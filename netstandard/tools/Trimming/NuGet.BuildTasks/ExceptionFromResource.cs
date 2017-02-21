// Copyright (c) .NET Foundation. All rights reserved. 
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.NuGet.Build.Tasks
{
    /// <summary>
    /// An exception for reporting errors to the user. Points to a resource in <see cref="Strings"/> so
    /// we get the proper MSBuild localization handling.
    /// </summary>
    internal sealed class ExceptionFromResource : Exception
    {
        public string ResourceName { get; private set; }
        public string[] MessageArgs { get; private set; }

        public ExceptionFromResource(string resourceName, params string[] messageArgs)
        {
            ResourceName = resourceName;
            MessageArgs = messageArgs;
        }
    }
}
