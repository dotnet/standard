# System.Drawing

``` diff
 namespace System.Drawing {
+    public sealed class Bitmap : Image {
+        public Bitmap(Image original);
+        public Bitmap(Image original, Size newSize);
+        public Bitmap(Image original, int width, int height);
+        public Bitmap(int width, int height);
+        public Bitmap(int width, int height, Graphics g);
+        public Bitmap(int width, int height, PixelFormat format);
+        public Bitmap(int width, int height, int stride, PixelFormat format, IntPtr scan0);
+        public Bitmap(Stream stream);
+        public Bitmap(Stream stream, bool useIcm);
+        public Bitmap(string filename);
+        public Bitmap(string filename, bool useIcm);
+        public Bitmap(Type type, string resource);
+        public Bitmap Clone(Rectangle rect, PixelFormat format);
+        public Bitmap Clone(RectangleF rect, PixelFormat format);
+        public static Bitmap FromHicon(IntPtr hicon);
+        public static Bitmap FromResource(IntPtr hinstance, string bitmapName);
+        public IntPtr GetHbitmap();
+        public IntPtr GetHbitmap(Color background);
+        public IntPtr GetHicon();
+        public Color GetPixel(int x, int y);
+        public BitmapData LockBits(Rectangle rect, ImageLockMode flags, PixelFormat format);
+        public BitmapData LockBits(Rectangle rect, ImageLockMode flags, PixelFormat format, BitmapData bitmapData);
+        public void MakeTransparent();
+        public void MakeTransparent(Color transparentColor);
+        public void SetPixel(int x, int y, Color color);
+        public void SetResolution(float xDpi, float yDpi);
+        public void UnlockBits(BitmapData bitmapdata);
+    }
+    public class BitmapSuffixInSameAssemblyAttribute : Attribute {
+        public BitmapSuffixInSameAssemblyAttribute();
+    }
+    public class BitmapSuffixInSatelliteAssemblyAttribute : Attribute {
+        public BitmapSuffixInSatelliteAssemblyAttribute();
+    }
+    public abstract class Brush : MarshalByRefObject, ICloneable, IDisposable {
+        protected Brush();
+        public abstract object Clone();
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        ~Brush();
+        protected internal void SetNativeBrush(IntPtr brush);
+    }
+    public sealed class Brushes {
+        public static Brush AliceBlue { get; }
+        public static Brush AntiqueWhite { get; }
+        public static Brush Aqua { get; }
+        public static Brush Aquamarine { get; }
+        public static Brush Azure { get; }
+        public static Brush Beige { get; }
+        public static Brush Bisque { get; }
+        public static Brush Black { get; }
+        public static Brush BlanchedAlmond { get; }
+        public static Brush Blue { get; }
+        public static Brush BlueViolet { get; }
+        public static Brush Brown { get; }
+        public static Brush BurlyWood { get; }
+        public static Brush CadetBlue { get; }
+        public static Brush Chartreuse { get; }
+        public static Brush Chocolate { get; }
+        public static Brush Coral { get; }
+        public static Brush CornflowerBlue { get; }
+        public static Brush Cornsilk { get; }
+        public static Brush Crimson { get; }
+        public static Brush Cyan { get; }
+        public static Brush DarkBlue { get; }
+        public static Brush DarkCyan { get; }
+        public static Brush DarkGoldenrod { get; }
+        public static Brush DarkGray { get; }
+        public static Brush DarkGreen { get; }
+        public static Brush DarkKhaki { get; }
+        public static Brush DarkMagenta { get; }
+        public static Brush DarkOliveGreen { get; }
+        public static Brush DarkOrange { get; }
+        public static Brush DarkOrchid { get; }
+        public static Brush DarkRed { get; }
+        public static Brush DarkSalmon { get; }
+        public static Brush DarkSeaGreen { get; }
+        public static Brush DarkSlateBlue { get; }
+        public static Brush DarkSlateGray { get; }
+        public static Brush DarkTurquoise { get; }
+        public static Brush DarkViolet { get; }
+        public static Brush DeepPink { get; }
+        public static Brush DeepSkyBlue { get; }
+        public static Brush DimGray { get; }
+        public static Brush DodgerBlue { get; }
+        public static Brush Firebrick { get; }
+        public static Brush FloralWhite { get; }
+        public static Brush ForestGreen { get; }
+        public static Brush Fuchsia { get; }
+        public static Brush Gainsboro { get; }
+        public static Brush GhostWhite { get; }
+        public static Brush Gold { get; }
+        public static Brush Goldenrod { get; }
+        public static Brush Gray { get; }
+        public static Brush Green { get; }
+        public static Brush GreenYellow { get; }
+        public static Brush Honeydew { get; }
+        public static Brush HotPink { get; }
+        public static Brush IndianRed { get; }
+        public static Brush Indigo { get; }
+        public static Brush Ivory { get; }
+        public static Brush Khaki { get; }
+        public static Brush Lavender { get; }
+        public static Brush LavenderBlush { get; }
+        public static Brush LawnGreen { get; }
+        public static Brush LemonChiffon { get; }
+        public static Brush LightBlue { get; }
+        public static Brush LightCoral { get; }
+        public static Brush LightCyan { get; }
+        public static Brush LightGoldenrodYellow { get; }
+        public static Brush LightGray { get; }
+        public static Brush LightGreen { get; }
+        public static Brush LightPink { get; }
+        public static Brush LightSalmon { get; }
+        public static Brush LightSeaGreen { get; }
+        public static Brush LightSkyBlue { get; }
+        public static Brush LightSlateGray { get; }
+        public static Brush LightSteelBlue { get; }
+        public static Brush LightYellow { get; }
+        public static Brush Lime { get; }
+        public static Brush LimeGreen { get; }
+        public static Brush Linen { get; }
+        public static Brush Magenta { get; }
+        public static Brush Maroon { get; }
+        public static Brush MediumAquamarine { get; }
+        public static Brush MediumBlue { get; }
+        public static Brush MediumOrchid { get; }
+        public static Brush MediumPurple { get; }
+        public static Brush MediumSeaGreen { get; }
+        public static Brush MediumSlateBlue { get; }
+        public static Brush MediumSpringGreen { get; }
+        public static Brush MediumTurquoise { get; }
+        public static Brush MediumVioletRed { get; }
+        public static Brush MidnightBlue { get; }
+        public static Brush MintCream { get; }
+        public static Brush MistyRose { get; }
+        public static Brush Moccasin { get; }
+        public static Brush NavajoWhite { get; }
+        public static Brush Navy { get; }
+        public static Brush OldLace { get; }
+        public static Brush Olive { get; }
+        public static Brush OliveDrab { get; }
+        public static Brush Orange { get; }
+        public static Brush OrangeRed { get; }
+        public static Brush Orchid { get; }
+        public static Brush PaleGoldenrod { get; }
+        public static Brush PaleGreen { get; }
+        public static Brush PaleTurquoise { get; }
+        public static Brush PaleVioletRed { get; }
+        public static Brush PapayaWhip { get; }
+        public static Brush PeachPuff { get; }
+        public static Brush Peru { get; }
+        public static Brush Pink { get; }
+        public static Brush Plum { get; }
+        public static Brush PowderBlue { get; }
+        public static Brush Purple { get; }
+        public static Brush Red { get; }
+        public static Brush RosyBrown { get; }
+        public static Brush RoyalBlue { get; }
+        public static Brush SaddleBrown { get; }
+        public static Brush Salmon { get; }
+        public static Brush SandyBrown { get; }
+        public static Brush SeaGreen { get; }
+        public static Brush SeaShell { get; }
+        public static Brush Sienna { get; }
+        public static Brush Silver { get; }
+        public static Brush SkyBlue { get; }
+        public static Brush SlateBlue { get; }
+        public static Brush SlateGray { get; }
+        public static Brush Snow { get; }
+        public static Brush SpringGreen { get; }
+        public static Brush SteelBlue { get; }
+        public static Brush Tan { get; }
+        public static Brush Teal { get; }
+        public static Brush Thistle { get; }
+        public static Brush Tomato { get; }
+        public static Brush Transparent { get; }
+        public static Brush Turquoise { get; }
+        public static Brush Violet { get; }
+        public static Brush Wheat { get; }
+        public static Brush White { get; }
+        public static Brush WhiteSmoke { get; }
+        public static Brush Yellow { get; }
+        public static Brush YellowGreen { get; }
+    }
+    public sealed class BufferedGraphics : IDisposable {
+        public Graphics Graphics { get; }
+        public void Dispose();
+        ~BufferedGraphics();
+        public void Render();
+        public void Render(Graphics target);
+        public void Render(IntPtr targetDC);
+    }
+    public sealed class BufferedGraphicsContext : IDisposable {
+        public BufferedGraphicsContext();
+        public Size MaximumBuffer { get; set; }
+        public BufferedGraphics Allocate(Graphics targetGraphics, Rectangle targetRectangle);
+        public BufferedGraphics Allocate(IntPtr targetDC, Rectangle targetRectangle);
+        public void Dispose();
+        ~BufferedGraphicsContext();
+        public void Invalidate();
+    }
+    public sealed class BufferedGraphicsManager {
+        public static BufferedGraphicsContext Current { get; }
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct CharacterRange {
+        public CharacterRange(int First, int Length);
+        public int First { get; set; }
+        public int Length { get; set; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public static bool operator ==(CharacterRange cr1, CharacterRange cr2);
+        public static bool operator !=(CharacterRange cr1, CharacterRange cr2);
+    }
-    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
-    public struct Color {
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Size=1)]
+    public struct Color : IEquatable<Color> {
+        public bool IsKnownColor { get; }
+        public bool IsSystemColor { get; }
+        public bool Equals(Color other);
+        public static Color FromKnownColor(KnownColor color);
+        public KnownColor ToKnownColor();
     }
+    public class ColorConverter : TypeConverter {
+        public ColorConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+        public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context);
+        public override bool GetStandardValuesSupported(ITypeDescriptorContext context);
+    }
+    public sealed class ColorTranslator {
+        public static Color FromHtml(string htmlColor);
+        public static Color FromOle(int oleColor);
+        public static Color FromWin32(int win32Color);
+        public static string ToHtml(Color c);
+        public static int ToOle(Color c);
+        public static int ToWin32(Color c);
+    }
+    public enum ContentAlignment {
+        BottomCenter = 512,
+        BottomLeft = 256,
+        BottomRight = 1024,
+        MiddleCenter = 32,
+        MiddleLeft = 16,
+        MiddleRight = 64,
+        TopCenter = 2,
+        TopLeft = 1,
+        TopRight = 4,
+    }
+    public enum CopyPixelOperation {
+        Blackness = 66,
+        CaptureBlt = 1073741824,
+        DestinationInvert = 5570569,
+        MergeCopy = 12583114,
+        MergePaint = 12255782,
+        NoMirrorBitmap = -2147483648,
+        NotSourceCopy = 3342344,
+        NotSourceErase = 1114278,
+        PatCopy = 15728673,
+        PatInvert = 5898313,
+        PatPaint = 16452105,
+        SourceAnd = 8913094,
+        SourceCopy = 13369376,
+        SourceErase = 4457256,
+        SourceInvert = 6684742,
+        SourcePaint = 15597702,
+        Whiteness = 16711778,
+    }
+    public sealed class Font : MarshalByRefObject, ICloneable, IDisposable, ISerializable {
+        public Font(Font prototype, FontStyle newStyle);
+        public Font(FontFamily family, float emSize);
+        public Font(FontFamily family, float emSize, FontStyle style);
+        public Font(FontFamily family, float emSize, FontStyle style, GraphicsUnit unit);
+        public Font(FontFamily family, float emSize, FontStyle style, GraphicsUnit unit, byte gdiCharSet);
+        public Font(FontFamily family, float emSize, FontStyle style, GraphicsUnit unit, byte gdiCharSet, bool gdiVerticalFont);
+        public Font(FontFamily family, float emSize, GraphicsUnit unit);
+        public Font(string familyName, float emSize);
+        public Font(string familyName, float emSize, FontStyle style);
+        public Font(string familyName, float emSize, FontStyle style, GraphicsUnit unit);
+        public Font(string familyName, float emSize, FontStyle style, GraphicsUnit unit, byte gdiCharSet);
+        public Font(string familyName, float emSize, FontStyle style, GraphicsUnit unit, byte gdiCharSet, bool gdiVerticalFont);
+        public Font(string familyName, float emSize, GraphicsUnit unit);
+        public bool Bold { get; }
+        public FontFamily FontFamily { get; }
+        public byte GdiCharSet { get; }
+        public bool GdiVerticalFont { get; }
+        public int Height { get; }
+        public bool IsSystemFont { get; }
+        public bool Italic { get; }
+        public string Name { get; }
+        public string OriginalFontName { get; }
+        public float Size { get; }
+        public float SizeInPoints { get; }
+        public bool Strikeout { get; }
+        public FontStyle Style { get; }
+        public string SystemFontName { get; }
+        public bool Underline { get; }
+        public GraphicsUnit Unit { get; }
+        public object Clone();
+        public void Dispose();
+        public override bool Equals(object obj);
+        ~Font();
+        public static Font FromHdc(IntPtr hdc);
+        public static Font FromHfont(IntPtr hfont);
+        public static Font FromLogFont(object lf);
+        public static Font FromLogFont(object lf, IntPtr hdc);
+        public override int GetHashCode();
+        public float GetHeight();
+        public float GetHeight(Graphics graphics);
+        public float GetHeight(float dpi);
+        void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context);
+        public IntPtr ToHfont();
+        public void ToLogFont(object logFont);
+        public void ToLogFont(object logFont, Graphics graphics);
+        public override string ToString();
+    }
+    public sealed class FontFamily : MarshalByRefObject, IDisposable {
+        public FontFamily(GenericFontFamilies genericFamily);
+        public FontFamily(string name);
+        public FontFamily(string name, FontCollection fontCollection);
+        public static FontFamily[] Families { get; }
+        public static FontFamily GenericMonospace { get; }
+        public static FontFamily GenericSansSerif { get; }
+        public static FontFamily GenericSerif { get; }
+        public string Name { get; }
+        public void Dispose();
+        public override bool Equals(object obj);
+        ~FontFamily();
+        public int GetCellAscent(FontStyle style);
+        public int GetCellDescent(FontStyle style);
+        public int GetEmHeight(FontStyle style);
+        public static FontFamily[] GetFamilies(Graphics graphics);
+        public override int GetHashCode();
+        public int GetLineSpacing(FontStyle style);
+        public string GetName(int language);
+        public bool IsStyleAvailable(FontStyle style);
+        public override string ToString();
+    }
+    public enum FontStyle {
+        Bold = 1,
+        Italic = 2,
+        Regular = 0,
+        Strikeout = 8,
+        Underline = 4,
+    }
+    public sealed class Graphics : MarshalByRefObject, IDeviceContext, IDisposable {
+        public Region Clip { get; set; }
+        public RectangleF ClipBounds { get; }
+        public CompositingMode CompositingMode { get; set; }
+        public CompositingQuality CompositingQuality { get; set; }
+        public float DpiX { get; }
+        public float DpiY { get; }
+        public InterpolationMode InterpolationMode { get; set; }
+        public bool IsClipEmpty { get; }
+        public bool IsVisibleClipEmpty { get; }
+        public float PageScale { get; set; }
+        public GraphicsUnit PageUnit { get; set; }
+        public PixelOffsetMode PixelOffsetMode { get; set; }
+        public Point RenderingOrigin { get; set; }
+        public SmoothingMode SmoothingMode { get; set; }
+        public int TextContrast { get; set; }
+        public TextRenderingHint TextRenderingHint { get; set; }
+        public Matrix Transform { get; set; }
+        public RectangleF VisibleClipBounds { get; }
+        public void AddMetafileComment(byte[] data);
+        public GraphicsContainer BeginContainer();
+        public GraphicsContainer BeginContainer(Rectangle dstrect, Rectangle srcrect, GraphicsUnit unit);
+        public GraphicsContainer BeginContainer(RectangleF dstrect, RectangleF srcrect, GraphicsUnit unit);
+        public void Clear(Color color);
+        public void CopyFromScreen(Point upperLeftSource, Point upperLeftDestination, Size blockRegionSize);
+        public void CopyFromScreen(Point upperLeftSource, Point upperLeftDestination, Size blockRegionSize, CopyPixelOperation copyPixelOperation);
+        public void CopyFromScreen(int sourceX, int sourceY, int destinationX, int destinationY, Size blockRegionSize);
+        public void CopyFromScreen(int sourceX, int sourceY, int destinationX, int destinationY, Size blockRegionSize, CopyPixelOperation copyPixelOperation);
+        public void Dispose();
+        public void DrawArc(Pen pen, Rectangle rect, float startAngle, float sweepAngle);
+        public void DrawArc(Pen pen, RectangleF rect, float startAngle, float sweepAngle);
+        public void DrawArc(Pen pen, int x, int y, int width, int height, int startAngle, int sweepAngle);
+        public void DrawArc(Pen pen, float x, float y, float width, float height, float startAngle, float sweepAngle);
+        public void DrawBezier(Pen pen, Point pt1, Point pt2, Point pt3, Point pt4);
+        public void DrawBezier(Pen pen, PointF pt1, PointF pt2, PointF pt3, PointF pt4);
+        public void DrawBezier(Pen pen, float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4);
+        public void DrawBeziers(Pen pen, PointF[] points);
+        public void DrawBeziers(Pen pen, Point[] points);
+        public void DrawClosedCurve(Pen pen, PointF[] points);
+        public void DrawClosedCurve(Pen pen, PointF[] points, float tension, FillMode fillmode);
+        public void DrawClosedCurve(Pen pen, Point[] points);
+        public void DrawClosedCurve(Pen pen, Point[] points, float tension, FillMode fillmode);
+        public void DrawCurve(Pen pen, PointF[] points);
+        public void DrawCurve(Pen pen, PointF[] points, int offset, int numberOfSegments);
+        public void DrawCurve(Pen pen, PointF[] points, int offset, int numberOfSegments, float tension);
+        public void DrawCurve(Pen pen, PointF[] points, float tension);
+        public void DrawCurve(Pen pen, Point[] points);
+        public void DrawCurve(Pen pen, Point[] points, int offset, int numberOfSegments, float tension);
+        public void DrawCurve(Pen pen, Point[] points, float tension);
+        public void DrawEllipse(Pen pen, Rectangle rect);
+        public void DrawEllipse(Pen pen, RectangleF rect);
+        public void DrawEllipse(Pen pen, int x, int y, int width, int height);
+        public void DrawEllipse(Pen pen, float x, float y, float width, float height);
+        public void DrawIcon(Icon icon, Rectangle targetRect);
+        public void DrawIcon(Icon icon, int x, int y);
+        public void DrawIconUnstretched(Icon icon, Rectangle targetRect);
+        public void DrawImage(Image image, Point point);
+        public void DrawImage(Image image, PointF point);
+        public void DrawImage(Image image, PointF[] destPoints);
+        public void DrawImage(Image image, PointF[] destPoints, RectangleF srcRect, GraphicsUnit srcUnit);
+        public void DrawImage(Image image, PointF[] destPoints, RectangleF srcRect, GraphicsUnit srcUnit, ImageAttributes imageAttr);
+        public void DrawImage(Image image, PointF[] destPoints, RectangleF srcRect, GraphicsUnit srcUnit, ImageAttributes imageAttr, Graphics.DrawImageAbort callback);
+        public void DrawImage(Image image, PointF[] destPoints, RectangleF srcRect, GraphicsUnit srcUnit, ImageAttributes imageAttr, Graphics.DrawImageAbort callback, int callbackData);
+        public void DrawImage(Image image, Point[] destPoints);
+        public void DrawImage(Image image, Point[] destPoints, Rectangle srcRect, GraphicsUnit srcUnit);
+        public void DrawImage(Image image, Point[] destPoints, Rectangle srcRect, GraphicsUnit srcUnit, ImageAttributes imageAttr);
+        public void DrawImage(Image image, Point[] destPoints, Rectangle srcRect, GraphicsUnit srcUnit, ImageAttributes imageAttr, Graphics.DrawImageAbort callback);
+        public void DrawImage(Image image, Point[] destPoints, Rectangle srcRect, GraphicsUnit srcUnit, ImageAttributes imageAttr, Graphics.DrawImageAbort callback, int callbackData);
+        public void DrawImage(Image image, Rectangle rect);
+        public void DrawImage(Image image, Rectangle destRect, Rectangle srcRect, GraphicsUnit srcUnit);
+        public void DrawImage(Image image, Rectangle destRect, int srcX, int srcY, int srcWidth, int srcHeight, GraphicsUnit srcUnit);
+        public void DrawImage(Image image, Rectangle destRect, int srcX, int srcY, int srcWidth, int srcHeight, GraphicsUnit srcUnit, ImageAttributes imageAttr);
+        public void DrawImage(Image image, Rectangle destRect, int srcX, int srcY, int srcWidth, int srcHeight, GraphicsUnit srcUnit, ImageAttributes imageAttr, Graphics.DrawImageAbort callback);
+        public void DrawImage(Image image, Rectangle destRect, int srcX, int srcY, int srcWidth, int srcHeight, GraphicsUnit srcUnit, ImageAttributes imageAttrs, Graphics.DrawImageAbort callback, IntPtr callbackData);
+        public void DrawImage(Image image, Rectangle destRect, float srcX, float srcY, float srcWidth, float srcHeight, GraphicsUnit srcUnit);
+        public void DrawImage(Image image, Rectangle destRect, float srcX, float srcY, float srcWidth, float srcHeight, GraphicsUnit srcUnit, ImageAttributes imageAttrs);
+        public void DrawImage(Image image, Rectangle destRect, float srcX, float srcY, float srcWidth, float srcHeight, GraphicsUnit srcUnit, ImageAttributes imageAttrs, Graphics.DrawImageAbort callback);
+        public void DrawImage(Image image, Rectangle destRect, float srcX, float srcY, float srcWidth, float srcHeight, GraphicsUnit srcUnit, ImageAttributes imageAttrs, Graphics.DrawImageAbort callback, IntPtr callbackData);
+        public void DrawImage(Image image, RectangleF rect);
+        public void DrawImage(Image image, RectangleF destRect, RectangleF srcRect, GraphicsUnit srcUnit);
+        public void DrawImage(Image image, int x, int y);
+        public void DrawImage(Image image, int x, int y, Rectangle srcRect, GraphicsUnit srcUnit);
+        public void DrawImage(Image image, int x, int y, int width, int height);
+        public void DrawImage(Image image, float x, float y);
+        public void DrawImage(Image image, float x, float y, RectangleF srcRect, GraphicsUnit srcUnit);
+        public void DrawImage(Image image, float x, float y, float width, float height);
+        public void DrawImageUnscaled(Image image, Point point);
+        public void DrawImageUnscaled(Image image, Rectangle rect);
+        public void DrawImageUnscaled(Image image, int x, int y);
+        public void DrawImageUnscaled(Image image, int x, int y, int width, int height);
+        public void DrawImageUnscaledAndClipped(Image image, Rectangle rect);
+        public void DrawLine(Pen pen, Point pt1, Point pt2);
+        public void DrawLine(Pen pen, PointF pt1, PointF pt2);
+        public void DrawLine(Pen pen, int x1, int y1, int x2, int y2);
+        public void DrawLine(Pen pen, float x1, float y1, float x2, float y2);
+        public void DrawLines(Pen pen, PointF[] points);
+        public void DrawLines(Pen pen, Point[] points);
+        public void DrawPath(Pen pen, GraphicsPath path);
+        public void DrawPie(Pen pen, Rectangle rect, float startAngle, float sweepAngle);
+        public void DrawPie(Pen pen, RectangleF rect, float startAngle, float sweepAngle);
+        public void DrawPie(Pen pen, int x, int y, int width, int height, int startAngle, int sweepAngle);
+        public void DrawPie(Pen pen, float x, float y, float width, float height, float startAngle, float sweepAngle);
+        public void DrawPolygon(Pen pen, PointF[] points);
+        public void DrawPolygon(Pen pen, Point[] points);
+        public void DrawRectangle(Pen pen, Rectangle rect);
+        public void DrawRectangle(Pen pen, int x, int y, int width, int height);
+        public void DrawRectangle(Pen pen, float x, float y, float width, float height);
+        public void DrawRectangles(Pen pen, RectangleF[] rects);
+        public void DrawRectangles(Pen pen, Rectangle[] rects);
+        public void DrawString(string s, Font font, Brush brush, PointF point);
+        public void DrawString(string s, Font font, Brush brush, PointF point, StringFormat format);
+        public void DrawString(string s, Font font, Brush brush, RectangleF layoutRectangle);
+        public void DrawString(string s, Font font, Brush brush, RectangleF layoutRectangle, StringFormat format);
+        public void DrawString(string s, Font font, Brush brush, float x, float y);
+        public void DrawString(string s, Font font, Brush brush, float x, float y, StringFormat format);
+        public void EndContainer(GraphicsContainer container);
+        public void EnumerateMetafile(Metafile metafile, Point destPoint, Graphics.EnumerateMetafileProc callback);
+        public void EnumerateMetafile(Metafile metafile, Point destPoint, Graphics.EnumerateMetafileProc callback, IntPtr callbackData);
+        public void EnumerateMetafile(Metafile metafile, Point destPoint, Graphics.EnumerateMetafileProc callback, IntPtr callbackData, ImageAttributes imageAttr);
+        public void EnumerateMetafile(Metafile metafile, Point destPoint, Rectangle srcRect, GraphicsUnit srcUnit, Graphics.EnumerateMetafileProc callback);
+        public void EnumerateMetafile(Metafile metafile, Point destPoint, Rectangle srcRect, GraphicsUnit srcUnit, Graphics.EnumerateMetafileProc callback, IntPtr callbackData);
+        public void EnumerateMetafile(Metafile metafile, Point destPoint, Rectangle srcRect, GraphicsUnit unit, Graphics.EnumerateMetafileProc callback, IntPtr callbackData, ImageAttributes imageAttr);
+        public void EnumerateMetafile(Metafile metafile, PointF destPoint, Graphics.EnumerateMetafileProc callback);
+        public void EnumerateMetafile(Metafile metafile, PointF destPoint, Graphics.EnumerateMetafileProc callback, IntPtr callbackData);
+        public void EnumerateMetafile(Metafile metafile, PointF destPoint, Graphics.EnumerateMetafileProc callback, IntPtr callbackData, ImageAttributes imageAttr);
+        public void EnumerateMetafile(Metafile metafile, PointF destPoint, RectangleF srcRect, GraphicsUnit srcUnit, Graphics.EnumerateMetafileProc callback);
+        public void EnumerateMetafile(Metafile metafile, PointF destPoint, RectangleF srcRect, GraphicsUnit srcUnit, Graphics.EnumerateMetafileProc callback, IntPtr callbackData);
+        public void EnumerateMetafile(Metafile metafile, PointF destPoint, RectangleF srcRect, GraphicsUnit unit, Graphics.EnumerateMetafileProc callback, IntPtr callbackData, ImageAttributes imageAttr);
+        public void EnumerateMetafile(Metafile metafile, PointF[] destPoints, Graphics.EnumerateMetafileProc callback);
+        public void EnumerateMetafile(Metafile metafile, PointF[] destPoints, Graphics.EnumerateMetafileProc callback, IntPtr callbackData);
+        public void EnumerateMetafile(Metafile metafile, PointF[] destPoints, Graphics.EnumerateMetafileProc callback, IntPtr callbackData, ImageAttributes imageAttr);
+        public void EnumerateMetafile(Metafile metafile, PointF[] destPoints, RectangleF srcRect, GraphicsUnit srcUnit, Graphics.EnumerateMetafileProc callback);
+        public void EnumerateMetafile(Metafile metafile, PointF[] destPoints, RectangleF srcRect, GraphicsUnit srcUnit, Graphics.EnumerateMetafileProc callback, IntPtr callbackData);
+        public void EnumerateMetafile(Metafile metafile, PointF[] destPoints, RectangleF srcRect, GraphicsUnit unit, Graphics.EnumerateMetafileProc callback, IntPtr callbackData, ImageAttributes imageAttr);
+        public void EnumerateMetafile(Metafile metafile, Point[] destPoints, Graphics.EnumerateMetafileProc callback);
+        public void EnumerateMetafile(Metafile metafile, Point[] destPoints, Graphics.EnumerateMetafileProc callback, IntPtr callbackData);
+        public void EnumerateMetafile(Metafile metafile, Point[] destPoints, Graphics.EnumerateMetafileProc callback, IntPtr callbackData, ImageAttributes imageAttr);
+        public void EnumerateMetafile(Metafile metafile, Point[] destPoints, Rectangle srcRect, GraphicsUnit srcUnit, Graphics.EnumerateMetafileProc callback);
+        public void EnumerateMetafile(Metafile metafile, Point[] destPoints, Rectangle srcRect, GraphicsUnit srcUnit, Graphics.EnumerateMetafileProc callback, IntPtr callbackData);
+        public void EnumerateMetafile(Metafile metafile, Point[] destPoints, Rectangle srcRect, GraphicsUnit unit, Graphics.EnumerateMetafileProc callback, IntPtr callbackData, ImageAttributes imageAttr);
+        public void EnumerateMetafile(Metafile metafile, Rectangle destRect, Graphics.EnumerateMetafileProc callback);
+        public void EnumerateMetafile(Metafile metafile, Rectangle destRect, Graphics.EnumerateMetafileProc callback, IntPtr callbackData);
+        public void EnumerateMetafile(Metafile metafile, Rectangle destRect, Graphics.EnumerateMetafileProc callback, IntPtr callbackData, ImageAttributes imageAttr);
+        public void EnumerateMetafile(Metafile metafile, Rectangle destRect, Rectangle srcRect, GraphicsUnit srcUnit, Graphics.EnumerateMetafileProc callback);
+        public void EnumerateMetafile(Metafile metafile, Rectangle destRect, Rectangle srcRect, GraphicsUnit srcUnit, Graphics.EnumerateMetafileProc callback, IntPtr callbackData);
+        public void EnumerateMetafile(Metafile metafile, Rectangle destRect, Rectangle srcRect, GraphicsUnit unit, Graphics.EnumerateMetafileProc callback, IntPtr callbackData, ImageAttributes imageAttr);
+        public void EnumerateMetafile(Metafile metafile, RectangleF destRect, Graphics.EnumerateMetafileProc callback);
+        public void EnumerateMetafile(Metafile metafile, RectangleF destRect, Graphics.EnumerateMetafileProc callback, IntPtr callbackData);
+        public void EnumerateMetafile(Metafile metafile, RectangleF destRect, Graphics.EnumerateMetafileProc callback, IntPtr callbackData, ImageAttributes imageAttr);
+        public void EnumerateMetafile(Metafile metafile, RectangleF destRect, RectangleF srcRect, GraphicsUnit srcUnit, Graphics.EnumerateMetafileProc callback);
+        public void EnumerateMetafile(Metafile metafile, RectangleF destRect, RectangleF srcRect, GraphicsUnit srcUnit, Graphics.EnumerateMetafileProc callback, IntPtr callbackData);
+        public void EnumerateMetafile(Metafile metafile, RectangleF destRect, RectangleF srcRect, GraphicsUnit unit, Graphics.EnumerateMetafileProc callback, IntPtr callbackData, ImageAttributes imageAttr);
+        public void ExcludeClip(Rectangle rect);
+        public void ExcludeClip(Region region);
+        public void FillClosedCurve(Brush brush, PointF[] points);
+        public void FillClosedCurve(Brush brush, PointF[] points, FillMode fillmode);
+        public void FillClosedCurve(Brush brush, PointF[] points, FillMode fillmode, float tension);
+        public void FillClosedCurve(Brush brush, Point[] points);
+        public void FillClosedCurve(Brush brush, Point[] points, FillMode fillmode);
+        public void FillClosedCurve(Brush brush, Point[] points, FillMode fillmode, float tension);
+        public void FillEllipse(Brush brush, Rectangle rect);
+        public void FillEllipse(Brush brush, RectangleF rect);
+        public void FillEllipse(Brush brush, int x, int y, int width, int height);
+        public void FillEllipse(Brush brush, float x, float y, float width, float height);
+        public void FillPath(Brush brush, GraphicsPath path);
+        public void FillPie(Brush brush, Rectangle rect, float startAngle, float sweepAngle);
+        public void FillPie(Brush brush, int x, int y, int width, int height, int startAngle, int sweepAngle);
+        public void FillPie(Brush brush, float x, float y, float width, float height, float startAngle, float sweepAngle);
+        public void FillPolygon(Brush brush, PointF[] points);
+        public void FillPolygon(Brush brush, PointF[] points, FillMode fillMode);
+        public void FillPolygon(Brush brush, Point[] points);
+        public void FillPolygon(Brush brush, Point[] points, FillMode fillMode);
+        public void FillRectangle(Brush brush, Rectangle rect);
+        public void FillRectangle(Brush brush, RectangleF rect);
+        public void FillRectangle(Brush brush, int x, int y, int width, int height);
+        public void FillRectangle(Brush brush, float x, float y, float width, float height);
+        public void FillRectangles(Brush brush, RectangleF[] rects);
+        public void FillRectangles(Brush brush, Rectangle[] rects);
+        public void FillRegion(Brush brush, Region region);
+        ~Graphics();
+        public void Flush();
+        public void Flush(FlushIntention intention);
+        public static Graphics FromHdc(IntPtr hdc);
+        public static Graphics FromHdc(IntPtr hdc, IntPtr hdevice);
+        public static Graphics FromHdcInternal(IntPtr hdc);
+        public static Graphics FromHwnd(IntPtr hwnd);
+        public static Graphics FromHwndInternal(IntPtr hwnd);
+        public static Graphics FromImage(Image image);
+        public object GetContextInfo();
+        public static IntPtr GetHalftonePalette();
+        public IntPtr GetHdc();
+        public Color GetNearestColor(Color color);
+        public void IntersectClip(Rectangle rect);
+        public void IntersectClip(RectangleF rect);
+        public void IntersectClip(Region region);
+        public bool IsVisible(Point point);
+        public bool IsVisible(PointF point);
+        public bool IsVisible(Rectangle rect);
+        public bool IsVisible(RectangleF rect);
+        public bool IsVisible(int x, int y);
+        public bool IsVisible(int x, int y, int width, int height);
+        public bool IsVisible(float x, float y);
+        public bool IsVisible(float x, float y, float width, float height);
+        public Region[] MeasureCharacterRanges(string text, Font font, RectangleF layoutRect, StringFormat stringFormat);
+        public SizeF MeasureString(string text, Font font);
+        public SizeF MeasureString(string text, Font font, PointF origin, StringFormat stringFormat);
+        public SizeF MeasureString(string text, Font font, SizeF layoutArea);
+        public SizeF MeasureString(string text, Font font, SizeF layoutArea, StringFormat stringFormat);
+        public SizeF MeasureString(string text, Font font, SizeF layoutArea, StringFormat stringFormat, out int charactersFitted, out int linesFilled);
+        public SizeF MeasureString(string text, Font font, int width);
+        public SizeF MeasureString(string text, Font font, int width, StringFormat format);
+        public void MultiplyTransform(Matrix matrix);
+        public void MultiplyTransform(Matrix matrix, MatrixOrder order);
+        public void ReleaseHdc();
+        public void ReleaseHdc(IntPtr hdc);
+        public void ReleaseHdcInternal(IntPtr hdc);
+        public void ResetClip();
+        public void ResetTransform();
+        public void Restore(GraphicsState gstate);
+        public void RotateTransform(float angle);
+        public void RotateTransform(float angle, MatrixOrder order);
+        public GraphicsState Save();
+        public void ScaleTransform(float sx, float sy);
+        public void ScaleTransform(float sx, float sy, MatrixOrder order);
+        public void SetClip(GraphicsPath path);
+        public void SetClip(GraphicsPath path, CombineMode combineMode);
+        public void SetClip(Graphics g);
+        public void SetClip(Graphics g, CombineMode combineMode);
+        public void SetClip(Rectangle rect);
+        public void SetClip(Rectangle rect, CombineMode combineMode);
+        public void SetClip(RectangleF rect);
+        public void SetClip(RectangleF rect, CombineMode combineMode);
+        public void SetClip(Region region, CombineMode combineMode);
+        public void TransformPoints(CoordinateSpace destSpace, CoordinateSpace srcSpace, PointF[] pts);
+        public void TransformPoints(CoordinateSpace destSpace, CoordinateSpace srcSpace, Point[] pts);
+        public void TranslateClip(int dx, int dy);
+        public void TranslateClip(float dx, float dy);
+        public void TranslateTransform(float dx, float dy);
+        public void TranslateTransform(float dx, float dy, MatrixOrder order);
+        public delegate bool DrawImageAbort(IntPtr callbackdata);
+        public delegate bool EnumerateMetafileProc(EmfPlusRecordType recordType, int flags, int dataSize, IntPtr data, PlayRecordCallback callbackData);
+    }
+    public enum GraphicsUnit {
+        Display = 1,
+        Document = 5,
+        Inch = 4,
+        Millimeter = 6,
+        Pixel = 2,
+        Point = 3,
+        World = 0,
+    }
+    public sealed class Icon : MarshalByRefObject, ICloneable, IDisposable, ISerializable {
+        public Icon(Icon original, Size size);
+        public Icon(Icon original, int width, int height);
+        public Icon(Stream stream);
+        public Icon(Stream stream, Size size);
+        public Icon(Stream stream, int width, int height);
+        public Icon(string fileName);
+        public Icon(string fileName, Size size);
+        public Icon(string fileName, int width, int height);
+        public Icon(Type type, string resource);
+        public IntPtr Handle { get; }
+        public int Height { get; }
+        public Size Size { get; }
+        public int Width { get; }
+        public object Clone();
+        public void Dispose();
+        public static Icon ExtractAssociatedIcon(string filePath);
+        ~Icon();
+        public static Icon FromHandle(IntPtr handle);
+        public void Save(Stream outputStream);
+        void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context);
+        public Bitmap ToBitmap();
+        public override string ToString();
+    }
+    public interface IDeviceContext : IDisposable {
+        IntPtr GetHdc();
+        void ReleaseHdc();
+    }
+    public abstract class Image : MarshalByRefObject, ICloneable, IDisposable, ISerializable {
+        public int Flags { get; }
+        public Guid[] FrameDimensionsList { get; }
+        public int Height { get; }
+        public float HorizontalResolution { get; }
+        public ColorPalette Palette { get; set; }
+        public SizeF PhysicalDimension { get; }
+        public PixelFormat PixelFormat { get; }
+        public int[] PropertyIdList { get; }
+        public PropertyItem[] PropertyItems { get; }
+        public ImageFormat RawFormat { get; }
+        public Size Size { get; }
+        public object Tag { get; set; }
+        public float VerticalResolution { get; }
+        public int Width { get; }
+        public object Clone();
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        ~Image();
+        public static Image FromFile(string filename);
+        public static Image FromFile(string filename, bool useEmbeddedColorManagement);
+        public static Bitmap FromHbitmap(IntPtr hbitmap);
+        public static Bitmap FromHbitmap(IntPtr hbitmap, IntPtr hpalette);
+        public static Image FromStream(Stream stream);
+        public static Image FromStream(Stream stream, bool useEmbeddedColorManagement);
+        public static Image FromStream(Stream stream, bool useEmbeddedColorManagement, bool validateImageData);
+        public RectangleF GetBounds(ref GraphicsUnit pageUnit);
+        public EncoderParameters GetEncoderParameterList(Guid encoder);
+        public int GetFrameCount(FrameDimension dimension);
+        public static int GetPixelFormatSize(PixelFormat pixfmt);
+        public PropertyItem GetPropertyItem(int propid);
+        public Image GetThumbnailImage(int thumbWidth, int thumbHeight, Image.GetThumbnailImageAbort callback, IntPtr callbackData);
+        public static bool IsAlphaPixelFormat(PixelFormat pixfmt);
+        public static bool IsCanonicalPixelFormat(PixelFormat pixfmt);
+        public static bool IsExtendedPixelFormat(PixelFormat pixfmt);
+        public void RemovePropertyItem(int propid);
+        public void RotateFlip(RotateFlipType rotateFlipType);
+        public void Save(Stream stream, ImageCodecInfo encoder, EncoderParameters encoderParams);
+        public void Save(Stream stream, ImageFormat format);
+        public void Save(string filename);
+        public void Save(string filename, ImageCodecInfo encoder, EncoderParameters encoderParams);
+        public void Save(string filename, ImageFormat format);
+        public void SaveAdd(Image image, EncoderParameters encoderParams);
+        public void SaveAdd(EncoderParameters encoderParams);
+        public int SelectActiveFrame(FrameDimension dimension, int frameIndex);
+        public void SetPropertyItem(PropertyItem propitem);
+        void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context);
+        public delegate bool GetThumbnailImageAbort();
+    }
+    public sealed class ImageAnimator {
+        public static void Animate(Image image, EventHandler onFrameChangedHandler);
+        public static bool CanAnimate(Image image);
+        public static void StopAnimate(Image image, EventHandler onFrameChangedHandler);
+        public static void UpdateFrames();
+        public static void UpdateFrames(Image image);
+    }
+    public enum KnownColor {
+        ActiveBorder = 1,
+        ActiveCaption = 2,
+        ActiveCaptionText = 3,
+        AliceBlue = 28,
+        AntiqueWhite = 29,
+        AppWorkspace = 4,
+        Aqua = 30,
+        Aquamarine = 31,
+        Azure = 32,
+        Beige = 33,
+        Bisque = 34,
+        Black = 35,
+        BlanchedAlmond = 36,
+        Blue = 37,
+        BlueViolet = 38,
+        Brown = 39,
+        BurlyWood = 40,
+        ButtonFace = 168,
+        ButtonHighlight = 169,
+        ButtonShadow = 170,
+        CadetBlue = 41,
+        Chartreuse = 42,
+        Chocolate = 43,
+        Control = 5,
+        ControlDark = 6,
+        ControlDarkDark = 7,
+        ControlLight = 8,
+        ControlLightLight = 9,
+        ControlText = 10,
+        Coral = 44,
+        CornflowerBlue = 45,
+        Cornsilk = 46,
+        Crimson = 47,
+        Cyan = 48,
+        DarkBlue = 49,
+        DarkCyan = 50,
+        DarkGoldenrod = 51,
+        DarkGray = 52,
+        DarkGreen = 53,
+        DarkKhaki = 54,
+        DarkMagenta = 55,
+        DarkOliveGreen = 56,
+        DarkOrange = 57,
+        DarkOrchid = 58,
+        DarkRed = 59,
+        DarkSalmon = 60,
+        DarkSeaGreen = 61,
+        DarkSlateBlue = 62,
+        DarkSlateGray = 63,
+        DarkTurquoise = 64,
+        DarkViolet = 65,
+        DeepPink = 66,
+        DeepSkyBlue = 67,
+        Desktop = 11,
+        DimGray = 68,
+        DodgerBlue = 69,
+        Firebrick = 70,
+        FloralWhite = 71,
+        ForestGreen = 72,
+        Fuchsia = 73,
+        Gainsboro = 74,
+        GhostWhite = 75,
+        Gold = 76,
+        Goldenrod = 77,
+        GradientActiveCaption = 171,
+        GradientInactiveCaption = 172,
+        Gray = 78,
+        GrayText = 12,
+        Green = 79,
+        GreenYellow = 80,
+        Highlight = 13,
+        HighlightText = 14,
+        Honeydew = 81,
+        HotPink = 82,
+        HotTrack = 15,
+        InactiveBorder = 16,
+        InactiveCaption = 17,
+        InactiveCaptionText = 18,
+        IndianRed = 83,
+        Indigo = 84,
+        Info = 19,
+        InfoText = 20,
+        Ivory = 85,
+        Khaki = 86,
+        Lavender = 87,
+        LavenderBlush = 88,
+        LawnGreen = 89,
+        LemonChiffon = 90,
+        LightBlue = 91,
+        LightCoral = 92,
+        LightCyan = 93,
+        LightGoldenrodYellow = 94,
+        LightGray = 95,
+        LightGreen = 96,
+        LightPink = 97,
+        LightSalmon = 98,
+        LightSeaGreen = 99,
+        LightSkyBlue = 100,
+        LightSlateGray = 101,
+        LightSteelBlue = 102,
+        LightYellow = 103,
+        Lime = 104,
+        LimeGreen = 105,
+        Linen = 106,
+        Magenta = 107,
+        Maroon = 108,
+        MediumAquamarine = 109,
+        MediumBlue = 110,
+        MediumOrchid = 111,
+        MediumPurple = 112,
+        MediumSeaGreen = 113,
+        MediumSlateBlue = 114,
+        MediumSpringGreen = 115,
+        MediumTurquoise = 116,
+        MediumVioletRed = 117,
+        Menu = 21,
+        MenuBar = 173,
+        MenuHighlight = 174,
+        MenuText = 22,
+        MidnightBlue = 118,
+        MintCream = 119,
+        MistyRose = 120,
+        Moccasin = 121,
+        NavajoWhite = 122,
+        Navy = 123,
+        OldLace = 124,
+        Olive = 125,
+        OliveDrab = 126,
+        Orange = 127,
+        OrangeRed = 128,
+        Orchid = 129,
+        PaleGoldenrod = 130,
+        PaleGreen = 131,
+        PaleTurquoise = 132,
+        PaleVioletRed = 133,
+        PapayaWhip = 134,
+        PeachPuff = 135,
+        Peru = 136,
+        Pink = 137,
+        Plum = 138,
+        PowderBlue = 139,
+        Purple = 140,
+        Red = 141,
+        RosyBrown = 142,
+        RoyalBlue = 143,
+        SaddleBrown = 144,
+        Salmon = 145,
+        SandyBrown = 146,
+        ScrollBar = 23,
+        SeaGreen = 147,
+        SeaShell = 148,
+        Sienna = 149,
+        Silver = 150,
+        SkyBlue = 151,
+        SlateBlue = 152,
+        SlateGray = 153,
+        Snow = 154,
+        SpringGreen = 155,
+        SteelBlue = 156,
+        Tan = 157,
+        Teal = 158,
+        Thistle = 159,
+        Tomato = 160,
+        Transparent = 27,
+        Turquoise = 161,
+        Violet = 162,
+        Wheat = 163,
+        White = 164,
+        WhiteSmoke = 165,
+        Window = 24,
+        WindowFrame = 25,
+        WindowText = 26,
+        Yellow = 166,
+        YellowGreen = 167,
+    }
+    public sealed class Pen : MarshalByRefObject, ICloneable, IDisposable {
+        public Pen(Brush brush);
+        public Pen(Brush brush, float width);
+        public Pen(Color color);
+        public Pen(Color color, float width);
+        public PenAlignment Alignment { get; set; }
+        public Brush Brush { get; set; }
+        public Color Color { get; set; }
+        public float[] CompoundArray { get; set; }
+        public CustomLineCap CustomEndCap { get; set; }
+        public CustomLineCap CustomStartCap { get; set; }
+        public DashCap DashCap { get; set; }
+        public float DashOffset { get; set; }
+        public float[] DashPattern { get; set; }
+        public DashStyle DashStyle { get; set; }
+        public LineCap EndCap { get; set; }
+        public LineJoin LineJoin { get; set; }
+        public float MiterLimit { get; set; }
+        public PenType PenType { get; }
+        public LineCap StartCap { get; set; }
+        public Matrix Transform { get; set; }
+        public float Width { get; set; }
+        public object Clone();
+        public void Dispose();
+        ~Pen();
+        public void MultiplyTransform(Matrix matrix);
+        public void MultiplyTransform(Matrix matrix, MatrixOrder order);
+        public void ResetTransform();
+        public void RotateTransform(float angle);
+        public void RotateTransform(float angle, MatrixOrder order);
+        public void ScaleTransform(float sx, float sy);
+        public void ScaleTransform(float sx, float sy, MatrixOrder order);
+        public void SetLineCap(LineCap startCap, LineCap endCap, DashCap dashCap);
+        public void TranslateTransform(float dx, float dy);
+        public void TranslateTransform(float dx, float dy, MatrixOrder order);
+    }
+    public sealed class Pens {
+        public static Pen AliceBlue { get; }
+        public static Pen AntiqueWhite { get; }
+        public static Pen Aqua { get; }
+        public static Pen Aquamarine { get; }
+        public static Pen Azure { get; }
+        public static Pen Beige { get; }
+        public static Pen Bisque { get; }
+        public static Pen Black { get; }
+        public static Pen BlanchedAlmond { get; }
+        public static Pen Blue { get; }
+        public static Pen BlueViolet { get; }
+        public static Pen Brown { get; }
+        public static Pen BurlyWood { get; }
+        public static Pen CadetBlue { get; }
+        public static Pen Chartreuse { get; }
+        public static Pen Chocolate { get; }
+        public static Pen Coral { get; }
+        public static Pen CornflowerBlue { get; }
+        public static Pen Cornsilk { get; }
+        public static Pen Crimson { get; }
+        public static Pen Cyan { get; }
+        public static Pen DarkBlue { get; }
+        public static Pen DarkCyan { get; }
+        public static Pen DarkGoldenrod { get; }
+        public static Pen DarkGray { get; }
+        public static Pen DarkGreen { get; }
+        public static Pen DarkKhaki { get; }
+        public static Pen DarkMagenta { get; }
+        public static Pen DarkOliveGreen { get; }
+        public static Pen DarkOrange { get; }
+        public static Pen DarkOrchid { get; }
+        public static Pen DarkRed { get; }
+        public static Pen DarkSalmon { get; }
+        public static Pen DarkSeaGreen { get; }
+        public static Pen DarkSlateBlue { get; }
+        public static Pen DarkSlateGray { get; }
+        public static Pen DarkTurquoise { get; }
+        public static Pen DarkViolet { get; }
+        public static Pen DeepPink { get; }
+        public static Pen DeepSkyBlue { get; }
+        public static Pen DimGray { get; }
+        public static Pen DodgerBlue { get; }
+        public static Pen Firebrick { get; }
+        public static Pen FloralWhite { get; }
+        public static Pen ForestGreen { get; }
+        public static Pen Fuchsia { get; }
+        public static Pen Gainsboro { get; }
+        public static Pen GhostWhite { get; }
+        public static Pen Gold { get; }
+        public static Pen Goldenrod { get; }
+        public static Pen Gray { get; }
+        public static Pen Green { get; }
+        public static Pen GreenYellow { get; }
+        public static Pen Honeydew { get; }
+        public static Pen HotPink { get; }
+        public static Pen IndianRed { get; }
+        public static Pen Indigo { get; }
+        public static Pen Ivory { get; }
+        public static Pen Khaki { get; }
+        public static Pen Lavender { get; }
+        public static Pen LavenderBlush { get; }
+        public static Pen LawnGreen { get; }
+        public static Pen LemonChiffon { get; }
+        public static Pen LightBlue { get; }
+        public static Pen LightCoral { get; }
+        public static Pen LightCyan { get; }
+        public static Pen LightGoldenrodYellow { get; }
+        public static Pen LightGray { get; }
+        public static Pen LightGreen { get; }
+        public static Pen LightPink { get; }
+        public static Pen LightSalmon { get; }
+        public static Pen LightSeaGreen { get; }
+        public static Pen LightSkyBlue { get; }
+        public static Pen LightSlateGray { get; }
+        public static Pen LightSteelBlue { get; }
+        public static Pen LightYellow { get; }
+        public static Pen Lime { get; }
+        public static Pen LimeGreen { get; }
+        public static Pen Linen { get; }
+        public static Pen Magenta { get; }
+        public static Pen Maroon { get; }
+        public static Pen MediumAquamarine { get; }
+        public static Pen MediumBlue { get; }
+        public static Pen MediumOrchid { get; }
+        public static Pen MediumPurple { get; }
+        public static Pen MediumSeaGreen { get; }
+        public static Pen MediumSlateBlue { get; }
+        public static Pen MediumSpringGreen { get; }
+        public static Pen MediumTurquoise { get; }
+        public static Pen MediumVioletRed { get; }
+        public static Pen MidnightBlue { get; }
+        public static Pen MintCream { get; }
+        public static Pen MistyRose { get; }
+        public static Pen Moccasin { get; }
+        public static Pen NavajoWhite { get; }
+        public static Pen Navy { get; }
+        public static Pen OldLace { get; }
+        public static Pen Olive { get; }
+        public static Pen OliveDrab { get; }
+        public static Pen Orange { get; }
+        public static Pen OrangeRed { get; }
+        public static Pen Orchid { get; }
+        public static Pen PaleGoldenrod { get; }
+        public static Pen PaleGreen { get; }
+        public static Pen PaleTurquoise { get; }
+        public static Pen PaleVioletRed { get; }
+        public static Pen PapayaWhip { get; }
+        public static Pen PeachPuff { get; }
+        public static Pen Peru { get; }
+        public static Pen Pink { get; }
+        public static Pen Plum { get; }
+        public static Pen PowderBlue { get; }
+        public static Pen Purple { get; }
+        public static Pen Red { get; }
+        public static Pen RosyBrown { get; }
+        public static Pen RoyalBlue { get; }
+        public static Pen SaddleBrown { get; }
+        public static Pen Salmon { get; }
+        public static Pen SandyBrown { get; }
+        public static Pen SeaGreen { get; }
+        public static Pen SeaShell { get; }
+        public static Pen Sienna { get; }
+        public static Pen Silver { get; }
+        public static Pen SkyBlue { get; }
+        public static Pen SlateBlue { get; }
+        public static Pen SlateGray { get; }
+        public static Pen Snow { get; }
+        public static Pen SpringGreen { get; }
+        public static Pen SteelBlue { get; }
+        public static Pen Tan { get; }
+        public static Pen Teal { get; }
+        public static Pen Thistle { get; }
+        public static Pen Tomato { get; }
+        public static Pen Transparent { get; }
+        public static Pen Turquoise { get; }
+        public static Pen Violet { get; }
+        public static Pen Wheat { get; }
+        public static Pen White { get; }
+        public static Pen WhiteSmoke { get; }
+        public static Pen Yellow { get; }
+        public static Pen YellowGreen { get; }
+    }
-    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
-    public struct Point {
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Size=1)]
+    public struct Point : IEquatable<Point> {
+        public bool Equals(Point other);
     }
+    public class PointConverter : TypeConverter {
+        public PointConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+        public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues);
+        public override bool GetCreateInstanceSupported(ITypeDescriptorContext context);
+        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes);
+        public override bool GetPropertiesSupported(ITypeDescriptorContext context);
+    }
-    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
-    public struct PointF {
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Size=1)]
+    public struct PointF : IEquatable<PointF> {
+        public bool Equals(PointF other);
     }
-    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
-    public struct Rectangle {
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Size=1)]
+    public struct Rectangle : IEquatable<Rectangle> {
+        public bool Equals(Rectangle other);
     }
+    public class RectangleConverter : TypeConverter {
+        public RectangleConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+        public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues);
+        public override bool GetCreateInstanceSupported(ITypeDescriptorContext context);
+        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes);
+        public override bool GetPropertiesSupported(ITypeDescriptorContext context);
+    }
-    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
-    public struct RectangleF {
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Size=1)]
+    public struct RectangleF : IEquatable<RectangleF> {
+        public bool Equals(RectangleF other);
     }
+    public sealed class Region : MarshalByRefObject, IDisposable {
+        public Region();
+        public Region(GraphicsPath path);
+        public Region(RegionData rgnData);
+        public Region(Rectangle rect);
+        public Region(RectangleF rect);
+        public Region Clone();
+        public void Complement(GraphicsPath path);
+        public void Complement(Rectangle rect);
+        public void Complement(RectangleF rect);
+        public void Complement(Region region);
+        public void Dispose();
+        public bool Equals(Region region, Graphics g);
+        public void Exclude(GraphicsPath path);
+        public void Exclude(Rectangle rect);
+        public void Exclude(RectangleF rect);
+        public void Exclude(Region region);
+        ~Region();
+        public static Region FromHrgn(IntPtr hrgn);
+        public RectangleF GetBounds(Graphics g);
+        public IntPtr GetHrgn(Graphics g);
+        public RegionData GetRegionData();
+        public RectangleF[] GetRegionScans(Matrix matrix);
+        public void Intersect(GraphicsPath path);
+        public void Intersect(Rectangle rect);
+        public void Intersect(RectangleF rect);
+        public void Intersect(Region region);
+        public bool IsEmpty(Graphics g);
+        public bool IsInfinite(Graphics g);
+        public bool IsVisible(Point point);
+        public bool IsVisible(Point point, Graphics g);
+        public bool IsVisible(PointF point);
+        public bool IsVisible(PointF point, Graphics g);
+        public bool IsVisible(Rectangle rect);
+        public bool IsVisible(Rectangle rect, Graphics g);
+        public bool IsVisible(RectangleF rect);
+        public bool IsVisible(RectangleF rect, Graphics g);
+        public bool IsVisible(int x, int y, Graphics g);
+        public bool IsVisible(int x, int y, int width, int height);
+        public bool IsVisible(int x, int y, int width, int height, Graphics g);
+        public bool IsVisible(float x, float y);
+        public bool IsVisible(float x, float y, Graphics g);
+        public bool IsVisible(float x, float y, float width, float height);
+        public bool IsVisible(float x, float y, float width, float height, Graphics g);
+        public void MakeEmpty();
+        public void MakeInfinite();
+        public void ReleaseHrgn(IntPtr regionHandle);
+        public void Transform(Matrix matrix);
+        public void Translate(int dx, int dy);
+        public void Translate(float dx, float dy);
+        public void Union(GraphicsPath path);
+        public void Union(Rectangle rect);
+        public void Union(RectangleF rect);
+        public void Union(Region region);
+        public void Xor(GraphicsPath path);
+        public void Xor(Rectangle rect);
+        public void Xor(RectangleF rect);
+        public void Xor(Region region);
+    }
+    public enum RotateFlipType {
+        Rotate180FlipNone = 2,
+        Rotate180FlipX = 6,
+        Rotate180FlipXY = 0,
+        Rotate180FlipY = 4,
+        Rotate270FlipNone = 3,
+        Rotate270FlipX = 7,
+        Rotate270FlipXY = 1,
+        Rotate270FlipY = 5,
+        Rotate90FlipNone = 1,
+        Rotate90FlipX = 5,
+        Rotate90FlipXY = 3,
+        Rotate90FlipY = 7,
+        RotateNoneFlipNone = 0,
+        RotateNoneFlipX = 4,
+        RotateNoneFlipXY = 2,
+        RotateNoneFlipY = 6,
+    }
-    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
-    public struct Size {
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Size=1)]
+    public struct Size : IEquatable<Size> {
+        public bool Equals(Size other);
+        public static Size operator /(Size left, int right);
+        public static SizeF operator /(Size left, float right);
+        public static Size operator *(Size left, int right);
+        public static SizeF operator *(Size left, float right);
+        public static Size operator *(int left, Size right);
+        public static SizeF operator *(float left, Size right);
     }
+    public class SizeConverter : TypeConverter {
+        public SizeConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+        public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues);
+        public override bool GetCreateInstanceSupported(ITypeDescriptorContext context);
+        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes);
+        public override bool GetPropertiesSupported(ITypeDescriptorContext context);
+    }
-    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
-    public struct SizeF {
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Size=1)]
+    public struct SizeF : IEquatable<SizeF> {
+        public bool Equals(SizeF other);
+        public static SizeF operator /(SizeF left, float right);
+        public static SizeF operator *(SizeF left, float right);
+        public static SizeF operator *(float left, SizeF right);
     }
+    public class SizeFConverter : TypeConverter {
+        public SizeFConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+        public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues);
+        public override bool GetCreateInstanceSupported(ITypeDescriptorContext context);
+        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes);
+        public override bool GetPropertiesSupported(ITypeDescriptorContext context);
+    }
+    public sealed class SolidBrush : Brush {
+        public SolidBrush(Color color);
+        public Color Color { get; set; }
+        public override object Clone();
+        protected override void Dispose(bool disposing);
+    }
+    public enum StringAlignment {
+        Center = 1,
+        Far = 2,
+        Near = 0,
+    }
+    public enum StringDigitSubstitute {
+        National = 2,
+        None = 1,
+        Traditional = 3,
+        User = 0,
+    }
+    public sealed class StringFormat : MarshalByRefObject, ICloneable, IDisposable {
+        public StringFormat();
+        public StringFormat(StringFormat format);
+        public StringFormat(StringFormatFlags options);
+        public StringFormat(StringFormatFlags options, int language);
+        public StringAlignment Alignment { get; set; }
+        public int DigitSubstitutionLanguage { get; }
+        public StringDigitSubstitute DigitSubstitutionMethod { get; }
+        public StringFormatFlags FormatFlags { get; set; }
+        public static StringFormat GenericDefault { get; }
+        public static StringFormat GenericTypographic { get; }
+        public HotkeyPrefix HotkeyPrefix { get; set; }
+        public StringAlignment LineAlignment { get; set; }
+        public StringTrimming Trimming { get; set; }
+        public object Clone();
+        public void Dispose();
+        ~StringFormat();
+        public float[] GetTabStops(out float firstTabOffset);
+        public void SetDigitSubstitution(int language, StringDigitSubstitute substitute);
+        public void SetMeasurableCharacterRanges(CharacterRange[] ranges);
+        public void SetTabStops(float firstTabOffset, float[] tabStops);
+        public override string ToString();
+    }
+    public enum StringFormatFlags {
+        DirectionRightToLeft = 1,
+        DirectionVertical = 2,
+        DisplayFormatControl = 32,
+        FitBlackBox = 4,
+        LineLimit = 8192,
+        MeasureTrailingSpaces = 2048,
+        NoClip = 16384,
+        NoFontFallback = 1024,
+        NoWrap = 4096,
+    }
+    public enum StringTrimming {
+        Character = 1,
+        EllipsisCharacter = 3,
+        EllipsisPath = 5,
+        EllipsisWord = 4,
+        None = 0,
+        Word = 2,
+    }
+    public enum StringUnit {
+        Display = 1,
+        Document = 5,
+        Em = 32,
+        Inch = 4,
+        Millimeter = 6,
+        Pixel = 2,
+        Point = 3,
+        World = 0,
+    }
+    public sealed class SystemBrushes {
+        public static Brush ActiveBorder { get; }
+        public static Brush ActiveCaption { get; }
+        public static Brush ActiveCaptionText { get; }
+        public static Brush AppWorkspace { get; }
+        public static Brush ButtonFace { get; }
+        public static Brush ButtonHighlight { get; }
+        public static Brush ButtonShadow { get; }
+        public static Brush Control { get; }
+        public static Brush ControlDark { get; }
+        public static Brush ControlDarkDark { get; }
+        public static Brush ControlLight { get; }
+        public static Brush ControlLightLight { get; }
+        public static Brush ControlText { get; }
+        public static Brush Desktop { get; }
+        public static Brush GradientActiveCaption { get; }
+        public static Brush GradientInactiveCaption { get; }
+        public static Brush GrayText { get; }
+        public static Brush Highlight { get; }
+        public static Brush HighlightText { get; }
+        public static Brush HotTrack { get; }
+        public static Brush InactiveBorder { get; }
+        public static Brush InactiveCaption { get; }
+        public static Brush InactiveCaptionText { get; }
+        public static Brush Info { get; }
+        public static Brush InfoText { get; }
+        public static Brush Menu { get; }
+        public static Brush MenuBar { get; }
+        public static Brush MenuHighlight { get; }
+        public static Brush MenuText { get; }
+        public static Brush ScrollBar { get; }
+        public static Brush Window { get; }
+        public static Brush WindowFrame { get; }
+        public static Brush WindowText { get; }
+        public static Brush FromSystemColor(Color c);
+    }
+    public sealed class SystemColors {
+        public static Color ActiveBorder { get; }
+        public static Color ActiveCaption { get; }
+        public static Color ActiveCaptionText { get; }
+        public static Color AppWorkspace { get; }
+        public static Color ButtonFace { get; }
+        public static Color ButtonHighlight { get; }
+        public static Color ButtonShadow { get; }
+        public static Color Control { get; }
+        public static Color ControlDark { get; }
+        public static Color ControlDarkDark { get; }
+        public static Color ControlLight { get; }
+        public static Color ControlLightLight { get; }
+        public static Color ControlText { get; }
+        public static Color Desktop { get; }
+        public static Color GradientActiveCaption { get; }
+        public static Color GradientInactiveCaption { get; }
+        public static Color GrayText { get; }
+        public static Color Highlight { get; }
+        public static Color HighlightText { get; }
+        public static Color HotTrack { get; }
+        public static Color InactiveBorder { get; }
+        public static Color InactiveCaption { get; }
+        public static Color InactiveCaptionText { get; }
+        public static Color Info { get; }
+        public static Color InfoText { get; }
+        public static Color Menu { get; }
+        public static Color MenuBar { get; }
+        public static Color MenuHighlight { get; }
+        public static Color MenuText { get; }
+        public static Color ScrollBar { get; }
+        public static Color Window { get; }
+        public static Color WindowFrame { get; }
+        public static Color WindowText { get; }
+    }
+    public sealed class SystemFonts {
+        public static Font CaptionFont { get; }
+        public static Font DefaultFont { get; }
+        public static Font DialogFont { get; }
+        public static Font IconTitleFont { get; }
+        public static Font MenuFont { get; }
+        public static Font MessageBoxFont { get; }
+        public static Font SmallCaptionFont { get; }
+        public static Font StatusFont { get; }
+        public static Font GetFontByName(string systemFontName);
+    }
+    public sealed class SystemIcons {
+        public static Icon Application { get; }
+        public static Icon Asterisk { get; }
+        public static Icon Error { get; }
+        public static Icon Exclamation { get; }
+        public static Icon Hand { get; }
+        public static Icon Information { get; }
+        public static Icon Question { get; }
+        public static Icon Shield { get; }
+        public static Icon Warning { get; }
+        public static Icon WinLogo { get; }
+    }
+    public sealed class SystemPens {
+        public static Pen ActiveBorder { get; }
+        public static Pen ActiveCaption { get; }
+        public static Pen ActiveCaptionText { get; }
+        public static Pen AppWorkspace { get; }
+        public static Pen ButtonFace { get; }
+        public static Pen ButtonHighlight { get; }
+        public static Pen ButtonShadow { get; }
+        public static Pen Control { get; }
+        public static Pen ControlDark { get; }
+        public static Pen ControlDarkDark { get; }
+        public static Pen ControlLight { get; }
+        public static Pen ControlLightLight { get; }
+        public static Pen ControlText { get; }
+        public static Pen Desktop { get; }
+        public static Pen GradientActiveCaption { get; }
+        public static Pen GradientInactiveCaption { get; }
+        public static Pen GrayText { get; }
+        public static Pen Highlight { get; }
+        public static Pen HighlightText { get; }
+        public static Pen HotTrack { get; }
+        public static Pen InactiveBorder { get; }
+        public static Pen InactiveCaption { get; }
+        public static Pen InactiveCaptionText { get; }
+        public static Pen Info { get; }
+        public static Pen InfoText { get; }
+        public static Pen Menu { get; }
+        public static Pen MenuBar { get; }
+        public static Pen MenuHighlight { get; }
+        public static Pen MenuText { get; }
+        public static Pen ScrollBar { get; }
+        public static Pen Window { get; }
+        public static Pen WindowFrame { get; }
+        public static Pen WindowText { get; }
+        public static Pen FromSystemColor(Color c);
+    }
+    public sealed class TextureBrush : Brush {
+        public TextureBrush(Image bitmap);
+        public TextureBrush(Image image, WrapMode wrapMode);
+        public TextureBrush(Image image, WrapMode wrapMode, Rectangle dstRect);
+        public TextureBrush(Image image, WrapMode wrapMode, RectangleF dstRect);
+        public TextureBrush(Image image, Rectangle dstRect);
+        public TextureBrush(Image image, Rectangle dstRect, ImageAttributes imageAttr);
+        public TextureBrush(Image image, RectangleF dstRect);
+        public TextureBrush(Image image, RectangleF dstRect, ImageAttributes imageAttr);
+        public Image Image { get; }
+        public Matrix Transform { get; set; }
+        public WrapMode WrapMode { get; set; }
+        public override object Clone();
+        public void MultiplyTransform(Matrix matrix);
+        public void MultiplyTransform(Matrix matrix, MatrixOrder order);
+        public void ResetTransform();
+        public void RotateTransform(float angle);
+        public void RotateTransform(float angle, MatrixOrder order);
+        public void ScaleTransform(float sx, float sy);
+        public void ScaleTransform(float sx, float sy, MatrixOrder order);
+        public void TranslateTransform(float dx, float dy);
+        public void TranslateTransform(float dx, float dy, MatrixOrder order);
+    }
+    public class ToolboxBitmapAttribute : Attribute {
+        public static readonly ToolboxBitmapAttribute Default;
+        public ToolboxBitmapAttribute(string imageFile);
+        public ToolboxBitmapAttribute(Type t);
+        public ToolboxBitmapAttribute(Type t, string name);
+        public override bool Equals(object value);
+        public override int GetHashCode();
+        public Image GetImage(object component);
+        public Image GetImage(object component, bool large);
+        public Image GetImage(Type type);
+        public Image GetImage(Type type, bool large);
+        public Image GetImage(Type type, string imgName, bool large);
+        public static Image GetImageFromResource(Type t, string imageName, bool large);
+    }
 }
```

