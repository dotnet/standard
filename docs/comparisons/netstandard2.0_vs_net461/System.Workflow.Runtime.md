# System.Workflow.Runtime

``` diff
+namespace System.Workflow.Runtime {
+    public class CorrelationProperty {
+        public CorrelationProperty(string name, object value);
+        public string Name { get; }
+        public object Value { get; }
+    }
+    public sealed class CorrelationToken : DependencyObject, IPropertyValueProvider {
+        public CorrelationToken();
+        public CorrelationToken(string name);
+        public bool Initialized { get; }
+        public string Name { get; set; }
+        public string OwnerActivityName { get; set; }
+        public ICollection<CorrelationProperty> Properties { get; }
+        public void Initialize(Activity activity, ICollection<CorrelationProperty> propertyValues);
+        public void SubscribeForCorrelationTokenInitializedEvent(Activity activity, IActivityEventListener<CorrelationTokenEventArgs> dataChangeListener);
+        public void UnsubscribeFromCorrelationTokenInitializedEvent(Activity activity, IActivityEventListener<CorrelationTokenEventArgs> dataChangeListener);
+    }
+    public sealed class CorrelationTokenCollection : KeyedCollection<string, CorrelationToken> {
+        public static readonly DependencyProperty CorrelationTokenCollectionProperty;
+        public CorrelationTokenCollection();
+        protected override void ClearItems();
+        public static CorrelationToken GetCorrelationToken(Activity activity, string correlationTokenName, string ownerActivityName);
+        public CorrelationToken GetItem(string key);
+        protected override string GetKeyForItem(CorrelationToken item);
+        protected override void InsertItem(int index, CorrelationToken item);
+        protected override void RemoveItem(int index);
+        protected override void SetItem(int index, CorrelationToken item);
+    }
+    public sealed class CorrelationTokenEventArgs : EventArgs {
+        public CorrelationToken CorrelationToken { get; }
+        public bool IsInitializing { get; }
+    }
+    public interface IPendingWork {
+        void Commit(Transaction transaction, ICollection items);
+        void Complete(bool succeeded, ICollection items);
+        bool MustCommit(ICollection items);
+    }
+    public interface IWorkBatch {
+        void Add(IPendingWork work, object workItem);
+    }
+    public sealed class ServicesExceptionNotHandledEventArgs : EventArgs {
+        public Exception Exception { get; }
+        public Guid WorkflowInstanceId { get; }
+    }
+    public class TimerEventSubscription {
+        protected TimerEventSubscription();
+        public TimerEventSubscription(Guid workflowInstanceId, DateTime expiresAt);
+        public TimerEventSubscription(Guid timerId, Guid workflowInstanceId, DateTime expiresAt);
+        public virtual DateTime ExpiresAt { get; }
+        public virtual IComparable QueueName { get; protected set; }
+        public virtual Guid SubscriptionId { get; }
+        public virtual Guid WorkflowInstanceId { get; }
+    }
+    public class TimerEventSubscriptionCollection : ICollection, IEnumerable {
+        public static readonly DependencyProperty TimerCollectionProperty;
+        public int Count { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        public void Add(TimerEventSubscription item);
+        public void CopyTo(Array array, int index);
+        public IEnumerator GetEnumerator();
+        public TimerEventSubscription Peek();
+        public void Remove(Guid timerSubscriptionId);
+        public void Remove(TimerEventSubscription item);
+    }
+    public class WorkflowCompletedEventArgs : WorkflowEventArgs {
+        public Dictionary<string, object> OutputParameters { get; }
+        public Activity WorkflowDefinition { get; }
+    }
+    public static class WorkflowEnvironment {
+        public static IWorkBatch WorkBatch { get; }
+        public static Guid WorkflowInstanceId { get; }
+    }
+    public class WorkflowEventArgs : EventArgs {
+        public WorkflowInstance WorkflowInstance { get; }
+    }
+    public sealed class WorkflowInstance {
+        public Guid InstanceId { get; }
+        public WorkflowRuntime WorkflowRuntime { get; }
+        public void Abort();
+        public void ApplyWorkflowChanges(WorkflowChanges workflowChanges);
+        public void EnqueueItem(IComparable queueName, object item, IPendingWork pendingWork, object workItem);
+        public void EnqueueItemOnIdle(IComparable queueName, object item, IPendingWork pendingWork, object workItem);
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public Activity GetWorkflowDefinition();
+        public DateTime GetWorkflowNextTimerExpiration();
+        public ReadOnlyCollection<WorkflowQueueInfo> GetWorkflowQueueData();
+        public void Load();
+        public void ReloadTrackingProfiles();
+        public void Resume();
+        public void Start();
+        public void Suspend(string error);
+        public void Terminate(string error);
+        public bool TryUnload();
+        public void Unload();
+    }
+    public class WorkflowOwnershipException : Exception {
+        public WorkflowOwnershipException();
+        public WorkflowOwnershipException(Guid instanceId);
+        public WorkflowOwnershipException(Guid instanceId, string message);
+        public WorkflowOwnershipException(Guid instanceId, string message, Exception innerException);
+        protected WorkflowOwnershipException(SerializationInfo info, StreamingContext context);
+        public WorkflowOwnershipException(string message);
+        public WorkflowOwnershipException(string message, Exception innerException);
+        public Guid InstanceId { get; set; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class WorkflowQueue {
+        public int Count { get; }
+        public bool Enabled { get; set; }
+        public IComparable QueueName { get; }
+        public WorkflowQueuingService QueuingService { get; }
+        public event EventHandler<QueueEventArgs> QueueItemArrived;
+        public event EventHandler<QueueEventArgs> QueueItemAvailable;
+        public object Dequeue();
+        public void Enqueue(object item);
+        public object Peek();
+        public void RegisterForQueueItemArrived(IActivityEventListener<QueueEventArgs> eventListener);
+        public void RegisterForQueueItemAvailable(IActivityEventListener<QueueEventArgs> eventListener);
+        public void RegisterForQueueItemAvailable(IActivityEventListener<QueueEventArgs> eventListener, string subscriberQualifiedName);
+        public void UnregisterForQueueItemArrived(IActivityEventListener<QueueEventArgs> eventListener);
+        public void UnregisterForQueueItemAvailable(IActivityEventListener<QueueEventArgs> eventListener);
+    }
+    public class WorkflowQueueInfo {
+        public ICollection Items { get; }
+        public IComparable QueueName { get; }
+        public ReadOnlyCollection<string> SubscribedActivityNames { get; }
+    }
+    public class WorkflowQueuingService {
+        public static readonly DependencyProperty PendingMessagesProperty;
+        public WorkflowQueue CreateWorkflowQueue(IComparable queueName, bool transactional);
+        public void DeleteWorkflowQueue(IComparable queueName);
+        public bool Exists(IComparable queueName);
+        public WorkflowQueue GetWorkflowQueue(IComparable queueName);
+    }
+    public class WorkflowRuntime : IDisposable, IServiceProvider {
+        public WorkflowRuntime();
+        public WorkflowRuntime(string configSectionName);
+        public WorkflowRuntime(WorkflowRuntimeSection settings);
+        public bool IsStarted { get; }
+        public string Name { get; set; }
+        public event EventHandler<ServicesExceptionNotHandledEventArgs> ServicesExceptionNotHandled;
+        public event EventHandler<WorkflowRuntimeEventArgs> Started;
+        public event EventHandler<WorkflowRuntimeEventArgs> Stopped;
+        public event EventHandler<WorkflowEventArgs> WorkflowAborted;
+        public event EventHandler<WorkflowCompletedEventArgs> WorkflowCompleted;
+        public event EventHandler<WorkflowEventArgs> WorkflowCreated;
+        public event EventHandler<WorkflowEventArgs> WorkflowIdled;
+        public event EventHandler<WorkflowEventArgs> WorkflowLoaded;
+        public event EventHandler<WorkflowEventArgs> WorkflowPersisted;
+        public event EventHandler<WorkflowEventArgs> WorkflowResumed;
+        public event EventHandler<WorkflowEventArgs> WorkflowStarted;
+        public event EventHandler<WorkflowSuspendedEventArgs> WorkflowSuspended;
+        public event EventHandler<WorkflowTerminatedEventArgs> WorkflowTerminated;
+        public event EventHandler<WorkflowEventArgs> WorkflowUnloaded;
+        public void AddService(object service);
+        public WorkflowInstance CreateWorkflow(Type workflowType);
+        public WorkflowInstance CreateWorkflow(Type workflowType, Dictionary<string, object> namedArgumentValues);
+        public WorkflowInstance CreateWorkflow(Type workflowType, Dictionary<string, object> namedArgumentValues, Guid instanceId);
+        public WorkflowInstance CreateWorkflow(XmlReader workflowDefinitionReader);
+        public WorkflowInstance CreateWorkflow(XmlReader workflowDefinitionReader, XmlReader rulesReader, Dictionary<string, object> namedArgumentValues);
+        public WorkflowInstance CreateWorkflow(XmlReader workflowDefinitionReader, XmlReader rulesReader, Dictionary<string, object> namedArgumentValues, Guid instanceId);
+        public void Dispose();
+        public ReadOnlyCollection<object> GetAllServices(Type serviceType);
+        public ReadOnlyCollection<T> GetAllServices<T>();
+        public ReadOnlyCollection<WorkflowInstance> GetLoadedWorkflows();
+        public object GetService(Type serviceType);
+        public T GetService<T>();
+        public WorkflowInstance GetWorkflow(Guid instanceId);
+        public void RemoveService(object service);
+        public void StartRuntime();
+        public void StopRuntime();
+    }
+    public sealed class WorkflowRuntimeEventArgs : EventArgs {
+        public bool IsStarted { get; }
+    }
+    public enum WorkflowStatus {
+        Completed = 1,
+        Created = 4,
+        Running = 0,
+        Suspended = 2,
+        Terminated = 3,
+    }
+    public class WorkflowSuspendedEventArgs : WorkflowEventArgs {
+        public string Error { get; }
+    }
+    public class WorkflowTerminatedEventArgs : WorkflowEventArgs {
+        public Exception Exception { get; }
+    }
+}
```

