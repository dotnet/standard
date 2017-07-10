# System.Windows.Media.Imaging

``` diff
+namespace System.Windows.Media.Imaging {
+    public enum BitmapCacheOption {
+        Default = 0,
+        None = 2,
+        OnDemand = 0,
+        OnLoad = 1,
+    }
+    public abstract class BitmapCodecInfo {
+        protected BitmapCodecInfo();
+        public virtual string Author { get; }
+        public virtual Guid ContainerFormat { get; }
+        public virtual string DeviceManufacturer { get; }
+        public virtual string DeviceModels { get; }
+        public virtual string FileExtensions { get; }
+        public virtual string FriendlyName { get; }
+        public virtual string MimeTypes { get; }
+        public virtual Version SpecificationVersion { get; }
+        public virtual bool SupportsAnimation { get; }
+        public virtual bool SupportsLossless { get; }
+        public virtual bool SupportsMultipleFrames { get; }
+        public virtual Version Version { get; }
+    }
+    public enum BitmapCreateOptions {
+        DelayCreation = 2,
+        IgnoreColorProfile = 4,
+        IgnoreImageCache = 8,
+        None = 0,
+        PreservePixelFormat = 1,
+    }
+    public abstract class BitmapDecoder : DispatcherObject {
+        protected BitmapDecoder();
+        public virtual BitmapCodecInfo CodecInfo { get; }
+        public virtual ReadOnlyCollection<ColorContext> ColorContexts { get; }
+        public virtual ReadOnlyCollection<BitmapFrame> Frames { get; }
+        public virtual bool IsDownloading { get; }
+        public virtual BitmapMetadata Metadata { get; }
+        public virtual BitmapPalette Palette { get; }
+        public virtual BitmapSource Preview { get; }
+        public virtual BitmapSource Thumbnail { get; }
+        public virtual event EventHandler DownloadCompleted;
+        public virtual event EventHandler<ExceptionEventArgs> DownloadFailed;
+        public virtual event EventHandler<DownloadProgressEventArgs> DownloadProgress;
+        public static BitmapDecoder Create(Stream bitmapStream, BitmapCreateOptions createOptions, BitmapCacheOption cacheOption);
+        public static BitmapDecoder Create(Uri bitmapUri, BitmapCreateOptions createOptions, BitmapCacheOption cacheOption);
+        public static BitmapDecoder Create(Uri bitmapUri, BitmapCreateOptions createOptions, BitmapCacheOption cacheOption, RequestCachePolicy uriCachePolicy);
+        public virtual InPlaceBitmapMetadataWriter CreateInPlaceBitmapMetadataWriter();
+        ~BitmapDecoder();
+        public override string ToString();
+    }
+    public abstract class BitmapEncoder : DispatcherObject {
+        protected BitmapEncoder();
+        public virtual BitmapCodecInfo CodecInfo { get; }
+        public virtual ReadOnlyCollection<ColorContext> ColorContexts { get; set; }
+        public virtual IList<BitmapFrame> Frames { get; set; }
+        public virtual BitmapMetadata Metadata { get; set; }
+        public virtual BitmapPalette Palette { get; set; }
+        public virtual BitmapSource Preview { get; set; }
+        public virtual BitmapSource Thumbnail { get; set; }
+        public static BitmapEncoder Create(Guid containerFormat);
+        public virtual void Save(Stream stream);
+    }
+    public abstract class BitmapFrame : BitmapSource, IUriContext {
+        protected BitmapFrame();
+        public abstract Uri BaseUri { get; set; }
+        public abstract ReadOnlyCollection<ColorContext> ColorContexts { get; }
+        public abstract BitmapDecoder Decoder { get; }
+        public abstract BitmapSource Thumbnail { get; }
+        public static BitmapFrame Create(Stream bitmapStream);
+        public static BitmapFrame Create(Stream bitmapStream, BitmapCreateOptions createOptions, BitmapCacheOption cacheOption);
+        public static BitmapFrame Create(Uri bitmapUri);
+        public static BitmapFrame Create(Uri bitmapUri, RequestCachePolicy uriCachePolicy);
+        public static BitmapFrame Create(Uri bitmapUri, BitmapCreateOptions createOptions, BitmapCacheOption cacheOption);
+        public static BitmapFrame Create(Uri bitmapUri, BitmapCreateOptions createOptions, BitmapCacheOption cacheOption, RequestCachePolicy uriCachePolicy);
+        public static BitmapFrame Create(BitmapSource source);
+        public static BitmapFrame Create(BitmapSource source, BitmapSource thumbnail);
+        public static BitmapFrame Create(BitmapSource source, BitmapSource thumbnail, BitmapMetadata metadata, ReadOnlyCollection<ColorContext> colorContexts);
+        public abstract InPlaceBitmapMetadataWriter CreateInPlaceBitmapMetadataWriter();
+    }
+    public sealed class BitmapImage : BitmapSource, ISupportInitialize, IUriContext {
+        public static readonly DependencyProperty CacheOptionProperty;
+        public static readonly DependencyProperty CreateOptionsProperty;
+        public static readonly DependencyProperty DecodePixelHeightProperty;
+        public static readonly DependencyProperty DecodePixelWidthProperty;
+        public static readonly DependencyProperty RotationProperty;
+        public static readonly DependencyProperty SourceRectProperty;
+        public static readonly DependencyProperty StreamSourceProperty;
+        public static readonly DependencyProperty UriCachePolicyProperty;
+        public static readonly DependencyProperty UriSourceProperty;
+        public BitmapImage();
+        public BitmapImage(Uri uriSource);
+        public BitmapImage(Uri uriSource, RequestCachePolicy uriCachePolicy);
+        public Uri BaseUri { get; set; }
+        public BitmapCacheOption CacheOption { get; set; }
+        public BitmapCreateOptions CreateOptions { get; set; }
+        public int DecodePixelHeight { get; set; }
+        public int DecodePixelWidth { get; set; }
+        public override bool IsDownloading { get; }
+        public override ImageMetadata Metadata { get; }
+        public Rotation Rotation { get; set; }
+        public Int32Rect SourceRect { get; set; }
+        public Stream StreamSource { get; set; }
+        public RequestCachePolicy UriCachePolicy { get; set; }
+        public Uri UriSource { get; set; }
+        public void BeginInit();
+        public new BitmapImage Clone();
+        protected override void CloneCore(Freezable source);
+        public new BitmapImage CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable source);
+        protected override Freezable CreateInstanceCore();
+        public void EndInit();
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+    }
+    public class BitmapMetadata : ImageMetadata, IEnumerable, IEnumerable<string> {
+        public BitmapMetadata(string containerFormat);
+        public string ApplicationName { get; set; }
+        public ReadOnlyCollection<string> Author { get; set; }
+        public string CameraManufacturer { get; set; }
+        public string CameraModel { get; set; }
+        public string Comment { get; set; }
+        public string Copyright { get; set; }
+        public string DateTaken { get; set; }
+        public string Format { get; }
+        public bool IsFixedSize { get; }
+        public bool IsReadOnly { get; }
+        public ReadOnlyCollection<string> Keywords { get; set; }
+        public string Location { get; }
+        public int Rating { get; set; }
+        public string Subject { get; set; }
+        public string Title { get; set; }
+        public new BitmapMetadata Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        public bool ContainsQuery(string query);
+        protected override Freezable CreateInstanceCore();
+        protected override void GetAsFrozenCore(Freezable sourceFreezable);
+        protected override void GetCurrentValueAsFrozenCore(Freezable sourceFreezable);
+        public object GetQuery(string query);
+        public void RemoveQuery(string query);
+        public void SetQuery(string query, object value);
+        IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+    }
+    public class BitmapMetadataBlob {
+        public BitmapMetadataBlob(byte[] blob);
+        public byte[] GetBlobValue();
+    }
+    public sealed class BitmapPalette : DispatcherObject {
+        public BitmapPalette(IList<Color> colors);
+        public BitmapPalette(BitmapSource bitmapSource, int maxColorCount);
+        public IList<Color> Colors { get; }
+    }
+    public static class BitmapPalettes {
+        public static BitmapPalette BlackAndWhite { get; }
+        public static BitmapPalette BlackAndWhiteTransparent { get; }
+        public static BitmapPalette Gray16 { get; }
+        public static BitmapPalette Gray16Transparent { get; }
+        public static BitmapPalette Gray256 { get; }
+        public static BitmapPalette Gray256Transparent { get; }
+        public static BitmapPalette Gray4 { get; }
+        public static BitmapPalette Gray4Transparent { get; }
+        public static BitmapPalette Halftone125 { get; }
+        public static BitmapPalette Halftone125Transparent { get; }
+        public static BitmapPalette Halftone216 { get; }
+        public static BitmapPalette Halftone216Transparent { get; }
+        public static BitmapPalette Halftone252 { get; }
+        public static BitmapPalette Halftone252Transparent { get; }
+        public static BitmapPalette Halftone256 { get; }
+        public static BitmapPalette Halftone256Transparent { get; }
+        public static BitmapPalette Halftone27 { get; }
+        public static BitmapPalette Halftone27Transparent { get; }
+        public static BitmapPalette Halftone64 { get; }
+        public static BitmapPalette Halftone64Transparent { get; }
+        public static BitmapPalette Halftone8 { get; }
+        public static BitmapPalette Halftone8Transparent { get; }
+        public static BitmapPalette WebPalette { get; }
+        public static BitmapPalette WebPaletteTransparent { get; }
+    }
+    public class BitmapSizeOptions {
+        public int PixelHeight { get; }
+        public int PixelWidth { get; }
+        public bool PreservesAspectRatio { get; }
+        public Rotation Rotation { get; }
+        public static BitmapSizeOptions FromEmptyOptions();
+        public static BitmapSizeOptions FromHeight(int pixelHeight);
+        public static BitmapSizeOptions FromRotation(Rotation rotation);
+        public static BitmapSizeOptions FromWidth(int pixelWidth);
+        public static BitmapSizeOptions FromWidthAndHeight(int pixelWidth, int pixelHeight);
+    }
+    public abstract class BitmapSource : ImageSource, DUCE.IResource {
+        protected BitmapSource();
+        public virtual double DpiX { get; }
+        public virtual double DpiY { get; }
+        public virtual PixelFormat Format { get; }
+        public override double Height { get; }
+        public virtual bool IsDownloading { get; }
+        public override ImageMetadata Metadata { get; }
+        public virtual BitmapPalette Palette { get; }
+        public virtual int PixelHeight { get; }
+        public virtual int PixelWidth { get; }
+        public override double Width { get; }
+        public virtual event EventHandler<ExceptionEventArgs> DecodeFailed;
+        public virtual event EventHandler DownloadCompleted;
+        public virtual event EventHandler<ExceptionEventArgs> DownloadFailed;
+        public virtual event EventHandler<DownloadProgressEventArgs> DownloadProgress;
+        protected void CheckIfSiteOfOrigin();
+        public new BitmapSource Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        public new BitmapSource CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        public virtual void CopyPixels(Array pixels, int stride, int offset);
+        public virtual void CopyPixels(Int32Rect sourceRect, Array pixels, int stride, int offset);
+        public virtual void CopyPixels(Int32Rect sourceRect, IntPtr buffer, int bufferSize, int stride);
+        public static BitmapSource Create(int pixelWidth, int pixelHeight, double dpiX, double dpiY, PixelFormat pixelFormat, BitmapPalette palette, Array pixels, int stride);
+        public static BitmapSource Create(int pixelWidth, int pixelHeight, double dpiX, double dpiY, PixelFormat pixelFormat, BitmapPalette palette, IntPtr buffer, int bufferSize, int stride);
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable sourceFreezable);
+        protected override void GetCurrentValueAsFrozenCore(Freezable sourceFreezable);
+    }
+    public sealed class BmpBitmapDecoder : BitmapDecoder {
+        public BmpBitmapDecoder(Stream bitmapStream, BitmapCreateOptions createOptions, BitmapCacheOption cacheOption);
+        public BmpBitmapDecoder(Uri bitmapUri, BitmapCreateOptions createOptions, BitmapCacheOption cacheOption);
+    }
+    public sealed class BmpBitmapEncoder : BitmapEncoder {
+        public BmpBitmapEncoder();
+    }
+    public sealed class CachedBitmap : BitmapSource {
+        public CachedBitmap(BitmapSource source, BitmapCreateOptions createOptions, BitmapCacheOption cacheOption);
+        public new CachedBitmap Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        public new CachedBitmap CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        protected override Freezable CreateInstanceCore();
+        protected override void GetAsFrozenCore(Freezable sourceFreezable);
+        protected override void GetCurrentValueAsFrozenCore(Freezable sourceFreezable);
+    }
+    public sealed class ColorConvertedBitmap : BitmapSource, ISupportInitialize {
+        public static readonly DependencyProperty DestinationColorContextProperty;
+        public static readonly DependencyProperty DestinationFormatProperty;
+        public static readonly DependencyProperty SourceColorContextProperty;
+        public static readonly DependencyProperty SourceProperty;
+        public ColorConvertedBitmap();
+        public ColorConvertedBitmap(BitmapSource source, ColorContext sourceColorContext, ColorContext destinationColorContext, PixelFormat format);
+        public ColorContext DestinationColorContext { get; set; }
+        public PixelFormat DestinationFormat { get; set; }
+        public BitmapSource Source { get; set; }
+        public ColorContext SourceColorContext { get; set; }
+        public void BeginInit();
+        public new ColorConvertedBitmap Clone();
+        protected override void CloneCore(Freezable source);
+        public new ColorConvertedBitmap CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable source);
+        protected override Freezable CreateInstanceCore();
+        public void EndInit();
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+    }
+    public sealed class CroppedBitmap : BitmapSource, ISupportInitialize {
+        public static readonly DependencyProperty SourceProperty;
+        public static readonly DependencyProperty SourceRectProperty;
+        public CroppedBitmap();
+        public CroppedBitmap(BitmapSource source, Int32Rect sourceRect);
+        public BitmapSource Source { get; set; }
+        public Int32Rect SourceRect { get; set; }
+        public void BeginInit();
+        public new CroppedBitmap Clone();
+        protected override void CloneCore(Freezable source);
+        public new CroppedBitmap CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable source);
+        protected override Freezable CreateInstanceCore();
+        public void EndInit();
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+    }
+    public class DownloadProgressEventArgs : EventArgs {
+        public int Progress { get; }
+    }
+    public sealed class FormatConvertedBitmap : BitmapSource, ISupportInitialize {
+        public static readonly DependencyProperty AlphaThresholdProperty;
+        public static readonly DependencyProperty DestinationFormatProperty;
+        public static readonly DependencyProperty DestinationPaletteProperty;
+        public static readonly DependencyProperty SourceProperty;
+        public FormatConvertedBitmap();
+        public FormatConvertedBitmap(BitmapSource source, PixelFormat destinationFormat, BitmapPalette destinationPalette, double alphaThreshold);
+        public double AlphaThreshold { get; set; }
+        public PixelFormat DestinationFormat { get; set; }
+        public BitmapPalette DestinationPalette { get; set; }
+        public BitmapSource Source { get; set; }
+        public void BeginInit();
+        public new FormatConvertedBitmap Clone();
+        protected override void CloneCore(Freezable source);
+        public new FormatConvertedBitmap CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable source);
+        protected override Freezable CreateInstanceCore();
+        public void EndInit();
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+    }
+    public sealed class GifBitmapDecoder : BitmapDecoder {
+        public GifBitmapDecoder(Stream bitmapStream, BitmapCreateOptions createOptions, BitmapCacheOption cacheOption);
+        public GifBitmapDecoder(Uri bitmapUri, BitmapCreateOptions createOptions, BitmapCacheOption cacheOption);
+    }
+    public sealed class GifBitmapEncoder : BitmapEncoder {
+        public GifBitmapEncoder();
+    }
+    public sealed class IconBitmapDecoder : BitmapDecoder {
+        public IconBitmapDecoder(Stream bitmapStream, BitmapCreateOptions createOptions, BitmapCacheOption cacheOption);
+        public IconBitmapDecoder(Uri bitmapUri, BitmapCreateOptions createOptions, BitmapCacheOption cacheOption);
+    }
+    public sealed class InPlaceBitmapMetadataWriter : BitmapMetadata {
+        public new InPlaceBitmapMetadataWriter Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        protected override Freezable CreateInstanceCore();
+        protected override void GetAsFrozenCore(Freezable sourceFreezable);
+        protected override void GetCurrentValueAsFrozenCore(Freezable sourceFreezable);
+        public bool TrySave();
+    }
+    public sealed class JpegBitmapDecoder : BitmapDecoder {
+        public JpegBitmapDecoder(Stream bitmapStream, BitmapCreateOptions createOptions, BitmapCacheOption cacheOption);
+        public JpegBitmapDecoder(Uri bitmapUri, BitmapCreateOptions createOptions, BitmapCacheOption cacheOption);
+    }
+    public sealed class JpegBitmapEncoder : BitmapEncoder {
+        public JpegBitmapEncoder();
+        public bool FlipHorizontal { get; set; }
+        public bool FlipVertical { get; set; }
+        public int QualityLevel { get; set; }
+        public Rotation Rotation { get; set; }
+    }
+    public sealed class LateBoundBitmapDecoder : BitmapDecoder {
+        public override BitmapCodecInfo CodecInfo { get; }
+        public override ReadOnlyCollection<ColorContext> ColorContexts { get; }
+        public BitmapDecoder Decoder { get; }
+        public override ReadOnlyCollection<BitmapFrame> Frames { get; }
+        public override bool IsDownloading { get; }
+        public override BitmapPalette Palette { get; }
+        public override BitmapSource Preview { get; }
+        public override BitmapSource Thumbnail { get; }
+    }
+    public sealed class PngBitmapDecoder : BitmapDecoder {
+        public PngBitmapDecoder(Stream bitmapStream, BitmapCreateOptions createOptions, BitmapCacheOption cacheOption);
+        public PngBitmapDecoder(Uri bitmapUri, BitmapCreateOptions createOptions, BitmapCacheOption cacheOption);
+    }
+    public sealed class PngBitmapEncoder : BitmapEncoder {
+        public PngBitmapEncoder();
+        public PngInterlaceOption Interlace { get; set; }
+    }
+    public enum PngInterlaceOption {
+        Default = 0,
+        Off = 2,
+        On = 1,
+    }
+    public sealed class RenderTargetBitmap : BitmapSource {
+        public RenderTargetBitmap(int pixelWidth, int pixelHeight, double dpiX, double dpiY, PixelFormat pixelFormat);
+        public void Clear();
+        protected override void CloneCore(Freezable sourceFreezable);
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        protected override Freezable CreateInstanceCore();
+        protected override void GetAsFrozenCore(Freezable sourceFreezable);
+        protected override void GetCurrentValueAsFrozenCore(Freezable sourceFreezable);
+        public void Render(Visual visual);
+    }
+    public enum Rotation {
+        Rotate0 = 0,
+        Rotate180 = 2,
+        Rotate270 = 3,
+        Rotate90 = 1,
+    }
+    public sealed class TiffBitmapDecoder : BitmapDecoder {
+        public TiffBitmapDecoder(Stream bitmapStream, BitmapCreateOptions createOptions, BitmapCacheOption cacheOption);
+        public TiffBitmapDecoder(Uri bitmapUri, BitmapCreateOptions createOptions, BitmapCacheOption cacheOption);
+    }
+    public sealed class TiffBitmapEncoder : BitmapEncoder {
+        public TiffBitmapEncoder();
+        public TiffCompressOption Compression { get; set; }
+    }
+    public enum TiffCompressOption {
+        Ccitt3 = 2,
+        Ccitt4 = 3,
+        Default = 0,
+        Lzw = 4,
+        None = 1,
+        Rle = 5,
+        Zip = 6,
+    }
+    public sealed class TransformedBitmap : BitmapSource, ISupportInitialize {
+        public static readonly DependencyProperty SourceProperty;
+        public static readonly DependencyProperty TransformProperty;
+        public TransformedBitmap();
+        public TransformedBitmap(BitmapSource source, Transform newTransform);
+        public BitmapSource Source { get; set; }
+        public Transform Transform { get; set; }
+        public void BeginInit();
+        public new TransformedBitmap Clone();
+        protected override void CloneCore(Freezable source);
+        public new TransformedBitmap CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable source);
+        protected override Freezable CreateInstanceCore();
+        public void EndInit();
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+    }
+    public sealed class WmpBitmapDecoder : BitmapDecoder {
+        public WmpBitmapDecoder(Stream bitmapStream, BitmapCreateOptions createOptions, BitmapCacheOption cacheOption);
+        public WmpBitmapDecoder(Uri bitmapUri, BitmapCreateOptions createOptions, BitmapCacheOption cacheOption);
+    }
+    public sealed class WmpBitmapEncoder : BitmapEncoder {
+        public WmpBitmapEncoder();
+        public byte AlphaDataDiscardLevel { get; set; }
+        public byte AlphaQualityLevel { get; set; }
+        public bool CompressedDomainTranscode { get; set; }
+        public bool FlipHorizontal { get; set; }
+        public bool FlipVertical { get; set; }
+        public bool FrequencyOrder { get; set; }
+        public short HorizontalTileSlices { get; set; }
+        public bool IgnoreOverlap { get; set; }
+        public byte ImageDataDiscardLevel { get; set; }
+        public float ImageQualityLevel { get; set; }
+        public bool InterleavedAlpha { get; set; }
+        public bool Lossless { get; set; }
+        public byte OverlapLevel { get; set; }
+        public byte QualityLevel { get; set; }
+        public Rotation Rotation { get; set; }
+        public byte SubsamplingLevel { get; set; }
+        public bool UseCodecOptions { get; set; }
+        public short VerticalTileSlices { get; set; }
+    }
+    public sealed class WriteableBitmap : BitmapSource {
+        public WriteableBitmap(int pixelWidth, int pixelHeight, double dpiX, double dpiY, PixelFormat pixelFormat, BitmapPalette palette);
+        public WriteableBitmap(BitmapSource source);
+        public IntPtr BackBuffer { get; private set; }
+        public int BackBufferStride { get; }
+        public void AddDirtyRect(Int32Rect dirtyRect);
+        public new WriteableBitmap Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        public new WriteableBitmap CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable sourceFreezable);
+        protected override void GetCurrentValueAsFrozenCore(Freezable sourceFreezable);
+        public void Lock();
+        public bool TryLock(Duration timeout);
+        public void Unlock();
+        public void WritePixels(Int32Rect sourceRect, Array pixels, int stride, int offset);
+        public void WritePixels(Int32Rect sourceRect, Array sourceBuffer, int sourceBufferStride, int destinationX, int destinationY);
+        public void WritePixels(Int32Rect sourceRect, IntPtr buffer, int bufferSize, int stride);
+        public void WritePixels(Int32Rect sourceRect, IntPtr sourceBuffer, int sourceBufferSize, int sourceBufferStride, int destinationX, int destinationY);
+    }
+}
```

