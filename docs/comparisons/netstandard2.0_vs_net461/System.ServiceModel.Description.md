# System.ServiceModel.Description

``` diff
+namespace System.ServiceModel.Description {
+    public class CallbackDebugBehavior : IEndpointBehavior {
+        public CallbackDebugBehavior(bool includeExceptionDetailInFaults);
+        public bool IncludeExceptionDetailInFaults { get; set; }
+        void System.ServiceModel.Description.IEndpointBehavior.AddBindingParameters(ServiceEndpoint serviceEndpoint, BindingParameterCollection bindingParameters);
+        void System.ServiceModel.Description.IEndpointBehavior.ApplyClientBehavior(ServiceEndpoint serviceEndpoint, ClientRuntime behavior);
+        void System.ServiceModel.Description.IEndpointBehavior.ApplyDispatchBehavior(ServiceEndpoint serviceEndpoint, EndpointDispatcher endpointDispatcher);
+        void System.ServiceModel.Description.IEndpointBehavior.Validate(ServiceEndpoint serviceEndpoint);
+    }
+    public class ClientCredentials : SecurityCredentialsManager, IEndpointBehavior {
+        public ClientCredentials();
+        protected ClientCredentials(ClientCredentials other);
+        public X509CertificateInitiatorClientCredential ClientCertificate { get; }
+        public HttpDigestClientCredential HttpDigest { get; }
+        public IssuedTokenClientCredential IssuedToken { get; }
+        public PeerCredential Peer { get; }
+        public SecurityTokenHandlerCollectionManager SecurityTokenHandlerCollectionManager { get; set; }
+        public X509CertificateRecipientClientCredential ServiceCertificate { get; }
+        public bool SupportInteractive { get; set; }
+        public bool UseIdentityConfiguration { get; set; }
+        public UserNamePasswordClientCredential UserName { get; }
+        public WindowsClientCredential Windows { get; }
+        public virtual void ApplyClientBehavior(ServiceEndpoint serviceEndpoint, ClientRuntime behavior);
+        public ClientCredentials Clone();
+        protected virtual ClientCredentials CloneCore();
+        public override SecurityTokenManager CreateSecurityTokenManager();
+        protected internal virtual SecurityToken GetInfoCardSecurityToken(bool requiresInfoCard, CardSpacePolicyElement[] chain, SecurityTokenSerializer tokenSerializer);
+        void System.ServiceModel.Description.IEndpointBehavior.AddBindingParameters(ServiceEndpoint serviceEndpoint, BindingParameterCollection bindingParameters);
+        void System.ServiceModel.Description.IEndpointBehavior.ApplyDispatchBehavior(ServiceEndpoint serviceEndpoint, EndpointDispatcher endpointDispatcher);
+        void System.ServiceModel.Description.IEndpointBehavior.Validate(ServiceEndpoint serviceEndpoint);
+    }
+    public class ClientViaBehavior : IEndpointBehavior {
+        public ClientViaBehavior(Uri uri);
+        public Uri Uri { get; set; }
+        void System.ServiceModel.Description.IEndpointBehavior.AddBindingParameters(ServiceEndpoint serviceEndpoint, BindingParameterCollection bindingParameters);
+        void System.ServiceModel.Description.IEndpointBehavior.ApplyClientBehavior(ServiceEndpoint serviceEndpoint, ClientRuntime behavior);
+        void System.ServiceModel.Description.IEndpointBehavior.ApplyDispatchBehavior(ServiceEndpoint serviceEndpoint, EndpointDispatcher endpointDispatcher);
+        void System.ServiceModel.Description.IEndpointBehavior.Validate(ServiceEndpoint serviceEndpoint);
+    }
+    public class ContractDescription {
+        public ContractDescription(string name);
+        public ContractDescription(string name, string ns);
+        public KeyedByTypeCollection<IContractBehavior> Behaviors { get; }
+        public Type CallbackContractType { get; set; }
+        public string ConfigurationName { get; set; }
+        public KeyedCollection<Type, IContractBehavior> ContractBehaviors { get; }
+        public Type ContractType { get; set; }
+        public bool HasProtectionLevel { get; }
+        public string Name { get; set; }
+        public string Namespace { get; set; }
+        public OperationDescriptionCollection Operations { get; }
+        public ProtectionLevel ProtectionLevel { get; set; }
+        public SessionMode SessionMode { get; set; }
+        public static ContractDescription GetContract(Type contractType);
+        public static ContractDescription GetContract(Type contractType, object serviceImplementation);
+        public static ContractDescription GetContract(Type contractType, Type serviceType);
+        public Collection<ContractDescription> GetInheritedContracts();
+        public bool ShouldSerializeProtectionLevel();
+    }
+    public class DataContractSerializerMessageContractImporter : IWsdlImportExtension {
+        public DataContractSerializerMessageContractImporter();
+        public bool Enabled { get; set; }
+        void System.ServiceModel.Description.IWsdlImportExtension.BeforeImport(ServiceDescriptionCollection wsdlDocuments, XmlSchemaSet xmlSchemas, ICollection<XmlElement> policy);
+        void System.ServiceModel.Description.IWsdlImportExtension.ImportContract(WsdlImporter importer, WsdlContractConversionContext contractContext);
+        void System.ServiceModel.Description.IWsdlImportExtension.ImportEndpoint(WsdlImporter importer, WsdlEndpointConversionContext endpointContext);
+    }
+    public class DataContractSerializerOperationBehavior : IOperationBehavior, IWsdlExportExtension {
+        public DataContractSerializerOperationBehavior(OperationDescription operation);
+        public DataContractSerializerOperationBehavior(OperationDescription operation, DataContractFormatAttribute dataContractFormatAttribute);
+        public DataContractFormatAttribute DataContractFormatAttribute { get; }
+        public DataContractResolver DataContractResolver { get; set; }
+        public IDataContractSurrogate DataContractSurrogate { get; set; }
+        public bool IgnoreExtensionDataObject { get; set; }
+        public int MaxItemsInObjectGraph { get; set; }
+        public virtual XmlObjectSerializer CreateSerializer(Type type, string name, string ns, IList<Type> knownTypes);
+        public virtual XmlObjectSerializer CreateSerializer(Type type, XmlDictionaryString name, XmlDictionaryString ns, IList<Type> knownTypes);
+        void System.ServiceModel.Description.IOperationBehavior.AddBindingParameters(OperationDescription description, BindingParameterCollection parameters);
+        void System.ServiceModel.Description.IOperationBehavior.ApplyClientBehavior(OperationDescription description, ClientOperation proxy);
+        void System.ServiceModel.Description.IOperationBehavior.ApplyDispatchBehavior(OperationDescription description, DispatchOperation dispatch);
+        void System.ServiceModel.Description.IOperationBehavior.Validate(OperationDescription description);
+        void System.ServiceModel.Description.IWsdlExportExtension.ExportContract(WsdlExporter exporter, WsdlContractConversionContext contractContext);
+        void System.ServiceModel.Description.IWsdlExportExtension.ExportEndpoint(WsdlExporter exporter, WsdlEndpointConversionContext endpointContext);
+    }
+    public class DispatcherSynchronizationBehavior : IEndpointBehavior {
+        public DispatcherSynchronizationBehavior();
+        public DispatcherSynchronizationBehavior(bool asynchronousSendEnabled, int maxPendingReceives);
+        public bool AsynchronousSendEnabled { get; set; }
+        public int MaxPendingReceives { get; set; }
+        void System.ServiceModel.Description.IEndpointBehavior.AddBindingParameters(ServiceEndpoint serviceEndpoint, BindingParameterCollection parameters);
+        void System.ServiceModel.Description.IEndpointBehavior.ApplyClientBehavior(ServiceEndpoint serviceEndpoint, ClientRuntime behavior);
+        void System.ServiceModel.Description.IEndpointBehavior.ApplyDispatchBehavior(ServiceEndpoint serviceEndpoint, EndpointDispatcher endpointDispatcher);
+        void System.ServiceModel.Description.IEndpointBehavior.Validate(ServiceEndpoint serviceEndpoint);
+    }
+    public sealed class DurableOperationAttribute : Attribute, IOperationBehavior, IWmiInstanceProvider {
+        public DurableOperationAttribute();
+        public bool CanCreateInstance { get; set; }
+        public bool CompletesInstance { get; set; }
+        public void AddBindingParameters(OperationDescription operationDescription, BindingParameterCollection bindingParameters);
+        public void ApplyClientBehavior(OperationDescription operationDescription, ClientOperation clientOperation);
+        public void ApplyDispatchBehavior(OperationDescription operationDescription, DispatchOperation dispatchOperation);
+        public void Validate(OperationDescription operationDescription);
+    }
+    public sealed class DurableServiceAttribute : Attribute, IContextSessionProvider, IServiceBehavior, IWmiInstanceProvider {
+        public DurableServiceAttribute();
+        public bool SaveStateInOperationTransaction { get; set; }
+        public UnknownExceptionAction UnknownExceptionAction { get; set; }
+        public void AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection bindingParameters);
+        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase);
+        public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase);
+    }
+    public class FaultDescription {
+        public FaultDescription(string action);
+        public string Action { get; internal set; }
+        public Type DetailType { get; set; }
+        public bool HasProtectionLevel { get; }
+        public string Name { get; set; }
+        public string Namespace { get; set; }
+        public ProtectionLevel ProtectionLevel { get; set; }
+        public bool ShouldSerializeProtectionLevel();
+    }
+    public class FaultDescriptionCollection : Collection<FaultDescription> {
+        public FaultDescription Find(string action);
+        public Collection<FaultDescription> FindAll(string action);
+    }
+    public interface IContractBehavior {
+        void AddBindingParameters(ContractDescription contractDescription, ServiceEndpoint endpoint, BindingParameterCollection bindingParameters);
+        void ApplyClientBehavior(ContractDescription contractDescription, ServiceEndpoint endpoint, ClientRuntime clientRuntime);
+        void ApplyDispatchBehavior(ContractDescription contractDescription, ServiceEndpoint endpoint, DispatchRuntime dispatchRuntime);
+        void Validate(ContractDescription contractDescription, ServiceEndpoint endpoint);
+    }
+    public interface IContractBehaviorAttribute {
+        Type TargetContract { get; }
+    }
+    public interface IEndpointBehavior {
+        void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters);
+        void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime);
+        void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher);
+        void Validate(ServiceEndpoint endpoint);
+    }
+    public interface IMetadataExchange {
+        IAsyncResult BeginGet(Message request, AsyncCallback callback, object state);
+        Message EndGet(IAsyncResult result);
+        Message Get(Message request);
+    }
+    public interface IOperationBehavior {
+        void AddBindingParameters(OperationDescription operationDescription, BindingParameterCollection bindingParameters);
+        void ApplyClientBehavior(OperationDescription operationDescription, ClientOperation clientOperation);
+        void ApplyDispatchBehavior(OperationDescription operationDescription, DispatchOperation dispatchOperation);
+        void Validate(OperationDescription operationDescription);
+    }
+    public interface IOperationContractGenerationExtension {
+        void GenerateOperation(OperationContractGenerationContext context);
+    }
+    public interface IPolicyExportExtension {
+        void ExportPolicy(MetadataExporter exporter, PolicyConversionContext context);
+    }
+    public interface IPolicyImportExtension {
+        void ImportPolicy(MetadataImporter importer, PolicyConversionContext context);
+    }
+    public interface IServiceBehavior {
+        void AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection bindingParameters);
+        void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase);
+        void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase);
+    }
+    public interface IServiceContractGenerationExtension {
+        void GenerateContract(ServiceContractGenerationContext context);
+    }
+    public interface IWsdlExportExtension {
+        void ExportContract(WsdlExporter exporter, WsdlContractConversionContext context);
+        void ExportEndpoint(WsdlExporter exporter, WsdlEndpointConversionContext context);
+    }
+    public interface IWsdlImportExtension {
+        void BeforeImport(ServiceDescriptionCollection wsdlDocuments, XmlSchemaSet xmlSchemas, ICollection<XmlElement> policy);
+        void ImportContract(WsdlImporter importer, WsdlContractConversionContext context);
+        void ImportEndpoint(WsdlImporter importer, WsdlEndpointConversionContext context);
+    }
+    public class JsonFaultDetail {
+        public JsonFaultDetail();
+        public ExceptionDetail ExceptionDetail { get; set; }
+        public string ExceptionType { get; set; }
+        public string Message { get; set; }
+        public string StackTrace { get; set; }
+    }
+    public enum ListenUriMode {
+        Explicit = 0,
+        Unique = 1,
+    }
+    public class MessageBodyDescription {
+        public MessageBodyDescription();
+        public MessagePartDescriptionCollection Parts { get; }
+        public MessagePartDescription ReturnValue { get; set; }
+        public string WrapperName { get; set; }
+        public string WrapperNamespace { get; set; }
+    }
+    public class MessageDescription {
+        public MessageDescription(string action, MessageDirection direction);
+        public string Action { get; internal set; }
+        public MessageBodyDescription Body { get; }
+        public MessageDirection Direction { get; }
+        public bool HasProtectionLevel { get; }
+        public MessageHeaderDescriptionCollection Headers { get; }
+        public Type MessageType { get; set; }
+        public MessagePropertyDescriptionCollection Properties { get; }
+        public ProtectionLevel ProtectionLevel { get; set; }
+        public bool ShouldSerializeProtectionLevel();
+    }
+    public class MessageDescriptionCollection : Collection<MessageDescription> {
+        public MessageDescription Find(string action);
+        public Collection<MessageDescription> FindAll(string action);
+    }
+    public enum MessageDirection {
+        Input = 0,
+        Output = 1,
+    }
+    public class MessageHeaderDescription : MessagePartDescription {
+        public MessageHeaderDescription(string name, string ns);
+        public string Actor { get; set; }
+        public bool MustUnderstand { get; set; }
+        public bool Relay { get; set; }
+        public bool TypedHeader { get; set; }
+    }
+    public class MessageHeaderDescriptionCollection : KeyedCollection<XmlQualifiedName, MessageHeaderDescription> {
+        protected override XmlQualifiedName GetKeyForItem(MessageHeaderDescription item);
+    }
+    public class MessagePartDescription {
+        public MessagePartDescription(string name, string ns);
+        public bool HasProtectionLevel { get; }
+        public int Index { get; set; }
+        public MemberInfo MemberInfo { get; set; }
+        public bool Multiple { get; set; }
+        public string Name { get; }
+        public string Namespace { get; }
+        public ProtectionLevel ProtectionLevel { get; set; }
+        public Type Type { get; set; }
+    }
+    public class MessagePartDescriptionCollection : KeyedCollection<XmlQualifiedName, MessagePartDescription> {
+        protected override XmlQualifiedName GetKeyForItem(MessagePartDescription item);
+    }
+    public class MessagePropertyDescription : MessagePartDescription {
+        public MessagePropertyDescription(string name);
+    }
+    public class MessagePropertyDescriptionCollection : KeyedCollection<string, MessagePropertyDescription> {
+        protected override string GetKeyForItem(MessagePropertyDescription item);
+    }
+    public class MetadataConversionError {
+        public MetadataConversionError(string message);
+        public MetadataConversionError(string message, bool isWarning);
+        public bool IsWarning { get; }
+        public string Message { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+    }
+    public static class MetadataExchangeBindings {
+        public static Binding CreateMexHttpBinding();
+        public static Binding CreateMexHttpsBinding();
+        public static Binding CreateMexNamedPipeBinding();
+        public static Binding CreateMexTcpBinding();
+    }
+    public class MetadataExchangeClient {
+        public MetadataExchangeClient();
+        public MetadataExchangeClient(Binding mexBinding);
+        public MetadataExchangeClient(EndpointAddress address);
+        public MetadataExchangeClient(string endpointConfigurationName);
+        public MetadataExchangeClient(Uri address, MetadataExchangeClientMode mode);
+        public ICredentials HttpCredentials { get; set; }
+        public int MaximumResolvedReferences { get; set; }
+        public TimeSpan OperationTimeout { get; set; }
+        public bool ResolveMetadataReferences { get; set; }
+        public ClientCredentials SoapCredentials { get; set; }
+        public IAsyncResult BeginGetMetadata(AsyncCallback callback, object asyncState);
+        public IAsyncResult BeginGetMetadata(EndpointAddress address, AsyncCallback callback, object asyncState);
+        public IAsyncResult BeginGetMetadata(Uri address, MetadataExchangeClientMode mode, AsyncCallback callback, object asyncState);
+        public MetadataSet EndGetMetadata(IAsyncResult result);
+        protected internal virtual ChannelFactory<IMetadataExchange> GetChannelFactory(EndpointAddress metadataAddress, string dialect, string identifier);
+        public MetadataSet GetMetadata();
+        public MetadataSet GetMetadata(EndpointAddress address);
+        public MetadataSet GetMetadata(EndpointAddress address, Uri via);
+        public MetadataSet GetMetadata(Uri address, MetadataExchangeClientMode mode);
+        public Task<MetadataSet> GetMetadataAsync();
+        public Task<MetadataSet> GetMetadataAsync(EndpointAddress address);
+        public Task<MetadataSet> GetMetadataAsync(EndpointAddress address, Uri via);
+        public Task<MetadataSet> GetMetadataAsync(Uri address, MetadataExchangeClientMode mode);
+        protected internal virtual HttpWebRequest GetWebRequest(Uri location, string dialect, string identifier);
+    }
+    public enum MetadataExchangeClientMode {
+        HttpGet = 1,
+        MetadataExchange = 0,
+    }
+    public abstract class MetadataExporter {
+        public Collection<MetadataConversionError> Errors { get; }
+        public PolicyVersion PolicyVersion { get; set; }
+        public Dictionary<object, object> State { get; }
+        public abstract void ExportContract(ContractDescription contract);
+        public abstract void ExportEndpoint(ServiceEndpoint endpoint);
+        protected internal PolicyConversionContext ExportPolicy(ServiceEndpoint endpoint);
+        public abstract MetadataSet GetGeneratedMetadata();
+    }
+    public abstract class MetadataImporter {
+        public Collection<MetadataConversionError> Errors { get; }
+        public Dictionary<XmlQualifiedName, ContractDescription> KnownContracts { get; }
+        public KeyedByTypeCollection<IPolicyImportExtension> PolicyImportExtensions { get; }
+        public Dictionary<object, object> State { get; }
+        public abstract Collection<ContractDescription> ImportAllContracts();
+        public abstract ServiceEndpointCollection ImportAllEndpoints();
+    }
+    public sealed class MetadataImporterQuotas {
+        public MetadataImporterQuotas();
+        public static MetadataImporterQuotas Defaults { get; }
+        public static MetadataImporterQuotas Max { get; }
+    }
+    public class MetadataLocation {
+        public MetadataLocation();
+        public MetadataLocation(string location);
+        public string Location { get; set; }
+    }
+    public class MetadataReference : IXmlSerializable {
+        public MetadataReference();
+        public MetadataReference(EndpointAddress address, AddressingVersion addressVersion);
+        public EndpointAddress Address { get; set; }
+        public AddressingVersion AddressVersion { get; set; }
+        XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
+        void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader);
+        void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer);
+    }
+    public static class MetadataResolver {
+        public static IAsyncResult BeginResolve(IEnumerable<ContractDescription> contracts, EndpointAddress address, AsyncCallback callback, object asyncState);
+        public static IAsyncResult BeginResolve(IEnumerable<ContractDescription> contracts, EndpointAddress address, MetadataExchangeClient client, AsyncCallback callback, object asyncState);
+        public static IAsyncResult BeginResolve(IEnumerable<ContractDescription> contracts, Uri address, MetadataExchangeClientMode mode, AsyncCallback callback, object asyncState);
+        public static IAsyncResult BeginResolve(IEnumerable<ContractDescription> contracts, Uri address, MetadataExchangeClientMode mode, MetadataExchangeClient client, AsyncCallback callback, object asyncState);
+        public static IAsyncResult BeginResolve(Type contract, EndpointAddress address, AsyncCallback callback, object asyncState);
+        public static IAsyncResult BeginResolve(Type contract, Uri address, MetadataExchangeClientMode mode, AsyncCallback callback, object asyncState);
+        public static ServiceEndpointCollection EndResolve(IAsyncResult result);
+        public static ServiceEndpointCollection Resolve(IEnumerable<ContractDescription> contracts, EndpointAddress address);
+        public static ServiceEndpointCollection Resolve(IEnumerable<ContractDescription> contracts, EndpointAddress address, MetadataExchangeClient client);
+        public static ServiceEndpointCollection Resolve(IEnumerable<ContractDescription> contracts, Uri address, MetadataExchangeClientMode mode);
+        public static ServiceEndpointCollection Resolve(IEnumerable<ContractDescription> contracts, Uri address, MetadataExchangeClientMode mode, MetadataExchangeClient client);
+        public static ServiceEndpointCollection Resolve(Type contract, EndpointAddress address);
+        public static ServiceEndpointCollection Resolve(Type contract, Uri address, MetadataExchangeClientMode mode);
+    }
+    public class MetadataSection {
+        public MetadataSection();
+        public MetadataSection(string dialect, string identifier, object metadata);
+        public Collection<XmlAttribute> Attributes { get; }
+        public string Dialect { get; set; }
+        public string Identifier { get; set; }
+        public object Metadata { get; set; }
+        public static string MetadataExchangeDialect { get; }
+        public static string PolicyDialect { get; }
+        public static string ServiceDescriptionDialect { get; }
+        public static string XmlSchemaDialect { get; }
+        public static MetadataSection CreateFromPolicy(XmlElement policy, string identifier);
+        public static MetadataSection CreateFromSchema(XmlSchema schema);
+        public static MetadataSection CreateFromServiceDescription(ServiceDescription serviceDescription);
+    }
+    public class MetadataSet : IXmlSerializable {
+        public MetadataSet();
+        public MetadataSet(IEnumerable<MetadataSection> sections);
+        public Collection<XmlAttribute> Attributes { get; }
+        public Collection<MetadataSection> MetadataSections { get; }
+        public static MetadataSet ReadFrom(XmlReader reader);
+        XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
+        void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader);
+        void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer);
+        public void WriteTo(XmlWriter writer);
+    }
+    public class MustUnderstandBehavior : IEndpointBehavior {
+        public MustUnderstandBehavior(bool validate);
+        public bool ValidateMustUnderstand { get; set; }
+        void System.ServiceModel.Description.IEndpointBehavior.AddBindingParameters(ServiceEndpoint serviceEndpoint, BindingParameterCollection bindingParameters);
+        void System.ServiceModel.Description.IEndpointBehavior.ApplyClientBehavior(ServiceEndpoint serviceEndpoint, ClientRuntime behavior);
+        void System.ServiceModel.Description.IEndpointBehavior.ApplyDispatchBehavior(ServiceEndpoint serviceEndpoint, EndpointDispatcher endpointDispatcher);
+        void System.ServiceModel.Description.IEndpointBehavior.Validate(ServiceEndpoint serviceEndpoint);
+    }
+    public class OperationContractGenerationContext {
+        public OperationContractGenerationContext(ServiceContractGenerator serviceContractGenerator, ServiceContractGenerationContext contract, OperationDescription operation, CodeTypeDeclaration declaringType, CodeMemberMethod method);
+        public OperationContractGenerationContext(ServiceContractGenerator serviceContractGenerator, ServiceContractGenerationContext contract, OperationDescription operation, CodeTypeDeclaration declaringType, CodeMemberMethod syncMethod, CodeMemberMethod taskMethod);
+        public OperationContractGenerationContext(ServiceContractGenerator serviceContractGenerator, ServiceContractGenerationContext contract, OperationDescription operation, CodeTypeDeclaration declaringType, CodeMemberMethod syncMethod, CodeMemberMethod beginMethod, CodeMemberMethod endMethod);
+        public OperationContractGenerationContext(ServiceContractGenerator serviceContractGenerator, ServiceContractGenerationContext contract, OperationDescription operation, CodeTypeDeclaration declaringType, CodeMemberMethod syncMethod, CodeMemberMethod beginMethod, CodeMemberMethod endMethod, CodeMemberMethod taskMethod);
+        public CodeMemberMethod BeginMethod { get; }
+        public ServiceContractGenerationContext Contract { get; }
+        public CodeTypeDeclaration DeclaringType { get; }
+        public CodeMemberMethod EndMethod { get; }
+        public bool IsAsync { get; }
+        public bool IsTask { get; }
+        public OperationDescription Operation { get; }
+        public ServiceContractGenerator ServiceContractGenerator { get; }
+        public CodeMemberMethod SyncMethod { get; }
+        public CodeMemberMethod TaskMethod { get; }
+    }
+    public class OperationDescription {
+        public OperationDescription(string name, ContractDescription declaringContract);
+        public MethodInfo BeginMethod { get; set; }
+        public KeyedByTypeCollection<IOperationBehavior> Behaviors { get; }
+        public ContractDescription DeclaringContract { get; set; }
+        public MethodInfo EndMethod { get; set; }
+        public FaultDescriptionCollection Faults { get; }
+        public bool HasProtectionLevel { get; }
+        public bool IsInitiating { get; set; }
+        public bool IsOneWay { get; }
+        public bool IsTerminating { get; set; }
+        public Collection<Type> KnownTypes { get; }
+        public MessageDescriptionCollection Messages { get; }
+        public string Name { get; }
+        public KeyedCollection<Type, IOperationBehavior> OperationBehaviors { get; }
+        public ProtectionLevel ProtectionLevel { get; set; }
+        public MethodInfo SyncMethod { get; set; }
+        public MethodInfo TaskMethod { get; set; }
+        public bool ShouldSerializeProtectionLevel();
+    }
+    public class OperationDescriptionCollection : Collection<OperationDescription> {
+        public OperationDescription Find(string name);
+        public Collection<OperationDescription> FindAll(string name);
+        protected override void InsertItem(int index, OperationDescription item);
+        protected override void SetItem(int index, OperationDescription item);
+    }
+    public static class ParameterXPathQueryGenerator {
+        public static string CreateFromDataContractSerializer(XName serviceContractName, string operationName, string parameterName, bool isReply, Type type, MemberInfo[] pathToMember, out XmlNamespaceManager namespaces);
+    }
+    public class PersistenceProviderBehavior : IServiceBehavior, IWmiInstanceProvider {
+        public PersistenceProviderBehavior(PersistenceProviderFactory providerFactory);
+        public PersistenceProviderBehavior(PersistenceProviderFactory providerFactory, TimeSpan persistenceOperationTimeout);
+        public TimeSpan PersistenceOperationTimeout { get; set; }
+        public PersistenceProviderFactory PersistenceProviderFactory { get; set; }
+        public virtual void AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection bindingParameters);
+        public virtual void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase);
+        public virtual void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase);
+    }
+    public class PolicyAssertionCollection : Collection<XmlElement> {
+        public PolicyAssertionCollection();
+        public PolicyAssertionCollection(IEnumerable<XmlElement> elements);
+        public bool Contains(string localName, string namespaceUri);
+        public XmlElement Find(string localName, string namespaceUri);
+        public Collection<XmlElement> FindAll(string localName, string namespaceUri);
+        protected override void InsertItem(int index, XmlElement item);
+        public XmlElement Remove(string localName, string namespaceUri);
+        public Collection<XmlElement> RemoveAll(string localName, string namespaceUri);
+        protected override void SetItem(int index, XmlElement item);
+    }
+    public abstract class PolicyConversionContext {
+        protected PolicyConversionContext(ServiceEndpoint endpoint);
+        public abstract BindingElementCollection BindingElements { get; }
+        public ContractDescription Contract { get; }
+        public abstract PolicyAssertionCollection GetBindingAssertions();
+        public abstract PolicyAssertionCollection GetFaultBindingAssertions(FaultDescription fault);
+        public abstract PolicyAssertionCollection GetMessageBindingAssertions(MessageDescription message);
+        public abstract PolicyAssertionCollection GetOperationBindingAssertions(OperationDescription operation);
+    }
+    public sealed class PolicyVersion {
+        public static PolicyVersion Default { get; }
+        public string Namespace { get; }
+        public static PolicyVersion Policy12 { get; }
+        public static PolicyVersion Policy15 { get; }
+        public override string ToString();
+    }
+    public enum PrincipalPermissionMode {
+        Always = 4,
+        Custom = 3,
+        None = 0,
+        UseAspNetRoles = 2,
+        UseWindowsGroups = 1,
+    }
+    public sealed class ServiceAuthenticationBehavior : IServiceBehavior {
+        public ServiceAuthenticationBehavior();
+        public AuthenticationSchemes AuthenticationSchemes { get; set; }
+        public ServiceAuthenticationManager ServiceAuthenticationManager { get; set; }
+        public bool ShouldSerializeAuthenticationSchemes();
+        public bool ShouldSerializeServiceAuthenticationManager();
+        void System.ServiceModel.Description.IServiceBehavior.AddBindingParameters(ServiceDescription description, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection parameters);
+        void System.ServiceModel.Description.IServiceBehavior.ApplyDispatchBehavior(ServiceDescription description, ServiceHostBase serviceHostBase);
+        void System.ServiceModel.Description.IServiceBehavior.Validate(ServiceDescription description, ServiceHostBase serviceHostBase);
+    }
+    public sealed class ServiceAuthorizationBehavior : IServiceBehavior {
+        public ServiceAuthorizationBehavior();
+        public ReadOnlyCollection<IAuthorizationPolicy> ExternalAuthorizationPolicies { get; set; }
+        public bool ImpersonateCallerForAllOperations { get; set; }
+        public bool ImpersonateOnSerializingReply { get; set; }
+        public PrincipalPermissionMode PrincipalPermissionMode { get; set; }
+        public RoleProvider RoleProvider { get; set; }
+        public ServiceAuthorizationManager ServiceAuthorizationManager { get; set; }
+        public bool ShouldSerializeExternalAuthorizationPolicies();
+        public bool ShouldSerializeServiceAuthorizationManager();
+        void System.ServiceModel.Description.IServiceBehavior.AddBindingParameters(ServiceDescription description, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection parameters);
+        void System.ServiceModel.Description.IServiceBehavior.ApplyDispatchBehavior(ServiceDescription description, ServiceHostBase serviceHostBase);
+        void System.ServiceModel.Description.IServiceBehavior.Validate(ServiceDescription description, ServiceHostBase serviceHostBase);
+    }
+    public class ServiceContractGenerationContext {
+        public ServiceContractGenerationContext(ServiceContractGenerator serviceContractGenerator, ContractDescription contract, CodeTypeDeclaration contractType);
+        public ServiceContractGenerationContext(ServiceContractGenerator serviceContractGenerator, ContractDescription contract, CodeTypeDeclaration contractType, CodeTypeDeclaration duplexCallbackType);
+        public ContractDescription Contract { get; }
+        public CodeTypeDeclaration ContractType { get; }
+        public CodeTypeDeclaration DuplexCallbackType { get; }
+        public Collection<OperationContractGenerationContext> Operations { get; }
+        public ServiceContractGenerator ServiceContractGenerator { get; }
+    }
+    public enum ServiceContractGenerationOptions {
+        AsynchronousMethods = 1,
+        ChannelInterface = 2,
+        ClientClass = 8,
+        EventBasedAsynchronousMethods = 32,
+        InternalTypes = 4,
+        None = 0,
+        TaskBasedAsynchronousMethod = 64,
+        TypedMessages = 16,
+    }
+    public class ServiceContractGenerator {
+        public ServiceContractGenerator();
+        public ServiceContractGenerator(CodeCompileUnit targetCompileUnit);
+        public ServiceContractGenerator(CodeCompileUnit targetCompileUnit, Configuration targetConfig);
+        public ServiceContractGenerator(Configuration targetConfig);
+        public Configuration Configuration { get; }
+        public Collection<MetadataConversionError> Errors { get; }
+        public Dictionary<string, string> NamespaceMappings { get; }
+        public ServiceContractGenerationOptions Options { get; set; }
+        public Dictionary<ContractDescription, Type> ReferencedTypes { get; }
+        public CodeCompileUnit TargetCompileUnit { get; }
+        public void GenerateBinding(Binding binding, out string bindingSectionName, out string configurationName);
+        public CodeTypeReference GenerateServiceContractType(ContractDescription contractDescription);
+        public CodeTypeReference GenerateServiceEndpoint(ServiceEndpoint endpoint, out ChannelEndpointElement channelElement);
+    }
+    public class ServiceCredentials : SecurityCredentialsManager, IServiceBehavior {
+        public ServiceCredentials();
+        protected ServiceCredentials(ServiceCredentials other);
+        public X509CertificateInitiatorServiceCredential ClientCertificate { get; }
+        public ExceptionMapper ExceptionMapper { get; set; }
+        public IdentityConfiguration IdentityConfiguration { get; set; }
+        public IssuedTokenServiceCredential IssuedTokenAuthentication { get; }
+        public PeerCredential Peer { get; }
+        public SecureConversationServiceCredential SecureConversationAuthentication { get; }
+        public X509CertificateRecipientServiceCredential ServiceCertificate { get; }
+        public bool UseIdentityConfiguration { get; set; }
+        public UserNamePasswordServiceCredential UserNameAuthentication { get; }
+        public WindowsServiceCredential WindowsAuthentication { get; }
+        public ServiceCredentials Clone();
+        protected virtual ServiceCredentials CloneCore();
+        public override SecurityTokenManager CreateSecurityTokenManager();
+        void System.ServiceModel.Description.IServiceBehavior.AddBindingParameters(ServiceDescription description, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection parameters);
+        void System.ServiceModel.Description.IServiceBehavior.ApplyDispatchBehavior(ServiceDescription description, ServiceHostBase serviceHostBase);
+        void System.ServiceModel.Description.IServiceBehavior.Validate(ServiceDescription description, ServiceHostBase serviceHostBase);
+    }
+    public class ServiceDebugBehavior : IServiceBehavior {
+        public ServiceDebugBehavior();
+        public Binding HttpHelpPageBinding { get; set; }
+        public bool HttpHelpPageEnabled { get; set; }
+        public Uri HttpHelpPageUrl { get; set; }
+        public Binding HttpsHelpPageBinding { get; set; }
+        public bool HttpsHelpPageEnabled { get; set; }
+        public Uri HttpsHelpPageUrl { get; set; }
+        public bool IncludeExceptionDetailInFaults { get; set; }
+        void System.ServiceModel.Description.IServiceBehavior.AddBindingParameters(ServiceDescription description, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection parameters);
+        void System.ServiceModel.Description.IServiceBehavior.ApplyDispatchBehavior(ServiceDescription description, ServiceHostBase serviceHostBase);
+        void System.ServiceModel.Description.IServiceBehavior.Validate(ServiceDescription description, ServiceHostBase serviceHostBase);
+    }
+    public class ServiceDescription {
+        public ServiceDescription();
+        public ServiceDescription(IEnumerable<ServiceEndpoint> endpoints);
+        public KeyedByTypeCollection<IServiceBehavior> Behaviors { get; }
+        public string ConfigurationName { get; set; }
+        public ServiceEndpointCollection Endpoints { get; }
+        public string Name { get; set; }
+        public string Namespace { get; set; }
+        public Type ServiceType { get; set; }
+        public static ServiceDescription GetService(object serviceImplementation);
+        public static ServiceDescription GetService(Type serviceType);
+    }
+    public class ServiceEndpoint {
+        public ServiceEndpoint(ContractDescription contract);
+        public ServiceEndpoint(ContractDescription contract, Binding binding, EndpointAddress address);
+        public EndpointAddress Address { get; set; }
+        public KeyedByTypeCollection<IEndpointBehavior> Behaviors { get; }
+        public Binding Binding { get; set; }
+        public ContractDescription Contract { get; set; }
+        public KeyedCollection<Type, IEndpointBehavior> EndpointBehaviors { get; }
+        public bool IsSystemEndpoint { get; set; }
+        public Uri ListenUri { get; set; }
+        public ListenUriMode ListenUriMode { get; set; }
+        public string Name { get; set; }
+    }
+    public class ServiceEndpointCollection : Collection<ServiceEndpoint> {
+        public ServiceEndpoint Find(Type contractType);
+        public ServiceEndpoint Find(Type contractType, XmlQualifiedName bindingName);
+        public ServiceEndpoint Find(Uri address);
+        public ServiceEndpoint Find(XmlQualifiedName contractName);
+        public ServiceEndpoint Find(XmlQualifiedName contractName, XmlQualifiedName bindingName);
+        public Collection<ServiceEndpoint> FindAll(Type contractType);
+        public Collection<ServiceEndpoint> FindAll(XmlQualifiedName contractName);
+        protected override void InsertItem(int index, ServiceEndpoint item);
+        protected override void SetItem(int index, ServiceEndpoint item);
+    }
+    public class ServiceMetadataBehavior : IServiceBehavior {
+        public const string MexContractName = "IMetadataExchange";
+        public ServiceMetadataBehavior();
+        public Uri ExternalMetadataLocation { get; set; }
+        public Binding HttpGetBinding { get; set; }
+        public bool HttpGetEnabled { get; set; }
+        public Uri HttpGetUrl { get; set; }
+        public Binding HttpsGetBinding { get; set; }
+        public bool HttpsGetEnabled { get; set; }
+        public Uri HttpsGetUrl { get; set; }
+        public MetadataExporter MetadataExporter { get; set; }
+        void System.ServiceModel.Description.IServiceBehavior.AddBindingParameters(ServiceDescription description, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection parameters);
+        void System.ServiceModel.Description.IServiceBehavior.ApplyDispatchBehavior(ServiceDescription description, ServiceHostBase serviceHostBase);
+        void System.ServiceModel.Description.IServiceBehavior.Validate(ServiceDescription description, ServiceHostBase serviceHostBase);
+    }
+    public sealed class ServiceMetadataContractBehavior : IContractBehavior {
+        public ServiceMetadataContractBehavior();
+        public ServiceMetadataContractBehavior(bool metadataGenerationDisabled);
+        public bool MetadataGenerationDisabled { get; set; }
+        void System.ServiceModel.Description.IContractBehavior.AddBindingParameters(ContractDescription description, ServiceEndpoint endpoint, BindingParameterCollection parameters);
+        void System.ServiceModel.Description.IContractBehavior.ApplyClientBehavior(ContractDescription description, ServiceEndpoint endpoint, ClientRuntime proxy);
+        void System.ServiceModel.Description.IContractBehavior.ApplyDispatchBehavior(ContractDescription description, ServiceEndpoint endpoint, DispatchRuntime dispatch);
+        void System.ServiceModel.Description.IContractBehavior.Validate(ContractDescription description, ServiceEndpoint endpoint);
+    }
+    public class ServiceMetadataEndpoint : ServiceEndpoint {
+        public ServiceMetadataEndpoint();
+        public ServiceMetadataEndpoint(Binding binding, EndpointAddress address);
+        public ServiceMetadataEndpoint(EndpointAddress address);
+    }
+    public class ServiceMetadataExtension : IExtension<ServiceHostBase> {
+        public ServiceMetadataExtension();
+        public MetadataSet Metadata { get; }
+        public ServiceDescription SingleWsdl { get; }
+        void System.ServiceModel.IExtension<System.ServiceModel.ServiceHostBase>.Attach(ServiceHostBase owner);
+        void System.ServiceModel.IExtension<System.ServiceModel.ServiceHostBase>.Detach(ServiceHostBase owner);
+    }
+    public sealed class ServiceSecurityAuditBehavior : IServiceBehavior {
+        public ServiceSecurityAuditBehavior();
+        public AuditLogLocation AuditLogLocation { get; set; }
+        public AuditLevel MessageAuthenticationAuditLevel { get; set; }
+        public AuditLevel ServiceAuthorizationAuditLevel { get; set; }
+        public bool SuppressAuditFailure { get; set; }
+        void System.ServiceModel.Description.IServiceBehavior.AddBindingParameters(ServiceDescription description, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection parameters);
+        void System.ServiceModel.Description.IServiceBehavior.ApplyDispatchBehavior(ServiceDescription description, ServiceHostBase serviceHostBase);
+        void System.ServiceModel.Description.IServiceBehavior.Validate(ServiceDescription description, ServiceHostBase serviceHostBase);
+    }
+    public class ServiceThrottlingBehavior : IServiceBehavior {
+        public ServiceThrottlingBehavior();
+        public int MaxConcurrentCalls { get; set; }
+        public int MaxConcurrentInstances { get; set; }
+        public int MaxConcurrentSessions { get; set; }
+        void System.ServiceModel.Description.IServiceBehavior.AddBindingParameters(ServiceDescription description, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection parameters);
+        void System.ServiceModel.Description.IServiceBehavior.ApplyDispatchBehavior(ServiceDescription description, ServiceHostBase serviceHostBase);
+        void System.ServiceModel.Description.IServiceBehavior.Validate(ServiceDescription description, ServiceHostBase serviceHostBase);
+    }
+    public class SynchronousReceiveBehavior : IEndpointBehavior {
+        public SynchronousReceiveBehavior();
+        void System.ServiceModel.Description.IEndpointBehavior.AddBindingParameters(ServiceEndpoint serviceEndpoint, BindingParameterCollection parameters);
+        void System.ServiceModel.Description.IEndpointBehavior.ApplyClientBehavior(ServiceEndpoint serviceEndpoint, ClientRuntime behavior);
+        void System.ServiceModel.Description.IEndpointBehavior.ApplyDispatchBehavior(ServiceEndpoint serviceEndpoint, EndpointDispatcher endpointDispatcher);
+        void System.ServiceModel.Description.IEndpointBehavior.Validate(ServiceEndpoint serviceEndpoint);
+    }
+    public class TransactedBatchingBehavior : IEndpointBehavior {
+        public TransactedBatchingBehavior(int maxBatchSize);
+        public int MaxBatchSize { get; set; }
+        void System.ServiceModel.Description.IEndpointBehavior.AddBindingParameters(ServiceEndpoint serviceEndpoint, BindingParameterCollection bindingParameters);
+        void System.ServiceModel.Description.IEndpointBehavior.ApplyClientBehavior(ServiceEndpoint serviceEndpoint, ClientRuntime behavior);
+        void System.ServiceModel.Description.IEndpointBehavior.ApplyDispatchBehavior(ServiceEndpoint serviceEndpoint, EndpointDispatcher endpointDispatcher);
+        void System.ServiceModel.Description.IEndpointBehavior.Validate(ServiceEndpoint serviceEndpoint);
+    }
+    public abstract class TypedMessageConverter {
+        protected TypedMessageConverter();
+        public static TypedMessageConverter Create(Type messageContract, string action);
+        public static TypedMessageConverter Create(Type messageContract, string action, DataContractFormatAttribute formatterAttribute);
+        public static TypedMessageConverter Create(Type messageContract, string action, XmlSerializerFormatAttribute formatterAttribute);
+        public static TypedMessageConverter Create(Type messageContract, string action, string defaultNamespace);
+        public static TypedMessageConverter Create(Type messageContract, string action, string defaultNamespace, DataContractFormatAttribute formatterAttribute);
+        public static TypedMessageConverter Create(Type messageContract, string action, string defaultNamespace, XmlSerializerFormatAttribute formatterAttribute);
+        public abstract object FromMessage(Message message);
+        public abstract Message ToMessage(object typedMessage);
+        public abstract Message ToMessage(object typedMessage, MessageVersion version);
+    }
+    public enum UnknownExceptionAction {
+        AbortInstance = 1,
+        TerminateInstance = 0,
+    }
+    public class UseRequestHeadersForMetadataAddressBehavior : IServiceBehavior {
+        public UseRequestHeadersForMetadataAddressBehavior();
+        public IDictionary<string, int> DefaultPortsByScheme { get; }
+        void System.ServiceModel.Description.IServiceBehavior.AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection bindingParameters);
+        void System.ServiceModel.Description.IServiceBehavior.ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase);
+        void System.ServiceModel.Description.IServiceBehavior.Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase);
+    }
+    public class WebHttpBehavior : IEndpointBehavior, IWmiInstanceProvider {
+        public WebHttpBehavior();
+        public virtual bool AutomaticFormatSelectionEnabled { get; set; }
+        public virtual WebMessageBodyStyle DefaultBodyStyle { get; set; }
+        public virtual WebMessageFormat DefaultOutgoingRequestFormat { get; set; }
+        public virtual WebMessageFormat DefaultOutgoingResponseFormat { get; set; }
+        public virtual bool FaultExceptionEnabled { get; set; }
+        public virtual bool HelpEnabled { get; set; }
+        protected internal string JavascriptCallbackParameterName { get; set; }
+        public virtual void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters);
+        protected virtual void AddClientErrorInspector(ServiceEndpoint endpoint, ClientRuntime clientRuntime);
+        protected virtual void AddServerErrorHandlers(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher);
+        public virtual void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime);
+        public virtual void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher);
+        protected virtual WebHttpDispatchOperationSelector GetOperationSelector(ServiceEndpoint endpoint);
+        protected virtual QueryStringConverter GetQueryStringConverter(OperationDescription operationDescription);
+        protected virtual IClientMessageFormatter GetReplyClientFormatter(OperationDescription operationDescription, ServiceEndpoint endpoint);
+        protected virtual IDispatchMessageFormatter GetReplyDispatchFormatter(OperationDescription operationDescription, ServiceEndpoint endpoint);
+        protected virtual IClientMessageFormatter GetRequestClientFormatter(OperationDescription operationDescription, ServiceEndpoint endpoint);
+        protected virtual IDispatchMessageFormatter GetRequestDispatchFormatter(OperationDescription operationDescription, ServiceEndpoint endpoint);
+        public virtual void Validate(ServiceEndpoint endpoint);
+        protected virtual void ValidateBinding(ServiceEndpoint endpoint);
+    }
+    public class WebHttpEndpoint : WebServiceEndpoint {
+        public WebHttpEndpoint(ContractDescription contract);
+        public WebHttpEndpoint(ContractDescription contract, EndpointAddress address);
+        public bool AutomaticFormatSelectionEnabled { get; set; }
+        public WebMessageFormat DefaultOutgoingResponseFormat { get; set; }
+        public bool FaultExceptionEnabled { get; set; }
+        public bool HelpEnabled { get; set; }
+        protected override Type WebEndpointType { get; }
+    }
+    public sealed class WebScriptEnablingBehavior : WebHttpBehavior {
+        public WebScriptEnablingBehavior();
+        public override bool AutomaticFormatSelectionEnabled { get; set; }
+        public override WebMessageBodyStyle DefaultBodyStyle { get; set; }
+        public override WebMessageFormat DefaultOutgoingRequestFormat { get; set; }
+        public override WebMessageFormat DefaultOutgoingResponseFormat { get; set; }
+        public override bool FaultExceptionEnabled { get; set; }
+        public override bool HelpEnabled { get; set; }
+        protected override void AddClientErrorInspector(ServiceEndpoint endpoint, ClientRuntime clientRuntime);
+        protected override void AddServerErrorHandlers(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher);
+        public override void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime);
+        public override void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher);
+        protected override QueryStringConverter GetQueryStringConverter(OperationDescription operationDescription);
+        public override void Validate(ServiceEndpoint endpoint);
+    }
+    public class WebScriptEndpoint : WebServiceEndpoint {
+        public WebScriptEndpoint(ContractDescription contract);
+        public WebScriptEndpoint(ContractDescription contract, EndpointAddress address);
+        protected override Type WebEndpointType { get; }
+    }
+    public abstract class WebServiceEndpoint : ServiceEndpoint {
+        public WebContentTypeMapper ContentTypeMapper { get; set; }
+        public bool CrossDomainScriptAccessEnabled { get; set; }
+        public HostNameComparisonMode HostNameComparisonMode { get; set; }
+        public long MaxBufferPoolSize { get; set; }
+        public int MaxBufferSize { get; set; }
+        public long MaxReceivedMessageSize { get; set; }
+        public XmlDictionaryReaderQuotas ReaderQuotas { get; set; }
+        public WebHttpSecurity Security { get; }
+        public TransferMode TransferMode { get; set; }
+        protected abstract Type WebEndpointType { get; }
+        public Encoding WriteEncoding { get; set; }
+    }
+    public class WorkflowRuntimeBehavior : IServiceBehavior, IWmiInstanceProvider {
+        public WorkflowRuntimeBehavior();
+        public TimeSpan CachedInstanceExpiration { get; set; }
+        public WorkflowRuntime WorkflowRuntime { get; }
+        public void AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection bindingParameters);
+        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase);
+        public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase);
+    }
+    public class WsdlContractConversionContext {
+        public ContractDescription Contract { get; }
+        public PortType WsdlPortType { get; }
+        public FaultDescription GetFaultDescription(OperationFault operationFault);
+        public MessageDescription GetMessageDescription(OperationMessage operationMessage);
+        public Operation GetOperation(OperationDescription operation);
+        public OperationDescription GetOperationDescription(Operation operation);
+        public OperationFault GetOperationFault(FaultDescription fault);
+        public OperationMessage GetOperationMessage(MessageDescription message);
+    }
+    public class WsdlEndpointConversionContext {
+        public WsdlContractConversionContext ContractConversionContext { get; }
+        public ServiceEndpoint Endpoint { get; }
+        public Binding WsdlBinding { get; }
+        public Port WsdlPort { get; }
+        public FaultBinding GetFaultBinding(FaultDescription fault);
+        public FaultDescription GetFaultDescription(FaultBinding faultBinding);
+        public MessageBinding GetMessageBinding(MessageDescription message);
+        public MessageDescription GetMessageDescription(MessageBinding messageBinding);
+        public OperationBinding GetOperationBinding(OperationDescription operation);
+        public OperationDescription GetOperationDescription(OperationBinding operationBinding);
+    }
+    public class WsdlExporter : MetadataExporter {
+        public WsdlExporter();
+        public ServiceDescriptionCollection GeneratedWsdlDocuments { get; }
+        public XmlSchemaSet GeneratedXmlSchemas { get; }
+        public override void ExportContract(ContractDescription contract);
+        public override void ExportEndpoint(ServiceEndpoint endpoint);
+        public void ExportEndpoints(IEnumerable<ServiceEndpoint> endpoints, XmlQualifiedName wsdlServiceQName);
+        public override MetadataSet GetGeneratedMetadata();
+    }
+    public class WsdlImporter : MetadataImporter {
+        public WsdlImporter(MetadataSet metadata);
+        public WsdlImporter(MetadataSet metadata, IEnumerable<IPolicyImportExtension> policyImportExtensions, IEnumerable<IWsdlImportExtension> wsdlImportExtensions);
+        public WsdlImporter(MetadataSet metadata, IEnumerable<IPolicyImportExtension> policyImportExtensions, IEnumerable<IWsdlImportExtension> wsdlImportExtensions, MetadataImporterQuotas quotas);
+        public ServiceDescriptionCollection WsdlDocuments { get; }
+        public KeyedByTypeCollection<IWsdlImportExtension> WsdlImportExtensions { get; }
+        public XmlSchemaSet XmlSchemas { get; }
+        public Collection<Binding> ImportAllBindings();
+        public override Collection<ContractDescription> ImportAllContracts();
+        public override ServiceEndpointCollection ImportAllEndpoints();
+        public Binding ImportBinding(Binding wsdlBinding);
+        public ContractDescription ImportContract(PortType wsdlPortType);
+        public ServiceEndpoint ImportEndpoint(Port wsdlPort);
+        public ServiceEndpointCollection ImportEndpoints(Binding wsdlBinding);
+        public ServiceEndpointCollection ImportEndpoints(PortType wsdlPortType);
+        public ServiceEndpointCollection ImportEndpoints(Service wsdlService);
+    }
+    public class XmlSerializerMessageContractImporter : IWsdlImportExtension {
+        public XmlSerializerMessageContractImporter();
+        void System.ServiceModel.Description.IWsdlImportExtension.BeforeImport(ServiceDescriptionCollection wsdlDocuments, XmlSchemaSet xmlSchemas, ICollection<XmlElement> policy);
+        void System.ServiceModel.Description.IWsdlImportExtension.ImportContract(WsdlImporter importer, WsdlContractConversionContext contractContext);
+        void System.ServiceModel.Description.IWsdlImportExtension.ImportEndpoint(WsdlImporter importer, WsdlEndpointConversionContext endpointContext);
+    }
+    public class XmlSerializerOperationBehavior : IOperationBehavior, IWsdlExportExtension {
+        public XmlSerializerOperationBehavior(OperationDescription operation);
+        public XmlSerializerOperationBehavior(OperationDescription operation, XmlSerializerFormatAttribute attribute);
+        public XmlSerializerFormatAttribute XmlSerializerFormatAttribute { get; }
+        public Collection<XmlMapping> GetXmlMappings();
+        void System.ServiceModel.Description.IOperationBehavior.AddBindingParameters(OperationDescription description, BindingParameterCollection parameters);
+        void System.ServiceModel.Description.IOperationBehavior.ApplyClientBehavior(OperationDescription description, ClientOperation proxy);
+        void System.ServiceModel.Description.IOperationBehavior.ApplyDispatchBehavior(OperationDescription description, DispatchOperation dispatch);
+        void System.ServiceModel.Description.IOperationBehavior.Validate(OperationDescription description);
+        void System.ServiceModel.Description.IWsdlExportExtension.ExportContract(WsdlExporter exporter, WsdlContractConversionContext contractContext);
+        void System.ServiceModel.Description.IWsdlExportExtension.ExportEndpoint(WsdlExporter exporter, WsdlEndpointConversionContext endpointContext);
+    }
+}
```

