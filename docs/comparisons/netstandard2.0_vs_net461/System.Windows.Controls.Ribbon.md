# System.Windows.Controls.Ribbon

``` diff
+namespace System.Windows.Controls.Ribbon {
+    public class Ribbon : Selector {
+        public static readonly DependencyProperty ApplicationMenuProperty;
+        public static readonly DependencyProperty CheckedBackgroundProperty;
+        public static readonly DependencyProperty CheckedBorderBrushProperty;
+        public static readonly DependencyProperty ContextualTabGroupHeaderTemplateProperty;
+        public static readonly DependencyProperty ContextualTabGroupsSourceProperty;
+        public static readonly DependencyProperty ContextualTabGroupStyleProperty;
+        public static readonly DependencyProperty FocusedBackgroundProperty;
+        public static readonly DependencyProperty FocusedBorderBrushProperty;
+        public static readonly DependencyProperty HelpPaneContentProperty;
+        public static readonly DependencyProperty HelpPaneContentTemplateProperty;
+        public static readonly DependencyProperty IsCollapsedProperty;
+        public static readonly DependencyProperty IsDropDownOpenProperty;
+        public static readonly DependencyProperty IsHostedInRibbonWindowProperty;
+        public static readonly DependencyProperty IsMinimizedProperty;
+        public static readonly DependencyProperty MouseOverBackgroundProperty;
+        public static readonly DependencyProperty MouseOverBorderBrushProperty;
+        public static readonly DependencyProperty PressedBackgroundProperty;
+        public static readonly DependencyProperty PressedBorderBrushProperty;
+        public static readonly DependencyProperty QuickAccessToolBarProperty;
+        public static readonly DependencyProperty ShowQuickAccessToolBarOnTopProperty;
+        public static readonly DependencyProperty TabHeaderStyleProperty;
+        public static readonly DependencyProperty TabHeaderTemplateProperty;
+        public static readonly DependencyProperty TitleProperty;
+        public static readonly DependencyProperty TitleTemplateProperty;
+        public static readonly DependencyProperty WindowIconVisibilityProperty;
+        public static readonly RoutedEvent CollapsedEvent;
+        public static readonly RoutedEvent ExpandedEvent;
+        public Ribbon();
+        public RibbonApplicationMenu ApplicationMenu { get; set; }
+        public Brush CheckedBackground { get; set; }
+        public Brush CheckedBorderBrush { get; set; }
+        public DataTemplate ContextualTabGroupHeaderTemplate { get; set; }
+        public Collection<RibbonContextualTabGroup> ContextualTabGroups { get; }
+        public IEnumerable ContextualTabGroupsSource { get; set; }
+        public Style ContextualTabGroupStyle { get; set; }
+        public Brush FocusedBackground { get; set; }
+        public Brush FocusedBorderBrush { get; set; }
+        public object HelpPaneContent { get; set; }
+        public DataTemplate HelpPaneContentTemplate { get; set; }
+        public bool IsCollapsed { get; set; }
+        public bool IsDropDownOpen { get; set; }
+        public bool IsHostedInRibbonWindow { get; private set; }
+        public bool IsMinimized { get; set; }
+        protected internal override IEnumerator LogicalChildren { get; }
+        public Brush MouseOverBackground { get; set; }
+        public Brush MouseOverBorderBrush { get; set; }
+        public Brush PressedBackground { get; set; }
+        public Brush PressedBorderBrush { get; set; }
+        public RibbonQuickAccessToolBar QuickAccessToolBar { get; set; }
+        public bool ShowQuickAccessToolBarOnTop { get; set; }
+        public Style TabHeaderStyle { get; set; }
+        public DataTemplate TabHeaderTemplate { get; set; }
+        public object Title { get; set; }
+        public DataTemplate TitleTemplate { get; set; }
+        public Visibility WindowIconVisibility { get; set; }
+        public event RoutedEventHandler Collapsed;
+        public event RoutedEventHandler Expanded;
+        protected override DependencyObject GetContainerForItemOverride();
+        protected override bool IsItemItsOwnContainerOverride(object item);
+        public override void OnApplyTemplate();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnItemsChanged(NotifyCollectionChangedEventArgs e);
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected override void OnMouseDown(MouseButtonEventArgs e);
+        protected override void OnPreviewMouseDown(MouseButtonEventArgs e);
+        protected override void OnPreviewMouseWheel(MouseWheelEventArgs e);
+        protected override void OnSelectionChanged(SelectionChangedEventArgs e);
+        protected override void PrepareContainerForItemOverride(DependencyObject element, object item);
+    }
+    public class RibbonApplicationMenu : RibbonMenuButton {
+        public static readonly DependencyProperty AuxiliaryPaneContentProperty;
+        public static readonly DependencyProperty AuxiliaryPaneContentTemplateProperty;
+        public static readonly DependencyProperty AuxiliaryPaneContentTemplateSelectorProperty;
+        public static readonly DependencyProperty FooterPaneContentProperty;
+        public static readonly DependencyProperty FooterPaneContentTemplateProperty;
+        public static readonly DependencyProperty FooterPaneContentTemplateSelectorProperty;
+        public RibbonApplicationMenu();
+        public object AuxiliaryPaneContent { get; set; }
+        public DataTemplate AuxiliaryPaneContentTemplate { get; set; }
+        public DataTemplateSelector AuxiliaryPaneContentTemplateSelector { get; set; }
+        public object FooterPaneContent { get; set; }
+        public DataTemplate FooterPaneContentTemplate { get; set; }
+        public DataTemplateSelector FooterPaneContentTemplateSelector { get; set; }
+        protected override DependencyObject GetContainerForItemOverride();
+        protected override bool IsItemItsOwnContainerOverride(object item);
+        protected override void OnActivatingKeyTip(ActivatingKeyTipEventArgs e);
+        public override void OnApplyTemplate();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnPreviewKeyDown(KeyEventArgs e);
+        protected override bool ShouldApplyItemContainerStyle(DependencyObject container, object item);
+    }
+    public class RibbonApplicationMenuItem : RibbonMenuItem {
+        public static readonly DependencyProperty LevelProperty;
+        public RibbonApplicationMenuItem();
+        public RibbonApplicationMenuItemLevel Level { get; internal set; }
+        protected override DependencyObject GetContainerForItemOverride();
+        protected override bool IsItemItsOwnContainerOverride(object item);
+        protected override void OnActivatingKeyTip(ActivatingKeyTipEventArgs e);
+        public override void OnApplyTemplate();
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected override void PrepareContainerForItemOverride(DependencyObject element, object item);
+        protected override bool ShouldApplyItemContainerStyle(DependencyObject container, object item);
+    }
+    public enum RibbonApplicationMenuItemLevel {
+        Middle = 1,
+        Sub = 2,
+        Top = 0,
+    }
+    public class RibbonApplicationSplitMenuItem : RibbonSplitMenuItem {
+        public static readonly DependencyProperty LevelProperty;
+        public RibbonApplicationSplitMenuItem();
+        public RibbonApplicationMenuItemLevel Level { get; internal set; }
+        protected override DependencyObject GetContainerForItemOverride();
+        protected override bool IsItemItsOwnContainerOverride(object item);
+        protected override void OnActivatingKeyTip(ActivatingKeyTipEventArgs e);
+        public override void OnApplyTemplate();
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected override void PrepareContainerForItemOverride(DependencyObject element, object item);
+        protected override bool ShouldApplyItemContainerStyle(DependencyObject container, object item);
+    }
+    public class RibbonButton : Button {
+        public static readonly DependencyProperty CanAddToQuickAccessToolBarDirectlyProperty;
+        public static readonly DependencyProperty ControlSizeDefinitionProperty;
+        public static readonly DependencyProperty CornerRadiusProperty;
+        public static readonly DependencyProperty FocusedBackgroundProperty;
+        public static readonly DependencyProperty FocusedBorderBrushProperty;
+        public static readonly DependencyProperty IsInControlGroupProperty;
+        public static readonly DependencyProperty IsInQuickAccessToolBarProperty;
+        public static readonly DependencyProperty KeyTipProperty;
+        public static readonly DependencyProperty LabelProperty;
+        public static readonly DependencyProperty LargeImageSourceProperty;
+        public static readonly DependencyProperty MouseOverBackgroundProperty;
+        public static readonly DependencyProperty MouseOverBorderBrushProperty;
+        public static readonly DependencyProperty PressedBackgroundProperty;
+        public static readonly DependencyProperty PressedBorderBrushProperty;
+        public static readonly DependencyProperty QuickAccessToolBarControlSizeDefinitionProperty;
+        public static readonly DependencyProperty QuickAccessToolBarIdProperty;
+        public static readonly DependencyProperty RibbonProperty;
+        public static readonly DependencyProperty ShowKeyboardCuesProperty;
+        public static readonly DependencyProperty SmallImageSourceProperty;
+        public static readonly DependencyProperty ToolTipDescriptionProperty;
+        public static readonly DependencyProperty ToolTipFooterDescriptionProperty;
+        public static readonly DependencyProperty ToolTipFooterImageSourceProperty;
+        public static readonly DependencyProperty ToolTipFooterTitleProperty;
+        public static readonly DependencyProperty ToolTipImageSourceProperty;
+        public static readonly DependencyProperty ToolTipTitleProperty;
+        public RibbonButton();
+        public bool CanAddToQuickAccessToolBarDirectly { get; set; }
+        public RibbonControlSizeDefinition ControlSizeDefinition { get; set; }
+        public CornerRadius CornerRadius { get; set; }
+        public Brush FocusedBackground { get; set; }
+        public Brush FocusedBorderBrush { get; set; }
+        public bool IsInControlGroup { get; internal set; }
+        public bool IsInQuickAccessToolBar { get; internal set; }
+        public string KeyTip { get; set; }
+        public string Label { get; set; }
+        public ImageSource LargeImageSource { get; set; }
+        public Brush MouseOverBackground { get; set; }
+        public Brush MouseOverBorderBrush { get; set; }
+        public Brush PressedBackground { get; set; }
+        public Brush PressedBorderBrush { get; set; }
+        public RibbonControlSizeDefinition QuickAccessToolBarControlSizeDefinition { get; set; }
+        public object QuickAccessToolBarId { get; set; }
+        public Ribbon Ribbon { get; }
+        public bool ShowKeyboardCues { get; }
+        public ImageSource SmallImageSource { get; set; }
+        public string ToolTipDescription { get; set; }
+        public string ToolTipFooterDescription { get; set; }
+        public ImageSource ToolTipFooterImageSource { get; set; }
+        public string ToolTipFooterTitle { get; set; }
+        public ImageSource ToolTipImageSource { get; set; }
+        public string ToolTipTitle { get; set; }
+        protected virtual void OnActivatingKeyTip(ActivatingKeyTipEventArgs e);
+        public override void OnApplyTemplate();
+        protected override void OnClick();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnGotKeyboardFocus(KeyboardFocusChangedEventArgs e);
+        protected virtual void OnKeyTipAccessed(KeyTipAccessedEventArgs e);
+        protected override void OnLostKeyboardFocus(KeyboardFocusChangedEventArgs e);
+        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e);
+    }
+    public class RibbonCheckBox : CheckBox {
+        public static readonly DependencyProperty CanAddToQuickAccessToolBarDirectlyProperty;
+        public static readonly DependencyProperty CheckedBackgroundProperty;
+        public static readonly DependencyProperty CheckedBorderBrushProperty;
+        public static readonly DependencyProperty ControlSizeDefinitionProperty;
+        public static readonly DependencyProperty FocusedBackgroundProperty;
+        public static readonly DependencyProperty FocusedBorderBrushProperty;
+        public static readonly DependencyProperty IsInControlGroupProperty;
+        public static readonly DependencyProperty IsInQuickAccessToolBarProperty;
+        public static readonly DependencyProperty KeyTipProperty;
+        public static readonly DependencyProperty LabelProperty;
+        public static readonly DependencyProperty LargeImageSourceProperty;
+        public static readonly DependencyProperty MouseOverBackgroundProperty;
+        public static readonly DependencyProperty MouseOverBorderBrushProperty;
+        public static readonly DependencyProperty PressedBackgroundProperty;
+        public static readonly DependencyProperty PressedBorderBrushProperty;
+        public static readonly DependencyProperty QuickAccessToolBarControlSizeDefinitionProperty;
+        public static readonly DependencyProperty QuickAccessToolBarIdProperty;
+        public static readonly DependencyProperty RibbonProperty;
+        public static readonly DependencyProperty ShowKeyboardCuesProperty;
+        public static readonly DependencyProperty SmallImageSourceProperty;
+        public static readonly DependencyProperty ToolTipDescriptionProperty;
+        public static readonly DependencyProperty ToolTipFooterDescriptionProperty;
+        public static readonly DependencyProperty ToolTipFooterImageSourceProperty;
+        public static readonly DependencyProperty ToolTipFooterTitleProperty;
+        public static readonly DependencyProperty ToolTipImageSourceProperty;
+        public static readonly DependencyProperty ToolTipTitleProperty;
+        public RibbonCheckBox();
+        public bool CanAddToQuickAccessToolBarDirectly { get; set; }
+        public Brush CheckedBackground { get; set; }
+        public Brush CheckedBorderBrush { get; set; }
+        public RibbonControlSizeDefinition ControlSizeDefinition { get; set; }
+        public Brush FocusedBackground { get; set; }
+        public Brush FocusedBorderBrush { get; set; }
+        public bool IsInControlGroup { get; internal set; }
+        public bool IsInQuickAccessToolBar { get; internal set; }
+        public string KeyTip { get; set; }
+        public string Label { get; set; }
+        public ImageSource LargeImageSource { get; set; }
+        public Brush MouseOverBackground { get; set; }
+        public Brush MouseOverBorderBrush { get; set; }
+        public Brush PressedBackground { get; set; }
+        public Brush PressedBorderBrush { get; set; }
+        public RibbonControlSizeDefinition QuickAccessToolBarControlSizeDefinition { get; set; }
+        public object QuickAccessToolBarId { get; set; }
+        public Ribbon Ribbon { get; }
+        public bool ShowKeyboardCues { get; }
+        public ImageSource SmallImageSource { get; set; }
+        public string ToolTipDescription { get; set; }
+        public string ToolTipFooterDescription { get; set; }
+        public ImageSource ToolTipFooterImageSource { get; set; }
+        public string ToolTipFooterTitle { get; set; }
+        public ImageSource ToolTipImageSource { get; set; }
+        public string ToolTipTitle { get; set; }
+        protected virtual void OnActivatingKeyTip(ActivatingKeyTipEventArgs e);
+        public override void OnApplyTemplate();
+        protected override void OnClick();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnGotKeyboardFocus(KeyboardFocusChangedEventArgs e);
+        protected virtual void OnKeyTipAccessed(KeyTipAccessedEventArgs e);
+        protected override void OnLostKeyboardFocus(KeyboardFocusChangedEventArgs e);
+        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e);
+    }
+    public class RibbonComboBox : RibbonMenuButton {
+        public static readonly DependencyProperty IsEditableProperty;
+        public static readonly DependencyProperty IsReadOnlyProperty;
+        public static readonly DependencyProperty SelectionBoxItemProperty;
+        public static readonly DependencyProperty SelectionBoxItemStringFormatProperty;
+        public static readonly DependencyProperty SelectionBoxItemTemplateProperty;
+        public static readonly DependencyProperty SelectionBoxItemTemplateSelectorProperty;
+        public static readonly DependencyProperty SelectionBoxWidthProperty;
+        public static readonly DependencyProperty ShowKeyboardCuesProperty;
+        public static readonly DependencyProperty StaysOpenOnEditProperty;
+        public static readonly DependencyProperty TextProperty;
+        public RibbonComboBox();
+        public bool IsEditable { get; set; }
+        public bool IsReadOnly { get; set; }
+        public object SelectionBoxItem { get; private set; }
+        public string SelectionBoxItemStringFormat { get; private set; }
+        public DataTemplate SelectionBoxItemTemplate { get; private set; }
+        public DataTemplateSelector SelectionBoxItemTemplateSelector { get; private set; }
+        public double SelectionBoxWidth { get; set; }
+        public bool ShowKeyboardCues { get; }
+        public bool StaysOpenOnEdit { get; set; }
+        public string Text { get; set; }
+        protected override void ClearContainerForItemOverride(DependencyObject element, object item);
+        protected override void OnActivatingKeyTip(ActivatingKeyTipEventArgs e);
+        public override void OnApplyTemplate();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnGotKeyboardFocus(KeyboardFocusChangedEventArgs e);
+        protected override void OnIsKeyboardFocusWithinChanged(DependencyPropertyChangedEventArgs e);
+        protected override void OnItemsChanged(NotifyCollectionChangedEventArgs e);
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected override void OnKeyTipAccessed(KeyTipAccessedEventArgs e);
+        protected override void OnKeyUp(KeyEventArgs e);
+        protected override void OnLostKeyboardFocus(KeyboardFocusChangedEventArgs e);
+        protected override void OnPreviewKeyDown(KeyEventArgs e);
+        protected override void OnPreviewMouseDown(MouseButtonEventArgs e);
+        protected override void OnTextInput(TextCompositionEventArgs e);
+        protected override void PrepareContainerForItemOverride(DependencyObject element, object item);
+    }
+    public static class RibbonCommands {
+        public static RoutedUICommand AddToQuickAccessToolBarCommand { get; private set; }
+        public static RoutedUICommand MaximizeRibbonCommand { get; private set; }
+        public static RoutedUICommand MinimizeRibbonCommand { get; private set; }
+        public static RoutedUICommand RemoveFromQuickAccessToolBarCommand { get; private set; }
+        public static RoutedUICommand ShowQuickAccessToolBarAboveRibbonCommand { get; private set; }
+        public static RoutedUICommand ShowQuickAccessToolBarBelowRibbonCommand { get; private set; }
+    }
+    public class RibbonContentPresenter : ContentPresenter {
+        public static readonly DependencyProperty ControlSizeDefinitionProperty;
+        public static readonly DependencyProperty IsInControlGroupProperty;
+        public static readonly DependencyProperty IsInQuickAccessToolBarProperty;
+        public RibbonContentPresenter();
+        public RibbonControlSizeDefinition ControlSizeDefinition { get; set; }
+        public bool IsInControlGroup { get; internal set; }
+        public bool IsInQuickAccessToolBar { get; internal set; }
+        public override void OnApplyTemplate();
+        protected override void OnTemplateChanged(DataTemplate oldTemplate, DataTemplate newTemplate);
+    }
+    public class RibbonContextMenu : ContextMenu {
+        public static readonly DependencyProperty HasGalleryProperty;
+        public RibbonContextMenu();
+        public bool HasGallery { get; private set; }
+        protected override void ClearContainerForItemOverride(DependencyObject element, object item);
+        protected override DependencyObject GetContainerForItemOverride();
+        protected override bool IsItemItsOwnContainerOverride(object item);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected override void PrepareContainerForItemOverride(DependencyObject element, object item);
+        protected override bool ShouldApplyItemContainerStyle(DependencyObject container, object item);
+    }
+    public class RibbonContextualTabGroup : Control {
+        public static readonly DependencyProperty HeaderProperty;
+        public static readonly DependencyProperty HeaderStringFormatProperty;
+        public static readonly DependencyProperty HeaderTemplateProperty;
+        public static readonly DependencyProperty HeaderTemplateSelectorProperty;
+        public static readonly DependencyProperty RibbonProperty;
+        public RibbonContextualTabGroup();
+        public object Header { get; set; }
+        public string HeaderStringFormat { get; set; }
+        public DataTemplate HeaderTemplate { get; set; }
+        public DataTemplateSelector HeaderTemplateSelector { get; set; }
+        public Ribbon Ribbon { get; }
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected virtual void OnHeaderChanged(object oldHeader, object newHeader);
+        protected override void OnMouseDown(MouseButtonEventArgs e);
+        protected override void OnMouseUp(MouseButtonEventArgs e);
+    }
+    public class RibbonContextualTabGroupItemsControl : ItemsControl {
+        public static readonly DependencyProperty RibbonProperty;
+        public RibbonContextualTabGroupItemsControl();
+        public Ribbon Ribbon { get; }
+        protected override void ClearContainerForItemOverride(DependencyObject element, object item);
+        protected override DependencyObject GetContainerForItemOverride();
+        protected override bool IsItemItsOwnContainerOverride(object item);
+        public override void OnApplyTemplate();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void PrepareContainerForItemOverride(DependencyObject element, object item);
+    }
+    public class RibbonControl : ContentControl {
+        public static readonly DependencyProperty ControlSizeDefinitionProperty;
+        public static readonly DependencyProperty IsInControlGroupProperty;
+        public static readonly DependencyProperty IsInQuickAccessToolBarProperty;
+        public RibbonControl();
+        public RibbonControlSizeDefinition ControlSizeDefinition { get; set; }
+        public bool IsInControlGroup { get; internal set; }
+        public bool IsInQuickAccessToolBar { get; internal set; }
+        public override void OnApplyTemplate();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnTemplateChanged(ControlTemplate oldTemplate, ControlTemplate newTemplate);
+    }
+    public class RibbonControlGroup : ItemsControl {
+        public static readonly DependencyProperty ControlSizeDefinitionProperty;
+        public static readonly DependencyProperty RibbonProperty;
+        public RibbonControlGroup();
+        public RibbonControlSizeDefinition ControlSizeDefinition { get; set; }
+        public Ribbon Ribbon { get; }
+        protected override void ClearContainerForItemOverride(DependencyObject element, object item);
+        protected override DependencyObject GetContainerForItemOverride();
+        protected override bool IsItemItsOwnContainerOverride(object item);
+        public override void OnApplyTemplate();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void PrepareContainerForItemOverride(DependencyObject element, object item);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct RibbonControlLength : IEquatable<RibbonControlLength> {
+        public RibbonControlLength(double pixels);
+        public RibbonControlLength(double value, RibbonControlLengthUnitType type);
+        public static RibbonControlLength Auto { get; }
+        public bool IsAbsolute { get; }
+        public bool IsAuto { get; }
+        public bool IsStar { get; }
+        public RibbonControlLengthUnitType RibbonControlLengthUnitType { get; }
+        public double Value { get; }
+        public override bool Equals(object obj);
+        public bool Equals(RibbonControlLength other);
+        public override int GetHashCode();
+        public static bool operator ==(RibbonControlLength length1, RibbonControlLength length2);
+        public static bool operator !=(RibbonControlLength length1, RibbonControlLength length2);
+        public override string ToString();
+    }
+    public class RibbonControlLengthConverter : TypeConverter {
+        public RibbonControlLengthConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public enum RibbonControlLengthUnitType {
+        Auto = 0,
+        Item = 2,
+        Pixel = 1,
+        Star = 3,
+    }
+    public static class RibbonControlService {
+        public static readonly DependencyProperty CanAddToQuickAccessToolBarDirectlyProperty;
+        public static readonly DependencyProperty CheckedBackgroundProperty;
+        public static readonly DependencyProperty CheckedBorderBrushProperty;
+        public static readonly DependencyProperty ControlSizeDefinitionProperty;
+        public static readonly DependencyProperty CornerRadiusProperty;
+        public static readonly DependencyProperty DefaultControlSizeDefinitionProperty;
+        public static readonly DependencyProperty FocusedBackgroundProperty;
+        public static readonly DependencyProperty FocusedBorderBrushProperty;
+        public static readonly DependencyProperty IsInControlGroupProperty;
+        public static readonly DependencyProperty IsInQuickAccessToolBarProperty;
+        public static readonly DependencyProperty LabelProperty;
+        public static readonly DependencyProperty LargeImageSourceProperty;
+        public static readonly DependencyProperty MouseOverBackgroundProperty;
+        public static readonly DependencyProperty MouseOverBorderBrushProperty;
+        public static readonly DependencyProperty PressedBackgroundProperty;
+        public static readonly DependencyProperty PressedBorderBrushProperty;
+        public static readonly DependencyProperty QuickAccessToolBarControlSizeDefinitionProperty;
+        public static readonly DependencyProperty QuickAccessToolBarIdProperty;
+        public static readonly DependencyProperty RibbonProperty;
+        public static readonly DependencyProperty ShowKeyboardCuesProperty;
+        public static readonly DependencyProperty SmallImageSourceProperty;
+        public static readonly DependencyProperty ToolTipDescriptionProperty;
+        public static readonly DependencyProperty ToolTipFooterDescriptionProperty;
+        public static readonly DependencyProperty ToolTipFooterImageSourceProperty;
+        public static readonly DependencyProperty ToolTipFooterTitleProperty;
+        public static readonly DependencyProperty ToolTipImageSourceProperty;
+        public static readonly DependencyProperty ToolTipTitleProperty;
+        public static readonly RoutedEvent DismissPopupEvent;
+        public static void AddDismissPopupHandler(DependencyObject element, RibbonDismissPopupEventHandler handler);
+        public static bool GetCanAddToQuickAccessToolBarDirectly(DependencyObject element);
+        public static Brush GetCheckedBackground(DependencyObject element);
+        public static Brush GetCheckedBorderBrush(DependencyObject element);
+        public static RibbonControlSizeDefinition GetControlSizeDefinition(DependencyObject element);
+        public static CornerRadius GetCornerRadius(DependencyObject element);
+        public static RibbonControlSizeDefinition GetDefaultControlSizeDefinition(DependencyObject element);
+        public static Brush GetFocusedBackground(DependencyObject element);
+        public static Brush GetFocusedBorderBrush(DependencyObject element);
+        public static bool GetIsInControlGroup(DependencyObject element);
+        public static bool GetIsInQuickAccessToolBar(DependencyObject element);
+        public static string GetLabel(DependencyObject element);
+        public static ImageSource GetLargeImageSource(DependencyObject element);
+        public static Brush GetMouseOverBackground(DependencyObject element);
+        public static Brush GetMouseOverBorderBrush(DependencyObject element);
+        public static Brush GetPressedBackground(DependencyObject element);
+        public static Brush GetPressedBorderBrush(DependencyObject element);
+        public static RibbonControlSizeDefinition GetQuickAccessToolBarControlSizeDefinition(DependencyObject element);
+        public static object GetQuickAccessToolBarId(DependencyObject element);
+        public static Ribbon GetRibbon(DependencyObject element);
+        public static bool GetShowKeyboardCues(DependencyObject element);
+        public static ImageSource GetSmallImageSource(DependencyObject element);
+        public static string GetToolTipDescription(DependencyObject element);
+        public static string GetToolTipFooterDescription(DependencyObject element);
+        public static ImageSource GetToolTipFooterImageSource(DependencyObject element);
+        public static string GetToolTipFooterTitle(DependencyObject element);
+        public static ImageSource GetToolTipImageSource(DependencyObject element);
+        public static string GetToolTipTitle(DependencyObject element);
+        public static void RemoveDismissPopupHandler(DependencyObject element, RibbonDismissPopupEventHandler handler);
+        public static void SetCanAddToQuickAccessToolBarDirectly(DependencyObject element, bool value);
+        public static void SetCheckedBackground(DependencyObject element, Brush value);
+        public static void SetCheckedBorderBrush(DependencyObject element, Brush value);
+        public static void SetControlSizeDefinition(DependencyObject element, RibbonControlSizeDefinition value);
+        public static void SetCornerRadius(DependencyObject element, CornerRadius value);
+        public static void SetDefaultControlSizeDefinition(DependencyObject element, RibbonControlSizeDefinition value);
+        public static void SetFocusedBackground(DependencyObject element, Brush value);
+        public static void SetFocusedBorderBrush(DependencyObject element, Brush value);
+        public static void SetLabel(DependencyObject element, string value);
+        public static void SetLargeImageSource(DependencyObject element, ImageSource value);
+        public static void SetMouseOverBackground(DependencyObject element, Brush value);
+        public static void SetMouseOverBorderBrush(DependencyObject element, Brush value);
+        public static void SetPressedBackground(DependencyObject element, Brush value);
+        public static void SetPressedBorderBrush(DependencyObject element, Brush value);
+        public static void SetQuickAccessToolBarControlSizeDefinition(DependencyObject element, RibbonControlSizeDefinition value);
+        public static void SetQuickAccessToolBarId(DependencyObject element, object value);
+        public static void SetSmallImageSource(DependencyObject element, ImageSource value);
+        public static void SetToolTipDescription(DependencyObject element, string value);
+        public static void SetToolTipFooterDescription(DependencyObject element, string value);
+        public static void SetToolTipFooterImageSource(DependencyObject element, ImageSource value);
+        public static void SetToolTipFooterTitle(DependencyObject element, string value);
+        public static void SetToolTipImageSource(DependencyObject element, ImageSource value);
+        public static void SetToolTipTitle(DependencyObject element, string value);
+    }
+    public class RibbonControlSizeDefinition : Freezable {
+        public static readonly DependencyProperty ImageSizeProperty;
+        public static readonly DependencyProperty IsCollapsedProperty;
+        public static readonly DependencyProperty IsLabelVisibleProperty;
+        public static readonly DependencyProperty MaxWidthProperty;
+        public static readonly DependencyProperty MinWidthProperty;
+        public static readonly DependencyProperty WidthProperty;
+        public RibbonControlSizeDefinition();
+        public RibbonImageSize ImageSize { get; set; }
+        public bool IsCollapsed { get; set; }
+        public bool IsLabelVisible { get; set; }
+        public RibbonControlLength MaxWidth { get; set; }
+        public RibbonControlLength MinWidth { get; set; }
+        public RibbonControlLength Width { get; set; }
+        protected override Freezable CreateInstanceCore();
+    }
+    public class RibbonControlSizeDefinitionCollection : FreezableCollection<RibbonControlSizeDefinition> {
+        public RibbonControlSizeDefinitionCollection();
+        protected override Freezable CreateInstanceCore();
+    }
+    public class RibbonDismissPopupEventArgs : RoutedEventArgs {
+        public RibbonDismissPopupEventArgs();
+        public RibbonDismissPopupEventArgs(RibbonDismissPopupMode dismissMode);
+        public RibbonDismissPopupMode DismissMode { get; private set; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void RibbonDismissPopupEventHandler(object sender, RibbonDismissPopupEventArgs e);
+    public enum RibbonDismissPopupMode {
+        Always = 0,
+        MousePhysicallyNotOver = 1,
+    }
+    public class RibbonFilterMenuButton : RibbonMenuButton {
+        public RibbonFilterMenuButton();
+        protected override void OnActivatingKeyTip(ActivatingKeyTipEventArgs e);
+        public override void OnApplyTemplate();
+        protected override void OnDismissPopup(RibbonDismissPopupEventArgs e);
+    }
+    public class RibbonGallery : ItemsControl, ICommandSource, IPreviewCommandSource, IWeakEventListener {
+        public static readonly DependencyProperty AllFilterItemContainerStyleProperty;
+        public static readonly DependencyProperty AllFilterItemTemplateProperty;
+        public static readonly DependencyProperty CanAddToQuickAccessToolBarDirectlyProperty;
+        public static readonly DependencyProperty CanUserFilterProperty;
+        public static readonly DependencyProperty CategoryStyleProperty;
+        public static readonly DependencyProperty CategoryTemplateProperty;
+        public static readonly DependencyProperty ColumnsStretchToFillProperty;
+        public static readonly DependencyProperty CommandParameterProperty;
+        public static readonly DependencyProperty CommandProperty;
+        public static readonly DependencyProperty CommandTargetProperty;
+        public static readonly DependencyProperty FilterItemContainerStyleProperty;
+        public static readonly DependencyProperty FilterItemContainerStyleSelectorProperty;
+        public static readonly DependencyProperty FilterItemTemplateProperty;
+        public static readonly DependencyProperty FilterItemTemplateSelectorProperty;
+        public static readonly DependencyProperty FilterMenuButtonStyleProperty;
+        public static readonly DependencyProperty FilterPaneContentProperty;
+        public static readonly DependencyProperty FilterPaneContentTemplateProperty;
+        public static readonly DependencyProperty GalleryItemStyleProperty;
+        public static readonly DependencyProperty GalleryItemTemplateProperty;
+        public static readonly DependencyProperty HighlightedItemProperty;
+        public static readonly DependencyProperty IsSharedColumnSizeScopeProperty;
+        public static readonly DependencyProperty IsSynchronizedWithCurrentItemProperty;
+        public static readonly DependencyProperty MaxColumnCountProperty;
+        public static readonly DependencyProperty MinColumnCountProperty;
+        public static readonly DependencyProperty PreviewCommandParameterProperty;
+        public static readonly DependencyProperty QuickAccessToolBarIdProperty;
+        public static readonly DependencyProperty RibbonProperty;
+        public static readonly DependencyProperty SelectedItemProperty;
+        public static readonly DependencyProperty SelectedValuePathProperty;
+        public static readonly DependencyProperty SelectedValueProperty;
+        public static readonly DependencyProperty SmallImageSourceProperty;
+        public static readonly DependencyProperty ToolTipDescriptionProperty;
+        public static readonly DependencyProperty ToolTipFooterDescriptionProperty;
+        public static readonly DependencyProperty ToolTipFooterImageSourceProperty;
+        public static readonly DependencyProperty ToolTipFooterTitleProperty;
+        public static readonly DependencyProperty ToolTipImageSourceProperty;
+        public static readonly DependencyProperty ToolTipTitleProperty;
+        public static readonly RoutedEvent SelectionChangedEvent;
+        public RibbonGallery();
+        public static object AllFilterItem { get; }
+        public Style AllFilterItemContainerStyle { get; set; }
+        public DataTemplate AllFilterItemTemplate { get; set; }
+        public bool CanAddToQuickAccessToolBarDirectly { get; set; }
+        public bool CanUserFilter { get; set; }
+        public Style CategoryStyle { get; set; }
+        public DataTemplate CategoryTemplate { get; set; }
+        public bool ColumnsStretchToFill { get; set; }
+        public ICommand Command { get; set; }
+        public object CommandParameter { get; set; }
+        public IInputElement CommandTarget { get; set; }
+        public static RoutedCommand FilterCommand { get; private set; }
+        public Style FilterItemContainerStyle { get; set; }
+        public StyleSelector FilterItemContainerStyleSelector { get; set; }
+        public DataTemplate FilterItemTemplate { get; set; }
+        public DataTemplateSelector FilterItemTemplateSelector { get; set; }
+        public Style FilterMenuButtonStyle { get; set; }
+        public object FilterPaneContent { get; set; }
+        public DataTemplate FilterPaneContentTemplate { get; set; }
+        public Style GalleryItemStyle { get; set; }
+        public DataTemplate GalleryItemTemplate { get; set; }
+        public object HighlightedItem { get; internal set; }
+        protected override bool IsEnabledCore { get; }
+        public bool IsSharedColumnSizeScope { get; set; }
+        public Nullable<bool> IsSynchronizedWithCurrentItem { get; set; }
+        public int MaxColumnCount { get; set; }
+        public int MinColumnCount { get; set; }
+        public object PreviewCommandParameter { get; set; }
+        public object QuickAccessToolBarId { get; set; }
+        public Ribbon Ribbon { get; }
+        public object SelectedItem { get; set; }
+        public object SelectedValue { get; set; }
+        public string SelectedValuePath { get; set; }
+        public ImageSource SmallImageSource { get; set; }
+        public string ToolTipDescription { get; set; }
+        public string ToolTipFooterDescription { get; set; }
+        public ImageSource ToolTipFooterImageSource { get; set; }
+        public string ToolTipFooterTitle { get; set; }
+        public ImageSource ToolTipImageSource { get; set; }
+        public string ToolTipTitle { get; set; }
+        public event RoutedPropertyChangedEventHandler<object> SelectionChanged;
+        protected override void ClearContainerForItemOverride(DependencyObject element, object item);
+        protected override DependencyObject GetContainerForItemOverride();
+        protected override bool IsItemItsOwnContainerOverride(object item);
+        public override void OnApplyTemplate();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected virtual void OnHighlightedItemChanged(DependencyPropertyChangedEventArgs e);
+        protected override void OnInitialized(EventArgs e);
+        protected override void OnIsKeyboardFocusWithinChanged(DependencyPropertyChangedEventArgs e);
+        protected override void OnItemsChanged(NotifyCollectionChangedEventArgs e);
+        protected override void OnItemsSourceChanged(IEnumerable oldValue, IEnumerable newValue);
+        protected override void OnMouseEnter(MouseEventArgs e);
+        protected override void OnMouseLeave(MouseEventArgs e);
+        protected override void OnPreviewKeyDown(KeyEventArgs e);
+        protected virtual void OnSelectionChanged(RoutedPropertyChangedEventArgs<object> e);
+        protected override void PrepareContainerForItemOverride(DependencyObject element, object item);
+        public void ScrollIntoView(object item);
+        bool System.Windows.IWeakEventListener.ReceiveWeakEvent(Type managerType, object sender, EventArgs e);
+    }
+    public class RibbonGalleryCategory : HeaderedItemsControl, IWeakEventListener {
+        public static readonly DependencyProperty ColumnsStretchToFillProperty;
+        public static readonly DependencyProperty HeaderVisibilityProperty;
+        public static readonly DependencyProperty IsSharedColumnSizeScopeProperty;
+        public static readonly DependencyProperty MaxColumnCountProperty;
+        public static readonly DependencyProperty MinColumnCountProperty;
+        public RibbonGalleryCategory();
+        public bool ColumnsStretchToFill { get; set; }
+        public Visibility HeaderVisibility { get; set; }
+        public bool IsSharedColumnSizeScope { get; set; }
+        public int MaxColumnCount { get; set; }
+        public int MinColumnCount { get; set; }
+        protected override void ClearContainerForItemOverride(DependencyObject element, object item);
+        protected override DependencyObject GetContainerForItemOverride();
+        protected override bool IsItemItsOwnContainerOverride(object item);
+        public override void OnApplyTemplate();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnInitialized(EventArgs e);
+        protected override void OnItemsChanged(NotifyCollectionChangedEventArgs e);
+        protected override void OnItemsSourceChanged(IEnumerable oldValue, IEnumerable newValue);
+        protected override void PrepareContainerForItemOverride(DependencyObject element, object item);
+        bool System.Windows.IWeakEventListener.ReceiveWeakEvent(Type managerType, object sender, EventArgs e);
+    }
+    public class RibbonGalleryItem : ContentControl {
+        public static readonly DependencyProperty CheckedBackgroundProperty;
+        public static readonly DependencyProperty CheckedBorderBrushProperty;
+        public static readonly DependencyProperty IsHighlightedProperty;
+        public static readonly DependencyProperty IsPressedProperty;
+        public static readonly DependencyProperty IsSelectedProperty;
+        public static readonly DependencyProperty KeyTipProperty;
+        public static readonly DependencyProperty MouseOverBackgroundProperty;
+        public static readonly DependencyProperty MouseOverBorderBrushProperty;
+        public static readonly DependencyProperty PressedBackgroundProperty;
+        public static readonly DependencyProperty PressedBorderBrushProperty;
+        public static readonly DependencyProperty RibbonProperty;
+        public static readonly DependencyProperty ToolTipDescriptionProperty;
+        public static readonly DependencyProperty ToolTipFooterDescriptionProperty;
+        public static readonly DependencyProperty ToolTipFooterImageSourceProperty;
+        public static readonly DependencyProperty ToolTipFooterTitleProperty;
+        public static readonly DependencyProperty ToolTipImageSourceProperty;
+        public static readonly DependencyProperty ToolTipTitleProperty;
+        public static readonly RoutedEvent SelectedEvent;
+        public static readonly RoutedEvent UnselectedEvent;
+        public RibbonGalleryItem();
+        public Brush CheckedBackground { get; set; }
+        public Brush CheckedBorderBrush { get; set; }
+        public bool IsHighlighted { get; internal set; }
+        public bool IsPressed { get; private set; }
+        public bool IsSelected { get; set; }
+        public string KeyTip { get; set; }
+        public Brush MouseOverBackground { get; set; }
+        public Brush MouseOverBorderBrush { get; set; }
+        public Brush PressedBackground { get; set; }
+        public Brush PressedBorderBrush { get; set; }
+        public Ribbon Ribbon { get; }
+        public string ToolTipDescription { get; set; }
+        public string ToolTipFooterDescription { get; set; }
+        public ImageSource ToolTipFooterImageSource { get; set; }
+        public string ToolTipFooterTitle { get; set; }
+        public ImageSource ToolTipImageSource { get; set; }
+        public string ToolTipTitle { get; set; }
+        public event RoutedEventHandler Selected;
+        public event RoutedEventHandler Unselected;
+        protected virtual void OnActivatingKeyTip(ActivatingKeyTipEventArgs e);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnGotKeyboardFocus(KeyboardFocusChangedEventArgs e);
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected virtual void OnKeyTipAccessed(KeyTipAccessedEventArgs e);
+        protected override void OnKeyUp(KeyEventArgs e);
+        protected override void OnLostKeyboardFocus(KeyboardFocusChangedEventArgs e);
+        protected override void OnMouseLeave(MouseEventArgs e);
+        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e);
+        protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e);
+        protected override void OnMouseMove(MouseEventArgs e);
+        protected internal virtual void OnSelected(RoutedEventArgs e);
+        protected internal virtual void OnUnselected(RoutedEventArgs e);
+    }
+    public class RibbonGroup : HeaderedItemsControl {
+        public static readonly DependencyProperty CanAddToQuickAccessToolBarDirectlyProperty;
+        public static readonly DependencyProperty GroupSizeDefinitionsProperty;
+        public static readonly DependencyProperty IsCollapsedProperty;
+        public static readonly DependencyProperty IsDropDownOpenProperty;
+        public static readonly DependencyProperty IsInQuickAccessToolBarProperty;
+        public static readonly DependencyProperty KeyTipProperty;
+        public static readonly DependencyProperty LargeImageSourceProperty;
+        public static readonly DependencyProperty MouseOverBackgroundProperty;
+        public static readonly DependencyProperty MouseOverBorderBrushProperty;
+        public static readonly DependencyProperty QuickAccessToolBarIdProperty;
+        public static readonly DependencyProperty RibbonProperty;
+        public static readonly DependencyProperty SmallImageSourceProperty;
+        public static readonly DependencyProperty ToolTipDescriptionProperty;
+        public static readonly DependencyProperty ToolTipFooterDescriptionProperty;
+        public static readonly DependencyProperty ToolTipFooterImageSourceProperty;
+        public static readonly DependencyProperty ToolTipFooterTitleProperty;
+        public static readonly DependencyProperty ToolTipImageSourceProperty;
+        public static readonly DependencyProperty ToolTipTitleProperty;
+        public RibbonGroup();
+        public bool CanAddToQuickAccessToolBarDirectly { get; set; }
+        public RibbonGroupSizeDefinitionBaseCollection GroupSizeDefinitions { get; set; }
+        public bool IsCollapsed { get; internal set; }
+        public bool IsDropDownOpen { get; set; }
+        public bool IsInQuickAccessToolBar { get; internal set; }
+        public string KeyTip { get; set; }
+        public ImageSource LargeImageSource { get; set; }
+        public Brush MouseOverBackground { get; set; }
+        public Brush MouseOverBorderBrush { get; set; }
+        public object QuickAccessToolBarId { get; set; }
+        public Ribbon Ribbon { get; }
+        public ImageSource SmallImageSource { get; set; }
+        public string ToolTipDescription { get; set; }
+        public string ToolTipFooterDescription { get; set; }
+        public ImageSource ToolTipFooterImageSource { get; set; }
+        public string ToolTipFooterTitle { get; set; }
+        public ImageSource ToolTipImageSource { get; set; }
+        public string ToolTipTitle { get; set; }
+        protected override void ClearContainerForItemOverride(DependencyObject element, object item);
+        protected override DependencyObject GetContainerForItemOverride();
+        protected override bool IsItemItsOwnContainerOverride(object item);
+        protected override Size MeasureOverride(Size availableSize);
+        protected virtual void OnActivatingKeyTip(ActivatingKeyTipEventArgs e);
+        public override void OnApplyTemplate();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnItemsChanged(NotifyCollectionChangedEventArgs e);
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected virtual void OnKeyTipAccessed(KeyTipAccessedEventArgs e);
+        protected override void OnMouseEnter(MouseEventArgs e);
+        protected override void OnMouseLeave(MouseEventArgs e);
+        protected override void OnPreviewMouseDown(MouseButtonEventArgs e);
+        protected internal override void OnRenderSizeChanged(SizeChangedInfo info);
+        protected override void PrepareContainerForItemOverride(DependencyObject element, object item);
+    }
+    public class RibbonGroupSizeDefinition : RibbonGroupSizeDefinitionBase {
+        public static readonly DependencyProperty ControlSizeDefinitionsProperty;
+        public RibbonGroupSizeDefinition();
+        public RibbonControlSizeDefinitionCollection ControlSizeDefinitions { get; set; }
+        protected override Freezable CreateInstanceCore();
+    }
+    public abstract class RibbonGroupSizeDefinitionBase : Freezable {
+        public static readonly DependencyProperty IsCollapsedProperty;
+        protected RibbonGroupSizeDefinitionBase();
+        public bool IsCollapsed { get; set; }
+    }
+    public class RibbonGroupSizeDefinitionBaseCollection : FreezableCollection<RibbonGroupSizeDefinitionBase> {
+        public RibbonGroupSizeDefinitionBaseCollection();
+        protected override Freezable CreateInstanceCore();
+    }
+    public class RibbonGroupTemplateSizeDefinition : RibbonGroupSizeDefinitionBase {
+        public static readonly DependencyProperty ContentTemplateProperty;
+        public RibbonGroupTemplateSizeDefinition();
+        public DataTemplate ContentTemplate { get; set; }
+        protected override Freezable CreateInstanceCore();
+    }
+    public enum RibbonImageSize {
+        Collapsed = 0,
+        Large = 2,
+        Small = 1,
+    }
+    public class RibbonMenuButton : Menu {
+        public static readonly DependencyProperty CanAddToQuickAccessToolBarDirectlyProperty;
+        public static readonly DependencyProperty CanUserResizeHorizontallyProperty;
+        public static readonly DependencyProperty CanUserResizeVerticallyProperty;
+        public static readonly DependencyProperty ControlSizeDefinitionProperty;
+        public static readonly DependencyProperty DropDownHeightProperty;
+        public static readonly DependencyProperty FocusedBackgroundProperty;
+        public static readonly DependencyProperty FocusedBorderBrushProperty;
+        public static readonly DependencyProperty HasGalleryProperty;
+        public static readonly DependencyProperty IsDropDownOpenProperty;
+        public static readonly DependencyProperty IsDropDownPositionedAboveProperty;
+        public static readonly DependencyProperty IsInControlGroupProperty;
+        public static readonly DependencyProperty IsInQuickAccessToolBarProperty;
+        public static readonly DependencyProperty KeyTipProperty;
+        public static readonly DependencyProperty LabelProperty;
+        public static readonly DependencyProperty LargeImageSourceProperty;
+        public static readonly DependencyProperty MouseOverBackgroundProperty;
+        public static readonly DependencyProperty MouseOverBorderBrushProperty;
+        public static readonly DependencyProperty PressedBackgroundProperty;
+        public static readonly DependencyProperty PressedBorderBrushProperty;
+        public static readonly DependencyProperty QuickAccessToolBarControlSizeDefinitionProperty;
+        public static readonly DependencyProperty QuickAccessToolBarIdProperty;
+        public static readonly DependencyProperty RibbonProperty;
+        public static readonly DependencyProperty SmallImageSourceProperty;
+        public static readonly DependencyProperty ToolTipDescriptionProperty;
+        public static readonly DependencyProperty ToolTipFooterDescriptionProperty;
+        public static readonly DependencyProperty ToolTipFooterImageSourceProperty;
+        public static readonly DependencyProperty ToolTipFooterTitleProperty;
+        public static readonly DependencyProperty ToolTipImageSourceProperty;
+        public static readonly DependencyProperty ToolTipTitleProperty;
+        public RibbonMenuButton();
+        public bool CanAddToQuickAccessToolBarDirectly { get; set; }
+        public bool CanUserResizeHorizontally { get; set; }
+        public bool CanUserResizeVertically { get; set; }
+        public RibbonControlSizeDefinition ControlSizeDefinition { get; set; }
+        public double DropDownHeight { get; set; }
+        public Brush FocusedBackground { get; set; }
+        public Brush FocusedBorderBrush { get; set; }
+        protected internal override bool HandlesScrolling { get; }
+        public bool HasGallery { get; private set; }
+        public bool IsDropDownOpen { get; set; }
+        public bool IsDropDownPositionedAbove { get; private set; }
+        public bool IsInControlGroup { get; internal set; }
+        public bool IsInQuickAccessToolBar { get; internal set; }
+        public string KeyTip { get; set; }
+        public string Label { get; set; }
+        public ImageSource LargeImageSource { get; set; }
+        public Brush MouseOverBackground { get; set; }
+        public Brush MouseOverBorderBrush { get; set; }
+        public Brush PressedBackground { get; set; }
+        public Brush PressedBorderBrush { get; set; }
+        public RibbonControlSizeDefinition QuickAccessToolBarControlSizeDefinition { get; set; }
+        public object QuickAccessToolBarId { get; set; }
+        public Ribbon Ribbon { get; }
+        public ImageSource SmallImageSource { get; set; }
+        public string ToolTipDescription { get; set; }
+        public string ToolTipFooterDescription { get; set; }
+        public ImageSource ToolTipFooterImageSource { get; set; }
+        public string ToolTipFooterTitle { get; set; }
+        public ImageSource ToolTipImageSource { get; set; }
+        public string ToolTipTitle { get; set; }
+        public event EventHandler DropDownClosed;
+        public event EventHandler DropDownOpened;
+        protected override void ClearContainerForItemOverride(DependencyObject element, object item);
+        protected override DependencyObject GetContainerForItemOverride();
+        protected override void HandleMouseButton(MouseButtonEventArgs e);
+        protected override bool IsItemItsOwnContainerOverride(object item);
+        protected virtual void OnActivatingKeyTip(ActivatingKeyTipEventArgs e);
+        public override void OnApplyTemplate();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected virtual void OnDismissPopup(RibbonDismissPopupEventArgs e);
+        protected override void OnGotKeyboardFocus(KeyboardFocusChangedEventArgs e);
+        protected override void OnIsKeyboardFocusWithinChanged(DependencyPropertyChangedEventArgs e);
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected virtual void OnKeyTipAccessed(KeyTipAccessedEventArgs e);
+        protected override void OnKeyUp(KeyEventArgs e);
+        protected override void OnPreviewKeyDown(KeyEventArgs e);
+        protected override void OnPreviewMouseDown(MouseButtonEventArgs e);
+        protected override void OnTemplateChanged(ControlTemplate oldTemplate, ControlTemplate newTemplate);
+        protected override void PrepareContainerForItemOverride(DependencyObject element, object item);
+        protected override bool ShouldApplyItemContainerStyle(DependencyObject container, object item);
+    }
+    public class RibbonMenuItem : MenuItem {
+        public static readonly DependencyProperty CanAddToQuickAccessToolBarDirectlyProperty;
+        public static readonly DependencyProperty CanUserResizeHorizontallyProperty;
+        public static readonly DependencyProperty CanUserResizeVerticallyProperty;
+        public static readonly DependencyProperty CheckedBackgroundProperty;
+        public static readonly DependencyProperty CheckedBorderBrushProperty;
+        public static readonly DependencyProperty DropDownHeightProperty;
+        public static readonly DependencyProperty HasGalleryProperty;
+        public static readonly DependencyProperty ImageSourceProperty;
+        public static readonly DependencyProperty IsDropDownPositionedLeftProperty;
+        public static readonly DependencyProperty KeyTipProperty;
+        public static readonly DependencyProperty MouseOverBackgroundProperty;
+        public static readonly DependencyProperty MouseOverBorderBrushProperty;
+        public static readonly DependencyProperty PressedBackgroundProperty;
+        public static readonly DependencyProperty PressedBorderBrushProperty;
+        public static readonly DependencyProperty QuickAccessToolBarIdProperty;
+        public static readonly DependencyProperty QuickAccessToolBarImageSourceProperty;
+        public static readonly DependencyProperty RibbonProperty;
+        public static readonly DependencyProperty ToolTipDescriptionProperty;
+        public static readonly DependencyProperty ToolTipFooterDescriptionProperty;
+        public static readonly DependencyProperty ToolTipFooterImageSourceProperty;
+        public static readonly DependencyProperty ToolTipFooterTitleProperty;
+        public static readonly DependencyProperty ToolTipImageSourceProperty;
+        public static readonly DependencyProperty ToolTipTitleProperty;
+        public RibbonMenuItem();
+        public bool CanAddToQuickAccessToolBarDirectly { get; set; }
+        public bool CanUserResizeHorizontally { get; set; }
+        public bool CanUserResizeVertically { get; set; }
+        public Brush CheckedBackground { get; set; }
+        public Brush CheckedBorderBrush { get; set; }
+        public double DropDownHeight { get; set; }
+        public bool HasGallery { get; private set; }
+        public ImageSource ImageSource { get; set; }
+        public bool IsDropDownPositionedLeft { get; private set; }
+        public string KeyTip { get; set; }
+        public Brush MouseOverBackground { get; set; }
+        public Brush MouseOverBorderBrush { get; set; }
+        public Brush PressedBackground { get; set; }
+        public Brush PressedBorderBrush { get; set; }
+        public object QuickAccessToolBarId { get; set; }
+        public ImageSource QuickAccessToolBarImageSource { get; set; }
+        public Ribbon Ribbon { get; }
+        public string ToolTipDescription { get; set; }
+        public string ToolTipFooterDescription { get; set; }
+        public ImageSource ToolTipFooterImageSource { get; set; }
+        public string ToolTipFooterTitle { get; set; }
+        public ImageSource ToolTipImageSource { get; set; }
+        public string ToolTipTitle { get; set; }
+        protected override void ClearContainerForItemOverride(DependencyObject element, object item);
+        protected override DependencyObject GetContainerForItemOverride();
+        protected override bool IsItemItsOwnContainerOverride(object item);
+        protected virtual void OnActivatingKeyTip(ActivatingKeyTipEventArgs e);
+        public override void OnApplyTemplate();
+        protected override void OnClick();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnGotKeyboardFocus(KeyboardFocusChangedEventArgs e);
+        protected override void OnIsKeyboardFocusWithinChanged(DependencyPropertyChangedEventArgs e);
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected virtual void OnKeyTipAccessed(KeyTipAccessedEventArgs e);
+        protected override void OnLostKeyboardFocus(KeyboardFocusChangedEventArgs e);
+        protected override void OnMouseEnter(MouseEventArgs e);
+        protected override void OnMouseLeave(MouseEventArgs e);
+        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e);
+        protected override void OnPreviewKeyUp(KeyEventArgs e);
+        protected override void PrepareContainerForItemOverride(DependencyObject element, object item);
+        protected override bool ShouldApplyItemContainerStyle(DependencyObject container, object item);
+    }
+    public class RibbonQuickAccessToolBar : ItemsControl {
+        public static readonly DependencyProperty CustomizeMenuButtonProperty;
+        public static readonly DependencyProperty HasOverflowItemsProperty;
+        public static readonly DependencyProperty IsOverflowItemProperty;
+        public static readonly DependencyProperty IsOverflowOpenProperty;
+        public static readonly DependencyProperty RibbonProperty;
+        public static readonly RoutedEvent CloneEvent;
+        public RibbonQuickAccessToolBar();
+        public RibbonMenuButton CustomizeMenuButton { get; set; }
+        public bool HasOverflowItems { get; internal set; }
+        public bool IsOverflowOpen { get; set; }
+        public Ribbon Ribbon { get; }
+        public static void AddCloneHandler(DependencyObject element, RibbonQuickAccessToolBarCloneEventHandler handler);
+        protected override void ClearContainerForItemOverride(DependencyObject element, object item);
+        protected override DependencyObject GetContainerForItemOverride();
+        public static bool GetIsOverflowItem(DependencyObject element);
+        protected override bool IsItemItsOwnContainerOverride(object item);
+        protected virtual void OnActivatingKeyTip(ActivatingKeyTipEventArgs e);
+        public override void OnApplyTemplate();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnItemsChanged(NotifyCollectionChangedEventArgs e);
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected virtual void OnPreviewKeyTipAccessed(KeyTipAccessedEventArgs e);
+        protected override void PrepareContainerForItemOverride(DependencyObject element, object item);
+        public static void RemoveCloneHandler(DependencyObject element, RibbonQuickAccessToolBarCloneEventHandler handler);
+    }
+    public class RibbonQuickAccessToolBarCloneEventArgs : RoutedEventArgs {
+        public RibbonQuickAccessToolBarCloneEventArgs(UIElement targetElement);
+        public UIElement CloneInstance { get; set; }
+        public UIElement InstanceToBeCloned { get; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void RibbonQuickAccessToolBarCloneEventHandler(object sender, RibbonQuickAccessToolBarCloneEventArgs e);
+    public class RibbonRadioButton : RadioButton {
+        public static readonly DependencyProperty CanAddToQuickAccessToolBarDirectlyProperty;
+        public static readonly DependencyProperty CheckedBackgroundProperty;
+        public static readonly DependencyProperty CheckedBorderBrushProperty;
+        public static readonly DependencyProperty ControlSizeDefinitionProperty;
+        public static readonly DependencyProperty CornerRadiusProperty;
+        public static readonly DependencyProperty FocusedBackgroundProperty;
+        public static readonly DependencyProperty FocusedBorderBrushProperty;
+        public static readonly DependencyProperty IsInControlGroupProperty;
+        public static readonly DependencyProperty IsInQuickAccessToolBarProperty;
+        public static readonly DependencyProperty KeyTipProperty;
+        public static readonly DependencyProperty LabelProperty;
+        public static readonly DependencyProperty LargeImageSourceProperty;
+        public static readonly DependencyProperty MouseOverBackgroundProperty;
+        public static readonly DependencyProperty MouseOverBorderBrushProperty;
+        public static readonly DependencyProperty PressedBackgroundProperty;
+        public static readonly DependencyProperty PressedBorderBrushProperty;
+        public static readonly DependencyProperty QuickAccessToolBarControlSizeDefinitionProperty;
+        public static readonly DependencyProperty QuickAccessToolBarIdProperty;
+        public static readonly DependencyProperty RibbonProperty;
+        public static readonly DependencyProperty ShowKeyboardCuesProperty;
+        public static readonly DependencyProperty SmallImageSourceProperty;
+        public static readonly DependencyProperty ToolTipDescriptionProperty;
+        public static readonly DependencyProperty ToolTipFooterDescriptionProperty;
+        public static readonly DependencyProperty ToolTipFooterImageSourceProperty;
+        public static readonly DependencyProperty ToolTipFooterTitleProperty;
+        public static readonly DependencyProperty ToolTipImageSourceProperty;
+        public static readonly DependencyProperty ToolTipTitleProperty;
+        public RibbonRadioButton();
+        public bool CanAddToQuickAccessToolBarDirectly { get; set; }
+        public Brush CheckedBackground { get; set; }
+        public Brush CheckedBorderBrush { get; set; }
+        public RibbonControlSizeDefinition ControlSizeDefinition { get; set; }
+        public CornerRadius CornerRadius { get; set; }
+        public Brush FocusedBackground { get; set; }
+        public Brush FocusedBorderBrush { get; set; }
+        public bool IsInControlGroup { get; internal set; }
+        public bool IsInQuickAccessToolBar { get; internal set; }
+        public string KeyTip { get; set; }
+        public string Label { get; set; }
+        public ImageSource LargeImageSource { get; set; }
+        public Brush MouseOverBackground { get; set; }
+        public Brush MouseOverBorderBrush { get; set; }
+        public Brush PressedBackground { get; set; }
+        public Brush PressedBorderBrush { get; set; }
+        public RibbonControlSizeDefinition QuickAccessToolBarControlSizeDefinition { get; set; }
+        public object QuickAccessToolBarId { get; set; }
+        public Ribbon Ribbon { get; }
+        public bool ShowKeyboardCues { get; }
+        public ImageSource SmallImageSource { get; set; }
+        public string ToolTipDescription { get; set; }
+        public string ToolTipFooterDescription { get; set; }
+        public ImageSource ToolTipFooterImageSource { get; set; }
+        public string ToolTipFooterTitle { get; set; }
+        public ImageSource ToolTipImageSource { get; set; }
+        public string ToolTipTitle { get; set; }
+        protected virtual void OnActivatingKeyTip(ActivatingKeyTipEventArgs e);
+        public override void OnApplyTemplate();
+        protected override void OnClick();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnGotKeyboardFocus(KeyboardFocusChangedEventArgs e);
+        protected virtual void OnKeyTipAccessed(KeyTipAccessedEventArgs e);
+        protected override void OnLostKeyboardFocus(KeyboardFocusChangedEventArgs e);
+        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e);
+    }
+    public class RibbonSeparator : Separator {
+        public static readonly DependencyProperty LabelProperty;
+        public static readonly DependencyProperty RibbonProperty;
+        public RibbonSeparator();
+        public string Label { get; set; }
+        public Ribbon Ribbon { get; }
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e);
+        protected internal override void OnVisualParentChanged(DependencyObject oldParent);
+    }
+    public class RibbonSplitButton : RibbonMenuButton, ICommandSource {
+        public static readonly DependencyProperty CheckedBackgroundProperty;
+        public static readonly DependencyProperty CheckedBorderBrushProperty;
+        public static readonly DependencyProperty CommandParameterProperty;
+        public static readonly DependencyProperty CommandProperty;
+        public static readonly DependencyProperty CommandTargetProperty;
+        public static readonly DependencyProperty DropDownToolTipDescriptionProperty;
+        public static readonly DependencyProperty DropDownToolTipFooterDescriptionProperty;
+        public static readonly DependencyProperty DropDownToolTipFooterImageSourceProperty;
+        public static readonly DependencyProperty DropDownToolTipFooterTitleProperty;
+        public static readonly DependencyProperty DropDownToolTipImageSourceProperty;
+        public static readonly DependencyProperty DropDownToolTipTitleProperty;
+        public static readonly DependencyProperty HeaderKeyTipProperty;
+        public static readonly DependencyProperty HeaderQuickAccessToolBarIdProperty;
+        public static readonly DependencyProperty IsCheckableProperty;
+        public static readonly DependencyProperty IsCheckedProperty;
+        public static readonly DependencyProperty LabelPositionProperty;
+        public static readonly RoutedEvent ClickEvent;
+        public RibbonSplitButton();
+        public Brush CheckedBackground { get; set; }
+        public Brush CheckedBorderBrush { get; set; }
+        public ICommand Command { get; set; }
+        public object CommandParameter { get; set; }
+        public IInputElement CommandTarget { get; set; }
+        public string DropDownToolTipDescription { get; set; }
+        public string DropDownToolTipFooterDescription { get; set; }
+        public ImageSource DropDownToolTipFooterImageSource { get; set; }
+        public string DropDownToolTipFooterTitle { get; set; }
+        public ImageSource DropDownToolTipImageSource { get; set; }
+        public string DropDownToolTipTitle { get; set; }
+        public string HeaderKeyTip { get; set; }
+        public object HeaderQuickAccessToolBarId { get; set; }
+        public bool IsCheckable { get; set; }
+        public bool IsChecked { get; set; }
+        public RibbonSplitButtonLabelPosition LabelPosition { get; set; }
+        public event RoutedEventHandler Click;
+        protected override void OnActivatingKeyTip(ActivatingKeyTipEventArgs e);
+        public override void OnApplyTemplate();
+        protected override AutomationPeer OnCreateAutomationPeer();
+    }
+    public enum RibbonSplitButtonLabelPosition {
+        DropDown = 1,
+        Header = 0,
+    }
+    public class RibbonSplitMenuItem : RibbonMenuItem {
+        public static readonly DependencyProperty DropDownToolTipDescriptionProperty;
+        public static readonly DependencyProperty DropDownToolTipFooterDescriptionProperty;
+        public static readonly DependencyProperty DropDownToolTipFooterImageSourceProperty;
+        public static readonly DependencyProperty DropDownToolTipFooterTitleProperty;
+        public static readonly DependencyProperty DropDownToolTipImageSourceProperty;
+        public static readonly DependencyProperty DropDownToolTipTitleProperty;
+        public static readonly DependencyProperty HeaderKeyTipProperty;
+        public static readonly DependencyProperty HeaderQuickAccessToolBarIdProperty;
+        public RibbonSplitMenuItem();
+        public string DropDownToolTipDescription { get; set; }
+        public string DropDownToolTipFooterDescription { get; set; }
+        public ImageSource DropDownToolTipFooterImageSource { get; set; }
+        public string DropDownToolTipFooterTitle { get; set; }
+        public ImageSource DropDownToolTipImageSource { get; set; }
+        public string DropDownToolTipTitle { get; set; }
+        public string HeaderKeyTip { get; set; }
+        public object HeaderQuickAccessToolBarId { get; set; }
+        protected override bool IsEnabledCore { get; }
+        protected override void OnActivatingKeyTip(ActivatingKeyTipEventArgs e);
+        public override void OnApplyTemplate();
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected override void OnKeyTipAccessed(KeyTipAccessedEventArgs e);
+    }
+    public class RibbonTab : HeaderedItemsControl {
+        public static readonly DependencyProperty ContextualTabGroupHeaderProperty;
+        public static readonly DependencyProperty ContextualTabGroupProperty;
+        public static readonly DependencyProperty GroupSizeReductionOrderProperty;
+        public static readonly DependencyProperty HeaderStyleProperty;
+        public static readonly DependencyProperty IsSelectedProperty;
+        public static readonly DependencyProperty KeyTipProperty;
+        public static readonly DependencyProperty RibbonProperty;
+        public static readonly DependencyProperty TabHeaderLeftProperty;
+        public static readonly DependencyProperty TabHeaderRightProperty;
+        public RibbonTab();
+        public RibbonContextualTabGroup ContextualTabGroup { get; internal set; }
+        public object ContextualTabGroupHeader { get; set; }
+        public StringCollection GroupSizeReductionOrder { get; set; }
+        protected internal override bool HandlesScrolling { get; }
+        public Style HeaderStyle { get; set; }
+        public bool IsSelected { get; set; }
+        public string KeyTip { get; set; }
+        public Ribbon Ribbon { get; }
+        public double TabHeaderLeft { get; internal set; }
+        public double TabHeaderRight { get; internal set; }
+        protected override void ClearContainerForItemOverride(DependencyObject element, object item);
+        protected override DependencyObject GetContainerForItemOverride();
+        protected override bool IsItemItsOwnContainerOverride(object item);
+        protected virtual void OnActivatingKeyTip(ActivatingKeyTipEventArgs e);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnItemsChanged(NotifyCollectionChangedEventArgs e);
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected virtual void OnKeyTipAccessed(KeyTipAccessedEventArgs e);
+        protected virtual void OnSelected(RoutedEventArgs e);
+        protected virtual void OnUnselected(RoutedEventArgs e);
+        protected override void PrepareContainerForItemOverride(DependencyObject element, object item);
+    }
+    public class RibbonTabHeader : ContentControl {
+        public static readonly DependencyProperty CheckedBackgroundProperty;
+        public static readonly DependencyProperty CheckedBorderBrushProperty;
+        public static readonly DependencyProperty ContextualTabGroupProperty;
+        public static readonly DependencyProperty FocusedBackgroundProperty;
+        public static readonly DependencyProperty FocusedBorderBrushProperty;
+        public static readonly DependencyProperty IsContextualTabProperty;
+        public static readonly DependencyProperty IsRibbonTabSelectedProperty;
+        public static readonly DependencyProperty MouseOverBackgroundProperty;
+        public static readonly DependencyProperty MouseOverBorderBrushProperty;
+        public static readonly DependencyProperty RibbonProperty;
+        public RibbonTabHeader();
+        public Brush CheckedBackground { get; set; }
+        public Brush CheckedBorderBrush { get; set; }
+        public RibbonContextualTabGroup ContextualTabGroup { get; private set; }
+        public Brush FocusedBackground { get; set; }
+        public Brush FocusedBorderBrush { get; set; }
+        public bool IsContextualTab { get; private set; }
+        public bool IsRibbonTabSelected { get; internal set; }
+        public Brush MouseOverBackground { get; set; }
+        public Brush MouseOverBorderBrush { get; set; }
+        public Ribbon Ribbon { get; }
+        protected virtual void OnActivatingKeyTip(ActivatingKeyTipEventArgs e);
+        public override void OnApplyTemplate();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnGotKeyboardFocus(KeyboardFocusChangedEventArgs e);
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected virtual void OnKeyTipAccessed(KeyTipAccessedEventArgs e);
+        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e);
+        protected override void OnRender(DrawingContext drawingContext);
+    }
+    public class RibbonTabHeaderItemsControl : ItemsControl {
+        public RibbonTabHeaderItemsControl();
+        protected internal override bool HandlesScrolling { get; }
+        protected override DependencyObject GetContainerForItemOverride();
+        protected override bool IsItemItsOwnContainerOverride(object item);
+        public override void OnApplyTemplate();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void PrepareContainerForItemOverride(DependencyObject element, object item);
+    }
+    public class RibbonTextBox : TextBox, ICommandSource {
+        public static readonly DependencyProperty CanAddToQuickAccessToolBarDirectlyProperty;
+        public static readonly DependencyProperty CommandParameterProperty;
+        public static readonly DependencyProperty CommandProperty;
+        public static readonly DependencyProperty CommandTargetProperty;
+        public static readonly DependencyProperty ControlSizeDefinitionProperty;
+        public static readonly DependencyProperty FocusedBackgroundProperty;
+        public static readonly DependencyProperty FocusedBorderBrushProperty;
+        public static readonly DependencyProperty IsInControlGroupProperty;
+        public static readonly DependencyProperty IsInQuickAccessToolBarProperty;
+        public static readonly DependencyProperty KeyTipProperty;
+        public static readonly DependencyProperty LabelProperty;
+        public static readonly DependencyProperty LargeImageSourceProperty;
+        public static readonly DependencyProperty MouseOverBackgroundProperty;
+        public static readonly DependencyProperty MouseOverBorderBrushProperty;
+        public static readonly DependencyProperty QuickAccessToolBarControlSizeDefinitionProperty;
+        public static readonly DependencyProperty QuickAccessToolBarIdProperty;
+        public static readonly DependencyProperty RibbonProperty;
+        public static readonly DependencyProperty ShowKeyboardCuesProperty;
+        public static readonly DependencyProperty SmallImageSourceProperty;
+        public static readonly DependencyProperty TextBoxWidthProperty;
+        public static readonly DependencyProperty ToolTipDescriptionProperty;
+        public static readonly DependencyProperty ToolTipFooterDescriptionProperty;
+        public static readonly DependencyProperty ToolTipFooterImageSourceProperty;
+        public static readonly DependencyProperty ToolTipFooterTitleProperty;
+        public static readonly DependencyProperty ToolTipImageSourceProperty;
+        public static readonly DependencyProperty ToolTipTitleProperty;
+        public RibbonTextBox();
+        public bool CanAddToQuickAccessToolBarDirectly { get; set; }
+        public ICommand Command { get; set; }
+        public object CommandParameter { get; set; }
+        public IInputElement CommandTarget { get; set; }
+        public RibbonControlSizeDefinition ControlSizeDefinition { get; set; }
+        public Brush FocusedBackground { get; set; }
+        public Brush FocusedBorderBrush { get; set; }
+        protected override bool IsEnabledCore { get; }
+        public bool IsInControlGroup { get; internal set; }
+        public bool IsInQuickAccessToolBar { get; internal set; }
+        public string KeyTip { get; set; }
+        public string Label { get; set; }
+        public ImageSource LargeImageSource { get; set; }
+        public Brush MouseOverBackground { get; set; }
+        public Brush MouseOverBorderBrush { get; set; }
+        public RibbonControlSizeDefinition QuickAccessToolBarControlSizeDefinition { get; set; }
+        public object QuickAccessToolBarId { get; set; }
+        public Ribbon Ribbon { get; }
+        public bool ShowKeyboardCues { get; }
+        public ImageSource SmallImageSource { get; set; }
+        public double TextBoxWidth { get; set; }
+        public string ToolTipDescription { get; set; }
+        public string ToolTipFooterDescription { get; set; }
+        public ImageSource ToolTipFooterImageSource { get; set; }
+        public string ToolTipFooterTitle { get; set; }
+        public ImageSource ToolTipImageSource { get; set; }
+        public string ToolTipTitle { get; set; }
+        protected virtual void OnActivatingKeyTip(ActivatingKeyTipEventArgs e);
+        public override void OnApplyTemplate();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnGotKeyboardFocus(KeyboardFocusChangedEventArgs e);
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected virtual void OnKeyTipAccessed(KeyTipAccessedEventArgs e);
+        protected override void OnLostKeyboardFocus(KeyboardFocusChangedEventArgs e);
+        protected override void OnTemplateChanged(ControlTemplate oldTemplate, ControlTemplate newTemplate);
+    }
+    public class RibbonToggleButton : ToggleButton {
+        public static readonly DependencyProperty CanAddToQuickAccessToolBarDirectlyProperty;
+        public static readonly DependencyProperty CheckedBackgroundProperty;
+        public static readonly DependencyProperty CheckedBorderBrushProperty;
+        public static readonly DependencyProperty ControlSizeDefinitionProperty;
+        public static readonly DependencyProperty CornerRadiusProperty;
+        public static readonly DependencyProperty FocusedBackgroundProperty;
+        public static readonly DependencyProperty FocusedBorderBrushProperty;
+        public static readonly DependencyProperty IsInControlGroupProperty;
+        public static readonly DependencyProperty IsInQuickAccessToolBarProperty;
+        public static readonly DependencyProperty KeyTipProperty;
+        public static readonly DependencyProperty LabelProperty;
+        public static readonly DependencyProperty LargeImageSourceProperty;
+        public static readonly DependencyProperty MouseOverBackgroundProperty;
+        public static readonly DependencyProperty MouseOverBorderBrushProperty;
+        public static readonly DependencyProperty PressedBackgroundProperty;
+        public static readonly DependencyProperty PressedBorderBrushProperty;
+        public static readonly DependencyProperty QuickAccessToolBarControlSizeDefinitionProperty;
+        public static readonly DependencyProperty QuickAccessToolBarIdProperty;
+        public static readonly DependencyProperty RibbonProperty;
+        public static readonly DependencyProperty ShowKeyboardCuesProperty;
+        public static readonly DependencyProperty SmallImageSourceProperty;
+        public static readonly DependencyProperty ToolTipDescriptionProperty;
+        public static readonly DependencyProperty ToolTipFooterDescriptionProperty;
+        public static readonly DependencyProperty ToolTipFooterImageSourceProperty;
+        public static readonly DependencyProperty ToolTipFooterTitleProperty;
+        public static readonly DependencyProperty ToolTipImageSourceProperty;
+        public static readonly DependencyProperty ToolTipTitleProperty;
+        public RibbonToggleButton();
+        public bool CanAddToQuickAccessToolBarDirectly { get; set; }
+        public Brush CheckedBackground { get; set; }
+        public Brush CheckedBorderBrush { get; set; }
+        public RibbonControlSizeDefinition ControlSizeDefinition { get; set; }
+        public CornerRadius CornerRadius { get; set; }
+        public Brush FocusedBackground { get; set; }
+        public Brush FocusedBorderBrush { get; set; }
+        public bool IsInControlGroup { get; internal set; }
+        public bool IsInQuickAccessToolBar { get; internal set; }
+        public string KeyTip { get; set; }
+        public string Label { get; set; }
+        public ImageSource LargeImageSource { get; set; }
+        public Brush MouseOverBackground { get; set; }
+        public Brush MouseOverBorderBrush { get; set; }
+        public Brush PressedBackground { get; set; }
+        public Brush PressedBorderBrush { get; set; }
+        public RibbonControlSizeDefinition QuickAccessToolBarControlSizeDefinition { get; set; }
+        public object QuickAccessToolBarId { get; set; }
+        public Ribbon Ribbon { get; }
+        public bool ShowKeyboardCues { get; }
+        public ImageSource SmallImageSource { get; set; }
+        public string ToolTipDescription { get; set; }
+        public string ToolTipFooterDescription { get; set; }
+        public ImageSource ToolTipFooterImageSource { get; set; }
+        public string ToolTipFooterTitle { get; set; }
+        public ImageSource ToolTipImageSource { get; set; }
+        public string ToolTipTitle { get; set; }
+        protected virtual void OnActivatingKeyTip(ActivatingKeyTipEventArgs e);
+        public override void OnApplyTemplate();
+        protected override void OnClick();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnGotKeyboardFocus(KeyboardFocusChangedEventArgs e);
+        protected virtual void OnKeyTipAccessed(KeyTipAccessedEventArgs e);
+        protected override void OnLostKeyboardFocus(KeyboardFocusChangedEventArgs e);
+        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e);
+    }
+    public class RibbonToolTip : ToolTip {
+        public static readonly DependencyProperty DescriptionProperty;
+        public static readonly DependencyProperty FooterDescriptionProperty;
+        public static readonly DependencyProperty FooterImageSourceProperty;
+        public static readonly DependencyProperty FooterTitleProperty;
+        public static readonly DependencyProperty HasFooterProperty;
+        public static readonly DependencyProperty HasHeaderProperty;
+        public static readonly DependencyProperty ImageSourceProperty;
+        public static readonly DependencyProperty IsPlacementTargetInRibbonGroupProperty;
+        public static readonly DependencyProperty RibbonProperty;
+        public static readonly DependencyProperty TitleProperty;
+        public RibbonToolTip();
+        public string Description { get; set; }
+        public string FooterDescription { get; set; }
+        public ImageSource FooterImageSource { get; set; }
+        public string FooterTitle { get; set; }
+        public bool HasFooter { get; internal set; }
+        public bool HasHeader { get; internal set; }
+        public ImageSource ImageSource { get; set; }
+        public bool IsPlacementTargetInRibbonGroup { get; internal set; }
+        public Ribbon Ribbon { get; private set; }
+        public string Title { get; set; }
+        protected override AutomationPeer OnCreateAutomationPeer();
+    }
+    public class RibbonTwoLineText : Control {
+        public static readonly DependencyProperty BaselineOffsetProperty;
+        public static readonly DependencyProperty HasTwoLinesProperty;
+        public static readonly DependencyProperty LineHeightProperty;
+        public static readonly DependencyProperty LineStackingStrategyProperty;
+        public static readonly new DependencyProperty PaddingProperty;
+        public static readonly DependencyProperty PathDataProperty;
+        public static readonly DependencyProperty PathFillProperty;
+        public static readonly DependencyProperty PathStrokeProperty;
+        public static readonly DependencyProperty TextAlignmentProperty;
+        public static readonly DependencyProperty TextDecorationsProperty;
+        public static readonly DependencyProperty TextEffectsProperty;
+        public static readonly DependencyProperty TextProperty;
+        public static readonly DependencyProperty TextTrimmingProperty;
+        public RibbonTwoLineText();
+        public double BaselineOffset { get; set; }
+        public double LineHeight { get; set; }
+        public LineStackingStrategy LineStackingStrategy { get; set; }
+        public new Thickness Padding { get; set; }
+        public Brush PathFill { get; set; }
+        public Brush PathStroke { get; set; }
+        public string Text { get; set; }
+        public TextAlignment TextAlignment { get; set; }
+        public TextDecorationCollection TextDecorations { get; set; }
+        public TextEffectCollection TextEffects { get; set; }
+        public TextTrimming TextTrimming { get; set; }
+        public static bool GetHasTwoLines(DependencyObject element);
+        public static Geometry GetPathData(DependencyObject element);
+        protected override Size MeasureOverride(Size availableSize);
+        public override void OnApplyTemplate();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        public static void SetHasTwoLines(DependencyObject element, bool value);
+        public static void SetPathData(DependencyObject element, Geometry value);
+    }
+    public class RibbonWindow : Window {
+        public RibbonWindow();
+        public override void OnApplyTemplate();
+    }
+    public class StringCollectionConverter : TypeConverter {
+        public StringCollectionConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+}
```

