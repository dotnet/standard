# System.Data.Services

``` diff
+namespace System.Data.Services {
+    public sealed class ChangeInterceptorAttribute : Attribute {
+        public ChangeInterceptorAttribute(string entitySetName);
+        public string EntitySetName { get; }
+    }
+    public class DataService<T> : IRequestHandler {
+        public DataService();
+        protected T CurrentDataSource { get; }
+        public DataServiceProcessingPipeline ProcessingPipeline { get; }
+        public void AttachHost(IDataServiceHost host);
+        protected virtual T CreateDataSource();
+        protected virtual void HandleException(HandleExceptionArgs args);
+        protected virtual void OnStartProcessingRequest(ProcessRequestArgs args);
+        public void ProcessRequest();
+        public Message ProcessRequestForMessage(Stream messageBody);
+    }
+    public sealed class DataServiceBehavior {
+        public bool AcceptCountRequests { get; set; }
+        public bool AcceptProjectionRequests { get; set; }
+        public bool AcceptReplaceFunctionInQuery { get; set; }
+        public bool InvokeInterceptorsOnLinkDelete { get; set; }
+        public DataServiceProtocolVersion MaxProtocolVersion { get; set; }
+    }
+    public sealed class DataServiceConfiguration : IDataServiceConfiguration {
+        public DataServiceBehavior DataServiceBehavior { get; }
+        public bool EnableTypeConversion { get; set; }
+        public int MaxBatchCount { get; set; }
+        public int MaxChangesetCount { get; set; }
+        public int MaxExpandCount { get; set; }
+        public int MaxExpandDepth { get; set; }
+        public int MaxObjectCountOnInsert { get; set; }
+        public int MaxResultsPerCollection { get; set; }
+        public bool UseVerboseErrors { get; set; }
+        public void EnableTypeAccess(string typeName);
+        public void RegisterKnownType(Type type);
+        public void SetEntitySetAccessRule(string name, EntitySetRights rights);
+        public void SetEntitySetPageSize(string name, int size);
+        public void SetServiceOperationAccessRule(string name, ServiceOperationRights rights);
+    }
+    public sealed class DataServiceException : InvalidOperationException {
+        public DataServiceException();
+        public DataServiceException(int statusCode, string message);
+        public DataServiceException(int statusCode, string errorCode, string message, string messageXmlLang, Exception innerException);
+        protected DataServiceException(SerializationInfo serializationInfo, StreamingContext streamingContext);
+        public DataServiceException(string message);
+        public DataServiceException(string message, Exception innerException);
+        public string ErrorCode { get; }
+        public string MessageLanguage { get; }
+        public int StatusCode { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class DataServiceHost : WebServiceHost {
+        public DataServiceHost(Type serviceType, Uri[] baseAddresses);
+    }
+    public class DataServiceHostFactory : ServiceHostFactory {
+        public DataServiceHostFactory();
+        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses);
+    }
+    public sealed class DataServiceOperationContext {
+        public Uri AbsoluteRequestUri { get; }
+        public Uri AbsoluteServiceUri { get; }
+        public bool IsBatchRequest { get; }
+        public WebHeaderCollection RequestHeaders { get; }
+        public string RequestMethod { get; }
+        public WebHeaderCollection ResponseHeaders { get; }
+        public int ResponseStatusCode { get; set; }
+    }
+    public sealed class DataServiceProcessingPipeline {
+        public DataServiceProcessingPipeline();
+        public event EventHandler<EventArgs> ProcessedChangeset;
+        public event EventHandler<DataServiceProcessingPipelineEventArgs> ProcessedRequest;
+        public event EventHandler<EventArgs> ProcessingChangeset;
+        public event EventHandler<DataServiceProcessingPipelineEventArgs> ProcessingRequest;
+    }
+    public sealed class DataServiceProcessingPipelineEventArgs : EventArgs {
+        public DataServiceOperationContext OperationContext { get; }
+    }
+    public enum EntitySetRights {
+        All = 63,
+        AllRead = 3,
+        AllWrite = 60,
+        None = 0,
+        ReadMultiple = 2,
+        ReadSingle = 1,
+        WriteAppend = 4,
+        WriteDelete = 16,
+        WriteMerge = 32,
+        WriteReplace = 8,
+    }
+    public sealed class ETagAttribute : Attribute {
+        public ETagAttribute(string propertyName);
+        public ETagAttribute(params string[] propertyNames);
+        public ReadOnlyCollection<string> PropertyNames { get; }
+    }
+    public class ExpandSegment {
+        public ExpandSegment(string name, Expression filter);
+        public ResourceProperty ExpandedProperty { get; }
+        public Expression Filter { get; }
+        public bool HasFilter { get; }
+        public int MaxResultsExpected { get; }
+        public string Name { get; }
+        public static bool PathHasFilter(IEnumerable<ExpandSegment> path);
+    }
+    public class ExpandSegmentCollection : List<ExpandSegment> {
+        public ExpandSegmentCollection();
+        public ExpandSegmentCollection(int capacity);
+        public bool HasFilter { get; }
+    }
+    public class HandleExceptionArgs {
+        public Exception Exception { get; set; }
+        public string ResponseContentType { get; }
+        public int ResponseStatusCode { get; }
+        public bool ResponseWritten { get; }
+        public bool UseVerboseErrors { get; set; }
+    }
+    public interface IDataServiceConfiguration {
+        int MaxBatchCount { get; set; }
+        int MaxChangesetCount { get; set; }
+        int MaxExpandCount { get; set; }
+        int MaxExpandDepth { get; set; }
+        int MaxObjectCountOnInsert { get; set; }
+        int MaxResultsPerCollection { get; set; }
+        bool UseVerboseErrors { get; set; }
+        void RegisterKnownType(Type type);
+        void SetEntitySetAccessRule(string name, EntitySetRights rights);
+        void SetServiceOperationAccessRule(string name, ServiceOperationRights rights);
+    }
+    public interface IDataServiceHost {
+        Uri AbsoluteRequestUri { get; }
+        Uri AbsoluteServiceUri { get; }
+        string RequestAccept { get; }
+        string RequestAcceptCharSet { get; }
+        string RequestContentType { get; }
+        string RequestHttpMethod { get; }
+        string RequestIfMatch { get; }
+        string RequestIfNoneMatch { get; }
+        string RequestMaxVersion { get; }
+        Stream RequestStream { get; }
+        string RequestVersion { get; }
+        string ResponseCacheControl { get; set; }
+        string ResponseContentType { get; set; }
+        string ResponseETag { get; set; }
+        string ResponseLocation { get; set; }
+        int ResponseStatusCode { get; set; }
+        Stream ResponseStream { get; }
+        string ResponseVersion { get; set; }
+        string GetQueryStringItem(string item);
+        void ProcessException(HandleExceptionArgs args);
+    }
+    public interface IDataServiceHost2 : IDataServiceHost {
+        WebHeaderCollection RequestHeaders { get; }
+        WebHeaderCollection ResponseHeaders { get; }
+    }
+    public interface IExpandedResult {
+        object ExpandedElement { get; }
+        object GetExpandedPropertyValue(string name);
+    }
+    public interface IExpandProvider {
+        IEnumerable ApplyExpansions(IQueryable queryable, ICollection<ExpandSegmentCollection> expandPaths);
+    }
+    public sealed class IgnorePropertiesAttribute : Attribute {
+        public IgnorePropertiesAttribute(string propertyName);
+        public IgnorePropertiesAttribute(params string[] propertyNames);
+        public ReadOnlyCollection<string> PropertyNames { get; }
+    }
+    public interface IRequestHandler {
+        Message ProcessRequestForMessage(Stream messageBody);
+    }
+    public interface IUpdatable {
+        void AddReferenceToCollection(object targetResource, string propertyName, object resourceToBeAdded);
+        void ClearChanges();
+        object CreateResource(string containerName, string fullTypeName);
+        void DeleteResource(object targetResource);
+        object GetResource(IQueryable query, string fullTypeName);
+        object GetValue(object targetResource, string propertyName);
+        void RemoveReferenceFromCollection(object targetResource, string propertyName, object resourceToBeRemoved);
+        object ResetResource(object resource);
+        object ResolveResource(object resource);
+        void SaveChanges();
+        void SetReference(object targetResource, string propertyName, object propertyValue);
+        void SetValue(object targetResource, string propertyName, object propertyValue);
+    }
+    public sealed class MimeTypeAttribute : Attribute {
+        public MimeTypeAttribute(string memberName, string mimeType);
+        public string MemberName { get; }
+        public string MimeType { get; }
+    }
+    public sealed class ProcessRequestArgs {
+        public bool IsBatchOperation { get; }
+        public DataServiceOperationContext OperationContext { get; private set; }
+        public Uri RequestUri { get; }
+    }
+    public sealed class QueryInterceptorAttribute : Attribute {
+        public QueryInterceptorAttribute(string entitySetName);
+        public string EntitySetName { get; }
+    }
+    public enum ServiceOperationRights {
+        All = 3,
+        AllRead = 3,
+        None = 0,
+        OverrideEntitySetRights = 4,
+        ReadMultiple = 2,
+        ReadSingle = 1,
+    }
+    public sealed class SingleResultAttribute : Attribute {
+        public SingleResultAttribute();
+    }
+    public enum UpdateOperations {
+        Add = 1,
+        Change = 2,
+        Delete = 4,
+        None = 0,
+    }
+}
```

