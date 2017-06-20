# System.Workflow.Runtime.DebugEngine

``` diff
+namespace System.Workflow.Runtime.DebugEngine {
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct ActivityHandlerDescriptor {
+        public int Token;
+        public string Name;
+    }
+    public sealed class DebugController : MarshalByRefObject {
+        public void AttachToConduit(Uri url);
+        public override object InitializeLifetimeService();
+    }
+    public delegate void DebugEngineCallback();
+    public interface IExpressionEvaluationFrame {
+        void CreateEvaluationFrame(IInstanceTable instanceTable, DebugEngineCallback callback);
+    }
+    public interface IInstanceTable {
+        Activity GetActivity(string instanceId, string activityName);
+    }
+    public interface IWorkflowDebugger {
+        void ActivityStatusChanged(Guid programId, Guid scheduleTypeId, Guid instanceId, string activityQualifiedName, string hierarchicalActivityId, ActivityExecutionStatus status, int stateReaderId);
+        void AssemblyLoaded(Guid programId, string assemblyPath, bool fromGlobalAssemblyCache);
+        void BeforeActivityStatusChanged(Guid programId, Guid scheduleTypeId, Guid instanceId, string activityQualifiedName, string hierarchicalActivityId, ActivityExecutionStatus status, int stateReaderId);
+        void BeforeHandlerInvoked(Guid programId, Guid scheduleTypeId, string activityQualifiedName, ActivityHandlerDescriptor handlerMethod);
+        void HandlerInvoked(Guid programId, Guid instanceId, int threadId, string activityQualifiedName);
+        void InstanceCompleted(Guid programId, Guid instanceId);
+        void InstanceCreated(Guid programId, Guid instanceId, Guid scheduleTypeId);
+        void InstanceDynamicallyUpdated(Guid programId, Guid instanceId, Guid scheduleTypeId);
+        void ScheduleTypeLoaded(Guid programId, Guid scheduleTypeId, string assemblyFullName, string fileName, string md5Digest, bool isDynamic, string scheduleNamespace, string scheduleName, string workflowMarkup);
+        void SetInitialActivityStatus(Guid programId, Guid scheduleTypeId, Guid instanceId, string activityQualifiedName, string hierarchicalActivityId, ActivityExecutionStatus status, int stateReaderId);
+        void UpdateHandlerMethodsForActivity(Guid programId, Guid scheduleTypeId, string activityQualifiedName, List<ActivityHandlerDescriptor> handlerMethods);
+    }
+    public interface IWorkflowDebuggerService {
+        void NotifyHandlerInvoked();
+        void NotifyHandlerInvoking(Delegate delegateHandler);
+    }
+    public sealed class WorkflowDebuggerSteppingAttribute : Attribute {
+        public WorkflowDebuggerSteppingAttribute(WorkflowDebuggerSteppingOption steppingOption);
+        public WorkflowDebuggerSteppingOption SteppingOption { get; }
+    }
+    public enum WorkflowDebuggerSteppingOption {
+        Concurrent = 1,
+        Sequential = 0,
+    }
+}
```

