// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Runtime.CompilerServices
{
    [System.AttributeUsageAttribute(System.AttributeTargets.Field)]
    public sealed partial class AccessedThroughPropertyAttribute : System.Attribute
    {
        public AccessedThroughPropertyAttribute(string propertyName) { }
        public string PropertyName { get { throw null; } }
    }
    public partial struct AsyncIteratorMethodBuilder
    {
        private object _dummy;
        public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : System.Runtime.CompilerServices.INotifyCompletion where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine { }
        public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : System.Runtime.CompilerServices.ICriticalNotifyCompletion where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine { }
        public void Complete() { }
        public static System.Runtime.CompilerServices.AsyncIteratorMethodBuilder Create() { throw null; }
        public void MoveNext<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method, Inherited=false, AllowMultiple=false)]
    public sealed partial class AsyncIteratorStateMachineAttribute : System.Runtime.CompilerServices.StateMachineAttribute
    {
        public AsyncIteratorStateMachineAttribute(System.Type stateMachineType) : base(default(System.Type)) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Delegate | System.AttributeTargets.Enum | System.AttributeTargets.Interface | System.AttributeTargets.Struct, Inherited=false, AllowMultiple=false)]
    public sealed partial class AsyncMethodBuilderAttribute : System.Attribute
    {
        public AsyncMethodBuilderAttribute(System.Type builderType) { }
        public System.Type BuilderType { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method, Inherited=false, AllowMultiple=false)]
    public sealed partial class AsyncStateMachineAttribute : System.Runtime.CompilerServices.StateMachineAttribute
    {
        public AsyncStateMachineAttribute(System.Type stateMachineType) : base (default(System.Type)) { }
    }
    public partial struct AsyncTaskMethodBuilder
    {
        private object _dummy;
        public System.Threading.Tasks.Task Task { get { throw null; } }
        public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : System.Runtime.CompilerServices.INotifyCompletion where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine { }
        public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : System.Runtime.CompilerServices.ICriticalNotifyCompletion where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine { }
        public static System.Runtime.CompilerServices.AsyncTaskMethodBuilder Create() { throw null; }
        public void SetException(System.Exception exception) { }
        public void SetResult() { }
        public void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { }
        public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine { }
    }
    public partial struct AsyncTaskMethodBuilder<TResult>
    {
        private object _dummy;
        public System.Threading.Tasks.Task<TResult> Task { get { throw null; } }
        public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : System.Runtime.CompilerServices.INotifyCompletion where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine { }
        public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : System.Runtime.CompilerServices.ICriticalNotifyCompletion where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine { }
        public static System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult> Create() { throw null; }
        public void SetException(System.Exception exception) { }
        public void SetResult(TResult result) { }
        public void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { }
        public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine { }
    }
    public partial struct AsyncValueTaskMethodBuilder
    {
        private object _dummy;
        private int _dummyPrimitive;
        public System.Threading.Tasks.ValueTask Task { get { throw null; } }
        public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : System.Runtime.CompilerServices.INotifyCompletion where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine { }
        public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : System.Runtime.CompilerServices.ICriticalNotifyCompletion where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine { }
        public static System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder Create() { throw null; }
        public void SetException(System.Exception exception) { }
        public void SetResult() { }
        public void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { }
        public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine { }
    }
    public partial struct AsyncValueTaskMethodBuilder<TResult>
    {
        private TResult _result;
        private object _dummy;
        private int _dummyPrimitive;
        public System.Threading.Tasks.ValueTask<TResult> Task { get { throw null; } }
        public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : System.Runtime.CompilerServices.INotifyCompletion where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine { }
        public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : System.Runtime.CompilerServices.ICriticalNotifyCompletion where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine { }
        public static System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder<TResult> Create() { throw null; }
        public void SetException(System.Exception exception) { }
        public void SetResult(TResult result) { }
        public void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { }
        public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine { }
    }
    public partial struct AsyncVoidMethodBuilder
    {
        private object _dummy;
        public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : System.Runtime.CompilerServices.INotifyCompletion where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine { }
        public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : System.Runtime.CompilerServices.ICriticalNotifyCompletion where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine { }
        public static System.Runtime.CompilerServices.AsyncVoidMethodBuilder Create() { throw null; }
        public void SetException(System.Exception exception) { }
        public void SetResult() { }
        public void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) { }
        public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine { }
    }
    public partial class CallConvCdecl
    {
        public CallConvCdecl() { }
    }
    public partial class CallConvFastcall
    {
        public CallConvFastcall() { }
    }
    public partial class CallConvStdcall
    {
        public CallConvStdcall() { }
    }
    public partial class CallConvThiscall
    {
        public CallConvThiscall() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter, Inherited=false)]
    public sealed partial class CallerFilePathAttribute : System.Attribute
    {
        public CallerFilePathAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter, Inherited=false)]
    public sealed partial class CallerLineNumberAttribute : System.Attribute
    {
        public CallerLineNumberAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter, Inherited=false)]
    public sealed partial class CallerMemberNameAttribute : System.Attribute
    {
        public CallerMemberNameAttribute() { }
    }
    public partial class CallSite
    {
        internal CallSite() { }
        public System.Runtime.CompilerServices.CallSiteBinder Binder { get { throw null; } }
        public static System.Runtime.CompilerServices.CallSite Create(System.Type delegateType, System.Runtime.CompilerServices.CallSiteBinder binder) { throw null; }
    }
    public partial class CallSite<T> : System.Runtime.CompilerServices.CallSite where T : class
    {
        internal CallSite() { }
        public T Target;
        public T Update { get { throw null; } }
        public static System.Runtime.CompilerServices.CallSite<T> Create(System.Runtime.CompilerServices.CallSiteBinder binder) { throw null; }
    }
    public abstract partial class CallSiteBinder
    {
        protected CallSiteBinder() { }
        public static System.Linq.Expressions.LabelTarget UpdateLabel { get { throw null; } }
        public abstract System.Linq.Expressions.Expression Bind(object[] args, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> parameters, System.Linq.Expressions.LabelTarget returnLabel);
        public virtual T BindDelegate<T>(System.Runtime.CompilerServices.CallSite<T> site, object[] args) where T : class { throw null; }
        protected void CacheTarget<T>(T target) where T : class { }
    }
    public static partial class CallSiteHelpers
    {
        public static bool IsInternalFrame(System.Reflection.MethodBase mb) { throw null; }
    }
    [System.FlagsAttribute]
    public enum CompilationRelaxations
    {
        NoStringInterning = 8,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.Class | System.AttributeTargets.Method | System.AttributeTargets.Module)]
    public partial class CompilationRelaxationsAttribute : System.Attribute
    {
        public CompilationRelaxationsAttribute(int relaxations) { }
        public CompilationRelaxationsAttribute(System.Runtime.CompilerServices.CompilationRelaxations relaxations) { }
        public int CompilationRelaxations { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All, Inherited=true)]
    public sealed partial class CompilerGeneratedAttribute : System.Attribute
    {
        public CompilerGeneratedAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class)]
    public partial class CompilerGlobalScopeAttribute : System.Attribute
    {
        public CompilerGlobalScopeAttribute() { }
    }
    public static partial class CompilerMarshalOverride
    {
    }
    public sealed partial class ConditionalWeakTable<TKey, TValue> : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable where TKey : class where TValue : class
    {
        public ConditionalWeakTable() { }
        public void Add(TKey key, TValue value) { }
        public void AddOrUpdate(TKey key, TValue value) { }
        public void Clear() { }
        public TValue GetOrCreateValue(TKey key) { throw null; }
        public TValue GetValue(TKey key, System.Runtime.CompilerServices.ConditionalWeakTable<TKey, TValue>.CreateValueCallback createValueCallback) { throw null; }
        public bool Remove(TKey key) { throw null; }
        System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public bool TryGetValue(TKey key, out TValue value) { throw null; }
        public delegate TValue CreateValueCallback(TKey key);
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ConfiguredAsyncDisposable
    {
        private readonly object _dummy;
        public System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable DisposeAsync() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ConfiguredCancelableAsyncEnumerable<T>
    {
        private readonly object _dummy;
        public System.Runtime.CompilerServices.ConfiguredCancelableAsyncEnumerable<T> ConfigureAwait(bool continueOnCapturedContext) { throw null; }
        public System.Runtime.CompilerServices.ConfiguredCancelableAsyncEnumerable<T>.Enumerator GetAsyncEnumerator() { throw null; }
        public System.Runtime.CompilerServices.ConfiguredCancelableAsyncEnumerable<T> WithCancellation(System.Threading.CancellationToken cancellationToken) { throw null; }
        public readonly partial struct Enumerator
        {
            private readonly object _dummy;
            public T Current { get { throw null; } }
            public System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable DisposeAsync() { throw null; }
            public System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable<bool> MoveNextAsync() { throw null; }
        }
    }
    public readonly partial struct ConfiguredTaskAwaitable
    {
        private readonly object _dummy;
        public System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter GetAwaiter() { throw null; }
        public readonly partial struct ConfiguredTaskAwaiter : System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
        {
            private readonly object _dummy;
            private readonly int _dummyPrimitive;
            public bool IsCompleted { get { throw null; } }
            public void GetResult() { }
            public void OnCompleted(System.Action continuation) { }
            public void UnsafeOnCompleted(System.Action continuation) { }
        }
    }
    public readonly partial struct ConfiguredTaskAwaitable<TResult>
    {
        private readonly object _dummy;
        public System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter GetAwaiter() { throw null; }
        public readonly partial struct ConfiguredTaskAwaiter : System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
        {
            private readonly object _dummy;
            private readonly int _dummyPrimitive;
            public bool IsCompleted { get { throw null; } }
            public TResult GetResult() { throw null; }
            public void OnCompleted(System.Action continuation) { }
            public void UnsafeOnCompleted(System.Action continuation) { }
        }
    }
    public readonly partial struct ConfiguredValueTaskAwaitable
    {
        private readonly object _dummy;
        public System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter GetAwaiter() { throw null; }
        public readonly partial struct ConfiguredValueTaskAwaiter : System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
        {
            private readonly object _dummy;
            public bool IsCompleted { get { throw null; } }
            public void GetResult() { }
            public void OnCompleted(System.Action continuation) { }
            public void UnsafeOnCompleted(System.Action continuation) { }
        }
    }
    public readonly partial struct ConfiguredValueTaskAwaitable<TResult>
    {
        private readonly object _dummy;
        public System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable<TResult>.ConfiguredValueTaskAwaiter GetAwaiter() { throw null; }
        public readonly partial struct ConfiguredValueTaskAwaiter : System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
        {
            private readonly object _dummy;
            public bool IsCompleted { get { throw null; } }
            public TResult GetResult() { throw null; }
            public void OnCompleted(System.Action continuation) { }
            public void UnsafeOnCompleted(System.Action continuation) { }
        }
    }
    public static partial class ContractHelper
    {
        public static string RaiseContractFailedEvent(System.Diagnostics.Contracts.ContractFailureKind failureKind, string userMessage, string conditionText, System.Exception innerException) { throw null; }
        public static void TriggerFailure(System.Diagnostics.Contracts.ContractFailureKind kind, string displayMessage, string userMessage, string conditionText, System.Exception innerException) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Field | System.AttributeTargets.Parameter, Inherited=false)]
    public abstract partial class CustomConstantAttribute : System.Attribute
    {
        protected CustomConstantAttribute() { }
        public abstract object Value { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Field | System.AttributeTargets.Parameter, Inherited=false)]
    public sealed partial class DateTimeConstantAttribute : System.Runtime.CompilerServices.CustomConstantAttribute
    {
        public DateTimeConstantAttribute(long ticks) { }
        public override object Value { get { throw null; } }
    }
    public abstract partial class DebugInfoGenerator
    {
        protected DebugInfoGenerator() { }
        public static System.Runtime.CompilerServices.DebugInfoGenerator CreatePdbGenerator() { throw null; }
        public abstract void MarkSequencePoint(System.Linq.Expressions.LambdaExpression method, int ilOffset, System.Linq.Expressions.DebugInfoExpression sequencePoint);
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Field | System.AttributeTargets.Parameter, Inherited=false)]
    public sealed partial class DecimalConstantAttribute : System.Attribute
    {
        public DecimalConstantAttribute(byte scale, byte sign, int hi, int mid, int low) { }
        [System.CLSCompliantAttribute(false)]
        public DecimalConstantAttribute(byte scale, byte sign, uint hi, uint mid, uint low) { }
        public decimal Value { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly)]
    public sealed partial class DefaultDependencyAttribute : System.Attribute
    {
        public DefaultDependencyAttribute(System.Runtime.CompilerServices.LoadHint loadHintArgument) { }
        public System.Runtime.CompilerServices.LoadHint LoadHint { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, AllowMultiple=true)]
    public sealed partial class DependencyAttribute : System.Attribute
    {
        public DependencyAttribute(string dependentAssemblyArgument, System.Runtime.CompilerServices.LoadHint loadHintArgument) { }
        public string DependentAssembly { get { throw null; } }
        public System.Runtime.CompilerServices.LoadHint LoadHint { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, AllowMultiple=false, Inherited=false)]
    public sealed partial class DisablePrivateReflectionAttribute : System.Attribute
    {
        public DisablePrivateReflectionAttribute() { }
    }
    public partial class DiscardableAttribute : System.Attribute
    {
        public DiscardableAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Field | System.AttributeTargets.Parameter | System.AttributeTargets.Property | System.AttributeTargets.ReturnValue | System.AttributeTargets.Struct)]
    public sealed partial class DynamicAttribute : System.Attribute
    {
        public DynamicAttribute() { }
        public DynamicAttribute(bool[] transformFlags) { }
        public System.Collections.Generic.IList<bool> TransformFlags { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter, Inherited=false)]
    public sealed partial class EnumeratorCancellationAttribute : System.Attribute
    {
        public EnumeratorCancellationAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.Class | System.AttributeTargets.Method)]
    public sealed partial class ExtensionAttribute : System.Attribute
    {
        public ExtensionAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Field)]
    public sealed partial class FixedAddressValueTypeAttribute : System.Attribute
    {
        public FixedAddressValueTypeAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Field, Inherited=false)]
    public sealed partial class FixedBufferAttribute : System.Attribute
    {
        public FixedBufferAttribute(System.Type elementType, int length) { }
        public System.Type ElementType { get { throw null; } }
        public int Length { get { throw null; } }
    }
    public static partial class FormattableStringFactory
    {
        public static System.FormattableString Create(string format, params object[] arguments) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Struct)]
    public sealed partial class HasCopySemanticsAttribute : System.Attribute
    {
        public HasCopySemanticsAttribute() { }
    }
    public partial interface IAsyncStateMachine
    {
        void MoveNext();
        void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
    public partial interface ICriticalNotifyCompletion : System.Runtime.CompilerServices.INotifyCompletion
    {
        void UnsafeOnCompleted(System.Action continuation);
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property, Inherited=true)]
    public sealed partial class IndexerNameAttribute : System.Attribute
    {
        public IndexerNameAttribute(string indexerName) { }
    }
    public partial interface INotifyCompletion
    {
        void OnCompleted(System.Action continuation);
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, AllowMultiple=true, Inherited=false)]
    public sealed partial class InternalsVisibleToAttribute : System.Attribute
    {
        public InternalsVisibleToAttribute(string assemblyName) { }
        public bool AllInternalsVisible { get { throw null; } set { } }
        public string AssemblyName { get { throw null; } }
    }
    public partial interface IRuntimeVariables
    {
        int Count { get; }
        object this[int index] { get; set; }
    }
    public static partial class IsBoxed
    {
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Struct)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public sealed partial class IsByRefLikeAttribute : System.Attribute
    {
        public IsByRefLikeAttribute() { }
    }
    public static partial class IsByValue
    {
    }
    public static partial class IsConst
    {
    }
    public static partial class IsCopyConstructed
    {
    }
    public static partial class IsExplicitlyDereferenced
    {
    }
    public static partial class IsImplicitlyDereferenced
    {
    }
    public static partial class IsJitIntrinsic
    {
    }
    public static partial class IsLong
    {
    }
    public static partial class IsPinned
    {
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All, Inherited=false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public sealed partial class IsReadOnlyAttribute : System.Attribute
    {
        public IsReadOnlyAttribute() { }
    }
    public static partial class IsSignUnspecifiedByte
    {
    }
    public partial interface IStrongBox
    {
        object Value { get; set; }
    }
    public static partial class IsUdtReturn
    {
    }
    public static partial class IsVolatile
    {
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method, Inherited=false, AllowMultiple=false)]
    public sealed partial class IteratorStateMachineAttribute : System.Runtime.CompilerServices.StateMachineAttribute
    {
        public IteratorStateMachineAttribute(System.Type stateMachineType) : base (default(System.Type)) { }
    }
    public partial interface ITuple
    {
        object this[int index] { get; }
        int Length { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Field | System.AttributeTargets.Parameter, Inherited=false)]
    public sealed partial class IUnknownConstantAttribute : System.Runtime.CompilerServices.CustomConstantAttribute
    {
        public IUnknownConstantAttribute() { }
        public override object Value { get { throw null; } }
    }
    public enum LoadHint
    {
        Always = 1,
        Default = 0,
        Sometimes = 2,
    }
    public enum MethodCodeType
    {
        IL = 0,
        Native = 1,
        OPTIL = 2,
        Runtime = 3,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Constructor | System.AttributeTargets.Method, Inherited=false)]
    public sealed partial class MethodImplAttribute : System.Attribute
    {
        public System.Runtime.CompilerServices.MethodCodeType MethodCodeType;
        public MethodImplAttribute() { }
        public MethodImplAttribute(short value) { }
        public MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions methodImplOptions) { }
        public System.Runtime.CompilerServices.MethodImplOptions Value { get { throw null; } }
    }
    [System.FlagsAttribute]
    public enum MethodImplOptions
    {
        AggressiveInlining = 256,
        ForwardRef = 16,
        InternalCall = 4096,
        NoInlining = 8,
        NoOptimization = 64,
        PreserveSig = 128,
        Synchronized = 32,
        Unmanaged = 4,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Struct, Inherited=true)]
    public sealed partial class NativeCppClassAttribute : System.Attribute
    {
        public NativeCppClassAttribute() { }
    }
    public sealed partial class ReadOnlyCollectionBuilder<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
    {
        public ReadOnlyCollectionBuilder() { }
        public ReadOnlyCollectionBuilder(System.Collections.Generic.IEnumerable<T> collection) { }
        public ReadOnlyCollectionBuilder(int capacity) { }
        public int Capacity { get { throw null; } set { } }
        public int Count { get { throw null; } }
        public T this[int index] { get { throw null; } set { } }
        bool System.Collections.Generic.ICollection<T>.IsReadOnly { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        bool System.Collections.IList.IsFixedSize { get { throw null; } }
        bool System.Collections.IList.IsReadOnly { get { throw null; } }
        object System.Collections.IList.this[int index] { get { throw null; } set { } }
        public void Add(T item) { }
        public void Clear() { }
        public bool Contains(T item) { throw null; }
        public void CopyTo(T[] array, int arrayIndex) { }
        public System.Collections.Generic.IEnumerator<T> GetEnumerator() { throw null; }
        public int IndexOf(T item) { throw null; }
        public void Insert(int index, T item) { }
        public bool Remove(T item) { throw null; }
        public void RemoveAt(int index) { }
        public void Reverse() { }
        public void Reverse(int index, int count) { }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        int System.Collections.IList.Add(object value) { throw null; }
        bool System.Collections.IList.Contains(object value) { throw null; }
        int System.Collections.IList.IndexOf(object value) { throw null; }
        void System.Collections.IList.Insert(int index, object value) { }
        void System.Collections.IList.Remove(object value) { }
        public T[] ToArray() { throw null; }
        public System.Collections.ObjectModel.ReadOnlyCollection<T> ToReadOnlyCollection() { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, AllowMultiple=false)]
    public sealed partial class ReferenceAssemblyAttribute : System.Attribute
    {
        public ReferenceAssemblyAttribute() { }
        public ReferenceAssemblyAttribute(string description) { }
        public string Description { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Enum | System.AttributeTargets.Interface | System.AttributeTargets.Struct, AllowMultiple=true, Inherited=false)]
    public sealed partial class RequiredAttributeAttribute : System.Attribute
    {
        public RequiredAttributeAttribute(System.Type requiredContract) { }
        public System.Type RequiredContract { get { throw null; } }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public partial class RuleCache<T> where T : class
    {
        internal RuleCache() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, Inherited=false, AllowMultiple=false)]
    public sealed partial class RuntimeCompatibilityAttribute : System.Attribute
    {
        public RuntimeCompatibilityAttribute() { }
        public bool WrapNonExceptionThrows { get { throw null; } set { } }
    }
    public static partial class RuntimeFeature
    {
        public const string DefaultImplementationsOfInterfaces = "DefaultImplementationsOfInterfaces";
        public const string PortablePdb = "PortablePdb";
        public static bool IsDynamicCodeCompiled { get { throw null; } }
        public static bool IsDynamicCodeSupported { get { throw null; } }
        public static bool IsSupported(string feature) { throw null; }
    }
    public static partial class RuntimeHelpers
    {
        public static int OffsetToStringData { get { throw null; } }
        public static void EnsureSufficientExecutionStack() { }
        public static new bool Equals(object o1, object o2) { throw null; }
        public static void ExecuteCodeWithGuaranteedCleanup(System.Runtime.CompilerServices.RuntimeHelpers.TryCode code, System.Runtime.CompilerServices.RuntimeHelpers.CleanupCode backoutCode, object userData) { }
        public static int GetHashCode(object o) { throw null; }
        public static object GetObjectValue(object obj) { throw null; }
        public static T[] GetSubArray<T>(T[] array, System.Range range) { throw null; }
        public static object GetUninitializedObject(System.Type type) { throw null; }
        public static void InitializeArray(System.Array array, System.RuntimeFieldHandle fldHandle) { }
        public static bool IsReferenceOrContainsReferences<T>() { throw null; }
        public static void PrepareConstrainedRegions() { }
        public static void PrepareConstrainedRegionsNoOP() { }
        public static void PrepareContractedDelegate(System.Delegate d) { }
        public static void PrepareDelegate(System.Delegate d) { }
        public static void PrepareMethod(System.RuntimeMethodHandle method) { }
        public static void PrepareMethod(System.RuntimeMethodHandle method, System.RuntimeTypeHandle[] instantiation) { }
        public static void ProbeForSufficientStack() { }
        public static void RunClassConstructor(System.RuntimeTypeHandle type) { }
        public static void RunModuleConstructor(System.ModuleHandle module) { }
        public static bool TryEnsureSufficientExecutionStack() { throw null; }
        public delegate void CleanupCode(object userData, bool exceptionThrown);
        public delegate void TryCode(object userData);
    }
    public sealed partial class RuntimeWrappedException : System.Exception
    {
        public RuntimeWrappedException(object thrownObject) { }
        public object WrappedException { get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Enum)]
    public sealed partial class ScopelessEnumAttribute : System.Attribute
    {
        public ScopelessEnumAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Event | System.AttributeTargets.Field | System.AttributeTargets.Method | System.AttributeTargets.Property | System.AttributeTargets.Struct)]
    public sealed partial class SpecialNameAttribute : System.Attribute
    {
        public SpecialNameAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method, Inherited=false, AllowMultiple=false)]
    public partial class StateMachineAttribute : System.Attribute
    {
        public StateMachineAttribute(System.Type stateMachineType) { }
        public System.Type StateMachineType { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, Inherited=false)]
    public sealed partial class StringFreezingAttribute : System.Attribute
    {
        public StringFreezingAttribute() { }
    }
    public partial class StrongBox<T> : System.Runtime.CompilerServices.IStrongBox
    {
        public T Value;
        public StrongBox() { }
        public StrongBox(T value) { }
        object System.Runtime.CompilerServices.IStrongBox.Value { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.Module)]
    public sealed partial class SuppressIldasmAttribute : System.Attribute
    {
        public SuppressIldasmAttribute() { }
    }
    public sealed partial class SwitchExpressionException : System.InvalidOperationException
    {
        public SwitchExpressionException() { }
        public SwitchExpressionException(System.Exception innerException) { }
        public SwitchExpressionException(object unmatchedValue) { }
        public SwitchExpressionException(string message) { }
        public SwitchExpressionException(string message, System.Exception innerException) { }
        public object UnmatchedValue { get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public readonly partial struct TaskAwaiter : System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
    {
        private readonly object _dummy;
        public bool IsCompleted { get { throw null; } }
        public void GetResult() { }
        public void OnCompleted(System.Action continuation) { }
        public void UnsafeOnCompleted(System.Action continuation) { }
    }
    public readonly partial struct TaskAwaiter<TResult> : System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
    {
        private readonly object _dummy;
        public bool IsCompleted { get { throw null; } }
        public TResult GetResult() { throw null; }
        public void OnCompleted(System.Action continuation) { }
        public void UnsafeOnCompleted(System.Action continuation) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Event | System.AttributeTargets.Field | System.AttributeTargets.Parameter | System.AttributeTargets.Property | System.AttributeTargets.ReturnValue | System.AttributeTargets.Struct)]
    [System.CLSCompliantAttribute(false)]
    public sealed partial class TupleElementNamesAttribute : System.Attribute
    {
        public TupleElementNamesAttribute(string[] transformNames) { }
        public System.Collections.Generic.IList<string> TransformNames { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Delegate | System.AttributeTargets.Enum | System.AttributeTargets.Interface | System.AttributeTargets.Struct, Inherited=false, AllowMultiple=false)]
    public sealed partial class TypeForwardedFromAttribute : System.Attribute
    {
        public TypeForwardedFromAttribute(string assemblyFullName) { }
        public string AssemblyFullName { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, AllowMultiple=true, Inherited=false)]
    public sealed partial class TypeForwardedToAttribute : System.Attribute
    {
        public TypeForwardedToAttribute(System.Type destination) { }
        public System.Type Destination { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Struct)]
    public sealed partial class UnsafeValueTypeAttribute : System.Attribute
    {
        public UnsafeValueTypeAttribute() { }
    }
    public readonly partial struct ValueTaskAwaiter : System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
    {
        private readonly object _dummy;
        public bool IsCompleted { get { throw null; } }
        public void GetResult() { }
        public void OnCompleted(System.Action continuation) { }
        public void UnsafeOnCompleted(System.Action continuation) { }
    }
    public readonly partial struct ValueTaskAwaiter<TResult> : System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
    {
        private readonly object _dummy;
        public bool IsCompleted { get { throw null; } }
        public TResult GetResult() { throw null; }
        public void OnCompleted(System.Action continuation) { }
        public void UnsafeOnCompleted(System.Action continuation) { }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public readonly partial struct YieldAwaitable
    {
        public System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter GetAwaiter() { throw null; }
        public readonly partial struct YieldAwaiter : System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
        {
            public bool IsCompleted { get { throw null; } }
            public void GetResult() { }
            public void OnCompleted(System.Action continuation) { }
            public void UnsafeOnCompleted(System.Action continuation) { }
        }
    }
}
