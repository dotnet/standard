# System.AddIn

``` diff
+namespace System.AddIn {
+    public sealed class AddInAttribute : Attribute {
+        public AddInAttribute(string name);
+        public string Description { get; set; }
+        public string Name { get; }
+        public string Publisher { get; set; }
+        public string Version { get; set; }
+    }
+}
```

