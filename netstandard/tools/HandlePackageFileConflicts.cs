// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using System;
using System.Collections.Generic;
using System.IO;

namespace Microsoft.DotNet.Build.Tasks
{
    public partial class HandlePackageFileConflicts : Task
    {
        private Dictionary<string, int> packageRanks = null;

        public ITaskItem[] References { get; set; }
        
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
            var referencesWithoutConflicts = HandleConflicts(References, ItemUtilities.GetReferenceFileName);

            // remove References that will conflict in output
            Dictionary<string, ITaskItem> referencesByTargetPath;
            referencesWithoutConflicts = HandleConflicts(referencesWithoutConflicts, ItemUtilities.GetReferenceTargetPath, out referencesByTargetPath);

            // remove ReferenceCopyLocalPaths that will conflict in output.
            Dictionary<string, ITaskItem> referenceCopyLocalPathsByTargetPath;
            var referenceCopyLocalPathsWithoutConflicts = HandleConflicts(ReferenceCopyLocalPaths, ItemUtilities.GetTargetPath, out referenceCopyLocalPathsByTargetPath);

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

        private int GetPackageRank(ITaskItem item)
        {
            int rank = int.MaxValue;

            var packageId = item.GetMetadata("NuGetPackageId");

            if (!String.IsNullOrWhiteSpace(packageId) && PreferredPackages != null)
            {
                EnsurePackageRanks();

                packageRanks.TryGetValue(packageId, out rank);
            }

            return rank;
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

        private ITaskItem HandleConflict(ITaskItem item1, ITaskItem item2)
        {
            var conflictMessage = $"Encountered conflict between {item1.ItemSpec} and {item2.ItemSpec}.";

            var sourcePath1 = ItemUtilities.GetSourcePath(item1);
            var sourcePath2 = ItemUtilities.GetSourcePath(item2);

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
            
            var assemblyVersion1 = FileUtilities.TryGetAssemblyVersion(sourcePath1);
            var assemblyVersion2 = FileUtilities.TryGetAssemblyVersion(sourcePath2);

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

            var fileVersion1 = FileUtilities.GetFileVersion(sourcePath1);
            var fileVersion2 = FileUtilities.GetFileVersion(sourcePath2);

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

    }
}
