# System.Windows.Diagnostics

``` diff
+namespace System.Windows.Diagnostics {
+    public static class VisualDiagnostics {
+        public static event EventHandler<VisualTreeChangeEventArgs> VisualTreeChanged;
+        public static XamlSourceInfo GetXamlSourceInfo(object obj);
+    }
+    public class VisualTreeChangeEventArgs : EventArgs {
+        public VisualTreeChangeEventArgs(DependencyObject parent, DependencyObject child, int childIndex, VisualTreeChangeType changeType);
+        public VisualTreeChangeType ChangeType { get; private set; }
+        public DependencyObject Child { get; private set; }
+        public int ChildIndex { get; private set; }
+        public DependencyObject Parent { get; private set; }
+    }
+    public enum VisualTreeChangeType {
+        Add = 0,
+        Remove = 1,
+    }
+    public class XamlSourceInfo {
+        public XamlSourceInfo(Uri sourceUri, int lineNumber, int linePosition);
+        public int LineNumber { get; private set; }
+        public int LinePosition { get; private set; }
+        public Uri SourceUri { get; private set; }
+    }
+}
```

