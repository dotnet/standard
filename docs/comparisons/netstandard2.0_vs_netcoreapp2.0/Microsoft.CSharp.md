# Microsoft.CSharp

``` diff
+namespace Microsoft.CSharp {
+    public class CSharpCodeProvider : CodeDomProvider {
+        public CSharpCodeProvider();
+        public CSharpCodeProvider(IDictionary<string, string> providerOptions);
+        public override string FileExtension { get; }
+        public override ICodeCompiler CreateCompiler();
+        public override ICodeGenerator CreateGenerator();
+        public override void GenerateCodeFromMember(CodeTypeMember member, TextWriter writer, CodeGeneratorOptions options);
+        public override TypeConverter GetConverter(Type type);
+    }
+}
```

