# System.ServiceModel.Dispatcher

``` diff
+namespace System.ServiceModel.Dispatcher {
+    public class ActionMessageFilter : MessageFilter {
+        public ActionMessageFilter(params string[] actions);
+        public ReadOnlyCollection<string> Actions { get; }
+        protected internal override IMessageFilterTable<FilterData> CreateFilterTable<FilterData>();
+        public override bool Match(Message message);
+        public override bool Match(MessageBuffer messageBuffer);
+    }
+    public class ChannelDispatcher : ChannelDispatcherBase {
+        public ChannelDispatcher(IChannelListener listener);
+        public ChannelDispatcher(IChannelListener listener, string bindingName);
+        public ChannelDispatcher(IChannelListener listener, string bindingName, IDefaultCommunicationTimeouts timeouts);
+        public bool AsynchronousTransactedAcceptEnabled { get; set; }
+        public string BindingName { get; }
+        public SynchronizedCollection<IChannelInitializer> ChannelInitializers { get; }
+        protected override TimeSpan DefaultCloseTimeout { get; }
+        protected override TimeSpan DefaultOpenTimeout { get; }
+        public SynchronizedCollection<EndpointDispatcher> Endpoints { get; }
+        public Collection<IErrorHandler> ErrorHandlers { get; }
+        public override ServiceHostBase Host { get; }
+        public bool IncludeExceptionDetailInFaults { get; set; }
+        public bool IsTransactedAccept { get; }
+        public bool IsTransactedReceive { get; set; }
+        public override IChannelListener Listener { get; }
+        public bool ManualAddressing { get; set; }
+        public int MaxPendingReceives { get; set; }
+        public int MaxTransactedBatchSize { get; set; }
+        public MessageVersion MessageVersion { get; set; }
+        public bool ReceiveContextEnabled { get; set; }
+        public bool ReceiveSynchronously { get; set; }
+        public bool SendAsynchronously { get; set; }
+        public ServiceThrottle ServiceThrottle { get; set; }
+        public IsolationLevel TransactionIsolationLevel { get; set; }
+        public TimeSpan TransactionTimeout { get; set; }
+        protected override void Attach(ServiceHostBase host);
+        public override void CloseInput();
+        protected override void Detach(ServiceHostBase host);
+        protected override void OnAbort();
+        protected override IAsyncResult OnBeginClose(TimeSpan timeout, AsyncCallback callback, object state);
+        protected override IAsyncResult OnBeginOpen(TimeSpan timeout, AsyncCallback callback, object state);
+        protected override void OnClose(TimeSpan timeout);
+        protected override void OnClosed();
+        protected override void OnEndClose(IAsyncResult result);
+        protected override void OnEndOpen(IAsyncResult result);
+        protected override void OnOpen(TimeSpan timeout);
+        protected override void OnOpened();
+        protected override void OnOpening();
+    }
+    public abstract class ChannelDispatcherBase : CommunicationObject {
+        protected ChannelDispatcherBase();
+        public abstract ServiceHostBase Host { get; }
+        public abstract IChannelListener Listener { get; }
+        protected virtual void Attach(ServiceHostBase host);
+        public virtual void CloseInput();
+        protected virtual void Detach(ServiceHostBase host);
+    }
+    public class ChannelDispatcherCollection : SynchronizedCollection<ChannelDispatcherBase> {
+        protected override void ClearItems();
+        protected override void InsertItem(int index, ChannelDispatcherBase item);
+        protected override void RemoveItem(int index);
+        protected override void SetItem(int index, ChannelDispatcherBase item);
+    }
+    public sealed class ClientOperation : ClientOperationCompatBase {
+        public ClientOperation(ClientRuntime parent, string name, string action);
+        public ClientOperation(ClientRuntime parent, string name, string action, string replyAction);
+        public string Action { get; }
+        public MethodInfo BeginMethod { get; set; }
+        public ICollection<IParameterInspector> ClientParameterInspectors { get; }
+        public bool DeserializeReply { get; set; }
+        public MethodInfo EndMethod { get; set; }
+        public SynchronizedCollection<FaultContractInfo> FaultContractInfos { get; }
+        public IClientMessageFormatter Formatter { get; set; }
+        public bool IsInitiating { get; set; }
+        public bool IsOneWay { get; set; }
+        public bool IsTerminating { get; set; }
+        public string Name { get; }
+        public new SynchronizedCollection<IParameterInspector> ParameterInspectors { get; }
+        public ClientRuntime Parent { get; }
+        public string ReplyAction { get; }
+        public bool SerializeRequest { get; set; }
+        public MethodInfo SyncMethod { get; set; }
+        public MethodInfo TaskMethod { get; set; }
+        public Type TaskTResult { get; set; }
+    }
+    public class ClientOperationCompatBase {
+        public IList<IParameterInspector> ParameterInspectors { get; }
+    }
+    public sealed class ClientRuntime : ClientRuntimeCompatBase {
+        public Type CallbackClientType { get; set; }
+        public DispatchRuntime CallbackDispatchRuntime { get; }
+        public SynchronizedCollection<IChannelInitializer> ChannelInitializers { get; }
+        public ICollection<IClientMessageInspector> ClientMessageInspectors { get; }
+        public ICollection<ClientOperation> ClientOperations { get; }
+        public Type ContractClientType { get; set; }
+        public string ContractName { get; }
+        public string ContractNamespace { get; }
+        public SynchronizedCollection<IInteractiveChannelInitializer> InteractiveChannelInitializers { get; }
+        public bool ManualAddressing { get; set; }
+        public int MaxFaultSize { get; set; }
+        public new SynchronizedCollection<IClientMessageInspector> MessageInspectors { get; }
+        public bool MessageVersionNoneFaultsEnabled { get; set; }
+        public new SynchronizedKeyedCollection<string, ClientOperation> Operations { get; }
+        public IClientOperationSelector OperationSelector { get; set; }
+        public ClientOperation UnhandledClientOperation { get; }
+        public bool ValidateMustUnderstand { get; set; }
+        public Uri Via { get; set; }
+    }
+    public class ClientRuntimeCompatBase {
+        public IList<IClientMessageInspector> MessageInspectors { get; }
+        public KeyedCollection<string, ClientOperation> Operations { get; }
+    }
+    public sealed class DispatchOperation {
+        public DispatchOperation(DispatchRuntime parent, string name, string action);
+        public DispatchOperation(DispatchRuntime parent, string name, string action, string replyAction);
+        public string Action { get; }
+        public bool AutoDisposeParameters { get; set; }
+        public SynchronizedCollection<ICallContextInitializer> CallContextInitializers { get; }
+        public bool DeserializeRequest { get; set; }
+        public SynchronizedCollection<FaultContractInfo> FaultContractInfos { get; }
+        public IDispatchMessageFormatter Formatter { get; set; }
+        public ImpersonationOption Impersonation { get; set; }
+        public IOperationInvoker Invoker { get; set; }
+        public bool IsInsideTransactedReceiveScope { get; set; }
+        public bool IsOneWay { get; }
+        public bool IsTerminating { get; set; }
+        public string Name { get; }
+        public SynchronizedCollection<IParameterInspector> ParameterInspectors { get; }
+        public DispatchRuntime Parent { get; }
+        public bool ReleaseInstanceAfterCall { get; set; }
+        public bool ReleaseInstanceBeforeCall { get; set; }
+        public string ReplyAction { get; }
+        public bool SerializeReply { get; set; }
+        public bool TransactionAutoComplete { get; set; }
+        public bool TransactionRequired { get; set; }
+    }
+    public sealed class DispatchRuntime {
+        public bool AutomaticInputSessionShutdown { get; set; }
+        public ClientRuntime CallbackClientRuntime { get; }
+        public ChannelDispatcher ChannelDispatcher { get; }
+        public ConcurrencyMode ConcurrencyMode { get; set; }
+        public EndpointDispatcher EndpointDispatcher { get; }
+        public bool EnsureOrderedDispatch { get; set; }
+        public ReadOnlyCollection<IAuthorizationPolicy> ExternalAuthorizationPolicies { get; set; }
+        public bool IgnoreTransactionMessageProperty { get; set; }
+        public bool ImpersonateCallerForAllOperations { get; set; }
+        public bool ImpersonateOnSerializingReply { get; set; }
+        public SynchronizedCollection<IInputSessionShutdown> InputSessionShutdownHandlers { get; }
+        public SynchronizedCollection<IInstanceContextInitializer> InstanceContextInitializers { get; }
+        public IInstanceContextProvider InstanceContextProvider { get; set; }
+        public IInstanceProvider InstanceProvider { get; set; }
+        public AuditLevel MessageAuthenticationAuditLevel { get; set; }
+        public SynchronizedCollection<IDispatchMessageInspector> MessageInspectors { get; }
+        public SynchronizedKeyedCollection<string, DispatchOperation> Operations { get; }
+        public IDispatchOperationSelector OperationSelector { get; set; }
+        public bool PreserveMessage { get; set; }
+        public PrincipalPermissionMode PrincipalPermissionMode { get; set; }
+        public bool ReleaseServiceInstanceOnTransactionComplete { get; set; }
+        public RoleProvider RoleProvider { get; set; }
+        public AuditLogLocation SecurityAuditLogLocation { get; set; }
+        public ServiceAuthenticationManager ServiceAuthenticationManager { get; set; }
+        public AuditLevel ServiceAuthorizationAuditLevel { get; set; }
+        public ServiceAuthorizationManager ServiceAuthorizationManager { get; set; }
+        public InstanceContext SingletonInstanceContext { get; set; }
+        public bool SuppressAuditFailure { get; set; }
+        public SynchronizationContext SynchronizationContext { get; set; }
+        public bool TransactionAutoCompleteOnSessionClose { get; set; }
+        public Type Type { get; set; }
+        public DispatchOperation UnhandledDispatchOperation { get; set; }
+        public bool ValidateMustUnderstand { get; set; }
+    }
+    public static class DurableOperationContext {
+        public static Guid InstanceId { get; }
+        public static void AbortInstance();
+        public static void CompleteInstance();
+    }
+    public class EndpointAddressMessageFilter : MessageFilter {
+        public EndpointAddressMessageFilter(EndpointAddress address);
+        public EndpointAddressMessageFilter(EndpointAddress address, bool includeHostNameInComparison);
+        public EndpointAddress Address { get; }
+        public bool IncludeHostNameInComparison { get; }
+        protected internal override IMessageFilterTable<FilterData> CreateFilterTable<FilterData>();
+        public override bool Match(Message message);
+        public override bool Match(MessageBuffer messageBuffer);
+    }
+    public class EndpointDispatcher {
+        public EndpointDispatcher(EndpointAddress address, string contractName, string contractNamespace);
+        public EndpointDispatcher(EndpointAddress address, string contractName, string contractNamespace, bool isSystemEndpoint);
+        public MessageFilter AddressFilter { get; set; }
+        public ChannelDispatcher ChannelDispatcher { get; }
+        public MessageFilter ContractFilter { get; set; }
+        public string ContractName { get; }
+        public string ContractNamespace { get; }
+        public DispatchRuntime DispatchRuntime { get; }
+        public EndpointAddress EndpointAddress { get; }
+        public int FilterPriority { get; set; }
+        public bool IsSystemEndpoint { get; }
+    }
+    public class EndpointNameMessageFilter : MessageFilter {
+        public EndpointNameMessageFilter(string endpointName);
+        public override bool Match(Message message);
+        public override bool Match(MessageBuffer buffer);
+    }
+    public abstract class ExceptionHandler {
+        protected ExceptionHandler();
+        public static ExceptionHandler AlwaysHandle { get; }
+        public static ExceptionHandler AsynchronousThreadExceptionHandler { get; set; }
+        public static ExceptionHandler TransportExceptionHandler { get; set; }
+        public abstract bool HandleException(Exception exception);
+    }
+    public class FaultContractInfo {
+        public FaultContractInfo(string action, Type detail);
+        public string Action { get; }
+        public Type Detail { get; }
+    }
+    public class FilterInvalidBodyAccessException : InvalidBodyAccessException {
+        public FilterInvalidBodyAccessException();
+        protected FilterInvalidBodyAccessException(SerializationInfo info, StreamingContext context);
+        public FilterInvalidBodyAccessException(string message);
+        public FilterInvalidBodyAccessException(string message, Collection<MessageFilter> filters);
+        public FilterInvalidBodyAccessException(string message, Exception innerException);
+        public FilterInvalidBodyAccessException(string message, Exception innerException, Collection<MessageFilter> filters);
+        public Collection<MessageFilter> Filters { get; }
+    }
+    public interface ICallContextInitializer {
+        void AfterInvoke(object correlationState);
+        object BeforeInvoke(InstanceContext instanceContext, IClientChannel channel, Message message);
+    }
+    public interface IChannelInitializer {
+        void Initialize(IClientChannel channel);
+    }
+    public interface IClientMessageFormatter {
+        object DeserializeReply(Message message, object[] parameters);
+        Message SerializeRequest(MessageVersion messageVersion, object[] parameters);
+    }
+    public interface IClientMessageInspector {
+        void AfterReceiveReply(ref Message reply, object correlationState);
+        object BeforeSendRequest(ref Message request, IClientChannel channel);
+    }
+    public interface IClientOperationSelector {
+        bool AreParametersRequiredForSelection { get; }
+        string SelectOperation(MethodBase method, object[] parameters);
+    }
+    public interface IDispatchMessageFormatter {
+        void DeserializeRequest(Message message, object[] parameters);
+        Message SerializeReply(MessageVersion messageVersion, object[] parameters, object result);
+    }
+    public interface IDispatchMessageInspector {
+        object AfterReceiveRequest(ref Message request, IClientChannel channel, InstanceContext instanceContext);
+        void BeforeSendReply(ref Message reply, object correlationState);
+    }
+    public interface IDispatchOperationSelector {
+        string SelectOperation(ref Message message);
+    }
+    public interface IErrorHandler {
+        bool HandleError(Exception error);
+        void ProvideFault(Exception error, MessageVersion version, ref Message fault);
+    }
+    public interface IInputSessionShutdown {
+        void ChannelFaulted(IDuplexContextChannel channel);
+        void DoneReceiving(IDuplexContextChannel channel);
+    }
+    public interface IInstanceContextInitializer {
+        void Initialize(InstanceContext instanceContext, Message message);
+    }
+    public interface IInstanceContextProvider {
+        InstanceContext GetExistingInstanceContext(Message message, IContextChannel channel);
+        void InitializeInstanceContext(InstanceContext instanceContext, Message message, IContextChannel channel);
+        bool IsIdle(InstanceContext instanceContext);
+        void NotifyIdle(InstanceContextIdleCallback callback, InstanceContext instanceContext);
+    }
+    public interface IInstanceProvider {
+        object GetInstance(InstanceContext instanceContext);
+        object GetInstance(InstanceContext instanceContext, Message message);
+        void ReleaseInstance(InstanceContext instanceContext, object instance);
+    }
+    public interface IInteractiveChannelInitializer {
+        IAsyncResult BeginDisplayInitializationUI(IClientChannel channel, AsyncCallback callback, object state);
+        void EndDisplayInitializationUI(IAsyncResult result);
+    }
+    public interface IMessageFilterTable<TFilterData> : ICollection<KeyValuePair<MessageFilter, TFilterData>>, IDictionary<MessageFilter, TFilterData>, IEnumerable, IEnumerable<KeyValuePair<MessageFilter, TFilterData>> {
+        bool GetMatchingFilter(Message message, out MessageFilter filter);
+        bool GetMatchingFilter(MessageBuffer messageBuffer, out MessageFilter filter);
+        bool GetMatchingFilters(Message message, ICollection<MessageFilter> results);
+        bool GetMatchingFilters(MessageBuffer messageBuffer, ICollection<MessageFilter> results);
+        bool GetMatchingValue(Message message, out TFilterData value);
+        bool GetMatchingValue(MessageBuffer messageBuffer, out TFilterData value);
+        bool GetMatchingValues(Message message, ICollection<TFilterData> results);
+        bool GetMatchingValues(MessageBuffer messageBuffer, ICollection<TFilterData> results);
+    }
+    public delegate void InstanceContextIdleCallback(InstanceContext instanceContext);
+    public abstract class InvalidBodyAccessException : SystemException {
+        protected InvalidBodyAccessException(SerializationInfo info, StreamingContext context);
+        protected InvalidBodyAccessException(string message);
+        protected InvalidBodyAccessException(string message, Exception innerException);
+    }
+    public interface IOperationInvoker {
+        bool IsSynchronous { get; }
+        object[] AllocateInputs();
+        object Invoke(object instance, object[] inputs, out object[] outputs);
+        IAsyncResult InvokeBegin(object instance, object[] inputs, AsyncCallback callback, object state);
+        object InvokeEnd(object instance, out object[] outputs, IAsyncResult result);
+    }
+    public interface IParameterInspector {
+        void AfterCall(string operationName, object[] outputs, object returnValue, object correlationState);
+        object BeforeCall(string operationName, object[] inputs);
+    }
+    public class JsonQueryStringConverter : QueryStringConverter {
+        public JsonQueryStringConverter();
+        public override bool CanConvert(Type type);
+        public override object ConvertStringToValue(string parameter, Type parameterType);
+        public override string ConvertValueToString(object parameter, Type parameterType);
+    }
+    public class MatchAllMessageFilter : MessageFilter {
+        public MatchAllMessageFilter();
+        public override bool Match(Message message);
+        public override bool Match(MessageBuffer messageBuffer);
+    }
+    public class MatchNoneMessageFilter : MessageFilter {
+        public MatchNoneMessageFilter();
+        public override bool Match(Message message);
+        public override bool Match(MessageBuffer messageBuffer);
+    }
+    public abstract class MessageFilter {
+        protected MessageFilter();
+        protected internal virtual IMessageFilterTable<FilterData> CreateFilterTable<FilterData>();
+        public abstract bool Match(Message message);
+        public abstract bool Match(MessageBuffer buffer);
+    }
+    public class MessageFilterException : CommunicationException {
+        public MessageFilterException();
+        protected MessageFilterException(SerializationInfo info, StreamingContext context);
+        public MessageFilterException(string message);
+        public MessageFilterException(string message, Collection<MessageFilter> filters);
+        public MessageFilterException(string message, Exception innerException);
+        public MessageFilterException(string message, Exception innerException, Collection<MessageFilter> filters);
+        public Collection<MessageFilter> Filters { get; }
+    }
+    public class MessageFilterTable<TFilterData> : ICollection<KeyValuePair<MessageFilter, TFilterData>>, IDictionary<MessageFilter, TFilterData>, IEnumerable, IEnumerable<KeyValuePair<MessageFilter, TFilterData>>, IMessageFilterTable<TFilterData> {
+        public MessageFilterTable();
+        public MessageFilterTable(int defaultPriority);
+        public int Count { get; }
+        public int DefaultPriority { get; set; }
+        public bool IsReadOnly { get; }
+        public ICollection<MessageFilter> Keys { get; }
+        public TFilterData this[MessageFilter filter] { get; set; }
+        public ICollection<TFilterData> Values { get; }
+        public void Add(KeyValuePair<MessageFilter, TFilterData> item);
+        public void Add(MessageFilter filter, TFilterData data);
+        public void Add(MessageFilter filter, TFilterData data, int priority);
+        public void Clear();
+        public bool Contains(KeyValuePair<MessageFilter, TFilterData> item);
+        public bool ContainsKey(MessageFilter filter);
+        public void CopyTo(KeyValuePair<MessageFilter, TFilterData>[] array, int arrayIndex);
+        protected virtual IMessageFilterTable<TFilterData> CreateFilterTable(MessageFilter filter);
+        public IEnumerator<KeyValuePair<MessageFilter, TFilterData>> GetEnumerator();
+        public bool GetMatchingFilter(Message message, out MessageFilter filter);
+        public bool GetMatchingFilter(MessageBuffer buffer, out MessageFilter filter);
+        public bool GetMatchingFilters(Message message, ICollection<MessageFilter> results);
+        public bool GetMatchingFilters(MessageBuffer buffer, ICollection<MessageFilter> results);
+        public bool GetMatchingValue(Message message, out TFilterData data);
+        public bool GetMatchingValue(MessageBuffer buffer, out TFilterData data);
+        public bool GetMatchingValues(Message message, ICollection<TFilterData> results);
+        public bool GetMatchingValues(MessageBuffer buffer, ICollection<TFilterData> results);
+        public int GetPriority(MessageFilter filter);
+        public bool Remove(KeyValuePair<MessageFilter, TFilterData> item);
+        public bool Remove(MessageFilter filter);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        public bool TryGetValue(MessageFilter filter, out TFilterData data);
+    }
+    public abstract class MessageQuery {
+        protected MessageQuery();
+        public virtual MessageQueryCollection CreateMessageQueryCollection();
+        public abstract TResult Evaluate<TResult>(Message message);
+        public abstract TResult Evaluate<TResult>(MessageBuffer buffer);
+    }
+    public abstract class MessageQueryCollection : Collection<MessageQuery> {
+        protected MessageQueryCollection();
+        public abstract IEnumerable<KeyValuePair<MessageQuery, TResult>> Evaluate<TResult>(Message message);
+        public abstract IEnumerable<KeyValuePair<MessageQuery, TResult>> Evaluate<TResult>(MessageBuffer buffer);
+    }
+    public class MessageQueryTable<TItem> : ICollection<KeyValuePair<MessageQuery, TItem>>, IDictionary<MessageQuery, TItem>, IEnumerable, IEnumerable<KeyValuePair<MessageQuery, TItem>> {
+        public MessageQueryTable();
+        public int Count { get; }
+        public bool IsReadOnly { get; }
+        public ICollection<MessageQuery> Keys { get; }
+        public TItem this[MessageQuery key] { get; set; }
+        public ICollection<TItem> Values { get; }
+        public void Add(KeyValuePair<MessageQuery, TItem> item);
+        public void Add(MessageQuery key, TItem value);
+        public void Clear();
+        public bool Contains(KeyValuePair<MessageQuery, TItem> item);
+        public bool ContainsKey(MessageQuery key);
+        public void CopyTo(KeyValuePair<MessageQuery, TItem>[] array, int arrayIndex);
+        public IEnumerable<KeyValuePair<MessageQuery, TResult>> Evaluate<TResult>(Message message);
+        public IEnumerable<KeyValuePair<MessageQuery, TResult>> Evaluate<TResult>(MessageBuffer buffer);
+        public IEnumerator<KeyValuePair<MessageQuery, TItem>> GetEnumerator();
+        public bool Remove(KeyValuePair<MessageQuery, TItem> item);
+        public bool Remove(MessageQuery key);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        public bool TryGetValue(MessageQuery key, out TItem value);
+    }
+    public class MultipleFilterMatchesException : SystemException {
+        public MultipleFilterMatchesException();
+        protected MultipleFilterMatchesException(SerializationInfo info, StreamingContext context);
+        public MultipleFilterMatchesException(string message);
+        public MultipleFilterMatchesException(string message, Collection<MessageFilter> filters);
+        public MultipleFilterMatchesException(string message, Exception innerException);
+        public MultipleFilterMatchesException(string message, Exception innerException, Collection<MessageFilter> filters);
+        public Collection<MessageFilter> Filters { get; }
+    }
+    public class NavigatorInvalidBodyAccessException : InvalidBodyAccessException {
+        public NavigatorInvalidBodyAccessException();
+        protected NavigatorInvalidBodyAccessException(SerializationInfo info, StreamingContext context);
+        public NavigatorInvalidBodyAccessException(string message);
+        public NavigatorInvalidBodyAccessException(string message, Exception innerException);
+    }
+    public class PrefixEndpointAddressMessageFilter : MessageFilter {
+        public PrefixEndpointAddressMessageFilter(EndpointAddress address);
+        public PrefixEndpointAddressMessageFilter(EndpointAddress address, bool includeHostNameInComparison);
+        public EndpointAddress Address { get; }
+        public bool IncludeHostNameInComparison { get; }
+        protected internal override IMessageFilterTable<FilterData> CreateFilterTable<FilterData>();
+        public override bool Match(Message message);
+        public override bool Match(MessageBuffer messageBuffer);
+    }
+    public class QueryStringConverter {
+        public QueryStringConverter();
+        public virtual bool CanConvert(Type type);
+        public virtual object ConvertStringToValue(string parameter, Type parameterType);
+        public virtual string ConvertValueToString(object parameter, Type parameterType);
+    }
+    public abstract class SeekableXPathNavigator : XPathNavigator {
+        protected SeekableXPathNavigator();
+        public abstract long CurrentPosition { get; set; }
+        public abstract XmlNodeOrder ComparePosition(long firstPosition, long secondPosition);
+        public abstract string GetLocalName(long nodePosition);
+        public abstract string GetName(long nodePosition);
+        public abstract string GetNamespace(long nodePosition);
+        public abstract XPathNodeType GetNodeType(long nodePosition);
+        public abstract string GetValue(long nodePosition);
+    }
+    public sealed class ServiceThrottle {
+        public int MaxConcurrentCalls { get; set; }
+        public int MaxConcurrentInstances { get; set; }
+        public int MaxConcurrentSessions { get; set; }
+    }
+    public class StrictAndMessageFilter : MessageFilter {
+        public StrictAndMessageFilter(MessageFilter filter1, MessageFilter filter2);
+        protected internal override IMessageFilterTable<TFilterData> CreateFilterTable<TFilterData>();
+        public override bool Match(Message message);
+        public override bool Match(MessageBuffer buffer);
+    }
+    public class WebHttpDispatchOperationSelector : IDispatchOperationSelector {
+        public const string HttpOperationNamePropertyName = "HttpOperationName";
+        public const string HttpOperationSelectorUriMatchedPropertyName = "UriMatched";
+        protected WebHttpDispatchOperationSelector();
+        public WebHttpDispatchOperationSelector(ServiceEndpoint endpoint);
+        public virtual UriTemplate GetUriTemplate(string operationName);
+        public string SelectOperation(ref Message message);
+        protected virtual string SelectOperation(ref Message message, out bool uriMatched);
+    }
+    public class XPathMessageContext : XsltContext {
+        public XPathMessageContext();
+        public XPathMessageContext(NameTable table);
+        public override bool Whitespace { get; }
+        public override int CompareDocument(string baseUri, string nextBaseUri);
+        public override bool PreserveWhitespace(XPathNavigator node);
+        public override IXsltContextFunction ResolveFunction(string prefix, string name, XPathResultType[] argTypes);
+        public override IXsltContextVariable ResolveVariable(string prefix, string name);
+    }
+    public class XPathMessageFilter : MessageFilter, IXmlSerializable {
+        public XPathMessageFilter();
+        public XPathMessageFilter(string xpath);
+        public XPathMessageFilter(string xpath, XmlNamespaceManager namespaces);
+        public XPathMessageFilter(string xpath, XsltContext context);
+        public XPathMessageFilter(XmlReader reader);
+        public XPathMessageFilter(XmlReader reader, XmlNamespaceManager namespaces);
+        public XPathMessageFilter(XmlReader reader, XsltContext context);
+        public XmlNamespaceManager Namespaces { get; }
+        public int NodeQuota { get; set; }
+        public string XPath { get; }
+        protected internal override IMessageFilterTable<FilterData> CreateFilterTable<FilterData>();
+        public override bool Match(Message message);
+        public override bool Match(MessageBuffer messageBuffer);
+        public bool Match(SeekableXPathNavigator navigator);
+        public bool Match(XPathNavigator navigator);
+        protected virtual XmlSchema OnGetSchema();
+        protected virtual void OnReadXml(XmlReader reader);
+        protected virtual void OnWriteXml(XmlWriter writer);
+        protected void ReadXPath(XmlReader reader, XmlNamespaceManager namespaces);
+        public static XmlSchemaType StaticGetSchema(XmlSchemaSet schemas);
+        XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
+        void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader);
+        void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer);
+        public void TrimToSize();
+        protected void WriteXPath(XmlWriter writer, IXmlNamespaceResolver resolver);
+        public void WriteXPathTo(XmlWriter writer, string prefix, string localName, string ns, bool writeNamespaces);
+    }
+    public class XPathMessageFilterTable<TFilterData> : ICollection<KeyValuePair<MessageFilter, TFilterData>>, IDictionary<MessageFilter, TFilterData>, IEnumerable, IEnumerable<KeyValuePair<MessageFilter, TFilterData>>, IMessageFilterTable<TFilterData> {
+        public XPathMessageFilterTable();
+        public XPathMessageFilterTable(int capacity);
+        public int Count { get; }
+        public bool IsReadOnly { get; }
+        public ICollection<MessageFilter> Keys { get; }
+        public int NodeQuota { get; set; }
+        public TFilterData this[MessageFilter filter] { get; set; }
+        public ICollection<TFilterData> Values { get; }
+        public void Add(KeyValuePair<MessageFilter, TFilterData> item);
+        public void Add(MessageFilter filter, TFilterData data);
+        public void Add(XPathMessageFilter filter, TFilterData data);
+        public void Clear();
+        public bool Contains(KeyValuePair<MessageFilter, TFilterData> item);
+        public bool ContainsKey(MessageFilter filter);
+        public void CopyTo(KeyValuePair<MessageFilter, TFilterData>[] array, int arrayIndex);
+        public IEnumerator<KeyValuePair<MessageFilter, TFilterData>> GetEnumerator();
+        public bool GetMatchingFilter(Message message, out MessageFilter filter);
+        public bool GetMatchingFilter(MessageBuffer messageBuffer, out MessageFilter filter);
+        public bool GetMatchingFilter(SeekableXPathNavigator navigator, out MessageFilter filter);
+        public bool GetMatchingFilter(XPathNavigator navigator, out MessageFilter filter);
+        public bool GetMatchingFilters(Message message, ICollection<MessageFilter> results);
+        public bool GetMatchingFilters(MessageBuffer messageBuffer, ICollection<MessageFilter> results);
+        public bool GetMatchingFilters(SeekableXPathNavigator navigator, ICollection<MessageFilter> results);
+        public bool GetMatchingFilters(XPathNavigator navigator, ICollection<MessageFilter> results);
+        public bool GetMatchingValue(Message message, out TFilterData data);
+        public bool GetMatchingValue(MessageBuffer messageBuffer, out TFilterData data);
+        public bool GetMatchingValue(SeekableXPathNavigator navigator, out TFilterData data);
+        public bool GetMatchingValue(XPathNavigator navigator, out TFilterData data);
+        public bool GetMatchingValues(Message message, ICollection<TFilterData> results);
+        public bool GetMatchingValues(MessageBuffer messageBuffer, ICollection<TFilterData> results);
+        public bool GetMatchingValues(SeekableXPathNavigator navigator, ICollection<TFilterData> results);
+        public bool GetMatchingValues(XPathNavigator navigator, ICollection<TFilterData> results);
+        public bool Remove(KeyValuePair<MessageFilter, TFilterData> item);
+        public bool Remove(MessageFilter filter);
+        public bool Remove(XPathMessageFilter filter);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        public void TrimToSize();
+        public bool TryGetValue(MessageFilter filter, out TFilterData data);
+    }
+    public class XPathMessageQueryCollection : MessageQueryCollection {
+        public XPathMessageQueryCollection();
+        public override IEnumerable<KeyValuePair<MessageQuery, TResult>> Evaluate<TResult>(Message message);
+        public override IEnumerable<KeyValuePair<MessageQuery, TResult>> Evaluate<TResult>(MessageBuffer buffer);
+        protected override void InsertItem(int index, MessageQuery item);
+        protected override void RemoveItem(int index);
+        protected override void SetItem(int index, MessageQuery item);
+    }
+    public class XPathNavigatorException : XPathException {
+        public XPathNavigatorException();
+        protected XPathNavigatorException(SerializationInfo info, StreamingContext context);
+        public XPathNavigatorException(string message);
+        public XPathNavigatorException(string message, Exception innerException);
+    }
+    public sealed class XPathResult : IDisposable {
+        public XPathResultType ResultType { get; }
+        public void Dispose();
+        public bool GetResultAsBoolean();
+        public XPathNodeIterator GetResultAsNodeset();
+        public double GetResultAsNumber();
+        public string GetResultAsString();
+    }
+}
```

