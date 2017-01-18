// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.DotNet.Build.Tasks
{
    public partial class HandlePackageFileConflicts : Task
    {
        HashSet<ITaskItem> referenceConflicts = new HashSet<ITaskItem>(ReferenceComparer<ITaskItem>.Instance);
        HashSet<ITaskItem> copyLocalConflicts = new HashSet<ITaskItem>(ReferenceComparer<ITaskItem>.Instance);
        HashSet<string> conflictPackages = new HashSet<string>();

        public ITaskItem[] References { get; set; }

        public ITaskItem[] ReferenceCopyLocalPaths { get; set; }

        public ITaskItem[] OtherRuntimeItems { get; set; }

        public ITaskItem[] PlatformManifests { get; set; }

        /// <summary>
        /// NuGet3 and later only.  In the case of a conflict with identical file version information a file from the most preferred package will be chosen.
        /// </summary>
        public string[] PreferredPackages { get; set; }

        [Output]
        public ITaskItem[] ReferencesWithoutConflicts { get; set; }

        [Output]
        public ITaskItem[] ReferenceCopyLocalPathsWithoutConflicts { get; set; }

        [Output]
        public ITaskItem[] ConflictPackages { get; set; }

        public override bool Execute()
        {
            var log = new MSBuildLog(Log);
            var packageRanks = new PackageRank(PreferredPackages);

            // resolve conflicts at compile time
            var referenceItems = GetConflictTaskItems(References, ConflictItemType.Reference).ToArray();

            var compileConflictScope = new ConflictResolver(packageRanks, log);

            compileConflictScope.ResolveConflicts(referenceItems, 
                ci => ItemUtilities.GetReferenceFileName(ci.OriginalItem),
                HandleCompileConflict);

            // resolve conflicts that class in output
            var runtimeConflictScope = new ConflictResolver(packageRanks, log);

            runtimeConflictScope.ResolveConflicts(referenceItems,
                ci => ItemUtilities.GetReferenceTargetPath(ci.OriginalItem),
                HandleRuntimeConflict);

            var copyLocalItems = GetConflictTaskItems(ReferenceCopyLocalPaths, ConflictItemType.CopyLocal).ToArray();

            runtimeConflictScope.ResolveConflicts(copyLocalItems,
                ci => ItemUtilities.GetTargetPath(ci.OriginalItem),
                HandleRuntimeConflict);

            var otherRuntimeItems = GetConflictTaskItems(OtherRuntimeItems, ConflictItemType.Runtime).ToArray();

            runtimeConflictScope.ResolveConflicts(otherRuntimeItems,
                ci => ItemUtilities.GetTargetPath(ci.OriginalItem),
                HandleRuntimeConflict);


            // resolve conflicts with platform (eg: shared framework) items
            // we only commit the platform items since its not a conflict if other items share the same filename.
            var platformConflictScope = new ConflictResolver(packageRanks, log);
            var platformItems = PlatformManifests?.SelectMany(pm => ConflictPlatformItem.LoadPlatformManifest(pm.ItemSpec, log)) ?? Enumerable.Empty<ConflictPlatformItem>();

            platformConflictScope.ResolveConflicts(platformItems, pi => pi.FileName, pi => { });
            platformConflictScope.ResolveConflicts(referenceItems.Where(ri => !referenceConflicts.Contains(ri.OriginalItem)),
                                                   ri => ItemUtilities.GetReferenceTargetFileName(ri.OriginalItem),
                                                   HandleRuntimeConflict,
                                                   commitWinner:false);
            platformConflictScope.ResolveConflicts(copyLocalItems.Where(ci => !copyLocalConflicts.Contains(ci.OriginalItem)),
                                                   ri => ri.FileName,
                                                   HandleRuntimeConflict,
                                                   commitWinner: false);
            platformConflictScope.ResolveConflicts(otherRuntimeItems,
                                                   ri => ri.FileName,
                                                   HandleRuntimeConflict,
                                                   commitWinner: false);

            ReferencesWithoutConflicts = RemoveConflicts(References, referenceConflicts);
            ReferenceCopyLocalPathsWithoutConflicts = RemoveConflicts(ReferenceCopyLocalPaths, copyLocalConflicts);
            ConflictPackages = conflictPackages.Select(p => new TaskItem(p)).ToArray();

            return !Log.HasLoggedErrors;
        }

        private IEnumerable<ConflictTaskItem> GetConflictTaskItems(ITaskItem[] items, ConflictItemType itemType)
        {
            return (items != null) ? items.Select(i => new ConflictTaskItem(i, itemType)) : Enumerable.Empty<ConflictTaskItem>();
        }

        private void HandleCompileConflict(IConflictItem conflictItem)
        {
            var conflictTaskItem = conflictItem as ConflictTaskItem;
            if (conflictTaskItem != null)
            {
                if (conflictTaskItem.ItemType == ConflictItemType.Reference)
                {
                    referenceConflicts.Add(conflictTaskItem.OriginalItem);
                }
            }

            if (conflictItem.PackageId != null)
            {
                conflictPackages.Add(conflictItem.PackageId);
            }
        }

        private void HandleRuntimeConflict(IConflictItem conflictItem)
        {
            var conflictTaskItem = conflictItem as ConflictTaskItem;
            if (conflictTaskItem != null)
            {
                if (conflictTaskItem.ItemType == ConflictItemType.Reference)
                {
                    conflictTaskItem.OriginalItem.SetMetadata("Private", "False");
                }
                else if (conflictTaskItem.ItemType == ConflictItemType.CopyLocal)
                {
                    copyLocalConflicts.Add(conflictTaskItem.OriginalItem);
                }
            }

            if (conflictItem.PackageId != null)
            {
                conflictPackages.Add(conflictItem.PackageId);
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

        private class MSBuildLog : ILog
        {
            private TaskLoggingHelper logger;
            public MSBuildLog(TaskLoggingHelper logger)
            {
                this.logger = logger;
            }

            public void LogError(string errorMessage)
            {
                logger.LogError(errorMessage);
            }

            public void LogMessage(string message)
            {
                logger.LogMessage(message);
            }
        }

    }
}
