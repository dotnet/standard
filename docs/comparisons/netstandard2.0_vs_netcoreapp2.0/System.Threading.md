# System.Threading

``` diff
 namespace System.Threading {
     public static class Interlocked {
+        public static void MemoryBarrierProcessWide();
     }
     public static class LazyInitializer {
+        public static T EnsureInitialized<T>(ref T target, ref object syncLock, Func<T> valueFactory) where T : class;
     }
     public sealed class ReaderWriterLock : CriticalFinalizerObject {
+        ~ReaderWriterLock();
     }
     public sealed class Thread : CriticalFinalizerObject {
+        ~Thread();
     }
+    public static class ThreadingAclExtensions {
+        public static EventWaitHandleSecurity GetAccessControl(this EventWaitHandle handle);
+        public static MutexSecurity GetAccessControl(this Mutex mutex);
+        public static SemaphoreSecurity GetAccessControl(this Semaphore semaphore);
+        public static void SetAccessControl(this EventWaitHandle handle, EventWaitHandleSecurity eventSecurity);
+        public static void SetAccessControl(this Mutex mutex, MutexSecurity mutexSecurity);
+        public static void SetAccessControl(this Semaphore semaphore, SemaphoreSecurity semaphoreSecurity);
+    }
 }
```

