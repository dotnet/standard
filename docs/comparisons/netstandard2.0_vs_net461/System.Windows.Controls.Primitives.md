# System.Windows.Controls.Primitives

``` diff
+namespace System.Windows.Controls.Primitives {
+    public enum AutoToolTipPlacement {
+        BottomRight = 2,
+        None = 0,
+        TopLeft = 1,
+    }
+    public class BulletDecorator : Decorator {
+        public static readonly DependencyProperty BackgroundProperty;
+        public BulletDecorator();
+        public Brush Background { get; set; }
+        public UIElement Bullet { get; set; }
+        protected internal override IEnumerator LogicalChildren { get; }
+        protected override int VisualChildrenCount { get; }
+        protected override Size ArrangeOverride(Size arrangeSize);
+        protected override Visual GetVisualChild(int index);
+        protected override Size MeasureOverride(Size constraint);
+        protected override void OnRender(DrawingContext dc);
+    }
+    public abstract class ButtonBase : ContentControl, ICommandSource {
+        public static readonly DependencyProperty ClickModeProperty;
+        public static readonly DependencyProperty CommandParameterProperty;
+        public static readonly DependencyProperty CommandProperty;
+        public static readonly DependencyProperty CommandTargetProperty;
+        public static readonly DependencyProperty IsPressedProperty;
+        public static readonly RoutedEvent ClickEvent;
+        protected ButtonBase();
+        public ClickMode ClickMode { get; set; }
+        public ICommand Command { get; set; }
+        public object CommandParameter { get; set; }
+        public IInputElement CommandTarget { get; set; }
+        protected override bool IsEnabledCore { get; }
+        public bool IsPressed { get; protected set; }
+        public event RoutedEventHandler Click;
+        protected override void OnAccessKey(AccessKeyEventArgs e);
+        protected virtual void OnClick();
+        protected virtual void OnIsPressedChanged(DependencyPropertyChangedEventArgs e);
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected override void OnKeyUp(KeyEventArgs e);
+        protected override void OnLostKeyboardFocus(KeyboardFocusChangedEventArgs e);
+        protected override void OnLostMouseCapture(MouseEventArgs e);
+        protected override void OnMouseEnter(MouseEventArgs e);
+        protected override void OnMouseLeave(MouseEventArgs e);
+        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e);
+        protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e);
+        protected override void OnMouseMove(MouseEventArgs e);
+        protected internal override void OnRenderSizeChanged(SizeChangedInfo sizeInfo);
+    }
+    public sealed class CalendarButton : Button {
+        public static readonly DependencyProperty HasSelectedDaysProperty;
+        public static readonly DependencyProperty IsInactiveProperty;
+        public CalendarButton();
+        public bool HasSelectedDays { get; internal set; }
+        public bool IsInactive { get; internal set; }
+        protected override AutomationPeer OnCreateAutomationPeer();
+    }
+    public sealed class CalendarDayButton : Button {
+        public static readonly DependencyProperty IsBlackedOutProperty;
+        public static readonly DependencyProperty IsHighlightedProperty;
+        public static readonly DependencyProperty IsInactiveProperty;
+        public static readonly DependencyProperty IsSelectedProperty;
+        public static readonly DependencyProperty IsTodayProperty;
+        public CalendarDayButton();
+        public bool IsBlackedOut { get; }
+        public bool IsHighlighted { get; }
+        public bool IsInactive { get; }
+        public bool IsSelected { get; }
+        public bool IsToday { get; }
+        protected override AutomationPeer OnCreateAutomationPeer();
+    }
+    public sealed class CalendarItem : Control {
+        public CalendarItem();
+        public static ComponentResourceKey DayTitleTemplateResourceKey { get; }
+        public override void OnApplyTemplate();
+        protected override void OnLostMouseCapture(MouseEventArgs e);
+        protected override void OnMouseUp(MouseButtonEventArgs e);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct CustomPopupPlacement {
+        public CustomPopupPlacement(Point point, PopupPrimaryAxis primaryAxis);
+        public Point Point { get; set; }
+        public PopupPrimaryAxis PrimaryAxis { get; set; }
+        public override bool Equals(object o);
+        public override int GetHashCode();
+        public static bool operator ==(CustomPopupPlacement placement1, CustomPopupPlacement placement2);
+        public static bool operator !=(CustomPopupPlacement placement1, CustomPopupPlacement placement2);
+    }
+    public delegate CustomPopupPlacement[] CustomPopupPlacementCallback(Size popupSize, Size targetSize, Point offset);
+    public class DataGridCellsPresenter : ItemsControl {
+        public DataGridCellsPresenter();
+        public object Item { get; internal set; }
+        protected override Size ArrangeOverride(Size finalSize);
+        protected override void ClearContainerForItemOverride(DependencyObject element, object item);
+        protected override DependencyObject GetContainerForItemOverride();
+        protected override bool IsItemItsOwnContainerOverride(object item);
+        protected override Size MeasureOverride(Size availableSize);
+        public override void OnApplyTemplate();
+        protected internal virtual void OnColumnsChanged(ObservableCollection<DataGridColumn> columns, NotifyCollectionChangedEventArgs e);
+        protected virtual void OnItemChanged(object oldItem, object newItem);
+        protected override void OnRender(DrawingContext drawingContext);
+        protected override void PrepareContainerForItemOverride(DependencyObject element, object item);
+    }
+    public class DataGridColumnHeader : ButtonBase, IProvideDataGridColumn {
+        public static readonly DependencyProperty CanUserSortProperty;
+        public static readonly DependencyProperty DisplayIndexProperty;
+        public static readonly DependencyProperty IsFrozenProperty;
+        public static readonly DependencyProperty SeparatorBrushProperty;
+        public static readonly DependencyProperty SeparatorVisibilityProperty;
+        public static readonly DependencyProperty SortDirectionProperty;
+        public DataGridColumnHeader();
+        public bool CanUserSort { get; }
+        public DataGridColumn Column { get; }
+        public static ComponentResourceKey ColumnFloatingHeaderStyleKey { get; }
+        public static ComponentResourceKey ColumnHeaderDropSeparatorStyleKey { get; }
+        public int DisplayIndex { get; }
+        public bool IsFrozen { get; }
+        public Brush SeparatorBrush { get; set; }
+        public Visibility SeparatorVisibility { get; set; }
+        public Nullable<ListSortDirection> SortDirection { get; }
+        public override void OnApplyTemplate();
+        protected override void OnClick();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnLostMouseCapture(MouseEventArgs e);
+        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e);
+        protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e);
+        protected override void OnMouseMove(MouseEventArgs e);
+    }
+    public class DataGridColumnHeadersPresenter : ItemsControl {
+        public DataGridColumnHeadersPresenter();
+        protected override int VisualChildrenCount { get; }
+        protected override Size ArrangeOverride(Size finalSize);
+        protected override void ClearContainerForItemOverride(DependencyObject element, object item);
+        protected override DependencyObject GetContainerForItemOverride();
+        protected override Geometry GetLayoutClip(Size layoutSlotSize);
+        protected override Visual GetVisualChild(int index);
+        protected override bool IsItemItsOwnContainerOverride(object item);
+        protected override Size MeasureOverride(Size availableSize);
+        public override void OnApplyTemplate();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void PrepareContainerForItemOverride(DependencyObject element, object item);
+    }
+    public class DataGridDetailsPresenter : ContentPresenter {
+        public DataGridDetailsPresenter();
+        protected override Size ArrangeOverride(Size finalSize);
+        protected override Size MeasureOverride(Size availableSize);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnRender(DrawingContext drawingContext);
+        protected internal override void OnVisualParentChanged(DependencyObject oldParent);
+    }
+    public class DataGridRowHeader : ButtonBase {
+        public static readonly DependencyProperty IsRowSelectedProperty;
+        public static readonly DependencyProperty SeparatorBrushProperty;
+        public static readonly DependencyProperty SeparatorVisibilityProperty;
+        public DataGridRowHeader();
+        public bool IsRowSelected { get; }
+        public Brush SeparatorBrush { get; set; }
+        public Visibility SeparatorVisibility { get; set; }
+        protected override Size MeasureOverride(Size availableSize);
+        public override void OnApplyTemplate();
+        protected override void OnClick();
+        protected override AutomationPeer OnCreateAutomationPeer();
+    }
+    public class DataGridRowsPresenter : VirtualizingStackPanel {
+        public DataGridRowsPresenter();
+        protected override Size MeasureOverride(Size constraint);
+        protected override void OnCleanUpVirtualizedItem(CleanUpVirtualizedItemEventArgs e);
+        protected override void OnIsItemsHostChanged(bool oldIsItemsHost, bool newIsItemsHost);
+        protected override void OnViewportSizeChanged(Size oldViewportSize, Size newViewportSize);
+    }
+    public sealed class DatePickerTextBox : TextBox {
+        public DatePickerTextBox();
+        public override void OnApplyTemplate();
+        protected override void OnGotFocus(RoutedEventArgs e);
+    }
+    public class DocumentPageView : FrameworkElement, IDisposable, IServiceProvider {
+        public static readonly DependencyProperty PageNumberProperty;
+        public static readonly DependencyProperty StretchDirectionProperty;
+        public static readonly DependencyProperty StretchProperty;
+        public DocumentPageView();
+        public DocumentPage DocumentPage { get; }
+        public DocumentPaginator DocumentPaginator { get; set; }
+        protected bool IsDisposed { get; }
+        public int PageNumber { get; set; }
+        public Stretch Stretch { get; set; }
+        public StretchDirection StretchDirection { get; set; }
+        protected override int VisualChildrenCount { get; }
+        public event EventHandler PageConnected;
+        public event EventHandler PageDisconnected;
+        protected sealed override Size ArrangeOverride(Size finalSize);
+        protected void Dispose();
+        protected object GetService(Type serviceType);
+        protected override Visual GetVisualChild(int index);
+        protected sealed override Size MeasureOverride(Size availableSize);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        void System.IDisposable.Dispose();
+        object System.IServiceProvider.GetService(Type serviceType);
+    }
+    public abstract class DocumentViewerBase : Control, IAddChild, IServiceProvider {
+        public static readonly DependencyProperty CanGoToNextPageProperty;
+        public static readonly DependencyProperty CanGoToPreviousPageProperty;
+        public static readonly DependencyProperty DocumentProperty;
+        public static readonly DependencyProperty IsMasterPageProperty;
+        public static readonly DependencyProperty MasterPageNumberProperty;
+        public static readonly DependencyProperty PageCountProperty;
+        protected static readonly DependencyPropertyKey CanGoToNextPagePropertyKey;
+        protected static readonly DependencyPropertyKey CanGoToPreviousPagePropertyKey;
+        protected static readonly DependencyPropertyKey MasterPageNumberPropertyKey;
+        protected static readonly DependencyPropertyKey PageCountPropertyKey;
+        protected DocumentViewerBase();
+        public virtual bool CanGoToNextPage { get; }
+        public virtual bool CanGoToPreviousPage { get; }
+        public IDocumentPaginatorSource Document { get; set; }
+        protected internal override IEnumerator LogicalChildren { get; }
+        public virtual int MasterPageNumber { get; }
+        public int PageCount { get; }
+        public ReadOnlyCollection<DocumentPageView> PageViews { get; }
+        public event EventHandler PageViewsChanged;
+        public void CancelPrint();
+        public virtual bool CanGoToPage(int pageNumber);
+        public void FirstPage();
+        public static bool GetIsMasterPage(DependencyObject element);
+        protected DocumentPageView GetMasterPageView();
+        protected virtual ReadOnlyCollection<DocumentPageView> GetPageViewsCollection(out bool changed);
+        public void GoToPage(int pageNumber);
+        protected void InvalidatePageViews();
+        public void LastPage();
+        public void NextPage();
+        public override void OnApplyTemplate();
+        protected virtual void OnBringIntoView(DependencyObject element, Rect rect, int pageNumber);
+        protected virtual void OnCancelPrintCommand();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected virtual void OnDocumentChanged();
+        protected virtual void OnFirstPageCommand();
+        protected virtual void OnGoToPageCommand(int pageNumber);
+        protected virtual void OnLastPageCommand();
+        protected virtual void OnMasterPageNumberChanged();
+        protected virtual void OnNextPageCommand();
+        protected virtual void OnPageViewsChanged();
+        protected virtual void OnPreviousPageCommand();
+        protected virtual void OnPrintCommand();
+        public void PreviousPage();
+        public void Print();
+        public static void SetIsMasterPage(DependencyObject element, bool value);
+        object System.IServiceProvider.GetService(Type serviceType);
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public class DragCompletedEventArgs : RoutedEventArgs {
+        public DragCompletedEventArgs(double horizontalChange, double verticalChange, bool canceled);
+        public bool Canceled { get; }
+        public double HorizontalChange { get; }
+        public double VerticalChange { get; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void DragCompletedEventHandler(object sender, DragCompletedEventArgs e);
+    public class DragDeltaEventArgs : RoutedEventArgs {
+        public DragDeltaEventArgs(double horizontalChange, double verticalChange);
+        public double HorizontalChange { get; }
+        public double VerticalChange { get; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void DragDeltaEventHandler(object sender, DragDeltaEventArgs e);
+    public class DragStartedEventArgs : RoutedEventArgs {
+        public DragStartedEventArgs(double horizontalOffset, double verticalOffset);
+        public double HorizontalOffset { get; }
+        public double VerticalOffset { get; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void DragStartedEventHandler(object sender, DragStartedEventArgs e);
+    public enum GeneratorDirection {
+        Backward = 1,
+        Forward = 0,
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct GeneratorPosition {
+        public GeneratorPosition(int index, int offset);
+        public int Index { get; set; }
+        public int Offset { get; set; }
+        public override bool Equals(object o);
+        public override int GetHashCode();
+        public static bool operator ==(GeneratorPosition gp1, GeneratorPosition gp2);
+        public static bool operator !=(GeneratorPosition gp1, GeneratorPosition gp2);
+        public override string ToString();
+    }
+    public enum GeneratorStatus {
+        ContainersGenerated = 2,
+        Error = 3,
+        GeneratingContainers = 1,
+        NotStarted = 0,
+    }
+    public abstract class GridViewRowPresenterBase : FrameworkElement, IWeakEventListener {
+        public static readonly DependencyProperty ColumnsProperty;
+        protected GridViewRowPresenterBase();
+        public GridViewColumnCollection Columns { get; set; }
+        protected internal override IEnumerator LogicalChildren { get; }
+        protected override int VisualChildrenCount { get; }
+        protected override Visual GetVisualChild(int index);
+        bool System.Windows.IWeakEventListener.ReceiveWeakEvent(Type managerType, object sender, EventArgs args);
+        public override string ToString();
+    }
+    public interface IContainItemStorage {
+        void Clear();
+        void ClearItemValue(object item, DependencyProperty dp);
+        void ClearValue(DependencyProperty dp);
+        object ReadItemValue(object item, DependencyProperty dp);
+        void StoreItemValue(object item, DependencyProperty dp, object value);
+    }
+    public interface IHierarchicalVirtualizationAndScrollInfo {
+        HierarchicalVirtualizationConstraints Constraints { get; set; }
+        HierarchicalVirtualizationHeaderDesiredSizes HeaderDesiredSizes { get; }
+        bool InBackgroundLayout { get; set; }
+        HierarchicalVirtualizationItemDesiredSizes ItemDesiredSizes { get; set; }
+        Panel ItemsHost { get; }
+        bool MustDisableVirtualization { get; set; }
+    }
+    public interface IItemContainerGenerator {
+        DependencyObject GenerateNext();
+        DependencyObject GenerateNext(out bool isNewlyRealized);
+        GeneratorPosition GeneratorPositionFromIndex(int itemIndex);
+        ItemContainerGenerator GetItemContainerGeneratorForPanel(Panel panel);
+        int IndexFromGeneratorPosition(GeneratorPosition position);
+        void PrepareItemContainer(DependencyObject container);
+        void Remove(GeneratorPosition position, int count);
+        void RemoveAll();
+        IDisposable StartAt(GeneratorPosition position, GeneratorDirection direction);
+        IDisposable StartAt(GeneratorPosition position, GeneratorDirection direction, bool allowStartAtRealizedItem);
+    }
+    public interface IRecyclingItemContainerGenerator : IItemContainerGenerator {
+        void Recycle(GeneratorPosition position, int count);
+    }
+    public interface IScrollInfo {
+        bool CanHorizontallyScroll { get; set; }
+        bool CanVerticallyScroll { get; set; }
+        double ExtentHeight { get; }
+        double ExtentWidth { get; }
+        double HorizontalOffset { get; }
+        ScrollViewer ScrollOwner { get; set; }
+        double VerticalOffset { get; }
+        double ViewportHeight { get; }
+        double ViewportWidth { get; }
+        void LineDown();
+        void LineLeft();
+        void LineRight();
+        void LineUp();
+        Rect MakeVisible(Visual visual, Rect rectangle);
+        void MouseWheelDown();
+        void MouseWheelLeft();
+        void MouseWheelRight();
+        void MouseWheelUp();
+        void PageDown();
+        void PageLeft();
+        void PageRight();
+        void PageUp();
+        void SetHorizontalOffset(double offset);
+        void SetVerticalOffset(double offset);
+    }
+    public class ItemsChangedEventArgs : EventArgs {
+        public NotifyCollectionChangedAction Action { get; }
+        public int ItemCount { get; }
+        public int ItemUICount { get; }
+        public GeneratorPosition OldPosition { get; }
+        public GeneratorPosition Position { get; }
+    }
+    public delegate void ItemsChangedEventHandler(object sender, ItemsChangedEventArgs e);
+    public static class LayoutInformation {
+        public static Geometry GetLayoutClip(FrameworkElement element);
+        public static UIElement GetLayoutExceptionElement(Dispatcher dispatcher);
+        public static Rect GetLayoutSlot(FrameworkElement element);
+    }
+    public abstract class MenuBase : ItemsControl {
+        public static readonly DependencyProperty ItemContainerTemplateSelectorProperty;
+        public static readonly DependencyProperty UsesItemContainerTemplateProperty;
+        protected MenuBase();
+        public ItemContainerTemplateSelector ItemContainerTemplateSelector { get; set; }
+        public bool UsesItemContainerTemplate { get; set; }
+        protected override DependencyObject GetContainerForItemOverride();
+        protected virtual void HandleMouseButton(MouseButtonEventArgs e);
+        protected override bool IsItemItsOwnContainerOverride(object item);
+        protected override void OnIsKeyboardFocusWithinChanged(DependencyPropertyChangedEventArgs e);
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected override void OnMouseLeave(MouseEventArgs e);
+    }
+    public abstract class MultiSelector : Selector {
+        protected MultiSelector();
+        protected bool CanSelectMultipleItems { get; set; }
+        protected bool IsUpdatingSelectedItems { get; }
+        public IList SelectedItems { get; }
+        protected void BeginUpdateSelectedItems();
+        protected void EndUpdateSelectedItems();
+        public void SelectAll();
+        public void UnselectAll();
+    }
+    public enum PlacementMode {
+        Absolute = 0,
+        AbsolutePoint = 5,
+        Bottom = 2,
+        Center = 3,
+        Custom = 11,
+        Left = 9,
+        Mouse = 7,
+        MousePoint = 8,
+        Relative = 1,
+        RelativePoint = 6,
+        Right = 4,
+        Top = 10,
+    }
+    public class Popup : FrameworkElement, IAddChild {
+        public static readonly DependencyProperty AllowsTransparencyProperty;
+        public static readonly DependencyProperty ChildProperty;
+        public static readonly DependencyProperty CustomPopupPlacementCallbackProperty;
+        public static readonly DependencyProperty HasDropShadowProperty;
+        public static readonly DependencyProperty HorizontalOffsetProperty;
+        public static readonly DependencyProperty IsOpenProperty;
+        public static readonly DependencyProperty PlacementProperty;
+        public static readonly DependencyProperty PlacementRectangleProperty;
+        public static readonly DependencyProperty PlacementTargetProperty;
+        public static readonly DependencyProperty PopupAnimationProperty;
+        public static readonly DependencyProperty StaysOpenProperty;
+        public static readonly DependencyProperty VerticalOffsetProperty;
+        public Popup();
+        public bool AllowsTransparency { get; set; }
+        public UIElement Child { get; set; }
+        public CustomPopupPlacementCallback CustomPopupPlacementCallback { get; set; }
+        public bool HasDropShadow { get; }
+        public double HorizontalOffset { get; set; }
+        public bool IsOpen { get; set; }
+        protected internal override IEnumerator LogicalChildren { get; }
+        public PlacementMode Placement { get; set; }
+        public Rect PlacementRectangle { get; set; }
+        public UIElement PlacementTarget { get; set; }
+        public PopupAnimation PopupAnimation { get; set; }
+        public bool StaysOpen { get; set; }
+        public double VerticalOffset { get; set; }
+        public event EventHandler Closed;
+        public event EventHandler Opened;
+        public static void CreateRootPopup(Popup popup, UIElement child);
+        protected internal override DependencyObject GetUIParentCore();
+        protected override Size MeasureOverride(Size availableSize);
+        protected virtual void OnClosed(EventArgs e);
+        protected virtual void OnOpened(EventArgs e);
+        protected override void OnPreviewMouseLeftButtonDown(MouseButtonEventArgs e);
+        protected override void OnPreviewMouseLeftButtonUp(MouseButtonEventArgs e);
+        protected override void OnPreviewMouseRightButtonDown(MouseButtonEventArgs e);
+        protected override void OnPreviewMouseRightButtonUp(MouseButtonEventArgs e);
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public enum PopupAnimation {
+        Fade = 1,
+        None = 0,
+        Scroll = 3,
+        Slide = 2,
+    }
+    public enum PopupPrimaryAxis {
+        Horizontal = 1,
+        None = 0,
+        Vertical = 2,
+    }
+    public abstract class RangeBase : Control {
+        public static readonly DependencyProperty LargeChangeProperty;
+        public static readonly DependencyProperty MaximumProperty;
+        public static readonly DependencyProperty MinimumProperty;
+        public static readonly DependencyProperty SmallChangeProperty;
+        public static readonly DependencyProperty ValueProperty;
+        public static readonly RoutedEvent ValueChangedEvent;
+        protected RangeBase();
+        public double LargeChange { get; set; }
+        public double Maximum { get; set; }
+        public double Minimum { get; set; }
+        public double SmallChange { get; set; }
+        public double Value { get; set; }
+        public event RoutedPropertyChangedEventHandler<double> ValueChanged;
+        protected virtual void OnMaximumChanged(double oldMaximum, double newMaximum);
+        protected virtual void OnMinimumChanged(double oldMinimum, double newMinimum);
+        protected virtual void OnValueChanged(double oldValue, double newValue);
+        public override string ToString();
+    }
+    public class RepeatButton : ButtonBase {
+        public static readonly DependencyProperty DelayProperty;
+        public static readonly DependencyProperty IntervalProperty;
+        public RepeatButton();
+        public int Delay { get; set; }
+        public int Interval { get; set; }
+        protected override void OnClick();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected override void OnKeyUp(KeyEventArgs e);
+        protected override void OnLostMouseCapture(MouseEventArgs e);
+        protected override void OnMouseEnter(MouseEventArgs e);
+        protected override void OnMouseLeave(MouseEventArgs e);
+        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e);
+        protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e);
+    }
+    public class ResizeGrip : Control {
+        public ResizeGrip();
+    }
+    public class ScrollBar : RangeBase {
+        public static readonly DependencyProperty OrientationProperty;
+        public static readonly DependencyProperty ViewportSizeProperty;
+        public static readonly RoutedCommand DeferScrollToHorizontalOffsetCommand;
+        public static readonly RoutedCommand DeferScrollToVerticalOffsetCommand;
+        public static readonly RoutedCommand LineDownCommand;
+        public static readonly RoutedCommand LineLeftCommand;
+        public static readonly RoutedCommand LineRightCommand;
+        public static readonly RoutedCommand LineUpCommand;
+        public static readonly RoutedCommand PageDownCommand;
+        public static readonly RoutedCommand PageLeftCommand;
+        public static readonly RoutedCommand PageRightCommand;
+        public static readonly RoutedCommand PageUpCommand;
+        public static readonly RoutedCommand ScrollHereCommand;
+        public static readonly RoutedCommand ScrollToBottomCommand;
+        public static readonly RoutedCommand ScrollToEndCommand;
+        public static readonly RoutedCommand ScrollToHomeCommand;
+        public static readonly RoutedCommand ScrollToHorizontalOffsetCommand;
+        public static readonly RoutedCommand ScrollToLeftEndCommand;
+        public static readonly RoutedCommand ScrollToRightEndCommand;
+        public static readonly RoutedCommand ScrollToTopCommand;
+        public static readonly RoutedCommand ScrollToVerticalOffsetCommand;
+        public static readonly RoutedEvent ScrollEvent;
+        public ScrollBar();
+        protected override bool IsEnabledCore { get; }
+        public Orientation Orientation { get; set; }
+        public Track Track { get; }
+        public double ViewportSize { get; set; }
+        public event ScrollEventHandler Scroll;
+        public override void OnApplyTemplate();
+        protected override void OnContextMenuClosing(ContextMenuEventArgs e);
+        protected override void OnContextMenuOpening(ContextMenuEventArgs e);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnPreviewMouseLeftButtonDown(MouseButtonEventArgs e);
+        protected override void OnPreviewMouseRightButtonUp(MouseButtonEventArgs e);
+    }
+    public class ScrollEventArgs : RoutedEventArgs {
+        public ScrollEventArgs(ScrollEventType scrollEventType, double newValue);
+        public double NewValue { get; }
+        public ScrollEventType ScrollEventType { get; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void ScrollEventHandler(object sender, ScrollEventArgs e);
+    public enum ScrollEventType {
+        EndScroll = 0,
+        First = 1,
+        LargeDecrement = 2,
+        LargeIncrement = 3,
+        Last = 4,
+        SmallDecrement = 5,
+        SmallIncrement = 6,
+        ThumbPosition = 7,
+        ThumbTrack = 8,
+    }
+    public class SelectiveScrollingGrid : Grid {
+        public static readonly DependencyProperty SelectiveScrollingOrientationProperty;
+        public SelectiveScrollingGrid();
+        public static SelectiveScrollingOrientation GetSelectiveScrollingOrientation(DependencyObject obj);
+        public static void SetSelectiveScrollingOrientation(DependencyObject obj, SelectiveScrollingOrientation value);
+    }
+    public abstract class Selector : ItemsControl {
+        public static readonly DependencyProperty IsSelectedProperty;
+        public static readonly DependencyProperty IsSelectionActiveProperty;
+        public static readonly DependencyProperty IsSynchronizedWithCurrentItemProperty;
+        public static readonly DependencyProperty SelectedIndexProperty;
+        public static readonly DependencyProperty SelectedItemProperty;
+        public static readonly DependencyProperty SelectedValuePathProperty;
+        public static readonly DependencyProperty SelectedValueProperty;
+        public static readonly RoutedEvent SelectedEvent;
+        public static readonly RoutedEvent SelectionChangedEvent;
+        public static readonly RoutedEvent UnselectedEvent;
+        protected Selector();
+        public Nullable<bool> IsSynchronizedWithCurrentItem { get; set; }
+        public int SelectedIndex { get; set; }
+        public object SelectedItem { get; set; }
+        public object SelectedValue { get; set; }
+        public string SelectedValuePath { get; set; }
+        public event SelectionChangedEventHandler SelectionChanged;
+        public static void AddSelectedHandler(DependencyObject element, RoutedEventHandler handler);
+        public static void AddUnselectedHandler(DependencyObject element, RoutedEventHandler handler);
+        protected override void ClearContainerForItemOverride(DependencyObject element, object item);
+        public static bool GetIsSelected(DependencyObject element);
+        public static bool GetIsSelectionActive(DependencyObject element);
+        protected override void OnInitialized(EventArgs e);
+        protected override void OnIsKeyboardFocusWithinChanged(DependencyPropertyChangedEventArgs e);
+        protected override void OnItemsChanged(NotifyCollectionChangedEventArgs e);
+        protected override void OnItemsSourceChanged(IEnumerable oldValue, IEnumerable newValue);
+        protected virtual void OnSelectionChanged(SelectionChangedEventArgs e);
+        protected override void PrepareContainerForItemOverride(DependencyObject element, object item);
+        public static void RemoveSelectedHandler(DependencyObject element, RoutedEventHandler handler);
+        public static void RemoveUnselectedHandler(DependencyObject element, RoutedEventHandler handler);
+        public static void SetIsSelected(DependencyObject element, bool isSelected);
+    }
+    public class StatusBar : ItemsControl {
+        public static readonly DependencyProperty ItemContainerTemplateSelectorProperty;
+        public static readonly DependencyProperty UsesItemContainerTemplateProperty;
+        public StatusBar();
+        public ItemContainerTemplateSelector ItemContainerTemplateSelector { get; set; }
+        public static ResourceKey SeparatorStyleKey { get; }
+        public bool UsesItemContainerTemplate { get; set; }
+        protected override DependencyObject GetContainerForItemOverride();
+        protected override bool IsItemItsOwnContainerOverride(object item);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void PrepareContainerForItemOverride(DependencyObject element, object item);
+        protected override bool ShouldApplyItemContainerStyle(DependencyObject container, object item);
+    }
+    public class StatusBarItem : ContentControl {
+        public StatusBarItem();
+        protected override AutomationPeer OnCreateAutomationPeer();
+    }
+    public class TabPanel : Panel {
+        public TabPanel();
+        protected override Size ArrangeOverride(Size arrangeSize);
+        protected override Geometry GetLayoutClip(Size layoutSlotSize);
+        protected override Size MeasureOverride(Size constraint);
+    }
+    public abstract class TextBoxBase : Control {
+        public static readonly DependencyProperty AcceptsReturnProperty;
+        public static readonly DependencyProperty AcceptsTabProperty;
+        public static readonly DependencyProperty AutoWordSelectionProperty;
+        public static readonly DependencyProperty CaretBrushProperty;
+        public static readonly DependencyProperty HorizontalScrollBarVisibilityProperty;
+        public static readonly DependencyProperty IsInactiveSelectionHighlightEnabledProperty;
+        public static readonly DependencyProperty IsReadOnlyCaretVisibleProperty;
+        public static readonly DependencyProperty IsReadOnlyProperty;
+        public static readonly DependencyProperty IsSelectionActiveProperty;
+        public static readonly DependencyProperty IsUndoEnabledProperty;
+        public static readonly DependencyProperty SelectionBrushProperty;
+        public static readonly DependencyProperty SelectionOpacityProperty;
+        public static readonly DependencyProperty UndoLimitProperty;
+        public static readonly DependencyProperty VerticalScrollBarVisibilityProperty;
+        public static readonly RoutedEvent SelectionChangedEvent;
+        public static readonly RoutedEvent TextChangedEvent;
+        public bool AcceptsReturn { get; set; }
+        public bool AcceptsTab { get; set; }
+        public bool AutoWordSelection { get; set; }
+        public bool CanRedo { get; }
+        public bool CanUndo { get; }
+        public Brush CaretBrush { get; set; }
+        public double ExtentHeight { get; }
+        public double ExtentWidth { get; }
+        public double HorizontalOffset { get; }
+        public ScrollBarVisibility HorizontalScrollBarVisibility { get; set; }
+        public bool IsInactiveSelectionHighlightEnabled { get; set; }
+        public bool IsReadOnly { get; set; }
+        public bool IsReadOnlyCaretVisible { get; set; }
+        public bool IsSelectionActive { get; }
+        public bool IsUndoEnabled { get; set; }
+        public Brush SelectionBrush { get; set; }
+        public double SelectionOpacity { get; set; }
+        public SpellCheck SpellCheck { get; }
+        public int UndoLimit { get; set; }
+        public double VerticalOffset { get; }
+        public ScrollBarVisibility VerticalScrollBarVisibility { get; set; }
+        public double ViewportHeight { get; }
+        public double ViewportWidth { get; }
+        public event RoutedEventHandler SelectionChanged;
+        public event TextChangedEventHandler TextChanged;
+        public void AppendText(string textData);
+        public void BeginChange();
+        public void Copy();
+        public void Cut();
+        public IDisposable DeclareChangeBlock();
+        public void EndChange();
+        public void LineDown();
+        public void LineLeft();
+        public void LineRight();
+        public void LineUp();
+        public void LockCurrentUndoUnit();
+        public override void OnApplyTemplate();
+        protected override void OnContextMenuOpening(ContextMenuEventArgs e);
+        protected override void OnDragEnter(DragEventArgs e);
+        protected override void OnDragLeave(DragEventArgs e);
+        protected override void OnDragOver(DragEventArgs e);
+        protected override void OnDrop(DragEventArgs e);
+        protected override void OnGiveFeedback(GiveFeedbackEventArgs e);
+        protected override void OnGotKeyboardFocus(KeyboardFocusChangedEventArgs e);
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected override void OnKeyUp(KeyEventArgs e);
+        protected override void OnLostFocus(RoutedEventArgs e);
+        protected override void OnLostKeyboardFocus(KeyboardFocusChangedEventArgs e);
+        protected override void OnMouseDown(MouseButtonEventArgs e);
+        protected override void OnMouseMove(MouseEventArgs e);
+        protected override void OnMouseUp(MouseButtonEventArgs e);
+        protected override void OnMouseWheel(MouseWheelEventArgs e);
+        protected override void OnPreviewKeyDown(KeyEventArgs e);
+        protected override void OnQueryContinueDrag(QueryContinueDragEventArgs e);
+        protected override void OnQueryCursor(QueryCursorEventArgs e);
+        protected virtual void OnSelectionChanged(RoutedEventArgs e);
+        protected override void OnTemplateChanged(ControlTemplate oldTemplate, ControlTemplate newTemplate);
+        protected virtual void OnTextChanged(TextChangedEventArgs e);
+        protected override void OnTextInput(TextCompositionEventArgs e);
+        public void PageDown();
+        public void PageLeft();
+        public void PageRight();
+        public void PageUp();
+        public void Paste();
+        public bool Redo();
+        public void ScrollToEnd();
+        public void ScrollToHome();
+        public void ScrollToHorizontalOffset(double offset);
+        public void ScrollToVerticalOffset(double offset);
+        public void SelectAll();
+        public bool Undo();
+    }
+    public class Thumb : Control {
+        public static readonly DependencyProperty IsDraggingProperty;
+        public static readonly RoutedEvent DragCompletedEvent;
+        public static readonly RoutedEvent DragDeltaEvent;
+        public static readonly RoutedEvent DragStartedEvent;
+        public Thumb();
+        public bool IsDragging { get; protected set; }
+        public event DragCompletedEventHandler DragCompleted;
+        public event DragDeltaEventHandler DragDelta;
+        public event DragStartedEventHandler DragStarted;
+        public void CancelDrag();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected virtual void OnDraggingChanged(DependencyPropertyChangedEventArgs e);
+        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e);
+        protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e);
+        protected override void OnMouseMove(MouseEventArgs e);
+    }
+    public class TickBar : FrameworkElement {
+        public static readonly DependencyProperty FillProperty;
+        public static readonly DependencyProperty IsDirectionReversedProperty;
+        public static readonly DependencyProperty IsSelectionRangeEnabledProperty;
+        public static readonly DependencyProperty MaximumProperty;
+        public static readonly DependencyProperty MinimumProperty;
+        public static readonly DependencyProperty PlacementProperty;
+        public static readonly DependencyProperty ReservedSpaceProperty;
+        public static readonly DependencyProperty SelectionEndProperty;
+        public static readonly DependencyProperty SelectionStartProperty;
+        public static readonly DependencyProperty TickFrequencyProperty;
+        public static readonly DependencyProperty TicksProperty;
+        public TickBar();
+        public Brush Fill { get; set; }
+        public bool IsDirectionReversed { get; set; }
+        public bool IsSelectionRangeEnabled { get; set; }
+        public double Maximum { get; set; }
+        public double Minimum { get; set; }
+        public TickBarPlacement Placement { get; set; }
+        public double ReservedSpace { get; set; }
+        public double SelectionEnd { get; set; }
+        public double SelectionStart { get; set; }
+        public double TickFrequency { get; set; }
+        public DoubleCollection Ticks { get; set; }
+        protected override void OnRender(DrawingContext dc);
+    }
+    public enum TickBarPlacement {
+        Bottom = 3,
+        Left = 0,
+        Right = 2,
+        Top = 1,
+    }
+    public enum TickPlacement {
+        Both = 3,
+        BottomRight = 2,
+        None = 0,
+        TopLeft = 1,
+    }
+    public class ToggleButton : ButtonBase {
+        public static readonly DependencyProperty IsCheckedProperty;
+        public static readonly DependencyProperty IsThreeStateProperty;
+        public static readonly RoutedEvent CheckedEvent;
+        public static readonly RoutedEvent IndeterminateEvent;
+        public static readonly RoutedEvent UncheckedEvent;
+        public ToggleButton();
+        public Nullable<bool> IsChecked { get; set; }
+        public bool IsThreeState { get; set; }
+        public event RoutedEventHandler Checked;
+        public event RoutedEventHandler Indeterminate;
+        public event RoutedEventHandler Unchecked;
+        protected virtual void OnChecked(RoutedEventArgs e);
+        protected override void OnClick();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected virtual void OnIndeterminate(RoutedEventArgs e);
+        protected internal virtual void OnToggle();
+        protected virtual void OnUnchecked(RoutedEventArgs e);
+        public override string ToString();
+    }
+    public class ToolBarOverflowPanel : Panel {
+        public static readonly DependencyProperty WrapWidthProperty;
+        public ToolBarOverflowPanel();
+        public double WrapWidth { get; set; }
+        protected override Size ArrangeOverride(Size arrangeBounds);
+        protected override UIElementCollection CreateUIElementCollection(FrameworkElement logicalParent);
+        protected override Size MeasureOverride(Size constraint);
+    }
+    public class ToolBarPanel : StackPanel {
+        public ToolBarPanel();
+        protected override Size ArrangeOverride(Size arrangeSize);
+        protected override Size MeasureOverride(Size constraint);
+    }
+    public class Track : FrameworkElement {
+        public static readonly DependencyProperty IsDirectionReversedProperty;
+        public static readonly DependencyProperty MaximumProperty;
+        public static readonly DependencyProperty MinimumProperty;
+        public static readonly DependencyProperty OrientationProperty;
+        public static readonly DependencyProperty ValueProperty;
+        public static readonly DependencyProperty ViewportSizeProperty;
+        public Track();
+        public RepeatButton DecreaseRepeatButton { get; set; }
+        public RepeatButton IncreaseRepeatButton { get; set; }
+        public bool IsDirectionReversed { get; set; }
+        public double Maximum { get; set; }
+        public double Minimum { get; set; }
+        public Orientation Orientation { get; set; }
+        public Thumb Thumb { get; set; }
+        public double Value { get; set; }
+        public double ViewportSize { get; set; }
+        protected override int VisualChildrenCount { get; }
+        protected override Size ArrangeOverride(Size arrangeSize);
+        protected override Visual GetVisualChild(int index);
+        protected override Size MeasureOverride(Size availableSize);
+        public virtual double ValueFromDistance(double horizontal, double vertical);
+        public virtual double ValueFromPoint(Point pt);
+    }
+    public class UniformGrid : Panel {
+        public static readonly DependencyProperty ColumnsProperty;
+        public static readonly DependencyProperty FirstColumnProperty;
+        public static readonly DependencyProperty RowsProperty;
+        public UniformGrid();
+        public int Columns { get; set; }
+        public int FirstColumn { get; set; }
+        public int Rows { get; set; }
+        protected override Size ArrangeOverride(Size arrangeSize);
+        protected override Size MeasureOverride(Size constraint);
+    }
+}
```

