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
    public partial class TrimFiles : Task
    {
        /// <summary>
        /// Files to consider as a roots for trimming.  These files and their dependency closure will be preserved.
        /// Typically the project's output assembly.
        /// </summary>
        [Required]
        public ITaskItem[] RootFiles { get; set; }

        /// <summary>
        /// Packages to consider as roots for trimming.  These packages and their dependency closure will be preserved.
        /// Identity either package ID or packageID/version.
        /// </summary>
        [Required]
        public ITaskItem[] RootPackages { get; set; }

        /// <summary>
        /// Optional additional packages which can be trimmed.  Default is common meta-packages.
        /// Identity is package ID.
        /// </summary>
        public ITaskItem[] TrimmablePackages { get; set; }

        /// <summary>
        /// Optional additional files which can be trimmed.  Default is none.
        /// </summary>
        public ITaskItem[] TrimmableFiles { get; set; }

        /// <summary>
        /// PackageDependency items.
        /// Identity is packageId/packageVersion
        /// ParentPackage metadata is packageId/packageVersion of depending package
        /// ParentTarget metadata is target string, targetMoniker/RID.
        /// </summary>
        [Required]
        public ITaskItem[] PackageDependencies { get; set; }

        /// <summary>
        /// Target framework to use when determining package dependencies.  Should be long form, IE: .NETCoreApp,Version=v1.0
        /// </summary>
        [Required]
        public string TargetFramework { get; set; }

        /// <summary>
        /// RuntimeIdentifier to use when determining package dependencies.
        /// </summary>
        public string RuntimeIdentifier { get; set; }

        /// <summary>
        /// Resolved runtime items to consider for trimming.
        /// Should have metadata (where appropriate):
        ///     NuGetPackageId
        ///     NuGetPackageVersion
        /// </summary>
        [Required]
        public ITaskItem[] RuntimeItems { get; set; }

        /// <summary>
        /// Resolved runtime items to consider for trimming.
        /// Should have metadata (where appropriate):
        ///     NuGetPackageId
        ///     NuGetPackageVersion
        /// </summary>
        public ITaskItem[] OtherRuntimeItems { get; set; }

        /// <summary>
        /// True to prefer a native image ('.ni.dll') over non-native image when walking references.
        /// </summary>
        public bool PreferNativeImages { get; set; }

        /// <summary>
        /// True to treat packages with only package references as trimmable.
        /// </summary>
        public bool TreatMetaPackagesAsTrimmable { get; set; }

        /// <summary>
        /// A subset of ReferenceCopyLocalPaths after trimming has been done.
        /// </summary>
        [Output]
        public ITaskItem[] RuntimeItemsAfterTrimming { get; set; }

        [Output]
        public ITaskItem[] TrimmedItems { get; set; }

        private ILog log;
        private Trimmable trimmable;

        public override bool Execute()
        {
            log = new MSBuildLog(Log);

            // Build the package graph
            var packages = GetPackagesFromPackageDependencies();

            // Build file graph
            var files = GetFiles(packages);

            trimmable = new Trimmable(TrimmablePackages?.Select(i => i.ItemSpec), 
                                      TrimmableFiles?.Select(i => GetFileNameFromItem(i)));

            Queue<NuGetPackageNode> packageRoots = GetPackageRoots(packages, trimmable);
            Queue<FileNode> fileRoots = GetFileRoots(files, trimmable);
            
            while (packageRoots.Count > 0 || fileRoots.Count > 0)
            {
                while (fileRoots.Count > 0)
                {
                    var fileNode = fileRoots.Dequeue();

                    foreach(var file in fileNode.Dependencies.Where(f => !trimmable.IsFileTrimmable(f.Name)))
                    {
                        IncludeNode(fileRoots, file);
                    }

                    if (fileNode.Package != null && !IsPackageTrimmable(fileNode.Package))
                    {
                        IncludeNode(packageRoots, fileNode.Package);
                    }
                }

                while (packageRoots.Count > 0)
                {
                    var packageNode = packageRoots.Dequeue();

                    foreach(var dependency in packageNode.Dependencies.Where(d => !IsPackageTrimmable(d)))
                    {
                        IncludeNode(packageRoots, dependency);
                    }

                    foreach(var file in packageNode.Files.Where(f => !trimmable.IsFileTrimmable(f.Name)))
                    {
                        IncludeNode(fileRoots, file);
                    }
                }
            }

            var excludedItems = files.Values.Where(f => !f.IsIncluded).Select(f => f.OriginalItem);
            TrimmedItems = excludedItems.ToArray();
            RuntimeItemsAfterTrimming = RuntimeItems.Except(excludedItems).ToArray();

            LogResults(files.Values);

            return !Log.HasLoggedErrors;
        }

        private void LogResults(IEnumerable<FileNode> results)
        {
            int numIncluded = 0, numExcluded = 0;
            long sizeIncluded = 0, sizeExcluded = 0;
            foreach (var file in results)
            {
                if (file.IsIncluded)
                {
                    numIncluded++;
                    sizeIncluded += GetFileSize(file);
                }
                else
                {
                    numExcluded++;
                    sizeExcluded += GetFileSize(file);
                }
            }

            Log.LogMessage(MessageImportance.High, $"Trimmed {numExcluded} out of {numExcluded + numIncluded} files for a savings of {(double)sizeExcluded / (1024*1024):0.##} MB");
            Log.LogMessage(MessageImportance.High, $"Final app size is {(double)sizeIncluded / (1024 * 1024):0.##} MB");
        }

        private long GetFileSize(FileNode file)
        {
            return new FileInfo(file.SourceFile).Length;
        }

        Queue<NuGetPackageNode> GetPackageRoots(IDictionary<string, NuGetPackageNode> packages, Trimmable trimmable)
        {
            var packageRootQueue = new Queue<NuGetPackageNode>();

            if (RootPackages != null)
            {
                var rootPackageIds = RootPackages.Select(i => GetPackageIdFromItemSpec(i.ItemSpec));

                foreach (var rootPackageId in rootPackageIds)
                {
                    NuGetPackageNode rootPackage;

                    if (!packages.TryGetValue(rootPackageId, out rootPackage))
                    {
                        throw new Exception($"Root package {rootPackageId} was specified but was not found in PackageDependencies");
                    }

                    if (!IsPackageTrimmable(rootPackage))
                    {
                        IncludeNode(packageRootQueue, rootPackage);
                    }
                }
            }

            return packageRootQueue;
        }

        private static string GetPackageIdFromItemSpec(string itemSpec)
        {
            string id, unused;
            GetPackageIdAndVersion(itemSpec, out id, out unused);
            return id;
        }

        private static void GetPackageIdAndVersion(string packageString, out string packageId, out string packageVersion)
        {
            var separatorIndex = packageString.IndexOf('/');

            packageId = separatorIndex > 0 ? packageString.Substring(0, separatorIndex) : packageString;
            packageVersion = separatorIndex > 0 && (separatorIndex + 1) < packageString.Length ?
                packageString.Substring(separatorIndex + 1) : null;
        }

        Queue<FileNode> GetFileRoots(IDictionary<string, FileNode> files, Trimmable trimmable)
        {
            var fileRootQueue = new Queue<FileNode>();

            var trimmedRootFilenames = RootFiles.Select(i => GetFileNameFromItem(i)).Where(f => !trimmable.IsFileTrimmable(f));

            foreach(var rootFilename in trimmedRootFilenames)
            {
                FileNode rootFile;
                if (files.TryGetValue(rootFilename, out rootFile))
                {
                    IncludeNode(fileRootQueue, rootFile);
                }
                else
                {
                    Log.LogMessage($"Root file {rootFilename} was specified but was not found in the file index.");
                }
            }

            return fileRootQueue;
        }

        internal IDictionary<string, NuGetPackageNode> GetPackagesFromPackageDependencies()
        {
            Dictionary<string, NuGetPackageNode> packages = new Dictionary<string, NuGetPackageNode>(StringComparer.OrdinalIgnoreCase);

            var target = TargetFramework;

            if (!string.IsNullOrEmpty(RuntimeIdentifier))
            {
                target += "/" + RuntimeIdentifier;
            }

            foreach (var packageDepedency in PackageDependencies)
            {
                var dependencyTarget = packageDepedency.GetMetadata("ParentTarget");

                if (!dependencyTarget.Equals(target, StringComparison.Ordinal))
                {
                    continue;
                }

                var parentPackage = packageDepedency.GetMetadata("ParentPackage");
                var childPackage = packageDepedency.ItemSpec;

                var parentNode = GetOrCreatePackageNode(packages, parentPackage);
                var childNode = GetOrCreatePackageNode(packages, childPackage);

                parentNode.AddDependency(childNode);
            }

            return packages;
        }

        private static NuGetPackageNode GetOrCreatePackageNode(IDictionary<string, NuGetPackageNode> packages, string package)
        {
            string id, version;
            GetPackageIdAndVersion(package, out id, out version);

            NuGetPackageNode node;
            if (!packages.TryGetValue(id, out node))
            {
                packages[id] = node = new NuGetPackageNode(id, version);
            }

            return node;
        }


        internal IDictionary<string, FileNode> GetFiles(IDictionary<string, NuGetPackageNode> packages)
        {
            var files = new Dictionary<string, FileNode>(RuntimeItems.Length, StringComparer.OrdinalIgnoreCase);
            IEnumerable<ITaskItem> runtimeItems = RuntimeItems;

            if (OtherRuntimeItems != null)
            {
                runtimeItems = runtimeItems.Concat(OtherRuntimeItems);
            }

            foreach(var runtimeItem in runtimeItems)
            {
                var fileNode = new FileNode(runtimeItem, packages);
                files.Add(fileNode.Name, fileNode);
            }

            // root files are likely not in the RuntimeItems
            foreach (var rootFile in RootFiles)
            {
                var fileNode = new FileNode(rootFile, packages);
                if (!files.ContainsKey(fileNode.Name)  && File.Exists(fileNode.SourceFile))
                {
                    files.Add(fileNode.Name, fileNode);
                }
            }

            // connect the graph
            foreach(var file in files.Values)
            {
                file.PopulateDependencies(files, PreferNativeImages, log);
            }

            return files;
        }

        private bool IsPackageTrimmable(NuGetPackageNode package)
        {
            return trimmable.IsPackageTrimmable(package.Id) ||
                (TreatMetaPackagesAsTrimmable && package.IsMetaPackage);
        }

        private static void IncludeNode<T>(Queue<T> queue, T node) where T : IIsIncluded
        {
            if (!node.IsIncluded)
            {
                node.IsIncluded = true;
                queue.Enqueue(node); 
            }
        }

        private static string GetFileNameFromItem(ITaskItem item)
        {
            return item.GetMetadata("FileName") + item.GetMetadata("Extension");
        }
    }
}
