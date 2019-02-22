// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Threading.Tasks.Sources
{
    public partial interface IValueTaskSource
    {
        void GetResult(short token);
        System.Threading.Tasks.Sources.ValueTaskSourceStatus GetStatus(short token);
        void OnCompleted(System.Action<object> continuation, object state, short token, System.Threading.Tasks.Sources.ValueTaskSourceOnCompletedFlags flags);
    }
    public partial interface IValueTaskSource<out TResult>
    {
        TResult GetResult(short token);
        System.Threading.Tasks.Sources.ValueTaskSourceStatus GetStatus(short token);
        void OnCompleted(System.Action<object> continuation, object state, short token, System.Threading.Tasks.Sources.ValueTaskSourceOnCompletedFlags flags);
    }
    public partial struct ManualResetValueTaskSourceCore<TResult>
    {
        private TResult _result;
        private object _dummy;
        private int _dummyPrimitive;
        public bool RunContinuationsAsynchronously { get { throw null; } set { } }
        public short Version { get { throw null; } }
        public TResult GetResult(short token) { throw null; }
        public System.Threading.Tasks.Sources.ValueTaskSourceStatus GetStatus(short token) { throw null; }
        public void OnCompleted(System.Action<object> continuation, object state, short token, System.Threading.Tasks.Sources.ValueTaskSourceOnCompletedFlags flags) { }
        public void Reset() { }
        public void SetException(System.Exception error) { }
        public void SetResult(TResult result) { }
    }
    [System.FlagsAttribute]
    public enum ValueTaskSourceOnCompletedFlags
    {
        FlowExecutionContext = 2,
        None = 0,
        UseSchedulingContext = 1,
    }
    public enum ValueTaskSourceStatus
    {
        Canceled = 3,
        Faulted = 2,
        Pending = 0,
        Succeeded = 1,
    }
}
