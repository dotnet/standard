// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Microsoft.DotNet.Build.Tasks
{
    public partial class HandlePackageFileConflicts : Task
    {
        static readonly char[] s_manifestLineSeparator = new[] { '|' };
        private Dictionary<string, int> packageRanks = null;
        private Dictionary<string, ConflictItem> platformRuntimeByFileName = new Dictionary<string, ConflictItem>(StringComparer.OrdinalIgnoreCase);
        private Dictionary<string, ConflictItem> runtimeItemsByTargetPath = new Dictionary<string, ConflictItem>(StringComparer.OrdinalIgnoreCase);

        public ITaskItem[] References { get; set; }

        public ITaskItem[] ReferenceCopyLocalPaths { get; set; }

        public ITaskItem[] PlatformItems { get; set; }

        public ITaskItem[] PlatformManifests { get; set; }

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
            var referencesWithoutConflicts = HandleReferenceConflicts(References);

            LoadPlatform();

            // remove References that will conflict in output or with platform items.
            referencesWithoutConflicts = HandleRuntimeConflicts(referencesWithoutConflicts, ConflictItemType.Reference, ItemUtilities.GetReferenceTargetPath);

            // remove ReferenceCopyLocalPaths that will conflict in output or with platform items.
            var referenceCopyLocalPathsWithoutConflicts = HandleRuntimeConflicts(ReferenceCopyLocalPaths, ConflictItemType.CopyLocal, ItemUtilities.GetTargetPath);

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

        private int GetPackageRank(ConflictItem item)
        {
            int rank = int.MaxValue;

            if (item.PackageId != null && PreferredPackages != null)
            {
                EnsurePackageRanks();

                packageRanks.TryGetValue(item.PackageId, out rank);
            }

            return rank;
        }

        /// <summary>
        /// Examines items for conflicting keys and chooses the best item.
        /// </summary>
        /// <param name="items">Items from which to remove conflicts</param>
        /// <returns>Items without conflicts</returns>
        private ITaskItem[] HandleReferenceConflicts(ITaskItem[] items)
        {
            Dictionary<string, ConflictItem> referenceByName = new Dictionary<string, ConflictItem>(StringComparer.OrdinalIgnoreCase);

            return HandleConflicts(items, ConflictItemType.Reference, ItemUtilities.GetReferenceFileName, referenceByName);
        }

        /// <summary>
        /// Examines items for conflicting keys and chooses the best item.
        /// </summary>
        /// <param name="items">Items from which to remove conflicts</param>
        /// <param name="itemType">Type of items represented by <paramref name="items"/></param>
        /// <param name="getItemKey">Delegate to calculate key for an item</param>
        /// <returns>Items without conflicts</returns>
        private ITaskItem[] HandleRuntimeConflicts(ITaskItem[] items, ConflictItemType itemType, Func<ITaskItem, string> getItemKey)
        {
            return HandleConflicts(items, itemType, getItemKey, runtimeItemsByTargetPath, checkPlatform:true);
        }

        /// <summary>
        /// Examines items for conflicting keys and chooses the best item.
        /// </summary>
        /// <param name="items">Items from which to remove conflicts</param>
        /// <param name="itemType">Type of items represented by <paramref name="items"/></param>
        /// <param name="getItemKey">Delegate to calculate key for an item</param>
        /// <param name="winningItemsByKey">Dictionary of items by key without conflicts</param>
        /// <param name="checkPlatform">If items should be checked for conflicts against platform items</param>
        /// <returns>Items without conflicts</returns>
        private ITaskItem[] HandleConflicts(ITaskItem[] items,
                                            ConflictItemType itemType,
                                            Func<ITaskItem, string> getItemKey,
                                            Dictionary<string, ConflictItem> winningItemsByKey,
                                            bool checkPlatform = false)
        {
            if (items == null)
            {
                return items;
            }

            // ensure we use reference equality and not any overridden equality operators on items
            var conflictsToRemove = new HashSet<ITaskItem>(ReferenceComparer<ITaskItem>.Instance);

            foreach (var item in items)
            {
                var itemKey = getItemKey(item);

                if (String.IsNullOrEmpty(itemKey))
                {
                    continue;
                }

                ConflictItem existingItem, conflictItem = new ConflictItem(item, itemType);

                if (checkPlatform && HandleExternalConflict(conflictItem))
                {
                    conflictsToRemove.Add(item);
                    continue;
                }

                if (winningItemsByKey.TryGetValue(itemKey, out existingItem))
                {
                    // a conflict was found, determine the winner.
                    var winner = HandleConflict(existingItem, conflictItem);

                    if (winner == null)
                    {
                        // no winner, skip it.
                        // don't add to conflict list and just use the existing item for future conflicts.
                        continue;
                    }

                    if (!ReferenceEquals(winner, existingItem))
                    {
                        // replace existing item
                        winningItemsByKey[itemKey] = conflictItem;

                        if (existingItem.ItemType == itemType)
                        {
                            if (existingItem.OriginalItem != null)
                            {
                                // same type as we're currently processing remove it from item list
                                conflictsToRemove.Add(existingItem.OriginalItem);
                            }
                        }
                        else if (existingItem.ItemType == ConflictItemType.Reference)
                        {
                            if (existingItem.OriginalItem != null)
                            {
                                // Existing item is a Reference and winning item is CopyLocal or External
                                // make the Reference not private, so that it will not copy-local
                                existingItem.OriginalItem.SetMetadata("Private", "False");
                            }
                        }
                        else
                        {
                            throw new InvalidOperationException($"Internal error. Cannot remove item from {existingItem.ItemType} when processing {itemType}.");
                        }
                    }
                    else
                    {
                        // no need to replace item, just add new item to conflict list.
                        conflictsToRemove.Add(item);
                    }
                }
                else
                {
                    winningItemsByKey[itemKey] = conflictItem;
                }
            }

            return RemoveConflicts(items, conflictsToRemove);
        }

        private ConflictItem HandleConflict(ConflictItem item1, ConflictItem item2)
        {
            bool unused;
            return HandleConflict(item1, item2, out unused);
        }

        private ConflictItem HandleConflict(ConflictItem item1, ConflictItem item2, out bool equal)
        {
            equal = false;
            var conflictMessage = $"Encountered conflict between {item1.DisplayName} and {item2.DisplayName}.";

            var exists1 = item1.Exists;
            var exists2 = item2.Exists;

            if (!exists1 || !exists2)
            {
                var fileMessage = !exists1 ?
                                    !exists2 ? 
                                      "both files do" :
                                      $"{item1.DisplayName} does" :
                                  $"{item2.DisplayName} does";

                Log.LogMessage($"{conflictMessage}.  Could not determine winner because {fileMessage} not exist.");
                return null;
            }

            var assemblyVersion1 = item1.AssemblyVersion;
            var assemblyVersion2 = item2.AssemblyVersion;

            // if only one is missing version stop: something is wrong when we have a conflict between assembly and non-assembly
            if (assemblyVersion1 == null ^ assemblyVersion2 == null)
            {
                var nonAssembly = assemblyVersion1 == null ? item1.DisplayName : item2.DisplayName;
                Log.LogMessage($"{conflictMessage}. Could not determine a winner because {nonAssembly} is not an assembly.");
                return null;
            }

            // only handle cases where assembly version is different, and not null (implicit here due to xor above)
            if (assemblyVersion1 != assemblyVersion2)
            {
                if (assemblyVersion1 > assemblyVersion2)
                {
                    Log.LogMessage($"{conflictMessage}.  Choosing {item1.DisplayName} because AssemblyVersion {assemblyVersion1} is greater than {assemblyVersion2}.");
                    return item1;
                }

                if (assemblyVersion2 > assemblyVersion1)
                {
                    Log.LogMessage($"{conflictMessage}.  Choosing {item2.DisplayName} because AssemblyVersion {assemblyVersion2} is greater than {assemblyVersion1}.");
                    return item2;
                }
            }

            var fileVersion1 = item1.FileVersion;
            var fileVersion2 = item2.FileVersion;

            // if only one is missing version
            if (fileVersion1 == null ^ fileVersion2 == null)
            {
                var nonVersion = fileVersion1 == null ? item1.DisplayName : item2.DisplayName;
                Log.LogMessage($"{conflictMessage}. Could not determine a winner because {nonVersion} has no file version.");
                return null;
            }

            if (fileVersion1 != fileVersion2)
            {
                if (fileVersion1 > fileVersion2)
                {
                    Log.LogMessage($"{conflictMessage}.  Choosing {item1.DisplayName} because file version {fileVersion1} is greater than {fileVersion2}.");
                    return item1;
                }

                if (fileVersion2 > fileVersion1)
                {
                    Log.LogMessage($"{conflictMessage}.  Choosing {item2.DisplayName} because file version {fileVersion2} is greater than {fileVersion1}.");
                    return item2;
                }
            }

            var packageRank1 = GetPackageRank(item1);
            var packageRank2 = GetPackageRank(item2);

            if (packageRank1 < packageRank2)
            {
                Log.LogMessage($"{conflictMessage}.  Choosing {item1.DisplayName} because package it comes from a package that is preferred.");
                return item1;
            }

            if (packageRank2 < packageRank1)
            {
                Log.LogMessage($"{conflictMessage}.  Choosing {item2.DisplayName} because package it comes from a package that is preferred.");
                return item2;
            }

            Log.LogMessage($"{conflictMessage}.  Could not determine winner due to equal file and assembly versions.");
            equal = true;
            return null;
        }

        private bool HandleExternalConflict(ConflictItem item)
        {
            ConflictItem platformItem;

            if (platformRuntimeByFileName.TryGetValue(item.FileName, out platformItem))
            {
                bool equal;
                var winner = HandleConflict(item, platformItem, out equal);

                if (winner == platformItem || equal)
                {
                    return true;
                }
                else if (winner == item)
                {
                    platformRuntimeByFileName.Remove(item.FileName);
                }
            }

            return false;
        }

        private void LoadPlatform()
        {
            IEnumerable<ConflictItem> platformItems = Enumerable.Empty<ConflictItem>();

            if (PlatformItems != null)
            {
                platformItems = platformItems.Concat(PlatformItems.Select(e => new ConflictItem(e, ConflictItemType.Platform)));
            }

            if (PlatformManifests != null)
            {
                platformItems = platformItems.Concat(PlatformManifests.SelectMany(manifestItem => LoadPlatformManifest(manifestItem.GetMetadata("FullPath"))));
            }

            foreach (var platformItem in platformItems)
            {
                ConflictItem existingItem;

                if (!platformRuntimeByFileName.TryGetValue(platformItem.FileName, out existingItem) ||
                    HandleConflict(existingItem, platformItem) == platformItem)
                {
                    // we only care about the winners for platform items
                    // the losers are redundant since we only use this map
                    // to determine if Reference/CopyLocal should be trimmed.
                    platformRuntimeByFileName[platformItem.FileName] = platformItem;
                }
            }
        }

        private IEnumerable<ConflictItem> LoadPlatformManifest(string manifestPath)
        {
            if (manifestPath == null)
            {
                throw new ArgumentNullException(nameof(manifestPath));
            }

            if (!File.Exists(manifestPath))
            {
                Log.LogError($"Could not load {nameof(PlatformManifests)} from {manifestPath} because it did not exist");
                yield break;
            }

            using (var manfiestStream = File.Open(manifestPath, FileMode.Open, FileAccess.Read, FileShare.Read | FileShare.Delete))
            using (var manifestReader = new StreamReader(manfiestStream))
            {
                for (int lineNumber = 0; !manifestReader.EndOfStream; lineNumber++)
                {
                    var line = manifestReader.ReadLine().Trim();

                    if (line.Length == 0 || line[0] == '#')
                    {
                        continue;
                    }

                    var lineParts = line.Split(s_manifestLineSeparator);

                    if (lineParts.Length != 4)
                    {
                        Log.LogError($"Error parsing {nameof(PlatformManifests)} from {manifestPath} line {lineNumber}.  Lines must have the format fileName|packageId|assemblyVersion|fileVersion");
                        yield break;
                    }

                    var fileName = lineParts[0].Trim();
                    var packageId = lineParts[1].Trim();
                    var assemblyVersionString = lineParts[2].Trim();
                    var fileVersionString = lineParts[3].Trim();

                    Version assemblyVersion = null, fileVersion = null;

                    if (assemblyVersionString.Length != 0 && !Version.TryParse(assemblyVersionString, out assemblyVersion))
                    {
                        Log.LogError($"Error parsing {nameof(PlatformManifests)} from {manifestPath} line {lineNumber}.  AssemblyVersion {assemblyVersionString} was invalid.");
                    }

                    if (fileVersionString.Length != 0 && !Version.TryParse(fileVersionString, out fileVersion))
                    {
                        Log.LogError($"Error parsing {nameof(PlatformManifests)} from {manifestPath} line {lineNumber}.  FileVersion {fileVersionString} was invalid.");
                    }

                    yield return new ConflictItem(fileName, packageId, assemblyVersion, fileVersion);
                }
            }
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

    }
}
