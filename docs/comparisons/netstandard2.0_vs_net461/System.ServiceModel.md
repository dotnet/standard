# System.ServiceModel

``` diff
+namespace System.ServiceModel {
+    public class ActionNotSupportedException : CommunicationException {
+        public ActionNotSupportedException();
+        protected ActionNotSupportedException(SerializationInfo info, StreamingContext context);
+        public ActionNotSupportedException(string message);
+        public ActionNotSupportedException(string message, Exception innerException);
+    }
+    public class AddressAccessDeniedException : CommunicationException {
+        public AddressAccessDeniedException();
+        protected AddressAccessDeniedException(SerializationInfo info, StreamingContext context);
+        public AddressAccessDeniedException(string message);
+        public AddressAccessDeniedException(string message, Exception innerException);
+    }
+    public class AddressAlreadyInUseException : CommunicationException {
+        public AddressAlreadyInUseException();
+        protected AddressAlreadyInUseException(SerializationInfo info, StreamingContext context);
+        public AddressAlreadyInUseException(string message);
+        public AddressAlreadyInUseException(string message, Exception innerException);
+    }
+    public enum AddressFilterMode {
+        Any = 2,
+        Exact = 0,
+        Prefix = 1,
+    }
+    public enum AuditLevel {
+        Failure = 2,
+        None = 0,
+        Success = 1,
+        SuccessOrFailure = 3,
+    }
+    public enum AuditLogLocation {
+        Application = 1,
+        Default = 0,
+        Security = 2,
+    }
+    public class BasicHttpBinding : HttpBindingBase {
+        public BasicHttpBinding();
+        public BasicHttpBinding(BasicHttpSecurityMode securityMode);
+        public BasicHttpBinding(string configurationName);
+        public bool EnableHttpCookieContainer { get; set; }
+        public WSMessageEncoding MessageEncoding { get; set; }
+        public BasicHttpSecurity Security { get; set; }
+        public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingParameterCollection parameters);
+        public override BindingElementCollection CreateBindingElements();
+        public bool ShouldSerializeEnableHttpCookieContainer();
+        public bool ShouldSerializeSecurity();
+    }
+    public class BasicHttpContextBinding : BasicHttpBinding {
+        public BasicHttpContextBinding();
+        public BasicHttpContextBinding(BasicHttpSecurityMode securityMode);
+        public BasicHttpContextBinding(string configName);
+        public bool ContextManagementEnabled { get; set; }
+        public override BindingElementCollection CreateBindingElements();
+    }
+    public enum BasicHttpMessageCredentialType {
+        Certificate = 1,
+        UserName = 0,
+    }
+    public sealed class BasicHttpMessageSecurity {
+        public BasicHttpMessageSecurity();
+        public SecurityAlgorithmSuite AlgorithmSuite { get; set; }
+        public BasicHttpMessageCredentialType ClientCredentialType { get; set; }
+        public bool ShouldSerializeAlgorithmSuite();
+        public bool ShouldSerializeClientCredentialType();
+    }
+    public class BasicHttpsBinding : HttpBindingBase {
+        public BasicHttpsBinding();
+        public BasicHttpsBinding(BasicHttpsSecurityMode securityMode);
+        public BasicHttpsBinding(string configurationName);
+        public WSMessageEncoding MessageEncoding { get; set; }
+        public BasicHttpsSecurity Security { get; set; }
+        public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingParameterCollection parameters);
+        public override BindingElementCollection CreateBindingElements();
+        public bool ShouldSerializeSecurity();
+    }
+    public sealed class BasicHttpSecurity {
+        public BasicHttpSecurity();
+        public BasicHttpMessageSecurity Message { get; set; }
+        public BasicHttpSecurityMode Mode { get; set; }
+        public HttpTransportSecurity Transport { get; set; }
+        public bool ShouldSerializeMessage();
+        public bool ShouldSerializeTransport();
+    }
+    public enum BasicHttpSecurityMode {
+        Message = 2,
+        None = 0,
+        Transport = 1,
+        TransportCredentialOnly = 4,
+        TransportWithMessageCredential = 3,
+    }
+    public sealed class BasicHttpsSecurity {
+        public BasicHttpsSecurity();
+        public BasicHttpMessageSecurity Message { get; set; }
+        public BasicHttpsSecurityMode Mode { get; set; }
+        public HttpTransportSecurity Transport { get; set; }
+        public bool ShouldSerializeMessage();
+        public bool ShouldSerializeTransport();
+    }
+    public enum BasicHttpsSecurityMode {
+        Transport = 0,
+        TransportWithMessageCredential = 1,
+    }
+    public enum CacheSetting {
+        AlwaysOff = 2,
+        AlwaysOn = 1,
+        Default = 0,
+    }
+    public sealed class CallbackBehaviorAttribute : Attribute, IEndpointBehavior {
+        public CallbackBehaviorAttribute();
+        public bool AutomaticSessionShutdown { get; set; }
+        public ConcurrencyMode ConcurrencyMode { get; set; }
+        public bool IgnoreExtensionDataObject { get; set; }
+        public bool IncludeExceptionDetailInFaults { get; set; }
+        public int MaxItemsInObjectGraph { get; set; }
+        public IsolationLevel TransactionIsolationLevel { get; set; }
+        public string TransactionTimeout { get; set; }
+        public bool UseSynchronizationContext { get; set; }
+        public bool ValidateMustUnderstand { get; set; }
+        void System.ServiceModel.Description.IEndpointBehavior.AddBindingParameters(ServiceEndpoint serviceEndpoint, BindingParameterCollection parameters);
+        void System.ServiceModel.Description.IEndpointBehavior.ApplyClientBehavior(ServiceEndpoint serviceEndpoint, ClientRuntime clientRuntime);
+        void System.ServiceModel.Description.IEndpointBehavior.ApplyDispatchBehavior(ServiceEndpoint serviceEndpoint, EndpointDispatcher endpointDispatcher);
+        void System.ServiceModel.Description.IEndpointBehavior.Validate(ServiceEndpoint serviceEndpoint);
+    }
+    public abstract class ChannelFactory : CommunicationObject, IChannelFactory, ICommunicationObject, IDisposable {
+        protected ChannelFactory();
+        public ClientCredentials Credentials { get; }
+        protected override TimeSpan DefaultCloseTimeout { get; }
+        protected override TimeSpan DefaultOpenTimeout { get; }
+        public ServiceEndpoint Endpoint { get; }
+        protected virtual void ApplyConfiguration(string configurationName);
+        protected abstract ServiceEndpoint CreateDescription();
+        protected virtual IChannelFactory CreateFactory();
+        protected internal void EnsureOpened();
+        public T GetProperty<T>() where T : class;
+        protected void InitializeEndpoint(Binding binding, EndpointAddress address);
+        protected void InitializeEndpoint(ServiceEndpoint endpoint);
+        protected void InitializeEndpoint(string configurationName, EndpointAddress address);
+        protected override void OnAbort();
+        protected override IAsyncResult OnBeginClose(TimeSpan timeout, AsyncCallback callback, object state);
+        protected override IAsyncResult OnBeginOpen(TimeSpan timeout, AsyncCallback callback, object state);
+        protected override void OnClose(TimeSpan timeout);
+        protected override void OnEndClose(IAsyncResult result);
+        protected override void OnEndOpen(IAsyncResult result);
+        protected override void OnOpen(TimeSpan timeout);
+        protected override void OnOpened();
+        protected override void OnOpening();
+        void System.IDisposable.Dispose();
+    }
+    public class ChannelFactory<TChannel> : ChannelFactory, IChannelFactory, IChannelFactory<TChannel>, ICommunicationObject {
+        public ChannelFactory();
+        public ChannelFactory(Binding binding);
+        public ChannelFactory(Binding binding, EndpointAddress remoteAddress);
+        public ChannelFactory(Binding binding, string remoteAddress);
+        public ChannelFactory(ServiceEndpoint endpoint);
+        public ChannelFactory(string endpointConfigurationName);
+        public ChannelFactory(string endpointConfigurationName, EndpointAddress remoteAddress);
+        protected ChannelFactory(Type channelType);
+        public TChannel CreateChannel();
+        public static TChannel CreateChannel(Binding binding, EndpointAddress endpointAddress);
+        public static TChannel CreateChannel(Binding binding, EndpointAddress endpointAddress, Uri via);
+        public TChannel CreateChannel(EndpointAddress address);
+        public virtual TChannel CreateChannel(EndpointAddress address, Uri via);
+        protected static TChannel CreateChannel(string endpointConfigurationName);
+        public TChannel CreateChannelWithActAsToken(SecurityToken actAsToken);
+        public TChannel CreateChannelWithActAsToken(SecurityToken actAsToken, EndpointAddress address);
+        public TChannel CreateChannelWithActAsToken(SecurityToken actAsToken, EndpointAddress address, Uri via);
+        public TChannel CreateChannelWithIssuedToken(SecurityToken issuedToken);
+        public TChannel CreateChannelWithIssuedToken(SecurityToken issuedToken, EndpointAddress address);
+        public TChannel CreateChannelWithIssuedToken(SecurityToken issuedToken, EndpointAddress address, Uri via);
+        public TChannel CreateChannelWithOnBehalfOfToken(SecurityToken onBehalfOf);
+        public TChannel CreateChannelWithOnBehalfOfToken(SecurityToken onBehalfOf, EndpointAddress address);
+        public TChannel CreateChannelWithOnBehalfOfToken(SecurityToken onBehalfOf, EndpointAddress address, Uri via);
+        protected override ServiceEndpoint CreateDescription();
+    }
+    public class ChannelTerminatedException : CommunicationException {
+        public ChannelTerminatedException();
+        protected ChannelTerminatedException(SerializationInfo info, StreamingContext context);
+        public ChannelTerminatedException(string message);
+        public ChannelTerminatedException(string message, Exception innerException);
+    }
+    public abstract class ClientBase<TChannel> : ICommunicationObject, IDisposable where TChannel : class {
+        protected ClientBase();
+        protected ClientBase(Binding binding, EndpointAddress remoteAddress);
+        protected ClientBase(ServiceEndpoint endpoint);
+        protected ClientBase(InstanceContext callbackInstance);
+        protected ClientBase(InstanceContext callbackInstance, Binding binding, EndpointAddress remoteAddress);
+        protected ClientBase(InstanceContext callbackInstance, ServiceEndpoint endpoint);
+        protected ClientBase(InstanceContext callbackInstance, string endpointConfigurationName);
+        protected ClientBase(InstanceContext callbackInstance, string endpointConfigurationName, EndpointAddress remoteAddress);
+        protected ClientBase(InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress);
+        protected ClientBase(string endpointConfigurationName);
+        protected ClientBase(string endpointConfigurationName, EndpointAddress remoteAddress);
+        protected ClientBase(string endpointConfigurationName, string remoteAddress);
+        public static CacheSetting CacheSetting { get; set; }
+        protected TChannel Channel { get; }
+        public ChannelFactory<TChannel> ChannelFactory { get; }
+        public ClientCredentials ClientCredentials { get; }
+        public ServiceEndpoint Endpoint { get; }
+        public IClientChannel InnerChannel { get; }
+        public CommunicationState State { get; }
+        event EventHandler System.ServiceModel.ICommunicationObject.Closed;
+        event EventHandler System.ServiceModel.ICommunicationObject.Closing;
+        event EventHandler System.ServiceModel.ICommunicationObject.Faulted;
+        event EventHandler System.ServiceModel.ICommunicationObject.Opened;
+        event EventHandler System.ServiceModel.ICommunicationObject.Opening;
+        public void Abort();
+        public void Close();
+        protected virtual TChannel CreateChannel();
+        public void DisplayInitializationUI();
+        protected T GetDefaultValueForInitialization<T>();
+        protected void InvokeAsync(ClientBase<TChannel>.BeginOperationDelegate beginOperationDelegate, object[] inValues, ClientBase<TChannel>.EndOperationDelegate endOperationDelegate, SendOrPostCallback operationCompletedCallback, object userState);
+        public void Open();
+        void System.IDisposable.Dispose();
+        IAsyncResult System.ServiceModel.ICommunicationObject.BeginClose(AsyncCallback callback, object state);
+        IAsyncResult System.ServiceModel.ICommunicationObject.BeginClose(TimeSpan timeout, AsyncCallback callback, object state);
+        IAsyncResult System.ServiceModel.ICommunicationObject.BeginOpen(AsyncCallback callback, object state);
+        IAsyncResult System.ServiceModel.ICommunicationObject.BeginOpen(TimeSpan timeout, AsyncCallback callback, object state);
+        void System.ServiceModel.ICommunicationObject.Close(TimeSpan timeout);
+        void System.ServiceModel.ICommunicationObject.EndClose(IAsyncResult result);
+        void System.ServiceModel.ICommunicationObject.EndOpen(IAsyncResult result);
+        void System.ServiceModel.ICommunicationObject.Open(TimeSpan timeout);
+        protected delegate IAsyncResult BeginOperationDelegate(object[] inValues, AsyncCallback asyncCallback, object state);
+        protected class ChannelBase<T> : IChannel, IChannelBaseProxy, IClientChannel, ICommunicationObject, IContextChannel, IDisposable, IExtensibleObject<IContextChannel>, IOutputChannel, IRequestChannel where T : class {
+            protected ChannelBase(ClientBase<T> client);
+            EndpointAddress System.ServiceModel.Channels.IOutputChannel.RemoteAddress { get; }
+            Uri System.ServiceModel.Channels.IOutputChannel.Via { get; }
+            EndpointAddress System.ServiceModel.Channels.IRequestChannel.RemoteAddress { get; }
+            Uri System.ServiceModel.Channels.IRequestChannel.Via { get; }
+            bool System.ServiceModel.IClientChannel.AllowInitializationUI { get; set; }
+            bool System.ServiceModel.IClientChannel.DidInteractiveInitialization { get; }
+            Uri System.ServiceModel.IClientChannel.Via { get; }
+            CommunicationState System.ServiceModel.ICommunicationObject.State { get; }
+            bool System.ServiceModel.IContextChannel.AllowOutputBatching { get; set; }
+            IInputSession System.ServiceModel.IContextChannel.InputSession { get; }
+            EndpointAddress System.ServiceModel.IContextChannel.LocalAddress { get; }
+            TimeSpan System.ServiceModel.IContextChannel.OperationTimeout { get; set; }
+            IOutputSession System.ServiceModel.IContextChannel.OutputSession { get; }
+            EndpointAddress System.ServiceModel.IContextChannel.RemoteAddress { get; }
+            string System.ServiceModel.IContextChannel.SessionId { get; }
+            IExtensionCollection<IContextChannel> System.ServiceModel.IExtensibleObject<System.ServiceModel.IContextChannel>.Extensions { get; }
+            event EventHandler<UnknownMessageReceivedEventArgs> System.ServiceModel.IClientChannel.UnknownMessageReceived;
+            event EventHandler System.ServiceModel.ICommunicationObject.Closed;
+            event EventHandler System.ServiceModel.ICommunicationObject.Closing;
+            event EventHandler System.ServiceModel.ICommunicationObject.Faulted;
+            event EventHandler System.ServiceModel.ICommunicationObject.Opened;
+            event EventHandler System.ServiceModel.ICommunicationObject.Opening;
+            protected IAsyncResult BeginInvoke(string methodName, object[] args, AsyncCallback callback, object state);
+            protected object EndInvoke(string methodName, object[] args, IAsyncResult result);
+            void System.IDisposable.Dispose();
+            TProperty System.ServiceModel.Channels.IChannel.GetProperty<TProperty>();
+            IAsyncResult System.ServiceModel.Channels.IOutputChannel.BeginSend(Message message, AsyncCallback callback, object state);
+            IAsyncResult System.ServiceModel.Channels.IOutputChannel.BeginSend(Message message, TimeSpan timeout, AsyncCallback callback, object state);
+            void System.ServiceModel.Channels.IOutputChannel.EndSend(IAsyncResult result);
+            void System.ServiceModel.Channels.IOutputChannel.Send(Message message);
+            void System.ServiceModel.Channels.IOutputChannel.Send(Message message, TimeSpan timeout);
+            IAsyncResult System.ServiceModel.Channels.IRequestChannel.BeginRequest(Message message, AsyncCallback callback, object state);
+            IAsyncResult System.ServiceModel.Channels.IRequestChannel.BeginRequest(Message message, TimeSpan timeout, AsyncCallback callback, object state);
+            Message System.ServiceModel.Channels.IRequestChannel.EndRequest(IAsyncResult result);
+            Message System.ServiceModel.Channels.IRequestChannel.Request(Message message);
+            Message System.ServiceModel.Channels.IRequestChannel.Request(Message message, TimeSpan timeout);
+            IAsyncResult System.ServiceModel.IClientChannel.BeginDisplayInitializationUI(AsyncCallback callback, object state);
+            void System.ServiceModel.IClientChannel.DisplayInitializationUI();
+            void System.ServiceModel.IClientChannel.EndDisplayInitializationUI(IAsyncResult result);
+            void System.ServiceModel.ICommunicationObject.Abort();
+            IAsyncResult System.ServiceModel.ICommunicationObject.BeginClose(AsyncCallback callback, object state);
+            IAsyncResult System.ServiceModel.ICommunicationObject.BeginClose(TimeSpan timeout, AsyncCallback callback, object state);
+            IAsyncResult System.ServiceModel.ICommunicationObject.BeginOpen(AsyncCallback callback, object state);
+            IAsyncResult System.ServiceModel.ICommunicationObject.BeginOpen(TimeSpan timeout, AsyncCallback callback, object state);
+            void System.ServiceModel.ICommunicationObject.Close();
+            void System.ServiceModel.ICommunicationObject.Close(TimeSpan timeout);
+            void System.ServiceModel.ICommunicationObject.EndClose(IAsyncResult result);
+            void System.ServiceModel.ICommunicationObject.EndOpen(IAsyncResult result);
+            void System.ServiceModel.ICommunicationObject.Open();
+            void System.ServiceModel.ICommunicationObject.Open(TimeSpan timeout);
+        }
+        protected delegate object[] EndOperationDelegate(IAsyncResult result);
+        protected class InvokeAsyncCompletedEventArgs : AsyncCompletedEventArgs {
+            public object[] Results { get; }
+        }
+    }
+    public class ClientCredentialsSecurityTokenManager : SecurityTokenManager {
+        public ClientCredentialsSecurityTokenManager(ClientCredentials clientCredentials);
+        public ClientCredentials ClientCredentials { get; }
+        public override SecurityTokenAuthenticator CreateSecurityTokenAuthenticator(SecurityTokenRequirement tokenRequirement, out SecurityTokenResolver outOfBandTokenResolver);
+        public override SecurityTokenProvider CreateSecurityTokenProvider(SecurityTokenRequirement tokenRequirement);
+        public override SecurityTokenSerializer CreateSecurityTokenSerializer(SecurityTokenVersion version);
+        protected SecurityTokenSerializer CreateSecurityTokenSerializer(SecurityVersion version);
+        protected internal bool IsIssuedSecurityTokenRequirement(SecurityTokenRequirement requirement);
+    }
+    public class CommunicationException : SystemException {
+        public CommunicationException();
+        protected CommunicationException(SerializationInfo info, StreamingContext context);
+        public CommunicationException(string message);
+        public CommunicationException(string message, Exception innerException);
+    }
+    public class CommunicationObjectAbortedException : CommunicationException {
+        public CommunicationObjectAbortedException();
+        protected CommunicationObjectAbortedException(SerializationInfo info, StreamingContext context);
+        public CommunicationObjectAbortedException(string message);
+        public CommunicationObjectAbortedException(string message, Exception innerException);
+    }
+    public class CommunicationObjectFaultedException : CommunicationException {
+        public CommunicationObjectFaultedException();
+        protected CommunicationObjectFaultedException(SerializationInfo info, StreamingContext context);
+        public CommunicationObjectFaultedException(string message);
+        public CommunicationObjectFaultedException(string message, Exception innerException);
+    }
+    public enum CommunicationState {
+        Closed = 4,
+        Closing = 3,
+        Created = 0,
+        Faulted = 5,
+        Opened = 2,
+        Opening = 1,
+    }
+    public enum ConcurrencyMode {
+        Multiple = 2,
+        Reentrant = 1,
+        Single = 0,
+    }
+    public class CorrelationActionMessageFilter : MessageFilter {
+        public CorrelationActionMessageFilter();
+        public string Action { get; set; }
+        public override bool Equals(object other);
+        public override int GetHashCode();
+        public override bool Match(Message message);
+        public override bool Match(MessageBuffer messageBuffer);
+        public override string ToString();
+    }
+    public class CorrelationQuery {
+        public CorrelationQuery();
+        public MessageQuerySet Select { get; set; }
+        public Collection<MessageQuerySet> SelectAdditional { get; }
+        public MessageFilter Where { get; set; }
+        public override bool Equals(object other);
+        public override int GetHashCode();
+    }
+    public sealed class DataContractFormatAttribute : Attribute {
+        public DataContractFormatAttribute();
+        public OperationFormatStyle Style { get; set; }
+    }
+    public enum DeadLetterQueue {
+        Custom = 2,
+        None = 0,
+        System = 1,
+    }
+    public sealed class DeliveryRequirementsAttribute : Attribute, IContractBehavior, IContractBehaviorAttribute {
+        public DeliveryRequirementsAttribute();
+        public QueuedDeliveryRequirementsMode QueuedDeliveryRequirements { get; set; }
+        public bool RequireOrderedDelivery { get; set; }
+        public Type TargetContract { get; set; }
+        void System.ServiceModel.Description.IContractBehavior.AddBindingParameters(ContractDescription description, ServiceEndpoint endpoint, BindingParameterCollection parameters);
+        void System.ServiceModel.Description.IContractBehavior.ApplyClientBehavior(ContractDescription description, ServiceEndpoint endpoint, ClientRuntime proxy);
+        void System.ServiceModel.Description.IContractBehavior.ApplyDispatchBehavior(ContractDescription description, ServiceEndpoint endpoint, DispatchRuntime dispatch);
+        void System.ServiceModel.Description.IContractBehavior.Validate(ContractDescription description, ServiceEndpoint endpoint);
+    }
+    public class DnsEndpointIdentity : EndpointIdentity {
+        public DnsEndpointIdentity(Claim identity);
+        public DnsEndpointIdentity(string dnsName);
+    }
+    public class DuplexChannelFactory<TChannel> : ChannelFactory<TChannel> {
+        public DuplexChannelFactory(object callbackObject);
+        public DuplexChannelFactory(object callbackObject, Binding binding);
+        public DuplexChannelFactory(object callbackObject, Binding binding, EndpointAddress remoteAddress);
+        public DuplexChannelFactory(object callbackObject, Binding binding, string remoteAddress);
+        public DuplexChannelFactory(object callbackObject, ServiceEndpoint endpoint);
+        public DuplexChannelFactory(object callbackObject, string endpointConfigurationName);
+        public DuplexChannelFactory(object callbackObject, string endpointConfigurationName, EndpointAddress remoteAddress);
+        public DuplexChannelFactory(InstanceContext callbackInstance);
+        public DuplexChannelFactory(InstanceContext callbackInstance, Binding binding);
+        public DuplexChannelFactory(InstanceContext callbackInstance, Binding binding, EndpointAddress remoteAddress);
+        public DuplexChannelFactory(InstanceContext callbackInstance, Binding binding, string remoteAddress);
+        public DuplexChannelFactory(InstanceContext callbackInstance, ServiceEndpoint endpoint);
+        public DuplexChannelFactory(InstanceContext callbackInstance, string endpointConfigurationName);
+        public DuplexChannelFactory(InstanceContext callbackInstance, string endpointConfigurationName, EndpointAddress remoteAddress);
+        public DuplexChannelFactory(Type callbackInstanceType);
+        public DuplexChannelFactory(Type callbackInstanceType, Binding binding);
+        public DuplexChannelFactory(Type callbackInstanceType, Binding binding, EndpointAddress remoteAddress);
+        public DuplexChannelFactory(Type callbackInstanceType, Binding binding, string remoteAddress);
+        public DuplexChannelFactory(Type callbackInstanceType, ServiceEndpoint endpoint);
+        public DuplexChannelFactory(Type callbackInstanceType, string endpointConfigurationName);
+        public DuplexChannelFactory(Type callbackInstanceType, string endpointConfigurationName, EndpointAddress remoteAddress);
+        public static TChannel CreateChannel(object callbackObject, Binding binding, EndpointAddress endpointAddress);
+        public static TChannel CreateChannel(object callbackObject, Binding binding, EndpointAddress endpointAddress, Uri via);
+        public static TChannel CreateChannel(object callbackObject, string endpointConfigurationName);
+        public override TChannel CreateChannel(EndpointAddress address, Uri via);
+        public TChannel CreateChannel(InstanceContext callbackInstance);
+        public static TChannel CreateChannel(InstanceContext callbackInstance, Binding binding, EndpointAddress endpointAddress);
+        public static TChannel CreateChannel(InstanceContext callbackInstance, Binding binding, EndpointAddress endpointAddress, Uri via);
+        public TChannel CreateChannel(InstanceContext callbackInstance, EndpointAddress address);
+        public virtual TChannel CreateChannel(InstanceContext callbackInstance, EndpointAddress address, Uri via);
+        public static TChannel CreateChannel(InstanceContext callbackInstance, string endpointConfigurationName);
+    }
+    public abstract class DuplexClientBase<TChannel> : ClientBase<TChannel> where TChannel : class {
+        protected DuplexClientBase(object callbackInstance);
+        protected DuplexClientBase(object callbackInstance, Binding binding, EndpointAddress remoteAddress);
+        protected DuplexClientBase(object callbackInstance, ServiceEndpoint endpoint);
+        protected DuplexClientBase(object callbackInstance, string endpointConfigurationName);
+        protected DuplexClientBase(object callbackInstance, string endpointConfigurationName, EndpointAddress remoteAddress);
+        protected DuplexClientBase(object callbackInstance, string endpointConfigurationName, string remoteAddress);
+        protected DuplexClientBase(InstanceContext callbackInstance);
+        protected DuplexClientBase(InstanceContext callbackInstance, Binding binding, EndpointAddress remoteAddress);
+        protected DuplexClientBase(InstanceContext callbackInstance, ServiceEndpoint endpoint);
+        protected DuplexClientBase(InstanceContext callbackInstance, string endpointConfigurationName);
+        protected DuplexClientBase(InstanceContext callbackInstance, string endpointConfigurationName, EndpointAddress remoteAddress);
+        protected DuplexClientBase(InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress);
+        public IDuplexContextChannel InnerDuplexChannel { get; }
+    }
+    public class Endpoint {
+        public Endpoint();
+        public Uri AddressUri { get; set; }
+        public string BehaviorConfigurationName { get; set; }
+        public Binding Binding { get; set; }
+        public Collection<AddressHeader> Headers { get; }
+        public EndpointIdentity Identity { get; set; }
+        public Uri ListenUri { get; set; }
+        public string Name { get; set; }
+        public XName ServiceContractName { get; set; }
+        public EndpointAddress GetAddress();
+        public EndpointAddress GetAddress(ServiceHostBase host);
+    }
+    public class EndpointAddress {
+        public EndpointAddress(string uri);
+        public EndpointAddress(Uri uri, params AddressHeader[] addressHeaders);
+        public EndpointAddress(Uri uri, EndpointIdentity identity, AddressHeaderCollection headers);
+        public EndpointAddress(Uri uri, EndpointIdentity identity, AddressHeaderCollection headers, XmlDictionaryReader metadataReader, XmlDictionaryReader extensionReader);
+        public EndpointAddress(Uri uri, EndpointIdentity identity, params AddressHeader[] addressHeaders);
+        public static Uri AnonymousUri { get; }
+        public AddressHeaderCollection Headers { get; }
+        public EndpointIdentity Identity { get; }
+        public bool IsAnonymous { get; }
+        public bool IsNone { get; }
+        public static Uri NoneUri { get; }
+        public Uri Uri { get; }
+        public void ApplyTo(Message message);
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public XmlDictionaryReader GetReaderAtExtensions();
+        public XmlDictionaryReader GetReaderAtMetadata();
+        public static bool operator ==(EndpointAddress address1, EndpointAddress address2);
+        public static bool operator !=(EndpointAddress address1, EndpointAddress address2);
+        public static EndpointAddress ReadFrom(AddressingVersion addressingVersion, XmlDictionaryReader reader);
+        public static EndpointAddress ReadFrom(AddressingVersion addressingVersion, XmlDictionaryReader reader, XmlDictionaryString localName, XmlDictionaryString ns);
+        public static EndpointAddress ReadFrom(AddressingVersion addressingVersion, XmlReader reader);
+        public static EndpointAddress ReadFrom(AddressingVersion addressingVersion, XmlReader reader, string localName, string ns);
+        public static EndpointAddress ReadFrom(XmlDictionaryReader reader);
+        public static EndpointAddress ReadFrom(XmlDictionaryReader reader, XmlDictionaryString localName, XmlDictionaryString ns);
+        public override string ToString();
+        public void WriteContentsTo(AddressingVersion addressingVersion, XmlDictionaryWriter writer);
+        public void WriteContentsTo(AddressingVersion addressingVersion, XmlWriter writer);
+        public void WriteTo(AddressingVersion addressingVersion, XmlDictionaryWriter writer);
+        public void WriteTo(AddressingVersion addressingVersion, XmlDictionaryWriter writer, XmlDictionaryString localName, XmlDictionaryString ns);
+        public void WriteTo(AddressingVersion addressingVersion, XmlWriter writer);
+        public void WriteTo(AddressingVersion addressingVersion, XmlWriter writer, string localName, string ns);
+    }
+    public class EndpointAddress10 : IXmlSerializable {
+        public static EndpointAddress10 FromEndpointAddress(EndpointAddress address);
+        public static XmlQualifiedName GetSchema(XmlSchemaSet xmlSchemaSet);
+        XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
+        void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader);
+        void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer);
+        public EndpointAddress ToEndpointAddress();
+    }
+    public class EndpointAddressAugust2004 : IXmlSerializable {
+        public static EndpointAddressAugust2004 FromEndpointAddress(EndpointAddress address);
+        public static XmlQualifiedName GetSchema(XmlSchemaSet xmlSchemaSet);
+        XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
+        void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader);
+        void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer);
+        public EndpointAddress ToEndpointAddress();
+    }
+    public class EndpointAddressBuilder {
+        public EndpointAddressBuilder();
+        public EndpointAddressBuilder(EndpointAddress address);
+        public Collection<AddressHeader> Headers { get; }
+        public EndpointIdentity Identity { get; set; }
+        public Uri Uri { get; set; }
+        public XmlDictionaryReader GetReaderAtExtensions();
+        public XmlDictionaryReader GetReaderAtMetadata();
+        public void SetExtensionReader(XmlDictionaryReader reader);
+        public void SetMetadataReader(XmlDictionaryReader reader);
+        public EndpointAddress ToEndpointAddress();
+    }
+    public abstract class EndpointIdentity {
+        protected EndpointIdentity();
+        public Claim IdentityClaim { get; }
+        public static EndpointIdentity CreateDnsIdentity(string dnsName);
+        public static EndpointIdentity CreateIdentity(Claim identity);
+        public static EndpointIdentity CreateRsaIdentity(X509Certificate2 certificate);
+        public static EndpointIdentity CreateRsaIdentity(string publicKey);
+        public static EndpointIdentity CreateSpnIdentity(string spnName);
+        public static EndpointIdentity CreateUpnIdentity(string upnName);
+        public static EndpointIdentity CreateX509CertificateIdentity(X509Certificate2 certificate);
+        public static EndpointIdentity CreateX509CertificateIdentity(X509Certificate2 primaryCertificate, X509Certificate2Collection supportingCertificates);
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        protected void Initialize(Claim identityClaim);
+        protected void Initialize(Claim identityClaim, IEqualityComparer<Claim> claimComparer);
+        public override string ToString();
+    }
+    public class EndpointIdentityExtension : MarkupExtension {
+        public EndpointIdentityExtension();
+        public EndpointIdentityExtension(EndpointIdentity identity);
+        public object ClaimResource { get; set; }
+        public string ClaimRight { get; set; }
+        public string ClaimType { get; set; }
+        public override object ProvideValue(IServiceProvider serviceProvider);
+    }
+    public class EndpointNotFoundException : CommunicationException {
+        public EndpointNotFoundException();
+        protected EndpointNotFoundException(SerializationInfo info, StreamingContext context);
+        public EndpointNotFoundException(string message);
+        public EndpointNotFoundException(string message, Exception innerException);
+    }
+    public sealed class EnvelopeVersion {
+        public string NextDestinationActorValue { get; }
+        public static EnvelopeVersion None { get; }
+        public static EnvelopeVersion Soap11 { get; }
+        public static EnvelopeVersion Soap12 { get; }
+        public string[] GetUltimateDestinationActorValues();
+        public override string ToString();
+    }
+    public class ExceptionDetail {
+        public ExceptionDetail(Exception exception);
+        public string HelpLink { get; set; }
+        public ExceptionDetail InnerException { get; set; }
+        public string Message { get; set; }
+        public string StackTrace { get; set; }
+        public string Type { get; set; }
+        public override string ToString();
+    }
+    public class ExceptionMapper {
+        public ExceptionMapper();
+        public virtual FaultException FromException(Exception ex);
+        public virtual FaultException FromException(Exception ex, string soapNamespace, string trustNamespace);
+        public virtual bool HandleSecurityTokenProcessingException(Exception ex);
+    }
+    public sealed class ExtensionCollection<T> : SynchronizedCollection<IExtension<T>>, ICollection<IExtension<T>>, IEnumerable, IEnumerable<IExtension<T>>, IExtensionCollection<T> where T : IExtensibleObject<T> {
+        public ExtensionCollection(T owner);
+        public ExtensionCollection(T owner, object syncRoot);
+        bool System.Collections.Generic.ICollection<System.ServiceModel.IExtension<T>>.IsReadOnly { get; }
+        protected override void ClearItems();
+        public E Find<E>();
+        public Collection<E> FindAll<E>();
+        protected override void InsertItem(int index, IExtension<T> item);
+        protected override void RemoveItem(int index);
+        protected override void SetItem(int index, IExtension<T> item);
+    }
+    public class FaultCode {
+        public FaultCode(string name);
+        public FaultCode(string name, FaultCode subCode);
+        public FaultCode(string name, string ns);
+        public FaultCode(string name, string ns, FaultCode subCode);
+        public bool IsPredefinedFault { get; }
+        public bool IsReceiverFault { get; }
+        public bool IsSenderFault { get; }
+        public string Name { get; }
+        public string Namespace { get; }
+        public FaultCode SubCode { get; }
+        public static FaultCode CreateReceiverFaultCode(FaultCode subCode);
+        public static FaultCode CreateReceiverFaultCode(string name, string ns);
+        public static FaultCode CreateSenderFaultCode(FaultCode subCode);
+        public static FaultCode CreateSenderFaultCode(string name, string ns);
+    }
+    public sealed class FaultContractAttribute : Attribute {
+        public FaultContractAttribute(Type detailType);
+        public string Action { get; set; }
+        public Type DetailType { get; }
+        public bool HasProtectionLevel { get; }
+        public string Name { get; set; }
+        public string Namespace { get; set; }
+        public ProtectionLevel ProtectionLevel { get; set; }
+    }
+    public class FaultException : CommunicationException {
+        public FaultException();
+        protected FaultException(SerializationInfo info, StreamingContext context);
+        public FaultException(MessageFault fault);
+        public FaultException(MessageFault fault, string action);
+        public FaultException(FaultReason reason);
+        public FaultException(FaultReason reason, FaultCode code);
+        public FaultException(FaultReason reason, FaultCode code, string action);
+        public FaultException(string reason);
+        public FaultException(string reason, FaultCode code);
+        public FaultException(string reason, FaultCode code, string action);
+        public string Action { get; }
+        public FaultCode Code { get; }
+        public override string Message { get; }
+        public FaultReason Reason { get; }
+        public static FaultException CreateFault(MessageFault messageFault, string action, params Type[] faultDetailTypes);
+        public static FaultException CreateFault(MessageFault messageFault, params Type[] faultDetailTypes);
+        public virtual MessageFault CreateMessageFault();
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class FaultException<TDetail> : FaultException {
+        protected FaultException(SerializationInfo info, StreamingContext context);
+        public FaultException(TDetail detail);
+        public FaultException(TDetail detail, FaultReason reason);
+        public FaultException(TDetail detail, FaultReason reason, FaultCode code);
+        public FaultException(TDetail detail, FaultReason reason, FaultCode code, string action);
+        public FaultException(TDetail detail, string reason);
+        public FaultException(TDetail detail, string reason, FaultCode code);
+        public FaultException(TDetail detail, string reason, FaultCode code, string action);
+        public TDetail Detail { get; }
+        public override MessageFault CreateMessageFault();
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+        public override string ToString();
+    }
+    public class FaultImportOptions {
+        public FaultImportOptions();
+        public bool UseMessageFormat { get; set; }
+    }
+    public class FaultReason {
+        public FaultReason(IEnumerable<FaultReasonText> translations);
+        public FaultReason(FaultReasonText translation);
+        public FaultReason(string text);
+        public SynchronizedReadOnlyCollection<FaultReasonText> Translations { get; }
+        public FaultReasonText GetMatchingTranslation();
+        public FaultReasonText GetMatchingTranslation(CultureInfo cultureInfo);
+        public override string ToString();
+    }
+    public class FaultReasonText {
+        public FaultReasonText(string text);
+        public FaultReasonText(string text, CultureInfo cultureInfo);
+        public FaultReasonText(string text, string xmlLang);
+        public string Text { get; }
+        public string XmlLang { get; }
+        public bool Matches(CultureInfo cultureInfo);
+    }
+    public sealed class FederatedMessageSecurityOverHttp {
+        public FederatedMessageSecurityOverHttp();
+        public SecurityAlgorithmSuite AlgorithmSuite { get; set; }
+        public Collection<ClaimTypeRequirement> ClaimTypeRequirements { get; }
+        public bool EstablishSecurityContext { get; set; }
+        public SecurityKeyType IssuedKeyType { get; set; }
+        public string IssuedTokenType { get; set; }
+        public EndpointAddress IssuerAddress { get; set; }
+        public Binding IssuerBinding { get; set; }
+        public EndpointAddress IssuerMetadataAddress { get; set; }
+        public bool NegotiateServiceCredential { get; set; }
+        public Collection<XmlElement> TokenRequestParameters { get; }
+        public bool ShouldSerializeAlgorithmSuite();
+        public bool ShouldSerializeClaimTypeRequirements();
+        public bool ShouldSerializeEstablishSecurityContext();
+        public bool ShouldSerializeIssuedKeyType();
+        public bool ShouldSerializeNegotiateServiceCredential();
+        public bool ShouldSerializeTokenRequestParameters();
+    }
+    public enum HostNameComparisonMode {
+        Exact = 1,
+        StrongWildcard = 0,
+        WeakWildcard = 2,
+    }
+    public abstract class HttpBindingBase : Binding, IBindingRuntimePreferences {
+        public bool AllowCookies { get; set; }
+        public bool BypassProxyOnLocal { get; set; }
+        public EnvelopeVersion EnvelopeVersion { get; }
+        public HostNameComparisonMode HostNameComparisonMode { get; set; }
+        public long MaxBufferPoolSize { get; set; }
+        public int MaxBufferSize { get; set; }
+        public long MaxReceivedMessageSize { get; set; }
+        public Uri ProxyAddress { get; set; }
+        public XmlDictionaryReaderQuotas ReaderQuotas { get; set; }
+        public override string Scheme { get; }
+        bool System.ServiceModel.Channels.IBindingRuntimePreferences.ReceiveSynchronously { get; }
+        public Encoding TextEncoding { get; set; }
+        public TransferMode TransferMode { get; set; }
+        public bool UseDefaultWebProxy { get; set; }
+        public bool ShouldSerializeReaderQuotas();
+        public bool ShouldSerializeTextEncoding();
+    }
+    public enum HttpClientCredentialType {
+        Basic = 1,
+        Certificate = 5,
+        Digest = 2,
+        InheritedFromHost = 6,
+        None = 0,
+        Ntlm = 3,
+        Windows = 4,
+    }
+    public enum HttpProxyCredentialType {
+        Basic = 1,
+        Digest = 2,
+        None = 0,
+        Ntlm = 3,
+        Windows = 4,
+    }
+    public sealed class HttpTransportSecurity {
+        public HttpTransportSecurity();
+        public HttpClientCredentialType ClientCredentialType { get; set; }
+        public ExtendedProtectionPolicy ExtendedProtectionPolicy { get; set; }
+        public HttpProxyCredentialType ProxyCredentialType { get; set; }
+        public string Realm { get; set; }
+        public bool ShouldSerializeClientCredentialType();
+        public bool ShouldSerializeExtendedProtectionPolicy();
+        public bool ShouldSerializeProxyCredentialType();
+        public bool ShouldSerializeRealm();
+    }
+    public interface IClientChannel : IChannel, ICommunicationObject, IContextChannel, IDisposable, IExtensibleObject<IContextChannel> {
+        bool AllowInitializationUI { get; set; }
+        bool DidInteractiveInitialization { get; }
+        Uri Via { get; }
+        event EventHandler<UnknownMessageReceivedEventArgs> UnknownMessageReceived;
+        IAsyncResult BeginDisplayInitializationUI(AsyncCallback callback, object state);
+        void DisplayInitializationUI();
+        void EndDisplayInitializationUI(IAsyncResult result);
+    }
+    public interface ICommunicationObject {
+        CommunicationState State { get; }
+        event EventHandler Closed;
+        event EventHandler Closing;
+        event EventHandler Faulted;
+        event EventHandler Opened;
+        event EventHandler Opening;
+        void Abort();
+        IAsyncResult BeginClose(AsyncCallback callback, object state);
+        IAsyncResult BeginClose(TimeSpan timeout, AsyncCallback callback, object state);
+        IAsyncResult BeginOpen(AsyncCallback callback, object state);
+        IAsyncResult BeginOpen(TimeSpan timeout, AsyncCallback callback, object state);
+        void Close();
+        void Close(TimeSpan timeout);
+        void EndClose(IAsyncResult result);
+        void EndOpen(IAsyncResult result);
+        void Open();
+        void Open(TimeSpan timeout);
+    }
+    public interface IContextChannel : IChannel, ICommunicationObject, IExtensibleObject<IContextChannel> {
+        bool AllowOutputBatching { get; set; }
+        IInputSession InputSession { get; }
+        EndpointAddress LocalAddress { get; }
+        TimeSpan OperationTimeout { get; set; }
+        IOutputSession OutputSession { get; }
+        EndpointAddress RemoteAddress { get; }
+        string SessionId { get; }
+    }
+    public interface IDefaultCommunicationTimeouts {
+        TimeSpan CloseTimeout { get; }
+        TimeSpan OpenTimeout { get; }
+        TimeSpan ReceiveTimeout { get; }
+        TimeSpan SendTimeout { get; }
+    }
+    public interface IDuplexContextChannel : IChannel, ICommunicationObject, IContextChannel, IExtensibleObject<IContextChannel> {
+        bool AutomaticInputSessionShutdown { get; set; }
+        InstanceContext CallbackInstance { get; set; }
+        IAsyncResult BeginCloseOutputSession(TimeSpan timeout, AsyncCallback callback, object state);
+        void CloseOutputSession(TimeSpan timeout);
+        void EndCloseOutputSession(IAsyncResult result);
+    }
+    public interface IExtensibleObject<T> where T : IExtensibleObject<T> {
+        IExtensionCollection<T> Extensions { get; }
+    }
+    public interface IExtension<T> where T : IExtensibleObject<T> {
+        void Attach(T owner);
+        void Detach(T owner);
+    }
+    public interface IExtensionCollection<T> : ICollection<IExtension<T>>, IEnumerable, IEnumerable<IExtension<T>> where T : IExtensibleObject<T> {
+        E Find<E>();
+        Collection<E> FindAll<E>();
+    }
+    public enum ImpersonationOption {
+        Allowed = 1,
+        NotAllowed = 0,
+        Required = 2,
+    }
+    public sealed class InstanceContext : CommunicationObject, IExtensibleObject<InstanceContext> {
+        public InstanceContext(object implementation);
+        public InstanceContext(ServiceHostBase host);
+        public InstanceContext(ServiceHostBase host, object implementation);
+        protected override TimeSpan DefaultCloseTimeout { get; }
+        protected override TimeSpan DefaultOpenTimeout { get; }
+        public IExtensionCollection<InstanceContext> Extensions { get; }
+        public ServiceHostBase Host { get; }
+        public ICollection<IChannel> IncomingChannels { get; }
+        public int ManualFlowControlLimit { get; set; }
+        public ICollection<IChannel> OutgoingChannels { get; }
+        public SynchronizationContext SynchronizationContext { get; set; }
+        public object GetServiceInstance();
+        public object GetServiceInstance(Message message);
+        public int IncrementManualFlowControlLimit(int incrementBy);
+        protected override void OnAbort();
+        protected override IAsyncResult OnBeginClose(TimeSpan timeout, AsyncCallback callback, object state);
+        protected override IAsyncResult OnBeginOpen(TimeSpan timeout, AsyncCallback callback, object state);
+        protected override void OnClose(TimeSpan timeout);
+        protected override void OnClosed();
+        protected override void OnEndClose(IAsyncResult result);
+        protected override void OnEndOpen(IAsyncResult result);
+        protected override void OnFaulted();
+        protected override void OnOpen(TimeSpan timeout);
+        protected override void OnOpened();
+        protected override void OnOpening();
+        public void ReleaseServiceInstance();
+    }
+    public enum InstanceContextMode {
+        PerCall = 1,
+        PerSession = 0,
+        Single = 2,
+    }
+    public class InvalidMessageContractException : SystemException {
+        public InvalidMessageContractException();
+        protected InvalidMessageContractException(SerializationInfo info, StreamingContext context);
+        public InvalidMessageContractException(string message);
+        public InvalidMessageContractException(string message, Exception innerException);
+    }
+    public interface IOnlineStatus {
+        bool IsOnline { get; }
+        event EventHandler Offline;
+        event EventHandler Online;
+    }
+    public interface IServiceChannel : IChannel, ICommunicationObject, IContextChannel, IExtensibleObject<IContextChannel> {
+        Uri ListenUri { get; }
+    }
+    public class MessageBodyMemberAttribute : MessageContractMemberAttribute {
+        public MessageBodyMemberAttribute();
+        public int Order { get; set; }
+    }
+    public sealed class MessageContractAttribute : Attribute {
+        public MessageContractAttribute();
+        public bool HasProtectionLevel { get; }
+        public bool IsWrapped { get; set; }
+        public ProtectionLevel ProtectionLevel { get; set; }
+        public string WrapperName { get; set; }
+        public string WrapperNamespace { get; set; }
+    }
+    public abstract class MessageContractMemberAttribute : Attribute {
+        protected MessageContractMemberAttribute();
+        public bool HasProtectionLevel { get; }
+        public string Name { get; set; }
+        public string Namespace { get; set; }
+        public ProtectionLevel ProtectionLevel { get; set; }
+    }
+    public enum MessageCredentialType {
+        Certificate = 3,
+        IssuedToken = 4,
+        None = 0,
+        UserName = 2,
+        Windows = 1,
+    }
+    public class MessageHeader<T> {
+        public MessageHeader();
+        public MessageHeader(T content);
+        public MessageHeader(T content, bool mustUnderstand, string actor, bool relay);
+        public string Actor { get; set; }
+        public T Content { get; set; }
+        public bool MustUnderstand { get; set; }
+        public bool Relay { get; set; }
+        public MessageHeader GetUntypedHeader(string name, string ns);
+    }
+    public sealed class MessageHeaderArrayAttribute : MessageHeaderAttribute {
+        public MessageHeaderArrayAttribute();
+    }
+    public class MessageHeaderAttribute : MessageContractMemberAttribute {
+        public MessageHeaderAttribute();
+        public string Actor { get; set; }
+        public bool MustUnderstand { get; set; }
+        public bool Relay { get; set; }
+    }
+    public class MessageHeaderException : ProtocolException {
+        public MessageHeaderException();
+        protected MessageHeaderException(SerializationInfo info, StreamingContext context);
+        public MessageHeaderException(string message);
+        public MessageHeaderException(string message, bool isDuplicate);
+        public MessageHeaderException(string message, Exception innerException);
+        public MessageHeaderException(string message, string headerName, string ns);
+        public MessageHeaderException(string message, string headerName, string ns, bool isDuplicate);
+        public MessageHeaderException(string message, string headerName, string ns, bool isDuplicate, Exception innerException);
+        public MessageHeaderException(string message, string headerName, string ns, Exception innerException);
+        public string HeaderName { get; }
+        public string HeaderNamespace { get; }
+        public bool IsDuplicate { get; }
+    }
+    public sealed class MessageParameterAttribute : Attribute {
+        public MessageParameterAttribute();
+        public string Name { get; set; }
+    }
+    public sealed class MessagePropertyAttribute : Attribute {
+        public MessagePropertyAttribute();
+        public string Name { get; set; }
+    }
+    public class MessageQuerySet : Dictionary<string, MessageQuery> {
+        public MessageQuerySet();
+        public MessageQuerySet(MessageQueryTable<string> queryTable);
+        public string Name { get; set; }
+        public MessageQueryTable<string> GetMessageQueryTable();
+    }
+    public class MessageSecurityOverHttp {
+        public MessageSecurityOverHttp();
+        public SecurityAlgorithmSuite AlgorithmSuite { get; set; }
+        public MessageCredentialType ClientCredentialType { get; set; }
+        public bool NegotiateServiceCredential { get; set; }
+        protected virtual bool IsSecureConversationEnabled();
+        public bool ShouldSerializeAlgorithmSuite();
+        public bool ShouldSerializeClientCredentialType();
+        public bool ShouldSerializeNegotiateServiceCredential();
+    }
+    public sealed class MessageSecurityOverMsmq {
+        public MessageSecurityOverMsmq();
+        public SecurityAlgorithmSuite AlgorithmSuite { get; set; }
+        public MessageCredentialType ClientCredentialType { get; set; }
+    }
+    public sealed class MessageSecurityOverTcp {
+        public MessageSecurityOverTcp();
+        public SecurityAlgorithmSuite AlgorithmSuite { get; set; }
+        public MessageCredentialType ClientCredentialType { get; set; }
+    }
+    public abstract class MessageSecurityVersion {
+        public abstract BasicSecurityProfileVersion BasicSecurityProfileVersion { get; }
+        public static MessageSecurityVersion Default { get; }
+        public SecureConversationVersion SecureConversationVersion { get; }
+        public abstract SecurityPolicyVersion SecurityPolicyVersion { get; }
+        public SecurityTokenVersion SecurityTokenVersion { get; }
+        public SecurityVersion SecurityVersion { get; }
+        public TrustVersion TrustVersion { get; }
+        public static MessageSecurityVersion WSSecurity10WSTrust13WSSecureConversation13WSSecurityPolicy12BasicSecurityProfile10 { get; }
+        public static MessageSecurityVersion WSSecurity10WSTrustFebruary2005WSSecureConversationFebruary2005WSSecurityPolicy11BasicSecurityProfile10 { get; }
+        public static MessageSecurityVersion WSSecurity11WSTrust13WSSecureConversation13WSSecurityPolicy12 { get; }
+        public static MessageSecurityVersion WSSecurity11WSTrust13WSSecureConversation13WSSecurityPolicy12BasicSecurityProfile10 { get; }
+        public static MessageSecurityVersion WSSecurity11WSTrustFebruary2005WSSecureConversationFebruary2005WSSecurityPolicy11 { get; }
+        public static MessageSecurityVersion WSSecurity11WSTrustFebruary2005WSSecureConversationFebruary2005WSSecurityPolicy11BasicSecurityProfile10 { get; }
+    }
+    public enum MsmqAuthenticationMode {
+        Certificate = 2,
+        None = 0,
+        WindowsDomain = 1,
+    }
+    public abstract class MsmqBindingBase : Binding, IBindingRuntimePreferences {
+        protected MsmqBindingBase();
+        public Uri CustomDeadLetterQueue { get; set; }
+        public DeadLetterQueue DeadLetterQueue { get; set; }
+        public bool Durable { get; set; }
+        public bool ExactlyOnce { get; set; }
+        public long MaxReceivedMessageSize { get; set; }
+        public int MaxRetryCycles { get; set; }
+        public bool ReceiveContextEnabled { get; set; }
+        public ReceiveErrorHandling ReceiveErrorHandling { get; set; }
+        public int ReceiveRetryCount { get; set; }
+        public TimeSpan RetryCycleDelay { get; set; }
+        public override string Scheme { get; }
+        bool System.ServiceModel.Channels.IBindingRuntimePreferences.ReceiveSynchronously { get; }
+        public TimeSpan TimeToLive { get; set; }
+        public bool UseMsmqTracing { get; set; }
+        public bool UseSourceJournal { get; set; }
+        public TimeSpan ValidityDuration { get; set; }
+    }
+    public enum MsmqEncryptionAlgorithm {
+        Aes = 1,
+        RC4Stream = 0,
+    }
+    public class MsmqException : ExternalException {
+        public MsmqException();
+        protected MsmqException(SerializationInfo info, StreamingContext context);
+        public MsmqException(string message);
+        public MsmqException(string message, Exception inner);
+        public MsmqException(string message, int error);
+    }
+    public class MsmqPoisonMessageException : PoisonMessageException {
+        public MsmqPoisonMessageException();
+        public MsmqPoisonMessageException(long messageLookupId);
+        public MsmqPoisonMessageException(long messageLookupId, Exception innerException);
+        protected MsmqPoisonMessageException(SerializationInfo info, StreamingContext context);
+        public MsmqPoisonMessageException(string message);
+        public MsmqPoisonMessageException(string message, Exception innerException);
+        public long MessageLookupId { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public enum MsmqSecureHashAlgorithm {
+        MD5 = 0,
+        Sha1 = 1,
+        Sha256 = 2,
+        Sha512 = 3,
+    }
+    public sealed class MsmqTransportSecurity {
+        public MsmqTransportSecurity();
+        public MsmqTransportSecurity(MsmqTransportSecurity other);
+        public MsmqAuthenticationMode MsmqAuthenticationMode { get; set; }
+        public MsmqEncryptionAlgorithm MsmqEncryptionAlgorithm { get; set; }
+        public ProtectionLevel MsmqProtectionLevel { get; set; }
+        public MsmqSecureHashAlgorithm MsmqSecureHashAlgorithm { get; set; }
+    }
+    public sealed class NamedPipeTransportSecurity {
+        public NamedPipeTransportSecurity();
+        public ProtectionLevel ProtectionLevel { get; set; }
+    }
+    public class NetHttpBinding : HttpBindingBase {
+        public NetHttpBinding();
+        public NetHttpBinding(BasicHttpSecurityMode securityMode);
+        public NetHttpBinding(BasicHttpSecurityMode securityMode, bool reliableSessionEnabled);
+        public NetHttpBinding(string configurationName);
+        public NetHttpMessageEncoding MessageEncoding { get; set; }
+        public OptionalReliableSession ReliableSession { get; set; }
+        public BasicHttpSecurity Security { get; set; }
+        public WebSocketTransportSettings WebSocketSettings { get; }
+        public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingParameterCollection parameters);
+        public override BindingElementCollection CreateBindingElements();
+        public bool ShouldSerializeReliableSession();
+        public bool ShouldSerializeSecurity();
+    }
+    public enum NetHttpMessageEncoding {
+        Binary = 0,
+        Mtom = 2,
+        Text = 1,
+    }
+    public class NetHttpsBinding : HttpBindingBase {
+        public NetHttpsBinding();
+        public NetHttpsBinding(BasicHttpsSecurityMode securityMode);
+        public NetHttpsBinding(BasicHttpsSecurityMode securityMode, bool reliableSessionEnabled);
+        public NetHttpsBinding(string configurationName);
+        public NetHttpMessageEncoding MessageEncoding { get; set; }
+        public OptionalReliableSession ReliableSession { get; set; }
+        public BasicHttpsSecurity Security { get; set; }
+        public WebSocketTransportSettings WebSocketSettings { get; }
+        public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingParameterCollection parameters);
+        public override BindingElementCollection CreateBindingElements();
+        public bool ShouldSerializeReliableSession();
+        public bool ShouldSerializeSecurity();
+    }
+    public class NetMsmqBinding : MsmqBindingBase {
+        public NetMsmqBinding();
+        public NetMsmqBinding(NetMsmqSecurityMode securityMode);
+        public NetMsmqBinding(string configurationName);
+        public EnvelopeVersion EnvelopeVersion { get; }
+        public long MaxBufferPoolSize { get; set; }
+        public QueueTransferProtocol QueueTransferProtocol { get; set; }
+        public XmlDictionaryReaderQuotas ReaderQuotas { get; set; }
+        public NetMsmqSecurity Security { get; set; }
+        public bool UseActiveDirectory { get; set; }
+        public override BindingElementCollection CreateBindingElements();
+        public bool ShouldSerializeReaderQuotas();
+        public bool ShouldSerializeSecurity();
+    }
+    public sealed class NetMsmqSecurity {
+        public NetMsmqSecurity();
+        public MessageSecurityOverMsmq Message { get; set; }
+        public NetMsmqSecurityMode Mode { get; set; }
+        public MsmqTransportSecurity Transport { get; set; }
+    }
+    public enum NetMsmqSecurityMode {
+        Both = 3,
+        Message = 2,
+        None = 0,
+        Transport = 1,
+    }
+    public class NetNamedPipeBinding : Binding, IBindingRuntimePreferences {
+        public NetNamedPipeBinding();
+        public NetNamedPipeBinding(NetNamedPipeSecurityMode securityMode);
+        public NetNamedPipeBinding(string configurationName);
+        public EnvelopeVersion EnvelopeVersion { get; }
+        public HostNameComparisonMode HostNameComparisonMode { get; set; }
+        public long MaxBufferPoolSize { get; set; }
+        public int MaxBufferSize { get; set; }
+        public int MaxConnections { get; set; }
+        public long MaxReceivedMessageSize { get; set; }
+        public XmlDictionaryReaderQuotas ReaderQuotas { get; set; }
+        public override string Scheme { get; }
+        public NetNamedPipeSecurity Security { get; set; }
+        bool System.ServiceModel.Channels.IBindingRuntimePreferences.ReceiveSynchronously { get; }
+        public bool TransactionFlow { get; set; }
+        public TransactionProtocol TransactionProtocol { get; set; }
+        public TransferMode TransferMode { get; set; }
+        public override BindingElementCollection CreateBindingElements();
+        public bool ShouldSerializeMaxConnections();
+        public bool ShouldSerializeReaderQuotas();
+        public bool ShouldSerializeSecurity();
+        public bool ShouldSerializeTransactionProtocol();
+    }
+    public sealed class NetNamedPipeSecurity {
+        public NetNamedPipeSecurity();
+        public NetNamedPipeSecurityMode Mode { get; set; }
+        public NamedPipeTransportSecurity Transport { get; set; }
+        public bool ShouldSerializeTransport();
+    }
+    public enum NetNamedPipeSecurityMode {
+        None = 0,
+        Transport = 1,
+    }
+    public class NetPeerTcpBinding : Binding, IBindingRuntimePreferences {
+        public NetPeerTcpBinding();
+        public NetPeerTcpBinding(string configurationName);
+        public EnvelopeVersion EnvelopeVersion { get; }
+        public static bool IsPnrpAvailable { get; }
+        public IPAddress ListenIPAddress { get; set; }
+        public long MaxBufferPoolSize { get; set; }
+        public long MaxReceivedMessageSize { get; set; }
+        public int Port { get; set; }
+        public XmlDictionaryReaderQuotas ReaderQuotas { get; set; }
+        public PeerResolverSettings Resolver { get; }
+        public override string Scheme { get; }
+        public PeerSecuritySettings Security { get; set; }
+        bool System.ServiceModel.Channels.IBindingRuntimePreferences.ReceiveSynchronously { get; }
+        public override BindingElementCollection CreateBindingElements();
+        public bool ShouldSerializeReaderQuotas();
+        public bool ShouldSerializeSecurity();
+    }
+    public class NetTcpBinding : Binding, IBindingRuntimePreferences {
+        public NetTcpBinding();
+        public NetTcpBinding(SecurityMode securityMode);
+        public NetTcpBinding(SecurityMode securityMode, bool reliableSessionEnabled);
+        public NetTcpBinding(string configurationName);
+        public EnvelopeVersion EnvelopeVersion { get; }
+        public HostNameComparisonMode HostNameComparisonMode { get; set; }
+        public int ListenBacklog { get; set; }
+        public long MaxBufferPoolSize { get; set; }
+        public int MaxBufferSize { get; set; }
+        public int MaxConnections { get; set; }
+        public long MaxReceivedMessageSize { get; set; }
+        public bool PortSharingEnabled { get; set; }
+        public XmlDictionaryReaderQuotas ReaderQuotas { get; set; }
+        public OptionalReliableSession ReliableSession { get; set; }
+        public override string Scheme { get; }
+        public NetTcpSecurity Security { get; set; }
+        bool System.ServiceModel.Channels.IBindingRuntimePreferences.ReceiveSynchronously { get; }
+        public bool TransactionFlow { get; set; }
+        public TransactionProtocol TransactionProtocol { get; set; }
+        public TransferMode TransferMode { get; set; }
+        public override BindingElementCollection CreateBindingElements();
+        public bool ShouldSerializeListenBacklog();
+        public bool ShouldSerializeMaxConnections();
+        public bool ShouldSerializeReaderQuotas();
+        public bool ShouldSerializeReliableSession();
+        public bool ShouldSerializeSecurity();
+        public bool ShouldSerializeTransactionProtocol();
+    }
+    public class NetTcpContextBinding : NetTcpBinding {
+        public NetTcpContextBinding();
+        public NetTcpContextBinding(SecurityMode securityMode);
+        public NetTcpContextBinding(SecurityMode securityMode, bool reliableSessionEnabled);
+        public NetTcpContextBinding(string configName);
+        public Uri ClientCallbackAddress { get; set; }
+        public bool ContextManagementEnabled { get; set; }
+        public ProtectionLevel ContextProtectionLevel { get; set; }
+        public override BindingElementCollection CreateBindingElements();
+    }
+    public sealed class NetTcpSecurity {
+        public NetTcpSecurity();
+        public MessageSecurityOverTcp Message { get; set; }
+        public SecurityMode Mode { get; set; }
+        public TcpTransportSecurity Transport { get; set; }
+    }
+    public sealed class NonDualMessageSecurityOverHttp : MessageSecurityOverHttp {
+        public NonDualMessageSecurityOverHttp();
+        public bool EstablishSecurityContext { get; set; }
+        protected override bool IsSecureConversationEnabled();
+    }
+    public sealed class OperationBehaviorAttribute : Attribute, IOperationBehavior {
+        public OperationBehaviorAttribute();
+        public bool AutoDisposeParameters { get; set; }
+        public ImpersonationOption Impersonation { get; set; }
+        public ReleaseInstanceMode ReleaseInstanceMode { get; set; }
+        public bool TransactionAutoComplete { get; set; }
+        public bool TransactionScopeRequired { get; set; }
+        void System.ServiceModel.Description.IOperationBehavior.AddBindingParameters(OperationDescription description, BindingParameterCollection parameters);
+        void System.ServiceModel.Description.IOperationBehavior.ApplyClientBehavior(OperationDescription description, ClientOperation proxy);
+        void System.ServiceModel.Description.IOperationBehavior.ApplyDispatchBehavior(OperationDescription description, DispatchOperation dispatch);
+        void System.ServiceModel.Description.IOperationBehavior.Validate(OperationDescription description);
+    }
+    public sealed class OperationContext : IExtensibleObject<OperationContext> {
+        public OperationContext(IContextChannel channel);
+        public IContextChannel Channel { get; }
+        public ClaimsPrincipal ClaimsPrincipal { get; internal set; }
+        public static OperationContext Current { get; set; }
+        public EndpointDispatcher EndpointDispatcher { get; set; }
+        public IExtensionCollection<OperationContext> Extensions { get; }
+        public bool HasSupportingTokens { get; }
+        public ServiceHostBase Host { get; }
+        public MessageHeaders IncomingMessageHeaders { get; }
+        public MessageProperties IncomingMessageProperties { get; }
+        public MessageVersion IncomingMessageVersion { get; }
+        public InstanceContext InstanceContext { get; }
+        public bool IsUserContext { get; }
+        public MessageHeaders OutgoingMessageHeaders { get; }
+        public MessageProperties OutgoingMessageProperties { get; }
+        public RequestContext RequestContext { get; set; }
+        public ServiceSecurityContext ServiceSecurityContext { get; }
+        public string SessionId { get; }
+        public ICollection<SupportingTokenSpecification> SupportingTokens { get; }
+        public event EventHandler OperationCompleted;
+        public T GetCallbackChannel<T>();
+        public void SetTransactionComplete();
+    }
+    public sealed class OperationContextScope : IDisposable {
+        public OperationContextScope(IContextChannel channel);
+        public OperationContextScope(OperationContext context);
+        public void Dispose();
+    }
+    public sealed class OperationContractAttribute : Attribute {
+        public OperationContractAttribute();
+        public string Action { get; set; }
+        public bool AsyncPattern { get; set; }
+        public bool HasProtectionLevel { get; }
+        public bool IsInitiating { get; set; }
+        public bool IsOneWay { get; set; }
+        public bool IsTerminating { get; set; }
+        public string Name { get; set; }
+        public ProtectionLevel ProtectionLevel { get; set; }
+        public string ReplyAction { get; set; }
+    }
+    public enum OperationFormatStyle {
+        Document = 0,
+        Rpc = 1,
+    }
+    public enum OperationFormatUse {
+        Encoded = 1,
+        Literal = 0,
+    }
+    public class OptionalReliableSession : ReliableSession {
+        public OptionalReliableSession();
+        public OptionalReliableSession(ReliableSessionBindingElement reliableSessionBindingElement);
+        public bool Enabled { get; set; }
+    }
+    public sealed class PeerHopCountAttribute : MessageHeaderAttribute {
+        public PeerHopCountAttribute();
+        public new string Actor { get; }
+        public new bool MustUnderstand { get; }
+        public new string Name { get; }
+        public new string Namespace { get; }
+        public new ProtectionLevel ProtectionLevel { get; }
+        public new bool Relay { get; }
+    }
+    public enum PeerMessageOrigination {
+        Local = 0,
+        Remote = 1,
+    }
+    public enum PeerMessagePropagation {
+        Local = 1,
+        LocalAndRemote = 3,
+        None = 0,
+        Remote = 2,
+    }
+    public abstract class PeerMessagePropagationFilter {
+        protected PeerMessagePropagationFilter();
+        public abstract PeerMessagePropagation ShouldMessagePropagate(Message message, PeerMessageOrigination origination);
+    }
+    public sealed class PeerNode : IOnlineStatus {
+        public bool IsOnline { get; }
+        public PeerMessagePropagationFilter MessagePropagationFilter { get; set; }
+        public int Port { get; }
+        public event EventHandler Offline;
+        public event EventHandler Online;
+        public void RefreshConnection();
+        public override string ToString();
+    }
+    public sealed class PeerNodeAddress {
+        public PeerNodeAddress(EndpointAddress endpointAddress, ReadOnlyCollection<IPAddress> ipAddresses);
+        public EndpointAddress EndpointAddress { get; }
+        public ReadOnlyCollection<IPAddress> IPAddresses { get; }
+    }
+    public abstract class PeerResolver {
+        protected PeerResolver();
+        public abstract bool CanShareReferrals { get; }
+        public virtual void Initialize(EndpointAddress address, Binding binding, ClientCredentials credentials, PeerReferralPolicy referralPolicy);
+        public abstract object Register(string meshId, PeerNodeAddress nodeAddress, TimeSpan timeout);
+        public abstract ReadOnlyCollection<PeerNodeAddress> Resolve(string meshId, int maxAddresses, TimeSpan timeout);
+        public abstract void Unregister(object registrationId, TimeSpan timeout);
+        public abstract void Update(object registrationId, PeerNodeAddress updatedNodeAddress, TimeSpan timeout);
+    }
+    public sealed class PeerSecuritySettings {
+        public PeerSecuritySettings();
+        public SecurityMode Mode { get; set; }
+        public PeerTransportSecuritySettings Transport { get; set; }
+        public bool ShouldSerializeMode();
+        public bool ShouldSerializeTransport();
+    }
+    public enum PeerTransportCredentialType {
+        Certificate = 1,
+        Password = 0,
+    }
+    public sealed class PeerTransportSecuritySettings {
+        public PeerTransportSecuritySettings();
+        public PeerTransportCredentialType CredentialType { get; set; }
+    }
+    public class PoisonMessageException : CommunicationException {
+        public PoisonMessageException();
+        protected PoisonMessageException(SerializationInfo info, StreamingContext context);
+        public PoisonMessageException(string message);
+        public PoisonMessageException(string message, Exception innerException);
+    }
+    public class ProtocolException : CommunicationException {
+        public ProtocolException();
+        protected ProtocolException(SerializationInfo info, StreamingContext context);
+        public ProtocolException(string message);
+        public ProtocolException(string message, Exception innerException);
+    }
+    public enum QueuedDeliveryRequirementsMode {
+        Allowed = 0,
+        NotAllowed = 2,
+        Required = 1,
+    }
+    public enum QueueTransferProtocol {
+        Native = 0,
+        Srmp = 1,
+        SrmpSecure = 2,
+    }
+    public class QuotaExceededException : SystemException {
+        public QuotaExceededException();
+        protected QuotaExceededException(SerializationInfo info, StreamingContext context);
+        public QuotaExceededException(string message);
+        public QuotaExceededException(string message, Exception innerException);
+    }
+    public sealed class ReceiveContextEnabledAttribute : Attribute, IOperationBehavior {
+        public ReceiveContextEnabledAttribute();
+        public bool ManualControl { get; set; }
+        public void AddBindingParameters(OperationDescription operationDescription, BindingParameterCollection bindingParameters);
+        public void ApplyClientBehavior(OperationDescription operationDescription, ClientOperation clientOperation);
+        public void ApplyDispatchBehavior(OperationDescription operationDescription, DispatchOperation dispatchOperation);
+        public void Validate(OperationDescription operationDescription);
+    }
+    public enum ReceiveErrorHandling {
+        Drop = 1,
+        Fault = 0,
+        Move = 3,
+        Reject = 2,
+    }
+    public enum ReleaseInstanceMode {
+        AfterCall = 2,
+        BeforeAndAfterCall = 3,
+        BeforeCall = 1,
+        None = 0,
+    }
+    public abstract class ReliableMessagingVersion {
+        public static ReliableMessagingVersion Default { get; }
+        public static ReliableMessagingVersion WSReliableMessaging11 { get; }
+        public static ReliableMessagingVersion WSReliableMessagingFebruary2005 { get; }
+    }
+    public class ReliableSession {
+        public ReliableSession();
+        public ReliableSession(ReliableSessionBindingElement reliableSessionBindingElement);
+        public TimeSpan InactivityTimeout { get; set; }
+        public bool Ordered { get; set; }
+    }
+    public class RsaEndpointIdentity : EndpointIdentity {
+        public RsaEndpointIdentity(Claim identity);
+        public RsaEndpointIdentity(X509Certificate2 certificate);
+        public RsaEndpointIdentity(string publicKey);
+    }
+    public enum SecurityMode {
+        Message = 2,
+        None = 0,
+        Transport = 1,
+        TransportWithMessageCredential = 3,
+    }
+    public class ServerTooBusyException : CommunicationException {
+        public ServerTooBusyException();
+        protected ServerTooBusyException(SerializationInfo info, StreamingContext context);
+        public ServerTooBusyException(string message);
+        public ServerTooBusyException(string message, Exception innerException);
+    }
+    public class ServiceActivationException : CommunicationException {
+        public ServiceActivationException();
+        protected ServiceActivationException(SerializationInfo info, StreamingContext context);
+        public ServiceActivationException(string message);
+        public ServiceActivationException(string message, Exception innerException);
+    }
+    public class ServiceAuthenticationManager {
+        public ServiceAuthenticationManager();
+        public virtual ReadOnlyCollection<IAuthorizationPolicy> Authenticate(ReadOnlyCollection<IAuthorizationPolicy> authPolicy, Uri listenUri, ref Message message);
+    }
+    public class ServiceAuthorizationManager {
+        public ServiceAuthorizationManager();
+        public virtual bool CheckAccess(OperationContext operationContext);
+        public virtual bool CheckAccess(OperationContext operationContext, ref Message message);
+        protected virtual bool CheckAccessCore(OperationContext operationContext);
+        protected virtual ReadOnlyCollection<IAuthorizationPolicy> GetAuthorizationPolicies(OperationContext operationContext);
+    }
+    public sealed class ServiceBehaviorAttribute : Attribute, IServiceBehavior {
+        public ServiceBehaviorAttribute();
+        public AddressFilterMode AddressFilterMode { get; set; }
+        public bool AutomaticSessionShutdown { get; set; }
+        public ConcurrencyMode ConcurrencyMode { get; set; }
+        public string ConfigurationName { get; set; }
+        public bool EnsureOrderedDispatch { get; set; }
+        public bool IgnoreExtensionDataObject { get; set; }
+        public bool IncludeExceptionDetailInFaults { get; set; }
+        public InstanceContextMode InstanceContextMode { get; set; }
+        public int MaxItemsInObjectGraph { get; set; }
+        public string Name { get; set; }
+        public string Namespace { get; set; }
+        public bool ReleaseServiceInstanceOnTransactionComplete { get; set; }
+        public bool TransactionAutoCompleteOnSessionClose { get; set; }
+        public IsolationLevel TransactionIsolationLevel { get; set; }
+        public string TransactionTimeout { get; set; }
+        public bool UseSynchronizationContext { get; set; }
+        public bool ValidateMustUnderstand { get; set; }
+        public object GetWellKnownSingleton();
+        public void SetWellKnownSingleton(object value);
+        public bool ShouldSerializeConfigurationName();
+        public bool ShouldSerializeReleaseServiceInstanceOnTransactionComplete();
+        public bool ShouldSerializeTransactionAutoCompleteOnSessionClose();
+        public bool ShouldSerializeTransactionIsolationLevel();
+        public bool ShouldSerializeTransactionTimeout();
+        void System.ServiceModel.Description.IServiceBehavior.AddBindingParameters(ServiceDescription description, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection parameters);
+        void System.ServiceModel.Description.IServiceBehavior.ApplyDispatchBehavior(ServiceDescription description, ServiceHostBase serviceHostBase);
+        void System.ServiceModel.Description.IServiceBehavior.Validate(ServiceDescription description, ServiceHostBase serviceHostBase);
+    }
+    public class ServiceConfiguration {
+        public ServiceAuthenticationBehavior Authentication { get; }
+        public ServiceAuthorizationBehavior Authorization { get; }
+        public ReadOnlyCollection<Uri> BaseAddresses { get; }
+        public TimeSpan CloseTimeout { get; set; }
+        public ServiceCredentials Credentials { get; }
+        public ServiceDescription Description { get; }
+        public IdentityConfiguration IdentityConfiguration { get; set; }
+        public TimeSpan OpenTimeout { get; set; }
+        public bool UseIdentityConfiguration { get; set; }
+        public void AddServiceEndpoint(ServiceEndpoint endpoint);
+        public ServiceEndpoint AddServiceEndpoint(Type contractType, Binding binding, string address);
+        public ServiceEndpoint AddServiceEndpoint(Type contractType, Binding binding, string address, Uri listenUri);
+        public ServiceEndpoint AddServiceEndpoint(Type contractType, Binding binding, Uri address);
+        public ServiceEndpoint AddServiceEndpoint(Type contractType, Binding binding, Uri address, Uri listenUri);
+        public Collection<ServiceEndpoint> EnableProtocol(Binding protocol);
+        public void LoadFromConfiguration();
+        public void LoadFromConfiguration(Configuration configuration);
+        public void SetEndpointAddress(ServiceEndpoint endpoint, string relativeAddress);
+    }
+    public sealed class ServiceContractAttribute : Attribute {
+        public ServiceContractAttribute();
+        public Type CallbackContract { get; set; }
+        public string ConfigurationName { get; set; }
+        public bool HasProtectionLevel { get; }
+        public string Name { get; set; }
+        public string Namespace { get; set; }
+        public ProtectionLevel ProtectionLevel { get; set; }
+        public SessionMode SessionMode { get; set; }
+    }
+    public class ServiceHost : ServiceHostBase {
+        protected ServiceHost();
+        public ServiceHost(object singletonInstance, params Uri[] baseAddresses);
+        public ServiceHost(Type serviceType, params Uri[] baseAddresses);
+        public object SingletonInstance { get; }
+        public ServiceEndpoint AddServiceEndpoint(Type implementedContract, Binding binding, string address);
+        public ServiceEndpoint AddServiceEndpoint(Type implementedContract, Binding binding, string address, Uri listenUri);
+        public ServiceEndpoint AddServiceEndpoint(Type implementedContract, Binding binding, Uri address);
+        public ServiceEndpoint AddServiceEndpoint(Type implementedContract, Binding binding, Uri address, Uri listenUri);
+        protected override void ApplyConfiguration();
+        protected override ServiceDescription CreateDescription(out IDictionary<string, ContractDescription> implementedContracts);
+        protected void InitializeDescription(object singletonInstance, UriSchemeKeyedCollection baseAddresses);
+        protected void InitializeDescription(Type serviceType, UriSchemeKeyedCollection baseAddresses);
+        protected override void OnClosed();
+    }
+    public abstract class ServiceHostBase : CommunicationObject, IDisposable, IExtensibleObject<ServiceHostBase> {
+        protected ServiceHostBase();
+        public ServiceAuthenticationBehavior Authentication { get; }
+        public ServiceAuthorizationBehavior Authorization { get; }
+        public ReadOnlyCollection<Uri> BaseAddresses { get; }
+        public ChannelDispatcherCollection ChannelDispatchers { get; }
+        public TimeSpan CloseTimeout { get; set; }
+        public ServiceCredentials Credentials { get; }
+        protected override TimeSpan DefaultCloseTimeout { get; }
+        protected override TimeSpan DefaultOpenTimeout { get; }
+        public ServiceDescription Description { get; }
+        public IExtensionCollection<ServiceHostBase> Extensions { get; }
+        protected internal IDictionary<string, ContractDescription> ImplementedContracts { get; }
+        public int ManualFlowControlLimit { get; set; }
+        public TimeSpan OpenTimeout { get; set; }
+        public event EventHandler<UnknownMessageReceivedEventArgs> UnknownMessageReceived;
+        protected void AddBaseAddress(Uri baseAddress);
+        public virtual ReadOnlyCollection<ServiceEndpoint> AddDefaultEndpoints();
+        public virtual void AddServiceEndpoint(ServiceEndpoint endpoint);
+        public ServiceEndpoint AddServiceEndpoint(string implementedContract, Binding binding, string address);
+        public ServiceEndpoint AddServiceEndpoint(string implementedContract, Binding binding, string address, Uri listenUri);
+        public ServiceEndpoint AddServiceEndpoint(string implementedContract, Binding binding, Uri address);
+        public ServiceEndpoint AddServiceEndpoint(string implementedContract, Binding binding, Uri address, Uri listenUri);
+        protected virtual void ApplyConfiguration();
+        protected abstract ServiceDescription CreateDescription(out IDictionary<string, ContractDescription> implementedContracts);
+        public int IncrementManualFlowControlLimit(int incrementBy);
+        protected void InitializeDescription(UriSchemeKeyedCollection baseAddresses);
+        protected virtual void InitializeRuntime();
+        protected void LoadConfigurationSection(ServiceElement serviceSection);
+        protected override void OnAbort();
+        protected override IAsyncResult OnBeginClose(TimeSpan timeout, AsyncCallback callback, object state);
+        protected override IAsyncResult OnBeginOpen(TimeSpan timeout, AsyncCallback callback, object state);
+        protected override void OnClose(TimeSpan timeout);
+        protected override void OnClosed();
+        protected override void OnEndClose(IAsyncResult result);
+        protected override void OnEndOpen(IAsyncResult result);
+        protected override void OnOpen(TimeSpan timeout);
+        protected override void OnOpened();
+        protected void ReleasePerformanceCounters();
+        public void SetEndpointAddress(ServiceEndpoint endpoint, string relativeAddress);
+        void System.IDisposable.Dispose();
+    }
+    public static class ServiceHostingEnvironment {
+        public static bool AspNetCompatibilityEnabled { get; }
+        public static bool MultipleSiteBindingsEnabled { get; }
+        public static void EnsureInitialized();
+        public static void EnsureServiceAvailable(string virtualPath);
+    }
+    public sealed class ServiceKnownTypeAttribute : Attribute {
+        public ServiceKnownTypeAttribute(string methodName);
+        public ServiceKnownTypeAttribute(string methodName, Type declaringType);
+        public ServiceKnownTypeAttribute(Type type);
+        public Type DeclaringType { get; }
+        public string MethodName { get; }
+        public Type Type { get; }
+    }
+    public class ServiceSecurityContext {
+        public ServiceSecurityContext(ReadOnlyCollection<IAuthorizationPolicy> authorizationPolicies);
+        public ServiceSecurityContext(AuthorizationContext authorizationContext);
+        public ServiceSecurityContext(AuthorizationContext authorizationContext, ReadOnlyCollection<IAuthorizationPolicy> authorizationPolicies);
+        public static ServiceSecurityContext Anonymous { get; }
+        public AuthorizationContext AuthorizationContext { get; }
+        public ReadOnlyCollection<IAuthorizationPolicy> AuthorizationPolicies { get; set; }
+        public static ServiceSecurityContext Current { get; }
+        public bool IsAnonymous { get; }
+        public IIdentity PrimaryIdentity { get; }
+        public WindowsIdentity WindowsIdentity { get; }
+    }
+    public enum SessionMode {
+        Allowed = 0,
+        NotAllowed = 2,
+        Required = 1,
+    }
+    public class SpnEndpointIdentity : EndpointIdentity {
+        public SpnEndpointIdentity(Claim identity);
+        public SpnEndpointIdentity(string spnName);
+        public static TimeSpan SpnLookupTime { get; set; }
+    }
+    public enum TcpClientCredentialType {
+        Certificate = 2,
+        None = 0,
+        Windows = 1,
+    }
+    public sealed class TcpTransportSecurity {
+        public TcpTransportSecurity();
+        public TcpClientCredentialType ClientCredentialType { get; set; }
+        public ExtendedProtectionPolicy ExtendedProtectionPolicy { get; set; }
+        public ProtectionLevel ProtectionLevel { get; set; }
+        public SslProtocols SslProtocols { get; set; }
+        public bool ShouldSerializeExtendedProtectionPolicy();
+    }
+    public sealed class TransactionFlowAttribute : Attribute, IOperationBehavior {
+        public TransactionFlowAttribute(TransactionFlowOption transactions);
+        public TransactionFlowOption Transactions { get; }
+        void System.ServiceModel.Description.IOperationBehavior.AddBindingParameters(OperationDescription description, BindingParameterCollection parameters);
+        void System.ServiceModel.Description.IOperationBehavior.ApplyClientBehavior(OperationDescription description, ClientOperation proxy);
+        void System.ServiceModel.Description.IOperationBehavior.ApplyDispatchBehavior(OperationDescription description, DispatchOperation dispatch);
+        void System.ServiceModel.Description.IOperationBehavior.Validate(OperationDescription description);
+    }
+    public enum TransactionFlowOption {
+        Allowed = 1,
+        Mandatory = 2,
+        NotAllowed = 0,
+    }
+    public abstract class TransactionProtocol {
+        protected TransactionProtocol();
+        public static TransactionProtocol Default { get; }
+        public static TransactionProtocol OleTransactions { get; }
+        public static TransactionProtocol WSAtomicTransaction11 { get; }
+        public static TransactionProtocol WSAtomicTransactionOctober2004 { get; }
+    }
+    public enum TransferMode {
+        Buffered = 0,
+        Streamed = 1,
+        StreamedRequest = 2,
+        StreamedResponse = 3,
+    }
+    public class UdpBinding : Binding, IBindingRuntimePreferences {
+        public UdpBinding();
+        public UdpBinding(string configurationName);
+        public int DuplicateMessageHistoryLength { get; set; }
+        public long MaxBufferPoolSize { get; set; }
+        public long MaxPendingMessagesTotalSize { get; set; }
+        public long MaxReceivedMessageSize { get; set; }
+        public int MaxRetransmitCount { get; set; }
+        public string MulticastInterfaceId { get; set; }
+        public XmlDictionaryReaderQuotas ReaderQuotas { get; set; }
+        public override string Scheme { get; }
+        bool System.ServiceModel.Channels.IBindingRuntimePreferences.ReceiveSynchronously { get; }
+        public Encoding TextEncoding { get; set; }
+        public int TimeToLive { get; set; }
+        public override BindingElementCollection CreateBindingElements();
+        public bool ShouldSerializeReaderQuotas();
+        public bool ShouldSerializeTextEncoding();
+    }
+    public sealed class UnknownMessageReceivedEventArgs : EventArgs {
+        public Message Message { get; }
+    }
+    public class UpnEndpointIdentity : EndpointIdentity {
+        public UpnEndpointIdentity(Claim identity);
+        public UpnEndpointIdentity(string upnName);
+    }
+    public class UriSchemeKeyedCollection : SynchronizedKeyedCollection<string, Uri> {
+        public UriSchemeKeyedCollection(params Uri[] addresses);
+        protected override string GetKeyForItem(Uri item);
+        protected override void InsertItem(int index, Uri item);
+        protected override void SetItem(int index, Uri item);
+    }
+    public class WebHttpBinding : Binding, IBindingRuntimePreferences {
+        public WebHttpBinding();
+        public WebHttpBinding(WebHttpSecurityMode securityMode);
+        public WebHttpBinding(string configurationName);
+        public bool AllowCookies { get; set; }
+        public bool BypassProxyOnLocal { get; set; }
+        public WebContentTypeMapper ContentTypeMapper { get; set; }
+        public bool CrossDomainScriptAccessEnabled { get; set; }
+        public EnvelopeVersion EnvelopeVersion { get; }
+        public HostNameComparisonMode HostNameComparisonMode { get; set; }
+        public long MaxBufferPoolSize { get; set; }
+        public int MaxBufferSize { get; set; }
+        public long MaxReceivedMessageSize { get; set; }
+        public Uri ProxyAddress { get; set; }
+        public XmlDictionaryReaderQuotas ReaderQuotas { get; set; }
+        public override string Scheme { get; }
+        public WebHttpSecurity Security { get; set; }
+        bool System.ServiceModel.Channels.IBindingRuntimePreferences.ReceiveSynchronously { get; }
+        public TransferMode TransferMode { get; set; }
+        public bool UseDefaultWebProxy { get; set; }
+        public Encoding WriteEncoding { get; set; }
+        public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingParameterCollection parameters);
+        public override BindingElementCollection CreateBindingElements();
+        public bool ShouldSerializeReaderQuotas();
+        public bool ShouldSerializeSecurity();
+        public bool ShouldSerializeWriteEncoding();
+    }
+    public sealed class WebHttpSecurity {
+        public WebHttpSecurity();
+        public WebHttpSecurityMode Mode { get; set; }
+        public HttpTransportSecurity Transport { get; set; }
+        public bool ShouldSerializeMode();
+        public bool ShouldSerializeTransport();
+    }
+    public enum WebHttpSecurityMode {
+        None = 0,
+        Transport = 1,
+        TransportCredentialOnly = 2,
+    }
+    public class WorkflowServiceHost : ServiceHostBase {
+        protected WorkflowServiceHost();
+        public WorkflowServiceHost(Stream workflowDefinition, Stream ruleDefinition, params Uri[] baseAddress);
+        public WorkflowServiceHost(Stream workflowDefinition, Stream ruleDefinition, ITypeProvider typeProvider, params Uri[] baseAddress);
+        public WorkflowServiceHost(Stream workflowDefinition, params Uri[] baseAddress);
+        public WorkflowServiceHost(string workflowDefinitionPath, string ruleDefinitionPath, params Uri[] baseAddress);
+        public WorkflowServiceHost(string workflowDefinitionPath, string ruleDefinitionPath, ITypeProvider typeProvider, params Uri[] baseAddress);
+        public WorkflowServiceHost(string workflowDefinitionPath, params Uri[] baseAddress);
+        public WorkflowServiceHost(Type workflowType, params Uri[] baseAddress);
+        public ServiceEndpoint AddServiceEndpoint(Type implementedContract, Binding binding, string address);
+        public ServiceEndpoint AddServiceEndpoint(Type implementedContract, Binding binding, string address, Uri listenUri);
+        public ServiceEndpoint AddServiceEndpoint(Type implementedContract, Binding binding, Uri address);
+        public ServiceEndpoint AddServiceEndpoint(Type implementedContract, Binding binding, Uri address, Uri listenUri);
+        protected override ServiceDescription CreateDescription(out IDictionary<string, ContractDescription> implementedContracts);
+        protected override void OnClosing();
+    }
+    public class WS2007FederationHttpBinding : WSFederationHttpBinding {
+        public WS2007FederationHttpBinding();
+        public WS2007FederationHttpBinding(WSFederationHttpSecurityMode securityMode);
+        public WS2007FederationHttpBinding(WSFederationHttpSecurityMode securityMode, bool reliableSessionEnabled);
+        public WS2007FederationHttpBinding(string configName);
+        protected override SecurityBindingElement CreateMessageSecurity();
+    }
+    public class WS2007HttpBinding : WSHttpBinding {
+        public WS2007HttpBinding();
+        public WS2007HttpBinding(SecurityMode securityMode);
+        public WS2007HttpBinding(SecurityMode securityMode, bool reliableSessionEnabled);
+        public WS2007HttpBinding(string configName);
+        protected override SecurityBindingElement CreateMessageSecurity();
+    }
+    public class WSDualHttpBinding : Binding, IBindingRuntimePreferences {
+        public WSDualHttpBinding();
+        public WSDualHttpBinding(WSDualHttpSecurityMode securityMode);
+        public WSDualHttpBinding(string configName);
+        public bool BypassProxyOnLocal { get; set; }
+        public Uri ClientBaseAddress { get; set; }
+        public EnvelopeVersion EnvelopeVersion { get; }
+        public HostNameComparisonMode HostNameComparisonMode { get; set; }
+        public long MaxBufferPoolSize { get; set; }
+        public long MaxReceivedMessageSize { get; set; }
+        public WSMessageEncoding MessageEncoding { get; set; }
+        public Uri ProxyAddress { get; set; }
+        public XmlDictionaryReaderQuotas ReaderQuotas { get; set; }
+        public ReliableSession ReliableSession { get; set; }
+        public override string Scheme { get; }
+        public WSDualHttpSecurity Security { get; set; }
+        bool System.ServiceModel.Channels.IBindingRuntimePreferences.ReceiveSynchronously { get; }
+        public Encoding TextEncoding { get; set; }
+        public bool TransactionFlow { get; set; }
+        public bool UseDefaultWebProxy { get; set; }
+        public override BindingElementCollection CreateBindingElements();
+        public bool ShouldSerializeReaderQuotas();
+        public bool ShouldSerializeReliableSession();
+        public bool ShouldSerializeSecurity();
+        public bool ShouldSerializeTextEncoding();
+    }
+    public sealed class WSDualHttpSecurity {
+        public WSDualHttpSecurity();
+        public MessageSecurityOverHttp Message { get; set; }
+        public WSDualHttpSecurityMode Mode { get; set; }
+        public bool ShouldSerializeMessage();
+        public bool ShouldSerializeMode();
+    }
+    public enum WSDualHttpSecurityMode {
+        Message = 1,
+        None = 0,
+    }
+    public class WSFederationHttpBinding : WSHttpBindingBase {
+        public WSFederationHttpBinding();
+        public WSFederationHttpBinding(WSFederationHttpSecurityMode securityMode);
+        public WSFederationHttpBinding(WSFederationHttpSecurityMode securityMode, bool reliableSessionEnabled);
+        public WSFederationHttpBinding(string configName);
+        public Uri PrivacyNoticeAt { get; set; }
+        public int PrivacyNoticeVersion { get; set; }
+        public WSFederationHttpSecurity Security { get; set; }
+        public override BindingElementCollection CreateBindingElements();
+        protected override SecurityBindingElement CreateMessageSecurity();
+        protected override TransportBindingElement GetTransport();
+        public bool ShouldSerializeSecurity();
+    }
+    public sealed class WSFederationHttpSecurity {
+        public WSFederationHttpSecurity();
+        public FederatedMessageSecurityOverHttp Message { get; set; }
+        public WSFederationHttpSecurityMode Mode { get; set; }
+        public bool ShouldSerializeMessage();
+        public bool ShouldSerializeMode();
+    }
+    public enum WSFederationHttpSecurityMode {
+        Message = 1,
+        None = 0,
+        TransportWithMessageCredential = 2,
+    }
+    public class WSHttpBinding : WSHttpBindingBase {
+        public WSHttpBinding();
+        public WSHttpBinding(SecurityMode securityMode);
+        public WSHttpBinding(SecurityMode securityMode, bool reliableSessionEnabled);
+        public WSHttpBinding(string configName);
+        public bool AllowCookies { get; set; }
+        public WSHttpSecurity Security { get; set; }
+        public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingParameterCollection parameters);
+        public override BindingElementCollection CreateBindingElements();
+        protected override SecurityBindingElement CreateMessageSecurity();
+        protected override TransportBindingElement GetTransport();
+        public bool ShouldSerializeSecurity();
+    }
+    public abstract class WSHttpBindingBase : Binding, IBindingRuntimePreferences {
+        protected WSHttpBindingBase();
+        protected WSHttpBindingBase(bool reliableSessionEnabled);
+        public bool BypassProxyOnLocal { get; set; }
+        public EnvelopeVersion EnvelopeVersion { get; }
+        public HostNameComparisonMode HostNameComparisonMode { get; set; }
+        public long MaxBufferPoolSize { get; set; }
+        public long MaxReceivedMessageSize { get; set; }
+        public WSMessageEncoding MessageEncoding { get; set; }
+        public Uri ProxyAddress { get; set; }
+        public XmlDictionaryReaderQuotas ReaderQuotas { get; set; }
+        public OptionalReliableSession ReliableSession { get; set; }
+        public override string Scheme { get; }
+        bool System.ServiceModel.Channels.IBindingRuntimePreferences.ReceiveSynchronously { get; }
+        public Encoding TextEncoding { get; set; }
+        public bool TransactionFlow { get; set; }
+        public bool UseDefaultWebProxy { get; set; }
+        public override BindingElementCollection CreateBindingElements();
+        protected abstract SecurityBindingElement CreateMessageSecurity();
+        protected abstract TransportBindingElement GetTransport();
+        public bool ShouldSerializeReaderQuotas();
+        public bool ShouldSerializeReliableSession();
+        public bool ShouldSerializeTextEncoding();
+    }
+    public class WSHttpContextBinding : WSHttpBinding {
+        public WSHttpContextBinding();
+        public WSHttpContextBinding(SecurityMode securityMode);
+        public WSHttpContextBinding(SecurityMode securityMode, bool reliableSessionEnabled);
+        public WSHttpContextBinding(string configName);
+        public Uri ClientCallbackAddress { get; set; }
+        public bool ContextManagementEnabled { get; set; }
+        public ProtectionLevel ContextProtectionLevel { get; set; }
+        public override BindingElementCollection CreateBindingElements();
+    }
+    public sealed class WSHttpSecurity {
+        public WSHttpSecurity();
+        public NonDualMessageSecurityOverHttp Message { get; set; }
+        public SecurityMode Mode { get; set; }
+        public HttpTransportSecurity Transport { get; set; }
+        public bool ShouldSerializeMessage();
+        public bool ShouldSerializeMode();
+        public bool ShouldSerializeTransport();
+    }
+    public enum WSMessageEncoding {
+        Mtom = 1,
+        Text = 0,
+    }
+    public class X509CertificateEndpointIdentity : EndpointIdentity {
+        public X509CertificateEndpointIdentity(X509Certificate2 certificate);
+        public X509CertificateEndpointIdentity(X509Certificate2 primaryCertificate, X509Certificate2Collection supportingCertificates);
+        public X509Certificate2Collection Certificates { get; }
+    }
+    public sealed class XmlSerializerFormatAttribute : Attribute {
+        public XmlSerializerFormatAttribute();
+        public OperationFormatStyle Style { get; set; }
+        public bool SupportFaults { get; set; }
+        public OperationFormatUse Use { get; set; }
+    }
+    public class XPathMessageQuery : MessageQuery {
+        public XPathMessageQuery();
+        public XPathMessageQuery(string expression);
+        public XPathMessageQuery(string expression, XmlNamespaceManager namespaces);
+        public XPathMessageQuery(string expression, XsltContext context);
+        public string Expression { get; set; }
+        public XmlNamespaceManager Namespaces { get; set; }
+        public override MessageQueryCollection CreateMessageQueryCollection();
+        public override TResult Evaluate<TResult>(Message message);
+        public override TResult Evaluate<TResult>(MessageBuffer buffer);
+    }
+}
```

