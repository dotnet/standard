# System.ServiceModel.Web

``` diff
+namespace System.ServiceModel.Web {
+    public sealed class AspNetCacheProfileAttribute : Attribute, IOperationBehavior {
+        public AspNetCacheProfileAttribute(string cacheProfileName);
+        public string CacheProfileName { get; }
+        public void AddBindingParameters(OperationDescription operationDescription, BindingParameterCollection bindingParameters);
+        public void ApplyClientBehavior(OperationDescription operationDescription, ClientOperation clientOperation);
+        public void ApplyDispatchBehavior(OperationDescription operationDescription, DispatchOperation dispatchOperation);
+        public void Validate(OperationDescription operationDescription);
+    }
+    public class IncomingWebRequestContext {
+        public string Accept { get; }
+        public long ContentLength { get; }
+        public string ContentType { get; }
+        public WebHeaderCollection Headers { get; }
+        public IEnumerable<string> IfMatch { get; }
+        public Nullable<DateTime> IfModifiedSince { get; }
+        public IEnumerable<string> IfNoneMatch { get; }
+        public Nullable<DateTime> IfUnmodifiedSince { get; }
+        public string Method { get; }
+        public UriTemplateMatch UriTemplateMatch { get; set; }
+        public string UserAgent { get; }
+        public void CheckConditionalRetrieve(DateTime lastModified);
+        public void CheckConditionalRetrieve(Guid entityTag);
+        public void CheckConditionalRetrieve(int entityTag);
+        public void CheckConditionalRetrieve(long entityTag);
+        public void CheckConditionalRetrieve(string entityTag);
+        public void CheckConditionalUpdate(Guid entityTag);
+        public void CheckConditionalUpdate(int entityTag);
+        public void CheckConditionalUpdate(long entityTag);
+        public void CheckConditionalUpdate(string entityTag);
+        public Collection<ContentType> GetAcceptHeaderElements();
+    }
+    public class IncomingWebResponseContext {
+        public long ContentLength { get; }
+        public string ContentType { get; }
+        public string ETag { get; }
+        public WebHeaderCollection Headers { get; }
+        public string Location { get; }
+        public HttpStatusCode StatusCode { get; }
+        public string StatusDescription { get; }
+    }
+    public sealed class JavascriptCallbackBehaviorAttribute : Attribute, IContractBehavior {
+        public JavascriptCallbackBehaviorAttribute();
+        public string UrlParameterName { get; set; }
+        public void AddBindingParameters(ContractDescription contractDescription, ServiceEndpoint endpoint, BindingParameterCollection bindingParameters);
+        public void ApplyClientBehavior(ContractDescription contractDescription, ServiceEndpoint endpoint, ClientRuntime clientRuntime);
+        public void ApplyDispatchBehavior(ContractDescription contractDescription, ServiceEndpoint endpoint, DispatchRuntime dispatchRuntime);
+        public void Validate(ContractDescription contractDescription, ServiceEndpoint endpoint);
+    }
+    public class OutgoingWebRequestContext {
+        public string Accept { get; set; }
+        public long ContentLength { get; set; }
+        public string ContentType { get; set; }
+        public WebHeaderCollection Headers { get; }
+        public string IfMatch { get; set; }
+        public string IfModifiedSince { get; set; }
+        public string IfNoneMatch { get; set; }
+        public string IfUnmodifiedSince { get; set; }
+        public string Method { get; set; }
+        public bool SuppressEntityBody { get; set; }
+        public string UserAgent { get; set; }
+    }
+    public class OutgoingWebResponseContext {
+        public Encoding BindingWriteEncoding { get; }
+        public long ContentLength { get; set; }
+        public string ContentType { get; set; }
+        public string ETag { get; set; }
+        public Nullable<WebMessageFormat> Format { get; set; }
+        public WebHeaderCollection Headers { get; }
+        public DateTime LastModified { get; set; }
+        public string Location { get; set; }
+        public HttpStatusCode StatusCode { get; set; }
+        public string StatusDescription { get; set; }
+        public bool SuppressEntityBody { get; set; }
+        public void SetETag(Guid entityTag);
+        public void SetETag(int entityTag);
+        public void SetETag(long entityTag);
+        public void SetETag(string entityTag);
+        public void SetStatusAsCreated(Uri locationUri);
+        public void SetStatusAsNotFound();
+        public void SetStatusAsNotFound(string description);
+    }
+    public class WebChannelFactory<TChannel> : ChannelFactory<TChannel> where TChannel : class {
+        public WebChannelFactory();
+        public WebChannelFactory(Binding binding);
+        public WebChannelFactory(Binding binding, Uri remoteAddress);
+        public WebChannelFactory(ServiceEndpoint endpoint);
+        public WebChannelFactory(string endpointConfigurationName);
+        public WebChannelFactory(string endpointConfigurationName, Uri remoteAddress);
+        public WebChannelFactory(Type channelType);
+        public WebChannelFactory(Uri remoteAddress);
+        protected override void OnOpening();
+    }
+    public class WebFaultException : FaultException, IWebFaultException {
+        public WebFaultException(HttpStatusCode statusCode);
+        protected WebFaultException(SerializationInfo info, StreamingContext context);
+        public HttpStatusCode StatusCode { get; private set; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class WebFaultException<T> : FaultException<T>, IWebFaultException {
+        protected WebFaultException(SerializationInfo info, StreamingContext context);
+        public WebFaultException(T detail, HttpStatusCode statusCode);
+        public WebFaultException(T detail, HttpStatusCode statusCode, IEnumerable<Type> knownTypes);
+        public HttpStatusCode StatusCode { get; private set; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public sealed class WebGetAttribute : Attribute, IOperationBehavior, IOperationContractAttributeProvider, IWmiInstanceProvider {
+        public WebGetAttribute();
+        public WebMessageBodyStyle BodyStyle { get; set; }
+        public bool IsBodyStyleSetExplicitly { get; }
+        public bool IsRequestFormatSetExplicitly { get; }
+        public bool IsResponseFormatSetExplicitly { get; }
+        public WebMessageFormat RequestFormat { get; set; }
+        public WebMessageFormat ResponseFormat { get; set; }
+        public string UriTemplate { get; set; }
+        void System.ServiceModel.Description.IOperationBehavior.AddBindingParameters(OperationDescription operationDescription, BindingParameterCollection bindingParameters);
+        void System.ServiceModel.Description.IOperationBehavior.ApplyClientBehavior(OperationDescription operationDescription, ClientOperation clientOperation);
+        void System.ServiceModel.Description.IOperationBehavior.ApplyDispatchBehavior(OperationDescription operationDescription, DispatchOperation dispatchOperation);
+        void System.ServiceModel.Description.IOperationBehavior.Validate(OperationDescription operationDescription);
+    }
+    public sealed class WebInvokeAttribute : Attribute, IOperationBehavior, IOperationContractAttributeProvider, IWmiInstanceProvider {
+        public WebInvokeAttribute();
+        public WebMessageBodyStyle BodyStyle { get; set; }
+        public bool IsBodyStyleSetExplicitly { get; }
+        public bool IsRequestFormatSetExplicitly { get; }
+        public bool IsResponseFormatSetExplicitly { get; }
+        public string Method { get; set; }
+        public WebMessageFormat RequestFormat { get; set; }
+        public WebMessageFormat ResponseFormat { get; set; }
+        public string UriTemplate { get; set; }
+        void System.ServiceModel.Description.IOperationBehavior.AddBindingParameters(OperationDescription operationDescription, BindingParameterCollection bindingParameters);
+        void System.ServiceModel.Description.IOperationBehavior.ApplyClientBehavior(OperationDescription operationDescription, ClientOperation clientOperation);
+        void System.ServiceModel.Description.IOperationBehavior.ApplyDispatchBehavior(OperationDescription operationDescription, DispatchOperation dispatchOperation);
+        void System.ServiceModel.Description.IOperationBehavior.Validate(OperationDescription operationDescription);
+    }
+    public enum WebMessageBodyStyle {
+        Bare = 0,
+        Wrapped = 1,
+        WrappedRequest = 2,
+        WrappedResponse = 3,
+    }
+    public enum WebMessageFormat {
+        Json = 1,
+        Xml = 0,
+    }
+    public class WebOperationContext : IExtension<OperationContext> {
+        public WebOperationContext(OperationContext operationContext);
+        public static WebOperationContext Current { get; }
+        public IncomingWebRequestContext IncomingRequest { get; }
+        public IncomingWebResponseContext IncomingResponse { get; }
+        public OutgoingWebRequestContext OutgoingRequest { get; }
+        public OutgoingWebResponseContext OutgoingResponse { get; }
+        public void Attach(OperationContext owner);
+        public Message CreateAtom10Response(ServiceDocument document);
+        public Message CreateAtom10Response(SyndicationFeed feed);
+        public Message CreateAtom10Response(SyndicationItem item);
+        public Message CreateJsonResponse<T>(T instance);
+        public Message CreateJsonResponse<T>(T instance, DataContractJsonSerializer serializer);
+        public Message CreateStreamResponse(Action<Stream> streamWriter, string contentType);
+        public Message CreateStreamResponse(Stream stream, string contentType);
+        public Message CreateStreamResponse(StreamBodyWriter bodyWriter, string contentType);
+        public Message CreateTextResponse(Action<TextWriter> textWriter, string contentType);
+        public Message CreateTextResponse(Action<TextWriter> textWriter, string contentType, Encoding encoding);
+        public Message CreateTextResponse(string text);
+        public Message CreateTextResponse(string text, string contentType);
+        public Message CreateTextResponse(string text, string contentType, Encoding encoding);
+        public Message CreateXmlResponse(XDocument document);
+        public Message CreateXmlResponse(XElement element);
+        public Message CreateXmlResponse<T>(T instance);
+        public Message CreateXmlResponse<T>(T instance, XmlObjectSerializer serializer);
+        public Message CreateXmlResponse<T>(T instance, XmlSerializer serializer);
+        public void Detach(OperationContext owner);
+        public UriTemplate GetUriTemplate(string operationName);
+    }
+    public class WebServiceHost : ServiceHost {
+        public WebServiceHost();
+        public WebServiceHost(object singletonInstance, params Uri[] baseAddresses);
+        public WebServiceHost(Type serviceType, params Uri[] baseAddresses);
+        protected override void OnOpening();
+    }
+}
```

