# System.Net

``` diff
 namespace System.Net {
+    public static class Dns {
+        public static Task<IPAddress[]> GetHostAddressesAsync(string hostNameOrAddress);
+        public static Task<IPHostEntry> GetHostEntryAsync(IPAddress address);
+        public static Task<IPHostEntry> GetHostEntryAsync(string hostNameOrAddress);
+        public static string GetHostName();
+    }
+    public enum HttpRequestHeader {
+        Accept = 20,
+        AcceptCharset = 21,
+        AcceptEncoding = 22,
+        AcceptLanguage = 23,
+        Allow = 10,
+        Authorization = 24,
+        CacheControl = 0,
+        Connection = 1,
+        ContentEncoding = 13,
+        ContentLanguage = 14,
+        ContentLength = 11,
+        ContentLocation = 15,
+        ContentMd5 = 16,
+        ContentRange = 17,
+        ContentType = 12,
+        Cookie = 25,
+        Date = 2,
+        Expect = 26,
+        Expires = 18,
+        From = 27,
+        Host = 28,
+        IfMatch = 29,
+        IfModifiedSince = 30,
+        IfNoneMatch = 31,
+        IfRange = 32,
+        IfUnmodifiedSince = 33,
+        KeepAlive = 3,
+        LastModified = 19,
+        MaxForwards = 34,
+        Pragma = 4,
+        ProxyAuthorization = 35,
+        Range = 37,
+        Referer = 36,
+        Te = 38,
+        Trailer = 5,
+        TransferEncoding = 6,
+        Translate = 39,
+        Upgrade = 7,
+        UserAgent = 40,
+        Via = 8,
+        Warning = 9,
+    }
+    public enum HttpResponseHeader {
+        AcceptRanges = 20,
+        Age = 21,
+        Allow = 10,
+        CacheControl = 0,
+        Connection = 1,
+        ContentEncoding = 13,
+        ContentLanguage = 14,
+        ContentLength = 11,
+        ContentLocation = 15,
+        ContentMd5 = 16,
+        ContentRange = 17,
+        ContentType = 12,
+        Date = 2,
+        ETag = 22,
+        Expires = 18,
+        KeepAlive = 3,
+        LastModified = 19,
+        Location = 23,
+        Pragma = 4,
+        ProxyAuthenticate = 24,
+        RetryAfter = 25,
+        Server = 26,
+        SetCookie = 27,
+        Trailer = 5,
+        TransferEncoding = 6,
+        Upgrade = 7,
+        Vary = 28,
+        Via = 8,
+        Warning = 9,
+        WwwAuthenticate = 29,
+    }
+    public class HttpWebRequest : WebRequest {
+        public string Accept { get; set; }
+        public virtual bool AllowReadStreamBuffering { get; set; }
+        public override string ContentType { get; set; }
+        public int ContinueTimeout { get; set; }
+        public virtual CookieContainer CookieContainer { get; set; }
+        public override ICredentials Credentials { get; set; }
+        public virtual bool HaveResponse { get; }
+        public override WebHeaderCollection Headers { get; set; }
+        public override string Method { get; set; }
+        public override Uri RequestUri { get; }
+        public virtual bool SupportsCookieContainer { get; }
+        public override bool UseDefaultCredentials { get; set; }
+        public override void Abort();
+        public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state);
+        public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state);
+        public override Stream EndGetRequestStream(IAsyncResult asyncResult);
+        public override WebResponse EndGetResponse(IAsyncResult asyncResult);
+    }
+    public class HttpWebResponse : WebResponse {
+        public override long ContentLength { get; }
+        public override string ContentType { get; }
+        public virtual CookieCollection Cookies { get; }
+        public override WebHeaderCollection Headers { get; }
+        public virtual string Method { get; }
+        public override Uri ResponseUri { get; }
+        public virtual HttpStatusCode StatusCode { get; }
+        public virtual string StatusDescription { get; }
+        public override bool SupportsHeaders { get; }
+        protected override void Dispose(bool disposing);
+        public override Stream GetResponseStream();
+    }
+    public class IPHostEntry {
+        public IPHostEntry();
+        public IPAddress[] AddressList { get; set; }
+        public string[] Aliases { get; set; }
+        public string HostName { get; set; }
+    }
+    public interface IWebRequestCreate {
+        WebRequest Create(Uri uri);
+    }
+    public class ProtocolViolationException : InvalidOperationException {
+        public ProtocolViolationException();
+        public ProtocolViolationException(string message);
+    }
+    public class WebException : InvalidOperationException {
+        public WebException();
+        public WebException(string message);
+        public WebException(string message, Exception innerException);
+        public WebException(string message, Exception innerException, WebExceptionStatus status, WebResponse response);
+        public WebException(string message, WebExceptionStatus status);
+        public WebResponse Response { get; }
+        public WebExceptionStatus Status { get; }
+    }
+    public enum WebExceptionStatus {
+        CacheEntryNotFound = 18,
+        ConnectFailure = 2,
+        ConnectionClosed = 8,
+        KeepAliveFailure = 12,
+        MessageLengthLimitExceeded = 17,
+        NameResolutionFailure = 1,
+        Pending = 13,
+        PipelineFailure = 5,
+        ProtocolError = 7,
+        ProxyNameResolutionFailure = 15,
+        ReceiveFailure = 3,
+        RequestCanceled = 6,
+        RequestProhibitedByCachePolicy = 19,
+        RequestProhibitedByProxy = 20,
+        SecureChannelFailure = 10,
+        SendFailure = 4,
+        ServerProtocolViolation = 11,
+        Success = 0,
+        Timeout = 14,
+        TrustFailure = 9,
+        UnknownError = 16,
+    }
+    public sealed class WebHeaderCollection : IEnumerable {
+        public WebHeaderCollection();
+        public string[] AllKeys { get; }
+        public int Count { get; }
+        public string this[HttpRequestHeader header] { get; set; }
+        public string this[HttpResponseHeader header] { get; set; }
+        public string this[string name] { get; set; }
+        public void Remove(string name);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        public override string ToString();
+    }
+    public abstract class WebRequest {
+        protected WebRequest();
+        public abstract string ContentType { get; set; }
+        public virtual ICredentials Credentials { get; set; }
+        public static IWebProxy DefaultWebProxy { get; set; }
+        public abstract WebHeaderCollection Headers { get; set; }
+        public abstract string Method { get; set; }
+        public virtual IWebProxy Proxy { get; set; }
+        public abstract Uri RequestUri { get; }
+        public virtual bool UseDefaultCredentials { get; set; }
+        public abstract void Abort();
+        public abstract IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state);
+        public abstract IAsyncResult BeginGetResponse(AsyncCallback callback, object state);
+        public static WebRequest Create(string requestUriString);
+        public static WebRequest Create(Uri requestUri);
+        public static HttpWebRequest CreateHttp(string requestUriString);
+        public static HttpWebRequest CreateHttp(Uri requestUri);
+        public abstract Stream EndGetRequestStream(IAsyncResult asyncResult);
+        public abstract WebResponse EndGetResponse(IAsyncResult asyncResult);
+        public virtual Task<Stream> GetRequestStreamAsync();
+        public virtual Task<WebResponse> GetResponseAsync();
+        public static bool RegisterPrefix(string prefix, IWebRequestCreate creator);
+    }
+    public abstract class WebResponse : IDisposable {
+        protected WebResponse();
+        public abstract long ContentLength { get; }
+        public abstract string ContentType { get; }
+        public virtual WebHeaderCollection Headers { get; }
+        public abstract Uri ResponseUri { get; }
+        public virtual bool SupportsHeaders { get; }
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        public abstract Stream GetResponseStream();
+    }
 }
```

