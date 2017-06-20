# System.Data.Metadata.Edm

``` diff
+namespace System.Data.Metadata.Edm {
+    public sealed class AssociationEndMember : RelationshipEndMember {
+        public override BuiltInTypeKind BuiltInTypeKind { get; }
+    }
+    public sealed class AssociationSet : RelationshipSet {
+        public ReadOnlyMetadataCollection<AssociationSetEnd> AssociationSetEnds { get; }
+        public override BuiltInTypeKind BuiltInTypeKind { get; }
+        public new AssociationType ElementType { get; }
+    }
+    public sealed class AssociationSetEnd : MetadataItem {
+        public override BuiltInTypeKind BuiltInTypeKind { get; }
+        public AssociationEndMember CorrespondingAssociationEndMember { get; }
+        public EntitySet EntitySet { get; }
+        public string Name { get; }
+        public AssociationSet ParentAssociationSet { get; }
+        public string Role { get; }
+        public override string ToString();
+    }
+    public sealed class AssociationType : RelationshipType {
+        public ReadOnlyMetadataCollection<AssociationEndMember> AssociationEndMembers { get; }
+        public override BuiltInTypeKind BuiltInTypeKind { get; }
+        public bool IsForeignKey { get; }
+        public ReadOnlyMetadataCollection<ReferentialConstraint> ReferentialConstraints { get; }
+    }
+    public enum BuiltInTypeKind {
+        AssociationEndMember = 0,
+        AssociationSet = 2,
+        AssociationSetEnd = 1,
+        AssociationType = 3,
+        CollectionKind = 7,
+        CollectionType = 6,
+        ComplexType = 8,
+        Documentation = 9,
+        EdmFunction = 18,
+        EdmMember = 24,
+        EdmProperty = 28,
+        EdmType = 11,
+        EntityContainer = 12,
+        EntitySet = 13,
+        EntitySetBase = 4,
+        EntityType = 14,
+        EntityTypeBase = 5,
+        EnumMember = 16,
+        EnumType = 15,
+        Facet = 17,
+        FunctionParameter = 19,
+        GlobalItem = 20,
+        MetadataItem = 23,
+        MetadataProperty = 21,
+        NavigationProperty = 22,
+        OperationAction = 10,
+        ParameterMode = 25,
+        PrimitiveType = 26,
+        PrimitiveTypeKind = 27,
+        ProviderManifest = 29,
+        ReferentialConstraint = 30,
+        RefType = 31,
+        RelationshipEndMember = 32,
+        RelationshipMultiplicity = 33,
+        RelationshipSet = 34,
+        RelationshipType = 35,
+        RowType = 36,
+        SimpleType = 37,
+        StructuralType = 38,
+        TypeUsage = 39,
+    }
+    public enum CollectionKind {
+        Bag = 1,
+        List = 2,
+        None = 0,
+    }
+    public sealed class CollectionType : EdmType {
+        public override BuiltInTypeKind BuiltInTypeKind { get; }
+        public TypeUsage TypeUsage { get; }
+    }
+    public class ComplexType : StructuralType {
+        public override BuiltInTypeKind BuiltInTypeKind { get; }
+        public ReadOnlyMetadataCollection<EdmProperty> Properties { get; }
+    }
+    public enum ConcurrencyMode {
+        Fixed = 1,
+        None = 0,
+    }
+    public enum DataSpace {
+        CSpace = 1,
+        CSSpace = 4,
+        OCSpace = 3,
+        OSpace = 0,
+        SSpace = 2,
+    }
+    public sealed class Documentation : MetadataItem {
+        public override BuiltInTypeKind BuiltInTypeKind { get; }
+        public bool IsEmpty { get; }
+        public string LongDescription { get; internal set; }
+        public string Summary { get; internal set; }
+        public override string ToString();
+    }
+    public abstract class EdmError {
+        public string Message { get; }
+    }
+    public sealed class EdmFunction : EdmType {
+        public override BuiltInTypeKind BuiltInTypeKind { get; }
+        public string CommandTextAttribute { get; }
+        public override string FullName { get; }
+        public bool IsComposableAttribute { get; }
+        public ReadOnlyMetadataCollection<FunctionParameter> Parameters { get; }
+        public FunctionParameter ReturnParameter { get; }
+        public ReadOnlyMetadataCollection<FunctionParameter> ReturnParameters { get; }
+    }
+    public sealed class EdmItemCollection : ItemCollection {
+        public EdmItemCollection(IEnumerable<XmlReader> xmlReaders);
+        public EdmItemCollection(params string[] filePaths);
+        public double EdmVersion { get; internal set; }
+        public ReadOnlyCollection<PrimitiveType> GetPrimitiveTypes();
+        public ReadOnlyCollection<PrimitiveType> GetPrimitiveTypes(double edmVersion);
+    }
+    public abstract class EdmMember : MetadataItem {
+        public StructuralType DeclaringType { get; }
+        public string Name { get; }
+        public TypeUsage TypeUsage { get; }
+        public override string ToString();
+    }
+    public sealed class EdmProperty : EdmMember {
+        public override BuiltInTypeKind BuiltInTypeKind { get; }
+        public object DefaultValue { get; }
+        public bool Nullable { get; }
+    }
+    public sealed class EdmSchemaError : EdmError {
+        public int Column { get; }
+        public int ErrorCode { get; }
+        public int Line { get; }
+        public string SchemaLocation { get; }
+        public string SchemaName { get; }
+        public EdmSchemaErrorSeverity Severity { get; set; }
+        public string StackTrace { get; }
+        public override string ToString();
+    }
+    public enum EdmSchemaErrorSeverity {
+        Error = 1,
+        Warning = 0,
+    }
+    public abstract class EdmType : GlobalItem {
+        public bool Abstract { get; internal set; }
+        public EdmType BaseType { get; internal set; }
+        public virtual string FullName { get; }
+        public string Name { get; internal set; }
+        public string NamespaceName { get; internal set; }
+        public CollectionType GetCollectionType();
+        public override string ToString();
+    }
+    public sealed class EntityContainer : GlobalItem {
+        public ReadOnlyMetadataCollection<EntitySetBase> BaseEntitySets { get; }
+        public override BuiltInTypeKind BuiltInTypeKind { get; }
+        public ReadOnlyMetadataCollection<EdmFunction> FunctionImports { get; }
+        public string Name { get; }
+        public EntitySet GetEntitySetByName(string name, bool ignoreCase);
+        public RelationshipSet GetRelationshipSetByName(string name, bool ignoreCase);
+        public override string ToString();
+        public bool TryGetEntitySetByName(string name, bool ignoreCase, out EntitySet entitySet);
+        public bool TryGetRelationshipSetByName(string name, bool ignoreCase, out RelationshipSet relationshipSet);
+    }
+    public class EntitySet : EntitySetBase {
+        public override BuiltInTypeKind BuiltInTypeKind { get; }
+        public new EntityType ElementType { get; }
+    }
+    public abstract class EntitySetBase : MetadataItem {
+        public override BuiltInTypeKind BuiltInTypeKind { get; }
+        public EntityTypeBase ElementType { get; internal set; }
+        public EntityContainer EntityContainer { get; }
+        public string Name { get; }
+        public override string ToString();
+    }
+    public class EntityType : EntityTypeBase {
+        public override BuiltInTypeKind BuiltInTypeKind { get; }
+        public ReadOnlyMetadataCollection<NavigationProperty> NavigationProperties { get; }
+        public ReadOnlyMetadataCollection<EdmProperty> Properties { get; }
+        public RefType GetReferenceType();
+    }
+    public abstract class EntityTypeBase : StructuralType {
+        public ReadOnlyMetadataCollection<EdmMember> KeyMembers { get; }
+    }
+    public sealed class EnumMember : MetadataItem {
+        public override BuiltInTypeKind BuiltInTypeKind { get; }
+        public string Name { get; }
+        public object Value { get; }
+        public override string ToString();
+    }
+    public class EnumType : SimpleType {
+        public override BuiltInTypeKind BuiltInTypeKind { get; }
+        public bool IsFlags { get; }
+        public ReadOnlyMetadataCollection<EnumMember> Members { get; }
+        public PrimitiveType UnderlyingType { get; }
+    }
+    public sealed class Facet : MetadataItem {
+        public override BuiltInTypeKind BuiltInTypeKind { get; }
+        public FacetDescription Description { get; }
+        public EdmType FacetType { get; }
+        public bool IsUnbounded { get; }
+        public string Name { get; }
+        public object Value { get; }
+        public override string ToString();
+    }
+    public sealed class FacetDescription {
+        public object DefaultValue { get; }
+        public string FacetName { get; }
+        public EdmType FacetType { get; }
+        public bool IsConstant { get; }
+        public bool IsRequired { get; }
+        public Nullable<int> MaxValue { get; }
+        public Nullable<int> MinValue { get; }
+        public override string ToString();
+    }
+    public sealed class FunctionParameter : MetadataItem {
+        public override BuiltInTypeKind BuiltInTypeKind { get; }
+        public EdmFunction DeclaringFunction { get; }
+        public ParameterMode Mode { get; }
+        public string Name { get; }
+        public TypeUsage TypeUsage { get; }
+        public override string ToString();
+    }
+    public abstract class GlobalItem : MetadataItem
+    public abstract class ItemCollection : ReadOnlyMetadataCollection<GlobalItem> {
+        public DataSpace DataSpace { get; }
+        public EntityContainer GetEntityContainer(string name);
+        public EntityContainer GetEntityContainer(string name, bool ignoreCase);
+        protected static ReadOnlyCollection<EdmFunction> GetFunctions(Dictionary<string, ReadOnlyCollection<EdmFunction>> functionCollection, string functionName, bool ignoreCase);
+        public ReadOnlyCollection<EdmFunction> GetFunctions(string functionName);
+        public ReadOnlyCollection<EdmFunction> GetFunctions(string functionName, bool ignoreCase);
+        public T GetItem<T>(string identity) where T : GlobalItem;
+        public T GetItem<T>(string identity, bool ignoreCase) where T : GlobalItem;
+        public virtual ReadOnlyCollection<T> GetItems<T>() where T : GlobalItem;
+        public EdmType GetType(string name, string namespaceName);
+        public EdmType GetType(string name, string namespaceName, bool ignoreCase);
+        public bool TryGetEntityContainer(string name, bool ignoreCase, out EntityContainer entityContainer);
+        public bool TryGetEntityContainer(string name, out EntityContainer entityContainer);
+        public bool TryGetItem<T>(string identity, bool ignoreCase, out T item) where T : GlobalItem;
+        public bool TryGetItem<T>(string identity, out T item) where T : GlobalItem;
+        public bool TryGetType(string name, string namespaceName, bool ignoreCase, out EdmType type);
+        public bool TryGetType(string name, string namespaceName, out EdmType type);
+    }
+    public abstract class MetadataItem {
+        public abstract BuiltInTypeKind BuiltInTypeKind { get; }
+        public Documentation Documentation { get; set; }
+        public ReadOnlyMetadataCollection<MetadataProperty> MetadataProperties { get; }
+        public static EdmType GetBuiltInType(BuiltInTypeKind builtInTypeKind);
+        public static ReadOnlyCollection<FacetDescription> GetGeneralFacetDescriptions();
+    }
+    public sealed class MetadataProperty : MetadataItem {
+        public override BuiltInTypeKind BuiltInTypeKind { get; }
+        public string Name { get; }
+        public PropertyKind PropertyKind { get; }
+        public TypeUsage TypeUsage { get; }
+        public object Value { get; }
+    }
+    public sealed class MetadataWorkspace {
+        public static readonly double MaximumEdmVersionSupported;
+        public MetadataWorkspace();
+        public MetadataWorkspace(IEnumerable<string> paths, IEnumerable<Assembly> assembliesToConsider);
+        public static void ClearCache();
+        public EntitySqlParser CreateEntitySqlParser();
+        public DbQueryCommandTree CreateQueryCommandTree(DbExpression query);
+        public EnumType GetEdmSpaceType(EnumType objectSpaceType);
+        public StructuralType GetEdmSpaceType(StructuralType objectSpaceType);
+        public EntityContainer GetEntityContainer(string name, bool ignoreCase, DataSpace dataSpace);
+        public EntityContainer GetEntityContainer(string name, DataSpace dataSpace);
+        public ReadOnlyCollection<EdmFunction> GetFunctions(string name, string namespaceName, DataSpace dataSpace);
+        public ReadOnlyCollection<EdmFunction> GetFunctions(string name, string namespaceName, DataSpace dataSpace, bool ignoreCase);
+        public T GetItem<T>(string identity, bool ignoreCase, DataSpace dataSpace) where T : GlobalItem;
+        public T GetItem<T>(string identity, DataSpace dataSpace) where T : GlobalItem;
+        public ItemCollection GetItemCollection(DataSpace dataSpace);
+        public ReadOnlyCollection<GlobalItem> GetItems(DataSpace dataSpace);
+        public ReadOnlyCollection<T> GetItems<T>(DataSpace dataSpace) where T : GlobalItem;
+        public EnumType GetObjectSpaceType(EnumType edmSpaceType);
+        public StructuralType GetObjectSpaceType(StructuralType edmSpaceType);
+        public ReadOnlyCollection<PrimitiveType> GetPrimitiveTypes(DataSpace dataSpace);
+        public ReadOnlyCollection<EdmMember> GetRelevantMembersForUpdate(EntitySetBase entitySet, EntityTypeBase entityType, bool partialUpdateSupported);
+        public IEnumerable<EdmMember> GetRequiredOriginalValueMembers(EntitySetBase entitySet, EntityTypeBase entityType);
+        public EdmType GetType(string name, string namespaceName, bool ignoreCase, DataSpace dataSpace);
+        public EdmType GetType(string name, string namespaceName, DataSpace dataSpace);
+        public void LoadFromAssembly(Assembly assembly);
+        public void LoadFromAssembly(Assembly assembly, Action<string> logLoadMessage);
+        public void RegisterItemCollection(ItemCollection collection);
+        public bool TryGetEdmSpaceType(EnumType objectSpaceType, out EnumType edmSpaceType);
+        public bool TryGetEdmSpaceType(StructuralType objectSpaceType, out StructuralType edmSpaceType);
+        public bool TryGetEntityContainer(string name, bool ignoreCase, DataSpace dataSpace, out EntityContainer entityContainer);
+        public bool TryGetEntityContainer(string name, DataSpace dataSpace, out EntityContainer entityContainer);
+        public bool TryGetItem<T>(string identity, bool ignoreCase, DataSpace dataSpace, out T item) where T : GlobalItem;
+        public bool TryGetItem<T>(string identity, DataSpace space, out T item) where T : GlobalItem;
+        public bool TryGetItemCollection(DataSpace dataSpace, out ItemCollection collection);
+        public bool TryGetObjectSpaceType(EnumType edmSpaceType, out EnumType objectSpaceType);
+        public bool TryGetObjectSpaceType(StructuralType edmSpaceType, out StructuralType objectSpaceType);
+        public bool TryGetType(string name, string namespaceName, bool ignoreCase, DataSpace dataSpace, out EdmType type);
+        public bool TryGetType(string name, string namespaceName, DataSpace dataSpace, out EdmType type);
+    }
+    public sealed class NavigationProperty : EdmMember {
+        public override BuiltInTypeKind BuiltInTypeKind { get; }
+        public RelationshipEndMember FromEndMember { get; internal set; }
+        public RelationshipType RelationshipType { get; internal set; }
+        public RelationshipEndMember ToEndMember { get; internal set; }
+        public IEnumerable<EdmProperty> GetDependentProperties();
+    }
+    public sealed class ObjectItemCollection : ItemCollection {
+        public ObjectItemCollection();
+        public Type GetClrType(EnumType objectSpaceType);
+        public Type GetClrType(StructuralType objectSpaceType);
+        public override ReadOnlyCollection<T> GetItems<T>();
+        public IEnumerable<PrimitiveType> GetPrimitiveTypes();
+        public void LoadFromAssembly(Assembly assembly);
+        public void LoadFromAssembly(Assembly assembly, EdmItemCollection edmItemCollection);
+        public void LoadFromAssembly(Assembly assembly, EdmItemCollection edmItemCollection, Action<string> logLoadMessage);
+        public bool TryGetClrType(EnumType objectSpaceType, out Type clrType);
+        public bool TryGetClrType(StructuralType objectSpaceType, out Type clrType);
+    }
+    public enum OperationAction {
+        Cascade = 1,
+        None = 0,
+        Restrict = 2,
+    }
+    public enum ParameterMode {
+        In = 0,
+        InOut = 2,
+        Out = 1,
+        ReturnValue = 3,
+    }
+    public enum ParameterTypeSemantics {
+        AllowImplicitConversion = 0,
+        AllowImplicitPromotion = 1,
+        ExactMatchOnly = 2,
+    }
+    public sealed class PrimitiveType : SimpleType {
+        public override BuiltInTypeKind BuiltInTypeKind { get; }
+        public Type ClrEquivalentType { get; }
+        public ReadOnlyCollection<FacetDescription> FacetDescriptions { get; }
+        public PrimitiveTypeKind PrimitiveTypeKind { get; internal set; }
+        public EdmType GetEdmPrimitiveType();
+        public static PrimitiveType GetEdmPrimitiveType(PrimitiveTypeKind primitiveTypeKind);
+        public static ReadOnlyCollection<PrimitiveType> GetEdmPrimitiveTypes();
+    }
+    public enum PrimitiveTypeKind {
+        Binary = 0,
+        Boolean = 1,
+        Byte = 2,
+        DateTime = 3,
+        DateTimeOffset = 14,
+        Decimal = 4,
+        Double = 5,
+        Geography = 16,
+        GeographyCollection = 30,
+        GeographyLineString = 25,
+        GeographyMultiLineString = 28,
+        GeographyMultiPoint = 27,
+        GeographyMultiPolygon = 29,
+        GeographyPoint = 24,
+        GeographyPolygon = 26,
+        Geometry = 15,
+        GeometryCollection = 23,
+        GeometryLineString = 18,
+        GeometryMultiLineString = 21,
+        GeometryMultiPoint = 20,
+        GeometryMultiPolygon = 22,
+        GeometryPoint = 17,
+        GeometryPolygon = 19,
+        Guid = 6,
+        Int16 = 9,
+        Int32 = 10,
+        Int64 = 11,
+        SByte = 8,
+        Single = 7,
+        String = 12,
+        Time = 13,
+    }
+    public enum PropertyKind {
+        Extended = 1,
+        System = 0,
+    }
+    public class ReadOnlyMetadataCollection<T> : ReadOnlyCollection<T> where T : MetadataItem {
+        public bool IsReadOnly { get; }
+        public virtual T this[string identity] { get; }
+        public virtual bool Contains(string identity);
+        public new ReadOnlyMetadataCollection<T>.Enumerator GetEnumerator();
+        public virtual T GetValue(string identity, bool ignoreCase);
+        public virtual new int IndexOf(T value);
+        public virtual bool TryGetValue(string identity, bool ignoreCase, out T item);
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct Enumerator : IDisposable, IEnumerator, IEnumerator<T> {
+            public T Current { get; }
+            object System.Collections.IEnumerator.Current { get; }
+            public void Dispose();
+            public bool MoveNext();
+            public void Reset();
+        }
+    }
+    public sealed class ReferentialConstraint : MetadataItem {
+        public override BuiltInTypeKind BuiltInTypeKind { get; }
+        public ReadOnlyMetadataCollection<EdmProperty> FromProperties { get; }
+        public RelationshipEndMember FromRole { get; }
+        public ReadOnlyMetadataCollection<EdmProperty> ToProperties { get; }
+        public RelationshipEndMember ToRole { get; }
+        public override string ToString();
+    }
+    public sealed class RefType : EdmType {
+        public override BuiltInTypeKind BuiltInTypeKind { get; }
+        public EntityTypeBase ElementType { get; }
+    }
+    public abstract class RelationshipEndMember : EdmMember {
+        public OperationAction DeleteBehavior { get; internal set; }
+        public RelationshipMultiplicity RelationshipMultiplicity { get; }
+        public EntityType GetEntityType();
+    }
+    public enum RelationshipMultiplicity {
+        Many = 2,
+        One = 1,
+        ZeroOrOne = 0,
+    }
+    public abstract class RelationshipSet : EntitySetBase {
+        public override BuiltInTypeKind BuiltInTypeKind { get; }
+        public new RelationshipType ElementType { get; }
+    }
+    public abstract class RelationshipType : EntityTypeBase {
+        public ReadOnlyMetadataCollection<RelationshipEndMember> RelationshipEndMembers { get; }
+    }
+    public sealed class RowType : StructuralType {
+        public override BuiltInTypeKind BuiltInTypeKind { get; }
+        public ReadOnlyMetadataCollection<EdmProperty> Properties { get; }
+    }
+    public abstract class SimpleType : EdmType
+    public enum StoreGeneratedPattern {
+        Computed = 2,
+        Identity = 1,
+        None = 0,
+    }
+    public sealed class StoreItemCollection : ItemCollection {
+        public StoreItemCollection(IEnumerable<XmlReader> xmlReaders);
+        public StoreItemCollection(params string[] filePaths);
+        public double StoreSchemaVersion { get; internal set; }
+        public ReadOnlyCollection<PrimitiveType> GetPrimitiveTypes();
+    }
+    public abstract class StructuralType : EdmType {
+        public ReadOnlyMetadataCollection<EdmMember> Members { get; }
+    }
+    public sealed class TypeUsage : MetadataItem {
+        public override BuiltInTypeKind BuiltInTypeKind { get; }
+        public EdmType EdmType { get; }
+        public ReadOnlyMetadataCollection<Facet> Facets { get; }
+        public static TypeUsage CreateBinaryTypeUsage(PrimitiveType primitiveType, bool isFixedLength);
+        public static TypeUsage CreateBinaryTypeUsage(PrimitiveType primitiveType, bool isFixedLength, int maxLength);
+        public static TypeUsage CreateDateTimeOffsetTypeUsage(PrimitiveType primitiveType, Nullable<byte> precision);
+        public static TypeUsage CreateDateTimeTypeUsage(PrimitiveType primitiveType, Nullable<byte> precision);
+        public static TypeUsage CreateDecimalTypeUsage(PrimitiveType primitiveType);
+        public static TypeUsage CreateDecimalTypeUsage(PrimitiveType primitiveType, byte precision, byte scale);
+        public static TypeUsage CreateDefaultTypeUsage(EdmType edmType);
+        public static TypeUsage CreateStringTypeUsage(PrimitiveType primitiveType, bool isUnicode, bool isFixedLength);
+        public static TypeUsage CreateStringTypeUsage(PrimitiveType primitiveType, bool isUnicode, bool isFixedLength, int maxLength);
+        public static TypeUsage CreateTimeTypeUsage(PrimitiveType primitiveType, Nullable<byte> precision);
+        public bool IsSubtypeOf(TypeUsage typeUsage);
+        public override string ToString();
+    }
+}
```

