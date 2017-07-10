# System.Net.Http

``` diff
 namespace System.Net.Http {
+    public enum CookieUsePolicy {
+        IgnoreCookies = 0,
+        UseInternalCookieStoreOnly = 1,
+        UseSpecifiedCookieContainer = 2,
+    }
+    public enum WindowsProxyUsePolicy {
+        DoNotUseProxy = 0,
+        UseCustomProxy = 3,
+        UseWinHttpProxy = 1,
+        UseWinInetProxy = 2,
+    }
+    public class WinHttpHandler : HttpMessageHandler {
+        public WinHttpHandler();
+        public DecompressionMethods AutomaticDecompression { get; set; }
+        public bool AutomaticRedirection { get; set; }
+        public bool CheckCertificateRevocationList { get; set; }
+        public ClientCertificateOption ClientCertificateOption { get; set; }
+        public X509Certificate2Collection ClientCertificates { get; }
+        public CookieContainer CookieContainer { get; set; }
+        public CookieUsePolicy CookieUsePolicy { get; set; }
+        public ICredentials DefaultProxyCredentials { get; set; }
+        public int MaxAutomaticRedirections { get; set; }
+        public int MaxConnectionsPerServer { get; set; }
+        public int MaxResponseDrainSize { get; set; }
+        public int MaxResponseHeadersLength { get; set; }
+        public bool PreAuthenticate { get; set; }
+        public IDictionary<string, object> Properties { get; }
+        public IWebProxy Proxy { get; set; }
+        public TimeSpan ReceiveDataTimeout { get; set; }
+        public TimeSpan ReceiveHeadersTimeout { get; set; }
+        public TimeSpan SendTimeout { get; set; }
+        public Func<HttpRequestMessage, X509Certificate2, X509Chain, SslPolicyErrors, bool> ServerCertificateValidationCallback { get; set; }
+        public ICredentials ServerCredentials { get; set; }
+        public SslProtocols SslProtocols { get; set; }
+        public WindowsProxyUsePolicy WindowsProxyUsePolicy { get; set; }
+        protected override void Dispose(bool disposing);
+        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);
+    }
 }
```

