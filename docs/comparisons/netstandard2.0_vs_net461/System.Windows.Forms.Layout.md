# System.Windows.Forms.Layout

``` diff
+namespace System.Windows.Forms.Layout {
+    public class ArrangedElementCollection : ICollection, IEnumerable, IList {
+        public virtual int Count { get; }
+        public virtual bool IsReadOnly { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public void CopyTo(Array array, int index);
+        public override bool Equals(object obj);
+        public virtual IEnumerator GetEnumerator();
+        public override int GetHashCode();
+        int System.Collections.IList.Add(object value);
+        void System.Collections.IList.Clear();
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        void System.Collections.IList.RemoveAt(int index);
+    }
+    public abstract class LayoutEngine {
+        protected LayoutEngine();
+        public virtual void InitLayout(object child, BoundsSpecified specified);
+        public virtual bool Layout(object container, LayoutEventArgs layoutEventArgs);
+    }
+    public class TableLayoutSettingsTypeConverter : TypeConverter {
+        public TableLayoutSettingsTypeConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+}
```

