# System.Net.Security

``` diff
 namespace System.Net.Security {
     public class NegotiateStream : AuthenticatedStream {
+        public override Task FlushAsync(CancellationToken cancellationToken);
     }
     public class SslStream : AuthenticatedStream {
+        public virtual void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, bool checkCertificateRevocation);
+        public virtual Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, bool checkCertificateRevocation);
+        public virtual void AuthenticateAsServer(X509Certificate serverCertificate, bool clientCertificateRequired, bool checkCertificateRevocation);
+        public virtual Task AuthenticateAsServerAsync(X509Certificate serverCertificate, bool clientCertificateRequired, bool checkCertificateRevocation);
+        public virtual IAsyncResult BeginAuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState);
+        public virtual IAsyncResult BeginAuthenticateAsServer(X509Certificate serverCertificate, bool clientCertificateRequired, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState);
+        public override Task FlushAsync(CancellationToken cancellationToken);
+        public virtual Task ShutdownAsync();
     }
 }
```

