// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System
{
    public partial class AccessViolationException : System.SystemException
    {
        public AccessViolationException() { }
        protected AccessViolationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public AccessViolationException(string message) { }
        public AccessViolationException(string message, System.Exception innerException) { }
    }
    public delegate void Action();
    public delegate void Action<in T>(T obj);
    public delegate void Action<in T1, in T2>(T1 arg1, T2 arg2);
    public delegate void Action<in T1, in T2, in T3>(T1 arg1, T2 arg2, T3 arg3);
    public delegate void Action<in T1, in T2, in T3, in T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4);
    public delegate void Action<in T1, in T2, in T3, in T4, in T5>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);
    public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);
    public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);
    public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);
    public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9);
    public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10);
    public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11);
    public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12);
    public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13);
    public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14);
    public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15);
    public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16);
    public static partial class Activator
    {
//REMOTING        public static System.Runtime.Remoting.ObjectHandle CreateComInstanceFrom(string assemblyName, string typeName) { throw null; }
//REMOTING        public static System.Runtime.Remoting.ObjectHandle CreateComInstanceFrom(string assemblyName, string typeName, byte[] hashValue, System.Configuration.Assemblies.AssemblyHashAlgorithm hashAlgorithm) { throw null; }
//REMOTING        public static System.Runtime.Remoting.ObjectHandle CreateInstance(System.ActivationContext activationContext) { throw null; }
//REMOTING        public static System.Runtime.Remoting.ObjectHandle CreateInstance(System.ActivationContext activationContext, string[] activationCustomData) { throw null; }
//REMOTING        public static System.Runtime.Remoting.ObjectHandle CreateInstance(System.AppDomain domain, string assemblyName, string typeName) { throw null; }
//REMOTING        public static System.Runtime.Remoting.ObjectHandle CreateInstance(System.AppDomain domain, string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes) { throw null; }
//REMOTING        [System.ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of CreateInstance which does not take an Evidence parameter. See https://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//REMOTING        public static System.Runtime.Remoting.ObjectHandle CreateInstance(System.AppDomain domain, string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityAttributes) { throw null; }
//REMOTING        public static System.Runtime.Remoting.ObjectHandle CreateInstance(string assemblyName, string typeName) { throw null; }
//REMOTING        public static System.Runtime.Remoting.ObjectHandle CreateInstance(string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes) { throw null; }
//REMOTING        [System.ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of CreateInstance which does not take an Evidence parameter. See https://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
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
//REMOTING        [System.ObsoleteAttribute("Methods which use Evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of CreateInstanceFrom which does not take an Evidence parameter. See https://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//REMOTING        public static System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(System.AppDomain domain, string assemblyFile, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityAttributes) { throw null; }
//REMOTING        public static System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName) { throw null; }
//REMOTING        public static System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes) { throw null; }
//REMOTING        [System.ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of CreateInstanceFrom which does not take an Evidence parameter. See https://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//REMOTING        public static System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityInfo) { throw null; }
//REMOTING        public static System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, object[] activationAttributes) { throw null; }
//REMOTING        public static object GetObject(System.Type type, string url) { throw null; }
//REMOTING        public static object GetObject(System.Type type, string url, object state) { throw null; }
    }
    public partial class AggregateException : System.Exception
    {
        public AggregateException() { }
        public AggregateException(System.Collections.Generic.IEnumerable<System.Exception> innerExceptions) { }
        public AggregateException(params System.Exception[] innerExceptions) { }
        protected AggregateException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public AggregateException(string message) { }
        public AggregateException(string message, System.Collections.Generic.IEnumerable<System.Exception> innerExceptions) { }
        public AggregateException(string message, System.Exception innerException) { }
        public AggregateException(string message, params System.Exception[] innerExceptions) { }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Exception> InnerExceptions { get { throw null; } }
        public override string Message { get { throw null; } }
        public System.AggregateException Flatten() { throw null; }
        public override System.Exception GetBaseException() { throw null; }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public void Handle(System.Func<System.Exception, bool> predicate) { }
        public override string ToString() { throw null; }
    }
    public static partial class AppContext
    {
        public static string BaseDirectory { get { throw null; } }
        public static string TargetFrameworkName { get { throw null; } }
        public static object GetData(string name) { throw null; }
        public static void SetSwitch(string switchName, bool isEnabled) { }
        public static bool TryGetSwitch(string switchName, out bool isEnabled) { throw null; }
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
        [System.ObsoleteAttribute("AppDomain.AppendPrivatePath has been deprecated. Please investigate the use of AppDomainSetup.PrivateBinPath instead. https://go.microsoft.com/fwlink/?linkid=14202")]
        public void AppendPrivatePath(string path) { }
        public string ApplyPolicy(string assemblyName) { throw null; }
        [System.ObsoleteAttribute("AppDomain.ClearPrivatePath has been deprecated. Please investigate the use of AppDomainSetup.PrivateBinPath instead. https://go.microsoft.com/fwlink/?linkid=14202")]
        public void ClearPrivatePath() { }
        [System.ObsoleteAttribute("AppDomain.ClearShadowCopyPath has been deprecated. Please investigate the use of AppDomainSetup.ShadowCopyDirectories instead. https://go.microsoft.com/fwlink/?linkid=14202")]
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
//REMOTING        [System.ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of CreateInstance which does not take an Evidence parameter. See https://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//REMOTING        public System.Runtime.Remoting.ObjectHandle CreateInstance(string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityAttributes) { throw null; }
//REMOTING        public System.Runtime.Remoting.ObjectHandle CreateInstance(string assemblyName, string typeName, object[] activationAttributes) { throw null; }
//REMOTING        public object CreateInstanceAndUnwrap(string assemblyName, string typeName) { throw null; }
//REMOTING        public object CreateInstanceAndUnwrap(string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes) { throw null; }
//REMOTING        [System.ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of CreateInstanceAndUnwrap which does not take an Evidence parameter. See https://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//REMOTING        public object CreateInstanceAndUnwrap(string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityAttributes) { throw null; }
//REMOTING        public object CreateInstanceAndUnwrap(string assemblyName, string typeName, object[] activationAttributes) { throw null; }
//REMOTING        public System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName) { throw null; }
//REMOTING        public System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes) { throw null; }
//REMOTING        [System.ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of CreateInstanceFrom which does not take an Evidence parameter. See https://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//REMOTING        public System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityAttributes) { throw null; }
//REMOTING        public System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, object[] activationAttributes) { throw null; }
//REMOTING        public object CreateInstanceFromAndUnwrap(string assemblyName, string typeName) { throw null; }
//REMOTING        public object CreateInstanceFromAndUnwrap(string assemblyFile, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes) { throw null; }
//REMOTING        [System.ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of CreateInstanceFromAndUnwrap which does not take an Evidence parameter. See https://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//REMOTING        public object CreateInstanceFromAndUnwrap(string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityAttributes) { throw null; }
//REMOTING        public object CreateInstanceFromAndUnwrap(string assemblyName, string typeName, object[] activationAttributes) { throw null; }
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access) { throw null; }
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, System.Collections.Generic.IEnumerable<System.Reflection.Emit.CustomAttributeBuilder> assemblyAttributes) { throw null; }
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, System.Collections.Generic.IEnumerable<System.Reflection.Emit.CustomAttributeBuilder> assemblyAttributes, System.Security.SecurityContextSource securityContextSource) { throw null; }
//REFEMIT        [System.ObsoleteAttribute("Assembly level declarative security is obsolete and is no longer enforced by the CLR by default.  See https://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, System.Security.PermissionSet requiredPermissions, System.Security.PermissionSet optionalPermissions, System.Security.PermissionSet refusedPermissions) { throw null; }
//REFEMIT        [System.ObsoleteAttribute("Assembly level declarative security is obsolete and is no longer enforced by the CLR by default.  See https://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, System.Security.Policy.Evidence evidence) { throw null; }
//REFEMIT        [System.ObsoleteAttribute("Assembly level declarative security is obsolete and is no longer enforced by the CLR by default. See https://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, System.Security.Policy.Evidence evidence, System.Security.PermissionSet requiredPermissions, System.Security.PermissionSet optionalPermissions, System.Security.PermissionSet refusedPermissions) { throw null; }
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, string dir) { throw null; }
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, string dir, bool isSynchronized, System.Collections.Generic.IEnumerable<System.Reflection.Emit.CustomAttributeBuilder> assemblyAttributes) { throw null; }
//REFEMIT        [System.ObsoleteAttribute("Assembly level declarative security is obsolete and is no longer enforced by the CLR by default. See https://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, string dir, System.Security.PermissionSet requiredPermissions, System.Security.PermissionSet optionalPermissions, System.Security.PermissionSet refusedPermissions) { throw null; }
//REFEMIT        [System.ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of DefineDynamicAssembly which does not take an Evidence parameter. See https://go.microsoft.com/fwlink/?LinkId=155570 for more information.")]
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, string dir, System.Security.Policy.Evidence evidence) { throw null; }
//REFEMIT        [System.ObsoleteAttribute("Assembly level declarative security is obsolete and is no longer enforced by the CLR by default.  Please see https://go.microsoft.com/fwlink/?LinkId=155570 for more information.")]
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, string dir, System.Security.Policy.Evidence evidence, System.Security.PermissionSet requiredPermissions, System.Security.PermissionSet optionalPermissions, System.Security.PermissionSet refusedPermissions) { throw null; }
//REFEMIT        [System.ObsoleteAttribute("Assembly level declarative security is obsolete and is no longer enforced by the CLR by default. See https://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, string dir, System.Security.Policy.Evidence evidence, System.Security.PermissionSet requiredPermissions, System.Security.PermissionSet optionalPermissions, System.Security.PermissionSet refusedPermissions, bool isSynchronized) { throw null; }
//REFEMIT        [System.ObsoleteAttribute("Assembly level declarative security is obsolete and is no longer enforced by the CLR by default. See https://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, string dir, System.Security.Policy.Evidence evidence, System.Security.PermissionSet requiredPermissions, System.Security.PermissionSet optionalPermissions, System.Security.PermissionSet refusedPermissions, bool isSynchronized, System.Collections.Generic.IEnumerable<System.Reflection.Emit.CustomAttributeBuilder> assemblyAttributes) { throw null; }
//REMOTING        public void DoCallBack(System.CrossAppDomainDelegate callBackDelegate) { }
        public int ExecuteAssembly(string assemblyFile) { throw null; }
//CAS        [System.ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of ExecuteAssembly which does not take an Evidence parameter. See https://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//CAS        public int ExecuteAssembly(string assemblyFile, System.Security.Policy.Evidence assemblySecurity) { throw null; }
//CAS        [System.ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of ExecuteAssembly which does not take an Evidence parameter. See https://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//CAS        public int ExecuteAssembly(string assemblyFile, System.Security.Policy.Evidence assemblySecurity, string[] args) { throw null; }
//CAS        [System.ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of ExecuteAssembly which does not take an Evidence parameter. See https://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//CAS        public int ExecuteAssembly(string assemblyFile, System.Security.Policy.Evidence assemblySecurity, string[] args, byte[] hashValue, System.Configuration.Assemblies.AssemblyHashAlgorithm hashAlgorithm) { throw null; }
        public int ExecuteAssembly(string assemblyFile, string[] args) { throw null; }
        public int ExecuteAssembly(string assemblyFile, string[] args, byte[] hashValue, System.Configuration.Assemblies.AssemblyHashAlgorithm hashAlgorithm) { throw null; }
//CAS        [System.ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of ExecuteAssemblyByName which does not take an Evidence parameter. See https://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//CAS        public int ExecuteAssemblyByName(System.Reflection.AssemblyName assemblyName, System.Security.Policy.Evidence assemblySecurity, params string[] args) { throw null; }
        public int ExecuteAssemblyByName(System.Reflection.AssemblyName assemblyName, params string[] args) { throw null; }
        public int ExecuteAssemblyByName(string assemblyName) { throw null; }
//CAS        [System.ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of ExecuteAssemblyByName which does not take an Evidence parameter. See https://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//CAS        public int ExecuteAssemblyByName(string assemblyName, System.Security.Policy.Evidence assemblySecurity) { throw null; }
//CAS        [System.ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of ExecuteAssemblyByName which does not take an Evidence parameter. See https://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//CAS        public int ExecuteAssemblyByName(string assemblyName, System.Security.Policy.Evidence assemblySecurity, params string[] args) { throw null; }
        public int ExecuteAssemblyByName(string assemblyName, params string[] args) { throw null; }
        public System.Reflection.Assembly[] GetAssemblies() { throw null; }
        [System.ObsoleteAttribute("AppDomain.GetCurrentThreadId has been deprecated because it does not provide a stable Id when managed threads are running on fibers (aka lightweight threads). To get a stable identifier for a managed thread, use the ManagedThreadId property on Thread.  https://go.microsoft.com/fwlink/?linkid=14202", false)]
        public static int GetCurrentThreadId() { throw null; }
        public object GetData(string name) { throw null; }
        public System.Nullable<bool> IsCompatibilitySwitchSet(string value) { throw null; }
        public bool IsDefaultAppDomain() { throw null; }
        public bool IsFinalizingForUnload() { throw null; }
        public System.Reflection.Assembly Load(byte[] rawAssembly) { throw null; }
        public System.Reflection.Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore) { throw null; }
//CAS        [System.ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of Load which does not take an Evidence parameter. See https://go.microsoft.com/fwlink/?LinkId=155570 for more information.")]
//CAS        public System.Reflection.Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore, System.Security.Policy.Evidence securityEvidence) { throw null; }
        public System.Reflection.Assembly Load(System.Reflection.AssemblyName assemblyRef) { throw null; }
//CAS        [System.ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of Load which does not take an Evidence parameter. See https://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//CAS        public System.Reflection.Assembly Load(System.Reflection.AssemblyName assemblyRef, System.Security.Policy.Evidence assemblySecurity) { throw null; }
        public System.Reflection.Assembly Load(string assemblyString) { throw null; }
//CAS        [System.ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of Load which does not take an Evidence parameter. See https://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//CAS        public System.Reflection.Assembly Load(string assemblyString, System.Security.Policy.Evidence assemblySecurity) { throw null; }
        public System.Reflection.Assembly[] ReflectionOnlyGetAssemblies() { throw null; }
//CAS        [System.ObsoleteAttribute("AppDomain policy levels are obsolete and will be removed in a future release of the .NET Framework. See https://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//CAS        public void SetAppDomainPolicy(System.Security.Policy.PolicyLevel domainPolicy) { }
        [System.ObsoleteAttribute("AppDomain.SetCachePath has been deprecated. Please investigate the use of AppDomainSetup.CachePath instead. https://go.microsoft.com/fwlink/?linkid=14202")]
        public void SetCachePath(string path) { }
        public void SetData(string name, object data) { }
//CAS        public void SetData(string name, object data, System.Security.IPermission permission) { }
        [System.ObsoleteAttribute("AppDomain.SetDynamicBase has been deprecated. Please investigate the use of AppDomainSetup.DynamicBase instead. https://go.microsoft.com/fwlink/?linkid=14202")]
        public void SetDynamicBase(string path) { }
        public void SetPrincipalPolicy(System.Security.Principal.PrincipalPolicy policy) { }
        [System.ObsoleteAttribute("AppDomain.SetShadowCopyFiles has been deprecated. Please investigate the use of AppDomainSetup.ShadowCopyFiles instead. https://go.microsoft.com/fwlink/?linkid=14202")]
        public void SetShadowCopyFiles() { }
        [System.ObsoleteAttribute("AppDomain.SetShadowCopyPath has been deprecated. Please investigate the use of AppDomainSetup.ShadowCopyDirectories instead. https://go.microsoft.com/fwlink/?linkid=14202")]
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
    public partial class ApplicationException : System.Exception
    {
        public ApplicationException() { }
        protected ApplicationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public ApplicationException(string message) { }
        public ApplicationException(string message, System.Exception innerException) { }
    }
    public sealed partial class ApplicationId
    {
        public ApplicationId(byte[] publicKeyToken, string name, System.Version version, string processorArchitecture, string culture) { }
        public string Culture { get { throw null; } }
        public string Name { get { throw null; } }
        public string ProcessorArchitecture { get { throw null; } }
        public byte[] PublicKeyToken { get { throw null; } }
        public System.Version Version { get { throw null; } }
        public System.ApplicationId Copy() { throw null; }
        public override bool Equals(object o) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ArgumentException : System.SystemException
    {
        public ArgumentException() { }
        protected ArgumentException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public ArgumentException(string message) { }
        public ArgumentException(string message, System.Exception innerException) { }
        public ArgumentException(string message, string paramName) { }
        public ArgumentException(string message, string paramName, System.Exception innerException) { }
        public override string Message { get { throw null; } }
        public virtual string ParamName { get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public partial class ArgumentNullException : System.ArgumentException
    {
        public ArgumentNullException() { }
        protected ArgumentNullException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public ArgumentNullException(string paramName) { }
        public ArgumentNullException(string message, System.Exception innerException) { }
        public ArgumentNullException(string paramName, string message) { }
    }
    public partial class ArgumentOutOfRangeException : System.ArgumentException
    {
        public ArgumentOutOfRangeException() { }
        protected ArgumentOutOfRangeException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public ArgumentOutOfRangeException(string paramName) { }
        public ArgumentOutOfRangeException(string message, System.Exception innerException) { }
        public ArgumentOutOfRangeException(string paramName, object actualValue, string message) { }
        public ArgumentOutOfRangeException(string paramName, string message) { }
        public virtual object ActualValue { get { throw null; } }
        public override string Message { get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public partial class ArithmeticException : System.SystemException
    {
        public ArithmeticException() { }
        protected ArithmeticException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public ArithmeticException(string message) { }
        public ArithmeticException(string message, System.Exception innerException) { }
    }
    public abstract partial class Array : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.Collections.IStructuralComparable, System.Collections.IStructuralEquatable, System.ICloneable
    {
        internal Array() { }
        public bool IsFixedSize { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public bool IsSynchronized { get { throw null; } }
        public int Length { get { throw null; } }
        public long LongLength { get { throw null; } }
        public int Rank { get { throw null; } }
        public object SyncRoot { get { throw null; } }
        int System.Collections.ICollection.Count { get { throw null; } }
        object System.Collections.IList.this[int index] { get { throw null; } set { } }
        public static System.Collections.ObjectModel.ReadOnlyCollection<T> AsReadOnly<T>(T[] array) { throw null; }
        public static int BinarySearch(System.Array array, int index, int length, object value) { throw null; }
        public static int BinarySearch(System.Array array, int index, int length, object value, System.Collections.IComparer comparer) { throw null; }
        public static int BinarySearch(System.Array array, object value) { throw null; }
        public static int BinarySearch(System.Array array, object value, System.Collections.IComparer comparer) { throw null; }
        public static int BinarySearch<T>(T[] array, int index, int length, T value) { throw null; }
        public static int BinarySearch<T>(T[] array, int index, int length, T value, System.Collections.Generic.IComparer<T> comparer) { throw null; }
        public static int BinarySearch<T>(T[] array, T value) { throw null; }
        public static int BinarySearch<T>(T[] array, T value, System.Collections.Generic.IComparer<T> comparer) { throw null; }
        public static void Clear(System.Array array, int index, int length) { }
        public object Clone() { throw null; }
        public static void ConstrainedCopy(System.Array sourceArray, int sourceIndex, System.Array destinationArray, int destinationIndex, int length) { }
        public static TOutput[] ConvertAll<TInput, TOutput>(TInput[] array, System.Converter<TInput, TOutput> converter) { throw null; }
        public static void Copy(System.Array sourceArray, System.Array destinationArray, int length) { }
        public static void Copy(System.Array sourceArray, System.Array destinationArray, long length) { }
        public static void Copy(System.Array sourceArray, int sourceIndex, System.Array destinationArray, int destinationIndex, int length) { }
        public static void Copy(System.Array sourceArray, long sourceIndex, System.Array destinationArray, long destinationIndex, long length) { }
        public void CopyTo(System.Array array, int index) { }
        public void CopyTo(System.Array array, long index) { }
        public static System.Array CreateInstance(System.Type elementType, int length) { throw null; }
        public static System.Array CreateInstance(System.Type elementType, int length1, int length2) { throw null; }
        public static System.Array CreateInstance(System.Type elementType, int length1, int length2, int length3) { throw null; }
        public static System.Array CreateInstance(System.Type elementType, params int[] lengths) { throw null; }
        public static System.Array CreateInstance(System.Type elementType, int[] lengths, int[] lowerBounds) { throw null; }
        public static System.Array CreateInstance(System.Type elementType, params long[] lengths) { throw null; }
        public static T[] Empty<T>() { throw null; }
        public static bool Exists<T>(T[] array, System.Predicate<T> match) { throw null; }
        public static void Fill<T>(T[] array, T value) { }
        public static void Fill<T>(T[] array, T value, int startIndex, int count) { }
        public static T[] FindAll<T>(T[] array, System.Predicate<T> match) { throw null; }
        public static int FindIndex<T>(T[] array, int startIndex, int count, System.Predicate<T> match) { throw null; }
        public static int FindIndex<T>(T[] array, int startIndex, System.Predicate<T> match) { throw null; }
        public static int FindIndex<T>(T[] array, System.Predicate<T> match) { throw null; }
        public static int FindLastIndex<T>(T[] array, int startIndex, int count, System.Predicate<T> match) { throw null; }
        public static int FindLastIndex<T>(T[] array, int startIndex, System.Predicate<T> match) { throw null; }
        public static int FindLastIndex<T>(T[] array, System.Predicate<T> match) { throw null; }
        public static T FindLast<T>(T[] array, System.Predicate<T> match) { throw null; }
        public static T Find<T>(T[] array, System.Predicate<T> match) { throw null; }
        public static void ForEach<T>(T[] array, System.Action<T> action) { }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        public int GetLength(int dimension) { throw null; }
        public long GetLongLength(int dimension) { throw null; }
        public int GetLowerBound(int dimension) { throw null; }
        public int GetUpperBound(int dimension) { throw null; }
        public object GetValue(int index) { throw null; }
        public object GetValue(int index1, int index2) { throw null; }
        public object GetValue(int index1, int index2, int index3) { throw null; }
        public object GetValue(params int[] indices) { throw null; }
        public object GetValue(long index) { throw null; }
        public object GetValue(long index1, long index2) { throw null; }
        public object GetValue(long index1, long index2, long index3) { throw null; }
        public object GetValue(params long[] indices) { throw null; }
        public static int IndexOf(System.Array array, object value) { throw null; }
        public static int IndexOf(System.Array array, object value, int startIndex) { throw null; }
        public static int IndexOf(System.Array array, object value, int startIndex, int count) { throw null; }
        public static int IndexOf<T>(T[] array, T value) { throw null; }
        public static int IndexOf<T>(T[] array, T value, int startIndex) { throw null; }
        public static int IndexOf<T>(T[] array, T value, int startIndex, int count) { throw null; }
        public void Initialize() { }
        public static int LastIndexOf(System.Array array, object value) { throw null; }
        public static int LastIndexOf(System.Array array, object value, int startIndex) { throw null; }
        public static int LastIndexOf(System.Array array, object value, int startIndex, int count) { throw null; }
        public static int LastIndexOf<T>(T[] array, T value) { throw null; }
        public static int LastIndexOf<T>(T[] array, T value, int startIndex) { throw null; }
        public static int LastIndexOf<T>(T[] array, T value, int startIndex, int count) { throw null; }
        public static void Resize<T>(ref T[] array, int newSize) { }
        public static void Reverse(System.Array array) { }
        public static void Reverse(System.Array array, int index, int length) { }
        public static void Reverse<T>(T[] array) { }
        public static void Reverse<T>(T[] array, int index, int length) { }
        public void SetValue(object value, int index) { }
        public void SetValue(object value, int index1, int index2) { }
        public void SetValue(object value, int index1, int index2, int index3) { }
        public void SetValue(object value, params int[] indices) { }
        public void SetValue(object value, long index) { }
        public void SetValue(object value, long index1, long index2) { }
        public void SetValue(object value, long index1, long index2, long index3) { }
        public void SetValue(object value, params long[] indices) { }
        public static void Sort(System.Array array) { }
        public static void Sort(System.Array keys, System.Array items) { }
        public static void Sort(System.Array keys, System.Array items, System.Collections.IComparer comparer) { }
        public static void Sort(System.Array keys, System.Array items, int index, int length) { }
        public static void Sort(System.Array keys, System.Array items, int index, int length, System.Collections.IComparer comparer) { }
        public static void Sort(System.Array array, System.Collections.IComparer comparer) { }
        public static void Sort(System.Array array, int index, int length) { }
        public static void Sort(System.Array array, int index, int length, System.Collections.IComparer comparer) { }
        public static void Sort<T>(T[] array) { }
        public static void Sort<T>(T[] array, System.Collections.Generic.IComparer<T> comparer) { }
        public static void Sort<T>(T[] array, System.Comparison<T> comparison) { }
        public static void Sort<T>(T[] array, int index, int length) { }
        public static void Sort<T>(T[] array, int index, int length, System.Collections.Generic.IComparer<T> comparer) { }
        public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items) { }
        public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, System.Collections.Generic.IComparer<TKey> comparer) { }
        public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, int index, int length) { }
        public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, int index, int length, System.Collections.Generic.IComparer<TKey> comparer) { }
        int System.Collections.IList.Add(object value) { throw null; }
        void System.Collections.IList.Clear() { }
        bool System.Collections.IList.Contains(object value) { throw null; }
        int System.Collections.IList.IndexOf(object value) { throw null; }
        void System.Collections.IList.Insert(int index, object value) { }
        void System.Collections.IList.Remove(object value) { }
        void System.Collections.IList.RemoveAt(int index) { }
        int System.Collections.IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) { throw null; }
        bool System.Collections.IStructuralEquatable.Equals(object other, System.Collections.IEqualityComparer comparer) { throw null; }
        int System.Collections.IStructuralEquatable.GetHashCode(System.Collections.IEqualityComparer comparer) { throw null; }
        public static bool TrueForAll<T>(T[] array, System.Predicate<T> match) { throw null; }
    }
    public readonly partial struct ArraySegment<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.Generic.IReadOnlyCollection<T>, System.Collections.Generic.IReadOnlyList<T>, System.Collections.IEnumerable
    {
        private readonly T[] _array;
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ArraySegment(T[] array) { throw null; }
        public ArraySegment(T[] array, int offset, int count) { throw null; }
        public T[] Array { get { throw null; } }
        public int Count { get { throw null; } }
        public static System.ArraySegment<T> Empty { get { throw null; } }
        public T this[int index] { get { throw null; } set { } }
        public int Offset { get { throw null; } }
        bool System.Collections.Generic.ICollection<T>.IsReadOnly { get { throw null; } }
        T System.Collections.Generic.IList<T>.this[int index] { get { throw null; } set { } }
        T System.Collections.Generic.IReadOnlyList<T>.this[int index] { get { throw null; } }
        public void CopyTo(System.ArraySegment<T> destination) { }
        public void CopyTo(T[] destination) { }
        public void CopyTo(T[] destination, int destinationIndex) { }
        public bool Equals(System.ArraySegment<T> obj) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public System.ArraySegment<T>.Enumerator GetEnumerator() { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.ArraySegment<T> a, System.ArraySegment<T> b) { throw null; }
        public static implicit operator System.ArraySegment<T> (T[] array) { throw null; }
        public static bool operator !=(System.ArraySegment<T> a, System.ArraySegment<T> b) { throw null; }
        public System.ArraySegment<T> Slice(int index) { throw null; }
        public System.ArraySegment<T> Slice(int index, int count) { throw null; }
        void System.Collections.Generic.ICollection<T>.Add(T item) { }
        void System.Collections.Generic.ICollection<T>.Clear() { }
        bool System.Collections.Generic.ICollection<T>.Contains(T item) { throw null; }
        bool System.Collections.Generic.ICollection<T>.Remove(T item) { throw null; }
        System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { throw null; }
        int System.Collections.Generic.IList<T>.IndexOf(T item) { throw null; }
        void System.Collections.Generic.IList<T>.Insert(int index, T item) { }
        void System.Collections.Generic.IList<T>.RemoveAt(int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public T[] ToArray() { throw null; }
        public partial struct Enumerator : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
        {
            private readonly T[] _array;
            private object _dummy;
            private int _dummyPrimitive;
            public T Current { get { throw null; } }
            object System.Collections.IEnumerator.Current { get { throw null; } }
            public void Dispose() { }
            public bool MoveNext() { throw null; }
            void System.Collections.IEnumerator.Reset() { }
        }
    }
    public partial class ArrayTypeMismatchException : System.SystemException
    {
        public ArrayTypeMismatchException() { }
        protected ArrayTypeMismatchException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public ArrayTypeMismatchException(string message) { }
        public ArrayTypeMismatchException(string message, System.Exception innerException) { }
    }
    public partial class AssemblyLoadEventArgs : System.EventArgs
    {
        public AssemblyLoadEventArgs(System.Reflection.Assembly loadedAssembly) { }
        public System.Reflection.Assembly LoadedAssembly { get { throw null; } }
    }
    public delegate void AssemblyLoadEventHandler(object sender, System.AssemblyLoadEventArgs args);
    public delegate void AsyncCallback(System.IAsyncResult ar);
    [System.AttributeUsageAttribute(System.AttributeTargets.All, Inherited=true, AllowMultiple=false)]
    public abstract partial class Attribute
    {
        protected Attribute() { }
        public virtual object TypeId { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public static System.Attribute GetCustomAttribute(System.Reflection.Assembly element, System.Type attributeType) { throw null; }
        public static System.Attribute GetCustomAttribute(System.Reflection.Assembly element, System.Type attributeType, bool inherit) { throw null; }
        public static System.Attribute GetCustomAttribute(System.Reflection.MemberInfo element, System.Type attributeType) { throw null; }
        public static System.Attribute GetCustomAttribute(System.Reflection.MemberInfo element, System.Type attributeType, bool inherit) { throw null; }
        public static System.Attribute GetCustomAttribute(System.Reflection.Module element, System.Type attributeType) { throw null; }
        public static System.Attribute GetCustomAttribute(System.Reflection.Module element, System.Type attributeType, bool inherit) { throw null; }
        public static System.Attribute GetCustomAttribute(System.Reflection.ParameterInfo element, System.Type attributeType) { throw null; }
        public static System.Attribute GetCustomAttribute(System.Reflection.ParameterInfo element, System.Type attributeType, bool inherit) { throw null; }
        public static System.Attribute[] GetCustomAttributes(System.Reflection.Assembly element) { throw null; }
        public static System.Attribute[] GetCustomAttributes(System.Reflection.Assembly element, bool inherit) { throw null; }
        public static System.Attribute[] GetCustomAttributes(System.Reflection.Assembly element, System.Type attributeType) { throw null; }
        public static System.Attribute[] GetCustomAttributes(System.Reflection.Assembly element, System.Type attributeType, bool inherit) { throw null; }
        public static System.Attribute[] GetCustomAttributes(System.Reflection.MemberInfo element) { throw null; }
        public static System.Attribute[] GetCustomAttributes(System.Reflection.MemberInfo element, bool inherit) { throw null; }
        public static System.Attribute[] GetCustomAttributes(System.Reflection.MemberInfo element, System.Type type) { throw null; }
        public static System.Attribute[] GetCustomAttributes(System.Reflection.MemberInfo element, System.Type type, bool inherit) { throw null; }
        public static System.Attribute[] GetCustomAttributes(System.Reflection.Module element) { throw null; }
        public static System.Attribute[] GetCustomAttributes(System.Reflection.Module element, bool inherit) { throw null; }
        public static System.Attribute[] GetCustomAttributes(System.Reflection.Module element, System.Type attributeType) { throw null; }
        public static System.Attribute[] GetCustomAttributes(System.Reflection.Module element, System.Type attributeType, bool inherit) { throw null; }
        public static System.Attribute[] GetCustomAttributes(System.Reflection.ParameterInfo element) { throw null; }
        public static System.Attribute[] GetCustomAttributes(System.Reflection.ParameterInfo element, bool inherit) { throw null; }
        public static System.Attribute[] GetCustomAttributes(System.Reflection.ParameterInfo element, System.Type attributeType) { throw null; }
        public static System.Attribute[] GetCustomAttributes(System.Reflection.ParameterInfo element, System.Type attributeType, bool inherit) { throw null; }
        public override int GetHashCode() { throw null; }
        public virtual bool IsDefaultAttribute() { throw null; }
        public static bool IsDefined(System.Reflection.Assembly element, System.Type attributeType) { throw null; }
        public static bool IsDefined(System.Reflection.Assembly element, System.Type attributeType, bool inherit) { throw null; }
        public static bool IsDefined(System.Reflection.MemberInfo element, System.Type attributeType) { throw null; }
        public static bool IsDefined(System.Reflection.MemberInfo element, System.Type attributeType, bool inherit) { throw null; }
        public static bool IsDefined(System.Reflection.Module element, System.Type attributeType) { throw null; }
        public static bool IsDefined(System.Reflection.Module element, System.Type attributeType, bool inherit) { throw null; }
        public static bool IsDefined(System.Reflection.ParameterInfo element, System.Type attributeType) { throw null; }
        public static bool IsDefined(System.Reflection.ParameterInfo element, System.Type attributeType, bool inherit) { throw null; }
        public virtual bool Match(object obj) { throw null; }
    }
    [System.FlagsAttribute]
    public enum AttributeTargets
    {
        All = 32767,
        Assembly = 1,
        Class = 4,
        Constructor = 32,
        Delegate = 4096,
        Enum = 16,
        Event = 512,
        Field = 256,
        GenericParameter = 16384,
        Interface = 1024,
        Method = 64,
        Module = 2,
        Parameter = 2048,
        Property = 128,
        ReturnValue = 8192,
        Struct = 8,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class, Inherited=true)]
    public sealed partial class AttributeUsageAttribute : System.Attribute
    {
        public AttributeUsageAttribute(System.AttributeTargets validOn) { }
        public bool AllowMultiple { get { throw null; } set { } }
        public bool Inherited { get { throw null; } set { } }
        public System.AttributeTargets ValidOn { get { throw null; } }
    }
    public partial class BadImageFormatException : System.SystemException
    {
        public BadImageFormatException() { }
        protected BadImageFormatException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public BadImageFormatException(string message) { }
        public BadImageFormatException(string message, System.Exception inner) { }
        public BadImageFormatException(string message, string fileName) { }
        public BadImageFormatException(string message, string fileName, System.Exception inner) { }
        public string FileName { get { throw null; } }
        public string FusionLog { get { throw null; } }
        public override string Message { get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public override string ToString() { throw null; }
    }
    [System.FlagsAttribute]
    public enum Base64FormattingOptions
    {
        InsertLineBreaks = 1,
        None = 0,
    }
    public static partial class BitConverter
    {
        public static readonly bool IsLittleEndian;
        public static long DoubleToInt64Bits(double value) { throw null; }
        public static byte[] GetBytes(bool value) { throw null; }
        public static byte[] GetBytes(char value) { throw null; }
        public static byte[] GetBytes(double value) { throw null; }
        public static byte[] GetBytes(short value) { throw null; }
        public static byte[] GetBytes(int value) { throw null; }
        public static byte[] GetBytes(long value) { throw null; }
        public static byte[] GetBytes(float value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static byte[] GetBytes(ushort value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static byte[] GetBytes(uint value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static byte[] GetBytes(ulong value) { throw null; }
        public static float Int32BitsToSingle(int value) { throw null; }
        public static double Int64BitsToDouble(long value) { throw null; }
        public static int SingleToInt32Bits(float value) { throw null; }
        public static bool ToBoolean(byte[] value, int startIndex) { throw null; }
        public static bool ToBoolean(System.ReadOnlySpan<byte> value) { throw null; }
        public static char ToChar(byte[] value, int startIndex) { throw null; }
        public static char ToChar(System.ReadOnlySpan<byte> value) { throw null; }
        public static double ToDouble(byte[] value, int startIndex) { throw null; }
        public static double ToDouble(System.ReadOnlySpan<byte> value) { throw null; }
        public static short ToInt16(byte[] value, int startIndex) { throw null; }
        public static short ToInt16(System.ReadOnlySpan<byte> value) { throw null; }
        public static int ToInt32(byte[] value, int startIndex) { throw null; }
        public static int ToInt32(System.ReadOnlySpan<byte> value) { throw null; }
        public static long ToInt64(byte[] value, int startIndex) { throw null; }
        public static long ToInt64(System.ReadOnlySpan<byte> value) { throw null; }
        public static float ToSingle(byte[] value, int startIndex) { throw null; }
        public static float ToSingle(System.ReadOnlySpan<byte> value) { throw null; }
        public static string ToString(byte[] value) { throw null; }
        public static string ToString(byte[] value, int startIndex) { throw null; }
        public static string ToString(byte[] value, int startIndex, int length) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(byte[] value, int startIndex) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(System.ReadOnlySpan<byte> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(byte[] value, int startIndex) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(System.ReadOnlySpan<byte> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(byte[] value, int startIndex) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(System.ReadOnlySpan<byte> value) { throw null; }
        public static bool TryWriteBytes(System.Span<byte> destination, bool value) { throw null; }
        public static bool TryWriteBytes(System.Span<byte> destination, char value) { throw null; }
        public static bool TryWriteBytes(System.Span<byte> destination, double value) { throw null; }
        public static bool TryWriteBytes(System.Span<byte> destination, short value) { throw null; }
        public static bool TryWriteBytes(System.Span<byte> destination, int value) { throw null; }
        public static bool TryWriteBytes(System.Span<byte> destination, long value) { throw null; }
        public static bool TryWriteBytes(System.Span<byte> destination, float value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static bool TryWriteBytes(System.Span<byte> destination, ushort value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static bool TryWriteBytes(System.Span<byte> destination, uint value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static bool TryWriteBytes(System.Span<byte> destination, ulong value) { throw null; }
    }
    public readonly partial struct Boolean : System.IComparable, System.IComparable<bool>, System.IConvertible, System.IEquatable<bool>
    {
        private readonly bool _dummyPrimitive;
        public static readonly string FalseString;
        public static readonly string TrueString;
        public int CompareTo(System.Boolean value) { throw null; }
        public int CompareTo(object obj) { throw null; }
        public System.Boolean Equals(System.Boolean obj) { throw null; }
        public override System.Boolean Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public System.TypeCode GetTypeCode() { throw null; }
        public static System.Boolean Parse(System.ReadOnlySpan<char> value) { throw null; }
        public static System.Boolean Parse(string value) { throw null; }
        System.Boolean System.IConvertible.ToBoolean(System.IFormatProvider provider) { throw null; }
        byte System.IConvertible.ToByte(System.IFormatProvider provider) { throw null; }
        char System.IConvertible.ToChar(System.IFormatProvider provider) { throw null; }
        System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider) { throw null; }
        decimal System.IConvertible.ToDecimal(System.IFormatProvider provider) { throw null; }
        double System.IConvertible.ToDouble(System.IFormatProvider provider) { throw null; }
        short System.IConvertible.ToInt16(System.IFormatProvider provider) { throw null; }
        int System.IConvertible.ToInt32(System.IFormatProvider provider) { throw null; }
        long System.IConvertible.ToInt64(System.IFormatProvider provider) { throw null; }
        sbyte System.IConvertible.ToSByte(System.IFormatProvider provider) { throw null; }
        float System.IConvertible.ToSingle(System.IFormatProvider provider) { throw null; }
        object System.IConvertible.ToType(System.Type type, System.IFormatProvider provider) { throw null; }
        ushort System.IConvertible.ToUInt16(System.IFormatProvider provider) { throw null; }
        uint System.IConvertible.ToUInt32(System.IFormatProvider provider) { throw null; }
        ulong System.IConvertible.ToUInt64(System.IFormatProvider provider) { throw null; }
        public override string ToString() { throw null; }
        public string ToString(System.IFormatProvider provider) { throw null; }
        public System.Boolean TryFormat(System.Span<char> destination, out int charsWritten) { throw null; }
        public static System.Boolean TryParse(System.ReadOnlySpan<char> value, out System.Boolean result) { throw null; }
        public static System.Boolean TryParse(string value, out System.Boolean result) { throw null; }
    }
    public static partial class Buffer
    {
        public static void BlockCopy(System.Array src, int srcOffset, System.Array dst, int dstOffset, int count) { }
        public static int ByteLength(System.Array array) { throw null; }
        public static byte GetByte(System.Array array, int index) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public unsafe static void MemoryCopy(void* source, void* destination, long destinationSizeInBytes, long sourceBytesToCopy) { }
        [System.CLSCompliantAttribute(false)]
        public unsafe static void MemoryCopy(void* source, void* destination, ulong destinationSizeInBytes, ulong sourceBytesToCopy) { }
        public static void SetByte(System.Array array, int index, byte value) { }
    }
    public readonly partial struct Byte : System.IComparable, System.IComparable<byte>, System.IConvertible, System.IEquatable<byte>, System.IFormattable
    {
        private readonly byte _dummyPrimitive;
        public const byte MaxValue = (byte)255;
        public const byte MinValue = (byte)0;
        public int CompareTo(System.Byte value) { throw null; }
        public int CompareTo(object value) { throw null; }
        public bool Equals(System.Byte obj) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public System.TypeCode GetTypeCode() { throw null; }
        public static System.Byte Parse(System.ReadOnlySpan<char> s, System.Globalization.NumberStyles style = System.Globalization.NumberStyles.Integer, System.IFormatProvider provider = null) { throw null; }
        public static System.Byte Parse(string s) { throw null; }
        public static System.Byte Parse(string s, System.Globalization.NumberStyles style) { throw null; }
        public static System.Byte Parse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider) { throw null; }
        public static System.Byte Parse(string s, System.IFormatProvider provider) { throw null; }
        bool System.IConvertible.ToBoolean(System.IFormatProvider provider) { throw null; }
        System.Byte System.IConvertible.ToByte(System.IFormatProvider provider) { throw null; }
        char System.IConvertible.ToChar(System.IFormatProvider provider) { throw null; }
        System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider) { throw null; }
        decimal System.IConvertible.ToDecimal(System.IFormatProvider provider) { throw null; }
        double System.IConvertible.ToDouble(System.IFormatProvider provider) { throw null; }
        short System.IConvertible.ToInt16(System.IFormatProvider provider) { throw null; }
        int System.IConvertible.ToInt32(System.IFormatProvider provider) { throw null; }
        long System.IConvertible.ToInt64(System.IFormatProvider provider) { throw null; }
        sbyte System.IConvertible.ToSByte(System.IFormatProvider provider) { throw null; }
        float System.IConvertible.ToSingle(System.IFormatProvider provider) { throw null; }
        object System.IConvertible.ToType(System.Type type, System.IFormatProvider provider) { throw null; }
        ushort System.IConvertible.ToUInt16(System.IFormatProvider provider) { throw null; }
        uint System.IConvertible.ToUInt32(System.IFormatProvider provider) { throw null; }
        ulong System.IConvertible.ToUInt64(System.IFormatProvider provider) { throw null; }
        public override string ToString() { throw null; }
        public string ToString(System.IFormatProvider provider) { throw null; }
        public string ToString(string format) { throw null; }
        public string ToString(string format, System.IFormatProvider provider) { throw null; }
        public bool TryFormat(System.Span<char> destination, out int charsWritten, System.ReadOnlySpan<char> format = default(System.ReadOnlySpan<char>), System.IFormatProvider provider = null) { throw null; }
        public static bool TryParse(System.ReadOnlySpan<char> s, out System.Byte result) { throw null; }
        public static bool TryParse(System.ReadOnlySpan<char> s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out System.Byte result) { throw null; }
        public static bool TryParse(string s, out System.Byte result) { throw null; }
        public static bool TryParse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out System.Byte result) { throw null; }
    }
    public partial class CannotUnloadAppDomainException : System.SystemException
    {
        public CannotUnloadAppDomainException() { }
        protected CannotUnloadAppDomainException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public CannotUnloadAppDomainException(string message) { }
        public CannotUnloadAppDomainException(string message, System.Exception innerException) { }
    }
    public readonly partial struct Char : System.IComparable, System.IComparable<char>, System.IConvertible, System.IEquatable<char>
    {
        private readonly char _dummyPrimitive;
        public const char MaxValue = '\uFFFF';
        public const char MinValue = '\0';
        public int CompareTo(System.Char value) { throw null; }
        public int CompareTo(object value) { throw null; }
        public static string ConvertFromUtf32(int utf32) { throw null; }
        public static int ConvertToUtf32(System.Char highSurrogate, System.Char lowSurrogate) { throw null; }
        public static int ConvertToUtf32(string s, int index) { throw null; }
        public bool Equals(System.Char obj) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static double GetNumericValue(System.Char c) { throw null; }
        public static double GetNumericValue(string s, int index) { throw null; }
        public System.TypeCode GetTypeCode() { throw null; }
        public static System.Globalization.UnicodeCategory GetUnicodeCategory(System.Char c) { throw null; }
        public static System.Globalization.UnicodeCategory GetUnicodeCategory(string s, int index) { throw null; }
        public static bool IsControl(System.Char c) { throw null; }
        public static bool IsControl(string s, int index) { throw null; }
        public static bool IsDigit(System.Char c) { throw null; }
        public static bool IsDigit(string s, int index) { throw null; }
        public static bool IsHighSurrogate(System.Char c) { throw null; }
        public static bool IsHighSurrogate(string s, int index) { throw null; }
        public static bool IsLetter(System.Char c) { throw null; }
        public static bool IsLetter(string s, int index) { throw null; }
        public static bool IsLetterOrDigit(System.Char c) { throw null; }
        public static bool IsLetterOrDigit(string s, int index) { throw null; }
        public static bool IsLower(System.Char c) { throw null; }
        public static bool IsLower(string s, int index) { throw null; }
        public static bool IsLowSurrogate(System.Char c) { throw null; }
        public static bool IsLowSurrogate(string s, int index) { throw null; }
        public static bool IsNumber(System.Char c) { throw null; }
        public static bool IsNumber(string s, int index) { throw null; }
        public static bool IsPunctuation(System.Char c) { throw null; }
        public static bool IsPunctuation(string s, int index) { throw null; }
        public static bool IsSeparator(System.Char c) { throw null; }
        public static bool IsSeparator(string s, int index) { throw null; }
        public static bool IsSurrogate(System.Char c) { throw null; }
        public static bool IsSurrogate(string s, int index) { throw null; }
        public static bool IsSurrogatePair(System.Char highSurrogate, System.Char lowSurrogate) { throw null; }
        public static bool IsSurrogatePair(string s, int index) { throw null; }
        public static bool IsSymbol(System.Char c) { throw null; }
        public static bool IsSymbol(string s, int index) { throw null; }
        public static bool IsUpper(System.Char c) { throw null; }
        public static bool IsUpper(string s, int index) { throw null; }
        public static bool IsWhiteSpace(System.Char c) { throw null; }
        public static bool IsWhiteSpace(string s, int index) { throw null; }
        public static System.Char Parse(string s) { throw null; }
        bool System.IConvertible.ToBoolean(System.IFormatProvider provider) { throw null; }
        byte System.IConvertible.ToByte(System.IFormatProvider provider) { throw null; }
        System.Char System.IConvertible.ToChar(System.IFormatProvider provider) { throw null; }
        System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider) { throw null; }
        decimal System.IConvertible.ToDecimal(System.IFormatProvider provider) { throw null; }
        double System.IConvertible.ToDouble(System.IFormatProvider provider) { throw null; }
        short System.IConvertible.ToInt16(System.IFormatProvider provider) { throw null; }
        int System.IConvertible.ToInt32(System.IFormatProvider provider) { throw null; }
        long System.IConvertible.ToInt64(System.IFormatProvider provider) { throw null; }
        sbyte System.IConvertible.ToSByte(System.IFormatProvider provider) { throw null; }
        float System.IConvertible.ToSingle(System.IFormatProvider provider) { throw null; }
        object System.IConvertible.ToType(System.Type type, System.IFormatProvider provider) { throw null; }
        ushort System.IConvertible.ToUInt16(System.IFormatProvider provider) { throw null; }
        uint System.IConvertible.ToUInt32(System.IFormatProvider provider) { throw null; }
        ulong System.IConvertible.ToUInt64(System.IFormatProvider provider) { throw null; }
        public static System.Char ToLower(System.Char c) { throw null; }
        public static System.Char ToLower(System.Char c, System.Globalization.CultureInfo culture) { throw null; }
        public static System.Char ToLowerInvariant(System.Char c) { throw null; }
        public override string ToString() { throw null; }
        public static string ToString(System.Char c) { throw null; }
        public string ToString(System.IFormatProvider provider) { throw null; }
        public static System.Char ToUpper(System.Char c) { throw null; }
        public static System.Char ToUpper(System.Char c, System.Globalization.CultureInfo culture) { throw null; }
        public static System.Char ToUpperInvariant(System.Char c) { throw null; }
        public static bool TryParse(string s, out System.Char result) { throw null; }
    }
    public sealed partial class CharEnumerator : System.Collections.Generic.IEnumerator<char>, System.Collections.IEnumerator, System.ICloneable, System.IDisposable
    {
        internal CharEnumerator() { }
        public char Current { get { throw null; } }
        object System.Collections.IEnumerator.Current { get { throw null; } }
        public object Clone() { throw null; }
        public void Dispose() { }
        public bool MoveNext() { throw null; }
        public void Reset() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All, Inherited=true, AllowMultiple=false)]
    public sealed partial class CLSCompliantAttribute : System.Attribute
    {
        public CLSCompliantAttribute(bool isCompliant) { }
        public bool IsCompliant { get { throw null; } }
    }
    public delegate int Comparison<in T>(T x, T y);
    public static partial class Console
    {
        public static System.ConsoleColor BackgroundColor { get { throw null; } set { } }
        public static int BufferHeight { get { throw null; } set { } }
        public static int BufferWidth { get { throw null; } set { } }
        public static bool CapsLock { get { throw null; } }
        public static int CursorLeft { get { throw null; } set { } }
        public static int CursorSize { get { throw null; } set { } }
        public static int CursorTop { get { throw null; } set { } }
        public static bool CursorVisible { get { throw null; } set { } }
        public static System.IO.TextWriter Error { get { throw null; } }
        public static System.ConsoleColor ForegroundColor { get { throw null; } set { } }
        public static System.IO.TextReader In { get { throw null; } }
        public static System.Text.Encoding InputEncoding { get { throw null; } set { } }
        public static bool IsErrorRedirected { get { throw null; } }
        public static bool IsInputRedirected { get { throw null; } }
        public static bool IsOutputRedirected { get { throw null; } }
        public static bool KeyAvailable { get { throw null; } }
        public static int LargestWindowHeight { get { throw null; } }
        public static int LargestWindowWidth { get { throw null; } }
        public static bool NumberLock { get { throw null; } }
        public static System.IO.TextWriter Out { get { throw null; } }
        public static System.Text.Encoding OutputEncoding { get { throw null; } set { } }
        public static string Title { get { throw null; } set { } }
        public static bool TreatControlCAsInput { get { throw null; } set { } }
        public static int WindowHeight { get { throw null; } set { } }
        public static int WindowLeft { get { throw null; } set { } }
        public static int WindowTop { get { throw null; } set { } }
        public static int WindowWidth { get { throw null; } set { } }
        public static event System.ConsoleCancelEventHandler CancelKeyPress { add { } remove { } }
        public static void Beep() { }
        public static void Beep(int frequency, int duration) { }
        public static void Clear() { }
        public static void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop) { }
        public static void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop, char sourceChar, System.ConsoleColor sourceForeColor, System.ConsoleColor sourceBackColor) { }
        public static System.IO.Stream OpenStandardError() { throw null; }
        public static System.IO.Stream OpenStandardError(int bufferSize) { throw null; }
        public static System.IO.Stream OpenStandardInput() { throw null; }
        public static System.IO.Stream OpenStandardInput(int bufferSize) { throw null; }
        public static System.IO.Stream OpenStandardOutput() { throw null; }
        public static System.IO.Stream OpenStandardOutput(int bufferSize) { throw null; }
        public static int Read() { throw null; }
        public static System.ConsoleKeyInfo ReadKey() { throw null; }
        public static System.ConsoleKeyInfo ReadKey(bool intercept) { throw null; }
        public static string ReadLine() { throw null; }
        public static void ResetColor() { }
        public static void SetBufferSize(int width, int height) { }
        public static void SetCursorPosition(int left, int top) { }
        public static void SetError(System.IO.TextWriter newError) { }
        public static void SetIn(System.IO.TextReader newIn) { }
        public static void SetOut(System.IO.TextWriter newOut) { }
        public static void SetWindowPosition(int left, int top) { }
        public static void SetWindowSize(int width, int height) { }
        public static void Write(bool value) { }
        public static void Write(char value) { }
        public static void Write(char[] buffer) { }
        public static void Write(char[] buffer, int index, int count) { }
        public static void Write(decimal value) { }
        public static void Write(double value) { }
        public static void Write(int value) { }
        public static void Write(long value) { }
        public static void Write(object value) { }
        public static void Write(float value) { }
        public static void Write(string value) { }
        public static void Write(string format, object arg0) { }
        public static void Write(string format, object arg0, object arg1) { }
        public static void Write(string format, object arg0, object arg1, object arg2) { }
        public static void Write(string format, params object[] arg) { }
        [System.CLSCompliantAttribute(false)]
        public static void Write(uint value) { }
        [System.CLSCompliantAttribute(false)]
        public static void Write(ulong value) { }
        public static void WriteLine() { }
        public static void WriteLine(bool value) { }
        public static void WriteLine(char value) { }
        public static void WriteLine(char[] buffer) { }
        public static void WriteLine(char[] buffer, int index, int count) { }
        public static void WriteLine(decimal value) { }
        public static void WriteLine(double value) { }
        public static void WriteLine(int value) { }
        public static void WriteLine(long value) { }
        public static void WriteLine(object value) { }
        public static void WriteLine(float value) { }
        public static void WriteLine(string value) { }
        public static void WriteLine(string format, object arg0) { }
        public static void WriteLine(string format, object arg0, object arg1) { }
        public static void WriteLine(string format, object arg0, object arg1, object arg2) { }
        public static void WriteLine(string format, params object[] arg) { }
        [System.CLSCompliantAttribute(false)]
        public static void WriteLine(uint value) { }
        [System.CLSCompliantAttribute(false)]
        public static void WriteLine(ulong value) { }
    }
    public sealed partial class ConsoleCancelEventArgs : System.EventArgs
    {
        internal ConsoleCancelEventArgs() { }
        public bool Cancel { get { throw null; } set { } }
        public System.ConsoleSpecialKey SpecialKey { get { throw null; } }
    }
    public delegate void ConsoleCancelEventHandler(object sender, System.ConsoleCancelEventArgs e);
    public enum ConsoleColor
    {
        Black = 0,
        Blue = 9,
        Cyan = 11,
        DarkBlue = 1,
        DarkCyan = 3,
        DarkGray = 8,
        DarkGreen = 2,
        DarkMagenta = 5,
        DarkRed = 4,
        DarkYellow = 6,
        Gray = 7,
        Green = 10,
        Magenta = 13,
        Red = 12,
        White = 15,
        Yellow = 14,
    }
    public enum ConsoleKey
    {
        A = 65,
        Add = 107,
        Applications = 93,
        Attention = 246,
        B = 66,
        Backspace = 8,
        BrowserBack = 166,
        BrowserFavorites = 171,
        BrowserForward = 167,
        BrowserHome = 172,
        BrowserRefresh = 168,
        BrowserSearch = 170,
        BrowserStop = 169,
        C = 67,
        Clear = 12,
        CrSel = 247,
        D = 68,
        D0 = 48,
        D1 = 49,
        D2 = 50,
        D3 = 51,
        D4 = 52,
        D5 = 53,
        D6 = 54,
        D7 = 55,
        D8 = 56,
        D9 = 57,
        Decimal = 110,
        Delete = 46,
        Divide = 111,
        DownArrow = 40,
        E = 69,
        End = 35,
        Enter = 13,
        EraseEndOfFile = 249,
        Escape = 27,
        Execute = 43,
        ExSel = 248,
        F = 70,
        F1 = 112,
        F10 = 121,
        F11 = 122,
        F12 = 123,
        F13 = 124,
        F14 = 125,
        F15 = 126,
        F16 = 127,
        F17 = 128,
        F18 = 129,
        F19 = 130,
        F2 = 113,
        F20 = 131,
        F21 = 132,
        F22 = 133,
        F23 = 134,
        F24 = 135,
        F3 = 114,
        F4 = 115,
        F5 = 116,
        F6 = 117,
        F7 = 118,
        F8 = 119,
        F9 = 120,
        G = 71,
        H = 72,
        Help = 47,
        Home = 36,
        I = 73,
        Insert = 45,
        J = 74,
        K = 75,
        L = 76,
        LaunchApp1 = 182,
        LaunchApp2 = 183,
        LaunchMail = 180,
        LaunchMediaSelect = 181,
        LeftArrow = 37,
        LeftWindows = 91,
        M = 77,
        MediaNext = 176,
        MediaPlay = 179,
        MediaPrevious = 177,
        MediaStop = 178,
        Multiply = 106,
        N = 78,
        NoName = 252,
        NumPad0 = 96,
        NumPad1 = 97,
        NumPad2 = 98,
        NumPad3 = 99,
        NumPad4 = 100,
        NumPad5 = 101,
        NumPad6 = 102,
        NumPad7 = 103,
        NumPad8 = 104,
        NumPad9 = 105,
        O = 79,
        Oem1 = 186,
        Oem102 = 226,
        Oem2 = 191,
        Oem3 = 192,
        Oem4 = 219,
        Oem5 = 220,
        Oem6 = 221,
        Oem7 = 222,
        Oem8 = 223,
        OemClear = 254,
        OemComma = 188,
        OemMinus = 189,
        OemPeriod = 190,
        OemPlus = 187,
        P = 80,
        Pa1 = 253,
        Packet = 231,
        PageDown = 34,
        PageUp = 33,
        Pause = 19,
        Play = 250,
        Print = 42,
        PrintScreen = 44,
        Process = 229,
        Q = 81,
        R = 82,
        RightArrow = 39,
        RightWindows = 92,
        S = 83,
        Select = 41,
        Separator = 108,
        Sleep = 95,
        Spacebar = 32,
        Subtract = 109,
        T = 84,
        Tab = 9,
        U = 85,
        UpArrow = 38,
        V = 86,
        VolumeDown = 174,
        VolumeMute = 173,
        VolumeUp = 175,
        W = 87,
        X = 88,
        Y = 89,
        Z = 90,
        Zoom = 251,
    }
    public readonly partial struct ConsoleKeyInfo
    {
        private readonly int _dummyPrimitive;
        public ConsoleKeyInfo(char keyChar, System.ConsoleKey key, bool shift, bool alt, bool control) { throw null; }
        public System.ConsoleKey Key { get { throw null; } }
        public char KeyChar { get { throw null; } }
        public System.ConsoleModifiers Modifiers { get { throw null; } }
        public bool Equals(System.ConsoleKeyInfo obj) { throw null; }
        public override bool Equals(object value) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.ConsoleKeyInfo a, System.ConsoleKeyInfo b) { throw null; }
        public static bool operator !=(System.ConsoleKeyInfo a, System.ConsoleKeyInfo b) { throw null; }
    }
    [System.FlagsAttribute]
    public enum ConsoleModifiers
    {
        Alt = 1,
        Control = 4,
        Shift = 2,
    }
    public enum ConsoleSpecialKey
    {
        ControlBreak = 1,
        ControlC = 0,
    }
    public abstract partial class ContextBoundObject : System.MarshalByRefObject
    {
        protected ContextBoundObject() { }
    }
    public partial class ContextMarshalException : System.SystemException
    {
        public ContextMarshalException() { }
        protected ContextMarshalException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public ContextMarshalException(string message) { }
        public ContextMarshalException(string message, System.Exception inner) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Field, Inherited=false)]
    public partial class ContextStaticAttribute : System.Attribute
    {
        public ContextStaticAttribute() { }
    }
    public static partial class Convert
    {
        public static readonly object DBNull;
        public static object ChangeType(object value, System.Type conversionType) { throw null; }
        public static object ChangeType(object value, System.Type conversionType, System.IFormatProvider provider) { throw null; }
        public static object ChangeType(object value, System.TypeCode typeCode) { throw null; }
        public static object ChangeType(object value, System.TypeCode typeCode, System.IFormatProvider provider) { throw null; }
        public static byte[] FromBase64CharArray(char[] inArray, int offset, int length) { throw null; }
        public static byte[] FromBase64String(string s) { throw null; }
        public static System.TypeCode GetTypeCode(object value) { throw null; }
        public static bool IsDBNull(object value) { throw null; }
        public static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut) { throw null; }
        public static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut, System.Base64FormattingOptions options) { throw null; }
        public static string ToBase64String(byte[] inArray) { throw null; }
        public static string ToBase64String(byte[] inArray, System.Base64FormattingOptions options) { throw null; }
        public static string ToBase64String(byte[] inArray, int offset, int length) { throw null; }
        public static string ToBase64String(byte[] inArray, int offset, int length, System.Base64FormattingOptions options) { throw null; }
        public static string ToBase64String(System.ReadOnlySpan<byte> bytes, System.Base64FormattingOptions options = System.Base64FormattingOptions.None) { throw null; }
        public static bool ToBoolean(bool value) { throw null; }
        public static bool ToBoolean(byte value) { throw null; }
        public static bool ToBoolean(char value) { throw null; }
        public static bool ToBoolean(System.DateTime value) { throw null; }
        public static bool ToBoolean(decimal value) { throw null; }
        public static bool ToBoolean(double value) { throw null; }
        public static bool ToBoolean(short value) { throw null; }
        public static bool ToBoolean(int value) { throw null; }
        public static bool ToBoolean(long value) { throw null; }
        public static bool ToBoolean(object value) { throw null; }
        public static bool ToBoolean(object value, System.IFormatProvider provider) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static bool ToBoolean(sbyte value) { throw null; }
        public static bool ToBoolean(float value) { throw null; }
        public static bool ToBoolean(string value) { throw null; }
        public static bool ToBoolean(string value, System.IFormatProvider provider) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static bool ToBoolean(ushort value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static bool ToBoolean(uint value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static bool ToBoolean(ulong value) { throw null; }
        public static byte ToByte(bool value) { throw null; }
        public static byte ToByte(byte value) { throw null; }
        public static byte ToByte(char value) { throw null; }
        public static byte ToByte(System.DateTime value) { throw null; }
        public static byte ToByte(decimal value) { throw null; }
        public static byte ToByte(double value) { throw null; }
        public static byte ToByte(short value) { throw null; }
        public static byte ToByte(int value) { throw null; }
        public static byte ToByte(long value) { throw null; }
        public static byte ToByte(object value) { throw null; }
        public static byte ToByte(object value, System.IFormatProvider provider) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static byte ToByte(sbyte value) { throw null; }
        public static byte ToByte(float value) { throw null; }
        public static byte ToByte(string value) { throw null; }
        public static byte ToByte(string value, System.IFormatProvider provider) { throw null; }
        public static byte ToByte(string value, int fromBase) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static byte ToByte(ushort value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static byte ToByte(uint value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static byte ToByte(ulong value) { throw null; }
        public static char ToChar(bool value) { throw null; }
        public static char ToChar(byte value) { throw null; }
        public static char ToChar(char value) { throw null; }
        public static char ToChar(System.DateTime value) { throw null; }
        public static char ToChar(decimal value) { throw null; }
        public static char ToChar(double value) { throw null; }
        public static char ToChar(short value) { throw null; }
        public static char ToChar(int value) { throw null; }
        public static char ToChar(long value) { throw null; }
        public static char ToChar(object value) { throw null; }
        public static char ToChar(object value, System.IFormatProvider provider) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static char ToChar(sbyte value) { throw null; }
        public static char ToChar(float value) { throw null; }
        public static char ToChar(string value) { throw null; }
        public static char ToChar(string value, System.IFormatProvider provider) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static char ToChar(ushort value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static char ToChar(uint value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static char ToChar(ulong value) { throw null; }
        public static System.DateTime ToDateTime(bool value) { throw null; }
        public static System.DateTime ToDateTime(byte value) { throw null; }
        public static System.DateTime ToDateTime(char value) { throw null; }
        public static System.DateTime ToDateTime(System.DateTime value) { throw null; }
        public static System.DateTime ToDateTime(decimal value) { throw null; }
        public static System.DateTime ToDateTime(double value) { throw null; }
        public static System.DateTime ToDateTime(short value) { throw null; }
        public static System.DateTime ToDateTime(int value) { throw null; }
        public static System.DateTime ToDateTime(long value) { throw null; }
        public static System.DateTime ToDateTime(object value) { throw null; }
        public static System.DateTime ToDateTime(object value, System.IFormatProvider provider) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.DateTime ToDateTime(sbyte value) { throw null; }
        public static System.DateTime ToDateTime(float value) { throw null; }
        public static System.DateTime ToDateTime(string value) { throw null; }
        public static System.DateTime ToDateTime(string value, System.IFormatProvider provider) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.DateTime ToDateTime(ushort value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.DateTime ToDateTime(uint value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.DateTime ToDateTime(ulong value) { throw null; }
        public static decimal ToDecimal(bool value) { throw null; }
        public static decimal ToDecimal(byte value) { throw null; }
        public static decimal ToDecimal(char value) { throw null; }
        public static decimal ToDecimal(System.DateTime value) { throw null; }
        public static decimal ToDecimal(decimal value) { throw null; }
        public static decimal ToDecimal(double value) { throw null; }
        public static decimal ToDecimal(short value) { throw null; }
        public static decimal ToDecimal(int value) { throw null; }
        public static decimal ToDecimal(long value) { throw null; }
        public static decimal ToDecimal(object value) { throw null; }
        public static decimal ToDecimal(object value, System.IFormatProvider provider) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static decimal ToDecimal(sbyte value) { throw null; }
        public static decimal ToDecimal(float value) { throw null; }
        public static decimal ToDecimal(string value) { throw null; }
        public static decimal ToDecimal(string value, System.IFormatProvider provider) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static decimal ToDecimal(ushort value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static decimal ToDecimal(uint value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static decimal ToDecimal(ulong value) { throw null; }
        public static double ToDouble(bool value) { throw null; }
        public static double ToDouble(byte value) { throw null; }
        public static double ToDouble(char value) { throw null; }
        public static double ToDouble(System.DateTime value) { throw null; }
        public static double ToDouble(decimal value) { throw null; }
        public static double ToDouble(double value) { throw null; }
        public static double ToDouble(short value) { throw null; }
        public static double ToDouble(int value) { throw null; }
        public static double ToDouble(long value) { throw null; }
        public static double ToDouble(object value) { throw null; }
        public static double ToDouble(object value, System.IFormatProvider provider) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static double ToDouble(sbyte value) { throw null; }
        public static double ToDouble(float value) { throw null; }
        public static double ToDouble(string value) { throw null; }
        public static double ToDouble(string value, System.IFormatProvider provider) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static double ToDouble(ushort value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static double ToDouble(uint value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static double ToDouble(ulong value) { throw null; }
        public static short ToInt16(bool value) { throw null; }
        public static short ToInt16(byte value) { throw null; }
        public static short ToInt16(char value) { throw null; }
        public static short ToInt16(System.DateTime value) { throw null; }
        public static short ToInt16(decimal value) { throw null; }
        public static short ToInt16(double value) { throw null; }
        public static short ToInt16(short value) { throw null; }
        public static short ToInt16(int value) { throw null; }
        public static short ToInt16(long value) { throw null; }
        public static short ToInt16(object value) { throw null; }
        public static short ToInt16(object value, System.IFormatProvider provider) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static short ToInt16(sbyte value) { throw null; }
        public static short ToInt16(float value) { throw null; }
        public static short ToInt16(string value) { throw null; }
        public static short ToInt16(string value, System.IFormatProvider provider) { throw null; }
        public static short ToInt16(string value, int fromBase) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static short ToInt16(ushort value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static short ToInt16(uint value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static short ToInt16(ulong value) { throw null; }
        public static int ToInt32(bool value) { throw null; }
        public static int ToInt32(byte value) { throw null; }
        public static int ToInt32(char value) { throw null; }
        public static int ToInt32(System.DateTime value) { throw null; }
        public static int ToInt32(decimal value) { throw null; }
        public static int ToInt32(double value) { throw null; }
        public static int ToInt32(short value) { throw null; }
        public static int ToInt32(int value) { throw null; }
        public static int ToInt32(long value) { throw null; }
        public static int ToInt32(object value) { throw null; }
        public static int ToInt32(object value, System.IFormatProvider provider) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static int ToInt32(sbyte value) { throw null; }
        public static int ToInt32(float value) { throw null; }
        public static int ToInt32(string value) { throw null; }
        public static int ToInt32(string value, System.IFormatProvider provider) { throw null; }
        public static int ToInt32(string value, int fromBase) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static int ToInt32(ushort value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static int ToInt32(uint value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static int ToInt32(ulong value) { throw null; }
        public static long ToInt64(bool value) { throw null; }
        public static long ToInt64(byte value) { throw null; }
        public static long ToInt64(char value) { throw null; }
        public static long ToInt64(System.DateTime value) { throw null; }
        public static long ToInt64(decimal value) { throw null; }
        public static long ToInt64(double value) { throw null; }
        public static long ToInt64(short value) { throw null; }
        public static long ToInt64(int value) { throw null; }
        public static long ToInt64(long value) { throw null; }
        public static long ToInt64(object value) { throw null; }
        public static long ToInt64(object value, System.IFormatProvider provider) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static long ToInt64(sbyte value) { throw null; }
        public static long ToInt64(float value) { throw null; }
        public static long ToInt64(string value) { throw null; }
        public static long ToInt64(string value, System.IFormatProvider provider) { throw null; }
        public static long ToInt64(string value, int fromBase) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static long ToInt64(ushort value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static long ToInt64(uint value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static long ToInt64(ulong value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(bool value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(byte value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(char value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(System.DateTime value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(decimal value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(double value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(short value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(int value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(long value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(object value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(object value, System.IFormatProvider provider) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(sbyte value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(float value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(string value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(string value, System.IFormatProvider provider) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(string value, int fromBase) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(ushort value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(uint value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(ulong value) { throw null; }
        public static float ToSingle(bool value) { throw null; }
        public static float ToSingle(byte value) { throw null; }
        public static float ToSingle(char value) { throw null; }
        public static float ToSingle(System.DateTime value) { throw null; }
        public static float ToSingle(decimal value) { throw null; }
        public static float ToSingle(double value) { throw null; }
        public static float ToSingle(short value) { throw null; }
        public static float ToSingle(int value) { throw null; }
        public static float ToSingle(long value) { throw null; }
        public static float ToSingle(object value) { throw null; }
        public static float ToSingle(object value, System.IFormatProvider provider) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static float ToSingle(sbyte value) { throw null; }
        public static float ToSingle(float value) { throw null; }
        public static float ToSingle(string value) { throw null; }
        public static float ToSingle(string value, System.IFormatProvider provider) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static float ToSingle(ushort value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static float ToSingle(uint value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static float ToSingle(ulong value) { throw null; }
        public static string ToString(bool value) { throw null; }
        public static string ToString(bool value, System.IFormatProvider provider) { throw null; }
        public static string ToString(byte value) { throw null; }
        public static string ToString(byte value, System.IFormatProvider provider) { throw null; }
        public static string ToString(byte value, int toBase) { throw null; }
        public static string ToString(char value) { throw null; }
        public static string ToString(char value, System.IFormatProvider provider) { throw null; }
        public static string ToString(System.DateTime value) { throw null; }
        public static string ToString(System.DateTime value, System.IFormatProvider provider) { throw null; }
        public static string ToString(decimal value) { throw null; }
        public static string ToString(decimal value, System.IFormatProvider provider) { throw null; }
        public static string ToString(double value) { throw null; }
        public static string ToString(double value, System.IFormatProvider provider) { throw null; }
        public static string ToString(short value) { throw null; }
        public static string ToString(short value, System.IFormatProvider provider) { throw null; }
        public static string ToString(short value, int toBase) { throw null; }
        public static string ToString(int value) { throw null; }
        public static string ToString(int value, System.IFormatProvider provider) { throw null; }
        public static string ToString(int value, int toBase) { throw null; }
        public static string ToString(long value) { throw null; }
        public static string ToString(long value, System.IFormatProvider provider) { throw null; }
        public static string ToString(long value, int toBase) { throw null; }
        public static string ToString(object value) { throw null; }
        public static string ToString(object value, System.IFormatProvider provider) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static string ToString(sbyte value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static string ToString(sbyte value, System.IFormatProvider provider) { throw null; }
        public static string ToString(float value) { throw null; }
        public static string ToString(float value, System.IFormatProvider provider) { throw null; }
        public static string ToString(string value) { throw null; }
        public static string ToString(string value, System.IFormatProvider provider) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static string ToString(ushort value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static string ToString(ushort value, System.IFormatProvider provider) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static string ToString(uint value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static string ToString(uint value, System.IFormatProvider provider) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static string ToString(ulong value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static string ToString(ulong value, System.IFormatProvider provider) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(bool value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(byte value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(char value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(System.DateTime value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(decimal value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(double value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(short value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(int value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(long value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(object value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(object value, System.IFormatProvider provider) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(sbyte value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(float value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(string value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(string value, System.IFormatProvider provider) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(string value, int fromBase) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(ushort value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(uint value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(ulong value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(bool value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(byte value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(char value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(System.DateTime value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(decimal value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(double value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(short value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(int value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(long value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(object value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(object value, System.IFormatProvider provider) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(sbyte value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(float value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(string value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(string value, System.IFormatProvider provider) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(string value, int fromBase) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(ushort value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(uint value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(ulong value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(bool value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(byte value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(char value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(System.DateTime value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(decimal value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(double value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(short value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(int value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(long value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(object value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(object value, System.IFormatProvider provider) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(sbyte value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(float value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(string value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(string value, System.IFormatProvider provider) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(string value, int fromBase) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(ushort value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(uint value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(ulong value) { throw null; }
        public static bool TryFromBase64Chars(System.ReadOnlySpan<char> chars, System.Span<byte> bytes, out int bytesWritten) { throw null; }
        public static bool TryFromBase64String(string s, System.Span<byte> bytes, out int bytesWritten) { throw null; }
        public static bool TryToBase64Chars(System.ReadOnlySpan<byte> bytes, System.Span<char> chars, out int charsWritten, System.Base64FormattingOptions options = System.Base64FormattingOptions.None) { throw null; }
    }
    public delegate TOutput Converter<in TInput, out TOutput>(TInput input);
    public sealed partial class DataMisalignedException : System.SystemException
    {
        public DataMisalignedException() { }
        public DataMisalignedException(string message) { }
        public DataMisalignedException(string message, System.Exception innerException) { }
    }
    public readonly partial struct DateTime : System.IComparable, System.IComparable<System.DateTime>, System.IConvertible, System.IEquatable<System.DateTime>, System.IFormattable, System.Runtime.Serialization.ISerializable
    {
        private readonly int _dummyPrimitive;
        public static readonly System.DateTime MaxValue;
        public static readonly System.DateTime MinValue;
        public static readonly System.DateTime UnixEpoch;
        public DateTime(int year, int month, int day) { throw null; }
        public DateTime(int year, int month, int day, System.Globalization.Calendar calendar) { throw null; }
        public DateTime(int year, int month, int day, int hour, int minute, int second) { throw null; }
        public DateTime(int year, int month, int day, int hour, int minute, int second, System.DateTimeKind kind) { throw null; }
        public DateTime(int year, int month, int day, int hour, int minute, int second, System.Globalization.Calendar calendar) { throw null; }
        public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond) { throw null; }
        public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, System.DateTimeKind kind) { throw null; }
        public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, System.Globalization.Calendar calendar) { throw null; }
        public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, System.Globalization.Calendar calendar, System.DateTimeKind kind) { throw null; }
        public DateTime(long ticks) { throw null; }
        public DateTime(long ticks, System.DateTimeKind kind) { throw null; }
        public System.DateTime Date { get { throw null; } }
        public int Day { get { throw null; } }
        public System.DayOfWeek DayOfWeek { get { throw null; } }
        public int DayOfYear { get { throw null; } }
        public int Hour { get { throw null; } }
        public System.DateTimeKind Kind { get { throw null; } }
        public int Millisecond { get { throw null; } }
        public int Minute { get { throw null; } }
        public int Month { get { throw null; } }
        public static System.DateTime Now { get { throw null; } }
        public int Second { get { throw null; } }
        public long Ticks { get { throw null; } }
        public System.TimeSpan TimeOfDay { get { throw null; } }
        public static System.DateTime Today { get { throw null; } }
        public static System.DateTime UtcNow { get { throw null; } }
        public int Year { get { throw null; } }
        public System.DateTime Add(System.TimeSpan value) { throw null; }
        public System.DateTime AddDays(double value) { throw null; }
        public System.DateTime AddHours(double value) { throw null; }
        public System.DateTime AddMilliseconds(double value) { throw null; }
        public System.DateTime AddMinutes(double value) { throw null; }
        public System.DateTime AddMonths(int months) { throw null; }
        public System.DateTime AddSeconds(double value) { throw null; }
        public System.DateTime AddTicks(long value) { throw null; }
        public System.DateTime AddYears(int value) { throw null; }
        public static int Compare(System.DateTime t1, System.DateTime t2) { throw null; }
        public int CompareTo(System.DateTime value) { throw null; }
        public int CompareTo(object value) { throw null; }
        public static int DaysInMonth(int year, int month) { throw null; }
        public bool Equals(System.DateTime value) { throw null; }
        public static bool Equals(System.DateTime t1, System.DateTime t2) { throw null; }
        public override bool Equals(object value) { throw null; }
        public static System.DateTime FromBinary(long dateData) { throw null; }
        public static System.DateTime FromFileTime(long fileTime) { throw null; }
        public static System.DateTime FromFileTimeUtc(long fileTime) { throw null; }
        public static System.DateTime FromOADate(double d) { throw null; }
        public string[] GetDateTimeFormats() { throw null; }
        public string[] GetDateTimeFormats(char format) { throw null; }
        public string[] GetDateTimeFormats(char format, System.IFormatProvider provider) { throw null; }
        public string[] GetDateTimeFormats(System.IFormatProvider provider) { throw null; }
        public override int GetHashCode() { throw null; }
        public System.TypeCode GetTypeCode() { throw null; }
        public bool IsDaylightSavingTime() { throw null; }
        public static bool IsLeapYear(int year) { throw null; }
        public static System.DateTime operator +(System.DateTime d, System.TimeSpan t) { throw null; }
        public static bool operator ==(System.DateTime d1, System.DateTime d2) { throw null; }
        public static bool operator >(System.DateTime t1, System.DateTime t2) { throw null; }
        public static bool operator >=(System.DateTime t1, System.DateTime t2) { throw null; }
        public static bool operator !=(System.DateTime d1, System.DateTime d2) { throw null; }
        public static bool operator <(System.DateTime t1, System.DateTime t2) { throw null; }
        public static bool operator <=(System.DateTime t1, System.DateTime t2) { throw null; }
        public static System.TimeSpan operator -(System.DateTime d1, System.DateTime d2) { throw null; }
        public static System.DateTime operator -(System.DateTime d, System.TimeSpan t) { throw null; }
        public static System.DateTime Parse(System.ReadOnlySpan<char> s, System.IFormatProvider provider = null, System.Globalization.DateTimeStyles styles = System.Globalization.DateTimeStyles.None) { throw null; }
        public static System.DateTime Parse(string s) { throw null; }
        public static System.DateTime Parse(string s, System.IFormatProvider provider) { throw null; }
        public static System.DateTime Parse(string s, System.IFormatProvider provider, System.Globalization.DateTimeStyles styles) { throw null; }
        public static System.DateTime ParseExact(System.ReadOnlySpan<char> s, System.ReadOnlySpan<char> format, System.IFormatProvider provider, System.Globalization.DateTimeStyles style = System.Globalization.DateTimeStyles.None) { throw null; }
        public static System.DateTime ParseExact(System.ReadOnlySpan<char> s, string[] formats, System.IFormatProvider provider, System.Globalization.DateTimeStyles style = System.Globalization.DateTimeStyles.None) { throw null; }
        public static System.DateTime ParseExact(string s, string format, System.IFormatProvider provider) { throw null; }
        public static System.DateTime ParseExact(string s, string format, System.IFormatProvider provider, System.Globalization.DateTimeStyles style) { throw null; }
        public static System.DateTime ParseExact(string s, string[] formats, System.IFormatProvider provider, System.Globalization.DateTimeStyles style) { throw null; }
        public static System.DateTime SpecifyKind(System.DateTime value, System.DateTimeKind kind) { throw null; }
        public System.TimeSpan Subtract(System.DateTime value) { throw null; }
        public System.DateTime Subtract(System.TimeSpan value) { throw null; }
        bool System.IConvertible.ToBoolean(System.IFormatProvider provider) { throw null; }
        byte System.IConvertible.ToByte(System.IFormatProvider provider) { throw null; }
        char System.IConvertible.ToChar(System.IFormatProvider provider) { throw null; }
        System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider) { throw null; }
        decimal System.IConvertible.ToDecimal(System.IFormatProvider provider) { throw null; }
        double System.IConvertible.ToDouble(System.IFormatProvider provider) { throw null; }
        short System.IConvertible.ToInt16(System.IFormatProvider provider) { throw null; }
        int System.IConvertible.ToInt32(System.IFormatProvider provider) { throw null; }
        long System.IConvertible.ToInt64(System.IFormatProvider provider) { throw null; }
        sbyte System.IConvertible.ToSByte(System.IFormatProvider provider) { throw null; }
        float System.IConvertible.ToSingle(System.IFormatProvider provider) { throw null; }
        object System.IConvertible.ToType(System.Type type, System.IFormatProvider provider) { throw null; }
        ushort System.IConvertible.ToUInt16(System.IFormatProvider provider) { throw null; }
        uint System.IConvertible.ToUInt32(System.IFormatProvider provider) { throw null; }
        ulong System.IConvertible.ToUInt64(System.IFormatProvider provider) { throw null; }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public long ToBinary() { throw null; }
        public long ToFileTime() { throw null; }
        public long ToFileTimeUtc() { throw null; }
        public System.DateTime ToLocalTime() { throw null; }
        public string ToLongDateString() { throw null; }
        public string ToLongTimeString() { throw null; }
        public double ToOADate() { throw null; }
        public string ToShortDateString() { throw null; }
        public string ToShortTimeString() { throw null; }
        public override string ToString() { throw null; }
        public string ToString(System.IFormatProvider provider) { throw null; }
        public string ToString(string format) { throw null; }
        public string ToString(string format, System.IFormatProvider provider) { throw null; }
        public System.DateTime ToUniversalTime() { throw null; }
        public bool TryFormat(System.Span<char> destination, out int charsWritten, System.ReadOnlySpan<char> format = default(System.ReadOnlySpan<char>), System.IFormatProvider provider = null) { throw null; }
        public static bool TryParse(System.ReadOnlySpan<char> s, out System.DateTime result) { throw null; }
        public static bool TryParse(System.ReadOnlySpan<char> s, System.IFormatProvider provider, System.Globalization.DateTimeStyles styles, out System.DateTime result) { throw null; }
        public static bool TryParse(string s, out System.DateTime result) { throw null; }
        public static bool TryParse(string s, System.IFormatProvider provider, System.Globalization.DateTimeStyles styles, out System.DateTime result) { throw null; }
        public static bool TryParseExact(System.ReadOnlySpan<char> s, System.ReadOnlySpan<char> format, System.IFormatProvider provider, System.Globalization.DateTimeStyles style, out System.DateTime result) { throw null; }
        public static bool TryParseExact(System.ReadOnlySpan<char> s, string[] formats, System.IFormatProvider provider, System.Globalization.DateTimeStyles style, out System.DateTime result) { throw null; }
        public static bool TryParseExact(string s, string format, System.IFormatProvider provider, System.Globalization.DateTimeStyles style, out System.DateTime result) { throw null; }
        public static bool TryParseExact(string s, string[] formats, System.IFormatProvider provider, System.Globalization.DateTimeStyles style, out System.DateTime result) { throw null; }
    }
    public enum DateTimeKind
    {
        Local = 2,
        Unspecified = 0,
        Utc = 1,
    }
    public readonly partial struct DateTimeOffset : System.IComparable, System.IComparable<System.DateTimeOffset>, System.IEquatable<System.DateTimeOffset>, System.IFormattable, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable
    {
        private readonly int _dummyPrimitive;
        public static readonly System.DateTimeOffset MaxValue;
        public static readonly System.DateTimeOffset MinValue;
        public static readonly System.DateTimeOffset UnixEpoch;
        public DateTimeOffset(System.DateTime dateTime) { throw null; }
        public DateTimeOffset(System.DateTime dateTime, System.TimeSpan offset) { throw null; }
        public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, System.Globalization.Calendar calendar, System.TimeSpan offset) { throw null; }
        public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, System.TimeSpan offset) { throw null; }
        public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, System.TimeSpan offset) { throw null; }
        public DateTimeOffset(long ticks, System.TimeSpan offset) { throw null; }
        public System.DateTime Date { get { throw null; } }
        public System.DateTime DateTime { get { throw null; } }
        public int Day { get { throw null; } }
        public System.DayOfWeek DayOfWeek { get { throw null; } }
        public int DayOfYear { get { throw null; } }
        public int Hour { get { throw null; } }
        public System.DateTime LocalDateTime { get { throw null; } }
        public int Millisecond { get { throw null; } }
        public int Minute { get { throw null; } }
        public int Month { get { throw null; } }
        public static System.DateTimeOffset Now { get { throw null; } }
        public System.TimeSpan Offset { get { throw null; } }
        public int Second { get { throw null; } }
        public long Ticks { get { throw null; } }
        public System.TimeSpan TimeOfDay { get { throw null; } }
        public System.DateTime UtcDateTime { get { throw null; } }
        public static System.DateTimeOffset UtcNow { get { throw null; } }
        public long UtcTicks { get { throw null; } }
        public int Year { get { throw null; } }
        public System.DateTimeOffset Add(System.TimeSpan timeSpan) { throw null; }
        public System.DateTimeOffset AddDays(double days) { throw null; }
        public System.DateTimeOffset AddHours(double hours) { throw null; }
        public System.DateTimeOffset AddMilliseconds(double milliseconds) { throw null; }
        public System.DateTimeOffset AddMinutes(double minutes) { throw null; }
        public System.DateTimeOffset AddMonths(int months) { throw null; }
        public System.DateTimeOffset AddSeconds(double seconds) { throw null; }
        public System.DateTimeOffset AddTicks(long ticks) { throw null; }
        public System.DateTimeOffset AddYears(int years) { throw null; }
        public static int Compare(System.DateTimeOffset first, System.DateTimeOffset second) { throw null; }
        public int CompareTo(System.DateTimeOffset other) { throw null; }
        public bool Equals(System.DateTimeOffset other) { throw null; }
        public static bool Equals(System.DateTimeOffset first, System.DateTimeOffset second) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public bool EqualsExact(System.DateTimeOffset other) { throw null; }
        public static System.DateTimeOffset FromFileTime(long fileTime) { throw null; }
        public static System.DateTimeOffset FromUnixTimeMilliseconds(long milliseconds) { throw null; }
        public static System.DateTimeOffset FromUnixTimeSeconds(long seconds) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.DateTimeOffset operator +(System.DateTimeOffset dateTimeOffset, System.TimeSpan timeSpan) { throw null; }
        public static bool operator ==(System.DateTimeOffset left, System.DateTimeOffset right) { throw null; }
        public static bool operator >(System.DateTimeOffset left, System.DateTimeOffset right) { throw null; }
        public static bool operator >=(System.DateTimeOffset left, System.DateTimeOffset right) { throw null; }
        public static implicit operator System.DateTimeOffset (System.DateTime dateTime) { throw null; }
        public static bool operator !=(System.DateTimeOffset left, System.DateTimeOffset right) { throw null; }
        public static bool operator <(System.DateTimeOffset left, System.DateTimeOffset right) { throw null; }
        public static bool operator <=(System.DateTimeOffset left, System.DateTimeOffset right) { throw null; }
        public static System.TimeSpan operator -(System.DateTimeOffset left, System.DateTimeOffset right) { throw null; }
        public static System.DateTimeOffset operator -(System.DateTimeOffset dateTimeOffset, System.TimeSpan timeSpan) { throw null; }
        public static System.DateTimeOffset Parse(System.ReadOnlySpan<char> input, System.IFormatProvider formatProvider = null, System.Globalization.DateTimeStyles styles = System.Globalization.DateTimeStyles.None) { throw null; }
        public static System.DateTimeOffset Parse(string input) { throw null; }
        public static System.DateTimeOffset Parse(string input, System.IFormatProvider formatProvider) { throw null; }
        public static System.DateTimeOffset Parse(string input, System.IFormatProvider formatProvider, System.Globalization.DateTimeStyles styles) { throw null; }
        public static System.DateTimeOffset ParseExact(System.ReadOnlySpan<char> input, System.ReadOnlySpan<char> format, System.IFormatProvider formatProvider, System.Globalization.DateTimeStyles styles = System.Globalization.DateTimeStyles.None) { throw null; }
        public static System.DateTimeOffset ParseExact(System.ReadOnlySpan<char> input, string[] formats, System.IFormatProvider formatProvider, System.Globalization.DateTimeStyles styles = System.Globalization.DateTimeStyles.None) { throw null; }
        public static System.DateTimeOffset ParseExact(string input, string format, System.IFormatProvider formatProvider) { throw null; }
        public static System.DateTimeOffset ParseExact(string input, string format, System.IFormatProvider formatProvider, System.Globalization.DateTimeStyles styles) { throw null; }
        public static System.DateTimeOffset ParseExact(string input, string[] formats, System.IFormatProvider formatProvider, System.Globalization.DateTimeStyles styles) { throw null; }
        public System.TimeSpan Subtract(System.DateTimeOffset value) { throw null; }
        public System.DateTimeOffset Subtract(System.TimeSpan value) { throw null; }
        int System.IComparable.CompareTo(object obj) { throw null; }
        void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public long ToFileTime() { throw null; }
        public System.DateTimeOffset ToLocalTime() { throw null; }
        public System.DateTimeOffset ToOffset(System.TimeSpan offset) { throw null; }
        public override string ToString() { throw null; }
        public string ToString(System.IFormatProvider formatProvider) { throw null; }
        public string ToString(string format) { throw null; }
        public string ToString(string format, System.IFormatProvider formatProvider) { throw null; }
        public System.DateTimeOffset ToUniversalTime() { throw null; }
        public long ToUnixTimeMilliseconds() { throw null; }
        public long ToUnixTimeSeconds() { throw null; }
        public bool TryFormat(System.Span<char> destination, out int charsWritten, System.ReadOnlySpan<char> format = default(System.ReadOnlySpan<char>), System.IFormatProvider formatProvider = null) { throw null; }
        public static bool TryParse(System.ReadOnlySpan<char> input, out System.DateTimeOffset result) { throw null; }
        public static bool TryParse(System.ReadOnlySpan<char> input, System.IFormatProvider formatProvider, System.Globalization.DateTimeStyles styles, out System.DateTimeOffset result) { throw null; }
        public static bool TryParse(string input, out System.DateTimeOffset result) { throw null; }
        public static bool TryParse(string input, System.IFormatProvider formatProvider, System.Globalization.DateTimeStyles styles, out System.DateTimeOffset result) { throw null; }
        public static bool TryParseExact(System.ReadOnlySpan<char> input, System.ReadOnlySpan<char> format, System.IFormatProvider formatProvider, System.Globalization.DateTimeStyles styles, out System.DateTimeOffset result) { throw null; }
        public static bool TryParseExact(System.ReadOnlySpan<char> input, string[] formats, System.IFormatProvider formatProvider, System.Globalization.DateTimeStyles styles, out System.DateTimeOffset result) { throw null; }
        public static bool TryParseExact(string input, string format, System.IFormatProvider formatProvider, System.Globalization.DateTimeStyles styles, out System.DateTimeOffset result) { throw null; }
        public static bool TryParseExact(string input, string[] formats, System.IFormatProvider formatProvider, System.Globalization.DateTimeStyles styles, out System.DateTimeOffset result) { throw null; }
    }
    public enum DayOfWeek
    {
        Friday = 5,
        Monday = 1,
        Saturday = 6,
        Sunday = 0,
        Thursday = 4,
        Tuesday = 2,
        Wednesday = 3,
    }
    public sealed partial class DBNull : System.IConvertible, System.Runtime.Serialization.ISerializable
    {
        internal DBNull() { }
        public static readonly System.DBNull Value;
        public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public System.TypeCode GetTypeCode() { throw null; }
        bool System.IConvertible.ToBoolean(System.IFormatProvider provider) { throw null; }
        byte System.IConvertible.ToByte(System.IFormatProvider provider) { throw null; }
        char System.IConvertible.ToChar(System.IFormatProvider provider) { throw null; }
        System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider) { throw null; }
        decimal System.IConvertible.ToDecimal(System.IFormatProvider provider) { throw null; }
        double System.IConvertible.ToDouble(System.IFormatProvider provider) { throw null; }
        short System.IConvertible.ToInt16(System.IFormatProvider provider) { throw null; }
        int System.IConvertible.ToInt32(System.IFormatProvider provider) { throw null; }
        long System.IConvertible.ToInt64(System.IFormatProvider provider) { throw null; }
        sbyte System.IConvertible.ToSByte(System.IFormatProvider provider) { throw null; }
        float System.IConvertible.ToSingle(System.IFormatProvider provider) { throw null; }
        object System.IConvertible.ToType(System.Type type, System.IFormatProvider provider) { throw null; }
        ushort System.IConvertible.ToUInt16(System.IFormatProvider provider) { throw null; }
        uint System.IConvertible.ToUInt32(System.IFormatProvider provider) { throw null; }
        ulong System.IConvertible.ToUInt64(System.IFormatProvider provider) { throw null; }
        public override string ToString() { throw null; }
        public string ToString(System.IFormatProvider provider) { throw null; }
    }
    public readonly partial struct Decimal : System.IComparable, System.IComparable<decimal>, System.IConvertible, System.IEquatable<decimal>, System.IFormattable, System.Runtime.Serialization.IDeserializationCallback
    {
        private readonly int _dummyPrimitive;
        [System.Runtime.CompilerServices.DecimalConstantAttribute((byte)0, (byte)0, (uint)4294967295, (uint)4294967295, (uint)4294967295)]
        public static readonly decimal MaxValue;
        [System.Runtime.CompilerServices.DecimalConstantAttribute((byte)0, (byte)128, (uint)0, (uint)0, (uint)1)]
        public static readonly decimal MinusOne;
        [System.Runtime.CompilerServices.DecimalConstantAttribute((byte)0, (byte)128, (uint)4294967295, (uint)4294967295, (uint)4294967295)]
        public static readonly decimal MinValue;
        [System.Runtime.CompilerServices.DecimalConstantAttribute((byte)0, (byte)0, (uint)0, (uint)0, (uint)1)]
        public static readonly decimal One;
        [System.Runtime.CompilerServices.DecimalConstantAttribute((byte)0, (byte)0, (uint)0, (uint)0, (uint)0)]
        public static readonly decimal Zero;
        public Decimal(double value) { throw null; }
        public Decimal(int value) { throw null; }
        public Decimal(int lo, int mid, int hi, bool isNegative, byte scale) { throw null; }
        public Decimal(int[] bits) { throw null; }
        public Decimal(long value) { throw null; }
        public Decimal(float value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public Decimal(uint value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public Decimal(ulong value) { throw null; }
        public static System.Decimal Add(System.Decimal d1, System.Decimal d2) { throw null; }
        public static System.Decimal Ceiling(System.Decimal d) { throw null; }
        public static int Compare(System.Decimal d1, System.Decimal d2) { throw null; }
        public int CompareTo(System.Decimal value) { throw null; }
        public int CompareTo(object value) { throw null; }
        public static System.Decimal Divide(System.Decimal d1, System.Decimal d2) { throw null; }
        public bool Equals(System.Decimal value) { throw null; }
        public static bool Equals(System.Decimal d1, System.Decimal d2) { throw null; }
        public override bool Equals(object value) { throw null; }
        public static System.Decimal Floor(System.Decimal d) { throw null; }
        public static System.Decimal FromOACurrency(long cy) { throw null; }
        public static int[] GetBits(System.Decimal d) { throw null; }
        public override int GetHashCode() { throw null; }
        public System.TypeCode GetTypeCode() { throw null; }
        public static System.Decimal Multiply(System.Decimal d1, System.Decimal d2) { throw null; }
        public static System.Decimal Negate(System.Decimal d) { throw null; }
        public static System.Decimal operator +(System.Decimal d1, System.Decimal d2) { throw null; }
        public static System.Decimal operator --(System.Decimal d) { throw null; }
        public static System.Decimal operator /(System.Decimal d1, System.Decimal d2) { throw null; }
        public static bool operator ==(System.Decimal d1, System.Decimal d2) { throw null; }
        public static explicit operator byte (System.Decimal value) { throw null; }
        public static explicit operator char (System.Decimal value) { throw null; }
        public static explicit operator double (System.Decimal value) { throw null; }
        public static explicit operator short (System.Decimal value) { throw null; }
        public static explicit operator int (System.Decimal value) { throw null; }
        public static explicit operator long (System.Decimal value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static explicit operator sbyte (System.Decimal value) { throw null; }
        public static explicit operator float (System.Decimal value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static explicit operator ushort (System.Decimal value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static explicit operator uint (System.Decimal value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static explicit operator ulong (System.Decimal value) { throw null; }
        public static explicit operator System.Decimal (double value) { throw null; }
        public static explicit operator System.Decimal (float value) { throw null; }
        public static bool operator >(System.Decimal d1, System.Decimal d2) { throw null; }
        public static bool operator >=(System.Decimal d1, System.Decimal d2) { throw null; }
        public static implicit operator System.Decimal (byte value) { throw null; }
        public static implicit operator System.Decimal (char value) { throw null; }
        public static implicit operator System.Decimal (short value) { throw null; }
        public static implicit operator System.Decimal (int value) { throw null; }
        public static implicit operator System.Decimal (long value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static implicit operator System.Decimal (sbyte value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static implicit operator System.Decimal (ushort value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static implicit operator System.Decimal (uint value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static implicit operator System.Decimal (ulong value) { throw null; }
        public static System.Decimal operator ++(System.Decimal d) { throw null; }
        public static bool operator !=(System.Decimal d1, System.Decimal d2) { throw null; }
        public static bool operator <(System.Decimal d1, System.Decimal d2) { throw null; }
        public static bool operator <=(System.Decimal d1, System.Decimal d2) { throw null; }
        public static System.Decimal operator %(System.Decimal d1, System.Decimal d2) { throw null; }
        public static System.Decimal operator *(System.Decimal d1, System.Decimal d2) { throw null; }
        public static System.Decimal operator -(System.Decimal d1, System.Decimal d2) { throw null; }
        public static System.Decimal operator -(System.Decimal d) { throw null; }
        public static System.Decimal operator +(System.Decimal d) { throw null; }
        public static System.Decimal Parse(System.ReadOnlySpan<char> s, System.Globalization.NumberStyles style = System.Globalization.NumberStyles.Number, System.IFormatProvider provider = null) { throw null; }
        public static System.Decimal Parse(string s) { throw null; }
        public static System.Decimal Parse(string s, System.Globalization.NumberStyles style) { throw null; }
        public static System.Decimal Parse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider) { throw null; }
        public static System.Decimal Parse(string s, System.IFormatProvider provider) { throw null; }
        public static System.Decimal Remainder(System.Decimal d1, System.Decimal d2) { throw null; }
        public static System.Decimal Round(System.Decimal d) { throw null; }
        public static System.Decimal Round(System.Decimal d, int decimals) { throw null; }
        public static System.Decimal Round(System.Decimal d, int decimals, System.MidpointRounding mode) { throw null; }
        public static System.Decimal Round(System.Decimal d, System.MidpointRounding mode) { throw null; }
        public static System.Decimal Subtract(System.Decimal d1, System.Decimal d2) { throw null; }
        bool System.IConvertible.ToBoolean(System.IFormatProvider provider) { throw null; }
        byte System.IConvertible.ToByte(System.IFormatProvider provider) { throw null; }
        char System.IConvertible.ToChar(System.IFormatProvider provider) { throw null; }
        System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider) { throw null; }
        System.Decimal System.IConvertible.ToDecimal(System.IFormatProvider provider) { throw null; }
        double System.IConvertible.ToDouble(System.IFormatProvider provider) { throw null; }
        short System.IConvertible.ToInt16(System.IFormatProvider provider) { throw null; }
        int System.IConvertible.ToInt32(System.IFormatProvider provider) { throw null; }
        long System.IConvertible.ToInt64(System.IFormatProvider provider) { throw null; }
        sbyte System.IConvertible.ToSByte(System.IFormatProvider provider) { throw null; }
        float System.IConvertible.ToSingle(System.IFormatProvider provider) { throw null; }
        object System.IConvertible.ToType(System.Type type, System.IFormatProvider provider) { throw null; }
        ushort System.IConvertible.ToUInt16(System.IFormatProvider provider) { throw null; }
        uint System.IConvertible.ToUInt32(System.IFormatProvider provider) { throw null; }
        ulong System.IConvertible.ToUInt64(System.IFormatProvider provider) { throw null; }
        void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
        public static byte ToByte(System.Decimal value) { throw null; }
        public static double ToDouble(System.Decimal d) { throw null; }
        public static short ToInt16(System.Decimal value) { throw null; }
        public static int ToInt32(System.Decimal d) { throw null; }
        public static long ToInt64(System.Decimal d) { throw null; }
        public static long ToOACurrency(System.Decimal value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(System.Decimal value) { throw null; }
        public static float ToSingle(System.Decimal d) { throw null; }
        public override string ToString() { throw null; }
        public string ToString(System.IFormatProvider provider) { throw null; }
        public string ToString(string format) { throw null; }
        public string ToString(string format, System.IFormatProvider provider) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(System.Decimal value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(System.Decimal d) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(System.Decimal d) { throw null; }
        public static System.Decimal Truncate(System.Decimal d) { throw null; }
        public bool TryFormat(System.Span<char> destination, out int charsWritten, System.ReadOnlySpan<char> format = default(System.ReadOnlySpan<char>), System.IFormatProvider provider = null) { throw null; }
        public static bool TryParse(System.ReadOnlySpan<char> s, out System.Decimal result) { throw null; }
        public static bool TryParse(System.ReadOnlySpan<char> s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out System.Decimal result) { throw null; }
        public static bool TryParse(string s, out System.Decimal result) { throw null; }
        public static bool TryParse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out System.Decimal result) { throw null; }
    }
    public abstract partial class Delegate : System.ICloneable, System.Runtime.Serialization.ISerializable
    {
        protected Delegate(object target, string method) { }
        protected Delegate(System.Type target, string method) { }
        public System.Reflection.MethodInfo Method { get { throw null; } }
        public object Target { get { throw null; } }
        public virtual object Clone() { throw null; }
        public static System.Delegate Combine(System.Delegate a, System.Delegate b) { throw null; }
        public static System.Delegate Combine(params System.Delegate[] delegates) { throw null; }
        protected virtual System.Delegate CombineImpl(System.Delegate d) { throw null; }
        public static System.Delegate CreateDelegate(System.Type type, object firstArgument, System.Reflection.MethodInfo method) { throw null; }
        public static System.Delegate CreateDelegate(System.Type type, object firstArgument, System.Reflection.MethodInfo method, bool throwOnBindFailure) { throw null; }
        public static System.Delegate CreateDelegate(System.Type type, object target, string method) { throw null; }
        public static System.Delegate CreateDelegate(System.Type type, object target, string method, bool ignoreCase) { throw null; }
        public static System.Delegate CreateDelegate(System.Type type, object target, string method, bool ignoreCase, bool throwOnBindFailure) { throw null; }
        public static System.Delegate CreateDelegate(System.Type type, System.Reflection.MethodInfo method) { throw null; }
        public static System.Delegate CreateDelegate(System.Type type, System.Reflection.MethodInfo method, bool throwOnBindFailure) { throw null; }
        public static System.Delegate CreateDelegate(System.Type type, System.Type target, string method) { throw null; }
        public static System.Delegate CreateDelegate(System.Type type, System.Type target, string method, bool ignoreCase) { throw null; }
        public static System.Delegate CreateDelegate(System.Type type, System.Type target, string method, bool ignoreCase, bool throwOnBindFailure) { throw null; }
        public object DynamicInvoke(params object[] args) { throw null; }
        protected virtual object DynamicInvokeImpl(object[] args) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public virtual System.Delegate[] GetInvocationList() { throw null; }
        protected virtual System.Reflection.MethodInfo GetMethodImpl() { throw null; }
        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public static bool operator ==(System.Delegate d1, System.Delegate d2) { throw null; }
        public static bool operator !=(System.Delegate d1, System.Delegate d2) { throw null; }
        public static System.Delegate Remove(System.Delegate source, System.Delegate value) { throw null; }
        public static System.Delegate RemoveAll(System.Delegate source, System.Delegate value) { throw null; }
        protected virtual System.Delegate RemoveImpl(System.Delegate d) { throw null; }
    }
    public partial class DivideByZeroException : System.ArithmeticException
    {
        public DivideByZeroException() { }
        protected DivideByZeroException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public DivideByZeroException(string message) { }
        public DivideByZeroException(string message, System.Exception innerException) { }
    }
    public partial class DllNotFoundException : System.TypeLoadException
    {
        public DllNotFoundException() { }
        protected DllNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public DllNotFoundException(string message) { }
        public DllNotFoundException(string message, System.Exception inner) { }
    }
    public readonly partial struct Double : System.IComparable, System.IComparable<double>, System.IConvertible, System.IEquatable<double>, System.IFormattable
    {
        private readonly double _dummyPrimitive;
        public const double Epsilon = 4.94065645841247E-324;
        public const double MaxValue = 1.7976931348623157E+308;
        public const double MinValue = -1.7976931348623157E+308;
        public const double NaN = 0.0 / 0.0;
        public const double NegativeInfinity = -1.0 / 0.0;
        public const double PositiveInfinity = 1.0 / 0.0;
        public int CompareTo(System.Double value) { throw null; }
        public int CompareTo(object value) { throw null; }
        public bool Equals(System.Double obj) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public System.TypeCode GetTypeCode() { throw null; }
        public static bool IsFinite(System.Double d) { throw null; }
        public static bool IsInfinity(System.Double d) { throw null; }
        public static bool IsNaN(System.Double d) { throw null; }
        public static bool IsNegative(System.Double d) { throw null; }
        public static bool IsNegativeInfinity(System.Double d) { throw null; }
        public static bool IsNormal(System.Double d) { throw null; }
        public static bool IsPositiveInfinity(System.Double d) { throw null; }
        public static bool IsSubnormal(System.Double d) { throw null; }
        public static bool operator ==(System.Double left, System.Double right) { throw null; }
        public static bool operator >(System.Double left, System.Double right) { throw null; }
        public static bool operator >=(System.Double left, System.Double right) { throw null; }
        public static bool operator !=(System.Double left, System.Double right) { throw null; }
        public static bool operator <(System.Double left, System.Double right) { throw null; }
        public static bool operator <=(System.Double left, System.Double right) { throw null; }
        public static System.Double Parse(System.ReadOnlySpan<char> s, System.Globalization.NumberStyles style = System.Globalization.NumberStyles.AllowDecimalPoint | System.Globalization.NumberStyles.AllowExponent | System.Globalization.NumberStyles.AllowLeadingSign | System.Globalization.NumberStyles.AllowLeadingWhite | System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.AllowTrailingWhite, System.IFormatProvider provider = null) { throw null; }
        public static System.Double Parse(string s) { throw null; }
        public static System.Double Parse(string s, System.Globalization.NumberStyles style) { throw null; }
        public static System.Double Parse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider) { throw null; }
        public static System.Double Parse(string s, System.IFormatProvider provider) { throw null; }
        bool System.IConvertible.ToBoolean(System.IFormatProvider provider) { throw null; }
        byte System.IConvertible.ToByte(System.IFormatProvider provider) { throw null; }
        char System.IConvertible.ToChar(System.IFormatProvider provider) { throw null; }
        System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider) { throw null; }
        decimal System.IConvertible.ToDecimal(System.IFormatProvider provider) { throw null; }
        System.Double System.IConvertible.ToDouble(System.IFormatProvider provider) { throw null; }
        short System.IConvertible.ToInt16(System.IFormatProvider provider) { throw null; }
        int System.IConvertible.ToInt32(System.IFormatProvider provider) { throw null; }
        long System.IConvertible.ToInt64(System.IFormatProvider provider) { throw null; }
        sbyte System.IConvertible.ToSByte(System.IFormatProvider provider) { throw null; }
        float System.IConvertible.ToSingle(System.IFormatProvider provider) { throw null; }
        object System.IConvertible.ToType(System.Type type, System.IFormatProvider provider) { throw null; }
        ushort System.IConvertible.ToUInt16(System.IFormatProvider provider) { throw null; }
        uint System.IConvertible.ToUInt32(System.IFormatProvider provider) { throw null; }
        ulong System.IConvertible.ToUInt64(System.IFormatProvider provider) { throw null; }
        public override string ToString() { throw null; }
        public string ToString(System.IFormatProvider provider) { throw null; }
        public string ToString(string format) { throw null; }
        public string ToString(string format, System.IFormatProvider provider) { throw null; }
        public bool TryFormat(System.Span<char> destination, out int charsWritten, System.ReadOnlySpan<char> format = default(System.ReadOnlySpan<char>), System.IFormatProvider provider = null) { throw null; }
        public static bool TryParse(System.ReadOnlySpan<char> s, out System.Double result) { throw null; }
        public static bool TryParse(System.ReadOnlySpan<char> s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out System.Double result) { throw null; }
        public static bool TryParse(string s, out System.Double result) { throw null; }
        public static bool TryParse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out System.Double result) { throw null; }
    }
    public partial class DuplicateWaitObjectException : System.ArgumentException
    {
        public DuplicateWaitObjectException() { }
        protected DuplicateWaitObjectException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public DuplicateWaitObjectException(string parameterName) { }
        public DuplicateWaitObjectException(string message, System.Exception innerException) { }
        public DuplicateWaitObjectException(string parameterName, string message) { }
    }
    public partial class EntryPointNotFoundException : System.TypeLoadException
    {
        public EntryPointNotFoundException() { }
        protected EntryPointNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public EntryPointNotFoundException(string message) { }
        public EntryPointNotFoundException(string message, System.Exception inner) { }
    }
    public abstract partial class Enum : System.ValueType, System.IComparable, System.IConvertible, System.IFormattable
    {
        protected Enum() { }
        public int CompareTo(object target) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public static string Format(System.Type enumType, object value, string format) { throw null; }
        public override int GetHashCode() { throw null; }
        public static string GetName(System.Type enumType, object value) { throw null; }
        public static string[] GetNames(System.Type enumType) { throw null; }
        public System.TypeCode GetTypeCode() { throw null; }
        public static System.Type GetUnderlyingType(System.Type enumType) { throw null; }
        public static System.Array GetValues(System.Type enumType) { throw null; }
        public bool HasFlag(System.Enum flag) { throw null; }
        public static bool IsDefined(System.Type enumType, object value) { throw null; }
        public static object Parse(System.Type enumType, string value) { throw null; }
        public static object Parse(System.Type enumType, string value, bool ignoreCase) { throw null; }
        public static TEnum Parse<TEnum>(string value) where TEnum : struct { throw null; }
        public static TEnum Parse<TEnum>(string value, bool ignoreCase) where TEnum : struct { throw null; }
        bool System.IConvertible.ToBoolean(System.IFormatProvider provider) { throw null; }
        byte System.IConvertible.ToByte(System.IFormatProvider provider) { throw null; }
        char System.IConvertible.ToChar(System.IFormatProvider provider) { throw null; }
        System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider) { throw null; }
        decimal System.IConvertible.ToDecimal(System.IFormatProvider provider) { throw null; }
        double System.IConvertible.ToDouble(System.IFormatProvider provider) { throw null; }
        short System.IConvertible.ToInt16(System.IFormatProvider provider) { throw null; }
        int System.IConvertible.ToInt32(System.IFormatProvider provider) { throw null; }
        long System.IConvertible.ToInt64(System.IFormatProvider provider) { throw null; }
        sbyte System.IConvertible.ToSByte(System.IFormatProvider provider) { throw null; }
        float System.IConvertible.ToSingle(System.IFormatProvider provider) { throw null; }
        object System.IConvertible.ToType(System.Type type, System.IFormatProvider provider) { throw null; }
        ushort System.IConvertible.ToUInt16(System.IFormatProvider provider) { throw null; }
        uint System.IConvertible.ToUInt32(System.IFormatProvider provider) { throw null; }
        ulong System.IConvertible.ToUInt64(System.IFormatProvider provider) { throw null; }
        public static object ToObject(System.Type enumType, byte value) { throw null; }
        public static object ToObject(System.Type enumType, short value) { throw null; }
        public static object ToObject(System.Type enumType, int value) { throw null; }
        public static object ToObject(System.Type enumType, long value) { throw null; }
        public static object ToObject(System.Type enumType, object value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static object ToObject(System.Type enumType, sbyte value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static object ToObject(System.Type enumType, ushort value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static object ToObject(System.Type enumType, uint value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static object ToObject(System.Type enumType, ulong value) { throw null; }
        public override string ToString() { throw null; }
        [System.ObsoleteAttribute("The provider argument is not used. Please use ToString().")]
        public string ToString(System.IFormatProvider provider) { throw null; }
        public string ToString(string format) { throw null; }
        [System.ObsoleteAttribute("The provider argument is not used. Please use ToString(String).")]
        public string ToString(string format, System.IFormatProvider provider) { throw null; }
        public static bool TryParse(System.Type enumType, string value, bool ignoreCase, out object result) { throw null; }
        public static bool TryParse(System.Type enumType, string value, out object result) { throw null; }
        public static bool TryParse<TEnum>(string value, bool ignoreCase, out TEnum result) where TEnum : struct { throw null; }
        public static bool TryParse<TEnum>(string value, out TEnum result) where TEnum : struct { throw null; }
    }
    public static partial class Environment
    {
        public static string CommandLine { get { throw null; } }
        public static string CurrentDirectory { get { throw null; } set { } }
        public static int CurrentManagedThreadId { get { throw null; } }
        public static int ExitCode { get { throw null; } set { } }
        public static bool HasShutdownStarted { get { throw null; } }
        public static bool Is64BitOperatingSystem { get { throw null; } }
        public static bool Is64BitProcess { get { throw null; } }
        public static string MachineName { get { throw null; } }
        public static string NewLine { get { throw null; } }
        public static System.OperatingSystem OSVersion { get { throw null; } }
        public static int ProcessorCount { get { throw null; } }
        public static string StackTrace { get { throw null; } }
        public static string SystemDirectory { get { throw null; } }
        public static int SystemPageSize { get { throw null; } }
        public static int TickCount { get { throw null; } }
        public static string UserDomainName { get { throw null; } }
        public static bool UserInteractive { get { throw null; } }
        public static string UserName { get { throw null; } }
        public static System.Version Version { get { throw null; } }
        public static long WorkingSet { get { throw null; } }
        public static void Exit(int exitCode) { }
        public static string ExpandEnvironmentVariables(string name) { throw null; }
        public static void FailFast(string message) { }
        public static void FailFast(string message, System.Exception exception) { }
        public static string[] GetCommandLineArgs() { throw null; }
        public static string GetEnvironmentVariable(string variable) { throw null; }
        public static string GetEnvironmentVariable(string variable, System.EnvironmentVariableTarget target) { throw null; }
        public static System.Collections.IDictionary GetEnvironmentVariables() { throw null; }
        public static System.Collections.IDictionary GetEnvironmentVariables(System.EnvironmentVariableTarget target) { throw null; }
        public static string GetFolderPath(System.Environment.SpecialFolder folder) { throw null; }
        public static string GetFolderPath(System.Environment.SpecialFolder folder, System.Environment.SpecialFolderOption option) { throw null; }
        public static string[] GetLogicalDrives() { throw null; }
        public static void SetEnvironmentVariable(string variable, string value) { }
        public static void SetEnvironmentVariable(string variable, string value, System.EnvironmentVariableTarget target) { }
        public enum SpecialFolder
        {
            AdminTools = 48,
            ApplicationData = 26,
            CDBurning = 59,
            CommonAdminTools = 47,
            CommonApplicationData = 35,
            CommonDesktopDirectory = 25,
            CommonDocuments = 46,
            CommonMusic = 53,
            CommonOemLinks = 58,
            CommonPictures = 54,
            CommonProgramFiles = 43,
            CommonProgramFilesX86 = 44,
            CommonPrograms = 23,
            CommonStartMenu = 22,
            CommonStartup = 24,
            CommonTemplates = 45,
            CommonVideos = 55,
            Cookies = 33,
            Desktop = 0,
            DesktopDirectory = 16,
            Favorites = 6,
            Fonts = 20,
            History = 34,
            InternetCache = 32,
            LocalApplicationData = 28,
            LocalizedResources = 57,
            MyComputer = 17,
            MyDocuments = 5,
            MyMusic = 13,
            MyPictures = 39,
            MyVideos = 14,
            NetworkShortcuts = 19,
            Personal = 5,
            PrinterShortcuts = 27,
            ProgramFiles = 38,
            ProgramFilesX86 = 42,
            Programs = 2,
            Recent = 8,
            Resources = 56,
            SendTo = 9,
            StartMenu = 11,
            Startup = 7,
            System = 37,
            SystemX86 = 41,
            Templates = 21,
            UserProfile = 40,
            Windows = 36,
        }
        public enum SpecialFolderOption
        {
            Create = 32768,
            DoNotVerify = 16384,
            None = 0,
        }
    }
    public enum EnvironmentVariableTarget
    {
        Machine = 2,
        Process = 0,
        User = 1,
    }
    public partial class EventArgs
    {
        public static readonly System.EventArgs Empty;
        public EventArgs() { }
    }
    public delegate void EventHandler(object sender, System.EventArgs e);
    public delegate void EventHandler<TEventArgs>(object sender, TEventArgs e);
    public partial class Exception : System.Runtime.Serialization.ISerializable
    {
        public Exception() { }
        protected Exception(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public Exception(string message) { }
        public Exception(string message, System.Exception innerException) { }
        public virtual System.Collections.IDictionary Data { get { throw null; } }
        public virtual string HelpLink { get { throw null; } set { } }
        public int HResult { get { throw null; } protected set { } }
        public System.Exception InnerException { get { throw null; } }
        public virtual string Message { get { throw null; } }
        public virtual string Source { get { throw null; } set { } }
        public virtual string StackTrace { get { throw null; } }
        public System.Reflection.MethodBase TargetSite { get { throw null; } }
        protected event System.EventHandler<System.Runtime.Serialization.SafeSerializationEventArgs> SerializeObjectState { add { } remove { } }
        public virtual System.Exception GetBaseException() { throw null; }
        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public new System.Type GetType() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.ObsoleteAttribute("This type previously indicated an unspecified fatal error in the runtime. The runtime no longer raises this exception so this type is obsolete.")]
    public sealed partial class ExecutionEngineException : System.SystemException
    {
        public ExecutionEngineException() { }
        public ExecutionEngineException(string message) { }
        public ExecutionEngineException(string message, System.Exception innerException) { }
    }
    public partial class FieldAccessException : System.MemberAccessException
    {
        public FieldAccessException() { }
        protected FieldAccessException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public FieldAccessException(string message) { }
        public FieldAccessException(string message, System.Exception inner) { }
    }
    public partial class FileStyleUriParser : System.UriParser
    {
        public FileStyleUriParser() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Enum, Inherited=false)]
    public partial class FlagsAttribute : System.Attribute
    {
        public FlagsAttribute() { }
    }
    public partial class FormatException : System.SystemException
    {
        public FormatException() { }
        protected FormatException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public FormatException(string message) { }
        public FormatException(string message, System.Exception innerException) { }
    }
    public abstract partial class FormattableString : System.IFormattable
    {
        protected FormattableString() { }
        public abstract int ArgumentCount { get; }
        public abstract string Format { get; }
        public abstract object GetArgument(int index);
        public abstract object[] GetArguments();
        public static string Invariant(System.FormattableString formattable) { throw null; }
        string System.IFormattable.ToString(string ignored, System.IFormatProvider formatProvider) { throw null; }
        public override string ToString() { throw null; }
        public abstract string ToString(System.IFormatProvider formatProvider);
    }
    public partial class FtpStyleUriParser : System.UriParser
    {
        public FtpStyleUriParser() { }
    }
    public delegate TResult Func<out TResult>();
    public delegate TResult Func<in T, out TResult>(T arg);
    public delegate TResult Func<in T1, in T2, out TResult>(T1 arg1, T2 arg2);
    public delegate TResult Func<in T1, in T2, in T3, out TResult>(T1 arg1, T2 arg2, T3 arg3);
    public delegate TResult Func<in T1, in T2, in T3, in T4, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4);
    public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);
    public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);
    public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);
    public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);
    public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9);
    public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10);
    public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11);
    public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12);
    public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13);
    public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14);
    public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15);
    public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16);
    public static partial class GC
    {
        public static int MaxGeneration { get { throw null; } }
        public static void AddMemoryPressure(long bytesAllocated) { }
        public static void CancelFullGCNotification() { }
        public static void Collect() { }
        public static void Collect(int generation) { }
        public static void Collect(int generation, System.GCCollectionMode mode) { }
        public static void Collect(int generation, System.GCCollectionMode mode, bool blocking) { }
        public static void Collect(int generation, System.GCCollectionMode mode, bool blocking, bool compacting) { }
        public static int CollectionCount(int generation) { throw null; }
        public static void EndNoGCRegion() { }
        public static long GetAllocatedBytesForCurrentThread() { throw null; }
        public static int GetGeneration(object obj) { throw null; }
        public static int GetGeneration(System.WeakReference wo) { throw null; }
        public static long GetTotalMemory(bool forceFullCollection) { throw null; }
        public static void KeepAlive(object obj) { }
        public static void RegisterForFullGCNotification(int maxGenerationThreshold, int largeObjectHeapThreshold) { }
        public static void RemoveMemoryPressure(long bytesAllocated) { }
        public static void ReRegisterForFinalize(object obj) { }
        public static void SuppressFinalize(object obj) { }
        public static bool TryStartNoGCRegion(long totalSize) { throw null; }
        public static bool TryStartNoGCRegion(long totalSize, bool disallowFullBlockingGC) { throw null; }
        public static bool TryStartNoGCRegion(long totalSize, long lohSize) { throw null; }
        public static bool TryStartNoGCRegion(long totalSize, long lohSize, bool disallowFullBlockingGC) { throw null; }
        public static System.GCNotificationStatus WaitForFullGCApproach() { throw null; }
        public static System.GCNotificationStatus WaitForFullGCApproach(int millisecondsTimeout) { throw null; }
        public static System.GCNotificationStatus WaitForFullGCComplete() { throw null; }
        public static System.GCNotificationStatus WaitForFullGCComplete(int millisecondsTimeout) { throw null; }
        public static void WaitForPendingFinalizers() { }
    }
    public enum GCCollectionMode
    {
        Default = 0,
        Forced = 1,
        Optimized = 2,
    }
    public enum GCNotificationStatus
    {
        Canceled = 2,
        Failed = 1,
        NotApplicable = 4,
        Succeeded = 0,
        Timeout = 3,
    }
    public partial class GenericUriParser : System.UriParser
    {
        public GenericUriParser(System.GenericUriParserOptions options) { }
    }
    [System.FlagsAttribute]
    public enum GenericUriParserOptions
    {
        AllowEmptyAuthority = 2,
        Default = 0,
        DontCompressPath = 128,
        DontConvertPathBackslashes = 64,
        DontUnescapePathDotsAndSlashes = 256,
        GenericAuthority = 1,
        Idn = 512,
        IriParsing = 1024,
        NoFragment = 32,
        NoPort = 8,
        NoQuery = 16,
        NoUserInfo = 4,
    }
    public partial class GopherStyleUriParser : System.UriParser
    {
        public GopherStyleUriParser() { }
    }
    public partial struct Guid : System.IComparable, System.IComparable<System.Guid>, System.IEquatable<System.Guid>, System.IFormattable
    {
        private int _dummyPrimitive;
        public static readonly System.Guid Empty;
        public Guid(byte[] b) { throw null; }
        public Guid(int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k) { throw null; }
        public Guid(int a, short b, short c, byte[] d) { throw null; }
        public Guid(System.ReadOnlySpan<byte> b) { throw null; }
        public Guid(string g) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public Guid(uint a, ushort b, ushort c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k) { throw null; }
        public int CompareTo(System.Guid value) { throw null; }
        public int CompareTo(object value) { throw null; }
        public bool Equals(System.Guid g) { throw null; }
        public override bool Equals(object o) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Guid NewGuid() { throw null; }
        public static bool operator ==(System.Guid a, System.Guid b) { throw null; }
        public static bool operator !=(System.Guid a, System.Guid b) { throw null; }
        public static System.Guid Parse(System.ReadOnlySpan<char> input) { throw null; }
        public static System.Guid Parse(string input) { throw null; }
        public static System.Guid ParseExact(System.ReadOnlySpan<char> input, System.ReadOnlySpan<char> format) { throw null; }
        public static System.Guid ParseExact(string input, string format) { throw null; }
        public byte[] ToByteArray() { throw null; }
        public override string ToString() { throw null; }
        public string ToString(string format) { throw null; }
        public string ToString(string format, System.IFormatProvider provider) { throw null; }
        public bool TryFormat(System.Span<char> destination, out int charsWritten, System.ReadOnlySpan<char> format = default(System.ReadOnlySpan<char>)) { throw null; }
        public static bool TryParse(System.ReadOnlySpan<char> input, out System.Guid result) { throw null; }
        public static bool TryParse(string input, out System.Guid result) { throw null; }
        public static bool TryParseExact(System.ReadOnlySpan<char> input, System.ReadOnlySpan<char> format, out System.Guid result) { throw null; }
        public static bool TryParseExact(string input, string format, out System.Guid result) { throw null; }
        public bool TryWriteBytes(System.Span<byte> destination) { throw null; }
    }
    public partial struct HashCode
    {
        private int _dummyPrimitive;
        public void Add<T>(T value) { }
        public void Add<T>(T value, System.Collections.Generic.IEqualityComparer<T> comparer) { }
        public static int Combine<T1>(T1 value1) { throw null; }
        public static int Combine<T1, T2>(T1 value1, T2 value2) { throw null; }
        public static int Combine<T1, T2, T3>(T1 value1, T2 value2, T3 value3) { throw null; }
        public static int Combine<T1, T2, T3, T4>(T1 value1, T2 value2, T3 value3, T4 value4) { throw null; }
        public static int Combine<T1, T2, T3, T4, T5>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) { throw null; }
        public static int Combine<T1, T2, T3, T4, T5, T6>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) { throw null; }
        public static int Combine<T1, T2, T3, T4, T5, T6, T7>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) { throw null; }
        public static int Combine<T1, T2, T3, T4, T5, T6, T7, T8>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("HashCode is a mutable struct and should not be compared with other HashCodes.", true)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("HashCode is a mutable struct and should not be compared with other HashCodes. Use ToHashCode to retrieve the computed hash code.", true)]
        public override int GetHashCode() { throw null; }
        public int ToHashCode() { throw null; }
    }
    public partial class HttpStyleUriParser : System.UriParser
    {
        public HttpStyleUriParser() { }
    }
    public partial interface IAsyncDisposable
    {
        System.Threading.Tasks.ValueTask DisposeAsync();
    }
    public partial interface IAsyncResult
    {
        object AsyncState { get; }
        System.Threading.WaitHandle AsyncWaitHandle { get; }
        bool CompletedSynchronously { get; }
        bool IsCompleted { get; }
    }
    public partial interface ICloneable
    {
        object Clone();
    }
    public partial interface IComparable
    {
        int CompareTo(object obj);
    }
    public partial interface IComparable<in T>
    {
        int CompareTo(T other);
    }
    [System.CLSCompliantAttribute(false)]
    public partial interface IConvertible
    {
        System.TypeCode GetTypeCode();
        bool ToBoolean(System.IFormatProvider provider);
        byte ToByte(System.IFormatProvider provider);
        char ToChar(System.IFormatProvider provider);
        System.DateTime ToDateTime(System.IFormatProvider provider);
        decimal ToDecimal(System.IFormatProvider provider);
        double ToDouble(System.IFormatProvider provider);
        short ToInt16(System.IFormatProvider provider);
        int ToInt32(System.IFormatProvider provider);
        long ToInt64(System.IFormatProvider provider);
        sbyte ToSByte(System.IFormatProvider provider);
        float ToSingle(System.IFormatProvider provider);
        string ToString(System.IFormatProvider provider);
        object ToType(System.Type conversionType, System.IFormatProvider provider);
        ushort ToUInt16(System.IFormatProvider provider);
        uint ToUInt32(System.IFormatProvider provider);
        ulong ToUInt64(System.IFormatProvider provider);
    }
    public partial interface ICustomFormatter
    {
        string Format(string format, object arg, System.IFormatProvider formatProvider);
    }
    public partial interface IDisposable
    {
        void Dispose();
    }
    public partial interface IEquatable<T>
    {
        bool Equals(T other);
    }
    public partial interface IFormatProvider
    {
        object GetFormat(System.Type formatType);
    }
    public partial interface IFormattable
    {
        string ToString(string format, System.IFormatProvider formatProvider);
    }
    public readonly partial struct Index : System.IEquatable<System.Index>
    {
        private readonly int _dummyPrimitive;
        public Index(int value, bool fromEnd = false) { throw null; }
        public static System.Index End { get { throw null; } }
        public bool IsFromEnd { get { throw null; } }
        public static System.Index Start { get { throw null; } }
        public int Value { get { throw null; } }
        public bool Equals(System.Index other) { throw null; }
        public override bool Equals(object value) { throw null; }
        public static System.Index FromEnd(int value) { throw null; }
        public static System.Index FromStart(int value) { throw null; }
        public override int GetHashCode() { throw null; }
        public int GetOffset(int length) { throw null; }
        public static implicit operator System.Index (int value) { throw null; }
        public override string ToString() { throw null; }
    }
    public sealed partial class IndexOutOfRangeException : System.SystemException
    {
        public IndexOutOfRangeException() { }
        public IndexOutOfRangeException(string message) { }
        public IndexOutOfRangeException(string message, System.Exception innerException) { }
    }
    public sealed partial class InsufficientExecutionStackException : System.SystemException
    {
        public InsufficientExecutionStackException() { }
        public InsufficientExecutionStackException(string message) { }
        public InsufficientExecutionStackException(string message, System.Exception innerException) { }
    }
    public sealed partial class InsufficientMemoryException : System.OutOfMemoryException
    {
        public InsufficientMemoryException() { }
        public InsufficientMemoryException(string message) { }
        public InsufficientMemoryException(string message, System.Exception innerException) { }
    }
    public readonly partial struct Int16 : System.IComparable, System.IComparable<short>, System.IConvertible, System.IEquatable<short>, System.IFormattable
    {
        private readonly short _dummyPrimitive;
        public const short MaxValue = (short)32767;
        public const short MinValue = (short)-32768;
        public int CompareTo(System.Int16 value) { throw null; }
        public int CompareTo(object value) { throw null; }
        public bool Equals(System.Int16 obj) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public System.TypeCode GetTypeCode() { throw null; }
        public static System.Int16 Parse(System.ReadOnlySpan<char> s, System.Globalization.NumberStyles style = System.Globalization.NumberStyles.Integer, System.IFormatProvider provider = null) { throw null; }
        public static System.Int16 Parse(string s) { throw null; }
        public static System.Int16 Parse(string s, System.Globalization.NumberStyles style) { throw null; }
        public static System.Int16 Parse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider) { throw null; }
        public static System.Int16 Parse(string s, System.IFormatProvider provider) { throw null; }
        bool System.IConvertible.ToBoolean(System.IFormatProvider provider) { throw null; }
        byte System.IConvertible.ToByte(System.IFormatProvider provider) { throw null; }
        char System.IConvertible.ToChar(System.IFormatProvider provider) { throw null; }
        System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider) { throw null; }
        decimal System.IConvertible.ToDecimal(System.IFormatProvider provider) { throw null; }
        double System.IConvertible.ToDouble(System.IFormatProvider provider) { throw null; }
        System.Int16 System.IConvertible.ToInt16(System.IFormatProvider provider) { throw null; }
        int System.IConvertible.ToInt32(System.IFormatProvider provider) { throw null; }
        long System.IConvertible.ToInt64(System.IFormatProvider provider) { throw null; }
        sbyte System.IConvertible.ToSByte(System.IFormatProvider provider) { throw null; }
        float System.IConvertible.ToSingle(System.IFormatProvider provider) { throw null; }
        object System.IConvertible.ToType(System.Type type, System.IFormatProvider provider) { throw null; }
        ushort System.IConvertible.ToUInt16(System.IFormatProvider provider) { throw null; }
        uint System.IConvertible.ToUInt32(System.IFormatProvider provider) { throw null; }
        ulong System.IConvertible.ToUInt64(System.IFormatProvider provider) { throw null; }
        public override string ToString() { throw null; }
        public string ToString(System.IFormatProvider provider) { throw null; }
        public string ToString(string format) { throw null; }
        public string ToString(string format, System.IFormatProvider provider) { throw null; }
        public bool TryFormat(System.Span<char> destination, out int charsWritten, System.ReadOnlySpan<char> format = default(System.ReadOnlySpan<char>), System.IFormatProvider provider = null) { throw null; }
        public static bool TryParse(System.ReadOnlySpan<char> s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out System.Int16 result) { throw null; }
        public static bool TryParse(System.ReadOnlySpan<char> s, out System.Int16 result) { throw null; }
        public static bool TryParse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out System.Int16 result) { throw null; }
        public static bool TryParse(string s, out System.Int16 result) { throw null; }
    }
    public readonly partial struct Int32 : System.IComparable, System.IComparable<int>, System.IConvertible, System.IEquatable<int>, System.IFormattable
    {
        private readonly int _dummyPrimitive;
        public const int MaxValue = 2147483647;
        public const int MinValue = -2147483648;
        public System.Int32 CompareTo(System.Int32 value) { throw null; }
        public System.Int32 CompareTo(object value) { throw null; }
        public bool Equals(System.Int32 obj) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override System.Int32 GetHashCode() { throw null; }
        public System.TypeCode GetTypeCode() { throw null; }
        public static System.Int32 Parse(System.ReadOnlySpan<char> s, System.Globalization.NumberStyles style = System.Globalization.NumberStyles.Integer, System.IFormatProvider provider = null) { throw null; }
        public static System.Int32 Parse(string s) { throw null; }
        public static System.Int32 Parse(string s, System.Globalization.NumberStyles style) { throw null; }
        public static System.Int32 Parse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider) { throw null; }
        public static System.Int32 Parse(string s, System.IFormatProvider provider) { throw null; }
        bool System.IConvertible.ToBoolean(System.IFormatProvider provider) { throw null; }
        byte System.IConvertible.ToByte(System.IFormatProvider provider) { throw null; }
        char System.IConvertible.ToChar(System.IFormatProvider provider) { throw null; }
        System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider) { throw null; }
        decimal System.IConvertible.ToDecimal(System.IFormatProvider provider) { throw null; }
        double System.IConvertible.ToDouble(System.IFormatProvider provider) { throw null; }
        short System.IConvertible.ToInt16(System.IFormatProvider provider) { throw null; }
        System.Int32 System.IConvertible.ToInt32(System.IFormatProvider provider) { throw null; }
        long System.IConvertible.ToInt64(System.IFormatProvider provider) { throw null; }
        sbyte System.IConvertible.ToSByte(System.IFormatProvider provider) { throw null; }
        float System.IConvertible.ToSingle(System.IFormatProvider provider) { throw null; }
        object System.IConvertible.ToType(System.Type type, System.IFormatProvider provider) { throw null; }
        ushort System.IConvertible.ToUInt16(System.IFormatProvider provider) { throw null; }
        uint System.IConvertible.ToUInt32(System.IFormatProvider provider) { throw null; }
        ulong System.IConvertible.ToUInt64(System.IFormatProvider provider) { throw null; }
        public override string ToString() { throw null; }
        public string ToString(System.IFormatProvider provider) { throw null; }
        public string ToString(string format) { throw null; }
        public string ToString(string format, System.IFormatProvider provider) { throw null; }
        public bool TryFormat(System.Span<char> destination, out System.Int32 charsWritten, System.ReadOnlySpan<char> format = default(System.ReadOnlySpan<char>), System.IFormatProvider provider = null) { throw null; }
        public static bool TryParse(System.ReadOnlySpan<char> s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out System.Int32 result) { throw null; }
        public static bool TryParse(System.ReadOnlySpan<char> s, out System.Int32 result) { throw null; }
        public static bool TryParse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out System.Int32 result) { throw null; }
        public static bool TryParse(string s, out System.Int32 result) { throw null; }
    }
    public readonly partial struct Int64 : System.IComparable, System.IComparable<long>, System.IConvertible, System.IEquatable<long>, System.IFormattable
    {
        private readonly long _dummyPrimitive;
        public const long MaxValue = (long)9223372036854775807;
        public const long MinValue = (long)-9223372036854775808;
        public int CompareTo(System.Int64 value) { throw null; }
        public int CompareTo(object value) { throw null; }
        public bool Equals(System.Int64 obj) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public System.TypeCode GetTypeCode() { throw null; }
        public static System.Int64 Parse(System.ReadOnlySpan<char> s, System.Globalization.NumberStyles style = System.Globalization.NumberStyles.Integer, System.IFormatProvider provider = null) { throw null; }
        public static System.Int64 Parse(string s) { throw null; }
        public static System.Int64 Parse(string s, System.Globalization.NumberStyles style) { throw null; }
        public static System.Int64 Parse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider) { throw null; }
        public static System.Int64 Parse(string s, System.IFormatProvider provider) { throw null; }
        bool System.IConvertible.ToBoolean(System.IFormatProvider provider) { throw null; }
        byte System.IConvertible.ToByte(System.IFormatProvider provider) { throw null; }
        char System.IConvertible.ToChar(System.IFormatProvider provider) { throw null; }
        System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider) { throw null; }
        decimal System.IConvertible.ToDecimal(System.IFormatProvider provider) { throw null; }
        double System.IConvertible.ToDouble(System.IFormatProvider provider) { throw null; }
        short System.IConvertible.ToInt16(System.IFormatProvider provider) { throw null; }
        int System.IConvertible.ToInt32(System.IFormatProvider provider) { throw null; }
        System.Int64 System.IConvertible.ToInt64(System.IFormatProvider provider) { throw null; }
        sbyte System.IConvertible.ToSByte(System.IFormatProvider provider) { throw null; }
        float System.IConvertible.ToSingle(System.IFormatProvider provider) { throw null; }
        object System.IConvertible.ToType(System.Type type, System.IFormatProvider provider) { throw null; }
        ushort System.IConvertible.ToUInt16(System.IFormatProvider provider) { throw null; }
        uint System.IConvertible.ToUInt32(System.IFormatProvider provider) { throw null; }
        ulong System.IConvertible.ToUInt64(System.IFormatProvider provider) { throw null; }
        public override string ToString() { throw null; }
        public string ToString(System.IFormatProvider provider) { throw null; }
        public string ToString(string format) { throw null; }
        public string ToString(string format, System.IFormatProvider provider) { throw null; }
        public bool TryFormat(System.Span<char> destination, out int charsWritten, System.ReadOnlySpan<char> format = default(System.ReadOnlySpan<char>), System.IFormatProvider provider = null) { throw null; }
        public static bool TryParse(System.ReadOnlySpan<char> s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out System.Int64 result) { throw null; }
        public static bool TryParse(System.ReadOnlySpan<char> s, out System.Int64 result) { throw null; }
        public static bool TryParse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out System.Int64 result) { throw null; }
        public static bool TryParse(string s, out System.Int64 result) { throw null; }
    }
    public readonly partial struct IntPtr : System.IEquatable<System.IntPtr>, System.Runtime.Serialization.ISerializable
    {
        private readonly int _dummyPrimitive;
        public static readonly System.IntPtr Zero;
        public IntPtr(int value) { throw null; }
        public IntPtr(long value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public unsafe IntPtr(void* value) { throw null; }
        public static int Size { get { throw null; } }
        public static System.IntPtr Add(System.IntPtr pointer, int offset) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.IntPtr operator +(System.IntPtr pointer, int offset) { throw null; }
        public static bool operator ==(System.IntPtr value1, System.IntPtr value2) { throw null; }
        public static explicit operator System.IntPtr (int value) { throw null; }
        public static explicit operator System.IntPtr (long value) { throw null; }
        public static explicit operator int (System.IntPtr value) { throw null; }
        public static explicit operator long (System.IntPtr value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public unsafe static explicit operator void* (System.IntPtr value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public unsafe static explicit operator System.IntPtr (void* value) { throw null; }
        public static bool operator !=(System.IntPtr value1, System.IntPtr value2) { throw null; }
        public static System.IntPtr operator -(System.IntPtr pointer, int offset) { throw null; }
        public static System.IntPtr Subtract(System.IntPtr pointer, int offset) { throw null; }
        bool System.IEquatable<System.IntPtr>.Equals(System.IntPtr other) { throw null; }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public int ToInt32() { throw null; }
        public long ToInt64() { throw null; }
        [System.CLSCompliantAttribute(false)]
        public unsafe void* ToPointer() { throw null; }
        public override string ToString() { throw null; }
        public string ToString(string format) { throw null; }
    }
    public partial class InvalidCastException : System.SystemException
    {
        public InvalidCastException() { }
        protected InvalidCastException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public InvalidCastException(string message) { }
        public InvalidCastException(string message, System.Exception innerException) { }
        public InvalidCastException(string message, int errorCode) { }
    }
    public partial class InvalidOperationException : System.SystemException
    {
        public InvalidOperationException() { }
        protected InvalidOperationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public InvalidOperationException(string message) { }
        public InvalidOperationException(string message, System.Exception innerException) { }
    }
    public sealed partial class InvalidProgramException : System.SystemException
    {
        public InvalidProgramException() { }
        public InvalidProgramException(string message) { }
        public InvalidProgramException(string message, System.Exception inner) { }
    }
    public partial class InvalidTimeZoneException : System.Exception
    {
        public InvalidTimeZoneException() { }
        protected InvalidTimeZoneException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public InvalidTimeZoneException(string message) { }
        public InvalidTimeZoneException(string message, System.Exception innerException) { }
    }
    public partial interface IObservable<out T>
    {
        System.IDisposable Subscribe(System.IObserver<T> observer);
    }
    public partial interface IObserver<in T>
    {
        void OnCompleted();
        void OnError(System.Exception error);
        void OnNext(T value);
    }
    public partial interface IProgress<in T>
    {
        void Report(T value);
    }
    public partial interface IServiceProvider
    {
        object GetService(System.Type serviceType);
    }
    public partial class Lazy<T>
    {
        public Lazy() { }
        public Lazy(bool isThreadSafe) { }
        public Lazy(System.Func<T> valueFactory) { }
        public Lazy(System.Func<T> valueFactory, bool isThreadSafe) { }
        public Lazy(System.Func<T> valueFactory, System.Threading.LazyThreadSafetyMode mode) { }
        public Lazy(System.Threading.LazyThreadSafetyMode mode) { }
        public Lazy(T value) { }
        public bool IsValueCreated { get { throw null; } }
        public T Value { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public partial class Lazy<T, TMetadata> : System.Lazy<T>
    {
        public Lazy(System.Func<T> valueFactory, TMetadata metadata) { }
        public Lazy(System.Func<T> valueFactory, TMetadata metadata, bool isThreadSafe) { }
        public Lazy(System.Func<T> valueFactory, TMetadata metadata, System.Threading.LazyThreadSafetyMode mode) { }
        public Lazy(TMetadata metadata) { }
        public Lazy(TMetadata metadata, bool isThreadSafe) { }
        public Lazy(TMetadata metadata, System.Threading.LazyThreadSafetyMode mode) { }
        public TMetadata Metadata { get { throw null; } }
    }
    public partial class LdapStyleUriParser : System.UriParser
    {
        public LdapStyleUriParser() { }
    }
    public enum LoaderOptimization
    {
        [System.ObsoleteAttribute("This method has been deprecated. Please use Assembly.Load() instead. https://go.microsoft.com/fwlink/?linkid=14202")]
        DisallowBindings = 4,
        [System.ObsoleteAttribute("This method has been deprecated. Please use Assembly.Load() instead. https://go.microsoft.com/fwlink/?linkid=14202")]
        DomainMask = 3,
        MultiDomain = 2,
        MultiDomainHost = 3,
        NotSpecified = 0,
        SingleDomain = 1,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method)]
    public sealed partial class LoaderOptimizationAttribute : System.Attribute
    {
        public LoaderOptimizationAttribute(byte value) { }
        public LoaderOptimizationAttribute(System.LoaderOptimization value) { }
        public System.LoaderOptimization Value { get { throw null; } }
    }
    public sealed partial class LocalDataStoreSlot
    {
        internal LocalDataStoreSlot() { }
    }
    public abstract partial class MarshalByRefObject
    {
        protected MarshalByRefObject() { }
//REMOTING        public virtual System.Runtime.Remoting.ObjRef CreateObjRef(System.Type requestedType) { throw null; }
        public object GetLifetimeService() { throw null; }
        public virtual object InitializeLifetimeService() { throw null; }
        protected System.MarshalByRefObject MemberwiseClone(bool cloneIdentity) { throw null; }
    }
    public static partial class Math
    {
        public const double E = 2.7182818284590451;
        public const double PI = 3.1415926535897931;
        public static decimal Abs(decimal value) { throw null; }
        public static double Abs(double value) { throw null; }
        public static short Abs(short value) { throw null; }
        public static int Abs(int value) { throw null; }
        public static long Abs(long value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static sbyte Abs(sbyte value) { throw null; }
        public static float Abs(float value) { throw null; }
        public static double Acos(double d) { throw null; }
        public static double Acosh(double d) { throw null; }
        public static double Asin(double d) { throw null; }
        public static double Asinh(double d) { throw null; }
        public static double Atan(double d) { throw null; }
        public static double Atan2(double y, double x) { throw null; }
        public static double Atanh(double d) { throw null; }
        public static long BigMul(int a, int b) { throw null; }
        public static double Cbrt(double d) { throw null; }
        public static decimal Ceiling(decimal d) { throw null; }
        public static double Ceiling(double a) { throw null; }
        public static byte Clamp(byte value, byte min, byte max) { throw null; }
        public static decimal Clamp(decimal value, decimal min, decimal max) { throw null; }
        public static double Clamp(double value, double min, double max) { throw null; }
        public static short Clamp(short value, short min, short max) { throw null; }
        public static int Clamp(int value, int min, int max) { throw null; }
        public static long Clamp(long value, long min, long max) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static sbyte Clamp(sbyte value, sbyte min, sbyte max) { throw null; }
        public static float Clamp(float value, float min, float max) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ushort Clamp(ushort value, ushort min, ushort max) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static uint Clamp(uint value, uint min, uint max) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ulong Clamp(ulong value, ulong min, ulong max) { throw null; }
        public static double Cos(double d) { throw null; }
        public static double Cosh(double value) { throw null; }
        public static int DivRem(int a, int b, out int result) { throw null; }
        public static long DivRem(long a, long b, out long result) { throw null; }
        public static double Exp(double d) { throw null; }
        public static decimal Floor(decimal d) { throw null; }
        public static double Floor(double d) { throw null; }
        public static double IEEERemainder(double x, double y) { throw null; }
        public static double Log(double d) { throw null; }
        public static double Log(double a, double newBase) { throw null; }
        public static double Log10(double d) { throw null; }
        public static byte Max(byte val1, byte val2) { throw null; }
        public static decimal Max(decimal val1, decimal val2) { throw null; }
        public static double Max(double val1, double val2) { throw null; }
        public static short Max(short val1, short val2) { throw null; }
        public static int Max(int val1, int val2) { throw null; }
        public static long Max(long val1, long val2) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static sbyte Max(sbyte val1, sbyte val2) { throw null; }
        public static float Max(float val1, float val2) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ushort Max(ushort val1, ushort val2) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static uint Max(uint val1, uint val2) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ulong Max(ulong val1, ulong val2) { throw null; }
        public static byte Min(byte val1, byte val2) { throw null; }
        public static decimal Min(decimal val1, decimal val2) { throw null; }
        public static double Min(double val1, double val2) { throw null; }
        public static short Min(short val1, short val2) { throw null; }
        public static int Min(int val1, int val2) { throw null; }
        public static long Min(long val1, long val2) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static sbyte Min(sbyte val1, sbyte val2) { throw null; }
        public static float Min(float val1, float val2) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ushort Min(ushort val1, ushort val2) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static uint Min(uint val1, uint val2) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ulong Min(ulong val1, ulong val2) { throw null; }
        public static double Pow(double x, double y) { throw null; }
        public static decimal Round(decimal d) { throw null; }
        public static decimal Round(decimal d, int decimals) { throw null; }
        public static decimal Round(decimal d, int decimals, System.MidpointRounding mode) { throw null; }
        public static decimal Round(decimal d, System.MidpointRounding mode) { throw null; }
        public static double Round(double a) { throw null; }
        public static double Round(double value, int digits) { throw null; }
        public static double Round(double value, int digits, System.MidpointRounding mode) { throw null; }
        public static double Round(double value, System.MidpointRounding mode) { throw null; }
        public static int Sign(decimal value) { throw null; }
        public static int Sign(double value) { throw null; }
        public static int Sign(short value) { throw null; }
        public static int Sign(int value) { throw null; }
        public static int Sign(long value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static int Sign(sbyte value) { throw null; }
        public static int Sign(float value) { throw null; }
        public static double Sin(double a) { throw null; }
        public static double Sinh(double value) { throw null; }
        public static double Sqrt(double d) { throw null; }
        public static double Tan(double a) { throw null; }
        public static double Tanh(double value) { throw null; }
        public static decimal Truncate(decimal d) { throw null; }
        public static double Truncate(double d) { throw null; }
    }
    public static partial class MathF
    {
        public const float E = 2.71828175f;
        public const float PI = 3.14159274f;
        public static float Abs(float x) { throw null; }
        public static float Acos(float x) { throw null; }
        public static float Acosh(float x) { throw null; }
        public static float Asin(float x) { throw null; }
        public static float Asinh(float x) { throw null; }
        public static float Atan(float x) { throw null; }
        public static float Atan2(float y, float x) { throw null; }
        public static float Atanh(float x) { throw null; }
        public static float Cbrt(float x) { throw null; }
        public static float Ceiling(float x) { throw null; }
        public static float Cos(float x) { throw null; }
        public static float Cosh(float x) { throw null; }
        public static float Exp(float x) { throw null; }
        public static float Floor(float x) { throw null; }
        public static float IEEERemainder(float x, float y) { throw null; }
        public static float Log(float x) { throw null; }
        public static float Log(float x, float y) { throw null; }
        public static float Log10(float x) { throw null; }
        public static float Max(float x, float y) { throw null; }
        public static float Min(float x, float y) { throw null; }
        public static float Pow(float x, float y) { throw null; }
        public static float Round(float x) { throw null; }
        public static float Round(float x, int digits) { throw null; }
        public static float Round(float x, int digits, System.MidpointRounding mode) { throw null; }
        public static float Round(float x, System.MidpointRounding mode) { throw null; }
        public static int Sign(float x) { throw null; }
        public static float Sin(float x) { throw null; }
        public static float Sinh(float x) { throw null; }
        public static float Sqrt(float x) { throw null; }
        public static float Tan(float x) { throw null; }
        public static float Tanh(float x) { throw null; }
        public static float Truncate(float x) { throw null; }
    }
    public partial class MemberAccessException : System.SystemException
    {
        public MemberAccessException() { }
        protected MemberAccessException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public MemberAccessException(string message) { }
        public MemberAccessException(string message, System.Exception inner) { }
    }
    public readonly partial struct Memory<T> : System.IEquatable<System.Memory<T>>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public Memory(T[] array) { throw null; }
        public Memory(T[] array, int start, int length) { throw null; }
        public static System.Memory<T> Empty { get { throw null; } }
        public bool IsEmpty { get { throw null; } }
        public int Length { get { throw null; } }
        public System.Span<T> Span { get { throw null; } }
        public void CopyTo(System.Memory<T> destination) { }
        public bool Equals(System.Memory<T> other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static implicit operator System.Memory<T> (System.ArraySegment<T> segment) { throw null; }
        public static implicit operator System.ReadOnlyMemory<T> (System.Memory<T> memory) { throw null; }
        public static implicit operator System.Memory<T> (T[] array) { throw null; }
        public System.Buffers.MemoryHandle Pin() { throw null; }
        public System.Memory<T> Slice(int start) { throw null; }
        public System.Memory<T> Slice(int start, int length) { throw null; }
        public T[] ToArray() { throw null; }
        public override string ToString() { throw null; }
        public bool TryCopyTo(System.Memory<T> destination) { throw null; }
    }
    public static partial class MemoryExtensions
    {
        public static System.ReadOnlyMemory<char> AsMemory(this string text) { throw null; }
        public static System.ReadOnlyMemory<char> AsMemory(this string text, System.Index startIndex) { throw null; }
        public static System.ReadOnlyMemory<char> AsMemory(this string text, int start) { throw null; }
        public static System.ReadOnlyMemory<char> AsMemory(this string text, int start, int length) { throw null; }
        public static System.ReadOnlyMemory<char> AsMemory(this string text, System.Range range) { throw null; }
        public static System.Memory<T> AsMemory<T>(this System.ArraySegment<T> segment) { throw null; }
        public static System.Memory<T> AsMemory<T>(this System.ArraySegment<T> segment, int start) { throw null; }
        public static System.Memory<T> AsMemory<T>(this System.ArraySegment<T> segment, int start, int length) { throw null; }
        public static System.Memory<T> AsMemory<T>(this T[] array) { throw null; }
        public static System.Memory<T> AsMemory<T>(this T[] array, System.Index startIndex) { throw null; }
        public static System.Memory<T> AsMemory<T>(this T[] array, int start) { throw null; }
        public static System.Memory<T> AsMemory<T>(this T[] array, int start, int length) { throw null; }
        public static System.Memory<T> AsMemory<T>(this T[] array, System.Range range) { throw null; }
        public static System.ReadOnlySpan<char> AsSpan(this string text) { throw null; }
        public static System.ReadOnlySpan<char> AsSpan(this string text, int start) { throw null; }
        public static System.ReadOnlySpan<char> AsSpan(this string text, int start, int length) { throw null; }
        public static System.Span<T> AsSpan<T>(this System.ArraySegment<T> segment) { throw null; }
        public static System.Span<T> AsSpan<T>(this System.ArraySegment<T> segment, System.Index startIndex) { throw null; }
        public static System.Span<T> AsSpan<T>(this System.ArraySegment<T> segment, int start) { throw null; }
        public static System.Span<T> AsSpan<T>(this System.ArraySegment<T> segment, int start, int length) { throw null; }
        public static System.Span<T> AsSpan<T>(this System.ArraySegment<T> segment, System.Range range) { throw null; }
        public static System.Span<T> AsSpan<T>(this T[] array) { throw null; }
        public static System.Span<T> AsSpan<T>(this T[] array, System.Index startIndex) { throw null; }
        public static System.Span<T> AsSpan<T>(this T[] array, int start) { throw null; }
        public static System.Span<T> AsSpan<T>(this T[] array, int start, int length) { throw null; }
        public static System.Span<T> AsSpan<T>(this T[] array, System.Range range) { throw null; }
        public static int BinarySearch<T>(this System.ReadOnlySpan<T> span, System.IComparable<T> comparable) { throw null; }
        public static int BinarySearch<T>(this System.Span<T> span, System.IComparable<T> comparable) { throw null; }
        public static int BinarySearch<T, TComparer>(this System.ReadOnlySpan<T> span, T value, TComparer comparer) where TComparer : System.Collections.Generic.IComparer<T> { throw null; }
        public static int BinarySearch<T, TComparable>(this System.ReadOnlySpan<T> span, TComparable comparable) where TComparable : System.IComparable<T> { throw null; }
        public static int BinarySearch<T, TComparer>(this System.Span<T> span, T value, TComparer comparer) where TComparer : System.Collections.Generic.IComparer<T> { throw null; }
        public static int BinarySearch<T, TComparable>(this System.Span<T> span, TComparable comparable) where TComparable : System.IComparable<T> { throw null; }
        public static int CompareTo(this System.ReadOnlySpan<char> span, System.ReadOnlySpan<char> other, System.StringComparison comparisonType) { throw null; }
        public static bool Contains(this System.ReadOnlySpan<char> span, System.ReadOnlySpan<char> value, System.StringComparison comparisonType) { throw null; }
        public static void CopyTo<T>(this T[] source, System.Memory<T> destination) { }
        public static void CopyTo<T>(this T[] source, System.Span<T> destination) { }
        public static bool EndsWith(this System.ReadOnlySpan<char> span, System.ReadOnlySpan<char> value, System.StringComparison comparisonType) { throw null; }
        public static bool EndsWith<T>(this System.ReadOnlySpan<T> span, System.ReadOnlySpan<T> value) where T : System.IEquatable<T> { throw null; }
        public static bool EndsWith<T>(this System.Span<T> span, System.ReadOnlySpan<T> value) where T : System.IEquatable<T> { throw null; }
        public static bool Equals(this System.ReadOnlySpan<char> span, System.ReadOnlySpan<char> other, System.StringComparison comparisonType) { throw null; }
        public static int IndexOf(this System.ReadOnlySpan<char> span, System.ReadOnlySpan<char> value, System.StringComparison comparisonType) { throw null; }
        public static int IndexOfAny<T>(this System.ReadOnlySpan<T> span, System.ReadOnlySpan<T> values) where T : System.IEquatable<T> { throw null; }
        public static int IndexOfAny<T>(this System.ReadOnlySpan<T> span, T value0, T value1) where T : System.IEquatable<T> { throw null; }
        public static int IndexOfAny<T>(this System.ReadOnlySpan<T> span, T value0, T value1, T value2) where T : System.IEquatable<T> { throw null; }
        public static int IndexOfAny<T>(this System.Span<T> span, System.ReadOnlySpan<T> values) where T : System.IEquatable<T> { throw null; }
        public static int IndexOfAny<T>(this System.Span<T> span, T value0, T value1) where T : System.IEquatable<T> { throw null; }
        public static int IndexOfAny<T>(this System.Span<T> span, T value0, T value1, T value2) where T : System.IEquatable<T> { throw null; }
        public static int IndexOf<T>(this System.ReadOnlySpan<T> span, System.ReadOnlySpan<T> value) where T : System.IEquatable<T> { throw null; }
        public static int IndexOf<T>(this System.ReadOnlySpan<T> span, T value) where T : System.IEquatable<T> { throw null; }
        public static int IndexOf<T>(this System.Span<T> span, System.ReadOnlySpan<T> value) where T : System.IEquatable<T> { throw null; }
        public static int IndexOf<T>(this System.Span<T> span, T value) where T : System.IEquatable<T> { throw null; }
        public static bool IsWhiteSpace(this System.ReadOnlySpan<char> span) { throw null; }
        public static int LastIndexOfAny<T>(this System.ReadOnlySpan<T> span, System.ReadOnlySpan<T> values) where T : System.IEquatable<T> { throw null; }
        public static int LastIndexOfAny<T>(this System.ReadOnlySpan<T> span, T value0, T value1) where T : System.IEquatable<T> { throw null; }
        public static int LastIndexOfAny<T>(this System.ReadOnlySpan<T> span, T value0, T value1, T value2) where T : System.IEquatable<T> { throw null; }
        public static int LastIndexOfAny<T>(this System.Span<T> span, System.ReadOnlySpan<T> values) where T : System.IEquatable<T> { throw null; }
        public static int LastIndexOfAny<T>(this System.Span<T> span, T value0, T value1) where T : System.IEquatable<T> { throw null; }
        public static int LastIndexOfAny<T>(this System.Span<T> span, T value0, T value1, T value2) where T : System.IEquatable<T> { throw null; }
        public static int LastIndexOf<T>(this System.ReadOnlySpan<T> span, System.ReadOnlySpan<T> value) where T : System.IEquatable<T> { throw null; }
        public static int LastIndexOf<T>(this System.ReadOnlySpan<T> span, T value) where T : System.IEquatable<T> { throw null; }
        public static int LastIndexOf<T>(this System.Span<T> span, System.ReadOnlySpan<T> value) where T : System.IEquatable<T> { throw null; }
        public static int LastIndexOf<T>(this System.Span<T> span, T value) where T : System.IEquatable<T> { throw null; }
        public static bool Overlaps<T>(this System.ReadOnlySpan<T> span, System.ReadOnlySpan<T> other) { throw null; }
        public static bool Overlaps<T>(this System.ReadOnlySpan<T> span, System.ReadOnlySpan<T> other, out int elementOffset) { throw null; }
        public static bool Overlaps<T>(this System.Span<T> span, System.ReadOnlySpan<T> other) { throw null; }
        public static bool Overlaps<T>(this System.Span<T> span, System.ReadOnlySpan<T> other, out int elementOffset) { throw null; }
        public static void Reverse<T>(this System.Span<T> span) { }
        public static int SequenceCompareTo<T>(this System.ReadOnlySpan<T> span, System.ReadOnlySpan<T> other) where T : System.IComparable<T> { throw null; }
        public static int SequenceCompareTo<T>(this System.Span<T> span, System.ReadOnlySpan<T> other) where T : System.IComparable<T> { throw null; }
        public static bool SequenceEqual<T>(this System.ReadOnlySpan<T> span, System.ReadOnlySpan<T> other) where T : System.IEquatable<T> { throw null; }
        public static bool SequenceEqual<T>(this System.Span<T> span, System.ReadOnlySpan<T> other) where T : System.IEquatable<T> { throw null; }
        public static bool StartsWith(this System.ReadOnlySpan<char> span, System.ReadOnlySpan<char> value, System.StringComparison comparisonType) { throw null; }
        public static bool StartsWith<T>(this System.ReadOnlySpan<T> span, System.ReadOnlySpan<T> value) where T : System.IEquatable<T> { throw null; }
        public static bool StartsWith<T>(this System.Span<T> span, System.ReadOnlySpan<T> value) where T : System.IEquatable<T> { throw null; }
        public static int ToLower(this System.ReadOnlySpan<char> source, System.Span<char> destination, System.Globalization.CultureInfo culture) { throw null; }
        public static int ToLowerInvariant(this System.ReadOnlySpan<char> source, System.Span<char> destination) { throw null; }
        public static int ToUpper(this System.ReadOnlySpan<char> source, System.Span<char> destination, System.Globalization.CultureInfo culture) { throw null; }
        public static int ToUpperInvariant(this System.ReadOnlySpan<char> source, System.Span<char> destination) { throw null; }
        public static System.ReadOnlySpan<char> Trim(this System.ReadOnlySpan<char> span) { throw null; }
        public static System.ReadOnlySpan<char> Trim(this System.ReadOnlySpan<char> span, char trimChar) { throw null; }
        public static System.ReadOnlySpan<char> Trim(this System.ReadOnlySpan<char> span, System.ReadOnlySpan<char> trimChars) { throw null; }
        public static System.ReadOnlySpan<char> TrimEnd(this System.ReadOnlySpan<char> span) { throw null; }
        public static System.ReadOnlySpan<char> TrimEnd(this System.ReadOnlySpan<char> span, char trimChar) { throw null; }
        public static System.ReadOnlySpan<char> TrimEnd(this System.ReadOnlySpan<char> span, System.ReadOnlySpan<char> trimChars) { throw null; }
        public static System.ReadOnlySpan<char> TrimStart(this System.ReadOnlySpan<char> span) { throw null; }
        public static System.ReadOnlySpan<char> TrimStart(this System.ReadOnlySpan<char> span, char trimChar) { throw null; }
        public static System.ReadOnlySpan<char> TrimStart(this System.ReadOnlySpan<char> span, System.ReadOnlySpan<char> trimChars) { throw null; }
    }
    public partial class MethodAccessException : System.MemberAccessException
    {
        public MethodAccessException() { }
        protected MethodAccessException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public MethodAccessException(string message) { }
        public MethodAccessException(string message, System.Exception inner) { }
    }
    public enum MidpointRounding
    {
        AwayFromZero = 1,
        ToEven = 0,
    }
    public partial class MissingFieldException : System.MissingMemberException, System.Runtime.Serialization.ISerializable
    {
        public MissingFieldException() { }
        protected MissingFieldException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public MissingFieldException(string message) { }
        public MissingFieldException(string message, System.Exception inner) { }
        public MissingFieldException(string className, string fieldName) { }
        public override string Message { get { throw null; } }
    }
    public partial class MissingMemberException : System.MemberAccessException, System.Runtime.Serialization.ISerializable
    {
        protected string ClassName;
        protected string MemberName;
        protected byte[] Signature;
        public MissingMemberException() { }
        protected MissingMemberException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public MissingMemberException(string message) { }
        public MissingMemberException(string message, System.Exception inner) { }
        public MissingMemberException(string className, string memberName) { }
        public override string Message { get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public partial class MissingMethodException : System.MissingMemberException
    {
        public MissingMethodException() { }
        protected MissingMethodException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public MissingMethodException(string message) { }
        public MissingMethodException(string message, System.Exception inner) { }
        public MissingMethodException(string className, string methodName) { }
        public override string Message { get { throw null; } }
    }
    public partial struct ModuleHandle
    {
        private object _dummy;
        public static readonly System.ModuleHandle EmptyHandle;
        public int MDStreamVersion { get { throw null; } }
        public bool Equals(System.ModuleHandle handle) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public System.RuntimeFieldHandle GetRuntimeFieldHandleFromMetadataToken(int fieldToken) { throw null; }
        public System.RuntimeMethodHandle GetRuntimeMethodHandleFromMetadataToken(int methodToken) { throw null; }
        public System.RuntimeTypeHandle GetRuntimeTypeHandleFromMetadataToken(int typeToken) { throw null; }
        public static bool operator ==(System.ModuleHandle left, System.ModuleHandle right) { throw null; }
        public static bool operator !=(System.ModuleHandle left, System.ModuleHandle right) { throw null; }
        public System.RuntimeFieldHandle ResolveFieldHandle(int fieldToken) { throw null; }
        public System.RuntimeFieldHandle ResolveFieldHandle(int fieldToken, System.RuntimeTypeHandle[] typeInstantiationContext, System.RuntimeTypeHandle[] methodInstantiationContext) { throw null; }
        public System.RuntimeMethodHandle ResolveMethodHandle(int methodToken) { throw null; }
        public System.RuntimeMethodHandle ResolveMethodHandle(int methodToken, System.RuntimeTypeHandle[] typeInstantiationContext, System.RuntimeTypeHandle[] methodInstantiationContext) { throw null; }
        public System.RuntimeTypeHandle ResolveTypeHandle(int typeToken) { throw null; }
        public System.RuntimeTypeHandle ResolveTypeHandle(int typeToken, System.RuntimeTypeHandle[] typeInstantiationContext, System.RuntimeTypeHandle[] methodInstantiationContext) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method)]
    public sealed partial class MTAThreadAttribute : System.Attribute
    {
        public MTAThreadAttribute() { }
    }
    public abstract partial class MulticastDelegate : System.Delegate
    {
        protected MulticastDelegate(object target, string method) : base (default(object), default(string)) { }
        protected MulticastDelegate(System.Type target, string method) : base (default(object), default(string)) { }
        protected sealed override System.Delegate CombineImpl(System.Delegate follow) { throw null; }
        public sealed override bool Equals(object obj) { throw null; }
        public sealed override int GetHashCode() { throw null; }
        public sealed override System.Delegate[] GetInvocationList() { throw null; }
        protected override System.Reflection.MethodInfo GetMethodImpl() { throw null; }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public static bool operator ==(System.MulticastDelegate d1, System.MulticastDelegate d2) { throw null; }
        public static bool operator !=(System.MulticastDelegate d1, System.MulticastDelegate d2) { throw null; }
        protected sealed override System.Delegate RemoveImpl(System.Delegate value) { throw null; }
    }
    public sealed partial class MulticastNotSupportedException : System.SystemException
    {
        public MulticastNotSupportedException() { }
        public MulticastNotSupportedException(string message) { }
        public MulticastNotSupportedException(string message, System.Exception inner) { }
    }
    public partial class NetPipeStyleUriParser : System.UriParser
    {
        public NetPipeStyleUriParser() { }
    }
    public partial class NetTcpStyleUriParser : System.UriParser
    {
        public NetTcpStyleUriParser() { }
    }
    public partial class NewsStyleUriParser : System.UriParser
    {
        public NewsStyleUriParser() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Field, Inherited=false)]
    public sealed partial class NonSerializedAttribute : System.Attribute
    {
        public NonSerializedAttribute() { }
    }
    public partial class NotFiniteNumberException : System.ArithmeticException
    {
        public NotFiniteNumberException() { }
        public NotFiniteNumberException(double offendingNumber) { }
        protected NotFiniteNumberException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public NotFiniteNumberException(string message) { }
        public NotFiniteNumberException(string message, double offendingNumber) { }
        public NotFiniteNumberException(string message, double offendingNumber, System.Exception innerException) { }
        public NotFiniteNumberException(string message, System.Exception innerException) { }
        public double OffendingNumber { get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public partial class NotImplementedException : System.SystemException
    {
        public NotImplementedException() { }
        protected NotImplementedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public NotImplementedException(string message) { }
        public NotImplementedException(string message, System.Exception inner) { }
    }
    public partial class NotSupportedException : System.SystemException
    {
        public NotSupportedException() { }
        protected NotSupportedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public NotSupportedException(string message) { }
        public NotSupportedException(string message, System.Exception innerException) { }
    }
    public static partial class Nullable
    {
        public static int Compare<T>(System.Nullable<T> n1, System.Nullable<T> n2) where T : struct { throw null; }
        public static bool Equals<T>(System.Nullable<T> n1, System.Nullable<T> n2) where T : struct { throw null; }
        public static System.Type GetUnderlyingType(System.Type nullableType) { throw null; }
    }
    public partial struct Nullable<T> where T : struct
    {
        internal T value;
        private int _dummyPrimitive;
        public Nullable(T value) { throw null; }
        public bool HasValue { get { throw null; } }
        public T Value { get { throw null; } }
        public override bool Equals(object other) { throw null; }
        public override int GetHashCode() { throw null; }
        public T GetValueOrDefault() { throw null; }
        public T GetValueOrDefault(T defaultValue) { throw null; }
        public static explicit operator T (System.Nullable<T> value) { throw null; }
        public static implicit operator System.Nullable<T> (T value) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class NullReferenceException : System.SystemException
    {
        public NullReferenceException() { }
        protected NullReferenceException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public NullReferenceException(string message) { }
        public NullReferenceException(string message, System.Exception innerException) { }
    }
    public partial class Object
    {
        public Object() { }
        public virtual bool Equals(System.Object obj) { throw null; }
        public static bool Equals(System.Object objA, System.Object objB) { throw null; }
        ~Object() { }
        public virtual int GetHashCode() { throw null; }
        public System.Type GetType() { throw null; }
        protected System.Object MemberwiseClone() { throw null; }
        public static bool ReferenceEquals(System.Object objA, System.Object objB) { throw null; }
        public virtual string ToString() { throw null; }
    }
    public partial class ObjectDisposedException : System.InvalidOperationException
    {
        protected ObjectDisposedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public ObjectDisposedException(string objectName) { }
        public ObjectDisposedException(string message, System.Exception innerException) { }
        public ObjectDisposedException(string objectName, string message) { }
        public override string Message { get { throw null; } }
        public string ObjectName { get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Constructor | System.AttributeTargets.Delegate | System.AttributeTargets.Enum | System.AttributeTargets.Event | System.AttributeTargets.Field | System.AttributeTargets.Interface | System.AttributeTargets.Method | System.AttributeTargets.Property | System.AttributeTargets.Struct, Inherited=false)]
    public sealed partial class ObsoleteAttribute : System.Attribute
    {
        public ObsoleteAttribute() { }
        public ObsoleteAttribute(string message) { }
        public ObsoleteAttribute(string message, bool error) { }
        public bool IsError { get { throw null; } }
        public string Message { get { throw null; } }
    }
    public sealed partial class OperatingSystem : System.ICloneable, System.Runtime.Serialization.ISerializable
    {
        public OperatingSystem(System.PlatformID platform, System.Version version) { }
        public System.PlatformID Platform { get { throw null; } }
        public string ServicePack { get { throw null; } }
        public System.Version Version { get { throw null; } }
        public string VersionString { get { throw null; } }
        public object Clone() { throw null; }
        public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public override string ToString() { throw null; }
    }
    public partial class OperationCanceledException : System.SystemException
    {
        public OperationCanceledException() { }
        protected OperationCanceledException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public OperationCanceledException(string message) { }
        public OperationCanceledException(string message, System.Exception innerException) { }
        public OperationCanceledException(string message, System.Exception innerException, System.Threading.CancellationToken token) { }
        public OperationCanceledException(string message, System.Threading.CancellationToken token) { }
        public OperationCanceledException(System.Threading.CancellationToken token) { }
        public System.Threading.CancellationToken CancellationToken { get { throw null; } }
    }
    public partial class OutOfMemoryException : System.SystemException
    {
        public OutOfMemoryException() { }
        protected OutOfMemoryException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public OutOfMemoryException(string message) { }
        public OutOfMemoryException(string message, System.Exception innerException) { }
    }
    public partial class OverflowException : System.ArithmeticException
    {
        public OverflowException() { }
        protected OverflowException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public OverflowException(string message) { }
        public OverflowException(string message, System.Exception innerException) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter, Inherited=true, AllowMultiple=false)]
    public sealed partial class ParamArrayAttribute : System.Attribute
    {
        public ParamArrayAttribute() { }
    }
    public enum PlatformID
    {
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        MacOSX = 6,
        Unix = 4,
        Win32NT = 2,
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        Win32S = 0,
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        Win32Windows = 1,
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        WinCE = 3,
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        Xbox = 5,
    }
    public partial class PlatformNotSupportedException : System.NotSupportedException
    {
        public PlatformNotSupportedException() { }
        protected PlatformNotSupportedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public PlatformNotSupportedException(string message) { }
        public PlatformNotSupportedException(string message, System.Exception inner) { }
    }
    public delegate bool Predicate<in T>(T obj);
    public partial class Progress<T> : System.IProgress<T>
    {
        public Progress() { }
        public Progress(System.Action<T> handler) { }
        public event System.EventHandler<T> ProgressChanged { add { } remove { } }
        protected virtual void OnReport(T value) { }
        void System.IProgress<T>.Report(T value) { }
    }
    public partial class Random
    {
        public Random() { }
        public Random(int Seed) { }
        public virtual int Next() { throw null; }
        public virtual int Next(int maxValue) { throw null; }
        public virtual int Next(int minValue, int maxValue) { throw null; }
        public virtual void NextBytes(byte[] buffer) { }
        public virtual void NextBytes(System.Span<byte> buffer) { }
        public virtual double NextDouble() { throw null; }
        protected virtual double Sample() { throw null; }
    }
    public readonly partial struct Range : System.IEquatable<System.Range>
    {
        private readonly int _dummyPrimitive;
        public Range(System.Index start, System.Index end) { throw null; }
        public static System.Range All { get { throw null; } }
        public System.Index End { get { throw null; } }
        public System.Index Start { get { throw null; } }
        public static System.Range EndAt(System.Index end) { throw null; }
        public override bool Equals(object value) { throw null; }
        public bool Equals(System.Range other) { throw null; }
        public override int GetHashCode() { throw null; }
        public (int Offset, int Length) GetOffsetAndLength(int length) { throw null; }
        public static System.Range StartAt(System.Index start) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class RankException : System.SystemException
    {
        public RankException() { }
        protected RankException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public RankException(string message) { }
        public RankException(string message, System.Exception innerException) { }
    }
    public readonly partial struct ReadOnlyMemory<T> : System.IEquatable<System.ReadOnlyMemory<T>>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ReadOnlyMemory(T[] array) { throw null; }
        public ReadOnlyMemory(T[] array, int start, int length) { throw null; }
        public static System.ReadOnlyMemory<T> Empty { get { throw null; } }
        public bool IsEmpty { get { throw null; } }
        public int Length { get { throw null; } }
        public System.ReadOnlySpan<T> Span { get { throw null; } }
        public void CopyTo(System.Memory<T> destination) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.ReadOnlyMemory<T> other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static implicit operator System.ReadOnlyMemory<T> (System.ArraySegment<T> segment) { throw null; }
        public static implicit operator System.ReadOnlyMemory<T> (T[] array) { throw null; }
        public System.Buffers.MemoryHandle Pin() { throw null; }
        public System.ReadOnlyMemory<T> Slice(int start) { throw null; }
        public System.ReadOnlyMemory<T> Slice(int start, int length) { throw null; }
        public T[] ToArray() { throw null; }
        public override string ToString() { throw null; }
        public bool TryCopyTo(System.Memory<T> destination) { throw null; }
    }
    public readonly ref partial struct ReadOnlySpan<T>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        [System.CLSCompliantAttribute(false)]
        public unsafe ReadOnlySpan(void* pointer, int length) { throw null; }
        public ReadOnlySpan(T[] array) { throw null; }
        public ReadOnlySpan(T[] array, int start, int length) { throw null; }
        public static System.ReadOnlySpan<T> Empty { get { throw null; } }
        public bool IsEmpty { get { throw null; } }
        public ref readonly T this[int index] { get { throw null; } }
        public int Length { get { throw null; } }
        public void CopyTo(System.Span<T> destination) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("Equals() on ReadOnlySpan will always throw an exception. Use == instead.")]
        public override bool Equals(object obj) { throw null; }
        public System.ReadOnlySpan<T>.Enumerator GetEnumerator() { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("GetHashCode() on ReadOnlySpan will always throw an exception.")]
        public override int GetHashCode() { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public ref readonly T GetPinnableReference() { throw null; }
        public static bool operator ==(System.ReadOnlySpan<T> left, System.ReadOnlySpan<T> right) { throw null; }
        public static implicit operator System.ReadOnlySpan<T> (System.ArraySegment<T> segment) { throw null; }
        public static implicit operator System.ReadOnlySpan<T> (T[] array) { throw null; }
        public static bool operator !=(System.ReadOnlySpan<T> left, System.ReadOnlySpan<T> right) { throw null; }
        public System.ReadOnlySpan<T> Slice(int start) { throw null; }
        public System.ReadOnlySpan<T> Slice(int start, int length) { throw null; }
        public T[] ToArray() { throw null; }
        public override string ToString() { throw null; }
        public bool TryCopyTo(System.Span<T> destination) { throw null; }
        public ref partial struct Enumerator
        {
            private object _dummy;
            private int _dummyPrimitive;
            public ref readonly T Current { get { throw null; } }
            public bool MoveNext() { throw null; }
        }
    }
    public partial class ResolveEventArgs : System.EventArgs
    {
        public ResolveEventArgs(string name) { }
        public ResolveEventArgs(string name, System.Reflection.Assembly requestingAssembly) { }
        public string Name { get { throw null; } }
        public System.Reflection.Assembly RequestingAssembly { get { throw null; } }
    }
    public delegate System.Reflection.Assembly ResolveEventHandler(object sender, System.ResolveEventArgs args);
    public ref partial struct RuntimeArgumentHandle
    {
        private int _dummyPrimitive;
    }
    public partial struct RuntimeFieldHandle : System.Runtime.Serialization.ISerializable
    {
        private object _dummy;
        public System.IntPtr Value { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.RuntimeFieldHandle handle) { throw null; }
        public override int GetHashCode() { throw null; }
        public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public static bool operator ==(System.RuntimeFieldHandle left, System.RuntimeFieldHandle right) { throw null; }
        public static bool operator !=(System.RuntimeFieldHandle left, System.RuntimeFieldHandle right) { throw null; }
    }
    public partial struct RuntimeMethodHandle : System.Runtime.Serialization.ISerializable
    {
        private object _dummy;
        public System.IntPtr Value { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.RuntimeMethodHandle handle) { throw null; }
        public System.IntPtr GetFunctionPointer() { throw null; }
        public override int GetHashCode() { throw null; }
        public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public static bool operator ==(System.RuntimeMethodHandle left, System.RuntimeMethodHandle right) { throw null; }
        public static bool operator !=(System.RuntimeMethodHandle left, System.RuntimeMethodHandle right) { throw null; }
    }
    public partial struct RuntimeTypeHandle : System.Runtime.Serialization.ISerializable
    {
        private object _dummy;
        public System.IntPtr Value { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.RuntimeTypeHandle handle) { throw null; }
        public override int GetHashCode() { throw null; }
        [System.CLSCompliantAttribute(false)]
        public System.ModuleHandle GetModuleHandle() { throw null; }
        public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public static bool operator ==(object left, System.RuntimeTypeHandle right) { throw null; }
        public static bool operator ==(System.RuntimeTypeHandle left, object right) { throw null; }
        public static bool operator !=(object left, System.RuntimeTypeHandle right) { throw null; }
        public static bool operator !=(System.RuntimeTypeHandle left, object right) { throw null; }
    }
    [System.CLSCompliantAttribute(false)]
    public readonly partial struct SByte : System.IComparable, System.IComparable<sbyte>, System.IConvertible, System.IEquatable<sbyte>, System.IFormattable
    {
        private readonly sbyte _dummyPrimitive;
        public const sbyte MaxValue = (sbyte)127;
        public const sbyte MinValue = (sbyte)-128;
        public int CompareTo(object obj) { throw null; }
        public int CompareTo(System.SByte value) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.SByte obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public System.TypeCode GetTypeCode() { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.SByte Parse(System.ReadOnlySpan<char> s, System.Globalization.NumberStyles style = System.Globalization.NumberStyles.Integer, System.IFormatProvider provider = null) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.SByte Parse(string s) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.SByte Parse(string s, System.Globalization.NumberStyles style) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.SByte Parse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.SByte Parse(string s, System.IFormatProvider provider) { throw null; }
        bool System.IConvertible.ToBoolean(System.IFormatProvider provider) { throw null; }
        byte System.IConvertible.ToByte(System.IFormatProvider provider) { throw null; }
        char System.IConvertible.ToChar(System.IFormatProvider provider) { throw null; }
        System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider) { throw null; }
        decimal System.IConvertible.ToDecimal(System.IFormatProvider provider) { throw null; }
        double System.IConvertible.ToDouble(System.IFormatProvider provider) { throw null; }
        short System.IConvertible.ToInt16(System.IFormatProvider provider) { throw null; }
        int System.IConvertible.ToInt32(System.IFormatProvider provider) { throw null; }
        long System.IConvertible.ToInt64(System.IFormatProvider provider) { throw null; }
        System.SByte System.IConvertible.ToSByte(System.IFormatProvider provider) { throw null; }
        float System.IConvertible.ToSingle(System.IFormatProvider provider) { throw null; }
        object System.IConvertible.ToType(System.Type type, System.IFormatProvider provider) { throw null; }
        ushort System.IConvertible.ToUInt16(System.IFormatProvider provider) { throw null; }
        uint System.IConvertible.ToUInt32(System.IFormatProvider provider) { throw null; }
        ulong System.IConvertible.ToUInt64(System.IFormatProvider provider) { throw null; }
        public override string ToString() { throw null; }
        public string ToString(System.IFormatProvider provider) { throw null; }
        public string ToString(string format) { throw null; }
        public string ToString(string format, System.IFormatProvider provider) { throw null; }
        public bool TryFormat(System.Span<char> destination, out int charsWritten, System.ReadOnlySpan<char> format = default(System.ReadOnlySpan<char>), System.IFormatProvider provider = null) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static bool TryParse(System.ReadOnlySpan<char> s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out System.SByte result) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static bool TryParse(System.ReadOnlySpan<char> s, out System.SByte result) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static bool TryParse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out System.SByte result) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static bool TryParse(string s, out System.SByte result) { throw null; }
    }
    public readonly partial struct SequencePosition : System.IEquatable<System.SequencePosition>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SequencePosition(object @object, int integer) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.SequencePosition other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public int GetInteger() { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object GetObject() { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Delegate | System.AttributeTargets.Enum | System.AttributeTargets.Struct, Inherited=false)]
    public sealed partial class SerializableAttribute : System.Attribute
    {
        public SerializableAttribute() { }
    }
    public readonly partial struct Single : System.IComparable, System.IComparable<float>, System.IConvertible, System.IEquatable<float>, System.IFormattable
    {
        private readonly float _dummyPrimitive;
        public const float Epsilon = 1.401298E-45f;
        public const float MaxValue = 3.40282347E+38f;
        public const float MinValue = -3.40282347E+38f;
        public const float NaN = 0.0f / 0.0f;
        public const float NegativeInfinity = -1.0f / 0.0f;
        public const float PositiveInfinity = 1.0f / 0.0f;
        public int CompareTo(object value) { throw null; }
        public int CompareTo(System.Single value) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Single obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public System.TypeCode GetTypeCode() { throw null; }
        public static bool IsFinite(System.Single f) { throw null; }
        public static bool IsInfinity(System.Single f) { throw null; }
        public static bool IsNaN(System.Single f) { throw null; }
        public static bool IsNegative(System.Single f) { throw null; }
        public static bool IsNegativeInfinity(System.Single f) { throw null; }
        public static bool IsNormal(System.Single f) { throw null; }
        public static bool IsPositiveInfinity(System.Single f) { throw null; }
        public static bool IsSubnormal(System.Single f) { throw null; }
        public static bool operator ==(System.Single left, System.Single right) { throw null; }
        public static bool operator >(System.Single left, System.Single right) { throw null; }
        public static bool operator >=(System.Single left, System.Single right) { throw null; }
        public static bool operator !=(System.Single left, System.Single right) { throw null; }
        public static bool operator <(System.Single left, System.Single right) { throw null; }
        public static bool operator <=(System.Single left, System.Single right) { throw null; }
        public static System.Single Parse(System.ReadOnlySpan<char> s, System.Globalization.NumberStyles style = System.Globalization.NumberStyles.AllowDecimalPoint | System.Globalization.NumberStyles.AllowExponent | System.Globalization.NumberStyles.AllowLeadingSign | System.Globalization.NumberStyles.AllowLeadingWhite | System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.AllowTrailingWhite, System.IFormatProvider provider = null) { throw null; }
        public static System.Single Parse(string s) { throw null; }
        public static System.Single Parse(string s, System.Globalization.NumberStyles style) { throw null; }
        public static System.Single Parse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider) { throw null; }
        public static System.Single Parse(string s, System.IFormatProvider provider) { throw null; }
        bool System.IConvertible.ToBoolean(System.IFormatProvider provider) { throw null; }
        byte System.IConvertible.ToByte(System.IFormatProvider provider) { throw null; }
        char System.IConvertible.ToChar(System.IFormatProvider provider) { throw null; }
        System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider) { throw null; }
        decimal System.IConvertible.ToDecimal(System.IFormatProvider provider) { throw null; }
        double System.IConvertible.ToDouble(System.IFormatProvider provider) { throw null; }
        short System.IConvertible.ToInt16(System.IFormatProvider provider) { throw null; }
        int System.IConvertible.ToInt32(System.IFormatProvider provider) { throw null; }
        long System.IConvertible.ToInt64(System.IFormatProvider provider) { throw null; }
        sbyte System.IConvertible.ToSByte(System.IFormatProvider provider) { throw null; }
        System.Single System.IConvertible.ToSingle(System.IFormatProvider provider) { throw null; }
        object System.IConvertible.ToType(System.Type type, System.IFormatProvider provider) { throw null; }
        ushort System.IConvertible.ToUInt16(System.IFormatProvider provider) { throw null; }
        uint System.IConvertible.ToUInt32(System.IFormatProvider provider) { throw null; }
        ulong System.IConvertible.ToUInt64(System.IFormatProvider provider) { throw null; }
        public override string ToString() { throw null; }
        public string ToString(System.IFormatProvider provider) { throw null; }
        public string ToString(string format) { throw null; }
        public string ToString(string format, System.IFormatProvider provider) { throw null; }
        public bool TryFormat(System.Span<char> destination, out int charsWritten, System.ReadOnlySpan<char> format = default(System.ReadOnlySpan<char>), System.IFormatProvider provider = null) { throw null; }
        public static bool TryParse(System.ReadOnlySpan<char> s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out System.Single result) { throw null; }
        public static bool TryParse(System.ReadOnlySpan<char> s, out System.Single result) { throw null; }
        public static bool TryParse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out System.Single result) { throw null; }
        public static bool TryParse(string s, out System.Single result) { throw null; }
    }
    public readonly ref partial struct Span<T>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        [System.CLSCompliantAttribute(false)]
        public unsafe Span(void* pointer, int length) { throw null; }
        public Span(T[] array) { throw null; }
        public Span(T[] array, int start, int length) { throw null; }
        public static System.Span<T> Empty { get { throw null; } }
        public bool IsEmpty { get { throw null; } }
        public ref T this[int index] { get { throw null; } }
        public int Length { get { throw null; } }
        public void Clear() { }
        public void CopyTo(System.Span<T> destination) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("Equals() on Span will always throw an exception. Use == instead.")]
        public override bool Equals(object obj) { throw null; }
        public void Fill(T value) { }
        public System.Span<T>.Enumerator GetEnumerator() { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("GetHashCode() on Span will always throw an exception.")]
        public override int GetHashCode() { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public ref T GetPinnableReference() { throw null; }
        public static bool operator ==(System.Span<T> left, System.Span<T> right) { throw null; }
        public static implicit operator System.Span<T> (System.ArraySegment<T> segment) { throw null; }
        public static implicit operator System.ReadOnlySpan<T> (System.Span<T> span) { throw null; }
        public static implicit operator System.Span<T> (T[] array) { throw null; }
        public static bool operator !=(System.Span<T> left, System.Span<T> right) { throw null; }
        public System.Span<T> Slice(int start) { throw null; }
        public System.Span<T> Slice(int start, int length) { throw null; }
        public T[] ToArray() { throw null; }
        public override string ToString() { throw null; }
        public bool TryCopyTo(System.Span<T> destination) { throw null; }
        public ref partial struct Enumerator
        {
            private object _dummy;
            private int _dummyPrimitive;
            public ref T Current { get { throw null; } }
            public bool MoveNext() { throw null; }
        }
    }
    public sealed partial class StackOverflowException : System.SystemException
    {
        public StackOverflowException() { }
        public StackOverflowException(string message) { }
        public StackOverflowException(string message, System.Exception innerException) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method)]
    public sealed partial class STAThreadAttribute : System.Attribute
    {
        public STAThreadAttribute() { }
    }
    public sealed partial class String : System.Collections.Generic.IEnumerable<char>, System.Collections.IEnumerable, System.ICloneable, System.IComparable, System.IComparable<string>, System.IConvertible, System.IEquatable<string>
    {
        public static readonly string Empty;
        [System.CLSCompliantAttribute(false)]
        public unsafe String(char* value) { }
        [System.CLSCompliantAttribute(false)]
        public unsafe String(char* value, int startIndex, int length) { }
        public String(char c, int count) { }
        public String(char[] value) { }
        public String(char[] value, int startIndex, int length) { }
        public String(System.ReadOnlySpan<char> value) { }
        [System.CLSCompliantAttribute(false)]
        public unsafe String(sbyte* value) { }
        [System.CLSCompliantAttribute(false)]
        public unsafe String(sbyte* value, int startIndex, int length) { }
        [System.CLSCompliantAttribute(false)]
        public unsafe String(sbyte* value, int startIndex, int length, System.Text.Encoding enc) { }
        [System.Runtime.CompilerServices.IndexerName("Chars")]
        public char this[int index] { get { throw null; } }
        public int Length { get { throw null; } }
        public object Clone() { throw null; }
        public static int Compare(System.String strA, int indexA, System.String strB, int indexB, int length) { throw null; }
        public static int Compare(System.String strA, int indexA, System.String strB, int indexB, int length, bool ignoreCase) { throw null; }
        public static int Compare(System.String strA, int indexA, System.String strB, int indexB, int length, bool ignoreCase, System.Globalization.CultureInfo culture) { throw null; }
        public static int Compare(System.String strA, int indexA, System.String strB, int indexB, int length, System.Globalization.CultureInfo culture, System.Globalization.CompareOptions options) { throw null; }
        public static int Compare(System.String strA, int indexA, System.String strB, int indexB, int length, System.StringComparison comparisonType) { throw null; }
        public static int Compare(System.String strA, System.String strB) { throw null; }
        public static int Compare(System.String strA, System.String strB, bool ignoreCase) { throw null; }
        public static int Compare(System.String strA, System.String strB, bool ignoreCase, System.Globalization.CultureInfo culture) { throw null; }
        public static int Compare(System.String strA, System.String strB, System.Globalization.CultureInfo culture, System.Globalization.CompareOptions options) { throw null; }
        public static int Compare(System.String strA, System.String strB, System.StringComparison comparisonType) { throw null; }
        public static int CompareOrdinal(System.String strA, int indexA, System.String strB, int indexB, int length) { throw null; }
        public static int CompareOrdinal(System.String strA, System.String strB) { throw null; }
        public int CompareTo(object value) { throw null; }
        public int CompareTo(System.String strB) { throw null; }
        public static System.String Concat(System.Collections.Generic.IEnumerable<string> values) { throw null; }
        public static System.String Concat(object arg0) { throw null; }
        public static System.String Concat(object arg0, object arg1) { throw null; }
        public static System.String Concat(object arg0, object arg1, object arg2) { throw null; }
        public static System.String Concat(params object[] args) { throw null; }
        public static System.String Concat(System.String str0, System.String str1) { throw null; }
        public static System.String Concat(System.String str0, System.String str1, System.String str2) { throw null; }
        public static System.String Concat(System.String str0, System.String str1, System.String str2, System.String str3) { throw null; }
        public static System.String Concat(params string[] values) { throw null; }
        public static System.String Concat<T>(System.Collections.Generic.IEnumerable<T> values) { throw null; }
        public bool Contains(char value) { throw null; }
        public bool Contains(char value, System.StringComparison comparisonType) { throw null; }
        public bool Contains(System.String value) { throw null; }
        public bool Contains(System.String value, System.StringComparison comparisonType) { throw null; }
        public static System.String Copy(System.String str) { throw null; }
        public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count) { }
        public static System.String Create<TState>(int length, TState state, System.Buffers.SpanAction<char, TState> action) { throw null; }
        public bool EndsWith(char value) { throw null; }
        public bool EndsWith(System.String value) { throw null; }
        public bool EndsWith(System.String value, bool ignoreCase, System.Globalization.CultureInfo culture) { throw null; }
        public bool EndsWith(System.String value, System.StringComparison comparisonType) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.String value) { throw null; }
        public static bool Equals(System.String a, System.String b) { throw null; }
        public static bool Equals(System.String a, System.String b, System.StringComparison comparisonType) { throw null; }
        public bool Equals(System.String value, System.StringComparison comparisonType) { throw null; }
        public static System.String Format(System.IFormatProvider provider, System.String format, object arg0) { throw null; }
        public static System.String Format(System.IFormatProvider provider, System.String format, object arg0, object arg1) { throw null; }
        public static System.String Format(System.IFormatProvider provider, System.String format, object arg0, object arg1, object arg2) { throw null; }
        public static System.String Format(System.IFormatProvider provider, System.String format, params object[] args) { throw null; }
        public static System.String Format(System.String format, object arg0) { throw null; }
        public static System.String Format(System.String format, object arg0, object arg1) { throw null; }
        public static System.String Format(System.String format, object arg0, object arg1, object arg2) { throw null; }
        public static System.String Format(System.String format, params object[] args) { throw null; }
        public System.CharEnumerator GetEnumerator() { throw null; }
        public override int GetHashCode() { throw null; }
        public int GetHashCode(System.StringComparison comparisonType) { throw null; }
        public System.TypeCode GetTypeCode() { throw null; }
        public int IndexOf(char value) { throw null; }
        public int IndexOf(char value, int startIndex) { throw null; }
        public int IndexOf(char value, int startIndex, int count) { throw null; }
        public int IndexOf(char value, System.StringComparison comparisonType) { throw null; }
        public int IndexOf(System.String value) { throw null; }
        public int IndexOf(System.String value, int startIndex) { throw null; }
        public int IndexOf(System.String value, int startIndex, int count) { throw null; }
        public int IndexOf(System.String value, int startIndex, int count, System.StringComparison comparisonType) { throw null; }
        public int IndexOf(System.String value, int startIndex, System.StringComparison comparisonType) { throw null; }
        public int IndexOf(System.String value, System.StringComparison comparisonType) { throw null; }
        public int IndexOfAny(char[] anyOf) { throw null; }
        public int IndexOfAny(char[] anyOf, int startIndex) { throw null; }
        public int IndexOfAny(char[] anyOf, int startIndex, int count) { throw null; }
        public System.String Insert(int startIndex, System.String value) { throw null; }
        public static System.String Intern(System.String str) { throw null; }
        public static System.String IsInterned(System.String str) { throw null; }
        public bool IsNormalized() { throw null; }
        public bool IsNormalized(System.Text.NormalizationForm normalizationForm) { throw null; }
        public static bool IsNullOrEmpty(System.String value) { throw null; }
        public static bool IsNullOrWhiteSpace(System.String value) { throw null; }
        public static System.String Join(char separator, params object[] values) { throw null; }
        public static System.String Join(char separator, params string[] value) { throw null; }
        public static System.String Join(char separator, string[] value, int startIndex, int count) { throw null; }
        public static System.String Join(System.String separator, System.Collections.Generic.IEnumerable<string> values) { throw null; }
        public static System.String Join(System.String separator, params object[] values) { throw null; }
        public static System.String Join(System.String separator, params string[] value) { throw null; }
        public static System.String Join(System.String separator, string[] value, int startIndex, int count) { throw null; }
        public static System.String Join<T>(char separator, System.Collections.Generic.IEnumerable<T> values) { throw null; }
        public static System.String Join<T>(System.String separator, System.Collections.Generic.IEnumerable<T> values) { throw null; }
        public int LastIndexOf(char value) { throw null; }
        public int LastIndexOf(char value, int startIndex) { throw null; }
        public int LastIndexOf(char value, int startIndex, int count) { throw null; }
        public int LastIndexOf(System.String value) { throw null; }
        public int LastIndexOf(System.String value, int startIndex) { throw null; }
        public int LastIndexOf(System.String value, int startIndex, int count) { throw null; }
        public int LastIndexOf(System.String value, int startIndex, int count, System.StringComparison comparisonType) { throw null; }
        public int LastIndexOf(System.String value, int startIndex, System.StringComparison comparisonType) { throw null; }
        public int LastIndexOf(System.String value, System.StringComparison comparisonType) { throw null; }
        public int LastIndexOfAny(char[] anyOf) { throw null; }
        public int LastIndexOfAny(char[] anyOf, int startIndex) { throw null; }
        public int LastIndexOfAny(char[] anyOf, int startIndex, int count) { throw null; }
        public System.String Normalize() { throw null; }
        public System.String Normalize(System.Text.NormalizationForm normalizationForm) { throw null; }
        public static bool operator ==(System.String a, System.String b) { throw null; }
        public static implicit operator System.ReadOnlySpan<char> (System.String value) { throw null; }
        public static bool operator !=(System.String a, System.String b) { throw null; }
        public System.String PadLeft(int totalWidth) { throw null; }
        public System.String PadLeft(int totalWidth, char paddingChar) { throw null; }
        public System.String PadRight(int totalWidth) { throw null; }
        public System.String PadRight(int totalWidth, char paddingChar) { throw null; }
        public System.String Remove(int startIndex) { throw null; }
        public System.String Remove(int startIndex, int count) { throw null; }
        public System.String Replace(char oldChar, char newChar) { throw null; }
        public System.String Replace(System.String oldValue, System.String newValue) { throw null; }
        public System.String Replace(System.String oldValue, System.String newValue, bool ignoreCase, System.Globalization.CultureInfo culture) { throw null; }
        public System.String Replace(System.String oldValue, System.String newValue, System.StringComparison comparisonType) { throw null; }
        public string[] Split(char separator, int count, System.StringSplitOptions options = System.StringSplitOptions.None) { throw null; }
        public string[] Split(char separator, System.StringSplitOptions options = System.StringSplitOptions.None) { throw null; }
        public string[] Split(params char[] separator) { throw null; }
        public string[] Split(char[] separator, int count) { throw null; }
        public string[] Split(char[] separator, int count, System.StringSplitOptions options) { throw null; }
        public string[] Split(char[] separator, System.StringSplitOptions options) { throw null; }
        public string[] Split(System.String separator, int count, System.StringSplitOptions options = System.StringSplitOptions.None) { throw null; }
        public string[] Split(System.String separator, System.StringSplitOptions options = System.StringSplitOptions.None) { throw null; }
        public string[] Split(string[] separator, int count, System.StringSplitOptions options) { throw null; }
        public string[] Split(string[] separator, System.StringSplitOptions options) { throw null; }
        public bool StartsWith(char value) { throw null; }
        public bool StartsWith(System.String value) { throw null; }
        public bool StartsWith(System.String value, bool ignoreCase, System.Globalization.CultureInfo culture) { throw null; }
        public bool StartsWith(System.String value, System.StringComparison comparisonType) { throw null; }
        public System.String Substring(int startIndex) { throw null; }
        public System.String Substring(int startIndex, int length) { throw null; }
        System.Collections.Generic.IEnumerator<char> System.Collections.Generic.IEnumerable<System.Char>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        bool System.IConvertible.ToBoolean(System.IFormatProvider provider) { throw null; }
        byte System.IConvertible.ToByte(System.IFormatProvider provider) { throw null; }
        char System.IConvertible.ToChar(System.IFormatProvider provider) { throw null; }
        System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider) { throw null; }
        decimal System.IConvertible.ToDecimal(System.IFormatProvider provider) { throw null; }
        double System.IConvertible.ToDouble(System.IFormatProvider provider) { throw null; }
        short System.IConvertible.ToInt16(System.IFormatProvider provider) { throw null; }
        int System.IConvertible.ToInt32(System.IFormatProvider provider) { throw null; }
        long System.IConvertible.ToInt64(System.IFormatProvider provider) { throw null; }
        sbyte System.IConvertible.ToSByte(System.IFormatProvider provider) { throw null; }
        float System.IConvertible.ToSingle(System.IFormatProvider provider) { throw null; }
        object System.IConvertible.ToType(System.Type type, System.IFormatProvider provider) { throw null; }
        ushort System.IConvertible.ToUInt16(System.IFormatProvider provider) { throw null; }
        uint System.IConvertible.ToUInt32(System.IFormatProvider provider) { throw null; }
        ulong System.IConvertible.ToUInt64(System.IFormatProvider provider) { throw null; }
        public char[] ToCharArray() { throw null; }
        public char[] ToCharArray(int startIndex, int length) { throw null; }
        public System.String ToLower() { throw null; }
        public System.String ToLower(System.Globalization.CultureInfo culture) { throw null; }
        public System.String ToLowerInvariant() { throw null; }
        public override System.String ToString() { throw null; }
        public System.String ToString(System.IFormatProvider provider) { throw null; }
        public System.String ToUpper() { throw null; }
        public System.String ToUpper(System.Globalization.CultureInfo culture) { throw null; }
        public System.String ToUpperInvariant() { throw null; }
        public System.String Trim() { throw null; }
        public System.String Trim(char trimChar) { throw null; }
        public System.String Trim(params char[] trimChars) { throw null; }
        public System.String TrimEnd() { throw null; }
        public System.String TrimEnd(char trimChar) { throw null; }
        public System.String TrimEnd(params char[] trimChars) { throw null; }
        public System.String TrimStart() { throw null; }
        public System.String TrimStart(char trimChar) { throw null; }
        public System.String TrimStart(params char[] trimChars) { throw null; }
    }
    public abstract partial class StringComparer : System.Collections.Generic.IComparer<string>, System.Collections.Generic.IEqualityComparer<string>, System.Collections.IComparer, System.Collections.IEqualityComparer
    {
        protected StringComparer() { }
        public static System.StringComparer CurrentCulture { get { throw null; } }
        public static System.StringComparer CurrentCultureIgnoreCase { get { throw null; } }
        public static System.StringComparer InvariantCulture { get { throw null; } }
        public static System.StringComparer InvariantCultureIgnoreCase { get { throw null; } }
        public static System.StringComparer Ordinal { get { throw null; } }
        public static System.StringComparer OrdinalIgnoreCase { get { throw null; } }
        public int Compare(object x, object y) { throw null; }
        public abstract int Compare(string x, string y);
        public static System.StringComparer Create(System.Globalization.CultureInfo culture, bool ignoreCase) { throw null; }
        public static System.StringComparer Create(System.Globalization.CultureInfo culture, System.Globalization.CompareOptions options) { throw null; }
        public new bool Equals(object x, object y) { throw null; }
        public abstract bool Equals(string x, string y);
        public static System.StringComparer FromComparison(System.StringComparison comparisonType) { throw null; }
        public int GetHashCode(object obj) { throw null; }
        public abstract int GetHashCode(string obj);
        bool System.Collections.IEqualityComparer.Equals(object x, object y) { throw null; }
        int System.Collections.IEqualityComparer.GetHashCode(object obj) { throw null; }
    }
    public enum StringComparison
    {
        CurrentCulture = 0,
        CurrentCultureIgnoreCase = 1,
        InvariantCulture = 2,
        InvariantCultureIgnoreCase = 3,
        Ordinal = 4,
        OrdinalIgnoreCase = 5,
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public static partial class StringNormalizationExtensions
    {
        public static bool IsNormalized(this string value) { throw null; }
        public static bool IsNormalized(this string value, System.Text.NormalizationForm normalizationForm) { throw null; }
        public static string Normalize(this string value) { throw null; }
        public static string Normalize(this string value, System.Text.NormalizationForm normalizationForm) { throw null; }
    }
    [System.FlagsAttribute]
    public enum StringSplitOptions
    {
        None = 0,
        RemoveEmptyEntries = 1,
    }
    public partial class SystemException : System.Exception
    {
        public SystemException() { }
        protected SystemException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public SystemException(string message) { }
        public SystemException(string message, System.Exception innerException) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Field, Inherited=false)]
    public partial class ThreadStaticAttribute : System.Attribute
    {
        public ThreadStaticAttribute() { }
    }
    public partial class TimeoutException : System.SystemException
    {
        public TimeoutException() { }
        protected TimeoutException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public TimeoutException(string message) { }
        public TimeoutException(string message, System.Exception innerException) { }
    }
    public readonly partial struct TimeSpan : System.IComparable, System.IComparable<System.TimeSpan>, System.IEquatable<System.TimeSpan>, System.IFormattable
    {
        private readonly int _dummyPrimitive;
        public static readonly System.TimeSpan MaxValue;
        public static readonly System.TimeSpan MinValue;
        public const long TicksPerDay = (long)864000000000;
        public const long TicksPerHour = (long)36000000000;
        public const long TicksPerMillisecond = (long)10000;
        public const long TicksPerMinute = (long)600000000;
        public const long TicksPerSecond = (long)10000000;
        public static readonly System.TimeSpan Zero;
        public TimeSpan(int hours, int minutes, int seconds) { throw null; }
        public TimeSpan(int days, int hours, int minutes, int seconds) { throw null; }
        public TimeSpan(int days, int hours, int minutes, int seconds, int milliseconds) { throw null; }
        public TimeSpan(long ticks) { throw null; }
        public int Days { get { throw null; } }
        public int Hours { get { throw null; } }
        public int Milliseconds { get { throw null; } }
        public int Minutes { get { throw null; } }
        public int Seconds { get { throw null; } }
        public long Ticks { get { throw null; } }
        public double TotalDays { get { throw null; } }
        public double TotalHours { get { throw null; } }
        public double TotalMilliseconds { get { throw null; } }
        public double TotalMinutes { get { throw null; } }
        public double TotalSeconds { get { throw null; } }
        public System.TimeSpan Add(System.TimeSpan ts) { throw null; }
        public static int Compare(System.TimeSpan t1, System.TimeSpan t2) { throw null; }
        public int CompareTo(object value) { throw null; }
        public int CompareTo(System.TimeSpan value) { throw null; }
        public System.TimeSpan Divide(double divisor) { throw null; }
        public double Divide(System.TimeSpan ts) { throw null; }
        public System.TimeSpan Duration() { throw null; }
        public override bool Equals(object value) { throw null; }
        public bool Equals(System.TimeSpan obj) { throw null; }
        public static bool Equals(System.TimeSpan t1, System.TimeSpan t2) { throw null; }
        public static System.TimeSpan FromDays(double value) { throw null; }
        public static System.TimeSpan FromHours(double value) { throw null; }
        public static System.TimeSpan FromMilliseconds(double value) { throw null; }
        public static System.TimeSpan FromMinutes(double value) { throw null; }
        public static System.TimeSpan FromSeconds(double value) { throw null; }
        public static System.TimeSpan FromTicks(long value) { throw null; }
        public override int GetHashCode() { throw null; }
        public System.TimeSpan Multiply(double factor) { throw null; }
        public System.TimeSpan Negate() { throw null; }
        public static System.TimeSpan operator +(System.TimeSpan t1, System.TimeSpan t2) { throw null; }
        public static System.TimeSpan operator /(System.TimeSpan timeSpan, double divisor) { throw null; }
        public static double operator /(System.TimeSpan t1, System.TimeSpan t2) { throw null; }
        public static bool operator ==(System.TimeSpan t1, System.TimeSpan t2) { throw null; }
        public static bool operator >(System.TimeSpan t1, System.TimeSpan t2) { throw null; }
        public static bool operator >=(System.TimeSpan t1, System.TimeSpan t2) { throw null; }
        public static bool operator !=(System.TimeSpan t1, System.TimeSpan t2) { throw null; }
        public static bool operator <(System.TimeSpan t1, System.TimeSpan t2) { throw null; }
        public static bool operator <=(System.TimeSpan t1, System.TimeSpan t2) { throw null; }
        public static System.TimeSpan operator *(double factor, System.TimeSpan timeSpan) { throw null; }
        public static System.TimeSpan operator *(System.TimeSpan timeSpan, double factor) { throw null; }
        public static System.TimeSpan operator -(System.TimeSpan t1, System.TimeSpan t2) { throw null; }
        public static System.TimeSpan operator -(System.TimeSpan t) { throw null; }
        public static System.TimeSpan operator +(System.TimeSpan t) { throw null; }
        public static System.TimeSpan Parse(System.ReadOnlySpan<char> input, System.IFormatProvider formatProvider = null) { throw null; }
        public static System.TimeSpan Parse(string s) { throw null; }
        public static System.TimeSpan Parse(string input, System.IFormatProvider formatProvider) { throw null; }
        public static System.TimeSpan ParseExact(System.ReadOnlySpan<char> input, System.ReadOnlySpan<char> format, System.IFormatProvider formatProvider, System.Globalization.TimeSpanStyles styles = System.Globalization.TimeSpanStyles.None) { throw null; }
        public static System.TimeSpan ParseExact(System.ReadOnlySpan<char> input, string[] formats, System.IFormatProvider formatProvider, System.Globalization.TimeSpanStyles styles = System.Globalization.TimeSpanStyles.None) { throw null; }
        public static System.TimeSpan ParseExact(string input, string format, System.IFormatProvider formatProvider) { throw null; }
        public static System.TimeSpan ParseExact(string input, string format, System.IFormatProvider formatProvider, System.Globalization.TimeSpanStyles styles) { throw null; }
        public static System.TimeSpan ParseExact(string input, string[] formats, System.IFormatProvider formatProvider) { throw null; }
        public static System.TimeSpan ParseExact(string input, string[] formats, System.IFormatProvider formatProvider, System.Globalization.TimeSpanStyles styles) { throw null; }
        public System.TimeSpan Subtract(System.TimeSpan ts) { throw null; }
        public override string ToString() { throw null; }
        public string ToString(string format) { throw null; }
        public string ToString(string format, System.IFormatProvider formatProvider) { throw null; }
        public bool TryFormat(System.Span<char> destination, out int charsWritten, System.ReadOnlySpan<char> format = default(System.ReadOnlySpan<char>), System.IFormatProvider formatProvider = null) { throw null; }
        public static bool TryParse(System.ReadOnlySpan<char> input, System.IFormatProvider formatProvider, out System.TimeSpan result) { throw null; }
        public static bool TryParse(System.ReadOnlySpan<char> s, out System.TimeSpan result) { throw null; }
        public static bool TryParse(string input, System.IFormatProvider formatProvider, out System.TimeSpan result) { throw null; }
        public static bool TryParse(string s, out System.TimeSpan result) { throw null; }
        public static bool TryParseExact(System.ReadOnlySpan<char> input, System.ReadOnlySpan<char> format, System.IFormatProvider formatProvider, System.Globalization.TimeSpanStyles styles, out System.TimeSpan result) { throw null; }
        public static bool TryParseExact(System.ReadOnlySpan<char> input, System.ReadOnlySpan<char> format, System.IFormatProvider formatProvider, out System.TimeSpan result) { throw null; }
        public static bool TryParseExact(System.ReadOnlySpan<char> input, string[] formats, System.IFormatProvider formatProvider, System.Globalization.TimeSpanStyles styles, out System.TimeSpan result) { throw null; }
        public static bool TryParseExact(System.ReadOnlySpan<char> input, string[] formats, System.IFormatProvider formatProvider, out System.TimeSpan result) { throw null; }
        public static bool TryParseExact(string input, string format, System.IFormatProvider formatProvider, System.Globalization.TimeSpanStyles styles, out System.TimeSpan result) { throw null; }
        public static bool TryParseExact(string input, string format, System.IFormatProvider formatProvider, out System.TimeSpan result) { throw null; }
        public static bool TryParseExact(string input, string[] formats, System.IFormatProvider formatProvider, System.Globalization.TimeSpanStyles styles, out System.TimeSpan result) { throw null; }
        public static bool TryParseExact(string input, string[] formats, System.IFormatProvider formatProvider, out System.TimeSpan result) { throw null; }
    }
    [System.ObsoleteAttribute("System.TimeZone has been deprecated.  Please investigate the use of System.TimeZoneInfo instead.")]
    public abstract partial class TimeZone
    {
        protected TimeZone() { }
        public static System.TimeZone CurrentTimeZone { get { throw null; } }
        public abstract string DaylightName { get; }
        public abstract string StandardName { get; }
        public abstract System.Globalization.DaylightTime GetDaylightChanges(int year);
        public abstract System.TimeSpan GetUtcOffset(System.DateTime time);
        public virtual bool IsDaylightSavingTime(System.DateTime time) { throw null; }
        public static bool IsDaylightSavingTime(System.DateTime time, System.Globalization.DaylightTime daylightTimes) { throw null; }
        public virtual System.DateTime ToLocalTime(System.DateTime time) { throw null; }
        public virtual System.DateTime ToUniversalTime(System.DateTime time) { throw null; }
    }
    public sealed partial class TimeZoneInfo : System.IEquatable<System.TimeZoneInfo>, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable
    {
        internal TimeZoneInfo() { }
        public System.TimeSpan BaseUtcOffset { get { throw null; } }
        public string DaylightName { get { throw null; } }
        public string DisplayName { get { throw null; } }
        public string Id { get { throw null; } }
        public static System.TimeZoneInfo Local { get { throw null; } }
        public string StandardName { get { throw null; } }
        public bool SupportsDaylightSavingTime { get { throw null; } }
        public static System.TimeZoneInfo Utc { get { throw null; } }
        public static void ClearCachedData() { }
        public static System.DateTime ConvertTime(System.DateTime dateTime, System.TimeZoneInfo destinationTimeZone) { throw null; }
        public static System.DateTime ConvertTime(System.DateTime dateTime, System.TimeZoneInfo sourceTimeZone, System.TimeZoneInfo destinationTimeZone) { throw null; }
        public static System.DateTimeOffset ConvertTime(System.DateTimeOffset dateTimeOffset, System.TimeZoneInfo destinationTimeZone) { throw null; }
        public static System.DateTime ConvertTimeBySystemTimeZoneId(System.DateTime dateTime, string destinationTimeZoneId) { throw null; }
        public static System.DateTime ConvertTimeBySystemTimeZoneId(System.DateTime dateTime, string sourceTimeZoneId, string destinationTimeZoneId) { throw null; }
        public static System.DateTimeOffset ConvertTimeBySystemTimeZoneId(System.DateTimeOffset dateTimeOffset, string destinationTimeZoneId) { throw null; }
        public static System.DateTime ConvertTimeFromUtc(System.DateTime dateTime, System.TimeZoneInfo destinationTimeZone) { throw null; }
        public static System.DateTime ConvertTimeToUtc(System.DateTime dateTime) { throw null; }
        public static System.DateTime ConvertTimeToUtc(System.DateTime dateTime, System.TimeZoneInfo sourceTimeZone) { throw null; }
        public static System.TimeZoneInfo CreateCustomTimeZone(string id, System.TimeSpan baseUtcOffset, string displayName, string standardDisplayName) { throw null; }
        public static System.TimeZoneInfo CreateCustomTimeZone(string id, System.TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, System.TimeZoneInfo.AdjustmentRule[] adjustmentRules) { throw null; }
        public static System.TimeZoneInfo CreateCustomTimeZone(string id, System.TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, System.TimeZoneInfo.AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.TimeZoneInfo other) { throw null; }
        public static System.TimeZoneInfo FindSystemTimeZoneById(string id) { throw null; }
        public static System.TimeZoneInfo FromSerializedString(string source) { throw null; }
        public System.TimeZoneInfo.AdjustmentRule[] GetAdjustmentRules() { throw null; }
        public System.TimeSpan[] GetAmbiguousTimeOffsets(System.DateTime dateTime) { throw null; }
        public System.TimeSpan[] GetAmbiguousTimeOffsets(System.DateTimeOffset dateTimeOffset) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Collections.ObjectModel.ReadOnlyCollection<System.TimeZoneInfo> GetSystemTimeZones() { throw null; }
        public System.TimeSpan GetUtcOffset(System.DateTime dateTime) { throw null; }
        public System.TimeSpan GetUtcOffset(System.DateTimeOffset dateTimeOffset) { throw null; }
        public bool HasSameRules(System.TimeZoneInfo other) { throw null; }
        public bool IsAmbiguousTime(System.DateTime dateTime) { throw null; }
        public bool IsAmbiguousTime(System.DateTimeOffset dateTimeOffset) { throw null; }
        public bool IsDaylightSavingTime(System.DateTime dateTime) { throw null; }
        public bool IsDaylightSavingTime(System.DateTimeOffset dateTimeOffset) { throw null; }
        public bool IsInvalidTime(System.DateTime dateTime) { throw null; }
        void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public string ToSerializedString() { throw null; }
        public override string ToString() { throw null; }
        public sealed partial class AdjustmentRule : System.IEquatable<System.TimeZoneInfo.AdjustmentRule>, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable
        {
            internal AdjustmentRule() { }
            public System.DateTime DateEnd { get { throw null; } }
            public System.DateTime DateStart { get { throw null; } }
            public System.TimeSpan DaylightDelta { get { throw null; } }
            public System.TimeZoneInfo.TransitionTime DaylightTransitionEnd { get { throw null; } }
            public System.TimeZoneInfo.TransitionTime DaylightTransitionStart { get { throw null; } }
            public static System.TimeZoneInfo.AdjustmentRule CreateAdjustmentRule(System.DateTime dateStart, System.DateTime dateEnd, System.TimeSpan daylightDelta, System.TimeZoneInfo.TransitionTime daylightTransitionStart, System.TimeZoneInfo.TransitionTime daylightTransitionEnd) { throw null; }
            public bool Equals(System.TimeZoneInfo.AdjustmentRule other) { throw null; }
            public override int GetHashCode() { throw null; }
            void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
            void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        }
        public readonly partial struct TransitionTime : System.IEquatable<System.TimeZoneInfo.TransitionTime>, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable
        {
            private readonly int _dummyPrimitive;
            public int Day { get { throw null; } }
            public System.DayOfWeek DayOfWeek { get { throw null; } }
            public bool IsFixedDateRule { get { throw null; } }
            public int Month { get { throw null; } }
            public System.DateTime TimeOfDay { get { throw null; } }
            public int Week { get { throw null; } }
            public static System.TimeZoneInfo.TransitionTime CreateFixedDateRule(System.DateTime timeOfDay, int month, int day) { throw null; }
            public static System.TimeZoneInfo.TransitionTime CreateFloatingDateRule(System.DateTime timeOfDay, int month, int week, System.DayOfWeek dayOfWeek) { throw null; }
            public override bool Equals(object obj) { throw null; }
            public bool Equals(System.TimeZoneInfo.TransitionTime other) { throw null; }
            public override int GetHashCode() { throw null; }
            public static bool operator ==(System.TimeZoneInfo.TransitionTime t1, System.TimeZoneInfo.TransitionTime t2) { throw null; }
            public static bool operator !=(System.TimeZoneInfo.TransitionTime t1, System.TimeZoneInfo.TransitionTime t2) { throw null; }
            void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
            void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        }
    }
    public partial class TimeZoneNotFoundException : System.Exception
    {
        public TimeZoneNotFoundException() { }
        protected TimeZoneNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public TimeZoneNotFoundException(string message) { }
        public TimeZoneNotFoundException(string message, System.Exception innerException) { }
    }
    public static partial class Tuple
    {
        public static System.Tuple<T1> Create<T1>(T1 item1) { throw null; }
        public static System.Tuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2) { throw null; }
        public static System.Tuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3) { throw null; }
        public static System.Tuple<T1, T2, T3, T4> Create<T1, T2, T3, T4>(T1 item1, T2 item2, T3 item3, T4 item4) { throw null; }
        public static System.Tuple<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5) { throw null; }
        public static System.Tuple<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6) { throw null; }
        public static System.Tuple<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7) { throw null; }
        public static System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8>> Create<T1, T2, T3, T4, T5, T6, T7, T8>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8) { throw null; }
    }
    public partial class Tuple<T1> : System.Collections.IStructuralComparable, System.Collections.IStructuralEquatable, System.IComparable, System.Runtime.CompilerServices.ITuple
    {
        public Tuple(T1 item1) { }
        public T1 Item1 { get { throw null; } }
        object System.Runtime.CompilerServices.ITuple.this[int index] { get { throw null; } }
        int System.Runtime.CompilerServices.ITuple.Length { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        int System.Collections.IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) { throw null; }
        bool System.Collections.IStructuralEquatable.Equals(object other, System.Collections.IEqualityComparer comparer) { throw null; }
        int System.Collections.IStructuralEquatable.GetHashCode(System.Collections.IEqualityComparer comparer) { throw null; }
        int System.IComparable.CompareTo(object obj) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class Tuple<T1, T2> : System.Collections.IStructuralComparable, System.Collections.IStructuralEquatable, System.IComparable, System.Runtime.CompilerServices.ITuple
    {
        public Tuple(T1 item1, T2 item2) { }
        public T1 Item1 { get { throw null; } }
        public T2 Item2 { get { throw null; } }
        object System.Runtime.CompilerServices.ITuple.this[int index] { get { throw null; } }
        int System.Runtime.CompilerServices.ITuple.Length { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        int System.Collections.IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) { throw null; }
        bool System.Collections.IStructuralEquatable.Equals(object other, System.Collections.IEqualityComparer comparer) { throw null; }
        int System.Collections.IStructuralEquatable.GetHashCode(System.Collections.IEqualityComparer comparer) { throw null; }
        int System.IComparable.CompareTo(object obj) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class Tuple<T1, T2, T3> : System.Collections.IStructuralComparable, System.Collections.IStructuralEquatable, System.IComparable, System.Runtime.CompilerServices.ITuple
    {
        public Tuple(T1 item1, T2 item2, T3 item3) { }
        public T1 Item1 { get { throw null; } }
        public T2 Item2 { get { throw null; } }
        public T3 Item3 { get { throw null; } }
        object System.Runtime.CompilerServices.ITuple.this[int index] { get { throw null; } }
        int System.Runtime.CompilerServices.ITuple.Length { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        int System.Collections.IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) { throw null; }
        bool System.Collections.IStructuralEquatable.Equals(object other, System.Collections.IEqualityComparer comparer) { throw null; }
        int System.Collections.IStructuralEquatable.GetHashCode(System.Collections.IEqualityComparer comparer) { throw null; }
        int System.IComparable.CompareTo(object obj) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class Tuple<T1, T2, T3, T4> : System.Collections.IStructuralComparable, System.Collections.IStructuralEquatable, System.IComparable, System.Runtime.CompilerServices.ITuple
    {
        public Tuple(T1 item1, T2 item2, T3 item3, T4 item4) { }
        public T1 Item1 { get { throw null; } }
        public T2 Item2 { get { throw null; } }
        public T3 Item3 { get { throw null; } }
        public T4 Item4 { get { throw null; } }
        object System.Runtime.CompilerServices.ITuple.this[int index] { get { throw null; } }
        int System.Runtime.CompilerServices.ITuple.Length { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        int System.Collections.IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) { throw null; }
        bool System.Collections.IStructuralEquatable.Equals(object other, System.Collections.IEqualityComparer comparer) { throw null; }
        int System.Collections.IStructuralEquatable.GetHashCode(System.Collections.IEqualityComparer comparer) { throw null; }
        int System.IComparable.CompareTo(object obj) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class Tuple<T1, T2, T3, T4, T5> : System.Collections.IStructuralComparable, System.Collections.IStructuralEquatable, System.IComparable, System.Runtime.CompilerServices.ITuple
    {
        public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5) { }
        public T1 Item1 { get { throw null; } }
        public T2 Item2 { get { throw null; } }
        public T3 Item3 { get { throw null; } }
        public T4 Item4 { get { throw null; } }
        public T5 Item5 { get { throw null; } }
        object System.Runtime.CompilerServices.ITuple.this[int index] { get { throw null; } }
        int System.Runtime.CompilerServices.ITuple.Length { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        int System.Collections.IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) { throw null; }
        bool System.Collections.IStructuralEquatable.Equals(object other, System.Collections.IEqualityComparer comparer) { throw null; }
        int System.Collections.IStructuralEquatable.GetHashCode(System.Collections.IEqualityComparer comparer) { throw null; }
        int System.IComparable.CompareTo(object obj) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class Tuple<T1, T2, T3, T4, T5, T6> : System.Collections.IStructuralComparable, System.Collections.IStructuralEquatable, System.IComparable, System.Runtime.CompilerServices.ITuple
    {
        public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6) { }
        public T1 Item1 { get { throw null; } }
        public T2 Item2 { get { throw null; } }
        public T3 Item3 { get { throw null; } }
        public T4 Item4 { get { throw null; } }
        public T5 Item5 { get { throw null; } }
        public T6 Item6 { get { throw null; } }
        object System.Runtime.CompilerServices.ITuple.this[int index] { get { throw null; } }
        int System.Runtime.CompilerServices.ITuple.Length { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        int System.Collections.IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) { throw null; }
        bool System.Collections.IStructuralEquatable.Equals(object other, System.Collections.IEqualityComparer comparer) { throw null; }
        int System.Collections.IStructuralEquatable.GetHashCode(System.Collections.IEqualityComparer comparer) { throw null; }
        int System.IComparable.CompareTo(object obj) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class Tuple<T1, T2, T3, T4, T5, T6, T7> : System.Collections.IStructuralComparable, System.Collections.IStructuralEquatable, System.IComparable, System.Runtime.CompilerServices.ITuple
    {
        public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7) { }
        public T1 Item1 { get { throw null; } }
        public T2 Item2 { get { throw null; } }
        public T3 Item3 { get { throw null; } }
        public T4 Item4 { get { throw null; } }
        public T5 Item5 { get { throw null; } }
        public T6 Item6 { get { throw null; } }
        public T7 Item7 { get { throw null; } }
        object System.Runtime.CompilerServices.ITuple.this[int index] { get { throw null; } }
        int System.Runtime.CompilerServices.ITuple.Length { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        int System.Collections.IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) { throw null; }
        bool System.Collections.IStructuralEquatable.Equals(object other, System.Collections.IEqualityComparer comparer) { throw null; }
        int System.Collections.IStructuralEquatable.GetHashCode(System.Collections.IEqualityComparer comparer) { throw null; }
        int System.IComparable.CompareTo(object obj) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> : System.Collections.IStructuralComparable, System.Collections.IStructuralEquatable, System.IComparable, System.Runtime.CompilerServices.ITuple
    {
        public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, TRest rest) { }
        public T1 Item1 { get { throw null; } }
        public T2 Item2 { get { throw null; } }
        public T3 Item3 { get { throw null; } }
        public T4 Item4 { get { throw null; } }
        public T5 Item5 { get { throw null; } }
        public T6 Item6 { get { throw null; } }
        public T7 Item7 { get { throw null; } }
        public TRest Rest { get { throw null; } }
        object System.Runtime.CompilerServices.ITuple.this[int index] { get { throw null; } }
        int System.Runtime.CompilerServices.ITuple.Length { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        int System.Collections.IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) { throw null; }
        bool System.Collections.IStructuralEquatable.Equals(object other, System.Collections.IEqualityComparer comparer) { throw null; }
        int System.Collections.IStructuralEquatable.GetHashCode(System.Collections.IEqualityComparer comparer) { throw null; }
        int System.IComparable.CompareTo(object obj) { throw null; }
        public override string ToString() { throw null; }
    }
    public static partial class TupleExtensions
    {
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static void Deconstruct<T1>(this System.Tuple<T1> value, out T1 item1) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static void Deconstruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8, T9, T10>> value, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9, out T10 item10) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static void Deconstruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8, T9, T10, T11>> value, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9, out T10 item10, out T11 item11) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static void Deconstruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8, T9, T10, T11, T12>> value, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9, out T10 item10, out T11 item11, out T12 item12) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static void Deconstruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8, T9, T10, T11, T12, T13>> value, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9, out T10 item10, out T11 item11, out T12 item12, out T13 item13) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static void Deconstruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8, T9, T10, T11, T12, T13, T14>> value, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9, out T10 item10, out T11 item11, out T12 item12, out T13 item13, out T14 item14) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static void Deconstruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8, T9, T10, T11, T12, T13, T14, System.Tuple<T15>>> value, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9, out T10 item10, out T11 item11, out T12 item12, out T13 item13, out T14 item14, out T15 item15) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static void Deconstruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8, T9, T10, T11, T12, T13, T14, System.Tuple<T15, T16>>> value, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9, out T10 item10, out T11 item11, out T12 item12, out T13 item13, out T14 item14, out T15 item15, out T16 item16) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static void Deconstruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(this System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8, T9, T10, T11, T12, T13, T14, System.Tuple<T15, T16, T17>>> value, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9, out T10 item10, out T11 item11, out T12 item12, out T13 item13, out T14 item14, out T15 item15, out T16 item16, out T17 item17) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static void Deconstruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(this System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8, T9, T10, T11, T12, T13, T14, System.Tuple<T15, T16, T17, T18>>> value, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9, out T10 item10, out T11 item11, out T12 item12, out T13 item13, out T14 item14, out T15 item15, out T16 item16, out T17 item17, out T18 item18) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static void Deconstruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(this System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8, T9, T10, T11, T12, T13, T14, System.Tuple<T15, T16, T17, T18, T19>>> value, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9, out T10 item10, out T11 item11, out T12 item12, out T13 item13, out T14 item14, out T15 item15, out T16 item16, out T17 item17, out T18 item18, out T19 item19) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static void Deconstruct<T1, T2>(this System.Tuple<T1, T2> value, out T1 item1, out T2 item2) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static void Deconstruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(this System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8, T9, T10, T11, T12, T13, T14, System.Tuple<T15, T16, T17, T18, T19, T20>>> value, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9, out T10 item10, out T11 item11, out T12 item12, out T13 item13, out T14 item14, out T15 item15, out T16 item16, out T17 item17, out T18 item18, out T19 item19, out T20 item20) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static void Deconstruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(this System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8, T9, T10, T11, T12, T13, T14, System.Tuple<T15, T16, T17, T18, T19, T20, T21>>> value, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9, out T10 item10, out T11 item11, out T12 item12, out T13 item13, out T14 item14, out T15 item15, out T16 item16, out T17 item17, out T18 item18, out T19 item19, out T20 item20, out T21 item21) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static void Deconstruct<T1, T2, T3>(this System.Tuple<T1, T2, T3> value, out T1 item1, out T2 item2, out T3 item3) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static void Deconstruct<T1, T2, T3, T4>(this System.Tuple<T1, T2, T3, T4> value, out T1 item1, out T2 item2, out T3 item3, out T4 item4) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static void Deconstruct<T1, T2, T3, T4, T5>(this System.Tuple<T1, T2, T3, T4, T5> value, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static void Deconstruct<T1, T2, T3, T4, T5, T6>(this System.Tuple<T1, T2, T3, T4, T5, T6> value, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static void Deconstruct<T1, T2, T3, T4, T5, T6, T7>(this System.Tuple<T1, T2, T3, T4, T5, T6, T7> value, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static void Deconstruct<T1, T2, T3, T4, T5, T6, T7, T8>(this System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8>> value, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static void Deconstruct<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8, T9>> value, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9) { throw null; }
        public static System.Tuple<T1> ToTuple<T1>(this System.ValueTuple<T1> value) { throw null; }
        public static System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8, T9, T10>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, System.ValueTuple<T8, T9, T10>> value) { throw null; }
        public static System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8, T9, T10, T11>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, System.ValueTuple<T8, T9, T10, T11>> value) { throw null; }
        public static System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8, T9, T10, T11, T12>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, System.ValueTuple<T8, T9, T10, T11, T12>> value) { throw null; }
        public static System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8, T9, T10, T11, T12, T13>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, System.ValueTuple<T8, T9, T10, T11, T12, T13>> value) { throw null; }
        public static System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8, T9, T10, T11, T12, T13, T14>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, System.ValueTuple<T8, T9, T10, T11, T12, T13, T14>> value) { throw null; }
        public static System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8, T9, T10, T11, T12, T13, T14, System.Tuple<T15>>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, System.ValueTuple<T8, T9, T10, T11, T12, T13, T14, System.ValueTuple<T15>>> value) { throw null; }
        public static System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8, T9, T10, T11, T12, T13, T14, System.Tuple<T15, T16>>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, System.ValueTuple<T8, T9, T10, T11, T12, T13, T14, System.ValueTuple<T15, T16>>> value) { throw null; }
        public static System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8, T9, T10, T11, T12, T13, T14, System.Tuple<T15, T16, T17>>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(this System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, System.ValueTuple<T8, T9, T10, T11, T12, T13, T14, System.ValueTuple<T15, T16, T17>>> value) { throw null; }
        public static System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8, T9, T10, T11, T12, T13, T14, System.Tuple<T15, T16, T17, T18>>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(this System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, System.ValueTuple<T8, T9, T10, T11, T12, T13, T14, System.ValueTuple<T15, T16, T17, T18>>> value) { throw null; }
        public static System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8, T9, T10, T11, T12, T13, T14, System.Tuple<T15, T16, T17, T18, T19>>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(this System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, System.ValueTuple<T8, T9, T10, T11, T12, T13, T14, System.ValueTuple<T15, T16, T17, T18, T19>>> value) { throw null; }
        public static System.Tuple<T1, T2> ToTuple<T1, T2>(this System.ValueTuple<T1, T2> value) { throw null; }
        public static System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8, T9, T10, T11, T12, T13, T14, System.Tuple<T15, T16, T17, T18, T19, T20>>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(this System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, System.ValueTuple<T8, T9, T10, T11, T12, T13, T14, System.ValueTuple<T15, T16, T17, T18, T19, T20>>> value) { throw null; }
        public static System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8, T9, T10, T11, T12, T13, T14, System.Tuple<T15, T16, T17, T18, T19, T20, T21>>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(this System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, System.ValueTuple<T8, T9, T10, T11, T12, T13, T14, System.ValueTuple<T15, T16, T17, T18, T19, T20, T21>>> value) { throw null; }
        public static System.Tuple<T1, T2, T3> ToTuple<T1, T2, T3>(this System.ValueTuple<T1, T2, T3> value) { throw null; }
        public static System.Tuple<T1, T2, T3, T4> ToTuple<T1, T2, T3, T4>(this System.ValueTuple<T1, T2, T3, T4> value) { throw null; }
        public static System.Tuple<T1, T2, T3, T4, T5> ToTuple<T1, T2, T3, T4, T5>(this System.ValueTuple<T1, T2, T3, T4, T5> value) { throw null; }
        public static System.Tuple<T1, T2, T3, T4, T5, T6> ToTuple<T1, T2, T3, T4, T5, T6>(this System.ValueTuple<T1, T2, T3, T4, T5, T6> value) { throw null; }
        public static System.Tuple<T1, T2, T3, T4, T5, T6, T7> ToTuple<T1, T2, T3, T4, T5, T6, T7>(this System.ValueTuple<T1, T2, T3, T4, T5, T6, T7> value) { throw null; }
        public static System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8>(this System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, System.ValueTuple<T8>> value) { throw null; }
        public static System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8, T9>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, System.ValueTuple<T8, T9>> value) { throw null; }
        public static System.ValueTuple<T1> ToValueTuple<T1>(this System.Tuple<T1> value) { throw null; }
        public static System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, System.ValueTuple<T8, T9, T10>> ToValueTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8, T9, T10>> value) { throw null; }
        public static System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, System.ValueTuple<T8, T9, T10, T11>> ToValueTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8, T9, T10, T11>> value) { throw null; }
        public static System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, System.ValueTuple<T8, T9, T10, T11, T12>> ToValueTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8, T9, T10, T11, T12>> value) { throw null; }
        public static System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, System.ValueTuple<T8, T9, T10, T11, T12, T13>> ToValueTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8, T9, T10, T11, T12, T13>> value) { throw null; }
        public static System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, System.ValueTuple<T8, T9, T10, T11, T12, T13, T14>> ToValueTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8, T9, T10, T11, T12, T13, T14>> value) { throw null; }
        public static System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, System.ValueTuple<T8, T9, T10, T11, T12, T13, T14, System.ValueTuple<T15>>> ToValueTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8, T9, T10, T11, T12, T13, T14, System.Tuple<T15>>> value) { throw null; }
        public static System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, System.ValueTuple<T8, T9, T10, T11, T12, T13, T14, System.ValueTuple<T15, T16>>> ToValueTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8, T9, T10, T11, T12, T13, T14, System.Tuple<T15, T16>>> value) { throw null; }
        public static System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, System.ValueTuple<T8, T9, T10, T11, T12, T13, T14, System.ValueTuple<T15, T16, T17>>> ToValueTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(this System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8, T9, T10, T11, T12, T13, T14, System.Tuple<T15, T16, T17>>> value) { throw null; }
        public static System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, System.ValueTuple<T8, T9, T10, T11, T12, T13, T14, System.ValueTuple<T15, T16, T17, T18>>> ToValueTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(this System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8, T9, T10, T11, T12, T13, T14, System.Tuple<T15, T16, T17, T18>>> value) { throw null; }
        public static System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, System.ValueTuple<T8, T9, T10, T11, T12, T13, T14, System.ValueTuple<T15, T16, T17, T18, T19>>> ToValueTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(this System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8, T9, T10, T11, T12, T13, T14, System.Tuple<T15, T16, T17, T18, T19>>> value) { throw null; }
        public static System.ValueTuple<T1, T2> ToValueTuple<T1, T2>(this System.Tuple<T1, T2> value) { throw null; }
        public static System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, System.ValueTuple<T8, T9, T10, T11, T12, T13, T14, System.ValueTuple<T15, T16, T17, T18, T19, T20>>> ToValueTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(this System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8, T9, T10, T11, T12, T13, T14, System.Tuple<T15, T16, T17, T18, T19, T20>>> value) { throw null; }
        public static System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, System.ValueTuple<T8, T9, T10, T11, T12, T13, T14, System.ValueTuple<T15, T16, T17, T18, T19, T20, T21>>> ToValueTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(this System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8, T9, T10, T11, T12, T13, T14, System.Tuple<T15, T16, T17, T18, T19, T20, T21>>> value) { throw null; }
        public static System.ValueTuple<T1, T2, T3> ToValueTuple<T1, T2, T3>(this System.Tuple<T1, T2, T3> value) { throw null; }
        public static System.ValueTuple<T1, T2, T3, T4> ToValueTuple<T1, T2, T3, T4>(this System.Tuple<T1, T2, T3, T4> value) { throw null; }
        public static System.ValueTuple<T1, T2, T3, T4, T5> ToValueTuple<T1, T2, T3, T4, T5>(this System.Tuple<T1, T2, T3, T4, T5> value) { throw null; }
        public static System.ValueTuple<T1, T2, T3, T4, T5, T6> ToValueTuple<T1, T2, T3, T4, T5, T6>(this System.Tuple<T1, T2, T3, T4, T5, T6> value) { throw null; }
        public static System.ValueTuple<T1, T2, T3, T4, T5, T6, T7> ToValueTuple<T1, T2, T3, T4, T5, T6, T7>(this System.Tuple<T1, T2, T3, T4, T5, T6, T7> value) { throw null; }
        public static System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, System.ValueTuple<T8>> ToValueTuple<T1, T2, T3, T4, T5, T6, T7, T8>(this System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8>> value) { throw null; }
        public static System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, System.ValueTuple<T8, T9>> ToValueTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this System.Tuple<T1, T2, T3, T4, T5, T6, T7, System.Tuple<T8, T9>> value) { throw null; }
    }
    public abstract partial class Type : System.Reflection.MemberInfo, System.Reflection.IReflect
    {
        public static readonly char Delimiter;
        public static readonly System.Type[] EmptyTypes;
        public static readonly System.Reflection.MemberFilter FilterAttribute;
        public static readonly System.Reflection.MemberFilter FilterName;
        public static readonly System.Reflection.MemberFilter FilterNameIgnoreCase;
        public static readonly object Missing;
        protected Type() { }
        public abstract System.Reflection.Assembly Assembly { get; }
        public abstract string AssemblyQualifiedName { get; }
        public System.Reflection.TypeAttributes Attributes { get { throw null; } }
        public abstract System.Type BaseType { get; }
        public virtual bool ContainsGenericParameters { get { throw null; } }
        public virtual System.Reflection.MethodBase DeclaringMethod { get { throw null; } }
        public override System.Type DeclaringType { get { throw null; } }
        public static System.Reflection.Binder DefaultBinder { get { throw null; } }
        public abstract string FullName { get; }
        public virtual System.Reflection.GenericParameterAttributes GenericParameterAttributes { get { throw null; } }
        public virtual int GenericParameterPosition { get { throw null; } }
        public virtual System.Type[] GenericTypeArguments { get { throw null; } }
        public abstract System.Guid GUID { get; }
        public bool HasElementType { get { throw null; } }
        public bool IsAbstract { get { throw null; } }
        public bool IsAnsiClass { get { throw null; } }
        public bool IsArray { get { throw null; } }
        public bool IsAutoClass { get { throw null; } }
        public bool IsAutoLayout { get { throw null; } }
        public bool IsByRef { get { throw null; } }
        public virtual bool IsByRefLike { get { throw null; } }
        public bool IsClass { get { throw null; } }
        public bool IsCOMObject { get { throw null; } }
        public virtual bool IsConstructedGenericType { get { throw null; } }
        public bool IsContextful { get { throw null; } }
        public virtual bool IsEnum { get { throw null; } }
        public bool IsExplicitLayout { get { throw null; } }
        public virtual bool IsGenericMethodParameter { get { throw null; } }
        public virtual bool IsGenericParameter { get { throw null; } }
        public virtual bool IsGenericType { get { throw null; } }
        public virtual bool IsGenericTypeDefinition { get { throw null; } }
        public virtual bool IsGenericTypeParameter { get { throw null; } }
        public bool IsImport { get { throw null; } }
        public bool IsInterface { get { throw null; } }
        public bool IsLayoutSequential { get { throw null; } }
        public bool IsMarshalByRef { get { throw null; } }
        public bool IsNested { get { throw null; } }
        public bool IsNestedAssembly { get { throw null; } }
        public bool IsNestedFamANDAssem { get { throw null; } }
        public bool IsNestedFamily { get { throw null; } }
        public bool IsNestedFamORAssem { get { throw null; } }
        public bool IsNestedPrivate { get { throw null; } }
        public bool IsNestedPublic { get { throw null; } }
        public bool IsNotPublic { get { throw null; } }
        public bool IsPointer { get { throw null; } }
        public bool IsPrimitive { get { throw null; } }
        public bool IsPublic { get { throw null; } }
        public bool IsSealed { get { throw null; } }
        public virtual bool IsSecurityCritical { get { throw null; } }
        public virtual bool IsSecuritySafeCritical { get { throw null; } }
        public virtual bool IsSecurityTransparent { get { throw null; } }
        public virtual bool IsSerializable { get { throw null; } }
        public virtual bool IsSignatureType { get { throw null; } }
        public bool IsSpecialName { get { throw null; } }
        public virtual bool IsSZArray { get { throw null; } }
        public virtual bool IsTypeDefinition { get { throw null; } }
        public bool IsUnicodeClass { get { throw null; } }
        public bool IsValueType { get { throw null; } }
        public virtual bool IsVariableBoundArray { get { throw null; } }
        public bool IsVisible { get { throw null; } }
        public override System.Reflection.MemberTypes MemberType { get { throw null; } }
        public abstract new System.Reflection.Module Module { get; }
        public abstract string Namespace { get; }
        public override System.Type ReflectedType { get { throw null; } }
        public virtual System.Runtime.InteropServices.StructLayoutAttribute StructLayoutAttribute { get { throw null; } }
        public virtual System.RuntimeTypeHandle TypeHandle { get { throw null; } }
        public System.Reflection.ConstructorInfo TypeInitializer { get { throw null; } }
        public abstract System.Type UnderlyingSystemType { get; }
        public override bool Equals(object o) { throw null; }
        public virtual bool Equals(System.Type o) { throw null; }
        public virtual System.Type[] FindInterfaces(System.Reflection.TypeFilter filter, object filterCriteria) { throw null; }
        public virtual System.Reflection.MemberInfo[] FindMembers(System.Reflection.MemberTypes memberType, System.Reflection.BindingFlags bindingAttr, System.Reflection.MemberFilter filter, object filterCriteria) { throw null; }
        public virtual int GetArrayRank() { throw null; }
        protected abstract System.Reflection.TypeAttributes GetAttributeFlagsImpl();
        public System.Reflection.ConstructorInfo GetConstructor(System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { throw null; }
        public System.Reflection.ConstructorInfo GetConstructor(System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { throw null; }
        public System.Reflection.ConstructorInfo GetConstructor(System.Type[] types) { throw null; }
        protected abstract System.Reflection.ConstructorInfo GetConstructorImpl(System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, System.Type[] types, System.Reflection.ParameterModifier[] modifiers);
        public System.Reflection.ConstructorInfo[] GetConstructors() { throw null; }
        public abstract System.Reflection.ConstructorInfo[] GetConstructors(System.Reflection.BindingFlags bindingAttr);
        public virtual System.Reflection.MemberInfo[] GetDefaultMembers() { throw null; }
        public abstract System.Type GetElementType();
        public virtual string GetEnumName(object value) { throw null; }
        public virtual string[] GetEnumNames() { throw null; }
        public virtual System.Type GetEnumUnderlyingType() { throw null; }
        public virtual System.Array GetEnumValues() { throw null; }
        public System.Reflection.EventInfo GetEvent(string name) { throw null; }
        public abstract System.Reflection.EventInfo GetEvent(string name, System.Reflection.BindingFlags bindingAttr);
        public virtual System.Reflection.EventInfo[] GetEvents() { throw null; }
        public abstract System.Reflection.EventInfo[] GetEvents(System.Reflection.BindingFlags bindingAttr);
        public System.Reflection.FieldInfo GetField(string name) { throw null; }
        public abstract System.Reflection.FieldInfo GetField(string name, System.Reflection.BindingFlags bindingAttr);
        public System.Reflection.FieldInfo[] GetFields() { throw null; }
        public abstract System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags bindingAttr);
        public virtual System.Type[] GetGenericArguments() { throw null; }
        public virtual System.Type[] GetGenericParameterConstraints() { throw null; }
        public virtual System.Type GetGenericTypeDefinition() { throw null; }
        public override int GetHashCode() { throw null; }
        public System.Type GetInterface(string name) { throw null; }
        public abstract System.Type GetInterface(string name, bool ignoreCase);
        public virtual System.Reflection.InterfaceMapping GetInterfaceMap(System.Type interfaceType) { throw null; }
        public abstract System.Type[] GetInterfaces();
        public System.Reflection.MemberInfo[] GetMember(string name) { throw null; }
        public virtual System.Reflection.MemberInfo[] GetMember(string name, System.Reflection.BindingFlags bindingAttr) { throw null; }
        public virtual System.Reflection.MemberInfo[] GetMember(string name, System.Reflection.MemberTypes type, System.Reflection.BindingFlags bindingAttr) { throw null; }
        public System.Reflection.MemberInfo[] GetMembers() { throw null; }
        public abstract System.Reflection.MemberInfo[] GetMembers(System.Reflection.BindingFlags bindingAttr);
        public System.Reflection.MethodInfo GetMethod(string name) { throw null; }
        public System.Reflection.MethodInfo GetMethod(string name, int genericParameterCount, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { throw null; }
        public System.Reflection.MethodInfo GetMethod(string name, int genericParameterCount, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { throw null; }
        public System.Reflection.MethodInfo GetMethod(string name, int genericParameterCount, System.Type[] types) { throw null; }
        public System.Reflection.MethodInfo GetMethod(string name, int genericParameterCount, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { throw null; }
        public System.Reflection.MethodInfo GetMethod(string name, System.Reflection.BindingFlags bindingAttr) { throw null; }
        public System.Reflection.MethodInfo GetMethod(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { throw null; }
        public System.Reflection.MethodInfo GetMethod(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { throw null; }
        public System.Reflection.MethodInfo GetMethod(string name, System.Type[] types) { throw null; }
        public System.Reflection.MethodInfo GetMethod(string name, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { throw null; }
        protected virtual System.Reflection.MethodInfo GetMethodImpl(string name, int genericParameterCount, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { throw null; }
        protected abstract System.Reflection.MethodInfo GetMethodImpl(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, System.Type[] types, System.Reflection.ParameterModifier[] modifiers);
        public System.Reflection.MethodInfo[] GetMethods() { throw null; }
        public abstract System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags bindingAttr);
        public System.Type GetNestedType(string name) { throw null; }
        public abstract System.Type GetNestedType(string name, System.Reflection.BindingFlags bindingAttr);
        public System.Type[] GetNestedTypes() { throw null; }
        public abstract System.Type[] GetNestedTypes(System.Reflection.BindingFlags bindingAttr);
        public System.Reflection.PropertyInfo[] GetProperties() { throw null; }
        public abstract System.Reflection.PropertyInfo[] GetProperties(System.Reflection.BindingFlags bindingAttr);
        public System.Reflection.PropertyInfo GetProperty(string name) { throw null; }
        public System.Reflection.PropertyInfo GetProperty(string name, System.Reflection.BindingFlags bindingAttr) { throw null; }
        public System.Reflection.PropertyInfo GetProperty(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Type returnType, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { throw null; }
        public System.Reflection.PropertyInfo GetProperty(string name, System.Type returnType) { throw null; }
        public System.Reflection.PropertyInfo GetProperty(string name, System.Type returnType, System.Type[] types) { throw null; }
        public System.Reflection.PropertyInfo GetProperty(string name, System.Type returnType, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { throw null; }
        public System.Reflection.PropertyInfo GetProperty(string name, System.Type[] types) { throw null; }
        protected abstract System.Reflection.PropertyInfo GetPropertyImpl(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Type returnType, System.Type[] types, System.Reflection.ParameterModifier[] modifiers);
        public new System.Type GetType() { throw null; }
        public static System.Type GetType(string typeName) { throw null; }
        public static System.Type GetType(string typeName, bool throwOnError) { throw null; }
        public static System.Type GetType(string typeName, bool throwOnError, bool ignoreCase) { throw null; }
        public static System.Type GetType(string typeName, System.Func<System.Reflection.AssemblyName, System.Reflection.Assembly> assemblyResolver, System.Func<System.Reflection.Assembly, string, bool, System.Type> typeResolver) { throw null; }
        public static System.Type GetType(string typeName, System.Func<System.Reflection.AssemblyName, System.Reflection.Assembly> assemblyResolver, System.Func<System.Reflection.Assembly, string, bool, System.Type> typeResolver, bool throwOnError) { throw null; }
        public static System.Type GetType(string typeName, System.Func<System.Reflection.AssemblyName, System.Reflection.Assembly> assemblyResolver, System.Func<System.Reflection.Assembly, string, bool, System.Type> typeResolver, bool throwOnError, bool ignoreCase) { throw null; }
        public static System.Type[] GetTypeArray(object[] args) { throw null; }
        public static System.TypeCode GetTypeCode(System.Type type) { throw null; }
        protected virtual System.TypeCode GetTypeCodeImpl() { throw null; }
        public static System.Type GetTypeFromCLSID(System.Guid clsid) { throw null; }
        public static System.Type GetTypeFromCLSID(System.Guid clsid, bool throwOnError) { throw null; }
        public static System.Type GetTypeFromCLSID(System.Guid clsid, string server) { throw null; }
        public static System.Type GetTypeFromCLSID(System.Guid clsid, string server, bool throwOnError) { throw null; }
        public static System.Type GetTypeFromHandle(System.RuntimeTypeHandle handle) { throw null; }
        public static System.Type GetTypeFromProgID(string progID) { throw null; }
        public static System.Type GetTypeFromProgID(string progID, bool throwOnError) { throw null; }
        public static System.Type GetTypeFromProgID(string progID, string server) { throw null; }
        public static System.Type GetTypeFromProgID(string progID, string server, bool throwOnError) { throw null; }
        public static System.RuntimeTypeHandle GetTypeHandle(object o) { throw null; }
        protected abstract bool HasElementTypeImpl();
        public object InvokeMember(string name, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object target, object[] args) { throw null; }
        public object InvokeMember(string name, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object target, object[] args, System.Globalization.CultureInfo culture) { throw null; }
        public abstract object InvokeMember(string name, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object target, object[] args, System.Reflection.ParameterModifier[] modifiers, System.Globalization.CultureInfo culture, string[] namedParameters);
        protected abstract bool IsArrayImpl();
        public virtual bool IsAssignableFrom(System.Type c) { throw null; }
        protected abstract bool IsByRefImpl();
        protected abstract bool IsCOMObjectImpl();
        protected virtual bool IsContextfulImpl() { throw null; }
        public virtual bool IsEnumDefined(object value) { throw null; }
        public virtual bool IsEquivalentTo(System.Type other) { throw null; }
        public virtual bool IsInstanceOfType(object o) { throw null; }
        protected virtual bool IsMarshalByRefImpl() { throw null; }
        protected abstract bool IsPointerImpl();
        protected abstract bool IsPrimitiveImpl();
        public virtual bool IsSubclassOf(System.Type c) { throw null; }
        protected virtual bool IsValueTypeImpl() { throw null; }
        public virtual System.Type MakeArrayType() { throw null; }
        public virtual System.Type MakeArrayType(int rank) { throw null; }
        public virtual System.Type MakeByRefType() { throw null; }
        public static System.Type MakeGenericMethodParameter(int position) { throw null; }
        public virtual System.Type MakeGenericType(params System.Type[] typeArguments) { throw null; }
        public virtual System.Type MakePointerType() { throw null; }
        public static bool operator ==(System.Type left, System.Type right) { throw null; }
        public static bool operator !=(System.Type left, System.Type right) { throw null; }
        public static System.Type ReflectionOnlyGetType(string typeName, bool throwIfNotFound, bool ignoreCase) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class TypeAccessException : System.TypeLoadException
    {
        public TypeAccessException() { }
        protected TypeAccessException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public TypeAccessException(string message) { }
        public TypeAccessException(string message, System.Exception inner) { }
    }
    public enum TypeCode
    {
        Boolean = 3,
        Byte = 6,
        Char = 4,
        DateTime = 16,
        DBNull = 2,
        Decimal = 15,
        Double = 14,
        Empty = 0,
        Int16 = 7,
        Int32 = 9,
        Int64 = 11,
        Object = 1,
        SByte = 5,
        Single = 13,
        String = 18,
        UInt16 = 8,
        UInt32 = 10,
        UInt64 = 12,
    }
    [System.CLSCompliantAttribute(false)]
    public ref partial struct TypedReference
    {
        private object _dummy;
        private int _dummyPrimitive;
        public override bool Equals(object o) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Type GetTargetType(System.TypedReference value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.TypedReference MakeTypedReference(object target, System.Reflection.FieldInfo[] flds) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static void SetTypedReference(System.TypedReference target, object value) { }
        public static System.RuntimeTypeHandle TargetTypeToken(System.TypedReference value) { throw null; }
        public static object ToObject(System.TypedReference value) { throw null; }
    }
    public sealed partial class TypeInitializationException : System.SystemException
    {
        public TypeInitializationException(string fullTypeName, System.Exception innerException) { }
        public string TypeName { get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public partial class TypeLoadException : System.SystemException, System.Runtime.Serialization.ISerializable
    {
        public TypeLoadException() { }
        protected TypeLoadException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public TypeLoadException(string message) { }
        public TypeLoadException(string message, System.Exception inner) { }
        public override string Message { get { throw null; } }
        public string TypeName { get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public partial class TypeUnloadedException : System.SystemException
    {
        public TypeUnloadedException() { }
        protected TypeUnloadedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public TypeUnloadedException(string message) { }
        public TypeUnloadedException(string message, System.Exception innerException) { }
    }
    [System.CLSCompliantAttribute(false)]
    public readonly partial struct UInt16 : System.IComparable, System.IComparable<ushort>, System.IConvertible, System.IEquatable<ushort>, System.IFormattable
    {
        private readonly ushort _dummyPrimitive;
        public const ushort MaxValue = (ushort)65535;
        public const ushort MinValue = (ushort)0;
        public int CompareTo(object value) { throw null; }
        public int CompareTo(System.UInt16 value) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.UInt16 obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public System.TypeCode GetTypeCode() { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.UInt16 Parse(System.ReadOnlySpan<char> s, System.Globalization.NumberStyles style = System.Globalization.NumberStyles.Integer, System.IFormatProvider provider = null) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.UInt16 Parse(string s) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.UInt16 Parse(string s, System.Globalization.NumberStyles style) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.UInt16 Parse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.UInt16 Parse(string s, System.IFormatProvider provider) { throw null; }
        bool System.IConvertible.ToBoolean(System.IFormatProvider provider) { throw null; }
        byte System.IConvertible.ToByte(System.IFormatProvider provider) { throw null; }
        char System.IConvertible.ToChar(System.IFormatProvider provider) { throw null; }
        System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider) { throw null; }
        decimal System.IConvertible.ToDecimal(System.IFormatProvider provider) { throw null; }
        double System.IConvertible.ToDouble(System.IFormatProvider provider) { throw null; }
        short System.IConvertible.ToInt16(System.IFormatProvider provider) { throw null; }
        int System.IConvertible.ToInt32(System.IFormatProvider provider) { throw null; }
        long System.IConvertible.ToInt64(System.IFormatProvider provider) { throw null; }
        sbyte System.IConvertible.ToSByte(System.IFormatProvider provider) { throw null; }
        float System.IConvertible.ToSingle(System.IFormatProvider provider) { throw null; }
        object System.IConvertible.ToType(System.Type type, System.IFormatProvider provider) { throw null; }
        System.UInt16 System.IConvertible.ToUInt16(System.IFormatProvider provider) { throw null; }
        uint System.IConvertible.ToUInt32(System.IFormatProvider provider) { throw null; }
        ulong System.IConvertible.ToUInt64(System.IFormatProvider provider) { throw null; }
        public override string ToString() { throw null; }
        public string ToString(System.IFormatProvider provider) { throw null; }
        public string ToString(string format) { throw null; }
        public string ToString(string format, System.IFormatProvider provider) { throw null; }
        public bool TryFormat(System.Span<char> destination, out int charsWritten, System.ReadOnlySpan<char> format = default(System.ReadOnlySpan<char>), System.IFormatProvider provider = null) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static bool TryParse(System.ReadOnlySpan<char> s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out System.UInt16 result) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static bool TryParse(System.ReadOnlySpan<char> s, out System.UInt16 result) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static bool TryParse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out System.UInt16 result) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static bool TryParse(string s, out System.UInt16 result) { throw null; }
    }
    [System.CLSCompliantAttribute(false)]
    public readonly partial struct UInt32 : System.IComparable, System.IComparable<uint>, System.IConvertible, System.IEquatable<uint>, System.IFormattable
    {
        private readonly uint _dummyPrimitive;
        public const uint MaxValue = (uint)4294967295;
        public const uint MinValue = (uint)0;
        public int CompareTo(object value) { throw null; }
        public int CompareTo(System.UInt32 value) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.UInt32 obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public System.TypeCode GetTypeCode() { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.UInt32 Parse(System.ReadOnlySpan<char> s, System.Globalization.NumberStyles style = System.Globalization.NumberStyles.Integer, System.IFormatProvider provider = null) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.UInt32 Parse(string s) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.UInt32 Parse(string s, System.Globalization.NumberStyles style) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.UInt32 Parse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.UInt32 Parse(string s, System.IFormatProvider provider) { throw null; }
        bool System.IConvertible.ToBoolean(System.IFormatProvider provider) { throw null; }
        byte System.IConvertible.ToByte(System.IFormatProvider provider) { throw null; }
        char System.IConvertible.ToChar(System.IFormatProvider provider) { throw null; }
        System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider) { throw null; }
        decimal System.IConvertible.ToDecimal(System.IFormatProvider provider) { throw null; }
        double System.IConvertible.ToDouble(System.IFormatProvider provider) { throw null; }
        short System.IConvertible.ToInt16(System.IFormatProvider provider) { throw null; }
        int System.IConvertible.ToInt32(System.IFormatProvider provider) { throw null; }
        long System.IConvertible.ToInt64(System.IFormatProvider provider) { throw null; }
        sbyte System.IConvertible.ToSByte(System.IFormatProvider provider) { throw null; }
        float System.IConvertible.ToSingle(System.IFormatProvider provider) { throw null; }
        object System.IConvertible.ToType(System.Type type, System.IFormatProvider provider) { throw null; }
        ushort System.IConvertible.ToUInt16(System.IFormatProvider provider) { throw null; }
        System.UInt32 System.IConvertible.ToUInt32(System.IFormatProvider provider) { throw null; }
        ulong System.IConvertible.ToUInt64(System.IFormatProvider provider) { throw null; }
        public override string ToString() { throw null; }
        public string ToString(System.IFormatProvider provider) { throw null; }
        public string ToString(string format) { throw null; }
        public string ToString(string format, System.IFormatProvider provider) { throw null; }
        public bool TryFormat(System.Span<char> destination, out int charsWritten, System.ReadOnlySpan<char> format = default(System.ReadOnlySpan<char>), System.IFormatProvider provider = null) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static bool TryParse(System.ReadOnlySpan<char> s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out System.UInt32 result) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static bool TryParse(System.ReadOnlySpan<char> s, out System.UInt32 result) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static bool TryParse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out System.UInt32 result) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static bool TryParse(string s, out System.UInt32 result) { throw null; }
    }
    [System.CLSCompliantAttribute(false)]
    public readonly partial struct UInt64 : System.IComparable, System.IComparable<ulong>, System.IConvertible, System.IEquatable<ulong>, System.IFormattable
    {
        private readonly ulong _dummyPrimitive;
        public const ulong MaxValue = (ulong)18446744073709551615;
        public const ulong MinValue = (ulong)0;
        public int CompareTo(object value) { throw null; }
        public int CompareTo(System.UInt64 value) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.UInt64 obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public System.TypeCode GetTypeCode() { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.UInt64 Parse(System.ReadOnlySpan<char> s, System.Globalization.NumberStyles style = System.Globalization.NumberStyles.Integer, System.IFormatProvider provider = null) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.UInt64 Parse(string s) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.UInt64 Parse(string s, System.Globalization.NumberStyles style) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.UInt64 Parse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.UInt64 Parse(string s, System.IFormatProvider provider) { throw null; }
        bool System.IConvertible.ToBoolean(System.IFormatProvider provider) { throw null; }
        byte System.IConvertible.ToByte(System.IFormatProvider provider) { throw null; }
        char System.IConvertible.ToChar(System.IFormatProvider provider) { throw null; }
        System.DateTime System.IConvertible.ToDateTime(System.IFormatProvider provider) { throw null; }
        decimal System.IConvertible.ToDecimal(System.IFormatProvider provider) { throw null; }
        double System.IConvertible.ToDouble(System.IFormatProvider provider) { throw null; }
        short System.IConvertible.ToInt16(System.IFormatProvider provider) { throw null; }
        int System.IConvertible.ToInt32(System.IFormatProvider provider) { throw null; }
        long System.IConvertible.ToInt64(System.IFormatProvider provider) { throw null; }
        sbyte System.IConvertible.ToSByte(System.IFormatProvider provider) { throw null; }
        float System.IConvertible.ToSingle(System.IFormatProvider provider) { throw null; }
        object System.IConvertible.ToType(System.Type type, System.IFormatProvider provider) { throw null; }
        ushort System.IConvertible.ToUInt16(System.IFormatProvider provider) { throw null; }
        uint System.IConvertible.ToUInt32(System.IFormatProvider provider) { throw null; }
        System.UInt64 System.IConvertible.ToUInt64(System.IFormatProvider provider) { throw null; }
        public override string ToString() { throw null; }
        public string ToString(System.IFormatProvider provider) { throw null; }
        public string ToString(string format) { throw null; }
        public string ToString(string format, System.IFormatProvider provider) { throw null; }
        public bool TryFormat(System.Span<char> destination, out int charsWritten, System.ReadOnlySpan<char> format = default(System.ReadOnlySpan<char>), System.IFormatProvider provider = null) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static bool TryParse(System.ReadOnlySpan<char> s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out System.UInt64 result) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static bool TryParse(System.ReadOnlySpan<char> s, out System.UInt64 result) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static bool TryParse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out System.UInt64 result) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static bool TryParse(string s, out System.UInt64 result) { throw null; }
    }
    [System.CLSCompliantAttribute(false)]
    public readonly partial struct UIntPtr : System.IEquatable<System.UIntPtr>, System.Runtime.Serialization.ISerializable
    {
        private readonly int _dummyPrimitive;
        public static readonly System.UIntPtr Zero;
        public UIntPtr(uint value) { throw null; }
        public UIntPtr(ulong value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public unsafe UIntPtr(void* value) { throw null; }
        public static int Size { get { throw null; } }
        public static System.UIntPtr Add(System.UIntPtr pointer, int offset) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.UIntPtr operator +(System.UIntPtr pointer, int offset) { throw null; }
        public static bool operator ==(System.UIntPtr value1, System.UIntPtr value2) { throw null; }
        public static explicit operator System.UIntPtr (uint value) { throw null; }
        public static explicit operator System.UIntPtr (ulong value) { throw null; }
        public static explicit operator uint (System.UIntPtr value) { throw null; }
        public static explicit operator ulong (System.UIntPtr value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public unsafe static explicit operator void* (System.UIntPtr value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public unsafe static explicit operator System.UIntPtr (void* value) { throw null; }
        public static bool operator !=(System.UIntPtr value1, System.UIntPtr value2) { throw null; }
        public static System.UIntPtr operator -(System.UIntPtr pointer, int offset) { throw null; }
        public static System.UIntPtr Subtract(System.UIntPtr pointer, int offset) { throw null; }
        bool System.IEquatable<System.UIntPtr>.Equals(System.UIntPtr other) { throw null; }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        [System.CLSCompliantAttribute(false)]
        public unsafe void* ToPointer() { throw null; }
        public override string ToString() { throw null; }
        public uint ToUInt32() { throw null; }
        public ulong ToUInt64() { throw null; }
    }
    public partial class UnauthorizedAccessException : System.SystemException
    {
        public UnauthorizedAccessException() { }
        protected UnauthorizedAccessException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public UnauthorizedAccessException(string message) { }
        public UnauthorizedAccessException(string message, System.Exception inner) { }
    }
    public partial class UnhandledExceptionEventArgs : System.EventArgs
    {
        public UnhandledExceptionEventArgs(object exception, bool isTerminating) { }
        public object ExceptionObject { get { throw null; } }
        public bool IsTerminating { get { throw null; } }
    }
    public delegate void UnhandledExceptionEventHandler(object sender, System.UnhandledExceptionEventArgs e);
    public partial class Uri : System.Runtime.Serialization.ISerializable
    {
        public static readonly string SchemeDelimiter;
        public static readonly string UriSchemeFile;
        public static readonly string UriSchemeFtp;
        public static readonly string UriSchemeGopher;
        public static readonly string UriSchemeHttp;
        public static readonly string UriSchemeHttps;
        public static readonly string UriSchemeMailto;
        public static readonly string UriSchemeNetPipe;
        public static readonly string UriSchemeNetTcp;
        public static readonly string UriSchemeNews;
        public static readonly string UriSchemeNntp;
        protected Uri(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public Uri(string uriString) { }
        [System.ObsoleteAttribute("The constructor has been deprecated. Please use new Uri(string). The dontEscape parameter is deprecated and is always false. https://go.microsoft.com/fwlink/?linkid=14202")]
        public Uri(string uriString, bool dontEscape) { }
        public Uri(string uriString, System.UriKind uriKind) { }
        public Uri(System.Uri baseUri, string relativeUri) { }
        [System.ObsoleteAttribute("The constructor has been deprecated. Please new Uri(Uri, string). The dontEscape parameter is deprecated and is always false. https://go.microsoft.com/fwlink/?linkid=14202")]
        public Uri(System.Uri baseUri, string relativeUri, bool dontEscape) { }
        public Uri(System.Uri baseUri, System.Uri relativeUri) { }
        public string AbsolutePath { get { throw null; } }
        public string AbsoluteUri { get { throw null; } }
        public string Authority { get { throw null; } }
        public string DnsSafeHost { get { throw null; } }
        public string Fragment { get { throw null; } }
        public string Host { get { throw null; } }
        public System.UriHostNameType HostNameType { get { throw null; } }
        public string IdnHost { get { throw null; } }
        public bool IsAbsoluteUri { get { throw null; } }
        public bool IsDefaultPort { get { throw null; } }
        public bool IsFile { get { throw null; } }
        public bool IsLoopback { get { throw null; } }
        public bool IsUnc { get { throw null; } }
        public string LocalPath { get { throw null; } }
        public string OriginalString { get { throw null; } }
        public string PathAndQuery { get { throw null; } }
        public int Port { get { throw null; } }
        public string Query { get { throw null; } }
        public string Scheme { get { throw null; } }
        public string[] Segments { get { throw null; } }
        public bool UserEscaped { get { throw null; } }
        public string UserInfo { get { throw null; } }
        [System.ObsoleteAttribute("The method has been deprecated. It is not used by the system. https://go.microsoft.com/fwlink/?linkid=14202")]
        protected virtual void Canonicalize() { }
        public static System.UriHostNameType CheckHostName(string name) { throw null; }
        public static bool CheckSchemeName(string schemeName) { throw null; }
        [System.ObsoleteAttribute("The method has been deprecated. It is not used by the system. https://go.microsoft.com/fwlink/?linkid=14202")]
        protected virtual void CheckSecurity() { }
        public static int Compare(System.Uri uri1, System.Uri uri2, System.UriComponents partsToCompare, System.UriFormat compareFormat, System.StringComparison comparisonType) { throw null; }
        public override bool Equals(object comparand) { throw null; }
        [System.ObsoleteAttribute("The method has been deprecated. It is not used by the system. https://go.microsoft.com/fwlink/?linkid=14202")]
        protected virtual void Escape() { }
        public static string EscapeDataString(string stringToEscape) { throw null; }
        [System.ObsoleteAttribute("The method has been deprecated. Please use GetComponents() or static EscapeUriString() to escape a Uri component or a string. https://go.microsoft.com/fwlink/?linkid=14202")]
        protected static string EscapeString(string str) { throw null; }
        public static string EscapeUriString(string stringToEscape) { throw null; }
        public static int FromHex(char digit) { throw null; }
        public string GetComponents(System.UriComponents components, System.UriFormat format) { throw null; }
        public override int GetHashCode() { throw null; }
        public string GetLeftPart(System.UriPartial part) { throw null; }
        protected void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public static string HexEscape(char character) { throw null; }
        public static char HexUnescape(string pattern, ref int index) { throw null; }
        [System.ObsoleteAttribute("The method has been deprecated. It is not used by the system. https://go.microsoft.com/fwlink/?linkid=14202")]
        protected virtual bool IsBadFileSystemCharacter(char character) { throw null; }
        public bool IsBaseOf(System.Uri uri) { throw null; }
        [System.ObsoleteAttribute("The method has been deprecated. It is not used by the system. https://go.microsoft.com/fwlink/?linkid=14202")]
        protected static bool IsExcludedCharacter(char character) { throw null; }
        public static bool IsHexDigit(char character) { throw null; }
        public static bool IsHexEncoding(string pattern, int index) { throw null; }
        [System.ObsoleteAttribute("The method has been deprecated. It is not used by the system. https://go.microsoft.com/fwlink/?linkid=14202")]
        protected virtual bool IsReservedCharacter(char character) { throw null; }
        public bool IsWellFormedOriginalString() { throw null; }
        public static bool IsWellFormedUriString(string uriString, System.UriKind uriKind) { throw null; }
        [System.ObsoleteAttribute("The method has been deprecated. Please use MakeRelativeUri(Uri uri). https://go.microsoft.com/fwlink/?linkid=14202")]
        public string MakeRelative(System.Uri toUri) { throw null; }
        public System.Uri MakeRelativeUri(System.Uri uri) { throw null; }
        public static bool operator ==(System.Uri uri1, System.Uri uri2) { throw null; }
        public static bool operator !=(System.Uri uri1, System.Uri uri2) { throw null; }
        [System.ObsoleteAttribute("The method has been deprecated. It is not used by the system. https://go.microsoft.com/fwlink/?linkid=14202")]
        protected virtual void Parse() { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public override string ToString() { throw null; }
        public static bool TryCreate(string uriString, System.UriKind uriKind, out System.Uri result) { throw null; }
        public static bool TryCreate(System.Uri baseUri, string relativeUri, out System.Uri result) { throw null; }
        public static bool TryCreate(System.Uri baseUri, System.Uri relativeUri, out System.Uri result) { throw null; }
        [System.ObsoleteAttribute("The method has been deprecated. Please use GetComponents() or static UnescapeDataString() to unescape a Uri component or a string. https://go.microsoft.com/fwlink/?linkid=14202")]
        protected virtual string Unescape(string path) { throw null; }
        public static string UnescapeDataString(string stringToUnescape) { throw null; }
    }
    public partial class UriBuilder
    {
        public UriBuilder() { }
        public UriBuilder(string uri) { }
        public UriBuilder(string schemeName, string hostName) { }
        public UriBuilder(string scheme, string host, int portNumber) { }
        public UriBuilder(string scheme, string host, int port, string pathValue) { }
        public UriBuilder(string scheme, string host, int port, string path, string extraValue) { }
        public UriBuilder(System.Uri uri) { }
        public string Fragment { get { throw null; } set { } }
        public string Host { get { throw null; } set { } }
        public string Password { get { throw null; } set { } }
        public string Path { get { throw null; } set { } }
        public int Port { get { throw null; } set { } }
        public string Query { get { throw null; } set { } }
        public string Scheme { get { throw null; } set { } }
        public System.Uri Uri { get { throw null; } }
        public string UserName { get { throw null; } set { } }
        public override bool Equals(object rparam) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.FlagsAttribute]
    public enum UriComponents
    {
        AbsoluteUri = 127,
        Fragment = 64,
        Host = 4,
        HostAndPort = 132,
        HttpRequestUrl = 61,
        KeepDelimiter = 1073741824,
        NormalizedHost = 256,
        Path = 16,
        PathAndQuery = 48,
        Port = 8,
        Query = 32,
        Scheme = 1,
        SchemeAndServer = 13,
        SerializationInfoString = -2147483648,
        StrongAuthority = 134,
        StrongPort = 128,
        UserInfo = 2,
    }
    public enum UriFormat
    {
        SafeUnescaped = 3,
        Unescaped = 2,
        UriEscaped = 1,
    }
    public partial class UriFormatException : System.FormatException, System.Runtime.Serialization.ISerializable
    {
        public UriFormatException() { }
        protected UriFormatException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public UriFormatException(string textString) { }
        public UriFormatException(string textString, System.Exception e) { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    }
    public enum UriHostNameType
    {
        Basic = 1,
        Dns = 2,
        IPv4 = 3,
        IPv6 = 4,
        Unknown = 0,
    }
    public enum UriKind
    {
        Absolute = 1,
        Relative = 2,
        RelativeOrAbsolute = 0,
    }
    public abstract partial class UriParser
    {
        protected UriParser() { }
        protected virtual string GetComponents(System.Uri uri, System.UriComponents components, System.UriFormat format) { throw null; }
        protected virtual void InitializeAndValidate(System.Uri uri, out System.UriFormatException parsingError) { throw null; }
        protected virtual bool IsBaseOf(System.Uri baseUri, System.Uri relativeUri) { throw null; }
        public static bool IsKnownScheme(string schemeName) { throw null; }
        protected virtual bool IsWellFormedOriginalString(System.Uri uri) { throw null; }
        protected virtual System.UriParser OnNewUri() { throw null; }
        protected virtual void OnRegister(string schemeName, int defaultPort) { }
        public static void Register(System.UriParser uriParser, string schemeName, int defaultPort) { }
        protected virtual string Resolve(System.Uri baseUri, System.Uri relativeUri, out System.UriFormatException parsingError) { throw null; }
    }
    public enum UriPartial
    {
        Authority = 1,
        Path = 2,
        Query = 3,
        Scheme = 0,
    }
    public partial class UriTypeConverter : System.ComponentModel.TypeConverter
    {
        public UriTypeConverter() { }
        public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { throw null; }
        public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { throw null; }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { throw null; }
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { throw null; }
        public override bool IsValid(System.ComponentModel.ITypeDescriptorContext context, object value) { throw null; }
    }
    public partial struct ValueTuple : System.Collections.IStructuralComparable, System.Collections.IStructuralEquatable, System.IComparable, System.IComparable<System.ValueTuple>, System.IEquatable<System.ValueTuple>, System.Runtime.CompilerServices.ITuple
    {
        object System.Runtime.CompilerServices.ITuple.this[int index] { get { throw null; } }
        int System.Runtime.CompilerServices.ITuple.Length { get { throw null; } }
        public int CompareTo(System.ValueTuple other) { throw null; }
        public static System.ValueTuple Create() { throw null; }
        public static System.ValueTuple<T1> Create<T1>(T1 item1) { throw null; }
        public static System.ValueTuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2) { throw null; }
        public static System.ValueTuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3) { throw null; }
        public static System.ValueTuple<T1, T2, T3, T4> Create<T1, T2, T3, T4>(T1 item1, T2 item2, T3 item3, T4 item4) { throw null; }
        public static System.ValueTuple<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5) { throw null; }
        public static System.ValueTuple<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6) { throw null; }
        public static System.ValueTuple<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7) { throw null; }
        public static System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, System.ValueTuple<T8>> Create<T1, T2, T3, T4, T5, T6, T7, T8>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.ValueTuple other) { throw null; }
        public override int GetHashCode() { throw null; }
        int System.Collections.IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) { throw null; }
        bool System.Collections.IStructuralEquatable.Equals(object other, System.Collections.IEqualityComparer comparer) { throw null; }
        int System.Collections.IStructuralEquatable.GetHashCode(System.Collections.IEqualityComparer comparer) { throw null; }
        int System.IComparable.CompareTo(object other) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial struct ValueTuple<T1> : System.Collections.IStructuralComparable, System.Collections.IStructuralEquatable, System.IComparable, System.IComparable<System.ValueTuple<T1>>, System.IEquatable<System.ValueTuple<T1>>, System.Runtime.CompilerServices.ITuple
    {
        public T1 Item1;
        public ValueTuple(T1 item1) { throw null; }
        object System.Runtime.CompilerServices.ITuple.this[int index] { get { throw null; } }
        int System.Runtime.CompilerServices.ITuple.Length { get { throw null; } }
        public int CompareTo(System.ValueTuple<T1> other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.ValueTuple<T1> other) { throw null; }
        public override int GetHashCode() { throw null; }
        int System.Collections.IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) { throw null; }
        bool System.Collections.IStructuralEquatable.Equals(object other, System.Collections.IEqualityComparer comparer) { throw null; }
        int System.Collections.IStructuralEquatable.GetHashCode(System.Collections.IEqualityComparer comparer) { throw null; }
        int System.IComparable.CompareTo(object other) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial struct ValueTuple<T1, T2> : System.Collections.IStructuralComparable, System.Collections.IStructuralEquatable, System.IComparable, System.IComparable<System.ValueTuple<T1, T2>>, System.IEquatable<System.ValueTuple<T1, T2>>, System.Runtime.CompilerServices.ITuple
    {
        public T1 Item1;
        public T2 Item2;
        public ValueTuple(T1 item1, T2 item2) { throw null; }
        object System.Runtime.CompilerServices.ITuple.this[int index] { get { throw null; } }
        int System.Runtime.CompilerServices.ITuple.Length { get { throw null; } }
        public int CompareTo(System.ValueTuple<T1, T2> other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.ValueTuple<T1, T2> other) { throw null; }
        public override int GetHashCode() { throw null; }
        int System.Collections.IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) { throw null; }
        bool System.Collections.IStructuralEquatable.Equals(object other, System.Collections.IEqualityComparer comparer) { throw null; }
        int System.Collections.IStructuralEquatable.GetHashCode(System.Collections.IEqualityComparer comparer) { throw null; }
        int System.IComparable.CompareTo(object other) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial struct ValueTuple<T1, T2, T3> : System.Collections.IStructuralComparable, System.Collections.IStructuralEquatable, System.IComparable, System.IComparable<System.ValueTuple<T1, T2, T3>>, System.IEquatable<System.ValueTuple<T1, T2, T3>>, System.Runtime.CompilerServices.ITuple
    {
        public T1 Item1;
        public T2 Item2;
        public T3 Item3;
        public ValueTuple(T1 item1, T2 item2, T3 item3) { throw null; }
        object System.Runtime.CompilerServices.ITuple.this[int index] { get { throw null; } }
        int System.Runtime.CompilerServices.ITuple.Length { get { throw null; } }
        public int CompareTo(System.ValueTuple<T1, T2, T3> other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.ValueTuple<T1, T2, T3> other) { throw null; }
        public override int GetHashCode() { throw null; }
        int System.Collections.IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) { throw null; }
        bool System.Collections.IStructuralEquatable.Equals(object other, System.Collections.IEqualityComparer comparer) { throw null; }
        int System.Collections.IStructuralEquatable.GetHashCode(System.Collections.IEqualityComparer comparer) { throw null; }
        int System.IComparable.CompareTo(object other) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial struct ValueTuple<T1, T2, T3, T4> : System.Collections.IStructuralComparable, System.Collections.IStructuralEquatable, System.IComparable, System.IComparable<System.ValueTuple<T1, T2, T3, T4>>, System.IEquatable<System.ValueTuple<T1, T2, T3, T4>>, System.Runtime.CompilerServices.ITuple
    {
        public T1 Item1;
        public T2 Item2;
        public T3 Item3;
        public T4 Item4;
        public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4) { throw null; }
        object System.Runtime.CompilerServices.ITuple.this[int index] { get { throw null; } }
        int System.Runtime.CompilerServices.ITuple.Length { get { throw null; } }
        public int CompareTo(System.ValueTuple<T1, T2, T3, T4> other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.ValueTuple<T1, T2, T3, T4> other) { throw null; }
        public override int GetHashCode() { throw null; }
        int System.Collections.IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) { throw null; }
        bool System.Collections.IStructuralEquatable.Equals(object other, System.Collections.IEqualityComparer comparer) { throw null; }
        int System.Collections.IStructuralEquatable.GetHashCode(System.Collections.IEqualityComparer comparer) { throw null; }
        int System.IComparable.CompareTo(object other) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial struct ValueTuple<T1, T2, T3, T4, T5> : System.Collections.IStructuralComparable, System.Collections.IStructuralEquatable, System.IComparable, System.IComparable<System.ValueTuple<T1, T2, T3, T4, T5>>, System.IEquatable<System.ValueTuple<T1, T2, T3, T4, T5>>, System.Runtime.CompilerServices.ITuple
    {
        public T1 Item1;
        public T2 Item2;
        public T3 Item3;
        public T4 Item4;
        public T5 Item5;
        public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5) { throw null; }
        object System.Runtime.CompilerServices.ITuple.this[int index] { get { throw null; } }
        int System.Runtime.CompilerServices.ITuple.Length { get { throw null; } }
        public int CompareTo(System.ValueTuple<T1, T2, T3, T4, T5> other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.ValueTuple<T1, T2, T3, T4, T5> other) { throw null; }
        public override int GetHashCode() { throw null; }
        int System.Collections.IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) { throw null; }
        bool System.Collections.IStructuralEquatable.Equals(object other, System.Collections.IEqualityComparer comparer) { throw null; }
        int System.Collections.IStructuralEquatable.GetHashCode(System.Collections.IEqualityComparer comparer) { throw null; }
        int System.IComparable.CompareTo(object other) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial struct ValueTuple<T1, T2, T3, T4, T5, T6> : System.Collections.IStructuralComparable, System.Collections.IStructuralEquatable, System.IComparable, System.IComparable<System.ValueTuple<T1, T2, T3, T4, T5, T6>>, System.IEquatable<System.ValueTuple<T1, T2, T3, T4, T5, T6>>, System.Runtime.CompilerServices.ITuple
    {
        public T1 Item1;
        public T2 Item2;
        public T3 Item3;
        public T4 Item4;
        public T5 Item5;
        public T6 Item6;
        public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6) { throw null; }
        object System.Runtime.CompilerServices.ITuple.this[int index] { get { throw null; } }
        int System.Runtime.CompilerServices.ITuple.Length { get { throw null; } }
        public int CompareTo(System.ValueTuple<T1, T2, T3, T4, T5, T6> other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.ValueTuple<T1, T2, T3, T4, T5, T6> other) { throw null; }
        public override int GetHashCode() { throw null; }
        int System.Collections.IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) { throw null; }
        bool System.Collections.IStructuralEquatable.Equals(object other, System.Collections.IEqualityComparer comparer) { throw null; }
        int System.Collections.IStructuralEquatable.GetHashCode(System.Collections.IEqualityComparer comparer) { throw null; }
        int System.IComparable.CompareTo(object other) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial struct ValueTuple<T1, T2, T3, T4, T5, T6, T7> : System.Collections.IStructuralComparable, System.Collections.IStructuralEquatable, System.IComparable, System.IComparable<System.ValueTuple<T1, T2, T3, T4, T5, T6, T7>>, System.IEquatable<System.ValueTuple<T1, T2, T3, T4, T5, T6, T7>>, System.Runtime.CompilerServices.ITuple
    {
        public T1 Item1;
        public T2 Item2;
        public T3 Item3;
        public T4 Item4;
        public T5 Item5;
        public T6 Item6;
        public T7 Item7;
        public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7) { throw null; }
        object System.Runtime.CompilerServices.ITuple.this[int index] { get { throw null; } }
        int System.Runtime.CompilerServices.ITuple.Length { get { throw null; } }
        public int CompareTo(System.ValueTuple<T1, T2, T3, T4, T5, T6, T7> other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.ValueTuple<T1, T2, T3, T4, T5, T6, T7> other) { throw null; }
        public override int GetHashCode() { throw null; }
        int System.Collections.IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) { throw null; }
        bool System.Collections.IStructuralEquatable.Equals(object other, System.Collections.IEqualityComparer comparer) { throw null; }
        int System.Collections.IStructuralEquatable.GetHashCode(System.Collections.IEqualityComparer comparer) { throw null; }
        int System.IComparable.CompareTo(object other) { throw null; }
        public override string ToString() { throw null; }
    }    
    public partial struct ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> : System.Collections.IStructuralComparable, System.Collections.IStructuralEquatable, System.IComparable, System.IComparable<System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>, System.IEquatable<System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>, System.Runtime.CompilerServices.ITuple where TRest : struct
    {
        public T1 Item1;
        public T2 Item2;
        public T3 Item3;
        public T4 Item4;
        public T5 Item5;
        public T6 Item6;
        public T7 Item7;
        public TRest Rest;
        public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, TRest rest) { throw null; }
        object System.Runtime.CompilerServices.ITuple.this[int index] { get { throw null; } }
        int System.Runtime.CompilerServices.ITuple.Length { get { throw null; } }
        public int CompareTo(System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> other) { throw null; }
        public override int GetHashCode() { throw null; }
        int System.Collections.IStructuralComparable.CompareTo(object other, System.Collections.IComparer comparer) { throw null; }
        bool System.Collections.IStructuralEquatable.Equals(object other, System.Collections.IEqualityComparer comparer) { throw null; }
        int System.Collections.IStructuralEquatable.GetHashCode(System.Collections.IEqualityComparer comparer) { throw null; }
        int System.IComparable.CompareTo(object other) { throw null; }
        public override string ToString() { throw null; }
    }
    public abstract partial class ValueType
    {
        protected ValueType() { }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public sealed partial class Version : System.ICloneable, System.IComparable, System.IComparable<System.Version>, System.IEquatable<System.Version>
    {
        public Version() { }
        public Version(int major, int minor) { }
        public Version(int major, int minor, int build) { }
        public Version(int major, int minor, int build, int revision) { }
        public Version(string version) { }
        public int Build { get { throw null; } }
        public int Major { get { throw null; } }
        public short MajorRevision { get { throw null; } }
        public int Minor { get { throw null; } }
        public short MinorRevision { get { throw null; } }
        public int Revision { get { throw null; } }
        public object Clone() { throw null; }
        public int CompareTo(object version) { throw null; }
        public int CompareTo(System.Version value) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Version obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Version v1, System.Version v2) { throw null; }
        public static bool operator >(System.Version v1, System.Version v2) { throw null; }
        public static bool operator >=(System.Version v1, System.Version v2) { throw null; }
        public static bool operator !=(System.Version v1, System.Version v2) { throw null; }
        public static bool operator <(System.Version v1, System.Version v2) { throw null; }
        public static bool operator <=(System.Version v1, System.Version v2) { throw null; }
        public static System.Version Parse(System.ReadOnlySpan<char> input) { throw null; }
        public static System.Version Parse(string input) { throw null; }
        public override string ToString() { throw null; }
        public string ToString(int fieldCount) { throw null; }
        public bool TryFormat(System.Span<char> destination, int fieldCount, out int charsWritten) { throw null; }
        public bool TryFormat(System.Span<char> destination, out int charsWritten) { throw null; }
        public static bool TryParse(System.ReadOnlySpan<char> input, out System.Version result) { throw null; }
        public static bool TryParse(string input, out System.Version result) { throw null; }
    }
    public partial struct Void
    {
    }
    public partial class WeakReference : System.Runtime.Serialization.ISerializable
    {
        public WeakReference(object target) { }
        public WeakReference(object target, bool trackResurrection) { }
        protected WeakReference(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public virtual bool IsAlive { get { throw null; } }
        public virtual object Target { get { throw null; } set { } }
        public virtual bool TrackResurrection { get { throw null; } }
        ~WeakReference() { }
        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public sealed partial class WeakReference<T> : System.Runtime.Serialization.ISerializable where T : class
    {
        public WeakReference(T target) { }
        public WeakReference(T target, bool trackResurrection) { }
        public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public void SetTarget(T target) { }
        public bool TryGetTarget(out T target) { throw null; }
    }
}
