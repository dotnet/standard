// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Build.Framework;
using System;
using System.IO;

namespace Microsoft.DotNet.Build.Tasks
{
    static partial class NuGetUtilities
    {
        /// <summary>
        /// Gets PackageId from sourcePath.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static string GetPackageIdFromSourcePath(string sourcePath)
        {
            try
            {
                // this method is just a temporary heuristic until we get metadata added to items created by the .NETCore SDK
                for(var dir = Directory.GetParent(sourcePath); dir != null; dir = dir.Parent)
                {
                    var nuspecs = dir.GetFiles("*.nuspec");

                    if (nuspecs.Length > 0)
                    {
                        return Path.GetFileNameWithoutExtension(nuspecs[0].Name);
                    }
                }
            }
            catch (Exception)
            { }

            return null;
        }
    }
}
