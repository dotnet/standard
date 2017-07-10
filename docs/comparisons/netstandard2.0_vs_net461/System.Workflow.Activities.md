# System.Workflow.Activities

``` diff
+namespace System.Workflow.Activities {
+    public sealed class ActiveDirectoryRole : WorkflowRole, IDisposable, ISerializable {
+        public override string Name { get; set; }
+        public DirectoryEntry RootEntry { get; }
+        public ActiveDirectoryRole GetAllReports();
+        public ActiveDirectoryRole GetDirectReports();
+        public ICollection<DirectoryEntry> GetEntries();
+        public override IList<string> GetIdentities();
+        public ActiveDirectoryRole GetManager();
+        public ActiveDirectoryRole GetManagerialChain();
+        public ActiveDirectoryRole GetPeers();
+        public IList<SecurityIdentifier> GetSecurityIdentifiers();
+        public override bool IncludesIdentity(string identity);
+        void System.IDisposable.Dispose();
+        void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public static class ActiveDirectoryRoleFactory {
+        public static ActiveDirectoryRoleFactoryConfiguration Configuration { get; }
+        public static ActiveDirectoryRole CreateFromAlias(string alias);
+        public static ActiveDirectoryRole CreateFromEmailAddress(string emailAddress);
+        public static ActiveDirectoryRole CreateFromSecurityIdentifier(SecurityIdentifier sid);
+    }
+    public class CallExternalMethodActivity : Activity, IDynamicPropertyTypeProvider, IPropertyValueProvider {
+        public static readonly DependencyProperty CorrelationTokenProperty;
+        public static readonly DependencyProperty InterfaceTypeProperty;
+        public static readonly DependencyProperty MethodInvokingEvent;
+        public static readonly DependencyProperty MethodNameProperty;
+        public static readonly DependencyProperty ParameterBindingsProperty;
+        public CallExternalMethodActivity();
+        public CallExternalMethodActivity(string name);
+        public virtual CorrelationToken CorrelationToken { get; set; }
+        public virtual Type InterfaceType { get; set; }
+        public virtual string MethodName { get; set; }
+        public WorkflowParameterBindingCollection ParameterBindings { get; }
+        public event EventHandler MethodInvoking;
+        protected sealed override ActivityExecutionStatus Execute(ActivityExecutionContext executionContext);
+        protected override void InitializeProperties();
+        protected virtual void OnMethodInvoked(EventArgs e);
+        protected virtual void OnMethodInvoking(EventArgs e);
+        AccessTypes System.Workflow.ComponentModel.IDynamicPropertyTypeProvider.GetAccessType(IServiceProvider serviceProvider, string propertyName);
+        Type System.Workflow.ComponentModel.IDynamicPropertyTypeProvider.GetPropertyType(IServiceProvider serviceProvider, string propertyName);
+    }
+    public class CallExternalMethodActivityValidator : ActivityValidator {
+        public CallExternalMethodActivityValidator();
+        public override ValidationErrorCollection Validate(ValidationManager manager, object obj);
+    }
+    public sealed class ChannelToken : DependencyObject, IPropertyValueProvider {
+        public ChannelToken();
+        public string EndpointName { get; set; }
+        public string Name { get; set; }
+        public string OwnerActivityName { get; set; }
+    }
+    public sealed class CodeActivity : Activity {
+        public static readonly DependencyProperty ExecuteCodeEvent;
+        public CodeActivity();
+        public CodeActivity(string name);
+        public event EventHandler ExecuteCode;
+        protected sealed override ActivityExecutionStatus Execute(ActivityExecutionContext executionContext);
+    }
+    public class CodeCondition : ActivityCondition {
+        public static readonly DependencyProperty ConditionEvent;
+        public CodeCondition();
+        public event EventHandler<ConditionalEventArgs> Condition;
+        public override bool Evaluate(Activity ownerActivity, IServiceProvider provider);
+        protected override object GetBoundValue(ActivityBind bind, Type targetType);
+    }
+    public sealed class CompensatableSequenceActivity : SequenceActivity, ICompensatableActivity {
+        public CompensatableSequenceActivity();
+        public CompensatableSequenceActivity(string name);
+        ActivityExecutionStatus System.Workflow.ComponentModel.ICompensatableActivity.Compensate(ActivityExecutionContext executionContext);
+    }
+    public sealed class ConditionalEventArgs : EventArgs {
+        public ConditionalEventArgs();
+        public ConditionalEventArgs(bool result);
+        public bool Result { get; set; }
+    }
+    public sealed class ConditionedActivityGroup : CompositeActivity, IActivityEventListener<ActivityExecutionStatusChangedEventArgs> {
+        public static readonly DependencyProperty UntilConditionProperty;
+        public static readonly DependencyProperty WhenConditionProperty;
+        public ConditionedActivityGroup();
+        public ConditionedActivityGroup(string name);
+        public ActivityCondition UntilCondition { get; set; }
+        protected override ActivityExecutionStatus Cancel(ActivityExecutionContext executionContext);
+        protected override ActivityExecutionStatus Execute(ActivityExecutionContext executionContext);
+        public int GetChildActivityExecutedCount(Activity child);
+        public Activity GetDynamicActivity(string childActivityName);
+        public static object GetWhenCondition(object dependencyObject);
+        protected override void OnActivityChangeAdd(ActivityExecutionContext executionContext, Activity addedActivity);
+        protected override void OnActivityChangeRemove(ActivityExecutionContext executionContext, Activity removedActivity);
+        protected override void OnClosed(IServiceProvider provider);
+        protected override void OnWorkflowChangesCompleted(ActivityExecutionContext executionContext);
+        public static void SetWhenCondition(object dependencyObject, object value);
+        void System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs>.OnEvent(object sender, ActivityExecutionStatusChangedEventArgs e);
+    }
+    public sealed class ContextToken : DependencyObject, IPropertyValueProvider {
+        public const string RootContextName = "(RootContext)";
+        public ContextToken();
+        public ContextToken(string name);
+        public string Name { get; set; }
+        public string OwnerActivityName { get; set; }
+    }
+    public sealed class CorrelationAliasAttribute : Attribute {
+        public CorrelationAliasAttribute(string name, string path);
+        public string Name { get; }
+        public string Path { get; }
+    }
+    public sealed class CorrelationInitializerAttribute : Attribute {
+        public CorrelationInitializerAttribute();
+    }
+    public sealed class CorrelationParameterAttribute : Attribute {
+        public CorrelationParameterAttribute(string name);
+        public string Name { get; }
+    }
+    public sealed class DelayActivity : Activity, IActivityEventListener<QueueEventArgs>, IEventActivity {
+        public static readonly DependencyProperty InitializeTimeoutDurationEvent;
+        public static readonly DependencyProperty TimeoutDurationProperty;
+        public DelayActivity();
+        public DelayActivity(string name);
+        IComparable System.Workflow.Activities.IEventActivity.QueueName { get; }
+        public TimeSpan TimeoutDuration { get; set; }
+        public event EventHandler InitializeTimeoutDuration;
+        protected override ActivityExecutionStatus Cancel(ActivityExecutionContext executionContext);
+        protected override ActivityExecutionStatus Execute(ActivityExecutionContext executionContext);
+        protected sealed override ActivityExecutionStatus HandleFault(ActivityExecutionContext executionContext, Exception exception);
+        protected override void Initialize(IServiceProvider provider);
+        protected override void OnClosed(IServiceProvider provider);
+        void System.Workflow.Activities.IEventActivity.Subscribe(ActivityExecutionContext parentContext, IActivityEventListener<QueueEventArgs> parentEventHandler);
+        void System.Workflow.Activities.IEventActivity.Unsubscribe(ActivityExecutionContext parentContext, IActivityEventListener<QueueEventArgs> parentEventHandler);
+        void System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.QueueEventArgs>.OnEvent(object sender, QueueEventArgs e);
+    }
+    public sealed class EventDeliveryFailedException : SystemException {
+        public EventDeliveryFailedException();
+        public EventDeliveryFailedException(string message);
+        public EventDeliveryFailedException(string message, Exception innerException);
+    }
+    public sealed class EventDrivenActivity : SequenceActivity {
+        public EventDrivenActivity();
+        public EventDrivenActivity(string name);
+        public IEventActivity EventActivity { get; }
+    }
+    public sealed class EventHandlersActivity : CompositeActivity, IActivityEventListener<ActivityExecutionStatusChangedEventArgs> {
+        public EventHandlersActivity();
+        public EventHandlersActivity(string name);
+        protected override ActivityExecutionStatus Cancel(ActivityExecutionContext executionContext);
+        protected override ActivityExecutionStatus Execute(ActivityExecutionContext executionContext);
+        public Activity GetDynamicActivity(string childActivityName);
+        protected override void Initialize(IServiceProvider provider);
+        protected override void OnActivityChangeAdd(ActivityExecutionContext executionContext, Activity addedActivity);
+        protected override void OnActivityChangeRemove(ActivityExecutionContext executionContext, Activity removedActivity);
+        protected override void OnClosed(IServiceProvider provider);
+        protected override void OnWorkflowChangesCompleted(ActivityExecutionContext executionContext);
+        void System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs>.OnEvent(object sender, ActivityExecutionStatusChangedEventArgs e);
+    }
+    public sealed class EventHandlingScopeActivity : CompositeActivity, IActivityEventListener<ActivityExecutionStatusChangedEventArgs> {
+        public EventHandlingScopeActivity();
+        public EventHandlingScopeActivity(string name);
+        protected override ActivityExecutionStatus Cancel(ActivityExecutionContext executionContext);
+        protected override ActivityExecutionStatus Execute(ActivityExecutionContext executionContext);
+        protected override void OnActivityChangeRemove(ActivityExecutionContext executionContext, Activity removedActivity);
+        protected override void OnWorkflowChangesCompleted(ActivityExecutionContext executionContext);
+        void System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs>.OnEvent(object sender, ActivityExecutionStatusChangedEventArgs e);
+    }
+    public sealed class EventQueueName : IComparable {
+        public EventQueueName(Type interfaceType, string operation);
+        public EventQueueName(Type interfaceType, string operation, ICollection<CorrelationProperty> propertyValues);
+        public Type InterfaceType { get; }
+        public string MethodName { get; }
+        public int CompareTo(object toCompare);
+        public int CompareTo(EventQueueName eventQueueName);
+        public override bool Equals(object obj);
+        public CorrelationProperty[] GetCorrelationValues();
+        public override int GetHashCode();
+        public static bool operator ==(EventQueueName queueKey1, EventQueueName queueKey2);
+        public static bool operator >(EventQueueName queueKey1, EventQueueName queueKey2);
+        public static bool operator !=(EventQueueName queueKey1, EventQueueName queueKey2);
+        public static bool operator <(EventQueueName queueKey1, EventQueueName queueKey2);
+        public override string ToString();
+    }
+    public enum ExecutionType {
+        Parallel = 1,
+        Sequence = 0,
+    }
+    public class ExternalDataEventArgs : EventArgs {
+        public ExternalDataEventArgs();
+        public ExternalDataEventArgs(Guid instanceId);
+        public ExternalDataEventArgs(Guid instanceId, IPendingWork workHandler, object workItem);
+        public ExternalDataEventArgs(Guid instanceId, IPendingWork workHandler, object workItem, bool waitForIdle);
+        public string Identity { get; set; }
+        public Guid InstanceId { get; set; }
+        public bool WaitForIdle { get; set; }
+        public IPendingWork WorkHandler { get; set; }
+        public object WorkItem { get; set; }
+    }
+    public sealed class ExternalDataExchangeAttribute : Attribute {
+        public ExternalDataExchangeAttribute();
+    }
+    public class ExternalDataExchangeService : WorkflowRuntimeService {
+        public ExternalDataExchangeService();
+        public ExternalDataExchangeService(NameValueCollection parameters);
+        public ExternalDataExchangeService(string configSectionName);
+        public ExternalDataExchangeService(ExternalDataExchangeServiceSection settings);
+        public virtual void AddService(object service);
+        public virtual object GetService(Type serviceType);
+        public virtual void RemoveService(object service);
+        protected override void Start();
+    }
+    public class ExternalDataExchangeServiceSection : ConfigurationSection {
+        public ExternalDataExchangeServiceSection();
+        public WorkflowRuntimeServiceElementCollection Services { get; }
+    }
+    public class HandleExternalEventActivity : Activity, IActivityEventListener<QueueEventArgs>, IDynamicPropertyTypeProvider, IEventActivity, IPropertyValueProvider {
+        public static readonly DependencyProperty CorrelationTokenProperty;
+        public static readonly DependencyProperty EventNameProperty;
+        public static readonly DependencyProperty InterfaceTypeProperty;
+        public static readonly DependencyProperty InvokedEvent;
+        public static readonly DependencyProperty ParameterBindingsProperty;
+        public static readonly DependencyProperty RolesProperty;
+        public HandleExternalEventActivity();
+        public HandleExternalEventActivity(string name);
+        public virtual CorrelationToken CorrelationToken { get; set; }
+        public virtual string EventName { get; set; }
+        public virtual Type InterfaceType { get; set; }
+        public WorkflowParameterBindingCollection ParameterBindings { get; }
+        public WorkflowRoleCollection Roles { get; set; }
+        IComparable System.Workflow.Activities.IEventActivity.QueueName { get; }
+        public event EventHandler<ExternalDataEventArgs> Invoked;
+        protected sealed override ActivityExecutionStatus Cancel(ActivityExecutionContext executionContext);
+        protected sealed override ActivityExecutionStatus Execute(ActivityExecutionContext executionContext);
+        protected sealed override ActivityExecutionStatus HandleFault(ActivityExecutionContext executionContext, Exception exception);
+        protected sealed override void Initialize(IServiceProvider provider);
+        protected override void InitializeProperties();
+        protected override void OnClosed(IServiceProvider provider);
+        protected virtual void OnInvoked(EventArgs e);
+        void System.Workflow.Activities.IEventActivity.Subscribe(ActivityExecutionContext parentContext, IActivityEventListener<QueueEventArgs> parentEventHandler);
+        void System.Workflow.Activities.IEventActivity.Unsubscribe(ActivityExecutionContext parentContext, IActivityEventListener<QueueEventArgs> parentEventHandler);
+        void System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.QueueEventArgs>.OnEvent(object sender, QueueEventArgs e);
+        AccessTypes System.Workflow.ComponentModel.IDynamicPropertyTypeProvider.GetAccessType(IServiceProvider serviceProvider, string propertyName);
+        Type System.Workflow.ComponentModel.IDynamicPropertyTypeProvider.GetPropertyType(IServiceProvider serviceProvider, string propertyName);
+    }
+    public class HandleExternalEventActivityValidator : ActivityValidator {
+        public HandleExternalEventActivityValidator();
+        public override ValidationErrorCollection Validate(ValidationManager manager, object obj);
+    }
+    public interface IEventActivity {
+        IComparable QueueName { get; }
+        void Subscribe(ActivityExecutionContext parentContext, IActivityEventListener<QueueEventArgs> parentEventHandler);
+        void Unsubscribe(ActivityExecutionContext parentContext, IActivityEventListener<QueueEventArgs> parentEventHandler);
+    }
+    public sealed class IfElseActivity : CompositeActivity, IActivityEventListener<ActivityExecutionStatusChangedEventArgs> {
+        public IfElseActivity();
+        public IfElseActivity(string name);
+        public IfElseBranchActivity AddBranch(ICollection<Activity> activities);
+        public IfElseBranchActivity AddBranch(ICollection<Activity> activities, ActivityCondition branchCondition);
+        protected override ActivityExecutionStatus Cancel(ActivityExecutionContext executionContext);
+        protected override ActivityExecutionStatus Execute(ActivityExecutionContext executionContext);
+        void System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs>.OnEvent(object sender, ActivityExecutionStatusChangedEventArgs e);
+    }
+    public sealed class IfElseBranchActivity : SequenceActivity {
+        public static readonly DependencyProperty ConditionProperty;
+        public IfElseBranchActivity();
+        public IfElseBranchActivity(string name);
+        public ActivityCondition Condition { get; set; }
+    }
+    public sealed class InvokeWebServiceActivity : Activity, IDynamicPropertyTypeProvider, IPropertyValueProvider {
+        public static readonly DependencyProperty InvokedEvent;
+        public static readonly DependencyProperty InvokingEvent;
+        public static readonly DependencyProperty MethodNameProperty;
+        public static readonly DependencyProperty ParameterBindingsProperty;
+        public static readonly DependencyProperty ProxyClassProperty;
+        public static readonly DependencyProperty SessionIdProperty;
+        public InvokeWebServiceActivity();
+        public InvokeWebServiceActivity(string name);
+        public string MethodName { get; set; }
+        public WorkflowParameterBindingCollection ParameterBindings { get; }
+        public Type ProxyClass { get; set; }
+        public string SessionId { get; set; }
+        public event EventHandler<InvokeWebServiceEventArgs> Invoked;
+        public event EventHandler<InvokeWebServiceEventArgs> Invoking;
+        protected sealed override ActivityExecutionStatus Execute(ActivityExecutionContext executionContext);
+        protected override void OnClosed(IServiceProvider provider);
+        AccessTypes System.Workflow.ComponentModel.IDynamicPropertyTypeProvider.GetAccessType(IServiceProvider serviceProvider, string propertyName);
+        Type System.Workflow.ComponentModel.IDynamicPropertyTypeProvider.GetPropertyType(IServiceProvider serviceProvider, string propertyName);
+    }
+    public sealed class InvokeWebServiceEventArgs : EventArgs {
+        public InvokeWebServiceEventArgs(object proxyInstance);
+        public object WebServiceProxy { get; }
+    }
+    public sealed class InvokeWorkflowActivity : Activity, ITypeFilterProvider {
+        public static readonly DependencyProperty InstanceIdProperty;
+        public static readonly DependencyProperty InvokingEvent;
+        public static readonly DependencyProperty ParameterBindingsProperty;
+        public static readonly DependencyProperty TargetWorkflowProperty;
+        public InvokeWorkflowActivity();
+        public InvokeWorkflowActivity(string name);
+        public Guid InstanceId { get; }
+        public WorkflowParameterBindingCollection ParameterBindings { get; }
+        string System.Workflow.ComponentModel.Design.ITypeFilterProvider.FilterDescription { get; }
+        public Type TargetWorkflow { get; set; }
+        public event EventHandler Invoking;
+        protected override ActivityExecutionStatus Execute(ActivityExecutionContext executionContext);
+        bool System.Workflow.ComponentModel.Design.ITypeFilterProvider.CanFilterType(Type type, bool throwOnError);
+    }
+    public sealed class ListenActivity : CompositeActivity, IActivityEventListener<ActivityExecutionStatusChangedEventArgs> {
+        public ListenActivity();
+        public ListenActivity(string name);
+        protected override ActivityExecutionStatus Cancel(ActivityExecutionContext executionContext);
+        protected override ActivityExecutionStatus Execute(ActivityExecutionContext executionContext);
+        protected sealed override void OnActivityChangeAdd(ActivityExecutionContext executionContext, Activity addedActivity);
+        protected sealed override void OnActivityChangeRemove(ActivityExecutionContext executionContext, Activity removedActivity);
+        protected override void OnClosed(IServiceProvider provider);
+        protected override void OnWorkflowChangesCompleted(ActivityExecutionContext executionContext);
+        void System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs>.OnEvent(object sender, ActivityExecutionStatusChangedEventArgs e);
+    }
+    public class MessageEventSubscription {
+        protected MessageEventSubscription();
+        public MessageEventSubscription(IComparable queueName, Guid instanceId);
+        public MessageEventSubscription(IComparable queueName, Guid instanceId, Guid subscriptionId);
+        public MessageEventSubscription(IComparable queueName, Guid subscriptionId, Type interfaceType, string operation);
+        public MessageEventSubscription(IComparable queueName, Guid instanceId, Type interfaceType, string operation, Guid subscriptionId);
+        public virtual ICollection<CorrelationProperty> CorrelationProperties { get; }
+        public virtual Type InterfaceType { get; set; }
+        public virtual string MethodName { get; set; }
+        public virtual IComparable QueueName { get; protected set; }
+        public virtual Guid SubscriptionId { get; }
+        public virtual Guid WorkflowInstanceId { get; }
+    }
+    public sealed class OperationInfo : OperationInfoBase {
+        public OperationInfo();
+        public string ContractName { get; set; }
+        public bool HasProtectionLevel { get; }
+        public bool IsOneWay { get; set; }
+        public OperationParameterInfoCollection Parameters { get; }
+        public Nullable<ProtectionLevel> ProtectionLevel { get; set; }
+        public override OperationInfoBase Clone();
+        public override bool Equals(object obj);
+        protected internal override string GetContractFullName(IServiceProvider provider);
+        protected internal override Type GetContractType(IServiceProvider provider);
+        public override int GetHashCode();
+        protected internal override bool GetIsOneWay(IServiceProvider provider);
+        protected internal override MethodInfo GetMethodInfo(IServiceProvider provider);
+        protected internal override OperationParameterInfoCollection GetParameters(IServiceProvider provider);
+        public override string ToString();
+    }
+    public abstract class OperationInfoBase : DependencyObject {
+        protected OperationInfoBase();
+        public virtual string Name { get; set; }
+        public virtual string PrincipalPermissionName { get; set; }
+        public virtual string PrincipalPermissionRole { get; set; }
+        public virtual OperationInfoBase Clone();
+        public override bool Equals(object obj);
+        protected internal abstract string GetContractFullName(IServiceProvider provider);
+        protected internal abstract Type GetContractType(IServiceProvider provider);
+        public override int GetHashCode();
+        protected internal abstract bool GetIsOneWay(IServiceProvider provider);
+        protected internal abstract MethodInfo GetMethodInfo(IServiceProvider provider);
+        protected internal abstract OperationParameterInfoCollection GetParameters(IServiceProvider provider);
+    }
+    public sealed class OperationParameterInfo : DependencyObject {
+        public static readonly DependencyProperty AttributesProperty;
+        public static readonly DependencyProperty NameProperty;
+        public static readonly DependencyProperty ParameterTypeProperty;
+        public static readonly DependencyProperty PositionProperty;
+        public OperationParameterInfo();
+        public OperationParameterInfo(string parameterName);
+        public ParameterAttributes Attributes { get; set; }
+        public bool IsIn { get; }
+        public bool IsLcid { get; }
+        public bool IsOptional { get; }
+        public bool IsOut { get; }
+        public bool IsRetval { get; }
+        public string Name { get; set; }
+        public Type ParameterType { get; set; }
+        public int Position { get; set; }
+        public OperationParameterInfo Clone();
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+    }
+    public sealed class OperationParameterInfoCollection : List<OperationParameterInfo>, ICollection, ICollection<OperationParameterInfo>, IEnumerable, IEnumerable<OperationParameterInfo>, IList, IList<OperationParameterInfo> {
+        public OperationParameterInfoCollection();
+        public OperationParameterInfoCollection(OperationInfoBase owner);
+        public new int Count { get; }
+        int System.Collections.Generic.ICollection<System.Workflow.Activities.OperationParameterInfo>.Count { get; }
+        bool System.Collections.Generic.ICollection<System.Workflow.Activities.OperationParameterInfo>.IsReadOnly { get; }
+        OperationParameterInfo System.Collections.Generic.IList<System.Workflow.Activities.OperationParameterInfo>.this[int index] { get; set; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public new OperationParameterInfo this[int index] { get; set; }
+        public OperationParameterInfo this[string key] { get; }
+        public new void Add(OperationParameterInfo item);
+        public new void Clear();
+        public new bool Contains(OperationParameterInfo item);
+        public new IEnumerator<OperationParameterInfo> GetEnumerator();
+        public new int IndexOf(OperationParameterInfo item);
+        public new void Insert(int index, OperationParameterInfo item);
+        public new bool Remove(OperationParameterInfo item);
+        public new void RemoveAt(int index);
+        void System.Collections.Generic.ICollection<System.Workflow.Activities.OperationParameterInfo>.Add(OperationParameterInfo item);
+        void System.Collections.Generic.ICollection<System.Workflow.Activities.OperationParameterInfo>.Clear();
+        bool System.Collections.Generic.ICollection<System.Workflow.Activities.OperationParameterInfo>.Contains(OperationParameterInfo item);
+        void System.Collections.Generic.ICollection<System.Workflow.Activities.OperationParameterInfo>.CopyTo(OperationParameterInfo[] array, int arrayIndex);
+        bool System.Collections.Generic.ICollection<System.Workflow.Activities.OperationParameterInfo>.Remove(OperationParameterInfo item);
+        IEnumerator<OperationParameterInfo> System.Collections.Generic.IEnumerable<System.Workflow.Activities.OperationParameterInfo>.GetEnumerator();
+        int System.Collections.Generic.IList<System.Workflow.Activities.OperationParameterInfo>.IndexOf(OperationParameterInfo item);
+        void System.Collections.Generic.IList<System.Workflow.Activities.OperationParameterInfo>.Insert(int index, OperationParameterInfo item);
+        void System.Collections.Generic.IList<System.Workflow.Activities.OperationParameterInfo>.RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        void System.Collections.IList.Clear();
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+    }
+    public class OperationValidationEventArgs : EventArgs {
+        public OperationValidationEventArgs(ReadOnlyCollection<ClaimSet> claimSets);
+        public ReadOnlyCollection<ClaimSet> ClaimSets { get; }
+        public bool IsValid { get; set; }
+    }
+    public sealed class ParallelActivity : CompositeActivity, IActivityEventListener<ActivityExecutionStatusChangedEventArgs> {
+        public ParallelActivity();
+        public ParallelActivity(string name);
+        protected override ActivityExecutionStatus Cancel(ActivityExecutionContext executionContext);
+        protected override ActivityExecutionStatus Execute(ActivityExecutionContext executionContext);
+        protected override void OnActivityChangeAdd(ActivityExecutionContext executionContext, Activity addedActivity);
+        protected override void OnActivityChangeRemove(ActivityExecutionContext rootExecutionContext, Activity removedActivity);
+        protected override void OnClosed(IServiceProvider provider);
+        protected override void OnWorkflowChangesCompleted(ActivityExecutionContext executionContext);
+        void System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs>.OnEvent(object sender, ActivityExecutionStatusChangedEventArgs e);
+    }
+    public sealed class PolicyActivity : Activity {
+        public static readonly DependencyProperty RuleSetReferenceProperty;
+        public PolicyActivity();
+        public PolicyActivity(string name);
+        public RuleSetReference RuleSetReference { get; set; }
+        protected override ActivityExecutionStatus Execute(ActivityExecutionContext executionContext);
+        protected override void Initialize(IServiceProvider provider);
+    }
+    public sealed class ReceiveActivity : SequenceActivity, IActivityEventListener<QueueEventArgs>, IEventActivity, IServiceDescriptionBuilder {
+        public static readonly DependencyProperty FaultMessageProperty;
+        public static readonly DependencyProperty OperationValidationEvent;
+        public static readonly DependencyProperty WorkflowServiceAttributesProperty;
+        public ReceiveActivity();
+        public ReceiveActivity(string name);
+        public bool CanCreateInstance { get; set; }
+        public IDictionary<string, string> Context { get; }
+        public ContextToken ContextToken { get; set; }
+        public FaultException FaultMessage { get; set; }
+        public WorkflowParameterBindingCollection ParameterBindings { get; }
+        public OperationInfoBase ServiceOperationInfo { get; set; }
+        IComparable System.Workflow.Activities.IEventActivity.QueueName { get; }
+        public event EventHandler<OperationValidationEventArgs> OperationValidation;
+        protected override ActivityExecutionStatus Cancel(ActivityExecutionContext executionContext);
+        protected override void Dispose(bool disposing);
+        protected override ActivityExecutionStatus Execute(ActivityExecutionContext executionContext);
+        public static IDictionary<string, string> GetContext(Activity activity, string contextName, string ownerActivityName);
+        public static IDictionary<string, string> GetContext(Activity activity, ContextToken contextToken);
+        public static IDictionary<string, string> GetRootContext(Activity activity);
+        public static object GetWorkflowServiceAttributes(object dependencyObject);
+        protected override ActivityExecutionStatus HandleFault(ActivityExecutionContext executionContext, Exception exception);
+        protected internal override void Initialize(IServiceProvider provider);
+        protected override void InitializeProperties();
+        protected override void OnSequenceComplete(ActivityExecutionContext executionContext);
+        public static void SetWorkflowServiceAttributes(object dependencyObject, object value);
+        void System.Workflow.Activities.IEventActivity.Subscribe(ActivityExecutionContext parentContext, IActivityEventListener<QueueEventArgs> parentEventHandler);
+        void System.Workflow.Activities.IEventActivity.Unsubscribe(ActivityExecutionContext parentContext, IActivityEventListener<QueueEventArgs> parentEventHandler);
+        void System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.QueueEventArgs>.OnEvent(object sender, QueueEventArgs e);
+    }
+    public sealed class ReplicatorActivity : CompositeActivity {
+        public static readonly DependencyProperty ChildCompletedEvent;
+        public static readonly DependencyProperty ChildInitializedEvent;
+        public static readonly DependencyProperty CompletedEvent;
+        public static readonly DependencyProperty ExecutionTypeProperty;
+        public static readonly DependencyProperty InitialChildDataProperty;
+        public static readonly DependencyProperty InitializedEvent;
+        public static readonly DependencyProperty UntilConditionProperty;
+        public ReplicatorActivity();
+        public ReplicatorActivity(string name);
+        public bool AllChildrenComplete { get; }
+        public IList CurrentChildData { get; }
+        public int CurrentIndex { get; }
+        public ICollection<Activity> DynamicActivities { get; }
+        public ExecutionType ExecutionType { get; set; }
+        public IList InitialChildData { get; set; }
+        public ActivityCondition UntilCondition { get; set; }
+        public event EventHandler<ReplicatorChildEventArgs> ChildCompleted;
+        public event EventHandler<ReplicatorChildEventArgs> ChildInitialized;
+        public event EventHandler Completed;
+        public event EventHandler Initialized;
+        protected override ActivityExecutionStatus Cancel(ActivityExecutionContext executionContext);
+        protected override ActivityExecutionStatus Execute(ActivityExecutionContext executionContext);
+        public bool IsExecuting(int index);
+        protected override void OnClosed(IServiceProvider provider);
+    }
+    public sealed class ReplicatorChildEventArgs : EventArgs {
+        public ReplicatorChildEventArgs(object instanceData, Activity activity);
+        public Activity Activity { get; }
+        public object InstanceData { get; }
+    }
+    public sealed class SendActivity : Activity {
+        public const string ReturnValuePropertyName = "(ReturnValue)";
+        public static readonly DependencyProperty AfterResponseEvent;
+        public static readonly DependencyProperty BeforeSendEvent;
+        public static readonly DependencyProperty CustomAddressProperty;
+        public SendActivity();
+        public SendActivity(string name);
+        public ChannelToken ChannelToken { get; set; }
+        public IDictionary<string, string> Context { get; set; }
+        public string CustomAddress { get; set; }
+        public WorkflowParameterBindingCollection ParameterBindings { get; }
+        public TypedOperationInfo ServiceOperationInfo { get; set; }
+        public event EventHandler<SendActivityEventArgs> AfterResponse;
+        public event EventHandler<SendActivityEventArgs> BeforeSend;
+        protected internal override ActivityExecutionStatus Execute(ActivityExecutionContext executionContext);
+        public static IDictionary<string, string> GetContext(Activity activity, string endpointName, string ownerActivityName, Type contractType);
+        public static IDictionary<string, string> GetContext(Activity activity, ChannelToken endpoint, Type contractType);
+        protected override void InitializeProperties();
+        public static void SetContext(Activity activity, string endpointName, string ownerActivityName, Type contractType, IDictionary<string, string> context);
+        public static void SetContext(Activity activity, ChannelToken endpoint, Type contractType, IDictionary<string, string> context);
+    }
+    public sealed class SendActivityEventArgs : EventArgs {
+        public SendActivityEventArgs(SendActivity sendActivity);
+        public SendActivity SendActivity { get; }
+    }
+    public class SequenceActivity : CompositeActivity, IActivityEventListener<ActivityExecutionStatusChangedEventArgs> {
+        public SequenceActivity();
+        public SequenceActivity(string name);
+        protected override ActivityExecutionStatus Cancel(ActivityExecutionContext executionContext);
+        protected override ActivityExecutionStatus Execute(ActivityExecutionContext executionContext);
+        protected override ActivityExecutionStatus HandleFault(ActivityExecutionContext executionContext, Exception exception);
+        protected override void OnActivityChangeRemove(ActivityExecutionContext executionContext, Activity removedActivity);
+        protected virtual void OnSequenceComplete(ActivityExecutionContext executionContext);
+        protected override void OnWorkflowChangesCompleted(ActivityExecutionContext executionContext);
+        void System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs>.OnEvent(object sender, ActivityExecutionStatusChangedEventArgs e);
+    }
+    public class SequentialWorkflowActivity : SequenceActivity {
+        public static readonly DependencyProperty CompletedEvent;
+        public static readonly DependencyProperty InitializedEvent;
+        public SequentialWorkflowActivity();
+        public SequentialWorkflowActivity(string name);
+        public ActivityCondition DynamicUpdateCondition { get; set; }
+        public event EventHandler Completed;
+        public event EventHandler Initialized;
+        protected override ActivityExecutionStatus Execute(ActivityExecutionContext executionContext);
+        protected sealed override void OnSequenceComplete(ActivityExecutionContext executionContext);
+    }
+    public sealed class SetStateActivity : Activity {
+        public static readonly DependencyProperty TargetStateNameProperty;
+        public SetStateActivity();
+        public SetStateActivity(string name);
+        public string TargetStateName { get; set; }
+        protected override ActivityExecutionStatus Execute(ActivityExecutionContext executionContext);
+    }
+    public class SetStateEventArgs : EventArgs {
+        public SetStateEventArgs(string targetStateName);
+        public string TargetStateName { get; }
+    }
+    public class StateActivity : CompositeActivity {
+        public const string StateChangeTrackingDataKey = "StateActivity.StateChange";
+        public StateActivity();
+        public StateActivity(string name);
+        protected override ActivityExecutionStatus Cancel(ActivityExecutionContext executionContext);
+        protected override ActivityExecutionStatus Execute(ActivityExecutionContext executionContext);
+        public Activity GetDynamicActivity(string childActivityName);
+        protected override void Initialize(IServiceProvider provider);
+        protected override void OnActivityChangeAdd(ActivityExecutionContext executionContext, Activity addedActivity);
+        protected override void OnClosed(IServiceProvider provider);
+    }
+    public class StateActivityValidator : CompositeActivityValidator {
+        public StateActivityValidator();
+        public override ValidationErrorCollection Validate(ValidationManager manager, object obj);
+        public override ValidationError ValidateActivityChange(Activity activity, ActivityChangeAction action);
+    }
+    public sealed class StateFinalizationActivity : SequenceActivity {
+        public StateFinalizationActivity();
+        public StateFinalizationActivity(string name);
+    }
+    public sealed class StateInitializationActivity : SequenceActivity {
+        public StateInitializationActivity();
+        public StateInitializationActivity(string name);
+    }
+    public class StateMachineWorkflowActivity : StateActivity {
+        public const string SetStateQueueName = "SetStateQueue";
+        public static readonly DependencyProperty CompletedStateNameProperty;
+        public static readonly DependencyProperty InitialStateNameProperty;
+        public StateMachineWorkflowActivity();
+        public StateMachineWorkflowActivity(string name);
+        public string CompletedStateName { get; set; }
+        public string CurrentStateName { get; }
+        public ActivityCondition DynamicUpdateCondition { get; set; }
+        public string InitialStateName { get; set; }
+        public string PreviousStateName { get; }
+    }
+    public sealed class StateMachineWorkflowInstance {
+        public StateMachineWorkflowInstance(WorkflowRuntime runtime, Guid instanceId);
+        public StateActivity CurrentState { get; }
+        public string CurrentStateName { get; }
+        public Guid InstanceId { get; }
+        public ReadOnlyCollection<string> PossibleStateTransitions { get; }
+        public ReadOnlyCollection<string> StateHistory { get; }
+        public StateMachineWorkflowActivity StateMachineWorkflow { get; }
+        public ReadOnlyCollection<StateActivity> States { get; }
+        public WorkflowInstance WorkflowInstance { get; }
+        public void EnqueueItem(IComparable queueName, object item);
+        public void EnqueueItem(IComparable queueName, object item, IPendingWork pendingWork, object workItem);
+        public void SetState(string targetStateName);
+        public void SetState(StateActivity targetState);
+    }
+    public sealed class TypedOperationInfo : OperationInfoBase {
+        public TypedOperationInfo();
+        public TypedOperationInfo(Type contractType, string operationName);
+        public Type ContractType { get; set; }
+        public override OperationInfoBase Clone();
+        public override bool Equals(object obj);
+        protected internal override string GetContractFullName(IServiceProvider provider);
+        protected internal override Type GetContractType(IServiceProvider provider);
+        public override int GetHashCode();
+        protected internal override bool GetIsOneWay(IServiceProvider provider);
+        protected internal override MethodInfo GetMethodInfo(IServiceProvider provider);
+        protected internal override OperationParameterInfoCollection GetParameters(IServiceProvider provider);
+        public override string ToString();
+    }
+    public sealed class WebServiceFaultActivity : Activity, IPropertyValueProvider {
+        public static readonly DependencyProperty FaultProperty;
+        public static readonly DependencyProperty InputActivityNameProperty;
+        public static readonly DependencyProperty SendingFaultEvent;
+        public WebServiceFaultActivity();
+        public WebServiceFaultActivity(string name);
+        public Exception Fault { get; set; }
+        public string InputActivityName { get; set; }
+        public event EventHandler SendingFault;
+        protected override ActivityExecutionStatus Execute(ActivityExecutionContext executionContext);
+        protected override void Initialize(IServiceProvider provider);
+    }
+    public sealed class WebServiceInputActivity : Activity, IActivityEventListener<QueueEventArgs>, IDynamicPropertyTypeProvider, IEventActivity, IPropertyValueProvider {
+        public static readonly DependencyProperty ActivitySubscribedProperty;
+        public static readonly DependencyProperty InputReceivedEvent;
+        public static readonly DependencyProperty InterfaceTypeProperty;
+        public static readonly DependencyProperty IsActivatingProperty;
+        public static readonly DependencyProperty MethodNameProperty;
+        public static readonly DependencyProperty ParameterBindingsProperty;
+        public static readonly DependencyProperty RolesProperty;
+        public WebServiceInputActivity();
+        public WebServiceInputActivity(string name);
+        public Type InterfaceType { get; set; }
+        public bool IsActivating { get; set; }
+        public string MethodName { get; set; }
+        public WorkflowParameterBindingCollection ParameterBindings { get; }
+        public WorkflowRoleCollection Roles { get; set; }
+        IComparable System.Workflow.Activities.IEventActivity.QueueName { get; }
+        public event EventHandler InputReceived;
+        protected sealed override ActivityExecutionStatus Cancel(ActivityExecutionContext executionContext);
+        protected sealed override ActivityExecutionStatus Execute(ActivityExecutionContext executionContext);
+        protected sealed override ActivityExecutionStatus HandleFault(ActivityExecutionContext executionContext, Exception exception);
+        protected sealed override void Initialize(IServiceProvider provider);
+        void System.Workflow.Activities.IEventActivity.Subscribe(ActivityExecutionContext parentContext, IActivityEventListener<QueueEventArgs> parentEventHandler);
+        void System.Workflow.Activities.IEventActivity.Unsubscribe(ActivityExecutionContext parentContext, IActivityEventListener<QueueEventArgs> parentEventHandler);
+        void System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.QueueEventArgs>.OnEvent(object sender, QueueEventArgs e);
+        AccessTypes System.Workflow.ComponentModel.IDynamicPropertyTypeProvider.GetAccessType(IServiceProvider serviceProvider, string propertyName);
+        Type System.Workflow.ComponentModel.IDynamicPropertyTypeProvider.GetPropertyType(IServiceProvider serviceProvider, string propertyName);
+    }
+    public sealed class WebServiceOutputActivity : Activity, IDynamicPropertyTypeProvider, IPropertyValueProvider {
+        public static readonly DependencyProperty InputActivityNameProperty;
+        public static readonly DependencyProperty ParameterBindingsProperty;
+        public static readonly DependencyProperty SendingOutputEvent;
+        public WebServiceOutputActivity();
+        public WebServiceOutputActivity(string name);
+        public string InputActivityName { get; set; }
+        public WorkflowParameterBindingCollection ParameterBindings { get; }
+        public event EventHandler SendingOutput;
+        protected override ActivityExecutionStatus Execute(ActivityExecutionContext executionContext);
+        protected override void Initialize(IServiceProvider provider);
+        AccessTypes System.Workflow.ComponentModel.IDynamicPropertyTypeProvider.GetAccessType(IServiceProvider serviceProvider, string propertyName);
+        Type System.Workflow.ComponentModel.IDynamicPropertyTypeProvider.GetPropertyType(IServiceProvider serviceProvider, string propertyName);
+    }
+    public class WebWorkflowRole : WorkflowRole {
+        public WebWorkflowRole(string roleName);
+        public WebWorkflowRole(string roleName, string provider);
+        public override string Name { get; set; }
+        public string RoleProvider { get; set; }
+        public override IList<string> GetIdentities();
+        public override bool IncludesIdentity(string identity);
+    }
+    public sealed class WhileActivity : CompositeActivity, IActivityEventListener<ActivityExecutionStatusChangedEventArgs> {
+        public static readonly DependencyProperty ConditionProperty;
+        public WhileActivity();
+        public WhileActivity(string name);
+        public ActivityCondition Condition { get; set; }
+        public Activity DynamicActivity { get; }
+        protected override ActivityExecutionStatus Cancel(ActivityExecutionContext executionContext);
+        protected override ActivityExecutionStatus Execute(ActivityExecutionContext executionContext);
+        void System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs>.OnEvent(object sender, ActivityExecutionStatusChangedEventArgs e);
+    }
+    public class WorkflowAuthorizationException : SystemException {
+        public WorkflowAuthorizationException();
+        protected WorkflowAuthorizationException(SerializationInfo info, StreamingContext context);
+        public WorkflowAuthorizationException(string message);
+        public WorkflowAuthorizationException(string message, Exception innerException);
+        public WorkflowAuthorizationException(string activityName, string principalName);
+    }
+    public abstract class WorkflowRole {
+        protected WorkflowRole();
+        public abstract string Name { get; set; }
+        public abstract IList<string> GetIdentities();
+        public abstract bool IncludesIdentity(string identity);
+    }
+    public sealed class WorkflowRoleCollection : List<WorkflowRole> {
+        public WorkflowRoleCollection();
+        public bool IncludesIdentity(string identity);
+    }
+    public sealed class WorkflowServiceAttributes : DependencyObject, IServiceDescriptionBuilder {
+        public WorkflowServiceAttributes();
+        public AddressFilterMode AddressFilterMode { get; set; }
+        public string ConfigurationName { get; set; }
+        public bool IgnoreExtensionDataObject { get; set; }
+        public bool IncludeExceptionDetailInFaults { get; set; }
+        public int MaxItemsInObjectGraph { get; set; }
+        public string Name { get; set; }
+        public string Namespace { get; set; }
+        public bool UseSynchronizationContext { get; set; }
+        public bool ValidateMustUnderstand { get; set; }
+    }
+    public sealed class WorkflowServiceAttributesDynamicPropertyValidator : Validator {
+        public WorkflowServiceAttributesDynamicPropertyValidator();
+        public override ValidationErrorCollection Validate(ValidationManager manager, object obj);
+    }
+    public abstract class WorkflowSubscriptionService {
+        protected WorkflowSubscriptionService();
+        public abstract void CreateSubscription(MessageEventSubscription subscription);
+        public abstract void DeleteSubscription(Guid subscriptionId);
+    }
+    public abstract class WorkflowWebService : WebService {
+        protected WorkflowWebService(Type workflowType);
+        protected WorkflowRuntime WorkflowRuntime { get; }
+        protected object[] Invoke(Type interfaceType, string methodName, bool isActivation, object[] parameters);
+    }
+}
```

