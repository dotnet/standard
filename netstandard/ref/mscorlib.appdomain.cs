// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.


namespace System
{
    public static partial class Activator
    {
//REMOTING        public static System.Runtime.Remoting.ObjectHandle CreateComInstanceFrom(string assemblyName, string typeName) { throw null; }
//REMOTING        public static System.Runtime.Remoting.ObjectHandle CreateComInstanceFrom(string assemblyName, string typeName, byte[] hashValue, System.Configuration.Assemblies.AssemblyHashAlgorithm hashAlgorithm) { throw null; }
//REMOTING        public static System.Runtime.Remoting.ObjectHandle CreateInstance(System.ActivationContext activationContext) { throw null; }
//REMOTING        public static System.Runtime.Remoting.ObjectHandle CreateInstance(System.ActivationContext activationContext, string[] activationCustomData) { throw null; }
//REMOTING        public static System.Runtime.Remoting.ObjectHandle CreateInstance(System.AppDomain domain, string assemblyName, string typeName) { throw null; }
//REMOTING        public static System.Runtime.Remoting.ObjectHandle CreateInstance(System.AppDomain domain, string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes) { throw null; }
//REMOTING        [System.ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of CreateInstance which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//REMOTING        public static System.Runtime.Remoting.ObjectHandle CreateInstance(System.AppDomain domain, string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityAttributes) { throw null; }
//REMOTING        public static System.Runtime.Remoting.ObjectHandle CreateInstance(string assemblyName, string typeName) { throw null; }
//REMOTING        public static System.Runtime.Remoting.ObjectHandle CreateInstance(string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes) { throw null; }
//REMOTING        [System.ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of CreateInstance which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//REMOTING        public static System.Runtime.Remoting.ObjectHandle CreateInstance(string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityInfo) { throw null; }
//REMOTING        public static System.Runtime.Remoting.ObjectHandle CreateInstance(string assemblyName, string typeName, object[] activationAttributes) { throw null; }
        public static object CreateInstance(System.Type type) { throw null; }
        public static object CreateInstance(System.Type type, bool nonPublic) { throw null; }
        public static object CreateInstance(System.Type type, params object[] args) { throw null; }
        public static object CreateInstance(System.Type type, object[] args, object[] activationAttributes) { throw null; }
        public static object CreateInstance(System.Type type, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture) { throw null; }
        public static object CreateInstance(System.Type type, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes) { throw null; }
        public static T CreateInstance<T>() { throw null; }
//REMOTING        public static System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(System.AppDomain domain, string assemblyFile, string typeName) { throw null; }
//REMOTING        public static System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(System.AppDomain domain, string assemblyFile, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes) { throw null; }
//REMOTING        [System.ObsoleteAttribute("Methods which use Evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of CreateInstanceFrom which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//REMOTING        public static System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(System.AppDomain domain, string assemblyFile, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityAttributes) { throw null; }
//REMOTING        public static System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName) { throw null; }
//REMOTING        public static System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes) { throw null; }
//REMOTING        [System.ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of CreateInstanceFrom which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//REMOTING        public static System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityInfo) { throw null; }
//REMOTING        public static System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, object[] activationAttributes) { throw null; }
//REMOTING        public static object GetObject(System.Type type, string url) { throw null; }
//REMOTING        public static object GetObject(System.Type type, string url, object state) { throw null; }
    }
    public sealed partial class AppDomain : System.MarshalByRefObject
//CAS   , System.Security.IEvidenceFactory
    {
        internal AppDomain() { }
//REMOTING        public System.ActivationContext ActivationContext { get { throw null; } }
//REMOTING        public System.ApplicationIdentity ApplicationIdentity { get { throw null; } }
//CAS        public System.Security.Policy.ApplicationTrust ApplicationTrust { get { throw null; } }
        public string BaseDirectory { get { throw null; } }
        public static System.AppDomain CurrentDomain { get { throw null; } }
//REMOTING        public System.AppDomainManager DomainManager { get { throw null; } }
        public string DynamicDirectory { get { throw null; } }
//CAS        public System.Security.Policy.Evidence Evidence { get { throw null; } }
        public string FriendlyName { get { throw null; } }
        public int Id { get { throw null; } }
        public bool IsFullyTrusted { get { throw null; } }
        public bool IsHomogenous { get { throw null; } }
        public static bool MonitoringIsEnabled { get { throw null; } set { } }
        public long MonitoringSurvivedMemorySize { get { throw null; } }
        public static long MonitoringSurvivedProcessMemorySize { get { throw null; } }
        public long MonitoringTotalAllocatedMemorySize { get { throw null; } }
        public System.TimeSpan MonitoringTotalProcessorTime { get { throw null; } }
//CAS        public System.Security.PermissionSet PermissionSet { get { throw null; } }
        public string RelativeSearchPath { get { throw null; } }
//REMOTING        public System.AppDomainSetup SetupInformation { get { throw null; } }
        public bool ShadowCopyFiles { get { throw null; } }
        public event System.AssemblyLoadEventHandler AssemblyLoad { add { } remove { } }
        public event System.ResolveEventHandler AssemblyResolve { add { } remove { } }
        public event System.EventHandler DomainUnload { add { } remove { } }
        public event System.EventHandler<System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs> FirstChanceException { add { } remove { } }
        public event System.EventHandler ProcessExit { add { } remove { } }
        public event System.ResolveEventHandler ReflectionOnlyAssemblyResolve { add { } remove { } }
        public event System.ResolveEventHandler ResourceResolve { add { } remove { } }
        public event System.ResolveEventHandler TypeResolve { add { } remove { } }
        public event System.UnhandledExceptionEventHandler UnhandledException { add { } remove { } }
        [System.ObsoleteAttribute("AppDomain.AppendPrivatePath has been deprecated. Please investigate the use of AppDomainSetup.PrivateBinPath instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        public void AppendPrivatePath(string path) { }
        public string ApplyPolicy(string assemblyName) { throw null; }
        [System.ObsoleteAttribute("AppDomain.ClearPrivatePath has been deprecated. Please investigate the use of AppDomainSetup.PrivateBinPath instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        public void ClearPrivatePath() { }
        [System.ObsoleteAttribute("AppDomain.ClearShadowCopyPath has been deprecated. Please investigate the use of AppDomainSetup.ShadowCopyDirectories instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        public void ClearShadowCopyPath() { }
//REMOTING        public System.Runtime.Remoting.ObjectHandle CreateComInstanceFrom(string assemblyName, string typeName) { throw null; }
//REMOTING        public System.Runtime.Remoting.ObjectHandle CreateComInstanceFrom(string assemblyFile, string typeName, byte[] hashValue, System.Configuration.Assemblies.AssemblyHashAlgorithm hashAlgorithm) { throw null; }
        public static System.AppDomain CreateDomain(string friendlyName) { throw null; }
//CAS        public static System.AppDomain CreateDomain(string friendlyName, System.Security.Policy.Evidence securityInfo) { throw null; }
//CAS        public static System.AppDomain CreateDomain(string friendlyName, System.Security.Policy.Evidence securityInfo, System.AppDomainSetup info) { throw null; }
//CAS        public static System.AppDomain CreateDomain(string friendlyName, System.Security.Policy.Evidence securityInfo, System.AppDomainSetup info, System.Security.PermissionSet grantSet, params System.Security.Policy.StrongName[] fullTrustAssemblies) { throw null; }
//CAS        public static System.AppDomain CreateDomain(string friendlyName, System.Security.Policy.Evidence securityInfo, string appBasePath, string appRelativeSearchPath, bool shadowCopyFiles) { throw null; }
//CAS        public static System.AppDomain CreateDomain(string friendlyName, System.Security.Policy.Evidence securityInfo, string appBasePath, string appRelativeSearchPath, bool shadowCopyFiles, System.AppDomainInitializer adInit, string[] adInitArgs) { throw null; }
//REMOTING        public System.Runtime.Remoting.ObjectHandle CreateInstance(string assemblyName, string typeName) { throw null; }
//REMOTING        public System.Runtime.Remoting.ObjectHandle CreateInstance(string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes) { throw null; }
//REMOTING        [System.ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of CreateInstance which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//REMOTING        public System.Runtime.Remoting.ObjectHandle CreateInstance(string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityAttributes) { throw null; }
//REMOTING        public System.Runtime.Remoting.ObjectHandle CreateInstance(string assemblyName, string typeName, object[] activationAttributes) { throw null; }
//REMOTING        public object CreateInstanceAndUnwrap(string assemblyName, string typeName) { throw null; }
//REMOTING        public object CreateInstanceAndUnwrap(string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes) { throw null; }
//REMOTING        [System.ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of CreateInstanceAndUnwrap which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//REMOTING        public object CreateInstanceAndUnwrap(string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityAttributes) { throw null; }
//REMOTING        public object CreateInstanceAndUnwrap(string assemblyName, string typeName, object[] activationAttributes) { throw null; }
//REMOTING        public System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName) { throw null; }
//REMOTING        public System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes) { throw null; }
//REMOTING        [System.ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of CreateInstanceFrom which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//REMOTING        public System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityAttributes) { throw null; }
//REMOTING        public System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, object[] activationAttributes) { throw null; }
//REMOTING        public object CreateInstanceFromAndUnwrap(string assemblyName, string typeName) { throw null; }
//REMOTING        public object CreateInstanceFromAndUnwrap(string assemblyFile, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes) { throw null; }
//REMOTING        [System.ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of CreateInstanceFromAndUnwrap which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//REMOTING        public object CreateInstanceFromAndUnwrap(string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityAttributes) { throw null; }
//REMOTING        public object CreateInstanceFromAndUnwrap(string assemblyName, string typeName, object[] activationAttributes) { throw null; }
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access) { throw null; }
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, System.Collections.Generic.IEnumerable<System.Reflection.Emit.CustomAttributeBuilder> assemblyAttributes) { throw null; }
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, System.Collections.Generic.IEnumerable<System.Reflection.Emit.CustomAttributeBuilder> assemblyAttributes, System.Security.SecurityContextSource securityContextSource) { throw null; }
//REFEMIT        [System.ObsoleteAttribute("Assembly level declarative security is obsolete and is no longer enforced by the CLR by default.  See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, System.Security.PermissionSet requiredPermissions, System.Security.PermissionSet optionalPermissions, System.Security.PermissionSet refusedPermissions) { throw null; }
//REFEMIT        [System.ObsoleteAttribute("Assembly level declarative security is obsolete and is no longer enforced by the CLR by default.  See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, System.Security.Policy.Evidence evidence) { throw null; }
//REFEMIT        [System.ObsoleteAttribute("Assembly level declarative security is obsolete and is no longer enforced by the CLR by default. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, System.Security.Policy.Evidence evidence, System.Security.PermissionSet requiredPermissions, System.Security.PermissionSet optionalPermissions, System.Security.PermissionSet refusedPermissions) { throw null; }
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, string dir) { throw null; }
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, string dir, bool isSynchronized, System.Collections.Generic.IEnumerable<System.Reflection.Emit.CustomAttributeBuilder> assemblyAttributes) { throw null; }
//REFEMIT        [System.ObsoleteAttribute("Assembly level declarative security is obsolete and is no longer enforced by the CLR by default. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, string dir, System.Security.PermissionSet requiredPermissions, System.Security.PermissionSet optionalPermissions, System.Security.PermissionSet refusedPermissions) { throw null; }
//REFEMIT        [System.ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of DefineDynamicAssembly which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkId=155570 for more information.")]
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, string dir, System.Security.Policy.Evidence evidence) { throw null; }
//REFEMIT        [System.ObsoleteAttribute("Assembly level declarative security is obsolete and is no longer enforced by the CLR by default.  Please see http://go.microsoft.com/fwlink/?LinkId=155570 for more information.")]
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, string dir, System.Security.Policy.Evidence evidence, System.Security.PermissionSet requiredPermissions, System.Security.PermissionSet optionalPermissions, System.Security.PermissionSet refusedPermissions) { throw null; }
//REFEMIT        [System.ObsoleteAttribute("Assembly level declarative security is obsolete and is no longer enforced by the CLR by default. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, string dir, System.Security.Policy.Evidence evidence, System.Security.PermissionSet requiredPermissions, System.Security.PermissionSet optionalPermissions, System.Security.PermissionSet refusedPermissions, bool isSynchronized) { throw null; }
//REFEMIT        [System.ObsoleteAttribute("Assembly level declarative security is obsolete and is no longer enforced by the CLR by default. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, string dir, System.Security.Policy.Evidence evidence, System.Security.PermissionSet requiredPermissions, System.Security.PermissionSet optionalPermissions, System.Security.PermissionSet refusedPermissions, bool isSynchronized, System.Collections.Generic.IEnumerable<System.Reflection.Emit.CustomAttributeBuilder> assemblyAttributes) { throw null; }
//REMOTING        public void DoCallBack(System.CrossAppDomainDelegate callBackDelegate) { }
        public int ExecuteAssembly(string assemblyFile) { throw null; }
//CAS        [System.ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of ExecuteAssembly which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//CAS        public int ExecuteAssembly(string assemblyFile, System.Security.Policy.Evidence assemblySecurity) { throw null; }
//CAS        [System.ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of ExecuteAssembly which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//CAS        public int ExecuteAssembly(string assemblyFile, System.Security.Policy.Evidence assemblySecurity, string[] args) { throw null; }
//CAS        [System.ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of ExecuteAssembly which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//CAS        public int ExecuteAssembly(string assemblyFile, System.Security.Policy.Evidence assemblySecurity, string[] args, byte[] hashValue, System.Configuration.Assemblies.AssemblyHashAlgorithm hashAlgorithm) { throw null; }
        public int ExecuteAssembly(string assemblyFile, string[] args) { throw null; }
        public int ExecuteAssembly(string assemblyFile, string[] args, byte[] hashValue, System.Configuration.Assemblies.AssemblyHashAlgorithm hashAlgorithm) { throw null; }
//CAS        [System.ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of ExecuteAssemblyByName which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//CAS        public int ExecuteAssemblyByName(System.Reflection.AssemblyName assemblyName, System.Security.Policy.Evidence assemblySecurity, params string[] args) { throw null; }
        public int ExecuteAssemblyByName(System.Reflection.AssemblyName assemblyName, params string[] args) { throw null; }
        public int ExecuteAssemblyByName(string assemblyName) { throw null; }
//CAS        [System.ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of ExecuteAssemblyByName which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//CAS        public int ExecuteAssemblyByName(string assemblyName, System.Security.Policy.Evidence assemblySecurity) { throw null; }
//CAS        [System.ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of ExecuteAssemblyByName which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//CAS        public int ExecuteAssemblyByName(string assemblyName, System.Security.Policy.Evidence assemblySecurity, params string[] args) { throw null; }
        public int ExecuteAssemblyByName(string assemblyName, params string[] args) { throw null; }
        public System.Reflection.Assembly[] GetAssemblies() { throw null; }
        [System.ObsoleteAttribute("AppDomain.GetCurrentThreadId has been deprecated because it does not provide a stable Id when managed threads are running on fibers (aka lightweight threads). To get a stable identifier for a managed thread, use the ManagedThreadId property on Thread.  http://go.microsoft.com/fwlink/?linkid=14202", false)]
        public static int GetCurrentThreadId() { throw null; }
        public object GetData(string name) { throw null; }
        public new System.Type GetType() { throw null; }
        public override object InitializeLifetimeService() { throw null; }
        public System.Nullable<bool> IsCompatibilitySwitchSet(string value) { throw null; }
        public bool IsDefaultAppDomain() { throw null; }
        public bool IsFinalizingForUnload() { throw null; }
        public System.Reflection.Assembly Load(byte[] rawAssembly) { throw null; }
        public System.Reflection.Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore) { throw null; }
//CAS        [System.ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of Load which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkId=155570 for more information.")]
//CAS        public System.Reflection.Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore, System.Security.Policy.Evidence securityEvidence) { throw null; }
        public System.Reflection.Assembly Load(System.Reflection.AssemblyName assemblyRef) { throw null; }
//CAS        [System.ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of Load which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//CAS        public System.Reflection.Assembly Load(System.Reflection.AssemblyName assemblyRef, System.Security.Policy.Evidence assemblySecurity) { throw null; }
        public System.Reflection.Assembly Load(string assemblyString) { throw null; }
//CAS        [System.ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of Load which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//CAS        public System.Reflection.Assembly Load(string assemblyString, System.Security.Policy.Evidence assemblySecurity) { throw null; }
        public System.Reflection.Assembly[] ReflectionOnlyGetAssemblies() { throw null; }
//CAS        [System.ObsoleteAttribute("AppDomain policy levels are obsolete and will be removed in a future release of the .NET Framework. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//CAS        public void SetAppDomainPolicy(System.Security.Policy.PolicyLevel domainPolicy) { }
        [System.ObsoleteAttribute("AppDomain.SetCachePath has been deprecated. Please investigate the use of AppDomainSetup.CachePath instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        public void SetCachePath(string path) { }
        public void SetData(string name, object data) { }
//CAS        public void SetData(string name, object data, System.Security.IPermission permission) { }
        [System.ObsoleteAttribute("AppDomain.SetDynamicBase has been deprecated. Please investigate the use of AppDomainSetup.DynamicBase instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        public void SetDynamicBase(string path) { }
        public void SetPrincipalPolicy(System.Security.Principal.PrincipalPolicy policy) { }
        [System.ObsoleteAttribute("AppDomain.SetShadowCopyFiles has been deprecated. Please investigate the use of AppDomainSetup.ShadowCopyFiles instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        public void SetShadowCopyFiles() { }
        [System.ObsoleteAttribute("AppDomain.SetShadowCopyPath has been deprecated. Please investigate the use of AppDomainSetup.ShadowCopyDirectories instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        public void SetShadowCopyPath(string path) { }
        public void SetThreadPrincipal(System.Security.Principal.IPrincipal principal) { }
        public override string ToString() { throw null; }
        public static void Unload(System.AppDomain domain) { }
    }
    public partial class AppDomainUnloadedException : System.SystemException
    {
        public AppDomainUnloadedException() { }
        protected AppDomainUnloadedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public AppDomainUnloadedException(string message) { }
        public AppDomainUnloadedException(string message, System.Exception innerException) { }
    }
    public partial class CannotUnloadAppDomainException : System.SystemException
    {
        public CannotUnloadAppDomainException() { }
        protected CannotUnloadAppDomainException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public CannotUnloadAppDomainException(string message) { }
        public CannotUnloadAppDomainException(string message, System.Exception innerException) { }
    }
}
