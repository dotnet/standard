# System.Data.Services.Design

``` diff
+namespace System.Data.Services.Design {
+    public enum DataServiceCodeVersion {
+        V1 = 0,
+        V2 = 1,
+    }
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
+        public bool UseDataServiceCollection { get; set; }
+        public DataServiceCodeVersion Version { get; set; }
+        public event EventHandler<PropertyGeneratedEventArgs> OnPropertyGenerated;
+        public event EventHandler<TypeGeneratedEventArgs> OnTypeGenerated;
+        public IList<EdmSchemaError> GenerateCode(XmlReader sourceReader, TextWriter targetWriter, string namespacePrefix);
+        public IList<EdmSchemaError> GenerateCode(XmlReader sourceReader, string targetFilePath);
+    }
+    public enum LanguageOption {
+        GenerateCSharpCode = 0,
+        GenerateVBCode = 1,
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
+    public sealed class TypeGeneratedEventArgs : EventArgs {
+        public TypeGeneratedEventArgs();
+        public TypeGeneratedEventArgs(GlobalItem typeSource, CodeTypeReference baseType);
+        public List<CodeAttributeDeclaration> AdditionalAttributes { get; }
+        public List<Type> AdditionalInterfaces { get; }
+        public List<CodeTypeMember> AdditionalMembers { get; }
+        public CodeTypeReference BaseType { get; set; }
+        public GlobalItem TypeSource { get; }
+    }
+}
```

