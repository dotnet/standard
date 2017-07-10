# System.ServiceModel.Discovery.Configuration

``` diff
+namespace System.ServiceModel.Discovery.Configuration {
+    public sealed class AnnouncementChannelEndpointElementCollection : ServiceModelConfigurationElementCollection<ChannelEndpointElement> {
+        public AnnouncementChannelEndpointElementCollection();
+        protected override object GetElementKey(ConfigurationElement element);
+    }
+    public class AnnouncementEndpointCollectionElement : StandardEndpointCollectionElement<AnnouncementEndpoint, AnnouncementEndpointElement> {
+        public AnnouncementEndpointCollectionElement();
+    }
+    public class AnnouncementEndpointElement : StandardEndpointElement {
+        public AnnouncementEndpointElement();
+        public DiscoveryVersion DiscoveryVersion { get; set; }
+        protected internal override Type EndpointType { get; }
+        public TimeSpan MaxAnnouncementDelay { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected internal override ServiceEndpoint CreateServiceEndpoint(ContractDescription contractDescription);
+        protected internal override void InitializeFrom(ServiceEndpoint endpoint);
+        protected override void OnApplyConfiguration(ServiceEndpoint endpoint, ChannelEndpointElement serviceEndpointElement);
+        protected override void OnApplyConfiguration(ServiceEndpoint endpoint, ServiceEndpointElement serviceEndpointElement);
+        protected override void OnInitializeAndValidate(ChannelEndpointElement channelEndpointElement);
+        protected override void OnInitializeAndValidate(ServiceEndpointElement serviceEndpointElement);
+    }
+    public sealed class ContractTypeNameElement : ConfigurationElement {
+        public ContractTypeNameElement();
+        public ContractTypeNameElement(string name, string ns);
+        public string Name { get; set; }
+        public string Namespace { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class ContractTypeNameElementCollection : ServiceModelConfigurationElementCollection<ContractTypeNameElement> {
+        public ContractTypeNameElementCollection();
+        protected override object GetElementKey(ConfigurationElement element);
+    }
+    public sealed class DiscoveryClientElement : BindingElementExtensionElement {
+        public DiscoveryClientElement();
+        public override Type BindingElementType { get; }
+        public ChannelEndpointElement DiscoveryEndpoint { get; }
+        public FindCriteriaElement FindCriteria { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public override void ApplyConfiguration(BindingElement bindingElement);
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected internal override BindingElement CreateBindingElement();
+        protected internal override void InitializeFrom(BindingElement bindingElement);
+    }
+    public sealed class DiscoveryClientSettingsElement : ConfigurationElement {
+        public DiscoveryClientSettingsElement();
+        public ChannelEndpointElement DiscoveryEndpoint { get; }
+        public FindCriteriaElement FindCriteria { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public class DiscoveryEndpointCollectionElement : StandardEndpointCollectionElement<DiscoveryEndpoint, DiscoveryEndpointElement> {
+        public DiscoveryEndpointCollectionElement();
+    }
+    public class DiscoveryEndpointElement : StandardEndpointElement {
+        public DiscoveryEndpointElement();
+        public ServiceDiscoveryMode DiscoveryMode { get; set; }
+        public DiscoveryVersion DiscoveryVersion { get; set; }
+        protected internal override Type EndpointType { get; }
+        public TimeSpan MaxResponseDelay { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected internal override ServiceEndpoint CreateServiceEndpoint(ContractDescription contractDescription);
+        protected internal override void InitializeFrom(ServiceEndpoint endpoint);
+        protected override void OnApplyConfiguration(ServiceEndpoint endpoint, ChannelEndpointElement serviceEndpointElement);
+        protected override void OnApplyConfiguration(ServiceEndpoint endpoint, ServiceEndpointElement serviceEndpointElement);
+        protected override void OnInitializeAndValidate(ChannelEndpointElement channelEndpointElement);
+        protected override void OnInitializeAndValidate(ServiceEndpointElement serviceEndpointElement);
+    }
+    public class DiscoveryVersionConverter : TypeConverter {
+        public DiscoveryVersionConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public class DynamicEndpointCollectionElement : StandardEndpointCollectionElement<DynamicEndpoint, DynamicEndpointElement> {
+        public DynamicEndpointCollectionElement();
+    }
+    public sealed class DynamicEndpointElement : StandardEndpointElement {
+        public DynamicEndpointElement();
+        public DiscoveryClientSettingsElement DiscoveryClientSettings { get; }
+        protected internal override Type EndpointType { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected internal override ServiceEndpoint CreateServiceEndpoint(ContractDescription contractDescription);
+        protected override void OnApplyConfiguration(ServiceEndpoint endpoint, ChannelEndpointElement serviceEndpointElement);
+        protected override void OnApplyConfiguration(ServiceEndpoint endpoint, ServiceEndpointElement serviceEndpointElement);
+        protected override void OnInitializeAndValidate(ChannelEndpointElement channelEndpointElement);
+        protected override void OnInitializeAndValidate(ServiceEndpointElement serviceEndpointElement);
+    }
+    public sealed class EndpointDiscoveryElement : BehaviorExtensionElement {
+        public EndpointDiscoveryElement();
+        public override Type BehaviorType { get; }
+        public ContractTypeNameElementCollection ContractTypeNames { get; }
+        public bool Enabled { get; set; }
+        public XmlElementElementCollection Extensions { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public ScopeElementCollection Scopes { get; }
+        protected internal override object CreateBehavior();
+    }
+    public sealed class FindCriteriaElement : ConfigurationElement {
+        public FindCriteriaElement();
+        public ContractTypeNameElementCollection ContractTypeNames { get; }
+        public TimeSpan Duration { get; set; }
+        public XmlElementElementCollection Extensions { get; }
+        public int MaxResults { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public Uri ScopeMatchBy { get; set; }
+        public ScopeElementCollection Scopes { get; }
+    }
+    public sealed class ScopeElement : ConfigurationElement {
+        public ScopeElement();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public Uri Scope { get; set; }
+    }
+    public sealed class ScopeElementCollection : ServiceModelConfigurationElementCollection<ScopeElement> {
+        public ScopeElementCollection();
+        protected override object GetElementKey(ConfigurationElement element);
+    }
+    public sealed class ServiceDiscoveryElement : BehaviorExtensionElement {
+        public ServiceDiscoveryElement();
+        public AnnouncementChannelEndpointElementCollection AnnouncementEndpoints { get; }
+        public override Type BehaviorType { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected internal override object CreateBehavior();
+    }
+    public class UdpAnnouncementEndpointCollectionElement : StandardEndpointCollectionElement<UdpAnnouncementEndpoint, UdpAnnouncementEndpointElement> {
+        public UdpAnnouncementEndpointCollectionElement();
+    }
+    public class UdpAnnouncementEndpointElement : AnnouncementEndpointElement {
+        public UdpAnnouncementEndpointElement();
+        protected internal override Type EndpointType { get; }
+        public new TimeSpan MaxAnnouncementDelay { get; set; }
+        public Uri MulticastAddress { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public UdpTransportSettingsElement TransportSettings { get; }
+        protected internal override ServiceEndpoint CreateServiceEndpoint(ContractDescription contractDescription);
+        protected internal override void InitializeFrom(ServiceEndpoint endpoint);
+        protected override void OnApplyConfiguration(ServiceEndpoint endpoint, ChannelEndpointElement serviceEndpointElement);
+        protected override void OnApplyConfiguration(ServiceEndpoint endpoint, ServiceEndpointElement serviceEndpointElement);
+        protected override void OnInitializeAndValidate(ChannelEndpointElement channelEndpointElement);
+        protected override void OnInitializeAndValidate(ServiceEndpointElement serviceEndpointElement);
+    }
+    public class UdpDiscoveryEndpointCollectionElement : StandardEndpointCollectionElement<UdpDiscoveryEndpoint, UdpDiscoveryEndpointElement> {
+        public UdpDiscoveryEndpointCollectionElement();
+    }
+    public class UdpDiscoveryEndpointElement : DiscoveryEndpointElement {
+        public UdpDiscoveryEndpointElement();
+        public new ServiceDiscoveryMode DiscoveryMode { get; set; }
+        protected internal override Type EndpointType { get; }
+        public new TimeSpan MaxResponseDelay { get; set; }
+        public Uri MulticastAddress { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public UdpTransportSettingsElement TransportSettings { get; }
+        protected internal override ServiceEndpoint CreateServiceEndpoint(ContractDescription contractDescription);
+        protected internal override void InitializeFrom(ServiceEndpoint endpoint);
+        protected override void OnApplyConfiguration(ServiceEndpoint endpoint, ChannelEndpointElement serviceEndpointElement);
+        protected override void OnApplyConfiguration(ServiceEndpoint endpoint, ServiceEndpointElement serviceEndpointElement);
+        protected override void OnInitializeAndValidate(ChannelEndpointElement channelEndpointElement);
+        protected override void OnInitializeAndValidate(ServiceEndpointElement serviceEndpointElement);
+    }
+    public sealed class UdpTransportSettingsElement : ConfigurationElement {
+        public UdpTransportSettingsElement();
+        public int DuplicateMessageHistoryLength { get; set; }
+        public long MaxBufferPoolSize { get; set; }
+        public int MaxMulticastRetransmitCount { get; set; }
+        public int MaxPendingMessageCount { get; set; }
+        public long MaxReceivedMessageSize { get; set; }
+        public int MaxUnicastRetransmitCount { get; set; }
+        public string MulticastInterfaceId { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public int SocketReceiveBufferSize { get; set; }
+        public int TimeToLive { get; set; }
+    }
+}
```

