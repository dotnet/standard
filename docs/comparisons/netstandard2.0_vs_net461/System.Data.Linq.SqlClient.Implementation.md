# System.Data.Linq.SqlClient.Implementation

``` diff
+namespace System.Data.Linq.SqlClient.Implementation {
+    public abstract class ObjectMaterializer<TDataReader> where TDataReader : DbDataReader {
+        public DbDataReader BufferReader;
+        public int[] Ordinals;
+        public object[] Arguments;
+        public object[] Globals;
+        public object[] Locals;
+        public TDataReader DataReader;
+        public ObjectMaterializer();
+        public abstract bool CanDeferLoad { get; }
+        public static IEnumerable<TOutput> Convert<TOutput>(IEnumerable source);
+        public static IGrouping<TKey, TElement> CreateGroup<TKey, TElement>(TKey key, IEnumerable<TElement> items);
+        public static IOrderedEnumerable<TElement> CreateOrderedEnumerable<TElement>(IEnumerable<TElement> items);
+        public static Exception ErrorAssignmentToNull(Type type);
+        public abstract IEnumerable ExecuteSubQuery(int iSubQuery, object[] args);
+        public abstract IEnumerable<T> GetLinkSource<T>(int globalLink, int localFactory, object[] keyValues);
+        public abstract IEnumerable<T> GetNestedLinkSource<T>(int globalLink, int localFactory, object instance);
+        public abstract object InsertLookup(int globalMetaType, object instance);
+        public abstract bool Read();
+        public abstract void SendEntityMaterialized(int globalMetaType, object instance);
+    }
+}
```

