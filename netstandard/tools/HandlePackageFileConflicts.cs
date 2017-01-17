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

        public ITaskItem[] References { get; set; }

        public ITaskItem[] ReferenceCopyLocalPaths { get; set; }
        
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
            var log = new MSBuildLog(Log);
            var packageRanks = new PackageRank(PreferredPackages);

            var referenceItems = References.Select(r => new ConflictTaskItem(r, ConflictItemType.Reference)).ToArray();

            var compileConflictScope = new ConflictResolver(packageRanks, log);

            compileConflictScope.ResolveConflicts(referenceItems, 
                ci => ItemUtilities.GetReferenceFileName(ci.OriginalItem),
                HandleCompileConflict);

            var runtimeConflictScope = new ConflictResolver(packageRanks, log);

            runtimeConflictScope.ResolveConflicts(referenceItems,
                ci => ItemUtilities.GetReferenceTargetPath(ci.OriginalItem),
                HandleRuntimeConflict);

            var copyLocalItems = ReferenceCopyLocalPaths.Select(c => new ConflictTaskItem(c, ConflictItemType.CopyLocal)).ToArray();

            runtimeConflictScope.ResolveConflicts(copyLocalItems,
                ci => ItemUtilities.GetTargetPath(ci.OriginalItem),
                HandleRuntimeConflict);

            var platformConflictScope = new ConflictResolver(packageRanks, log);
            var platformItems = PlatformManifests.SelectMany(pm => ConflictPlatformItem.LoadPlatformManifest(pm.ItemSpec, log));

            platformConflictScope.ResolveConflicts(platformItems, pi => pi.FileName, pi => { });
            platformConflictScope.ResolveConflicts(referenceItems.Where(ri => !referenceConflicts.Contains(ri.OriginalItem)),
                                                   ri => ri.FileName,
                                                   HandleRuntimeConflict);
            platformConflictScope.ResolveConflicts(copyLocalItems.Where(ci => !copyLocalConflicts.Contains(ci.OriginalItem)),
                                                   ri => ri.FileName,
                                                   HandleRuntimeConflict);

            ReferencesWithoutConflicts = RemoveConflicts(References, referenceConflicts);
            ReferenceCopyLocalPathsWithoutConflicts = RemoveConflicts(ReferenceCopyLocalPaths, copyLocalConflicts);

            return !Log.HasLoggedErrors;
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
                else
                {
                    copyLocalConflicts.Add(conflictTaskItem.OriginalItem);
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
