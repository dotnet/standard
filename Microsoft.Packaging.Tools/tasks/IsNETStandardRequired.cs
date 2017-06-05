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
    public class IsNETStandardRequired : Task
    {
        [Required]
        public ITaskItem[] References { get; set; }

        [Output]
        public bool Required { get; set; }

        public override bool Execute()
        {
            foreach(var reference in References)
            {
                var referenceSourcePath = ItemUtilities.GetSourcePath(reference);

                if (referenceSourcePath != null && File.Exists(referenceSourcePath))
                {
                    if (Required = FileUtilities.GetReferencesNETStandard(referenceSourcePath))
                    {
                        break;
                    }
                }
            }

            return !Log.HasLoggedErrors;
        }
    }
}
