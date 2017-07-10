# System.Data.Entity.Design

``` diff
+namespace System.Data.Entity.Design {
+    public class EdmToObjectNamespaceMap {
+        public int Count { get; }
+        public ICollection<string> EdmNamespaces { get; }
+        public string this[string edmNamespace] { get; set; }
+        public void Add(string edmNamespace, string objectNamespace);
+        public void Clear();
+        public bool Contains(string edmNamespace);
+        public bool Remove(string edmNamespace);
+        public bool TryGetObjectNamespace(string edmNamespace, out string objectNamespace);
+    }
+    public sealed class EntityClassGenerator {
+        public EntityClassGenerator();
+        public EntityClassGenerator(LanguageOption languageOption);
+        public EdmToObjectNamespaceMap EdmToObjectNamespaceMap { get; }
+        public LanguageOption LanguageOption { get; set; }
+        public event PropertyGeneratedEventHandler OnPropertyGenerated;
+        public event TypeGeneratedEventHandler OnTypeGenerated;
+        public IList<EdmSchemaError> GenerateCode(string sourceEdmSchemaFilePath, string targetFilePath);
+        public IList<EdmSchemaError> GenerateCode(string sourceEdmSchemaFilePath, string targetPath, IEnumerable<string> additionalEdmSchemaFilePaths);
+        public IList<EdmSchemaError> GenerateCode(XmlReader sourceEdmSchema, TextWriter target);
+        public IList<EdmSchemaError> GenerateCode(XmlReader sourceEdmSchema, TextWriter target, IEnumerable<XmlReader> additionalEdmSchemas);
+    }
+    public class EntityCodeGenerator {
+        public EntityCodeGenerator(LanguageOption languageOption);
+        public EdmToObjectNamespaceMap EdmToObjectNamespaceMap { get; }
+        public LanguageOption LanguageOption { get; set; }
+        public IList<EdmSchemaError> GenerateCode(string sourceEdmSchemaFilePath, string targetPath);
+        public IList<EdmSchemaError> GenerateCode(string sourceEdmSchemaFilePath, string targetPath, IEnumerable<string> additionalEdmSchemaFilePaths);
+        public IList<EdmSchemaError> GenerateCode(string sourceEdmSchemaFilePath, string targetPath, IEnumerable<string> additionalEdmSchemaFilePaths, Version targetEntityFrameworkVersion);
+        public IList<EdmSchemaError> GenerateCode(string sourceEdmSchemaFilePath, string targetPath, Version targetEntityFrameworkVersion);
+        public IList<EdmSchemaError> GenerateCode(XmlReader sourceEdmSchema, TextWriter target);
+        public IList<EdmSchemaError> GenerateCode(XmlReader sourceEdmSchema, TextWriter target, IEnumerable<XmlReader> additionalEdmSchemas);
+        public IList<EdmSchemaError> GenerateCode(XmlReader sourceEdmSchema, TextWriter target, IEnumerable<XmlReader> additionalEdmSchemas, Version targetEntityFrameworkVersion);
+        public IList<EdmSchemaError> GenerateCode(XmlReader sourceEdmSchema, TextWriter target, Version targetEntityFrameworkVersion);
+    }
+    public static class EntityFrameworkVersions {
+        public static readonly Version Version1;
+        public static readonly Version Version2;
+        public static readonly Version Version3;
+        public static Stream GetSchemaXsd(Version entityFrameworkVersion, DataSpace dataSpace);
+    }
+    public sealed class EntityModelSchemaGenerator {
+        public EntityModelSchemaGenerator(EntityContainer storeEntityContainer);
+        public EntityModelSchemaGenerator(EntityContainer storeEntityContainer, string namespaceName, string modelEntityContainerName);
+        public EntityModelSchemaGenerator(StoreItemCollection storeItemCollection, string namespaceName, string modelEntityContainerName);
+        public EdmItemCollection EdmItemCollection { get; }
+        public EntityContainer EntityContainer { get; }
+        public bool GenerateForeignKeyProperties { get; set; }
+        public PluralizationService PluralizationService { get; set; }
+        public IList<EdmSchemaError> GenerateMetadata();
+        public IList<EdmSchemaError> GenerateMetadata(Version targetEntityFrameworkVersion);
+        public void WriteModelSchema(string outputFileName);
+        public void WriteModelSchema(XmlWriter writer);
+        public void WriteStorageMapping(string outputFileName);
+        public void WriteStorageMapping(XmlWriter writer);
+    }
+    public enum EntityStoreSchemaFilterEffect {
+        Allow = 0,
+        Exclude = 1,
+    }
+    public class EntityStoreSchemaFilterEntry {
+        public EntityStoreSchemaFilterEntry(string catalog, string schema, string name);
+        public EntityStoreSchemaFilterEntry(string catalog, string schema, string name, EntityStoreSchemaFilterObjectTypes types, EntityStoreSchemaFilterEffect effect);
+        public string Catalog { get; }
+        public EntityStoreSchemaFilterEffect Effect { get; }
+        public string Name { get; }
+        public string Schema { get; }
+        public EntityStoreSchemaFilterObjectTypes Types { get; }
+    }
+    public enum EntityStoreSchemaFilterObjectTypes {
+        All = 7,
+        Function = 4,
+        None = 0,
+        Table = 1,
+        View = 2,
+    }
+    public sealed class EntityStoreSchemaGenerator {
+        public EntityStoreSchemaGenerator(string providerInvariantName, string connectionString, string namespaceName);
+        public EntityContainer EntityContainer { get; }
+        public bool GenerateForeignKeyProperties { get; set; }
+        public StoreItemCollection StoreItemCollection { get; }
+        public static EntityConnection CreateStoreSchemaConnection(string providerInvariantName, string connectionString);
+        public static EntityConnection CreateStoreSchemaConnection(string providerInvariantName, string connectionString, Version targetEntityFrameworkVersion);
+        public IList<EdmSchemaError> GenerateStoreMetadata();
+        public IList<EdmSchemaError> GenerateStoreMetadata(IEnumerable<EntityStoreSchemaFilterEntry> filters);
+        public IList<EdmSchemaError> GenerateStoreMetadata(IEnumerable<EntityStoreSchemaFilterEntry> filters, Version targetEntityFrameworkVersion);
+        public void WriteStoreSchema(string outputFileName);
+        public void WriteStoreSchema(XmlWriter writer);
+    }
+    public class EntityViewGenerator {
+        public EntityViewGenerator();
+        public EntityViewGenerator(LanguageOption languageOption);
+        public LanguageOption LanguageOption { get; set; }
+        public IList<EdmSchemaError> GenerateViews(StorageMappingItemCollection mappingCollection, TextWriter outputWriter);
+        public IList<EdmSchemaError> GenerateViews(StorageMappingItemCollection mappingCollection, TextWriter outputWriter, Version targetEntityFrameworkVersion);
+        public IList<EdmSchemaError> GenerateViews(StorageMappingItemCollection mappingCollection, string outputPath);
+        public static IList<EdmSchemaError> Validate(StorageMappingItemCollection mappingCollection);
+        public static IList<EdmSchemaError> Validate(StorageMappingItemCollection mappingCollection, Version targetEntityFrameworkVersion);
+    }
+    public enum LanguageOption {
+        GenerateCSharpCode = 0,
+        GenerateVBCode = 1,
+    }
+    public static class MetadataExtensionMethods {
+        public static ReadOnlyCollection<PrimitiveType> GetPrimitiveTypes(this EdmItemCollection itemCollection, Version edmVersion);
+    }
+    public static class MetadataItemCollectionFactory {
+        public static EdmItemCollection CreateEdmItemCollection(IEnumerable<XmlReader> readers, out IList<EdmSchemaError> errors);
+        public static EdmItemCollection CreateEdmItemCollection(IEnumerable<XmlReader> readers, Version targetEntityFrameworkVersion, out IList<EdmSchemaError> errors);
+        public static StorageMappingItemCollection CreateStorageMappingItemCollection(EdmItemCollection edmCollection, StoreItemCollection storeCollection, IEnumerable<XmlReader> readers, out IList<EdmSchemaError> errors);
+        public static StorageMappingItemCollection CreateStorageMappingItemCollection(EdmItemCollection edmCollection, StoreItemCollection storeCollection, IEnumerable<XmlReader> readers, Version targetEntityFrameworkVersion, out IList<EdmSchemaError> errors);
+        public static StoreItemCollection CreateStoreItemCollection(IEnumerable<XmlReader> readers, out IList<EdmSchemaError> errors);
+        public static StoreItemCollection CreateStoreItemCollection(IEnumerable<XmlReader> readers, Version targetEntityFrameworkVersion, out IList<EdmSchemaError> errors);
+    }
+    public sealed class PropertyGeneratedEventArgs : EventArgs {
+        public PropertyGeneratedEventArgs();
+        public PropertyGeneratedEventArgs(MetadataItem propertySource, string backingFieldName, CodeTypeReference returnType);
+        public List<CodeAttributeDeclaration> AdditionalAttributes { get; }
+        public List<CodeStatement> AdditionalGetStatements { get; }
+        public List<CodeStatement> AdditionalSetStatements { get; }
+        public string BackingFieldName { get; }
+        public MetadataItem PropertySource { get; }
+        public CodeTypeReference ReturnType { get; set; }
+    }
+    public delegate void PropertyGeneratedEventHandler(object sender, PropertyGeneratedEventArgs e);
+    public sealed class TypeGeneratedEventArgs : EventArgs {
+        public TypeGeneratedEventArgs();
+        public TypeGeneratedEventArgs(GlobalItem typeSource, CodeTypeReference baseType);
+        public List<CodeAttributeDeclaration> AdditionalAttributes { get; }
+        public List<Type> AdditionalInterfaces { get; }
+        public List<CodeTypeMember> AdditionalMembers { get; }
+        public CodeTypeReference BaseType { get; set; }
+        public GlobalItem TypeSource { get; }
+    }
+    public delegate void TypeGeneratedEventHandler(object sender, TypeGeneratedEventArgs e);
+}
```

