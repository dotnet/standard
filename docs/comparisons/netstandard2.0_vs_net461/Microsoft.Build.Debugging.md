# Microsoft.Build.Debugging

``` diff
+namespace Microsoft.Build.Debugging {
+    public static class DebuggerManager {
+        public sealed class IslandThread : IDisposable {
+            public static void IslandWorker(DebuggerManager.IslandThread controller);
+            void System.IDisposable.Dispose();
+        }
+    }
+}
```

