# System.Windows.Markup

``` diff
+namespace System.Windows.Markup {
+    public class AcceptedMarkupExtensionExpressionTypeAttribute : Attribute {
+        public AcceptedMarkupExtensionExpressionTypeAttribute(Type type);
+        public Type Type { get; set; }
+    }
+    public sealed class AmbientAttribute : Attribute {
+        public AmbientAttribute();
+    }
+    public class ArrayExtension : MarkupExtension {
+        public ArrayExtension();
+        public ArrayExtension(Array elements);
+        public ArrayExtension(Type arrayType);
+        public IList Items { get; }
+        public Type Type { get; set; }
+        public void AddChild(object value);
+        public void AddText(string text);
+        public override object ProvideValue(IServiceProvider serviceProvider);
+    }
+    public class ComponentResourceKeyConverter : ExpressionConverter {
+        public ComponentResourceKeyConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public sealed class ConstructorArgumentAttribute : Attribute {
+        public ConstructorArgumentAttribute(string argumentName);
+        public string ArgumentName { get; }
+    }
+    public sealed class ContentPropertyAttribute : Attribute {
+        public ContentPropertyAttribute();
+        public ContentPropertyAttribute(string name);
+        public string Name { get; }
+    }
+    public sealed class ContentWrapperAttribute : Attribute {
+        public ContentWrapperAttribute(Type contentWrapper);
+        public Type ContentWrapper { get; }
+        public override object TypeId { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+    }
+    public class DateTimeValueSerializer : ValueSerializer {
+        public DateTimeValueSerializer();
+        public override bool CanConvertFromString(string value, IValueSerializerContext context);
+        public override bool CanConvertToString(object value, IValueSerializerContext context);
+        public override object ConvertFromString(string value, IValueSerializerContext context);
+        public override string ConvertToString(object value, IValueSerializerContext context);
+    }
+    public sealed class DependencyPropertyConverter : TypeConverter {
+        public DependencyPropertyConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object source);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public sealed class DependsOnAttribute : Attribute {
+        public DependsOnAttribute(string name);
+        public string Name { get; }
+        public override object TypeId { get; }
+    }
+    public enum DesignerSerializationOptions {
+        SerializeAsAttribute = 1,
+    }
+    public sealed class DesignerSerializationOptionsAttribute : Attribute {
+        public DesignerSerializationOptionsAttribute(DesignerSerializationOptions designerSerializationOptions);
+        public DesignerSerializationOptions DesignerSerializationOptions { get; }
+    }
+    public sealed class DictionaryKeyPropertyAttribute : Attribute {
+        public DictionaryKeyPropertyAttribute(string name);
+        public string Name { get; }
+    }
+    public sealed class EventSetterHandlerConverter : TypeConverter {
+        public EventSetterHandlerConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext typeDescriptorContext, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext typeDescriptorContext, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext typeDescriptorContext, CultureInfo cultureInfo, object source);
+        public override object ConvertTo(ITypeDescriptorContext typeDescriptorContext, CultureInfo cultureInfo, object value, Type destinationType);
+    }
+    public interface IAddChild {
+        void AddChild(object value);
+        void AddText(string text);
+    }
+    public interface IComponentConnector {
+        void Connect(int connectionId, object target);
+        void InitializeComponent();
+    }
+    public interface INameScope {
+        object FindName(string name);
+        void RegisterName(string name, object scopedElement);
+        void UnregisterName(string name);
+    }
+    public interface INameScopeDictionary : ICollection<KeyValuePair<string, object>>, IDictionary<string, object>, IEnumerable, IEnumerable<KeyValuePair<string, object>>, INameScope
+    public abstract class InternalTypeHelper {
+        protected InternalTypeHelper();
+        protected internal abstract void AddEventHandler(EventInfo eventInfo, object target, Delegate handler);
+        protected internal abstract Delegate CreateDelegate(Type delegateType, object target, string handler);
+        protected internal abstract object CreateInstance(Type type, CultureInfo culture);
+        protected internal abstract object GetPropertyValue(PropertyInfo propertyInfo, object target, CultureInfo culture);
+        protected internal abstract void SetPropertyValue(PropertyInfo propertyInfo, object target, object value, CultureInfo culture);
+    }
+    public interface IProvideValueTarget {
+        object TargetObject { get; }
+        object TargetProperty { get; }
+    }
+    public interface IQueryAmbient {
+        bool IsAmbientPropertyAvailable(string propertyName);
+    }
+    public interface IReceiveMarkupExtension {
+        void ReceiveMarkupExtension(string property, MarkupExtension markupExtension, IServiceProvider serviceProvider);
+    }
+    public interface IStyleConnector {
+        void Connect(int connectionId, object target);
+    }
+    public interface IUriContext {
+        Uri BaseUri { get; set; }
+    }
+    public interface IValueSerializerContext : IServiceProvider, ITypeDescriptorContext {
+        ValueSerializer GetValueSerializerFor(PropertyDescriptor descriptor);
+        ValueSerializer GetValueSerializerFor(Type type);
+    }
+    public interface IXamlTypeResolver {
+        Type Resolve(string qualifiedTypeName);
+    }
+    public abstract class MarkupExtension {
+        protected MarkupExtension();
+        public abstract object ProvideValue(IServiceProvider serviceProvider);
+    }
+    public sealed class MarkupExtensionReturnTypeAttribute : Attribute {
+        public MarkupExtensionReturnTypeAttribute();
+        public MarkupExtensionReturnTypeAttribute(Type returnType);
+        public MarkupExtensionReturnTypeAttribute(Type returnType, Type expressionType);
+        public Type ExpressionType { get; }
+        public Type ReturnType { get; }
+    }
+    public abstract class MemberDefinition {
+        protected MemberDefinition();
+        public abstract string Name { get; set; }
+    }
+    public class NameReferenceConverter : TypeConverter {
+        public NameReferenceConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public sealed class NameScopePropertyAttribute : Attribute {
+        public NameScopePropertyAttribute(string name);
+        public NameScopePropertyAttribute(string name, Type type);
+        public string Name { get; }
+        public Type Type { get; }
+    }
+    public class NamespaceMapEntry {
+        public NamespaceMapEntry();
+        public NamespaceMapEntry(string xmlNamespace, string assemblyName, string clrNamespace);
+        public string AssemblyName { get; set; }
+        public string ClrNamespace { get; set; }
+        public string XmlNamespace { get; set; }
+    }
+    public class NullExtension : MarkupExtension {
+        public NullExtension();
+        public override object ProvideValue(IServiceProvider serviceProvider);
+    }
+    public class ParserContext : IUriContext {
+        public ParserContext();
+        public ParserContext(XmlParserContext xmlParserContext);
+        public Uri BaseUri { get; set; }
+        public XamlTypeMapper XamlTypeMapper { get; set; }
+        public string XmlLang { get; set; }
+        public XmlnsDictionary XmlnsDictionary { get; }
+        public string XmlSpace { get; set; }
+        public static implicit operator XmlParserContext (ParserContext parserContext);
+        public static XmlParserContext ToXmlParserContext(ParserContext parserContext);
+    }
+    public class PropertyDefinition : MemberDefinition {
+        public PropertyDefinition();
+        public IList<Attribute> Attributes { get; }
+        public string Modifier { get; set; }
+        public override string Name { get; set; }
+        public XamlType Type { get; set; }
+    }
+    public class Reference : MarkupExtension {
+        public Reference();
+        public Reference(string name);
+        public string Name { get; set; }
+        public override object ProvideValue(IServiceProvider serviceProvider);
+    }
+    public class ResourceReferenceExpressionConverter : ExpressionConverter {
+        public ResourceReferenceExpressionConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public sealed class RootNamespaceAttribute : Attribute {
+        public RootNamespaceAttribute(string nameSpace);
+        public string Namespace { get; }
+    }
+    public sealed class RoutedEventConverter : TypeConverter {
+        public RoutedEventConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext typeDescriptorContext, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext typeDescriptorContext, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext typeDescriptorContext, CultureInfo cultureInfo, object source);
+        public override object ConvertTo(ITypeDescriptorContext typeDescriptorContext, CultureInfo cultureInfo, object value, Type destinationType);
+    }
+    public sealed class RuntimeNamePropertyAttribute : Attribute {
+        public RuntimeNamePropertyAttribute(string name);
+        public string Name { get; }
+    }
+    public class ServiceProviders : IServiceProvider {
+        public ServiceProviders();
+        public void AddService(Type serviceType, object service);
+        public object GetService(Type serviceType);
+    }
+    public sealed class SetterTriggerConditionValueConverter : TypeConverter {
+        public SetterTriggerConditionValueConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object source);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public class StaticExtension : MarkupExtension {
+        public StaticExtension();
+        public StaticExtension(string member);
+        public string Member { get; set; }
+        public Type MemberType { get; set; }
+        public override object ProvideValue(IServiceProvider serviceProvider);
+    }
+    public sealed class TemplateKeyConverter : TypeConverter {
+        public TemplateKeyConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object source);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public sealed class TrimSurroundingWhitespaceAttribute : Attribute {
+        public TrimSurroundingWhitespaceAttribute();
+    }
+    public class TypeExtension : MarkupExtension {
+        public TypeExtension();
+        public TypeExtension(string typeName);
+        public TypeExtension(Type type);
+        public Type Type { get; set; }
+        public string TypeName { get; set; }
+        public override object ProvideValue(IServiceProvider serviceProvider);
+    }
+    public sealed class UidPropertyAttribute : Attribute {
+        public UidPropertyAttribute(string name);
+        public string Name { get; }
+    }
+    public sealed class UsableDuringInitializationAttribute : Attribute {
+        public UsableDuringInitializationAttribute(bool usable);
+        public bool Usable { get; }
+    }
+    public abstract class ValueSerializer {
+        protected ValueSerializer();
+        public virtual bool CanConvertFromString(string value, IValueSerializerContext context);
+        public virtual bool CanConvertToString(object value, IValueSerializerContext context);
+        public virtual object ConvertFromString(string value, IValueSerializerContext context);
+        public virtual string ConvertToString(object value, IValueSerializerContext context);
+        protected Exception GetConvertFromException(object value);
+        protected Exception GetConvertToException(object value, Type destinationType);
+        public static ValueSerializer GetSerializerFor(PropertyDescriptor descriptor);
+        public static ValueSerializer GetSerializerFor(PropertyDescriptor descriptor, IValueSerializerContext context);
+        public static ValueSerializer GetSerializerFor(Type type);
+        public static ValueSerializer GetSerializerFor(Type type, IValueSerializerContext context);
+        public virtual IEnumerable<Type> TypeReferences(object value, IValueSerializerContext context);
+    }
+    public sealed class ValueSerializerAttribute : Attribute {
+        public ValueSerializerAttribute(string valueSerializerTypeName);
+        public ValueSerializerAttribute(Type valueSerializerType);
+        public Type ValueSerializerType { get; }
+        public string ValueSerializerTypeName { get; }
+    }
+    public sealed class WhitespaceSignificantCollectionAttribute : Attribute {
+        public WhitespaceSignificantCollectionAttribute();
+    }
+    public sealed class XamlDeferLoadAttribute : Attribute {
+        public XamlDeferLoadAttribute(string loaderType, string contentType);
+        public XamlDeferLoadAttribute(Type loaderType, Type contentType);
+        public Type ContentType { get; private set; }
+        public string ContentTypeName { get; }
+        public Type LoaderType { get; private set; }
+        public string LoaderTypeName { get; }
+    }
+    public class XamlDesignerSerializationManager : ServiceProviders {
+        public XamlDesignerSerializationManager(XmlWriter xmlWriter);
+        public XamlWriterMode XamlWriterMode { get; set; }
+    }
+    public abstract class XamlInstanceCreator {
+        protected XamlInstanceCreator();
+        public abstract object CreateObject();
+    }
+    public class XamlParseException : SystemException {
+        public XamlParseException();
+        protected XamlParseException(SerializationInfo info, StreamingContext context);
+        public XamlParseException(string message);
+        public XamlParseException(string message, Exception innerException);
+        public XamlParseException(string message, int lineNumber, int linePosition);
+        public XamlParseException(string message, int lineNumber, int linePosition, Exception innerException);
+        public Uri BaseUri { get; internal set; }
+        public object KeyContext { get; internal set; }
+        public int LineNumber { get; internal set; }
+        public int LinePosition { get; internal set; }
+        public string NameContext { get; internal set; }
+        public string UidContext { get; internal set; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class XamlReader {
+        public XamlReader();
+        public event AsyncCompletedEventHandler LoadCompleted;
+        public void CancelAsync();
+        public static XamlSchemaContext GetWpfSchemaContext();
+        public static object Load(Stream stream);
+        public static object Load(Stream stream, ParserContext parserContext);
+        public static object Load(XamlReader reader);
+        public static object Load(XmlReader reader);
+        public object LoadAsync(Stream stream);
+        public object LoadAsync(Stream stream, ParserContext parserContext);
+        public object LoadAsync(XmlReader reader);
+        public static object Parse(string xamlText);
+        public static object Parse(string xamlText, ParserContext parserContext);
+    }
+    public sealed class XamlSetMarkupExtensionAttribute : Attribute {
+        public XamlSetMarkupExtensionAttribute(string xamlSetMarkupExtensionHandler);
+        public string XamlSetMarkupExtensionHandler { get; private set; }
+    }
+    public class XamlSetMarkupExtensionEventArgs : XamlSetValueEventArgs {
+        public XamlSetMarkupExtensionEventArgs(XamlMember member, MarkupExtension value, IServiceProvider serviceProvider);
+        public MarkupExtension MarkupExtension { get; }
+        public IServiceProvider ServiceProvider { get; private set; }
+        public override void CallBase();
+    }
+    public sealed class XamlSetTypeConverterAttribute : Attribute {
+        public XamlSetTypeConverterAttribute(string xamlSetTypeConverterHandler);
+        public string XamlSetTypeConverterHandler { get; private set; }
+    }
+    public class XamlSetTypeConverterEventArgs : XamlSetValueEventArgs {
+        public XamlSetTypeConverterEventArgs(XamlMember member, TypeConverter typeConverter, object value, ITypeDescriptorContext serviceProvider, CultureInfo cultureInfo);
+        public CultureInfo CultureInfo { get; private set; }
+        public ITypeDescriptorContext ServiceProvider { get; private set; }
+        public TypeConverter TypeConverter { get; private set; }
+        public override void CallBase();
+    }
+    public class XamlSetValueEventArgs : EventArgs {
+        public XamlSetValueEventArgs(XamlMember member, object value);
+        public bool Handled { get; set; }
+        public XamlMember Member { get; private set; }
+        public object Value { get; private set; }
+        public virtual void CallBase();
+    }
+    public class XamlTypeMapper {
+        public XamlTypeMapper(string[] assemblyNames);
+        public XamlTypeMapper(string[] assemblyNames, NamespaceMapEntry[] namespaceMaps);
+        public static XamlTypeMapper DefaultMapper { get; }
+        public void AddMappingProcessingInstruction(string xmlNamespace, string clrNamespace, string assemblyName);
+        protected virtual bool AllowInternalType(Type type);
+        public Type GetType(string xmlNamespace, string localName);
+        public void SetAssemblyPath(string assemblyName, string assemblyPath);
+    }
+    public static class XamlWriter {
+        public static string Save(object obj);
+        public static void Save(object obj, Stream stream);
+        public static void Save(object obj, TextWriter writer);
+        public static void Save(object obj, XamlDesignerSerializationManager manager);
+        public static void Save(object obj, XmlWriter xmlWriter);
+    }
+    public enum XamlWriterMode {
+        Expression = 0,
+        Value = 1,
+    }
+    public enum XamlWriterState {
+        Finished = 1,
+        Starting = 0,
+    }
+    public sealed class XData {
+        public XData();
+        public string Text { get; set; }
+        public object XmlReader { get; set; }
+    }
+    public sealed class XmlAttributeProperties {
+        public static readonly DependencyProperty XmlNamespaceMapsProperty;
+        public static readonly DependencyProperty XmlnsDefinitionProperty;
+        public static readonly DependencyProperty XmlnsDictionaryProperty;
+        public static readonly DependencyProperty XmlSpaceProperty;
+        public static string GetXmlNamespaceMaps(DependencyObject dependencyObject);
+        public static string GetXmlnsDefinition(DependencyObject dependencyObject);
+        public static XmlnsDictionary GetXmlnsDictionary(DependencyObject dependencyObject);
+        public static string GetXmlSpace(DependencyObject dependencyObject);
+        public static void SetXmlNamespaceMaps(DependencyObject dependencyObject, string value);
+        public static void SetXmlnsDefinition(DependencyObject dependencyObject, string value);
+        public static void SetXmlnsDictionary(DependencyObject dependencyObject, XmlnsDictionary value);
+        public static void SetXmlSpace(DependencyObject dependencyObject, string value);
+    }
+    public sealed class XmlLangPropertyAttribute : Attribute {
+        public XmlLangPropertyAttribute(string name);
+        public string Name { get; }
+    }
+    public class XmlLanguage {
+        public static XmlLanguage Empty { get; }
+        public string IetfLanguageTag { get; }
+        public CultureInfo GetEquivalentCulture();
+        public static XmlLanguage GetLanguage(string ietfLanguageTag);
+        public CultureInfo GetSpecificCulture();
+        public override string ToString();
+    }
+    public class XmlLanguageConverter : TypeConverter {
+        public XmlLanguageConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext typeDescriptorContext, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext typeDescriptorContext, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext typeDescriptorContext, CultureInfo cultureInfo, object source);
+        public override object ConvertTo(ITypeDescriptorContext typeDescriptorContext, CultureInfo cultureInfo, object value, Type destinationType);
+    }
+    public sealed class XmlnsCompatibleWithAttribute : Attribute {
+        public XmlnsCompatibleWithAttribute(string oldNamespace, string newNamespace);
+        public string NewNamespace { get; }
+        public string OldNamespace { get; }
+    }
+    public sealed class XmlnsDefinitionAttribute : Attribute {
+        public XmlnsDefinitionAttribute(string xmlNamespace, string clrNamespace);
+        public string AssemblyName { get; set; }
+        public string ClrNamespace { get; }
+        public string XmlNamespace { get; }
+    }
+    public class XmlnsDictionary : ICollection, IDictionary, IEnumerable, IXamlNamespaceResolver {
+        public XmlnsDictionary();
+        public XmlnsDictionary(XmlnsDictionary xmlnsDictionary);
+        public int Count { get; }
+        public bool IsFixedSize { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public ICollection Keys { get; }
+        public bool Sealed { get; }
+        public object SyncRoot { get; }
+        public object this[object prefix] { get; set; }
+        public string this[string prefix] { get; set; }
+        public ICollection Values { get; }
+        public void Add(object prefix, object xmlNamespace);
+        public void Add(string prefix, string xmlNamespace);
+        public void Clear();
+        public bool Contains(object key);
+        public void CopyTo(Array array, int index);
+        public void CopyTo(DictionaryEntry[] array, int index);
+        public string DefaultNamespace();
+        protected IDictionaryEnumerator GetDictionaryEnumerator();
+        protected IEnumerator GetEnumerator();
+        public string GetNamespace(string prefix);
+        public IEnumerable<NamespaceDeclaration> GetNamespacePrefixes();
+        public string LookupNamespace(string prefix);
+        public string LookupPrefix(string xmlNamespace);
+        public void PopScope();
+        public void PushScope();
+        public void Remove(object prefix);
+        public void Remove(string prefix);
+        public void Seal();
+        IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+    }
+    public sealed class XmlnsPrefixAttribute : Attribute {
+        public XmlnsPrefixAttribute(string xmlNamespace, string prefix);
+        public string Prefix { get; }
+        public string XmlNamespace { get; }
+    }
+}
```

