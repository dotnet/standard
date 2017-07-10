# System.Windows.Forms.DataVisualization.Charting

``` diff
+namespace System.Windows.Forms.DataVisualization.Charting {
+    public abstract class Annotation : ChartNamedElement {
+        protected Annotation();
+        public virtual ContentAlignment Alignment { get; set; }
+        public virtual bool AllowAnchorMoving { get; set; }
+        public virtual bool AllowMoving { get; set; }
+        public virtual bool AllowPathEditing { get; set; }
+        public virtual bool AllowResizing { get; set; }
+        public virtual bool AllowSelecting { get; set; }
+        public virtual bool AllowTextEditing { get; set; }
+        public virtual ContentAlignment AnchorAlignment { get; set; }
+        public virtual DataPoint AnchorDataPoint { get; set; }
+        public virtual string AnchorDataPointName { get; set; }
+        public virtual double AnchorOffsetX { get; set; }
+        public virtual double AnchorOffsetY { get; set; }
+        public virtual double AnchorX { get; set; }
+        public virtual double AnchorY { get; set; }
+        public AnnotationGroup AnnotationGroup { get; }
+        public abstract string AnnotationType { get; }
+        public virtual Axis AxisX { get; set; }
+        public virtual string AxisXName { get; set; }
+        public virtual Axis AxisY { get; set; }
+        public virtual string AxisYName { get; set; }
+        public virtual Color BackColor { get; set; }
+        public virtual GradientStyle BackGradientStyle { get; set; }
+        public virtual ChartHatchStyle BackHatchStyle { get; set; }
+        public virtual Color BackSecondaryColor { get; set; }
+        public virtual double Bottom { get; set; }
+        public virtual string ClipToChartArea { get; set; }
+        public virtual Font Font { get; set; }
+        public virtual Color ForeColor { get; set; }
+        public virtual double Height { get; set; }
+        public virtual bool IsSelected { get; set; }
+        public virtual bool IsSizeAlwaysRelative { get; set; }
+        public virtual Color LineColor { get; set; }
+        public virtual ChartDashStyle LineDashStyle { get; set; }
+        public virtual int LineWidth { get; set; }
+        public override string Name { get; set; }
+        public virtual double Right { get; set; }
+        public virtual Color ShadowColor { get; set; }
+        public virtual int ShadowOffset { get; set; }
+        public AnnotationSmartLabelStyle SmartLabelStyle { get; set; }
+        public virtual TextStyle TextStyle { get; set; }
+        public virtual string ToolTip { get; set; }
+        public virtual bool Visible { get; set; }
+        public virtual double Width { get; set; }
+        public virtual double X { get; set; }
+        public virtual double Y { get; set; }
+        public virtual string YAxisName { get; set; }
+        public virtual void BeginPlacement();
+        public virtual void BringToFront();
+        protected override void Dispose(bool disposing);
+        public virtual void EndPlacement();
+        public virtual void ResizeToContent();
+        public virtual void SendToBack();
+        public void SetAnchor(DataPoint dataPoint);
+        public void SetAnchor(DataPoint dataPoint1, DataPoint dataPoint2);
+    }
+    public class AnnotationCollection : ChartNamedElementCollection<Annotation> {
+        public override Annotation FindByName(string name);
+    }
+    public class AnnotationGroup : Annotation {
+        public AnnotationGroup();
+        public override ContentAlignment Alignment { get; set; }
+        public override bool AllowAnchorMoving { get; set; }
+        public override bool AllowMoving { get; set; }
+        public override bool AllowPathEditing { get; set; }
+        public override bool AllowResizing { get; set; }
+        public override bool AllowSelecting { get; set; }
+        public override bool AllowTextEditing { get; set; }
+        public AnnotationCollection Annotations { get; }
+        public override string AnnotationType { get; }
+        public override Color BackColor { get; set; }
+        public override GradientStyle BackGradientStyle { get; set; }
+        public override ChartHatchStyle BackHatchStyle { get; set; }
+        public override Color BackSecondaryColor { get; set; }
+        public override string ClipToChartArea { get; set; }
+        public override Font Font { get; set; }
+        public override Color ForeColor { get; set; }
+        public override bool IsSelected { get; set; }
+        public override bool IsSizeAlwaysRelative { get; set; }
+        public override Color LineColor { get; set; }
+        public override ChartDashStyle LineDashStyle { get; set; }
+        public override int LineWidth { get; set; }
+        public override Color ShadowColor { get; set; }
+        public override int ShadowOffset { get; set; }
+        public override TextStyle TextStyle { get; set; }
+        public override bool Visible { get; set; }
+        protected override void Dispose(bool disposing);
+    }
+    public class AnnotationPathPoint : ChartElement {
+        public AnnotationPathPoint();
+        public AnnotationPathPoint(float x, float y);
+        public AnnotationPathPoint(float x, float y, byte type);
+        public string Name { get; }
+        public byte PointType { get; set; }
+        public float X { get; set; }
+        public float Y { get; set; }
+    }
+    public class AnnotationPathPointCollection : ChartElementCollection<AnnotationPathPoint> {
+        public AnnotationPathPointCollection(PolylineAnnotation annotation);
+        protected override void Dispose(bool disposing);
+        public override void Invalidate();
+    }
+    public class AnnotationPositionChangingEventArgs : EventArgs {
+        public AnnotationPositionChangingEventArgs();
+        public Annotation Annotation { get; set; }
+        public PointF NewAnchorLocation { get; set; }
+        public double NewAnchorLocationX { get; set; }
+        public double NewAnchorLocationY { get; set; }
+        public double NewLocationX { get; set; }
+        public double NewLocationY { get; set; }
+        public RectangleF NewPosition { get; set; }
+        public double NewSizeHeight { get; set; }
+        public double NewSizeWidth { get; set; }
+    }
+    public class AnnotationSmartLabelStyle : SmartLabelStyle {
+        public AnnotationSmartLabelStyle();
+        public AnnotationSmartLabelStyle(object chartElement);
+        public override Color CalloutBackColor { get; set; }
+        public override LineAnchorCapStyle CalloutLineAnchorCapStyle { get; set; }
+        public override Color CalloutLineColor { get; set; }
+        public override ChartDashStyle CalloutLineDashStyle { get; set; }
+        public override int CalloutLineWidth { get; set; }
+        public override LabelCalloutStyle CalloutStyle { get; set; }
+    }
+    public class AnovaResult {
+        public AnovaResult();
+        public double DegreeOfFreedomBetweenGroups { get; }
+        public double DegreeOfFreedomTotal { get; }
+        public double DegreeOfFreedomWithinGroups { get; }
+        public double FCriticalValue { get; }
+        public double FRatio { get; }
+        public double MeanSquareVarianceBetweenGroups { get; }
+        public double MeanSquareVarianceWithinGroups { get; }
+        public double SumOfSquaresBetweenGroups { get; }
+        public double SumOfSquaresTotal { get; }
+        public double SumOfSquaresWithinGroups { get; }
+    }
+    public enum AntiAliasingStyles {
+        All = 3,
+        Graphics = 2,
+        None = 0,
+        Text = 1,
+    }
+    public enum AreaAlignmentOrientations {
+        All = 3,
+        Horizontal = 2,
+        None = 0,
+        Vertical = 1,
+    }
+    public enum AreaAlignmentStyles {
+        All = 15,
+        AxesView = 4,
+        Cursor = 8,
+        None = 0,
+        PlotPosition = 2,
+        Position = 1,
+    }
+    public class ArrowAnnotation : Annotation {
+        public ArrowAnnotation();
+        public override ContentAlignment AnchorAlignment { get; set; }
+        public override string AnnotationType { get; }
+        public virtual int ArrowSize { get; set; }
+        public virtual ArrowStyle ArrowStyle { get; set; }
+    }
+    public enum ArrowStyle {
+        DoubleArrow = 1,
+        Simple = 0,
+        Tailed = 2,
+    }
+    public class Axis : ChartNamedElement {
+        public Axis();
+        public Axis(ChartArea chartArea, AxisName axisTypeName);
+        public AxisArrowStyle ArrowStyle { get; set; }
+        public virtual AxisName AxisName { get; }
+        public virtual double Crossing { get; set; }
+        public CustomLabelsCollection CustomLabels { get; }
+        public AxisEnabled Enabled { get; set; }
+        public Color InterlacedColor { get; set; }
+        public double Interval { get; set; }
+        public IntervalAutoMode IntervalAutoMode { get; set; }
+        public double IntervalOffset { get; set; }
+        public DateTimeIntervalType IntervalOffsetType { get; set; }
+        public DateTimeIntervalType IntervalType { get; set; }
+        public bool IsInterlaced { get; set; }
+        public bool IsLabelAutoFit { get; set; }
+        public bool IsLogarithmic { get; set; }
+        public bool IsMarginVisible { get; set; }
+        public virtual bool IsMarksNextToAxis { get; set; }
+        public bool IsReversed { get; set; }
+        public bool IsStartedFromZero { get; set; }
+        public int LabelAutoFitMaxFontSize { get; set; }
+        public int LabelAutoFitMinFontSize { get; set; }
+        public LabelAutoFitStyles LabelAutoFitStyle { get; set; }
+        public LabelStyle LabelStyle { get; set; }
+        public Color LineColor { get; set; }
+        public ChartDashStyle LineDashStyle { get; set; }
+        public int LineWidth { get; set; }
+        public double LogarithmBase { get; set; }
+        public Grid MajorGrid { get; set; }
+        public TickMark MajorTickMark { get; set; }
+        public double Maximum { get; set; }
+        public float MaximumAutoSize { get; set; }
+        public double Minimum { get; set; }
+        public Grid MinorGrid { get; set; }
+        public TickMark MinorTickMark { get; set; }
+        public override string Name { get; set; }
+        public virtual AxisScaleBreakStyle ScaleBreakStyle { get; set; }
+        public AxisScaleView ScaleView { get; set; }
+        public AxisScrollBar ScrollBar { get; set; }
+        public StripLinesCollection StripLines { get; }
+        public TextOrientation TextOrientation { get; set; }
+        public string Title { get; set; }
+        public StringAlignment TitleAlignment { get; set; }
+        public Font TitleFont { get; set; }
+        public Color TitleForeColor { get; set; }
+        public string ToolTip { get; set; }
+        protected override void Dispose(bool disposing);
+        public double GetPosition(double axisValue);
+        public double PixelPositionToValue(double position);
+        public double PositionToValue(double position);
+        public void RoundAxisValues();
+        public double ValueToPixelPosition(double axisValue);
+        public double ValueToPosition(double axisValue);
+    }
+    public enum AxisArrowStyle {
+        Lines = 3,
+        None = 0,
+        SharpTriangle = 2,
+        Triangle = 1,
+    }
+    public enum AxisEnabled {
+        Auto = 0,
+        False = 2,
+        True = 1,
+    }
+    public enum AxisName {
+        X = 0,
+        X2 = 2,
+        Y = 1,
+        Y2 = 3,
+    }
+    public class AxisScaleBreakStyle {
+        public AxisScaleBreakStyle();
+        public BreakLineStyle BreakLineStyle { get; set; }
+        public int CollapsibleSpaceThreshold { get; set; }
+        public bool Enabled { get; set; }
+        public Color LineColor { get; set; }
+        public ChartDashStyle LineDashStyle { get; set; }
+        public int LineWidth { get; set; }
+        public int MaxNumberOfBreaks { get; set; }
+        public double Spacing { get; set; }
+        public StartFromZero StartFromZero { get; set; }
+    }
+    public class AxisScaleView {
+        public AxisScaleView();
+        public bool IsZoomed { get; }
+        public double MinSize { get; set; }
+        public DateTimeIntervalType MinSizeType { get; set; }
+        public double Position { get; set; }
+        public double Size { get; set; }
+        public DateTimeIntervalType SizeType { get; set; }
+        public double SmallScrollMinSize { get; set; }
+        public DateTimeIntervalType SmallScrollMinSizeType { get; set; }
+        public double SmallScrollSize { get; set; }
+        public DateTimeIntervalType SmallScrollSizeType { get; set; }
+        public double ViewMaximum { get; }
+        public double ViewMinimum { get; }
+        public bool Zoomable { get; set; }
+        public void Scroll(DateTime newPosition);
+        public void Scroll(double newPosition);
+        public void Scroll(ScrollType scrollType);
+        public void Zoom(double viewStart, double viewEnd);
+        public void Zoom(double viewPosition, double viewSize, DateTimeIntervalType viewSizeType);
+        public void Zoom(double viewPosition, double viewSize, DateTimeIntervalType viewSizeType, bool saveState);
+        public void ZoomReset();
+        public void ZoomReset(int numberOfViews);
+    }
+    public class AxisScrollBar : IDisposable {
+        public AxisScrollBar();
+        public Axis Axis { get; }
+        public Color BackColor { get; set; }
+        public Color ButtonColor { get; set; }
+        public ScrollBarButtonStyles ButtonStyle { get; set; }
+        public ChartArea ChartArea { get; }
+        public bool Enabled { get; set; }
+        public bool IsPositionedInside { get; set; }
+        public bool IsVisible { get; }
+        public Color LineColor { get; set; }
+        public double Size { get; set; }
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+    }
+    public enum AxisType {
+        Primary = 0,
+        Secondary = 1,
+    }
+    public class Border3DAnnotation : RectangleAnnotation {
+        public Border3DAnnotation();
+        public override string AnnotationType { get; }
+        public BorderSkin BorderSkin { get; set; }
+    }
+    public class BorderSkin : ChartElement {
+        public BorderSkin();
+        public Color BackColor { get; set; }
+        public GradientStyle BackGradientStyle { get; set; }
+        public ChartHatchStyle BackHatchStyle { get; set; }
+        public string BackImage { get; set; }
+        public ChartImageAlignmentStyle BackImageAlignment { get; set; }
+        public Color BackImageTransparentColor { get; set; }
+        public ChartImageWrapMode BackImageWrapMode { get; set; }
+        public Color BackSecondaryColor { get; set; }
+        public Color BorderColor { get; set; }
+        public ChartDashStyle BorderDashStyle { get; set; }
+        public int BorderWidth { get; set; }
+        public Color PageColor { get; set; }
+        public BorderSkinStyle SkinStyle { get; set; }
+    }
+    public enum BorderSkinStyle {
+        Emboss = 1,
+        FrameThin1 = 4,
+        FrameThin2 = 5,
+        FrameThin3 = 6,
+        FrameThin4 = 7,
+        FrameThin5 = 8,
+        FrameThin6 = 9,
+        FrameTitle1 = 10,
+        FrameTitle2 = 11,
+        FrameTitle3 = 12,
+        FrameTitle4 = 13,
+        FrameTitle5 = 14,
+        FrameTitle6 = 15,
+        FrameTitle7 = 16,
+        FrameTitle8 = 17,
+        None = 0,
+        Raised = 2,
+        Sunken = 3,
+    }
+    public enum BreakLineStyle {
+        None = 0,
+        Ragged = 3,
+        Straight = 1,
+        Wave = 2,
+    }
+    public class CalloutAnnotation : TextAnnotation {
+        public CalloutAnnotation();
+        public override ContentAlignment AnchorAlignment { get; set; }
+        public override double AnchorOffsetX { get; set; }
+        public override double AnchorOffsetY { get; set; }
+        public override string AnnotationType { get; }
+        public override Color BackColor { get; set; }
+        public override GradientStyle BackGradientStyle { get; set; }
+        public override ChartHatchStyle BackHatchStyle { get; set; }
+        public override Color BackSecondaryColor { get; set; }
+        public virtual LineAnchorCapStyle CalloutAnchorCap { get; set; }
+        public virtual CalloutStyle CalloutStyle { get; set; }
+        public override Color LineColor { get; set; }
+        public override ChartDashStyle LineDashStyle { get; set; }
+        public override int LineWidth { get; set; }
+    }
+    public enum CalloutStyle {
+        Borderline = 1,
+        Cloud = 2,
+        Ellipse = 5,
+        Perspective = 6,
+        Rectangle = 3,
+        RoundedRectangle = 4,
+        SimpleLine = 0,
+    }
+    public class Chart : Control, IDisposable, ISupportInitialize {
+        public Chart();
+        public AnnotationCollection Annotations { get; }
+        public AntiAliasingStyles AntiAliasing { get; set; }
+        public override Color BackColor { get; set; }
+        public GradientStyle BackGradientStyle { get; set; }
+        public override Image BackgroundImage { get; set; }
+        public ChartHatchStyle BackHatchStyle { get; set; }
+        public string BackImage { get; set; }
+        public ChartImageAlignmentStyle BackImageAlignment { get; set; }
+        public Color BackImageTransparentColor { get; set; }
+        public ChartImageWrapMode BackImageWrapMode { get; set; }
+        public Color BackSecondaryColor { get; set; }
+        public Color BorderColor { get; set; }
+        public ChartDashStyle BorderDashStyle { get; set; }
+        public Color BorderlineColor { get; set; }
+        public ChartDashStyle BorderlineDashStyle { get; set; }
+        public int BorderlineWidth { get; set; }
+        public BorderSkin BorderSkin { get; set; }
+        public int BorderWidth { get; set; }
+        public string BuildNumber { get; }
+        public ChartAreaCollection ChartAreas { get; }
+        public DataManipulator DataManipulator { get; }
+        public object DataSource { get; set; }
+        protected override Size DefaultSize { get; }
+        public new Font Font { get; set; }
+        public override Color ForeColor { get; set; }
+        public NamedImagesCollection Images { get; }
+        public bool IsSoftShadows { get; set; }
+        public LegendCollection Legends { get; }
+        public ChartColorPalette Palette { get; set; }
+        public Color[] PaletteCustomColors { get; set; }
+        public PrintingManager Printing { get; }
+        public double RenderingDpiX { get; set; }
+        public double RenderingDpiY { get; set; }
+        public ChartSerializer Serializer { get; }
+        public SeriesCollection Series { get; }
+        public new Size Size { get; set; }
+        public bool SuppressExceptions { get; set; }
+        public TextAntiAliasingQuality TextAntiAliasingQuality { get; set; }
+        public TitleCollection Titles { get; }
+        public event EventHandler AnnotationPlaced;
+        public event EventHandler AnnotationPositionChanged;
+        public event EventHandler<AnnotationPositionChangingEventArgs> AnnotationPositionChanging;
+        public event EventHandler AnnotationSelectionChanged;
+        public event EventHandler AnnotationTextChanged;
+        public event EventHandler<ScrollBarEventArgs> AxisScrollBarClicked;
+        public event EventHandler<ViewEventArgs> AxisViewChanged;
+        public event EventHandler<ViewEventArgs> AxisViewChanging;
+        public event EventHandler<CursorEventArgs> CursorPositionChanged;
+        public event EventHandler<CursorEventArgs> CursorPositionChanging;
+        public event EventHandler Customize;
+        public event EventHandler<CustomizeLegendEventArgs> CustomizeLegend;
+        public event EventHandler<FormatNumberEventArgs> FormatNumber;
+        public event EventHandler<ToolTipEventArgs> GetToolTipText;
+        public event EventHandler<ChartPaintEventArgs> PostPaint;
+        public event EventHandler<ChartPaintEventArgs> PrePaint;
+        public event EventHandler<CursorEventArgs> SelectionRangeChanged;
+        public event EventHandler<CursorEventArgs> SelectionRangeChanging;
+        public void AlignDataPointsByAxisLabel();
+        public void AlignDataPointsByAxisLabel(string series);
+        public void AlignDataPointsByAxisLabel(string series, PointSortOrder sortingOrder);
+        public void AlignDataPointsByAxisLabel(PointSortOrder sortingOrder);
+        public void ApplyPaletteColors();
+        public void BeginInit();
+        protected override AccessibleObject CreateAccessibilityInstance();
+        public void DataBind();
+        public void DataBindCrossTable(IEnumerable dataSource, string seriesGroupByField, string xField, string yFields, string otherFields);
+        public void DataBindCrossTable(IEnumerable dataSource, string seriesGroupByField, string xField, string yFields, string otherFields, PointSortOrder sortingOrder);
+        public void DataBindTable(IEnumerable dataSource);
+        public void DataBindTable(IEnumerable dataSource, string xField);
+        protected override void Dispose(bool disposing);
+        public void EndInit();
+        public ChartElementOutline GetChartElementOutline(object element, ChartElementType elementType);
+        public new object GetService(Type serviceType);
+        public HitTestResult HitTest(int x, int y);
+        public HitTestResult HitTest(int x, int y, bool ignoreTransparent);
+        public HitTestResult[] HitTest(int x, int y, bool ignoreTransparent, params ChartElementType[] requestedElement);
+        public HitTestResult HitTest(int x, int y, ChartElementType requestedElement);
+        public new void Invalidate();
+        public new void Invalidate(Rectangle rectangle);
+        public void LoadTemplate(Stream stream);
+        public void LoadTemplate(string name);
+        protected override void OnCursorChanged(EventArgs e);
+        protected virtual void OnCustomize();
+        protected virtual void OnCustomizeLegend(LegendItemsCollection legendItems, string legendName);
+        protected override void OnDoubleClick(EventArgs e);
+        protected virtual void OnFormatNumber(FormatNumberEventArgs e);
+        protected override void OnLocationChanged(EventArgs e);
+        protected override void OnMouseDown(MouseEventArgs e);
+        protected override void OnMouseMove(MouseEventArgs e);
+        protected override void OnMouseUp(MouseEventArgs e);
+        protected override void OnPaint(PaintEventArgs e);
+        protected override void OnPaintBackground(PaintEventArgs pevent);
+        protected virtual void OnPostPaint(ChartPaintEventArgs e);
+        protected virtual void OnPrePaint(ChartPaintEventArgs e);
+        protected override void OnResize(EventArgs e);
+        protected override void OnRightToLeftChanged(EventArgs e);
+        protected override void OnSystemColorsChanged(EventArgs e);
+        public override void Refresh();
+        public void ResetAutoValues();
+        public void SaveImage(Stream imageStream, ImageFormat format);
+        public void SaveImage(Stream imageStream, ChartImageFormat format);
+        public void SaveImage(string imageFileName, ImageFormat format);
+        public void SaveImage(string imageFileName, ChartImageFormat format);
+        public void UpdateAnnotations();
+        public void UpdateCursor();
+    }
+    public class ChartArea : ChartNamedElement {
+        public ChartArea();
+        public ChartArea(string name);
+        public AreaAlignmentOrientations AlignmentOrientation { get; set; }
+        public AreaAlignmentStyles AlignmentStyle { get; set; }
+        public string AlignWithChartArea { get; set; }
+        public ChartArea3DStyle Area3DStyle { get; set; }
+        public Axis[] Axes { get; set; }
+        public Axis AxisX { get; set; }
+        public Axis AxisX2 { get; set; }
+        public Axis AxisY { get; set; }
+        public Axis AxisY2 { get; set; }
+        public Color BackColor { get; set; }
+        public GradientStyle BackGradientStyle { get; set; }
+        public ChartHatchStyle BackHatchStyle { get; set; }
+        public string BackImage { get; set; }
+        public ChartImageAlignmentStyle BackImageAlignment { get; set; }
+        public Color BackImageTransparentColor { get; set; }
+        public ChartImageWrapMode BackImageWrapMode { get; set; }
+        public Color BackSecondaryColor { get; set; }
+        public Color BorderColor { get; set; }
+        public ChartDashStyle BorderDashStyle { get; set; }
+        public int BorderWidth { get; set; }
+        public Cursor CursorX { get; set; }
+        public Cursor CursorY { get; set; }
+        public ElementPosition InnerPlotPosition { get; set; }
+        public bool IsSameFontSizeForAllAxes { get; set; }
+        public override string Name { get; set; }
+        public ElementPosition Position { get; set; }
+        public Color ShadowColor { get; set; }
+        public int ShadowOffset { get; set; }
+        public virtual bool Visible { get; set; }
+        protected override void Dispose(bool disposing);
+        public float GetSeriesDepth(Series series);
+        public float GetSeriesZPosition(Series series);
+        public void RecalculateAxesScale();
+        public void TransformPoints(Point3D[] points);
+    }
+    public class ChartArea3DStyle {
+        public ChartArea3DStyle();
+        public ChartArea3DStyle(ChartArea chartArea);
+        public bool Enable3D { get; set; }
+        public int Inclination { get; set; }
+        public bool IsClustered { get; set; }
+        public bool IsRightAngleAxes { get; set; }
+        public LightStyle LightStyle { get; set; }
+        public int Perspective { get; set; }
+        public int PointDepth { get; set; }
+        public int PointGapDepth { get; set; }
+        public int Rotation { get; set; }
+        public int WallWidth { get; set; }
+    }
+    public class ChartAreaCollection : ChartNamedElementCollection<ChartArea> {
+        public ChartArea Add(string name);
+    }
+    public enum ChartColorPalette {
+        Berry = 8,
+        Bright = 1,
+        BrightPastel = 12,
+        Chocolate = 9,
+        EarthTones = 6,
+        Excel = 3,
+        Fire = 10,
+        Grayscale = 2,
+        Light = 4,
+        None = 0,
+        Pastel = 5,
+        SeaGreen = 11,
+        SemiTransparent = 7,
+    }
+    public enum ChartDashStyle {
+        Dash = 1,
+        DashDot = 2,
+        DashDotDot = 3,
+        Dot = 4,
+        NotSet = 0,
+        Solid = 5,
+    }
+    public abstract class ChartElement : IChartElement, IDisposable {
+        protected ChartElement();
+        public object Tag { get; set; }
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public override string ToString();
+    }
+    public abstract class ChartElementCollection<T> : Collection<T>, IChartElement, IDisposable where T : ChartElement {
+        protected override void ClearItems();
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        protected override void InsertItem(int index, T item);
+        public virtual void Invalidate();
+        protected override void RemoveItem(int index);
+        public virtual void ResumeUpdates();
+        protected override void SetItem(int index, T item);
+        public virtual void SuspendUpdates();
+    }
+    public class ChartElementOutline : IDisposable {
+        public ReadOnlyCollection<PointF> Markers { get; internal set; }
+        public GraphicsPath OutlinePath { get; internal set; }
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+    }
+    public enum ChartElementType {
+        Annotation = 22,
+        Axis = 3,
+        AxisLabelImage = 7,
+        AxisLabels = 8,
+        AxisTitle = 9,
+        DataPoint = 16,
+        DataPointLabel = 17,
+        Gridlines = 5,
+        LegendArea = 18,
+        LegendHeader = 20,
+        LegendItem = 21,
+        LegendTitle = 19,
+        Nothing = 0,
+        PlottingArea = 2,
+        ScrollBarLargeDecrement = 13,
+        ScrollBarLargeIncrement = 14,
+        ScrollBarSmallDecrement = 11,
+        ScrollBarSmallIncrement = 12,
+        ScrollBarThumbTracker = 10,
+        ScrollBarZoomReset = 15,
+        StripLines = 6,
+        TickMarks = 4,
+        Title = 1,
+    }
+    public class ChartGraphics : ChartElement {
+        public Graphics Graphics { get; set; }
+        protected override void Dispose(bool disposing);
+        public PointF GetAbsolutePoint(PointF point);
+        public RectangleF GetAbsoluteRectangle(RectangleF rectangle);
+        public SizeF GetAbsoluteSize(SizeF size);
+        public double GetPositionFromAxis(string chartAreaName, AxisName axis, double axisValue);
+        public PointF GetRelativePoint(PointF point);
+        public RectangleF GetRelativeRectangle(RectangleF rectangle);
+        public SizeF GetRelativeSize(SizeF size);
+    }
+    public enum ChartHatchStyle {
+        BackwardDiagonal = 1,
+        Cross = 2,
+        DarkDownwardDiagonal = 3,
+        DarkHorizontal = 4,
+        DarkUpwardDiagonal = 5,
+        DarkVertical = 6,
+        DashedDownwardDiagonal = 7,
+        DashedHorizontal = 8,
+        DashedUpwardDiagonal = 9,
+        DashedVertical = 10,
+        DiagonalBrick = 11,
+        DiagonalCross = 12,
+        Divot = 13,
+        DottedDiamond = 14,
+        DottedGrid = 15,
+        ForwardDiagonal = 16,
+        Horizontal = 17,
+        HorizontalBrick = 18,
+        LargeCheckerBoard = 19,
+        LargeConfetti = 20,
+        LargeGrid = 21,
+        LightDownwardDiagonal = 22,
+        LightHorizontal = 23,
+        LightUpwardDiagonal = 24,
+        LightVertical = 25,
+        NarrowHorizontal = 26,
+        NarrowVertical = 27,
+        None = 0,
+        OutlinedDiamond = 28,
+        Percent05 = 29,
+        Percent10 = 30,
+        Percent20 = 31,
+        Percent25 = 32,
+        Percent30 = 33,
+        Percent40 = 34,
+        Percent50 = 35,
+        Percent60 = 36,
+        Percent70 = 37,
+        Percent75 = 38,
+        Percent80 = 39,
+        Percent90 = 40,
+        Plaid = 41,
+        Shingle = 42,
+        SmallCheckerBoard = 43,
+        SmallConfetti = 44,
+        SmallGrid = 45,
+        SolidDiamond = 46,
+        Sphere = 47,
+        Trellis = 48,
+        Vertical = 49,
+        Wave = 50,
+        Weave = 51,
+        WideDownwardDiagonal = 52,
+        WideUpwardDiagonal = 53,
+        ZigZag = 54,
+    }
+    public enum ChartImageAlignmentStyle {
+        Bottom = 5,
+        BottomLeft = 6,
+        BottomRight = 4,
+        Center = 8,
+        Left = 7,
+        Right = 3,
+        Top = 1,
+        TopLeft = 0,
+        TopRight = 2,
+    }
+    public enum ChartImageFormat {
+        Bmp = 2,
+        Emf = 5,
+        EmfDual = 6,
+        EmfPlus = 7,
+        Gif = 4,
+        Jpeg = 0,
+        Png = 1,
+        Tiff = 3,
+    }
+    public enum ChartImageWrapMode {
+        Scaled = 4,
+        Tile = 0,
+        TileFlipX = 1,
+        TileFlipXY = 3,
+        TileFlipY = 2,
+        Unscaled = 100,
+    }
+    public abstract class ChartNamedElement : ChartElement {
+        protected ChartNamedElement();
+        protected ChartNamedElement(string name);
+        public virtual string Name { get; set; }
+    }
+    public abstract class ChartNamedElementCollection<T> : ChartElementCollection<T>, INameController where T : ChartNamedElement {
+        protected virtual string NamePrefix { get; }
+        public T this[string name] { get; set; }
+        public virtual T FindByName(string name);
+        public int IndexOf(string name);
+        protected override void InsertItem(int index, T item);
+        public virtual bool IsUniqueName(string name);
+        public virtual string NextUniqueName();
+        protected override void RemoveItem(int index);
+        protected override void SetItem(int index, T item);
+    }
+    public class ChartPaintEventArgs : EventArgs {
+        public Chart Chart { get; }
+        public object ChartElement { get; }
+        public ChartGraphics ChartGraphics { get; }
+        public ElementPosition Position { get; }
+    }
+    public class ChartSerializer {
+        public SerializationContents Content { get; set; }
+        public SerializationFormat Format { get; set; }
+        public bool IsResetWhenLoading { get; set; }
+        public bool IsTemplateMode { get; set; }
+        public bool IsUnknownAttributeIgnored { get; set; }
+        public string NonSerializableContent { get; set; }
+        public string SerializableContent { get; set; }
+        protected string GetContentString(SerializationContents content, bool serializable);
+        public void Load(Stream stream);
+        public void Load(TextReader reader);
+        public void Load(string fileName);
+        public void Load(XmlReader reader);
+        public void Reset();
+        public void Save(Stream stream);
+        public void Save(TextWriter writer);
+        public void Save(string fileName);
+        public void Save(XmlWriter writer);
+    }
+    public enum ChartValueType {
+        Auto = 0,
+        Date = 9,
+        DateTime = 8,
+        DateTimeOffset = 11,
+        Double = 1,
+        Int32 = 3,
+        Int64 = 4,
+        Single = 2,
+        String = 7,
+        Time = 10,
+        UInt32 = 5,
+        UInt64 = 6,
+    }
+    public enum CompareMethod {
+        EqualTo = 2,
+        LessThan = 1,
+        LessThanOrEqualTo = 4,
+        MoreThan = 0,
+        MoreThanOrEqualTo = 3,
+        NotEqualTo = 5,
+    }
+    public class Cursor : IDisposable {
+        public Cursor();
+        public bool AutoScroll { get; set; }
+        public AxisType AxisType { get; set; }
+        public double Interval { get; set; }
+        public double IntervalOffset { get; set; }
+        public DateTimeIntervalType IntervalOffsetType { get; set; }
+        public DateTimeIntervalType IntervalType { get; set; }
+        public bool IsUserEnabled { get; set; }
+        public bool IsUserSelectionEnabled { get; set; }
+        public Color LineColor { get; set; }
+        public ChartDashStyle LineDashStyle { get; set; }
+        public int LineWidth { get; set; }
+        public double Position { get; set; }
+        public Color SelectionColor { get; set; }
+        public double SelectionEnd { get; set; }
+        public double SelectionStart { get; set; }
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        public void SetCursorPixelPosition(PointF point, bool roundToBoundary);
+        public void SetCursorPosition(double newPosition);
+        public void SetSelectionPixelPosition(PointF startPoint, PointF endPoint, bool roundToBoundary);
+        public void SetSelectionPosition(double newStart, double newEnd);
+    }
+    public class CursorEventArgs : EventArgs {
+        public CursorEventArgs(ChartArea chartArea, Axis axis, double newPosition);
+        public CursorEventArgs(ChartArea chartArea, Axis axis, double newSelectionStart, double newSelectionEnd);
+        public Axis Axis { get; }
+        public ChartArea ChartArea { get; }
+        public double NewPosition { get; set; }
+        public double NewSelectionEnd { get; set; }
+        public double NewSelectionStart { get; set; }
+    }
+    public class CustomizeLegendEventArgs : EventArgs {
+        public CustomizeLegendEventArgs(LegendItemsCollection legendItems);
+        public CustomizeLegendEventArgs(LegendItemsCollection legendItems, string legendName);
+        public LegendItemsCollection LegendItems { get; }
+        public string LegendName { get; }
+    }
+    public class CustomLabel : ChartNamedElement {
+        public CustomLabel();
+        public CustomLabel(double fromPosition, double toPosition, string text, int labelRow, LabelMarkStyle markStyle);
+        public CustomLabel(double fromPosition, double toPosition, string text, int labelRow, LabelMarkStyle markStyle, GridTickTypes gridTick);
+        public Axis Axis { get; }
+        public Color ForeColor { get; set; }
+        public double FromPosition { get; set; }
+        public GridTickTypes GridTicks { get; set; }
+        public string Image { get; set; }
+        public Color ImageTransparentColor { get; set; }
+        public LabelMarkStyle LabelMark { get; set; }
+        public Color MarkColor { get; set; }
+        public override string Name { get; set; }
+        public int RowIndex { get; set; }
+        public string Text { get; set; }
+        public string ToolTip { get; set; }
+        public double ToPosition { get; set; }
+        public CustomLabel Clone();
+    }
+    public class CustomLabelsCollection : ChartElementCollection<CustomLabel> {
+        public CustomLabel Add(double fromPosition, double toPosition, string text);
+        public CustomLabel Add(double fromPosition, double toPosition, string text, int rowIndex, LabelMarkStyle markStyle);
+        public CustomLabel Add(double fromPosition, double toPosition, string text, int rowIndex, LabelMarkStyle markStyle, GridTickTypes gridTick);
+        public void Add(double labelsStep, DateTimeIntervalType intervalType);
+        public void Add(double labelsStep, DateTimeIntervalType intervalType, double min, double max, string format, int rowIndex, LabelMarkStyle markStyle);
+        public void Add(double labelsStep, DateTimeIntervalType intervalType, string format);
+        public void Add(double labelsStep, DateTimeIntervalType intervalType, string format, int rowIndex, LabelMarkStyle markStyle);
+    }
+    public class CustomProperties
+    public class DataFormula {
+        public DataFormula();
+        public bool IsEmptyPointIgnored { get; set; }
+        public bool IsStartFromFirst { get; set; }
+        public StatisticFormula Statistics { get; }
+        public void CopySeriesValues(string inputSeries, string outputSeries);
+        public void FinancialFormula(FinancialFormula formulaName, string inputSeries);
+        public void FinancialFormula(FinancialFormula formulaName, string inputSeries, string outputSeries);
+        public void FinancialFormula(FinancialFormula formulaName, string parameters, string inputSeries, string outputSeries);
+        public void FinancialFormula(FinancialFormula formulaName, string parameters, Series inputSeries, Series outputSeries);
+        public void FinancialFormula(FinancialFormula formulaName, Series inputSeries);
+        public void FinancialFormula(FinancialFormula formulaName, Series inputSeries, Series outputSeries);
+    }
+    public class DataManipulator : DataFormula {
+        public DataManipulator();
+        public bool FilterMatchedPoints { get; set; }
+        public bool FilterSetEmptyPoints { get; set; }
+        public DataSet ExportSeriesValues();
+        public DataSet ExportSeriesValues(string seriesNames);
+        public DataSet ExportSeriesValues(Series series);
+        public void Filter(CompareMethod compareMethod, double compareValue, string inputSeriesNames);
+        public void Filter(CompareMethod compareMethod, double compareValue, string inputSeriesNames, string outputSeriesNames);
+        public void Filter(CompareMethod compareMethod, double compareValue, string inputSeriesNames, string outputSeriesNames, string usingValue);
+        public void Filter(CompareMethod compareMethod, double compareValue, Series inputSeries);
+        public void Filter(CompareMethod compareMethod, double compareValue, Series inputSeries, Series outputSeries);
+        public void Filter(CompareMethod compareMethod, double compareValue, Series inputSeries, Series outputSeries, string usingValue);
+        public void Filter(DateRangeType dateRange, string rangeElements, string inputSeriesNames);
+        public void Filter(DateRangeType dateRange, string rangeElements, string inputSeriesNames, string outputSeriesNames);
+        public void Filter(DateRangeType dateRange, string rangeElements, Series inputSeries);
+        public void Filter(DateRangeType dateRange, string rangeElements, Series inputSeries, Series outputSeries);
+        public void Filter(IDataPointFilter filterInterface, string inputSeriesNames);
+        public void Filter(IDataPointFilter filterInterface, string inputSeriesNames, string outputSeriesNames);
+        public void Filter(IDataPointFilter filterInterface, Series inputSeries);
+        public void Filter(IDataPointFilter filterInterface, Series inputSeries, Series outputSeries);
+        public void FilterTopN(int pointCount, string inputSeriesNames);
+        public void FilterTopN(int pointCount, string inputSeriesNames, string outputSeriesNames);
+        public void FilterTopN(int pointCount, string inputSeriesNames, string outputSeriesNames, string usingValue);
+        public void FilterTopN(int pointCount, string inputSeriesNames, string outputSeriesNames, string usingValue, bool getTopValues);
+        public void FilterTopN(int pointCount, Series inputSeries);
+        public void FilterTopN(int pointCount, Series inputSeries, Series outputSeries);
+        public void FilterTopN(int pointCount, Series inputSeries, Series outputSeries, string usingValue);
+        public void FilterTopN(int pointCount, Series inputSeries, Series outputSeries, string usingValue, bool getTopValues);
+        public void Group(string formula, double interval, IntervalType intervalType, double intervalOffset, IntervalType intervalOffsetType, string inputSeriesName);
+        public void Group(string formula, double interval, IntervalType intervalType, double intervalOffset, IntervalType intervalOffsetType, string inputSeriesName, string outputSeriesName);
+        public void Group(string formula, double interval, IntervalType intervalType, double intervalOffset, IntervalType intervalOffsetType, Series inputSeries);
+        public void Group(string formula, double interval, IntervalType intervalType, double intervalOffset, IntervalType intervalOffsetType, Series inputSeries, Series outputSeries);
+        public void Group(string formula, double interval, IntervalType intervalType, string inputSeriesName);
+        public void Group(string formula, double interval, IntervalType intervalType, string inputSeriesName, string outputSeriesName);
+        public void Group(string formula, double interval, IntervalType intervalType, Series inputSeries);
+        public void Group(string formula, double interval, IntervalType intervalType, Series inputSeries, Series outputSeries);
+        public void GroupByAxisLabel(string formula, string inputSeriesName);
+        public void GroupByAxisLabel(string formula, string inputSeriesName, string outputSeriesName);
+        public void GroupByAxisLabel(string formula, Series inputSeries);
+        public void GroupByAxisLabel(string formula, Series inputSeries, Series outputSeries);
+        public void InsertEmptyPoints(double interval, IntervalType intervalType, double intervalOffset, IntervalType intervalOffsetType, double fromXValue, double toXValue, string seriesName);
+        public void InsertEmptyPoints(double interval, IntervalType intervalType, double intervalOffset, IntervalType intervalOffsetType, double fromXValue, double toXValue, Series series);
+        public void InsertEmptyPoints(double interval, IntervalType intervalType, double intervalOffset, IntervalType intervalOffsetType, string seriesName);
+        public void InsertEmptyPoints(double interval, IntervalType intervalType, double intervalOffset, IntervalType intervalOffsetType, Series series);
+        public void InsertEmptyPoints(double interval, IntervalType intervalType, string seriesName);
+        public void InsertEmptyPoints(double interval, IntervalType intervalType, Series series);
+        public void Sort(IComparer<DataPoint> comparer, string seriesName);
+        public void Sort(IComparer<DataPoint> comparer, Series series);
+        public void Sort(PointSortOrder pointSortOrder, string seriesName);
+        public void Sort(PointSortOrder pointSortOrder, string sortBy, string seriesName);
+        public void Sort(PointSortOrder pointSortOrder, string sortBy, Series series);
+        public void Sort(PointSortOrder pointSortOrder, Series series);
+    }
+    public class DataPoint : DataPointCustomProperties {
+        public DataPoint();
+        public DataPoint(double xValue, double yValue);
+        public DataPoint(double xValue, double[] yValues);
+        public DataPoint(double xValue, string yValues);
+        public DataPoint(Series series);
+        public bool IsEmpty { get; set; }
+        public override string Name { get; set; }
+        public double XValue { get; set; }
+        public double[] YValues { get; set; }
+        public DataPoint Clone();
+        public double GetValueByName(string valueName);
+        public void SetValueXY(object xValue, params object[] yValue);
+        public void SetValueY(params object[] yValue);
+    }
+    public class DataPointCollection : ChartElementCollection<DataPoint> {
+        public DataPoint Add(params double[] y);
+        public int AddXY(double xValue, double yValue);
+        public int AddXY(object xValue, params object[] yValue);
+        public int AddY(double yValue);
+        public int AddY(params object[] yValue);
+        protected override void ClearItems();
+        public void DataBind(IEnumerable dataSource, string xField, string yFields, string otherFields);
+        public void DataBindXY(IEnumerable xValue, params IEnumerable[] yValues);
+        public void DataBindXY(IEnumerable xValue, string xField, IEnumerable yValue, string yFields);
+        public void DataBindY(IEnumerable yValue, string yFields);
+        public void DataBindY(params IEnumerable[] yValue);
+        public IEnumerable<DataPoint> FindAllByValue(double valueToFind);
+        public IEnumerable<DataPoint> FindAllByValue(double valueToFind, string useValue);
+        public IEnumerable<DataPoint> FindAllByValue(double valueToFind, string useValue, int startIndex);
+        public DataPoint FindByValue(double valueToFind);
+        public DataPoint FindByValue(double valueToFind, string useValue);
+        public DataPoint FindByValue(double valueToFind, string useValue, int startIndex);
+        public DataPoint FindMaxByValue();
+        public DataPoint FindMaxByValue(string useValue);
+        public DataPoint FindMaxByValue(string useValue, int startIndex);
+        public DataPoint FindMinByValue();
+        public DataPoint FindMinByValue(string useValue);
+        public DataPoint FindMinByValue(string useValue, int startIndex);
+        public void InsertXY(int index, object xValue, params object[] yValue);
+        public void InsertY(int index, params object[] yValue);
+    }
+    public class DataPointComparer : IComparer<DataPoint> {
+        public DataPointComparer(Series series, PointSortOrder sortOrder, string sortBy);
+        public int Compare(DataPoint x, DataPoint y);
+    }
+    public class DataPointCustomProperties : ChartNamedElement {
+        public DataPointCustomProperties();
+        public DataPointCustomProperties(Series series, bool pointProperties);
+        public virtual string AxisLabel { get; set; }
+        public GradientStyle BackGradientStyle { get; set; }
+        public ChartHatchStyle BackHatchStyle { get; set; }
+        public string BackImage { get; set; }
+        public ChartImageAlignmentStyle BackImageAlignment { get; set; }
+        public Color BackImageTransparentColor { get; set; }
+        public ChartImageWrapMode BackImageWrapMode { get; set; }
+        public Color BackSecondaryColor { get; set; }
+        public Color BorderColor { get; set; }
+        public ChartDashStyle BorderDashStyle { get; set; }
+        public int BorderWidth { get; set; }
+        public Color Color { get; set; }
+        public string CustomProperties { get; set; }
+        public CustomProperties CustomPropertiesExtended { get; set; }
+        public Font Font { get; set; }
+        public bool IsValueShownAsLabel { get; set; }
+        public bool IsVisibleInLegend { get; set; }
+        public virtual string Label { get; set; }
+        public int LabelAngle { get; set; }
+        public Color LabelBackColor { get; set; }
+        public Color LabelBorderColor { get; set; }
+        public ChartDashStyle LabelBorderDashStyle { get; set; }
+        public int LabelBorderWidth { get; set; }
+        public Color LabelForeColor { get; set; }
+        public string LabelFormat { get; set; }
+        public string LabelToolTip { get; set; }
+        public string LegendText { get; set; }
+        public string LegendToolTip { get; set; }
+        public Color MarkerBorderColor { get; set; }
+        public int MarkerBorderWidth { get; set; }
+        public Color MarkerColor { get; set; }
+        public string MarkerImage { get; set; }
+        public Color MarkerImageTransparentColor { get; set; }
+        public int MarkerSize { get; set; }
+        public MarkerStyle MarkerStyle { get; set; }
+        public string this[int index] { get; }
+        public string this[string name] { get; set; }
+        public string ToolTip { get; set; }
+        public virtual void DeleteCustomProperty(string name);
+        public virtual string GetCustomProperty(string name);
+        public virtual bool IsCustomPropertySet(string name);
+        public void ResetIsValueShownAsLabel();
+        public void ResetIsVisibleInLegend();
+        public virtual void SetCustomProperty(string name, string propertyValue);
+        public virtual void SetDefault(bool clearAll);
+    }
+    public enum DateRangeType {
+        DayOfMonth = 3,
+        DayOfWeek = 2,
+        Hour = 4,
+        Minute = 5,
+        Month = 1,
+        Year = 0,
+    }
+    public enum DateTimeIntervalType {
+        Auto = 0,
+        Days = 5,
+        Hours = 6,
+        Milliseconds = 9,
+        Minutes = 7,
+        Months = 3,
+        NotSet = 10,
+        Number = 1,
+        Seconds = 8,
+        Weeks = 4,
+        Years = 2,
+    }
+    public enum Docking {
+        Bottom = 2,
+        Left = 3,
+        Right = 1,
+        Top = 0,
+    }
+    public class ElementPosition : ChartElement {
+        public ElementPosition();
+        public ElementPosition(float x, float y, float width, float height);
+        public bool Auto { get; set; }
+        public float Bottom { get; }
+        public float Height { get; set; }
+        public float Right { get; }
+        public SizeF Size { get; }
+        public float Width { get; set; }
+        public float X { get; set; }
+        public float Y { get; set; }
+        public void FromRectangleF(RectangleF rect);
+        public RectangleF ToRectangleF();
+    }
+    public class EllipseAnnotation : RectangleAnnotation {
+        public EllipseAnnotation();
+        public override string AnnotationType { get; }
+    }
+    public enum FinancialFormula {
+        AccumulationDistribution = 0,
+        AverageTrueRange = 1,
+        BollingerBands = 2,
+        ChaikinOscillator = 3,
+        CommodityChannelIndex = 4,
+        DetrendedPriceOscillator = 5,
+        EaseOfMovement = 6,
+        Envelopes = 7,
+        ExponentialMovingAverage = 8,
+        Forecasting = 9,
+        MassIndex = 11,
+        MedianPrice = 12,
+        MoneyFlow = 13,
+        MovingAverage = 21,
+        MovingAverageConvergenceDivergence = 10,
+        NegativeVolumeIndex = 14,
+        OnBalanceVolume = 15,
+        Performance = 16,
+        PositiveVolumeIndex = 17,
+        PriceVolumeTrend = 18,
+        RateOfChange = 19,
+        RelativeStrengthIndex = 20,
+        StandardDeviation = 22,
+        StochasticIndicator = 23,
+        TriangularMovingAverage = 24,
+        TripleExponentialMovingAverage = 25,
+        TypicalPrice = 26,
+        VolatilityChaikins = 27,
+        VolumeOscillator = 28,
+        WeightedClose = 29,
+        WeightedMovingAverage = 30,
+        WilliamsR = 31,
+    }
+    public class FormatNumberEventArgs : EventArgs {
+        public ChartElementType ElementType { get; }
+        public string Format { get; }
+        public string LocalizedValue { get; set; }
+        public object SenderTag { get; }
+        public double Value { get; }
+        public ChartValueType ValueType { get; }
+    }
+    public class FTestResult {
+        public FTestResult();
+        public double FCriticalValueOneTail { get; }
+        public double FirstSeriesMean { get; }
+        public double FirstSeriesVariance { get; }
+        public double FValue { get; }
+        public double ProbabilityFOneTail { get; }
+        public double SecondSeriesMean { get; }
+        public double SecondSeriesVariance { get; }
+    }
+    public enum GradientStyle {
+        Center = 3,
+        DiagonalLeft = 4,
+        DiagonalRight = 5,
+        HorizontalCenter = 6,
+        LeftRight = 1,
+        None = 0,
+        TopBottom = 2,
+        VerticalCenter = 7,
+    }
+    public class Grid {
+        public Grid();
+        public bool Enabled { get; set; }
+        public double Interval { get; set; }
+        public double IntervalOffset { get; set; }
+        public DateTimeIntervalType IntervalOffsetType { get; set; }
+        public DateTimeIntervalType IntervalType { get; set; }
+        public Color LineColor { get; set; }
+        public ChartDashStyle LineDashStyle { get; set; }
+        public int LineWidth { get; set; }
+    }
+    public enum GridTickTypes {
+        All = 3,
+        Gridline = 2,
+        None = 0,
+        TickMark = 1,
+    }
+    public class HitTestResult {
+        public HitTestResult();
+        public Axis Axis { get; set; }
+        public ChartArea ChartArea { get; set; }
+        public ChartElementType ChartElementType { get; set; }
+        public object Object { get; set; }
+        public int PointIndex { get; set; }
+        public Series Series { get; set; }
+        public object SubObject { get; set; }
+    }
+    public class HorizontalLineAnnotation : LineAnnotation {
+        public HorizontalLineAnnotation();
+        public override string AnnotationType { get; }
+    }
+    public interface IDataPointFilter {
+        bool FilterDataPoint(DataPoint point, Series series, int pointIndex);
+    }
+    public class ImageAnnotation : Annotation {
+        public ImageAnnotation();
+        public override ContentAlignment Alignment { get; set; }
+        public override string AnnotationType { get; }
+        public override Color BackColor { get; set; }
+        public override GradientStyle BackGradientStyle { get; set; }
+        public override ChartHatchStyle BackHatchStyle { get; set; }
+        public override Color BackSecondaryColor { get; set; }
+        public override Font Font { get; set; }
+        public override Color ForeColor { get; set; }
+        public virtual string Image { get; set; }
+        public Color ImageTransparentColor { get; set; }
+        public ChartImageWrapMode ImageWrapMode { get; set; }
+        public override Color LineColor { get; set; }
+        public override ChartDashStyle LineDashStyle { get; set; }
+        public override int LineWidth { get; set; }
+        public override TextStyle TextStyle { get; set; }
+    }
+    public enum IntervalAutoMode {
+        FixedCount = 0,
+        VariableCount = 1,
+    }
+    public enum IntervalType {
+        Days = 4,
+        Hours = 5,
+        Milliseconds = 8,
+        Minutes = 6,
+        Months = 2,
+        Number = 0,
+        Seconds = 7,
+        Weeks = 3,
+        Years = 1,
+    }
+    public enum LabelAlignmentStyles {
+        Bottom = 2,
+        BottomLeft = 64,
+        BottomRight = 128,
+        Center = 256,
+        Left = 8,
+        Right = 4,
+        Top = 1,
+        TopLeft = 16,
+        TopRight = 32,
+    }
+    public enum LabelAutoFitStyles {
+        DecreaseFont = 2,
+        IncreaseFont = 1,
+        LabelsAngleStep30 = 8,
+        LabelsAngleStep45 = 16,
+        LabelsAngleStep90 = 32,
+        None = 0,
+        StaggeredLabels = 4,
+        WordWrap = 64,
+    }
+    public enum LabelCalloutStyle {
+        Box = 2,
+        None = 0,
+        Underlined = 1,
+    }
+    public enum LabelMarkStyle {
+        Box = 3,
+        LineSideMark = 2,
+        None = 0,
+        SideMark = 1,
+    }
+    public enum LabelOutsidePlotAreaStyle {
+        No = 1,
+        Partial = 2,
+        Yes = 0,
+    }
+    public class LabelStyle : ChartElement {
+        public LabelStyle();
+        public int Angle { get; set; }
+        public bool Enabled { get; set; }
+        public Font Font { get; set; }
+        public Color ForeColor { get; set; }
+        public string Format { get; set; }
+        public double Interval { get; set; }
+        public double IntervalOffset { get; set; }
+        public DateTimeIntervalType IntervalOffsetType { get; set; }
+        public DateTimeIntervalType IntervalType { get; set; }
+        public bool IsEndLabelVisible { get; set; }
+        public bool IsStaggered { get; set; }
+        public bool TruncatedLabels { get; set; }
+        protected override void Dispose(bool disposing);
+    }
+    public class Legend : ChartNamedElement {
+        public Legend();
+        public Legend(string name);
+        public StringAlignment Alignment { get; set; }
+        public int AutoFitMinFontSize { get; set; }
+        public Color BackColor { get; set; }
+        public GradientStyle BackGradientStyle { get; set; }
+        public ChartHatchStyle BackHatchStyle { get; set; }
+        public string BackImage { get; set; }
+        public ChartImageAlignmentStyle BackImageAlignment { get; set; }
+        public Color BackImageTransparentColor { get; set; }
+        public ChartImageWrapMode BackImageWrapMode { get; set; }
+        public Color BackSecondaryColor { get; set; }
+        public Color BorderColor { get; set; }
+        public ChartDashStyle BorderDashStyle { get; set; }
+        public int BorderWidth { get; set; }
+        public LegendCellColumnCollection CellColumns { get; }
+        public LegendItemsCollection CustomItems { get; }
+        public string DockedToChartArea { get; set; }
+        public Docking Docking { get; set; }
+        public bool Enabled { get; set; }
+        public Font Font { get; set; }
+        public Color ForeColor { get; set; }
+        public LegendSeparatorStyle HeaderSeparator { get; set; }
+        public Color HeaderSeparatorColor { get; set; }
+        public string InsideChartArea { get; set; }
+        public bool InterlacedRows { get; set; }
+        public Color InterlacedRowsColor { get; set; }
+        public bool IsDockedInsideChartArea { get; set; }
+        public bool IsEquallySpacedItems { get; set; }
+        public bool IsTextAutoFit { get; set; }
+        public LegendSeparatorStyle ItemColumnSeparator { get; set; }
+        public Color ItemColumnSeparatorColor { get; set; }
+        public int ItemColumnSpacing { get; set; }
+        public LegendItemOrder LegendItemOrder { get; set; }
+        public LegendStyle LegendStyle { get; set; }
+        public float MaximumAutoSize { get; set; }
+        public override string Name { get; set; }
+        public ElementPosition Position { get; set; }
+        public Color ShadowColor { get; set; }
+        public int ShadowOffset { get; set; }
+        public LegendTableStyle TableStyle { get; set; }
+        public int TextWrapThreshold { get; set; }
+        public string Title { get; set; }
+        public StringAlignment TitleAlignment { get; set; }
+        public Color TitleBackColor { get; set; }
+        public Font TitleFont { get; set; }
+        public Color TitleForeColor { get; set; }
+        public LegendSeparatorStyle TitleSeparator { get; set; }
+        public Color TitleSeparatorColor { get; set; }
+        protected override void Dispose(bool disposing);
+    }
+    public class LegendCell : ChartNamedElement {
+        public LegendCell();
+        public LegendCell(string text);
+        public LegendCell(LegendCellType cellType, string text);
+        public LegendCell(LegendCellType cellType, string text, ContentAlignment alignment);
+        public virtual ContentAlignment Alignment { get; set; }
+        public virtual Color BackColor { get; set; }
+        public virtual int CellSpan { get; set; }
+        public virtual LegendCellType CellType { get; set; }
+        public virtual Font Font { get; set; }
+        public virtual Color ForeColor { get; set; }
+        public virtual string Image { get; set; }
+        public virtual Size ImageSize { get; set; }
+        public virtual Color ImageTransparentColor { get; set; }
+        public virtual Legend Legend { get; }
+        public virtual LegendItem LegendItem { get; }
+        public virtual Margins Margins { get; set; }
+        public override string Name { get; set; }
+        public virtual Size SeriesSymbolSize { get; set; }
+        public virtual string Text { get; set; }
+        public virtual string ToolTip { get; set; }
+        protected override void Dispose(bool disposing);
+    }
+    public class LegendCellCollection : ChartNamedElementCollection<LegendCell> {
+        public int Add(LegendCellType cellType, string text, ContentAlignment alignment);
+        public void Insert(int index, LegendCellType cellType, string text, ContentAlignment alignment);
+    }
+    public class LegendCellColumn : ChartNamedElement {
+        public LegendCellColumn();
+        public LegendCellColumn(string headerText, LegendCellColumnType columnType, string text);
+        public LegendCellColumn(string headerText, LegendCellColumnType columnType, string text, ContentAlignment alignment);
+        public virtual ContentAlignment Alignment { get; set; }
+        public virtual Color BackColor { get; set; }
+        public virtual LegendCellColumnType ColumnType { get; set; }
+        public virtual Font Font { get; set; }
+        public virtual Color ForeColor { get; set; }
+        public StringAlignment HeaderAlignment { get; set; }
+        public virtual Color HeaderBackColor { get; set; }
+        public virtual Font HeaderFont { get; set; }
+        public virtual Color HeaderForeColor { get; set; }
+        public virtual string HeaderText { get; set; }
+        public virtual Legend Legend { get; }
+        public virtual Margins Margins { get; set; }
+        public virtual int MaximumWidth { get; set; }
+        public virtual int MinimumWidth { get; set; }
+        public override string Name { get; set; }
+        public virtual Size SeriesSymbolSize { get; set; }
+        public virtual string Text { get; set; }
+        public virtual string ToolTip { get; set; }
+        protected override void Dispose(bool disposing);
+        public bool ShouldSerializeMargins();
+    }
+    public class LegendCellColumnCollection : ChartNamedElementCollection<LegendCellColumn> {
+        protected override void Dispose(bool disposing);
+    }
+    public enum LegendCellColumnType {
+        SeriesSymbol = 1,
+        Text = 0,
+    }
+    public enum LegendCellType {
+        Image = 2,
+        SeriesSymbol = 1,
+        Text = 0,
+    }
+    public class LegendCollection : ChartNamedElementCollection<Legend> {
+        public Legend Add(string name);
+    }
+    public enum LegendImageStyle {
+        Line = 1,
+        Marker = 2,
+        Rectangle = 0,
+    }
+    public class LegendItem : ChartNamedElement {
+        public LegendItem();
+        public LegendItem(string name, Color color, string image);
+        public GradientStyle BackGradientStyle { get; set; }
+        public ChartHatchStyle BackHatchStyle { get; set; }
+        public Color BackImageTransparentColor { get; set; }
+        public Color BackSecondaryColor { get; set; }
+        public Color BorderColor { get; set; }
+        public ChartDashStyle BorderDashStyle { get; set; }
+        public int BorderWidth { get; set; }
+        public LegendCellCollection Cells { get; }
+        public Color Color { get; set; }
+        public bool Enabled { get; set; }
+        public string Image { get; set; }
+        public LegendImageStyle ImageStyle { get; set; }
+        public Legend Legend { get; }
+        public Color MarkerBorderColor { get; set; }
+        public int MarkerBorderWidth { get; set; }
+        public Color MarkerColor { get; set; }
+        public string MarkerImage { get; set; }
+        public Color MarkerImageTransparentColor { get; set; }
+        public int MarkerSize { get; set; }
+        public MarkerStyle MarkerStyle { get; set; }
+        public override string Name { get; set; }
+        public Color SeparatorColor { get; set; }
+        public LegendSeparatorStyle SeparatorType { get; set; }
+        public string SeriesName { get; set; }
+        public int SeriesPointIndex { get; set; }
+        public Color ShadowColor { get; set; }
+        public int ShadowOffset { get; set; }
+        public string ToolTip { get; set; }
+        protected override void Dispose(bool disposing);
+    }
+    public enum LegendItemOrder {
+        Auto = 0,
+        ReversedSeriesOrder = 2,
+        SameAsSeriesOrder = 1,
+    }
+    public class LegendItemsCollection : ChartElementCollection<LegendItem> {
+        public int Add(Color color, string text);
+        public int Add(string image, string text);
+        public void Insert(int index, Color color, string text);
+        public void Insert(int index, string image, string text);
+        public void Reverse();
+    }
+    public enum LegendSeparatorStyle {
+        DashLine = 4,
+        DotLine = 5,
+        DoubleLine = 3,
+        GradientLine = 6,
+        Line = 1,
+        None = 0,
+        ThickGradientLine = 7,
+        ThickLine = 2,
+    }
+    public enum LegendStyle {
+        Column = 0,
+        Row = 1,
+        Table = 2,
+    }
+    public enum LegendTableStyle {
+        Auto = 0,
+        Tall = 2,
+        Wide = 1,
+    }
+    public enum LightStyle {
+        None = 0,
+        Realistic = 2,
+        Simplistic = 1,
+    }
+    public enum LineAnchorCapStyle {
+        Arrow = 1,
+        Diamond = 2,
+        None = 0,
+        Round = 4,
+        Square = 3,
+    }
+    public class LineAnnotation : Annotation {
+        public LineAnnotation();
+        public override ContentAlignment Alignment { get; set; }
+        public override ContentAlignment AnchorAlignment { get; set; }
+        public override string AnnotationType { get; }
+        public override Color BackColor { get; set; }
+        public override GradientStyle BackGradientStyle { get; set; }
+        public override ChartHatchStyle BackHatchStyle { get; set; }
+        public override Color BackSecondaryColor { get; set; }
+        public virtual LineAnchorCapStyle EndCap { get; set; }
+        public override Font Font { get; set; }
+        public override Color ForeColor { get; set; }
+        public virtual bool IsInfinitive { get; set; }
+        public override bool IsSizeAlwaysRelative { get; set; }
+        public virtual LineAnchorCapStyle StartCap { get; set; }
+        public override TextStyle TextStyle { get; set; }
+    }
+    public class Margins {
+        public Margins();
+        public Margins(int top, int bottom, int left, int right);
+        public int Bottom { get; set; }
+        public int Left { get; set; }
+        public int Right { get; set; }
+        public int Top { get; set; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public bool IsEmpty();
+        public RectangleF ToRectangleF();
+        public override string ToString();
+    }
+    public enum MarkerStyle {
+        Circle = 2,
+        Cross = 5,
+        Diamond = 3,
+        None = 0,
+        Square = 1,
+        Star10 = 9,
+        Star4 = 6,
+        Star5 = 7,
+        Star6 = 8,
+        Triangle = 4,
+    }
+    public class NamedImage : ChartNamedElement {
+        public NamedImage();
+        public NamedImage(string name, Image image);
+        public Image Image { get; set; }
+        public override string Name { get; set; }
+        protected override void Dispose(bool disposing);
+    }
+    public class NamedImagesCollection : ChartNamedElementCollection<NamedImage>
+    public class Point3D {
+        public Point3D();
+        public Point3D(float x, float y, float z);
+        public PointF PointF { get; set; }
+        public float X { get; set; }
+        public float Y { get; set; }
+        public float Z { get; set; }
+    }
+    public enum PointSortOrder {
+        Ascending = 0,
+        Descending = 1,
+    }
+    public class PolygonAnnotation : PolylineAnnotation {
+        public PolygonAnnotation();
+        public override string AnnotationType { get; }
+        public override Color BackColor { get; set; }
+        public override GradientStyle BackGradientStyle { get; set; }
+        public override ChartHatchStyle BackHatchStyle { get; set; }
+        public override Color BackSecondaryColor { get; set; }
+        public override LineAnchorCapStyle EndCap { get; set; }
+        public override LineAnchorCapStyle StartCap { get; set; }
+    }
+    public class PolylineAnnotation : Annotation {
+        public PolylineAnnotation();
+        public override ContentAlignment Alignment { get; set; }
+        public override string AnnotationType { get; }
+        public override Color BackColor { get; set; }
+        public override GradientStyle BackGradientStyle { get; set; }
+        public override ChartHatchStyle BackHatchStyle { get; set; }
+        public override Color BackSecondaryColor { get; set; }
+        public virtual LineAnchorCapStyle EndCap { get; set; }
+        public override Font Font { get; set; }
+        public override Color ForeColor { get; set; }
+        public virtual GraphicsPath GraphicsPath { get; set; }
+        public AnnotationPathPointCollection GraphicsPathPoints { get; }
+        public virtual bool IsFreeDrawPlacement { get; set; }
+        public virtual LineAnchorCapStyle StartCap { get; set; }
+        public override TextStyle TextStyle { get; set; }
+        protected override void Dispose(bool disposing);
+        public override void EndPlacement();
+    }
+    public class PrintingManager : IDisposable {
+        public PrintingManager(IServiceContainer container);
+        public PrintDocument PrintDocument { get; set; }
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        public void PageSetup();
+        public void Print(bool showPrintDialog);
+        public void PrintPaint(Graphics graphics, Rectangle position);
+        public void PrintPreview();
+    }
+    public class RectangleAnnotation : TextAnnotation {
+        public RectangleAnnotation();
+        public override string AnnotationType { get; }
+        public override Color BackColor { get; set; }
+        public override GradientStyle BackGradientStyle { get; set; }
+        public override ChartHatchStyle BackHatchStyle { get; set; }
+        public override Color BackSecondaryColor { get; set; }
+        public override Color LineColor { get; set; }
+        public override ChartDashStyle LineDashStyle { get; set; }
+        public override int LineWidth { get; set; }
+    }
+    public enum ScrollBarButtonStyles {
+        All = 3,
+        None = 0,
+        ResetZoom = 2,
+        SmallScroll = 1,
+    }
+    public enum ScrollBarButtonType {
+        LargeDecrement = 3,
+        LargeIncrement = 4,
+        SmallDecrement = 1,
+        SmallIncrement = 2,
+        ThumbTracker = 0,
+        ZoomReset = 5,
+    }
+    public class ScrollBarEventArgs : EventArgs {
+        public ScrollBarEventArgs(Axis axis, int x, int y, ScrollBarButtonType buttonType);
+        public Axis Axis { get; }
+        public ScrollBarButtonType ButtonType { get; }
+        public ChartArea ChartArea { get; }
+        public bool IsHandled { get; set; }
+        public int MousePositionX { get; }
+        public int MousePositionY { get; }
+    }
+    public enum ScrollType {
+        First = 4,
+        LargeDecrement = 2,
+        LargeIncrement = 3,
+        Last = 5,
+        SmallDecrement = 0,
+        SmallIncrement = 1,
+    }
+    public enum SerializationContents {
+        All = 7,
+        Appearance = 4,
+        Data = 2,
+        Default = 1,
+    }
+    public enum SerializationFormat {
+        Binary = 1,
+        Xml = 0,
+    }
+    public class Series : DataPointCustomProperties {
+        public Series();
+        public Series(string name);
+        public Series(string name, int yValues);
+        public override string AxisLabel { get; set; }
+        public string ChartArea { get; set; }
+        public SeriesChartType ChartType { get; set; }
+        public string ChartTypeName { get; set; }
+        public DataPointCustomProperties EmptyPointStyle { get; set; }
+        public bool Enabled { get; set; }
+        public bool IsXValueIndexed { get; set; }
+        public string Legend { get; set; }
+        public int MarkerStep { get; set; }
+        public override string Name { get; set; }
+        public ChartColorPalette Palette { get; set; }
+        public DataPointCollection Points { get; }
+        public Color ShadowColor { get; set; }
+        public int ShadowOffset { get; set; }
+        public SmartLabelStyle SmartLabelStyle { get; set; }
+        public AxisType XAxisType { get; set; }
+        public string XValueMember { get; set; }
+        public ChartValueType XValueType { get; set; }
+        public AxisType YAxisType { get; set; }
+        public string YValueMembers { get; set; }
+        public int YValuesPerPoint { get; set; }
+        public ChartValueType YValueType { get; set; }
+        protected override void Dispose(bool disposing);
+        public void Sort(IComparer<DataPoint> comparer);
+        public void Sort(PointSortOrder pointSortOrder);
+        public void Sort(PointSortOrder pointSortOrder, string sortBy);
+    }
+    public enum SeriesChartType {
+        Area = 13,
+        Bar = 7,
+        BoxPlot = 28,
+        Bubble = 2,
+        Candlestick = 20,
+        Column = 10,
+        Doughnut = 18,
+        ErrorBar = 27,
+        FastLine = 6,
+        FastPoint = 1,
+        Funnel = 33,
+        Kagi = 31,
+        Line = 3,
+        Pie = 17,
+        Point = 0,
+        PointAndFigure = 32,
+        Polar = 26,
+        Pyramid = 34,
+        Radar = 25,
+        Range = 21,
+        RangeBar = 23,
+        RangeColumn = 24,
+        Renko = 29,
+        Spline = 4,
+        SplineArea = 14,
+        SplineRange = 22,
+        StackedArea = 15,
+        StackedArea100 = 16,
+        StackedBar = 8,
+        StackedBar100 = 9,
+        StackedColumn = 11,
+        StackedColumn100 = 12,
+        StepLine = 5,
+        Stock = 19,
+        ThreeLineBreak = 30,
+    }
+    public class SeriesCollection : ChartNamedElementCollection<Series> {
+        public Series Add(string name);
+    }
+    public class SmartLabelStyle {
+        public SmartLabelStyle();
+        public virtual LabelOutsidePlotAreaStyle AllowOutsidePlotArea { get; set; }
+        public virtual Color CalloutBackColor { get; set; }
+        public virtual LineAnchorCapStyle CalloutLineAnchorCapStyle { get; set; }
+        public virtual Color CalloutLineColor { get; set; }
+        public virtual ChartDashStyle CalloutLineDashStyle { get; set; }
+        public virtual int CalloutLineWidth { get; set; }
+        public virtual LabelCalloutStyle CalloutStyle { get; set; }
+        public virtual bool Enabled { get; set; }
+        public virtual bool IsMarkerOverlappingAllowed { get; set; }
+        public virtual bool IsOverlappedHidden { get; set; }
+        public virtual double MaxMovingDistance { get; set; }
+        public virtual double MinMovingDistance { get; set; }
+        public virtual LabelAlignmentStyles MovingDirection { get; set; }
+    }
+    public enum StartFromZero {
+        Auto = 0,
+        No = 2,
+        Yes = 1,
+    }
+    public class StatisticFormula {
+        public AnovaResult Anova(double probability, string inputSeriesNames);
+        public double BetaFunction(double m, double n);
+        public double Correlation(string firstInputSeriesName, string secondInputSeriesName);
+        public double Covariance(string firstInputSeriesName, string secondInputSeriesName);
+        public double FDistribution(double value, int firstDegreeOfFreedom, int secondDegreeOfFreedom);
+        public FTestResult FTest(double probability, string firstInputSeriesName, string secondInputSeriesName);
+        public double GammaFunction(double value);
+        public double InverseFDistribution(double probability, int firstDegreeOfFreedom, int secondDegreeOfFreedom);
+        public double InverseNormalDistribution(double probability);
+        public double InverseTDistribution(double probability, int degreeOfFreedom);
+        public double Mean(string inputSeriesName);
+        public double Median(string inputSeriesName);
+        public double NormalDistribution(double zValue);
+        public double TDistribution(double value, int degreeOfFreedom, bool oneTail);
+        public TTestResult TTestEqualVariances(double hypothesizedMeanDifference, double probability, string firstInputSeriesName, string secondInputSeriesName);
+        public TTestResult TTestPaired(double hypothesizedMeanDifference, double probability, string firstInputSeriesName, string secondInputSeriesName);
+        public TTestResult TTestUnequalVariances(double hypothesizedMeanDifference, double probability, string firstInputSeriesName, string secondInputSeriesName);
+        public double Variance(string inputSeriesName, bool sampleVariance);
+        public ZTestResult ZTest(double hypothesizedMeanDifference, double varianceFirstGroup, double varianceSecondGroup, double probability, string firstInputSeriesName, string secondInputSeriesName);
+    }
+    public class StripLine : ChartElement {
+        public StripLine();
+        public Color BackColor { get; set; }
+        public GradientStyle BackGradientStyle { get; set; }
+        public ChartHatchStyle BackHatchStyle { get; set; }
+        public string BackImage { get; set; }
+        public ChartImageAlignmentStyle BackImageAlignment { get; set; }
+        public Color BackImageTransparentColor { get; set; }
+        public ChartImageWrapMode BackImageWrapMode { get; set; }
+        public Color BackSecondaryColor { get; set; }
+        public Color BorderColor { get; set; }
+        public ChartDashStyle BorderDashStyle { get; set; }
+        public int BorderWidth { get; set; }
+        public Font Font { get; set; }
+        public Color ForeColor { get; set; }
+        public double Interval { get; set; }
+        public double IntervalOffset { get; set; }
+        public DateTimeIntervalType IntervalOffsetType { get; set; }
+        public DateTimeIntervalType IntervalType { get; set; }
+        public string Name { get; }
+        public double StripWidth { get; set; }
+        public DateTimeIntervalType StripWidthType { get; set; }
+        public string Text { get; set; }
+        public StringAlignment TextAlignment { get; set; }
+        public StringAlignment TextLineAlignment { get; set; }
+        public TextOrientation TextOrientation { get; set; }
+        public string ToolTip { get; set; }
+        protected override void Dispose(bool disposing);
+    }
+    public class StripLinesCollection : ChartElementCollection<StripLine>
+    public class TextAnnotation : Annotation {
+        public TextAnnotation();
+        public override string AnnotationType { get; }
+        public override Color BackColor { get; set; }
+        public override GradientStyle BackGradientStyle { get; set; }
+        public override ChartHatchStyle BackHatchStyle { get; set; }
+        public override Color BackSecondaryColor { get; set; }
+        public override Font Font { get; set; }
+        public virtual bool IsMultiline { get; set; }
+        public override Color LineColor { get; set; }
+        public override ChartDashStyle LineDashStyle { get; set; }
+        public override int LineWidth { get; set; }
+        public virtual string Text { get; set; }
+        public void BeginTextEditing();
+        public override void EndPlacement();
+        public void StopTextEditing();
+    }
+    public enum TextAntiAliasingQuality {
+        High = 1,
+        Normal = 0,
+        SystemDefault = 2,
+    }
+    public enum TextOrientation {
+        Auto = 0,
+        Horizontal = 1,
+        Rotated270 = 3,
+        Rotated90 = 2,
+        Stacked = 4,
+    }
+    public enum TextStyle {
+        Default = 0,
+        Embed = 3,
+        Emboss = 2,
+        Frame = 4,
+        Shadow = 1,
+    }
+    public class TickMark : Grid {
+        public TickMark();
+        public float Size { get; set; }
+        public TickMarkStyle TickMarkStyle { get; set; }
+    }
+    public enum TickMarkStyle {
+        AcrossAxis = 3,
+        InsideArea = 2,
+        None = 0,
+        OutsideArea = 1,
+    }
+    public class Title : ChartNamedElement, IDisposable {
+        public Title();
+        public Title(string text);
+        public Title(string text, Docking docking);
+        public Title(string text, Docking docking, Font font, Color color);
+        public ContentAlignment Alignment { get; set; }
+        public Color BackColor { get; set; }
+        public GradientStyle BackGradientStyle { get; set; }
+        public ChartHatchStyle BackHatchStyle { get; set; }
+        public string BackImage { get; set; }
+        public ChartImageAlignmentStyle BackImageAlignment { get; set; }
+        public Color BackImageTransparentColor { get; set; }
+        public ChartImageWrapMode BackImageWrapMode { get; set; }
+        public Color BackSecondaryColor { get; set; }
+        public Color BorderColor { get; set; }
+        public ChartDashStyle BorderDashStyle { get; set; }
+        public int BorderWidth { get; set; }
+        public string DockedToChartArea { get; set; }
+        public Docking Docking { get; set; }
+        public int DockingOffset { get; set; }
+        public Font Font { get; set; }
+        public Color ForeColor { get; set; }
+        public bool IsDockedInsideChartArea { get; set; }
+        public override string Name { get; set; }
+        public ElementPosition Position { get; set; }
+        public Color ShadowColor { get; set; }
+        public int ShadowOffset { get; set; }
+        public string Text { get; set; }
+        public TextOrientation TextOrientation { get; set; }
+        public TextStyle TextStyle { get; set; }
+        public string ToolTip { get; set; }
+        public virtual bool Visible { get; set; }
+        protected override void Dispose(bool disposing);
+    }
+    public class TitleCollection : ChartNamedElementCollection<Title> {
+        public Title Add(string name);
+    }
+    public class ToolTipEventArgs : EventArgs {
+        public ToolTipEventArgs(int x, int y, string text, HitTestResult result);
+        public HitTestResult HitTestResult { get; }
+        public string Text { get; set; }
+        public int X { get; }
+        public int Y { get; }
+    }
+    public class TTestResult {
+        public TTestResult();
+        public double DegreeOfFreedom { get; }
+        public double FirstSeriesMean { get; }
+        public double FirstSeriesVariance { get; }
+        public double ProbabilityTOneTail { get; }
+        public double ProbabilityTTwoTail { get; }
+        public double SecondSeriesMean { get; }
+        public double SecondSeriesVariance { get; }
+        public double TCriticalValueOneTail { get; }
+        public double TCriticalValueTwoTail { get; }
+        public double TValue { get; }
+    }
+    public class VerticalLineAnnotation : LineAnnotation {
+        public VerticalLineAnnotation();
+        public override string AnnotationType { get; }
+    }
+    public class ViewEventArgs : EventArgs {
+        public ViewEventArgs(Axis axis, double newPosition);
+        public ViewEventArgs(Axis axis, double newPosition, double newSize, DateTimeIntervalType newSizeType);
+        public Axis Axis { get; }
+        public ChartArea ChartArea { get; }
+        public double NewPosition { get; set; }
+        public double NewSize { get; set; }
+        public DateTimeIntervalType NewSizeType { get; set; }
+    }
+    public class ZTestResult {
+        public ZTestResult();
+        public double FirstSeriesMean { get; }
+        public double FirstSeriesVariance { get; }
+        public double ProbabilityZOneTail { get; }
+        public double ProbabilityZTwoTail { get; }
+        public double SecondSeriesMean { get; }
+        public double SecondSeriesVariance { get; }
+        public double ZCriticalValueOneTail { get; }
+        public double ZCriticalValueTwoTail { get; }
+        public double ZValue { get; }
+    }
+}
```

