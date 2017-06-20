# System.Web.Services.Discovery

``` diff
+namespace System.Web.Services.Discovery {
+    public class ContractReference : DiscoveryReference {
+        public const string Namespace = "http://schemas.xmlsoap.org/disco/scl/";
+        public ContractReference();
+        public ContractReference(string href);
+        public ContractReference(string href, string docRef);
+        public ServiceDescription Contract { get; }
+        public override string DefaultFilename { get; }
+        public string DocRef { get; set; }
+        public string Ref { get; set; }
+        public override string Url { get; set; }
+        public override object ReadDocument(Stream stream);
+        protected internal override void Resolve(string contentType, Stream stream);
+        public override void WriteDocument(object document, Stream stream);
+    }
+    public sealed class ContractSearchPattern : DiscoverySearchPattern {
+        public ContractSearchPattern();
+        public override string Pattern { get; }
+        public override DiscoveryReference GetDiscoveryReference(string filename);
+    }
+    public sealed class DiscoveryClientDocumentCollection : DictionaryBase {
+        public DiscoveryClientDocumentCollection();
+        public ICollection Keys { get; }
+        public object this[string url] { get; set; }
+        public ICollection Values { get; }
+        public void Add(string url, object value);
+        public bool Contains(string url);
+        public void Remove(string url);
+    }
+    public class DiscoveryClientProtocol : HttpWebClientProtocol {
+        public DiscoveryClientProtocol();
+        public IList AdditionalInformation { get; }
+        public DiscoveryClientDocumentCollection Documents { get; }
+        public DiscoveryExceptionDictionary Errors { get; }
+        public DiscoveryClientReferenceCollection References { get; }
+        public DiscoveryDocument Discover(string url);
+        public DiscoveryDocument DiscoverAny(string url);
+        public Stream Download(ref string url);
+        public Stream Download(ref string url, ref string contentType);
+        public void LoadExternals();
+        public DiscoveryClientResultCollection ReadAll(string topLevelFilename);
+        public void ResolveAll();
+        public void ResolveOneLevel();
+        public DiscoveryClientResultCollection WriteAll(string directory, string topLevelFilename);
+        public sealed class DiscoveryClientResultsFile {
+            public DiscoveryClientResultsFile();
+            public DiscoveryClientResultCollection Results { get; }
+        }
+    }
+    public sealed class DiscoveryClientReferenceCollection : DictionaryBase {
+        public DiscoveryClientReferenceCollection();
+        public ICollection Keys { get; }
+        public DiscoveryReference this[string url] { get; set; }
+        public ICollection Values { get; }
+        public void Add(string url, DiscoveryReference value);
+        public void Add(DiscoveryReference value);
+        public bool Contains(string url);
+        public void Remove(string url);
+    }
+    public sealed class DiscoveryClientResult {
+        public DiscoveryClientResult();
+        public DiscoveryClientResult(Type referenceType, string url, string filename);
+        public string Filename { get; set; }
+        public string ReferenceTypeName { get; set; }
+        public string Url { get; set; }
+    }
+    public sealed class DiscoveryClientResultCollection : CollectionBase {
+        public DiscoveryClientResultCollection();
+        public DiscoveryClientResult this[int i] { get; set; }
+        public int Add(DiscoveryClientResult value);
+        public bool Contains(DiscoveryClientResult value);
+        public void Remove(DiscoveryClientResult value);
+    }
+    public sealed class DiscoveryDocument {
+        public const string Namespace = "http://schemas.xmlsoap.org/disco/";
+        public DiscoveryDocument();
+        public IList References { get; }
+        public static bool CanRead(XmlReader xmlReader);
+        public static DiscoveryDocument Read(Stream stream);
+        public static DiscoveryDocument Read(TextReader reader);
+        public static DiscoveryDocument Read(XmlReader xmlReader);
+        public void Write(Stream stream);
+        public void Write(TextWriter writer);
+        public void Write(XmlWriter writer);
+    }
+    public class DiscoveryDocumentLinksPattern : DiscoverySearchPattern {
+        public DiscoveryDocumentLinksPattern();
+        public override string Pattern { get; }
+        public override DiscoveryReference GetDiscoveryReference(string filename);
+    }
+    public sealed class DiscoveryDocumentReference : DiscoveryReference {
+        public DiscoveryDocumentReference();
+        public DiscoveryDocumentReference(string href);
+        public override string DefaultFilename { get; }
+        public DiscoveryDocument Document { get; }
+        public string Ref { get; set; }
+        public override string Url { get; set; }
+        public override object ReadDocument(Stream stream);
+        protected internal override void Resolve(string contentType, Stream stream);
+        public void ResolveAll();
+        public override void WriteDocument(object document, Stream stream);
+    }
+    public sealed class DiscoveryDocumentSearchPattern : DiscoverySearchPattern {
+        public DiscoveryDocumentSearchPattern();
+        public override string Pattern { get; }
+        public override DiscoveryReference GetDiscoveryReference(string filename);
+    }
+    public sealed class DiscoveryExceptionDictionary : DictionaryBase {
+        public DiscoveryExceptionDictionary();
+        public ICollection Keys { get; }
+        public Exception this[string url] { get; set; }
+        public ICollection Values { get; }
+        public void Add(string url, Exception value);
+        public bool Contains(string url);
+        public void Remove(string url);
+    }
+    public abstract class DiscoveryReference {
+        protected DiscoveryReference();
+        public DiscoveryClientProtocol ClientProtocol { get; set; }
+        public virtual string DefaultFilename { get; }
+        public abstract string Url { get; set; }
+        public static string FilenameFromUrl(string url);
+        public abstract object ReadDocument(Stream stream);
+        public void Resolve();
+        protected internal abstract void Resolve(string contentType, Stream stream);
+        public abstract void WriteDocument(object document, Stream stream);
+    }
+    public sealed class DiscoveryReferenceCollection : CollectionBase {
+        public DiscoveryReferenceCollection();
+        public DiscoveryReference this[int i] { get; set; }
+        public int Add(DiscoveryReference value);
+        public bool Contains(DiscoveryReference value);
+        public void Remove(DiscoveryReference value);
+    }
+    public sealed class DiscoveryRequestHandler : IHttpHandler {
+        public DiscoveryRequestHandler();
+        public bool IsReusable { get; }
+        public void ProcessRequest(HttpContext context);
+    }
+    public abstract class DiscoverySearchPattern {
+        protected DiscoverySearchPattern();
+        public abstract string Pattern { get; }
+        public abstract DiscoveryReference GetDiscoveryReference(string filename);
+    }
+    public sealed class DynamicDiscoveryDocument {
+        public const string Namespace = "urn:schemas-dynamicdiscovery:disco.2000-03-17";
+        public DynamicDiscoveryDocument();
+        public ExcludePathInfo[] ExcludePaths { get; set; }
+        public static DynamicDiscoveryDocument Load(Stream stream);
+        public void Write(Stream stream);
+    }
+    public sealed class ExcludePathInfo {
+        public ExcludePathInfo();
+        public ExcludePathInfo(string path);
+        public string Path { get; set; }
+    }
+    public sealed class SchemaReference : DiscoveryReference {
+        public const string Namespace = "http://schemas.xmlsoap.org/disco/schema/";
+        public SchemaReference();
+        public SchemaReference(string url);
+        public override string DefaultFilename { get; }
+        public string Ref { get; set; }
+        public XmlSchema Schema { get; }
+        public string TargetNamespace { get; set; }
+        public override string Url { get; set; }
+        public override object ReadDocument(Stream stream);
+        protected internal override void Resolve(string contentType, Stream stream);
+        public override void WriteDocument(object document, Stream stream);
+    }
+    public sealed class SoapBinding {
+        public const string Namespace = "http://schemas.xmlsoap.org/disco/soap/";
+        public SoapBinding();
+        public string Address { get; set; }
+        public XmlQualifiedName Binding { get; set; }
+    }
+    public sealed class XmlSchemaSearchPattern : DiscoverySearchPattern {
+        public XmlSchemaSearchPattern();
+        public override string Pattern { get; }
+        public override DiscoveryReference GetDiscoveryReference(string filename);
+    }
+}
```

