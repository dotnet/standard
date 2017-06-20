# System.Configuration.Provider

``` diff
+namespace System.Configuration.Provider {
+    public abstract class ProviderBase {
+        protected ProviderBase();
+        public virtual string Description { get; }
+        public virtual string Name { get; }
+        public virtual void Initialize(string name, NameValueCollection config);
+    }
+    public class ProviderCollection : ICollection, IEnumerable {
+        public ProviderCollection();
+        public int Count { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        public ProviderBase this[string name] { get; }
+        public virtual void Add(ProviderBase provider);
+        public void Clear();
+        public void CopyTo(ProviderBase[] array, int index);
+        public IEnumerator GetEnumerator();
+        public void Remove(string name);
+        public void SetReadOnly();
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+    }
+    public class ProviderException : Exception {
+        public ProviderException();
+        protected ProviderException(SerializationInfo info, StreamingContext context);
+        public ProviderException(string message);
+        public ProviderException(string message, Exception innerException);
+    }
+}
```

