// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Net
{
    public partial class AuthenticationManager
    {
        internal AuthenticationManager() { }
        public static System.Net.ICredentialPolicy CredentialPolicy { get { throw null; } set { } }
        public static System.Collections.Specialized.StringDictionary CustomTargetNameDictionary { get { throw null; } }
        public static System.Collections.IEnumerator RegisteredModules { get { throw null; } }
        public static System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest request, System.Net.ICredentials credentials) { throw null; }
        public static System.Net.Authorization PreAuthenticate(System.Net.WebRequest request, System.Net.ICredentials credentials) { throw null; }
        public static void Register(System.Net.IAuthenticationModule authenticationModule) { }
        public static void Unregister(System.Net.IAuthenticationModule authenticationModule) { }
        public static void Unregister(string authenticationScheme) { }
    }
    [System.FlagsAttribute]
    public enum AuthenticationSchemes
    {
        Anonymous = 32768,
        Basic = 8,
        Digest = 1,
        IntegratedWindowsAuthentication = 6,
        Negotiate = 2,
        None = 0,
        Ntlm = 4,
    }
    public delegate System.Net.AuthenticationSchemes AuthenticationSchemeSelector(System.Net.HttpListenerRequest httpRequest);
    public partial class Authorization
    {
        public Authorization(string token) { }
        public Authorization(string token, bool finished) { }
        public Authorization(string token, bool finished, string connectionGroupId) { }
        public bool Complete { get { throw null; } }
        public string ConnectionGroupId { get { throw null; } }
        public string Message { get { throw null; } }
        public bool MutuallyAuthenticated { get { throw null; } set { } }
        public string[] ProtectionRealm { get { throw null; } set { } }
    }
    public delegate System.Net.IPEndPoint BindIPEndPoint(System.Net.ServicePoint servicePoint, System.Net.IPEndPoint remoteEndPoint, int retryCount);
    public sealed partial class Cookie
    {
        public Cookie() { }
        public Cookie(string name, string value) { }
        public Cookie(string name, string value, string path) { }
        public Cookie(string name, string value, string path, string domain) { }
        public string Comment { get { throw null; } set { } }
        public System.Uri CommentUri { get { throw null; } set { } }
        public bool Discard { get { throw null; } set { } }
        public string Domain { get { throw null; } set { } }
        public bool Expired { get { throw null; } set { } }
        public System.DateTime Expires { get { throw null; } set { } }
        public bool HttpOnly { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string Path { get { throw null; } set { } }
        public string Port { get { throw null; } set { } }
        public bool Secure { get { throw null; } set { } }
        public System.DateTime TimeStamp { get { throw null; } }
        public string Value { get { throw null; } set { } }
        public int Version { get { throw null; } set { } }
        public override bool Equals(object comparand) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class CookieCollection : System.Collections.ICollection, System.Collections.IEnumerable
    {
        public CookieCollection() { }
        public int Count { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public bool IsSynchronized { get { throw null; } }
        public System.Net.Cookie this[int index] { get { throw null; } }
        public System.Net.Cookie this[string name] { get { throw null; } }
        public object SyncRoot { get { throw null; } }
        public void Add(System.Net.Cookie cookie) { }
        public void Add(System.Net.CookieCollection cookies) { }
        public void CopyTo(System.Array array, int index) { }
        public void CopyTo(System.Net.Cookie[] array, int index) { }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
    }
    public partial class CookieContainer
    {
        public const int DefaultCookieLengthLimit = 4096;
        public const int DefaultCookieLimit = 300;
        public const int DefaultPerDomainCookieLimit = 20;
        public CookieContainer() { }
        public CookieContainer(int capacity) { }
        public CookieContainer(int capacity, int perDomainCapacity, int maxCookieSize) { }
        public int Capacity { get { throw null; } set { } }
        public int Count { get { throw null; } }
        public int MaxCookieSize { get { throw null; } set { } }
        public int PerDomainCapacity { get { throw null; } set { } }
        public void Add(System.Net.Cookie cookie) { }
        public void Add(System.Net.CookieCollection cookies) { }
        public void Add(System.Uri uri, System.Net.Cookie cookie) { }
        public void Add(System.Uri uri, System.Net.CookieCollection cookies) { }
        public string GetCookieHeader(System.Uri uri) { throw null; }
        public System.Net.CookieCollection GetCookies(System.Uri uri) { throw null; }
        public void SetCookies(System.Uri uri, string cookieHeader) { }
    }
    public partial class CookieException : System.FormatException, System.Runtime.Serialization.ISerializable
    {
        public CookieException() { }
        protected CookieException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    }
    public partial class CredentialCache : System.Collections.IEnumerable, System.Net.ICredentials, System.Net.ICredentialsByHost
    {
        public CredentialCache() { }
        public static System.Net.ICredentials DefaultCredentials { get { throw null; } }
        public static System.Net.NetworkCredential DefaultNetworkCredentials { get { throw null; } }
        public void Add(string host, int port, string authenticationType, System.Net.NetworkCredential credential) { }
        public void Add(System.Uri uriPrefix, string authType, System.Net.NetworkCredential cred) { }
        public System.Net.NetworkCredential GetCredential(string host, int port, string authenticationType) { throw null; }
        public System.Net.NetworkCredential GetCredential(System.Uri uriPrefix, string authType) { throw null; }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        public void Remove(string host, int port, string authenticationType) { }
        public void Remove(System.Uri uriPrefix, string authType) { }
    }
    [System.FlagsAttribute]
    public enum DecompressionMethods
    {
        Deflate = 2,
        GZip = 1,
        None = 0,
    }
    public static partial class Dns
    {
        public static System.IAsyncResult BeginGetHostAddresses(string hostNameOrAddress, System.AsyncCallback requestCallback, object state) { throw null; }
        [System.ObsoleteAttribute("BeginGetHostByName is obsoleted for this type, please use BeginGetHostEntry instead. https://go.microsoft.com/fwlink/?linkid=14202")]
        public static System.IAsyncResult BeginGetHostByName(string hostName, System.AsyncCallback requestCallback, object stateObject) { throw null; }
        public static System.IAsyncResult BeginGetHostEntry(System.Net.IPAddress address, System.AsyncCallback requestCallback, object stateObject) { throw null; }
        public static System.IAsyncResult BeginGetHostEntry(string hostNameOrAddress, System.AsyncCallback requestCallback, object stateObject) { throw null; }
        [System.ObsoleteAttribute("BeginResolve is obsoleted for this type, please use BeginGetHostEntry instead. https://go.microsoft.com/fwlink/?linkid=14202")]
        public static System.IAsyncResult BeginResolve(string hostName, System.AsyncCallback requestCallback, object stateObject) { throw null; }
        public static System.Net.IPAddress[] EndGetHostAddresses(System.IAsyncResult asyncResult) { throw null; }
        [System.ObsoleteAttribute("EndGetHostByName is obsoleted for this type, please use EndGetHostEntry instead. https://go.microsoft.com/fwlink/?linkid=14202")]
        public static System.Net.IPHostEntry EndGetHostByName(System.IAsyncResult asyncResult) { throw null; }
        public static System.Net.IPHostEntry EndGetHostEntry(System.IAsyncResult asyncResult) { throw null; }
        [System.ObsoleteAttribute("EndResolve is obsoleted for this type, please use EndGetHostEntry instead. https://go.microsoft.com/fwlink/?linkid=14202")]
        public static System.Net.IPHostEntry EndResolve(System.IAsyncResult asyncResult) { throw null; }
        public static System.Net.IPAddress[] GetHostAddresses(string hostNameOrAddress) { throw null; }
        public static System.Threading.Tasks.Task<System.Net.IPAddress[]> GetHostAddressesAsync(string hostNameOrAddress) { throw null; }
        [System.ObsoleteAttribute("GetHostByAddress is obsoleted for this type, please use GetHostEntry instead. https://go.microsoft.com/fwlink/?linkid=14202")]
        public static System.Net.IPHostEntry GetHostByAddress(System.Net.IPAddress address) { throw null; }
        [System.ObsoleteAttribute("GetHostByAddress is obsoleted for this type, please use GetHostEntry instead. https://go.microsoft.com/fwlink/?linkid=14202")]
        public static System.Net.IPHostEntry GetHostByAddress(string address) { throw null; }
        [System.ObsoleteAttribute("GetHostByName is obsoleted for this type, please use GetHostEntry instead. https://go.microsoft.com/fwlink/?linkid=14202")]
        public static System.Net.IPHostEntry GetHostByName(string hostName) { throw null; }
        public static System.Net.IPHostEntry GetHostEntry(System.Net.IPAddress address) { throw null; }
        public static System.Net.IPHostEntry GetHostEntry(string hostNameOrAddress) { throw null; }
        public static System.Threading.Tasks.Task<System.Net.IPHostEntry> GetHostEntryAsync(System.Net.IPAddress address) { throw null; }
        public static System.Threading.Tasks.Task<System.Net.IPHostEntry> GetHostEntryAsync(string hostNameOrAddress) { throw null; }
        public static string GetHostName() { throw null; }
        [System.ObsoleteAttribute("Resolve is obsoleted for this type, please use GetHostEntry instead. https://go.microsoft.com/fwlink/?linkid=14202")]
        public static System.Net.IPHostEntry Resolve(string hostName) { throw null; }
    }
    public partial class DnsEndPoint : System.Net.EndPoint
    {
        public DnsEndPoint(string host, int port) { }
        public DnsEndPoint(string host, int port, System.Net.Sockets.AddressFamily addressFamily) { }
        public override System.Net.Sockets.AddressFamily AddressFamily { get { throw null; } }
        public string Host { get { throw null; } }
        public int Port { get { throw null; } }
        public override bool Equals(object comparand) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DownloadDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        internal DownloadDataCompletedEventArgs() : base (default(System.Exception), default(bool), default(object)) { }
        public byte[] Result { get { throw null; } }
    }
    public delegate void DownloadDataCompletedEventHandler(object sender, System.Net.DownloadDataCompletedEventArgs e);
    public partial class DownloadProgressChangedEventArgs : System.ComponentModel.ProgressChangedEventArgs
    {
        internal DownloadProgressChangedEventArgs() : base (default(int), default(object)) { }
        public long BytesReceived { get { throw null; } }
        public long TotalBytesToReceive { get { throw null; } }
    }
    public delegate void DownloadProgressChangedEventHandler(object sender, System.Net.DownloadProgressChangedEventArgs e);
    public partial class DownloadStringCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        internal DownloadStringCompletedEventArgs() : base (default(System.Exception), default(bool), default(object)) { }
        public string Result { get { throw null; } }
    }
    public delegate void DownloadStringCompletedEventHandler(object sender, System.Net.DownloadStringCompletedEventArgs e);
    public abstract partial class EndPoint
    {
        protected EndPoint() { }
        public virtual System.Net.Sockets.AddressFamily AddressFamily { get { throw null; } }
        public virtual System.Net.EndPoint Create(System.Net.SocketAddress socketAddress) { throw null; }
        public virtual System.Net.SocketAddress Serialize() { throw null; }
    }
    public partial class FileWebRequest : System.Net.WebRequest, System.Runtime.Serialization.ISerializable
    {
        [System.ObsoleteAttribute("Serialization is obsoleted for this type. https://go.microsoft.com/fwlink/?linkid=14202")]
        protected FileWebRequest(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public override string ConnectionGroupName { get { throw null; } set { } }
        public override long ContentLength { get { throw null; } set { } }
        public override string ContentType { get { throw null; } set { } }
        public override System.Net.ICredentials Credentials { get { throw null; } set { } }
        public override System.Net.WebHeaderCollection Headers { get { throw null; } }
        public override string Method { get { throw null; } set { } }
        public override bool PreAuthenticate { get { throw null; } set { } }
        public override System.Net.IWebProxy Proxy { get { throw null; } set { } }
        public override System.Uri RequestUri { get { throw null; } }
        public override int Timeout { get { throw null; } set { } }
        public override bool UseDefaultCredentials { get { throw null; } set { } }
        public override void Abort() { }
        public override System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, object state) { throw null; }
        public override System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state) { throw null; }
        public override System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult) { throw null; }
        public override System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult) { throw null; }
        protected override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public override System.IO.Stream GetRequestStream() { throw null; }
        public override System.Threading.Tasks.Task<System.IO.Stream> GetRequestStreamAsync() { throw null; }
        public override System.Net.WebResponse GetResponse() { throw null; }
        public override System.Threading.Tasks.Task<System.Net.WebResponse> GetResponseAsync() { throw null; }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    }
    public partial class FileWebResponse : System.Net.WebResponse, System.Runtime.Serialization.ISerializable
    {
        [System.ObsoleteAttribute("Serialization is obsoleted for this type. https://go.microsoft.com/fwlink/?linkid=14202")]
        protected FileWebResponse(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public override long ContentLength { get { throw null; } }
        public override string ContentType { get { throw null; } }
        public override System.Net.WebHeaderCollection Headers { get { throw null; } }
        public override System.Uri ResponseUri { get { throw null; } }
        public override bool SupportsHeaders { get { throw null; } }
        public override void Close() { }
        protected override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public override System.IO.Stream GetResponseStream() { throw null; }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    }
    public enum FtpStatusCode
    {
        AccountNeeded = 532,
        ActionAbortedLocalProcessingError = 451,
        ActionAbortedUnknownPageType = 551,
        ActionNotTakenFilenameNotAllowed = 553,
        ActionNotTakenFileUnavailable = 550,
        ActionNotTakenFileUnavailableOrBusy = 450,
        ActionNotTakenInsufficientSpace = 452,
        ArgumentSyntaxError = 501,
        BadCommandSequence = 503,
        CantOpenData = 425,
        ClosingControl = 221,
        ClosingData = 226,
        CommandExtraneous = 202,
        CommandNotImplemented = 502,
        CommandOK = 200,
        CommandSyntaxError = 500,
        ConnectionClosed = 426,
        DataAlreadyOpen = 125,
        DirectoryStatus = 212,
        EnteringPassive = 227,
        FileActionAborted = 552,
        FileActionOK = 250,
        FileCommandPending = 350,
        FileStatus = 213,
        LoggedInProceed = 230,
        NeedLoginAccount = 332,
        NotLoggedIn = 530,
        OpeningData = 150,
        PathnameCreated = 257,
        RestartMarker = 110,
        SendPasswordCommand = 331,
        SendUserCommand = 220,
        ServerWantsSecureSession = 234,
        ServiceNotAvailable = 421,
        ServiceTemporarilyNotAvailable = 120,
        SystemType = 215,
        Undefined = 0,
    }
    public sealed partial class FtpWebRequest : System.Net.WebRequest
    {
        internal FtpWebRequest() { }
        public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get { throw null; } set { } }
        public override string ConnectionGroupName { get { throw null; } set { } }
        public override long ContentLength { get { throw null; } set { } }
        public long ContentOffset { get { throw null; } set { } }
        public override string ContentType { get { throw null; } set { } }
        public override System.Net.ICredentials Credentials { get { throw null; } set { } }
        public static new System.Net.Cache.RequestCachePolicy DefaultCachePolicy { get { throw null; } set { } }
        public bool EnableSsl { get { throw null; } set { } }
        public override System.Net.WebHeaderCollection Headers { get { throw null; } set { } }
        public bool KeepAlive { get { throw null; } set { } }
        public override string Method { get { throw null; } set { } }
        public override bool PreAuthenticate { get { throw null; } set { } }
        public override System.Net.IWebProxy Proxy { get { throw null; } set { } }
        public int ReadWriteTimeout { get { throw null; } set { } }
        public string RenameTo { get { throw null; } set { } }
        public override System.Uri RequestUri { get { throw null; } }
        public System.Net.ServicePoint ServicePoint { get { throw null; } }
        public override int Timeout { get { throw null; } set { } }
        public bool UseBinary { get { throw null; } set { } }
        public override bool UseDefaultCredentials { get { throw null; } set { } }
        public bool UsePassive { get { throw null; } set { } }
        public override void Abort() { }
        public override System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, object state) { throw null; }
        public override System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state) { throw null; }
        public override System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult) { throw null; }
        public override System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult) { throw null; }
        public override System.IO.Stream GetRequestStream() { throw null; }
        public override System.Net.WebResponse GetResponse() { throw null; }
    }
    public partial class FtpWebResponse : System.Net.WebResponse, System.IDisposable
    {
        internal FtpWebResponse() { }
        public string BannerMessage { get { throw null; } }
        public override long ContentLength { get { throw null; } }
        public override string ContentType { get { throw null; } }
        public string ExitMessage { get { throw null; } }
        public override System.Net.WebHeaderCollection Headers { get { throw null; } }
        public System.DateTime LastModified { get { throw null; } }
        public override System.Uri ResponseUri { get { throw null; } }
        public System.Net.FtpStatusCode StatusCode { get { throw null; } }
        public string StatusDescription { get { throw null; } }
        public override bool SupportsHeaders { get { throw null; } }
        public string WelcomeMessage { get { throw null; } }
        public override void Close() { }
        public override System.IO.Stream GetResponseStream() { throw null; }
    }
    [System.ObsoleteAttribute("This class has been deprecated. Please use WebRequest.DefaultWebProxy instead to access and set the global default proxy. Use 'null' instead of GetEmptyWebProxy. https://go.microsoft.com/fwlink/?linkid=14202")]
    public partial class GlobalProxySelection
    {
        public GlobalProxySelection() { }
        public static System.Net.IWebProxy Select { get { throw null; } set { } }
        public static System.Net.IWebProxy GetEmptyWebProxy() { throw null; }
    }
    public delegate void HttpContinueDelegate(int StatusCode, System.Net.WebHeaderCollection httpHeaders);
    public sealed partial class HttpListener : System.IDisposable
    {
        public HttpListener() { }
        public System.Net.AuthenticationSchemes AuthenticationSchemes { get { throw null; } set { } }
        public System.Net.AuthenticationSchemeSelector AuthenticationSchemeSelectorDelegate { get { throw null; } set { } }
        public System.Security.Authentication.ExtendedProtection.ServiceNameCollection DefaultServiceNames { get { throw null; } }
        public System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy ExtendedProtectionPolicy { get { throw null; } set { } }
        public System.Net.HttpListener.ExtendedProtectionSelector ExtendedProtectionSelectorDelegate { get { throw null; } set { } }
        public bool IgnoreWriteExceptions { get { throw null; } set { } }
        public bool IsListening { get { throw null; } }
        public static bool IsSupported { get { throw null; } }
        public System.Net.HttpListenerPrefixCollection Prefixes { get { throw null; } }
        public string Realm { get { throw null; } set { } }
        public System.Net.HttpListenerTimeoutManager TimeoutManager { get { throw null; } }
        public bool UnsafeConnectionNtlmAuthentication { get { throw null; } set { } }
        public void Abort() { }
        public System.IAsyncResult BeginGetContext(System.AsyncCallback callback, object state) { throw null; }
        public void Close() { }
        public System.Net.HttpListenerContext EndGetContext(System.IAsyncResult asyncResult) { throw null; }
        public System.Net.HttpListenerContext GetContext() { throw null; }
        public System.Threading.Tasks.Task<System.Net.HttpListenerContext> GetContextAsync() { throw null; }
        public void Start() { }
        public void Stop() { }
        void System.IDisposable.Dispose() { }
        public delegate System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy ExtendedProtectionSelector(System.Net.HttpListenerRequest request);
    }
    public partial class HttpListenerBasicIdentity : System.Security.Principal.GenericIdentity
    {
        public HttpListenerBasicIdentity(string username, string password) : base (default(string)) { }
        public virtual string Password { get { throw null; } }
    }
    public sealed partial class HttpListenerContext
    {
        internal HttpListenerContext() { }
        public System.Net.HttpListenerRequest Request { get { throw null; } }
        public System.Net.HttpListenerResponse Response { get { throw null; } }
        public System.Security.Principal.IPrincipal User { get { throw null; } }
        public System.Threading.Tasks.Task<System.Net.WebSockets.HttpListenerWebSocketContext> AcceptWebSocketAsync(string subProtocol) { throw null; }
        public System.Threading.Tasks.Task<System.Net.WebSockets.HttpListenerWebSocketContext> AcceptWebSocketAsync(string subProtocol, int receiveBufferSize, System.TimeSpan keepAliveInterval) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Threading.Tasks.Task<System.Net.WebSockets.HttpListenerWebSocketContext> AcceptWebSocketAsync(string subProtocol, int receiveBufferSize, System.TimeSpan keepAliveInterval, System.ArraySegment<byte> internalBuffer) { throw null; }
        public System.Threading.Tasks.Task<System.Net.WebSockets.HttpListenerWebSocketContext> AcceptWebSocketAsync(string subProtocol, System.TimeSpan keepAliveInterval) { throw null; }
    }
    public partial class HttpListenerException : System.ComponentModel.Win32Exception
    {
        public HttpListenerException() { }
        public HttpListenerException(int errorCode) { }
        public HttpListenerException(int errorCode, string message) { }
        protected HttpListenerException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public override int ErrorCode { get { throw null; } }
    }
    public partial class HttpListenerPrefixCollection : System.Collections.Generic.ICollection<string>, System.Collections.Generic.IEnumerable<string>, System.Collections.IEnumerable
    {
        internal HttpListenerPrefixCollection() { }
        public int Count { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public bool IsSynchronized { get { throw null; } }
        public void Add(string uriPrefix) { }
        public void Clear() { }
        public bool Contains(string uriPrefix) { throw null; }
        public void CopyTo(System.Array array, int offset) { }
        public void CopyTo(string[] array, int offset) { }
        public System.Collections.Generic.IEnumerator<string> GetEnumerator() { throw null; }
        public bool Remove(string uriPrefix) { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public sealed partial class HttpListenerRequest
    {
        internal HttpListenerRequest() { }
        public string[] AcceptTypes { get { throw null; } }
        public int ClientCertificateError { get { throw null; } }
        public System.Text.Encoding ContentEncoding { get { throw null; } }
        public long ContentLength64 { get { throw null; } }
        public string ContentType { get { throw null; } }
        public System.Net.CookieCollection Cookies { get { throw null; } }
        public bool HasEntityBody { get { throw null; } }
        public System.Collections.Specialized.NameValueCollection Headers { get { throw null; } }
        public string HttpMethod { get { throw null; } }
        public System.IO.Stream InputStream { get { throw null; } }
        public bool IsAuthenticated { get { throw null; } }
        public bool IsLocal { get { throw null; } }
        public bool IsSecureConnection { get { throw null; } }
        public bool IsWebSocketRequest { get { throw null; } }
        public bool KeepAlive { get { throw null; } }
        public System.Net.IPEndPoint LocalEndPoint { get { throw null; } }
        public System.Version ProtocolVersion { get { throw null; } }
        public System.Collections.Specialized.NameValueCollection QueryString { get { throw null; } }
        public string RawUrl { get { throw null; } }
        public System.Net.IPEndPoint RemoteEndPoint { get { throw null; } }
        public System.Guid RequestTraceIdentifier { get { throw null; } }
        public string ServiceName { get { throw null; } }
        public System.Net.TransportContext TransportContext { get { throw null; } }
        public System.Uri Url { get { throw null; } }
        public System.Uri UrlReferrer { get { throw null; } }
        public string UserAgent { get { throw null; } }
        public string UserHostAddress { get { throw null; } }
        public string UserHostName { get { throw null; } }
        public string[] UserLanguages { get { throw null; } }
        public System.IAsyncResult BeginGetClientCertificate(System.AsyncCallback requestCallback, object state) { throw null; }
        public System.Security.Cryptography.X509Certificates.X509Certificate2 EndGetClientCertificate(System.IAsyncResult asyncResult) { throw null; }
        public System.Security.Cryptography.X509Certificates.X509Certificate2 GetClientCertificate() { throw null; }
        public System.Threading.Tasks.Task<System.Security.Cryptography.X509Certificates.X509Certificate2> GetClientCertificateAsync() { throw null; }
    }
    public sealed partial class HttpListenerResponse : System.IDisposable
    {
        internal HttpListenerResponse() { }
        public System.Text.Encoding ContentEncoding { get { throw null; } set { } }
        public long ContentLength64 { get { throw null; } set { } }
        public string ContentType { get { throw null; } set { } }
        public System.Net.CookieCollection Cookies { get { throw null; } set { } }
        public System.Net.WebHeaderCollection Headers { get { throw null; } set { } }
        public bool KeepAlive { get { throw null; } set { } }
        public System.IO.Stream OutputStream { get { throw null; } }
        public System.Version ProtocolVersion { get { throw null; } set { } }
        public string RedirectLocation { get { throw null; } set { } }
        public bool SendChunked { get { throw null; } set { } }
        public int StatusCode { get { throw null; } set { } }
        public string StatusDescription { get { throw null; } set { } }
        public void Abort() { }
        public void AddHeader(string name, string value) { }
        public void AppendCookie(System.Net.Cookie cookie) { }
        public void AppendHeader(string name, string value) { }
        public void Close() { }
        public void Close(byte[] responseEntity, bool willBlock) { }
        public void CopyFrom(System.Net.HttpListenerResponse templateResponse) { }
        public void Redirect(string url) { }
        public void SetCookie(System.Net.Cookie cookie) { }
        void System.IDisposable.Dispose() { }
    }
    public partial class HttpListenerTimeoutManager
    {
        internal HttpListenerTimeoutManager() { }
        public System.TimeSpan DrainEntityBody { get { throw null; } set { } }
        public System.TimeSpan EntityBody { get { throw null; } set { } }
        public System.TimeSpan HeaderWait { get { throw null; } set { } }
        public System.TimeSpan IdleConnection { get { throw null; } set { } }
        public long MinSendBytesPerSecond { get { throw null; } set { } }
        public System.TimeSpan RequestQueue { get { throw null; } set { } }
    }
    public enum HttpRequestHeader
    {
        Accept = 20,
        AcceptCharset = 21,
        AcceptEncoding = 22,
        AcceptLanguage = 23,
        Allow = 10,
        Authorization = 24,
        CacheControl = 0,
        Connection = 1,
        ContentEncoding = 13,
        ContentLanguage = 14,
        ContentLength = 11,
        ContentLocation = 15,
        ContentMd5 = 16,
        ContentRange = 17,
        ContentType = 12,
        Cookie = 25,
        Date = 2,
        Expect = 26,
        Expires = 18,
        From = 27,
        Host = 28,
        IfMatch = 29,
        IfModifiedSince = 30,
        IfNoneMatch = 31,
        IfRange = 32,
        IfUnmodifiedSince = 33,
        KeepAlive = 3,
        LastModified = 19,
        MaxForwards = 34,
        Pragma = 4,
        ProxyAuthorization = 35,
        Range = 37,
        Referer = 36,
        Te = 38,
        Trailer = 5,
        TransferEncoding = 6,
        Translate = 39,
        Upgrade = 7,
        UserAgent = 40,
        Via = 8,
        Warning = 9,
    }
    public enum HttpResponseHeader
    {
        AcceptRanges = 20,
        Age = 21,
        Allow = 10,
        CacheControl = 0,
        Connection = 1,
        ContentEncoding = 13,
        ContentLanguage = 14,
        ContentLength = 11,
        ContentLocation = 15,
        ContentMd5 = 16,
        ContentRange = 17,
        ContentType = 12,
        Date = 2,
        ETag = 22,
        Expires = 18,
        KeepAlive = 3,
        LastModified = 19,
        Location = 23,
        Pragma = 4,
        ProxyAuthenticate = 24,
        RetryAfter = 25,
        Server = 26,
        SetCookie = 27,
        Trailer = 5,
        TransferEncoding = 6,
        Upgrade = 7,
        Vary = 28,
        Via = 8,
        Warning = 9,
        WwwAuthenticate = 29,
    }
    public enum HttpStatusCode
    {
        Accepted = 202,
        AlreadyReported = 208,
        Ambiguous = 300,
        BadGateway = 502,
        BadRequest = 400,
        Conflict = 409,
        Continue = 100,
        Created = 201,
        EarlyHints = 103,
        ExpectationFailed = 417,
        FailedDependency = 424,
        Forbidden = 403,
        Found = 302,
        GatewayTimeout = 504,
        Gone = 410,
        HttpVersionNotSupported = 505,
        IMUsed = 226,
        InsufficientStorage = 507,
        InternalServerError = 500,
        LengthRequired = 411,
        Locked = 423,
        LoopDetected = 508,
        MethodNotAllowed = 405,
        MisdirectedRequest = 421,
        Moved = 301,
        MovedPermanently = 301,
        MultipleChoices = 300,
        MultiStatus = 207,
        NetworkAuthenticationRequired = 511,
        NoContent = 204,
        NonAuthoritativeInformation = 203,
        NotAcceptable = 406,
        NotExtended = 510,
        NotFound = 404,
        NotImplemented = 501,
        NotModified = 304,
        OK = 200,
        PartialContent = 206,
        PaymentRequired = 402,
        PermanentRedirect = 308,
        PreconditionFailed = 412,
        PreconditionRequired = 428,
        Processing = 102,
        ProxyAuthenticationRequired = 407,
        Redirect = 302,
        RedirectKeepVerb = 307,
        RedirectMethod = 303,
        RequestedRangeNotSatisfiable = 416,
        RequestEntityTooLarge = 413,
        RequestHeaderFieldsTooLarge = 431,
        RequestTimeout = 408,
        RequestUriTooLong = 414,
        ResetContent = 205,
        SeeOther = 303,
        ServiceUnavailable = 503,
        SwitchingProtocols = 101,
        TemporaryRedirect = 307,
        TooManyRequests = 429,
        Unauthorized = 401,
        UnavailableForLegalReasons = 451,
        UnprocessableEntity = 422,
        UnsupportedMediaType = 415,
        Unused = 306,
        UpgradeRequired = 426,
        UseProxy = 305,
        VariantAlsoNegotiates = 506,
    }
    public static partial class HttpVersion
    {
        public static readonly System.Version Unknown;
        public static readonly System.Version Version10;
        public static readonly System.Version Version11;
        public static readonly System.Version Version20;
    }
    public partial class HttpWebRequest : System.Net.WebRequest, System.Runtime.Serialization.ISerializable
    {
        [System.ObsoleteAttribute("Serialization is obsoleted for this type.  https://go.microsoft.com/fwlink/?linkid=14202")]
        protected HttpWebRequest(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public string Accept { get { throw null; } set { } }
        public System.Uri Address { get { throw null; } }
        public virtual bool AllowAutoRedirect { get { throw null; } set { } }
        public virtual bool AllowReadStreamBuffering { get { throw null; } set { } }
        public virtual bool AllowWriteStreamBuffering { get { throw null; } set { } }
        public System.Net.DecompressionMethods AutomaticDecompression { get { throw null; } set { } }
        public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get { throw null; } set { } }
        public string Connection { get { throw null; } set { } }
        public override string ConnectionGroupName { get { throw null; } set { } }
        public override long ContentLength { get { throw null; } set { } }
        public override string ContentType { get { throw null; } set { } }
        public System.Net.HttpContinueDelegate ContinueDelegate { get { throw null; } set { } }
        public int ContinueTimeout { get { throw null; } set { } }
        public virtual System.Net.CookieContainer CookieContainer { get { throw null; } set { } }
        public override System.Net.ICredentials Credentials { get { throw null; } set { } }
        public System.DateTime Date { get { throw null; } set { } }
        public static new System.Net.Cache.RequestCachePolicy DefaultCachePolicy { get { throw null; } set { } }
        public static int DefaultMaximumErrorResponseLength { get { throw null; } set { } }
        public static int DefaultMaximumResponseHeadersLength { get { throw null; } set { } }
        public string Expect { get { throw null; } set { } }
        public virtual bool HaveResponse { get { throw null; } }
        public override System.Net.WebHeaderCollection Headers { get { throw null; } set { } }
        public string Host { get { throw null; } set { } }
        public System.DateTime IfModifiedSince { get { throw null; } set { } }
        public bool KeepAlive { get { throw null; } set { } }
        public int MaximumAutomaticRedirections { get { throw null; } set { } }
        public int MaximumResponseHeadersLength { get { throw null; } set { } }
        public string MediaType { get { throw null; } set { } }
        public override string Method { get { throw null; } set { } }
        public bool Pipelined { get { throw null; } set { } }
        public override bool PreAuthenticate { get { throw null; } set { } }
        public System.Version ProtocolVersion { get { throw null; } set { } }
        public override System.Net.IWebProxy Proxy { get { throw null; } set { } }
        public int ReadWriteTimeout { get { throw null; } set { } }
        public string Referer { get { throw null; } set { } }
        public override System.Uri RequestUri { get { throw null; } }
        public bool SendChunked { get { throw null; } set { } }
        public System.Net.Security.RemoteCertificateValidationCallback ServerCertificateValidationCallback { get { throw null; } set { } }
        public System.Net.ServicePoint ServicePoint { get { throw null; } }
        public virtual bool SupportsCookieContainer { get { throw null; } }
        public override int Timeout { get { throw null; } set { } }
        public string TransferEncoding { get { throw null; } set { } }
        public bool UnsafeAuthenticatedConnectionSharing { get { throw null; } set { } }
        public override bool UseDefaultCredentials { get { throw null; } set { } }
        public string UserAgent { get { throw null; } set { } }
        public override void Abort() { }
        public void AddRange(int range) { }
        public void AddRange(int from, int to) { }
        public void AddRange(long range) { }
        public void AddRange(long from, long to) { }
        public void AddRange(string rangeSpecifier, int range) { }
        public void AddRange(string rangeSpecifier, int from, int to) { }
        public void AddRange(string rangeSpecifier, long range) { }
        public void AddRange(string rangeSpecifier, long from, long to) { }
        public override System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, object state) { throw null; }
        public override System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state) { throw null; }
        public override System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult) { throw null; }
        public System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult, out System.Net.TransportContext context) { throw null; }
        public override System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult) { throw null; }
        [System.ObsoleteAttribute("Serialization is obsoleted for this type.  https://go.microsoft.com/fwlink/?linkid=14202")]
        protected override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public override System.IO.Stream GetRequestStream() { throw null; }
        public System.IO.Stream GetRequestStream(out System.Net.TransportContext context) { throw null; }
        public override System.Net.WebResponse GetResponse() { throw null; }
        [System.ObsoleteAttribute("Serialization is obsoleted for this type.  https://go.microsoft.com/fwlink/?linkid=14202")]
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    }
    public partial class HttpWebResponse : System.Net.WebResponse, System.Runtime.Serialization.ISerializable
    {
        public HttpWebResponse() { }
        [System.ObsoleteAttribute("Serialization is obsoleted for this type.  https://go.microsoft.com/fwlink/?linkid=14202")]
        protected HttpWebResponse(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public string CharacterSet { get { throw null; } }
        public string ContentEncoding { get { throw null; } }
        public override long ContentLength { get { throw null; } }
        public override string ContentType { get { throw null; } }
        public virtual System.Net.CookieCollection Cookies { get { throw null; } set { } }
        public override System.Net.WebHeaderCollection Headers { get { throw null; } }
        public override bool IsMutuallyAuthenticated { get { throw null; } }
        public System.DateTime LastModified { get { throw null; } }
        public virtual string Method { get { throw null; } }
        public System.Version ProtocolVersion { get { throw null; } }
        public override System.Uri ResponseUri { get { throw null; } }
        public string Server { get { throw null; } }
        public virtual System.Net.HttpStatusCode StatusCode { get { throw null; } }
        public virtual string StatusDescription { get { throw null; } }
        public override bool SupportsHeaders { get { throw null; } }
        public override void Close() { }
        protected override void Dispose(bool disposing) { }
        [System.ObsoleteAttribute("Serialization is obsoleted for this type.  https://go.microsoft.com/fwlink/?linkid=14202")]
        protected override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public string GetResponseHeader(string headerName) { throw null; }
        public override System.IO.Stream GetResponseStream() { throw null; }
        [System.ObsoleteAttribute("Serialization is obsoleted for this type.  https://go.microsoft.com/fwlink/?linkid=14202")]
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    }
    public partial interface IAuthenticationModule
    {
        string AuthenticationType { get; }
        bool CanPreAuthenticate { get; }
        System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest request, System.Net.ICredentials credentials);
        System.Net.Authorization PreAuthenticate(System.Net.WebRequest request, System.Net.ICredentials credentials);
    }
    public partial interface ICredentialPolicy
    {
        bool ShouldSendCredential(System.Uri challengeUri, System.Net.WebRequest request, System.Net.NetworkCredential credential, System.Net.IAuthenticationModule authenticationModule);
    }
    public partial interface ICredentials
    {
        System.Net.NetworkCredential GetCredential(System.Uri uri, string authType);
    }
    public partial interface ICredentialsByHost
    {
        System.Net.NetworkCredential GetCredential(string host, int port, string authenticationType);
    }
    public partial class IPAddress
    {
        public static readonly System.Net.IPAddress Any;
        public static readonly System.Net.IPAddress Broadcast;
        public static readonly System.Net.IPAddress IPv6Any;
        public static readonly System.Net.IPAddress IPv6Loopback;
        public static readonly System.Net.IPAddress IPv6None;
        public static readonly System.Net.IPAddress Loopback;
        public static readonly System.Net.IPAddress None;
        public IPAddress(byte[] address) { }
        public IPAddress(byte[] address, long scopeid) { }
        public IPAddress(long newAddress) { }
        public IPAddress(System.ReadOnlySpan<byte> address) { }
        public IPAddress(System.ReadOnlySpan<byte> address, long scopeid) { }
        [System.ObsoleteAttribute("This property has been deprecated. It is address family dependent. Please use IPAddress.Equals method to perform comparisons. https://go.microsoft.com/fwlink/?linkid=14202")]
        public long Address { get { throw null; } set { } }
        public System.Net.Sockets.AddressFamily AddressFamily { get { throw null; } }
        public bool IsIPv4MappedToIPv6 { get { throw null; } }
        public bool IsIPv6LinkLocal { get { throw null; } }
        public bool IsIPv6Multicast { get { throw null; } }
        public bool IsIPv6SiteLocal { get { throw null; } }
        public bool IsIPv6Teredo { get { throw null; } }
        public long ScopeId { get { throw null; } set { } }
        public override bool Equals(object comparand) { throw null; }
        public byte[] GetAddressBytes() { throw null; }
        public override int GetHashCode() { throw null; }
        public static short HostToNetworkOrder(short host) { throw null; }
        public static int HostToNetworkOrder(int host) { throw null; }
        public static long HostToNetworkOrder(long host) { throw null; }
        public static bool IsLoopback(System.Net.IPAddress address) { throw null; }
        public System.Net.IPAddress MapToIPv4() { throw null; }
        public System.Net.IPAddress MapToIPv6() { throw null; }
        public static short NetworkToHostOrder(short network) { throw null; }
        public static int NetworkToHostOrder(int network) { throw null; }
        public static long NetworkToHostOrder(long network) { throw null; }
        public static System.Net.IPAddress Parse(System.ReadOnlySpan<char> ipString) { throw null; }
        public static System.Net.IPAddress Parse(string ipString) { throw null; }
        public override string ToString() { throw null; }
        public bool TryFormat(System.Span<char> destination, out int charsWritten) { throw null; }
        public static bool TryParse(System.ReadOnlySpan<char> ipString, out System.Net.IPAddress address) { throw null; }
        public static bool TryParse(string ipString, out System.Net.IPAddress address) { throw null; }
        public bool TryWriteBytes(System.Span<byte> destination, out int bytesWritten) { throw null; }
    }
    public partial class IPEndPoint : System.Net.EndPoint
    {
        public const int MaxPort = 65535;
        public const int MinPort = 0;
        public IPEndPoint(long address, int port) { }
        public IPEndPoint(System.Net.IPAddress address, int port) { }
        public System.Net.IPAddress Address { get { throw null; } set { } }
        public override System.Net.Sockets.AddressFamily AddressFamily { get { throw null; } }
        public int Port { get { throw null; } set { } }
        public override System.Net.EndPoint Create(System.Net.SocketAddress socketAddress) { throw null; }
        public override bool Equals(object comparand) { throw null; }
        public override int GetHashCode() { throw null; }
        public override System.Net.SocketAddress Serialize() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class IPHostEntry
    {
        public IPHostEntry() { }
        public System.Net.IPAddress[] AddressList { get { throw null; } set { } }
        public string[] Aliases { get { throw null; } set { } }
        public string HostName { get { throw null; } set { } }
    }
    public partial interface IWebProxy
    {
        System.Net.ICredentials Credentials { get; set; }
        System.Uri GetProxy(System.Uri destination);
        bool IsBypassed(System.Uri host);
    }
    public partial interface IWebProxyScript
    {
        void Close();
        bool Load(System.Uri scriptLocation, string script, System.Type helperType);
        string Run(string url, string host);
    }
    public partial interface IWebRequestCreate
    {
        System.Net.WebRequest Create(System.Uri uri);
    }
    public partial class NetworkCredential : System.Net.ICredentials, System.Net.ICredentialsByHost
    {
        public NetworkCredential() { }
        [System.CLSCompliantAttribute(false)]
        public NetworkCredential(string userName, System.Security.SecureString password) { }
        [System.CLSCompliantAttribute(false)]
        public NetworkCredential(string userName, System.Security.SecureString password, string domain) { }
        public NetworkCredential(string userName, string password) { }
        public NetworkCredential(string userName, string password, string domain) { }
        public string Domain { get { throw null; } set { } }
        public string Password { get { throw null; } set { } }
        [System.CLSCompliantAttribute(false)]
        public System.Security.SecureString SecurePassword { get { throw null; } set { } }
        public string UserName { get { throw null; } set { } }
        public System.Net.NetworkCredential GetCredential(string host, int port, string authenticationType) { throw null; }
        public System.Net.NetworkCredential GetCredential(System.Uri uri, string authType) { throw null; }
    }
    public partial class OpenReadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        internal OpenReadCompletedEventArgs() : base (default(System.Exception), default(bool), default(object)) { }
        public System.IO.Stream Result { get { throw null; } }
    }
    public delegate void OpenReadCompletedEventHandler(object sender, System.Net.OpenReadCompletedEventArgs e);
    public partial class OpenWriteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        internal OpenWriteCompletedEventArgs() : base (default(System.Exception), default(bool), default(object)) { }
        public System.IO.Stream Result { get { throw null; } }
    }
    public delegate void OpenWriteCompletedEventHandler(object sender, System.Net.OpenWriteCompletedEventArgs e);
    public partial class ProtocolViolationException : System.InvalidOperationException, System.Runtime.Serialization.ISerializable
    {
        public ProtocolViolationException() { }
        protected ProtocolViolationException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public ProtocolViolationException(string message) { }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    }
    [System.FlagsAttribute]
    public enum SecurityProtocolType
    {
        [System.ObsoleteAttribute("This value has been deprecated.  It is no longer supported. https://go.microsoft.com/fwlink/?linkid=14202")]
        Ssl3 = 48,
        SystemDefault = 0,
        Tls = 192,
        Tls11 = 768,
        Tls12 = 3072,
    }
    public partial class ServicePoint
    {
        internal ServicePoint() { }
        public System.Uri Address { get { throw null; } }
        public System.Net.BindIPEndPoint BindIPEndPointDelegate { get { throw null; } set { } }
        public System.Security.Cryptography.X509Certificates.X509Certificate Certificate { get { throw null; } }
        public System.Security.Cryptography.X509Certificates.X509Certificate ClientCertificate { get { throw null; } }
        public int ConnectionLeaseTimeout { get { throw null; } set { } }
        public int ConnectionLimit { get { throw null; } set { } }
        public string ConnectionName { get { throw null; } }
        public int CurrentConnections { get { throw null; } }
        public bool Expect100Continue { get { throw null; } set { } }
        public System.DateTime IdleSince { get { throw null; } }
        public int MaxIdleTime { get { throw null; } set { } }
        public virtual System.Version ProtocolVersion { get { throw null; } }
        public int ReceiveBufferSize { get { throw null; } set { } }
        public bool SupportsPipelining { get { throw null; } }
        public bool UseNagleAlgorithm { get { throw null; } set { } }
        public bool CloseConnectionGroup(string connectionGroupName) { throw null; }
        public void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval) { }
    }
    public partial class ServicePointManager
    {
        internal ServicePointManager() { }
        public const int DefaultNonPersistentConnectionLimit = 4;
        public const int DefaultPersistentConnectionLimit = 2;
        public static bool CheckCertificateRevocationList { get { throw null; } set { } }
        public static int DefaultConnectionLimit { get { throw null; } set { } }
        public static int DnsRefreshTimeout { get { throw null; } set { } }
        public static bool EnableDnsRoundRobin { get { throw null; } set { } }
        public static System.Net.Security.EncryptionPolicy EncryptionPolicy { get { throw null; } }
        public static bool Expect100Continue { get { throw null; } set { } }
        public static int MaxServicePointIdleTime { get { throw null; } set { } }
        public static int MaxServicePoints { get { throw null; } set { } }
        public static bool ReusePort { get { throw null; } set { } }
        public static System.Net.SecurityProtocolType SecurityProtocol { get { throw null; } set { } }
        public static System.Net.Security.RemoteCertificateValidationCallback ServerCertificateValidationCallback { get { throw null; } set { } }
        public static bool UseNagleAlgorithm { get { throw null; } set { } }
        public static System.Net.ServicePoint FindServicePoint(string uriString, System.Net.IWebProxy proxy) { throw null; }
        public static System.Net.ServicePoint FindServicePoint(System.Uri address) { throw null; }
        public static System.Net.ServicePoint FindServicePoint(System.Uri address, System.Net.IWebProxy proxy) { throw null; }
        public static void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval) { }
    }
    public partial class SocketAddress
    {
        public SocketAddress(System.Net.Sockets.AddressFamily family) { }
        public SocketAddress(System.Net.Sockets.AddressFamily family, int size) { }
        public System.Net.Sockets.AddressFamily Family { get { throw null; } }
        public byte this[int offset] { get { throw null; } set { } }
        public int Size { get { throw null; } }
        public override bool Equals(object comparand) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public abstract partial class TransportContext
    {
        protected TransportContext() { }
        public abstract System.Security.Authentication.ExtendedProtection.ChannelBinding GetChannelBinding(System.Security.Authentication.ExtendedProtection.ChannelBindingKind kind);
    }
    public partial class UploadDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        internal UploadDataCompletedEventArgs() : base (default(System.Exception), default(bool), default(object)) { }
        public byte[] Result { get { throw null; } }
    }
    public delegate void UploadDataCompletedEventHandler(object sender, System.Net.UploadDataCompletedEventArgs e);
    public partial class UploadFileCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        internal UploadFileCompletedEventArgs() : base (default(System.Exception), default(bool), default(object)) { }
        public byte[] Result { get { throw null; } }
    }
    public delegate void UploadFileCompletedEventHandler(object sender, System.Net.UploadFileCompletedEventArgs e);
    public partial class UploadProgressChangedEventArgs : System.ComponentModel.ProgressChangedEventArgs
    {
        internal UploadProgressChangedEventArgs() : base (default(int), default(object)) { }
        public long BytesReceived { get { throw null; } }
        public long BytesSent { get { throw null; } }
        public long TotalBytesToReceive { get { throw null; } }
        public long TotalBytesToSend { get { throw null; } }
    }
    public delegate void UploadProgressChangedEventHandler(object sender, System.Net.UploadProgressChangedEventArgs e);
    public partial class UploadStringCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        internal UploadStringCompletedEventArgs() : base (default(System.Exception), default(bool), default(object)) { }
        public string Result { get { throw null; } }
    }
    public delegate void UploadStringCompletedEventHandler(object sender, System.Net.UploadStringCompletedEventArgs e);
    public partial class UploadValuesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        internal UploadValuesCompletedEventArgs() : base (default(System.Exception), default(bool), default(object)) { }
        public byte[] Result { get { throw null; } }
    }
    public delegate void UploadValuesCompletedEventHandler(object sender, System.Net.UploadValuesCompletedEventArgs e);
    public partial class WebClient : System.ComponentModel.Component
    {
        public WebClient() { }
        public string BaseAddress { get { throw null; } set { } }
        public System.Net.Cache.RequestCachePolicy CachePolicy { get { throw null; } set { } }
        public System.Net.ICredentials Credentials { get { throw null; } set { } }
        public System.Text.Encoding Encoding { get { throw null; } set { } }
        public System.Net.WebHeaderCollection Headers { get { throw null; } set { } }
        public bool IsBusy { get { throw null; } }
        public System.Net.IWebProxy Proxy { get { throw null; } set { } }
        public System.Collections.Specialized.NameValueCollection QueryString { get { throw null; } set { } }
        public System.Net.WebHeaderCollection ResponseHeaders { get { throw null; } }
        public bool UseDefaultCredentials { get { throw null; } set { } }
        public event System.Net.DownloadDataCompletedEventHandler DownloadDataCompleted { add { } remove { } }
        public event System.ComponentModel.AsyncCompletedEventHandler DownloadFileCompleted { add { } remove { } }
        public event System.Net.DownloadProgressChangedEventHandler DownloadProgressChanged { add { } remove { } }
        public event System.Net.DownloadStringCompletedEventHandler DownloadStringCompleted { add { } remove { } }
        public event System.Net.OpenReadCompletedEventHandler OpenReadCompleted { add { } remove { } }
        public event System.Net.OpenWriteCompletedEventHandler OpenWriteCompleted { add { } remove { } }
        public event System.Net.UploadDataCompletedEventHandler UploadDataCompleted { add { } remove { } }
        public event System.Net.UploadFileCompletedEventHandler UploadFileCompleted { add { } remove { } }
        public event System.Net.UploadProgressChangedEventHandler UploadProgressChanged { add { } remove { } }
        public event System.Net.UploadStringCompletedEventHandler UploadStringCompleted { add { } remove { } }
        public event System.Net.UploadValuesCompletedEventHandler UploadValuesCompleted { add { } remove { } }
        public void CancelAsync() { }
        public byte[] DownloadData(string address) { throw null; }
        public byte[] DownloadData(System.Uri address) { throw null; }
        public void DownloadDataAsync(System.Uri address) { }
        public void DownloadDataAsync(System.Uri address, object userToken) { }
        public System.Threading.Tasks.Task<byte[]> DownloadDataTaskAsync(string address) { throw null; }
        public System.Threading.Tasks.Task<byte[]> DownloadDataTaskAsync(System.Uri address) { throw null; }
        public void DownloadFile(string address, string fileName) { }
        public void DownloadFile(System.Uri address, string fileName) { }
        public void DownloadFileAsync(System.Uri address, string fileName) { }
        public void DownloadFileAsync(System.Uri address, string fileName, object userToken) { }
        public System.Threading.Tasks.Task DownloadFileTaskAsync(string address, string fileName) { throw null; }
        public System.Threading.Tasks.Task DownloadFileTaskAsync(System.Uri address, string fileName) { throw null; }
        public string DownloadString(string address) { throw null; }
        public string DownloadString(System.Uri address) { throw null; }
        public void DownloadStringAsync(System.Uri address) { }
        public void DownloadStringAsync(System.Uri address, object userToken) { }
        public System.Threading.Tasks.Task<string> DownloadStringTaskAsync(string address) { throw null; }
        public System.Threading.Tasks.Task<string> DownloadStringTaskAsync(System.Uri address) { throw null; }
        protected virtual System.Net.WebRequest GetWebRequest(System.Uri address) { throw null; }
        protected virtual System.Net.WebResponse GetWebResponse(System.Net.WebRequest request) { throw null; }
        protected virtual System.Net.WebResponse GetWebResponse(System.Net.WebRequest request, System.IAsyncResult result) { throw null; }
        protected virtual void OnDownloadDataCompleted(System.Net.DownloadDataCompletedEventArgs e) { }
        protected virtual void OnDownloadFileCompleted(System.ComponentModel.AsyncCompletedEventArgs e) { }
        protected virtual void OnDownloadProgressChanged(System.Net.DownloadProgressChangedEventArgs e) { }
        protected virtual void OnDownloadStringCompleted(System.Net.DownloadStringCompletedEventArgs e) { }
        protected virtual void OnOpenReadCompleted(System.Net.OpenReadCompletedEventArgs e) { }
        protected virtual void OnOpenWriteCompleted(System.Net.OpenWriteCompletedEventArgs e) { }
        protected virtual void OnUploadDataCompleted(System.Net.UploadDataCompletedEventArgs e) { }
        protected virtual void OnUploadFileCompleted(System.Net.UploadFileCompletedEventArgs e) { }
        protected virtual void OnUploadProgressChanged(System.Net.UploadProgressChangedEventArgs e) { }
        protected virtual void OnUploadStringCompleted(System.Net.UploadStringCompletedEventArgs e) { }
        protected virtual void OnUploadValuesCompleted(System.Net.UploadValuesCompletedEventArgs e) { }
        public System.IO.Stream OpenRead(string address) { throw null; }
        public System.IO.Stream OpenRead(System.Uri address) { throw null; }
        public void OpenReadAsync(System.Uri address) { }
        public void OpenReadAsync(System.Uri address, object userToken) { }
        public System.Threading.Tasks.Task<System.IO.Stream> OpenReadTaskAsync(string address) { throw null; }
        public System.Threading.Tasks.Task<System.IO.Stream> OpenReadTaskAsync(System.Uri address) { throw null; }
        public System.IO.Stream OpenWrite(string address) { throw null; }
        public System.IO.Stream OpenWrite(string address, string method) { throw null; }
        public System.IO.Stream OpenWrite(System.Uri address) { throw null; }
        public System.IO.Stream OpenWrite(System.Uri address, string method) { throw null; }
        public void OpenWriteAsync(System.Uri address) { }
        public void OpenWriteAsync(System.Uri address, string method) { }
        public void OpenWriteAsync(System.Uri address, string method, object userToken) { }
        public System.Threading.Tasks.Task<System.IO.Stream> OpenWriteTaskAsync(string address) { throw null; }
        public System.Threading.Tasks.Task<System.IO.Stream> OpenWriteTaskAsync(string address, string method) { throw null; }
        public System.Threading.Tasks.Task<System.IO.Stream> OpenWriteTaskAsync(System.Uri address) { throw null; }
        public System.Threading.Tasks.Task<System.IO.Stream> OpenWriteTaskAsync(System.Uri address, string method) { throw null; }
        public byte[] UploadData(string address, byte[] data) { throw null; }
        public byte[] UploadData(string address, string method, byte[] data) { throw null; }
        public byte[] UploadData(System.Uri address, byte[] data) { throw null; }
        public byte[] UploadData(System.Uri address, string method, byte[] data) { throw null; }
        public void UploadDataAsync(System.Uri address, byte[] data) { }
        public void UploadDataAsync(System.Uri address, string method, byte[] data) { }
        public void UploadDataAsync(System.Uri address, string method, byte[] data, object userToken) { }
        public System.Threading.Tasks.Task<byte[]> UploadDataTaskAsync(string address, byte[] data) { throw null; }
        public System.Threading.Tasks.Task<byte[]> UploadDataTaskAsync(string address, string method, byte[] data) { throw null; }
        public System.Threading.Tasks.Task<byte[]> UploadDataTaskAsync(System.Uri address, byte[] data) { throw null; }
        public System.Threading.Tasks.Task<byte[]> UploadDataTaskAsync(System.Uri address, string method, byte[] data) { throw null; }
        public byte[] UploadFile(string address, string fileName) { throw null; }
        public byte[] UploadFile(string address, string method, string fileName) { throw null; }
        public byte[] UploadFile(System.Uri address, string fileName) { throw null; }
        public byte[] UploadFile(System.Uri address, string method, string fileName) { throw null; }
        public void UploadFileAsync(System.Uri address, string fileName) { }
        public void UploadFileAsync(System.Uri address, string method, string fileName) { }
        public void UploadFileAsync(System.Uri address, string method, string fileName, object userToken) { }
        public System.Threading.Tasks.Task<byte[]> UploadFileTaskAsync(string address, string fileName) { throw null; }
        public System.Threading.Tasks.Task<byte[]> UploadFileTaskAsync(string address, string method, string fileName) { throw null; }
        public System.Threading.Tasks.Task<byte[]> UploadFileTaskAsync(System.Uri address, string fileName) { throw null; }
        public System.Threading.Tasks.Task<byte[]> UploadFileTaskAsync(System.Uri address, string method, string fileName) { throw null; }
        public string UploadString(string address, string data) { throw null; }
        public string UploadString(string address, string method, string data) { throw null; }
        public string UploadString(System.Uri address, string data) { throw null; }
        public string UploadString(System.Uri address, string method, string data) { throw null; }
        public void UploadStringAsync(System.Uri address, string data) { }
        public void UploadStringAsync(System.Uri address, string method, string data) { }
        public void UploadStringAsync(System.Uri address, string method, string data, object userToken) { }
        public System.Threading.Tasks.Task<string> UploadStringTaskAsync(string address, string data) { throw null; }
        public System.Threading.Tasks.Task<string> UploadStringTaskAsync(string address, string method, string data) { throw null; }
        public System.Threading.Tasks.Task<string> UploadStringTaskAsync(System.Uri address, string data) { throw null; }
        public System.Threading.Tasks.Task<string> UploadStringTaskAsync(System.Uri address, string method, string data) { throw null; }
        public byte[] UploadValues(string address, System.Collections.Specialized.NameValueCollection data) { throw null; }
        public byte[] UploadValues(string address, string method, System.Collections.Specialized.NameValueCollection data) { throw null; }
        public byte[] UploadValues(System.Uri address, System.Collections.Specialized.NameValueCollection data) { throw null; }
        public byte[] UploadValues(System.Uri address, string method, System.Collections.Specialized.NameValueCollection data) { throw null; }
        public void UploadValuesAsync(System.Uri address, System.Collections.Specialized.NameValueCollection data) { }
        public void UploadValuesAsync(System.Uri address, string method, System.Collections.Specialized.NameValueCollection data) { }
        public void UploadValuesAsync(System.Uri address, string method, System.Collections.Specialized.NameValueCollection data, object userToken) { }
        public System.Threading.Tasks.Task<byte[]> UploadValuesTaskAsync(string address, System.Collections.Specialized.NameValueCollection data) { throw null; }
        public System.Threading.Tasks.Task<byte[]> UploadValuesTaskAsync(string address, string method, System.Collections.Specialized.NameValueCollection data) { throw null; }
        public System.Threading.Tasks.Task<byte[]> UploadValuesTaskAsync(System.Uri address, System.Collections.Specialized.NameValueCollection data) { throw null; }
        public System.Threading.Tasks.Task<byte[]> UploadValuesTaskAsync(System.Uri address, string method, System.Collections.Specialized.NameValueCollection data) { throw null; }
    }
    public partial class WebException : System.InvalidOperationException, System.Runtime.Serialization.ISerializable
    {
        public WebException() { }
        protected WebException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public WebException(string message) { }
        public WebException(string message, System.Exception innerException) { }
        public WebException(string message, System.Exception innerException, System.Net.WebExceptionStatus status, System.Net.WebResponse response) { }
        public WebException(string message, System.Net.WebExceptionStatus status) { }
        public System.Net.WebResponse Response { get { throw null; } }
        public System.Net.WebExceptionStatus Status { get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    }
    public enum WebExceptionStatus
    {
        CacheEntryNotFound = 18,
        ConnectFailure = 2,
        ConnectionClosed = 8,
        KeepAliveFailure = 12,
        MessageLengthLimitExceeded = 17,
        NameResolutionFailure = 1,
        Pending = 13,
        PipelineFailure = 5,
        ProtocolError = 7,
        ProxyNameResolutionFailure = 15,
        ReceiveFailure = 3,
        RequestCanceled = 6,
        RequestProhibitedByCachePolicy = 19,
        RequestProhibitedByProxy = 20,
        SecureChannelFailure = 10,
        SendFailure = 4,
        ServerProtocolViolation = 11,
        Success = 0,
        Timeout = 14,
        TrustFailure = 9,
        UnknownError = 16,
    }
    public partial class WebHeaderCollection : System.Collections.Specialized.NameValueCollection, System.Collections.IEnumerable, System.Runtime.Serialization.ISerializable
    {
        public WebHeaderCollection() { }
        protected WebHeaderCollection(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public override string[] AllKeys { get { throw null; } }
        public override int Count { get { throw null; } }
        public string this[System.Net.HttpRequestHeader header] { get { throw null; } set { } }
        public string this[System.Net.HttpResponseHeader header] { get { throw null; } set { } }
        public new string this[string name] { get { throw null; } set { } }
        public override System.Collections.Specialized.NameObjectCollectionBase.KeysCollection Keys { get { throw null; } }
        public void Add(System.Net.HttpRequestHeader header, string value) { }
        public void Add(System.Net.HttpResponseHeader header, string value) { }
        public void Add(string header) { }
        public override void Add(string name, string value) { }
        protected void AddWithoutValidate(string headerName, string headerValue) { }
        public override void Clear() { }
        public override string Get(int index) { throw null; }
        public override string Get(string name) { throw null; }
        public override System.Collections.IEnumerator GetEnumerator() { throw null; }
        public override string GetKey(int index) { throw null; }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public override string[] GetValues(int index) { throw null; }
        public override string[] GetValues(string header) { throw null; }
        public static bool IsRestricted(string headerName) { throw null; }
        public static bool IsRestricted(string headerName, bool response) { throw null; }
        public override void OnDeserialization(object sender) { }
        public void Remove(System.Net.HttpRequestHeader header) { }
        public void Remove(System.Net.HttpResponseHeader header) { }
        public override void Remove(string name) { }
        public void Set(System.Net.HttpRequestHeader header, string value) { }
        public void Set(System.Net.HttpResponseHeader header, string value) { }
        public override void Set(string name, string value) { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public byte[] ToByteArray() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class WebProxy : System.Net.IWebProxy, System.Runtime.Serialization.ISerializable
    {
        public WebProxy() { }
        protected WebProxy(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public WebProxy(string Address) { }
        public WebProxy(string Address, bool BypassOnLocal) { }
        public WebProxy(string Address, bool BypassOnLocal, string[] BypassList) { }
        public WebProxy(string Address, bool BypassOnLocal, string[] BypassList, System.Net.ICredentials Credentials) { }
        public WebProxy(string Host, int Port) { }
        public WebProxy(System.Uri Address) { }
        public WebProxy(System.Uri Address, bool BypassOnLocal) { }
        public WebProxy(System.Uri Address, bool BypassOnLocal, string[] BypassList) { }
        public WebProxy(System.Uri Address, bool BypassOnLocal, string[] BypassList, System.Net.ICredentials Credentials) { }
        public System.Uri Address { get { throw null; } set { } }
        public System.Collections.ArrayList BypassArrayList { get { throw null; } }
        public string[] BypassList { get { throw null; } set { } }
        public bool BypassProxyOnLocal { get { throw null; } set { } }
        public System.Net.ICredentials Credentials { get { throw null; } set { } }
        public bool UseDefaultCredentials { get { throw null; } set { } }
        [System.ObsoleteAttribute("This method has been deprecated. Please use the proxy selected for you by default. https://go.microsoft.com/fwlink/?linkid=14202")]
        public static System.Net.WebProxy GetDefaultProxy() { throw null; }
        protected virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public System.Uri GetProxy(System.Uri destination) { throw null; }
        public bool IsBypassed(System.Uri host) { throw null; }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    }
    public abstract partial class WebRequest : System.MarshalByRefObject, System.Runtime.Serialization.ISerializable
    {
        protected WebRequest() { }
        protected WebRequest(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public System.Net.Security.AuthenticationLevel AuthenticationLevel { get { throw null; } set { } }
        public virtual System.Net.Cache.RequestCachePolicy CachePolicy { get { throw null; } set { } }
        public virtual string ConnectionGroupName { get { throw null; } set { } }
        public virtual long ContentLength { get { throw null; } set { } }
        public virtual string ContentType { get { throw null; } set { } }
        public virtual System.Net.ICredentials Credentials { get { throw null; } set { } }
        public static System.Net.Cache.RequestCachePolicy DefaultCachePolicy { get { throw null; } set { } }
        public static System.Net.IWebProxy DefaultWebProxy { get { throw null; } set { } }
        public virtual System.Net.WebHeaderCollection Headers { get { throw null; } set { } }
        public System.Security.Principal.TokenImpersonationLevel ImpersonationLevel { get { throw null; } set { } }
        public virtual string Method { get { throw null; } set { } }
        public virtual bool PreAuthenticate { get { throw null; } set { } }
        public virtual System.Net.IWebProxy Proxy { get { throw null; } set { } }
        public virtual System.Uri RequestUri { get { throw null; } }
        public virtual int Timeout { get { throw null; } set { } }
        public virtual bool UseDefaultCredentials { get { throw null; } set { } }
        public virtual void Abort() { }
        public virtual System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, object state) { throw null; }
        public virtual System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state) { throw null; }
        public static System.Net.WebRequest Create(string requestUriString) { throw null; }
        public static System.Net.WebRequest Create(System.Uri requestUri) { throw null; }
        public static System.Net.WebRequest CreateDefault(System.Uri requestUri) { throw null; }
        public static System.Net.HttpWebRequest CreateHttp(string requestUriString) { throw null; }
        public static System.Net.HttpWebRequest CreateHttp(System.Uri requestUri) { throw null; }
        public virtual System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult) { throw null; }
        public virtual System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult) { throw null; }
        protected virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public virtual System.IO.Stream GetRequestStream() { throw null; }
        public virtual System.Threading.Tasks.Task<System.IO.Stream> GetRequestStreamAsync() { throw null; }
        public virtual System.Net.WebResponse GetResponse() { throw null; }
        public virtual System.Threading.Tasks.Task<System.Net.WebResponse> GetResponseAsync() { throw null; }
        public static System.Net.IWebProxy GetSystemWebProxy() { throw null; }
        public static bool RegisterPrefix(string prefix, System.Net.IWebRequestCreate creator) { throw null; }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    }
    public static partial class WebRequestMethods
    {
        public static partial class File
        {
            public const string DownloadFile = "GET";
            public const string UploadFile = "PUT";
        }
        public static partial class Ftp
        {
            public const string AppendFile = "APPE";
            public const string DeleteFile = "DELE";
            public const string DownloadFile = "RETR";
            public const string GetDateTimestamp = "MDTM";
            public const string GetFileSize = "SIZE";
            public const string ListDirectory = "NLST";
            public const string ListDirectoryDetails = "LIST";
            public const string MakeDirectory = "MKD";
            public const string PrintWorkingDirectory = "PWD";
            public const string RemoveDirectory = "RMD";
            public const string Rename = "RENAME";
            public const string UploadFile = "STOR";
            public const string UploadFileWithUniqueName = "STOU";
        }
        public static partial class Http
        {
            public const string Connect = "CONNECT";
            public const string Get = "GET";
            public const string Head = "HEAD";
            public const string MkCol = "MKCOL";
            public const string Post = "POST";
            public const string Put = "PUT";
        }
    }
    public abstract partial class WebResponse : System.MarshalByRefObject, System.IDisposable, System.Runtime.Serialization.ISerializable
    {
        protected WebResponse() { }
        protected WebResponse(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public virtual long ContentLength { get { throw null; } set { } }
        public virtual string ContentType { get { throw null; } set { } }
        public virtual System.Net.WebHeaderCollection Headers { get { throw null; } }
        public virtual bool IsFromCache { get { throw null; } }
        public virtual bool IsMutuallyAuthenticated { get { throw null; } }
        public virtual System.Uri ResponseUri { get { throw null; } }
        public virtual bool SupportsHeaders { get { throw null; } }
        public virtual void Close() { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        protected virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public virtual System.IO.Stream GetResponseStream() { throw null; }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    }
    public static partial class WebUtility
    {
        public static string HtmlDecode(string value) { throw null; }
        public static void HtmlDecode(string value, System.IO.TextWriter output) { }
        public static string HtmlEncode(string value) { throw null; }
        public static void HtmlEncode(string value, System.IO.TextWriter output) { }
        public static string UrlDecode(string encodedValue) { throw null; }
        public static byte[] UrlDecodeToBytes(byte[] encodedValue, int offset, int count) { throw null; }
        public static string UrlEncode(string value) { throw null; }
        public static byte[] UrlEncodeToBytes(byte[] value, int offset, int count) { throw null; }
    }
}
