# System.Windows.Controls.Ribbon.Primitives

``` diff
+namespace System.Windows.Controls.Ribbon.Primitives {
+    public interface IProvideStarLayoutInfo : IProvideStarLayoutInfoBase {
+        IEnumerable<StarLayoutInfo> StarLayoutCombinations { get; }
+        void OnStarSizeAllocationCompleted();
+    }
+    public interface IProvideStarLayoutInfoBase {
+        UIElement TargetElement { get; }
+        void OnInitializeLayout();
+    }
+    public interface ISupportStarLayout {
+        bool IsStarLayoutPass { get; }
+        void RegisterStarLayoutProvider(IProvideStarLayoutInfoBase starLayoutInfoProvider);
+        void UnregisterStarLayoutProvider(IProvideStarLayoutInfoBase starLayoutInfoProvider);
+    }
+    public class RibbonContextualTabGroupsPanel : Panel {
+        public static readonly DependencyProperty RibbonProperty;
+        public RibbonContextualTabGroupsPanel();
+        public Ribbon Ribbon { get; }
+        protected override Size ArrangeOverride(Size finalSize);
+        protected override Size MeasureOverride(Size availableSize);
+        protected override void OnIsItemsHostChanged(bool oldIsItemsHost, bool newIsItemsHost);
+        protected override void OnRender(DrawingContext drawingContext);
+    }
+    public class RibbonGalleryCategoriesPanel : Panel, IProvideStarLayoutInfoBase, IScrollInfo {
+        public RibbonGalleryCategoriesPanel();
+        public bool CanHorizontallyScroll { get; set; }
+        public bool CanVerticallyScroll { get; set; }
+        public double ExtentHeight { get; }
+        public double ExtentWidth { get; }
+        public double HorizontalOffset { get; }
+        public ScrollViewer ScrollOwner { get; set; }
+        public UIElement TargetElement { get; }
+        public double VerticalOffset { get; }
+        public double ViewportHeight { get; }
+        public double ViewportWidth { get; }
+        protected override Size ArrangeOverride(Size finalSize);
+        public void LineDown();
+        public void LineLeft();
+        public void LineRight();
+        public void LineUp();
+        public Rect MakeVisible(Visual visual, Rect rectangle);
+        protected override Size MeasureOverride(Size availableSize);
+        public void MouseWheelDown();
+        public void MouseWheelLeft();
+        public void MouseWheelRight();
+        public void MouseWheelUp();
+        public void OnInitializeLayout();
+        public void PageDown();
+        public void PageLeft();
+        public void PageRight();
+        public void PageUp();
+        public void SetHorizontalOffset(double offset);
+        public void SetVerticalOffset(double offset);
+    }
+    public class RibbonGalleryItemsPanel : Panel {
+        public RibbonGalleryItemsPanel();
+        protected override Size ArrangeOverride(Size finalSize);
+        protected override Size MeasureOverride(Size availableSize);
+    }
+    public class RibbonGroupItemsPanel : Panel, IProvideStarLayoutInfo, IProvideStarLayoutInfoBase {
+        public RibbonGroupItemsPanel();
+        public IEnumerable<StarLayoutInfo> StarLayoutCombinations { get; }
+        public UIElement TargetElement { get; }
+        protected override Size ArrangeOverride(Size finalSize);
+        protected override Size MeasureOverride(Size availableSize);
+        public void OnInitializeLayout();
+        public void OnStarSizeAllocationCompleted();
+    }
+    public class RibbonGroupsPanel : StackPanel, ISupportStarLayout {
+        public static readonly DependencyProperty IsStarLayoutPassProperty;
+        public RibbonGroupsPanel();
+        public bool IsStarLayoutPass { get; private set; }
+        protected override Size MeasureOverride(Size availableSize);
+        public void RegisterStarLayoutProvider(IProvideStarLayoutInfoBase starLayoutInfoProvider);
+        public void UnregisterStarLayoutProvider(IProvideStarLayoutInfoBase starLayoutInfoProvider);
+    }
+    public class RibbonMenuItemsPanel : VirtualizingStackPanel, ISupportStarLayout {
+        public RibbonMenuItemsPanel();
+        public bool IsStarLayoutPass { get; }
+        protected override Size ArrangeOverride(Size finalSize);
+        protected override Size MeasureOverride(Size availableSize);
+        protected override void OnIsItemsHostChanged(bool oldIsItemsHost, bool newIsItemsHost);
+        public void RegisterStarLayoutProvider(IProvideStarLayoutInfoBase starLayoutInfoProvider);
+        public void UnregisterStarLayoutProvider(IProvideStarLayoutInfoBase starLayoutInfoProvider);
+    }
+    public class RibbonQuickAccessToolBarOverflowPanel : Panel {
+        public RibbonQuickAccessToolBarOverflowPanel();
+        protected override Size ArrangeOverride(Size finalSize);
+        protected override Size MeasureOverride(Size availableSize);
+    }
+    public class RibbonQuickAccessToolBarPanel : VirtualizingPanel {
+        public RibbonQuickAccessToolBarPanel();
+        protected override Size ArrangeOverride(Size finalSize);
+        protected override Size MeasureOverride(Size availableSize);
+        protected override void OnItemsChanged(object sender, ItemsChangedEventArgs args);
+    }
+    public sealed class RibbonScrollButtonVisibilityConverter : IMultiValueConverter {
+        public RibbonScrollButtonVisibilityConverter();
+        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture);
+        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture);
+    }
+    public class RibbonTabHeadersPanel : Panel, IScrollInfo {
+        public static readonly DependencyProperty RibbonProperty;
+        public RibbonTabHeadersPanel();
+        public bool CanHorizontallyScroll { get; set; }
+        public bool CanVerticallyScroll { get; set; }
+        public double ExtentHeight { get; }
+        public double ExtentWidth { get; }
+        public double HorizontalOffset { get; }
+        public Ribbon Ribbon { get; }
+        public ScrollViewer ScrollOwner { get; set; }
+        public double VerticalOffset { get; }
+        public double ViewportHeight { get; }
+        public double ViewportWidth { get; }
+        protected override Size ArrangeOverride(Size finalSize);
+        public void LineDown();
+        public void LineLeft();
+        public void LineRight();
+        public void LineUp();
+        public Rect MakeVisible(Visual visual, Rect rectangle);
+        protected override Size MeasureOverride(Size availableSize);
+        public void MouseWheelDown();
+        public void MouseWheelLeft();
+        public void MouseWheelRight();
+        public void MouseWheelUp();
+        protected override void OnIsItemsHostChanged(bool oldIsItemsHost, bool newIsItemsHost);
+        protected override void OnRender(DrawingContext drawingContext);
+        public void PageDown();
+        public void PageLeft();
+        public void PageRight();
+        public void PageUp();
+        public void SetHorizontalOffset(double offset);
+        public void SetVerticalOffset(double offset);
+    }
+    public class RibbonTabsPanel : Panel, IScrollInfo {
+        public RibbonTabsPanel();
+        public bool CanHorizontallyScroll { get; set; }
+        public bool CanVerticallyScroll { get; set; }
+        public double ExtentHeight { get; }
+        public double ExtentWidth { get; }
+        public double HorizontalOffset { get; }
+        public ScrollViewer ScrollOwner { get; set; }
+        public double VerticalOffset { get; }
+        public double ViewportHeight { get; }
+        public double ViewportWidth { get; }
+        protected override Size ArrangeOverride(Size finalSize);
+        public void LineDown();
+        public void LineLeft();
+        public void LineRight();
+        public void LineUp();
+        public Rect MakeVisible(Visual visual, Rect rectangle);
+        protected override Size MeasureOverride(Size availableSize);
+        public void MouseWheelDown();
+        public void MouseWheelLeft();
+        public void MouseWheelRight();
+        public void MouseWheelUp();
+        public void PageDown();
+        public void PageLeft();
+        public void PageRight();
+        public void PageUp();
+        public void SetHorizontalOffset(double offset);
+        public void SetVerticalOffset(double offset);
+    }
+    public class RibbonTitlePanel : Panel {
+        public static readonly DependencyProperty RibbonProperty;
+        public RibbonTitlePanel();
+        public Ribbon Ribbon { get; }
+        protected override Size ArrangeOverride(Size finalSize);
+        protected override Size MeasureOverride(Size availableSize);
+    }
+    public class RibbonWindowSmallIconConverter : IValueConverter {
+        public RibbonWindowSmallIconConverter();
+        public object Convert(object value, Type targetType, object parameter, CultureInfo culture);
+        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);
+    }
+    public class StarLayoutInfo : DependencyObject {
+        public static readonly DependencyProperty AllocatedStarWidthProperty;
+        public static readonly DependencyProperty RequestedStarMaxWidthProperty;
+        public static readonly DependencyProperty RequestedStarMinWidthProperty;
+        public static readonly DependencyProperty RequestedStarWeightProperty;
+        public StarLayoutInfo();
+        public double AllocatedStarWidth { get; set; }
+        public double RequestedStarMaxWidth { get; set; }
+        public double RequestedStarMinWidth { get; set; }
+        public double RequestedStarWeight { get; set; }
+    }
+}
```

