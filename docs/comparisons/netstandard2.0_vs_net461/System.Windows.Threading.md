# System.Windows.Threading

``` diff
+namespace System.Windows.Threading {
+    public sealed class Dispatcher {
+        public static Dispatcher CurrentDispatcher { get; }
+        public bool HasShutdownFinished { get; }
+        public bool HasShutdownStarted { get; }
+        public DispatcherHooks Hooks { get; }
+        public Thread Thread { get; }
+        public event EventHandler ShutdownFinished;
+        public event EventHandler ShutdownStarted;
+        public event DispatcherUnhandledExceptionEventHandler UnhandledException;
+        public event DispatcherUnhandledExceptionFilterEventHandler UnhandledExceptionFilter;
+        public DispatcherOperation BeginInvoke(Delegate method, params object[] args);
+        public DispatcherOperation BeginInvoke(Delegate method, DispatcherPriority priority, params object[] args);
+        public DispatcherOperation BeginInvoke(DispatcherPriority priority, Delegate method);
+        public DispatcherOperation BeginInvoke(DispatcherPriority priority, Delegate method, object arg);
+        public DispatcherOperation BeginInvoke(DispatcherPriority priority, Delegate method, object arg, params object[] args);
+        public void BeginInvokeShutdown(DispatcherPriority priority);
+        public bool CheckAccess();
+        public DispatcherProcessingDisabled DisableProcessing();
+        public static void ExitAllFrames();
+        public static Dispatcher FromThread(Thread thread);
+        public void Invoke(Action callback);
+        public void Invoke(Action callback, DispatcherPriority priority);
+        public void Invoke(Action callback, DispatcherPriority priority, CancellationToken cancellationToken);
+        public void Invoke(Action callback, DispatcherPriority priority, CancellationToken cancellationToken, TimeSpan timeout);
+        public object Invoke(Delegate method, params object[] args);
+        public object Invoke(Delegate method, TimeSpan timeout, params object[] args);
+        public object Invoke(Delegate method, TimeSpan timeout, DispatcherPriority priority, params object[] args);
+        public object Invoke(Delegate method, DispatcherPriority priority, params object[] args);
+        public object Invoke(DispatcherPriority priority, Delegate method);
+        public object Invoke(DispatcherPriority priority, Delegate method, object arg);
+        public object Invoke(DispatcherPriority priority, Delegate method, object arg, params object[] args);
+        public object Invoke(DispatcherPriority priority, TimeSpan timeout, Delegate method);
+        public object Invoke(DispatcherPriority priority, TimeSpan timeout, Delegate method, object arg);
+        public object Invoke(DispatcherPriority priority, TimeSpan timeout, Delegate method, object arg, params object[] args);
+        public TResult Invoke<TResult>(Func<TResult> callback);
+        public TResult Invoke<TResult>(Func<TResult> callback, DispatcherPriority priority);
+        public TResult Invoke<TResult>(Func<TResult> callback, DispatcherPriority priority, CancellationToken cancellationToken);
+        public TResult Invoke<TResult>(Func<TResult> callback, DispatcherPriority priority, CancellationToken cancellationToken, TimeSpan timeout);
+        public DispatcherOperation InvokeAsync(Action callback);
+        public DispatcherOperation InvokeAsync(Action callback, DispatcherPriority priority);
+        public DispatcherOperation InvokeAsync(Action callback, DispatcherPriority priority, CancellationToken cancellationToken);
+        public DispatcherOperation<TResult> InvokeAsync<TResult>(Func<TResult> callback);
+        public DispatcherOperation<TResult> InvokeAsync<TResult>(Func<TResult> callback, DispatcherPriority priority);
+        public DispatcherOperation<TResult> InvokeAsync<TResult>(Func<TResult> callback, DispatcherPriority priority, CancellationToken cancellationToken);
+        public void InvokeShutdown();
+        public static void PushFrame(DispatcherFrame frame);
+        public static void Run();
+        public static void ValidatePriority(DispatcherPriority priority, string parameterName);
+        public void VerifyAccess();
+        public static DispatcherPriorityAwaitable Yield();
+        public static DispatcherPriorityAwaitable Yield(DispatcherPriority priority);
+    }
+    public class DispatcherEventArgs : EventArgs {
+        public Dispatcher Dispatcher { get; }
+    }
+    public static class DispatcherExtensions {
+        public static DispatcherOperation BeginInvoke(this Dispatcher dispatcher, Action action);
+        public static DispatcherOperation BeginInvoke(this Dispatcher dispatcher, Action action, DispatcherPriority priority);
+        public static void Invoke(this Dispatcher dispatcher, Action action);
+        public static void Invoke(this Dispatcher dispatcher, Action action, TimeSpan timeout);
+        public static void Invoke(this Dispatcher dispatcher, Action action, TimeSpan timeout, DispatcherPriority priority);
+        public static void Invoke(this Dispatcher dispatcher, Action action, DispatcherPriority priority);
+    }
+    public class DispatcherFrame : DispatcherObject {
+        public DispatcherFrame();
+        public DispatcherFrame(bool exitWhenRequested);
+        public bool Continue { get; set; }
+    }
+    public sealed class DispatcherHookEventArgs : EventArgs {
+        public DispatcherHookEventArgs(DispatcherOperation operation);
+        public Dispatcher Dispatcher { get; }
+        public DispatcherOperation Operation { get; }
+    }
+    public delegate void DispatcherHookEventHandler(object sender, DispatcherHookEventArgs e);
+    public sealed class DispatcherHooks {
+        public event EventHandler DispatcherInactive;
+        public event DispatcherHookEventHandler OperationAborted;
+        public event DispatcherHookEventHandler OperationCompleted;
+        public event DispatcherHookEventHandler OperationPosted;
+        public event DispatcherHookEventHandler OperationPriorityChanged;
+        public event DispatcherHookEventHandler OperationStarted;
+    }
+    public abstract class DispatcherObject {
+        protected DispatcherObject();
+        public Dispatcher Dispatcher { get; }
+        public bool CheckAccess();
+        public void VerifyAccess();
+    }
+    public class DispatcherOperation {
+        public Dispatcher Dispatcher { get; }
+        public DispatcherPriority Priority { get; set; }
+        public object Result { get; }
+        public DispatcherOperationStatus Status { get; }
+        public Task Task { get; }
+        public event EventHandler Aborted;
+        public event EventHandler Completed;
+        public bool Abort();
+        public TaskAwaiter GetAwaiter();
+        protected virtual object InvokeDelegateCore();
+        public DispatcherOperationStatus Wait();
+        public DispatcherOperationStatus Wait(TimeSpan timeout);
+    }
+    public class DispatcherOperation<TResult> : DispatcherOperation {
+        public new TResult Result { get; }
+        public new Task<TResult> Task { get; }
+        public new TaskAwaiter<TResult> GetAwaiter();
+        protected override object InvokeDelegateCore();
+    }
+    public delegate object DispatcherOperationCallback(object arg);
+    public enum DispatcherOperationStatus {
+        Aborted = 1,
+        Completed = 2,
+        Executing = 3,
+        Pending = 0,
+    }
+    public enum DispatcherPriority {
+        ApplicationIdle = 2,
+        Background = 4,
+        ContextIdle = 3,
+        DataBind = 8,
+        Inactive = 0,
+        Input = 5,
+        Invalid = -1,
+        Loaded = 6,
+        Normal = 9,
+        Render = 7,
+        Send = 10,
+        SystemIdle = 1,
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct DispatcherPriorityAwaitable {
+        public DispatcherPriorityAwaiter GetAwaiter();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct DispatcherPriorityAwaiter : INotifyCompletion {
+        public bool IsCompleted { get; }
+        public void GetResult();
+        public void OnCompleted(Action continuation);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct DispatcherProcessingDisabled : IDisposable {
+        public void Dispose();
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public static bool operator ==(DispatcherProcessingDisabled left, DispatcherProcessingDisabled right);
+        public static bool operator !=(DispatcherProcessingDisabled left, DispatcherProcessingDisabled right);
+    }
+    public sealed class DispatcherSynchronizationContext : SynchronizationContext {
+        public DispatcherSynchronizationContext();
+        public DispatcherSynchronizationContext(Dispatcher dispatcher);
+        public DispatcherSynchronizationContext(Dispatcher dispatcher, DispatcherPriority priority);
+        public override SynchronizationContext CreateCopy();
+        public override void Post(SendOrPostCallback d, object state);
+        public override void Send(SendOrPostCallback d, object state);
+        public override int Wait(IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout);
+    }
+    public class DispatcherTimer {
+        public DispatcherTimer();
+        public DispatcherTimer(TimeSpan interval, DispatcherPriority priority, EventHandler callback, Dispatcher dispatcher);
+        public DispatcherTimer(DispatcherPriority priority);
+        public DispatcherTimer(DispatcherPriority priority, Dispatcher dispatcher);
+        public Dispatcher Dispatcher { get; }
+        public TimeSpan Interval { get; set; }
+        public bool IsEnabled { get; set; }
+        public object Tag { get; set; }
+        public event EventHandler Tick;
+        public void Start();
+        public void Stop();
+    }
+    public sealed class DispatcherUnhandledExceptionEventArgs : DispatcherEventArgs {
+        public Exception Exception { get; }
+        public bool Handled { get; set; }
+    }
+    public delegate void DispatcherUnhandledExceptionEventHandler(object sender, DispatcherUnhandledExceptionEventArgs e);
+    public sealed class DispatcherUnhandledExceptionFilterEventArgs : DispatcherEventArgs {
+        public Exception Exception { get; }
+        public bool RequestCatch { get; set; }
+    }
+    public delegate void DispatcherUnhandledExceptionFilterEventHandler(object sender, DispatcherUnhandledExceptionFilterEventArgs e);
+    public static class TaskExtensions {
+        public static DispatcherOperationStatus DispatcherOperationWait(this Task @this);
+        public static DispatcherOperationStatus DispatcherOperationWait(this Task @this, TimeSpan timeout);
+        public static bool IsDispatcherOperationTask(this Task @this);
+    }
+}
```

