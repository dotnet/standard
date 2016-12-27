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
            foreach (var metadata in s_targetPathMetadata)
            {
                var targetPath = item.GetMetadata("TargetPath");

                if (!String.IsNullOrWhiteSpace(targetPath))
                {
                    return targetPath.Replace('\\', '/');
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

            if (!exists1 && !exists2)
            {
                Log.LogMessage($"{conflictMessage}.  Could not determine winner because {sourcePath1} and {sourcePath2} do not exist.  Arbitrarily choosing {item1.ItemSpec}.");
                return item1;
            }

            if (exists1 && !exists2)
            {
                Log.LogMessage($"{conflictMessage}.  Choosing {item1.ItemSpec} because {sourcePath1} exists and {sourcePath2} does not.");
                return item1;
            }

            if (!exists1 && exists2)
            {
                Log.LogMessage($"{conflictMessage}.  Choosing {item2.ItemSpec} because {sourcePath2} exists and {sourcePath1} does not.");
                return item2;
            }

            var assemblyVersion1 = GetAssemblyVersion(sourcePath1);
            var assemblyVersion2 = GetAssemblyVersion(sourcePath2);

            if (assemblyVersion1 != null || assemblyVersion2 != null)
            {
                if (assemblyVersion1 == null)
                {
                    Log.LogMessage($"{conflictMessage}.  Choosing {item2.ItemSpec} because {sourcePath1} had no AssemblyVersion and {sourcePath2} did.");
                    return item2;
                }

                if (assemblyVersion2 == null)
                {
                    Log.LogMessage($"{conflictMessage}.  Choosing {item1.ItemSpec} because {sourcePath2} had no AssemblyVersion and {sourcePath1} did.");
                    return item1;
                }

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

                // if (assemblyVersion1 == assemblyVersion2) continue
            }

            var fileVersion1 = GetFileVersion(sourcePath1);
            var fileVersion2 = GetFileVersion(sourcePath2);

            if (fileVersion1 != null || fileVersion2 != null)
            {
                if (fileVersion1 == null)
                {
                    Log.LogMessage($"{conflictMessage}.  Choosing {item2.ItemSpec} because {sourcePath1} had no AssemblyVersion and {sourcePath2} did.");
                    return item2;
                }

                if (fileVersion2 == null)
                {
                    Log.LogMessage($"{conflictMessage}.  Choosing {item1.ItemSpec} because {sourcePath2} had no AssemblyVersion and {sourcePath1} did.");
                    return item1;
                }

                if (fileVersion1 > fileVersion2)
                {
                    Log.LogMessage($"{conflictMessage}.  Choosing {item1.ItemSpec} because FileVersion {fileVersion1} is greater than {fileVersion2}.");
                    return item1;
                }

                if (fileVersion2 > fileVersion1)
                {
                    Log.LogMessage($"{conflictMessage}.  Choosing {item2.ItemSpec} because FileVersion {fileVersion2} is greater than {fileVersion1}.");
                    return item2;
                }

                // if (fileVersion1 == fileVersion2) continue
            }

            Log.LogMessage($"{conflictMessage}.  Could not determine winner due to equal File and Assembly versions.  Arbitrarily choosing {item1.ItemSpec}.");
            return item1;
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
    }
}
