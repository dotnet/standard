# System.Windows.Media

``` diff
+namespace System.Windows.Media {
+    public class AdornerHitTestResult : PointHitTestResult {
+        public Adorner Adorner { get; }
+    }
+    public enum AlignmentX {
+        Center = 1,
+        Left = 0,
+        Right = 2,
+    }
+    public enum AlignmentY {
+        Bottom = 2,
+        Center = 1,
+        Top = 0,
+    }
+    public sealed class ArcSegment : PathSegment {
+        public static readonly DependencyProperty IsLargeArcProperty;
+        public static readonly DependencyProperty PointProperty;
+        public static readonly DependencyProperty RotationAngleProperty;
+        public static readonly DependencyProperty SizeProperty;
+        public static readonly DependencyProperty SweepDirectionProperty;
+        public ArcSegment();
+        public ArcSegment(Point point, Size size, double rotationAngle, bool isLargeArc, SweepDirection sweepDirection, bool isStroked);
+        public bool IsLargeArc { get; set; }
+        public Point Point { get; set; }
+        public double RotationAngle { get; set; }
+        public Size Size { get; set; }
+        public SweepDirection SweepDirection { get; set; }
+        public new ArcSegment Clone();
+        public new ArcSegment CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public sealed class BezierSegment : PathSegment {
+        public static readonly DependencyProperty Point1Property;
+        public static readonly DependencyProperty Point2Property;
+        public static readonly DependencyProperty Point3Property;
+        public BezierSegment();
+        public BezierSegment(Point point1, Point point2, Point point3, bool isStroked);
+        public Point Point1 { get; set; }
+        public Point Point2 { get; set; }
+        public Point Point3 { get; set; }
+        public new BezierSegment Clone();
+        public new BezierSegment CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public sealed class BitmapCache : CacheMode {
+        public static readonly DependencyProperty EnableClearTypeProperty;
+        public static readonly DependencyProperty RenderAtScaleProperty;
+        public static readonly DependencyProperty SnapsToDevicePixelsProperty;
+        public BitmapCache();
+        public BitmapCache(double renderAtScale);
+        public bool EnableClearType { get; set; }
+        public double RenderAtScale { get; set; }
+        public bool SnapsToDevicePixels { get; set; }
+        public new BitmapCache Clone();
+        public new BitmapCache CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public sealed class BitmapCacheBrush : Brush, ICyclicBrush {
+        public static readonly DependencyProperty AutoLayoutContentProperty;
+        public static readonly DependencyProperty BitmapCacheProperty;
+        public static readonly DependencyProperty TargetProperty;
+        public BitmapCacheBrush();
+        public BitmapCacheBrush(Visual visual);
+        public bool AutoLayoutContent { get; set; }
+        public BitmapCache BitmapCache { get; set; }
+        public Visual Target { get; set; }
+        public new BitmapCacheBrush Clone();
+        public new BitmapCacheBrush CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e);
+    }
+    public enum BitmapScalingMode {
+        Fant = 2,
+        HighQuality = 2,
+        Linear = 1,
+        LowQuality = 1,
+        NearestNeighbor = 3,
+        Unspecified = 0,
+    }
+    public abstract class Brush : Animatable, DUCE.IResource, IFormattable {
+        public static readonly DependencyProperty OpacityProperty;
+        public static readonly DependencyProperty RelativeTransformProperty;
+        public static readonly DependencyProperty TransformProperty;
+        protected Brush();
+        public double Opacity { get; set; }
+        public Transform RelativeTransform { get; set; }
+        public Transform Transform { get; set; }
+        public new Brush Clone();
+        public new Brush CloneCurrentValue();
+        string System.IFormattable.ToString(string format, IFormatProvider provider);
+        public override string ToString();
+        public string ToString(IFormatProvider provider);
+    }
+    public sealed class BrushConverter : TypeConverter {
+        public BrushConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public sealed class Brushes {
+        public static SolidColorBrush AliceBlue { get; }
+        public static SolidColorBrush AntiqueWhite { get; }
+        public static SolidColorBrush Aqua { get; }
+        public static SolidColorBrush Aquamarine { get; }
+        public static SolidColorBrush Azure { get; }
+        public static SolidColorBrush Beige { get; }
+        public static SolidColorBrush Bisque { get; }
+        public static SolidColorBrush Black { get; }
+        public static SolidColorBrush BlanchedAlmond { get; }
+        public static SolidColorBrush Blue { get; }
+        public static SolidColorBrush BlueViolet { get; }
+        public static SolidColorBrush Brown { get; }
+        public static SolidColorBrush BurlyWood { get; }
+        public static SolidColorBrush CadetBlue { get; }
+        public static SolidColorBrush Chartreuse { get; }
+        public static SolidColorBrush Chocolate { get; }
+        public static SolidColorBrush Coral { get; }
+        public static SolidColorBrush CornflowerBlue { get; }
+        public static SolidColorBrush Cornsilk { get; }
+        public static SolidColorBrush Crimson { get; }
+        public static SolidColorBrush Cyan { get; }
+        public static SolidColorBrush DarkBlue { get; }
+        public static SolidColorBrush DarkCyan { get; }
+        public static SolidColorBrush DarkGoldenrod { get; }
+        public static SolidColorBrush DarkGray { get; }
+        public static SolidColorBrush DarkGreen { get; }
+        public static SolidColorBrush DarkKhaki { get; }
+        public static SolidColorBrush DarkMagenta { get; }
+        public static SolidColorBrush DarkOliveGreen { get; }
+        public static SolidColorBrush DarkOrange { get; }
+        public static SolidColorBrush DarkOrchid { get; }
+        public static SolidColorBrush DarkRed { get; }
+        public static SolidColorBrush DarkSalmon { get; }
+        public static SolidColorBrush DarkSeaGreen { get; }
+        public static SolidColorBrush DarkSlateBlue { get; }
+        public static SolidColorBrush DarkSlateGray { get; }
+        public static SolidColorBrush DarkTurquoise { get; }
+        public static SolidColorBrush DarkViolet { get; }
+        public static SolidColorBrush DeepPink { get; }
+        public static SolidColorBrush DeepSkyBlue { get; }
+        public static SolidColorBrush DimGray { get; }
+        public static SolidColorBrush DodgerBlue { get; }
+        public static SolidColorBrush Firebrick { get; }
+        public static SolidColorBrush FloralWhite { get; }
+        public static SolidColorBrush ForestGreen { get; }
+        public static SolidColorBrush Fuchsia { get; }
+        public static SolidColorBrush Gainsboro { get; }
+        public static SolidColorBrush GhostWhite { get; }
+        public static SolidColorBrush Gold { get; }
+        public static SolidColorBrush Goldenrod { get; }
+        public static SolidColorBrush Gray { get; }
+        public static SolidColorBrush Green { get; }
+        public static SolidColorBrush GreenYellow { get; }
+        public static SolidColorBrush Honeydew { get; }
+        public static SolidColorBrush HotPink { get; }
+        public static SolidColorBrush IndianRed { get; }
+        public static SolidColorBrush Indigo { get; }
+        public static SolidColorBrush Ivory { get; }
+        public static SolidColorBrush Khaki { get; }
+        public static SolidColorBrush Lavender { get; }
+        public static SolidColorBrush LavenderBlush { get; }
+        public static SolidColorBrush LawnGreen { get; }
+        public static SolidColorBrush LemonChiffon { get; }
+        public static SolidColorBrush LightBlue { get; }
+        public static SolidColorBrush LightCoral { get; }
+        public static SolidColorBrush LightCyan { get; }
+        public static SolidColorBrush LightGoldenrodYellow { get; }
+        public static SolidColorBrush LightGray { get; }
+        public static SolidColorBrush LightGreen { get; }
+        public static SolidColorBrush LightPink { get; }
+        public static SolidColorBrush LightSalmon { get; }
+        public static SolidColorBrush LightSeaGreen { get; }
+        public static SolidColorBrush LightSkyBlue { get; }
+        public static SolidColorBrush LightSlateGray { get; }
+        public static SolidColorBrush LightSteelBlue { get; }
+        public static SolidColorBrush LightYellow { get; }
+        public static SolidColorBrush Lime { get; }
+        public static SolidColorBrush LimeGreen { get; }
+        public static SolidColorBrush Linen { get; }
+        public static SolidColorBrush Magenta { get; }
+        public static SolidColorBrush Maroon { get; }
+        public static SolidColorBrush MediumAquamarine { get; }
+        public static SolidColorBrush MediumBlue { get; }
+        public static SolidColorBrush MediumOrchid { get; }
+        public static SolidColorBrush MediumPurple { get; }
+        public static SolidColorBrush MediumSeaGreen { get; }
+        public static SolidColorBrush MediumSlateBlue { get; }
+        public static SolidColorBrush MediumSpringGreen { get; }
+        public static SolidColorBrush MediumTurquoise { get; }
+        public static SolidColorBrush MediumVioletRed { get; }
+        public static SolidColorBrush MidnightBlue { get; }
+        public static SolidColorBrush MintCream { get; }
+        public static SolidColorBrush MistyRose { get; }
+        public static SolidColorBrush Moccasin { get; }
+        public static SolidColorBrush NavajoWhite { get; }
+        public static SolidColorBrush Navy { get; }
+        public static SolidColorBrush OldLace { get; }
+        public static SolidColorBrush Olive { get; }
+        public static SolidColorBrush OliveDrab { get; }
+        public static SolidColorBrush Orange { get; }
+        public static SolidColorBrush OrangeRed { get; }
+        public static SolidColorBrush Orchid { get; }
+        public static SolidColorBrush PaleGoldenrod { get; }
+        public static SolidColorBrush PaleGreen { get; }
+        public static SolidColorBrush PaleTurquoise { get; }
+        public static SolidColorBrush PaleVioletRed { get; }
+        public static SolidColorBrush PapayaWhip { get; }
+        public static SolidColorBrush PeachPuff { get; }
+        public static SolidColorBrush Peru { get; }
+        public static SolidColorBrush Pink { get; }
+        public static SolidColorBrush Plum { get; }
+        public static SolidColorBrush PowderBlue { get; }
+        public static SolidColorBrush Purple { get; }
+        public static SolidColorBrush Red { get; }
+        public static SolidColorBrush RosyBrown { get; }
+        public static SolidColorBrush RoyalBlue { get; }
+        public static SolidColorBrush SaddleBrown { get; }
+        public static SolidColorBrush Salmon { get; }
+        public static SolidColorBrush SandyBrown { get; }
+        public static SolidColorBrush SeaGreen { get; }
+        public static SolidColorBrush SeaShell { get; }
+        public static SolidColorBrush Sienna { get; }
+        public static SolidColorBrush Silver { get; }
+        public static SolidColorBrush SkyBlue { get; }
+        public static SolidColorBrush SlateBlue { get; }
+        public static SolidColorBrush SlateGray { get; }
+        public static SolidColorBrush Snow { get; }
+        public static SolidColorBrush SpringGreen { get; }
+        public static SolidColorBrush SteelBlue { get; }
+        public static SolidColorBrush Tan { get; }
+        public static SolidColorBrush Teal { get; }
+        public static SolidColorBrush Thistle { get; }
+        public static SolidColorBrush Tomato { get; }
+        public static SolidColorBrush Transparent { get; }
+        public static SolidColorBrush Turquoise { get; }
+        public static SolidColorBrush Violet { get; }
+        public static SolidColorBrush Wheat { get; }
+        public static SolidColorBrush White { get; }
+        public static SolidColorBrush WhiteSmoke { get; }
+        public static SolidColorBrush Yellow { get; }
+        public static SolidColorBrush YellowGreen { get; }
+    }
+    public enum BrushMappingMode {
+        Absolute = 0,
+        RelativeToBoundingBox = 1,
+    }
+    public abstract class CacheMode : Animatable, DUCE.IResource {
+        public new CacheMode Clone();
+        public new CacheMode CloneCurrentValue();
+    }
+    public sealed class CacheModeConverter : TypeConverter {
+        public CacheModeConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public enum CachingHint {
+        Cache = 1,
+        Unspecified = 0,
+    }
+    public class CharacterMetrics {
+        public CharacterMetrics();
+        public CharacterMetrics(string metrics);
+        public double Baseline { get; }
+        public double BlackBoxHeight { get; }
+        public double BlackBoxWidth { get; }
+        public double BottomSideBearing { get; }
+        public double LeftSideBearing { get; }
+        public string Metrics { get; set; }
+        public double RightSideBearing { get; }
+        public double TopSideBearing { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+    }
+    public sealed class CharacterMetricsDictionary : ICollection, ICollection<KeyValuePair<int, CharacterMetrics>>, IDictionary, IDictionary<int, CharacterMetrics>, IEnumerable, IEnumerable<KeyValuePair<int, CharacterMetrics>> {
+        public int Count { get; }
+        public bool IsReadOnly { get; }
+        public ICollection<int> Keys { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IDictionary.IsFixedSize { get; }
+        object System.Collections.IDictionary.this[object key] { get; set; }
+        ICollection System.Collections.IDictionary.Keys { get; }
+        ICollection System.Collections.IDictionary.Values { get; }
+        public CharacterMetrics this[int key] { get; set; }
+        public ICollection<CharacterMetrics> Values { get; }
+        public void Add(KeyValuePair<int, CharacterMetrics> item);
+        public void Add(int key, CharacterMetrics value);
+        public void Clear();
+        public bool Contains(KeyValuePair<int, CharacterMetrics> item);
+        public bool ContainsKey(int key);
+        public void CopyTo(KeyValuePair<int, CharacterMetrics>[] array, int index);
+        public IEnumerator<KeyValuePair<int, CharacterMetrics>> GetEnumerator();
+        public bool Remove(KeyValuePair<int, CharacterMetrics> item);
+        public bool Remove(int key);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        void System.Collections.IDictionary.Add(object key, object value);
+        bool System.Collections.IDictionary.Contains(object key);
+        IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator();
+        void System.Collections.IDictionary.Remove(object key);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        public bool TryGetValue(int key, out CharacterMetrics value);
+    }
+    public enum ClearTypeHint {
+        Auto = 0,
+        Enabled = 1,
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct Color : IEquatable<Color>, IFormattable {
+        public byte A { get; set; }
+        public byte B { get; set; }
+        public ColorContext ColorContext { get; }
+        public byte G { get; set; }
+        public byte R { get; set; }
+        public float ScA { get; set; }
+        public float ScB { get; set; }
+        public float ScG { get; set; }
+        public float ScR { get; set; }
+        public static Color Add(Color color1, Color color2);
+        public static bool AreClose(Color color1, Color color2);
+        public void Clamp();
+        public override bool Equals(object o);
+        public bool Equals(Color color);
+        public static bool Equals(Color color1, Color color2);
+        public static Color FromArgb(byte a, byte r, byte g, byte b);
+        public static Color FromAValues(float a, float[] values, Uri profileUri);
+        public static Color FromRgb(byte r, byte g, byte b);
+        public static Color FromScRgb(float a, float r, float g, float b);
+        public static Color FromValues(float[] values, Uri profileUri);
+        public override int GetHashCode();
+        public float[] GetNativeColorValues();
+        public static Color Multiply(Color color, float coefficient);
+        public static Color operator +(Color color1, Color color2);
+        public static bool operator ==(Color color1, Color color2);
+        public static bool operator !=(Color color1, Color color2);
+        public static Color operator *(Color color, float coefficient);
+        public static Color operator -(Color color1, Color color2);
+        public static Color Subtract(Color color1, Color color2);
+        string System.IFormattable.ToString(string format, IFormatProvider provider);
+        public override string ToString();
+        public string ToString(IFormatProvider provider);
+    }
+    public class ColorContext {
+        public ColorContext(Uri profileUri);
+        public ColorContext(PixelFormat pixelFormat);
+        public Uri ProfileUri { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public Stream OpenProfileStream();
+        public static bool operator ==(ColorContext context1, ColorContext context2);
+        public static bool operator !=(ColorContext context1, ColorContext context2);
+    }
+    public sealed class ColorConverter : TypeConverter {
+        public ColorConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext td, Type t);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext td, CultureInfo ci, object value);
+        public static new object ConvertFromString(string value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public enum ColorInterpolationMode {
+        ScRgbLinearInterpolation = 0,
+        SRgbLinearInterpolation = 1,
+    }
+    public sealed class Colors {
+        public static Color AliceBlue { get; }
+        public static Color AntiqueWhite { get; }
+        public static Color Aqua { get; }
+        public static Color Aquamarine { get; }
+        public static Color Azure { get; }
+        public static Color Beige { get; }
+        public static Color Bisque { get; }
+        public static Color Black { get; }
+        public static Color BlanchedAlmond { get; }
+        public static Color Blue { get; }
+        public static Color BlueViolet { get; }
+        public static Color Brown { get; }
+        public static Color BurlyWood { get; }
+        public static Color CadetBlue { get; }
+        public static Color Chartreuse { get; }
+        public static Color Chocolate { get; }
+        public static Color Coral { get; }
+        public static Color CornflowerBlue { get; }
+        public static Color Cornsilk { get; }
+        public static Color Crimson { get; }
+        public static Color Cyan { get; }
+        public static Color DarkBlue { get; }
+        public static Color DarkCyan { get; }
+        public static Color DarkGoldenrod { get; }
+        public static Color DarkGray { get; }
+        public static Color DarkGreen { get; }
+        public static Color DarkKhaki { get; }
+        public static Color DarkMagenta { get; }
+        public static Color DarkOliveGreen { get; }
+        public static Color DarkOrange { get; }
+        public static Color DarkOrchid { get; }
+        public static Color DarkRed { get; }
+        public static Color DarkSalmon { get; }
+        public static Color DarkSeaGreen { get; }
+        public static Color DarkSlateBlue { get; }
+        public static Color DarkSlateGray { get; }
+        public static Color DarkTurquoise { get; }
+        public static Color DarkViolet { get; }
+        public static Color DeepPink { get; }
+        public static Color DeepSkyBlue { get; }
+        public static Color DimGray { get; }
+        public static Color DodgerBlue { get; }
+        public static Color Firebrick { get; }
+        public static Color FloralWhite { get; }
+        public static Color ForestGreen { get; }
+        public static Color Fuchsia { get; }
+        public static Color Gainsboro { get; }
+        public static Color GhostWhite { get; }
+        public static Color Gold { get; }
+        public static Color Goldenrod { get; }
+        public static Color Gray { get; }
+        public static Color Green { get; }
+        public static Color GreenYellow { get; }
+        public static Color Honeydew { get; }
+        public static Color HotPink { get; }
+        public static Color IndianRed { get; }
+        public static Color Indigo { get; }
+        public static Color Ivory { get; }
+        public static Color Khaki { get; }
+        public static Color Lavender { get; }
+        public static Color LavenderBlush { get; }
+        public static Color LawnGreen { get; }
+        public static Color LemonChiffon { get; }
+        public static Color LightBlue { get; }
+        public static Color LightCoral { get; }
+        public static Color LightCyan { get; }
+        public static Color LightGoldenrodYellow { get; }
+        public static Color LightGray { get; }
+        public static Color LightGreen { get; }
+        public static Color LightPink { get; }
+        public static Color LightSalmon { get; }
+        public static Color LightSeaGreen { get; }
+        public static Color LightSkyBlue { get; }
+        public static Color LightSlateGray { get; }
+        public static Color LightSteelBlue { get; }
+        public static Color LightYellow { get; }
+        public static Color Lime { get; }
+        public static Color LimeGreen { get; }
+        public static Color Linen { get; }
+        public static Color Magenta { get; }
+        public static Color Maroon { get; }
+        public static Color MediumAquamarine { get; }
+        public static Color MediumBlue { get; }
+        public static Color MediumOrchid { get; }
+        public static Color MediumPurple { get; }
+        public static Color MediumSeaGreen { get; }
+        public static Color MediumSlateBlue { get; }
+        public static Color MediumSpringGreen { get; }
+        public static Color MediumTurquoise { get; }
+        public static Color MediumVioletRed { get; }
+        public static Color MidnightBlue { get; }
+        public static Color MintCream { get; }
+        public static Color MistyRose { get; }
+        public static Color Moccasin { get; }
+        public static Color NavajoWhite { get; }
+        public static Color Navy { get; }
+        public static Color OldLace { get; }
+        public static Color Olive { get; }
+        public static Color OliveDrab { get; }
+        public static Color Orange { get; }
+        public static Color OrangeRed { get; }
+        public static Color Orchid { get; }
+        public static Color PaleGoldenrod { get; }
+        public static Color PaleGreen { get; }
+        public static Color PaleTurquoise { get; }
+        public static Color PaleVioletRed { get; }
+        public static Color PapayaWhip { get; }
+        public static Color PeachPuff { get; }
+        public static Color Peru { get; }
+        public static Color Pink { get; }
+        public static Color Plum { get; }
+        public static Color PowderBlue { get; }
+        public static Color Purple { get; }
+        public static Color Red { get; }
+        public static Color RosyBrown { get; }
+        public static Color RoyalBlue { get; }
+        public static Color SaddleBrown { get; }
+        public static Color Salmon { get; }
+        public static Color SandyBrown { get; }
+        public static Color SeaGreen { get; }
+        public static Color SeaShell { get; }
+        public static Color Sienna { get; }
+        public static Color Silver { get; }
+        public static Color SkyBlue { get; }
+        public static Color SlateBlue { get; }
+        public static Color SlateGray { get; }
+        public static Color Snow { get; }
+        public static Color SpringGreen { get; }
+        public static Color SteelBlue { get; }
+        public static Color Tan { get; }
+        public static Color Teal { get; }
+        public static Color Thistle { get; }
+        public static Color Tomato { get; }
+        public static Color Transparent { get; }
+        public static Color Turquoise { get; }
+        public static Color Violet { get; }
+        public static Color Wheat { get; }
+        public static Color White { get; }
+        public static Color WhiteSmoke { get; }
+        public static Color Yellow { get; }
+        public static Color YellowGreen { get; }
+    }
+    public sealed class CombinedGeometry : Geometry {
+        public static readonly DependencyProperty Geometry1Property;
+        public static readonly DependencyProperty Geometry2Property;
+        public static readonly DependencyProperty GeometryCombineModeProperty;
+        public CombinedGeometry();
+        public CombinedGeometry(Geometry geometry1, Geometry geometry2);
+        public CombinedGeometry(GeometryCombineMode geometryCombineMode, Geometry geometry1, Geometry geometry2);
+        public CombinedGeometry(GeometryCombineMode geometryCombineMode, Geometry geometry1, Geometry geometry2, Transform transform);
+        public override Rect Bounds { get; }
+        public Geometry Geometry1 { get; set; }
+        public Geometry Geometry2 { get; set; }
+        public GeometryCombineMode GeometryCombineMode { get; set; }
+        public new CombinedGeometry Clone();
+        public new CombinedGeometry CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+        public override double GetArea(double tolerance, ToleranceType type);
+        public override bool IsEmpty();
+        public override bool MayHaveCurves();
+    }
+    public abstract class CompositionTarget : DispatcherObject, ICompositionTarget, IDisposable {
+        public virtual Visual RootVisual { get; set; }
+        public abstract Matrix TransformFromDevice { get; }
+        public abstract Matrix TransformToDevice { get; }
+        public static event EventHandler Rendering;
+        public virtual void Dispose();
+    }
+    public class ContainerVisual : Visual {
+        public ContainerVisual();
+        public BitmapEffect BitmapEffect { get; set; }
+        public BitmapEffectInput BitmapEffectInput { get; set; }
+        public CacheMode CacheMode { get; set; }
+        public VisualCollection Children { get; }
+        public Geometry Clip { get; set; }
+        public Rect ContentBounds { get; }
+        public Rect DescendantBounds { get; }
+        public Effect Effect { get; set; }
+        public Vector Offset { get; set; }
+        public double Opacity { get; set; }
+        public Brush OpacityMask { get; set; }
+        public DependencyObject Parent { get; }
+        public Transform Transform { get; set; }
+        protected sealed override int VisualChildrenCount { get; }
+        public DoubleCollection XSnappingGuidelines { get; set; }
+        public DoubleCollection YSnappingGuidelines { get; set; }
+        protected sealed override Visual GetVisualChild(int index);
+        public new void HitTest(HitTestFilterCallback filterCallback, HitTestResultCallback resultCallback, HitTestParameters hitTestParameters);
+        public new HitTestResult HitTest(Point point);
+    }
+    public sealed class DashStyle : Animatable, DUCE.IResource {
+        public static readonly DependencyProperty DashesProperty;
+        public static readonly DependencyProperty OffsetProperty;
+        public DashStyle();
+        public DashStyle(IEnumerable<double> dashes, double offset);
+        public DoubleCollection Dashes { get; set; }
+        public double Offset { get; set; }
+        public new DashStyle Clone();
+        public new DashStyle CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public static class DashStyles {
+        public static DashStyle Dash { get; }
+        public static DashStyle DashDot { get; }
+        public static DashStyle DashDotDot { get; }
+        public static DashStyle Dot { get; }
+        public static DashStyle Solid { get; }
+    }
+    public sealed class DisableDpiAwarenessAttribute : Attribute {
+        public DisableDpiAwarenessAttribute();
+    }
+    public sealed class DoubleCollection : Freezable, ICollection, ICollection<double>, IEnumerable, IEnumerable<double>, IFormattable, IList, IList<double> {
+        public DoubleCollection();
+        public DoubleCollection(IEnumerable<double> collection);
+        public DoubleCollection(int capacity);
+        public int Count { get; }
+        bool System.Collections.Generic.ICollection<System.Double>.IsReadOnly { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public double this[int index] { get; set; }
+        public void Add(double value);
+        public void Clear();
+        public new DoubleCollection Clone();
+        protected override void CloneCore(Freezable source);
+        public new DoubleCollection CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable source);
+        public bool Contains(double value);
+        public void CopyTo(double[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        public DoubleCollection.Enumerator GetEnumerator();
+        public int IndexOf(double value);
+        public void Insert(int index, double value);
+        public static DoubleCollection Parse(string source);
+        public bool Remove(double value);
+        public void RemoveAt(int index);
+        IEnumerator<double> System.Collections.Generic.IEnumerable<System.Double>.GetEnumerator();
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        string System.IFormattable.ToString(string format, IFormatProvider provider);
+        public override string ToString();
+        public string ToString(IFormatProvider provider);
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct Enumerator : IDisposable, IEnumerator, IEnumerator<double> {
+            public double Current { get; }
+            object System.Collections.IEnumerator.Current { get; }
+            public bool MoveNext();
+            public void Reset();
+            void System.IDisposable.Dispose();
+        }
+    }
+    public sealed class DoubleCollectionConverter : TypeConverter {
+        public DoubleCollectionConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public abstract class Drawing : Animatable, DUCE.IResource, IDrawingContent {
+        public Rect Bounds { get; }
+        public new Drawing Clone();
+        public new Drawing CloneCurrentValue();
+    }
+    public sealed class DrawingBrush : TileBrush {
+        public static readonly DependencyProperty DrawingProperty;
+        public DrawingBrush();
+        public DrawingBrush(Drawing drawing);
+        public Drawing Drawing { get; set; }
+        public new DrawingBrush Clone();
+        public new DrawingBrush CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+        protected override void GetContentBounds(out Rect contentBounds);
+    }
+    public sealed class DrawingCollection : Animatable, ICollection, ICollection<Drawing>, IEnumerable, IEnumerable<Drawing>, IList, IList<Drawing> {
+        public DrawingCollection();
+        public DrawingCollection(IEnumerable<Drawing> collection);
+        public DrawingCollection(int capacity);
+        public int Count { get; }
+        bool System.Collections.Generic.ICollection<System.Windows.Media.Drawing>.IsReadOnly { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public Drawing this[int index] { get; set; }
+        public void Add(Drawing value);
+        public void Clear();
+        public new DrawingCollection Clone();
+        protected override void CloneCore(Freezable source);
+        public new DrawingCollection CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable source);
+        public bool Contains(Drawing value);
+        public void CopyTo(Drawing[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        public DrawingCollection.Enumerator GetEnumerator();
+        public int IndexOf(Drawing value);
+        public void Insert(int index, Drawing value);
+        public bool Remove(Drawing value);
+        public void RemoveAt(int index);
+        IEnumerator<Drawing> System.Collections.Generic.IEnumerable<System.Windows.Media.Drawing>.GetEnumerator();
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct Enumerator : IDisposable, IEnumerator, IEnumerator<Drawing> {
+            public Drawing Current { get; }
+            object System.Collections.IEnumerator.Current { get; }
+            public bool MoveNext();
+            public void Reset();
+            void System.IDisposable.Dispose();
+        }
+    }
+    public abstract class DrawingContext : DispatcherObject, IDisposable {
+        public abstract void Close();
+        protected abstract void DisposeCore();
+        public abstract void DrawDrawing(Drawing drawing);
+        public abstract void DrawEllipse(Brush brush, Pen pen, Point center, double radiusX, double radiusY);
+        public abstract void DrawEllipse(Brush brush, Pen pen, Point center, AnimationClock centerAnimations, double radiusX, AnimationClock radiusXAnimations, double radiusY, AnimationClock radiusYAnimations);
+        public abstract void DrawGeometry(Brush brush, Pen pen, Geometry geometry);
+        public abstract void DrawGlyphRun(Brush foregroundBrush, GlyphRun glyphRun);
+        public abstract void DrawImage(ImageSource imageSource, Rect rectangle);
+        public abstract void DrawImage(ImageSource imageSource, Rect rectangle, AnimationClock rectangleAnimations);
+        public abstract void DrawLine(Pen pen, Point point0, AnimationClock point0Animations, Point point1, AnimationClock point1Animations);
+        public abstract void DrawLine(Pen pen, Point point0, Point point1);
+        public abstract void DrawRectangle(Brush brush, Pen pen, Rect rectangle);
+        public abstract void DrawRectangle(Brush brush, Pen pen, Rect rectangle, AnimationClock rectangleAnimations);
+        public abstract void DrawRoundedRectangle(Brush brush, Pen pen, Rect rectangle, double radiusX, double radiusY);
+        public abstract void DrawRoundedRectangle(Brush brush, Pen pen, Rect rectangle, AnimationClock rectangleAnimations, double radiusX, AnimationClock radiusXAnimations, double radiusY, AnimationClock radiusYAnimations);
+        public void DrawText(FormattedText formattedText, Point origin);
+        public abstract void DrawVideo(MediaPlayer player, Rect rectangle);
+        public abstract void DrawVideo(MediaPlayer player, Rect rectangle, AnimationClock rectangleAnimations);
+        public abstract void Pop();
+        public abstract void PushClip(Geometry clipGeometry);
+        public abstract void PushEffect(BitmapEffect effect, BitmapEffectInput effectInput);
+        public abstract void PushGuidelineSet(GuidelineSet guidelines);
+        public abstract void PushOpacity(double opacity);
+        public abstract void PushOpacity(double opacity, AnimationClock opacityAnimations);
+        public abstract void PushOpacityMask(Brush opacityMask);
+        public abstract void PushTransform(Transform transform);
+        void System.IDisposable.Dispose();
+        protected virtual void VerifyApiNonstructuralChange();
+    }
+    public sealed class DrawingGroup : Drawing {
+        public static readonly DependencyProperty BitmapEffectInputProperty;
+        public static readonly DependencyProperty BitmapEffectProperty;
+        public static readonly DependencyProperty ChildrenProperty;
+        public static readonly DependencyProperty ClipGeometryProperty;
+        public static readonly DependencyProperty GuidelineSetProperty;
+        public static readonly DependencyProperty OpacityMaskProperty;
+        public static readonly DependencyProperty OpacityProperty;
+        public static readonly DependencyProperty TransformProperty;
+        public DrawingGroup();
+        public BitmapEffect BitmapEffect { get; set; }
+        public BitmapEffectInput BitmapEffectInput { get; set; }
+        public DrawingCollection Children { get; set; }
+        public Geometry ClipGeometry { get; set; }
+        public GuidelineSet GuidelineSet { get; set; }
+        public double Opacity { get; set; }
+        public Brush OpacityMask { get; set; }
+        public Transform Transform { get; set; }
+        public DrawingContext Append();
+        public new DrawingGroup Clone();
+        public new DrawingGroup CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+        public DrawingContext Open();
+    }
+    public sealed class DrawingImage : ImageSource {
+        public static readonly DependencyProperty DrawingProperty;
+        public DrawingImage();
+        public DrawingImage(Drawing drawing);
+        public Drawing Drawing { get; set; }
+        public override double Height { get; }
+        public override ImageMetadata Metadata { get; }
+        public override double Width { get; }
+        public new DrawingImage Clone();
+        public new DrawingImage CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public class DrawingVisual : ContainerVisual {
+        public DrawingVisual();
+        public DrawingGroup Drawing { get; }
+        protected override GeometryHitTestResult HitTestCore(GeometryHitTestParameters hitTestParameters);
+        protected override HitTestResult HitTestCore(PointHitTestParameters hitTestParameters);
+        public DrawingContext RenderOpen();
+    }
+    public enum EdgeMode {
+        Aliased = 1,
+        Unspecified = 0,
+    }
+    public sealed class EllipseGeometry : Geometry {
+        public static readonly DependencyProperty CenterProperty;
+        public static readonly DependencyProperty RadiusXProperty;
+        public static readonly DependencyProperty RadiusYProperty;
+        public EllipseGeometry();
+        public EllipseGeometry(Point center, double radiusX, double radiusY);
+        public EllipseGeometry(Point center, double radiusX, double radiusY, Transform transform);
+        public EllipseGeometry(Rect rect);
+        public override Rect Bounds { get; }
+        public Point Center { get; set; }
+        public double RadiusX { get; set; }
+        public double RadiusY { get; set; }
+        public new EllipseGeometry Clone();
+        public new EllipseGeometry CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+        public override double GetArea(double tolerance, ToleranceType type);
+        public override bool IsEmpty();
+        public override bool MayHaveCurves();
+    }
+    public sealed class ExceptionEventArgs : EventArgs {
+        public Exception ErrorException { get; }
+    }
+    public class FamilyTypeface : IDeviceFont, ITypefaceMetrics {
+        public FamilyTypeface();
+        public IDictionary<XmlLanguage, string> AdjustedFaceNames { get; }
+        public double CapsHeight { get; set; }
+        public CharacterMetricsDictionary DeviceFontCharacterMetrics { get; }
+        public string DeviceFontName { get; set; }
+        public FontStretch Stretch { get; set; }
+        public double StrikethroughPosition { get; set; }
+        public double StrikethroughThickness { get; set; }
+        public FontStyle Style { get; set; }
+        public double UnderlinePosition { get; set; }
+        public double UnderlineThickness { get; set; }
+        public FontWeight Weight { get; set; }
+        public double XHeight { get; set; }
+        public override bool Equals(object o);
+        public bool Equals(FamilyTypeface typeface);
+        public override int GetHashCode();
+    }
+    public sealed class FamilyTypefaceCollection : ICollection, ICollection<FamilyTypeface>, IEnumerable, IEnumerable<FamilyTypeface>, IList, IList<FamilyTypeface> {
+        public int Count { get; }
+        public bool IsReadOnly { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public FamilyTypeface this[int index] { get; set; }
+        public void Add(FamilyTypeface item);
+        public void Clear();
+        public bool Contains(FamilyTypeface item);
+        public void CopyTo(FamilyTypeface[] array, int index);
+        public IEnumerator<FamilyTypeface> GetEnumerator();
+        public int IndexOf(FamilyTypeface item);
+        public void Insert(int index, FamilyTypeface item);
+        public bool Remove(FamilyTypeface item);
+        public void RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object item);
+        void System.Collections.IList.Remove(object value);
+    }
+    public enum FillRule {
+        EvenOdd = 0,
+        Nonzero = 1,
+    }
+    public class FontEmbeddingManager {
+        public FontEmbeddingManager();
+        public ICollection<Uri> GlyphTypefaceUris { get; }
+        public ICollection<ushort> GetUsedGlyphs(Uri glyphTypeface);
+        public void RecordUsage(GlyphRun glyphRun);
+    }
+    public enum FontEmbeddingRight {
+        Editable = 9,
+        EditableButNoSubsetting = 10,
+        EditableButNoSubsettingAndWithBitmapsOnly = 12,
+        EditableButWithBitmapsOnly = 11,
+        Installable = 0,
+        InstallableButNoSubsetting = 1,
+        InstallableButNoSubsettingAndWithBitmapsOnly = 3,
+        InstallableButWithBitmapsOnly = 2,
+        PreviewAndPrint = 5,
+        PreviewAndPrintButNoSubsetting = 6,
+        PreviewAndPrintButNoSubsettingAndWithBitmapsOnly = 8,
+        PreviewAndPrintButWithBitmapsOnly = 7,
+        RestrictedLicense = 4,
+    }
+    public class FontFamily {
+        public FontFamily();
+        public FontFamily(string familyName);
+        public FontFamily(Uri baseUri, string familyName);
+        public double Baseline { get; set; }
+        public Uri BaseUri { get; }
+        public FontFamilyMapCollection FamilyMaps { get; }
+        public LanguageSpecificStringDictionary FamilyNames { get; }
+        public FamilyTypefaceCollection FamilyTypefaces { get; }
+        public double LineSpacing { get; set; }
+        public string Source { get; }
+        public override bool Equals(object o);
+        public override int GetHashCode();
+        public ICollection<Typeface> GetTypefaces();
+        public override string ToString();
+    }
+    public class FontFamilyConverter : TypeConverter {
+        public FontFamilyConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext td, Type t);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo cultureInfo, object o);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public class FontFamilyMap {
+        public FontFamilyMap();
+        public XmlLanguage Language { get; set; }
+        public double Scale { get; set; }
+        public string Target { get; set; }
+        public string Unicode { get; set; }
+    }
+    public sealed class FontFamilyMapCollection : ICollection, ICollection<FontFamilyMap>, IEnumerable, IEnumerable<FontFamilyMap>, IList, IList<FontFamilyMap> {
+        public int Count { get; }
+        public bool IsReadOnly { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public FontFamilyMap this[int index] { get; set; }
+        public void Add(FontFamilyMap item);
+        public void Clear();
+        public bool Contains(FontFamilyMap item);
+        public void CopyTo(FontFamilyMap[] array, int index);
+        public IEnumerator<FontFamilyMap> GetEnumerator();
+        public int IndexOf(FontFamilyMap item);
+        public void Insert(int index, FontFamilyMap item);
+        public bool Remove(FontFamilyMap item);
+        public void RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object item);
+        void System.Collections.IList.Remove(object value);
+    }
+    public class FontFamilyValueSerializer : ValueSerializer {
+        public FontFamilyValueSerializer();
+        public override bool CanConvertFromString(string value, IValueSerializerContext context);
+        public override bool CanConvertToString(object value, IValueSerializerContext context);
+        public override object ConvertFromString(string value, IValueSerializerContext context);
+        public override string ConvertToString(object value, IValueSerializerContext context);
+    }
+    public static class Fonts {
+        public static ICollection<FontFamily> SystemFontFamilies { get; }
+        public static ICollection<Typeface> SystemTypefaces { get; }
+        public static ICollection<FontFamily> GetFontFamilies(string location);
+        public static ICollection<FontFamily> GetFontFamilies(Uri baseUri);
+        public static ICollection<FontFamily> GetFontFamilies(Uri baseUri, string location);
+        public static ICollection<Typeface> GetTypefaces(string location);
+        public static ICollection<Typeface> GetTypefaces(Uri baseUri);
+        public static ICollection<Typeface> GetTypefaces(Uri baseUri, string location);
+    }
+    public class FormattedText {
+        public FormattedText(string textToFormat, CultureInfo culture, FlowDirection flowDirection, Typeface typeface, double emSize, Brush foreground);
+        public FormattedText(string textToFormat, CultureInfo culture, FlowDirection flowDirection, Typeface typeface, double emSize, Brush foreground, NumberSubstitution numberSubstitution);
+        public FormattedText(string textToFormat, CultureInfo culture, FlowDirection flowDirection, Typeface typeface, double emSize, Brush foreground, NumberSubstitution numberSubstitution, TextFormattingMode textFormattingMode);
+        public double Baseline { get; }
+        public double Extent { get; }
+        public FlowDirection FlowDirection { get; set; }
+        public double Height { get; }
+        public double LineHeight { get; set; }
+        public int MaxLineCount { get; set; }
+        public double MaxTextHeight { get; set; }
+        public double MaxTextWidth { get; set; }
+        public double MinWidth { get; }
+        public double OverhangAfter { get; }
+        public double OverhangLeading { get; }
+        public double OverhangTrailing { get; }
+        public string Text { get; }
+        public TextAlignment TextAlignment { get; set; }
+        public TextTrimming Trimming { get; set; }
+        public double Width { get; }
+        public double WidthIncludingTrailingWhitespace { get; }
+        public Geometry BuildGeometry(Point origin);
+        public Geometry BuildHighlightGeometry(Point origin);
+        public Geometry BuildHighlightGeometry(Point origin, int startIndex, int count);
+        public double[] GetMaxTextWidths();
+        public void SetCulture(CultureInfo culture);
+        public void SetCulture(CultureInfo culture, int startIndex, int count);
+        public void SetFontFamily(string fontFamily);
+        public void SetFontFamily(string fontFamily, int startIndex, int count);
+        public void SetFontFamily(FontFamily fontFamily);
+        public void SetFontFamily(FontFamily fontFamily, int startIndex, int count);
+        public void SetFontSize(double emSize);
+        public void SetFontSize(double emSize, int startIndex, int count);
+        public void SetFontStretch(FontStretch stretch);
+        public void SetFontStretch(FontStretch stretch, int startIndex, int count);
+        public void SetFontStyle(FontStyle style);
+        public void SetFontStyle(FontStyle style, int startIndex, int count);
+        public void SetFontTypeface(Typeface typeface);
+        public void SetFontTypeface(Typeface typeface, int startIndex, int count);
+        public void SetFontWeight(FontWeight weight);
+        public void SetFontWeight(FontWeight weight, int startIndex, int count);
+        public void SetForegroundBrush(Brush foregroundBrush);
+        public void SetForegroundBrush(Brush foregroundBrush, int startIndex, int count);
+        public void SetMaxTextWidths(double[] maxTextWidths);
+        public void SetNumberSubstitution(NumberSubstitution numberSubstitution);
+        public void SetNumberSubstitution(NumberSubstitution numberSubstitution, int startIndex, int count);
+        public void SetTextDecorations(TextDecorationCollection textDecorations);
+        public void SetTextDecorations(TextDecorationCollection textDecorations, int startIndex, int count);
+    }
+    public abstract class GeneralTransform : Animatable, IFormattable {
+        protected GeneralTransform();
+        public abstract GeneralTransform Inverse { get; }
+        public new GeneralTransform Clone();
+        public new GeneralTransform CloneCurrentValue();
+        string System.IFormattable.ToString(string format, IFormatProvider provider);
+        public override string ToString();
+        public string ToString(IFormatProvider provider);
+        public Point Transform(Point point);
+        public abstract Rect TransformBounds(Rect rect);
+        public abstract bool TryTransform(Point inPoint, out Point result);
+    }
+    public sealed class GeneralTransformCollection : Animatable, ICollection, ICollection<GeneralTransform>, IEnumerable, IEnumerable<GeneralTransform>, IList, IList<GeneralTransform> {
+        public GeneralTransformCollection();
+        public GeneralTransformCollection(IEnumerable<GeneralTransform> collection);
+        public GeneralTransformCollection(int capacity);
+        public int Count { get; }
+        bool System.Collections.Generic.ICollection<System.Windows.Media.GeneralTransform>.IsReadOnly { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public GeneralTransform this[int index] { get; set; }
+        public void Add(GeneralTransform value);
+        public void Clear();
+        public new GeneralTransformCollection Clone();
+        protected override void CloneCore(Freezable source);
+        public new GeneralTransformCollection CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable source);
+        public bool Contains(GeneralTransform value);
+        public void CopyTo(GeneralTransform[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        public GeneralTransformCollection.Enumerator GetEnumerator();
+        public int IndexOf(GeneralTransform value);
+        public void Insert(int index, GeneralTransform value);
+        public bool Remove(GeneralTransform value);
+        public void RemoveAt(int index);
+        IEnumerator<GeneralTransform> System.Collections.Generic.IEnumerable<System.Windows.Media.GeneralTransform>.GetEnumerator();
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct Enumerator : IDisposable, IEnumerator, IEnumerator<GeneralTransform> {
+            public GeneralTransform Current { get; }
+            object System.Collections.IEnumerator.Current { get; }
+            public bool MoveNext();
+            public void Reset();
+            void System.IDisposable.Dispose();
+        }
+    }
+    public sealed class GeneralTransformGroup : GeneralTransform {
+        public static readonly DependencyProperty ChildrenProperty;
+        public GeneralTransformGroup();
+        public GeneralTransformCollection Children { get; set; }
+        public override GeneralTransform Inverse { get; }
+        public new GeneralTransformGroup Clone();
+        public new GeneralTransformGroup CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+        public override Rect TransformBounds(Rect rect);
+        public override bool TryTransform(Point inPoint, out Point result);
+    }
+    public abstract class Geometry : Animatable, DUCE.IResource, IFormattable {
+        public static readonly DependencyProperty TransformProperty;
+        public virtual Rect Bounds { get; }
+        public static Geometry Empty { get; }
+        public static double StandardFlatteningTolerance { get; }
+        public Transform Transform { get; set; }
+        public new Geometry Clone();
+        public new Geometry CloneCurrentValue();
+        public static PathGeometry Combine(Geometry geometry1, Geometry geometry2, GeometryCombineMode mode, Transform transform);
+        public static PathGeometry Combine(Geometry geometry1, Geometry geometry2, GeometryCombineMode mode, Transform transform, double tolerance, ToleranceType type);
+        public bool FillContains(Geometry geometry);
+        public bool FillContains(Geometry geometry, double tolerance, ToleranceType type);
+        public bool FillContains(Point hitPoint);
+        public bool FillContains(Point hitPoint, double tolerance, ToleranceType type);
+        public IntersectionDetail FillContainsWithDetail(Geometry geometry);
+        public virtual IntersectionDetail FillContainsWithDetail(Geometry geometry, double tolerance, ToleranceType type);
+        public double GetArea();
+        public virtual double GetArea(double tolerance, ToleranceType type);
+        public PathGeometry GetFlattenedPathGeometry();
+        public virtual PathGeometry GetFlattenedPathGeometry(double tolerance, ToleranceType type);
+        public PathGeometry GetOutlinedPathGeometry();
+        public virtual PathGeometry GetOutlinedPathGeometry(double tolerance, ToleranceType type);
+        public Rect GetRenderBounds(Pen pen);
+        public virtual Rect GetRenderBounds(Pen pen, double tolerance, ToleranceType type);
+        public PathGeometry GetWidenedPathGeometry(Pen pen);
+        public virtual PathGeometry GetWidenedPathGeometry(Pen pen, double tolerance, ToleranceType type);
+        public abstract bool IsEmpty();
+        public abstract bool MayHaveCurves();
+        public static Geometry Parse(string source);
+        public bool ShouldSerializeTransform();
+        public bool StrokeContains(Pen pen, Point hitPoint);
+        public bool StrokeContains(Pen pen, Point hitPoint, double tolerance, ToleranceType type);
+        public IntersectionDetail StrokeContainsWithDetail(Pen pen, Geometry geometry);
+        public IntersectionDetail StrokeContainsWithDetail(Pen pen, Geometry geometry, double tolerance, ToleranceType type);
+        string System.IFormattable.ToString(string format, IFormatProvider provider);
+        public override string ToString();
+        public string ToString(IFormatProvider provider);
+    }
+    public sealed class GeometryCollection : Animatable, ICollection, ICollection<Geometry>, IEnumerable, IEnumerable<Geometry>, IList, IList<Geometry> {
+        public GeometryCollection();
+        public GeometryCollection(IEnumerable<Geometry> collection);
+        public GeometryCollection(int capacity);
+        public int Count { get; }
+        bool System.Collections.Generic.ICollection<System.Windows.Media.Geometry>.IsReadOnly { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public Geometry this[int index] { get; set; }
+        public void Add(Geometry value);
+        public void Clear();
+        public new GeometryCollection Clone();
+        protected override void CloneCore(Freezable source);
+        public new GeometryCollection CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable source);
+        public bool Contains(Geometry value);
+        public void CopyTo(Geometry[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        public GeometryCollection.Enumerator GetEnumerator();
+        public int IndexOf(Geometry value);
+        public void Insert(int index, Geometry value);
+        public bool Remove(Geometry value);
+        public void RemoveAt(int index);
+        IEnumerator<Geometry> System.Collections.Generic.IEnumerable<System.Windows.Media.Geometry>.GetEnumerator();
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct Enumerator : IDisposable, IEnumerator, IEnumerator<Geometry> {
+            public Geometry Current { get; }
+            object System.Collections.IEnumerator.Current { get; }
+            public bool MoveNext();
+            public void Reset();
+            void System.IDisposable.Dispose();
+        }
+    }
+    public enum GeometryCombineMode {
+        Exclude = 3,
+        Intersect = 1,
+        Union = 0,
+        Xor = 2,
+    }
+    public sealed class GeometryConverter : TypeConverter {
+        public GeometryConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public sealed class GeometryDrawing : Drawing {
+        public static readonly DependencyProperty BrushProperty;
+        public static readonly DependencyProperty GeometryProperty;
+        public static readonly DependencyProperty PenProperty;
+        public GeometryDrawing();
+        public GeometryDrawing(Brush brush, Pen pen, Geometry geometry);
+        public Brush Brush { get; set; }
+        public Geometry Geometry { get; set; }
+        public Pen Pen { get; set; }
+        public new GeometryDrawing Clone();
+        public new GeometryDrawing CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public sealed class GeometryGroup : Geometry {
+        public static readonly DependencyProperty ChildrenProperty;
+        public static readonly DependencyProperty FillRuleProperty;
+        public GeometryGroup();
+        public GeometryCollection Children { get; set; }
+        public FillRule FillRule { get; set; }
+        public new GeometryGroup Clone();
+        public new GeometryGroup CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+        public override bool IsEmpty();
+        public override bool MayHaveCurves();
+    }
+    public class GeometryHitTestParameters : HitTestParameters {
+        public GeometryHitTestParameters(Geometry geometry);
+        public Geometry HitGeometry { get; }
+    }
+    public class GeometryHitTestResult : HitTestResult {
+        public GeometryHitTestResult(Visual visualHit, IntersectionDetail intersectionDetail);
+        public IntersectionDetail IntersectionDetail { get; }
+        public new Visual VisualHit { get; }
+    }
+    public class GlyphRun : DUCE.IResource, ISupportInitialize {
+        public GlyphRun();
+        public GlyphRun(GlyphTypeface glyphTypeface, int bidiLevel, bool isSideways, double renderingEmSize, IList<ushort> glyphIndices, Point baselineOrigin, IList<double> advanceWidths, IList<Point> glyphOffsets, IList<char> characters, string deviceFontName, IList<ushort> clusterMap, IList<bool> caretStops, XmlLanguage language);
+        public IList<double> AdvanceWidths { get; set; }
+        public Point BaselineOrigin { get; set; }
+        public int BidiLevel { get; set; }
+        public IList<bool> CaretStops { get; set; }
+        public IList<char> Characters { get; set; }
+        public IList<ushort> ClusterMap { get; set; }
+        public string DeviceFontName { get; set; }
+        public double FontRenderingEmSize { get; set; }
+        public IList<ushort> GlyphIndices { get; set; }
+        public IList<Point> GlyphOffsets { get; set; }
+        public GlyphTypeface GlyphTypeface { get; set; }
+        public bool IsHitTestable { get; }
+        public bool IsSideways { get; set; }
+        public XmlLanguage Language { get; set; }
+        public Geometry BuildGeometry();
+        public Rect ComputeAlignmentBox();
+        public Rect ComputeInkBoundingBox();
+        public CharacterHit GetCaretCharacterHitFromDistance(double distance, out bool isInside);
+        public double GetDistanceFromCaretCharacterHit(CharacterHit characterHit);
+        public CharacterHit GetNextCaretCharacterHit(CharacterHit characterHit);
+        public CharacterHit GetPreviousCaretCharacterHit(CharacterHit characterHit);
+        void System.ComponentModel.ISupportInitialize.BeginInit();
+        void System.ComponentModel.ISupportInitialize.EndInit();
+    }
+    public sealed class GlyphRunDrawing : Drawing {
+        public static readonly DependencyProperty ForegroundBrushProperty;
+        public static readonly DependencyProperty GlyphRunProperty;
+        public GlyphRunDrawing();
+        public GlyphRunDrawing(Brush foregroundBrush, GlyphRun glyphRun);
+        public Brush ForegroundBrush { get; set; }
+        public GlyphRun GlyphRun { get; set; }
+        public new GlyphRunDrawing Clone();
+        public new GlyphRunDrawing CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public class GlyphTypeface : ISupportInitialize, ITypefaceMetrics {
+        public GlyphTypeface();
+        public GlyphTypeface(Uri typefaceSource);
+        public GlyphTypeface(Uri typefaceSource, StyleSimulations styleSimulations);
+        public IDictionary<ushort, double> AdvanceHeights { get; }
+        public IDictionary<ushort, double> AdvanceWidths { get; }
+        public double Baseline { get; }
+        public IDictionary<ushort, double> BottomSideBearings { get; }
+        public double CapsHeight { get; }
+        public IDictionary<int, ushort> CharacterToGlyphMap { get; }
+        public IDictionary<CultureInfo, string> Copyrights { get; }
+        public IDictionary<CultureInfo, string> Descriptions { get; }
+        public IDictionary<CultureInfo, string> DesignerNames { get; }
+        public IDictionary<CultureInfo, string> DesignerUrls { get; }
+        public IDictionary<ushort, double> DistancesFromHorizontalBaselineToBlackBoxBottom { get; }
+        public FontEmbeddingRight EmbeddingRights { get; }
+        public IDictionary<CultureInfo, string> FaceNames { get; }
+        public IDictionary<CultureInfo, string> FamilyNames { get; }
+        public Uri FontUri { get; set; }
+        public int GlyphCount { get; }
+        public double Height { get; }
+        public IDictionary<ushort, double> LeftSideBearings { get; }
+        public IDictionary<CultureInfo, string> LicenseDescriptions { get; }
+        public IDictionary<CultureInfo, string> ManufacturerNames { get; }
+        public IDictionary<ushort, double> RightSideBearings { get; }
+        public IDictionary<CultureInfo, string> SampleTexts { get; }
+        public FontStretch Stretch { get; }
+        public double StrikethroughPosition { get; }
+        public double StrikethroughThickness { get; }
+        public FontStyle Style { get; }
+        public StyleSimulations StyleSimulations { get; set; }
+        public bool Symbol { get; }
+        public IDictionary<ushort, double> TopSideBearings { get; }
+        public IDictionary<CultureInfo, string> Trademarks { get; }
+        public double UnderlinePosition { get; }
+        public double UnderlineThickness { get; }
+        public IDictionary<CultureInfo, string> VendorUrls { get; }
+        public double Version { get; }
+        public IDictionary<CultureInfo, string> VersionStrings { get; }
+        public FontWeight Weight { get; }
+        public IDictionary<CultureInfo, string> Win32FaceNames { get; }
+        public IDictionary<CultureInfo, string> Win32FamilyNames { get; }
+        public double XHeight { get; }
+        public byte[] ComputeSubset(ICollection<ushort> glyphs);
+        public override bool Equals(object o);
+        public Stream GetFontStream();
+        public Geometry GetGlyphOutline(ushort glyphIndex, double renderingEmSize, double hintingEmSize);
+        public override int GetHashCode();
+        void System.ComponentModel.ISupportInitialize.BeginInit();
+        void System.ComponentModel.ISupportInitialize.EndInit();
+    }
+    public abstract class GradientBrush : Brush {
+        public static readonly DependencyProperty ColorInterpolationModeProperty;
+        public static readonly DependencyProperty GradientStopsProperty;
+        public static readonly DependencyProperty MappingModeProperty;
+        public static readonly DependencyProperty SpreadMethodProperty;
+        protected GradientBrush();
+        protected GradientBrush(GradientStopCollection gradientStopCollection);
+        public ColorInterpolationMode ColorInterpolationMode { get; set; }
+        public GradientStopCollection GradientStops { get; set; }
+        public BrushMappingMode MappingMode { get; set; }
+        public GradientSpreadMethod SpreadMethod { get; set; }
+        public new GradientBrush Clone();
+        public new GradientBrush CloneCurrentValue();
+    }
+    public enum GradientSpreadMethod {
+        Pad = 0,
+        Reflect = 1,
+        Repeat = 2,
+    }
+    public sealed class GradientStop : Animatable, IFormattable {
+        public static readonly DependencyProperty ColorProperty;
+        public static readonly DependencyProperty OffsetProperty;
+        public GradientStop();
+        public GradientStop(Color color, double offset);
+        public Color Color { get; set; }
+        public double Offset { get; set; }
+        public new GradientStop Clone();
+        public new GradientStop CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+        string System.IFormattable.ToString(string format, IFormatProvider provider);
+        public override string ToString();
+        public string ToString(IFormatProvider provider);
+    }
+    public sealed class GradientStopCollection : Animatable, ICollection, ICollection<GradientStop>, IEnumerable, IEnumerable<GradientStop>, IFormattable, IList, IList<GradientStop> {
+        public GradientStopCollection();
+        public GradientStopCollection(IEnumerable<GradientStop> collection);
+        public GradientStopCollection(int capacity);
+        public int Count { get; }
+        bool System.Collections.Generic.ICollection<System.Windows.Media.GradientStop>.IsReadOnly { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public GradientStop this[int index] { get; set; }
+        public void Add(GradientStop value);
+        public void Clear();
+        public new GradientStopCollection Clone();
+        protected override void CloneCore(Freezable source);
+        public new GradientStopCollection CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable source);
+        public bool Contains(GradientStop value);
+        public void CopyTo(GradientStop[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        public GradientStopCollection.Enumerator GetEnumerator();
+        public int IndexOf(GradientStop value);
+        public void Insert(int index, GradientStop value);
+        public static GradientStopCollection Parse(string source);
+        public bool Remove(GradientStop value);
+        public void RemoveAt(int index);
+        IEnumerator<GradientStop> System.Collections.Generic.IEnumerable<System.Windows.Media.GradientStop>.GetEnumerator();
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        string System.IFormattable.ToString(string format, IFormatProvider provider);
+        public override string ToString();
+        public string ToString(IFormatProvider provider);
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct Enumerator : IDisposable, IEnumerator, IEnumerator<GradientStop> {
+            public GradientStop Current { get; }
+            object System.Collections.IEnumerator.Current { get; }
+            public bool MoveNext();
+            public void Reset();
+            void System.IDisposable.Dispose();
+        }
+    }
+    public sealed class GuidelineSet : Animatable, DUCE.IResource {
+        public static readonly DependencyProperty GuidelinesXProperty;
+        public static readonly DependencyProperty GuidelinesYProperty;
+        public GuidelineSet();
+        public GuidelineSet(double[] guidelinesX, double[] guidelinesY);
+        public DoubleCollection GuidelinesX { get; set; }
+        public DoubleCollection GuidelinesY { get; set; }
+        public new GuidelineSet Clone();
+        public new GuidelineSet CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public enum HitTestFilterBehavior {
+        Continue = 6,
+        ContinueSkipChildren = 2,
+        ContinueSkipSelf = 4,
+        ContinueSkipSelfAndChildren = 0,
+        Stop = 8,
+    }
+    public delegate HitTestFilterBehavior HitTestFilterCallback(DependencyObject potentialHitTestTarget);
+    public abstract class HitTestParameters
+    public abstract class HitTestResult {
+        public DependencyObject VisualHit { get; }
+    }
+    public enum HitTestResultBehavior {
+        Continue = 1,
+        Stop = 0,
+    }
+    public delegate HitTestResultBehavior HitTestResultCallback(HitTestResult result);
+    public class HostVisual : ContainerVisual {
+        public HostVisual();
+        protected override GeometryHitTestResult HitTestCore(GeometryHitTestParameters hitTestParameters);
+        protected override HitTestResult HitTestCore(PointHitTestParameters hitTestParameters);
+    }
+    public sealed class ImageBrush : TileBrush {
+        public static readonly DependencyProperty ImageSourceProperty;
+        public ImageBrush();
+        public ImageBrush(ImageSource image);
+        public ImageSource ImageSource { get; set; }
+        public new ImageBrush Clone();
+        public new ImageBrush CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+        protected override void GetContentBounds(out Rect contentBounds);
+    }
+    public sealed class ImageDrawing : Drawing {
+        public static readonly DependencyProperty ImageSourceProperty;
+        public static readonly DependencyProperty RectProperty;
+        public ImageDrawing();
+        public ImageDrawing(ImageSource imageSource, Rect rect);
+        public ImageSource ImageSource { get; set; }
+        public Rect Rect { get; set; }
+        public new ImageDrawing Clone();
+        public new ImageDrawing CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public abstract class ImageMetadata : Freezable {
+        public new ImageMetadata Clone();
+    }
+    public abstract class ImageSource : Animatable, DUCE.IResource, IFormattable {
+        public abstract double Height { get; }
+        public abstract ImageMetadata Metadata { get; }
+        public abstract double Width { get; }
+        public new ImageSource Clone();
+        public new ImageSource CloneCurrentValue();
+        protected static double PixelsToDIPs(double dpi, int pixels);
+        string System.IFormattable.ToString(string format, IFormatProvider provider);
+        public override string ToString();
+        public string ToString(IFormatProvider provider);
+    }
+    public class ImageSourceConverter : TypeConverter {
+        public ImageSourceConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public class ImageSourceValueSerializer : ValueSerializer {
+        public ImageSourceValueSerializer();
+        public override bool CanConvertFromString(string value, IValueSerializerContext context);
+        public override bool CanConvertToString(object value, IValueSerializerContext context);
+        public override object ConvertFromString(string value, IValueSerializerContext context);
+        public override string ConvertToString(object value, IValueSerializerContext context);
+    }
+    public sealed class Int32Collection : Freezable, ICollection, ICollection<int>, IEnumerable, IEnumerable<int>, IFormattable, IList, IList<int> {
+        public Int32Collection();
+        public Int32Collection(IEnumerable<int> collection);
+        public Int32Collection(int capacity);
+        public int Count { get; }
+        bool System.Collections.Generic.ICollection<System.Int32>.IsReadOnly { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public int this[int index] { get; set; }
+        public void Add(int value);
+        public void Clear();
+        public new Int32Collection Clone();
+        protected override void CloneCore(Freezable source);
+        public new Int32Collection CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable source);
+        public bool Contains(int value);
+        public void CopyTo(int[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        public Int32Collection.Enumerator GetEnumerator();
+        public int IndexOf(int value);
+        public void Insert(int index, int value);
+        public static Int32Collection Parse(string source);
+        public bool Remove(int value);
+        public void RemoveAt(int index);
+        IEnumerator<int> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator();
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        string System.IFormattable.ToString(string format, IFormatProvider provider);
+        public override string ToString();
+        public string ToString(IFormatProvider provider);
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct Enumerator : IDisposable, IEnumerator, IEnumerator<int> {
+            public int Current { get; }
+            object System.Collections.IEnumerator.Current { get; }
+            public bool MoveNext();
+            public void Reset();
+            void System.IDisposable.Dispose();
+        }
+    }
+    public sealed class Int32CollectionConverter : TypeConverter {
+        public Int32CollectionConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public enum IntersectionDetail {
+        Empty = 1,
+        FullyContains = 3,
+        FullyInside = 2,
+        Intersects = 4,
+        NotCalculated = 0,
+    }
+    public class InvalidWmpVersionException : SystemException {
+        public InvalidWmpVersionException();
+        protected InvalidWmpVersionException(SerializationInfo info, StreamingContext context);
+        public InvalidWmpVersionException(string message);
+        public InvalidWmpVersionException(string message, Exception innerException);
+    }
+    public sealed class LanguageSpecificStringDictionary : ICollection, ICollection<KeyValuePair<XmlLanguage, string>>, IDictionary, IDictionary<XmlLanguage, string>, IEnumerable, IEnumerable<KeyValuePair<XmlLanguage, string>> {
+        public int Count { get; }
+        public bool IsReadOnly { get; }
+        public ICollection<XmlLanguage> Keys { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IDictionary.IsFixedSize { get; }
+        object System.Collections.IDictionary.this[object key] { get; set; }
+        ICollection System.Collections.IDictionary.Keys { get; }
+        ICollection System.Collections.IDictionary.Values { get; }
+        public string this[XmlLanguage key] { get; set; }
+        public ICollection<string> Values { get; }
+        public void Add(KeyValuePair<XmlLanguage, string> item);
+        public void Add(XmlLanguage key, string value);
+        public void Clear();
+        public bool Contains(KeyValuePair<XmlLanguage, string> item);
+        public bool ContainsKey(XmlLanguage key);
+        public void CopyTo(KeyValuePair<XmlLanguage, string>[] array, int index);
+        public IEnumerator<KeyValuePair<XmlLanguage, string>> GetEnumerator();
+        public bool Remove(KeyValuePair<XmlLanguage, string> item);
+        public bool Remove(XmlLanguage key);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        void System.Collections.IDictionary.Add(object key, object value);
+        bool System.Collections.IDictionary.Contains(object key);
+        IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator();
+        void System.Collections.IDictionary.Remove(object key);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        public bool TryGetValue(XmlLanguage key, out string value);
+    }
+    public sealed class LinearGradientBrush : GradientBrush {
+        public static readonly DependencyProperty EndPointProperty;
+        public static readonly DependencyProperty StartPointProperty;
+        public LinearGradientBrush();
+        public LinearGradientBrush(Color startColor, Color endColor, double angle);
+        public LinearGradientBrush(Color startColor, Color endColor, Point startPoint, Point endPoint);
+        public LinearGradientBrush(GradientStopCollection gradientStopCollection);
+        public LinearGradientBrush(GradientStopCollection gradientStopCollection, double angle);
+        public LinearGradientBrush(GradientStopCollection gradientStopCollection, Point startPoint, Point endPoint);
+        public Point EndPoint { get; set; }
+        public Point StartPoint { get; set; }
+        public new LinearGradientBrush Clone();
+        public new LinearGradientBrush CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public sealed class LineGeometry : Geometry {
+        public static readonly DependencyProperty EndPointProperty;
+        public static readonly DependencyProperty StartPointProperty;
+        public LineGeometry();
+        public LineGeometry(Point startPoint, Point endPoint);
+        public LineGeometry(Point startPoint, Point endPoint, Transform transform);
+        public override Rect Bounds { get; }
+        public Point EndPoint { get; set; }
+        public Point StartPoint { get; set; }
+        public new LineGeometry Clone();
+        public new LineGeometry CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+        public override double GetArea(double tolerance, ToleranceType type);
+        public override bool IsEmpty();
+        public override bool MayHaveCurves();
+    }
+    public sealed class LineSegment : PathSegment {
+        public static readonly DependencyProperty PointProperty;
+        public LineSegment();
+        public LineSegment(Point point, bool isStroked);
+        public Point Point { get; set; }
+        public new LineSegment Clone();
+        public new LineSegment CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct Matrix : IFormattable {
+        public Matrix(double m11, double m12, double m21, double m22, double offsetX, double offsetY);
+        public double Determinant { get; }
+        public bool HasInverse { get; }
+        public static Matrix Identity { get; }
+        public bool IsIdentity { get; }
+        public double M11 { get; set; }
+        public double M12 { get; set; }
+        public double M21 { get; set; }
+        public double M22 { get; set; }
+        public double OffsetX { get; set; }
+        public double OffsetY { get; set; }
+        public void Append(Matrix matrix);
+        public override bool Equals(object o);
+        public bool Equals(Matrix value);
+        public static bool Equals(Matrix matrix1, Matrix matrix2);
+        public override int GetHashCode();
+        public void Invert();
+        public static Matrix Multiply(Matrix trans1, Matrix trans2);
+        public static bool operator ==(Matrix matrix1, Matrix matrix2);
+        public static bool operator !=(Matrix matrix1, Matrix matrix2);
+        public static Matrix operator *(Matrix trans1, Matrix trans2);
+        public static Matrix Parse(string source);
+        public void Prepend(Matrix matrix);
+        public void Rotate(double angle);
+        public void RotateAt(double angle, double centerX, double centerY);
+        public void RotateAtPrepend(double angle, double centerX, double centerY);
+        public void RotatePrepend(double angle);
+        public void Scale(double scaleX, double scaleY);
+        public void ScaleAt(double scaleX, double scaleY, double centerX, double centerY);
+        public void ScaleAtPrepend(double scaleX, double scaleY, double centerX, double centerY);
+        public void ScalePrepend(double scaleX, double scaleY);
+        public void SetIdentity();
+        public void Skew(double skewX, double skewY);
+        public void SkewPrepend(double skewX, double skewY);
+        string System.IFormattable.ToString(string format, IFormatProvider provider);
+        public override string ToString();
+        public string ToString(IFormatProvider provider);
+        public Point Transform(Point point);
+        public void Transform(Point[] points);
+        public Vector Transform(Vector vector);
+        public void Transform(Vector[] vectors);
+        public void Translate(double offsetX, double offsetY);
+        public void TranslatePrepend(double offsetX, double offsetY);
+    }
+    public sealed class MatrixConverter : TypeConverter {
+        public MatrixConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public sealed class MatrixTransform : Transform {
+        public static readonly DependencyProperty MatrixProperty;
+        public MatrixTransform();
+        public MatrixTransform(double m11, double m12, double m21, double m22, double offsetX, double offsetY);
+        public MatrixTransform(Matrix matrix);
+        public Matrix Matrix { get; set; }
+        public override Matrix Value { get; }
+        public new MatrixTransform Clone();
+        public new MatrixTransform CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public class MediaClock : Clock {
+        protected internal MediaClock(MediaTimeline media);
+        public new MediaTimeline Timeline { get; }
+        protected override void DiscontinuousTimeMovement();
+        protected override bool GetCanSlip();
+        protected override TimeSpan GetCurrentTimeCore();
+        protected override void SpeedChanged();
+        protected override void Stopped();
+    }
+    public class MediaPlayer : Animatable, DUCE.IResource {
+        public MediaPlayer();
+        public double Balance { get; set; }
+        public double BufferingProgress { get; }
+        public bool CanPause { get; }
+        public MediaClock Clock { get; set; }
+        public double DownloadProgress { get; }
+        public bool HasAudio { get; }
+        public bool HasVideo { get; }
+        public bool IsBuffering { get; }
+        public bool IsMuted { get; set; }
+        public Duration NaturalDuration { get; }
+        public int NaturalVideoHeight { get; }
+        public int NaturalVideoWidth { get; }
+        public TimeSpan Position { get; set; }
+        public bool ScrubbingEnabled { get; set; }
+        public Uri Source { get; }
+        public double SpeedRatio { get; set; }
+        public double Volume { get; set; }
+        public event EventHandler BufferingEnded;
+        public event EventHandler BufferingStarted;
+        public event EventHandler MediaEnded;
+        public event EventHandler<ExceptionEventArgs> MediaFailed;
+        public event EventHandler MediaOpened;
+        public event EventHandler<MediaScriptCommandEventArgs> ScriptCommand;
+        protected override void CloneCore(Freezable sourceFreezable);
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        public void Close();
+        protected override Freezable CreateInstanceCore();
+        protected override void GetAsFrozenCore(Freezable sourceFreezable);
+        public void Open(Uri source);
+        public void Pause();
+        public void Play();
+        protected new void ReadPreamble();
+        public void Stop();
+        protected new void WritePreamble();
+    }
+    public sealed class MediaScriptCommandEventArgs : EventArgs {
+        public string ParameterType { get; }
+        public string ParameterValue { get; }
+    }
+    public class MediaTimeline : Timeline, IUriContext {
+        public static readonly DependencyProperty SourceProperty;
+        public MediaTimeline();
+        public MediaTimeline(Nullable<TimeSpan> beginTime);
+        public MediaTimeline(Nullable<TimeSpan> beginTime, Duration duration);
+        public MediaTimeline(Nullable<TimeSpan> beginTime, Duration duration, RepeatBehavior repeatBehavior);
+        public MediaTimeline(Uri source);
+        public Uri Source { get; set; }
+        Uri System.Windows.Markup.IUriContext.BaseUri { get; set; }
+        protected internal override Clock AllocateClock();
+        public new MediaTimeline Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        public new MediaTimeline CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        public new MediaClock CreateClock();
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        protected override Duration GetNaturalDurationCore(Clock clock);
+        public override string ToString();
+    }
+    public enum NumberCultureSource {
+        Override = 2,
+        Text = 0,
+        User = 1,
+    }
+    public class NumberSubstitution {
+        public static readonly DependencyProperty CultureOverrideProperty;
+        public static readonly DependencyProperty CultureSourceProperty;
+        public static readonly DependencyProperty SubstitutionProperty;
+        public NumberSubstitution();
+        public NumberSubstitution(NumberCultureSource source, CultureInfo cultureOverride, NumberSubstitutionMethod substitution);
+        public CultureInfo CultureOverride { get; set; }
+        public NumberCultureSource CultureSource { get; set; }
+        public NumberSubstitutionMethod Substitution { get; set; }
+        public override bool Equals(object obj);
+        public static CultureInfo GetCultureOverride(DependencyObject target);
+        public static NumberCultureSource GetCultureSource(DependencyObject target);
+        public override int GetHashCode();
+        public static NumberSubstitutionMethod GetSubstitution(DependencyObject target);
+        public static void SetCultureOverride(DependencyObject target, CultureInfo value);
+        public static void SetCultureSource(DependencyObject target, NumberCultureSource value);
+        public static void SetSubstitution(DependencyObject target, NumberSubstitutionMethod value);
+    }
+    public enum NumberSubstitutionMethod {
+        AsCulture = 0,
+        Context = 1,
+        European = 2,
+        NativeNational = 3,
+        Traditional = 4,
+    }
+    public sealed class PathFigure : Animatable, IFormattable {
+        public static readonly DependencyProperty IsClosedProperty;
+        public static readonly DependencyProperty IsFilledProperty;
+        public static readonly DependencyProperty SegmentsProperty;
+        public static readonly DependencyProperty StartPointProperty;
+        public PathFigure();
+        public PathFigure(Point start, IEnumerable<PathSegment> segments, bool closed);
+        public bool IsClosed { get; set; }
+        public bool IsFilled { get; set; }
+        public PathSegmentCollection Segments { get; set; }
+        public Point StartPoint { get; set; }
+        public new PathFigure Clone();
+        public new PathFigure CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+        public PathFigure GetFlattenedPathFigure();
+        public PathFigure GetFlattenedPathFigure(double tolerance, ToleranceType type);
+        public bool MayHaveCurves();
+        string System.IFormattable.ToString(string format, IFormatProvider provider);
+        public override string ToString();
+        public string ToString(IFormatProvider provider);
+    }
+    public sealed class PathFigureCollection : Animatable, ICollection, ICollection<PathFigure>, IEnumerable, IEnumerable<PathFigure>, IFormattable, IList, IList<PathFigure> {
+        public PathFigureCollection();
+        public PathFigureCollection(IEnumerable<PathFigure> collection);
+        public PathFigureCollection(int capacity);
+        public int Count { get; }
+        bool System.Collections.Generic.ICollection<System.Windows.Media.PathFigure>.IsReadOnly { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public PathFigure this[int index] { get; set; }
+        public void Add(PathFigure value);
+        public void Clear();
+        public new PathFigureCollection Clone();
+        protected override void CloneCore(Freezable source);
+        public new PathFigureCollection CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable source);
+        public bool Contains(PathFigure value);
+        public void CopyTo(PathFigure[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        public PathFigureCollection.Enumerator GetEnumerator();
+        public int IndexOf(PathFigure value);
+        public void Insert(int index, PathFigure value);
+        public static PathFigureCollection Parse(string source);
+        public bool Remove(PathFigure value);
+        public void RemoveAt(int index);
+        IEnumerator<PathFigure> System.Collections.Generic.IEnumerable<System.Windows.Media.PathFigure>.GetEnumerator();
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        string System.IFormattable.ToString(string format, IFormatProvider provider);
+        public override string ToString();
+        public string ToString(IFormatProvider provider);
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct Enumerator : IDisposable, IEnumerator, IEnumerator<PathFigure> {
+            public PathFigure Current { get; }
+            object System.Collections.IEnumerator.Current { get; }
+            public bool MoveNext();
+            public void Reset();
+            void System.IDisposable.Dispose();
+        }
+    }
+    public sealed class PathFigureCollectionConverter : TypeConverter {
+        public PathFigureCollectionConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public sealed class PathGeometry : Geometry {
+        public static readonly DependencyProperty FiguresProperty;
+        public static readonly DependencyProperty FillRuleProperty;
+        public PathGeometry();
+        public PathGeometry(IEnumerable<PathFigure> figures);
+        public PathGeometry(IEnumerable<PathFigure> figures, FillRule fillRule, Transform transform);
+        public override Rect Bounds { get; }
+        public PathFigureCollection Figures { get; set; }
+        public FillRule FillRule { get; set; }
+        public void AddGeometry(Geometry geometry);
+        public void Clear();
+        public new PathGeometry Clone();
+        public new PathGeometry CloneCurrentValue();
+        public static PathGeometry CreateFromGeometry(Geometry geometry);
+        protected override Freezable CreateInstanceCore();
+        public void GetPointAtFractionLength(double progress, out Point point, out Point tangent);
+        public override bool IsEmpty();
+        public override bool MayHaveCurves();
+        protected override void OnChanged();
+    }
+    public abstract class PathSegment : Animatable {
+        public static readonly DependencyProperty IsSmoothJoinProperty;
+        public static readonly DependencyProperty IsStrokedProperty;
+        public bool IsSmoothJoin { get; set; }
+        public bool IsStroked { get; set; }
+        public new PathSegment Clone();
+        public new PathSegment CloneCurrentValue();
+    }
+    public sealed class PathSegmentCollection : Animatable, ICollection, ICollection<PathSegment>, IEnumerable, IEnumerable<PathSegment>, IList, IList<PathSegment> {
+        public PathSegmentCollection();
+        public PathSegmentCollection(IEnumerable<PathSegment> collection);
+        public PathSegmentCollection(int capacity);
+        public int Count { get; }
+        bool System.Collections.Generic.ICollection<System.Windows.Media.PathSegment>.IsReadOnly { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public PathSegment this[int index] { get; set; }
+        public void Add(PathSegment value);
+        public void Clear();
+        public new PathSegmentCollection Clone();
+        protected override void CloneCore(Freezable source);
+        public new PathSegmentCollection CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable source);
+        public bool Contains(PathSegment value);
+        public void CopyTo(PathSegment[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        public PathSegmentCollection.Enumerator GetEnumerator();
+        public int IndexOf(PathSegment value);
+        public void Insert(int index, PathSegment value);
+        public bool Remove(PathSegment value);
+        public void RemoveAt(int index);
+        IEnumerator<PathSegment> System.Collections.Generic.IEnumerable<System.Windows.Media.PathSegment>.GetEnumerator();
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct Enumerator : IDisposable, IEnumerator, IEnumerator<PathSegment> {
+            public PathSegment Current { get; }
+            object System.Collections.IEnumerator.Current { get; }
+            public bool MoveNext();
+            public void Reset();
+            void System.IDisposable.Dispose();
+        }
+    }
+    public sealed class Pen : Animatable, DUCE.IResource {
+        public static readonly DependencyProperty BrushProperty;
+        public static readonly DependencyProperty DashCapProperty;
+        public static readonly DependencyProperty DashStyleProperty;
+        public static readonly DependencyProperty EndLineCapProperty;
+        public static readonly DependencyProperty LineJoinProperty;
+        public static readonly DependencyProperty MiterLimitProperty;
+        public static readonly DependencyProperty StartLineCapProperty;
+        public static readonly DependencyProperty ThicknessProperty;
+        public Pen();
+        public Pen(Brush brush, double thickness);
+        public Brush Brush { get; set; }
+        public PenLineCap DashCap { get; set; }
+        public DashStyle DashStyle { get; set; }
+        public PenLineCap EndLineCap { get; set; }
+        public PenLineJoin LineJoin { get; set; }
+        public double MiterLimit { get; set; }
+        public PenLineCap StartLineCap { get; set; }
+        public double Thickness { get; set; }
+        public new Pen Clone();
+        public new Pen CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public enum PenLineCap {
+        Flat = 0,
+        Round = 2,
+        Square = 1,
+        Triangle = 3,
+    }
+    public enum PenLineJoin {
+        Bevel = 1,
+        Miter = 0,
+        Round = 2,
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct PixelFormat : IEquatable<PixelFormat> {
+        public int BitsPerPixel { get; }
+        public IList<PixelFormatChannelMask> Masks { get; }
+        public override bool Equals(object obj);
+        public bool Equals(PixelFormat pixelFormat);
+        public static bool Equals(PixelFormat left, PixelFormat right);
+        public override int GetHashCode();
+        public static bool operator ==(PixelFormat left, PixelFormat right);
+        public static bool operator !=(PixelFormat left, PixelFormat right);
+        public override string ToString();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct PixelFormatChannelMask {
+        public IList<byte> Mask { get; }
+        public override bool Equals(object obj);
+        public static bool Equals(PixelFormatChannelMask left, PixelFormatChannelMask right);
+        public override int GetHashCode();
+        public static bool operator ==(PixelFormatChannelMask left, PixelFormatChannelMask right);
+        public static bool operator !=(PixelFormatChannelMask left, PixelFormatChannelMask right);
+    }
+    public sealed class PixelFormatConverter : TypeConverter {
+        public PixelFormatConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext td, Type t);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext td, CultureInfo ci, object o);
+        public new object ConvertFromString(string value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public static class PixelFormats {
+        public static PixelFormat Bgr101010 { get; }
+        public static PixelFormat Bgr24 { get; }
+        public static PixelFormat Bgr32 { get; }
+        public static PixelFormat Bgr555 { get; }
+        public static PixelFormat Bgr565 { get; }
+        public static PixelFormat Bgra32 { get; }
+        public static PixelFormat BlackWhite { get; }
+        public static PixelFormat Cmyk32 { get; }
+        public static PixelFormat Default { get; }
+        public static PixelFormat Gray16 { get; }
+        public static PixelFormat Gray2 { get; }
+        public static PixelFormat Gray32Float { get; }
+        public static PixelFormat Gray4 { get; }
+        public static PixelFormat Gray8 { get; }
+        public static PixelFormat Indexed1 { get; }
+        public static PixelFormat Indexed2 { get; }
+        public static PixelFormat Indexed4 { get; }
+        public static PixelFormat Indexed8 { get; }
+        public static PixelFormat Pbgra32 { get; }
+        public static PixelFormat Prgba128Float { get; }
+        public static PixelFormat Prgba64 { get; }
+        public static PixelFormat Rgb128Float { get; }
+        public static PixelFormat Rgb24 { get; }
+        public static PixelFormat Rgb48 { get; }
+        public static PixelFormat Rgba128Float { get; }
+        public static PixelFormat Rgba64 { get; }
+    }
+    public sealed class PointCollection : Freezable, ICollection, ICollection<Point>, IEnumerable, IEnumerable<Point>, IFormattable, IList, IList<Point> {
+        public PointCollection();
+        public PointCollection(IEnumerable<Point> collection);
+        public PointCollection(int capacity);
+        public int Count { get; }
+        bool System.Collections.Generic.ICollection<System.Windows.Point>.IsReadOnly { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public Point this[int index] { get; set; }
+        public void Add(Point value);
+        public void Clear();
+        public new PointCollection Clone();
+        protected override void CloneCore(Freezable source);
+        public new PointCollection CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable source);
+        public bool Contains(Point value);
+        public void CopyTo(Point[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        public PointCollection.Enumerator GetEnumerator();
+        public int IndexOf(Point value);
+        public void Insert(int index, Point value);
+        public static PointCollection Parse(string source);
+        public bool Remove(Point value);
+        public void RemoveAt(int index);
+        IEnumerator<Point> System.Collections.Generic.IEnumerable<System.Windows.Point>.GetEnumerator();
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        string System.IFormattable.ToString(string format, IFormatProvider provider);
+        public override string ToString();
+        public string ToString(IFormatProvider provider);
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct Enumerator : IDisposable, IEnumerator, IEnumerator<Point> {
+            public Point Current { get; }
+            object System.Collections.IEnumerator.Current { get; }
+            public bool MoveNext();
+            public void Reset();
+            void System.IDisposable.Dispose();
+        }
+    }
+    public sealed class PointCollectionConverter : TypeConverter {
+        public PointCollectionConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public class PointHitTestParameters : HitTestParameters {
+        public PointHitTestParameters(Point point);
+        public Point HitPoint { get; }
+    }
+    public class PointHitTestResult : HitTestResult {
+        public PointHitTestResult(Visual visualHit, Point pointHit);
+        public Point PointHit { get; }
+        public new Visual VisualHit { get; }
+    }
+    public sealed class PolyBezierSegment : PathSegment {
+        public static readonly DependencyProperty PointsProperty;
+        public PolyBezierSegment();
+        public PolyBezierSegment(IEnumerable<Point> points, bool isStroked);
+        public PointCollection Points { get; set; }
+        public new PolyBezierSegment Clone();
+        public new PolyBezierSegment CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public sealed class PolyLineSegment : PathSegment {
+        public static readonly DependencyProperty PointsProperty;
+        public PolyLineSegment();
+        public PolyLineSegment(IEnumerable<Point> points, bool isStroked);
+        public PointCollection Points { get; set; }
+        public new PolyLineSegment Clone();
+        public new PolyLineSegment CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public sealed class PolyQuadraticBezierSegment : PathSegment {
+        public static readonly DependencyProperty PointsProperty;
+        public PolyQuadraticBezierSegment();
+        public PolyQuadraticBezierSegment(IEnumerable<Point> points, bool isStroked);
+        public PointCollection Points { get; set; }
+        public new PolyQuadraticBezierSegment Clone();
+        public new PolyQuadraticBezierSegment CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public sealed class QuadraticBezierSegment : PathSegment {
+        public static readonly DependencyProperty Point1Property;
+        public static readonly DependencyProperty Point2Property;
+        public QuadraticBezierSegment();
+        public QuadraticBezierSegment(Point point1, Point point2, bool isStroked);
+        public Point Point1 { get; set; }
+        public Point Point2 { get; set; }
+        public new QuadraticBezierSegment Clone();
+        public new QuadraticBezierSegment CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public sealed class RadialGradientBrush : GradientBrush {
+        public static readonly DependencyProperty CenterProperty;
+        public static readonly DependencyProperty GradientOriginProperty;
+        public static readonly DependencyProperty RadiusXProperty;
+        public static readonly DependencyProperty RadiusYProperty;
+        public RadialGradientBrush();
+        public RadialGradientBrush(Color startColor, Color endColor);
+        public RadialGradientBrush(GradientStopCollection gradientStopCollection);
+        public Point Center { get; set; }
+        public Point GradientOrigin { get; set; }
+        public double RadiusX { get; set; }
+        public double RadiusY { get; set; }
+        public new RadialGradientBrush Clone();
+        public new RadialGradientBrush CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public sealed class RectangleGeometry : Geometry {
+        public static readonly DependencyProperty RadiusXProperty;
+        public static readonly DependencyProperty RadiusYProperty;
+        public static readonly DependencyProperty RectProperty;
+        public RectangleGeometry();
+        public RectangleGeometry(Rect rect);
+        public RectangleGeometry(Rect rect, double radiusX, double radiusY);
+        public RectangleGeometry(Rect rect, double radiusX, double radiusY, Transform transform);
+        public override Rect Bounds { get; }
+        public double RadiusX { get; set; }
+        public double RadiusY { get; set; }
+        public Rect Rect { get; set; }
+        public new RectangleGeometry Clone();
+        public new RectangleGeometry CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+        public override double GetArea(double tolerance, ToleranceType type);
+        public override bool IsEmpty();
+        public override bool MayHaveCurves();
+    }
+    public static class RenderCapability {
+        public static bool IsShaderEffectSoftwareRenderingSupported { get; }
+        public static Size MaxHardwareTextureSize { get; }
+        public static int Tier { get; }
+        public static event EventHandler TierChanged;
+        public static bool IsPixelShaderVersionSupported(short majorVersionRequested, short minorVersionRequested);
+        public static bool IsPixelShaderVersionSupportedInSoftware(short majorVersionRequested, short minorVersionRequested);
+        public static int MaxPixelShaderInstructionSlots(short majorVersionRequested, short minorVersionRequested);
+    }
+    public class RenderingEventArgs : EventArgs {
+        public TimeSpan RenderingTime { get; }
+    }
+    public static class RenderOptions {
+        public static readonly DependencyProperty BitmapScalingModeProperty;
+        public static readonly DependencyProperty CacheInvalidationThresholdMaximumProperty;
+        public static readonly DependencyProperty CacheInvalidationThresholdMinimumProperty;
+        public static readonly DependencyProperty CachingHintProperty;
+        public static readonly DependencyProperty ClearTypeHintProperty;
+        public static readonly DependencyProperty EdgeModeProperty;
+        public static RenderMode ProcessRenderMode { get; set; }
+        public static BitmapScalingMode GetBitmapScalingMode(DependencyObject target);
+        public static double GetCacheInvalidationThresholdMaximum(DependencyObject target);
+        public static double GetCacheInvalidationThresholdMinimum(DependencyObject target);
+        public static CachingHint GetCachingHint(DependencyObject target);
+        public static ClearTypeHint GetClearTypeHint(DependencyObject target);
+        public static EdgeMode GetEdgeMode(DependencyObject target);
+        public static void SetBitmapScalingMode(DependencyObject target, BitmapScalingMode bitmapScalingMode);
+        public static void SetCacheInvalidationThresholdMaximum(DependencyObject target, double cacheInvalidationThresholdMaximum);
+        public static void SetCacheInvalidationThresholdMinimum(DependencyObject target, double cacheInvalidationThresholdMinimum);
+        public static void SetCachingHint(DependencyObject target, CachingHint cachingHint);
+        public static void SetClearTypeHint(DependencyObject target, ClearTypeHint clearTypeHint);
+        public static void SetEdgeMode(DependencyObject target, EdgeMode edgeMode);
+    }
+    public sealed class RequestCachePolicyConverter : TypeConverter {
+        public RequestCachePolicyConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext td, Type t);
+        public override bool CanConvertTo(ITypeDescriptorContext typeDescriptorContext, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext td, CultureInfo ci, object value);
+        public override object ConvertTo(ITypeDescriptorContext typeDescriptorContext, CultureInfo cultureInfo, object value, Type destinationType);
+    }
+    public sealed class RotateTransform : Transform {
+        public static readonly DependencyProperty AngleProperty;
+        public static readonly DependencyProperty CenterXProperty;
+        public static readonly DependencyProperty CenterYProperty;
+        public RotateTransform();
+        public RotateTransform(double angle);
+        public RotateTransform(double angle, double centerX, double centerY);
+        public double Angle { get; set; }
+        public double CenterX { get; set; }
+        public double CenterY { get; set; }
+        public override Matrix Value { get; }
+        public new RotateTransform Clone();
+        public new RotateTransform CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public sealed class ScaleTransform : Transform {
+        public static readonly DependencyProperty CenterXProperty;
+        public static readonly DependencyProperty CenterYProperty;
+        public static readonly DependencyProperty ScaleXProperty;
+        public static readonly DependencyProperty ScaleYProperty;
+        public ScaleTransform();
+        public ScaleTransform(double scaleX, double scaleY);
+        public ScaleTransform(double scaleX, double scaleY, double centerX, double centerY);
+        public double CenterX { get; set; }
+        public double CenterY { get; set; }
+        public double ScaleX { get; set; }
+        public double ScaleY { get; set; }
+        public override Matrix Value { get; }
+        public new ScaleTransform Clone();
+        public new ScaleTransform CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public sealed class SkewTransform : Transform {
+        public static readonly DependencyProperty AngleXProperty;
+        public static readonly DependencyProperty AngleYProperty;
+        public static readonly DependencyProperty CenterXProperty;
+        public static readonly DependencyProperty CenterYProperty;
+        public SkewTransform();
+        public SkewTransform(double angleX, double angleY);
+        public SkewTransform(double angleX, double angleY, double centerX, double centerY);
+        public double AngleX { get; set; }
+        public double AngleY { get; set; }
+        public double CenterX { get; set; }
+        public double CenterY { get; set; }
+        public override Matrix Value { get; }
+        public new SkewTransform Clone();
+        public new SkewTransform CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public sealed class SolidColorBrush : Brush {
+        public static readonly DependencyProperty ColorProperty;
+        public SolidColorBrush();
+        public SolidColorBrush(Color color);
+        public Color Color { get; set; }
+        public new SolidColorBrush Clone();
+        public new SolidColorBrush CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+        public static object DeserializeFrom(BinaryReader reader);
+    }
+    public sealed class StreamGeometry : Geometry {
+        public static readonly DependencyProperty FillRuleProperty;
+        public StreamGeometry();
+        public override Rect Bounds { get; }
+        public FillRule FillRule { get; set; }
+        public void Clear();
+        public new StreamGeometry Clone();
+        protected override void CloneCore(Freezable source);
+        public new StreamGeometry CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable source);
+        protected override Freezable CreateInstanceCore();
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        public override bool IsEmpty();
+        public override bool MayHaveCurves();
+        protected override void OnChanged();
+        public StreamGeometryContext Open();
+    }
+    public abstract class StreamGeometryContext : DispatcherObject, IDisposable {
+        public abstract void ArcTo(Point point, Size size, double rotationAngle, bool isLargeArc, SweepDirection sweepDirection, bool isStroked, bool isSmoothJoin);
+        public abstract void BeginFigure(Point startPoint, bool isFilled, bool isClosed);
+        public abstract void BezierTo(Point point1, Point point2, Point point3, bool isStroked, bool isSmoothJoin);
+        public virtual void Close();
+        public abstract void LineTo(Point point, bool isStroked, bool isSmoothJoin);
+        public abstract void PolyBezierTo(IList<Point> points, bool isStroked, bool isSmoothJoin);
+        public abstract void PolyLineTo(IList<Point> points, bool isStroked, bool isSmoothJoin);
+        public abstract void PolyQuadraticBezierTo(IList<Point> points, bool isStroked, bool isSmoothJoin);
+        public abstract void QuadraticBezierTo(Point point1, Point point2, bool isStroked, bool isSmoothJoin);
+        void System.IDisposable.Dispose();
+    }
+    public enum Stretch {
+        Fill = 1,
+        None = 0,
+        Uniform = 2,
+        UniformToFill = 3,
+    }
+    public enum StyleSimulations {
+        BoldItalicSimulation = 3,
+        BoldSimulation = 1,
+        ItalicSimulation = 2,
+        None = 0,
+    }
+    public enum SweepDirection {
+        Clockwise = 1,
+        Counterclockwise = 0,
+    }
+    public sealed class TextEffect : Animatable {
+        public static readonly DependencyProperty ClipProperty;
+        public static readonly DependencyProperty ForegroundProperty;
+        public static readonly DependencyProperty PositionCountProperty;
+        public static readonly DependencyProperty PositionStartProperty;
+        public static readonly DependencyProperty TransformProperty;
+        public TextEffect();
+        public TextEffect(Transform transform, Brush foreground, Geometry clip, int positionStart, int positionCount);
+        public Geometry Clip { get; set; }
+        public Brush Foreground { get; set; }
+        public int PositionCount { get; set; }
+        public int PositionStart { get; set; }
+        public Transform Transform { get; set; }
+        public new TextEffect Clone();
+        public new TextEffect CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public sealed class TextEffectCollection : Animatable, ICollection, ICollection<TextEffect>, IEnumerable, IEnumerable<TextEffect>, IList, IList<TextEffect> {
+        public TextEffectCollection();
+        public TextEffectCollection(IEnumerable<TextEffect> collection);
+        public TextEffectCollection(int capacity);
+        public int Count { get; }
+        bool System.Collections.Generic.ICollection<System.Windows.Media.TextEffect>.IsReadOnly { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public TextEffect this[int index] { get; set; }
+        public void Add(TextEffect value);
+        public void Clear();
+        public new TextEffectCollection Clone();
+        protected override void CloneCore(Freezable source);
+        public new TextEffectCollection CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable source);
+        public bool Contains(TextEffect value);
+        public void CopyTo(TextEffect[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        public TextEffectCollection.Enumerator GetEnumerator();
+        public int IndexOf(TextEffect value);
+        public void Insert(int index, TextEffect value);
+        public bool Remove(TextEffect value);
+        public void RemoveAt(int index);
+        IEnumerator<TextEffect> System.Collections.Generic.IEnumerable<System.Windows.Media.TextEffect>.GetEnumerator();
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct Enumerator : IDisposable, IEnumerator, IEnumerator<TextEffect> {
+            public TextEffect Current { get; }
+            object System.Collections.IEnumerator.Current { get; }
+            public bool MoveNext();
+            public void Reset();
+            void System.IDisposable.Dispose();
+        }
+    }
+    public enum TextFormattingMode {
+        Display = 1,
+        Ideal = 0,
+    }
+    public enum TextHintingMode {
+        Animated = 2,
+        Auto = 0,
+        Fixed = 1,
+    }
+    public static class TextOptions {
+        public static readonly DependencyProperty TextFormattingModeProperty;
+        public static readonly DependencyProperty TextHintingModeProperty;
+        public static readonly DependencyProperty TextRenderingModeProperty;
+        public static TextFormattingMode GetTextFormattingMode(DependencyObject element);
+        public static TextHintingMode GetTextHintingMode(DependencyObject element);
+        public static TextRenderingMode GetTextRenderingMode(DependencyObject element);
+        public static void SetTextFormattingMode(DependencyObject element, TextFormattingMode value);
+        public static void SetTextHintingMode(DependencyObject element, TextHintingMode value);
+        public static void SetTextRenderingMode(DependencyObject element, TextRenderingMode value);
+    }
+    public enum TextRenderingMode {
+        Aliased = 1,
+        Auto = 0,
+        ClearType = 3,
+        Grayscale = 2,
+    }
+    public abstract class TileBrush : Brush {
+        public static readonly DependencyProperty AlignmentXProperty;
+        public static readonly DependencyProperty AlignmentYProperty;
+        public static readonly DependencyProperty StretchProperty;
+        public static readonly DependencyProperty TileModeProperty;
+        public static readonly DependencyProperty ViewboxProperty;
+        public static readonly DependencyProperty ViewboxUnitsProperty;
+        public static readonly DependencyProperty ViewportProperty;
+        public static readonly DependencyProperty ViewportUnitsProperty;
+        protected TileBrush();
+        public AlignmentX AlignmentX { get; set; }
+        public AlignmentY AlignmentY { get; set; }
+        public Stretch Stretch { get; set; }
+        public TileMode TileMode { get; set; }
+        public Rect Viewbox { get; set; }
+        public BrushMappingMode ViewboxUnits { get; set; }
+        public Rect Viewport { get; set; }
+        public BrushMappingMode ViewportUnits { get; set; }
+        public new TileBrush Clone();
+        public new TileBrush CloneCurrentValue();
+        protected abstract void GetContentBounds(out Rect contentBounds);
+    }
+    public enum TileMode {
+        FlipX = 1,
+        FlipXY = 3,
+        FlipY = 2,
+        None = 0,
+        Tile = 4,
+    }
+    public enum ToleranceType {
+        Absolute = 0,
+        Relative = 1,
+    }
+    public abstract class Transform : GeneralTransform, DUCE.IResource {
+        public static Transform Identity { get; }
+        public override GeneralTransform Inverse { get; }
+        public abstract Matrix Value { get; }
+        public new Transform Clone();
+        public new Transform CloneCurrentValue();
+        public static Transform Parse(string source);
+        public override Rect TransformBounds(Rect rect);
+        public override bool TryTransform(Point inPoint, out Point result);
+    }
+    public sealed class TransformCollection : Animatable, ICollection, ICollection<Transform>, IEnumerable, IEnumerable<Transform>, IList, IList<Transform> {
+        public TransformCollection();
+        public TransformCollection(IEnumerable<Transform> collection);
+        public TransformCollection(int capacity);
+        public int Count { get; }
+        bool System.Collections.Generic.ICollection<System.Windows.Media.Transform>.IsReadOnly { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public Transform this[int index] { get; set; }
+        public void Add(Transform value);
+        public void Clear();
+        public new TransformCollection Clone();
+        protected override void CloneCore(Freezable source);
+        public new TransformCollection CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable source);
+        public bool Contains(Transform value);
+        public void CopyTo(Transform[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        public TransformCollection.Enumerator GetEnumerator();
+        public int IndexOf(Transform value);
+        public void Insert(int index, Transform value);
+        public bool Remove(Transform value);
+        public void RemoveAt(int index);
+        IEnumerator<Transform> System.Collections.Generic.IEnumerable<System.Windows.Media.Transform>.GetEnumerator();
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct Enumerator : IDisposable, IEnumerator, IEnumerator<Transform> {
+            public Transform Current { get; }
+            object System.Collections.IEnumerator.Current { get; }
+            public bool MoveNext();
+            public void Reset();
+            void System.IDisposable.Dispose();
+        }
+    }
+    public sealed class TransformConverter : TypeConverter {
+        public TransformConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public sealed class TransformGroup : Transform {
+        public static readonly DependencyProperty ChildrenProperty;
+        public TransformGroup();
+        public TransformCollection Children { get; set; }
+        public override Matrix Value { get; }
+        public new TransformGroup Clone();
+        public new TransformGroup CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public sealed class TranslateTransform : Transform {
+        public static readonly DependencyProperty XProperty;
+        public static readonly DependencyProperty YProperty;
+        public TranslateTransform();
+        public TranslateTransform(double offsetX, double offsetY);
+        public override Matrix Value { get; }
+        public double X { get; set; }
+        public double Y { get; set; }
+        public new TranslateTransform Clone();
+        public new TranslateTransform CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public class Typeface {
+        public Typeface(string typefaceName);
+        public Typeface(FontFamily fontFamily, FontStyle style, FontWeight weight, FontStretch stretch);
+        public Typeface(FontFamily fontFamily, FontStyle style, FontWeight weight, FontStretch stretch, FontFamily fallbackFontFamily);
+        public double CapsHeight { get; }
+        public LanguageSpecificStringDictionary FaceNames { get; }
+        public FontFamily FontFamily { get; }
+        public bool IsBoldSimulated { get; }
+        public bool IsObliqueSimulated { get; }
+        public FontStretch Stretch { get; }
+        public double StrikethroughPosition { get; }
+        public double StrikethroughThickness { get; }
+        public FontStyle Style { get; }
+        public double UnderlinePosition { get; }
+        public double UnderlineThickness { get; }
+        public FontWeight Weight { get; }
+        public double XHeight { get; }
+        public override bool Equals(object o);
+        public override int GetHashCode();
+        public bool TryGetGlyphTypeface(out GlyphTypeface glyphTypeface);
+    }
+    public sealed class VectorCollection : Freezable, ICollection, ICollection<Vector>, IEnumerable, IEnumerable<Vector>, IFormattable, IList, IList<Vector> {
+        public VectorCollection();
+        public VectorCollection(IEnumerable<Vector> collection);
+        public VectorCollection(int capacity);
+        public int Count { get; }
+        bool System.Collections.Generic.ICollection<System.Windows.Vector>.IsReadOnly { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public Vector this[int index] { get; set; }
+        public void Add(Vector value);
+        public void Clear();
+        public new VectorCollection Clone();
+        protected override void CloneCore(Freezable source);
+        public new VectorCollection CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable source);
+        public bool Contains(Vector value);
+        public void CopyTo(Vector[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        public VectorCollection.Enumerator GetEnumerator();
+        public int IndexOf(Vector value);
+        public void Insert(int index, Vector value);
+        public static VectorCollection Parse(string source);
+        public bool Remove(Vector value);
+        public void RemoveAt(int index);
+        IEnumerator<Vector> System.Collections.Generic.IEnumerable<System.Windows.Vector>.GetEnumerator();
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        string System.IFormattable.ToString(string format, IFormatProvider provider);
+        public override string ToString();
+        public string ToString(IFormatProvider provider);
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct Enumerator : IDisposable, IEnumerator, IEnumerator<Vector> {
+            public Vector Current { get; }
+            object System.Collections.IEnumerator.Current { get; }
+            public bool MoveNext();
+            public void Reset();
+            void System.IDisposable.Dispose();
+        }
+    }
+    public sealed class VectorCollectionConverter : TypeConverter {
+        public VectorCollectionConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public sealed class VideoDrawing : Drawing {
+        public static readonly DependencyProperty PlayerProperty;
+        public static readonly DependencyProperty RectProperty;
+        public VideoDrawing();
+        public MediaPlayer Player { get; set; }
+        public Rect Rect { get; set; }
+        public new VideoDrawing Clone();
+        public new VideoDrawing CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public abstract class Visual : DependencyObject, DUCE.IResource {
+        protected Visual();
+        protected internal BitmapEffect VisualBitmapEffect { get; protected set; }
+        protected internal BitmapEffectInput VisualBitmapEffectInput { get; protected set; }
+        protected internal BitmapScalingMode VisualBitmapScalingMode { get; protected set; }
+        protected internal CacheMode VisualCacheMode { get; protected set; }
+        protected virtual int VisualChildrenCount { get; }
+        protected internal ClearTypeHint VisualClearTypeHint { get; set; }
+        protected internal Geometry VisualClip { get; protected set; }
+        protected internal EdgeMode VisualEdgeMode { get; protected set; }
+        protected internal Effect VisualEffect { get; protected set; }
+        protected internal Vector VisualOffset { get; protected set; }
+        protected internal double VisualOpacity { get; protected set; }
+        protected internal Brush VisualOpacityMask { get; protected set; }
+        protected DependencyObject VisualParent { get; }
+        protected internal Nullable<Rect> VisualScrollableAreaClip { get; protected set; }
+        protected internal TextHintingMode VisualTextHintingMode { get; set; }
+        protected internal TextRenderingMode VisualTextRenderingMode { get; set; }
+        protected internal Transform VisualTransform { get; protected set; }
+        protected internal DoubleCollection VisualXSnappingGuidelines { get; protected set; }
+        protected internal DoubleCollection VisualYSnappingGuidelines { get; protected set; }
+        protected void AddVisualChild(Visual child);
+        public DependencyObject FindCommonVisualAncestor(DependencyObject otherVisual);
+        protected virtual Visual GetVisualChild(int index);
+        protected virtual GeometryHitTestResult HitTestCore(GeometryHitTestParameters hitTestParameters);
+        protected virtual HitTestResult HitTestCore(PointHitTestParameters hitTestParameters);
+        public bool IsAncestorOf(DependencyObject descendant);
+        public bool IsDescendantOf(DependencyObject ancestor);
+        protected internal virtual void OnVisualChildrenChanged(DependencyObject visualAdded, DependencyObject visualRemoved);
+        protected internal virtual void OnVisualParentChanged(DependencyObject oldParent);
+        public Point PointFromScreen(Point point);
+        public Point PointToScreen(Point point);
+        protected void RemoveVisualChild(Visual child);
+        public GeneralTransform2DTo3D TransformToAncestor(Visual3D ancestor);
+        public GeneralTransform TransformToAncestor(Visual ancestor);
+        public GeneralTransform TransformToDescendant(Visual descendant);
+        public GeneralTransform TransformToVisual(Visual visual);
+    }
+    public sealed class VisualBrush : TileBrush, ICyclicBrush {
+        public static readonly DependencyProperty AutoLayoutContentProperty;
+        public static readonly DependencyProperty VisualProperty;
+        public VisualBrush();
+        public VisualBrush(Visual visual);
+        public bool AutoLayoutContent { get; set; }
+        public Visual Visual { get; set; }
+        public new VisualBrush Clone();
+        public new VisualBrush CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+        protected override void GetContentBounds(out Rect contentBounds);
+        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e);
+    }
+    public sealed class VisualCollection : ICollection, IEnumerable {
+        public VisualCollection(Visual parent);
+        public int Capacity { get; set; }
+        public int Count { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        public Visual this[int index] { get; set; }
+        public int Add(Visual visual);
+        public void Clear();
+        public bool Contains(Visual visual);
+        public void CopyTo(Array array, int index);
+        public void CopyTo(Visual[] array, int index);
+        public VisualCollection.Enumerator GetEnumerator();
+        public int IndexOf(Visual visual);
+        public void Insert(int index, Visual visual);
+        public void Remove(Visual visual);
+        public void RemoveAt(int index);
+        public void RemoveRange(int index, int count);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct Enumerator : IEnumerator {
+            public Visual Current { get; }
+            object System.Collections.IEnumerator.Current { get; }
+            public bool MoveNext();
+            public void Reset();
+        }
+    }
+    public class VisualTarget : CompositionTarget {
+        public VisualTarget(HostVisual hostVisual);
+        public override Matrix TransformFromDevice { get; }
+        public override Matrix TransformToDevice { get; }
+        public override void Dispose();
+    }
+    public static class VisualTreeHelper {
+        public static BitmapEffect GetBitmapEffect(Visual reference);
+        public static BitmapEffectInput GetBitmapEffectInput(Visual reference);
+        public static CacheMode GetCacheMode(Visual reference);
+        public static DependencyObject GetChild(DependencyObject reference, int childIndex);
+        public static int GetChildrenCount(DependencyObject reference);
+        public static Geometry GetClip(Visual reference);
+        public static Rect3D GetContentBounds(Visual3D reference);
+        public static Rect GetContentBounds(Visual reference);
+        public static Rect3D GetDescendantBounds(Visual3D reference);
+        public static Rect GetDescendantBounds(Visual reference);
+        public static DrawingGroup GetDrawing(Visual reference);
+        public static EdgeMode GetEdgeMode(Visual reference);
+        public static Effect GetEffect(Visual reference);
+        public static Vector GetOffset(Visual reference);
+        public static double GetOpacity(Visual reference);
+        public static Brush GetOpacityMask(Visual reference);
+        public static DependencyObject GetParent(DependencyObject reference);
+        public static Transform GetTransform(Visual reference);
+        public static DoubleCollection GetXSnappingGuidelines(Visual reference);
+        public static DoubleCollection GetYSnappingGuidelines(Visual reference);
+        public static void HitTest(Visual3D reference, HitTestFilterCallback filterCallback, HitTestResultCallback resultCallback, HitTestParameters3D hitTestParameters);
+        public static void HitTest(Visual reference, HitTestFilterCallback filterCallback, HitTestResultCallback resultCallback, HitTestParameters hitTestParameters);
+        public static HitTestResult HitTest(Visual reference, Point point);
+    }
+}
```

