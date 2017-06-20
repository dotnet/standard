# System.Windows.Shapes

``` diff
+namespace System.Windows.Shapes {
+    public sealed class Ellipse : Shape {
+        public Ellipse();
+        protected override Geometry DefiningGeometry { get; }
+        public override Transform GeometryTransform { get; }
+        public override Geometry RenderedGeometry { get; }
+        protected override Size ArrangeOverride(Size finalSize);
+        protected override Size MeasureOverride(Size constraint);
+        protected override void OnRender(DrawingContext drawingContext);
+    }
+    public sealed class Line : Shape {
+        public static readonly DependencyProperty X1Property;
+        public static readonly DependencyProperty X2Property;
+        public static readonly DependencyProperty Y1Property;
+        public static readonly DependencyProperty Y2Property;
+        public Line();
+        protected override Geometry DefiningGeometry { get; }
+        public double X1 { get; set; }
+        public double X2 { get; set; }
+        public double Y1 { get; set; }
+        public double Y2 { get; set; }
+    }
+    public sealed class Path : Shape {
+        public static readonly DependencyProperty DataProperty;
+        public Path();
+        public Geometry Data { get; set; }
+        protected override Geometry DefiningGeometry { get; }
+    }
+    public sealed class Polygon : Shape {
+        public static readonly DependencyProperty FillRuleProperty;
+        public static readonly DependencyProperty PointsProperty;
+        public Polygon();
+        protected override Geometry DefiningGeometry { get; }
+        public FillRule FillRule { get; set; }
+        public PointCollection Points { get; set; }
+    }
+    public sealed class Polyline : Shape {
+        public static readonly DependencyProperty FillRuleProperty;
+        public static readonly DependencyProperty PointsProperty;
+        public Polyline();
+        protected override Geometry DefiningGeometry { get; }
+        public FillRule FillRule { get; set; }
+        public PointCollection Points { get; set; }
+    }
+    public sealed class Rectangle : Shape {
+        public static readonly DependencyProperty RadiusXProperty;
+        public static readonly DependencyProperty RadiusYProperty;
+        public Rectangle();
+        protected override Geometry DefiningGeometry { get; }
+        public override Transform GeometryTransform { get; }
+        public double RadiusX { get; set; }
+        public double RadiusY { get; set; }
+        public override Geometry RenderedGeometry { get; }
+        protected override Size ArrangeOverride(Size finalSize);
+        protected override Size MeasureOverride(Size constraint);
+        protected override void OnRender(DrawingContext drawingContext);
+    }
+    public abstract class Shape : FrameworkElement {
+        public static readonly DependencyProperty FillProperty;
+        public static readonly DependencyProperty StretchProperty;
+        public static readonly DependencyProperty StrokeDashArrayProperty;
+        public static readonly DependencyProperty StrokeDashCapProperty;
+        public static readonly DependencyProperty StrokeDashOffsetProperty;
+        public static readonly DependencyProperty StrokeEndLineCapProperty;
+        public static readonly DependencyProperty StrokeLineJoinProperty;
+        public static readonly DependencyProperty StrokeMiterLimitProperty;
+        public static readonly DependencyProperty StrokeProperty;
+        public static readonly DependencyProperty StrokeStartLineCapProperty;
+        public static readonly DependencyProperty StrokeThicknessProperty;
+        protected Shape();
+        protected abstract Geometry DefiningGeometry { get; }
+        public Brush Fill { get; set; }
+        public virtual Transform GeometryTransform { get; }
+        public virtual Geometry RenderedGeometry { get; }
+        public Stretch Stretch { get; set; }
+        public Brush Stroke { get; set; }
+        public DoubleCollection StrokeDashArray { get; set; }
+        public PenLineCap StrokeDashCap { get; set; }
+        public double StrokeDashOffset { get; set; }
+        public PenLineCap StrokeEndLineCap { get; set; }
+        public PenLineJoin StrokeLineJoin { get; set; }
+        public double StrokeMiterLimit { get; set; }
+        public PenLineCap StrokeStartLineCap { get; set; }
+        public double StrokeThickness { get; set; }
+        protected override Size ArrangeOverride(Size finalSize);
+        protected override Size MeasureOverride(Size constraint);
+        protected override void OnRender(DrawingContext drawingContext);
+    }
+}
```

