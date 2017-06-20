# System.Threading

``` diff
 namespace System.Threading {
+    public unsafe delegate void IOCompletionCallback(uint errorCode, uint numBytes, NativeOverlapped* pOVERLAP);
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct NativeOverlapped {
+        public int OffsetHigh;
+        public int OffsetLow;
+        public IntPtr EventHandle;
+        public IntPtr InternalHigh;
+        public IntPtr InternalLow;
+    }
+    public delegate void ParameterizedThreadStart(object obj);
+    public sealed class PreAllocatedOverlapped : IDisposable {
+        public PreAllocatedOverlapped(IOCompletionCallback callback, object state, object pinData);
+        public void Dispose();
+    }
+    public sealed class RegisteredWaitHandle {
+        public bool Unregister(WaitHandle waitObject);
+    }
+    public sealed class Thread {
+        public Thread(ParameterizedThreadStart start);
+        public Thread(ThreadStart start);
+        public static Thread CurrentThread { get; }
+        public bool IsAlive { get; }
+        public bool IsBackground { get; set; }
+        public int ManagedThreadId { get; }
+        public string Name { get; set; }
+        public ThreadState ThreadState { get; }
+        public void Join();
+        public bool Join(int millisecondsTimeout);
+        public static void Sleep(int millisecondsTimeout);
+        public static void Sleep(TimeSpan timeout);
+        public void Start();
+        public void Start(object parameter);
+    }
+    public static class ThreadingAclExtensions {
+        public static EventWaitHandleSecurity GetAccessControl(this EventWaitHandle handle);
+        public static MutexSecurity GetAccessControl(this Mutex mutex);
+        public static SemaphoreSecurity GetAccessControl(this Semaphore semaphore);
+        public static void SetAccessControl(this EventWaitHandle handle, EventWaitHandleSecurity eventSecurity);
+        public static void SetAccessControl(this Mutex mutex, MutexSecurity mutexSecurity);
+        public static void SetAccessControl(this Semaphore semaphore, SemaphoreSecurity semaphoreSecurity);
+    }
+    public static class ThreadPool {
+        public static bool BindHandle(SafeHandle osHandle);
+        public static bool QueueUserWorkItem(WaitCallback callBack);
+        public static bool QueueUserWorkItem(WaitCallback callBack, object state);
+        public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, int millisecondsTimeOutInterval, bool executeOnlyOnce);
+        public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, long millisecondsTimeOutInterval, bool executeOnlyOnce);
+        public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, TimeSpan timeout, bool executeOnlyOnce);
+        public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce);
+    }
+    public sealed class ThreadPoolBoundHandle : IDisposable {
+        public SafeHandle Handle { get; }
+        public unsafe NativeOverlapped* AllocateNativeOverlapped(IOCompletionCallback callback, object state, object pinData);
+        public unsafe NativeOverlapped* AllocateNativeOverlapped(PreAllocatedOverlapped preAllocated);
+        public static ThreadPoolBoundHandle BindHandle(SafeHandle handle);
+        public void Dispose();
+        public unsafe void FreeNativeOverlapped(NativeOverlapped* overlapped);
+        public unsafe static object GetNativeOverlappedState(NativeOverlapped* overlapped);
+    }
+    public delegate void ThreadStart();
+    public sealed class ThreadStartException : Exception
+    public enum ThreadState {
+        Aborted = 256,
+        AbortRequested = 128,
+        Background = 4,
+        Running = 0,
+        Stopped = 16,
+        StopRequested = 1,
+        Suspended = 64,
+        SuspendRequested = 2,
+        Unstarted = 8,
+        WaitSleepJoin = 32,
+    }
+    public class ThreadStateException : Exception {
+        public ThreadStateException();
+        public ThreadStateException(string message);
+        public ThreadStateException(string message, Exception innerException);
+    }
+    public delegate void WaitCallback(object state);
+    public delegate void WaitOrTimerCallback(object state, bool timedOut);
 }
```

