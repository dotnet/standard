// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Runtime.InteropServices
{
    [System.AttributeUsageAttribute(System.AttributeTargets.Method, AllowMultiple=false, Inherited=false)]
    public sealed partial class AllowReversePInvokeCallsAttribute : System.Attribute
    {
        public AllowReversePInvokeCallsAttribute() { }
    }
    public enum Architecture
    {
        Arm = 2,
        Arm64 = 3,
        X64 = 1,
        X86 = 0,
    }
    public partial struct ArrayWithOffset
    {
        private object _dummy;
        public ArrayWithOffset(object array, int offset) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Runtime.InteropServices.ArrayWithOffset obj) { throw null; }
        public object GetArray() { throw null; }
        public override int GetHashCode() { throw null; }
        public int GetOffset() { throw null; }
        public static bool operator ==(System.Runtime.InteropServices.ArrayWithOffset a, System.Runtime.InteropServices.ArrayWithOffset b) { throw null; }
        public static bool operator !=(System.Runtime.InteropServices.ArrayWithOffset a, System.Runtime.InteropServices.ArrayWithOffset b) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.Class | System.AttributeTargets.Interface, Inherited=false)]
    public sealed partial class AutomationProxyAttribute : System.Attribute
    {
        public AutomationProxyAttribute(bool val) { }
        public bool Value { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.Class | System.AttributeTargets.Interface | System.AttributeTargets.Struct, Inherited=false)]
    public sealed partial class BestFitMappingAttribute : System.Attribute
    {
        public bool ThrowOnUnmappableChar;
        public BestFitMappingAttribute(bool BestFitMapping) { }
        public bool BestFitMapping { get { throw null; } }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.ObsoleteAttribute("BStrWrapper and support for marshalling to the VARIANT type may be unavailable in future releases.")]
    public sealed partial class BStrWrapper
    {
        public BStrWrapper(object value) { }
        public BStrWrapper(string value) { }
        public string WrappedObject { get { throw null; } }
    }
    public enum CallingConvention
    {
        Cdecl = 2,
        FastCall = 5,
        StdCall = 3,
        ThisCall = 4,
        Winapi = 1,
    }
    public enum CharSet
    {
        Ansi = 2,
        Auto = 4,
        None = 1,
        Unicode = 3,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.Class, Inherited=false)]
    public sealed partial class ClassInterfaceAttribute : System.Attribute
    {
        public ClassInterfaceAttribute(short classInterfaceType) { }
        public ClassInterfaceAttribute(System.Runtime.InteropServices.ClassInterfaceType classInterfaceType) { }
        public System.Runtime.InteropServices.ClassInterfaceType Value { get { throw null; } }
    }
    public enum ClassInterfaceType
    {
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("Support for IDispatch may be unavailable in future releases.")]
        AutoDispatch = 1,
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("Support for IDispatch may be unavailable in future releases.")]
        AutoDual = 2,
        None = 0,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Interface, Inherited=false)]
    public sealed partial class CoClassAttribute : System.Attribute
    {
        public CoClassAttribute(System.Type coClass) { }
        public System.Type CoClass { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Field | System.AttributeTargets.Parameter | System.AttributeTargets.Property | System.AttributeTargets.ReturnValue, Inherited=false)]
    public sealed partial class ComAliasNameAttribute : System.Attribute
    {
        public ComAliasNameAttribute(string alias) { }
        public string Value { get { throw null; } }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.ObsoleteAttribute("ComAwareEventInfo may be unavailable in future releases.")]
    public partial class ComAwareEventInfo : System.Reflection.EventInfo
    {
        public ComAwareEventInfo(System.Type type, string eventName) { }
        public override System.Reflection.EventAttributes Attributes { get { throw null; } }
        public override System.Type DeclaringType { get { throw null; } }
        public override string Name { get { throw null; } }
        public override System.Type ReflectedType { get { throw null; } }
        public override void AddEventHandler(object target, System.Delegate handler) { }
        public override System.Reflection.MethodInfo GetAddMethod(bool nonPublic) { throw null; }
        public override object[] GetCustomAttributes(bool inherit) { throw null; }
        public override object[] GetCustomAttributes(System.Type attributeType, bool inherit) { throw null; }
        public override System.Reflection.MethodInfo GetRaiseMethod(bool nonPublic) { throw null; }
        public override System.Reflection.MethodInfo GetRemoveMethod(bool nonPublic) { throw null; }
        public override bool IsDefined(System.Type attributeType, bool inherit) { throw null; }
        public override void RemoveEventHandler(object target, System.Delegate handler) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, Inherited=false)]
    public sealed partial class ComCompatibleVersionAttribute : System.Attribute
    {
        public ComCompatibleVersionAttribute(int major, int minor, int build, int revision) { }
        public int BuildNumber { get { throw null; } }
        public int MajorVersion { get { throw null; } }
        public int MinorVersion { get { throw null; } }
        public int RevisionNumber { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All, Inherited=false)]
    public sealed partial class ComConversionLossAttribute : System.Attribute
    {
        public ComConversionLossAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class, Inherited=false)]
    public sealed partial class ComDefaultInterfaceAttribute : System.Attribute
    {
        public ComDefaultInterfaceAttribute(System.Type defaultInterface) { }
        public System.Type Value { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Interface, Inherited=false)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.ObsoleteAttribute("ComEventInterfaceAttribute may be unavailable in future releases.")]
    public sealed partial class ComEventInterfaceAttribute : System.Attribute
    {
        public ComEventInterfaceAttribute(System.Type SourceInterface, System.Type EventProvider) { }
        public System.Type EventProvider { get { throw null; } }
        public System.Type SourceInterface { get { throw null; } }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.ObsoleteAttribute("ComEventsHelper may be unavailable in future releases.")]
    public static partial class ComEventsHelper
    {
        public static void Combine(object rcw, System.Guid iid, int dispid, System.Delegate d) { }
        public static System.Delegate Remove(object rcw, System.Guid iid, int dispid, System.Delegate d) { throw null; }
    }
    public partial class COMException : System.Runtime.InteropServices.ExternalException
    {
        public COMException() { }
        protected COMException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public COMException(string message) { }
        public COMException(string message, System.Exception inner) { }
        public COMException(string message, int errorCode) { }
        public override string ToString() { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Interface, Inherited=false)]
    public sealed partial class ComImportAttribute : System.Attribute
    {
        public ComImportAttribute() { }
    }
    public enum ComInterfaceType
    {
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("Support for IDispatch may be unavailable in future releases.")]
        InterfaceIsDual = 0,
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("Support for IDispatch may be unavailable in future releases.")]
        InterfaceIsIDispatch = 2,
        InterfaceIsIInspectable = 3,
        InterfaceIsIUnknown = 1,
    }
    public enum ComMemberType
    {
        Method = 0,
        PropGet = 1,
        PropSet = 2,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method, Inherited=false)]
    public sealed partial class ComRegisterFunctionAttribute : System.Attribute
    {
        public ComRegisterFunctionAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class, Inherited=true)]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.ObsoleteAttribute("ComSourceInterfacesAttribute may be unavailable in future releases.")]
    public sealed partial class ComSourceInterfacesAttribute : System.Attribute
    {
        public ComSourceInterfacesAttribute(string sourceInterfaces) { }
        public ComSourceInterfacesAttribute(System.Type sourceInterface) { }
        public ComSourceInterfacesAttribute(System.Type sourceInterface1, System.Type sourceInterface2) { }
        public ComSourceInterfacesAttribute(System.Type sourceInterface1, System.Type sourceInterface2, System.Type sourceInterface3) { }
        public ComSourceInterfacesAttribute(System.Type sourceInterface1, System.Type sourceInterface2, System.Type sourceInterface3, System.Type sourceInterface4) { }
        public string Value { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method, Inherited=false)]
    public sealed partial class ComUnregisterFunctionAttribute : System.Attribute
    {
        public ComUnregisterFunctionAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.Class | System.AttributeTargets.Delegate | System.AttributeTargets.Enum | System.AttributeTargets.Field | System.AttributeTargets.Interface | System.AttributeTargets.Method | System.AttributeTargets.Property | System.AttributeTargets.Struct, Inherited=false)]
    public sealed partial class ComVisibleAttribute : System.Attribute
    {
        public ComVisibleAttribute(bool visibility) { }
        public bool Value { get { throw null; } }
    }
    public abstract partial class CriticalHandle : System.Runtime.ConstrainedExecution.CriticalFinalizerObject, System.IDisposable
    {
        protected System.IntPtr handle;
        protected CriticalHandle(System.IntPtr invalidHandleValue) { }
        public bool IsClosed { get { throw null; } }
        public abstract bool IsInvalid { get; }
        public void Close() { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        ~CriticalHandle() { }
        protected abstract bool ReleaseHandle();
        protected void SetHandle(System.IntPtr handle) { }
        public void SetHandleAsInvalid() { }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.ObsoleteAttribute("CurrencyWrapper and support for marshalling to the VARIANT type may be unavailable in future releases.")]
    public sealed partial class CurrencyWrapper
    {
        public CurrencyWrapper(decimal obj) { }
        public CurrencyWrapper(object obj) { }
        public decimal WrappedObject { get { throw null; } }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public enum CustomQueryInterfaceMode
    {
        Allow = 1,
        Ignore = 0,
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public enum CustomQueryInterfaceResult
    {
        Failed = 2,
        Handled = 0,
        NotHandled = 1,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Module, Inherited=false)]
    public sealed partial class DefaultCharSetAttribute : System.Attribute
    {
        public DefaultCharSetAttribute(System.Runtime.InteropServices.CharSet charSet) { }
        public System.Runtime.InteropServices.CharSet CharSet { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.Method, AllowMultiple=false)]
    public sealed partial class DefaultDllImportSearchPathsAttribute : System.Attribute
    {
        public DefaultDllImportSearchPathsAttribute(System.Runtime.InteropServices.DllImportSearchPath paths) { }
        public System.Runtime.InteropServices.DllImportSearchPath Paths { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter)]
    public sealed partial class DefaultParameterValueAttribute : System.Attribute
    {
        public DefaultParameterValueAttribute(object value) { }
        public object Value { get { throw null; } }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.ObsoleteAttribute("DispatchWrapper and support for marshalling to the VARIANT type may be unavailable in future releases.")]
    public sealed partial class DispatchWrapper
    {
        public DispatchWrapper(object obj) { }
        public object WrappedObject { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Event | System.AttributeTargets.Field | System.AttributeTargets.Method | System.AttributeTargets.Property, Inherited=false)]
    public sealed partial class DispIdAttribute : System.Attribute
    {
        public DispIdAttribute(int dispId) { }
        public int Value { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method, Inherited=false)]
    public sealed partial class DllImportAttribute : System.Attribute
    {
        public bool BestFitMapping;
        public System.Runtime.InteropServices.CallingConvention CallingConvention;
        public System.Runtime.InteropServices.CharSet CharSet;
        public string EntryPoint;
        public bool ExactSpelling;
        public bool PreserveSig;
        public bool SetLastError;
        public bool ThrowOnUnmappableChar;
        public DllImportAttribute(string dllName) { }
        public string Value { get { throw null; } }
    }
    [System.FlagsAttribute]
    public enum DllImportSearchPath
    {
        ApplicationDirectory = 512,
        AssemblyDirectory = 2,
        LegacyBehavior = 0,
        SafeDirectories = 4096,
        System32 = 2048,
        UseDllDirectoryForDependencies = 256,
        UserDirectories = 1024,
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.ObsoleteAttribute("ErrorWrapper and support for marshalling to the VARIANT type may be unavailable in future releases.")]
    public sealed partial class ErrorWrapper
    {
        public ErrorWrapper(System.Exception e) { }
        public ErrorWrapper(int errorCode) { }
        public ErrorWrapper(object errorCode) { }
        public int ErrorCode { get { throw null; } }
    }
    public partial class ExternalException : System.SystemException
    {
        public ExternalException() { }
        protected ExternalException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public ExternalException(string message) { }
        public ExternalException(string message, System.Exception inner) { }
        public ExternalException(string message, int errorCode) { }
        public virtual int ErrorCode { get { throw null; } }
        public override string ToString() { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Field, Inherited=false)]
    public sealed partial class FieldOffsetAttribute : System.Attribute
    {
        public FieldOffsetAttribute(int offset) { }
        public int Value { get { throw null; } }
    }
    public partial struct GCHandle
    {
        private int _dummyPrimitive;
        public bool IsAllocated { get { throw null; } }
        public object Target { get { throw null; } set { } }
        public System.IntPtr AddrOfPinnedObject() { throw null; }
        public static System.Runtime.InteropServices.GCHandle Alloc(object value) { throw null; }
        public static System.Runtime.InteropServices.GCHandle Alloc(object value, System.Runtime.InteropServices.GCHandleType type) { throw null; }
        public override bool Equals(object o) { throw null; }
        public void Free() { }
        public static System.Runtime.InteropServices.GCHandle FromIntPtr(System.IntPtr value) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Runtime.InteropServices.GCHandle a, System.Runtime.InteropServices.GCHandle b) { throw null; }
        public static explicit operator System.Runtime.InteropServices.GCHandle (System.IntPtr value) { throw null; }
        public static explicit operator System.IntPtr (System.Runtime.InteropServices.GCHandle value) { throw null; }
        public static bool operator !=(System.Runtime.InteropServices.GCHandle a, System.Runtime.InteropServices.GCHandle b) { throw null; }
        public static System.IntPtr ToIntPtr(System.Runtime.InteropServices.GCHandle value) { throw null; }
    }
    public enum GCHandleType
    {
        Normal = 2,
        Pinned = 3,
        Weak = 0,
        WeakTrackResurrection = 1,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.Class | System.AttributeTargets.Delegate | System.AttributeTargets.Enum | System.AttributeTargets.Interface | System.AttributeTargets.Struct, Inherited=false)]
    public sealed partial class GuidAttribute : System.Attribute
    {
        public GuidAttribute(string guid) { }
        public string Value { get { throw null; } }
    }
    public sealed partial class HandleCollector
    {
        public HandleCollector(string name, int initialThreshold) { }
        public HandleCollector(string name, int initialThreshold, int maximumThreshold) { }
        public int Count { get { throw null; } }
        public int InitialThreshold { get { throw null; } }
        public int MaximumThreshold { get { throw null; } }
        public string Name { get { throw null; } }
        public void Add() { }
        public void Remove() { }
    }
    public readonly partial struct HandleRef
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public HandleRef(object wrapper, System.IntPtr handle) { throw null; }
        public System.IntPtr Handle { get { throw null; } }
        public object Wrapper { get { throw null; } }
        public static explicit operator System.IntPtr (System.Runtime.InteropServices.HandleRef value) { throw null; }
        public static System.IntPtr ToIntPtr(System.Runtime.InteropServices.HandleRef value) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.ObsoleteAttribute("ICustomAdapter may be unavailable in future releases.")]
    public partial interface ICustomAdapter
    {
        object GetUnderlyingObject();
    }
    public partial interface ICustomFactory
    {
        System.MarshalByRefObject CreateInstance(System.Type serverType);
    }
    public partial interface ICustomMarshaler
    {
        void CleanUpManagedData(object ManagedObj);
        void CleanUpNativeData(System.IntPtr pNativeData);
        int GetNativeDataSize();
        System.IntPtr MarshalManagedToNative(object ManagedObj);
        object MarshalNativeToManaged(System.IntPtr pNativeData);
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public partial interface ICustomQueryInterface
    {
        System.Runtime.InteropServices.CustomQueryInterfaceResult GetInterface(ref System.Guid iid, out System.IntPtr ppv);
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, Inherited=false)]
    public sealed partial class ImportedFromTypeLibAttribute : System.Attribute
    {
        public ImportedFromTypeLibAttribute(string tlbFile) { }
        public string Value { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter, Inherited=false)]
    public sealed partial class InAttribute : System.Attribute
    {
        public InAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Interface, Inherited=false)]
    public sealed partial class InterfaceTypeAttribute : System.Attribute
    {
        public InterfaceTypeAttribute(short interfaceType) { }
        public InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType interfaceType) { }
        public System.Runtime.InteropServices.ComInterfaceType Value { get { throw null; } }
    }
    public partial class InvalidComObjectException : System.SystemException
    {
        public InvalidComObjectException() { }
        protected InvalidComObjectException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public InvalidComObjectException(string message) { }
        public InvalidComObjectException(string message, System.Exception inner) { }
    }
    public partial class InvalidOleVariantTypeException : System.SystemException
    {
        public InvalidOleVariantTypeException() { }
        protected InvalidOleVariantTypeException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public InvalidOleVariantTypeException(string message) { }
        public InvalidOleVariantTypeException(string message, System.Exception inner) { }
    }
    public enum LayoutKind
    {
        Auto = 3,
        Explicit = 2,
        Sequential = 0,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method, Inherited=false)]
    public sealed partial class LCIDConversionAttribute : System.Attribute
    {
        public LCIDConversionAttribute(int lcid) { }
        public int Value { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method, Inherited = false)]
    public sealed partial class ManagedToNativeComInteropStubAttribute : System.Attribute
    {
        public ManagedToNativeComInteropStubAttribute(System.Type classType, string methodName) { }
        public System.Type ClassType { get { throw null; } }
        public string MethodName { get { throw null; } }
    }
    public static partial class Marshal
    {
        public static readonly int SystemDefaultCharSize;
        public static readonly int SystemMaxDBCSCharSize;
        public static int AddRef(System.IntPtr pUnk) { throw null; }
        public static System.IntPtr AllocCoTaskMem(int cb) { throw null; }
        public static System.IntPtr AllocHGlobal(int cb) { throw null; }
        public static System.IntPtr AllocHGlobal(System.IntPtr cb) { throw null; }
        public static bool AreComObjectsAvailableForCleanup() { throw null; }
        public static object BindToMoniker(string monikerName) { throw null; }
        public static void ChangeWrapperHandleStrength(object otp, bool fIsWeak) { }
        public static void CleanupUnusedObjectsInCurrentContext() { }
        public static void Copy(byte[] source, int startIndex, System.IntPtr destination, int length) { }
        public static void Copy(char[] source, int startIndex, System.IntPtr destination, int length) { }
        public static void Copy(double[] source, int startIndex, System.IntPtr destination, int length) { }
        public static void Copy(short[] source, int startIndex, System.IntPtr destination, int length) { }
        public static void Copy(int[] source, int startIndex, System.IntPtr destination, int length) { }
        public static void Copy(long[] source, int startIndex, System.IntPtr destination, int length) { }
        public static void Copy(System.IntPtr source, byte[] destination, int startIndex, int length) { }
        public static void Copy(System.IntPtr source, char[] destination, int startIndex, int length) { }
        public static void Copy(System.IntPtr source, double[] destination, int startIndex, int length) { }
        public static void Copy(System.IntPtr source, short[] destination, int startIndex, int length) { }
        public static void Copy(System.IntPtr source, int[] destination, int startIndex, int length) { }
        public static void Copy(System.IntPtr source, long[] destination, int startIndex, int length) { }
        public static void Copy(System.IntPtr source, System.IntPtr[] destination, int startIndex, int length) { }
        public static void Copy(System.IntPtr source, float[] destination, int startIndex, int length) { }
        public static void Copy(System.IntPtr[] source, int startIndex, System.IntPtr destination, int length) { }
        public static void Copy(float[] source, int startIndex, System.IntPtr destination, int length) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static System.IntPtr CreateAggregatedObject(System.IntPtr pOuter, object o) { throw null; }
        public static System.IntPtr CreateAggregatedObject<T>(System.IntPtr pOuter, T o) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static object CreateWrapperOfType(object o, System.Type t) { throw null; }
        public static TWrapper CreateWrapperOfType<T, TWrapper>(T o) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static void DestroyStructure(System.IntPtr ptr, System.Type structuretype) { }
        public static void DestroyStructure<T>(System.IntPtr ptr) { }
        public static int FinalReleaseComObject(object o) { throw null; }
        public static void FreeBSTR(System.IntPtr ptr) { }
        public static void FreeCoTaskMem(System.IntPtr ptr) { }
        public static void FreeHGlobal(System.IntPtr hglobal) { }
        public static System.Guid GenerateGuidForType(System.Type type) { throw null; }
        public static string GenerateProgIdForType(System.Type type) { throw null; }
//INTEROP        public static object GetActiveObject(string progID) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static System.IntPtr GetComInterfaceForObject(object o, System.Type T) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static System.IntPtr GetComInterfaceForObject(object o, System.Type T, System.Runtime.InteropServices.CustomQueryInterfaceMode mode) { throw null; }
        public static System.IntPtr GetComInterfaceForObject<T, TInterface>(T o) { throw null; }
//INTEROP        public static System.IntPtr GetComInterfaceForObjectInContext(object o, System.Type t) { throw null; }
        public static object GetComObjectData(object obj, object key) { throw null; }
//INTEROP        public static int GetComSlotForMethodInfo(System.Reflection.MemberInfo m) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static System.Delegate GetDelegateForFunctionPointer(System.IntPtr ptr, System.Type t) { throw null; }
        public static TDelegate GetDelegateForFunctionPointer<TDelegate>(System.IntPtr ptr) { throw null; }
//INTEROP        public static int GetEndComSlot(System.Type t) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("GetExceptionCode() may be unavailable in future releases.")]
        public static int GetExceptionCode() { throw null; }
        public static System.Exception GetExceptionForHR(int errorCode) { throw null; }
        public static System.Exception GetExceptionForHR(int errorCode, System.IntPtr errorInfo) { throw null; }
//INTEROP        public static System.IntPtr GetExceptionPointers() { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static System.IntPtr GetFunctionPointerForDelegate(System.Delegate d) { throw null; }
        public static System.IntPtr GetFunctionPointerForDelegate<TDelegate>(TDelegate d) { throw null; }
        public static System.IntPtr GetHINSTANCE(System.Reflection.Module m) { throw null; }
        public static int GetHRForException(System.Exception e) { throw null; }
        public static int GetHRForLastWin32Error() { throw null; }
        public static System.IntPtr GetIDispatchForObject(object o) { throw null; }
//INTEROP        public static System.IntPtr GetIDispatchForObjectInContext(object o) { throw null; }
//INTEROP        public static System.IntPtr GetITypeInfoForType(System.Type t) { throw null; }
        public static System.IntPtr GetIUnknownForObject(object o) { throw null; }
//INTEROP        public static System.IntPtr GetIUnknownForObjectInContext(object o) { throw null; }
        public static int GetLastWin32Error() { throw null; }
//INTEROP        [System.ObsoleteAttribute("The GetManagedThunkForUnmanagedMethodPtr method has been deprecated and will be removed in a future release.", false)]
//INTEROP        public static System.IntPtr GetManagedThunkForUnmanagedMethodPtr(System.IntPtr pfnMethodToWrap, System.IntPtr pbSignature, int cbSignature) { throw null; }
//INTEROP        public static System.Reflection.MemberInfo GetMethodInfoForComSlot(System.Type t, int slot, ref System.Runtime.InteropServices.ComMemberType memberType) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("GetNativeVariantForObject(Object, IntPtr) may be unavailable in future releases.")]
        public static void GetNativeVariantForObject(object obj, System.IntPtr pDstNativeVariant) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("GetNativeVariantForObject<T>(T, IntPtr) may be unavailable in future releases.")]
        public static void GetNativeVariantForObject<T>(T obj, System.IntPtr pDstNativeVariant) { }
        public static object GetObjectForIUnknown(System.IntPtr pUnk) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("GetObjectForNativeVariant(IntPtr) may be unavailable in future releases.")]
        public static object GetObjectForNativeVariant(System.IntPtr pSrcNativeVariant) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("GetObjectForNativeVariant<T>(IntPtr) may be unavailable in future releases.")]
        public static T GetObjectForNativeVariant<T>(System.IntPtr pSrcNativeVariant) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("GetObjectsForNativeVariants(IntPtr, Int32) may be unavailable in future releases.")]
        public static object[] GetObjectsForNativeVariants(System.IntPtr aSrcNativeVariant, int cVars) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("GetObjectsForNativeVariants<T>(IntPtr, Int32) may be unavailable in future releases.")]
        public static T[] GetObjectsForNativeVariants<T>(System.IntPtr aSrcNativeVariant, int cVars) { throw null; }
        public static int GetStartComSlot(System.Type t) { throw null; }
//INTEROP        [System.ObsoleteAttribute("The GetThreadFromFiberCookie method has been deprecated.  Use the hosting API to perform this operation.", false)]
//INTEROP        public static System.Threading.Thread GetThreadFromFiberCookie(int cookie) { throw null; }
        public static object GetTypedObjectForIUnknown(System.IntPtr pUnk, System.Type t) { throw null; }
//INTEROP        public static System.Type GetTypeForITypeInfo(System.IntPtr piTypeInfo) { throw null; }
        public static System.Type GetTypeFromCLSID(System.Guid clsid) { throw null; }
        public static string GetTypeInfoName(System.Runtime.InteropServices.ComTypes.ITypeInfo typeInfo) { throw null; }
//INTEROP        [System.ObsoleteAttribute("Use System.Runtime.InteropServices.Marshal.GetTypeInfoName(ITypeInfo pTLB) instead. https://go.microsoft.com/fwlink/?linkid=14202&ID=0000011.", false)]
//INTEROP        public static string GetTypeInfoName(System.Runtime.InteropServices.UCOMITypeInfo pTI) { throw null; }
//INTEROP        public static System.Guid GetTypeLibGuid(System.Runtime.InteropServices.ComTypes.ITypeLib typelib) { throw null; }
//INTEROP        [System.ObsoleteAttribute("Use System.Runtime.InteropServices.Marshal.GetTypeLibGuid(ITypeLib pTLB) instead. https://go.microsoft.com/fwlink/?linkid=14202&ID=0000011.", false)]
//INTEROP        public static System.Guid GetTypeLibGuid(System.Runtime.InteropServices.UCOMITypeLib pTLB) { throw null; }
//INTEROP        public static System.Guid GetTypeLibGuidForAssembly(System.Reflection.Assembly asm) { throw null; }
//INTEROP        public static int GetTypeLibLcid(System.Runtime.InteropServices.ComTypes.ITypeLib typelib) { throw null; }
//INTEROP        [System.ObsoleteAttribute("Use System.Runtime.InteropServices.Marshal.GetTypeLibLcid(ITypeLib pTLB) instead. https://go.microsoft.com/fwlink/?linkid=14202&ID=0000011.", false)]
//INTEROP        public static int GetTypeLibLcid(System.Runtime.InteropServices.UCOMITypeLib pTLB) { throw null; }
//INTEROP        public static string GetTypeLibName(System.Runtime.InteropServices.ComTypes.ITypeLib typelib) { throw null; }
//INTEROP        [System.ObsoleteAttribute("Use System.Runtime.InteropServices.Marshal.GetTypeLibName(ITypeLib pTLB) instead. https://go.microsoft.com/fwlink/?linkid=14202&ID=0000011.", false)]
//INTEROP        public static string GetTypeLibName(System.Runtime.InteropServices.UCOMITypeLib pTLB) { throw null; }
//INTEROP        public static void GetTypeLibVersionForAssembly(System.Reflection.Assembly inputAssembly, out int majorVersion, out int minorVersion) { throw null; }
        public static object GetUniqueObjectForIUnknown(System.IntPtr unknown) { throw null; }
//INTEROP        [System.ObsoleteAttribute("The GetUnmanagedThunkForManagedMethodPtr method has been deprecated and will be removed in a future release.", false)]
//INTEROP        public static System.IntPtr GetUnmanagedThunkForManagedMethodPtr(System.IntPtr pfnMethodToWrap, System.IntPtr pbSignature, int cbSignature) { throw null; }
        public static bool IsComObject(object o) { throw null; }
//INTEROP        public static bool IsTypeVisibleFromCom(System.Type t) { throw null; }
//INTEROP        public static int NumParamBytes(System.Reflection.MethodInfo m) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static System.IntPtr OffsetOf(System.Type t, string fieldName) { throw null; }
        public static System.IntPtr OffsetOf<T>(string fieldName) { throw null; }
        public static void Prelink(System.Reflection.MethodInfo m) { }
        public static void PrelinkAll(System.Type c) { }
        public static string PtrToStringAnsi(System.IntPtr ptr) { throw null; }
        public static string PtrToStringAnsi(System.IntPtr ptr, int len) { throw null; }
        public static string PtrToStringAuto(System.IntPtr ptr) { throw null; }
        public static string PtrToStringAuto(System.IntPtr ptr, int len) { throw null; }
        public static string PtrToStringBSTR(System.IntPtr ptr) { throw null; }
        public static string PtrToStringUni(System.IntPtr ptr) { throw null; }
        public static string PtrToStringUni(System.IntPtr ptr, int len) { throw null; }
        public static string PtrToStringUTF8(System.IntPtr ptr) { throw null; }
        public static string PtrToStringUTF8(System.IntPtr ptr, int byteLen) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static void PtrToStructure(System.IntPtr ptr, object structure) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static object PtrToStructure(System.IntPtr ptr, System.Type structureType) { throw null; }
        public static T PtrToStructure<T>(System.IntPtr ptr) { throw null; }
        public static void PtrToStructure<T>(System.IntPtr ptr, T structure) { }
        public static int QueryInterface(System.IntPtr pUnk, ref System.Guid iid, out System.IntPtr ppv) { throw null; }
        public static byte ReadByte(System.IntPtr ptr) { throw null; }
        public static byte ReadByte(System.IntPtr ptr, int ofs) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("ReadByte(Object, Int32) may be unavailable in future releases.")]
        public static byte ReadByte(object ptr, int ofs) { throw null; }
        public static short ReadInt16(System.IntPtr ptr) { throw null; }
        public static short ReadInt16(System.IntPtr ptr, int ofs) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("ReadInt16(Object, Int32) may be unavailable in future releases.")]
        public static short ReadInt16(object ptr, int ofs) { throw null; }
        public static int ReadInt32(System.IntPtr ptr) { throw null; }
        public static int ReadInt32(System.IntPtr ptr, int ofs) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("ReadInt32(Object, Int32) may be unavailable in future releases.")]
        public static int ReadInt32(object ptr, int ofs) { throw null; }
        public static long ReadInt64(System.IntPtr ptr) { throw null; }
        public static long ReadInt64(System.IntPtr ptr, int ofs) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("ReadInt64(Object, Int32) may be unavailable in future releases.")]
        public static long ReadInt64(object ptr, int ofs) { throw null; }
        public static System.IntPtr ReadIntPtr(System.IntPtr ptr) { throw null; }
        public static System.IntPtr ReadIntPtr(System.IntPtr ptr, int ofs) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("ReadIntPtr(Object, Int32) may be unavailable in future releases.")]
        public static System.IntPtr ReadIntPtr(object ptr, int ofs) { throw null; }
        public static System.IntPtr ReAllocCoTaskMem(System.IntPtr pv, int cb) { throw null; }
        public static System.IntPtr ReAllocHGlobal(System.IntPtr pv, System.IntPtr cb) { throw null; }
        public static int Release(System.IntPtr pUnk) { throw null; }
        public static int ReleaseComObject(object o) { throw null; }
//INTEROP        [System.ObsoleteAttribute("This API did not perform any operation and will be removed in future versions of the CLR.", false)]
//INTEROP        public static void ReleaseThreadCache() { }
        [System.CLSCompliantAttribute(false)]
        public static System.IntPtr SecureStringToBSTR(System.Security.SecureString s) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.IntPtr SecureStringToCoTaskMemAnsi(System.Security.SecureString s) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.IntPtr SecureStringToCoTaskMemUnicode(System.Security.SecureString s) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.IntPtr SecureStringToGlobalAllocAnsi(System.Security.SecureString s) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.IntPtr SecureStringToGlobalAllocUnicode(System.Security.SecureString s) { throw null; }
        public static bool SetComObjectData(object obj, object key, object data) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static int SizeOf(object structure) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static int SizeOf(System.Type t) { throw null; }
        public static int SizeOf<T>() { throw null; }
        public static int SizeOf<T>(T structure) { throw null; }
        public static System.IntPtr StringToBSTR(string s) { throw null; }
        public static System.IntPtr StringToCoTaskMemAnsi(string s) { throw null; }
        public static System.IntPtr StringToCoTaskMemAuto(string s) { throw null; }
        public static System.IntPtr StringToCoTaskMemUni(string s) { throw null; }
        public static System.IntPtr StringToCoTaskMemUTF8(string s) { throw null; }
        public static System.IntPtr StringToHGlobalAnsi(string s) { throw null; }
        public static System.IntPtr StringToHGlobalAuto(string s) { throw null; }
        public static System.IntPtr StringToHGlobalUni(string s) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static void StructureToPtr(object structure, System.IntPtr ptr, bool fDeleteOld) { }
        public static void StructureToPtr<T>(T structure, System.IntPtr ptr, bool fDeleteOld) { }
        public static void ThrowExceptionForHR(int errorCode) { }
        public static void ThrowExceptionForHR(int errorCode, System.IntPtr errorInfo) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static System.IntPtr UnsafeAddrOfPinnedArrayElement(System.Array arr, int index) { throw null; }
        public static System.IntPtr UnsafeAddrOfPinnedArrayElement<T>(T[] arr, int index) { throw null; }
        public static void WriteByte(System.IntPtr ptr, byte val) { }
        public static void WriteByte(System.IntPtr ptr, int ofs, byte val) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("WriteByte(Object, Int32, Byte) may be unavailable in future releases.")]
        public static void WriteByte(object ptr, int ofs, byte val) { }
        public static void WriteInt16(System.IntPtr ptr, char val) { }
        public static void WriteInt16(System.IntPtr ptr, short val) { }
        public static void WriteInt16(System.IntPtr ptr, int ofs, char val) { }
        public static void WriteInt16(System.IntPtr ptr, int ofs, short val) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("WriteInt16(Object, Int32, Char) may be unavailable in future releases.")]
        public static void WriteInt16(object ptr, int ofs, char val) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("WriteInt16(Object, Int32, Int16) may be unavailable in future releases.")]
        public static void WriteInt16(object ptr, int ofs, short val) { }
        public static void WriteInt32(System.IntPtr ptr, int val) { }
        public static void WriteInt32(System.IntPtr ptr, int ofs, int val) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("WriteInt32(Object, Int32, Int32) may be unavailable in future releases.")]
        public static void WriteInt32(object ptr, int ofs, int val) { }
        public static void WriteInt64(System.IntPtr ptr, int ofs, long val) { }
        public static void WriteInt64(System.IntPtr ptr, long val) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("WriteInt64(Object, Int32, Int64) may be unavailable in future releases.")]
        public static void WriteInt64(object ptr, int ofs, long val) { }
        public static void WriteIntPtr(System.IntPtr ptr, int ofs, System.IntPtr val) { }
        public static void WriteIntPtr(System.IntPtr ptr, System.IntPtr val) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("WriteIntPtr(Object, Int32, IntPtr) may be unavailable in future releases.")]
        public static void WriteIntPtr(object ptr, int ofs, System.IntPtr val) { }
        public static void ZeroFreeBSTR(System.IntPtr s) { }
        public static void ZeroFreeCoTaskMemAnsi(System.IntPtr s) { }
        public static void ZeroFreeCoTaskMemUnicode(System.IntPtr s) { }
        public static void ZeroFreeCoTaskMemUTF8(System.IntPtr s) { }
        public static void ZeroFreeGlobalAllocAnsi(System.IntPtr s) { }
        public static void ZeroFreeGlobalAllocUnicode(System.IntPtr s) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Field | System.AttributeTargets.Parameter | System.AttributeTargets.ReturnValue, Inherited=false)]
    public sealed partial class MarshalAsAttribute : System.Attribute
    {
        public System.Runtime.InteropServices.UnmanagedType ArraySubType;
        public int IidParameterIndex;
        public string MarshalCookie;
        public string MarshalType;
        public System.Type MarshalTypeRef;
        public System.Runtime.InteropServices.VarEnum SafeArraySubType;
        public System.Type SafeArrayUserDefinedSubType;
        public int SizeConst;
        public short SizeParamIndex;
        public MarshalAsAttribute(short unmanagedType) { }
        public MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType unmanagedType) { }
        public System.Runtime.InteropServices.UnmanagedType Value { get { throw null; } }
    }
    public partial class MarshalDirectiveException : System.SystemException
    {
        public MarshalDirectiveException() { }
        protected MarshalDirectiveException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public MarshalDirectiveException(string message) { }
        public MarshalDirectiveException(string message, System.Exception inner) { }
    }
    public static partial class MemoryMarshal
    {
        public static System.ReadOnlySpan<byte> AsBytes<T>(System.ReadOnlySpan<T> span) where T : struct { throw null; }
        public static System.Span<byte> AsBytes<T>(System.Span<T> span) where T : struct { throw null; }
        public static System.Memory<T> AsMemory<T>(System.ReadOnlyMemory<T> memory) { throw null; }
        public static System.ReadOnlySpan<TTo> Cast<TFrom, TTo>(System.ReadOnlySpan<TFrom> span) where TFrom : struct where TTo : struct { throw null; }
        public static System.Span<TTo> Cast<TFrom, TTo>(System.Span<TFrom> span) where TFrom : struct where TTo : struct { throw null; }
        public static System.Memory<T> CreateFromPinnedArray<T>(T[] array, int start, int length) { throw null; }
        public static System.ReadOnlySpan<T> CreateReadOnlySpan<T>(ref T reference, int length) { throw null; }
        public static System.Span<T> CreateSpan<T>(ref T reference, int length) { throw null; }
        public static ref T GetReference<T>(System.ReadOnlySpan<T> span) { throw null; }
        public static ref T GetReference<T>(System.Span<T> span) { throw null; }
        public static T Read<T>(System.ReadOnlySpan<byte> source) where T : struct { throw null; }
        public static System.Collections.Generic.IEnumerable<T> ToEnumerable<T>(System.ReadOnlyMemory<T> memory) { throw null; }
        public static bool TryGetArray<T>(System.ReadOnlyMemory<T> memory, out System.ArraySegment<T> segment) { throw null; }
        public static bool TryGetMemoryManager<T, TManager>(System.ReadOnlyMemory<T> memory, out TManager manager) where TManager : System.Buffers.MemoryManager<T> { throw null; }
        public static bool TryGetMemoryManager<T, TManager>(System.ReadOnlyMemory<T> memory, out TManager manager, out int start, out int length) where TManager : System.Buffers.MemoryManager<T> { throw null; }
        public static bool TryGetString(System.ReadOnlyMemory<char> memory, out string text, out int start, out int length) { throw null; }
        public static bool TryRead<T>(System.ReadOnlySpan<byte> source, out T value) where T : struct { throw null; }
        public static bool TryWrite<T>(System.Span<byte> destination, ref T value) where T : struct { throw null; }
        public static void Write<T>(System.Span<byte> destination, ref T value) where T : struct { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter, Inherited=false)]
    public sealed partial class OptionalAttribute : System.Attribute
    {
        public OptionalAttribute() { }
    }
    public readonly partial struct OSPlatform : System.IEquatable<System.Runtime.InteropServices.OSPlatform>
    {
        private readonly object _dummy;
        public static System.Runtime.InteropServices.OSPlatform Linux { get { throw null; } }
        public static System.Runtime.InteropServices.OSPlatform OSX { get { throw null; } }
        public static System.Runtime.InteropServices.OSPlatform Windows { get { throw null; } }
        public static System.Runtime.InteropServices.OSPlatform Create(string osPlatform) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Runtime.InteropServices.OSPlatform other) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Runtime.InteropServices.OSPlatform left, System.Runtime.InteropServices.OSPlatform right) { throw null; }
        public static bool operator !=(System.Runtime.InteropServices.OSPlatform left, System.Runtime.InteropServices.OSPlatform right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter, Inherited=false)]
    public sealed partial class OutAttribute : System.Attribute
    {
        public OutAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method, Inherited=false)]
    public sealed partial class PreserveSigAttribute : System.Attribute
    {
        public PreserveSigAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, Inherited=false, AllowMultiple=true)]
    public sealed partial class PrimaryInteropAssemblyAttribute : System.Attribute
    {
        public PrimaryInteropAssemblyAttribute(int major, int minor) { }
        public int MajorVersion { get { throw null; } }
        public int MinorVersion { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class, Inherited=false)]
    public sealed partial class ProgIdAttribute : System.Attribute
    {
        public ProgIdAttribute(string progId) { }
        public string Value { get { throw null; } }
    }
    public static partial class RuntimeEnvironment
    {
        public static string SystemConfigurationFile { get { throw null; } }
        public static bool FromGlobalAccessCache(System.Reflection.Assembly a) { throw null; }
        public static string GetRuntimeDirectory() { throw null; }
        public static System.IntPtr GetRuntimeInterfaceAsIntPtr(System.Guid clsid, System.Guid riid) { throw null; }
        public static object GetRuntimeInterfaceAsObject(System.Guid clsid, System.Guid riid) { throw null; }
        public static string GetSystemVersion() { throw null; }
    }
    public static partial class RuntimeInformation
    {
        public static string FrameworkDescription { get { throw null; } }
        public static System.Runtime.InteropServices.Architecture OSArchitecture { get { throw null; } }
        public static string OSDescription { get { throw null; } }
        public static System.Runtime.InteropServices.Architecture ProcessArchitecture { get { throw null; } }
        public static bool IsOSPlatform(System.Runtime.InteropServices.OSPlatform osPlatform) { throw null; }
    }
    public partial class SafeArrayRankMismatchException : System.SystemException
    {
        public SafeArrayRankMismatchException() { }
        protected SafeArrayRankMismatchException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public SafeArrayRankMismatchException(string message) { }
        public SafeArrayRankMismatchException(string message, System.Exception inner) { }
    }
    public partial class SafeArrayTypeMismatchException : System.SystemException
    {
        public SafeArrayTypeMismatchException() { }
        protected SafeArrayTypeMismatchException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public SafeArrayTypeMismatchException(string message) { }
        public SafeArrayTypeMismatchException(string message, System.Exception inner) { }
    }
    public abstract partial class SafeBuffer : Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid
    {
        protected SafeBuffer(bool ownsHandle) : base (default(bool)) { }
        [System.CLSCompliantAttribute(false)]
        public ulong ByteLength { get { throw null; } }
        [System.CLSCompliantAttribute(false)]
        public unsafe void AcquirePointer(ref byte* pointer) { }
        [System.CLSCompliantAttribute(false)]
        public void Initialize(uint numElements, uint sizeOfEachElement) { }
        [System.CLSCompliantAttribute(false)]
        public void Initialize(ulong numBytes) { }
        [System.CLSCompliantAttribute(false)]
        public void Initialize<T>(uint numElements) where T : struct { }
        [System.CLSCompliantAttribute(false)]
        public void ReadArray<T>(ulong byteOffset, T[] array, int index, int count) where T : struct { }
        [System.CLSCompliantAttribute(false)]
        public T Read<T>(ulong byteOffset) where T : struct { throw null; }
        public void ReleasePointer() { }
        [System.CLSCompliantAttribute(false)]
        public void WriteArray<T>(ulong byteOffset, T[] array, int index, int count) where T : struct { }
        [System.CLSCompliantAttribute(false)]
        public void Write<T>(ulong byteOffset, T value) where T : struct { }
    }
    public abstract partial class SafeHandle : System.Runtime.ConstrainedExecution.CriticalFinalizerObject, System.IDisposable
    {
        protected System.IntPtr handle;
        protected SafeHandle(System.IntPtr invalidHandleValue, bool ownsHandle) { }
        public bool IsClosed { get { throw null; } }
        public abstract bool IsInvalid { get; }
        public void Close() { }
        public void DangerousAddRef(ref bool success) { }
        public System.IntPtr DangerousGetHandle() { throw null; }
        public void DangerousRelease() { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        ~SafeHandle() { }
        protected abstract bool ReleaseHandle();
        protected void SetHandle(System.IntPtr handle) { }
        public void SetHandleAsInvalid() { }
    }
    public partial class SEHException : System.Runtime.InteropServices.ExternalException
    {
        public SEHException() { }
        protected SEHException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public SEHException(string message) { }
        public SEHException(string message, System.Exception inner) { }
        public virtual bool CanResume() { throw null; }
    }
    public static partial class SequenceMarshal
    {
        public static bool TryGetArray<T>(System.Buffers.ReadOnlySequence<T> sequence, out System.ArraySegment<T> segment) { throw null; }
        public static bool TryGetReadOnlyMemory<T>(System.Buffers.ReadOnlySequence<T> sequence, out System.ReadOnlyMemory<T> memory) { throw null; }
        public static bool TryGetReadOnlySequenceSegment<T>(System.Buffers.ReadOnlySequence<T> sequence, out System.Buffers.ReadOnlySequenceSegment<T> startSegment, out int startIndex, out System.Buffers.ReadOnlySequenceSegment<T> endSegment, out int endIndex) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Struct, Inherited=false)]
    public sealed partial class StructLayoutAttribute : System.Attribute
    {
        public System.Runtime.InteropServices.CharSet CharSet;
        public int Pack;
        public int Size;
        public StructLayoutAttribute(short layoutKind) { }
        public StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind layoutKind) { }
        public System.Runtime.InteropServices.LayoutKind Value { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Delegate | System.AttributeTargets.Enum | System.AttributeTargets.Interface | System.AttributeTargets.Struct, AllowMultiple=false, Inherited=false)]
    public sealed partial class TypeIdentifierAttribute : System.Attribute
    {
        public TypeIdentifierAttribute() { }
        public TypeIdentifierAttribute(string scope, string identifier) { }
        public string Identifier { get { throw null; } }
        public string Scope { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method, Inherited=false)]
    public sealed partial class TypeLibFuncAttribute : System.Attribute
    {
        public TypeLibFuncAttribute(short flags) { }
        public TypeLibFuncAttribute(System.Runtime.InteropServices.TypeLibFuncFlags flags) { }
        public System.Runtime.InteropServices.TypeLibFuncFlags Value { get { throw null; } }
    }
    [System.FlagsAttribute]
    public enum TypeLibFuncFlags
    {
        FBindable = 4,
        FDefaultBind = 32,
        FDefaultCollelem = 256,
        FDisplayBind = 16,
        FHidden = 64,
        FImmediateBind = 4096,
        FNonBrowsable = 1024,
        FReplaceable = 2048,
        FRequestEdit = 8,
        FRestricted = 1,
        FSource = 2,
        FUiDefault = 512,
        FUsesGetLastError = 128,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Interface, Inherited=false)]
    public sealed partial class TypeLibImportClassAttribute : System.Attribute
    {
        public TypeLibImportClassAttribute(System.Type importClass) { }
        public string Value { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Enum | System.AttributeTargets.Interface | System.AttributeTargets.Struct, Inherited=false)]
    public sealed partial class TypeLibTypeAttribute : System.Attribute
    {
        public TypeLibTypeAttribute(short flags) { }
        public TypeLibTypeAttribute(System.Runtime.InteropServices.TypeLibTypeFlags flags) { }
        public System.Runtime.InteropServices.TypeLibTypeFlags Value { get { throw null; } }
    }
    [System.FlagsAttribute]
    public enum TypeLibTypeFlags
    {
        FAggregatable = 1024,
        FAppObject = 1,
        FCanCreate = 2,
        FControl = 32,
        FDispatchable = 4096,
        FDual = 64,
        FHidden = 16,
        FLicensed = 4,
        FNonExtensible = 128,
        FOleAutomation = 256,
        FPreDeclId = 8,
        FReplaceable = 2048,
        FRestricted = 512,
        FReverseBind = 8192,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Field, Inherited=false)]
    public sealed partial class TypeLibVarAttribute : System.Attribute
    {
        public TypeLibVarAttribute(short flags) { }
        public TypeLibVarAttribute(System.Runtime.InteropServices.TypeLibVarFlags flags) { }
        public System.Runtime.InteropServices.TypeLibVarFlags Value { get { throw null; } }
    }
    [System.FlagsAttribute]
    public enum TypeLibVarFlags
    {
        FBindable = 4,
        FDefaultBind = 32,
        FDefaultCollelem = 256,
        FDisplayBind = 16,
        FHidden = 64,
        FImmediateBind = 4096,
        FNonBrowsable = 1024,
        FReadOnly = 1,
        FReplaceable = 2048,
        FRequestEdit = 8,
        FRestricted = 128,
        FSource = 2,
        FUiDefault = 512,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, Inherited=false)]
    public sealed partial class TypeLibVersionAttribute : System.Attribute
    {
        public TypeLibVersionAttribute(int major, int minor) { }
        public int MajorVersion { get { throw null; } }
        public int MinorVersion { get { throw null; } }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.ObsoleteAttribute("UnknownWrapper and support for marshalling to the VARIANT type may be unavailable in future releases.")]
    public sealed partial class UnknownWrapper
    {
        public UnknownWrapper(object obj) { }
        public object WrappedObject { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Delegate, AllowMultiple=false, Inherited=false)]
    public sealed partial class UnmanagedFunctionPointerAttribute : System.Attribute
    {
        public bool BestFitMapping;
        public System.Runtime.InteropServices.CharSet CharSet;
        public bool SetLastError;
        public bool ThrowOnUnmappableChar;
        public UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention callingConvention) { }
        public System.Runtime.InteropServices.CallingConvention CallingConvention { get { throw null; } }
    }
    public enum UnmanagedType
    {
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("Marshalling as AnsiBStr may be unavailable in future releases.")]
        AnsiBStr = 35,
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("Marshalling arbitrary types may be unavailable in future releases. Please specify the type you wish to marshal as.")]
        AsAny = 40,
        Bool = 2,
        BStr = 19,
        ByValArray = 30,
        ByValTStr = 23,
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("Marshalling as Currency may be unavailable in future releases.")]
        Currency = 15,
        CustomMarshaler = 44,
        Error = 45,
        FunctionPtr = 38,
        HString = 47,
        I1 = 3,
        I2 = 5,
        I4 = 7,
        I8 = 9,
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("Marshalling as IDispatch may be unavailable in future releases.")]
        IDispatch = 26,
        IInspectable = 46,
        Interface = 28,
        IUnknown = 25,
        LPArray = 42,
        LPStr = 20,
        LPStruct = 43,
        LPTStr = 22,
        LPUTF8Str = 48,
        LPWStr = 21,
        R4 = 11,
        R8 = 12,
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("Marshalling as SafeArray may be unavailable in future releases.")]
        SafeArray = 29,
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("Applying UnmanagedType.Struct is unnecessary when marshalling a struct. Support for UnmanagedType.Struct when marshalling a reference type may be unavailable in future releases.")]
        Struct = 27,
        SysInt = 31,
        SysUInt = 32,
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("Marshalling as TBstr may be unavailable in future releases.")]
        TBStr = 36,
        U1 = 4,
        U2 = 6,
        U4 = 8,
        U8 = 10,
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("Marshalling as VariantBool may be unavailable in future releases.")]
        VariantBool = 37,
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("Marshalling as VBByRefString may be unavailable in future releases.")]
        VBByRefStr = 34,
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.ObsoleteAttribute("Marshalling VARIANTs may be unavailable in future releases.")]
    public enum VarEnum
    {
        VT_ARRAY = 8192,
        VT_BLOB = 65,
        VT_BLOB_OBJECT = 70,
        VT_BOOL = 11,
        VT_BSTR = 8,
        VT_BYREF = 16384,
        VT_CARRAY = 28,
        VT_CF = 71,
        VT_CLSID = 72,
        VT_CY = 6,
        VT_DATE = 7,
        VT_DECIMAL = 14,
        VT_DISPATCH = 9,
        VT_EMPTY = 0,
        VT_ERROR = 10,
        VT_FILETIME = 64,
        VT_HRESULT = 25,
        VT_I1 = 16,
        VT_I2 = 2,
        VT_I4 = 3,
        VT_I8 = 20,
        VT_INT = 22,
        VT_LPSTR = 30,
        VT_LPWSTR = 31,
        VT_NULL = 1,
        VT_PTR = 26,
        VT_R4 = 4,
        VT_R8 = 5,
        VT_RECORD = 36,
        VT_SAFEARRAY = 27,
        VT_STORAGE = 67,
        VT_STORED_OBJECT = 69,
        VT_STREAM = 66,
        VT_STREAMED_OBJECT = 68,
        VT_UI1 = 17,
        VT_UI2 = 18,
        VT_UI4 = 19,
        VT_UI8 = 21,
        VT_UINT = 23,
        VT_UNKNOWN = 13,
        VT_USERDEFINED = 29,
        VT_VARIANT = 12,
        VT_VECTOR = 4096,
        VT_VOID = 24,
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.ObsoleteAttribute("VariantWrapper and support for marshalling to the VARIANT type may be unavailable in future releases.")]
    public sealed partial class VariantWrapper
    {
        public VariantWrapper(object obj) { }
        public object WrappedObject { get { throw null; } }
    }
}
