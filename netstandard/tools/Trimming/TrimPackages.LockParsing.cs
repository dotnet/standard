using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using Microsoft.NuGet.Build.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.DotNet.Build.Tasks
{
    public partial class TrimPackages
    {
        // This code was all copied / adapted from ResolveNuGetPackageAssets.cs

        /// <summary>
        /// Fetches the right target from the targets section in a lock file, or attempts to find a "best match" if allowed. The "best match" logic
        /// is there to allow a design time build for the IDE to generally work even if something isn't quite right. Throws an exception
        /// if either the preferred isn't there and fallbacks aren't allowed, or fallbacks are allowed but nothing at all could be found.
        /// </summary>
        /// <param name="lockFile">The lock file JSON.</param>
        /// <param name="needsRuntimeIdentifier">Whether we must find targets that include the runtime identifier or one without the runtime identifier.</param>
        private JObject GetTargetOrAttemptFallback(JObject lockFile, bool needsRuntimeIdentifier)
        {
            var targets = (JObject)lockFile["targets"];

            foreach (var preferredTargetMoniker in TargetMonikers)
            {
                var preferredTargetMonikerWithOptionalRuntimeIdentifier = GetTargetMonikerWithOptionalRuntimeIdentifier(preferredTargetMoniker, needsRuntimeIdentifier);
                var target = (JObject)targets[preferredTargetMonikerWithOptionalRuntimeIdentifier];

                if (target != null)
                {
                    return target;
                }
            }

            // If we need a runtime identifier, let's see if we have the framework targeted. If we do,
            // then we can give a better error message.
            bool onlyNeedsRuntimeInProjectJson = false;
            if (needsRuntimeIdentifier)
            {
                foreach (var targetMoniker in TargetMonikers)
                {
                    var targetMonikerWithoutRuntimeIdentifier = GetTargetMonikerWithOptionalRuntimeIdentifier(targetMoniker, needsRuntimeIdentifier: false);
                    if (targets[targetMonikerWithoutRuntimeIdentifier] != null)
                    {
                        // We do have a TXM being targeted, so we just are missing the runtime
                        onlyNeedsRuntimeInProjectJson = true;
                        break;
                    }
                }
            }

            if (onlyNeedsRuntimeInProjectJson)
            {
                GiveErrorForMissingRuntimeIdentifier();
            }
            else
            {
                ThrowExceptionIfNotAllowingFallback(nameof(Strings.MissingFramework), TargetMonikers.First().ItemSpec);
            }

            // If we're still here, that means we're allowing fallback, so let's try
            foreach (var fallback in TargetMonikers)
            {
                var target = (JObject)targets[GetTargetMonikerWithOptionalRuntimeIdentifier(fallback, needsRuntimeIdentifier: false)];

                if (target != null)
                {
                    return target;
                }
            }

            // Anything goes
            var enumerableTargets = targets.Cast<KeyValuePair<string, JToken>>();
            var firstTarget = (JObject)enumerableTargets.FirstOrDefault().Value;
            if (firstTarget == null)
            {
                throw new ExceptionFromResource(nameof(Strings.NoTargetsInLockFile));
            }

            return firstTarget;
        }

        private void GiveErrorForMissingRuntimeIdentifier()
        {
            string runtimePiece = '"' + RuntimeIdentifier + "\": { }";

            bool hasRuntimesSection;
            try
            {
                using (var stream = File.OpenRead(ProjectLockFile.Replace(".lock.json", ".json")))
                using (var streamReader = new StreamReader(stream))
                {
                    var jsonFile = JObject.Load(new JsonTextReader(streamReader));
                    hasRuntimesSection = jsonFile["runtimes"] != null;
                }
            }
            catch
            {
                // User has a bad file, locked file, no file at all, etc. We'll just assume they have one.
                hasRuntimesSection = true;
            }

            if (hasRuntimesSection)
            {
                ThrowExceptionIfNotAllowingFallback(nameof(Strings.MissingRuntimeInRuntimesSection), RuntimeIdentifier, runtimePiece);
            }
            else
            {
                var runtimesSection = "\"runtimes\": { " + runtimePiece + " }";
                ThrowExceptionIfNotAllowingFallback(nameof(Strings.MissingRuntimesSection), runtimesSection);
            }
        }
        
        private void ThrowExceptionIfNotAllowingFallback(string resourceName, params string[] messageArgs)
        {
            if (!AllowFallbackOnTargetSelection)
            {
                throw new ExceptionFromResource(resourceName, messageArgs);
            }
            else
            {
                // We are allowing fallback, so we'll still give a warning but allow us to continue
                Log.LogWarningFromResources(resourceName, messageArgs);
            }
        }

        private string GetTargetMonikerWithOptionalRuntimeIdentifier(ITaskItem preferredTargetMoniker, bool needsRuntimeIdentifier)
        {
            return needsRuntimeIdentifier ? preferredTargetMoniker.ItemSpec + "/" + RuntimeIdentifier : preferredTargetMoniker.ItemSpec;
        }

        private IDictionary<string, NuGetPackageNode> GetPackagesFromTarget(JObject target)
        {
            Dictionary<string, NuGetPackageNode> packages = new Dictionary<string, NuGetPackageNode>(target.Count, StringComparer.OrdinalIgnoreCase);

            foreach (var package in target)
            {
                var nameParts = package.Key.Split('/');
                var id = nameParts[0];
                var version = nameParts[1];

                packages.Add(id, new NuGetPackageNode(id, version, (JObject)package.Value));
            }

            // Connect the graph
            foreach(var package in packages.Values)
            {
                package.PopulateDependencies(packages);
            }

            return packages;
        }

        internal IDictionary<string, NuGetPackageNode> GetPackages()
        {
            JObject lockFile;
            using (var stream = File.OpenRead(ProjectLockFile))
            using (var streamReader = new StreamReader(stream))
            {
                lockFile = JObject.Load(new JsonTextReader(streamReader));
            }

            var target = GetTargetOrAttemptFallback(lockFile, needsRuntimeIdentifier: !String.IsNullOrEmpty(RuntimeIdentifier));

            return GetPackagesFromTarget(target);
        }


        // Workaround https://github.com/NuGet/Home/issues/1843
        private IEnumerable<string> GetReferencedPackagesFromLockFile()
        {
            JObject lockFile;
            using (var stream = File.OpenRead(ProjectLockFile))
            using (var streamReader = new StreamReader(stream))
            {
                lockFile = JObject.Load(new JsonTextReader(streamReader));
            }

            var projectFileDependencyGroups = (JObject)lockFile["projectFileDependencyGroups"];

            // find whichever target we will have selected
            var actualTarget = GetTargetOrAttemptFallback(lockFile, needsRuntimeIdentifier: !String.IsNullOrEmpty(RuntimeIdentifier))?.Parent as JProperty;
            string targetMoniker = null;
            if (actualTarget != null)
            {
                targetMoniker = actualTarget.Name.Split('/').FirstOrDefault();
            }

            foreach (var dependencyGroup in projectFileDependencyGroups.Values<JProperty>())
            {
                if (dependencyGroup.Name.Length == 0 || dependencyGroup.Name == targetMoniker)
                {
                    foreach (var packageDependency in dependencyGroup.Value.Values<string>())
                    {
                        int firstSpace = packageDependency.IndexOf(' ');

                        if (firstSpace > -1)
                        {
                            yield return packageDependency.Substring(0, firstSpace);
                        }
                    }
                }
            }
        }
    }
}
