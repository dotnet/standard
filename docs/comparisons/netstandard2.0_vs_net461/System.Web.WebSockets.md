# System.Web.WebSockets

``` diff
+namespace System.Web.WebSockets {
+    public sealed class AspNetWebSocket : WebSocket, IAsyncAbortableWebSocket {
+        public override Nullable<WebSocketCloseStatus> CloseStatus { get; }
+        public override string CloseStatusDescription { get; }
+        public override WebSocketState State { get; }
+        public override string SubProtocol { get; }
+        public override void Abort();
+        public override Task CloseAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken);
+        public override Task CloseOutputAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken);
+        public override void Dispose();
+        public override Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<byte> buffer, CancellationToken cancellationToken);
+        public override Task SendAsync(ArraySegment<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken);
+    }
+    public abstract class AspNetWebSocketContext : WebSocketContext {
+        protected AspNetWebSocketContext();
+        public virtual string AnonymousID { get; }
+        public virtual HttpApplicationStateBase Application { get; }
+        public virtual string ApplicationPath { get; }
+        public virtual Cache Cache { get; }
+        public virtual HttpClientCertificate ClientCertificate { get; }
+        public static int ConnectionCount { get; }
+        public override CookieCollection CookieCollection { get; }
+        public virtual HttpCookieCollection Cookies { get; }
+        public virtual string FilePath { get; }
+        public override NameValueCollection Headers { get; }
+        public override bool IsAuthenticated { get; }
+        public virtual bool IsClientConnected { get; }
+        public virtual bool IsDebuggingEnabled { get; }
+        public override bool IsLocal { get; }
+        public override bool IsSecureConnection { get; }
+        public virtual IDictionary Items { get; }
+        public virtual WindowsIdentity LogonUserIdentity { get; }
+        public override string Origin { get; }
+        public virtual string Path { get; }
+        public virtual string PathInfo { get; }
+        public virtual ProfileBase Profile { get; }
+        public virtual NameValueCollection QueryString { get; }
+        public virtual string RawUrl { get; }
+        public override Uri RequestUri { get; }
+        public override string SecWebSocketKey { get; }
+        public override IEnumerable<string> SecWebSocketProtocols { get; }
+        public override string SecWebSocketVersion { get; }
+        public virtual HttpServerUtilityBase Server { get; }
+        public virtual NameValueCollection ServerVariables { get; }
+        public virtual DateTime Timestamp { get; }
+        public virtual UnvalidatedRequestValuesBase Unvalidated { get; }
+        public virtual Uri UrlReferrer { get; }
+        public override IPrincipal User { get; }
+        public virtual string UserAgent { get; }
+        public virtual string UserHostAddress { get; }
+        public virtual string UserHostName { get; }
+        public virtual string[] UserLanguages { get; }
+        public override WebSocket WebSocket { get; }
+    }
+    public sealed class AspNetWebSocketOptions {
+        public AspNetWebSocketOptions();
+        public bool RequireSameOrigin { get; set; }
+        public string SubProtocol { get; set; }
+    }
+}
```

