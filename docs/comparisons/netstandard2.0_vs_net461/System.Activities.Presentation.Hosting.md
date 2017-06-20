# System.Activities.Presentation.Hosting

``` diff
+namespace System.Activities.Presentation.Hosting {
+    public sealed class AssemblyContextControlItem : ContextItem {
+        public AssemblyContextControlItem();
+        public IEnumerable<string> AllAssemblyNamesInContext { get; }
+        public override Type ItemType { get; }
+        public AssemblyName LocalAssemblyName { get; set; }
+        public IList<AssemblyName> ReferencedAssemblyNames { get; set; }
+        public static Assembly GetAssembly(AssemblyName assemblyName, IMultiTargetingSupportService multiTargetingService);
+        public IEnumerable<Assembly> GetEnvironmentAssemblies(IMultiTargetingSupportService multiTargetingService);
+        public IEnumerable<AssemblyName> GetEnvironmentAssemblyNames();
+    }
+    public sealed class CommandInfo {
+        public ICommand Command { get; internal set; }
+        public bool IsBindingEnabledInDesigner { get; set; }
+    }
+    public static class CommandValues {
+        public const int DeleteBreakpoint = 7;
+        public const int DisableBreakpoint = 9;
+        public const int EnableBreakpoint = 8;
+        public const int InsertBreakpoint = 6;
+        public const int ShowProperties = 5;
+    }
+    public interface ICommandService {
+        bool CanExecuteCommand(int commandId);
+        void ExecuteCommand(int commandId, Dictionary<string, object> parameters);
+        bool IsCommandSupported(int commandId);
+    }
+    public interface IDocumentPersistenceService {
+        void Flush(object documentRoot);
+        object Load(string fileName);
+        void OnModelChanged(object documentRoot);
+    }
+    public sealed class ImportedNamespaceContextItem : ContextItem {
+        public ImportedNamespaceContextItem();
+        public Collection<string> ImportedNamespaces { get; }
+        public override Type ItemType { get; }
+        public void EnsureInitialized(EditingContext context);
+    }
+    public interface IMultiTargetingSupportService {
+        Assembly GetReflectionAssembly(AssemblyName targetAssemblyName);
+        Type GetRuntimeType(Type reflectionType);
+        bool IsSupportedType(Type type);
+    }
+    public interface IWorkflowCommandExtensionCallback {
+        void OnWorkflowCommandLoaded(CommandInfo commandInfo);
+    }
+    public abstract class MultiTargetingSupportService : IMultiTargetingSupportService {
+        protected MultiTargetingSupportService();
+        public abstract Assembly GetReflectionAssembly(AssemblyName targetAssemblyName);
+        public abstract Type GetReflectionType(Type objectType);
+        public abstract Type GetRuntimeType(Type reflectionType);
+        public abstract bool IsSupportedType(Type type);
+    }
+    public sealed class ReadOnlyState : ContextItem {
+        public ReadOnlyState();
+        public bool IsReadOnly { get; set; }
+        public override Type ItemType { get; }
+    }
+    public class WindowHelperService {
+        public WindowHelperService(IntPtr hwnd);
+        public IntPtr ParentWindowHwnd { get; private set; }
+        public bool RegisterWindowMessageHandler(WindowMessage callback);
+        public bool TrySetWindowOwner(DependencyObject source, Window target);
+        public bool UnregisterWindowMessageHandler(WindowMessage callback);
+    }
+    public delegate void WindowMessage(int msgId, IntPtr parameter1, IntPtr parameter2);
+    public sealed class WorkflowCommandExtensionItem : ContextItem {
+        public WorkflowCommandExtensionItem();
+        public WorkflowCommandExtensionItem(IWorkflowCommandExtensionCallback callback);
+        public override Type ItemType { get; }
+    }
+}
```

