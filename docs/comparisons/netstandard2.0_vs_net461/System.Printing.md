# System.Printing

``` diff
+namespace System.Printing {
+    public enum Collation {
+        Collated = 1,
+        Uncollated = 2,
+        Unknown = 0,
+    }
+    public enum ConflictStatus {
+        ConflictResolved = 1,
+        NoConflict = 0,
+    }
+    public enum DeviceFontSubstitution {
+        Off = 1,
+        On = 2,
+        Unknown = 0,
+    }
+    public enum Duplexing {
+        OneSided = 1,
+        TwoSidedLongEdge = 3,
+        TwoSidedShortEdge = 2,
+        Unknown = 0,
+    }
+    public enum EnumeratedPrintQueueTypes {
+        Connections = 16,
+        DirectPrinting = 2,
+        EnableBidi = 2048,
+        EnableDevQuery = 128,
+        Fax = 16384,
+        KeepPrintedJobs = 256,
+        Local = 64,
+        PublishedInDirectoryServices = 8192,
+        PushedMachineConnection = 262144,
+        PushedUserConnection = 131072,
+        Queued = 1,
+        RawOnly = 4096,
+        Shared = 8,
+        TerminalServer = 32768,
+        WorkOffline = 1024,
+    }
+    public enum InputBin {
+        AutoSelect = 1,
+        AutoSheetFeeder = 4,
+        Cassette = 2,
+        Manual = 5,
+        Tractor = 3,
+        Unknown = 0,
+    }
+    public sealed class LocalPrintServer : PrintServer {
+        public LocalPrintServer();
+        public LocalPrintServer(LocalPrintServerIndexedProperty[] propertiesFilter);
+        public LocalPrintServer(LocalPrintServerIndexedProperty[] propertiesFilter, PrintSystemDesiredAccess desiredAccess);
+        public LocalPrintServer(PrintSystemDesiredAccess desiredAccess);
+        public LocalPrintServer(string[] propertiesFilter);
+        public LocalPrintServer(string[] propertiesFilter, PrintSystemDesiredAccess desiredAccess);
+        public PrintQueue DefaultPrintQueue { get; set; }
+        public sealed override void Commit();
+        public bool ConnectToPrintQueue(PrintQueue printer);
+        public bool ConnectToPrintQueue(string printQueuePath);
+        public bool DisconnectFromPrintQueue(PrintQueue printer);
+        public bool DisconnectFromPrintQueue(string printQueuePath);
+        public static PrintQueue GetDefaultPrintQueue();
+        public sealed override void Refresh();
+    }
+    public enum LocalPrintServerIndexedProperty {
+        BeepEnabled = 5,
+        DefaultPortThreadPriority = 2,
+        DefaultPrintQueue = 12,
+        DefaultSchedulerPriority = 4,
+        DefaultSpoolDirectory = 0,
+        EventLog = 7,
+        MajorVersion = 8,
+        MinorVersion = 9,
+        NetPopup = 6,
+        PortThreadPriority = 1,
+        RestartJobOnPoolEnabled = 11,
+        RestartJobOnPoolTimeout = 10,
+        SchedulerPriority = 3,
+    }
+    public enum OutputColor {
+        Color = 1,
+        Grayscale = 2,
+        Monochrome = 3,
+        Unknown = 0,
+    }
+    public enum OutputQuality {
+        Automatic = 1,
+        Draft = 2,
+        Fax = 3,
+        High = 4,
+        Normal = 5,
+        Photographic = 6,
+        Text = 7,
+        Unknown = 0,
+    }
+    public enum PageBorderless {
+        Borderless = 1,
+        None = 2,
+        Unknown = 0,
+    }
+    public sealed class PageImageableArea {
+        public double ExtentHeight { get; }
+        public double ExtentWidth { get; }
+        public double OriginHeight { get; }
+        public double OriginWidth { get; }
+        public override string ToString();
+    }
+    public sealed class PageMediaSize {
+        public PageMediaSize(double width, double height);
+        public PageMediaSize(PageMediaSizeName mediaSizeName);
+        public PageMediaSize(PageMediaSizeName mediaSizeName, double width, double height);
+        public Nullable<double> Height { get; }
+        public Nullable<PageMediaSizeName> PageMediaSizeName { get; }
+        public Nullable<double> Width { get; }
+        public override string ToString();
+    }
+    public enum PageMediaSizeName {
+        BusinessCard = 169,
+        CreditCard = 170,
+        ISOA0 = 1,
+        ISOA1 = 2,
+        ISOA10 = 3,
+        ISOA2 = 4,
+        ISOA3 = 5,
+        ISOA3Extra = 7,
+        ISOA3Rotated = 6,
+        ISOA4 = 8,
+        ISOA4Extra = 10,
+        ISOA4Rotated = 9,
+        ISOA5 = 11,
+        ISOA5Extra = 13,
+        ISOA5Rotated = 12,
+        ISOA6 = 14,
+        ISOA6Rotated = 15,
+        ISOA7 = 16,
+        ISOA8 = 17,
+        ISOA9 = 18,
+        ISOB0 = 19,
+        ISOB1 = 20,
+        ISOB10 = 21,
+        ISOB2 = 22,
+        ISOB3 = 23,
+        ISOB4 = 24,
+        ISOB4Envelope = 25,
+        ISOB5Envelope = 26,
+        ISOB5Extra = 27,
+        ISOB7 = 28,
+        ISOB8 = 29,
+        ISOB9 = 30,
+        ISOC0 = 31,
+        ISOC1 = 32,
+        ISOC10 = 33,
+        ISOC2 = 34,
+        ISOC3 = 35,
+        ISOC3Envelope = 36,
+        ISOC4 = 37,
+        ISOC4Envelope = 38,
+        ISOC5 = 39,
+        ISOC5Envelope = 40,
+        ISOC6 = 41,
+        ISOC6C5Envelope = 43,
+        ISOC6Envelope = 42,
+        ISOC7 = 44,
+        ISOC8 = 45,
+        ISOC9 = 46,
+        ISODLEnvelope = 47,
+        ISODLEnvelopeRotated = 48,
+        ISOSRA3 = 49,
+        Japan2LPhoto = 156,
+        JapanChou3Envelope = 65,
+        JapanChou3EnvelopeRotated = 66,
+        JapanChou4Envelope = 67,
+        JapanChou4EnvelopeRotated = 68,
+        JapanDoubleHagakiPostcard = 153,
+        JapanDoubleHagakiPostcardRotated = 154,
+        JapanHagakiPostcard = 69,
+        JapanHagakiPostcardRotated = 70,
+        JapanKaku2Envelope = 71,
+        JapanKaku2EnvelopeRotated = 72,
+        JapanKaku3Envelope = 73,
+        JapanKaku3EnvelopeRotated = 74,
+        JapanLPhoto = 155,
+        JapanQuadrupleHagakiPostcard = 50,
+        JapanYou1Envelope = 157,
+        JapanYou2Envelope = 158,
+        JapanYou3Envelope = 159,
+        JapanYou4Envelope = 75,
+        JapanYou4EnvelopeRotated = 160,
+        JapanYou6Envelope = 161,
+        JapanYou6EnvelopeRotated = 162,
+        JISB0 = 51,
+        JISB1 = 52,
+        JISB10 = 53,
+        JISB2 = 54,
+        JISB3 = 55,
+        JISB4 = 56,
+        JISB4Rotated = 57,
+        JISB5 = 58,
+        JISB5Rotated = 59,
+        JISB6 = 60,
+        JISB6Rotated = 61,
+        JISB7 = 62,
+        JISB8 = 63,
+        JISB9 = 64,
+        NorthAmerica10x11 = 76,
+        NorthAmerica10x12 = 167,
+        NorthAmerica10x14 = 77,
+        NorthAmerica11x17 = 78,
+        NorthAmerica14x17 = 168,
+        NorthAmerica4x6 = 163,
+        NorthAmerica4x8 = 164,
+        NorthAmerica5x7 = 165,
+        NorthAmerica8x10 = 166,
+        NorthAmerica9x11 = 79,
+        NorthAmericaArchitectureASheet = 80,
+        NorthAmericaArchitectureBSheet = 81,
+        NorthAmericaArchitectureCSheet = 82,
+        NorthAmericaArchitectureDSheet = 83,
+        NorthAmericaArchitectureESheet = 84,
+        NorthAmericaCSheet = 85,
+        NorthAmericaDSheet = 86,
+        NorthAmericaESheet = 87,
+        NorthAmericaExecutive = 88,
+        NorthAmericaGermanLegalFanfold = 89,
+        NorthAmericaGermanStandardFanfold = 90,
+        NorthAmericaLegal = 91,
+        NorthAmericaLegalExtra = 92,
+        NorthAmericaLetter = 93,
+        NorthAmericaLetterExtra = 95,
+        NorthAmericaLetterPlus = 96,
+        NorthAmericaLetterRotated = 94,
+        NorthAmericaMonarchEnvelope = 97,
+        NorthAmericaNote = 98,
+        NorthAmericaNumber10Envelope = 99,
+        NorthAmericaNumber10EnvelopeRotated = 100,
+        NorthAmericaNumber11Envelope = 102,
+        NorthAmericaNumber12Envelope = 103,
+        NorthAmericaNumber14Envelope = 104,
+        NorthAmericaNumber9Envelope = 101,
+        NorthAmericaPersonalEnvelope = 105,
+        NorthAmericaQuarto = 106,
+        NorthAmericaStatement = 107,
+        NorthAmericaSuperA = 108,
+        NorthAmericaSuperB = 109,
+        NorthAmericaTabloid = 110,
+        NorthAmericaTabloidExtra = 111,
+        OtherMetricA3Plus = 113,
+        OtherMetricA4Plus = 112,
+        OtherMetricFolio = 114,
+        OtherMetricInviteEnvelope = 115,
+        OtherMetricItalianEnvelope = 116,
+        PRC10Envelope = 119,
+        PRC10EnvelopeRotated = 120,
+        PRC16K = 121,
+        PRC16KRotated = 122,
+        PRC1Envelope = 117,
+        PRC1EnvelopeRotated = 118,
+        PRC2Envelope = 123,
+        PRC2EnvelopeRotated = 124,
+        PRC32K = 125,
+        PRC32KBig = 127,
+        PRC32KRotated = 126,
+        PRC3Envelope = 128,
+        PRC3EnvelopeRotated = 129,
+        PRC4Envelope = 130,
+        PRC4EnvelopeRotated = 131,
+        PRC5Envelope = 132,
+        PRC5EnvelopeRotated = 133,
+        PRC6Envelope = 134,
+        PRC6EnvelopeRotated = 135,
+        PRC7Envelope = 136,
+        PRC7EnvelopeRotated = 137,
+        PRC8Envelope = 138,
+        PRC8EnvelopeRotated = 139,
+        PRC9Envelope = 140,
+        PRC9EnvelopeRotated = 141,
+        Roll04Inch = 142,
+        Roll06Inch = 143,
+        Roll08Inch = 144,
+        Roll12Inch = 145,
+        Roll15Inch = 146,
+        Roll18Inch = 147,
+        Roll22Inch = 148,
+        Roll24Inch = 149,
+        Roll30Inch = 150,
+        Roll36Inch = 151,
+        Roll54Inch = 152,
+        Unknown = 0,
+    }
+    public enum PageMediaType {
+        Archival = 2,
+        AutoSelect = 1,
+        BackPrintFilm = 3,
+        Bond = 4,
+        CardStock = 5,
+        Continuous = 6,
+        EnvelopePlain = 7,
+        EnvelopeWindow = 8,
+        Fabric = 9,
+        HighResolution = 10,
+        Label = 11,
+        MultiLayerForm = 12,
+        MultiPartForm = 13,
+        None = 29,
+        Photographic = 14,
+        PhotographicFilm = 15,
+        PhotographicGlossy = 16,
+        PhotographicHighGloss = 17,
+        PhotographicMatte = 18,
+        PhotographicSatin = 19,
+        PhotographicSemiGloss = 20,
+        Plain = 21,
+        Screen = 22,
+        ScreenPaged = 23,
+        Stationery = 24,
+        TabStockFull = 25,
+        TabStockPreCut = 26,
+        Transparency = 27,
+        TShirtTransfer = 28,
+        Unknown = 0,
+    }
+    public enum PageOrder {
+        Reverse = 2,
+        Standard = 1,
+        Unknown = 0,
+    }
+    public enum PageOrientation {
+        Landscape = 1,
+        Portrait = 2,
+        ReverseLandscape = 3,
+        ReversePortrait = 4,
+        Unknown = 0,
+    }
+    public enum PageQualitativeResolution {
+        Default = 1,
+        Draft = 2,
+        High = 3,
+        Normal = 4,
+        Other = 5,
+        Unknown = 0,
+    }
+    public sealed class PageResolution {
+        public PageResolution(int resolutionX, int resolutionY);
+        public PageResolution(int resolutionX, int resolutionY, PageQualitativeResolution qualitative);
+        public PageResolution(PageQualitativeResolution qualitative);
+        public Nullable<PageQualitativeResolution> QualitativeResolution { get; }
+        public Nullable<int> X { get; }
+        public Nullable<int> Y { get; }
+        public override string ToString();
+    }
+    public sealed class PageScalingFactorRange {
+        public int MaximumScale { get; }
+        public int MinimumScale { get; }
+        public override string ToString();
+    }
+    public enum PagesPerSheetDirection {
+        BottomLeft = 4,
+        BottomRight = 2,
+        LeftBottom = 3,
+        LeftTop = 7,
+        RightBottom = 1,
+        RightTop = 5,
+        TopLeft = 8,
+        TopRight = 6,
+        Unknown = 0,
+    }
+    public enum PhotoPrintingIntent {
+        None = 1,
+        PhotoBest = 2,
+        PhotoDraft = 3,
+        PhotoStandard = 4,
+        Unknown = 0,
+    }
+    public sealed class PrintCapabilities {
+        public PrintCapabilities(Stream xmlStream);
+        public ReadOnlyCollection<Collation> CollationCapability { get; }
+        public ReadOnlyCollection<DeviceFontSubstitution> DeviceFontSubstitutionCapability { get; }
+        public ReadOnlyCollection<Duplexing> DuplexingCapability { get; }
+        public ReadOnlyCollection<InputBin> InputBinCapability { get; }
+        public Nullable<int> MaxCopyCount { get; }
+        public Nullable<double> OrientedPageMediaHeight { get; }
+        public Nullable<double> OrientedPageMediaWidth { get; }
+        public ReadOnlyCollection<OutputColor> OutputColorCapability { get; }
+        public ReadOnlyCollection<OutputQuality> OutputQualityCapability { get; }
+        public ReadOnlyCollection<PageBorderless> PageBorderlessCapability { get; }
+        public PageImageableArea PageImageableArea { get; }
+        public ReadOnlyCollection<PageMediaSize> PageMediaSizeCapability { get; }
+        public ReadOnlyCollection<PageMediaType> PageMediaTypeCapability { get; }
+        public ReadOnlyCollection<PageOrder> PageOrderCapability { get; }
+        public ReadOnlyCollection<PageOrientation> PageOrientationCapability { get; }
+        public ReadOnlyCollection<PageResolution> PageResolutionCapability { get; }
+        public PageScalingFactorRange PageScalingFactorRange { get; }
+        public ReadOnlyCollection<int> PagesPerSheetCapability { get; }
+        public ReadOnlyCollection<PagesPerSheetDirection> PagesPerSheetDirectionCapability { get; }
+        public ReadOnlyCollection<PhotoPrintingIntent> PhotoPrintingIntentCapability { get; }
+        public ReadOnlyCollection<Stapling> StaplingCapability { get; }
+        public ReadOnlyCollection<TrueTypeFontMode> TrueTypeFontModeCapability { get; }
+    }
+    public class PrintCommitAttributesException : PrintSystemException {
+        public PrintCommitAttributesException();
+        public PrintCommitAttributesException(int errorCode, Collection<string> attributesSuccessList, Collection<string> attributesFailList);
+        public PrintCommitAttributesException(int errorCode, string message, Collection<string> attributesSuccessList, Collection<string> attributesFailList, string objectName);
+        protected PrintCommitAttributesException(SerializationInfo info, StreamingContext context);
+        public PrintCommitAttributesException(string message);
+        public PrintCommitAttributesException(string message, Exception innerException);
+        public Collection<string> CommittedAttributesCollection { get; }
+        public Collection<string> FailedAttributesCollection { get; }
+        public string PrintObjectName { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class PrintDocumentImageableArea {
+        public double ExtentHeight { get; internal set; }
+        public double ExtentWidth { get; internal set; }
+        public double MediaSizeHeight { get; internal set; }
+        public double MediaSizeWidth { get; internal set; }
+        public double OriginHeight { get; internal set; }
+        public double OriginWidth { get; internal set; }
+    }
+    public sealed class PrintDriver : PrintFilter {
+        public sealed override void Commit();
+        protected sealed override void InternalDispose(bool disposing);
+        public sealed override void Refresh();
+    }
+    public abstract class PrintFilter : PrintSystemObject {
+        protected override void InternalDispose(bool disposing);
+    }
+    public class PrintingCanceledException : PrintJobException {
+        public PrintingCanceledException();
+        public PrintingCanceledException(int errorCode, string message);
+        public PrintingCanceledException(int errorCode, string message, Exception innerException);
+        public PrintingCanceledException(int errorCode, string message, string printQueueName, string jobName, int jobId);
+        public PrintingCanceledException(int errorCode, string message, string printQueueName, string jobName, int jobId, Exception innerException);
+        protected PrintingCanceledException(SerializationInfo info, StreamingContext context);
+        public PrintingCanceledException(string message);
+        public PrintingCanceledException(string message, Exception innerException);
+    }
+    public class PrintingNotSupportedException : PrintSystemException {
+        public PrintingNotSupportedException();
+        protected PrintingNotSupportedException(SerializationInfo info, StreamingContext context);
+        public PrintingNotSupportedException(string message);
+        public PrintingNotSupportedException(string message, Exception innerException);
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class PrintJobException : PrintSystemException {
+        public PrintJobException();
+        public PrintJobException(int errorCode, string message);
+        public PrintJobException(int errorCode, string message, Exception innerException);
+        public PrintJobException(int errorCode, string message, string printQueueName, string jobName, int jobId);
+        public PrintJobException(int errorCode, string message, string printQueueName, string jobName, int jobId, Exception innerException);
+        protected PrintJobException(SerializationInfo info, StreamingContext context);
+        public PrintJobException(string message);
+        public PrintJobException(string message, Exception innerException);
+        public int JobId { get; }
+        public string JobName { get; }
+        public string PrintQueueName { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class PrintJobInfoCollection : PrintSystemObjects, IDisposable, IEnumerable, IEnumerable<PrintSystemJobInfo> {
+        public PrintJobInfoCollection(PrintQueue printQueue, string[] propertyFilter);
+        public void Add(PrintSystemJobInfo printObject);
+        protected override void Dispose(bool A_0);
+        public virtual IEnumerator<PrintSystemJobInfo> GetEnumerator();
+        virtual IEnumerator GetNonGenericEnumerator();
+    }
+    public enum PrintJobPriority {
+        Default = 1,
+        Maximum = 99,
+        Minimum = 1,
+        None = 0,
+    }
+    public class PrintJobSettings {
+        public PrintTicket CurrentPrintTicket { get; set; }
+        public string Description { get; set; }
+    }
+    public enum PrintJobStatus {
+        Blocked = 512,
+        Completed = 4096,
+        Deleted = 256,
+        Deleting = 4,
+        Error = 2,
+        None = 0,
+        Offline = 32,
+        PaperOut = 64,
+        Paused = 1,
+        Printed = 128,
+        Printing = 16,
+        Restarted = 2048,
+        Retained = 8192,
+        Spooling = 8,
+        UserIntervention = 1024,
+    }
+    public enum PrintJobType {
+        Legacy = 2,
+        None = 0,
+        Xps = 1,
+    }
+    public sealed class PrintPort : PrintSystemObject {
+        public sealed override void Commit();
+        protected sealed override void InternalDispose(bool disposing);
+        public sealed override void Refresh();
+    }
+    public sealed class PrintProcessor : PrintFilter {
+        public sealed override void Commit();
+        protected sealed override void InternalDispose(bool disposing);
+        public sealed override void Refresh();
+    }
+    public class PrintQueue : PrintSystemObject {
+        public PrintQueue(PrintServer printServer, string printQueueName);
+        public PrintQueue(PrintServer printServer, string printQueueName, int printSchemaVersion);
+        public PrintQueue(PrintServer printServer, string printQueueName, int printSchemaVersion, PrintSystemDesiredAccess desiredAccess);
+        public PrintQueue(PrintServer printServer, string printQueueName, PrintQueueIndexedProperty[] propertyFilter);
+        public PrintQueue(PrintServer printServer, string printQueueName, PrintQueueIndexedProperty[] propertyFilter, PrintSystemDesiredAccess desiredAccess);
+        public PrintQueue(PrintServer printServer, string printQueueName, PrintSystemDesiredAccess desiredAccess);
+        public PrintQueue(PrintServer printServer, string printQueueName, string[] propertyFilter);
+        public PrintQueue(PrintServer printServer, string printQueueName, string[] propertyFilter, PrintSystemDesiredAccess desiredAccess);
+        public virtual int AveragePagesPerMinute { get; }
+        public int ClientPrintSchemaVersion { get; }
+        public virtual string Comment { get; set; }
+        public PrintJobSettings CurrentJobSettings { get; }
+        public virtual PrintTicket DefaultPrintTicket { get; set; }
+        public virtual int DefaultPriority { get; set; }
+        public virtual string Description { get; internal set; }
+        public string FullName { get; }
+        public bool HasPaperProblem { get; }
+        public bool HasToner { get; }
+        public virtual PrintServer HostingPrintServer { get; protected set; }
+        public bool InPartialTrust { get; set; }
+        public bool IsBidiEnabled { get; }
+        public bool IsBusy { get; }
+        public bool IsDevQueryEnabled { get; }
+        public bool IsDirect { get; }
+        public bool IsDoorOpened { get; }
+        public bool IsHidden { get; }
+        public bool IsInError { get; }
+        public bool IsInitializing { get; }
+        public bool IsIOActive { get; }
+        public bool IsManualFeedRequired { get; }
+        public bool IsNotAvailable { get; }
+        public bool IsOffline { get; }
+        public bool IsOutOfMemory { get; }
+        public bool IsOutOfPaper { get; }
+        public bool IsOutputBinFull { get; }
+        public bool IsPaperJammed { get; }
+        public bool IsPaused { get; }
+        public bool IsPendingDeletion { get; }
+        public bool IsPowerSaveOn { get; }
+        public bool IsPrinting { get; }
+        public bool IsProcessing { get; }
+        public bool IsPublished { get; }
+        public bool IsQueued { get; }
+        public bool IsRawOnlyEnabled { get; }
+        public bool IsServerUnknown { get; }
+        public bool IsShared { get; }
+        public bool IsTonerLow { get; }
+        public bool IsWaiting { get; }
+        public bool IsWarmingUp { get; }
+        public bool IsXpsDevice { get; internal set; }
+        public bool KeepPrintedJobs { get; }
+        public virtual string Location { get; set; }
+        public static int MaxPrintSchemaVersion { get; }
+        public sealed override string Name { get; set; }
+        public bool NeedUserIntervention { get; }
+        public virtual int NumberOfJobs { get; internal set; }
+        public bool PagePunt { get; }
+        public bool PrintingIsCancelled { get; set; }
+        public virtual int Priority { get; set; }
+        public PrintQueueAttributes QueueAttributes { get; }
+        public virtual PrintDriver QueueDriver { get; set; }
+        public virtual PrintPort QueuePort { get; set; }
+        public virtual PrintProcessor QueuePrintProcessor { get; set; }
+        public PrintQueueStatus QueueStatus { get; }
+        public bool ScheduleCompletedJobsFirst { get; }
+        public virtual string SeparatorFile { get; set; }
+        public virtual string ShareName { get; set; }
+        public virtual int StartTimeOfDay { get; set; }
+        public virtual int UntilTimeOfDay { get; set; }
+        public virtual PrintTicket UserPrintTicket { get; set; }
+        public PrintSystemJobInfo AddJob();
+        public PrintSystemJobInfo AddJob(string jobName);
+        public PrintSystemJobInfo AddJob(string jobName, PrintTicket printTicket);
+        public PrintSystemJobInfo AddJob(string jobName, string documentPath, bool fastCopy);
+        public PrintSystemJobInfo AddJob(string jobName, string documentPath, bool fastCopy, PrintTicket printTicket);
+        public override void Commit();
+        public static XpsDocumentWriter CreateXpsDocumentWriter(ref double width, ref double height);
+        public static XpsDocumentWriter CreateXpsDocumentWriter(ref PrintDocumentImageableArea documentImageableArea);
+        public static XpsDocumentWriter CreateXpsDocumentWriter(ref PrintDocumentImageableArea documentImageableArea, ref PageRangeSelection pageRangeSelection, ref PageRange pageRange);
+        public static XpsDocumentWriter CreateXpsDocumentWriter(PrintQueue printQueue);
+        public static XpsDocumentWriter CreateXpsDocumentWriter(string jobDescription, ref PrintDocumentImageableArea documentImageableArea);
+        public static XpsDocumentWriter CreateXpsDocumentWriter(string jobDescription, ref PrintDocumentImageableArea documentImageableArea, ref PageRangeSelection pageRangeSelection, ref PageRange pageRange);
+        public PrintSystemJobInfo GetJob(int jobId);
+        public PrintCapabilities GetPrintCapabilities();
+        public PrintCapabilities GetPrintCapabilities(PrintTicket printTicket);
+        public MemoryStream GetPrintCapabilitiesAsXml();
+        public MemoryStream GetPrintCapabilitiesAsXml(PrintTicket printTicket);
+        public PrintJobInfoCollection GetPrintJobInfoCollection();
+        protected sealed override void InternalDispose(bool disposing);
+        public ValidationResult MergeAndValidatePrintTicket(PrintTicket basePrintTicket, PrintTicket deltaPrintTicket);
+        public ValidationResult MergeAndValidatePrintTicket(PrintTicket basePrintTicket, PrintTicket deltaPrintTicket, PrintTicketScope scope);
+        public virtual void Pause();
+        public virtual void Purge();
+        public override void Refresh();
+        public virtual void Resume();
+    }
+    public enum PrintQueueAttributes {
+        Direct = 2,
+        EnableBidi = 2048,
+        EnableDevQuery = 128,
+        Hidden = 32,
+        KeepPrintedJobs = 256,
+        None = 0,
+        Published = 8192,
+        Queued = 1,
+        RawOnly = 4096,
+        ScheduleCompletedJobsFirst = 512,
+        Shared = 8,
+    }
+    public class PrintQueueCollection : PrintSystemObjects, IDisposable, IEnumerable, IEnumerable<PrintQueue> {
+        public PrintQueueCollection();
+        public PrintQueueCollection(PrintServer printServer, string[] propertyFilter);
+        public PrintQueueCollection(PrintServer printServer, string[] propertyFilter, EnumeratedPrintQueueTypes[] enumerationFlag);
+        public static object SyncRoot { get; }
+        public void Add(PrintQueue printObject);
+        protected override void Dispose(bool A_0);
+        public virtual IEnumerator<PrintQueue> GetEnumerator();
+        virtual IEnumerator GetNonGenericEnumerator();
+    }
+    public class PrintQueueException : PrintSystemException {
+        public PrintQueueException();
+        public PrintQueueException(int errorCode, string message, string printerName);
+        public PrintQueueException(int errorCode, string message, string printerName, Exception innerException);
+        public PrintQueueException(int errorCode, string message, string printerName, string printerMessage);
+        protected PrintQueueException(SerializationInfo info, StreamingContext context);
+        public PrintQueueException(string message);
+        public PrintQueueException(string message, Exception innerException);
+        public string PrinterName { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public enum PrintQueueIndexedProperty {
+        AveragePagesPerMinute = 9,
+        Comment = 2,
+        DefaultPrintTicket = 19,
+        DefaultPriority = 6,
+        Description = 4,
+        HostingPrintServer = 15,
+        Location = 3,
+        Name = 0,
+        NumberOfJobs = 10,
+        Priority = 5,
+        QueueAttributes = 11,
+        QueueDriver = 12,
+        QueuePort = 13,
+        QueuePrintProcessor = 14,
+        QueueStatus = 16,
+        SeparatorFile = 17,
+        ShareName = 1,
+        StartTimeOfDay = 7,
+        UntilTimeOfDay = 8,
+        UserPrintTicket = 18,
+    }
+    public enum PrintQueueStatus {
+        Busy = 512,
+        DoorOpen = 4194304,
+        Error = 2,
+        Initializing = 32768,
+        IOActive = 256,
+        ManualFeed = 32,
+        None = 0,
+        NotAvailable = 4096,
+        NoToner = 262144,
+        Offline = 128,
+        OutOfMemory = 2097152,
+        OutputBinFull = 2048,
+        PagePunt = 524288,
+        PaperJam = 8,
+        PaperOut = 16,
+        PaperProblem = 64,
+        Paused = 1,
+        PendingDeletion = 4,
+        PowerSave = 16777216,
+        Printing = 1024,
+        Processing = 16384,
+        ServerUnknown = 8388608,
+        TonerLow = 131072,
+        UserIntervention = 1048576,
+        Waiting = 8192,
+        WarmingUp = 65536,
+    }
+    public class PrintQueueStream : Stream {
+        public PrintQueueStream(PrintQueue printQueue, string printJobName);
+        public PrintQueueStream(PrintQueue printQueue, string printJobName, bool commitDataOnClose);
+        public PrintQueueStream(PrintQueue printQueue, string printJobName, bool commitDataOnClose, PrintTicket printTicket);
+        public override bool CanRead { get; }
+        public override bool CanSeek { get; }
+        public override bool CanWrite { get; }
+        public int JobIdentifier { get; }
+        public override long Length { get; }
+        public override long Position { get; set; }
+        public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state);
+        public override void Close();
+        protected override void Dispose(bool A_0);
+        public override void EndWrite(IAsyncResult asyncResult);
+        ~PrintQueueStream();
+        public override void Flush();
+        public void HandlePackagingProgressEvent(object sender, PackagingProgressEventArgs e);
+        public override int Read(byte[] buffer, int offset, int count);
+        public override long Seek(long offset, SeekOrigin origin);
+        public override void SetLength(long value);
+        public override void Write(byte[] buffer, int offset, int count);
+    }
+    public class PrintQueueStringProperty {
+        public PrintQueueStringProperty();
+        public string Name { get; set; }
+        public PrintQueueStringPropertyType Type { get; set; }
+    }
+    public enum PrintQueueStringPropertyType {
+        Comment = 1,
+        Location = 0,
+        ShareName = 2,
+    }
+    public class PrintServer : PrintSystemObject {
+        public PrintServer();
+        public PrintServer(PrintSystemDesiredAccess desiredAccess);
+        public PrintServer(string path);
+        public PrintServer(string path, PrintServerIndexedProperty[] propertiesFilter);
+        public PrintServer(string path, PrintServerIndexedProperty[] propertiesFilter, PrintSystemDesiredAccess desiredAccess);
+        public PrintServer(string path, PrintSystemDesiredAccess desiredAccess);
+        public PrintServer(string path, string[] propertiesFilter);
+        public PrintServer(string path, string[] propertiesFilter, PrintSystemDesiredAccess desiredAccess);
+        public bool BeepEnabled { get; set; }
+        public ThreadPriority DefaultPortThreadPriority { get; internal set; }
+        public ThreadPriority DefaultSchedulerPriority { get; internal set; }
+        public string DefaultSpoolDirectory { get; set; }
+        public PrintServerEventLoggingTypes EventLog { get; set; }
+        protected bool IsDelayInitialized { get; set; }
+        public int MajorVersion { get; internal set; }
+        public int MinorVersion { get; internal set; }
+        public sealed override string Name { get; internal set; }
+        public bool NetPopup { get; set; }
+        public ThreadPriority PortThreadPriority { get; set; }
+        public bool RestartJobOnPoolEnabled { get; set; }
+        public int RestartJobOnPoolTimeout { get; set; }
+        public ThreadPriority SchedulerPriority { get; set; }
+        public byte SubSystemVersion { get; }
+        public override void Commit();
+        public static bool DeletePrintQueue(PrintQueue printQueue);
+        public static bool DeletePrintQueue(string printQueueName);
+        public PrintQueue GetPrintQueue(string printQueueName);
+        public PrintQueue GetPrintQueue(string printQueueName, string[] propertiesFilter);
+        public PrintQueueCollection GetPrintQueues();
+        public PrintQueueCollection GetPrintQueues(EnumeratedPrintQueueTypes[] enumerationFlag);
+        public PrintQueueCollection GetPrintQueues(PrintQueueIndexedProperty[] propertiesFilter);
+        public PrintQueueCollection GetPrintQueues(PrintQueueIndexedProperty[] propertiesFilter, EnumeratedPrintQueueTypes[] enumerationFlag);
+        public PrintQueueCollection GetPrintQueues(string[] propertiesFilter);
+        public PrintQueueCollection GetPrintQueues(string[] propertiesFilter, EnumeratedPrintQueueTypes[] enumerationFlag);
+        public PrintQueue InstallPrintQueue(string printQueueName, string driverName, string[] portNames, string printProcessorName, PrintPropertyDictionary initialParameters);
+        public PrintQueue InstallPrintQueue(string printQueueName, string driverName, string[] portNames, string printProcessorName, PrintQueueAttributes printQueueAttributes);
+        public PrintQueue InstallPrintQueue(string printQueueName, string driverName, string[] portNames, string printProcessorName, PrintQueueAttributes printQueueAttributes, PrintQueueStringProperty printQueueProperty, int printQueuePriority, int printQueueDefaultPriority);
+        public PrintQueue InstallPrintQueue(string printQueueName, string driverName, string[] portNames, string printProcessorName, PrintQueueAttributes printQueueAttributes, string printQueueShareName, string printQueueComment, string printQueueLocation, string printQueueSeparatorFile, int printQueuePriority, int printQueueDefaultPriority);
+        protected sealed override void InternalDispose(bool disposing);
+        public override void Refresh();
+    }
+    public enum PrintServerEventLoggingTypes {
+        LogAllPrintingEvents = 5,
+        LogPrintingErrorEvents = 2,
+        LogPrintingInformationEvents = 4,
+        LogPrintingSuccessEvents = 1,
+        LogPrintingWarningEvents = 3,
+        None = 0,
+    }
+    public class PrintServerException : PrintSystemException {
+        public PrintServerException();
+        public PrintServerException(int errorCode, string message, string serverName);
+        public PrintServerException(int errorCode, string message, string serverName, Exception innerException);
+        protected PrintServerException(SerializationInfo info, StreamingContext context);
+        public PrintServerException(string message);
+        public PrintServerException(string message, Exception innerException);
+        public string ServerName { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public enum PrintServerIndexedProperty {
+        BeepEnabled = 5,
+        DefaultPortThreadPriority = 2,
+        DefaultSchedulerPriority = 4,
+        DefaultSpoolDirectory = 0,
+        EventLog = 7,
+        MajorVersion = 8,
+        MinorVersion = 9,
+        NetPopup = 6,
+        PortThreadPriority = 1,
+        RestartJobOnPoolEnabled = 11,
+        RestartJobOnPoolTimeout = 10,
+        SchedulerPriority = 3,
+    }
+    public enum PrintSystemDesiredAccess {
+        AdministratePrinter = 983052,
+        AdministrateServer = 983041,
+        EnumerateServer = 131074,
+        None = 0,
+        UsePrinter = 131080,
+    }
+    public class PrintSystemException : SystemException {
+        public PrintSystemException();
+        public PrintSystemException(int errorCode, string message);
+        public PrintSystemException(int errorCode, string message, Exception innerException);
+        public PrintSystemException(int errorCode, string message, string printerMessage);
+        protected PrintSystemException(SerializationInfo info, StreamingContext context);
+        public PrintSystemException(string message);
+        public PrintSystemException(string message, Exception innerException);
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class PrintSystemJobInfo : PrintSystemObject {
+        public PrintQueue HostingPrintQueue { get; internal set; }
+        public PrintServer HostingPrintServer { get; internal set; }
+        public bool IsBlocked { get; }
+        public bool IsCompleted { get; }
+        public bool IsDeleted { get; }
+        public bool IsDeleting { get; }
+        public bool IsInError { get; }
+        public bool IsOffline { get; }
+        public bool IsPaperOut { get; }
+        public bool IsPaused { get; }
+        public bool IsPrinted { get; }
+        public bool IsPrinting { get; }
+        public bool IsRestarted { get; }
+        public bool IsRetained { get; }
+        public bool IsSpooling { get; }
+        public bool IsUserInterventionRequired { get; }
+        public int JobIdentifier { get; internal set; }
+        public string JobName { get; set; }
+        public int JobSize { get; internal set; }
+        public PrintJobStatus JobStatus { get; internal set; }
+        public Stream JobStream { get; }
+        public int NumberOfPages { get; internal set; }
+        public int NumberOfPagesPrinted { get; internal set; }
+        public int PositionInPrintQueue { get; internal set; }
+        public PrintJobPriority Priority { get; internal set; }
+        public int StartTimeOfDay { get; internal set; }
+        public string Submitter { get; internal set; }
+        public DateTime TimeJobSubmitted { get; internal set; }
+        public int TimeSinceStartedPrinting { get; }
+        public int UntilTimeOfDay { get; internal set; }
+        public void Cancel();
+        public override void Commit();
+        public static PrintSystemJobInfo Get(PrintQueue printQueue, int jobIdentifier);
+        protected sealed override void InternalDispose(bool disposing);
+        public void Pause();
+        public override void Refresh();
+        public void Restart();
+        public void Resume();
+    }
+    public abstract class PrintSystemObject : IDisposable {
+        protected PrintSystemObject();
+        protected PrintSystemObject(PrintSystemObjectLoadMode mode);
+        protected bool IsDisposed { get; set; }
+        public virtual string Name { get; internal set; }
+        public virtual PrintSystemObject Parent { get; }
+        public PrintPropertyDictionary PropertiesCollection { get; internal set; }
+        protected static string[] BaseAttributeNames();
+        public abstract void Commit();
+        public sealed override void Dispose();
+        protected virtual void Dispose(bool A_0);
+        ~PrintSystemObject();
+        protected void Initialize();
+        protected virtual void InternalDispose(bool disposing);
+        public abstract void Refresh();
+    }
+    public enum PrintSystemObjectLoadMode {
+        LoadInitialized = 2,
+        LoadUninitialized = 1,
+        None = 0,
+    }
+    public class PrintSystemObjectPropertiesChangedEventArgs : EventArgs, IDisposable {
+        public PrintSystemObjectPropertiesChangedEventArgs(StringCollection events);
+        public StringCollection PropertiesNames { get; }
+        public sealed override void Dispose();
+        protected virtual void Dispose(bool A_0);
+    }
+    public class PrintSystemObjectPropertyChangedEventArgs : EventArgs, IDisposable {
+        public PrintSystemObjectPropertyChangedEventArgs(string eventName);
+        public string PropertyName { get; }
+        public sealed override void Dispose();
+        protected virtual void Dispose(bool A_0);
+    }
+    public abstract class PrintSystemObjects : IDisposable {
+        protected PrintSystemObjects();
+        public sealed override void Dispose();
+        protected virtual void Dispose(bool A_0);
+    }
+    public sealed class PrintTicket : INotifyPropertyChanged {
+        public PrintTicket();
+        public PrintTicket(Stream xmlStream);
+        public Nullable<Collation> Collation { get; set; }
+        public Nullable<int> CopyCount { get; set; }
+        public Nullable<DeviceFontSubstitution> DeviceFontSubstitution { get; set; }
+        public Nullable<Duplexing> Duplexing { get; set; }
+        public Nullable<InputBin> InputBin { get; set; }
+        public Nullable<OutputColor> OutputColor { get; set; }
+        public Nullable<OutputQuality> OutputQuality { get; set; }
+        public Nullable<PageBorderless> PageBorderless { get; set; }
+        public PageMediaSize PageMediaSize { get; set; }
+        public Nullable<PageMediaType> PageMediaType { get; set; }
+        public Nullable<PageOrder> PageOrder { get; set; }
+        public Nullable<PageOrientation> PageOrientation { get; set; }
+        public PageResolution PageResolution { get; set; }
+        public Nullable<int> PageScalingFactor { get; set; }
+        public Nullable<int> PagesPerSheet { get; set; }
+        public Nullable<PagesPerSheetDirection> PagesPerSheetDirection { get; set; }
+        public Nullable<PhotoPrintingIntent> PhotoPrintingIntent { get; set; }
+        public Nullable<Stapling> Stapling { get; set; }
+        public Nullable<TrueTypeFontMode> TrueTypeFontMode { get; set; }
+        public event PropertyChangedEventHandler PropertyChanged;
+        public PrintTicket Clone();
+        public MemoryStream GetXmlStream();
+        public void SaveTo(Stream outStream);
+    }
+    public enum PrintTicketScope {
+        DocumentScope = 1,
+        JobScope = 2,
+        PageScope = 0,
+    }
+    public enum Stapling {
+        None = 10,
+        SaddleStitch = 1,
+        StapleBottomLeft = 2,
+        StapleBottomRight = 3,
+        StapleDualBottom = 7,
+        StapleDualLeft = 4,
+        StapleDualRight = 5,
+        StapleDualTop = 6,
+        StapleTopLeft = 8,
+        StapleTopRight = 9,
+        Unknown = 0,
+    }
+    public enum TrueTypeFontMode {
+        Automatic = 1,
+        DownloadAsNativeTrueTypeFont = 4,
+        DownloadAsOutlineFont = 2,
+        DownloadAsRasterFont = 3,
+        RenderAsBitmap = 5,
+        Unknown = 0,
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct ValidationResult {
+        public ConflictStatus ConflictStatus { get; }
+        public PrintTicket ValidatedPrintTicket { get; }
+        public override bool Equals(object o);
+        public override int GetHashCode();
+        public static bool operator ==(ValidationResult a, ValidationResult b);
+        public static bool operator !=(ValidationResult a, ValidationResult b);
+    }
+}
```

