# System.EnterpriseServices

``` diff
+namespace System.EnterpriseServices {
+    public enum AccessChecksLevelOption {
+        Application = 0,
+        ApplicationComponent = 1,
+    }
+    public enum ActivationOption {
+        Library = 0,
+        Server = 1,
+    }
+    public sealed class Activity {
+        public Activity(ServiceConfig cfg);
+        public void AsynchronousCall(IServiceCall serviceCall);
+        public void BindToCurrentThread();
+        public void SynchronousCall(IServiceCall serviceCall);
+        public void UnbindFromThread();
+    }
+    public sealed class ApplicationAccessControlAttribute : Attribute {
+        public ApplicationAccessControlAttribute();
+        public ApplicationAccessControlAttribute(bool val);
+        public AccessChecksLevelOption AccessChecksLevel { get; set; }
+        public AuthenticationOption Authentication { get; set; }
+        public ImpersonationLevelOption ImpersonationLevel { get; set; }
+        public bool Value { get; set; }
+    }
+    public sealed class ApplicationActivationAttribute : Attribute {
+        public ApplicationActivationAttribute(ActivationOption opt);
+        public string SoapMailbox { get; set; }
+        public string SoapVRoot { get; set; }
+        public ActivationOption Value { get; }
+    }
+    public sealed class ApplicationIDAttribute : Attribute {
+        public ApplicationIDAttribute(string guid);
+        public Guid Value { get; }
+    }
+    public sealed class ApplicationNameAttribute : Attribute {
+        public ApplicationNameAttribute(string name);
+        public string Value { get; }
+    }
+    public sealed class ApplicationQueuingAttribute : Attribute {
+        public ApplicationQueuingAttribute();
+        public bool Enabled { get; set; }
+        public int MaxListenerThreads { get; set; }
+        public bool QueueListenerEnabled { get; set; }
+    }
+    public enum AuthenticationOption {
+        Call = 3,
+        Connect = 2,
+        Default = 0,
+        Integrity = 5,
+        None = 1,
+        Packet = 4,
+        Privacy = 6,
+    }
+    public sealed class AutoCompleteAttribute : Attribute {
+        public AutoCompleteAttribute();
+        public AutoCompleteAttribute(bool val);
+        public bool Value { get; }
+    }
+    public enum BindingOption {
+        BindingToPoolThread = 1,
+        NoBinding = 0,
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct BOID {
+        public byte[] rgb;
+    }
+    public sealed class BYOT {
+        public static object CreateWithTipTransaction(string url, Type t);
+        public static object CreateWithTransaction(object transaction, Type t);
+    }
+    public sealed class ComponentAccessControlAttribute : Attribute {
+        public ComponentAccessControlAttribute();
+        public ComponentAccessControlAttribute(bool val);
+        public bool Value { get; }
+    }
+    public sealed class COMTIIntrinsicsAttribute : Attribute {
+        public COMTIIntrinsicsAttribute();
+        public COMTIIntrinsicsAttribute(bool val);
+        public bool Value { get; }
+    }
+    public sealed class ConstructionEnabledAttribute : Attribute {
+        public ConstructionEnabledAttribute();
+        public ConstructionEnabledAttribute(bool val);
+        public string Default { get; set; }
+        public bool Enabled { get; set; }
+    }
+    public sealed class ContextUtil {
+        public static Guid ActivityId { get; }
+        public static Guid ApplicationId { get; }
+        public static Guid ApplicationInstanceId { get; }
+        public static Guid ContextId { get; }
+        public static bool DeactivateOnReturn { get; set; }
+        public static bool IsInTransaction { get; }
+        public static bool IsSecurityEnabled { get; }
+        public static TransactionVote MyTransactionVote { get; set; }
+        public static Guid PartitionId { get; }
+        public static Transaction SystemTransaction { get; }
+        public static object Transaction { get; }
+        public static Guid TransactionId { get; }
+        public static void DisableCommit();
+        public static void EnableCommit();
+        public static object GetNamedProperty(string name);
+        public static bool IsCallerInRole(string role);
+        public static bool IsDefaultContext();
+        public static void SetAbort();
+        public static void SetComplete();
+        public static void SetNamedProperty(string name, object value);
+    }
+    public sealed class DescriptionAttribute : Attribute {
+        public DescriptionAttribute(string desc);
+    }
+    public sealed class EventClassAttribute : Attribute {
+        public EventClassAttribute();
+        public bool AllowInprocSubscribers { get; set; }
+        public bool FireInParallel { get; set; }
+        public string PublisherFilter { get; set; }
+    }
+    public sealed class EventTrackingEnabledAttribute : Attribute {
+        public EventTrackingEnabledAttribute();
+        public EventTrackingEnabledAttribute(bool val);
+        public bool Value { get; }
+    }
+    public sealed class ExceptionClassAttribute : Attribute {
+        public ExceptionClassAttribute(string name);
+        public string Value { get; }
+    }
+    public interface IAsyncErrorNotify {
+        void OnError(int hresult);
+    }
+    public sealed class IISIntrinsicsAttribute : Attribute {
+        public IISIntrinsicsAttribute();
+        public IISIntrinsicsAttribute(bool val);
+        public bool Value { get; }
+    }
+    public enum ImpersonationLevelOption {
+        Anonymous = 1,
+        Default = 0,
+        Delegate = 4,
+        Identify = 2,
+        Impersonate = 3,
+    }
+    public enum InheritanceOption {
+        Ignore = 1,
+        Inherit = 0,
+    }
+    public enum InstallationFlags {
+        Configure = 1024,
+        ConfigureComponentsOnly = 16,
+        CreateTargetApplication = 2,
+        Default = 0,
+        ExpectExistingTypeLib = 1,
+        FindOrCreateTargetApplication = 4,
+        Install = 512,
+        ReconfigureExistingApplication = 8,
+        Register = 256,
+        ReportWarningsToConsole = 32,
+    }
+    public sealed class InterfaceQueuingAttribute : Attribute {
+        public InterfaceQueuingAttribute();
+        public InterfaceQueuingAttribute(bool enabled);
+        public bool Enabled { get; set; }
+        public string Interface { get; set; }
+    }
+    public interface IPlaybackControl {
+        void FinalClientRetry();
+        void FinalServerRetry();
+    }
+    public interface IProcessInitControl {
+        void ResetInitializerTimeout(int dwSecondsRemaining);
+    }
+    public interface IProcessInitializer {
+        void Shutdown();
+        void Startup(object punkProcessControl);
+    }
+    public interface IRegistrationHelper {
+        void InstallAssembly(string assembly, ref string application, ref string tlb, InstallationFlags installFlags);
+        void UninstallAssembly(string assembly, string application);
+    }
+    public interface IRemoteDispatch {
+        string RemoteDispatchAutoDone(string s);
+        string RemoteDispatchNotAutoDone(string s);
+    }
+    public interface IServiceCall {
+        void OnCall();
+    }
+    public interface IServicedComponentInfo {
+        void GetComponentInfo(ref int infoMask, out string[] infoArray);
+    }
+    public interface ITransaction {
+        void Abort(ref BOID pboidReason, int fRetaining, int fAsync);
+        void Commit(int fRetaining, int grfTC, int grfRM);
+        void GetTransactionInfo(out XACTTRANSINFO pinfo);
+    }
+    public sealed class JustInTimeActivationAttribute : Attribute {
+        public JustInTimeActivationAttribute();
+        public JustInTimeActivationAttribute(bool val);
+        public bool Value { get; }
+    }
+    public sealed class LoadBalancingSupportedAttribute : Attribute {
+        public LoadBalancingSupportedAttribute();
+        public LoadBalancingSupportedAttribute(bool val);
+        public bool Value { get; }
+    }
+    public sealed class MustRunInClientContextAttribute : Attribute {
+        public MustRunInClientContextAttribute();
+        public MustRunInClientContextAttribute(bool val);
+        public bool Value { get; }
+    }
+    public sealed class ObjectPoolingAttribute : Attribute {
+        public ObjectPoolingAttribute();
+        public ObjectPoolingAttribute(bool enable);
+        public ObjectPoolingAttribute(bool enable, int minPoolSize, int maxPoolSize);
+        public ObjectPoolingAttribute(int minPoolSize, int maxPoolSize);
+        public int CreationTimeout { get; set; }
+        public bool Enabled { get; set; }
+        public int MaxPoolSize { get; set; }
+        public int MinPoolSize { get; set; }
+        public bool AfterSaveChanges(Hashtable info);
+        public bool Apply(Hashtable info);
+        public bool IsValidTarget(string s);
+    }
+    public enum PartitionOption {
+        Ignore = 0,
+        Inherit = 1,
+        New = 2,
+    }
+    public sealed class PrivateComponentAttribute : Attribute {
+        public PrivateComponentAttribute();
+    }
+    public enum PropertyLockMode {
+        Method = 1,
+        SetGet = 0,
+    }
+    public enum PropertyReleaseMode {
+        Process = 1,
+        Standard = 0,
+    }
+    public class RegistrationConfig {
+        public RegistrationConfig();
+        public string Application { get; set; }
+        public string ApplicationRootDirectory { get; set; }
+        public string AssemblyFile { get; set; }
+        public InstallationFlags InstallationFlags { get; set; }
+        public string Partition { get; set; }
+        public string TypeLibrary { get; set; }
+    }
+    public sealed class RegistrationErrorInfo {
+        public int ErrorCode { get; }
+        public string ErrorString { get; }
+        public string MajorRef { get; }
+        public string MinorRef { get; }
+        public string Name { get; }
+    }
+    public sealed class RegistrationException : SystemException {
+        public RegistrationException();
+        public RegistrationException(string msg);
+        public RegistrationException(string msg, Exception inner);
+        public RegistrationErrorInfo[] ErrorInfo { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext ctx);
+    }
+    public sealed class RegistrationHelper : MarshalByRefObject, IRegistrationHelper {
+        public RegistrationHelper();
+        public void InstallAssembly(string assembly, ref string application, ref string tlb, InstallationFlags installFlags);
+        public void InstallAssembly(string assembly, ref string application, string partition, ref string tlb, InstallationFlags installFlags);
+        public void InstallAssemblyFromConfig(ref RegistrationConfig regConfig);
+        public void UninstallAssembly(string assembly, string application);
+        public void UninstallAssembly(string assembly, string application, string partition);
+        public void UninstallAssemblyFromConfig(ref RegistrationConfig regConfig);
+    }
+    public sealed class RegistrationHelperTx : ServicedComponent {
+        public RegistrationHelperTx();
+        protected internal override void Activate();
+        protected internal override void Deactivate();
+        public void InstallAssembly(string assembly, ref string application, ref string tlb, InstallationFlags installFlags, object sync);
+        public void InstallAssembly(string assembly, ref string application, string partition, ref string tlb, InstallationFlags installFlags, object sync);
+        public void InstallAssemblyFromConfig(ref RegistrationConfig regConfig, object sync);
+        public bool IsInTransaction();
+        public void UninstallAssembly(string assembly, string application, object sync);
+        public void UninstallAssembly(string assembly, string application, string partition, object sync);
+        public void UninstallAssemblyFromConfig(ref RegistrationConfig regConfig, object sync);
+    }
+    public sealed class ResourcePool {
+        public ResourcePool(ResourcePool.TransactionEndDelegate cb);
+        public object GetResource();
+        public bool PutResource(object resource);
+        public delegate void TransactionEndDelegate(object resource);
+    }
+    public sealed class SecureMethodAttribute : Attribute {
+        public SecureMethodAttribute();
+    }
+    public sealed class SecurityCallContext {
+        public SecurityCallers Callers { get; }
+        public static SecurityCallContext CurrentCall { get; }
+        public SecurityIdentity DirectCaller { get; }
+        public bool IsSecurityEnabled { get; }
+        public int MinAuthenticationLevel { get; }
+        public int NumCallers { get; }
+        public SecurityIdentity OriginalCaller { get; }
+        public bool IsCallerInRole(string role);
+        public bool IsUserInRole(string user, string role);
+    }
+    public sealed class SecurityCallers : IEnumerable {
+        public int Count { get; }
+        public SecurityIdentity this[int idx] { get; }
+        public IEnumerator GetEnumerator();
+    }
+    public sealed class SecurityIdentity {
+        public string AccountName { get; }
+        public AuthenticationOption AuthenticationLevel { get; }
+        public int AuthenticationService { get; }
+        public ImpersonationLevelOption ImpersonationLevel { get; }
+    }
+    public sealed class SecurityRoleAttribute : Attribute {
+        public SecurityRoleAttribute(string role);
+        public SecurityRoleAttribute(string role, bool everyone);
+        public string Description { get; set; }
+        public string Role { get; set; }
+        public bool SetEveryoneAccess { get; set; }
+    }
+    public sealed class ServiceConfig {
+        public ServiceConfig();
+        public BindingOption Binding { get; set; }
+        public Transaction BringYourOwnSystemTransaction { get; set; }
+        public ITransaction BringYourOwnTransaction { get; set; }
+        public bool COMTIIntrinsicsEnabled { get; set; }
+        public bool IISIntrinsicsEnabled { get; set; }
+        public InheritanceOption Inheritance { get; set; }
+        public TransactionIsolationLevel IsolationLevel { get; set; }
+        public Guid PartitionId { get; set; }
+        public PartitionOption PartitionOption { get; set; }
+        public string SxsDirectory { get; set; }
+        public string SxsName { get; set; }
+        public SxsOption SxsOption { get; set; }
+        public SynchronizationOption Synchronization { get; set; }
+        public ThreadPoolOption ThreadPool { get; set; }
+        public string TipUrl { get; set; }
+        public string TrackingAppName { get; set; }
+        public string TrackingComponentName { get; set; }
+        public bool TrackingEnabled { get; set; }
+        public TransactionOption Transaction { get; set; }
+        public string TransactionDescription { get; set; }
+        public int TransactionTimeout { get; set; }
+    }
+    public abstract class ServicedComponent : ContextBoundObject, IDisposable, IRemoteDispatch, IServicedComponentInfo {
+        public ServicedComponent();
+        protected internal virtual void Activate();
+        protected internal virtual bool CanBePooled();
+        protected internal virtual void Construct(string s);
+        protected internal virtual void Deactivate();
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        public static void DisposeObject(ServicedComponent sc);
+        string System.EnterpriseServices.IRemoteDispatch.RemoteDispatchAutoDone(string s);
+        string System.EnterpriseServices.IRemoteDispatch.RemoteDispatchNotAutoDone(string s);
+        void System.EnterpriseServices.IServicedComponentInfo.GetComponentInfo(ref int infoMask, out string[] infoArray);
+    }
+    public sealed class ServicedComponentException : SystemException {
+        public ServicedComponentException();
+        public ServicedComponentException(string message);
+        public ServicedComponentException(string message, Exception innerException);
+    }
+    public sealed class ServiceDomain {
+        public static void Enter(ServiceConfig cfg);
+        public static TransactionStatus Leave();
+    }
+    public sealed class SharedProperty {
+        public object Value { get; set; }
+    }
+    public sealed class SharedPropertyGroup {
+        public SharedProperty CreateProperty(string name, out bool fExists);
+        public SharedProperty CreatePropertyByPosition(int position, out bool fExists);
+        public SharedProperty Property(string name);
+        public SharedProperty PropertyByPosition(int position);
+    }
+    public sealed class SharedPropertyGroupManager : IEnumerable {
+        public SharedPropertyGroupManager();
+        public SharedPropertyGroup CreatePropertyGroup(string name, ref PropertyLockMode dwIsoMode, ref PropertyReleaseMode dwRelMode, out bool fExist);
+        public IEnumerator GetEnumerator();
+        public SharedPropertyGroup Group(string name);
+    }
+    public enum SxsOption {
+        Ignore = 0,
+        Inherit = 1,
+        New = 2,
+    }
+    public sealed class SynchronizationAttribute : Attribute {
+        public SynchronizationAttribute();
+        public SynchronizationAttribute(SynchronizationOption val);
+        public SynchronizationOption Value { get; }
+    }
+    public enum SynchronizationOption {
+        Disabled = 0,
+        NotSupported = 1,
+        Required = 3,
+        RequiresNew = 4,
+        Supported = 2,
+    }
+    public enum ThreadPoolOption {
+        Inherit = 1,
+        MTA = 3,
+        None = 0,
+        STA = 2,
+    }
+    public sealed class TransactionAttribute : Attribute {
+        public TransactionAttribute();
+        public TransactionAttribute(TransactionOption val);
+        public TransactionIsolationLevel Isolation { get; set; }
+        public int Timeout { get; set; }
+        public TransactionOption Value { get; }
+    }
+    public enum TransactionIsolationLevel {
+        Any = 0,
+        ReadCommitted = 2,
+        ReadUncommitted = 1,
+        RepeatableRead = 3,
+        Serializable = 4,
+    }
+    public enum TransactionOption {
+        Disabled = 0,
+        NotSupported = 1,
+        Required = 3,
+        RequiresNew = 4,
+        Supported = 2,
+    }
+    public enum TransactionStatus {
+        Aborted = 4,
+        Aborting = 3,
+        Commited = 0,
+        LocallyOk = 1,
+        NoTransaction = 2,
+    }
+    public enum TransactionVote {
+        Abort = 1,
+        Commit = 0,
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct XACTTRANSINFO {
+        public BOID uow;
+        public int grfRMSupported;
+        public int grfRMSupportedRetaining;
+        public int grfTCSupported;
+        public int grfTCSupportedRetaining;
+        public int isoFlags;
+        public int isoLevel;
+    }
+}
```

