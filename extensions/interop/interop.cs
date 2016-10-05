/*
APIs removed/broken by this factoring:

    public static partial class Marshal
    {
//INTEROP        public static void CleanupUnusedObjectsInCurrentContext() { }
//INTEROP        public static System.Guid GenerateGuidForType(System.Type type) { throw null; }
//INTEROP        public static string GenerateProgIdForType(System.Type type) { throw null; }
//INTEROP        public static object GetActiveObject(string progID) { throw null; }
//INTEROP        public static System.IntPtr GetComInterfaceForObjectInContext(object o, System.Type t) { throw null; }
//INTEROP        public static object GetComObjectData(object obj, object key) { throw null; }
//INTEROP        public static int GetComSlotForMethodInfo(System.Reflection.MemberInfo m) { throw null; }
//INTEROP        public static int GetEndComSlot(System.Type t) { throw null; }
//INTEROP        public static System.IntPtr GetExceptionPointers() { throw null; }
//INTEROP        public static System.IntPtr GetHINSTANCE(System.Reflection.Module m) { throw null; }
//INTEROP        public static System.IntPtr GetIDispatchForObject(object o) { throw null; }
//INTEROP        public static System.IntPtr GetIDispatchForObjectInContext(object o) { throw null; }
//INTEROP        public static System.IntPtr GetITypeInfoForType(System.Type t) { throw null; }
//INTEROP        public static System.IntPtr GetIUnknownForObjectInContext(object o) { throw null; }
//INTEROP        [System.ObsoleteAttribute("The GetManagedThunkForUnmanagedMethodPtr method has been deprecated and will be removed in a future release.", false)]
//INTEROP        public static System.IntPtr GetManagedThunkForUnmanagedMethodPtr(System.IntPtr pfnMethodToWrap, System.IntPtr pbSignature, int cbSignature) { throw null; }
//INTEROP        public static System.Reflection.MemberInfo GetMethodInfoForComSlot(System.Type t, int slot, ref System.Runtime.InteropServices.ComMemberType memberType) { throw null; }
//INTEROP        [System.ObsoleteAttribute("The GetThreadFromFiberCookie method has been deprecated.  Use the hosting API to perform this operation.", false)]
//INTEROP        public static System.Threading.Thread GetThreadFromFiberCookie(int cookie) { throw null; }
//INTEROP        public static object GetTypedObjectForIUnknown(System.IntPtr pUnk, System.Type t) { throw null; }
//INTEROP        public static System.Type GetTypeForITypeInfo(System.IntPtr piTypeInfo) { throw null; }
//INTEROP        [System.ObsoleteAttribute("Use System.Runtime.InteropServices.Marshal.GetTypeInfoName(ITypeInfo pTLB) instead. http://go.microsoft.com/fwlink/?linkid=14202&ID=0000011.", false)]
//INTEROP        public static string GetTypeInfoName(System.Runtime.InteropServices.UCOMITypeInfo pTI) { throw null; }
//INTEROP        public static System.Guid GetTypeLibGuid(System.Runtime.InteropServices.ComTypes.ITypeLib typelib) { throw null; }
//INTEROP        [System.ObsoleteAttribute("Use System.Runtime.InteropServices.Marshal.GetTypeLibGuid(ITypeLib pTLB) instead. http://go.microsoft.com/fwlink/?linkid=14202&ID=0000011.", false)]
//INTEROP        public static System.Guid GetTypeLibGuid(System.Runtime.InteropServices.UCOMITypeLib pTLB) { throw null; }
//INTEROP        public static System.Guid GetTypeLibGuidForAssembly(System.Reflection.Assembly asm) { throw null; }
//INTEROP        public static int GetTypeLibLcid(System.Runtime.InteropServices.ComTypes.ITypeLib typelib) { throw null; }
//INTEROP        [System.ObsoleteAttribute("Use System.Runtime.InteropServices.Marshal.GetTypeLibLcid(ITypeLib pTLB) instead. http://go.microsoft.com/fwlink/?linkid=14202&ID=0000011.", false)]
//INTEROP        public static int GetTypeLibLcid(System.Runtime.InteropServices.UCOMITypeLib pTLB) { throw null; }
//INTEROP        public static string GetTypeLibName(System.Runtime.InteropServices.ComTypes.ITypeLib typelib) { throw null; }
//INTEROP        [System.ObsoleteAttribute("Use System.Runtime.InteropServices.Marshal.GetTypeLibName(ITypeLib pTLB) instead. http://go.microsoft.com/fwlink/?linkid=14202&ID=0000011.", false)]
//INTEROP        public static string GetTypeLibName(System.Runtime.InteropServices.UCOMITypeLib pTLB) { throw null; }
//INTEROP        public static void GetTypeLibVersionForAssembly(System.Reflection.Assembly inputAssembly, out int majorVersion, out int minorVersion) { majorVersion = default(int); minorVersion = default(int); }
//INTEROP        [System.ObsoleteAttribute("The GetUnmanagedThunkForManagedMethodPtr method has been deprecated and will be removed in a future release.", false)]
//INTEROP        public static System.IntPtr GetUnmanagedThunkForManagedMethodPtr(System.IntPtr pfnMethodToWrap, System.IntPtr pbSignature, int cbSignature) { throw null; }
//INTEROP        public static bool IsTypeVisibleFromCom(System.Type t) { throw null; }
//INTEROP        public static int NumParamBytes(System.Reflection.MethodInfo m) { throw null; }
//INTEROP        [System.ObsoleteAttribute("This API did not perform any operation and will be removed in future versions of the CLR.", false)]
//INTEROP        public static void ReleaseThreadCache() { }
//INTEROP        public static bool SetComObjectData(object obj, object key, object data) { throw null; }
    }
    public partial class RuntimeEnvironment
    {
//INTEROP        public static System.IntPtr GetRuntimeInterfaceAsIntPtr(System.Guid clsid, System.Guid riid) { throw null; }
//INTEROP        public static object GetRuntimeInterfaceAsObject(System.Guid clsid, System.Guid riid) { throw null; }
    }

*/
namespace System.Runtime.CompilerServices
{
    [System.AttributeUsageAttribute((System.AttributeTargets)(2304), Inherited=false)]
    public sealed partial class IDispatchConstantAttribute : System.Runtime.CompilerServices.CustomConstantAttribute
    {
        public IDispatchConstantAttribute() { }
        public override object Value { get { throw null; } }
    }
}
namespace System.Runtime.DesignerServices
{
    public sealed partial class WindowsRuntimeDesignerContext
    {
        public WindowsRuntimeDesignerContext(System.Collections.Generic.IEnumerable<string> paths, string name) { }
        public string Name { get { throw null; } }
        public System.Reflection.Assembly GetAssembly(string assemblyName) { throw null; }
        public System.Type GetType(string typeName) { throw null; }
        public static void InitializeSharedContext(System.Collections.Generic.IEnumerable<string> paths) { }
        public static void SetIterationContext(System.Runtime.DesignerServices.WindowsRuntimeDesignerContext context) { }
    }
}
namespace System.Runtime.InteropServices
{
    [System.FlagsAttribute]
    public enum AssemblyRegistrationFlags
    {
        None = 0,
        SetCodeBase = 1,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1029), Inherited=false)]
    public sealed partial class AutomationProxyAttribute : System.Attribute
    {
        public AutomationProxyAttribute(bool val) { }
        public bool Value { get { throw null; } }
    }
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.BIND_OPTS instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct BIND_OPTS
    {
        public int cbStruct;
        public int dwTickCountDeadline;
        public int grfFlags;
        public int grfMode;
    }
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.BINDPTR instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
    public partial struct BINDPTR
    {
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public System.IntPtr lpfuncdesc;
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public System.IntPtr lptcomp;
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public System.IntPtr lpvardesc;
    }
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.CALLCONV instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public enum CALLCONV
    {
        CC_CDECL = 1,
        CC_MACPASCAL = 3,
        CC_MAX = 9,
        CC_MPWCDECL = 7,
        CC_MPWPASCAL = 8,
        CC_MSCPASCAL = 2,
        CC_PASCAL = 2,
        CC_RESERVED = 5,
        CC_STDCALL = 4,
        CC_SYSCALL = 6,
    }
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.CONNECTDATA instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct CONNECTDATA
    {
        public int dwCookie;
        public object pUnk;
    }
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.DESCKIND instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public enum DESCKIND
    {
        DESCKIND_FUNCDESC = 1,
        DESCKIND_IMPLICITAPPOBJ = 4,
        DESCKIND_MAX = 5,
        DESCKIND_NONE = 0,
        DESCKIND_TYPECOMP = 3,
        DESCKIND_VARDESC = 2,
    }
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.DISPPARAMS instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct DISPPARAMS
    {
        public int cArgs;
        public int cNamedArgs;
        public System.IntPtr rgdispidNamedArgs;
        public System.IntPtr rgvarg;
    }
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.ELEMDESC instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct ELEMDESC
    {
        public System.Runtime.InteropServices.ELEMDESC.DESCUNION desc;
        public System.Runtime.InteropServices.TYPEDESC tdesc;
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public partial struct DESCUNION
        {
            [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
            public System.Runtime.InteropServices.IDLDESC idldesc;
            [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
            public System.Runtime.InteropServices.PARAMDESC paramdesc;
        }
    }
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.EXCEPINFO instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct EXCEPINFO
    {
        public string bstrDescription;
        public string bstrHelpFile;
        public string bstrSource;
        public int dwHelpContext;
        public System.IntPtr pfnDeferredFillIn;
        public System.IntPtr pvReserved;
        public short wCode;
        public short wReserved;
    }
    public enum ExporterEventKind
    {
        ERROR_REFTOINVALIDASSEMBLY = 2,
        NOTIF_CONVERTWARNING = 1,
        NOTIF_TYPECONVERTED = 0,
    }
    public sealed partial class ExtensibleClassFactory
    {
        internal ExtensibleClassFactory() { }
        public static void RegisterObjectCreationCallback(System.Runtime.InteropServices.ObjectCreationDelegate callback) { }
    }
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.FILETIME instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct FILETIME
    {
        public int dwHighDateTime;
        public int dwLowDateTime;
    }
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.FUNCDESC instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct FUNCDESC
    {
        public System.Runtime.InteropServices.CALLCONV callconv;
        public short cParams;
        public short cParamsOpt;
        public short cScodes;
        public System.Runtime.InteropServices.ELEMDESC elemdescFunc;
        public System.Runtime.InteropServices.FUNCKIND funckind;
        public System.Runtime.InteropServices.INVOKEKIND invkind;
        public System.IntPtr lprgelemdescParam;
        public System.IntPtr lprgscode;
        public int memid;
        public short oVft;
        public short wFuncFlags;
    }
    [System.FlagsAttribute]
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.FUNCFLAGS instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public enum FUNCFLAGS : short
    {
        FUNCFLAG_FBINDABLE = (short)4,
        FUNCFLAG_FDEFAULTBIND = (short)32,
        FUNCFLAG_FDEFAULTCOLLELEM = (short)256,
        FUNCFLAG_FDISPLAYBIND = (short)16,
        FUNCFLAG_FHIDDEN = (short)64,
        FUNCFLAG_FIMMEDIATEBIND = (short)4096,
        FUNCFLAG_FNONBROWSABLE = (short)1024,
        FUNCFLAG_FREPLACEABLE = (short)2048,
        FUNCFLAG_FREQUESTEDIT = (short)8,
        FUNCFLAG_FRESTRICTED = (short)1,
        FUNCFLAG_FSOURCE = (short)2,
        FUNCFLAG_FUIDEFAULT = (short)512,
        FUNCFLAG_FUSESGETLASTERROR = (short)128,
    }
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.FUNCKIND instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public enum FUNCKIND
    {
        FUNC_DISPATCH = 4,
        FUNC_NONVIRTUAL = 2,
        FUNC_PUREVIRTUAL = 1,
        FUNC_STATIC = 3,
        FUNC_VIRTUAL = 0,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(5), Inherited=false)]
    [System.ObsoleteAttribute("This attribute is deprecated and will be removed in a future version.", false)]
    public sealed partial class IDispatchImplAttribute : System.Attribute
    {
        public IDispatchImplAttribute(short implType) { }
        public IDispatchImplAttribute(System.Runtime.InteropServices.IDispatchImplType implType) { }
        public System.Runtime.InteropServices.IDispatchImplType Value { get { throw null; } }
    }
    [System.ObsoleteAttribute("The IDispatchImplAttribute is deprecated.", false)]
    public enum IDispatchImplType
    {
        CompatibleImpl = 2,
        InternalImpl = 1,
        SystemDefinedImpl = 0,
    }
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.IDLDESC instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct IDLDESC
    {
        public int dwReserved;
        public System.Runtime.InteropServices.IDLFLAG wIDLFlags;
    }
    [System.FlagsAttribute]
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.IDLFLAG instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public enum IDLFLAG : short
    {
        IDLFLAG_FIN = (short)1,
        IDLFLAG_FLCID = (short)4,
        IDLFLAG_FOUT = (short)2,
        IDLFLAG_FRETVAL = (short)8,
        IDLFLAG_NONE = (short)0,
    }
    [System.FlagsAttribute]
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.IMPLTYPEFLAGS instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public enum IMPLTYPEFLAGS
    {
        IMPLTYPEFLAG_FDEFAULT = 1,
        IMPLTYPEFLAG_FDEFAULTVTABLE = 8,
        IMPLTYPEFLAG_FRESTRICTED = 4,
        IMPLTYPEFLAG_FSOURCE = 2,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1), Inherited=false)]
    public sealed partial class ImportedFromTypeLibAttribute : System.Attribute
    {
        public ImportedFromTypeLibAttribute(string tlbFile) { }
        public string Value { get { throw null; } }
    }
    public enum ImporterEventKind
    {
        ERROR_REFTOINVALIDTYPELIB = 2,
        NOTIF_CONVERTWARNING = 1,
        NOTIF_TYPECONVERTED = 0,
    }
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.INVOKEKIND instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public enum INVOKEKIND
    {
        INVOKE_FUNC = 1,
        INVOKE_PROPERTYGET = 2,
        INVOKE_PROPERTYPUT = 4,
        INVOKE_PROPERTYPUTREF = 8,
    }
    public partial interface IRegistrationServices
    {
        System.Guid GetManagedCategoryGuid();
        string GetProgIdForType(System.Type type);
        System.Type[] GetRegistrableTypesInAssembly(System.Reflection.Assembly assembly);
        bool RegisterAssembly(System.Reflection.Assembly assembly, System.Runtime.InteropServices.AssemblyRegistrationFlags flags);
        void RegisterTypeForComClients(System.Type type, ref System.Guid g);
        bool TypeRepresentsComType(System.Type type);
        bool TypeRequiresRegistration(System.Type type);
        bool UnregisterAssembly(System.Reflection.Assembly assembly);
    }
    public partial interface ITypeLibConverter
    {
        object ConvertAssemblyToTypeLib(System.Reflection.Assembly assembly, string typeLibName, System.Runtime.InteropServices.TypeLibExporterFlags flags, System.Runtime.InteropServices.ITypeLibExporterNotifySink notifySink);
//REFEMIT        System.Reflection.Emit.AssemblyBuilder ConvertTypeLibToAssembly(object typeLib, string asmFileName, int flags, System.Runtime.InteropServices.ITypeLibImporterNotifySink notifySink, byte[] publicKey, System.Reflection.StrongNameKeyPair keyPair, bool unsafeInterfaces);
//REFEMIT        System.Reflection.Emit.AssemblyBuilder ConvertTypeLibToAssembly(object typeLib, string asmFileName, System.Runtime.InteropServices.TypeLibImporterFlags flags, System.Runtime.InteropServices.ITypeLibImporterNotifySink notifySink, byte[] publicKey, System.Reflection.StrongNameKeyPair keyPair, string asmNamespace, System.Version asmVersion);
        bool GetPrimaryInteropAssembly(System.Guid g, int major, int minor, int lcid, out string asmName, out string asmCodeBase);
    }
    public partial interface ITypeLibExporterNameProvider
    {
        string[] GetNames();
    }
    public partial interface ITypeLibExporterNotifySink
    {
        void ReportEvent(System.Runtime.InteropServices.ExporterEventKind eventKind, int eventCode, string eventMsg);
        object ResolveRef(System.Reflection.Assembly assembly);
    }
    public partial interface ITypeLibImporterNotifySink
    {
        void ReportEvent(System.Runtime.InteropServices.ImporterEventKind eventKind, int eventCode, string eventMsg);
        System.Reflection.Assembly ResolveRef(object typeLib);
    }
    [System.FlagsAttribute]
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.LIBFLAGS instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public enum LIBFLAGS : short
    {
        LIBFLAG_FCONTROL = (short)2,
        LIBFLAG_FHASDISKIMAGE = (short)8,
        LIBFLAG_FHIDDEN = (short)4,
        LIBFLAG_FRESTRICTED = (short)1,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64), Inherited=false, AllowMultiple=false)]
    public sealed partial class ManagedToNativeComInteropStubAttribute : System.Attribute
    {
        public ManagedToNativeComInteropStubAttribute(System.Type classType, string methodName) { }
        public System.Type ClassType { get { throw null; } }
        public string MethodName { get { throw null; } }
    }
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.PARAMDESC instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct PARAMDESC
    {
        public System.IntPtr lpVarValue;
        public System.Runtime.InteropServices.PARAMFLAG wParamFlags;
    }
    [System.FlagsAttribute]
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.PARAMFLAG instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public enum PARAMFLAG : short
    {
        PARAMFLAG_FHASCUSTDATA = (short)64,
        PARAMFLAG_FHASDEFAULT = (short)32,
        PARAMFLAG_FIN = (short)1,
        PARAMFLAG_FLCID = (short)4,
        PARAMFLAG_FOPT = (short)16,
        PARAMFLAG_FOUT = (short)2,
        PARAMFLAG_FRETVAL = (short)8,
        PARAMFLAG_NONE = (short)0,
    }
    [System.FlagsAttribute]
    public enum RegistrationClassContext
    {
        DisableActivateAsActivator = 32768,
        EnableActivateAsActivator = 65536,
        EnableCodeDownload = 8192,
        FromDefaultContext = 131072,
        InProcessHandler = 2,
        InProcessHandler16 = 32,
        InProcessServer = 1,
        InProcessServer16 = 8,
        LocalServer = 4,
        NoCodeDownload = 1024,
        NoCustomMarshal = 4096,
        NoFailureLog = 16384,
        RemoteServer = 16,
        Reserved1 = 64,
        Reserved2 = 128,
        Reserved3 = 256,
        Reserved4 = 512,
        Reserved5 = 2048,
    }
    [System.FlagsAttribute]
    public enum RegistrationConnectionType
    {
        MultipleUse = 1,
        MultiSeparate = 2,
        SingleUse = 0,
        Surrogate = 8,
        Suspended = 4,
    }
    public partial class RegistrationServices : System.Runtime.InteropServices.IRegistrationServices
    {
        public RegistrationServices() { }
        public virtual System.Guid GetManagedCategoryGuid() { throw null; }
        public virtual string GetProgIdForType(System.Type type) { throw null; }
        public virtual System.Type[] GetRegistrableTypesInAssembly(System.Reflection.Assembly assembly) { throw null; }
        public virtual bool RegisterAssembly(System.Reflection.Assembly assembly, System.Runtime.InteropServices.AssemblyRegistrationFlags flags) { throw null; }
        public virtual void RegisterTypeForComClients(System.Type type, ref System.Guid g) { }
        public virtual int RegisterTypeForComClients(System.Type type, System.Runtime.InteropServices.RegistrationClassContext classContext, System.Runtime.InteropServices.RegistrationConnectionType flags) { throw null; }
        public virtual bool TypeRepresentsComType(System.Type type) { throw null; }
        public virtual bool TypeRequiresRegistration(System.Type type) { throw null; }
        public virtual bool UnregisterAssembly(System.Reflection.Assembly assembly) { throw null; }
        public virtual void UnregisterTypeForComClients(int cookie) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1), Inherited=false)]
    [System.ObsoleteAttribute("This attribute has been deprecated.  Application Domains no longer respect Activation Context boundaries in IDispatch calls.", false)]
    public sealed partial class SetWin32ContextInIDispatchAttribute : System.Attribute
    {
        public SetWin32ContextInIDispatchAttribute() { }
    }
    public partial class StandardOleMarshalObject : System.MarshalByRefObject
    {
        protected StandardOleMarshalObject() { }
    }
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.STATSTG instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct STATSTG
    {
        public System.Runtime.InteropServices.FILETIME atime;
        public long cbSize;
        public System.Guid clsid;
        public System.Runtime.InteropServices.FILETIME ctime;
        public int grfLocksSupported;
        public int grfMode;
        public int grfStateBits;
        public System.Runtime.InteropServices.FILETIME mtime;
        public string pwcsName;
        public int reserved;
        public int type;
    }
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.SYSKIND instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public enum SYSKIND
    {
        SYS_MAC = 2,
        SYS_WIN16 = 0,
        SYS_WIN32 = 1,
    }
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.TYPEATTR instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct TYPEATTR
    {
        public short cbAlignment;
        public int cbSizeInstance;
        public short cbSizeVft;
        public short cFuncs;
        public short cImplTypes;
        public short cVars;
        public int dwReserved;
        public System.Guid guid;
        public System.Runtime.InteropServices.IDLDESC idldescType;
        public int lcid;
        public System.IntPtr lpstrSchema;
        public const int MEMBER_ID_NIL = -1;
        public int memidConstructor;
        public int memidDestructor;
        public System.Runtime.InteropServices.TYPEDESC tdescAlias;
        public System.Runtime.InteropServices.TYPEKIND typekind;
        public short wMajorVerNum;
        public short wMinorVerNum;
        public System.Runtime.InteropServices.TYPEFLAGS wTypeFlags;
    }
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.TYPEKIND instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public enum TYPEKIND
    {
        TKIND_ALIAS = 6,
        TKIND_COCLASS = 5,
        TKIND_DISPATCH = 4,
        TKIND_ENUM = 0,
        TKIND_INTERFACE = 3,
        TKIND_MAX = 8,
        TKIND_MODULE = 2,
        TKIND_RECORD = 1,
        TKIND_UNION = 7,
    }
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.TYPEDESC instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct TYPEDESC
    {
        public System.IntPtr lpValue;
        public short vt;
    }
    [System.FlagsAttribute]
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.TYPEFLAGS instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public enum TYPEFLAGS : short
    {
        TYPEFLAG_FAGGREGATABLE = (short)1024,
        TYPEFLAG_FAPPOBJECT = (short)1,
        TYPEFLAG_FCANCREATE = (short)2,
        TYPEFLAG_FCONTROL = (short)32,
        TYPEFLAG_FDISPATCHABLE = (short)4096,
        TYPEFLAG_FDUAL = (short)64,
        TYPEFLAG_FHIDDEN = (short)16,
        TYPEFLAG_FLICENSED = (short)4,
        TYPEFLAG_FNONEXTENSIBLE = (short)128,
        TYPEFLAG_FOLEAUTOMATION = (short)256,
        TYPEFLAG_FPREDECLID = (short)8,
        TYPEFLAG_FPROXY = (short)16384,
        TYPEFLAG_FREPLACEABLE = (short)2048,
        TYPEFLAG_FRESTRICTED = (short)512,
        TYPEFLAG_FREVERSEBIND = (short)8192,
    }
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.TYPELIBATTR instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct TYPELIBATTR
    {
        public System.Guid guid;
        public int lcid;
        public System.Runtime.InteropServices.SYSKIND syskind;
        public System.Runtime.InteropServices.LIBFLAGS wLibFlags;
        public short wMajorVerNum;
        public short wMinorVerNum;
    }
    public sealed partial class TypeLibConverter : System.Runtime.InteropServices.ITypeLibConverter
    {
        public TypeLibConverter() { }
        public object ConvertAssemblyToTypeLib(System.Reflection.Assembly assembly, string strTypeLibName, System.Runtime.InteropServices.TypeLibExporterFlags flags, System.Runtime.InteropServices.ITypeLibExporterNotifySink notifySink) { throw null; }
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder ConvertTypeLibToAssembly(object typeLib, string asmFileName, int flags, System.Runtime.InteropServices.ITypeLibImporterNotifySink notifySink, byte[] publicKey, System.Reflection.StrongNameKeyPair keyPair, bool unsafeInterfaces) { throw null; }
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder ConvertTypeLibToAssembly(object typeLib, string asmFileName, System.Runtime.InteropServices.TypeLibImporterFlags flags, System.Runtime.InteropServices.ITypeLibImporterNotifySink notifySink, byte[] publicKey, System.Reflection.StrongNameKeyPair keyPair, string asmNamespace, System.Version asmVersion) { throw null; }
        public bool GetPrimaryInteropAssembly(System.Guid g, int major, int minor, int lcid, out string asmName, out string asmCodeBase) { asmName = default(string); asmCodeBase = default(string); throw null; }
    }
    [System.FlagsAttribute]
    public enum TypeLibExporterFlags
    {
        CallerResolvedReferences = 2,
        ExportAs32Bit = 16,
        ExportAs64Bit = 32,
        None = 0,
        OldNames = 4,
        OnlyReferenceRegistered = 1,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64), Inherited=false)]
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
    [System.AttributeUsageAttribute((System.AttributeTargets)(1024), Inherited=false)]
    public sealed partial class TypeLibImportClassAttribute : System.Attribute
    {
        public TypeLibImportClassAttribute(System.Type importClass) { }
        public string Value { get { throw null; } }
    }
    [System.FlagsAttribute]
    public enum TypeLibImporterFlags
    {
        ImportAsAgnostic = 2048,
        ImportAsArm = 16384,
        ImportAsItanium = 1024,
        ImportAsX64 = 512,
        ImportAsX86 = 256,
        NoDefineVersionResource = 8192,
        None = 0,
        PreventClassMembers = 16,
        PrimaryInteropAssembly = 1,
        ReflectionOnlyLoading = 4096,
        SafeArrayAsSystemArray = 4,
        SerializableValueClasses = 32,
        TransformDispRetVals = 8,
        UnsafeInterfaces = 2,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1052), Inherited=false)]
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
    [System.AttributeUsageAttribute((System.AttributeTargets)(256), Inherited=false)]
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
    [System.AttributeUsageAttribute((System.AttributeTargets)(1), Inherited=false)]
    public sealed partial class TypeLibVersionAttribute : System.Attribute
    {
        public TypeLibVersionAttribute(int major, int minor) { }
        public int MajorVersion { get { throw null; } }
        public int MinorVersion { get { throw null; } }
    }
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.IBindCtx instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public partial interface UCOMIBindCtx
    {
        void EnumObjectParam(out System.Runtime.InteropServices.UCOMIEnumString ppenum);
        void GetBindOptions(ref System.Runtime.InteropServices.BIND_OPTS pbindopts);
        void GetObjectParam(string pszKey, out object ppunk);
        void GetRunningObjectTable(out System.Runtime.InteropServices.UCOMIRunningObjectTable pprot);
        void RegisterObjectBound(object punk);
        void RegisterObjectParam(string pszKey, object punk);
        void ReleaseBoundObjects();
        void RevokeObjectBound(object punk);
        void RevokeObjectParam(string pszKey);
        void SetBindOptions(ref System.Runtime.InteropServices.BIND_OPTS pbindopts);
    }
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.IConnectionPoint instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public partial interface UCOMIConnectionPoint
    {
        void Advise(object pUnkSink, out int pdwCookie);
        void EnumConnections(out System.Runtime.InteropServices.UCOMIEnumConnections ppEnum);
        void GetConnectionInterface(out System.Guid pIID);
        void GetConnectionPointContainer(out System.Runtime.InteropServices.UCOMIConnectionPointContainer ppCPC);
        void Unadvise(int dwCookie);
    }
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.IConnectionPointContainer instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public partial interface UCOMIConnectionPointContainer
    {
        void EnumConnectionPoints(out System.Runtime.InteropServices.UCOMIEnumConnectionPoints ppEnum);
        void FindConnectionPoint(ref System.Guid riid, out System.Runtime.InteropServices.UCOMIConnectionPoint ppCP);
    }
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.IEnumConnectionPoints instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public partial interface UCOMIEnumConnectionPoints
    {
        void Clone(out System.Runtime.InteropServices.UCOMIEnumConnectionPoints ppenum);
        int Next(int celt, System.Runtime.InteropServices.UCOMIConnectionPoint[] rgelt, out int pceltFetched);
        int Reset();
        int Skip(int celt);
    }
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.IEnumConnections instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public partial interface UCOMIEnumConnections
    {
        void Clone(out System.Runtime.InteropServices.UCOMIEnumConnections ppenum);
        int Next(int celt, System.Runtime.InteropServices.CONNECTDATA[] rgelt, out int pceltFetched);
        void Reset();
        int Skip(int celt);
    }
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.IEnumMoniker instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public partial interface UCOMIEnumMoniker
    {
        void Clone(out System.Runtime.InteropServices.UCOMIEnumMoniker ppenum);
        int Next(int celt, System.Runtime.InteropServices.UCOMIMoniker[] rgelt, out int pceltFetched);
        int Reset();
        int Skip(int celt);
    }
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.IEnumString instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public partial interface UCOMIEnumString
    {
        void Clone(out System.Runtime.InteropServices.UCOMIEnumString ppenum);
        int Next(int celt, string[] rgelt, out int pceltFetched);
        int Reset();
        int Skip(int celt);
    }
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.IEnumVARIANT instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public partial interface UCOMIEnumVARIANT
    {
        void Clone(int ppenum);
        int Next(int celt, int rgvar, int pceltFetched);
        int Reset();
        int Skip(int celt);
    }
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.IMoniker instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public partial interface UCOMIMoniker
    {
        void BindToObject(System.Runtime.InteropServices.UCOMIBindCtx pbc, System.Runtime.InteropServices.UCOMIMoniker pmkToLeft, ref System.Guid riidResult, out object ppvResult);
        void BindToStorage(System.Runtime.InteropServices.UCOMIBindCtx pbc, System.Runtime.InteropServices.UCOMIMoniker pmkToLeft, ref System.Guid riid, out object ppvObj);
        void CommonPrefixWith(System.Runtime.InteropServices.UCOMIMoniker pmkOther, out System.Runtime.InteropServices.UCOMIMoniker ppmkPrefix);
        void ComposeWith(System.Runtime.InteropServices.UCOMIMoniker pmkRight, bool fOnlyIfNotGeneric, out System.Runtime.InteropServices.UCOMIMoniker ppmkComposite);
        void Enum(bool fForward, out System.Runtime.InteropServices.UCOMIEnumMoniker ppenumMoniker);
        void GetClassID(out System.Guid pClassID);
        void GetDisplayName(System.Runtime.InteropServices.UCOMIBindCtx pbc, System.Runtime.InteropServices.UCOMIMoniker pmkToLeft, out string ppszDisplayName);
        void GetSizeMax(out long pcbSize);
        void GetTimeOfLastChange(System.Runtime.InteropServices.UCOMIBindCtx pbc, System.Runtime.InteropServices.UCOMIMoniker pmkToLeft, out System.Runtime.InteropServices.FILETIME pFileTime);
        void Hash(out int pdwHash);
        void Inverse(out System.Runtime.InteropServices.UCOMIMoniker ppmk);
        int IsDirty();
        void IsEqual(System.Runtime.InteropServices.UCOMIMoniker pmkOtherMoniker);
        void IsRunning(System.Runtime.InteropServices.UCOMIBindCtx pbc, System.Runtime.InteropServices.UCOMIMoniker pmkToLeft, System.Runtime.InteropServices.UCOMIMoniker pmkNewlyRunning);
        void IsSystemMoniker(out int pdwMksys);
        void Load(System.Runtime.InteropServices.UCOMIStream pStm);
        void ParseDisplayName(System.Runtime.InteropServices.UCOMIBindCtx pbc, System.Runtime.InteropServices.UCOMIMoniker pmkToLeft, string pszDisplayName, out int pchEaten, out System.Runtime.InteropServices.UCOMIMoniker ppmkOut);
        void Reduce(System.Runtime.InteropServices.UCOMIBindCtx pbc, int dwReduceHowFar, ref System.Runtime.InteropServices.UCOMIMoniker ppmkToLeft, out System.Runtime.InteropServices.UCOMIMoniker ppmkReduced);
        void RelativePathTo(System.Runtime.InteropServices.UCOMIMoniker pmkOther, out System.Runtime.InteropServices.UCOMIMoniker ppmkRelPath);
        void Save(System.Runtime.InteropServices.UCOMIStream pStm, bool fClearDirty);
    }
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.IPersistFile instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public partial interface UCOMIPersistFile
    {
        void GetClassID(out System.Guid pClassID);
        void GetCurFile(out string ppszFileName);
        int IsDirty();
        void Load(string pszFileName, int dwMode);
        void Save(string pszFileName, bool fRemember);
        void SaveCompleted(string pszFileName);
    }
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.IRunningObjectTable instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public partial interface UCOMIRunningObjectTable
    {
        void EnumRunning(out System.Runtime.InteropServices.UCOMIEnumMoniker ppenumMoniker);
        void GetObject(System.Runtime.InteropServices.UCOMIMoniker pmkObjectName, out object ppunkObject);
        void GetTimeOfLastChange(System.Runtime.InteropServices.UCOMIMoniker pmkObjectName, out System.Runtime.InteropServices.FILETIME pfiletime);
        void IsRunning(System.Runtime.InteropServices.UCOMIMoniker pmkObjectName);
        void NoteChangeTime(int dwRegister, ref System.Runtime.InteropServices.FILETIME pfiletime);
        void Register(int grfFlags, object punkObject, System.Runtime.InteropServices.UCOMIMoniker pmkObjectName, out int pdwRegister);
        void Revoke(int dwRegister);
    }
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.IStream instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public partial interface UCOMIStream
    {
        void Clone(out System.Runtime.InteropServices.UCOMIStream ppstm);
        void Commit(int grfCommitFlags);
        void CopyTo(System.Runtime.InteropServices.UCOMIStream pstm, long cb, System.IntPtr pcbRead, System.IntPtr pcbWritten);
        void LockRegion(long libOffset, long cb, int dwLockType);
        void Read(byte[] pv, int cb, System.IntPtr pcbRead);
        void Revert();
        void Seek(long dlibMove, int dwOrigin, System.IntPtr plibNewPosition);
        void SetSize(long libNewSize);
        void Stat(out System.Runtime.InteropServices.STATSTG pstatstg, int grfStatFlag);
        void UnlockRegion(long libOffset, long cb, int dwLockType);
        void Write(byte[] pv, int cb, System.IntPtr pcbWritten);
    }
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.ITypeComp instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public partial interface UCOMITypeComp
    {
        void Bind(string szName, int lHashVal, short wFlags, out System.Runtime.InteropServices.UCOMITypeInfo ppTInfo, out System.Runtime.InteropServices.DESCKIND pDescKind, out System.Runtime.InteropServices.BINDPTR pBindPtr);
        void BindType(string szName, int lHashVal, out System.Runtime.InteropServices.UCOMITypeInfo ppTInfo, out System.Runtime.InteropServices.UCOMITypeComp ppTComp);
    }
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.ITypeInfo instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public partial interface UCOMITypeInfo
    {
        void AddressOfMember(int memid, System.Runtime.InteropServices.INVOKEKIND invKind, out System.IntPtr ppv);
        void CreateInstance(object pUnkOuter, ref System.Guid riid, out object ppvObj);
        void GetContainingTypeLib(out System.Runtime.InteropServices.UCOMITypeLib ppTLB, out int pIndex);
        void GetDllEntry(int memid, System.Runtime.InteropServices.INVOKEKIND invKind, out string pBstrDllName, out string pBstrName, out short pwOrdinal);
        void GetDocumentation(int index, out string strName, out string strDocString, out int dwHelpContext, out string strHelpFile);
        void GetFuncDesc(int index, out System.IntPtr ppFuncDesc);
        void GetIDsOfNames(string[] rgszNames, int cNames, int[] pMemId);
        void GetImplTypeFlags(int index, out int pImplTypeFlags);
        void GetMops(int memid, out string pBstrMops);
        void GetNames(int memid, string[] rgBstrNames, int cMaxNames, out int pcNames);
        void GetRefTypeInfo(int hRef, out System.Runtime.InteropServices.UCOMITypeInfo ppTI);
        void GetRefTypeOfImplType(int index, out int href);
        void GetTypeAttr(out System.IntPtr ppTypeAttr);
        void GetTypeComp(out System.Runtime.InteropServices.UCOMITypeComp ppTComp);
        void GetVarDesc(int index, out System.IntPtr ppVarDesc);
        void Invoke(object pvInstance, int memid, short wFlags, ref System.Runtime.InteropServices.DISPPARAMS pDispParams, out object pVarResult, out System.Runtime.InteropServices.EXCEPINFO pExcepInfo, out int puArgErr);
        void ReleaseFuncDesc(System.IntPtr pFuncDesc);
        void ReleaseTypeAttr(System.IntPtr pTypeAttr);
        void ReleaseVarDesc(System.IntPtr pVarDesc);
    }
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.ITypeLib instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public partial interface UCOMITypeLib
    {
        void FindName(string szNameBuf, int lHashVal, System.Runtime.InteropServices.UCOMITypeInfo[] ppTInfo, int[] rgMemId, ref short pcFound);
        void GetDocumentation(int index, out string strName, out string strDocString, out int dwHelpContext, out string strHelpFile);
        void GetLibAttr(out System.IntPtr ppTLibAttr);
        void GetTypeComp(out System.Runtime.InteropServices.UCOMITypeComp ppTComp);
        void GetTypeInfo(int index, out System.Runtime.InteropServices.UCOMITypeInfo ppTI);
        int GetTypeInfoCount();
        void GetTypeInfoOfGuid(ref System.Guid guid, out System.Runtime.InteropServices.UCOMITypeInfo ppTInfo);
        void GetTypeInfoType(int index, out System.Runtime.InteropServices.TYPEKIND pTKind);
        bool IsName(string szNameBuf, int lHashVal);
        void ReleaseTLibAttr(System.IntPtr pTLibAttr);
    }
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.VARDESC instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct VARDESC
    {
        public System.Runtime.InteropServices.ELEMDESC elemdescVar;
        public string lpstrSchema;
        public int memid;
        public System.Runtime.InteropServices.VarEnum varkind;
        public short wVarFlags;
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public partial struct DESCUNION
        {
            [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
            public System.IntPtr lpvarValue;
            [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
            public int oInst;
        }
    }
    [System.FlagsAttribute]
    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.VARFLAGS instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public enum VARFLAGS : short
    {
        VARFLAG_FBINDABLE = (short)4,
        VARFLAG_FDEFAULTBIND = (short)32,
        VARFLAG_FDEFAULTCOLLELEM = (short)256,
        VARFLAG_FDISPLAYBIND = (short)16,
        VARFLAG_FHIDDEN = (short)64,
        VARFLAG_FIMMEDIATEBIND = (short)4096,
        VARFLAG_FNONBROWSABLE = (short)1024,
        VARFLAG_FREADONLY = (short)1,
        VARFLAG_FREPLACEABLE = (short)2048,
        VARFLAG_FREQUESTEDIT = (short)8,
        VARFLAG_FRESTRICTED = (short)128,
        VARFLAG_FSOURCE = (short)2,
        VARFLAG_FUIDEFAULT = (short)512,
    }
}
namespace System.Runtime.InteropServices.Expando
{
    public partial interface IExpando : System.Reflection.IReflect
    {
        System.Reflection.FieldInfo AddField(string name);
        System.Reflection.MethodInfo AddMethod(string name, System.Delegate method);
        System.Reflection.PropertyInfo AddProperty(string name);
        void RemoveMember(System.Reflection.MemberInfo m);
    }
}
namespace System.Runtime.InteropServices.WindowsRuntime
{
    [System.AttributeUsageAttribute((System.AttributeTargets)(1028), AllowMultiple=false, Inherited=false)]
    public sealed partial class DefaultInterfaceAttribute : System.Attribute
    {
        public DefaultInterfaceAttribute(System.Type defaultInterface) { }
        public System.Type DefaultInterface { get { throw null; } }
    }
    public partial class DesignerNamespaceResolveEventArgs : System.EventArgs
    {
        public DesignerNamespaceResolveEventArgs(string namespaceName) { }
        public string NamespaceName { get { throw null; } }
        public System.Collections.ObjectModel.Collection<string> ResolvedAssemblyFiles { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct EventRegistrationToken
    {
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken left, System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken right) { throw null; }
        public static bool operator !=(System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken left, System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken right) { throw null; }
    }
    public sealed partial class EventRegistrationTokenTable<T> where T : class
    {
        public EventRegistrationTokenTable() { }
        public T InvocationList { get { throw null; } set { } }
        public System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken AddEventHandler(T handler) { throw null; }
        public static System.Runtime.InteropServices.WindowsRuntime.EventRegistrationTokenTable<T> GetOrCreateEventRegistrationTokenTable(ref System.Runtime.InteropServices.WindowsRuntime.EventRegistrationTokenTable<T> refEventTable) { throw null; }
        public void RemoveEventHandler(T handler) { }
        public void RemoveEventHandler(System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken token) { }
    }
    public partial interface IActivationFactory
    {
        object ActivateInstance();
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1028), Inherited=false, AllowMultiple=true)]
    public sealed partial class InterfaceImplementedInVersionAttribute : System.Attribute
    {
        public InterfaceImplementedInVersionAttribute(System.Type interfaceType, byte majorVersion, byte minorVersion, byte buildVersion, byte revisionVersion) { }
        public byte BuildVersion { get { throw null; } }
        public System.Type InterfaceType { get { throw null; } }
        public byte MajorVersion { get { throw null; } }
        public byte MinorVersion { get { throw null; } }
        public byte RevisionVersion { get { throw null; } }
    }
    public partial class NamespaceResolveEventArgs : System.EventArgs
    {
        public NamespaceResolveEventArgs(string namespaceName, System.Reflection.Assembly requestingAssembly) { }
        public string NamespaceName { get { throw null; } }
        public System.Reflection.Assembly RequestingAssembly { get { throw null; } }
        public System.Collections.ObjectModel.Collection<System.Reflection.Assembly> ResolvedAssemblies { get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(2048), Inherited=false, AllowMultiple=false)]
    public sealed partial class ReadOnlyArrayAttribute : System.Attribute
    {
        public ReadOnlyArrayAttribute() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(12288), AllowMultiple=false, Inherited=false)]
    public sealed partial class ReturnValueNameAttribute : System.Attribute
    {
        public ReturnValueNameAttribute(string name) { }
        public string Name { get { throw null; } }
    }
    public static partial class WindowsRuntimeMarshal
    {
        public static void AddEventHandler<T>(System.Func<T, System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken> addMethod, System.Action<System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken> removeMethod, T handler) { }
        public static void FreeHString(System.IntPtr ptr) { }
        public static System.Runtime.InteropServices.WindowsRuntime.IActivationFactory GetActivationFactory(System.Type type) { throw null; }
        public static string PtrToStringHString(System.IntPtr ptr) { throw null; }
        public static void RemoveAllEventHandlers(System.Action<System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken> removeMethod) { }
        public static void RemoveEventHandler<T>(System.Action<System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken> removeMethod, T handler) { }
        public static System.IntPtr StringToHString(string s) { throw null; }
    }
    public static partial class WindowsRuntimeMetadata
    {
        public static event System.EventHandler<System.Runtime.InteropServices.WindowsRuntime.DesignerNamespaceResolveEventArgs> DesignerNamespaceResolve { add { } remove { } }
        public static event System.EventHandler<System.Runtime.InteropServices.WindowsRuntime.NamespaceResolveEventArgs> ReflectionOnlyNamespaceResolve { add { } remove { } }
        public static System.Collections.Generic.IEnumerable<string> ResolveNamespace(string namespaceName, System.Collections.Generic.IEnumerable<string> packageGraphFilePaths) { throw null; }
        public static System.Collections.Generic.IEnumerable<string> ResolveNamespace(string namespaceName, string windowsSdkFilePath, System.Collections.Generic.IEnumerable<string> packageGraphFilePaths) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(2048), Inherited=false, AllowMultiple=false)]
    public sealed partial class WriteOnlyArrayAttribute : System.Attribute
    {
        public WriteOnlyArrayAttribute() { }
    }
}