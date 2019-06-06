// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Net.Http
{
    public partial class ByteArrayContent : System.Net.Http.HttpContent
    {
        public ByteArrayContent(byte[] content) { }
        public ByteArrayContent(byte[] content, int offset, int count) { }
        protected override System.Threading.Tasks.Task<System.IO.Stream> CreateContentReadStreamAsync() { throw null; }
        protected override System.Threading.Tasks.Task SerializeToStreamAsync(System.IO.Stream stream, System.Net.TransportContext context) { throw null; }
        protected internal override bool TryComputeLength(out long length) { throw null; }
    }
    public enum ClientCertificateOption
    {
        Automatic = 1,
        Manual = 0,
    }
    public abstract partial class DelegatingHandler : System.Net.Http.HttpMessageHandler
    {
        protected DelegatingHandler() { }
        protected DelegatingHandler(System.Net.Http.HttpMessageHandler innerHandler) { }
        public System.Net.Http.HttpMessageHandler InnerHandler { get { throw null; } set { } }
        protected override void Dispose(bool disposing) { }
        protected internal override System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public partial class FormUrlEncodedContent : System.Net.Http.ByteArrayContent
    {
        public FormUrlEncodedContent(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> nameValueCollection) : base (default(byte[])) { }
    }
    public partial class HttpClient : System.Net.Http.HttpMessageInvoker
    {
        public HttpClient() : base (default(System.Net.Http.HttpMessageHandler)) { }
        public HttpClient(System.Net.Http.HttpMessageHandler handler) : base (default(System.Net.Http.HttpMessageHandler)) { }
        public HttpClient(System.Net.Http.HttpMessageHandler handler, bool disposeHandler) : base (default(System.Net.Http.HttpMessageHandler)) { }
        public System.Uri BaseAddress { get { throw null; } set { } }
        public System.Net.Http.Headers.HttpRequestHeaders DefaultRequestHeaders { get { throw null; } }
        public long MaxResponseContentBufferSize { get { throw null; } set { } }
        public System.TimeSpan Timeout { get { throw null; } set { } }
        public void CancelPendingRequests() { }
        public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> DeleteAsync(string requestUri) { throw null; }
        public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> DeleteAsync(string requestUri, System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> DeleteAsync(System.Uri requestUri) { throw null; }
        public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> DeleteAsync(System.Uri requestUri, System.Threading.CancellationToken cancellationToken) { throw null; }
        protected override void Dispose(bool disposing) { }
        public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> GetAsync(string requestUri) { throw null; }
        public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> GetAsync(string requestUri, System.Net.Http.HttpCompletionOption completionOption) { throw null; }
        public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> GetAsync(string requestUri, System.Net.Http.HttpCompletionOption completionOption, System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> GetAsync(string requestUri, System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> GetAsync(System.Uri requestUri) { throw null; }
        public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> GetAsync(System.Uri requestUri, System.Net.Http.HttpCompletionOption completionOption) { throw null; }
        public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> GetAsync(System.Uri requestUri, System.Net.Http.HttpCompletionOption completionOption, System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> GetAsync(System.Uri requestUri, System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task<byte[]> GetByteArrayAsync(string requestUri) { throw null; }
        public System.Threading.Tasks.Task<byte[]> GetByteArrayAsync(System.Uri requestUri) { throw null; }
        public System.Threading.Tasks.Task<System.IO.Stream> GetStreamAsync(string requestUri) { throw null; }
        public System.Threading.Tasks.Task<System.IO.Stream> GetStreamAsync(System.Uri requestUri) { throw null; }
        public System.Threading.Tasks.Task<string> GetStringAsync(string requestUri) { throw null; }
        public System.Threading.Tasks.Task<string> GetStringAsync(System.Uri requestUri) { throw null; }
        public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PatchAsync(string requestUri, System.Net.Http.HttpContent content) { throw null; }
        public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PatchAsync(string requestUri, System.Net.Http.HttpContent content, System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PatchAsync(System.Uri requestUri, System.Net.Http.HttpContent content) { throw null; }
        public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PatchAsync(System.Uri requestUri, System.Net.Http.HttpContent content, System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PostAsync(string requestUri, System.Net.Http.HttpContent content) { throw null; }
        public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PostAsync(string requestUri, System.Net.Http.HttpContent content, System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PostAsync(System.Uri requestUri, System.Net.Http.HttpContent content) { throw null; }
        public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PostAsync(System.Uri requestUri, System.Net.Http.HttpContent content, System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PutAsync(string requestUri, System.Net.Http.HttpContent content) { throw null; }
        public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PutAsync(string requestUri, System.Net.Http.HttpContent content, System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PutAsync(System.Uri requestUri, System.Net.Http.HttpContent content) { throw null; }
        public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PutAsync(System.Uri requestUri, System.Net.Http.HttpContent content, System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request) { throw null; }
        public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Net.Http.HttpCompletionOption completionOption) { throw null; }
        public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Net.Http.HttpCompletionOption completionOption, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public partial class HttpClientHandler : System.Net.Http.HttpMessageHandler
    {
        public HttpClientHandler() { }
        public bool AllowAutoRedirect { get { throw null; } set { } }
        public System.Net.DecompressionMethods AutomaticDecompression { get { throw null; } set { } }
        public bool CheckCertificateRevocationList { get { throw null; } set { } }
        public System.Net.Http.ClientCertificateOption ClientCertificateOptions { get { throw null; } set { } }
        public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get { throw null; } }
        public System.Net.CookieContainer CookieContainer { get { throw null; } set { } }
        public System.Net.ICredentials Credentials { get { throw null; } set { } }
        public static System.Func<System.Net.Http.HttpRequestMessage, System.Security.Cryptography.X509Certificates.X509Certificate2, System.Security.Cryptography.X509Certificates.X509Chain, System.Net.Security.SslPolicyErrors, bool> DangerousAcceptAnyServerCertificateValidator { get { throw null; } }
        public System.Net.ICredentials DefaultProxyCredentials { get { throw null; } set { } }
        public int MaxAutomaticRedirections { get { throw null; } set { } }
        public int MaxConnectionsPerServer { get { throw null; } set { } }
        public long MaxRequestContentBufferSize { get { throw null; } set { } }
        public int MaxResponseHeadersLength { get { throw null; } set { } }
        public bool PreAuthenticate { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, object> Properties { get { throw null; } }
        public System.Net.IWebProxy Proxy { get { throw null; } set { } }
        public System.Func<System.Net.Http.HttpRequestMessage, System.Security.Cryptography.X509Certificates.X509Certificate2, System.Security.Cryptography.X509Certificates.X509Chain, System.Net.Security.SslPolicyErrors, bool> ServerCertificateCustomValidationCallback { get { throw null; } set { } }
        public System.Security.Authentication.SslProtocols SslProtocols { get { throw null; } set { } }
        public virtual bool SupportsAutomaticDecompression { get { throw null; } }
        public virtual bool SupportsProxy { get { throw null; } }
        public virtual bool SupportsRedirectConfiguration { get { throw null; } }
        public bool UseCookies { get { throw null; } set { } }
        public bool UseDefaultCredentials { get { throw null; } set { } }
        public bool UseProxy { get { throw null; } set { } }
        protected override void Dispose(bool disposing) { }
        protected internal override System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public enum HttpCompletionOption
    {
        ResponseContentRead = 0,
        ResponseHeadersRead = 1,
    }
    public abstract partial class HttpContent : System.IDisposable
    {
        protected HttpContent() { }
        public System.Net.Http.Headers.HttpContentHeaders Headers { get { throw null; } }
        public System.Threading.Tasks.Task CopyToAsync(System.IO.Stream stream) { throw null; }
        public System.Threading.Tasks.Task CopyToAsync(System.IO.Stream stream, System.Net.TransportContext context) { throw null; }
        protected virtual System.Threading.Tasks.Task<System.IO.Stream> CreateContentReadStreamAsync() { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public System.Threading.Tasks.Task LoadIntoBufferAsync() { throw null; }
        public System.Threading.Tasks.Task LoadIntoBufferAsync(long maxBufferSize) { throw null; }
        public System.Threading.Tasks.Task<byte[]> ReadAsByteArrayAsync() { throw null; }
        public System.Threading.Tasks.Task<System.IO.Stream> ReadAsStreamAsync() { throw null; }
        public System.Threading.Tasks.Task<string> ReadAsStringAsync() { throw null; }
        protected abstract System.Threading.Tasks.Task SerializeToStreamAsync(System.IO.Stream stream, System.Net.TransportContext context);
        protected internal abstract bool TryComputeLength(out long length);
    }
    public abstract partial class HttpMessageHandler : System.IDisposable
    {
        protected HttpMessageHandler() { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        protected internal abstract System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken);
    }
    public partial class HttpMessageInvoker : System.IDisposable
    {
        public HttpMessageInvoker(System.Net.Http.HttpMessageHandler handler) { }
        public HttpMessageInvoker(System.Net.Http.HttpMessageHandler handler, bool disposeHandler) { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public virtual System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public partial class HttpMethod : System.IEquatable<System.Net.Http.HttpMethod>
    {
        public HttpMethod(string method) { }
        public static System.Net.Http.HttpMethod Delete { get { throw null; } }
        public static System.Net.Http.HttpMethod Get { get { throw null; } }
        public static System.Net.Http.HttpMethod Head { get { throw null; } }
        public string Method { get { throw null; } }
        public static System.Net.Http.HttpMethod Options { get { throw null; } }
        public static System.Net.Http.HttpMethod Patch { get { throw null; } }
        public static System.Net.Http.HttpMethod Post { get { throw null; } }
        public static System.Net.Http.HttpMethod Put { get { throw null; } }
        public static System.Net.Http.HttpMethod Trace { get { throw null; } }
        public bool Equals(System.Net.Http.HttpMethod other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Net.Http.HttpMethod left, System.Net.Http.HttpMethod right) { throw null; }
        public static bool operator !=(System.Net.Http.HttpMethod left, System.Net.Http.HttpMethod right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class HttpRequestException : System.Exception
    {
        public HttpRequestException() { }
        public HttpRequestException(string message) { }
        public HttpRequestException(string message, System.Exception inner) { }
    }
    public partial class HttpRequestMessage : System.IDisposable
    {
        public HttpRequestMessage() { }
        public HttpRequestMessage(System.Net.Http.HttpMethod method, string requestUri) { }
        public HttpRequestMessage(System.Net.Http.HttpMethod method, System.Uri requestUri) { }
        public System.Net.Http.HttpContent Content { get { throw null; } set { } }
        public System.Net.Http.Headers.HttpRequestHeaders Headers { get { throw null; } }
        public System.Net.Http.HttpMethod Method { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, object> Properties { get { throw null; } }
        public System.Uri RequestUri { get { throw null; } set { } }
        public System.Version Version { get { throw null; } set { } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public override string ToString() { throw null; }
    }
    public partial class HttpResponseMessage : System.IDisposable
    {
        public HttpResponseMessage() { }
        public HttpResponseMessage(System.Net.HttpStatusCode statusCode) { }
        public System.Net.Http.HttpContent Content { get { throw null; } set { } }
        public System.Net.Http.Headers.HttpResponseHeaders Headers { get { throw null; } }
        public bool IsSuccessStatusCode { get { throw null; } }
        public string ReasonPhrase { get { throw null; } set { } }
        public System.Net.Http.HttpRequestMessage RequestMessage { get { throw null; } set { } }
        public System.Net.HttpStatusCode StatusCode { get { throw null; } set { } }
        public System.Net.Http.Headers.HttpResponseHeaders TrailingHeaders { get { throw null; } }
        public System.Version Version { get { throw null; } set { } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public System.Net.Http.HttpResponseMessage EnsureSuccessStatusCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public abstract partial class MessageProcessingHandler : System.Net.Http.DelegatingHandler
    {
        protected MessageProcessingHandler() { }
        protected MessageProcessingHandler(System.Net.Http.HttpMessageHandler innerHandler) { }
        protected abstract System.Net.Http.HttpRequestMessage ProcessRequest(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken);
        protected abstract System.Net.Http.HttpResponseMessage ProcessResponse(System.Net.Http.HttpResponseMessage response, System.Threading.CancellationToken cancellationToken);
        protected internal sealed override System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public partial class MultipartContent : System.Net.Http.HttpContent, System.Collections.Generic.IEnumerable<System.Net.Http.HttpContent>, System.Collections.IEnumerable
    {
        public MultipartContent() { }
        public MultipartContent(string subtype) { }
        public MultipartContent(string subtype, string boundary) { }
        public virtual void Add(System.Net.Http.HttpContent content) { }
        protected override System.Threading.Tasks.Task<System.IO.Stream> CreateContentReadStreamAsync() { throw null; }
        protected override void Dispose(bool disposing) { }
        public System.Collections.Generic.IEnumerator<System.Net.Http.HttpContent> GetEnumerator() { throw null; }
        protected override System.Threading.Tasks.Task SerializeToStreamAsync(System.IO.Stream stream, System.Net.TransportContext context) { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        protected internal override bool TryComputeLength(out long length) { throw null; }
    }
    public partial class MultipartFormDataContent : System.Net.Http.MultipartContent
    {
        public MultipartFormDataContent() { }
        public MultipartFormDataContent(string boundary) { }
        public override void Add(System.Net.Http.HttpContent content) { }
        public void Add(System.Net.Http.HttpContent content, string name) { }
        public void Add(System.Net.Http.HttpContent content, string name, string fileName) { }
    }
    public sealed partial class ReadOnlyMemoryContent : System.Net.Http.HttpContent
    {
        public ReadOnlyMemoryContent(System.ReadOnlyMemory<byte> content) { }
        protected override System.Threading.Tasks.Task<System.IO.Stream> CreateContentReadStreamAsync() { throw null; }
        protected override System.Threading.Tasks.Task SerializeToStreamAsync(System.IO.Stream stream, System.Net.TransportContext context) { throw null; }
        protected internal override bool TryComputeLength(out long length) { throw null; }
    }
    public partial class StreamContent : System.Net.Http.HttpContent
    {
        public StreamContent(System.IO.Stream content) { }
        public StreamContent(System.IO.Stream content, int bufferSize) { }
        protected override System.Threading.Tasks.Task<System.IO.Stream> CreateContentReadStreamAsync() { throw null; }
        protected override void Dispose(bool disposing) { }
        protected override System.Threading.Tasks.Task SerializeToStreamAsync(System.IO.Stream stream, System.Net.TransportContext context) { throw null; }
        protected internal override bool TryComputeLength(out long length) { throw null; }
    }
    public partial class StringContent : System.Net.Http.ByteArrayContent
    {
        public StringContent(string content) : base (default(byte[])) { }
        public StringContent(string content, System.Text.Encoding encoding) : base (default(byte[])) { }
        public StringContent(string content, System.Text.Encoding encoding, string mediaType) : base (default(byte[])) { }
    }
}
