/*
APIs removed/broken by this factoring:

// Below APIs don't exist in Xamarin so removing from netstandard
    public partial class CryptoConfig
    {
//CRYPTO        public static void AddAlgorithm(System.Type algorithm, params string[] names) { }
//CRYPTO        public static void AddOID(string oid, params string[] names) { }
    }
    public sealed partial class RC2CryptoServiceProvider : System.Security.Cryptography.RC2
    {
//CRYPTO        public bool UseSalt { get { throw null; } set { } }
    }
    public partial class Rfc2898DeriveBytes : System.Security.Cryptography.DeriveBytes
    {
//CRYPTO        public byte[] CryptDeriveKey(string algname, string alghashname, int keySize, byte[] rgbIV) { throw null; }
    }
    public sealed partial class RNGCryptoServiceProvider : System.Security.Cryptography.RandomNumberGenerator
    {
//CRYPTO        public RNGCryptoServiceProvider(byte[] rgb) { }
//CRYPTO        public RNGCryptoServiceProvider(System.Security.Cryptography.CspParameters cspParams) { }
//CRYPTO        public RNGCryptoServiceProvider(string str) { }
    }
*/
namespace System.Security.Cryptography
{
    public sealed partial class CryptoAPITransform : System.IDisposable, System.Security.Cryptography.ICryptoTransform
    {
        internal CryptoAPITransform() { }
        public bool CanReuseTransform { get { throw null; } }
        public bool CanTransformMultipleBlocks { get { throw null; } }
        public int InputBlockSize { get { throw null; } }
        public System.IntPtr KeyHandle { get { throw null; } }
        public int OutputBlockSize { get { throw null; } }
        public void Clear() { }
        public void Dispose() { }
        public void Reset() { }
        public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { throw null; }
        public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { throw null; }
    }
    public abstract partial class ECDiffieHellman : System.Security.Cryptography.AsymmetricAlgorithm
    {
        protected ECDiffieHellman() { }
        public override string KeyExchangeAlgorithm { get { throw null; } }
        public abstract System.Security.Cryptography.ECDiffieHellmanPublicKey PublicKey { get; }
        public override string SignatureAlgorithm { get { throw null; } }
        public static new System.Security.Cryptography.ECDiffieHellman Create() { throw null; }
        public static new System.Security.Cryptography.ECDiffieHellman Create(string algorithm) { throw null; }
        public abstract byte[] DeriveKeyMaterial(System.Security.Cryptography.ECDiffieHellmanPublicKey otherPartyPublicKey);
    }
    public sealed partial class ECDiffieHellmanCng : System.Security.Cryptography.ECDiffieHellman
    {
        public ECDiffieHellmanCng() { }
        public ECDiffieHellmanCng(int keySize) { }
        public ECDiffieHellmanCng(System.Security.Cryptography.CngKey key) { }
        public System.Security.Cryptography.CngAlgorithm HashAlgorithm { get { throw null; } set { } }
        public byte[] HmacKey { get { throw null; } set { } }
        public System.Security.Cryptography.CngKey Key { get { throw null; } }
        public System.Security.Cryptography.ECDiffieHellmanKeyDerivationFunction KeyDerivationFunction { get { throw null; } set { } }
        public byte[] Label { get { throw null; } set { } }
        public override System.Security.Cryptography.ECDiffieHellmanPublicKey PublicKey { get { throw null; } }
        public byte[] SecretAppend { get { throw null; } set { } }
        public byte[] SecretPrepend { get { throw null; } set { } }
        public byte[] Seed { get { throw null; } set { } }
        public bool UseSecretAgreementAsHmacKey { get { throw null; } }
        public byte[] DeriveKeyMaterial(System.Security.Cryptography.CngKey otherPartyPublicKey) { throw null; }
        public override byte[] DeriveKeyMaterial(System.Security.Cryptography.ECDiffieHellmanPublicKey otherPartyPublicKey) { throw null; }
        public Microsoft.Win32.SafeHandles.SafeNCryptSecretHandle DeriveSecretAgreementHandle(System.Security.Cryptography.CngKey otherPartyPublicKey) { throw null; }
        public Microsoft.Win32.SafeHandles.SafeNCryptSecretHandle DeriveSecretAgreementHandle(System.Security.Cryptography.ECDiffieHellmanPublicKey otherPartyPublicKey) { throw null; }
        protected override void Dispose(bool disposing) { }
        public override void FromXmlString(string xmlString) { }
        public void FromXmlString(string xml, System.Security.Cryptography.ECKeyXmlFormat format) { }
        public override string ToXmlString(bool includePrivateParameters) { throw null; }
        public string ToXmlString(System.Security.Cryptography.ECKeyXmlFormat format) { throw null; }
    }
    public sealed partial class ECDiffieHellmanCngPublicKey : System.Security.Cryptography.ECDiffieHellmanPublicKey
    {
        internal ECDiffieHellmanCngPublicKey() : base (default(byte[])) { }
        public System.Security.Cryptography.CngKeyBlobFormat BlobFormat { get { throw null; } }
        protected override void Dispose(bool disposing) { }
        public static System.Security.Cryptography.ECDiffieHellmanPublicKey FromByteArray(byte[] publicKeyBlob, System.Security.Cryptography.CngKeyBlobFormat format) { throw null; }
        public static System.Security.Cryptography.ECDiffieHellmanCngPublicKey FromXmlString(string xml) { throw null; }
        public System.Security.Cryptography.CngKey Import() { throw null; }
        public override string ToXmlString() { throw null; }
    }
    public enum ECDiffieHellmanKeyDerivationFunction
    {
        Hash = 0,
        Hmac = 1,
        Tls = 2,
    }
    public sealed partial class ECDsaCng : System.Security.Cryptography.ECDsa
    {
        public ECDsaCng() { }
        public ECDsaCng(int keySize) { }
        public ECDsaCng(System.Security.Cryptography.CngKey key) { }
        public System.Security.Cryptography.CngAlgorithm HashAlgorithm { get { throw null; } set { } }
        public System.Security.Cryptography.CngKey Key { get { throw null; } }
        protected override void Dispose(bool disposing) { }
        public override void FromXmlString(string xmlString) { }
        public void FromXmlString(string xml, System.Security.Cryptography.ECKeyXmlFormat format) { }
        protected override byte[] HashData(byte[] data, int offset, int count, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { throw null; }
        protected override byte[] HashData(System.IO.Stream data, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { throw null; }
        public byte[] SignData(byte[] data) { throw null; }
        public byte[] SignData(byte[] data, int offset, int count) { throw null; }
        public byte[] SignData(System.IO.Stream data) { throw null; }
        public override byte[] SignHash(byte[] hash) { throw null; }
        public override string ToXmlString(bool includePrivateParameters) { throw null; }
        public string ToXmlString(System.Security.Cryptography.ECKeyXmlFormat format) { throw null; }
        public bool VerifyData(byte[] data, byte[] signature) { throw null; }
        public bool VerifyData(byte[] data, int offset, int count, byte[] signature) { throw null; }
        public bool VerifyData(System.IO.Stream data, byte[] signature) { throw null; }
        public override bool VerifyHash(byte[] hash, byte[] signature) { throw null; }
    }
    public enum ECKeyXmlFormat
    {
        Rfc4050 = 0,
    }
    public partial class HMACRIPEMD160 : System.Security.Cryptography.HMAC
    {
        public HMACRIPEMD160() { }
        public HMACRIPEMD160(byte[] key) { }
    }
    public partial class MACTripleDES : System.Security.Cryptography.KeyedHashAlgorithm
    {
        public MACTripleDES() { }
        public MACTripleDES(byte[] rgbKey) { }
        public MACTripleDES(string strTripleDES, byte[] rgbKey) { }
        public System.Security.Cryptography.PaddingMode Padding { get { throw null; } set { } }
        protected override void Dispose(bool disposing) { }
        protected override void HashCore(byte[] rgbData, int ibStart, int cbSize) { }
        protected override byte[] HashFinal() { throw null; }
        public override void Initialize() { }
    }
    public sealed partial class MD5Cng : System.Security.Cryptography.MD5
    {
        public MD5Cng() { }
        protected override void Dispose(bool disposing) { }
        protected override void HashCore(byte[] array, int ibStart, int cbSize) { }
        protected override byte[] HashFinal() { throw null; }
        public override void Initialize() { }
    }
    public sealed partial class RijndaelManagedTransform : System.IDisposable, System.Security.Cryptography.ICryptoTransform
    {
        internal RijndaelManagedTransform() { }
        public int BlockSizeValue { get { throw null; } }
        public bool CanReuseTransform { get { throw null; } }
        public bool CanTransformMultipleBlocks { get { throw null; } }
        public int InputBlockSize { get { throw null; } }
        public int OutputBlockSize { get { throw null; } }
        public void Clear() { }
        public void Dispose() { }
        public void Reset() { }
        public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { throw null; }
        public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { throw null; }
    }
    public abstract partial class RIPEMD160 : System.Security.Cryptography.HashAlgorithm
    {
        protected RIPEMD160() { }
        public static new System.Security.Cryptography.RIPEMD160 Create() { throw null; }
        public static new System.Security.Cryptography.RIPEMD160 Create(string hashName) { throw null; }
    }
    public partial class RIPEMD160Managed : System.Security.Cryptography.RIPEMD160
    {
        public RIPEMD160Managed() { }
        protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }
        protected override byte[] HashFinal() { throw null; }
        public override void Initialize() { }
    }
    public sealed partial class SHA1Cng : System.Security.Cryptography.SHA1
    {
        public SHA1Cng() { }
        protected override void Dispose(bool disposing) { }
        protected override void HashCore(byte[] array, int ibStart, int cbSize) { }
        protected override byte[] HashFinal() { throw null; }
        public override void Initialize() { }
    }
    public sealed partial class SHA256Cng : System.Security.Cryptography.SHA256
    {
        public SHA256Cng() { }
        protected override void Dispose(bool disposing) { }
        protected override void HashCore(byte[] array, int ibStart, int cbSize) { }
        protected override byte[] HashFinal() { throw null; }
        public override void Initialize() { }
    }
    public sealed partial class SHA256CryptoServiceProvider : System.Security.Cryptography.SHA256
    {
        public SHA256CryptoServiceProvider() { }
        protected override void Dispose(bool disposing) { }
        protected override void HashCore(byte[] array, int ibStart, int cbSize) { }
        protected override byte[] HashFinal() { throw null; }
        public override void Initialize() { }
    }
    public sealed partial class SHA384Cng : System.Security.Cryptography.SHA384
    {
        public SHA384Cng() { }
        protected override void Dispose(bool disposing) { }
        protected override void HashCore(byte[] array, int ibStart, int cbSize) { }
        protected override byte[] HashFinal() { throw null; }
        public override void Initialize() { }
    }
    public sealed partial class SHA384CryptoServiceProvider : System.Security.Cryptography.SHA384
    {
        public SHA384CryptoServiceProvider() { }
        protected override void Dispose(bool disposing) { }
        protected override void HashCore(byte[] array, int ibStart, int cbSize) { }
        protected override byte[] HashFinal() { throw null; }
        public override void Initialize() { }
    }
    public sealed partial class SHA512Cng : System.Security.Cryptography.SHA512
    {
        public SHA512Cng() { }
        protected override void Dispose(bool disposing) { }
        protected override void HashCore(byte[] array, int ibStart, int cbSize) { }
        protected override byte[] HashFinal() { throw null; }
        public override void Initialize() { }
    }
    public sealed partial class SHA512CryptoServiceProvider : System.Security.Cryptography.SHA512
    {
        public SHA512CryptoServiceProvider() { }
        protected override void Dispose(bool disposing) { }
        protected override void HashCore(byte[] array, int ibStart, int cbSize) { }
        protected override byte[] HashFinal() { throw null; }
        public override void Initialize() { }
    }
}