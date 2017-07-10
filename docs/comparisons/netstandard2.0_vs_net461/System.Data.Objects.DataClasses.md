# System.Data.Objects.DataClasses

``` diff
+namespace System.Data.Objects.DataClasses {
+    public abstract class ComplexObject : StructuralObject {
+        protected ComplexObject();
+        protected sealed override void ReportPropertyChanged(string property);
+        protected sealed override void ReportPropertyChanging(string property);
+    }
+    public sealed class EdmComplexPropertyAttribute : EdmPropertyAttribute {
+        public EdmComplexPropertyAttribute();
+    }
+    public sealed class EdmComplexTypeAttribute : EdmTypeAttribute {
+        public EdmComplexTypeAttribute();
+    }
+    public sealed class EdmEntityTypeAttribute : EdmTypeAttribute {
+        public EdmEntityTypeAttribute();
+    }
+    public sealed class EdmEnumTypeAttribute : EdmTypeAttribute {
+        public EdmEnumTypeAttribute();
+    }
+    public sealed class EdmFunctionAttribute : Attribute {
+        public EdmFunctionAttribute(string namespaceName, string functionName);
+        public string FunctionName { get; }
+        public string NamespaceName { get; }
+    }
+    public abstract class EdmPropertyAttribute : Attribute
+    public sealed class EdmRelationshipAttribute : Attribute {
+        public EdmRelationshipAttribute(string relationshipNamespaceName, string relationshipName, string role1Name, RelationshipMultiplicity role1Multiplicity, Type role1Type, string role2Name, RelationshipMultiplicity role2Multiplicity, Type role2Type);
+        public EdmRelationshipAttribute(string relationshipNamespaceName, string relationshipName, string role1Name, RelationshipMultiplicity role1Multiplicity, Type role1Type, string role2Name, RelationshipMultiplicity role2Multiplicity, Type role2Type, bool isForeignKey);
+        public bool IsForeignKey { get; }
+        public string RelationshipName { get; }
+        public string RelationshipNamespaceName { get; }
+        public RelationshipMultiplicity Role1Multiplicity { get; }
+        public string Role1Name { get; }
+        public Type Role1Type { get; }
+        public RelationshipMultiplicity Role2Multiplicity { get; }
+        public string Role2Name { get; }
+        public Type Role2Type { get; }
+    }
+    public sealed class EdmRelationshipNavigationPropertyAttribute : EdmPropertyAttribute {
+        public EdmRelationshipNavigationPropertyAttribute(string relationshipNamespaceName, string relationshipName, string targetRoleName);
+        public string RelationshipName { get; }
+        public string RelationshipNamespaceName { get; }
+        public string TargetRoleName { get; }
+    }
+    public sealed class EdmScalarPropertyAttribute : EdmPropertyAttribute {
+        public EdmScalarPropertyAttribute();
+        public bool EntityKeyProperty { get; set; }
+        public bool IsNullable { get; set; }
+    }
+    public sealed class EdmSchemaAttribute : Attribute {
+        public EdmSchemaAttribute();
+        public EdmSchemaAttribute(string assemblyGuid);
+    }
+    public abstract class EdmTypeAttribute : Attribute {
+        public string Name { get; set; }
+        public string NamespaceName { get; set; }
+    }
+    public sealed class EntityCollection<TEntity> : RelatedEnd, ICollection<TEntity>, IEnumerable, IEnumerable<TEntity>, IListSource where TEntity : class {
+        public EntityCollection();
+        public int Count { get; }
+        public bool IsReadOnly { get; }
+        bool System.ComponentModel.IListSource.ContainsListCollection { get; }
+        public void Add(TEntity entity);
+        public void Attach(IEnumerable<TEntity> entities);
+        public void Attach(TEntity entity);
+        public void Clear();
+        public bool Contains(TEntity entity);
+        public void CopyTo(TEntity[] array, int arrayIndex);
+        public ObjectQuery<TEntity> CreateSourceQuery();
+        public new IEnumerator<TEntity> GetEnumerator();
+        public override void Load(MergeOption mergeOption);
+        public void OnCollectionDeserialized(StreamingContext context);
+        public void OnSerializing(StreamingContext context);
+        public bool Remove(TEntity entity);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        IList System.ComponentModel.IListSource.GetList();
+    }
+    public abstract class EntityObject : StructuralObject, IEntityWithChangeTracker, IEntityWithKey, IEntityWithRelationships {
+        protected EntityObject();
+        public EntityKey EntityKey { get; set; }
+        public EntityState EntityState { get; }
+        RelationshipManager System.Data.Objects.DataClasses.IEntityWithRelationships.RelationshipManager { get; }
+        protected sealed override void ReportPropertyChanged(string property);
+        protected sealed override void ReportPropertyChanging(string property);
+        void System.Data.Objects.DataClasses.IEntityWithChangeTracker.SetChangeTracker(IEntityChangeTracker changeTracker);
+    }
+    public abstract class EntityReference : RelatedEnd {
+        public EntityKey EntityKey { get; set; }
+    }
+    public sealed class EntityReference<TEntity> : EntityReference where TEntity : class {
+        public EntityReference();
+        public TEntity Value { get; set; }
+        public void Attach(TEntity entity);
+        public ObjectQuery<TEntity> CreateSourceQuery();
+        public override void Load(MergeOption mergeOption);
+        public void OnRefDeserialized(StreamingContext context);
+        public void OnSerializing(StreamingContext context);
+    }
+    public interface IEntityChangeTracker {
+        EntityState EntityState { get; }
+        void EntityComplexMemberChanged(string entityMemberName, object complexObject, string complexObjectMemberName);
+        void EntityComplexMemberChanging(string entityMemberName, object complexObject, string complexObjectMemberName);
+        void EntityMemberChanged(string entityMemberName);
+        void EntityMemberChanging(string entityMemberName);
+    }
+    public interface IEntityWithChangeTracker {
+        void SetChangeTracker(IEntityChangeTracker changeTracker);
+    }
+    public interface IEntityWithKey {
+        EntityKey EntityKey { get; set; }
+    }
+    public interface IEntityWithRelationships {
+        RelationshipManager RelationshipManager { get; }
+    }
+    public interface IRelatedEnd {
+        bool IsLoaded { get; }
+        string RelationshipName { get; }
+        RelationshipSet RelationshipSet { get; }
+        string SourceRoleName { get; }
+        string TargetRoleName { get; }
+        void Add(IEntityWithRelationships entity);
+        void Add(object entity);
+        void Attach(IEntityWithRelationships entity);
+        void Attach(object entity);
+        IEnumerable CreateSourceQuery();
+        IEnumerator GetEnumerator();
+        void Load();
+        void Load(MergeOption mergeOption);
+        bool Remove(IEntityWithRelationships entity);
+        bool Remove(object entity);
+    }
+    public abstract class RelatedEnd : IRelatedEnd {
+        public bool IsLoaded { get; }
+        public string RelationshipName { get; }
+        public RelationshipSet RelationshipSet { get; }
+        public string SourceRoleName { get; }
+        public string TargetRoleName { get; }
+        public event CollectionChangeEventHandler AssociationChanged;
+        public IEnumerator GetEnumerator();
+        public void Load();
+        public abstract void Load(MergeOption mergeOption);
+        public void OnDeserialized(StreamingContext context);
+        void System.Data.Objects.DataClasses.IRelatedEnd.Add(IEntityWithRelationships entity);
+        void System.Data.Objects.DataClasses.IRelatedEnd.Add(object entity);
+        void System.Data.Objects.DataClasses.IRelatedEnd.Attach(IEntityWithRelationships entity);
+        void System.Data.Objects.DataClasses.IRelatedEnd.Attach(object entity);
+        IEnumerable System.Data.Objects.DataClasses.IRelatedEnd.CreateSourceQuery();
+        bool System.Data.Objects.DataClasses.IRelatedEnd.Remove(IEntityWithRelationships entity);
+        bool System.Data.Objects.DataClasses.IRelatedEnd.Remove(object entity);
+    }
+    public enum RelationshipKind {
+        Association = 0,
+    }
+    public class RelationshipManager {
+        public static RelationshipManager Create(IEntityWithRelationships owner);
+        public IEnumerable<IRelatedEnd> GetAllRelatedEnds();
+        public EntityCollection<TTargetEntity> GetRelatedCollection<TTargetEntity>(string relationshipName, string targetRoleName) where TTargetEntity : class;
+        public IRelatedEnd GetRelatedEnd(string relationshipName, string targetRoleName);
+        public EntityReference<TTargetEntity> GetRelatedReference<TTargetEntity>(string relationshipName, string targetRoleName) where TTargetEntity : class;
+        public void InitializeRelatedCollection<TTargetEntity>(string relationshipName, string targetRoleName, EntityCollection<TTargetEntity> entityCollection) where TTargetEntity : class;
+        public void InitializeRelatedReference<TTargetEntity>(string relationshipName, string targetRoleName, EntityReference<TTargetEntity> entityReference) where TTargetEntity : class;
+        public void OnDeserialized(StreamingContext context);
+        public void OnSerializing(StreamingContext context);
+    }
+    public abstract class StructuralObject : INotifyPropertyChanged, INotifyPropertyChanging {
+        public static readonly string EntityKeyPropertyName;
+        protected StructuralObject();
+        public event PropertyChangedEventHandler PropertyChanged;
+        public event PropertyChangingEventHandler PropertyChanging;
+        protected internal static bool BinaryEquals(byte[] first, byte[] second);
+        protected static DateTime DefaultDateTimeValue();
+        protected internal static byte[] GetValidValue(byte[] currentValue);
+        protected internal T GetValidValue<T>(T currentValue, string property, bool isNullable, bool isInitialized) where T : ComplexObject, new();
+        protected virtual void OnPropertyChanged(string property);
+        protected virtual void OnPropertyChanging(string property);
+        protected virtual void ReportPropertyChanged(string property);
+        protected virtual void ReportPropertyChanging(string property);
+        protected internal static bool SetValidValue(bool value);
+        protected internal static bool SetValidValue(bool value, string propertyName);
+        protected internal static byte SetValidValue(byte value);
+        protected internal static byte SetValidValue(byte value, string propertyName);
+        protected internal static byte[] SetValidValue(byte[] value, bool isNullable);
+        protected internal static byte[] SetValidValue(byte[] value, bool isNullable, string propertyName);
+        protected internal static DbGeography SetValidValue(DbGeography value, bool isNullable);
+        protected internal static DbGeography SetValidValue(DbGeography value, bool isNullable, string propertyName);
+        protected internal static DbGeometry SetValidValue(DbGeometry value, bool isNullable);
+        protected internal static DbGeometry SetValidValue(DbGeometry value, bool isNullable, string propertyName);
+        protected internal static DateTime SetValidValue(DateTime value);
+        protected internal static DateTime SetValidValue(DateTime value, string propertyName);
+        protected internal static DateTimeOffset SetValidValue(DateTimeOffset value);
+        protected internal static DateTimeOffset SetValidValue(DateTimeOffset value, string propertyName);
+        protected internal static decimal SetValidValue(decimal value);
+        protected internal static decimal SetValidValue(decimal value, string propertyName);
+        protected internal static double SetValidValue(double value);
+        protected internal static double SetValidValue(double value, string propertyName);
+        protected internal static Guid SetValidValue(Guid value);
+        protected internal static Guid SetValidValue(Guid value, string propertyName);
+        protected internal static short SetValidValue(short value);
+        protected internal static short SetValidValue(short value, string propertyName);
+        protected internal static int SetValidValue(int value);
+        protected internal static int SetValidValue(int value, string propertyName);
+        protected internal static long SetValidValue(long value);
+        protected internal static long SetValidValue(long value, string propertyName);
+        protected internal static Nullable<bool> SetValidValue(Nullable<bool> value);
+        protected internal static Nullable<bool> SetValidValue(Nullable<bool> value, string propertyName);
+        protected internal static Nullable<byte> SetValidValue(Nullable<byte> value);
+        protected internal static Nullable<byte> SetValidValue(Nullable<byte> value, string propertyName);
+        protected internal static Nullable<DateTime> SetValidValue(Nullable<DateTime> value);
+        protected internal static Nullable<DateTime> SetValidValue(Nullable<DateTime> value, string propertyName);
+        protected internal static Nullable<DateTimeOffset> SetValidValue(Nullable<DateTimeOffset> value);
+        protected internal static Nullable<DateTimeOffset> SetValidValue(Nullable<DateTimeOffset> value, string propertyName);
+        protected internal static Nullable<decimal> SetValidValue(Nullable<decimal> value);
+        protected internal static Nullable<decimal> SetValidValue(Nullable<decimal> value, string propertyName);
+        protected internal static Nullable<double> SetValidValue(Nullable<double> value);
+        protected internal static Nullable<double> SetValidValue(Nullable<double> value, string propertyName);
+        protected internal static Nullable<Guid> SetValidValue(Nullable<Guid> value);
+        protected internal static Nullable<Guid> SetValidValue(Nullable<Guid> value, string propertyName);
+        protected internal static Nullable<short> SetValidValue(Nullable<short> value);
+        protected internal static Nullable<short> SetValidValue(Nullable<short> value, string propertyName);
+        protected internal static Nullable<int> SetValidValue(Nullable<int> value);
+        protected internal static Nullable<int> SetValidValue(Nullable<int> value, string propertyName);
+        protected internal static Nullable<long> SetValidValue(Nullable<long> value);
+        protected internal static Nullable<long> SetValidValue(Nullable<long> value, string propertyName);
+        protected internal static Nullable<sbyte> SetValidValue(Nullable<sbyte> value);
+        protected internal static Nullable<sbyte> SetValidValue(Nullable<sbyte> value, string propertyName);
+        protected internal static Nullable<float> SetValidValue(Nullable<float> value);
+        protected internal static Nullable<float> SetValidValue(Nullable<float> value, string propertyName);
+        protected internal static Nullable<TimeSpan> SetValidValue(Nullable<TimeSpan> value);
+        protected internal static Nullable<TimeSpan> SetValidValue(Nullable<TimeSpan> value, string propertyName);
+        protected internal static Nullable<ushort> SetValidValue(Nullable<ushort> value);
+        protected internal static Nullable<ushort> SetValidValue(Nullable<ushort> value, string propertyName);
+        protected internal static Nullable<uint> SetValidValue(Nullable<uint> value);
+        protected internal static Nullable<uint> SetValidValue(Nullable<uint> value, string propertyName);
+        protected internal static Nullable<ulong> SetValidValue(Nullable<ulong> value);
+        protected internal static Nullable<ulong> SetValidValue(Nullable<ulong> value, string propertyName);
+        protected internal static sbyte SetValidValue(sbyte value);
+        protected internal static sbyte SetValidValue(sbyte value, string propertyName);
+        protected internal static float SetValidValue(float value);
+        protected internal static float SetValidValue(float value, string propertyName);
+        protected internal static string SetValidValue(string value, bool isNullable);
+        protected internal static string SetValidValue(string value, bool isNullable, string propertyName);
+        protected internal static TimeSpan SetValidValue(TimeSpan value);
+        protected internal static TimeSpan SetValidValue(TimeSpan value, string propertyName);
+        protected internal static ushort SetValidValue(ushort value);
+        protected internal static ushort SetValidValue(ushort value, string propertyName);
+        protected internal static uint SetValidValue(uint value);
+        protected internal static uint SetValidValue(uint value, string propertyName);
+        protected internal static ulong SetValidValue(ulong value);
+        protected internal static ulong SetValidValue(ulong value, string propertyName);
+        protected internal T SetValidValue<T>(T oldValue, T newValue, string property) where T : ComplexObject;
+        protected internal static TComplex VerifyComplexObjectIsNotNull<TComplex>(TComplex complexObject, string propertyName) where TComplex : ComplexObject;
+    }
+}
```

