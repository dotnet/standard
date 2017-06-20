# System.Drawing.Imaging

``` diff
+namespace System.Drawing.Imaging {
+    public sealed class BitmapData {
+        public BitmapData();
+        public int Height { get; set; }
+        public PixelFormat PixelFormat { get; set; }
+        public int Reserved { get; set; }
+        public IntPtr Scan0 { get; set; }
+        public int Stride { get; set; }
+        public int Width { get; set; }
+    }
+    public enum ColorAdjustType {
+        Any = 6,
+        Bitmap = 1,
+        Brush = 2,
+        Count = 5,
+        Default = 0,
+        Pen = 3,
+        Text = 4,
+    }
+    public enum ColorChannelFlag {
+        ColorChannelC = 0,
+        ColorChannelK = 3,
+        ColorChannelLast = 4,
+        ColorChannelM = 1,
+        ColorChannelY = 2,
+    }
+    public sealed class ColorMap {
+        public ColorMap();
+        public Color NewColor { get; set; }
+        public Color OldColor { get; set; }
+    }
+    public enum ColorMapType {
+        Brush = 1,
+        Default = 0,
+    }
+    public sealed class ColorMatrix {
+        public ColorMatrix();
+        public ColorMatrix(float[][] newColorMatrix);
+        public float Matrix00 { get; set; }
+        public float Matrix01 { get; set; }
+        public float Matrix02 { get; set; }
+        public float Matrix03 { get; set; }
+        public float Matrix04 { get; set; }
+        public float Matrix10 { get; set; }
+        public float Matrix11 { get; set; }
+        public float Matrix12 { get; set; }
+        public float Matrix13 { get; set; }
+        public float Matrix14 { get; set; }
+        public float Matrix20 { get; set; }
+        public float Matrix21 { get; set; }
+        public float Matrix22 { get; set; }
+        public float Matrix23 { get; set; }
+        public float Matrix24 { get; set; }
+        public float Matrix30 { get; set; }
+        public float Matrix31 { get; set; }
+        public float Matrix32 { get; set; }
+        public float Matrix33 { get; set; }
+        public float Matrix34 { get; set; }
+        public float Matrix40 { get; set; }
+        public float Matrix41 { get; set; }
+        public float Matrix42 { get; set; }
+        public float Matrix43 { get; set; }
+        public float Matrix44 { get; set; }
+        public float this[int row, int column] { get; set; }
+    }
+    public enum ColorMatrixFlag {
+        AltGrays = 2,
+        Default = 0,
+        SkipGrays = 1,
+    }
+    public enum ColorMode {
+        Argb32Mode = 0,
+        Argb64Mode = 1,
+    }
+    public sealed class ColorPalette {
+        public Color[] Entries { get; }
+        public int Flags { get; }
+    }
+    public enum EmfPlusRecordType {
+        BeginContainer = 16423,
+        BeginContainerNoParams = 16424,
+        Clear = 16393,
+        Comment = 16387,
+        DrawArc = 16402,
+        DrawBeziers = 16409,
+        DrawClosedCurve = 16407,
+        DrawCurve = 16408,
+        DrawDriverString = 16438,
+        DrawEllipse = 16399,
+        DrawImage = 16410,
+        DrawImagePoints = 16411,
+        DrawLines = 16397,
+        DrawPath = 16405,
+        DrawPie = 16401,
+        DrawRects = 16395,
+        DrawString = 16412,
+        EmfAbortPath = 68,
+        EmfAlphaBlend = 114,
+        EmfAngleArc = 41,
+        EmfArcTo = 55,
+        EmfBeginPath = 59,
+        EmfBitBlt = 76,
+        EmfChord = 46,
+        EmfCloseFigure = 61,
+        EmfColorCorrectPalette = 111,
+        EmfColorMatchToTargetW = 121,
+        EmfCreateBrushIndirect = 39,
+        EmfCreateColorSpace = 99,
+        EmfCreateColorSpaceW = 122,
+        EmfCreateDibPatternBrushPt = 94,
+        EmfCreateMonoBrush = 93,
+        EmfCreatePalette = 49,
+        EmfCreatePen = 38,
+        EmfDeleteColorSpace = 101,
+        EmfDeleteObject = 40,
+        EmfDrawEscape = 105,
+        EmfEllipse = 42,
+        EmfEndPath = 60,
+        EmfEof = 14,
+        EmfExcludeClipRect = 29,
+        EmfExtCreateFontIndirect = 82,
+        EmfExtCreatePen = 95,
+        EmfExtEscape = 106,
+        EmfExtFloodFill = 53,
+        EmfExtSelectClipRgn = 75,
+        EmfExtTextOutA = 83,
+        EmfExtTextOutW = 84,
+        EmfFillPath = 62,
+        EmfFillRgn = 71,
+        EmfFlattenPath = 65,
+        EmfForceUfiMapping = 109,
+        EmfFrameRgn = 72,
+        EmfGdiComment = 70,
+        EmfGlsBoundedRecord = 103,
+        EmfGlsRecord = 102,
+        EmfGradientFill = 118,
+        EmfHeader = 1,
+        EmfIntersectClipRect = 30,
+        EmfInvertRgn = 73,
+        EmfLineTo = 54,
+        EmfMaskBlt = 78,
+        EmfMax = 122,
+        EmfMin = 1,
+        EmfModifyWorldTransform = 36,
+        EmfMoveToEx = 27,
+        EmfNamedEscpae = 110,
+        EmfOffsetClipRgn = 26,
+        EmfPaintRgn = 74,
+        EmfPie = 47,
+        EmfPixelFormat = 104,
+        EmfPlgBlt = 79,
+        EmfPlusRecordBase = 16384,
+        EmfPolyBezier = 2,
+        EmfPolyBezier16 = 85,
+        EmfPolyBezierTo = 5,
+        EmfPolyBezierTo16 = 88,
+        EmfPolyDraw = 56,
+        EmfPolyDraw16 = 92,
+        EmfPolygon = 3,
+        EmfPolygon16 = 86,
+        EmfPolyline = 4,
+        EmfPolyline16 = 87,
+        EmfPolyLineTo = 6,
+        EmfPolylineTo16 = 89,
+        EmfPolyPolygon = 8,
+        EmfPolyPolygon16 = 91,
+        EmfPolyPolyline = 7,
+        EmfPolyPolyline16 = 90,
+        EmfPolyTextOutA = 96,
+        EmfPolyTextOutW = 97,
+        EmfRealizePalette = 52,
+        EmfRectangle = 43,
+        EmfReserved069 = 69,
+        EmfReserved117 = 117,
+        EmfResizePalette = 51,
+        EmfRestoreDC = 34,
+        EmfRoundArc = 45,
+        EmfRoundRect = 44,
+        EmfSaveDC = 33,
+        EmfScaleViewportExtEx = 31,
+        EmfScaleWindowExtEx = 32,
+        EmfSelectClipPath = 67,
+        EmfSelectObject = 37,
+        EmfSelectPalette = 48,
+        EmfSetArcDirection = 57,
+        EmfSetBkColor = 25,
+        EmfSetBkMode = 18,
+        EmfSetBrushOrgEx = 13,
+        EmfSetColorAdjustment = 23,
+        EmfSetColorSpace = 100,
+        EmfSetDIBitsToDevice = 80,
+        EmfSetIcmMode = 98,
+        EmfSetIcmProfileA = 112,
+        EmfSetIcmProfileW = 113,
+        EmfSetLayout = 115,
+        EmfSetLinkedUfis = 119,
+        EmfSetMapMode = 17,
+        EmfSetMapperFlags = 16,
+        EmfSetMetaRgn = 28,
+        EmfSetMiterLimit = 58,
+        EmfSetPaletteEntries = 50,
+        EmfSetPixelV = 15,
+        EmfSetPolyFillMode = 19,
+        EmfSetROP2 = 20,
+        EmfSetStretchBltMode = 21,
+        EmfSetTextAlign = 22,
+        EmfSetTextColor = 24,
+        EmfSetTextJustification = 120,
+        EmfSetViewportExtEx = 11,
+        EmfSetViewportOrgEx = 12,
+        EmfSetWindowExtEx = 9,
+        EmfSetWindowOrgEx = 10,
+        EmfSetWorldTransform = 35,
+        EmfSmallTextOut = 108,
+        EmfStartDoc = 107,
+        EmfStretchBlt = 77,
+        EmfStretchDIBits = 81,
+        EmfStrokeAndFillPath = 63,
+        EmfStrokePath = 64,
+        EmfTransparentBlt = 116,
+        EmfWidenPath = 66,
+        EndContainer = 16425,
+        EndOfFile = 16386,
+        FillClosedCurve = 16406,
+        FillEllipse = 16398,
+        FillPath = 16404,
+        FillPie = 16400,
+        FillPolygon = 16396,
+        FillRects = 16394,
+        FillRegion = 16403,
+        GetDC = 16388,
+        Header = 16385,
+        Invalid = 16384,
+        Max = 16438,
+        Min = 16385,
+        MultiFormatEnd = 16391,
+        MultiFormatSection = 16390,
+        MultiFormatStart = 16389,
+        MultiplyWorldTransform = 16428,
+        Object = 16392,
+        OffsetClip = 16437,
+        ResetClip = 16433,
+        ResetWorldTransform = 16427,
+        Restore = 16422,
+        RotateWorldTransform = 16431,
+        Save = 16421,
+        ScaleWorldTransform = 16430,
+        SetAntiAliasMode = 16414,
+        SetClipPath = 16435,
+        SetClipRect = 16434,
+        SetClipRegion = 16436,
+        SetCompositingMode = 16419,
+        SetCompositingQuality = 16420,
+        SetInterpolationMode = 16417,
+        SetPageTransform = 16432,
+        SetPixelOffsetMode = 16418,
+        SetRenderingOrigin = 16413,
+        SetTextContrast = 16416,
+        SetTextRenderingHint = 16415,
+        SetWorldTransform = 16426,
+        Total = 16439,
+        TranslateWorldTransform = 16429,
+        WmfAnimatePalette = 66614,
+        WmfArc = 67607,
+        WmfBitBlt = 67874,
+        WmfChord = 67632,
+        WmfCreateBrushIndirect = 66300,
+        WmfCreateFontIndirect = 66299,
+        WmfCreatePalette = 65783,
+        WmfCreatePatternBrush = 66041,
+        WmfCreatePenIndirect = 66298,
+        WmfCreateRegion = 67327,
+        WmfDeleteObject = 66032,
+        WmfDibBitBlt = 67904,
+        WmfDibCreatePatternBrush = 65858,
+        WmfDibStretchBlt = 68417,
+        WmfEllipse = 66584,
+        WmfEscape = 67110,
+        WmfExcludeClipRect = 66581,
+        WmfExtFloodFill = 66888,
+        WmfExtTextOut = 68146,
+        WmfFillRegion = 66088,
+        WmfFloodFill = 66585,
+        WmfFrameRegion = 66601,
+        WmfIntersectClipRect = 66582,
+        WmfInvertRegion = 65834,
+        WmfLineTo = 66067,
+        WmfMoveTo = 66068,
+        WmfOffsetCilpRgn = 66080,
+        WmfOffsetViewportOrg = 66065,
+        WmfOffsetWindowOrg = 66063,
+        WmfPaintRegion = 65835,
+        WmfPatBlt = 67101,
+        WmfPie = 67610,
+        WmfPolygon = 66340,
+        WmfPolyline = 66341,
+        WmfPolyPolygon = 66872,
+        WmfRealizePalette = 65589,
+        WmfRecordBase = 65536,
+        WmfRectangle = 66587,
+        WmfResizePalette = 65849,
+        WmfRestoreDC = 65831,
+        WmfRoundRect = 67100,
+        WmfSaveDC = 65566,
+        WmfScaleViewportExt = 66578,
+        WmfScaleWindowExt = 66576,
+        WmfSelectClipRegion = 65836,
+        WmfSelectObject = 65837,
+        WmfSelectPalette = 66100,
+        WmfSetBkColor = 66049,
+        WmfSetBkMode = 65794,
+        WmfSetDibToDev = 68915,
+        WmfSetLayout = 65865,
+        WmfSetMapMode = 65795,
+        WmfSetMapperFlags = 66097,
+        WmfSetPalEntries = 65591,
+        WmfSetPixel = 66591,
+        WmfSetPolyFillMode = 65798,
+        WmfSetRelAbs = 65797,
+        WmfSetROP2 = 65796,
+        WmfSetStretchBltMode = 65799,
+        WmfSetTextAlign = 65838,
+        WmfSetTextCharExtra = 65800,
+        WmfSetTextColor = 66057,
+        WmfSetTextJustification = 66058,
+        WmfSetViewportExt = 66062,
+        WmfSetViewportOrg = 66061,
+        WmfSetWindowExt = 66060,
+        WmfSetWindowOrg = 66059,
+        WmfStretchBlt = 68387,
+        WmfStretchDib = 69443,
+        WmfTextOut = 66849,
+    }
+    public enum EmfType {
+        EmfOnly = 3,
+        EmfPlusDual = 5,
+        EmfPlusOnly = 4,
+    }
+    public sealed class Encoder {
+        public static readonly Encoder ChrominanceTable;
+        public static readonly Encoder ColorDepth;
+        public static readonly Encoder Compression;
+        public static readonly Encoder LuminanceTable;
+        public static readonly Encoder Quality;
+        public static readonly Encoder RenderMethod;
+        public static readonly Encoder SaveFlag;
+        public static readonly Encoder ScanMethod;
+        public static readonly Encoder Transformation;
+        public static readonly Encoder Version;
+        public Encoder(Guid guid);
+        public Guid Guid { get; }
+    }
+    public sealed class EncoderParameter : IDisposable {
+        public EncoderParameter(Encoder encoder, byte value);
+        public EncoderParameter(Encoder encoder, byte value, bool undefined);
+        public EncoderParameter(Encoder encoder, byte[] value);
+        public EncoderParameter(Encoder encoder, byte[] value, bool undefined);
+        public EncoderParameter(Encoder encoder, short value);
+        public EncoderParameter(Encoder encoder, short[] value);
+        public EncoderParameter(Encoder encoder, int numberValues, EncoderParameterValueType type, IntPtr value);
+        public EncoderParameter(Encoder encoder, int numerator, int denominator);
+        public EncoderParameter(Encoder encoder, int NumberOfValues, int Type, int Value);
+        public EncoderParameter(Encoder encoder, int numerator1, int demoninator1, int numerator2, int demoninator2);
+        public EncoderParameter(Encoder encoder, int[] numerator, int[] denominator);
+        public EncoderParameter(Encoder encoder, int[] numerator1, int[] denominator1, int[] numerator2, int[] denominator2);
+        public EncoderParameter(Encoder encoder, long value);
+        public EncoderParameter(Encoder encoder, long rangebegin, long rangeend);
+        public EncoderParameter(Encoder encoder, long[] value);
+        public EncoderParameter(Encoder encoder, long[] rangebegin, long[] rangeend);
+        public EncoderParameter(Encoder encoder, string value);
+        public Encoder Encoder { get; set; }
+        public int NumberOfValues { get; }
+        public EncoderParameterValueType Type { get; }
+        public EncoderParameterValueType ValueType { get; }
+        public void Dispose();
+        ~EncoderParameter();
+    }
+    public sealed class EncoderParameters : IDisposable {
+        public EncoderParameters();
+        public EncoderParameters(int count);
+        public EncoderParameter[] Param { get; set; }
+        public void Dispose();
+    }
+    public enum EncoderParameterValueType {
+        ValueTypeAscii = 2,
+        ValueTypeByte = 1,
+        ValueTypeLong = 4,
+        ValueTypeLongRange = 6,
+        ValueTypeRational = 5,
+        ValueTypeRationalRange = 8,
+        ValueTypeShort = 3,
+        ValueTypeUndefined = 7,
+    }
+    public enum EncoderValue {
+        ColorTypeCMYK = 0,
+        ColorTypeYCCK = 1,
+        CompressionCCITT3 = 3,
+        CompressionCCITT4 = 4,
+        CompressionLZW = 2,
+        CompressionNone = 6,
+        CompressionRle = 5,
+        Flush = 20,
+        FrameDimensionPage = 23,
+        FrameDimensionResolution = 22,
+        FrameDimensionTime = 21,
+        LastFrame = 19,
+        MultiFrame = 18,
+        RenderNonProgressive = 12,
+        RenderProgressive = 11,
+        ScanMethodInterlaced = 7,
+        ScanMethodNonInterlaced = 8,
+        TransformFlipHorizontal = 16,
+        TransformFlipVertical = 17,
+        TransformRotate180 = 14,
+        TransformRotate270 = 15,
+        TransformRotate90 = 13,
+        VersionGif87 = 9,
+        VersionGif89 = 10,
+    }
+    public sealed class FrameDimension {
+        public FrameDimension(Guid guid);
+        public Guid Guid { get; }
+        public static FrameDimension Page { get; }
+        public static FrameDimension Resolution { get; }
+        public static FrameDimension Time { get; }
+        public override bool Equals(object o);
+        public override int GetHashCode();
+        public override string ToString();
+    }
+    public sealed class ImageAttributes : ICloneable, IDisposable {
+        public ImageAttributes();
+        public void ClearBrushRemapTable();
+        public void ClearColorKey();
+        public void ClearColorKey(ColorAdjustType type);
+        public void ClearColorMatrix();
+        public void ClearColorMatrix(ColorAdjustType type);
+        public void ClearGamma();
+        public void ClearGamma(ColorAdjustType type);
+        public void ClearNoOp();
+        public void ClearNoOp(ColorAdjustType type);
+        public void ClearOutputChannel();
+        public void ClearOutputChannel(ColorAdjustType type);
+        public void ClearOutputChannelColorProfile();
+        public void ClearOutputChannelColorProfile(ColorAdjustType type);
+        public void ClearRemapTable();
+        public void ClearRemapTable(ColorAdjustType type);
+        public void ClearThreshold();
+        public void ClearThreshold(ColorAdjustType type);
+        public object Clone();
+        public void Dispose();
+        ~ImageAttributes();
+        public void GetAdjustedPalette(ColorPalette palette, ColorAdjustType type);
+        public void SetBrushRemapTable(ColorMap[] map);
+        public void SetColorKey(Color colorLow, Color colorHigh);
+        public void SetColorKey(Color colorLow, Color colorHigh, ColorAdjustType type);
+        public void SetColorMatrices(ColorMatrix newColorMatrix, ColorMatrix grayMatrix);
+        public void SetColorMatrices(ColorMatrix newColorMatrix, ColorMatrix grayMatrix, ColorMatrixFlag flags);
+        public void SetColorMatrices(ColorMatrix newColorMatrix, ColorMatrix grayMatrix, ColorMatrixFlag mode, ColorAdjustType type);
+        public void SetColorMatrix(ColorMatrix newColorMatrix);
+        public void SetColorMatrix(ColorMatrix newColorMatrix, ColorMatrixFlag flags);
+        public void SetColorMatrix(ColorMatrix newColorMatrix, ColorMatrixFlag mode, ColorAdjustType type);
+        public void SetGamma(float gamma);
+        public void SetGamma(float gamma, ColorAdjustType type);
+        public void SetNoOp();
+        public void SetNoOp(ColorAdjustType type);
+        public void SetOutputChannel(ColorChannelFlag flags);
+        public void SetOutputChannel(ColorChannelFlag flags, ColorAdjustType type);
+        public void SetOutputChannelColorProfile(string colorProfileFilename);
+        public void SetOutputChannelColorProfile(string colorProfileFilename, ColorAdjustType type);
+        public void SetRemapTable(ColorMap[] map);
+        public void SetRemapTable(ColorMap[] map, ColorAdjustType type);
+        public void SetThreshold(float threshold);
+        public void SetThreshold(float threshold, ColorAdjustType type);
+        public void SetWrapMode(WrapMode mode);
+        public void SetWrapMode(WrapMode mode, Color color);
+        public void SetWrapMode(WrapMode mode, Color color, bool clamp);
+    }
+    public enum ImageCodecFlags {
+        BlockingDecode = 32,
+        Builtin = 65536,
+        Decoder = 2,
+        Encoder = 1,
+        SeekableEncode = 16,
+        SupportBitmap = 4,
+        SupportVector = 8,
+        System = 131072,
+        User = 262144,
+    }
+    public sealed class ImageCodecInfo {
+        public Guid Clsid { get; set; }
+        public string CodecName { get; set; }
+        public string DllName { get; set; }
+        public string FilenameExtension { get; set; }
+        public ImageCodecFlags Flags { get; set; }
+        public string FormatDescription { get; set; }
+        public Guid FormatID { get; set; }
+        public string MimeType { get; set; }
+        public byte[][] SignatureMasks { get; set; }
+        public byte[][] SignaturePatterns { get; set; }
+        public int Version { get; set; }
+        public static ImageCodecInfo[] GetImageDecoders();
+        public static ImageCodecInfo[] GetImageEncoders();
+    }
+    public enum ImageFlags {
+        Caching = 131072,
+        ColorSpaceCmyk = 32,
+        ColorSpaceGray = 64,
+        ColorSpaceRgb = 16,
+        ColorSpaceYcbcr = 128,
+        ColorSpaceYcck = 256,
+        HasAlpha = 2,
+        HasRealDpi = 4096,
+        HasRealPixelSize = 8192,
+        HasTranslucent = 4,
+        None = 0,
+        PartiallyScalable = 8,
+        ReadOnly = 65536,
+        Scalable = 1,
+    }
+    public sealed class ImageFormat {
+        public ImageFormat(Guid guid);
+        public static ImageFormat Bmp { get; }
+        public static ImageFormat Emf { get; }
+        public static ImageFormat Exif { get; }
+        public static ImageFormat Gif { get; }
+        public Guid Guid { get; }
+        public static ImageFormat Icon { get; }
+        public static ImageFormat Jpeg { get; }
+        public static ImageFormat MemoryBmp { get; }
+        public static ImageFormat Png { get; }
+        public static ImageFormat Tiff { get; }
+        public static ImageFormat Wmf { get; }
+        public override bool Equals(object o);
+        public override int GetHashCode();
+        public override string ToString();
+    }
+    public enum ImageLockMode {
+        ReadOnly = 1,
+        ReadWrite = 3,
+        UserInputBuffer = 4,
+        WriteOnly = 2,
+    }
+    public sealed class Metafile : Image {
+        public Metafile(IntPtr henhmetafile, bool deleteEmf);
+        public Metafile(IntPtr referenceHdc, EmfType emfType);
+        public Metafile(IntPtr referenceHdc, EmfType emfType, string description);
+        public Metafile(IntPtr hmetafile, WmfPlaceableFileHeader wmfHeader);
+        public Metafile(IntPtr hmetafile, WmfPlaceableFileHeader wmfHeader, bool deleteWmf);
+        public Metafile(IntPtr referenceHdc, Rectangle frameRect);
+        public Metafile(IntPtr referenceHdc, Rectangle frameRect, MetafileFrameUnit frameUnit);
+        public Metafile(IntPtr referenceHdc, Rectangle frameRect, MetafileFrameUnit frameUnit, EmfType type);
+        public Metafile(IntPtr referenceHdc, Rectangle frameRect, MetafileFrameUnit frameUnit, EmfType type, string desc);
+        public Metafile(IntPtr referenceHdc, RectangleF frameRect);
+        public Metafile(IntPtr referenceHdc, RectangleF frameRect, MetafileFrameUnit frameUnit);
+        public Metafile(IntPtr referenceHdc, RectangleF frameRect, MetafileFrameUnit frameUnit, EmfType type);
+        public Metafile(IntPtr referenceHdc, RectangleF frameRect, MetafileFrameUnit frameUnit, EmfType type, string description);
+        public Metafile(Stream stream);
+        public Metafile(Stream stream, IntPtr referenceHdc);
+        public Metafile(Stream stream, IntPtr referenceHdc, EmfType type);
+        public Metafile(Stream stream, IntPtr referenceHdc, EmfType type, string description);
+        public Metafile(Stream stream, IntPtr referenceHdc, Rectangle frameRect);
+        public Metafile(Stream stream, IntPtr referenceHdc, Rectangle frameRect, MetafileFrameUnit frameUnit);
+        public Metafile(Stream stream, IntPtr referenceHdc, Rectangle frameRect, MetafileFrameUnit frameUnit, EmfType type);
+        public Metafile(Stream stream, IntPtr referenceHdc, Rectangle frameRect, MetafileFrameUnit frameUnit, EmfType type, string description);
+        public Metafile(Stream stream, IntPtr referenceHdc, RectangleF frameRect);
+        public Metafile(Stream stream, IntPtr referenceHdc, RectangleF frameRect, MetafileFrameUnit frameUnit);
+        public Metafile(Stream stream, IntPtr referenceHdc, RectangleF frameRect, MetafileFrameUnit frameUnit, EmfType type);
+        public Metafile(Stream stream, IntPtr referenceHdc, RectangleF frameRect, MetafileFrameUnit frameUnit, EmfType type, string description);
+        public Metafile(string filename);
+        public Metafile(string fileName, IntPtr referenceHdc);
+        public Metafile(string fileName, IntPtr referenceHdc, EmfType type);
+        public Metafile(string fileName, IntPtr referenceHdc, EmfType type, string description);
+        public Metafile(string fileName, IntPtr referenceHdc, Rectangle frameRect);
+        public Metafile(string fileName, IntPtr referenceHdc, Rectangle frameRect, MetafileFrameUnit frameUnit);
+        public Metafile(string fileName, IntPtr referenceHdc, Rectangle frameRect, MetafileFrameUnit frameUnit, EmfType type);
+        public Metafile(string fileName, IntPtr referenceHdc, Rectangle frameRect, MetafileFrameUnit frameUnit, EmfType type, string description);
+        public Metafile(string fileName, IntPtr referenceHdc, Rectangle frameRect, MetafileFrameUnit frameUnit, string description);
+        public Metafile(string fileName, IntPtr referenceHdc, RectangleF frameRect);
+        public Metafile(string fileName, IntPtr referenceHdc, RectangleF frameRect, MetafileFrameUnit frameUnit);
+        public Metafile(string fileName, IntPtr referenceHdc, RectangleF frameRect, MetafileFrameUnit frameUnit, EmfType type);
+        public Metafile(string fileName, IntPtr referenceHdc, RectangleF frameRect, MetafileFrameUnit frameUnit, EmfType type, string description);
+        public Metafile(string fileName, IntPtr referenceHdc, RectangleF frameRect, MetafileFrameUnit frameUnit, string desc);
+        public IntPtr GetHenhmetafile();
+        public MetafileHeader GetMetafileHeader();
+        public static MetafileHeader GetMetafileHeader(IntPtr henhmetafile);
+        public static MetafileHeader GetMetafileHeader(IntPtr hmetafile, WmfPlaceableFileHeader wmfHeader);
+        public static MetafileHeader GetMetafileHeader(Stream stream);
+        public static MetafileHeader GetMetafileHeader(string fileName);
+        public void PlayRecord(EmfPlusRecordType recordType, int flags, int dataSize, byte[] data);
+    }
+    public enum MetafileFrameUnit {
+        Document = 5,
+        GdiCompatible = 7,
+        Inch = 4,
+        Millimeter = 6,
+        Pixel = 2,
+        Point = 3,
+    }
+    public sealed class MetafileHeader {
+        public Rectangle Bounds { get; }
+        public float DpiX { get; }
+        public float DpiY { get; }
+        public int EmfPlusHeaderSize { get; }
+        public int LogicalDpiX { get; }
+        public int LogicalDpiY { get; }
+        public int MetafileSize { get; }
+        public MetafileType Type { get; }
+        public int Version { get; }
+        public MetaHeader WmfHeader { get; }
+        public bool IsDisplay();
+        public bool IsEmf();
+        public bool IsEmfOrEmfPlus();
+        public bool IsEmfPlus();
+        public bool IsEmfPlusDual();
+        public bool IsEmfPlusOnly();
+        public bool IsWmf();
+        public bool IsWmfPlaceable();
+    }
+    public enum MetafileType {
+        Emf = 3,
+        EmfPlusDual = 5,
+        EmfPlusOnly = 4,
+        Invalid = 0,
+        Wmf = 1,
+        WmfPlaceable = 2,
+    }
+    public sealed class MetaHeader {
+        public MetaHeader();
+        public short HeaderSize { get; set; }
+        public int MaxRecord { get; set; }
+        public short NoObjects { get; set; }
+        public short NoParameters { get; set; }
+        public int Size { get; set; }
+        public short Type { get; set; }
+        public short Version { get; set; }
+    }
+    public enum PaletteFlags {
+        GrayScale = 2,
+        Halftone = 4,
+        HasAlpha = 1,
+    }
+    public enum PixelFormat {
+        Alpha = 262144,
+        Canonical = 2097152,
+        DontCare = 0,
+        Extended = 1048576,
+        Format16bppArgb1555 = 397319,
+        Format16bppGrayScale = 1052676,
+        Format16bppRgb555 = 135173,
+        Format16bppRgb565 = 135174,
+        Format1bppIndexed = 196865,
+        Format24bppRgb = 137224,
+        Format32bppArgb = 2498570,
+        Format32bppPArgb = 925707,
+        Format32bppRgb = 139273,
+        Format48bppRgb = 1060876,
+        Format4bppIndexed = 197634,
+        Format64bppArgb = 3424269,
+        Format64bppPArgb = 1851406,
+        Format8bppIndexed = 198659,
+        Gdi = 131072,
+        Indexed = 65536,
+        Max = 15,
+        PAlpha = 524288,
+        Undefined = 0,
+    }
+    public delegate void PlayRecordCallback(EmfPlusRecordType recordType, int flags, int dataSize, IntPtr recordData);
+    public sealed class PropertyItem {
+        public int Id { get; set; }
+        public int Len { get; set; }
+        public short Type { get; set; }
+        public byte[] Value { get; set; }
+    }
+    public sealed class WmfPlaceableFileHeader {
+        public WmfPlaceableFileHeader();
+        public short BboxBottom { get; set; }
+        public short BboxLeft { get; set; }
+        public short BboxRight { get; set; }
+        public short BboxTop { get; set; }
+        public short Checksum { get; set; }
+        public short Hmf { get; set; }
+        public short Inch { get; set; }
+        public int Key { get; set; }
+        public int Reserved { get; set; }
+    }
+}
```

