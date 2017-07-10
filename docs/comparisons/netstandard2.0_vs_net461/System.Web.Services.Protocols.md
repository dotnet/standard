# System.Web.Services.Protocols

``` diff
+namespace System.Web.Services.Protocols {
+    public class AnyReturnReader : MimeReturnReader {
+        public AnyReturnReader();
+        public override object GetInitializer(LogicalMethodInfo methodInfo);
+        public override void Initialize(object o);
+        public override object Read(WebResponse response, Stream responseStream);
+    }
+    public class HtmlFormParameterReader : ValueCollectionParameterReader {
+        public HtmlFormParameterReader();
+        public override object[] Read(HttpRequest request);
+    }
+    public class HtmlFormParameterWriter : UrlEncodedParameterWriter {
+        public HtmlFormParameterWriter();
+        public override bool UsesWriteRequest { get; }
+        public override void InitializeRequest(WebRequest request, object[] values);
+        public override void WriteRequest(Stream requestStream, object[] values);
+    }
+    public class HttpGetClientProtocol : HttpSimpleClientProtocol {
+        public HttpGetClientProtocol();
+        protected override WebRequest GetWebRequest(Uri uri);
+    }
+    public sealed class HttpMethodAttribute : Attribute {
+        public HttpMethodAttribute();
+        public HttpMethodAttribute(Type returnFormatter, Type parameterFormatter);
+        public Type ParameterFormatter { get; set; }
+        public Type ReturnFormatter { get; set; }
+    }
+    public class HttpPostClientProtocol : HttpSimpleClientProtocol {
+        public HttpPostClientProtocol();
+        protected override WebRequest GetWebRequest(Uri uri);
+    }
+    public abstract class HttpSimpleClientProtocol : HttpWebClientProtocol {
+        protected HttpSimpleClientProtocol();
+        protected IAsyncResult BeginInvoke(string methodName, string requestUrl, object[] parameters, AsyncCallback callback, object asyncState);
+        protected object EndInvoke(IAsyncResult asyncResult);
+        protected object Invoke(string methodName, string requestUrl, object[] parameters);
+        protected void InvokeAsync(string methodName, string requestUrl, object[] parameters, SendOrPostCallback callback);
+        protected void InvokeAsync(string methodName, string requestUrl, object[] parameters, SendOrPostCallback callback, object userState);
+    }
+    public abstract class HttpWebClientProtocol : WebClientProtocol {
+        protected HttpWebClientProtocol();
+        public bool AllowAutoRedirect { get; set; }
+        public X509CertificateCollection ClientCertificates { get; }
+        public CookieContainer CookieContainer { get; set; }
+        public bool EnableDecompression { get; set; }
+        public IWebProxy Proxy { get; set; }
+        public bool UnsafeAuthenticatedConnectionSharing { get; set; }
+        public string UserAgent { get; set; }
+        protected void CancelAsync(object userState);
+        public static bool GenerateXmlMappings(Type type, ArrayList mappings);
+        public static Hashtable GenerateXmlMappings(Type[] types, ArrayList mappings);
+        protected override WebRequest GetWebRequest(Uri uri);
+        protected override WebResponse GetWebResponse(WebRequest request);
+        protected override WebResponse GetWebResponse(WebRequest request, IAsyncResult result);
+    }
+    public class InvokeCompletedEventArgs : AsyncCompletedEventArgs {
+        public object[] Results { get; }
+    }
+    public delegate void InvokeCompletedEventHandler(object sender, InvokeCompletedEventArgs e);
+    public sealed class LogicalMethodInfo {
+        public LogicalMethodInfo(MethodInfo methodInfo);
+        public ParameterInfo AsyncCallbackParameter { get; }
+        public ParameterInfo AsyncResultParameter { get; }
+        public ParameterInfo AsyncStateParameter { get; }
+        public MethodInfo BeginMethodInfo { get; }
+        public ICustomAttributeProvider CustomAttributeProvider { get; }
+        public Type DeclaringType { get; }
+        public MethodInfo EndMethodInfo { get; }
+        public ParameterInfo[] InParameters { get; }
+        public bool IsAsync { get; }
+        public bool IsVoid { get; }
+        public MethodInfo MethodInfo { get; }
+        public string Name { get; }
+        public ParameterInfo[] OutParameters { get; }
+        public ParameterInfo[] Parameters { get; }
+        public Type ReturnType { get; }
+        public ICustomAttributeProvider ReturnTypeCustomAttributeProvider { get; }
+        public IAsyncResult BeginInvoke(object target, object[] values, AsyncCallback callback, object asyncState);
+        public static LogicalMethodInfo[] Create(MethodInfo[] methodInfos);
+        public static LogicalMethodInfo[] Create(MethodInfo[] methodInfos, LogicalMethodTypes types);
+        public object[] EndInvoke(object target, IAsyncResult asyncResult);
+        public object GetCustomAttribute(Type type);
+        public object[] GetCustomAttributes(Type type);
+        public object[] Invoke(object target, object[] values);
+        public static bool IsBeginMethod(MethodInfo methodInfo);
+        public static bool IsEndMethod(MethodInfo methodInfo);
+        public override string ToString();
+    }
+    public enum LogicalMethodTypes {
+        Async = 2,
+        Sync = 1,
+    }
+    public sealed class MatchAttribute : Attribute {
+        public MatchAttribute(string pattern);
+        public int Capture { get; set; }
+        public int Group { get; set; }
+        public bool IgnoreCase { get; set; }
+        public int MaxRepeats { get; set; }
+        public string Pattern { get; set; }
+    }
+    public abstract class MimeFormatter {
+        protected MimeFormatter();
+        public static MimeFormatter CreateInstance(Type type, object initializer);
+        public static object GetInitializer(Type type, LogicalMethodInfo methodInfo);
+        public abstract object GetInitializer(LogicalMethodInfo methodInfo);
+        public static object[] GetInitializers(Type type, LogicalMethodInfo[] methodInfos);
+        public virtual object[] GetInitializers(LogicalMethodInfo[] methodInfos);
+        public abstract void Initialize(object initializer);
+    }
+    public abstract class MimeParameterReader : MimeFormatter {
+        protected MimeParameterReader();
+        public abstract object[] Read(HttpRequest request);
+    }
+    public abstract class MimeParameterWriter : MimeFormatter {
+        protected MimeParameterWriter();
+        public virtual Encoding RequestEncoding { get; set; }
+        public virtual bool UsesWriteRequest { get; }
+        public virtual string GetRequestUrl(string url, object[] parameters);
+        public virtual void InitializeRequest(WebRequest request, object[] values);
+        public virtual void WriteRequest(Stream requestStream, object[] values);
+    }
+    public abstract class MimeReturnReader : MimeFormatter {
+        protected MimeReturnReader();
+        public abstract object Read(WebResponse response, Stream responseStream);
+    }
+    public class NopReturnReader : MimeReturnReader {
+        public NopReturnReader();
+        public override object GetInitializer(LogicalMethodInfo methodInfo);
+        public override void Initialize(object initializer);
+        public override object Read(WebResponse response, Stream responseStream);
+    }
+    public sealed class PatternMatcher {
+        public PatternMatcher(Type type);
+        public object Match(string text);
+    }
+    public abstract class ServerProtocol {
+        protected ServerProtocol();
+        protected internal HttpContext Context { get; }
+        protected internal HttpRequest Request { get; }
+        protected internal HttpResponse Response { get; }
+        protected internal virtual object Target { get; }
+        protected void AddToCache(Type protocolType, Type serverType, object value);
+        protected object GetFromCache(Type protocolType, Type serverType);
+    }
+    public abstract class ServerProtocolFactory {
+        protected ServerProtocolFactory();
+        protected abstract ServerProtocol CreateIfRequestCompatible(HttpRequest request);
+    }
+    public class ServerType {
+        public ServerType(Type type);
+    }
+    public sealed class Soap12FaultCodes {
+        public static readonly XmlQualifiedName DataEncodingUnknownFaultCode;
+        public static readonly XmlQualifiedName EncodingMissingIdFaultCode;
+        public static readonly XmlQualifiedName EncodingUntypedValueFaultCode;
+        public static readonly XmlQualifiedName MustUnderstandFaultCode;
+        public static readonly XmlQualifiedName ReceiverFaultCode;
+        public static readonly XmlQualifiedName RpcBadArgumentsFaultCode;
+        public static readonly XmlQualifiedName RpcProcedureNotPresentFaultCode;
+        public static readonly XmlQualifiedName SenderFaultCode;
+        public static readonly XmlQualifiedName VersionMismatchFaultCode;
+    }
+    public sealed class SoapClientMessage : SoapMessage {
+        public override string Action { get; }
+        public SoapHttpClientProtocol Client { get; }
+        public override LogicalMethodInfo MethodInfo { get; }
+        public override bool OneWay { get; }
+        public override SoapProtocolVersion SoapVersion { get; }
+        public override string Url { get; }
+        protected override void EnsureInStage();
+        protected override void EnsureOutStage();
+    }
+    public sealed class SoapDocumentMethodAttribute : Attribute {
+        public SoapDocumentMethodAttribute();
+        public SoapDocumentMethodAttribute(string action);
+        public string Action { get; set; }
+        public string Binding { get; set; }
+        public bool OneWay { get; set; }
+        public SoapParameterStyle ParameterStyle { get; set; }
+        public string RequestElementName { get; set; }
+        public string RequestNamespace { get; set; }
+        public string ResponseElementName { get; set; }
+        public string ResponseNamespace { get; set; }
+        public SoapBindingUse Use { get; set; }
+    }
+    public sealed class SoapDocumentServiceAttribute : Attribute {
+        public SoapDocumentServiceAttribute();
+        public SoapDocumentServiceAttribute(SoapBindingUse use);
+        public SoapDocumentServiceAttribute(SoapBindingUse use, SoapParameterStyle paramStyle);
+        public SoapParameterStyle ParameterStyle { get; set; }
+        public SoapServiceRoutingStyle RoutingStyle { get; set; }
+        public SoapBindingUse Use { get; set; }
+    }
+    public class SoapException : SystemException {
+        public static readonly XmlQualifiedName ClientFaultCode;
+        public static readonly XmlQualifiedName DetailElementName;
+        public static readonly XmlQualifiedName MustUnderstandFaultCode;
+        public static readonly XmlQualifiedName ServerFaultCode;
+        public static readonly XmlQualifiedName VersionMismatchFaultCode;
+        public SoapException();
+        protected SoapException(SerializationInfo info, StreamingContext context);
+        public SoapException(string message, XmlQualifiedName code);
+        public SoapException(string message, XmlQualifiedName code, Exception innerException);
+        public SoapException(string message, XmlQualifiedName code, string actor);
+        public SoapException(string message, XmlQualifiedName code, string actor, Exception innerException);
+        public SoapException(string message, XmlQualifiedName code, string actor, string role, string lang, XmlNode detail, SoapFaultSubCode subCode, Exception innerException);
+        public SoapException(string message, XmlQualifiedName code, string actor, string role, XmlNode detail, SoapFaultSubCode subCode, Exception innerException);
+        public SoapException(string message, XmlQualifiedName code, string actor, XmlNode detail);
+        public SoapException(string message, XmlQualifiedName code, string actor, XmlNode detail, Exception innerException);
+        public SoapException(string message, XmlQualifiedName code, SoapFaultSubCode subCode);
+        public string Actor { get; }
+        public XmlQualifiedName Code { get; }
+        public XmlNode Detail { get; }
+        public string Lang { get; }
+        public string Node { get; }
+        public string Role { get; }
+        public SoapFaultSubCode SubCode { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+        public static bool IsClientFaultCode(XmlQualifiedName code);
+        public static bool IsMustUnderstandFaultCode(XmlQualifiedName code);
+        public static bool IsServerFaultCode(XmlQualifiedName code);
+        public static bool IsVersionMismatchFaultCode(XmlQualifiedName code);
+    }
+    public abstract class SoapExtension {
+        protected SoapExtension();
+        public virtual Stream ChainStream(Stream stream);
+        public abstract object GetInitializer(Type serviceType);
+        public abstract object GetInitializer(LogicalMethodInfo methodInfo, SoapExtensionAttribute attribute);
+        public abstract void Initialize(object initializer);
+        public abstract void ProcessMessage(SoapMessage message);
+    }
+    public abstract class SoapExtensionAttribute : Attribute {
+        protected SoapExtensionAttribute();
+        public abstract Type ExtensionType { get; }
+        public abstract int Priority { get; set; }
+    }
+    public class SoapFaultSubCode {
+        public SoapFaultSubCode(XmlQualifiedName code);
+        public SoapFaultSubCode(XmlQualifiedName code, SoapFaultSubCode subCode);
+        public XmlQualifiedName Code { get; }
+        public SoapFaultSubCode SubCode { get; }
+    }
+    public abstract class SoapHeader {
+        protected SoapHeader();
+        public string Actor { get; set; }
+        public bool DidUnderstand { get; set; }
+        public string EncodedMustUnderstand { get; set; }
+        public string EncodedMustUnderstand12 { get; set; }
+        public string EncodedRelay { get; set; }
+        public bool MustUnderstand { get; set; }
+        public bool Relay { get; set; }
+        public string Role { get; set; }
+    }
+    public sealed class SoapHeaderAttribute : Attribute {
+        public SoapHeaderAttribute(string memberName);
+        public SoapHeaderDirection Direction { get; set; }
+        public string MemberName { get; set; }
+        public bool Required { get; set; }
+    }
+    public class SoapHeaderCollection : CollectionBase {
+        public SoapHeaderCollection();
+        public SoapHeader this[int index] { get; set; }
+        public int Add(SoapHeader header);
+        public bool Contains(SoapHeader header);
+        public void CopyTo(SoapHeader[] array, int index);
+        public int IndexOf(SoapHeader header);
+        public void Insert(int index, SoapHeader header);
+        public void Remove(SoapHeader header);
+    }
+    public enum SoapHeaderDirection {
+        Fault = 4,
+        In = 1,
+        InOut = 3,
+        Out = 2,
+    }
+    public class SoapHeaderException : SoapException {
+        public SoapHeaderException();
+        protected SoapHeaderException(SerializationInfo info, StreamingContext context);
+        public SoapHeaderException(string message, XmlQualifiedName code);
+        public SoapHeaderException(string message, XmlQualifiedName code, Exception innerException);
+        public SoapHeaderException(string message, XmlQualifiedName code, string actor);
+        public SoapHeaderException(string message, XmlQualifiedName code, string actor, Exception innerException);
+        public SoapHeaderException(string message, XmlQualifiedName code, string actor, string role, string lang, SoapFaultSubCode subCode, Exception innerException);
+        public SoapHeaderException(string message, XmlQualifiedName code, string actor, string role, SoapFaultSubCode subCode, Exception innerException);
+    }
+    public sealed class SoapHeaderHandling {
+        public SoapHeaderHandling();
+        public static void EnsureHeadersUnderstood(SoapHeaderCollection headers);
+        public static void GetHeaderMembers(SoapHeaderCollection headers, object target, SoapHeaderMapping[] mappings, SoapHeaderDirection direction, bool client);
+        public string ReadHeaders(XmlReader reader, XmlSerializer serializer, SoapHeaderCollection headers, SoapHeaderMapping[] mappings, SoapHeaderDirection direction, string envelopeNS, string encodingStyle, bool checkRequiredHeaders);
+        public static void SetHeaderMembers(SoapHeaderCollection headers, object target, SoapHeaderMapping[] mappings, SoapHeaderDirection direction, bool client);
+        public static void WriteHeaders(XmlWriter writer, XmlSerializer serializer, SoapHeaderCollection headers, SoapHeaderMapping[] mappings, SoapHeaderDirection direction, bool isEncoded, string defaultNS, bool serviceDefaultIsEncoded, string envelopeNS);
+        public static void WriteUnknownHeaders(XmlWriter writer, SoapHeaderCollection headers, string envelopeNS);
+    }
+    public sealed class SoapHeaderMapping {
+        public bool Custom { get; }
+        public SoapHeaderDirection Direction { get; }
+        public Type HeaderType { get; }
+        public MemberInfo MemberInfo { get; }
+        public bool Repeats { get; }
+    }
+    public class SoapHttpClientProtocol : HttpWebClientProtocol {
+        public SoapHttpClientProtocol();
+        public SoapProtocolVersion SoapVersion { get; set; }
+        protected IAsyncResult BeginInvoke(string methodName, object[] parameters, AsyncCallback callback, object asyncState);
+        public void Discover();
+        protected object[] EndInvoke(IAsyncResult asyncResult);
+        protected virtual XmlReader GetReaderForMessage(SoapClientMessage message, int bufferSize);
+        protected override WebRequest GetWebRequest(Uri uri);
+        protected virtual XmlWriter GetWriterForMessage(SoapClientMessage message, int bufferSize);
+        protected object[] Invoke(string methodName, object[] parameters);
+        protected void InvokeAsync(string methodName, object[] parameters, SendOrPostCallback callback);
+        protected void InvokeAsync(string methodName, object[] parameters, SendOrPostCallback callback, object userState);
+    }
+    public abstract class SoapMessage {
+        public abstract string Action { get; }
+        public string ContentEncoding { get; set; }
+        public string ContentType { get; set; }
+        public SoapException Exception { get; set; }
+        public SoapHeaderCollection Headers { get; }
+        public abstract LogicalMethodInfo MethodInfo { get; }
+        public abstract bool OneWay { get; }
+        public virtual SoapProtocolVersion SoapVersion { get; }
+        public SoapMessageStage Stage { get; }
+        public Stream Stream { get; }
+        public abstract string Url { get; }
+        protected abstract void EnsureInStage();
+        protected abstract void EnsureOutStage();
+        protected void EnsureStage(SoapMessageStage stage);
+        public object GetInParameterValue(int index);
+        public object GetOutParameterValue(int index);
+        public object GetReturnValue();
+    }
+    public enum SoapMessageStage {
+        AfterDeserialize = 8,
+        AfterSerialize = 2,
+        BeforeDeserialize = 4,
+        BeforeSerialize = 1,
+    }
+    public enum SoapParameterStyle {
+        Bare = 1,
+        Default = 0,
+        Wrapped = 2,
+    }
+    public enum SoapProtocolVersion {
+        Default = 0,
+        Soap11 = 1,
+        Soap12 = 2,
+    }
+    public sealed class SoapRpcMethodAttribute : Attribute {
+        public SoapRpcMethodAttribute();
+        public SoapRpcMethodAttribute(string action);
+        public string Action { get; set; }
+        public string Binding { get; set; }
+        public bool OneWay { get; set; }
+        public string RequestElementName { get; set; }
+        public string RequestNamespace { get; set; }
+        public string ResponseElementName { get; set; }
+        public string ResponseNamespace { get; set; }
+        public SoapBindingUse Use { get; set; }
+    }
+    public sealed class SoapRpcServiceAttribute : Attribute {
+        public SoapRpcServiceAttribute();
+        public SoapServiceRoutingStyle RoutingStyle { get; set; }
+        public SoapBindingUse Use { get; set; }
+    }
+    public sealed class SoapServerMessage : SoapMessage {
+        public override string Action { get; }
+        public override LogicalMethodInfo MethodInfo { get; }
+        public override bool OneWay { get; }
+        public object Server { get; }
+        public override SoapProtocolVersion SoapVersion { get; }
+        public override string Url { get; }
+        protected override void EnsureInStage();
+        protected override void EnsureOutStage();
+    }
+    public sealed class SoapServerMethod {
+        public SoapServerMethod();
+        public SoapServerMethod(Type serverType, LogicalMethodInfo methodInfo);
+        public string Action { get; }
+        public SoapBindingUse BindingUse { get; }
+        public SoapHeaderMapping[] InHeaderMappings { get; }
+        public XmlSerializer InHeaderSerializer { get; }
+        public LogicalMethodInfo MethodInfo { get; }
+        public bool OneWay { get; }
+        public SoapHeaderMapping[] OutHeaderMappings { get; }
+        public XmlSerializer OutHeaderSerializer { get; }
+        public XmlSerializer ParameterSerializer { get; }
+        public SoapParameterStyle ParameterStyle { get; }
+        public XmlSerializer ReturnSerializer { get; }
+        public bool Rpc { get; }
+        public WsiProfiles WsiClaims { get; }
+    }
+    public class SoapServerProtocol : ServerProtocol {
+        protected internal SoapServerProtocol();
+        protected virtual XmlReader GetReaderForMessage(SoapServerMessage message, int bufferSize);
+        protected virtual XmlWriter GetWriterForMessage(SoapServerMessage message, int bufferSize);
+        protected virtual SoapExtension[] ModifyInitializedExtensions(PriorityGroup group, SoapExtension[] extensions);
+        protected virtual SoapServerMethod RouteRequest(SoapServerMessage message);
+    }
+    public class SoapServerProtocolFactory : ServerProtocolFactory {
+        public SoapServerProtocolFactory();
+        protected override ServerProtocol CreateIfRequestCompatible(HttpRequest request);
+    }
+    public sealed class SoapServerType : ServerType {
+        public SoapServerType(Type type, WebServiceProtocols protocolsSupported);
+        public bool ServiceDefaultIsEncoded { get; }
+        public string ServiceNamespace { get; }
+        public bool ServiceRoutingOnSoapAction { get; }
+        public SoapServerMethod GetDuplicateMethod(object key);
+        public SoapServerMethod GetMethod(object key);
+    }
+    public enum SoapServiceRoutingStyle {
+        RequestElement = 1,
+        SoapAction = 0,
+    }
+    public sealed class SoapUnknownHeader : SoapHeader {
+        public SoapUnknownHeader();
+        public XmlElement Element { get; set; }
+    }
+    public class TextReturnReader : MimeReturnReader {
+        public TextReturnReader();
+        public override object GetInitializer(LogicalMethodInfo methodInfo);
+        public override void Initialize(object o);
+        public override object Read(WebResponse response, Stream responseStream);
+    }
+    public abstract class UrlEncodedParameterWriter : MimeParameterWriter {
+        protected UrlEncodedParameterWriter();
+        public override Encoding RequestEncoding { get; set; }
+        protected void Encode(TextWriter writer, object[] values);
+        protected void Encode(TextWriter writer, string name, object value);
+        public override object GetInitializer(LogicalMethodInfo methodInfo);
+        public override void Initialize(object initializer);
+    }
+    public class UrlParameterReader : ValueCollectionParameterReader {
+        public UrlParameterReader();
+        public override object[] Read(HttpRequest request);
+    }
+    public class UrlParameterWriter : UrlEncodedParameterWriter {
+        public UrlParameterWriter();
+        public override string GetRequestUrl(string url, object[] parameters);
+    }
+    public abstract class ValueCollectionParameterReader : MimeParameterReader {
+        protected ValueCollectionParameterReader();
+        public override object GetInitializer(LogicalMethodInfo methodInfo);
+        public override void Initialize(object o);
+        public static bool IsSupported(ParameterInfo paramInfo);
+        public static bool IsSupported(LogicalMethodInfo methodInfo);
+        protected object[] Read(NameValueCollection collection);
+    }
+    public class WebClientAsyncResult : IAsyncResult {
+        public object AsyncState { get; }
+        public WaitHandle AsyncWaitHandle { get; }
+        public bool CompletedSynchronously { get; }
+        public bool IsCompleted { get; }
+        public void Abort();
+    }
+    public abstract class WebClientProtocol : Component {
+        protected WebClientProtocol();
+        public string ConnectionGroupName { get; set; }
+        public ICredentials Credentials { get; set; }
+        public bool PreAuthenticate { get; set; }
+        public Encoding RequestEncoding { get; set; }
+        public int Timeout { get; set; }
+        public string Url { get; set; }
+        public bool UseDefaultCredentials { get; set; }
+        public virtual void Abort();
+        protected static void AddToCache(Type type, object value);
+        protected static object GetFromCache(Type type);
+        protected virtual WebRequest GetWebRequest(Uri uri);
+        protected virtual WebResponse GetWebResponse(WebRequest request);
+        protected virtual WebResponse GetWebResponse(WebRequest request, IAsyncResult result);
+    }
+    public class WebServiceHandlerFactory : IHttpHandlerFactory {
+        public WebServiceHandlerFactory();
+        public IHttpHandler GetHandler(HttpContext context, string verb, string url, string filePath);
+        public void ReleaseHandler(IHttpHandler handler);
+    }
+    public class XmlReturnReader : MimeReturnReader {
+        public XmlReturnReader();
+        public override object GetInitializer(LogicalMethodInfo methodInfo);
+        public override object[] GetInitializers(LogicalMethodInfo[] methodInfos);
+        public override void Initialize(object o);
+        public override object Read(WebResponse response, Stream responseStream);
+    }
+}
```

