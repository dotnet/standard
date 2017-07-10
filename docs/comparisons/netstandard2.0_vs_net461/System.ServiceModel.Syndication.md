# System.ServiceModel.Syndication

``` diff
+namespace System.ServiceModel.Syndication {
+    public class Atom10FeedFormatter : SyndicationFeedFormatter, IXmlSerializable {
+        public Atom10FeedFormatter();
+        public Atom10FeedFormatter(SyndicationFeed feedToWrite);
+        public Atom10FeedFormatter(Type feedTypeToCreate);
+        protected Type FeedType { get; }
+        public bool PreserveAttributeExtensions { get; set; }
+        public bool PreserveElementExtensions { get; set; }
+        public override string Version { get; }
+        public override bool CanRead(XmlReader reader);
+        protected override SyndicationFeed CreateFeedInstance();
+        public override void ReadFrom(XmlReader reader);
+        protected virtual SyndicationItem ReadItem(XmlReader reader, SyndicationFeed feed);
+        protected virtual IEnumerable<SyndicationItem> ReadItems(XmlReader reader, SyndicationFeed feed, out bool areAllItemsRead);
+        XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
+        void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader);
+        void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer);
+        protected virtual void WriteItem(XmlWriter writer, SyndicationItem item, Uri feedBaseUri);
+        protected virtual void WriteItems(XmlWriter writer, IEnumerable<SyndicationItem> items, Uri feedBaseUri);
+        public override void WriteTo(XmlWriter writer);
+    }
+    public class Atom10FeedFormatter<TSyndicationFeed> : Atom10FeedFormatter where TSyndicationFeed : SyndicationFeed, new() {
+        public Atom10FeedFormatter();
+        public Atom10FeedFormatter(TSyndicationFeed feedToWrite);
+        protected override SyndicationFeed CreateFeedInstance();
+    }
+    public class Atom10ItemFormatter : SyndicationItemFormatter, IXmlSerializable {
+        public Atom10ItemFormatter();
+        public Atom10ItemFormatter(SyndicationItem itemToWrite);
+        public Atom10ItemFormatter(Type itemTypeToCreate);
+        protected Type ItemType { get; }
+        public bool PreserveAttributeExtensions { get; set; }
+        public bool PreserveElementExtensions { get; set; }
+        public override string Version { get; }
+        public override bool CanRead(XmlReader reader);
+        protected override SyndicationItem CreateItemInstance();
+        public override void ReadFrom(XmlReader reader);
+        XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
+        void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader);
+        void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer);
+        public override void WriteTo(XmlWriter writer);
+    }
+    public class Atom10ItemFormatter<TSyndicationItem> : Atom10ItemFormatter where TSyndicationItem : SyndicationItem, new() {
+        public Atom10ItemFormatter();
+        public Atom10ItemFormatter(TSyndicationItem itemToWrite);
+        protected override SyndicationItem CreateItemInstance();
+    }
+    public class AtomPub10CategoriesDocumentFormatter : CategoriesDocumentFormatter, IXmlSerializable {
+        public AtomPub10CategoriesDocumentFormatter();
+        public AtomPub10CategoriesDocumentFormatter(CategoriesDocument documentToWrite);
+        public AtomPub10CategoriesDocumentFormatter(Type inlineDocumentType, Type referencedDocumentType);
+        public override string Version { get; }
+        public override bool CanRead(XmlReader reader);
+        protected override InlineCategoriesDocument CreateInlineCategoriesDocument();
+        protected override ReferencedCategoriesDocument CreateReferencedCategoriesDocument();
+        public override void ReadFrom(XmlReader reader);
+        XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
+        void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader);
+        void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer);
+        public override void WriteTo(XmlWriter writer);
+    }
+    public class AtomPub10ServiceDocumentFormatter : ServiceDocumentFormatter, IXmlSerializable {
+        public AtomPub10ServiceDocumentFormatter();
+        public AtomPub10ServiceDocumentFormatter(ServiceDocument documentToWrite);
+        public AtomPub10ServiceDocumentFormatter(Type documentTypeToCreate);
+        public override string Version { get; }
+        public override bool CanRead(XmlReader reader);
+        protected override ServiceDocument CreateDocumentInstance();
+        public override void ReadFrom(XmlReader reader);
+        XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
+        void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader);
+        void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer);
+        public override void WriteTo(XmlWriter writer);
+    }
+    public class AtomPub10ServiceDocumentFormatter<TServiceDocument> : AtomPub10ServiceDocumentFormatter where TServiceDocument : ServiceDocument, new() {
+        public AtomPub10ServiceDocumentFormatter();
+        public AtomPub10ServiceDocumentFormatter(TServiceDocument documentToWrite);
+        protected override ServiceDocument CreateDocumentInstance();
+    }
+    public abstract class CategoriesDocument : IExtensibleSyndicationObject {
+        public Dictionary<XmlQualifiedName, string> AttributeExtensions { get; }
+        public Uri BaseUri { get; set; }
+        public SyndicationElementExtensionCollection ElementExtensions { get; }
+        public string Language { get; set; }
+        public static InlineCategoriesDocument Create(Collection<SyndicationCategory> categories);
+        public static InlineCategoriesDocument Create(Collection<SyndicationCategory> categories, bool isFixed, string scheme);
+        public static ReferencedCategoriesDocument Create(Uri linkToCategoriesDocument);
+        public CategoriesDocumentFormatter GetFormatter();
+        public static CategoriesDocument Load(XmlReader reader);
+        public void Save(XmlWriter writer);
+        protected internal virtual bool TryParseAttribute(string name, string ns, string value, string version);
+        protected internal virtual bool TryParseElement(XmlReader reader, string version);
+        protected internal virtual void WriteAttributeExtensions(XmlWriter writer, string version);
+        protected internal virtual void WriteElementExtensions(XmlWriter writer, string version);
+    }
+    public abstract class CategoriesDocumentFormatter {
+        protected CategoriesDocumentFormatter();
+        protected CategoriesDocumentFormatter(CategoriesDocument documentToWrite);
+        public CategoriesDocument Document { get; }
+        public abstract string Version { get; }
+        public abstract bool CanRead(XmlReader reader);
+        protected virtual InlineCategoriesDocument CreateInlineCategoriesDocument();
+        protected virtual ReferencedCategoriesDocument CreateReferencedCategoriesDocument();
+        public abstract void ReadFrom(XmlReader reader);
+        protected virtual void SetDocument(CategoriesDocument document);
+        public abstract void WriteTo(XmlWriter writer);
+    }
+    public class InlineCategoriesDocument : CategoriesDocument {
+        public InlineCategoriesDocument();
+        public InlineCategoriesDocument(IEnumerable<SyndicationCategory> categories);
+        public InlineCategoriesDocument(IEnumerable<SyndicationCategory> categories, bool isFixed, string scheme);
+        public Collection<SyndicationCategory> Categories { get; }
+        public bool IsFixed { get; set; }
+        public string Scheme { get; set; }
+        protected internal virtual SyndicationCategory CreateCategory();
+    }
+    public class ReferencedCategoriesDocument : CategoriesDocument {
+        public ReferencedCategoriesDocument();
+        public ReferencedCategoriesDocument(Uri link);
+        public Uri Link { get; set; }
+    }
+    public class ResourceCollectionInfo : IExtensibleSyndicationObject {
+        public ResourceCollectionInfo();
+        public ResourceCollectionInfo(TextSyndicationContent title, Uri link);
+        public ResourceCollectionInfo(TextSyndicationContent title, Uri link, IEnumerable<CategoriesDocument> categories, bool allowsNewEntries);
+        public ResourceCollectionInfo(TextSyndicationContent title, Uri link, IEnumerable<CategoriesDocument> categories, IEnumerable<string> accepts);
+        public ResourceCollectionInfo(string title, Uri link);
+        public Collection<string> Accepts { get; }
+        public Dictionary<XmlQualifiedName, string> AttributeExtensions { get; }
+        public Uri BaseUri { get; set; }
+        public Collection<CategoriesDocument> Categories { get; }
+        public SyndicationElementExtensionCollection ElementExtensions { get; }
+        public Uri Link { get; set; }
+        public TextSyndicationContent Title { get; set; }
+        protected internal virtual InlineCategoriesDocument CreateInlineCategoriesDocument();
+        protected internal virtual ReferencedCategoriesDocument CreateReferencedCategoriesDocument();
+        protected internal virtual bool TryParseAttribute(string name, string ns, string value, string version);
+        protected internal virtual bool TryParseElement(XmlReader reader, string version);
+        protected internal virtual void WriteAttributeExtensions(XmlWriter writer, string version);
+        protected internal virtual void WriteElementExtensions(XmlWriter writer, string version);
+    }
+    public class Rss20FeedFormatter : SyndicationFeedFormatter, IXmlSerializable {
+        public Rss20FeedFormatter();
+        public Rss20FeedFormatter(SyndicationFeed feedToWrite);
+        public Rss20FeedFormatter(SyndicationFeed feedToWrite, bool serializeExtensionsAsAtom);
+        public Rss20FeedFormatter(Type feedTypeToCreate);
+        protected Type FeedType { get; }
+        public bool PreserveAttributeExtensions { get; set; }
+        public bool PreserveElementExtensions { get; set; }
+        public bool SerializeExtensionsAsAtom { get; set; }
+        public override string Version { get; }
+        public override bool CanRead(XmlReader reader);
+        protected override SyndicationFeed CreateFeedInstance();
+        public override void ReadFrom(XmlReader reader);
+        protected virtual SyndicationItem ReadItem(XmlReader reader, SyndicationFeed feed);
+        protected virtual IEnumerable<SyndicationItem> ReadItems(XmlReader reader, SyndicationFeed feed, out bool areAllItemsRead);
+        protected internal override void SetFeed(SyndicationFeed feed);
+        XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
+        void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader);
+        void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer);
+        protected virtual void WriteItem(XmlWriter writer, SyndicationItem item, Uri feedBaseUri);
+        protected virtual void WriteItems(XmlWriter writer, IEnumerable<SyndicationItem> items, Uri feedBaseUri);
+        public override void WriteTo(XmlWriter writer);
+    }
+    public class Rss20FeedFormatter<TSyndicationFeed> : Rss20FeedFormatter where TSyndicationFeed : SyndicationFeed, new() {
+        public Rss20FeedFormatter();
+        public Rss20FeedFormatter(TSyndicationFeed feedToWrite);
+        public Rss20FeedFormatter(TSyndicationFeed feedToWrite, bool serializeExtensionsAsAtom);
+        protected override SyndicationFeed CreateFeedInstance();
+    }
+    public class Rss20ItemFormatter : SyndicationItemFormatter, IXmlSerializable {
+        public Rss20ItemFormatter();
+        public Rss20ItemFormatter(SyndicationItem itemToWrite);
+        public Rss20ItemFormatter(SyndicationItem itemToWrite, bool serializeExtensionsAsAtom);
+        public Rss20ItemFormatter(Type itemTypeToCreate);
+        protected Type ItemType { get; }
+        public bool PreserveAttributeExtensions { get; set; }
+        public bool PreserveElementExtensions { get; set; }
+        public bool SerializeExtensionsAsAtom { get; set; }
+        public override string Version { get; }
+        public override bool CanRead(XmlReader reader);
+        protected override SyndicationItem CreateItemInstance();
+        public override void ReadFrom(XmlReader reader);
+        XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema();
+        void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader);
+        void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer);
+        public override void WriteTo(XmlWriter writer);
+    }
+    public class Rss20ItemFormatter<TSyndicationItem> : Rss20ItemFormatter, IXmlSerializable where TSyndicationItem : SyndicationItem, new() {
+        public Rss20ItemFormatter();
+        public Rss20ItemFormatter(TSyndicationItem itemToWrite);
+        public Rss20ItemFormatter(TSyndicationItem itemToWrite, bool serializeExtensionsAsAtom);
+        protected override SyndicationItem CreateItemInstance();
+    }
+    public class ServiceDocument : IExtensibleSyndicationObject {
+        public ServiceDocument();
+        public ServiceDocument(IEnumerable<Workspace> workspaces);
+        public Dictionary<XmlQualifiedName, string> AttributeExtensions { get; }
+        public Uri BaseUri { get; set; }
+        public SyndicationElementExtensionCollection ElementExtensions { get; }
+        public string Language { get; set; }
+        public Collection<Workspace> Workspaces { get; }
+        protected internal virtual Workspace CreateWorkspace();
+        public ServiceDocumentFormatter GetFormatter();
+        public static ServiceDocument Load(XmlReader reader);
+        public static TServiceDocument Load<TServiceDocument>(XmlReader reader) where TServiceDocument : ServiceDocument, new();
+        public void Save(XmlWriter writer);
+        protected internal virtual bool TryParseAttribute(string name, string ns, string value, string version);
+        protected internal virtual bool TryParseElement(XmlReader reader, string version);
+        protected internal virtual void WriteAttributeExtensions(XmlWriter writer, string version);
+        protected internal virtual void WriteElementExtensions(XmlWriter writer, string version);
+    }
+    public abstract class ServiceDocumentFormatter {
+        protected ServiceDocumentFormatter();
+        protected ServiceDocumentFormatter(ServiceDocument documentToWrite);
+        public ServiceDocument Document { get; }
+        public abstract string Version { get; }
+        public abstract bool CanRead(XmlReader reader);
+        protected static SyndicationCategory CreateCategory(InlineCategoriesDocument inlineCategories);
+        protected static ResourceCollectionInfo CreateCollection(Workspace workspace);
+        protected virtual ServiceDocument CreateDocumentInstance();
+        protected static InlineCategoriesDocument CreateInlineCategories(ResourceCollectionInfo collection);
+        protected static ReferencedCategoriesDocument CreateReferencedCategories(ResourceCollectionInfo collection);
+        protected static Workspace CreateWorkspace(ServiceDocument document);
+        protected static void LoadElementExtensions(XmlReader reader, CategoriesDocument categories, int maxExtensionSize);
+        protected static void LoadElementExtensions(XmlReader reader, ResourceCollectionInfo collection, int maxExtensionSize);
+        protected static void LoadElementExtensions(XmlReader reader, ServiceDocument document, int maxExtensionSize);
+        protected static void LoadElementExtensions(XmlReader reader, Workspace workspace, int maxExtensionSize);
+        public abstract void ReadFrom(XmlReader reader);
+        protected virtual void SetDocument(ServiceDocument document);
+        protected static bool TryParseAttribute(string name, string ns, string value, CategoriesDocument categories, string version);
+        protected static bool TryParseAttribute(string name, string ns, string value, ResourceCollectionInfo collection, string version);
+        protected static bool TryParseAttribute(string name, string ns, string value, ServiceDocument document, string version);
+        protected static bool TryParseAttribute(string name, string ns, string value, Workspace workspace, string version);
+        protected static bool TryParseElement(XmlReader reader, CategoriesDocument categories, string version);
+        protected static bool TryParseElement(XmlReader reader, ResourceCollectionInfo collection, string version);
+        protected static bool TryParseElement(XmlReader reader, ServiceDocument document, string version);
+        protected static bool TryParseElement(XmlReader reader, Workspace workspace, string version);
+        protected static void WriteAttributeExtensions(XmlWriter writer, CategoriesDocument categories, string version);
+        protected static void WriteAttributeExtensions(XmlWriter writer, ResourceCollectionInfo collection, string version);
+        protected static void WriteAttributeExtensions(XmlWriter writer, ServiceDocument document, string version);
+        protected static void WriteAttributeExtensions(XmlWriter writer, Workspace workspace, string version);
+        protected static void WriteElementExtensions(XmlWriter writer, CategoriesDocument categories, string version);
+        protected static void WriteElementExtensions(XmlWriter writer, ResourceCollectionInfo collection, string version);
+        protected static void WriteElementExtensions(XmlWriter writer, ServiceDocument document, string version);
+        protected static void WriteElementExtensions(XmlWriter writer, Workspace workspace, string version);
+        public abstract void WriteTo(XmlWriter writer);
+    }
+    public class SyndicationCategory : IExtensibleSyndicationObject {
+        public SyndicationCategory();
+        protected SyndicationCategory(SyndicationCategory source);
+        public SyndicationCategory(string name);
+        public SyndicationCategory(string name, string scheme, string label);
+        public Dictionary<XmlQualifiedName, string> AttributeExtensions { get; }
+        public SyndicationElementExtensionCollection ElementExtensions { get; }
+        public string Label { get; set; }
+        public string Name { get; set; }
+        public string Scheme { get; set; }
+        public virtual SyndicationCategory Clone();
+        protected internal virtual bool TryParseAttribute(string name, string ns, string value, string version);
+        protected internal virtual bool TryParseElement(XmlReader reader, string version);
+        protected internal virtual void WriteAttributeExtensions(XmlWriter writer, string version);
+        protected internal virtual void WriteElementExtensions(XmlWriter writer, string version);
+    }
+    public abstract class SyndicationContent {
+        protected SyndicationContent();
+        protected SyndicationContent(SyndicationContent source);
+        public Dictionary<XmlQualifiedName, string> AttributeExtensions { get; }
+        public abstract string Type { get; }
+        public abstract SyndicationContent Clone();
+        public static TextSyndicationContent CreateHtmlContent(string content);
+        public static TextSyndicationContent CreatePlaintextContent(string content);
+        public static UrlSyndicationContent CreateUrlContent(Uri url, string mediaType);
+        public static TextSyndicationContent CreateXhtmlContent(string content);
+        public static XmlSyndicationContent CreateXmlContent(object dataContractObject);
+        public static XmlSyndicationContent CreateXmlContent(object dataContractObject, XmlObjectSerializer dataContractSerializer);
+        public static XmlSyndicationContent CreateXmlContent(object xmlSerializerObject, XmlSerializer serializer);
+        public static XmlSyndicationContent CreateXmlContent(XmlReader xmlReader);
+        protected abstract void WriteContentsTo(XmlWriter writer);
+        public void WriteTo(XmlWriter writer, string outerElementName, string outerElementNamespace);
+    }
+    public class SyndicationElementExtension {
+        public SyndicationElementExtension(object dataContractExtension);
+        public SyndicationElementExtension(object dataContractExtension, XmlObjectSerializer dataContractSerializer);
+        public SyndicationElementExtension(object xmlSerializerExtension, XmlSerializer serializer);
+        public SyndicationElementExtension(string outerName, string outerNamespace, object dataContractExtension);
+        public SyndicationElementExtension(string outerName, string outerNamespace, object dataContractExtension, XmlObjectSerializer dataContractSerializer);
+        public SyndicationElementExtension(XmlReader xmlReader);
+        public string OuterName { get; }
+        public string OuterNamespace { get; }
+        public TExtension GetObject<TExtension>();
+        public TExtension GetObject<TExtension>(XmlObjectSerializer serializer);
+        public TExtension GetObject<TExtension>(XmlSerializer serializer);
+        public XmlReader GetReader();
+        public void WriteTo(XmlWriter writer);
+    }
+    public sealed class SyndicationElementExtensionCollection : Collection<SyndicationElementExtension> {
+        public void Add(object extension);
+        public void Add(object dataContractExtension, DataContractSerializer serializer);
+        public void Add(object xmlSerializerExtension, XmlSerializer serializer);
+        public void Add(string outerName, string outerNamespace, object dataContractExtension);
+        public void Add(string outerName, string outerNamespace, object dataContractExtension, XmlObjectSerializer dataContractSerializer);
+        public void Add(XmlReader xmlReader);
+        protected override void ClearItems();
+        public XmlReader GetReaderAtElementExtensions();
+        protected override void InsertItem(int index, SyndicationElementExtension item);
+        public Collection<TExtension> ReadElementExtensions<TExtension>(string extensionName, string extensionNamespace);
+        public Collection<TExtension> ReadElementExtensions<TExtension>(string extensionName, string extensionNamespace, XmlObjectSerializer serializer);
+        public Collection<TExtension> ReadElementExtensions<TExtension>(string extensionName, string extensionNamespace, XmlSerializer serializer);
+        protected override void RemoveItem(int index);
+        protected override void SetItem(int index, SyndicationElementExtension item);
+    }
+    public class SyndicationFeed : IExtensibleSyndicationObject {
+        public SyndicationFeed();
+        public SyndicationFeed(IEnumerable<SyndicationItem> items);
+        protected SyndicationFeed(SyndicationFeed source, bool cloneItems);
+        public SyndicationFeed(string title, string description, Uri feedAlternateLink);
+        public SyndicationFeed(string title, string description, Uri feedAlternateLink, IEnumerable<SyndicationItem> items);
+        public SyndicationFeed(string title, string description, Uri feedAlternateLink, string id, DateTimeOffset lastUpdatedTime);
+        public SyndicationFeed(string title, string description, Uri feedAlternateLink, string id, DateTimeOffset lastUpdatedTime, IEnumerable<SyndicationItem> items);
+        public Dictionary<XmlQualifiedName, string> AttributeExtensions { get; }
+        public Collection<SyndicationPerson> Authors { get; }
+        public Uri BaseUri { get; set; }
+        public Collection<SyndicationCategory> Categories { get; }
+        public Collection<SyndicationPerson> Contributors { get; }
+        public TextSyndicationContent Copyright { get; set; }
+        public TextSyndicationContent Description { get; set; }
+        public SyndicationElementExtensionCollection ElementExtensions { get; }
+        public string Generator { get; set; }
+        public string Id { get; set; }
+        public Uri ImageUrl { get; set; }
+        public IEnumerable<SyndicationItem> Items { get; set; }
+        public string Language { get; set; }
+        public DateTimeOffset LastUpdatedTime { get; set; }
+        public Collection<SyndicationLink> Links { get; }
+        public TextSyndicationContent Title { get; set; }
+        public virtual SyndicationFeed Clone(bool cloneItems);
+        protected internal virtual SyndicationCategory CreateCategory();
+        protected internal virtual SyndicationItem CreateItem();
+        protected internal virtual SyndicationLink CreateLink();
+        protected internal virtual SyndicationPerson CreatePerson();
+        public Atom10FeedFormatter GetAtom10Formatter();
+        public Rss20FeedFormatter GetRss20Formatter();
+        public Rss20FeedFormatter GetRss20Formatter(bool serializeExtensionsAsAtom);
+        public static SyndicationFeed Load(XmlReader reader);
+        public static TSyndicationFeed Load<TSyndicationFeed>(XmlReader reader) where TSyndicationFeed : SyndicationFeed, new();
+        public void SaveAsAtom10(XmlWriter writer);
+        public void SaveAsRss20(XmlWriter writer);
+        protected internal virtual bool TryParseAttribute(string name, string ns, string value, string version);
+        protected internal virtual bool TryParseElement(XmlReader reader, string version);
+        protected internal virtual void WriteAttributeExtensions(XmlWriter writer, string version);
+        protected internal virtual void WriteElementExtensions(XmlWriter writer, string version);
+    }
+    public abstract class SyndicationFeedFormatter {
+        protected SyndicationFeedFormatter();
+        protected SyndicationFeedFormatter(SyndicationFeed feedToWrite);
+        public SyndicationFeed Feed { get; }
+        public abstract string Version { get; }
+        public abstract bool CanRead(XmlReader reader);
+        protected internal static SyndicationCategory CreateCategory(SyndicationFeed feed);
+        protected internal static SyndicationCategory CreateCategory(SyndicationItem item);
+        protected abstract SyndicationFeed CreateFeedInstance();
+        protected internal static SyndicationItem CreateItem(SyndicationFeed feed);
+        protected internal static SyndicationLink CreateLink(SyndicationFeed feed);
+        protected internal static SyndicationLink CreateLink(SyndicationItem item);
+        protected internal static SyndicationPerson CreatePerson(SyndicationFeed feed);
+        protected internal static SyndicationPerson CreatePerson(SyndicationItem item);
+        protected internal static void LoadElementExtensions(XmlReader reader, SyndicationCategory category, int maxExtensionSize);
+        protected internal static void LoadElementExtensions(XmlReader reader, SyndicationFeed feed, int maxExtensionSize);
+        protected internal static void LoadElementExtensions(XmlReader reader, SyndicationItem item, int maxExtensionSize);
+        protected internal static void LoadElementExtensions(XmlReader reader, SyndicationLink link, int maxExtensionSize);
+        protected internal static void LoadElementExtensions(XmlReader reader, SyndicationPerson person, int maxExtensionSize);
+        public abstract void ReadFrom(XmlReader reader);
+        protected internal virtual void SetFeed(SyndicationFeed feed);
+        public override string ToString();
+        protected internal static bool TryParseAttribute(string name, string ns, string value, SyndicationCategory category, string version);
+        protected internal static bool TryParseAttribute(string name, string ns, string value, SyndicationFeed feed, string version);
+        protected internal static bool TryParseAttribute(string name, string ns, string value, SyndicationItem item, string version);
+        protected internal static bool TryParseAttribute(string name, string ns, string value, SyndicationLink link, string version);
+        protected internal static bool TryParseAttribute(string name, string ns, string value, SyndicationPerson person, string version);
+        protected internal static bool TryParseContent(XmlReader reader, SyndicationItem item, string contentType, string version, out SyndicationContent content);
+        protected internal static bool TryParseElement(XmlReader reader, SyndicationCategory category, string version);
+        protected internal static bool TryParseElement(XmlReader reader, SyndicationFeed feed, string version);
+        protected internal static bool TryParseElement(XmlReader reader, SyndicationItem item, string version);
+        protected internal static bool TryParseElement(XmlReader reader, SyndicationLink link, string version);
+        protected internal static bool TryParseElement(XmlReader reader, SyndicationPerson person, string version);
+        protected internal static void WriteAttributeExtensions(XmlWriter writer, SyndicationCategory category, string version);
+        protected internal static void WriteAttributeExtensions(XmlWriter writer, SyndicationFeed feed, string version);
+        protected internal static void WriteAttributeExtensions(XmlWriter writer, SyndicationItem item, string version);
+        protected internal static void WriteAttributeExtensions(XmlWriter writer, SyndicationLink link, string version);
+        protected internal static void WriteAttributeExtensions(XmlWriter writer, SyndicationPerson person, string version);
+        protected internal static void WriteElementExtensions(XmlWriter writer, SyndicationCategory category, string version);
+        protected internal static void WriteElementExtensions(XmlWriter writer, SyndicationFeed feed, string version);
+        protected internal static void WriteElementExtensions(XmlWriter writer, SyndicationItem item, string version);
+        protected internal static void WriteElementExtensions(XmlWriter writer, SyndicationLink link, string version);
+        protected internal static void WriteElementExtensions(XmlWriter writer, SyndicationPerson person, string version);
+        public abstract void WriteTo(XmlWriter writer);
+    }
+    public class SyndicationItem : IExtensibleSyndicationObject {
+        public SyndicationItem();
+        protected SyndicationItem(SyndicationItem source);
+        public SyndicationItem(string title, SyndicationContent content, Uri itemAlternateLink, string id, DateTimeOffset lastUpdatedTime);
+        public SyndicationItem(string title, string content, Uri itemAlternateLink);
+        public SyndicationItem(string title, string content, Uri itemAlternateLink, string id, DateTimeOffset lastUpdatedTime);
+        public Dictionary<XmlQualifiedName, string> AttributeExtensions { get; }
+        public Collection<SyndicationPerson> Authors { get; }
+        public Uri BaseUri { get; set; }
+        public Collection<SyndicationCategory> Categories { get; }
+        public SyndicationContent Content { get; set; }
+        public Collection<SyndicationPerson> Contributors { get; }
+        public TextSyndicationContent Copyright { get; set; }
+        public SyndicationElementExtensionCollection ElementExtensions { get; }
+        public string Id { get; set; }
+        public DateTimeOffset LastUpdatedTime { get; set; }
+        public Collection<SyndicationLink> Links { get; }
+        public DateTimeOffset PublishDate { get; set; }
+        public SyndicationFeed SourceFeed { get; set; }
+        public TextSyndicationContent Summary { get; set; }
+        public TextSyndicationContent Title { get; set; }
+        public void AddPermalink(Uri permalink);
+        public virtual SyndicationItem Clone();
+        protected internal virtual SyndicationCategory CreateCategory();
+        protected internal virtual SyndicationLink CreateLink();
+        protected internal virtual SyndicationPerson CreatePerson();
+        public Atom10ItemFormatter GetAtom10Formatter();
+        public Rss20ItemFormatter GetRss20Formatter();
+        public Rss20ItemFormatter GetRss20Formatter(bool serializeExtensionsAsAtom);
+        public static SyndicationItem Load(XmlReader reader);
+        public static TSyndicationItem Load<TSyndicationItem>(XmlReader reader) where TSyndicationItem : SyndicationItem, new();
+        public void SaveAsAtom10(XmlWriter writer);
+        public void SaveAsRss20(XmlWriter writer);
+        protected internal virtual bool TryParseAttribute(string name, string ns, string value, string version);
+        protected internal virtual bool TryParseContent(XmlReader reader, string contentType, string version, out SyndicationContent content);
+        protected internal virtual bool TryParseElement(XmlReader reader, string version);
+        protected internal virtual void WriteAttributeExtensions(XmlWriter writer, string version);
+        protected internal virtual void WriteElementExtensions(XmlWriter writer, string version);
+    }
+    public abstract class SyndicationItemFormatter {
+        protected SyndicationItemFormatter();
+        protected SyndicationItemFormatter(SyndicationItem itemToWrite);
+        public SyndicationItem Item { get; }
+        public abstract string Version { get; }
+        public abstract bool CanRead(XmlReader reader);
+        protected static SyndicationCategory CreateCategory(SyndicationItem item);
+        protected abstract SyndicationItem CreateItemInstance();
+        protected static SyndicationLink CreateLink(SyndicationItem item);
+        protected static SyndicationPerson CreatePerson(SyndicationItem item);
+        protected static void LoadElementExtensions(XmlReader reader, SyndicationCategory category, int maxExtensionSize);
+        protected static void LoadElementExtensions(XmlReader reader, SyndicationItem item, int maxExtensionSize);
+        protected static void LoadElementExtensions(XmlReader reader, SyndicationLink link, int maxExtensionSize);
+        protected static void LoadElementExtensions(XmlReader reader, SyndicationPerson person, int maxExtensionSize);
+        public abstract void ReadFrom(XmlReader reader);
+        protected internal virtual void SetItem(SyndicationItem item);
+        public override string ToString();
+        protected static bool TryParseAttribute(string name, string ns, string value, SyndicationCategory category, string version);
+        protected static bool TryParseAttribute(string name, string ns, string value, SyndicationItem item, string version);
+        protected static bool TryParseAttribute(string name, string ns, string value, SyndicationLink link, string version);
+        protected static bool TryParseAttribute(string name, string ns, string value, SyndicationPerson person, string version);
+        protected static bool TryParseContent(XmlReader reader, SyndicationItem item, string contentType, string version, out SyndicationContent content);
+        protected static bool TryParseElement(XmlReader reader, SyndicationCategory category, string version);
+        protected static bool TryParseElement(XmlReader reader, SyndicationItem item, string version);
+        protected static bool TryParseElement(XmlReader reader, SyndicationLink link, string version);
+        protected static bool TryParseElement(XmlReader reader, SyndicationPerson person, string version);
+        protected static void WriteAttributeExtensions(XmlWriter writer, SyndicationCategory category, string version);
+        protected static void WriteAttributeExtensions(XmlWriter writer, SyndicationItem item, string version);
+        protected static void WriteAttributeExtensions(XmlWriter writer, SyndicationLink link, string version);
+        protected static void WriteAttributeExtensions(XmlWriter writer, SyndicationPerson person, string version);
+        protected void WriteElementExtensions(XmlWriter writer, SyndicationCategory category, string version);
+        protected static void WriteElementExtensions(XmlWriter writer, SyndicationItem item, string version);
+        protected void WriteElementExtensions(XmlWriter writer, SyndicationLink link, string version);
+        protected void WriteElementExtensions(XmlWriter writer, SyndicationPerson person, string version);
+        public abstract void WriteTo(XmlWriter writer);
+    }
+    public class SyndicationLink : IExtensibleSyndicationObject {
+        public SyndicationLink();
+        protected SyndicationLink(SyndicationLink source);
+        public SyndicationLink(Uri uri);
+        public SyndicationLink(Uri uri, string relationshipType, string title, string mediaType, long length);
+        public Dictionary<XmlQualifiedName, string> AttributeExtensions { get; }
+        public Uri BaseUri { get; set; }
+        public SyndicationElementExtensionCollection ElementExtensions { get; }
+        public long Length { get; set; }
+        public string MediaType { get; set; }
+        public string RelationshipType { get; set; }
+        public string Title { get; set; }
+        public Uri Uri { get; set; }
+        public virtual SyndicationLink Clone();
+        public static SyndicationLink CreateAlternateLink(Uri uri);
+        public static SyndicationLink CreateAlternateLink(Uri uri, string mediaType);
+        public static SyndicationLink CreateMediaEnclosureLink(Uri uri, string mediaType, long length);
+        public static SyndicationLink CreateSelfLink(Uri uri);
+        public static SyndicationLink CreateSelfLink(Uri uri, string mediaType);
+        public Uri GetAbsoluteUri();
+        protected internal virtual bool TryParseAttribute(string name, string ns, string value, string version);
+        protected internal virtual bool TryParseElement(XmlReader reader, string version);
+        protected internal virtual void WriteAttributeExtensions(XmlWriter writer, string version);
+        protected internal virtual void WriteElementExtensions(XmlWriter writer, string version);
+    }
+    public class SyndicationPerson : IExtensibleSyndicationObject {
+        public SyndicationPerson();
+        protected SyndicationPerson(SyndicationPerson source);
+        public SyndicationPerson(string email);
+        public SyndicationPerson(string email, string name, string uri);
+        public Dictionary<XmlQualifiedName, string> AttributeExtensions { get; }
+        public SyndicationElementExtensionCollection ElementExtensions { get; }
+        public string Email { get; set; }
+        public string Name { get; set; }
+        public string Uri { get; set; }
+        public virtual SyndicationPerson Clone();
+        protected internal virtual bool TryParseAttribute(string name, string ns, string value, string version);
+        protected internal virtual bool TryParseElement(XmlReader reader, string version);
+        protected internal virtual void WriteAttributeExtensions(XmlWriter writer, string version);
+        protected internal virtual void WriteElementExtensions(XmlWriter writer, string version);
+    }
+    public static class SyndicationVersions {
+        public const string Atom10 = "Atom10";
+        public const string Rss20 = "Rss20";
+    }
+    public class TextSyndicationContent : SyndicationContent {
+        protected TextSyndicationContent(TextSyndicationContent source);
+        public TextSyndicationContent(string text);
+        public TextSyndicationContent(string text, TextSyndicationContentKind textKind);
+        public string Text { get; }
+        public override string Type { get; }
+        public override SyndicationContent Clone();
+        protected override void WriteContentsTo(XmlWriter writer);
+    }
+    public enum TextSyndicationContentKind {
+        Html = 1,
+        Plaintext = 0,
+        XHtml = 2,
+    }
+    public class UrlSyndicationContent : SyndicationContent {
+        protected UrlSyndicationContent(UrlSyndicationContent source);
+        public UrlSyndicationContent(Uri url, string mediaType);
+        public override string Type { get; }
+        public Uri Url { get; }
+        public override SyndicationContent Clone();
+        protected override void WriteContentsTo(XmlWriter writer);
+    }
+    public class Workspace : IExtensibleSyndicationObject {
+        public Workspace();
+        public Workspace(TextSyndicationContent title, IEnumerable<ResourceCollectionInfo> collections);
+        public Workspace(string title, IEnumerable<ResourceCollectionInfo> collections);
+        public Dictionary<XmlQualifiedName, string> AttributeExtensions { get; }
+        public Uri BaseUri { get; set; }
+        public Collection<ResourceCollectionInfo> Collections { get; }
+        public SyndicationElementExtensionCollection ElementExtensions { get; }
+        public TextSyndicationContent Title { get; set; }
+        protected internal virtual ResourceCollectionInfo CreateResourceCollection();
+        protected internal virtual bool TryParseAttribute(string name, string ns, string value, string version);
+        protected internal virtual bool TryParseElement(XmlReader reader, string version);
+        protected internal virtual void WriteAttributeExtensions(XmlWriter writer, string version);
+        protected internal virtual void WriteElementExtensions(XmlWriter writer, string version);
+    }
+    public class XmlSyndicationContent : SyndicationContent {
+        protected XmlSyndicationContent(XmlSyndicationContent source);
+        public XmlSyndicationContent(string type, object dataContractExtension, XmlObjectSerializer dataContractSerializer);
+        public XmlSyndicationContent(string type, object xmlSerializerExtension, XmlSerializer serializer);
+        public XmlSyndicationContent(string type, SyndicationElementExtension extension);
+        public XmlSyndicationContent(XmlReader reader);
+        public SyndicationElementExtension Extension { get; }
+        public override string Type { get; }
+        public override SyndicationContent Clone();
+        public XmlDictionaryReader GetReaderAtContent();
+        public TContent ReadContent<TContent>();
+        public TContent ReadContent<TContent>(XmlObjectSerializer dataContractSerializer);
+        public TContent ReadContent<TContent>(XmlSerializer serializer);
+        protected override void WriteContentsTo(XmlWriter writer);
+    }
+}
```

