# System.Management.Instrumentation

``` diff
+namespace System.Management.Instrumentation {
+    public abstract class BaseEvent : IEvent {
+        protected BaseEvent();
+        public void Fire();
+    }
+    public class DefaultManagementInstaller : Installer {
+        public DefaultManagementInstaller();
+    }
+    public class DefaultManagementProjectInstaller : Installer {
+        public DefaultManagementProjectInstaller();
+    }
+    public interface IEvent {
+        void Fire();
+    }
+    public class IgnoreMemberAttribute : Attribute {
+        public IgnoreMemberAttribute();
+    }
+    public interface IInstance {
+        bool Published { get; set; }
+    }
+    public abstract class Instance : IInstance {
+        protected Instance();
+        public bool Published { get; set; }
+    }
+    public class InstanceNotFoundException : InstrumentationException {
+        public InstanceNotFoundException();
+        protected InstanceNotFoundException(SerializationInfo info, StreamingContext context);
+        public InstanceNotFoundException(string message);
+        public InstanceNotFoundException(string message, Exception innerException);
+    }
+    public class Instrumentation {
+        public Instrumentation();
+        public static void Fire(object eventData);
+        public static bool IsAssemblyRegistered(Assembly assemblyToRegister);
+        public static void Publish(object instanceData);
+        public static void RegisterAssembly(Assembly assemblyToRegister);
+        public static void Revoke(object instanceData);
+        public static void SetBatchSize(Type instrumentationClass, int batchSize);
+    }
+    public class InstrumentationBaseException : Exception {
+        public InstrumentationBaseException();
+        protected InstrumentationBaseException(SerializationInfo info, StreamingContext context);
+        public InstrumentationBaseException(string message);
+        public InstrumentationBaseException(string message, Exception innerException);
+    }
+    public class InstrumentationClassAttribute : Attribute {
+        public InstrumentationClassAttribute(InstrumentationType instrumentationType);
+        public InstrumentationClassAttribute(InstrumentationType instrumentationType, string managedBaseClassName);
+        public InstrumentationType InstrumentationType { get; }
+        public string ManagedBaseClassName { get; }
+    }
+    public class InstrumentationException : InstrumentationBaseException {
+        public InstrumentationException();
+        public InstrumentationException(Exception innerException);
+        protected InstrumentationException(SerializationInfo info, StreamingContext context);
+        public InstrumentationException(string message);
+        public InstrumentationException(string message, Exception innerException);
+    }
+    public static class InstrumentationManager {
+        public static void Publish(object value);
+        public static void RegisterAssembly(Assembly managementAssembly);
+        public static void RegisterType(Type managementType);
+        public static void Revoke(object value);
+        public static void UnregisterAssembly(Assembly managementAssembly);
+        public static void UnregisterType(Type managementType);
+    }
+    public enum InstrumentationType {
+        Abstract = 2,
+        Event = 1,
+        Instance = 0,
+    }
+    public class InstrumentedAttribute : Attribute {
+        public InstrumentedAttribute();
+        public InstrumentedAttribute(string namespaceName);
+        public InstrumentedAttribute(string namespaceName, string securityDescriptor);
+        public string NamespaceName { get; }
+        public string SecurityDescriptor { get; }
+    }
+    public class ManagedCommonProvider {
+        public ManagedCommonProvider();
+    }
+    public class ManagedNameAttribute : Attribute {
+        public ManagedNameAttribute(string name);
+        public string Name { get; }
+    }
+    public sealed class ManagementBindAttribute : ManagementNewInstanceAttribute {
+        public ManagementBindAttribute();
+        public Type Schema { get; set; }
+    }
+    public sealed class ManagementCommitAttribute : ManagementMemberAttribute {
+        public ManagementCommitAttribute();
+    }
+    public sealed class ManagementConfigurationAttribute : ManagementMemberAttribute {
+        public ManagementConfigurationAttribute();
+        public ManagementConfigurationType Mode { get; set; }
+        public Type Schema { get; set; }
+    }
+    public enum ManagementConfigurationType {
+        Apply = 0,
+        OnCommit = 1,
+    }
+    public sealed class ManagementCreateAttribute : ManagementNewInstanceAttribute {
+        public ManagementCreateAttribute();
+    }
+    public sealed class ManagementEntityAttribute : Attribute {
+        public ManagementEntityAttribute();
+        public bool External { get; set; }
+        public string Name { get; set; }
+        public bool Singleton { get; set; }
+    }
+    public sealed class ManagementEnumeratorAttribute : ManagementNewInstanceAttribute {
+        public ManagementEnumeratorAttribute();
+        public Type Schema { get; set; }
+    }
+    public enum ManagementHostingModel {
+        Decoupled = 0,
+        LocalService = 2,
+        LocalSystem = 3,
+        NetworkService = 1,
+    }
+    public class ManagementInstaller : Installer {
+        public ManagementInstaller();
+        public override string HelpText { get; }
+        public override void Commit(IDictionary savedState);
+        public override void Install(IDictionary savedState);
+        public override void Rollback(IDictionary savedState);
+        public override void Uninstall(IDictionary savedState);
+    }
+    public sealed class ManagementKeyAttribute : ManagementMemberAttribute {
+        public ManagementKeyAttribute();
+    }
+    public abstract class ManagementMemberAttribute : Attribute {
+        protected ManagementMemberAttribute();
+        public string Name { get; set; }
+    }
+    public sealed class ManagementNameAttribute : Attribute {
+        public ManagementNameAttribute(string name);
+        public string Name { get; }
+    }
+    public abstract class ManagementNewInstanceAttribute : ManagementMemberAttribute {
+        protected ManagementNewInstanceAttribute();
+    }
+    public sealed class ManagementProbeAttribute : ManagementMemberAttribute {
+        public ManagementProbeAttribute();
+        public Type Schema { get; set; }
+    }
+    public sealed class ManagementQualifierAttribute : Attribute {
+        public ManagementQualifierAttribute(string name);
+        public ManagementQualifierFlavors Flavor { get; set; }
+        public string Name { get; }
+        public object Value { get; set; }
+    }
+    public enum ManagementQualifierFlavors {
+        Amended = 1,
+        ClassOnly = 4,
+        DisableOverride = 2,
+        ThisClassOnly = 8,
+    }
+    public sealed class ManagementReferenceAttribute : Attribute {
+        public ManagementReferenceAttribute();
+        public string Type { get; set; }
+    }
+    public sealed class ManagementRemoveAttribute : ManagementMemberAttribute {
+        public ManagementRemoveAttribute();
+        public Type Schema { get; set; }
+    }
+    public sealed class ManagementTaskAttribute : ManagementMemberAttribute {
+        public ManagementTaskAttribute();
+        public Type Schema { get; set; }
+    }
+    public sealed class WmiConfigurationAttribute : Attribute {
+        public WmiConfigurationAttribute(string scope);
+        public string HostingGroup { get; set; }
+        public ManagementHostingModel HostingModel { get; set; }
+        public bool IdentifyLevel { get; set; }
+        public string NamespaceSecurity { get; set; }
+        public string Scope { get; }
+        public string SecurityRestriction { get; set; }
+    }
+    public class WmiProviderInstallationException : Exception {
+        public WmiProviderInstallationException();
+        protected WmiProviderInstallationException(SerializationInfo info, StreamingContext context);
+        public WmiProviderInstallationException(string message);
+        public WmiProviderInstallationException(string message, Exception innerException);
+    }
+}
```

