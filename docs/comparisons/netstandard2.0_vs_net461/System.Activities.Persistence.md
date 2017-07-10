# System.Activities.Persistence

``` diff
+namespace System.Activities.Persistence {
+    public abstract class PersistenceIOParticipant : PersistenceParticipant {
+        protected PersistenceIOParticipant(bool isSaveTransactionRequired, bool isLoadTransactionRequired);
+        protected abstract void Abort();
+        protected virtual IAsyncResult BeginOnLoad(IDictionary<XName, object> readWriteValues, TimeSpan timeout, AsyncCallback callback, object state);
+        protected virtual IAsyncResult BeginOnSave(IDictionary<XName, object> readWriteValues, IDictionary<XName, object> writeOnlyValues, TimeSpan timeout, AsyncCallback callback, object state);
+        protected virtual void EndOnLoad(IAsyncResult result);
+        protected virtual void EndOnSave(IAsyncResult result);
+    }
+    public abstract class PersistenceParticipant : IPersistencePipelineModule {
+        protected PersistenceParticipant();
+        protected virtual void CollectValues(out IDictionary<XName, object> readWriteValues, out IDictionary<XName, object> writeOnlyValues);
+        protected virtual IDictionary<XName, object> MapValues(IDictionary<XName, object> readWriteValues, IDictionary<XName, object> writeOnlyValues);
+        protected virtual void PublishValues(IDictionary<XName, object> readWriteValues);
+    }
+}
```

