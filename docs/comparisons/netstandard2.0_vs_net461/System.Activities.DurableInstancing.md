# System.Activities.DurableInstancing

``` diff
+namespace System.Activities.DurableInstancing {
+    public sealed class ActivatableWorkflowsQueryResult : InstanceStoreQueryResult {
+        public ActivatableWorkflowsQueryResult();
+        public ActivatableWorkflowsQueryResult(IDictionary<XName, object> parameters);
+        public ActivatableWorkflowsQueryResult(IEnumerable<IDictionary<XName, object>> parameters);
+        public List<IDictionary<XName, object>> ActivationParameters { get; private set; }
+    }
+    public sealed class CreateWorkflowOwnerCommand : InstancePersistenceCommand {
+        public CreateWorkflowOwnerCommand();
+        public IDictionary<XName, InstanceValue> InstanceOwnerMetadata { get; }
+        protected internal override bool IsTransactionEnlistmentOptional { get; }
+        protected internal override void Validate(InstanceView view);
+    }
+    public sealed class CreateWorkflowOwnerWithIdentityCommand : InstancePersistenceCommand {
+        public CreateWorkflowOwnerWithIdentityCommand();
+        public IDictionary<XName, InstanceValue> InstanceOwnerMetadata { get; }
+        protected internal override bool IsTransactionEnlistmentOptional { get; }
+        protected internal override void Validate(InstanceView view);
+    }
+    public sealed class DeleteWorkflowOwnerCommand : InstancePersistenceCommand {
+        public DeleteWorkflowOwnerCommand();
+        protected internal override bool IsTransactionEnlistmentOptional { get; }
+        protected internal override void Validate(InstanceView view);
+    }
+    public sealed class HasActivatableWorkflowEvent : InstancePersistenceEvent<HasActivatableWorkflowEvent> {
+        public HasActivatableWorkflowEvent();
+    }
+    public sealed class HasRunnableWorkflowEvent : InstancePersistenceEvent<HasRunnableWorkflowEvent> {
+        public HasRunnableWorkflowEvent();
+    }
+    public enum InstanceCompletionAction {
+        DeleteAll = 1,
+        DeleteNothing = 0,
+    }
+    public enum InstanceEncodingOption {
+        GZip = 1,
+        None = 0,
+    }
+    public enum InstanceLockedExceptionAction {
+        AggressiveRetry = 2,
+        BasicRetry = 1,
+        NoRetry = 0,
+    }
+    public sealed class LoadWorkflowByInstanceKeyCommand : InstancePersistenceCommand {
+        public LoadWorkflowByInstanceKeyCommand();
+        public bool AcceptUninitializedInstance { get; set; }
+        public Guid AssociateInstanceKeyToInstanceId { get; set; }
+        protected internal override bool AutomaticallyAcquiringLock { get; }
+        public IDictionary<Guid, IDictionary<XName, InstanceValue>> InstanceKeysToAssociate { get; }
+        protected internal override bool IsTransactionEnlistmentOptional { get; }
+        public Guid LookupInstanceKey { get; set; }
+        protected internal override void Validate(InstanceView view);
+    }
+    public sealed class LoadWorkflowCommand : InstancePersistenceCommand {
+        public LoadWorkflowCommand();
+        public bool AcceptUninitializedInstance { get; set; }
+        protected internal override bool AutomaticallyAcquiringLock { get; }
+        protected internal override bool IsTransactionEnlistmentOptional { get; }
+        protected internal override void Validate(InstanceView view);
+    }
+    public sealed class QueryActivatableWorkflowsCommand : InstancePersistenceCommand {
+        public QueryActivatableWorkflowsCommand();
+        protected internal override bool IsTransactionEnlistmentOptional { get; }
+        protected internal override void Validate(InstanceView view);
+    }
+    public sealed class SaveWorkflowCommand : InstancePersistenceCommand {
+        public SaveWorkflowCommand();
+        protected internal override bool AutomaticallyAcquiringLock { get; }
+        public bool CompleteInstance { get; set; }
+        public IDictionary<XName, InstanceValue> InstanceData { get; }
+        public IDictionary<Guid, IDictionary<XName, InstanceValue>> InstanceKeyMetadataChanges { get; }
+        public IDictionary<Guid, IDictionary<XName, InstanceValue>> InstanceKeysToAssociate { get; }
+        public ICollection<Guid> InstanceKeysToComplete { get; }
+        public ICollection<Guid> InstanceKeysToFree { get; }
+        public IDictionary<XName, InstanceValue> InstanceMetadataChanges { get; }
+        protected internal override bool IsTransactionEnlistmentOptional { get; }
+        public bool UnlockInstance { get; set; }
+        protected internal override void Validate(InstanceView view);
+    }
+    public sealed class SqlWorkflowInstanceStore : InstanceStore {
+        public SqlWorkflowInstanceStore();
+        public SqlWorkflowInstanceStore(string connectionString);
+        public string ConnectionString { get; set; }
+        public bool EnqueueRunCommands { get; set; }
+        public TimeSpan HostLockRenewalPeriod { get; set; }
+        public InstanceCompletionAction InstanceCompletionAction { get; set; }
+        public InstanceEncodingOption InstanceEncodingOption { get; set; }
+        public InstanceLockedExceptionAction InstanceLockedExceptionAction { get; set; }
+        public int MaxConnectionRetries { get; set; }
+        public TimeSpan RunnableInstancesDetectionPeriod { get; set; }
+        protected internal override IAsyncResult BeginTryCommand(InstancePersistenceContext context, InstancePersistenceCommand command, TimeSpan timeout, AsyncCallback callback, object state);
+        protected internal override bool EndTryCommand(IAsyncResult result);
+        protected override void OnFreeInstanceHandle(InstanceHandle instanceHandle, object userContext);
+        protected override object OnNewInstanceHandle(InstanceHandle instanceHandle);
+        public void Promote(string name, IEnumerable<XName> promoteAsVariant, IEnumerable<XName> promoteAsBinary);
+    }
+    public sealed class TryLoadRunnableWorkflowCommand : InstancePersistenceCommand {
+        public TryLoadRunnableWorkflowCommand();
+        protected internal override bool AutomaticallyAcquiringLock { get; }
+        protected internal override bool IsTransactionEnlistmentOptional { get; }
+        protected internal override void Validate(InstanceView view);
+    }
+}
```

