# System.ServiceModel.Activities.Activation

``` diff
+namespace System.ServiceModel.Activities.Activation {
+    public class WorkflowServiceHostFactory : ServiceHostFactoryBase {
+        public WorkflowServiceHostFactory();
+        public override ServiceHostBase CreateServiceHost(string constructorString, Uri[] baseAddresses);
+        protected virtual WorkflowServiceHost CreateWorkflowServiceHost(Activity activity, Uri[] baseAddresses);
+        protected virtual WorkflowServiceHost CreateWorkflowServiceHost(WorkflowService service, Uri[] baseAddresses);
+    }
+}
```

