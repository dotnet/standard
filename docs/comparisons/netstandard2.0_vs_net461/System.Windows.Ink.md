# System.Windows.Ink

``` diff
+namespace System.Windows.Ink {
+    public enum ApplicationGesture {
+        AllGestures = 0,
+        ArrowDown = 61497,
+        ArrowLeft = 61498,
+        ArrowRight = 61499,
+        ArrowUp = 61496,
+        Check = 61445,
+        ChevronDown = 61489,
+        ChevronLeft = 61490,
+        ChevronRight = 61491,
+        ChevronUp = 61488,
+        Circle = 61472,
+        Curlicue = 61456,
+        DoubleCircle = 61473,
+        DoubleCurlicue = 61457,
+        DoubleTap = 61681,
+        Down = 61529,
+        DownLeft = 61546,
+        DownLeftLong = 61542,
+        DownRight = 61547,
+        DownRightLong = 61543,
+        DownUp = 61537,
+        Exclamation = 61604,
+        Left = 61530,
+        LeftDown = 61549,
+        LeftRight = 61538,
+        LeftUp = 61548,
+        NoGesture = 61440,
+        Right = 61531,
+        RightDown = 61551,
+        RightLeft = 61539,
+        RightUp = 61550,
+        ScratchOut = 61441,
+        SemicircleLeft = 61480,
+        SemicircleRight = 61481,
+        Square = 61443,
+        Star = 61444,
+        Tap = 61680,
+        Triangle = 61442,
+        Up = 61528,
+        UpDown = 61536,
+        UpLeft = 61544,
+        UpLeftLong = 61540,
+        UpRight = 61545,
+        UpRightLong = 61541,
+    }
+    public static class DrawingAttributeIds {
+        public static readonly Guid Color;
+        public static readonly Guid DrawingFlags;
+        public static readonly Guid IsHighlighter;
+        public static readonly Guid StylusHeight;
+        public static readonly Guid StylusTip;
+        public static readonly Guid StylusTipTransform;
+        public static readonly Guid StylusWidth;
+    }
+    public class DrawingAttributes : INotifyPropertyChanged {
+        public static readonly double MaxHeight;
+        public static readonly double MaxWidth;
+        public static readonly double MinHeight;
+        public static readonly double MinWidth;
+        public DrawingAttributes();
+        public Color Color { get; set; }
+        public bool FitToCurve { get; set; }
+        public double Height { get; set; }
+        public bool IgnorePressure { get; set; }
+        public bool IsHighlighter { get; set; }
+        public StylusTip StylusTip { get; set; }
+        public Matrix StylusTipTransform { get; set; }
+        public double Width { get; set; }
+        public event PropertyDataChangedEventHandler AttributeChanged;
+        public event PropertyDataChangedEventHandler PropertyDataChanged;
+        event PropertyChangedEventHandler System.ComponentModel.INotifyPropertyChanged.PropertyChanged;
+        public void AddPropertyData(Guid propertyDataId, object propertyData);
+        public virtual DrawingAttributes Clone();
+        public bool ContainsPropertyData(Guid propertyDataId);
+        public override bool Equals(object o);
+        public override int GetHashCode();
+        public object GetPropertyData(Guid propertyDataId);
+        public Guid[] GetPropertyDataIds();
+        protected virtual void OnAttributeChanged(PropertyDataChangedEventArgs e);
+        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e);
+        protected virtual void OnPropertyDataChanged(PropertyDataChangedEventArgs e);
+        public static bool operator ==(DrawingAttributes first, DrawingAttributes second);
+        public static bool operator !=(DrawingAttributes first, DrawingAttributes second);
+        public void RemovePropertyData(Guid propertyDataId);
+    }
+    public class DrawingAttributesReplacedEventArgs : EventArgs {
+        public DrawingAttributesReplacedEventArgs(DrawingAttributes newDrawingAttributes, DrawingAttributes previousDrawingAttributes);
+        public DrawingAttributes NewDrawingAttributes { get; }
+        public DrawingAttributes PreviousDrawingAttributes { get; }
+    }
+    public delegate void DrawingAttributesReplacedEventHandler(object sender, DrawingAttributesReplacedEventArgs e);
+    public sealed class EllipseStylusShape : StylusShape {
+        public EllipseStylusShape(double width, double height);
+        public EllipseStylusShape(double width, double height, double rotation);
+    }
+    public class GestureRecognitionResult {
+        public ApplicationGesture ApplicationGesture { get; }
+        public RecognitionConfidence RecognitionConfidence { get; }
+    }
+    public sealed class GestureRecognizer : DependencyObject, IDisposable {
+        public GestureRecognizer();
+        public GestureRecognizer(IEnumerable<ApplicationGesture> enabledApplicationGestures);
+        public bool IsRecognizerAvailable { get; }
+        public void Dispose();
+        public ReadOnlyCollection<ApplicationGesture> GetEnabledGestures();
+        public ReadOnlyCollection<GestureRecognitionResult> Recognize(StrokeCollection strokes);
+        public void SetEnabledGestures(IEnumerable<ApplicationGesture> applicationGestures);
+    }
+    public abstract class IncrementalHitTester {
+        public bool IsValid { get; }
+        public void AddPoint(Point point);
+        public void AddPoints(IEnumerable<Point> points);
+        public void AddPoints(StylusPointCollection stylusPoints);
+        protected abstract void AddPointsCore(IEnumerable<Point> points);
+        public void EndHitTesting();
+    }
+    public class IncrementalLassoHitTester : IncrementalHitTester {
+        public event LassoSelectionChangedEventHandler SelectionChanged;
+        protected override void AddPointsCore(IEnumerable<Point> points);
+        protected void OnSelectionChanged(LassoSelectionChangedEventArgs eventArgs);
+    }
+    public class IncrementalStrokeHitTester : IncrementalHitTester {
+        public event StrokeHitEventHandler StrokeHit;
+        protected override void AddPointsCore(IEnumerable<Point> points);
+        protected void OnStrokeHit(StrokeHitEventArgs eventArgs);
+    }
+    public class LassoSelectionChangedEventArgs : EventArgs {
+        public StrokeCollection DeselectedStrokes { get; }
+        public StrokeCollection SelectedStrokes { get; }
+    }
+    public delegate void LassoSelectionChangedEventHandler(object sender, LassoSelectionChangedEventArgs e);
+    public class PropertyDataChangedEventArgs : EventArgs {
+        public PropertyDataChangedEventArgs(Guid propertyGuid, object newValue, object previousValue);
+        public object NewValue { get; }
+        public object PreviousValue { get; }
+        public Guid PropertyGuid { get; }
+    }
+    public delegate void PropertyDataChangedEventHandler(object sender, PropertyDataChangedEventArgs e);
+    public enum RecognitionConfidence {
+        Intermediate = 1,
+        Poor = 2,
+        Strong = 0,
+    }
+    public sealed class RectangleStylusShape : StylusShape {
+        public RectangleStylusShape(double width, double height);
+        public RectangleStylusShape(double width, double height, double rotation);
+    }
+    public class Stroke : INotifyPropertyChanged {
+        public Stroke(StylusPointCollection stylusPoints);
+        public Stroke(StylusPointCollection stylusPoints, DrawingAttributes drawingAttributes);
+        public DrawingAttributes DrawingAttributes { get; set; }
+        public StylusPointCollection StylusPoints { get; set; }
+        public event PropertyDataChangedEventHandler DrawingAttributesChanged;
+        public event DrawingAttributesReplacedEventHandler DrawingAttributesReplaced;
+        public event EventHandler Invalidated;
+        public event PropertyDataChangedEventHandler PropertyDataChanged;
+        public event EventHandler StylusPointsChanged;
+        public event StylusPointsReplacedEventHandler StylusPointsReplaced;
+        event PropertyChangedEventHandler System.ComponentModel.INotifyPropertyChanged.PropertyChanged;
+        public void AddPropertyData(Guid propertyDataId, object propertyData);
+        public virtual Stroke Clone();
+        public bool ContainsPropertyData(Guid propertyDataId);
+        public void Draw(DrawingContext context);
+        public void Draw(DrawingContext drawingContext, DrawingAttributes drawingAttributes);
+        protected virtual void DrawCore(DrawingContext drawingContext, DrawingAttributes drawingAttributes);
+        public StylusPointCollection GetBezierStylusPoints();
+        public virtual Rect GetBounds();
+        public StrokeCollection GetClipResult(IEnumerable<Point> lassoPoints);
+        public StrokeCollection GetClipResult(Rect bounds);
+        public StrokeCollection GetEraseResult(IEnumerable<Point> lassoPoints);
+        public StrokeCollection GetEraseResult(IEnumerable<Point> eraserPath, StylusShape eraserShape);
+        public StrokeCollection GetEraseResult(Rect bounds);
+        public Geometry GetGeometry();
+        public Geometry GetGeometry(DrawingAttributes drawingAttributes);
+        public object GetPropertyData(Guid propertyDataId);
+        public Guid[] GetPropertyDataIds();
+        public bool HitTest(IEnumerable<Point> lassoPoints, int percentageWithinLasso);
+        public bool HitTest(IEnumerable<Point> path, StylusShape stylusShape);
+        public bool HitTest(Point point);
+        public bool HitTest(Point point, double diameter);
+        public bool HitTest(Rect bounds, int percentageWithinBounds);
+        protected virtual void OnDrawingAttributesChanged(PropertyDataChangedEventArgs e);
+        protected virtual void OnDrawingAttributesReplaced(DrawingAttributesReplacedEventArgs e);
+        protected virtual void OnInvalidated(EventArgs e);
+        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e);
+        protected virtual void OnPropertyDataChanged(PropertyDataChangedEventArgs e);
+        protected virtual void OnStylusPointsChanged(EventArgs e);
+        protected virtual void OnStylusPointsReplaced(StylusPointsReplacedEventArgs e);
+        public void RemovePropertyData(Guid propertyDataId);
+        public virtual void Transform(Matrix transformMatrix, bool applyToStylusTip);
+    }
+    public class StrokeCollection : Collection<Stroke>, INotifyCollectionChanged, INotifyPropertyChanged {
+        public static readonly string InkSerializedFormat;
+        public StrokeCollection();
+        public StrokeCollection(IEnumerable<Stroke> strokes);
+        public StrokeCollection(Stream stream);
+        public event PropertyDataChangedEventHandler PropertyDataChanged;
+        public event StrokeCollectionChangedEventHandler StrokesChanged;
+        event NotifyCollectionChangedEventHandler System.Collections.Specialized.INotifyCollectionChanged.CollectionChanged;
+        event PropertyChangedEventHandler System.ComponentModel.INotifyPropertyChanged.PropertyChanged;
+        public void Add(StrokeCollection strokes);
+        public void AddPropertyData(Guid propertyDataId, object propertyData);
+        protected sealed override void ClearItems();
+        public void Clip(IEnumerable<Point> lassoPoints);
+        public void Clip(Rect bounds);
+        public virtual StrokeCollection Clone();
+        public bool ContainsPropertyData(Guid propertyDataId);
+        public void Draw(DrawingContext context);
+        public void Erase(IEnumerable<Point> lassoPoints);
+        public void Erase(IEnumerable<Point> eraserPath, StylusShape eraserShape);
+        public void Erase(Rect bounds);
+        public Rect GetBounds();
+        public IncrementalLassoHitTester GetIncrementalLassoHitTester(int percentageWithinLasso);
+        public IncrementalStrokeHitTester GetIncrementalStrokeHitTester(StylusShape eraserShape);
+        public object GetPropertyData(Guid propertyDataId);
+        public Guid[] GetPropertyDataIds();
+        public StrokeCollection HitTest(IEnumerable<Point> lassoPoints, int percentageWithinLasso);
+        public StrokeCollection HitTest(IEnumerable<Point> path, StylusShape stylusShape);
+        public StrokeCollection HitTest(Point point);
+        public StrokeCollection HitTest(Point point, double diameter);
+        public StrokeCollection HitTest(Rect bounds, int percentageWithinBounds);
+        public new int IndexOf(Stroke stroke);
+        protected sealed override void InsertItem(int index, Stroke stroke);
+        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e);
+        protected virtual void OnPropertyDataChanged(PropertyDataChangedEventArgs e);
+        protected virtual void OnStrokesChanged(StrokeCollectionChangedEventArgs e);
+        public void Remove(StrokeCollection strokes);
+        protected sealed override void RemoveItem(int index);
+        public void RemovePropertyData(Guid propertyDataId);
+        public void Replace(Stroke strokeToReplace, StrokeCollection strokesToReplaceWith);
+        public void Replace(StrokeCollection strokesToReplace, StrokeCollection strokesToReplaceWith);
+        public void Save(Stream stream);
+        public virtual void Save(Stream stream, bool compress);
+        protected sealed override void SetItem(int index, Stroke stroke);
+        public void Transform(Matrix transformMatrix, bool applyToStylusTip);
+    }
+    public class StrokeCollectionChangedEventArgs : EventArgs {
+        public StrokeCollectionChangedEventArgs(StrokeCollection added, StrokeCollection removed);
+        public StrokeCollection Added { get; }
+        public StrokeCollection Removed { get; }
+    }
+    public delegate void StrokeCollectionChangedEventHandler(object sender, StrokeCollectionChangedEventArgs e);
+    public class StrokeHitEventArgs : EventArgs {
+        public Stroke HitStroke { get; }
+        public StrokeCollection GetPointEraseResults();
+    }
+    public delegate void StrokeHitEventHandler(object sender, StrokeHitEventArgs e);
+    public class StylusPointsReplacedEventArgs : EventArgs {
+        public StylusPointsReplacedEventArgs(StylusPointCollection newStylusPoints, StylusPointCollection previousStylusPoints);
+        public StylusPointCollection NewStylusPoints { get; }
+        public StylusPointCollection PreviousStylusPoints { get; }
+    }
+    public delegate void StylusPointsReplacedEventHandler(object sender, StylusPointsReplacedEventArgs e);
+    public abstract class StylusShape {
+        public double Height { get; }
+        public double Rotation { get; }
+        public double Width { get; }
+    }
+    public enum StylusTip {
+        Ellipse = 1,
+        Rectangle = 0,
+    }
+}
```

