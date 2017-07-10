# System.Data.Common

``` diff
 namespace System.Data.Common {
+    public class DataRecordInfo {
+        public DataRecordInfo(TypeUsage metadata, IEnumerable<EdmMember> memberInfo);
+        public ReadOnlyCollection<FieldMetadata> FieldMetadata { get; }
+        public TypeUsage RecordType { get; }
+    }
-    public abstract class DbColumn {
 {
-        protected DbColumn();

-        public Nullable<bool> AllowDBNull { get; protected set; }

-        public string BaseCatalogName { get; protected set; }

-        public string BaseColumnName { get; protected set; }

-        public string BaseSchemaName { get; protected set; }

-        public string BaseServerName { get; protected set; }

-        public string BaseTableName { get; protected set; }

-        public string ColumnName { get; protected set; }

-        public Nullable<int> ColumnOrdinal { get; protected set; }

-        public Nullable<int> ColumnSize { get; protected set; }

-        public Type DataType { get; protected set; }

-        public string DataTypeName { get; protected set; }

-        public Nullable<bool> IsAliased { get; protected set; }

-        public Nullable<bool> IsAutoIncrement { get; protected set; }

-        public Nullable<bool> IsExpression { get; protected set; }

-        public Nullable<bool> IsHidden { get; protected set; }

-        public Nullable<bool> IsIdentity { get; protected set; }

-        public Nullable<bool> IsKey { get; protected set; }

-        public Nullable<bool> IsLong { get; protected set; }

-        public Nullable<bool> IsReadOnly { get; protected set; }

-        public Nullable<bool> IsUnique { get; protected set; }

-        public Nullable<int> NumericPrecision { get; protected set; }

-        public Nullable<int> NumericScale { get; protected set; }

-        public virtual object this[string property] { get; }

-        public string UdtAssemblyQualifiedName { get; protected set; }

-    }
+    public class DbCommandDefinition {
+        protected DbCommandDefinition();
+        protected DbCommandDefinition(DbCommand prototype);
+        public virtual DbCommand CreateCommand();
+    }
+    public abstract class DBDataPermission : CodeAccessPermission, IUnrestrictedPermission {
+        protected DBDataPermission();
+        protected DBDataPermission(DBDataPermission permission);
+        protected DBDataPermission(DBDataPermissionAttribute permissionAttribute);
+        protected DBDataPermission(PermissionState state);
+        protected DBDataPermission(PermissionState state, bool allowBlankPassword);
+        public bool AllowBlankPassword { get; set; }
+        public virtual void Add(string connectionString, string restrictions, KeyRestrictionBehavior behavior);
+        protected void Clear();
+        public override IPermission Copy();
+        protected virtual DBDataPermission CreateInstance();
+        public override void FromXml(SecurityElement securityElement);
+        public override IPermission Intersect(IPermission target);
+        public override bool IsSubsetOf(IPermission target);
+        public bool IsUnrestricted();
+        public override SecurityElement ToXml();
+        public override IPermission Union(IPermission target);
+    }
+    public abstract class DBDataPermissionAttribute : CodeAccessSecurityAttribute {
+        protected DBDataPermissionAttribute(SecurityAction action);
+        public bool AllowBlankPassword { get; set; }
+        public string ConnectionString { get; set; }
+        public KeyRestrictionBehavior KeyRestrictionBehavior { get; set; }
+        public string KeyRestrictions { get; set; }
+        public bool ShouldSerializeConnectionString();
+        public bool ShouldSerializeKeyRestrictions();
+    }
-    public static class DbDataReaderExtensions {
 {
-        public static bool CanGetColumnSchema(this DbDataReader reader);

-        public static ReadOnlyCollection<DbColumn> GetColumnSchema(this DbDataReader reader);

-    }
+    public class DbProviderConfigurationHandler : IConfigurationSectionHandler {
+        public DbProviderConfigurationHandler();
+        public virtual object Create(object parent, object configContext, XmlNode section);
+    }
+    public static class DbProviderFactories {
+        public static DbProviderFactory GetFactory(DbConnection connection);
+        public static DbProviderFactory GetFactory(DataRow providerRow);
+        public static DbProviderFactory GetFactory(string providerInvariantName);
+        public static DataTable GetFactoryClasses();
+    }
+    public class DbProviderFactoriesConfigurationHandler : IConfigurationSectionHandler {
+        public DbProviderFactoriesConfigurationHandler();
+        public virtual object Create(object parent, object configContext, XmlNode section);
+    }
     public abstract class DbProviderFactory {
+        public virtual CodeAccessPermission CreatePermission(PermissionState state);
     }
+    public abstract class DbProviderManifest {
+        public static readonly string ConceptualSchemaDefinition;
+        public static readonly string ConceptualSchemaDefinitionVersion3;
+        public static readonly string StoreSchemaDefinition;
+        public static readonly string StoreSchemaDefinitionVersion3;
+        public static readonly string StoreSchemaMapping;
+        public static readonly string StoreSchemaMappingVersion3;
+        protected DbProviderManifest();
+        public abstract string NamespaceName { get; }
+        public virtual string EscapeLikeArgument(string argument);
+        protected abstract XmlReader GetDbInformation(string informationType);
+        public abstract TypeUsage GetEdmType(TypeUsage storeType);
+        public abstract ReadOnlyCollection<FacetDescription> GetFacetDescriptions(EdmType edmType);
+        public XmlReader GetInformation(string informationType);
+        public abstract ReadOnlyCollection<EdmFunction> GetStoreFunctions();
+        public abstract TypeUsage GetStoreType(TypeUsage edmType);
+        public abstract ReadOnlyCollection<PrimitiveType> GetStoreTypes();
+        public virtual bool SupportsEscapingLikeArgument(out char escapeCharacter);
+    }
+    public abstract class DbProviderServices {
+        protected DbProviderServices();
+        public DbCommandDefinition CreateCommandDefinition(DbCommandTree commandTree);
+        public virtual DbCommandDefinition CreateCommandDefinition(DbCommand prototype);
+        public DbCommandDefinition CreateCommandDefinition(DbProviderManifest providerManifest, DbCommandTree commandTree);
+        public void CreateDatabase(DbConnection connection, Nullable<int> commandTimeout, StoreItemCollection storeItemCollection);
+        public string CreateDatabaseScript(string providerManifestToken, StoreItemCollection storeItemCollection);
+        protected abstract DbCommandDefinition CreateDbCommandDefinition(DbProviderManifest providerManifest, DbCommandTree commandTree);
+        public bool DatabaseExists(DbConnection connection, Nullable<int> commandTimeout, StoreItemCollection storeItemCollection);
+        protected virtual void DbCreateDatabase(DbConnection connection, Nullable<int> commandTimeout, StoreItemCollection storeItemCollection);
+        protected virtual string DbCreateDatabaseScript(string providerManifestToken, StoreItemCollection storeItemCollection);
+        protected virtual bool DbDatabaseExists(DbConnection connection, Nullable<int> commandTimeout, StoreItemCollection storeItemCollection);
+        protected virtual void DbDeleteDatabase(DbConnection connection, Nullable<int> commandTimeout, StoreItemCollection storeItemCollection);
+        protected virtual DbSpatialServices DbGetSpatialServices(string manifestToken);
+        public void DeleteDatabase(DbConnection connection, Nullable<int> commandTimeout, StoreItemCollection storeItemCollection);
+        protected abstract DbProviderManifest GetDbProviderManifest(string manifestToken);
+        protected abstract string GetDbProviderManifestToken(DbConnection connection);
+        protected virtual DbSpatialDataReader GetDbSpatialDataReader(DbDataReader fromReader, string manifestToken);
+        public static DbProviderFactory GetProviderFactory(DbConnection connection);
+        public DbProviderManifest GetProviderManifest(string manifestToken);
+        public string GetProviderManifestToken(DbConnection connection);
+        public static DbProviderServices GetProviderServices(DbConnection connection);
+        public DbSpatialDataReader GetSpatialDataReader(DbDataReader fromReader, string manifestToken);
+        public DbSpatialServices GetSpatialServices(string manifestToken);
+        protected virtual void SetDbParameterValue(DbParameter parameter, TypeUsage parameterType, object value);
+    }
+    public abstract class DbXmlEnabledProviderManifest : DbProviderManifest {
+        protected DbXmlEnabledProviderManifest(XmlReader reader);
+        public override string NamespaceName { get; }
+        protected Dictionary<string, PrimitiveType> StoreTypeNameToEdmPrimitiveType { get; }
+        protected Dictionary<string, PrimitiveType> StoreTypeNameToStorePrimitiveType { get; }
+        public override ReadOnlyCollection<FacetDescription> GetFacetDescriptions(EdmType type);
+        public override ReadOnlyCollection<EdmFunction> GetStoreFunctions();
+        public override ReadOnlyCollection<PrimitiveType> GetStoreTypes();
+    }
+    public class EntityRecordInfo : DataRecordInfo {
+        public EntityRecordInfo(EntityType metadata, IEnumerable<EdmMember> memberInfo, EntityKey entityKey, EntitySet entitySet);
+        public EntityKey EntityKey { get; }
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct FieldMetadata {
+        public FieldMetadata(int ordinal, EdmMember fieldType);
+        public EdmMember FieldType { get; }
+        public int Ordinal { get; }
+    }
-    public interface IDbColumnSchemaGenerator {
 {
-        ReadOnlyCollection<DbColumn> GetColumnSchema();

-    }
 }
```

