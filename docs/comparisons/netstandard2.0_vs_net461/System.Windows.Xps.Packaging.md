# System.Windows.Xps.Packaging

``` diff
+namespace System.Windows.Xps.Packaging {
+    public interface IDocumentStructureProvider {
+        XpsStructure AddDocumentStructure();
+    }
+    public interface IStoryFragmentProvider {
+        XpsStructure AddStoryFragment();
+    }
+    public interface IXpsFixedDocumentReader : IDocumentStructureProvider {
+        int DocumentNumber { get; }
+        XpsStructure DocumentStructure { get; }
+        ReadOnlyCollection<IXpsFixedPageReader> FixedPages { get; }
+        PrintTicket PrintTicket { get; }
+        ICollection<XpsSignatureDefinition> SignatureDefinitions { get; }
+        XpsThumbnail Thumbnail { get; }
+        Uri Uri { get; }
+        void AddSignatureDefinition(XpsSignatureDefinition signatureDefinition);
+        void CommitSignatureDefinition();
+        IXpsFixedPageReader GetFixedPage(Uri pageSource);
+        void RemoveSignatureDefinition(XpsSignatureDefinition signatureDefinition);
+    }
+    public interface IXpsFixedDocumentSequenceReader {
+        ReadOnlyCollection<IXpsFixedDocumentReader> FixedDocuments { get; }
+        PrintTicket PrintTicket { get; }
+        XpsThumbnail Thumbnail { get; }
+        Uri Uri { get; }
+        IXpsFixedDocumentReader GetFixedDocument(Uri documentSource);
+    }
+    public interface IXpsFixedDocumentSequenceWriter {
+        PrintTicket PrintTicket { set; }
+        Uri Uri { get; }
+        IXpsFixedDocumentWriter AddFixedDocument();
+        XpsThumbnail AddThumbnail(XpsImageType imageType);
+        void Commit();
+    }
+    public interface IXpsFixedDocumentWriter : IDocumentStructureProvider {
+        int DocumentNumber { get; }
+        PrintTicket PrintTicket { set; }
+        Uri Uri { get; }
+        IXpsFixedPageWriter AddFixedPage();
+        XpsThumbnail AddThumbnail(XpsImageType imageType);
+        void Commit();
+    }
+    public interface IXpsFixedPageReader : IStoryFragmentProvider {
+        ICollection<XpsColorContext> ColorContexts { get; }
+        ICollection<XpsFont> Fonts { get; }
+        ICollection<XpsImage> Images { get; }
+        int PageNumber { get; }
+        PrintTicket PrintTicket { get; }
+        ICollection<XpsResourceDictionary> ResourceDictionaries { get; }
+        XpsStructure StoryFragment { get; }
+        XpsThumbnail Thumbnail { get; }
+        Uri Uri { get; }
+        XmlReader XmlReader { get; }
+        XpsColorContext GetColorContext(Uri uri);
+        XpsFont GetFont(Uri uri);
+        XpsImage GetImage(Uri uri);
+        XpsResource GetResource(Uri resourceUri);
+        XpsResourceDictionary GetResourceDictionary(Uri uri);
+    }
+    public interface IXpsFixedPageWriter : IStoryFragmentProvider {
+        IList<string> LinkTargetStream { get; }
+        int PageNumber { get; }
+        PrintTicket PrintTicket { set; }
+        Uri Uri { get; }
+        XmlWriter XmlWriter { get; }
+        XpsColorContext AddColorContext();
+        XpsFont AddFont();
+        XpsFont AddFont(bool obfuscate);
+        XpsFont AddFont(bool obfuscate, bool addRestrictedRelationship);
+        XpsImage AddImage(string mimeType);
+        XpsImage AddImage(XpsImageType imageType);
+        XpsResource AddResource(Type resourceType, Uri resourceUri);
+        XpsResourceDictionary AddResourceDictionary();
+        XpsThumbnail AddThumbnail(XpsImageType imageType);
+        void Commit();
+    }
+    public enum PackageInterleavingOrder {
+        ImagesLast = 3,
+        None = 0,
+        ResourceFirst = 1,
+        ResourceLast = 2,
+    }
+    public enum PackagingAction {
+        AddingDocumentSequence = 1,
+        AddingFixedDocument = 3,
+        AddingFixedPage = 5,
+        DocumentSequenceCompleted = 2,
+        FixedDocumentCompleted = 4,
+        FixedPageCompleted = 6,
+        FontAdded = 8,
+        ImageAdded = 9,
+        None = 0,
+        ResourceAdded = 7,
+        XpsDocumentCommitted = 10,
+    }
+    public class PackagingProgressEventArgs : EventArgs {
+        public PackagingProgressEventArgs(PackagingAction action, int numberCompleted);
+        public PackagingAction Action { get; }
+        public int NumberCompleted { get; }
+    }
+    public delegate void PackagingProgressEventHandler(object sender, PackagingProgressEventArgs e);
+    public class SpotLocation {
+        public SpotLocation();
+        public Uri PageUri { get; set; }
+        public double StartX { get; set; }
+        public double StartY { get; set; }
+    }
+    public class XpsColorContext : XpsResource
+    public class XpsDigitalSignature {
+        public XpsDigitalSignature(PackageDigitalSignature packageSignature, XpsDocument package);
+        public bool DocumentPropertiesRestricted { get; }
+        public Nullable<Guid> Id { get; }
+        public bool IsCertificateAvailable { get; }
+        public bool SignatureOriginRestricted { get; }
+        public string SignatureType { get; }
+        public byte[] SignatureValue { get; }
+        public IXpsFixedDocumentSequenceReader SignedDocumentSequence { get; }
+        public X509Certificate SignerCertificate { get; }
+        public DateTime SigningTime { get; }
+        public VerifyResult Verify();
+        public VerifyResult Verify(X509Certificate certificate);
+        public X509ChainStatusFlags VerifyCertificate();
+        public static X509ChainStatusFlags VerifyCertificate(X509Certificate certificate);
+    }
+    public enum XpsDigSigPartAlteringRestrictions {
+        Annotations = 2,
+        CoreMetadata = 1,
+        None = 0,
+        SignatureOrigin = 4,
+    }
+    public class XpsDocument : XpsPartBase, IDisposable, INode {
+        public XpsDocument(Package package);
+        public XpsDocument(Package package, CompressionOption compressionOption);
+        public XpsDocument(Package package, CompressionOption compressionOption, string path);
+        public XpsDocument(string path, FileAccess packageAccess);
+        public XpsDocument(string path, FileAccess packageAccess, CompressionOption compressionOption);
+        public PackageProperties CoreDocumentProperties { get; }
+        public IXpsFixedDocumentSequenceReader FixedDocumentSequenceReader { get; }
+        public bool IsReader { get; }
+        public bool IsSignable { get; }
+        public bool IsWriter { get; }
+        public ReadOnlyCollection<XpsDigitalSignature> Signatures { get; }
+        public XpsThumbnail Thumbnail { get; set; }
+        public IXpsFixedDocumentSequenceWriter AddFixedDocumentSequence();
+        public XpsThumbnail AddThumbnail(XpsImageType imageType);
+        public void Close();
+        public static XpsDocumentWriter CreateXpsDocumentWriter(XpsDocument xpsDocument);
+        protected virtual void Dispose(bool disposing);
+        public FixedDocumentSequence GetFixedDocumentSequence();
+        public void RemoveSignature(XpsDigitalSignature signature);
+        public XpsDigitalSignature SignDigitally(X509Certificate certificate, bool embedCertificate, XpsDigSigPartAlteringRestrictions restrictions);
+        public XpsDigitalSignature SignDigitally(X509Certificate certificate, bool embedCertificate, XpsDigSigPartAlteringRestrictions restrictions, Guid id);
+        public XpsDigitalSignature SignDigitally(X509Certificate certificate, bool embedCertificate, XpsDigSigPartAlteringRestrictions restrictions, Guid id, bool testIsSignable);
+        void System.IDisposable.Dispose();
+    }
+    public class XpsFont : XpsResource {
+        public bool IsObfuscated { get; }
+        public bool IsRestricted { get; set; }
+        public static void ObfuscateFontData(byte[] fontData, Guid guid);
+    }
+    public class XpsImage : XpsResource
+    public enum XpsImageType {
+        JpegImageType = 1,
+        PngImageType = 0,
+        TiffImageType = 2,
+        WdpImageType = 3,
+    }
+    public abstract class XpsPartBase {
+        public Uri Uri { get; set; }
+    }
+    public class XpsResource : XpsPartBase, IDisposable, INode {
+        public void Commit();
+        public virtual Stream GetStream();
+        public Uri RelativeUri(Uri inUri);
+        void System.IDisposable.Dispose();
+    }
+    public class XpsResourceDictionary : XpsResource
+    public enum XpsResourceSharing {
+        NoResourceSharing = 1,
+        ShareResources = 0,
+    }
+    public class XpsSignatureDefinition {
+        public XpsSignatureDefinition();
+        public CultureInfo Culture { get; set; }
+        public bool HasBeenModified { get; set; }
+        public string Intent { get; set; }
+        public string RequestedSigner { get; set; }
+        public Nullable<DateTime> SignBy { get; set; }
+        public string SigningLocale { get; set; }
+        public Nullable<Guid> SpotId { get; set; }
+        public SpotLocation SpotLocation { get; set; }
+    }
+    public class XpsStructure : XpsResource
+    public class XpsThumbnail : XpsResource
+}
```

