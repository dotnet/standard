# Microsoft.Activities.Build.Validation

``` diff
+namespace Microsoft.Activities.Build.Validation {
+    public class DeferredValidationTask : Task {
+        public DeferredValidationTask();
+        public string DeferredValidationErrorsFilePath { get; set; }
+        public override bool Execute();
+    }
+    public class ReportDeferredValidationErrorsTask : Task {
+        public ReportDeferredValidationErrorsTask();
+        public string DeferredValidationErrorsFilePath { get; set; }
+        public override bool Execute();
+    }
+}
```

