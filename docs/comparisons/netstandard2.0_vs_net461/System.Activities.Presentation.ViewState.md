# System.Activities.Presentation.ViewState

``` diff
+namespace System.Activities.Presentation.ViewState {
+    public sealed class ViewStateData {
+        public ViewStateData();
+        public string Id { get; set; }
+    }
+    public sealed class ViewStateManager {
+        public ViewStateManager();
+        public Collection<ViewStateData> ViewStateData { get; }
+    }
+    public static class WorkflowViewState {
+        public static readonly AttachableMemberIdentifier IdRefProperty;
+        public static readonly AttachableMemberIdentifier ViewStateManagerProperty;
+        public static string GetIdRef(object instance);
+        public static ViewStateManager GetViewStateManager(object instance);
+        public static void SetIdRef(object instance, string idRef);
+        public static void SetViewStateManager(object instance, ViewStateManager viewStateManager);
+    }
+}
```

