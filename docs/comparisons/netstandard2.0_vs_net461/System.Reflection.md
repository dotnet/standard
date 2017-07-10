# System.Reflection

``` diff
 namespace System.Reflection {
-    public abstract class Assembly : ICustomAttributeProvider, ISerializable {
+    public abstract class Assembly : ICustomAttributeProvider, IEvidenceFactory, ISerializable, _Assembly {
+        public virtual Evidence Evidence { get; }
+        public virtual PermissionSet PermissionSet { get; }
+        public static Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore, Evidence securityEvidence);
+        public static Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore, SecurityContextSource securityContextSource);
+        public static Assembly Load(AssemblyName assemblyRef, Evidence assemblySecurity);
+        public static Assembly Load(string assemblyString, Evidence assemblySecurity);
+        public static Assembly LoadFile(string path, Evidence securityEvidence);
+        public static Assembly LoadFrom(string assemblyFile, Evidence securityEvidence);
+        public static Assembly LoadFrom(string assemblyFile, Evidence securityEvidence, byte[] hashValue, AssemblyHashAlgorithm hashAlgorithm);
+        public static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence);
+        Type System.Runtime.InteropServices._Assembly.GetType();
     }
-    public sealed class AssemblyName : ICloneable, IDeserializationCallback, ISerializable {
+    public sealed class AssemblyName : ICloneable, IDeserializationCallback, ISerializable, _AssemblyName {
+        void System.Runtime.InteropServices._AssemblyName.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void System.Runtime.InteropServices._AssemblyName.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void System.Runtime.InteropServices._AssemblyName.GetTypeInfoCount(out uint pcTInfo);
+        void System.Runtime.InteropServices._AssemblyName.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
     }
-    public abstract class ConstructorInfo : MethodBase {
+    public abstract class ConstructorInfo : MethodBase, _ConstructorInfo {
+        void System.Runtime.InteropServices._ConstructorInfo.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        Type System.Runtime.InteropServices._ConstructorInfo.GetType();
+        void System.Runtime.InteropServices._ConstructorInfo.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void System.Runtime.InteropServices._ConstructorInfo.GetTypeInfoCount(out uint pcTInfo);
+        void System.Runtime.InteropServices._ConstructorInfo.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+        object System.Runtime.InteropServices._ConstructorInfo.Invoke_2(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);
+        object System.Runtime.InteropServices._ConstructorInfo.Invoke_3(object obj, object[] parameters);
+        object System.Runtime.InteropServices._ConstructorInfo.Invoke_4(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);
+        object System.Runtime.InteropServices._ConstructorInfo.Invoke_5(object[] parameters);
     }
-    public abstract class EventInfo : MemberInfo {
+    public abstract class EventInfo : MemberInfo, _EventInfo {
+        void System.Runtime.InteropServices._EventInfo.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        Type System.Runtime.InteropServices._EventInfo.GetType();
+        void System.Runtime.InteropServices._EventInfo.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void System.Runtime.InteropServices._EventInfo.GetTypeInfoCount(out uint pcTInfo);
+        void System.Runtime.InteropServices._EventInfo.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
     }
-    public abstract class FieldInfo : MemberInfo {
+    public abstract class FieldInfo : MemberInfo, _FieldInfo {
+        void System.Runtime.InteropServices._FieldInfo.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        Type System.Runtime.InteropServices._FieldInfo.GetType();
+        void System.Runtime.InteropServices._FieldInfo.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void System.Runtime.InteropServices._FieldInfo.GetTypeInfoCount(out uint pcTInfo);
+        void System.Runtime.InteropServices._FieldInfo.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
     }
+    public interface ICustomTypeProvider {
+        Type GetCustomType();
+    }
-    public abstract class MemberInfo : ICustomAttributeProvider {
+    public abstract class MemberInfo : ICustomAttributeProvider, _MemberInfo {
+        void System.Runtime.InteropServices._MemberInfo.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        Type System.Runtime.InteropServices._MemberInfo.GetType();
+        void System.Runtime.InteropServices._MemberInfo.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void System.Runtime.InteropServices._MemberInfo.GetTypeInfoCount(out uint pcTInfo);
+        void System.Runtime.InteropServices._MemberInfo.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
     }
-    public abstract class MethodBase : MemberInfo {
+    public abstract class MethodBase : MemberInfo, _MethodBase {
+        bool System.Runtime.InteropServices._MethodBase.IsAbstract { get; }
+        bool System.Runtime.InteropServices._MethodBase.IsAssembly { get; }
+        bool System.Runtime.InteropServices._MethodBase.IsConstructor { get; }
+        bool System.Runtime.InteropServices._MethodBase.IsFamily { get; }
+        bool System.Runtime.InteropServices._MethodBase.IsFamilyAndAssembly { get; }
+        bool System.Runtime.InteropServices._MethodBase.IsFamilyOrAssembly { get; }
+        bool System.Runtime.InteropServices._MethodBase.IsFinal { get; }
+        bool System.Runtime.InteropServices._MethodBase.IsHideBySig { get; }
+        bool System.Runtime.InteropServices._MethodBase.IsPrivate { get; }
+        bool System.Runtime.InteropServices._MethodBase.IsPublic { get; }
+        bool System.Runtime.InteropServices._MethodBase.IsSpecialName { get; }
+        bool System.Runtime.InteropServices._MethodBase.IsStatic { get; }
+        bool System.Runtime.InteropServices._MethodBase.IsVirtual { get; }
+        void System.Runtime.InteropServices._MethodBase.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        Type System.Runtime.InteropServices._MethodBase.GetType();
+        void System.Runtime.InteropServices._MethodBase.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void System.Runtime.InteropServices._MethodBase.GetTypeInfoCount(out uint pcTInfo);
+        void System.Runtime.InteropServices._MethodBase.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
     }
-    public abstract class MethodInfo : MethodBase {
+    public abstract class MethodInfo : MethodBase, _MethodInfo {
+        void System.Runtime.InteropServices._MethodInfo.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        Type System.Runtime.InteropServices._MethodInfo.GetType();
+        void System.Runtime.InteropServices._MethodInfo.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void System.Runtime.InteropServices._MethodInfo.GetTypeInfoCount(out uint pcTInfo);
+        void System.Runtime.InteropServices._MethodInfo.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
     }
-    public abstract class Module : ICustomAttributeProvider, ISerializable {
+    public abstract class Module : ICustomAttributeProvider, ISerializable, _Module {
+        public virtual X509Certificate GetSignerCertificate();
+        void System.Runtime.InteropServices._Module.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void System.Runtime.InteropServices._Module.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void System.Runtime.InteropServices._Module.GetTypeInfoCount(out uint pcTInfo);
+        void System.Runtime.InteropServices._Module.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
     }
-    public class ParameterInfo : ICustomAttributeProvider, IObjectReference {
+    public class ParameterInfo : ICustomAttributeProvider, IObjectReference, _ParameterInfo {
+        void System.Runtime.InteropServices._ParameterInfo.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void System.Runtime.InteropServices._ParameterInfo.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void System.Runtime.InteropServices._ParameterInfo.GetTypeInfoCount(out uint pcTInfo);
+        void System.Runtime.InteropServices._ParameterInfo.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
     }
-    public abstract class PropertyInfo : MemberInfo {
+    public abstract class PropertyInfo : MemberInfo, _PropertyInfo {
+        void System.Runtime.InteropServices._PropertyInfo.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        Type System.Runtime.InteropServices._PropertyInfo.GetType();
+        void System.Runtime.InteropServices._PropertyInfo.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void System.Runtime.InteropServices._PropertyInfo.GetTypeInfoCount(out uint pcTInfo);
+        void System.Runtime.InteropServices._PropertyInfo.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
     }
 }
```

