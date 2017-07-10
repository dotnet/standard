# System.ServiceModel.Configuration

``` diff
+namespace System.ServiceModel.Configuration {
+    public sealed class AddressHeaderCollectionElement : ServiceModelConfigurationElement {
+        public AddressHeaderCollectionElement();
+        public AddressHeaderCollection Headers { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey);
+        protected override bool SerializeToXmlElement(XmlWriter writer, string elementName);
+    }
+    public sealed class AllowedAudienceUriElement : ConfigurationElement {
+        public AllowedAudienceUriElement();
+        public string AllowedAudienceUri { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class AllowedAudienceUriElementCollection : ServiceModelConfigurationElementCollection<AllowedAudienceUriElement> {
+        public AllowedAudienceUriElementCollection();
+        protected override bool ThrowOnDuplicate { get; }
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+    }
+    public sealed class ApplicationContainerSettingsElement : ServiceModelConfigurationElement {
+        public ApplicationContainerSettingsElement();
+        public string PackageFullName { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public int SessionId { get; set; }
+    }
+    public enum AuthenticationMode {
+        AnonymousForCertificate = 0,
+        AnonymousForSslNegotiated = 1,
+        CertificateOverTransport = 2,
+        IssuedToken = 3,
+        IssuedTokenForCertificate = 4,
+        IssuedTokenForSslNegotiated = 5,
+        IssuedTokenOverTransport = 6,
+        Kerberos = 7,
+        KerberosOverTransport = 8,
+        MutualCertificate = 9,
+        MutualCertificateDuplex = 10,
+        MutualSslNegotiated = 11,
+        SecureConversation = 12,
+        SspiNegotiated = 13,
+        SspiNegotiatedOverTransport = 17,
+        UserNameForCertificate = 14,
+        UserNameForSslNegotiated = 15,
+        UserNameOverTransport = 16,
+    }
+    public sealed class AuthorizationPolicyTypeElement : ConfigurationElement {
+        public AuthorizationPolicyTypeElement();
+        public AuthorizationPolicyTypeElement(string policyType);
+        public string PolicyType { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class AuthorizationPolicyTypeElementCollection : ServiceModelConfigurationElementCollection<AuthorizationPolicyTypeElement> {
+        public AuthorizationPolicyTypeElementCollection();
+        protected override object GetElementKey(ConfigurationElement element);
+    }
+    public sealed class BaseAddressElement : ConfigurationElement {
+        public BaseAddressElement();
+        public string BaseAddress { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class BaseAddressElementCollection : ServiceModelConfigurationElementCollection<BaseAddressElement> {
+        public BaseAddressElementCollection();
+        protected override bool ThrowOnDuplicate { get; }
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+    }
+    public sealed class BaseAddressPrefixFilterElement : ConfigurationElement {
+        public BaseAddressPrefixFilterElement();
+        public BaseAddressPrefixFilterElement(Uri prefix);
+        public Uri Prefix { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class BaseAddressPrefixFilterElementCollection : ServiceModelConfigurationElementCollection<BaseAddressPrefixFilterElement> {
+        public BaseAddressPrefixFilterElementCollection();
+        protected override bool ThrowOnDuplicate { get; }
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+    }
+    public class BasicHttpBindingCollectionElement : StandardBindingCollectionElement<BasicHttpBinding, BasicHttpBindingElement> {
+        public BasicHttpBindingCollectionElement();
+    }
+    public class BasicHttpBindingElement : HttpBindingBaseElement {
+        public BasicHttpBindingElement();
+        public BasicHttpBindingElement(string name);
+        protected override Type BindingElementType { get; }
+        public WSMessageEncoding MessageEncoding { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public BasicHttpSecurityElement Security { get; }
+        protected internal override void InitializeFrom(Binding binding);
+        protected override void OnApplyConfiguration(Binding binding);
+    }
+    public class BasicHttpContextBindingCollectionElement : StandardBindingCollectionElement<BasicHttpContextBinding, BasicHttpContextBindingElement> {
+        public BasicHttpContextBindingCollectionElement();
+    }
+    public class BasicHttpContextBindingElement : BasicHttpBindingElement {
+        public BasicHttpContextBindingElement();
+        public BasicHttpContextBindingElement(string name);
+        protected override Type BindingElementType { get; }
+        public bool ContextManagementEnabled { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected internal override void InitializeFrom(Binding binding);
+        protected override void OnApplyConfiguration(Binding binding);
+    }
+    public sealed class BasicHttpMessageSecurityElement : ServiceModelConfigurationElement {
+        public BasicHttpMessageSecurityElement();
+        public SecurityAlgorithmSuite AlgorithmSuite { get; set; }
+        public BasicHttpMessageCredentialType ClientCredentialType { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public class BasicHttpsBindingCollectionElement : StandardBindingCollectionElement<BasicHttpsBinding, BasicHttpsBindingElement> {
+        public BasicHttpsBindingCollectionElement();
+    }
+    public class BasicHttpsBindingElement : HttpBindingBaseElement {
+        public BasicHttpsBindingElement();
+        public BasicHttpsBindingElement(string name);
+        protected override Type BindingElementType { get; }
+        public WSMessageEncoding MessageEncoding { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public BasicHttpsSecurityElement Security { get; }
+        protected internal override void InitializeFrom(Binding binding);
+        protected override void OnApplyConfiguration(Binding binding);
+    }
+    public sealed class BasicHttpSecurityElement : ServiceModelConfigurationElement {
+        public BasicHttpSecurityElement();
+        public BasicHttpMessageSecurityElement Message { get; }
+        public BasicHttpSecurityMode Mode { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public HttpTransportSecurityElement Transport { get; }
+    }
+    public sealed class BasicHttpsSecurityElement : ServiceModelConfigurationElement {
+        public BasicHttpsSecurityElement();
+        public BasicHttpMessageSecurityElement Message { get; }
+        public BasicHttpsSecurityMode Mode { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public HttpTransportSecurityElement Transport { get; }
+    }
+    public abstract class BehaviorExtensionElement : ServiceModelExtensionElement {
+        protected BehaviorExtensionElement();
+        public abstract Type BehaviorType { get; }
+        protected internal abstract object CreateBehavior();
+    }
+    public class BehaviorsSection : ConfigurationSection {
+        public BehaviorsSection();
+        public EndpointBehaviorElementCollection EndpointBehaviors { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public ServiceBehaviorElementCollection ServiceBehaviors { get; }
+    }
+    public sealed class BinaryMessageEncodingElement : BindingElementExtensionElement {
+        public BinaryMessageEncodingElement();
+        public override Type BindingElementType { get; }
+        public CompressionFormat CompressionFormat { get; set; }
+        public int MaxReadPoolSize { get; set; }
+        public int MaxSessionSize { get; set; }
+        public int MaxWritePoolSize { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public XmlDictionaryReaderQuotasElement ReaderQuotas { get; }
+        public override void ApplyConfiguration(BindingElement bindingElement);
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected internal override BindingElement CreateBindingElement();
+        protected internal override void InitializeFrom(BindingElement bindingElement);
+    }
+    public abstract class BindingCollectionElement : ConfigurationElement, IConfigurationContextProviderInternal {
+        protected BindingCollectionElement();
+        public string BindingName { get; }
+        public abstract Type BindingType { get; }
+        public abstract ReadOnlyCollection<IBindingConfigurationElement> ConfiguredBindings { get; }
+        public abstract bool ContainsKey(string name);
+        protected internal abstract Binding GetDefault();
+        protected internal abstract bool TryAdd(string name, Binding binding, Configuration config);
+    }
+    public abstract class BindingElementExtensionElement : ServiceModelExtensionElement {
+        protected BindingElementExtensionElement();
+        public abstract Type BindingElementType { get; }
+        public virtual void ApplyConfiguration(BindingElement bindingElement);
+        protected internal abstract BindingElement CreateBindingElement();
+        protected internal virtual void InitializeFrom(BindingElement bindingElement);
+    }
+    public sealed class BindingsSection : ConfigurationSection, IConfigurationContextProviderInternal {
+        public BindingsSection();
+        public BasicHttpBindingCollectionElement BasicHttpBinding { get; }
+        public BasicHttpsBindingCollectionElement BasicHttpsBinding { get; }
+        public List<BindingCollectionElement> BindingCollections { get; }
+        public CustomBindingCollectionElement CustomBinding { get; }
+        public MsmqIntegrationBindingCollectionElement MsmqIntegrationBinding { get; }
+        public NetHttpBindingCollectionElement NetHttpBinding { get; }
+        public NetHttpsBindingCollectionElement NetHttpsBinding { get; }
+        public NetMsmqBindingCollectionElement NetMsmqBinding { get; }
+        public NetNamedPipeBindingCollectionElement NetNamedPipeBinding { get; }
+        public NetPeerTcpBindingCollectionElement NetPeerTcpBinding { get; }
+        public NetTcpBindingCollectionElement NetTcpBinding { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public new BindingCollectionElement this[string binding] { get; }
+        public WS2007FederationHttpBindingCollectionElement WS2007FederationHttpBinding { get; }
+        public WS2007HttpBindingCollectionElement WS2007HttpBinding { get; }
+        public WSDualHttpBindingCollectionElement WSDualHttpBinding { get; }
+        public WSFederationHttpBindingCollectionElement WSFederationHttpBinding { get; }
+        public WSHttpBindingCollectionElement WSHttpBinding { get; }
+        public static BindingsSection GetSection(Configuration config);
+        protected override bool OnDeserializeUnrecognizedElement(string elementName, XmlReader reader);
+    }
+    public sealed class ByteStreamMessageEncodingElement : BindingElementExtensionElement {
+        public ByteStreamMessageEncodingElement();
+        public override Type BindingElementType { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public XmlDictionaryReaderQuotasElement ReaderQuotas { get; }
+        public override void ApplyConfiguration(BindingElement bindingElement);
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected internal override BindingElement CreateBindingElement();
+        protected internal override void InitializeFrom(BindingElement bindingElement);
+    }
+    public sealed class CallbackDebugElement : BehaviorExtensionElement {
+        public CallbackDebugElement();
+        public override Type BehaviorType { get; }
+        public bool IncludeExceptionDetailInFaults { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected internal override object CreateBehavior();
+    }
+    public sealed class CallbackTimeoutsElement : BehaviorExtensionElement {
+        public CallbackTimeoutsElement();
+        public override Type BehaviorType { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public TimeSpan TransactionTimeout { get; set; }
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected internal override object CreateBehavior();
+    }
+    public sealed class CertificateElement : ConfigurationElement {
+        public CertificateElement();
+        public string EncodedValue { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class CertificateReferenceElement : ConfigurationElement {
+        public CertificateReferenceElement();
+        public string FindValue { get; set; }
+        public bool IsChainIncluded { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public StoreLocation StoreLocation { get; set; }
+        public StoreName StoreName { get; set; }
+        public X509FindType X509FindType { get; set; }
+    }
+    public sealed class ChannelEndpointElement : ConfigurationElement, IConfigurationContextProviderInternal {
+        public ChannelEndpointElement();
+        public ChannelEndpointElement(EndpointAddress address, string contractType);
+        public Uri Address { get; set; }
+        public string BehaviorConfiguration { get; set; }
+        public string Binding { get; set; }
+        public string BindingConfiguration { get; set; }
+        public string Contract { get; set; }
+        public string EndpointConfiguration { get; set; }
+        public AddressHeaderCollectionElement Headers { get; }
+        public IdentityElement Identity { get; }
+        public string Kind { get; set; }
+        public string Name { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected override void Reset(ConfigurationElement parentElement);
+    }
+    public sealed class ChannelEndpointElementCollection : ServiceModelEnhancedConfigurationElementCollection<ChannelEndpointElement> {
+        public ChannelEndpointElementCollection();
+        protected override object GetElementKey(ConfigurationElement element);
+    }
+    public sealed class ChannelPoolSettingsElement : ServiceModelConfigurationElement {
+        public ChannelPoolSettingsElement();
+        public TimeSpan IdleTimeout { get; set; }
+        public TimeSpan LeaseTimeout { get; set; }
+        public int MaxOutboundChannelsPerEndpoint { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class ClaimTypeElement : ConfigurationElement {
+        public ClaimTypeElement();
+        public ClaimTypeElement(string claimType, bool isOptional);
+        public string ClaimType { get; set; }
+        public bool IsOptional { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class ClaimTypeElementCollection : ServiceModelConfigurationElementCollection<ClaimTypeElement> {
+        public ClaimTypeElementCollection();
+        protected override object GetElementKey(ConfigurationElement element);
+    }
+    public sealed class ClearBehaviorElement : BehaviorExtensionElement {
+        public ClearBehaviorElement();
+        public override Type BehaviorType { get; }
+        protected internal override object CreateBehavior();
+    }
+    public class ClientCredentialsElement : BehaviorExtensionElement {
+        public ClientCredentialsElement();
+        public override Type BehaviorType { get; }
+        public X509InitiatorCertificateClientElement ClientCertificate { get; }
+        public HttpDigestClientElement HttpDigest { get; }
+        public IssuedTokenClientElement IssuedToken { get; }
+        public PeerCredentialElement Peer { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public X509RecipientCertificateClientElement ServiceCertificate { get; }
+        public bool SupportInteractive { get; set; }
+        public string Type { get; set; }
+        public bool UseIdentityConfiguration { get; set; }
+        public WindowsClientElement Windows { get; }
+        protected internal void ApplyConfiguration(ClientCredentials behavior);
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected internal override object CreateBehavior();
+    }
+    public sealed class ClientSection : ConfigurationSection, IConfigurationContextProviderInternal {
+        public ClientSection();
+        public ChannelEndpointElementCollection Endpoints { get; }
+        public MetadataElement Metadata { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected override void InitializeDefault();
+        protected override void PostDeserialize();
+    }
+    public sealed class ClientViaElement : BehaviorExtensionElement {
+        public ClientViaElement();
+        public override Type BehaviorType { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public Uri ViaUri { get; set; }
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected internal override object CreateBehavior();
+    }
+    public sealed class ComContractElement : ConfigurationElement {
+        public ComContractElement();
+        public ComContractElement(string contractType);
+        public string Contract { get; set; }
+        public ComMethodElementCollection ExposedMethods { get; }
+        public string Name { get; set; }
+        public string Namespace { get; set; }
+        public ComPersistableTypeElementCollection PersistableTypes { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public bool RequiresSession { get; set; }
+        public ComUdtElementCollection UserDefinedTypes { get; }
+    }
+    public sealed class ComContractElementCollection : ServiceModelEnhancedConfigurationElementCollection<ComContractElement> {
+        public ComContractElementCollection();
+        protected override bool ThrowOnDuplicate { get; }
+        protected override object GetElementKey(ConfigurationElement element);
+    }
+    public sealed class ComContractsSection : ConfigurationSection {
+        public ComContractsSection();
+        public ComContractElementCollection ComContracts { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class ComMethodElement : ConfigurationElement {
+        public ComMethodElement();
+        public ComMethodElement(string method);
+        public string ExposedMethod { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class ComMethodElementCollection : ServiceModelEnhancedConfigurationElementCollection<ComMethodElement> {
+        public ComMethodElementCollection();
+        protected override bool ThrowOnDuplicate { get; }
+        protected override object GetElementKey(ConfigurationElement element);
+    }
+    public class CommonBehaviorsSection : ConfigurationSection {
+        public CommonBehaviorsSection();
+        public CommonEndpointBehaviorElement EndpointBehaviors { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public CommonServiceBehaviorElement ServiceBehaviors { get; }
+    }
+    public class CommonEndpointBehaviorElement : ServiceModelExtensionCollectionElement<BehaviorExtensionElement> {
+        public CommonEndpointBehaviorElement();
+        public override void Add(BehaviorExtensionElement element);
+        public override bool CanAdd(BehaviorExtensionElement element);
+    }
+    public class CommonServiceBehaviorElement : ServiceModelExtensionCollectionElement<BehaviorExtensionElement> {
+        public CommonServiceBehaviorElement();
+        public override void Add(BehaviorExtensionElement element);
+        public override bool CanAdd(BehaviorExtensionElement element);
+    }
+    public sealed class ComPersistableTypeElement : ConfigurationElement {
+        public ComPersistableTypeElement();
+        public ComPersistableTypeElement(string ID);
+        public string ID { get; set; }
+        public string Name { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class ComPersistableTypeElementCollection : ServiceModelEnhancedConfigurationElementCollection<ComPersistableTypeElement> {
+        public ComPersistableTypeElementCollection();
+        protected override bool ThrowOnDuplicate { get; }
+        protected override object GetElementKey(ConfigurationElement element);
+    }
+    public sealed class CompositeDuplexElement : BindingElementExtensionElement {
+        public CompositeDuplexElement();
+        public override Type BindingElementType { get; }
+        public Uri ClientBaseAddress { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public override void ApplyConfiguration(BindingElement bindingElement);
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected internal override BindingElement CreateBindingElement();
+        protected internal override void InitializeFrom(BindingElement bindingElement);
+    }
+    public sealed class ComUdtElement : ConfigurationElement {
+        public ComUdtElement();
+        public ComUdtElement(string typeDefID);
+        public string Name { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string TypeDefID { get; set; }
+        public string TypeLibID { get; set; }
+        public string TypeLibVersion { get; set; }
+    }
+    public sealed class ComUdtElementCollection : ServiceModelEnhancedConfigurationElementCollection<ComUdtElement> {
+        public ComUdtElementCollection();
+        protected override bool ThrowOnDuplicate { get; }
+        protected override object GetElementKey(ConfigurationElement element);
+    }
+    public sealed class ConfigurationChannelFactory<TChannel> : ChannelFactory<TChannel> {
+        public ConfigurationChannelFactory(string endpointConfigurationName, Configuration configuration, EndpointAddress remoteAddress);
+    }
+    public sealed class ConfigurationDuplexChannelFactory<TChannel> : DuplexChannelFactory<TChannel> {
+        public ConfigurationDuplexChannelFactory(object callbackObject, string endpointConfigurationName, EndpointAddress remoteAddress, Configuration configuration);
+    }
+    public abstract class ConnectionOrientedTransportElement : TransportElement {
+        public TimeSpan ChannelInitializationTimeout { get; set; }
+        public int ConnectionBufferSize { get; set; }
+        public HostNameComparisonMode HostNameComparisonMode { get; set; }
+        public int MaxBufferSize { get; set; }
+        public TimeSpan MaxOutputDelay { get; set; }
+        public int MaxPendingAccepts { get; set; }
+        public int MaxPendingConnections { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public TransferMode TransferMode { get; set; }
+        public override void ApplyConfiguration(BindingElement bindingElement);
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected internal override void InitializeFrom(BindingElement bindingElement);
+    }
+    public class ContextBindingElementExtensionElement : BindingElementExtensionElement {
+        public ContextBindingElementExtensionElement();
+        public override Type BindingElementType { get; }
+        public Uri ClientCallbackAddress { get; set; }
+        public ContextExchangeMechanism ContextExchangeMechanism { get; set; }
+        public bool ContextManagementEnabled { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public ProtectionLevel ProtectionLevel { get; set; }
+        protected internal override BindingElement CreateBindingElement();
+    }
+    public sealed class CustomBindingCollectionElement : BindingCollectionElement {
+        public CustomBindingCollectionElement();
+        public CustomBindingElementCollection Bindings { get; }
+        public override Type BindingType { get; }
+        public override ReadOnlyCollection<IBindingConfigurationElement> ConfiguredBindings { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public override bool ContainsKey(string name);
+        protected internal override Binding GetDefault();
+        protected internal override bool TryAdd(string name, Binding binding, Configuration config);
+    }
+    public class CustomBindingElement : NamedServiceModelExtensionCollectionElement<BindingElementExtensionElement>, IBindingConfigurationElement, ICollection<BindingElementExtensionElement>, IEnumerable, IEnumerable<BindingElementExtensionElement> {
+        public CustomBindingElement();
+        public CustomBindingElement(string name);
+        public TimeSpan CloseTimeout { get; set; }
+        public TimeSpan OpenTimeout { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public TimeSpan ReceiveTimeout { get; set; }
+        public TimeSpan SendTimeout { get; set; }
+        public override void Add(BindingElementExtensionElement element);
+        public void ApplyConfiguration(Binding binding);
+        public override bool CanAdd(BindingElementExtensionElement element);
+        protected void OnApplyConfiguration(Binding binding);
+    }
+    public sealed class CustomBindingElementCollection : ServiceModelEnhancedConfigurationElementCollection<CustomBindingElement> {
+        public CustomBindingElementCollection();
+        protected override object GetElementKey(ConfigurationElement element);
+    }
+    public sealed class DataContractSerializerElement : BehaviorExtensionElement {
+        public DataContractSerializerElement();
+        public override Type BehaviorType { get; }
+        public bool IgnoreExtensionDataObject { get; set; }
+        public int MaxItemsInObjectGraph { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected internal override object CreateBehavior();
+    }
+    public sealed class DefaultPortElement : ConfigurationElement {
+        public DefaultPortElement();
+        public DefaultPortElement(DefaultPortElement other);
+        public int Port { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string Scheme { get; set; }
+    }
+    public sealed class DefaultPortElementCollection : ServiceModelEnhancedConfigurationElementCollection<DefaultPortElement> {
+        public DefaultPortElementCollection();
+        protected override object GetElementKey(ConfigurationElement element);
+    }
+    public sealed class DelegatingHandlerElement : ConfigurationElement {
+        public DelegatingHandlerElement();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string Type { get; set; }
+    }
+    public sealed class DelegatingHandlerElementCollection : ServiceModelConfigurationElementCollection<DelegatingHandlerElement> {
+        public DelegatingHandlerElementCollection();
+        protected override bool ThrowOnDuplicate { get; }
+        protected override object GetElementKey(ConfigurationElement element);
+    }
+    public sealed class DiagnosticSection : ConfigurationSection {
+        public DiagnosticSection();
+        public EndToEndTracingElement EndToEndTracing { get; }
+        public string EtwProviderId { get; set; }
+        public MessageLoggingElement MessageLogging { get; }
+        public PerformanceCounterScope PerformanceCounters { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public bool WmiProviderEnabled { get; set; }
+    }
+    public sealed class DispatcherSynchronizationElement : BehaviorExtensionElement {
+        public DispatcherSynchronizationElement();
+        public bool AsynchronousSendEnabled { get; set; }
+        public override Type BehaviorType { get; }
+        public int MaxPendingReceives { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected internal override object CreateBehavior();
+    }
+    public sealed class DnsElement : ConfigurationElement {
+        public DnsElement();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string Value { get; set; }
+    }
+    public class EndpointAddressElementBase : ServiceModelConfigurationElement {
+        protected EndpointAddressElementBase();
+        public Uri Address { get; set; }
+        public AddressHeaderCollectionElement Headers { get; }
+        public IdentityElement Identity { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected internal void Copy(EndpointAddressElementBase source);
+        public void InitializeFrom(EndpointAddress endpointAddress);
+    }
+    public class EndpointBehaviorElement : NamedServiceModelExtensionCollectionElement<BehaviorExtensionElement> {
+        public EndpointBehaviorElement();
+        public EndpointBehaviorElement(string name);
+        public override void Add(BehaviorExtensionElement element);
+        public override bool CanAdd(BehaviorExtensionElement element);
+    }
+    public sealed class EndpointBehaviorElementCollection : ServiceModelEnhancedConfigurationElementCollection<EndpointBehaviorElement> {
+        public EndpointBehaviorElementCollection();
+        protected override bool ThrowOnDuplicate { get; }
+        protected override void BaseAdd(ConfigurationElement element);
+        protected override object GetElementKey(ConfigurationElement element);
+    }
+    public abstract class EndpointCollectionElement : ConfigurationElement, IConfigurationContextProviderInternal {
+        protected EndpointCollectionElement();
+        public abstract ReadOnlyCollection<StandardEndpointElement> ConfiguredEndpoints { get; }
+        public string EndpointName { get; }
+        public abstract Type EndpointType { get; }
+        public abstract bool ContainsKey(string name);
+        protected internal abstract StandardEndpointElement GetDefaultStandardEndpointElement();
+        protected internal abstract bool TryAdd(string name, ServiceEndpoint endpoint, Configuration config);
+    }
+    public sealed class EndToEndTracingElement : ConfigurationElement {
+        public EndToEndTracingElement();
+        public bool ActivityTracing { get; set; }
+        public bool MessageFlowTracing { get; set; }
+        public bool PropagateActivity { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public class ExtendedWorkflowRuntimeServiceElementCollection : WorkflowRuntimeServiceElementCollection {
+        public ExtendedWorkflowRuntimeServiceElementCollection();
+        public void Remove(string key);
+        public void Remove(WorkflowRuntimeServiceElement serviceSettings);
+    }
+    public class ExtensionElement : ConfigurationElement {
+        public ExtensionElement();
+        public ExtensionElement(string name);
+        public ExtensionElement(string name, string type);
+        public string Name { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string Type { get; set; }
+    }
+    public class ExtensionElementCollection : ServiceModelConfigurationElementCollection<ExtensionElement> {
+        public ExtensionElementCollection();
+        protected override bool ThrowOnDuplicate { get; }
+        protected override void BaseAdd(ConfigurationElement element);
+        protected override void BaseAdd(int index, ConfigurationElement element);
+        protected override object GetElementKey(ConfigurationElement element);
+    }
+    public class ExtensionsSection : ConfigurationSection {
+        public ExtensionsSection();
+        public ExtensionElementCollection BehaviorExtensions { get; }
+        public ExtensionElementCollection BindingElementExtensions { get; }
+        public ExtensionElementCollection BindingExtensions { get; }
+        public ExtensionElementCollection EndpointExtensions { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected override void InitializeDefault();
+    }
+    public sealed class FederatedMessageSecurityOverHttpElement : ServiceModelConfigurationElement {
+        public FederatedMessageSecurityOverHttpElement();
+        public SecurityAlgorithmSuite AlgorithmSuite { get; set; }
+        public ClaimTypeElementCollection ClaimTypeRequirements { get; }
+        public bool EstablishSecurityContext { get; set; }
+        public SecurityKeyType IssuedKeyType { get; set; }
+        public string IssuedTokenType { get; set; }
+        public IssuedTokenParametersEndpointAddressElement Issuer { get; }
+        public EndpointAddressElementBase IssuerMetadata { get; }
+        public bool NegotiateServiceCredential { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public XmlElementElementCollection TokenRequestParameters { get; }
+    }
+    public sealed class HostElement : ConfigurationElement {
+        public HostElement();
+        public BaseAddressElementCollection BaseAddresses { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public HostTimeoutsElement Timeouts { get; }
+    }
+    public sealed class HostTimeoutsElement : ConfigurationElement {
+        public HostTimeoutsElement();
+        public TimeSpan CloseTimeout { get; set; }
+        public TimeSpan OpenTimeout { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public abstract class HttpBindingBaseElement : StandardBindingElement {
+        protected HttpBindingBaseElement(string name);
+        public bool AllowCookies { get; set; }
+        public bool BypassProxyOnLocal { get; set; }
+        public HostNameComparisonMode HostNameComparisonMode { get; set; }
+        public long MaxBufferPoolSize { get; set; }
+        public int MaxBufferSize { get; set; }
+        public long MaxReceivedMessageSize { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public Uri ProxyAddress { get; set; }
+        public XmlDictionaryReaderQuotasElement ReaderQuotas { get; }
+        public Encoding TextEncoding { get; set; }
+        public TransferMode TransferMode { get; set; }
+        public bool UseDefaultWebProxy { get; set; }
+        protected internal override void InitializeFrom(Binding binding);
+        protected override void OnApplyConfiguration(Binding binding);
+    }
+    public sealed class HttpDigestClientElement : ConfigurationElement {
+        public HttpDigestClientElement();
+        public TokenImpersonationLevel ImpersonationLevel { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public void Copy(HttpDigestClientElement from);
+    }
+    public sealed class HttpMessageHandlerFactoryElement : ConfigurationElement {
+        public HttpMessageHandlerFactoryElement();
+        public DelegatingHandlerElementCollection Handlers { get; internal set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string Type { get; set; }
+    }
+    public class HttpsTransportElement : HttpTransportElement {
+        public HttpsTransportElement();
+        public override Type BindingElementType { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public bool RequireClientCertificate { get; set; }
+        public override void ApplyConfiguration(BindingElement bindingElement);
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected override TransportBindingElement CreateDefaultBindingElement();
+        protected internal override void InitializeFrom(BindingElement bindingElement);
+    }
+    public class HttpTransportElement : TransportElement {
+        public HttpTransportElement();
+        public bool AllowCookies { get; set; }
+        public AuthenticationSchemes AuthenticationScheme { get; set; }
+        public override Type BindingElementType { get; }
+        public bool BypassProxyOnLocal { get; set; }
+        public bool DecompressionEnabled { get; set; }
+        public ExtendedProtectionPolicyElement ExtendedProtectionPolicy { get; private set; }
+        public HostNameComparisonMode HostNameComparisonMode { get; set; }
+        public bool KeepAliveEnabled { get; set; }
+        public int MaxBufferSize { get; set; }
+        public int MaxPendingAccepts { get; set; }
+        public HttpMessageHandlerFactoryElement MessageHandlerFactory { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public Uri ProxyAddress { get; set; }
+        public AuthenticationSchemes ProxyAuthenticationScheme { get; set; }
+        public string Realm { get; set; }
+        public TimeSpan RequestInitializationTimeout { get; set; }
+        public TransferMode TransferMode { get; set; }
+        public bool UnsafeConnectionNtlmAuthentication { get; set; }
+        public bool UseDefaultWebProxy { get; set; }
+        public WebSocketTransportSettingsElement WebSocketSettings { get; set; }
+        public override void ApplyConfiguration(BindingElement bindingElement);
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected override TransportBindingElement CreateDefaultBindingElement();
+        protected internal override void InitializeFrom(BindingElement bindingElement);
+    }
+    public sealed class HttpTransportSecurityElement : ServiceModelConfigurationElement {
+        public HttpTransportSecurityElement();
+        public HttpClientCredentialType ClientCredentialType { get; set; }
+        public ExtendedProtectionPolicyElement ExtendedProtectionPolicy { get; private set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public HttpProxyCredentialType ProxyCredentialType { get; set; }
+        public string Realm { get; set; }
+    }
+    public interface IBindingConfigurationElement {
+        TimeSpan CloseTimeout { get; }
+        string Name { get; }
+        TimeSpan OpenTimeout { get; }
+        TimeSpan ReceiveTimeout { get; }
+        TimeSpan SendTimeout { get; }
+        void ApplyConfiguration(Binding binding);
+    }
+    public sealed class IdentityElement : ConfigurationElement {
+        public IdentityElement();
+        public CertificateElement Certificate { get; }
+        public CertificateReferenceElement CertificateReference { get; }
+        public DnsElement Dns { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public RsaElement Rsa { get; }
+        public ServicePrincipalNameElement ServicePrincipalName { get; }
+        public UserPrincipalNameElement UserPrincipalName { get; }
+        public void InitializeFrom(EndpointIdentity identity);
+    }
+    public sealed class IssuedTokenClientBehaviorsElement : ConfigurationElement {
+        public IssuedTokenClientBehaviorsElement();
+        public string BehaviorConfiguration { get; set; }
+        public string IssuerAddress { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class IssuedTokenClientBehaviorsElementCollection : ServiceModelConfigurationElementCollection<IssuedTokenClientBehaviorsElement> {
+        public IssuedTokenClientBehaviorsElementCollection();
+        protected override object GetElementKey(ConfigurationElement element);
+    }
+    public sealed class IssuedTokenClientElement : ConfigurationElement {
+        public IssuedTokenClientElement();
+        public bool CacheIssuedTokens { get; set; }
+        public SecurityKeyEntropyMode DefaultKeyEntropyMode { get; set; }
+        public int IssuedTokenRenewalThresholdPercentage { get; set; }
+        public IssuedTokenClientBehaviorsElementCollection IssuerChannelBehaviors { get; }
+        public IssuedTokenParametersEndpointAddressElement LocalIssuer { get; }
+        public string LocalIssuerChannelBehaviors { get; set; }
+        public TimeSpan MaxIssuedTokenCachingTime { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public void Copy(IssuedTokenClientElement from);
+    }
+    public sealed class IssuedTokenParametersElement : ServiceModelConfigurationElement {
+        public IssuedTokenParametersElement();
+        public XmlElementElementCollection AdditionalRequestParameters { get; }
+        public ClaimTypeElementCollection ClaimTypeRequirements { get; }
+        public MessageSecurityVersion DefaultMessageSecurityVersion { get; set; }
+        public IssuedTokenParametersEndpointAddressElement Issuer { get; }
+        public EndpointAddressElementBase IssuerMetadata { get; }
+        public int KeySize { get; set; }
+        public SecurityKeyType KeyType { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string TokenType { get; set; }
+        public bool UseStrTransform { get; set; }
+        protected override bool SerializeToXmlElement(XmlWriter writer, string elementName);
+        protected override void Unmerge(ConfigurationElement sourceElement, ConfigurationElement parentElement, ConfigurationSaveMode saveMode);
+    }
+    public sealed class IssuedTokenParametersEndpointAddressElement : EndpointAddressElementBase, IConfigurationContextProviderInternal {
+        public IssuedTokenParametersEndpointAddressElement();
+        public string Binding { get; set; }
+        public string BindingConfiguration { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class IssuedTokenServiceElement : ConfigurationElement {
+        public IssuedTokenServiceElement();
+        public AllowedAudienceUriElementCollection AllowedAudienceUris { get; }
+        public bool AllowUntrustedRsaIssuers { get; set; }
+        public AudienceUriMode AudienceUriMode { get; set; }
+        public X509CertificateValidationMode CertificateValidationMode { get; set; }
+        public string CustomCertificateValidatorType { get; set; }
+        public X509CertificateTrustedIssuerElementCollection KnownCertificates { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public X509RevocationMode RevocationMode { get; set; }
+        public string SamlSerializerType { get; set; }
+        public StoreLocation TrustedStoreLocation { get; set; }
+        public void Copy(IssuedTokenServiceElement from);
+    }
+    public sealed class LocalClientSecuritySettingsElement : ServiceModelConfigurationElement {
+        public LocalClientSecuritySettingsElement();
+        public bool CacheCookies { get; set; }
+        public int CookieRenewalThresholdPercentage { get; set; }
+        public bool DetectReplays { get; set; }
+        public TimeSpan MaxClockSkew { get; set; }
+        public TimeSpan MaxCookieCachingTime { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public bool ReconnectTransportOnFailure { get; set; }
+        public int ReplayCacheSize { get; set; }
+        public TimeSpan ReplayWindow { get; set; }
+        public TimeSpan SessionKeyRenewalInterval { get; set; }
+        public TimeSpan SessionKeyRolloverInterval { get; set; }
+        public TimeSpan TimestampValidityDuration { get; set; }
+    }
+    public sealed class LocalServiceSecuritySettingsElement : ServiceModelConfigurationElement {
+        public LocalServiceSecuritySettingsElement();
+        public bool DetectReplays { get; set; }
+        public TimeSpan InactivityTimeout { get; set; }
+        public TimeSpan IssuedCookieLifetime { get; set; }
+        public int MaxCachedCookies { get; set; }
+        public TimeSpan MaxClockSkew { get; set; }
+        public int MaxPendingSessions { get; set; }
+        public int MaxStatefulNegotiations { get; set; }
+        public TimeSpan NegotiationTimeout { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public bool ReconnectTransportOnFailure { get; set; }
+        public int ReplayCacheSize { get; set; }
+        public TimeSpan ReplayWindow { get; set; }
+        public TimeSpan SessionKeyRenewalInterval { get; set; }
+        public TimeSpan SessionKeyRolloverInterval { get; set; }
+        public TimeSpan TimestampValidityDuration { get; set; }
+    }
+    public sealed class MessageLoggingElement : ConfigurationElement {
+        public MessageLoggingElement();
+        public XPathMessageFilterElementCollection Filters { get; }
+        public bool LogEntireMessage { get; set; }
+        public bool LogKnownPii { get; set; }
+        public bool LogMalformedMessages { get; set; }
+        public bool LogMessagesAtServiceLevel { get; set; }
+        public bool LogMessagesAtTransportLevel { get; set; }
+        public int MaxMessagesToLog { get; set; }
+        public int MaxSizeOfMessageToLog { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public class MessageSecurityOverHttpElement : ServiceModelConfigurationElement {
+        public SecurityAlgorithmSuite AlgorithmSuite { get; set; }
+        public MessageCredentialType ClientCredentialType { get; set; }
+        public bool NegotiateServiceCredential { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class MessageSecurityOverMsmqElement : ServiceModelConfigurationElement {
+        public MessageSecurityOverMsmqElement();
+        public SecurityAlgorithmSuite AlgorithmSuite { get; set; }
+        public MessageCredentialType ClientCredentialType { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class MessageSecurityOverTcpElement : ServiceModelConfigurationElement {
+        public MessageSecurityOverTcpElement();
+        public SecurityAlgorithmSuite AlgorithmSuite { get; set; }
+        public MessageCredentialType ClientCredentialType { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class MetadataElement : ConfigurationElement {
+        public MetadataElement();
+        public PolicyImporterElementCollection PolicyImporters { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public WsdlImporterElementCollection WsdlImporters { get; }
+        public Collection<IPolicyImportExtension> LoadPolicyImportExtensions();
+        public Collection<IWsdlImportExtension> LoadWsdlImportExtensions();
+    }
+    public abstract class MexBindingBindingCollectionElement<TStandardBinding, TBindingConfiguration> : StandardBindingCollectionElement<TStandardBinding, TBindingConfiguration> where TStandardBinding : Binding where TBindingConfiguration : StandardBindingElement, new() {
+        protected MexBindingBindingCollectionElement();
+        protected internal override bool TryAdd(string name, Binding binding, Configuration config);
+    }
+    public abstract class MexBindingElement<TStandardBinding> : StandardBindingElement where TStandardBinding : Binding {
+        protected MexBindingElement(string name);
+        protected override Type BindingElementType { get; }
+        protected override void OnApplyConfiguration(Binding binding);
+    }
+    public class MexHttpBindingCollectionElement : MexBindingBindingCollectionElement<WSHttpBinding, MexHttpBindingElement> {
+        public MexHttpBindingCollectionElement();
+        protected internal override Binding GetDefault();
+    }
+    public class MexHttpBindingElement : MexBindingElement<WSHttpBinding> {
+        public MexHttpBindingElement();
+        public MexHttpBindingElement(string name);
+    }
+    public class MexHttpsBindingCollectionElement : MexBindingBindingCollectionElement<WSHttpBinding, MexHttpsBindingElement> {
+        public MexHttpsBindingCollectionElement();
+        protected internal override Binding GetDefault();
+    }
+    public class MexHttpsBindingElement : MexBindingElement<WSHttpBinding> {
+        public MexHttpsBindingElement();
+        public MexHttpsBindingElement(string name);
+    }
+    public class MexNamedPipeBindingCollectionElement : MexBindingBindingCollectionElement<CustomBinding, MexNamedPipeBindingElement> {
+        public MexNamedPipeBindingCollectionElement();
+        protected internal override Binding GetDefault();
+    }
+    public class MexNamedPipeBindingElement : MexBindingElement<CustomBinding> {
+        public MexNamedPipeBindingElement();
+        public MexNamedPipeBindingElement(string name);
+    }
+    public class MexTcpBindingCollectionElement : MexBindingBindingCollectionElement<CustomBinding, MexTcpBindingElement> {
+        public MexTcpBindingCollectionElement();
+        protected internal override Binding GetDefault();
+    }
+    public class MexTcpBindingElement : MexBindingElement<CustomBinding> {
+        public MexTcpBindingElement();
+        public MexTcpBindingElement(string name);
+    }
+    public abstract class MsmqBindingElementBase : StandardBindingElement {
+        protected MsmqBindingElementBase();
+        protected MsmqBindingElementBase(string name);
+        public Uri CustomDeadLetterQueue { get; set; }
+        public DeadLetterQueue DeadLetterQueue { get; set; }
+        public bool Durable { get; set; }
+        public bool ExactlyOnce { get; set; }
+        public long MaxReceivedMessageSize { get; set; }
+        public int MaxRetryCycles { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public bool ReceiveContextEnabled { get; set; }
+        public ReceiveErrorHandling ReceiveErrorHandling { get; set; }
+        public int ReceiveRetryCount { get; set; }
+        public TimeSpan RetryCycleDelay { get; set; }
+        public TimeSpan TimeToLive { get; set; }
+        public bool UseMsmqTracing { get; set; }
+        public bool UseSourceJournal { get; set; }
+        public TimeSpan ValidityDuration { get; set; }
+        protected internal override void InitializeFrom(Binding binding);
+        protected override void OnApplyConfiguration(Binding binding);
+    }
+    public abstract class MsmqElementBase : TransportElement {
+        protected MsmqElementBase();
+        public Uri CustomDeadLetterQueue { get; set; }
+        public DeadLetterQueue DeadLetterQueue { get; set; }
+        public bool Durable { get; set; }
+        public bool ExactlyOnce { get; set; }
+        public int MaxRetryCycles { get; set; }
+        public MsmqTransportSecurityElement MsmqTransportSecurity { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public bool ReceiveContextEnabled { get; set; }
+        public ReceiveErrorHandling ReceiveErrorHandling { get; set; }
+        public int ReceiveRetryCount { get; set; }
+        public TimeSpan RetryCycleDelay { get; set; }
+        public TimeSpan TimeToLive { get; set; }
+        public bool UseMsmqTracing { get; set; }
+        public bool UseSourceJournal { get; set; }
+        public TimeSpan ValidityDuration { get; set; }
+        public override void ApplyConfiguration(BindingElement bindingElement);
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected internal override void InitializeFrom(BindingElement bindingElement);
+    }
+    public class MsmqIntegrationBindingCollectionElement : StandardBindingCollectionElement<MsmqIntegrationBinding, MsmqIntegrationBindingElement> {
+        public MsmqIntegrationBindingCollectionElement();
+    }
+    public class MsmqIntegrationBindingElement : MsmqBindingElementBase {
+        public MsmqIntegrationBindingElement();
+        public MsmqIntegrationBindingElement(string name);
+        protected override Type BindingElementType { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public MsmqIntegrationSecurityElement Security { get; }
+        public MsmqMessageSerializationFormat SerializationFormat { get; set; }
+        protected internal override void InitializeFrom(Binding binding);
+        protected override void OnApplyConfiguration(Binding binding);
+    }
+    public sealed class MsmqIntegrationElement : MsmqElementBase {
+        public MsmqIntegrationElement();
+        public override Type BindingElementType { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public MsmqMessageSerializationFormat SerializationFormat { get; set; }
+        public override void ApplyConfiguration(BindingElement bindingElement);
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected override TransportBindingElement CreateDefaultBindingElement();
+        protected internal override void InitializeFrom(BindingElement bindingElement);
+    }
+    public sealed class MsmqIntegrationSecurityElement : ServiceModelConfigurationElement {
+        public MsmqIntegrationSecurityElement();
+        public MsmqIntegrationSecurityMode Mode { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public MsmqTransportSecurityElement Transport { get; }
+    }
+    public sealed class MsmqTransportElement : MsmqElementBase {
+        public MsmqTransportElement();
+        public override Type BindingElementType { get; }
+        public int MaxPoolSize { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public QueueTransferProtocol QueueTransferProtocol { get; set; }
+        public bool UseActiveDirectory { get; set; }
+        public override void ApplyConfiguration(BindingElement bindingElement);
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected override TransportBindingElement CreateDefaultBindingElement();
+        protected internal override void InitializeFrom(BindingElement bindingElement);
+    }
+    public sealed class MsmqTransportSecurityElement : ServiceModelConfigurationElement {
+        public MsmqTransportSecurityElement();
+        public MsmqAuthenticationMode MsmqAuthenticationMode { get; set; }
+        public MsmqEncryptionAlgorithm MsmqEncryptionAlgorithm { get; set; }
+        public ProtectionLevel MsmqProtectionLevel { get; set; }
+        public MsmqSecureHashAlgorithm MsmqSecureHashAlgorithm { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class MtomMessageEncodingElement : BindingElementExtensionElement {
+        public MtomMessageEncodingElement();
+        public override Type BindingElementType { get; }
+        public int MaxBufferSize { get; set; }
+        public int MaxReadPoolSize { get; set; }
+        public int MaxWritePoolSize { get; set; }
+        public MessageVersion MessageVersion { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public XmlDictionaryReaderQuotasElement ReaderQuotas { get; }
+        public Encoding WriteEncoding { get; set; }
+        public override void ApplyConfiguration(BindingElement bindingElement);
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected internal override BindingElement CreateBindingElement();
+        protected internal override void InitializeFrom(BindingElement bindingElement);
+    }
+    public sealed class NamedPipeConnectionPoolSettingsElement : ServiceModelConfigurationElement {
+        public NamedPipeConnectionPoolSettingsElement();
+        public string GroupName { get; set; }
+        public TimeSpan IdleTimeout { get; set; }
+        public int MaxOutboundConnectionsPerEndpoint { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class NamedPipeSettingsElement : ServiceModelConfigurationElement {
+        public NamedPipeSettingsElement();
+        public ApplicationContainerSettingsElement ApplicationContainerSettings { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class NamedPipeTransportElement : ConnectionOrientedTransportElement {
+        public NamedPipeTransportElement();
+        public override Type BindingElementType { get; }
+        public NamedPipeConnectionPoolSettingsElement ConnectionPoolSettings { get; set; }
+        public NamedPipeSettingsElement PipeSettings { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public override void ApplyConfiguration(BindingElement bindingElement);
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected override TransportBindingElement CreateDefaultBindingElement();
+        protected internal override void InitializeFrom(BindingElement bindingElement);
+    }
+    public sealed class NamedPipeTransportSecurityElement : ServiceModelConfigurationElement {
+        public NamedPipeTransportSecurityElement();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public ProtectionLevel ProtectionLevel { get; set; }
+    }
+    public abstract class NamedServiceModelExtensionCollectionElement<TServiceModelExtensionElement> : ServiceModelExtensionCollectionElement<TServiceModelExtensionElement> where TServiceModelExtensionElement : ServiceModelExtensionElement {
+        public string Name { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public class NetHttpBindingCollectionElement : StandardBindingCollectionElement<NetHttpBinding, NetHttpBindingElement> {
+        public NetHttpBindingCollectionElement();
+    }
+    public sealed class NetHttpBindingElement : HttpBindingBaseElement {
+        public NetHttpBindingElement();
+        public NetHttpBindingElement(string name);
+        protected override Type BindingElementType { get; }
+        public NetHttpMessageEncoding MessageEncoding { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public StandardBindingOptionalReliableSessionElement ReliableSession { get; }
+        public BasicHttpSecurityElement Security { get; }
+        public NetHttpWebSocketTransportSettingsElement WebSocketSettings { get; set; }
+        protected internal override void InitializeFrom(Binding binding);
+        protected override void OnApplyConfiguration(Binding binding);
+    }
+    public class NetHttpsBindingCollectionElement : StandardBindingCollectionElement<NetHttpsBinding, NetHttpsBindingElement> {
+        public NetHttpsBindingCollectionElement();
+    }
+    public sealed class NetHttpsBindingElement : HttpBindingBaseElement {
+        public NetHttpsBindingElement();
+        public NetHttpsBindingElement(string name);
+        protected override Type BindingElementType { get; }
+        public NetHttpMessageEncoding MessageEncoding { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public StandardBindingOptionalReliableSessionElement ReliableSession { get; }
+        public BasicHttpsSecurityElement Security { get; }
+        public NetHttpWebSocketTransportSettingsElement WebSocketSettings { get; set; }
+        protected internal override void InitializeFrom(Binding binding);
+        protected override void OnApplyConfiguration(Binding binding);
+    }
+    public sealed class NetHttpWebSocketTransportSettingsElement : WebSocketTransportSettingsElement {
+        public NetHttpWebSocketTransportSettingsElement();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public override string SubProtocol { get; set; }
+        public override WebSocketTransportUsage TransportUsage { get; set; }
+    }
+    public class NetMsmqBindingCollectionElement : StandardBindingCollectionElement<NetMsmqBinding, NetMsmqBindingElement> {
+        public NetMsmqBindingCollectionElement();
+    }
+    public class NetMsmqBindingElement : MsmqBindingElementBase {
+        public NetMsmqBindingElement();
+        public NetMsmqBindingElement(string name);
+        protected override Type BindingElementType { get; }
+        public long MaxBufferPoolSize { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public QueueTransferProtocol QueueTransferProtocol { get; set; }
+        public XmlDictionaryReaderQuotasElement ReaderQuotas { get; }
+        public NetMsmqSecurityElement Security { get; }
+        public bool UseActiveDirectory { get; set; }
+        protected internal override void InitializeFrom(Binding binding);
+        protected override void OnApplyConfiguration(Binding binding);
+    }
+    public sealed class NetMsmqSecurityElement : ServiceModelConfigurationElement {
+        public NetMsmqSecurityElement();
+        public MessageSecurityOverMsmqElement Message { get; }
+        public NetMsmqSecurityMode Mode { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public MsmqTransportSecurityElement Transport { get; }
+    }
+    public class NetNamedPipeBindingCollectionElement : StandardBindingCollectionElement<NetNamedPipeBinding, NetNamedPipeBindingElement> {
+        public NetNamedPipeBindingCollectionElement();
+    }
+    public class NetNamedPipeBindingElement : StandardBindingElement {
+        public NetNamedPipeBindingElement();
+        public NetNamedPipeBindingElement(string name);
+        protected override Type BindingElementType { get; }
+        public HostNameComparisonMode HostNameComparisonMode { get; set; }
+        public long MaxBufferPoolSize { get; set; }
+        public int MaxBufferSize { get; set; }
+        public int MaxConnections { get; set; }
+        public long MaxReceivedMessageSize { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public XmlDictionaryReaderQuotasElement ReaderQuotas { get; }
+        public NetNamedPipeSecurityElement Security { get; }
+        public bool TransactionFlow { get; set; }
+        public TransactionProtocol TransactionProtocol { get; set; }
+        public TransferMode TransferMode { get; set; }
+        protected internal override void InitializeFrom(Binding binding);
+        protected override void OnApplyConfiguration(Binding binding);
+    }
+    public sealed class NetNamedPipeSecurityElement : ServiceModelConfigurationElement {
+        public NetNamedPipeSecurityElement();
+        public NetNamedPipeSecurityMode Mode { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public NamedPipeTransportSecurityElement Transport { get; }
+    }
+    public class NetPeerTcpBindingCollectionElement : StandardBindingCollectionElement<NetPeerTcpBinding, NetPeerTcpBindingElement> {
+        public NetPeerTcpBindingCollectionElement();
+    }
+    public class NetPeerTcpBindingElement : StandardBindingElement {
+        public NetPeerTcpBindingElement();
+        public NetPeerTcpBindingElement(string name);
+        protected override Type BindingElementType { get; }
+        public IPAddress ListenIPAddress { get; set; }
+        public long MaxBufferPoolSize { get; set; }
+        public long MaxReceivedMessageSize { get; set; }
+        public int Port { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public XmlDictionaryReaderQuotasElement ReaderQuotas { get; }
+        public PeerResolverElement Resolver { get; }
+        public PeerSecurityElement Security { get; }
+        protected internal override void InitializeFrom(Binding binding);
+        protected override void OnApplyConfiguration(Binding binding);
+    }
+    public class NetTcpBindingCollectionElement : StandardBindingCollectionElement<NetTcpBinding, NetTcpBindingElement> {
+        public NetTcpBindingCollectionElement();
+    }
+    public class NetTcpBindingElement : StandardBindingElement {
+        public NetTcpBindingElement();
+        public NetTcpBindingElement(string name);
+        protected override Type BindingElementType { get; }
+        public HostNameComparisonMode HostNameComparisonMode { get; set; }
+        public int ListenBacklog { get; set; }
+        public long MaxBufferPoolSize { get; set; }
+        public int MaxBufferSize { get; set; }
+        public int MaxConnections { get; set; }
+        public long MaxReceivedMessageSize { get; set; }
+        public bool PortSharingEnabled { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public XmlDictionaryReaderQuotasElement ReaderQuotas { get; }
+        public StandardBindingOptionalReliableSessionElement ReliableSession { get; }
+        public NetTcpSecurityElement Security { get; }
+        public bool TransactionFlow { get; set; }
+        public TransactionProtocol TransactionProtocol { get; set; }
+        public TransferMode TransferMode { get; set; }
+        protected internal override void InitializeFrom(Binding binding);
+        protected override void OnApplyConfiguration(Binding binding);
+    }
+    public class NetTcpContextBindingCollectionElement : StandardBindingCollectionElement<NetTcpContextBinding, NetTcpContextBindingElement> {
+        public NetTcpContextBindingCollectionElement();
+    }
+    public class NetTcpContextBindingElement : NetTcpBindingElement {
+        public NetTcpContextBindingElement();
+        public NetTcpContextBindingElement(string name);
+        protected override Type BindingElementType { get; }
+        public Uri ClientCallbackAddress { get; set; }
+        public bool ContextManagementEnabled { get; set; }
+        public ProtectionLevel ContextProtectionLevel { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected internal override void InitializeFrom(Binding binding);
+        protected override void OnApplyConfiguration(Binding binding);
+    }
+    public sealed class NetTcpSecurityElement : ServiceModelConfigurationElement {
+        public NetTcpSecurityElement();
+        public MessageSecurityOverTcpElement Message { get; }
+        public SecurityMode Mode { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public TcpTransportSecurityElement Transport { get; }
+    }
+    public sealed class NonDualMessageSecurityOverHttpElement : MessageSecurityOverHttpElement {
+        public NonDualMessageSecurityOverHttpElement();
+        public bool EstablishSecurityContext { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class OneWayElement : BindingElementExtensionElement {
+        public OneWayElement();
+        public override Type BindingElementType { get; }
+        public ChannelPoolSettingsElement ChannelPoolSettings { get; }
+        public int MaxAcceptedChannels { get; set; }
+        public bool PacketRoutable { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public override void ApplyConfiguration(BindingElement bindingElement);
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected internal override BindingElement CreateBindingElement();
+        protected internal override void InitializeFrom(BindingElement bindingElement);
+    }
+    public sealed class PeerCredentialElement : ConfigurationElement {
+        public PeerCredentialElement();
+        public X509PeerCertificateElement Certificate { get; }
+        public X509PeerCertificateAuthenticationElement MessageSenderAuthentication { get; }
+        public X509PeerCertificateAuthenticationElement PeerAuthentication { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public void Copy(PeerCredentialElement from);
+    }
+    public sealed class PeerCustomResolverElement : ServiceModelConfigurationElement {
+        public PeerCustomResolverElement();
+        public Uri Address { get; set; }
+        public string Binding { get; set; }
+        public string BindingConfiguration { get; set; }
+        public AddressHeaderCollectionElement Headers { get; }
+        public IdentityElement Identity { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string ResolverType { get; set; }
+    }
+    public sealed class PeerResolverElement : ServiceModelConfigurationElement {
+        public PeerResolverElement();
+        public PeerCustomResolverElement Custom { get; }
+        public PeerResolverMode Mode { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public PeerReferralPolicy ReferralPolicy { get; set; }
+    }
+    public sealed class PeerSecurityElement : ServiceModelConfigurationElement {
+        public PeerSecurityElement();
+        public SecurityMode Mode { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public PeerTransportSecurityElement Transport { get; }
+    }
+    public class PeerTransportElement : BindingElementExtensionElement {
+        public PeerTransportElement();
+        public override Type BindingElementType { get; }
+        public IPAddress ListenIPAddress { get; set; }
+        public long MaxBufferPoolSize { get; set; }
+        public long MaxReceivedMessageSize { get; set; }
+        public int Port { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public PeerSecurityElement Security { get; }
+        public override void ApplyConfiguration(BindingElement bindingElement);
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected internal override BindingElement CreateBindingElement();
+        protected internal override void InitializeFrom(BindingElement bindingElement);
+    }
+    public sealed class PeerTransportSecurityElement : ServiceModelConfigurationElement {
+        public PeerTransportSecurityElement();
+        public PeerTransportCredentialType CredentialType { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public class PersistenceProviderElement : BehaviorExtensionElement {
+        public PersistenceProviderElement();
+        public override Type BehaviorType { get; }
+        public TimeSpan PersistenceOperationTimeout { get; set; }
+        public NameValueCollection PersistenceProviderArguments { get; }
+        public string Type { get; set; }
+        protected internal override object CreateBehavior();
+        protected override bool IsModified();
+        protected override bool OnDeserializeUnrecognizedAttribute(string name, string value);
+        protected override void PostDeserialize();
+        protected override bool SerializeElement(XmlWriter writer, bool serializeCollectionKey);
+        protected override void Unmerge(ConfigurationElement sourceElement, ConfigurationElement parentElement, ConfigurationSaveMode saveMode);
+    }
+    public class PnrpPeerResolverElement : BindingElementExtensionElement {
+        public PnrpPeerResolverElement();
+        public override Type BindingElementType { get; }
+        protected internal override BindingElement CreateBindingElement();
+    }
+    public sealed class PolicyImporterElement : ConfigurationElement {
+        public PolicyImporterElement();
+        public PolicyImporterElement(string type);
+        public PolicyImporterElement(Type type);
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string Type { get; set; }
+    }
+    public sealed class PolicyImporterElementCollection : ServiceModelEnhancedConfigurationElementCollection<PolicyImporterElement> {
+        public PolicyImporterElementCollection();
+        protected override object GetElementKey(ConfigurationElement element);
+    }
+    public class PrivacyNoticeElement : BindingElementExtensionElement {
+        public PrivacyNoticeElement();
+        public override Type BindingElementType { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public Uri Url { get; set; }
+        public int Version { get; set; }
+        public override void ApplyConfiguration(BindingElement bindingElement);
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected internal override BindingElement CreateBindingElement();
+        protected internal override void InitializeFrom(BindingElement bindingElement);
+    }
+    public sealed class ProtocolMappingElement : ConfigurationElement {
+        public ProtocolMappingElement();
+        public ProtocolMappingElement(string schemeType, string binding, string bindingConfiguration);
+        public string Binding { get; set; }
+        public string BindingConfiguration { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string Scheme { get; set; }
+    }
+    public sealed class ProtocolMappingElementCollection : ServiceModelEnhancedConfigurationElementCollection<ProtocolMappingElement> {
+        public ProtocolMappingElementCollection();
+        protected override object GetElementKey(ConfigurationElement element);
+    }
+    public sealed class ProtocolMappingSection : ConfigurationSection {
+        public ProtocolMappingSection();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public ProtocolMappingElementCollection ProtocolMappingCollection { get; }
+        protected override void InitializeDefault();
+    }
+    public sealed class ReliableSessionElement : BindingElementExtensionElement {
+        public ReliableSessionElement();
+        public TimeSpan AcknowledgementInterval { get; set; }
+        public override Type BindingElementType { get; }
+        public bool FlowControlEnabled { get; set; }
+        public TimeSpan InactivityTimeout { get; set; }
+        public int MaxPendingChannels { get; set; }
+        public int MaxRetryCount { get; set; }
+        public int MaxTransferWindowSize { get; set; }
+        public bool Ordered { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public ReliableMessagingVersion ReliableMessagingVersion { get; set; }
+        public override void ApplyConfiguration(BindingElement bindingElement);
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected internal override BindingElement CreateBindingElement();
+        protected internal override void InitializeFrom(BindingElement bindingElement);
+    }
+    public sealed class RemoveBehaviorElement : BehaviorExtensionElement {
+        public RemoveBehaviorElement();
+        public override Type BehaviorType { get; }
+        public string Name { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected internal override object CreateBehavior();
+    }
+    public sealed class RsaElement : ConfigurationElement {
+        public RsaElement();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string Value { get; set; }
+    }
+    public sealed class SecureConversationServiceElement : ConfigurationElement {
+        public SecureConversationServiceElement();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string SecurityStateEncoderType { get; set; }
+        public void Copy(SecureConversationServiceElement from);
+    }
+    public sealed class SecurityElement : SecurityElementBase {
+        public SecurityElement();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public SecurityElementBase SecureConversationBootstrap { get; }
+        protected override void AddBindingTemplates(Dictionary<AuthenticationMode, SecurityBindingElement> bindingTemplates);
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected internal override BindingElement CreateBindingElement(bool createTemplateOnly);
+        protected override void InitializeNestedTokenParameterSettings(SecurityTokenParameters sp, bool initializeNestedBindings);
+    }
+    public class SecurityElementBase : BindingElementExtensionElement {
+        public bool AllowInsecureTransport { get; set; }
+        public bool AllowSerializedSigningTokenOnReply { get; set; }
+        public AuthenticationMode AuthenticationMode { get; set; }
+        public override Type BindingElementType { get; }
+        public bool CanRenewSecurityContextToken { get; set; }
+        public SecurityAlgorithmSuite DefaultAlgorithmSuite { get; set; }
+        public bool EnableUnsecuredResponse { get; set; }
+        public bool IncludeTimestamp { get; set; }
+        public IssuedTokenParametersElement IssuedTokenParameters { get; }
+        public SecurityKeyEntropyMode KeyEntropyMode { get; set; }
+        public LocalClientSecuritySettingsElement LocalClientSettings { get; }
+        public LocalServiceSecuritySettingsElement LocalServiceSettings { get; }
+        public MessageProtectionOrder MessageProtectionOrder { get; set; }
+        public MessageSecurityVersion MessageSecurityVersion { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public bool ProtectTokens { get; set; }
+        public bool RequireDerivedKeys { get; set; }
+        public bool RequireSecurityContextCancellation { get; set; }
+        public bool RequireSignatureConfirmation { get; set; }
+        public SecurityHeaderLayout SecurityHeaderLayout { get; set; }
+        protected void AddBindingTemplate(Dictionary<AuthenticationMode, SecurityBindingElement> bindingTemplates, AuthenticationMode mode);
+        protected virtual void AddBindingTemplates(Dictionary<AuthenticationMode, SecurityBindingElement> bindingTemplates);
+        public override void ApplyConfiguration(BindingElement bindingElement);
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected internal override BindingElement CreateBindingElement();
+        protected internal virtual BindingElement CreateBindingElement(bool createTemplateOnly);
+        protected internal override void InitializeFrom(BindingElement bindingElement);
+        protected virtual void InitializeNestedTokenParameterSettings(SecurityTokenParameters sp, bool initializeNestedBindings);
+        protected override bool SerializeElement(XmlWriter writer, bool serializeCollectionKey);
+        protected override bool SerializeToXmlElement(XmlWriter writer, string elementName);
+        protected override void Unmerge(ConfigurationElement sourceElement, ConfigurationElement parentElement, ConfigurationSaveMode saveMode);
+    }
+    public sealed class ServiceActivationElement : ConfigurationElement {
+        public ServiceActivationElement();
+        public ServiceActivationElement(string relativeAddress);
+        public ServiceActivationElement(string relativeAddress, string service);
+        public ServiceActivationElement(string relativeAddress, string service, string factory);
+        public string Factory { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string RelativeAddress { get; set; }
+        public string Service { get; set; }
+    }
+    public sealed class ServiceActivationElementCollection : ServiceModelConfigurationElementCollection<ServiceActivationElement> {
+        public ServiceActivationElementCollection();
+        protected override bool ThrowOnDuplicate { get; }
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+    }
+    public sealed class ServiceAuthenticationElement : BehaviorExtensionElement {
+        public ServiceAuthenticationElement();
+        public AuthenticationSchemes AuthenticationSchemes { get; set; }
+        public override Type BehaviorType { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string ServiceAuthenticationManagerType { get; set; }
+        protected internal override object CreateBehavior();
+    }
+    public sealed class ServiceAuthorizationElement : BehaviorExtensionElement {
+        public ServiceAuthorizationElement();
+        public AuthorizationPolicyTypeElementCollection AuthorizationPolicies { get; }
+        public override Type BehaviorType { get; }
+        public bool ImpersonateCallerForAllOperations { get; set; }
+        public bool ImpersonateOnSerializingReply { get; set; }
+        public PrincipalPermissionMode PrincipalPermissionMode { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string RoleProviderName { get; set; }
+        public string ServiceAuthorizationManagerType { get; set; }
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected internal override object CreateBehavior();
+    }
+    public class ServiceBehaviorElement : NamedServiceModelExtensionCollectionElement<BehaviorExtensionElement> {
+        public ServiceBehaviorElement();
+        public ServiceBehaviorElement(string name);
+        public override void Add(BehaviorExtensionElement element);
+        public override bool CanAdd(BehaviorExtensionElement element);
+        protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey);
+    }
+    public sealed class ServiceBehaviorElementCollection : ServiceModelEnhancedConfigurationElementCollection<ServiceBehaviorElement> {
+        public ServiceBehaviorElementCollection();
+        protected override bool ThrowOnDuplicate { get; }
+        protected override void BaseAdd(ConfigurationElement element);
+        protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey);
+        protected override object GetElementKey(ConfigurationElement element);
+    }
+    public class ServiceCredentialsElement : BehaviorExtensionElement {
+        public ServiceCredentialsElement();
+        public override Type BehaviorType { get; }
+        public X509InitiatorCertificateServiceElement ClientCertificate { get; }
+        public string IdentityConfiguration { get; set; }
+        public IssuedTokenServiceElement IssuedTokenAuthentication { get; }
+        public PeerCredentialElement Peer { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public SecureConversationServiceElement SecureConversationAuthentication { get; }
+        public X509RecipientCertificateServiceElement ServiceCertificate { get; }
+        public string Type { get; set; }
+        public bool UseIdentityConfiguration { get; set; }
+        public UserNameServiceElement UserNameAuthentication { get; }
+        public WindowsServiceElement WindowsAuthentication { get; }
+        protected internal void ApplyConfiguration(ServiceCredentials behavior);
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected internal override object CreateBehavior();
+    }
+    public sealed class ServiceDebugElement : BehaviorExtensionElement {
+        public ServiceDebugElement();
+        public override Type BehaviorType { get; }
+        public string HttpHelpPageBinding { get; set; }
+        public string HttpHelpPageBindingConfiguration { get; set; }
+        public bool HttpHelpPageEnabled { get; set; }
+        public Uri HttpHelpPageUrl { get; set; }
+        public string HttpsHelpPageBinding { get; set; }
+        public string HttpsHelpPageBindingConfiguration { get; set; }
+        public bool HttpsHelpPageEnabled { get; set; }
+        public Uri HttpsHelpPageUrl { get; set; }
+        public bool IncludeExceptionDetailInFaults { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected internal override object CreateBehavior();
+    }
+    public sealed class ServiceElement : ConfigurationElement, IConfigurationContextProviderInternal {
+        public ServiceElement();
+        public ServiceElement(string serviceName);
+        public string BehaviorConfiguration { get; set; }
+        public ServiceEndpointElementCollection Endpoints { get; }
+        public HostElement Host { get; }
+        public string Name { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected override void Reset(ConfigurationElement parentElement);
+    }
+    public sealed class ServiceElementCollection : ServiceModelEnhancedConfigurationElementCollection<ServiceElement> {
+        public ServiceElementCollection();
+        protected override object GetElementKey(ConfigurationElement element);
+    }
+    public sealed class ServiceEndpointElement : ConfigurationElement, IConfigurationContextProviderInternal {
+        public ServiceEndpointElement();
+        public ServiceEndpointElement(Uri address, string contractType);
+        public Uri Address { get; set; }
+        public string BehaviorConfiguration { get; set; }
+        public string Binding { get; set; }
+        public string BindingConfiguration { get; set; }
+        public string BindingName { get; set; }
+        public string BindingNamespace { get; set; }
+        public string Contract { get; set; }
+        public string EndpointConfiguration { get; set; }
+        public AddressHeaderCollectionElement Headers { get; }
+        public IdentityElement Identity { get; }
+        public bool IsSystemEndpoint { get; set; }
+        public string Kind { get; set; }
+        public Uri ListenUri { get; set; }
+        public ListenUriMode ListenUriMode { get; set; }
+        public string Name { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class ServiceEndpointElementCollection : ServiceModelEnhancedConfigurationElementCollection<ServiceEndpointElement> {
+        public ServiceEndpointElementCollection();
+        protected override bool ThrowOnDuplicate { get; }
+        protected override object GetElementKey(ConfigurationElement element);
+    }
+    public sealed class ServiceHostingEnvironmentSection : ConfigurationSection {
+        public ServiceHostingEnvironmentSection();
+        public bool AspNetCompatibilityEnabled { get; set; }
+        public BaseAddressPrefixFilterElementCollection BaseAddressPrefixFilters { get; }
+        public bool CloseIdleServicesAtLowMemory { get; set; }
+        public int MinFreeMemoryPercentageToActivateService { get; set; }
+        public bool MultipleSiteBindingsEnabled { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public ServiceActivationElementCollection ServiceActivations { get; }
+        public TransportConfigurationTypeElementCollection TransportConfigurationTypes { get; }
+        protected override void PostDeserialize();
+    }
+    public class ServiceMetadataEndpointCollectionElement : StandardEndpointCollectionElement<ServiceMetadataEndpoint, ServiceMetadataEndpointElement> {
+        public ServiceMetadataEndpointCollectionElement();
+    }
+    public class ServiceMetadataEndpointElement : StandardEndpointElement {
+        public ServiceMetadataEndpointElement();
+        protected internal override Type EndpointType { get; }
+        protected internal override ServiceEndpoint CreateServiceEndpoint(ContractDescription contractDescription);
+        protected override void OnApplyConfiguration(ServiceEndpoint endpoint, ChannelEndpointElement serviceEndpointElement);
+        protected override void OnApplyConfiguration(ServiceEndpoint endpoint, ServiceEndpointElement serviceEndpointElement);
+        protected override void OnInitializeAndValidate(ChannelEndpointElement channelEndpointElement);
+        protected override void OnInitializeAndValidate(ServiceEndpointElement serviceEndpointElement);
+    }
+    public sealed class ServiceMetadataPublishingElement : BehaviorExtensionElement {
+        public ServiceMetadataPublishingElement();
+        public override Type BehaviorType { get; }
+        public Uri ExternalMetadataLocation { get; set; }
+        public string HttpGetBinding { get; set; }
+        public string HttpGetBindingConfiguration { get; set; }
+        public bool HttpGetEnabled { get; set; }
+        public Uri HttpGetUrl { get; set; }
+        public string HttpsGetBinding { get; set; }
+        public string HttpsGetBindingConfiguration { get; set; }
+        public bool HttpsGetEnabled { get; set; }
+        public Uri HttpsGetUrl { get; set; }
+        public PolicyVersion PolicyVersion { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected internal override object CreateBehavior();
+    }
+    public abstract class ServiceModelConfigurationElement : ConfigurationElement {
+        protected ServiceModelConfigurationElement();
+        protected void SetPropertyValueIfNotDefaultValue<T>(string propertyName, T value);
+    }
+    public abstract class ServiceModelConfigurationElementCollection<ConfigurationElementType> : ConfigurationElementCollection where ConfigurationElementType : ConfigurationElement, new() {
+        public override ConfigurationElementCollectionType CollectionType { get; }
+        protected override string ElementName { get; }
+        public ConfigurationElementType this[int index] { get; set; }
+        public virtual ConfigurationElementType this[object key] { get; set; }
+        public void Add(ConfigurationElementType element);
+        protected override void BaseAdd(ConfigurationElement element);
+        public void Clear();
+        public virtual bool ContainsKey(object key);
+        public void CopyTo(ConfigurationElementType[] array, int start);
+        protected override ConfigurationElement CreateNewElement();
+        public int IndexOf(ConfigurationElementType element);
+        public void Remove(ConfigurationElementType element);
+        public void RemoveAt(int index);
+        public void RemoveAt(object key);
+    }
+    public abstract class ServiceModelEnhancedConfigurationElementCollection<TConfigurationElement> : ServiceModelConfigurationElementCollection<TConfigurationElement> where TConfigurationElement : ConfigurationElement, new() {
+        protected override bool ThrowOnDuplicate { get; }
+        protected override void BaseAdd(ConfigurationElement element);
+    }
+    public abstract class ServiceModelExtensionCollectionElement<TServiceModelExtensionElement> : ConfigurationElement, ICollection<TServiceModelExtensionElement>, IConfigurationContextProviderInternal, IEnumerable, IEnumerable<TServiceModelExtensionElement> where TServiceModelExtensionElement : ServiceModelExtensionElement {
+        public int Count { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        bool System.Collections.Generic.ICollection<TServiceModelExtensionElement>.IsReadOnly { get; }
+        public TServiceModelExtensionElement this[int index] { get; }
+        public TServiceModelExtensionElement this[Type extensionType] { get; }
+        public virtual void Add(TServiceModelExtensionElement element);
+        public virtual bool CanAdd(TServiceModelExtensionElement element);
+        public void Clear();
+        public bool Contains(TServiceModelExtensionElement element);
+        public bool ContainsKey(string elementName);
+        public bool ContainsKey(Type elementType);
+        public void CopyTo(TServiceModelExtensionElement[] elements, int start);
+        protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey);
+        public IEnumerator<TServiceModelExtensionElement> GetEnumerator();
+        protected override bool IsModified();
+        protected override bool OnDeserializeUnrecognizedElement(string elementName, XmlReader reader);
+        public bool Remove(TServiceModelExtensionElement element);
+        protected override void Reset(ConfigurationElement parentElement);
+        protected override void ResetModified();
+        protected void SetIsModified();
+        protected override void SetReadOnly();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        protected override void Unmerge(ConfigurationElement sourceElement, ConfigurationElement parentElement, ConfigurationSaveMode saveMode);
+    }
+    public abstract class ServiceModelExtensionElement : ServiceModelConfigurationElement, IConfigurationContextProviderInternal {
+        protected ServiceModelExtensionElement();
+        public string ConfigurationElementName { get; internal set; }
+        public virtual void CopyFrom(ServiceModelExtensionElement from);
+        protected override bool IsModified();
+        protected override void Reset(ConfigurationElement parentElement);
+        protected override bool SerializeElement(XmlWriter writer, bool serializeCollectionKey);
+    }
+    public sealed class ServiceModelSectionGroup : ConfigurationSectionGroup {
+        public ServiceModelSectionGroup();
+        public BehaviorsSection Behaviors { get; }
+        public BindingsSection Bindings { get; }
+        public ClientSection Client { get; }
+        public ComContractsSection ComContracts { get; }
+        public CommonBehaviorsSection CommonBehaviors { get; }
+        public DiagnosticSection Diagnostic { get; }
+        public ExtensionsSection Extensions { get; }
+        public ProtocolMappingSection ProtocolMapping { get; }
+        public ServiceHostingEnvironmentSection ServiceHostingEnvironment { get; }
+        public ServicesSection Services { get; }
+        public StandardEndpointsSection StandardEndpoints { get; }
+        public static ServiceModelSectionGroup GetSectionGroup(Configuration config);
+    }
+    public sealed class ServicePrincipalNameElement : ConfigurationElement {
+        public ServicePrincipalNameElement();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string Value { get; set; }
+    }
+    public sealed class ServiceSecurityAuditElement : BehaviorExtensionElement {
+        public ServiceSecurityAuditElement();
+        public AuditLogLocation AuditLogLocation { get; set; }
+        public override Type BehaviorType { get; }
+        public AuditLevel MessageAuthenticationAuditLevel { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public AuditLevel ServiceAuthorizationAuditLevel { get; set; }
+        public bool SuppressAuditFailure { get; set; }
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected internal override object CreateBehavior();
+    }
+    public sealed class ServicesSection : ConfigurationSection, IConfigurationContextProviderInternal {
+        public ServicesSection();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public ServiceElementCollection Services { get; }
+        protected override void PostDeserialize();
+        protected override void Reset(ConfigurationElement parentElement);
+    }
+    public sealed class ServiceThrottlingElement : BehaviorExtensionElement {
+        public ServiceThrottlingElement();
+        public override Type BehaviorType { get; }
+        public int MaxConcurrentCalls { get; set; }
+        public int MaxConcurrentInstances { get; set; }
+        public int MaxConcurrentSessions { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected internal override object CreateBehavior();
+    }
+    public sealed class ServiceTimeoutsElement : BehaviorExtensionElement {
+        public ServiceTimeoutsElement();
+        public override Type BehaviorType { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public TimeSpan TransactionTimeout { get; set; }
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected internal override object CreateBehavior();
+    }
+    public sealed class SslStreamSecurityElement : BindingElementExtensionElement {
+        public SslStreamSecurityElement();
+        public override Type BindingElementType { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public bool RequireClientCertificate { get; set; }
+        public SslProtocols SslProtocols { get; private set; }
+        public override void ApplyConfiguration(BindingElement bindingElement);
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected internal override BindingElement CreateBindingElement();
+        protected internal override void InitializeFrom(BindingElement bindingElement);
+    }
+    public class StandardBindingCollectionElement<TStandardBinding, TBindingConfiguration> : BindingCollectionElement where TStandardBinding : Binding where TBindingConfiguration : StandardBindingElement, new() {
+        public StandardBindingCollectionElement();
+        public StandardBindingElementCollection<TBindingConfiguration> Bindings { get; }
+        public override Type BindingType { get; }
+        public override ReadOnlyCollection<IBindingConfigurationElement> ConfiguredBindings { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public override bool ContainsKey(string name);
+        protected internal override Binding GetDefault();
+        protected internal override bool TryAdd(string name, Binding binding, Configuration config);
+    }
+    public abstract class StandardBindingElement : ServiceModelConfigurationElement, IBindingConfigurationElement, IConfigurationContextProviderInternal {
+        protected StandardBindingElement();
+        protected StandardBindingElement(string name);
+        protected abstract Type BindingElementType { get; }
+        public TimeSpan CloseTimeout { get; set; }
+        public string Name { get; set; }
+        public TimeSpan OpenTimeout { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public TimeSpan ReceiveTimeout { get; set; }
+        public TimeSpan SendTimeout { get; set; }
+        public void ApplyConfiguration(Binding binding);
+        protected internal virtual void InitializeFrom(Binding binding);
+        protected abstract void OnApplyConfiguration(Binding binding);
+        protected override void Reset(ConfigurationElement parentElement);
+    }
+    public sealed class StandardBindingElementCollection<TBindingConfiguration> : ServiceModelEnhancedConfigurationElementCollection<TBindingConfiguration> where TBindingConfiguration : StandardBindingElement, new() {
+        public StandardBindingElementCollection();
+        protected override object GetElementKey(ConfigurationElement element);
+    }
+    public sealed class StandardBindingOptionalReliableSessionElement : StandardBindingReliableSessionElement {
+        public StandardBindingOptionalReliableSessionElement();
+        public bool Enabled { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public void ApplyConfiguration(OptionalReliableSession optionalReliableSession);
+        public void InitializeFrom(OptionalReliableSession optionalReliableSession);
+    }
+    public class StandardBindingReliableSessionElement : ServiceModelConfigurationElement {
+        public StandardBindingReliableSessionElement();
+        public TimeSpan InactivityTimeout { get; set; }
+        public bool Ordered { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public void ApplyConfiguration(ReliableSession reliableSession);
+        public void InitializeFrom(ReliableSession reliableSession);
+    }
+    public class StandardEndpointCollectionElement<TStandardEndpoint, TEndpointConfiguration> : EndpointCollectionElement where TStandardEndpoint : ServiceEndpoint where TEndpointConfiguration : StandardEndpointElement, new() {
+        public StandardEndpointCollectionElement();
+        public override ReadOnlyCollection<StandardEndpointElement> ConfiguredEndpoints { get; }
+        public StandardEndpointElementCollection<TEndpointConfiguration> Endpoints { get; }
+        public override Type EndpointType { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public override bool ContainsKey(string name);
+        protected internal override StandardEndpointElement GetDefaultStandardEndpointElement();
+        protected internal override bool TryAdd(string name, ServiceEndpoint endpoint, Configuration config);
+    }
+    public abstract class StandardEndpointElement : ConfigurationElement, IConfigurationContextProviderInternal {
+        protected StandardEndpointElement();
+        protected internal abstract Type EndpointType { get; }
+        public string Name { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public void ApplyConfiguration(ServiceEndpoint endpoint, ChannelEndpointElement channelEndpointElement);
+        public void ApplyConfiguration(ServiceEndpoint endpoint, ServiceEndpointElement serviceEndpointElement);
+        protected internal abstract ServiceEndpoint CreateServiceEndpoint(ContractDescription contractDescription);
+        public void InitializeAndValidate(ChannelEndpointElement channelEndpointElement);
+        public void InitializeAndValidate(ServiceEndpointElement serviceEndpointElement);
+        protected internal virtual void InitializeFrom(ServiceEndpoint endpoint);
+        protected abstract void OnApplyConfiguration(ServiceEndpoint endpoint, ChannelEndpointElement channelEndpointElement);
+        protected abstract void OnApplyConfiguration(ServiceEndpoint endpoint, ServiceEndpointElement serviceEndpointElement);
+        protected abstract void OnInitializeAndValidate(ChannelEndpointElement channelEndpointElement);
+        protected abstract void OnInitializeAndValidate(ServiceEndpointElement serviceEndpointElement);
+        protected override void Reset(ConfigurationElement parentElement);
+    }
+    public sealed class StandardEndpointElementCollection<TEndpointConfiguration> : ServiceModelEnhancedConfigurationElementCollection<TEndpointConfiguration> where TEndpointConfiguration : StandardEndpointElement, new() {
+        public StandardEndpointElementCollection();
+        protected override object GetElementKey(ConfigurationElement element);
+    }
+    public sealed class StandardEndpointsSection : ConfigurationSection, IConfigurationContextProviderInternal {
+        public StandardEndpointsSection();
+        public List<EndpointCollectionElement> EndpointCollections { get; }
+        public ServiceMetadataEndpointCollectionElement MexEndpoint { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public new EndpointCollectionElement this[string endpoint] { get; }
+        public static StandardEndpointsSection GetSection(Configuration config);
+        protected override bool OnDeserializeUnrecognizedElement(string elementName, XmlReader reader);
+    }
+    public sealed class SynchronousReceiveElement : BehaviorExtensionElement {
+        public SynchronousReceiveElement();
+        public override Type BehaviorType { get; }
+        protected internal override object CreateBehavior();
+    }
+    public sealed class TcpConnectionPoolSettingsElement : ServiceModelConfigurationElement {
+        public TcpConnectionPoolSettingsElement();
+        public string GroupName { get; set; }
+        public TimeSpan IdleTimeout { get; set; }
+        public TimeSpan LeaseTimeout { get; set; }
+        public int MaxOutboundConnectionsPerEndpoint { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class TcpTransportElement : ConnectionOrientedTransportElement {
+        public TcpTransportElement();
+        public override Type BindingElementType { get; }
+        public TcpConnectionPoolSettingsElement ConnectionPoolSettings { get; set; }
+        public ExtendedProtectionPolicyElement ExtendedProtectionPolicy { get; private set; }
+        public int ListenBacklog { get; set; }
+        public bool PortSharingEnabled { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public bool TeredoEnabled { get; set; }
+        public override void ApplyConfiguration(BindingElement bindingElement);
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected override TransportBindingElement CreateDefaultBindingElement();
+        protected internal override void InitializeFrom(BindingElement bindingElement);
+    }
+    public sealed class TcpTransportSecurityElement : ServiceModelConfigurationElement {
+        public TcpTransportSecurityElement();
+        public TcpClientCredentialType ClientCredentialType { get; set; }
+        public ExtendedProtectionPolicyElement ExtendedProtectionPolicy { get; private set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public ProtectionLevel ProtectionLevel { get; set; }
+        public SslProtocols SslProtocols { get; private set; }
+    }
+    public sealed class TextMessageEncodingElement : BindingElementExtensionElement {
+        public TextMessageEncodingElement();
+        public override Type BindingElementType { get; }
+        public int MaxReadPoolSize { get; set; }
+        public int MaxWritePoolSize { get; set; }
+        public MessageVersion MessageVersion { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public XmlDictionaryReaderQuotasElement ReaderQuotas { get; }
+        public Encoding WriteEncoding { get; set; }
+        public override void ApplyConfiguration(BindingElement bindingElement);
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected internal override BindingElement CreateBindingElement();
+        protected internal override void InitializeFrom(BindingElement bindingElement);
+    }
+    public sealed class TransactedBatchingElement : BehaviorExtensionElement {
+        public TransactedBatchingElement();
+        public override Type BehaviorType { get; }
+        public int MaxBatchSize { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected internal override object CreateBehavior();
+    }
+    public class TransactionFlowElement : BindingElementExtensionElement {
+        public TransactionFlowElement();
+        public bool AllowWildcardAction { get; set; }
+        public override Type BindingElementType { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public TransactionProtocol TransactionProtocol { get; set; }
+        public override void ApplyConfiguration(BindingElement bindingElement);
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected internal override BindingElement CreateBindingElement();
+        protected internal override void InitializeFrom(BindingElement bindingElement);
+    }
+    public sealed class TransportConfigurationTypeElement : ConfigurationElement {
+        public TransportConfigurationTypeElement();
+        public TransportConfigurationTypeElement(string name);
+        public TransportConfigurationTypeElement(string name, string transportConfigurationTypeName);
+        public string Name { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string TransportConfigurationType { get; set; }
+    }
+    public sealed class TransportConfigurationTypeElementCollection : ServiceModelConfigurationElementCollection<TransportConfigurationTypeElement> {
+        public TransportConfigurationTypeElementCollection();
+        protected override object GetElementKey(ConfigurationElement element);
+    }
+    public abstract class TransportElement : BindingElementExtensionElement {
+        protected TransportElement();
+        public bool ManualAddressing { get; set; }
+        public long MaxBufferPoolSize { get; set; }
+        public long MaxReceivedMessageSize { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public override void ApplyConfiguration(BindingElement bindingElement);
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected internal override BindingElement CreateBindingElement();
+        protected abstract TransportBindingElement CreateDefaultBindingElement();
+        protected internal override void InitializeFrom(BindingElement bindingElement);
+    }
+    public class UdpBindingCollectionElement : StandardBindingCollectionElement<UdpBinding, UdpBindingElement> {
+        public UdpBindingCollectionElement();
+    }
+    public class UdpBindingElement : StandardBindingElement {
+        public UdpBindingElement();
+        public UdpBindingElement(string name);
+        protected override Type BindingElementType { get; }
+        public int DuplicateMessageHistoryLength { get; set; }
+        public long MaxBufferPoolSize { get; set; }
+        public long MaxPendingMessagesTotalSize { get; set; }
+        public long MaxReceivedMessageSize { get; set; }
+        public int MaxRetransmitCount { get; set; }
+        public string MulticastInterfaceId { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public XmlDictionaryReaderQuotasElement ReaderQuotas { get; }
+        public Encoding TextEncoding { get; set; }
+        public int TimeToLive { get; set; }
+        protected internal override void InitializeFrom(Binding binding);
+        protected override void OnApplyConfiguration(Binding binding);
+    }
+    public sealed class UdpRetransmissionSettingsElement : ServiceModelConfigurationElement {
+        public UdpRetransmissionSettingsElement();
+        public TimeSpan DelayLowerBound { get; set; }
+        public TimeSpan DelayUpperBound { get; set; }
+        public TimeSpan MaxDelayPerRetransmission { get; set; }
+        public int MaxMulticastRetransmitCount { get; set; }
+        public int MaxUnicastRetransmitCount { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class UdpTransportElement : TransportElement {
+        public UdpTransportElement();
+        public override Type BindingElementType { get; }
+        public int DuplicateMessageHistoryLength { get; set; }
+        public long MaxPendingMessagesTotalSize { get; set; }
+        public string MulticastInterfaceId { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public UdpRetransmissionSettingsElement RetransmissionSettings { get; set; }
+        public int SocketReceiveBufferSize { get; set; }
+        public int TimeToLive { get; set; }
+        public override void ApplyConfiguration(BindingElement bindingElement);
+        protected override TransportBindingElement CreateDefaultBindingElement();
+        protected internal override void InitializeFrom(BindingElement bindingElement);
+    }
+    public class UseManagedPresentationElement : BindingElementExtensionElement {
+        public UseManagedPresentationElement();
+        public override Type BindingElementType { get; }
+        protected internal override BindingElement CreateBindingElement();
+    }
+    public sealed class UseRequestHeadersForMetadataAddressElement : BehaviorExtensionElement {
+        public UseRequestHeadersForMetadataAddressElement();
+        public override Type BehaviorType { get; }
+        public DefaultPortElementCollection DefaultPorts { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected internal override object CreateBehavior();
+    }
+    public sealed class UserNameServiceElement : ConfigurationElement {
+        public UserNameServiceElement();
+        public TimeSpan CachedLogonTokenLifetime { get; set; }
+        public bool CacheLogonTokens { get; set; }
+        public string CustomUserNamePasswordValidatorType { get; set; }
+        public bool IncludeWindowsGroups { get; set; }
+        public int MaxCachedLogonTokens { get; set; }
+        public string MembershipProviderName { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public UserNamePasswordValidationMode UserNamePasswordValidationMode { get; set; }
+        public void Copy(UserNameServiceElement from);
+    }
+    public sealed class UserPrincipalNameElement : ConfigurationElement {
+        public UserPrincipalNameElement();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string Value { get; set; }
+    }
+    public class WebHttpBindingCollectionElement : StandardBindingCollectionElement<WebHttpBinding, WebHttpBindingElement> {
+        public WebHttpBindingCollectionElement();
+        protected internal override Binding GetDefault();
+    }
+    public class WebHttpBindingElement : StandardBindingElement {
+        public WebHttpBindingElement();
+        public WebHttpBindingElement(string name);
+        public bool AllowCookies { get; set; }
+        protected override Type BindingElementType { get; }
+        public bool BypassProxyOnLocal { get; set; }
+        public string ContentTypeMapper { get; set; }
+        public bool CrossDomainScriptAccessEnabled { get; set; }
+        public HostNameComparisonMode HostNameComparisonMode { get; set; }
+        public long MaxBufferPoolSize { get; set; }
+        public int MaxBufferSize { get; set; }
+        public long MaxReceivedMessageSize { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public Uri ProxyAddress { get; set; }
+        public XmlDictionaryReaderQuotasElement ReaderQuotas { get; }
+        public WebHttpSecurityElement Security { get; }
+        public TransferMode TransferMode { get; set; }
+        public bool UseDefaultWebProxy { get; set; }
+        public Encoding WriteEncoding { get; set; }
+        protected internal override void InitializeFrom(Binding binding);
+        protected override void OnApplyConfiguration(Binding binding);
+    }
+    public sealed class WebHttpElement : BehaviorExtensionElement {
+        public WebHttpElement();
+        public bool AutomaticFormatSelectionEnabled { get; set; }
+        public override Type BehaviorType { get; }
+        public WebMessageBodyStyle DefaultBodyStyle { get; set; }
+        public WebMessageFormat DefaultOutgoingResponseFormat { get; set; }
+        public bool FaultExceptionEnabled { get; set; }
+        public bool HelpEnabled { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected internal override object CreateBehavior();
+    }
+    public class WebHttpEndpointCollectionElement : StandardEndpointCollectionElement<WebHttpEndpoint, WebHttpEndpointElement> {
+        public WebHttpEndpointCollectionElement();
+    }
+    public class WebHttpEndpointElement : StandardEndpointElement {
+        public WebHttpEndpointElement();
+        public bool AutomaticFormatSelectionEnabled { get; set; }
+        public string ContentTypeMapper { get; set; }
+        public bool CrossDomainScriptAccessEnabled { get; set; }
+        public WebMessageFormat DefaultOutgoingResponseFormat { get; set; }
+        protected internal override Type EndpointType { get; }
+        public bool FaultExceptionEnabled { get; set; }
+        public bool HelpEnabled { get; set; }
+        public HostNameComparisonMode HostNameComparisonMode { get; set; }
+        public long MaxBufferPoolSize { get; set; }
+        public int MaxBufferSize { get; set; }
+        public long MaxReceivedMessageSize { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public XmlDictionaryReaderQuotasElement ReaderQuotas { get; }
+        public WebHttpSecurityElement Security { get; }
+        public TransferMode TransferMode { get; set; }
+        public Encoding WriteEncoding { get; set; }
+        protected internal override ServiceEndpoint CreateServiceEndpoint(ContractDescription contractDescription);
+        protected override void OnApplyConfiguration(ServiceEndpoint endpoint, ChannelEndpointElement serviceEndpointElement);
+        protected override void OnApplyConfiguration(ServiceEndpoint endpoint, ServiceEndpointElement serviceEndpointElement);
+        protected override void OnInitializeAndValidate(ChannelEndpointElement channelEndpointElement);
+        protected override void OnInitializeAndValidate(ServiceEndpointElement serviceEndpointElement);
+    }
+    public sealed class WebHttpSecurityElement : ServiceModelConfigurationElement {
+        public WebHttpSecurityElement();
+        public WebHttpSecurityMode Mode { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public HttpTransportSecurityElement Transport { get; }
+    }
+    public sealed class WebMessageEncodingElement : BindingElementExtensionElement {
+        public WebMessageEncodingElement();
+        public override Type BindingElementType { get; }
+        public int MaxReadPoolSize { get; set; }
+        public int MaxWritePoolSize { get; set; }
+        public XmlDictionaryReaderQuotasElement ReaderQuotas { get; }
+        public string WebContentTypeMapperType { get; set; }
+        public Encoding WriteEncoding { get; set; }
+        public override void ApplyConfiguration(BindingElement bindingElement);
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected internal override BindingElement CreateBindingElement();
+    }
+    public sealed class WebScriptEnablingElement : BehaviorExtensionElement {
+        public WebScriptEnablingElement();
+        public override Type BehaviorType { get; }
+        protected internal override object CreateBehavior();
+    }
+    public class WebScriptEndpointCollectionElement : StandardEndpointCollectionElement<WebScriptEndpoint, WebScriptEndpointElement> {
+        public WebScriptEndpointCollectionElement();
+    }
+    public class WebScriptEndpointElement : StandardEndpointElement {
+        public WebScriptEndpointElement();
+        public string ContentTypeMapper { get; set; }
+        public bool CrossDomainScriptAccessEnabled { get; set; }
+        protected internal override Type EndpointType { get; }
+        public HostNameComparisonMode HostNameComparisonMode { get; set; }
+        public long MaxBufferPoolSize { get; set; }
+        public int MaxBufferSize { get; set; }
+        public long MaxReceivedMessageSize { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public XmlDictionaryReaderQuotasElement ReaderQuotas { get; }
+        public WebHttpSecurityElement Security { get; }
+        public TransferMode TransferMode { get; set; }
+        public Encoding WriteEncoding { get; set; }
+        protected internal override ServiceEndpoint CreateServiceEndpoint(ContractDescription contractDescription);
+        protected override void OnApplyConfiguration(ServiceEndpoint endpoint, ChannelEndpointElement serviceEndpointElement);
+        protected override void OnApplyConfiguration(ServiceEndpoint endpoint, ServiceEndpointElement serviceEndpointElement);
+        protected override void OnInitializeAndValidate(ChannelEndpointElement channelEndpointElement);
+        protected override void OnInitializeAndValidate(ServiceEndpointElement serviceEndpointElement);
+    }
+    public class WebSocketTransportSettingsElement : ServiceModelConfigurationElement {
+        public WebSocketTransportSettingsElement();
+        public bool CreateNotificationOnConnection { get; set; }
+        public bool DisablePayloadMasking { get; set; }
+        public TimeSpan KeepAliveInterval { get; set; }
+        public int MaxPendingConnections { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public virtual string SubProtocol { get; set; }
+        public virtual WebSocketTransportUsage TransportUsage { get; set; }
+        public void ApplyConfiguration(WebSocketTransportSettings settings);
+        public void InitializeFrom(WebSocketTransportSettings settings);
+    }
+    public sealed class WindowsClientElement : ConfigurationElement {
+        public WindowsClientElement();
+        public TokenImpersonationLevel AllowedImpersonationLevel { get; set; }
+        public bool AllowNtlm { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public void Copy(WindowsClientElement from);
+    }
+    public sealed class WindowsServiceElement : ConfigurationElement {
+        public WindowsServiceElement();
+        public bool AllowAnonymousLogons { get; set; }
+        public bool IncludeWindowsGroups { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public void Copy(WindowsServiceElement from);
+    }
+    public sealed class WindowsStreamSecurityElement : BindingElementExtensionElement {
+        public WindowsStreamSecurityElement();
+        public override Type BindingElementType { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public ProtectionLevel ProtectionLevel { get; set; }
+        public override void ApplyConfiguration(BindingElement bindingElement);
+        public override void CopyFrom(ServiceModelExtensionElement from);
+        protected internal override BindingElement CreateBindingElement();
+        protected internal override void InitializeFrom(BindingElement bindingElement);
+    }
+    public class WorkflowRuntimeElement : BehaviorExtensionElement {
+        public WorkflowRuntimeElement();
+        public override Type BehaviorType { get; }
+        public TimeSpan CachedInstanceExpiration { get; set; }
+        public NameValueConfigurationCollection CommonParameters { get; }
+        public bool EnablePerformanceCounters { get; set; }
+        public string Name { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public ExtendedWorkflowRuntimeServiceElementCollection Services { get; }
+        public bool ValidateOnCreate { get; set; }
+        protected internal override object CreateBehavior();
+    }
+    public class WS2007FederationHttpBindingCollectionElement : StandardBindingCollectionElement<WS2007FederationHttpBinding, WS2007FederationHttpBindingElement> {
+        public WS2007FederationHttpBindingCollectionElement();
+    }
+    public class WS2007FederationHttpBindingElement : WSFederationHttpBindingElement {
+        public WS2007FederationHttpBindingElement();
+        public WS2007FederationHttpBindingElement(string name);
+        protected override Type BindingElementType { get; }
+    }
+    public class WS2007HttpBindingCollectionElement : StandardBindingCollectionElement<WS2007HttpBinding, WS2007HttpBindingElement> {
+        public WS2007HttpBindingCollectionElement();
+    }
+    public class WS2007HttpBindingElement : WSHttpBindingElement {
+        public WS2007HttpBindingElement();
+        public WS2007HttpBindingElement(string name);
+        protected override Type BindingElementType { get; }
+    }
+    public sealed class WsdlImporterElement : ConfigurationElement {
+        public WsdlImporterElement();
+        public WsdlImporterElement(string type);
+        public WsdlImporterElement(Type type);
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string Type { get; set; }
+    }
+    public sealed class WsdlImporterElementCollection : ServiceModelEnhancedConfigurationElementCollection<WsdlImporterElement> {
+        public WsdlImporterElementCollection();
+        protected override object GetElementKey(ConfigurationElement element);
+    }
+    public class WSDualHttpBindingCollectionElement : StandardBindingCollectionElement<WSDualHttpBinding, WSDualHttpBindingElement> {
+        public WSDualHttpBindingCollectionElement();
+    }
+    public class WSDualHttpBindingElement : StandardBindingElement {
+        public WSDualHttpBindingElement();
+        public WSDualHttpBindingElement(string name);
+        protected override Type BindingElementType { get; }
+        public bool BypassProxyOnLocal { get; set; }
+        public Uri ClientBaseAddress { get; set; }
+        public HostNameComparisonMode HostNameComparisonMode { get; set; }
+        public long MaxBufferPoolSize { get; set; }
+        public long MaxReceivedMessageSize { get; set; }
+        public WSMessageEncoding MessageEncoding { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public Uri ProxyAddress { get; set; }
+        public XmlDictionaryReaderQuotasElement ReaderQuotas { get; }
+        public StandardBindingReliableSessionElement ReliableSession { get; }
+        public WSDualHttpSecurityElement Security { get; }
+        public Encoding TextEncoding { get; set; }
+        public bool TransactionFlow { get; set; }
+        public bool UseDefaultWebProxy { get; set; }
+        protected internal override void InitializeFrom(Binding binding);
+        protected override void OnApplyConfiguration(Binding binding);
+    }
+    public sealed class WSDualHttpSecurityElement : ServiceModelConfigurationElement {
+        public WSDualHttpSecurityElement();
+        public MessageSecurityOverHttpElement Message { get; }
+        public WSDualHttpSecurityMode Mode { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public class WSFederationHttpBindingCollectionElement : StandardBindingCollectionElement<WSFederationHttpBinding, WSFederationHttpBindingElement> {
+        public WSFederationHttpBindingCollectionElement();
+    }
+    public class WSFederationHttpBindingElement : WSHttpBindingBaseElement {
+        public WSFederationHttpBindingElement();
+        public WSFederationHttpBindingElement(string name);
+        protected override Type BindingElementType { get; }
+        public Uri PrivacyNoticeAt { get; set; }
+        public int PrivacyNoticeVersion { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public WSFederationHttpSecurityElement Security { get; }
+        protected internal override void InitializeFrom(Binding binding);
+        protected override void OnApplyConfiguration(Binding binding);
+    }
+    public sealed class WSFederationHttpSecurityElement : ServiceModelConfigurationElement {
+        public WSFederationHttpSecurityElement();
+        public FederatedMessageSecurityOverHttpElement Message { get; }
+        public WSFederationHttpSecurityMode Mode { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public abstract class WSHttpBindingBaseElement : StandardBindingElement {
+        protected WSHttpBindingBaseElement();
+        protected WSHttpBindingBaseElement(string name);
+        public bool BypassProxyOnLocal { get; set; }
+        public HostNameComparisonMode HostNameComparisonMode { get; set; }
+        public long MaxBufferPoolSize { get; set; }
+        public long MaxReceivedMessageSize { get; set; }
+        public WSMessageEncoding MessageEncoding { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public Uri ProxyAddress { get; set; }
+        public XmlDictionaryReaderQuotasElement ReaderQuotas { get; }
+        public StandardBindingOptionalReliableSessionElement ReliableSession { get; }
+        public Encoding TextEncoding { get; set; }
+        public bool TransactionFlow { get; set; }
+        public bool UseDefaultWebProxy { get; set; }
+        protected internal override void InitializeFrom(Binding binding);
+        protected override void OnApplyConfiguration(Binding binding);
+    }
+    public class WSHttpBindingCollectionElement : StandardBindingCollectionElement<WSHttpBinding, WSHttpBindingElement> {
+        public WSHttpBindingCollectionElement();
+    }
+    public class WSHttpBindingElement : WSHttpBindingBaseElement {
+        public WSHttpBindingElement();
+        public WSHttpBindingElement(string name);
+        public bool AllowCookies { get; set; }
+        protected override Type BindingElementType { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public WSHttpSecurityElement Security { get; }
+        protected internal override void InitializeFrom(Binding binding);
+        protected override void OnApplyConfiguration(Binding binding);
+    }
+    public class WSHttpContextBindingCollectionElement : StandardBindingCollectionElement<WSHttpContextBinding, WSHttpContextBindingElement> {
+        public WSHttpContextBindingCollectionElement();
+    }
+    public class WSHttpContextBindingElement : WSHttpBindingElement {
+        public WSHttpContextBindingElement();
+        public WSHttpContextBindingElement(string name);
+        protected override Type BindingElementType { get; }
+        public Uri ClientCallbackAddress { get; set; }
+        public bool ContextManagementEnabled { get; set; }
+        public ProtectionLevel ContextProtectionLevel { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected internal override void InitializeFrom(Binding binding);
+        protected override void OnApplyConfiguration(Binding binding);
+    }
+    public sealed class WSHttpSecurityElement : ServiceModelConfigurationElement {
+        public WSHttpSecurityElement();
+        public NonDualMessageSecurityOverHttpElement Message { get; }
+        public SecurityMode Mode { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public WSHttpTransportSecurityElement Transport { get; }
+    }
+    public sealed class WSHttpTransportSecurityElement : ServiceModelConfigurationElement {
+        public WSHttpTransportSecurityElement();
+        public HttpClientCredentialType ClientCredentialType { get; set; }
+        public ExtendedProtectionPolicyElement ExtendedProtectionPolicy { get; private set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public HttpProxyCredentialType ProxyCredentialType { get; set; }
+        public string Realm { get; set; }
+    }
+    public sealed class X509CertificateTrustedIssuerElement : ConfigurationElement {
+        public X509CertificateTrustedIssuerElement();
+        public string FindValue { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public StoreLocation StoreLocation { get; set; }
+        public StoreName StoreName { get; set; }
+        public X509FindType X509FindType { get; set; }
+        public void Copy(X509CertificateTrustedIssuerElement from);
+    }
+    public sealed class X509CertificateTrustedIssuerElementCollection : ServiceModelConfigurationElementCollection<X509CertificateTrustedIssuerElement> {
+        public X509CertificateTrustedIssuerElementCollection();
+        protected override object GetElementKey(ConfigurationElement element);
+    }
+    public sealed class X509ClientCertificateAuthenticationElement : ConfigurationElement {
+        public X509ClientCertificateAuthenticationElement();
+        public X509CertificateValidationMode CertificateValidationMode { get; set; }
+        public string CustomCertificateValidatorType { get; set; }
+        public bool IncludeWindowsGroups { get; set; }
+        public bool MapClientCertificateToWindowsAccount { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public X509RevocationMode RevocationMode { get; set; }
+        public StoreLocation TrustedStoreLocation { get; set; }
+        public void Copy(X509ClientCertificateAuthenticationElement from);
+    }
+    public sealed class X509ClientCertificateCredentialsElement : ConfigurationElement {
+        public X509ClientCertificateCredentialsElement();
+        public string FindValue { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public StoreLocation StoreLocation { get; set; }
+        public StoreName StoreName { get; set; }
+        public X509FindType X509FindType { get; set; }
+        public void Copy(X509ClientCertificateCredentialsElement from);
+    }
+    public sealed class X509DefaultServiceCertificateElement : ConfigurationElement {
+        public X509DefaultServiceCertificateElement();
+        public string FindValue { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public StoreLocation StoreLocation { get; set; }
+        public StoreName StoreName { get; set; }
+        public X509FindType X509FindType { get; set; }
+        public void Copy(X509DefaultServiceCertificateElement from);
+    }
+    public sealed class X509InitiatorCertificateClientElement : ConfigurationElement {
+        public X509InitiatorCertificateClientElement();
+        public string FindValue { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public StoreLocation StoreLocation { get; set; }
+        public StoreName StoreName { get; set; }
+        public X509FindType X509FindType { get; set; }
+        public void Copy(X509InitiatorCertificateClientElement from);
+    }
+    public sealed class X509InitiatorCertificateServiceElement : ConfigurationElement {
+        public X509InitiatorCertificateServiceElement();
+        public X509ClientCertificateAuthenticationElement Authentication { get; }
+        public X509ClientCertificateCredentialsElement Certificate { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public void Copy(X509InitiatorCertificateServiceElement from);
+    }
+    public sealed class X509PeerCertificateAuthenticationElement : ConfigurationElement {
+        public X509PeerCertificateAuthenticationElement();
+        public X509CertificateValidationMode CertificateValidationMode { get; set; }
+        public string CustomCertificateValidatorType { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public X509RevocationMode RevocationMode { get; set; }
+        public StoreLocation TrustedStoreLocation { get; set; }
+        public void Copy(X509PeerCertificateAuthenticationElement from);
+    }
+    public sealed class X509PeerCertificateElement : ConfigurationElement {
+        public X509PeerCertificateElement();
+        public string FindValue { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public StoreLocation StoreLocation { get; set; }
+        public StoreName StoreName { get; set; }
+        public X509FindType X509FindType { get; set; }
+        public void Copy(X509PeerCertificateElement from);
+    }
+    public sealed class X509RecipientCertificateClientElement : ConfigurationElement {
+        public X509RecipientCertificateClientElement();
+        public X509ServiceCertificateAuthenticationElement Authentication { get; }
+        public X509DefaultServiceCertificateElement DefaultCertificate { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public X509ScopedServiceCertificateElementCollection ScopedCertificates { get; }
+        public X509ServiceCertificateAuthenticationElement SslCertificateAuthentication { get; }
+        public void Copy(X509RecipientCertificateClientElement from);
+    }
+    public sealed class X509RecipientCertificateServiceElement : ConfigurationElement {
+        public X509RecipientCertificateServiceElement();
+        public string FindValue { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public StoreLocation StoreLocation { get; set; }
+        public StoreName StoreName { get; set; }
+        public X509FindType X509FindType { get; set; }
+        public void Copy(X509RecipientCertificateServiceElement from);
+    }
+    public sealed class X509ScopedServiceCertificateElement : ConfigurationElement {
+        public X509ScopedServiceCertificateElement();
+        public string FindValue { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public StoreLocation StoreLocation { get; set; }
+        public StoreName StoreName { get; set; }
+        public Uri TargetUri { get; set; }
+        public X509FindType X509FindType { get; set; }
+        public void Copy(X509ScopedServiceCertificateElement from);
+    }
+    public sealed class X509ScopedServiceCertificateElementCollection : ServiceModelConfigurationElementCollection<X509ScopedServiceCertificateElement> {
+        public X509ScopedServiceCertificateElementCollection();
+        protected override object GetElementKey(ConfigurationElement element);
+    }
+    public sealed class X509ServiceCertificateAuthenticationElement : ConfigurationElement {
+        public X509ServiceCertificateAuthenticationElement();
+        public X509CertificateValidationMode CertificateValidationMode { get; set; }
+        public string CustomCertificateValidatorType { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public X509RevocationMode RevocationMode { get; set; }
+        public StoreLocation TrustedStoreLocation { get; set; }
+        public void Copy(X509ServiceCertificateAuthenticationElement from);
+    }
+    public sealed class XmlDictionaryReaderQuotasElement : ServiceModelConfigurationElement {
+        public XmlDictionaryReaderQuotasElement();
+        public int MaxArrayLength { get; set; }
+        public int MaxBytesPerRead { get; set; }
+        public int MaxDepth { get; set; }
+        public int MaxNameTableCharCount { get; set; }
+        public int MaxStringContentLength { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class XmlElementElement : ConfigurationElement {
+        public XmlElementElement();
+        public XmlElementElement(XmlElement element);
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public XmlElement XmlElement { get; set; }
+        public void Copy(XmlElementElement source);
+        protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey);
+        protected override void PostDeserialize();
+        protected override bool SerializeToXmlElement(XmlWriter writer, string elementName);
+    }
+    public sealed class XmlElementElementCollection : ServiceModelConfigurationElementCollection<XmlElementElement> {
+        public XmlElementElementCollection();
+        protected override object GetElementKey(ConfigurationElement element);
+        protected override bool OnDeserializeUnrecognizedElement(string elementName, XmlReader reader);
+        protected override void Unmerge(ConfigurationElement sourceElement, ConfigurationElement parentElement, ConfigurationSaveMode saveMode);
+    }
+    public sealed class XPathMessageFilterElement : ConfigurationElement {
+        public XPathMessageFilterElement();
+        public XPathMessageFilter Filter { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey);
+        protected override bool SerializeToXmlElement(XmlWriter writer, string elementName);
+    }
+    public sealed class XPathMessageFilterElementCollection : ServiceModelConfigurationElementCollection<XPathMessageFilterElement> {
+        public XPathMessageFilterElementCollection();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public override XPathMessageFilterElement this[object key] { get; set; }
+        public override bool ContainsKey(object key);
+        protected override object GetElementKey(ConfigurationElement element);
+    }
+    public class XPathMessageFilterElementComparer : IComparer {
+        public XPathMessageFilterElementComparer();
+        int System.Collections.IComparer.Compare(object x, object y);
+    }
+}
```

