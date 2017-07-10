# System.Data.Services.Client

``` diff
+namespace System.Data.Services.Client {
+    public sealed class ChangeOperationResponse : OperationResponse {
+        public Descriptor Descriptor { get; }
+    }
+    public sealed class DataServiceClientException : InvalidOperationException {
+        public DataServiceClientException();
+        protected DataServiceClientException(SerializationInfo serializationInfo, StreamingContext context);
+        public DataServiceClientException(string message);
+        public DataServiceClientException(string message, Exception innerException);
+        public DataServiceClientException(string message, Exception innerException, int statusCode);
+        public DataServiceClientException(string message, int statusCode);
+        public int StatusCode { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class DataServiceCollection<T> : ObservableCollection<T> {
+        public DataServiceCollection();
+        public DataServiceCollection(IEnumerable<T> items);
+        public DataServiceCollection(IEnumerable<T> items, TrackingMode trackingMode);
+        public DataServiceCollection(IEnumerable<T> items, TrackingMode trackingMode, string entitySetName, Func<EntityChangedParams, bool> entityChangedCallback, Func<EntityCollectionChangedParams, bool> collectionChangedCallback);
+        public DataServiceCollection(DataServiceContext context);
+        public DataServiceCollection(DataServiceContext context, IEnumerable<T> items, TrackingMode trackingMode, string entitySetName, Func<EntityChangedParams, bool> entityChangedCallback, Func<EntityCollectionChangedParams, bool> collectionChangedCallback);
+        public DataServiceCollection(DataServiceContext context, string entitySetName, Func<EntityChangedParams, bool> entityChangedCallback, Func<EntityCollectionChangedParams, bool> collectionChangedCallback);
+        public DataServiceQueryContinuation<T> Continuation { get; set; }
+        public void Clear(bool stopTracking);
+        public void Detach();
+        protected override void InsertItem(int index, T item);
+        public void Load(IEnumerable<T> items);
+        public void Load(T item);
+    }
+    public class DataServiceContext {
+        public DataServiceContext(Uri serviceRoot);
+        public bool ApplyingChanges { get; internal set; }
+        public Uri BaseUri { get; }
+        public ICredentials Credentials { get; set; }
+        public string DataNamespace { get; set; }
+        public ReadOnlyCollection<EntityDescriptor> Entities { get; }
+        public bool IgnoreMissingProperties { get; set; }
+        public bool IgnoreResourceNotFoundException { get; set; }
+        public ReadOnlyCollection<LinkDescriptor> Links { get; }
+        public MergeOption MergeOption { get; set; }
+        public Func<Type, string> ResolveName { get; set; }
+        public Func<string, Type> ResolveType { get; set; }
+        public SaveChangesOptions SaveChangesDefaultOptions { get; set; }
+        public int Timeout { get; set; }
+        public Uri TypeScheme { get; set; }
+        public bool UsePostTunneling { get; set; }
+        public event EventHandler<ReadingWritingEntityEventArgs> ReadingEntity;
+        public event EventHandler<SendingRequestEventArgs> SendingRequest;
+        public event EventHandler<ReadingWritingEntityEventArgs> WritingEntity;
+        public void AddLink(object source, string sourceProperty, object target);
+        public void AddObject(string entitySetName, object entity);
+        public void AddRelatedObject(object source, string sourceProperty, object target);
+        public void AttachLink(object source, string sourceProperty, object target);
+        public void AttachTo(string entitySetName, object entity);
+        public void AttachTo(string entitySetName, object entity, string etag);
+        public IAsyncResult BeginExecute<T>(DataServiceQueryContinuation<T> continuation, AsyncCallback callback, object state);
+        public IAsyncResult BeginExecute<TElement>(Uri requestUri, AsyncCallback callback, object state);
+        public IAsyncResult BeginExecuteBatch(AsyncCallback callback, object state, params DataServiceRequest[] queries);
+        public IAsyncResult BeginGetReadStream(object entity, DataServiceRequestArgs args, AsyncCallback callback, object state);
+        public IAsyncResult BeginLoadProperty(object entity, string propertyName, AsyncCallback callback, object state);
+        public IAsyncResult BeginLoadProperty(object entity, string propertyName, DataServiceQueryContinuation continuation, AsyncCallback callback, object state);
+        public IAsyncResult BeginLoadProperty(object entity, string propertyName, Uri nextLinkUri, AsyncCallback callback, object state);
+        public IAsyncResult BeginSaveChanges(AsyncCallback callback, object state);
+        public IAsyncResult BeginSaveChanges(SaveChangesOptions options, AsyncCallback callback, object state);
+        public void CancelRequest(IAsyncResult asyncResult);
+        public DataServiceQuery<T> CreateQuery<T>(string entitySetName);
+        public void DeleteLink(object source, string sourceProperty, object target);
+        public void DeleteObject(object entity);
+        public bool Detach(object entity);
+        public bool DetachLink(object source, string sourceProperty, object target);
+        public IEnumerable<TElement> EndExecute<TElement>(IAsyncResult asyncResult);
+        public DataServiceResponse EndExecuteBatch(IAsyncResult asyncResult);
+        public DataServiceStreamResponse EndGetReadStream(IAsyncResult asyncResult);
+        public QueryOperationResponse EndLoadProperty(IAsyncResult asyncResult);
+        public DataServiceResponse EndSaveChanges(IAsyncResult asyncResult);
+        public QueryOperationResponse<T> Execute<T>(DataServiceQueryContinuation<T> continuation);
+        public IEnumerable<TElement> Execute<TElement>(Uri requestUri);
+        public DataServiceResponse ExecuteBatch(params DataServiceRequest[] queries);
+        public EntityDescriptor GetEntityDescriptor(object entity);
+        public LinkDescriptor GetLinkDescriptor(object source, string sourceProperty, object target);
+        public Uri GetMetadataUri();
+        public DataServiceStreamResponse GetReadStream(object entity);
+        public DataServiceStreamResponse GetReadStream(object entity, DataServiceRequestArgs args);
+        public DataServiceStreamResponse GetReadStream(object entity, string acceptContentType);
+        public Uri GetReadStreamUri(object entity);
+        public QueryOperationResponse LoadProperty(object entity, string propertyName);
+        public QueryOperationResponse LoadProperty(object entity, string propertyName, DataServiceQueryContinuation continuation);
+        public QueryOperationResponse LoadProperty(object entity, string propertyName, Uri nextLinkUri);
+        public QueryOperationResponse<T> LoadProperty<T>(object entity, string propertyName, DataServiceQueryContinuation<T> continuation);
+        public DataServiceResponse SaveChanges();
+        public DataServiceResponse SaveChanges(SaveChangesOptions options);
+        public void SetLink(object source, string sourceProperty, object target);
+        public void SetSaveStream(object entity, Stream stream, bool closeStream, DataServiceRequestArgs args);
+        public void SetSaveStream(object entity, Stream stream, bool closeStream, string contentType, string slug);
+        public bool TryGetEntity<TEntity>(Uri identity, out TEntity entity) where TEntity : class;
+        public bool TryGetUri(object entity, out Uri identity);
+        public void UpdateObject(object entity);
+    }
+    public abstract class DataServiceQuery : DataServiceRequest, IEnumerable, IQueryable {
+        public abstract Expression Expression { get; }
+        public abstract IQueryProvider Provider { get; }
+        public IAsyncResult BeginExecute(AsyncCallback callback, object state);
+        public IEnumerable EndExecute(IAsyncResult asyncResult);
+        public IEnumerable Execute();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+    }
+    public class DataServiceQuery<TElement> : DataServiceQuery, IEnumerable, IEnumerable<TElement>, IQueryable, IQueryable<TElement> {
+        public override Type ElementType { get; }
+        public override Expression Expression { get; }
+        public override IQueryProvider Provider { get; }
+        public override Uri RequestUri { get; }
+        public DataServiceQuery<TElement> AddQueryOption(string name, object value);
+        public new IAsyncResult BeginExecute(AsyncCallback callback, object state);
+        public new IEnumerable<TElement> EndExecute(IAsyncResult asyncResult);
+        public new IEnumerable<TElement> Execute();
+        public DataServiceQuery<TElement> Expand(string path);
+        public IEnumerator<TElement> GetEnumerator();
+        public DataServiceQuery<TElement> IncludeTotalCount();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        public override string ToString();
+    }
+    public abstract class DataServiceQueryContinuation {
+        public Uri NextLinkUri { get; }
+        public override string ToString();
+    }
+    public sealed class DataServiceQueryContinuation<T> : DataServiceQueryContinuation
+    public sealed class DataServiceQueryException : InvalidOperationException {
+        public DataServiceQueryException();
+        protected DataServiceQueryException(SerializationInfo info, StreamingContext context);
+        public DataServiceQueryException(string message);
+        public DataServiceQueryException(string message, Exception innerException);
+        public DataServiceQueryException(string message, Exception innerException, QueryOperationResponse response);
+        public QueryOperationResponse Response { get; }
+    }
+    public abstract class DataServiceRequest {
+        public abstract Type ElementType { get; }
+        public abstract Uri RequestUri { get; }
+        public override string ToString();
+    }
+    public sealed class DataServiceRequest<TElement> : DataServiceRequest {
+        public DataServiceRequest(Uri requestUri);
+        public override Type ElementType { get; }
+        public override Uri RequestUri { get; }
+    }
+    public class DataServiceRequestArgs {
+        public DataServiceRequestArgs();
+        public string AcceptContentType { get; set; }
+        public string ContentType { get; set; }
+        public Dictionary<string, string> Headers { get; }
+        public string Slug { get; set; }
+    }
+    public sealed class DataServiceRequestException : InvalidOperationException {
+        public DataServiceRequestException();
+        protected DataServiceRequestException(SerializationInfo info, StreamingContext context);
+        public DataServiceRequestException(string message);
+        public DataServiceRequestException(string message, Exception innerException);
+        public DataServiceRequestException(string message, Exception innerException, DataServiceResponse response);
+        public DataServiceResponse Response { get; }
+    }
+    public sealed class DataServiceResponse : IEnumerable, IEnumerable<OperationResponse> {
+        public IDictionary<string, string> BatchHeaders { get; }
+        public int BatchStatusCode { get; }
+        public bool IsBatchResponse { get; }
+        public IEnumerator<OperationResponse> GetEnumerator();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+    }
+    public sealed class DataServiceStreamResponse : IDisposable {
+        public string ContentDisposition { get; }
+        public string ContentType { get; }
+        public Dictionary<string, string> Headers { get; }
+        public Stream Stream { get; }
+        public void Dispose();
+    }
+    public abstract class Descriptor {
+        public EntityStates State { get; internal set; }
+    }
+    public sealed class EntityChangedParams {
+        public DataServiceContext Context { get; }
+        public object Entity { get; }
+        public string PropertyName { get; }
+        public object PropertyValue { get; }
+        public string SourceEntitySet { get; }
+        public string TargetEntitySet { get; }
+    }
+    public sealed class EntityCollectionChangedParams {
+        public NotifyCollectionChangedAction Action { get; }
+        public ICollection Collection { get; }
+        public DataServiceContext Context { get; }
+        public string PropertyName { get; }
+        public object SourceEntity { get; }
+        public string SourceEntitySet { get; }
+        public object TargetEntity { get; }
+        public string TargetEntitySet { get; }
+    }
+    public sealed class EntityDescriptor : Descriptor {
+        public Uri EditLink { get; internal set; }
+        public Uri EditStreamUri { get; internal set; }
+        public object Entity { get; }
+        public string ETag { get; internal set; }
+        public string Identity { get; internal set; }
+        public EntityDescriptor ParentForInsert { get; }
+        public string ParentPropertyForInsert { get; }
+        public Uri ReadStreamUri { get; internal set; }
+        public Uri SelfLink { get; internal set; }
+        public string ServerTypeName { get; internal set; }
+        public string StreamETag { get; internal set; }
+    }
+    public enum EntityStates {
+        Added = 4,
+        Deleted = 8,
+        Detached = 1,
+        Modified = 16,
+        Unchanged = 2,
+    }
+    public sealed class LinkDescriptor : Descriptor {
+        public object Source { get; }
+        public string SourceProperty { get; }
+        public object Target { get; }
+    }
+    public sealed class MediaEntryAttribute : Attribute {
+        public MediaEntryAttribute(string mediaMemberName);
+        public string MediaMemberName { get; }
+    }
+    public enum MergeOption {
+        AppendOnly = 0,
+        NoTracking = 3,
+        OverwriteChanges = 1,
+        PreserveChanges = 2,
+    }
+    public sealed class MimeTypePropertyAttribute : Attribute {
+        public MimeTypePropertyAttribute(string dataPropertyName, string mimeTypePropertyName);
+        public string DataPropertyName { get; }
+        public string MimeTypePropertyName { get; }
+    }
+    public abstract class OperationResponse {
+        public Exception Error { get; set; }
+        public IDictionary<string, string> Headers { get; }
+        public int StatusCode { get; internal set; }
+    }
+    public class QueryOperationResponse : OperationResponse, IEnumerable {
+        public DataServiceRequest Query { get; }
+        public virtual long TotalCount { get; }
+        public DataServiceQueryContinuation GetContinuation();
+        public DataServiceQueryContinuation GetContinuation(IEnumerable collection);
+        public DataServiceQueryContinuation<T> GetContinuation<T>(IEnumerable<T> collection);
+        public IEnumerator GetEnumerator();
+    }
+    public sealed class QueryOperationResponse<T> : QueryOperationResponse, IEnumerable, IEnumerable<T> {
+        public override long TotalCount { get; }
+        public new DataServiceQueryContinuation<T> GetContinuation();
+        public new IEnumerator<T> GetEnumerator();
+    }
+    public sealed class ReadingWritingEntityEventArgs : EventArgs {
+        public XElement Data { get; }
+        public object Entity { get; }
+    }
+    public enum SaveChangesOptions {
+        Batch = 1,
+        ContinueOnError = 2,
+        None = 0,
+        ReplaceOnUpdate = 4,
+    }
+    public class SendingRequestEventArgs : EventArgs {
+        public WebRequest Request { get; set; }
+        public WebHeaderCollection RequestHeaders { get; }
+    }
+    public enum TrackingMode {
+        AutoChangeTracking = 1,
+        None = 0,
+    }
+}
```

