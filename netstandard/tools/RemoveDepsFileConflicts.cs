// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using Microsoft.Extensions.DependencyModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Microsoft.DotNet.Build.Tasks
{
    public partial class RemoveDepsFileConflicts : Task
    {
        HashSet<string> conflictPackages;

        [Required]
        public string DepsFilePath { get; set; }

        [Required]
        public ITaskItem[] ConflictPackages { get; set; }

        public override bool Execute()
        {
            conflictPackages = new HashSet<string>(ConflictPackages.Select(p => p.ItemSpec), StringComparer.OrdinalIgnoreCase);

            DependencyContext sourceDeps;
            using (var sourceStream = File.Open(DepsFilePath, FileMode.Open, FileAccess.Read, FileShare.Read | FileShare.Delete))
            {
                sourceDeps = new DependencyContextJsonReader().Read(sourceStream);
            }

            DependencyContext trimmedDeps = TrimConflicts(sourceDeps);

            var writer = new DependencyContextWriter();
            using (var fileStream = File.Create(DepsFilePath))
            {
                writer.Write(trimmedDeps, fileStream);
            }

            return !Log.HasLoggedErrors;
        }

        private DependencyContext TrimConflicts(DependencyContext sourceDeps)
        {
            return new DependencyContext(sourceDeps.Target,
                                         sourceDeps.CompilationOptions,
                                         TrimCompilationLibraries(sourceDeps.CompileLibraries),
                                         TrimRuntimeLibraries(sourceDeps.RuntimeLibraries),
                                         sourceDeps.RuntimeGraph);
        }


        // Array.Empty doesn't exist on net451
        static readonly RuntimeAssetGroup[] s_emptyRuntimeAssetGroup = new RuntimeAssetGroup[0];
        private IEnumerable<RuntimeLibrary> TrimRuntimeLibraries(IReadOnlyList<RuntimeLibrary> runtimeLibraries)
        {
            foreach(var runtimeLibrary in runtimeLibraries)
            {
                if (conflictPackages.Contains(runtimeLibrary.Name))
                {
                    yield return new RuntimeLibrary(runtimeLibrary.Type,
                                              runtimeLibrary.Name,
                                              runtimeLibrary.Version,
                                              runtimeLibrary.Hash,
                                              s_emptyRuntimeAssetGroup,
                                              s_emptyRuntimeAssetGroup,
                                              Enumerable.Empty<ResourceAssembly>(),
                                              runtimeLibrary.Dependencies,
                                              runtimeLibrary.Serviceable);
                }
                else
                {
                    yield return runtimeLibrary;
                }
            }
        }

        private IEnumerable<CompilationLibrary> TrimCompilationLibraries(IReadOnlyList<CompilationLibrary> compileLibraries)
        {
            foreach (var compileLibrary in compileLibraries)
            {
                if (conflictPackages.Contains(compileLibrary.Name))
                {
                    yield return new CompilationLibrary(compileLibrary.Type,
                                              compileLibrary.Name,
                                              compileLibrary.Version,
                                              compileLibrary.Hash,
                                              Enumerable.Empty<string>(),
                                              compileLibrary.Dependencies,
                                              compileLibrary.Serviceable);
                }
                else
                {
                    yield return compileLibrary;
                }
            }
        }
    }
}
