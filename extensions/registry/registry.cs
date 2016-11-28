// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

/*
APIs removed/broken by this factoring:

*/

namespace Microsoft.Win32
{
    public static partial class Registry
    {
        public static readonly Microsoft.Win32.RegistryKey ClassesRoot;
        public static readonly Microsoft.Win32.RegistryKey CurrentConfig;
        public static readonly Microsoft.Win32.RegistryKey CurrentUser;
        [System.ObsoleteAttribute("The DynData registry key only works on Win9x, which is no longer supported by the CLR.  On NT-based operating systems, use the PerformanceData registry key instead.")]
        public static readonly Microsoft.Win32.RegistryKey DynData;
        public static readonly Microsoft.Win32.RegistryKey LocalMachine;
        public static readonly Microsoft.Win32.RegistryKey PerformanceData;
        public static readonly Microsoft.Win32.RegistryKey Users;
        public static object GetValue(string keyName, string valueName, object defaultValue) { throw null; }
        public static void SetValue(string keyName, string valueName, object value) { }
        public static void SetValue(string keyName, string valueName, object value, Microsoft.Win32.RegistryValueKind valueKind) { }
    }
    public enum RegistryHive
    {
        ClassesRoot = -2147483648,
        CurrentConfig = -2147483643,
        CurrentUser = -2147483647,
        DynData = -2147483642,
        LocalMachine = -2147483646,
        PerformanceData = -2147483644,
        Users = -2147483645,
    }
    public sealed partial class RegistryKey : System.MarshalByRefObject, System.IDisposable
    {
        internal RegistryKey() { }
        public Microsoft.Win32.SafeHandles.SafeRegistryHandle Handle { get { throw null; } }
        public string Name { get { throw null; } }
        public int SubKeyCount { get { throw null; } }
        public int ValueCount { get { throw null; } }
        public Microsoft.Win32.RegistryView View { get { throw null; } }
        public void Close() { }
        public Microsoft.Win32.RegistryKey CreateSubKey(string subkey) { throw null; }
        public Microsoft.Win32.RegistryKey CreateSubKey(string subkey, Microsoft.Win32.RegistryKeyPermissionCheck permissionCheck) { throw null; }
        public Microsoft.Win32.RegistryKey CreateSubKey(string subkey, Microsoft.Win32.RegistryKeyPermissionCheck permissionCheck, Microsoft.Win32.RegistryOptions options) { throw null; }
        public Microsoft.Win32.RegistryKey CreateSubKey(string subkey, Microsoft.Win32.RegistryKeyPermissionCheck permissionCheck, Microsoft.Win32.RegistryOptions registryOptions, System.Security.AccessControl.RegistrySecurity registrySecurity) { throw null; }
        public Microsoft.Win32.RegistryKey CreateSubKey(string subkey, Microsoft.Win32.RegistryKeyPermissionCheck permissionCheck, System.Security.AccessControl.RegistrySecurity registrySecurity) { throw null; }
        public Microsoft.Win32.RegistryKey CreateSubKey(string subkey, bool writable) { throw null; }
        public Microsoft.Win32.RegistryKey CreateSubKey(string subkey, bool writable, Microsoft.Win32.RegistryOptions options) { throw null; }
        public void DeleteSubKey(string subkey) { }
        public void DeleteSubKey(string subkey, bool throwOnMissingSubKey) { }
        public void DeleteSubKeyTree(string subkey) { }
        public void DeleteSubKeyTree(string subkey, bool throwOnMissingSubKey) { }
        public void DeleteValue(string name) { }
        public void DeleteValue(string name, bool throwOnMissingValue) { }
        public void Dispose() { }
        public void Flush() { }
        public static Microsoft.Win32.RegistryKey FromHandle(Microsoft.Win32.SafeHandles.SafeRegistryHandle handle) { throw null; }
        public static Microsoft.Win32.RegistryKey FromHandle(Microsoft.Win32.SafeHandles.SafeRegistryHandle handle, Microsoft.Win32.RegistryView view) { throw null; }
        public System.Security.AccessControl.RegistrySecurity GetAccessControl() { throw null; }
        public System.Security.AccessControl.RegistrySecurity GetAccessControl(System.Security.AccessControl.AccessControlSections includeSections) { throw null; }
        public string[] GetSubKeyNames() { throw null; }
        public object GetValue(string name) { throw null; }
        public object GetValue(string name, object defaultValue) { throw null; }
        public object GetValue(string name, object defaultValue, Microsoft.Win32.RegistryValueOptions options) { throw null; }
        public Microsoft.Win32.RegistryValueKind GetValueKind(string name) { throw null; }
        public string[] GetValueNames() { throw null; }
        public static Microsoft.Win32.RegistryKey OpenBaseKey(Microsoft.Win32.RegistryHive hKey, Microsoft.Win32.RegistryView view) { throw null; }
        public static Microsoft.Win32.RegistryKey OpenRemoteBaseKey(Microsoft.Win32.RegistryHive hKey, string machineName) { throw null; }
        public static Microsoft.Win32.RegistryKey OpenRemoteBaseKey(Microsoft.Win32.RegistryHive hKey, string machineName, Microsoft.Win32.RegistryView view) { throw null; }
        public Microsoft.Win32.RegistryKey OpenSubKey(string name) { throw null; }
        public Microsoft.Win32.RegistryKey OpenSubKey(string name, Microsoft.Win32.RegistryKeyPermissionCheck permissionCheck) { throw null; }
        public Microsoft.Win32.RegistryKey OpenSubKey(string name, Microsoft.Win32.RegistryKeyPermissionCheck permissionCheck, System.Security.AccessControl.RegistryRights rights) { throw null; }
        public Microsoft.Win32.RegistryKey OpenSubKey(string name, bool writable) { throw null; }
        public Microsoft.Win32.RegistryKey OpenSubKey(string name, System.Security.AccessControl.RegistryRights rights) { throw null; }
        public void SetAccessControl(System.Security.AccessControl.RegistrySecurity registrySecurity) { }
        public void SetValue(string name, object value) { }
        public void SetValue(string name, object value, Microsoft.Win32.RegistryValueKind valueKind) { }
        public override string ToString() { throw null; }
    }
    public enum RegistryKeyPermissionCheck
    {
        Default = 0,
        ReadSubTree = 1,
        ReadWriteSubTree = 2,
    }
    [System.FlagsAttribute]
    public enum RegistryOptions
    {
        None = 0,
        Volatile = 1,
    }
    public enum RegistryValueKind
    {
        Binary = 3,
        DWord = 4,
        ExpandString = 2,
        MultiString = 7,
        None = -1,
        QWord = 11,
        String = 1,
        Unknown = 0,
    }
    [System.FlagsAttribute]
    public enum RegistryValueOptions
    {
        DoNotExpandEnvironmentNames = 1,
        None = 0,
    }
    public enum RegistryView
    {
        Default = 0,
        Registry32 = 512,
        Registry64 = 256,
    }
}
namespace Microsoft.Win32.SafeHandles
{
    public sealed partial class SafeRegistryHandle : Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid
    {
        public SafeRegistryHandle(System.IntPtr preexistingHandle, bool ownsHandle) : base (default(bool)) { }
        protected override bool ReleaseHandle() { throw null; }
    }
}
