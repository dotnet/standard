# System.Runtime.InteropServices.WindowsRuntime

``` diff
+namespace System.Runtime.InteropServices.WindowsRuntime {
+    public sealed class DefaultInterfaceAttribute : Attribute {
+        public DefaultInterfaceAttribute(Type defaultInterface);
+        public Type DefaultInterface { get; }
+    }
+    public class DesignerNamespaceResolveEventArgs : EventArgs {
+        public DesignerNamespaceResolveEventArgs(string namespaceName);
+        public string NamespaceName { get; }
+        public Collection<string> ResolvedAssemblyFiles { get; }
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct EventRegistrationToken {
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public static bool operator ==(EventRegistrationToken left, EventRegistrationToken right);
+        public static bool operator !=(EventRegistrationToken left, EventRegistrationToken right);
+    }
+    public sealed class EventRegistrationTokenTable<T> where T : class {
+        public EventRegistrationTokenTable();
+        public T InvocationList { get; set; }
+        public EventRegistrationToken AddEventHandler(T handler);
+        public static EventRegistrationTokenTable<T> GetOrCreateEventRegistrationTokenTable(ref EventRegistrationTokenTable<T> refEventTable);
+        public void RemoveEventHandler(EventRegistrationToken token);
+        public void RemoveEventHandler(T handler);
+    }
+    public interface IActivationFactory {
+        object ActivateInstance();
+    }
+    public sealed class InterfaceImplementedInVersionAttribute : Attribute {
+        public InterfaceImplementedInVersionAttribute(Type interfaceType, byte majorVersion, byte minorVersion, byte buildVersion, byte revisionVersion);
+        public byte BuildVersion { get; }
+        public Type InterfaceType { get; }
+        public byte MajorVersion { get; }
+        public byte MinorVersion { get; }
+        public byte RevisionVersion { get; }
+    }
+    public class NamespaceResolveEventArgs : EventArgs {
+        public NamespaceResolveEventArgs(string namespaceName, Assembly requestingAssembly);
+        public string NamespaceName { get; }
+        public Assembly RequestingAssembly { get; }
+        public Collection<Assembly> ResolvedAssemblies { get; }
+    }
+    public sealed class ReadOnlyArrayAttribute : Attribute {
+        public ReadOnlyArrayAttribute();
+    }
+    public sealed class ReturnValueNameAttribute : Attribute {
+        public ReturnValueNameAttribute(string name);
+        public string Name { get; }
+    }
+    public static class WindowsRuntimeMarshal {
+        public static void AddEventHandler<T>(Func<T, EventRegistrationToken> addMethod, Action<EventRegistrationToken> removeMethod, T handler);
+        public static void FreeHString(IntPtr ptr);
+        public static IActivationFactory GetActivationFactory(Type type);
+        public static string PtrToStringHString(IntPtr ptr);
+        public static void RemoveAllEventHandlers(Action<EventRegistrationToken> removeMethod);
+        public static void RemoveEventHandler<T>(Action<EventRegistrationToken> removeMethod, T handler);
+        public static IntPtr StringToHString(string s);
+    }
+    public static class WindowsRuntimeMetadata {
+        public static event EventHandler<DesignerNamespaceResolveEventArgs> DesignerNamespaceResolve;
+        public static event EventHandler<NamespaceResolveEventArgs> ReflectionOnlyNamespaceResolve;
+        public static IEnumerable<string> ResolveNamespace(string namespaceName, IEnumerable<string> packageGraphFilePaths);
+        public static IEnumerable<string> ResolveNamespace(string namespaceName, string windowsSdkFilePath, IEnumerable<string> packageGraphFilePaths);
+    }
+    public sealed class WriteOnlyArrayAttribute : Attribute {
+        public WriteOnlyArrayAttribute();
+    }
+}
```

