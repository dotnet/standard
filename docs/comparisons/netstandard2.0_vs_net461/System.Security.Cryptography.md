# System.Security.Cryptography

``` diff
 namespace System.Security.Cryptography {
+    public sealed class CngAlgorithm : IEquatable<CngAlgorithm> {
+        public CngAlgorithm(string algorithm);
+        public string Algorithm { get; }
+        public static CngAlgorithm ECDiffieHellmanP256 { get; }
+        public static CngAlgorithm ECDiffieHellmanP384 { get; }
+        public static CngAlgorithm ECDiffieHellmanP521 { get; }
+        public static CngAlgorithm ECDsaP256 { get; }
+        public static CngAlgorithm ECDsaP384 { get; }
+        public static CngAlgorithm ECDsaP521 { get; }
+        public static CngAlgorithm MD5 { get; }
+        public static CngAlgorithm Rsa { get; }
+        public static CngAlgorithm Sha1 { get; }
+        public static CngAlgorithm Sha256 { get; }
+        public static CngAlgorithm Sha384 { get; }
+        public static CngAlgorithm Sha512 { get; }
+        public override bool Equals(object obj);
+        public bool Equals(CngAlgorithm other);
+        public override int GetHashCode();
+        public static bool operator ==(CngAlgorithm left, CngAlgorithm right);
+        public static bool operator !=(CngAlgorithm left, CngAlgorithm right);
+        public override string ToString();
+    }
+    public sealed class CngAlgorithmGroup : IEquatable<CngAlgorithmGroup> {
+        public CngAlgorithmGroup(string algorithmGroup);
+        public string AlgorithmGroup { get; }
+        public static CngAlgorithmGroup DiffieHellman { get; }
+        public static CngAlgorithmGroup Dsa { get; }
+        public static CngAlgorithmGroup ECDiffieHellman { get; }
+        public static CngAlgorithmGroup ECDsa { get; }
+        public static CngAlgorithmGroup Rsa { get; }
+        public override bool Equals(object obj);
+        public bool Equals(CngAlgorithmGroup other);
+        public override int GetHashCode();
+        public static bool operator ==(CngAlgorithmGroup left, CngAlgorithmGroup right);
+        public static bool operator !=(CngAlgorithmGroup left, CngAlgorithmGroup right);
+        public override string ToString();
+    }
+    public enum CngExportPolicies {
+        AllowArchiving = 4,
+        AllowExport = 1,
+        AllowPlaintextArchiving = 8,
+        AllowPlaintextExport = 2,
+        None = 0,
+    }
+    public sealed class CngKey : IDisposable {
+        public CngAlgorithm Algorithm { get; }
+        public CngAlgorithmGroup AlgorithmGroup { get; }
+        public CngExportPolicies ExportPolicy { get; }
+        public SafeNCryptKeyHandle Handle { get; }
+        public bool IsEphemeral { get; private set; }
+        public bool IsMachineKey { get; }
+        public string KeyName { get; }
+        public int KeySize { get; }
+        public CngKeyUsages KeyUsage { get; }
+        public IntPtr ParentWindowHandle { get; set; }
+        public CngProvider Provider { get; }
+        public SafeNCryptProviderHandle ProviderHandle { get; }
+        public CngUIPolicy UIPolicy { get; }
+        public string UniqueName { get; }
+        public static CngKey Create(CngAlgorithm algorithm);
+        public static CngKey Create(CngAlgorithm algorithm, string keyName);
+        public static CngKey Create(CngAlgorithm algorithm, string keyName, CngKeyCreationParameters creationParameters);
+        public void Delete();
+        public void Dispose();
+        public static bool Exists(string keyName);
+        public static bool Exists(string keyName, CngProvider provider);
+        public static bool Exists(string keyName, CngProvider provider, CngKeyOpenOptions options);
+        public byte[] Export(CngKeyBlobFormat format);
+        public CngProperty GetProperty(string name, CngPropertyOptions options);
+        public bool HasProperty(string name, CngPropertyOptions options);
+        public static CngKey Import(byte[] keyBlob, CngKeyBlobFormat format);
+        public static CngKey Import(byte[] keyBlob, CngKeyBlobFormat format, CngProvider provider);
+        public static CngKey Open(SafeNCryptKeyHandle keyHandle, CngKeyHandleOpenOptions keyHandleOpenOptions);
+        public static CngKey Open(string keyName);
+        public static CngKey Open(string keyName, CngProvider provider);
+        public static CngKey Open(string keyName, CngProvider provider, CngKeyOpenOptions openOptions);
+        public void SetProperty(CngProperty property);
+    }
+    public sealed class CngKeyBlobFormat : IEquatable<CngKeyBlobFormat> {
+        public CngKeyBlobFormat(string format);
+        public static CngKeyBlobFormat EccPrivateBlob { get; }
+        public static CngKeyBlobFormat EccPublicBlob { get; }
+        public string Format { get; }
+        public static CngKeyBlobFormat GenericPrivateBlob { get; }
+        public static CngKeyBlobFormat GenericPublicBlob { get; }
+        public static CngKeyBlobFormat OpaqueTransportBlob { get; }
+        public static CngKeyBlobFormat Pkcs8PrivateBlob { get; }
+        public override bool Equals(object obj);
+        public bool Equals(CngKeyBlobFormat other);
+        public override int GetHashCode();
+        public static bool operator ==(CngKeyBlobFormat left, CngKeyBlobFormat right);
+        public static bool operator !=(CngKeyBlobFormat left, CngKeyBlobFormat right);
+        public override string ToString();
+    }
+    public enum CngKeyCreationOptions {
+        MachineKey = 32,
+        None = 0,
+        OverwriteExistingKey = 128,
+    }
+    public sealed class CngKeyCreationParameters {
+        public CngKeyCreationParameters();
+        public Nullable<CngExportPolicies> ExportPolicy { get; set; }
+        public CngKeyCreationOptions KeyCreationOptions { get; set; }
+        public Nullable<CngKeyUsages> KeyUsage { get; set; }
+        public CngPropertyCollection Parameters { get; }
+        public IntPtr ParentWindowHandle { get; set; }
+        public CngProvider Provider { get; set; }
+        public CngUIPolicy UIPolicy { get; set; }
+    }
+    public enum CngKeyHandleOpenOptions {
+        EphemeralKey = 1,
+        None = 0,
+    }
+    public enum CngKeyOpenOptions {
+        MachineKey = 32,
+        None = 0,
+        Silent = 64,
+        UserKey = 0,
+    }
+    public enum CngKeyUsages {
+        AllUsages = 16777215,
+        Decryption = 1,
+        KeyAgreement = 4,
+        None = 0,
+        Signing = 2,
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct CngProperty : IEquatable<CngProperty> {
+        public CngProperty(string name, byte[] value, CngPropertyOptions options);
+        public string Name { get; }
+        public CngPropertyOptions Options { get; }
+        public override bool Equals(object obj);
+        public bool Equals(CngProperty other);
+        public override int GetHashCode();
+        public byte[] GetValue();
+        public static bool operator ==(CngProperty left, CngProperty right);
+        public static bool operator !=(CngProperty left, CngProperty right);
+    }
+    public sealed class CngPropertyCollection : Collection<CngProperty> {
+        public CngPropertyCollection();
+    }
+    public enum CngPropertyOptions {
+        CustomProperty = 1073741824,
+        None = 0,
+        Persist = -2147483648,
+    }
+    public sealed class CngProvider : IEquatable<CngProvider> {
+        public CngProvider(string provider);
+        public static CngProvider MicrosoftSmartCardKeyStorageProvider { get; }
+        public static CngProvider MicrosoftSoftwareKeyStorageProvider { get; }
+        public string Provider { get; }
+        public override bool Equals(object obj);
+        public bool Equals(CngProvider other);
+        public override int GetHashCode();
+        public static bool operator ==(CngProvider left, CngProvider right);
+        public static bool operator !=(CngProvider left, CngProvider right);
+        public override string ToString();
+    }
+    public sealed class CngUIPolicy {
+        public CngUIPolicy(CngUIProtectionLevels protectionLevel);
+        public CngUIPolicy(CngUIProtectionLevels protectionLevel, string friendlyName);
+        public CngUIPolicy(CngUIProtectionLevels protectionLevel, string friendlyName, string description);
+        public CngUIPolicy(CngUIProtectionLevels protectionLevel, string friendlyName, string description, string useContext);
+        public CngUIPolicy(CngUIProtectionLevels protectionLevel, string friendlyName, string description, string useContext, string creationTitle);
+        public string CreationTitle { get; }
+        public string Description { get; }
+        public string FriendlyName { get; }
+        public CngUIProtectionLevels ProtectionLevel { get; }
+        public string UseContext { get; }
+    }
+    public enum CngUIProtectionLevels {
+        ForceHighProtection = 2,
+        None = 0,
+        ProtectKey = 1,
+    }
+    public sealed class CryptoAPITransform : ICryptoTransform, IDisposable {
+        public bool CanReuseTransform { get; }
+        public bool CanTransformMultipleBlocks { get; }
+        public int InputBlockSize { get; }
+        public IntPtr KeyHandle { get; }
+        public int OutputBlockSize { get; }
+        public void Clear();
+        public void Dispose();
+        public void Reset();
+        public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset);
+        public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount);
+    }
+    public sealed class CryptographicAttributeObject {
+        public CryptographicAttributeObject(Oid oid);
+        public CryptographicAttributeObject(Oid oid, AsnEncodedDataCollection values);
+        public Oid Oid { get; }
+        public AsnEncodedDataCollection Values { get; }
+    }
+    public sealed class CryptographicAttributeObjectCollection : ICollection, IEnumerable {
+        public CryptographicAttributeObjectCollection();
+        public CryptographicAttributeObjectCollection(CryptographicAttributeObject attribute);
+        public int Count { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        public CryptographicAttributeObject this[int index] { get; }
+        public int Add(AsnEncodedData asnEncodedData);
+        public int Add(CryptographicAttributeObject attribute);
+        public void CopyTo(CryptographicAttributeObject[] array, int index);
+        public CryptographicAttributeObjectEnumerator GetEnumerator();
+        public void Remove(CryptographicAttributeObject attribute);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+    }
+    public sealed class CryptographicAttributeObjectEnumerator : IEnumerator {
+        public CryptographicAttributeObject Current { get; }
+        object System.Collections.IEnumerator.Current { get; }
+        public bool MoveNext();
+        public void Reset();
+    }
     public sealed class CspKeyContainerInfo {
+        public CryptoKeySecurity CryptoKeySecurity { get; }
     }
     public sealed class CspParameters {
+        public CspParameters(int providerType, string providerName, string keyContainerName, CryptoKeySecurity cryptoKeySecurity, IntPtr parentWindowHandle);
+        public CspParameters(int providerType, string providerName, string keyContainerName, CryptoKeySecurity cryptoKeySecurity, SecureString keyPassword);
+        public CryptoKeySecurity CryptoKeySecurity { get; set; }
     }
+    public enum DataProtectionScope {
+        CurrentUser = 0,
+        LocalMachine = 1,
+    }
+    public abstract class DataProtector {
+        protected DataProtector(string applicationName, string primaryPurpose, string[] specificPurposes);
+        protected string ApplicationName { get; }
+        protected virtual bool PrependHashedPurposeToPlaintext { get; }
+        protected string PrimaryPurpose { get; }
+        protected IEnumerable<string> SpecificPurposes { get; }
+        public static DataProtector Create(string providerClass, string applicationName, string primaryPurpose, params string[] specificPurposes);
+        protected virtual byte[] GetHashedPurpose();
+        public abstract bool IsReprotectRequired(byte[] encryptedData);
+        public byte[] Protect(byte[] userData);
+        protected abstract byte[] ProviderProtect(byte[] userData);
+        protected abstract byte[] ProviderUnprotect(byte[] encryptedData);
+        public byte[] Unprotect(byte[] encryptedData);
+    }
+    public sealed class DpapiDataProtector : DataProtector {
+        public DpapiDataProtector(string appName, string primaryPurpose, params string[] specificPurpose);
+        protected override bool PrependHashedPurposeToPlaintext { get; }
+        public DataProtectionScope Scope { get; set; }
+        public override bool IsReprotectRequired(byte[] encryptedData);
+        protected override byte[] ProviderProtect(byte[] userData);
+        protected override byte[] ProviderUnprotect(byte[] encryptedData);
+    }
-    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
-    public struct ECCurve {
 {
-        public ECCurve.ECCurveType CurveType;

-        public byte[] A;

-        public byte[] B;

-        public byte[] Cofactor;

-        public byte[] Order;

-        public byte[] Polynomial;

-        public byte[] Prime;

-        public byte[] Seed;

-        public Nullable<HashAlgorithmName> Hash;

-        public ECPoint G;

-        public bool IsCharacteristic2 { get; }

-        public bool IsExplicit { get; }

-        public bool IsNamed { get; }

-        public bool IsPrime { get; }

-        public Oid Oid { get; }

-        public static ECCurve CreateFromFriendlyName(string oidFriendlyName);

-        public static ECCurve CreateFromOid(Oid curveOid);

-        public static ECCurve CreateFromValue(string oidValue);

-        public void Validate();

-        public enum ECCurveType {
 {
-            Characteristic2 = 4,

-            Implicit = 0,

-            Named = 5,

-            PrimeMontgomery = 3,

-            PrimeShortWeierstrass = 1,

-            PrimeTwistedEdwards = 2,

-        }
-        public static class NamedCurves {
 {
-            public static ECCurve brainpoolP160r1 { get; }

-            public static ECCurve brainpoolP160t1 { get; }

-            public static ECCurve brainpoolP192r1 { get; }

-            public static ECCurve brainpoolP192t1 { get; }

-            public static ECCurve brainpoolP224r1 { get; }

-            public static ECCurve brainpoolP224t1 { get; }

-            public static ECCurve brainpoolP256r1 { get; }

-            public static ECCurve brainpoolP256t1 { get; }

-            public static ECCurve brainpoolP320r1 { get; }

-            public static ECCurve brainpoolP320t1 { get; }

-            public static ECCurve brainpoolP384r1 { get; }

-            public static ECCurve brainpoolP384t1 { get; }

-            public static ECCurve brainpoolP512r1 { get; }

-            public static ECCurve brainpoolP512t1 { get; }

-            public static ECCurve nistP256 { get; }

-            public static ECCurve nistP384 { get; }

-            public static ECCurve nistP521 { get; }

-        }
-    }
+    public abstract class ECDiffieHellman : AsymmetricAlgorithm {
+        protected ECDiffieHellman();
+        public override string KeyExchangeAlgorithm { get; }
+        public abstract ECDiffieHellmanPublicKey PublicKey { get; }
+        public override string SignatureAlgorithm { get; }
+        public static new ECDiffieHellman Create();
+        public static new ECDiffieHellman Create(string algorithm);
+        public abstract byte[] DeriveKeyMaterial(ECDiffieHellmanPublicKey otherPartyPublicKey);
+    }
+    public sealed class ECDiffieHellmanCng : ECDiffieHellman {
+        public ECDiffieHellmanCng();
+        public ECDiffieHellmanCng(int keySize);
+        public ECDiffieHellmanCng(CngKey key);
+        public CngAlgorithm HashAlgorithm { get; set; }
+        public byte[] HmacKey { get; set; }
+        public CngKey Key { get; private set; }
+        public ECDiffieHellmanKeyDerivationFunction KeyDerivationFunction { get; set; }
+        public byte[] Label { get; set; }
+        public override ECDiffieHellmanPublicKey PublicKey { get; }
+        public byte[] SecretAppend { get; set; }
+        public byte[] SecretPrepend { get; set; }
+        public byte[] Seed { get; set; }
+        public bool UseSecretAgreementAsHmacKey { get; }
+        public byte[] DeriveKeyMaterial(CngKey otherPartyPublicKey);
+        public override byte[] DeriveKeyMaterial(ECDiffieHellmanPublicKey otherPartyPublicKey);
+        public SafeNCryptSecretHandle DeriveSecretAgreementHandle(CngKey otherPartyPublicKey);
+        public SafeNCryptSecretHandle DeriveSecretAgreementHandle(ECDiffieHellmanPublicKey otherPartyPublicKey);
+        protected override void Dispose(bool disposing);
+        public override void FromXmlString(string xmlString);
+        public void FromXmlString(string xml, ECKeyXmlFormat format);
+        public override string ToXmlString(bool includePrivateParameters);
+        public string ToXmlString(ECKeyXmlFormat format);
+    }
+    public sealed class ECDiffieHellmanCngPublicKey : ECDiffieHellmanPublicKey {
+        public CngKeyBlobFormat BlobFormat { get; }
+        protected override void Dispose(bool disposing);
+        public static ECDiffieHellmanPublicKey FromByteArray(byte[] publicKeyBlob, CngKeyBlobFormat format);
+        public static ECDiffieHellmanCngPublicKey FromXmlString(string xml);
+        public CngKey Import();
+        public override string ToXmlString();
+    }
+    public enum ECDiffieHellmanKeyDerivationFunction {
+        Hash = 0,
+        Hmac = 1,
+        Tls = 2,
+    }
     public abstract class ECDsa : AsymmetricAlgorithm {
-        public static ECDsa Create(ECCurve curve);

-        public static ECDsa Create(ECParameters parameters);

-        public virtual ECParameters ExportExplicitParameters(bool includePrivateParameters);

-        public virtual ECParameters ExportParameters(bool includePrivateParameters);

-        public virtual void GenerateKey(ECCurve curve);

-        public virtual void ImportParameters(ECParameters parameters);

     }
+    public sealed class ECDsaCng : ECDsa {
+        public ECDsaCng();
+        public ECDsaCng(int keySize);
+        public ECDsaCng(CngKey key);
+        public CngAlgorithm HashAlgorithm { get; set; }
+        public CngKey Key { get; private set; }
+        protected override void Dispose(bool disposing);
+        public override void FromXmlString(string xmlString);
+        public void FromXmlString(string xml, ECKeyXmlFormat format);
+        protected override byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm);
+        protected override byte[] HashData(Stream data, HashAlgorithmName hashAlgorithm);
+        public byte[] SignData(byte[] data);
+        public byte[] SignData(byte[] data, int offset, int count);
+        public byte[] SignData(Stream data);
+        public override byte[] SignHash(byte[] hash);
+        public override string ToXmlString(bool includePrivateParameters);
+        public string ToXmlString(ECKeyXmlFormat format);
+        public bool VerifyData(byte[] data, byte[] signature);
+        public bool VerifyData(byte[] data, int offset, int count, byte[] signature);
+        public bool VerifyData(Stream data, byte[] signature);
+        public override bool VerifyHash(byte[] hash, byte[] signature);
+    }
+    public enum ECKeyXmlFormat {
+        Rfc4050 = 0,
+    }
-    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
-    public struct ECParameters {
 {
-        public byte[] D;

-        public ECCurve Curve;

-        public ECPoint Q;

-        public void Validate();

-    }
-    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
-    public struct ECPoint {
 {
-        public byte[] X;

-        public byte[] Y;

-    }
+    public class HMACRIPEMD160 : HMAC {
+        public HMACRIPEMD160();
+        public HMACRIPEMD160(byte[] key);
+    }
-    public sealed class IncrementalHash : IDisposable {
 {
-        public HashAlgorithmName AlgorithmName { get; }

-        public void AppendData(byte[] data);

-        public void AppendData(byte[] data, int offset, int count);

-        public static IncrementalHash CreateHash(HashAlgorithmName hashAlgorithm);

-        public static IncrementalHash CreateHMAC(HashAlgorithmName hashAlgorithm, byte[] key);

-        public void Dispose();

-        public byte[] GetHashAndReset();

-    }
+    public class MACTripleDES : KeyedHashAlgorithm {
+        public MACTripleDES();
+        public MACTripleDES(byte[] rgbKey);
+        public MACTripleDES(string strTripleDES, byte[] rgbKey);
+        public PaddingMode Padding { get; set; }
+        protected override void Dispose(bool disposing);
+        protected override void HashCore(byte[] rgbData, int ibStart, int cbSize);
+        protected override byte[] HashFinal();
+        public override void Initialize();
+    }
+    public sealed class ManifestSignatureInformation {
+        public AuthenticodeSignatureInformation AuthenticodeSignature { get; }
+        public ManifestKinds Manifest { get; }
+        public StrongNameSignatureInformation StrongNameSignature { get; }
+        public static ManifestSignatureInformationCollection VerifySignature(ActivationContext application);
+        public static ManifestSignatureInformationCollection VerifySignature(ActivationContext application, ManifestKinds manifests);
+        public static ManifestSignatureInformationCollection VerifySignature(ActivationContext application, ManifestKinds manifests, X509RevocationFlag revocationFlag, X509RevocationMode revocationMode);
+    }
+    public sealed class ManifestSignatureInformationCollection : ReadOnlyCollection<ManifestSignatureInformation>
+    public sealed class MD5Cng : MD5 {
+        public MD5Cng();
+        protected override void Dispose(bool disposing);
+        protected override void HashCore(byte[] array, int ibStart, int cbSize);
+        protected override byte[] HashFinal();
+        public override void Initialize();
+    }
+    public enum MemoryProtectionScope {
+        CrossProcess = 1,
+        SameLogon = 2,
+        SameProcess = 0,
+    }
+    public static class ProtectedData {
+        public static byte[] Protect(byte[] userData, byte[] optionalEntropy, DataProtectionScope scope);
+        public static byte[] Unprotect(byte[] encryptedData, byte[] optionalEntropy, DataProtectionScope scope);
+    }
+    public static class ProtectedMemory {
+        public static void Protect(byte[] userData, MemoryProtectionScope scope);
+        public static void Unprotect(byte[] encryptedData, MemoryProtectionScope scope);
+    }
+    public sealed class RijndaelManagedTransform : ICryptoTransform, IDisposable {
+        public int BlockSizeValue { get; }
+        public bool CanReuseTransform { get; }
+        public bool CanTransformMultipleBlocks { get; }
+        public int InputBlockSize { get; }
+        public int OutputBlockSize { get; }
+        public void Clear();
+        public void Dispose();
+        public void Reset();
+        public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset);
+        public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount);
+    }
+    public abstract class RIPEMD160 : HashAlgorithm {
+        protected RIPEMD160();
+        public static new RIPEMD160 Create();
+        public static new RIPEMD160 Create(string hashName);
+    }
+    public class RIPEMD160Managed : RIPEMD160 {
+        public RIPEMD160Managed();
+        protected override void HashCore(byte[] rgb, int ibStart, int cbSize);
+        protected override byte[] HashFinal();
+        public override void Initialize();
+    }
+    public sealed class RSACng : RSA {
+        public RSACng();
+        public RSACng(int keySize);
+        public RSACng(CngKey key);
+        public CngKey Key { get; private set; }
+        public override byte[] Decrypt(byte[] data, RSAEncryptionPadding padding);
+        protected override void Dispose(bool disposing);
+        public override byte[] Encrypt(byte[] data, RSAEncryptionPadding padding);
+        public override RSAParameters ExportParameters(bool includePrivateParameters);
+        protected override byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm);
+        protected override byte[] HashData(Stream data, HashAlgorithmName hashAlgorithm);
+        public override void ImportParameters(RSAParameters parameters);
+        public override byte[] SignHash(byte[] hash, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding);
+        public override bool VerifyHash(byte[] hash, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding);
+    }
+    public sealed class SHA1Cng : SHA1 {
+        public SHA1Cng();
+        protected override void Dispose(bool disposing);
+        protected override void HashCore(byte[] array, int ibStart, int cbSize);
+        protected override byte[] HashFinal();
+        public override void Initialize();
+    }
-    public sealed class SHA1Managed : SHA1
+    public class SHA1Managed : SHA1
+    public sealed class SHA256Cng : SHA256 {
+        public SHA256Cng();
+        protected override void Dispose(bool disposing);
+        protected override void HashCore(byte[] array, int ibStart, int cbSize);
+        protected override byte[] HashFinal();
+        public override void Initialize();
+    }
-    public sealed class SHA256Managed : SHA256
+    public class SHA256Managed : SHA256
+    public sealed class SHA384Cng : SHA384 {
+        public SHA384Cng();
+        protected override void Dispose(bool disposing);
+        protected override void HashCore(byte[] array, int ibStart, int cbSize);
+        protected override byte[] HashFinal();
+        public override void Initialize();
+    }
-    public sealed class SHA384Managed : SHA384
+    public class SHA384Managed : SHA384
+    public sealed class SHA512Cng : SHA512 {
+        public SHA512Cng();
+        protected override void Dispose(bool disposing);
+        protected override void HashCore(byte[] array, int ibStart, int cbSize);
+        protected override byte[] HashFinal();
+        public override void Initialize();
+    }
-    public sealed class SHA512Managed : SHA512
+    public class SHA512Managed : SHA512
+    public enum SignatureVerificationResult {
+        AssemblyIdentityMismatch = 1,
+        BadDigest = -2146869232,
+        BadSignatureFormat = -2146762749,
+        BasicConstraintsNotObserved = -2146869223,
+        CertificateExpired = -2146762495,
+        CertificateExplicitlyDistrusted = -2146762479,
+        CertificateMalformed = -2146762488,
+        CertificateNotExplicitlyTrusted = -2146762748,
+        CertificateRevoked = -2146762484,
+        CertificateUsageNotAllowed = -2146762490,
+        ContainingSignatureInvalid = 2,
+        CouldNotBuildChain = -2146762486,
+        GenericTrustFailure = -2146762485,
+        InvalidCertificateName = -2146762476,
+        InvalidCertificatePolicy = -2146762477,
+        InvalidCertificateRole = -2146762493,
+        InvalidCertificateSignature = -2146869244,
+        InvalidCertificateUsage = -2146762480,
+        InvalidCountersignature = -2146869245,
+        InvalidSignerCertificate = -2146869246,
+        InvalidTimePeriodNesting = -2146762494,
+        InvalidTimestamp = -2146869243,
+        IssuerChainingError = -2146762489,
+        MissingSignature = -2146762496,
+        PathLengthConstraintViolated = -2146762492,
+        PublicKeyTokenMismatch = 3,
+        PublisherMismatch = 4,
+        RevocationCheckFailure = -2146762482,
+        SystemError = -2146869247,
+        UnknownCriticalExtension = -2146762491,
+        UnknownTrustProvider = -2146762751,
+        UnknownVerificationAction = -2146762750,
+        UntrustedCertificationAuthority = -2146762478,
+        UntrustedRootCertificate = -2146762487,
+        UntrustedTestRootCertificate = -2146762483,
+        Valid = 0,
+    }
+    public sealed class StrongNameSignatureInformation {
+        public string HashAlgorithm { get; }
+        public int HResult { get; }
+        public bool IsValid { get; }
+        public AsymmetricAlgorithm PublicKey { get; }
+        public SignatureVerificationResult VerificationResult { get; }
+    }
 }
```

