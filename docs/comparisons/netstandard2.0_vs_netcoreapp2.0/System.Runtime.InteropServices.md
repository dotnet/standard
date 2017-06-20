# System.Runtime.InteropServices

``` diff
 namespace System.Runtime.InteropServices {
+    public sealed class AutomationProxyAttribute : Attribute {
+        public AutomationProxyAttribute(bool val);
+        public bool Value { get; }
+    }
+    public sealed class ImportedFromTypeLibAttribute : Attribute {
+        public ImportedFromTypeLibAttribute(string tlbFile);
+        public string Value { get; }
+    }
+    public sealed class ManagedToNativeComInteropStubAttribute : Attribute {
+        public ManagedToNativeComInteropStubAttribute(Type classType, string methodName);
+        public Type ClassType { get; }
+        public string MethodName { get; }
+    }
     public static class Marshal {
+        public static Guid GenerateGuidForType(Type type);
+        public static string GenerateProgIdForType(Type type);
+        public static object GetComObjectData(object obj, object key);
+        public static IntPtr GetHINSTANCE(Module m);
+        public static IntPtr GetIDispatchForObject(object o);
+        public static object GetTypedObjectForIUnknown(IntPtr pUnk, Type t);
+        public static string PtrToStringUTF8(IntPtr ptr);
+        public static string PtrToStringUTF8(IntPtr ptr, int byteLen);
+        public static bool SetComObjectData(object obj, object key, object data);
+        public static IntPtr StringToCoTaskMemUTF8(string s);
+        public static void ZeroFreeCoTaskMemUTF8(IntPtr s);
     }
+    public sealed class TypeLibFuncAttribute : Attribute {
+        public TypeLibFuncAttribute(short flags);
+        public TypeLibFuncAttribute(TypeLibFuncFlags flags);
+        public TypeLibFuncFlags Value { get; }
+    }
+    public enum TypeLibFuncFlags {
+        FBindable = 4,
+        FDefaultBind = 32,
+        FDefaultCollelem = 256,
+        FDisplayBind = 16,
+        FHidden = 64,
+        FImmediateBind = 4096,
+        FNonBrowsable = 1024,
+        FReplaceable = 2048,
+        FRequestEdit = 8,
+        FRestricted = 1,
+        FSource = 2,
+        FUiDefault = 512,
+        FUsesGetLastError = 128,
+    }
+    public sealed class TypeLibImportClassAttribute : Attribute {
+        public TypeLibImportClassAttribute(Type importClass);
+        public string Value { get; }
+    }
+    public sealed class TypeLibTypeAttribute : Attribute {
+        public TypeLibTypeAttribute(short flags);
+        public TypeLibTypeAttribute(TypeLibTypeFlags flags);
+        public TypeLibTypeFlags Value { get; }
+    }
+    public enum TypeLibTypeFlags {
+        FAggregatable = 1024,
+        FAppObject = 1,
+        FCanCreate = 2,
+        FControl = 32,
+        FDispatchable = 4096,
+        FDual = 64,
+        FHidden = 16,
+        FLicensed = 4,
+        FNonExtensible = 128,
+        FOleAutomation = 256,
+        FPreDeclId = 8,
+        FReplaceable = 2048,
+        FRestricted = 512,
+        FReverseBind = 8192,
+    }
+    public sealed class TypeLibVarAttribute : Attribute {
+        public TypeLibVarAttribute(short flags);
+        public TypeLibVarAttribute(TypeLibVarFlags flags);
+        public TypeLibVarFlags Value { get; }
+    }
+    public enum TypeLibVarFlags {
+        FBindable = 4,
+        FDefaultBind = 32,
+        FDefaultCollelem = 256,
+        FDisplayBind = 16,
+        FHidden = 64,
+        FImmediateBind = 4096,
+        FNonBrowsable = 1024,
+        FReadOnly = 1,
+        FReplaceable = 2048,
+        FRequestEdit = 8,
+        FRestricted = 128,
+        FSource = 2,
+        FUiDefault = 512,
+    }
+    public sealed class TypeLibVersionAttribute : Attribute {
+        public TypeLibVersionAttribute(int major, int minor);
+        public int MajorVersion { get; }
+        public int MinorVersion { get; }
+    }
     public enum UnmanagedType {
+        LPUTF8Str = 48,
     }
 }
```

