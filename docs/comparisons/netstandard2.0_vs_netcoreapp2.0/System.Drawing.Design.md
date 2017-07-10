# System.Drawing.Design

``` diff
+namespace System.Drawing.Design {
+    public sealed class CategoryNameCollection : ReadOnlyCollectionBase {
+        public CategoryNameCollection(CategoryNameCollection value);
+        public CategoryNameCollection(string[] value);
+        public string this[int index] { get; }
+        public bool Contains(string value);
+        public void CopyTo(string[] array, int index);
+        public int IndexOf(string value);
+    }
+}
```

