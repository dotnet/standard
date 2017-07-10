# System.Web.Hosting

``` diff
+namespace System.Web.Hosting {
+    public sealed class AppDomainFactory : IAppDomainFactory {
+        public AppDomainFactory();
+        public object Create(string module, string typeName, string appId, string appPath, string strUrlOfAppOrigin, int iZone);
+    }
+    public class AppDomainInfo : IAppDomainInfo {
+        public string GetId();
+        public string GetPhysicalPath();
+        public int GetSiteId();
+        public string GetVirtualPath();
+        public bool IsIdle();
+    }
+    public class AppDomainInfoEnum : IAppDomainInfoEnum {
+        public int Count();
+        public IAppDomainInfo GetData();
+        public bool MoveNext();
+        public void Reset();
+    }
+    public abstract class AppDomainProtocolHandler : MarshalByRefObject, IRegisteredObject {
+        protected AppDomainProtocolHandler();
+        public override object InitializeLifetimeService();
+        public abstract void StartListenerChannel(IListenerChannelCallback listenerChannelCallback);
+        public virtual void Stop(bool immediate);
+        public abstract void StopListenerChannel(int listenerChannelId, bool immediate);
+        public abstract void StopProtocol(bool immediate);
+    }
+    public sealed class ApplicationHost {
+        public static object CreateApplicationHost(Type hostType, string virtualDir, string physicalDir);
+    }
+    public sealed class ApplicationInfo {
+        public string ID { get; }
+        public string PhysicalPath { get; }
+        public string VirtualPath { get; }
+    }
+    public sealed class ApplicationManager : MarshalByRefObject {
+        public void Close();
+        public IRegisteredObject CreateObject(string appId, Type type, string virtualPath, string physicalPath, bool failIfExists);
+        public IRegisteredObject CreateObject(string appId, Type type, string virtualPath, string physicalPath, bool failIfExists, bool throwOnError);
+        public IRegisteredObject CreateObject(IApplicationHost appHost, Type type);
+        public AppDomain GetAppDomain(string appId);
+        public AppDomain GetAppDomain(IApplicationHost appHost);
+        public static ApplicationManager GetApplicationManager();
+        public IRegisteredObject GetObject(string appId, Type type);
+        public ApplicationInfo[] GetRunningApplications();
+        public override object InitializeLifetimeService();
+        public bool IsIdle();
+        public void Open();
+        public void ShutdownAll();
+        public void ShutdownApplication(string appId);
+        public void StopObject(string appId, Type type);
+    }
+    public sealed class AppManagerAppDomainFactory : IAppManagerAppDomainFactory {
+        public AppManagerAppDomainFactory();
+        public object Create(string appId, string appPath);
+        public void Stop();
+    }
+    public sealed class CustomLoaderAttribute : Attribute {
+        public CustomLoaderAttribute(Type customLoaderType);
+        public Type CustomLoaderType { get; private set; }
+    }
+    public sealed class HostingEnvironment : MarshalByRefObject {
+        public HostingEnvironment();
+        public static IApplicationHost ApplicationHost { get; }
+        public static string ApplicationID { get; }
+        public static string ApplicationPhysicalPath { get; }
+        public static string ApplicationVirtualPath { get; }
+        public static Cache Cache { get; }
+        public static bool InClientBuildManager { get; }
+        public static Exception InitializationException { get; }
+        public static bool IsDevelopmentEnvironment { get; }
+        public static bool IsHosted { get; }
+        public static int MaxConcurrentRequestsPerCPU { get; set; }
+        public static int MaxConcurrentThreadsPerCPU { get; set; }
+        public static ApplicationShutdownReason ShutdownReason { get; }
+        public static string SiteName { get; }
+        public static VirtualPathProvider VirtualPathProvider { get; }
+        public static event EventHandler StopListening;
+        public static void DecrementBusyCount();
+        public static IDisposable Impersonate();
+        public static IDisposable Impersonate(IntPtr token);
+        public static IDisposable Impersonate(IntPtr userToken, string virtualPath);
+        public static void IncrementBusyCount();
+        public override object InitializeLifetimeService();
+        public static void InitiateShutdown();
+        public static string MapPath(string virtualPath);
+        public static void MessageReceived();
+        public static void QueueBackgroundWorkItem(Action<CancellationToken> workItem);
+        public static void QueueBackgroundWorkItem(Func<CancellationToken, Task> workItem);
+        public static void RegisterObject(IRegisteredObject obj);
+        public static void RegisterVirtualPathProvider(VirtualPathProvider virtualPathProvider);
+        public static IDisposable SetCultures();
+        public static IDisposable SetCultures(string virtualPath);
+        public static void UnregisterObject(IRegisteredObject obj);
+    }
+    public class HostSecurityPolicyResolver {
+        public HostSecurityPolicyResolver();
+        public virtual HostSecurityPolicyResults ResolvePolicy(Evidence evidence);
+    }
+    public enum HostSecurityPolicyResults {
+        AppDomainTrust = 2,
+        DefaultPolicy = 0,
+        FullTrust = 1,
+        Nothing = 3,
+    }
+    public interface IAdphManager {
+        void StartAppDomainProtocolListenerChannel(string appId, string protocolId, IListenerChannelCallback listenerChannelCallback);
+        void StopAppDomainProtocol(string appId, string protocolId, bool immediate);
+        void StopAppDomainProtocolListenerChannel(string appId, string protocolId, int listenerChannelId, bool immediate);
+    }
+    public interface IAppDomainFactory {
+        object Create(string module, string typeName, string appId, string appPath, string strUrlOfAppOrigin, int iZone);
+    }
+    public interface IAppDomainInfo {
+        string GetId();
+        string GetPhysicalPath();
+        int GetSiteId();
+        string GetVirtualPath();
+        bool IsIdle();
+    }
+    public interface IAppDomainInfoEnum {
+        int Count();
+        IAppDomainInfo GetData();
+        bool MoveNext();
+        void Reset();
+    }
+    public interface IApplicationHost {
+        IConfigMapPathFactory GetConfigMapPathFactory();
+        IntPtr GetConfigToken();
+        string GetPhysicalPath();
+        string GetSiteID();
+        string GetSiteName();
+        string GetVirtualPath();
+        void MessageReceived();
+    }
+    public interface IApplicationPreloadManager {
+        void SetApplicationPreloadState(string context, string appId, bool enabled);
+        void SetApplicationPreloadUtil(IApplicationPreloadUtil preloadUtil);
+    }
+    public interface IApplicationPreloadUtil {
+        void GetApplicationPreloadInfo(string context, out bool enabled, out string startupObjType, out string[] parametersForStartupObj);
+        void ReportApplicationPreloadFailure(string context, int errorCode, string errorMessage);
+    }
+    public interface IAppManagerAppDomainFactory {
+        object Create(string appId, string appPath);
+        void Stop();
+    }
+    public interface IISAPIRuntime {
+        void DoGCCollect();
+        int ProcessRequest(IntPtr ecb, int useProcessModel);
+        void StartProcessing();
+        void StopProcessing();
+    }
+    public interface IListenerChannelCallback {
+        void GetBlob(byte[] buffer, ref int bufferSize);
+        int GetBlobLength();
+        int GetId();
+        void ReportMessageReceived();
+        void ReportStarted();
+        void ReportStopped(int hr);
+    }
+    public interface IPphManager {
+        void StartProcessProtocolListenerChannel(string protocolId, IListenerChannelCallback listenerChannelCallback);
+        void StopProcessProtocol(string protocolId, bool immediate);
+        void StopProcessProtocolListenerChannel(string protocolId, int listenerChannelId, bool immediate);
+    }
+    public interface IProcessHost {
+        void EnumerateAppDomains(out IAppDomainInfoEnum appDomainInfoEnum);
+        void Shutdown();
+        void ShutdownApplication(string appId);
+        void StartApplication(string appId, string appPath, out object runtimeInterface);
+    }
+    public interface IProcessHostFactoryHelper {
+        object GetProcessHost(IProcessHostSupportFunctions functions);
+    }
+    public interface IProcessHostIdleAndHealthCheck {
+        bool IsIdle();
+        void Ping(IProcessPingCallback callback);
+    }
+    public interface IProcessHostPreloadClient {
+        void Preload(string[] parameters);
+    }
+    public interface IProcessHostSupportFunctions {
+        string GetAppHostConfigFilename();
+        void GetApplicationProperties(string appId, out string virtualPath, out string physicalPath, out string siteName, out string siteId);
+        IntPtr GetConfigToken(string appId);
+        IntPtr GetNativeConfigurationSystem();
+        string GetRootWebConfigFilename();
+        void MapPath(string appId, string virtualPath, out string physicalPath);
+    }
+    public interface IProcessPingCallback {
+        void Respond();
+    }
+    public interface IRegisteredObject {
+        void Stop(bool immediate);
+    }
+    public sealed class ISAPIRuntime : MarshalByRefObject, IISAPIRuntime, IISAPIRuntime2, IRegisteredObject {
+        public ISAPIRuntime();
+        public void DoGCCollect();
+        public override object InitializeLifetimeService();
+        public int ProcessRequest(IntPtr ecb, int iWRType);
+        public void StartProcessing();
+        public void StopProcessing();
+        void System.Web.Hosting.IRegisteredObject.Stop(bool immediate);
+    }
+    public interface IStopListeningRegisteredObject : IRegisteredObject {
+        void StopListening();
+    }
+    public interface ISuspendibleRegisteredObject : IRegisteredObject {
+        Action Suspend();
+    }
+    public sealed class ProcessHost : MarshalByRefObject, IAdphManager, IApplicationPreloadManager, ICustomRuntimeManager, IPphManager, IProcessHost, IProcessHostIdleAndHealthCheck, IProcessHostLite, IProcessSuspendListener {
+        public void EnumerateAppDomains(out IAppDomainInfoEnum appDomainInfoEnum);
+        public override object InitializeLifetimeService();
+        public bool IsIdle();
+        public void Ping(IProcessPingCallback callback);
+        public void SetApplicationPreloadState(string context, string appId, bool enabled);
+        public void SetApplicationPreloadUtil(IApplicationPreloadUtil applicationPreloadUtil);
+        public void Shutdown();
+        public void ShutdownApplication(string appId);
+        public void StartAppDomainProtocolListenerChannel(string appId, string protocolId, IListenerChannelCallback listenerChannelCallback);
+        public void StartApplication(string appId, string appPath, out object runtimeInterface);
+        public void StartProcessProtocolListenerChannel(string protocolId, IListenerChannelCallback listenerChannelCallback);
+        public void StopAppDomainProtocol(string appId, string protocolId, bool immediate);
+        public void StopAppDomainProtocolListenerChannel(string appId, string protocolId, int listenerChannelId, bool immediate);
+        public void StopProcessProtocol(string protocolId, bool immediate);
+        public void StopProcessProtocolListenerChannel(string protocolId, int listenerChannelId, bool immediate);
+    }
+    public sealed class ProcessHostFactoryHelper : MarshalByRefObject, IProcessHostFactoryHelper {
+        public ProcessHostFactoryHelper();
+        public object GetProcessHost(IProcessHostSupportFunctions functions);
+        public override object InitializeLifetimeService();
+    }
+    public abstract class ProcessProtocolHandler : MarshalByRefObject {
+        protected ProcessProtocolHandler();
+        public override object InitializeLifetimeService();
+        public abstract void StartListenerChannel(IListenerChannelCallback listenerChannelCallback, IAdphManager AdphManager);
+        public abstract void StopListenerChannel(int listenerChannelId, bool immediate);
+        public abstract void StopProtocol(bool immediate);
+    }
+    public class SimpleWorkerRequest : HttpWorkerRequest {
+        public SimpleWorkerRequest(string page, string query, TextWriter output);
+        public SimpleWorkerRequest(string appVirtualDir, string appPhysicalDir, string page, string query, TextWriter output);
+        public override string MachineConfigPath { get; }
+        public override string MachineInstallDirectory { get; }
+        public override string RootWebConfigPath { get; }
+        public override void EndOfRequest();
+        public override void FlushResponse(bool finalFlush);
+        public override string GetAppPath();
+        public override string GetAppPathTranslated();
+        public override string GetFilePath();
+        public override string GetFilePathTranslated();
+        public override string GetHttpVerbName();
+        public override string GetHttpVersion();
+        public override string GetLocalAddress();
+        public override int GetLocalPort();
+        public override string GetPathInfo();
+        public override string GetQueryString();
+        public override string GetRawUrl();
+        public override string GetRemoteAddress();
+        public override int GetRemotePort();
+        public override string GetServerVariable(string name);
+        public override string GetUriPath();
+        public override IntPtr GetUserToken();
+        public override string MapPath(string path);
+        public override void SendKnownResponseHeader(int index, string value);
+        public override void SendResponseFromFile(IntPtr handle, long offset, long length);
+        public override void SendResponseFromFile(string filename, long offset, long length);
+        public override void SendResponseFromMemory(byte[] data, int length);
+        public override void SendStatus(int statusCode, string statusDescription);
+        public override void SendUnknownResponseHeader(string name, string value);
+    }
+    public abstract class VirtualDirectory : VirtualFileBase {
+        protected VirtualDirectory(string virtualPath);
+        public abstract IEnumerable Children { get; }
+        public abstract IEnumerable Directories { get; }
+        public abstract IEnumerable Files { get; }
+        public override bool IsDirectory { get; }
+    }
+    public abstract class VirtualFile : VirtualFileBase {
+        protected VirtualFile(string virtualPath);
+        public override bool IsDirectory { get; }
+        public abstract Stream Open();
+    }
+    public abstract class VirtualFileBase : MarshalByRefObject {
+        protected VirtualFileBase();
+        public abstract bool IsDirectory { get; }
+        public virtual string Name { get; }
+        public string VirtualPath { get; }
+        public override object InitializeLifetimeService();
+    }
+    public abstract class VirtualPathProvider : MarshalByRefObject {
+        protected VirtualPathProvider();
+        protected internal VirtualPathProvider Previous { get; }
+        public virtual string CombineVirtualPaths(string basePath, string relativePath);
+        public virtual bool DirectoryExists(string virtualDir);
+        public virtual bool FileExists(string virtualPath);
+        public virtual CacheDependency GetCacheDependency(string virtualPath, IEnumerable virtualPathDependencies, DateTime utcStart);
+        public virtual string GetCacheKey(string virtualPath);
+        public virtual VirtualDirectory GetDirectory(string virtualDir);
+        public virtual VirtualFile GetFile(string virtualPath);
+        public virtual string GetFileHash(string virtualPath, IEnumerable virtualPathDependencies);
+        protected virtual void Initialize();
+        public override object InitializeLifetimeService();
+        public static Stream OpenFile(string virtualPath);
+    }
+}
```

