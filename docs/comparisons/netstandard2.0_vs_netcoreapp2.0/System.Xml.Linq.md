# System.Xml.Linq

``` diff
 namespace System.Xml.Linq {
     public class XCData : XText {
+        public override Task WriteToAsync(XmlWriter writer, CancellationToken cancellationToken);
     }
     public class XComment : XNode {
+        public override Task WriteToAsync(XmlWriter writer, CancellationToken cancellationToken);
     }
     public class XDocument : XContainer {
+        public static Task<XDocument> LoadAsync(Stream stream, LoadOptions options, CancellationToken cancellationToken);
+        public static Task<XDocument> LoadAsync(TextReader textReader, LoadOptions options, CancellationToken cancellationToken);
+        public static Task<XDocument> LoadAsync(XmlReader reader, LoadOptions options, CancellationToken cancellationToken);
+        public Task SaveAsync(Stream stream, SaveOptions options, CancellationToken cancellationToken);
+        public Task SaveAsync(TextWriter textWriter, SaveOptions options, CancellationToken cancellationToken);
+        public Task SaveAsync(XmlWriter writer, CancellationToken cancellationToken);
+        public override Task WriteToAsync(XmlWriter writer, CancellationToken cancellationToken);
     }
     public class XDocumentType : XNode {
+        public override Task WriteToAsync(XmlWriter writer, CancellationToken cancellationToken);
     }
     public class XElement : XContainer, IXmlSerializable {
+        public static Task<XElement> LoadAsync(Stream stream, LoadOptions options, CancellationToken cancellationToken);
+        public static Task<XElement> LoadAsync(TextReader textReader, LoadOptions options, CancellationToken cancellationToken);
+        public static Task<XElement> LoadAsync(XmlReader reader, LoadOptions options, CancellationToken cancellationToken);
+        public Task SaveAsync(Stream stream, SaveOptions options, CancellationToken cancellationToken);
+        public Task SaveAsync(TextWriter textWriter, SaveOptions options, CancellationToken cancellationToken);
+        public Task SaveAsync(XmlWriter writer, CancellationToken cancellationToken);
+        public override Task WriteToAsync(XmlWriter writer, CancellationToken cancellationToken);
     }
     public abstract class XNode : XObject {
+        public static Task<XNode> ReadFromAsync(XmlReader reader, CancellationToken cancellationToken);
+        public abstract Task WriteToAsync(XmlWriter writer, CancellationToken cancellationToken);
     }
     public class XProcessingInstruction : XNode {
+        public override Task WriteToAsync(XmlWriter writer, CancellationToken cancellationToken);
     }
     public class XText : XNode {
+        public override Task WriteToAsync(XmlWriter writer, CancellationToken cancellationToken);
     }
 }
```

