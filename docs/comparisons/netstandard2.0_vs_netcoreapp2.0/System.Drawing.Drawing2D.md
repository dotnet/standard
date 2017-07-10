# System.Drawing.Drawing2D

``` diff
+namespace System.Drawing.Drawing2D {
+    public sealed class AdjustableArrowCap : CustomLineCap {
+        public AdjustableArrowCap(float width, float height);
+        public AdjustableArrowCap(float width, float height, bool isFilled);
+        public bool Filled { get; set; }
+        public float Height { get; set; }
+        public float MiddleInset { get; set; }
+        public float Width { get; set; }
+    }
+    public sealed class Blend {
+        public Blend();
+        public Blend(int count);
+        public float[] Factors { get; set; }
+        public float[] Positions { get; set; }
+    }
+    public sealed class ColorBlend {
+        public ColorBlend();
+        public ColorBlend(int count);
+        public Color[] Colors { get; set; }
+        public float[] Positions { get; set; }
+    }
+    public enum CombineMode {
+        Complement = 5,
+        Exclude = 4,
+        Intersect = 1,
+        Replace = 0,
+        Union = 2,
+        Xor = 3,
+    }
+    public enum CompositingMode {
+        SourceCopy = 1,
+        SourceOver = 0,
+    }
+    public enum CompositingQuality {
+        AssumeLinear = 4,
+        Default = 0,
+        GammaCorrected = 3,
+        HighQuality = 2,
+        HighSpeed = 1,
+        Invalid = -1,
+    }
+    public enum CoordinateSpace {
+        Device = 2,
+        Page = 1,
+        World = 0,
+    }
+    public class CustomLineCap : MarshalByRefObject, ICloneable, IDisposable {
+        public CustomLineCap(GraphicsPath fillPath, GraphicsPath strokePath);
+        public CustomLineCap(GraphicsPath fillPath, GraphicsPath strokePath, LineCap baseCap);
+        public CustomLineCap(GraphicsPath fillPath, GraphicsPath strokePath, LineCap baseCap, float baseInset);
+        public LineCap BaseCap { get; set; }
+        public float BaseInset { get; set; }
+        public LineJoin StrokeJoin { get; set; }
+        public float WidthScale { get; set; }
+        public object Clone();
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        ~CustomLineCap();
+        public void GetStrokeCaps(out LineCap startCap, out LineCap endCap);
+        public void SetStrokeCaps(LineCap startCap, LineCap endCap);
+    }
+    public enum DashCap {
+        Flat = 0,
+        Round = 2,
+        Triangle = 3,
+    }
+    public enum DashStyle {
+        Custom = 5,
+        Dash = 1,
+        DashDot = 3,
+        DashDotDot = 4,
+        Dot = 2,
+        Solid = 0,
+    }
+    public enum FillMode {
+        Alternate = 0,
+        Winding = 1,
+    }
+    public enum FlushIntention {
+        Flush = 0,
+        Sync = 1,
+    }
+    public sealed class GraphicsContainer : MarshalByRefObject
+    public sealed class GraphicsPath : MarshalByRefObject, ICloneable, IDisposable {
+        public GraphicsPath();
+        public GraphicsPath(FillMode fillMode);
+        public GraphicsPath(PointF[] pts, byte[] types);
+        public GraphicsPath(PointF[] pts, byte[] types, FillMode fillMode);
+        public GraphicsPath(Point[] pts, byte[] types);
+        public GraphicsPath(Point[] pts, byte[] types, FillMode fillMode);
+        public FillMode FillMode { get; set; }
+        public PathData PathData { get; }
+        public PointF[] PathPoints { get; }
+        public byte[] PathTypes { get; }
+        public int PointCount { get; }
+        public void AddArc(Rectangle rect, float startAngle, float sweepAngle);
+        public void AddArc(RectangleF rect, float startAngle, float sweepAngle);
+        public void AddArc(int x, int y, int width, int height, float startAngle, float sweepAngle);
+        public void AddArc(float x, float y, float width, float height, float startAngle, float sweepAngle);
+        public void AddBezier(Point pt1, Point pt2, Point pt3, Point pt4);
+        public void AddBezier(PointF pt1, PointF pt2, PointF pt3, PointF pt4);
+        public void AddBezier(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4);
+        public void AddBezier(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4);
+        public void AddBeziers(PointF[] points);
+        public void AddBeziers(params Point[] points);
+        public void AddClosedCurve(PointF[] points);
+        public void AddClosedCurve(PointF[] points, float tension);
+        public void AddClosedCurve(Point[] points);
+        public void AddClosedCurve(Point[] points, float tension);
+        public void AddCurve(PointF[] points);
+        public void AddCurve(PointF[] points, int offset, int numberOfSegments, float tension);
+        public void AddCurve(PointF[] points, float tension);
+        public void AddCurve(Point[] points);
+        public void AddCurve(Point[] points, int offset, int numberOfSegments, float tension);
+        public void AddCurve(Point[] points, float tension);
+        public void AddEllipse(Rectangle rect);
+        public void AddEllipse(RectangleF rect);
+        public void AddEllipse(int x, int y, int width, int height);
+        public void AddEllipse(float x, float y, float width, float height);
+        public void AddLine(Point pt1, Point pt2);
+        public void AddLine(PointF pt1, PointF pt2);
+        public void AddLine(int x1, int y1, int x2, int y2);
+        public void AddLine(float x1, float y1, float x2, float y2);
+        public void AddLines(PointF[] points);
+        public void AddLines(Point[] points);
+        public void AddPath(GraphicsPath addingPath, bool connect);
+        public void AddPie(Rectangle rect, float startAngle, float sweepAngle);
+        public void AddPie(int x, int y, int width, int height, float startAngle, float sweepAngle);
+        public void AddPie(float x, float y, float width, float height, float startAngle, float sweepAngle);
+        public void AddPolygon(PointF[] points);
+        public void AddPolygon(Point[] points);
+        public void AddRectangle(Rectangle rect);
+        public void AddRectangle(RectangleF rect);
+        public void AddRectangles(RectangleF[] rects);
+        public void AddRectangles(Rectangle[] rects);
+        public void AddString(string s, FontFamily family, int style, float emSize, Point origin, StringFormat format);
+        public void AddString(string s, FontFamily family, int style, float emSize, PointF origin, StringFormat format);
+        public void AddString(string s, FontFamily family, int style, float emSize, Rectangle layoutRect, StringFormat format);
+        public void AddString(string s, FontFamily family, int style, float emSize, RectangleF layoutRect, StringFormat format);
+        public void ClearMarkers();
+        public object Clone();
+        public void CloseAllFigures();
+        public void CloseFigure();
+        public void Dispose();
+        ~GraphicsPath();
+        public void Flatten();
+        public void Flatten(Matrix matrix);
+        public void Flatten(Matrix matrix, float flatness);
+        public RectangleF GetBounds();
+        public RectangleF GetBounds(Matrix matrix);
+        public RectangleF GetBounds(Matrix matrix, Pen pen);
+        public PointF GetLastPoint();
+        public bool IsOutlineVisible(Point point, Pen pen);
+        public bool IsOutlineVisible(Point pt, Pen pen, Graphics graphics);
+        public bool IsOutlineVisible(PointF point, Pen pen);
+        public bool IsOutlineVisible(PointF pt, Pen pen, Graphics graphics);
+        public bool IsOutlineVisible(int x, int y, Pen pen);
+        public bool IsOutlineVisible(int x, int y, Pen pen, Graphics graphics);
+        public bool IsOutlineVisible(float x, float y, Pen pen);
+        public bool IsOutlineVisible(float x, float y, Pen pen, Graphics graphics);
+        public bool IsVisible(Point point);
+        public bool IsVisible(Point pt, Graphics graphics);
+        public bool IsVisible(PointF point);
+        public bool IsVisible(PointF pt, Graphics graphics);
+        public bool IsVisible(int x, int y);
+        public bool IsVisible(int x, int y, Graphics graphics);
+        public bool IsVisible(float x, float y);
+        public bool IsVisible(float x, float y, Graphics graphics);
+        public void Reset();
+        public void Reverse();
+        public void SetMarkers();
+        public void StartFigure();
+        public void Transform(Matrix matrix);
+        public void Warp(PointF[] destPoints, RectangleF srcRect);
+        public void Warp(PointF[] destPoints, RectangleF srcRect, Matrix matrix);
+        public void Warp(PointF[] destPoints, RectangleF srcRect, Matrix matrix, WarpMode warpMode);
+        public void Warp(PointF[] destPoints, RectangleF srcRect, Matrix matrix, WarpMode warpMode, float flatness);
+        public void Widen(Pen pen);
+        public void Widen(Pen pen, Matrix matrix);
+        public void Widen(Pen pen, Matrix matrix, float flatness);
+    }
+    public sealed class GraphicsPathIterator : MarshalByRefObject, IDisposable {
+        public GraphicsPathIterator(GraphicsPath path);
+        public int Count { get; }
+        public int SubpathCount { get; }
+        public int CopyData(ref PointF[] points, ref byte[] types, int startIndex, int endIndex);
+        public void Dispose();
+        public int Enumerate(ref PointF[] points, ref byte[] types);
+        ~GraphicsPathIterator();
+        public bool HasCurve();
+        public int NextMarker(GraphicsPath path);
+        public int NextMarker(out int startIndex, out int endIndex);
+        public int NextPathType(out byte pathType, out int startIndex, out int endIndex);
+        public int NextSubpath(GraphicsPath path, out bool isClosed);
+        public int NextSubpath(out int startIndex, out int endIndex, out bool isClosed);
+        public void Rewind();
+    }
+    public sealed class GraphicsState : MarshalByRefObject
+    public sealed class HatchBrush : Brush {
+        public HatchBrush(HatchStyle hatchstyle, Color foreColor);
+        public HatchBrush(HatchStyle hatchstyle, Color foreColor, Color backColor);
+        public Color BackgroundColor { get; }
+        public Color ForegroundColor { get; }
+        public HatchStyle HatchStyle { get; }
+        public override object Clone();
+    }
+    public enum HatchStyle {
+        BackwardDiagonal = 3,
+        Cross = 4,
+        DarkDownwardDiagonal = 20,
+        DarkHorizontal = 29,
+        DarkUpwardDiagonal = 21,
+        DarkVertical = 28,
+        DashedDownwardDiagonal = 30,
+        DashedHorizontal = 32,
+        DashedUpwardDiagonal = 31,
+        DashedVertical = 33,
+        DiagonalBrick = 38,
+        DiagonalCross = 5,
+        Divot = 42,
+        DottedDiamond = 44,
+        DottedGrid = 43,
+        ForwardDiagonal = 2,
+        Horizontal = 0,
+        HorizontalBrick = 39,
+        LargeCheckerBoard = 50,
+        LargeConfetti = 35,
+        LargeGrid = 4,
+        LightDownwardDiagonal = 18,
+        LightHorizontal = 25,
+        LightUpwardDiagonal = 19,
+        LightVertical = 24,
+        Max = 4,
+        Min = 0,
+        NarrowHorizontal = 27,
+        NarrowVertical = 26,
+        OutlinedDiamond = 51,
+        Percent05 = 6,
+        Percent10 = 7,
+        Percent20 = 8,
+        Percent25 = 9,
+        Percent30 = 10,
+        Percent40 = 11,
+        Percent50 = 12,
+        Percent60 = 13,
+        Percent70 = 14,
+        Percent75 = 15,
+        Percent80 = 16,
+        Percent90 = 17,
+        Plaid = 41,
+        Shingle = 45,
+        SmallCheckerBoard = 49,
+        SmallConfetti = 34,
+        SmallGrid = 48,
+        SolidDiamond = 52,
+        Sphere = 47,
+        Trellis = 46,
+        Vertical = 1,
+        Wave = 37,
+        Weave = 40,
+        WideDownwardDiagonal = 22,
+        WideUpwardDiagonal = 23,
+        ZigZag = 36,
+    }
+    public enum InterpolationMode {
+        Bicubic = 4,
+        Bilinear = 3,
+        Default = 0,
+        High = 2,
+        HighQualityBicubic = 7,
+        HighQualityBilinear = 6,
+        Invalid = -1,
+        Low = 1,
+        NearestNeighbor = 5,
+    }
+    public sealed class LinearGradientBrush : Brush {
+        public LinearGradientBrush(Point point1, Point point2, Color color1, Color color2);
+        public LinearGradientBrush(PointF point1, PointF point2, Color color1, Color color2);
+        public LinearGradientBrush(Rectangle rect, Color color1, Color color2, LinearGradientMode linearGradientMode);
+        public LinearGradientBrush(Rectangle rect, Color color1, Color color2, float angle);
+        public LinearGradientBrush(Rectangle rect, Color color1, Color color2, float angle, bool isAngleScaleable);
+        public LinearGradientBrush(RectangleF rect, Color color1, Color color2, LinearGradientMode linearGradientMode);
+        public LinearGradientBrush(RectangleF rect, Color color1, Color color2, float angle);
+        public LinearGradientBrush(RectangleF rect, Color color1, Color color2, float angle, bool isAngleScaleable);
+        public Blend Blend { get; set; }
+        public bool GammaCorrection { get; set; }
+        public ColorBlend InterpolationColors { get; set; }
+        public Color[] LinearColors { get; set; }
+        public RectangleF Rectangle { get; }
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
+        public void SetBlendTriangularShape(float focus);
+        public void SetBlendTriangularShape(float focus, float scale);
+        public void SetSigmaBellShape(float focus);
+        public void SetSigmaBellShape(float focus, float scale);
+        public void TranslateTransform(float dx, float dy);
+        public void TranslateTransform(float dx, float dy, MatrixOrder order);
+    }
+    public enum LinearGradientMode {
+        BackwardDiagonal = 3,
+        ForwardDiagonal = 2,
+        Horizontal = 0,
+        Vertical = 1,
+    }
+    public enum LineCap {
+        AnchorMask = 240,
+        ArrowAnchor = 20,
+        Custom = 255,
+        DiamondAnchor = 19,
+        Flat = 0,
+        NoAnchor = 16,
+        Round = 2,
+        RoundAnchor = 18,
+        Square = 1,
+        SquareAnchor = 17,
+        Triangle = 3,
+    }
+    public enum LineJoin {
+        Bevel = 1,
+        Miter = 0,
+        MiterClipped = 3,
+        Round = 2,
+    }
+    public sealed class Matrix : MarshalByRefObject, IDisposable {
+        public Matrix();
+        public Matrix(Rectangle rect, Point[] plgpts);
+        public Matrix(RectangleF rect, PointF[] plgpts);
+        public Matrix(float m11, float m12, float m21, float m22, float dx, float dy);
+        public float[] Elements { get; }
+        public bool IsIdentity { get; }
+        public bool IsInvertible { get; }
+        public float OffsetX { get; }
+        public float OffsetY { get; }
+        public Matrix Clone();
+        public void Dispose();
+        public override bool Equals(object obj);
+        ~Matrix();
+        public override int GetHashCode();
+        public void Invert();
+        public void Multiply(Matrix matrix);
+        public void Multiply(Matrix matrix, MatrixOrder order);
+        public void Reset();
+        public void Rotate(float angle);
+        public void Rotate(float angle, MatrixOrder order);
+        public void RotateAt(float angle, PointF point);
+        public void RotateAt(float angle, PointF point, MatrixOrder order);
+        public void Scale(float scaleX, float scaleY);
+        public void Scale(float scaleX, float scaleY, MatrixOrder order);
+        public void Shear(float shearX, float shearY);
+        public void Shear(float shearX, float shearY, MatrixOrder order);
+        public void TransformPoints(PointF[] pts);
+        public void TransformPoints(Point[] pts);
+        public void TransformVectors(PointF[] pts);
+        public void TransformVectors(Point[] pts);
+        public void Translate(float offsetX, float offsetY);
+        public void Translate(float offsetX, float offsetY, MatrixOrder order);
+        public void VectorTransformPoints(Point[] pts);
+    }
+    public enum MatrixOrder {
+        Append = 1,
+        Prepend = 0,
+    }
+    public sealed class PathData {
+        public PathData();
+        public PointF[] Points { get; set; }
+        public byte[] Types { get; set; }
+    }
+    public sealed class PathGradientBrush : Brush {
+        public PathGradientBrush(GraphicsPath path);
+        public PathGradientBrush(PointF[] points);
+        public PathGradientBrush(PointF[] points, WrapMode wrapMode);
+        public PathGradientBrush(Point[] points);
+        public PathGradientBrush(Point[] points, WrapMode wrapMode);
+        public Blend Blend { get; set; }
+        public Color CenterColor { get; set; }
+        public PointF CenterPoint { get; set; }
+        public PointF FocusScales { get; set; }
+        public ColorBlend InterpolationColors { get; set; }
+        public RectangleF Rectangle { get; }
+        public Color[] SurroundColors { get; set; }
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
+        public void SetBlendTriangularShape(float focus);
+        public void SetBlendTriangularShape(float focus, float scale);
+        public void SetSigmaBellShape(float focus);
+        public void SetSigmaBellShape(float focus, float scale);
+        public void TranslateTransform(float dx, float dy);
+        public void TranslateTransform(float dx, float dy, MatrixOrder order);
+    }
+    public enum PathPointType {
+        Bezier = 3,
+        Bezier3 = 3,
+        CloseSubpath = 128,
+        DashMode = 16,
+        Line = 1,
+        PathMarker = 32,
+        PathTypeMask = 7,
+        Start = 0,
+    }
+    public enum PenAlignment {
+        Center = 0,
+        Inset = 1,
+        Left = 3,
+        Outset = 2,
+        Right = 4,
+    }
+    public enum PenType {
+        HatchFill = 1,
+        LinearGradient = 4,
+        PathGradient = 3,
+        SolidColor = 0,
+        TextureFill = 2,
+    }
+    public enum PixelOffsetMode {
+        Default = 0,
+        Half = 4,
+        HighQuality = 2,
+        HighSpeed = 1,
+        Invalid = -1,
+        None = 3,
+    }
+    public enum QualityMode {
+        Default = 0,
+        High = 2,
+        Invalid = -1,
+        Low = 1,
+    }
+    public sealed class RegionData {
+        public byte[] Data { get; set; }
+    }
+    public enum SmoothingMode {
+        AntiAlias = 4,
+        Default = 0,
+        HighQuality = 2,
+        HighSpeed = 1,
+        Invalid = -1,
+        None = 3,
+    }
+    public enum WarpMode {
+        Bilinear = 1,
+        Perspective = 0,
+    }
+    public enum WrapMode {
+        Clamp = 4,
+        Tile = 0,
+        TileFlipX = 1,
+        TileFlipXY = 3,
+        TileFlipY = 2,
+    }
+}
```

