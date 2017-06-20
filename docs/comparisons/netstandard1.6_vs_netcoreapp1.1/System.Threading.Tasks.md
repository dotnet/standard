# System.Threading.Tasks

``` diff
 namespace System.Threading.Tasks {
+    public static class Parallel {
+        public static ParallelLoopResult For(int fromInclusive, int toExclusive, Action<int, ParallelLoopState> body);
+        public static ParallelLoopResult For(int fromInclusive, int toExclusive, Action<int> body);
+        public static ParallelLoopResult For(int fromInclusive, int toExclusive, ParallelOptions parallelOptions, Action<int, ParallelLoopState> body);
+        public static ParallelLoopResult For(int fromInclusive, int toExclusive, ParallelOptions parallelOptions, Action<int> body);
+        public static ParallelLoopResult For(long fromInclusive, long toExclusive, Action<long, ParallelLoopState> body);
+        public static ParallelLoopResult For(long fromInclusive, long toExclusive, Action<long> body);
+        public static ParallelLoopResult For(long fromInclusive, long toExclusive, ParallelOptions parallelOptions, Action<long, ParallelLoopState> body);
+        public static ParallelLoopResult For(long fromInclusive, long toExclusive, ParallelOptions parallelOptions, Action<long> body);
+        public static ParallelLoopResult For<TLocal>(int fromInclusive, int toExclusive, Func<TLocal> localInit, Func<int, ParallelLoopState, TLocal, TLocal> body, Action<TLocal> localFinally);
+        public static ParallelLoopResult For<TLocal>(int fromInclusive, int toExclusive, ParallelOptions parallelOptions, Func<TLocal> localInit, Func<int, ParallelLoopState, TLocal, TLocal> body, Action<TLocal> localFinally);
+        public static ParallelLoopResult For<TLocal>(long fromInclusive, long toExclusive, Func<TLocal> localInit, Func<long, ParallelLoopState, TLocal, TLocal> body, Action<TLocal> localFinally);
+        public static ParallelLoopResult For<TLocal>(long fromInclusive, long toExclusive, ParallelOptions parallelOptions, Func<TLocal> localInit, Func<long, ParallelLoopState, TLocal, TLocal> body, Action<TLocal> localFinally);
+        public static ParallelLoopResult ForEach<TSource, TLocal>(OrderablePartitioner<TSource> source, Func<TLocal> localInit, Func<TSource, ParallelLoopState, long, TLocal, TLocal> body, Action<TLocal> localFinally);
+        public static ParallelLoopResult ForEach<TSource, TLocal>(OrderablePartitioner<TSource> source, ParallelOptions parallelOptions, Func<TLocal> localInit, Func<TSource, ParallelLoopState, long, TLocal, TLocal> body, Action<TLocal> localFinally);
+        public static ParallelLoopResult ForEach<TSource, TLocal>(Partitioner<TSource> source, Func<TLocal> localInit, Func<TSource, ParallelLoopState, TLocal, TLocal> body, Action<TLocal> localFinally);
+        public static ParallelLoopResult ForEach<TSource, TLocal>(Partitioner<TSource> source, ParallelOptions parallelOptions, Func<TLocal> localInit, Func<TSource, ParallelLoopState, TLocal, TLocal> body, Action<TLocal> localFinally);
+        public static ParallelLoopResult ForEach<TSource, TLocal>(IEnumerable<TSource> source, Func<TLocal> localInit, Func<TSource, ParallelLoopState, long, TLocal, TLocal> body, Action<TLocal> localFinally);
+        public static ParallelLoopResult ForEach<TSource, TLocal>(IEnumerable<TSource> source, Func<TLocal> localInit, Func<TSource, ParallelLoopState, TLocal, TLocal> body, Action<TLocal> localFinally);
+        public static ParallelLoopResult ForEach<TSource, TLocal>(IEnumerable<TSource> source, ParallelOptions parallelOptions, Func<TLocal> localInit, Func<TSource, ParallelLoopState, long, TLocal, TLocal> body, Action<TLocal> localFinally);
+        public static ParallelLoopResult ForEach<TSource, TLocal>(IEnumerable<TSource> source, ParallelOptions parallelOptions, Func<TLocal> localInit, Func<TSource, ParallelLoopState, TLocal, TLocal> body, Action<TLocal> localFinally);
+        public static ParallelLoopResult ForEach<TSource>(OrderablePartitioner<TSource> source, Action<TSource, ParallelLoopState, long> body);
+        public static ParallelLoopResult ForEach<TSource>(OrderablePartitioner<TSource> source, ParallelOptions parallelOptions, Action<TSource, ParallelLoopState, long> body);
+        public static ParallelLoopResult ForEach<TSource>(Partitioner<TSource> source, Action<TSource, ParallelLoopState> body);
+        public static ParallelLoopResult ForEach<TSource>(Partitioner<TSource> source, Action<TSource> body);
+        public static ParallelLoopResult ForEach<TSource>(Partitioner<TSource> source, ParallelOptions parallelOptions, Action<TSource, ParallelLoopState> body);
+        public static ParallelLoopResult ForEach<TSource>(Partitioner<TSource> source, ParallelOptions parallelOptions, Action<TSource> body);
+        public static ParallelLoopResult ForEach<TSource>(IEnumerable<TSource> source, Action<TSource, ParallelLoopState, long> body);
+        public static ParallelLoopResult ForEach<TSource>(IEnumerable<TSource> source, Action<TSource, ParallelLoopState> body);
+        public static ParallelLoopResult ForEach<TSource>(IEnumerable<TSource> source, Action<TSource> body);
+        public static ParallelLoopResult ForEach<TSource>(IEnumerable<TSource> source, ParallelOptions parallelOptions, Action<TSource, ParallelLoopState, long> body);
+        public static ParallelLoopResult ForEach<TSource>(IEnumerable<TSource> source, ParallelOptions parallelOptions, Action<TSource, ParallelLoopState> body);
+        public static ParallelLoopResult ForEach<TSource>(IEnumerable<TSource> source, ParallelOptions parallelOptions, Action<TSource> body);
+        public static void Invoke(params Action[] actions);
+        public static void Invoke(ParallelOptions parallelOptions, params Action[] actions);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct ParallelLoopResult {
+        public bool IsCompleted { get; }
+        public Nullable<long> LowestBreakIteration { get; }
+    }
+    public class ParallelLoopState {
+        public bool IsExceptional { get; }
+        public bool IsStopped { get; }
+        public Nullable<long> LowestBreakIteration { get; }
+        public bool ShouldExitCurrentIteration { get; }
+        public void Break();
+        public void Stop();
+    }
+    public class ParallelOptions {
+        public ParallelOptions();
+        public CancellationToken CancellationToken { get; set; }
+        public int MaxDegreeOfParallelism { get; set; }
+        public TaskScheduler TaskScheduler { get; set; }
+    }
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

