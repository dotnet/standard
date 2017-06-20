# System.AddIn.Hosting

``` diff
+namespace System.AddIn.Hosting {
+    public sealed class AddInController {
+        public AddInEnvironment AddInEnvironment { get; }
+        public AppDomain AppDomain { get; }
+        public AddInToken Token { get; }
+        public static AddInController GetAddInController(object addIn);
+        public void Shutdown();
+    }
+    public sealed class AddInEnvironment {
+        public AddInEnvironment(AppDomain appDomain);
+        public AddInProcess Process { get; }
+    }
+    public sealed class AddInProcess {
+        public AddInProcess();
+        public AddInProcess(Platform platform);
+        public bool IsCurrentProcess { get; }
+        public bool KeepAlive { get; set; }
+        public Platform Platform { get; }
+        public int ProcessId { get; }
+        public TimeSpan StartupTimeout { get; set; }
+        public event EventHandler<CancelEventArgs> ShuttingDown;
+        public bool Shutdown();
+        public bool Start();
+    }
+    public enum AddInSecurityLevel {
+        FullTrust = 2,
+        Host = 3,
+        Internet = 0,
+        Intranet = 1,
+    }
+    public class AddInSegmentDirectoryNotFoundException : Exception {
+        public AddInSegmentDirectoryNotFoundException();
+        protected AddInSegmentDirectoryNotFoundException(SerializationInfo info, StreamingContext context);
+        public AddInSegmentDirectoryNotFoundException(string message);
+        public AddInSegmentDirectoryNotFoundException(string message, Exception innerException);
+    }
+    public enum AddInSegmentType {
+        AddIn = 5,
+        AddInSideAdapter = 3,
+        AddInView = 4,
+        Contract = 2,
+        HostSideAdapter = 1,
+        HostViewOfAddIn = 0,
+    }
+    public static class AddInStore {
+        public static Collection<AddInToken> FindAddIn(Type hostViewOfAddIn, string pipelineRootFolderPath, string addInFilePath, string addInTypeName);
+        public static Collection<AddInToken> FindAddIns(Type hostViewOfAddIn, PipelineStoreLocation location);
+        public static Collection<AddInToken> FindAddIns(Type hostViewOfAddIn, PipelineStoreLocation location, params string[] addInFolderPaths);
+        public static Collection<AddInToken> FindAddIns(Type hostViewOfAddIn, string pipelineRootFolderPath, params string[] addInFolderPaths);
+        public static string[] Rebuild(PipelineStoreLocation location);
+        public static string[] Rebuild(string pipelineRootFolderPath);
+        public static string[] RebuildAddIns(string addInsFolderPath);
+        public static string[] Update(PipelineStoreLocation location);
+        public static string[] Update(string pipelineRootFolderPath);
+        public static string[] UpdateAddIns(string addInsFolderPath);
+    }
+    public sealed class AddInToken : IEnumerable, IEnumerable<QualificationDataItem> {
+        public string AddInFullName { get; }
+        public AssemblyName AssemblyName { get; }
+        public string Description { get; }
+        public static bool EnableDirectConnect { get; set; }
+        public string Name { get; }
+        public string Publisher { get; }
+        public IDictionary<AddInSegmentType, IDictionary<string, string>> QualificationData { get; }
+        public string Version { get; }
+        public T Activate<T>(AddInEnvironment environment);
+        public T Activate<T>(AddInProcess process, AddInSecurityLevel level);
+        public T Activate<T>(AddInProcess process, PermissionSet permissionSet);
+        public T Activate<T>(AddInSecurityLevel trustLevel);
+        public T Activate<T>(AddInSecurityLevel trustLevel, string appDomainName);
+        public T Activate<T>(AppDomain target);
+        public T Activate<T>(PermissionSet permissions);
+        public override bool Equals(object obj);
+        public IEnumerator<QualificationDataItem> GetEnumerator();
+        public override int GetHashCode();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        public override string ToString();
+    }
+    public class InvalidPipelineStoreException : Exception {
+        public InvalidPipelineStoreException();
+        protected InvalidPipelineStoreException(SerializationInfo info, StreamingContext context);
+        public InvalidPipelineStoreException(string message);
+        public InvalidPipelineStoreException(string message, Exception innerException);
+    }
+    public enum PipelineStoreLocation {
+        ApplicationBase = 0,
+    }
+    public enum Platform {
+        AnyCpu = 1,
+        ARM = 4,
+        Host = 0,
+        X64 = 3,
+        X86 = 2,
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct QualificationDataItem {
+        public string Name { get; }
+        public AddInSegmentType Segment { get; }
+        public string Value { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public static bool operator ==(QualificationDataItem item1, QualificationDataItem item2);
+        public static bool operator !=(QualificationDataItem item1, QualificationDataItem item2);
+    }
+}
```

