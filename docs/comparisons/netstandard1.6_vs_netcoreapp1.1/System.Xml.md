# System.Xml

``` diff
 namespace System.Xml {
+    public interface IXmlDictionary {
+        bool TryLookup(int key, out XmlDictionaryString result);
+        bool TryLookup(string value, out XmlDictionaryString result);
+        bool TryLookup(XmlDictionaryString value, out XmlDictionaryString result);
+    }
+    public delegate void OnXmlDictionaryReaderClose(XmlDictionaryReader reader);
+    public class UniqueId {
+        public UniqueId();
+        public UniqueId(byte[] guid);
+        public UniqueId(byte[] guid, int offset);
+        public UniqueId(char[] chars, int offset, int count);
+        public UniqueId(Guid guid);
+        public UniqueId(string value);
+        public int CharArrayLength { get; }
+        public bool IsGuid { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public static bool operator ==(UniqueId id1, UniqueId id2);
+        public static bool operator !=(UniqueId id1, UniqueId id2);
+        public int ToCharArray(char[] chars, int offset);
+        public override string ToString();
+        public bool TryGetGuid(byte[] buffer, int offset);
+        public bool TryGetGuid(out Guid guid);
+    }
+    public class XmlAttribute : XmlNode {
+        protected internal XmlAttribute(string prefix, string localName, string namespaceURI, XmlDocument doc);
+        public override string BaseURI { get; }
+        public override string InnerText { set; }
+        public override string InnerXml { set; }
+        public override string LocalName { get; }
+        public override string Name { get; }
+        public override string NamespaceURI { get; }
+        public override XmlNodeType NodeType { get; }
+        public override XmlDocument OwnerDocument { get; }
+        public virtual XmlElement OwnerElement { get; }
+        public override XmlNode ParentNode { get; }
+        public override string Prefix { get; set; }
+        public virtual bool Specified { get; }
+        public override string Value { get; set; }
+        public override XmlNode AppendChild(XmlNode newChild);
+        public override XmlNode CloneNode(bool deep);
+        public override XmlNode InsertAfter(XmlNode newChild, XmlNode refChild);
+        public override XmlNode InsertBefore(XmlNode newChild, XmlNode refChild);
+        public override XmlNode PrependChild(XmlNode newChild);
+        public override XmlNode RemoveChild(XmlNode oldChild);
+        public override XmlNode ReplaceChild(XmlNode newChild, XmlNode oldChild);
+        public override void WriteContentTo(XmlWriter w);
+        public override void WriteTo(XmlWriter w);
+    }
+    public sealed class XmlAttributeCollection : XmlNamedNodeMap, ICollection, IEnumerable {
+        int System.Collections.ICollection.Count { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        [System.Runtime.CompilerServices.IndexerName("ItemOf")]
+        public XmlAttribute this[int i] { get; }
+        [System.Runtime.CompilerServices.IndexerName("ItemOf")]
+        public XmlAttribute this[string localName, string namespaceURI] { get; }
+        [System.Runtime.CompilerServices.IndexerName("ItemOf")]
+        public XmlAttribute this[string name] { get; }
+        public XmlAttribute Append(XmlAttribute node);
+        public void CopyTo(XmlAttribute[] array, int index);
+        public XmlAttribute InsertAfter(XmlAttribute newNode, XmlAttribute refNode);
+        public XmlAttribute InsertBefore(XmlAttribute newNode, XmlAttribute refNode);
+        public XmlAttribute Prepend(XmlAttribute node);
+        public XmlAttribute Remove(XmlAttribute node);
+        public void RemoveAll();
+        public XmlAttribute RemoveAt(int i);
+        public override XmlNode SetNamedItem(XmlNode node);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+    }
+    public class XmlBinaryReaderSession : IXmlDictionary {
+        public XmlBinaryReaderSession();
+        public XmlDictionaryString Add(int id, string value);
+        public void Clear();
+        public bool TryLookup(int key, out XmlDictionaryString result);
+        public bool TryLookup(string value, out XmlDictionaryString result);
+        public bool TryLookup(XmlDictionaryString value, out XmlDictionaryString result);
+    }
+    public class XmlBinaryWriterSession {
+        public XmlBinaryWriterSession();
+        public void Reset();
+        public virtual bool TryAdd(XmlDictionaryString value, out int key);
+    }
+    public class XmlCDataSection : XmlCharacterData {
+        protected internal XmlCDataSection(string data, XmlDocument doc);
+        public override string LocalName { get; }
+        public override string Name { get; }
+        public override XmlNodeType NodeType { get; }
+        public override XmlNode ParentNode { get; }
+        public override XmlNode PreviousText { get; }
+        public override XmlNode CloneNode(bool deep);
+        public override void WriteContentTo(XmlWriter w);
+        public override void WriteTo(XmlWriter w);
+    }
+    public abstract class XmlCharacterData : XmlLinkedNode {
+        protected internal XmlCharacterData(string data, XmlDocument doc);
+        public virtual string Data { get; set; }
+        public virtual int Length { get; }
+        public override string Value { get; set; }
+        public virtual void AppendData(string strData);
+        public virtual void DeleteData(int offset, int count);
+        public virtual void InsertData(int offset, string strData);
+        public virtual void ReplaceData(int offset, int count, string strData);
+        public virtual string Substring(int offset, int count);
+    }
+    public class XmlComment : XmlCharacterData {
+        protected internal XmlComment(string comment, XmlDocument doc);
+        public override string LocalName { get; }
+        public override string Name { get; }
+        public override XmlNodeType NodeType { get; }
+        public override XmlNode CloneNode(bool deep);
+        public override void WriteContentTo(XmlWriter w);
+        public override void WriteTo(XmlWriter w);
+    }
+    public class XmlDeclaration : XmlLinkedNode {
+        protected internal XmlDeclaration(string version, string encoding, string standalone, XmlDocument doc);
+        public string Encoding { get; set; }
+        public override string InnerText { get; set; }
+        public override string LocalName { get; }
+        public override string Name { get; }
+        public override XmlNodeType NodeType { get; }
+        public string Standalone { get; set; }
+        public override string Value { get; set; }
+        public string Version { get; }
+        public override XmlNode CloneNode(bool deep);
+        public override void WriteContentTo(XmlWriter w);
+        public override void WriteTo(XmlWriter w);
+    }
+    public class XmlDictionary : IXmlDictionary {
+        public XmlDictionary();
+        public XmlDictionary(int capacity);
+        public static IXmlDictionary Empty { get; }
+        public virtual XmlDictionaryString Add(string value);
+        public virtual bool TryLookup(int key, out XmlDictionaryString result);
+        public virtual bool TryLookup(string value, out XmlDictionaryString result);
+        public virtual bool TryLookup(XmlDictionaryString value, out XmlDictionaryString result);
+    }
+    public abstract class XmlDictionaryReader : XmlReader {
+        protected XmlDictionaryReader();
+        public virtual bool CanCanonicalize { get; }
+        public virtual XmlDictionaryReaderQuotas Quotas { get; }
+        public static XmlDictionaryReader CreateBinaryReader(byte[] buffer, int offset, int count, IXmlDictionary dictionary, XmlDictionaryReaderQuotas quotas);
+        public static XmlDictionaryReader CreateBinaryReader(byte[] buffer, int offset, int count, IXmlDictionary dictionary, XmlDictionaryReaderQuotas quotas, XmlBinaryReaderSession session);
+        public static XmlDictionaryReader CreateBinaryReader(byte[] buffer, int offset, int count, XmlDictionaryReaderQuotas quotas);
+        public static XmlDictionaryReader CreateBinaryReader(byte[] buffer, XmlDictionaryReaderQuotas quotas);
+        public static XmlDictionaryReader CreateBinaryReader(Stream stream, IXmlDictionary dictionary, XmlDictionaryReaderQuotas quotas);
+        public static XmlDictionaryReader CreateBinaryReader(Stream stream, IXmlDictionary dictionary, XmlDictionaryReaderQuotas quotas, XmlBinaryReaderSession session);
+        public static XmlDictionaryReader CreateBinaryReader(Stream stream, XmlDictionaryReaderQuotas quotas);
+        public static XmlDictionaryReader CreateDictionaryReader(XmlReader reader);
+        public static XmlDictionaryReader CreateTextReader(byte[] buffer, int offset, int count, XmlDictionaryReaderQuotas quotas);
+        public static XmlDictionaryReader CreateTextReader(byte[] buffer, XmlDictionaryReaderQuotas quotas);
+        public static XmlDictionaryReader CreateTextReader(Stream stream, Encoding encoding, XmlDictionaryReaderQuotas quotas, OnXmlDictionaryReaderClose onClose);
+        public static XmlDictionaryReader CreateTextReader(Stream stream, XmlDictionaryReaderQuotas quotas);
+        public virtual void EndCanonicalization();
+        public virtual string GetAttribute(XmlDictionaryString localName, XmlDictionaryString namespaceUri);
+        public virtual int IndexOfLocalName(string[] localNames, string namespaceUri);
+        public virtual int IndexOfLocalName(XmlDictionaryString[] localNames, XmlDictionaryString namespaceUri);
+        public virtual bool IsLocalName(string localName);
+        public virtual bool IsLocalName(XmlDictionaryString localName);
+        public virtual bool IsNamespaceUri(string namespaceUri);
+        public virtual bool IsNamespaceUri(XmlDictionaryString namespaceUri);
+        public virtual bool IsStartArray(out Type type);
+        public virtual bool IsStartElement(XmlDictionaryString localName, XmlDictionaryString namespaceUri);
+        protected bool IsTextNode(XmlNodeType nodeType);
+        public virtual void MoveToStartElement();
+        public virtual void MoveToStartElement(string name);
+        public virtual void MoveToStartElement(string localName, string namespaceUri);
+        public virtual void MoveToStartElement(XmlDictionaryString localName, XmlDictionaryString namespaceUri);
+        public virtual int ReadArray(string localName, string namespaceUri, bool[] array, int offset, int count);
+        public virtual int ReadArray(string localName, string namespaceUri, DateTime[] array, int offset, int count);
+        public virtual int ReadArray(string localName, string namespaceUri, decimal[] array, int offset, int count);
+        public virtual int ReadArray(string localName, string namespaceUri, double[] array, int offset, int count);
+        public virtual int ReadArray(string localName, string namespaceUri, Guid[] array, int offset, int count);
+        public virtual int ReadArray(string localName, string namespaceUri, short[] array, int offset, int count);
+        public virtual int ReadArray(string localName, string namespaceUri, int[] array, int offset, int count);
+        public virtual int ReadArray(string localName, string namespaceUri, long[] array, int offset, int count);
+        public virtual int ReadArray(string localName, string namespaceUri, float[] array, int offset, int count);
+        public virtual int ReadArray(string localName, string namespaceUri, TimeSpan[] array, int offset, int count);
+        public virtual int ReadArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, bool[] array, int offset, int count);
+        public virtual int ReadArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, DateTime[] array, int offset, int count);
+        public virtual int ReadArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, decimal[] array, int offset, int count);
+        public virtual int ReadArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, double[] array, int offset, int count);
+        public virtual int ReadArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, Guid[] array, int offset, int count);
+        public virtual int ReadArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, short[] array, int offset, int count);
+        public virtual int ReadArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, int[] array, int offset, int count);
+        public virtual int ReadArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, long[] array, int offset, int count);
+        public virtual int ReadArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, float[] array, int offset, int count);
+        public virtual int ReadArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, TimeSpan[] array, int offset, int count);
+        public virtual bool[] ReadBooleanArray(string localName, string namespaceUri);
+        public virtual bool[] ReadBooleanArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri);
+        public override object ReadContentAs(Type type, IXmlNamespaceResolver namespaceResolver);
+        public virtual byte[] ReadContentAsBase64();
+        public virtual byte[] ReadContentAsBinHex();
+        protected byte[] ReadContentAsBinHex(int maxByteArrayContentLength);
+        public virtual int ReadContentAsChars(char[] chars, int offset, int count);
+        public override decimal ReadContentAsDecimal();
+        public override float ReadContentAsFloat();
+        public virtual Guid ReadContentAsGuid();
+        public virtual void ReadContentAsQualifiedName(out string localName, out string namespaceUri);
+        public override string ReadContentAsString();
+        protected string ReadContentAsString(int maxStringContentLength);
+        public virtual string ReadContentAsString(string[] strings, out int index);
+        public virtual string ReadContentAsString(XmlDictionaryString[] strings, out int index);
+        public virtual TimeSpan ReadContentAsTimeSpan();
+        public virtual UniqueId ReadContentAsUniqueId();
+        public virtual DateTime[] ReadDateTimeArray(string localName, string namespaceUri);
+        public virtual DateTime[] ReadDateTimeArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri);
+        public virtual decimal[] ReadDecimalArray(string localName, string namespaceUri);
+        public virtual decimal[] ReadDecimalArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri);
+        public virtual double[] ReadDoubleArray(string localName, string namespaceUri);
+        public virtual double[] ReadDoubleArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri);
+        public virtual byte[] ReadElementContentAsBase64();
+        public virtual byte[] ReadElementContentAsBinHex();
+        public override bool ReadElementContentAsBoolean();
+        public override decimal ReadElementContentAsDecimal();
+        public override double ReadElementContentAsDouble();
+        public override float ReadElementContentAsFloat();
+        public virtual Guid ReadElementContentAsGuid();
+        public override int ReadElementContentAsInt();
+        public override long ReadElementContentAsLong();
+        public override string ReadElementContentAsString();
+        public virtual TimeSpan ReadElementContentAsTimeSpan();
+        public virtual UniqueId ReadElementContentAsUniqueId();
+        public virtual void ReadFullStartElement();
+        public virtual void ReadFullStartElement(string name);
+        public virtual void ReadFullStartElement(string localName, string namespaceUri);
+        public virtual void ReadFullStartElement(XmlDictionaryString localName, XmlDictionaryString namespaceUri);
+        public virtual Guid[] ReadGuidArray(string localName, string namespaceUri);
+        public virtual Guid[] ReadGuidArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri);
+        public virtual short[] ReadInt16Array(string localName, string namespaceUri);
+        public virtual short[] ReadInt16Array(XmlDictionaryString localName, XmlDictionaryString namespaceUri);
+        public virtual int[] ReadInt32Array(string localName, string namespaceUri);
+        public virtual int[] ReadInt32Array(XmlDictionaryString localName, XmlDictionaryString namespaceUri);
+        public virtual long[] ReadInt64Array(string localName, string namespaceUri);
+        public virtual long[] ReadInt64Array(XmlDictionaryString localName, XmlDictionaryString namespaceUri);
+        public virtual float[] ReadSingleArray(string localName, string namespaceUri);
+        public virtual float[] ReadSingleArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri);
+        public virtual void ReadStartElement(XmlDictionaryString localName, XmlDictionaryString namespaceUri);
+        public virtual TimeSpan[] ReadTimeSpanArray(string localName, string namespaceUri);
+        public virtual TimeSpan[] ReadTimeSpanArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri);
+        public virtual int ReadValueAsBase64(byte[] buffer, int offset, int count);
+        public virtual void StartCanonicalization(Stream stream, bool includeComments, string[] inclusivePrefixes);
+        public virtual bool TryGetArrayLength(out int count);
+        public virtual bool TryGetBase64ContentLength(out int length);
+        public virtual bool TryGetLocalNameAsDictionaryString(out XmlDictionaryString localName);
+        public virtual bool TryGetNamespaceUriAsDictionaryString(out XmlDictionaryString namespaceUri);
+        public virtual bool TryGetValueAsDictionaryString(out XmlDictionaryString value);
+    }
+    public sealed class XmlDictionaryReaderQuotas {
+        public XmlDictionaryReaderQuotas();
+        public static XmlDictionaryReaderQuotas Max { get; }
+        public int MaxArrayLength { get; set; }
+        public int MaxBytesPerRead { get; set; }
+        public int MaxDepth { get; set; }
+        public int MaxNameTableCharCount { get; set; }
+        public int MaxStringContentLength { get; set; }
+        public XmlDictionaryReaderQuotaTypes ModifiedQuotas { get; }
+        public void CopyTo(XmlDictionaryReaderQuotas quotas);
+    }
+    public enum XmlDictionaryReaderQuotaTypes {
+        MaxArrayLength = 4,
+        MaxBytesPerRead = 8,
+        MaxDepth = 1,
+        MaxNameTableCharCount = 16,
+        MaxStringContentLength = 2,
+    }
+    public class XmlDictionaryString {
+        public XmlDictionaryString(IXmlDictionary dictionary, string value, int key);
+        public IXmlDictionary Dictionary { get; }
+        public static XmlDictionaryString Empty { get; }
+        public int Key { get; }
+        public string Value { get; }
+        public override string ToString();
+    }
+    public abstract class XmlDictionaryWriter : XmlWriter {
+        protected XmlDictionaryWriter();
+        public virtual bool CanCanonicalize { get; }
+        public static XmlDictionaryWriter CreateBinaryWriter(Stream stream);
+        public static XmlDictionaryWriter CreateBinaryWriter(Stream stream, IXmlDictionary dictionary);
+        public static XmlDictionaryWriter CreateBinaryWriter(Stream stream, IXmlDictionary dictionary, XmlBinaryWriterSession session);
+        public static XmlDictionaryWriter CreateBinaryWriter(Stream stream, IXmlDictionary dictionary, XmlBinaryWriterSession session, bool ownsStream);
+        public static XmlDictionaryWriter CreateDictionaryWriter(XmlWriter writer);
+        public static XmlDictionaryWriter CreateTextWriter(Stream stream);
+        public static XmlDictionaryWriter CreateTextWriter(Stream stream, Encoding encoding);
+        public static XmlDictionaryWriter CreateTextWriter(Stream stream, Encoding encoding, bool ownsStream);
+        public virtual void EndCanonicalization();
+        public virtual void StartCanonicalization(Stream stream, bool includeComments, string[] inclusivePrefixes);
+        public virtual void WriteArray(string prefix, string localName, string namespaceUri, bool[] array, int offset, int count);
+        public virtual void WriteArray(string prefix, string localName, string namespaceUri, DateTime[] array, int offset, int count);
+        public virtual void WriteArray(string prefix, string localName, string namespaceUri, decimal[] array, int offset, int count);
+        public virtual void WriteArray(string prefix, string localName, string namespaceUri, double[] array, int offset, int count);
+        public virtual void WriteArray(string prefix, string localName, string namespaceUri, Guid[] array, int offset, int count);
+        public virtual void WriteArray(string prefix, string localName, string namespaceUri, short[] array, int offset, int count);
+        public virtual void WriteArray(string prefix, string localName, string namespaceUri, int[] array, int offset, int count);
+        public virtual void WriteArray(string prefix, string localName, string namespaceUri, long[] array, int offset, int count);
+        public virtual void WriteArray(string prefix, string localName, string namespaceUri, float[] array, int offset, int count);
+        public virtual void WriteArray(string prefix, string localName, string namespaceUri, TimeSpan[] array, int offset, int count);
+        public virtual void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, bool[] array, int offset, int count);
+        public virtual void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, DateTime[] array, int offset, int count);
+        public virtual void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, decimal[] array, int offset, int count);
+        public virtual void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, double[] array, int offset, int count);
+        public virtual void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Guid[] array, int offset, int count);
+        public virtual void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, short[] array, int offset, int count);
+        public virtual void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, int[] array, int offset, int count);
+        public virtual void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, long[] array, int offset, int count);
+        public virtual void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, float[] array, int offset, int count);
+        public virtual void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, TimeSpan[] array, int offset, int count);
+        public void WriteAttributeString(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, string value);
+        public void WriteAttributeString(XmlDictionaryString localName, XmlDictionaryString namespaceUri, string value);
+        public void WriteElementString(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, string value);
+        public void WriteElementString(XmlDictionaryString localName, XmlDictionaryString namespaceUri, string value);
+        public virtual void WriteNode(XmlDictionaryReader reader, bool defattr);
+        public override void WriteNode(XmlReader reader, bool defattr);
+        public virtual void WriteQualifiedName(XmlDictionaryString localName, XmlDictionaryString namespaceUri);
+        public virtual void WriteStartAttribute(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri);
+        public void WriteStartAttribute(XmlDictionaryString localName, XmlDictionaryString namespaceUri);
+        public virtual void WriteStartElement(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri);
+        public void WriteStartElement(XmlDictionaryString localName, XmlDictionaryString namespaceUri);
+        public virtual void WriteString(XmlDictionaryString value);
+        protected virtual void WriteTextNode(XmlDictionaryReader reader, bool isAttribute);
+        public virtual void WriteValue(Guid value);
+        public virtual void WriteValue(TimeSpan value);
+        public virtual void WriteValue(UniqueId value);
+        public virtual void WriteValue(XmlDictionaryString value);
+        public virtual void WriteXmlAttribute(string localName, string value);
+        public virtual void WriteXmlAttribute(XmlDictionaryString localName, XmlDictionaryString value);
+        public virtual void WriteXmlnsAttribute(string prefix, string namespaceUri);
+        public virtual void WriteXmlnsAttribute(string prefix, XmlDictionaryString namespaceUri);
+    }
+    public class XmlDocument : XmlNode {
+        public XmlDocument();
+        protected internal XmlDocument(XmlImplementation imp);
+        public XmlDocument(XmlNameTable nt);
+        public override string BaseURI { get; }
+        public XmlElement DocumentElement { get; }
+        public XmlImplementation Implementation { get; }
+        public override string InnerText { set; }
+        public override string InnerXml { get; set; }
+        public override bool IsReadOnly { get; }
+        public override string LocalName { get; }
+        public override string Name { get; }
+        public XmlNameTable NameTable { get; }
+        public override XmlNodeType NodeType { get; }
+        public override XmlDocument OwnerDocument { get; }
+        public override XmlNode ParentNode { get; }
+        public bool PreserveWhitespace { get; set; }
+        public event XmlNodeChangedEventHandler NodeChanged;
+        public event XmlNodeChangedEventHandler NodeChanging;
+        public event XmlNodeChangedEventHandler NodeInserted;
+        public event XmlNodeChangedEventHandler NodeInserting;
+        public event XmlNodeChangedEventHandler NodeRemoved;
+        public event XmlNodeChangedEventHandler NodeRemoving;
+        public override XmlNode CloneNode(bool deep);
+        public XmlAttribute CreateAttribute(string name);
+        public XmlAttribute CreateAttribute(string qualifiedName, string namespaceURI);
+        public virtual XmlAttribute CreateAttribute(string prefix, string localName, string namespaceURI);
+        public virtual XmlCDataSection CreateCDataSection(string data);
+        public virtual XmlComment CreateComment(string data);
+        public virtual XmlDocumentFragment CreateDocumentFragment();
+        public XmlElement CreateElement(string name);
+        public XmlElement CreateElement(string qualifiedName, string namespaceURI);
+        public virtual XmlElement CreateElement(string prefix, string localName, string namespaceURI);
+        public virtual XmlNode CreateNode(string nodeTypeString, string name, string namespaceURI);
+        public virtual XmlNode CreateNode(XmlNodeType type, string name, string namespaceURI);
+        public virtual XmlNode CreateNode(XmlNodeType type, string prefix, string name, string namespaceURI);
+        public virtual XmlProcessingInstruction CreateProcessingInstruction(string target, string data);
+        public virtual XmlSignificantWhitespace CreateSignificantWhitespace(string text);
+        public virtual XmlText CreateTextNode(string text);
+        public virtual XmlWhitespace CreateWhitespace(string text);
+        public virtual XmlDeclaration CreateXmlDeclaration(string version, string encoding, string standalone);
+        public virtual XmlNodeList GetElementsByTagName(string name);
+        public virtual XmlNodeList GetElementsByTagName(string localName, string namespaceURI);
+        public virtual XmlNode ImportNode(XmlNode node, bool deep);
+        public virtual void Load(Stream inStream);
+        public virtual void Load(TextReader txtReader);
+        public virtual void Load(XmlReader reader);
+        public virtual void LoadXml(string xml);
+        public virtual XmlNode ReadNode(XmlReader reader);
+        public virtual void Save(Stream outStream);
+        public virtual void Save(TextWriter writer);
+        public virtual void Save(XmlWriter w);
+        public override void WriteContentTo(XmlWriter xw);
+        public override void WriteTo(XmlWriter w);
+    }
+    public class XmlDocumentFragment : XmlNode {
+        protected internal XmlDocumentFragment(XmlDocument ownerDocument);
+        public override string InnerXml { get; set; }
+        public override string LocalName { get; }
+        public override string Name { get; }
+        public override XmlNodeType NodeType { get; }
+        public override XmlDocument OwnerDocument { get; }
+        public override XmlNode ParentNode { get; }
+        public override XmlNode CloneNode(bool deep);
+        public override void WriteContentTo(XmlWriter w);
+        public override void WriteTo(XmlWriter w);
+    }
+    public static class XmlDocumentXPathExtensions {
+        public static XPathNavigator CreateNavigator(this XmlDocument document);
+        public static XPathNavigator CreateNavigator(this XmlDocument document, XmlNode node);
+        public static XPathNavigator CreateNavigator(this XmlNode node);
+        public static XmlNodeList SelectNodes(this XmlNode node, string xpath);
+        public static XmlNodeList SelectNodes(this XmlNode node, string xpath, XmlNamespaceManager nsmgr);
+        public static XmlNode SelectSingleNode(this XmlNode node, string xpath);
+        public static XmlNode SelectSingleNode(this XmlNode node, string xpath, XmlNamespaceManager nsmgr);
+        public static IXPathNavigable ToXPathNavigable(this XmlNode node);
+    }
+    public class XmlElement : XmlLinkedNode {
+        protected internal XmlElement(string prefix, string localName, string namespaceURI, XmlDocument doc);
+        public override XmlAttributeCollection Attributes { get; }
+        public virtual bool HasAttributes { get; }
+        public override string InnerText { get; set; }
+        public override string InnerXml { get; set; }
+        public bool IsEmpty { get; set; }
+        public override string LocalName { get; }
+        public override string Name { get; }
+        public override string NamespaceURI { get; }
+        public override XmlNode NextSibling { get; }
+        public override XmlNodeType NodeType { get; }
+        public override XmlDocument OwnerDocument { get; }
+        public override XmlNode ParentNode { get; }
+        public override string Prefix { get; set; }
+        public override XmlNode CloneNode(bool deep);
+        public virtual string GetAttribute(string name);
+        public virtual string GetAttribute(string localName, string namespaceURI);
+        public virtual XmlAttribute GetAttributeNode(string name);
+        public virtual XmlAttribute GetAttributeNode(string localName, string namespaceURI);
+        public virtual XmlNodeList GetElementsByTagName(string name);
+        public virtual XmlNodeList GetElementsByTagName(string localName, string namespaceURI);
+        public virtual bool HasAttribute(string name);
+        public virtual bool HasAttribute(string localName, string namespaceURI);
+        public override void RemoveAll();
+        public virtual void RemoveAllAttributes();
+        public virtual void RemoveAttribute(string name);
+        public virtual void RemoveAttribute(string localName, string namespaceURI);
+        public virtual XmlNode RemoveAttributeAt(int i);
+        public virtual XmlAttribute RemoveAttributeNode(string localName, string namespaceURI);
+        public virtual XmlAttribute RemoveAttributeNode(XmlAttribute oldAttr);
+        public virtual void SetAttribute(string name, string value);
+        public virtual string SetAttribute(string localName, string namespaceURI, string value);
+        public virtual XmlAttribute SetAttributeNode(string localName, string namespaceURI);
+        public virtual XmlAttribute SetAttributeNode(XmlAttribute newAttr);
+        public override void WriteContentTo(XmlWriter w);
+        public override void WriteTo(XmlWriter w);
+    }
+    public class XmlImplementation {
+        public XmlImplementation();
+        public XmlImplementation(XmlNameTable nt);
+        public virtual XmlDocument CreateDocument();
+        public bool HasFeature(string strFeature, string strVersion);
+    }
+    public abstract class XmlLinkedNode : XmlNode {
+        public override XmlNode NextSibling { get; }
+        public override XmlNode PreviousSibling { get; }
+    }
+    public class XmlNamedNodeMap : IEnumerable {
+        public virtual int Count { get; }
+        public virtual IEnumerator GetEnumerator();
+        public virtual XmlNode GetNamedItem(string name);
+        public virtual XmlNode GetNamedItem(string localName, string namespaceURI);
+        public virtual XmlNode Item(int index);
+        public virtual XmlNode RemoveNamedItem(string name);
+        public virtual XmlNode RemoveNamedItem(string localName, string namespaceURI);
+        public virtual XmlNode SetNamedItem(XmlNode node);
+    }
+    public abstract class XmlNode : IEnumerable {
+        public virtual XmlAttributeCollection Attributes { get; }
+        public virtual string BaseURI { get; }
+        public virtual XmlNodeList ChildNodes { get; }
+        public virtual XmlNode FirstChild { get; }
+        public virtual bool HasChildNodes { get; }
+        public virtual string InnerText { get; set; }
+        public virtual string InnerXml { get; set; }
+        public virtual bool IsReadOnly { get; }
+        public virtual XmlNode LastChild { get; }
+        public abstract string LocalName { get; }
+        public abstract string Name { get; }
+        public virtual string NamespaceURI { get; }
+        public virtual XmlNode NextSibling { get; }
+        public abstract XmlNodeType NodeType { get; }
+        public virtual string OuterXml { get; }
+        public virtual XmlDocument OwnerDocument { get; }
+        public virtual XmlNode ParentNode { get; }
+        public virtual string Prefix { get; set; }
+        public virtual XmlNode PreviousSibling { get; }
+        public virtual XmlNode PreviousText { get; }
+        public virtual XmlElement this[string localname, string ns] { get; }
+        public virtual XmlElement this[string name] { get; }
+        public virtual string Value { get; set; }
+        public virtual XmlNode AppendChild(XmlNode newChild);
+        public abstract XmlNode CloneNode(bool deep);
+        public IEnumerator GetEnumerator();
+        public virtual string GetNamespaceOfPrefix(string prefix);
+        public virtual string GetPrefixOfNamespace(string namespaceURI);
+        public virtual XmlNode InsertAfter(XmlNode newChild, XmlNode refChild);
+        public virtual XmlNode InsertBefore(XmlNode newChild, XmlNode refChild);
+        public virtual void Normalize();
+        public virtual XmlNode PrependChild(XmlNode newChild);
+        public virtual void RemoveAll();
+        public virtual XmlNode RemoveChild(XmlNode oldChild);
+        public virtual XmlNode ReplaceChild(XmlNode newChild, XmlNode oldChild);
+        public virtual bool Supports(string feature, string version);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        public abstract void WriteContentTo(XmlWriter w);
+        public abstract void WriteTo(XmlWriter w);
+    }
+    public enum XmlNodeChangedAction {
+        Change = 2,
+        Insert = 0,
+        Remove = 1,
+    }
+    public class XmlNodeChangedEventArgs : EventArgs {
+        public XmlNodeChangedEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action);
+        public XmlNodeChangedAction Action { get; }
+        public XmlNode NewParent { get; }
+        public string NewValue { get; }
+        public XmlNode Node { get; }
+        public XmlNode OldParent { get; }
+        public string OldValue { get; }
+    }
+    public delegate void XmlNodeChangedEventHandler(object sender, XmlNodeChangedEventArgs e);
+    public abstract class XmlNodeList : IDisposable, IEnumerable {
+        protected XmlNodeList();
+        public abstract int Count { get; }
+        [System.Runtime.CompilerServices.IndexerName("ItemOf")]
+        public virtual XmlNode this[int i] { get; }
+        public abstract IEnumerator GetEnumerator();
+        public abstract XmlNode Item(int index);
+        protected virtual void PrivateDisposeNodeList();
+        void System.IDisposable.Dispose();
+    }
+    public enum XmlNodeOrder {
+        After = 1,
+        Before = 0,
+        Same = 2,
+        Unknown = 3,
+    }
+    public class XmlProcessingInstruction : XmlLinkedNode {
+        protected internal XmlProcessingInstruction(string target, string data, XmlDocument doc);
+        public string Data { get; set; }
+        public override string InnerText { get; set; }
+        public override string LocalName { get; }
+        public override string Name { get; }
+        public override XmlNodeType NodeType { get; }
+        public string Target { get; }
+        public override string Value { get; set; }
+        public override XmlNode CloneNode(bool deep);
+        public override void WriteContentTo(XmlWriter w);
+        public override void WriteTo(XmlWriter w);
+    }
+    public class XmlSignificantWhitespace : XmlCharacterData {
+        protected internal XmlSignificantWhitespace(string strData, XmlDocument doc);
+        public override string LocalName { get; }
+        public override string Name { get; }
+        public override XmlNodeType NodeType { get; }
+        public override XmlNode ParentNode { get; }
+        public override XmlNode PreviousText { get; }
+        public override string Value { get; set; }
+        public override XmlNode CloneNode(bool deep);
+        public override void WriteContentTo(XmlWriter w);
+        public override void WriteTo(XmlWriter w);
+    }
+    public class XmlText : XmlCharacterData {
+        protected internal XmlText(string strData, XmlDocument doc);
+        public override string LocalName { get; }
+        public override string Name { get; }
+        public override XmlNodeType NodeType { get; }
+        public override XmlNode ParentNode { get; }
+        public override XmlNode PreviousText { get; }
+        public override string Value { get; set; }
+        public override XmlNode CloneNode(bool deep);
+        public virtual XmlText SplitText(int offset);
+        public override void WriteContentTo(XmlWriter w);
+        public override void WriteTo(XmlWriter w);
+    }
+    public class XmlWhitespace : XmlCharacterData {
+        protected internal XmlWhitespace(string strData, XmlDocument doc);
+        public override string LocalName { get; }
+        public override string Name { get; }
+        public override XmlNodeType NodeType { get; }
+        public override XmlNode ParentNode { get; }
+        public override XmlNode PreviousText { get; }
+        public override string Value { get; set; }
+        public override XmlNode CloneNode(bool deep);
+        public override void WriteContentTo(XmlWriter w);
+        public override void WriteTo(XmlWriter w);
+    }
 }
```

