# .NET Standard 1.4

[Overview](../versions.md) | [Previous](netstandard1.3.md) | [Next](netstandard1.5.md)

* [APIs](netstandard1.4_ref.md)
* [Diff with 1.3](netstandard1.4_diff.md)

## Platform Support

* .NET Core 1.0
* .NET Framework 4.6.1
* Mono 4.6
* Xamarin.iOS 10.0
* Xamarin.Android 7.0
* Universal Windows Platform 10

## What's new?

| Namespace                                     | #APIs |
|:----------------------------------------------|------:| 
| System.Security.Cryptography                  |    12 |
| System.Security.Cryptography.X509Certificates |     6 |

```diff
 namespace System.Security.Cryptography {
+    public abstract class ECDsa : AsymmetricAlgorithm {
+        protected ECDsa();
+        protected abstract byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm);
+        protected abstract byte[] HashData(Stream data, HashAlgorithmName hashAlgorithm);
+        public virtual byte[] SignData(byte[] data, HashAlgorithmName hashAlgorithm);
+        public virtual byte[] SignData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm);
+        public virtual byte[] SignData(Stream data, HashAlgorithmName hashAlgorithm);
+        public abstract byte[] SignHash(byte[] hash);
+        public bool VerifyData(byte[] data, byte[] signature, HashAlgorithmName hashAlgorithm);
+        public virtual bool VerifyData(byte[] data, int offset, int count, byte[] signature, HashAlgorithmName hashAlgorithm);
+        public bool VerifyData(Stream data, byte[] signature, HashAlgorithmName hashAlgorithm);
+        public abstract bool VerifyHash(byte[] hash, byte[] signature);
+    }
 }
 namespace System.Security.Cryptography.X509Certificates {
+    public static class ECDsaCertificateExtensions {
+        public static ECDsa GetECDsaPrivateKey(this X509Certificate2 certificate);
+        public static ECDsa GetECDsaPublicKey(this X509Certificate2 certificate);
+    }
     public enum X509ChainStatusFlags {
+        ExplicitDistrust = 67108864,
+        HasNotSupportedCriticalExtension = 134217728,
+        HasWeakSignature = 1048576,
     }
 }
```
