# System.Runtime.Remoting.Metadata

``` diff
+namespace System.Runtime.Remoting.Metadata {
+    public class SoapAttribute : Attribute {
+        protected object ReflectInfo;
+        protected string ProtXmlNamespace;
+        public SoapAttribute();
+        public virtual bool Embedded { get; set; }
+        public virtual bool UseAttribute { get; set; }
+        public virtual string XmlNamespace { get; set; }
+    }
+    public sealed class SoapFieldAttribute : SoapAttribute {
+        public SoapFieldAttribute();
+        public int Order { get; set; }
+        public string XmlElementName { get; set; }
+        public bool IsInteropXmlElement();
+    }
+    public sealed class SoapMethodAttribute : SoapAttribute {
+        public SoapMethodAttribute();
+        public string ResponseXmlElementName { get; set; }
+        public string ResponseXmlNamespace { get; set; }
+        public string ReturnXmlElementName { get; set; }
+        public string SoapAction { get; set; }
+        public override bool UseAttribute { get; set; }
+        public override string XmlNamespace { get; set; }
+    }
+    public enum SoapOption {
+        AlwaysIncludeTypes = 1,
+        EmbedAll = 4,
+        None = 0,
+        Option1 = 8,
+        Option2 = 16,
+        XsdString = 2,
+    }
+    public sealed class SoapParameterAttribute : SoapAttribute {
+        public SoapParameterAttribute();
+    }
+    public sealed class SoapTypeAttribute : SoapAttribute {
+        public SoapTypeAttribute();
+        public SoapOption SoapOptions { get; set; }
+        public override bool UseAttribute { get; set; }
+        public string XmlElementName { get; set; }
+        public XmlFieldOrderOption XmlFieldOrder { get; set; }
+        public override string XmlNamespace { get; set; }
+        public string XmlTypeName { get; set; }
+        public string XmlTypeNamespace { get; set; }
+    }
+    public enum XmlFieldOrderOption {
+        All = 0,
+        Choice = 2,
+        Sequence = 1,
+    }
+}
```

