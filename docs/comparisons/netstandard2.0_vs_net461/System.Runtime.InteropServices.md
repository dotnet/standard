# System.Runtime.InteropServices

``` diff
 namespace System.Runtime.InteropServices {
+    public interface _Activator {
+        void GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void GetTypeInfoCount(out uint pcTInfo);
+        void Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+    }
+    public interface _Assembly {
+        string CodeBase { get; }
+        MethodInfo EntryPoint { get; }
+        string EscapedCodeBase { get; }
+        Evidence Evidence { get; }
+        string FullName { get; }
+        bool GlobalAssemblyCache { get; }
+        string Location { get; }
+        event ModuleResolveEventHandler ModuleResolve;
+        object CreateInstance(string typeName);
+        object CreateInstance(string typeName, bool ignoreCase);
+        object CreateInstance(string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes);
+        bool Equals(object other);
+        object[] GetCustomAttributes(bool inherit);
+        object[] GetCustomAttributes(Type attributeType, bool inherit);
+        Type[] GetExportedTypes();
+        FileStream GetFile(string name);
+        FileStream[] GetFiles();
+        FileStream[] GetFiles(bool getResourceModules);
+        int GetHashCode();
+        Module[] GetLoadedModules();
+        Module[] GetLoadedModules(bool getResourceModules);
+        ManifestResourceInfo GetManifestResourceInfo(string resourceName);
+        string[] GetManifestResourceNames();
+        Stream GetManifestResourceStream(string name);
+        Stream GetManifestResourceStream(Type type, string name);
+        Module GetModule(string name);
+        Module[] GetModules();
+        Module[] GetModules(bool getResourceModules);
+        AssemblyName GetName();
+        AssemblyName GetName(bool copiedName);
+        void GetObjectData(SerializationInfo info, StreamingContext context);
+        AssemblyName[] GetReferencedAssemblies();
+        Assembly GetSatelliteAssembly(CultureInfo culture);
+        Assembly GetSatelliteAssembly(CultureInfo culture, Version version);
+        Type GetType();
+        Type GetType(string name);
+        Type GetType(string name, bool throwOnError);
+        Type GetType(string name, bool throwOnError, bool ignoreCase);
+        Type[] GetTypes();
+        bool IsDefined(Type attributeType, bool inherit);
+        Module LoadModule(string moduleName, byte[] rawModule);
+        Module LoadModule(string moduleName, byte[] rawModule, byte[] rawSymbolStore);
+        string ToString();
+    }
+    public interface _AssemblyBuilder {
+        void GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void GetTypeInfoCount(out uint pcTInfo);
+        void Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+    }
+    public interface _AssemblyName {
+        void GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void GetTypeInfoCount(out uint pcTInfo);
+        void Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+    }
+    public interface _Attribute {
+        void GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void GetTypeInfoCount(out uint pcTInfo);
+        void Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+    }
+    public interface _ConstructorBuilder {
+        void GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void GetTypeInfoCount(out uint pcTInfo);
+        void Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+    }
+    public interface _ConstructorInfo {
+        MethodAttributes Attributes { get; }
+        CallingConventions CallingConvention { get; }
+        Type DeclaringType { get; }
+        bool IsAbstract { get; }
+        bool IsAssembly { get; }
+        bool IsConstructor { get; }
+        bool IsFamily { get; }
+        bool IsFamilyAndAssembly { get; }
+        bool IsFamilyOrAssembly { get; }
+        bool IsFinal { get; }
+        bool IsHideBySig { get; }
+        bool IsPrivate { get; }
+        bool IsPublic { get; }
+        bool IsSpecialName { get; }
+        bool IsStatic { get; }
+        bool IsVirtual { get; }
+        MemberTypes MemberType { get; }
+        RuntimeMethodHandle MethodHandle { get; }
+        string Name { get; }
+        Type ReflectedType { get; }
+        bool Equals(object other);
+        object[] GetCustomAttributes(bool inherit);
+        object[] GetCustomAttributes(Type attributeType, bool inherit);
+        int GetHashCode();
+        void GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        MethodImplAttributes GetMethodImplementationFlags();
+        ParameterInfo[] GetParameters();
+        Type GetType();
+        void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void GetTypeInfoCount(out uint pcTInfo);
+        void Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+        object Invoke_2(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);
+        object Invoke_3(object obj, object[] parameters);
+        object Invoke_4(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);
+        object Invoke_5(object[] parameters);
+        bool IsDefined(Type attributeType, bool inherit);
+        string ToString();
+    }
+    public interface _CustomAttributeBuilder {
+        void GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void GetTypeInfoCount(out uint pcTInfo);
+        void Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+    }
+    public interface _EnumBuilder {
+        void GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void GetTypeInfoCount(out uint pcTInfo);
+        void Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+    }
+    public interface _EventBuilder {
+        void GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void GetTypeInfoCount(out uint pcTInfo);
+        void Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+    }
+    public interface _EventInfo {
+        EventAttributes Attributes { get; }
+        Type DeclaringType { get; }
+        Type EventHandlerType { get; }
+        bool IsMulticast { get; }
+        bool IsSpecialName { get; }
+        MemberTypes MemberType { get; }
+        string Name { get; }
+        Type ReflectedType { get; }
+        void AddEventHandler(object target, Delegate handler);
+        bool Equals(object other);
+        MethodInfo GetAddMethod();
+        MethodInfo GetAddMethod(bool nonPublic);
+        object[] GetCustomAttributes(bool inherit);
+        object[] GetCustomAttributes(Type attributeType, bool inherit);
+        int GetHashCode();
+        void GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        MethodInfo GetRaiseMethod();
+        MethodInfo GetRaiseMethod(bool nonPublic);
+        MethodInfo GetRemoveMethod();
+        MethodInfo GetRemoveMethod(bool nonPublic);
+        Type GetType();
+        void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void GetTypeInfoCount(out uint pcTInfo);
+        void Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+        bool IsDefined(Type attributeType, bool inherit);
+        void RemoveEventHandler(object target, Delegate handler);
+        string ToString();
+    }
+    public interface _Exception {
+        string HelpLink { get; set; }
+        Exception InnerException { get; }
+        string Message { get; }
+        string Source { get; set; }
+        string StackTrace { get; }
+        MethodBase TargetSite { get; }
+        bool Equals(object obj);
+        Exception GetBaseException();
+        int GetHashCode();
+        void GetObjectData(SerializationInfo info, StreamingContext context);
+        Type GetType();
+        string ToString();
+    }
+    public interface _FieldBuilder {
+        void GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void GetTypeInfoCount(out uint pcTInfo);
+        void Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+    }
+    public interface _FieldInfo {
+        FieldAttributes Attributes { get; }
+        Type DeclaringType { get; }
+        RuntimeFieldHandle FieldHandle { get; }
+        Type FieldType { get; }
+        bool IsAssembly { get; }
+        bool IsFamily { get; }
+        bool IsFamilyAndAssembly { get; }
+        bool IsFamilyOrAssembly { get; }
+        bool IsInitOnly { get; }
+        bool IsLiteral { get; }
+        bool IsNotSerialized { get; }
+        bool IsPinvokeImpl { get; }
+        bool IsPrivate { get; }
+        bool IsPublic { get; }
+        bool IsSpecialName { get; }
+        bool IsStatic { get; }
+        MemberTypes MemberType { get; }
+        string Name { get; }
+        Type ReflectedType { get; }
+        bool Equals(object other);
+        object[] GetCustomAttributes(bool inherit);
+        object[] GetCustomAttributes(Type attributeType, bool inherit);
+        int GetHashCode();
+        void GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        Type GetType();
+        void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void GetTypeInfoCount(out uint pcTInfo);
+        object GetValue(object obj);
+        object GetValueDirect(TypedReference obj);
+        void Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+        bool IsDefined(Type attributeType, bool inherit);
+        void SetValue(object obj, object value);
+        void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture);
+        void SetValueDirect(TypedReference obj, object value);
+        string ToString();
+    }
+    public interface _ILGenerator {
+        void GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void GetTypeInfoCount(out uint pcTInfo);
+        void Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+    }
+    public interface _LocalBuilder {
+        void GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void GetTypeInfoCount(out uint pcTInfo);
+        void Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+    }
+    public interface _MemberInfo {
+        Type DeclaringType { get; }
+        MemberTypes MemberType { get; }
+        string Name { get; }
+        Type ReflectedType { get; }
+        bool Equals(object other);
+        object[] GetCustomAttributes(bool inherit);
+        object[] GetCustomAttributes(Type attributeType, bool inherit);
+        int GetHashCode();
+        void GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        Type GetType();
+        void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void GetTypeInfoCount(out uint pcTInfo);
+        void Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+        bool IsDefined(Type attributeType, bool inherit);
+        string ToString();
+    }
+    public interface _MethodBase {
+        MethodAttributes Attributes { get; }
+        CallingConventions CallingConvention { get; }
+        Type DeclaringType { get; }
+        bool IsAbstract { get; }
+        bool IsAssembly { get; }
+        bool IsConstructor { get; }
+        bool IsFamily { get; }
+        bool IsFamilyAndAssembly { get; }
+        bool IsFamilyOrAssembly { get; }
+        bool IsFinal { get; }
+        bool IsHideBySig { get; }
+        bool IsPrivate { get; }
+        bool IsPublic { get; }
+        bool IsSpecialName { get; }
+        bool IsStatic { get; }
+        bool IsVirtual { get; }
+        MemberTypes MemberType { get; }
+        RuntimeMethodHandle MethodHandle { get; }
+        string Name { get; }
+        Type ReflectedType { get; }
+        bool Equals(object other);
+        object[] GetCustomAttributes(bool inherit);
+        object[] GetCustomAttributes(Type attributeType, bool inherit);
+        int GetHashCode();
+        void GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        MethodImplAttributes GetMethodImplementationFlags();
+        ParameterInfo[] GetParameters();
+        Type GetType();
+        void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void GetTypeInfoCount(out uint pcTInfo);
+        object Invoke(object obj, object[] parameters);
+        object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);
+        void Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+        bool IsDefined(Type attributeType, bool inherit);
+        string ToString();
+    }
+    public interface _MethodBuilder {
+        void GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void GetTypeInfoCount(out uint pcTInfo);
+        void Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+    }
+    public interface _MethodInfo {
+        MethodAttributes Attributes { get; }
+        CallingConventions CallingConvention { get; }
+        Type DeclaringType { get; }
+        bool IsAbstract { get; }
+        bool IsAssembly { get; }
+        bool IsConstructor { get; }
+        bool IsFamily { get; }
+        bool IsFamilyAndAssembly { get; }
+        bool IsFamilyOrAssembly { get; }
+        bool IsFinal { get; }
+        bool IsHideBySig { get; }
+        bool IsPrivate { get; }
+        bool IsPublic { get; }
+        bool IsSpecialName { get; }
+        bool IsStatic { get; }
+        bool IsVirtual { get; }
+        MemberTypes MemberType { get; }
+        RuntimeMethodHandle MethodHandle { get; }
+        string Name { get; }
+        Type ReflectedType { get; }
+        Type ReturnType { get; }
+        ICustomAttributeProvider ReturnTypeCustomAttributes { get; }
+        bool Equals(object other);
+        MethodInfo GetBaseDefinition();
+        object[] GetCustomAttributes(bool inherit);
+        object[] GetCustomAttributes(Type attributeType, bool inherit);
+        int GetHashCode();
+        void GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        MethodImplAttributes GetMethodImplementationFlags();
+        ParameterInfo[] GetParameters();
+        Type GetType();
+        void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void GetTypeInfoCount(out uint pcTInfo);
+        object Invoke(object obj, object[] parameters);
+        object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);
+        void Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+        bool IsDefined(Type attributeType, bool inherit);
+        string ToString();
+    }
+    public interface _MethodRental {
+        void GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void GetTypeInfoCount(out uint pcTInfo);
+        void Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+    }
+    public interface _Module {
+        void GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void GetTypeInfoCount(out uint pcTInfo);
+        void Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+    }
+    public interface _ModuleBuilder {
+        void GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void GetTypeInfoCount(out uint pcTInfo);
+        void Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+    }
+    public interface _ParameterBuilder {
+        void GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void GetTypeInfoCount(out uint pcTInfo);
+        void Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+    }
+    public interface _ParameterInfo {
+        void GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void GetTypeInfoCount(out uint pcTInfo);
+        void Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+    }
+    public interface _PropertyBuilder {
+        void GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void GetTypeInfoCount(out uint pcTInfo);
+        void Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+    }
+    public interface _PropertyInfo {
+        PropertyAttributes Attributes { get; }
+        bool CanRead { get; }
+        bool CanWrite { get; }
+        Type DeclaringType { get; }
+        bool IsSpecialName { get; }
+        MemberTypes MemberType { get; }
+        string Name { get; }
+        Type PropertyType { get; }
+        Type ReflectedType { get; }
+        bool Equals(object other);
+        MethodInfo[] GetAccessors();
+        MethodInfo[] GetAccessors(bool nonPublic);
+        object[] GetCustomAttributes(bool inherit);
+        object[] GetCustomAttributes(Type attributeType, bool inherit);
+        MethodInfo GetGetMethod();
+        MethodInfo GetGetMethod(bool nonPublic);
+        int GetHashCode();
+        void GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        ParameterInfo[] GetIndexParameters();
+        MethodInfo GetSetMethod();
+        MethodInfo GetSetMethod(bool nonPublic);
+        Type GetType();
+        void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void GetTypeInfoCount(out uint pcTInfo);
+        object GetValue(object obj, object[] index);
+        object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);
+        void Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+        bool IsDefined(Type attributeType, bool inherit);
+        void SetValue(object obj, object value, object[] index);
+        void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);
+        string ToString();
+    }
+    public interface _SignatureHelper {
+        void GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void GetTypeInfoCount(out uint pcTInfo);
+        void Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+    }
+    public interface _Thread {
+        void GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void GetTypeInfoCount(out uint pcTInfo);
+        void Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+    }
+    public interface _Type {
+        Assembly Assembly { get; }
+        string AssemblyQualifiedName { get; }
+        TypeAttributes Attributes { get; }
+        Type BaseType { get; }
+        Type DeclaringType { get; }
+        string FullName { get; }
+        Guid GUID { get; }
+        bool HasElementType { get; }
+        bool IsAbstract { get; }
+        bool IsAnsiClass { get; }
+        bool IsArray { get; }
+        bool IsAutoClass { get; }
+        bool IsAutoLayout { get; }
+        bool IsByRef { get; }
+        bool IsClass { get; }
+        bool IsCOMObject { get; }
+        bool IsContextful { get; }
+        bool IsEnum { get; }
+        bool IsExplicitLayout { get; }
+        bool IsImport { get; }
+        bool IsInterface { get; }
+        bool IsLayoutSequential { get; }
+        bool IsMarshalByRef { get; }
+        bool IsNestedAssembly { get; }
+        bool IsNestedFamANDAssem { get; }
+        bool IsNestedFamily { get; }
+        bool IsNestedFamORAssem { get; }
+        bool IsNestedPrivate { get; }
+        bool IsNestedPublic { get; }
+        bool IsNotPublic { get; }
+        bool IsPointer { get; }
+        bool IsPrimitive { get; }
+        bool IsPublic { get; }
+        bool IsSealed { get; }
+        bool IsSerializable { get; }
+        bool IsSpecialName { get; }
+        bool IsUnicodeClass { get; }
+        bool IsValueType { get; }
+        MemberTypes MemberType { get; }
+        Module Module { get; }
+        string Name { get; }
+        string Namespace { get; }
+        Type ReflectedType { get; }
+        RuntimeTypeHandle TypeHandle { get; }
+        ConstructorInfo TypeInitializer { get; }
+        Type UnderlyingSystemType { get; }
+        bool Equals(object other);
+        bool Equals(Type o);
+        Type[] FindInterfaces(TypeFilter filter, object filterCriteria);
+        MemberInfo[] FindMembers(MemberTypes memberType, BindingFlags bindingAttr, MemberFilter filter, object filterCriteria);
+        int GetArrayRank();
+        ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);
+        ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers);
+        ConstructorInfo GetConstructor(Type[] types);
+        ConstructorInfo[] GetConstructors();
+        ConstructorInfo[] GetConstructors(BindingFlags bindingAttr);
+        object[] GetCustomAttributes(bool inherit);
+        object[] GetCustomAttributes(Type attributeType, bool inherit);
+        MemberInfo[] GetDefaultMembers();
+        Type GetElementType();
+        EventInfo GetEvent(string name);
+        EventInfo GetEvent(string name, BindingFlags bindingAttr);
+        EventInfo[] GetEvents();
+        EventInfo[] GetEvents(BindingFlags bindingAttr);
+        FieldInfo GetField(string name);
+        FieldInfo GetField(string name, BindingFlags bindingAttr);
+        FieldInfo[] GetFields();
+        FieldInfo[] GetFields(BindingFlags bindingAttr);
+        int GetHashCode();
+        void GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        Type GetInterface(string name);
+        Type GetInterface(string name, bool ignoreCase);
+        InterfaceMapping GetInterfaceMap(Type interfaceType);
+        Type[] GetInterfaces();
+        MemberInfo[] GetMember(string name);
+        MemberInfo[] GetMember(string name, BindingFlags bindingAttr);
+        MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr);
+        MemberInfo[] GetMembers();
+        MemberInfo[] GetMembers(BindingFlags bindingAttr);
+        MethodInfo GetMethod(string name);
+        MethodInfo GetMethod(string name, BindingFlags bindingAttr);
+        MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);
+        MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers);
+        MethodInfo GetMethod(string name, Type[] types);
+        MethodInfo GetMethod(string name, Type[] types, ParameterModifier[] modifiers);
+        MethodInfo[] GetMethods();
+        MethodInfo[] GetMethods(BindingFlags bindingAttr);
+        Type GetNestedType(string name);
+        Type GetNestedType(string name, BindingFlags bindingAttr);
+        Type[] GetNestedTypes();
+        Type[] GetNestedTypes(BindingFlags bindingAttr);
+        PropertyInfo[] GetProperties();
+        PropertyInfo[] GetProperties(BindingFlags bindingAttr);
+        PropertyInfo GetProperty(string name);
+        PropertyInfo GetProperty(string name, BindingFlags bindingAttr);
+        PropertyInfo GetProperty(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers);
+        PropertyInfo GetProperty(string name, Type returnType);
+        PropertyInfo GetProperty(string name, Type returnType, Type[] types);
+        PropertyInfo GetProperty(string name, Type returnType, Type[] types, ParameterModifier[] modifiers);
+        PropertyInfo GetProperty(string name, Type[] types);
+        Type GetType();
+        void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void GetTypeInfoCount(out uint pcTInfo);
+        void Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+        object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args);
+        object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, CultureInfo culture);
+        object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters);
+        bool IsAssignableFrom(Type c);
+        bool IsDefined(Type attributeType, bool inherit);
+        bool IsInstanceOfType(object o);
+        bool IsSubclassOf(Type c);
+        string ToString();
+    }
+    public interface _TypeBuilder {
+        void GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void GetTypeInfoCount(out uint pcTInfo);
+        void Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+    }
-    public enum Architecture {
 {
-        Arm = 2,

-        Arm64 = 3,

-        X64 = 1,

-        X86 = 0,

-    }
+    public enum AssemblyRegistrationFlags {
+        None = 0,
+        SetCodeBase = 1,
+    }
+    public sealed class AutomationProxyAttribute : Attribute {
+        public AutomationProxyAttribute(bool val);
+        public bool Value { get; }
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct BIND_OPTS {
+        public int cbStruct;
+        public int dwTickCountDeadline;
+        public int grfFlags;
+        public int grfMode;
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
+    public struct BINDPTR {
+        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
+        public IntPtr lpfuncdesc;
+        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
+        public IntPtr lptcomp;
+        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
+        public IntPtr lpvardesc;
+    }
+    public enum CALLCONV {
+        CC_CDECL = 1,
+        CC_MACPASCAL = 3,
+        CC_MAX = 9,
+        CC_MPWCDECL = 7,
+        CC_MPWPASCAL = 8,
+        CC_MSCPASCAL = 2,
+        CC_PASCAL = 2,
+        CC_RESERVED = 5,
+        CC_STDCALL = 4,
+        CC_SYSCALL = 6,
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct CONNECTDATA {
+        public int dwCookie;
+        public object pUnk;
+    }
+    public enum DESCKIND {
+        DESCKIND_FUNCDESC = 1,
+        DESCKIND_IMPLICITAPPOBJ = 4,
+        DESCKIND_MAX = 5,
+        DESCKIND_NONE = 0,
+        DESCKIND_TYPECOMP = 3,
+        DESCKIND_VARDESC = 2,
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct DISPPARAMS {
+        public int cArgs;
+        public int cNamedArgs;
+        public IntPtr rgdispidNamedArgs;
+        public IntPtr rgvarg;
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct ELEMDESC {
+        public ELEMDESC.DESCUNION desc;
+        public TYPEDESC tdesc;
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
+        public struct DESCUNION {
+            [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
+            public IDLDESC idldesc;
+            [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
+            public PARAMDESC paramdesc;
+        }
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct EXCEPINFO {
+        public short wCode;
+        public short wReserved;
+        public int dwHelpContext;
+        public IntPtr pfnDeferredFillIn;
+        public IntPtr pvReserved;
+        public string bstrDescription;
+        public string bstrHelpFile;
+        public string bstrSource;
+    }
+    public enum ExporterEventKind {
+        ERROR_REFTOINVALIDASSEMBLY = 2,
+        NOTIF_CONVERTWARNING = 1,
+        NOTIF_TYPECONVERTED = 0,
+    }
+    public sealed class ExtensibleClassFactory {
+        public static void RegisterObjectCreationCallback(ObjectCreationDelegate callback);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct FILETIME {
+        public int dwHighDateTime;
+        public int dwLowDateTime;
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct FUNCDESC {
+        public short cParams;
+        public short cParamsOpt;
+        public short cScodes;
+        public short oVft;
+        public short wFuncFlags;
+        public int memid;
+        public IntPtr lprgelemdescParam;
+        public IntPtr lprgscode;
+        public CALLCONV callconv;
+        public ELEMDESC elemdescFunc;
+        public FUNCKIND funckind;
+        public INVOKEKIND invkind;
+    }
+    public enum FUNCFLAGS : short {
+        FUNCFLAG_FBINDABLE = (short)4,
+        FUNCFLAG_FDEFAULTBIND = (short)32,
+        FUNCFLAG_FDEFAULTCOLLELEM = (short)256,
+        FUNCFLAG_FDISPLAYBIND = (short)16,
+        FUNCFLAG_FHIDDEN = (short)64,
+        FUNCFLAG_FIMMEDIATEBIND = (short)4096,
+        FUNCFLAG_FNONBROWSABLE = (short)1024,
+        FUNCFLAG_FREPLACEABLE = (short)2048,
+        FUNCFLAG_FREQUESTEDIT = (short)8,
+        FUNCFLAG_FRESTRICTED = (short)1,
+        FUNCFLAG_FSOURCE = (short)2,
+        FUNCFLAG_FUIDEFAULT = (short)512,
+        FUNCFLAG_FUSESGETLASTERROR = (short)128,
+    }
+    public enum FUNCKIND {
+        FUNC_DISPATCH = 4,
+        FUNC_NONVIRTUAL = 2,
+        FUNC_PUREVIRTUAL = 1,
+        FUNC_STATIC = 3,
+        FUNC_VIRTUAL = 0,
+    }
+    public sealed class IDispatchImplAttribute : Attribute {
+        public IDispatchImplAttribute(short implType);
+        public IDispatchImplAttribute(IDispatchImplType implType);
+        public IDispatchImplType Value { get; }
+    }
+    public enum IDispatchImplType {
+        CompatibleImpl = 2,
+        InternalImpl = 1,
+        SystemDefinedImpl = 0,
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct IDLDESC {
+        public int dwReserved;
+        public IDLFLAG wIDLFlags;
+    }
+    public enum IDLFLAG : short {
+        IDLFLAG_FIN = (short)1,
+        IDLFLAG_FLCID = (short)4,
+        IDLFLAG_FOUT = (short)2,
+        IDLFLAG_FRETVAL = (short)8,
+        IDLFLAG_NONE = (short)0,
+    }
+    public enum IMPLTYPEFLAGS {
+        IMPLTYPEFLAG_FDEFAULT = 1,
+        IMPLTYPEFLAG_FDEFAULTVTABLE = 8,
+        IMPLTYPEFLAG_FRESTRICTED = 4,
+        IMPLTYPEFLAG_FSOURCE = 2,
+    }
+    public sealed class ImportedFromTypeLibAttribute : Attribute {
+        public ImportedFromTypeLibAttribute(string tlbFile);
+        public string Value { get; }
+    }
+    public enum ImporterEventKind {
+        ERROR_REFTOINVALIDTYPELIB = 2,
+        NOTIF_CONVERTWARNING = 1,
+        NOTIF_TYPECONVERTED = 0,
+    }
+    public enum INVOKEKIND {
+        INVOKE_FUNC = 1,
+        INVOKE_PROPERTYGET = 2,
+        INVOKE_PROPERTYPUT = 4,
+        INVOKE_PROPERTYPUTREF = 8,
+    }
+    public interface IRegistrationServices {
+        Guid GetManagedCategoryGuid();
+        string GetProgIdForType(Type type);
+        Type[] GetRegistrableTypesInAssembly(Assembly assembly);
+        bool RegisterAssembly(Assembly assembly, AssemblyRegistrationFlags flags);
+        void RegisterTypeForComClients(Type type, ref Guid g);
+        bool TypeRepresentsComType(Type type);
+        bool TypeRequiresRegistration(Type type);
+        bool UnregisterAssembly(Assembly assembly);
+    }
+    public interface ITypeLibConverter {
+        object ConvertAssemblyToTypeLib(Assembly assembly, string typeLibName, TypeLibExporterFlags flags, ITypeLibExporterNotifySink notifySink);
+        AssemblyBuilder ConvertTypeLibToAssembly(object typeLib, string asmFileName, int flags, ITypeLibImporterNotifySink notifySink, byte[] publicKey, StrongNameKeyPair keyPair, bool unsafeInterfaces);
+        AssemblyBuilder ConvertTypeLibToAssembly(object typeLib, string asmFileName, TypeLibImporterFlags flags, ITypeLibImporterNotifySink notifySink, byte[] publicKey, StrongNameKeyPair keyPair, string asmNamespace, Version asmVersion);
+        bool GetPrimaryInteropAssembly(Guid g, int major, int minor, int lcid, out string asmName, out string asmCodeBase);
+    }
+    public interface ITypeLibExporterNameProvider {
+        string[] GetNames();
+    }
+    public interface ITypeLibExporterNotifySink {
+        void ReportEvent(ExporterEventKind eventKind, int eventCode, string eventMsg);
+        object ResolveRef(Assembly assembly);
+    }
+    public interface ITypeLibImporterNotifySink {
+        void ReportEvent(ImporterEventKind eventKind, int eventCode, string eventMsg);
+        Assembly ResolveRef(object typeLib);
+    }
+    public enum LIBFLAGS : short {
+        LIBFLAG_FCONTROL = (short)2,
+        LIBFLAG_FHASDISKIMAGE = (short)8,
+        LIBFLAG_FHIDDEN = (short)4,
+        LIBFLAG_FRESTRICTED = (short)1,
+    }
+    public sealed class ManagedToNativeComInteropStubAttribute : Attribute {
+        public ManagedToNativeComInteropStubAttribute(Type classType, string methodName);
+        public Type ClassType { get; }
+        public string MethodName { get; }
+    }
     public static class Marshal {
+        public static Guid GenerateGuidForType(Type type);
+        public static string GenerateProgIdForType(Type type);
+        public static object GetActiveObject(string progID);
+        public static IntPtr GetComInterfaceForObjectInContext(object o, Type t);
+        public static object GetComObjectData(object obj, object key);
+        public static int GetComSlotForMethodInfo(MemberInfo m);
+        public static int GetEndComSlot(Type t);
+        public static IntPtr GetExceptionPointers();
+        public static IntPtr GetHINSTANCE(Module m);
+        public static IntPtr GetIDispatchForObject(object o);
+        public static IntPtr GetIDispatchForObjectInContext(object o);
+        public static IntPtr GetITypeInfoForType(Type t);
+        public static IntPtr GetIUnknownForObjectInContext(object o);
+        public static IntPtr GetManagedThunkForUnmanagedMethodPtr(IntPtr pfnMethodToWrap, IntPtr pbSignature, int cbSignature);
+        public static MemberInfo GetMethodInfoForComSlot(Type t, int slot, ref ComMemberType memberType);
+        public static Thread GetThreadFromFiberCookie(int cookie);
+        public static object GetTypedObjectForIUnknown(IntPtr pUnk, Type t);
+        public static Type GetTypeForITypeInfo(IntPtr piTypeInfo);
+        public static string GetTypeInfoName(UCOMITypeInfo pTI);
+        public static Guid GetTypeLibGuid(ITypeLib typelib);
+        public static Guid GetTypeLibGuid(UCOMITypeLib pTLB);
+        public static Guid GetTypeLibGuidForAssembly(Assembly asm);
+        public static int GetTypeLibLcid(ITypeLib typelib);
+        public static int GetTypeLibLcid(UCOMITypeLib pTLB);
+        public static string GetTypeLibName(ITypeLib typelib);
+        public static string GetTypeLibName(UCOMITypeLib pTLB);
+        public static void GetTypeLibVersionForAssembly(Assembly inputAssembly, out int majorVersion, out int minorVersion);
+        public static IntPtr GetUnmanagedThunkForManagedMethodPtr(IntPtr pfnMethodToWrap, IntPtr pbSignature, int cbSignature);
+        public static bool IsTypeVisibleFromCom(Type t);
+        public static int NumParamBytes(MethodInfo m);
-        public static byte ReadByte(object ptr, int ofs);
+        public static extern byte ReadByte(object ptr, int ofs);
-        public static short ReadInt16(object ptr, int ofs);
+        public static extern short ReadInt16(object ptr, int ofs);
-        public static int ReadInt32(object ptr, int ofs);
+        public static extern int ReadInt32(object ptr, int ofs);
-        public static long ReadInt64(object ptr, int ofs);
+        public static extern long ReadInt64(object ptr, int ofs);
+        public static void ReleaseThreadCache();
+        public static bool SetComObjectData(object obj, object key, object data);
-        public static void WriteByte(object ptr, int ofs, byte val);
+        public static extern void WriteByte(object ptr, int ofs, byte val);
-        public static void WriteInt16(object ptr, int ofs, short val);
+        public static extern void WriteInt16(object ptr, int ofs, short val);
-        public static void WriteInt32(object ptr, int ofs, int val);
+        public static extern void WriteInt32(object ptr, int ofs, int val);
-        public static void WriteInt64(object ptr, int ofs, long val);
+        public static extern void WriteInt64(object ptr, int ofs, long val);
     }
+    public delegate IntPtr ObjectCreationDelegate(IntPtr aggregator);
-    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
-    public struct OSPlatform : IEquatable<OSPlatform> {
 {
-        public static OSPlatform Linux { get; }

-        public static OSPlatform OSX { get; }

-        public static OSPlatform Windows { get; }

-        public static OSPlatform Create(string osPlatform);

-        public override bool Equals(object obj);

-        public bool Equals(OSPlatform other);

-        public override int GetHashCode();

-        public static bool operator ==(OSPlatform left, OSPlatform right);

-        public static bool operator !=(OSPlatform left, OSPlatform right);

-        public override string ToString();

-    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct PARAMDESC {
+        public IntPtr lpVarValue;
+        public PARAMFLAG wParamFlags;
+    }
+    public enum PARAMFLAG : short {
+        PARAMFLAG_FHASCUSTDATA = (short)64,
+        PARAMFLAG_FHASDEFAULT = (short)32,
+        PARAMFLAG_FIN = (short)1,
+        PARAMFLAG_FLCID = (short)4,
+        PARAMFLAG_FOPT = (short)16,
+        PARAMFLAG_FOUT = (short)2,
+        PARAMFLAG_FRETVAL = (short)8,
+        PARAMFLAG_NONE = (short)0,
+    }
+    public enum RegistrationClassContext {
+        DisableActivateAsActivator = 32768,
+        EnableActivateAsActivator = 65536,
+        EnableCodeDownload = 8192,
+        FromDefaultContext = 131072,
+        InProcessHandler = 2,
+        InProcessHandler16 = 32,
+        InProcessServer = 1,
+        InProcessServer16 = 8,
+        LocalServer = 4,
+        NoCodeDownload = 1024,
+        NoCustomMarshal = 4096,
+        NoFailureLog = 16384,
+        RemoteServer = 16,
+        Reserved1 = 64,
+        Reserved2 = 128,
+        Reserved3 = 256,
+        Reserved4 = 512,
+        Reserved5 = 2048,
+    }
+    public enum RegistrationConnectionType {
+        MultipleUse = 1,
+        MultiSeparate = 2,
+        SingleUse = 0,
+        Surrogate = 8,
+        Suspended = 4,
+    }
+    public class RegistrationServices : IRegistrationServices {
+        public RegistrationServices();
+        public virtual Guid GetManagedCategoryGuid();
+        public virtual string GetProgIdForType(Type type);
+        public virtual Type[] GetRegistrableTypesInAssembly(Assembly assembly);
+        public virtual bool RegisterAssembly(Assembly assembly, AssemblyRegistrationFlags flags);
+        public virtual void RegisterTypeForComClients(Type type, ref Guid g);
+        public virtual int RegisterTypeForComClients(Type type, RegistrationClassContext classContext, RegistrationConnectionType flags);
+        public virtual bool TypeRepresentsComType(Type type);
+        public virtual bool TypeRequiresRegistration(Type type);
+        public virtual bool UnregisterAssembly(Assembly assembly);
+        public virtual void UnregisterTypeForComClients(int cookie);
+    }
-    public static class RuntimeEnvironment {
+    public class RuntimeEnvironment {
+        public RuntimeEnvironment();
     }
-    public static class RuntimeInformation {
 {
-        public static string FrameworkDescription { get; }

-        public static Architecture OSArchitecture { get; }

-        public static string OSDescription { get; }

-        public static Architecture ProcessArchitecture { get; }

-        public static bool IsOSPlatform(OSPlatform osPlatform);

-    }
+    public sealed class SetWin32ContextInIDispatchAttribute : Attribute {
+        public SetWin32ContextInIDispatchAttribute();
+    }
+    public class StandardOleMarshalObject : MarshalByRefObject, UnsafeNativeMethods.IMarshal {
+        protected StandardOleMarshalObject();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct STATSTG {
+        public Guid clsid;
+        public int grfLocksSupported;
+        public int grfMode;
+        public int grfStateBits;
+        public int reserved;
+        public int type;
+        public long cbSize;
+        public FILETIME atime;
+        public FILETIME ctime;
+        public FILETIME mtime;
+        public string pwcsName;
+    }
+    public enum SYSKIND {
+        SYS_MAC = 2,
+        SYS_WIN16 = 0,
+        SYS_WIN32 = 1,
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct TYPEATTR {
+        public Guid guid;
+        public short cbAlignment;
+        public short cbSizeVft;
+        public short cFuncs;
+        public short cImplTypes;
+        public short cVars;
+        public short wMajorVerNum;
+        public short wMinorVerNum;
+        public int cbSizeInstance;
+        public int dwReserved;
+        public int lcid;
+        public const int MEMBER_ID_NIL = -1;
+        public int memidConstructor;
+        public int memidDestructor;
+        public IntPtr lpstrSchema;
+        public IDLDESC idldescType;
+        public TYPEDESC tdescAlias;
+        public TYPEFLAGS wTypeFlags;
+        public TYPEKIND typekind;
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct TYPEDESC {
+        public short vt;
+        public IntPtr lpValue;
+    }
+    public enum TYPEFLAGS : short {
+        TYPEFLAG_FAGGREGATABLE = (short)1024,
+        TYPEFLAG_FAPPOBJECT = (short)1,
+        TYPEFLAG_FCANCREATE = (short)2,
+        TYPEFLAG_FCONTROL = (short)32,
+        TYPEFLAG_FDISPATCHABLE = (short)4096,
+        TYPEFLAG_FDUAL = (short)64,
+        TYPEFLAG_FHIDDEN = (short)16,
+        TYPEFLAG_FLICENSED = (short)4,
+        TYPEFLAG_FNONEXTENSIBLE = (short)128,
+        TYPEFLAG_FOLEAUTOMATION = (short)256,
+        TYPEFLAG_FPREDECLID = (short)8,
+        TYPEFLAG_FPROXY = (short)16384,
+        TYPEFLAG_FREPLACEABLE = (short)2048,
+        TYPEFLAG_FRESTRICTED = (short)512,
+        TYPEFLAG_FREVERSEBIND = (short)8192,
+    }
+    public enum TYPEKIND {
+        TKIND_ALIAS = 6,
+        TKIND_COCLASS = 5,
+        TKIND_DISPATCH = 4,
+        TKIND_ENUM = 0,
+        TKIND_INTERFACE = 3,
+        TKIND_MAX = 8,
+        TKIND_MODULE = 2,
+        TKIND_RECORD = 1,
+        TKIND_UNION = 7,
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct TYPELIBATTR {
+        public Guid guid;
+        public short wMajorVerNum;
+        public short wMinorVerNum;
+        public int lcid;
+        public LIBFLAGS wLibFlags;
+        public SYSKIND syskind;
+    }
+    public sealed class TypeLibConverter : ITypeLibConverter {
+        public TypeLibConverter();
+        public object ConvertAssemblyToTypeLib(Assembly assembly, string strTypeLibName, TypeLibExporterFlags flags, ITypeLibExporterNotifySink notifySink);
+        public AssemblyBuilder ConvertTypeLibToAssembly(object typeLib, string asmFileName, int flags, ITypeLibImporterNotifySink notifySink, byte[] publicKey, StrongNameKeyPair keyPair, bool unsafeInterfaces);
+        public AssemblyBuilder ConvertTypeLibToAssembly(object typeLib, string asmFileName, TypeLibImporterFlags flags, ITypeLibImporterNotifySink notifySink, byte[] publicKey, StrongNameKeyPair keyPair, string asmNamespace, Version asmVersion);
+        public bool GetPrimaryInteropAssembly(Guid g, int major, int minor, int lcid, out string asmName, out string asmCodeBase);
+    }
+    public enum TypeLibExporterFlags {
+        CallerResolvedReferences = 2,
+        ExportAs32Bit = 16,
+        ExportAs64Bit = 32,
+        None = 0,
+        OldNames = 4,
+        OnlyReferenceRegistered = 1,
+    }
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
+    public enum TypeLibImporterFlags {
+        ImportAsAgnostic = 2048,
+        ImportAsArm = 16384,
+        ImportAsItanium = 1024,
+        ImportAsX64 = 512,
+        ImportAsX86 = 256,
+        NoDefineVersionResource = 8192,
+        None = 0,
+        PreventClassMembers = 16,
+        PrimaryInteropAssembly = 1,
+        ReflectionOnlyLoading = 4096,
+        SafeArrayAsSystemArray = 4,
+        SerializableValueClasses = 32,
+        TransformDispRetVals = 8,
+        UnsafeInterfaces = 2,
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
+    public interface UCOMIBindCtx {
+        void EnumObjectParam(out UCOMIEnumString ppenum);
+        void GetBindOptions(ref BIND_OPTS pbindopts);
+        void GetObjectParam(string pszKey, out object ppunk);
+        void GetRunningObjectTable(out UCOMIRunningObjectTable pprot);
+        void RegisterObjectBound(object punk);
+        void RegisterObjectParam(string pszKey, object punk);
+        void ReleaseBoundObjects();
+        void RevokeObjectBound(object punk);
+        void RevokeObjectParam(string pszKey);
+        void SetBindOptions(ref BIND_OPTS pbindopts);
+    }
+    public interface UCOMIConnectionPoint {
+        void Advise(object pUnkSink, out int pdwCookie);
+        void EnumConnections(out UCOMIEnumConnections ppEnum);
+        void GetConnectionInterface(out Guid pIID);
+        void GetConnectionPointContainer(out UCOMIConnectionPointContainer ppCPC);
+        void Unadvise(int dwCookie);
+    }
+    public interface UCOMIConnectionPointContainer {
+        void EnumConnectionPoints(out UCOMIEnumConnectionPoints ppEnum);
+        void FindConnectionPoint(ref Guid riid, out UCOMIConnectionPoint ppCP);
+    }
+    public interface UCOMIEnumConnectionPoints {
+        void Clone(out UCOMIEnumConnectionPoints ppenum);
+        int Next(int celt, UCOMIConnectionPoint[] rgelt, out int pceltFetched);
+        int Reset();
+        int Skip(int celt);
+    }
+    public interface UCOMIEnumConnections {
+        void Clone(out UCOMIEnumConnections ppenum);
+        int Next(int celt, CONNECTDATA[] rgelt, out int pceltFetched);
+        void Reset();
+        int Skip(int celt);
+    }
+    public interface UCOMIEnumMoniker {
+        void Clone(out UCOMIEnumMoniker ppenum);
+        int Next(int celt, UCOMIMoniker[] rgelt, out int pceltFetched);
+        int Reset();
+        int Skip(int celt);
+    }
+    public interface UCOMIEnumString {
+        void Clone(out UCOMIEnumString ppenum);
+        int Next(int celt, string[] rgelt, out int pceltFetched);
+        int Reset();
+        int Skip(int celt);
+    }
+    public interface UCOMIEnumVARIANT {
+        void Clone(int ppenum);
+        int Next(int celt, int rgvar, int pceltFetched);
+        int Reset();
+        int Skip(int celt);
+    }
+    public interface UCOMIMoniker {
+        void BindToObject(UCOMIBindCtx pbc, UCOMIMoniker pmkToLeft, ref Guid riidResult, out object ppvResult);
+        void BindToStorage(UCOMIBindCtx pbc, UCOMIMoniker pmkToLeft, ref Guid riid, out object ppvObj);
+        void CommonPrefixWith(UCOMIMoniker pmkOther, out UCOMIMoniker ppmkPrefix);
+        void ComposeWith(UCOMIMoniker pmkRight, bool fOnlyIfNotGeneric, out UCOMIMoniker ppmkComposite);
+        void Enum(bool fForward, out UCOMIEnumMoniker ppenumMoniker);
+        void GetClassID(out Guid pClassID);
+        void GetDisplayName(UCOMIBindCtx pbc, UCOMIMoniker pmkToLeft, out string ppszDisplayName);
+        void GetSizeMax(out long pcbSize);
+        void GetTimeOfLastChange(UCOMIBindCtx pbc, UCOMIMoniker pmkToLeft, out FILETIME pFileTime);
+        void Hash(out int pdwHash);
+        void Inverse(out UCOMIMoniker ppmk);
+        int IsDirty();
+        void IsEqual(UCOMIMoniker pmkOtherMoniker);
+        void IsRunning(UCOMIBindCtx pbc, UCOMIMoniker pmkToLeft, UCOMIMoniker pmkNewlyRunning);
+        void IsSystemMoniker(out int pdwMksys);
+        void Load(UCOMIStream pStm);
+        void ParseDisplayName(UCOMIBindCtx pbc, UCOMIMoniker pmkToLeft, string pszDisplayName, out int pchEaten, out UCOMIMoniker ppmkOut);
+        void Reduce(UCOMIBindCtx pbc, int dwReduceHowFar, ref UCOMIMoniker ppmkToLeft, out UCOMIMoniker ppmkReduced);
+        void RelativePathTo(UCOMIMoniker pmkOther, out UCOMIMoniker ppmkRelPath);
+        void Save(UCOMIStream pStm, bool fClearDirty);
+    }
+    public interface UCOMIPersistFile {
+        void GetClassID(out Guid pClassID);
+        void GetCurFile(out string ppszFileName);
+        int IsDirty();
+        void Load(string pszFileName, int dwMode);
+        void Save(string pszFileName, bool fRemember);
+        void SaveCompleted(string pszFileName);
+    }
+    public interface UCOMIRunningObjectTable {
+        void EnumRunning(out UCOMIEnumMoniker ppenumMoniker);
+        void GetObject(UCOMIMoniker pmkObjectName, out object ppunkObject);
+        void GetTimeOfLastChange(UCOMIMoniker pmkObjectName, out FILETIME pfiletime);
+        void IsRunning(UCOMIMoniker pmkObjectName);
+        void NoteChangeTime(int dwRegister, ref FILETIME pfiletime);
+        void Register(int grfFlags, object punkObject, UCOMIMoniker pmkObjectName, out int pdwRegister);
+        void Revoke(int dwRegister);
+    }
+    public interface UCOMIStream {
+        void Clone(out UCOMIStream ppstm);
+        void Commit(int grfCommitFlags);
+        void CopyTo(UCOMIStream pstm, long cb, IntPtr pcbRead, IntPtr pcbWritten);
+        void LockRegion(long libOffset, long cb, int dwLockType);
+        void Read(byte[] pv, int cb, IntPtr pcbRead);
+        void Revert();
+        void Seek(long dlibMove, int dwOrigin, IntPtr plibNewPosition);
+        void SetSize(long libNewSize);
+        void Stat(out STATSTG pstatstg, int grfStatFlag);
+        void UnlockRegion(long libOffset, long cb, int dwLockType);
+        void Write(byte[] pv, int cb, IntPtr pcbWritten);
+    }
+    public interface UCOMITypeComp {
+        void Bind(string szName, int lHashVal, short wFlags, out UCOMITypeInfo ppTInfo, out DESCKIND pDescKind, out BINDPTR pBindPtr);
+        void BindType(string szName, int lHashVal, out UCOMITypeInfo ppTInfo, out UCOMITypeComp ppTComp);
+    }
+    public interface UCOMITypeInfo {
+        void AddressOfMember(int memid, INVOKEKIND invKind, out IntPtr ppv);
+        void CreateInstance(object pUnkOuter, ref Guid riid, out object ppvObj);
+        void GetContainingTypeLib(out UCOMITypeLib ppTLB, out int pIndex);
+        void GetDllEntry(int memid, INVOKEKIND invKind, out string pBstrDllName, out string pBstrName, out short pwOrdinal);
+        void GetDocumentation(int index, out string strName, out string strDocString, out int dwHelpContext, out string strHelpFile);
+        void GetFuncDesc(int index, out IntPtr ppFuncDesc);
+        void GetIDsOfNames(string[] rgszNames, int cNames, int[] pMemId);
+        void GetImplTypeFlags(int index, out int pImplTypeFlags);
+        void GetMops(int memid, out string pBstrMops);
+        void GetNames(int memid, string[] rgBstrNames, int cMaxNames, out int pcNames);
+        void GetRefTypeInfo(int hRef, out UCOMITypeInfo ppTI);
+        void GetRefTypeOfImplType(int index, out int href);
+        void GetTypeAttr(out IntPtr ppTypeAttr);
+        void GetTypeComp(out UCOMITypeComp ppTComp);
+        void GetVarDesc(int index, out IntPtr ppVarDesc);
+        void Invoke(object pvInstance, int memid, short wFlags, ref DISPPARAMS pDispParams, out object pVarResult, out EXCEPINFO pExcepInfo, out int puArgErr);
+        void ReleaseFuncDesc(IntPtr pFuncDesc);
+        void ReleaseTypeAttr(IntPtr pTypeAttr);
+        void ReleaseVarDesc(IntPtr pVarDesc);
+    }
+    public interface UCOMITypeLib {
+        void FindName(string szNameBuf, int lHashVal, UCOMITypeInfo[] ppTInfo, int[] rgMemId, ref short pcFound);
+        void GetDocumentation(int index, out string strName, out string strDocString, out int dwHelpContext, out string strHelpFile);
+        void GetLibAttr(out IntPtr ppTLibAttr);
+        void GetTypeComp(out UCOMITypeComp ppTComp);
+        void GetTypeInfo(int index, out UCOMITypeInfo ppTI);
+        int GetTypeInfoCount();
+        void GetTypeInfoOfGuid(ref Guid guid, out UCOMITypeInfo ppTInfo);
+        void GetTypeInfoType(int index, out TYPEKIND pTKind);
+        bool IsName(string szNameBuf, int lHashVal);
+        void ReleaseTLibAttr(IntPtr pTLibAttr);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct VARDESC {
+        public short wVarFlags;
+        public int memid;
+        public ELEMDESC elemdescVar;
+        public VarEnum varkind;
+        public string lpstrSchema;
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
+        public struct DESCUNION {
+            [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
+            public int oInst;
+            [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
+            public IntPtr lpvarValue;
+        }
+    }
+    public enum VARFLAGS : short {
+        VARFLAG_FBINDABLE = (short)4,
+        VARFLAG_FDEFAULTBIND = (short)32,
+        VARFLAG_FDEFAULTCOLLELEM = (short)256,
+        VARFLAG_FDISPLAYBIND = (short)16,
+        VARFLAG_FHIDDEN = (short)64,
+        VARFLAG_FIMMEDIATEBIND = (short)4096,
+        VARFLAG_FNONBROWSABLE = (short)1024,
+        VARFLAG_FREADONLY = (short)1,
+        VARFLAG_FREPLACEABLE = (short)2048,
+        VARFLAG_FREQUESTEDIT = (short)8,
+        VARFLAG_FRESTRICTED = (short)128,
+        VARFLAG_FSOURCE = (short)2,
+        VARFLAG_FUIDEFAULT = (short)512,
+    }
 }
```

