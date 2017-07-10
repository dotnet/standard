# System.Data.Design

``` diff
+namespace System.Data.Design {
+    public class MethodSignatureGenerator {
+        public MethodSignatureGenerator();
+        public CodeDomProvider CodeProvider { get; set; }
+        public Type ContainerParameterType { get; set; }
+        public string DataSetClassName { get; set; }
+        public bool IsGetMethod { get; set; }
+        public bool PagingMethod { get; set; }
+        public ParameterGenerationOption ParameterOption { get; set; }
+        public string TableClassName { get; set; }
+        public CodeMemberMethod GenerateMethod();
+        public string GenerateMethodSignature();
+        public CodeTypeDeclaration GenerateUpdatingMethods();
+        public void SetDesignTableContent(string designTableContent);
+        public void SetMethodSourceContent(string methodSourceContent);
+    }
+    public enum ParameterGenerationOption {
+        ClrTypes = 0,
+        Objects = 2,
+        SqlTypes = 1,
+    }
+    public sealed class TypedDataSetGenerator {
+        public static ICollection<Assembly> ReferencedAssemblies { get; }
+        public static string Generate(DataSet dataSet, CodeNamespace codeNamespace, CodeDomProvider codeProvider);
+        public static string Generate(string inputFileContent, CodeCompileUnit compileUnit, CodeNamespace mainNamespace, CodeDomProvider codeProvider);
+        public static string Generate(string inputFileContent, CodeCompileUnit compileUnit, CodeNamespace mainNamespace, CodeDomProvider codeProvider, TypedDataSetGenerator.GenerateOption option);
+        public static string Generate(string inputFileContent, CodeCompileUnit compileUnit, CodeNamespace mainNamespace, CodeDomProvider codeProvider, TypedDataSetGenerator.GenerateOption option, string dataSetNamespace);
+        public static string Generate(string inputFileContent, CodeCompileUnit compileUnit, CodeNamespace mainNamespace, CodeDomProvider codeProvider, TypedDataSetGenerator.GenerateOption option, string dataSetNamespace, string basePath);
+        public static void Generate(string inputFileContent, CodeCompileUnit compileUnit, CodeNamespace mainNamespace, CodeDomProvider codeProvider, Hashtable customDBProviders);
+        public static void Generate(string inputFileContent, CodeCompileUnit compileUnit, CodeNamespace mainNamespace, CodeDomProvider codeProvider, Hashtable customDBProviders, TypedDataSetGenerator.GenerateOption option);
+        public static void Generate(string inputFileContent, CodeCompileUnit compileUnit, CodeNamespace mainNamespace, CodeDomProvider codeProvider, Hashtable customDBProviders, TypedDataSetGenerator.GenerateOption option, string dataSetNamespace);
+        public static void Generate(string inputFileContent, CodeCompileUnit compileUnit, CodeNamespace mainNamespace, CodeDomProvider codeProvider, Hashtable customDBProviders, TypedDataSetGenerator.GenerateOption option, string dataSetNamespace, string basePath);
+        public static void Generate(string inputFileContent, CodeCompileUnit compileUnit, CodeNamespace mainNamespace, CodeDomProvider codeProvider, DbProviderFactory specifiedFactory);
+        public static string GetProviderName(string inputFileContent);
+        public static string GetProviderName(string inputFileContent, string tableName);
+        public enum GenerateOption {
+            HierarchicalUpdate = 1,
+            LinqOverTypedDatasets = 2,
+            None = 0,
+        }
+    }
+    public class TypedDataSetGeneratorException : DataException {
+        public TypedDataSetGeneratorException();
+        public TypedDataSetGeneratorException(IList list);
+        protected TypedDataSetGeneratorException(SerializationInfo info, StreamingContext context);
+        public TypedDataSetGeneratorException(string message);
+        public TypedDataSetGeneratorException(string message, Exception innerException);
+        public IList ErrorList { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class TypedDataSetSchemaImporterExtension : SchemaImporterExtension {
+        public TypedDataSetSchemaImporterExtension();
+        protected TypedDataSetSchemaImporterExtension(TypedDataSetGenerator.GenerateOption dataSetGenerateOptions);
+        public override string ImportSchemaType(string name, string namespaceName, XmlSchemaObject context, XmlSchemas schemas, XmlSchemaImporter importer, CodeCompileUnit compileUnit, CodeNamespace mainNamespace, CodeGenerationOptions options, CodeDomProvider codeProvider);
+        public override string ImportSchemaType(XmlSchemaType type, XmlSchemaObject context, XmlSchemas schemas, XmlSchemaImporter importer, CodeCompileUnit compileUnit, CodeNamespace mainNamespace, CodeGenerationOptions options, CodeDomProvider codeProvider);
+    }
+    public class TypedDataSetSchemaImporterExtensionFx35 : TypedDataSetSchemaImporterExtension {
+        public TypedDataSetSchemaImporterExtensionFx35();
+    }
+}
```

