# System.Security.Cryptography.X509Certificates

``` diff
 namespace System.Security.Cryptography.X509Certificates {
+    public sealed class AuthenticodeSignatureInformation {
+        public string Description { get; }
+        public Uri DescriptionUrl { get; }
+        public string HashAlgorithm { get; }
+        public int HResult { get; }
+        public X509Chain SignatureChain { get; }
+        public X509Certificate2 SigningCertificate { get; }
+        public TimestampInformation Timestamp { get; }
+        public TrustStatus TrustStatus { get; }
+        public SignatureVerificationResult VerificationResult { get; }
+    }
+    public sealed class TimestampInformation {
+        public string HashAlgorithm { get; }
+        public int HResult { get; }
+        public bool IsValid { get; }
+        public X509Chain SignatureChain { get; }
+        public X509Certificate2 SigningCertificate { get; }
+        public DateTime Timestamp { get; }
+        public SignatureVerificationResult VerificationResult { get; }
+    }
+    public enum TrustStatus {
+        KnownIdentity = 2,
+        Trusted = 3,
+        UnknownIdentity = 1,
+        Untrusted = 0,
+    }
+    public static class X509Certificate2UI {
+        public static void DisplayCertificate(X509Certificate2 certificate);
+        public static void DisplayCertificate(X509Certificate2 certificate, IntPtr hwndParent);
+        public static X509Certificate2Collection SelectFromCollection(X509Certificate2Collection certificates, string title, string message, X509SelectionFlag selectionFlag);
+        public static X509Certificate2Collection SelectFromCollection(X509Certificate2Collection certificates, string title, string message, X509SelectionFlag selectionFlag, IntPtr hwndParent);
+    }
+    public enum X509SelectionFlag {
+        MultiSelection = 1,
+        SingleSelection = 0,
+    }
 }
```

