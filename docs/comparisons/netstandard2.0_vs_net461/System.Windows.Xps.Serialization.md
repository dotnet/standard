# System.Windows.Xps.Serialization

``` diff
+namespace System.Windows.Xps.Serialization {
+    public abstract class BasePackagingPolicy : IDisposable {
+        protected BasePackagingPolicy();
+        public abstract Uri CurrentFixedDocumentUri { get; }
+        public abstract Uri CurrentFixedPageUri { get; }
+        public abstract XpsResourceStream AcquireResourceStreamForXpsColorContext(string resourceId);
+        public abstract XpsResourceStream AcquireResourceStreamForXpsFont();
+        public abstract XpsResourceStream AcquireResourceStreamForXpsFont(string resourceId);
+        public abstract XpsResourceStream AcquireResourceStreamForXpsImage(string resourceId);
+        public abstract XpsResourceStream AcquireResourceStreamForXpsResourceDictionary(string resourceId);
+        public abstract IList<string> AcquireStreamForLinkTargets();
+        public abstract XmlWriter AcquireXmlWriterForFixedDocument();
+        public abstract XmlWriter AcquireXmlWriterForFixedDocumentSequence();
+        public abstract XmlWriter AcquireXmlWriterForFixedPage();
+        public abstract XmlWriter AcquireXmlWriterForPage();
+        public abstract XmlWriter AcquireXmlWriterForResourceDictionary();
+        public abstract void PersistPrintTicket(PrintTicket printTicket);
+        public abstract void PreCommitCurrentPage();
+        public abstract void RelateResourceToCurrentPage(Uri targetUri, string relationshipName);
+        public abstract void RelateRestrictedFontToCurrentDocument(Uri targetUri);
+        public abstract void ReleaseResourceStreamForXpsColorContext();
+        public abstract void ReleaseResourceStreamForXpsFont();
+        public abstract void ReleaseResourceStreamForXpsFont(string resourceId);
+        public abstract void ReleaseResourceStreamForXpsImage();
+        public abstract void ReleaseResourceStreamForXpsResourceDictionary();
+        public abstract void ReleaseXmlWriterForFixedDocument();
+        public abstract void ReleaseXmlWriterForFixedDocumentSequence();
+        public abstract void ReleaseXmlWriterForFixedPage();
+        void System.IDisposable.Dispose();
+    }
+    public class ColorTypeConverter : ExpandableObjectConverter {
+        public ColorTypeConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes);
+        public static string SerializeColorContext(IServiceProvider context, ColorContext colorContext);
+    }
+    public enum FontSubsetterCommitPolicies {
+        CommitEntireSequence = 3,
+        CommitPerDocument = 2,
+        CommitPerPage = 1,
+        None = 0,
+    }
+    public class FontTypeConverter : ExpandableObjectConverter {
+        public FontTypeConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes);
+    }
+    public class ImageSourceTypeConverter : ExpandableObjectConverter {
+        public ImageSourceTypeConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes);
+    }
+    public abstract class PackageSerializationManager : IDisposable {
+        protected PackageSerializationManager();
+        public abstract void SaveAsXaml(object serializedObject);
+        void System.IDisposable.Dispose();
+    }
+    public enum PrintTicketLevel {
+        FixedDocumentPrintTicket = 2,
+        FixedDocumentSequencePrintTicket = 1,
+        FixedPagePrintTicket = 3,
+        None = 0,
+    }
+    public enum SerializationState {
+        Normal = 0,
+        Stop = 1,
+    }
+    public class XpsPackagingPolicy : BasePackagingPolicy {
+        public XpsPackagingPolicy(XpsDocument xpsPackage);
+        public XpsPackagingPolicy(XpsDocument xpsPackage, PackageInterleavingOrder interleavingType);
+        public override Uri CurrentFixedDocumentUri { get; }
+        public override Uri CurrentFixedPageUri { get; }
+        public event PackagingProgressEventHandler PackagingProgressEvent;
+        public override XpsResourceStream AcquireResourceStreamForXpsColorContext(string resourceId);
+        public override XpsResourceStream AcquireResourceStreamForXpsFont();
+        public override XpsResourceStream AcquireResourceStreamForXpsFont(string resourceId);
+        public override XpsResourceStream AcquireResourceStreamForXpsImage(string resourceId);
+        public override XpsResourceStream AcquireResourceStreamForXpsResourceDictionary(string resourceId);
+        public override IList<string> AcquireStreamForLinkTargets();
+        public override XmlWriter AcquireXmlWriterForFixedDocument();
+        public override XmlWriter AcquireXmlWriterForFixedDocumentSequence();
+        public override XmlWriter AcquireXmlWriterForFixedPage();
+        public override XmlWriter AcquireXmlWriterForPage();
+        public override XmlWriter AcquireXmlWriterForResourceDictionary();
+        public override void PersistPrintTicket(PrintTicket printTicket);
+        public override void PreCommitCurrentPage();
+        public override void RelateResourceToCurrentPage(Uri targetUri, string relationshipName);
+        public override void RelateRestrictedFontToCurrentDocument(Uri targetUri);
+        public override void ReleaseResourceStreamForXpsColorContext();
+        public override void ReleaseResourceStreamForXpsFont();
+        public override void ReleaseResourceStreamForXpsFont(string resourceId);
+        public override void ReleaseResourceStreamForXpsImage();
+        public override void ReleaseResourceStreamForXpsResourceDictionary();
+        public override void ReleaseXmlWriterForFixedDocument();
+        public override void ReleaseXmlWriterForFixedDocumentSequence();
+        public override void ReleaseXmlWriterForFixedPage();
+    }
+    public class XpsResourceStream {
+        public XpsResourceStream(Stream stream, Uri uri);
+        public Stream Stream { get; }
+        public Uri Uri { get; }
+        public void Initialize();
+    }
+    public class XpsSerializationCompletedEventArgs : AsyncCompletedEventArgs {
+        public XpsSerializationCompletedEventArgs(bool canceled, object state, Exception exception);
+    }
+    public delegate void XpsSerializationCompletedEventHandler(object sender, XpsSerializationCompletedEventArgs e);
+    public class XpsSerializationManager : PackageSerializationManager {
+        public XpsSerializationManager(BasePackagingPolicy packagingPolicy, bool batchMode);
+        public bool IsBatchMode { get; }
+        public event XpsSerializationPrintTicketRequiredEventHandler XpsSerializationPrintTicketRequired;
+        public event XpsSerializationProgressChangedEventHandler XpsSerializationProgressChanged;
+        public virtual void Commit();
+        public override void SaveAsXaml(object serializedObject);
+        public void SetFontSubsettingCountPolicy(int countPolicy);
+        public void SetFontSubsettingPolicy(FontSubsetterCommitPolicies policy);
+    }
+    public sealed class XpsSerializationManagerAsync : XpsSerializationManager {
+        public XpsSerializationManagerAsync(BasePackagingPolicy packagingPolicy, bool batchMode);
+        public event XpsSerializationCompletedEventHandler XpsSerializationCompleted;
+        public void CancelAsync();
+        public override void Commit();
+        public override void SaveAsXaml(object serializedObject);
+    }
+    public class XpsSerializationPrintTicketRequiredEventArgs : EventArgs {
+        public XpsSerializationPrintTicketRequiredEventArgs(PrintTicketLevel printTicketLevel, int sequence);
+        public PrintTicket PrintTicket { get; set; }
+        public PrintTicketLevel PrintTicketLevel { get; }
+        public int Sequence { get; }
+    }
+    public delegate void XpsSerializationPrintTicketRequiredEventHandler(object sender, XpsSerializationPrintTicketRequiredEventArgs e);
+    public class XpsSerializationProgressChangedEventArgs : ProgressChangedEventArgs {
+        public XpsSerializationProgressChangedEventArgs(XpsWritingProgressChangeLevel writingLevel, int pageNumber, int progressPercentage, object userToken);
+        public int PageNumber { get; }
+        public XpsWritingProgressChangeLevel WritingLevel { get; }
+    }
+    public delegate void XpsSerializationProgressChangedEventHandler(object sender, XpsSerializationProgressChangedEventArgs e);
+    public sealed class XpsSerializerFactory : ISerializerFactory {
+        public XpsSerializerFactory();
+        public string DefaultFileExtension { get; }
+        public string DisplayName { get; }
+        public string ManufacturerName { get; }
+        public Uri ManufacturerWebsite { get; }
+        public SerializerWriter CreateSerializerWriter(Stream stream);
+    }
+    public enum XpsWritingProgressChangeLevel {
+        FixedDocumentSequenceWritingProgress = 1,
+        FixedDocumentWritingProgress = 2,
+        FixedPageWritingProgress = 3,
+        None = 0,
+    }
+}
```

