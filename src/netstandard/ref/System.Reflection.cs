// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Reflection
{
    public sealed partial class AmbiguousMatchException : System.SystemException
    {
        public AmbiguousMatchException() { }
        public AmbiguousMatchException(string message) { }
        public AmbiguousMatchException(string message, System.Exception inner) { }
    }
    public abstract partial class Assembly : System.Reflection.ICustomAttributeProvider, System.Runtime.Serialization.ISerializable
//CAS , System.Security.IEvidenceFactory
    {
        protected Assembly() { }
        public virtual string CodeBase { get { throw null; } }
        public virtual System.Collections.Generic.IEnumerable<System.Reflection.CustomAttributeData> CustomAttributes { get { throw null; } }
        public virtual System.Collections.Generic.IEnumerable<System.Reflection.TypeInfo> DefinedTypes { get { throw null; } }
        public virtual System.Reflection.MethodInfo EntryPoint { get { throw null; } }
        public virtual string EscapedCodeBase { get { throw null; } }
//CAS        public virtual System.Security.Policy.Evidence Evidence { get { throw null; } }
        public virtual System.Collections.Generic.IEnumerable<System.Type> ExportedTypes { get { throw null; } }
        public virtual string FullName { get { throw null; } }
        public virtual bool GlobalAssemblyCache { get { throw null; } }
        public virtual long HostContext { get { throw null; } }
        public virtual string ImageRuntimeVersion { get { throw null; } }
        public virtual bool IsDynamic { get { throw null; } }
        public bool IsFullyTrusted { get { throw null; } }
        public virtual string Location { get { throw null; } }
        public virtual System.Reflection.Module ManifestModule { get { throw null; } }
        public virtual System.Collections.Generic.IEnumerable<System.Reflection.Module> Modules { get { throw null; } }
//CAS        public virtual System.Security.PermissionSet PermissionSet { get { throw null; } }
        public virtual bool ReflectionOnly { get { throw null; } }
        public virtual System.Security.SecurityRuleSet SecurityRuleSet { get { throw null; } }
        public virtual event System.Reflection.ModuleResolveEventHandler ModuleResolve { add { } remove { } }
        public object CreateInstance(string typeName) { throw null; }
        public object CreateInstance(string typeName, bool ignoreCase) { throw null; }
        public virtual object CreateInstance(string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes) { throw null; }
        public static string CreateQualifiedName(string assemblyName, string typeName) { throw null; }
        public override bool Equals(object o) { throw null; }
        public static System.Reflection.Assembly GetAssembly(System.Type type) { throw null; }
        public static System.Reflection.Assembly GetCallingAssembly() { throw null; }
        public virtual object[] GetCustomAttributes(bool inherit) { throw null; }
        public virtual object[] GetCustomAttributes(System.Type attributeType, bool inherit) { throw null; }
        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData() { throw null; }
        public static System.Reflection.Assembly GetEntryAssembly() { throw null; }
        public static System.Reflection.Assembly GetExecutingAssembly() { throw null; }
        public virtual System.Type[] GetExportedTypes() { throw null; }
        public virtual System.IO.FileStream GetFile(string name) { throw null; }
        public virtual System.IO.FileStream[] GetFiles() { throw null; }
        public virtual System.IO.FileStream[] GetFiles(bool getResourceModules) { throw null; }
        public virtual System.Type[] GetForwardedTypes() { throw null; }
        public override int GetHashCode() { throw null; }
        public System.Reflection.Module[] GetLoadedModules() { throw null; }
        public virtual System.Reflection.Module[] GetLoadedModules(bool getResourceModules) { throw null; }
        public virtual System.Reflection.ManifestResourceInfo GetManifestResourceInfo(string resourceName) { throw null; }
        public virtual string[] GetManifestResourceNames() { throw null; }
        public virtual System.IO.Stream GetManifestResourceStream(string name) { throw null; }
        public virtual System.IO.Stream GetManifestResourceStream(System.Type type, string name) { throw null; }
        public virtual System.Reflection.Module GetModule(string name) { throw null; }
        public System.Reflection.Module[] GetModules() { throw null; }
        public virtual System.Reflection.Module[] GetModules(bool getResourceModules) { throw null; }
        public virtual System.Reflection.AssemblyName GetName() { throw null; }
        public virtual System.Reflection.AssemblyName GetName(bool copiedName) { throw null; }
        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public virtual System.Reflection.AssemblyName[] GetReferencedAssemblies() { throw null; }
        public virtual System.Reflection.Assembly GetSatelliteAssembly(System.Globalization.CultureInfo culture) { throw null; }
        public virtual System.Reflection.Assembly GetSatelliteAssembly(System.Globalization.CultureInfo culture, System.Version version) { throw null; }
        public virtual System.Type GetType(string name) { throw null; }
        public virtual System.Type GetType(string name, bool throwOnError) { throw null; }
        public virtual System.Type GetType(string name, bool throwOnError, bool ignoreCase) { throw null; }
        public virtual System.Type[] GetTypes() { throw null; }
        public virtual bool IsDefined(System.Type attributeType, bool inherit) { throw null; }
        public static System.Reflection.Assembly Load(byte[] rawAssembly) { throw null; }
        public static System.Reflection.Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore) { throw null; }
//CAS        [System.ObsoleteAttribute("This method is obsolete and will be removed in a future release of the .NET Framework. Please use an overload of Load which does not take an Evidence parameter. See https://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//CAS        public static System.Reflection.Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore, System.Security.Policy.Evidence securityEvidence) { throw null; }
//CAS        public static System.Reflection.Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore, System.Security.SecurityContextSource securityContextSource) { throw null; }
        public static System.Reflection.Assembly Load(System.Reflection.AssemblyName assemblyRef) { throw null; }
//CAS        [System.ObsoleteAttribute("This method is obsolete and will be removed in a future release of the .NET Framework. Please use an overload of Load which does not take an Evidence parameter. See https://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//CAS        public static System.Reflection.Assembly Load(System.Reflection.AssemblyName assemblyRef, System.Security.Policy.Evidence assemblySecurity) { throw null; }
        public static System.Reflection.Assembly Load(string assemblyString) { throw null; }
//CAS        [System.ObsoleteAttribute("This method is obsolete and will be removed in a future release of the .NET Framework. Please use an overload of Load which does not take an Evidence parameter. See https://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//CAS        public static System.Reflection.Assembly Load(string assemblyString, System.Security.Policy.Evidence assemblySecurity) { throw null; }
        public static System.Reflection.Assembly LoadFile(string path) { throw null; }
//CAS        [System.ObsoleteAttribute("This method is obsolete and will be removed in a future release of the .NET Framework. Please use an overload of LoadFile which does not take an Evidence parameter. See https://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//CAS        public static System.Reflection.Assembly LoadFile(string path, System.Security.Policy.Evidence securityEvidence) { throw null; }
        public static System.Reflection.Assembly LoadFrom(string assemblyFile) { throw null; }
        public static System.Reflection.Assembly LoadFrom(string assemblyFile, byte[] hashValue, System.Configuration.Assemblies.AssemblyHashAlgorithm hashAlgorithm) { throw null; }
//CAS        [System.ObsoleteAttribute("This method is obsolete and will be removed in a future release of the .NET Framework. Please use an overload of LoadFrom which does not take an Evidence parameter. See https://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//CAS        public static System.Reflection.Assembly LoadFrom(string assemblyFile, System.Security.Policy.Evidence securityEvidence) { throw null; }
//CAS        [System.ObsoleteAttribute("This method is obsolete and will be removed in a future release of the .NET Framework. Please use an overload of LoadFrom which does not take an Evidence parameter. See https://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//CAS        public static System.Reflection.Assembly LoadFrom(string assemblyFile, System.Security.Policy.Evidence securityEvidence, byte[] hashValue, System.Configuration.Assemblies.AssemblyHashAlgorithm hashAlgorithm) { throw null; }
        public System.Reflection.Module LoadModule(string moduleName, byte[] rawModule) { throw null; }
        public virtual System.Reflection.Module LoadModule(string moduleName, byte[] rawModule, byte[] rawSymbolStore) { throw null; }
        [System.ObsoleteAttribute("This method has been deprecated. Please use Assembly.Load() instead. https://go.microsoft.com/fwlink/?linkid=14202")]
        public static System.Reflection.Assembly LoadWithPartialName(string partialName) { throw null; }
//CAS        [System.ObsoleteAttribute("This method has been deprecated. Please use Assembly.Load() instead. https://go.microsoft.com/fwlink/?linkid=14202")]
//CAS        public static System.Reflection.Assembly LoadWithPartialName(string partialName, System.Security.Policy.Evidence securityEvidence) { throw null; }
        public static bool operator ==(System.Reflection.Assembly left, System.Reflection.Assembly right) { throw null; }
        public static bool operator !=(System.Reflection.Assembly left, System.Reflection.Assembly right) { throw null; }
        public static System.Reflection.Assembly ReflectionOnlyLoad(byte[] rawAssembly) { throw null; }
        public static System.Reflection.Assembly ReflectionOnlyLoad(string assemblyString) { throw null; }
        public static System.Reflection.Assembly ReflectionOnlyLoadFrom(string assemblyFile) { throw null; }
        public override string ToString() { throw null; }
        public static System.Reflection.Assembly UnsafeLoadFrom(string assemblyFile) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, Inherited=false)]
    public sealed partial class AssemblyAlgorithmIdAttribute : System.Attribute
    {
        public AssemblyAlgorithmIdAttribute(System.Configuration.Assemblies.AssemblyHashAlgorithm algorithmId) { }
        [System.CLSCompliantAttribute(false)]
        public AssemblyAlgorithmIdAttribute(uint algorithmId) { }
        [System.CLSCompliantAttribute(false)]
        public uint AlgorithmId { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, Inherited=false)]
    public sealed partial class AssemblyCompanyAttribute : System.Attribute
    {
        public AssemblyCompanyAttribute(string company) { }
        public string Company { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, Inherited=false)]
    public sealed partial class AssemblyConfigurationAttribute : System.Attribute
    {
        public AssemblyConfigurationAttribute(string configuration) { }
        public string Configuration { get { throw null; } }
    }
    public enum AssemblyContentType
    {
        Default = 0,
        WindowsRuntime = 1,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, Inherited=false)]
    public sealed partial class AssemblyCopyrightAttribute : System.Attribute
    {
        public AssemblyCopyrightAttribute(string copyright) { }
        public string Copyright { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, Inherited=false)]
    public sealed partial class AssemblyCultureAttribute : System.Attribute
    {
        public AssemblyCultureAttribute(string culture) { }
        public string Culture { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, Inherited=false)]
    public sealed partial class AssemblyDefaultAliasAttribute : System.Attribute
    {
        public AssemblyDefaultAliasAttribute(string defaultAlias) { }
        public string DefaultAlias { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, Inherited=false)]
    public sealed partial class AssemblyDelaySignAttribute : System.Attribute
    {
        public AssemblyDelaySignAttribute(bool delaySign) { }
        public bool DelaySign { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, Inherited=false)]
    public sealed partial class AssemblyDescriptionAttribute : System.Attribute
    {
        public AssemblyDescriptionAttribute(string description) { }
        public string Description { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, Inherited=false)]
    public sealed partial class AssemblyFileVersionAttribute : System.Attribute
    {
        public AssemblyFileVersionAttribute(string version) { }
        public string Version { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, Inherited=false)]
    public sealed partial class AssemblyFlagsAttribute : System.Attribute
    {
        [System.ObsoleteAttribute("This constructor has been deprecated. Please use AssemblyFlagsAttribute(AssemblyNameFlags) instead. https://go.microsoft.com/fwlink/?linkid=14202")]
        public AssemblyFlagsAttribute(int assemblyFlags) { }
        public AssemblyFlagsAttribute(System.Reflection.AssemblyNameFlags assemblyFlags) { }
        [System.CLSCompliantAttribute(false)]
        [System.ObsoleteAttribute("This constructor has been deprecated. Please use AssemblyFlagsAttribute(AssemblyNameFlags) instead. https://go.microsoft.com/fwlink/?linkid=14202")]
        public AssemblyFlagsAttribute(uint flags) { }
        public int AssemblyFlags { get { throw null; } }
        [System.CLSCompliantAttribute(false)]
        [System.ObsoleteAttribute("This property has been deprecated. Please use AssemblyFlags instead. https://go.microsoft.com/fwlink/?linkid=14202")]
        public uint Flags { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, Inherited=false)]
    public sealed partial class AssemblyInformationalVersionAttribute : System.Attribute
    {
        public AssemblyInformationalVersionAttribute(string informationalVersion) { }
        public string InformationalVersion { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, Inherited=false)]
    public sealed partial class AssemblyKeyFileAttribute : System.Attribute
    {
        public AssemblyKeyFileAttribute(string keyFile) { }
        public string KeyFile { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, Inherited=false)]
    public sealed partial class AssemblyKeyNameAttribute : System.Attribute
    {
        public AssemblyKeyNameAttribute(string keyName) { }
        public string KeyName { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, AllowMultiple=true, Inherited=false)]
    public sealed partial class AssemblyMetadataAttribute : System.Attribute
    {
        public AssemblyMetadataAttribute(string key, string value) { }
        public string Key { get { throw null; } }
        public string Value { get { throw null; } }
    }
    public sealed partial class AssemblyName : System.ICloneable, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable
    {
        public AssemblyName() { }
        public AssemblyName(string assemblyName) { }
        public string CodeBase { get { throw null; } set { } }
        public System.Reflection.AssemblyContentType ContentType { get { throw null; } set { } }
        public System.Globalization.CultureInfo CultureInfo { get { throw null; } set { } }
        public string CultureName { get { throw null; } set { } }
        public string EscapedCodeBase { get { throw null; } }
        public System.Reflection.AssemblyNameFlags Flags { get { throw null; } set { } }
        public string FullName { get { throw null; } }
        public System.Configuration.Assemblies.AssemblyHashAlgorithm HashAlgorithm { get { throw null; } set { } }
        public System.Reflection.StrongNameKeyPair KeyPair { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public System.Reflection.ProcessorArchitecture ProcessorArchitecture { get { throw null; } set { } }
        public System.Version Version { get { throw null; } set { } }
        public System.Configuration.Assemblies.AssemblyVersionCompatibility VersionCompatibility { get { throw null; } set { } }
        public object Clone() { throw null; }
        public static System.Reflection.AssemblyName GetAssemblyName(string assemblyFile) { throw null; }
        public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public byte[] GetPublicKey() { throw null; }
        public byte[] GetPublicKeyToken() { throw null; }
        public void OnDeserialization(object sender) { }
        public static bool ReferenceMatchesDefinition(System.Reflection.AssemblyName reference, System.Reflection.AssemblyName definition) { throw null; }
        public void SetPublicKey(byte[] publicKey) { }
        public void SetPublicKeyToken(byte[] publicKeyToken) { }
        public override string ToString() { throw null; }
    }
    [System.FlagsAttribute]
    public enum AssemblyNameFlags
    {
        EnableJITcompileOptimizer = 16384,
        EnableJITcompileTracking = 32768,
        None = 0,
        PublicKey = 1,
        Retargetable = 256,
    }
    public partial class AssemblyNameProxy : System.MarshalByRefObject
    {
        public AssemblyNameProxy() { }
        public System.Reflection.AssemblyName GetAssemblyName(string assemblyFile) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, Inherited=false)]
    public sealed partial class AssemblyProductAttribute : System.Attribute
    {
        public AssemblyProductAttribute(string product) { }
        public string Product { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, Inherited=false, AllowMultiple=false)]
    public sealed partial class AssemblySignatureKeyAttribute : System.Attribute
    {
        public AssemblySignatureKeyAttribute(string publicKey, string countersignature) { }
        public string Countersignature { get { throw null; } }
        public string PublicKey { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, Inherited=false)]
    public sealed partial class AssemblyTitleAttribute : System.Attribute
    {
        public AssemblyTitleAttribute(string title) { }
        public string Title { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, Inherited=false)]
    public sealed partial class AssemblyTrademarkAttribute : System.Attribute
    {
        public AssemblyTrademarkAttribute(string trademark) { }
        public string Trademark { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, Inherited=false)]
    public sealed partial class AssemblyVersionAttribute : System.Attribute
    {
        public AssemblyVersionAttribute(string version) { }
        public string Version { get { throw null; } }
    }
    public abstract partial class Binder
    {
        protected Binder() { }
        public abstract System.Reflection.FieldInfo BindToField(System.Reflection.BindingFlags bindingAttr, System.Reflection.FieldInfo[] match, object value, System.Globalization.CultureInfo culture);
        public abstract System.Reflection.MethodBase BindToMethod(System.Reflection.BindingFlags bindingAttr, System.Reflection.MethodBase[] match, ref object[] args, System.Reflection.ParameterModifier[] modifiers, System.Globalization.CultureInfo culture, string[] names, out object state);
        public abstract object ChangeType(object value, System.Type type, System.Globalization.CultureInfo culture);
        public abstract void ReorderArgumentArray(ref object[] args, object state);
        public abstract System.Reflection.MethodBase SelectMethod(System.Reflection.BindingFlags bindingAttr, System.Reflection.MethodBase[] match, System.Type[] types, System.Reflection.ParameterModifier[] modifiers);
        public abstract System.Reflection.PropertyInfo SelectProperty(System.Reflection.BindingFlags bindingAttr, System.Reflection.PropertyInfo[] match, System.Type returnType, System.Type[] indexes, System.Reflection.ParameterModifier[] modifiers);
    }
    [System.FlagsAttribute]
    public enum BindingFlags
    {
        CreateInstance = 512,
        DeclaredOnly = 2,
        Default = 0,
        DoNotWrapExceptions = 33554432,
        ExactBinding = 65536,
        FlattenHierarchy = 64,
        GetField = 1024,
        GetProperty = 4096,
        IgnoreCase = 1,
        IgnoreReturn = 16777216,
        Instance = 4,
        InvokeMethod = 256,
        NonPublic = 32,
        OptionalParamBinding = 262144,
        Public = 16,
        PutDispProperty = 16384,
        PutRefDispProperty = 32768,
        SetField = 2048,
        SetProperty = 8192,
        Static = 8,
        SuppressChangeType = 131072,
    }
    [System.FlagsAttribute]
    public enum CallingConventions
    {
        Any = 3,
        ExplicitThis = 64,
        HasThis = 32,
        Standard = 1,
        VarArgs = 2,
    }
    public abstract partial class ConstructorInfo : System.Reflection.MethodBase
    {
        public static readonly string ConstructorName;
        public static readonly string TypeConstructorName;
        protected ConstructorInfo() { }
        public override System.Reflection.MemberTypes MemberType { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public object Invoke(object[] parameters) { throw null; }
        public abstract object Invoke(System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] parameters, System.Globalization.CultureInfo culture);
        public static bool operator ==(System.Reflection.ConstructorInfo left, System.Reflection.ConstructorInfo right) { throw null; }
        public static bool operator !=(System.Reflection.ConstructorInfo left, System.Reflection.ConstructorInfo right) { throw null; }
    }
    public partial class CustomAttributeData
    {
        protected CustomAttributeData() { }
        public System.Type AttributeType { get { throw null; } }
        public virtual System.Reflection.ConstructorInfo Constructor { get { throw null; } }
        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeTypedArgument> ConstructorArguments { get { throw null; } }
        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeNamedArgument> NamedArguments { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public static System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributes(System.Reflection.Assembly target) { throw null; }
        public static System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributes(System.Reflection.MemberInfo target) { throw null; }
        public static System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributes(System.Reflection.Module target) { throw null; }
        public static System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributes(System.Reflection.ParameterInfo target) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public static partial class CustomAttributeExtensions
    {
        public static System.Attribute GetCustomAttribute(this System.Reflection.Assembly element, System.Type attributeType) { throw null; }
        public static System.Attribute GetCustomAttribute(this System.Reflection.MemberInfo element, System.Type attributeType) { throw null; }
        public static System.Attribute GetCustomAttribute(this System.Reflection.MemberInfo element, System.Type attributeType, bool inherit) { throw null; }
        public static System.Attribute GetCustomAttribute(this System.Reflection.Module element, System.Type attributeType) { throw null; }
        public static System.Attribute GetCustomAttribute(this System.Reflection.ParameterInfo element, System.Type attributeType) { throw null; }
        public static System.Attribute GetCustomAttribute(this System.Reflection.ParameterInfo element, System.Type attributeType, bool inherit) { throw null; }
        public static System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes(this System.Reflection.Assembly element) { throw null; }
        public static System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes(this System.Reflection.Assembly element, System.Type attributeType) { throw null; }
        public static System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes(this System.Reflection.MemberInfo element) { throw null; }
        public static System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes(this System.Reflection.MemberInfo element, bool inherit) { throw null; }
        public static System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes(this System.Reflection.MemberInfo element, System.Type attributeType) { throw null; }
        public static System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes(this System.Reflection.MemberInfo element, System.Type attributeType, bool inherit) { throw null; }
        public static System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes(this System.Reflection.Module element) { throw null; }
        public static System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes(this System.Reflection.Module element, System.Type attributeType) { throw null; }
        public static System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes(this System.Reflection.ParameterInfo element) { throw null; }
        public static System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes(this System.Reflection.ParameterInfo element, bool inherit) { throw null; }
        public static System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes(this System.Reflection.ParameterInfo element, System.Type attributeType) { throw null; }
        public static System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes(this System.Reflection.ParameterInfo element, System.Type attributeType, bool inherit) { throw null; }
        public static System.Collections.Generic.IEnumerable<T> GetCustomAttributes<T>(this System.Reflection.Assembly element) where T : System.Attribute { throw null; }
        public static System.Collections.Generic.IEnumerable<T> GetCustomAttributes<T>(this System.Reflection.MemberInfo element) where T : System.Attribute { throw null; }
        public static System.Collections.Generic.IEnumerable<T> GetCustomAttributes<T>(this System.Reflection.MemberInfo element, bool inherit) where T : System.Attribute { throw null; }
        public static System.Collections.Generic.IEnumerable<T> GetCustomAttributes<T>(this System.Reflection.Module element) where T : System.Attribute { throw null; }
        public static System.Collections.Generic.IEnumerable<T> GetCustomAttributes<T>(this System.Reflection.ParameterInfo element) where T : System.Attribute { throw null; }
        public static System.Collections.Generic.IEnumerable<T> GetCustomAttributes<T>(this System.Reflection.ParameterInfo element, bool inherit) where T : System.Attribute { throw null; }
        public static T GetCustomAttribute<T>(this System.Reflection.Assembly element) where T : System.Attribute { throw null; }
        public static T GetCustomAttribute<T>(this System.Reflection.MemberInfo element) where T : System.Attribute { throw null; }
        public static T GetCustomAttribute<T>(this System.Reflection.MemberInfo element, bool inherit) where T : System.Attribute { throw null; }
        public static T GetCustomAttribute<T>(this System.Reflection.Module element) where T : System.Attribute { throw null; }
        public static T GetCustomAttribute<T>(this System.Reflection.ParameterInfo element) where T : System.Attribute { throw null; }
        public static T GetCustomAttribute<T>(this System.Reflection.ParameterInfo element, bool inherit) where T : System.Attribute { throw null; }
        public static bool IsDefined(this System.Reflection.Assembly element, System.Type attributeType) { throw null; }
        public static bool IsDefined(this System.Reflection.MemberInfo element, System.Type attributeType) { throw null; }
        public static bool IsDefined(this System.Reflection.MemberInfo element, System.Type attributeType, bool inherit) { throw null; }
        public static bool IsDefined(this System.Reflection.Module element, System.Type attributeType) { throw null; }
        public static bool IsDefined(this System.Reflection.ParameterInfo element, System.Type attributeType) { throw null; }
        public static bool IsDefined(this System.Reflection.ParameterInfo element, System.Type attributeType, bool inherit) { throw null; }
    }
    public partial class CustomAttributeFormatException : System.FormatException
    {
        public CustomAttributeFormatException() { }
        protected CustomAttributeFormatException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public CustomAttributeFormatException(string message) { }
        public CustomAttributeFormatException(string message, System.Exception inner) { }
    }
    public partial struct CustomAttributeNamedArgument
    {
        private object _dummy;
        public CustomAttributeNamedArgument(System.Reflection.MemberInfo memberInfo, object value) { throw null; }
        public CustomAttributeNamedArgument(System.Reflection.MemberInfo memberInfo, System.Reflection.CustomAttributeTypedArgument typedArgument) { throw null; }
        public bool IsField { get { throw null; } }
        public System.Reflection.MemberInfo MemberInfo { get { throw null; } }
        public string MemberName { get { throw null; } }
        public System.Reflection.CustomAttributeTypedArgument TypedValue { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Reflection.CustomAttributeNamedArgument left, System.Reflection.CustomAttributeNamedArgument right) { throw null; }
        public static bool operator !=(System.Reflection.CustomAttributeNamedArgument left, System.Reflection.CustomAttributeNamedArgument right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial struct CustomAttributeTypedArgument
    {
        private object _dummy;
        public CustomAttributeTypedArgument(object value) { throw null; }
        public CustomAttributeTypedArgument(System.Type argumentType, object value) { throw null; }
        public System.Type ArgumentType { get { throw null; } }
        public object Value { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Reflection.CustomAttributeTypedArgument left, System.Reflection.CustomAttributeTypedArgument right) { throw null; }
        public static bool operator !=(System.Reflection.CustomAttributeTypedArgument left, System.Reflection.CustomAttributeTypedArgument right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Interface | System.AttributeTargets.Struct)]
    public sealed partial class DefaultMemberAttribute : System.Attribute
    {
        public DefaultMemberAttribute(string memberName) { }
        public string MemberName { get { throw null; } }
    }
    public abstract partial class DispatchProxy
    {
        protected DispatchProxy() { }
        public static T Create<T, TProxy>() where TProxy : System.Reflection.DispatchProxy { throw null; }
        protected abstract object Invoke(System.Reflection.MethodInfo targetMethod, object[] args);
    }
    [System.FlagsAttribute]
    public enum EventAttributes
    {
        None = 0,
        ReservedMask = 1024,
        RTSpecialName = 1024,
        SpecialName = 512,
    }
    public abstract partial class EventInfo : System.Reflection.MemberInfo
    {
        protected EventInfo() { }
        public virtual System.Reflection.MethodInfo AddMethod { get { throw null; } }
        public abstract System.Reflection.EventAttributes Attributes { get; }
        public virtual System.Type EventHandlerType { get { throw null; } }
        public virtual bool IsMulticast { get { throw null; } }
        public bool IsSpecialName { get { throw null; } }
        public override System.Reflection.MemberTypes MemberType { get { throw null; } }
        public virtual System.Reflection.MethodInfo RaiseMethod { get { throw null; } }
        public virtual System.Reflection.MethodInfo RemoveMethod { get { throw null; } }
        public virtual void AddEventHandler(object target, System.Delegate handler) { }
        public override bool Equals(object obj) { throw null; }
        public System.Reflection.MethodInfo GetAddMethod() { throw null; }
        public abstract System.Reflection.MethodInfo GetAddMethod(bool nonPublic);
        public override int GetHashCode() { throw null; }
        public System.Reflection.MethodInfo[] GetOtherMethods() { throw null; }
        public virtual System.Reflection.MethodInfo[] GetOtherMethods(bool nonPublic) { throw null; }
        public System.Reflection.MethodInfo GetRaiseMethod() { throw null; }
        public abstract System.Reflection.MethodInfo GetRaiseMethod(bool nonPublic);
        public System.Reflection.MethodInfo GetRemoveMethod() { throw null; }
        public abstract System.Reflection.MethodInfo GetRemoveMethod(bool nonPublic);
        public static bool operator ==(System.Reflection.EventInfo left, System.Reflection.EventInfo right) { throw null; }
        public static bool operator !=(System.Reflection.EventInfo left, System.Reflection.EventInfo right) { throw null; }
        public virtual void RemoveEventHandler(object target, System.Delegate handler) { }
    }
    public partial class ExceptionHandlingClause
    {
        protected ExceptionHandlingClause() { }
        public virtual System.Type CatchType { get { throw null; } }
        public virtual int FilterOffset { get { throw null; } }
        public virtual System.Reflection.ExceptionHandlingClauseOptions Flags { get { throw null; } }
        public virtual int HandlerLength { get { throw null; } }
        public virtual int HandlerOffset { get { throw null; } }
        public virtual int TryLength { get { throw null; } }
        public virtual int TryOffset { get { throw null; } }
        public override string ToString() { throw null; }
    }
    [System.FlagsAttribute]
    public enum ExceptionHandlingClauseOptions
    {
        Clause = 0,
        Fault = 4,
        Filter = 1,
        Finally = 2,
    }
    [System.FlagsAttribute]
    public enum FieldAttributes
    {
        Assembly = 3,
        FamANDAssem = 2,
        Family = 4,
        FamORAssem = 5,
        FieldAccessMask = 7,
        HasDefault = 32768,
        HasFieldMarshal = 4096,
        HasFieldRVA = 256,
        InitOnly = 32,
        Literal = 64,
        NotSerialized = 128,
        PinvokeImpl = 8192,
        Private = 1,
        PrivateScope = 0,
        Public = 6,
        ReservedMask = 38144,
        RTSpecialName = 1024,
        SpecialName = 512,
        Static = 16,
    }
    public abstract partial class FieldInfo : System.Reflection.MemberInfo
    {
        protected FieldInfo() { }
        public abstract System.Reflection.FieldAttributes Attributes { get; }
        public abstract System.RuntimeFieldHandle FieldHandle { get; }
        public abstract System.Type FieldType { get; }
        public bool IsAssembly { get { throw null; } }
        public bool IsFamily { get { throw null; } }
        public bool IsFamilyAndAssembly { get { throw null; } }
        public bool IsFamilyOrAssembly { get { throw null; } }
        public bool IsInitOnly { get { throw null; } }
        public bool IsLiteral { get { throw null; } }
        public bool IsNotSerialized { get { throw null; } }
        public bool IsPinvokeImpl { get { throw null; } }
        public bool IsPrivate { get { throw null; } }
        public bool IsPublic { get { throw null; } }
        public virtual bool IsSecurityCritical { get { throw null; } }
        public virtual bool IsSecuritySafeCritical { get { throw null; } }
        public virtual bool IsSecurityTransparent { get { throw null; } }
        public bool IsSpecialName { get { throw null; } }
        public bool IsStatic { get { throw null; } }
        public override System.Reflection.MemberTypes MemberType { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public static System.Reflection.FieldInfo GetFieldFromHandle(System.RuntimeFieldHandle handle) { throw null; }
        public static System.Reflection.FieldInfo GetFieldFromHandle(System.RuntimeFieldHandle handle, System.RuntimeTypeHandle declaringType) { throw null; }
        public override int GetHashCode() { throw null; }
        public virtual System.Type[] GetOptionalCustomModifiers() { throw null; }
        public virtual object GetRawConstantValue() { throw null; }
        public virtual System.Type[] GetRequiredCustomModifiers() { throw null; }
        public abstract object GetValue(object obj);
        [System.CLSCompliantAttribute(false)]
        public virtual object GetValueDirect(System.TypedReference obj) { throw null; }
        public static bool operator ==(System.Reflection.FieldInfo left, System.Reflection.FieldInfo right) { throw null; }
        public static bool operator !=(System.Reflection.FieldInfo left, System.Reflection.FieldInfo right) { throw null; }
        public void SetValue(object obj, object value) { }
        public abstract void SetValue(object obj, object value, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, System.Globalization.CultureInfo culture);
        [System.CLSCompliantAttribute(false)]
        public virtual void SetValueDirect(System.TypedReference obj, object value) { }
    }
    [System.FlagsAttribute]
    public enum GenericParameterAttributes
    {
        Contravariant = 2,
        Covariant = 1,
        DefaultConstructorConstraint = 16,
        None = 0,
        NotNullableValueTypeConstraint = 8,
        ReferenceTypeConstraint = 4,
        SpecialConstraintMask = 28,
        VarianceMask = 3,
    }
    public partial interface ICustomAttributeProvider
    {
        object[] GetCustomAttributes(bool inherit);
        object[] GetCustomAttributes(System.Type attributeType, bool inherit);
        bool IsDefined(System.Type attributeType, bool inherit);
    }
    public enum ImageFileMachine
    {
        AMD64 = 34404,
        ARM = 452,
        I386 = 332,
        IA64 = 512,
    }
    public partial struct InterfaceMapping
    {
        public System.Reflection.MethodInfo[] InterfaceMethods;
        public System.Type InterfaceType;
        public System.Reflection.MethodInfo[] TargetMethods;
        public System.Type TargetType;
    }
    public static partial class IntrospectionExtensions
    {
        public static System.Reflection.TypeInfo GetTypeInfo(this System.Type type) { throw null; }
    }
    public partial class InvalidFilterCriteriaException : System.ApplicationException
    {
        public InvalidFilterCriteriaException() { }
        protected InvalidFilterCriteriaException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public InvalidFilterCriteriaException(string message) { }
        public InvalidFilterCriteriaException(string message, System.Exception inner) { }
    }
    public partial interface IReflect
    {
        System.Type UnderlyingSystemType { get; }
        System.Reflection.FieldInfo GetField(string name, System.Reflection.BindingFlags bindingAttr);
        System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags bindingAttr);
        System.Reflection.MemberInfo[] GetMember(string name, System.Reflection.BindingFlags bindingAttr);
        System.Reflection.MemberInfo[] GetMembers(System.Reflection.BindingFlags bindingAttr);
        System.Reflection.MethodInfo GetMethod(string name, System.Reflection.BindingFlags bindingAttr);
        System.Reflection.MethodInfo GetMethod(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Type[] types, System.Reflection.ParameterModifier[] modifiers);
        System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags bindingAttr);
        System.Reflection.PropertyInfo[] GetProperties(System.Reflection.BindingFlags bindingAttr);
        System.Reflection.PropertyInfo GetProperty(string name, System.Reflection.BindingFlags bindingAttr);
        System.Reflection.PropertyInfo GetProperty(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Type returnType, System.Type[] types, System.Reflection.ParameterModifier[] modifiers);
        object InvokeMember(string name, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object target, object[] args, System.Reflection.ParameterModifier[] modifiers, System.Globalization.CultureInfo culture, string[] namedParameters);
    }
    public partial interface IReflectableType
    {
        System.Reflection.TypeInfo GetTypeInfo();
    }
    public partial class LocalVariableInfo
    {
        protected LocalVariableInfo() { }
        public virtual bool IsPinned { get { throw null; } }
        public virtual int LocalIndex { get { throw null; } }
        public virtual System.Type LocalType { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public partial class ManifestResourceInfo
    {
        public ManifestResourceInfo(System.Reflection.Assembly containingAssembly, string containingFileName, System.Reflection.ResourceLocation resourceLocation) { }
        public virtual string FileName { get { throw null; } }
        public virtual System.Reflection.Assembly ReferencedAssembly { get { throw null; } }
        public virtual System.Reflection.ResourceLocation ResourceLocation { get { throw null; } }
    }
    public delegate bool MemberFilter(System.Reflection.MemberInfo m, object filterCriteria);
    public abstract partial class MemberInfo : System.Reflection.ICustomAttributeProvider
    {
        protected MemberInfo() { }
        public virtual System.Collections.Generic.IEnumerable<System.Reflection.CustomAttributeData> CustomAttributes { get { throw null; } }
        public abstract System.Type DeclaringType { get; }
        public abstract System.Reflection.MemberTypes MemberType { get; }
        public virtual int MetadataToken { get { throw null; } }
        public virtual System.Reflection.Module Module { get { throw null; } }
        public abstract string Name { get; }
        public abstract System.Type ReflectedType { get; }
        public override bool Equals(object obj) { throw null; }
        public abstract object[] GetCustomAttributes(bool inherit);
        public abstract object[] GetCustomAttributes(System.Type attributeType, bool inherit);
        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData() { throw null; }
        public override int GetHashCode() { throw null; }
        public virtual bool HasSameMetadataDefinitionAs(System.Reflection.MemberInfo other) { throw null; }
        public abstract bool IsDefined(System.Type attributeType, bool inherit);
        public static bool operator ==(System.Reflection.MemberInfo left, System.Reflection.MemberInfo right) { throw null; }
        public static bool operator !=(System.Reflection.MemberInfo left, System.Reflection.MemberInfo right) { throw null; }
    }
    [System.FlagsAttribute]
    public enum MemberTypes
    {
        All = 191,
        Constructor = 1,
        Custom = 64,
        Event = 2,
        Field = 4,
        Method = 8,
        NestedType = 128,
        Property = 16,
        TypeInfo = 32,
    }
    [System.FlagsAttribute]
    public enum MethodAttributes
    {
        Abstract = 1024,
        Assembly = 3,
        CheckAccessOnOverride = 512,
        FamANDAssem = 2,
        Family = 4,
        FamORAssem = 5,
        Final = 32,
        HasSecurity = 16384,
        HideBySig = 128,
        MemberAccessMask = 7,
        NewSlot = 256,
        PinvokeImpl = 8192,
        Private = 1,
        PrivateScope = 0,
        Public = 6,
        RequireSecObject = 32768,
        ReservedMask = 53248,
        ReuseSlot = 0,
        RTSpecialName = 4096,
        SpecialName = 2048,
        Static = 16,
        UnmanagedExport = 8,
        Virtual = 64,
        VtableLayoutMask = 256,
    }
    public abstract partial class MethodBase : System.Reflection.MemberInfo
    {
        protected MethodBase() { }
        public abstract System.Reflection.MethodAttributes Attributes { get; }
        public virtual System.Reflection.CallingConventions CallingConvention { get { throw null; } }
        public virtual bool ContainsGenericParameters { get { throw null; } }
        public bool IsAbstract { get { throw null; } }
        public bool IsAssembly { get { throw null; } }
        public virtual bool IsConstructedGenericMethod { get { throw null; } }
        public bool IsConstructor { get { throw null; } }
        public bool IsFamily { get { throw null; } }
        public bool IsFamilyAndAssembly { get { throw null; } }
        public bool IsFamilyOrAssembly { get { throw null; } }
        public bool IsFinal { get { throw null; } }
        public virtual bool IsGenericMethod { get { throw null; } }
        public virtual bool IsGenericMethodDefinition { get { throw null; } }
        public bool IsHideBySig { get { throw null; } }
        public bool IsPrivate { get { throw null; } }
        public bool IsPublic { get { throw null; } }
        public virtual bool IsSecurityCritical { get { throw null; } }
        public virtual bool IsSecuritySafeCritical { get { throw null; } }
        public virtual bool IsSecurityTransparent { get { throw null; } }
        public bool IsSpecialName { get { throw null; } }
        public bool IsStatic { get { throw null; } }
        public bool IsVirtual { get { throw null; } }
        public abstract System.RuntimeMethodHandle MethodHandle { get; }
        public virtual System.Reflection.MethodImplAttributes MethodImplementationFlags { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public static System.Reflection.MethodBase GetCurrentMethod() { throw null; }
        public virtual System.Type[] GetGenericArguments() { throw null; }
        public override int GetHashCode() { throw null; }
        public virtual System.Reflection.MethodBody GetMethodBody() { throw null; }
        public static System.Reflection.MethodBase GetMethodFromHandle(System.RuntimeMethodHandle handle) { throw null; }
        public static System.Reflection.MethodBase GetMethodFromHandle(System.RuntimeMethodHandle handle, System.RuntimeTypeHandle declaringType) { throw null; }
        public abstract System.Reflection.MethodImplAttributes GetMethodImplementationFlags();
        public abstract System.Reflection.ParameterInfo[] GetParameters();
        public object Invoke(object obj, object[] parameters) { throw null; }
        public abstract object Invoke(object obj, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] parameters, System.Globalization.CultureInfo culture);
        public static bool operator ==(System.Reflection.MethodBase left, System.Reflection.MethodBase right) { throw null; }
        public static bool operator !=(System.Reflection.MethodBase left, System.Reflection.MethodBase right) { throw null; }
    }
    public partial class MethodBody
    {
        protected MethodBody() { }
        public virtual System.Collections.Generic.IList<System.Reflection.ExceptionHandlingClause> ExceptionHandlingClauses { get { throw null; } }
        public virtual bool InitLocals { get { throw null; } }
        public virtual int LocalSignatureMetadataToken { get { throw null; } }
        public virtual System.Collections.Generic.IList<System.Reflection.LocalVariableInfo> LocalVariables { get { throw null; } }
        public virtual int MaxStackSize { get { throw null; } }
        public virtual byte[] GetILAsByteArray() { throw null; }
    }
    public enum MethodImplAttributes
    {
        AggressiveInlining = 256,
        CodeTypeMask = 3,
        ForwardRef = 16,
        IL = 0,
        InternalCall = 4096,
        Managed = 0,
        ManagedMask = 4,
        MaxMethodImplVal = 65535,
        Native = 1,
        NoInlining = 8,
        NoOptimization = 64,
        OPTIL = 2,
        PreserveSig = 128,
        Runtime = 3,
        Synchronized = 32,
        Unmanaged = 4,
    }
    public abstract partial class MethodInfo : System.Reflection.MethodBase
    {
        protected MethodInfo() { }
        public override System.Reflection.MemberTypes MemberType { get { throw null; } }
        public virtual System.Reflection.ParameterInfo ReturnParameter { get { throw null; } }
        public virtual System.Type ReturnType { get { throw null; } }
        public abstract System.Reflection.ICustomAttributeProvider ReturnTypeCustomAttributes { get; }
        public virtual System.Delegate CreateDelegate(System.Type delegateType) { throw null; }
        public virtual System.Delegate CreateDelegate(System.Type delegateType, object target) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public abstract System.Reflection.MethodInfo GetBaseDefinition();
        public override System.Type[] GetGenericArguments() { throw null; }
        public virtual System.Reflection.MethodInfo GetGenericMethodDefinition() { throw null; }
        public override int GetHashCode() { throw null; }
        public virtual System.Reflection.MethodInfo MakeGenericMethod(params System.Type[] typeArguments) { throw null; }
        public static bool operator ==(System.Reflection.MethodInfo left, System.Reflection.MethodInfo right) { throw null; }
        public static bool operator !=(System.Reflection.MethodInfo left, System.Reflection.MethodInfo right) { throw null; }
    }
    public sealed partial class Missing : System.Runtime.Serialization.ISerializable
    {
        internal Missing() { }
        public static readonly System.Reflection.Missing Value;
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public abstract partial class Module : System.Reflection.ICustomAttributeProvider, System.Runtime.Serialization.ISerializable
    {
        public static readonly System.Reflection.TypeFilter FilterTypeName;
        public static readonly System.Reflection.TypeFilter FilterTypeNameIgnoreCase;
        protected Module() { }
        public virtual System.Reflection.Assembly Assembly { get { throw null; } }
        public virtual System.Collections.Generic.IEnumerable<System.Reflection.CustomAttributeData> CustomAttributes { get { throw null; } }
        public virtual string FullyQualifiedName { get { throw null; } }
        public virtual int MDStreamVersion { get { throw null; } }
        public virtual int MetadataToken { get { throw null; } }
        public System.ModuleHandle ModuleHandle { get { throw null; } }
        public virtual System.Guid ModuleVersionId { get { throw null; } }
        public virtual string Name { get { throw null; } }
        public virtual string ScopeName { get { throw null; } }
        public override bool Equals(object o) { throw null; }
        public virtual System.Type[] FindTypes(System.Reflection.TypeFilter filter, object filterCriteria) { throw null; }
        public virtual object[] GetCustomAttributes(bool inherit) { throw null; }
        public virtual object[] GetCustomAttributes(System.Type attributeType, bool inherit) { throw null; }
        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData() { throw null; }
        public System.Reflection.FieldInfo GetField(string name) { throw null; }
        public virtual System.Reflection.FieldInfo GetField(string name, System.Reflection.BindingFlags bindingAttr) { throw null; }
        public System.Reflection.FieldInfo[] GetFields() { throw null; }
        public virtual System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags bindingFlags) { throw null; }
        public override int GetHashCode() { throw null; }
        public System.Reflection.MethodInfo GetMethod(string name) { throw null; }
        public System.Reflection.MethodInfo GetMethod(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { throw null; }
        public System.Reflection.MethodInfo GetMethod(string name, System.Type[] types) { throw null; }
        protected virtual System.Reflection.MethodInfo GetMethodImpl(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { throw null; }
        public System.Reflection.MethodInfo[] GetMethods() { throw null; }
        public virtual System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags bindingFlags) { throw null; }
        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public virtual void GetPEKind(out System.Reflection.PortableExecutableKinds peKind, out System.Reflection.ImageFileMachine machine) { throw null; }
//      We've excluded GetSignerCertificate() for the following reasons:
//          * It pulls in crypto, which isn't in corlib in .NET Core
//          * It's unclear how this API would work if the module has multiple certs
//          * It seems like a fringe scenario. If there are use cases for extracting Authenticode signatures from modules,
//            it should probably be part of System.Reflection.Metadata and return raw blobs. The consumer can feed it to
//            crypto cert APIs (e.g. as a byte array), which would avoid the layering issue.
//      public virtual System.Security.Cryptography.X509Certificates.X509Certificate GetSignerCertificate() { throw null; }
        public virtual System.Type GetType(string className) { throw null; }
        public virtual System.Type GetType(string className, bool ignoreCase) { throw null; }
        public virtual System.Type GetType(string className, bool throwOnError, bool ignoreCase) { throw null; }
        public virtual System.Type[] GetTypes() { throw null; }
        public virtual bool IsDefined(System.Type attributeType, bool inherit) { throw null; }
        public virtual bool IsResource() { throw null; }
        public static bool operator ==(System.Reflection.Module left, System.Reflection.Module right) { throw null; }
        public static bool operator !=(System.Reflection.Module left, System.Reflection.Module right) { throw null; }
        public System.Reflection.FieldInfo ResolveField(int metadataToken) { throw null; }
        public virtual System.Reflection.FieldInfo ResolveField(int metadataToken, System.Type[] genericTypeArguments, System.Type[] genericMethodArguments) { throw null; }
        public System.Reflection.MemberInfo ResolveMember(int metadataToken) { throw null; }
        public virtual System.Reflection.MemberInfo ResolveMember(int metadataToken, System.Type[] genericTypeArguments, System.Type[] genericMethodArguments) { throw null; }
        public System.Reflection.MethodBase ResolveMethod(int metadataToken) { throw null; }
        public virtual System.Reflection.MethodBase ResolveMethod(int metadataToken, System.Type[] genericTypeArguments, System.Type[] genericMethodArguments) { throw null; }
        public virtual byte[] ResolveSignature(int metadataToken) { throw null; }
        public virtual string ResolveString(int metadataToken) { throw null; }
        public System.Type ResolveType(int metadataToken) { throw null; }
        public virtual System.Type ResolveType(int metadataToken, System.Type[] genericTypeArguments, System.Type[] genericMethodArguments) { throw null; }
        public override string ToString() { throw null; }
    }
    public delegate System.Reflection.Module ModuleResolveEventHandler(object sender, System.ResolveEventArgs e);
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, AllowMultiple=false, Inherited=false)]
    public sealed partial class ObfuscateAssemblyAttribute : System.Attribute
    {
        public ObfuscateAssemblyAttribute(bool assemblyIsPrivate) { }
        public bool AssemblyIsPrivate { get { throw null; } }
        public bool StripAfterObfuscation { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.Class | System.AttributeTargets.Delegate | System.AttributeTargets.Enum | System.AttributeTargets.Event | System.AttributeTargets.Field | System.AttributeTargets.Interface | System.AttributeTargets.Method | System.AttributeTargets.Parameter | System.AttributeTargets.Property | System.AttributeTargets.Struct, AllowMultiple=true, Inherited=false)]
    public sealed partial class ObfuscationAttribute : System.Attribute
    {
        public ObfuscationAttribute() { }
        public bool ApplyToMembers { get { throw null; } set { } }
        public bool Exclude { get { throw null; } set { } }
        public string Feature { get { throw null; } set { } }
        public bool StripAfterObfuscation { get { throw null; } set { } }
    }
    [System.FlagsAttribute]
    public enum ParameterAttributes
    {
        HasDefault = 4096,
        HasFieldMarshal = 8192,
        In = 1,
        Lcid = 4,
        None = 0,
        Optional = 16,
        Out = 2,
        Reserved3 = 16384,
        Reserved4 = 32768,
        ReservedMask = 61440,
        Retval = 8,
    }
    public partial class ParameterInfo : System.Reflection.ICustomAttributeProvider, System.Runtime.Serialization.IObjectReference
    {
        protected System.Reflection.ParameterAttributes AttrsImpl;
        protected System.Type ClassImpl;
        protected object DefaultValueImpl;
        protected System.Reflection.MemberInfo MemberImpl;
        protected string NameImpl;
        protected int PositionImpl;
        protected ParameterInfo() { }
        public virtual System.Reflection.ParameterAttributes Attributes { get { throw null; } }
        public virtual System.Collections.Generic.IEnumerable<System.Reflection.CustomAttributeData> CustomAttributes { get { throw null; } }
        public virtual object DefaultValue { get { throw null; } }
        public virtual bool HasDefaultValue { get { throw null; } }
        public bool IsIn { get { throw null; } }
        public bool IsLcid { get { throw null; } }
        public bool IsOptional { get { throw null; } }
        public bool IsOut { get { throw null; } }
        public bool IsRetval { get { throw null; } }
        public virtual System.Reflection.MemberInfo Member { get { throw null; } }
        public virtual int MetadataToken { get { throw null; } }
        public virtual string Name { get { throw null; } }
        public virtual System.Type ParameterType { get { throw null; } }
        public virtual int Position { get { throw null; } }
        public virtual object RawDefaultValue { get { throw null; } }
        public virtual object[] GetCustomAttributes(bool inherit) { throw null; }
        public virtual object[] GetCustomAttributes(System.Type attributeType, bool inherit) { throw null; }
        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData() { throw null; }
        public virtual System.Type[] GetOptionalCustomModifiers() { throw null; }
        public object GetRealObject(System.Runtime.Serialization.StreamingContext context) { throw null; }
        public virtual System.Type[] GetRequiredCustomModifiers() { throw null; }
        public virtual bool IsDefined(System.Type attributeType, bool inherit) { throw null; }
        public override string ToString() { throw null; }
    }
    public readonly partial struct ParameterModifier
    {
        private readonly object _dummy;
        public ParameterModifier(int parameterCount) { throw null; }
        public bool this[int index] { get { throw null; } set { } }
    }
    [System.CLSCompliantAttribute(false)]
    public sealed partial class Pointer : System.Runtime.Serialization.ISerializable
    {
        internal Pointer() { }
        public unsafe static object Box(void* ptr, System.Type type) { throw null; }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public unsafe static void* Unbox(object ptr) { throw null; }
    }
    [System.FlagsAttribute]
    public enum PortableExecutableKinds
    {
        ILOnly = 1,
        NotAPortableExecutableImage = 0,
        PE32Plus = 4,
        Preferred32Bit = 16,
        Required32Bit = 2,
        Unmanaged32Bit = 8,
    }
    public enum ProcessorArchitecture
    {
        Amd64 = 4,
        Arm = 5,
        IA64 = 3,
        MSIL = 1,
        None = 0,
        X86 = 2,
    }
    [System.FlagsAttribute]
    public enum PropertyAttributes
    {
        HasDefault = 4096,
        None = 0,
        Reserved2 = 8192,
        Reserved3 = 16384,
        Reserved4 = 32768,
        ReservedMask = 62464,
        RTSpecialName = 1024,
        SpecialName = 512,
    }
    public abstract partial class PropertyInfo : System.Reflection.MemberInfo
    {
        protected PropertyInfo() { }
        public abstract System.Reflection.PropertyAttributes Attributes { get; }
        public abstract bool CanRead { get; }
        public abstract bool CanWrite { get; }
        public virtual System.Reflection.MethodInfo GetMethod { get { throw null; } }
        public bool IsSpecialName { get { throw null; } }
        public override System.Reflection.MemberTypes MemberType { get { throw null; } }
        public abstract System.Type PropertyType { get; }
        public virtual System.Reflection.MethodInfo SetMethod { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public System.Reflection.MethodInfo[] GetAccessors() { throw null; }
        public abstract System.Reflection.MethodInfo[] GetAccessors(bool nonPublic);
        public virtual object GetConstantValue() { throw null; }
        public System.Reflection.MethodInfo GetGetMethod() { throw null; }
        public abstract System.Reflection.MethodInfo GetGetMethod(bool nonPublic);
        public override int GetHashCode() { throw null; }
        public abstract System.Reflection.ParameterInfo[] GetIndexParameters();
        public virtual System.Type[] GetOptionalCustomModifiers() { throw null; }
        public virtual object GetRawConstantValue() { throw null; }
        public virtual System.Type[] GetRequiredCustomModifiers() { throw null; }
        public System.Reflection.MethodInfo GetSetMethod() { throw null; }
        public abstract System.Reflection.MethodInfo GetSetMethod(bool nonPublic);
        public object GetValue(object obj) { throw null; }
        public virtual object GetValue(object obj, object[] index) { throw null; }
        public abstract object GetValue(object obj, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] index, System.Globalization.CultureInfo culture);
        public static bool operator ==(System.Reflection.PropertyInfo left, System.Reflection.PropertyInfo right) { throw null; }
        public static bool operator !=(System.Reflection.PropertyInfo left, System.Reflection.PropertyInfo right) { throw null; }
        public void SetValue(object obj, object value) { }
        public virtual void SetValue(object obj, object value, object[] index) { }
        public abstract void SetValue(object obj, object value, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] index, System.Globalization.CultureInfo culture);
    }
    public abstract partial class ReflectionContext
    {
        protected ReflectionContext() { }
        public virtual System.Reflection.TypeInfo GetTypeForObject(object value) { throw null; }
        public abstract System.Reflection.Assembly MapAssembly(System.Reflection.Assembly assembly);
        public abstract System.Reflection.TypeInfo MapType(System.Reflection.TypeInfo type);
    }
    public sealed partial class ReflectionTypeLoadException : System.SystemException, System.Runtime.Serialization.ISerializable
    {
        public ReflectionTypeLoadException(System.Type[] classes, System.Exception[] exceptions) { }
        public ReflectionTypeLoadException(System.Type[] classes, System.Exception[] exceptions, string message) { }
        public System.Exception[] LoaderExceptions { get { throw null; } }
        public System.Type[] Types { get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    [System.FlagsAttribute]
    public enum ResourceAttributes
    {
        Private = 2,
        Public = 1,
    }
    [System.FlagsAttribute]
    public enum ResourceLocation
    {
        ContainedInAnotherAssembly = 2,
        ContainedInManifestFile = 4,
        Embedded = 1,
    }
    public static partial class RuntimeReflectionExtensions
    {
        public static System.Reflection.MethodInfo GetMethodInfo(this System.Delegate del) { throw null; }
        public static System.Reflection.MethodInfo GetRuntimeBaseDefinition(this System.Reflection.MethodInfo method) { throw null; }
        public static System.Reflection.EventInfo GetRuntimeEvent(this System.Type type, string name) { throw null; }
        public static System.Collections.Generic.IEnumerable<System.Reflection.EventInfo> GetRuntimeEvents(this System.Type type) { throw null; }
        public static System.Reflection.FieldInfo GetRuntimeField(this System.Type type, string name) { throw null; }
        public static System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo> GetRuntimeFields(this System.Type type) { throw null; }
        public static System.Reflection.InterfaceMapping GetRuntimeInterfaceMap(this System.Reflection.TypeInfo typeInfo, System.Type interfaceType) { throw null; }
        public static System.Reflection.MethodInfo GetRuntimeMethod(this System.Type type, string name, System.Type[] parameters) { throw null; }
        public static System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo> GetRuntimeMethods(this System.Type type) { throw null; }
        public static System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo> GetRuntimeProperties(this System.Type type) { throw null; }
        public static System.Reflection.PropertyInfo GetRuntimeProperty(this System.Type type, string name) { throw null; }
    }
    public partial class StrongNameKeyPair : System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable
    {
        public StrongNameKeyPair(byte[] keyPairArray) { }
        public StrongNameKeyPair(System.IO.FileStream keyPairFile) { }
        protected StrongNameKeyPair(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public StrongNameKeyPair(string keyPairContainer) { }
        public byte[] PublicKey { get { throw null; } }
        void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public partial class TargetException : System.ApplicationException
    {
        public TargetException() { }
        protected TargetException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public TargetException(string message) { }
        public TargetException(string message, System.Exception inner) { }
    }
    public sealed partial class TargetInvocationException : System.ApplicationException
    {
        public TargetInvocationException(System.Exception inner) { }
        public TargetInvocationException(string message, System.Exception inner) { }
    }
    public sealed partial class TargetParameterCountException : System.ApplicationException
    {
        public TargetParameterCountException() { }
        public TargetParameterCountException(string message) { }
        public TargetParameterCountException(string message, System.Exception inner) { }
    }
    [System.FlagsAttribute]
    public enum TypeAttributes
    {
        Abstract = 128,
        AnsiClass = 0,
        AutoClass = 131072,
        AutoLayout = 0,
        BeforeFieldInit = 1048576,
        Class = 0,
        ClassSemanticsMask = 32,
        CustomFormatClass = 196608,
        CustomFormatMask = 12582912,
        ExplicitLayout = 16,
        HasSecurity = 262144,
        Import = 4096,
        Interface = 32,
        LayoutMask = 24,
        NestedAssembly = 5,
        NestedFamANDAssem = 6,
        NestedFamily = 4,
        NestedFamORAssem = 7,
        NestedPrivate = 3,
        NestedPublic = 2,
        NotPublic = 0,
        Public = 1,
        ReservedMask = 264192,
        RTSpecialName = 2048,
        Sealed = 256,
        SequentialLayout = 8,
        Serializable = 8192,
        SpecialName = 1024,
        StringFormatMask = 196608,
        UnicodeClass = 65536,
        VisibilityMask = 7,
        WindowsRuntime = 16384,
    }
    public partial class TypeDelegator : System.Reflection.TypeInfo
    {
        protected System.Type typeImpl;
        protected TypeDelegator() { }
        public TypeDelegator(System.Type delegatingType) { }
        public override System.Reflection.Assembly Assembly { get { throw null; } }
        public override string AssemblyQualifiedName { get { throw null; } }
        public override System.Type BaseType { get { throw null; } }
        public override string FullName { get { throw null; } }
        public override System.Guid GUID { get { throw null; } }
        public override bool IsByRefLike { get { throw null; } }
        public override bool IsConstructedGenericType { get { throw null; } }
        public override bool IsGenericMethodParameter { get { throw null; } }
        public override bool IsGenericTypeParameter { get { throw null; } }
        public override bool IsSZArray { get { throw null; } }
        public override bool IsTypeDefinition { get { throw null; } }
        public override bool IsVariableBoundArray { get { throw null; } }
        public override int MetadataToken { get { throw null; } }
        public override System.Reflection.Module Module { get { throw null; } }
        public override string Name { get { throw null; } }
        public override string Namespace { get { throw null; } }
        public override System.RuntimeTypeHandle TypeHandle { get { throw null; } }
        public override System.Type UnderlyingSystemType { get { throw null; } }
        protected override System.Reflection.TypeAttributes GetAttributeFlagsImpl() { throw null; }
        protected override System.Reflection.ConstructorInfo GetConstructorImpl(System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { throw null; }
        public override System.Reflection.ConstructorInfo[] GetConstructors(System.Reflection.BindingFlags bindingAttr) { throw null; }
        public override object[] GetCustomAttributes(bool inherit) { throw null; }
        public override object[] GetCustomAttributes(System.Type attributeType, bool inherit) { throw null; }
        public override System.Type GetElementType() { throw null; }
        public override System.Reflection.EventInfo GetEvent(string name, System.Reflection.BindingFlags bindingAttr) { throw null; }
        public override System.Reflection.EventInfo[] GetEvents() { throw null; }
        public override System.Reflection.EventInfo[] GetEvents(System.Reflection.BindingFlags bindingAttr) { throw null; }
        public override System.Reflection.FieldInfo GetField(string name, System.Reflection.BindingFlags bindingAttr) { throw null; }
        public override System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags bindingAttr) { throw null; }
        public override System.Type GetInterface(string name, bool ignoreCase) { throw null; }
        public override System.Reflection.InterfaceMapping GetInterfaceMap(System.Type interfaceType) { throw null; }
        public override System.Type[] GetInterfaces() { throw null; }
        public override System.Reflection.MemberInfo[] GetMember(string name, System.Reflection.MemberTypes type, System.Reflection.BindingFlags bindingAttr) { throw null; }
        public override System.Reflection.MemberInfo[] GetMembers(System.Reflection.BindingFlags bindingAttr) { throw null; }
        protected override System.Reflection.MethodInfo GetMethodImpl(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { throw null; }
        public override System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags bindingAttr) { throw null; }
        public override System.Type GetNestedType(string name, System.Reflection.BindingFlags bindingAttr) { throw null; }
        public override System.Type[] GetNestedTypes(System.Reflection.BindingFlags bindingAttr) { throw null; }
        public override System.Reflection.PropertyInfo[] GetProperties(System.Reflection.BindingFlags bindingAttr) { throw null; }
        protected override System.Reflection.PropertyInfo GetPropertyImpl(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Type returnType, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { throw null; }
        protected override bool HasElementTypeImpl() { throw null; }
        public override object InvokeMember(string name, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object target, object[] args, System.Reflection.ParameterModifier[] modifiers, System.Globalization.CultureInfo culture, string[] namedParameters) { throw null; }
        protected override bool IsArrayImpl() { throw null; }
        public override bool IsAssignableFrom(System.Reflection.TypeInfo typeInfo) { throw null; }
        protected override bool IsByRefImpl() { throw null; }
        protected override bool IsCOMObjectImpl() { throw null; }
        public override bool IsDefined(System.Type attributeType, bool inherit) { throw null; }
        protected override bool IsPointerImpl() { throw null; }
        protected override bool IsPrimitiveImpl() { throw null; }
        protected override bool IsValueTypeImpl() { throw null; }
    }
    public delegate bool TypeFilter(System.Type m, object filterCriteria);
    public abstract partial class TypeInfo : System.Type, System.Reflection.IReflectableType
    {
        protected TypeInfo() { }
        public virtual System.Collections.Generic.IEnumerable<System.Reflection.ConstructorInfo> DeclaredConstructors { get { throw null; } }
        public virtual System.Collections.Generic.IEnumerable<System.Reflection.EventInfo> DeclaredEvents { get { throw null; } }
        public virtual System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo> DeclaredFields { get { throw null; } }
        public virtual System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> DeclaredMembers { get { throw null; } }
        public virtual System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo> DeclaredMethods { get { throw null; } }
        public virtual System.Collections.Generic.IEnumerable<System.Reflection.TypeInfo> DeclaredNestedTypes { get { throw null; } }
        public virtual System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo> DeclaredProperties { get { throw null; } }
        public virtual System.Type[] GenericTypeParameters { get { throw null; } }
        public virtual System.Collections.Generic.IEnumerable<System.Type> ImplementedInterfaces { get { throw null; } }
        public virtual System.Type AsType() { throw null; }
        public virtual System.Reflection.EventInfo GetDeclaredEvent(string name) { throw null; }
        public virtual System.Reflection.FieldInfo GetDeclaredField(string name) { throw null; }
        public virtual System.Reflection.MethodInfo GetDeclaredMethod(string name) { throw null; }
        public virtual System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo> GetDeclaredMethods(string name) { throw null; }
        public virtual System.Reflection.TypeInfo GetDeclaredNestedType(string name) { throw null; }
        public virtual System.Reflection.PropertyInfo GetDeclaredProperty(string name) { throw null; }
        public virtual bool IsAssignableFrom(System.Reflection.TypeInfo typeInfo) { throw null; }
        System.Reflection.TypeInfo System.Reflection.IReflectableType.GetTypeInfo() { throw null; }
    }
}
