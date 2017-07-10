# System.Runtime.Serialization

``` diff
 namespace System.Runtime.Serialization {
     public sealed class DataContractSerializer : XmlObjectSerializer {
+        public DataContractSerializer(Type type, IEnumerable<Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, IDataContractSurrogate dataContractSurrogate);
+        public DataContractSerializer(Type type, IEnumerable<Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, IDataContractSurrogate dataContractSurrogate, DataContractResolver dataContractResolver);
+        public DataContractSerializer(Type type, string rootName, string rootNamespace, IEnumerable<Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, IDataContractSurrogate dataContractSurrogate);
+        public DataContractSerializer(Type type, string rootName, string rootNamespace, IEnumerable<Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, IDataContractSurrogate dataContractSurrogate, DataContractResolver dataContractResolver);
+        public DataContractSerializer(Type type, XmlDictionaryString rootName, XmlDictionaryString rootNamespace, IEnumerable<Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, IDataContractSurrogate dataContractSurrogate);
+        public DataContractSerializer(Type type, XmlDictionaryString rootName, XmlDictionaryString rootNamespace, IEnumerable<Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, IDataContractSurrogate dataContractSurrogate, DataContractResolver dataContractResolver);
+        public IDataContractSurrogate DataContractSurrogate { get; }
     }
-    public static class DataContractSerializerExtensions {
 {
-        public static ISerializationSurrogateProvider GetSerializationSurrogateProvider(this DataContractSerializer serializer);

-        public static void SetSerializationSurrogateProvider(this DataContractSerializer serializer, ISerializationSurrogateProvider provider);

-    }
     public class DataContractSerializerSettings {
+        public IDataContractSurrogate DataContractSurrogate { get; set; }
     }
     public class ExportOptions {
+        public IDataContractSurrogate DataContractSurrogate { get; set; }
     }
+    public interface IDataContractSurrogate {
+        object GetCustomDataToExport(MemberInfo memberInfo, Type dataContractType);
+        object GetCustomDataToExport(Type clrType, Type dataContractType);
+        Type GetDataContractType(Type type);
+        object GetDeserializedObject(object obj, Type targetType);
+        void GetKnownCustomDataTypes(Collection<Type> customDataTypes);
+        object GetObjectToSerialize(object obj, Type targetType);
+        Type GetReferencedTypeOnImport(string typeName, string typeNamespace, object customData);
+        CodeTypeDeclaration ProcessImportedType(CodeTypeDeclaration typeDeclaration, CodeCompileUnit compileUnit);
+    }
+    public class ImportOptions {
+        public ImportOptions();
+        public CodeDomProvider CodeProvider { get; set; }
+        public IDataContractSurrogate DataContractSurrogate { get; set; }
+        public bool EnableDataBinding { get; set; }
+        public bool GenerateInternal { get; set; }
+        public bool GenerateSerializable { get; set; }
+        public bool ImportXmlType { get; set; }
+        public IDictionary<string, string> Namespaces { get; }
+        public ICollection<Type> ReferencedCollectionTypes { get; }
+        public ICollection<Type> ReferencedTypes { get; }
+    }
-    public interface ISerializationSurrogateProvider {
 {
-        object GetDeserializedObject(object obj, Type targetType);

-        object GetObjectToSerialize(object obj, Type targetType);

-        Type GetSurrogateType(Type type);

-    }
+    public sealed class NetDataContractSerializer : XmlObjectSerializer, IFormatter {
+        public NetDataContractSerializer();
+        public NetDataContractSerializer(StreamingContext context);
+        public NetDataContractSerializer(StreamingContext context, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, FormatterAssemblyStyle assemblyFormat, ISurrogateSelector surrogateSelector);
+        public NetDataContractSerializer(string rootName, string rootNamespace);
+        public NetDataContractSerializer(string rootName, string rootNamespace, StreamingContext context, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, FormatterAssemblyStyle assemblyFormat, ISurrogateSelector surrogateSelector);
+        public NetDataContractSerializer(XmlDictionaryString rootName, XmlDictionaryString rootNamespace);
+        public NetDataContractSerializer(XmlDictionaryString rootName, XmlDictionaryString rootNamespace, StreamingContext context, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, FormatterAssemblyStyle assemblyFormat, ISurrogateSelector surrogateSelector);
+        public FormatterAssemblyStyle AssemblyFormat { get; set; }
+        public SerializationBinder Binder { get; set; }
+        public StreamingContext Context { get; set; }
+        public bool IgnoreExtensionDataObject { get; }
+        public int MaxItemsInObjectGraph { get; }
+        public ISurrogateSelector SurrogateSelector { get; set; }
+        public object Deserialize(Stream stream);
+        public override bool IsStartObject(XmlDictionaryReader reader);
+        public override bool IsStartObject(XmlReader reader);
+        public override object ReadObject(XmlDictionaryReader reader, bool verifyObjectName);
+        public override object ReadObject(XmlReader reader);
+        public override object ReadObject(XmlReader reader, bool verifyObjectName);
+        public void Serialize(Stream stream, object graph);
+        public override void WriteEndObject(XmlDictionaryWriter writer);
+        public override void WriteEndObject(XmlWriter writer);
+        public override void WriteObject(XmlWriter writer, object graph);
+        public override void WriteObjectContent(XmlDictionaryWriter writer, object graph);
+        public override void WriteObjectContent(XmlWriter writer, object graph);
+        public override void WriteStartObject(XmlDictionaryWriter writer, object graph);
+        public override void WriteStartObject(XmlWriter writer, object graph);
+    }
+    public class XsdDataContractImporter {
+        public XsdDataContractImporter();
+        public XsdDataContractImporter(CodeCompileUnit codeCompileUnit);
+        public CodeCompileUnit CodeCompileUnit { get; }
+        public ImportOptions Options { get; set; }
+        public bool CanImport(XmlSchemaSet schemas);
+        public bool CanImport(XmlSchemaSet schemas, ICollection<XmlQualifiedName> typeNames);
+        public bool CanImport(XmlSchemaSet schemas, XmlSchemaElement element);
+        public bool CanImport(XmlSchemaSet schemas, XmlQualifiedName typeName);
+        public CodeTypeReference GetCodeTypeReference(XmlQualifiedName typeName);
+        public CodeTypeReference GetCodeTypeReference(XmlQualifiedName typeName, XmlSchemaElement element);
+        public ICollection<CodeTypeReference> GetKnownTypeReferences(XmlQualifiedName typeName);
+        public void Import(XmlSchemaSet schemas);
+        public void Import(XmlSchemaSet schemas, ICollection<XmlQualifiedName> typeNames);
+        public XmlQualifiedName Import(XmlSchemaSet schemas, XmlSchemaElement element);
+        public void Import(XmlSchemaSet schemas, XmlQualifiedName typeName);
+    }
 }
```

