# System.Security.Cryptography.X509Certificates

``` diff
 namespace System.Security.Cryptography.X509Certificates {
+    public sealed class CertificateRequest {
+        public CertificateRequest(X500DistinguishedName subjectName, ECDsa key, HashAlgorithmName hashAlgorithm);
+        public CertificateRequest(X500DistinguishedName subjectName, RSA key, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding);
+        public CertificateRequest(X500DistinguishedName subjectName, PublicKey publicKey, HashAlgorithmName hashAlgorithm);
+        public CertificateRequest(string subjectName, ECDsa key, HashAlgorithmName hashAlgorithm);
+        public CertificateRequest(string subjectName, RSA key, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding);
+        public Collection<X509Extension> CertificateExtensions { get; }
+        public HashAlgorithmName HashAlgorithm { get; }
+        public PublicKey PublicKey { get; }
+        public X500DistinguishedName SubjectName { get; }
+        public X509Certificate2 Create(X500DistinguishedName issuerName, X509SignatureGenerator generator, DateTimeOffset notBefore, DateTimeOffset notAfter, byte[] serialNumber);
+        public X509Certificate2 Create(X509Certificate2 issuerCertificate, DateTimeOffset notBefore, DateTimeOffset notAfter, byte[] serialNumber);
+        public X509Certificate2 CreateSelfSigned(DateTimeOffset notBefore, DateTimeOffset notAfter);
+        public byte[] CreateSigningRequest();
+        public byte[] CreateSigningRequest(X509SignatureGenerator signatureGenerator);
+    }
+    public static class DSACertificateExtensions {
+        public static X509Certificate2 CopyWithPrivateKey(this X509Certificate2 certificate, DSA privateKey);
+        public static DSA GetDSAPrivateKey(this X509Certificate2 certificate);
+        public static DSA GetDSAPublicKey(this X509Certificate2 certificate);
+    }
     public static class ECDsaCertificateExtensions {
+        public static X509Certificate2 CopyWithPrivateKey(this X509Certificate2 certificate, ECDsa privateKey);
     }
     public static class RSACertificateExtensions {
+        public static X509Certificate2 CopyWithPrivateKey(this X509Certificate2 certificate, RSA privateKey);
     }
+    public sealed class SubjectAlternativeNameBuilder {
+        public SubjectAlternativeNameBuilder();
+        public void AddDnsName(string dnsName);
+        public void AddEmailAddress(string emailAddress);
+        public void AddIpAddress(IPAddress ipAddress);
+        public void AddUri(Uri uri);
+        public void AddUserPrincipalName(string upn);
+        public X509Extension Build(bool critical=false);
+    }
     public enum X509KeyStorageFlags {
+        EphemeralKeySet = 32,
     }
+    public abstract class X509SignatureGenerator {
+        protected X509SignatureGenerator();
+        public PublicKey PublicKey { get; }
+        protected abstract PublicKey BuildPublicKey();
+        public static X509SignatureGenerator CreateForECDsa(ECDsa key);
+        public static X509SignatureGenerator CreateForRSA(RSA key, RSASignaturePadding signaturePadding);
+        public abstract byte[] GetSignatureAlgorithmIdentifier(HashAlgorithmName hashAlgorithm);
+        public abstract byte[] SignData(byte[] data, HashAlgorithmName hashAlgorithm);
+    }
     public sealed class X509Store : IDisposable {
+        public X509Store(StoreName storeName, StoreLocation storeLocation, OpenFlags flags);
+        public X509Store(string storeName, StoreLocation storeLocation, OpenFlags flags);
+        public bool IsOpen { get; }
     }
 }
```

