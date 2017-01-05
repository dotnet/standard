// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace Microsoft.DotNet.Build.Tasks
{
    public partial class HandlePackageFileConflicts : Task
    {
        private Dictionary<string, int> packageRanks = null;

        [Required]
        public ITaskItem[] References { get; set; }

        [Required]
        public ITaskItem[] ReferenceCopyLocalPaths { get; set; }

        /// <summary>
        /// NuGet3 and later only.  In the case of a conflict with identical file version information a file from the most preferred package will be chosen.
        /// </summary>
        public string[] PreferredPackages { get; set; }

        [Output]
        public ITaskItem[] ReferencesWithoutConflicts { get; set; }

        [Output]
        public ITaskItem[] ReferenceCopyLocalPathsWithoutConflicts { get; set; }

        public override bool Execute()
        {
            ReferencesWithoutConflicts = HandleConflicts(References, GetReferenceKey);

            ReferenceCopyLocalPathsWithoutConflicts = HandleConflicts(ReferenceCopyLocalPaths, GetTargetPath);

            return !Log.HasLoggedErrors;
        }

        private void EnsurePackageRanks()
        {
            if (packageRanks == null)
            {
                var numPreferredPackages = PreferredPackages?.Length ?? 0;

                // cache ranks for fast lookup
                packageRanks = new Dictionary<string, int>(numPreferredPackages, StringComparer.OrdinalIgnoreCase);

                for (int i = numPreferredPackages - 1; i >= 0 ; i--)
                {
                    var preferredPackageId = PreferredPackages[i].Trim();

                    if (preferredPackageId.Length != 0)
                    {
                        // overwrite any duplicates, lowest rank will win.
                        packageRanks[preferredPackageId] = i;
                    }
                }
            }
        }

        /// <summary>
        /// Examines items for conflicting targetpath and chooses the best item.
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        private ITaskItem[] HandleConflicts(ITaskItem[] items, Func<ITaskItem, string> getItemKey)
        {
            var winningItems = new Dictionary<string, ITaskItem>(StringComparer.OrdinalIgnoreCase);
            // ensure we use reference equality and not any overridden equality operators on items
            var conflictsToRemove = new HashSet<ITaskItem>(ReferenceComparer<ITaskItem>.Instance);

            foreach (var item in items)
            {
                var itemKey = getItemKey(item);

                if (itemKey == null)
                {
                    continue;
                }

                ITaskItem existingItem;

                if (winningItems.TryGetValue(itemKey, out existingItem))
                {
                    // a conflict was found, determine the winner.
                    var winner = HandleConflict(existingItem, item);

                    if (winner == null)
                    {
                        // no winner, skip it.
                        // don't add to conflict list and just use the existing item for future conflicts.
                        continue;
                    }

                    if (winner != existingItem)
                    {
                        // replace existing item and add it to conflict list.
                        winningItems[itemKey] = item;
                        conflictsToRemove.Add(existingItem);
                    }
                    else
                    {
                        // no need to replace item, just add new item to conflict list.
                        conflictsToRemove.Add(item);
                    }
                }
                else
                {
                    winningItems[itemKey] = item;
                }
            }

            return RemoveConflicts(items, conflictsToRemove);
        }

        private Version GetFileVersion(string sourcePath)
        {
            var fvi = FileVersionInfo.GetVersionInfo(sourcePath);

            if (fvi != null)
            {
                return new Version(fvi.FileMajorPart, fvi.FileMinorPart, fvi.FileBuildPart, fvi.FilePrivatePart);
            }

            return null;
        }

        private int GetPackageRank(ITaskItem item)
        {
            int rank = int.MaxValue;

            // NuGet 3
            var packageId = item.GetMetadata("NuGetPackageId");

            if (String.IsNullOrWhiteSpace(packageId))
            {
                // NuGet 4
                packageId = item.GetMetadata("ParentPackage");

                var versionSeparatorIndex = packageId.IndexOf('/');

                if (versionSeparatorIndex != -1)
                {
                    packageId = packageId.Substring(0, versionSeparatorIndex);
                }
            }

            if (!String.IsNullOrWhiteSpace(packageId) && PreferredPackages != null)
            {
                EnsurePackageRanks();

                packageRanks.TryGetValue(packageId, out rank);
            }

            return rank;
        }

        /// <summary>
        /// Get's the key to use for identifying reference conflicts
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private static string GetReferenceKey(ITaskItem item)
        {
            var aliases = item.GetMetadata("Aliases");

            if (!String.IsNullOrEmpty(aliases))
            {
                // skip conflict detection for aliased assemblies
                return null;
            }

            // We only handle references that have path information since we're only concerned
            // with resolving conflicts between file references.  If conflicts exist between 
            // named references that are found from AssemblySearchPaths we'll leave those to
            // RAR to handle or not as it sees fit.
            var sourcePath = GetSourcePath(item);

            if (String.IsNullOrEmpty(sourcePath))
            {
                return null;
            }

            // The following is similar to Path.GetFileName but does not throw and returns null
            // rather than empty for a directory.
            var length = sourcePath.Length;
            for (int i = length - 1; --i >= 0;)
            {
                var ch = sourcePath[i];

                if (ch == Path.DirectorySeparatorChar || ch == Path.AltDirectorySeparatorChar || ch == Path.VolumeSeparatorChar)
                {
                    // string terminated with a separator: we were given a directory, ignore it.
                    if (i == length - 1)
                    {
                        return null;
                    }

                    // we found a separator, return filename portion.
                    var startOfFileName = i + 1;
                    return sourcePath.Substring(startOfFileName);
                }
            }

            // could not find a separator, return source path
            return sourcePath;
        }

        private static string GetSourcePath(ITaskItem item)
        {
            var sourcePath = item.GetMetadata("HintPath");

            if (String.IsNullOrWhiteSpace(sourcePath))
            {
                // assume item-spec points to the file.
                // this won't work if it comes from a targeting pack or SDK, but
                // in that case the file won't exist and we'll skip it.
                sourcePath = item.ItemSpec;
            }

            return sourcePath;
        }

        static readonly string[] s_targetPathMetadata = new[] { "TargetPath", "Path" };
        private static string GetTargetPath(ITaskItem item)
        {
            // first use TargetPath, then Path, then fallback to filename+extension alone
            foreach (var metadata in s_targetPathMetadata)
            {
                var value = item.GetMetadata(metadata);

                if (!String.IsNullOrWhiteSpace(value))
                {
                    // normalize path
                    return value.Replace('\\', '/');
                }
            }

            var sourcePath = GetSourcePath(item);

            return Path.GetFileName(sourcePath);
        }

        private ITaskItem HandleConflict(ITaskItem item1, ITaskItem item2)
        {
            var conflictMessage = $"Encountered conflict between {item1.ItemSpec} and {item2.ItemSpec}.";

            var sourcePath1 = GetSourcePath(item1);
            var sourcePath2 = GetSourcePath(item2);

            var exists1 = File.Exists(sourcePath1);
            var exists2 = File.Exists(sourcePath2);

            if (!exists1 || !exists2)
            {
                var fileMessage = !exists1 ?
                                    !exists2 ? 
                                      "both files do" :
                                      $"{item1.ItemSpec} does" :
                                  $"{item2.ItemSpec} does";

                Log.LogMessage($"{conflictMessage}.  Could not determine winner because {fileMessage} not exist.");
                return null;
            }
            
            var assemblyVersion1 = TryGetAssemblyVersion(sourcePath1);
            var assemblyVersion2 = TryGetAssemblyVersion(sourcePath2);

            // if only one is missing version stop: something is wrong when we have a conflict between assembly and non-assembly
            if (assemblyVersion1 == null ^ assemblyVersion2 == null)
            {
                var nonAssembly = assemblyVersion1 == null ? item1.ItemSpec : item2.ItemSpec;
                Log.LogMessage($"{conflictMessage}. Could not determine a winner because {nonAssembly} is not an assembly.");
                return null;
            }

            // only handle cases where assembly version is different, and not null (implicit here due to xor above)
            if (assemblyVersion1 != assemblyVersion2)
            {
                if (assemblyVersion1 > assemblyVersion2)
                {
                    Log.LogMessage($"{conflictMessage}.  Choosing {item1.ItemSpec} because AssemblyVersion {assemblyVersion1} is greater than {assemblyVersion2}.");
                    return item1;
                }

                if (assemblyVersion2 > assemblyVersion1)
                {
                    Log.LogMessage($"{conflictMessage}.  Choosing {item2.ItemSpec} because AssemblyVersion {assemblyVersion2} is greater than {assemblyVersion1}.");
                    return item2;
                }
            }

            var fileVersion1 = GetFileVersion(sourcePath1);
            var fileVersion2 = GetFileVersion(sourcePath2);

            // if only one is missing version
            if (fileVersion1 == null ^ fileVersion2 == null)
            {
                var nonVersion = fileVersion1 == null ? item1.ItemSpec : item2.ItemSpec;
                Log.LogMessage($"{conflictMessage}. Could not determine a winner because {nonVersion} has no file version.");
                return null;
            }

            if (fileVersion1 != fileVersion2)
            {
                if (fileVersion1 > fileVersion2)
                {
                    Log.LogMessage($"{conflictMessage}.  Choosing {item1.ItemSpec} because file version {fileVersion1} is greater than {fileVersion2}.");
                    return item1;
                }

                if (fileVersion2 > fileVersion1)
                {
                    Log.LogMessage($"{conflictMessage}.  Choosing {item2.ItemSpec} because file version {fileVersion2} is greater than {fileVersion1}.");
                    return item2;
                }
            }

            var packageRank1 = GetPackageRank(item1);
            var packageRank2 = GetPackageRank(item2);

            if (packageRank1 < packageRank2)
            {
                Log.LogMessage($"{conflictMessage}.  Choosing {item1.ItemSpec} because package it comes from a package that is preferred.");
                return item1;
            }

            if (packageRank2 < packageRank1)
            {
                Log.LogMessage($"{conflictMessage}.  Choosing {item2.ItemSpec} because package it comes from a package that is preferred.");
                return item2;
            }

            Log.LogMessage($"{conflictMessage}.  Could not determine winner due to equal file and assembly versions.");
            return null;
        }

        /// <summary>
        /// Filters conflicts from original, maintaining order.
        /// </summary>
        /// <param name="original"></param>
        /// <param name="conflicts"></param>
        /// <returns></returns>
        private ITaskItem[] RemoveConflicts(ITaskItem[] original, ICollection<ITaskItem> conflicts)
        {
            if (conflicts.Count == 0)
            {
                return original;
            }

            var result = new ITaskItem[original.Length - conflicts.Count];
            int index = 0;

            foreach(var originalItem in original)
            {
                if (!conflicts.Contains(originalItem))
                {
                    if (index >= result.Length)
                    {
                        throw new ArgumentException($"Items from {nameof(conflicts)} were missing from {nameof(original)}");
                    }
                    result[index++] = originalItem;
                }
            }

            return result;
        }

        static readonly HashSet<string> s_assemblyExtensions = new HashSet<string>(new[] { ".dll", ".exe", ".winmd" }, StringComparer.OrdinalIgnoreCase);
        private static Version TryGetAssemblyVersion(string sourcePath)
        {
            var extension = Path.GetExtension(sourcePath);

            return s_assemblyExtensions.Contains(extension) ? GetAssemblyVersion(sourcePath) : null;
        }
    }
}
