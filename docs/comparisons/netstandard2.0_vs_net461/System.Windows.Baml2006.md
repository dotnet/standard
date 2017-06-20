# System.Windows.Baml2006

``` diff
+namespace System.Windows.Baml2006 {
+    public class Baml2006Reader : XamlReader, IFreezeFreezables, IXamlLineInfo {
+        public Baml2006Reader(Stream stream);
+        public Baml2006Reader(Stream stream, XamlReaderSettings xamlReaderSettings);
+        public Baml2006Reader(string fileName);
+        public override bool IsEof { get; }
+        public override XamlMember Member { get; }
+        public override NamespaceDeclaration Namespace { get; }
+        public override XamlNodeType NodeType { get; }
+        public override XamlSchemaContext SchemaContext { get; }
+        bool System.Xaml.IXamlLineInfo.HasLineInfo { get; }
+        int System.Xaml.IXamlLineInfo.LineNumber { get; }
+        int System.Xaml.IXamlLineInfo.LinePosition { get; }
+        public override XamlType Type { get; }
+        public override object Value { get; }
+        protected override void Dispose(bool disposing);
+        public override bool Read();
+    }
+}
```

