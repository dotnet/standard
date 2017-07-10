# System.Drawing.Printing

``` diff
+namespace System.Drawing.Printing {
+    public enum Duplex {
+        Default = -1,
+        Horizontal = 3,
+        Simplex = 1,
+        Vertical = 2,
+    }
+    public class InvalidPrinterException : SystemException {
+        public InvalidPrinterException(PrinterSettings settings);
+        protected InvalidPrinterException(SerializationInfo info, StreamingContext context);
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class Margins : ICloneable {
+        public Margins();
+        public Margins(int left, int right, int top, int bottom);
+        public int Bottom { get; set; }
+        public int Left { get; set; }
+        public int Right { get; set; }
+        public int Top { get; set; }
+        public object Clone();
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public static bool operator ==(Margins m1, Margins m2);
+        public static bool operator !=(Margins m1, Margins m2);
+        public override string ToString();
+    }
+    public class MarginsConverter : ExpandableObjectConverter {
+        public MarginsConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+        public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues);
+        public override bool GetCreateInstanceSupported(ITypeDescriptorContext context);
+    }
+    public class PageSettings : ICloneable {
+        public PageSettings();
+        public PageSettings(PrinterSettings printerSettings);
+        public Rectangle Bounds { get; }
+        public bool Color { get; set; }
+        public float HardMarginX { get; }
+        public float HardMarginY { get; }
+        public bool Landscape { get; set; }
+        public Margins Margins { get; set; }
+        public PaperSize PaperSize { get; set; }
+        public PaperSource PaperSource { get; set; }
+        public RectangleF PrintableArea { get; }
+        public PrinterResolution PrinterResolution { get; set; }
+        public PrinterSettings PrinterSettings { get; set; }
+        public object Clone();
+        public void CopyToHdevmode(IntPtr hdevmode);
+        public void SetHdevmode(IntPtr hdevmode);
+        public override string ToString();
+    }
+    public enum PaperKind {
+        A2 = 66,
+        A3 = 8,
+        A3Extra = 63,
+        A3ExtraTransverse = 68,
+        A3Rotated = 76,
+        A3Transverse = 67,
+        A4 = 9,
+        A4Extra = 53,
+        A4Plus = 60,
+        A4Rotated = 77,
+        A4Small = 10,
+        A4Transverse = 55,
+        A5 = 11,
+        A5Extra = 64,
+        A5Rotated = 78,
+        A5Transverse = 61,
+        A6 = 70,
+        A6Rotated = 83,
+        APlus = 57,
+        B4 = 12,
+        B4Envelope = 33,
+        B4JisRotated = 79,
+        B5 = 13,
+        B5Envelope = 34,
+        B5Extra = 65,
+        B5JisRotated = 80,
+        B5Transverse = 62,
+        B6Envelope = 35,
+        B6Jis = 88,
+        B6JisRotated = 89,
+        BPlus = 58,
+        C3Envelope = 29,
+        C4Envelope = 30,
+        C5Envelope = 28,
+        C65Envelope = 32,
+        C6Envelope = 31,
+        CSheet = 24,
+        Custom = 0,
+        DLEnvelope = 27,
+        DSheet = 25,
+        ESheet = 26,
+        Executive = 7,
+        Folio = 14,
+        GermanLegalFanfold = 41,
+        GermanStandardFanfold = 40,
+        InviteEnvelope = 47,
+        IsoB4 = 42,
+        ItalyEnvelope = 36,
+        JapaneseDoublePostcard = 69,
+        JapaneseDoublePostcardRotated = 82,
+        JapaneseEnvelopeChouNumber3 = 73,
+        JapaneseEnvelopeChouNumber3Rotated = 86,
+        JapaneseEnvelopeChouNumber4 = 74,
+        JapaneseEnvelopeChouNumber4Rotated = 87,
+        JapaneseEnvelopeKakuNumber2 = 71,
+        JapaneseEnvelopeKakuNumber2Rotated = 84,
+        JapaneseEnvelopeKakuNumber3 = 72,
+        JapaneseEnvelopeKakuNumber3Rotated = 85,
+        JapaneseEnvelopeYouNumber4 = 91,
+        JapaneseEnvelopeYouNumber4Rotated = 92,
+        JapanesePostcard = 43,
+        JapanesePostcardRotated = 81,
+        Ledger = 4,
+        Legal = 5,
+        LegalExtra = 51,
+        Letter = 1,
+        LetterExtra = 50,
+        LetterExtraTransverse = 56,
+        LetterPlus = 59,
+        LetterRotated = 75,
+        LetterSmall = 2,
+        LetterTransverse = 54,
+        MonarchEnvelope = 37,
+        Note = 18,
+        Number10Envelope = 20,
+        Number11Envelope = 21,
+        Number12Envelope = 22,
+        Number14Envelope = 23,
+        Number9Envelope = 19,
+        PersonalEnvelope = 38,
+        Prc16K = 93,
+        Prc16KRotated = 106,
+        Prc32K = 94,
+        Prc32KBig = 95,
+        Prc32KBigRotated = 108,
+        Prc32KRotated = 107,
+        PrcEnvelopeNumber1 = 96,
+        PrcEnvelopeNumber10 = 105,
+        PrcEnvelopeNumber10Rotated = 118,
+        PrcEnvelopeNumber1Rotated = 109,
+        PrcEnvelopeNumber2 = 97,
+        PrcEnvelopeNumber2Rotated = 110,
+        PrcEnvelopeNumber3 = 98,
+        PrcEnvelopeNumber3Rotated = 111,
+        PrcEnvelopeNumber4 = 99,
+        PrcEnvelopeNumber4Rotated = 112,
+        PrcEnvelopeNumber5 = 100,
+        PrcEnvelopeNumber5Rotated = 113,
+        PrcEnvelopeNumber6 = 101,
+        PrcEnvelopeNumber6Rotated = 114,
+        PrcEnvelopeNumber7 = 102,
+        PrcEnvelopeNumber7Rotated = 115,
+        PrcEnvelopeNumber8 = 103,
+        PrcEnvelopeNumber8Rotated = 116,
+        PrcEnvelopeNumber9 = 104,
+        PrcEnvelopeNumber9Rotated = 117,
+        Quarto = 15,
+        Standard10x11 = 45,
+        Standard10x14 = 16,
+        Standard11x17 = 17,
+        Standard12x11 = 90,
+        Standard15x11 = 46,
+        Standard9x11 = 44,
+        Statement = 6,
+        Tabloid = 3,
+        TabloidExtra = 52,
+        USStandardFanfold = 39,
+    }
+    public class PaperSize {
+        public PaperSize();
+        public PaperSize(string name, int width, int height);
+        public int Height { get; set; }
+        public PaperKind Kind { get; }
+        public string PaperName { get; set; }
+        public int RawKind { get; set; }
+        public int Width { get; set; }
+        public override string ToString();
+    }
+    public class PaperSource {
+        public PaperSource();
+        public PaperSourceKind Kind { get; }
+        public int RawKind { get; set; }
+        public string SourceName { get; set; }
+        public override string ToString();
+    }
+    public enum PaperSourceKind {
+        AutomaticFeed = 7,
+        Cassette = 14,
+        Custom = 257,
+        Envelope = 5,
+        FormSource = 15,
+        LargeCapacity = 11,
+        LargeFormat = 10,
+        Lower = 2,
+        Manual = 4,
+        ManualFeed = 6,
+        Middle = 3,
+        SmallFormat = 9,
+        TractorFeed = 8,
+        Upper = 1,
+    }
+    public sealed class PreviewPageInfo {
+        public PreviewPageInfo(Image image, Size physicalSize);
+        public Image Image { get; }
+        public Size PhysicalSize { get; }
+    }
+    public class PreviewPrintController : PrintController {
+        public PreviewPrintController();
+        public override bool IsPreview { get; }
+        public virtual bool UseAntiAlias { get; set; }
+        public PreviewPageInfo[] GetPreviewPageInfo();
+        public override void OnEndPage(PrintDocument document, PrintPageEventArgs e);
+        public override void OnEndPrint(PrintDocument document, PrintEventArgs e);
+        public override Graphics OnStartPage(PrintDocument document, PrintPageEventArgs e);
+        public override void OnStartPrint(PrintDocument document, PrintEventArgs e);
+    }
+    public enum PrintAction {
+        PrintToFile = 0,
+        PrintToPreview = 1,
+        PrintToPrinter = 2,
+    }
+    public abstract class PrintController {
+        protected PrintController();
+        public virtual bool IsPreview { get; }
+        public virtual void OnEndPage(PrintDocument document, PrintPageEventArgs e);
+        public virtual void OnEndPrint(PrintDocument document, PrintEventArgs e);
+        public virtual Graphics OnStartPage(PrintDocument document, PrintPageEventArgs e);
+        public virtual void OnStartPrint(PrintDocument document, PrintEventArgs e);
+    }
+    public class PrintDocument : Component {
+        public PrintDocument();
+        public PageSettings DefaultPageSettings { get; set; }
+        public string DocumentName { get; set; }
+        public bool OriginAtMargins { get; set; }
+        public PrintController PrintController { get; set; }
+        public PrinterSettings PrinterSettings { get; set; }
+        public event PrintEventHandler BeginPrint;
+        public event PrintEventHandler EndPrint;
+        public event PrintPageEventHandler PrintPage;
+        public event QueryPageSettingsEventHandler QueryPageSettings;
+        protected virtual void OnBeginPrint(PrintEventArgs e);
+        protected virtual void OnEndPrint(PrintEventArgs e);
+        protected virtual void OnPrintPage(PrintPageEventArgs e);
+        protected virtual void OnQueryPageSettings(QueryPageSettingsEventArgs e);
+        public void Print();
+        public override string ToString();
+    }
+    public class PrinterResolution {
+        public PrinterResolution();
+        public PrinterResolutionKind Kind { get; set; }
+        public int X { get; set; }
+        public int Y { get; set; }
+        public override string ToString();
+    }
+    public enum PrinterResolutionKind {
+        Custom = 0,
+        Draft = -1,
+        High = -4,
+        Low = -2,
+        Medium = -3,
+    }
+    public class PrinterSettings : ICloneable {
+        public PrinterSettings();
+        public bool CanDuplex { get; }
+        public bool Collate { get; set; }
+        public short Copies { get; set; }
+        public PageSettings DefaultPageSettings { get; }
+        public Duplex Duplex { get; set; }
+        public int FromPage { get; set; }
+        public static PrinterSettings.StringCollection InstalledPrinters { get; }
+        public bool IsDefaultPrinter { get; }
+        public bool IsPlotter { get; }
+        public bool IsValid { get; }
+        public int LandscapeAngle { get; }
+        public int MaximumCopies { get; }
+        public int MaximumPage { get; set; }
+        public int MinimumPage { get; set; }
+        public PrinterSettings.PaperSizeCollection PaperSizes { get; }
+        public PrinterSettings.PaperSourceCollection PaperSources { get; }
+        public string PrinterName { get; set; }
+        public PrinterSettings.PrinterResolutionCollection PrinterResolutions { get; }
+        public string PrintFileName { get; set; }
+        public PrintRange PrintRange { get; set; }
+        public bool PrintToFile { get; set; }
+        public bool SupportsColor { get; }
+        public int ToPage { get; set; }
+        public object Clone();
+        public Graphics CreateMeasurementGraphics();
+        public Graphics CreateMeasurementGraphics(bool honorOriginAtMargins);
+        public Graphics CreateMeasurementGraphics(PageSettings pageSettings);
+        public Graphics CreateMeasurementGraphics(PageSettings pageSettings, bool honorOriginAtMargins);
+        public IntPtr GetHdevmode();
+        public IntPtr GetHdevmode(PageSettings pageSettings);
+        public IntPtr GetHdevnames();
+        public bool IsDirectPrintingSupported(Image image);
+        public bool IsDirectPrintingSupported(ImageFormat imageFormat);
+        public void SetHdevmode(IntPtr hdevmode);
+        public void SetHdevnames(IntPtr hdevnames);
+        public override string ToString();
+        public class PaperSizeCollection : ICollection, IEnumerable {
+            public PaperSizeCollection(PaperSize[] array);
+            public int Count { get; }
+            int System.Collections.ICollection.Count { get; }
+            bool System.Collections.ICollection.IsSynchronized { get; }
+            object System.Collections.ICollection.SyncRoot { get; }
+            public virtual PaperSize this[int index] { get; }
+            public int Add(PaperSize paperSize);
+            public void CopyTo(PaperSize[] paperSizes, int index);
+            public IEnumerator GetEnumerator();
+            void System.Collections.ICollection.CopyTo(Array array, int index);
+            IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        }
+        public class PaperSourceCollection : ICollection, IEnumerable {
+            public PaperSourceCollection(PaperSource[] array);
+            public int Count { get; }
+            int System.Collections.ICollection.Count { get; }
+            bool System.Collections.ICollection.IsSynchronized { get; }
+            object System.Collections.ICollection.SyncRoot { get; }
+            public virtual PaperSource this[int index] { get; }
+            public int Add(PaperSource paperSource);
+            public void CopyTo(PaperSource[] paperSources, int index);
+            public IEnumerator GetEnumerator();
+            void System.Collections.ICollection.CopyTo(Array array, int index);
+            IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        }
+        public class PrinterResolutionCollection : ICollection, IEnumerable {
+            public PrinterResolutionCollection(PrinterResolution[] array);
+            public int Count { get; }
+            int System.Collections.ICollection.Count { get; }
+            bool System.Collections.ICollection.IsSynchronized { get; }
+            object System.Collections.ICollection.SyncRoot { get; }
+            public virtual PrinterResolution this[int index] { get; }
+            public int Add(PrinterResolution printerResolution);
+            public void CopyTo(PrinterResolution[] printerResolutions, int index);
+            public IEnumerator GetEnumerator();
+            void System.Collections.ICollection.CopyTo(Array array, int index);
+            IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        }
+        public class StringCollection : ICollection, IEnumerable {
+            public StringCollection(string[] array);
+            public int Count { get; }
+            int System.Collections.ICollection.Count { get; }
+            bool System.Collections.ICollection.IsSynchronized { get; }
+            object System.Collections.ICollection.SyncRoot { get; }
+            public virtual string this[int index] { get; }
+            public int Add(string value);
+            public void CopyTo(string[] strings, int index);
+            public IEnumerator GetEnumerator();
+            void System.Collections.ICollection.CopyTo(Array array, int index);
+            IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        }
+    }
+    public enum PrinterUnit {
+        Display = 0,
+        HundredthsOfAMillimeter = 2,
+        TenthsOfAMillimeter = 3,
+        ThousandthsOfAnInch = 1,
+    }
+    public sealed class PrinterUnitConvert {
+        public static double Convert(double value, PrinterUnit fromUnit, PrinterUnit toUnit);
+        public static Point Convert(Point value, PrinterUnit fromUnit, PrinterUnit toUnit);
+        public static Margins Convert(Margins value, PrinterUnit fromUnit, PrinterUnit toUnit);
+        public static Rectangle Convert(Rectangle value, PrinterUnit fromUnit, PrinterUnit toUnit);
+        public static Size Convert(Size value, PrinterUnit fromUnit, PrinterUnit toUnit);
+        public static int Convert(int value, PrinterUnit fromUnit, PrinterUnit toUnit);
+    }
+    public class PrintEventArgs : CancelEventArgs {
+        public PrintEventArgs();
+        public PrintAction PrintAction { get; }
+    }
+    public delegate void PrintEventHandler(object sender, PrintEventArgs e);
+    public sealed class PrintingPermission : CodeAccessPermission, IUnrestrictedPermission {
+        public PrintingPermission(PrintingPermissionLevel printingLevel);
+        public PrintingPermission(PermissionState state);
+        public PrintingPermissionLevel Level { get; set; }
+        public override IPermission Copy();
+        public override void FromXml(SecurityElement esd);
+        public override IPermission Intersect(IPermission target);
+        public override bool IsSubsetOf(IPermission target);
+        public bool IsUnrestricted();
+        public override SecurityElement ToXml();
+        public override IPermission Union(IPermission target);
+    }
+    public sealed class PrintingPermissionAttribute : CodeAccessSecurityAttribute {
+        public PrintingPermissionAttribute(SecurityAction action);
+        public PrintingPermissionLevel Level { get; set; }
+        public override IPermission CreatePermission();
+    }
+    public enum PrintingPermissionLevel {
+        AllPrinting = 3,
+        DefaultPrinting = 2,
+        NoPrinting = 0,
+        SafePrinting = 1,
+    }
+    public class PrintPageEventArgs : EventArgs {
+        public PrintPageEventArgs(Graphics graphics, Rectangle marginBounds, Rectangle pageBounds, PageSettings pageSettings);
+        public bool Cancel { get; set; }
+        public Graphics Graphics { get; }
+        public bool HasMorePages { get; set; }
+        public Rectangle MarginBounds { get; }
+        public Rectangle PageBounds { get; }
+        public PageSettings PageSettings { get; }
+    }
+    public delegate void PrintPageEventHandler(object sender, PrintPageEventArgs e);
+    public enum PrintRange {
+        AllPages = 0,
+        CurrentPage = 4194304,
+        Selection = 1,
+        SomePages = 2,
+    }
+    public class QueryPageSettingsEventArgs : PrintEventArgs {
+        public QueryPageSettingsEventArgs(PageSettings pageSettings);
+        public PageSettings PageSettings { get; set; }
+    }
+    public delegate void QueryPageSettingsEventHandler(object sender, QueryPageSettingsEventArgs e);
+    public class StandardPrintController : PrintController {
+        public StandardPrintController();
+        public override void OnEndPage(PrintDocument document, PrintPageEventArgs e);
+        public override void OnEndPrint(PrintDocument document, PrintEventArgs e);
+        public override Graphics OnStartPage(PrintDocument document, PrintPageEventArgs e);
+        public override void OnStartPrint(PrintDocument document, PrintEventArgs e);
+    }
+}
```

