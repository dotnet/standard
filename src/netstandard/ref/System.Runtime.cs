// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Runtime
{
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, Inherited=false)]
    public sealed partial class AssemblyTargetedPatchBandAttribute : System.Attribute
    {
        public AssemblyTargetedPatchBandAttribute(string targetedPatchBand) { }
        public string TargetedPatchBand { get { throw null; } }
    }
    public enum GCLargeObjectHeapCompactionMode
    {
        CompactOnce = 2,
        Default = 1,
    }
    public enum GCLatencyMode
    {
        Batch = 0,
        Interactive = 1,
        LowLatency = 2,
        NoGCRegion = 4,
        SustainedLowLatency = 3,
    }
    public static partial class GCSettings
    {
        public static bool IsServerGC { get { throw null; } }
        public static System.Runtime.GCLargeObjectHeapCompactionMode LargeObjectHeapCompactionMode { get { throw null; } set { } }
        public static System.Runtime.GCLatencyMode LatencyMode { get { throw null; } set { } }
    }
    public sealed partial class MemoryFailPoint : System.Runtime.ConstrainedExecution.CriticalFinalizerObject, System.IDisposable
    {
        public MemoryFailPoint(int sizeInMegabytes) { }
        public void Dispose() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Constructor | System.AttributeTargets.Method, AllowMultiple=false, Inherited=false)]
    public sealed partial class TargetedPatchingOptOutAttribute : System.Attribute
    {
        public TargetedPatchingOptOutAttribute(string reason) { }
        public string Reason { get { throw null; } }
    }
}
