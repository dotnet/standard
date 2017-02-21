// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Microsoft.DotNet.Build.Tasks
{
    /// <summary>
    /// Metedata and information for a package listed in the lock file.
    /// </summary>
    internal sealed class NuGetPackageNode : IIsIncluded
    {
        private const string NuGetPackageDependencies = "dependencies";
        private List<NuGetPackageNode> _dependencies = new List<NuGetPackageNode>();
        private JObject _targetObject;

        public NuGetPackageNode(string id, string version, JObject targetObject)
        {
            Id = id;
            IsRuntimePackage = id.StartsWith("runtime.");
            Version = version;
            _targetObject = targetObject;
        }

        public string Id { get; }
        private bool IsRuntimePackage { get; }
        public bool IsIncluded { get; set; }
        public string Version { get; }
        public bool IsProject { get; }
        public IEnumerable<NuGetPackageNode> Dependencies { get { return _dependencies; } }
        public IList<FileNode> Files { get; } = new List<FileNode>();

        public void PopulateDependencies(Dictionary<string, NuGetPackageNode> allPackages)
        {
            var dependenciesObject = _targetObject[NuGetPackageDependencies] as JObject;
            
            if (dependenciesObject != null)
            {
                foreach(var dependencyProperty in dependenciesObject.Properties())
                {
                    var dependencyId = dependencyProperty.Name;

                    NuGetPackageNode dependency;
                    if (!allPackages.TryGetValue(dependencyId, out dependency))
                    {
                        // package declared a dependency but NuGet was missing the dependent package
                        // in the lock file.  This indicates a broken restore, but don't fail trimming
                    }
                    else
                    {
                        _dependencies.Add(dependency);

                        // Runtime packages may be brought in by a file-based dependency,
                        // but runtime packages may be missing the dependencies needed since those are 
                        // often declared by the idenity package since it is in the compile graph
                        // and capable of bringing in other runtime-split packages.

                        // Map back up to the identity package so that we can root it and its dependencies.
                        // This creates an artificial cycle, but our graph walk doesn't care about cycles.
                        if (dependency.IsRuntimePackage)
                        {
                            dependency._dependencies.Add(this);
                        }
                    }
                }
            }
        }

    }
}
