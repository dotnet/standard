# System.Data.Linq.Mapping

``` diff
+namespace System.Data.Linq.Mapping {
+    public sealed class AssociationAttribute : DataAttribute {
+        public AssociationAttribute();
+        public bool DeleteOnNull { get; set; }
+        public string DeleteRule { get; set; }
+        public bool IsForeignKey { get; set; }
+        public bool IsUnique { get; set; }
+        public string OtherKey { get; set; }
+        public string ThisKey { get; set; }
+    }
+    public sealed class AttributeMappingSource : MappingSource {
+        public AttributeMappingSource();
+        protected override MetaModel CreateModel(Type dataContextType);
+    }
+    public enum AutoSync {
+        Always = 1,
+        Default = 0,
+        Never = 2,
+        OnInsert = 3,
+        OnUpdate = 4,
+    }
+    public sealed class ColumnAttribute : DataAttribute {
+        public ColumnAttribute();
+        public AutoSync AutoSync { get; set; }
+        public bool CanBeNull { get; set; }
+        public string DbType { get; set; }
+        public string Expression { get; set; }
+        public bool IsDbGenerated { get; set; }
+        public bool IsDiscriminator { get; set; }
+        public bool IsPrimaryKey { get; set; }
+        public bool IsVersion { get; set; }
+        public UpdateCheck UpdateCheck { get; set; }
+    }
+    public abstract class DataAttribute : Attribute {
+        protected DataAttribute();
+        public string Name { get; set; }
+        public string Storage { get; set; }
+    }
+    public sealed class DatabaseAttribute : Attribute {
+        public DatabaseAttribute();
+        public string Name { get; set; }
+    }
+    public sealed class FunctionAttribute : Attribute {
+        public FunctionAttribute();
+        public bool IsComposable { get; set; }
+        public string Name { get; set; }
+    }
+    public sealed class InheritanceMappingAttribute : Attribute {
+        public InheritanceMappingAttribute();
+        public object Code { get; set; }
+        public bool IsDefault { get; set; }
+        public Type Type { get; set; }
+    }
+    public abstract class MappingSource {
+        protected MappingSource();
+        protected abstract MetaModel CreateModel(Type dataContextType);
+        public MetaModel GetModel(Type dataContextType);
+    }
+    public abstract class MetaAccessor {
+        protected MetaAccessor();
+        public abstract Type Type { get; }
+        public abstract object GetBoxedValue(object instance);
+        public virtual bool HasAssignedValue(object instance);
+        public virtual bool HasLoadedValue(object instance);
+        public virtual bool HasValue(object instance);
+        public abstract void SetBoxedValue(ref object instance, object value);
+    }
+    public abstract class MetaAccessor<TEntity, TMember> : MetaAccessor {
+        protected MetaAccessor();
+        public override Type Type { get; }
+        public override object GetBoxedValue(object instance);
+        public abstract TMember GetValue(TEntity instance);
+        public override void SetBoxedValue(ref object instance, object value);
+        public abstract void SetValue(ref TEntity instance, TMember value);
+    }
+    public abstract class MetaAssociation {
+        protected MetaAssociation();
+        public abstract bool DeleteOnNull { get; }
+        public abstract string DeleteRule { get; }
+        public abstract bool IsForeignKey { get; }
+        public abstract bool IsMany { get; }
+        public abstract bool IsNullable { get; }
+        public abstract bool IsUnique { get; }
+        public abstract ReadOnlyCollection<MetaDataMember> OtherKey { get; }
+        public abstract bool OtherKeyIsPrimaryKey { get; }
+        public abstract MetaDataMember OtherMember { get; }
+        public abstract MetaType OtherType { get; }
+        public abstract ReadOnlyCollection<MetaDataMember> ThisKey { get; }
+        public abstract bool ThisKeyIsPrimaryKey { get; }
+        public abstract MetaDataMember ThisMember { get; }
+    }
+    public abstract class MetaDataMember {
+        protected MetaDataMember();
+        public abstract MetaAssociation Association { get; }
+        public abstract AutoSync AutoSync { get; }
+        public abstract bool CanBeNull { get; }
+        public abstract string DbType { get; }
+        public abstract MetaType DeclaringType { get; }
+        public abstract MetaAccessor DeferredSourceAccessor { get; }
+        public abstract MetaAccessor DeferredValueAccessor { get; }
+        public abstract string Expression { get; }
+        public abstract bool IsAssociation { get; }
+        public abstract bool IsDbGenerated { get; }
+        public abstract bool IsDeferred { get; }
+        public abstract bool IsDiscriminator { get; }
+        public abstract bool IsPersistent { get; }
+        public abstract bool IsPrimaryKey { get; }
+        public abstract bool IsVersion { get; }
+        public abstract MethodInfo LoadMethod { get; }
+        public abstract string MappedName { get; }
+        public abstract MemberInfo Member { get; }
+        public abstract MetaAccessor MemberAccessor { get; }
+        public abstract string Name { get; }
+        public abstract int Ordinal { get; }
+        public abstract MetaAccessor StorageAccessor { get; }
+        public abstract MemberInfo StorageMember { get; }
+        public abstract Type Type { get; }
+        public abstract UpdateCheck UpdateCheck { get; }
+        public abstract bool IsDeclaredBy(MetaType type);
+    }
+    public abstract class MetaFunction {
+        protected MetaFunction();
+        public abstract bool HasMultipleResults { get; }
+        public abstract bool IsComposable { get; }
+        public abstract string MappedName { get; }
+        public abstract MethodInfo Method { get; }
+        public abstract MetaModel Model { get; }
+        public abstract string Name { get; }
+        public abstract ReadOnlyCollection<MetaParameter> Parameters { get; }
+        public abstract ReadOnlyCollection<MetaType> ResultRowTypes { get; }
+        public abstract MetaParameter ReturnParameter { get; }
+    }
+    public abstract class MetaModel {
+        protected MetaModel();
+        public abstract Type ContextType { get; }
+        public abstract string DatabaseName { get; }
+        public abstract MappingSource MappingSource { get; }
+        public abstract Type ProviderType { get; }
+        public abstract MetaFunction GetFunction(MethodInfo method);
+        public abstract IEnumerable<MetaFunction> GetFunctions();
+        public abstract MetaType GetMetaType(Type type);
+        public abstract MetaTable GetTable(Type rowType);
+        public abstract IEnumerable<MetaTable> GetTables();
+    }
+    public abstract class MetaParameter {
+        protected MetaParameter();
+        public abstract string DbType { get; }
+        public abstract string MappedName { get; }
+        public abstract string Name { get; }
+        public abstract ParameterInfo Parameter { get; }
+        public abstract Type ParameterType { get; }
+    }
+    public abstract class MetaTable {
+        protected MetaTable();
+        public abstract MethodInfo DeleteMethod { get; }
+        public abstract MethodInfo InsertMethod { get; }
+        public abstract MetaModel Model { get; }
+        public abstract MetaType RowType { get; }
+        public abstract string TableName { get; }
+        public abstract MethodInfo UpdateMethod { get; }
+    }
+    public abstract class MetaType {
+        protected MetaType();
+        public abstract ReadOnlyCollection<MetaAssociation> Associations { get; }
+        public abstract bool CanInstantiate { get; }
+        public abstract ReadOnlyCollection<MetaDataMember> DataMembers { get; }
+        public abstract MetaDataMember DBGeneratedIdentityMember { get; }
+        public abstract ReadOnlyCollection<MetaType> DerivedTypes { get; }
+        public abstract MetaDataMember Discriminator { get; }
+        public abstract bool HasAnyLoadMethod { get; }
+        public abstract bool HasAnyValidateMethod { get; }
+        public abstract bool HasInheritance { get; }
+        public abstract bool HasInheritanceCode { get; }
+        public abstract bool HasUpdateCheck { get; }
+        public abstract ReadOnlyCollection<MetaDataMember> IdentityMembers { get; }
+        public abstract MetaType InheritanceBase { get; }
+        public abstract object InheritanceCode { get; }
+        public abstract MetaType InheritanceDefault { get; }
+        public abstract MetaType InheritanceRoot { get; }
+        public abstract ReadOnlyCollection<MetaType> InheritanceTypes { get; }
+        public abstract bool IsEntity { get; }
+        public abstract bool IsInheritanceDefault { get; }
+        public abstract MetaModel Model { get; }
+        public abstract string Name { get; }
+        public abstract MethodInfo OnLoadedMethod { get; }
+        public abstract MethodInfo OnValidateMethod { get; }
+        public abstract ReadOnlyCollection<MetaDataMember> PersistentDataMembers { get; }
+        public abstract MetaTable Table { get; }
+        public abstract Type Type { get; }
+        public abstract MetaDataMember VersionMember { get; }
+        public abstract MetaDataMember GetDataMember(MemberInfo member);
+        public abstract MetaType GetInheritanceType(Type type);
+        public abstract MetaType GetTypeForInheritanceCode(object code);
+    }
+    public sealed class ParameterAttribute : Attribute {
+        public ParameterAttribute();
+        public string DbType { get; set; }
+        public string Name { get; set; }
+    }
+    public sealed class ProviderAttribute : Attribute {
+        public ProviderAttribute();
+        public ProviderAttribute(Type type);
+        public Type Type { get; }
+    }
+    public sealed class ResultTypeAttribute : Attribute {
+        public ResultTypeAttribute(Type type);
+        public Type Type { get; }
+    }
+    public sealed class TableAttribute : Attribute {
+        public TableAttribute();
+        public string Name { get; set; }
+    }
+    public enum UpdateCheck {
+        Always = 0,
+        Never = 1,
+        WhenChanged = 2,
+    }
+    public sealed class XmlMappingSource : MappingSource {
+        protected override MetaModel CreateModel(Type dataContextType);
+        public static XmlMappingSource FromReader(XmlReader reader);
+        public static XmlMappingSource FromStream(Stream stream);
+        public static XmlMappingSource FromUrl(string url);
+        public static XmlMappingSource FromXml(string xml);
+    }
+}
```

