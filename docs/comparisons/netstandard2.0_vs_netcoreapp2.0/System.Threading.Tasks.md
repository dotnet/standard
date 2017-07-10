# System.Threading.Tasks

``` diff
 namespace System.Threading.Tasks {
     public class Task : IAsyncResult, IDisposable {
+        public bool IsCompletedSuccessfully { get; }
     }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Size=1)]
+    public struct ValueTask<TResult> : IEquatable<ValueTask<TResult>> {
+        public ValueTask(Task<TResult> task);
+        public ValueTask(TResult result);
+        public bool IsCanceled { get; }
+        public bool IsCompleted { get; }
+        public bool IsCompletedSuccessfully { get; }
+        public bool IsFaulted { get; }
+        public TResult Result { get; }
+        public Task<TResult> AsTask();
+        public ConfiguredValueTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext);
+        public static AsyncValueTaskMethodBuilder<TResult> CreateAsyncMethodBuilder();
+        public override bool Equals(object obj);
+        public bool Equals(ValueTask<TResult> other);
+        public ValueTaskAwaiter<TResult> GetAwaiter();
+        public override int GetHashCode();
+        public static bool operator ==(ValueTask<TResult> left, ValueTask<TResult> right);
+        public static bool operator !=(ValueTask<TResult> left, ValueTask<TResult> right);
+        public override string ToString();
+    }
 }
```

