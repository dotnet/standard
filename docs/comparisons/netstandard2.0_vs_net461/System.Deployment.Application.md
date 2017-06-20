# System.Deployment.Application

``` diff
+namespace System.Deployment.Application {
+    public sealed class ApplicationDeployment {
+        public Uri ActivationUri { get; }
+        public static ApplicationDeployment CurrentDeployment { get; }
+        public Version CurrentVersion { get; }
+        public string DataDirectory { get; }
+        public bool IsFirstRun { get; }
+        public static bool IsNetworkDeployed { get; }
+        public DateTime TimeOfLastUpdateCheck { get; }
+        public string UpdatedApplicationFullName { get; }
+        public Version UpdatedVersion { get; }
+        public Uri UpdateLocation { get; }
+        public event CheckForUpdateCompletedEventHandler CheckForUpdateCompleted;
+        public event DeploymentProgressChangedEventHandler CheckForUpdateProgressChanged;
+        public event DownloadFileGroupCompletedEventHandler DownloadFileGroupCompleted;
+        public event DeploymentProgressChangedEventHandler DownloadFileGroupProgressChanged;
+        public event AsyncCompletedEventHandler UpdateCompleted;
+        public event DeploymentProgressChangedEventHandler UpdateProgressChanged;
+        public UpdateCheckInfo CheckForDetailedUpdate();
+        public UpdateCheckInfo CheckForDetailedUpdate(bool persistUpdateCheckResult);
+        public bool CheckForUpdate();
+        public bool CheckForUpdate(bool persistUpdateCheckResult);
+        public void CheckForUpdateAsync();
+        public void CheckForUpdateAsyncCancel();
+        public void DownloadFileGroup(string groupName);
+        public void DownloadFileGroupAsync(string groupName);
+        public void DownloadFileGroupAsync(string groupName, object userState);
+        public void DownloadFileGroupAsyncCancel(string groupName);
+        public bool IsFileGroupDownloaded(string groupName);
+        public bool Update();
+        public void UpdateAsync();
+        public void UpdateAsyncCancel();
+    }
+    public class CheckForUpdateCompletedEventArgs : AsyncCompletedEventArgs {
+        public Version AvailableVersion { get; }
+        public bool IsUpdateRequired { get; }
+        public Version MinimumRequiredVersion { get; }
+        public bool UpdateAvailable { get; }
+        public long UpdateSizeBytes { get; }
+    }
+    public delegate void CheckForUpdateCompletedEventHandler(object sender, CheckForUpdateCompletedEventArgs e);
+    public class CompatibleFramework {
+        public string Profile { get; }
+        public string SupportedRuntime { get; }
+        public string TargetVersion { get; }
+    }
+    public class CompatibleFrameworkMissingException : DependentPlatformMissingException {
+        public CompatibleFrameworkMissingException();
+        protected CompatibleFrameworkMissingException(SerializationInfo serializationInfo, StreamingContext streamingContext);
+        public CompatibleFrameworkMissingException(string message);
+        public CompatibleFrameworkMissingException(string message, Exception innerException);
+        public CompatibleFrameworks CompatibleFrameworks { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class CompatibleFrameworks {
+        public IList<CompatibleFramework> Frameworks { get; }
+        public Uri SupportUrl { get; }
+    }
+    public class DependentPlatformMissingException : DeploymentException {
+        public DependentPlatformMissingException();
+        protected DependentPlatformMissingException(SerializationInfo serializationInfo, StreamingContext streamingContext);
+        public DependentPlatformMissingException(string message);
+        public DependentPlatformMissingException(string message, Exception innerException);
+        public DependentPlatformMissingException(string message, Uri supportUrl);
+        public Uri SupportUrl { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class DeploymentDownloadException : DeploymentException {
+        public DeploymentDownloadException();
+        protected DeploymentDownloadException(SerializationInfo serializationInfo, StreamingContext streamingContext);
+        public DeploymentDownloadException(string message);
+        public DeploymentDownloadException(string message, Exception innerException);
+    }
+    public class DeploymentException : SystemException {
+        public DeploymentException();
+        protected DeploymentException(SerializationInfo serializationInfo, StreamingContext streamingContext);
+        public DeploymentException(string message);
+        public DeploymentException(string message, Exception innerException);
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class DeploymentProgressChangedEventArgs : ProgressChangedEventArgs {
+        public long BytesCompleted { get; }
+        public long BytesTotal { get; }
+        public string Group { get; }
+        public DeploymentProgressState State { get; }
+    }
+    public delegate void DeploymentProgressChangedEventHandler(object sender, DeploymentProgressChangedEventArgs e);
+    public enum DeploymentProgressState {
+        DownloadingApplicationFiles = 2,
+        DownloadingApplicationInformation = 1,
+        DownloadingDeploymentInformation = 0,
+    }
+    public class DeploymentServiceCom {
+        public DeploymentServiceCom();
+        public void ActivateApplicationExtension(string textualSubId, string deploymentProviderUrl, string targetAssociatedFile);
+        public void ActivateDeployment(string deploymentLocation, bool isShortcut);
+        public void ActivateDeploymentEx(string deploymentLocation, int unsignedPolicy, int signedPolicy);
+        public void CheckForDeploymentUpdate(string textualSubId);
+        public void CleanOnlineAppCache();
+        public void EndServiceRightNow();
+        public void MaintainSubscription(string textualSubId);
+    }
+    public class DownloadApplicationCompletedEventArgs : AsyncCompletedEventArgs {
+        public string LogFilePath { get; }
+        public string ShortcutAppId { get; }
+    }
+    public class DownloadFileGroupCompletedEventArgs : AsyncCompletedEventArgs {
+        public string Group { get; }
+    }
+    public delegate void DownloadFileGroupCompletedEventHandler(object sender, DownloadFileGroupCompletedEventArgs e);
+    public class DownloadProgressChangedEventArgs : ProgressChangedEventArgs {
+        public long BytesDownloaded { get; }
+        public DeploymentProgressState State { get; }
+        public long TotalBytesToDownload { get; }
+    }
+    public class GetManifestCompletedEventArgs : AsyncCompletedEventArgs {
+        public ActivationContext ActivationContext { get; }
+        public ApplicationIdentity ApplicationIdentity { get; }
+        public XmlReader ApplicationManifest { get; }
+        public XmlReader DeploymentManifest { get; }
+        public bool IsCached { get; }
+        public string LogFilePath { get; }
+        public string ProductName { get; }
+        public string SubscriptionIdentity { get; }
+        public Uri SupportUri { get; }
+        public Version Version { get; }
+    }
+    public class InPlaceHostingManager : IDisposable {
+        public InPlaceHostingManager(Uri deploymentManifest);
+        public InPlaceHostingManager(Uri deploymentManifest, bool launchInHostProcess);
+        public event EventHandler<DownloadApplicationCompletedEventArgs> DownloadApplicationCompleted;
+        public event EventHandler<DownloadProgressChangedEventArgs> DownloadProgressChanged;
+        public event EventHandler<GetManifestCompletedEventArgs> GetManifestCompleted;
+        public void AssertApplicationRequirements();
+        public void AssertApplicationRequirements(bool grantApplicationTrust);
+        public void CancelAsync();
+        public void Dispose();
+        public void DownloadApplicationAsync();
+        public ObjectHandle Execute();
+        public void GetManifestAsync();
+        public static void UninstallCustomAddIn(string subscriptionId);
+        public static void UninstallCustomUXApplication(string subscriptionId);
+    }
+    public class InvalidDeploymentException : DeploymentException {
+        public InvalidDeploymentException();
+        protected InvalidDeploymentException(SerializationInfo serializationInfo, StreamingContext streamingContext);
+        public InvalidDeploymentException(string message);
+        public InvalidDeploymentException(string message, Exception innerException);
+    }
+    public class SupportedRuntimeMissingException : DependentPlatformMissingException {
+        public SupportedRuntimeMissingException();
+        protected SupportedRuntimeMissingException(SerializationInfo serializationInfo, StreamingContext streamingContext);
+        public SupportedRuntimeMissingException(string message);
+        public SupportedRuntimeMissingException(string message, Exception innerException);
+        public string SupportedRuntimeVersion { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class TrustNotGrantedException : DeploymentException {
+        public TrustNotGrantedException();
+        protected TrustNotGrantedException(SerializationInfo serializationInfo, StreamingContext streamingContext);
+        public TrustNotGrantedException(string message);
+        public TrustNotGrantedException(string message, Exception innerException);
+    }
+    public class UpdateCheckInfo {
+        public Version AvailableVersion { get; }
+        public bool IsUpdateRequired { get; }
+        public Version MinimumRequiredVersion { get; }
+        public bool UpdateAvailable { get; }
+        public long UpdateSizeBytes { get; }
+    }
+}
```

