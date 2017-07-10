# System.Runtime.DurableInstancing

``` diff
+namespace System.Runtime.DurableInstancing {
+    public class InstanceCollisionException : InstancePersistenceCommandException {
+        public InstanceCollisionException();
+        protected InstanceCollisionException(SerializationInfo info, StreamingContext context);
+        public InstanceCollisionException(string message);
+        public InstanceCollisionException(string message, Exception innerException);
+        public InstanceCollisionException(XName commandName, Guid instanceId);
+        public InstanceCollisionException(XName commandName, Guid instanceId, Exception innerException);
+        public InstanceCollisionException(XName commandName, Guid instanceId, string message, Exception innerException);
+    }
+    public class InstanceCompleteException : InstancePersistenceCommandException {
+        public InstanceCompleteException();
+        protected InstanceCompleteException(SerializationInfo info, StreamingContext context);
+        public InstanceCompleteException(string message);
+        public InstanceCompleteException(string message, Exception innerException);
+        public InstanceCompleteException(XName commandName, Guid instanceId);
+        public InstanceCompleteException(XName commandName, Guid instanceId, Exception innerException);
+        public InstanceCompleteException(XName commandName, Guid instanceId, string message, Exception innerException);
+    }
+    public sealed class InstanceHandle {
+        public bool IsValid { get; private set; }
+        public void Free();
+    }
+    public class InstanceHandleConflictException : InstancePersistenceCommandException {
+        public InstanceHandleConflictException();
+        protected InstanceHandleConflictException(SerializationInfo info, StreamingContext context);
+        public InstanceHandleConflictException(string message);
+        public InstanceHandleConflictException(string message, Exception innerException);
+        public InstanceHandleConflictException(XName commandName, Guid instanceId);
+        public InstanceHandleConflictException(XName commandName, Guid instanceId, Exception innerException);
+        public InstanceHandleConflictException(XName commandName, Guid instanceId, string message, Exception innerException);
+    }
+    public class InstanceKey {
+        public InstanceKey(Guid value);
+        public InstanceKey(Guid value, IDictionary<XName, InstanceValue> metadata);
+        public static InstanceKey InvalidKey { get; }
+        public bool IsValid { get; }
+        public IDictionary<XName, InstanceValue> Metadata { get; private set; }
+        public Guid Value { get; private set; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+    }
+    public class InstanceKeyCollisionException : InstancePersistenceCommandException {
+        public InstanceKeyCollisionException();
+        protected InstanceKeyCollisionException(SerializationInfo info, StreamingContext context);
+        public InstanceKeyCollisionException(string message);
+        public InstanceKeyCollisionException(string message, Exception innerException);
+        public InstanceKeyCollisionException(XName commandName, Guid instanceId, InstanceKey instanceKey, Guid conflictingInstanceId);
+        public InstanceKeyCollisionException(XName commandName, Guid instanceId, InstanceKey instanceKey, Guid conflictingInstanceId, Exception innerException);
+        public InstanceKeyCollisionException(XName commandName, Guid instanceId, InstanceKey instanceKey, Guid conflictingInstanceId, string message, Exception innerException);
+        public Guid ConflictingInstanceId { get; private set; }
+        public InstanceKey InstanceKey { get; private set; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class InstanceKeyCompleteException : InstancePersistenceCommandException {
+        public InstanceKeyCompleteException();
+        protected InstanceKeyCompleteException(SerializationInfo info, StreamingContext context);
+        public InstanceKeyCompleteException(string message);
+        public InstanceKeyCompleteException(string message, Exception innerException);
+        public InstanceKeyCompleteException(XName commandName, Guid instanceId, InstanceKey instanceKey, string message, Exception innerException);
+        public InstanceKeyCompleteException(XName commandName, InstanceKey instanceKey);
+        public InstanceKeyCompleteException(XName commandName, InstanceKey instanceKey, Exception innerException);
+        public InstanceKey InstanceKey { get; private set; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class InstanceKeyNotReadyException : InstancePersistenceCommandException {
+        public InstanceKeyNotReadyException();
+        protected InstanceKeyNotReadyException(SerializationInfo info, StreamingContext context);
+        public InstanceKeyNotReadyException(string message);
+        public InstanceKeyNotReadyException(string message, Exception innerException);
+        public InstanceKeyNotReadyException(XName commandName, Guid instanceId, InstanceKey instanceKey, string message, Exception innerException);
+        public InstanceKeyNotReadyException(XName commandName, InstanceKey instanceKey);
+        public InstanceKeyNotReadyException(XName commandName, InstanceKey instanceKey, Exception innerException);
+        public InstanceKey InstanceKey { get; private set; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public enum InstanceKeyState {
+        Associated = 1,
+        Completed = 2,
+        Unknown = 0,
+    }
+    public sealed class InstanceKeyView {
+        public Guid InstanceKey { get; private set; }
+        public IDictionary<XName, InstanceValue> InstanceKeyMetadata { get; internal set; }
+        public InstanceValueConsistency InstanceKeyMetadataConsistency { get; internal set; }
+        public InstanceKeyState InstanceKeyState { get; internal set; }
+    }
+    public class InstanceLockedException : InstancePersistenceCommandException {
+        public InstanceLockedException();
+        protected InstanceLockedException(SerializationInfo info, StreamingContext context);
+        public InstanceLockedException(string message);
+        public InstanceLockedException(string message, Exception innerException);
+        public InstanceLockedException(XName commandName, Guid instanceId);
+        public InstanceLockedException(XName commandName, Guid instanceId, Exception innerException);
+        public InstanceLockedException(XName commandName, Guid instanceId, Guid instanceOwnerId, IDictionary<XName, object> serializableInstanceOwnerMetadata);
+        public InstanceLockedException(XName commandName, Guid instanceId, Guid instanceOwnerId, IDictionary<XName, object> serializableInstanceOwnerMetadata, Exception innerException);
+        public InstanceLockedException(XName commandName, Guid instanceId, Guid instanceOwnerId, IDictionary<XName, object> serializableInstanceOwnerMetadata, string message, Exception innerException);
+        public InstanceLockedException(XName commandName, Guid instanceId, string message, Exception innerException);
+        public Guid InstanceOwnerId { get; private set; }
+        public IDictionary<XName, object> SerializableInstanceOwnerMetadata { get; private set; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class InstanceLockLostException : InstancePersistenceCommandException {
+        public InstanceLockLostException();
+        protected InstanceLockLostException(SerializationInfo info, StreamingContext context);
+        public InstanceLockLostException(string message);
+        public InstanceLockLostException(string message, Exception innerException);
+        public InstanceLockLostException(XName commandName, Guid instanceId);
+        public InstanceLockLostException(XName commandName, Guid instanceId, Exception innerException);
+        public InstanceLockLostException(XName commandName, Guid instanceId, string message, Exception innerException);
+    }
+    public sealed class InstanceLockQueryResult : InstanceStoreQueryResult {
+        public InstanceLockQueryResult();
+        public InstanceLockQueryResult(IDictionary<Guid, Guid> instanceOwnerIds);
+        public InstanceLockQueryResult(Guid instanceId, Guid instanceOwnerId);
+        public IDictionary<Guid, Guid> InstanceOwnerIds { get; private set; }
+    }
+    public class InstanceNotReadyException : InstancePersistenceCommandException {
+        public InstanceNotReadyException();
+        protected InstanceNotReadyException(SerializationInfo info, StreamingContext context);
+        public InstanceNotReadyException(string message);
+        public InstanceNotReadyException(string message, Exception innerException);
+        public InstanceNotReadyException(XName commandName, Guid instanceId);
+        public InstanceNotReadyException(XName commandName, Guid instanceId, Exception innerException);
+        public InstanceNotReadyException(XName commandName, Guid instanceId, string message, Exception innerException);
+    }
+    public sealed class InstanceOwner {
+        public Guid InstanceOwnerId { get; private set; }
+    }
+    public class InstanceOwnerException : InstancePersistenceException {
+        public InstanceOwnerException();
+        protected InstanceOwnerException(SerializationInfo info, StreamingContext context);
+        public InstanceOwnerException(string message);
+        public InstanceOwnerException(string message, Exception innerException);
+        public InstanceOwnerException(XName commandName, Guid instanceOwnerId);
+        public InstanceOwnerException(XName commandName, Guid instanceOwnerId, Exception innerException);
+        public InstanceOwnerException(XName commandName, Guid instanceOwnerId, string message, Exception innerException);
+        public Guid InstanceOwnerId { get; private set; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public sealed class InstanceOwnerQueryResult : InstanceStoreQueryResult {
+        public InstanceOwnerQueryResult();
+        public InstanceOwnerQueryResult(IDictionary<Guid, IDictionary<XName, InstanceValue>> instanceOwners);
+        public InstanceOwnerQueryResult(Guid instanceOwnerId, IDictionary<XName, InstanceValue> metadata);
+        public IDictionary<Guid, IDictionary<XName, InstanceValue>> InstanceOwners { get; private set; }
+    }
+    public abstract class InstancePersistenceCommand {
+        protected InstancePersistenceCommand(XName name);
+        protected internal virtual bool AutomaticallyAcquiringLock { get; }
+        protected internal virtual bool IsTransactionEnlistmentOptional { get; }
+        public XName Name { get; private set; }
+        protected internal virtual void Validate(InstanceView view);
+    }
+    public class InstancePersistenceCommandException : InstancePersistenceException {
+        public InstancePersistenceCommandException();
+        protected InstancePersistenceCommandException(SerializationInfo info, StreamingContext context);
+        public InstancePersistenceCommandException(string message);
+        public InstancePersistenceCommandException(string message, Exception innerException);
+        public InstancePersistenceCommandException(XName commandName);
+        public InstancePersistenceCommandException(XName commandName, Exception innerException);
+        public InstancePersistenceCommandException(XName commandName, Guid instanceId);
+        public InstancePersistenceCommandException(XName commandName, Guid instanceId, Exception innerException);
+        public InstancePersistenceCommandException(XName commandName, Guid instanceId, string message, Exception innerException);
+        public InstancePersistenceCommandException(XName commandName, string message, Exception innerException);
+        public Guid InstanceId { get; private set; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public sealed class InstancePersistenceContext {
+        public InstanceHandle InstanceHandle { get; private set; }
+        public long InstanceVersion { get; }
+        public InstanceView InstanceView { get; private set; }
+        public Guid LockToken { get; }
+        public object UserContext { get; }
+        public void AssociatedInstanceKey(Guid key);
+        public IAsyncResult BeginBindReclaimedLock(long instanceVersion, TimeSpan timeout, AsyncCallback callback, object state);
+        public IAsyncResult BeginExecute(InstancePersistenceCommand command, TimeSpan timeout, AsyncCallback callback, object state);
+        public void BindAcquiredLock(long instanceVersion);
+        public void BindEvent(InstancePersistenceEvent persistenceEvent);
+        public void BindInstance(Guid instanceId);
+        public void BindInstanceOwner(Guid instanceOwnerId, Guid lockToken);
+        public void BindReclaimedLock(long instanceVersion, TimeSpan timeout);
+        public void CompletedInstance();
+        public void CompletedInstanceKey(Guid key);
+        public Exception CreateBindReclaimedLockException(long instanceVersion);
+        public void EndBindReclaimedLock(IAsyncResult result);
+        public void EndExecute(IAsyncResult result);
+        public void Execute(InstancePersistenceCommand command, TimeSpan timeout);
+        public void LoadedInstance(InstanceState state, IDictionary<XName, InstanceValue> instanceData, IDictionary<XName, InstanceValue> instanceMetadata, IDictionary<Guid, IDictionary<XName, InstanceValue>> associatedInstanceKeyMetadata, IDictionary<Guid, IDictionary<XName, InstanceValue>> completedInstanceKeyMetadata);
+        public void PersistedInstance(IDictionary<XName, InstanceValue> data);
+        public void QueriedInstanceStore(InstanceStoreQueryResult queryResult);
+        public void ReadInstanceKeyMetadata(Guid key, IDictionary<XName, InstanceValue> metadata, bool complete);
+        public void ReadInstanceMetadata(IDictionary<XName, InstanceValue> metadata, bool complete);
+        public void ReadInstanceOwnerMetadata(IDictionary<XName, InstanceValue> metadata, bool complete);
+        public void SetCancellationHandler(Action<InstancePersistenceContext> cancellationHandler);
+        public void UnassociatedInstanceKey(Guid key);
+        public void WroteInstanceKeyMetadataValue(Guid key, XName name, InstanceValue value);
+        public void WroteInstanceMetadataValue(XName name, InstanceValue value);
+        public void WroteInstanceOwnerMetadataValue(XName name, InstanceValue value);
+    }
+    public abstract class InstancePersistenceEvent : IEquatable<InstancePersistenceEvent> {
+        public XName Name { get; private set; }
+        public override bool Equals(object obj);
+        public bool Equals(InstancePersistenceEvent persistenceEvent);
+        public override int GetHashCode();
+        public static bool operator ==(InstancePersistenceEvent left, InstancePersistenceEvent right);
+        public static bool operator !=(InstancePersistenceEvent left, InstancePersistenceEvent right);
+    }
+    public abstract class InstancePersistenceEvent<T> : InstancePersistenceEvent where T : InstancePersistenceEvent<T>, new() {
+        protected InstancePersistenceEvent(XName name);
+        public static T Value { get; }
+    }
+    public class InstancePersistenceException : Exception {
+        public InstancePersistenceException();
+        protected InstancePersistenceException(SerializationInfo info, StreamingContext context);
+        public InstancePersistenceException(string message);
+        public InstancePersistenceException(string message, Exception innerException);
+        public InstancePersistenceException(XName commandName);
+        public InstancePersistenceException(XName commandName, Exception innerException);
+        public InstancePersistenceException(XName commandName, string message);
+        public InstancePersistenceException(XName commandName, string message, Exception innerException);
+        public XName CommandName { get; private set; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public enum InstanceState {
+        Completed = 3,
+        Initialized = 2,
+        Uninitialized = 1,
+        Unknown = 0,
+    }
+    public abstract class InstanceStore {
+        protected InstanceStore();
+        public InstanceOwner DefaultInstanceOwner { get; set; }
+        public IAsyncResult BeginExecute(InstanceHandle handle, InstancePersistenceCommand command, TimeSpan timeout, AsyncCallback callback, object state);
+        protected internal virtual IAsyncResult BeginTryCommand(InstancePersistenceContext context, InstancePersistenceCommand command, TimeSpan timeout, AsyncCallback callback, object state);
+        public IAsyncResult BeginWaitForEvents(InstanceHandle handle, TimeSpan timeout, AsyncCallback callback, object state);
+        public InstanceHandle CreateInstanceHandle();
+        public InstanceHandle CreateInstanceHandle(Guid instanceId);
+        public InstanceHandle CreateInstanceHandle(InstanceOwner owner);
+        public InstanceHandle CreateInstanceHandle(InstanceOwner owner, Guid instanceId);
+        public InstanceView EndExecute(IAsyncResult result);
+        protected internal virtual bool EndTryCommand(IAsyncResult result);
+        public List<InstancePersistenceEvent> EndWaitForEvents(IAsyncResult result);
+        public InstanceView Execute(InstanceHandle handle, InstancePersistenceCommand command, TimeSpan timeout);
+        protected InstancePersistenceEvent[] GetEvents(InstanceOwner owner);
+        protected InstanceOwner[] GetInstanceOwners();
+        protected virtual void OnFreeInstanceHandle(InstanceHandle instanceHandle, object userContext);
+        protected virtual object OnNewInstanceHandle(InstanceHandle instanceHandle);
+        protected void ResetEvent(InstancePersistenceEvent persistenceEvent, InstanceOwner owner);
+        protected void SignalEvent(InstancePersistenceEvent persistenceEvent, InstanceOwner owner);
+        protected internal virtual bool TryCommand(InstancePersistenceContext context, InstancePersistenceCommand command, TimeSpan timeout);
+        public List<InstancePersistenceEvent> WaitForEvents(InstanceHandle handle, TimeSpan timeout);
+    }
+    public abstract class InstanceStoreQueryResult {
+        protected InstanceStoreQueryResult();
+    }
+    public sealed class InstanceValue {
+        public InstanceValue(object value);
+        public InstanceValue(object value, InstanceValueOptions options);
+        public static InstanceValue DeletedValue { get; }
+        public bool IsDeletedValue { get; }
+        public InstanceValueOptions Options { get; private set; }
+        public object Value { get; private set; }
+    }
+    public enum InstanceValueConsistency {
+        InDoubt = 1,
+        None = 0,
+        Partial = 2,
+    }
+    public enum InstanceValueOptions {
+        None = 0,
+        Optional = 1,
+        WriteOnly = 2,
+    }
+    public sealed class InstanceView {
+        public IDictionary<XName, InstanceValue> InstanceData { get; internal set; }
+        public InstanceValueConsistency InstanceDataConsistency { get; internal set; }
+        public Guid InstanceId { get; private set; }
+        public IDictionary<Guid, InstanceKeyView> InstanceKeys { get; internal set; }
+        public InstanceValueConsistency InstanceKeysConsistency { get; internal set; }
+        public IDictionary<XName, InstanceValue> InstanceMetadata { get; internal set; }
+        public InstanceValueConsistency InstanceMetadataConsistency { get; internal set; }
+        public InstanceOwner InstanceOwner { get; private set; }
+        public IDictionary<XName, InstanceValue> InstanceOwnerMetadata { get; internal set; }
+        public InstanceValueConsistency InstanceOwnerMetadataConsistency { get; internal set; }
+        public InstanceState InstanceState { get; internal set; }
+        public ReadOnlyCollection<InstanceStoreQueryResult> InstanceStoreQueryResults { get; internal set; }
+        public bool IsBoundToInstance { get; private set; }
+        public bool IsBoundToInstanceOwner { get; }
+        public bool IsBoundToLock { get; }
+    }
+}
```

