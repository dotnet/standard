# System.Collections.Generic

``` diff
 namespace System.Collections.Generic {
+    public class KeyedByTypeCollection<TItem> : KeyedCollection<Type, TItem> {
+        public KeyedByTypeCollection();
+        public KeyedByTypeCollection(IEnumerable<TItem> items);
+        public T Find<T>();
+        public Collection<T> FindAll<T>();
+        protected override Type GetKeyForItem(TItem item);
+        protected override void InsertItem(int index, TItem item);
+        public T Remove<T>();
+        public Collection<T> RemoveAll<T>();
+        protected override void SetItem(int index, TItem item);
+    }
+    public class SynchronizedCollection<T> : ICollection, ICollection<T>, IEnumerable, IEnumerable<T>, IList, IList<T> {
+        public SynchronizedCollection();
+        public SynchronizedCollection(object syncRoot);
+        public SynchronizedCollection(object syncRoot, IEnumerable<T> list);
+        public SynchronizedCollection(object syncRoot, params T[] list);
+        public int Count { get; }
+        protected List<T> Items { get; }
+        public object SyncRoot { get; }
+        bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public T this[int index] { get; set; }
+        public void Add(T item);
+        public void Clear();
+        protected virtual void ClearItems();
+        public bool Contains(T item);
+        public void CopyTo(T[] array, int index);
+        public IEnumerator<T> GetEnumerator();
+        public int IndexOf(T item);
+        public void Insert(int index, T item);
+        protected virtual void InsertItem(int index, T item);
+        public bool Remove(T item);
+        public void RemoveAt(int index);
+        protected virtual void RemoveItem(int index);
+        protected virtual void SetItem(int index, T item);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+    }
+    public abstract class SynchronizedKeyedCollection<K, T> : SynchronizedCollection<T> {
+        protected SynchronizedKeyedCollection();
+        protected SynchronizedKeyedCollection(object syncRoot);
+        protected SynchronizedKeyedCollection(object syncRoot, IEqualityComparer<K> comparer);
+        protected SynchronizedKeyedCollection(object syncRoot, IEqualityComparer<K> comparer, int dictionaryCreationThreshold);
+        protected IDictionary<K, T> Dictionary { get; }
+        public T this[K key] { get; }
+        protected void ChangeItemKey(T item, K newKey);
+        protected override void ClearItems();
+        public bool Contains(K key);
+        protected abstract K GetKeyForItem(T item);
+        protected override void InsertItem(int index, T item);
+        public bool Remove(K key);
+        protected override void RemoveItem(int index);
+        protected override void SetItem(int index, T item);
+    }
+    public class SynchronizedReadOnlyCollection<T> : ICollection, ICollection<T>, IEnumerable, IEnumerable<T>, IList, IList<T> {
+        public SynchronizedReadOnlyCollection();
+        public SynchronizedReadOnlyCollection(object syncRoot);
+        public SynchronizedReadOnlyCollection(object syncRoot, IEnumerable<T> list);
+        public SynchronizedReadOnlyCollection(object syncRoot, params T[] list);
+        public int Count { get; }
+        protected IList<T> Items { get; }
+        bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
+        T System.Collections.Generic.IList<T>.this[int index] { get; set; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public T this[int index] { get; }
+        public bool Contains(T value);
+        public void CopyTo(T[] array, int index);
+        public IEnumerator<T> GetEnumerator();
+        public int IndexOf(T value);
+        void System.Collections.Generic.ICollection<T>.Add(T value);
+        void System.Collections.Generic.ICollection<T>.Clear();
+        bool System.Collections.Generic.ICollection<T>.Remove(T value);
+        void System.Collections.Generic.IList<T>.Insert(int index, T value);
+        void System.Collections.Generic.IList<T>.RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        void System.Collections.IList.Clear();
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        void System.Collections.IList.RemoveAt(int index);
+    }
 }
```

