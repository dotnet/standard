using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.DotNet.Build.Tasks
{
    internal class FileNode : IIsIncluded
    {
        IEnumerable<FileNode> _dependencies;

        internal const string NuGetPackageIdMetadata = "NuGetPackageId";
        internal const string NuGetPackageVersionMetadata = "NuGetPackageVersion";
        public FileNode(ITaskItem fileItem, IDictionary<string, NuGetPackageNode> allPackages)
        {
            Name = fileItem.GetMetadata("Filename") + fileItem.GetMetadata("Extension");
            OriginalItem = fileItem;
            PackageId = fileItem.GetMetadata(NuGetPackageIdMetadata);
            if (!String.IsNullOrEmpty(PackageId))
            {
                NuGetPackageNode package;

                if (!allPackages.TryGetValue(PackageId, out package))
                {
                    // some file came from a package that wasn't found in the lock file
                }
                else
                {
                    Package = package;
                    Package.Files.Add(this);
                }
            }
            SourceFile = fileItem.GetMetadata("FullPath");
        }

        public bool IsIncluded { get; set; }
        public string Name { get; }
        public ITaskItem OriginalItem { get; }
        public string PackageId { get; }
        public string SourceFile { get; }
        public NuGetPackageNode Package { get; }
        public IEnumerable<FileNode> Dependencies { get { return _dependencies; } }

        public void PopulateDependencies(Dictionary<string, FileNode> allFiles)
        {
            List<FileNode> dependencies = new List<FileNode>();

            try
            {
                using (var peReader = new PEReader(new FileStream(SourceFile, FileMode.Open, FileAccess.Read, FileShare.Delete | FileShare.Read)))
                {
                    if (peReader.HasMetadata)
                    {
                        var reader = peReader.GetMetadataReader();
                        foreach (var handle in reader.AssemblyReferences)
                        {
                            var reference = reader.GetAssemblyReference(handle);
                            var referenceCandidates = new[] { reader.GetString(reference.Name) + ".dll", reader.GetString(reference.Name) + ".ni.dll" };

                            FileNode referencedFile = null;
                            foreach (var referenceName in referenceCandidates)
                            {
                                if (allFiles.TryGetValue(referenceName, out referencedFile))
                                {
                                    break;
                                }
                            }

                            if (referencedFile != null)
                            {
                                dependencies.Add(referencedFile);
                            }
                            else
                            {
                                // static dependency that wasn't satisfied, this can happen if folks use 
                                // lightup code to gaurd the static dependency.
                                // this can also happen when referencing a package that isn't implemented
                                // on this platform but don't fail the build here
                            }
                        }

                        for (int i = 1, count = reader.GetTableRowCount(TableIndex.ModuleRef); i <= count; i++)
                        {
                            var moduleRef = reader.GetModuleReference(MetadataTokens.ModuleReferenceHandle(i));
                            var moduleName = reader.GetString(moduleRef.Name);

                            FileNode referencedNativeFile;
                            if (allFiles.TryGetValue(moduleName, out referencedNativeFile))
                            {
                                dependencies.Add(referencedNativeFile);
                            }
                            else
                            {
                                // DLLImport that wasn't satisfied
                            }
                        }
                    }
                }
            }
            catch(BadImageFormatException)
            {
                // not a PE
            }

            _dependencies = dependencies;
        }
    }
}
