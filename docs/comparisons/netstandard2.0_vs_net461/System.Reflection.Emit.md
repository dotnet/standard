# System.Reflection.Emit

``` diff
 namespace System.Reflection.Emit {
+    public sealed class AssemblyBuilder : Assembly, _AssemblyBuilder {
+        public override string CodeBase { get; }
+        public override MethodInfo EntryPoint { get; }
+        public override Evidence Evidence { get; }
+        public override string FullName { get; }
+        public override bool GlobalAssemblyCache { get; }
+        public override long HostContext { get; }
+        public override string ImageRuntimeVersion { get; }
+        public override bool IsDynamic { get; }
+        public override string Location { get; }
+        public override Module ManifestModule { get; }
+        public override PermissionSet PermissionSet { get; }
+        public override bool ReflectionOnly { get; }
+        public override SecurityRuleSet SecurityRuleSet { get; }
+        public void AddResourceFile(string name, string fileName);
+        public void AddResourceFile(string name, string fileName, ResourceAttributes attribute);
+        public static AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access);
+        public static AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, IEnumerable<CustomAttributeBuilder> assemblyAttributes);
+        public ModuleBuilder DefineDynamicModule(string name);
+        public ModuleBuilder DefineDynamicModule(string name, bool emitSymbolInfo);
+        public ModuleBuilder DefineDynamicModule(string name, string fileName);
+        public ModuleBuilder DefineDynamicModule(string name, string fileName, bool emitSymbolInfo);
+        public IResourceWriter DefineResource(string name, string description, string fileName);
+        public IResourceWriter DefineResource(string name, string description, string fileName, ResourceAttributes attribute);
+        public void DefineUnmanagedResource(byte[] resource);
+        public void DefineUnmanagedResource(string resourceFileName);
+        public void DefineVersionInfoResource();
+        public void DefineVersionInfoResource(string product, string productVersion, string company, string copyright, string trademark);
+        public override bool Equals(object obj);
+        public override object[] GetCustomAttributes(bool inherit);
+        public override object[] GetCustomAttributes(Type attributeType, bool inherit);
+        public override IList<CustomAttributeData> GetCustomAttributesData();
+        public ModuleBuilder GetDynamicModule(string name);
+        public override Type[] GetExportedTypes();
+        public override FileStream GetFile(string name);
+        public override FileStream[] GetFiles(bool getResourceModules);
+        public override int GetHashCode();
+        public override Module[] GetLoadedModules(bool getResourceModules);
+        public override ManifestResourceInfo GetManifestResourceInfo(string resourceName);
+        public override string[] GetManifestResourceNames();
+        public override Stream GetManifestResourceStream(string name);
+        public override Stream GetManifestResourceStream(Type type, string name);
+        public override Module GetModule(string name);
+        public override Module[] GetModules(bool getResourceModules);
+        public override AssemblyName GetName(bool copiedName);
+        public override AssemblyName[] GetReferencedAssemblies();
+        public override Assembly GetSatelliteAssembly(CultureInfo culture);
+        public override Assembly GetSatelliteAssembly(CultureInfo culture, Version version);
+        public override Type GetType(string name, bool throwOnError, bool ignoreCase);
+        public override bool IsDefined(Type attributeType, bool inherit);
+        public void Save(string assemblyFileName);
+        public void Save(string assemblyFileName, PortableExecutableKinds portableExecutableKind, ImageFileMachine imageFileMachine);
+        public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute);
+        public void SetCustomAttribute(CustomAttributeBuilder customBuilder);
+        public void SetEntryPoint(MethodInfo entryMethod);
+        public void SetEntryPoint(MethodInfo entryMethod, PEFileKinds fileKind);
+        void System.Runtime.InteropServices._AssemblyBuilder.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void System.Runtime.InteropServices._AssemblyBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void System.Runtime.InteropServices._AssemblyBuilder.GetTypeInfoCount(out uint pcTInfo);
+        void System.Runtime.InteropServices._AssemblyBuilder.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+    }
+    public enum AssemblyBuilderAccess {
+        ReflectionOnly = 6,
+        Run = 1,
+        RunAndCollect = 9,
+        RunAndSave = 3,
+        Save = 2,
+    }
+    public sealed class ConstructorBuilder : ConstructorInfo, _ConstructorBuilder {
+        public override MethodAttributes Attributes { get; }
+        public override CallingConventions CallingConvention { get; }
+        public override Type DeclaringType { get; }
+        public bool InitLocals { get; set; }
+        public override RuntimeMethodHandle MethodHandle { get; }
+        public override Module Module { get; }
+        public override string Name { get; }
+        public override Type ReflectedType { get; }
+        public Type ReturnType { get; }
+        public string Signature { get; }
+        public void AddDeclarativeSecurity(SecurityAction action, PermissionSet pset);
+        public ParameterBuilder DefineParameter(int iSequence, ParameterAttributes attributes, string strParamName);
+        public override object[] GetCustomAttributes(bool inherit);
+        public override object[] GetCustomAttributes(Type attributeType, bool inherit);
+        public ILGenerator GetILGenerator();
+        public ILGenerator GetILGenerator(int streamSize);
+        public override MethodImplAttributes GetMethodImplementationFlags();
+        public Module GetModule();
+        public override ParameterInfo[] GetParameters();
+        public MethodToken GetToken();
+        public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);
+        public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);
+        public override bool IsDefined(Type attributeType, bool inherit);
+        public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute);
+        public void SetCustomAttribute(CustomAttributeBuilder customBuilder);
+        public void SetImplementationFlags(MethodImplAttributes attributes);
+        public void SetMethodBody(byte[] il, int maxStack, byte[] localSignature, IEnumerable<ExceptionHandler> exceptionHandlers, IEnumerable<int> tokenFixups);
+        public void SetSymCustomAttribute(string name, byte[] data);
+        void System.Runtime.InteropServices._ConstructorBuilder.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void System.Runtime.InteropServices._ConstructorBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void System.Runtime.InteropServices._ConstructorBuilder.GetTypeInfoCount(out uint pcTInfo);
+        void System.Runtime.InteropServices._ConstructorBuilder.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+        public override string ToString();
+    }
+    public class CustomAttributeBuilder : _CustomAttributeBuilder {
+        public CustomAttributeBuilder(ConstructorInfo con, object[] constructorArgs);
+        public CustomAttributeBuilder(ConstructorInfo con, object[] constructorArgs, FieldInfo[] namedFields, object[] fieldValues);
+        public CustomAttributeBuilder(ConstructorInfo con, object[] constructorArgs, PropertyInfo[] namedProperties, object[] propertyValues);
+        public CustomAttributeBuilder(ConstructorInfo con, object[] constructorArgs, PropertyInfo[] namedProperties, object[] propertyValues, FieldInfo[] namedFields, object[] fieldValues);
+        void System.Runtime.InteropServices._CustomAttributeBuilder.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void System.Runtime.InteropServices._CustomAttributeBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void System.Runtime.InteropServices._CustomAttributeBuilder.GetTypeInfoCount(out uint pcTInfo);
+        void System.Runtime.InteropServices._CustomAttributeBuilder.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+    }
+    public class DynamicILInfo {
+        public DynamicMethod DynamicMethod { get; }
+        public int GetTokenFor(byte[] signature);
+        public int GetTokenFor(DynamicMethod method);
+        public int GetTokenFor(RuntimeFieldHandle field);
+        public int GetTokenFor(RuntimeFieldHandle field, RuntimeTypeHandle contextType);
+        public int GetTokenFor(RuntimeMethodHandle method);
+        public int GetTokenFor(RuntimeMethodHandle method, RuntimeTypeHandle contextType);
+        public int GetTokenFor(RuntimeTypeHandle type);
+        public int GetTokenFor(string literal);
+        public unsafe void SetCode(byte* code, int codeSize, int maxStackSize);
+        public void SetCode(byte[] code, int maxStackSize);
+        public unsafe void SetExceptions(byte* exceptions, int exceptionsSize);
+        public void SetExceptions(byte[] exceptions);
+        public unsafe void SetLocalSignature(byte* localSignature, int signatureSize);
+        public void SetLocalSignature(byte[] localSignature);
+    }
+    public sealed class DynamicMethod : MethodInfo {
+        public DynamicMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, Module m, bool skipVisibility);
+        public DynamicMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, Type owner, bool skipVisibility);
+        public DynamicMethod(string name, Type returnType, Type[] parameterTypes);
+        public DynamicMethod(string name, Type returnType, Type[] parameterTypes, bool restrictedSkipVisibility);
+        public DynamicMethod(string name, Type returnType, Type[] parameterTypes, Module m);
+        public DynamicMethod(string name, Type returnType, Type[] parameterTypes, Module m, bool skipVisibility);
+        public DynamicMethod(string name, Type returnType, Type[] parameterTypes, Type owner);
+        public DynamicMethod(string name, Type returnType, Type[] parameterTypes, Type owner, bool skipVisibility);
+        public override MethodAttributes Attributes { get; }
+        public override CallingConventions CallingConvention { get; }
+        public override Type DeclaringType { get; }
+        public bool InitLocals { get; set; }
+        public override bool IsSecurityCritical { get; }
+        public override bool IsSecuritySafeCritical { get; }
+        public override bool IsSecurityTransparent { get; }
+        public override RuntimeMethodHandle MethodHandle { get; }
+        public override Module Module { get; }
+        public override string Name { get; }
+        public override Type ReflectedType { get; }
+        public override ParameterInfo ReturnParameter { get; }
+        public override Type ReturnType { get; }
+        public override ICustomAttributeProvider ReturnTypeCustomAttributes { get; }
+        public sealed override Delegate CreateDelegate(Type delegateType);
+        public sealed override Delegate CreateDelegate(Type delegateType, object target);
+        public ParameterBuilder DefineParameter(int position, ParameterAttributes attributes, string parameterName);
+        public override MethodInfo GetBaseDefinition();
+        public override object[] GetCustomAttributes(bool inherit);
+        public override object[] GetCustomAttributes(Type attributeType, bool inherit);
+        public DynamicILInfo GetDynamicILInfo();
+        public ILGenerator GetILGenerator();
+        public ILGenerator GetILGenerator(int streamSize);
+        public override MethodImplAttributes GetMethodImplementationFlags();
+        public override ParameterInfo[] GetParameters();
+        public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);
+        public override bool IsDefined(Type attributeType, bool inherit);
+        public override string ToString();
+    }
+    public sealed class EnumBuilder : TypeInfo, _EnumBuilder {
+        public override Assembly Assembly { get; }
+        public override string AssemblyQualifiedName { get; }
+        public override Type BaseType { get; }
+        public override Type DeclaringType { get; }
+        public override string FullName { get; }
+        public override Guid GUID { get; }
+        public override bool IsConstructedGenericType { get; }
+        public override Module Module { get; }
+        public override string Name { get; }
+        public override string Namespace { get; }
+        public override Type ReflectedType { get; }
+        public override RuntimeTypeHandle TypeHandle { get; }
+        public TypeToken TypeToken { get; }
+        public FieldBuilder UnderlyingField { get; }
+        public override Type UnderlyingSystemType { get; }
+        public Type CreateType();
+        public TypeInfo CreateTypeInfo();
+        public FieldBuilder DefineLiteral(string literalName, object literalValue);
+        protected override TypeAttributes GetAttributeFlagsImpl();
+        protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);
+        public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr);
+        public override object[] GetCustomAttributes(bool inherit);
+        public override object[] GetCustomAttributes(Type attributeType, bool inherit);
+        public override Type GetElementType();
+        public override Type GetEnumUnderlyingType();
+        public override EventInfo GetEvent(string name, BindingFlags bindingAttr);
+        public override EventInfo[] GetEvents();
+        public override EventInfo[] GetEvents(BindingFlags bindingAttr);
+        public override FieldInfo GetField(string name, BindingFlags bindingAttr);
+        public override FieldInfo[] GetFields(BindingFlags bindingAttr);
+        public override Type GetInterface(string name, bool ignoreCase);
+        public override InterfaceMapping GetInterfaceMap(Type interfaceType);
+        public override Type[] GetInterfaces();
+        public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr);
+        public override MemberInfo[] GetMembers(BindingFlags bindingAttr);
+        protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);
+        public override MethodInfo[] GetMethods(BindingFlags bindingAttr);
+        public override Type GetNestedType(string name, BindingFlags bindingAttr);
+        public override Type[] GetNestedTypes(BindingFlags bindingAttr);
+        public override PropertyInfo[] GetProperties(BindingFlags bindingAttr);
+        protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers);
+        protected override bool HasElementTypeImpl();
+        public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters);
+        protected override bool IsArrayImpl();
+        public override bool IsAssignableFrom(TypeInfo typeInfo);
+        protected override bool IsByRefImpl();
+        protected override bool IsCOMObjectImpl();
+        public override bool IsDefined(Type attributeType, bool inherit);
+        protected override bool IsPointerImpl();
+        protected override bool IsPrimitiveImpl();
+        protected override bool IsValueTypeImpl();
+        public override Type MakeArrayType();
+        public override Type MakeArrayType(int rank);
+        public override Type MakeByRefType();
+        public override Type MakePointerType();
+        public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute);
+        public void SetCustomAttribute(CustomAttributeBuilder customBuilder);
+        void System.Runtime.InteropServices._EnumBuilder.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void System.Runtime.InteropServices._EnumBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void System.Runtime.InteropServices._EnumBuilder.GetTypeInfoCount(out uint pcTInfo);
+        void System.Runtime.InteropServices._EnumBuilder.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+    }
+    public sealed class EventBuilder : _EventBuilder {
+        public void AddOtherMethod(MethodBuilder mdBuilder);
+        public EventToken GetEventToken();
+        public void SetAddOnMethod(MethodBuilder mdBuilder);
+        public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute);
+        public void SetCustomAttribute(CustomAttributeBuilder customBuilder);
+        public void SetRaiseMethod(MethodBuilder mdBuilder);
+        public void SetRemoveOnMethod(MethodBuilder mdBuilder);
+        void System.Runtime.InteropServices._EventBuilder.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void System.Runtime.InteropServices._EventBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void System.Runtime.InteropServices._EventBuilder.GetTypeInfoCount(out uint pcTInfo);
+        void System.Runtime.InteropServices._EventBuilder.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct EventToken {
+        public static readonly EventToken Empty;
+        public int Token { get; }
+        public override bool Equals(object obj);
+        public bool Equals(EventToken obj);
+        public override int GetHashCode();
+        public static bool operator ==(EventToken a, EventToken b);
+        public static bool operator !=(EventToken a, EventToken b);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct ExceptionHandler : IEquatable<ExceptionHandler> {
+        public ExceptionHandler(int tryOffset, int tryLength, int filterOffset, int handlerOffset, int handlerLength, ExceptionHandlingClauseOptions kind, int exceptionTypeToken);
+        public int ExceptionTypeToken { get; }
+        public int FilterOffset { get; }
+        public int HandlerLength { get; }
+        public int HandlerOffset { get; }
+        public ExceptionHandlingClauseOptions Kind { get; }
+        public int TryLength { get; }
+        public int TryOffset { get; }
+        public override bool Equals(object obj);
+        public bool Equals(ExceptionHandler other);
+        public override int GetHashCode();
+        public static bool operator ==(ExceptionHandler left, ExceptionHandler right);
+        public static bool operator !=(ExceptionHandler left, ExceptionHandler right);
+    }
+    public sealed class FieldBuilder : FieldInfo, _FieldBuilder {
+        public override FieldAttributes Attributes { get; }
+        public override Type DeclaringType { get; }
+        public override RuntimeFieldHandle FieldHandle { get; }
+        public override Type FieldType { get; }
+        public override Module Module { get; }
+        public override string Name { get; }
+        public override Type ReflectedType { get; }
+        public override object[] GetCustomAttributes(bool inherit);
+        public override object[] GetCustomAttributes(Type attributeType, bool inherit);
+        public FieldToken GetToken();
+        public override object GetValue(object obj);
+        public override bool IsDefined(Type attributeType, bool inherit);
+        public void SetConstant(object defaultValue);
+        public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute);
+        public void SetCustomAttribute(CustomAttributeBuilder customBuilder);
+        public void SetMarshal(UnmanagedMarshal unmanagedMarshal);
+        public void SetOffset(int iOffset);
+        public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture);
+        void System.Runtime.InteropServices._FieldBuilder.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void System.Runtime.InteropServices._FieldBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void System.Runtime.InteropServices._FieldBuilder.GetTypeInfoCount(out uint pcTInfo);
+        void System.Runtime.InteropServices._FieldBuilder.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct FieldToken {
+        public static readonly FieldToken Empty;
+        public int Token { get; }
+        public override bool Equals(object obj);
+        public bool Equals(FieldToken obj);
+        public override int GetHashCode();
+        public static bool operator ==(FieldToken a, FieldToken b);
+        public static bool operator !=(FieldToken a, FieldToken b);
+    }
+    public sealed class GenericTypeParameterBuilder : TypeInfo {
+        public override Assembly Assembly { get; }
+        public override string AssemblyQualifiedName { get; }
+        public override Type BaseType { get; }
+        public override bool ContainsGenericParameters { get; }
+        public override MethodBase DeclaringMethod { get; }
+        public override Type DeclaringType { get; }
+        public override string FullName { get; }
+        public override GenericParameterAttributes GenericParameterAttributes { get; }
+        public override int GenericParameterPosition { get; }
+        public override Guid GUID { get; }
+        public override bool IsConstructedGenericType { get; }
+        public override bool IsGenericParameter { get; }
+        public override bool IsGenericType { get; }
+        public override bool IsGenericTypeDefinition { get; }
+        public override Module Module { get; }
+        public override string Name { get; }
+        public override string Namespace { get; }
+        public override Type ReflectedType { get; }
+        public override RuntimeTypeHandle TypeHandle { get; }
+        public override Type UnderlyingSystemType { get; }
+        public override bool Equals(object o);
+        protected override TypeAttributes GetAttributeFlagsImpl();
+        protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);
+        public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr);
+        public override object[] GetCustomAttributes(bool inherit);
+        public override object[] GetCustomAttributes(Type attributeType, bool inherit);
+        public override Type GetElementType();
+        public override EventInfo GetEvent(string name, BindingFlags bindingAttr);
+        public override EventInfo[] GetEvents();
+        public override EventInfo[] GetEvents(BindingFlags bindingAttr);
+        public override FieldInfo GetField(string name, BindingFlags bindingAttr);
+        public override FieldInfo[] GetFields(BindingFlags bindingAttr);
+        public override Type[] GetGenericArguments();
+        public override Type GetGenericTypeDefinition();
+        public override int GetHashCode();
+        public override Type GetInterface(string name, bool ignoreCase);
+        public override InterfaceMapping GetInterfaceMap(Type interfaceType);
+        public override Type[] GetInterfaces();
+        public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr);
+        public override MemberInfo[] GetMembers(BindingFlags bindingAttr);
+        protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);
+        public override MethodInfo[] GetMethods(BindingFlags bindingAttr);
+        public override Type GetNestedType(string name, BindingFlags bindingAttr);
+        public override Type[] GetNestedTypes(BindingFlags bindingAttr);
+        public override PropertyInfo[] GetProperties(BindingFlags bindingAttr);
+        protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers);
+        protected override bool HasElementTypeImpl();
+        public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters);
+        protected override bool IsArrayImpl();
+        public override bool IsAssignableFrom(TypeInfo typeInfo);
+        public override bool IsAssignableFrom(Type c);
+        protected override bool IsByRefImpl();
+        protected override bool IsCOMObjectImpl();
+        public override bool IsDefined(Type attributeType, bool inherit);
+        protected override bool IsPointerImpl();
+        protected override bool IsPrimitiveImpl();
+        public override bool IsSubclassOf(Type c);
+        protected override bool IsValueTypeImpl();
+        public override Type MakeArrayType();
+        public override Type MakeArrayType(int rank);
+        public override Type MakeByRefType();
+        public override Type MakeGenericType(params Type[] typeArguments);
+        public override Type MakePointerType();
+        public void SetBaseTypeConstraint(Type baseTypeConstraint);
+        public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute);
+        public void SetCustomAttribute(CustomAttributeBuilder customBuilder);
+        public void SetGenericParameterAttributes(GenericParameterAttributes genericParameterAttributes);
+        public void SetInterfaceConstraints(params Type[] interfaceConstraints);
+        public override string ToString();
+    }
+    public class ILGenerator : _ILGenerator {
+        public virtual int ILOffset { get; }
+        public virtual void BeginCatchBlock(Type exceptionType);
+        public virtual void BeginExceptFilterBlock();
+        public virtual Label BeginExceptionBlock();
+        public virtual void BeginFaultBlock();
+        public virtual void BeginFinallyBlock();
+        public virtual void BeginScope();
+        public virtual LocalBuilder DeclareLocal(Type localType);
+        public virtual LocalBuilder DeclareLocal(Type localType, bool pinned);
+        public virtual Label DefineLabel();
+        public virtual void Emit(OpCode opcode);
+        public virtual void Emit(OpCode opcode, byte arg);
+        public virtual void Emit(OpCode opcode, double arg);
+        public virtual void Emit(OpCode opcode, short arg);
+        public virtual void Emit(OpCode opcode, int arg);
+        public virtual void Emit(OpCode opcode, long arg);
+        public virtual void Emit(OpCode opcode, ConstructorInfo con);
+        public virtual void Emit(OpCode opcode, Label label);
+        public virtual void Emit(OpCode opcode, Label[] labels);
+        public virtual void Emit(OpCode opcode, LocalBuilder local);
+        public virtual void Emit(OpCode opcode, SignatureHelper signature);
+        public virtual void Emit(OpCode opcode, FieldInfo field);
+        public virtual void Emit(OpCode opcode, MethodInfo meth);
+        public void Emit(OpCode opcode, sbyte arg);
+        public virtual void Emit(OpCode opcode, float arg);
+        public virtual void Emit(OpCode opcode, string str);
+        public virtual void Emit(OpCode opcode, Type cls);
+        public virtual void EmitCall(OpCode opcode, MethodInfo methodInfo, Type[] optionalParameterTypes);
+        public virtual void EmitCalli(OpCode opcode, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, Type[] optionalParameterTypes);
+        public virtual void EmitCalli(OpCode opcode, CallingConvention unmanagedCallConv, Type returnType, Type[] parameterTypes);
+        public virtual void EmitWriteLine(LocalBuilder localBuilder);
+        public virtual void EmitWriteLine(FieldInfo fld);
+        public virtual void EmitWriteLine(string value);
+        public virtual void EndExceptionBlock();
+        public virtual void EndScope();
+        public virtual void MarkLabel(Label loc);
+        public virtual void MarkSequencePoint(ISymbolDocumentWriter document, int startLine, int startColumn, int endLine, int endColumn);
+        void System.Runtime.InteropServices._ILGenerator.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void System.Runtime.InteropServices._ILGenerator.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void System.Runtime.InteropServices._ILGenerator.GetTypeInfoCount(out uint pcTInfo);
+        void System.Runtime.InteropServices._ILGenerator.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+        public virtual void ThrowException(Type excType);
+        public virtual void UsingNamespace(string usingNamespace);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct Label {
+        public override bool Equals(object obj);
+        public bool Equals(Label obj);
+        public override int GetHashCode();
+        public static bool operator ==(Label a, Label b);
+        public static bool operator !=(Label a, Label b);
+    }
+    public sealed class LocalBuilder : LocalVariableInfo, _LocalBuilder {
+        public override bool IsPinned { get; }
+        public override int LocalIndex { get; }
+        public override Type LocalType { get; }
+        public void SetLocalSymInfo(string name);
+        public void SetLocalSymInfo(string name, int startOffset, int endOffset);
+        void System.Runtime.InteropServices._LocalBuilder.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void System.Runtime.InteropServices._LocalBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void System.Runtime.InteropServices._LocalBuilder.GetTypeInfoCount(out uint pcTInfo);
+        void System.Runtime.InteropServices._LocalBuilder.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+    }
+    public sealed class MethodBuilder : MethodInfo, _MethodBuilder {
+        public override MethodAttributes Attributes { get; }
+        public override CallingConventions CallingConvention { get; }
+        public override bool ContainsGenericParameters { get; }
+        public override Type DeclaringType { get; }
+        public bool InitLocals { get; set; }
+        public override bool IsGenericMethod { get; }
+        public override bool IsGenericMethodDefinition { get; }
+        public override bool IsSecurityCritical { get; }
+        public override bool IsSecuritySafeCritical { get; }
+        public override bool IsSecurityTransparent { get; }
+        public override RuntimeMethodHandle MethodHandle { get; }
+        public override Module Module { get; }
+        public override string Name { get; }
+        public override Type ReflectedType { get; }
+        public override ParameterInfo ReturnParameter { get; }
+        public override Type ReturnType { get; }
+        public override ICustomAttributeProvider ReturnTypeCustomAttributes { get; }
+        public string Signature { get; }
+        public void AddDeclarativeSecurity(SecurityAction action, PermissionSet pset);
+        public void CreateMethodBody(byte[] il, int count);
+        public GenericTypeParameterBuilder[] DefineGenericParameters(params string[] names);
+        public ParameterBuilder DefineParameter(int position, ParameterAttributes attributes, string strParamName);
+        public override bool Equals(object obj);
+        public override MethodInfo GetBaseDefinition();
+        public override object[] GetCustomAttributes(bool inherit);
+        public override object[] GetCustomAttributes(Type attributeType, bool inherit);
+        public override Type[] GetGenericArguments();
+        public override MethodInfo GetGenericMethodDefinition();
+        public override int GetHashCode();
+        public ILGenerator GetILGenerator();
+        public ILGenerator GetILGenerator(int size);
+        public override MethodImplAttributes GetMethodImplementationFlags();
+        public Module GetModule();
+        public override ParameterInfo[] GetParameters();
+        public MethodToken GetToken();
+        public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);
+        public override bool IsDefined(Type attributeType, bool inherit);
+        public override MethodInfo MakeGenericMethod(params Type[] typeArguments);
+        public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute);
+        public void SetCustomAttribute(CustomAttributeBuilder customBuilder);
+        public void SetImplementationFlags(MethodImplAttributes attributes);
+        public void SetMarshal(UnmanagedMarshal unmanagedMarshal);
+        public void SetMethodBody(byte[] il, int maxStack, byte[] localSignature, IEnumerable<ExceptionHandler> exceptionHandlers, IEnumerable<int> tokenFixups);
+        public void SetParameters(params Type[] parameterTypes);
+        public void SetReturnType(Type returnType);
+        public void SetSignature(Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[][] parameterTypeRequiredCustomModifiers, Type[][] parameterTypeOptionalCustomModifiers);
+        public void SetSymCustomAttribute(string name, byte[] data);
+        void System.Runtime.InteropServices._MethodBuilder.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void System.Runtime.InteropServices._MethodBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void System.Runtime.InteropServices._MethodBuilder.GetTypeInfoCount(out uint pcTInfo);
+        void System.Runtime.InteropServices._MethodBuilder.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+        public override string ToString();
+    }
+    public sealed class MethodRental : _MethodRental {
+        public const int JitImmediate = 1;
+        public const int JitOnDemand = 0;
+        public static void SwapMethodBody(Type cls, int methodtoken, IntPtr rgIL, int methodSize, int flags);
+        void System.Runtime.InteropServices._MethodRental.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void System.Runtime.InteropServices._MethodRental.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void System.Runtime.InteropServices._MethodRental.GetTypeInfoCount(out uint pcTInfo);
+        void System.Runtime.InteropServices._MethodRental.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct MethodToken {
+        public static readonly MethodToken Empty;
+        public int Token { get; }
+        public override bool Equals(object obj);
+        public bool Equals(MethodToken obj);
+        public override int GetHashCode();
+        public static bool operator ==(MethodToken a, MethodToken b);
+        public static bool operator !=(MethodToken a, MethodToken b);
+    }
+    public class ModuleBuilder : Module, _ModuleBuilder {
+        public override Assembly Assembly { get; }
+        public override string FullyQualifiedName { get; }
+        public override int MDStreamVersion { get; }
+        public override int MetadataToken { get; }
+        public override Guid ModuleVersionId { get; }
+        public override string Name { get; }
+        public override string ScopeName { get; }
+        public void CreateGlobalFunctions();
+        public ISymbolDocumentWriter DefineDocument(string url, Guid language, Guid languageVendor, Guid documentType);
+        public EnumBuilder DefineEnum(string name, TypeAttributes visibility, Type underlyingType);
+        public MethodBuilder DefineGlobalMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes);
+        public MethodBuilder DefineGlobalMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] requiredReturnTypeCustomModifiers, Type[] optionalReturnTypeCustomModifiers, Type[] parameterTypes, Type[][] requiredParameterTypeCustomModifiers, Type[][] optionalParameterTypeCustomModifiers);
+        public MethodBuilder DefineGlobalMethod(string name, MethodAttributes attributes, Type returnType, Type[] parameterTypes);
+        public FieldBuilder DefineInitializedData(string name, byte[] data, FieldAttributes attributes);
+        public void DefineManifestResource(string name, Stream stream, ResourceAttributes attribute);
+        public MethodBuilder DefinePInvokeMethod(string name, string dllName, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, CallingConvention nativeCallConv, CharSet nativeCharSet);
+        public MethodBuilder DefinePInvokeMethod(string name, string dllName, string entryName, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, CallingConvention nativeCallConv, CharSet nativeCharSet);
+        public IResourceWriter DefineResource(string name, string description);
+        public IResourceWriter DefineResource(string name, string description, ResourceAttributes attribute);
+        public TypeBuilder DefineType(string name);
+        public TypeBuilder DefineType(string name, TypeAttributes attr);
+        public TypeBuilder DefineType(string name, TypeAttributes attr, Type parent);
+        public TypeBuilder DefineType(string name, TypeAttributes attr, Type parent, int typesize);
+        public TypeBuilder DefineType(string name, TypeAttributes attr, Type parent, PackingSize packsize);
+        public TypeBuilder DefineType(string name, TypeAttributes attr, Type parent, PackingSize packingSize, int typesize);
+        public TypeBuilder DefineType(string name, TypeAttributes attr, Type parent, Type[] interfaces);
+        public FieldBuilder DefineUninitializedData(string name, int size, FieldAttributes attributes);
+        public void DefineUnmanagedResource(byte[] resource);
+        public void DefineUnmanagedResource(string resourceFileName);
+        public override bool Equals(object obj);
+        public MethodInfo GetArrayMethod(Type arrayClass, string methodName, CallingConventions callingConvention, Type returnType, Type[] parameterTypes);
+        public MethodToken GetArrayMethodToken(Type arrayClass, string methodName, CallingConventions callingConvention, Type returnType, Type[] parameterTypes);
+        public MethodToken GetConstructorToken(ConstructorInfo con);
+        public MethodToken GetConstructorToken(ConstructorInfo constructor, IEnumerable<Type> optionalParameterTypes);
+        public override object[] GetCustomAttributes(bool inherit);
+        public override object[] GetCustomAttributes(Type attributeType, bool inherit);
+        public override IList<CustomAttributeData> GetCustomAttributesData();
+        public override FieldInfo GetField(string name, BindingFlags bindingAttr);
+        public override FieldInfo[] GetFields(BindingFlags bindingFlags);
+        public FieldToken GetFieldToken(FieldInfo field);
+        public override int GetHashCode();
+        protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);
+        public override MethodInfo[] GetMethods(BindingFlags bindingFlags);
+        public MethodToken GetMethodToken(MethodInfo method);
+        public MethodToken GetMethodToken(MethodInfo method, IEnumerable<Type> optionalParameterTypes);
+        public override void GetPEKind(out PortableExecutableKinds peKind, out ImageFileMachine machine);
+        public SignatureToken GetSignatureToken(byte[] sigBytes, int sigLength);
+        public SignatureToken GetSignatureToken(SignatureHelper sigHelper);
+        public override X509Certificate GetSignerCertificate();
+        public StringToken GetStringConstant(string str);
+        public ISymbolWriter GetSymWriter();
+        public override Type GetType(string className);
+        public override Type GetType(string className, bool ignoreCase);
+        public override Type GetType(string className, bool throwOnError, bool ignoreCase);
+        public override Type[] GetTypes();
+        public TypeToken GetTypeToken(string name);
+        public TypeToken GetTypeToken(Type type);
+        public override bool IsDefined(Type attributeType, bool inherit);
+        public override bool IsResource();
+        public bool IsTransient();
+        public override FieldInfo ResolveField(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments);
+        public override MemberInfo ResolveMember(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments);
+        public override MethodBase ResolveMethod(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments);
+        public override byte[] ResolveSignature(int metadataToken);
+        public override string ResolveString(int metadataToken);
+        public override Type ResolveType(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments);
+        public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute);
+        public void SetCustomAttribute(CustomAttributeBuilder customBuilder);
+        public void SetSymCustomAttribute(string name, byte[] data);
+        public void SetUserEntryPoint(MethodInfo entryPoint);
+        void System.Runtime.InteropServices._ModuleBuilder.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void System.Runtime.InteropServices._ModuleBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void System.Runtime.InteropServices._ModuleBuilder.GetTypeInfoCount(out uint pcTInfo);
+        void System.Runtime.InteropServices._ModuleBuilder.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+    }
+    public class ParameterBuilder : _ParameterBuilder {
+        public virtual int Attributes { get; }
+        public bool IsIn { get; }
+        public bool IsOptional { get; }
+        public bool IsOut { get; }
+        public virtual string Name { get; }
+        public virtual int Position { get; }
+        public virtual ParameterToken GetToken();
+        public virtual void SetConstant(object defaultValue);
+        public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute);
+        public void SetCustomAttribute(CustomAttributeBuilder customBuilder);
+        public virtual void SetMarshal(UnmanagedMarshal unmanagedMarshal);
+        void System.Runtime.InteropServices._ParameterBuilder.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void System.Runtime.InteropServices._ParameterBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void System.Runtime.InteropServices._ParameterBuilder.GetTypeInfoCount(out uint pcTInfo);
+        void System.Runtime.InteropServices._ParameterBuilder.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct ParameterToken {
+        public static readonly ParameterToken Empty;
+        public int Token { get; }
+        public override bool Equals(object obj);
+        public bool Equals(ParameterToken obj);
+        public override int GetHashCode();
+        public static bool operator ==(ParameterToken a, ParameterToken b);
+        public static bool operator !=(ParameterToken a, ParameterToken b);
+    }
+    public enum PEFileKinds {
+        ConsoleApplication = 2,
+        Dll = 1,
+        WindowApplication = 3,
+    }
+    public sealed class PropertyBuilder : PropertyInfo, _PropertyBuilder {
+        public override PropertyAttributes Attributes { get; }
+        public override bool CanRead { get; }
+        public override bool CanWrite { get; }
+        public override Type DeclaringType { get; }
+        public override Module Module { get; }
+        public override string Name { get; }
+        public PropertyToken PropertyToken { get; }
+        public override Type PropertyType { get; }
+        public override Type ReflectedType { get; }
+        public void AddOtherMethod(MethodBuilder mdBuilder);
+        public override MethodInfo[] GetAccessors(bool nonPublic);
+        public override object[] GetCustomAttributes(bool inherit);
+        public override object[] GetCustomAttributes(Type attributeType, bool inherit);
+        public override MethodInfo GetGetMethod(bool nonPublic);
+        public override ParameterInfo[] GetIndexParameters();
+        public override MethodInfo GetSetMethod(bool nonPublic);
+        public override object GetValue(object obj, object[] index);
+        public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);
+        public override bool IsDefined(Type attributeType, bool inherit);
+        public void SetConstant(object defaultValue);
+        public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute);
+        public void SetCustomAttribute(CustomAttributeBuilder customBuilder);
+        public void SetGetMethod(MethodBuilder mdBuilder);
+        public void SetSetMethod(MethodBuilder mdBuilder);
+        public override void SetValue(object obj, object value, object[] index);
+        public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);
+        void System.Runtime.InteropServices._PropertyBuilder.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void System.Runtime.InteropServices._PropertyBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void System.Runtime.InteropServices._PropertyBuilder.GetTypeInfoCount(out uint pcTInfo);
+        void System.Runtime.InteropServices._PropertyBuilder.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct PropertyToken {
+        public static readonly PropertyToken Empty;
+        public int Token { get; }
+        public override bool Equals(object obj);
+        public bool Equals(PropertyToken obj);
+        public override int GetHashCode();
+        public static bool operator ==(PropertyToken a, PropertyToken b);
+        public static bool operator !=(PropertyToken a, PropertyToken b);
+    }
+    public sealed class SignatureHelper : _SignatureHelper {
+        public void AddArgument(Type clsArgument);
+        public void AddArgument(Type argument, bool pinned);
+        public void AddArgument(Type argument, Type[] requiredCustomModifiers, Type[] optionalCustomModifiers);
+        public void AddArguments(Type[] arguments, Type[][] requiredCustomModifiers, Type[][] optionalCustomModifiers);
+        public void AddSentinel();
+        public override bool Equals(object obj);
+        public static SignatureHelper GetFieldSigHelper(Module mod);
+        public override int GetHashCode();
+        public static SignatureHelper GetLocalVarSigHelper();
+        public static SignatureHelper GetLocalVarSigHelper(Module mod);
+        public static SignatureHelper GetMethodSigHelper(CallingConventions callingConvention, Type returnType);
+        public static SignatureHelper GetMethodSigHelper(Module mod, CallingConventions callingConvention, Type returnType);
+        public static SignatureHelper GetMethodSigHelper(Module mod, CallingConvention unmanagedCallConv, Type returnType);
+        public static SignatureHelper GetMethodSigHelper(Module mod, Type returnType, Type[] parameterTypes);
+        public static SignatureHelper GetMethodSigHelper(CallingConvention unmanagedCallingConvention, Type returnType);
+        public static SignatureHelper GetPropertySigHelper(Module mod, CallingConventions callingConvention, Type returnType, Type[] requiredReturnTypeCustomModifiers, Type[] optionalReturnTypeCustomModifiers, Type[] parameterTypes, Type[][] requiredParameterTypeCustomModifiers, Type[][] optionalParameterTypeCustomModifiers);
+        public static SignatureHelper GetPropertySigHelper(Module mod, Type returnType, Type[] parameterTypes);
+        public static SignatureHelper GetPropertySigHelper(Module mod, Type returnType, Type[] requiredReturnTypeCustomModifiers, Type[] optionalReturnTypeCustomModifiers, Type[] parameterTypes, Type[][] requiredParameterTypeCustomModifiers, Type[][] optionalParameterTypeCustomModifiers);
+        public byte[] GetSignature();
+        void System.Runtime.InteropServices._SignatureHelper.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void System.Runtime.InteropServices._SignatureHelper.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void System.Runtime.InteropServices._SignatureHelper.GetTypeInfoCount(out uint pcTInfo);
+        void System.Runtime.InteropServices._SignatureHelper.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+        public override string ToString();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct SignatureToken {
+        public static readonly SignatureToken Empty;
+        public int Token { get; }
+        public override bool Equals(object obj);
+        public bool Equals(SignatureToken obj);
+        public override int GetHashCode();
+        public static bool operator ==(SignatureToken a, SignatureToken b);
+        public static bool operator !=(SignatureToken a, SignatureToken b);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct StringToken {
+        public int Token { get; }
+        public override bool Equals(object obj);
+        public bool Equals(StringToken obj);
+        public override int GetHashCode();
+        public static bool operator ==(StringToken a, StringToken b);
+        public static bool operator !=(StringToken a, StringToken b);
+    }
+    public sealed class TypeBuilder : TypeInfo, _TypeBuilder {
+        public const int UnspecifiedTypeSize = 0;
+        public override Assembly Assembly { get; }
+        public override string AssemblyQualifiedName { get; }
+        public override Type BaseType { get; }
+        public override MethodBase DeclaringMethod { get; }
+        public override Type DeclaringType { get; }
+        public override string FullName { get; }
+        public override GenericParameterAttributes GenericParameterAttributes { get; }
+        public override int GenericParameterPosition { get; }
+        public override Guid GUID { get; }
+        public override bool IsConstructedGenericType { get; }
+        public override bool IsGenericParameter { get; }
+        public override bool IsGenericType { get; }
+        public override bool IsGenericTypeDefinition { get; }
+        public override bool IsSecurityCritical { get; }
+        public override bool IsSecuritySafeCritical { get; }
+        public override bool IsSecurityTransparent { get; }
+        public override Module Module { get; }
+        public override string Name { get; }
+        public override string Namespace { get; }
+        public PackingSize PackingSize { get; }
+        public override Type ReflectedType { get; }
+        public int Size { get; }
+        public override RuntimeTypeHandle TypeHandle { get; }
+        public TypeToken TypeToken { get; }
+        public override Type UnderlyingSystemType { get; }
+        public void AddDeclarativeSecurity(SecurityAction action, PermissionSet pset);
+        public void AddInterfaceImplementation(Type interfaceType);
+        public Type CreateType();
+        public TypeInfo CreateTypeInfo();
+        public ConstructorBuilder DefineConstructor(MethodAttributes attributes, CallingConventions callingConvention, Type[] parameterTypes);
+        public ConstructorBuilder DefineConstructor(MethodAttributes attributes, CallingConventions callingConvention, Type[] parameterTypes, Type[][] requiredCustomModifiers, Type[][] optionalCustomModifiers);
+        public ConstructorBuilder DefineDefaultConstructor(MethodAttributes attributes);
+        public EventBuilder DefineEvent(string name, EventAttributes attributes, Type eventtype);
+        public FieldBuilder DefineField(string fieldName, Type type, FieldAttributes attributes);
+        public FieldBuilder DefineField(string fieldName, Type type, Type[] requiredCustomModifiers, Type[] optionalCustomModifiers, FieldAttributes attributes);
+        public GenericTypeParameterBuilder[] DefineGenericParameters(params string[] names);
+        public FieldBuilder DefineInitializedData(string name, byte[] data, FieldAttributes attributes);
+        public MethodBuilder DefineMethod(string name, MethodAttributes attributes);
+        public MethodBuilder DefineMethod(string name, MethodAttributes attributes, CallingConventions callingConvention);
+        public MethodBuilder DefineMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes);
+        public MethodBuilder DefineMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[][] parameterTypeRequiredCustomModifiers, Type[][] parameterTypeOptionalCustomModifiers);
+        public MethodBuilder DefineMethod(string name, MethodAttributes attributes, Type returnType, Type[] parameterTypes);
+        public void DefineMethodOverride(MethodInfo methodInfoBody, MethodInfo methodInfoDeclaration);
+        public TypeBuilder DefineNestedType(string name);
+        public TypeBuilder DefineNestedType(string name, TypeAttributes attr);
+        public TypeBuilder DefineNestedType(string name, TypeAttributes attr, Type parent);
+        public TypeBuilder DefineNestedType(string name, TypeAttributes attr, Type parent, int typeSize);
+        public TypeBuilder DefineNestedType(string name, TypeAttributes attr, Type parent, PackingSize packSize);
+        public TypeBuilder DefineNestedType(string name, TypeAttributes attr, Type parent, PackingSize packSize, int typeSize);
+        public TypeBuilder DefineNestedType(string name, TypeAttributes attr, Type parent, Type[] interfaces);
+        public MethodBuilder DefinePInvokeMethod(string name, string dllName, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, CallingConvention nativeCallConv, CharSet nativeCharSet);
+        public MethodBuilder DefinePInvokeMethod(string name, string dllName, string entryName, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, CallingConvention nativeCallConv, CharSet nativeCharSet);
+        public MethodBuilder DefinePInvokeMethod(string name, string dllName, string entryName, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[][] parameterTypeRequiredCustomModifiers, Type[][] parameterTypeOptionalCustomModifiers, CallingConvention nativeCallConv, CharSet nativeCharSet);
+        public PropertyBuilder DefineProperty(string name, PropertyAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes);
+        public PropertyBuilder DefineProperty(string name, PropertyAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[][] parameterTypeRequiredCustomModifiers, Type[][] parameterTypeOptionalCustomModifiers);
+        public PropertyBuilder DefineProperty(string name, PropertyAttributes attributes, Type returnType, Type[] parameterTypes);
+        public PropertyBuilder DefineProperty(string name, PropertyAttributes attributes, Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[][] parameterTypeRequiredCustomModifiers, Type[][] parameterTypeOptionalCustomModifiers);
+        public ConstructorBuilder DefineTypeInitializer();
+        public FieldBuilder DefineUninitializedData(string name, int size, FieldAttributes attributes);
+        protected override TypeAttributes GetAttributeFlagsImpl();
+        public static ConstructorInfo GetConstructor(Type type, ConstructorInfo constructor);
+        protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);
+        public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr);
+        public override object[] GetCustomAttributes(bool inherit);
+        public override object[] GetCustomAttributes(Type attributeType, bool inherit);
+        public override Type GetElementType();
+        public override EventInfo GetEvent(string name, BindingFlags bindingAttr);
+        public override EventInfo[] GetEvents();
+        public override EventInfo[] GetEvents(BindingFlags bindingAttr);
+        public override FieldInfo GetField(string name, BindingFlags bindingAttr);
+        public static FieldInfo GetField(Type type, FieldInfo field);
+        public override FieldInfo[] GetFields(BindingFlags bindingAttr);
+        public override Type[] GetGenericArguments();
+        public override Type GetGenericTypeDefinition();
+        public override Type GetInterface(string name, bool ignoreCase);
+        public override InterfaceMapping GetInterfaceMap(Type interfaceType);
+        public override Type[] GetInterfaces();
+        public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr);
+        public override MemberInfo[] GetMembers(BindingFlags bindingAttr);
+        public static MethodInfo GetMethod(Type type, MethodInfo method);
+        protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);
+        public override MethodInfo[] GetMethods(BindingFlags bindingAttr);
+        public override Type GetNestedType(string name, BindingFlags bindingAttr);
+        public override Type[] GetNestedTypes(BindingFlags bindingAttr);
+        public override PropertyInfo[] GetProperties(BindingFlags bindingAttr);
+        protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers);
+        protected override bool HasElementTypeImpl();
+        public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters);
+        protected override bool IsArrayImpl();
+        public override bool IsAssignableFrom(TypeInfo typeInfo);
+        public override bool IsAssignableFrom(Type c);
+        protected override bool IsByRefImpl();
+        protected override bool IsCOMObjectImpl();
+        public bool IsCreated();
+        public override bool IsDefined(Type attributeType, bool inherit);
+        protected override bool IsPointerImpl();
+        protected override bool IsPrimitiveImpl();
+        public override bool IsSubclassOf(Type c);
+        public override Type MakeArrayType();
+        public override Type MakeArrayType(int rank);
+        public override Type MakeByRefType();
+        public override Type MakeGenericType(params Type[] typeArguments);
+        public override Type MakePointerType();
+        public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute);
+        public void SetCustomAttribute(CustomAttributeBuilder customBuilder);
+        public void SetParent(Type parent);
+        void System.Runtime.InteropServices._TypeBuilder.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
+        void System.Runtime.InteropServices._TypeBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
+        void System.Runtime.InteropServices._TypeBuilder.GetTypeInfoCount(out uint pcTInfo);
+        void System.Runtime.InteropServices._TypeBuilder.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
+        public override string ToString();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct TypeToken {
+        public static readonly TypeToken Empty;
+        public int Token { get; }
+        public override bool Equals(object obj);
+        public bool Equals(TypeToken obj);
+        public override int GetHashCode();
+        public static bool operator ==(TypeToken a, TypeToken b);
+        public static bool operator !=(TypeToken a, TypeToken b);
+    }
+    public sealed class UnmanagedMarshal {
+        public UnmanagedType BaseType { get; }
+        public int ElementCount { get; }
+        public UnmanagedType GetUnmanagedType { get; }
+        public Guid IIDGuid { get; }
+        public static UnmanagedMarshal DefineByValArray(int elemCount);
+        public static UnmanagedMarshal DefineByValTStr(int elemCount);
+        public static UnmanagedMarshal DefineLPArray(UnmanagedType elemType);
+        public static UnmanagedMarshal DefineSafeArray(UnmanagedType elemType);
+        public static UnmanagedMarshal DefineUnmanagedMarshal(UnmanagedType unmanagedType);
+    }
 }
```

