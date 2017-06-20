# System.ServiceModel.Activities

``` diff
+namespace System.ServiceModel.Activities {
+    public sealed class CallbackCorrelationInitializer : CorrelationInitializer {
+        public CallbackCorrelationInitializer();
+    }
+    public class ChannelCacheSettings {
+        public ChannelCacheSettings();
+        public TimeSpan IdleTimeout { get; set; }
+        public TimeSpan LeaseTimeout { get; set; }
+        public int MaxItemsInCache { get; set; }
+    }
+    public sealed class ContextCorrelationInitializer : CorrelationInitializer {
+        public ContextCorrelationInitializer();
+    }
+    public class CorrelationHandle : Handle {
+        public CorrelationHandle();
+        protected override void OnInitialize(HandleInitializationContext context);
+        protected override void OnUninitialize(HandleInitializationContext context);
+    }
+    public abstract class CorrelationInitializer {
+        public InArgument<CorrelationHandle> CorrelationHandle { get; set; }
+    }
+    public class CorrelationScope : NativeActivity {
+        public CorrelationScope();
+        public Activity Body { get; set; }
+        public InArgument<CorrelationHandle> CorrelatesWith { get; set; }
+        protected override void CacheMetadata(NativeActivityMetadata metadata);
+        protected override void Execute(NativeActivityContext context);
+        public bool ShouldSerializeCorrelatesWith();
+    }
+    public sealed class DurableInstancingOptions : IDurableInstancingOptions {
+        public InstanceStore InstanceStore { get; set; }
+        public void AddInitialInstanceValues(IDictionary<XName, object> writeOnlyValues);
+        public void AddInstanceOwnerValues(IDictionary<XName, object> readWriteValues, IDictionary<XName, object> writeOnlyValues);
+    }
+    public sealed class HostSettings {
+        public HostSettings();
+        public bool IncludeExceptionDetailInFaults { get; set; }
+        public XName ScopeName { get; set; }
+        public bool UseNoPersistHandle { get; set; }
+    }
+    public sealed class InitializeCorrelation : NativeActivity {
+        public InitializeCorrelation();
+        public InArgument<CorrelationHandle> Correlation { get; set; }
+        public IDictionary<string, InArgument<string>> CorrelationData { get; private set; }
+        protected override void Execute(NativeActivityContext context);
+    }
+    public interface IReceiveMessageCallback {
+        void OnReceiveMessage(OperationContext operationContext, ExecutionProperties activityExecutionProperties);
+    }
+    public interface ISendMessageCallback {
+        void OnSendMessage(OperationContext operationContext);
+    }
+    public interface IWorkflowInstanceManagement {
+        void Abandon(Guid instanceId, string reason);
+        IAsyncResult BeginAbandon(Guid instanceId, string reason, AsyncCallback callback, object state);
+        IAsyncResult BeginCancel(Guid instanceId, AsyncCallback callback, object state);
+        IAsyncResult BeginRun(Guid instanceId, AsyncCallback callback, object state);
+        IAsyncResult BeginSuspend(Guid instanceId, string reason, AsyncCallback callback, object state);
+        IAsyncResult BeginTerminate(Guid instanceId, string reason, AsyncCallback callback, object state);
+        IAsyncResult BeginTransactedCancel(Guid instanceId, AsyncCallback callback, object state);
+        IAsyncResult BeginTransactedRun(Guid instanceId, AsyncCallback callback, object state);
+        IAsyncResult BeginTransactedSuspend(Guid instanceId, string reason, AsyncCallback callback, object state);
+        IAsyncResult BeginTransactedTerminate(Guid instanceId, string reason, AsyncCallback callback, object state);
+        IAsyncResult BeginTransactedUnsuspend(Guid instanceId, AsyncCallback callback, object state);
+        IAsyncResult BeginUnsuspend(Guid instanceId, AsyncCallback callback, object state);
+        void Cancel(Guid instanceId);
+        void EndAbandon(IAsyncResult result);
+        void EndCancel(IAsyncResult result);
+        void EndRun(IAsyncResult result);
+        void EndSuspend(IAsyncResult result);
+        void EndTerminate(IAsyncResult result);
+        void EndTransactedCancel(IAsyncResult result);
+        void EndTransactedRun(IAsyncResult result);
+        void EndTransactedSuspend(IAsyncResult result);
+        void EndTransactedTerminate(IAsyncResult result);
+        void EndTransactedUnsuspend(IAsyncResult result);
+        void EndUnsuspend(IAsyncResult result);
+        void Run(Guid instanceId);
+        void Suspend(Guid instanceId, string reason);
+        void Terminate(Guid instanceId, string reason);
+        void TransactedCancel(Guid instanceId);
+        void TransactedRun(Guid instanceId);
+        void TransactedSuspend(Guid instanceId, string reason);
+        void TransactedTerminate(Guid instanceId, string reason);
+        void TransactedUnsuspend(Guid instanceId);
+        void Unsuspend(Guid instanceId);
+    }
+    public interface IWorkflowUpdateableInstanceManagement : IWorkflowInstanceManagement {
+        IAsyncResult BeginTransactedUpdate(Guid instanceId, WorkflowIdentity updatedDefinitionIdentity, AsyncCallback callback, object state);
+        IAsyncResult BeginUpdate(Guid instanceId, WorkflowIdentity updatedDefinitionIdentity, AsyncCallback callback, object state);
+        void EndTransactedUpdate(IAsyncResult result);
+        void EndUpdate(IAsyncResult result);
+        void TransactedUpdate(Guid instanceId, WorkflowIdentity updatedDefinitionIdentity);
+        void Update(Guid instanceId, WorkflowIdentity updatedDefinitionIdentity);
+    }
+    public class MessageContext {
+        public MessageContext();
+        public virtual Guid EndToEndTracingId { get; set; }
+        public virtual Message Message { get; set; }
+    }
+    public sealed class QueryCorrelationInitializer : CorrelationInitializer {
+        public QueryCorrelationInitializer();
+        public MessageQuerySet MessageQuerySet { get; set; }
+    }
+    public sealed class Receive : Activity {
+        public Receive();
+        public string Action { get; set; }
+        public bool CanCreateInstance { get; set; }
+        public ReceiveContent Content { get; set; }
+        public MessageQuerySet CorrelatesOn { get; set; }
+        public InArgument<CorrelationHandle> CorrelatesWith { get; set; }
+        public Collection<CorrelationInitializer> CorrelationInitializers { get; }
+        public Collection<Type> KnownTypes { get; }
+        public string OperationName { get; set; }
+        public Nullable<ProtectionLevel> ProtectionLevel { get; set; }
+        public SerializerOption SerializerOption { get; set; }
+        public XName ServiceContractName { get; set; }
+        protected override void CacheMetadata(ActivityMetadata metadata);
+        public static Receive FromOperationDescription(OperationDescription operation);
+        protected override void OnCreateDynamicUpdateMap(UpdateMapMetadata metadata, Activity originalActivity);
+        public bool ShouldSerializeCorrelatesOn();
+    }
+    public abstract class ReceiveContent {
+        public static ReceiveMessageContent Create(OutArgument message);
+        public static ReceiveMessageContent Create(OutArgument message, Type declaredMessageType);
+        public static ReceiveParametersContent Create(IDictionary<string, OutArgument> parameters);
+    }
+    public sealed class ReceiveMessageContent : ReceiveContent {
+        public ReceiveMessageContent();
+        public ReceiveMessageContent(OutArgument message);
+        public ReceiveMessageContent(OutArgument message, Type declaredMessageType);
+        public Type DeclaredMessageType { get; set; }
+        public OutArgument Message { get; set; }
+        public bool ShouldSerializeDeclaredMessageType();
+    }
+    public sealed class ReceiveParametersContent : ReceiveContent {
+        public ReceiveParametersContent();
+        public ReceiveParametersContent(IDictionary<string, OutArgument> parameters);
+        public IDictionary<string, OutArgument> Parameters { get; private set; }
+    }
+    public sealed class ReceiveReply : Activity {
+        public ReceiveReply();
+        public string Action { get; set; }
+        public ReceiveContent Content { get; set; }
+        public Collection<CorrelationInitializer> CorrelationInitializers { get; }
+        public Send Request { get; set; }
+        protected override void CacheMetadata(ActivityMetadata metadata);
+    }
+    public sealed class ReceiveSettings {
+        public ReceiveSettings();
+        public string Action { get; set; }
+        public bool CanCreateInstance { get; set; }
+        public string OwnerDisplayName { get; set; }
+    }
+    public sealed class RequestReplyCorrelationInitializer : CorrelationInitializer {
+        public RequestReplyCorrelationInitializer();
+    }
+    public sealed class Send : Activity {
+        public Send();
+        public string Action { get; set; }
+        public SendContent Content { get; set; }
+        public InArgument<CorrelationHandle> CorrelatesWith { get; set; }
+        public Collection<CorrelationInitializer> CorrelationInitializers { get; }
+        public Endpoint Endpoint { get; set; }
+        public InArgument<Uri> EndpointAddress { get; set; }
+        public string EndpointConfigurationName { get; set; }
+        public Collection<Type> KnownTypes { get; }
+        public string OperationName { get; set; }
+        public Nullable<ProtectionLevel> ProtectionLevel { get; set; }
+        public SerializerOption SerializerOption { get; set; }
+        public XName ServiceContractName { get; set; }
+        public TokenImpersonationLevel TokenImpersonationLevel { get; set; }
+        protected override void CacheMetadata(ActivityMetadata metadata);
+    }
+    public abstract class SendContent {
+        public static SendMessageContent Create(InArgument message);
+        public static SendMessageContent Create(InArgument message, Type declaredMessageType);
+        public static SendParametersContent Create(IDictionary<string, InArgument> parameters);
+    }
+    public sealed class SendMessageChannelCache : ICancelable, IDisposable {
+        public SendMessageChannelCache();
+        public SendMessageChannelCache(ChannelCacheSettings factorySettings, ChannelCacheSettings channelSettings);
+        public SendMessageChannelCache(ChannelCacheSettings factorySettings, ChannelCacheSettings channelSettings, bool allowUnsafeCaching);
+        public bool AllowUnsafeCaching { get; set; }
+        public ChannelCacheSettings ChannelSettings { get; set; }
+        public ChannelCacheSettings FactorySettings { get; set; }
+        public void Dispose();
+    }
+    public sealed class SendMessageContent : SendContent {
+        public SendMessageContent();
+        public SendMessageContent(InArgument message);
+        public SendMessageContent(InArgument message, Type declaredMessageType);
+        public Type DeclaredMessageType { get; set; }
+        public InArgument Message { get; set; }
+        public bool ShouldSerializeDeclaredMessageType();
+    }
+    public sealed class SendParametersContent : SendContent {
+        public SendParametersContent();
+        public SendParametersContent(IDictionary<string, InArgument> parameters);
+        public IDictionary<string, InArgument> Parameters { get; private set; }
+    }
+    public abstract class SendReceiveExtension {
+        protected SendReceiveExtension();
+        public abstract HostSettings HostSettings { get; }
+        public abstract void Cancel(Bookmark bookmark);
+        protected abstract void OnRegisterReceive(ReceiveSettings settings, InstanceKey correlatesWith, Bookmark receiveBookmark);
+        public abstract void OnUninitializeCorrelation(InstanceKey correlationKey);
+        public void RegisterReceive(ReceiveSettings settings, InstanceKey correlatesWith, Bookmark receiveBookmark);
+        public abstract void Send(MessageContext message, SendSettings settings, InstanceKey correlatesWith, Bookmark sendCompleteBookmark);
+    }
+    public sealed class SendReply : Activity {
+        public SendReply();
+        public string Action { get; set; }
+        public SendContent Content { get; set; }
+        public Collection<CorrelationInitializer> CorrelationInitializers { get; }
+        public bool PersistBeforeSend { get; set; }
+        public Receive Request { get; set; }
+        protected override void CacheMetadata(ActivityMetadata metadata);
+        public static SendReply FromOperationDescription(OperationDescription operation, out IEnumerable<SendReply> faultReplies);
+    }
+    public sealed class SendSettings {
+        public SendSettings();
+        public Endpoint Endpoint { get; set; }
+        public Uri EndpointAddress { get; set; }
+        public string EndpointConfigurationName { get; set; }
+        public bool IsOneWay { get; set; }
+        public string OwnerDisplayName { get; set; }
+        public Nullable<ProtectionLevel> ProtectionLevel { get; set; }
+        public bool RequirePersistBeforeSend { get; set; }
+        public TokenImpersonationLevel TokenImpersonationLevel { get; set; }
+    }
+    public enum SerializerOption {
+        DataContractSerializer = 0,
+        XmlSerializer = 1,
+    }
+    public sealed class TransactedReceiveScope : NativeActivity {
+        public TransactedReceiveScope();
+        public Activity Body { get; set; }
+        public Receive Request { get; set; }
+        public Collection<Variable> Variables { get; }
+        protected override void CacheMetadata(NativeActivityMetadata metadata);
+        protected override void Execute(NativeActivityContext context);
+    }
+    public class WorkflowControlClient : ClientBase<IWorkflowInstanceManagement> {
+        public WorkflowControlClient();
+        public WorkflowControlClient(WorkflowControlEndpoint workflowEndpoint);
+        public WorkflowControlClient(Binding binding, EndpointAddress remoteAddress);
+        public WorkflowControlClient(string endpointConfigurationName);
+        public WorkflowControlClient(string endpointConfigurationName, EndpointAddress remoteAddress);
+        public WorkflowControlClient(string endpointConfigurationName, string remoteAddress);
+        public event EventHandler<AsyncCompletedEventArgs> AbandonCompleted;
+        public event EventHandler<AsyncCompletedEventArgs> CancelCompleted;
+        public event EventHandler<AsyncCompletedEventArgs> RunCompleted;
+        public event EventHandler<AsyncCompletedEventArgs> SuspendCompleted;
+        public event EventHandler<AsyncCompletedEventArgs> TerminateCompleted;
+        public event EventHandler<AsyncCompletedEventArgs> UnsuspendCompleted;
+        public void Abandon(Guid instanceId);
+        public void Abandon(Guid instanceId, string reason);
+        public void AbandonAsync(Guid instanceId);
+        public void AbandonAsync(Guid instanceId, object userState);
+        public void AbandonAsync(Guid instanceId, string reason);
+        public void AbandonAsync(Guid instanceId, string reason, object userState);
+        public IAsyncResult BeginAbandon(Guid instanceId, AsyncCallback callback, object state);
+        public IAsyncResult BeginAbandon(Guid instanceId, string reason, AsyncCallback callback, object state);
+        public IAsyncResult BeginCancel(Guid instanceId, AsyncCallback callback, object state);
+        public IAsyncResult BeginRun(Guid instanceId, AsyncCallback callback, object state);
+        public IAsyncResult BeginSuspend(Guid instanceId, AsyncCallback callback, object state);
+        public IAsyncResult BeginSuspend(Guid instanceId, string reason, AsyncCallback callback, object state);
+        public IAsyncResult BeginTerminate(Guid instanceId, AsyncCallback callback, object state);
+        public IAsyncResult BeginTerminate(Guid instanceId, string reason, AsyncCallback callback, object state);
+        public IAsyncResult BeginUnsuspend(Guid instanceId, AsyncCallback callback, object state);
+        public void Cancel(Guid instanceId);
+        public void CancelAsync(Guid instanceId);
+        public void CancelAsync(Guid instanceId, object userState);
+        public void EndAbandon(IAsyncResult result);
+        public void EndCancel(IAsyncResult result);
+        public void EndRun(IAsyncResult result);
+        public void EndSuspend(IAsyncResult result);
+        public void EndTerminate(IAsyncResult result);
+        public void EndUnsuspend(IAsyncResult result);
+        public void Run(Guid instanceId);
+        public void RunAsync(Guid instanceId);
+        public void RunAsync(Guid instanceId, object userState);
+        public void Suspend(Guid instanceId);
+        public void Suspend(Guid instanceId, string reason);
+        public void SuspendAsync(Guid instanceId);
+        public void SuspendAsync(Guid instanceId, object userState);
+        public void SuspendAsync(Guid instanceId, string reason);
+        public void SuspendAsync(Guid instanceId, string reason, object userState);
+        public void Terminate(Guid instanceId);
+        public void Terminate(Guid instanceId, string reason);
+        public void TerminateAsync(Guid instanceId);
+        public void TerminateAsync(Guid instanceId, object userState);
+        public void TerminateAsync(Guid instanceId, string reason);
+        public void TerminateAsync(Guid instanceId, string reason, object userState);
+        public void Unsuspend(Guid instanceId);
+        public void UnsuspendAsync(Guid instanceId);
+        public void UnsuspendAsync(Guid instanceId, object userState);
+    }
+    public class WorkflowControlEndpoint : ServiceEndpoint {
+        public WorkflowControlEndpoint();
+        public WorkflowControlEndpoint(Binding binding, EndpointAddress address);
+    }
+    public class WorkflowCreationContext {
+        public WorkflowCreationContext();
+        public bool CreateOnly { get; set; }
+        public bool IsCompletionTransactionRequired { get; set; }
+        public IDictionary<string, object> WorkflowArguments { get; }
+        protected internal virtual void OnAbort();
+        protected internal virtual IAsyncResult OnBeginWorkflowCompleted(ActivityInstanceState completionState, IDictionary<string, object> workflowOutputs, Exception terminationException, TimeSpan timeout, AsyncCallback callback, object state);
+        protected internal virtual void OnEndWorkflowCompleted(IAsyncResult result);
+    }
+    public abstract class WorkflowHostingEndpoint : ServiceEndpoint {
+        protected WorkflowHostingEndpoint(Type contractType);
+        protected WorkflowHostingEndpoint(Type contractType, Binding binding, EndpointAddress address);
+        public Collection<CorrelationQuery> CorrelationQueries { get; }
+        protected internal virtual WorkflowCreationContext OnGetCreationContext(object[] inputs, OperationContext operationContext, Guid instanceId, WorkflowHostingResponseContext responseContext);
+        protected internal virtual Guid OnGetInstanceId(object[] inputs, OperationContext operationContext);
+        protected internal virtual Bookmark OnResolveBookmark(object[] inputs, OperationContext operationContext, WorkflowHostingResponseContext responseContext, out object value);
+    }
+    public sealed class WorkflowHostingResponseContext {
+        public void SendResponse(object returnValue, object[] outputs);
+    }
+    public class WorkflowService : IDebuggableWorkflowTree {
+        public WorkflowService();
+        public bool AllowBufferedReceive { get; set; }
+        public Activity Body { get; set; }
+        public string ConfigurationName { get; set; }
+        public WorkflowIdentity DefinitionIdentity { get; set; }
+        public Collection<Endpoint> Endpoints { get; }
+        public Collection<Type> ImplementedContracts { get; }
+        public XName Name { get; set; }
+        public IDictionary<WorkflowIdentity, DynamicUpdateMap> UpdateMaps { get; }
+        public virtual IDictionary<XName, ContractDescription> GetContractDescriptions();
+        public Activity GetWorkflowRoot();
+        public ValidationResults Validate(ValidationSettings settings);
+    }
+    public class WorkflowServiceHost : ServiceHostBase {
+        protected WorkflowServiceHost();
+        public WorkflowServiceHost(Activity activity, params Uri[] baseAddresses);
+        public WorkflowServiceHost(object serviceImplementation, params Uri[] baseAddresses);
+        public WorkflowServiceHost(WorkflowService serviceDefinition, params Uri[] baseAddresses);
+        public Activity Activity { get; }
+        public DurableInstancingOptions DurableInstancingOptions { get; }
+        public ICollection<WorkflowService> SupportedVersions { get; }
+        public WorkflowInstanceExtensionManager WorkflowExtensions { get; }
+        public override void AddServiceEndpoint(ServiceEndpoint endpoint);
+        public new ServiceEndpoint AddServiceEndpoint(string implementedContract, Binding binding, string address);
+        public new ServiceEndpoint AddServiceEndpoint(string implementedContract, Binding binding, string address, Uri listenUri);
+        public new ServiceEndpoint AddServiceEndpoint(string implementedContract, Binding binding, Uri address);
+        public new ServiceEndpoint AddServiceEndpoint(string implementedContract, Binding binding, Uri address, Uri listenUri);
+        public ServiceEndpoint AddServiceEndpoint(XName serviceContractName, Binding binding, string address, Uri listenUri=null, string behaviorConfigurationName=null);
+        public ServiceEndpoint AddServiceEndpoint(XName serviceContractName, Binding binding, Uri address, Uri listenUri=null, string behaviorConfigurationName=null);
+        protected override ServiceDescription CreateDescription(out IDictionary<string, ContractDescription> implementedContracts);
+        protected override void InitializeRuntime();
+        protected override void OnAbort();
+        protected override IAsyncResult OnBeginClose(TimeSpan timeout, AsyncCallback callback, object state);
+        protected override void OnClose(TimeSpan timeout);
+        protected override void OnEndClose(IAsyncResult result);
+    }
+    public class WorkflowUpdateableControlClient : ClientBase<IWorkflowUpdateableInstanceManagement> {
+        public WorkflowUpdateableControlClient();
+        public WorkflowUpdateableControlClient(WorkflowControlEndpoint workflowEndpoint);
+        public WorkflowUpdateableControlClient(Binding binding, EndpointAddress remoteAddress);
+        public WorkflowUpdateableControlClient(string endpointConfigurationName);
+        public WorkflowUpdateableControlClient(string endpointConfigurationName, EndpointAddress remoteAddress);
+        public WorkflowUpdateableControlClient(string endpointConfigurationName, string remoteAddress);
+        public event EventHandler<AsyncCompletedEventArgs> AbandonCompleted;
+        public event EventHandler<AsyncCompletedEventArgs> CancelCompleted;
+        public event EventHandler<AsyncCompletedEventArgs> RunCompleted;
+        public event EventHandler<AsyncCompletedEventArgs> SuspendCompleted;
+        public event EventHandler<AsyncCompletedEventArgs> TerminateCompleted;
+        public event EventHandler<AsyncCompletedEventArgs> UnsuspendCompleted;
+        public event EventHandler<AsyncCompletedEventArgs> UpdateCompleted;
+        public void Abandon(Guid instanceId);
+        public void Abandon(Guid instanceId, string reason);
+        public void AbandonAsync(Guid instanceId);
+        public void AbandonAsync(Guid instanceId, object userState);
+        public void AbandonAsync(Guid instanceId, string reason);
+        public void AbandonAsync(Guid instanceId, string reason, object userState);
+        public IAsyncResult BeginAbandon(Guid instanceId, AsyncCallback callback, object state);
+        public IAsyncResult BeginAbandon(Guid instanceId, string reason, AsyncCallback callback, object state);
+        public IAsyncResult BeginCancel(Guid instanceId, AsyncCallback callback, object state);
+        public IAsyncResult BeginRun(Guid instanceId, AsyncCallback callback, object state);
+        public IAsyncResult BeginSuspend(Guid instanceId, AsyncCallback callback, object state);
+        public IAsyncResult BeginSuspend(Guid instanceId, string reason, AsyncCallback callback, object state);
+        public IAsyncResult BeginTerminate(Guid instanceId, AsyncCallback callback, object state);
+        public IAsyncResult BeginTerminate(Guid instanceId, string reason, AsyncCallback callback, object state);
+        public IAsyncResult BeginUnsuspend(Guid instanceId, AsyncCallback callback, object state);
+        public IAsyncResult BeginUpdate(Guid instanceId, WorkflowIdentity updatedDefinitionIdentity, AsyncCallback callback, object state);
+        public void Cancel(Guid instanceId);
+        public void CancelAsync(Guid instanceId);
+        public void CancelAsync(Guid instanceId, object userState);
+        public void EndAbandon(IAsyncResult result);
+        public void EndCancel(IAsyncResult result);
+        public void EndRun(IAsyncResult result);
+        public void EndSuspend(IAsyncResult result);
+        public void EndTerminate(IAsyncResult result);
+        public void EndUnsuspend(IAsyncResult result);
+        public void EndUpdate(IAsyncResult result);
+        public void Run(Guid instanceId);
+        public void RunAsync(Guid instanceId);
+        public void RunAsync(Guid instanceId, object userState);
+        public void Suspend(Guid instanceId);
+        public void Suspend(Guid instanceId, string reason);
+        public void SuspendAsync(Guid instanceId);
+        public void SuspendAsync(Guid instanceId, object userState);
+        public void SuspendAsync(Guid instanceId, string reason);
+        public void SuspendAsync(Guid instanceId, string reason, object userState);
+        public void Terminate(Guid instanceId);
+        public void Terminate(Guid instanceId, string reason);
+        public void TerminateAsync(Guid instanceId);
+        public void TerminateAsync(Guid instanceId, object userState);
+        public void TerminateAsync(Guid instanceId, string reason);
+        public void TerminateAsync(Guid instanceId, string reason, object userState);
+        public void Unsuspend(Guid instanceId);
+        public void UnsuspendAsync(Guid instanceId);
+        public void UnsuspendAsync(Guid instanceId, object userState);
+        public void Update(Guid instanceId, WorkflowIdentity updatedDefinitionIdentity);
+        public void UpdateAsync(Guid instanceId, WorkflowIdentity updatedDefinitionIdentity);
+        public void UpdateAsync(Guid instanceId, WorkflowIdentity updatedDefinitionIdentity, object userState);
+    }
+}
```

