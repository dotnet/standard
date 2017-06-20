# System.Web.Query.Dynamic

``` diff
+namespace System.Web.Query.Dynamic {
+    public abstract class DynamicClass {
+        protected DynamicClass();
+        public override string ToString();
+    }
+    public class ParseException : Exception {
+        public ParseException(string message, int position);
+        public int Position { get; }
+        public override string ToString();
+    }
+}
```

