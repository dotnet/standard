# System.ServiceModel.Activities.Configuration

``` diff
+namespace System.ServiceModel.Activities.Configuration {
+    public sealed class BufferedReceiveElement : BehaviorExtensionElement {
+        public BufferedReceiveElement();
+        public override Type BehaviorType { get; }
+        public int MaxPendingMessagesPerChannel { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected internal override object CreateBehavior();
+    }
+    public sealed class ChannelSettingsElement : ConfigurationElement {
+        public ChannelSettingsElement();
+        public TimeSpan IdleTimeout { get; set; }
+        public TimeSpan LeaseTimeout { get; set; }
+        public int MaxItemsInCache { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public class EtwTrackingBehaviorElement : BehaviorExtensionElement {
+        public EtwTrackingBehaviorElement();
+        public override Type BehaviorType { get; }
+        public string ProfileName { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected internal override object CreateBehavior();
+    }
+    public sealed class FactorySettingsElement : ConfigurationElement {
+        public FactorySettingsElement();
+        public TimeSpan IdleTimeout { get; set; }
+        public TimeSpan LeaseTimeout { get; set; }
+        public int MaxItemsInCache { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class SendMessageChannelCacheElement : BehaviorExtensionElement {
+        public SendMessageChannelCacheElement();
+        public bool AllowUnsafeCaching { get; set; }
+        public override Type BehaviorType { get; }
+        public ChannelSettingsElement ChannelSettings { get; }
+        public FactorySettingsElement FactorySettings { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected internal override object CreateBehavior();
+    }
+    public sealed class ServiceModelActivitiesSectionGroup : ConfigurationSectionGroup {
+        public ServiceModelActivitiesSectionGroup();
+        public WorkflowHostingOptionsSection WorkflowHostingOptionsSection { get; }
+        public static ServiceModelActivitiesSectionGroup GetSectionGroup(Configuration config);
+    }
+    public class SqlWorkflowInstanceStoreElement : BehaviorExtensionElement {
+        public SqlWorkflowInstanceStoreElement();
+        public override Type BehaviorType { get; }
+        public string ConnectionString { get; set; }
+        public string ConnectionStringName { get; set; }
+        public TimeSpan HostLockRenewalPeriod { get; set; }
+        public InstanceCompletionAction InstanceCompletionAction { get; set; }
+        public InstanceEncodingOption InstanceEncodingOption { get; set; }
+        public InstanceLockedExceptionAction InstanceLockedExceptionAction { get; set; }
+        public int MaxConnectionRetries { get; set; }
+        public TimeSpan RunnableInstancesDetectionPeriod { get; set; }
+        protected internal override object CreateBehavior();
+    }
+    public class WorkflowControlEndpointCollectionElement : StandardEndpointCollectionElement<WorkflowControlEndpoint, WorkflowControlEndpointElement> {
+        public WorkflowControlEndpointCollectionElement();
+    }
+    public class WorkflowControlEndpointElement : StandardEndpointElement {
+        public WorkflowControlEndpointElement();
+        public Uri Address { get; set; }
+        public string Binding { get; set; }
+        public string BindingConfiguration { get; set; }
+        protected internal override Type EndpointType { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected internal override ServiceEndpoint CreateServiceEndpoint(ContractDescription contractDescription);
+        protected override void OnApplyConfiguration(ServiceEndpoint endpoint, ChannelEndpointElement channelEndpointElement);
+        protected override void OnApplyConfiguration(ServiceEndpoint endpoint, ServiceEndpointElement serviceEndpointElement);
+        protected override void OnInitializeAndValidate(ChannelEndpointElement channelEndpointElement);
+        protected override void OnInitializeAndValidate(ServiceEndpointElement serviceEndpointElement);
+    }
+    public sealed class WorkflowHostingOptionsSection : ConfigurationSection {
+        public WorkflowHostingOptionsSection();
+        public bool OverrideSiteName { get; set; }
+    }
+    public sealed class WorkflowIdleElement : BehaviorExtensionElement {
+        public WorkflowIdleElement();
+        public override Type BehaviorType { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public TimeSpan TimeToPersist { get; set; }
+        public TimeSpan TimeToUnload { get; set; }
+        protected internal override object CreateBehavior();
+    }
+    public class WorkflowInstanceManagementElement : BehaviorExtensionElement {
+        public WorkflowInstanceManagementElement();
+        public string AuthorizedWindowsGroup { get; set; }
+        public override Type BehaviorType { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected internal override object CreateBehavior();
+    }
+    public sealed class WorkflowUnhandledExceptionElement : BehaviorExtensionElement {
+        public WorkflowUnhandledExceptionElement();
+        public WorkflowUnhandledExceptionAction Action { get; set; }
+        public override Type BehaviorType { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected internal override object CreateBehavior();
+    }
+}
```

