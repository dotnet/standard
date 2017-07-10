# System.Xml.XmlConfiguration

``` diff
+namespace System.Xml.XmlConfiguration {
+    public sealed class XmlReaderSection : ConfigurationSection {
+        public XmlReaderSection();
+        public string ProhibitDefaultResolverString { get; set; }
+    }
+    public sealed class XsltConfigSection : ConfigurationSection {
+        public XsltConfigSection();
+        public string ProhibitDefaultResolverString { get; set; }
+    }
+}
```

