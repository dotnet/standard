# System.ServiceModel.Activities.Description

``` diff
+namespace System.ServiceModel.Activities.Description {
+    public sealed class BufferedReceiveServiceBehavior : IServiceBehavior {
+        public BufferedReceiveServiceBehavior();
+        public int MaxPendingMessagesPerChannel { get; set; }
+        public void AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection bindingParameters);
+        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase);
+        public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase);
+    }
+    public class EtwTrackingBehavior : IServiceBehavior {
+        public EtwTrackingBehavior();
+        public string ProfileName { get; set; }
+        public virtual void AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection bindingParameters);
+        public virtual void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase);
+        public virtual void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase);
+    }
+    public class SqlWorkflowInstanceStoreBehavior : IServiceBehavior {
+        public SqlWorkflowInstanceStoreBehavior();
+        public SqlWorkflowInstanceStoreBehavior(string connectionString);
+        public string ConnectionString { get; set; }
+        public TimeSpan HostLockRenewalPeriod { get; set; }
+        public InstanceCompletionAction InstanceCompletionAction { get; set; }
+        public InstanceEncodingOption InstanceEncodingOption { get; set; }
+        public InstanceLockedExceptionAction InstanceLockedExceptionAction { get; set; }
+        public int MaxConnectionRetries { get; set; }
+        public TimeSpan RunnableInstancesDetectionPeriod { get; set; }
+        public void AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection bindingParameters);
+        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase);
+        public void Promote(string name, IEnumerable<XName> promoteAsSqlVariant, IEnumerable<XName> promoteAsBinary);
+        public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase);
+    }
+    public sealed class WorkflowContractBehaviorAttribute : Attribute, IContractBehavior {
+        public WorkflowContractBehaviorAttribute();
+        public void AddBindingParameters(ContractDescription contractDescription, ServiceEndpoint endpoint, BindingParameterCollection bindingParameters);
+        public void ApplyClientBehavior(ContractDescription contractDescription, ServiceEndpoint endpoint, ClientRuntime clientRuntime);
+        public void ApplyDispatchBehavior(ContractDescription contractDescription, ServiceEndpoint endpoint, DispatchRuntime dispatchRuntime);
+        public void Validate(ContractDescription contractDescription, ServiceEndpoint endpoint);
+    }
+    public class WorkflowIdleBehavior : IServiceBehavior {
+        public WorkflowIdleBehavior();
+        public TimeSpan TimeToPersist { get; set; }
+        public TimeSpan TimeToUnload { get; set; }
+        public void AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection bindingParameters);
+        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase);
+        public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase);
+    }
+    public sealed class WorkflowInstanceManagementBehavior : IServiceBehavior {
+        public const string ControlEndpointAddress = "System.ServiceModel.Activities_IWorkflowInstanceManagement";
+        public WorkflowInstanceManagementBehavior();
+        public static Binding HttpControlEndpointBinding { get; }
+        public static Binding NamedPipeControlEndpointBinding { get; }
+        public string WindowsGroup { get; set; }
+        public void AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection bindingParameters);
+        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase);
+        public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase);
+    }
+    public class WorkflowRuntimeEndpoint : WorkflowHostingEndpoint {
+        public WorkflowRuntimeEndpoint();
+        public void AddService(object service);
+        public object GetService(Type serviceType);
+        public T GetService<T>();
+        protected override Guid OnGetInstanceId(object[] inputs, OperationContext operationContext);
+        protected override Bookmark OnResolveBookmark(object[] inputs, OperationContext operationContext, WorkflowHostingResponseContext responseContext, out object value);
+        public void RemoveService(object service);
+    }
+    public enum WorkflowUnhandledExceptionAction {
+        Abandon = 0,
+        AbandonAndSuspend = 3,
+        Cancel = 1,
+        Terminate = 2,
+    }
+    public class WorkflowUnhandledExceptionBehavior : IServiceBehavior {
+        public WorkflowUnhandledExceptionBehavior();
+        public WorkflowUnhandledExceptionAction Action { get; set; }
+        public void AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection bindingParameters);
+        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase);
+        public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase);
+    }
+}
```

