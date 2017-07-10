# System.Xml.Serialization.Advanced

``` diff
+namespace System.Xml.Serialization.Advanced {
+    public abstract class SchemaImporterExtension {
+        protected SchemaImporterExtension();
+        public virtual string ImportAnyElement(XmlSchemaAny any, bool mixed, XmlSchemas schemas, XmlSchemaImporter importer, CodeCompileUnit compileUnit, CodeNamespace mainNamespace, CodeGenerationOptions options, CodeDomProvider codeProvider);
+        public virtual CodeExpression ImportDefaultValue(string value, string type);
+        public virtual string ImportSchemaType(string name, string ns, XmlSchemaObject context, XmlSchemas schemas, XmlSchemaImporter importer, CodeCompileUnit compileUnit, CodeNamespace mainNamespace, CodeGenerationOptions options, CodeDomProvider codeProvider);
+        public virtual string ImportSchemaType(XmlSchemaType type, XmlSchemaObject context, XmlSchemas schemas, XmlSchemaImporter importer, CodeCompileUnit compileUnit, CodeNamespace mainNamespace, CodeGenerationOptions options, CodeDomProvider codeProvider);
+    }
+    public class SchemaImporterExtensionCollection : CollectionBase {
+        public SchemaImporterExtensionCollection();
+        public SchemaImporterExtension this[int index] { get; set; }
+        public int Add(string name, Type type);
+        public int Add(SchemaImporterExtension extension);
+        public new void Clear();
+        public bool Contains(SchemaImporterExtension extension);
+        public void CopyTo(SchemaImporterExtension[] array, int index);
+        public int IndexOf(SchemaImporterExtension extension);
+        public void Insert(int index, SchemaImporterExtension extension);
+        public void Remove(string name);
+        public void Remove(SchemaImporterExtension extension);
+    }
+}
```

