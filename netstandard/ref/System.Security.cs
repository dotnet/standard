// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Security
{
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, AllowMultiple=false, Inherited=false)]
    public sealed partial class AllowPartiallyTrustedCallersAttribute : System.Attribute
    {
        public AllowPartiallyTrustedCallersAttribute() { }
        public System.Security.PartialTrustVisibilityLevel PartialTrustVisibilityLevel { get { throw null; } set { } }
    }
    public partial interface IPermission : System.Security.ISecurityEncodable
    {
        System.Security.IPermission Copy();
        void Demand();
        System.Security.IPermission Intersect(System.Security.IPermission target);
        bool IsSubsetOf(System.Security.IPermission target);
        System.Security.IPermission Union(System.Security.IPermission target);
    }
    public partial interface ISecurityEncodable
    {
        void FromXml(System.Security.SecurityElement e);
        System.Security.SecurityElement ToXml();
    }
    public enum PartialTrustVisibilityLevel
    {
        NotVisibleByDefault = 1,
        VisibleToAllHosts = 0,
    }
    public sealed partial class SecureString : System.IDisposable
    {
        public SecureString() { }
        [System.CLSCompliantAttribute(false)]
        public unsafe SecureString(char* value, int length) { }
        public int Length { get { throw null; } }
        [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
        public void AppendChar(char c) { }
        public void Clear() { }
        public System.Security.SecureString Copy() { throw null; }
        public void Dispose() { }
        [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
        public void InsertAt(int index, char c) { }
        public bool IsReadOnly() { throw null; }
        public void MakeReadOnly() { }
        [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
        public void RemoveAt(int index) { }
        [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
        public void SetAt(int index, char c) { }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public static partial class SecureStringMarshal
    {
        public static System.IntPtr SecureStringToCoTaskMemAnsi(System.Security.SecureString s) { throw null; }
        public static System.IntPtr SecureStringToCoTaskMemUnicode(System.Security.SecureString s) { throw null; }
        public static System.IntPtr SecureStringToGlobalAllocAnsi(System.Security.SecureString s) { throw null; }
        public static System.IntPtr SecureStringToGlobalAllocUnicode(System.Security.SecureString s) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.Class | System.AttributeTargets.Constructor | System.AttributeTargets.Delegate | System.AttributeTargets.Enum | System.AttributeTargets.Field | System.AttributeTargets.Interface | System.AttributeTargets.Method | System.AttributeTargets.Struct, AllowMultiple=false, Inherited=false)]
    public sealed partial class SecurityCriticalAttribute : System.Attribute
    {
        public SecurityCriticalAttribute() { }
        public SecurityCriticalAttribute(System.Security.SecurityCriticalScope scope) { }
        [System.ObsoleteAttribute("SecurityCriticalScope is only used for .NET 2.0 transparency compatibility.")]
        public System.Security.SecurityCriticalScope Scope { get { throw null; } }
    }
    [System.ObsoleteAttribute("SecurityCriticalScope is only used for .NET 2.0 transparency compatibility.")]
    public enum SecurityCriticalScope
    {
        Everything = 1,
        Explicit = 0,
    }
    public sealed partial class SecurityElement
    {
        public SecurityElement(string tag) { }
        public SecurityElement(string tag, string text) { }
        public System.Collections.Hashtable Attributes { get { throw null; } set { } }
        public System.Collections.ArrayList Children { get { throw null; } set { } }
        public string Tag { get { throw null; } set { } }
        public string Text { get { throw null; } set { } }
        public void AddAttribute(string name, string value) { }
        public void AddChild(System.Security.SecurityElement child) { }
        public string Attribute(string name) { throw null; }
        public System.Security.SecurityElement Copy() { throw null; }
        public bool Equal(System.Security.SecurityElement other) { throw null; }
        public static string Escape(string str) { throw null; }
        public static System.Security.SecurityElement FromString(string xml) { throw null; }
        public static bool IsValidAttributeName(string name) { throw null; }
        public static bool IsValidAttributeValue(string value) { throw null; }
        public static bool IsValidTag(string tag) { throw null; }
        public static bool IsValidText(string text) { throw null; }
        public System.Security.SecurityElement SearchForChildByTag(string tag) { throw null; }
        public string SearchForTextOfTag(string tag) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SecurityException : System.SystemException
    {
        public SecurityException() { }
        protected SecurityException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public SecurityException(string message) { }
        public SecurityException(string message, System.Exception inner) { }
//CAS        public SecurityException(string message, object deny, object permitOnly, System.Reflection.MethodInfo method, object demanded, System.Security.IPermission permThatFailed) { }
//CAS        public SecurityException(string message, System.Reflection.AssemblyName assemblyName, System.Security.PermissionSet grant, System.Security.PermissionSet refused, System.Reflection.MethodInfo method, System.Security.Permissions.SecurityAction action, object demanded, System.Security.IPermission permThatFailed, System.Security.Policy.Evidence evidence) { }
        public SecurityException(string message, System.Type type) { }
        public SecurityException(string message, System.Type type, string state) { }
//CAS        public System.Security.Permissions.SecurityAction Action { get { throw null; } set { } }
        public object Demanded { get { throw null; } set { } }
        public object DenySetInstance { get { throw null; } set { } }
        public System.Reflection.AssemblyName FailedAssemblyInfo { get { throw null; } set { } }
//CAS        public System.Security.IPermission FirstPermissionThatFailed { get { throw null; } set { } }
        public string GrantedSet { get { throw null; } set { } }
        public System.Reflection.MethodInfo Method { get { throw null; } set { } }
        public string PermissionState { get { throw null; } set { } }
        public System.Type PermissionType { get { throw null; } set { } }
        public object PermitOnlySetInstance { get { throw null; } set { } }
        public string RefusedSet { get { throw null; } set { } }
        public string Url { get { throw null; } set { } }
//CAS        public System.Security.SecurityZone Zone { get { throw null; } set { } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public override string ToString() { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, AllowMultiple=false)]
    public sealed partial class SecurityRulesAttribute : System.Attribute
    {
        public SecurityRulesAttribute(System.Security.SecurityRuleSet ruleSet) { }
        public System.Security.SecurityRuleSet RuleSet { get { throw null; } }
        public bool SkipVerificationInFullTrust { get { throw null; } set { } }
    }
    public enum SecurityRuleSet : byte
    {
        Level1 = (byte)1,
        Level2 = (byte)2,
        None = (byte)0,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Constructor | System.AttributeTargets.Delegate | System.AttributeTargets.Enum | System.AttributeTargets.Field | System.AttributeTargets.Interface | System.AttributeTargets.Method | System.AttributeTargets.Struct, AllowMultiple=false, Inherited=false)]
    public sealed partial class SecuritySafeCriticalAttribute : System.Attribute
    {
        public SecuritySafeCriticalAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, AllowMultiple=false, Inherited=false)]
    public sealed partial class SecurityTransparentAttribute : System.Attribute
    {
        public SecurityTransparentAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.Class | System.AttributeTargets.Constructor | System.AttributeTargets.Delegate | System.AttributeTargets.Enum | System.AttributeTargets.Field | System.AttributeTargets.Interface | System.AttributeTargets.Method | System.AttributeTargets.Struct, AllowMultiple=false, Inherited=false)]
    [System.ObsoleteAttribute("SecurityTreatAsSafe is only used for .NET 2.0 transparency compatibility.  Please use the SecuritySafeCriticalAttribute instead.")]
    public sealed partial class SecurityTreatAsSafeAttribute : System.Attribute
    {
        public SecurityTreatAsSafeAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Delegate | System.AttributeTargets.Interface | System.AttributeTargets.Method, AllowMultiple=true, Inherited=false)]
    public sealed partial class SuppressUnmanagedCodeSecurityAttribute : System.Attribute
    {
        public SuppressUnmanagedCodeSecurityAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Module, AllowMultiple=true, Inherited=false)]
    public sealed partial class UnverifiableCodeAttribute : System.Attribute
    {
        public UnverifiableCodeAttribute() { }
    }
    public partial class VerificationException : System.SystemException
    {
        public VerificationException() { }
        protected VerificationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public VerificationException(string message) { }
        public VerificationException(string message, System.Exception innerException) { }
    }
}
