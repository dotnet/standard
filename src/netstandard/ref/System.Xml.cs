// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Xml
{
    public enum ConformanceLevel
    {
        Auto = 0,
        Document = 2,
        Fragment = 1,
    }
    public enum DtdProcessing
    {
        Ignore = 1,
        Parse = 2,
        Prohibit = 0,
    }
    public enum EntityHandling
    {
        ExpandCharEntities = 2,
        ExpandEntities = 1,
    }
    public enum Formatting
    {
        Indented = 1,
        None = 0,
    }
    public partial interface IFragmentCapableXmlDictionaryWriter
    {
        bool CanFragment { get; }
        void EndFragment();
        void StartFragment(System.IO.Stream stream, bool generateSelfContainedTextFragment);
        void WriteFragment(byte[] buffer, int offset, int count);
    }
    public partial interface IHasXmlNode
    {
        System.Xml.XmlNode GetNode();
    }
    public partial interface IStreamProvider
    {
        System.IO.Stream GetStream();
        void ReleaseStream(System.IO.Stream stream);
    }
    public partial interface IXmlBinaryReaderInitializer
    {
        void SetInput(byte[] buffer, int offset, int count, System.Xml.IXmlDictionary dictionary, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.XmlBinaryReaderSession session, System.Xml.OnXmlDictionaryReaderClose onClose);
        void SetInput(System.IO.Stream stream, System.Xml.IXmlDictionary dictionary, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.XmlBinaryReaderSession session, System.Xml.OnXmlDictionaryReaderClose onClose);
    }
    public partial interface IXmlBinaryWriterInitializer
    {
        void SetOutput(System.IO.Stream stream, System.Xml.IXmlDictionary dictionary, System.Xml.XmlBinaryWriterSession session, bool ownsStream);
    }
    public partial interface IXmlDictionary
    {
        bool TryLookup(int key, out System.Xml.XmlDictionaryString result);
        bool TryLookup(string value, out System.Xml.XmlDictionaryString result);
        bool TryLookup(System.Xml.XmlDictionaryString value, out System.Xml.XmlDictionaryString result);
    }
    public partial interface IXmlLineInfo
    {
        int LineNumber { get; }
        int LinePosition { get; }
        bool HasLineInfo();
    }
    public partial interface IXmlNamespaceResolver
    {
        System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
        string LookupNamespace(string prefix);
        string LookupPrefix(string namespaceName);
    }
    public partial interface IXmlTextReaderInitializer
    {
        void SetInput(byte[] buffer, int offset, int count, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose onClose);
        void SetInput(System.IO.Stream stream, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose onClose);
    }
    public partial interface IXmlTextWriterInitializer
    {
        void SetOutput(System.IO.Stream stream, System.Text.Encoding encoding, bool ownsStream);
    }
    [System.FlagsAttribute]
    public enum NamespaceHandling
    {
        Default = 0,
        OmitDuplicates = 1,
    }
    public partial class NameTable : System.Xml.XmlNameTable
    {
        public NameTable() { }
        public override string Add(char[] key, int start, int len) { throw null; }
        public override string Add(string key) { throw null; }
        public override string Get(char[] key, int start, int len) { throw null; }
        public override string Get(string value) { throw null; }
    }
    public enum NewLineHandling
    {
        Entitize = 1,
        None = 2,
        Replace = 0,
    }
    public delegate void OnXmlDictionaryReaderClose(System.Xml.XmlDictionaryReader reader);
    public enum ReadState
    {
        Closed = 4,
        EndOfFile = 3,
        Error = 2,
        Initial = 0,
        Interactive = 1,
    }
    public partial class UniqueId
    {
        public UniqueId() { }
        public UniqueId(byte[] guid) { }
        public UniqueId(byte[] guid, int offset) { }
        public UniqueId(char[] chars, int offset, int count) { }
        public UniqueId(System.Guid guid) { }
        public UniqueId(string value) { }
        public int CharArrayLength { get { throw null; } }
        public bool IsGuid { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Xml.UniqueId id1, System.Xml.UniqueId id2) { throw null; }
        public static bool operator !=(System.Xml.UniqueId id1, System.Xml.UniqueId id2) { throw null; }
        public int ToCharArray(char[] chars, int offset) { throw null; }
        public override string ToString() { throw null; }
        public bool TryGetGuid(byte[] buffer, int offset) { throw null; }
        public bool TryGetGuid(out System.Guid guid) { throw null; }
    }
    public enum ValidationType
    {
        [System.ObsoleteAttribute("Validation type should be specified as DTD or Schema.")]
        Auto = 1,
        DTD = 2,
        None = 0,
        Schema = 4,
        [System.ObsoleteAttribute("XDR Validation through XmlValidatingReader is obsoleted")]
        XDR = 3,
    }
    public enum WhitespaceHandling
    {
        All = 0,
        None = 2,
        Significant = 1,
    }
    public enum WriteState
    {
        Attribute = 3,
        Closed = 5,
        Content = 4,
        Element = 2,
        Error = 6,
        Prolog = 1,
        Start = 0,
    }
    public partial class XmlAttribute : System.Xml.XmlNode
    {
        protected internal XmlAttribute(string prefix, string localName, string namespaceURI, System.Xml.XmlDocument doc) { }
        public override string BaseURI { get { throw null; } }
        public override string InnerText { set { } }
        public override string InnerXml { set { } }
        public override string LocalName { get { throw null; } }
        public override string Name { get { throw null; } }
        public override string NamespaceURI { get { throw null; } }
        public override System.Xml.XmlNodeType NodeType { get { throw null; } }
        public override System.Xml.XmlDocument OwnerDocument { get { throw null; } }
        public virtual System.Xml.XmlElement OwnerElement { get { throw null; } }
        public override System.Xml.XmlNode ParentNode { get { throw null; } }
        public override string Prefix { get { throw null; } set { } }
        public override System.Xml.Schema.IXmlSchemaInfo SchemaInfo { get { throw null; } }
        public virtual bool Specified { get { throw null; } }
        public override string Value { get { throw null; } set { } }
        public override System.Xml.XmlNode AppendChild(System.Xml.XmlNode newChild) { throw null; }
        public override System.Xml.XmlNode CloneNode(bool deep) { throw null; }
        public override System.Xml.XmlNode InsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild) { throw null; }
        public override System.Xml.XmlNode InsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild) { throw null; }
        public override System.Xml.XmlNode PrependChild(System.Xml.XmlNode newChild) { throw null; }
        public override System.Xml.XmlNode RemoveChild(System.Xml.XmlNode oldChild) { throw null; }
        public override System.Xml.XmlNode ReplaceChild(System.Xml.XmlNode newChild, System.Xml.XmlNode oldChild) { throw null; }
        public override void WriteContentTo(System.Xml.XmlWriter w) { }
        public override void WriteTo(System.Xml.XmlWriter w) { }
    }
    public sealed partial class XmlAttributeCollection : System.Xml.XmlNamedNodeMap, System.Collections.ICollection, System.Collections.IEnumerable
    {
        internal XmlAttributeCollection() { }
        [System.Runtime.CompilerServices.IndexerName("ItemOf")]
        public System.Xml.XmlAttribute this[int i] { get { throw null; } }
        [System.Runtime.CompilerServices.IndexerName("ItemOf")]
        public System.Xml.XmlAttribute this[string name] { get { throw null; } }
        [System.Runtime.CompilerServices.IndexerName("ItemOf")]
        public System.Xml.XmlAttribute this[string localName, string namespaceURI] { get { throw null; } }
        int System.Collections.ICollection.Count { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        public System.Xml.XmlAttribute Append(System.Xml.XmlAttribute node) { throw null; }
        public void CopyTo(System.Xml.XmlAttribute[] array, int index) { }
        public System.Xml.XmlAttribute InsertAfter(System.Xml.XmlAttribute newNode, System.Xml.XmlAttribute refNode) { throw null; }
        public System.Xml.XmlAttribute InsertBefore(System.Xml.XmlAttribute newNode, System.Xml.XmlAttribute refNode) { throw null; }
        public System.Xml.XmlAttribute Prepend(System.Xml.XmlAttribute node) { throw null; }
        public System.Xml.XmlAttribute Remove(System.Xml.XmlAttribute node) { throw null; }
        public void RemoveAll() { }
        public System.Xml.XmlAttribute RemoveAt(int i) { throw null; }
        public override System.Xml.XmlNode SetNamedItem(System.Xml.XmlNode node) { throw null; }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    }
    public partial class XmlBinaryReaderSession : System.Xml.IXmlDictionary
    {
        public XmlBinaryReaderSession() { }
        public System.Xml.XmlDictionaryString Add(int id, string value) { throw null; }
        public void Clear() { }
        public bool TryLookup(int key, out System.Xml.XmlDictionaryString result) { throw null; }
        public bool TryLookup(string value, out System.Xml.XmlDictionaryString result) { throw null; }
        public bool TryLookup(System.Xml.XmlDictionaryString value, out System.Xml.XmlDictionaryString result) { throw null; }
    }
    public partial class XmlBinaryWriterSession
    {
        public XmlBinaryWriterSession() { }
        public void Reset() { }
        public virtual bool TryAdd(System.Xml.XmlDictionaryString value, out int key) { throw null; }
    }
    public partial class XmlCDataSection : System.Xml.XmlCharacterData
    {
        protected internal XmlCDataSection(string data, System.Xml.XmlDocument doc) : base (default(string), default(System.Xml.XmlDocument)) { }
        public override string LocalName { get { throw null; } }
        public override string Name { get { throw null; } }
        public override System.Xml.XmlNodeType NodeType { get { throw null; } }
        public override System.Xml.XmlNode ParentNode { get { throw null; } }
        public override System.Xml.XmlNode PreviousText { get { throw null; } }
        public override System.Xml.XmlNode CloneNode(bool deep) { throw null; }
        public override void WriteContentTo(System.Xml.XmlWriter w) { }
        public override void WriteTo(System.Xml.XmlWriter w) { }
    }
    public abstract partial class XmlCharacterData : System.Xml.XmlLinkedNode
    {
        protected internal XmlCharacterData(string data, System.Xml.XmlDocument doc) { }
        public virtual string Data { get { throw null; } set { } }
        public override string InnerText { get { throw null; } set { } }
        public virtual int Length { get { throw null; } }
        public override string Value { get { throw null; } set { } }
        public virtual void AppendData(string strData) { }
        public virtual void DeleteData(int offset, int count) { }
        public virtual void InsertData(int offset, string strData) { }
        public virtual void ReplaceData(int offset, int count, string strData) { }
        public virtual string Substring(int offset, int count) { throw null; }
    }
    public partial class XmlComment : System.Xml.XmlCharacterData
    {
        protected internal XmlComment(string comment, System.Xml.XmlDocument doc) : base (default(string), default(System.Xml.XmlDocument)) { }
        public override string LocalName { get { throw null; } }
        public override string Name { get { throw null; } }
        public override System.Xml.XmlNodeType NodeType { get { throw null; } }
        public override System.Xml.XmlNode CloneNode(bool deep) { throw null; }
        public override void WriteContentTo(System.Xml.XmlWriter w) { }
        public override void WriteTo(System.Xml.XmlWriter w) { }
    }
    public partial class XmlConvert
    {
        public XmlConvert() { }
        public static string DecodeName(string name) { throw null; }
        public static string EncodeLocalName(string name) { throw null; }
        public static string EncodeName(string name) { throw null; }
        public static string EncodeNmToken(string name) { throw null; }
        public static bool IsNCNameChar(char ch) { throw null; }
        public static bool IsPublicIdChar(char ch) { throw null; }
        public static bool IsStartNCNameChar(char ch) { throw null; }
        public static bool IsWhitespaceChar(char ch) { throw null; }
        public static bool IsXmlChar(char ch) { throw null; }
        public static bool IsXmlSurrogatePair(char lowChar, char highChar) { throw null; }
        public static bool ToBoolean(string s) { throw null; }
        public static byte ToByte(string s) { throw null; }
        public static char ToChar(string s) { throw null; }
        [System.ObsoleteAttribute("Use XmlConvert.ToDateTime() that takes in XmlDateTimeSerializationMode")]
        public static System.DateTime ToDateTime(string s) { throw null; }
        public static System.DateTime ToDateTime(string s, string format) { throw null; }
        public static System.DateTime ToDateTime(string s, string[] formats) { throw null; }
        public static System.DateTime ToDateTime(string s, System.Xml.XmlDateTimeSerializationMode dateTimeOption) { throw null; }
        public static System.DateTimeOffset ToDateTimeOffset(string s) { throw null; }
        public static System.DateTimeOffset ToDateTimeOffset(string s, string format) { throw null; }
        public static System.DateTimeOffset ToDateTimeOffset(string s, string[] formats) { throw null; }
        public static decimal ToDecimal(string s) { throw null; }
        public static double ToDouble(string s) { throw null; }
        public static System.Guid ToGuid(string s) { throw null; }
        public static short ToInt16(string s) { throw null; }
        public static int ToInt32(string s) { throw null; }
        public static long ToInt64(string s) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(string s) { throw null; }
        public static float ToSingle(string s) { throw null; }
        public static string ToString(bool value) { throw null; }
        public static string ToString(byte value) { throw null; }
        public static string ToString(char value) { throw null; }
        [System.ObsoleteAttribute("Use XmlConvert.ToString() that takes in XmlDateTimeSerializationMode")]
        public static string ToString(System.DateTime value) { throw null; }
        public static string ToString(System.DateTime value, string format) { throw null; }
        public static string ToString(System.DateTime value, System.Xml.XmlDateTimeSerializationMode dateTimeOption) { throw null; }
        public static string ToString(System.DateTimeOffset value) { throw null; }
        public static string ToString(System.DateTimeOffset value, string format) { throw null; }
        public static string ToString(decimal value) { throw null; }
        public static string ToString(double value) { throw null; }
        public static string ToString(System.Guid value) { throw null; }
        public static string ToString(short value) { throw null; }
        public static string ToString(int value) { throw null; }
        public static string ToString(long value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static string ToString(sbyte value) { throw null; }
        public static string ToString(float value) { throw null; }
        public static string ToString(System.TimeSpan value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static string ToString(ushort value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static string ToString(uint value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static string ToString(ulong value) { throw null; }
        public static System.TimeSpan ToTimeSpan(string s) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(string s) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(string s) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(string s) { throw null; }
        public static string VerifyName(string name) { throw null; }
        public static string VerifyNCName(string name) { throw null; }
        public static string VerifyNMTOKEN(string name) { throw null; }
        public static string VerifyPublicId(string publicId) { throw null; }
        public static string VerifyTOKEN(string token) { throw null; }
        public static string VerifyWhitespace(string content) { throw null; }
        public static string VerifyXmlChars(string content) { throw null; }
    }
    public enum XmlDateTimeSerializationMode
    {
        Local = 0,
        RoundtripKind = 3,
        Unspecified = 2,
        Utc = 1,
    }
    public partial class XmlDeclaration : System.Xml.XmlLinkedNode
    {
        protected internal XmlDeclaration(string version, string encoding, string standalone, System.Xml.XmlDocument doc) { }
        public string Encoding { get { throw null; } set { } }
        public override string InnerText { get { throw null; } set { } }
        public override string LocalName { get { throw null; } }
        public override string Name { get { throw null; } }
        public override System.Xml.XmlNodeType NodeType { get { throw null; } }
        public string Standalone { get { throw null; } set { } }
        public override string Value { get { throw null; } set { } }
        public string Version { get { throw null; } }
        public override System.Xml.XmlNode CloneNode(bool deep) { throw null; }
        public override void WriteContentTo(System.Xml.XmlWriter w) { }
        public override void WriteTo(System.Xml.XmlWriter w) { }
    }
    public partial class XmlDictionary : System.Xml.IXmlDictionary
    {
        public XmlDictionary() { }
        public XmlDictionary(int capacity) { }
        public static System.Xml.IXmlDictionary Empty { get { throw null; } }
        public virtual System.Xml.XmlDictionaryString Add(string value) { throw null; }
        public virtual bool TryLookup(int key, out System.Xml.XmlDictionaryString result) { throw null; }
        public virtual bool TryLookup(string value, out System.Xml.XmlDictionaryString result) { throw null; }
        public virtual bool TryLookup(System.Xml.XmlDictionaryString value, out System.Xml.XmlDictionaryString result) { throw null; }
    }
    public abstract partial class XmlDictionaryReader : System.Xml.XmlReader
    {
        protected XmlDictionaryReader() { }
        public virtual bool CanCanonicalize { get { throw null; } }
        public virtual System.Xml.XmlDictionaryReaderQuotas Quotas { get { throw null; } }
        public static System.Xml.XmlDictionaryReader CreateBinaryReader(byte[] buffer, int offset, int count, System.Xml.IXmlDictionary dictionary, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateBinaryReader(byte[] buffer, int offset, int count, System.Xml.IXmlDictionary dictionary, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.XmlBinaryReaderSession session) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateBinaryReader(byte[] buffer, int offset, int count, System.Xml.IXmlDictionary dictionary, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.XmlBinaryReaderSession session, System.Xml.OnXmlDictionaryReaderClose onClose) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateBinaryReader(byte[] buffer, int offset, int count, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateBinaryReader(byte[] buffer, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateBinaryReader(System.IO.Stream stream, System.Xml.IXmlDictionary dictionary, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateBinaryReader(System.IO.Stream stream, System.Xml.IXmlDictionary dictionary, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.XmlBinaryReaderSession session) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateBinaryReader(System.IO.Stream stream, System.Xml.IXmlDictionary dictionary, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.XmlBinaryReaderSession session, System.Xml.OnXmlDictionaryReaderClose onClose) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateBinaryReader(System.IO.Stream stream, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateDictionaryReader(System.Xml.XmlReader reader) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateMtomReader(byte[] buffer, int offset, int count, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateMtomReader(byte[] buffer, int offset, int count, System.Text.Encoding[] encodings, string contentType, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateMtomReader(byte[] buffer, int offset, int count, System.Text.Encoding[] encodings, string contentType, System.Xml.XmlDictionaryReaderQuotas quotas, int maxBufferSize, System.Xml.OnXmlDictionaryReaderClose onClose) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateMtomReader(byte[] buffer, int offset, int count, System.Text.Encoding[] encodings, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateMtomReader(System.IO.Stream stream, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateMtomReader(System.IO.Stream stream, System.Text.Encoding[] encodings, string contentType, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateMtomReader(System.IO.Stream stream, System.Text.Encoding[] encodings, string contentType, System.Xml.XmlDictionaryReaderQuotas quotas, int maxBufferSize, System.Xml.OnXmlDictionaryReaderClose onClose) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateMtomReader(System.IO.Stream stream, System.Text.Encoding[] encodings, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateTextReader(byte[] buffer, int offset, int count, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose onClose) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateTextReader(byte[] buffer, int offset, int count, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateTextReader(byte[] buffer, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateTextReader(System.IO.Stream stream, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose onClose) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateTextReader(System.IO.Stream stream, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public virtual void EndCanonicalization() { }
        public virtual string GetAttribute(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual void GetNonAtomizedNames(out string localName, out string namespaceUri) { throw null; }
        public virtual int IndexOfLocalName(string[] localNames, string namespaceUri) { throw null; }
        public virtual int IndexOfLocalName(System.Xml.XmlDictionaryString[] localNames, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual bool IsLocalName(string localName) { throw null; }
        public virtual bool IsLocalName(System.Xml.XmlDictionaryString localName) { throw null; }
        public virtual bool IsNamespaceUri(string namespaceUri) { throw null; }
        public virtual bool IsNamespaceUri(System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual bool IsStartArray(out System.Type type) { throw null; }
        public virtual bool IsStartElement(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        protected bool IsTextNode(System.Xml.XmlNodeType nodeType) { throw null; }
        public virtual void MoveToStartElement() { }
        public virtual void MoveToStartElement(string name) { }
        public virtual void MoveToStartElement(string localName, string namespaceUri) { }
        public virtual void MoveToStartElement(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
        public virtual int ReadArray(string localName, string namespaceUri, bool[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(string localName, string namespaceUri, System.DateTime[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(string localName, string namespaceUri, decimal[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(string localName, string namespaceUri, double[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(string localName, string namespaceUri, System.Guid[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(string localName, string namespaceUri, short[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(string localName, string namespaceUri, int[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(string localName, string namespaceUri, long[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(string localName, string namespaceUri, float[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(string localName, string namespaceUri, System.TimeSpan[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, bool[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.DateTime[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, decimal[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, double[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.Guid[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, short[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, int[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, long[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, float[] array, int offset, int count) { throw null; }
        public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.TimeSpan[] array, int offset, int count) { throw null; }
        public virtual bool[] ReadBooleanArray(string localName, string namespaceUri) { throw null; }
        public virtual bool[] ReadBooleanArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public override object ReadContentAs(System.Type type, System.Xml.IXmlNamespaceResolver namespaceResolver) { throw null; }
        public virtual byte[] ReadContentAsBase64() { throw null; }
        public virtual byte[] ReadContentAsBinHex() { throw null; }
        protected byte[] ReadContentAsBinHex(int maxByteArrayContentLength) { throw null; }
        public virtual int ReadContentAsChars(char[] chars, int offset, int count) { throw null; }
        public override decimal ReadContentAsDecimal() { throw null; }
        public override float ReadContentAsFloat() { throw null; }
        public virtual System.Guid ReadContentAsGuid() { throw null; }
        public virtual void ReadContentAsQualifiedName(out string localName, out string namespaceUri) { throw null; }
        public override string ReadContentAsString() { throw null; }
        protected string ReadContentAsString(int maxStringContentLength) { throw null; }
        public virtual string ReadContentAsString(string[] strings, out int index) { throw null; }
        public virtual string ReadContentAsString(System.Xml.XmlDictionaryString[] strings, out int index) { throw null; }
        public virtual System.TimeSpan ReadContentAsTimeSpan() { throw null; }
        public virtual System.Xml.UniqueId ReadContentAsUniqueId() { throw null; }
        public virtual System.DateTime[] ReadDateTimeArray(string localName, string namespaceUri) { throw null; }
        public virtual System.DateTime[] ReadDateTimeArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual decimal[] ReadDecimalArray(string localName, string namespaceUri) { throw null; }
        public virtual decimal[] ReadDecimalArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual double[] ReadDoubleArray(string localName, string namespaceUri) { throw null; }
        public virtual double[] ReadDoubleArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual byte[] ReadElementContentAsBase64() { throw null; }
        public virtual byte[] ReadElementContentAsBinHex() { throw null; }
        public override bool ReadElementContentAsBoolean() { throw null; }
        public override System.DateTime ReadElementContentAsDateTime() { throw null; }
        public override decimal ReadElementContentAsDecimal() { throw null; }
        public override double ReadElementContentAsDouble() { throw null; }
        public override float ReadElementContentAsFloat() { throw null; }
        public virtual System.Guid ReadElementContentAsGuid() { throw null; }
        public override int ReadElementContentAsInt() { throw null; }
        public override long ReadElementContentAsLong() { throw null; }
        public override string ReadElementContentAsString() { throw null; }
        public virtual System.TimeSpan ReadElementContentAsTimeSpan() { throw null; }
        public virtual System.Xml.UniqueId ReadElementContentAsUniqueId() { throw null; }
        public virtual void ReadFullStartElement() { }
        public virtual void ReadFullStartElement(string name) { }
        public virtual void ReadFullStartElement(string localName, string namespaceUri) { }
        public virtual void ReadFullStartElement(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
        public virtual System.Guid[] ReadGuidArray(string localName, string namespaceUri) { throw null; }
        public virtual System.Guid[] ReadGuidArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual short[] ReadInt16Array(string localName, string namespaceUri) { throw null; }
        public virtual short[] ReadInt16Array(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual int[] ReadInt32Array(string localName, string namespaceUri) { throw null; }
        public virtual int[] ReadInt32Array(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual long[] ReadInt64Array(string localName, string namespaceUri) { throw null; }
        public virtual long[] ReadInt64Array(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual float[] ReadSingleArray(string localName, string namespaceUri) { throw null; }
        public virtual float[] ReadSingleArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual void ReadStartElement(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
        public override string ReadString() { throw null; }
        protected string ReadString(int maxStringContentLength) { throw null; }
        public virtual System.TimeSpan[] ReadTimeSpanArray(string localName, string namespaceUri) { throw null; }
        public virtual System.TimeSpan[] ReadTimeSpanArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual int ReadValueAsBase64(byte[] buffer, int offset, int count) { throw null; }
        public virtual void StartCanonicalization(System.IO.Stream stream, bool includeComments, string[] inclusivePrefixes) { }
        public virtual bool TryGetArrayLength(out int count) { throw null; }
        public virtual bool TryGetBase64ContentLength(out int length) { throw null; }
        public virtual bool TryGetLocalNameAsDictionaryString(out System.Xml.XmlDictionaryString localName) { throw null; }
        public virtual bool TryGetNamespaceUriAsDictionaryString(out System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual bool TryGetValueAsDictionaryString(out System.Xml.XmlDictionaryString value) { throw null; }
    }
    public sealed partial class XmlDictionaryReaderQuotas
    {
        public XmlDictionaryReaderQuotas() { }
        public static System.Xml.XmlDictionaryReaderQuotas Max { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute(16384)]
        public int MaxArrayLength { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(4096)]
        public int MaxBytesPerRead { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(32)]
        public int MaxDepth { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(16384)]
        public int MaxNameTableCharCount { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(8192)]
        public int MaxStringContentLength { get { throw null; } set { } }
        public System.Xml.XmlDictionaryReaderQuotaTypes ModifiedQuotas { get { throw null; } }
        public void CopyTo(System.Xml.XmlDictionaryReaderQuotas quotas) { }
    }
    [System.FlagsAttribute]
    public enum XmlDictionaryReaderQuotaTypes
    {
        MaxArrayLength = 4,
        MaxBytesPerRead = 8,
        MaxDepth = 1,
        MaxNameTableCharCount = 16,
        MaxStringContentLength = 2,
    }
    public partial class XmlDictionaryString
    {
        public XmlDictionaryString(System.Xml.IXmlDictionary dictionary, string value, int key) { }
        public System.Xml.IXmlDictionary Dictionary { get { throw null; } }
        public static System.Xml.XmlDictionaryString Empty { get { throw null; } }
        public int Key { get { throw null; } }
        public string Value { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public abstract partial class XmlDictionaryWriter : System.Xml.XmlWriter
    {
        protected XmlDictionaryWriter() { }
        public virtual bool CanCanonicalize { get { throw null; } }
        public static System.Xml.XmlDictionaryWriter CreateBinaryWriter(System.IO.Stream stream) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateBinaryWriter(System.IO.Stream stream, System.Xml.IXmlDictionary dictionary) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateBinaryWriter(System.IO.Stream stream, System.Xml.IXmlDictionary dictionary, System.Xml.XmlBinaryWriterSession session) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateBinaryWriter(System.IO.Stream stream, System.Xml.IXmlDictionary dictionary, System.Xml.XmlBinaryWriterSession session, bool ownsStream) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateDictionaryWriter(System.Xml.XmlWriter writer) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateMtomWriter(System.IO.Stream stream, System.Text.Encoding encoding, int maxSizeInBytes, string startInfo) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateMtomWriter(System.IO.Stream stream, System.Text.Encoding encoding, int maxSizeInBytes, string startInfo, string boundary, string startUri, bool writeMessageHeaders, bool ownsStream) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateTextWriter(System.IO.Stream stream) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateTextWriter(System.IO.Stream stream, System.Text.Encoding encoding) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateTextWriter(System.IO.Stream stream, System.Text.Encoding encoding, bool ownsStream) { throw null; }
        public virtual void EndCanonicalization() { }
        public virtual void StartCanonicalization(System.IO.Stream stream, bool includeComments, string[] inclusivePrefixes) { }
        public virtual void WriteArray(string prefix, string localName, string namespaceUri, bool[] array, int offset, int count) { }
        public virtual void WriteArray(string prefix, string localName, string namespaceUri, System.DateTime[] array, int offset, int count) { }
        public virtual void WriteArray(string prefix, string localName, string namespaceUri, decimal[] array, int offset, int count) { }
        public virtual void WriteArray(string prefix, string localName, string namespaceUri, double[] array, int offset, int count) { }
        public virtual void WriteArray(string prefix, string localName, string namespaceUri, System.Guid[] array, int offset, int count) { }
        public virtual void WriteArray(string prefix, string localName, string namespaceUri, short[] array, int offset, int count) { }
        public virtual void WriteArray(string prefix, string localName, string namespaceUri, int[] array, int offset, int count) { }
        public virtual void WriteArray(string prefix, string localName, string namespaceUri, long[] array, int offset, int count) { }
        public virtual void WriteArray(string prefix, string localName, string namespaceUri, float[] array, int offset, int count) { }
        public virtual void WriteArray(string prefix, string localName, string namespaceUri, System.TimeSpan[] array, int offset, int count) { }
        public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, bool[] array, int offset, int count) { }
        public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.DateTime[] array, int offset, int count) { }
        public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, decimal[] array, int offset, int count) { }
        public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, double[] array, int offset, int count) { }
        public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.Guid[] array, int offset, int count) { }
        public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, short[] array, int offset, int count) { }
        public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, int[] array, int offset, int count) { }
        public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, long[] array, int offset, int count) { }
        public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, float[] array, int offset, int count) { }
        public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.TimeSpan[] array, int offset, int count) { }
        public void WriteAttributeString(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, string value) { }
        public void WriteAttributeString(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, string value) { }
        public override System.Threading.Tasks.Task WriteBase64Async(byte[] buffer, int index, int count) { throw null; }
        public void WriteElementString(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, string value) { }
        public void WriteElementString(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, string value) { }
        public virtual void WriteNode(System.Xml.XmlDictionaryReader reader, bool defattr) { }
        public override void WriteNode(System.Xml.XmlReader reader, bool defattr) { }
        public virtual void WriteQualifiedName(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
        public virtual void WriteStartAttribute(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
        public void WriteStartAttribute(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
        public virtual void WriteStartElement(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
        public void WriteStartElement(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
        public virtual void WriteString(System.Xml.XmlDictionaryString value) { }
        protected virtual void WriteTextNode(System.Xml.XmlDictionaryReader reader, bool isAttribute) { }
        public virtual void WriteValue(System.Guid value) { }
        public virtual void WriteValue(System.TimeSpan value) { }
        public virtual void WriteValue(System.Xml.IStreamProvider value) { }
        public virtual void WriteValue(System.Xml.UniqueId value) { }
        public virtual void WriteValue(System.Xml.XmlDictionaryString value) { }
        public virtual System.Threading.Tasks.Task WriteValueAsync(System.Xml.IStreamProvider value) { throw null; }
        public virtual void WriteXmlAttribute(string localName, string value) { }
        public virtual void WriteXmlAttribute(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString value) { }
        public virtual void WriteXmlnsAttribute(string prefix, string namespaceUri) { }
        public virtual void WriteXmlnsAttribute(string prefix, System.Xml.XmlDictionaryString namespaceUri) { }
    }
    public partial class XmlDocument : System.Xml.XmlNode
    {
        public XmlDocument() { }
        protected internal XmlDocument(System.Xml.XmlImplementation imp) { }
        public XmlDocument(System.Xml.XmlNameTable nt) { }
        public override string BaseURI { get { throw null; } }
        public System.Xml.XmlElement DocumentElement { get { throw null; } }
        public virtual System.Xml.XmlDocumentType DocumentType { get { throw null; } }
        public System.Xml.XmlImplementation Implementation { get { throw null; } }
        public override string InnerText { set { } }
        public override string InnerXml { get { throw null; } set { } }
        public override bool IsReadOnly { get { throw null; } }
        public override string LocalName { get { throw null; } }
        public override string Name { get { throw null; } }
        public System.Xml.XmlNameTable NameTable { get { throw null; } }
        public override System.Xml.XmlNodeType NodeType { get { throw null; } }
        public override System.Xml.XmlDocument OwnerDocument { get { throw null; } }
        public override System.Xml.XmlNode ParentNode { get { throw null; } }
        public bool PreserveWhitespace { get { throw null; } set { } }
        public override System.Xml.Schema.IXmlSchemaInfo SchemaInfo { get { throw null; } }
        public System.Xml.Schema.XmlSchemaSet Schemas { get { throw null; } set { } }
        public virtual System.Xml.XmlResolver XmlResolver { set { } }
        public event System.Xml.XmlNodeChangedEventHandler NodeChanged { add { } remove { } }
        public event System.Xml.XmlNodeChangedEventHandler NodeChanging { add { } remove { } }
        public event System.Xml.XmlNodeChangedEventHandler NodeInserted { add { } remove { } }
        public event System.Xml.XmlNodeChangedEventHandler NodeInserting { add { } remove { } }
        public event System.Xml.XmlNodeChangedEventHandler NodeRemoved { add { } remove { } }
        public event System.Xml.XmlNodeChangedEventHandler NodeRemoving { add { } remove { } }
        public override System.Xml.XmlNode CloneNode(bool deep) { throw null; }
        public System.Xml.XmlAttribute CreateAttribute(string name) { throw null; }
        public System.Xml.XmlAttribute CreateAttribute(string qualifiedName, string namespaceURI) { throw null; }
        public virtual System.Xml.XmlAttribute CreateAttribute(string prefix, string localName, string namespaceURI) { throw null; }
        public virtual System.Xml.XmlCDataSection CreateCDataSection(string data) { throw null; }
        public virtual System.Xml.XmlComment CreateComment(string data) { throw null; }
        protected internal virtual System.Xml.XmlAttribute CreateDefaultAttribute(string prefix, string localName, string namespaceURI) { throw null; }
        public virtual System.Xml.XmlDocumentFragment CreateDocumentFragment() { throw null; }
        public virtual System.Xml.XmlDocumentType CreateDocumentType(string name, string publicId, string systemId, string internalSubset) { throw null; }
        public System.Xml.XmlElement CreateElement(string name) { throw null; }
        public System.Xml.XmlElement CreateElement(string qualifiedName, string namespaceURI) { throw null; }
        public virtual System.Xml.XmlElement CreateElement(string prefix, string localName, string namespaceURI) { throw null; }
        public virtual System.Xml.XmlEntityReference CreateEntityReference(string name) { throw null; }
        public override System.Xml.XPath.XPathNavigator CreateNavigator() { throw null; }
        protected internal virtual System.Xml.XPath.XPathNavigator CreateNavigator(System.Xml.XmlNode node) { throw null; }
        public virtual System.Xml.XmlNode CreateNode(string nodeTypeString, string name, string namespaceURI) { throw null; }
        public virtual System.Xml.XmlNode CreateNode(System.Xml.XmlNodeType type, string name, string namespaceURI) { throw null; }
        public virtual System.Xml.XmlNode CreateNode(System.Xml.XmlNodeType type, string prefix, string name, string namespaceURI) { throw null; }
        public virtual System.Xml.XmlProcessingInstruction CreateProcessingInstruction(string target, string data) { throw null; }
        public virtual System.Xml.XmlSignificantWhitespace CreateSignificantWhitespace(string text) { throw null; }
        public virtual System.Xml.XmlText CreateTextNode(string text) { throw null; }
        public virtual System.Xml.XmlWhitespace CreateWhitespace(string text) { throw null; }
        public virtual System.Xml.XmlDeclaration CreateXmlDeclaration(string version, string encoding, string standalone) { throw null; }
        public virtual System.Xml.XmlElement GetElementById(string elementId) { throw null; }
        public virtual System.Xml.XmlNodeList GetElementsByTagName(string name) { throw null; }
        public virtual System.Xml.XmlNodeList GetElementsByTagName(string localName, string namespaceURI) { throw null; }
        public virtual System.Xml.XmlNode ImportNode(System.Xml.XmlNode node, bool deep) { throw null; }
        public virtual void Load(System.IO.Stream inStream) { }
        public virtual void Load(System.IO.TextReader txtReader) { }
        public virtual void Load(string filename) { }
        public virtual void Load(System.Xml.XmlReader reader) { }
        public virtual void LoadXml(string xml) { }
        public virtual System.Xml.XmlNode ReadNode(System.Xml.XmlReader reader) { throw null; }
        public virtual void Save(System.IO.Stream outStream) { }
        public virtual void Save(System.IO.TextWriter writer) { }
        public virtual void Save(string filename) { }
        public virtual void Save(System.Xml.XmlWriter w) { }
        public void Validate(System.Xml.Schema.ValidationEventHandler validationEventHandler) { }
        public void Validate(System.Xml.Schema.ValidationEventHandler validationEventHandler, System.Xml.XmlNode nodeToValidate) { }
        public override void WriteContentTo(System.Xml.XmlWriter xw) { }
        public override void WriteTo(System.Xml.XmlWriter w) { }
    }
    public partial class XmlDocumentFragment : System.Xml.XmlNode
    {
        protected internal XmlDocumentFragment(System.Xml.XmlDocument ownerDocument) { }
        public override string InnerXml { get { throw null; } set { } }
        public override string LocalName { get { throw null; } }
        public override string Name { get { throw null; } }
        public override System.Xml.XmlNodeType NodeType { get { throw null; } }
        public override System.Xml.XmlDocument OwnerDocument { get { throw null; } }
        public override System.Xml.XmlNode ParentNode { get { throw null; } }
        public override System.Xml.XmlNode CloneNode(bool deep) { throw null; }
        public override void WriteContentTo(System.Xml.XmlWriter w) { }
        public override void WriteTo(System.Xml.XmlWriter w) { }
    }
    public partial class XmlDocumentType : System.Xml.XmlLinkedNode
    {
        protected internal XmlDocumentType(string name, string publicId, string systemId, string internalSubset, System.Xml.XmlDocument doc) { }
        public System.Xml.XmlNamedNodeMap Entities { get { throw null; } }
        public string InternalSubset { get { throw null; } }
        public override bool IsReadOnly { get { throw null; } }
        public override string LocalName { get { throw null; } }
        public override string Name { get { throw null; } }
        public override System.Xml.XmlNodeType NodeType { get { throw null; } }
        public System.Xml.XmlNamedNodeMap Notations { get { throw null; } }
        public string PublicId { get { throw null; } }
        public string SystemId { get { throw null; } }
        public override System.Xml.XmlNode CloneNode(bool deep) { throw null; }
        public override void WriteContentTo(System.Xml.XmlWriter w) { }
        public override void WriteTo(System.Xml.XmlWriter w) { }
    }
    public partial class XmlElement : System.Xml.XmlLinkedNode
    {
        protected internal XmlElement(string prefix, string localName, string namespaceURI, System.Xml.XmlDocument doc) { }
        public override System.Xml.XmlAttributeCollection Attributes { get { throw null; } }
        public virtual bool HasAttributes { get { throw null; } }
        public override string InnerText { get { throw null; } set { } }
        public override string InnerXml { get { throw null; } set { } }
        public bool IsEmpty { get { throw null; } set { } }
        public override string LocalName { get { throw null; } }
        public override string Name { get { throw null; } }
        public override string NamespaceURI { get { throw null; } }
        public override System.Xml.XmlNode NextSibling { get { throw null; } }
        public override System.Xml.XmlNodeType NodeType { get { throw null; } }
        public override System.Xml.XmlDocument OwnerDocument { get { throw null; } }
        public override System.Xml.XmlNode ParentNode { get { throw null; } }
        public override string Prefix { get { throw null; } set { } }
        public override System.Xml.Schema.IXmlSchemaInfo SchemaInfo { get { throw null; } }
        public override System.Xml.XmlNode CloneNode(bool deep) { throw null; }
        public virtual string GetAttribute(string name) { throw null; }
        public virtual string GetAttribute(string localName, string namespaceURI) { throw null; }
        public virtual System.Xml.XmlAttribute GetAttributeNode(string name) { throw null; }
        public virtual System.Xml.XmlAttribute GetAttributeNode(string localName, string namespaceURI) { throw null; }
        public virtual System.Xml.XmlNodeList GetElementsByTagName(string name) { throw null; }
        public virtual System.Xml.XmlNodeList GetElementsByTagName(string localName, string namespaceURI) { throw null; }
        public virtual bool HasAttribute(string name) { throw null; }
        public virtual bool HasAttribute(string localName, string namespaceURI) { throw null; }
        public override void RemoveAll() { }
        public virtual void RemoveAllAttributes() { }
        public virtual void RemoveAttribute(string name) { }
        public virtual void RemoveAttribute(string localName, string namespaceURI) { }
        public virtual System.Xml.XmlNode RemoveAttributeAt(int i) { throw null; }
        public virtual System.Xml.XmlAttribute RemoveAttributeNode(string localName, string namespaceURI) { throw null; }
        public virtual System.Xml.XmlAttribute RemoveAttributeNode(System.Xml.XmlAttribute oldAttr) { throw null; }
        public virtual void SetAttribute(string name, string value) { }
        public virtual string SetAttribute(string localName, string namespaceURI, string value) { throw null; }
        public virtual System.Xml.XmlAttribute SetAttributeNode(string localName, string namespaceURI) { throw null; }
        public virtual System.Xml.XmlAttribute SetAttributeNode(System.Xml.XmlAttribute newAttr) { throw null; }
        public override void WriteContentTo(System.Xml.XmlWriter w) { }
        public override void WriteTo(System.Xml.XmlWriter w) { }
    }
    public partial class XmlEntity : System.Xml.XmlNode
    {
        internal XmlEntity() { }
        public override string BaseURI { get { throw null; } }
        public override string InnerText { get { throw null; } set { } }
        public override string InnerXml { get { throw null; } set { } }
        public override bool IsReadOnly { get { throw null; } }
        public override string LocalName { get { throw null; } }
        public override string Name { get { throw null; } }
        public override System.Xml.XmlNodeType NodeType { get { throw null; } }
        public string NotationName { get { throw null; } }
        public override string OuterXml { get { throw null; } }
        public string PublicId { get { throw null; } }
        public string SystemId { get { throw null; } }
        public override System.Xml.XmlNode CloneNode(bool deep) { throw null; }
        public override void WriteContentTo(System.Xml.XmlWriter w) { }
        public override void WriteTo(System.Xml.XmlWriter w) { }
    }
    public partial class XmlEntityReference : System.Xml.XmlLinkedNode
    {
        protected internal XmlEntityReference(string name, System.Xml.XmlDocument doc) { }
        public override string BaseURI { get { throw null; } }
        public override bool IsReadOnly { get { throw null; } }
        public override string LocalName { get { throw null; } }
        public override string Name { get { throw null; } }
        public override System.Xml.XmlNodeType NodeType { get { throw null; } }
        public override string Value { get { throw null; } set { } }
        public override System.Xml.XmlNode CloneNode(bool deep) { throw null; }
        public override void WriteContentTo(System.Xml.XmlWriter w) { }
        public override void WriteTo(System.Xml.XmlWriter w) { }
    }
    public partial class XmlException : System.SystemException
    {
        public XmlException() { }
        protected XmlException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public XmlException(string message) { }
        public XmlException(string message, System.Exception innerException) { }
        public XmlException(string message, System.Exception innerException, int lineNumber, int linePosition) { }
        public int LineNumber { get { throw null; } }
        public int LinePosition { get { throw null; } }
        public override string Message { get { throw null; } }
        public string SourceUri { get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public partial class XmlImplementation
    {
        public XmlImplementation() { }
        public XmlImplementation(System.Xml.XmlNameTable nt) { }
        public virtual System.Xml.XmlDocument CreateDocument() { throw null; }
        public bool HasFeature(string strFeature, string strVersion) { throw null; }
    }
    public abstract partial class XmlLinkedNode : System.Xml.XmlNode
    {
        internal XmlLinkedNode() { }
        public override System.Xml.XmlNode NextSibling { get { throw null; } }
        public override System.Xml.XmlNode PreviousSibling { get { throw null; } }
    }
    public partial class XmlNamedNodeMap : System.Collections.IEnumerable
    {
        internal XmlNamedNodeMap() { }
        public virtual int Count { get { throw null; } }
        public virtual System.Collections.IEnumerator GetEnumerator() { throw null; }
        public virtual System.Xml.XmlNode GetNamedItem(string name) { throw null; }
        public virtual System.Xml.XmlNode GetNamedItem(string localName, string namespaceURI) { throw null; }
        public virtual System.Xml.XmlNode Item(int index) { throw null; }
        public virtual System.Xml.XmlNode RemoveNamedItem(string name) { throw null; }
        public virtual System.Xml.XmlNode RemoveNamedItem(string localName, string namespaceURI) { throw null; }
        public virtual System.Xml.XmlNode SetNamedItem(System.Xml.XmlNode node) { throw null; }
    }
    public partial class XmlNamespaceManager : System.Collections.IEnumerable, System.Xml.IXmlNamespaceResolver
    {
        public XmlNamespaceManager(System.Xml.XmlNameTable nameTable) { }
        public virtual string DefaultNamespace { get { throw null; } }
        public virtual System.Xml.XmlNameTable NameTable { get { throw null; } }
        public virtual void AddNamespace(string prefix, string uri) { }
        public virtual System.Collections.IEnumerator GetEnumerator() { throw null; }
        public virtual System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope) { throw null; }
        public virtual bool HasNamespace(string prefix) { throw null; }
        public virtual string LookupNamespace(string prefix) { throw null; }
        public virtual string LookupPrefix(string uri) { throw null; }
        public virtual bool PopScope() { throw null; }
        public virtual void PushScope() { }
        public virtual void RemoveNamespace(string prefix, string uri) { }
    }
    public enum XmlNamespaceScope
    {
        All = 0,
        ExcludeXml = 1,
        Local = 2,
    }
    public abstract partial class XmlNameTable
    {
        protected XmlNameTable() { }
        public abstract string Add(char[] array, int offset, int length);
        public abstract string Add(string array);
        public abstract string Get(char[] array, int offset, int length);
        public abstract string Get(string array);
    }
    public abstract partial class XmlNode : System.Collections.IEnumerable, System.ICloneable, System.Xml.XPath.IXPathNavigable
    {
        internal XmlNode() { }
        public virtual System.Xml.XmlAttributeCollection Attributes { get { throw null; } }
        public virtual string BaseURI { get { throw null; } }
        public virtual System.Xml.XmlNodeList ChildNodes { get { throw null; } }
        public virtual System.Xml.XmlNode FirstChild { get { throw null; } }
        public virtual bool HasChildNodes { get { throw null; } }
        public virtual string InnerText { get { throw null; } set { } }
        public virtual string InnerXml { get { throw null; } set { } }
        public virtual bool IsReadOnly { get { throw null; } }
        public virtual System.Xml.XmlElement this[string name] { get { throw null; } }
        public virtual System.Xml.XmlElement this[string localname, string ns] { get { throw null; } }
        public virtual System.Xml.XmlNode LastChild { get { throw null; } }
        public abstract string LocalName { get; }
        public abstract string Name { get; }
        public virtual string NamespaceURI { get { throw null; } }
        public virtual System.Xml.XmlNode NextSibling { get { throw null; } }
        public abstract System.Xml.XmlNodeType NodeType { get; }
        public virtual string OuterXml { get { throw null; } }
        public virtual System.Xml.XmlDocument OwnerDocument { get { throw null; } }
        public virtual System.Xml.XmlNode ParentNode { get { throw null; } }
        public virtual string Prefix { get { throw null; } set { } }
        public virtual System.Xml.XmlNode PreviousSibling { get { throw null; } }
        public virtual System.Xml.XmlNode PreviousText { get { throw null; } }
        public virtual System.Xml.Schema.IXmlSchemaInfo SchemaInfo { get { throw null; } }
        public virtual string Value { get { throw null; } set { } }
        public virtual System.Xml.XmlNode AppendChild(System.Xml.XmlNode newChild) { throw null; }
        public virtual System.Xml.XmlNode Clone() { throw null; }
        public abstract System.Xml.XmlNode CloneNode(bool deep);
        public virtual System.Xml.XPath.XPathNavigator CreateNavigator() { throw null; }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        public virtual string GetNamespaceOfPrefix(string prefix) { throw null; }
        public virtual string GetPrefixOfNamespace(string namespaceURI) { throw null; }
        public virtual System.Xml.XmlNode InsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild) { throw null; }
        public virtual System.Xml.XmlNode InsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild) { throw null; }
        public virtual void Normalize() { }
        public virtual System.Xml.XmlNode PrependChild(System.Xml.XmlNode newChild) { throw null; }
        public virtual void RemoveAll() { }
        public virtual System.Xml.XmlNode RemoveChild(System.Xml.XmlNode oldChild) { throw null; }
        public virtual System.Xml.XmlNode ReplaceChild(System.Xml.XmlNode newChild, System.Xml.XmlNode oldChild) { throw null; }
        public System.Xml.XmlNodeList SelectNodes(string xpath) { throw null; }
        public System.Xml.XmlNodeList SelectNodes(string xpath, System.Xml.XmlNamespaceManager nsmgr) { throw null; }
        public System.Xml.XmlNode SelectSingleNode(string xpath) { throw null; }
        public System.Xml.XmlNode SelectSingleNode(string xpath, System.Xml.XmlNamespaceManager nsmgr) { throw null; }
        public virtual bool Supports(string feature, string version) { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        object System.ICloneable.Clone() { throw null; }
        public abstract void WriteContentTo(System.Xml.XmlWriter w);
        public abstract void WriteTo(System.Xml.XmlWriter w);
    }
    public enum XmlNodeChangedAction
    {
        Change = 2,
        Insert = 0,
        Remove = 1,
    }
    public partial class XmlNodeChangedEventArgs : System.EventArgs
    {
        public XmlNodeChangedEventArgs(System.Xml.XmlNode node, System.Xml.XmlNode oldParent, System.Xml.XmlNode newParent, string oldValue, string newValue, System.Xml.XmlNodeChangedAction action) { }
        public System.Xml.XmlNodeChangedAction Action { get { throw null; } }
        public System.Xml.XmlNode NewParent { get { throw null; } }
        public string NewValue { get { throw null; } }
        public System.Xml.XmlNode Node { get { throw null; } }
        public System.Xml.XmlNode OldParent { get { throw null; } }
        public string OldValue { get { throw null; } }
    }
    public delegate void XmlNodeChangedEventHandler(object sender, System.Xml.XmlNodeChangedEventArgs e);
    public abstract partial class XmlNodeList : System.Collections.IEnumerable, System.IDisposable
    {
        protected XmlNodeList() { }
        public abstract int Count { get; }
        [System.Runtime.CompilerServices.IndexerName("ItemOf")]
        public virtual System.Xml.XmlNode this[int i] { get { throw null; } }
        public abstract System.Collections.IEnumerator GetEnumerator();
        public abstract System.Xml.XmlNode Item(int index);
        protected virtual void PrivateDisposeNodeList() { }
        void System.IDisposable.Dispose() { }
    }
    public enum XmlNodeOrder
    {
        After = 1,
        Before = 0,
        Same = 2,
        Unknown = 3,
    }
    public partial class XmlNodeReader : System.Xml.XmlReader, System.Xml.IXmlNamespaceResolver
    {
        public XmlNodeReader(System.Xml.XmlNode node) { }
        public override int AttributeCount { get { throw null; } }
        public override string BaseURI { get { throw null; } }
        public override bool CanReadBinaryContent { get { throw null; } }
        public override bool CanResolveEntity { get { throw null; } }
        public override int Depth { get { throw null; } }
        public override bool EOF { get { throw null; } }
        public override bool HasAttributes { get { throw null; } }
        public override bool HasValue { get { throw null; } }
        public override bool IsDefault { get { throw null; } }
        public override bool IsEmptyElement { get { throw null; } }
        public override string LocalName { get { throw null; } }
        public override string Name { get { throw null; } }
        public override string NamespaceURI { get { throw null; } }
        public override System.Xml.XmlNameTable NameTable { get { throw null; } }
        public override System.Xml.XmlNodeType NodeType { get { throw null; } }
        public override string Prefix { get { throw null; } }
        public override System.Xml.ReadState ReadState { get { throw null; } }
        public override System.Xml.Schema.IXmlSchemaInfo SchemaInfo { get { throw null; } }
        public override string Value { get { throw null; } }
        public override string XmlLang { get { throw null; } }
        public override System.Xml.XmlSpace XmlSpace { get { throw null; } }
        public override void Close() { }
        public override string GetAttribute(int attributeIndex) { throw null; }
        public override string GetAttribute(string name) { throw null; }
        public override string GetAttribute(string name, string namespaceURI) { throw null; }
        public override string LookupNamespace(string prefix) { throw null; }
        public override void MoveToAttribute(int attributeIndex) { }
        public override bool MoveToAttribute(string name) { throw null; }
        public override bool MoveToAttribute(string name, string namespaceURI) { throw null; }
        public override bool MoveToElement() { throw null; }
        public override bool MoveToFirstAttribute() { throw null; }
        public override bool MoveToNextAttribute() { throw null; }
        public override bool Read() { throw null; }
        public override bool ReadAttributeValue() { throw null; }
        public override int ReadContentAsBase64(byte[] buffer, int index, int count) { throw null; }
        public override int ReadContentAsBinHex(byte[] buffer, int index, int count) { throw null; }
        public override int ReadElementContentAsBase64(byte[] buffer, int index, int count) { throw null; }
        public override int ReadElementContentAsBinHex(byte[] buffer, int index, int count) { throw null; }
        public override string ReadString() { throw null; }
        public override void ResolveEntity() { }
        public override void Skip() { }
        System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope) { throw null; }
        string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { throw null; }
        string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { throw null; }
    }
    public enum XmlNodeType
    {
        Attribute = 2,
        CDATA = 4,
        Comment = 8,
        Document = 9,
        DocumentFragment = 11,
        DocumentType = 10,
        Element = 1,
        EndElement = 15,
        EndEntity = 16,
        Entity = 6,
        EntityReference = 5,
        None = 0,
        Notation = 12,
        ProcessingInstruction = 7,
        SignificantWhitespace = 14,
        Text = 3,
        Whitespace = 13,
        XmlDeclaration = 17,
    }
    public partial class XmlNotation : System.Xml.XmlNode
    {
        internal XmlNotation() { }
        public override string InnerXml { get { throw null; } set { } }
        public override bool IsReadOnly { get { throw null; } }
        public override string LocalName { get { throw null; } }
        public override string Name { get { throw null; } }
        public override System.Xml.XmlNodeType NodeType { get { throw null; } }
        public override string OuterXml { get { throw null; } }
        public string PublicId { get { throw null; } }
        public string SystemId { get { throw null; } }
        public override System.Xml.XmlNode CloneNode(bool deep) { throw null; }
        public override void WriteContentTo(System.Xml.XmlWriter w) { }
        public override void WriteTo(System.Xml.XmlWriter w) { }
    }
    public enum XmlOutputMethod
    {
        AutoDetect = 3,
        Html = 1,
        Text = 2,
        Xml = 0,
    }
    public partial class XmlParserContext
    {
        public XmlParserContext(System.Xml.XmlNameTable nt, System.Xml.XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, System.Xml.XmlSpace xmlSpace) { }
        public XmlParserContext(System.Xml.XmlNameTable nt, System.Xml.XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, System.Xml.XmlSpace xmlSpace, System.Text.Encoding enc) { }
        public XmlParserContext(System.Xml.XmlNameTable nt, System.Xml.XmlNamespaceManager nsMgr, string xmlLang, System.Xml.XmlSpace xmlSpace) { }
        public XmlParserContext(System.Xml.XmlNameTable nt, System.Xml.XmlNamespaceManager nsMgr, string xmlLang, System.Xml.XmlSpace xmlSpace, System.Text.Encoding enc) { }
        public string BaseURI { get { throw null; } set { } }
        public string DocTypeName { get { throw null; } set { } }
        public System.Text.Encoding Encoding { get { throw null; } set { } }
        public string InternalSubset { get { throw null; } set { } }
        public System.Xml.XmlNamespaceManager NamespaceManager { get { throw null; } set { } }
        public System.Xml.XmlNameTable NameTable { get { throw null; } set { } }
        public string PublicId { get { throw null; } set { } }
        public string SystemId { get { throw null; } set { } }
        public string XmlLang { get { throw null; } set { } }
        public System.Xml.XmlSpace XmlSpace { get { throw null; } set { } }
    }
    public partial class XmlProcessingInstruction : System.Xml.XmlLinkedNode
    {
        protected internal XmlProcessingInstruction(string target, string data, System.Xml.XmlDocument doc) { }
        public string Data { get { throw null; } set { } }
        public override string InnerText { get { throw null; } set { } }
        public override string LocalName { get { throw null; } }
        public override string Name { get { throw null; } }
        public override System.Xml.XmlNodeType NodeType { get { throw null; } }
        public string Target { get { throw null; } }
        public override string Value { get { throw null; } set { } }
        public override System.Xml.XmlNode CloneNode(bool deep) { throw null; }
        public override void WriteContentTo(System.Xml.XmlWriter w) { }
        public override void WriteTo(System.Xml.XmlWriter w) { }
    }
    public partial class XmlQualifiedName
    {
        public static readonly System.Xml.XmlQualifiedName Empty;
        public XmlQualifiedName() { }
        public XmlQualifiedName(string name) { }
        public XmlQualifiedName(string name, string ns) { }
        public bool IsEmpty { get { throw null; } }
        public string Name { get { throw null; } }
        public string Namespace { get { throw null; } }
        public override bool Equals(object other) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Xml.XmlQualifiedName a, System.Xml.XmlQualifiedName b) { throw null; }
        public static bool operator !=(System.Xml.XmlQualifiedName a, System.Xml.XmlQualifiedName b) { throw null; }
        public override string ToString() { throw null; }
        public static string ToString(string name, string ns) { throw null; }
    }
    public abstract partial class XmlReader : System.IDisposable
    {
        protected XmlReader() { }
        public abstract int AttributeCount { get; }
        public abstract string BaseURI { get; }
        public virtual bool CanReadBinaryContent { get { throw null; } }
        public virtual bool CanReadValueChunk { get { throw null; } }
        public virtual bool CanResolveEntity { get { throw null; } }
        public abstract int Depth { get; }
        public abstract bool EOF { get; }
        public virtual bool HasAttributes { get { throw null; } }
        public virtual bool HasValue { get { throw null; } }
        public virtual bool IsDefault { get { throw null; } }
        public abstract bool IsEmptyElement { get; }
        public virtual string this[int i] { get { throw null; } }
        public virtual string this[string name] { get { throw null; } }
        public virtual string this[string name, string namespaceURI] { get { throw null; } }
        public abstract string LocalName { get; }
        public virtual string Name { get { throw null; } }
        public abstract string NamespaceURI { get; }
        public abstract System.Xml.XmlNameTable NameTable { get; }
        public abstract System.Xml.XmlNodeType NodeType { get; }
        public abstract string Prefix { get; }
        public virtual char QuoteChar { get { throw null; } }
        public abstract System.Xml.ReadState ReadState { get; }
        public virtual System.Xml.Schema.IXmlSchemaInfo SchemaInfo { get { throw null; } }
        public virtual System.Xml.XmlReaderSettings Settings { get { throw null; } }
        public abstract string Value { get; }
        public virtual System.Type ValueType { get { throw null; } }
        public virtual string XmlLang { get { throw null; } }
        public virtual System.Xml.XmlSpace XmlSpace { get { throw null; } }
        public virtual void Close() { }
        public static System.Xml.XmlReader Create(System.IO.Stream input) { throw null; }
        public static System.Xml.XmlReader Create(System.IO.Stream input, System.Xml.XmlReaderSettings settings) { throw null; }
        public static System.Xml.XmlReader Create(System.IO.Stream input, System.Xml.XmlReaderSettings settings, string baseUri) { throw null; }
        public static System.Xml.XmlReader Create(System.IO.Stream input, System.Xml.XmlReaderSettings settings, System.Xml.XmlParserContext inputContext) { throw null; }
        public static System.Xml.XmlReader Create(System.IO.TextReader input) { throw null; }
        public static System.Xml.XmlReader Create(System.IO.TextReader input, System.Xml.XmlReaderSettings settings) { throw null; }
        public static System.Xml.XmlReader Create(System.IO.TextReader input, System.Xml.XmlReaderSettings settings, string baseUri) { throw null; }
        public static System.Xml.XmlReader Create(System.IO.TextReader input, System.Xml.XmlReaderSettings settings, System.Xml.XmlParserContext inputContext) { throw null; }
        public static System.Xml.XmlReader Create(string inputUri) { throw null; }
        public static System.Xml.XmlReader Create(string inputUri, System.Xml.XmlReaderSettings settings) { throw null; }
        public static System.Xml.XmlReader Create(string inputUri, System.Xml.XmlReaderSettings settings, System.Xml.XmlParserContext inputContext) { throw null; }
        public static System.Xml.XmlReader Create(System.Xml.XmlReader reader, System.Xml.XmlReaderSettings settings) { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public abstract string GetAttribute(int i);
        public abstract string GetAttribute(string name);
        public abstract string GetAttribute(string name, string namespaceURI);
        public virtual System.Threading.Tasks.Task<string> GetValueAsync() { throw null; }
        public static bool IsName(string str) { throw null; }
        public static bool IsNameToken(string str) { throw null; }
        public virtual bool IsStartElement() { throw null; }
        public virtual bool IsStartElement(string name) { throw null; }
        public virtual bool IsStartElement(string localname, string ns) { throw null; }
        public abstract string LookupNamespace(string prefix);
        public virtual void MoveToAttribute(int i) { }
        public abstract bool MoveToAttribute(string name);
        public abstract bool MoveToAttribute(string name, string ns);
        public virtual System.Xml.XmlNodeType MoveToContent() { throw null; }
        public virtual System.Threading.Tasks.Task<System.Xml.XmlNodeType> MoveToContentAsync() { throw null; }
        public abstract bool MoveToElement();
        public abstract bool MoveToFirstAttribute();
        public abstract bool MoveToNextAttribute();
        public abstract bool Read();
        public virtual System.Threading.Tasks.Task<bool> ReadAsync() { throw null; }
        public abstract bool ReadAttributeValue();
        public virtual object ReadContentAs(System.Type returnType, System.Xml.IXmlNamespaceResolver namespaceResolver) { throw null; }
        public virtual System.Threading.Tasks.Task<object> ReadContentAsAsync(System.Type returnType, System.Xml.IXmlNamespaceResolver namespaceResolver) { throw null; }
        public virtual int ReadContentAsBase64(byte[] buffer, int index, int count) { throw null; }
        public virtual System.Threading.Tasks.Task<int> ReadContentAsBase64Async(byte[] buffer, int index, int count) { throw null; }
        public virtual int ReadContentAsBinHex(byte[] buffer, int index, int count) { throw null; }
        public virtual System.Threading.Tasks.Task<int> ReadContentAsBinHexAsync(byte[] buffer, int index, int count) { throw null; }
        public virtual bool ReadContentAsBoolean() { throw null; }
        public virtual System.DateTime ReadContentAsDateTime() { throw null; }
        public virtual System.DateTimeOffset ReadContentAsDateTimeOffset() { throw null; }
        public virtual decimal ReadContentAsDecimal() { throw null; }
        public virtual double ReadContentAsDouble() { throw null; }
        public virtual float ReadContentAsFloat() { throw null; }
        public virtual int ReadContentAsInt() { throw null; }
        public virtual long ReadContentAsLong() { throw null; }
        public virtual object ReadContentAsObject() { throw null; }
        public virtual System.Threading.Tasks.Task<object> ReadContentAsObjectAsync() { throw null; }
        public virtual string ReadContentAsString() { throw null; }
        public virtual System.Threading.Tasks.Task<string> ReadContentAsStringAsync() { throw null; }
        public virtual object ReadElementContentAs(System.Type returnType, System.Xml.IXmlNamespaceResolver namespaceResolver) { throw null; }
        public virtual object ReadElementContentAs(System.Type returnType, System.Xml.IXmlNamespaceResolver namespaceResolver, string localName, string namespaceURI) { throw null; }
        public virtual System.Threading.Tasks.Task<object> ReadElementContentAsAsync(System.Type returnType, System.Xml.IXmlNamespaceResolver namespaceResolver) { throw null; }
        public virtual int ReadElementContentAsBase64(byte[] buffer, int index, int count) { throw null; }
        public virtual System.Threading.Tasks.Task<int> ReadElementContentAsBase64Async(byte[] buffer, int index, int count) { throw null; }
        public virtual int ReadElementContentAsBinHex(byte[] buffer, int index, int count) { throw null; }
        public virtual System.Threading.Tasks.Task<int> ReadElementContentAsBinHexAsync(byte[] buffer, int index, int count) { throw null; }
        public virtual bool ReadElementContentAsBoolean() { throw null; }
        public virtual bool ReadElementContentAsBoolean(string localName, string namespaceURI) { throw null; }
        public virtual System.DateTime ReadElementContentAsDateTime() { throw null; }
        public virtual System.DateTime ReadElementContentAsDateTime(string localName, string namespaceURI) { throw null; }
        public virtual decimal ReadElementContentAsDecimal() { throw null; }
        public virtual decimal ReadElementContentAsDecimal(string localName, string namespaceURI) { throw null; }
        public virtual double ReadElementContentAsDouble() { throw null; }
        public virtual double ReadElementContentAsDouble(string localName, string namespaceURI) { throw null; }
        public virtual float ReadElementContentAsFloat() { throw null; }
        public virtual float ReadElementContentAsFloat(string localName, string namespaceURI) { throw null; }
        public virtual int ReadElementContentAsInt() { throw null; }
        public virtual int ReadElementContentAsInt(string localName, string namespaceURI) { throw null; }
        public virtual long ReadElementContentAsLong() { throw null; }
        public virtual long ReadElementContentAsLong(string localName, string namespaceURI) { throw null; }
        public virtual object ReadElementContentAsObject() { throw null; }
        public virtual object ReadElementContentAsObject(string localName, string namespaceURI) { throw null; }
        public virtual System.Threading.Tasks.Task<object> ReadElementContentAsObjectAsync() { throw null; }
        public virtual string ReadElementContentAsString() { throw null; }
        public virtual string ReadElementContentAsString(string localName, string namespaceURI) { throw null; }
        public virtual System.Threading.Tasks.Task<string> ReadElementContentAsStringAsync() { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual string ReadElementString() { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual string ReadElementString(string name) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual string ReadElementString(string localname, string ns) { throw null; }
        public virtual void ReadEndElement() { }
        public virtual string ReadInnerXml() { throw null; }
        public virtual System.Threading.Tasks.Task<string> ReadInnerXmlAsync() { throw null; }
        public virtual string ReadOuterXml() { throw null; }
        public virtual System.Threading.Tasks.Task<string> ReadOuterXmlAsync() { throw null; }
        public virtual void ReadStartElement() { }
        public virtual void ReadStartElement(string name) { }
        public virtual void ReadStartElement(string localname, string ns) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual string ReadString() { throw null; }
        public virtual System.Xml.XmlReader ReadSubtree() { throw null; }
        public virtual bool ReadToDescendant(string name) { throw null; }
        public virtual bool ReadToDescendant(string localName, string namespaceURI) { throw null; }
        public virtual bool ReadToFollowing(string name) { throw null; }
        public virtual bool ReadToFollowing(string localName, string namespaceURI) { throw null; }
        public virtual bool ReadToNextSibling(string name) { throw null; }
        public virtual bool ReadToNextSibling(string localName, string namespaceURI) { throw null; }
        public virtual int ReadValueChunk(char[] buffer, int index, int count) { throw null; }
        public virtual System.Threading.Tasks.Task<int> ReadValueChunkAsync(char[] buffer, int index, int count) { throw null; }
        public abstract void ResolveEntity();
        public virtual void Skip() { }
        public virtual System.Threading.Tasks.Task SkipAsync() { throw null; }
    }
    public sealed partial class XmlReaderSettings
    {
        public XmlReaderSettings() { }
        public bool Async { get { throw null; } set { } }
        public bool CheckCharacters { get { throw null; } set { } }
        public bool CloseInput { get { throw null; } set { } }
        public System.Xml.ConformanceLevel ConformanceLevel { get { throw null; } set { } }
        public System.Xml.DtdProcessing DtdProcessing { get { throw null; } set { } }
        public bool IgnoreComments { get { throw null; } set { } }
        public bool IgnoreProcessingInstructions { get { throw null; } set { } }
        public bool IgnoreWhitespace { get { throw null; } set { } }
        public int LineNumberOffset { get { throw null; } set { } }
        public int LinePositionOffset { get { throw null; } set { } }
        public long MaxCharactersFromEntities { get { throw null; } set { } }
        public long MaxCharactersInDocument { get { throw null; } set { } }
        public System.Xml.XmlNameTable NameTable { get { throw null; } set { } }
        [System.ObsoleteAttribute("Use XmlReaderSettings.DtdProcessing property instead.")]
        public bool ProhibitDtd { get { throw null; } set { } }
        public System.Xml.Schema.XmlSchemaSet Schemas { get { throw null; } set { } }
        public System.Xml.Schema.XmlSchemaValidationFlags ValidationFlags { get { throw null; } set { } }
        public System.Xml.ValidationType ValidationType { get { throw null; } set { } }
        public System.Xml.XmlResolver XmlResolver { set { } }
        public event System.Xml.Schema.ValidationEventHandler ValidationEventHandler { add { } remove { } }
        public System.Xml.XmlReaderSettings Clone() { throw null; }
        public void Reset() { }
    }
    public abstract partial class XmlResolver
    {
        protected XmlResolver() { }
        public virtual System.Net.ICredentials Credentials { set { } }
        public abstract object GetEntity(System.Uri absoluteUri, string role, System.Type ofObjectToReturn);
        public virtual System.Threading.Tasks.Task<object> GetEntityAsync(System.Uri absoluteUri, string role, System.Type ofObjectToReturn) { throw null; }
        public virtual System.Uri ResolveUri(System.Uri baseUri, string relativeUri) { throw null; }
        public virtual bool SupportsType(System.Uri absoluteUri, System.Type type) { throw null; }
    }
    public partial class XmlSecureResolver : System.Xml.XmlResolver
    {
//CAS        public XmlSecureResolver(System.Xml.XmlResolver resolver, System.Security.PermissionSet permissionSet) { }
//CAS        public XmlSecureResolver(System.Xml.XmlResolver resolver, System.Security.Policy.Evidence evidence) { }
        public XmlSecureResolver(System.Xml.XmlResolver resolver, string securityUrl) { }
        public override System.Net.ICredentials Credentials { set { } }
//CAS        public static System.Security.Policy.Evidence CreateEvidenceForUrl(string securityUrl) { throw null; }
        public override object GetEntity(System.Uri absoluteUri, string role, System.Type ofObjectToReturn) { throw null; }
        public override System.Threading.Tasks.Task<object> GetEntityAsync(System.Uri absoluteUri, string role, System.Type ofObjectToReturn) { throw null; }
        public override System.Uri ResolveUri(System.Uri baseUri, string relativeUri) { throw null; }
    }
    public partial class XmlSignificantWhitespace : System.Xml.XmlCharacterData
    {
        protected internal XmlSignificantWhitespace(string strData, System.Xml.XmlDocument doc) : base (default(string), default(System.Xml.XmlDocument)) { }
        public override string LocalName { get { throw null; } }
        public override string Name { get { throw null; } }
        public override System.Xml.XmlNodeType NodeType { get { throw null; } }
        public override System.Xml.XmlNode ParentNode { get { throw null; } }
        public override System.Xml.XmlNode PreviousText { get { throw null; } }
        public override string Value { get { throw null; } set { } }
        public override System.Xml.XmlNode CloneNode(bool deep) { throw null; }
        public override void WriteContentTo(System.Xml.XmlWriter w) { }
        public override void WriteTo(System.Xml.XmlWriter w) { }
    }
    public enum XmlSpace
    {
        Default = 1,
        None = 0,
        Preserve = 2,
    }
    public partial class XmlText : System.Xml.XmlCharacterData
    {
        protected internal XmlText(string strData, System.Xml.XmlDocument doc) : base (default(string), default(System.Xml.XmlDocument)) { }
        public override string LocalName { get { throw null; } }
        public override string Name { get { throw null; } }
        public override System.Xml.XmlNodeType NodeType { get { throw null; } }
        public override System.Xml.XmlNode ParentNode { get { throw null; } }
        public override System.Xml.XmlNode PreviousText { get { throw null; } }
        public override string Value { get { throw null; } set { } }
        public override System.Xml.XmlNode CloneNode(bool deep) { throw null; }
        public virtual System.Xml.XmlText SplitText(int offset) { throw null; }
        public override void WriteContentTo(System.Xml.XmlWriter w) { }
        public override void WriteTo(System.Xml.XmlWriter w) { }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public partial class XmlTextReader : System.Xml.XmlReader, System.Xml.IXmlLineInfo, System.Xml.IXmlNamespaceResolver
    {
        protected XmlTextReader() { }
        public XmlTextReader(System.IO.Stream input) { }
        public XmlTextReader(System.IO.Stream input, System.Xml.XmlNameTable nt) { }
        public XmlTextReader(System.IO.Stream xmlFragment, System.Xml.XmlNodeType fragType, System.Xml.XmlParserContext context) { }
        public XmlTextReader(System.IO.TextReader input) { }
        public XmlTextReader(System.IO.TextReader input, System.Xml.XmlNameTable nt) { }
        public XmlTextReader(string url) { }
        public XmlTextReader(string url, System.IO.Stream input) { }
        public XmlTextReader(string url, System.IO.Stream input, System.Xml.XmlNameTable nt) { }
        public XmlTextReader(string url, System.IO.TextReader input) { }
        public XmlTextReader(string url, System.IO.TextReader input, System.Xml.XmlNameTable nt) { }
        public XmlTextReader(string url, System.Xml.XmlNameTable nt) { }
        public XmlTextReader(string xmlFragment, System.Xml.XmlNodeType fragType, System.Xml.XmlParserContext context) { }
        protected XmlTextReader(System.Xml.XmlNameTable nt) { }
        public override int AttributeCount { get { throw null; } }
        public override string BaseURI { get { throw null; } }
        public override bool CanReadBinaryContent { get { throw null; } }
        public override bool CanReadValueChunk { get { throw null; } }
        public override bool CanResolveEntity { get { throw null; } }
        public override int Depth { get { throw null; } }
        public System.Xml.DtdProcessing DtdProcessing { get { throw null; } set { } }
        public System.Text.Encoding Encoding { get { throw null; } }
        public System.Xml.EntityHandling EntityHandling { get { throw null; } set { } }
        public override bool EOF { get { throw null; } }
        public override bool HasValue { get { throw null; } }
        public override bool IsDefault { get { throw null; } }
        public override bool IsEmptyElement { get { throw null; } }
        public int LineNumber { get { throw null; } }
        public int LinePosition { get { throw null; } }
        public override string LocalName { get { throw null; } }
        public override string Name { get { throw null; } }
        public bool Namespaces { get { throw null; } set { } }
        public override string NamespaceURI { get { throw null; } }
        public override System.Xml.XmlNameTable NameTable { get { throw null; } }
        public override System.Xml.XmlNodeType NodeType { get { throw null; } }
        public bool Normalization { get { throw null; } set { } }
        public override string Prefix { get { throw null; } }
        [System.ObsoleteAttribute("Use DtdProcessing property instead.")]
        public bool ProhibitDtd { get { throw null; } set { } }
        public override char QuoteChar { get { throw null; } }
        public override System.Xml.ReadState ReadState { get { throw null; } }
        public override string Value { get { throw null; } }
        public System.Xml.WhitespaceHandling WhitespaceHandling { get { throw null; } set { } }
        public override string XmlLang { get { throw null; } }
        public System.Xml.XmlResolver XmlResolver { set { } }
        public override System.Xml.XmlSpace XmlSpace { get { throw null; } }
        public override void Close() { }
        public override string GetAttribute(int i) { throw null; }
        public override string GetAttribute(string name) { throw null; }
        public override string GetAttribute(string localName, string namespaceURI) { throw null; }
        public System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope) { throw null; }
        public System.IO.TextReader GetRemainder() { throw null; }
        public bool HasLineInfo() { throw null; }
        public override string LookupNamespace(string prefix) { throw null; }
        public override void MoveToAttribute(int i) { }
        public override bool MoveToAttribute(string name) { throw null; }
        public override bool MoveToAttribute(string localName, string namespaceURI) { throw null; }
        public override bool MoveToElement() { throw null; }
        public override bool MoveToFirstAttribute() { throw null; }
        public override bool MoveToNextAttribute() { throw null; }
        public override bool Read() { throw null; }
        public override bool ReadAttributeValue() { throw null; }
        public int ReadBase64(byte[] array, int offset, int len) { throw null; }
        public int ReadBinHex(byte[] array, int offset, int len) { throw null; }
        public int ReadChars(char[] buffer, int index, int count) { throw null; }
        public override int ReadContentAsBase64(byte[] buffer, int index, int count) { throw null; }
        public override int ReadContentAsBinHex(byte[] buffer, int index, int count) { throw null; }
        public override int ReadElementContentAsBase64(byte[] buffer, int index, int count) { throw null; }
        public override int ReadElementContentAsBinHex(byte[] buffer, int index, int count) { throw null; }
        public override string ReadString() { throw null; }
        public void ResetState() { }
        public override void ResolveEntity() { }
        public override void Skip() { }
        System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope) { throw null; }
        string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { throw null; }
        string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public partial class XmlTextWriter : System.Xml.XmlWriter
    {
        public XmlTextWriter(System.IO.Stream w, System.Text.Encoding encoding) { }
        public XmlTextWriter(System.IO.TextWriter w) { }
        public XmlTextWriter(string filename, System.Text.Encoding encoding) { }
        public System.IO.Stream BaseStream { get { throw null; } }
        public System.Xml.Formatting Formatting { get { throw null; } set { } }
        public int Indentation { get { throw null; } set { } }
        public char IndentChar { get { throw null; } set { } }
        public bool Namespaces { get { throw null; } set { } }
        public char QuoteChar { get { throw null; } set { } }
        public override System.Xml.WriteState WriteState { get { throw null; } }
        public override string XmlLang { get { throw null; } }
        public override System.Xml.XmlSpace XmlSpace { get { throw null; } }
        public override void Close() { }
        public override void Flush() { }
        public override string LookupPrefix(string ns) { throw null; }
        public override void WriteBase64(byte[] buffer, int index, int count) { }
        public override void WriteBinHex(byte[] buffer, int index, int count) { }
        public override void WriteCData(string text) { }
        public override void WriteCharEntity(char ch) { }
        public override void WriteChars(char[] buffer, int index, int count) { }
        public override void WriteComment(string text) { }
        public override void WriteDocType(string name, string pubid, string sysid, string subset) { }
        public override void WriteEndAttribute() { }
        public override void WriteEndDocument() { }
        public override void WriteEndElement() { }
        public override void WriteEntityRef(string name) { }
        public override void WriteFullEndElement() { }
        public override void WriteName(string name) { }
        public override void WriteNmToken(string name) { }
        public override void WriteProcessingInstruction(string name, string text) { }
        public override void WriteQualifiedName(string localName, string ns) { }
        public override void WriteRaw(char[] buffer, int index, int count) { }
        public override void WriteRaw(string data) { }
        public override void WriteStartAttribute(string prefix, string localName, string ns) { }
        public override void WriteStartDocument() { }
        public override void WriteStartDocument(bool standalone) { }
        public override void WriteStartElement(string prefix, string localName, string ns) { }
        public override void WriteString(string text) { }
        public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }
        public override void WriteWhitespace(string ws) { }
    }
    public enum XmlTokenizedType
    {
        CDATA = 0,
        ENTITIES = 5,
        ENTITY = 4,
        ENUMERATION = 9,
        ID = 1,
        IDREF = 2,
        IDREFS = 3,
        NCName = 11,
        NMTOKEN = 6,
        NMTOKENS = 7,
        None = 12,
        NOTATION = 8,
        QName = 10,
    }
    public partial class XmlUrlResolver : System.Xml.XmlResolver
    {
        public XmlUrlResolver() { }
        public System.Net.Cache.RequestCachePolicy CachePolicy { set { } }
        public override System.Net.ICredentials Credentials { set { } }
        public System.Net.IWebProxy Proxy { set { } }
        public override object GetEntity(System.Uri absoluteUri, string role, System.Type ofObjectToReturn) { throw null; }
        public override System.Threading.Tasks.Task<object> GetEntityAsync(System.Uri absoluteUri, string role, System.Type ofObjectToReturn) { throw null; }
        public override System.Uri ResolveUri(System.Uri baseUri, string relativeUri) { throw null; }
    }
    [System.ObsoleteAttribute("Use XmlReader created by XmlReader.Create() method using appropriate XmlReaderSettings instead. https://go.microsoft.com/fwlink/?linkid=14202")]
    public partial class XmlValidatingReader : System.Xml.XmlReader, System.Xml.IXmlLineInfo, System.Xml.IXmlNamespaceResolver
    {
        public XmlValidatingReader(System.IO.Stream xmlFragment, System.Xml.XmlNodeType fragType, System.Xml.XmlParserContext context) { }
        public XmlValidatingReader(string xmlFragment, System.Xml.XmlNodeType fragType, System.Xml.XmlParserContext context) { }
        public XmlValidatingReader(System.Xml.XmlReader reader) { }
        public override int AttributeCount { get { throw null; } }
        public override string BaseURI { get { throw null; } }
        public override bool CanReadBinaryContent { get { throw null; } }
        public override bool CanResolveEntity { get { throw null; } }
        public override int Depth { get { throw null; } }
        public System.Text.Encoding Encoding { get { throw null; } }
        public System.Xml.EntityHandling EntityHandling { get { throw null; } set { } }
        public override bool EOF { get { throw null; } }
        public override bool HasValue { get { throw null; } }
        public override bool IsDefault { get { throw null; } }
        public override bool IsEmptyElement { get { throw null; } }
        public int LineNumber { get { throw null; } }
        public int LinePosition { get { throw null; } }
        public override string LocalName { get { throw null; } }
        public override string Name { get { throw null; } }
        public bool Namespaces { get { throw null; } set { } }
        public override string NamespaceURI { get { throw null; } }
        public override System.Xml.XmlNameTable NameTable { get { throw null; } }
        public override System.Xml.XmlNodeType NodeType { get { throw null; } }
        public override string Prefix { get { throw null; } }
        public override char QuoteChar { get { throw null; } }
        public System.Xml.XmlReader Reader { get { throw null; } }
        public override System.Xml.ReadState ReadState { get { throw null; } }
        public System.Xml.Schema.XmlSchemaCollection Schemas { get { throw null; } }
        public object SchemaType { get { throw null; } }
        public System.Xml.ValidationType ValidationType { get { throw null; } set { } }
        public override string Value { get { throw null; } }
        public override string XmlLang { get { throw null; } }
        public System.Xml.XmlResolver XmlResolver { set { } }
        public override System.Xml.XmlSpace XmlSpace { get { throw null; } }
        public event System.Xml.Schema.ValidationEventHandler ValidationEventHandler { add { } remove { } }
        public override void Close() { }
        public override string GetAttribute(int i) { throw null; }
        public override string GetAttribute(string name) { throw null; }
        public override string GetAttribute(string localName, string namespaceURI) { throw null; }
        public bool HasLineInfo() { throw null; }
        public override string LookupNamespace(string prefix) { throw null; }
        public override void MoveToAttribute(int i) { }
        public override bool MoveToAttribute(string name) { throw null; }
        public override bool MoveToAttribute(string localName, string namespaceURI) { throw null; }
        public override bool MoveToElement() { throw null; }
        public override bool MoveToFirstAttribute() { throw null; }
        public override bool MoveToNextAttribute() { throw null; }
        public override bool Read() { throw null; }
        public override bool ReadAttributeValue() { throw null; }
        public override int ReadContentAsBase64(byte[] buffer, int index, int count) { throw null; }
        public override int ReadContentAsBinHex(byte[] buffer, int index, int count) { throw null; }
        public override int ReadElementContentAsBase64(byte[] buffer, int index, int count) { throw null; }
        public override int ReadElementContentAsBinHex(byte[] buffer, int index, int count) { throw null; }
        public override string ReadString() { throw null; }
        public object ReadTypedValue() { throw null; }
        public override void ResolveEntity() { }
        System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope) { throw null; }
        string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { throw null; }
        string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { throw null; }
    }
    public partial class XmlWhitespace : System.Xml.XmlCharacterData
    {
        protected internal XmlWhitespace(string strData, System.Xml.XmlDocument doc) : base (default(string), default(System.Xml.XmlDocument)) { }
        public override string LocalName { get { throw null; } }
        public override string Name { get { throw null; } }
        public override System.Xml.XmlNodeType NodeType { get { throw null; } }
        public override System.Xml.XmlNode ParentNode { get { throw null; } }
        public override System.Xml.XmlNode PreviousText { get { throw null; } }
        public override string Value { get { throw null; } set { } }
        public override System.Xml.XmlNode CloneNode(bool deep) { throw null; }
        public override void WriteContentTo(System.Xml.XmlWriter w) { }
        public override void WriteTo(System.Xml.XmlWriter w) { }
    }
    public abstract partial class XmlWriter : System.IDisposable
    {
        protected XmlWriter() { }
        public virtual System.Xml.XmlWriterSettings Settings { get { throw null; } }
        public abstract System.Xml.WriteState WriteState { get; }
        public virtual string XmlLang { get { throw null; } }
        public virtual System.Xml.XmlSpace XmlSpace { get { throw null; } }
        public virtual void Close() { }
        public static System.Xml.XmlWriter Create(System.IO.Stream output) { throw null; }
        public static System.Xml.XmlWriter Create(System.IO.Stream output, System.Xml.XmlWriterSettings settings) { throw null; }
        public static System.Xml.XmlWriter Create(System.IO.TextWriter output) { throw null; }
        public static System.Xml.XmlWriter Create(System.IO.TextWriter output, System.Xml.XmlWriterSettings settings) { throw null; }
        public static System.Xml.XmlWriter Create(string outputFileName) { throw null; }
        public static System.Xml.XmlWriter Create(string outputFileName, System.Xml.XmlWriterSettings settings) { throw null; }
        public static System.Xml.XmlWriter Create(System.Text.StringBuilder output) { throw null; }
        public static System.Xml.XmlWriter Create(System.Text.StringBuilder output, System.Xml.XmlWriterSettings settings) { throw null; }
        public static System.Xml.XmlWriter Create(System.Xml.XmlWriter output) { throw null; }
        public static System.Xml.XmlWriter Create(System.Xml.XmlWriter output, System.Xml.XmlWriterSettings settings) { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public abstract void Flush();
        public virtual System.Threading.Tasks.Task FlushAsync() { throw null; }
        public abstract string LookupPrefix(string ns);
        public virtual void WriteAttributes(System.Xml.XmlReader reader, bool defattr) { }
        public virtual System.Threading.Tasks.Task WriteAttributesAsync(System.Xml.XmlReader reader, bool defattr) { throw null; }
        public void WriteAttributeString(string localName, string value) { }
        public void WriteAttributeString(string localName, string ns, string value) { }
        public void WriteAttributeString(string prefix, string localName, string ns, string value) { }
        public System.Threading.Tasks.Task WriteAttributeStringAsync(string prefix, string localName, string ns, string value) { throw null; }
        public abstract void WriteBase64(byte[] buffer, int index, int count);
        public virtual System.Threading.Tasks.Task WriteBase64Async(byte[] buffer, int index, int count) { throw null; }
        public virtual void WriteBinHex(byte[] buffer, int index, int count) { }
        public virtual System.Threading.Tasks.Task WriteBinHexAsync(byte[] buffer, int index, int count) { throw null; }
        public abstract void WriteCData(string text);
        public virtual System.Threading.Tasks.Task WriteCDataAsync(string text) { throw null; }
        public abstract void WriteCharEntity(char ch);
        public virtual System.Threading.Tasks.Task WriteCharEntityAsync(char ch) { throw null; }
        public abstract void WriteChars(char[] buffer, int index, int count);
        public virtual System.Threading.Tasks.Task WriteCharsAsync(char[] buffer, int index, int count) { throw null; }
        public abstract void WriteComment(string text);
        public virtual System.Threading.Tasks.Task WriteCommentAsync(string text) { throw null; }
        public abstract void WriteDocType(string name, string pubid, string sysid, string subset);
        public virtual System.Threading.Tasks.Task WriteDocTypeAsync(string name, string pubid, string sysid, string subset) { throw null; }
        public void WriteElementString(string localName, string value) { }
        public void WriteElementString(string localName, string ns, string value) { }
        public void WriteElementString(string prefix, string localName, string ns, string value) { }
        public System.Threading.Tasks.Task WriteElementStringAsync(string prefix, string localName, string ns, string value) { throw null; }
        public abstract void WriteEndAttribute();
        protected internal virtual System.Threading.Tasks.Task WriteEndAttributeAsync() { throw null; }
        public abstract void WriteEndDocument();
        public virtual System.Threading.Tasks.Task WriteEndDocumentAsync() { throw null; }
        public abstract void WriteEndElement();
        public virtual System.Threading.Tasks.Task WriteEndElementAsync() { throw null; }
        public abstract void WriteEntityRef(string name);
        public virtual System.Threading.Tasks.Task WriteEntityRefAsync(string name) { throw null; }
        public abstract void WriteFullEndElement();
        public virtual System.Threading.Tasks.Task WriteFullEndElementAsync() { throw null; }
        public virtual void WriteName(string name) { }
        public virtual System.Threading.Tasks.Task WriteNameAsync(string name) { throw null; }
        public virtual void WriteNmToken(string name) { }
        public virtual System.Threading.Tasks.Task WriteNmTokenAsync(string name) { throw null; }
        public virtual void WriteNode(System.Xml.XmlReader reader, bool defattr) { }
        public virtual void WriteNode(System.Xml.XPath.XPathNavigator navigator, bool defattr) { }
        public virtual System.Threading.Tasks.Task WriteNodeAsync(System.Xml.XmlReader reader, bool defattr) { throw null; }
        public virtual System.Threading.Tasks.Task WriteNodeAsync(System.Xml.XPath.XPathNavigator navigator, bool defattr) { throw null; }
        public abstract void WriteProcessingInstruction(string name, string text);
        public virtual System.Threading.Tasks.Task WriteProcessingInstructionAsync(string name, string text) { throw null; }
        public virtual void WriteQualifiedName(string localName, string ns) { }
        public virtual System.Threading.Tasks.Task WriteQualifiedNameAsync(string localName, string ns) { throw null; }
        public abstract void WriteRaw(char[] buffer, int index, int count);
        public abstract void WriteRaw(string data);
        public virtual System.Threading.Tasks.Task WriteRawAsync(char[] buffer, int index, int count) { throw null; }
        public virtual System.Threading.Tasks.Task WriteRawAsync(string data) { throw null; }
        public void WriteStartAttribute(string localName) { }
        public void WriteStartAttribute(string localName, string ns) { }
        public abstract void WriteStartAttribute(string prefix, string localName, string ns);
        protected internal virtual System.Threading.Tasks.Task WriteStartAttributeAsync(string prefix, string localName, string ns) { throw null; }
        public abstract void WriteStartDocument();
        public abstract void WriteStartDocument(bool standalone);
        public virtual System.Threading.Tasks.Task WriteStartDocumentAsync() { throw null; }
        public virtual System.Threading.Tasks.Task WriteStartDocumentAsync(bool standalone) { throw null; }
        public void WriteStartElement(string localName) { }
        public void WriteStartElement(string localName, string ns) { }
        public abstract void WriteStartElement(string prefix, string localName, string ns);
        public virtual System.Threading.Tasks.Task WriteStartElementAsync(string prefix, string localName, string ns) { throw null; }
        public abstract void WriteString(string text);
        public virtual System.Threading.Tasks.Task WriteStringAsync(string text) { throw null; }
        public abstract void WriteSurrogateCharEntity(char lowChar, char highChar);
        public virtual System.Threading.Tasks.Task WriteSurrogateCharEntityAsync(char lowChar, char highChar) { throw null; }
        public virtual void WriteValue(bool value) { }
        public virtual void WriteValue(System.DateTime value) { }
        public virtual void WriteValue(System.DateTimeOffset value) { }
        public virtual void WriteValue(decimal value) { }
        public virtual void WriteValue(double value) { }
        public virtual void WriteValue(int value) { }
        public virtual void WriteValue(long value) { }
        public virtual void WriteValue(object value) { }
        public virtual void WriteValue(float value) { }
        public virtual void WriteValue(string value) { }
        public abstract void WriteWhitespace(string ws);
        public virtual System.Threading.Tasks.Task WriteWhitespaceAsync(string ws) { throw null; }
    }
    public sealed partial class XmlWriterSettings
    {
        public XmlWriterSettings() { }
        public bool Async { get { throw null; } set { } }
        public bool CheckCharacters { get { throw null; } set { } }
        public bool CloseOutput { get { throw null; } set { } }
        public System.Xml.ConformanceLevel ConformanceLevel { get { throw null; } set { } }
        public bool DoNotEscapeUriAttributes { get { throw null; } set { } }
        public System.Text.Encoding Encoding { get { throw null; } set { } }
        public bool Indent { get { throw null; } set { } }
        public string IndentChars { get { throw null; } set { } }
        public System.Xml.NamespaceHandling NamespaceHandling { get { throw null; } set { } }
        public string NewLineChars { get { throw null; } set { } }
        public System.Xml.NewLineHandling NewLineHandling { get { throw null; } set { } }
        public bool NewLineOnAttributes { get { throw null; } set { } }
        public bool OmitXmlDeclaration { get { throw null; } set { } }
        public System.Xml.XmlOutputMethod OutputMethod { get { throw null; } }
        public bool WriteEndDocumentOnClose { get { throw null; } set { } }
        public System.Xml.XmlWriterSettings Clone() { throw null; }
        public void Reset() { }
    }
}
