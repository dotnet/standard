// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Security.Cryptography
{
    public abstract partial class Aes : System.Security.Cryptography.SymmetricAlgorithm
    {
        protected Aes() { }
        public static new System.Security.Cryptography.Aes Create() { throw null; }
        public static new System.Security.Cryptography.Aes Create(string algorithmName) { throw null; }
    }
    public sealed partial class AesCryptoServiceProvider : System.Security.Cryptography.Aes
    {
        public AesCryptoServiceProvider() { }
        public override byte[] Key { get { throw null; } set { } }
        public override int KeySize { get { throw null; } set { } }
        public override System.Security.Cryptography.ICryptoTransform CreateDecryptor() { throw null; }
        public override System.Security.Cryptography.ICryptoTransform CreateDecryptor(byte[] key, byte[] iv) { throw null; }
        public override System.Security.Cryptography.ICryptoTransform CreateEncryptor() { throw null; }
        public override System.Security.Cryptography.ICryptoTransform CreateEncryptor(byte[] key, byte[] iv) { throw null; }
        protected override void Dispose(bool disposing) { }
        public override void GenerateIV() { }
        public override void GenerateKey() { }
    }
    public sealed partial class AesManaged : System.Security.Cryptography.Aes
    {
        public AesManaged() { }
        public override int FeedbackSize { get { throw null; } set { } }
        public override byte[] IV { get { throw null; } set { } }
        public override byte[] Key { get { throw null; } set { } }
        public override int KeySize { get { throw null; } set { } }
        public override System.Security.Cryptography.CipherMode Mode { get { throw null; } set { } }
        public override System.Security.Cryptography.PaddingMode Padding { get { throw null; } set { } }
        public override System.Security.Cryptography.ICryptoTransform CreateDecryptor() { throw null; }
        public override System.Security.Cryptography.ICryptoTransform CreateDecryptor(byte[] key, byte[] iv) { throw null; }
        public override System.Security.Cryptography.ICryptoTransform CreateEncryptor() { throw null; }
        public override System.Security.Cryptography.ICryptoTransform CreateEncryptor(byte[] key, byte[] iv) { throw null; }
        protected override void Dispose(bool disposing) { }
        public override void GenerateIV() { }
        public override void GenerateKey() { }
    }
    public partial class AsnEncodedData
    {
        protected AsnEncodedData() { }
        public AsnEncodedData(byte[] rawData) { }
        public AsnEncodedData(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
        public AsnEncodedData(System.Security.Cryptography.Oid oid, byte[] rawData) { }
        public AsnEncodedData(string oid, byte[] rawData) { }
        public System.Security.Cryptography.Oid Oid { get { throw null; } set { } }
        public byte[] RawData { get { throw null; } set { } }
        public virtual void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
        public virtual string Format(bool multiLine) { throw null; }
    }
    public sealed partial class AsnEncodedDataCollection : System.Collections.ICollection, System.Collections.IEnumerable
    {
        public AsnEncodedDataCollection() { }
        public AsnEncodedDataCollection(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
        public int Count { get { throw null; } }
        public bool IsSynchronized { get { throw null; } }
        public System.Security.Cryptography.AsnEncodedData this[int index] { get { throw null; } }
        public object SyncRoot { get { throw null; } }
        public int Add(System.Security.Cryptography.AsnEncodedData asnEncodedData) { throw null; }
        public void CopyTo(System.Security.Cryptography.AsnEncodedData[] array, int index) { }
        public System.Security.Cryptography.AsnEncodedDataEnumerator GetEnumerator() { throw null; }
        public void Remove(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public sealed partial class AsnEncodedDataEnumerator : System.Collections.IEnumerator
    {
        internal AsnEncodedDataEnumerator() { }
        public System.Security.Cryptography.AsnEncodedData Current { get { throw null; } }
        object System.Collections.IEnumerator.Current { get { throw null; } }
        public bool MoveNext() { throw null; }
        public void Reset() { }
    }
    public abstract partial class AsymmetricAlgorithm : System.IDisposable
    {
        protected int KeySizeValue;
        protected System.Security.Cryptography.KeySizes[] LegalKeySizesValue;
        protected AsymmetricAlgorithm() { }
        public virtual string KeyExchangeAlgorithm { get { throw null; } }
        public virtual int KeySize { get { throw null; } set { } }
        public virtual System.Security.Cryptography.KeySizes[] LegalKeySizes { get { throw null; } }
        public virtual string SignatureAlgorithm { get { throw null; } }
        public void Clear() { }
        public static System.Security.Cryptography.AsymmetricAlgorithm Create() { throw null; }
        public static System.Security.Cryptography.AsymmetricAlgorithm Create(string algName) { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public virtual void FromXmlString(string xmlString) { }
        public virtual string ToXmlString(bool includePrivateParameters) { throw null; }
    }
    public abstract partial class AsymmetricKeyExchangeDeformatter
    {
        protected AsymmetricKeyExchangeDeformatter() { }
        public abstract string Parameters { get; set; }
        public abstract byte[] DecryptKeyExchange(byte[] rgb);
        public abstract void SetKey(System.Security.Cryptography.AsymmetricAlgorithm key);
    }
    public abstract partial class AsymmetricKeyExchangeFormatter
    {
        protected AsymmetricKeyExchangeFormatter() { }
        public abstract string Parameters { get; }
        public abstract byte[] CreateKeyExchange(byte[] data);
        public abstract byte[] CreateKeyExchange(byte[] data, System.Type symAlgType);
        public abstract void SetKey(System.Security.Cryptography.AsymmetricAlgorithm key);
    }
    public abstract partial class AsymmetricSignatureDeformatter
    {
        protected AsymmetricSignatureDeformatter() { }
        public abstract void SetHashAlgorithm(string strName);
        public abstract void SetKey(System.Security.Cryptography.AsymmetricAlgorithm key);
        public abstract bool VerifySignature(byte[] rgbHash, byte[] rgbSignature);
        public virtual bool VerifySignature(System.Security.Cryptography.HashAlgorithm hash, byte[] rgbSignature) { throw null; }
    }
    public abstract partial class AsymmetricSignatureFormatter
    {
        protected AsymmetricSignatureFormatter() { }
        public abstract byte[] CreateSignature(byte[] rgbHash);
        public virtual byte[] CreateSignature(System.Security.Cryptography.HashAlgorithm hash) { throw null; }
        public abstract void SetHashAlgorithm(string strName);
        public abstract void SetKey(System.Security.Cryptography.AsymmetricAlgorithm key);
    }
    public enum CipherMode
    {
        CBC = 1,
        CFB = 4,
        CTS = 5,
        ECB = 2,
        OFB = 3,
    }
    public partial class CryptoConfig
    {
        public CryptoConfig() { }
        public static bool AllowOnlyFipsAlgorithms { get { throw null; } }
        public static void AddAlgorithm(System.Type algorithm, params string[] names) { }
        public static void AddOID(string oid, params string[] names) { }
        public static object CreateFromName(string name) { throw null; }
        public static object CreateFromName(string name, params object[] args) { throw null; }
        public static byte[] EncodeOID(string str) { throw null; }
        public static string MapNameToOID(string name) { throw null; }
    }
    public partial class CryptographicException : System.SystemException
    {
        public CryptographicException() { }
        public CryptographicException(int hr) { }
        protected CryptographicException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public CryptographicException(string message) { }
        public CryptographicException(string message, System.Exception inner) { }
        public CryptographicException(string format, string insert) { }
    }
    public static partial class CryptographicOperations
    {
        public static bool FixedTimeEquals(System.ReadOnlySpan<byte> left, System.ReadOnlySpan<byte> right) { throw null; }
        public static void ZeroMemory(System.Span<byte> buffer) { }
    }
    public partial class CryptographicUnexpectedOperationException : System.Security.Cryptography.CryptographicException
    {
        public CryptographicUnexpectedOperationException() { }
        protected CryptographicUnexpectedOperationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public CryptographicUnexpectedOperationException(string message) { }
        public CryptographicUnexpectedOperationException(string message, System.Exception inner) { }
        public CryptographicUnexpectedOperationException(string format, string insert) { }
    }
    public partial class CryptoStream : System.IO.Stream, System.IDisposable
    {
        public CryptoStream(System.IO.Stream stream, System.Security.Cryptography.ICryptoTransform transform, System.Security.Cryptography.CryptoStreamMode mode) { }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public bool HasFlushedFinalBlock { get { throw null; } }
        public override long Length { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        public void Clear() { }
        protected override void Dispose(bool disposing) { }
        public override void Flush() { }
        public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public void FlushFinalBlock() { }
        public override int Read(byte[] buffer, int offset, int count) { buffer = default(byte[]); throw null; }
        public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long value) { }
        public override void Write(byte[] buffer, int offset, int count) { }
        public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public enum CryptoStreamMode
    {
        Read = 0,
        Write = 1,
    }
    public sealed partial class CspKeyContainerInfo
    {
        public CspKeyContainerInfo(System.Security.Cryptography.CspParameters parameters) { }
        public bool Accessible { get { throw null; } }
//ACLS        public System.Security.AccessControl.CryptoKeySecurity CryptoKeySecurity { get { throw null; } }
        public bool Exportable { get { throw null; } }
        public bool HardwareDevice { get { throw null; } }
        public string KeyContainerName { get { throw null; } }
        public System.Security.Cryptography.KeyNumber KeyNumber { get { throw null; } }
        public bool MachineKeyStore { get { throw null; } }
        public bool Protected { get { throw null; } }
        public string ProviderName { get { throw null; } }
        public int ProviderType { get { throw null; } }
        public bool RandomlyGenerated { get { throw null; } }
        public bool Removable { get { throw null; } }
        public string UniqueKeyContainerName { get { throw null; } }
    }
    public sealed partial class CspParameters
    {
        public string KeyContainerName;
        public int KeyNumber;
        public string ProviderName;
        public int ProviderType;
        public CspParameters() { }
        public CspParameters(int dwTypeIn) { }
        public CspParameters(int dwTypeIn, string strProviderNameIn) { }
        public CspParameters(int dwTypeIn, string strProviderNameIn, string strContainerNameIn) { }
//ACLS        public CspParameters(int providerType, string providerName, string keyContainerName, System.Security.AccessControl.CryptoKeySecurity cryptoKeySecurity, System.IntPtr parentWindowHandle) { }
//ACLS        public CspParameters(int providerType, string providerName, string keyContainerName, System.Security.AccessControl.CryptoKeySecurity cryptoKeySecurity, System.Security.SecureString keyPassword) { }
//ACLS        public System.Security.AccessControl.CryptoKeySecurity CryptoKeySecurity { get { throw null; } set { } }
        public System.Security.Cryptography.CspProviderFlags Flags { get { throw null; } set { } }
        public System.Security.SecureString KeyPassword { get { throw null; } set { } }
        public System.IntPtr ParentWindowHandle { get { throw null; } set { } }
    }
    [System.FlagsAttribute]
    public enum CspProviderFlags
    {
        CreateEphemeralKey = 128,
        NoFlags = 0,
        NoPrompt = 64,
        UseArchivableKey = 16,
        UseDefaultKeyContainer = 2,
        UseExistingKey = 8,
        UseMachineKeyStore = 1,
        UseNonExportableKey = 4,
        UseUserProtectedKey = 32,
    }
    public abstract partial class DeriveBytes : System.IDisposable
    {
        protected DeriveBytes() { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public abstract byte[] GetBytes(int cb);
        public abstract void Reset();
    }
    public abstract partial class DES : System.Security.Cryptography.SymmetricAlgorithm
    {
        protected DES() { }
        public override byte[] Key { get { throw null; } set { } }
        public static new System.Security.Cryptography.DES Create() { throw null; }
        public static new System.Security.Cryptography.DES Create(string algName) { throw null; }
        public static bool IsSemiWeakKey(byte[] rgbKey) { throw null; }
        public static bool IsWeakKey(byte[] rgbKey) { throw null; }
    }
    public sealed partial class DESCryptoServiceProvider : System.Security.Cryptography.DES
    {
        public DESCryptoServiceProvider() { }
        public override System.Security.Cryptography.ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { throw null; }
        public override System.Security.Cryptography.ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { throw null; }
        public override void GenerateIV() { }
        public override void GenerateKey() { }
    }
    public abstract partial class DSA : System.Security.Cryptography.AsymmetricAlgorithm
    {
        protected DSA() { }
        public static new System.Security.Cryptography.DSA Create() { throw null; }
        public static new System.Security.Cryptography.DSA Create(string algName) { throw null; }
        public abstract byte[] CreateSignature(byte[] rgbHash);
        public abstract System.Security.Cryptography.DSAParameters ExportParameters(bool includePrivateParameters);
        public override void FromXmlString(string xmlString) { }
        public abstract void ImportParameters(System.Security.Cryptography.DSAParameters parameters);
        public override string ToXmlString(bool includePrivateParameters) { throw null; }
        public virtual bool TryCreateSignature(System.ReadOnlySpan<byte> hash, System.Span<byte> destination, out int bytesWritten) { bytesWritten = default(int); throw null; }
        protected virtual bool TryHashData(System.ReadOnlySpan<byte> data, System.Span<byte> destination, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, out int bytesWritten) { bytesWritten = default(int); throw null; }
        public virtual bool TrySignData(System.ReadOnlySpan<byte> data, System.Span<byte> destination, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, out int bytesWritten) { bytesWritten = default(int); throw null; }
        public virtual bool VerifyData(System.ReadOnlySpan<byte> data, System.ReadOnlySpan<byte> signature, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { throw null; }
        public abstract bool VerifySignature(byte[] rgbHash, byte[] rgbSignature);
        public virtual bool VerifySignature(System.ReadOnlySpan<byte> hash, System.ReadOnlySpan<byte> signature) { throw null; }
    }
    public sealed partial class DSACryptoServiceProvider : System.Security.Cryptography.DSA, System.Security.Cryptography.ICspAsymmetricAlgorithm
    {
        public DSACryptoServiceProvider() { }
        public DSACryptoServiceProvider(int dwKeySize) { }
        public DSACryptoServiceProvider(int dwKeySize, System.Security.Cryptography.CspParameters parameters) { }
        public DSACryptoServiceProvider(System.Security.Cryptography.CspParameters parameters) { }
        public System.Security.Cryptography.CspKeyContainerInfo CspKeyContainerInfo { get { throw null; } }
        public override string KeyExchangeAlgorithm { get { throw null; } }
        public override int KeySize { get { throw null; } }
        public bool PersistKeyInCsp { get { throw null; } set { } }
        public bool PublicOnly { get { throw null; } }
        public override string SignatureAlgorithm { get { throw null; } }
        public static bool UseMachineKeyStore { get { throw null; } set { } }
        public override byte[] CreateSignature(byte[] rgbHash) { throw null; }
        protected override void Dispose(bool disposing) { }
        public byte[] ExportCspBlob(bool includePrivateParameters) { throw null; }
        public override System.Security.Cryptography.DSAParameters ExportParameters(bool includePrivateParameters) { throw null; }
        public void ImportCspBlob(byte[] keyBlob) { }
        public override void ImportParameters(System.Security.Cryptography.DSAParameters parameters) { }
        public byte[] SignData(byte[] buffer) { throw null; }
        public byte[] SignData(byte[] buffer, int offset, int count) { throw null; }
        public byte[] SignData(System.IO.Stream inputStream) { throw null; }
        public byte[] SignHash(byte[] rgbHash, string str) { throw null; }
        public bool VerifyData(byte[] rgbData, byte[] rgbSignature) { throw null; }
        public bool VerifyHash(byte[] rgbHash, string str, byte[] rgbSignature) { throw null; }
        public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct DSAParameters
    {
        public int Counter;
        public byte[] G;
        public byte[] J;
        public byte[] P;
        public byte[] Q;
        public byte[] Seed;
        public byte[] X;
        public byte[] Y;
    }
    public partial class DSASignatureDeformatter : System.Security.Cryptography.AsymmetricSignatureDeformatter
    {
        public DSASignatureDeformatter() { }
        public DSASignatureDeformatter(System.Security.Cryptography.AsymmetricAlgorithm key) { }
        public override void SetHashAlgorithm(string strName) { }
        public override void SetKey(System.Security.Cryptography.AsymmetricAlgorithm key) { }
        public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { throw null; }
    }
    public partial class DSASignatureFormatter : System.Security.Cryptography.AsymmetricSignatureFormatter
    {
        public DSASignatureFormatter() { }
        public DSASignatureFormatter(System.Security.Cryptography.AsymmetricAlgorithm key) { }
        public override byte[] CreateSignature(byte[] rgbHash) { throw null; }
        public override void SetHashAlgorithm(string strName) { }
        public override void SetKey(System.Security.Cryptography.AsymmetricAlgorithm key) { }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct ECCurve
    {
        public byte[] A;
        public byte[] B;
        public byte[] Cofactor;
        public System.Security.Cryptography.ECCurve.ECCurveType CurveType;
        public System.Security.Cryptography.ECPoint G;
        public System.Nullable<System.Security.Cryptography.HashAlgorithmName> Hash;
        public byte[] Order;
        public byte[] Polynomial;
        public byte[] Prime;
        public byte[] Seed;
        public bool IsCharacteristic2 { get { throw null; } }
        public bool IsExplicit { get { throw null; } }
        public bool IsNamed { get { throw null; } }
        public bool IsPrime { get { throw null; } }
        public System.Security.Cryptography.Oid Oid { get { throw null; } }
        public static System.Security.Cryptography.ECCurve CreateFromFriendlyName(string oidFriendlyName) { throw null; }
        public static System.Security.Cryptography.ECCurve CreateFromOid(System.Security.Cryptography.Oid curveOid) { throw null; }
        public static System.Security.Cryptography.ECCurve CreateFromValue(string oidValue) { throw null; }
        public void Validate() { }
        public enum ECCurveType
        {
            Characteristic2 = 4,
            Implicit = 0,
            Named = 5,
            PrimeMontgomery = 3,
            PrimeShortWeierstrass = 1,
            PrimeTwistedEdwards = 2,
        }
        public static partial class NamedCurves
        {
            public static System.Security.Cryptography.ECCurve brainpoolP160r1 { get { throw null; } }
            public static System.Security.Cryptography.ECCurve brainpoolP160t1 { get { throw null; } }
            public static System.Security.Cryptography.ECCurve brainpoolP192r1 { get { throw null; } }
            public static System.Security.Cryptography.ECCurve brainpoolP192t1 { get { throw null; } }
            public static System.Security.Cryptography.ECCurve brainpoolP224r1 { get { throw null; } }
            public static System.Security.Cryptography.ECCurve brainpoolP224t1 { get { throw null; } }
            public static System.Security.Cryptography.ECCurve brainpoolP256r1 { get { throw null; } }
            public static System.Security.Cryptography.ECCurve brainpoolP256t1 { get { throw null; } }
            public static System.Security.Cryptography.ECCurve brainpoolP320r1 { get { throw null; } }
            public static System.Security.Cryptography.ECCurve brainpoolP320t1 { get { throw null; } }
            public static System.Security.Cryptography.ECCurve brainpoolP384r1 { get { throw null; } }
            public static System.Security.Cryptography.ECCurve brainpoolP384t1 { get { throw null; } }
            public static System.Security.Cryptography.ECCurve brainpoolP512r1 { get { throw null; } }
            public static System.Security.Cryptography.ECCurve brainpoolP512t1 { get { throw null; } }
            public static System.Security.Cryptography.ECCurve nistP256 { get { throw null; } }
            public static System.Security.Cryptography.ECCurve nistP384 { get { throw null; } }
            public static System.Security.Cryptography.ECCurve nistP521 { get { throw null; } }
        }
    }
    public abstract partial class ECDiffieHellmanPublicKey : System.IDisposable
    {
        protected ECDiffieHellmanPublicKey(byte[] keyBlob) { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public virtual byte[] ToByteArray() { throw null; }
        public abstract string ToXmlString();
    }
    public abstract partial class ECDsa : System.Security.Cryptography.AsymmetricAlgorithm
    {
        protected ECDsa() { }
        public override string KeyExchangeAlgorithm { get { throw null; } }
        public override string SignatureAlgorithm { get { throw null; } }
        public static new System.Security.Cryptography.ECDsa Create() { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static System.Security.Cryptography.ECDsa Create(System.Security.Cryptography.ECCurve curve) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static System.Security.Cryptography.ECDsa Create(System.Security.Cryptography.ECParameters parameters) { throw null; }
        public static new System.Security.Cryptography.ECDsa Create(string algorithm) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual System.Security.Cryptography.ECParameters ExportExplicitParameters(bool includePrivateParameters) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual System.Security.Cryptography.ECParameters ExportParameters(bool includePrivateParameters) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual void GenerateKey(System.Security.Cryptography.ECCurve curve) { }
        protected virtual byte[] HashData(byte[] data, int offset, int count, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { throw null; }
        protected virtual byte[] HashData(System.IO.Stream data, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual void ImportParameters(System.Security.Cryptography.ECParameters parameters) { }
        public virtual byte[] SignData(byte[] data, int offset, int count, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { throw null; }
        public virtual byte[] SignData(byte[] data, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { throw null; }
        public virtual byte[] SignData(System.IO.Stream data, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { throw null; }
        public abstract byte[] SignHash(byte[] hash);
        protected virtual bool TryHashData(System.ReadOnlySpan<byte> data, System.Span<byte> destination, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, out int bytesWritten) { bytesWritten = default(int); throw null; }
        public virtual bool TrySignData(System.ReadOnlySpan<byte> data, System.Span<byte> destination, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, out int bytesWritten) { bytesWritten = default(int); throw null; }
        public virtual bool TrySignHash(System.ReadOnlySpan<byte> hash, System.Span<byte> destination, out int bytesWritten) { bytesWritten = default(int); throw null; }
        public bool VerifyData(byte[] data, byte[] signature, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { throw null; }
        public virtual bool VerifyData(byte[] data, int offset, int count, byte[] signature, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { throw null; }
        public bool VerifyData(System.IO.Stream data, byte[] signature, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { throw null; }
        public virtual bool VerifyData(System.ReadOnlySpan<byte> data, System.ReadOnlySpan<byte> signature, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { throw null; }
        public abstract bool VerifyHash(byte[] hash, byte[] signature);
        public virtual bool VerifyHash(System.ReadOnlySpan<byte> hash, System.ReadOnlySpan<byte> signature) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct ECParameters
    {
        public System.Security.Cryptography.ECCurve Curve;
        public byte[] D;
        public System.Security.Cryptography.ECPoint Q;
        public void Validate() { }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct ECPoint
    {
        public byte[] X;
        public byte[] Y;
    }
    public partial class FromBase64Transform : System.IDisposable, System.Security.Cryptography.ICryptoTransform
    {
        public FromBase64Transform() { }
        public FromBase64Transform(System.Security.Cryptography.FromBase64TransformMode whitespaces) { }
        public virtual bool CanReuseTransform { get { throw null; } }
        public bool CanTransformMultipleBlocks { get { throw null; } }
        public int InputBlockSize { get { throw null; } }
        public int OutputBlockSize { get { throw null; } }
        public void Clear() { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        ~FromBase64Transform() { }
        public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { throw null; }
        public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { throw null; }
    }
    public enum FromBase64TransformMode
    {
        DoNotIgnoreWhiteSpaces = 1,
        IgnoreWhiteSpaces = 0,
    }
    public abstract partial class HashAlgorithm : System.IDisposable, System.Security.Cryptography.ICryptoTransform
    {
        protected int HashSizeValue;
        protected internal byte[] HashValue;
        protected int State;
        protected HashAlgorithm() { }
        public virtual bool CanReuseTransform { get { throw null; } }
        public virtual bool CanTransformMultipleBlocks { get { throw null; } }
        public virtual byte[] Hash { get { throw null; } }
        public virtual int HashSize { get { throw null; } }
        public virtual int InputBlockSize { get { throw null; } }
        public virtual int OutputBlockSize { get { throw null; } }
        public void Clear() { }
        public byte[] ComputeHash(byte[] buffer) { throw null; }
        public byte[] ComputeHash(byte[] buffer, int offset, int count) { throw null; }
        public byte[] ComputeHash(System.IO.Stream inputStream) { throw null; }
        public static System.Security.Cryptography.HashAlgorithm Create() { throw null; }
        public static System.Security.Cryptography.HashAlgorithm Create(string hashName) { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        protected abstract void HashCore(byte[] array, int ibStart, int cbSize);
        protected virtual void HashCore(System.ReadOnlySpan<byte> source) { }
        protected abstract byte[] HashFinal();
        public abstract void Initialize();
        public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { throw null; }
        public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { throw null; }
        public bool TryComputeHash(System.ReadOnlySpan<byte> source, System.Span<byte> destination, out int bytesWritten) { bytesWritten = default(int); throw null; }
        protected virtual bool TryHashFinal(System.Span<byte> destination, out int bytesWritten) { bytesWritten = default(int); throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct HashAlgorithmName : System.IEquatable<System.Security.Cryptography.HashAlgorithmName>
    {
        public HashAlgorithmName(string name) { throw null;}
        public static System.Security.Cryptography.HashAlgorithmName MD5 { get { throw null; } }
        public string Name { get { throw null; } }
        public static System.Security.Cryptography.HashAlgorithmName SHA1 { get { throw null; } }
        public static System.Security.Cryptography.HashAlgorithmName SHA256 { get { throw null; } }
        public static System.Security.Cryptography.HashAlgorithmName SHA384 { get { throw null; } }
        public static System.Security.Cryptography.HashAlgorithmName SHA512 { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Security.Cryptography.HashAlgorithmName other) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Security.Cryptography.HashAlgorithmName left, System.Security.Cryptography.HashAlgorithmName right) { throw null; }
        public static bool operator !=(System.Security.Cryptography.HashAlgorithmName left, System.Security.Cryptography.HashAlgorithmName right) { throw null; }
        public override string ToString() { throw null; }
    }
    public abstract partial class HMAC : System.Security.Cryptography.KeyedHashAlgorithm
    {
        protected HMAC() { }
        protected int BlockSizeValue { get { throw null; } set { } }
        public string HashName { get { throw null; } set { } }
        public override byte[] Key { get { throw null; } set { } }
        public static new System.Security.Cryptography.HMAC Create() { throw null; }
        public static new System.Security.Cryptography.HMAC Create(string algorithmName) { throw null; }
        protected override void Dispose(bool disposing) { }
        protected override void HashCore(byte[] rgb, int ib, int cb) { }
        protected override void HashCore(System.ReadOnlySpan<byte> source) { }
        protected override byte[] HashFinal() { throw null; }
        public override void Initialize() { }
        protected override bool TryHashFinal(System.Span<byte> destination, out int bytesWritten) { bytesWritten = default(int); throw null; }
    }
    public partial class HMACMD5 : System.Security.Cryptography.HMAC
    {
        public HMACMD5() { }
        public HMACMD5(byte[] key) { }
        protected override void HashCore(System.ReadOnlySpan<byte> source) { }
        protected override bool TryHashFinal(System.Span<byte> destination, out int bytesWritten) { bytesWritten = default(int); throw null; }
    }
    public partial class HMACSHA1 : System.Security.Cryptography.HMAC
    {
        public HMACSHA1() { }
        public HMACSHA1(byte[] key) { }
        public HMACSHA1(byte[] key, bool useManagedSha1) { }
        protected override void HashCore(System.ReadOnlySpan<byte> source) { }
        protected override bool TryHashFinal(System.Span<byte> destination, out int bytesWritten) { bytesWritten = default(int); throw null; }
    }
    public partial class HMACSHA256 : System.Security.Cryptography.HMAC
    {
        public HMACSHA256() { }
        public HMACSHA256(byte[] key) { }
        protected override void HashCore(System.ReadOnlySpan<byte> source) { }
        protected override bool TryHashFinal(System.Span<byte> destination, out int bytesWritten) { bytesWritten = default(int); throw null; }
    }
    public partial class HMACSHA384 : System.Security.Cryptography.HMAC
    {
        public HMACSHA384() { }
        public HMACSHA384(byte[] key) { }
        public bool ProduceLegacyHmacValues { get { throw null; } set { } }
        protected override void HashCore(System.ReadOnlySpan<byte> source) { }
        protected override bool TryHashFinal(System.Span<byte> destination, out int bytesWritten) { bytesWritten = default(int); throw null; }
    }
    public partial class HMACSHA512 : System.Security.Cryptography.HMAC
    {
        public HMACSHA512() { }
        public HMACSHA512(byte[] key) { }
        public bool ProduceLegacyHmacValues { get { throw null; } set { } }
        protected override void HashCore(System.ReadOnlySpan<byte> source) { }
        protected override bool TryHashFinal(System.Span<byte> destination, out int bytesWritten) { bytesWritten = default(int); throw null; }
    }
    public partial interface ICryptoTransform : System.IDisposable
    {
        bool CanReuseTransform { get; }
        bool CanTransformMultipleBlocks { get; }
        int InputBlockSize { get; }
        int OutputBlockSize { get; }
        int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset);
        byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount);
    }
    public partial interface ICspAsymmetricAlgorithm
    {
        System.Security.Cryptography.CspKeyContainerInfo CspKeyContainerInfo { get; }
        byte[] ExportCspBlob(bool includePrivateParameters);
        void ImportCspBlob(byte[] rawData);
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public sealed partial class IncrementalHash : System.IDisposable
    {
        internal IncrementalHash() { }
        public System.Security.Cryptography.HashAlgorithmName AlgorithmName { get { throw null; } }
        public void AppendData(byte[] data) { }
        public void AppendData(byte[] data, int offset, int count) { }
        public void AppendData(System.ReadOnlySpan<byte> data) { }
        public static System.Security.Cryptography.IncrementalHash CreateHash(System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { throw null; }
        public static System.Security.Cryptography.IncrementalHash CreateHMAC(System.Security.Cryptography.HashAlgorithmName hashAlgorithm, byte[] key) { throw null; }
        public void Dispose() { }
        public byte[] GetHashAndReset() { throw null; }
        public bool TryGetHashAndReset(System.Span<byte> destination, out int bytesWritten) { bytesWritten = default(int); throw null; }
    }
    public abstract partial class KeyedHashAlgorithm : System.Security.Cryptography.HashAlgorithm
    {
        protected byte[] KeyValue;
        protected KeyedHashAlgorithm() { }
        public virtual byte[] Key { get { throw null; } set { } }
        public static new System.Security.Cryptography.KeyedHashAlgorithm Create() { throw null; }
        public static new System.Security.Cryptography.KeyedHashAlgorithm Create(string algName) { throw null; }
        protected override void Dispose(bool disposing) { }
    }
    public enum KeyNumber
    {
        Exchange = 1,
        Signature = 2,
    }
    public sealed partial class KeySizes
    {
        public KeySizes(int minSize, int maxSize, int skipSize) { }
        public int MaxSize { get { throw null; } }
        public int MinSize { get { throw null; } }
        public int SkipSize { get { throw null; } }
    }
    public abstract partial class MaskGenerationMethod
    {
        protected MaskGenerationMethod() { }
        public abstract byte[] GenerateMask(byte[] rgbSeed, int cbReturn);
    }
    public abstract partial class MD5 : System.Security.Cryptography.HashAlgorithm
    {
        protected MD5() { }
        public static new System.Security.Cryptography.MD5 Create() { throw null; }
        public static new System.Security.Cryptography.MD5 Create(string algName) { throw null; }
    }
    public sealed partial class MD5CryptoServiceProvider : System.Security.Cryptography.MD5
    {
        public MD5CryptoServiceProvider() { }
        protected override void Dispose(bool disposing) { }
        protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }
        protected override byte[] HashFinal() { throw null; }
        public override void Initialize() { }
    }
    public sealed partial class Oid
    {
        public Oid() { }
        public Oid(System.Security.Cryptography.Oid oid) { }
        public Oid(string oid) { }
        public Oid(string value, string friendlyName) { }
        public string FriendlyName { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
        public static System.Security.Cryptography.Oid FromFriendlyName(string friendlyName, System.Security.Cryptography.OidGroup group) { throw null; }
        public static System.Security.Cryptography.Oid FromOidValue(string oidValue, System.Security.Cryptography.OidGroup group) { throw null; }
    }
    public sealed partial class OidCollection : System.Collections.ICollection, System.Collections.IEnumerable
    {
        public OidCollection() { }
        public int Count { get { throw null; } }
        public bool IsSynchronized { get { throw null; } }
        public System.Security.Cryptography.Oid this[int index] { get { throw null; } }
        public System.Security.Cryptography.Oid this[string oid] { get { throw null; } }
        public object SyncRoot { get { throw null; } }
        public int Add(System.Security.Cryptography.Oid oid) { throw null; }
        public void CopyTo(System.Security.Cryptography.Oid[] array, int index) { }
        public System.Security.Cryptography.OidEnumerator GetEnumerator() { throw null; }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public sealed partial class OidEnumerator : System.Collections.IEnumerator
    {
        internal OidEnumerator() { }
        public System.Security.Cryptography.Oid Current { get { throw null; } }
        object System.Collections.IEnumerator.Current { get { throw null; } }
        public bool MoveNext() { throw null; }
        public void Reset() { }
    }
    public enum OidGroup
    {
        All = 0,
        Attribute = 5,
        EncryptionAlgorithm = 2,
        EnhancedKeyUsage = 7,
        ExtensionOrAttribute = 6,
        HashAlgorithm = 1,
        KeyDerivationFunction = 10,
        Policy = 8,
        PublicKeyAlgorithm = 3,
        SignatureAlgorithm = 4,
        Template = 9,
    }
    public enum PaddingMode
    {
        ANSIX923 = 4,
        ISO10126 = 5,
        None = 1,
        PKCS7 = 2,
        Zeros = 3,
    }
    public partial class PasswordDeriveBytes : System.Security.Cryptography.DeriveBytes
    {
        public PasswordDeriveBytes(byte[] password, byte[] salt) { }
        public PasswordDeriveBytes(byte[] password, byte[] salt, System.Security.Cryptography.CspParameters cspParams) { }
        public PasswordDeriveBytes(byte[] password, byte[] salt, string hashName, int iterations) { }
        public PasswordDeriveBytes(byte[] password, byte[] salt, string hashName, int iterations, System.Security.Cryptography.CspParameters cspParams) { }
        public PasswordDeriveBytes(string strPassword, byte[] rgbSalt) { }
        public PasswordDeriveBytes(string strPassword, byte[] rgbSalt, System.Security.Cryptography.CspParameters cspParams) { }
        public PasswordDeriveBytes(string strPassword, byte[] rgbSalt, string strHashName, int iterations) { }
        public PasswordDeriveBytes(string strPassword, byte[] rgbSalt, string strHashName, int iterations, System.Security.Cryptography.CspParameters cspParams) { }
        public string HashName { get { throw null; } set { } }
        public int IterationCount { get { throw null; } set { } }
        public byte[] Salt { get { throw null; } set { } }
        public byte[] CryptDeriveKey(string algname, string alghashname, int keySize, byte[] rgbIV) { throw null; }
        protected override void Dispose(bool disposing) { }
        [System.ObsoleteAttribute("Rfc2898DeriveBytes replaces PasswordDeriveBytes for deriving key material from a password and is preferred in new applications.")]
        public override byte[] GetBytes(int cb) { throw null; }
        public override void Reset() { }
    }
    public partial class PKCS1MaskGenerationMethod : System.Security.Cryptography.MaskGenerationMethod
    {
        public PKCS1MaskGenerationMethod() { }
        public string HashName { get { throw null; } set { } }
        public override byte[] GenerateMask(byte[] rgbSeed, int cbReturn) { throw null; }
    }
    public abstract partial class RandomNumberGenerator : System.IDisposable
    {
        protected RandomNumberGenerator() { }
        public static System.Security.Cryptography.RandomNumberGenerator Create() { throw null; }
        public static System.Security.Cryptography.RandomNumberGenerator Create(string rngName) { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public static void Fill(System.Span<byte> data) { }
        public abstract void GetBytes(byte[] data);
        public virtual void GetBytes(byte[] data, int offset, int count) { }
        public virtual void GetBytes(System.Span<byte> data) { }
        public virtual void GetNonZeroBytes(byte[] data) { }
        public virtual void GetNonZeroBytes(System.Span<byte> data) { }
    }
    public abstract partial class RC2 : System.Security.Cryptography.SymmetricAlgorithm
    {
        protected int EffectiveKeySizeValue;
        protected RC2() { }
        public virtual int EffectiveKeySize { get { throw null; } set { } }
        public override int KeySize { get { throw null; } set { } }
        public static new System.Security.Cryptography.RC2 Create() { throw null; }
        public static new System.Security.Cryptography.RC2 Create(string AlgName) { throw null; }
    }
    public sealed partial class RC2CryptoServiceProvider : System.Security.Cryptography.RC2
    {
        public RC2CryptoServiceProvider() { }
        public override int EffectiveKeySize { get { throw null; } set { } }
        public bool UseSalt { get { throw null; } set { } }
        public override System.Security.Cryptography.ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { throw null; }
        public override System.Security.Cryptography.ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { throw null; }
        public override void GenerateIV() { }
        public override void GenerateKey() { }
    }
    public partial class Rfc2898DeriveBytes : System.Security.Cryptography.DeriveBytes
    {
        public Rfc2898DeriveBytes(byte[] password, byte[] salt, int iterations) { }
        public Rfc2898DeriveBytes(string password, byte[] salt) { }
        public Rfc2898DeriveBytes(string password, byte[] salt, int iterations) { }
        public Rfc2898DeriveBytes(string password, int saltSize) { }
        public Rfc2898DeriveBytes(string password, int saltSize, int iterations) { }
        public int IterationCount { get { throw null; } set { } }
        public byte[] Salt { get { throw null; } set { } }
        public byte[] CryptDeriveKey(string algname, string alghashname, int keySize, byte[] rgbIV) { throw null; }
        protected override void Dispose(bool disposing) { }
        public override byte[] GetBytes(int cb) { throw null; }
        public override void Reset() { }
    }
    public abstract partial class Rijndael : System.Security.Cryptography.SymmetricAlgorithm
    {
        protected Rijndael() { }
        public static new System.Security.Cryptography.Rijndael Create() { throw null; }
        public static new System.Security.Cryptography.Rijndael Create(string algName) { throw null; }
    }
    public sealed partial class RijndaelManaged : System.Security.Cryptography.Rijndael
    {
        public RijndaelManaged() { }
        public override System.Security.Cryptography.ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { throw null; }
        public override System.Security.Cryptography.ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { throw null; }
        public override void GenerateIV() { }
        public override void GenerateKey() { }
    }
    public sealed partial class RNGCryptoServiceProvider : System.Security.Cryptography.RandomNumberGenerator
    {
        public RNGCryptoServiceProvider() { }
        public RNGCryptoServiceProvider(byte[] rgb) { }
        public RNGCryptoServiceProvider(System.Security.Cryptography.CspParameters cspParams) { }
        public RNGCryptoServiceProvider(string str) { }
        protected override void Dispose(bool disposing) { }
        public override void GetBytes(byte[] data) { }
        public override void GetNonZeroBytes(byte[] data) { }
    }
    public abstract partial class RSA : System.Security.Cryptography.AsymmetricAlgorithm
    {
        protected RSA() { }
        public override string KeyExchangeAlgorithm { get { throw null; } }
        public override string SignatureAlgorithm { get { throw null; } }
        public static new System.Security.Cryptography.RSA Create() { throw null; }
        public static new System.Security.Cryptography.RSA Create(string algName) { throw null; }
        public virtual byte[] Decrypt(byte[] data, System.Security.Cryptography.RSAEncryptionPadding padding) { throw null; }
        public virtual byte[] DecryptValue(byte[] rgb) { throw null; }
        public virtual byte[] Encrypt(byte[] data, System.Security.Cryptography.RSAEncryptionPadding padding) { throw null; }
        public virtual byte[] EncryptValue(byte[] rgb) { throw null; }
        public abstract System.Security.Cryptography.RSAParameters ExportParameters(bool includePrivateParameters);
        public override void FromXmlString(string xmlString) { }
        protected virtual byte[] HashData(byte[] data, int offset, int count, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { throw null; }
        protected virtual byte[] HashData(System.IO.Stream data, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { throw null; }
        public abstract void ImportParameters(System.Security.Cryptography.RSAParameters parameters);
        public virtual byte[] SignData(byte[] data, int offset, int count, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, System.Security.Cryptography.RSASignaturePadding padding) { throw null; }
        public byte[] SignData(byte[] data, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, System.Security.Cryptography.RSASignaturePadding padding) { throw null; }
        public virtual byte[] SignData(System.IO.Stream data, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, System.Security.Cryptography.RSASignaturePadding padding) { throw null; }
        public virtual byte[] SignHash(byte[] hash, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, System.Security.Cryptography.RSASignaturePadding padding) { throw null; }
        public override string ToXmlString(bool includePrivateParameters) { throw null; }
        public virtual bool TryDecrypt(System.ReadOnlySpan<byte> data, System.Span<byte> destination, System.Security.Cryptography.RSAEncryptionPadding padding, out int bytesWritten) { bytesWritten = default(int); throw null; }
        public virtual bool TryEncrypt(System.ReadOnlySpan<byte> data, System.Span<byte> destination, System.Security.Cryptography.RSAEncryptionPadding padding, out int bytesWritten) { bytesWritten = default(int); throw null; }
        protected virtual bool TryHashData(System.ReadOnlySpan<byte> data, System.Span<byte> destination, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, out int bytesWritten) { bytesWritten = default(int); throw null; }
        public virtual bool TrySignData(System.ReadOnlySpan<byte> data, System.Span<byte> destination, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, System.Security.Cryptography.RSASignaturePadding padding, out int bytesWritten) { bytesWritten = default(int); throw null; }
        public virtual bool TrySignHash(System.ReadOnlySpan<byte> hash, System.Span<byte> destination, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, System.Security.Cryptography.RSASignaturePadding padding, out int bytesWritten) { bytesWritten = default(int); throw null; }
        public bool VerifyData(byte[] data, byte[] signature, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, System.Security.Cryptography.RSASignaturePadding padding) { throw null; }
        public virtual bool VerifyData(byte[] data, int offset, int count, byte[] signature, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, System.Security.Cryptography.RSASignaturePadding padding) { throw null; }
        public bool VerifyData(System.IO.Stream data, byte[] signature, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, System.Security.Cryptography.RSASignaturePadding padding) { throw null; }
        public virtual bool VerifyData(System.ReadOnlySpan<byte> data, System.ReadOnlySpan<byte> signature, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, System.Security.Cryptography.RSASignaturePadding padding) { throw null; }
        public virtual bool VerifyHash(byte[] hash, byte[] signature, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, System.Security.Cryptography.RSASignaturePadding padding) { throw null; }
        public virtual bool VerifyHash(System.ReadOnlySpan<byte> hash, System.ReadOnlySpan<byte> signature, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, System.Security.Cryptography.RSASignaturePadding padding) { throw null; }
    }
    public sealed partial class RSACryptoServiceProvider : System.Security.Cryptography.RSA, System.Security.Cryptography.ICspAsymmetricAlgorithm
    {
        public RSACryptoServiceProvider() { }
        public RSACryptoServiceProvider(int dwKeySize) { }
        public RSACryptoServiceProvider(int dwKeySize, System.Security.Cryptography.CspParameters parameters) { }
        public RSACryptoServiceProvider(System.Security.Cryptography.CspParameters parameters) { }
        public System.Security.Cryptography.CspKeyContainerInfo CspKeyContainerInfo { get { throw null; } }
        public override string KeyExchangeAlgorithm { get { throw null; } }
        public override int KeySize { get { throw null; } }
        public bool PersistKeyInCsp { get { throw null; } set { } }
        public bool PublicOnly { get { throw null; } }
        public override string SignatureAlgorithm { get { throw null; } }
        public static bool UseMachineKeyStore { get { throw null; } set { } }
        public byte[] Decrypt(byte[] rgb, bool fOAEP) { throw null; }
        public override byte[] Decrypt(byte[] data, System.Security.Cryptography.RSAEncryptionPadding padding) { throw null; }
        public override byte[] DecryptValue(byte[] rgb) { throw null; }
        protected override void Dispose(bool disposing) { }
        public byte[] Encrypt(byte[] rgb, bool fOAEP) { throw null; }
        public override byte[] Encrypt(byte[] data, System.Security.Cryptography.RSAEncryptionPadding padding) { throw null; }
        public override byte[] EncryptValue(byte[] rgb) { throw null; }
        public byte[] ExportCspBlob(bool includePrivateParameters) { throw null; }
        public override System.Security.Cryptography.RSAParameters ExportParameters(bool includePrivateParameters) { throw null; }
        protected override byte[] HashData(byte[] data, int offset, int count, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { throw null; }
        protected override byte[] HashData(System.IO.Stream data, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { throw null; }
        public void ImportCspBlob(byte[] keyBlob) { }
        public override void ImportParameters(System.Security.Cryptography.RSAParameters parameters) { }
        public byte[] SignData(byte[] buffer, int offset, int count, object halg) { throw null; }
        public byte[] SignData(byte[] buffer, object halg) { throw null; }
        public byte[] SignData(System.IO.Stream inputStream, object halg) { throw null; }
        public override byte[] SignHash(byte[] hash, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, System.Security.Cryptography.RSASignaturePadding padding) { throw null; }
        public byte[] SignHash(byte[] rgbHash, string str) { throw null; }
        public bool VerifyData(byte[] buffer, object halg, byte[] signature) { throw null; }
        public override bool VerifyHash(byte[] hash, byte[] signature, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, System.Security.Cryptography.RSASignaturePadding padding) { throw null; }
        public bool VerifyHash(byte[] rgbHash, string str, byte[] rgbSignature) { throw null; }
    }
    public sealed partial class RSAEncryptionPadding : System.IEquatable<System.Security.Cryptography.RSAEncryptionPadding>
    {
        internal RSAEncryptionPadding() { }
        public System.Security.Cryptography.RSAEncryptionPaddingMode Mode { get { throw null; } }
        public System.Security.Cryptography.HashAlgorithmName OaepHashAlgorithm { get { throw null; } }
        public static System.Security.Cryptography.RSAEncryptionPadding OaepSHA1 { get { throw null; } }
        public static System.Security.Cryptography.RSAEncryptionPadding OaepSHA256 { get { throw null; } }
        public static System.Security.Cryptography.RSAEncryptionPadding OaepSHA384 { get { throw null; } }
        public static System.Security.Cryptography.RSAEncryptionPadding OaepSHA512 { get { throw null; } }
        public static System.Security.Cryptography.RSAEncryptionPadding Pkcs1 { get { throw null; } }
        public static System.Security.Cryptography.RSAEncryptionPadding CreateOaep(System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Security.Cryptography.RSAEncryptionPadding other) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Security.Cryptography.RSAEncryptionPadding left, System.Security.Cryptography.RSAEncryptionPadding right) { throw null; }
        public static bool operator !=(System.Security.Cryptography.RSAEncryptionPadding left, System.Security.Cryptography.RSAEncryptionPadding right) { throw null; }
        public override string ToString() { throw null; }
    }
    public enum RSAEncryptionPaddingMode
    {
        Oaep = 1,
        Pkcs1 = 0,
    }
    public partial class RSAOAEPKeyExchangeDeformatter : System.Security.Cryptography.AsymmetricKeyExchangeDeformatter
    {
        public RSAOAEPKeyExchangeDeformatter() { }
        public RSAOAEPKeyExchangeDeformatter(System.Security.Cryptography.AsymmetricAlgorithm key) { }
        public override string Parameters { get { throw null; } set { } }
        public override byte[] DecryptKeyExchange(byte[] rgbData) { throw null; }
        public override void SetKey(System.Security.Cryptography.AsymmetricAlgorithm key) { }
    }
    public partial class RSAOAEPKeyExchangeFormatter : System.Security.Cryptography.AsymmetricKeyExchangeFormatter
    {
        public RSAOAEPKeyExchangeFormatter() { }
        public RSAOAEPKeyExchangeFormatter(System.Security.Cryptography.AsymmetricAlgorithm key) { }
        public byte[] Parameter { get { throw null; } set { } }
        public override string Parameters { get { throw null; } }
        public System.Security.Cryptography.RandomNumberGenerator Rng { get { throw null; } set { } }
        public override byte[] CreateKeyExchange(byte[] rgbData) { throw null; }
        public override byte[] CreateKeyExchange(byte[] rgbData, System.Type symAlgType) { throw null; }
        public override void SetKey(System.Security.Cryptography.AsymmetricAlgorithm key) { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct RSAParameters
    {
        public byte[] D;
        public byte[] DP;
        public byte[] DQ;
        public byte[] Exponent;
        public byte[] InverseQ;
        public byte[] Modulus;
        public byte[] P;
        public byte[] Q;
    }
    public partial class RSAPKCS1KeyExchangeDeformatter : System.Security.Cryptography.AsymmetricKeyExchangeDeformatter
    {
        public RSAPKCS1KeyExchangeDeformatter() { }
        public RSAPKCS1KeyExchangeDeformatter(System.Security.Cryptography.AsymmetricAlgorithm key) { }
        public override string Parameters { get { throw null; } set { } }
        public System.Security.Cryptography.RandomNumberGenerator RNG { get { throw null; } set { } }
        public override byte[] DecryptKeyExchange(byte[] rgbIn) { throw null; }
        public override void SetKey(System.Security.Cryptography.AsymmetricAlgorithm key) { }
    }
    public partial class RSAPKCS1KeyExchangeFormatter : System.Security.Cryptography.AsymmetricKeyExchangeFormatter
    {
        public RSAPKCS1KeyExchangeFormatter() { }
        public RSAPKCS1KeyExchangeFormatter(System.Security.Cryptography.AsymmetricAlgorithm key) { }
        public override string Parameters { get { throw null; } }
        public System.Security.Cryptography.RandomNumberGenerator Rng { get { throw null; } set { } }
        public override byte[] CreateKeyExchange(byte[] rgbData) { throw null; }
        public override byte[] CreateKeyExchange(byte[] rgbData, System.Type symAlgType) { throw null; }
        public override void SetKey(System.Security.Cryptography.AsymmetricAlgorithm key) { }
    }
    public partial class RSAPKCS1SignatureDeformatter : System.Security.Cryptography.AsymmetricSignatureDeformatter
    {
        public RSAPKCS1SignatureDeformatter() { }
        public RSAPKCS1SignatureDeformatter(System.Security.Cryptography.AsymmetricAlgorithm key) { }
        public override void SetHashAlgorithm(string strName) { }
        public override void SetKey(System.Security.Cryptography.AsymmetricAlgorithm key) { }
        public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { throw null; }
    }
    public partial class RSAPKCS1SignatureFormatter : System.Security.Cryptography.AsymmetricSignatureFormatter
    {
        public RSAPKCS1SignatureFormatter() { }
        public RSAPKCS1SignatureFormatter(System.Security.Cryptography.AsymmetricAlgorithm key) { }
        public override byte[] CreateSignature(byte[] rgbHash) { throw null; }
        public override void SetHashAlgorithm(string strName) { }
        public override void SetKey(System.Security.Cryptography.AsymmetricAlgorithm key) { }
    }
    public sealed partial class RSASignaturePadding : System.IEquatable<System.Security.Cryptography.RSASignaturePadding>
    {
        internal RSASignaturePadding() { }
        public System.Security.Cryptography.RSASignaturePaddingMode Mode { get { throw null; } }
        public static System.Security.Cryptography.RSASignaturePadding Pkcs1 { get { throw null; } }
        public static System.Security.Cryptography.RSASignaturePadding Pss { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Security.Cryptography.RSASignaturePadding other) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Security.Cryptography.RSASignaturePadding left, System.Security.Cryptography.RSASignaturePadding right) { throw null; }
        public static bool operator !=(System.Security.Cryptography.RSASignaturePadding left, System.Security.Cryptography.RSASignaturePadding right) { throw null; }
        public override string ToString() { throw null; }
    }
    public enum RSASignaturePaddingMode
    {
        Pkcs1 = 0,
        Pss = 1,
    }
    public abstract partial class SHA1 : System.Security.Cryptography.HashAlgorithm
    {
        protected SHA1() { }
        public static new System.Security.Cryptography.SHA1 Create() { throw null; }
        public static new System.Security.Cryptography.SHA1 Create(string hashName) { throw null; }
    }
    public sealed partial class SHA1CryptoServiceProvider : System.Security.Cryptography.SHA1
    {
        public SHA1CryptoServiceProvider() { }
        protected override void Dispose(bool disposing) { }
        protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }
        protected override byte[] HashFinal() { throw null; }
        public override void Initialize() { }
    }
    public sealed partial class SHA1Managed : System.Security.Cryptography.SHA1
    {
        public SHA1Managed() { }
        protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }
        protected sealed override void HashCore(System.ReadOnlySpan<byte> source) { }
        protected override byte[] HashFinal() { throw null; }
        public override void Initialize() { }
        protected sealed override bool TryHashFinal(System.Span<byte> destination, out int bytesWritten) { bytesWritten = default(int); throw null; }
    }
    public abstract partial class SHA256 : System.Security.Cryptography.HashAlgorithm
    {
        protected SHA256() { }
        public static new System.Security.Cryptography.SHA256 Create() { throw null; }
        public static new System.Security.Cryptography.SHA256 Create(string hashName) { throw null; }
    }
    public sealed partial class SHA256CryptoServiceProvider : System.Security.Cryptography.SHA256
    {
        public SHA256CryptoServiceProvider() { }
        protected override void Dispose(bool disposing) { }
        protected override void HashCore(byte[] array, int ibStart, int cbSize) { }
        protected override byte[] HashFinal() { throw null; }
        public override void Initialize() { }
    }
    public sealed partial class SHA256Managed : System.Security.Cryptography.SHA256
    {
        public SHA256Managed() { }
        protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }
        protected sealed override void HashCore(System.ReadOnlySpan<byte> source) { }
        protected override byte[] HashFinal() { throw null; }
        public override void Initialize() { }
        protected sealed override bool TryHashFinal(System.Span<byte> destination, out int bytesWritten) { bytesWritten = default(int); throw null; }
    }
    public abstract partial class SHA384 : System.Security.Cryptography.HashAlgorithm
    {
        protected SHA384() { }
        public static new System.Security.Cryptography.SHA384 Create() { throw null; }
        public static new System.Security.Cryptography.SHA384 Create(string hashName) { throw null; }
    }
    public sealed partial class SHA384CryptoServiceProvider : System.Security.Cryptography.SHA384
    {
        public SHA384CryptoServiceProvider() { }
        protected override void Dispose(bool disposing) { }
        protected override void HashCore(byte[] array, int ibStart, int cbSize) { }
        protected override byte[] HashFinal() { throw null; }
        public override void Initialize() { }
    }
    public sealed partial class SHA384Managed : System.Security.Cryptography.SHA384
    {
        public SHA384Managed() { }
        protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }
        protected sealed override void HashCore(System.ReadOnlySpan<byte> source) { }
        protected override byte[] HashFinal() { throw null; }
        public override void Initialize() { }
        protected sealed override bool TryHashFinal(System.Span<byte> destination, out int bytesWritten) { bytesWritten = default(int); throw null; }
    }
    public abstract partial class SHA512 : System.Security.Cryptography.HashAlgorithm
    {
        protected SHA512() { }
        public static new System.Security.Cryptography.SHA512 Create() { throw null; }
        public static new System.Security.Cryptography.SHA512 Create(string hashName) { throw null; }
    }
    public sealed partial class SHA512CryptoServiceProvider : System.Security.Cryptography.SHA512
    {
        public SHA512CryptoServiceProvider() { }
        protected override void Dispose(bool disposing) { }
        protected override void HashCore(byte[] array, int ibStart, int cbSize) { }
        protected override byte[] HashFinal() { throw null; }
        public override void Initialize() { }
    }
    public sealed partial class SHA512Managed : System.Security.Cryptography.SHA512
    {
        public SHA512Managed() { }
        protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }
        protected sealed override void HashCore(System.ReadOnlySpan<byte> source) { }
        protected override byte[] HashFinal() { throw null; }
        public override void Initialize() { }
        protected sealed override bool TryHashFinal(System.Span<byte> destination, out int bytesWritten) { bytesWritten = default(int); throw null; }
    }
    public partial class SignatureDescription
    {
        public SignatureDescription() { }
        public SignatureDescription(System.Security.SecurityElement el) { }
        public string DeformatterAlgorithm { get { throw null; } set { } }
        public string DigestAlgorithm { get { throw null; } set { } }
        public string FormatterAlgorithm { get { throw null; } set { } }
        public string KeyAlgorithm { get { throw null; } set { } }
        public virtual System.Security.Cryptography.AsymmetricSignatureDeformatter CreateDeformatter(System.Security.Cryptography.AsymmetricAlgorithm key) { throw null; }
        public virtual System.Security.Cryptography.HashAlgorithm CreateDigest() { throw null; }
        public virtual System.Security.Cryptography.AsymmetricSignatureFormatter CreateFormatter(System.Security.Cryptography.AsymmetricAlgorithm key) { throw null; }
    }
    public abstract partial class SymmetricAlgorithm : System.IDisposable
    {
        protected int BlockSizeValue;
        protected int FeedbackSizeValue;
        protected byte[] IVValue;
        protected int KeySizeValue;
        protected byte[] KeyValue;
        protected System.Security.Cryptography.KeySizes[] LegalBlockSizesValue;
        protected System.Security.Cryptography.KeySizes[] LegalKeySizesValue;
        protected System.Security.Cryptography.CipherMode ModeValue;
        protected System.Security.Cryptography.PaddingMode PaddingValue;
        protected SymmetricAlgorithm() { }
        public virtual int BlockSize { get { throw null; } set { } }
        public virtual int FeedbackSize { get { throw null; } set { } }
        public virtual byte[] IV { get { throw null; } set { } }
        public virtual byte[] Key { get { throw null; } set { } }
        public virtual int KeySize { get { throw null; } set { } }
        public virtual System.Security.Cryptography.KeySizes[] LegalBlockSizes { get { throw null; } }
        public virtual System.Security.Cryptography.KeySizes[] LegalKeySizes { get { throw null; } }
        public virtual System.Security.Cryptography.CipherMode Mode { get { throw null; } set { } }
        public virtual System.Security.Cryptography.PaddingMode Padding { get { throw null; } set { } }
        public void Clear() { }
        public static System.Security.Cryptography.SymmetricAlgorithm Create() { throw null; }
        public static System.Security.Cryptography.SymmetricAlgorithm Create(string algName) { throw null; }
        public virtual System.Security.Cryptography.ICryptoTransform CreateDecryptor() { throw null; }
        public abstract System.Security.Cryptography.ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV);
        public virtual System.Security.Cryptography.ICryptoTransform CreateEncryptor() { throw null; }
        public abstract System.Security.Cryptography.ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV);
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public abstract void GenerateIV();
        public abstract void GenerateKey();
        public bool ValidKeySize(int bitLength) { throw null; }
    }
    public partial class ToBase64Transform : System.IDisposable, System.Security.Cryptography.ICryptoTransform
    {
        public ToBase64Transform() { }
        public virtual bool CanReuseTransform { get { throw null; } }
        public bool CanTransformMultipleBlocks { get { throw null; } }
        public int InputBlockSize { get { throw null; } }
        public int OutputBlockSize { get { throw null; } }
        public void Clear() { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        ~ToBase64Transform() { }
        public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { throw null; }
        public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { throw null; }
    }
    public abstract partial class TripleDES : System.Security.Cryptography.SymmetricAlgorithm
    {
        protected TripleDES() { }
        public override byte[] Key { get { throw null; } set { } }
        public static new System.Security.Cryptography.TripleDES Create() { throw null; }
        public static new System.Security.Cryptography.TripleDES Create(string str) { throw null; }
        public static bool IsWeakKey(byte[] rgbKey) { throw null; }
    }
    public sealed partial class TripleDESCryptoServiceProvider : System.Security.Cryptography.TripleDES
    {
        public TripleDESCryptoServiceProvider() { }
        public override System.Security.Cryptography.ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { throw null; }
        public override System.Security.Cryptography.ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { throw null; }
        public override void GenerateIV() { }
        public override void GenerateKey() { }
    }
}
