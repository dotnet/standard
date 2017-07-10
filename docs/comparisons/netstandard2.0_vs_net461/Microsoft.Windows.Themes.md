# Microsoft.Windows.Themes

``` diff
+namespace Microsoft.Windows.Themes {
+    public sealed class BulletChrome : FrameworkElement {
+        public static readonly DependencyProperty BackgroundProperty;
+        public static readonly DependencyProperty BorderBrushProperty;
+        public static readonly DependencyProperty BorderThicknessProperty;
+        public static readonly DependencyProperty IsCheckedProperty;
+        public static readonly DependencyProperty IsRoundProperty;
+        public static readonly DependencyProperty RenderMouseOverProperty;
+        public static readonly DependencyProperty RenderPressedProperty;
+        public BulletChrome();
+        public Brush Background { get; set; }
+        public Brush BorderBrush { get; set; }
+        public Thickness BorderThickness { get; set; }
+        public Nullable<bool> IsChecked { get; set; }
+        public bool IsRound { get; set; }
+        public bool RenderMouseOver { get; set; }
+        public bool RenderPressed { get; set; }
+        protected override Size MeasureOverride(Size availableSize);
+        protected override void OnRender(DrawingContext drawingContext);
+    }
+    public sealed class ButtonChrome : Decorator {
+        public static readonly DependencyProperty BackgroundProperty;
+        public static readonly DependencyProperty BorderBrushProperty;
+        public static readonly DependencyProperty FillProperty;
+        public static readonly DependencyProperty RenderDefaultedProperty;
+        public static readonly DependencyProperty RenderMouseOverProperty;
+        public static readonly DependencyProperty RenderPressedProperty;
+        public static readonly DependencyProperty RoundCornersProperty;
+        public static readonly DependencyProperty ThemeColorProperty;
+        public ButtonChrome();
+        public Brush Background { get; set; }
+        public Brush BorderBrush { get; set; }
+        public Brush Fill { get; set; }
+        public bool RenderDefaulted { get; set; }
+        public bool RenderMouseOver { get; set; }
+        public bool RenderPressed { get; set; }
+        public bool RoundCorners { get; set; }
+        public ThemeColor ThemeColor { get; set; }
+        protected override Size ArrangeOverride(Size finalSize);
+        protected override Size MeasureOverride(Size availableSize);
+        protected override void OnRender(DrawingContext drawingContext);
+    }
+    public sealed class ClassicBorderDecorator : Decorator {
+        public static readonly DependencyProperty BackgroundProperty;
+        public static readonly DependencyProperty BorderBrushProperty;
+        public static readonly DependencyProperty BorderStyleProperty;
+        public static readonly DependencyProperty BorderThicknessProperty;
+        public ClassicBorderDecorator();
+        public Brush Background { get; set; }
+        public Brush BorderBrush { get; set; }
+        public ClassicBorderStyle BorderStyle { get; set; }
+        public Thickness BorderThickness { get; set; }
+        public static Brush ClassicBorderBrush { get; }
+        protected override Size ArrangeOverride(Size finalSize);
+        protected override Size MeasureOverride(Size availableSize);
+        protected override void OnRender(DrawingContext drawingContext);
+    }
+    public enum ClassicBorderStyle {
+        AltPressed = 15,
+        AltRaised = 14,
+        Etched = 5,
+        HorizontalLine = 6,
+        None = 0,
+        RadioButton = 16,
+        Raised = 1,
+        RaisedFocused = 3,
+        RaisedPressed = 2,
+        Sunken = 4,
+        TabBottom = 11,
+        TabLeft = 10,
+        TabRight = 8,
+        TabTop = 9,
+        ThinPressed = 13,
+        ThinRaised = 12,
+        VerticalLine = 7,
+    }
+    public sealed class DataGridHeaderBorder : Border {
+        public static readonly DependencyProperty IsClickableProperty;
+        public static readonly DependencyProperty IsHoveredProperty;
+        public static readonly DependencyProperty IsPressedProperty;
+        public static readonly DependencyProperty IsSelectedProperty;
+        public static readonly DependencyProperty OrientationProperty;
+        public static readonly DependencyProperty SeparatorBrushProperty;
+        public static readonly DependencyProperty SeparatorVisibilityProperty;
+        public static readonly DependencyProperty SortDirectionProperty;
+        public static readonly DependencyProperty ThemeColorProperty;
+        public DataGridHeaderBorder();
+        public bool IsClickable { get; set; }
+        public bool IsHovered { get; set; }
+        public bool IsPressed { get; set; }
+        public bool IsSelected { get; set; }
+        public Orientation Orientation { get; set; }
+        public Brush SeparatorBrush { get; set; }
+        public Visibility SeparatorVisibility { get; set; }
+        public Nullable<ListSortDirection> SortDirection { get; set; }
+        public ThemeColor ThemeColor { get; set; }
+        protected override Size ArrangeOverride(Size arrangeSize);
+        protected override Size MeasureOverride(Size constraint);
+        protected override void OnRender(DrawingContext dc);
+    }
+    public sealed class ListBoxChrome : Decorator {
+        public static readonly DependencyProperty BackgroundProperty;
+        public static readonly DependencyProperty BorderBrushProperty;
+        public static readonly DependencyProperty BorderThicknessProperty;
+        public static readonly DependencyProperty RenderFocusedProperty;
+        public static readonly DependencyProperty RenderMouseOverProperty;
+        public ListBoxChrome();
+        public Brush Background { get; set; }
+        public Brush BorderBrush { get; set; }
+        public Thickness BorderThickness { get; set; }
+        public bool RenderFocused { get; set; }
+        public bool RenderMouseOver { get; set; }
+        protected override Size ArrangeOverride(Size finalSize);
+        protected override Size MeasureOverride(Size availableSize);
+        protected override void OnRender(DrawingContext dc);
+    }
+    public static class PlatformCulture {
+        public static FlowDirection FlowDirection { get; }
+    }
+    public class ProgressBarBrushConverter : IMultiValueConverter {
+        public ProgressBarBrushConverter();
+        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture);
+        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture);
+    }
+    public class ProgressBarHighlightConverter : IMultiValueConverter {
+        public ProgressBarHighlightConverter();
+        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture);
+        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture);
+    }
+    public sealed class ScrollChrome : FrameworkElement {
+        public static readonly DependencyProperty HasOuterBorderProperty;
+        public static readonly DependencyProperty PaddingProperty;
+        public static readonly DependencyProperty RenderMouseOverProperty;
+        public static readonly DependencyProperty RenderPressedProperty;
+        public static readonly DependencyProperty ScrollGlyphProperty;
+        public static readonly DependencyProperty ThemeColorProperty;
+        public ScrollChrome();
+        public bool HasOuterBorder { get; set; }
+        public Thickness Padding { get; set; }
+        public bool RenderMouseOver { get; set; }
+        public bool RenderPressed { get; set; }
+        public ThemeColor ThemeColor { get; set; }
+        protected override Size ArrangeOverride(Size finalSize);
+        public static ScrollGlyph GetScrollGlyph(DependencyObject element);
+        protected override Size MeasureOverride(Size availableSize);
+        protected override void OnRender(DrawingContext drawingContext);
+        public static void SetScrollGlyph(DependencyObject element, ScrollGlyph value);
+    }
+    public enum ScrollGlyph {
+        DownArrow = 4,
+        HorizontalGripper = 6,
+        LeftArrow = 1,
+        None = 0,
+        RightArrow = 2,
+        UpArrow = 3,
+        VerticalGripper = 5,
+    }
+    public sealed class SystemDropShadowChrome : Decorator {
+        public static readonly DependencyProperty ColorProperty;
+        public static readonly DependencyProperty CornerRadiusProperty;
+        public SystemDropShadowChrome();
+        public Color Color { get; set; }
+        public CornerRadius CornerRadius { get; set; }
+        protected override void OnRender(DrawingContext drawingContext);
+    }
+    public enum ThemeColor {
+        Homestead = 1,
+        Metallic = 2,
+        NormalColor = 0,
+    }
+}
```

