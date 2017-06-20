# Microsoft.Activities.Build

``` diff
+namespace Microsoft.Activities.Build {
+    public sealed class WorkflowBuildMessageTask : Task {
+        public WorkflowBuildMessageTask();
+        public string MessageType { get; set; }
+        public string ResourceName { get; set; }
+        public override bool Execute();
+    }
+}
```

