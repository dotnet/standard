# System

``` diff
 namespace System {
+    public interface _AppDomain {
+        string BaseDirectory { get; }
+        string DynamicDirectory { get; }
+        Evidence Evidence { get; }
+        string FriendlyName { get; }
+        string RelativeSearchPath { get; }
+        bool ShadowCopyFiles { get; }
+        event AssemblyLoadEventHandler AssemblyLoad;
+        event ResolveEventHandler AssemblyResolve;
+        event EventHandler DomainUnload;
+        event EventHandler ProcessExit;
+        event ResolveEventHandler ResourceResolve;
+        event ResolveEventHandler TypeResolve;
+        event UnhandledExceptionEventHandler UnhandledException;
+        void AppendPrivatePath(string path);
+        void ClearPrivatePath();
+        void ClearShadowCopyPath();
+        ObjectHandle CreateInstance(string assemblyName, string typeName);
+        ObjectHandle CreateInstance(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes);
+        ObjectHandle CreateInstance(string assemblyName, string typeName, object[] activationAttributes);
+        ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName);
+        ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes);
+        ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, object[] activationAttributes);
+        AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access);
+        AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions);
+        AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, Evidence evidence);
+        AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, Evidence evidence, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions);
+        AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir);
+        AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions);
+        AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, Evidence evidence);
+        AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, Evidence evidence, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions);
+        AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, Evidence evidence, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions, bool isSynchronized);
+        void DoCallBack(CrossAppDomainDelegate theDelegate);
+        bool Equals(object other);
+        int ExecuteAssembly(string assemblyFile);
+        int ExecuteAssembly(string assemblyFile, Evidence assemblySecurity);
+        int ExecuteAssembly(string assemblyFile, Evidence assemblySecurity, string[] args);
+        Assembly[] GetAssemblies();
+        object GetData(string name);
+        int GetHashCode();
+        void GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        object GetLifetimeService();
+        Type GetType();
+        void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void GetTypeInfoCount(out uint pcTInfo);
+        object InitializeLifetimeService();
+        void Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+        Assembly Load(byte[] rawAssembly);
+        Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore);
+        Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore, Evidence securityEvidence);
+        Assembly Load(AssemblyName assemblyRef);
+        Assembly Load(AssemblyName assemblyRef, Evidence assemblySecurity);
+        Assembly Load(string assemblyString);
+        Assembly Load(string assemblyString, Evidence assemblySecurity);
+        void SetAppDomainPolicy(PolicyLevel domainPolicy);
+        void SetCachePath(string s);
+        void SetData(string name, object data);
+        void SetPrincipalPolicy(PrincipalPolicy policy);
+        void SetShadowCopyPath(string s);
+        void SetThreadPrincipal(IPrincipal principal);
+        string ToString();
+    }
+    public sealed class ActivationContext : IDisposable, ISerializable {
+        public byte[] ApplicationManifestBytes { get; }
+        public byte[] DeploymentManifestBytes { get; }
+        public ActivationContext.ContextForm Form { get; }
+        public ApplicationIdentity Identity { get; }
+        public static ActivationContext CreatePartialActivationContext(ApplicationIdentity identity);
+        public static ActivationContext CreatePartialActivationContext(ApplicationIdentity identity, string[] manifestPaths);
+        public void Dispose();
+        ~ActivationContext();
+        void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context);
+        public enum ContextForm {
+            Loose = 0,
+            StoreBounded = 1,
+        }
+    }
-    public static class Activator {
+    public sealed class Activator : _Activator {
+        public static ObjectHandle CreateComInstanceFrom(string assemblyName, string typeName);
+        public static ObjectHandle CreateComInstanceFrom(string assemblyName, string typeName, byte[] hashValue, AssemblyHashAlgorithm hashAlgorithm);
+        public static ObjectHandle CreateInstance(ActivationContext activationContext);
+        public static ObjectHandle CreateInstance(ActivationContext activationContext, string[] activationCustomData);
+        public static ObjectHandle CreateInstance(AppDomain domain, string assemblyName, string typeName);
+        public static ObjectHandle CreateInstance(AppDomain domain, string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes);
+        public static ObjectHandle CreateInstance(AppDomain domain, string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes);
+        public static ObjectHandle CreateInstance(string assemblyName, string typeName);
+        public static ObjectHandle CreateInstance(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes);
+        public static ObjectHandle CreateInstance(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityInfo);
+        public static ObjectHandle CreateInstance(string assemblyName, string typeName, object[] activationAttributes);
+        public static ObjectHandle CreateInstanceFrom(AppDomain domain, string assemblyFile, string typeName);
+        public static ObjectHandle CreateInstanceFrom(AppDomain domain, string assemblyFile, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes);
+        public static ObjectHandle CreateInstanceFrom(AppDomain domain, string assemblyFile, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes);
+        public static ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName);
+        public static ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes);
+        public static ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityInfo);
+        public static ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, object[] activationAttributes);
+        public static object GetObject(Type type, string url);
+        public static object GetObject(Type type, string url, object state);
+        void System.Runtime.InteropServices._Activator.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void System.Runtime.InteropServices._Activator.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void System.Runtime.InteropServices._Activator.GetTypeInfoCount(out uint pcTInfo);
+        void System.Runtime.InteropServices._Activator.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
     }
     public static class AppContext {
-        public static string TargetFrameworkName { get; }

-        public static object GetData(string name);

     }
-    public sealed class AppDomain : MarshalByRefObject {
+    public sealed class AppDomain : MarshalByRefObject, IEvidenceFactory, _AppDomain {
+        public ActivationContext ActivationContext { get; }
+        public ApplicationIdentity ApplicationIdentity { get; }
+        public ApplicationTrust ApplicationTrust { get; }
+        public AppDomainManager DomainManager { get; }
+        public Evidence Evidence { get; }
+        public PermissionSet PermissionSet { get; }
+        public AppDomainSetup SetupInformation { get; }
+        public ObjectHandle CreateComInstanceFrom(string assemblyName, string typeName);
+        public ObjectHandle CreateComInstanceFrom(string assemblyFile, string typeName, byte[] hashValue, AssemblyHashAlgorithm hashAlgorithm);
+        public static AppDomain CreateDomain(string friendlyName, Evidence securityInfo);
+        public static AppDomain CreateDomain(string friendlyName, Evidence securityInfo, AppDomainSetup info);
+        public static AppDomain CreateDomain(string friendlyName, Evidence securityInfo, AppDomainSetup info, PermissionSet grantSet, params StrongName[] fullTrustAssemblies);
+        public static AppDomain CreateDomain(string friendlyName, Evidence securityInfo, string appBasePath, string appRelativeSearchPath, bool shadowCopyFiles);
+        public static AppDomain CreateDomain(string friendlyName, Evidence securityInfo, string appBasePath, string appRelativeSearchPath, bool shadowCopyFiles, AppDomainInitializer adInit, string[] adInitArgs);
+        public ObjectHandle CreateInstance(string assemblyName, string typeName);
+        public ObjectHandle CreateInstance(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes);
+        public ObjectHandle CreateInstance(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes);
+        public ObjectHandle CreateInstance(string assemblyName, string typeName, object[] activationAttributes);
+        public object CreateInstanceAndUnwrap(string assemblyName, string typeName);
+        public object CreateInstanceAndUnwrap(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes);
+        public object CreateInstanceAndUnwrap(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes);
+        public object CreateInstanceAndUnwrap(string assemblyName, string typeName, object[] activationAttributes);
+        public ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName);
+        public ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes);
+        public ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes);
+        public ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, object[] activationAttributes);
+        public object CreateInstanceFromAndUnwrap(string assemblyName, string typeName);
+        public object CreateInstanceFromAndUnwrap(string assemblyFile, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes);
+        public object CreateInstanceFromAndUnwrap(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes);
+        public object CreateInstanceFromAndUnwrap(string assemblyName, string typeName, object[] activationAttributes);
+        public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access);
+        public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, IEnumerable<CustomAttributeBuilder> assemblyAttributes);
+        public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, IEnumerable<CustomAttributeBuilder> assemblyAttributes, SecurityContextSource securityContextSource);
+        public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions);
+        public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, Evidence evidence);
+        public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, Evidence evidence, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions);
+        public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir);
+        public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, bool isSynchronized, IEnumerable<CustomAttributeBuilder> assemblyAttributes);
+        public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions);
+        public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, Evidence evidence);
+        public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, Evidence evidence, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions);
+        public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, Evidence evidence, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions, bool isSynchronized);
+        public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, Evidence evidence, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions, bool isSynchronized, IEnumerable<CustomAttributeBuilder> assemblyAttributes);
+        public void DoCallBack(CrossAppDomainDelegate callBackDelegate);
+        public int ExecuteAssembly(string assemblyFile, Evidence assemblySecurity);
+        public int ExecuteAssembly(string assemblyFile, Evidence assemblySecurity, string[] args);
+        public int ExecuteAssembly(string assemblyFile, Evidence assemblySecurity, string[] args, byte[] hashValue, AssemblyHashAlgorithm hashAlgorithm);
+        public int ExecuteAssemblyByName(AssemblyName assemblyName, Evidence assemblySecurity, params string[] args);
+        public int ExecuteAssemblyByName(string assemblyName, Evidence assemblySecurity);
+        public int ExecuteAssemblyByName(string assemblyName, Evidence assemblySecurity, params string[] args);
-        public static int GetCurrentThreadId();
+        public static extern int GetCurrentThreadId();
+        public Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore, Evidence securityEvidence);
+        public Assembly Load(AssemblyName assemblyRef, Evidence assemblySecurity);
+        public Assembly Load(string assemblyString, Evidence assemblySecurity);
+        public void SetAppDomainPolicy(PolicyLevel domainPolicy);
+        public void SetData(string name, object data, IPermission permission);
+        void System._AppDomain.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void System._AppDomain.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void System._AppDomain.GetTypeInfoCount(out uint pcTInfo);
+        void System._AppDomain.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
     }
+    public delegate void AppDomainInitializer(string[] args);
+    public class AppDomainManager : MarshalByRefObject {
+        public AppDomainManager();
+        public virtual ApplicationActivator ApplicationActivator { get; }
+        public virtual Assembly EntryAssembly { get; }
+        public virtual HostExecutionContextManager HostExecutionContextManager { get; }
+        public virtual HostSecurityManager HostSecurityManager { get; }
+        public AppDomainManagerInitializationOptions InitializationFlags { get; set; }
+        public virtual bool CheckSecuritySettings(SecurityState state);
+        public virtual AppDomain CreateDomain(string friendlyName, Evidence securityInfo, AppDomainSetup appDomainInfo);
+        protected static AppDomain CreateDomainHelper(string friendlyName, Evidence securityInfo, AppDomainSetup appDomainInfo);
+        public virtual void InitializeNewDomain(AppDomainSetup appDomainInfo);
+    }
+    public enum AppDomainManagerInitializationOptions {
+        None = 0,
+        RegisterWithHost = 1,
+    }
+    public sealed class AppDomainSetup : IAppDomainSetup {
+        public AppDomainSetup();
+        public AppDomainSetup(ActivationContext activationContext);
+        public AppDomainSetup(ActivationArguments activationArguments);
+        public ActivationArguments ActivationArguments { get; set; }
+        public AppDomainInitializer AppDomainInitializer { get; set; }
+        public string[] AppDomainInitializerArguments { get; set; }
+        public string AppDomainManagerAssembly { get; set; }
+        public string AppDomainManagerType { get; set; }
+        public string ApplicationBase { get; set; }
+        public string ApplicationName { get; set; }
+        public ApplicationTrust ApplicationTrust { get; set; }
+        public string CachePath { get; set; }
+        public string ConfigurationFile { get; set; }
+        public bool DisallowApplicationBaseProbing { get; set; }
+        public bool DisallowBindingRedirects { get; set; }
+        public bool DisallowCodeDownload { get; set; }
+        public bool DisallowPublisherPolicy { get; set; }
+        public string DynamicBase { get; set; }
+        public string LicenseFile { get; set; }
+        public LoaderOptimization LoaderOptimization { get; set; }
+        public string[] PartialTrustVisibleAssemblies { get; set; }
+        public string PrivateBinPath { get; set; }
+        public string PrivateBinPathProbe { get; set; }
+        public bool SandboxInterop { get; set; }
+        public string ShadowCopyDirectories { get; set; }
+        public string ShadowCopyFiles { get; set; }
+        public string TargetFrameworkName { get; set; }
+        public byte[] GetConfigurationBytes();
+        public void SetCompatibilitySwitches(IEnumerable<string> switches);
+        public void SetConfigurationBytes(byte[] value);
+        public void SetNativeFunction(string functionName, int functionVersion, IntPtr functionPointer);
+    }
+    public sealed class ApplicationIdentity : ISerializable {
+        public ApplicationIdentity(string applicationIdentityFullName);
+        public string CodeBase { get; }
+        public string FullName { get; }
+        void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context);
+        public override string ToString();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct ArgIterator {
+        public ArgIterator(RuntimeArgumentHandle arglist);
+        public unsafe ArgIterator(RuntimeArgumentHandle arglist, void* ptr);
+        public void End();
+        public override bool Equals(object o);
+        public override int GetHashCode();
+        public TypedReference GetNextArg();
+        public TypedReference GetNextArg(RuntimeTypeHandle rth);
+        public RuntimeTypeHandle GetNextArgType();
+        public int GetRemainingCount();
+    }
-    public abstract class Attribute {
+    public abstract class Attribute : _Attribute {
+        void System.Runtime.InteropServices._Attribute.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void System.Runtime.InteropServices._Attribute.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void System.Runtime.InteropServices._Attribute.GetTypeInfoCount(out uint pcTInfo);
+        void System.Runtime.InteropServices._Attribute.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
     }
     public static class Console {
+        public static void Write(string format, object arg0, object arg1, object arg2, object arg3, __arglist);
+        public static void WriteLine(string format, object arg0, object arg1, object arg2, object arg3, __arglist);
     }
+    public delegate void CrossAppDomainDelegate();
-    public class Exception : ISerializable
+    public class Exception : ISerializable, _Exception
+    public interface IAppDomainSetup {
+        string ApplicationBase { get; set; }
+        string ApplicationName { get; set; }
+        string CachePath { get; set; }
+        string ConfigurationFile { get; set; }
+        string DynamicBase { get; set; }
+        string LicenseFile { get; set; }
+        string PrivateBinPath { get; set; }
+        string PrivateBinPathProbe { get; set; }
+        string ShadowCopyDirectories { get; set; }
+        string ShadowCopyFiles { get; set; }
+    }
     public sealed class LocalDataStoreSlot {
+        ~LocalDataStoreSlot();
     }
     public abstract class MarshalByRefObject {
+        public virtual ObjRef CreateObjRef(Type requestedType);
     }
     public sealed class String : ICloneable, IComparable, IComparable<string>, IConvertible, IEnumerable, IEnumerable<char>, IEquatable<string> {
+        public static String Concat(object arg0, object arg1, object arg2, object arg3, __arglist);
     }
-    public static class StringNormalizationExtensions {
 {
-        public static bool IsNormalized(this string value);

-        public static bool IsNormalized(this string value, NormalizationForm normalizationForm);

-        public static string Normalize(this string value);

-        public static string Normalize(this string value, NormalizationForm normalizationForm);

-    }
-    public static class TupleExtensions {
 {
-        public static void Deconstruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16, T17, T18, T19, T20, T21>>> value, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9, out T10 item10, out T11 item11, out T12 item12, out T13 item13, out T14 item14, out T15 item15, out T16 item16, out T17 item17, out T18 item18, out T19 item19, out T20 item20, out T21 item21);

-        public static void Deconstruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16, T17, T18, T19, T20>>> value, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9, out T10 item10, out T11 item11, out T12 item12, out T13 item13, out T14 item14, out T15 item15, out T16 item16, out T17 item17, out T18 item18, out T19 item19, out T20 item20);

-        public static void Deconstruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16, T17, T18, T19>>> value, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9, out T10 item10, out T11 item11, out T12 item12, out T13 item13, out T14 item14, out T15 item15, out T16 item16, out T17 item17, out T18 item18, out T19 item19);

-        public static void Deconstruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16, T17, T18>>> value, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9, out T10 item10, out T11 item11, out T12 item12, out T13 item13, out T14 item14, out T15 item15, out T16 item16, out T17 item17, out T18 item18);

-        public static void Deconstruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16, T17>>> value, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9, out T10 item10, out T11 item11, out T12 item12, out T13 item13, out T14 item14, out T15 item15, out T16 item16, out T17 item17);

-        public static void Deconstruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> value, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9, out T10 item10, out T11 item11, out T12 item12, out T13 item13, out T14 item14, out T15 item15, out T16 item16);

-        public static void Deconstruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> value, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9, out T10 item10, out T11 item11, out T12 item12, out T13 item13, out T14 item14, out T15 item15);

-        public static void Deconstruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> value, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9, out T10 item10, out T11 item11, out T12 item12, out T13 item13, out T14 item14);

-        public static void Deconstruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> value, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9, out T10 item10, out T11 item11, out T12 item12, out T13 item13);

-        public static void Deconstruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> value, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9, out T10 item10, out T11 item11, out T12 item12);

-        public static void Deconstruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> value, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9, out T10 item10, out T11 item11);

-        public static void Deconstruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> value, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9, out T10 item10);

-        public static void Deconstruct<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> value, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8, out T9 item9);

-        public static void Deconstruct<T1, T2, T3, T4, T5, T6, T7, T8>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> value, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7, out T8 item8);

-        public static void Deconstruct<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7);

-        public static void Deconstruct<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6);

-        public static void Deconstruct<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value, out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5);

-        public static void Deconstruct<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value, out T1 item1, out T2 item2, out T3 item3, out T4 item4);

-        public static void Deconstruct<T1, T2, T3>(this Tuple<T1, T2, T3> value, out T1 item1, out T2 item2, out T3 item3);

-        public static void Deconstruct<T1, T2>(this Tuple<T1, T2> value, out T1 item1, out T2 item2);

-        public static void Deconstruct<T1>(this Tuple<T1> value, out T1 item1);

-        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16, T17, T18, T19, T20, T21>>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(this ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple<T8, T9, T10, T11, T12, T13, T14, ValueTuple<T15, T16, T17, T18, T19, T20, T21>>> value);

-        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16, T17, T18, T19, T20>>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(this ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple<T8, T9, T10, T11, T12, T13, T14, ValueTuple<T15, T16, T17, T18, T19, T20>>> value);

-        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16, T17, T18, T19>>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(this ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple<T8, T9, T10, T11, T12, T13, T14, ValueTuple<T15, T16, T17, T18, T19>>> value);

-        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16, T17, T18>>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(this ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple<T8, T9, T10, T11, T12, T13, T14, ValueTuple<T15, T16, T17, T18>>> value);

-        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16, T17>>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(this ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple<T8, T9, T10, T11, T12, T13, T14, ValueTuple<T15, T16, T17>>> value);

-        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple<T8, T9, T10, T11, T12, T13, T14, ValueTuple<T15, T16>>> value);

-        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple<T8, T9, T10, T11, T12, T13, T14, ValueTuple<T15>>> value);

-        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple<T8, T9, T10, T11, T12, T13, T14>> value);

-        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple<T8, T9, T10, T11, T12, T13>> value);

-        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple<T8, T9, T10, T11, T12>> value);

-        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple<T8, T9, T10, T11>> value);

-        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple<T8, T9, T10>> value);

-        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple<T8, T9>> value);

-        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8>(this ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple<T8>> value);

-        public static Tuple<T1, T2, T3, T4, T5, T6, T7> ToTuple<T1, T2, T3, T4, T5, T6, T7>(this ValueTuple<T1, T2, T3, T4, T5, T6, T7> value);

-        public static Tuple<T1, T2, T3, T4, T5, T6> ToTuple<T1, T2, T3, T4, T5, T6>(this ValueTuple<T1, T2, T3, T4, T5, T6> value);

-        public static Tuple<T1, T2, T3, T4, T5> ToTuple<T1, T2, T3, T4, T5>(this ValueTuple<T1, T2, T3, T4, T5> value);

-        public static Tuple<T1, T2, T3, T4> ToTuple<T1, T2, T3, T4>(this ValueTuple<T1, T2, T3, T4> value);

-        public static Tuple<T1, T2, T3> ToTuple<T1, T2, T3>(this ValueTuple<T1, T2, T3> value);

-        public static Tuple<T1, T2> ToTuple<T1, T2>(this ValueTuple<T1, T2> value);

-        public static Tuple<T1> ToTuple<T1>(this ValueTuple<T1> value);

-        public static ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple<T8, T9, T10, T11, T12, T13, T14, ValueTuple<T15, T16, T17, T18, T19, T20, T21>>> ToValueTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16, T17, T18, T19, T20, T21>>> value);

-        public static ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple<T8, T9, T10, T11, T12, T13, T14, ValueTuple<T15, T16, T17, T18, T19, T20>>> ToValueTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16, T17, T18, T19, T20>>> value);

-        public static ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple<T8, T9, T10, T11, T12, T13, T14, ValueTuple<T15, T16, T17, T18, T19>>> ToValueTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16, T17, T18, T19>>> value);

-        public static ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple<T8, T9, T10, T11, T12, T13, T14, ValueTuple<T15, T16, T17, T18>>> ToValueTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16, T17, T18>>> value);

-        public static ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple<T8, T9, T10, T11, T12, T13, T14, ValueTuple<T15, T16, T17>>> ToValueTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16, T17>>> value);

-        public static ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple<T8, T9, T10, T11, T12, T13, T14, ValueTuple<T15, T16>>> ToValueTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> value);

-        public static ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple<T8, T9, T10, T11, T12, T13, T14, ValueTuple<T15>>> ToValueTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> value);

-        public static ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple<T8, T9, T10, T11, T12, T13, T14>> ToValueTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> value);

-        public static ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple<T8, T9, T10, T11, T12, T13>> ToValueTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> value);

-        public static ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple<T8, T9, T10, T11, T12>> ToValueTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> value);

-        public static ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple<T8, T9, T10, T11>> ToValueTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> value);

-        public static ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple<T8, T9, T10>> ToValueTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> value);

-        public static ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple<T8, T9>> ToValueTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> value);

-        public static ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple<T8>> ToValueTuple<T1, T2, T3, T4, T5, T6, T7, T8>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> value);

-        public static ValueTuple<T1, T2, T3, T4, T5, T6, T7> ToValueTuple<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> value);

-        public static ValueTuple<T1, T2, T3, T4, T5, T6> ToValueTuple<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> value);

-        public static ValueTuple<T1, T2, T3, T4, T5> ToValueTuple<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> value);

-        public static ValueTuple<T1, T2, T3, T4> ToValueTuple<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> value);

-        public static ValueTuple<T1, T2, T3> ToValueTuple<T1, T2, T3>(this Tuple<T1, T2, T3> value);

-        public static ValueTuple<T1, T2> ToValueTuple<T1, T2>(this Tuple<T1, T2> value);

-        public static ValueTuple<T1> ToValueTuple<T1>(this Tuple<T1> value);

-    }
-    public abstract class Type : MemberInfo, IReflect {
+    public abstract class Type : MemberInfo, IReflect, _Type {
+        void System.Runtime.InteropServices._Type.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void System.Runtime.InteropServices._Type.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void System.Runtime.InteropServices._Type.GetTypeInfoCount(out uint pcTInfo);
+        void System.Runtime.InteropServices._Type.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
     }
+    public enum UriIdnScope {
+        All = 2,
+        AllExceptIntranet = 1,
+        None = 0,
+    }
+    public class UriTemplate {
+        public UriTemplate(string template);
+        public UriTemplate(string template, bool ignoreTrailingSlash);
+        public UriTemplate(string template, bool ignoreTrailingSlash, IDictionary<string, string> additionalDefaults);
+        public UriTemplate(string template, IDictionary<string, string> additionalDefaults);
+        public IDictionary<string, string> Defaults { get; }
+        public bool IgnoreTrailingSlash { get; }
+        public ReadOnlyCollection<string> PathSegmentVariableNames { get; }
+        public ReadOnlyCollection<string> QueryValueVariableNames { get; }
+        public Uri BindByName(Uri baseAddress, IDictionary<string, string> parameters);
+        public Uri BindByName(Uri baseAddress, IDictionary<string, string> parameters, bool omitDefaults);
+        public Uri BindByName(Uri baseAddress, NameValueCollection parameters);
+        public Uri BindByName(Uri baseAddress, NameValueCollection parameters, bool omitDefaults);
+        public Uri BindByPosition(Uri baseAddress, params string[] values);
+        public bool IsEquivalentTo(UriTemplate other);
+        public UriTemplateMatch Match(Uri baseAddress, Uri candidate);
+        public override string ToString();
+    }
+    public class UriTemplateEquivalenceComparer : IEqualityComparer<UriTemplate> {
+        public UriTemplateEquivalenceComparer();
+        public bool Equals(UriTemplate x, UriTemplate y);
+        public int GetHashCode(UriTemplate obj);
+    }
+    public class UriTemplateMatch {
+        public UriTemplateMatch();
+        public Uri BaseUri { get; set; }
+        public NameValueCollection BoundVariables { get; }
+        public object Data { get; set; }
+        public NameValueCollection QueryParameters { get; }
+        public Collection<string> RelativePathSegments { get; }
+        public Uri RequestUri { get; set; }
+        public UriTemplate Template { get; set; }
+        public Collection<string> WildcardPathSegments { get; }
+    }
+    public class UriTemplateMatchException : SystemException {
+        public UriTemplateMatchException();
+        protected UriTemplateMatchException(SerializationInfo info, StreamingContext context);
+        public UriTemplateMatchException(string message);
+        public UriTemplateMatchException(string message, Exception innerException);
+    }
+    public class UriTemplateTable {
+        public UriTemplateTable();
+        public UriTemplateTable(IEnumerable<KeyValuePair<UriTemplate, object>> keyValuePairs);
+        public UriTemplateTable(Uri baseAddress);
+        public UriTemplateTable(Uri baseAddress, IEnumerable<KeyValuePair<UriTemplate, object>> keyValuePairs);
+        public Uri BaseAddress { get; set; }
+        public bool IsReadOnly { get; }
+        public IList<KeyValuePair<UriTemplate, object>> KeyValuePairs { get; }
+        public Uri OriginalBaseAddress { get; }
+        public void MakeReadOnly(bool allowDuplicateEquivalentUriTemplates);
+        public Collection<UriTemplateMatch> Match(Uri uri);
+        public UriTemplateMatch MatchSingle(Uri uri);
+    }
-    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Size=1)]
-    public struct ValueTuple : IComparable, IComparable<ValueTuple>, IEquatable<ValueTuple>, IStructuralComparable, IStructuralEquatable {
 {
-        public int CompareTo(ValueTuple other);

-        public static ValueTuple Create();

-        public static ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple<T8>> Create<T1, T2, T3, T4, T5, T6, T7, T8>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8);

-        public static ValueTuple<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7);

-        public static ValueTuple<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6);

-        public static ValueTuple<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5);

-        public static ValueTuple<T1, T2, T3, T4> Create<T1, T2, T3, T4>(T1 item1, T2 item2, T3 item3, T4 item4);

-        public static ValueTuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3);

-        public static ValueTuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2);

-        public static ValueTuple<T1> Create<T1>(T1 item1);

-        public override bool Equals(object obj);

-        public bool Equals(ValueTuple other);

-        public override int GetHashCode();

-        int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer);

-        bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer);

-        int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer);

-        int System.IComparable.CompareTo(object other);

-        public override string ToString();

-    }
-    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
-    public struct ValueTuple<T1> : IComparable, IComparable<ValueTuple<T1>>, IEquatable<ValueTuple<T1>>, IStructuralComparable, IStructuralEquatable {
 {
-        public T1 Item1;

-        public ValueTuple(T1 item1);

-        public int CompareTo(ValueTuple<T1> other);

-        public override bool Equals(object obj);

-        public bool Equals(ValueTuple<T1> other);

-        public override int GetHashCode();

-        int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer);

-        bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer);

-        int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer);

-        int System.IComparable.CompareTo(object other);

-        public override string ToString();

-    }
-    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
-    public struct ValueTuple<T1, T2> : IComparable, IComparable<ValueTuple<T1, T2>>, IEquatable<ValueTuple<T1, T2>>, IStructuralComparable, IStructuralEquatable {
 {
-        public T1 Item1;

-        public T2 Item2;

-        public ValueTuple(T1 item1, T2 item2);

-        public int CompareTo(ValueTuple<T1, T2> other);

-        public override bool Equals(object obj);

-        public bool Equals(ValueTuple<T1, T2> other);

-        public override int GetHashCode();

-        int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer);

-        bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer);

-        int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer);

-        int System.IComparable.CompareTo(object other);

-        public override string ToString();

-    }
-    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
-    public struct ValueTuple<T1, T2, T3> : IComparable, IComparable<ValueTuple<T1, T2, T3>>, IEquatable<ValueTuple<T1, T2, T3>>, IStructuralComparable, IStructuralEquatable {
 {
-        public T1 Item1;

-        public T2 Item2;

-        public T3 Item3;

-        public ValueTuple(T1 item1, T2 item2, T3 item3);

-        public int CompareTo(ValueTuple<T1, T2, T3> other);

-        public override bool Equals(object obj);

-        public bool Equals(ValueTuple<T1, T2, T3> other);

-        public override int GetHashCode();

-        int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer);

-        bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer);

-        int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer);

-        int System.IComparable.CompareTo(object other);

-        public override string ToString();

-    }
-    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
-    public struct ValueTuple<T1, T2, T3, T4> : IComparable, IComparable<ValueTuple<T1, T2, T3, T4>>, IEquatable<ValueTuple<T1, T2, T3, T4>>, IStructuralComparable, IStructuralEquatable {
 {
-        public T1 Item1;

-        public T2 Item2;

-        public T3 Item3;

-        public T4 Item4;

-        public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4);

-        public int CompareTo(ValueTuple<T1, T2, T3, T4> other);

-        public override bool Equals(object obj);

-        public bool Equals(ValueTuple<T1, T2, T3, T4> other);

-        public override int GetHashCode();

-        int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer);

-        bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer);

-        int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer);

-        int System.IComparable.CompareTo(object other);

-        public override string ToString();

-    }
-    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
-    public struct ValueTuple<T1, T2, T3, T4, T5> : IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5>>, IEquatable<ValueTuple<T1, T2, T3, T4, T5>>, IStructuralComparable, IStructuralEquatable {
 {
-        public T1 Item1;

-        public T2 Item2;

-        public T3 Item3;

-        public T4 Item4;

-        public T5 Item5;

-        public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5);

-        public int CompareTo(ValueTuple<T1, T2, T3, T4, T5> other);

-        public override bool Equals(object obj);

-        public bool Equals(ValueTuple<T1, T2, T3, T4, T5> other);

-        public override int GetHashCode();

-        int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer);

-        bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer);

-        int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer);

-        int System.IComparable.CompareTo(object other);

-        public override string ToString();

-    }
-    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
-    public struct ValueTuple<T1, T2, T3, T4, T5, T6> : IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5, T6>>, IEquatable<ValueTuple<T1, T2, T3, T4, T5, T6>>, IStructuralComparable, IStructuralEquatable {
 {
-        public T1 Item1;

-        public T2 Item2;

-        public T3 Item3;

-        public T4 Item4;

-        public T5 Item5;

-        public T6 Item6;

-        public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6);

-        public int CompareTo(ValueTuple<T1, T2, T3, T4, T5, T6> other);

-        public override bool Equals(object obj);

-        public bool Equals(ValueTuple<T1, T2, T3, T4, T5, T6> other);

-        public override int GetHashCode();

-        int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer);

-        bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer);

-        int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer);

-        int System.IComparable.CompareTo(object other);

-        public override string ToString();

-    }
-    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
-    public struct ValueTuple<T1, T2, T3, T4, T5, T6, T7> : IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5, T6, T7>>, IEquatable<ValueTuple<T1, T2, T3, T4, T5, T6, T7>>, IStructuralComparable, IStructuralEquatable {
 {
-        public T1 Item1;

-        public T2 Item2;

-        public T3 Item3;

-        public T4 Item4;

-        public T5 Item5;

-        public T6 Item6;

-        public T7 Item7;

-        public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7);

-        public int CompareTo(ValueTuple<T1, T2, T3, T4, T5, T6, T7> other);

-        public override bool Equals(object obj);

-        public bool Equals(ValueTuple<T1, T2, T3, T4, T5, T6, T7> other);

-        public override int GetHashCode();

-        int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer);

-        bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer);

-        int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer);

-        int System.IComparable.CompareTo(object other);

-        public override string ToString();

-    }
-    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
-    public struct ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> : IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>, IEquatable<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>, IStructuralComparable, IStructuralEquatable where TRest : struct {
 {
-        public T1 Item1;

-        public T2 Item2;

-        public T3 Item3;

-        public T4 Item4;

-        public T5 Item5;

-        public T6 Item6;

-        public T7 Item7;

-        public TRest Rest;

-        public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, TRest rest);

-        public int CompareTo(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> other);

-        public override bool Equals(object obj);

-        public bool Equals(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> other);

-        public override int GetHashCode();

-        int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer);

-        bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer);

-        int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer);

-        int System.IComparable.CompareTo(object other);

-        public override string ToString();

-    }
     public sealed class WeakReference<T> : ISerializable where T : class {
+        ~WeakReference();
     }
 }
```

