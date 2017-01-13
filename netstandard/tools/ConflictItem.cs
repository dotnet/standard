// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Build.Framework;
using System;
using System.IO;

namespace Microsoft.DotNet.Build.Tasks
{
    internal enum ConflictItemType
    {
        Reference,
        CopyLocal,
        External
    }

    // Wraps an ITask item and adds lazy evaluated properties used by Conflict resolution.
    internal class ConflictItem
    {
        public ConflictItem(ITaskItem originalItem, ConflictItemType itemType)
        {
            OriginalItem = originalItem;
            ItemType = itemType;
        }

        private bool hasAssemblyVersion;
        private Version assemblyVersion;
        public Version AssemblyVersion
        {
            get
            {
                if (!hasAssemblyVersion)
                {
                    if (ItemType == ConflictItemType.External)
                    {
                        assemblyVersion = null;

                        var assemblyVersionString = OriginalItem.GetMetadata(nameof(AssemblyVersion));

                        if (assemblyVersionString.Length != 0)
                        {
                            Version.TryParse(assemblyVersionString, out assemblyVersion);
                        }
                    }
                    else
                    {
                        assemblyVersion = FileUtilities.TryGetAssemblyVersion(SourcePath);
                    }

                    // assemblyVersion may be null but don't try to recalculate it
                    hasAssemblyVersion = true;
                }

                return assemblyVersion;
            }
        }

        public ConflictItemType ItemType { get; }

        private bool? exists;
        public bool Exists
        {
            get
            {
                if (exists == null)
                {
                    exists = ItemType == ConflictItemType.External || File.Exists(SourcePath);
                }

                return exists.Value;
            }
        }

        private string fileName;
        public string FileName
        {
            get
            {
                if (fileName == null)
                {
                    fileName = OriginalItem.GetMetadata("FileName") + OriginalItem.GetMetadata("Extension");
                }
                return fileName;
            }
        }

        private bool hasFileVersion;
        private Version fileVersion;
        public Version FileVersion
        {
            get
            {
                if (!hasFileVersion)
                {
                    if (ItemType == ConflictItemType.External)
                    {
                        fileVersion = null;

                        var fileVersionString = OriginalItem.GetMetadata(nameof(FileVersion));

                        if (fileVersionString.Length != 0)
                        {
                            Version.TryParse(fileVersionString, out fileVersion);
                        }
                    }
                    else
                    {
                        fileVersion = FileUtilities.GetFileVersion(SourcePath);
                    }

                    // fileVersion may be null but don't try to recalculate it
                    hasFileVersion = true;
                }

                return fileVersion;
            }
        }

        public ITaskItem OriginalItem { get; }

        private string packageId;
        public string PackageId
        {
            get
            {
                if (packageId == null)
                {
                    packageId = OriginalItem.GetMetadata("NuGetPackageId") ?? String.Empty;
                }

                return packageId.Length == 0 ? null : packageId;
            }
        }
        

        private string sourcePath;
        public string SourcePath
        {
            get
            {
                if (sourcePath == null)
                {
                    sourcePath = ItemUtilities.GetSourcePath(OriginalItem) ?? String.Empty;
                }

                return sourcePath.Length == 0 ? null : sourcePath;
            }
        }
        
        public string displayName;
        public string DisplayName
        {
            get
            {
                if (displayName == null)
                {
                    displayName = $"{ItemType}:{OriginalItem.ItemSpec}";
                }
                return displayName;
            }
        }
    }
}
