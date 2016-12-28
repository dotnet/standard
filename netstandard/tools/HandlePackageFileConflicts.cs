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
        [Required]
        public ITaskItem[] ResolvedReferences { get; set; }

        [Required]
        public ITaskItem[] ResolvedCopyLocalItems { get; set; }

        [Output]
        public ITaskItem[] ConflictingReferences { get; set; }

        [Output]
        public ITaskItem[] ConflictingCopyLocalItems { get; set; }

        public override bool Execute()
        {
            var conflictingReferences = new List<ITaskItem>();
            HandleConflicts(ResolvedReferences, conflictingReferences);
            ConflictingReferences = conflictingReferences.ToArray();

            var conflictingCopyLocalItems = new List<ITaskItem>();
            HandleConflicts(ResolvedCopyLocalItems, conflictingCopyLocalItems);
            ConflictingCopyLocalItems = conflictingCopyLocalItems.ToArray();

            return !Log.HasLoggedErrors;
        }

        void HandleConflicts(ITaskItem[] items, ICollection<ITaskItem> conflicts)
        {
            var targetPathToItem = new Dictionary<string, ITaskItem>(StringComparer.OrdinalIgnoreCase);
            foreach (var item in items)
            {
                var targetPath = GetTargetPath(item);

                ITaskItem existingItem;

                if (targetPathToItem.TryGetValue(targetPath, out existingItem))
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
                        targetPathToItem[targetPath] = item;
                        conflicts.Add(existingItem);
                    }
                    else
                    {
                        // no need to replace item, just add new item to conflict list.
                        conflicts.Add(item);
                    }
                }
                else
                {
                    targetPathToItem[targetPath] = item;
                }
            }
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

        private static string GetSourcePath(ITaskItem item)
        {
            var sourcePath = item.GetMetadata("HintPath");

            if (String.IsNullOrWhiteSpace(sourcePath))
            {
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
            
            var assemblyVersion1 = GetAssemblyVersion(sourcePath1);
            var assemblyVersion2 = GetAssemblyVersion(sourcePath2);

            // if only one is missing version
            if (assemblyVersion1 == null ^ assemblyVersion2 == null)
            {
                var nonAssembly = assemblyVersion1 == null ? item1.ItemSpec : item2.ItemSpec;
                Log.LogMessage($"{conflictMessage}. Could not determine a winner because {nonAssembly} is not an assembly.");
                return null;
            }

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

            Log.LogMessage($"{conflictMessage}.  Could not determine winner due to equal file and assembly versions.");
            return null;
        }
    }
}
