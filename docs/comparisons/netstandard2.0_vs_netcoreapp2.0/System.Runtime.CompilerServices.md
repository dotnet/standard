# System.Runtime.CompilerServices

``` diff
 namespace System.Runtime.CompilerServices {
+    public sealed class AsyncMethodBuilderAttribute : Attribute {
+        public AsyncMethodBuilderAttribute(Type builderType);
+        public Type BuilderType { get; }
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Size=1)]
+    public struct AsyncValueTaskMethodBuilder<TResult> {
+        public ValueTask<TResult> Task { get; }
+        public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : INotifyCompletion where TStateMachine : IAsyncStateMachine;
+        public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine;
+        public static AsyncValueTaskMethodBuilder<TResult> Create();
+        public void SetException(Exception exception);
+        public void SetResult(TResult result);
+        public void SetStateMachine(IAsyncStateMachine stateMachine);
+        public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine;
+    }
-    public sealed class ConditionalWeakTable<TKey, TValue> where TKey : class where TValue : class {
+    public sealed class ConditionalWeakTable<TKey, TValue> : IEnumerable, IEnumerable<KeyValuePair<TKey, TValue>> where TKey : class where TValue : class {
+        public void AddOrUpdate(TKey key, TValue value);
+        public void Clear();
+        ~ConditionalWeakTable();
+        IEnumerator<KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
     }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Size=1)]
+    public struct ConfiguredValueTaskAwaitable<TResult> {
+        public ConfiguredValueTaskAwaitable<TResult>.ConfiguredValueTaskAwaiter GetAwaiter();
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Size=1)]
+        public struct ConfiguredValueTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion {
+            public bool IsCompleted { get; }
+            public TResult GetResult();
+            public void OnCompleted(Action continuation);
+            public void UnsafeOnCompleted(Action continuation);
+        }
+    }
+    public sealed class IsByRefLikeAttribute : Attribute {
+        public IsByRefLikeAttribute();
+    }
+    public sealed class IsReadOnlyAttribute : Attribute {
+        public IsReadOnlyAttribute();
+    }
+    public interface ITuple {
+        int Length { get; }
+        object this[int index] { get; }
+    }
+    public static class RuntimeFeature {
+        public static bool IsSupported(string feature);
+    }
     public static class RuntimeHelpers {
+        public static object GetUninitializedObject(Type type);
+        public static bool IsReferenceOrContainsReferences<T>();
+        public static bool TryEnsureSufficientExecutionStack();
     }
+    public static class Unsafe {
+        public static ref T Add<T>(ref T source, int elementOffset);
+        public static ref T Add<T>(ref T source, IntPtr elementOffset);
+        public static ref T AddByteOffset<T>(ref T source, IntPtr byteOffset);
+        public static bool AreSame<T>(ref T left, ref T right);
+        public static T As<T>(object o) where T : class;
+        public static ref TTo As<TFrom, TTo>(ref TFrom source);
+        public unsafe static void* AsPointer<T>(ref T value);
+        public unsafe static ref T AsRef<T>(void* source);
+        public static IntPtr ByteOffset<T>(ref T origin, ref T target);
+        public unsafe static void Copy<T>(void* destination, ref T source);
+        public unsafe static void Copy<T>(ref T destination, void* source);
+        public static void CopyBlock(ref byte destination, ref byte source, uint byteCount);
+        public unsafe static void CopyBlock(void* destination, void* source, uint byteCount);
+        public static void CopyBlockUnaligned(ref byte destination, ref byte source, uint byteCount);
+        public unsafe static void CopyBlockUnaligned(void* destination, void* source, uint byteCount);
+        public static void InitBlock(ref byte startAddress, byte value, uint byteCount);
+        public unsafe static void InitBlock(void* startAddress, byte value, uint byteCount);
+        public static void InitBlockUnaligned(ref byte startAddress, byte value, uint byteCount);
+        public unsafe static void InitBlockUnaligned(void* startAddress, byte value, uint byteCount);
+        public unsafe static T Read<T>(void* source);
+        public static T ReadUnaligned<T>(ref byte source);
+        public unsafe static T ReadUnaligned<T>(void* source);
+        public static int SizeOf<T>();
+        public static ref T Subtract<T>(ref T source, int elementOffset);
+        public static ref T Subtract<T>(ref T source, IntPtr elementOffset);
+        public static ref T SubtractByteOffset<T>(ref T source, IntPtr byteOffset);
+        public unsafe static void Write<T>(void* destination, T value);
+        public static void WriteUnaligned<T>(ref byte destination, T value);
+        public unsafe static void WriteUnaligned<T>(void* destination, T value);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct ValueTaskAwaiter<TResult> : ICriticalNotifyCompletion, INotifyCompletion {
+        public bool IsCompleted { get; }
+        public TResult GetResult();
+        public void OnCompleted(Action continuation);
+        public void UnsafeOnCompleted(Action continuation);
+    }
 }
```

