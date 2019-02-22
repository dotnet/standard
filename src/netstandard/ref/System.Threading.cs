// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Threading
{
    public partial class AbandonedMutexException : System.SystemException
    {
        public AbandonedMutexException() { }
        public AbandonedMutexException(int location, System.Threading.WaitHandle handle) { }
        protected AbandonedMutexException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public AbandonedMutexException(string message) { }
        public AbandonedMutexException(string message, System.Exception inner) { }
        public AbandonedMutexException(string message, System.Exception inner, int location, System.Threading.WaitHandle handle) { }
        public AbandonedMutexException(string message, int location, System.Threading.WaitHandle handle) { }
        public System.Threading.Mutex Mutex { get { throw null; } }
        public int MutexIndex { get { throw null; } }
    }
    public enum ApartmentState
    {
        MTA = 1,
        STA = 0,
        Unknown = 2,
    }
    public partial struct AsyncFlowControl : System.IDisposable
    {
        private object _dummy;
        public void Dispose() { }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Threading.AsyncFlowControl obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Threading.AsyncFlowControl a, System.Threading.AsyncFlowControl b) { throw null; }
        public static bool operator !=(System.Threading.AsyncFlowControl a, System.Threading.AsyncFlowControl b) { throw null; }
        public void Undo() { }
    }
    public sealed partial class AsyncLocal<T>
    {
        public AsyncLocal() { }
        public AsyncLocal(System.Action<System.Threading.AsyncLocalValueChangedArgs<T>> valueChangedHandler) { }
        public T Value { get { throw null; } set { } }
    }
    public readonly partial struct AsyncLocalValueChangedArgs<T>
    {
        private readonly T _dummy;
        private readonly int _dummyPrimitive;
        public T CurrentValue { get { throw null; } }
        public T PreviousValue { get { throw null; } }
        public bool ThreadContextChanged { get { throw null; } }
    }
    public sealed partial class AutoResetEvent : System.Threading.EventWaitHandle
    {
        public AutoResetEvent(bool initialState) : base (default(bool), default(System.Threading.EventResetMode)) { }
    }
    public partial class Barrier : System.IDisposable
    {
        public Barrier(int participantCount) { }
        public Barrier(int participantCount, System.Action<System.Threading.Barrier> postPhaseAction) { }
        public long CurrentPhaseNumber { get { throw null; } }
        public int ParticipantCount { get { throw null; } }
        public int ParticipantsRemaining { get { throw null; } }
        public long AddParticipant() { throw null; }
        public long AddParticipants(int participantCount) { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public void RemoveParticipant() { }
        public void RemoveParticipants(int participantCount) { }
        public void SignalAndWait() { }
        public bool SignalAndWait(int millisecondsTimeout) { throw null; }
        public bool SignalAndWait(int millisecondsTimeout, System.Threading.CancellationToken cancellationToken) { throw null; }
        public void SignalAndWait(System.Threading.CancellationToken cancellationToken) { }
        public bool SignalAndWait(System.TimeSpan timeout) { throw null; }
        public bool SignalAndWait(System.TimeSpan timeout, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public partial class BarrierPostPhaseException : System.Exception
    {
        public BarrierPostPhaseException() { }
        public BarrierPostPhaseException(System.Exception innerException) { }
        protected BarrierPostPhaseException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public BarrierPostPhaseException(string message) { }
        public BarrierPostPhaseException(string message, System.Exception innerException) { }
    }
    public readonly partial struct CancellationToken
    {
        private readonly object _dummy;
        public CancellationToken(bool canceled) { throw null; }
        public bool CanBeCanceled { get { throw null; } }
        public bool IsCancellationRequested { get { throw null; } }
        public static System.Threading.CancellationToken None { get { throw null; } }
        public System.Threading.WaitHandle WaitHandle { get { throw null; } }
        public override bool Equals(object other) { throw null; }
        public bool Equals(System.Threading.CancellationToken other) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Threading.CancellationToken left, System.Threading.CancellationToken right) { throw null; }
        public static bool operator !=(System.Threading.CancellationToken left, System.Threading.CancellationToken right) { throw null; }
        public System.Threading.CancellationTokenRegistration Register(System.Action callback) { throw null; }
        public System.Threading.CancellationTokenRegistration Register(System.Action callback, bool useSynchronizationContext) { throw null; }
        public System.Threading.CancellationTokenRegistration Register(System.Action<object> callback, object state) { throw null; }
        public System.Threading.CancellationTokenRegistration Register(System.Action<object> callback, object state, bool useSynchronizationContext) { throw null; }
        public void ThrowIfCancellationRequested() { }
    }
    public readonly partial struct CancellationTokenRegistration : System.IAsyncDisposable, System.IDisposable, System.IEquatable<System.Threading.CancellationTokenRegistration>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public System.Threading.CancellationToken Token { get { throw null; } }
        public void Dispose() { }
        public System.Threading.Tasks.ValueTask DisposeAsync() { throw null; }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Threading.CancellationTokenRegistration other) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Threading.CancellationTokenRegistration left, System.Threading.CancellationTokenRegistration right) { throw null; }
        public static bool operator !=(System.Threading.CancellationTokenRegistration left, System.Threading.CancellationTokenRegistration right) { throw null; }
    }
    public partial class CancellationTokenSource : System.IDisposable
    {
        public CancellationTokenSource() { }
        public CancellationTokenSource(int millisecondsDelay) { }
        public CancellationTokenSource(System.TimeSpan delay) { }
        public bool IsCancellationRequested { get { throw null; } }
        public System.Threading.CancellationToken Token { get { throw null; } }
        public void Cancel() { }
        public void Cancel(bool throwOnFirstException) { }
        public void CancelAfter(int millisecondsDelay) { }
        public void CancelAfter(System.TimeSpan delay) { }
        public static System.Threading.CancellationTokenSource CreateLinkedTokenSource(System.Threading.CancellationToken token1, System.Threading.CancellationToken token2) { throw null; }
        public static System.Threading.CancellationTokenSource CreateLinkedTokenSource(params System.Threading.CancellationToken[] tokens) { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
    }
    public sealed partial class CompressedStack : System.Runtime.Serialization.ISerializable
    {
        internal CompressedStack() { }
        public static System.Threading.CompressedStack Capture() { throw null; }
        public System.Threading.CompressedStack CreateCopy() { throw null; }
        public static System.Threading.CompressedStack GetCompressedStack() { throw null; }
        public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public static void Run(System.Threading.CompressedStack compressedStack, System.Threading.ContextCallback callback, object state) { }
    }
    public delegate void ContextCallback(object state);
    public partial class CountdownEvent : System.IDisposable
    {
        public CountdownEvent(int initialCount) { }
        public int CurrentCount { get { throw null; } }
        public int InitialCount { get { throw null; } }
        public bool IsSet { get { throw null; } }
        public System.Threading.WaitHandle WaitHandle { get { throw null; } }
        public void AddCount() { }
        public void AddCount(int signalCount) { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public void Reset() { }
        public void Reset(int count) { }
        public bool Signal() { throw null; }
        public bool Signal(int signalCount) { throw null; }
        public bool TryAddCount() { throw null; }
        public bool TryAddCount(int signalCount) { throw null; }
        public void Wait() { }
        public bool Wait(int millisecondsTimeout) { throw null; }
        public bool Wait(int millisecondsTimeout, System.Threading.CancellationToken cancellationToken) { throw null; }
        public void Wait(System.Threading.CancellationToken cancellationToken) { }
        public bool Wait(System.TimeSpan timeout) { throw null; }
        public bool Wait(System.TimeSpan timeout, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public enum EventResetMode
    {
        AutoReset = 0,
        ManualReset = 1,
    }
    public partial class EventWaitHandle : System.Threading.WaitHandle
    {
        public EventWaitHandle(bool initialState, System.Threading.EventResetMode mode) { }
        public EventWaitHandle(bool initialState, System.Threading.EventResetMode mode, string name) { }
        public EventWaitHandle(bool initialState, System.Threading.EventResetMode mode, string name, out bool createdNew) { throw null; }
//ACLS        public EventWaitHandle(bool initialState, System.Threading.EventResetMode mode, string name, out bool createdNew, System.Security.AccessControl.EventWaitHandleSecurity eventSecurity) { throw null; }
//ACLS        public System.Security.AccessControl.EventWaitHandleSecurity GetAccessControl() { throw null; }
        public static System.Threading.EventWaitHandle OpenExisting(string name) { throw null; }
//ACLS        public static System.Threading.EventWaitHandle OpenExisting(string name, System.Security.AccessControl.EventWaitHandleRights rights) { throw null; }
        public bool Reset() { throw null; }
        public bool Set() { throw null; }
//ACLS        public void SetAccessControl(System.Security.AccessControl.EventWaitHandleSecurity eventSecurity) { }
//ACLS        public static bool TryOpenExisting(string name, System.Security.AccessControl.EventWaitHandleRights rights, out System.Threading.EventWaitHandle result) { throw null; }
        public static bool TryOpenExisting(string name, out System.Threading.EventWaitHandle result) { throw null; }
    }
    public sealed partial class ExecutionContext : System.IDisposable, System.Runtime.Serialization.ISerializable
    {
        internal ExecutionContext() { }
        public static System.Threading.ExecutionContext Capture() { throw null; }
        public System.Threading.ExecutionContext CreateCopy() { throw null; }
        public void Dispose() { }
        public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public static bool IsFlowSuppressed() { throw null; }
        public static void RestoreFlow() { }
        public static void Run(System.Threading.ExecutionContext executionContext, System.Threading.ContextCallback callback, object state) { }
        public static System.Threading.AsyncFlowControl SuppressFlow() { throw null; }
    }
    public partial class HostExecutionContext : System.IDisposable
    {
        public HostExecutionContext() { }
        public HostExecutionContext(object state) { }
        protected internal object State { get { throw null; } set { } }
        public virtual System.Threading.HostExecutionContext CreateCopy() { throw null; }
        public void Dispose() { }
        public virtual void Dispose(bool disposing) { }
    }
    public partial class HostExecutionContextManager
    {
        public HostExecutionContextManager() { }
        public virtual System.Threading.HostExecutionContext Capture() { throw null; }
        public virtual void Revert(object previousState) { }
        public virtual object SetHostExecutionContext(System.Threading.HostExecutionContext hostExecutionContext) { throw null; }
    }
    public static partial class Interlocked
    {
        public static int Add(ref int location1, int value) { throw null; }
        public static long Add(ref long location1, long value) { throw null; }
        public static double CompareExchange(ref double location1, double value, double comparand) { throw null; }
        public static int CompareExchange(ref int location1, int value, int comparand) { throw null; }
        public static long CompareExchange(ref long location1, long value, long comparand) { throw null; }
        public static System.IntPtr CompareExchange(ref System.IntPtr location1, System.IntPtr value, System.IntPtr comparand) { throw null; }
        public static object CompareExchange(ref object location1, object value, object comparand) { throw null; }
        public static float CompareExchange(ref float location1, float value, float comparand) { throw null; }
        public static T CompareExchange<T>(ref T location1, T value, T comparand) where T : class { throw null; }
        public static int Decrement(ref int location) { throw null; }
        public static long Decrement(ref long location) { throw null; }
        public static double Exchange(ref double location1, double value) { throw null; }
        public static int Exchange(ref int location1, int value) { throw null; }
        public static long Exchange(ref long location1, long value) { throw null; }
        public static System.IntPtr Exchange(ref System.IntPtr location1, System.IntPtr value) { throw null; }
        public static object Exchange(ref object location1, object value) { throw null; }
        public static float Exchange(ref float location1, float value) { throw null; }
        public static T Exchange<T>(ref T location1, T value) where T : class { throw null; }
        public static int Increment(ref int location) { throw null; }
        public static long Increment(ref long location) { throw null; }
        public static void MemoryBarrier() { }
        public static void MemoryBarrierProcessWide() { }
        public static long Read(ref long location) { throw null; }
    }
    [System.CLSCompliantAttribute(false)]
    public unsafe delegate void IOCompletionCallback(uint errorCode, uint numBytes, System.Threading.NativeOverlapped* pOVERLAP);
    public static partial class LazyInitializer
    {
        public static T EnsureInitialized<T>(ref T target) where T : class { throw null; }
        public static T EnsureInitialized<T>(ref T target, ref bool initialized, ref object syncLock) { throw null; }
        public static T EnsureInitialized<T>(ref T target, ref bool initialized, ref object syncLock, System.Func<T> valueFactory) { throw null; }
        public static T EnsureInitialized<T>(ref T target, System.Func<T> valueFactory) where T : class { throw null; }
        public static T EnsureInitialized<T>(ref T target, ref object syncLock, System.Func<T> valueFactory) where T : class { throw null; }
    }
    public enum LazyThreadSafetyMode
    {
        ExecutionAndPublication = 2,
        None = 0,
        PublicationOnly = 1,
    }
    public partial struct LockCookie
    {
        private int _dummyPrimitive;
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Threading.LockCookie obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Threading.LockCookie a, System.Threading.LockCookie b) { throw null; }
        public static bool operator !=(System.Threading.LockCookie a, System.Threading.LockCookie b) { throw null; }
    }
    public partial class LockRecursionException : System.Exception
    {
        public LockRecursionException() { }
        protected LockRecursionException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public LockRecursionException(string message) { }
        public LockRecursionException(string message, System.Exception innerException) { }
    }
    public enum LockRecursionPolicy
    {
        NoRecursion = 0,
        SupportsRecursion = 1,
    }
    public sealed partial class ManualResetEvent : System.Threading.EventWaitHandle
    {
        public ManualResetEvent(bool initialState) : base (default(bool), default(System.Threading.EventResetMode)) { }
    }
    public partial class ManualResetEventSlim : System.IDisposable
    {
        public ManualResetEventSlim() { }
        public ManualResetEventSlim(bool initialState) { }
        public ManualResetEventSlim(bool initialState, int spinCount) { }
        public bool IsSet { get { throw null; } }
        public int SpinCount { get { throw null; } }
        public System.Threading.WaitHandle WaitHandle { get { throw null; } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public void Reset() { }
        public void Set() { }
        public void Wait() { }
        public bool Wait(int millisecondsTimeout) { throw null; }
        public bool Wait(int millisecondsTimeout, System.Threading.CancellationToken cancellationToken) { throw null; }
        public void Wait(System.Threading.CancellationToken cancellationToken) { }
        public bool Wait(System.TimeSpan timeout) { throw null; }
        public bool Wait(System.TimeSpan timeout, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public static partial class Monitor
    {
        public static void Enter(object obj) { }
        public static void Enter(object obj, ref bool lockTaken) { }
        public static void Exit(object obj) { }
        public static bool IsEntered(object obj) { throw null; }
        public static void Pulse(object obj) { }
        public static void PulseAll(object obj) { }
        public static bool TryEnter(object obj) { throw null; }
        public static void TryEnter(object obj, ref bool lockTaken) { }
        public static bool TryEnter(object obj, int millisecondsTimeout) { throw null; }
        public static void TryEnter(object obj, int millisecondsTimeout, ref bool lockTaken) { }
        public static bool TryEnter(object obj, System.TimeSpan timeout) { throw null; }
        public static void TryEnter(object obj, System.TimeSpan timeout, ref bool lockTaken) { }
        public static bool Wait(object obj) { throw null; }
        public static bool Wait(object obj, int millisecondsTimeout) { throw null; }
        public static bool Wait(object obj, int millisecondsTimeout, bool exitContext) { throw null; }
        public static bool Wait(object obj, System.TimeSpan timeout) { throw null; }
        public static bool Wait(object obj, System.TimeSpan timeout, bool exitContext) { throw null; }
    }
    public sealed partial class Mutex : System.Threading.WaitHandle
    {
        public Mutex() { }
        public Mutex(bool initiallyOwned) { }
        public Mutex(bool initiallyOwned, string name) { }
        public Mutex(bool initiallyOwned, string name, out bool createdNew) { throw null; }
//ACLS        public Mutex(bool initiallyOwned, string name, out bool createdNew, System.Security.AccessControl.MutexSecurity mutexSecurity) { throw null; }
//ACLS        public System.Security.AccessControl.MutexSecurity GetAccessControl() { throw null; }
        public static System.Threading.Mutex OpenExisting(string name) { throw null; }
//ACLS        public static System.Threading.Mutex OpenExisting(string name, System.Security.AccessControl.MutexRights rights) { throw null; }
        public void ReleaseMutex() { }
//ACLS        public void SetAccessControl(System.Security.AccessControl.MutexSecurity mutexSecurity) { }
//ACLS        public static bool TryOpenExisting(string name, System.Security.AccessControl.MutexRights rights, out System.Threading.Mutex result) { throw null; }
        public static bool TryOpenExisting(string name, out System.Threading.Mutex result) { throw null; }
    }
    public partial struct NativeOverlapped
    {
        public System.IntPtr EventHandle;
        public System.IntPtr InternalHigh;
        public System.IntPtr InternalLow;
        public int OffsetHigh;
        public int OffsetLow;
    }
    public partial class Overlapped
    {
        public Overlapped() { }
        [System.ObsoleteAttribute("This constructor is not 64-bit compatible.  Use the constructor that takes an IntPtr for the event handle.  https://go.microsoft.com/fwlink/?linkid=14202")]
        public Overlapped(int offsetLo, int offsetHi, int hEvent, System.IAsyncResult ar) { }
        public Overlapped(int offsetLo, int offsetHi, System.IntPtr hEvent, System.IAsyncResult ar) { }
        public System.IAsyncResult AsyncResult { get { throw null; } set { } }
        [System.ObsoleteAttribute("This property is not 64-bit compatible.  Use EventHandleIntPtr instead.  https://go.microsoft.com/fwlink/?linkid=14202")]
        public int EventHandle { get { throw null; } set { } }
        public System.IntPtr EventHandleIntPtr { get { throw null; } set { } }
        public int OffsetHigh { get { throw null; } set { } }
        public int OffsetLow { get { throw null; } set { } }
        [System.CLSCompliantAttribute(false)]
        public unsafe static void Free(System.Threading.NativeOverlapped* nativeOverlappedPtr) { }
        [System.CLSCompliantAttribute(false)]
        [System.ObsoleteAttribute("This method is not safe.  Use Pack (iocb, userData) instead.  https://go.microsoft.com/fwlink/?linkid=14202")]
        public unsafe System.Threading.NativeOverlapped* Pack(System.Threading.IOCompletionCallback iocb) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public unsafe System.Threading.NativeOverlapped* Pack(System.Threading.IOCompletionCallback iocb, object userData) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public unsafe static System.Threading.Overlapped Unpack(System.Threading.NativeOverlapped* nativeOverlappedPtr) { throw null; }
        [System.CLSCompliantAttribute(false)]
        [System.ObsoleteAttribute("This method is not safe.  Use UnsafePack (iocb, userData) instead.  https://go.microsoft.com/fwlink/?linkid=14202")]
        public unsafe System.Threading.NativeOverlapped* UnsafePack(System.Threading.IOCompletionCallback iocb) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public unsafe System.Threading.NativeOverlapped* UnsafePack(System.Threading.IOCompletionCallback iocb, object userData) { throw null; }
    }
    public delegate void ParameterizedThreadStart(object obj);
    public sealed partial class PreAllocatedOverlapped : System.IDisposable
    {
        [System.CLSCompliantAttribute(false)]
        public PreAllocatedOverlapped(System.Threading.IOCompletionCallback callback, object state, object pinData) { }
        public void Dispose() { }
    }
    public sealed partial class ReaderWriterLock : System.Runtime.ConstrainedExecution.CriticalFinalizerObject
    {
        public ReaderWriterLock() { }
        public bool IsReaderLockHeld { get { throw null; } }
        public bool IsWriterLockHeld { get { throw null; } }
        public int WriterSeqNum { get { throw null; } }
        public void AcquireReaderLock(int millisecondsTimeout) { }
        public void AcquireReaderLock(System.TimeSpan timeout) { }
        public void AcquireWriterLock(int millisecondsTimeout) { }
        public void AcquireWriterLock(System.TimeSpan timeout) { }
        public bool AnyWritersSince(int seqNum) { throw null; }
        public void DowngradeFromWriterLock(ref System.Threading.LockCookie lockCookie) { }
        public System.Threading.LockCookie ReleaseLock() { throw null; }
        public void ReleaseReaderLock() { }
        public void ReleaseWriterLock() { }
        public void RestoreLock(ref System.Threading.LockCookie lockCookie) { }
        public System.Threading.LockCookie UpgradeToWriterLock(int millisecondsTimeout) { throw null; }
        public System.Threading.LockCookie UpgradeToWriterLock(System.TimeSpan timeout) { throw null; }
    }
    public partial class ReaderWriterLockSlim : System.IDisposable
    {
        public ReaderWriterLockSlim() { }
        public ReaderWriterLockSlim(System.Threading.LockRecursionPolicy recursionPolicy) { }
        public int CurrentReadCount { get { throw null; } }
        public bool IsReadLockHeld { get { throw null; } }
        public bool IsUpgradeableReadLockHeld { get { throw null; } }
        public bool IsWriteLockHeld { get { throw null; } }
        public System.Threading.LockRecursionPolicy RecursionPolicy { get { throw null; } }
        public int RecursiveReadCount { get { throw null; } }
        public int RecursiveUpgradeCount { get { throw null; } }
        public int RecursiveWriteCount { get { throw null; } }
        public int WaitingReadCount { get { throw null; } }
        public int WaitingUpgradeCount { get { throw null; } }
        public int WaitingWriteCount { get { throw null; } }
        public void Dispose() { }
        public void EnterReadLock() { }
        public void EnterUpgradeableReadLock() { }
        public void EnterWriteLock() { }
        public void ExitReadLock() { }
        public void ExitUpgradeableReadLock() { }
        public void ExitWriteLock() { }
        public bool TryEnterReadLock(int millisecondsTimeout) { throw null; }
        public bool TryEnterReadLock(System.TimeSpan timeout) { throw null; }
        public bool TryEnterUpgradeableReadLock(int millisecondsTimeout) { throw null; }
        public bool TryEnterUpgradeableReadLock(System.TimeSpan timeout) { throw null; }
        public bool TryEnterWriteLock(int millisecondsTimeout) { throw null; }
        public bool TryEnterWriteLock(System.TimeSpan timeout) { throw null; }
    }
    public sealed partial class RegisteredWaitHandle : System.MarshalByRefObject
    {
        internal RegisteredWaitHandle() { }
        public bool Unregister(System.Threading.WaitHandle waitObject) { throw null; }
    }
    public sealed partial class Semaphore : System.Threading.WaitHandle
    {
        public Semaphore(int initialCount, int maximumCount) { }
        public Semaphore(int initialCount, int maximumCount, string name) { }
        public Semaphore(int initialCount, int maximumCount, string name, out bool createdNew) { throw null; }
//ACLS        public Semaphore(int initialCount, int maximumCount, string name, out bool createdNew, System.Security.AccessControl.SemaphoreSecurity semaphoreSecurity) { throw null; }
//ACLS        public System.Security.AccessControl.SemaphoreSecurity GetAccessControl() { throw null; }
        public static System.Threading.Semaphore OpenExisting(string name) { throw null; }
//ACLS        public static System.Threading.Semaphore OpenExisting(string name, System.Security.AccessControl.SemaphoreRights rights) { throw null; }
        [System.Runtime.ConstrainedExecution.PrePrepareMethodAttribute]
        public int Release() { throw null; }
        public int Release(int releaseCount) { throw null; }
//ACLS        public void SetAccessControl(System.Security.AccessControl.SemaphoreSecurity semaphoreSecurity) { }
//ACLS        public static bool TryOpenExisting(string name, System.Security.AccessControl.SemaphoreRights rights, out System.Threading.Semaphore result) { throw null; }
        public static bool TryOpenExisting(string name, out System.Threading.Semaphore result) { throw null; }
    }
    public partial class SemaphoreFullException : System.SystemException
    {
        public SemaphoreFullException() { }
        protected SemaphoreFullException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public SemaphoreFullException(string message) { }
        public SemaphoreFullException(string message, System.Exception innerException) { }
    }
    public partial class SemaphoreSlim : System.IDisposable
    {
        public SemaphoreSlim(int initialCount) { }
        public SemaphoreSlim(int initialCount, int maxCount) { }
        public System.Threading.WaitHandle AvailableWaitHandle { get { throw null; } }
        public int CurrentCount { get { throw null; } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public int Release() { throw null; }
        public int Release(int releaseCount) { throw null; }
        public void Wait() { }
        public bool Wait(int millisecondsTimeout) { throw null; }
        public bool Wait(int millisecondsTimeout, System.Threading.CancellationToken cancellationToken) { throw null; }
        public void Wait(System.Threading.CancellationToken cancellationToken) { }
        public bool Wait(System.TimeSpan timeout) { throw null; }
        public bool Wait(System.TimeSpan timeout, System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task WaitAsync() { throw null; }
        public System.Threading.Tasks.Task<bool> WaitAsync(int millisecondsTimeout) { throw null; }
        public System.Threading.Tasks.Task<bool> WaitAsync(int millisecondsTimeout, System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task WaitAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task<bool> WaitAsync(System.TimeSpan timeout) { throw null; }
        public System.Threading.Tasks.Task<bool> WaitAsync(System.TimeSpan timeout, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public delegate void SendOrPostCallback(object state);
    public partial struct SpinLock
    {
        private int _dummyPrimitive;
        public SpinLock(bool enableThreadOwnerTracking) { throw null; }
        public bool IsHeld { get { throw null; } }
        public bool IsHeldByCurrentThread { get { throw null; } }
        public bool IsThreadOwnerTrackingEnabled { get { throw null; } }
        public void Enter(ref bool lockTaken) { }
        public void Exit() { }
        public void Exit(bool useMemoryBarrier) { }
        public void TryEnter(ref bool lockTaken) { }
        public void TryEnter(int millisecondsTimeout, ref bool lockTaken) { }
        public void TryEnter(System.TimeSpan timeout, ref bool lockTaken) { }
    }
    public partial struct SpinWait
    {
        private int _dummyPrimitive;
        public int Count { get { throw null; } }
        public bool NextSpinWillYield { get { throw null; } }
        public void Reset() { }
        public void SpinOnce() { }
        public static void SpinUntil(System.Func<bool> condition) { }
        public static bool SpinUntil(System.Func<bool> condition, int millisecondsTimeout) { throw null; }
        public static bool SpinUntil(System.Func<bool> condition, System.TimeSpan timeout) { throw null; }
    }
    public partial class SynchronizationContext
    {
        public SynchronizationContext() { }
        public static System.Threading.SynchronizationContext Current { get { throw null; } }
        public virtual System.Threading.SynchronizationContext CreateCopy() { throw null; }
        public bool IsWaitNotificationRequired() { throw null; }
        public virtual void OperationCompleted() { }
        public virtual void OperationStarted() { }
        public virtual void Post(System.Threading.SendOrPostCallback d, object state) { }
        public virtual void Send(System.Threading.SendOrPostCallback d, object state) { }
        public static void SetSynchronizationContext(System.Threading.SynchronizationContext syncContext) { }
        protected void SetWaitNotificationRequired() { }
        [System.CLSCompliantAttribute(false)]
        [System.Runtime.ConstrainedExecution.PrePrepareMethodAttribute]
        public virtual int Wait(System.IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout) { throw null; }
        [System.CLSCompliantAttribute(false)]
        [System.Runtime.ConstrainedExecution.PrePrepareMethodAttribute]
        protected static int WaitHelper(System.IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout) { throw null; }
    }
    public partial class SynchronizationLockException : System.SystemException
    {
        public SynchronizationLockException() { }
        protected SynchronizationLockException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public SynchronizationLockException(string message) { }
        public SynchronizationLockException(string message, System.Exception innerException) { }
    }
    public sealed partial class Thread : System.Runtime.ConstrainedExecution.CriticalFinalizerObject
    {
        public Thread(System.Threading.ParameterizedThreadStart start) { }
        public Thread(System.Threading.ParameterizedThreadStart start, int maxStackSize) { }
        public Thread(System.Threading.ThreadStart start) { }
        public Thread(System.Threading.ThreadStart start, int maxStackSize) { }
        [System.ObsoleteAttribute("The ApartmentState property has been deprecated.  Use GetApartmentState, SetApartmentState or TrySetApartmentState instead.", false)]
        public System.Threading.ApartmentState ApartmentState { get { throw null; } set { } }
//REMOTING        public static System.Runtime.Remoting.Contexts.Context CurrentContext { get { throw null; } }
        public System.Globalization.CultureInfo CurrentCulture { get { throw null; } set { } }
        public static System.Security.Principal.IPrincipal CurrentPrincipal { get { throw null; } set { } }
        public static System.Threading.Thread CurrentThread { get { throw null; } }
        public System.Globalization.CultureInfo CurrentUICulture { get { throw null; } set { } }
        public System.Threading.ExecutionContext ExecutionContext { get { throw null; } }
        public bool IsAlive { get { throw null; } }
        public bool IsBackground { get { throw null; } set { } }
        public bool IsThreadPoolThread { get { throw null; } }
        public int ManagedThreadId { get { throw null; } }
        public string Name { get { throw null; } set { } }
        public System.Threading.ThreadPriority Priority { get { throw null; } set { } }
        public System.Threading.ThreadState ThreadState { get { throw null; } }
        public void Abort() { }
        public void Abort(object stateInfo) { }
        public static System.LocalDataStoreSlot AllocateDataSlot() { throw null; }
        public static System.LocalDataStoreSlot AllocateNamedDataSlot(string name) { throw null; }
        public static void BeginCriticalRegion() { }
        public static void BeginThreadAffinity() { }
        public void DisableComObjectEagerCleanup() { }
        public static void EndCriticalRegion() { }
        public static void EndThreadAffinity() { }
        public static void FreeNamedDataSlot(string name) { }
        public System.Threading.ApartmentState GetApartmentState() { throw null; }
        [System.ObsoleteAttribute("Thread.GetCompressedStack is no longer supported. Please use the System.Threading.CompressedStack class")]
        public System.Threading.CompressedStack GetCompressedStack() { throw null; }
        public static int GetCurrentProcessorId() { throw null; }
        public static object GetData(System.LocalDataStoreSlot slot) { throw null; }
        public static System.AppDomain GetDomain() { throw null; }
        public static int GetDomainID() { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.LocalDataStoreSlot GetNamedDataSlot(string name) { throw null; }
        public void Interrupt() { }
        public void Join() { }
        public bool Join(int millisecondsTimeout) { throw null; }
        public bool Join(System.TimeSpan timeout) { throw null; }
        public static void MemoryBarrier() { }
        public static void ResetAbort() { }
        [System.ObsoleteAttribute("Thread.Resume has been deprecated.  Please use other classes in System.Threading, such as Monitor, Mutex, Event, and Semaphore, to synchronize Threads or protect resources.  https://go.microsoft.com/fwlink/?linkid=14202", false)]
        public void Resume() { }
        public void SetApartmentState(System.Threading.ApartmentState state) { }
        [System.ObsoleteAttribute("Thread.SetCompressedStack is no longer supported. Please use the System.Threading.CompressedStack class")]
        public void SetCompressedStack(System.Threading.CompressedStack stack) { }
        public static void SetData(System.LocalDataStoreSlot slot, object data) { }
        public static void Sleep(int millisecondsTimeout) { }
        public static void Sleep(System.TimeSpan timeout) { }
        public static void SpinWait(int iterations) { }
        public void Start() { }
        public void Start(object parameter) { }
        [System.ObsoleteAttribute("Thread.Suspend has been deprecated.  Please use other classes in System.Threading, such as Monitor, Mutex, Event, and Semaphore, to synchronize Threads or protect resources.  https://go.microsoft.com/fwlink/?linkid=14202", false)]
        public void Suspend() { }
        public bool TrySetApartmentState(System.Threading.ApartmentState state) { throw null; }
        public static byte VolatileRead(ref byte address) { throw null; }
        public static double VolatileRead(ref double address) { throw null; }
        public static short VolatileRead(ref short address) { throw null; }
        public static int VolatileRead(ref int address) { throw null; }
        public static long VolatileRead(ref long address) { throw null; }
        public static System.IntPtr VolatileRead(ref System.IntPtr address) { throw null; }
        public static object VolatileRead(ref object address) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static sbyte VolatileRead(ref sbyte address) { throw null; }
        public static float VolatileRead(ref float address) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ushort VolatileRead(ref ushort address) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static uint VolatileRead(ref uint address) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ulong VolatileRead(ref ulong address) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.UIntPtr VolatileRead(ref System.UIntPtr address) { throw null; }
        public static void VolatileWrite(ref byte address, byte value) { }
        public static void VolatileWrite(ref double address, double value) { }
        public static void VolatileWrite(ref short address, short value) { }
        public static void VolatileWrite(ref int address, int value) { }
        public static void VolatileWrite(ref long address, long value) { }
        public static void VolatileWrite(ref System.IntPtr address, System.IntPtr value) { }
        public static void VolatileWrite(ref object address, object value) { }
        [System.CLSCompliantAttribute(false)]
        public static void VolatileWrite(ref sbyte address, sbyte value) { }
        public static void VolatileWrite(ref float address, float value) { }
        [System.CLSCompliantAttribute(false)]
        public static void VolatileWrite(ref ushort address, ushort value) { }
        [System.CLSCompliantAttribute(false)]
        public static void VolatileWrite(ref uint address, uint value) { }
        [System.CLSCompliantAttribute(false)]
        public static void VolatileWrite(ref ulong address, ulong value) { }
        [System.CLSCompliantAttribute(false)]
        public static void VolatileWrite(ref System.UIntPtr address, System.UIntPtr value) { }
        public static bool Yield() { throw null; }
    }
    public sealed partial class ThreadAbortException : System.SystemException
    {
        internal ThreadAbortException() { }
        public object ExceptionState { get { throw null; } }
    }
    public partial class ThreadExceptionEventArgs : System.EventArgs
    {
        public ThreadExceptionEventArgs(System.Exception t) { }
        public System.Exception Exception { get { throw null; } }
    }
    public delegate void ThreadExceptionEventHandler(object sender, System.Threading.ThreadExceptionEventArgs e);
    public partial class ThreadInterruptedException : System.SystemException
    {
        public ThreadInterruptedException() { }
        protected ThreadInterruptedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public ThreadInterruptedException(string message) { }
        public ThreadInterruptedException(string message, System.Exception innerException) { }
    }
    public partial class ThreadLocal<T> : System.IDisposable
    {
        public ThreadLocal() { }
        public ThreadLocal(bool trackAllValues) { }
        public ThreadLocal(System.Func<T> valueFactory) { }
        public ThreadLocal(System.Func<T> valueFactory, bool trackAllValues) { }
        public bool IsValueCreated { get { throw null; } }
        public T Value { get { throw null; } set { } }
        public System.Collections.Generic.IList<T> Values { get { throw null; } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        ~ThreadLocal() { }
        public override string ToString() { throw null; }
    }
    public static partial class ThreadPool
    {
        [System.ObsoleteAttribute("ThreadPool.BindHandle(IntPtr) has been deprecated.  Please use ThreadPool.BindHandle(SafeHandle) instead.", false)]
        public static bool BindHandle(System.IntPtr osHandle) { throw null; }
        public static bool BindHandle(System.Runtime.InteropServices.SafeHandle osHandle) { throw null; }
        public static void GetAvailableThreads(out int workerThreads, out int completionPortThreads) { throw null; }
        public static void GetMaxThreads(out int workerThreads, out int completionPortThreads) { throw null; }
        public static void GetMinThreads(out int workerThreads, out int completionPortThreads) { throw null; }
        public static bool QueueUserWorkItem(System.Threading.WaitCallback callBack) { throw null; }
        public static bool QueueUserWorkItem(System.Threading.WaitCallback callBack, object state) { throw null; }
        public static bool QueueUserWorkItem<TState>(System.Action<TState> callBack, TState state, bool preferLocal) { throw null; }
        public static System.Threading.RegisteredWaitHandle RegisterWaitForSingleObject(System.Threading.WaitHandle waitObject, System.Threading.WaitOrTimerCallback callBack, object state, int millisecondsTimeOutInterval, bool executeOnlyOnce) { throw null; }
        public static System.Threading.RegisteredWaitHandle RegisterWaitForSingleObject(System.Threading.WaitHandle waitObject, System.Threading.WaitOrTimerCallback callBack, object state, long millisecondsTimeOutInterval, bool executeOnlyOnce) { throw null; }
        public static System.Threading.RegisteredWaitHandle RegisterWaitForSingleObject(System.Threading.WaitHandle waitObject, System.Threading.WaitOrTimerCallback callBack, object state, System.TimeSpan timeout, bool executeOnlyOnce) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Threading.RegisteredWaitHandle RegisterWaitForSingleObject(System.Threading.WaitHandle waitObject, System.Threading.WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce) { throw null; }
        public static bool SetMaxThreads(int workerThreads, int completionPortThreads) { throw null; }
        public static bool SetMinThreads(int workerThreads, int completionPortThreads) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public unsafe static bool UnsafeQueueNativeOverlapped(System.Threading.NativeOverlapped* overlapped) { throw null; }
        public static bool UnsafeQueueUserWorkItem(System.Threading.WaitCallback callBack, object state) { throw null; }
        public static System.Threading.RegisteredWaitHandle UnsafeRegisterWaitForSingleObject(System.Threading.WaitHandle waitObject, System.Threading.WaitOrTimerCallback callBack, object state, int millisecondsTimeOutInterval, bool executeOnlyOnce) { throw null; }
        public static System.Threading.RegisteredWaitHandle UnsafeRegisterWaitForSingleObject(System.Threading.WaitHandle waitObject, System.Threading.WaitOrTimerCallback callBack, object state, long millisecondsTimeOutInterval, bool executeOnlyOnce) { throw null; }
        public static System.Threading.RegisteredWaitHandle UnsafeRegisterWaitForSingleObject(System.Threading.WaitHandle waitObject, System.Threading.WaitOrTimerCallback callBack, object state, System.TimeSpan timeout, bool executeOnlyOnce) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Threading.RegisteredWaitHandle UnsafeRegisterWaitForSingleObject(System.Threading.WaitHandle waitObject, System.Threading.WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce) { throw null; }
    }
    public sealed partial class ThreadPoolBoundHandle : System.IDisposable
    {
        internal ThreadPoolBoundHandle() { }
        public System.Runtime.InteropServices.SafeHandle Handle { get { throw null; } }
        [System.CLSCompliantAttribute(false)]
        public unsafe System.Threading.NativeOverlapped* AllocateNativeOverlapped(System.Threading.IOCompletionCallback callback, object state, object pinData) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public unsafe System.Threading.NativeOverlapped* AllocateNativeOverlapped(System.Threading.PreAllocatedOverlapped preAllocated) { throw null; }
        public static System.Threading.ThreadPoolBoundHandle BindHandle(System.Runtime.InteropServices.SafeHandle handle) { throw null; }
        public void Dispose() { }
        [System.CLSCompliantAttribute(false)]
        public unsafe void FreeNativeOverlapped(System.Threading.NativeOverlapped* overlapped) { }
        [System.CLSCompliantAttribute(false)]
        public unsafe static object GetNativeOverlappedState(System.Threading.NativeOverlapped* overlapped) { throw null; }
    }
    public enum ThreadPriority
    {
        AboveNormal = 3,
        BelowNormal = 1,
        Highest = 4,
        Lowest = 0,
        Normal = 2,
    }
    public delegate void ThreadStart();
    public sealed partial class ThreadStartException : System.SystemException
    {
        internal ThreadStartException() { }
    }
    [System.FlagsAttribute]
    public enum ThreadState
    {
        Aborted = 256,
        AbortRequested = 128,
        Background = 4,
        Running = 0,
        Stopped = 16,
        StopRequested = 1,
        Suspended = 64,
        SuspendRequested = 2,
        Unstarted = 8,
        WaitSleepJoin = 32,
    }
    public partial class ThreadStateException : System.SystemException
    {
        public ThreadStateException() { }
        protected ThreadStateException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public ThreadStateException(string message) { }
        public ThreadStateException(string message, System.Exception innerException) { }
    }
    public static partial class Timeout
    {
        public const int Infinite = -1;
        public static readonly System.TimeSpan InfiniteTimeSpan;
    }
    public sealed partial class Timer : System.MarshalByRefObject, System.IAsyncDisposable, System.IDisposable
    {
        public Timer(System.Threading.TimerCallback callback) { }
        public Timer(System.Threading.TimerCallback callback, object state, int dueTime, int period) { }
        public Timer(System.Threading.TimerCallback callback, object state, long dueTime, long period) { }
        public Timer(System.Threading.TimerCallback callback, object state, System.TimeSpan dueTime, System.TimeSpan period) { }
        [System.CLSCompliantAttribute(false)]
        public Timer(System.Threading.TimerCallback callback, object state, uint dueTime, uint period) { }
        public bool Change(int dueTime, int period) { throw null; }
        public bool Change(long dueTime, long period) { throw null; }
        public bool Change(System.TimeSpan dueTime, System.TimeSpan period) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public bool Change(uint dueTime, uint period) { throw null; }
        public void Dispose() { }
        public bool Dispose(System.Threading.WaitHandle notifyObject) { throw null; }
        public System.Threading.Tasks.ValueTask DisposeAsync() { throw null; }
    }
    public delegate void TimerCallback(object state);
    public static partial class Volatile
    {
        public static bool Read(ref bool location) { throw null; }
        public static byte Read(ref byte location) { throw null; }
        public static double Read(ref double location) { throw null; }
        public static short Read(ref short location) { throw null; }
        public static int Read(ref int location) { throw null; }
        public static long Read(ref long location) { throw null; }
        public static System.IntPtr Read(ref System.IntPtr location) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static sbyte Read(ref sbyte location) { throw null; }
        public static float Read(ref float location) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ushort Read(ref ushort location) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static uint Read(ref uint location) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ulong Read(ref ulong location) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.UIntPtr Read(ref System.UIntPtr location) { throw null; }
        public static T Read<T>(ref T location) where T : class { throw null; }
        public static void Write(ref bool location, bool value) { }
        public static void Write(ref byte location, byte value) { }
        public static void Write(ref double location, double value) { }
        public static void Write(ref short location, short value) { }
        public static void Write(ref int location, int value) { }
        public static void Write(ref long location, long value) { }
        public static void Write(ref System.IntPtr location, System.IntPtr value) { }
        [System.CLSCompliantAttribute(false)]
        public static void Write(ref sbyte location, sbyte value) { }
        public static void Write(ref float location, float value) { }
        [System.CLSCompliantAttribute(false)]
        public static void Write(ref ushort location, ushort value) { }
        [System.CLSCompliantAttribute(false)]
        public static void Write(ref uint location, uint value) { }
        [System.CLSCompliantAttribute(false)]
        public static void Write(ref ulong location, ulong value) { }
        [System.CLSCompliantAttribute(false)]
        public static void Write(ref System.UIntPtr location, System.UIntPtr value) { }
        public static void Write<T>(ref T location, T value) where T : class { }
    }
    public delegate void WaitCallback(object state);
    public abstract partial class WaitHandle : System.MarshalByRefObject, System.IDisposable
    {
        protected static readonly System.IntPtr InvalidHandle;
        public const int WaitTimeout = 258;
        protected WaitHandle() { }
        [System.ObsoleteAttribute("Use the SafeWaitHandle property instead.")]
        public virtual System.IntPtr Handle { get { throw null; } set { } }
        public Microsoft.Win32.SafeHandles.SafeWaitHandle SafeWaitHandle { get { throw null; } set { } }
        public virtual void Close() { }
        public void Dispose() { }
        protected virtual void Dispose(bool explicitDisposing) { }
        public static bool SignalAndWait(System.Threading.WaitHandle toSignal, System.Threading.WaitHandle toWaitOn) { throw null; }
        public static bool SignalAndWait(System.Threading.WaitHandle toSignal, System.Threading.WaitHandle toWaitOn, int millisecondsTimeout, bool exitContext) { throw null; }
        public static bool SignalAndWait(System.Threading.WaitHandle toSignal, System.Threading.WaitHandle toWaitOn, System.TimeSpan timeout, bool exitContext) { throw null; }
        public static bool WaitAll(System.Threading.WaitHandle[] waitHandles) { throw null; }
        public static bool WaitAll(System.Threading.WaitHandle[] waitHandles, int millisecondsTimeout) { throw null; }
        public static bool WaitAll(System.Threading.WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext) { throw null; }
        public static bool WaitAll(System.Threading.WaitHandle[] waitHandles, System.TimeSpan timeout) { throw null; }
        public static bool WaitAll(System.Threading.WaitHandle[] waitHandles, System.TimeSpan timeout, bool exitContext) { throw null; }
        public static int WaitAny(System.Threading.WaitHandle[] waitHandles) { throw null; }
        public static int WaitAny(System.Threading.WaitHandle[] waitHandles, int millisecondsTimeout) { throw null; }
        public static int WaitAny(System.Threading.WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext) { throw null; }
        public static int WaitAny(System.Threading.WaitHandle[] waitHandles, System.TimeSpan timeout) { throw null; }
        public static int WaitAny(System.Threading.WaitHandle[] waitHandles, System.TimeSpan timeout, bool exitContext) { throw null; }
        public virtual bool WaitOne() { throw null; }
        public virtual bool WaitOne(int millisecondsTimeout) { throw null; }
        public virtual bool WaitOne(int millisecondsTimeout, bool exitContext) { throw null; }
        public virtual bool WaitOne(System.TimeSpan timeout) { throw null; }
        public virtual bool WaitOne(System.TimeSpan timeout, bool exitContext) { throw null; }
    }
    public partial class WaitHandleCannotBeOpenedException : System.ApplicationException
    {
        public WaitHandleCannotBeOpenedException() { }
        protected WaitHandleCannotBeOpenedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public WaitHandleCannotBeOpenedException(string message) { }
        public WaitHandleCannotBeOpenedException(string message, System.Exception innerException) { }
    }
    public static partial class WaitHandleExtensions
    {
        public static Microsoft.Win32.SafeHandles.SafeWaitHandle GetSafeWaitHandle(this System.Threading.WaitHandle waitHandle) { throw null; }
        public static void SetSafeWaitHandle(this System.Threading.WaitHandle waitHandle, Microsoft.Win32.SafeHandles.SafeWaitHandle value) { }
    }
    public delegate void WaitOrTimerCallback(object state, bool timedOut);
}
