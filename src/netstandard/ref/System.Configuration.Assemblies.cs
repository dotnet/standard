// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Configuration.Assemblies
{
    public enum AssemblyHashAlgorithm
    {
        MD5 = 32771,
        None = 0,
        SHA1 = 32772,
        SHA256 = 32780,
        SHA384 = 32781,
        SHA512 = 32782,
    }
    public enum AssemblyVersionCompatibility
    {
        SameDomain = 3,
        SameMachine = 1,
        SameProcess = 2,
    }
}
