// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Net.WebSockets
{
    public sealed partial class ClientWebSocket : System.Net.WebSockets.WebSocket
    {
        public ClientWebSocket() { }
        public override System.Nullable<System.Net.WebSockets.WebSocketCloseStatus> CloseStatus { get { throw null; } }
        public override string CloseStatusDescription { get { throw null; } }
        public System.Net.WebSockets.ClientWebSocketOptions Options { get { throw null; } }
        public override System.Net.WebSockets.WebSocketState State { get { throw null; } }
        public override string SubProtocol { get { throw null; } }
        public override void Abort() { }
        public override System.Threading.Tasks.Task CloseAsync(System.Net.WebSockets.WebSocketCloseStatus closeStatus, string statusDescription, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.Task CloseOutputAsync(System.Net.WebSockets.WebSocketCloseStatus closeStatus, string statusDescription, System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task ConnectAsync(System.Uri uri, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override void Dispose() { }
        public override System.Threading.Tasks.Task<System.Net.WebSockets.WebSocketReceiveResult> ReceiveAsync(System.ArraySegment<byte> buffer, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.Task SendAsync(System.ArraySegment<byte> buffer, System.Net.WebSockets.WebSocketMessageType messageType, bool endOfMessage, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public sealed partial class ClientWebSocketOptions
    {
        internal ClientWebSocketOptions() { }
        public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get { throw null; } set { } }
        public System.Net.CookieContainer Cookies { get { throw null; } set { } }
        public System.Net.ICredentials Credentials { get { throw null; } set { } }
        public System.TimeSpan KeepAliveInterval { get { throw null; } set { } }
        public System.Net.IWebProxy Proxy { get { throw null; } set { } }
        public bool UseDefaultCredentials { get { throw null; } set { } }
        public void AddSubProtocol(string subProtocol) { }
        public void SetBuffer(int receiveBufferSize, int sendBufferSize) { }
        public void SetBuffer(int receiveBufferSize, int sendBufferSize, System.ArraySegment<byte> buffer) { }
        public void SetRequestHeader(string headerName, string headerValue) { }
    }
    public partial class HttpListenerWebSocketContext : System.Net.WebSockets.WebSocketContext
    {
        internal HttpListenerWebSocketContext() { }
        public override System.Net.CookieCollection CookieCollection { get { throw null; } }
        public override System.Collections.Specialized.NameValueCollection Headers { get { throw null; } }
        public override bool IsAuthenticated { get { throw null; } }
        public override bool IsLocal { get { throw null; } }
        public override bool IsSecureConnection { get { throw null; } }
        public override string Origin { get { throw null; } }
        public override System.Uri RequestUri { get { throw null; } }
        public override string SecWebSocketKey { get { throw null; } }
        public override System.Collections.Generic.IEnumerable<string> SecWebSocketProtocols { get { throw null; } }
        public override string SecWebSocketVersion { get { throw null; } }
        public override System.Security.Principal.IPrincipal User { get { throw null; } }
        public override System.Net.WebSockets.WebSocket WebSocket { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ValueWebSocketReceiveResult
    {
        public ValueWebSocketReceiveResult(int count, System.Net.WebSockets.WebSocketMessageType messageType, bool endOfMessage) { throw null; }
        public int Count { get { throw null; } }
        public bool EndOfMessage { get { throw null; } }
        public System.Net.WebSockets.WebSocketMessageType MessageType { get { throw null; } }
    }
    public abstract partial class WebSocket : System.IDisposable
    {
        protected WebSocket() { }
        public abstract System.Nullable<System.Net.WebSockets.WebSocketCloseStatus> CloseStatus { get; }
        public abstract string CloseStatusDescription { get; }
        public static System.TimeSpan DefaultKeepAliveInterval { get { throw null; } }
        public abstract System.Net.WebSockets.WebSocketState State { get; }
        public abstract string SubProtocol { get; }
        public abstract void Abort();
        public abstract System.Threading.Tasks.Task CloseAsync(System.Net.WebSockets.WebSocketCloseStatus closeStatus, string statusDescription, System.Threading.CancellationToken cancellationToken);
        public abstract System.Threading.Tasks.Task CloseOutputAsync(System.Net.WebSockets.WebSocketCloseStatus closeStatus, string statusDescription, System.Threading.CancellationToken cancellationToken);
        public static System.ArraySegment<byte> CreateClientBuffer(int receiveBufferSize, int sendBufferSize) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public static System.Net.WebSockets.WebSocket CreateClientWebSocket(System.IO.Stream innerStream, string subProtocol, int receiveBufferSize, int sendBufferSize, System.TimeSpan keepAliveInterval, bool useZeroMaskingKey, System.ArraySegment<byte> internalBuffer) { throw null; }
        public static System.ArraySegment<byte> CreateServerBuffer(int receiveBufferSize) { throw null; }
        public abstract void Dispose();
        protected static bool IsStateTerminal(System.Net.WebSockets.WebSocketState state) { throw null; }
        public abstract System.Threading.Tasks.Task<System.Net.WebSockets.WebSocketReceiveResult> ReceiveAsync(System.ArraySegment<byte> buffer, System.Threading.CancellationToken cancellationToken);
        public virtual System.Threading.Tasks.ValueTask<System.Net.WebSockets.ValueWebSocketReceiveResult> ReceiveAsync(System.Memory<byte> buffer, System.Threading.CancellationToken cancellationToken) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public static void RegisterPrefixes() { }
        public abstract System.Threading.Tasks.Task SendAsync(System.ArraySegment<byte> buffer, System.Net.WebSockets.WebSocketMessageType messageType, bool endOfMessage, System.Threading.CancellationToken cancellationToken);
        public virtual System.Threading.Tasks.ValueTask SendAsync(System.ReadOnlyMemory<byte> buffer, System.Net.WebSockets.WebSocketMessageType messageType, bool endOfMessage, System.Threading.CancellationToken cancellationToken) { throw null; }
        protected static void ThrowOnInvalidState(System.Net.WebSockets.WebSocketState state, params System.Net.WebSockets.WebSocketState[] validStates) { }
    }
    public enum WebSocketCloseStatus
    {
        Empty = 1005,
        EndpointUnavailable = 1001,
        InternalServerError = 1011,
        InvalidMessageType = 1003,
        InvalidPayloadData = 1007,
        MandatoryExtension = 1010,
        MessageTooBig = 1009,
        NormalClosure = 1000,
        PolicyViolation = 1008,
        ProtocolError = 1002,
    }
    public abstract partial class WebSocketContext
    {
        protected WebSocketContext() { }
        public abstract System.Net.CookieCollection CookieCollection { get; }
        public abstract System.Collections.Specialized.NameValueCollection Headers { get; }
        public abstract bool IsAuthenticated { get; }
        public abstract bool IsLocal { get; }
        public abstract bool IsSecureConnection { get; }
        public abstract string Origin { get; }
        public abstract System.Uri RequestUri { get; }
        public abstract string SecWebSocketKey { get; }
        public abstract System.Collections.Generic.IEnumerable<string> SecWebSocketProtocols { get; }
        public abstract string SecWebSocketVersion { get; }
        public abstract System.Security.Principal.IPrincipal User { get; }
        public abstract System.Net.WebSockets.WebSocket WebSocket { get; }
    }
    public enum WebSocketError
    {
        ConnectionClosedPrematurely = 8,
        Faulted = 2,
        HeaderError = 7,
        InvalidMessageType = 1,
        InvalidState = 9,
        NativeError = 3,
        NotAWebSocket = 4,
        Success = 0,
        UnsupportedProtocol = 6,
        UnsupportedVersion = 5,
    }
    public sealed partial class WebSocketException : System.ComponentModel.Win32Exception
    {
        public WebSocketException() { }
        public WebSocketException(int nativeError) { }
        public WebSocketException(int nativeError, System.Exception innerException) { }
        public WebSocketException(int nativeError, string message) { }
        public WebSocketException(System.Net.WebSockets.WebSocketError error) { }
        public WebSocketException(System.Net.WebSockets.WebSocketError error, System.Exception innerException) { }
        public WebSocketException(System.Net.WebSockets.WebSocketError error, int nativeError) { }
        public WebSocketException(System.Net.WebSockets.WebSocketError error, int nativeError, System.Exception innerException) { }
        public WebSocketException(System.Net.WebSockets.WebSocketError error, int nativeError, string message) { }
        public WebSocketException(System.Net.WebSockets.WebSocketError error, int nativeError, string message, System.Exception innerException) { }
        public WebSocketException(System.Net.WebSockets.WebSocketError error, string message) { }
        public WebSocketException(System.Net.WebSockets.WebSocketError error, string message, System.Exception innerException) { }
        public WebSocketException(string message) { }
        public WebSocketException(string message, System.Exception innerException) { }
        public override int ErrorCode { get { throw null; } }
        public System.Net.WebSockets.WebSocketError WebSocketErrorCode { get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public enum WebSocketMessageType
    {
        Binary = 1,
        Close = 2,
        Text = 0,
    }
    public partial class WebSocketReceiveResult
    {
        public WebSocketReceiveResult(int count, System.Net.WebSockets.WebSocketMessageType messageType, bool endOfMessage) { }
        public WebSocketReceiveResult(int count, System.Net.WebSockets.WebSocketMessageType messageType, bool endOfMessage, System.Nullable<System.Net.WebSockets.WebSocketCloseStatus> closeStatus, string closeStatusDescription) { }
        public System.Nullable<System.Net.WebSockets.WebSocketCloseStatus> CloseStatus { get { throw null; } }
        public string CloseStatusDescription { get { throw null; } }
        public int Count { get { throw null; } }
        public bool EndOfMessage { get { throw null; } }
        public System.Net.WebSockets.WebSocketMessageType MessageType { get { throw null; } }
    }
    public enum WebSocketState
    {
        Aborted = 6,
        Closed = 5,
        CloseReceived = 4,
        CloseSent = 3,
        Connecting = 1,
        None = 0,
        Open = 2,
    }
}
