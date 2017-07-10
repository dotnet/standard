# System.Workflow.Runtime.Hosting

``` diff
+namespace System.Workflow.Runtime.Hosting {
+    public sealed class ChannelManagerService : WorkflowRuntimeService {
+        public ChannelManagerService();
+        public ChannelManagerService(IList<ServiceEndpoint> endpoints);
+        public ChannelManagerService(NameValueCollection parameters);
+        public ChannelManagerService(ChannelPoolSettings settings);
+        public ChannelManagerService(ChannelPoolSettings settings, IList<ServiceEndpoint> endpoints);
+        protected internal override void Start();
+        protected internal override void Stop();
+    }
+    public class DefaultWorkflowCommitWorkBatchService : WorkflowCommitWorkBatchService {
+        public DefaultWorkflowCommitWorkBatchService();
+        public DefaultWorkflowCommitWorkBatchService(NameValueCollection parameters);
+        public bool EnableRetries { get; set; }
+        protected internal override void CommitWorkBatch(WorkflowCommitWorkBatchService.CommitWorkBatchCallback commitWorkBatchCallback);
+        protected override void OnStopped();
+        protected internal override void Start();
+    }
+    public class DefaultWorkflowLoaderService : WorkflowLoaderService {
+        public DefaultWorkflowLoaderService();
+        protected internal override Activity CreateInstance(Type workflowType);
+        protected internal override Activity CreateInstance(XmlReader workflowDefinitionReader, XmlReader rulesReader);
+    }
+    public class DefaultWorkflowSchedulerService : WorkflowSchedulerService {
+        public DefaultWorkflowSchedulerService();
+        public DefaultWorkflowSchedulerService(NameValueCollection parameters);
+        public DefaultWorkflowSchedulerService(int maxSimultaneousWorkflows);
+        public int MaxSimultaneousWorkflows { get; }
+        protected internal override void Cancel(Guid timerId);
+        protected override void OnStarted();
+        protected internal override void Schedule(WaitCallback callback, Guid workflowInstanceId);
+        protected internal override void Schedule(WaitCallback callback, Guid workflowInstanceId, DateTime whenUtc, Guid timerId);
+        protected internal override void Stop();
+    }
+    public class ManualWorkflowSchedulerService : WorkflowSchedulerService {
+        public ManualWorkflowSchedulerService();
+        public ManualWorkflowSchedulerService(bool useActiveTimers);
+        public ManualWorkflowSchedulerService(NameValueCollection parameters);
+        protected internal override void Cancel(Guid timerId);
+        protected override void OnStarted();
+        public bool RunWorkflow(Guid workflowInstanceId);
+        protected internal override void Schedule(WaitCallback callback, Guid workflowInstanceId);
+        protected internal override void Schedule(WaitCallback callback, Guid workflowInstanceId, DateTime whenUtc, Guid timerId);
+        protected internal override void Stop();
+    }
+    public class PersistenceException : SystemException {
+        public PersistenceException();
+        protected PersistenceException(SerializationInfo info, StreamingContext context);
+        public PersistenceException(string message);
+        public PersistenceException(string message, Exception innerException);
+    }
+    public class SharedConnectionWorkflowCommitWorkBatchService : WorkflowCommitWorkBatchService {
+        public SharedConnectionWorkflowCommitWorkBatchService(NameValueCollection parameters);
+        public SharedConnectionWorkflowCommitWorkBatchService(string connectionString);
+        public bool EnableRetries { get; set; }
+        protected internal override void CommitWorkBatch(WorkflowCommitWorkBatchService.CommitWorkBatchCallback commitWorkBatchCallback);
+        protected override void OnStopped();
+        protected internal override void Start();
+    }
+    public class SqlPersistenceWorkflowInstanceDescription {
+        public bool IsBlocked { get; }
+        public SqlDateTime NextTimerExpiration { get; }
+        public WorkflowStatus Status { get; }
+        public string SuspendOrTerminateDescription { get; }
+        public Guid WorkflowInstanceId { get; }
+    }
+    public class SqlWorkflowPersistenceService : WorkflowPersistenceService, IPendingWork {
+        public SqlWorkflowPersistenceService(NameValueCollection parameters);
+        public SqlWorkflowPersistenceService(string connectionString);
+        public SqlWorkflowPersistenceService(string connectionString, bool unloadOnIdle, TimeSpan instanceOwnershipDuration, TimeSpan loadingInterval);
+        public bool EnableRetries { get; set; }
+        public TimeSpan LoadingInterval { get; }
+        public Guid ServiceInstanceId { get; }
+        public IEnumerable<SqlPersistenceWorkflowInstanceDescription> GetAllWorkflows();
+        protected internal override Activity LoadCompletedContextActivity(Guid id, Activity outerActivity);
+        public IList<Guid> LoadExpiredTimerWorkflowIds();
+        protected internal override Activity LoadWorkflowInstanceState(Guid id);
+        protected override void OnStarted();
+        protected internal override void SaveCompletedContextActivity(Activity completedScopeActivity);
+        protected internal override void SaveWorkflowInstanceState(Activity rootActivity, bool unlock);
+        protected internal override void Start();
+        protected internal override void Stop();
+        void System.Workflow.Runtime.IPendingWork.Commit(Transaction transaction, ICollection items);
+        void System.Workflow.Runtime.IPendingWork.Complete(bool succeeded, ICollection items);
+        bool System.Workflow.Runtime.IPendingWork.MustCommit(ICollection items);
+        protected internal override bool UnloadOnIdle(Activity activity);
+        protected internal override void UnlockWorkflowInstanceState(Activity rootActivity);
+    }
+    public abstract class WorkflowCommitWorkBatchService : WorkflowRuntimeService {
+        protected WorkflowCommitWorkBatchService();
+        protected internal virtual void CommitWorkBatch(WorkflowCommitWorkBatchService.CommitWorkBatchCallback commitWorkBatchCallback);
+        public delegate void CommitWorkBatchCallback();
+    }
+    public abstract class WorkflowLoaderService : WorkflowRuntimeService {
+        protected WorkflowLoaderService();
+        protected internal abstract Activity CreateInstance(Type workflowType);
+        protected internal abstract Activity CreateInstance(XmlReader workflowDefinitionReader, XmlReader rulesReader);
+    }
+    public abstract class WorkflowPersistenceService : WorkflowRuntimeService {
+        protected WorkflowPersistenceService();
+        protected static byte[] GetDefaultSerializedForm(Activity activity);
+        protected internal static bool GetIsBlocked(Activity rootActivity);
+        protected internal static string GetSuspendOrTerminateInfo(Activity rootActivity);
+        protected internal static WorkflowStatus GetWorkflowStatus(Activity rootActivity);
+        protected internal abstract Activity LoadCompletedContextActivity(Guid scopeId, Activity outerActivity);
+        protected internal abstract Activity LoadWorkflowInstanceState(Guid instanceId);
+        protected static Activity RestoreFromDefaultSerializedForm(byte[] activityBytes, Activity outerActivity);
+        protected internal abstract void SaveCompletedContextActivity(Activity activity);
+        protected internal abstract void SaveWorkflowInstanceState(Activity rootActivity, bool unlock);
+        protected internal abstract bool UnloadOnIdle(Activity activity);
+        protected internal abstract void UnlockWorkflowInstanceState(Activity rootActivity);
+    }
+    public abstract class WorkflowRuntimeService {
+        protected WorkflowRuntimeService();
+        protected WorkflowRuntime Runtime { get; }
+        protected WorkflowRuntimeServiceState State { get; }
+        protected virtual void OnStarted();
+        protected virtual void OnStopped();
+        protected void RaiseServicesExceptionNotHandledEvent(Exception exception, Guid instanceId);
+        protected internal virtual void Start();
+        protected internal virtual void Stop();
+    }
+    public enum WorkflowRuntimeServiceState {
+        Started = 2,
+        Starting = 1,
+        Stopped = 0,
+        Stopping = 3,
+    }
+    public abstract class WorkflowSchedulerService : WorkflowRuntimeService {
+        protected WorkflowSchedulerService();
+        protected internal abstract void Cancel(Guid timerId);
+        protected internal abstract void Schedule(WaitCallback callback, Guid workflowInstanceId);
+        protected internal abstract void Schedule(WaitCallback callback, Guid workflowInstanceId, DateTime whenUtc, Guid timerId);
+    }
+    public sealed class WorkflowWebHostingModule : IHttpModule {
+        public WorkflowWebHostingModule();
+        void System.Web.IHttpModule.Dispose();
+        void System.Web.IHttpModule.Init(HttpApplication application);
+    }
+}
```

