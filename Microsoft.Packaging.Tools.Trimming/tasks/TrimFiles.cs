// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using Microsoft.NET.Build.Tasks;
using NuGet.Frameworks;
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
        /// Project assets file.  In case of missing package dependencies this will be used to load the package graph.
        /// </summary>
        public string ProjectAssetsFile { get; set; }

        /// <summary>
        /// Target framework to use when determining package dependencies.  Should be long form, IE: .NETCoreApp,Version=v1.0
        /// </summary>
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
        /// True to treat packages with more than one file as trimmable unless all files have been included.
        /// </summary>
        public bool TreatMultiPackagesAsTrimmable { get; set; }

        /// <summary>
        /// True to treat all packages as trimmable.
        /// </summary>
        public bool TreatAllPackagesAsTrimmable { get; set; }

        /// <summary>
        /// True to include files that are associated via OriginalItemSpec relation (though not necessarily any other reference).
        /// </summary>
        public bool IncludeRelatedFiles { get; set; }

        public string DirectedGraphFile { get; set; }

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

            if (packages.Count == 0)
            {
                packages = GetPackagesFromAssetsFile();
            }

            // Build file graph
            var files = GetFiles(packages);

            trimmable = new Trimmable(TrimmablePackages?.Select(i => i.ItemSpec), 
                                      TrimmableFiles?.Select(i => GetFileNameFromItem(i)));

            Queue<NuGetPackageNode> packageRoots = GetPackageRoots(packages, trimmable);
            Queue<FileNode> fileRoots = GetFileRoots(files, trimmable);
            var originalPackageRoots = packageRoots.ToArray();
            var originalFileRoots = fileRoots.ToArray();

            while (packageRoots.Count > 0 || fileRoots.Count > 0)
            {
                while (fileRoots.Count > 0)
                {
                    var fileNode = fileRoots.Dequeue();

                    if (fileNode.IsMissing)
                    {
                        Log.LogWarning($"File {fileNode.SourceFile} was included through references or roots but the file was missing.  It's dependencies will also be missing from the trimmed output.");
                    }

                    foreach(var file in fileNode.Dependencies.Where(f => !trimmable.IsFileTrimmable(f.Name)))
                    {
                        IncludeNode(fileRoots, file, fileNode);
                    }

                    if (IncludeRelatedFiles)
                    {
                        foreach (var file in fileNode.RelatedFiles.Where(f => !trimmable.IsFileTrimmable(f.Name)))
                        {
                            IncludeNode(fileRoots, file, fileNode);
                        }
                    }

                    if (fileNode.Package != null && !IsPackageTrimmable(fileNode.Package))
                    {
                        IncludeNode(packageRoots, fileNode.Package, fileNode);
                    }
                }

                while (packageRoots.Count > 0)
                {
                    var packageNode = packageRoots.Dequeue();

                    foreach(var dependency in packageNode.Dependencies.Where(d => !IsPackageTrimmable(d)))
                    {
                        IncludeNode(packageRoots, dependency, packageNode);
                    }

                    foreach(var file in packageNode.Files.Where(f => !trimmable.IsFileTrimmable(f.Name)))
                    {
                        IncludeNode(fileRoots, file, packageNode);
                    }
                }
            }

            var excludedItems = files.Values.Where(f => !f.IsIncluded).Select(f => f.OriginalItem);
            TrimmedItems = excludedItems.ToArray();
            RuntimeItemsAfterTrimming = RuntimeItems.Except(excludedItems).ToArray();

            LogResults(files.Values);

            if (!string.IsNullOrEmpty(DirectedGraphFile))
            {
                DirectedGraphWriter.WriteGraph(DirectedGraphFile, files.Values, packages.Values, originalFileRoots, originalPackageRoots);
            }

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

            Log.LogMessage(MessageImportance.High, $"Trimmed {numExcluded} out of {numExcluded + numIncluded} files for a saving of {(double)sizeExcluded / (1024*1024):0.##} MB");
            Log.LogMessage(MessageImportance.High, $"Final app size is {(double)sizeIncluded / (1024 * 1024):0.##} MB");
        }

        private long GetFileSize(FileNode file)
        {
            return string.IsNullOrEmpty(file.SourceFile) ? 0 : new FileInfo(file.SourceFile).Length;
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
                        IncludeRoot(packageRootQueue, rootPackage);
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
                    IncludeRoot(fileRootQueue, rootFile);
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

            if (string.IsNullOrEmpty(TargetFramework) && PackageDependencies?.Length > 0)
            {
                Log.LogError($"{nameof(TargetFramework)} was not specified and is required when {nameof(PackageDependencies)} are present.");
                return packages;
            }

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


                var childNode = GetOrCreatePackageNode(packages, childPackage);

                var parentNode = GetOrCreatePackageNode(packages, parentPackage);
                if (string.IsNullOrEmpty(parentPackage))
                {
                    continue;
                }

                parentNode.AddDependency(childNode);
            }

            return packages;
        }

        internal IDictionary<string, NuGetPackageNode> GetPackagesFromAssetsFile()
        {
            Dictionary<string, NuGetPackageNode> packages = new Dictionary<string, NuGetPackageNode>(StringComparer.OrdinalIgnoreCase);

            if (string.IsNullOrEmpty(ProjectAssetsFile))
            {
                return packages;
            }

            if (string.IsNullOrEmpty(TargetFramework))
            {
                Log.LogError($"{nameof(TargetFramework)} was not specified and is required when {nameof(ProjectAssetsFile)} is present.");
                return packages;
            }

            var lockFile = new LockFileCache(BuildEngine4).GetLockFile(ProjectAssetsFile);
            var lockFileTarget = lockFile.GetTarget(NuGetFramework.Parse(TargetFramework), RuntimeIdentifier);

            if (lockFileTarget == null)
            {
                var targetString = string.IsNullOrEmpty(RuntimeIdentifier) ? TargetFramework : $"{TargetFramework}/{RuntimeIdentifier}";
                Log.LogError($"Missing target section {targetString} from assets file {ProjectAssetsFile}.  Ensure you have restored this project previously.");
                return packages;
            }
            
            foreach (var library in lockFileTarget.Libraries)
            {
                var parentNode = GetOrCreatePackageNode(packages, library.Name);

                foreach(var dependency in library.Dependencies)
                {
                    var childNode = GetOrCreatePackageNode(packages, dependency.Id);

                    parentNode.AddDependency(childNode);
                }
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

                FileNode existingNode;

                if (files.TryGetValue(fileNode.Name, out existingNode))
                {
                    // if there is any duplicate file we'll replace it with an 'imaginary' aggregate node that
                    // depends on the 'real' duplicate nodes.
                    if (!existingNode.IsAggregate)
                    {
                        files[fileNode.Name] = existingNode = FileNode.CreateAggregateFileNode(existingNode);
                    }

                    existingNode.AddCandidateImplementation(fileNode);
                }
                else
                {
                    files.Add(fileNode.Name, fileNode);
                }
            }

            // root files are likely not in the RuntimeItems
            foreach (var rootFile in RootFiles)
            {
                var fileNode = new FileNode(rootFile, packages);
                if (!files.ContainsKey(fileNode.Name) && File.Exists(fileNode.SourceFile))
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
            return TreatAllPackagesAsTrimmable || 
                trimmable.IsPackageTrimmable(package.Id) ||
                (TreatMetaPackagesAsTrimmable && package.IsMetaPackage) ||
                (TreatMultiPackagesAsTrimmable && package.IsMultiPackage && package.Files.Any(f => !f.IsIncluded));
        }

        private void IncludeRoot(Queue<FileNode> queue, FileNode root)
        {
            Log.LogMessage(MessageImportance.Low, $"Including root file {root}.");
            QueueNode(queue, root);
        }

        private void IncludeRoot(Queue<NuGetPackageNode> queue, NuGetPackageNode root)
        {
            Log.LogMessage(MessageImportance.Low, $"Including root package {root}.");
            QueueNode(queue, root);
        }

        private void IncludeNode(Queue<FileNode> queue, FileNode child, FileNode parent)
        {
            Log.LogMessage(MessageImportance.Low, $"Including file {child} referenced by file {parent}.");
            QueueNode(queue, child);
        }

        private void IncludeNode(Queue<NuGetPackageNode> queue, NuGetPackageNode child, FileNode parent)
        {
            Log.LogMessage(MessageImportance.Low, $"Including package {child} since it contains file {parent}.");
            QueueNode(queue, child);
        }

        private void IncludeNode(Queue<FileNode> queue, FileNode child, NuGetPackageNode parent)
        {
            Log.LogMessage(MessageImportance.Low, $"Including file {child} part of package {parent}.");
            QueueNode(queue, child);
        }

        private void IncludeNode(Queue<NuGetPackageNode> queue, NuGetPackageNode child, NuGetPackageNode parent)
        {
            Log.LogMessage(MessageImportance.Low, $"Including package {child} referenced by package {parent}.");
            QueueNode(queue, child);
        }

        private static void QueueNode<T>(Queue<T> queue, T node) where T : IIsIncluded
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
