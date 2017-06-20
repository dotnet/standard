# System.Xml.Xsl

``` diff
 namespace System.Xml.Xsl {
     public sealed class XslCompiledTransform {
+        public TempFileCollection TemporaryFiles { get; }
+        public static CompilerErrorCollection CompileToType(XmlReader stylesheet, XsltSettings settings, XmlResolver stylesheetResolver, bool debug, TypeBuilder typeBuilder, string scriptAssemblyPath);
     }
     public sealed class XslTransform {
+        public void Load(XmlReader stylesheet, XmlResolver resolver, Evidence evidence);
+        public void Load(IXPathNavigable stylesheet, XmlResolver resolver, Evidence evidence);
+        public void Load(XPathNavigator stylesheet, XmlResolver resolver, Evidence evidence);
     }
 }
```

