// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Security.Principal
{
    public partial class GenericIdentity : System.Security.Claims.ClaimsIdentity
    {
        protected GenericIdentity(System.Security.Principal.GenericIdentity identity) { }
        public GenericIdentity(string name) { }
        public GenericIdentity(string name, string type) { }
        public override string AuthenticationType { get { throw null; } }
        public override System.Collections.Generic.IEnumerable<System.Security.Claims.Claim> Claims { get { throw null; } }
        public override bool IsAuthenticated { get { throw null; } }
        public override string Name { get { throw null; } }
        public override System.Security.Claims.ClaimsIdentity Clone() { throw null; }
    }
    public partial class GenericPrincipal : System.Security.Claims.ClaimsPrincipal
    {
        public GenericPrincipal(System.Security.Principal.IIdentity identity, string[] roles) { }
        public override System.Security.Principal.IIdentity Identity { get { throw null; } }
        public override bool IsInRole(string role) { throw null; }
    }
    public partial interface IIdentity
    {
        string AuthenticationType { get; }
        bool IsAuthenticated { get; }
        string Name { get; }
    }
    public partial interface IPrincipal
    {
        System.Security.Principal.IIdentity Identity { get; }
        bool IsInRole(string role);
    }
    public enum PrincipalPolicy
    {
        NoPrincipal = 1,
        UnauthenticatedPrincipal = 0,
        WindowsPrincipal = 2,
    }
    public enum TokenImpersonationLevel
    {
        Anonymous = 1,
        Delegation = 4,
        Identification = 2,
        Impersonation = 3,
        None = 0,
    }
}
