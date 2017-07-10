# System.Data.SqlTypes

``` diff
 namespace System.Data.SqlTypes {
+    public sealed class SqlFileStream : Stream {
+        public SqlFileStream(string path, byte[] transactionContext, FileAccess access);
+        public SqlFileStream(string path, byte[] transactionContext, FileAccess access, FileOptions options, long allocationSize);
+        public override bool CanRead { get; }
+        public override bool CanSeek { get; }
+        public override bool CanTimeout { get; }
+        public override bool CanWrite { get; }
+        public override long Length { get; }
+        public string Name { get; private set; }
+        public override long Position { get; set; }
+        public override int ReadTimeout { get; set; }
+        public byte[] TransactionContext { get; private set; }
+        public override int WriteTimeout { get; set; }
+        public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state);
+        public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state);
+        protected override void Dispose(bool disposing);
+        public override int EndRead(IAsyncResult asyncResult);
+        public override void EndWrite(IAsyncResult asyncResult);
+        ~SqlFileStream();
+        public override void Flush();
+        public override int Read(byte[] buffer, int offset, int count);
+        public override int ReadByte();
+        public override long Seek(long offset, SeekOrigin origin);
+        public override void SetLength(long value);
+        public override void Write(byte[] buffer, int offset, int count);
+        public override void WriteByte(byte value);
+    }
+    public class SqlTypesSchemaImporterExtensionHelper : SchemaImporterExtension {
+        protected static readonly string SqlTypesNamespace;
+        public SqlTypesSchemaImporterExtensionHelper(string name, string destinationType);
+        public SqlTypesSchemaImporterExtensionHelper(string name, string destinationType, bool direct);
+        public SqlTypesSchemaImporterExtensionHelper(string name, string targetNamespace, string[] references, CodeNamespaceImport[] namespaceImports, string destinationType, bool direct);
+        public override string ImportSchemaType(string name, string xmlNamespace, XmlSchemaObject context, XmlSchemas schemas, XmlSchemaImporter importer, CodeCompileUnit compileUnit, CodeNamespace mainNamespace, CodeGenerationOptions options, CodeDomProvider codeProvider);
+        public override string ImportSchemaType(XmlSchemaType type, XmlSchemaObject context, XmlSchemas schemas, XmlSchemaImporter importer, CodeCompileUnit compileUnit, CodeNamespace mainNamespace, CodeGenerationOptions options, CodeDomProvider codeProvider);
+    }
+    public sealed class TypeBigIntSchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper {
+        public TypeBigIntSchemaImporterExtension();
+    }
+    public sealed class TypeBinarySchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper {
+        public TypeBinarySchemaImporterExtension();
+    }
+    public sealed class TypeBitSchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper {
+        public TypeBitSchemaImporterExtension();
+    }
+    public sealed class TypeCharSchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper {
+        public TypeCharSchemaImporterExtension();
+    }
+    public sealed class TypeDateTimeSchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper {
+        public TypeDateTimeSchemaImporterExtension();
+    }
+    public sealed class TypeDecimalSchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper {
+        public TypeDecimalSchemaImporterExtension();
+    }
+    public sealed class TypeFloatSchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper {
+        public TypeFloatSchemaImporterExtension();
+    }
+    public sealed class TypeIntSchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper {
+        public TypeIntSchemaImporterExtension();
+    }
+    public sealed class TypeMoneySchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper {
+        public TypeMoneySchemaImporterExtension();
+    }
+    public sealed class TypeNCharSchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper {
+        public TypeNCharSchemaImporterExtension();
+    }
+    public sealed class TypeNTextSchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper {
+        public TypeNTextSchemaImporterExtension();
+    }
+    public sealed class TypeNumericSchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper {
+        public TypeNumericSchemaImporterExtension();
+    }
+    public sealed class TypeNVarCharSchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper {
+        public TypeNVarCharSchemaImporterExtension();
+    }
+    public sealed class TypeRealSchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper {
+        public TypeRealSchemaImporterExtension();
+    }
+    public sealed class TypeSmallDateTimeSchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper {
+        public TypeSmallDateTimeSchemaImporterExtension();
+    }
+    public sealed class TypeSmallIntSchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper {
+        public TypeSmallIntSchemaImporterExtension();
+    }
+    public sealed class TypeSmallMoneySchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper {
+        public TypeSmallMoneySchemaImporterExtension();
+    }
+    public sealed class TypeTextSchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper {
+        public TypeTextSchemaImporterExtension();
+    }
+    public sealed class TypeTinyIntSchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper {
+        public TypeTinyIntSchemaImporterExtension();
+    }
+    public sealed class TypeUniqueIdentifierSchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper {
+        public TypeUniqueIdentifierSchemaImporterExtension();
+    }
+    public sealed class TypeVarBinarySchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper {
+        public TypeVarBinarySchemaImporterExtension();
+    }
+    public sealed class TypeVarCharSchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper {
+        public TypeVarCharSchemaImporterExtension();
+    }
+    public sealed class TypeVarImageSchemaImporterExtension : SqlTypesSchemaImporterExtensionHelper {
+        public TypeVarImageSchemaImporterExtension();
+    }
 }
```

