# System.Runtime.CompilerServices

``` diff
 namespace System.Runtime.CompilerServices {
+    public sealed class AsyncMethodBuilderAttribute : Attribute {
+        public AsyncMethodBuilderAttribute(Type builderType);
+        public Type BuilderType { get; }
+    }
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
+    public class CallConvCdecl
+    public class CallConvFastcall
+    public class CallConvStdcall
+    public class CallConvThiscall
+    public class CallSite {
+        public CallSiteBinder Binder { get; }
+        public static CallSite Create(Type delegateType, CallSiteBinder binder);
+    }
+    public class CallSite<T> : CallSite where T : class {
+        public T Target;
+        public T Update { get; }
+        public static CallSite<T> Create(CallSiteBinder binder);
+    }
+    public abstract class CallSiteBinder {
+        protected CallSiteBinder();
+        public static LabelTarget UpdateLabel { get; }
+        public abstract Expression Bind(object[] args, ReadOnlyCollection<ParameterExpression> parameters, LabelTarget returnLabel);
+        public virtual T BindDelegate<T>(CallSite<T> site, object[] args) where T : class;
+        protected void CacheTarget<T>(T target) where T : class;
+    }
+    public static class CallSiteHelpers {
+        public static bool IsInternalFrame(MethodBase mb);
+    }
+    public struct ConfiguredValueTaskAwaitable<TResult> {
+        public ConfiguredValueTaskAwaitable<TResult>.ConfiguredValueTaskAwaiter GetAwaiter();
+        public struct ConfiguredValueTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion {
+            public bool IsCompleted { get; }
+            public TResult GetResult();
+            public void OnCompleted(Action continuation);
+            public void UnsafeOnCompleted(Action continuation);
+        }
+    }
+    public static class ContractHelper {
+        public static string RaiseContractFailedEvent(ContractFailureKind failureKind, string userMessage, string conditionText, Exception innerException);
+        public static void TriggerFailure(ContractFailureKind kind, string displayMessage, string userMessage, string conditionText, Exception innerException);
+    }
+    public sealed class DynamicAttribute : Attribute {
+        public DynamicAttribute();
+        public DynamicAttribute(bool[] transformFlags);
+        public IList<bool> TransformFlags { get; }
+    }
+    public static class IsBoxed
+    public static class IsByValue
+    public static class IsCopyConstructed
+    public static class IsExplicitlyDereferenced
+    public static class IsImplicitlyDereferenced
+    public static class IsJitIntrinsic
+    public static class IsLong
+    public static class IsSignUnspecifiedByte
+    public static class IsUdtReturn
+    public sealed class NativeCppClassAttribute : Attribute {
+        public NativeCppClassAttribute();
+    }
+    public sealed class RequiredAttributeAttribute : Attribute {
+        public RequiredAttributeAttribute(Type requiredContract);
+        public Type RequiredContract { get; }
+    }
+    public sealed class TupleElementNamesAttribute : Attribute {
+        public TupleElementNamesAttribute(string[] transformNames);
+        public IList<string> TransformNames { get; }
+    }
+    public static class Unsafe {
+        public static ref T Add<T>(ref T source, int elementOffset);
+        public static bool AreSame<T>(ref T left, ref T right);
+        public static T As<T>(object o) where T : class;
+        public static ref TTo As<TFrom, TTo>(ref TFrom source);
+        public unsafe static void* AsPointer<T>(ref T value);
+        public unsafe static ref T AsRef<T>(void* source);
+        public unsafe static void Copy<T>(void* destination, ref T source);
+        public unsafe static void Copy<T>(ref T destination, void* source);
+        public unsafe static void CopyBlock(void* destination, void* source, uint byteCount);
+        public unsafe static void InitBlock(void* startAddress, byte value, uint byteCount);
+        public unsafe static T Read<T>(void* source);
+        public static int SizeOf<T>();
+        public static ref T Subtract<T>(ref T source, int elementOffset);
+        public unsafe static void Write<T>(void* destination, T value);
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

