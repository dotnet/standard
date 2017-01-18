﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;

namespace Microsoft.DotNet.Build.Tasks
{
    class PackageRank
    {
        private Dictionary<string, int> packageRanks;

        public PackageRank(string[] packageIds)
        {
            var numPackages = packageIds?.Length ?? 0;

            // cache ranks for fast lookup
            packageRanks = new Dictionary<string, int>(numPackages, StringComparer.OrdinalIgnoreCase);

            for (int i = numPackages - 1; i >= 0; i--)
            {
                var preferredPackageId = packageIds[i].Trim();

                if (preferredPackageId.Length != 0)
                {
                    // overwrite any duplicates, lowest rank will win.
                    packageRanks[preferredPackageId] = i;
                }
            }
        }

        /// <summary>
        /// Get's the rank of a package, lower packages are preferred
        /// </summary>
        /// <param name="packageId">id of package</param>
        /// <returns>rank of package</returns>
        public int GetPackageRank(string packageId)
        {
            int rank = int.MaxValue;

            if (packageId != null)
            {
                packageRanks.TryGetValue(packageId, out rank);
            }

            return rank;
        }
    }
}
