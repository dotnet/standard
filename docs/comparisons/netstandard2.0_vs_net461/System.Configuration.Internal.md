# System.Configuration.Internal

``` diff
+namespace System.Configuration.Internal {
+    public class DelegatingConfigHost : IInternalConfigHost {
+        protected DelegatingConfigHost();
+        protected IInternalConfigHost Host { get; set; }
+        public virtual bool IsRemote { get; }
+        public virtual bool SupportsChangeNotifications { get; }
+        public virtual bool SupportsLocation { get; }
+        public virtual bool SupportsPath { get; }
+        public virtual bool SupportsRefresh { get; }
+        public virtual object CreateConfigurationContext(string configPath, string locationSubPath);
+        public virtual object CreateDeprecatedConfigContext(string configPath);
+        public virtual string DecryptSection(string encryptedXml, ProtectedConfigurationProvider protectionProvider, ProtectedConfigurationSection protectedConfigSection);
+        public virtual void DeleteStream(string streamName);
+        public virtual string EncryptSection(string clearTextXml, ProtectedConfigurationProvider protectionProvider, ProtectedConfigurationSection protectedConfigSection);
+        public virtual string GetConfigPathFromLocationSubPath(string configPath, string locationSubPath);
+        public virtual Type GetConfigType(string typeName, bool throwOnError);
+        public virtual string GetConfigTypeName(Type t);
+        public virtual void GetRestrictedPermissions(IInternalConfigRecord configRecord, out PermissionSet permissionSet, out bool isHostReady);
+        public virtual string GetStreamName(string configPath);
+        public virtual string GetStreamNameForConfigSource(string streamName, string configSource);
+        public virtual object GetStreamVersion(string streamName);
+        public virtual IDisposable Impersonate();
+        public virtual void Init(IInternalConfigRoot configRoot, params object[] hostInitParams);
+        public virtual void InitForConfiguration(ref string locationSubPath, out string configPath, out string locationConfigPath, IInternalConfigRoot configRoot, params object[] hostInitConfigurationParams);
+        public virtual bool IsAboveApplication(string configPath);
+        public virtual bool IsConfigRecordRequired(string configPath);
+        public virtual bool IsDefinitionAllowed(string configPath, ConfigurationAllowDefinition allowDefinition, ConfigurationAllowExeDefinition allowExeDefinition);
+        public virtual bool IsFile(string streamName);
+        public virtual bool IsFullTrustSectionWithoutAptcaAllowed(IInternalConfigRecord configRecord);
+        public virtual bool IsInitDelayed(IInternalConfigRecord configRecord);
+        public virtual bool IsLocationApplicable(string configPath);
+        public virtual bool IsSecondaryRoot(string configPath);
+        public virtual bool IsTrustedConfigPath(string configPath);
+        public virtual Stream OpenStreamForRead(string streamName);
+        public virtual Stream OpenStreamForRead(string streamName, bool assertPermissions);
+        public virtual Stream OpenStreamForWrite(string streamName, string templateStreamName, ref object writeContext);
+        public virtual Stream OpenStreamForWrite(string streamName, string templateStreamName, ref object writeContext, bool assertPermissions);
+        public virtual bool PrefetchAll(string configPath, string streamName);
+        public virtual bool PrefetchSection(string sectionGroupName, string sectionName);
+        public virtual void RequireCompleteInit(IInternalConfigRecord configRecord);
+        public virtual object StartMonitoringStreamForChanges(string streamName, StreamChangeCallback callback);
+        public virtual void StopMonitoringStreamForChanges(string streamName, StreamChangeCallback callback);
+        public virtual void VerifyDefinitionAllowed(string configPath, ConfigurationAllowDefinition allowDefinition, ConfigurationAllowExeDefinition allowExeDefinition, IConfigErrorInfo errorInfo);
+        public virtual void WriteCompleted(string streamName, bool success, object writeContext);
+        public virtual void WriteCompleted(string streamName, bool success, object writeContext, bool assertPermissions);
+    }
+    public interface IConfigErrorInfo {
+        string Filename { get; }
+        int LineNumber { get; }
+    }
+    public interface IConfigSystem {
+        IInternalConfigHost Host { get; }
+        IInternalConfigRoot Root { get; }
+        void Init(Type typeConfigHost, params object[] hostInitParams);
+    }
+    public interface IConfigurationManagerHelper {
+        void EnsureNetConfigLoaded();
+    }
+    public interface IConfigurationManagerInternal {
+        string ApplicationConfigUri { get; }
+        string ExeLocalConfigDirectory { get; }
+        string ExeLocalConfigPath { get; }
+        string ExeProductName { get; }
+        string ExeProductVersion { get; }
+        string ExeRoamingConfigDirectory { get; }
+        string ExeRoamingConfigPath { get; }
+        string MachineConfigPath { get; }
+        bool SetConfigurationSystemInProgress { get; }
+        bool SupportsUserConfig { get; }
+        string UserConfigFilename { get; }
+    }
+    public interface IInternalConfigClientHost {
+        string GetExeConfigPath();
+        string GetLocalUserConfigPath();
+        string GetRoamingUserConfigPath();
+        bool IsExeConfig(string configPath);
+        bool IsLocalUserConfig(string configPath);
+        bool IsRoamingUserConfig(string configPath);
+    }
+    public interface IInternalConfigConfigurationFactory {
+        Configuration Create(Type typeConfigHost, params object[] hostInitConfigurationParams);
+        string NormalizeLocationSubPath(string subPath, IConfigErrorInfo errorInfo);
+    }
+    public interface IInternalConfigHost {
+        bool IsRemote { get; }
+        bool SupportsChangeNotifications { get; }
+        bool SupportsLocation { get; }
+        bool SupportsPath { get; }
+        bool SupportsRefresh { get; }
+        object CreateConfigurationContext(string configPath, string locationSubPath);
+        object CreateDeprecatedConfigContext(string configPath);
+        string DecryptSection(string encryptedXml, ProtectedConfigurationProvider protectionProvider, ProtectedConfigurationSection protectedConfigSection);
+        void DeleteStream(string streamName);
+        string EncryptSection(string clearTextXml, ProtectedConfigurationProvider protectionProvider, ProtectedConfigurationSection protectedConfigSection);
+        string GetConfigPathFromLocationSubPath(string configPath, string locationSubPath);
+        Type GetConfigType(string typeName, bool throwOnError);
+        string GetConfigTypeName(Type t);
+        void GetRestrictedPermissions(IInternalConfigRecord configRecord, out PermissionSet permissionSet, out bool isHostReady);
+        string GetStreamName(string configPath);
+        string GetStreamNameForConfigSource(string streamName, string configSource);
+        object GetStreamVersion(string streamName);
+        IDisposable Impersonate();
+        void Init(IInternalConfigRoot configRoot, params object[] hostInitParams);
+        void InitForConfiguration(ref string locationSubPath, out string configPath, out string locationConfigPath, IInternalConfigRoot configRoot, params object[] hostInitConfigurationParams);
+        bool IsAboveApplication(string configPath);
+        bool IsConfigRecordRequired(string configPath);
+        bool IsDefinitionAllowed(string configPath, ConfigurationAllowDefinition allowDefinition, ConfigurationAllowExeDefinition allowExeDefinition);
+        bool IsFile(string streamName);
+        bool IsFullTrustSectionWithoutAptcaAllowed(IInternalConfigRecord configRecord);
+        bool IsInitDelayed(IInternalConfigRecord configRecord);
+        bool IsLocationApplicable(string configPath);
+        bool IsSecondaryRoot(string configPath);
+        bool IsTrustedConfigPath(string configPath);
+        Stream OpenStreamForRead(string streamName);
+        Stream OpenStreamForRead(string streamName, bool assertPermissions);
+        Stream OpenStreamForWrite(string streamName, string templateStreamName, ref object writeContext);
+        Stream OpenStreamForWrite(string streamName, string templateStreamName, ref object writeContext, bool assertPermissions);
+        bool PrefetchAll(string configPath, string streamName);
+        bool PrefetchSection(string sectionGroupName, string sectionName);
+        void RequireCompleteInit(IInternalConfigRecord configRecord);
+        object StartMonitoringStreamForChanges(string streamName, StreamChangeCallback callback);
+        void StopMonitoringStreamForChanges(string streamName, StreamChangeCallback callback);
+        void VerifyDefinitionAllowed(string configPath, ConfigurationAllowDefinition allowDefinition, ConfigurationAllowExeDefinition allowExeDefinition, IConfigErrorInfo errorInfo);
+        void WriteCompleted(string streamName, bool success, object writeContext);
+        void WriteCompleted(string streamName, bool success, object writeContext, bool assertPermissions);
+    }
+    public interface IInternalConfigRecord {
+        string ConfigPath { get; }
+        bool HasInitErrors { get; }
+        string StreamName { get; }
+        object GetLkgSection(string configKey);
+        object GetSection(string configKey);
+        void RefreshSection(string configKey);
+        void Remove();
+        void ThrowIfInitErrors();
+    }
+    public interface IInternalConfigRoot {
+        bool IsDesignTime { get; }
+        event InternalConfigEventHandler ConfigChanged;
+        event InternalConfigEventHandler ConfigRemoved;
+        IInternalConfigRecord GetConfigRecord(string configPath);
+        object GetSection(string section, string configPath);
+        string GetUniqueConfigPath(string configPath);
+        IInternalConfigRecord GetUniqueConfigRecord(string configPath);
+        void Init(IInternalConfigHost host, bool isDesignTime);
+        void RemoveConfig(string configPath);
+    }
+    public interface IInternalConfigSettingsFactory {
+        void CompleteInit();
+        void SetConfigurationSystem(IInternalConfigSystem internalConfigSystem, bool initComplete);
+    }
+    public interface IInternalConfigSystem {
+        bool SupportsUserConfig { get; }
+        object GetSection(string configKey);
+        void RefreshConfig(string sectionName);
+    }
+    public sealed class InternalConfigEventArgs : EventArgs {
+        public InternalConfigEventArgs(string configPath);
+        public string ConfigPath { get; set; }
+    }
+    public delegate void InternalConfigEventHandler(object sender, InternalConfigEventArgs e);
+    public delegate void StreamChangeCallback(string streamName);
+}
```

