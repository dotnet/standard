# System.Xml

``` diff
 namespace System.Xml {
+    public interface IApplicationResourceStreamResolver {
+        Stream GetApplicationResourceStream(Uri relativeUri);
+    }
+    public interface IXmlMtomReaderInitializer {
+        void SetInput(byte[] buffer, int offset, int count, Encoding[] encodings, string contentType, XmlDictionaryReaderQuotas quotas, int maxBufferSize, OnXmlDictionaryReaderClose onClose);
+        void SetInput(Stream stream, Encoding[] encodings, string contentType, XmlDictionaryReaderQuotas quotas, int maxBufferSize, OnXmlDictionaryReaderClose onClose);
+    }
+    public interface IXmlMtomWriterInitializer {
+        void SetOutput(Stream stream, Encoding encoding, int maxSizeInBytes, string startInfo, string boundary, string startUri, bool writeMessageHeaders, bool ownsStream);
+    }
+    public class XmlDataDocument : XmlDocument {
+        public XmlDataDocument();
+        public XmlDataDocument(DataSet dataset);
+        public DataSet DataSet { get; }
+        public override XmlNode CloneNode(bool deep);
+        public override XmlElement CreateElement(string prefix, string localName, string namespaceURI);
+        public override XmlEntityReference CreateEntityReference(string name);
+        protected override XPathNavigator CreateNavigator(XmlNode node);
+        public override XmlElement GetElementById(string elemId);
+        public XmlElement GetElementFromRow(DataRow r);
+        public override XmlNodeList GetElementsByTagName(string name);
+        public DataRow GetRowFromElement(XmlElement e);
+        public override void Load(Stream inStream);
+        public override void Load(TextReader txtReader);
+        public override void Load(string filename);
+        public override void Load(XmlReader reader);
+    }
     public sealed class XmlReaderSettings {
+        public XmlReaderSettings(XmlResolver resolver);
     }
     public class XmlSecureResolver : XmlResolver {
+        public XmlSecureResolver(XmlResolver resolver, PermissionSet permissionSet);
+        public XmlSecureResolver(XmlResolver resolver, Evidence evidence);
+        public static Evidence CreateEvidenceForUrl(string securityUrl);
     }
+    public class XmlXapResolver : XmlResolver {
+        public XmlXapResolver();
+        public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn);
+        public static void RegisterApplicationResourceStreamResolver(IApplicationResourceStreamResolver appStreamResolver);
+    }
 }
```

