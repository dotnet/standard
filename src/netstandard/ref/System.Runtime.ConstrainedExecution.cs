// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Runtime.ConstrainedExecution
{
    public enum Cer
    {
        MayFail = 1,
        None = 0,
        Success = 2,
    }
    public enum Consistency
    {
        MayCorruptAppDomain = 1,
        MayCorruptInstance = 2,
        MayCorruptProcess = 0,
        WillNotCorruptState = 3,
    }
    public abstract partial class CriticalFinalizerObject
    {
        protected CriticalFinalizerObject() { }
        ~CriticalFinalizerObject() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Constructor | System.AttributeTargets.Method, Inherited=false)]
    public sealed partial class PrePrepareMethodAttribute : System.Attribute
    {
        public PrePrepareMethodAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.Class | System.AttributeTargets.Constructor | System.AttributeTargets.Interface | System.AttributeTargets.Method | System.AttributeTargets.Struct, Inherited=false)]
    public sealed partial class ReliabilityContractAttribute : System.Attribute
    {
        public ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency consistencyGuarantee, System.Runtime.ConstrainedExecution.Cer cer) { }
        public System.Runtime.ConstrainedExecution.Cer Cer { get { throw null; } }
        public System.Runtime.ConstrainedExecution.Consistency ConsistencyGuarantee { get { throw null; } }
    }
}
