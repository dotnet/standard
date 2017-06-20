# System.IO.Packaging

``` diff
+namespace System.IO.Packaging {
+    public enum CertificateEmbeddingOption {
+        InCertificatePart = 0,
+        InSignaturePart = 1,
+        NotEmbedded = 2,
+    }
+    public enum CompressionOption {
+        Fast = 2,
+        Maximum = 1,
+        Normal = 0,
+        NotCompressed = -1,
+        SuperFast = 3,
+    }
+    public class EncryptedPackageEnvelope : IDisposable {
+        public FileAccess FileOpenAccess { get; }
+        public PackageProperties PackageProperties { get; }
+        public RightsManagementInformation RightsManagementInformation { get; }
+        public StorageInfo StorageInfo { get; }
+        public void Close();
+        public static EncryptedPackageEnvelope Create(Stream envelopeStream, PublishLicense publishLicense, CryptoProvider cryptoProvider);
+        public static EncryptedPackageEnvelope Create(string envelopeFileName, PublishLicense publishLicense, CryptoProvider cryptoProvider);
+        public static EncryptedPackageEnvelope CreateFromPackage(Stream envelopeStream, Stream packageStream, PublishLicense publishLicense, CryptoProvider cryptoProvider);
+        public static EncryptedPackageEnvelope CreateFromPackage(string envelopeFileName, Stream packageStream, PublishLicense publishLicense, CryptoProvider cryptoProvider);
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        public void Flush();
+        public Package GetPackage();
+        public static bool IsEncryptedPackageEnvelope(Stream stream);
+        public static bool IsEncryptedPackageEnvelope(string fileName);
+        public static EncryptedPackageEnvelope Open(Stream envelopeStream);
+        public static EncryptedPackageEnvelope Open(string envelopeFileName);
+        public static EncryptedPackageEnvelope Open(string envelopeFileName, FileAccess access);
+        public static EncryptedPackageEnvelope Open(string envelopeFileName, FileAccess access, FileShare sharing);
+    }
+    public enum EncryptionOption {
+        None = 0,
+        RightsManagement = 1,
+    }
+    public delegate void InvalidSignatureEventHandler(object sender, SignatureVerificationEventArgs e);
+    public abstract class Package : IDisposable {
+        protected Package(FileAccess openFileAccess);
+        protected Package(FileAccess openFileAccess, bool streaming);
+        public FileAccess FileOpenAccess { get; }
+        public PackageProperties PackageProperties { get; }
+        public void Close();
+        public PackagePart CreatePart(Uri partUri, string contentType);
+        public PackagePart CreatePart(Uri partUri, string contentType, CompressionOption compressionOption);
+        protected abstract PackagePart CreatePartCore(Uri partUri, string contentType, CompressionOption compressionOption);
+        public PackageRelationship CreateRelationship(Uri targetUri, TargetMode targetMode, string relationshipType);
+        public PackageRelationship CreateRelationship(Uri targetUri, TargetMode targetMode, string relationshipType, string id);
+        public void DeletePart(Uri partUri);
+        protected abstract void DeletePartCore(Uri partUri);
+        public void DeleteRelationship(string id);
+        protected virtual void Dispose(bool disposing);
+        public void Flush();
+        protected abstract void FlushCore();
+        public PackagePart GetPart(Uri partUri);
+        protected abstract PackagePart GetPartCore(Uri partUri);
+        public PackagePartCollection GetParts();
+        protected abstract PackagePart[] GetPartsCore();
+        public PackageRelationship GetRelationship(string id);
+        public PackageRelationshipCollection GetRelationships();
+        public PackageRelationshipCollection GetRelationshipsByType(string relationshipType);
+        public static Package Open(Stream stream);
+        public static Package Open(Stream stream, FileMode packageMode);
+        public static Package Open(Stream stream, FileMode packageMode, FileAccess packageAccess);
+        public static Package Open(string path);
+        public static Package Open(string path, FileMode packageMode);
+        public static Package Open(string path, FileMode packageMode, FileAccess packageAccess);
+        public static Package Open(string path, FileMode packageMode, FileAccess packageAccess, FileShare packageShare);
+        public virtual bool PartExists(Uri partUri);
+        public bool RelationshipExists(string id);
+        void System.IDisposable.Dispose();
+    }
+    public class PackageDigitalSignature {
+        public CertificateEmbeddingOption CertificateEmbeddingOption { get; }
+        public Signature Signature { get; set; }
+        public PackagePart SignaturePart { get; }
+        public string SignatureType { get; }
+        public byte[] SignatureValue { get; }
+        public ReadOnlyCollection<Uri> SignedParts { get; }
+        public ReadOnlyCollection<PackageRelationshipSelector> SignedRelationshipSelectors { get; }
+        public X509Certificate Signer { get; }
+        public DateTime SigningTime { get; }
+        public string TimeFormat { get; }
+        public List<string> GetPartTransformList(Uri partName);
+        public VerifyResult Verify();
+        public VerifyResult Verify(X509Certificate signingCertificate);
+    }
+    public sealed class PackageDigitalSignatureManager {
+        public PackageDigitalSignatureManager(Package package);
+        public CertificateEmbeddingOption CertificateOption { get; set; }
+        public static string DefaultHashAlgorithm { get; }
+        public string HashAlgorithm { get; set; }
+        public bool IsSigned { get; }
+        public IntPtr ParentWindow { get; set; }
+        public Uri SignatureOrigin { get; }
+        public static string SignatureOriginRelationshipType { get; }
+        public ReadOnlyCollection<PackageDigitalSignature> Signatures { get; }
+        public string TimeFormat { get; set; }
+        public Dictionary<string, string> TransformMapping { get; }
+        public event InvalidSignatureEventHandler InvalidSignatureEvent;
+        public PackageDigitalSignature Countersign();
+        public PackageDigitalSignature Countersign(X509Certificate certificate);
+        public PackageDigitalSignature Countersign(X509Certificate certificate, IEnumerable<Uri> signatures);
+        public PackageDigitalSignature GetSignature(Uri signatureUri);
+        public void RemoveAllSignatures();
+        public void RemoveSignature(Uri signatureUri);
+        public PackageDigitalSignature Sign(IEnumerable<Uri> parts);
+        public PackageDigitalSignature Sign(IEnumerable<Uri> parts, X509Certificate certificate);
+        public PackageDigitalSignature Sign(IEnumerable<Uri> parts, X509Certificate certificate, IEnumerable<PackageRelationshipSelector> relationshipSelectors);
+        public PackageDigitalSignature Sign(IEnumerable<Uri> parts, X509Certificate certificate, IEnumerable<PackageRelationshipSelector> relationshipSelectors, string signatureId);
+        public PackageDigitalSignature Sign(IEnumerable<Uri> parts, X509Certificate certificate, IEnumerable<PackageRelationshipSelector> relationshipSelectors, string signatureId, IEnumerable<DataObject> signatureObjects, IEnumerable<Reference> objectReferences);
+        public static X509ChainStatusFlags VerifyCertificate(X509Certificate certificate);
+        public VerifyResult VerifySignatures(bool exitOnFailure);
+    }
+    public abstract class PackagePart {
+        protected PackagePart(Package package, Uri partUri);
+        protected PackagePart(Package package, Uri partUri, string contentType);
+        protected PackagePart(Package package, Uri partUri, string contentType, CompressionOption compressionOption);
+        public CompressionOption CompressionOption { get; }
+        public string ContentType { get; }
+        public Package Package { get; }
+        public Uri Uri { get; }
+        public PackageRelationship CreateRelationship(Uri targetUri, TargetMode targetMode, string relationshipType);
+        public PackageRelationship CreateRelationship(Uri targetUri, TargetMode targetMode, string relationshipType, string id);
+        public void DeleteRelationship(string id);
+        protected virtual string GetContentTypeCore();
+        public PackageRelationship GetRelationship(string id);
+        public PackageRelationshipCollection GetRelationships();
+        public PackageRelationshipCollection GetRelationshipsByType(string relationshipType);
+        public Stream GetStream();
+        public Stream GetStream(FileMode mode);
+        public Stream GetStream(FileMode mode, FileAccess access);
+        protected abstract Stream GetStreamCore(FileMode mode, FileAccess access);
+        public bool RelationshipExists(string id);
+    }
+    public class PackagePartCollection : IEnumerable, IEnumerable<PackagePart> {
+        public IEnumerator<PackagePart> GetEnumerator();
+        IEnumerator<PackagePart> System.Collections.Generic.IEnumerable<System.IO.Packaging.PackagePart>.GetEnumerator();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+    }
+    public abstract class PackageProperties : IDisposable {
+        protected PackageProperties();
+        public abstract string Category { get; set; }
+        public abstract string ContentStatus { get; set; }
+        public abstract string ContentType { get; set; }
+        public abstract Nullable<DateTime> Created { get; set; }
+        public abstract string Creator { get; set; }
+        public abstract string Description { get; set; }
+        public abstract string Identifier { get; set; }
+        public abstract string Keywords { get; set; }
+        public abstract string Language { get; set; }
+        public abstract string LastModifiedBy { get; set; }
+        public abstract Nullable<DateTime> LastPrinted { get; set; }
+        public abstract Nullable<DateTime> Modified { get; set; }
+        public abstract string Revision { get; set; }
+        public abstract string Subject { get; set; }
+        public abstract string Title { get; set; }
+        public abstract string Version { get; set; }
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+    }
+    public class PackageRelationship {
+        public string Id { get; }
+        public Package Package { get; }
+        public string RelationshipType { get; }
+        public Uri SourceUri { get; }
+        public TargetMode TargetMode { get; }
+        public Uri TargetUri { get; }
+    }
+    public class PackageRelationshipCollection : IEnumerable, IEnumerable<PackageRelationship> {
+        public IEnumerator<PackageRelationship> GetEnumerator();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+    }
+    public sealed class PackageRelationshipSelector {
+        public PackageRelationshipSelector(Uri sourceUri, PackageRelationshipSelectorType selectorType, string selectionCriteria);
+        public string SelectionCriteria { get; }
+        public PackageRelationshipSelectorType SelectorType { get; }
+        public Uri SourceUri { get; }
+        public List<PackageRelationship> Select(Package package);
+    }
+    public enum PackageRelationshipSelectorType {
+        Id = 0,
+        Type = 1,
+    }
+    public static class PackageStore {
+        public static void AddPackage(Uri uri, Package package);
+        public static Package GetPackage(Uri uri);
+        public static void RemovePackage(Uri uri);
+    }
+    public static class PackUriHelper {
+        public static readonly string UriSchemePack;
+        public static int ComparePackUri(Uri firstPackUri, Uri secondPackUri);
+        public static int ComparePartUri(Uri firstPartUri, Uri secondPartUri);
+        public static Uri Create(Uri packageUri);
+        public static Uri Create(Uri packageUri, Uri partUri);
+        public static Uri Create(Uri packageUri, Uri partUri, string fragment);
+        public static Uri CreatePartUri(Uri partUri);
+        public static Uri GetNormalizedPartUri(Uri partUri);
+        public static Uri GetPackageUri(Uri packUri);
+        public static Uri GetPartUri(Uri packUri);
+        public static Uri GetRelationshipPartUri(Uri partUri);
+        public static Uri GetRelativeUri(Uri sourcePartUri, Uri targetPartUri);
+        public static Uri GetSourcePartUriFromRelationshipPartUri(Uri relationshipPartUri);
+        public static bool IsRelationshipPartUri(Uri partUri);
+        public static Uri ResolvePartUri(Uri sourcePartUri, Uri targetUri);
+    }
+    public sealed class PackWebRequest : WebRequest {
+        public override RequestCachePolicy CachePolicy { get; set; }
+        public override string ConnectionGroupName { get; set; }
+        public override long ContentLength { get; set; }
+        public override string ContentType { get; set; }
+        public override ICredentials Credentials { get; set; }
+        public override WebHeaderCollection Headers { get; set; }
+        public override string Method { get; set; }
+        public override bool PreAuthenticate { get; set; }
+        public override IWebProxy Proxy { get; set; }
+        public override Uri RequestUri { get; }
+        public override int Timeout { get; set; }
+        public override bool UseDefaultCredentials { get; set; }
+        public WebRequest GetInnerRequest();
+        public override Stream GetRequestStream();
+        public override WebResponse GetResponse();
+    }
+    public sealed class PackWebRequestFactory : IWebRequestCreate {
+        public PackWebRequestFactory();
+        WebRequest System.Net.IWebRequestCreate.Create(Uri uri);
+    }
+    public sealed class PackWebResponse : WebResponse {
+        public override long ContentLength { get; }
+        public override string ContentType { get; }
+        public override WebHeaderCollection Headers { get; }
+        public WebResponse InnerResponse { get; }
+        public override bool IsFromCache { get; }
+        public override Uri ResponseUri { get; }
+        public override void Close();
+        protected override void Dispose(bool disposing);
+        public override Stream GetResponseStream();
+    }
+    public class RightsManagementInformation {
+        public CryptoProvider CryptoProvider { get; set; }
+        public void DeleteUseLicense(ContentUser userKey);
+        public IDictionary<ContentUser, UseLicense> GetEmbeddedUseLicenses();
+        public PublishLicense LoadPublishLicense();
+        public UseLicense LoadUseLicense(ContentUser userKey);
+        public void SavePublishLicense(PublishLicense publishLicense);
+        public void SaveUseLicense(ContentUser userKey, UseLicense useLicense);
+    }
+    public class SignatureVerificationEventArgs : EventArgs {
+        public PackageDigitalSignature Signature { get; }
+        public VerifyResult VerifyResult { get; }
+    }
+    public class StorageInfo {
+        public string Name { get; }
+        public StreamInfo CreateStream(string name);
+        public StreamInfo CreateStream(string name, CompressionOption compressionOption, EncryptionOption encryptionOption);
+        public StorageInfo CreateSubStorage(string name);
+        public void DeleteStream(string name);
+        public void DeleteSubStorage(string name);
+        public StreamInfo GetStreamInfo(string name);
+        public StreamInfo[] GetStreams();
+        public StorageInfo GetSubStorageInfo(string name);
+        public StorageInfo[] GetSubStorages();
+        public bool StreamExists(string name);
+        public bool SubStorageExists(string name);
+    }
+    public class StreamInfo {
+        public CompressionOption CompressionOption { get; }
+        public EncryptionOption EncryptionOption { get; }
+        public string Name { get; }
+        public Stream GetStream();
+        public Stream GetStream(FileMode mode);
+        public Stream GetStream(FileMode mode, FileAccess access);
+    }
+    public enum TargetMode {
+        External = 1,
+        Internal = 0,
+    }
+    public enum VerifyResult {
+        CertificateRequired = 2,
+        InvalidCertificate = 3,
+        InvalidSignature = 1,
+        NotSigned = 5,
+        ReferenceNotFound = 4,
+        Success = 0,
+    }
+    public sealed class ZipPackage : Package {
+        protected override PackagePart CreatePartCore(Uri partUri, string contentType, CompressionOption compressionOption);
+        protected override void DeletePartCore(Uri partUri);
+        protected override void Dispose(bool disposing);
+        protected override void FlushCore();
+        protected override PackagePart GetPartCore(Uri partUri);
+        protected override PackagePart[] GetPartsCore();
+    }
+    public sealed class ZipPackagePart : PackagePart {
+        protected override Stream GetStreamCore(FileMode mode, FileAccess access);
+    }
+}
```

