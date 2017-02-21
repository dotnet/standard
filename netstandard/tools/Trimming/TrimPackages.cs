using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Microsoft.DotNet.Build.Tasks
{
    public partial class TrimPackages : Task
    {
        /// <summary>
        /// Files to consider as a roots for trimming.  These files and their dependency closure will be preserved.
        /// Typically the project's output assembly.
        /// </summary>
        [Required]
        public ITaskItem[] RootFiles { get; set; }

        /// <summary>
        /// Packages to consider as roots for trimming.  These packages and their dependency closure will be preserved.
        /// Typically the ReferencedPackages output of the ResolveNuGetPackagesAssets task.
        /// https://github.com/NuGet/NuGet.BuildTasks/blob/b8552204ff93245bb6e36ff9a4cb6091d05a7b94/src/Microsoft.NuGet.Build.Tasks/Microsoft.NuGet.targets#L155
        /// Identity is package ID.
        /// </summary>
        [Required]
        public ITaskItem[] RootPackages { get; set; }

        /// <summary>
        /// Optional additional packages which can be trimmed.  Default is common meta-packages.
        /// Identity is package ID.
        /// TODO: this could replace the default set.
        /// </summary>
        public ITaskItem[] TrimmablePackages { get; set; }

        /// <summary>
        /// Optional additional files which can be trimmed.  Default is none.
        /// </summary>
        public ITaskItem[] TrimmableFiles { get; set; }

        /// <summary>
        /// Project.lock.json file for this project to be used for finding package dependencies.
        /// </summary>
        [Required]
        public string ProjectLockFile { get; set; }

        /// <summary>
        /// Target monikers to use when determining package dependencies. The first one found in the lock file is used
        /// </summary>
        [Required]
        public ITaskItem[] TargetMonikers { get; set; }

        /// <summary>
        /// RuntimeIdentifier to use when determining package dependencies.
        /// </summary>
        [Required]
        public string RuntimeIdentifier { get; set; }

        public bool AllowFallbackOnTargetSelection { get; set; }

        /// <summary>
        /// Resolved runtime items to consider for trimming.
        /// Typically the ResolvedCopyLocalItems output of the ResolveNuGetPackageAssets task.
        ///     https://github.com/NuGet/NuGet.BuildTasks/blob/b8552204ff93245bb6e36ff9a4cb6091d05a7b94/src/Microsoft.NuGet.Build.Tasks/Microsoft.NuGet.targets#L153
        /// Must have metadata:
        ///     NuGetPackageId
        ///     NuGetPackageVersion
        /// </summary>
        [Required]
        public ITaskItem[] RuntimeItems { get; set; }

        /// <summary>
        /// A subset of RuntimeItems after trimming has been done.
        /// </summary>
        [Output]
        public ITaskItem[] TrimmedRuntimeItems { get; set; }

        public override bool Execute()
        {
            // Build the package graph
            var packages = GetPackages();

            // Build file graph
            var files = GetFiles(packages);

            var trimmable = new Trimmable(TrimmablePackages?.Select(i => i.ItemSpec), 
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

                    if (fileNode.Package != null && !trimmable.IsPackageTrimmable(fileNode.PackageId))
                    {
                        IncludeNode(packageRoots, fileNode.Package);
                    }
                }

                while (packageRoots.Count > 0)
                {
                    var packageNode = packageRoots.Dequeue();

                    foreach(var dependency in packageNode.Dependencies.Where(d => !trimmable.IsPackageTrimmable(d.Id)))
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
            TrimmedRuntimeItems = RuntimeItems.Except(excludedItems).ToArray();

            LogResults(excludedItems, TrimmedRuntimeItems);

            return !Log.HasLoggedErrors;
        }

        private void LogResults(IEnumerable<ITaskItem> excluded, IEnumerable<ITaskItem> included)
        {
            var numIncluded = included.Count();
            var numExcluded = excluded.Count();
            var sizeIncluded = GetFileSize(included);
            var sizeExcluded = GetFileSize(excluded);

            Log.LogMessage(MessageImportance.High, $"Trimmed {numExcluded} out of {numExcluded + numIncluded} files for a savings of {(double)sizeExcluded / (1024*1024):0.##} MB");
            Log.LogMessage(MessageImportance.High, $"Final app size is {(double)sizeIncluded / (1024 * 1024):0.##} MB");
        }

        private long GetFileSize(IEnumerable<ITaskItem> items)
        {
            return items.Select(i => i.GetMetadata("FullPath"))
                        .Select(p => new FileInfo(p).Length)
                        .Sum();
        }

        Queue<NuGetPackageNode> GetPackageRoots(IDictionary<string, NuGetPackageNode> packages, Trimmable trimmable)
        {
            var packageRootQueue = new Queue<NuGetPackageNode>();

            if (RootPackages != null)
            {
                var rootPackageIds = RootPackages.Select(i => i.ItemSpec);

                // workaround bug where ResolveNuGetPackageAssets doesn't return TFM-specific dependencies
                // https://github.com/NuGet/Home/issues/1843
                rootPackageIds = rootPackageIds.Concat(GetReferencedPackagesFromLockFile()).Distinct();

                var trimmedRootPackageIds = rootPackageIds.Where(p => !trimmable.IsPackageTrimmable(p));

                foreach (var rootPackageId in trimmedRootPackageIds)
                {
                    NuGetPackageNode rootPackage;

                    if (!packages.TryGetValue(rootPackageId, out rootPackage))
                    {
                        throw new Exception($"Root package {rootPackageId} was specified but was not found in {ProjectLockFile}");
                    }

                    IncludeNode(packageRootQueue, rootPackage);
                }
            }

            return packageRootQueue;
        }

        Queue<FileNode> GetFileRoots(IDictionary<string, FileNode> files, Trimmable trimmable)
        {
            var fileRootQueue = new Queue<FileNode>();

            var trimmedRootFilenames = RootFiles.Select(i => GetFileNameFromItem(i)).Where(f => !trimmable.IsFileTrimmable(f));

            foreach(var rootFilename in trimmedRootFilenames)
            {
                FileNode rootFile;
                if (!files.TryGetValue(rootFilename, out rootFile))
                {
                    throw new Exception($"Root file {rootFilename} was specified but was not found in the file index.");
                }

                IncludeNode(fileRootQueue, rootFile);
            }

            return fileRootQueue;
        }

        internal IDictionary<string, FileNode> GetFiles(IDictionary<string, NuGetPackageNode> packages)
        {
            var files = new Dictionary<string, FileNode>(RuntimeItems.Length, StringComparer.OrdinalIgnoreCase);

            foreach(var runtimeItem in RuntimeItems)
            {
                var fileNode = new FileNode(runtimeItem, packages);
                files.Add(fileNode.Name, fileNode);
            }

            // root files are likely not in the RuntimeItems
            foreach (var rootFile in RootFiles)
            {
                var fileNode = new FileNode(rootFile, packages);
                if (!files.ContainsKey(fileNode.Name))
                {
                    files.Add(fileNode.Name, fileNode);
                }
            }

            // connect the graph
            foreach(var file in files.Values)
            {
                file.PopulateDependencies(files);
            }

            return files;
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
