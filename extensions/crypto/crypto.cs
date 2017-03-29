// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

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
namespace Microsoft.Win32.SafeHandles
{
    public abstract partial class SafeNCryptHandle : Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid
    {
        protected SafeNCryptHandle() : base (default(bool)) { }
        protected override bool ReleaseHandle() { throw null; }
        protected abstract bool ReleaseNativeHandle();
    }
    public sealed partial class SafeNCryptKeyHandle : Microsoft.Win32.SafeHandles.SafeNCryptHandle
    {
        public SafeNCryptKeyHandle() { }
        protected override bool ReleaseNativeHandle() { throw null; }
    }
    public sealed partial class SafeNCryptProviderHandle : Microsoft.Win32.SafeHandles.SafeNCryptHandle
    {
        public SafeNCryptProviderHandle() { }
        protected override bool ReleaseNativeHandle() { throw null; }
    }
    public sealed partial class SafeNCryptSecretHandle : Microsoft.Win32.SafeHandles.SafeNCryptHandle
    {
        public SafeNCryptSecretHandle() { }
        protected override bool ReleaseNativeHandle() { throw null; }
    }
}
namespace System.Security.Cryptography
{
    public sealed partial class AesCng : System.Security.Cryptography.Aes
    {
        public AesCng() { }
        public AesCng(string keyName) { }
        public AesCng(string keyName, System.Security.Cryptography.CngProvider provider) { }
        public AesCng(string keyName, System.Security.Cryptography.CngProvider provider, System.Security.Cryptography.CngKeyOpenOptions openOptions) { }
        public override byte[] Key { get { throw null; } set { } }
        public override int KeySize { get { throw null; } set { } }
        public override System.Security.Cryptography.ICryptoTransform CreateDecryptor() { throw null; }
        public override System.Security.Cryptography.ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { throw null; }
        public override System.Security.Cryptography.ICryptoTransform CreateEncryptor() { throw null; }
        public override System.Security.Cryptography.ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { throw null; }
        protected override void Dispose(bool disposing) { }
        public override void GenerateIV() { }
        public override void GenerateKey() { }
    }
    public sealed partial class CngAlgorithm : System.IEquatable<System.Security.Cryptography.CngAlgorithm>
    {
        public CngAlgorithm(string algorithm) { }
        public string Algorithm { get { throw null; } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static System.Security.Cryptography.CngAlgorithm ECDiffieHellman { get { throw null; } }
        public static System.Security.Cryptography.CngAlgorithm ECDiffieHellmanP256 { get { throw null; } }
        public static System.Security.Cryptography.CngAlgorithm ECDiffieHellmanP384 { get { throw null; } }
        public static System.Security.Cryptography.CngAlgorithm ECDiffieHellmanP521 { get { throw null; } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static System.Security.Cryptography.CngAlgorithm ECDsa { get { throw null; } }
        public static System.Security.Cryptography.CngAlgorithm ECDsaP256 { get { throw null; } }
        public static System.Security.Cryptography.CngAlgorithm ECDsaP384 { get { throw null; } }
        public static System.Security.Cryptography.CngAlgorithm ECDsaP521 { get { throw null; } }
        public static System.Security.Cryptography.CngAlgorithm MD5 { get { throw null; } }
        public static System.Security.Cryptography.CngAlgorithm Rsa { get { throw null; } }
        public static System.Security.Cryptography.CngAlgorithm Sha1 { get { throw null; } }
        public static System.Security.Cryptography.CngAlgorithm Sha256 { get { throw null; } }
        public static System.Security.Cryptography.CngAlgorithm Sha384 { get { throw null; } }
        public static System.Security.Cryptography.CngAlgorithm Sha512 { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Security.Cryptography.CngAlgorithm other) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Security.Cryptography.CngAlgorithm left, System.Security.Cryptography.CngAlgorithm right) { throw null; }
        public static bool operator !=(System.Security.Cryptography.CngAlgorithm left, System.Security.Cryptography.CngAlgorithm right) { throw null; }
        public override string ToString() { throw null; }
    }
    public sealed partial class CngAlgorithmGroup : System.IEquatable<System.Security.Cryptography.CngAlgorithmGroup>
    {
        public CngAlgorithmGroup(string algorithmGroup) { }
        public string AlgorithmGroup { get { throw null; } }
        public static System.Security.Cryptography.CngAlgorithmGroup DiffieHellman { get { throw null; } }
        public static System.Security.Cryptography.CngAlgorithmGroup Dsa { get { throw null; } }
        public static System.Security.Cryptography.CngAlgorithmGroup ECDiffieHellman { get { throw null; } }
        public static System.Security.Cryptography.CngAlgorithmGroup ECDsa { get { throw null; } }
        public static System.Security.Cryptography.CngAlgorithmGroup Rsa { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Security.Cryptography.CngAlgorithmGroup other) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Security.Cryptography.CngAlgorithmGroup left, System.Security.Cryptography.CngAlgorithmGroup right) { throw null; }
        public static bool operator !=(System.Security.Cryptography.CngAlgorithmGroup left, System.Security.Cryptography.CngAlgorithmGroup right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.FlagsAttribute]
    public enum CngExportPolicies
    {
        AllowArchiving = 4,
        AllowExport = 1,
        AllowPlaintextArchiving = 8,
        AllowPlaintextExport = 2,
        None = 0,
    }
    public sealed partial class CngKey : System.IDisposable
    {
        internal CngKey() { }
        public System.Security.Cryptography.CngAlgorithm Algorithm { get { throw null; } }
        public System.Security.Cryptography.CngAlgorithmGroup AlgorithmGroup { get { throw null; } }
        public System.Security.Cryptography.CngExportPolicies ExportPolicy { get { throw null; } }
        public Microsoft.Win32.SafeHandles.SafeNCryptKeyHandle Handle { get { throw null; } }
        public bool IsEphemeral { get { throw null; } }
        public bool IsMachineKey { get { throw null; } }
        public string KeyName { get { throw null; } }
        public int KeySize { get { throw null; } }
        public System.Security.Cryptography.CngKeyUsages KeyUsage { get { throw null; } }
        public System.IntPtr ParentWindowHandle { get { throw null; } set { } }
        public System.Security.Cryptography.CngProvider Provider { get { throw null; } }
        public Microsoft.Win32.SafeHandles.SafeNCryptProviderHandle ProviderHandle { get { throw null; } }
        public System.Security.Cryptography.CngUIPolicy UIPolicy { get { throw null; } }
        public string UniqueName { get { throw null; } }
        public static System.Security.Cryptography.CngKey Create(System.Security.Cryptography.CngAlgorithm algorithm) { throw null; }
        public static System.Security.Cryptography.CngKey Create(System.Security.Cryptography.CngAlgorithm algorithm, string keyName) { throw null; }
        public static System.Security.Cryptography.CngKey Create(System.Security.Cryptography.CngAlgorithm algorithm, string keyName, System.Security.Cryptography.CngKeyCreationParameters creationParameters) { throw null; }
        public void Delete() { }
        public void Dispose() { }
        public static bool Exists(string keyName) { throw null; }
        public static bool Exists(string keyName, System.Security.Cryptography.CngProvider provider) { throw null; }
        public static bool Exists(string keyName, System.Security.Cryptography.CngProvider provider, System.Security.Cryptography.CngKeyOpenOptions options) { throw null; }
        public byte[] Export(System.Security.Cryptography.CngKeyBlobFormat format) { throw null; }
        public System.Security.Cryptography.CngProperty GetProperty(string name, System.Security.Cryptography.CngPropertyOptions options) { throw null; }
        public bool HasProperty(string name, System.Security.Cryptography.CngPropertyOptions options) { throw null; }
        public static System.Security.Cryptography.CngKey Import(byte[] keyBlob, System.Security.Cryptography.CngKeyBlobFormat format) { throw null; }
        public static System.Security.Cryptography.CngKey Import(byte[] keyBlob, System.Security.Cryptography.CngKeyBlobFormat format, System.Security.Cryptography.CngProvider provider) { throw null; }
        public static System.Security.Cryptography.CngKey Open(Microsoft.Win32.SafeHandles.SafeNCryptKeyHandle keyHandle, System.Security.Cryptography.CngKeyHandleOpenOptions keyHandleOpenOptions) { throw null; }
        public static System.Security.Cryptography.CngKey Open(string keyName) { throw null; }
        public static System.Security.Cryptography.CngKey Open(string keyName, System.Security.Cryptography.CngProvider provider) { throw null; }
        public static System.Security.Cryptography.CngKey Open(string keyName, System.Security.Cryptography.CngProvider provider, System.Security.Cryptography.CngKeyOpenOptions openOptions) { throw null; }
        public void SetProperty(System.Security.Cryptography.CngProperty property) { }
    }
    public sealed partial class CngKeyBlobFormat : System.IEquatable<System.Security.Cryptography.CngKeyBlobFormat>
    {
        public CngKeyBlobFormat(string format) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static System.Security.Cryptography.CngKeyBlobFormat EccFullPrivateBlob { get { throw null; } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static System.Security.Cryptography.CngKeyBlobFormat EccFullPublicBlob { get { throw null; } }
        public static System.Security.Cryptography.CngKeyBlobFormat EccPrivateBlob { get { throw null; } }
        public static System.Security.Cryptography.CngKeyBlobFormat EccPublicBlob { get { throw null; } }
        public string Format { get { throw null; } }
        public static System.Security.Cryptography.CngKeyBlobFormat GenericPrivateBlob { get { throw null; } }
        public static System.Security.Cryptography.CngKeyBlobFormat GenericPublicBlob { get { throw null; } }
        public static System.Security.Cryptography.CngKeyBlobFormat OpaqueTransportBlob { get { throw null; } }
        public static System.Security.Cryptography.CngKeyBlobFormat Pkcs8PrivateBlob { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Security.Cryptography.CngKeyBlobFormat other) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Security.Cryptography.CngKeyBlobFormat left, System.Security.Cryptography.CngKeyBlobFormat right) { throw null; }
        public static bool operator !=(System.Security.Cryptography.CngKeyBlobFormat left, System.Security.Cryptography.CngKeyBlobFormat right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.FlagsAttribute]
    public enum CngKeyCreationOptions
    {
        MachineKey = 32,
        None = 0,
        OverwriteExistingKey = 128,
    }
    public sealed partial class CngKeyCreationParameters
    {
        public CngKeyCreationParameters() { }
        public System.Nullable<System.Security.Cryptography.CngExportPolicies> ExportPolicy { get { throw null; } set { } }
        public System.Security.Cryptography.CngKeyCreationOptions KeyCreationOptions { get { throw null; } set { } }
        public System.Nullable<System.Security.Cryptography.CngKeyUsages> KeyUsage { get { throw null; } set { } }
        public System.Security.Cryptography.CngPropertyCollection Parameters { get { throw null; } }
        public System.IntPtr ParentWindowHandle { get { throw null; } set { } }
        public System.Security.Cryptography.CngProvider Provider { get { throw null; } set { } }
        public System.Security.Cryptography.CngUIPolicy UIPolicy { get { throw null; } set { } }
    }
    [System.FlagsAttribute]
    public enum CngKeyHandleOpenOptions
    {
        EphemeralKey = 1,
        None = 0,
    }
    [System.FlagsAttribute]
    public enum CngKeyOpenOptions
    {
        MachineKey = 32,
        None = 0,
        Silent = 64,
        UserKey = 0,
    }
    [System.FlagsAttribute]
    public enum CngKeyUsages
    {
        AllUsages = 16777215,
        Decryption = 1,
        KeyAgreement = 4,
        None = 0,
        Signing = 2,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct CngProperty : System.IEquatable<System.Security.Cryptography.CngProperty>
    {
        public CngProperty(string name, byte[] value, System.Security.Cryptography.CngPropertyOptions options) { throw null;}
        public string Name { get { throw null; } }
        public System.Security.Cryptography.CngPropertyOptions Options { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Security.Cryptography.CngProperty other) { throw null; }
        public override int GetHashCode() { throw null; }
        public byte[] GetValue() { throw null; }
        public static bool operator ==(System.Security.Cryptography.CngProperty left, System.Security.Cryptography.CngProperty right) { throw null; }
        public static bool operator !=(System.Security.Cryptography.CngProperty left, System.Security.Cryptography.CngProperty right) { throw null; }
    }
    public sealed partial class CngPropertyCollection : System.Collections.ObjectModel.Collection<System.Security.Cryptography.CngProperty>
    {
        public CngPropertyCollection() { }
    }
    [System.FlagsAttribute]
    public enum CngPropertyOptions
    {
        CustomProperty = 1073741824,
        None = 0,
        Persist = -2147483648,
    }
    public sealed partial class CngProvider : System.IEquatable<System.Security.Cryptography.CngProvider>
    {
        public CngProvider(string provider) { }
        public static System.Security.Cryptography.CngProvider MicrosoftSmartCardKeyStorageProvider { get { throw null; } }
        public static System.Security.Cryptography.CngProvider MicrosoftSoftwareKeyStorageProvider { get { throw null; } }
        public string Provider { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Security.Cryptography.CngProvider other) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Security.Cryptography.CngProvider left, System.Security.Cryptography.CngProvider right) { throw null; }
        public static bool operator !=(System.Security.Cryptography.CngProvider left, System.Security.Cryptography.CngProvider right) { throw null; }
        public override string ToString() { throw null; }
    }
    public sealed partial class CngUIPolicy
    {
        public CngUIPolicy(System.Security.Cryptography.CngUIProtectionLevels protectionLevel) { }
        public CngUIPolicy(System.Security.Cryptography.CngUIProtectionLevels protectionLevel, string friendlyName) { }
        public CngUIPolicy(System.Security.Cryptography.CngUIProtectionLevels protectionLevel, string friendlyName, string description) { }
        public CngUIPolicy(System.Security.Cryptography.CngUIProtectionLevels protectionLevel, string friendlyName, string description, string useContext) { }
        public CngUIPolicy(System.Security.Cryptography.CngUIProtectionLevels protectionLevel, string friendlyName, string description, string useContext, string creationTitle) { }
        public string CreationTitle { get { throw null; } }
        public string Description { get { throw null; } }
        public string FriendlyName { get { throw null; } }
        public System.Security.Cryptography.CngUIProtectionLevels ProtectionLevel { get { throw null; } }
        public string UseContext { get { throw null; } }
    }
    [System.FlagsAttribute]
    public enum CngUIProtectionLevels
    {
        ForceHighProtection = 2,
        None = 0,
        ProtectKey = 1,
    }
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
        public ECDsaCng(System.Security.Cryptography.ECCurve curve) { }
        public System.Security.Cryptography.CngKey Key { get { throw null; } }
        public override int KeySize { get { throw null; } set { } }
        public override System.Security.Cryptography.KeySizes[] LegalKeySizes { get { throw null; } }
        protected override void Dispose(bool disposing) { }
        public override System.Security.Cryptography.ECParameters ExportExplicitParameters(bool includePrivateParameters) { throw null; }
        public override System.Security.Cryptography.ECParameters ExportParameters(bool includePrivateParameters) { throw null; }
        public override void GenerateKey(System.Security.Cryptography.ECCurve curve) { }
        protected override byte[] HashData(byte[] data, int offset, int count, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { throw null; }
        protected override byte[] HashData(System.IO.Stream data, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { throw null; }
        public override void ImportParameters(System.Security.Cryptography.ECParameters parameters) { }
        public override byte[] SignHash(byte[] hash) { throw null; }
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
    public sealed partial class RSACng : System.Security.Cryptography.RSA
    {
        public RSACng() { }
        public RSACng(int keySize) { }
        public RSACng(System.Security.Cryptography.CngKey key) { }
        public System.Security.Cryptography.CngKey Key { get { throw null; } }
        public override byte[] Decrypt(byte[] data, System.Security.Cryptography.RSAEncryptionPadding padding) { throw null; }
        protected override void Dispose(bool disposing) { }
        public override byte[] Encrypt(byte[] data, System.Security.Cryptography.RSAEncryptionPadding padding) { throw null; }
        public override System.Security.Cryptography.RSAParameters ExportParameters(bool includePrivateParameters) { throw null; }
        protected override byte[] HashData(byte[] data, int offset, int count, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { throw null; }
        protected override byte[] HashData(System.IO.Stream data, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { throw null; }
        public override void ImportParameters(System.Security.Cryptography.RSAParameters parameters) { }
        public override byte[] SignHash(byte[] hash, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, System.Security.Cryptography.RSASignaturePadding padding) { throw null; }
        public override bool VerifyHash(byte[] hash, byte[] signature, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, System.Security.Cryptography.RSASignaturePadding padding) { throw null; }
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
    public sealed partial class TripleDESCng : System.Security.Cryptography.TripleDES
    {
        public TripleDESCng() { }
        public TripleDESCng(string keyName) { }
        public TripleDESCng(string keyName, System.Security.Cryptography.CngProvider provider) { }
        public TripleDESCng(string keyName, System.Security.Cryptography.CngProvider provider, System.Security.Cryptography.CngKeyOpenOptions openOptions) { }
        public override byte[] Key { get { throw null; } set { } }
        public override int KeySize { get { throw null; } set { } }
        public override System.Security.Cryptography.KeySizes[] LegalKeySizes { get { throw null; } }
        public override System.Security.Cryptography.ICryptoTransform CreateDecryptor() { throw null; }
        public override System.Security.Cryptography.ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { throw null; }
        public override System.Security.Cryptography.ICryptoTransform CreateEncryptor() { throw null; }
        public override System.Security.Cryptography.ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { throw null; }
        protected override void Dispose(bool disposing) { }
        public override void GenerateIV() { }
        public override void GenerateKey() { }
    }
}
