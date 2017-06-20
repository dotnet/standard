# System.Runtime.DesignerServices

``` diff
+namespace System.Runtime.DesignerServices {
+    public sealed class WindowsRuntimeDesignerContext {
+        public WindowsRuntimeDesignerContext(IEnumerable<string> paths, string name);
+        public string Name { get; }
+        public Assembly GetAssembly(string assemblyName);
+        public Type GetType(string typeName);
+        public static void InitializeSharedContext(IEnumerable<string> paths);
+        public static void SetIterationContext(WindowsRuntimeDesignerContext context);
+    }
+}
```

