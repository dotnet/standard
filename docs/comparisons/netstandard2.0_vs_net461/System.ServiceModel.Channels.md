# System.ServiceModel.Channels

``` diff
+namespace System.ServiceModel.Channels {
+    public abstract class AddressHeader {
+        protected AddressHeader();
+        public abstract string Name { get; }
+        public abstract string Namespace { get; }
+        public static AddressHeader CreateAddressHeader(object value);
+        public static AddressHeader CreateAddressHeader(object value, XmlObjectSerializer serializer);
+        public static AddressHeader CreateAddressHeader(string name, string ns, object value);
+        public static AddressHeader CreateAddressHeader(string name, string ns, object value, XmlObjectSerializer serializer);
+        public override bool Equals(object obj);
+        public virtual XmlDictionaryReader GetAddressHeaderReader();
+        public override int GetHashCode();
+        public T GetValue<T>();
+        public T GetValue<T>(XmlObjectSerializer serializer);
+        protected abstract void OnWriteAddressHeaderContents(XmlDictionaryWriter writer);
+        protected virtual void OnWriteStartAddressHeader(XmlDictionaryWriter writer);
+        public MessageHeader ToMessageHeader();
+        public void WriteAddressHeader(XmlDictionaryWriter writer);
+        public void WriteAddressHeader(XmlWriter writer);
+        public void WriteAddressHeaderContents(XmlDictionaryWriter writer);
+        public void WriteStartAddressHeader(XmlDictionaryWriter writer);
+    }
+    public sealed class AddressHeaderCollection : ReadOnlyCollection<AddressHeader> {
+        public AddressHeaderCollection();
+        public AddressHeaderCollection(IEnumerable<AddressHeader> addressHeaders);
+        public void AddHeadersTo(Message message);
+        public AddressHeader[] FindAll(string name, string ns);
+        public AddressHeader FindHeader(string name, string ns);
+    }
+    public sealed class AddressingVersion {
+        public static AddressingVersion None { get; }
+        public static AddressingVersion WSAddressing10 { get; }
+        public static AddressingVersion WSAddressingAugust2004 { get; }
+        public override string ToString();
+    }
+    public sealed class ApplicationContainerSettings {
+        public const int CurrentSession = -1;
+        public const int ServiceSession = 0;
+        public string PackageFullName { get; set; }
+        public int SessionId { get; set; }
+    }
+    public sealed class AsymmetricSecurityBindingElement : SecurityBindingElement, IPolicyExportExtension {
+        public AsymmetricSecurityBindingElement();
+        public AsymmetricSecurityBindingElement(SecurityTokenParameters recipientTokenParameters);
+        public AsymmetricSecurityBindingElement(SecurityTokenParameters recipientTokenParameters, SecurityTokenParameters initiatorTokenParameters);
+        public bool AllowSerializedSigningTokenOnReply { get; set; }
+        public SecurityTokenParameters InitiatorTokenParameters { get; set; }
+        public MessageProtectionOrder MessageProtectionOrder { get; set; }
+        public SecurityTokenParameters RecipientTokenParameters { get; set; }
+        public bool RequireSignatureConfirmation { get; set; }
+        protected override IChannelFactory<TChannel> BuildChannelFactoryCore<TChannel>(BindingContext context);
+        protected override IChannelListener<TChannel> BuildChannelListenerCore<TChannel>(BindingContext context);
+        public override BindingElement Clone();
+        public override T GetProperty<T>(BindingContext context);
+        public override void SetKeyDerivation(bool requireDerivedKeys);
+        void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(MetadataExporter exporter, PolicyConversionContext context);
+        public override string ToString();
+    }
+    public sealed class BinaryMessageEncodingBindingElement : MessageEncodingBindingElement, IPolicyExportExtension, IWsdlExportExtension {
+        public BinaryMessageEncodingBindingElement();
+        public CompressionFormat CompressionFormat { get; set; }
+        public int MaxReadPoolSize { get; set; }
+        public int MaxSessionSize { get; set; }
+        public int MaxWritePoolSize { get; set; }
+        public override MessageVersion MessageVersion { get; set; }
+        public XmlDictionaryReaderQuotas ReaderQuotas { get; set; }
+        public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context);
+        public override IChannelListener<TChannel> BuildChannelListener<TChannel>(BindingContext context);
+        public override bool CanBuildChannelListener<TChannel>(BindingContext context);
+        public override BindingElement Clone();
+        public override MessageEncoderFactory CreateMessageEncoderFactory();
+        public override T GetProperty<T>(BindingContext context);
+        public bool ShouldSerializeMessageVersion();
+        public bool ShouldSerializeReaderQuotas();
+        void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(MetadataExporter exporter, PolicyConversionContext policyContext);
+        void System.ServiceModel.Description.IWsdlExportExtension.ExportContract(WsdlExporter exporter, WsdlContractConversionContext context);
+        void System.ServiceModel.Description.IWsdlExportExtension.ExportEndpoint(WsdlExporter exporter, WsdlEndpointConversionContext context);
+    }
+    public abstract class Binding : IDefaultCommunicationTimeouts {
+        protected Binding();
+        protected Binding(string name, string ns);
+        public TimeSpan CloseTimeout { get; set; }
+        public MessageVersion MessageVersion { get; }
+        public string Name { get; set; }
+        public string Namespace { get; set; }
+        public TimeSpan OpenTimeout { get; set; }
+        public TimeSpan ReceiveTimeout { get; set; }
+        public abstract string Scheme { get; }
+        public TimeSpan SendTimeout { get; set; }
+        public IChannelFactory<TChannel> BuildChannelFactory<TChannel>(params object[] parameters);
+        public virtual IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingParameterCollection parameters);
+        public virtual IChannelListener<TChannel> BuildChannelListener<TChannel>(params object[] parameters) where TChannel : class, IChannel;
+        public virtual IChannelListener<TChannel> BuildChannelListener<TChannel>(BindingParameterCollection parameters) where TChannel : class, IChannel;
+        public virtual IChannelListener<TChannel> BuildChannelListener<TChannel>(Uri listenUriBaseAddress, params object[] parameters) where TChannel : class, IChannel;
+        public virtual IChannelListener<TChannel> BuildChannelListener<TChannel>(Uri listenUriBaseAddress, BindingParameterCollection parameters) where TChannel : class, IChannel;
+        public virtual IChannelListener<TChannel> BuildChannelListener<TChannel>(Uri listenUriBaseAddress, string listenUriRelativeAddress, params object[] parameters) where TChannel : class, IChannel;
+        public virtual IChannelListener<TChannel> BuildChannelListener<TChannel>(Uri listenUriBaseAddress, string listenUriRelativeAddress, BindingParameterCollection parameters) where TChannel : class, IChannel;
+        public virtual IChannelListener<TChannel> BuildChannelListener<TChannel>(Uri listenUriBaseAddress, string listenUriRelativeAddress, ListenUriMode listenUriMode, params object[] parameters) where TChannel : class, IChannel;
+        public virtual IChannelListener<TChannel> BuildChannelListener<TChannel>(Uri listenUriBaseAddress, string listenUriRelativeAddress, ListenUriMode listenUriMode, BindingParameterCollection parameters) where TChannel : class, IChannel;
+        public bool CanBuildChannelFactory<TChannel>(params object[] parameters);
+        public virtual bool CanBuildChannelFactory<TChannel>(BindingParameterCollection parameters);
+        public bool CanBuildChannelListener<TChannel>(params object[] parameters) where TChannel : class, IChannel;
+        public virtual bool CanBuildChannelListener<TChannel>(BindingParameterCollection parameters) where TChannel : class, IChannel;
+        public abstract BindingElementCollection CreateBindingElements();
+        public T GetProperty<T>(BindingParameterCollection parameters) where T : class;
+        public bool ShouldSerializeName();
+        public bool ShouldSerializeNamespace();
+    }
+    public class BindingContext {
+        public BindingContext(CustomBinding binding, BindingParameterCollection parameters);
+        public BindingContext(CustomBinding binding, BindingParameterCollection parameters, Uri listenUriBaseAddress, string listenUriRelativeAddress, ListenUriMode listenUriMode);
+        public CustomBinding Binding { get; }
+        public BindingParameterCollection BindingParameters { get; }
+        public Uri ListenUriBaseAddress { get; set; }
+        public ListenUriMode ListenUriMode { get; set; }
+        public string ListenUriRelativeAddress { get; set; }
+        public BindingElementCollection RemainingBindingElements { get; }
+        public IChannelFactory<TChannel> BuildInnerChannelFactory<TChannel>();
+        public IChannelListener<TChannel> BuildInnerChannelListener<TChannel>() where TChannel : class, IChannel;
+        public bool CanBuildInnerChannelFactory<TChannel>();
+        public bool CanBuildInnerChannelListener<TChannel>() where TChannel : class, IChannel;
+        public BindingContext Clone();
+        public T GetInnerProperty<T>() where T : class;
+    }
+    public abstract class BindingElement {
+        protected BindingElement();
+        protected BindingElement(BindingElement elementToBeCloned);
+        public virtual IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context);
+        public virtual IChannelListener<TChannel> BuildChannelListener<TChannel>(BindingContext context) where TChannel : class, IChannel;
+        public virtual bool CanBuildChannelFactory<TChannel>(BindingContext context);
+        public virtual bool CanBuildChannelListener<TChannel>(BindingContext context) where TChannel : class, IChannel;
+        public abstract BindingElement Clone();
+        public abstract T GetProperty<T>(BindingContext context) where T : class;
+    }
+    public class BindingElementCollection : Collection<BindingElement> {
+        public BindingElementCollection();
+        public BindingElementCollection(IEnumerable<BindingElement> elements);
+        public BindingElementCollection(BindingElement[] elements);
+        public void AddRange(params BindingElement[] elements);
+        public BindingElementCollection Clone();
+        public bool Contains(Type bindingElementType);
+        public T Find<T>();
+        public Collection<T> FindAll<T>();
+        protected override void InsertItem(int index, BindingElement item);
+        public T Remove<T>();
+        public Collection<T> RemoveAll<T>();
+        protected override void SetItem(int index, BindingElement item);
+    }
+    public class BindingParameterCollection : KeyedByTypeCollection<object> {
+        public BindingParameterCollection();
+    }
+    public abstract class BodyWriter {
+        protected BodyWriter(bool isBuffered);
+        public bool IsBuffered { get; }
+        public IAsyncResult BeginWriteBodyContents(XmlDictionaryWriter writer, AsyncCallback callback, object state);
+        public BodyWriter CreateBufferedCopy(int maxBufferSize);
+        public void EndWriteBodyContents(IAsyncResult result);
+        protected virtual IAsyncResult OnBeginWriteBodyContents(XmlDictionaryWriter writer, AsyncCallback callback, object state);
+        protected virtual BodyWriter OnCreateBufferedCopy(int maxBufferSize);
+        protected virtual void OnEndWriteBodyContents(IAsyncResult result);
+        protected abstract void OnWriteBodyContents(XmlDictionaryWriter writer);
+        public void WriteBodyContents(XmlDictionaryWriter writer);
+    }
+    public abstract class BufferManager {
+        protected BufferManager();
+        public abstract void Clear();
+        public static BufferManager CreateBufferManager(long maxBufferPoolSize, int maxBufferSize);
+        public abstract void ReturnBuffer(byte[] buffer);
+        public abstract byte[] TakeBuffer(int bufferSize);
+    }
+    public static class ByteStreamMessage {
+        public static Message CreateMessage(ArraySegment<byte> buffer);
+        public static Message CreateMessage(ArraySegment<byte> buffer, BufferManager bufferManager);
+        public static Message CreateMessage(Stream stream);
+    }
+    public sealed class ByteStreamMessageEncodingBindingElement : MessageEncodingBindingElement {
+        public ByteStreamMessageEncodingBindingElement();
+        public ByteStreamMessageEncodingBindingElement(XmlDictionaryReaderQuotas quota);
+        public override MessageVersion MessageVersion { get; set; }
+        public XmlDictionaryReaderQuotas ReaderQuotas { get; set; }
+        public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context);
+        public override IChannelListener<TChannel> BuildChannelListener<TChannel>(BindingContext context);
+        public override bool CanBuildChannelFactory<TChannel>(BindingContext context);
+        public override bool CanBuildChannelListener<TChannel>(BindingContext context);
+        public override BindingElement Clone();
+        public override MessageEncoderFactory CreateMessageEncoderFactory();
+        public bool ShouldSerializeMessageVersion();
+        public bool ShouldSerializeReaderQuotas();
+    }
+    public class CallbackContextMessageProperty : IMessageProperty {
+        public CallbackContextMessageProperty(IDictionary<string, string> context);
+        public CallbackContextMessageProperty(EndpointAddress callbackAddress);
+        public CallbackContextMessageProperty(EndpointAddress listenAddress, IDictionary<string, string> context);
+        public CallbackContextMessageProperty(string listenAddress, IDictionary<string, string> context);
+        public CallbackContextMessageProperty(Uri listenAddress, IDictionary<string, string> context);
+        public EndpointAddress CallbackAddress { get; }
+        public IDictionary<string, string> Context { get; }
+        public static string Name { get; }
+        public void AddOrReplaceInMessage(Message message);
+        public void AddOrReplaceInMessageProperties(MessageProperties properties);
+        public EndpointAddress CreateCallbackAddress(Uri listenAddress);
+        public IMessageProperty CreateCopy();
+        public void GetListenAddressAndContext(out EndpointAddress listenAddress, out IDictionary<string, string> context);
+        public static bool TryGet(Message message, out CallbackContextMessageProperty contextMessageProperty);
+        public static bool TryGet(MessageProperties properties, out CallbackContextMessageProperty contextMessageProperty);
+    }
+    public abstract class ChannelBase : CommunicationObject, IChannel, ICommunicationObject, IDefaultCommunicationTimeouts {
+        protected ChannelBase(ChannelManagerBase channelManager);
+        protected override TimeSpan DefaultCloseTimeout { get; }
+        protected override TimeSpan DefaultOpenTimeout { get; }
+        protected TimeSpan DefaultReceiveTimeout { get; }
+        protected TimeSpan DefaultSendTimeout { get; }
+        protected ChannelManagerBase Manager { get; }
+        TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.CloseTimeout { get; }
+        TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.OpenTimeout { get; }
+        TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.ReceiveTimeout { get; }
+        TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.SendTimeout { get; }
+        public virtual T GetProperty<T>() where T : class;
+        protected override void OnClosed();
+    }
+    public abstract class ChannelFactoryBase : ChannelManagerBase, IChannelFactory, ICommunicationObject {
+        protected ChannelFactoryBase();
+        protected ChannelFactoryBase(IDefaultCommunicationTimeouts timeouts);
+        protected override TimeSpan DefaultCloseTimeout { get; }
+        protected override TimeSpan DefaultOpenTimeout { get; }
+        protected override TimeSpan DefaultReceiveTimeout { get; }
+        protected override TimeSpan DefaultSendTimeout { get; }
+        public virtual T GetProperty<T>() where T : class;
+        protected override void OnAbort();
+        protected override IAsyncResult OnBeginClose(TimeSpan timeout, AsyncCallback callback, object state);
+        protected override void OnClose(TimeSpan timeout);
+        protected override void OnEndClose(IAsyncResult result);
+    }
+    public abstract class ChannelFactoryBase<TChannel> : ChannelFactoryBase, IChannelFactory, IChannelFactory<TChannel>, ICommunicationObject {
+        protected ChannelFactoryBase();
+        protected ChannelFactoryBase(IDefaultCommunicationTimeouts timeouts);
+        public TChannel CreateChannel(EndpointAddress address);
+        public TChannel CreateChannel(EndpointAddress address, Uri via);
+        protected override void OnAbort();
+        protected override IAsyncResult OnBeginClose(TimeSpan timeout, AsyncCallback callback, object state);
+        protected override void OnClose(TimeSpan timeout);
+        protected abstract TChannel OnCreateChannel(EndpointAddress address, Uri via);
+        protected override void OnEndClose(IAsyncResult result);
+        protected void ValidateCreateChannel();
+    }
+    public abstract class ChannelListenerBase : ChannelManagerBase, IChannelListener, ICommunicationObject {
+        protected ChannelListenerBase();
+        protected ChannelListenerBase(IDefaultCommunicationTimeouts timeouts);
+        protected override TimeSpan DefaultCloseTimeout { get; }
+        protected override TimeSpan DefaultOpenTimeout { get; }
+        protected override TimeSpan DefaultReceiveTimeout { get; }
+        protected override TimeSpan DefaultSendTimeout { get; }
+        public abstract Uri Uri { get; }
+        public IAsyncResult BeginWaitForChannel(TimeSpan timeout, AsyncCallback callback, object state);
+        public bool EndWaitForChannel(IAsyncResult result);
+        public virtual T GetProperty<T>() where T : class;
+        protected abstract IAsyncResult OnBeginWaitForChannel(TimeSpan timeout, AsyncCallback callback, object state);
+        protected abstract bool OnEndWaitForChannel(IAsyncResult result);
+        protected abstract bool OnWaitForChannel(TimeSpan timeout);
+        public bool WaitForChannel(TimeSpan timeout);
+    }
+    public abstract class ChannelListenerBase<TChannel> : ChannelListenerBase, IChannelListener, IChannelListener<TChannel>, ICommunicationObject where TChannel : class, IChannel {
+        protected ChannelListenerBase();
+        protected ChannelListenerBase(IDefaultCommunicationTimeouts timeouts);
+        public TChannel AcceptChannel();
+        public TChannel AcceptChannel(TimeSpan timeout);
+        public IAsyncResult BeginAcceptChannel(AsyncCallback callback, object state);
+        public IAsyncResult BeginAcceptChannel(TimeSpan timeout, AsyncCallback callback, object state);
+        public TChannel EndAcceptChannel(IAsyncResult result);
+        protected abstract TChannel OnAcceptChannel(TimeSpan timeout);
+        protected abstract IAsyncResult OnBeginAcceptChannel(TimeSpan timeout, AsyncCallback callback, object state);
+        protected abstract TChannel OnEndAcceptChannel(IAsyncResult result);
+    }
+    public abstract class ChannelManagerBase : CommunicationObject, IDefaultCommunicationTimeouts {
+        protected ChannelManagerBase();
+        protected abstract TimeSpan DefaultReceiveTimeout { get; }
+        protected abstract TimeSpan DefaultSendTimeout { get; }
+        TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.CloseTimeout { get; }
+        TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.OpenTimeout { get; }
+        TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.ReceiveTimeout { get; }
+        TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.SendTimeout { get; }
+    }
+    public class ChannelParameterCollection : Collection<object> {
+        public ChannelParameterCollection();
+        public ChannelParameterCollection(IChannel channel);
+        protected virtual IChannel Channel { get; }
+        protected override void ClearItems();
+        protected override void InsertItem(int index, object item);
+        public void PropagateChannelParameters(IChannel innerChannel);
+        protected override void RemoveItem(int index);
+        protected override void SetItem(int index, object item);
+    }
+    public class ChannelPoolSettings {
+        public ChannelPoolSettings();
+        public TimeSpan IdleTimeout { get; set; }
+        public TimeSpan LeaseTimeout { get; set; }
+        public int MaxOutboundChannelsPerEndpoint { get; set; }
+    }
+    public abstract class ClientWebSocketFactory {
+        protected ClientWebSocketFactory();
+        public abstract string WebSocketVersion { get; }
+        public abstract WebSocket CreateWebSocket(Stream connection, WebSocketTransportSettings settings);
+    }
+    public abstract class CommunicationObject : ICommunicationObject {
+        protected CommunicationObject();
+        protected CommunicationObject(object mutex);
+        protected abstract TimeSpan DefaultCloseTimeout { get; }
+        protected abstract TimeSpan DefaultOpenTimeout { get; }
+        protected bool IsDisposed { get; }
+        public CommunicationState State { get; }
+        protected object ThisLock { get; }
+        public event EventHandler Closed;
+        public event EventHandler Closing;
+        public event EventHandler Faulted;
+        public event EventHandler Opened;
+        public event EventHandler Opening;
+        public void Abort();
+        public IAsyncResult BeginClose(AsyncCallback callback, object state);
+        public IAsyncResult BeginClose(TimeSpan timeout, AsyncCallback callback, object state);
+        public IAsyncResult BeginOpen(AsyncCallback callback, object state);
+        public IAsyncResult BeginOpen(TimeSpan timeout, AsyncCallback callback, object state);
+        public void Close();
+        public void Close(TimeSpan timeout);
+        public void EndClose(IAsyncResult result);
+        public void EndOpen(IAsyncResult result);
+        protected void Fault();
+        protected virtual Type GetCommunicationObjectType();
+        protected abstract void OnAbort();
+        protected abstract IAsyncResult OnBeginClose(TimeSpan timeout, AsyncCallback callback, object state);
+        protected abstract IAsyncResult OnBeginOpen(TimeSpan timeout, AsyncCallback callback, object state);
+        protected abstract void OnClose(TimeSpan timeout);
+        protected virtual void OnClosed();
+        protected virtual void OnClosing();
+        protected abstract void OnEndClose(IAsyncResult result);
+        protected abstract void OnEndOpen(IAsyncResult result);
+        protected virtual void OnFaulted();
+        protected abstract void OnOpen(TimeSpan timeout);
+        protected virtual void OnOpened();
+        protected virtual void OnOpening();
+        public void Open();
+        public void Open(TimeSpan timeout);
+        protected internal void ThrowIfDisposed();
+        protected internal void ThrowIfDisposedOrImmutable();
+        protected internal void ThrowIfDisposedOrNotOpen();
+    }
+    public sealed class CompositeDuplexBindingElement : BindingElement, IPolicyExportExtension {
+        public CompositeDuplexBindingElement();
+        public Uri ClientBaseAddress { get; set; }
+        public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context);
+        public override IChannelListener<TChannel> BuildChannelListener<TChannel>(BindingContext context);
+        public override bool CanBuildChannelFactory<TChannel>(BindingContext context);
+        public override bool CanBuildChannelListener<TChannel>(BindingContext context);
+        public override BindingElement Clone();
+        public override T GetProperty<T>(BindingContext context);
+        void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(MetadataExporter exporter, PolicyConversionContext context);
+    }
+    public class CompositeDuplexBindingElementImporter : IPolicyImportExtension {
+        public CompositeDuplexBindingElementImporter();
+        void System.ServiceModel.Description.IPolicyImportExtension.ImportPolicy(MetadataImporter importer, PolicyConversionContext context);
+    }
+    public enum CompressionFormat {
+        Deflate = 2,
+        GZip = 1,
+        None = 0,
+    }
+    public abstract class ConnectionOrientedTransportBindingElement : TransportBindingElement, IPolicyExportExtension, ITransportPolicyImport, IWsdlExportExtension {
+        public TimeSpan ChannelInitializationTimeout { get; set; }
+        public int ConnectionBufferSize { get; set; }
+        public HostNameComparisonMode HostNameComparisonMode { get; set; }
+        public int MaxBufferSize { get; set; }
+        public TimeSpan MaxOutputDelay { get; set; }
+        public int MaxPendingAccepts { get; set; }
+        public int MaxPendingConnections { get; set; }
+        public TransferMode TransferMode { get; set; }
+        public override bool CanBuildChannelFactory<TChannel>(BindingContext context);
+        public override bool CanBuildChannelListener<TChannel>(BindingContext context);
+        public override T GetProperty<T>(BindingContext context);
+        public bool ShouldSerializeMaxPendingAccepts();
+        public bool ShouldSerializeMaxPendingConnections();
+        void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(MetadataExporter exporter, PolicyConversionContext context);
+        void System.ServiceModel.Description.IWsdlExportExtension.ExportContract(WsdlExporter exporter, WsdlContractConversionContext context);
+        void System.ServiceModel.Description.IWsdlExportExtension.ExportEndpoint(WsdlExporter exporter, WsdlEndpointConversionContext endpointContext);
+    }
+    public class ContextBindingElement : BindingElement, IContextBindingElement, IContextSessionProvider, IPolicyExportExtension, IWmiInstanceProvider {
+        public ContextBindingElement();
+        public ContextBindingElement(ProtectionLevel protectionLevel);
+        public ContextBindingElement(ProtectionLevel protectionLevel, ContextExchangeMechanism contextExchangeMechanism);
+        public ContextBindingElement(ProtectionLevel protectionLevel, ContextExchangeMechanism contextExchangeMechanism, Uri clientCallbackAddress);
+        public ContextBindingElement(ProtectionLevel protectionLevel, ContextExchangeMechanism contextExchangeMechanism, Uri clientCallbackAddress, bool contextManagementEnabled);
+        public Uri ClientCallbackAddress { get; set; }
+        public ContextExchangeMechanism ContextExchangeMechanism { get; set; }
+        public bool ContextManagementEnabled { get; set; }
+        public ProtectionLevel ProtectionLevel { get; set; }
+        public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context);
+        public override IChannelListener<TChannel> BuildChannelListener<TChannel>(BindingContext context);
+        public override bool CanBuildChannelFactory<TChannel>(BindingContext context);
+        public override bool CanBuildChannelListener<TChannel>(BindingContext context);
+        public override BindingElement Clone();
+        public virtual void ExportPolicy(MetadataExporter exporter, PolicyConversionContext context);
+        public override T GetProperty<T>(BindingContext context);
+    }
+    public class ContextBindingElementImporter : IPolicyImportExtension, IWsdlImportExtension {
+        public ContextBindingElementImporter();
+        public void BeforeImport(ServiceDescriptionCollection wsdlDocuments, XmlSchemaSet xmlSchemas, ICollection<XmlElement> policy);
+        public void ImportContract(WsdlImporter importer, WsdlContractConversionContext context);
+        public void ImportEndpoint(WsdlImporter importer, WsdlEndpointConversionContext context);
+        public virtual void ImportPolicy(MetadataImporter importer, PolicyConversionContext context);
+    }
+    public enum ContextExchangeMechanism {
+        ContextSoapHeader = 0,
+        HttpCookie = 1,
+    }
+    public class ContextMessageProperty : IMessageProperty {
+        public ContextMessageProperty();
+        public ContextMessageProperty(IDictionary<string, string> context);
+        public IDictionary<string, string> Context { get; }
+        public static string Name { get; }
+        public void AddOrReplaceInMessage(Message message);
+        public void AddOrReplaceInMessageProperties(MessageProperties properties);
+        public IMessageProperty CreateCopy();
+        public static bool TryCreateFromHttpCookieHeader(string httpCookieHeader, out ContextMessageProperty context);
+        public static bool TryGet(Message message, out ContextMessageProperty contextMessageProperty);
+        public static bool TryGet(MessageProperties properties, out ContextMessageProperty contextMessageProperty);
+    }
+    public abstract class CorrelationCallbackMessageProperty : IMessageProperty {
+        protected CorrelationCallbackMessageProperty(ICollection<string> neededData);
+        protected CorrelationCallbackMessageProperty(CorrelationCallbackMessageProperty callback);
+        public bool IsFullyDefined { get; }
+        public static string Name { get; }
+        public IEnumerable<string> NeededData { get; }
+        public void AddData(string name, Func<string> value);
+        public IAsyncResult BeginFinalizeCorrelation(Message message, TimeSpan timeout, AsyncCallback callback, object state);
+        public abstract IMessageProperty CreateCopy();
+        public Message EndFinalizeCorrelation(IAsyncResult result);
+        public Message FinalizeCorrelation(Message message, TimeSpan timeout);
+        protected abstract IAsyncResult OnBeginFinalizeCorrelation(Message message, TimeSpan timeout, AsyncCallback callback, object state);
+        protected abstract Message OnEndFinalizeCorrelation(IAsyncResult result);
+        protected abstract Message OnFinalizeCorrelation(Message message, TimeSpan timeout);
+        public static bool TryGet(Message message, out CorrelationCallbackMessageProperty property);
+        public static bool TryGet(MessageProperties properties, out CorrelationCallbackMessageProperty property);
+    }
+    public abstract class CorrelationDataDescription {
+        protected CorrelationDataDescription();
+        public abstract bool IsDefault { get; }
+        public abstract bool IsOptional { get; }
+        public abstract bool KnownBeforeSend { get; }
+        public abstract string Name { get; }
+        public abstract bool ReceiveValue { get; }
+        public abstract bool SendValue { get; }
+    }
+    public class CorrelationDataMessageProperty : IMessageProperty {
+        public CorrelationDataMessageProperty();
+        public static string Name { get; }
+        public void Add(string name, Func<string> dataProvider);
+        public static void AddData(Message message, string name, Func<string> dataProvider);
+        public IMessageProperty CreateCopy();
+        public bool Remove(string name);
+        public static bool TryGet(Message message, out CorrelationDataMessageProperty property);
+        public static bool TryGet(MessageProperties properties, out CorrelationDataMessageProperty property);
+        public bool TryGetValue(string name, out string value);
+    }
+    public sealed class CorrelationKey : InstanceKey {
+        public CorrelationKey(IDictionary<string, string> keyData, XName scopeName, XNamespace provider);
+        public IDictionary<string, string> KeyData { get; private set; }
+        public string KeyString { get; private set; }
+        public string Name { get; set; }
+        public XNamespace Provider { get; private set; }
+        public XName ScopeName { get; private set; }
+    }
+    public class CorrelationMessageProperty {
+        public CorrelationMessageProperty(InstanceKey correlationKey, IEnumerable<InstanceKey> additionalKeys);
+        public CorrelationMessageProperty(InstanceKey correlationKey, IEnumerable<InstanceKey> additionalKeys, IEnumerable<InstanceKey> transientCorrelations);
+        public ReadOnlyCollection<InstanceKey> AdditionalKeys { get; }
+        public InstanceKey CorrelationKey { get; }
+        public static string Name { get; }
+        public ReadOnlyCollection<InstanceKey> TransientCorrelations { get; }
+        public static bool TryGet(Message message, out CorrelationMessageProperty property);
+        public static bool TryGet(MessageProperties properties, out CorrelationMessageProperty property);
+    }
+    public class CustomBinding : Binding {
+        public CustomBinding();
+        public CustomBinding(IEnumerable<BindingElement> bindingElementsInTopDownChannelStackOrder);
+        public CustomBinding(Binding binding);
+        public CustomBinding(params BindingElement[] bindingElementsInTopDownChannelStackOrder);
+        public CustomBinding(string configurationName);
+        public CustomBinding(string name, string ns, params BindingElement[] bindingElementsInTopDownChannelStackOrder);
+        public BindingElementCollection Elements { get; }
+        public override string Scheme { get; }
+        public override BindingElementCollection CreateBindingElements();
+    }
+    public enum DeliveryFailure {
+        AccessDenied = 32772,
+        BadDestinationQueue = 32768,
+        BadEncryption = 32775,
+        BadSignature = 32774,
+        CouldNotEncrypt = 32776,
+        HopCountExceeded = 32773,
+        NotTransactionalMessage = 32778,
+        NotTransactionalQueue = 32777,
+        Purged = 32769,
+        QueueDeleted = 49152,
+        QueueExceedMaximumSize = 32771,
+        QueuePurged = 49153,
+        ReachQueueTimeout = 32770,
+        ReceiveTimeout = 49154,
+        Unknown = 0,
+    }
+    public enum DeliveryStatus {
+        InDoubt = 0,
+        NotDelivered = 1,
+    }
+    public abstract class FaultConverter {
+        protected FaultConverter();
+        public static FaultConverter GetDefaultFaultConverter(MessageVersion version);
+        protected abstract bool OnTryCreateException(Message message, MessageFault fault, out Exception exception);
+        protected abstract bool OnTryCreateFaultMessage(Exception exception, out Message message);
+        public bool TryCreateException(Message message, MessageFault fault, out Exception exception);
+        public bool TryCreateFaultMessage(Exception exception, out Message message);
+    }
+    public class HttpCookieContainerBindingElement : BindingElement {
+        public HttpCookieContainerBindingElement();
+        protected HttpCookieContainerBindingElement(HttpCookieContainerBindingElement elementToBeCloned);
+        public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context);
+        public override BindingElement Clone();
+        public override T GetProperty<T>(BindingContext context);
+    }
+    public class HttpMessageHandlerFactory {
+        protected HttpMessageHandlerFactory();
+        public HttpMessageHandlerFactory(Func<IEnumerable<DelegatingHandler>> handlers);
+        public HttpMessageHandlerFactory(params Type[] handlers);
+        public HttpMessageHandler Create(HttpMessageHandler innerChannel);
+        protected virtual HttpMessageHandler OnCreate(HttpMessageHandler innerChannel);
+    }
+    public sealed class HttpMessageSettings : IEquatable<HttpMessageSettings> {
+        public HttpMessageSettings();
+        public bool HttpMessagesSupported { get; set; }
+        public bool Equals(HttpMessageSettings other);
+    }
+    public static class HttpRequestMessageExtensionMethods {
+        public static IPrincipal GetUserPrincipal(this HttpRequestMessage httpRequestMessage);
+        public static void SetUserPrincipal(this HttpRequestMessage httpRequestMessage, IPrincipal user);
+        public static Message ToMessage(this HttpRequestMessage httpRequestMessage);
+    }
+    public sealed class HttpRequestMessageProperty : IMergeEnabledMessageProperty, IMessageProperty {
+        public HttpRequestMessageProperty();
+        public WebHeaderCollection Headers { get; }
+        public string Method { get; set; }
+        public static string Name { get; }
+        public string QueryString { get; set; }
+        public bool SuppressEntityBody { get; set; }
+        IMessageProperty System.ServiceModel.Channels.IMessageProperty.CreateCopy();
+    }
+    public static class HttpResponseMessageExtensionMethods {
+        public static Message ToMessage(this HttpResponseMessage httpResponseMessage);
+    }
+    public sealed class HttpResponseMessageProperty : IMergeEnabledMessageProperty, IMessageProperty {
+        public HttpResponseMessageProperty();
+        public WebHeaderCollection Headers { get; }
+        public static string Name { get; }
+        public HttpStatusCode StatusCode { get; set; }
+        public string StatusDescription { get; set; }
+        public bool SuppressEntityBody { get; set; }
+        public bool SuppressPreamble { get; set; }
+        IMessageProperty System.ServiceModel.Channels.IMessageProperty.CreateCopy();
+    }
+    public class HttpsTransportBindingElement : HttpTransportBindingElement, ITransportTokenAssertionProvider {
+        public HttpsTransportBindingElement();
+        protected HttpsTransportBindingElement(HttpsTransportBindingElement elementToBeCloned);
+        public bool RequireClientCertificate { get; set; }
+        public override string Scheme { get; }
+        public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context);
+        public override IChannelListener<TChannel> BuildChannelListener<TChannel>(BindingContext context);
+        public override BindingElement Clone();
+        public override T GetProperty<T>(BindingContext context);
+        public XmlElement GetTransportTokenAssertion();
+    }
+    public class HttpTransportBindingElement : TransportBindingElement, IPolicyExportExtension, ITransportPolicyImport, IWsdlExportExtension {
+        public HttpTransportBindingElement();
+        protected HttpTransportBindingElement(HttpTransportBindingElement elementToBeCloned);
+        public bool AllowCookies { get; set; }
+        public AuthenticationSchemes AuthenticationScheme { get; set; }
+        public bool BypassProxyOnLocal { get; set; }
+        public bool DecompressionEnabled { get; set; }
+        public ExtendedProtectionPolicy ExtendedProtectionPolicy { get; set; }
+        public HostNameComparisonMode HostNameComparisonMode { get; set; }
+        public bool KeepAliveEnabled { get; set; }
+        public int MaxBufferSize { get; set; }
+        public int MaxPendingAccepts { get; set; }
+        public HttpMessageHandlerFactory MessageHandlerFactory { get; set; }
+        public Uri ProxyAddress { get; set; }
+        public AuthenticationSchemes ProxyAuthenticationScheme { get; set; }
+        public string Realm { get; set; }
+        public TimeSpan RequestInitializationTimeout { get; set; }
+        public override string Scheme { get; }
+        public TransferMode TransferMode { get; set; }
+        public bool UnsafeConnectionNtlmAuthentication { get; set; }
+        public bool UseDefaultWebProxy { get; set; }
+        public WebSocketTransportSettings WebSocketSettings { get; set; }
+        public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context);
+        public override IChannelListener<TChannel> BuildChannelListener<TChannel>(BindingContext context);
+        public override bool CanBuildChannelFactory<TChannel>(BindingContext context);
+        public override bool CanBuildChannelListener<TChannel>(BindingContext context);
+        public override BindingElement Clone();
+        public override T GetProperty<T>(BindingContext context);
+        public bool ShouldSerializeExtendedProtectionPolicy();
+        public bool ShouldSerializeMessageHandlerFactory();
+        public bool ShouldSerializeWebSocketSettings();
+        void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(MetadataExporter exporter, PolicyConversionContext context);
+        void System.ServiceModel.Description.IWsdlExportExtension.ExportContract(WsdlExporter exporter, WsdlContractConversionContext context);
+        void System.ServiceModel.Description.IWsdlExportExtension.ExportEndpoint(WsdlExporter exporter, WsdlEndpointConversionContext endpointContext);
+        protected void UpdateAuthenticationSchemes(BindingContext context);
+    }
+    public interface IAnonymousUriPrefixMatcher {
+        void Register(Uri anonymousUriPrefix);
+    }
+    public interface IBindingDeliveryCapabilities {
+        bool AssuresOrderedDelivery { get; }
+        bool QueuedDelivery { get; }
+    }
+    public interface IBindingMulticastCapabilities {
+        bool IsMulticast { get; }
+    }
+    public interface IBindingRuntimePreferences {
+        bool ReceiveSynchronously { get; }
+    }
+    public interface IChannel : ICommunicationObject {
+        T GetProperty<T>() where T : class;
+    }
+    public interface IChannelFactory : ICommunicationObject {
+        T GetProperty<T>() where T : class;
+    }
+    public interface IChannelFactory<TChannel> : IChannelFactory, ICommunicationObject {
+        TChannel CreateChannel(EndpointAddress to);
+        TChannel CreateChannel(EndpointAddress to, Uri via);
+    }
+    public interface IChannelListener : ICommunicationObject {
+        Uri Uri { get; }
+        IAsyncResult BeginWaitForChannel(TimeSpan timeout, AsyncCallback callback, object state);
+        bool EndWaitForChannel(IAsyncResult result);
+        T GetProperty<T>() where T : class;
+        bool WaitForChannel(TimeSpan timeout);
+    }
+    public interface IChannelListener<TChannel> : IChannelListener, ICommunicationObject where TChannel : class, IChannel {
+        TChannel AcceptChannel();
+        TChannel AcceptChannel(TimeSpan timeout);
+        IAsyncResult BeginAcceptChannel(AsyncCallback callback, object state);
+        IAsyncResult BeginAcceptChannel(TimeSpan timeout, AsyncCallback callback, object state);
+        TChannel EndAcceptChannel(IAsyncResult result);
+    }
+    public interface IContextBindingElement
+    public interface IContextManager {
+        bool Enabled { get; set; }
+        IDictionary<string, string> GetContext();
+        void SetContext(IDictionary<string, string> context);
+    }
+    public interface ICorrelationDataSource {
+        ICollection<CorrelationDataDescription> DataSources { get; }
+    }
+    public interface IDuplexChannel : IChannel, ICommunicationObject, IInputChannel, IOutputChannel
+    public interface IDuplexSession : IInputSession, IOutputSession, ISession {
+        IAsyncResult BeginCloseOutputSession(AsyncCallback callback, object state);
+        IAsyncResult BeginCloseOutputSession(TimeSpan timeout, AsyncCallback callback, object state);
+        void CloseOutputSession();
+        void CloseOutputSession(TimeSpan timeout);
+        void EndCloseOutputSession(IAsyncResult result);
+    }
+    public interface IDuplexSessionChannel : IChannel, ICommunicationObject, IDuplexChannel, IInputChannel, IOutputChannel, ISessionChannel<IDuplexSession>
+    public interface IHttpCookieContainerManager {
+        CookieContainer CookieContainer { get; set; }
+    }
+    public interface IInputChannel : IChannel, ICommunicationObject {
+        EndpointAddress LocalAddress { get; }
+        IAsyncResult BeginReceive(AsyncCallback callback, object state);
+        IAsyncResult BeginReceive(TimeSpan timeout, AsyncCallback callback, object state);
+        IAsyncResult BeginTryReceive(TimeSpan timeout, AsyncCallback callback, object state);
+        IAsyncResult BeginWaitForMessage(TimeSpan timeout, AsyncCallback callback, object state);
+        Message EndReceive(IAsyncResult result);
+        bool EndTryReceive(IAsyncResult result, out Message message);
+        bool EndWaitForMessage(IAsyncResult result);
+        Message Receive();
+        Message Receive(TimeSpan timeout);
+        bool TryReceive(TimeSpan timeout, out Message message);
+        bool WaitForMessage(TimeSpan timeout);
+    }
+    public interface IInputSession : ISession
+    public interface IInputSessionChannel : IChannel, ICommunicationObject, IInputChannel, ISessionChannel<IInputSession>
+    public interface IMessageProperty {
+        IMessageProperty CreateCopy();
+    }
+    public class InvalidChannelBindingException : Exception {
+        public InvalidChannelBindingException();
+        protected InvalidChannelBindingException(SerializationInfo info, StreamingContext context);
+        public InvalidChannelBindingException(string message);
+        public InvalidChannelBindingException(string message, Exception innerException);
+    }
+    public interface IOutputChannel : IChannel, ICommunicationObject {
+        EndpointAddress RemoteAddress { get; }
+        Uri Via { get; }
+        IAsyncResult BeginSend(Message message, AsyncCallback callback, object state);
+        IAsyncResult BeginSend(Message message, TimeSpan timeout, AsyncCallback callback, object state);
+        void EndSend(IAsyncResult result);
+        void Send(Message message);
+        void Send(Message message, TimeSpan timeout);
+    }
+    public interface IOutputSession : ISession
+    public interface IOutputSessionChannel : IChannel, ICommunicationObject, IOutputChannel, ISessionChannel<IOutputSession>
+    public interface IReceiveContextSettings {
+        bool Enabled { get; set; }
+        TimeSpan ValidityDuration { get; }
+    }
+    public interface IReplyChannel : IChannel, ICommunicationObject {
+        EndpointAddress LocalAddress { get; }
+        IAsyncResult BeginReceiveRequest(AsyncCallback callback, object state);
+        IAsyncResult BeginReceiveRequest(TimeSpan timeout, AsyncCallback callback, object state);
+        IAsyncResult BeginTryReceiveRequest(TimeSpan timeout, AsyncCallback callback, object state);
+        IAsyncResult BeginWaitForRequest(TimeSpan timeout, AsyncCallback callback, object state);
+        RequestContext EndReceiveRequest(IAsyncResult result);
+        bool EndTryReceiveRequest(IAsyncResult result, out RequestContext context);
+        bool EndWaitForRequest(IAsyncResult result);
+        RequestContext ReceiveRequest();
+        RequestContext ReceiveRequest(TimeSpan timeout);
+        bool TryReceiveRequest(TimeSpan timeout, out RequestContext context);
+        bool WaitForRequest(TimeSpan timeout);
+    }
+    public interface IReplySessionChannel : IChannel, ICommunicationObject, IReplyChannel, ISessionChannel<IInputSession>
+    public interface IRequestChannel : IChannel, ICommunicationObject {
+        EndpointAddress RemoteAddress { get; }
+        Uri Via { get; }
+        IAsyncResult BeginRequest(Message message, AsyncCallback callback, object state);
+        IAsyncResult BeginRequest(Message message, TimeSpan timeout, AsyncCallback callback, object state);
+        Message EndRequest(IAsyncResult result);
+        Message Request(Message message);
+        Message Request(Message message, TimeSpan timeout);
+    }
+    public interface IRequestSessionChannel : IChannel, ICommunicationObject, IRequestChannel, ISessionChannel<IOutputSession>
+    public interface ISecurityCapabilities {
+        ProtectionLevel SupportedRequestProtectionLevel { get; }
+        ProtectionLevel SupportedResponseProtectionLevel { get; }
+        bool SupportsClientAuthentication { get; }
+        bool SupportsClientWindowsIdentity { get; }
+        bool SupportsServerAuthentication { get; }
+    }
+    public interface ISession {
+        string Id { get; }
+    }
+    public interface ISessionChannel<TSession> where TSession : ISession {
+        TSession Session { get; }
+    }
+    public interface ITransactedBindingElement {
+        bool TransactedReceiveEnabled { get; }
+    }
+    public interface ITransportTokenAssertionProvider {
+        XmlElement GetTransportTokenAssertion();
+    }
+    public interface IWebSocketCloseDetails {
+        Nullable<WebSocketCloseStatus> InputCloseStatus { get; }
+        string InputCloseStatusDescription { get; }
+        void SetOutputCloseStatus(WebSocketCloseStatus closeStatus, string closeStatusDescription);
+    }
+    public sealed class JavascriptCallbackResponseMessageProperty {
+        public JavascriptCallbackResponseMessageProperty();
+        public string CallbackFunctionName { get; set; }
+        public static string Name { get; }
+        public Nullable<HttpStatusCode> StatusCode { get; set; }
+    }
+    public sealed class LocalClientSecuritySettings {
+        public LocalClientSecuritySettings();
+        public bool CacheCookies { get; set; }
+        public int CookieRenewalThresholdPercentage { get; set; }
+        public bool DetectReplays { get; set; }
+        public IdentityVerifier IdentityVerifier { get; set; }
+        public TimeSpan MaxClockSkew { get; set; }
+        public TimeSpan MaxCookieCachingTime { get; set; }
+        public NonceCache NonceCache { get; set; }
+        public bool ReconnectTransportOnFailure { get; set; }
+        public int ReplayCacheSize { get; set; }
+        public TimeSpan ReplayWindow { get; set; }
+        public TimeSpan SessionKeyRenewalInterval { get; set; }
+        public TimeSpan SessionKeyRolloverInterval { get; set; }
+        public TimeSpan TimestampValidityDuration { get; set; }
+        public LocalClientSecuritySettings Clone();
+    }
+    public sealed class LocalServiceSecuritySettings {
+        public LocalServiceSecuritySettings();
+        public bool DetectReplays { get; set; }
+        public TimeSpan InactivityTimeout { get; set; }
+        public TimeSpan IssuedCookieLifetime { get; set; }
+        public int MaxCachedCookies { get; set; }
+        public TimeSpan MaxClockSkew { get; set; }
+        public int MaxPendingSessions { get; set; }
+        public int MaxStatefulNegotiations { get; set; }
+        public TimeSpan NegotiationTimeout { get; set; }
+        public NonceCache NonceCache { get; set; }
+        public bool ReconnectTransportOnFailure { get; set; }
+        public int ReplayCacheSize { get; set; }
+        public TimeSpan ReplayWindow { get; set; }
+        public TimeSpan SessionKeyRenewalInterval { get; set; }
+        public TimeSpan SessionKeyRolloverInterval { get; set; }
+        public TimeSpan TimestampValidityDuration { get; set; }
+        public LocalServiceSecuritySettings Clone();
+    }
+    public abstract class Message : IDisposable {
+        protected Message();
+        public abstract MessageHeaders Headers { get; }
+        protected bool IsDisposed { get; }
+        public virtual bool IsEmpty { get; }
+        public virtual bool IsFault { get; }
+        public abstract MessageProperties Properties { get; }
+        public MessageState State { get; }
+        public abstract MessageVersion Version { get; }
+        public IAsyncResult BeginWriteBodyContents(XmlDictionaryWriter writer, AsyncCallback callback, object state);
+        public IAsyncResult BeginWriteMessage(XmlDictionaryWriter writer, AsyncCallback callback, object state);
+        public void Close();
+        public MessageBuffer CreateBufferedCopy(int maxBufferSize);
+        public static Message CreateMessage(MessageVersion version, MessageFault fault, string action);
+        public static Message CreateMessage(MessageVersion version, FaultCode faultCode, string reason, object detail, string action);
+        public static Message CreateMessage(MessageVersion version, FaultCode faultCode, string reason, string action);
+        public static Message CreateMessage(MessageVersion version, string action);
+        public static Message CreateMessage(MessageVersion version, string action, object body);
+        public static Message CreateMessage(MessageVersion version, string action, object body, XmlObjectSerializer serializer);
+        public static Message CreateMessage(MessageVersion version, string action, BodyWriter body);
+        public static Message CreateMessage(MessageVersion version, string action, XmlDictionaryReader body);
+        public static Message CreateMessage(MessageVersion version, string action, XmlReader body);
+        public static Message CreateMessage(XmlDictionaryReader envelopeReader, int maxSizeOfHeaders, MessageVersion version);
+        public static Message CreateMessage(XmlReader envelopeReader, int maxSizeOfHeaders, MessageVersion version);
+        public void EndWriteBodyContents(IAsyncResult result);
+        public void EndWriteMessage(IAsyncResult result);
+        public T GetBody<T>();
+        public T GetBody<T>(XmlObjectSerializer serializer);
+        public string GetBodyAttribute(string localName, string ns);
+        public XmlDictionaryReader GetReaderAtBodyContents();
+        protected virtual IAsyncResult OnBeginWriteBodyContents(XmlDictionaryWriter writer, AsyncCallback callback, object state);
+        protected virtual IAsyncResult OnBeginWriteMessage(XmlDictionaryWriter writer, AsyncCallback callback, object state);
+        protected virtual void OnBodyToString(XmlDictionaryWriter writer);
+        protected virtual void OnClose();
+        protected virtual MessageBuffer OnCreateBufferedCopy(int maxBufferSize);
+        protected virtual void OnEndWriteBodyContents(IAsyncResult result);
+        protected virtual void OnEndWriteMessage(IAsyncResult result);
+        protected virtual T OnGetBody<T>(XmlDictionaryReader reader);
+        protected virtual string OnGetBodyAttribute(string localName, string ns);
+        protected virtual XmlDictionaryReader OnGetReaderAtBodyContents();
+        protected abstract void OnWriteBodyContents(XmlDictionaryWriter writer);
+        protected virtual void OnWriteMessage(XmlDictionaryWriter writer);
+        protected virtual void OnWriteStartBody(XmlDictionaryWriter writer);
+        protected virtual void OnWriteStartEnvelope(XmlDictionaryWriter writer);
+        protected virtual void OnWriteStartHeaders(XmlDictionaryWriter writer);
+        void System.IDisposable.Dispose();
+        public override string ToString();
+        public void WriteBody(XmlDictionaryWriter writer);
+        public void WriteBody(XmlWriter writer);
+        public void WriteBodyContents(XmlDictionaryWriter writer);
+        public void WriteMessage(XmlDictionaryWriter writer);
+        public void WriteMessage(XmlWriter writer);
+        public void WriteStartBody(XmlDictionaryWriter writer);
+        public void WriteStartBody(XmlWriter writer);
+        public void WriteStartEnvelope(XmlDictionaryWriter writer);
+    }
+    public abstract class MessageBuffer : IDisposable, IXPathNavigable {
+        protected MessageBuffer();
+        public abstract int BufferSize { get; }
+        public virtual string MessageContentType { get; }
+        public abstract void Close();
+        public abstract Message CreateMessage();
+        public XPathNavigator CreateNavigator();
+        public XPathNavigator CreateNavigator(int nodeQuota);
+        public XPathNavigator CreateNavigator(int nodeQuota, XmlSpace space);
+        public XPathNavigator CreateNavigator(XmlSpace space);
+        void System.IDisposable.Dispose();
+        public virtual void WriteMessage(Stream stream);
+    }
+    public abstract class MessageEncoder {
+        protected MessageEncoder();
+        public abstract string ContentType { get; }
+        public abstract string MediaType { get; }
+        public abstract MessageVersion MessageVersion { get; }
+        public virtual IAsyncResult BeginWriteMessage(Message message, Stream stream, AsyncCallback callback, object state);
+        public virtual void EndWriteMessage(IAsyncResult result);
+        public virtual T GetProperty<T>() where T : class;
+        public virtual bool IsContentTypeSupported(string contentType);
+        public Message ReadMessage(ArraySegment<byte> buffer, BufferManager bufferManager);
+        public abstract Message ReadMessage(ArraySegment<byte> buffer, BufferManager bufferManager, string contentType);
+        public Message ReadMessage(Stream stream, int maxSizeOfHeaders);
+        public abstract Message ReadMessage(Stream stream, int maxSizeOfHeaders, string contentType);
+        public override string ToString();
+        public ArraySegment<byte> WriteMessage(Message message, int maxMessageSize, BufferManager bufferManager);
+        public abstract ArraySegment<byte> WriteMessage(Message message, int maxMessageSize, BufferManager bufferManager, int messageOffset);
+        public abstract void WriteMessage(Message message, Stream stream);
+    }
+    public abstract class MessageEncoderFactory {
+        protected MessageEncoderFactory();
+        public abstract MessageEncoder Encoder { get; }
+        public abstract MessageVersion MessageVersion { get; }
+        public virtual MessageEncoder CreateSessionEncoder();
+    }
+    public abstract class MessageEncodingBindingElement : BindingElement {
+        protected MessageEncodingBindingElement();
+        protected MessageEncodingBindingElement(MessageEncodingBindingElement elementToBeCloned);
+        public abstract MessageVersion MessageVersion { get; set; }
+        public abstract MessageEncoderFactory CreateMessageEncoderFactory();
+        public override T GetProperty<T>(BindingContext context);
+    }
+    public class MessageEncodingBindingElementImporter : IPolicyImportExtension, IWsdlImportExtension {
+        public MessageEncodingBindingElementImporter();
+        void System.ServiceModel.Description.IPolicyImportExtension.ImportPolicy(MetadataImporter importer, PolicyConversionContext context);
+        void System.ServiceModel.Description.IWsdlImportExtension.BeforeImport(ServiceDescriptionCollection wsdlDocuments, XmlSchemaSet xmlSchemas, ICollection<XmlElement> policy);
+        void System.ServiceModel.Description.IWsdlImportExtension.ImportContract(WsdlImporter importer, WsdlContractConversionContext context);
+        void System.ServiceModel.Description.IWsdlImportExtension.ImportEndpoint(WsdlImporter importer, WsdlEndpointConversionContext context);
+    }
+    public static class MessageExtensionMethods {
+        public static HttpRequestMessage ToHttpRequestMessage(this Message message);
+        public static HttpResponseMessage ToHttpResponseMessage(this Message message);
+    }
+    public abstract class MessageFault {
+        protected MessageFault();
+        public virtual string Actor { get; }
+        public abstract FaultCode Code { get; }
+        public abstract bool HasDetail { get; }
+        public bool IsMustUnderstandFault { get; }
+        public virtual string Node { get; }
+        public abstract FaultReason Reason { get; }
+        public static MessageFault CreateFault(Message message, int maxBufferSize);
+        public static MessageFault CreateFault(FaultCode code, FaultReason reason);
+        public static MessageFault CreateFault(FaultCode code, FaultReason reason, object detail);
+        public static MessageFault CreateFault(FaultCode code, FaultReason reason, object detail, XmlObjectSerializer serializer);
+        public static MessageFault CreateFault(FaultCode code, FaultReason reason, object detail, XmlObjectSerializer serializer, string actor);
+        public static MessageFault CreateFault(FaultCode code, FaultReason reason, object detail, XmlObjectSerializer serializer, string actor, string node);
+        public static MessageFault CreateFault(FaultCode code, string reason);
+        public T GetDetail<T>();
+        public T GetDetail<T>(XmlObjectSerializer serializer);
+        public XmlDictionaryReader GetReaderAtDetailContents();
+        protected virtual XmlDictionaryReader OnGetReaderAtDetailContents();
+        protected virtual void OnWriteDetail(XmlDictionaryWriter writer, EnvelopeVersion version);
+        protected abstract void OnWriteDetailContents(XmlDictionaryWriter writer);
+        protected virtual void OnWriteStartDetail(XmlDictionaryWriter writer, EnvelopeVersion version);
+        public static bool WasHeaderNotUnderstood(MessageHeaders headers, string name, string ns);
+        public void WriteTo(XmlDictionaryWriter writer, EnvelopeVersion version);
+        public void WriteTo(XmlWriter writer, EnvelopeVersion version);
+    }
+    public abstract class MessageHeader : MessageHeaderInfo {
+        protected MessageHeader();
+        public override string Actor { get; }
+        public override bool IsReferenceParameter { get; }
+        public override bool MustUnderstand { get; }
+        public override bool Relay { get; }
+        public static MessageHeader CreateHeader(string name, string ns, object value);
+        public static MessageHeader CreateHeader(string name, string ns, object value, bool mustUnderstand);
+        public static MessageHeader CreateHeader(string name, string ns, object value, bool mustUnderstand, string actor);
+        public static MessageHeader CreateHeader(string name, string ns, object value, bool mustUnderstand, string actor, bool relay);
+        public static MessageHeader CreateHeader(string name, string ns, object value, XmlObjectSerializer serializer);
+        public static MessageHeader CreateHeader(string name, string ns, object value, XmlObjectSerializer serializer, bool mustUnderstand);
+        public static MessageHeader CreateHeader(string name, string ns, object value, XmlObjectSerializer serializer, bool mustUnderstand, string actor);
+        public static MessageHeader CreateHeader(string name, string ns, object value, XmlObjectSerializer serializer, bool mustUnderstand, string actor, bool relay);
+        public virtual bool IsMessageVersionSupported(MessageVersion messageVersion);
+        protected abstract void OnWriteHeaderContents(XmlDictionaryWriter writer, MessageVersion messageVersion);
+        protected virtual void OnWriteStartHeader(XmlDictionaryWriter writer, MessageVersion messageVersion);
+        public override string ToString();
+        public void WriteHeader(XmlDictionaryWriter writer, MessageVersion messageVersion);
+        public void WriteHeader(XmlWriter writer, MessageVersion messageVersion);
+        protected void WriteHeaderAttributes(XmlDictionaryWriter writer, MessageVersion messageVersion);
+        public void WriteHeaderContents(XmlDictionaryWriter writer, MessageVersion messageVersion);
+        public void WriteStartHeader(XmlDictionaryWriter writer, MessageVersion messageVersion);
+    }
+    public abstract class MessageHeaderInfo {
+        protected MessageHeaderInfo();
+        public abstract string Actor { get; }
+        public abstract bool IsReferenceParameter { get; }
+        public abstract bool MustUnderstand { get; }
+        public abstract string Name { get; }
+        public abstract string Namespace { get; }
+        public abstract bool Relay { get; }
+    }
+    public sealed class MessageHeaders : IEnumerable, IEnumerable<MessageHeaderInfo> {
+        public MessageHeaders(MessageHeaders collection);
+        public MessageHeaders(MessageVersion version);
+        public MessageHeaders(MessageVersion version, int initialSize);
+        public string Action { get; set; }
+        public int Count { get; }
+        public EndpointAddress FaultTo { get; set; }
+        public EndpointAddress From { get; set; }
+        public UniqueId MessageId { get; set; }
+        public MessageVersion MessageVersion { get; }
+        public UniqueId RelatesTo { get; set; }
+        public EndpointAddress ReplyTo { get; set; }
+        public MessageHeaderInfo this[int index] { get; }
+        public Uri To { get; set; }
+        public UnderstoodHeaders UnderstoodHeaders { get; }
+        public void Add(MessageHeader header);
+        public void Clear();
+        public void CopyHeaderFrom(Message message, int headerIndex);
+        public void CopyHeaderFrom(MessageHeaders collection, int headerIndex);
+        public void CopyHeadersFrom(Message message);
+        public void CopyHeadersFrom(MessageHeaders collection);
+        public void CopyTo(MessageHeaderInfo[] array, int index);
+        public int FindHeader(string name, string ns);
+        public int FindHeader(string name, string ns, params string[] actors);
+        public IEnumerator<MessageHeaderInfo> GetEnumerator();
+        public T GetHeader<T>(int index);
+        public T GetHeader<T>(int index, XmlObjectSerializer serializer);
+        public T GetHeader<T>(string name, string ns);
+        public T GetHeader<T>(string name, string ns, XmlObjectSerializer serializer);
+        public T GetHeader<T>(string name, string ns, params string[] actors);
+        public XmlDictionaryReader GetReaderAtHeader(int headerIndex);
+        public bool HaveMandatoryHeadersBeenUnderstood();
+        public bool HaveMandatoryHeadersBeenUnderstood(params string[] actors);
+        public void Insert(int headerIndex, MessageHeader header);
+        public void RemoveAll(string name, string ns);
+        public void RemoveAt(int headerIndex);
+        public void SetAction(XmlDictionaryString action);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        public void WriteHeader(int headerIndex, XmlDictionaryWriter writer);
+        public void WriteHeader(int headerIndex, XmlWriter writer);
+        public void WriteHeaderContents(int headerIndex, XmlDictionaryWriter writer);
+        public void WriteHeaderContents(int headerIndex, XmlWriter writer);
+        public void WriteStartHeader(int headerIndex, XmlDictionaryWriter writer);
+        public void WriteStartHeader(int headerIndex, XmlWriter writer);
+    }
+    public sealed class MessageProperties : ICollection<KeyValuePair<string, object>>, IDictionary<string, object>, IDisposable, IEnumerable, IEnumerable<KeyValuePair<string, object>> {
+        public MessageProperties();
+        public MessageProperties(MessageProperties properties);
+        public bool AllowOutputBatching { get; set; }
+        public int Count { get; }
+        public MessageEncoder Encoder { get; set; }
+        public bool IsFixedSize { get; }
+        public bool IsReadOnly { get; }
+        public ICollection<string> Keys { get; }
+        public SecurityMessageProperty Security { get; set; }
+        public object this[string name] { get; set; }
+        public ICollection<object> Values { get; }
+        public Uri Via { get; set; }
+        public void Add(string name, object property);
+        public void Clear();
+        public bool ContainsKey(string name);
+        public void CopyProperties(MessageProperties properties);
+        public void Dispose();
+        public bool Remove(string name);
+        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Add(KeyValuePair<string, object> pair);
+        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Contains(KeyValuePair<string, object> pair);
+        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.CopyTo(KeyValuePair<string, object>[] array, int index);
+        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Remove(KeyValuePair<string, object> pair);
+        IEnumerator<KeyValuePair<string, object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        public bool TryGetValue(string name, out object value);
+    }
+    public enum MessageState {
+        Closed = 4,
+        Copied = 3,
+        Created = 0,
+        Read = 1,
+        Written = 2,
+    }
+    public sealed class MessageVersion {
+        public AddressingVersion Addressing { get; }
+        public static MessageVersion Default { get; }
+        public EnvelopeVersion Envelope { get; }
+        public static MessageVersion None { get; }
+        public static MessageVersion Soap11 { get; }
+        public static MessageVersion Soap11WSAddressing10 { get; }
+        public static MessageVersion Soap11WSAddressingAugust2004 { get; }
+        public static MessageVersion Soap12 { get; }
+        public static MessageVersion Soap12WSAddressing10 { get; }
+        public static MessageVersion Soap12WSAddressingAugust2004 { get; }
+        public static MessageVersion CreateVersion(EnvelopeVersion envelopeVersion);
+        public static MessageVersion CreateVersion(EnvelopeVersion envelopeVersion, AddressingVersion addressingVersion);
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public override string ToString();
+    }
+    public abstract class MsmqBindingElementBase : TransportBindingElement, IPolicyExportExtension, ITransactedBindingElement, ITransportPolicyImport, IWsdlExportExtension {
+        public Uri CustomDeadLetterQueue { get; set; }
+        public DeadLetterQueue DeadLetterQueue { get; set; }
+        public bool Durable { get; set; }
+        public bool ExactlyOnce { get; set; }
+        public int MaxRetryCycles { get; set; }
+        public MsmqTransportSecurity MsmqTransportSecurity { get; internal set; }
+        public bool ReceiveContextEnabled { get; set; }
+        public ReceiveErrorHandling ReceiveErrorHandling { get; set; }
+        public int ReceiveRetryCount { get; set; }
+        public TimeSpan RetryCycleDelay { get; set; }
+        public TimeSpan TimeToLive { get; set; }
+        public bool TransactedReceiveEnabled { get; }
+        public bool UseMsmqTracing { get; set; }
+        public bool UseSourceJournal { get; set; }
+        public TimeSpan ValidityDuration { get; set; }
+        public override T GetProperty<T>(BindingContext context);
+        void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(MetadataExporter exporter, PolicyConversionContext context);
+        void System.ServiceModel.Description.IWsdlExportExtension.ExportContract(WsdlExporter exporter, WsdlContractConversionContext context);
+        void System.ServiceModel.Description.IWsdlExportExtension.ExportEndpoint(WsdlExporter exporter, WsdlEndpointConversionContext endpointContext);
+    }
+    public sealed class MsmqMessageProperty {
+        public const string Name = "MsmqMessageProperty";
+        public int AbortCount { get; internal set; }
+        public Nullable<DeliveryFailure> DeliveryFailure { get; }
+        public Nullable<DeliveryStatus> DeliveryStatus { get; }
+        public int MoveCount { get; internal set; }
+        public static MsmqMessageProperty Get(Message message);
+    }
+    public sealed class MsmqTransportBindingElement : MsmqBindingElementBase {
+        public MsmqTransportBindingElement();
+        public int MaxPoolSize { get; set; }
+        public QueueTransferProtocol QueueTransferProtocol { get; set; }
+        public override string Scheme { get; }
+        public bool UseActiveDirectory { get; set; }
+        public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context);
+        public override IChannelListener<TChannel> BuildChannelListener<TChannel>(BindingContext context);
+        public override bool CanBuildChannelFactory<TChannel>(BindingContext context);
+        public override bool CanBuildChannelListener<TChannel>(BindingContext context);
+        public override BindingElement Clone();
+    }
+    public sealed class MtomMessageEncodingBindingElement : MessageEncodingBindingElement, IPolicyExportExtension, IWsdlExportExtension {
+        public MtomMessageEncodingBindingElement();
+        public MtomMessageEncodingBindingElement(MessageVersion messageVersion, Encoding writeEncoding);
+        public int MaxBufferSize { get; set; }
+        public int MaxReadPoolSize { get; set; }
+        public int MaxWritePoolSize { get; set; }
+        public override MessageVersion MessageVersion { get; set; }
+        public XmlDictionaryReaderQuotas ReaderQuotas { get; }
+        public Encoding WriteEncoding { get; set; }
+        public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context);
+        public override IChannelListener<TChannel> BuildChannelListener<TChannel>(BindingContext context);
+        public override bool CanBuildChannelFactory<TChannel>(BindingContext context);
+        public override bool CanBuildChannelListener<TChannel>(BindingContext context);
+        public override BindingElement Clone();
+        public override MessageEncoderFactory CreateMessageEncoderFactory();
+        public override T GetProperty<T>(BindingContext context);
+        public bool ShouldSerializeMessageVersion();
+        public bool ShouldSerializeReaderQuotas();
+        public bool ShouldSerializeWriteEncoding();
+        void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(MetadataExporter exporter, PolicyConversionContext policyContext);
+        void System.ServiceModel.Description.IWsdlExportExtension.ExportContract(WsdlExporter exporter, WsdlContractConversionContext context);
+        void System.ServiceModel.Description.IWsdlExportExtension.ExportEndpoint(WsdlExporter exporter, WsdlEndpointConversionContext context);
+    }
+    public sealed class NamedPipeConnectionPoolSettings {
+        public string GroupName { get; set; }
+        public TimeSpan IdleTimeout { get; set; }
+        public int MaxOutboundConnectionsPerEndpoint { get; set; }
+    }
+    public sealed class NamedPipeSettings {
+        public ApplicationContainerSettings ApplicationContainerSettings { get; private set; }
+    }
+    public class NamedPipeTransportBindingElement : ConnectionOrientedTransportBindingElement {
+        public NamedPipeTransportBindingElement();
+        protected NamedPipeTransportBindingElement(NamedPipeTransportBindingElement elementToBeCloned);
+        public NamedPipeConnectionPoolSettings ConnectionPoolSettings { get; }
+        public NamedPipeSettings PipeSettings { get; }
+        public override string Scheme { get; }
+        public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context);
+        public override IChannelListener<TChannel> BuildChannelListener<TChannel>(BindingContext context);
+        public override BindingElement Clone();
+        public override T GetProperty<T>(BindingContext context);
+    }
+    public class NetworkInterfaceMessageProperty {
+        public NetworkInterfaceMessageProperty(int interfaceIndex);
+        public int InterfaceIndex { get; private set; }
+        public static string Name { get; }
+        public void AddTo(Message message);
+        public void AddTo(MessageProperties properties);
+        public static bool TryGet(Message message, out NetworkInterfaceMessageProperty property);
+        public static bool TryGet(MessageProperties properties, out NetworkInterfaceMessageProperty property);
+    }
+    public sealed class OneWayBindingElement : BindingElement, IPolicyExportExtension {
+        public OneWayBindingElement();
+        public ChannelPoolSettings ChannelPoolSettings { get; set; }
+        public int MaxAcceptedChannels { get; set; }
+        public bool PacketRoutable { get; set; }
+        public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context);
+        public override IChannelListener<TChannel> BuildChannelListener<TChannel>(BindingContext context);
+        public override bool CanBuildChannelFactory<TChannel>(BindingContext context);
+        public override bool CanBuildChannelListener<TChannel>(BindingContext context);
+        public override BindingElement Clone();
+        public override T GetProperty<T>(BindingContext context);
+        public bool ShouldSerializeChannelPoolSettings();
+        void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(MetadataExporter exporter, PolicyConversionContext context);
+    }
+    public class OneWayBindingElementImporter : IPolicyImportExtension {
+        public OneWayBindingElementImporter();
+        void System.ServiceModel.Description.IPolicyImportExtension.ImportPolicy(MetadataImporter importer, PolicyConversionContext context);
+    }
+    public sealed class PeerCustomResolverBindingElement : PeerResolverBindingElement {
+        public PeerCustomResolverBindingElement();
+        public PeerCustomResolverBindingElement(BindingContext context, PeerCustomResolverSettings settings);
+        public PeerCustomResolverBindingElement(PeerCustomResolverBindingElement other);
+        public PeerCustomResolverBindingElement(PeerCustomResolverSettings settings);
+        public EndpointAddress Address { get; set; }
+        public Binding Binding { get; set; }
+        public override PeerReferralPolicy ReferralPolicy { get; set; }
+        public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context);
+        public override IChannelListener<TChannel> BuildChannelListener<TChannel>(BindingContext context);
+        public override bool CanBuildChannelFactory<TChannel>(BindingContext context);
+        public override bool CanBuildChannelListener<TChannel>(BindingContext context);
+        public override BindingElement Clone();
+        public override PeerResolver CreatePeerResolver();
+        public override T GetProperty<T>(BindingContext context);
+    }
+    public abstract class PeerResolverBindingElement : BindingElement {
+        protected PeerResolverBindingElement();
+        protected PeerResolverBindingElement(PeerResolverBindingElement other);
+        public abstract PeerReferralPolicy ReferralPolicy { get; set; }
+        public abstract PeerResolver CreatePeerResolver();
+    }
+    public sealed class PeerTransportBindingElement : TransportBindingElement, IPolicyExportExtension, ITransportPolicyImport, IWsdlExportExtension {
+        public PeerTransportBindingElement();
+        public IPAddress ListenIPAddress { get; set; }
+        public override long MaxReceivedMessageSize { get; set; }
+        public int Port { get; set; }
+        public override string Scheme { get; }
+        public PeerSecuritySettings Security { get; }
+        public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context);
+        public override IChannelListener<TChannel> BuildChannelListener<TChannel>(BindingContext context);
+        public override bool CanBuildChannelFactory<TChannel>(BindingContext context);
+        public override bool CanBuildChannelListener<TChannel>(BindingContext context);
+        public override BindingElement Clone();
+        public override T GetProperty<T>(BindingContext context);
+        void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(MetadataExporter exporter, PolicyConversionContext context);
+        void System.ServiceModel.Description.IWsdlExportExtension.ExportContract(WsdlExporter exporter, WsdlContractConversionContext context);
+        void System.ServiceModel.Description.IWsdlExportExtension.ExportEndpoint(WsdlExporter exporter, WsdlEndpointConversionContext endpointContext);
+    }
+    public sealed class PnrpPeerResolverBindingElement : PeerResolverBindingElement {
+        public PnrpPeerResolverBindingElement();
+        public PnrpPeerResolverBindingElement(PeerReferralPolicy referralPolicy);
+        public override PeerReferralPolicy ReferralPolicy { get; set; }
+        public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context);
+        public override IChannelListener<TChannel> BuildChannelListener<TChannel>(BindingContext context);
+        public override bool CanBuildChannelFactory<TChannel>(BindingContext context);
+        public override bool CanBuildChannelListener<TChannel>(BindingContext context);
+        public override BindingElement Clone();
+        public override PeerResolver CreatePeerResolver();
+        public override T GetProperty<T>(BindingContext context);
+    }
+    public sealed class PrivacyNoticeBindingElement : BindingElement, IPolicyExportExtension {
+        public PrivacyNoticeBindingElement();
+        public PrivacyNoticeBindingElement(PrivacyNoticeBindingElement elementToBeCloned);
+        public Uri Url { get; set; }
+        public int Version { get; set; }
+        public override BindingElement Clone();
+        public override T GetProperty<T>(BindingContext context);
+        void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(MetadataExporter exporter, PolicyConversionContext context);
+    }
+    public sealed class PrivacyNoticeBindingElementImporter : IPolicyImportExtension {
+        public PrivacyNoticeBindingElementImporter();
+        void System.ServiceModel.Description.IPolicyImportExtension.ImportPolicy(MetadataImporter importer, PolicyConversionContext policyContext);
+    }
+    public abstract class ReceiveContext {
+        public static readonly string Name;
+        protected ReceiveContext();
+        public ReceiveContextState State { get; protected set; }
+        protected object ThisLock { get; }
+        public event EventHandler Faulted;
+        public virtual void Abandon(Exception exception, TimeSpan timeout);
+        public virtual void Abandon(TimeSpan timeout);
+        public virtual IAsyncResult BeginAbandon(Exception exception, TimeSpan timeout, AsyncCallback callback, object state);
+        public virtual IAsyncResult BeginAbandon(TimeSpan timeout, AsyncCallback callback, object state);
+        public virtual IAsyncResult BeginComplete(TimeSpan timeout, AsyncCallback callback, object state);
+        public virtual void Complete(TimeSpan timeout);
+        public virtual void EndAbandon(IAsyncResult result);
+        public virtual void EndComplete(IAsyncResult result);
+        protected internal virtual void Fault();
+        protected virtual void OnAbandon(Exception exception, TimeSpan timeout);
+        protected abstract void OnAbandon(TimeSpan timeout);
+        protected virtual IAsyncResult OnBeginAbandon(Exception exception, TimeSpan timeout, AsyncCallback callback, object state);
+        protected abstract IAsyncResult OnBeginAbandon(TimeSpan timeout, AsyncCallback callback, object state);
+        protected abstract IAsyncResult OnBeginComplete(TimeSpan timeout, AsyncCallback callback, object state);
+        protected abstract void OnComplete(TimeSpan timeout);
+        protected abstract void OnEndAbandon(IAsyncResult result);
+        protected abstract void OnEndComplete(IAsyncResult result);
+        protected virtual void OnFaulted();
+        public static bool TryGet(Message message, out ReceiveContext property);
+        public static bool TryGet(MessageProperties properties, out ReceiveContext property);
+    }
+    public enum ReceiveContextState {
+        Abandoned = 4,
+        Abandoning = 3,
+        Completed = 2,
+        Completing = 1,
+        Faulted = 5,
+        Received = 0,
+    }
+    public class RedirectionDuration {
+        public string Namespace { get; private set; }
+        public static RedirectionDuration Permanent { get; }
+        public static RedirectionDuration Temporary { get; }
+        public string Value { get; private set; }
+        public static RedirectionDuration Create(string duration, string ns);
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public static bool operator ==(RedirectionDuration left, RedirectionDuration right);
+        public static bool operator !=(RedirectionDuration left, RedirectionDuration right);
+        public override string ToString();
+    }
+    public class RedirectionException : CommunicationException {
+        protected RedirectionException(SerializationInfo info, StreamingContext context);
+        public RedirectionException(RedirectionType type, RedirectionDuration duration, RedirectionScope scope, Exception innerException, params RedirectionLocation[] locations);
+        public RedirectionException(RedirectionType type, RedirectionDuration duration, RedirectionScope scope, params RedirectionLocation[] locations);
+        public RedirectionException(string message, RedirectionType type, RedirectionDuration duration, RedirectionScope scope, Exception innerException, params RedirectionLocation[] locations);
+        public RedirectionException(string message, RedirectionType type, RedirectionDuration duration, RedirectionScope scope, params RedirectionLocation[] locations);
+        public RedirectionDuration Duration { get; private set; }
+        public IEnumerable<RedirectionLocation> Locations { get; private set; }
+        public RedirectionScope Scope { get; private set; }
+        public RedirectionType Type { get; private set; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class RedirectionLocation {
+        public RedirectionLocation(Uri address);
+        public Uri Address { get; private set; }
+    }
+    public class RedirectionScope {
+        public static RedirectionScope Endpoint { get; }
+        public static RedirectionScope Message { get; }
+        public string Namespace { get; private set; }
+        public static RedirectionScope Session { get; }
+        public string Value { get; private set; }
+        public static RedirectionScope Create(string scope, string ns);
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public static bool operator ==(RedirectionScope left, RedirectionScope right);
+        public static bool operator !=(RedirectionScope left, RedirectionScope right);
+        public override string ToString();
+    }
+    public sealed class RedirectionType {
+        public static RedirectionType Cache { get; }
+        public string Namespace { get; private set; }
+        public static RedirectionType Resource { get; }
+        public static RedirectionType UseIntermediary { get; }
+        public string Value { get; private set; }
+        public static RedirectionType Create(string type, string ns);
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public static bool operator ==(RedirectionType left, RedirectionType right);
+        public static bool operator !=(RedirectionType left, RedirectionType right);
+        public override string ToString();
+    }
+    public sealed class ReliableSessionBindingElement : BindingElement, IPolicyExportExtension {
+        public ReliableSessionBindingElement();
+        public ReliableSessionBindingElement(bool ordered);
+        public TimeSpan AcknowledgementInterval { get; set; }
+        public bool FlowControlEnabled { get; set; }
+        public TimeSpan InactivityTimeout { get; set; }
+        public int MaxPendingChannels { get; set; }
+        public int MaxRetryCount { get; set; }
+        public int MaxTransferWindowSize { get; set; }
+        public bool Ordered { get; set; }
+        public ReliableMessagingVersion ReliableMessagingVersion { get; set; }
+        public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context);
+        public override IChannelListener<TChannel> BuildChannelListener<TChannel>(BindingContext context);
+        public override bool CanBuildChannelFactory<TChannel>(BindingContext context);
+        public override bool CanBuildChannelListener<TChannel>(BindingContext context);
+        public override BindingElement Clone();
+        public override T GetProperty<T>(BindingContext context);
+        void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(MetadataExporter exporter, PolicyConversionContext context);
+    }
+    public sealed class ReliableSessionBindingElementImporter : IPolicyImportExtension {
+        public ReliableSessionBindingElementImporter();
+        void System.ServiceModel.Description.IPolicyImportExtension.ImportPolicy(MetadataImporter importer, PolicyConversionContext context);
+    }
+    public sealed class RemoteEndpointMessageProperty {
+        public RemoteEndpointMessageProperty(string address, int port);
+        public string Address { get; }
+        public static string Name { get; }
+        public int Port { get; }
+    }
+    public abstract class RequestContext : IDisposable {
+        protected RequestContext();
+        public abstract Message RequestMessage { get; }
+        public abstract void Abort();
+        public abstract IAsyncResult BeginReply(Message message, AsyncCallback callback, object state);
+        public abstract IAsyncResult BeginReply(Message message, TimeSpan timeout, AsyncCallback callback, object state);
+        public abstract void Close();
+        public abstract void Close(TimeSpan timeout);
+        protected virtual void Dispose(bool disposing);
+        public abstract void EndReply(IAsyncResult result);
+        public abstract void Reply(Message message);
+        public abstract void Reply(Message message, TimeSpan timeout);
+        void System.IDisposable.Dispose();
+    }
+    public class RetryException : CommunicationException {
+        public RetryException();
+        protected RetryException(SerializationInfo info, StreamingContext context);
+        public RetryException(string message);
+        public RetryException(string message, Exception innerException);
+    }
+    public abstract class SecurityBindingElement : BindingElement {
+        public bool AllowInsecureTransport { get; set; }
+        public SecurityAlgorithmSuite DefaultAlgorithmSuite { get; set; }
+        public bool EnableUnsecuredResponse { get; set; }
+        public SupportingTokenParameters EndpointSupportingTokenParameters { get; }
+        public bool IncludeTimestamp { get; set; }
+        public SecurityKeyEntropyMode KeyEntropyMode { get; set; }
+        public LocalClientSecuritySettings LocalClientSettings { get; }
+        public LocalServiceSecuritySettings LocalServiceSettings { get; }
+        public MessageSecurityVersion MessageSecurityVersion { get; set; }
+        public IDictionary<string, SupportingTokenParameters> OperationSupportingTokenParameters { get; }
+        public SupportingTokenParameters OptionalEndpointSupportingTokenParameters { get; }
+        public IDictionary<string, SupportingTokenParameters> OptionalOperationSupportingTokenParameters { get; }
+        public bool ProtectTokens { get; set; }
+        public SecurityHeaderLayout SecurityHeaderLayout { get; set; }
+        public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context);
+        protected abstract IChannelFactory<TChannel> BuildChannelFactoryCore<TChannel>(BindingContext context);
+        public override IChannelListener<TChannel> BuildChannelListener<TChannel>(BindingContext context);
+        protected abstract IChannelListener<TChannel> BuildChannelListenerCore<TChannel>(BindingContext context) where TChannel : class, IChannel;
+        public override bool CanBuildChannelFactory<TChannel>(BindingContext context);
+        public override bool CanBuildChannelListener<TChannel>(BindingContext context);
+        public static SymmetricSecurityBindingElement CreateAnonymousForCertificateBindingElement();
+        public static TransportSecurityBindingElement CreateCertificateOverTransportBindingElement();
+        public static TransportSecurityBindingElement CreateCertificateOverTransportBindingElement(MessageSecurityVersion version);
+        public static AsymmetricSecurityBindingElement CreateCertificateSignatureBindingElement();
+        public static SymmetricSecurityBindingElement CreateIssuedTokenBindingElement(IssuedSecurityTokenParameters issuedTokenParameters);
+        public static SymmetricSecurityBindingElement CreateIssuedTokenForCertificateBindingElement(IssuedSecurityTokenParameters issuedTokenParameters);
+        public static SymmetricSecurityBindingElement CreateIssuedTokenForSslBindingElement(IssuedSecurityTokenParameters issuedTokenParameters);
+        public static SymmetricSecurityBindingElement CreateIssuedTokenForSslBindingElement(IssuedSecurityTokenParameters issuedTokenParameters, bool requireCancellation);
+        public static TransportSecurityBindingElement CreateIssuedTokenOverTransportBindingElement(IssuedSecurityTokenParameters issuedTokenParameters);
+        public static SymmetricSecurityBindingElement CreateKerberosBindingElement();
+        public static TransportSecurityBindingElement CreateKerberosOverTransportBindingElement();
+        public static SecurityBindingElement CreateMutualCertificateBindingElement();
+        public static SecurityBindingElement CreateMutualCertificateBindingElement(MessageSecurityVersion version);
+        public static SecurityBindingElement CreateMutualCertificateBindingElement(MessageSecurityVersion version, bool allowSerializedSigningTokenOnReply);
+        public static AsymmetricSecurityBindingElement CreateMutualCertificateDuplexBindingElement();
+        public static AsymmetricSecurityBindingElement CreateMutualCertificateDuplexBindingElement(MessageSecurityVersion version);
+        public static SecurityBindingElement CreateSecureConversationBindingElement(SecurityBindingElement bootstrapSecurity);
+        public static SecurityBindingElement CreateSecureConversationBindingElement(SecurityBindingElement bootstrapSecurity, bool requireCancellation);
+        public static SecurityBindingElement CreateSecureConversationBindingElement(SecurityBindingElement bootstrapSecurity, bool requireCancellation, ChannelProtectionRequirements bootstrapProtectionRequirements);
+        public static SymmetricSecurityBindingElement CreateSslNegotiationBindingElement(bool requireClientCertificate);
+        public static SymmetricSecurityBindingElement CreateSslNegotiationBindingElement(bool requireClientCertificate, bool requireCancellation);
+        public static SymmetricSecurityBindingElement CreateSspiNegotiationBindingElement();
+        public static SymmetricSecurityBindingElement CreateSspiNegotiationBindingElement(bool requireCancellation);
+        public static TransportSecurityBindingElement CreateSspiNegotiationOverTransportBindingElement();
+        public static TransportSecurityBindingElement CreateSspiNegotiationOverTransportBindingElement(bool requireCancellation);
+        public static SymmetricSecurityBindingElement CreateUserNameForCertificateBindingElement();
+        public static SymmetricSecurityBindingElement CreateUserNameForSslBindingElement();
+        public static SymmetricSecurityBindingElement CreateUserNameForSslBindingElement(bool requireCancellation);
+        public static TransportSecurityBindingElement CreateUserNameOverTransportBindingElement();
+        public override T GetProperty<T>(BindingContext context);
+        protected static void SetIssuerBindingContextIfRequired(SecurityTokenParameters parameters, BindingContext issuerBindingContext);
+        public virtual void SetKeyDerivation(bool requireDerivedKeys);
+        public override string ToString();
+    }
+    public class SecurityBindingElementImporter : IPolicyImportExtension {
+        public SecurityBindingElementImporter();
+        public int MaxPolicyRedirections { get; }
+        void System.ServiceModel.Description.IPolicyImportExtension.ImportPolicy(MetadataImporter importer, PolicyConversionContext policyContext);
+    }
+    public enum SecurityHeaderLayout {
+        Lax = 1,
+        LaxTimestampFirst = 2,
+        LaxTimestampLast = 3,
+        Strict = 0,
+    }
+    public abstract class SessionOpenNotification {
+        protected SessionOpenNotification();
+        public abstract bool IsEnabled { get; }
+        public abstract void UpdateMessageProperties(MessageProperties inboundMessageProperties);
+    }
+    public class SslStreamSecurityBindingElement : StreamUpgradeBindingElement, IPolicyExportExtension, ITransportTokenAssertionProvider {
+        public SslStreamSecurityBindingElement();
+        protected SslStreamSecurityBindingElement(SslStreamSecurityBindingElement elementToBeCloned);
+        public IdentityVerifier IdentityVerifier { get; set; }
+        public bool RequireClientCertificate { get; set; }
+        public SslProtocols SslProtocols { get; set; }
+        public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context);
+        public override IChannelListener<TChannel> BuildChannelListener<TChannel>(BindingContext context);
+        public override StreamUpgradeProvider BuildClientStreamUpgradeProvider(BindingContext context);
+        public override StreamUpgradeProvider BuildServerStreamUpgradeProvider(BindingContext context);
+        public override bool CanBuildChannelFactory<TChannel>(BindingContext context);
+        public override bool CanBuildChannelListener<TChannel>(BindingContext context);
+        public override BindingElement Clone();
+        public override T GetProperty<T>(BindingContext context);
+        public XmlElement GetTransportTokenAssertion();
+        public bool ShouldSerializeIdentityVerifier();
+        void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(MetadataExporter exporter, PolicyConversionContext context);
+    }
+    public class StandardBindingImporter : IWsdlImportExtension {
+        public StandardBindingImporter();
+        void System.ServiceModel.Description.IWsdlImportExtension.BeforeImport(ServiceDescriptionCollection wsdlDocuments, XmlSchemaSet xmlSchemas, ICollection<XmlElement> policy);
+        void System.ServiceModel.Description.IWsdlImportExtension.ImportContract(WsdlImporter importer, WsdlContractConversionContext context);
+        void System.ServiceModel.Description.IWsdlImportExtension.ImportEndpoint(WsdlImporter importer, WsdlEndpointConversionContext endpointContext);
+    }
+    public abstract class StreamBodyWriter : BodyWriter {
+        protected StreamBodyWriter(bool isBuffered);
+        protected override BodyWriter OnCreateBufferedCopy(int maxBufferSize);
+        protected abstract void OnWriteBodyContents(Stream stream);
+        protected override void OnWriteBodyContents(XmlDictionaryWriter writer);
+    }
+    public abstract class StreamSecurityUpgradeAcceptor : StreamUpgradeAcceptor {
+        protected StreamSecurityUpgradeAcceptor();
+        public abstract SecurityMessageProperty GetRemoteSecurity();
+    }
+    public abstract class StreamSecurityUpgradeInitiator : StreamUpgradeInitiator {
+        protected StreamSecurityUpgradeInitiator();
+        public abstract SecurityMessageProperty GetRemoteSecurity();
+    }
+    public abstract class StreamSecurityUpgradeProvider : StreamUpgradeProvider {
+        protected StreamSecurityUpgradeProvider();
+        protected StreamSecurityUpgradeProvider(IDefaultCommunicationTimeouts timeouts);
+        public abstract EndpointIdentity Identity { get; }
+    }
+    public abstract class StreamUpgradeAcceptor {
+        protected StreamUpgradeAcceptor();
+        public virtual Stream AcceptUpgrade(Stream stream);
+        public abstract IAsyncResult BeginAcceptUpgrade(Stream stream, AsyncCallback callback, object state);
+        public abstract bool CanUpgrade(string contentType);
+        public abstract Stream EndAcceptUpgrade(IAsyncResult result);
+    }
+    public abstract class StreamUpgradeBindingElement : BindingElement {
+        protected StreamUpgradeBindingElement();
+        protected StreamUpgradeBindingElement(StreamUpgradeBindingElement elementToBeCloned);
+        public abstract StreamUpgradeProvider BuildClientStreamUpgradeProvider(BindingContext context);
+        public abstract StreamUpgradeProvider BuildServerStreamUpgradeProvider(BindingContext context);
+    }
+    public abstract class StreamUpgradeInitiator {
+        protected StreamUpgradeInitiator();
+        public abstract IAsyncResult BeginInitiateUpgrade(Stream stream, AsyncCallback callback, object state);
+        public abstract Stream EndInitiateUpgrade(IAsyncResult result);
+        public abstract string GetNextUpgrade();
+        public abstract Stream InitiateUpgrade(Stream stream);
+    }
+    public abstract class StreamUpgradeProvider : CommunicationObject {
+        protected StreamUpgradeProvider();
+        protected StreamUpgradeProvider(IDefaultCommunicationTimeouts timeouts);
+        protected override TimeSpan DefaultCloseTimeout { get; }
+        protected override TimeSpan DefaultOpenTimeout { get; }
+        public abstract StreamUpgradeAcceptor CreateUpgradeAcceptor();
+        public abstract StreamUpgradeInitiator CreateUpgradeInitiator(EndpointAddress remoteAddress, Uri via);
+        public virtual T GetProperty<T>() where T : class;
+    }
+    public enum SupportedAddressingMode {
+        Anonymous = 0,
+        Mixed = 2,
+        NonAnonymous = 1,
+    }
+    public sealed class SymmetricSecurityBindingElement : SecurityBindingElement, IPolicyExportExtension {
+        public SymmetricSecurityBindingElement();
+        public SymmetricSecurityBindingElement(SecurityTokenParameters protectionTokenParameters);
+        public MessageProtectionOrder MessageProtectionOrder { get; set; }
+        public SecurityTokenParameters ProtectionTokenParameters { get; set; }
+        public bool RequireSignatureConfirmation { get; set; }
+        protected override IChannelFactory<TChannel> BuildChannelFactoryCore<TChannel>(BindingContext context);
+        protected override IChannelListener<TChannel> BuildChannelListenerCore<TChannel>(BindingContext context);
+        public override BindingElement Clone();
+        public override T GetProperty<T>(BindingContext context);
+        public override void SetKeyDerivation(bool requireDerivedKeys);
+        void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(MetadataExporter exporter, PolicyConversionContext context);
+        public override string ToString();
+    }
+    public sealed class TcpConnectionPoolSettings {
+        public string GroupName { get; set; }
+        public TimeSpan IdleTimeout { get; set; }
+        public TimeSpan LeaseTimeout { get; set; }
+        public int MaxOutboundConnectionsPerEndpoint { get; set; }
+    }
+    public class TcpTransportBindingElement : ConnectionOrientedTransportBindingElement {
+        public TcpTransportBindingElement();
+        protected TcpTransportBindingElement(TcpTransportBindingElement elementToBeCloned);
+        public TcpConnectionPoolSettings ConnectionPoolSettings { get; }
+        public ExtendedProtectionPolicy ExtendedProtectionPolicy { get; set; }
+        public int ListenBacklog { get; set; }
+        public bool PortSharingEnabled { get; set; }
+        public override string Scheme { get; }
+        public bool TeredoEnabled { get; set; }
+        public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context);
+        public override IChannelListener<TChannel> BuildChannelListener<TChannel>(BindingContext context);
+        public override BindingElement Clone();
+        public override T GetProperty<T>(BindingContext context);
+        public bool ShouldSerializeExtendedProtectionPolicy();
+        public bool ShouldSerializeListenBacklog();
+    }
+    public sealed class TextMessageEncodingBindingElement : MessageEncodingBindingElement, IPolicyExportExtension, IWsdlExportExtension {
+        public TextMessageEncodingBindingElement();
+        public TextMessageEncodingBindingElement(MessageVersion messageVersion, Encoding writeEncoding);
+        public int MaxReadPoolSize { get; set; }
+        public int MaxWritePoolSize { get; set; }
+        public override MessageVersion MessageVersion { get; set; }
+        public XmlDictionaryReaderQuotas ReaderQuotas { get; set; }
+        public Encoding WriteEncoding { get; set; }
+        public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context);
+        public override IChannelListener<TChannel> BuildChannelListener<TChannel>(BindingContext context);
+        public override bool CanBuildChannelListener<TChannel>(BindingContext context);
+        public override BindingElement Clone();
+        public override MessageEncoderFactory CreateMessageEncoderFactory();
+        public override T GetProperty<T>(BindingContext context);
+        public bool ShouldSerializeReaderQuotas();
+        public bool ShouldSerializeWriteEncoding();
+        void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(MetadataExporter exporter, PolicyConversionContext context);
+        void System.ServiceModel.Description.IWsdlExportExtension.ExportContract(WsdlExporter exporter, WsdlContractConversionContext context);
+        void System.ServiceModel.Description.IWsdlExportExtension.ExportEndpoint(WsdlExporter exporter, WsdlEndpointConversionContext context);
+    }
+    public sealed class TransactionFlowBindingElement : BindingElement, IPolicyExportExtension {
+        public TransactionFlowBindingElement();
+        public TransactionFlowBindingElement(TransactionProtocol transactionProtocol);
+        public bool AllowWildcardAction { get; set; }
+        public TransactionProtocol TransactionProtocol { get; set; }
+        public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context);
+        public override IChannelListener<TChannel> BuildChannelListener<TChannel>(BindingContext context);
+        public override bool CanBuildChannelFactory<TChannel>(BindingContext context);
+        public override bool CanBuildChannelListener<TChannel>(BindingContext context);
+        public override BindingElement Clone();
+        public override T GetProperty<T>(BindingContext context);
+        public bool ShouldSerializeTransactionProtocol();
+        void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(MetadataExporter exporter, PolicyConversionContext context);
+    }
+    public sealed class TransactionFlowBindingElementImporter : IPolicyImportExtension {
+        public TransactionFlowBindingElementImporter();
+        void System.ServiceModel.Description.IPolicyImportExtension.ImportPolicy(MetadataImporter importer, PolicyConversionContext context);
+    }
+    public sealed class TransactionMessageProperty {
+        public Transaction Transaction { get; }
+        public static void Set(Transaction transaction, Message message);
+    }
+    public enum TransferSession {
+        None = 0,
+        Ordered = 1,
+        Unordered = 2,
+    }
+    public abstract class TransportBindingElement : BindingElement {
+        protected TransportBindingElement();
+        protected TransportBindingElement(TransportBindingElement elementToBeCloned);
+        public virtual bool ManualAddressing { get; set; }
+        public virtual long MaxBufferPoolSize { get; set; }
+        public virtual long MaxReceivedMessageSize { get; set; }
+        public abstract string Scheme { get; }
+        public override T GetProperty<T>(BindingContext context);
+    }
+    public class TransportBindingElementImporter : IPolicyImportExtension, IWsdlImportExtension {
+        public TransportBindingElementImporter();
+        void System.ServiceModel.Description.IPolicyImportExtension.ImportPolicy(MetadataImporter importer, PolicyConversionContext policyContext);
+        void System.ServiceModel.Description.IWsdlImportExtension.BeforeImport(ServiceDescriptionCollection wsdlDocuments, XmlSchemaSet xmlSchemas, ICollection<XmlElement> policy);
+        void System.ServiceModel.Description.IWsdlImportExtension.ImportContract(WsdlImporter importer, WsdlContractConversionContext context);
+        void System.ServiceModel.Description.IWsdlImportExtension.ImportEndpoint(WsdlImporter importer, WsdlEndpointConversionContext context);
+    }
+    public sealed class TransportSecurityBindingElement : SecurityBindingElement, IPolicyExportExtension {
+        public TransportSecurityBindingElement();
+        protected override IChannelFactory<TChannel> BuildChannelFactoryCore<TChannel>(BindingContext context);
+        protected override IChannelListener<TChannel> BuildChannelListenerCore<TChannel>(BindingContext context);
+        public override BindingElement Clone();
+        public override T GetProperty<T>(BindingContext context);
+        void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(MetadataExporter exporter, PolicyConversionContext policyContext);
+    }
+    public sealed class UdpRetransmissionSettings {
+        public UdpRetransmissionSettings();
+        public UdpRetransmissionSettings(int maxUnicastRetransmitCount, int maxMulticastRetransmitCount);
+        public UdpRetransmissionSettings(int maxUnicastRetransmitCount, int maxMulticastRetransmitCount, TimeSpan delayLowerBound, TimeSpan delayUpperBound, TimeSpan maxDelayPerRetransmission);
+        public TimeSpan DelayLowerBound { get; set; }
+        public TimeSpan DelayUpperBound { get; set; }
+        public TimeSpan MaxDelayPerRetransmission { get; set; }
+        public int MaxMulticastRetransmitCount { get; set; }
+        public int MaxUnicastRetransmitCount { get; set; }
+        public bool ShouldSerializeDelayLowerBound();
+        public bool ShouldSerializeDelayUpperBound();
+        public bool ShouldSerializeMaxDelayPerRetransmission();
+    }
+    public class UdpTransportBindingElement : TransportBindingElement, IPolicyExportExtension, ITransportPolicyImport, IWsdlExportExtension {
+        public UdpTransportBindingElement();
+        public int DuplicateMessageHistoryLength { get; set; }
+        public long MaxPendingMessagesTotalSize { get; set; }
+        public string MulticastInterfaceId { get; set; }
+        public UdpRetransmissionSettings RetransmissionSettings { get; set; }
+        public override string Scheme { get; }
+        public int SocketReceiveBufferSize { get; set; }
+        public int TimeToLive { get; set; }
+        public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context);
+        public override IChannelListener<TChannel> BuildChannelListener<TChannel>(BindingContext context);
+        public override bool CanBuildChannelFactory<TChannel>(BindingContext context);
+        public override bool CanBuildChannelListener<TChannel>(BindingContext context);
+        public override BindingElement Clone();
+        public override T GetProperty<T>(BindingContext context);
+        public bool ShouldSerializeRetransmissionSettings();
+        void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(MetadataExporter exporter, PolicyConversionContext context);
+        void System.ServiceModel.Description.IWsdlExportExtension.ExportContract(WsdlExporter exporter, WsdlContractConversionContext context);
+        void System.ServiceModel.Description.IWsdlExportExtension.ExportEndpoint(WsdlExporter exporter, WsdlEndpointConversionContext context);
+    }
+    public class UdpTransportImporter : IPolicyImportExtension, IWsdlImportExtension {
+        public UdpTransportImporter();
+        public void BeforeImport(ServiceDescriptionCollection wsdlDocuments, XmlSchemaSet xmlSchemas, ICollection<XmlElement> policy);
+        public void ImportContract(WsdlImporter importer, WsdlContractConversionContext context);
+        public void ImportEndpoint(WsdlImporter importer, WsdlEndpointConversionContext context);
+        public void ImportPolicy(MetadataImporter importer, PolicyConversionContext context);
+    }
+    public sealed class UnderstoodHeaders : IEnumerable, IEnumerable<MessageHeaderInfo> {
+        public void Add(MessageHeaderInfo headerInfo);
+        public bool Contains(MessageHeaderInfo headerInfo);
+        public IEnumerator<MessageHeaderInfo> GetEnumerator();
+        public void Remove(MessageHeaderInfo headerInfo);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+    }
+    public sealed class UseManagedPresentationBindingElement : BindingElement, IPolicyExportExtension {
+        public UseManagedPresentationBindingElement();
+        public override BindingElement Clone();
+        public override T GetProperty<T>(BindingContext context);
+        void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(MetadataExporter exporter, PolicyConversionContext context);
+    }
+    public sealed class UseManagedPresentationBindingElementImporter : IPolicyImportExtension {
+        public UseManagedPresentationBindingElementImporter();
+        void System.ServiceModel.Description.IPolicyImportExtension.ImportPolicy(MetadataImporter importer, PolicyConversionContext policyContext);
+    }
+    public sealed class WebBodyFormatMessageProperty : IMessageProperty {
+        public const string Name = "WebBodyFormatMessageProperty";
+        public WebBodyFormatMessageProperty(WebContentFormat format);
+        public WebContentFormat Format { get; }
+        public IMessageProperty CreateCopy();
+        public override string ToString();
+    }
+    public enum WebContentFormat {
+        Default = 0,
+        Json = 2,
+        Raw = 3,
+        Xml = 1,
+    }
+    public abstract class WebContentTypeMapper {
+        protected WebContentTypeMapper();
+        public abstract WebContentFormat GetMessageFormatForContentType(string contentType);
+    }
+    public sealed class WebMessageEncodingBindingElement : MessageEncodingBindingElement, IWmiInstanceProvider, IWsdlExportExtension {
+        public WebMessageEncodingBindingElement();
+        public WebMessageEncodingBindingElement(Encoding writeEncoding);
+        public WebContentTypeMapper ContentTypeMapper { get; set; }
+        public bool CrossDomainScriptAccessEnabled { get; set; }
+        public int MaxReadPoolSize { get; set; }
+        public int MaxWritePoolSize { get; set; }
+        public override MessageVersion MessageVersion { get; set; }
+        public XmlDictionaryReaderQuotas ReaderQuotas { get; }
+        public Encoding WriteEncoding { get; set; }
+        public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context);
+        public override IChannelListener<TChannel> BuildChannelListener<TChannel>(BindingContext context);
+        public override bool CanBuildChannelListener<TChannel>(BindingContext context);
+        public override BindingElement Clone();
+        public override MessageEncoderFactory CreateMessageEncoderFactory();
+        public override T GetProperty<T>(BindingContext context);
+        void System.ServiceModel.Description.IWsdlExportExtension.ExportContract(WsdlExporter exporter, WsdlContractConversionContext context);
+        void System.ServiceModel.Description.IWsdlExportExtension.ExportEndpoint(WsdlExporter exporter, WsdlEndpointConversionContext context);
+    }
+    public sealed class WebSocketMessageProperty {
+        public const string Name = "WebSocketMessageProperty";
+        public WebSocketMessageProperty();
+        public WebSocketMessageType MessageType { get; set; }
+        public ReadOnlyDictionary<string, object> OpeningHandshakeProperties { get; }
+        public string SubProtocol { get; }
+        public WebSocketContext WebSocketContext { get; }
+    }
+    public sealed class WebSocketTransportSettings : IEquatable<WebSocketTransportSettings> {
+        public const string BinaryEncoderTransferModeHeader = "microsoft-binary-transfer-mode";
+        public const string BinaryMessageReceivedAction = "http://schemas.microsoft.com/2011/02/websockets/onbinarymessage";
+        public const string ConnectionOpenedAction = "http://schemas.microsoft.com/2011/02/session/onopen";
+        public const string SoapContentTypeHeader = "soap-content-type";
+        public const string TextMessageReceivedAction = "http://schemas.microsoft.com/2011/02/websockets/ontextmessage";
+        public WebSocketTransportSettings();
+        public bool CreateNotificationOnConnection { get; set; }
+        public bool DisablePayloadMasking { get; set; }
+        public TimeSpan KeepAliveInterval { get; set; }
+        public int MaxPendingConnections { get; set; }
+        public string SubProtocol { get; set; }
+        public WebSocketTransportUsage TransportUsage { get; set; }
+        public override bool Equals(object obj);
+        public bool Equals(WebSocketTransportSettings other);
+        public override int GetHashCode();
+    }
+    public enum WebSocketTransportUsage {
+        Always = 1,
+        Never = 2,
+        WhenDuplex = 0,
+    }
+    public class WindowsStreamSecurityBindingElement : StreamUpgradeBindingElement, IPolicyExportExtension, ITransportTokenAssertionProvider {
+        public WindowsStreamSecurityBindingElement();
+        protected WindowsStreamSecurityBindingElement(WindowsStreamSecurityBindingElement elementToBeCloned);
+        public ProtectionLevel ProtectionLevel { get; set; }
+        public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context);
+        public override IChannelListener<TChannel> BuildChannelListener<TChannel>(BindingContext context);
+        public override StreamUpgradeProvider BuildClientStreamUpgradeProvider(BindingContext context);
+        public override StreamUpgradeProvider BuildServerStreamUpgradeProvider(BindingContext context);
+        public override bool CanBuildChannelFactory<TChannel>(BindingContext context);
+        public override bool CanBuildChannelListener<TChannel>(BindingContext context);
+        public override BindingElement Clone();
+        public override T GetProperty<T>(BindingContext context);
+        public XmlElement GetTransportTokenAssertion();
+        void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(MetadataExporter exporter, PolicyConversionContext context);
+    }
+    public class WrappedOptions {
+        public WrappedOptions();
+        public bool WrappedFlag { get; set; }
+    }
+    public class XmlSerializerImportOptions {
+        public XmlSerializerImportOptions();
+        public XmlSerializerImportOptions(CodeCompileUnit codeCompileUnit);
+        public string ClrNamespace { get; set; }
+        public CodeCompileUnit CodeCompileUnit { get; }
+        public CodeDomProvider CodeProvider { get; set; }
+        public WebReferenceOptions WebReferenceOptions { get; set; }
+    }
+}
```

