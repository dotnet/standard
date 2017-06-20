# System.Threading

``` diff
 namespace System.Threading {
     public class EventWaitHandle : WaitHandle {
+        public EventWaitHandle(bool initialState, EventResetMode mode, string name, out bool createdNew, EventWaitHandleSecurity eventSecurity);
+        public EventWaitHandleSecurity GetAccessControl();
+        public static EventWaitHandle OpenExisting(string name, EventWaitHandleRights rights);
+        public void SetAccessControl(EventWaitHandleSecurity eventSecurity);
+        public static bool TryOpenExisting(string name, EventWaitHandleRights rights, out EventWaitHandle result);
     }
     public sealed class Mutex : WaitHandle {
+        public Mutex(bool initiallyOwned, string name, out bool createdNew, MutexSecurity mutexSecurity);
+        public MutexSecurity GetAccessControl();
+        public static Mutex OpenExisting(string name, MutexRights rights);
+        public void SetAccessControl(MutexSecurity mutexSecurity);
+        public static bool TryOpenExisting(string name, MutexRights rights, out Mutex result);
     }
-    public sealed class PreAllocatedOverlapped : IDisposable {
 {
-        public PreAllocatedOverlapped(IOCompletionCallback callback, object state, object pinData);

-        public void Dispose();

-    }
     public sealed class ReaderWriterLock : CriticalFinalizerObject {
+        ~ReaderWriterLock();
     }
     public sealed class Semaphore : WaitHandle {
+        public Semaphore(int initialCount, int maximumCount, string name, out bool createdNew, SemaphoreSecurity semaphoreSecurity);
+        public SemaphoreSecurity GetAccessControl();
+        public static Semaphore OpenExisting(string name, SemaphoreRights rights);
+        public void SetAccessControl(SemaphoreSecurity semaphoreSecurity);
+        public static bool TryOpenExisting(string name, SemaphoreRights rights, out Semaphore result);
     }
-    public sealed class Thread : CriticalFinalizerObject {
+    public sealed class Thread : CriticalFinalizerObject, _Thread {
+        public static Context CurrentContext { get; }
+        ~Thread();
+        void System.Runtime.InteropServices._Thread.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void System.Runtime.InteropServices._Thread.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void System.Runtime.InteropServices._Thread.GetTypeInfoCount(out uint pcTInfo);
+        void System.Runtime.InteropServices._Thread.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
     }
-    public sealed class ThreadPoolBoundHandle : IDisposable {
 {
-        public SafeHandle Handle { get; }

-        public unsafe NativeOverlapped* AllocateNativeOverlapped(IOCompletionCallback callback, object state, object pinData);

-        public unsafe NativeOverlapped* AllocateNativeOverlapped(PreAllocatedOverlapped preAllocated);

-        public static ThreadPoolBoundHandle BindHandle(SafeHandle handle);

-        public void Dispose();

-        public unsafe void FreeNativeOverlapped(NativeOverlapped* overlapped);

-        public unsafe static object GetNativeOverlappedState(NativeOverlapped* overlapped);

-    }
 }
```

