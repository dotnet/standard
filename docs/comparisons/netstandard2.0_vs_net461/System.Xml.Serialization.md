# System.Xml.Serialization

``` diff
 namespace System.Xml.Serialization {
+    public abstract class CodeExporter {
+        public CodeAttributeDeclarationCollection IncludeMetadata { get; }
+    }
+    public abstract class SchemaImporter {
+        public SchemaImporterExtensionCollection Extensions { get; }
+    }
+    public class SoapCodeExporter : CodeExporter {
+        public SoapCodeExporter(CodeNamespace codeNamespace);
+        public SoapCodeExporter(CodeNamespace codeNamespace, CodeCompileUnit codeCompileUnit);
+        public SoapCodeExporter(CodeNamespace codeNamespace, CodeCompileUnit codeCompileUnit, CodeDomProvider codeProvider, CodeGenerationOptions options, Hashtable mappings);
+        public SoapCodeExporter(CodeNamespace codeNamespace, CodeCompileUnit codeCompileUnit, CodeGenerationOptions options);
+        public SoapCodeExporter(CodeNamespace codeNamespace, CodeCompileUnit codeCompileUnit, CodeGenerationOptions options, Hashtable mappings);
+        public void AddMappingMetadata(CodeAttributeDeclarationCollection metadata, XmlMemberMapping member);
+        public void AddMappingMetadata(CodeAttributeDeclarationCollection metadata, XmlMemberMapping member, bool forceUseMemberName);
+        public void ExportMembersMapping(XmlMembersMapping xmlMembersMapping);
+        public void ExportTypeMapping(XmlTypeMapping xmlTypeMapping);
+    }
+    public class SoapSchemaExporter {
+        public SoapSchemaExporter(XmlSchemas schemas);
+        public void ExportMembersMapping(XmlMembersMapping xmlMembersMapping);
+        public void ExportMembersMapping(XmlMembersMapping xmlMembersMapping, bool exportEnclosingType);
+        public void ExportTypeMapping(XmlTypeMapping xmlTypeMapping);
+    }
+    public class SoapSchemaImporter : SchemaImporter {
+        public SoapSchemaImporter(XmlSchemas schemas);
+        public SoapSchemaImporter(XmlSchemas schemas, CodeGenerationOptions options, CodeDomProvider codeProvider, ImportContext context);
+        public SoapSchemaImporter(XmlSchemas schemas, CodeGenerationOptions options, ImportContext context);
+        public SoapSchemaImporter(XmlSchemas schemas, CodeIdentifiers typeIdentifiers);
+        public SoapSchemaImporter(XmlSchemas schemas, CodeIdentifiers typeIdentifiers, CodeGenerationOptions options);
+        public XmlTypeMapping ImportDerivedTypeMapping(XmlQualifiedName name, Type baseType, bool baseTypeCanBeIndirect);
+        public XmlMembersMapping ImportMembersMapping(string name, string ns, SoapSchemaMember member);
+        public XmlMembersMapping ImportMembersMapping(string name, string ns, SoapSchemaMember[] members);
+        public XmlMembersMapping ImportMembersMapping(string name, string ns, SoapSchemaMember[] members, bool hasWrapperElement);
+        public XmlMembersMapping ImportMembersMapping(string name, string ns, SoapSchemaMember[] members, bool hasWrapperElement, Type baseType, bool baseTypeCanBeIndirect);
+    }
+    public class XmlCodeExporter : CodeExporter {
+        public XmlCodeExporter(CodeNamespace codeNamespace);
+        public XmlCodeExporter(CodeNamespace codeNamespace, CodeCompileUnit codeCompileUnit);
+        public XmlCodeExporter(CodeNamespace codeNamespace, CodeCompileUnit codeCompileUnit, CodeDomProvider codeProvider, CodeGenerationOptions options, Hashtable mappings);
+        public XmlCodeExporter(CodeNamespace codeNamespace, CodeCompileUnit codeCompileUnit, CodeGenerationOptions options);
+        public XmlCodeExporter(CodeNamespace codeNamespace, CodeCompileUnit codeCompileUnit, CodeGenerationOptions options, Hashtable mappings);
+        public void AddMappingMetadata(CodeAttributeDeclarationCollection metadata, XmlMemberMapping member, string ns);
+        public void AddMappingMetadata(CodeAttributeDeclarationCollection metadata, XmlMemberMapping member, string ns, bool forceUseMemberName);
+        public void AddMappingMetadata(CodeAttributeDeclarationCollection metadata, XmlTypeMapping mapping, string ns);
+        public void ExportMembersMapping(XmlMembersMapping xmlMembersMapping);
+        public void ExportTypeMapping(XmlTypeMapping xmlTypeMapping);
+    }
     public class XmlMemberMapping {
+        public string GenerateTypeName(CodeDomProvider codeProvider);
     }
-    public class XmlSchemaImporter {
+    public class XmlSchemaImporter : SchemaImporter {
+        public XmlSchemaImporter(XmlSchemas schemas, CodeGenerationOptions options, CodeDomProvider codeProvider, ImportContext context);
+        public XmlSchemaImporter(XmlSchemas schemas, CodeGenerationOptions options, ImportContext context);
+        public XmlSchemaImporter(XmlSchemas schemas, CodeIdentifiers typeIdentifiers, CodeGenerationOptions options);
     }
     public class XmlSerializer {
+        public XmlSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace, string location, Evidence evidence);
+        public static XmlSerializer[] FromMappings(XmlMapping[] mappings, Evidence evidence);
+        public static Assembly GenerateSerializer(Type[] types, XmlMapping[] mappings);
+        public static Assembly GenerateSerializer(Type[] types, XmlMapping[] mappings, CompilerParameters parameters);
     }
     public class XmlSerializerFactory {
+        public XmlSerializer CreateSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace, string location, Evidence evidence);
     }
 }
```

