# System.IO.IsolatedStorage

``` diff
 namespace System.IO.IsolatedStorage {
     public abstract class IsolatedStorage : MarshalByRefObject {
+        protected IsolatedStorage();
     }
     public sealed class IsolatedStorageFile : IsolatedStorage, IDisposable {
+        ~IsolatedStorageFile();
     }
 }
```

