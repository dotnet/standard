# System.Xaml

``` diff
+namespace System.Xaml {
+    public class AmbientPropertyValue {
+        public AmbientPropertyValue(XamlMember property, object value);
+        public XamlMember RetrievedProperty { get; }
+        public object Value { get; }
+    }
+    public class AttachableMemberIdentifier : IEquatable<AttachableMemberIdentifier> {
+        public AttachableMemberIdentifier(Type declaringType, string memberName);
+        public Type DeclaringType { get; }
+        public string MemberName { get; }
+        public override bool Equals(object obj);
+        public bool Equals(AttachableMemberIdentifier other);
+        public override int GetHashCode();
+        public static bool operator ==(AttachableMemberIdentifier left, AttachableMemberIdentifier right);
+        public static bool operator !=(AttachableMemberIdentifier left, AttachableMemberIdentifier right);
+        public override string ToString();
+    }
+    public static class AttachablePropertyServices {
+        public static void CopyPropertiesTo(object instance, KeyValuePair<AttachableMemberIdentifier, object>[] array, int index);
+        public static int GetAttachedPropertyCount(object instance);
+        public static bool RemoveProperty(object instance, AttachableMemberIdentifier name);
+        public static void SetProperty(object instance, AttachableMemberIdentifier name, object value);
+        public static bool TryGetProperty(object instance, AttachableMemberIdentifier name, out object value);
+        public static bool TryGetProperty<T>(object instance, AttachableMemberIdentifier name, out T value);
+    }
+    public interface IAmbientProvider {
+        IEnumerable<AmbientPropertyValue> GetAllAmbientValues(IEnumerable<XamlType> ceilingTypes, bool searchLiveStackOnly, IEnumerable<XamlType> types, params XamlMember[] properties);
+        IEnumerable<AmbientPropertyValue> GetAllAmbientValues(IEnumerable<XamlType> ceilingTypes, params XamlMember[] properties);
+        IEnumerable<object> GetAllAmbientValues(params XamlType[] types);
+        AmbientPropertyValue GetFirstAmbientValue(IEnumerable<XamlType> ceilingTypes, params XamlMember[] properties);
+        object GetFirstAmbientValue(params XamlType[] types);
+    }
+    public interface IAttachedPropertyStore {
+        int PropertyCount { get; }
+        void CopyPropertiesTo(KeyValuePair<AttachableMemberIdentifier, object>[] array, int index);
+        bool RemoveProperty(AttachableMemberIdentifier attachableMemberIdentifier);
+        void SetProperty(AttachableMemberIdentifier attachableMemberIdentifier, object value);
+        bool TryGetProperty(AttachableMemberIdentifier attachableMemberIdentifier, out object value);
+    }
+    public interface IDestinationTypeProvider {
+        Type GetDestinationType();
+    }
+    public interface INamespacePrefixLookup {
+        string LookupPrefix(string ns);
+    }
+    public interface IRootObjectProvider {
+        object RootObject { get; }
+    }
+    public interface IXamlIndexingReader {
+        int Count { get; }
+        int CurrentIndex { get; set; }
+    }
+    public interface IXamlLineInfo {
+        bool HasLineInfo { get; }
+        int LineNumber { get; }
+        int LinePosition { get; }
+    }
+    public interface IXamlLineInfoConsumer {
+        bool ShouldProvideLineInfo { get; }
+        void SetLineInfo(int lineNumber, int linePosition);
+    }
+    public interface IXamlNameProvider {
+        string GetName(object value);
+    }
+    public interface IXamlNameResolver {
+        bool IsFixupTokenAvailable { get; }
+        event EventHandler OnNameScopeInitializationComplete;
+        IEnumerable<KeyValuePair<string, object>> GetAllNamesAndValuesInScope();
+        object GetFixupToken(IEnumerable<string> names);
+        object GetFixupToken(IEnumerable<string> names, bool canAssignDirectly);
+        object Resolve(string name);
+        object Resolve(string name, out bool isFullyInitialized);
+    }
+    public interface IXamlNamespaceResolver {
+        string GetNamespace(string prefix);
+        IEnumerable<NamespaceDeclaration> GetNamespacePrefixes();
+    }
+    public interface IXamlObjectWriterFactory {
+        XamlObjectWriterSettings GetParentSettings();
+        XamlObjectWriter GetXamlObjectWriter(XamlObjectWriterSettings settings);
+    }
+    public interface IXamlSchemaContextProvider {
+        XamlSchemaContext SchemaContext { get; }
+    }
+    public class NamespaceDeclaration {
+        public NamespaceDeclaration(string ns, string prefix);
+        public string Namespace { get; }
+        public string Prefix { get; }
+    }
+    public class XamlBackgroundReader : XamlReader, IXamlLineInfo {
+        public XamlBackgroundReader(XamlReader wrappedReader);
+        public bool HasLineInfo { get; }
+        public override bool IsEof { get; }
+        public int LineNumber { get; }
+        public int LinePosition { get; }
+        public override XamlMember Member { get; }
+        public override NamespaceDeclaration Namespace { get; }
+        public override XamlNodeType NodeType { get; }
+        public override XamlSchemaContext SchemaContext { get; }
+        public override XamlType Type { get; }
+        public override object Value { get; }
+        protected override void Dispose(bool disposing);
+        public override bool Read();
+        public void StartThread();
+        public void StartThread(string threadName);
+    }
+    public abstract class XamlDeferringLoader {
+        protected XamlDeferringLoader();
+        public abstract object Load(XamlReader xamlReader, IServiceProvider serviceProvider);
+        public abstract XamlReader Save(object value, IServiceProvider serviceProvider);
+    }
+    public class XamlDirective : XamlMember {
+        public XamlDirective(IEnumerable<string> xamlNamespaces, string name, XamlType xamlType, XamlValueConverter<TypeConverter> typeConverter, AllowedMemberLocations allowedLocation);
+        public XamlDirective(string xamlNamespace, string name);
+        public AllowedMemberLocations AllowedLocation { get; }
+        public override int GetHashCode();
+        public override IList<string> GetXamlNamespaces();
+        protected sealed override ICustomAttributeProvider LookupCustomAttributeProvider();
+        protected sealed override XamlValueConverter<XamlDeferringLoader> LookupDeferringLoader();
+        protected sealed override IList<XamlMember> LookupDependsOn();
+        protected sealed override XamlMemberInvoker LookupInvoker();
+        protected sealed override bool LookupIsAmbient();
+        protected sealed override bool LookupIsEvent();
+        protected sealed override bool LookupIsReadOnly();
+        protected sealed override bool LookupIsReadPublic();
+        protected sealed override bool LookupIsUnknown();
+        protected sealed override bool LookupIsWriteOnly();
+        protected sealed override bool LookupIsWritePublic();
+        protected sealed override XamlType LookupTargetType();
+        protected sealed override XamlType LookupType();
+        protected sealed override XamlValueConverter<TypeConverter> LookupTypeConverter();
+        protected sealed override MethodInfo LookupUnderlyingGetter();
+        protected sealed override MemberInfo LookupUnderlyingMember();
+        protected sealed override MethodInfo LookupUnderlyingSetter();
+        public override string ToString();
+    }
+    public class XamlDuplicateMemberException : XamlException {
+        public XamlDuplicateMemberException();
+        protected XamlDuplicateMemberException(SerializationInfo info, StreamingContext context);
+        public XamlDuplicateMemberException(string message);
+        public XamlDuplicateMemberException(string message, Exception innerException);
+        public XamlDuplicateMemberException(XamlMember member, XamlType type);
+        public XamlMember DuplicateMember { get; set; }
+        public XamlType ParentType { get; set; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class XamlException : Exception {
+        public XamlException();
+        protected XamlException(SerializationInfo info, StreamingContext context);
+        public XamlException(string message);
+        public XamlException(string message, Exception innerException);
+        public XamlException(string message, Exception innerException, int lineNumber, int linePosition);
+        public int LineNumber { get; protected set; }
+        public int LinePosition { get; protected set; }
+        public override string Message { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class XamlInternalException : XamlException {
+        public XamlInternalException();
+        protected XamlInternalException(SerializationInfo info, StreamingContext context);
+        public XamlInternalException(string message);
+        public XamlInternalException(string message, Exception innerException);
+    }
+    public static class XamlLanguage {
+        public const string Xaml2006Namespace = "http://schemas.microsoft.com/winfx/2006/xaml";
+        public const string Xml1998Namespace = "http://www.w3.org/XML/1998/namespace";
+        public static ReadOnlyCollection<XamlDirective> AllDirectives { get; }
+        public static ReadOnlyCollection<XamlType> AllTypes { get; }
+        public static XamlDirective Arguments { get; }
+        public static XamlType Array { get; }
+        public static XamlDirective AsyncRecords { get; }
+        public static XamlDirective Base { get; }
+        public static XamlType Boolean { get; }
+        public static XamlType Byte { get; }
+        public static XamlType Char { get; }
+        public static XamlDirective Class { get; }
+        public static XamlDirective ClassAttributes { get; }
+        public static XamlDirective ClassModifier { get; }
+        public static XamlDirective Code { get; }
+        public static XamlDirective ConnectionId { get; }
+        public static XamlType Decimal { get; }
+        public static XamlType Double { get; }
+        public static XamlDirective FactoryMethod { get; }
+        public static XamlDirective FieldModifier { get; }
+        public static XamlDirective Initialization { get; }
+        public static XamlType Int16 { get; }
+        public static XamlType Int32 { get; }
+        public static XamlType Int64 { get; }
+        public static XamlDirective Items { get; }
+        public static XamlDirective Key { get; }
+        public static XamlDirective Lang { get; }
+        public static XamlType Member { get; }
+        public static XamlDirective Members { get; }
+        public static XamlDirective Name { get; }
+        public static XamlType Null { get; }
+        public static XamlType Object { get; }
+        public static XamlDirective PositionalParameters { get; }
+        public static XamlType Property { get; }
+        public static XamlType Reference { get; }
+        public static XamlDirective Shared { get; }
+        public static XamlType Single { get; }
+        public static XamlDirective Space { get; }
+        public static XamlType Static { get; }
+        public static XamlType String { get; }
+        public static XamlDirective Subclass { get; }
+        public static XamlDirective SynchronousMode { get; }
+        public static XamlType TimeSpan { get; }
+        public static XamlType Type { get; }
+        public static XamlDirective TypeArguments { get; }
+        public static XamlDirective Uid { get; }
+        public static XamlDirective UnknownContent { get; }
+        public static XamlType Uri { get; }
+        public static IList<string> XamlNamespaces { get; }
+        public static XamlType XData { get; }
+        public static IList<string> XmlNamespaces { get; }
+    }
+    public class XamlMember : IEquatable<XamlMember> {
+        public XamlMember(EventInfo eventInfo, XamlSchemaContext schemaContext);
+        public XamlMember(EventInfo eventInfo, XamlSchemaContext schemaContext, XamlMemberInvoker invoker);
+        public XamlMember(PropertyInfo propertyInfo, XamlSchemaContext schemaContext);
+        public XamlMember(PropertyInfo propertyInfo, XamlSchemaContext schemaContext, XamlMemberInvoker invoker);
+        public XamlMember(string attachablePropertyName, MethodInfo getter, MethodInfo setter, XamlSchemaContext schemaContext);
+        public XamlMember(string attachablePropertyName, MethodInfo getter, MethodInfo setter, XamlSchemaContext schemaContext, XamlMemberInvoker invoker);
+        public XamlMember(string attachableEventName, MethodInfo adder, XamlSchemaContext schemaContext);
+        public XamlMember(string attachableEventName, MethodInfo adder, XamlSchemaContext schemaContext, XamlMemberInvoker invoker);
+        public XamlMember(string name, XamlType declaringType, bool isAttachable);
+        public XamlType DeclaringType { get; }
+        public XamlValueConverter<XamlDeferringLoader> DeferringLoader { get; }
+        public IList<XamlMember> DependsOn { get; }
+        public XamlMemberInvoker Invoker { get; }
+        public bool IsAmbient { get; }
+        public bool IsAttachable { get; }
+        public bool IsDirective { get; }
+        public bool IsEvent { get; }
+        public bool IsNameValid { get; }
+        public bool IsReadOnly { get; }
+        public bool IsReadPublic { get; }
+        public bool IsUnknown { get; }
+        public bool IsWriteOnly { get; }
+        public bool IsWritePublic { get; }
+        public string Name { get; }
+        public string PreferredXamlNamespace { get; }
+        public DesignerSerializationVisibility SerializationVisibility { get; }
+        public XamlType TargetType { get; }
+        public XamlType Type { get; }
+        public XamlValueConverter<TypeConverter> TypeConverter { get; }
+        public MemberInfo UnderlyingMember { get; }
+        public XamlValueConverter<ValueSerializer> ValueSerializer { get; }
+        public override bool Equals(object obj);
+        public bool Equals(XamlMember other);
+        public override int GetHashCode();
+        public virtual IList<string> GetXamlNamespaces();
+        protected virtual ICustomAttributeProvider LookupCustomAttributeProvider();
+        protected virtual XamlValueConverter<XamlDeferringLoader> LookupDeferringLoader();
+        protected virtual IList<XamlMember> LookupDependsOn();
+        protected virtual XamlMemberInvoker LookupInvoker();
+        protected virtual bool LookupIsAmbient();
+        protected virtual bool LookupIsEvent();
+        protected virtual bool LookupIsReadOnly();
+        protected virtual bool LookupIsReadPublic();
+        protected virtual bool LookupIsUnknown();
+        protected virtual bool LookupIsWriteOnly();
+        protected virtual bool LookupIsWritePublic();
+        protected virtual XamlType LookupTargetType();
+        protected virtual XamlType LookupType();
+        protected virtual XamlValueConverter<TypeConverter> LookupTypeConverter();
+        protected virtual MethodInfo LookupUnderlyingGetter();
+        protected virtual MemberInfo LookupUnderlyingMember();
+        protected virtual MethodInfo LookupUnderlyingSetter();
+        protected virtual XamlValueConverter<ValueSerializer> LookupValueSerializer();
+        public static bool operator ==(XamlMember xamlMember1, XamlMember xamlMember2);
+        public static bool operator !=(XamlMember xamlMember1, XamlMember xamlMember2);
+        public override string ToString();
+    }
+    public class XamlNodeList {
+        public XamlNodeList(XamlSchemaContext schemaContext);
+        public XamlNodeList(XamlSchemaContext schemaContext, int size);
+        public int Count { get; }
+        public XamlWriter Writer { get; }
+        public void Clear();
+        public XamlReader GetReader();
+    }
+    public class XamlNodeQueue {
+        public XamlNodeQueue(XamlSchemaContext schemaContext);
+        public int Count { get; }
+        public bool IsEmpty { get; }
+        public XamlReader Reader { get; }
+        public XamlWriter Writer { get; }
+    }
+    public enum XamlNodeType : byte {
+        EndMember = (byte)5,
+        EndObject = (byte)3,
+        GetObject = (byte)2,
+        NamespaceDeclaration = (byte)7,
+        None = (byte)0,
+        StartMember = (byte)4,
+        StartObject = (byte)1,
+        Value = (byte)6,
+    }
+    public class XamlObjectEventArgs : EventArgs {
+        public XamlObjectEventArgs(object instance);
+        public int ElementLineNumber { get; private set; }
+        public int ElementLinePosition { get; private set; }
+        public object Instance { get; private set; }
+        public Uri SourceBamlUri { get; private set; }
+    }
+    public class XamlObjectReader : XamlReader {
+        public XamlObjectReader(object instance);
+        public XamlObjectReader(object instance, XamlObjectReaderSettings settings);
+        public XamlObjectReader(object instance, XamlSchemaContext schemaContext);
+        public XamlObjectReader(object instance, XamlSchemaContext schemaContext, XamlObjectReaderSettings settings);
+        public virtual object Instance { get; }
+        public override bool IsEof { get; }
+        public override XamlMember Member { get; }
+        public override NamespaceDeclaration Namespace { get; }
+        public override XamlNodeType NodeType { get; }
+        public override XamlSchemaContext SchemaContext { get; }
+        public override XamlType Type { get; }
+        public override object Value { get; }
+        public override bool Read();
+    }
+    public class XamlObjectReaderException : XamlException {
+        public XamlObjectReaderException();
+        protected XamlObjectReaderException(SerializationInfo info, StreamingContext context);
+        public XamlObjectReaderException(string message);
+        public XamlObjectReaderException(string message, Exception innerException);
+    }
+    public class XamlObjectReaderSettings : XamlReaderSettings {
+        public XamlObjectReaderSettings();
+        public bool RequireExplicitContentVisibility { get; set; }
+    }
+    public class XamlObjectWriter : XamlWriter, IXamlLineInfoConsumer {
+        public XamlObjectWriter(XamlSchemaContext schemaContext);
+        public XamlObjectWriter(XamlSchemaContext schemaContext, XamlObjectWriterSettings settings);
+        public virtual object Result { get; }
+        public INameScope RootNameScope { get; }
+        public override XamlSchemaContext SchemaContext { get; }
+        public bool ShouldProvideLineInfo { get; }
+        public void Clear();
+        protected override void Dispose(bool disposing);
+        protected virtual void OnAfterBeginInit(object value);
+        protected virtual void OnAfterEndInit(object value);
+        protected virtual void OnAfterProperties(object value);
+        protected virtual void OnBeforeProperties(object value);
+        protected virtual bool OnSetValue(object eventSender, XamlMember member, object value);
+        public void SetLineInfo(int lineNumber, int linePosition);
+        public override void WriteEndMember();
+        public override void WriteEndObject();
+        public override void WriteGetObject();
+        public override void WriteNamespace(NamespaceDeclaration namespaceDeclaration);
+        public override void WriteStartMember(XamlMember property);
+        public override void WriteStartObject(XamlType xamlType);
+        public override void WriteValue(object value);
+    }
+    public class XamlObjectWriterException : XamlException {
+        public XamlObjectWriterException();
+        protected XamlObjectWriterException(SerializationInfo info, StreamingContext context);
+        public XamlObjectWriterException(string message);
+        public XamlObjectWriterException(string message, Exception innerException);
+    }
+    public class XamlObjectWriterSettings : XamlWriterSettings {
+        public XamlObjectWriterSettings();
+        public XamlObjectWriterSettings(XamlObjectWriterSettings settings);
+        public XamlAccessLevel AccessLevel { get; set; }
+        public EventHandler<XamlObjectEventArgs> AfterBeginInitHandler { get; set; }
+        public EventHandler<XamlObjectEventArgs> AfterEndInitHandler { get; set; }
+        public EventHandler<XamlObjectEventArgs> AfterPropertiesHandler { get; set; }
+        public EventHandler<XamlObjectEventArgs> BeforePropertiesHandler { get; set; }
+        public INameScope ExternalNameScope { get; set; }
+        public bool IgnoreCanConvert { get; set; }
+        public bool PreferUnconvertedDictionaryKeys { get; set; }
+        public bool RegisterNamesOnExternalNamescope { get; set; }
+        public object RootObjectInstance { get; set; }
+        public bool SkipDuplicatePropertyCheck { get; set; }
+        public bool SkipProvideValueOnRoot { get; set; }
+        public Uri SourceBamlUri { get; set; }
+        public EventHandler<XamlSetValueEventArgs> XamlSetValueHandler { get; set; }
+    }
+    public class XamlParseException : XamlException {
+        public XamlParseException();
+        protected XamlParseException(SerializationInfo info, StreamingContext context);
+        public XamlParseException(string message);
+        public XamlParseException(string message, Exception innerException);
+    }
+    public abstract class XamlReader : IDisposable {
+        protected XamlReader();
+        protected bool IsDisposed { get; private set; }
+        public abstract bool IsEof { get; }
+        public abstract XamlMember Member { get; }
+        public abstract NamespaceDeclaration Namespace { get; }
+        public abstract XamlNodeType NodeType { get; }
+        public abstract XamlSchemaContext SchemaContext { get; }
+        public abstract XamlType Type { get; }
+        public abstract object Value { get; }
+        public void Close();
+        protected virtual void Dispose(bool disposing);
+        public abstract bool Read();
+        public virtual XamlReader ReadSubtree();
+        public virtual void Skip();
+        void System.IDisposable.Dispose();
+    }
+    public class XamlReaderSettings {
+        public XamlReaderSettings();
+        public XamlReaderSettings(XamlReaderSettings settings);
+        public bool AllowProtectedMembersOnRoot { get; set; }
+        public Uri BaseUri { get; set; }
+        public bool IgnoreUidsOnPropertyElements { get; set; }
+        public Assembly LocalAssembly { get; set; }
+        public bool ProvideLineInfo { get; set; }
+        public bool ValuesMustBeString { get; set; }
+    }
+    public class XamlSchemaContext {
+        public XamlSchemaContext();
+        public XamlSchemaContext(IEnumerable<Assembly> referenceAssemblies);
+        public XamlSchemaContext(IEnumerable<Assembly> referenceAssemblies, XamlSchemaContextSettings settings);
+        public XamlSchemaContext(XamlSchemaContextSettings settings);
+        public bool FullyQualifyAssemblyNamesInClrNamespaces { get; }
+        public IList<Assembly> ReferenceAssemblies { get; }
+        public bool SupportMarkupExtensionsWithDuplicateArity { get; }
+        ~XamlSchemaContext();
+        public virtual IEnumerable<string> GetAllXamlNamespaces();
+        public virtual ICollection<XamlType> GetAllXamlTypes(string xamlNamespace);
+        public virtual string GetPreferredPrefix(string xmlns);
+        protected internal XamlValueConverter<TConverterBase> GetValueConverter<TConverterBase>(Type converterType, XamlType targetType) where TConverterBase : class;
+        public virtual XamlDirective GetXamlDirective(string xamlNamespace, string name);
+        protected internal virtual XamlType GetXamlType(string xamlNamespace, string name, params XamlType[] typeArguments);
+        public virtual XamlType GetXamlType(Type type);
+        public XamlType GetXamlType(XamlTypeName xamlTypeName);
+        protected internal virtual Assembly OnAssemblyResolve(string assemblyName);
+        public virtual bool TryGetCompatibleXamlNamespace(string xamlNamespace, out string compatibleNamespace);
+    }
+    public class XamlSchemaContextSettings {
+        public XamlSchemaContextSettings();
+        public XamlSchemaContextSettings(XamlSchemaContextSettings settings);
+        public bool FullyQualifyAssemblyNamesInClrNamespaces { get; set; }
+        public bool SupportMarkupExtensionsWithDuplicateArity { get; set; }
+    }
+    public class XamlSchemaException : XamlException {
+        public XamlSchemaException();
+        protected XamlSchemaException(SerializationInfo info, StreamingContext context);
+        public XamlSchemaException(string message);
+        public XamlSchemaException(string message, Exception innerException);
+    }
+    public static class XamlServices {
+        public static object Load(Stream stream);
+        public static object Load(TextReader textReader);
+        public static object Load(string fileName);
+        public static object Load(XamlReader xamlReader);
+        public static object Load(XmlReader xmlReader);
+        public static object Parse(string xaml);
+        public static void Save(Stream stream, object instance);
+        public static void Save(TextWriter writer, object instance);
+        public static string Save(object instance);
+        public static void Save(string fileName, object instance);
+        public static void Save(XamlWriter writer, object instance);
+        public static void Save(XmlWriter writer, object instance);
+        public static void Transform(XamlReader xamlReader, XamlWriter xamlWriter);
+        public static void Transform(XamlReader xamlReader, XamlWriter xamlWriter, bool closeWriter);
+    }
+    public class XamlType : IEquatable<XamlType> {
+        protected XamlType(string typeName, IList<XamlType> typeArguments, XamlSchemaContext schemaContext);
+        public XamlType(string unknownTypeNamespace, string unknownTypeName, IList<XamlType> typeArguments, XamlSchemaContext schemaContext);
+        public XamlType(Type underlyingType, XamlSchemaContext schemaContext);
+        public XamlType(Type underlyingType, XamlSchemaContext schemaContext, XamlTypeInvoker invoker);
+        public IList<XamlType> AllowedContentTypes { get; }
+        public XamlType BaseType { get; }
+        public bool ConstructionRequiresArguments { get; }
+        public XamlMember ContentProperty { get; }
+        public IList<XamlType> ContentWrappers { get; }
+        public XamlValueConverter<XamlDeferringLoader> DeferringLoader { get; }
+        public XamlTypeInvoker Invoker { get; }
+        public bool IsAmbient { get; }
+        public bool IsArray { get; }
+        public bool IsCollection { get; }
+        public bool IsConstructible { get; }
+        public bool IsDictionary { get; }
+        public bool IsGeneric { get; }
+        public bool IsMarkupExtension { get; }
+        public bool IsNameScope { get; }
+        public bool IsNameValid { get; }
+        public bool IsNullable { get; }
+        public bool IsPublic { get; }
+        public bool IsUnknown { get; }
+        public bool IsUsableDuringInitialization { get; }
+        public bool IsWhitespaceSignificantCollection { get; }
+        public bool IsXData { get; }
+        public XamlType ItemType { get; }
+        public XamlType KeyType { get; }
+        public XamlType MarkupExtensionReturnType { get; }
+        public string Name { get; }
+        public string PreferredXamlNamespace { get; }
+        public XamlSchemaContext SchemaContext { get; }
+        public bool TrimSurroundingWhitespace { get; }
+        public IList<XamlType> TypeArguments { get; }
+        public XamlValueConverter<TypeConverter> TypeConverter { get; }
+        public Type UnderlyingType { get; }
+        public XamlValueConverter<ValueSerializer> ValueSerializer { get; }
+        public virtual bool CanAssignTo(XamlType xamlType);
+        public override bool Equals(object obj);
+        public bool Equals(XamlType other);
+        public XamlMember GetAliasedProperty(XamlDirective directive);
+        public ICollection<XamlMember> GetAllAttachableMembers();
+        public ICollection<XamlMember> GetAllMembers();
+        public XamlMember GetAttachableMember(string name);
+        public override int GetHashCode();
+        public XamlMember GetMember(string name);
+        public IList<XamlType> GetPositionalParameters(int parameterCount);
+        public virtual IList<string> GetXamlNamespaces();
+        protected virtual XamlMember LookupAliasedProperty(XamlDirective directive);
+        protected virtual IEnumerable<XamlMember> LookupAllAttachableMembers();
+        protected virtual IEnumerable<XamlMember> LookupAllMembers();
+        protected virtual IList<XamlType> LookupAllowedContentTypes();
+        protected virtual XamlMember LookupAttachableMember(string name);
+        protected virtual XamlType LookupBaseType();
+        protected virtual XamlCollectionKind LookupCollectionKind();
+        protected virtual bool LookupConstructionRequiresArguments();
+        protected virtual XamlMember LookupContentProperty();
+        protected virtual IList<XamlType> LookupContentWrappers();
+        protected virtual ICustomAttributeProvider LookupCustomAttributeProvider();
+        protected virtual XamlValueConverter<XamlDeferringLoader> LookupDeferringLoader();
+        protected virtual XamlTypeInvoker LookupInvoker();
+        protected virtual bool LookupIsAmbient();
+        protected virtual bool LookupIsConstructible();
+        protected virtual bool LookupIsMarkupExtension();
+        protected virtual bool LookupIsNameScope();
+        protected virtual bool LookupIsNullable();
+        protected virtual bool LookupIsPublic();
+        protected virtual bool LookupIsUnknown();
+        protected virtual bool LookupIsWhitespaceSignificantCollection();
+        protected virtual bool LookupIsXData();
+        protected virtual XamlType LookupItemType();
+        protected virtual XamlType LookupKeyType();
+        protected virtual XamlType LookupMarkupExtensionReturnType();
+        protected virtual XamlMember LookupMember(string name, bool skipReadOnlyCheck);
+        protected virtual IList<XamlType> LookupPositionalParameters(int parameterCount);
+        protected virtual EventHandler<XamlSetMarkupExtensionEventArgs> LookupSetMarkupExtensionHandler();
+        protected virtual EventHandler<XamlSetTypeConverterEventArgs> LookupSetTypeConverterHandler();
+        protected virtual bool LookupTrimSurroundingWhitespace();
+        protected virtual XamlValueConverter<TypeConverter> LookupTypeConverter();
+        protected virtual Type LookupUnderlyingType();
+        protected virtual bool LookupUsableDuringInitialization();
+        protected virtual XamlValueConverter<ValueSerializer> LookupValueSerializer();
+        public static bool operator ==(XamlType xamlType1, XamlType xamlType2);
+        public static bool operator !=(XamlType xamlType1, XamlType xamlType2);
+        public override string ToString();
+    }
+    public abstract class XamlWriter : IDisposable {
+        protected XamlWriter();
+        protected bool IsDisposed { get; private set; }
+        public abstract XamlSchemaContext SchemaContext { get; }
+        public void Close();
+        protected virtual void Dispose(bool disposing);
+        void System.IDisposable.Dispose();
+        public abstract void WriteEndMember();
+        public abstract void WriteEndObject();
+        public abstract void WriteGetObject();
+        public abstract void WriteNamespace(NamespaceDeclaration namespaceDeclaration);
+        public void WriteNode(XamlReader reader);
+        public abstract void WriteStartMember(XamlMember xamlMember);
+        public abstract void WriteStartObject(XamlType type);
+        public abstract void WriteValue(object value);
+    }
+    public class XamlWriterSettings {
+        public XamlWriterSettings();
+        public XamlWriterSettings(XamlWriterSettings settings);
+    }
+    public class XamlXmlReader : XamlReader, IXamlLineInfo {
+        public XamlXmlReader(Stream stream);
+        public XamlXmlReader(Stream stream, XamlSchemaContext schemaContext);
+        public XamlXmlReader(Stream stream, XamlSchemaContext schemaContext, XamlXmlReaderSettings settings);
+        public XamlXmlReader(Stream stream, XamlXmlReaderSettings settings);
+        public XamlXmlReader(TextReader textReader);
+        public XamlXmlReader(TextReader textReader, XamlSchemaContext schemaContext);
+        public XamlXmlReader(TextReader textReader, XamlSchemaContext schemaContext, XamlXmlReaderSettings settings);
+        public XamlXmlReader(TextReader textReader, XamlXmlReaderSettings settings);
+        public XamlXmlReader(string fileName);
+        public XamlXmlReader(string fileName, XamlSchemaContext schemaContext);
+        public XamlXmlReader(string fileName, XamlSchemaContext schemaContext, XamlXmlReaderSettings settings);
+        public XamlXmlReader(string fileName, XamlXmlReaderSettings settings);
+        public XamlXmlReader(XmlReader xmlReader);
+        public XamlXmlReader(XmlReader xmlReader, XamlSchemaContext schemaContext);
+        public XamlXmlReader(XmlReader xmlReader, XamlSchemaContext schemaContext, XamlXmlReaderSettings settings);
+        public XamlXmlReader(XmlReader xmlReader, XamlXmlReaderSettings settings);
+        public bool HasLineInfo { get; }
+        public override bool IsEof { get; }
+        public int LineNumber { get; }
+        public int LinePosition { get; }
+        public override XamlMember Member { get; }
+        public override NamespaceDeclaration Namespace { get; }
+        public override XamlNodeType NodeType { get; }
+        public override XamlSchemaContext SchemaContext { get; }
+        public override XamlType Type { get; }
+        public override object Value { get; }
+        public override bool Read();
+    }
+    public class XamlXmlReaderSettings : XamlReaderSettings {
+        public XamlXmlReaderSettings();
+        public XamlXmlReaderSettings(XamlXmlReaderSettings settings);
+        public bool CloseInput { get; set; }
+        public bool SkipXmlCompatibilityProcessing { get; set; }
+        public string XmlLang { get; set; }
+        public bool XmlSpacePreserve { get; set; }
+    }
+    public class XamlXmlWriter : XamlWriter {
+        public XamlXmlWriter(Stream stream, XamlSchemaContext schemaContext);
+        public XamlXmlWriter(Stream stream, XamlSchemaContext schemaContext, XamlXmlWriterSettings settings);
+        public XamlXmlWriter(TextWriter textWriter, XamlSchemaContext schemaContext);
+        public XamlXmlWriter(TextWriter textWriter, XamlSchemaContext schemaContext, XamlXmlWriterSettings settings);
+        public XamlXmlWriter(XmlWriter xmlWriter, XamlSchemaContext schemaContext);
+        public XamlXmlWriter(XmlWriter xmlWriter, XamlSchemaContext schemaContext, XamlXmlWriterSettings settings);
+        public override XamlSchemaContext SchemaContext { get; }
+        public XamlXmlWriterSettings Settings { get; }
+        protected override void Dispose(bool disposing);
+        public void Flush();
+        public override void WriteEndMember();
+        public override void WriteEndObject();
+        public override void WriteGetObject();
+        public override void WriteNamespace(NamespaceDeclaration namespaceDeclaration);
+        public override void WriteStartMember(XamlMember property);
+        public override void WriteStartObject(XamlType type);
+        public override void WriteValue(object value);
+    }
+    public class XamlXmlWriterException : XamlException {
+        public XamlXmlWriterException();
+        protected XamlXmlWriterException(SerializationInfo info, StreamingContext context);
+        public XamlXmlWriterException(string message);
+        public XamlXmlWriterException(string message, Exception innerException);
+    }
+    public class XamlXmlWriterSettings : XamlWriterSettings {
+        public XamlXmlWriterSettings();
+        public bool AssumeValidInput { get; set; }
+        public bool CloseOutput { get; set; }
+        public XamlXmlWriterSettings Copy();
+    }
+}
```

