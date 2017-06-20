# System.Xml.Xsl.Runtime

``` diff
+namespace System.Xml.Xsl.Runtime {
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct AncestorDocOrderIterator {
+        public XPathNavigator Current { get; }
+        public void Create(XPathNavigator context, XmlNavigatorFilter filter, bool orSelf);
+        public bool MoveNext();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct AncestorIterator {
+        public XPathNavigator Current { get; }
+        public void Create(XPathNavigator context, XmlNavigatorFilter filter, bool orSelf);
+        public bool MoveNext();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct AttributeContentIterator {
+        public XPathNavigator Current { get; }
+        public void Create(XPathNavigator context);
+        public bool MoveNext();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct AttributeIterator {
+        public XPathNavigator Current { get; }
+        public void Create(XPathNavigator context);
+        public bool MoveNext();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct ContentIterator {
+        public XPathNavigator Current { get; }
+        public void Create(XPathNavigator context);
+        public bool MoveNext();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct ContentMergeIterator {
+        public XPathNavigator Current { get; }
+        public void Create(XmlNavigatorFilter filter);
+        public IteratorResult MoveNext(XPathNavigator input);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct DecimalAggregator {
+        public decimal AverageResult { get; }
+        public bool IsEmpty { get; }
+        public decimal MaximumResult { get; }
+        public decimal MinimumResult { get; }
+        public decimal SumResult { get; }
+        public void Average(decimal value);
+        public void Create();
+        public void Maximum(decimal value);
+        public void Minimum(decimal value);
+        public void Sum(decimal value);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct DescendantIterator {
+        public XPathNavigator Current { get; }
+        public void Create(XPathNavigator input, XmlNavigatorFilter filter, bool orSelf);
+        public bool MoveNext();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct DescendantMergeIterator {
+        public XPathNavigator Current { get; }
+        public void Create(XmlNavigatorFilter filter, bool orSelf);
+        public IteratorResult MoveNext(XPathNavigator input);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct DifferenceIterator {
+        public XPathNavigator Current { get; }
+        public void Create(XmlQueryRuntime runtime);
+        public SetIteratorResult MoveNext(XPathNavigator nestedNavigator);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct DodSequenceMerge {
+        public void AddSequence(IList<XPathNavigator> sequence);
+        public void Create(XmlQueryRuntime runtime);
+        public IList<XPathNavigator> MergeSequences();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct DoubleAggregator {
+        public double AverageResult { get; }
+        public bool IsEmpty { get; }
+        public double MaximumResult { get; }
+        public double MinimumResult { get; }
+        public double SumResult { get; }
+        public void Average(double value);
+        public void Create();
+        public void Maximum(double value);
+        public void Minimum(double value);
+        public void Sum(double value);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct ElementContentIterator {
+        public XPathNavigator Current { get; }
+        public void Create(XPathNavigator context, string localName, string ns);
+        public bool MoveNext();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct FollowingSiblingIterator {
+        public XPathNavigator Current { get; }
+        public void Create(XPathNavigator context, XmlNavigatorFilter filter);
+        public bool MoveNext();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct FollowingSiblingMergeIterator {
+        public XPathNavigator Current { get; }
+        public void Create(XmlNavigatorFilter filter);
+        public IteratorResult MoveNext(XPathNavigator navigator);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct IdIterator {
+        public XPathNavigator Current { get; }
+        public void Create(XPathNavigator context, string value);
+        public bool MoveNext();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct Int32Aggregator {
+        public int AverageResult { get; }
+        public bool IsEmpty { get; }
+        public int MaximumResult { get; }
+        public int MinimumResult { get; }
+        public int SumResult { get; }
+        public void Average(int value);
+        public void Create();
+        public void Maximum(int value);
+        public void Minimum(int value);
+        public void Sum(int value);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct Int64Aggregator {
+        public long AverageResult { get; }
+        public bool IsEmpty { get; }
+        public long MaximumResult { get; }
+        public long MinimumResult { get; }
+        public long SumResult { get; }
+        public void Average(long value);
+        public void Create();
+        public void Maximum(long value);
+        public void Minimum(long value);
+        public void Sum(long value);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct IntersectIterator {
+        public XPathNavigator Current { get; }
+        public void Create(XmlQueryRuntime runtime);
+        public SetIteratorResult MoveNext(XPathNavigator nestedNavigator);
+    }
+    public enum IteratorResult {
+        HaveCurrentNode = 2,
+        NeedInputNode = 1,
+        NoMoreNodes = 0,
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct NamespaceIterator {
+        public XPathNavigator Current { get; }
+        public void Create(XPathNavigator context);
+        public bool MoveNext();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct NodeKindContentIterator {
+        public XPathNavigator Current { get; }
+        public void Create(XPathNavigator context, XPathNodeType nodeType);
+        public bool MoveNext();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct NodeRangeIterator {
+        public XPathNavigator Current { get; }
+        public void Create(XPathNavigator start, XmlNavigatorFilter filter, XPathNavigator end);
+        public bool MoveNext();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct ParentIterator {
+        public XPathNavigator Current { get; }
+        public void Create(XPathNavigator context, XmlNavigatorFilter filter);
+        public bool MoveNext();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct PrecedingIterator {
+        public XPathNavigator Current { get; }
+        public void Create(XPathNavigator context, XmlNavigatorFilter filter);
+        public bool MoveNext();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct PrecedingSiblingDocOrderIterator {
+        public XPathNavigator Current { get; }
+        public void Create(XPathNavigator context, XmlNavigatorFilter filter);
+        public bool MoveNext();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct PrecedingSiblingIterator {
+        public XPathNavigator Current { get; }
+        public void Create(XPathNavigator context, XmlNavigatorFilter filter);
+        public bool MoveNext();
+    }
+    public enum SetIteratorResult {
+        HaveCurrentNode = 4,
+        InitRightIterator = 1,
+        NeedLeftNode = 2,
+        NeedRightNode = 3,
+        NoMoreNodes = 0,
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct StringConcat {
+        public string Delimiter { get; set; }
+        public void Clear();
+        public void Concat(string value);
+        public string GetResult();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct UnionIterator {
+        public XPathNavigator Current { get; }
+        public void Create(XmlQueryRuntime runtime);
+        public SetIteratorResult MoveNext(XPathNavigator nestedNavigator);
+    }
+    public sealed class XmlCollation {
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+    }
+    public sealed class XmlILIndex {
+        public void Add(string key, XPathNavigator navigator);
+        public XmlQueryNodeSequence Lookup(string key);
+    }
+    public static class XmlILStorageConverter {
+        public static XmlAtomicValue BooleanToAtomicValue(bool value, int index, XmlQueryRuntime runtime);
+        public static XmlAtomicValue BytesToAtomicValue(byte[] value, int index, XmlQueryRuntime runtime);
+        public static XmlAtomicValue DateTimeToAtomicValue(DateTime value, int index, XmlQueryRuntime runtime);
+        public static XmlAtomicValue DecimalToAtomicValue(decimal value, int index, XmlQueryRuntime runtime);
+        public static XmlAtomicValue DoubleToAtomicValue(double value, int index, XmlQueryRuntime runtime);
+        public static XmlAtomicValue Int32ToAtomicValue(int value, int index, XmlQueryRuntime runtime);
+        public static XmlAtomicValue Int64ToAtomicValue(long value, int index, XmlQueryRuntime runtime);
+        public static IList<XPathNavigator> ItemsToNavigators(IList<XPathItem> listItems);
+        public static IList<XPathItem> NavigatorsToItems(IList<XPathNavigator> listNavigators);
+        public static XmlAtomicValue SingleToAtomicValue(float value, int index, XmlQueryRuntime runtime);
+        public static XmlAtomicValue StringToAtomicValue(string value, int index, XmlQueryRuntime runtime);
+        public static XmlAtomicValue TimeSpanToAtomicValue(TimeSpan value, int index, XmlQueryRuntime runtime);
+        public static XmlAtomicValue XmlQualifiedNameToAtomicValue(XmlQualifiedName value, int index, XmlQueryRuntime runtime);
+    }
+    public abstract class XmlNavigatorFilter {
+        protected XmlNavigatorFilter();
+        public abstract bool IsFiltered(XPathNavigator navigator);
+        public abstract bool MoveToContent(XPathNavigator navigator);
+        public abstract bool MoveToFollowing(XPathNavigator navigator, XPathNavigator navigatorEnd);
+        public abstract bool MoveToFollowingSibling(XPathNavigator navigator);
+        public abstract bool MoveToNextContent(XPathNavigator navigator);
+        public abstract bool MoveToPreviousSibling(XPathNavigator navigator);
+    }
+    public sealed class XmlQueryContext {
+        public XPathNavigator DefaultDataSource { get; }
+        public XmlNameTable DefaultNameTable { get; }
+        public XmlNameTable QueryNameTable { get; }
+        public XPathNavigator GetDataSource(string uriRelative, string uriBase);
+        public object GetLateBoundObject(string namespaceUri);
+        public object GetParameter(string localName, string namespaceUri);
+        public IList<XPathItem> InvokeXsltLateBoundFunction(string name, string namespaceUri, IList<XPathItem>[] args);
+        public bool LateBoundFunctionExists(string name, string namespaceUri);
+        public void OnXsltMessageEncountered(string message);
+    }
+    public sealed class XmlQueryItemSequence : XmlQuerySequence<XPathItem> {
+        public static readonly new XmlQueryItemSequence Empty;
+        public XmlQueryItemSequence();
+        public XmlQueryItemSequence(int capacity);
+        public XmlQueryItemSequence(XPathItem item);
+        public void AddClone(XPathItem item);
+        public static XmlQueryItemSequence CreateOrReuse(XmlQueryItemSequence seq);
+        public static XmlQueryItemSequence CreateOrReuse(XmlQueryItemSequence seq, XPathItem item);
+    }
+    public sealed class XmlQueryNodeSequence : XmlQuerySequence<XPathNavigator>, ICollection<XPathItem>, IEnumerable, IEnumerable<XPathItem>, IList<XPathItem> {
+        public static readonly new XmlQueryNodeSequence Empty;
+        public XmlQueryNodeSequence();
+        public XmlQueryNodeSequence(IList<XPathNavigator> list);
+        public XmlQueryNodeSequence(int capacity);
+        public XmlQueryNodeSequence(XPathNavigator navigator);
+        public XmlQueryNodeSequence(XPathNavigator[] array, int size);
+        public bool IsDocOrderDistinct { get; set; }
+        bool System.Collections.Generic.ICollection<System.Xml.XPath.XPathItem>.IsReadOnly { get; }
+        XPathItem System.Collections.Generic.IList<System.Xml.XPath.XPathItem>.this[int index] { get; set; }
+        public void AddClone(XPathNavigator navigator);
+        public static XmlQueryNodeSequence CreateOrReuse(XmlQueryNodeSequence seq);
+        public static XmlQueryNodeSequence CreateOrReuse(XmlQueryNodeSequence seq, XPathNavigator navigator);
+        public XmlQueryNodeSequence DocOrderDistinct(IComparer<XPathNavigator> comparer);
+        protected override void OnItemsChanged();
+        void System.Collections.Generic.ICollection<System.Xml.XPath.XPathItem>.Add(XPathItem value);
+        void System.Collections.Generic.ICollection<System.Xml.XPath.XPathItem>.Clear();
+        bool System.Collections.Generic.ICollection<System.Xml.XPath.XPathItem>.Contains(XPathItem value);
+        void System.Collections.Generic.ICollection<System.Xml.XPath.XPathItem>.CopyTo(XPathItem[] array, int index);
+        bool System.Collections.Generic.ICollection<System.Xml.XPath.XPathItem>.Remove(XPathItem value);
+        IEnumerator<XPathItem> System.Collections.Generic.IEnumerable<System.Xml.XPath.XPathItem>.GetEnumerator();
+        int System.Collections.Generic.IList<System.Xml.XPath.XPathItem>.IndexOf(XPathItem value);
+        void System.Collections.Generic.IList<System.Xml.XPath.XPathItem>.Insert(int index, XPathItem value);
+        void System.Collections.Generic.IList<System.Xml.XPath.XPathItem>.RemoveAt(int index);
+    }
+    public sealed class XmlQueryOutput : XmlWriter {
+        public override WriteState WriteState { get; }
+        public override string XmlLang { get; }
+        public override XmlSpace XmlSpace { get; }
+        public override void Close();
+        public void EndCopy(XPathNavigator navigator);
+        public void EndTree();
+        public override void Flush();
+        public override string LookupPrefix(string ns);
+        public bool StartCopy(XPathNavigator navigator);
+        public void StartElementContentUnchecked();
+        public void StartTree(XPathNodeType rootType);
+        public override void WriteBase64(byte[] buffer, int index, int count);
+        public override void WriteCData(string text);
+        public override void WriteCharEntity(char ch);
+        public override void WriteChars(char[] buffer, int index, int count);
+        public override void WriteComment(string text);
+        public void WriteCommentString(string text);
+        public override void WriteDocType(string name, string pubid, string sysid, string subset);
+        public override void WriteEndAttribute();
+        public void WriteEndAttributeUnchecked();
+        public void WriteEndComment();
+        public override void WriteEndDocument();
+        public override void WriteEndElement();
+        public void WriteEndElementUnchecked(string localName);
+        public void WriteEndElementUnchecked(string prefix, string localName, string ns);
+        public void WriteEndNamespace();
+        public void WriteEndProcessingInstruction();
+        public void WriteEndRoot();
+        public override void WriteEntityRef(string name);
+        public override void WriteFullEndElement();
+        public void WriteItem(XPathItem item);
+        public void WriteNamespaceDeclaration(string prefix, string ns);
+        public void WriteNamespaceDeclarationUnchecked(string prefix, string ns);
+        public void WriteNamespaceString(string text);
+        public override void WriteProcessingInstruction(string target, string text);
+        public void WriteProcessingInstructionString(string text);
+        public override void WriteRaw(char[] buffer, int index, int count);
+        public override void WriteRaw(string data);
+        public void WriteRawUnchecked(string text);
+        public override void WriteStartAttribute(string prefix, string localName, string ns);
+        public void WriteStartAttributeComputed(string tagName, int prefixMappingsIndex);
+        public void WriteStartAttributeComputed(string tagName, string ns);
+        public void WriteStartAttributeComputed(XmlQualifiedName name);
+        public void WriteStartAttributeComputed(XPathNavigator navigator);
+        public void WriteStartAttributeLocalName(string localName);
+        public void WriteStartAttributeUnchecked(string localName);
+        public void WriteStartAttributeUnchecked(string prefix, string localName, string ns);
+        public void WriteStartComment();
+        public override void WriteStartDocument();
+        public override void WriteStartDocument(bool standalone);
+        public override void WriteStartElement(string prefix, string localName, string ns);
+        public void WriteStartElementComputed(string tagName, int prefixMappingsIndex);
+        public void WriteStartElementComputed(string tagName, string ns);
+        public void WriteStartElementComputed(XmlQualifiedName name);
+        public void WriteStartElementComputed(XPathNavigator navigator);
+        public void WriteStartElementLocalName(string localName);
+        public void WriteStartElementUnchecked(string localName);
+        public void WriteStartElementUnchecked(string prefix, string localName, string ns);
+        public void WriteStartNamespace(string prefix);
+        public void WriteStartProcessingInstruction(string target);
+        public void WriteStartRoot();
+        public override void WriteString(string text);
+        public void WriteStringUnchecked(string text);
+        public override void WriteSurrogateCharEntity(char lowChar, char highChar);
+        public override void WriteWhitespace(string ws);
+        public void XsltCopyOf(XPathNavigator navigator);
+    }
+    public sealed class XmlQueryRuntime {
+        public XmlQueryContext ExternalContext { get; }
+        public XmlNameTable NameTable { get; }
+        public XmlQueryOutput Output { get; }
+        public XsltLibrary XsltFunctions { get; }
+        public void AddNewIndex(XPathNavigator context, int indexId, XmlILIndex index);
+        public object ChangeTypeXsltArgument(int indexType, object value, Type destinationType);
+        public object ChangeTypeXsltResult(int indexType, object value);
+        public int ComparePosition(XPathNavigator navigatorThis, XPathNavigator navigatorThat);
+        public XmlCollation CreateCollation(string collation);
+        public string[] DebugGetGlobalNames();
+        public IList DebugGetGlobalValue(string name);
+        public object DebugGetXsltValue(IList seq);
+        public void DebugSetGlobalValue(string name, object value);
+        public IList<XPathNavigator> DocOrderDistinct(IList<XPathNavigator> seq);
+        public bool EarlyBoundFunctionExists(string name, string namespaceUri);
+        public XPathNavigator EndRtfConstruction(out XmlQueryOutput output);
+        public IList<XPathItem> EndSequenceConstruction(out XmlQueryOutput output);
+        public bool FindIndex(XPathNavigator context, int indexId, out XmlILIndex index);
+        public string GenerateId(XPathNavigator navigator);
+        public string GetAtomizedName(int index);
+        public XmlCollation GetCollation(int index);
+        public object GetEarlyBoundObject(int index);
+        public object GetGlobalValue(int index);
+        public XmlNavigatorFilter GetNameFilter(int index);
+        public XmlNavigatorFilter GetTypeFilter(XPathNodeType nodeType);
+        public bool IsGlobalComputed(int index);
+        public bool IsQNameEqual(XPathNavigator navigator, int indexLocalName, int indexNamespaceUri);
+        public bool IsQNameEqual(XPathNavigator n1, XPathNavigator n2);
+        public bool MatchesXmlType(IList<XPathItem> seq, int indexType);
+        public bool MatchesXmlType(IList<XPathItem> seq, XmlTypeCode code);
+        public bool MatchesXmlType(XPathItem item, int indexType);
+        public bool MatchesXmlType(XPathItem item, XmlTypeCode code);
+        public static int OnCurrentNodeChanged(XPathNavigator currentNode);
+        public XmlQualifiedName ParseTagName(string tagName, int indexPrefixMappings);
+        public XmlQualifiedName ParseTagName(string tagName, string ns);
+        public void SendMessage(string message);
+        public void SetGlobalValue(int index, object value);
+        public void StartRtfConstruction(string baseUri, out XmlQueryOutput output);
+        public void StartSequenceConstruction(out XmlQueryOutput output);
+        public XPathNavigator TextRtfConstruction(string text, string baseUri);
+        public void ThrowException(string text);
+    }
+    public class XmlQuerySequence<T> : ICollection, ICollection<T>, IEnumerable, IEnumerable<T>, IList, IList<T> {
+        public static readonly XmlQuerySequence<T> Empty;
+        public XmlQuerySequence();
+        public XmlQuerySequence(int capacity);
+        public XmlQuerySequence(T value);
+        public XmlQuerySequence(T[] array, int size);
+        public int Count { get; }
+        bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public T this[int index] { get; set; }
+        public void Add(T value);
+        public void Clear();
+        public bool Contains(T value);
+        public void CopyTo(T[] array, int index);
+        public static XmlQuerySequence<T> CreateOrReuse(XmlQuerySequence<T> seq);
+        public static XmlQuerySequence<T> CreateOrReuse(XmlQuerySequence<T> seq, T item);
+        public IEnumerator<T> GetEnumerator();
+        public int IndexOf(T value);
+        protected virtual void OnItemsChanged();
+        public void SortByKeys(Array keys);
+        void System.Collections.Generic.ICollection<T>.Add(T value);
+        void System.Collections.Generic.ICollection<T>.Clear();
+        bool System.Collections.Generic.ICollection<T>.Remove(T value);
+        void System.Collections.Generic.IList<T>.Insert(int index, T value);
+        void System.Collections.Generic.IList<T>.RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        void System.Collections.IList.Clear();
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        void System.Collections.IList.RemoveAt(int index);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct XmlSortKeyAccumulator {
+        public Array Keys { get; }
+        public void AddDateTimeSortKey(XmlCollation collation, DateTime value);
+        public void AddDecimalSortKey(XmlCollation collation, decimal value);
+        public void AddDoubleSortKey(XmlCollation collation, double value);
+        public void AddEmptySortKey(XmlCollation collation);
+        public void AddIntegerSortKey(XmlCollation collation, long value);
+        public void AddIntSortKey(XmlCollation collation, int value);
+        public void AddStringSortKey(XmlCollation collation, string value);
+        public void Create();
+        public void FinishSortKeys();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct XPathFollowingIterator {
+        public XPathNavigator Current { get; }
+        public void Create(XPathNavigator input, XmlNavigatorFilter filter);
+        public bool MoveNext();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct XPathFollowingMergeIterator {
+        public XPathNavigator Current { get; }
+        public void Create(XmlNavigatorFilter filter);
+        public IteratorResult MoveNext(XPathNavigator input);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct XPathPrecedingDocOrderIterator {
+        public XPathNavigator Current { get; }
+        public void Create(XPathNavigator input, XmlNavigatorFilter filter);
+        public bool MoveNext();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct XPathPrecedingIterator {
+        public XPathNavigator Current { get; }
+        public void Create(XPathNavigator context, XmlNavigatorFilter filter);
+        public bool MoveNext();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct XPathPrecedingMergeIterator {
+        public XPathNavigator Current { get; }
+        public void Create(XmlNavigatorFilter filter);
+        public IteratorResult MoveNext(XPathNavigator input);
+    }
+    public static class XsltConvert {
+        public static IList<XPathNavigator> EnsureNodeSet(IList<XPathItem> listItems);
+        public static bool ToBoolean(IList<XPathItem> listItems);
+        public static bool ToBoolean(XPathItem item);
+        public static DateTime ToDateTime(string value);
+        public static decimal ToDecimal(double value);
+        public static double ToDouble(IList<XPathItem> listItems);
+        public static double ToDouble(decimal value);
+        public static double ToDouble(int value);
+        public static double ToDouble(long value);
+        public static double ToDouble(string value);
+        public static double ToDouble(XPathItem item);
+        public static int ToInt(double value);
+        public static long ToLong(double value);
+        public static XPathNavigator ToNode(IList<XPathItem> listItems);
+        public static XPathNavigator ToNode(XPathItem item);
+        public static IList<XPathNavigator> ToNodeSet(IList<XPathItem> listItems);
+        public static IList<XPathNavigator> ToNodeSet(XPathItem item);
+        public static string ToString(IList<XPathItem> listItems);
+        public static string ToString(DateTime value);
+        public static string ToString(double value);
+        public static string ToString(XPathItem item);
+    }
+    public static class XsltFunctions {
+        public static string BaseUri(XPathNavigator navigator);
+        public static bool Contains(string s1, string s2);
+        public static string EXslObjectType(IList<XPathItem> value);
+        public static bool Lang(string value, XPathNavigator context);
+        public static string MSFormatDateTime(string dateTime, string format, string lang, bool isDate);
+        public static string MSLocalName(string name);
+        public static string MSNamespaceUri(string name, XPathNavigator currentNode);
+        public static double MSNumber(IList<XPathItem> value);
+        public static double MSStringCompare(string s1, string s2, string lang, string options);
+        public static string MSUtc(string dateTime);
+        public static string NormalizeSpace(string value);
+        public static string OuterXml(XPathNavigator navigator);
+        public static double Round(double value);
+        public static bool StartsWith(string s1, string s2);
+        public static string Substring(string value, double startIndex);
+        public static string Substring(string value, double startIndex, double length);
+        public static string SubstringAfter(string s1, string s2);
+        public static string SubstringBefore(string s1, string s2);
+        public static XPathItem SystemProperty(XmlQualifiedName name);
+        public static string Translate(string arg, string mapString, string transString);
+    }
+    public sealed class XsltLibrary {
+        public int CheckScriptNamespace(string nsUri);
+        public bool ElementAvailable(XmlQualifiedName name);
+        public bool EqualityOperator(double opCode, IList<XPathItem> left, IList<XPathItem> right);
+        public string FormatMessage(string res, IList<string> args);
+        public string FormatNumberDynamic(double value, string formatPicture, XmlQualifiedName decimalFormatName, string errorMessageName);
+        public string FormatNumberStatic(double value, double decimalFormatterIndex);
+        public bool FunctionAvailable(XmlQualifiedName name);
+        public bool IsSameNodeSort(XPathNavigator nav1, XPathNavigator nav2);
+        public int LangToLcid(string lang, bool forwardCompatibility);
+        public string NumberFormat(IList<XPathItem> value, string formatString, double lang, string letterValue, string groupingSeparator, double groupingSize);
+        public int RegisterDecimalFormat(XmlQualifiedName name, string infinitySymbol, string nanSymbol, string characters);
+        public double RegisterDecimalFormatter(string formatPicture, string infinitySymbol, string nanSymbol, string characters);
+        public bool RelationalOperator(double opCode, IList<XPathItem> left, IList<XPathItem> right);
+    }
+}
```

