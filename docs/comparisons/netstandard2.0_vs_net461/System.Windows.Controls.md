# System.Windows.Controls

``` diff
+namespace System.Windows.Controls {
+    public class AccessText : FrameworkElement, IAddChild {
+        public static readonly DependencyProperty BackgroundProperty;
+        public static readonly DependencyProperty BaselineOffsetProperty;
+        public static readonly DependencyProperty FontFamilyProperty;
+        public static readonly DependencyProperty FontSizeProperty;
+        public static readonly DependencyProperty FontStretchProperty;
+        public static readonly DependencyProperty FontStyleProperty;
+        public static readonly DependencyProperty FontWeightProperty;
+        public static readonly DependencyProperty ForegroundProperty;
+        public static readonly DependencyProperty LineHeightProperty;
+        public static readonly DependencyProperty LineStackingStrategyProperty;
+        public static readonly DependencyProperty TextAlignmentProperty;
+        public static readonly DependencyProperty TextDecorationsProperty;
+        public static readonly DependencyProperty TextEffectsProperty;
+        public static readonly DependencyProperty TextProperty;
+        public static readonly DependencyProperty TextTrimmingProperty;
+        public static readonly DependencyProperty TextWrappingProperty;
+        public AccessText();
+        public char AccessKey { get; }
+        public Brush Background { get; set; }
+        public double BaselineOffset { get; set; }
+        public FontFamily FontFamily { get; set; }
+        public double FontSize { get; set; }
+        public FontStretch FontStretch { get; set; }
+        public FontStyle FontStyle { get; set; }
+        public FontWeight FontWeight { get; set; }
+        public Brush Foreground { get; set; }
+        public double LineHeight { get; set; }
+        public LineStackingStrategy LineStackingStrategy { get; set; }
+        protected internal override IEnumerator LogicalChildren { get; }
+        public string Text { get; set; }
+        public TextAlignment TextAlignment { get; set; }
+        public TextDecorationCollection TextDecorations { get; set; }
+        public TextEffectCollection TextEffects { get; set; }
+        public TextTrimming TextTrimming { get; set; }
+        public TextWrapping TextWrapping { get; set; }
+        protected override int VisualChildrenCount { get; }
+        protected sealed override Size ArrangeOverride(Size arrangeSize);
+        protected override Visual GetVisualChild(int index);
+        protected sealed override Size MeasureOverride(Size constraint);
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public class ActivatingKeyTipEventArgs : RoutedEventArgs {
+        public ActivatingKeyTipEventArgs();
+        public double KeyTipHorizontalOffset { get; set; }
+        public KeyTipHorizontalPlacement KeyTipHorizontalPlacement { get; set; }
+        public double KeyTipVerticalOffset { get; set; }
+        public KeyTipVerticalPlacement KeyTipVerticalPlacement { get; set; }
+        public Visibility KeyTipVisibility { get; set; }
+        public UIElement PlacementTarget { get; set; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void ActivatingKeyTipEventHandler(object sender, ActivatingKeyTipEventArgs e);
+    public class AddingNewItemEventArgs : EventArgs {
+        public AddingNewItemEventArgs();
+        public object NewItem { get; set; }
+    }
+    public class AdornedElementPlaceholder : FrameworkElement, IAddChild {
+        public AdornedElementPlaceholder();
+        public UIElement AdornedElement { get; }
+        public virtual UIElement Child { get; set; }
+        protected internal override IEnumerator LogicalChildren { get; }
+        protected override int VisualChildrenCount { get; }
+        protected override Size ArrangeOverride(Size arrangeBounds);
+        protected override Visual GetVisualChild(int index);
+        protected override Size MeasureOverride(Size constraint);
+        protected override void OnInitialized(EventArgs e);
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public class AlternationConverter : IValueConverter {
+        public AlternationConverter();
+        public IList Values { get; }
+        public object Convert(object o, Type targetType, object parameter, CultureInfo culture);
+        public object ConvertBack(object o, Type targetType, object parameter, CultureInfo culture);
+    }
+    public sealed class BooleanToVisibilityConverter : IValueConverter {
+        public BooleanToVisibilityConverter();
+        public object Convert(object value, Type targetType, object parameter, CultureInfo culture);
+        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);
+    }
+    public class Border : Decorator {
+        public static readonly DependencyProperty BackgroundProperty;
+        public static readonly DependencyProperty BorderBrushProperty;
+        public static readonly DependencyProperty BorderThicknessProperty;
+        public static readonly DependencyProperty CornerRadiusProperty;
+        public static readonly DependencyProperty PaddingProperty;
+        public Border();
+        public Brush Background { get; set; }
+        public Brush BorderBrush { get; set; }
+        public Thickness BorderThickness { get; set; }
+        public CornerRadius CornerRadius { get; set; }
+        public Thickness Padding { get; set; }
+        protected override Size ArrangeOverride(Size finalSize);
+        protected override Size MeasureOverride(Size constraint);
+        protected override void OnRender(DrawingContext dc);
+    }
+    public class BorderGapMaskConverter : IMultiValueConverter {
+        public BorderGapMaskConverter();
+        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture);
+        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture);
+    }
+    public class Button : ButtonBase {
+        public static readonly DependencyProperty IsCancelProperty;
+        public static readonly DependencyProperty IsDefaultedProperty;
+        public static readonly DependencyProperty IsDefaultProperty;
+        public Button();
+        public bool IsCancel { get; set; }
+        public bool IsDefault { get; set; }
+        public bool IsDefaulted { get; }
+        protected override void OnClick();
+        protected override AutomationPeer OnCreateAutomationPeer();
+    }
+    public class Calendar : Control {
+        public static readonly DependencyProperty CalendarButtonStyleProperty;
+        public static readonly DependencyProperty CalendarDayButtonStyleProperty;
+        public static readonly DependencyProperty CalendarItemStyleProperty;
+        public static readonly DependencyProperty DisplayDateEndProperty;
+        public static readonly DependencyProperty DisplayDateProperty;
+        public static readonly DependencyProperty DisplayDateStartProperty;
+        public static readonly DependencyProperty DisplayModeProperty;
+        public static readonly DependencyProperty FirstDayOfWeekProperty;
+        public static readonly DependencyProperty IsTodayHighlightedProperty;
+        public static readonly DependencyProperty SelectedDateProperty;
+        public static readonly DependencyProperty SelectionModeProperty;
+        public static readonly RoutedEvent SelectedDatesChangedEvent;
+        public Calendar();
+        public CalendarBlackoutDatesCollection BlackoutDates { get; }
+        public Style CalendarButtonStyle { get; set; }
+        public Style CalendarDayButtonStyle { get; set; }
+        public Style CalendarItemStyle { get; set; }
+        public DateTime DisplayDate { get; set; }
+        public Nullable<DateTime> DisplayDateEnd { get; set; }
+        public Nullable<DateTime> DisplayDateStart { get; set; }
+        public CalendarMode DisplayMode { get; set; }
+        public DayOfWeek FirstDayOfWeek { get; set; }
+        public bool IsTodayHighlighted { get; set; }
+        public Nullable<DateTime> SelectedDate { get; set; }
+        public SelectedDatesCollection SelectedDates { get; }
+        public CalendarSelectionMode SelectionMode { get; set; }
+        public event EventHandler<CalendarDateChangedEventArgs> DisplayDateChanged;
+        public event EventHandler<CalendarModeChangedEventArgs> DisplayModeChanged;
+        public event EventHandler<SelectionChangedEventArgs> SelectedDatesChanged;
+        public event EventHandler<EventArgs> SelectionModeChanged;
+        public override void OnApplyTemplate();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected virtual void OnDisplayDateChanged(CalendarDateChangedEventArgs e);
+        protected virtual void OnDisplayModeChanged(CalendarModeChangedEventArgs e);
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected override void OnKeyUp(KeyEventArgs e);
+        protected virtual void OnSelectedDatesChanged(SelectionChangedEventArgs e);
+        protected virtual void OnSelectionModeChanged(EventArgs e);
+        public override string ToString();
+    }
+    public sealed class CalendarBlackoutDatesCollection : ObservableCollection<CalendarDateRange> {
+        public CalendarBlackoutDatesCollection(Calendar owner);
+        public void AddDatesInPast();
+        protected override void ClearItems();
+        public bool Contains(DateTime date);
+        public bool Contains(DateTime start, DateTime end);
+        public bool ContainsAny(CalendarDateRange range);
+        protected override void InsertItem(int index, CalendarDateRange item);
+        protected override void RemoveItem(int index);
+        protected override void SetItem(int index, CalendarDateRange item);
+    }
+    public class CalendarDateChangedEventArgs : RoutedEventArgs {
+        public Nullable<DateTime> AddedDate { get; private set; }
+        public Nullable<DateTime> RemovedDate { get; private set; }
+    }
+    public sealed class CalendarDateRange : INotifyPropertyChanged {
+        public CalendarDateRange();
+        public CalendarDateRange(DateTime day);
+        public CalendarDateRange(DateTime start, DateTime end);
+        public DateTime End { get; set; }
+        public DateTime Start { get; set; }
+        public event PropertyChangedEventHandler PropertyChanged;
+    }
+    public enum CalendarMode {
+        Decade = 2,
+        Month = 0,
+        Year = 1,
+    }
+    public class CalendarModeChangedEventArgs : RoutedEventArgs {
+        public CalendarModeChangedEventArgs(CalendarMode oldMode, CalendarMode newMode);
+        public CalendarMode NewMode { get; private set; }
+        public CalendarMode OldMode { get; private set; }
+    }
+    public enum CalendarSelectionMode {
+        MultipleRange = 2,
+        None = 3,
+        SingleDate = 0,
+        SingleRange = 1,
+    }
+    public class Canvas : Panel {
+        public static readonly DependencyProperty BottomProperty;
+        public static readonly DependencyProperty LeftProperty;
+        public static readonly DependencyProperty RightProperty;
+        public static readonly DependencyProperty TopProperty;
+        public Canvas();
+        protected override Size ArrangeOverride(Size arrangeSize);
+        public static double GetBottom(UIElement element);
+        protected override Geometry GetLayoutClip(Size layoutSlotSize);
+        public static double GetLeft(UIElement element);
+        public static double GetRight(UIElement element);
+        public static double GetTop(UIElement element);
+        protected override Size MeasureOverride(Size constraint);
+        public static void SetBottom(UIElement element, double length);
+        public static void SetLeft(UIElement element, double length);
+        public static void SetRight(UIElement element, double length);
+        public static void SetTop(UIElement element, double length);
+    }
+    public enum CharacterCasing {
+        Lower = 1,
+        Normal = 0,
+        Upper = 2,
+    }
+    public class CheckBox : ToggleButton {
+        public CheckBox();
+        protected override void OnAccessKey(AccessKeyEventArgs e);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnKeyDown(KeyEventArgs e);
+    }
+    public class CleanUpVirtualizedItemEventArgs : RoutedEventArgs {
+        public CleanUpVirtualizedItemEventArgs(object value, UIElement element);
+        public bool Cancel { get; set; }
+        public UIElement UIElement { get; }
+        public object Value { get; }
+    }
+    public delegate void CleanUpVirtualizedItemEventHandler(object sender, CleanUpVirtualizedItemEventArgs e);
+    public enum ClickMode {
+        Hover = 2,
+        Press = 1,
+        Release = 0,
+    }
+    public class ColumnDefinition : DefinitionBase {
+        public static readonly DependencyProperty MaxWidthProperty;
+        public static readonly DependencyProperty MinWidthProperty;
+        public static readonly DependencyProperty WidthProperty;
+        public ColumnDefinition();
+        public double ActualWidth { get; }
+        public double MaxWidth { get; set; }
+        public double MinWidth { get; set; }
+        public double Offset { get; }
+        public GridLength Width { get; set; }
+    }
+    public sealed class ColumnDefinitionCollection : ICollection, ICollection<ColumnDefinition>, IEnumerable, IEnumerable<ColumnDefinition>, IList, IList<ColumnDefinition> {
+        public int Count { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public ColumnDefinition this[int index] { get; set; }
+        public void Add(ColumnDefinition value);
+        public void Clear();
+        public bool Contains(ColumnDefinition value);
+        public void CopyTo(ColumnDefinition[] array, int index);
+        public int IndexOf(ColumnDefinition value);
+        public void Insert(int index, ColumnDefinition value);
+        public bool Remove(ColumnDefinition value);
+        public void RemoveAt(int index);
+        public void RemoveRange(int index, int count);
+        IEnumerator<ColumnDefinition> System.Collections.Generic.IEnumerable<System.Windows.Controls.ColumnDefinition>.GetEnumerator();
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+    }
+    public class ComboBox : Selector {
+        public static readonly DependencyProperty IsDropDownOpenProperty;
+        public static readonly DependencyProperty IsEditableProperty;
+        public static readonly DependencyProperty IsReadOnlyProperty;
+        public static readonly DependencyProperty MaxDropDownHeightProperty;
+        public static readonly DependencyProperty SelectionBoxItemProperty;
+        public static readonly DependencyProperty SelectionBoxItemStringFormatProperty;
+        public static readonly DependencyProperty SelectionBoxItemTemplateProperty;
+        public static readonly DependencyProperty ShouldPreserveUserEnteredPrefixProperty;
+        public static readonly DependencyProperty StaysOpenOnEditProperty;
+        public static readonly DependencyProperty TextProperty;
+        public ComboBox();
+        protected internal override bool HandlesScrolling { get; }
+        protected internal override bool HasEffectiveKeyboardFocus { get; }
+        public bool IsDropDownOpen { get; set; }
+        public bool IsEditable { get; set; }
+        public bool IsReadOnly { get; set; }
+        public bool IsSelectionBoxHighlighted { get; }
+        public double MaxDropDownHeight { get; set; }
+        public object SelectionBoxItem { get; private set; }
+        public string SelectionBoxItemStringFormat { get; private set; }
+        public DataTemplate SelectionBoxItemTemplate { get; private set; }
+        public bool ShouldPreserveUserEnteredPrefix { get; set; }
+        public bool StaysOpenOnEdit { get; set; }
+        public string Text { get; set; }
+        public event EventHandler DropDownClosed;
+        public event EventHandler DropDownOpened;
+        protected override DependencyObject GetContainerForItemOverride();
+        protected override bool IsItemItsOwnContainerOverride(object item);
+        public override void OnApplyTemplate();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected virtual void OnDropDownClosed(EventArgs e);
+        protected virtual void OnDropDownOpened(EventArgs e);
+        protected override void OnIsKeyboardFocusWithinChanged(DependencyPropertyChangedEventArgs e);
+        protected override void OnIsMouseCapturedChanged(DependencyPropertyChangedEventArgs e);
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e);
+        protected override void OnPreviewKeyDown(KeyEventArgs e);
+        protected override void OnSelectionChanged(SelectionChangedEventArgs e);
+        protected override void PrepareContainerForItemOverride(DependencyObject element, object item);
+    }
+    public class ComboBoxItem : ListBoxItem {
+        public static readonly DependencyProperty IsHighlightedProperty;
+        public ComboBoxItem();
+        public bool IsHighlighted { get; protected set; }
+        protected override void OnContentChanged(object oldContent, object newContent);
+        protected override void OnGotKeyboardFocus(KeyboardFocusChangedEventArgs e);
+        protected override void OnMouseEnter(MouseEventArgs e);
+        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e);
+        protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e);
+    }
+    public class ContentControl : Control, IAddChild {
+        public static readonly DependencyProperty ContentProperty;
+        public static readonly DependencyProperty ContentStringFormatProperty;
+        public static readonly DependencyProperty ContentTemplateProperty;
+        public static readonly DependencyProperty ContentTemplateSelectorProperty;
+        public static readonly DependencyProperty HasContentProperty;
+        public ContentControl();
+        public object Content { get; set; }
+        public string ContentStringFormat { get; set; }
+        public DataTemplate ContentTemplate { get; set; }
+        public DataTemplateSelector ContentTemplateSelector { get; set; }
+        public bool HasContent { get; }
+        protected internal override IEnumerator LogicalChildren { get; }
+        protected virtual void AddChild(object value);
+        protected virtual void AddText(string text);
+        protected virtual void OnContentChanged(object oldContent, object newContent);
+        protected virtual void OnContentStringFormatChanged(string oldContentStringFormat, string newContentStringFormat);
+        protected virtual void OnContentTemplateChanged(DataTemplate oldContentTemplate, DataTemplate newContentTemplate);
+        protected virtual void OnContentTemplateSelectorChanged(DataTemplateSelector oldContentTemplateSelector, DataTemplateSelector newContentTemplateSelector);
+        public virtual bool ShouldSerializeContent();
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public class ContentPresenter : FrameworkElement {
+        public static readonly DependencyProperty ContentProperty;
+        public static readonly DependencyProperty ContentSourceProperty;
+        public static readonly DependencyProperty ContentStringFormatProperty;
+        public static readonly DependencyProperty ContentTemplateProperty;
+        public static readonly DependencyProperty ContentTemplateSelectorProperty;
+        public static readonly DependencyProperty RecognizesAccessKeyProperty;
+        public ContentPresenter();
+        public object Content { get; set; }
+        public string ContentSource { get; set; }
+        public string ContentStringFormat { get; set; }
+        public DataTemplate ContentTemplate { get; set; }
+        public DataTemplateSelector ContentTemplateSelector { get; set; }
+        public bool RecognizesAccessKey { get; set; }
+        protected override Size ArrangeOverride(Size arrangeSize);
+        protected virtual DataTemplate ChooseTemplate();
+        protected override Size MeasureOverride(Size constraint);
+        protected virtual void OnContentStringFormatChanged(string oldContentStringFormat, string newContentStringFormat);
+        protected virtual void OnContentTemplateChanged(DataTemplate oldContentTemplate, DataTemplate newContentTemplate);
+        protected virtual void OnContentTemplateSelectorChanged(DataTemplateSelector oldContentTemplateSelector, DataTemplateSelector newContentTemplateSelector);
+        protected virtual void OnTemplateChanged(DataTemplate oldTemplate, DataTemplate newTemplate);
+        public bool ShouldSerializeContentTemplateSelector();
+    }
+    public class ContextMenu : MenuBase {
+        public static readonly DependencyProperty CustomPopupPlacementCallbackProperty;
+        public static readonly DependencyProperty HasDropShadowProperty;
+        public static readonly DependencyProperty HorizontalOffsetProperty;
+        public static readonly DependencyProperty IsOpenProperty;
+        public static readonly DependencyProperty PlacementProperty;
+        public static readonly DependencyProperty PlacementRectangleProperty;
+        public static readonly DependencyProperty PlacementTargetProperty;
+        public static readonly DependencyProperty StaysOpenProperty;
+        public static readonly DependencyProperty VerticalOffsetProperty;
+        public static readonly RoutedEvent ClosedEvent;
+        public static readonly RoutedEvent OpenedEvent;
+        public ContextMenu();
+        public CustomPopupPlacementCallback CustomPopupPlacementCallback { get; set; }
+        protected internal override bool HandlesScrolling { get; }
+        public bool HasDropShadow { get; set; }
+        public double HorizontalOffset { get; set; }
+        public bool IsOpen { get; set; }
+        public PlacementMode Placement { get; set; }
+        public Rect PlacementRectangle { get; set; }
+        public UIElement PlacementTarget { get; set; }
+        public bool StaysOpen { get; set; }
+        public double VerticalOffset { get; set; }
+        public event RoutedEventHandler Closed;
+        public event RoutedEventHandler Opened;
+        protected virtual void OnClosed(RoutedEventArgs e);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnIsKeyboardFocusWithinChanged(DependencyPropertyChangedEventArgs e);
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected override void OnKeyUp(KeyEventArgs e);
+        protected virtual void OnOpened(RoutedEventArgs e);
+        protected internal override void OnVisualParentChanged(DependencyObject oldParent);
+        protected override void PrepareContainerForItemOverride(DependencyObject element, object item);
+    }
+    public sealed class ContextMenuEventArgs : RoutedEventArgs {
+        public double CursorLeft { get; }
+        public double CursorTop { get; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void ContextMenuEventHandler(object sender, ContextMenuEventArgs e);
+    public static class ContextMenuService {
+        public static readonly DependencyProperty ContextMenuProperty;
+        public static readonly DependencyProperty HasDropShadowProperty;
+        public static readonly DependencyProperty HorizontalOffsetProperty;
+        public static readonly DependencyProperty IsEnabledProperty;
+        public static readonly DependencyProperty PlacementProperty;
+        public static readonly DependencyProperty PlacementRectangleProperty;
+        public static readonly DependencyProperty PlacementTargetProperty;
+        public static readonly DependencyProperty ShowOnDisabledProperty;
+        public static readonly DependencyProperty VerticalOffsetProperty;
+        public static readonly RoutedEvent ContextMenuClosingEvent;
+        public static readonly RoutedEvent ContextMenuOpeningEvent;
+        public static void AddContextMenuClosingHandler(DependencyObject element, ContextMenuEventHandler handler);
+        public static void AddContextMenuOpeningHandler(DependencyObject element, ContextMenuEventHandler handler);
+        public static ContextMenu GetContextMenu(DependencyObject element);
+        public static bool GetHasDropShadow(DependencyObject element);
+        public static double GetHorizontalOffset(DependencyObject element);
+        public static bool GetIsEnabled(DependencyObject element);
+        public static PlacementMode GetPlacement(DependencyObject element);
+        public static Rect GetPlacementRectangle(DependencyObject element);
+        public static UIElement GetPlacementTarget(DependencyObject element);
+        public static bool GetShowOnDisabled(DependencyObject element);
+        public static double GetVerticalOffset(DependencyObject element);
+        public static void RemoveContextMenuClosingHandler(DependencyObject element, ContextMenuEventHandler handler);
+        public static void RemoveContextMenuOpeningHandler(DependencyObject element, ContextMenuEventHandler handler);
+        public static void SetContextMenu(DependencyObject element, ContextMenu value);
+        public static void SetHasDropShadow(DependencyObject element, bool value);
+        public static void SetHorizontalOffset(DependencyObject element, double value);
+        public static void SetIsEnabled(DependencyObject element, bool value);
+        public static void SetPlacement(DependencyObject element, PlacementMode value);
+        public static void SetPlacementRectangle(DependencyObject element, Rect value);
+        public static void SetPlacementTarget(DependencyObject element, UIElement value);
+        public static void SetShowOnDisabled(DependencyObject element, bool value);
+        public static void SetVerticalOffset(DependencyObject element, double value);
+    }
+    public class Control : FrameworkElement {
+        public static readonly DependencyProperty BackgroundProperty;
+        public static readonly DependencyProperty BorderBrushProperty;
+        public static readonly DependencyProperty BorderThicknessProperty;
+        public static readonly DependencyProperty FontFamilyProperty;
+        public static readonly DependencyProperty FontSizeProperty;
+        public static readonly DependencyProperty FontStretchProperty;
+        public static readonly DependencyProperty FontStyleProperty;
+        public static readonly DependencyProperty FontWeightProperty;
+        public static readonly DependencyProperty ForegroundProperty;
+        public static readonly DependencyProperty HorizontalContentAlignmentProperty;
+        public static readonly DependencyProperty IsTabStopProperty;
+        public static readonly DependencyProperty PaddingProperty;
+        public static readonly DependencyProperty TabIndexProperty;
+        public static readonly DependencyProperty TemplateProperty;
+        public static readonly DependencyProperty VerticalContentAlignmentProperty;
+        public static readonly RoutedEvent MouseDoubleClickEvent;
+        public static readonly RoutedEvent PreviewMouseDoubleClickEvent;
+        public Control();
+        public Brush Background { get; set; }
+        public Brush BorderBrush { get; set; }
+        public Thickness BorderThickness { get; set; }
+        public FontFamily FontFamily { get; set; }
+        public double FontSize { get; set; }
+        public FontStretch FontStretch { get; set; }
+        public FontStyle FontStyle { get; set; }
+        public FontWeight FontWeight { get; set; }
+        public Brush Foreground { get; set; }
+        protected internal virtual bool HandlesScrolling { get; }
+        public HorizontalAlignment HorizontalContentAlignment { get; set; }
+        public bool IsTabStop { get; set; }
+        public Thickness Padding { get; set; }
+        public int TabIndex { get; set; }
+        public ControlTemplate Template { get; set; }
+        public VerticalAlignment VerticalContentAlignment { get; set; }
+        public event MouseButtonEventHandler MouseDoubleClick;
+        public event MouseButtonEventHandler PreviewMouseDoubleClick;
+        protected override Size ArrangeOverride(Size arrangeBounds);
+        protected override Size MeasureOverride(Size constraint);
+        protected virtual void OnMouseDoubleClick(MouseButtonEventArgs e);
+        protected virtual void OnPreviewMouseDoubleClick(MouseButtonEventArgs e);
+        protected virtual void OnTemplateChanged(ControlTemplate oldTemplate, ControlTemplate newTemplate);
+        public override string ToString();
+    }
+    public class ControlTemplate : FrameworkTemplate {
+        public ControlTemplate();
+        public ControlTemplate(Type targetType);
+        public Type TargetType { get; set; }
+        public TriggerCollection Triggers { get; }
+        protected override void ValidateTemplatedParent(FrameworkElement templatedParent);
+    }
+    public sealed class DataErrorValidationRule : ValidationRule {
+        public DataErrorValidationRule();
+        public override ValidationResult Validate(object value, CultureInfo cultureInfo);
+    }
+    public class DataGrid : MultiSelector {
+        public static readonly DependencyProperty AlternatingRowBackgroundProperty;
+        public static readonly DependencyProperty AreRowDetailsFrozenProperty;
+        public static readonly DependencyProperty AutoGenerateColumnsProperty;
+        public static readonly DependencyProperty CanUserAddRowsProperty;
+        public static readonly DependencyProperty CanUserDeleteRowsProperty;
+        public static readonly DependencyProperty CanUserReorderColumnsProperty;
+        public static readonly DependencyProperty CanUserResizeColumnsProperty;
+        public static readonly DependencyProperty CanUserResizeRowsProperty;
+        public static readonly DependencyProperty CanUserSortColumnsProperty;
+        public static readonly DependencyProperty CellsPanelHorizontalOffsetProperty;
+        public static readonly DependencyProperty CellStyleProperty;
+        public static readonly DependencyProperty ClipboardCopyModeProperty;
+        public static readonly DependencyProperty ColumnHeaderHeightProperty;
+        public static readonly DependencyProperty ColumnHeaderStyleProperty;
+        public static readonly DependencyProperty ColumnWidthProperty;
+        public static readonly DependencyProperty CurrentCellProperty;
+        public static readonly DependencyProperty CurrentColumnProperty;
+        public static readonly DependencyProperty CurrentItemProperty;
+        public static readonly DependencyProperty DragIndicatorStyleProperty;
+        public static readonly DependencyProperty DropLocationIndicatorStyleProperty;
+        public static readonly DependencyProperty EnableColumnVirtualizationProperty;
+        public static readonly DependencyProperty EnableRowVirtualizationProperty;
+        public static readonly DependencyProperty FrozenColumnCountProperty;
+        public static readonly DependencyProperty GridLinesVisibilityProperty;
+        public static readonly DependencyProperty HeadersVisibilityProperty;
+        public static readonly DependencyProperty HorizontalGridLinesBrushProperty;
+        public static readonly DependencyProperty HorizontalScrollBarVisibilityProperty;
+        public static readonly DependencyProperty IsReadOnlyProperty;
+        public static readonly DependencyProperty MaxColumnWidthProperty;
+        public static readonly DependencyProperty MinColumnWidthProperty;
+        public static readonly DependencyProperty MinRowHeightProperty;
+        public static readonly DependencyProperty NewItemMarginProperty;
+        public static readonly DependencyProperty NonFrozenColumnsViewportHorizontalOffsetProperty;
+        public static readonly DependencyProperty RowBackgroundProperty;
+        public static readonly DependencyProperty RowDetailsTemplateProperty;
+        public static readonly DependencyProperty RowDetailsTemplateSelectorProperty;
+        public static readonly DependencyProperty RowDetailsVisibilityModeProperty;
+        public static readonly DependencyProperty RowHeaderActualWidthProperty;
+        public static readonly DependencyProperty RowHeaderStyleProperty;
+        public static readonly DependencyProperty RowHeaderTemplateProperty;
+        public static readonly DependencyProperty RowHeaderTemplateSelectorProperty;
+        public static readonly DependencyProperty RowHeaderWidthProperty;
+        public static readonly DependencyProperty RowHeightProperty;
+        public static readonly DependencyProperty RowStyleProperty;
+        public static readonly DependencyProperty RowStyleSelectorProperty;
+        public static readonly DependencyProperty RowValidationErrorTemplateProperty;
+        public static readonly DependencyProperty SelectionModeProperty;
+        public static readonly DependencyProperty SelectionUnitProperty;
+        public static readonly DependencyProperty VerticalGridLinesBrushProperty;
+        public static readonly DependencyProperty VerticalScrollBarVisibilityProperty;
+        public static readonly RoutedCommand BeginEditCommand;
+        public static readonly RoutedCommand CancelEditCommand;
+        public static readonly RoutedCommand CommitEditCommand;
+        public DataGrid();
+        public Brush AlternatingRowBackground { get; set; }
+        public bool AreRowDetailsFrozen { get; set; }
+        public bool AutoGenerateColumns { get; set; }
+        public bool CanUserAddRows { get; set; }
+        public bool CanUserDeleteRows { get; set; }
+        public bool CanUserReorderColumns { get; set; }
+        public bool CanUserResizeColumns { get; set; }
+        public bool CanUserResizeRows { get; set; }
+        public bool CanUserSortColumns { get; set; }
+        public double CellsPanelHorizontalOffset { get; private set; }
+        public Style CellStyle { get; set; }
+        public DataGridClipboardCopyMode ClipboardCopyMode { get; set; }
+        public double ColumnHeaderHeight { get; set; }
+        public Style ColumnHeaderStyle { get; set; }
+        public ObservableCollection<DataGridColumn> Columns { get; }
+        public DataGridLength ColumnWidth { get; set; }
+        public DataGridCellInfo CurrentCell { get; set; }
+        public DataGridColumn CurrentColumn { get; set; }
+        public object CurrentItem { get; set; }
+        public static RoutedUICommand DeleteCommand { get; }
+        public Style DragIndicatorStyle { get; set; }
+        public Style DropLocationIndicatorStyle { get; set; }
+        public bool EnableColumnVirtualization { get; set; }
+        public bool EnableRowVirtualization { get; set; }
+        public static ComponentResourceKey FocusBorderBrushKey { get; }
+        public int FrozenColumnCount { get; set; }
+        public DataGridGridLinesVisibility GridLinesVisibility { get; set; }
+        protected internal override bool HandlesScrolling { get; }
+        public DataGridHeadersVisibility HeadersVisibility { get; set; }
+        public static IValueConverter HeadersVisibilityConverter { get; }
+        public Brush HorizontalGridLinesBrush { get; set; }
+        public ScrollBarVisibility HorizontalScrollBarVisibility { get; set; }
+        public bool IsReadOnly { get; set; }
+        public double MaxColumnWidth { get; set; }
+        public double MinColumnWidth { get; set; }
+        public double MinRowHeight { get; set; }
+        public Thickness NewItemMargin { get; private set; }
+        public double NonFrozenColumnsViewportHorizontalOffset { get; internal set; }
+        public Brush RowBackground { get; set; }
+        public static IValueConverter RowDetailsScrollingConverter { get; }
+        public DataTemplate RowDetailsTemplate { get; set; }
+        public DataTemplateSelector RowDetailsTemplateSelector { get; set; }
+        public DataGridRowDetailsVisibilityMode RowDetailsVisibilityMode { get; set; }
+        public double RowHeaderActualWidth { get; internal set; }
+        public Style RowHeaderStyle { get; set; }
+        public DataTemplate RowHeaderTemplate { get; set; }
+        public DataTemplateSelector RowHeaderTemplateSelector { get; set; }
+        public double RowHeaderWidth { get; set; }
+        public double RowHeight { get; set; }
+        public Style RowStyle { get; set; }
+        public StyleSelector RowStyleSelector { get; set; }
+        public ControlTemplate RowValidationErrorTemplate { get; set; }
+        public ObservableCollection<ValidationRule> RowValidationRules { get; }
+        public static RoutedUICommand SelectAllCommand { get; }
+        public IList<DataGridCellInfo> SelectedCells { get; }
+        public DataGridSelectionMode SelectionMode { get; set; }
+        public DataGridSelectionUnit SelectionUnit { get; set; }
+        public Brush VerticalGridLinesBrush { get; set; }
+        public ScrollBarVisibility VerticalScrollBarVisibility { get; set; }
+        public event EventHandler<AddingNewItemEventArgs> AddingNewItem;
+        public event EventHandler AutoGeneratedColumns;
+        public event EventHandler<DataGridAutoGeneratingColumnEventArgs> AutoGeneratingColumn;
+        public event EventHandler<DataGridBeginningEditEventArgs> BeginningEdit;
+        public event EventHandler<DataGridCellEditEndingEventArgs> CellEditEnding;
+        public event EventHandler<DataGridColumnEventArgs> ColumnDisplayIndexChanged;
+        public event EventHandler<DragCompletedEventArgs> ColumnHeaderDragCompleted;
+        public event EventHandler<DragDeltaEventArgs> ColumnHeaderDragDelta;
+        public event EventHandler<DragStartedEventArgs> ColumnHeaderDragStarted;
+        public event EventHandler<DataGridColumnEventArgs> ColumnReordered;
+        public event EventHandler<DataGridColumnReorderingEventArgs> ColumnReordering;
+        public event EventHandler<DataGridRowClipboardEventArgs> CopyingRowClipboardContent;
+        public event EventHandler<EventArgs> CurrentCellChanged;
+        public event InitializingNewItemEventHandler InitializingNewItem;
+        public event EventHandler<DataGridRowEventArgs> LoadingRow;
+        public event EventHandler<DataGridRowDetailsEventArgs> LoadingRowDetails;
+        public event EventHandler<DataGridPreparingCellForEditEventArgs> PreparingCellForEdit;
+        public event EventHandler<DataGridRowDetailsEventArgs> RowDetailsVisibilityChanged;
+        public event EventHandler<DataGridRowEditEndingEventArgs> RowEditEnding;
+        public event SelectedCellsChangedEventHandler SelectedCellsChanged;
+        public event DataGridSortingEventHandler Sorting;
+        public event EventHandler<DataGridRowEventArgs> UnloadingRow;
+        public event EventHandler<DataGridRowDetailsEventArgs> UnloadingRowDetails;
+        public bool BeginEdit();
+        public bool BeginEdit(RoutedEventArgs editingEventArgs);
+        public bool CancelEdit();
+        public bool CancelEdit(DataGridEditingUnit editingUnit);
+        protected override void ClearContainerForItemOverride(DependencyObject element, object item);
+        public void ClearDetailsVisibilityForItem(object item);
+        public DataGridColumn ColumnFromDisplayIndex(int displayIndex);
+        public bool CommitEdit();
+        public bool CommitEdit(DataGridEditingUnit editingUnit, bool exitEditingMode);
+        public static Collection<DataGridColumn> GenerateColumns(IItemProperties itemProperties);
+        protected override DependencyObject GetContainerForItemOverride();
+        public Visibility GetDetailsVisibilityForItem(object item);
+        protected override bool IsItemItsOwnContainerOverride(object item);
+        protected override Size MeasureOverride(Size availableSize);
+        protected virtual void OnAddingNewItem(AddingNewItemEventArgs e);
+        public override void OnApplyTemplate();
+        protected virtual void OnAutoGeneratedColumns(EventArgs e);
+        protected virtual void OnAutoGeneratingColumn(DataGridAutoGeneratingColumnEventArgs e);
+        protected virtual void OnBeginningEdit(DataGridBeginningEditEventArgs e);
+        protected virtual void OnCanExecuteBeginEdit(CanExecuteRoutedEventArgs e);
+        protected virtual void OnCanExecuteCancelEdit(CanExecuteRoutedEventArgs e);
+        protected virtual void OnCanExecuteCommitEdit(CanExecuteRoutedEventArgs e);
+        protected virtual void OnCanExecuteCopy(CanExecuteRoutedEventArgs args);
+        protected virtual void OnCanExecuteDelete(CanExecuteRoutedEventArgs e);
+        protected virtual void OnCellEditEnding(DataGridCellEditEndingEventArgs e);
+        protected internal virtual void OnColumnDisplayIndexChanged(DataGridColumnEventArgs e);
+        protected internal virtual void OnColumnHeaderDragCompleted(DragCompletedEventArgs e);
+        protected internal virtual void OnColumnHeaderDragDelta(DragDeltaEventArgs e);
+        protected internal virtual void OnColumnHeaderDragStarted(DragStartedEventArgs e);
+        protected internal virtual void OnColumnReordered(DataGridColumnEventArgs e);
+        protected internal virtual void OnColumnReordering(DataGridColumnReorderingEventArgs e);
+        protected override void OnContextMenuOpening(ContextMenuEventArgs e);
+        protected virtual void OnCopyingRowClipboardContent(DataGridRowClipboardEventArgs args);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected virtual void OnCurrentCellChanged(EventArgs e);
+        protected virtual void OnExecutedBeginEdit(ExecutedRoutedEventArgs e);
+        protected virtual void OnExecutedCancelEdit(ExecutedRoutedEventArgs e);
+        protected virtual void OnExecutedCommitEdit(ExecutedRoutedEventArgs e);
+        protected virtual void OnExecutedCopy(ExecutedRoutedEventArgs args);
+        protected virtual void OnExecutedDelete(ExecutedRoutedEventArgs e);
+        protected virtual void OnInitializingNewItem(InitializingNewItemEventArgs e);
+        protected override void OnIsMouseCapturedChanged(DependencyPropertyChangedEventArgs e);
+        protected override void OnItemsChanged(NotifyCollectionChangedEventArgs e);
+        protected override void OnItemsSourceChanged(IEnumerable oldValue, IEnumerable newValue);
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected virtual void OnLoadingRow(DataGridRowEventArgs e);
+        protected virtual void OnLoadingRowDetails(DataGridRowDetailsEventArgs e);
+        protected override void OnMouseMove(MouseEventArgs e);
+        protected internal virtual void OnPreparingCellForEdit(DataGridPreparingCellForEditEventArgs e);
+        protected internal virtual void OnRowDetailsVisibilityChanged(DataGridRowDetailsEventArgs e);
+        protected virtual void OnRowEditEnding(DataGridRowEditEndingEventArgs e);
+        protected virtual void OnSelectedCellsChanged(SelectedCellsChangedEventArgs e);
+        protected override void OnSelectionChanged(SelectionChangedEventArgs e);
+        protected virtual void OnSorting(DataGridSortingEventArgs eventArgs);
+        protected override void OnTemplateChanged(ControlTemplate oldTemplate, ControlTemplate newTemplate);
+        protected override void OnTextInput(TextCompositionEventArgs e);
+        protected virtual void OnUnloadingRow(DataGridRowEventArgs e);
+        protected virtual void OnUnloadingRowDetails(DataGridRowDetailsEventArgs e);
+        protected override void PrepareContainerForItemOverride(DependencyObject element, object item);
+        public void ScrollIntoView(object item);
+        public void ScrollIntoView(object item, DataGridColumn column);
+        public void SelectAllCells();
+        public void SetDetailsVisibilityForItem(object item, Visibility detailsVisibility);
+        public void UnselectAllCells();
+    }
+    public class DataGridAutoGeneratingColumnEventArgs : EventArgs {
+        public DataGridAutoGeneratingColumnEventArgs(string propertyName, Type propertyType, DataGridColumn column);
+        public bool Cancel { get; set; }
+        public DataGridColumn Column { get; set; }
+        public object PropertyDescriptor { get; private set; }
+        public string PropertyName { get; }
+        public Type PropertyType { get; }
+    }
+    public class DataGridBeginningEditEventArgs : EventArgs {
+        public DataGridBeginningEditEventArgs(DataGridColumn column, DataGridRow row, RoutedEventArgs editingEventArgs);
+        public bool Cancel { get; set; }
+        public DataGridColumn Column { get; }
+        public RoutedEventArgs EditingEventArgs { get; }
+        public DataGridRow Row { get; }
+    }
+    public abstract class DataGridBoundColumn : DataGridColumn {
+        public static readonly DependencyProperty EditingElementStyleProperty;
+        public static readonly DependencyProperty ElementStyleProperty;
+        protected DataGridBoundColumn();
+        public virtual BindingBase Binding { get; set; }
+        public override BindingBase ClipboardContentBinding { get; set; }
+        public Style EditingElementStyle { get; set; }
+        public Style ElementStyle { get; set; }
+        protected virtual void OnBindingChanged(BindingBase oldBinding, BindingBase newBinding);
+        protected override bool OnCoerceIsReadOnly(bool baseValue);
+        protected internal override void RefreshCellContent(FrameworkElement element, string propertyName);
+    }
+    public class DataGridCell : ContentControl, IProvideDataGridColumn {
+        public static readonly DependencyProperty ColumnProperty;
+        public static readonly DependencyProperty IsEditingProperty;
+        public static readonly DependencyProperty IsReadOnlyProperty;
+        public static readonly DependencyProperty IsSelectedProperty;
+        public static readonly RoutedEvent SelectedEvent;
+        public static readonly RoutedEvent UnselectedEvent;
+        public DataGridCell();
+        public DataGridColumn Column { get; internal set; }
+        public bool IsEditing { get; set; }
+        public bool IsReadOnly { get; }
+        public bool IsSelected { get; set; }
+        public event RoutedEventHandler Selected;
+        public event RoutedEventHandler Unselected;
+        protected override Size ArrangeOverride(Size arrangeSize);
+        protected override Size MeasureOverride(Size constraint);
+        protected virtual void OnColumnChanged(DataGridColumn oldColumn, DataGridColumn newColumn);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected virtual void OnIsEditingChanged(bool isEditing);
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected override void OnPreviewKeyDown(KeyEventArgs e);
+        protected override void OnRender(DrawingContext drawingContext);
+        protected virtual void OnSelected(RoutedEventArgs e);
+        protected override void OnTextInput(TextCompositionEventArgs e);
+        protected virtual void OnUnselected(RoutedEventArgs e);
+    }
+    public class DataGridCellClipboardEventArgs : EventArgs {
+        public DataGridCellClipboardEventArgs(object item, DataGridColumn column, object content);
+        public DataGridColumn Column { get; }
+        public object Content { get; set; }
+        public object Item { get; }
+    }
+    public class DataGridCellEditEndingEventArgs : EventArgs {
+        public DataGridCellEditEndingEventArgs(DataGridColumn column, DataGridRow row, FrameworkElement editingElement, DataGridEditAction editAction);
+        public bool Cancel { get; set; }
+        public DataGridColumn Column { get; }
+        public DataGridEditAction EditAction { get; }
+        public FrameworkElement EditingElement { get; }
+        public DataGridRow Row { get; }
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct DataGridCellInfo {
+        public DataGridCellInfo(object item, DataGridColumn column);
+        public DataGridCellInfo(DataGridCell cell);
+        public DataGridColumn Column { get; }
+        public bool IsValid { get; }
+        public object Item { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public static bool operator ==(DataGridCellInfo cell1, DataGridCellInfo cell2);
+        public static bool operator !=(DataGridCellInfo cell1, DataGridCellInfo cell2);
+    }
+    public class DataGridCellsPanel : VirtualizingPanel {
+        public DataGridCellsPanel();
+        protected override Size ArrangeOverride(Size arrangeSize);
+        protected internal override void BringIndexIntoView(int index);
+        protected override Size MeasureOverride(Size constraint);
+        protected override void OnClearChildren();
+        protected override void OnIsItemsHostChanged(bool oldIsItemsHost, bool newIsItemsHost);
+        protected override void OnItemsChanged(object sender, ItemsChangedEventArgs args);
+    }
+    public class DataGridCheckBoxColumn : DataGridBoundColumn {
+        public static readonly DependencyProperty IsThreeStateProperty;
+        public DataGridCheckBoxColumn();
+        public static Style DefaultEditingElementStyle { get; }
+        public static Style DefaultElementStyle { get; }
+        public bool IsThreeState { get; set; }
+        protected override FrameworkElement GenerateEditingElement(DataGridCell cell, object dataItem);
+        protected override FrameworkElement GenerateElement(DataGridCell cell, object dataItem);
+        protected override object PrepareCellForEdit(FrameworkElement editingElement, RoutedEventArgs editingEventArgs);
+        protected internal override void RefreshCellContent(FrameworkElement element, string propertyName);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct DataGridClipboardCellContent {
+        public DataGridClipboardCellContent(object item, DataGridColumn column, object content);
+        public DataGridColumn Column { get; }
+        public object Content { get; }
+        public object Item { get; }
+        public override bool Equals(object data);
+        public override int GetHashCode();
+        public static bool operator ==(DataGridClipboardCellContent clipboardCellContent1, DataGridClipboardCellContent clipboardCellContent2);
+        public static bool operator !=(DataGridClipboardCellContent clipboardCellContent1, DataGridClipboardCellContent clipboardCellContent2);
+    }
+    public enum DataGridClipboardCopyMode {
+        ExcludeHeader = 1,
+        IncludeHeader = 2,
+        None = 0,
+    }
+    public abstract class DataGridColumn : DependencyObject {
+        public static readonly DependencyProperty ActualWidthProperty;
+        public static readonly DependencyProperty CanUserReorderProperty;
+        public static readonly DependencyProperty CanUserResizeProperty;
+        public static readonly DependencyProperty CanUserSortProperty;
+        public static readonly DependencyProperty CellStyleProperty;
+        public static readonly DependencyProperty DisplayIndexProperty;
+        public static readonly DependencyProperty DragIndicatorStyleProperty;
+        public static readonly DependencyProperty HeaderProperty;
+        public static readonly DependencyProperty HeaderStringFormatProperty;
+        public static readonly DependencyProperty HeaderStyleProperty;
+        public static readonly DependencyProperty HeaderTemplateProperty;
+        public static readonly DependencyProperty HeaderTemplateSelectorProperty;
+        public static readonly DependencyProperty IsAutoGeneratedProperty;
+        public static readonly DependencyProperty IsFrozenProperty;
+        public static readonly DependencyProperty IsReadOnlyProperty;
+        public static readonly DependencyProperty MaxWidthProperty;
+        public static readonly DependencyProperty MinWidthProperty;
+        public static readonly DependencyProperty SortDirectionProperty;
+        public static readonly DependencyProperty SortMemberPathProperty;
+        public static readonly DependencyProperty VisibilityProperty;
+        public static readonly DependencyProperty WidthProperty;
+        protected DataGridColumn();
+        public double ActualWidth { get; private set; }
+        public bool CanUserReorder { get; set; }
+        public bool CanUserResize { get; set; }
+        public bool CanUserSort { get; set; }
+        public Style CellStyle { get; set; }
+        public virtual BindingBase ClipboardContentBinding { get; set; }
+        protected internal DataGrid DataGridOwner { get; internal set; }
+        public int DisplayIndex { get; set; }
+        public Style DragIndicatorStyle { get; set; }
+        public object Header { get; set; }
+        public string HeaderStringFormat { get; set; }
+        public Style HeaderStyle { get; set; }
+        public DataTemplate HeaderTemplate { get; set; }
+        public DataTemplateSelector HeaderTemplateSelector { get; set; }
+        public bool IsAutoGenerated { get; internal set; }
+        public bool IsFrozen { get; internal set; }
+        public bool IsReadOnly { get; set; }
+        public double MaxWidth { get; set; }
+        public double MinWidth { get; set; }
+        public Nullable<ListSortDirection> SortDirection { get; set; }
+        public string SortMemberPath { get; set; }
+        public Visibility Visibility { get; set; }
+        public DataGridLength Width { get; set; }
+        public event EventHandler<DataGridCellClipboardEventArgs> CopyingCellClipboardContent;
+        public event EventHandler<DataGridCellClipboardEventArgs> PastingCellClipboardContent;
+        protected virtual void CancelCellEdit(FrameworkElement editingElement, object uneditedValue);
+        protected virtual bool CommitCellEdit(FrameworkElement editingElement);
+        protected abstract FrameworkElement GenerateEditingElement(DataGridCell cell, object dataItem);
+        protected abstract FrameworkElement GenerateElement(DataGridCell cell, object dataItem);
+        public FrameworkElement GetCellContent(object dataItem);
+        public FrameworkElement GetCellContent(DataGridRow dataGridRow);
+        protected void NotifyPropertyChanged(string propertyName);
+        protected virtual bool OnCoerceIsReadOnly(bool baseValue);
+        public virtual object OnCopyingCellClipboardContent(object item);
+        public virtual void OnPastingCellClipboardContent(object item, object cellContent);
+        protected virtual object PrepareCellForEdit(FrameworkElement editingElement, RoutedEventArgs editingEventArgs);
+        protected internal virtual void RefreshCellContent(FrameworkElement element, string propertyName);
+    }
+    public class DataGridColumnEventArgs : EventArgs {
+        public DataGridColumnEventArgs(DataGridColumn column);
+        public DataGridColumn Column { get; }
+    }
+    public class DataGridColumnReorderingEventArgs : DataGridColumnEventArgs {
+        public DataGridColumnReorderingEventArgs(DataGridColumn dataGridColumn);
+        public bool Cancel { get; set; }
+        public Control DragIndicator { get; set; }
+        public Control DropLocationIndicator { get; set; }
+    }
+    public class DataGridComboBoxColumn : DataGridColumn {
+        public static readonly DependencyProperty DisplayMemberPathProperty;
+        public static readonly DependencyProperty EditingElementStyleProperty;
+        public static readonly DependencyProperty ElementStyleProperty;
+        public static readonly DependencyProperty ItemsSourceProperty;
+        public static readonly DependencyProperty SelectedValuePathProperty;
+        public DataGridComboBoxColumn();
+        public override BindingBase ClipboardContentBinding { get; set; }
+        public static Style DefaultEditingElementStyle { get; }
+        public static Style DefaultElementStyle { get; }
+        public string DisplayMemberPath { get; set; }
+        public Style EditingElementStyle { get; set; }
+        public Style ElementStyle { get; set; }
+        public IEnumerable ItemsSource { get; set; }
+        public virtual BindingBase SelectedItemBinding { get; set; }
+        public virtual BindingBase SelectedValueBinding { get; set; }
+        public string SelectedValuePath { get; set; }
+        public virtual BindingBase TextBinding { get; set; }
+        public static ComponentResourceKey TextBlockComboBoxStyleKey { get; }
+        protected override void CancelCellEdit(FrameworkElement editingElement, object uneditedValue);
+        protected override bool CommitCellEdit(FrameworkElement editingElement);
+        protected override FrameworkElement GenerateEditingElement(DataGridCell cell, object dataItem);
+        protected override FrameworkElement GenerateElement(DataGridCell cell, object dataItem);
+        protected override bool OnCoerceIsReadOnly(bool baseValue);
+        protected virtual void OnSelectedItemBindingChanged(BindingBase oldBinding, BindingBase newBinding);
+        protected virtual void OnSelectedValueBindingChanged(BindingBase oldBinding, BindingBase newBinding);
+        protected virtual void OnTextBindingChanged(BindingBase oldBinding, BindingBase newBinding);
+        protected override object PrepareCellForEdit(FrameworkElement editingElement, RoutedEventArgs editingEventArgs);
+        protected internal override void RefreshCellContent(FrameworkElement element, string propertyName);
+    }
+    public enum DataGridEditAction {
+        Cancel = 0,
+        Commit = 1,
+    }
+    public enum DataGridEditingUnit {
+        Cell = 0,
+        Row = 1,
+    }
+    public enum DataGridGridLinesVisibility {
+        All = 0,
+        Horizontal = 1,
+        None = 2,
+        Vertical = 3,
+    }
+    public enum DataGridHeadersVisibility {
+        All = 3,
+        Column = 1,
+        None = 0,
+        Row = 2,
+    }
+    public class DataGridHyperlinkColumn : DataGridBoundColumn {
+        public static readonly DependencyProperty TargetNameProperty;
+        public DataGridHyperlinkColumn();
+        public BindingBase ContentBinding { get; set; }
+        public static Style DefaultEditingElementStyle { get; }
+        public static Style DefaultElementStyle { get; }
+        public string TargetName { get; set; }
+        protected override void CancelCellEdit(FrameworkElement editingElement, object uneditedValue);
+        protected override bool CommitCellEdit(FrameworkElement editingElement);
+        protected override FrameworkElement GenerateEditingElement(DataGridCell cell, object dataItem);
+        protected override FrameworkElement GenerateElement(DataGridCell cell, object dataItem);
+        protected virtual void OnContentBindingChanged(BindingBase oldBinding, BindingBase newBinding);
+        protected override object PrepareCellForEdit(FrameworkElement editingElement, RoutedEventArgs editingEventArgs);
+        protected internal override void RefreshCellContent(FrameworkElement element, string propertyName);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct DataGridLength : IEquatable<DataGridLength> {
+        public DataGridLength(double pixels);
+        public DataGridLength(double value, DataGridLengthUnitType type);
+        public DataGridLength(double value, DataGridLengthUnitType type, double desiredValue, double displayValue);
+        public static DataGridLength Auto { get; }
+        public double DesiredValue { get; }
+        public double DisplayValue { get; }
+        public bool IsAbsolute { get; }
+        public bool IsAuto { get; }
+        public bool IsSizeToCells { get; }
+        public bool IsSizeToHeader { get; }
+        public bool IsStar { get; }
+        public static DataGridLength SizeToCells { get; }
+        public static DataGridLength SizeToHeader { get; }
+        public DataGridLengthUnitType UnitType { get; }
+        public double Value { get; }
+        public override bool Equals(object obj);
+        public bool Equals(DataGridLength other);
+        public override int GetHashCode();
+        public static bool operator ==(DataGridLength gl1, DataGridLength gl2);
+        public static implicit operator DataGridLength (double value);
+        public static bool operator !=(DataGridLength gl1, DataGridLength gl2);
+        public override string ToString();
+    }
+    public class DataGridLengthConverter : TypeConverter {
+        public DataGridLengthConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public enum DataGridLengthUnitType {
+        Auto = 0,
+        Pixel = 1,
+        SizeToCells = 2,
+        SizeToHeader = 3,
+        Star = 4,
+    }
+    public class DataGridPreparingCellForEditEventArgs : EventArgs {
+        public DataGridPreparingCellForEditEventArgs(DataGridColumn column, DataGridRow row, RoutedEventArgs editingEventArgs, FrameworkElement editingElement);
+        public DataGridColumn Column { get; }
+        public FrameworkElement EditingElement { get; }
+        public RoutedEventArgs EditingEventArgs { get; }
+        public DataGridRow Row { get; }
+    }
+    public class DataGridRow : Control {
+        public static readonly DependencyProperty AlternationIndexProperty;
+        public static readonly DependencyProperty DetailsTemplateProperty;
+        public static readonly DependencyProperty DetailsTemplateSelectorProperty;
+        public static readonly DependencyProperty DetailsVisibilityProperty;
+        public static readonly DependencyProperty HeaderProperty;
+        public static readonly DependencyProperty HeaderStyleProperty;
+        public static readonly DependencyProperty HeaderTemplateProperty;
+        public static readonly DependencyProperty HeaderTemplateSelectorProperty;
+        public static readonly DependencyProperty IsEditingProperty;
+        public static readonly DependencyProperty IsNewItemProperty;
+        public static readonly DependencyProperty IsSelectedProperty;
+        public static readonly DependencyProperty ItemProperty;
+        public static readonly DependencyProperty ItemsPanelProperty;
+        public static readonly DependencyProperty ValidationErrorTemplateProperty;
+        public static readonly RoutedEvent SelectedEvent;
+        public static readonly RoutedEvent UnselectedEvent;
+        public DataGridRow();
+        public int AlternationIndex { get; }
+        public DataTemplate DetailsTemplate { get; set; }
+        public DataTemplateSelector DetailsTemplateSelector { get; set; }
+        public Visibility DetailsVisibility { get; set; }
+        public object Header { get; set; }
+        public Style HeaderStyle { get; set; }
+        public DataTemplate HeaderTemplate { get; set; }
+        public DataTemplateSelector HeaderTemplateSelector { get; set; }
+        public bool IsEditing { get; internal set; }
+        public bool IsNewItem { get; internal set; }
+        public bool IsSelected { get; set; }
+        public object Item { get; set; }
+        public ItemsPanelTemplate ItemsPanel { get; set; }
+        public ControlTemplate ValidationErrorTemplate { get; set; }
+        public event RoutedEventHandler Selected;
+        public event RoutedEventHandler Unselected;
+        protected override Size ArrangeOverride(Size arrangeBounds);
+        public int GetIndex();
+        public static DataGridRow GetRowContainingElement(FrameworkElement element);
+        protected internal virtual void OnColumnsChanged(ObservableCollection<DataGridColumn> columns, NotifyCollectionChangedEventArgs e);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected virtual void OnHeaderChanged(object oldHeader, object newHeader);
+        protected virtual void OnItemChanged(object oldItem, object newItem);
+        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e);
+        protected virtual void OnSelected(RoutedEventArgs e);
+        protected override void OnTemplateChanged(ControlTemplate oldTemplate, ControlTemplate newTemplate);
+        protected virtual void OnUnselected(RoutedEventArgs e);
+    }
+    public class DataGridRowClipboardEventArgs : EventArgs {
+        public DataGridRowClipboardEventArgs(object item, int startColumnDisplayIndex, int endColumnDisplayIndex, bool isColumnHeadersRow);
+        public List<DataGridClipboardCellContent> ClipboardRowContent { get; }
+        public int EndColumnDisplayIndex { get; }
+        public bool IsColumnHeadersRow { get; }
+        public object Item { get; }
+        public int StartColumnDisplayIndex { get; }
+        public string FormatClipboardCellValues(string format);
+    }
+    public class DataGridRowDetailsEventArgs : EventArgs {
+        public DataGridRowDetailsEventArgs(DataGridRow row, FrameworkElement detailsElement);
+        public FrameworkElement DetailsElement { get; private set; }
+        public DataGridRow Row { get; private set; }
+    }
+    public enum DataGridRowDetailsVisibilityMode {
+        Collapsed = 0,
+        Visible = 1,
+        VisibleWhenSelected = 2,
+    }
+    public class DataGridRowEditEndingEventArgs : EventArgs {
+        public DataGridRowEditEndingEventArgs(DataGridRow row, DataGridEditAction editAction);
+        public bool Cancel { get; set; }
+        public DataGridEditAction EditAction { get; }
+        public DataGridRow Row { get; }
+    }
+    public class DataGridRowEventArgs : EventArgs {
+        public DataGridRowEventArgs(DataGridRow row);
+        public DataGridRow Row { get; private set; }
+    }
+    public enum DataGridSelectionMode {
+        Extended = 1,
+        Single = 0,
+    }
+    public enum DataGridSelectionUnit {
+        Cell = 0,
+        CellOrRowHeader = 2,
+        FullRow = 1,
+    }
+    public class DataGridSortingEventArgs : DataGridColumnEventArgs {
+        public DataGridSortingEventArgs(DataGridColumn column);
+        public bool Handled { get; set; }
+    }
+    public delegate void DataGridSortingEventHandler(object sender, DataGridSortingEventArgs e);
+    public class DataGridTemplateColumn : DataGridColumn {
+        public static readonly DependencyProperty CellEditingTemplateProperty;
+        public static readonly DependencyProperty CellEditingTemplateSelectorProperty;
+        public static readonly DependencyProperty CellTemplateProperty;
+        public static readonly DependencyProperty CellTemplateSelectorProperty;
+        public DataGridTemplateColumn();
+        public DataTemplate CellEditingTemplate { get; set; }
+        public DataTemplateSelector CellEditingTemplateSelector { get; set; }
+        public DataTemplate CellTemplate { get; set; }
+        public DataTemplateSelector CellTemplateSelector { get; set; }
+        protected override FrameworkElement GenerateEditingElement(DataGridCell cell, object dataItem);
+        protected override FrameworkElement GenerateElement(DataGridCell cell, object dataItem);
+        protected internal override void RefreshCellContent(FrameworkElement element, string propertyName);
+    }
+    public class DataGridTextColumn : DataGridBoundColumn {
+        public static readonly DependencyProperty FontFamilyProperty;
+        public static readonly DependencyProperty FontSizeProperty;
+        public static readonly DependencyProperty FontStyleProperty;
+        public static readonly DependencyProperty FontWeightProperty;
+        public static readonly DependencyProperty ForegroundProperty;
+        public DataGridTextColumn();
+        public static Style DefaultEditingElementStyle { get; }
+        public static Style DefaultElementStyle { get; }
+        public FontFamily FontFamily { get; set; }
+        public double FontSize { get; set; }
+        public FontStyle FontStyle { get; set; }
+        public FontWeight FontWeight { get; set; }
+        public Brush Foreground { get; set; }
+        protected override void CancelCellEdit(FrameworkElement editingElement, object uneditedValue);
+        protected override bool CommitCellEdit(FrameworkElement editingElement);
+        protected override FrameworkElement GenerateEditingElement(DataGridCell cell, object dataItem);
+        protected override FrameworkElement GenerateElement(DataGridCell cell, object dataItem);
+        protected override object PrepareCellForEdit(FrameworkElement editingElement, RoutedEventArgs editingEventArgs);
+        protected internal override void RefreshCellContent(FrameworkElement element, string propertyName);
+    }
+    public class DataTemplateSelector {
+        public DataTemplateSelector();
+        public virtual DataTemplate SelectTemplate(object item, DependencyObject container);
+    }
+    public class DatePicker : Control {
+        public static readonly DependencyProperty CalendarStyleProperty;
+        public static readonly DependencyProperty DisplayDateEndProperty;
+        public static readonly DependencyProperty DisplayDateProperty;
+        public static readonly DependencyProperty DisplayDateStartProperty;
+        public static readonly DependencyProperty FirstDayOfWeekProperty;
+        public static readonly DependencyProperty IsDropDownOpenProperty;
+        public static readonly DependencyProperty IsTodayHighlightedProperty;
+        public static readonly DependencyProperty SelectedDateFormatProperty;
+        public static readonly DependencyProperty SelectedDateProperty;
+        public static readonly DependencyProperty TextProperty;
+        public static readonly RoutedEvent SelectedDateChangedEvent;
+        public DatePicker();
+        public CalendarBlackoutDatesCollection BlackoutDates { get; }
+        public Style CalendarStyle { get; set; }
+        public DateTime DisplayDate { get; set; }
+        public Nullable<DateTime> DisplayDateEnd { get; set; }
+        public Nullable<DateTime> DisplayDateStart { get; set; }
+        public DayOfWeek FirstDayOfWeek { get; set; }
+        protected internal override bool HasEffectiveKeyboardFocus { get; }
+        public bool IsDropDownOpen { get; set; }
+        public bool IsTodayHighlighted { get; set; }
+        public Nullable<DateTime> SelectedDate { get; set; }
+        public DatePickerFormat SelectedDateFormat { get; set; }
+        public string Text { get; set; }
+        public event RoutedEventHandler CalendarClosed;
+        public event RoutedEventHandler CalendarOpened;
+        public event EventHandler<DatePickerDateValidationErrorEventArgs> DateValidationError;
+        public event EventHandler<SelectionChangedEventArgs> SelectedDateChanged;
+        public override void OnApplyTemplate();
+        protected virtual void OnCalendarClosed(RoutedEventArgs e);
+        protected virtual void OnCalendarOpened(RoutedEventArgs e);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected virtual void OnDateValidationError(DatePickerDateValidationErrorEventArgs e);
+        protected virtual void OnSelectedDateChanged(SelectionChangedEventArgs e);
+        public override string ToString();
+    }
+    public class DatePickerDateValidationErrorEventArgs : EventArgs {
+        public DatePickerDateValidationErrorEventArgs(Exception exception, string text);
+        public Exception Exception { get; private set; }
+        public string Text { get; private set; }
+        public bool ThrowException { get; set; }
+    }
+    public enum DatePickerFormat {
+        Long = 0,
+        Short = 1,
+    }
+    public class Decorator : FrameworkElement, IAddChild {
+        public Decorator();
+        public virtual UIElement Child { get; set; }
+        protected internal override IEnumerator LogicalChildren { get; }
+        protected override int VisualChildrenCount { get; }
+        protected override Size ArrangeOverride(Size arrangeSize);
+        protected override Visual GetVisualChild(int index);
+        protected override Size MeasureOverride(Size constraint);
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public abstract class DefinitionBase : FrameworkContentElement {
+        public static readonly DependencyProperty SharedSizeGroupProperty;
+        public string SharedSizeGroup { get; set; }
+    }
+    public enum Dock {
+        Bottom = 3,
+        Left = 0,
+        Right = 2,
+        Top = 1,
+    }
+    public class DockPanel : Panel {
+        public static readonly DependencyProperty DockProperty;
+        public static readonly DependencyProperty LastChildFillProperty;
+        public DockPanel();
+        public bool LastChildFill { get; set; }
+        protected override Size ArrangeOverride(Size arrangeSize);
+        public static Dock GetDock(UIElement element);
+        protected override Size MeasureOverride(Size constraint);
+        public static void SetDock(UIElement element, Dock dock);
+    }
+    public class DocumentViewer : DocumentViewerBase {
+        public static readonly DependencyProperty CanDecreaseZoomProperty;
+        public static readonly DependencyProperty CanIncreaseZoomProperty;
+        public static readonly DependencyProperty CanMoveDownProperty;
+        public static readonly DependencyProperty CanMoveLeftProperty;
+        public static readonly DependencyProperty CanMoveRightProperty;
+        public static readonly DependencyProperty CanMoveUpProperty;
+        public static readonly DependencyProperty ExtentHeightProperty;
+        public static readonly DependencyProperty ExtentWidthProperty;
+        public static readonly DependencyProperty HorizontalOffsetProperty;
+        public static readonly DependencyProperty HorizontalPageSpacingProperty;
+        public static readonly DependencyProperty MaxPagesAcrossProperty;
+        public static readonly DependencyProperty ShowPageBordersProperty;
+        public static readonly DependencyProperty VerticalOffsetProperty;
+        public static readonly DependencyProperty VerticalPageSpacingProperty;
+        public static readonly DependencyProperty ViewportHeightProperty;
+        public static readonly DependencyProperty ViewportWidthProperty;
+        public static readonly DependencyProperty ZoomProperty;
+        public DocumentViewer();
+        public bool CanDecreaseZoom { get; }
+        public bool CanIncreaseZoom { get; }
+        public bool CanMoveDown { get; }
+        public bool CanMoveLeft { get; }
+        public bool CanMoveRight { get; }
+        public bool CanMoveUp { get; }
+        public double ExtentHeight { get; }
+        public double ExtentWidth { get; }
+        public static RoutedUICommand FitToHeightCommand { get; }
+        public static RoutedUICommand FitToMaxPagesAcrossCommand { get; }
+        public static RoutedUICommand FitToWidthCommand { get; }
+        public double HorizontalOffset { get; set; }
+        public double HorizontalPageSpacing { get; set; }
+        public int MaxPagesAcross { get; set; }
+        public bool ShowPageBorders { get; set; }
+        public double VerticalOffset { get; set; }
+        public double VerticalPageSpacing { get; set; }
+        public double ViewportHeight { get; }
+        public double ViewportWidth { get; }
+        public static RoutedUICommand ViewThumbnailsCommand { get; }
+        public double Zoom { get; set; }
+        public void DecreaseZoom();
+        public void Find();
+        public void FitToHeight();
+        public void FitToMaxPagesAcross();
+        public void FitToMaxPagesAcross(int pagesAcross);
+        public void FitToWidth();
+        protected override ReadOnlyCollection<DocumentPageView> GetPageViewsCollection(out bool changed);
+        public void IncreaseZoom();
+        public void MoveDown();
+        public void MoveLeft();
+        public void MoveRight();
+        public void MoveUp();
+        public override void OnApplyTemplate();
+        protected override void OnBringIntoView(DependencyObject element, Rect rect, int pageNumber);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected virtual void OnDecreaseZoomCommand();
+        protected override void OnDocumentChanged();
+        protected virtual void OnFindCommand();
+        protected override void OnFirstPageCommand();
+        protected virtual void OnFitToHeightCommand();
+        protected virtual void OnFitToMaxPagesAcrossCommand();
+        protected virtual void OnFitToMaxPagesAcrossCommand(int pagesAcross);
+        protected virtual void OnFitToWidthCommand();
+        protected override void OnGoToPageCommand(int pageNumber);
+        protected virtual void OnIncreaseZoomCommand();
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected override void OnLastPageCommand();
+        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e);
+        protected virtual void OnMoveDownCommand();
+        protected virtual void OnMoveLeftCommand();
+        protected virtual void OnMoveRightCommand();
+        protected virtual void OnMoveUpCommand();
+        protected override void OnNextPageCommand();
+        protected override void OnPreviewMouseWheel(MouseWheelEventArgs e);
+        protected override void OnPreviousPageCommand();
+        protected virtual void OnScrollPageDownCommand();
+        protected virtual void OnScrollPageLeftCommand();
+        protected virtual void OnScrollPageRightCommand();
+        protected virtual void OnScrollPageUpCommand();
+        protected virtual void OnViewThumbnailsCommand();
+        public void ScrollPageDown();
+        public void ScrollPageLeft();
+        public void ScrollPageRight();
+        public void ScrollPageUp();
+        public void ViewThumbnails();
+    }
+    public sealed class ExceptionValidationRule : ValidationRule {
+        public ExceptionValidationRule();
+        public override ValidationResult Validate(object value, CultureInfo cultureInfo);
+    }
+    public enum ExpandDirection {
+        Down = 0,
+        Left = 2,
+        Right = 3,
+        Up = 1,
+    }
+    public class Expander : HeaderedContentControl {
+        public static readonly DependencyProperty ExpandDirectionProperty;
+        public static readonly DependencyProperty IsExpandedProperty;
+        public static readonly RoutedEvent CollapsedEvent;
+        public static readonly RoutedEvent ExpandedEvent;
+        public Expander();
+        public ExpandDirection ExpandDirection { get; set; }
+        public bool IsExpanded { get; set; }
+        public event RoutedEventHandler Collapsed;
+        public event RoutedEventHandler Expanded;
+        protected virtual void OnCollapsed();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected virtual void OnExpanded();
+    }
+    public class FlowDocumentPageViewer : DocumentViewerBase, IJournalState {
+        public static readonly DependencyProperty CanDecreaseZoomProperty;
+        public static readonly DependencyProperty CanIncreaseZoomProperty;
+        public static readonly DependencyProperty IsInactiveSelectionHighlightEnabledProperty;
+        public static readonly DependencyProperty IsSelectionActiveProperty;
+        public static readonly DependencyProperty MaxZoomProperty;
+        public static readonly DependencyProperty MinZoomProperty;
+        public static readonly DependencyProperty SelectionBrushProperty;
+        public static readonly DependencyProperty SelectionOpacityProperty;
+        public static readonly DependencyProperty ZoomIncrementProperty;
+        public static readonly DependencyProperty ZoomProperty;
+        protected static readonly DependencyPropertyKey CanDecreaseZoomPropertyKey;
+        protected static readonly DependencyPropertyKey CanIncreaseZoomPropertyKey;
+        public FlowDocumentPageViewer();
+        public virtual bool CanDecreaseZoom { get; }
+        public virtual bool CanIncreaseZoom { get; }
+        public bool IsInactiveSelectionHighlightEnabled { get; set; }
+        public bool IsSelectionActive { get; }
+        public double MaxZoom { get; set; }
+        public double MinZoom { get; set; }
+        public TextSelection Selection { get; }
+        public Brush SelectionBrush { get; set; }
+        public double SelectionOpacity { get; set; }
+        public double Zoom { get; set; }
+        public double ZoomIncrement { get; set; }
+        public void DecreaseZoom();
+        public void Find();
+        public void IncreaseZoom();
+        public override void OnApplyTemplate();
+        protected override void OnCancelPrintCommand();
+        protected override void OnContextMenuOpening(ContextMenuEventArgs e);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected virtual void OnDecreaseZoomCommand();
+        protected override void OnDocumentChanged();
+        protected virtual void OnFindCommand();
+        protected override void OnFirstPageCommand();
+        protected override void OnGoToPageCommand(int pageNumber);
+        protected virtual void OnIncreaseZoomCommand();
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected override void OnLastPageCommand();
+        protected override void OnMouseWheel(MouseWheelEventArgs e);
+        protected override void OnNextPageCommand();
+        protected override void OnPageViewsChanged();
+        protected override void OnPreviousPageCommand();
+        protected override void OnPrintCommand();
+        protected virtual void OnPrintCompleted();
+    }
+    public class FlowDocumentReader : Control, IAddChild, IJournalState {
+        public static readonly DependencyProperty CanDecreaseZoomProperty;
+        public static readonly DependencyProperty CanGoToNextPageProperty;
+        public static readonly DependencyProperty CanGoToPreviousPageProperty;
+        public static readonly DependencyProperty CanIncreaseZoomProperty;
+        public static readonly DependencyProperty DocumentProperty;
+        public static readonly DependencyProperty IsFindEnabledProperty;
+        public static readonly DependencyProperty IsInactiveSelectionHighlightEnabledProperty;
+        public static readonly DependencyProperty IsPageViewEnabledProperty;
+        public static readonly DependencyProperty IsPrintEnabledProperty;
+        public static readonly DependencyProperty IsScrollViewEnabledProperty;
+        public static readonly DependencyProperty IsSelectionActiveProperty;
+        public static readonly DependencyProperty IsTwoPageViewEnabledProperty;
+        public static readonly DependencyProperty MaxZoomProperty;
+        public static readonly DependencyProperty MinZoomProperty;
+        public static readonly DependencyProperty PageCountProperty;
+        public static readonly DependencyProperty PageNumberProperty;
+        public static readonly DependencyProperty SelectionBrushProperty;
+        public static readonly DependencyProperty SelectionOpacityProperty;
+        public static readonly DependencyProperty ViewingModeProperty;
+        public static readonly DependencyProperty ZoomIncrementProperty;
+        public static readonly DependencyProperty ZoomProperty;
+        public static readonly RoutedUICommand SwitchViewingModeCommand;
+        public FlowDocumentReader();
+        public bool CanDecreaseZoom { get; }
+        public bool CanGoToNextPage { get; }
+        public bool CanGoToPreviousPage { get; }
+        public bool CanIncreaseZoom { get; }
+        public FlowDocument Document { get; set; }
+        public bool IsFindEnabled { get; set; }
+        public bool IsInactiveSelectionHighlightEnabled { get; set; }
+        public bool IsPageViewEnabled { get; set; }
+        public bool IsPrintEnabled { get; set; }
+        public bool IsScrollViewEnabled { get; set; }
+        public bool IsSelectionActive { get; }
+        public bool IsTwoPageViewEnabled { get; set; }
+        protected internal override IEnumerator LogicalChildren { get; }
+        public double MaxZoom { get; set; }
+        public double MinZoom { get; set; }
+        public int PageCount { get; }
+        public int PageNumber { get; }
+        public TextSelection Selection { get; }
+        public Brush SelectionBrush { get; set; }
+        public double SelectionOpacity { get; set; }
+        public FlowDocumentReaderViewingMode ViewingMode { get; set; }
+        public double Zoom { get; set; }
+        public double ZoomIncrement { get; set; }
+        public void CancelPrint();
+        public bool CanGoToPage(int pageNumber);
+        public void DecreaseZoom();
+        public void Find();
+        public void IncreaseZoom();
+        public override void OnApplyTemplate();
+        protected virtual void OnCancelPrintCommand();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected virtual void OnDecreaseZoomCommand();
+        protected virtual void OnFindCommand();
+        protected virtual void OnIncreaseZoomCommand();
+        protected override void OnInitialized(EventArgs e);
+        protected override void OnIsKeyboardFocusWithinChanged(DependencyPropertyChangedEventArgs e);
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected virtual void OnPrintCommand();
+        protected virtual void OnPrintCompleted();
+        protected virtual void OnSwitchViewingModeCommand(FlowDocumentReaderViewingMode viewingMode);
+        public void Print();
+        public void SwitchViewingMode(FlowDocumentReaderViewingMode viewingMode);
+        protected virtual void SwitchViewingModeCore(FlowDocumentReaderViewingMode viewingMode);
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public enum FlowDocumentReaderViewingMode {
+        Page = 0,
+        Scroll = 2,
+        TwoPage = 1,
+    }
+    public class FlowDocumentScrollViewer : Control, IAddChild, IJournalState, IServiceProvider {
+        public static readonly DependencyProperty CanDecreaseZoomProperty;
+        public static readonly DependencyProperty CanIncreaseZoomProperty;
+        public static readonly DependencyProperty DocumentProperty;
+        public static readonly DependencyProperty HorizontalScrollBarVisibilityProperty;
+        public static readonly DependencyProperty IsInactiveSelectionHighlightEnabledProperty;
+        public static readonly DependencyProperty IsSelectionActiveProperty;
+        public static readonly DependencyProperty IsSelectionEnabledProperty;
+        public static readonly DependencyProperty IsToolBarVisibleProperty;
+        public static readonly DependencyProperty MaxZoomProperty;
+        public static readonly DependencyProperty MinZoomProperty;
+        public static readonly DependencyProperty SelectionBrushProperty;
+        public static readonly DependencyProperty SelectionOpacityProperty;
+        public static readonly DependencyProperty VerticalScrollBarVisibilityProperty;
+        public static readonly DependencyProperty ZoomIncrementProperty;
+        public static readonly DependencyProperty ZoomProperty;
+        public FlowDocumentScrollViewer();
+        public bool CanDecreaseZoom { get; }
+        public bool CanIncreaseZoom { get; }
+        public FlowDocument Document { get; set; }
+        public ScrollBarVisibility HorizontalScrollBarVisibility { get; set; }
+        public bool IsInactiveSelectionHighlightEnabled { get; set; }
+        public bool IsSelectionActive { get; }
+        public bool IsSelectionEnabled { get; set; }
+        public bool IsToolBarVisible { get; set; }
+        protected internal override IEnumerator LogicalChildren { get; }
+        public double MaxZoom { get; set; }
+        public double MinZoom { get; set; }
+        public TextSelection Selection { get; }
+        public Brush SelectionBrush { get; set; }
+        public double SelectionOpacity { get; set; }
+        public ScrollBarVisibility VerticalScrollBarVisibility { get; set; }
+        public double Zoom { get; set; }
+        public double ZoomIncrement { get; set; }
+        public void CancelPrint();
+        public void DecreaseZoom();
+        public void Find();
+        public void IncreaseZoom();
+        public override void OnApplyTemplate();
+        protected virtual void OnCancelPrintCommand();
+        protected override void OnContextMenuOpening(ContextMenuEventArgs e);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected virtual void OnDecreaseZoomCommand();
+        protected virtual void OnFindCommand();
+        protected virtual void OnIncreaseZoomCommand();
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected override void OnMouseWheel(MouseWheelEventArgs e);
+        protected virtual void OnPrintCommand();
+        protected virtual void OnPrintCompleted();
+        public void Print();
+        object System.IServiceProvider.GetService(Type serviceType);
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public class Frame : ContentControl, IAddChild, IDownloader, IJournalNavigationScopeHost, IJournalState, INavigator, INavigatorBase, INavigatorImpl, IUriContext {
+        public static readonly DependencyProperty BackStackProperty;
+        public static readonly DependencyProperty CanGoBackProperty;
+        public static readonly DependencyProperty CanGoForwardProperty;
+        public static readonly DependencyProperty ForwardStackProperty;
+        public static readonly DependencyProperty JournalOwnershipProperty;
+        public static readonly DependencyProperty NavigationUIVisibilityProperty;
+        public static readonly DependencyProperty SandboxExternalContentProperty;
+        public static readonly DependencyProperty SourceProperty;
+        public Frame();
+        public IEnumerable BackStack { get; }
+        protected virtual Uri BaseUri { get; set; }
+        public bool CanGoBack { get; }
+        public bool CanGoForward { get; }
+        public Uri CurrentSource { get; }
+        public IEnumerable ForwardStack { get; }
+        public JournalOwnership JournalOwnership { get; set; }
+        public NavigationService NavigationService { get; }
+        public NavigationUIVisibility NavigationUIVisibility { get; set; }
+        public bool SandboxExternalContent { get; set; }
+        public Uri Source { get; set; }
+        Uri System.Windows.Markup.IUriContext.BaseUri { get; set; }
+        public event EventHandler ContentRendered;
+        public event FragmentNavigationEventHandler FragmentNavigation;
+        public event LoadCompletedEventHandler LoadCompleted;
+        public event NavigatedEventHandler Navigated;
+        public event NavigatingCancelEventHandler Navigating;
+        public event NavigationFailedEventHandler NavigationFailed;
+        public event NavigationProgressEventHandler NavigationProgress;
+        public event NavigationStoppedEventHandler NavigationStopped;
+        public void AddBackEntry(CustomContentState state);
+        protected override void AddChild(object value);
+        protected override void AddText(string text);
+        public void GoBack();
+        public void GoForward();
+        public bool Navigate(object content);
+        public bool Navigate(object content, object extraData);
+        public bool Navigate(Uri source);
+        public bool Navigate(Uri source, object extraData);
+        public override void OnApplyTemplate();
+        protected virtual void OnContentRendered(EventArgs args);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        public void Refresh();
+        public JournalEntry RemoveBackEntry();
+        public override bool ShouldSerializeContent();
+        public void StopLoading();
+    }
+    public class Grid : Panel, IAddChild {
+        public static readonly DependencyProperty ColumnProperty;
+        public static readonly DependencyProperty ColumnSpanProperty;
+        public static readonly DependencyProperty IsSharedSizeScopeProperty;
+        public static readonly DependencyProperty RowProperty;
+        public static readonly DependencyProperty RowSpanProperty;
+        public static readonly DependencyProperty ShowGridLinesProperty;
+        public Grid();
+        public ColumnDefinitionCollection ColumnDefinitions { get; }
+        protected internal override IEnumerator LogicalChildren { get; }
+        public RowDefinitionCollection RowDefinitions { get; }
+        public bool ShowGridLines { get; set; }
+        protected override int VisualChildrenCount { get; }
+        protected override Size ArrangeOverride(Size arrangeSize);
+        public static int GetColumn(UIElement element);
+        public static int GetColumnSpan(UIElement element);
+        public static bool GetIsSharedSizeScope(UIElement element);
+        public static int GetRow(UIElement element);
+        public static int GetRowSpan(UIElement element);
+        protected override Visual GetVisualChild(int index);
+        protected override Size MeasureOverride(Size constraint);
+        protected internal override void OnVisualChildrenChanged(DependencyObject visualAdded, DependencyObject visualRemoved);
+        public static void SetColumn(UIElement element, int value);
+        public static void SetColumnSpan(UIElement element, int value);
+        public static void SetIsSharedSizeScope(UIElement element, bool value);
+        public static void SetRow(UIElement element, int value);
+        public static void SetRowSpan(UIElement element, int value);
+        public bool ShouldSerializeColumnDefinitions();
+        public bool ShouldSerializeRowDefinitions();
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public enum GridResizeBehavior {
+        BasedOnAlignment = 0,
+        CurrentAndNext = 1,
+        PreviousAndCurrent = 2,
+        PreviousAndNext = 3,
+    }
+    public enum GridResizeDirection {
+        Auto = 0,
+        Columns = 1,
+        Rows = 2,
+    }
+    public class GridSplitter : Thumb {
+        public static readonly DependencyProperty DragIncrementProperty;
+        public static readonly DependencyProperty KeyboardIncrementProperty;
+        public static readonly DependencyProperty PreviewStyleProperty;
+        public static readonly DependencyProperty ResizeBehaviorProperty;
+        public static readonly DependencyProperty ResizeDirectionProperty;
+        public static readonly DependencyProperty ShowsPreviewProperty;
+        public GridSplitter();
+        public double DragIncrement { get; set; }
+        public double KeyboardIncrement { get; set; }
+        public Style PreviewStyle { get; set; }
+        public GridResizeBehavior ResizeBehavior { get; set; }
+        public GridResizeDirection ResizeDirection { get; set; }
+        public bool ShowsPreview { get; set; }
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected override void OnLostKeyboardFocus(KeyboardFocusChangedEventArgs e);
+        protected internal override void OnRenderSizeChanged(SizeChangedInfo sizeInfo);
+    }
+    public class GridView : ViewBase, IAddChild {
+        public static readonly DependencyProperty AllowsColumnReorderProperty;
+        public static readonly DependencyProperty ColumnCollectionProperty;
+        public static readonly DependencyProperty ColumnHeaderContainerStyleProperty;
+        public static readonly DependencyProperty ColumnHeaderContextMenuProperty;
+        public static readonly DependencyProperty ColumnHeaderStringFormatProperty;
+        public static readonly DependencyProperty ColumnHeaderTemplateProperty;
+        public static readonly DependencyProperty ColumnHeaderTemplateSelectorProperty;
+        public static readonly DependencyProperty ColumnHeaderToolTipProperty;
+        public GridView();
+        public bool AllowsColumnReorder { get; set; }
+        public Style ColumnHeaderContainerStyle { get; set; }
+        public ContextMenu ColumnHeaderContextMenu { get; set; }
+        public string ColumnHeaderStringFormat { get; set; }
+        public DataTemplate ColumnHeaderTemplate { get; set; }
+        public DataTemplateSelector ColumnHeaderTemplateSelector { get; set; }
+        public object ColumnHeaderToolTip { get; set; }
+        public GridViewColumnCollection Columns { get; }
+        protected internal override object DefaultStyleKey { get; }
+        public static ResourceKey GridViewItemContainerStyleKey { get; }
+        public static ResourceKey GridViewScrollViewerStyleKey { get; }
+        public static ResourceKey GridViewStyleKey { get; }
+        protected internal override object ItemContainerDefaultStyleKey { get; }
+        protected virtual void AddChild(object column);
+        protected virtual void AddText(string text);
+        protected internal override void ClearItem(ListViewItem item);
+        protected internal override IViewAutomationPeer GetAutomationPeer(ListView parent);
+        public static GridViewColumnCollection GetColumnCollection(DependencyObject element);
+        protected internal override void PrepareItem(ListViewItem item);
+        public static void SetColumnCollection(DependencyObject element, GridViewColumnCollection collection);
+        public static bool ShouldSerializeColumnCollection(DependencyObject obj);
+        void System.Windows.Markup.IAddChild.AddChild(object column);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+        public override string ToString();
+    }
+    public class GridViewColumn : DependencyObject, INotifyPropertyChanged {
+        public static readonly DependencyProperty CellTemplateProperty;
+        public static readonly DependencyProperty CellTemplateSelectorProperty;
+        public static readonly DependencyProperty HeaderContainerStyleProperty;
+        public static readonly DependencyProperty HeaderProperty;
+        public static readonly DependencyProperty HeaderStringFormatProperty;
+        public static readonly DependencyProperty HeaderTemplateProperty;
+        public static readonly DependencyProperty HeaderTemplateSelectorProperty;
+        public static readonly DependencyProperty WidthProperty;
+        public GridViewColumn();
+        public double ActualWidth { get; private set; }
+        public DataTemplate CellTemplate { get; set; }
+        public DataTemplateSelector CellTemplateSelector { get; set; }
+        public BindingBase DisplayMemberBinding { get; set; }
+        public object Header { get; set; }
+        public Style HeaderContainerStyle { get; set; }
+        public string HeaderStringFormat { get; set; }
+        public DataTemplate HeaderTemplate { get; set; }
+        public DataTemplateSelector HeaderTemplateSelector { get; set; }
+        public double Width { get; set; }
+        event PropertyChangedEventHandler System.ComponentModel.INotifyPropertyChanged.PropertyChanged;
+        protected virtual void OnHeaderStringFormatChanged(string oldHeaderStringFormat, string newHeaderStringFormat);
+        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e);
+        public override string ToString();
+    }
+    public class GridViewColumnCollection : ObservableCollection<GridViewColumn> {
+        public GridViewColumnCollection();
+        protected override void ClearItems();
+        protected override void InsertItem(int index, GridViewColumn column);
+        protected override void MoveItem(int oldIndex, int newIndex);
+        protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e);
+        protected override void RemoveItem(int index);
+        protected override void SetItem(int index, GridViewColumn column);
+    }
+    public class GridViewColumnHeader : ButtonBase {
+        public static readonly DependencyProperty ColumnProperty;
+        public static readonly DependencyProperty RoleProperty;
+        public GridViewColumnHeader();
+        public GridViewColumn Column { get; }
+        public GridViewColumnHeaderRole Role { get; }
+        protected override void OnAccessKey(AccessKeyEventArgs e);
+        public override void OnApplyTemplate();
+        protected override void OnClick();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnLostKeyboardFocus(KeyboardFocusChangedEventArgs e);
+        protected override void OnMouseEnter(MouseEventArgs e);
+        protected override void OnMouseLeave(MouseEventArgs e);
+        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e);
+        protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e);
+        protected override void OnMouseMove(MouseEventArgs e);
+        protected internal override void OnRenderSizeChanged(SizeChangedInfo sizeInfo);
+        protected internal override bool ShouldSerializeProperty(DependencyProperty dp);
+    }
+    public enum GridViewColumnHeaderRole {
+        Floating = 1,
+        Normal = 0,
+        Padding = 2,
+    }
+    public class GridViewHeaderRowPresenter : GridViewRowPresenterBase {
+        public static readonly DependencyProperty AllowsColumnReorderProperty;
+        public static readonly DependencyProperty ColumnHeaderContainerStyleProperty;
+        public static readonly DependencyProperty ColumnHeaderContextMenuProperty;
+        public static readonly DependencyProperty ColumnHeaderStringFormatProperty;
+        public static readonly DependencyProperty ColumnHeaderTemplateProperty;
+        public static readonly DependencyProperty ColumnHeaderTemplateSelectorProperty;
+        public static readonly DependencyProperty ColumnHeaderToolTipProperty;
+        public GridViewHeaderRowPresenter();
+        public bool AllowsColumnReorder { get; set; }
+        public Style ColumnHeaderContainerStyle { get; set; }
+        public ContextMenu ColumnHeaderContextMenu { get; set; }
+        public string ColumnHeaderStringFormat { get; set; }
+        public DataTemplate ColumnHeaderTemplate { get; set; }
+        public DataTemplateSelector ColumnHeaderTemplateSelector { get; set; }
+        public object ColumnHeaderToolTip { get; set; }
+        protected override Size ArrangeOverride(Size arrangeSize);
+        protected override Size MeasureOverride(Size constraint);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnLostMouseCapture(MouseEventArgs e);
+        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e);
+        protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e);
+        protected override void OnMouseMove(MouseEventArgs e);
+    }
+    public class GridViewRowPresenter : GridViewRowPresenterBase {
+        public static readonly DependencyProperty ContentProperty;
+        public GridViewRowPresenter();
+        public object Content { get; set; }
+        protected override Size ArrangeOverride(Size arrangeSize);
+        protected override Size MeasureOverride(Size constraint);
+        public override string ToString();
+    }
+    public class GroupBox : HeaderedContentControl {
+        public GroupBox();
+        protected override void OnAccessKey(AccessKeyEventArgs e);
+        protected override AutomationPeer OnCreateAutomationPeer();
+    }
+    public class GroupItem : ContentControl, IContainItemStorage, IHierarchicalVirtualizationAndScrollInfo {
+        public GroupItem();
+        HierarchicalVirtualizationConstraints System.Windows.Controls.Primitives.IHierarchicalVirtualizationAndScrollInfo.Constraints { get; set; }
+        HierarchicalVirtualizationHeaderDesiredSizes System.Windows.Controls.Primitives.IHierarchicalVirtualizationAndScrollInfo.HeaderDesiredSizes { get; }
+        bool System.Windows.Controls.Primitives.IHierarchicalVirtualizationAndScrollInfo.InBackgroundLayout { get; set; }
+        HierarchicalVirtualizationItemDesiredSizes System.Windows.Controls.Primitives.IHierarchicalVirtualizationAndScrollInfo.ItemDesiredSizes { get; set; }
+        Panel System.Windows.Controls.Primitives.IHierarchicalVirtualizationAndScrollInfo.ItemsHost { get; }
+        bool System.Windows.Controls.Primitives.IHierarchicalVirtualizationAndScrollInfo.MustDisableVirtualization { get; set; }
+        protected override Size ArrangeOverride(Size arrangeSize);
+        public override void OnApplyTemplate();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        void System.Windows.Controls.Primitives.IContainItemStorage.Clear();
+        void System.Windows.Controls.Primitives.IContainItemStorage.ClearItemValue(object item, DependencyProperty dp);
+        void System.Windows.Controls.Primitives.IContainItemStorage.ClearValue(DependencyProperty dp);
+        object System.Windows.Controls.Primitives.IContainItemStorage.ReadItemValue(object item, DependencyProperty dp);
+        void System.Windows.Controls.Primitives.IContainItemStorage.StoreItemValue(object item, DependencyProperty dp, object value);
+    }
+    public class GroupStyle : INotifyPropertyChanged {
+        public static readonly ItemsPanelTemplate DefaultGroupPanel;
+        public GroupStyle();
+        public int AlternationCount { get; set; }
+        public Style ContainerStyle { get; set; }
+        public StyleSelector ContainerStyleSelector { get; set; }
+        public static GroupStyle Default { get; }
+        public string HeaderStringFormat { get; set; }
+        public DataTemplate HeaderTemplate { get; set; }
+        public DataTemplateSelector HeaderTemplateSelector { get; set; }
+        public bool HidesIfEmpty { get; set; }
+        public ItemsPanelTemplate Panel { get; set; }
+        protected virtual event PropertyChangedEventHandler PropertyChanged;
+        event PropertyChangedEventHandler System.ComponentModel.INotifyPropertyChanged.PropertyChanged;
+        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e);
+    }
+    public delegate GroupStyle GroupStyleSelector(CollectionViewGroup group, int level);
+    public class HeaderedContentControl : ContentControl {
+        public static readonly DependencyProperty HasHeaderProperty;
+        public static readonly DependencyProperty HeaderProperty;
+        public static readonly DependencyProperty HeaderStringFormatProperty;
+        public static readonly DependencyProperty HeaderTemplateProperty;
+        public static readonly DependencyProperty HeaderTemplateSelectorProperty;
+        public HeaderedContentControl();
+        public bool HasHeader { get; }
+        public object Header { get; set; }
+        public string HeaderStringFormat { get; set; }
+        public DataTemplate HeaderTemplate { get; set; }
+        public DataTemplateSelector HeaderTemplateSelector { get; set; }
+        protected internal override IEnumerator LogicalChildren { get; }
+        protected virtual void OnHeaderChanged(object oldHeader, object newHeader);
+        protected virtual void OnHeaderStringFormatChanged(string oldHeaderStringFormat, string newHeaderStringFormat);
+        protected virtual void OnHeaderTemplateChanged(DataTemplate oldHeaderTemplate, DataTemplate newHeaderTemplate);
+        protected virtual void OnHeaderTemplateSelectorChanged(DataTemplateSelector oldHeaderTemplateSelector, DataTemplateSelector newHeaderTemplateSelector);
+        public override string ToString();
+    }
+    public class HeaderedItemsControl : ItemsControl {
+        public static readonly DependencyProperty HasHeaderProperty;
+        public static readonly DependencyProperty HeaderProperty;
+        public static readonly DependencyProperty HeaderStringFormatProperty;
+        public static readonly DependencyProperty HeaderTemplateProperty;
+        public static readonly DependencyProperty HeaderTemplateSelectorProperty;
+        public HeaderedItemsControl();
+        public bool HasHeader { get; }
+        public object Header { get; set; }
+        public string HeaderStringFormat { get; set; }
+        public DataTemplate HeaderTemplate { get; set; }
+        public DataTemplateSelector HeaderTemplateSelector { get; set; }
+        protected internal override IEnumerator LogicalChildren { get; }
+        protected virtual void OnHeaderChanged(object oldHeader, object newHeader);
+        protected virtual void OnHeaderStringFormatChanged(string oldHeaderStringFormat, string newHeaderStringFormat);
+        protected virtual void OnHeaderTemplateChanged(DataTemplate oldHeaderTemplate, DataTemplate newHeaderTemplate);
+        protected virtual void OnHeaderTemplateSelectorChanged(DataTemplateSelector oldHeaderTemplateSelector, DataTemplateSelector newHeaderTemplateSelector);
+        public override string ToString();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct HierarchicalVirtualizationConstraints {
+        public HierarchicalVirtualizationConstraints(VirtualizationCacheLength cacheLength, VirtualizationCacheLengthUnit cacheLengthUnit, Rect viewport);
+        public VirtualizationCacheLength CacheLength { get; }
+        public VirtualizationCacheLengthUnit CacheLengthUnit { get; }
+        public Rect Viewport { get; }
+        public override bool Equals(object oCompare);
+        public bool Equals(HierarchicalVirtualizationConstraints comparisonConstraints);
+        public override int GetHashCode();
+        public static bool operator ==(HierarchicalVirtualizationConstraints constraints1, HierarchicalVirtualizationConstraints constraints2);
+        public static bool operator !=(HierarchicalVirtualizationConstraints constraints1, HierarchicalVirtualizationConstraints constraints2);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct HierarchicalVirtualizationHeaderDesiredSizes {
+        public HierarchicalVirtualizationHeaderDesiredSizes(Size logicalSize, Size pixelSize);
+        public Size LogicalSize { get; }
+        public Size PixelSize { get; }
+        public override bool Equals(object oCompare);
+        public bool Equals(HierarchicalVirtualizationHeaderDesiredSizes comparisonHeaderSizes);
+        public override int GetHashCode();
+        public static bool operator ==(HierarchicalVirtualizationHeaderDesiredSizes headerDesiredSizes1, HierarchicalVirtualizationHeaderDesiredSizes headerDesiredSizes2);
+        public static bool operator !=(HierarchicalVirtualizationHeaderDesiredSizes headerDesiredSizes1, HierarchicalVirtualizationHeaderDesiredSizes headerDesiredSizes2);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct HierarchicalVirtualizationItemDesiredSizes {
+        public HierarchicalVirtualizationItemDesiredSizes(Size logicalSize, Size logicalSizeInViewport, Size logicalSizeBeforeViewport, Size logicalSizeAfterViewport, Size pixelSize, Size pixelSizeInViewport, Size pixelSizeBeforeViewport, Size pixelSizeAfterViewport);
+        public Size LogicalSize { get; }
+        public Size LogicalSizeAfterViewport { get; }
+        public Size LogicalSizeBeforeViewport { get; }
+        public Size LogicalSizeInViewport { get; }
+        public Size PixelSize { get; }
+        public Size PixelSizeAfterViewport { get; }
+        public Size PixelSizeBeforeViewport { get; }
+        public Size PixelSizeInViewport { get; }
+        public override bool Equals(object oCompare);
+        public bool Equals(HierarchicalVirtualizationItemDesiredSizes comparisonItemSizes);
+        public override int GetHashCode();
+        public static bool operator ==(HierarchicalVirtualizationItemDesiredSizes itemDesiredSizes1, HierarchicalVirtualizationItemDesiredSizes itemDesiredSizes2);
+        public static bool operator !=(HierarchicalVirtualizationItemDesiredSizes itemDesiredSizes1, HierarchicalVirtualizationItemDesiredSizes itemDesiredSizes2);
+    }
+    public class Image : FrameworkElement, IProvidePropertyFallback, IUriContext {
+        public static readonly DependencyProperty SourceProperty;
+        public static readonly DependencyProperty StretchDirectionProperty;
+        public static readonly DependencyProperty StretchProperty;
+        public static readonly RoutedEvent ImageFailedEvent;
+        public Image();
+        protected virtual Uri BaseUri { get; set; }
+        public ImageSource Source { get; set; }
+        public Stretch Stretch { get; set; }
+        public StretchDirection StretchDirection { get; set; }
+        Uri System.Windows.Markup.IUriContext.BaseUri { get; set; }
+        public event EventHandler<ExceptionRoutedEventArgs> ImageFailed;
+        protected override Size ArrangeOverride(Size arrangeSize);
+        protected override Size MeasureOverride(Size constraint);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnRender(DrawingContext dc);
+    }
+    public class InitializingNewItemEventArgs : EventArgs {
+        public InitializingNewItemEventArgs(object newItem);
+        public object NewItem { get; }
+    }
+    public delegate void InitializingNewItemEventHandler(object sender, InitializingNewItemEventArgs e);
+    public class InkCanvas : FrameworkElement, IAddChild {
+        public static readonly DependencyProperty ActiveEditingModeProperty;
+        public static readonly DependencyProperty BackgroundProperty;
+        public static readonly DependencyProperty BottomProperty;
+        public static readonly DependencyProperty DefaultDrawingAttributesProperty;
+        public static readonly DependencyProperty EditingModeInvertedProperty;
+        public static readonly DependencyProperty EditingModeProperty;
+        public static readonly DependencyProperty LeftProperty;
+        public static readonly DependencyProperty RightProperty;
+        public static readonly DependencyProperty StrokesProperty;
+        public static readonly DependencyProperty TopProperty;
+        public static readonly RoutedEvent ActiveEditingModeChangedEvent;
+        public static readonly RoutedEvent EditingModeChangedEvent;
+        public static readonly RoutedEvent EditingModeInvertedChangedEvent;
+        public static readonly RoutedEvent GestureEvent;
+        public static readonly RoutedEvent StrokeCollectedEvent;
+        public static readonly RoutedEvent StrokeErasedEvent;
+        public InkCanvas();
+        public InkCanvasEditingMode ActiveEditingMode { get; }
+        public Brush Background { get; set; }
+        public UIElementCollection Children { get; }
+        public DrawingAttributes DefaultDrawingAttributes { get; set; }
+        public StylusPointDescription DefaultStylusPointDescription { get; set; }
+        protected DynamicRenderer DynamicRenderer { get; set; }
+        public InkCanvasEditingMode EditingMode { get; set; }
+        public InkCanvasEditingMode EditingModeInverted { get; set; }
+        public StylusShape EraserShape { get; set; }
+        protected InkPresenter InkPresenter { get; }
+        public bool IsGestureRecognizerAvailable { get; }
+        protected internal override IEnumerator LogicalChildren { get; }
+        public bool MoveEnabled { get; set; }
+        public IEnumerable<InkCanvasClipboardFormat> PreferredPasteFormats { get; set; }
+        public bool ResizeEnabled { get; set; }
+        public StrokeCollection Strokes { get; set; }
+        public bool UseCustomCursor { get; set; }
+        protected override int VisualChildrenCount { get; }
+        public event RoutedEventHandler ActiveEditingModeChanged;
+        public event DrawingAttributesReplacedEventHandler DefaultDrawingAttributesReplaced;
+        public event RoutedEventHandler EditingModeChanged;
+        public event RoutedEventHandler EditingModeInvertedChanged;
+        public event InkCanvasGestureEventHandler Gesture;
+        public event EventHandler SelectionChanged;
+        public event InkCanvasSelectionChangingEventHandler SelectionChanging;
+        public event EventHandler SelectionMoved;
+        public event InkCanvasSelectionEditingEventHandler SelectionMoving;
+        public event EventHandler SelectionResized;
+        public event InkCanvasSelectionEditingEventHandler SelectionResizing;
+        public event InkCanvasStrokeCollectedEventHandler StrokeCollected;
+        public event RoutedEventHandler StrokeErased;
+        public event InkCanvasStrokeErasingEventHandler StrokeErasing;
+        public event InkCanvasStrokesReplacedEventHandler StrokesReplaced;
+        protected override Size ArrangeOverride(Size arrangeSize);
+        public bool CanPaste();
+        public void CopySelection();
+        public void CutSelection();
+        public static double GetBottom(UIElement element);
+        public ReadOnlyCollection<ApplicationGesture> GetEnabledGestures();
+        public static double GetLeft(UIElement element);
+        public static double GetRight(UIElement element);
+        public ReadOnlyCollection<UIElement> GetSelectedElements();
+        public StrokeCollection GetSelectedStrokes();
+        public Rect GetSelectionBounds();
+        public static double GetTop(UIElement element);
+        protected override Visual GetVisualChild(int index);
+        protected override HitTestResult HitTestCore(PointHitTestParameters hitTestParams);
+        public InkCanvasSelectionHitResult HitTestSelection(Point point);
+        protected override Size MeasureOverride(Size availableSize);
+        protected virtual void OnActiveEditingModeChanged(RoutedEventArgs e);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected virtual void OnDefaultDrawingAttributesReplaced(DrawingAttributesReplacedEventArgs e);
+        protected virtual void OnEditingModeChanged(RoutedEventArgs e);
+        protected virtual void OnEditingModeInvertedChanged(RoutedEventArgs e);
+        protected virtual void OnGesture(InkCanvasGestureEventArgs e);
+        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e);
+        protected virtual void OnSelectionChanged(EventArgs e);
+        protected virtual void OnSelectionChanging(InkCanvasSelectionChangingEventArgs e);
+        protected virtual void OnSelectionMoved(EventArgs e);
+        protected virtual void OnSelectionMoving(InkCanvasSelectionEditingEventArgs e);
+        protected virtual void OnSelectionResized(EventArgs e);
+        protected virtual void OnSelectionResizing(InkCanvasSelectionEditingEventArgs e);
+        protected virtual void OnStrokeCollected(InkCanvasStrokeCollectedEventArgs e);
+        protected virtual void OnStrokeErased(RoutedEventArgs e);
+        protected virtual void OnStrokeErasing(InkCanvasStrokeErasingEventArgs e);
+        protected virtual void OnStrokesReplaced(InkCanvasStrokesReplacedEventArgs e);
+        public void Paste();
+        public void Paste(Point point);
+        public void Select(IEnumerable<UIElement> selectedElements);
+        public void Select(StrokeCollection selectedStrokes);
+        public void Select(StrokeCollection selectedStrokes, IEnumerable<UIElement> selectedElements);
+        public static void SetBottom(UIElement element, double length);
+        public void SetEnabledGestures(IEnumerable<ApplicationGesture> applicationGestures);
+        public static void SetLeft(UIElement element, double length);
+        public static void SetRight(UIElement element, double length);
+        public static void SetTop(UIElement element, double length);
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string textData);
+    }
+    public enum InkCanvasClipboardFormat {
+        InkSerializedFormat = 0,
+        Text = 1,
+        Xaml = 2,
+    }
+    public enum InkCanvasEditingMode {
+        EraseByPoint = 5,
+        EraseByStroke = 6,
+        GestureOnly = 2,
+        Ink = 1,
+        InkAndGesture = 3,
+        None = 0,
+        Select = 4,
+    }
+    public class InkCanvasGestureEventArgs : RoutedEventArgs {
+        public InkCanvasGestureEventArgs(StrokeCollection strokes, IEnumerable<GestureRecognitionResult> gestureRecognitionResults);
+        public bool Cancel { get; set; }
+        public StrokeCollection Strokes { get; }
+        public ReadOnlyCollection<GestureRecognitionResult> GetGestureRecognitionResults();
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void InkCanvasGestureEventHandler(object sender, InkCanvasGestureEventArgs e);
+    public class InkCanvasSelectionChangingEventArgs : CancelEventArgs {
+        public ReadOnlyCollection<UIElement> GetSelectedElements();
+        public StrokeCollection GetSelectedStrokes();
+        public void SetSelectedElements(IEnumerable<UIElement> selectedElements);
+        public void SetSelectedStrokes(StrokeCollection selectedStrokes);
+    }
+    public delegate void InkCanvasSelectionChangingEventHandler(object sender, InkCanvasSelectionChangingEventArgs e);
+    public class InkCanvasSelectionEditingEventArgs : CancelEventArgs {
+        public Rect NewRectangle { get; set; }
+        public Rect OldRectangle { get; }
+    }
+    public delegate void InkCanvasSelectionEditingEventHandler(object sender, InkCanvasSelectionEditingEventArgs e);
+    public enum InkCanvasSelectionHitResult {
+        Bottom = 6,
+        BottomLeft = 7,
+        BottomRight = 5,
+        Left = 8,
+        None = 0,
+        Right = 4,
+        Selection = 9,
+        Top = 2,
+        TopLeft = 1,
+        TopRight = 3,
+    }
+    public class InkCanvasStrokeCollectedEventArgs : RoutedEventArgs {
+        public InkCanvasStrokeCollectedEventArgs(Stroke stroke);
+        public Stroke Stroke { get; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void InkCanvasStrokeCollectedEventHandler(object sender, InkCanvasStrokeCollectedEventArgs e);
+    public class InkCanvasStrokeErasingEventArgs : CancelEventArgs {
+        public Stroke Stroke { get; }
+    }
+    public delegate void InkCanvasStrokeErasingEventHandler(object sender, InkCanvasStrokeErasingEventArgs e);
+    public class InkCanvasStrokesReplacedEventArgs : EventArgs {
+        public StrokeCollection NewStrokes { get; }
+        public StrokeCollection PreviousStrokes { get; }
+    }
+    public delegate void InkCanvasStrokesReplacedEventHandler(object sender, InkCanvasStrokesReplacedEventArgs e);
+    public class InkPresenter : Decorator {
+        public static readonly DependencyProperty StrokesProperty;
+        public InkPresenter();
+        public StrokeCollection Strokes { get; set; }
+        protected override int VisualChildrenCount { get; }
+        protected override Size ArrangeOverride(Size arrangeSize);
+        public void AttachVisuals(Visual visual, DrawingAttributes drawingAttributes);
+        public void DetachVisuals(Visual visual);
+        protected override Geometry GetLayoutClip(Size layoutSlotSize);
+        protected override Visual GetVisualChild(int index);
+        protected override Size MeasureOverride(Size constraint);
+        protected override AutomationPeer OnCreateAutomationPeer();
+    }
+    public sealed class ItemCollection : CollectionView, ICollection, ICollectionViewLiveShaping, IEditableCollectionView, IEditableCollectionViewAddNewItem, IEnumerable, IItemProperties, IList, IWeakEventListener {
+        public bool CanChangeLiveFiltering { get; }
+        public bool CanChangeLiveGrouping { get; }
+        public bool CanChangeLiveSorting { get; }
+        public override bool CanFilter { get; }
+        public override bool CanGroup { get; }
+        public override bool CanSort { get; }
+        public override int Count { get; }
+        public override object CurrentItem { get; }
+        public override int CurrentPosition { get; }
+        public override Predicate<object> Filter { get; set; }
+        public override ObservableCollection<GroupDescription> GroupDescriptions { get; }
+        public override ReadOnlyObservableCollection<object> Groups { get; }
+        public override bool IsCurrentAfterLast { get; }
+        public override bool IsCurrentBeforeFirst { get; }
+        public override bool IsEmpty { get; }
+        public Nullable<bool> IsLiveFiltering { get; set; }
+        public Nullable<bool> IsLiveGrouping { get; set; }
+        public Nullable<bool> IsLiveSorting { get; set; }
+        public ObservableCollection<string> LiveFilteringProperties { get; }
+        public ObservableCollection<string> LiveGroupingProperties { get; }
+        public ObservableCollection<string> LiveSortingProperties { get; }
+        public override bool NeedsRefresh { get; }
+        public override SortDescriptionCollection SortDescriptions { get; }
+        public override IEnumerable SourceCollection { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        bool System.ComponentModel.IEditableCollectionView.CanAddNew { get; }
+        bool System.ComponentModel.IEditableCollectionView.CanCancelEdit { get; }
+        bool System.ComponentModel.IEditableCollectionView.CanRemove { get; }
+        object System.ComponentModel.IEditableCollectionView.CurrentAddItem { get; }
+        object System.ComponentModel.IEditableCollectionView.CurrentEditItem { get; }
+        bool System.ComponentModel.IEditableCollectionView.IsAddingNew { get; }
+        bool System.ComponentModel.IEditableCollectionView.IsEditingItem { get; }
+        NewItemPlaceholderPosition System.ComponentModel.IEditableCollectionView.NewItemPlaceholderPosition { get; set; }
+        bool System.ComponentModel.IEditableCollectionViewAddNewItem.CanAddNewItem { get; }
+        ReadOnlyCollection<ItemPropertyInfo> System.ComponentModel.IItemProperties.ItemProperties { get; }
+        public object this[int index] { get; set; }
+        public int Add(object newItem);
+        public void Clear();
+        public override bool Contains(object containItem);
+        public void CopyTo(Array array, int index);
+        public override IDisposable DeferRefresh();
+        protected override IEnumerator GetEnumerator();
+        public override object GetItemAt(int index);
+        public override int IndexOf(object item);
+        public void Insert(int insertIndex, object insertItem);
+        public override bool MoveCurrentTo(object item);
+        public override bool MoveCurrentToFirst();
+        public override bool MoveCurrentToLast();
+        public override bool MoveCurrentToNext();
+        public override bool MoveCurrentToPosition(int position);
+        public override bool MoveCurrentToPrevious();
+        public override bool PassesFilter(object item);
+        protected override void RefreshOverride();
+        public void Remove(object removeItem);
+        public void RemoveAt(int removeIndex);
+        object System.ComponentModel.IEditableCollectionView.AddNew();
+        void System.ComponentModel.IEditableCollectionView.CancelEdit();
+        void System.ComponentModel.IEditableCollectionView.CancelNew();
+        void System.ComponentModel.IEditableCollectionView.CommitEdit();
+        void System.ComponentModel.IEditableCollectionView.CommitNew();
+        void System.ComponentModel.IEditableCollectionView.EditItem(object item);
+        void System.ComponentModel.IEditableCollectionView.Remove(object item);
+        void System.ComponentModel.IEditableCollectionView.RemoveAt(int index);
+        object System.ComponentModel.IEditableCollectionViewAddNewItem.AddNewItem(object newItem);
+        bool System.Windows.IWeakEventListener.ReceiveWeakEvent(Type managerType, object sender, EventArgs e);
+    }
+    public sealed class ItemContainerGenerator : IItemContainerGenerator, IRecyclingItemContainerGenerator, IWeakEventListener {
+        public ReadOnlyCollection<object> Items { get; }
+        public GeneratorStatus Status { get; }
+        public event ItemsChangedEventHandler ItemsChanged;
+        public event EventHandler StatusChanged;
+        public DependencyObject ContainerFromIndex(int index);
+        public DependencyObject ContainerFromItem(object item);
+        public IDisposable GenerateBatches();
+        public int IndexFromContainer(DependencyObject container);
+        public int IndexFromContainer(DependencyObject container, bool returnLocalIndex);
+        public object ItemFromContainer(DependencyObject container);
+        DependencyObject System.Windows.Controls.Primitives.IItemContainerGenerator.GenerateNext();
+        DependencyObject System.Windows.Controls.Primitives.IItemContainerGenerator.GenerateNext(out bool isNewlyRealized);
+        GeneratorPosition System.Windows.Controls.Primitives.IItemContainerGenerator.GeneratorPositionFromIndex(int itemIndex);
+        ItemContainerGenerator System.Windows.Controls.Primitives.IItemContainerGenerator.GetItemContainerGeneratorForPanel(Panel panel);
+        int System.Windows.Controls.Primitives.IItemContainerGenerator.IndexFromGeneratorPosition(GeneratorPosition position);
+        void System.Windows.Controls.Primitives.IItemContainerGenerator.PrepareItemContainer(DependencyObject container);
+        void System.Windows.Controls.Primitives.IItemContainerGenerator.Remove(GeneratorPosition position, int count);
+        void System.Windows.Controls.Primitives.IItemContainerGenerator.RemoveAll();
+        IDisposable System.Windows.Controls.Primitives.IItemContainerGenerator.StartAt(GeneratorPosition position, GeneratorDirection direction);
+        IDisposable System.Windows.Controls.Primitives.IItemContainerGenerator.StartAt(GeneratorPosition position, GeneratorDirection direction, bool allowStartAtRealizedItem);
+        void System.Windows.Controls.Primitives.IRecyclingItemContainerGenerator.Recycle(GeneratorPosition position, int count);
+        bool System.Windows.IWeakEventListener.ReceiveWeakEvent(Type managerType, object sender, EventArgs e);
+    }
+    public class ItemContainerTemplate : DataTemplate {
+        public ItemContainerTemplate();
+        public object ItemContainerTemplateKey { get; }
+    }
+    public class ItemContainerTemplateKey : TemplateKey {
+        public ItemContainerTemplateKey();
+        public ItemContainerTemplateKey(object dataType);
+    }
+    public abstract class ItemContainerTemplateSelector {
+        protected ItemContainerTemplateSelector();
+        public virtual DataTemplate SelectTemplate(object item, ItemsControl parentItemsControl);
+    }
+    public class ItemsControl : Control, IAddChild, IContainItemStorage, IGeneratorHost {
+        public static readonly DependencyProperty AlternationCountProperty;
+        public static readonly DependencyProperty AlternationIndexProperty;
+        public static readonly DependencyProperty DisplayMemberPathProperty;
+        public static readonly DependencyProperty GroupStyleSelectorProperty;
+        public static readonly DependencyProperty HasItemsProperty;
+        public static readonly DependencyProperty IsGroupingProperty;
+        public static readonly DependencyProperty IsTextSearchCaseSensitiveProperty;
+        public static readonly DependencyProperty IsTextSearchEnabledProperty;
+        public static readonly DependencyProperty ItemBindingGroupProperty;
+        public static readonly DependencyProperty ItemContainerStyleProperty;
+        public static readonly DependencyProperty ItemContainerStyleSelectorProperty;
+        public static readonly DependencyProperty ItemsPanelProperty;
+        public static readonly DependencyProperty ItemsSourceProperty;
+        public static readonly DependencyProperty ItemStringFormatProperty;
+        public static readonly DependencyProperty ItemTemplateProperty;
+        public static readonly DependencyProperty ItemTemplateSelectorProperty;
+        public ItemsControl();
+        public int AlternationCount { get; set; }
+        public string DisplayMemberPath { get; set; }
+        public ObservableCollection<GroupStyle> GroupStyle { get; }
+        public GroupStyleSelector GroupStyleSelector { get; set; }
+        public bool HasItems { get; }
+        public bool IsGrouping { get; }
+        public bool IsTextSearchCaseSensitive { get; set; }
+        public bool IsTextSearchEnabled { get; set; }
+        public BindingGroup ItemBindingGroup { get; set; }
+        public ItemContainerGenerator ItemContainerGenerator { get; }
+        public Style ItemContainerStyle { get; set; }
+        public StyleSelector ItemContainerStyleSelector { get; set; }
+        public ItemCollection Items { get; }
+        public ItemsPanelTemplate ItemsPanel { get; set; }
+        public IEnumerable ItemsSource { get; set; }
+        public string ItemStringFormat { get; set; }
+        public DataTemplate ItemTemplate { get; set; }
+        public DataTemplateSelector ItemTemplateSelector { get; set; }
+        protected internal override IEnumerator LogicalChildren { get; }
+        protected virtual void AddChild(object value);
+        protected virtual void AddText(string text);
+        public override void BeginInit();
+        protected virtual void ClearContainerForItemOverride(DependencyObject element, object item);
+        public static DependencyObject ContainerFromElement(ItemsControl itemsControl, DependencyObject element);
+        public DependencyObject ContainerFromElement(DependencyObject element);
+        public override void EndInit();
+        public static int GetAlternationIndex(DependencyObject element);
+        protected virtual DependencyObject GetContainerForItemOverride();
+        public static ItemsControl GetItemsOwner(DependencyObject element);
+        public bool IsItemItsOwnContainer(object item);
+        protected virtual bool IsItemItsOwnContainerOverride(object item);
+        public static ItemsControl ItemsControlFromItemContainer(DependencyObject container);
+        protected virtual void OnAlternationCountChanged(int oldAlternationCount, int newAlternationCount);
+        protected virtual void OnDisplayMemberPathChanged(string oldDisplayMemberPath, string newDisplayMemberPath);
+        protected virtual void OnGroupStyleSelectorChanged(GroupStyleSelector oldGroupStyleSelector, GroupStyleSelector newGroupStyleSelector);
+        protected virtual void OnItemBindingGroupChanged(BindingGroup oldItemBindingGroup, BindingGroup newItemBindingGroup);
+        protected virtual void OnItemContainerStyleChanged(Style oldItemContainerStyle, Style newItemContainerStyle);
+        protected virtual void OnItemContainerStyleSelectorChanged(StyleSelector oldItemContainerStyleSelector, StyleSelector newItemContainerStyleSelector);
+        protected virtual void OnItemsChanged(NotifyCollectionChangedEventArgs e);
+        protected virtual void OnItemsPanelChanged(ItemsPanelTemplate oldItemsPanel, ItemsPanelTemplate newItemsPanel);
+        protected virtual void OnItemsSourceChanged(IEnumerable oldValue, IEnumerable newValue);
+        protected virtual void OnItemStringFormatChanged(string oldItemStringFormat, string newItemStringFormat);
+        protected virtual void OnItemTemplateChanged(DataTemplate oldItemTemplate, DataTemplate newItemTemplate);
+        protected virtual void OnItemTemplateSelectorChanged(DataTemplateSelector oldItemTemplateSelector, DataTemplateSelector newItemTemplateSelector);
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected override void OnTextInput(TextCompositionEventArgs e);
+        protected virtual void PrepareContainerForItemOverride(DependencyObject element, object item);
+        protected virtual bool ShouldApplyItemContainerStyle(DependencyObject container, object item);
+        public bool ShouldSerializeGroupStyle();
+        public bool ShouldSerializeItems();
+        void System.Windows.Controls.Primitives.IContainItemStorage.Clear();
+        void System.Windows.Controls.Primitives.IContainItemStorage.ClearItemValue(object item, DependencyProperty dp);
+        void System.Windows.Controls.Primitives.IContainItemStorage.ClearValue(DependencyProperty dp);
+        object System.Windows.Controls.Primitives.IContainItemStorage.ReadItemValue(object item, DependencyProperty dp);
+        void System.Windows.Controls.Primitives.IContainItemStorage.StoreItemValue(object item, DependencyProperty dp, object value);
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+        public override string ToString();
+    }
+    public class ItemsPanelTemplate : FrameworkTemplate {
+        public ItemsPanelTemplate();
+        public ItemsPanelTemplate(FrameworkElementFactory root);
+        protected override void ValidateTemplatedParent(FrameworkElement templatedParent);
+    }
+    public class ItemsPresenter : FrameworkElement {
+        public ItemsPresenter();
+        protected override Size ArrangeOverride(Size arrangeSize);
+        protected override Size MeasureOverride(Size constraint);
+        public override void OnApplyTemplate();
+        protected virtual void OnTemplateChanged(ItemsPanelTemplate oldTemplate, ItemsPanelTemplate newTemplate);
+    }
+    public class KeyTipAccessedEventArgs : RoutedEventArgs {
+        public KeyTipAccessedEventArgs();
+        public DependencyObject TargetKeyTipScope { get; set; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void KeyTipAccessedEventHandler(object sender, KeyTipAccessedEventArgs e);
+    public class KeyTipControl : Control {
+        public static readonly DependencyProperty TextProperty;
+        public KeyTipControl();
+        public string Text { get; set; }
+    }
+    public enum KeyTipHorizontalPlacement {
+        KeyTipCenterAtTargetCenter = 4,
+        KeyTipCenterAtTargetLeft = 3,
+        KeyTipCenterAtTargetRight = 5,
+        KeyTipLeftAtTargetCenter = 1,
+        KeyTipLeftAtTargetLeft = 0,
+        KeyTipLeftAtTargetRight = 2,
+        KeyTipRightAtTargetCenter = 7,
+        KeyTipRightAtTargetLeft = 6,
+        KeyTipRightAtTargetRight = 8,
+    }
+    public class KeyTipService {
+        public static readonly DependencyProperty IsKeyTipScopeProperty;
+        public static readonly DependencyProperty KeyTipProperty;
+        public static readonly DependencyProperty KeyTipStyleProperty;
+        public static readonly RoutedEvent ActivatingKeyTipEvent;
+        public static readonly RoutedEvent KeyTipAccessedEvent;
+        public static readonly RoutedEvent PreviewKeyTipAccessedEvent;
+        public static void AddActivatingKeyTipHandler(DependencyObject element, ActivatingKeyTipEventHandler handler);
+        public static void AddKeyTipAccessedHandler(DependencyObject element, KeyTipAccessedEventHandler handler);
+        public static void AddPreviewKeyTipAccessedHandler(DependencyObject element, KeyTipAccessedEventHandler handler);
+        public static void DismissKeyTips();
+        public static bool GetIsKeyTipScope(DependencyObject element);
+        public static string GetKeyTip(DependencyObject element);
+        public static Style GetKeyTipStyle(DependencyObject element);
+        public static void RemoveActivatingKeyTipHandler(DependencyObject element, ActivatingKeyTipEventHandler handler);
+        public static void RemoveKeyTipAccessedHandler(DependencyObject element, KeyTipAccessedEventHandler handler);
+        public static void RemovePreviewKeyTipAccessedHandler(DependencyObject element, KeyTipAccessedEventHandler handler);
+        public static void SetIsKeyTipScope(DependencyObject element, bool value);
+        public static void SetKeyTip(DependencyObject element, string value);
+        public static void SetKeyTipStyle(DependencyObject element, Style value);
+    }
+    public enum KeyTipVerticalPlacement {
+        KeyTipBottomAtTargetBottom = 8,
+        KeyTipBottomAtTargetCenter = 7,
+        KeyTipBottomAtTargetTop = 6,
+        KeyTipCenterAtTargetBottom = 5,
+        KeyTipCenterAtTargetCenter = 4,
+        KeyTipCenterAtTargetTop = 3,
+        KeyTipTopAtTargetBottom = 2,
+        KeyTipTopAtTargetCenter = 1,
+        KeyTipTopAtTargetTop = 0,
+    }
+    public class Label : ContentControl {
+        public static readonly DependencyProperty TargetProperty;
+        public Label();
+        public UIElement Target { get; set; }
+        protected override AutomationPeer OnCreateAutomationPeer();
+    }
+    public class ListBox : Selector {
+        public static readonly DependencyProperty SelectedItemsProperty;
+        public static readonly DependencyProperty SelectionModeProperty;
+        public ListBox();
+        protected object AnchorItem { get; set; }
+        protected internal override bool HandlesScrolling { get; }
+        public IList SelectedItems { get; }
+        public SelectionMode SelectionMode { get; set; }
+        protected override DependencyObject GetContainerForItemOverride();
+        protected override bool IsItemItsOwnContainerOverride(object item);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnIsMouseCapturedChanged(DependencyPropertyChangedEventArgs e);
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected override void OnMouseMove(MouseEventArgs e);
+        protected override void OnSelectionChanged(SelectionChangedEventArgs e);
+        protected override void PrepareContainerForItemOverride(DependencyObject element, object item);
+        public void ScrollIntoView(object item);
+        public void SelectAll();
+        protected bool SetSelectedItems(IEnumerable selectedItems);
+        public void UnselectAll();
+    }
+    public class ListBoxItem : ContentControl {
+        public static readonly DependencyProperty IsSelectedProperty;
+        public static readonly RoutedEvent SelectedEvent;
+        public static readonly RoutedEvent UnselectedEvent;
+        public ListBoxItem();
+        public bool IsSelected { get; set; }
+        public event RoutedEventHandler Selected;
+        public event RoutedEventHandler Unselected;
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnMouseEnter(MouseEventArgs e);
+        protected override void OnMouseLeave(MouseEventArgs e);
+        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e);
+        protected override void OnMouseRightButtonDown(MouseButtonEventArgs e);
+        protected virtual void OnSelected(RoutedEventArgs e);
+        protected virtual void OnUnselected(RoutedEventArgs e);
+        protected internal override void OnVisualParentChanged(DependencyObject oldParent);
+    }
+    public class ListView : ListBox {
+        public static readonly DependencyProperty ViewProperty;
+        public ListView();
+        public ViewBase View { get; set; }
+        protected override void ClearContainerForItemOverride(DependencyObject element, object item);
+        protected override DependencyObject GetContainerForItemOverride();
+        protected override bool IsItemItsOwnContainerOverride(object item);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnItemsChanged(NotifyCollectionChangedEventArgs e);
+        protected override void PrepareContainerForItemOverride(DependencyObject element, object item);
+    }
+    public class ListViewItem : ListBoxItem {
+        public ListViewItem();
+    }
+    public class MediaElement : FrameworkElement, IUriContext {
+        public static readonly DependencyProperty BalanceProperty;
+        public static readonly DependencyProperty IsMutedProperty;
+        public static readonly DependencyProperty LoadedBehaviorProperty;
+        public static readonly DependencyProperty ScrubbingEnabledProperty;
+        public static readonly DependencyProperty SourceProperty;
+        public static readonly DependencyProperty StretchDirectionProperty;
+        public static readonly DependencyProperty StretchProperty;
+        public static readonly DependencyProperty UnloadedBehaviorProperty;
+        public static readonly DependencyProperty VolumeProperty;
+        public static readonly RoutedEvent BufferingEndedEvent;
+        public static readonly RoutedEvent BufferingStartedEvent;
+        public static readonly RoutedEvent MediaEndedEvent;
+        public static readonly RoutedEvent MediaFailedEvent;
+        public static readonly RoutedEvent MediaOpenedEvent;
+        public static readonly RoutedEvent ScriptCommandEvent;
+        public MediaElement();
+        public double Balance { get; set; }
+        public double BufferingProgress { get; }
+        public bool CanPause { get; }
+        public MediaClock Clock { get; set; }
+        public double DownloadProgress { get; }
+        public bool HasAudio { get; }
+        public bool HasVideo { get; }
+        public bool IsBuffering { get; }
+        public bool IsMuted { get; set; }
+        public MediaState LoadedBehavior { get; set; }
+        public Duration NaturalDuration { get; }
+        public int NaturalVideoHeight { get; }
+        public int NaturalVideoWidth { get; }
+        public TimeSpan Position { get; set; }
+        public bool ScrubbingEnabled { get; set; }
+        public Uri Source { get; set; }
+        public double SpeedRatio { get; set; }
+        public Stretch Stretch { get; set; }
+        public StretchDirection StretchDirection { get; set; }
+        Uri System.Windows.Markup.IUriContext.BaseUri { get; set; }
+        public MediaState UnloadedBehavior { get; set; }
+        public double Volume { get; set; }
+        public event RoutedEventHandler BufferingEnded;
+        public event RoutedEventHandler BufferingStarted;
+        public event RoutedEventHandler MediaEnded;
+        public event EventHandler<ExceptionRoutedEventArgs> MediaFailed;
+        public event RoutedEventHandler MediaOpened;
+        public event EventHandler<MediaScriptCommandRoutedEventArgs> ScriptCommand;
+        protected override Size ArrangeOverride(Size finalSize);
+        public void Close();
+        protected override Size MeasureOverride(Size availableSize);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnRender(DrawingContext drawingContext);
+        public void Pause();
+        public void Play();
+        public void Stop();
+    }
+    public enum MediaState {
+        Close = 2,
+        Manual = 0,
+        Pause = 3,
+        Play = 1,
+        Stop = 4,
+    }
+    public class Menu : MenuBase {
+        public static readonly DependencyProperty IsMainMenuProperty;
+        public Menu();
+        public bool IsMainMenu { get; set; }
+        protected override void HandleMouseButton(MouseButtonEventArgs e);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnInitialized(EventArgs e);
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected override void OnTextInput(TextCompositionEventArgs e);
+        protected override void PrepareContainerForItemOverride(DependencyObject element, object item);
+    }
+    public class MenuItem : HeaderedItemsControl, ICommandSource {
+        public static readonly DependencyProperty CommandParameterProperty;
+        public static readonly DependencyProperty CommandProperty;
+        public static readonly DependencyProperty CommandTargetProperty;
+        public static readonly DependencyProperty IconProperty;
+        public static readonly DependencyProperty InputGestureTextProperty;
+        public static readonly DependencyProperty IsCheckableProperty;
+        public static readonly DependencyProperty IsCheckedProperty;
+        public static readonly DependencyProperty IsHighlightedProperty;
+        public static readonly DependencyProperty IsPressedProperty;
+        public static readonly DependencyProperty IsSubmenuOpenProperty;
+        public static readonly DependencyProperty IsSuspendingPopupAnimationProperty;
+        public static readonly DependencyProperty ItemContainerTemplateSelectorProperty;
+        public static readonly DependencyProperty RoleProperty;
+        public static readonly DependencyProperty StaysOpenOnClickProperty;
+        public static readonly DependencyProperty UsesItemContainerTemplateProperty;
+        public static readonly RoutedEvent CheckedEvent;
+        public static readonly RoutedEvent ClickEvent;
+        public static readonly RoutedEvent SubmenuClosedEvent;
+        public static readonly RoutedEvent SubmenuOpenedEvent;
+        public static readonly RoutedEvent UncheckedEvent;
+        public MenuItem();
+        public ICommand Command { get; set; }
+        public object CommandParameter { get; set; }
+        public IInputElement CommandTarget { get; set; }
+        protected internal override bool HandlesScrolling { get; }
+        public object Icon { get; set; }
+        public string InputGestureText { get; set; }
+        public bool IsCheckable { get; set; }
+        public bool IsChecked { get; set; }
+        protected override bool IsEnabledCore { get; }
+        public bool IsHighlighted { get; protected set; }
+        public bool IsPressed { get; protected set; }
+        public bool IsSubmenuOpen { get; set; }
+        public bool IsSuspendingPopupAnimation { get; internal set; }
+        public ItemContainerTemplateSelector ItemContainerTemplateSelector { get; set; }
+        public MenuItemRole Role { get; }
+        public static ResourceKey SeparatorStyleKey { get; }
+        public bool StaysOpenOnClick { get; set; }
+        public static ResourceKey SubmenuHeaderTemplateKey { get; }
+        public static ResourceKey SubmenuItemTemplateKey { get; }
+        public static ResourceKey TopLevelHeaderTemplateKey { get; }
+        public static ResourceKey TopLevelItemTemplateKey { get; }
+        public bool UsesItemContainerTemplate { get; set; }
+        public event RoutedEventHandler Checked;
+        public event RoutedEventHandler Click;
+        public event RoutedEventHandler SubmenuClosed;
+        public event RoutedEventHandler SubmenuOpened;
+        public event RoutedEventHandler Unchecked;
+        protected override DependencyObject GetContainerForItemOverride();
+        protected override bool IsItemItsOwnContainerOverride(object item);
+        protected override void OnAccessKey(AccessKeyEventArgs e);
+        public override void OnApplyTemplate();
+        protected virtual void OnChecked(RoutedEventArgs e);
+        protected virtual void OnClick();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnGotKeyboardFocus(KeyboardFocusChangedEventArgs e);
+        protected override void OnInitialized(EventArgs e);
+        protected override void OnIsKeyboardFocusWithinChanged(DependencyPropertyChangedEventArgs e);
+        protected override void OnItemsChanged(NotifyCollectionChangedEventArgs e);
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected override void OnMouseEnter(MouseEventArgs e);
+        protected override void OnMouseLeave(MouseEventArgs e);
+        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e);
+        protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e);
+        protected override void OnMouseMove(MouseEventArgs e);
+        protected override void OnMouseRightButtonDown(MouseButtonEventArgs e);
+        protected override void OnMouseRightButtonUp(MouseButtonEventArgs e);
+        protected virtual void OnSubmenuClosed(RoutedEventArgs e);
+        protected virtual void OnSubmenuOpened(RoutedEventArgs e);
+        protected virtual void OnUnchecked(RoutedEventArgs e);
+        protected internal override void OnVisualParentChanged(DependencyObject oldParent);
+        protected override void PrepareContainerForItemOverride(DependencyObject element, object item);
+        protected override bool ShouldApplyItemContainerStyle(DependencyObject container, object item);
+    }
+    public enum MenuItemRole {
+        SubmenuHeader = 3,
+        SubmenuItem = 2,
+        TopLevelHeader = 1,
+        TopLevelItem = 0,
+    }
+    public sealed class MenuScrollingVisibilityConverter : IMultiValueConverter {
+        public MenuScrollingVisibilityConverter();
+        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture);
+        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture);
+    }
+    public sealed class NotifyDataErrorValidationRule : ValidationRule {
+        public NotifyDataErrorValidationRule();
+        public override ValidationResult Validate(object value, CultureInfo cultureInfo);
+    }
+    public enum Orientation {
+        Horizontal = 0,
+        Vertical = 1,
+    }
+    public enum OverflowMode {
+        Always = 1,
+        AsNeeded = 0,
+        Never = 2,
+    }
+    public class Page : FrameworkElement, IAddChild, IWindowService {
+        public static readonly DependencyProperty BackgroundProperty;
+        public static readonly DependencyProperty ContentProperty;
+        public static readonly DependencyProperty FontFamilyProperty;
+        public static readonly DependencyProperty FontSizeProperty;
+        public static readonly DependencyProperty ForegroundProperty;
+        public static readonly DependencyProperty KeepAliveProperty;
+        public static readonly DependencyProperty TemplateProperty;
+        public static readonly DependencyProperty TitleProperty;
+        public Page();
+        public Brush Background { get; set; }
+        public object Content { get; set; }
+        public FontFamily FontFamily { get; set; }
+        public double FontSize { get; set; }
+        public Brush Foreground { get; set; }
+        public bool KeepAlive { get; set; }
+        protected internal override IEnumerator LogicalChildren { get; }
+        public NavigationService NavigationService { get; }
+        public bool ShowsNavigationUI { get; set; }
+        public ControlTemplate Template { get; set; }
+        public string Title { get; set; }
+        public double WindowHeight { get; set; }
+        public string WindowTitle { get; set; }
+        public double WindowWidth { get; set; }
+        protected override Size ArrangeOverride(Size arrangeBounds);
+        protected override Size MeasureOverride(Size constraint);
+        protected virtual void OnTemplateChanged(ControlTemplate oldTemplate, ControlTemplate newTemplate);
+        protected internal sealed override void OnVisualParentChanged(DependencyObject oldParent);
+        public bool ShouldSerializeShowsNavigationUI();
+        public bool ShouldSerializeTitle();
+        public bool ShouldSerializeWindowHeight();
+        public bool ShouldSerializeWindowTitle();
+        public bool ShouldSerializeWindowWidth();
+        void System.Windows.Markup.IAddChild.AddChild(object obj);
+        void System.Windows.Markup.IAddChild.AddText(string str);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct PageRange {
+        public PageRange(int page);
+        public PageRange(int pageFrom, int pageTo);
+        public int PageFrom { get; set; }
+        public int PageTo { get; set; }
+        public override bool Equals(object obj);
+        public bool Equals(PageRange pageRange);
+        public override int GetHashCode();
+        public static bool operator ==(PageRange pr1, PageRange pr2);
+        public static bool operator !=(PageRange pr1, PageRange pr2);
+        public override string ToString();
+    }
+    public enum PageRangeSelection {
+        AllPages = 0,
+        CurrentPage = 2,
+        SelectedPages = 3,
+        UserPages = 1,
+    }
+    public abstract class Panel : FrameworkElement, IAddChild {
+        public static readonly DependencyProperty BackgroundProperty;
+        public static readonly DependencyProperty IsItemsHostProperty;
+        public static readonly DependencyProperty ZIndexProperty;
+        protected Panel();
+        public Brush Background { get; set; }
+        public UIElementCollection Children { get; }
+        protected internal virtual bool HasLogicalOrientation { get; }
+        public bool HasLogicalOrientationPublic { get; }
+        protected internal UIElementCollection InternalChildren { get; }
+        public bool IsItemsHost { get; set; }
+        protected internal override IEnumerator LogicalChildren { get; }
+        protected internal virtual Orientation LogicalOrientation { get; }
+        public Orientation LogicalOrientationPublic { get; }
+        protected override int VisualChildrenCount { get; }
+        protected virtual UIElementCollection CreateUIElementCollection(FrameworkElement logicalParent);
+        protected override Visual GetVisualChild(int index);
+        public static int GetZIndex(UIElement element);
+        protected virtual void OnIsItemsHostChanged(bool oldIsItemsHost, bool newIsItemsHost);
+        protected override void OnRender(DrawingContext dc);
+        protected internal override void OnVisualChildrenChanged(DependencyObject visualAdded, DependencyObject visualRemoved);
+        public static void SetZIndex(UIElement element, int value);
+        public bool ShouldSerializeChildren();
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public enum PanningMode {
+        Both = 3,
+        HorizontalFirst = 4,
+        HorizontalOnly = 1,
+        None = 0,
+        VerticalFirst = 5,
+        VerticalOnly = 2,
+    }
+    public sealed class PasswordBox : Control, ITextBoxViewHost {
+        public static readonly DependencyProperty CaretBrushProperty;
+        public static readonly DependencyProperty IsInactiveSelectionHighlightEnabledProperty;
+        public static readonly DependencyProperty IsSelectionActiveProperty;
+        public static readonly DependencyProperty MaxLengthProperty;
+        public static readonly DependencyProperty PasswordCharProperty;
+        public static readonly DependencyProperty SelectionBrushProperty;
+        public static readonly DependencyProperty SelectionOpacityProperty;
+        public static readonly RoutedEvent PasswordChangedEvent;
+        public PasswordBox();
+        public Brush CaretBrush { get; set; }
+        public bool IsInactiveSelectionHighlightEnabled { get; set; }
+        public bool IsSelectionActive { get; }
+        public int MaxLength { get; set; }
+        public string Password { get; set; }
+        public char PasswordChar { get; set; }
+        public SecureString SecurePassword { get; }
+        public Brush SelectionBrush { get; set; }
+        public double SelectionOpacity { get; set; }
+        public event RoutedEventHandler PasswordChanged;
+        public void Clear();
+        public override void OnApplyTemplate();
+        protected override void OnContextMenuOpening(ContextMenuEventArgs e);
+        protected override AutomationPeer OnCreateAutomationPeer();
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
+        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e);
+        protected override void OnQueryContinueDrag(QueryContinueDragEventArgs e);
+        protected override void OnQueryCursor(QueryCursorEventArgs e);
+        protected override void OnTemplateChanged(ControlTemplate oldTemplate, ControlTemplate newTemplate);
+        protected override void OnTextInput(TextCompositionEventArgs e);
+        public void Paste();
+        public void SelectAll();
+    }
+    public class PrintDialog {
+        public PrintDialog();
+        public bool CurrentPageEnabled { get; set; }
+        public uint MaxPage { get; set; }
+        public uint MinPage { get; set; }
+        public PageRange PageRange { get; set; }
+        public PageRangeSelection PageRangeSelection { get; set; }
+        public double PrintableAreaHeight { get; }
+        public double PrintableAreaWidth { get; }
+        public PrintQueue PrintQueue { get; set; }
+        public PrintTicket PrintTicket { get; set; }
+        public bool SelectedPagesEnabled { get; set; }
+        public bool UserPageRangeEnabled { get; set; }
+        public void PrintDocument(DocumentPaginator documentPaginator, string description);
+        public void PrintVisual(Visual visual, string description);
+        public Nullable<bool> ShowDialog();
+    }
+    public class PrintDialogException : Exception {
+        public PrintDialogException();
+        protected PrintDialogException(SerializationInfo info, StreamingContext context);
+        public PrintDialogException(string message);
+        public PrintDialogException(string message, Exception innerException);
+    }
+    public class ProgressBar : RangeBase {
+        public static readonly DependencyProperty IsIndeterminateProperty;
+        public static readonly DependencyProperty OrientationProperty;
+        public ProgressBar();
+        public bool IsIndeterminate { get; set; }
+        public Orientation Orientation { get; set; }
+        public override void OnApplyTemplate();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnMaximumChanged(double oldMaximum, double newMaximum);
+        protected override void OnMinimumChanged(double oldMinimum, double newMinimum);
+        protected override void OnValueChanged(double oldValue, double newValue);
+    }
+    public class RadioButton : ToggleButton {
+        public static readonly DependencyProperty GroupNameProperty;
+        public RadioButton();
+        public string GroupName { get; set; }
+        protected override void OnAccessKey(AccessKeyEventArgs e);
+        protected override void OnChecked(RoutedEventArgs e);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected internal override void OnToggle();
+    }
+    public class RichTextBox : TextBoxBase, IAddChild {
+        public static readonly DependencyProperty IsDocumentEnabledProperty;
+        public RichTextBox();
+        public RichTextBox(FlowDocument document);
+        public TextPointer CaretPosition { get; set; }
+        public FlowDocument Document { get; set; }
+        public bool IsDocumentEnabled { get; set; }
+        protected internal override IEnumerator LogicalChildren { get; }
+        public TextSelection Selection { get; }
+        public TextPointer GetNextSpellingErrorPosition(TextPointer position, LogicalDirection direction);
+        public TextPointer GetPositionFromPoint(Point point, bool snapToText);
+        public SpellingError GetSpellingError(TextPointer position);
+        public TextRange GetSpellingErrorRange(TextPointer position);
+        protected override Size MeasureOverride(Size constraint);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        public bool ShouldSerializeDocument();
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public class RowDefinition : DefinitionBase {
+        public static readonly DependencyProperty HeightProperty;
+        public static readonly DependencyProperty MaxHeightProperty;
+        public static readonly DependencyProperty MinHeightProperty;
+        public RowDefinition();
+        public double ActualHeight { get; }
+        public GridLength Height { get; set; }
+        public double MaxHeight { get; set; }
+        public double MinHeight { get; set; }
+        public double Offset { get; }
+    }
+    public sealed class RowDefinitionCollection : ICollection, ICollection<RowDefinition>, IEnumerable, IEnumerable<RowDefinition>, IList, IList<RowDefinition> {
+        public int Count { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public RowDefinition this[int index] { get; set; }
+        public void Add(RowDefinition value);
+        public void Clear();
+        public bool Contains(RowDefinition value);
+        public void CopyTo(RowDefinition[] array, int index);
+        public int IndexOf(RowDefinition value);
+        public void Insert(int index, RowDefinition value);
+        public bool Remove(RowDefinition value);
+        public void RemoveAt(int index);
+        public void RemoveRange(int index, int count);
+        IEnumerator<RowDefinition> System.Collections.Generic.IEnumerable<System.Windows.Controls.RowDefinition>.GetEnumerator();
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+    }
+    public enum ScrollBarVisibility {
+        Auto = 1,
+        Disabled = 0,
+        Hidden = 2,
+        Visible = 3,
+    }
+    public class ScrollChangedEventArgs : RoutedEventArgs {
+        public double ExtentHeight { get; }
+        public double ExtentHeightChange { get; }
+        public double ExtentWidth { get; }
+        public double ExtentWidthChange { get; }
+        public double HorizontalChange { get; }
+        public double HorizontalOffset { get; }
+        public double VerticalChange { get; }
+        public double VerticalOffset { get; }
+        public double ViewportHeight { get; }
+        public double ViewportHeightChange { get; }
+        public double ViewportWidth { get; }
+        public double ViewportWidthChange { get; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void ScrollChangedEventHandler(object sender, ScrollChangedEventArgs e);
+    public sealed class ScrollContentPresenter : ContentPresenter, IScrollInfo {
+        public static readonly DependencyProperty CanContentScrollProperty;
+        public ScrollContentPresenter();
+        public AdornerLayer AdornerLayer { get; }
+        public bool CanContentScroll { get; set; }
+        public bool CanHorizontallyScroll { get; set; }
+        public bool CanVerticallyScroll { get; set; }
+        public double ExtentHeight { get; }
+        public double ExtentWidth { get; }
+        public double HorizontalOffset { get; }
+        public ScrollViewer ScrollOwner { get; set; }
+        public double VerticalOffset { get; }
+        public double ViewportHeight { get; }
+        public double ViewportWidth { get; }
+        protected override int VisualChildrenCount { get; }
+        protected override Size ArrangeOverride(Size arrangeSize);
+        protected override Geometry GetLayoutClip(Size layoutSlotSize);
+        protected override Visual GetVisualChild(int index);
+        public void LineDown();
+        public void LineLeft();
+        public void LineRight();
+        public void LineUp();
+        public Rect MakeVisible(Visual visual, Rect rectangle);
+        protected override Size MeasureOverride(Size constraint);
+        public void MouseWheelDown();
+        public void MouseWheelLeft();
+        public void MouseWheelRight();
+        public void MouseWheelUp();
+        public override void OnApplyTemplate();
+        public void PageDown();
+        public void PageLeft();
+        public void PageRight();
+        public void PageUp();
+        public void SetHorizontalOffset(double offset);
+        public void SetVerticalOffset(double offset);
+    }
+    public enum ScrollUnit {
+        Item = 1,
+        Pixel = 0,
+    }
+    public class ScrollViewer : ContentControl {
+        public static readonly DependencyProperty CanContentScrollProperty;
+        public static readonly DependencyProperty ComputedHorizontalScrollBarVisibilityProperty;
+        public static readonly DependencyProperty ComputedVerticalScrollBarVisibilityProperty;
+        public static readonly DependencyProperty ContentHorizontalOffsetProperty;
+        public static readonly DependencyProperty ContentVerticalOffsetProperty;
+        public static readonly DependencyProperty ExtentHeightProperty;
+        public static readonly DependencyProperty ExtentWidthProperty;
+        public static readonly DependencyProperty HorizontalOffsetProperty;
+        public static readonly DependencyProperty HorizontalScrollBarVisibilityProperty;
+        public static readonly DependencyProperty IsDeferredScrollingEnabledProperty;
+        public static readonly DependencyProperty PanningDecelerationProperty;
+        public static readonly DependencyProperty PanningModeProperty;
+        public static readonly DependencyProperty PanningRatioProperty;
+        public static readonly DependencyProperty ScrollableHeightProperty;
+        public static readonly DependencyProperty ScrollableWidthProperty;
+        public static readonly DependencyProperty VerticalOffsetProperty;
+        public static readonly DependencyProperty VerticalScrollBarVisibilityProperty;
+        public static readonly DependencyProperty ViewportHeightProperty;
+        public static readonly DependencyProperty ViewportWidthProperty;
+        public static readonly RoutedEvent ScrollChangedEvent;
+        public ScrollViewer();
+        public bool CanContentScroll { get; set; }
+        public Visibility ComputedHorizontalScrollBarVisibility { get; }
+        public Visibility ComputedVerticalScrollBarVisibility { get; }
+        public double ContentHorizontalOffset { get; private set; }
+        public double ContentVerticalOffset { get; private set; }
+        public double ExtentHeight { get; }
+        public double ExtentWidth { get; }
+        protected internal override bool HandlesScrolling { get; }
+        public double HorizontalOffset { get; private set; }
+        public ScrollBarVisibility HorizontalScrollBarVisibility { get; set; }
+        public bool IsDeferredScrollingEnabled { get; set; }
+        public double PanningDeceleration { get; set; }
+        public PanningMode PanningMode { get; set; }
+        public double PanningRatio { get; set; }
+        public double ScrollableHeight { get; }
+        public double ScrollableWidth { get; }
+        protected internal IScrollInfo ScrollInfo { get; set; }
+        public double VerticalOffset { get; private set; }
+        public ScrollBarVisibility VerticalScrollBarVisibility { get; set; }
+        public double ViewportHeight { get; }
+        public double ViewportWidth { get; }
+        public event ScrollChangedEventHandler ScrollChanged;
+        protected override Size ArrangeOverride(Size arrangeSize);
+        public static bool GetCanContentScroll(DependencyObject element);
+        public static ScrollBarVisibility GetHorizontalScrollBarVisibility(DependencyObject element);
+        public static bool GetIsDeferredScrollingEnabled(DependencyObject element);
+        public static double GetPanningDeceleration(DependencyObject element);
+        public static PanningMode GetPanningMode(DependencyObject element);
+        public static double GetPanningRatio(DependencyObject element);
+        public static ScrollBarVisibility GetVerticalScrollBarVisibility(DependencyObject element);
+        protected override HitTestResult HitTestCore(PointHitTestParameters hitTestParameters);
+        public void InvalidateScrollInfo();
+        public void LineDown();
+        public void LineLeft();
+        public void LineRight();
+        public void LineUp();
+        protected override Size MeasureOverride(Size constraint);
+        public override void OnApplyTemplate();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected override void OnManipulationCompleted(ManipulationCompletedEventArgs e);
+        protected override void OnManipulationDelta(ManipulationDeltaEventArgs e);
+        protected override void OnManipulationInertiaStarting(ManipulationInertiaStartingEventArgs e);
+        protected override void OnManipulationStarting(ManipulationStartingEventArgs e);
+        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e);
+        protected override void OnMouseWheel(MouseWheelEventArgs e);
+        protected virtual void OnScrollChanged(ScrollChangedEventArgs e);
+        protected override void OnStylusSystemGesture(StylusSystemGestureEventArgs e);
+        public void PageDown();
+        public void PageLeft();
+        public void PageRight();
+        public void PageUp();
+        public void ScrollToBottom();
+        public void ScrollToEnd();
+        public void ScrollToHome();
+        public void ScrollToHorizontalOffset(double offset);
+        public void ScrollToLeftEnd();
+        public void ScrollToRightEnd();
+        public void ScrollToTop();
+        public void ScrollToVerticalOffset(double offset);
+        public static void SetCanContentScroll(DependencyObject element, bool canContentScroll);
+        public static void SetHorizontalScrollBarVisibility(DependencyObject element, ScrollBarVisibility horizontalScrollBarVisibility);
+        public static void SetIsDeferredScrollingEnabled(DependencyObject element, bool value);
+        public static void SetPanningDeceleration(DependencyObject element, double value);
+        public static void SetPanningMode(DependencyObject element, PanningMode panningMode);
+        public static void SetPanningRatio(DependencyObject element, double value);
+        public static void SetVerticalScrollBarVisibility(DependencyObject element, ScrollBarVisibility verticalScrollBarVisibility);
+    }
+    public class SelectedCellsChangedEventArgs : EventArgs {
+        public SelectedCellsChangedEventArgs(List<DataGridCellInfo> addedCells, List<DataGridCellInfo> removedCells);
+        public SelectedCellsChangedEventArgs(ReadOnlyCollection<DataGridCellInfo> addedCells, ReadOnlyCollection<DataGridCellInfo> removedCells);
+        public IList<DataGridCellInfo> AddedCells { get; }
+        public IList<DataGridCellInfo> RemovedCells { get; }
+    }
+    public delegate void SelectedCellsChangedEventHandler(object sender, SelectedCellsChangedEventArgs e);
+    public sealed class SelectedDatesCollection : ObservableCollection<DateTime> {
+        public SelectedDatesCollection(Calendar owner);
+        public void AddRange(DateTime start, DateTime end);
+        protected override void ClearItems();
+        protected override void InsertItem(int index, DateTime item);
+        protected override void RemoveItem(int index);
+        protected override void SetItem(int index, DateTime item);
+    }
+    public class SelectionChangedEventArgs : RoutedEventArgs {
+        public SelectionChangedEventArgs(RoutedEvent id, IList removedItems, IList addedItems);
+        public IList AddedItems { get; }
+        public IList RemovedItems { get; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void SelectionChangedEventHandler(object sender, SelectionChangedEventArgs e);
+    public enum SelectionMode {
+        Extended = 2,
+        Multiple = 1,
+        Single = 0,
+    }
+    public enum SelectiveScrollingOrientation {
+        Both = 3,
+        Horizontal = 1,
+        None = 0,
+        Vertical = 2,
+    }
+    public class Separator : Control {
+        public Separator();
+        protected override AutomationPeer OnCreateAutomationPeer();
+    }
+    public class Slider : RangeBase {
+        public static readonly DependencyProperty AutoToolTipPlacementProperty;
+        public static readonly DependencyProperty AutoToolTipPrecisionProperty;
+        public static readonly DependencyProperty DelayProperty;
+        public static readonly DependencyProperty IntervalProperty;
+        public static readonly DependencyProperty IsDirectionReversedProperty;
+        public static readonly DependencyProperty IsMoveToPointEnabledProperty;
+        public static readonly DependencyProperty IsSelectionRangeEnabledProperty;
+        public static readonly DependencyProperty IsSnapToTickEnabledProperty;
+        public static readonly DependencyProperty OrientationProperty;
+        public static readonly DependencyProperty SelectionEndProperty;
+        public static readonly DependencyProperty SelectionStartProperty;
+        public static readonly DependencyProperty TickFrequencyProperty;
+        public static readonly DependencyProperty TickPlacementProperty;
+        public static readonly DependencyProperty TicksProperty;
+        public Slider();
+        public AutoToolTipPlacement AutoToolTipPlacement { get; set; }
+        public int AutoToolTipPrecision { get; set; }
+        public static RoutedCommand DecreaseLarge { get; }
+        public static RoutedCommand DecreaseSmall { get; }
+        public int Delay { get; set; }
+        public static RoutedCommand IncreaseLarge { get; }
+        public static RoutedCommand IncreaseSmall { get; }
+        public int Interval { get; set; }
+        public bool IsDirectionReversed { get; set; }
+        public bool IsMoveToPointEnabled { get; set; }
+        public bool IsSelectionRangeEnabled { get; set; }
+        public bool IsSnapToTickEnabled { get; set; }
+        public static RoutedCommand MaximizeValue { get; }
+        public static RoutedCommand MinimizeValue { get; }
+        public Orientation Orientation { get; set; }
+        public double SelectionEnd { get; set; }
+        public double SelectionStart { get; set; }
+        public double TickFrequency { get; set; }
+        public TickPlacement TickPlacement { get; set; }
+        public DoubleCollection Ticks { get; set; }
+        protected override Size ArrangeOverride(Size finalSize);
+        public override void OnApplyTemplate();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected virtual void OnDecreaseLarge();
+        protected virtual void OnDecreaseSmall();
+        protected virtual void OnIncreaseLarge();
+        protected virtual void OnIncreaseSmall();
+        protected virtual void OnMaximizeValue();
+        protected override void OnMaximumChanged(double oldMaximum, double newMaximum);
+        protected virtual void OnMinimizeValue();
+        protected override void OnMinimumChanged(double oldMinimum, double newMinimum);
+        protected override void OnPreviewMouseLeftButtonDown(MouseButtonEventArgs e);
+        protected virtual void OnThumbDragCompleted(DragCompletedEventArgs e);
+        protected virtual void OnThumbDragDelta(DragDeltaEventArgs e);
+        protected virtual void OnThumbDragStarted(DragStartedEventArgs e);
+        protected override void OnValueChanged(double oldValue, double newValue);
+    }
+    public class SoundPlayerAction : TriggerAction, IDisposable {
+        public static readonly DependencyProperty SourceProperty;
+        public SoundPlayerAction();
+        public Uri Source { get; set; }
+        public void Dispose();
+    }
+    public sealed class SpellCheck {
+        public static readonly DependencyProperty CustomDictionariesProperty;
+        public static readonly DependencyProperty IsEnabledProperty;
+        public static readonly DependencyProperty SpellingReformProperty;
+        public IList CustomDictionaries { get; }
+        public bool IsEnabled { get; set; }
+        public SpellingReform SpellingReform { get; set; }
+        public static IList GetCustomDictionaries(TextBoxBase textBoxBase);
+        public static bool GetIsEnabled(TextBoxBase textBoxBase);
+        public static void SetIsEnabled(TextBoxBase textBoxBase, bool value);
+        public static void SetSpellingReform(TextBoxBase textBoxBase, SpellingReform value);
+    }
+    public class SpellingError {
+        public IEnumerable<string> Suggestions { get; }
+        public void Correct(string correctedText);
+        public void IgnoreAll();
+    }
+    public enum SpellingReform {
+        Postreform = 2,
+        PreAndPostreform = 0,
+        Prereform = 1,
+    }
+    public class StackPanel : Panel, IScrollInfo, IStackMeasure {
+        public static readonly DependencyProperty OrientationProperty;
+        public StackPanel();
+        public bool CanHorizontallyScroll { get; set; }
+        public bool CanVerticallyScroll { get; set; }
+        public double ExtentHeight { get; }
+        public double ExtentWidth { get; }
+        protected internal override bool HasLogicalOrientation { get; }
+        public double HorizontalOffset { get; }
+        protected internal override Orientation LogicalOrientation { get; }
+        public Orientation Orientation { get; set; }
+        public ScrollViewer ScrollOwner { get; set; }
+        public double VerticalOffset { get; }
+        public double ViewportHeight { get; }
+        public double ViewportWidth { get; }
+        protected override Size ArrangeOverride(Size arrangeSize);
+        public void LineDown();
+        public void LineLeft();
+        public void LineRight();
+        public void LineUp();
+        public Rect MakeVisible(Visual visual, Rect rectangle);
+        protected override Size MeasureOverride(Size constraint);
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
+    public sealed class StickyNoteControl : Control, IAnnotationComponent {
+        public static readonly DependencyProperty AuthorProperty;
+        public static readonly DependencyProperty CaptionFontFamilyProperty;
+        public static readonly DependencyProperty CaptionFontSizeProperty;
+        public static readonly DependencyProperty CaptionFontStretchProperty;
+        public static readonly DependencyProperty CaptionFontStyleProperty;
+        public static readonly DependencyProperty CaptionFontWeightProperty;
+        public static readonly DependencyProperty IsActiveProperty;
+        public static readonly DependencyProperty IsExpandedProperty;
+        public static readonly DependencyProperty IsMouseOverAnchorProperty;
+        public static readonly DependencyProperty PenWidthProperty;
+        public static readonly DependencyProperty StickyNoteTypeProperty;
+        public static readonly RoutedCommand DeleteNoteCommand;
+        public static readonly RoutedCommand InkCommand;
+        public static readonly XmlQualifiedName InkSchemaName;
+        public static readonly XmlQualifiedName TextSchemaName;
+        public IAnchorInfo AnchorInfo { get; }
+        public string Author { get; }
+        public FontFamily CaptionFontFamily { get; set; }
+        public double CaptionFontSize { get; set; }
+        public FontStretch CaptionFontStretch { get; set; }
+        public FontStyle CaptionFontStyle { get; set; }
+        public FontWeight CaptionFontWeight { get; set; }
+        public bool IsActive { get; }
+        public bool IsExpanded { get; set; }
+        public bool IsMouseOverAnchor { get; }
+        public double PenWidth { get; set; }
+        public StickyNoteType StickyNoteType { get; }
+        public override void OnApplyTemplate();
+        protected override void OnGotKeyboardFocus(KeyboardFocusChangedEventArgs args);
+        protected override void OnIsKeyboardFocusWithinChanged(DependencyPropertyChangedEventArgs args);
+        protected override void OnTemplateChanged(ControlTemplate oldTemplate, ControlTemplate newTemplate);
+    }
+    public enum StickyNoteType {
+        Ink = 1,
+        Text = 0,
+    }
+    public enum StretchDirection {
+        Both = 2,
+        DownOnly = 1,
+        UpOnly = 0,
+    }
+    public class StyleSelector {
+        public StyleSelector();
+        public virtual Style SelectStyle(object item, DependencyObject container);
+    }
+    public class TabControl : Selector {
+        public static readonly DependencyProperty ContentStringFormatProperty;
+        public static readonly DependencyProperty ContentTemplateProperty;
+        public static readonly DependencyProperty ContentTemplateSelectorProperty;
+        public static readonly DependencyProperty SelectedContentProperty;
+        public static readonly DependencyProperty SelectedContentStringFormatProperty;
+        public static readonly DependencyProperty SelectedContentTemplateProperty;
+        public static readonly DependencyProperty SelectedContentTemplateSelectorProperty;
+        public static readonly DependencyProperty TabStripPlacementProperty;
+        public TabControl();
+        public string ContentStringFormat { get; set; }
+        public DataTemplate ContentTemplate { get; set; }
+        public DataTemplateSelector ContentTemplateSelector { get; set; }
+        public object SelectedContent { get; internal set; }
+        public string SelectedContentStringFormat { get; internal set; }
+        public DataTemplate SelectedContentTemplate { get; internal set; }
+        public DataTemplateSelector SelectedContentTemplateSelector { get; internal set; }
+        public Dock TabStripPlacement { get; set; }
+        protected override DependencyObject GetContainerForItemOverride();
+        protected override bool IsItemItsOwnContainerOverride(object item);
+        public override void OnApplyTemplate();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnInitialized(EventArgs e);
+        protected override void OnItemsChanged(NotifyCollectionChangedEventArgs e);
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected override void OnSelectionChanged(SelectionChangedEventArgs e);
+    }
+    public class TabItem : HeaderedContentControl {
+        public static readonly DependencyProperty IsSelectedProperty;
+        public static readonly DependencyProperty TabStripPlacementProperty;
+        public TabItem();
+        public bool IsSelected { get; set; }
+        public Dock TabStripPlacement { get; }
+        protected override void OnAccessKey(AccessKeyEventArgs e);
+        protected override void OnContentChanged(object oldContent, object newContent);
+        protected override void OnContentTemplateChanged(DataTemplate oldContentTemplate, DataTemplate newContentTemplate);
+        protected override void OnContentTemplateSelectorChanged(DataTemplateSelector oldContentTemplateSelector, DataTemplateSelector newContentTemplateSelector);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e);
+        protected override void OnPreviewGotKeyboardFocus(KeyboardFocusChangedEventArgs e);
+        protected virtual void OnSelected(RoutedEventArgs e);
+        protected virtual void OnUnselected(RoutedEventArgs e);
+    }
+    public class TextBlock : FrameworkElement, IAddChild, IAddChildInternal, IContentHost, IServiceProvider {
+        public static readonly DependencyProperty BackgroundProperty;
+        public static readonly DependencyProperty BaselineOffsetProperty;
+        public static readonly DependencyProperty FontFamilyProperty;
+        public static readonly DependencyProperty FontSizeProperty;
+        public static readonly DependencyProperty FontStretchProperty;
+        public static readonly DependencyProperty FontStyleProperty;
+        public static readonly DependencyProperty FontWeightProperty;
+        public static readonly DependencyProperty ForegroundProperty;
+        public static readonly DependencyProperty IsHyphenationEnabledProperty;
+        public static readonly DependencyProperty LineHeightProperty;
+        public static readonly DependencyProperty LineStackingStrategyProperty;
+        public static readonly DependencyProperty PaddingProperty;
+        public static readonly DependencyProperty TextAlignmentProperty;
+        public static readonly DependencyProperty TextDecorationsProperty;
+        public static readonly DependencyProperty TextEffectsProperty;
+        public static readonly DependencyProperty TextProperty;
+        public static readonly DependencyProperty TextTrimmingProperty;
+        public static readonly DependencyProperty TextWrappingProperty;
+        public TextBlock();
+        public TextBlock(Inline inline);
+        public Brush Background { get; set; }
+        public double BaselineOffset { get; set; }
+        public LineBreakCondition BreakAfter { get; }
+        public LineBreakCondition BreakBefore { get; }
+        public TextPointer ContentEnd { get; }
+        public TextPointer ContentStart { get; }
+        public FontFamily FontFamily { get; set; }
+        public double FontSize { get; set; }
+        public FontStretch FontStretch { get; set; }
+        public FontStyle FontStyle { get; set; }
+        public FontWeight FontWeight { get; set; }
+        public Brush Foreground { get; set; }
+        protected virtual IEnumerator<IInputElement> HostedElementsCore { get; }
+        public InlineCollection Inlines { get; }
+        public bool IsHyphenationEnabled { get; set; }
+        public double LineHeight { get; set; }
+        public LineStackingStrategy LineStackingStrategy { get; set; }
+        protected internal override IEnumerator LogicalChildren { get; }
+        public Thickness Padding { get; set; }
+        IEnumerator<IInputElement> System.Windows.IContentHost.HostedElements { get; }
+        public string Text { get; set; }
+        public TextAlignment TextAlignment { get; set; }
+        public TextDecorationCollection TextDecorations { get; set; }
+        public TextEffectCollection TextEffects { get; set; }
+        public TextTrimming TextTrimming { get; set; }
+        public TextWrapping TextWrapping { get; set; }
+        public Typography Typography { get; }
+        protected override int VisualChildrenCount { get; }
+        protected sealed override Size ArrangeOverride(Size arrangeSize);
+        public static double GetBaselineOffset(DependencyObject element);
+        public static FontFamily GetFontFamily(DependencyObject element);
+        public static double GetFontSize(DependencyObject element);
+        public static FontStretch GetFontStretch(DependencyObject element);
+        public static FontStyle GetFontStyle(DependencyObject element);
+        public static FontWeight GetFontWeight(DependencyObject element);
+        public static Brush GetForeground(DependencyObject element);
+        public static double GetLineHeight(DependencyObject element);
+        public static LineStackingStrategy GetLineStackingStrategy(DependencyObject element);
+        public TextPointer GetPositionFromPoint(Point point, bool snapToText);
+        protected virtual ReadOnlyCollection<Rect> GetRectanglesCore(ContentElement child);
+        public static TextAlignment GetTextAlignment(DependencyObject element);
+        protected override Visual GetVisualChild(int index);
+        protected sealed override HitTestResult HitTestCore(PointHitTestParameters hitTestParameters);
+        protected virtual IInputElement InputHitTestCore(Point point);
+        protected sealed override Size MeasureOverride(Size constraint);
+        protected virtual void OnChildDesiredSizeChangedCore(UIElement child);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected sealed override void OnPropertyChanged(DependencyPropertyChangedEventArgs e);
+        protected sealed override void OnRender(DrawingContext ctx);
+        public static void SetBaselineOffset(DependencyObject element, double value);
+        public static void SetFontFamily(DependencyObject element, FontFamily value);
+        public static void SetFontSize(DependencyObject element, double value);
+        public static void SetFontStretch(DependencyObject element, FontStretch value);
+        public static void SetFontStyle(DependencyObject element, FontStyle value);
+        public static void SetFontWeight(DependencyObject element, FontWeight value);
+        public static void SetForeground(DependencyObject element, Brush value);
+        public static void SetLineHeight(DependencyObject element, double value);
+        public static void SetLineStackingStrategy(DependencyObject element, LineStackingStrategy value);
+        public static void SetTextAlignment(DependencyObject element, TextAlignment value);
+        public bool ShouldSerializeBaselineOffset();
+        public bool ShouldSerializeInlines(XamlDesignerSerializationManager manager);
+        public bool ShouldSerializeText();
+        object System.IServiceProvider.GetService(Type serviceType);
+        ReadOnlyCollection<Rect> System.Windows.IContentHost.GetRectangles(ContentElement child);
+        IInputElement System.Windows.IContentHost.InputHitTest(Point point);
+        void System.Windows.IContentHost.OnChildDesiredSizeChanged(UIElement child);
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public class TextBox : TextBoxBase, IAddChild, ITextBoxViewHost {
+        public static readonly DependencyProperty CharacterCasingProperty;
+        public static readonly DependencyProperty MaxLengthProperty;
+        public static readonly DependencyProperty MaxLinesProperty;
+        public static readonly DependencyProperty MinLinesProperty;
+        public static readonly DependencyProperty TextAlignmentProperty;
+        public static readonly DependencyProperty TextDecorationsProperty;
+        public static readonly DependencyProperty TextProperty;
+        public static readonly DependencyProperty TextWrappingProperty;
+        public TextBox();
+        public int CaretIndex { get; set; }
+        public CharacterCasing CharacterCasing { get; set; }
+        public int LineCount { get; }
+        protected internal override IEnumerator LogicalChildren { get; }
+        public int MaxLength { get; set; }
+        public int MaxLines { get; set; }
+        public int MinLines { get; set; }
+        public string SelectedText { get; set; }
+        public int SelectionLength { get; set; }
+        public int SelectionStart { get; set; }
+        public string Text { get; set; }
+        public TextAlignment TextAlignment { get; set; }
+        public TextDecorationCollection TextDecorations { get; set; }
+        public TextWrapping TextWrapping { get; set; }
+        public Typography Typography { get; }
+        public void Clear();
+        public int GetCharacterIndexFromLineIndex(int lineIndex);
+        public int GetCharacterIndexFromPoint(Point point, bool snapToText);
+        public int GetFirstVisibleLineIndex();
+        public int GetLastVisibleLineIndex();
+        public int GetLineIndexFromCharacterIndex(int charIndex);
+        public int GetLineLength(int lineIndex);
+        public string GetLineText(int lineIndex);
+        public int GetNextSpellingErrorCharacterIndex(int charIndex, LogicalDirection direction);
+        public Rect GetRectFromCharacterIndex(int charIndex);
+        public Rect GetRectFromCharacterIndex(int charIndex, bool trailingEdge);
+        public SpellingError GetSpellingError(int charIndex);
+        public int GetSpellingErrorLength(int charIndex);
+        public int GetSpellingErrorStart(int charIndex);
+        protected override Size MeasureOverride(Size constraint);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e);
+        public void ScrollToLine(int lineIndex);
+        public void Select(int start, int length);
+        public bool ShouldSerializeText(XamlDesignerSerializationManager manager);
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public class TextChange {
+        public int AddedLength { get; internal set; }
+        public int Offset { get; internal set; }
+        public int RemovedLength { get; internal set; }
+    }
+    public class TextChangedEventArgs : RoutedEventArgs {
+        public TextChangedEventArgs(RoutedEvent id, UndoAction action);
+        public TextChangedEventArgs(RoutedEvent id, UndoAction action, ICollection<TextChange> changes);
+        public ICollection<TextChange> Changes { get; }
+        public UndoAction UndoAction { get; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void TextChangedEventHandler(object sender, TextChangedEventArgs e);
+    public sealed class TextSearch : DependencyObject {
+        public static readonly DependencyProperty TextPathProperty;
+        public static readonly DependencyProperty TextProperty;
+        public static string GetText(DependencyObject element);
+        public static string GetTextPath(DependencyObject element);
+        public static void SetText(DependencyObject element, string text);
+        public static void SetTextPath(DependencyObject element, string path);
+    }
+    public class ToolBar : HeaderedItemsControl {
+        public static readonly DependencyProperty BandIndexProperty;
+        public static readonly DependencyProperty BandProperty;
+        public static readonly DependencyProperty HasOverflowItemsProperty;
+        public static readonly DependencyProperty IsOverflowItemProperty;
+        public static readonly DependencyProperty IsOverflowOpenProperty;
+        public static readonly DependencyProperty OrientationProperty;
+        public static readonly DependencyProperty OverflowModeProperty;
+        public ToolBar();
+        public int Band { get; set; }
+        public int BandIndex { get; set; }
+        public static ResourceKey ButtonStyleKey { get; }
+        public static ResourceKey CheckBoxStyleKey { get; }
+        public static ResourceKey ComboBoxStyleKey { get; }
+        public bool HasOverflowItems { get; }
+        public bool IsOverflowOpen { get; set; }
+        public static ResourceKey MenuStyleKey { get; }
+        public Orientation Orientation { get; }
+        public static ResourceKey RadioButtonStyleKey { get; }
+        public static ResourceKey SeparatorStyleKey { get; }
+        public static ResourceKey TextBoxStyleKey { get; }
+        public static ResourceKey ToggleButtonStyleKey { get; }
+        public static bool GetIsOverflowItem(DependencyObject element);
+        public static OverflowMode GetOverflowMode(DependencyObject element);
+        protected override Size MeasureOverride(Size constraint);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnItemsChanged(NotifyCollectionChangedEventArgs e);
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected override void OnLostMouseCapture(MouseEventArgs e);
+        protected override void PrepareContainerForItemOverride(DependencyObject element, object item);
+        public static void SetOverflowMode(DependencyObject element, OverflowMode mode);
+    }
+    public class ToolBarTray : FrameworkElement, IAddChild {
+        public static readonly DependencyProperty BackgroundProperty;
+        public static readonly DependencyProperty IsLockedProperty;
+        public static readonly DependencyProperty OrientationProperty;
+        public ToolBarTray();
+        public Brush Background { get; set; }
+        public bool IsLocked { get; set; }
+        protected internal override IEnumerator LogicalChildren { get; }
+        public Orientation Orientation { get; set; }
+        public Collection<ToolBar> ToolBars { get; }
+        protected override int VisualChildrenCount { get; }
+        protected override Size ArrangeOverride(Size arrangeSize);
+        public static bool GetIsLocked(DependencyObject element);
+        protected override Visual GetVisualChild(int index);
+        protected override Size MeasureOverride(Size constraint);
+        protected override void OnRender(DrawingContext dc);
+        public static void SetIsLocked(DependencyObject element, bool value);
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public class ToolTip : ContentControl {
+        public static readonly DependencyProperty CustomPopupPlacementCallbackProperty;
+        public static readonly DependencyProperty HasDropShadowProperty;
+        public static readonly DependencyProperty HorizontalOffsetProperty;
+        public static readonly DependencyProperty IsOpenProperty;
+        public static readonly DependencyProperty PlacementProperty;
+        public static readonly DependencyProperty PlacementRectangleProperty;
+        public static readonly DependencyProperty PlacementTargetProperty;
+        public static readonly DependencyProperty StaysOpenProperty;
+        public static readonly DependencyProperty VerticalOffsetProperty;
+        public static readonly RoutedEvent ClosedEvent;
+        public static readonly RoutedEvent OpenedEvent;
+        public ToolTip();
+        public CustomPopupPlacementCallback CustomPopupPlacementCallback { get; set; }
+        public bool HasDropShadow { get; set; }
+        public double HorizontalOffset { get; set; }
+        public bool IsOpen { get; set; }
+        public PlacementMode Placement { get; set; }
+        public Rect PlacementRectangle { get; set; }
+        public UIElement PlacementTarget { get; set; }
+        public bool StaysOpen { get; set; }
+        public double VerticalOffset { get; set; }
+        public event RoutedEventHandler Closed;
+        public event RoutedEventHandler Opened;
+        protected virtual void OnClosed(RoutedEventArgs e);
+        protected override void OnContentChanged(object oldContent, object newContent);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected virtual void OnOpened(RoutedEventArgs e);
+        protected internal override void OnVisualParentChanged(DependencyObject oldParent);
+    }
+    public sealed class ToolTipEventArgs : RoutedEventArgs {
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void ToolTipEventHandler(object sender, ToolTipEventArgs e);
+    public static class ToolTipService {
+        public static readonly DependencyProperty BetweenShowDelayProperty;
+        public static readonly DependencyProperty HasDropShadowProperty;
+        public static readonly DependencyProperty HorizontalOffsetProperty;
+        public static readonly DependencyProperty InitialShowDelayProperty;
+        public static readonly DependencyProperty IsEnabledProperty;
+        public static readonly DependencyProperty IsOpenProperty;
+        public static readonly DependencyProperty PlacementProperty;
+        public static readonly DependencyProperty PlacementRectangleProperty;
+        public static readonly DependencyProperty PlacementTargetProperty;
+        public static readonly DependencyProperty ShowDurationProperty;
+        public static readonly DependencyProperty ShowOnDisabledProperty;
+        public static readonly DependencyProperty ToolTipProperty;
+        public static readonly DependencyProperty VerticalOffsetProperty;
+        public static readonly RoutedEvent ToolTipClosingEvent;
+        public static readonly RoutedEvent ToolTipOpeningEvent;
+        public static void AddToolTipClosingHandler(DependencyObject element, ToolTipEventHandler handler);
+        public static void AddToolTipOpeningHandler(DependencyObject element, ToolTipEventHandler handler);
+        public static int GetBetweenShowDelay(DependencyObject element);
+        public static bool GetHasDropShadow(DependencyObject element);
+        public static double GetHorizontalOffset(DependencyObject element);
+        public static int GetInitialShowDelay(DependencyObject element);
+        public static bool GetIsEnabled(DependencyObject element);
+        public static bool GetIsOpen(DependencyObject element);
+        public static PlacementMode GetPlacement(DependencyObject element);
+        public static Rect GetPlacementRectangle(DependencyObject element);
+        public static UIElement GetPlacementTarget(DependencyObject element);
+        public static int GetShowDuration(DependencyObject element);
+        public static bool GetShowOnDisabled(DependencyObject element);
+        public static object GetToolTip(DependencyObject element);
+        public static double GetVerticalOffset(DependencyObject element);
+        public static void RemoveToolTipClosingHandler(DependencyObject element, ToolTipEventHandler handler);
+        public static void RemoveToolTipOpeningHandler(DependencyObject element, ToolTipEventHandler handler);
+        public static void SetBetweenShowDelay(DependencyObject element, int value);
+        public static void SetHasDropShadow(DependencyObject element, bool value);
+        public static void SetHorizontalOffset(DependencyObject element, double value);
+        public static void SetInitialShowDelay(DependencyObject element, int value);
+        public static void SetIsEnabled(DependencyObject element, bool value);
+        public static void SetPlacement(DependencyObject element, PlacementMode value);
+        public static void SetPlacementRectangle(DependencyObject element, Rect value);
+        public static void SetPlacementTarget(DependencyObject element, UIElement value);
+        public static void SetShowDuration(DependencyObject element, int value);
+        public static void SetShowOnDisabled(DependencyObject element, bool value);
+        public static void SetToolTip(DependencyObject element, object value);
+        public static void SetVerticalOffset(DependencyObject element, double value);
+    }
+    public class TreeView : ItemsControl {
+        public static readonly DependencyProperty SelectedItemProperty;
+        public static readonly DependencyProperty SelectedValuePathProperty;
+        public static readonly DependencyProperty SelectedValueProperty;
+        public static readonly RoutedEvent SelectedItemChangedEvent;
+        public TreeView();
+        protected internal override bool HandlesScrolling { get; }
+        public object SelectedItem { get; }
+        public object SelectedValue { get; }
+        public string SelectedValuePath { get; set; }
+        public event RoutedPropertyChangedEventHandler<object> SelectedItemChanged;
+        protected virtual bool ExpandSubtree(TreeViewItem container);
+        protected override DependencyObject GetContainerForItemOverride();
+        protected override bool IsItemItsOwnContainerOverride(object item);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnGotFocus(RoutedEventArgs e);
+        protected override void OnIsKeyboardFocusWithinChanged(DependencyPropertyChangedEventArgs e);
+        protected override void OnItemsChanged(NotifyCollectionChangedEventArgs e);
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected virtual void OnSelectedItemChanged(RoutedPropertyChangedEventArgs<object> e);
+    }
+    public class TreeViewItem : HeaderedItemsControl, IHierarchicalVirtualizationAndScrollInfo {
+        public static readonly DependencyProperty IsExpandedProperty;
+        public static readonly DependencyProperty IsSelectedProperty;
+        public static readonly DependencyProperty IsSelectionActiveProperty;
+        public static readonly RoutedEvent CollapsedEvent;
+        public static readonly RoutedEvent ExpandedEvent;
+        public static readonly RoutedEvent SelectedEvent;
+        public static readonly RoutedEvent UnselectedEvent;
+        public TreeViewItem();
+        public bool IsExpanded { get; set; }
+        public bool IsSelected { get; set; }
+        public bool IsSelectionActive { get; }
+        HierarchicalVirtualizationConstraints System.Windows.Controls.Primitives.IHierarchicalVirtualizationAndScrollInfo.Constraints { get; set; }
+        HierarchicalVirtualizationHeaderDesiredSizes System.Windows.Controls.Primitives.IHierarchicalVirtualizationAndScrollInfo.HeaderDesiredSizes { get; }
+        bool System.Windows.Controls.Primitives.IHierarchicalVirtualizationAndScrollInfo.InBackgroundLayout { get; set; }
+        HierarchicalVirtualizationItemDesiredSizes System.Windows.Controls.Primitives.IHierarchicalVirtualizationAndScrollInfo.ItemDesiredSizes { get; set; }
+        Panel System.Windows.Controls.Primitives.IHierarchicalVirtualizationAndScrollInfo.ItemsHost { get; }
+        bool System.Windows.Controls.Primitives.IHierarchicalVirtualizationAndScrollInfo.MustDisableVirtualization { get; set; }
+        public event RoutedEventHandler Collapsed;
+        public event RoutedEventHandler Expanded;
+        public event RoutedEventHandler Selected;
+        public event RoutedEventHandler Unselected;
+        protected override Size ArrangeOverride(Size arrangeSize);
+        public void ExpandSubtree();
+        protected override DependencyObject GetContainerForItemOverride();
+        protected override bool IsItemItsOwnContainerOverride(object item);
+        protected virtual void OnCollapsed(RoutedEventArgs e);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected virtual void OnExpanded(RoutedEventArgs e);
+        protected override void OnGotFocus(RoutedEventArgs e);
+        protected override void OnItemsChanged(NotifyCollectionChangedEventArgs e);
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e);
+        protected virtual void OnSelected(RoutedEventArgs e);
+        protected virtual void OnUnselected(RoutedEventArgs e);
+        protected internal override void OnVisualParentChanged(DependencyObject oldParent);
+    }
+    public class UIElementCollection : ICollection, IEnumerable, IList {
+        public UIElementCollection(UIElement visualParent, FrameworkElement logicalParent);
+        public virtual int Capacity { get; set; }
+        public virtual int Count { get; }
+        public virtual bool IsSynchronized { get; }
+        public virtual object SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public virtual UIElement this[int index] { get; set; }
+        public virtual int Add(UIElement element);
+        public virtual void Clear();
+        protected void ClearLogicalParent(UIElement element);
+        public virtual bool Contains(UIElement element);
+        public virtual void CopyTo(Array array, int index);
+        public virtual void CopyTo(UIElement[] array, int index);
+        public virtual IEnumerator GetEnumerator();
+        public virtual int IndexOf(UIElement element);
+        public virtual void Insert(int index, UIElement element);
+        public virtual void Remove(UIElement element);
+        public virtual void RemoveAt(int index);
+        public virtual void RemoveRange(int index, int count);
+        protected void SetLogicalParent(UIElement element);
+        int System.Collections.IList.Add(object value);
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+    }
+    public enum UndoAction {
+        Clear = 4,
+        Create = 5,
+        Merge = 1,
+        None = 0,
+        Redo = 3,
+        Undo = 2,
+    }
+    public class UserControl : ContentControl {
+        public UserControl();
+        protected override AutomationPeer OnCreateAutomationPeer();
+    }
+    public static class Validation {
+        public static readonly DependencyProperty ErrorsProperty;
+        public static readonly DependencyProperty ErrorTemplateProperty;
+        public static readonly DependencyProperty HasErrorProperty;
+        public static readonly DependencyProperty ValidationAdornerSiteForProperty;
+        public static readonly DependencyProperty ValidationAdornerSiteProperty;
+        public static readonly RoutedEvent ErrorEvent;
+        public static void AddErrorHandler(DependencyObject element, EventHandler<ValidationErrorEventArgs> handler);
+        public static void ClearInvalid(BindingExpressionBase bindingExpression);
+        public static ReadOnlyObservableCollection<ValidationError> GetErrors(DependencyObject element);
+        public static ControlTemplate GetErrorTemplate(DependencyObject element);
+        public static bool GetHasError(DependencyObject element);
+        public static DependencyObject GetValidationAdornerSite(DependencyObject element);
+        public static DependencyObject GetValidationAdornerSiteFor(DependencyObject element);
+        public static void MarkInvalid(BindingExpressionBase bindingExpression, ValidationError validationError);
+        public static void RemoveErrorHandler(DependencyObject element, EventHandler<ValidationErrorEventArgs> handler);
+        public static void SetErrorTemplate(DependencyObject element, ControlTemplate value);
+        public static void SetValidationAdornerSite(DependencyObject element, DependencyObject value);
+        public static void SetValidationAdornerSiteFor(DependencyObject element, DependencyObject value);
+    }
+    public class ValidationError {
+        public ValidationError(ValidationRule ruleInError, object bindingInError);
+        public ValidationError(ValidationRule ruleInError, object bindingInError, object errorContent, Exception exception);
+        public object BindingInError { get; }
+        public object ErrorContent { get; set; }
+        public Exception Exception { get; set; }
+        public ValidationRule RuleInError { get; set; }
+    }
+    public enum ValidationErrorEventAction {
+        Added = 0,
+        Removed = 1,
+    }
+    public class ValidationErrorEventArgs : RoutedEventArgs {
+        public ValidationErrorEventAction Action { get; }
+        public ValidationError Error { get; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public class ValidationResult {
+        public ValidationResult(bool isValid, object errorContent);
+        public object ErrorContent { get; }
+        public bool IsValid { get; }
+        public static ValidationResult ValidResult { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public static bool operator ==(ValidationResult left, ValidationResult right);
+        public static bool operator !=(ValidationResult left, ValidationResult right);
+    }
+    public abstract class ValidationRule {
+        protected ValidationRule();
+        protected ValidationRule(ValidationStep validationStep, bool validatesOnTargetUpdated);
+        public bool ValidatesOnTargetUpdated { get; set; }
+        public ValidationStep ValidationStep { get; set; }
+        public abstract ValidationResult Validate(object value, CultureInfo cultureInfo);
+        public virtual ValidationResult Validate(object value, CultureInfo cultureInfo, BindingExpressionBase owner);
+        public virtual ValidationResult Validate(object value, CultureInfo cultureInfo, BindingGroup owner);
+    }
+    public enum ValidationStep {
+        CommittedValue = 3,
+        ConvertedProposedValue = 1,
+        RawProposedValue = 0,
+        UpdatedValue = 2,
+    }
+    public abstract class ViewBase : DependencyObject {
+        protected ViewBase();
+        protected internal virtual object DefaultStyleKey { get; }
+        protected internal virtual object ItemContainerDefaultStyleKey { get; }
+        protected internal virtual void ClearItem(ListViewItem item);
+        protected internal virtual IViewAutomationPeer GetAutomationPeer(ListView parent);
+        protected internal virtual void PrepareItem(ListViewItem item);
+    }
+    public class Viewbox : Decorator {
+        public static readonly DependencyProperty StretchDirectionProperty;
+        public static readonly DependencyProperty StretchProperty;
+        public Viewbox();
+        public override UIElement Child { get; set; }
+        protected internal override IEnumerator LogicalChildren { get; }
+        public Stretch Stretch { get; set; }
+        public StretchDirection StretchDirection { get; set; }
+        protected override int VisualChildrenCount { get; }
+        protected override Size ArrangeOverride(Size arrangeSize);
+        protected override Visual GetVisualChild(int index);
+        protected override Size MeasureOverride(Size constraint);
+    }
+    public class Viewport3D : FrameworkElement, IAddChild {
+        public static readonly DependencyProperty CameraProperty;
+        public static readonly DependencyProperty ChildrenProperty;
+        public Viewport3D();
+        public Camera Camera { get; set; }
+        public Visual3DCollection Children { get; }
+        protected override int VisualChildrenCount { get; }
+        protected override Size ArrangeOverride(Size finalSize);
+        protected override Visual GetVisualChild(int index);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct VirtualizationCacheLength : IEquatable<VirtualizationCacheLength> {
+        public VirtualizationCacheLength(double cacheBeforeAndAfterViewport);
+        public VirtualizationCacheLength(double cacheBeforeViewport, double cacheAfterViewport);
+        public double CacheAfterViewport { get; }
+        public double CacheBeforeViewport { get; }
+        public override bool Equals(object oCompare);
+        public bool Equals(VirtualizationCacheLength cacheLength);
+        public override int GetHashCode();
+        public static bool operator ==(VirtualizationCacheLength cl1, VirtualizationCacheLength cl2);
+        public static bool operator !=(VirtualizationCacheLength cl1, VirtualizationCacheLength cl2);
+        public override string ToString();
+    }
+    public class VirtualizationCacheLengthConverter : TypeConverter {
+        public VirtualizationCacheLengthConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext typeDescriptorContext, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext typeDescriptorContext, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext typeDescriptorContext, CultureInfo cultureInfo, object source);
+        public override object ConvertTo(ITypeDescriptorContext typeDescriptorContext, CultureInfo cultureInfo, object value, Type destinationType);
+    }
+    public enum VirtualizationCacheLengthUnit {
+        Item = 1,
+        Page = 2,
+        Pixel = 0,
+    }
+    public enum VirtualizationMode {
+        Recycling = 1,
+        Standard = 0,
+    }
+    public abstract class VirtualizingPanel : Panel {
+        public static readonly DependencyProperty CacheLengthProperty;
+        public static readonly DependencyProperty CacheLengthUnitProperty;
+        public static readonly DependencyProperty IsContainerVirtualizableProperty;
+        public static readonly DependencyProperty IsVirtualizingProperty;
+        public static readonly DependencyProperty IsVirtualizingWhenGroupingProperty;
+        public static readonly DependencyProperty ScrollUnitProperty;
+        public static readonly DependencyProperty VirtualizationModeProperty;
+        protected VirtualizingPanel();
+        public bool CanHierarchicallyScrollAndVirtualize { get; }
+        protected virtual bool CanHierarchicallyScrollAndVirtualizeCore { get; }
+        public IItemContainerGenerator ItemContainerGenerator { get; }
+        protected void AddInternalChild(UIElement child);
+        protected internal virtual void BringIndexIntoView(int index);
+        public void BringIndexIntoViewPublic(int index);
+        public static VirtualizationCacheLength GetCacheLength(DependencyObject element);
+        public static VirtualizationCacheLengthUnit GetCacheLengthUnit(DependencyObject element);
+        public static bool GetIsContainerVirtualizable(DependencyObject element);
+        public static bool GetIsVirtualizing(DependencyObject element);
+        public static bool GetIsVirtualizingWhenGrouping(DependencyObject element);
+        public double GetItemOffset(UIElement child);
+        protected virtual double GetItemOffsetCore(UIElement child);
+        public static ScrollUnit GetScrollUnit(DependencyObject element);
+        public static VirtualizationMode GetVirtualizationMode(DependencyObject element);
+        protected void InsertInternalChild(int index, UIElement child);
+        protected virtual void OnClearChildren();
+        protected virtual void OnItemsChanged(object sender, ItemsChangedEventArgs args);
+        protected void RemoveInternalChildRange(int index, int range);
+        public static void SetCacheLength(DependencyObject element, VirtualizationCacheLength value);
+        public static void SetCacheLengthUnit(DependencyObject element, VirtualizationCacheLengthUnit value);
+        public static void SetIsContainerVirtualizable(DependencyObject element, bool value);
+        public static void SetIsVirtualizing(DependencyObject element, bool value);
+        public static void SetIsVirtualizingWhenGrouping(DependencyObject element, bool value);
+        public static void SetScrollUnit(DependencyObject element, ScrollUnit value);
+        public static void SetVirtualizationMode(DependencyObject element, VirtualizationMode value);
+        public bool ShouldItemsChangeAffectLayout(bool areItemChangesLocal, ItemsChangedEventArgs args);
+        protected virtual bool ShouldItemsChangeAffectLayoutCore(bool areItemChangesLocal, ItemsChangedEventArgs args);
+    }
+    public class VirtualizingStackPanel : VirtualizingPanel, IScrollInfo, IStackMeasure {
+        public static readonly new DependencyProperty IsVirtualizingProperty;
+        public static readonly DependencyProperty OrientationProperty;
+        public static readonly new DependencyProperty VirtualizationModeProperty;
+        public static readonly RoutedEvent CleanUpVirtualizedItemEvent;
+        public VirtualizingStackPanel();
+        protected override bool CanHierarchicallyScrollAndVirtualizeCore { get; }
+        public bool CanHorizontallyScroll { get; set; }
+        public bool CanVerticallyScroll { get; set; }
+        public double ExtentHeight { get; }
+        public double ExtentWidth { get; }
+        protected internal override bool HasLogicalOrientation { get; }
+        public double HorizontalOffset { get; }
+        protected internal override Orientation LogicalOrientation { get; }
+        public Orientation Orientation { get; set; }
+        public ScrollViewer ScrollOwner { get; set; }
+        public double VerticalOffset { get; }
+        public double ViewportHeight { get; }
+        public double ViewportWidth { get; }
+        public static void AddCleanUpVirtualizedItemHandler(DependencyObject element, CleanUpVirtualizedItemEventHandler handler);
+        protected override Size ArrangeOverride(Size arrangeSize);
+        protected internal override void BringIndexIntoView(int index);
+        protected override double GetItemOffsetCore(UIElement child);
+        public virtual void LineDown();
+        public virtual void LineLeft();
+        public virtual void LineRight();
+        public virtual void LineUp();
+        public Rect MakeVisible(Visual visual, Rect rectangle);
+        protected override Size MeasureOverride(Size constraint);
+        public virtual void MouseWheelDown();
+        public virtual void MouseWheelLeft();
+        public virtual void MouseWheelRight();
+        public virtual void MouseWheelUp();
+        protected virtual void OnCleanUpVirtualizedItem(CleanUpVirtualizedItemEventArgs e);
+        protected override void OnClearChildren();
+        protected override void OnItemsChanged(object sender, ItemsChangedEventArgs args);
+        protected virtual void OnViewportOffsetChanged(Vector oldViewportOffset, Vector newViewportOffset);
+        protected virtual void OnViewportSizeChanged(Size oldViewportSize, Size newViewportSize);
+        public virtual void PageDown();
+        public virtual void PageLeft();
+        public virtual void PageRight();
+        public virtual void PageUp();
+        public static void RemoveCleanUpVirtualizedItemHandler(DependencyObject element, CleanUpVirtualizedItemEventHandler handler);
+        public void SetHorizontalOffset(double offset);
+        public void SetVerticalOffset(double offset);
+        protected override bool ShouldItemsChangeAffectLayoutCore(bool areItemChangesLocal, ItemsChangedEventArgs args);
+    }
+    public sealed class WebBrowser : ActiveXHost {
+        public WebBrowser();
+        public bool CanGoBack { get; }
+        public bool CanGoForward { get; }
+        public object Document { get; }
+        public object ObjectForScripting { get; set; }
+        public Uri Source { get; set; }
+        public event LoadCompletedEventHandler LoadCompleted;
+        public event NavigatedEventHandler Navigated;
+        public event NavigatingCancelEventHandler Navigating;
+        public void GoBack();
+        public void GoForward();
+        public object InvokeScript(string scriptName);
+        public object InvokeScript(string scriptName, params object[] args);
+        public void Navigate(string source);
+        public void Navigate(string source, string targetFrameName, byte[] postData, string additionalHeaders);
+        public void Navigate(Uri source);
+        public void Navigate(Uri source, string targetFrameName, byte[] postData, string additionalHeaders);
+        public void NavigateToStream(Stream stream);
+        public void NavigateToString(string text);
+        public void Refresh();
+        public void Refresh(bool noCache);
+        protected override bool TabIntoCore(TraversalRequest request);
+        protected override bool TranslateAcceleratorCore(ref MSG msg, ModifierKeys modifiers);
+    }
+    public class WrapPanel : Panel {
+        public static readonly DependencyProperty ItemHeightProperty;
+        public static readonly DependencyProperty ItemWidthProperty;
+        public static readonly DependencyProperty OrientationProperty;
+        public WrapPanel();
+        public double ItemHeight { get; set; }
+        public double ItemWidth { get; set; }
+        public Orientation Orientation { get; set; }
+        protected override Size ArrangeOverride(Size finalSize);
+        protected override Size MeasureOverride(Size constraint);
+    }
+}
```

