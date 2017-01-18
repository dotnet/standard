﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Build.Framework;
using System;
using System.IO;

namespace Microsoft.DotNet.Build.Tasks
{
    static partial class ItemUtilities
    {
        /// <summary>
        /// Get's the filename to use for identifying reference conflicts
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static string GetReferenceFileName(ITaskItem item)
        {
            var aliases = item.GetMetadata("Aliases");

            if (!String.IsNullOrEmpty(aliases))
            {
                // skip compile-time conflict detection for aliased assemblies.
                // An alias is the way to avoid a conflict
                //   eg: System, v1.0.0.0 in global will not conflict with System, v2.0.0.0 in `private` alias
                // We could model each alias scope and try to check for conflicts within that scope,
                // but this is a ton of complexity for a fringe feature.
                // Instead, we'll treat an alias as an indication that the developer has opted out of 
                // conflict resolution.
                return null;
            }

            // We only handle references that have path information since we're only concerned
            // with resolving conflicts between file references.  If conflicts exist between 
            // named references that are found from AssemblySearchPaths we'll leave those to
            // RAR to handle or not as it sees fit.
            var sourcePath = GetSourcePath(item);

            if (String.IsNullOrEmpty(sourcePath))
            {
                return null;
            }

            try
            {
                return Path.GetFileName(sourcePath);
            }
            catch (ArgumentException)
            {
                // We won't even try to resolve a conflict if we can't open the file, so ignore invalid paths
                return null;
            }
        }

        public static string GetReferenceTargetPath(ITaskItem item)
        {
            // Determine if the reference will be copied local.  
            // We're only dealing with primary file references.  For these RAR will 
            // copy local if Private is true or unset.

            var isPrivate = MSBuildUtilities.ConvertStringToBool(item.GetMetadata("Private"), defaultValue: true);

            if (!isPrivate)
            {
                // Private = false means the reference shouldn't be copied.
                return null;
            }

            return GetTargetPath(item);
        }

        public static string GetReferenceTargetFileName(ITaskItem item)
        {
            var targetPath = GetReferenceTargetPath(item);

            return targetPath != null ? Path.GetFileName(targetPath) : null;
        }

        public static string GetSourcePath(ITaskItem item)
        {
            var sourcePath = item.GetMetadata("HintPath");

            if (String.IsNullOrWhiteSpace(sourcePath))
            {
                // assume item-spec points to the file.
                // this won't work if it comes from a targeting pack or SDK, but
                // in that case the file won't exist and we'll skip it.
                sourcePath = item.ItemSpec;
            }

            return sourcePath;
        }

        static readonly string[] s_targetPathMetadata = new[] { "TargetPath", "DestinationSubPath", "Path" };
        public static string GetTargetPath(ITaskItem item)
        {
            // first use TargetPath, DestinationSubPath, then Path, then fallback to filename+extension alone
            foreach (var metadata in s_targetPathMetadata)
            {
                var value = item.GetMetadata(metadata);

                if (!String.IsNullOrWhiteSpace(value))
                {
                    // normalize path
                    return value.Replace('\\', '/');
                }
            }

            var sourcePath = GetSourcePath(item);

            return Path.GetFileName(sourcePath);
        }
    }
}
