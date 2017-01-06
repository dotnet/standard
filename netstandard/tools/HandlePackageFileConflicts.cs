// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

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
            // remove References that will conflict at compile
            var referencesWithoutConflicts = HandleConflicts(References, GetReferenceKey);

            // remove References that will conflict in output
            Dictionary<string, ITaskItem> referencesByTargetPath;
            referencesWithoutConflicts = HandleConflicts(referencesWithoutConflicts, GetReferenceTargetPath, out referencesByTargetPath);

            // remove ReferenceCopyLocalPaths that will conflict in output.
            Dictionary<string, ITaskItem> referenceCopyLocalPathsByTargetPath;
            var referenceCopyLocalPathsWithoutConflicts = HandleConflicts(ReferenceCopyLocalPaths, GetTargetPath, out referenceCopyLocalPathsByTargetPath);

            // remove ReferenceCopyLocalPaths & set References to Private=false that will conflict in output.
            referenceCopyLocalPathsWithoutConflicts = HandleConflicts(referenceCopyLocalPathsWithoutConflicts, referenceCopyLocalPathsByTargetPath, referencesByTargetPath);

            ReferencesWithoutConflicts = referencesWithoutConflicts;
            ReferenceCopyLocalPathsWithoutConflicts = referenceCopyLocalPathsWithoutConflicts;

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
        /// Examines items for conflicting keys and chooses the best item.
        /// </summary>
        /// <param name="items">Items from which to remove conflicts</param>
        /// <param name="getItemKey">Delegate to calculate key for an item</param>
        /// <returns>Items without conflicts</returns>
        private ITaskItem[] HandleConflicts(ITaskItem[] items, Func<ITaskItem, string> getItemKey)
        {
            Dictionary<string, ITaskItem> itemsByKeyUnused;

            return HandleConflicts(items, getItemKey, out itemsByKeyUnused);
        }

        /// <summary>
        /// Examines items for conflicting keys and chooses the best item.
        /// </summary>
        /// <param name="items">Items from which to remove conflicts</param>
        /// <param name="getItemKey">Delegate to calculate key for an item</param>
        /// <param name="winningItemsByKey">Dictionary of items by key without conflicts</param>
        /// <returns>Items without conflicts</returns>
        private ITaskItem[] HandleConflicts(ITaskItem[] items, Func<ITaskItem, string> getItemKey, out Dictionary<string, ITaskItem> winningItemsByKey)
        {
            winningItemsByKey = new Dictionary<string, ITaskItem>(StringComparer.OrdinalIgnoreCase);
            // ensure we use reference equality and not any overridden equality operators on items
            var conflictsToRemove = new HashSet<ITaskItem>(ReferenceComparer<ITaskItem>.Instance);

            foreach (var item in items)
            {
                var itemKey = getItemKey(item);

                if (String.IsNullOrEmpty(itemKey))
                {
                    continue;
                }

                ITaskItem existingItem;

                if (winningItemsByKey.TryGetValue(itemKey, out existingItem))
                {
                    // a conflict was found, determine the winner.
                    var winner = HandleConflict(existingItem, item);

                    if (winner == null)
                    {
                        // no winner, skip it.
                        // don't add to conflict list and just use the existing item for future conflicts.
                        continue;
                    }

                    if (!ReferenceEquals(winner, existingItem))
                    {
                        // replace existing item and add it to conflict list.
                        winningItemsByKey[itemKey] = item;
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
                    winningItemsByKey[itemKey] = item;
                }
            }

            return RemoveConflicts(items, conflictsToRemove);
        }

        /// <summary>
        /// Examines private (copy-local) references amd referenceCopyLocalPaths for inter-conflicts and
        /// demotes references to non-private or removes items from referenceCopyLocalPaths.
        /// </summary>
        /// <param name="referenceCopyLocalPaths">ReferenceCopyLocalPaths item, already filtered for intra-conflicts</param>
        /// <param name="referenceCopyLocalPathsByTargetPath">ReferenceCopyLocalPaths already filtered for intra-conflicts, indexed by TargetPath</param>
        /// <param name="referencesByTargetPath">References item for private references, already filtered for compile-time intra-conflicts and copy-local intra-conflicts, indexed by TargetPath.  Items within this collection will be modified as neecessary to handle conflicts with ReferenceCopyLocalPaths by making the reference Private=false.</param>
        /// <returns>ReferenceCopyLocalPaths item filtered for inter-conflicts with References</returns>
        private ITaskItem[] HandleConflicts(ITaskItem[] referenceCopyLocalPaths, Dictionary<string, ITaskItem> referenceCopyLocalPathsByTargetPath, Dictionary<string, ITaskItem> referencesByTargetPath)
        {
            if (referencesByTargetPath.Count == 0 || referenceCopyLocalPathsByTargetPath.Count == 0)
            {
                // nothing to do if either item set doesn't have targetpaths
                return referenceCopyLocalPaths;
            }

            // ensure we use reference equality and not any overridden equality operators on items
            var conflictsToRemove = new HashSet<ITaskItem>(ReferenceComparer<ITaskItem>.Instance);

            // find conflicts between the two, arbitrarily choose ref to iterate over
            foreach (var referenceByTargetPath in referencesByTargetPath)
            {
                var targetPath = referenceByTargetPath.Key;
                var reference = referenceByTargetPath.Value;

                ITaskItem referenceCopyLocalPath = null;

                if (referenceCopyLocalPathsByTargetPath.TryGetValue(targetPath, out referenceCopyLocalPath))
                {
                    // a conflict was found, determine the winner.
                    var winner = HandleConflict(reference, referenceCopyLocalPath);

                    if (winner == null)
                    {
                        // no winner, skip it.
                        continue;
                    }

                    if (ReferenceEquals(winner, referenceCopyLocalPath))
                    {
                        // ReferenceCopyLocalPath won, make the reference not private, so that it will not copy-local
                        reference.SetMetadata("Private", "False");
                    }
                    else
                    {
                        // Reference won, remove the copy-local item.
                        conflictsToRemove.Add(referenceCopyLocalPath);
                    }
                }
            }
            
            return RemoveConflicts(referenceCopyLocalPaths, conflictsToRemove);
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
                // skip compile-time conflict detection for aliased assemblies.
                // An alias is the way to avoid a conflict
                //   eg: System, v1.0.0.0 in global will not conflict with System, v2.0.0.0 in `private` alias
                // We could model each alias scope and try to check for conflicts within that scope,
                // but this is a ton of complexity for a fringe feature.
                // Instead, we'll treat an alias as an indication that the developer has opted out of 
                // conflict resolution.
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

            try
            {
                return Path.GetFileName(sourcePath);
            }
            catch(ArgumentException)
            {
                // We won't even try to resolve a conflict if we can't open the file, so ignore invalid paths
                return null;
            }
        }

        private static string GetReferenceTargetPath(ITaskItem item)
        {
            // Determine if the reference will be copied local.  
            // We're only dealing with primary file references.  For these RAR will 
            // copy local if Private is true or unset.

            var isPrivate = MSBuildUtilities.ConvertStringToBool(item.GetMetadata("Private"), defaultValue: true);

            if (!isPrivate)
            {
                // Private = false means the reference shouldn't be copied.
                return null;
            }

            return GetTargetPath(item);
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
