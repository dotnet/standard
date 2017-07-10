# System.Web.Services.Description

``` diff
+namespace System.Web.Services.Description {
+    public class BasicProfileViolation {
+        public WsiProfiles Claims { get; }
+        public string Details { get; }
+        public StringCollection Elements { get; }
+        public string NormativeStatement { get; }
+        public string Recommendation { get; }
+        public override string ToString();
+    }
+    public class BasicProfileViolationCollection : CollectionBase, IEnumerable, IEnumerable<BasicProfileViolation> {
+        public BasicProfileViolationCollection();
+        public BasicProfileViolation this[int index] { get; set; }
+        public bool Contains(BasicProfileViolation violation);
+        public void CopyTo(BasicProfileViolation[] array, int index);
+        public int IndexOf(BasicProfileViolation violation);
+        public void Insert(int index, BasicProfileViolation violation);
+        public void Remove(BasicProfileViolation violation);
+        IEnumerator<BasicProfileViolation> System.Collections.Generic.IEnumerable<System.Web.Services.Description.BasicProfileViolation>.GetEnumerator();
+        public override string ToString();
+    }
+    public class BasicProfileViolationEnumerator : IDisposable, IEnumerator, IEnumerator<BasicProfileViolation> {
+        public BasicProfileViolationEnumerator(BasicProfileViolationCollection list);
+        public BasicProfileViolation Current { get; }
+        object System.Collections.IEnumerator.Current { get; }
+        public void Dispose();
+        public bool MoveNext();
+        void System.Collections.IEnumerator.Reset();
+    }
+    public sealed class Binding : NamedItem {
+        public Binding();
+        public override ServiceDescriptionFormatExtensionCollection Extensions { get; }
+        public OperationBindingCollection Operations { get; }
+        public ServiceDescription ServiceDescription { get; }
+        public XmlQualifiedName Type { get; set; }
+    }
+    public sealed class BindingCollection : ServiceDescriptionBaseCollection {
+        public Binding this[int index] { get; set; }
+        public Binding this[string name] { get; }
+        public int Add(Binding binding);
+        public bool Contains(Binding binding);
+        public void CopyTo(Binding[] array, int index);
+        protected override string GetKey(object value);
+        public int IndexOf(Binding binding);
+        public void Insert(int index, Binding binding);
+        public void Remove(Binding binding);
+        protected override void SetParent(object value, object parent);
+    }
+    public abstract class DocumentableItem {
+        protected DocumentableItem();
+        public string Documentation { get; set; }
+        public XmlElement DocumentationElement { get; set; }
+        public XmlAttribute[] ExtensibleAttributes { get; set; }
+        public abstract ServiceDescriptionFormatExtensionCollection Extensions { get; }
+        public XmlSerializerNamespaces Namespaces { get; set; }
+    }
+    public sealed class FaultBinding : MessageBinding {
+        public FaultBinding();
+        public override ServiceDescriptionFormatExtensionCollection Extensions { get; }
+    }
+    public sealed class FaultBindingCollection : ServiceDescriptionBaseCollection {
+        public FaultBinding this[int index] { get; set; }
+        public FaultBinding this[string name] { get; }
+        public int Add(FaultBinding bindingOperationFault);
+        public bool Contains(FaultBinding bindingOperationFault);
+        public void CopyTo(FaultBinding[] array, int index);
+        protected override string GetKey(object value);
+        public int IndexOf(FaultBinding bindingOperationFault);
+        public void Insert(int index, FaultBinding bindingOperationFault);
+        public void Remove(FaultBinding bindingOperationFault);
+        protected override void SetParent(object value, object parent);
+    }
+    public sealed class HttpAddressBinding : ServiceDescriptionFormatExtension {
+        public HttpAddressBinding();
+        public string Location { get; set; }
+    }
+    public sealed class HttpBinding : ServiceDescriptionFormatExtension {
+        public const string Namespace = "http://schemas.xmlsoap.org/wsdl/http/";
+        public HttpBinding();
+        public string Verb { get; set; }
+    }
+    public sealed class HttpOperationBinding : ServiceDescriptionFormatExtension {
+        public HttpOperationBinding();
+        public string Location { get; set; }
+    }
+    public sealed class HttpUrlEncodedBinding : ServiceDescriptionFormatExtension {
+        public HttpUrlEncodedBinding();
+    }
+    public sealed class HttpUrlReplacementBinding : ServiceDescriptionFormatExtension {
+        public HttpUrlReplacementBinding();
+    }
+    public sealed class Import : DocumentableItem {
+        public Import();
+        public override ServiceDescriptionFormatExtensionCollection Extensions { get; }
+        public string Location { get; set; }
+        public string Namespace { get; set; }
+        public ServiceDescription ServiceDescription { get; }
+    }
+    public sealed class ImportCollection : ServiceDescriptionBaseCollection {
+        public Import this[int index] { get; set; }
+        public int Add(Import import);
+        public bool Contains(Import import);
+        public void CopyTo(Import[] array, int index);
+        public int IndexOf(Import import);
+        public void Insert(int index, Import import);
+        public void Remove(Import import);
+        protected override void SetParent(object value, object parent);
+    }
+    public sealed class InputBinding : MessageBinding {
+        public InputBinding();
+        public override ServiceDescriptionFormatExtensionCollection Extensions { get; }
+    }
+    public sealed class Message : NamedItem {
+        public Message();
+        public override ServiceDescriptionFormatExtensionCollection Extensions { get; }
+        public MessagePartCollection Parts { get; }
+        public ServiceDescription ServiceDescription { get; }
+        public MessagePart FindPartByName(string partName);
+        public MessagePart[] FindPartsByName(string[] partNames);
+    }
+    public abstract class MessageBinding : NamedItem {
+        protected MessageBinding();
+        public OperationBinding OperationBinding { get; }
+    }
+    public sealed class MessageCollection : ServiceDescriptionBaseCollection {
+        public Message this[int index] { get; set; }
+        public Message this[string name] { get; }
+        public int Add(Message message);
+        public bool Contains(Message message);
+        public void CopyTo(Message[] array, int index);
+        protected override string GetKey(object value);
+        public int IndexOf(Message message);
+        public void Insert(int index, Message message);
+        public void Remove(Message message);
+        protected override void SetParent(object value, object parent);
+    }
+    public sealed class MessagePart : NamedItem {
+        public MessagePart();
+        public XmlQualifiedName Element { get; set; }
+        public override ServiceDescriptionFormatExtensionCollection Extensions { get; }
+        public Message Message { get; }
+        public XmlQualifiedName Type { get; set; }
+    }
+    public sealed class MessagePartCollection : ServiceDescriptionBaseCollection {
+        public MessagePart this[int index] { get; set; }
+        public MessagePart this[string name] { get; }
+        public int Add(MessagePart messagePart);
+        public bool Contains(MessagePart messagePart);
+        public void CopyTo(MessagePart[] array, int index);
+        protected override string GetKey(object value);
+        public int IndexOf(MessagePart messagePart);
+        public void Insert(int index, MessagePart messagePart);
+        public void Remove(MessagePart messagePart);
+        protected override void SetParent(object value, object parent);
+    }
+    public sealed class MimeContentBinding : ServiceDescriptionFormatExtension {
+        public const string Namespace = "http://schemas.xmlsoap.org/wsdl/mime/";
+        public MimeContentBinding();
+        public string Part { get; set; }
+        public string Type { get; set; }
+    }
+    public sealed class MimeMultipartRelatedBinding : ServiceDescriptionFormatExtension {
+        public MimeMultipartRelatedBinding();
+        public MimePartCollection Parts { get; }
+    }
+    public sealed class MimePart : ServiceDescriptionFormatExtension {
+        public MimePart();
+        public ServiceDescriptionFormatExtensionCollection Extensions { get; }
+    }
+    public sealed class MimePartCollection : CollectionBase {
+        public MimePartCollection();
+        public MimePart this[int index] { get; set; }
+        public int Add(MimePart mimePart);
+        public bool Contains(MimePart mimePart);
+        public void CopyTo(MimePart[] array, int index);
+        public int IndexOf(MimePart mimePart);
+        public void Insert(int index, MimePart mimePart);
+        public void Remove(MimePart mimePart);
+    }
+    public sealed class MimeTextBinding : ServiceDescriptionFormatExtension {
+        public const string Namespace = "http://microsoft.com/wsdl/mime/textMatching/";
+        public MimeTextBinding();
+        public MimeTextMatchCollection Matches { get; }
+    }
+    public sealed class MimeTextMatch {
+        public MimeTextMatch();
+        public int Capture { get; set; }
+        public int Group { get; set; }
+        public bool IgnoreCase { get; set; }
+        public MimeTextMatchCollection Matches { get; }
+        public string Name { get; set; }
+        public string Pattern { get; set; }
+        public int Repeats { get; set; }
+        public string RepeatsString { get; set; }
+        public string Type { get; set; }
+    }
+    public sealed class MimeTextMatchCollection : CollectionBase {
+        public MimeTextMatchCollection();
+        public MimeTextMatch this[int index] { get; set; }
+        public int Add(MimeTextMatch match);
+        public bool Contains(MimeTextMatch match);
+        public void CopyTo(MimeTextMatch[] array, int index);
+        public int IndexOf(MimeTextMatch match);
+        public void Insert(int index, MimeTextMatch match);
+        public void Remove(MimeTextMatch match);
+    }
+    public sealed class MimeXmlBinding : ServiceDescriptionFormatExtension {
+        public MimeXmlBinding();
+        public string Part { get; set; }
+    }
+    public abstract class NamedItem : DocumentableItem {
+        protected NamedItem();
+        public string Name { get; set; }
+    }
+    public sealed class Operation : NamedItem {
+        public Operation();
+        public override ServiceDescriptionFormatExtensionCollection Extensions { get; }
+        public OperationFaultCollection Faults { get; }
+        public OperationMessageCollection Messages { get; }
+        public string[] ParameterOrder { get; set; }
+        public string ParameterOrderString { get; set; }
+        public PortType PortType { get; }
+        public bool IsBoundBy(OperationBinding operationBinding);
+    }
+    public sealed class OperationBinding : NamedItem {
+        public OperationBinding();
+        public Binding Binding { get; }
+        public override ServiceDescriptionFormatExtensionCollection Extensions { get; }
+        public FaultBindingCollection Faults { get; }
+        public InputBinding Input { get; set; }
+        public OutputBinding Output { get; set; }
+    }
+    public sealed class OperationBindingCollection : ServiceDescriptionBaseCollection {
+        public OperationBinding this[int index] { get; set; }
+        public int Add(OperationBinding bindingOperation);
+        public bool Contains(OperationBinding bindingOperation);
+        public void CopyTo(OperationBinding[] array, int index);
+        public int IndexOf(OperationBinding bindingOperation);
+        public void Insert(int index, OperationBinding bindingOperation);
+        public void Remove(OperationBinding bindingOperation);
+        protected override void SetParent(object value, object parent);
+    }
+    public sealed class OperationCollection : ServiceDescriptionBaseCollection {
+        public Operation this[int index] { get; set; }
+        public int Add(Operation operation);
+        public bool Contains(Operation operation);
+        public void CopyTo(Operation[] array, int index);
+        public int IndexOf(Operation operation);
+        public void Insert(int index, Operation operation);
+        public void Remove(Operation operation);
+        protected override void SetParent(object value, object parent);
+    }
+    public sealed class OperationFault : OperationMessage {
+        public OperationFault();
+        public override ServiceDescriptionFormatExtensionCollection Extensions { get; }
+    }
+    public sealed class OperationFaultCollection : ServiceDescriptionBaseCollection {
+        public OperationFault this[int index] { get; set; }
+        public OperationFault this[string name] { get; }
+        public int Add(OperationFault operationFaultMessage);
+        public bool Contains(OperationFault operationFaultMessage);
+        public void CopyTo(OperationFault[] array, int index);
+        protected override string GetKey(object value);
+        public int IndexOf(OperationFault operationFaultMessage);
+        public void Insert(int index, OperationFault operationFaultMessage);
+        public void Remove(OperationFault operationFaultMessage);
+        protected override void SetParent(object value, object parent);
+    }
+    public enum OperationFlow {
+        None = 0,
+        Notification = 2,
+        OneWay = 1,
+        RequestResponse = 3,
+        SolicitResponse = 4,
+    }
+    public sealed class OperationInput : OperationMessage {
+        public OperationInput();
+        public override ServiceDescriptionFormatExtensionCollection Extensions { get; }
+    }
+    public abstract class OperationMessage : NamedItem {
+        protected OperationMessage();
+        public XmlQualifiedName Message { get; set; }
+        public Operation Operation { get; }
+    }
+    public sealed class OperationMessageCollection : ServiceDescriptionBaseCollection {
+        public OperationFlow Flow { get; }
+        public OperationInput Input { get; }
+        public OperationOutput Output { get; }
+        public OperationMessage this[int index] { get; set; }
+        public int Add(OperationMessage operationMessage);
+        public bool Contains(OperationMessage operationMessage);
+        public void CopyTo(OperationMessage[] array, int index);
+        public int IndexOf(OperationMessage operationMessage);
+        public void Insert(int index, OperationMessage operationMessage);
+        protected override void OnInsert(int index, object value);
+        protected override void OnSet(int index, object oldValue, object newValue);
+        protected override void OnValidate(object value);
+        public void Remove(OperationMessage operationMessage);
+        protected override void SetParent(object value, object parent);
+    }
+    public sealed class OperationOutput : OperationMessage {
+        public OperationOutput();
+        public override ServiceDescriptionFormatExtensionCollection Extensions { get; }
+    }
+    public sealed class OutputBinding : MessageBinding {
+        public OutputBinding();
+        public override ServiceDescriptionFormatExtensionCollection Extensions { get; }
+    }
+    public sealed class Port : NamedItem {
+        public Port();
+        public XmlQualifiedName Binding { get; set; }
+        public override ServiceDescriptionFormatExtensionCollection Extensions { get; }
+        public Service Service { get; }
+    }
+    public sealed class PortCollection : ServiceDescriptionBaseCollection {
+        public Port this[int index] { get; set; }
+        public Port this[string name] { get; }
+        public int Add(Port port);
+        public bool Contains(Port port);
+        public void CopyTo(Port[] array, int index);
+        protected override string GetKey(object value);
+        public int IndexOf(Port port);
+        public void Insert(int index, Port port);
+        public void Remove(Port port);
+        protected override void SetParent(object value, object parent);
+    }
+    public sealed class PortType : NamedItem {
+        public PortType();
+        public override ServiceDescriptionFormatExtensionCollection Extensions { get; }
+        public OperationCollection Operations { get; }
+        public ServiceDescription ServiceDescription { get; }
+    }
+    public sealed class PortTypeCollection : ServiceDescriptionBaseCollection {
+        public PortType this[int index] { get; set; }
+        public PortType this[string name] { get; }
+        public int Add(PortType portType);
+        public bool Contains(PortType portType);
+        public void CopyTo(PortType[] array, int index);
+        protected override string GetKey(object value);
+        public int IndexOf(PortType portType);
+        public void Insert(int index, PortType portType);
+        public void Remove(PortType portType);
+        protected override void SetParent(object value, object parent);
+    }
+    public abstract class ProtocolImporter {
+        protected ProtocolImporter();
+        public XmlSchemas AbstractSchemas { get; }
+        public Binding Binding { get; }
+        public string ClassName { get; }
+        public CodeIdentifiers ClassNames { get; }
+        public CodeNamespace CodeNamespace { get; }
+        public CodeTypeDeclaration CodeTypeDeclaration { get; }
+        public XmlSchemas ConcreteSchemas { get; }
+        public Message InputMessage { get; }
+        public string MethodName { get; }
+        public Operation Operation { get; }
+        public OperationBinding OperationBinding { get; }
+        public Message OutputMessage { get; }
+        public Port Port { get; }
+        public PortType PortType { get; }
+        public abstract string ProtocolName { get; }
+        public XmlSchemas Schemas { get; }
+        public Service Service { get; }
+        public ServiceDescriptionCollection ServiceDescriptions { get; }
+        public ServiceDescriptionImportStyle Style { get; }
+        public ServiceDescriptionImportWarnings Warnings { get; set; }
+        public void AddExtensionWarningComments(CodeCommentStatementCollection comments, ServiceDescriptionFormatExtensionCollection extensions);
+        protected abstract CodeTypeDeclaration BeginClass();
+        protected virtual void BeginNamespace();
+        protected virtual void EndClass();
+        protected virtual void EndNamespace();
+        protected abstract CodeMemberMethod GenerateMethod();
+        protected abstract bool IsBindingSupported();
+        protected abstract bool IsOperationFlowSupported(OperationFlow flow);
+        public Exception OperationBindingSyntaxException(string text);
+        public Exception OperationSyntaxException(string text);
+        public void UnsupportedBindingWarning(string text);
+        public void UnsupportedOperationBindingWarning(string text);
+        public void UnsupportedOperationWarning(string text);
+    }
+    public abstract class ProtocolReflector {
+        protected ProtocolReflector();
+        public Binding Binding { get; }
+        public string DefaultNamespace { get; }
+        public MessageCollection HeaderMessages { get; }
+        public Message InputMessage { get; }
+        public LogicalMethodInfo Method { get; }
+        public WebMethodAttribute MethodAttribute { get; }
+        public LogicalMethodInfo[] Methods { get; }
+        public Operation Operation { get; }
+        public OperationBinding OperationBinding { get; }
+        public Message OutputMessage { get; }
+        public Port Port { get; }
+        public PortType PortType { get; }
+        public abstract string ProtocolName { get; }
+        public XmlReflectionImporter ReflectionImporter { get; }
+        public XmlSchemaExporter SchemaExporter { get; }
+        public XmlSchemas Schemas { get; }
+        public Service Service { get; }
+        public ServiceDescription ServiceDescription { get; }
+        public ServiceDescriptionCollection ServiceDescriptions { get; }
+        public Type ServiceType { get; }
+        public string ServiceUrl { get; }
+        protected virtual void BeginClass();
+        protected virtual void EndClass();
+        public ServiceDescription GetServiceDescription(string ns);
+        protected virtual void ReflectDescription();
+        protected abstract bool ReflectMethod();
+        protected virtual string ReflectMethodBinding();
+    }
+    public sealed class Service : NamedItem {
+        public Service();
+        public override ServiceDescriptionFormatExtensionCollection Extensions { get; }
+        public PortCollection Ports { get; }
+        public ServiceDescription ServiceDescription { get; }
+    }
+    public sealed class ServiceCollection : ServiceDescriptionBaseCollection {
+        public Service this[int index] { get; set; }
+        public Service this[string name] { get; }
+        public int Add(Service service);
+        public bool Contains(Service service);
+        public void CopyTo(Service[] array, int index);
+        protected override string GetKey(object value);
+        public int IndexOf(Service service);
+        public void Insert(int index, Service service);
+        public void Remove(Service service);
+        protected override void SetParent(object value, object parent);
+    }
+    public sealed class ServiceDescription : NamedItem {
+        public const string Namespace = "http://schemas.xmlsoap.org/wsdl/";
+        public ServiceDescription();
+        public BindingCollection Bindings { get; }
+        public override ServiceDescriptionFormatExtensionCollection Extensions { get; }
+        public ImportCollection Imports { get; }
+        public MessageCollection Messages { get; }
+        public PortTypeCollection PortTypes { get; }
+        public string RetrievalUrl { get; set; }
+        public static XmlSchema Schema { get; }
+        public static XmlSerializer Serializer { get; }
+        public ServiceDescriptionCollection ServiceDescriptions { get; }
+        public ServiceCollection Services { get; }
+        public string TargetNamespace { get; set; }
+        public Types Types { get; set; }
+        public StringCollection ValidationWarnings { get; }
+        public static bool CanRead(XmlReader reader);
+        public static ServiceDescription Read(Stream stream);
+        public static ServiceDescription Read(Stream stream, bool validate);
+        public static ServiceDescription Read(TextReader textReader);
+        public static ServiceDescription Read(TextReader textReader, bool validate);
+        public static ServiceDescription Read(string fileName);
+        public static ServiceDescription Read(string fileName, bool validate);
+        public static ServiceDescription Read(XmlReader reader);
+        public static ServiceDescription Read(XmlReader reader, bool validate);
+        public void Write(Stream stream);
+        public void Write(TextWriter writer);
+        public void Write(string fileName);
+        public void Write(XmlWriter writer);
+    }
+    public abstract class ServiceDescriptionBaseCollection : CollectionBase {
+        protected virtual IDictionary Table { get; }
+        protected virtual string GetKey(object value);
+        protected override void OnClear();
+        protected override void OnInsertComplete(int index, object value);
+        protected override void OnRemove(int index, object value);
+        protected override void OnSet(int index, object oldValue, object newValue);
+        protected virtual void SetParent(object value, object parent);
+    }
+    public sealed class ServiceDescriptionCollection : ServiceDescriptionBaseCollection {
+        public ServiceDescriptionCollection();
+        public ServiceDescription this[int index] { get; set; }
+        public ServiceDescription this[string ns] { get; }
+        public int Add(ServiceDescription serviceDescription);
+        public bool Contains(ServiceDescription serviceDescription);
+        public void CopyTo(ServiceDescription[] array, int index);
+        public Binding GetBinding(XmlQualifiedName name);
+        protected override string GetKey(object value);
+        public Message GetMessage(XmlQualifiedName name);
+        public PortType GetPortType(XmlQualifiedName name);
+        public Service GetService(XmlQualifiedName name);
+        public int IndexOf(ServiceDescription serviceDescription);
+        public void Insert(int index, ServiceDescription serviceDescription);
+        protected override void OnInsertComplete(int index, object value);
+        public void Remove(ServiceDescription serviceDescription);
+        protected override void SetParent(object value, object parent);
+    }
+    public abstract class ServiceDescriptionFormatExtension {
+        protected ServiceDescriptionFormatExtension();
+        public bool Handled { get; set; }
+        public object Parent { get; }
+        public bool Required { get; set; }
+    }
+    public sealed class ServiceDescriptionFormatExtensionCollection : ServiceDescriptionBaseCollection {
+        public ServiceDescriptionFormatExtensionCollection(object parent);
+        public object this[int index] { get; set; }
+        public int Add(object extension);
+        public bool Contains(object extension);
+        public void CopyTo(object[] array, int index);
+        public XmlElement Find(string name, string ns);
+        public object Find(Type type);
+        public XmlElement[] FindAll(string name, string ns);
+        public object[] FindAll(Type type);
+        public int IndexOf(object extension);
+        public void Insert(int index, object extension);
+        public bool IsHandled(object item);
+        public bool IsRequired(object item);
+        protected override void OnValidate(object value);
+        public void Remove(object extension);
+        protected override void SetParent(object value, object parent);
+    }
+    public class ServiceDescriptionImporter {
+        public ServiceDescriptionImporter();
+        public CodeGenerationOptions CodeGenerationOptions { get; set; }
+        public CodeDomProvider CodeGenerator { get; set; }
+        public string ProtocolName { get; set; }
+        public XmlSchemas Schemas { get; }
+        public ServiceDescriptionCollection ServiceDescriptions { get; }
+        public ServiceDescriptionImportStyle Style { get; set; }
+        public void AddServiceDescription(ServiceDescription serviceDescription, string appSettingUrlKey, string appSettingBaseUrl);
+        public static StringCollection GenerateWebReferences(WebReferenceCollection webReferences, CodeDomProvider codeProvider, CodeCompileUnit codeCompileUnit, WebReferenceOptions options);
+        public ServiceDescriptionImportWarnings Import(CodeNamespace codeNamespace, CodeCompileUnit codeCompileUnit);
+    }
+    public enum ServiceDescriptionImportStyle {
+        Client = 0,
+        Server = 1,
+        ServerInterface = 2,
+    }
+    public enum ServiceDescriptionImportWarnings {
+        NoCodeGenerated = 1,
+        NoMethodsGenerated = 32,
+        OptionalExtensionsIgnored = 2,
+        RequiredExtensionsIgnored = 4,
+        SchemaValidation = 64,
+        UnsupportedBindingsIgnored = 16,
+        UnsupportedOperationsIgnored = 8,
+        WsiConformance = 128,
+    }
+    public class ServiceDescriptionReflector {
+        public ServiceDescriptionReflector();
+        public XmlSchemas Schemas { get; }
+        public ServiceDescriptionCollection ServiceDescriptions { get; }
+        public void Reflect(Type type, string url);
+    }
+    public sealed class Soap12AddressBinding : SoapAddressBinding {
+        public Soap12AddressBinding();
+    }
+    public sealed class Soap12Binding : SoapBinding {
+        public new const string HttpTransport = "http://schemas.xmlsoap.org/soap/http";
+        public new const string Namespace = "http://schemas.xmlsoap.org/wsdl/soap12/";
+        public Soap12Binding();
+    }
+    public sealed class Soap12BodyBinding : SoapBodyBinding {
+        public Soap12BodyBinding();
+    }
+    public sealed class Soap12FaultBinding : SoapFaultBinding {
+        public Soap12FaultBinding();
+    }
+    public sealed class Soap12HeaderBinding : SoapHeaderBinding {
+        public Soap12HeaderBinding();
+    }
+    public sealed class Soap12OperationBinding : SoapOperationBinding {
+        public Soap12OperationBinding();
+        public bool SoapActionRequired { get; set; }
+    }
+    public class SoapAddressBinding : ServiceDescriptionFormatExtension {
+        public SoapAddressBinding();
+        public string Location { get; set; }
+    }
+    public class SoapBinding : ServiceDescriptionFormatExtension {
+        public const string HttpTransport = "http://schemas.xmlsoap.org/soap/http";
+        public const string Namespace = "http://schemas.xmlsoap.org/wsdl/soap/";
+        public SoapBinding();
+        public static XmlSchema Schema { get; }
+        public SoapBindingStyle Style { get; set; }
+        public string Transport { get; set; }
+    }
+    public enum SoapBindingStyle {
+        Default = 0,
+        Document = 1,
+        Rpc = 2,
+    }
+    public enum SoapBindingUse {
+        Default = 0,
+        Encoded = 1,
+        Literal = 2,
+    }
+    public class SoapBodyBinding : ServiceDescriptionFormatExtension {
+        public SoapBodyBinding();
+        public string Encoding { get; set; }
+        public string Namespace { get; set; }
+        public string[] Parts { get; set; }
+        public string PartsString { get; set; }
+        public SoapBindingUse Use { get; set; }
+    }
+    public abstract class SoapExtensionImporter {
+        protected SoapExtensionImporter();
+        public SoapProtocolImporter ImportContext { get; set; }
+        public abstract void ImportMethod(CodeAttributeDeclarationCollection metadata);
+    }
+    public abstract class SoapExtensionReflector {
+        protected SoapExtensionReflector();
+        public ProtocolReflector ReflectionContext { get; set; }
+        public virtual void ReflectDescription();
+        public abstract void ReflectMethod();
+    }
+    public class SoapFaultBinding : ServiceDescriptionFormatExtension {
+        public SoapFaultBinding();
+        public string Encoding { get; set; }
+        public string Name { get; set; }
+        public string Namespace { get; set; }
+        public SoapBindingUse Use { get; set; }
+    }
+    public class SoapHeaderBinding : ServiceDescriptionFormatExtension {
+        public SoapHeaderBinding();
+        public string Encoding { get; set; }
+        public SoapHeaderFaultBinding Fault { get; set; }
+        public bool MapToProperty { get; set; }
+        public XmlQualifiedName Message { get; set; }
+        public string Namespace { get; set; }
+        public string Part { get; set; }
+        public SoapBindingUse Use { get; set; }
+    }
+    public class SoapHeaderFaultBinding : ServiceDescriptionFormatExtension {
+        public SoapHeaderFaultBinding();
+        public string Encoding { get; set; }
+        public XmlQualifiedName Message { get; set; }
+        public string Namespace { get; set; }
+        public string Part { get; set; }
+        public SoapBindingUse Use { get; set; }
+    }
+    public class SoapOperationBinding : ServiceDescriptionFormatExtension {
+        public SoapOperationBinding();
+        public string SoapAction { get; set; }
+        public SoapBindingStyle Style { get; set; }
+    }
+    public class SoapProtocolImporter : ProtocolImporter {
+        public SoapProtocolImporter();
+        public override string ProtocolName { get; }
+        public SoapBinding SoapBinding { get; }
+        public SoapCodeExporter SoapExporter { get; }
+        public SoapSchemaImporter SoapImporter { get; }
+        public XmlCodeExporter XmlExporter { get; }
+        public XmlSchemaImporter XmlImporter { get; }
+        protected override CodeTypeDeclaration BeginClass();
+        protected override void BeginNamespace();
+        protected override void EndClass();
+        protected override void EndNamespace();
+        protected override CodeMemberMethod GenerateMethod();
+        protected override bool IsBindingSupported();
+        protected override bool IsOperationFlowSupported(OperationFlow flow);
+        protected virtual bool IsSoapEncodingPresent(string uriList);
+    }
+    public abstract class SoapTransportImporter {
+        protected SoapTransportImporter();
+        public SoapProtocolImporter ImportContext { get; set; }
+        public abstract void ImportClass();
+        public abstract bool IsSupportedTransport(string transport);
+    }
+    public sealed class Types : DocumentableItem {
+        public Types();
+        public override ServiceDescriptionFormatExtensionCollection Extensions { get; }
+        public XmlSchemas Schemas { get; }
+    }
+    public sealed class WebReference {
+        public WebReference(DiscoveryClientDocumentCollection documents, CodeNamespace proxyCode);
+        public WebReference(DiscoveryClientDocumentCollection documents, CodeNamespace proxyCode, string appSettingUrlKey, string appSettingBaseUrl);
+        public WebReference(DiscoveryClientDocumentCollection documents, CodeNamespace proxyCode, string protocolName, string appSettingUrlKey, string appSettingBaseUrl);
+        public string AppSettingBaseUrl { get; }
+        public string AppSettingUrlKey { get; }
+        public DiscoveryClientDocumentCollection Documents { get; }
+        public string ProtocolName { get; set; }
+        public CodeNamespace ProxyCode { get; }
+        public StringCollection ValidationWarnings { get; }
+        public ServiceDescriptionImportWarnings Warnings { get; set; }
+    }
+    public sealed class WebReferenceCollection : CollectionBase {
+        public WebReferenceCollection();
+        public WebReference this[int index] { get; set; }
+        public int Add(WebReference webReference);
+        public bool Contains(WebReference webReference);
+        public void CopyTo(WebReference[] array, int index);
+        public int IndexOf(WebReference webReference);
+        public void Insert(int index, WebReference webReference);
+        public void Remove(WebReference webReference);
+    }
+    public class WebReferenceOptions {
+        public const string TargetNamespace = "http://microsoft.com/webReference/";
+        public WebReferenceOptions();
+        public CodeGenerationOptions CodeGenerationOptions { get; set; }
+        public static XmlSchema Schema { get; }
+        public StringCollection SchemaImporterExtensions { get; }
+        public ServiceDescriptionImportStyle Style { get; set; }
+        public bool Verbose { get; set; }
+        public static WebReferenceOptions Read(Stream stream, ValidationEventHandler validationEventHandler);
+        public static WebReferenceOptions Read(TextReader reader, ValidationEventHandler validationEventHandler);
+        public static WebReferenceOptions Read(XmlReader xmlReader, ValidationEventHandler validationEventHandler);
+    }
+    public sealed class WebServicesInteroperability {
+        public static bool CheckConformance(WsiProfiles claims, ServiceDescription description, BasicProfileViolationCollection violations);
+        public static bool CheckConformance(WsiProfiles claims, ServiceDescriptionCollection descriptions, BasicProfileViolationCollection violations);
+        public static bool CheckConformance(WsiProfiles claims, WebReference webReference, BasicProfileViolationCollection violations);
+    }
+}
```

