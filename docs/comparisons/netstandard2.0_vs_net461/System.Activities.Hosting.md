# System.Activities.Hosting

``` diff
+namespace System.Activities.Hosting {
+    public sealed class BookmarkInfo {
+        public string BookmarkName { get; private set; }
+        public string OwnerDisplayName { get; private set; }
+        public BookmarkScopeInfo ScopeInfo { get; private set; }
+    }
+    public sealed class BookmarkScopeInfo {
+        public Guid Id { get; private set; }
+        public bool IsInitialized { get; }
+        public string TemporaryId { get; private set; }
+    }
+    public interface IWorkflowInstanceExtension {
+        IEnumerable<object> GetAdditionalExtensions();
+        void SetInstance(WorkflowInstanceProxy instance);
+    }
+    public sealed class LocationInfo {
+        public string Name { get; private set; }
+        public string OwnerDisplayName { get; private set; }
+        public object Value { get; private set; }
+    }
+    public sealed class SymbolResolver : ICollection<KeyValuePair<string, object>>, IDictionary<string, object>, IEnumerable, IEnumerable<KeyValuePair<string, object>> {
+        public SymbolResolver();
+        public int Count { get; }
+        public bool IsReadOnly { get; }
+        public ICollection<string> Keys { get; }
+        public object this[string key] { get; set; }
+        public ICollection<object> Values { get; }
+        public void Add(KeyValuePair<string, object> item);
+        public void Add(string key, object value);
+        public void Add(string key, object value, Type type);
+        public void Add(string key, Type type);
+        public LocationReferenceEnvironment AsLocationReferenceEnvironment();
+        public void Clear();
+        public bool Contains(KeyValuePair<string, object> item);
+        public bool ContainsKey(string key);
+        public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex);
+        public IEnumerator<KeyValuePair<string, object>> GetEnumerator();
+        public bool Remove(KeyValuePair<string, object> item);
+        public bool Remove(string key);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        public bool TryGetValue(string key, out object value);
+    }
+    public abstract class WorkflowInstance {
+        protected WorkflowInstance(Activity workflowDefinition);
+        protected WorkflowInstance(Activity workflowDefinition, WorkflowIdentity definitionIdentity);
+        protected WorkflowInstance.WorkflowInstanceControl Controller { get; }
+        public WorkflowIdentity DefinitionIdentity { get; private set; }
+        public LocationReferenceEnvironment HostEnvironment { get; set; }
+        public abstract Guid Id { get; }
+        protected bool IsReadOnly { get; }
+        protected internal abstract bool SupportsInstanceKeys { get; }
+        public SynchronizationContext SynchronizationContext { get; set; }
+        public Activity WorkflowDefinition { get; private set; }
+        protected IAsyncResult BeginFlushTrackingRecords(TimeSpan timeout, AsyncCallback callback, object state);
+        protected void DisposeExtensions();
+        protected void EndFlushTrackingRecords(IAsyncResult result);
+        protected void FlushTrackingRecords(TimeSpan timeout);
+        protected static IList<ActivityBlockingUpdate> GetActivitiesBlockingUpdate(object deserializedRuntimeState, DynamicUpdateMap updateMap);
+        protected internal T GetExtension<T>() where T : class;
+        protected internal IEnumerable<T> GetExtensions<T>() where T : class;
+        protected void Initialize(IDictionary<string, object> workflowArgumentValues, IList<Handle> workflowExecutionProperties);
+        protected void Initialize(object deserializedRuntimeState);
+        protected void Initialize(object deserializedRuntimeState, DynamicUpdateMap updateMap);
+        protected internal abstract IAsyncResult OnBeginAssociateKeys(ICollection<InstanceKey> keys, AsyncCallback callback, object state);
+        protected virtual IAsyncResult OnBeginFlushTrackingRecords(AsyncCallback callback, object state);
+        protected internal abstract IAsyncResult OnBeginPersist(AsyncCallback callback, object state);
+        protected internal abstract IAsyncResult OnBeginResumeBookmark(Bookmark bookmark, object value, TimeSpan timeout, AsyncCallback callback, object state);
+        protected internal abstract void OnDisassociateKeys(ICollection<InstanceKey> keys);
+        protected internal abstract void OnEndAssociateKeys(IAsyncResult result);
+        protected virtual void OnEndFlushTrackingRecords(IAsyncResult result);
+        protected internal abstract void OnEndPersist(IAsyncResult result);
+        protected internal abstract BookmarkResumptionResult OnEndResumeBookmark(IAsyncResult result);
+        protected abstract void OnNotifyPaused();
+        protected abstract void OnNotifyUnhandledException(Exception exception, Activity source, string sourceInstanceId);
+        protected internal abstract void OnRequestAbort(Exception reason);
+        protected void RegisterExtensionManager(WorkflowInstanceExtensionManager extensionManager);
+        protected void ThrowIfReadOnly();
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        protected struct WorkflowInstanceControl {
+            public bool HasPendingTrackingRecords { get; }
+            public bool IsPersistable { get; }
+            public WorkflowInstanceState State { get; }
+            public bool TrackingEnabled { get; }
+            public void Abort();
+            public void Abort(Exception reason);
+            public IAsyncResult BeginFlushTrackingRecords(TimeSpan timeout, AsyncCallback callback, object state);
+            public void EndFlushTrackingRecords(IAsyncResult result);
+            public override bool Equals(object obj);
+            public void FlushTrackingRecords(TimeSpan timeout);
+            public Exception GetAbortReason();
+            public ReadOnlyCollection<BookmarkInfo> GetBookmarks();
+            public ReadOnlyCollection<BookmarkInfo> GetBookmarks(BookmarkScope scope);
+            public ActivityInstanceState GetCompletionState();
+            public ActivityInstanceState GetCompletionState(out IDictionary<string, object> outputs, out Exception terminationException);
+            public ActivityInstanceState GetCompletionState(out Exception terminationException);
+            public override int GetHashCode();
+            public IDictionary<string, LocationInfo> GetMappedVariables();
+            public static bool operator ==(WorkflowInstance.WorkflowInstanceControl left, WorkflowInstance.WorkflowInstanceControl right);
+            public static bool operator !=(WorkflowInstance.WorkflowInstanceControl left, WorkflowInstance.WorkflowInstanceControl right);
+            public void PauseWhenPersistable();
+            public object PrepareForSerialization();
+            public void RequestPause();
+            public void Run();
+            public BookmarkResumptionResult ScheduleBookmarkResumption(Bookmark bookmark, object value);
+            public BookmarkResumptionResult ScheduleBookmarkResumption(Bookmark bookmark, object value, BookmarkScope scope);
+            public void ScheduleCancel();
+            public void Terminate(Exception reason);
+            public void Track(WorkflowInstanceRecord instanceRecord);
+        }
+    }
+    public class WorkflowInstanceExtensionManager {
+        public WorkflowInstanceExtensionManager();
+        public virtual void Add(object singletonExtension);
+        public virtual void Add<T>(Func<T> extensionCreationFunction) where T : class;
+        public void MakeReadOnly();
+    }
+    public sealed class WorkflowInstanceProxy {
+        public Guid Id { get; }
+        public Activity WorkflowDefinition { get; }
+        public IAsyncResult BeginResumeBookmark(Bookmark bookmark, object value, AsyncCallback callback, object state);
+        public IAsyncResult BeginResumeBookmark(Bookmark bookmark, object value, TimeSpan timeout, AsyncCallback callback, object state);
+        public BookmarkResumptionResult EndResumeBookmark(IAsyncResult result);
+    }
+    public enum WorkflowInstanceState {
+        Aborted = 3,
+        Complete = 2,
+        Idle = 0,
+        Runnable = 1,
+    }
+}
```

