# System.IO.IsolatedStorage

``` diff
 namespace System.IO.IsolatedStorage {
     public abstract class IsolatedStorage : MarshalByRefObject {
+        protected IsolatedStorage();
+        protected abstract IsolatedStoragePermission GetPermission(PermissionSet ps);
     }
     public sealed class IsolatedStorageFile : IsolatedStorage, IDisposable {
+        ~IsolatedStorageFile();
+        protected override IsolatedStoragePermission GetPermission(PermissionSet ps);
+        public static IsolatedStorageFile GetStore(IsolatedStorageScope scope, Evidence domainEvidence, Type domainEvidenceType, Evidence assemblyEvidence, Type assemblyEvidenceType);
     }
+    public enum IsolatedStorageSecurityOptions {
+        IncreaseQuotaForApplication = 4,
+    }
+    public class IsolatedStorageSecurityState : SecurityState {
+        public IsolatedStorageSecurityOptions Options { get; }
+        public long Quota { get; set; }
+        public long UsedSize { get; }
+        public override void EnsureState();
+    }
 }
```

