# System.Net.Http

``` diff
 namespace System.Net.Http {
     public class HttpClientHandler : HttpMessageHandler {
-        public bool CheckCertificateRevocationList { get; set; }

-        public X509CertificateCollection ClientCertificates { get; }

-        public ICredentials DefaultProxyCredentials { get; set; }

-        public int MaxConnectionsPerServer { get; set; }

-        public int MaxResponseHeadersLength { get; set; }

-        public IDictionary<string, object> Properties { get; }

-        public Func<HttpRequestMessage, X509Certificate2, X509Chain, SslPolicyErrors, bool> ServerCertificateCustomValidationCallback { get; set; }

-        public SslProtocols SslProtocols { get; set; }

     }
+    public class WebRequestHandler : HttpClientHandler {
+        public WebRequestHandler();
+        public bool AllowPipelining { get; set; }
+        public AuthenticationLevel AuthenticationLevel { get; set; }
+        public RequestCachePolicy CachePolicy { get; set; }
+        public X509CertificateCollection ClientCertificates { get; }
+        public TimeSpan ContinueTimeout { get; set; }
+        public TokenImpersonationLevel ImpersonationLevel { get; set; }
+        public int MaxResponseHeadersLength { get; set; }
+        public int ReadWriteTimeout { get; set; }
+        public RemoteCertificateValidationCallback ServerCertificateValidationCallback { get; set; }
+        public bool UnsafeAuthenticatedConnectionSharing { get; set; }
+    }
 }
```

