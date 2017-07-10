# System.Windows.Automation.Peers

``` diff
+namespace System.Windows.Automation.Peers {
+    public enum AutomationControlType {
+        Button = 0,
+        Calendar = 1,
+        CheckBox = 2,
+        ComboBox = 3,
+        Custom = 25,
+        DataGrid = 28,
+        DataItem = 29,
+        Document = 30,
+        Edit = 4,
+        Group = 26,
+        Header = 34,
+        HeaderItem = 35,
+        Hyperlink = 5,
+        Image = 6,
+        List = 8,
+        ListItem = 7,
+        Menu = 9,
+        MenuBar = 10,
+        MenuItem = 11,
+        Pane = 33,
+        ProgressBar = 12,
+        RadioButton = 13,
+        ScrollBar = 14,
+        Separator = 38,
+        Slider = 15,
+        Spinner = 16,
+        SplitButton = 31,
+        StatusBar = 17,
+        Tab = 18,
+        TabItem = 19,
+        Table = 36,
+        Text = 20,
+        Thumb = 27,
+        TitleBar = 37,
+        ToolBar = 21,
+        ToolTip = 22,
+        Tree = 23,
+        TreeItem = 24,
+        Window = 32,
+    }
+    public enum AutomationEvents {
+        AsyncContentLoaded = 12,
+        AutomationFocusChanged = 4,
+        InputDiscarded = 17,
+        InputReachedOtherElement = 16,
+        InputReachedTarget = 15,
+        InvokePatternOnInvoked = 5,
+        MenuClosed = 3,
+        MenuOpened = 2,
+        PropertyChanged = 13,
+        SelectionItemPatternOnElementAddedToSelection = 6,
+        SelectionItemPatternOnElementRemovedFromSelection = 7,
+        SelectionItemPatternOnElementSelected = 8,
+        SelectionPatternOnInvalidated = 9,
+        StructureChanged = 14,
+        TextPatternOnTextChanged = 11,
+        TextPatternOnTextSelectionChanged = 10,
+        ToolTipClosed = 1,
+        ToolTipOpened = 0,
+    }
+    public enum AutomationOrientation {
+        Horizontal = 1,
+        None = 0,
+        Vertical = 2,
+    }
+    public abstract class AutomationPeer : DispatcherObject {
+        protected AutomationPeer();
+        public AutomationPeer EventsSource { get; set; }
+        protected internal virtual bool IsHwndHost { get; }
+        public string GetAcceleratorKey();
+        protected abstract string GetAcceleratorKeyCore();
+        public string GetAccessKey();
+        protected abstract string GetAccessKeyCore();
+        public AutomationControlType GetAutomationControlType();
+        protected abstract AutomationControlType GetAutomationControlTypeCore();
+        public string GetAutomationId();
+        protected abstract string GetAutomationIdCore();
+        public Rect GetBoundingRectangle();
+        protected abstract Rect GetBoundingRectangleCore();
+        public List<AutomationPeer> GetChildren();
+        protected abstract List<AutomationPeer> GetChildrenCore();
+        public string GetClassName();
+        protected abstract string GetClassNameCore();
+        public Point GetClickablePoint();
+        protected abstract Point GetClickablePointCore();
+        public string GetHelpText();
+        protected abstract string GetHelpTextCore();
+        protected virtual HostedWindowWrapper GetHostRawElementProviderCore();
+        public string GetItemStatus();
+        protected abstract string GetItemStatusCore();
+        public string GetItemType();
+        protected abstract string GetItemTypeCore();
+        public AutomationPeer GetLabeledBy();
+        protected abstract AutomationPeer GetLabeledByCore();
+        public string GetLocalizedControlType();
+        protected virtual string GetLocalizedControlTypeCore();
+        public string GetName();
+        protected abstract string GetNameCore();
+        public AutomationOrientation GetOrientation();
+        protected abstract AutomationOrientation GetOrientationCore();
+        public AutomationPeer GetParent();
+        public abstract object GetPattern(PatternInterface patternInterface);
+        public AutomationPeer GetPeerFromPoint(Point point);
+        protected virtual AutomationPeer GetPeerFromPointCore(Point point);
+        public bool HasKeyboardFocus();
+        protected abstract bool HasKeyboardFocusCore();
+        public void InvalidatePeer();
+        public bool IsContentElement();
+        protected abstract bool IsContentElementCore();
+        public bool IsControlElement();
+        protected abstract bool IsControlElementCore();
+        public bool IsEnabled();
+        protected abstract bool IsEnabledCore();
+        public bool IsKeyboardFocusable();
+        protected abstract bool IsKeyboardFocusableCore();
+        public bool IsOffscreen();
+        protected abstract bool IsOffscreenCore();
+        public bool IsPassword();
+        protected abstract bool IsPasswordCore();
+        public bool IsRequiredForForm();
+        protected abstract bool IsRequiredForFormCore();
+        public static bool ListenerExists(AutomationEvents eventId);
+        protected AutomationPeer PeerFromProvider(IRawElementProviderSimple provider);
+        protected internal IRawElementProviderSimple ProviderFromPeer(AutomationPeer peer);
+        public void RaiseAsyncContentLoadedEvent(AsyncContentLoadedEventArgs args);
+        public void RaiseAutomationEvent(AutomationEvents eventId);
+        public void RaisePropertyChangedEvent(AutomationProperty property, object oldValue, object newValue);
+        public void ResetChildrenCache();
+        public void SetFocus();
+        protected abstract void SetFocusCore();
+    }
+    public class ButtonAutomationPeer : ButtonBaseAutomationPeer, IInvokeProvider {
+        public ButtonAutomationPeer(Button owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        void System.Windows.Automation.Provider.IInvokeProvider.Invoke();
+    }
+    public abstract class ButtonBaseAutomationPeer : FrameworkElementAutomationPeer {
+        protected ButtonBaseAutomationPeer(ButtonBase owner);
+        protected override string GetAcceleratorKeyCore();
+        protected override string GetAutomationIdCore();
+        protected override string GetNameCore();
+    }
+    public sealed class CalendarAutomationPeer : FrameworkElementAutomationPeer, IGridProvider, IItemContainerProvider, IMultipleViewProvider, ISelectionProvider, ITableProvider {
+        public CalendarAutomationPeer(Calendar owner);
+        int System.Windows.Automation.Provider.IGridProvider.ColumnCount { get; }
+        int System.Windows.Automation.Provider.IGridProvider.RowCount { get; }
+        int System.Windows.Automation.Provider.IMultipleViewProvider.CurrentView { get; }
+        bool System.Windows.Automation.Provider.ISelectionProvider.CanSelectMultiple { get; }
+        bool System.Windows.Automation.Provider.ISelectionProvider.IsSelectionRequired { get; }
+        RowOrColumnMajor System.Windows.Automation.Provider.ITableProvider.RowOrColumnMajor { get; }
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override List<AutomationPeer> GetChildrenCore();
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        protected override void SetFocusCore();
+        IRawElementProviderSimple System.Windows.Automation.Provider.IGridProvider.GetItem(int row, int column);
+        IRawElementProviderSimple System.Windows.Automation.Provider.IItemContainerProvider.FindItemByProperty(IRawElementProviderSimple startAfterProvider, int propertyId, object value);
+        int[] System.Windows.Automation.Provider.IMultipleViewProvider.GetSupportedViews();
+        string System.Windows.Automation.Provider.IMultipleViewProvider.GetViewName(int viewId);
+        void System.Windows.Automation.Provider.IMultipleViewProvider.SetCurrentView(int viewId);
+        IRawElementProviderSimple[] System.Windows.Automation.Provider.ISelectionProvider.GetSelection();
+        IRawElementProviderSimple[] System.Windows.Automation.Provider.ITableProvider.GetColumnHeaders();
+        IRawElementProviderSimple[] System.Windows.Automation.Provider.ITableProvider.GetRowHeaders();
+    }
+    public sealed class CalendarButtonAutomationPeer : FrameworkElementAutomationPeer {
+        public CalendarButtonAutomationPeer(Button owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        protected override string GetLocalizedControlTypeCore();
+    }
+    public class CheckBoxAutomationPeer : ToggleButtonAutomationPeer {
+        public CheckBoxAutomationPeer(CheckBox owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+    }
+    public class ComboBoxAutomationPeer : SelectorAutomationPeer, IExpandCollapseProvider, IValueProvider {
+        public ComboBoxAutomationPeer(ComboBox owner);
+        ExpandCollapseState System.Windows.Automation.Provider.IExpandCollapseProvider.ExpandCollapseState { get; }
+        bool System.Windows.Automation.Provider.IValueProvider.IsReadOnly { get; }
+        string System.Windows.Automation.Provider.IValueProvider.Value { get; }
+        protected override ItemAutomationPeer CreateItemAutomationPeer(object item);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override List<AutomationPeer> GetChildrenCore();
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface pattern);
+        protected override void SetFocusCore();
+        void System.Windows.Automation.Provider.IExpandCollapseProvider.Collapse();
+        void System.Windows.Automation.Provider.IExpandCollapseProvider.Expand();
+        void System.Windows.Automation.Provider.IValueProvider.SetValue(string val);
+    }
+    public class ContentElementAutomationPeer : AutomationPeer {
+        public ContentElementAutomationPeer(ContentElement owner);
+        public ContentElement Owner { get; }
+        public static AutomationPeer CreatePeerForElement(ContentElement element);
+        public static AutomationPeer FromElement(ContentElement element);
+        protected override string GetAcceleratorKeyCore();
+        protected override string GetAccessKeyCore();
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetAutomationIdCore();
+        protected override Rect GetBoundingRectangleCore();
+        protected override List<AutomationPeer> GetChildrenCore();
+        protected override string GetClassNameCore();
+        protected override Point GetClickablePointCore();
+        protected override string GetHelpTextCore();
+        protected override string GetItemStatusCore();
+        protected override string GetItemTypeCore();
+        protected override AutomationPeer GetLabeledByCore();
+        protected override string GetNameCore();
+        protected override AutomationOrientation GetOrientationCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        protected override bool HasKeyboardFocusCore();
+        protected override bool IsContentElementCore();
+        protected override bool IsControlElementCore();
+        protected override bool IsEnabledCore();
+        protected override bool IsKeyboardFocusableCore();
+        protected override bool IsOffscreenCore();
+        protected override bool IsPasswordCore();
+        protected override bool IsRequiredForFormCore();
+        protected override void SetFocusCore();
+    }
+    public abstract class ContentTextAutomationPeer : FrameworkContentElementAutomationPeer {
+        protected ContentTextAutomationPeer(FrameworkContentElement owner);
+    }
+    public class ContextMenuAutomationPeer : FrameworkElementAutomationPeer {
+        public ContextMenuAutomationPeer(ContextMenu owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        protected override bool IsContentElementCore();
+    }
+    public sealed class DataGridAutomationPeer : ItemsControlAutomationPeer, IGridProvider, ISelectionProvider, ITableProvider {
+        public DataGridAutomationPeer(DataGrid owner);
+        int System.Windows.Automation.Provider.IGridProvider.ColumnCount { get; }
+        int System.Windows.Automation.Provider.IGridProvider.RowCount { get; }
+        bool System.Windows.Automation.Provider.ISelectionProvider.CanSelectMultiple { get; }
+        bool System.Windows.Automation.Provider.ISelectionProvider.IsSelectionRequired { get; }
+        RowOrColumnMajor System.Windows.Automation.Provider.ITableProvider.RowOrColumnMajor { get; }
+        protected override ItemAutomationPeer CreateItemAutomationPeer(object item);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override List<AutomationPeer> GetChildrenCore();
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        IRawElementProviderSimple System.Windows.Automation.Provider.IGridProvider.GetItem(int row, int column);
+        IRawElementProviderSimple[] System.Windows.Automation.Provider.ISelectionProvider.GetSelection();
+        IRawElementProviderSimple[] System.Windows.Automation.Provider.ITableProvider.GetColumnHeaders();
+        IRawElementProviderSimple[] System.Windows.Automation.Provider.ITableProvider.GetRowHeaders();
+    }
+    public sealed class DataGridCellAutomationPeer : FrameworkElementAutomationPeer {
+        public DataGridCellAutomationPeer(DataGridCell owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+    }
+    public sealed class DataGridCellItemAutomationPeer : AutomationPeer, IGridItemProvider, IInvokeProvider, IScrollItemProvider, ISelectionItemProvider, ITableItemProvider, IValueProvider, IVirtualizedItemProvider {
+        public DataGridCellItemAutomationPeer(object item, DataGridColumn dataGridColumn);
+        int System.Windows.Automation.Provider.IGridItemProvider.Column { get; }
+        int System.Windows.Automation.Provider.IGridItemProvider.ColumnSpan { get; }
+        IRawElementProviderSimple System.Windows.Automation.Provider.IGridItemProvider.ContainingGrid { get; }
+        int System.Windows.Automation.Provider.IGridItemProvider.Row { get; }
+        int System.Windows.Automation.Provider.IGridItemProvider.RowSpan { get; }
+        bool System.Windows.Automation.Provider.ISelectionItemProvider.IsSelected { get; }
+        IRawElementProviderSimple System.Windows.Automation.Provider.ISelectionItemProvider.SelectionContainer { get; }
+        bool System.Windows.Automation.Provider.IValueProvider.IsReadOnly { get; }
+        string System.Windows.Automation.Provider.IValueProvider.Value { get; }
+        protected override string GetAcceleratorKeyCore();
+        protected override string GetAccessKeyCore();
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetAutomationIdCore();
+        protected override Rect GetBoundingRectangleCore();
+        protected override List<AutomationPeer> GetChildrenCore();
+        protected override string GetClassNameCore();
+        protected override Point GetClickablePointCore();
+        protected override string GetHelpTextCore();
+        protected override string GetItemStatusCore();
+        protected override string GetItemTypeCore();
+        protected override AutomationPeer GetLabeledByCore();
+        protected override string GetNameCore();
+        protected override AutomationOrientation GetOrientationCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        protected override bool HasKeyboardFocusCore();
+        protected override bool IsContentElementCore();
+        protected override bool IsControlElementCore();
+        protected override bool IsEnabledCore();
+        protected override bool IsKeyboardFocusableCore();
+        protected override bool IsOffscreenCore();
+        protected override bool IsPasswordCore();
+        protected override bool IsRequiredForFormCore();
+        protected override void SetFocusCore();
+        void System.Windows.Automation.Provider.IInvokeProvider.Invoke();
+        void System.Windows.Automation.Provider.IScrollItemProvider.ScrollIntoView();
+        void System.Windows.Automation.Provider.ISelectionItemProvider.AddToSelection();
+        void System.Windows.Automation.Provider.ISelectionItemProvider.RemoveFromSelection();
+        void System.Windows.Automation.Provider.ISelectionItemProvider.Select();
+        IRawElementProviderSimple[] System.Windows.Automation.Provider.ITableItemProvider.GetColumnHeaderItems();
+        IRawElementProviderSimple[] System.Windows.Automation.Provider.ITableItemProvider.GetRowHeaderItems();
+        void System.Windows.Automation.Provider.IValueProvider.SetValue(string value);
+        void System.Windows.Automation.Provider.IVirtualizedItemProvider.Realize();
+    }
+    public sealed class DataGridColumnHeaderAutomationPeer : ButtonBaseAutomationPeer {
+        public DataGridColumnHeaderAutomationPeer(DataGridColumnHeader owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        protected override bool IsContentElementCore();
+    }
+    public class DataGridColumnHeaderItemAutomationPeer : ItemAutomationPeer, IInvokeProvider, IScrollItemProvider, ITransformProvider, IVirtualizedItemProvider {
+        public DataGridColumnHeaderItemAutomationPeer(object item, DataGridColumn column, DataGridColumnHeadersPresenterAutomationPeer peer);
+        bool System.Windows.Automation.Provider.ITransformProvider.CanMove { get; }
+        bool System.Windows.Automation.Provider.ITransformProvider.CanResize { get; }
+        bool System.Windows.Automation.Provider.ITransformProvider.CanRotate { get; }
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        protected override bool IsContentElementCore();
+        void System.Windows.Automation.Provider.IInvokeProvider.Invoke();
+        void System.Windows.Automation.Provider.IScrollItemProvider.ScrollIntoView();
+        void System.Windows.Automation.Provider.ITransformProvider.Move(double x, double y);
+        void System.Windows.Automation.Provider.ITransformProvider.Resize(double width, double height);
+        void System.Windows.Automation.Provider.ITransformProvider.Rotate(double degrees);
+        void System.Windows.Automation.Provider.IVirtualizedItemProvider.Realize();
+    }
+    public sealed class DataGridColumnHeadersPresenterAutomationPeer : ItemsControlAutomationPeer, IItemContainerProvider {
+        public DataGridColumnHeadersPresenterAutomationPeer(DataGridColumnHeadersPresenter owner);
+        protected override ItemAutomationPeer CreateItemAutomationPeer(object column);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override List<AutomationPeer> GetChildrenCore();
+        protected override string GetClassNameCore();
+        protected override bool IsContentElementCore();
+        IRawElementProviderSimple System.Windows.Automation.Provider.IItemContainerProvider.FindItemByProperty(IRawElementProviderSimple startAfter, int propertyId, object value);
+    }
+    public sealed class DataGridDetailsPresenterAutomationPeer : FrameworkElementAutomationPeer {
+        public DataGridDetailsPresenterAutomationPeer(DataGridDetailsPresenter owner);
+        protected override string GetClassNameCore();
+    }
+    public sealed class DataGridItemAutomationPeer : ItemAutomationPeer, IInvokeProvider, IItemContainerProvider, IScrollItemProvider, ISelectionItemProvider, ISelectionProvider {
+        public DataGridItemAutomationPeer(object item, DataGridAutomationPeer dataGridPeer);
+        bool System.Windows.Automation.Provider.ISelectionItemProvider.IsSelected { get; }
+        IRawElementProviderSimple System.Windows.Automation.Provider.ISelectionItemProvider.SelectionContainer { get; }
+        bool System.Windows.Automation.Provider.ISelectionProvider.CanSelectMultiple { get; }
+        bool System.Windows.Automation.Provider.ISelectionProvider.IsSelectionRequired { get; }
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override List<AutomationPeer> GetChildrenCore();
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        protected override AutomationPeer GetPeerFromPointCore(Point point);
+        void System.Windows.Automation.Provider.IInvokeProvider.Invoke();
+        IRawElementProviderSimple System.Windows.Automation.Provider.IItemContainerProvider.FindItemByProperty(IRawElementProviderSimple startAfter, int propertyId, object value);
+        void System.Windows.Automation.Provider.IScrollItemProvider.ScrollIntoView();
+        void System.Windows.Automation.Provider.ISelectionItemProvider.AddToSelection();
+        void System.Windows.Automation.Provider.ISelectionItemProvider.RemoveFromSelection();
+        void System.Windows.Automation.Provider.ISelectionItemProvider.Select();
+        IRawElementProviderSimple[] System.Windows.Automation.Provider.ISelectionProvider.GetSelection();
+    }
+    public sealed class DataGridRowAutomationPeer : FrameworkElementAutomationPeer {
+        public DataGridRowAutomationPeer(DataGridRow owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override List<AutomationPeer> GetChildrenCore();
+        protected override string GetClassNameCore();
+    }
+    public sealed class DataGridRowHeaderAutomationPeer : ButtonBaseAutomationPeer {
+        public DataGridRowHeaderAutomationPeer(DataGridRowHeader owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        protected override bool IsContentElementCore();
+    }
+    public sealed class DatePickerAutomationPeer : FrameworkElementAutomationPeer, IExpandCollapseProvider, IValueProvider {
+        public DatePickerAutomationPeer(DatePicker owner);
+        ExpandCollapseState System.Windows.Automation.Provider.IExpandCollapseProvider.ExpandCollapseState { get; }
+        bool System.Windows.Automation.Provider.IValueProvider.IsReadOnly { get; }
+        string System.Windows.Automation.Provider.IValueProvider.Value { get; }
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override List<AutomationPeer> GetChildrenCore();
+        protected override string GetClassNameCore();
+        protected override string GetLocalizedControlTypeCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        protected override void SetFocusCore();
+        void System.Windows.Automation.Provider.IExpandCollapseProvider.Collapse();
+        void System.Windows.Automation.Provider.IExpandCollapseProvider.Expand();
+        void System.Windows.Automation.Provider.IValueProvider.SetValue(string value);
+    }
+    public sealed class DateTimeAutomationPeer : AutomationPeer, IGridItemProvider, IInvokeProvider, ISelectionItemProvider, ITableItemProvider, IVirtualizedItemProvider {
+        int System.Windows.Automation.Provider.IGridItemProvider.Column { get; }
+        int System.Windows.Automation.Provider.IGridItemProvider.ColumnSpan { get; }
+        IRawElementProviderSimple System.Windows.Automation.Provider.IGridItemProvider.ContainingGrid { get; }
+        int System.Windows.Automation.Provider.IGridItemProvider.Row { get; }
+        int System.Windows.Automation.Provider.IGridItemProvider.RowSpan { get; }
+        bool System.Windows.Automation.Provider.ISelectionItemProvider.IsSelected { get; }
+        IRawElementProviderSimple System.Windows.Automation.Provider.ISelectionItemProvider.SelectionContainer { get; }
+        protected override string GetAcceleratorKeyCore();
+        protected override string GetAccessKeyCore();
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetAutomationIdCore();
+        protected override Rect GetBoundingRectangleCore();
+        protected override List<AutomationPeer> GetChildrenCore();
+        protected override string GetClassNameCore();
+        protected override Point GetClickablePointCore();
+        protected override string GetHelpTextCore();
+        protected override string GetItemStatusCore();
+        protected override string GetItemTypeCore();
+        protected override AutomationPeer GetLabeledByCore();
+        protected override string GetLocalizedControlTypeCore();
+        protected override string GetNameCore();
+        protected override AutomationOrientation GetOrientationCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        protected override bool HasKeyboardFocusCore();
+        protected override bool IsContentElementCore();
+        protected override bool IsControlElementCore();
+        protected override bool IsEnabledCore();
+        protected override bool IsKeyboardFocusableCore();
+        protected override bool IsOffscreenCore();
+        protected override bool IsPasswordCore();
+        protected override bool IsRequiredForFormCore();
+        protected override void SetFocusCore();
+        void System.Windows.Automation.Provider.IInvokeProvider.Invoke();
+        void System.Windows.Automation.Provider.ISelectionItemProvider.AddToSelection();
+        void System.Windows.Automation.Provider.ISelectionItemProvider.RemoveFromSelection();
+        void System.Windows.Automation.Provider.ISelectionItemProvider.Select();
+        IRawElementProviderSimple[] System.Windows.Automation.Provider.ITableItemProvider.GetColumnHeaderItems();
+        IRawElementProviderSimple[] System.Windows.Automation.Provider.ITableItemProvider.GetRowHeaderItems();
+        void System.Windows.Automation.Provider.IVirtualizedItemProvider.Realize();
+    }
+    public class DocumentAutomationPeer : ContentTextAutomationPeer {
+        public DocumentAutomationPeer(FrameworkContentElement owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override Rect GetBoundingRectangleCore();
+        protected override List<AutomationPeer> GetChildrenCore();
+        protected override string GetClassNameCore();
+        protected override Point GetClickablePointCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        protected override bool IsControlElementCore();
+        protected override bool IsOffscreenCore();
+    }
+    public class DocumentPageViewAutomationPeer : FrameworkElementAutomationPeer {
+        public DocumentPageViewAutomationPeer(DocumentPageView owner);
+        protected override string GetAutomationIdCore();
+        protected override List<AutomationPeer> GetChildrenCore();
+    }
+    public class DocumentViewerAutomationPeer : DocumentViewerBaseAutomationPeer {
+        public DocumentViewerAutomationPeer(DocumentViewer owner);
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+    }
+    public class DocumentViewerBaseAutomationPeer : FrameworkElementAutomationPeer {
+        public DocumentViewerBaseAutomationPeer(DocumentViewerBase owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override List<AutomationPeer> GetChildrenCore();
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+    }
+    public class ExpanderAutomationPeer : FrameworkElementAutomationPeer, IExpandCollapseProvider {
+        public ExpanderAutomationPeer(Expander owner);
+        ExpandCollapseState System.Windows.Automation.Provider.IExpandCollapseProvider.ExpandCollapseState { get; }
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface pattern);
+        void System.Windows.Automation.Provider.IExpandCollapseProvider.Collapse();
+        void System.Windows.Automation.Provider.IExpandCollapseProvider.Expand();
+    }
+    public class FixedPageAutomationPeer : FrameworkElementAutomationPeer {
+        public FixedPageAutomationPeer(FixedPage owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+    }
+    public class FlowDocumentPageViewerAutomationPeer : DocumentViewerBaseAutomationPeer {
+        public FlowDocumentPageViewerAutomationPeer(FlowDocumentPageViewer owner);
+        protected override List<AutomationPeer> GetChildrenCore();
+        protected override string GetClassNameCore();
+    }
+    public class FlowDocumentReaderAutomationPeer : FrameworkElementAutomationPeer, IMultipleViewProvider {
+        public FlowDocumentReaderAutomationPeer(FlowDocumentReader owner);
+        int System.Windows.Automation.Provider.IMultipleViewProvider.CurrentView { get; }
+        protected override List<AutomationPeer> GetChildrenCore();
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        int[] System.Windows.Automation.Provider.IMultipleViewProvider.GetSupportedViews();
+        string System.Windows.Automation.Provider.IMultipleViewProvider.GetViewName(int viewId);
+        void System.Windows.Automation.Provider.IMultipleViewProvider.SetCurrentView(int viewId);
+    }
+    public class FlowDocumentScrollViewerAutomationPeer : FrameworkElementAutomationPeer {
+        public FlowDocumentScrollViewerAutomationPeer(FlowDocumentScrollViewer owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override List<AutomationPeer> GetChildrenCore();
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+    }
+    public class FrameAutomationPeer : FrameworkElementAutomationPeer {
+        public FrameAutomationPeer(Frame owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+    }
+    public class FrameworkContentElementAutomationPeer : ContentElementAutomationPeer {
+        public FrameworkContentElementAutomationPeer(FrameworkContentElement owner);
+        protected override string GetAutomationIdCore();
+        protected override string GetHelpTextCore();
+        protected override AutomationPeer GetLabeledByCore();
+    }
+    public class FrameworkElementAutomationPeer : UIElementAutomationPeer {
+        public FrameworkElementAutomationPeer(FrameworkElement owner);
+        protected override string GetAutomationIdCore();
+        protected override string GetHelpTextCore();
+        protected override string GetNameCore();
+    }
+    public class GenericRootAutomationPeer : UIElementAutomationPeer {
+        public GenericRootAutomationPeer(UIElement owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override Rect GetBoundingRectangleCore();
+        protected override string GetClassNameCore();
+        protected override string GetNameCore();
+    }
+    public class GridSplitterAutomationPeer : ThumbAutomationPeer, ITransformProvider {
+        public GridSplitterAutomationPeer(GridSplitter owner);
+        bool System.Windows.Automation.Provider.ITransformProvider.CanMove { get; }
+        bool System.Windows.Automation.Provider.ITransformProvider.CanResize { get; }
+        bool System.Windows.Automation.Provider.ITransformProvider.CanRotate { get; }
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        void System.Windows.Automation.Provider.ITransformProvider.Move(double x, double y);
+        void System.Windows.Automation.Provider.ITransformProvider.Resize(double width, double height);
+        void System.Windows.Automation.Provider.ITransformProvider.Rotate(double degrees);
+    }
+    public class GridViewAutomationPeer : IGridProvider, ITableProvider, IViewAutomationPeer {
+        public GridViewAutomationPeer(GridView owner, ListView listview);
+        int System.Windows.Automation.Provider.IGridProvider.ColumnCount { get; }
+        int System.Windows.Automation.Provider.IGridProvider.RowCount { get; }
+        RowOrColumnMajor System.Windows.Automation.Provider.ITableProvider.RowOrColumnMajor { get; }
+        ItemAutomationPeer System.Windows.Automation.Peers.IViewAutomationPeer.CreateItemAutomationPeer(object item);
+        AutomationControlType System.Windows.Automation.Peers.IViewAutomationPeer.GetAutomationControlType();
+        List<AutomationPeer> System.Windows.Automation.Peers.IViewAutomationPeer.GetChildren(List<AutomationPeer> children);
+        object System.Windows.Automation.Peers.IViewAutomationPeer.GetPattern(PatternInterface patternInterface);
+        void System.Windows.Automation.Peers.IViewAutomationPeer.ItemsChanged(NotifyCollectionChangedEventArgs e);
+        void System.Windows.Automation.Peers.IViewAutomationPeer.ViewDetached();
+        IRawElementProviderSimple System.Windows.Automation.Provider.IGridProvider.GetItem(int row, int column);
+        IRawElementProviderSimple[] System.Windows.Automation.Provider.ITableProvider.GetColumnHeaders();
+        IRawElementProviderSimple[] System.Windows.Automation.Provider.ITableProvider.GetRowHeaders();
+    }
+    public class GridViewCellAutomationPeer : FrameworkElementAutomationPeer, IGridItemProvider, ITableItemProvider {
+        int System.Windows.Automation.Provider.IGridItemProvider.Column { get; }
+        int System.Windows.Automation.Provider.IGridItemProvider.ColumnSpan { get; }
+        IRawElementProviderSimple System.Windows.Automation.Provider.IGridItemProvider.ContainingGrid { get; }
+        int System.Windows.Automation.Provider.IGridItemProvider.Row { get; }
+        int System.Windows.Automation.Provider.IGridItemProvider.RowSpan { get; }
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        protected override bool IsControlElementCore();
+        IRawElementProviderSimple[] System.Windows.Automation.Provider.ITableItemProvider.GetColumnHeaderItems();
+        IRawElementProviderSimple[] System.Windows.Automation.Provider.ITableItemProvider.GetRowHeaderItems();
+    }
+    public class GridViewColumnHeaderAutomationPeer : FrameworkElementAutomationPeer, IInvokeProvider, ITransformProvider {
+        public GridViewColumnHeaderAutomationPeer(GridViewColumnHeader owner);
+        bool System.Windows.Automation.Provider.ITransformProvider.CanMove { get; }
+        bool System.Windows.Automation.Provider.ITransformProvider.CanResize { get; }
+        bool System.Windows.Automation.Provider.ITransformProvider.CanRotate { get; }
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        protected override bool IsContentElementCore();
+        void System.Windows.Automation.Provider.IInvokeProvider.Invoke();
+        void System.Windows.Automation.Provider.ITransformProvider.Move(double x, double y);
+        void System.Windows.Automation.Provider.ITransformProvider.Resize(double width, double height);
+        void System.Windows.Automation.Provider.ITransformProvider.Rotate(double degrees);
+    }
+    public class GridViewHeaderRowPresenterAutomationPeer : FrameworkElementAutomationPeer {
+        public GridViewHeaderRowPresenterAutomationPeer(GridViewHeaderRowPresenter owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override List<AutomationPeer> GetChildrenCore();
+        protected override string GetClassNameCore();
+        protected override bool IsContentElementCore();
+    }
+    public class GridViewItemAutomationPeer : ListBoxItemAutomationPeer {
+        public GridViewItemAutomationPeer(object owner, ListViewAutomationPeer listviewAP);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override List<AutomationPeer> GetChildrenCore();
+        protected override string GetClassNameCore();
+    }
+    public class GroupBoxAutomationPeer : FrameworkElementAutomationPeer {
+        public GroupBoxAutomationPeer(GroupBox owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        protected override string GetNameCore();
+    }
+    public class GroupItemAutomationPeer : FrameworkElementAutomationPeer {
+        public GroupItemAutomationPeer(GroupItem owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override List<AutomationPeer> GetChildrenCore();
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+    }
+    public sealed class HostedWindowWrapper {
+        public HostedWindowWrapper(IntPtr hwnd);
+    }
+    public class HyperlinkAutomationPeer : TextElementAutomationPeer, IInvokeProvider {
+        public HyperlinkAutomationPeer(Hyperlink owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        protected override string GetNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        protected override bool IsControlElementCore();
+        void System.Windows.Automation.Provider.IInvokeProvider.Invoke();
+    }
+    public class ImageAutomationPeer : FrameworkElementAutomationPeer {
+        public ImageAutomationPeer(Image owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+    }
+    public class InkCanvasAutomationPeer : FrameworkElementAutomationPeer {
+        public InkCanvasAutomationPeer(InkCanvas owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+    }
+    public class InkPresenterAutomationPeer : FrameworkElementAutomationPeer {
+        public InkPresenterAutomationPeer(InkPresenter owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+    }
+    public abstract class ItemAutomationPeer : AutomationPeer, IVirtualizedItemProvider {
+        protected ItemAutomationPeer(object item, ItemsControlAutomationPeer itemsControlAutomationPeer);
+        public object Item { get; }
+        public ItemsControlAutomationPeer ItemsControlAutomationPeer { get; internal set; }
+        protected override string GetAcceleratorKeyCore();
+        protected override string GetAccessKeyCore();
+        protected override string GetAutomationIdCore();
+        protected override Rect GetBoundingRectangleCore();
+        protected override List<AutomationPeer> GetChildrenCore();
+        protected override Point GetClickablePointCore();
+        protected override string GetHelpTextCore();
+        protected override string GetItemStatusCore();
+        protected override string GetItemTypeCore();
+        protected override AutomationPeer GetLabeledByCore();
+        protected override string GetNameCore();
+        protected override AutomationOrientation GetOrientationCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        protected override bool HasKeyboardFocusCore();
+        protected override bool IsContentElementCore();
+        protected override bool IsControlElementCore();
+        protected override bool IsEnabledCore();
+        protected override bool IsKeyboardFocusableCore();
+        protected override bool IsOffscreenCore();
+        protected override bool IsPasswordCore();
+        protected override bool IsRequiredForFormCore();
+        protected override void SetFocusCore();
+        void System.Windows.Automation.Provider.IVirtualizedItemProvider.Realize();
+    }
+    public abstract class ItemsControlAutomationPeer : FrameworkElementAutomationPeer, IItemContainerProvider {
+        protected ItemsControlAutomationPeer(ItemsControl owner);
+        protected virtual bool IsVirtualized { get; }
+        protected abstract ItemAutomationPeer CreateItemAutomationPeer(object item);
+        protected internal virtual ItemAutomationPeer FindOrCreateItemAutomationPeer(object item);
+        protected override List<AutomationPeer> GetChildrenCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        IRawElementProviderSimple System.Windows.Automation.Provider.IItemContainerProvider.FindItemByProperty(IRawElementProviderSimple startAfter, int propertyId, object value);
+    }
+    public interface IViewAutomationPeer {
+        ItemAutomationPeer CreateItemAutomationPeer(object item);
+        AutomationControlType GetAutomationControlType();
+        List<AutomationPeer> GetChildren(List<AutomationPeer> children);
+        object GetPattern(PatternInterface patternInterface);
+        void ItemsChanged(NotifyCollectionChangedEventArgs e);
+        void ViewDetached();
+    }
+    public class LabelAutomationPeer : FrameworkElementAutomationPeer {
+        public LabelAutomationPeer(Label owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        protected override string GetNameCore();
+    }
+    public class ListBoxAutomationPeer : SelectorAutomationPeer {
+        public ListBoxAutomationPeer(ListBox owner);
+        protected override ItemAutomationPeer CreateItemAutomationPeer(object item);
+        protected override string GetClassNameCore();
+    }
+    public class ListBoxItemAutomationPeer : SelectorItemAutomationPeer, IScrollItemProvider {
+        public ListBoxItemAutomationPeer(object owner, SelectorAutomationPeer selectorAutomationPeer);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        void System.Windows.Automation.Provider.IScrollItemProvider.ScrollIntoView();
+    }
+    public class ListBoxItemWrapperAutomationPeer : FrameworkElementAutomationPeer {
+        public ListBoxItemWrapperAutomationPeer(ListBoxItem owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+    }
+    public class ListViewAutomationPeer : ListBoxAutomationPeer {
+        public ListViewAutomationPeer(ListView owner);
+        protected internal IViewAutomationPeer ViewAutomationPeer { get; set; }
+        protected override ItemAutomationPeer CreateItemAutomationPeer(object item);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override List<AutomationPeer> GetChildrenCore();
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+    }
+    public class MediaElementAutomationPeer : FrameworkElementAutomationPeer {
+        public MediaElementAutomationPeer(MediaElement owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+    }
+    public class MenuAutomationPeer : FrameworkElementAutomationPeer {
+        public MenuAutomationPeer(Menu owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        protected override bool IsContentElementCore();
+    }
+    public class MenuItemAutomationPeer : FrameworkElementAutomationPeer, IExpandCollapseProvider, IInvokeProvider, IToggleProvider {
+        public MenuItemAutomationPeer(MenuItem owner);
+        ExpandCollapseState System.Windows.Automation.Provider.IExpandCollapseProvider.ExpandCollapseState { get; }
+        ToggleState System.Windows.Automation.Provider.IToggleProvider.ToggleState { get; }
+        protected override string GetAccessKeyCore();
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override List<AutomationPeer> GetChildrenCore();
+        protected override string GetClassNameCore();
+        protected override string GetNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        void System.Windows.Automation.Provider.IExpandCollapseProvider.Collapse();
+        void System.Windows.Automation.Provider.IExpandCollapseProvider.Expand();
+        void System.Windows.Automation.Provider.IInvokeProvider.Invoke();
+        void System.Windows.Automation.Provider.IToggleProvider.Toggle();
+    }
+    public class NavigationWindowAutomationPeer : WindowAutomationPeer {
+        public NavigationWindowAutomationPeer(NavigationWindow owner);
+        protected override string GetClassNameCore();
+    }
+    public class PasswordBoxAutomationPeer : TextAutomationPeer, IValueProvider {
+        public PasswordBoxAutomationPeer(PasswordBox owner);
+        bool System.Windows.Automation.Provider.IValueProvider.IsReadOnly { get; }
+        string System.Windows.Automation.Provider.IValueProvider.Value { get; }
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        protected override bool IsPasswordCore();
+        void System.Windows.Automation.Provider.IValueProvider.SetValue(string value);
+    }
+    public enum PatternInterface {
+        Dock = 12,
+        ExpandCollapse = 6,
+        Grid = 7,
+        GridItem = 8,
+        Invoke = 0,
+        ItemContainer = 18,
+        MultipleView = 9,
+        RangeValue = 3,
+        Scroll = 4,
+        ScrollItem = 5,
+        Selection = 1,
+        SelectionItem = 11,
+        SynchronizedInput = 20,
+        Table = 13,
+        TableItem = 14,
+        Text = 17,
+        Toggle = 15,
+        Transform = 16,
+        Value = 2,
+        VirtualizedItem = 19,
+        Window = 10,
+    }
+    public class ProgressBarAutomationPeer : RangeBaseAutomationPeer, IRangeValueProvider {
+        public ProgressBarAutomationPeer(ProgressBar owner);
+        bool System.Windows.Automation.Provider.IRangeValueProvider.IsReadOnly { get; }
+        double System.Windows.Automation.Provider.IRangeValueProvider.LargeChange { get; }
+        double System.Windows.Automation.Provider.IRangeValueProvider.SmallChange { get; }
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        void System.Windows.Automation.Provider.IRangeValueProvider.SetValue(double val);
+    }
+    public class RadioButtonAutomationPeer : ToggleButtonAutomationPeer, ISelectionItemProvider {
+        public RadioButtonAutomationPeer(RadioButton owner);
+        bool System.Windows.Automation.Provider.ISelectionItemProvider.IsSelected { get; }
+        IRawElementProviderSimple System.Windows.Automation.Provider.ISelectionItemProvider.SelectionContainer { get; }
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        void System.Windows.Automation.Provider.ISelectionItemProvider.AddToSelection();
+        void System.Windows.Automation.Provider.ISelectionItemProvider.RemoveFromSelection();
+        void System.Windows.Automation.Provider.ISelectionItemProvider.Select();
+    }
+    public class RangeBaseAutomationPeer : FrameworkElementAutomationPeer, IRangeValueProvider {
+        public RangeBaseAutomationPeer(RangeBase owner);
+        bool System.Windows.Automation.Provider.IRangeValueProvider.IsReadOnly { get; }
+        double System.Windows.Automation.Provider.IRangeValueProvider.LargeChange { get; }
+        double System.Windows.Automation.Provider.IRangeValueProvider.Maximum { get; }
+        double System.Windows.Automation.Provider.IRangeValueProvider.Minimum { get; }
+        double System.Windows.Automation.Provider.IRangeValueProvider.SmallChange { get; }
+        double System.Windows.Automation.Provider.IRangeValueProvider.Value { get; }
+        public override object GetPattern(PatternInterface patternInterface);
+        void System.Windows.Automation.Provider.IRangeValueProvider.SetValue(double val);
+    }
+    public class RepeatButtonAutomationPeer : ButtonBaseAutomationPeer, IInvokeProvider {
+        public RepeatButtonAutomationPeer(RepeatButton owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        void System.Windows.Automation.Provider.IInvokeProvider.Invoke();
+    }
+    public class RibbonApplicationMenuAutomationPeer : RibbonMenuButtonAutomationPeer {
+        public RibbonApplicationMenuAutomationPeer(RibbonApplicationMenu owner);
+        protected override List<AutomationPeer> GetChildrenCore();
+    }
+    public class RibbonAutomationPeer : SelectorAutomationPeer, IExpandCollapseProvider, ISelectionProvider {
+        public RibbonAutomationPeer(Ribbon owner);
+        public ExpandCollapseState ExpandCollapseState { get; }
+        bool System.Windows.Automation.Provider.ISelectionProvider.CanSelectMultiple { get; }
+        bool System.Windows.Automation.Provider.ISelectionProvider.IsSelectionRequired { get; }
+        public void Collapse();
+        protected override ItemAutomationPeer CreateItemAutomationPeer(object item);
+        public void Expand();
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override List<AutomationPeer> GetChildrenCore();
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        protected override bool IsOffscreenCore();
+        protected override void SetFocusCore();
+    }
+    public class RibbonButtonAutomationPeer : ButtonAutomationPeer {
+        public RibbonButtonAutomationPeer(RibbonButton owner);
+        protected override string GetAccessKeyCore();
+        protected override string GetClassNameCore();
+        protected override string GetHelpTextCore();
+        protected override string GetNameCore();
+    }
+    public class RibbonCheckBoxAutomationPeer : CheckBoxAutomationPeer {
+        public RibbonCheckBoxAutomationPeer(RibbonCheckBox owner);
+        protected override string GetAccessKeyCore();
+        protected override string GetClassNameCore();
+        protected override string GetHelpTextCore();
+        protected override string GetNameCore();
+    }
+    public class RibbonComboBoxAutomationPeer : RibbonMenuButtonAutomationPeer, IValueProvider {
+        public RibbonComboBoxAutomationPeer(RibbonComboBox owner);
+        public bool IsReadOnly { get; }
+        public string Value { get; }
+        protected override List<AutomationPeer> GetChildrenCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        protected override void SetFocusCore();
+        public void SetValue(string value);
+    }
+    public class RibbonContextMenuAutomationPeer : ItemsControlAutomationPeer {
+        public RibbonContextMenuAutomationPeer(RibbonContextMenu owner);
+        protected override ItemAutomationPeer CreateItemAutomationPeer(object item);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        protected override bool IsContentElementCore();
+    }
+    public class RibbonContextualTabGroupAutomationPeer : FrameworkElementAutomationPeer {
+        public RibbonContextualTabGroupAutomationPeer(RibbonContextualTabGroup owner);
+        protected override string GetClassNameCore();
+        protected override string GetNameCore();
+    }
+    public class RibbonContextualTabGroupDataAutomationPeer : ItemAutomationPeer, IInvokeProvider {
+        public RibbonContextualTabGroupDataAutomationPeer(object item, RibbonContextualTabGroupItemsControlAutomationPeer owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        protected override bool IsContentElementCore();
+        void System.Windows.Automation.Provider.IInvokeProvider.Invoke();
+    }
+    public class RibbonContextualTabGroupItemsControlAutomationPeer : ItemsControlAutomationPeer {
+        public RibbonContextualTabGroupItemsControlAutomationPeer(RibbonContextualTabGroupItemsControl owner);
+        protected override ItemAutomationPeer CreateItemAutomationPeer(object item);
+        public override object GetPattern(PatternInterface patternInterface);
+    }
+    public class RibbonControlAutomationPeer : FrameworkElementAutomationPeer {
+        public RibbonControlAutomationPeer(FrameworkElement owner);
+        protected override string GetClassNameCore();
+    }
+    public class RibbonControlDataAutomationPeer : ItemAutomationPeer {
+        public RibbonControlDataAutomationPeer(object item, ItemsControlAutomationPeer itemsControlPeer);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+    }
+    public class RibbonControlGroupAutomationPeer : ItemsControlAutomationPeer {
+        public RibbonControlGroupAutomationPeer(RibbonControlGroup owner);
+        protected override ItemAutomationPeer CreateItemAutomationPeer(object item);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+    }
+    public class RibbonGalleryAutomationPeer : ItemsControlAutomationPeer, ISelectionProvider {
+        public RibbonGalleryAutomationPeer(RibbonGallery owner);
+        bool System.Windows.Automation.Provider.ISelectionProvider.CanSelectMultiple { get; }
+        bool System.Windows.Automation.Provider.ISelectionProvider.IsSelectionRequired { get; }
+        protected override ItemAutomationPeer CreateItemAutomationPeer(object item);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override List<AutomationPeer> GetChildrenCore();
+        protected override string GetClassNameCore();
+        protected override string GetHelpTextCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        IRawElementProviderSimple[] System.Windows.Automation.Provider.ISelectionProvider.GetSelection();
+    }
+    public class RibbonGalleryCategoryAutomationPeer : ItemsControlAutomationPeer {
+        public RibbonGalleryCategoryAutomationPeer(RibbonGalleryCategory owner);
+        protected override ItemAutomationPeer CreateItemAutomationPeer(object item);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override List<AutomationPeer> GetChildrenCore();
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+    }
+    public class RibbonGalleryCategoryDataAutomationPeer : ItemAutomationPeer, IScrollItemProvider {
+        public RibbonGalleryCategoryDataAutomationPeer(object owner, ItemsControlAutomationPeer itemsControlAutomationPeer);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        void System.Windows.Automation.Provider.IScrollItemProvider.ScrollIntoView();
+    }
+    public class RibbonGalleryItemAutomationPeer : FrameworkElementAutomationPeer {
+        public RibbonGalleryItemAutomationPeer(RibbonGalleryItem owner);
+        protected override string GetAccessKeyCore();
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        protected override string GetHelpTextCore();
+    }
+    public class RibbonGalleryItemDataAutomationPeer : ItemAutomationPeer, IScrollItemProvider, ISelectionItemProvider {
+        public RibbonGalleryItemDataAutomationPeer(object owner, ItemsControlAutomationPeer itemsControlAutomationPeer, RibbonGalleryCategoryDataAutomationPeer parentCategoryDataAutomationPeer);
+        public RibbonGalleryCategoryDataAutomationPeer ParentCategoryDataAutomationPeer { get; }
+        bool System.Windows.Automation.Provider.ISelectionItemProvider.IsSelected { get; }
+        IRawElementProviderSimple System.Windows.Automation.Provider.ISelectionItemProvider.SelectionContainer { get; }
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        void System.Windows.Automation.Provider.IScrollItemProvider.ScrollIntoView();
+        void System.Windows.Automation.Provider.ISelectionItemProvider.AddToSelection();
+        void System.Windows.Automation.Provider.ISelectionItemProvider.RemoveFromSelection();
+        void System.Windows.Automation.Provider.ISelectionItemProvider.Select();
+    }
+    public class RibbonGroupAutomationPeer : ItemsControlAutomationPeer {
+        public RibbonGroupAutomationPeer(RibbonGroup owner);
+        protected override ItemAutomationPeer CreateItemAutomationPeer(object item);
+        protected override List<AutomationPeer> GetChildrenCore();
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        protected override void SetFocusCore();
+    }
+    public class RibbonGroupDataAutomationPeer : ItemAutomationPeer, IExpandCollapseProvider, IScrollItemProvider {
+        public RibbonGroupDataAutomationPeer(object item, RibbonTabAutomationPeer itemsControlPeer);
+        ExpandCollapseState System.Windows.Automation.Provider.IExpandCollapseProvider.ExpandCollapseState { get; }
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        void System.Windows.Automation.Provider.IExpandCollapseProvider.Collapse();
+        void System.Windows.Automation.Provider.IExpandCollapseProvider.Expand();
+        void System.Windows.Automation.Provider.IScrollItemProvider.ScrollIntoView();
+    }
+    public class RibbonGroupHeaderAutomationPeer : FrameworkElementAutomationPeer {
+        public RibbonGroupHeaderAutomationPeer(FrameworkElement owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        protected override string GetNameCore();
+        protected override bool IsContentElementCore();
+    }
+    public class RibbonMenuButtonAutomationPeer : ItemsControlAutomationPeer, IExpandCollapseProvider, ITransformProvider {
+        public RibbonMenuButtonAutomationPeer(RibbonMenuButton owner);
+        ExpandCollapseState System.Windows.Automation.Provider.IExpandCollapseProvider.ExpandCollapseState { get; }
+        bool System.Windows.Automation.Provider.ITransformProvider.CanMove { get; }
+        bool System.Windows.Automation.Provider.ITransformProvider.CanResize { get; }
+        bool System.Windows.Automation.Provider.ITransformProvider.CanRotate { get; }
+        protected override ItemAutomationPeer CreateItemAutomationPeer(object item);
+        protected override string GetAccessKeyCore();
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override List<AutomationPeer> GetChildrenCore();
+        protected override string GetClassNameCore();
+        protected override string GetHelpTextCore();
+        protected override string GetNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        void System.Windows.Automation.Provider.IExpandCollapseProvider.Collapse();
+        void System.Windows.Automation.Provider.IExpandCollapseProvider.Expand();
+        void System.Windows.Automation.Provider.ITransformProvider.Move(double x, double y);
+        void System.Windows.Automation.Provider.ITransformProvider.Resize(double width, double height);
+        void System.Windows.Automation.Provider.ITransformProvider.Rotate(double degrees);
+    }
+    public class RibbonMenuItemAutomationPeer : ItemsControlAutomationPeer {
+        public RibbonMenuItemAutomationPeer(RibbonMenuItem owner);
+        protected override ItemAutomationPeer CreateItemAutomationPeer(object item);
+        protected override string GetAccessKeyCore();
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        protected override string GetHelpTextCore();
+    }
+    public class RibbonMenuItemDataAutomationPeer : ItemAutomationPeer, IExpandCollapseProvider, IInvokeProvider, IToggleProvider, ITransformProvider {
+        public RibbonMenuItemDataAutomationPeer(object item, ItemsControlAutomationPeer itemsControlPeer);
+        ExpandCollapseState System.Windows.Automation.Provider.IExpandCollapseProvider.ExpandCollapseState { get; }
+        ToggleState System.Windows.Automation.Provider.IToggleProvider.ToggleState { get; }
+        bool System.Windows.Automation.Provider.ITransformProvider.CanMove { get; }
+        bool System.Windows.Automation.Provider.ITransformProvider.CanResize { get; }
+        bool System.Windows.Automation.Provider.ITransformProvider.CanRotate { get; }
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        void System.Windows.Automation.Provider.IExpandCollapseProvider.Collapse();
+        void System.Windows.Automation.Provider.IExpandCollapseProvider.Expand();
+        void System.Windows.Automation.Provider.IInvokeProvider.Invoke();
+        void System.Windows.Automation.Provider.IToggleProvider.Toggle();
+        void System.Windows.Automation.Provider.ITransformProvider.Move(double x, double y);
+        void System.Windows.Automation.Provider.ITransformProvider.Resize(double width, double height);
+        void System.Windows.Automation.Provider.ITransformProvider.Rotate(double degrees);
+    }
+    public class RibbonQuickAccessToolBarAutomationPeer : ItemsControlAutomationPeer, IExpandCollapseProvider {
+        public RibbonQuickAccessToolBarAutomationPeer(RibbonQuickAccessToolBar owner);
+        public ExpandCollapseState ExpandCollapseState { get; }
+        public void Collapse();
+        protected override ItemAutomationPeer CreateItemAutomationPeer(object item);
+        public void Expand();
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override List<AutomationPeer> GetChildrenCore();
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+    }
+    public class RibbonRadioButtonAutomationPeer : RadioButtonAutomationPeer {
+        public RibbonRadioButtonAutomationPeer(RibbonRadioButton owner);
+        protected override string GetAccessKeyCore();
+        protected override string GetClassNameCore();
+        protected override string GetHelpTextCore();
+        protected override string GetNameCore();
+    }
+    public class RibbonSeparatorAutomationPeer : SeparatorAutomationPeer {
+        public RibbonSeparatorAutomationPeer(RibbonSeparator owner);
+        protected override string GetClassNameCore();
+        protected override string GetNameCore();
+    }
+    public class RibbonSplitButtonAutomationPeer : RibbonMenuButtonAutomationPeer, IInvokeProvider, IToggleProvider {
+        public RibbonSplitButtonAutomationPeer(RibbonSplitButton owner);
+        ToggleState System.Windows.Automation.Provider.IToggleProvider.ToggleState { get; }
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        void System.Windows.Automation.Provider.IInvokeProvider.Invoke();
+        void System.Windows.Automation.Provider.IToggleProvider.Toggle();
+    }
+    public class RibbonTabAutomationPeer : ItemsControlAutomationPeer {
+        public RibbonTabAutomationPeer(RibbonTab owner);
+        protected override ItemAutomationPeer CreateItemAutomationPeer(object item);
+        protected override Rect GetBoundingRectangleCore();
+        protected override List<AutomationPeer> GetChildrenCore();
+        protected override string GetClassNameCore();
+    }
+    public class RibbonTabDataAutomationPeer : SelectorItemAutomationPeer, IExpandCollapseProvider, IScrollItemProvider, ISelectionItemProvider {
+        public RibbonTabDataAutomationPeer(object item, RibbonAutomationPeer itemsControlPeer);
+        ExpandCollapseState System.Windows.Automation.Provider.IExpandCollapseProvider.ExpandCollapseState { get; }
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        void System.Windows.Automation.Provider.IExpandCollapseProvider.Collapse();
+        void System.Windows.Automation.Provider.IExpandCollapseProvider.Expand();
+        void System.Windows.Automation.Provider.IScrollItemProvider.ScrollIntoView();
+        void System.Windows.Automation.Provider.ISelectionItemProvider.AddToSelection();
+        void System.Windows.Automation.Provider.ISelectionItemProvider.RemoveFromSelection();
+    }
+    public class RibbonTabHeaderAutomationPeer : FrameworkElementAutomationPeer {
+        public RibbonTabHeaderAutomationPeer(RibbonTabHeader owner);
+        protected override string GetClassNameCore();
+    }
+    public class RibbonTabHeaderDataAutomationPeer : ItemAutomationPeer {
+        public RibbonTabHeaderDataAutomationPeer(object item, RibbonTabHeaderItemsControlAutomationPeer itemsControlPeer);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        protected override bool IsContentElementCore();
+    }
+    public class RibbonTabHeaderItemsControlAutomationPeer : ItemsControlAutomationPeer {
+        public RibbonTabHeaderItemsControlAutomationPeer(RibbonTabHeaderItemsControl owner);
+        protected override ItemAutomationPeer CreateItemAutomationPeer(object item);
+    }
+    public class RibbonTextBoxAutomationPeer : TextBoxAutomationPeer, IInvokeProvider {
+        public RibbonTextBoxAutomationPeer(RibbonTextBox owner);
+        protected override string GetAcceleratorKeyCore();
+        protected override string GetAccessKeyCore();
+        protected override string GetClassNameCore();
+        protected override string GetHelpTextCore();
+        protected override string GetNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        void System.Windows.Automation.Provider.IInvokeProvider.Invoke();
+    }
+    public class RibbonTitleAutomationPeer : FrameworkElementAutomationPeer {
+        public RibbonTitleAutomationPeer(FrameworkElement owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        protected override string GetNameCore();
+        protected override bool IsContentElementCore();
+    }
+    public class RibbonToggleButtonAutomationPeer : ToggleButtonAutomationPeer {
+        public RibbonToggleButtonAutomationPeer(RibbonToggleButton owner);
+        protected override string GetAccessKeyCore();
+        protected override string GetClassNameCore();
+        protected override string GetHelpTextCore();
+        protected override string GetNameCore();
+    }
+    public class RibbonToolTipAutomationPeer : ToolTipAutomationPeer {
+        public RibbonToolTipAutomationPeer(RibbonToolTip owner);
+        protected override string GetClassNameCore();
+        protected override string GetNameCore();
+    }
+    public class RibbonTwoLineTextAutomationPeer : FrameworkElementAutomationPeer {
+        public RibbonTwoLineTextAutomationPeer(RibbonTwoLineText owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        protected override string GetNameCore();
+        protected override bool IsControlElementCore();
+    }
+    public class RichTextBoxAutomationPeer : TextAutomationPeer {
+        public RichTextBoxAutomationPeer(RichTextBox owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override List<AutomationPeer> GetChildrenCore();
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+    }
+    public class ScrollBarAutomationPeer : RangeBaseAutomationPeer {
+        public ScrollBarAutomationPeer(ScrollBar owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        protected override Point GetClickablePointCore();
+        protected override AutomationOrientation GetOrientationCore();
+        protected override bool IsContentElementCore();
+    }
+    public class ScrollViewerAutomationPeer : FrameworkElementAutomationPeer, IScrollProvider {
+        public ScrollViewerAutomationPeer(ScrollViewer owner);
+        bool System.Windows.Automation.Provider.IScrollProvider.HorizontallyScrollable { get; }
+        double System.Windows.Automation.Provider.IScrollProvider.HorizontalScrollPercent { get; }
+        double System.Windows.Automation.Provider.IScrollProvider.HorizontalViewSize { get; }
+        bool System.Windows.Automation.Provider.IScrollProvider.VerticallyScrollable { get; }
+        double System.Windows.Automation.Provider.IScrollProvider.VerticalScrollPercent { get; }
+        double System.Windows.Automation.Provider.IScrollProvider.VerticalViewSize { get; }
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        protected override bool IsControlElementCore();
+        void System.Windows.Automation.Provider.IScrollProvider.Scroll(ScrollAmount horizontalAmount, ScrollAmount verticalAmount);
+        void System.Windows.Automation.Provider.IScrollProvider.SetScrollPercent(double horizontalPercent, double verticalPercent);
+    }
+    public abstract class SelectorAutomationPeer : ItemsControlAutomationPeer, ISelectionProvider {
+        protected SelectorAutomationPeer(Selector owner);
+        bool System.Windows.Automation.Provider.ISelectionProvider.CanSelectMultiple { get; }
+        bool System.Windows.Automation.Provider.ISelectionProvider.IsSelectionRequired { get; }
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        IRawElementProviderSimple[] System.Windows.Automation.Provider.ISelectionProvider.GetSelection();
+    }
+    public abstract class SelectorItemAutomationPeer : ItemAutomationPeer, ISelectionItemProvider {
+        protected SelectorItemAutomationPeer(object owner, SelectorAutomationPeer selectorAutomationPeer);
+        bool System.Windows.Automation.Provider.ISelectionItemProvider.IsSelected { get; }
+        IRawElementProviderSimple System.Windows.Automation.Provider.ISelectionItemProvider.SelectionContainer { get; }
+        public override object GetPattern(PatternInterface patternInterface);
+        void System.Windows.Automation.Provider.ISelectionItemProvider.AddToSelection();
+        void System.Windows.Automation.Provider.ISelectionItemProvider.RemoveFromSelection();
+        void System.Windows.Automation.Provider.ISelectionItemProvider.Select();
+    }
+    public class SeparatorAutomationPeer : FrameworkElementAutomationPeer {
+        public SeparatorAutomationPeer(Separator owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        protected override bool IsContentElementCore();
+    }
+    public class SliderAutomationPeer : RangeBaseAutomationPeer {
+        public SliderAutomationPeer(Slider owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        protected override Point GetClickablePointCore();
+    }
+    public class StatusBarAutomationPeer : FrameworkElementAutomationPeer {
+        public StatusBarAutomationPeer(StatusBar owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override List<AutomationPeer> GetChildrenCore();
+        protected override string GetClassNameCore();
+    }
+    public class StatusBarItemAutomationPeer : FrameworkElementAutomationPeer {
+        public StatusBarItemAutomationPeer(StatusBarItem owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+    }
+    public class TabControlAutomationPeer : SelectorAutomationPeer, ISelectionProvider {
+        public TabControlAutomationPeer(TabControl owner);
+        bool System.Windows.Automation.Provider.ISelectionProvider.IsSelectionRequired { get; }
+        protected override ItemAutomationPeer CreateItemAutomationPeer(object item);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        protected override Point GetClickablePointCore();
+    }
+    public class TabItemAutomationPeer : SelectorItemAutomationPeer, ISelectionItemProvider {
+        public TabItemAutomationPeer(object owner, TabControlAutomationPeer tabControlAutomationPeer);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override List<AutomationPeer> GetChildrenCore();
+        protected override string GetClassNameCore();
+        protected override string GetNameCore();
+        void System.Windows.Automation.Provider.ISelectionItemProvider.RemoveFromSelection();
+    }
+    public class TabItemWrapperAutomationPeer : FrameworkElementAutomationPeer {
+        public TabItemWrapperAutomationPeer(TabItem owner);
+    }
+    public class TableAutomationPeer : TextElementAutomationPeer, IGridProvider {
+        public TableAutomationPeer(Table owner);
+        int System.Windows.Automation.Provider.IGridProvider.ColumnCount { get; }
+        int System.Windows.Automation.Provider.IGridProvider.RowCount { get; }
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        protected override bool IsControlElementCore();
+        IRawElementProviderSimple System.Windows.Automation.Provider.IGridProvider.GetItem(int row, int column);
+    }
+    public class TableCellAutomationPeer : TextElementAutomationPeer, IGridItemProvider {
+        public TableCellAutomationPeer(TableCell owner);
+        int System.Windows.Automation.Provider.IGridItemProvider.Column { get; }
+        int System.Windows.Automation.Provider.IGridItemProvider.ColumnSpan { get; }
+        IRawElementProviderSimple System.Windows.Automation.Provider.IGridItemProvider.ContainingGrid { get; }
+        int System.Windows.Automation.Provider.IGridItemProvider.Row { get; }
+        int System.Windows.Automation.Provider.IGridItemProvider.RowSpan { get; }
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        protected override string GetLocalizedControlTypeCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        protected override bool IsControlElementCore();
+    }
+    public abstract class TextAutomationPeer : FrameworkElementAutomationPeer {
+        protected TextAutomationPeer(FrameworkElement owner);
+        protected override string GetNameCore();
+    }
+    public class TextBlockAutomationPeer : FrameworkElementAutomationPeer {
+        public TextBlockAutomationPeer(TextBlock owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override List<AutomationPeer> GetChildrenCore();
+        protected override string GetClassNameCore();
+        protected override bool IsControlElementCore();
+    }
+    public class TextBoxAutomationPeer : TextAutomationPeer, IValueProvider {
+        public TextBoxAutomationPeer(TextBox owner);
+        bool System.Windows.Automation.Provider.IValueProvider.IsReadOnly { get; }
+        string System.Windows.Automation.Provider.IValueProvider.Value { get; }
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        void System.Windows.Automation.Provider.IValueProvider.SetValue(string value);
+    }
+    public class TextElementAutomationPeer : ContentTextAutomationPeer {
+        public TextElementAutomationPeer(TextElement owner);
+        protected override Rect GetBoundingRectangleCore();
+        protected override List<AutomationPeer> GetChildrenCore();
+        protected override Point GetClickablePointCore();
+        protected override bool IsOffscreenCore();
+    }
+    public class ThumbAutomationPeer : FrameworkElementAutomationPeer {
+        public ThumbAutomationPeer(Thumb owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        protected override bool IsContentElementCore();
+    }
+    public class ToggleButtonAutomationPeer : ButtonBaseAutomationPeer, IToggleProvider {
+        public ToggleButtonAutomationPeer(ToggleButton owner);
+        ToggleState System.Windows.Automation.Provider.IToggleProvider.ToggleState { get; }
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        void System.Windows.Automation.Provider.IToggleProvider.Toggle();
+    }
+    public class ToolBarAutomationPeer : FrameworkElementAutomationPeer {
+        public ToolBarAutomationPeer(ToolBar owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+    }
+    public class ToolTipAutomationPeer : FrameworkElementAutomationPeer {
+        public ToolTipAutomationPeer(ToolTip owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+    }
+    public class TreeViewAutomationPeer : ItemsControlAutomationPeer, ISelectionProvider {
+        public TreeViewAutomationPeer(TreeView owner);
+        bool System.Windows.Automation.Provider.ISelectionProvider.CanSelectMultiple { get; }
+        bool System.Windows.Automation.Provider.ISelectionProvider.IsSelectionRequired { get; }
+        protected override ItemAutomationPeer CreateItemAutomationPeer(object item);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override List<AutomationPeer> GetChildrenCore();
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        IRawElementProviderSimple[] System.Windows.Automation.Provider.ISelectionProvider.GetSelection();
+    }
+    public class TreeViewDataItemAutomationPeer : ItemAutomationPeer, IExpandCollapseProvider, IScrollItemProvider, ISelectionItemProvider {
+        public TreeViewDataItemAutomationPeer(object item, ItemsControlAutomationPeer itemsControlAutomationPeer, TreeViewDataItemAutomationPeer parentDataItemAutomationPeer);
+        public TreeViewDataItemAutomationPeer ParentDataItemAutomationPeer { get; }
+        ExpandCollapseState System.Windows.Automation.Provider.IExpandCollapseProvider.ExpandCollapseState { get; }
+        bool System.Windows.Automation.Provider.ISelectionItemProvider.IsSelected { get; }
+        IRawElementProviderSimple System.Windows.Automation.Provider.ISelectionItemProvider.SelectionContainer { get; }
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        void System.Windows.Automation.Provider.IExpandCollapseProvider.Collapse();
+        void System.Windows.Automation.Provider.IExpandCollapseProvider.Expand();
+        void System.Windows.Automation.Provider.IScrollItemProvider.ScrollIntoView();
+        void System.Windows.Automation.Provider.ISelectionItemProvider.AddToSelection();
+        void System.Windows.Automation.Provider.ISelectionItemProvider.RemoveFromSelection();
+        void System.Windows.Automation.Provider.ISelectionItemProvider.Select();
+    }
+    public class TreeViewItemAutomationPeer : ItemsControlAutomationPeer, IExpandCollapseProvider, IScrollItemProvider, ISelectionItemProvider {
+        public TreeViewItemAutomationPeer(TreeViewItem owner);
+        ExpandCollapseState System.Windows.Automation.Provider.IExpandCollapseProvider.ExpandCollapseState { get; }
+        bool System.Windows.Automation.Provider.ISelectionItemProvider.IsSelected { get; }
+        IRawElementProviderSimple System.Windows.Automation.Provider.ISelectionItemProvider.SelectionContainer { get; }
+        protected override ItemAutomationPeer CreateItemAutomationPeer(object item);
+        protected internal override ItemAutomationPeer FindOrCreateItemAutomationPeer(object item);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override List<AutomationPeer> GetChildrenCore();
+        protected override string GetClassNameCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        void System.Windows.Automation.Provider.IExpandCollapseProvider.Collapse();
+        void System.Windows.Automation.Provider.IExpandCollapseProvider.Expand();
+        void System.Windows.Automation.Provider.IScrollItemProvider.ScrollIntoView();
+        void System.Windows.Automation.Provider.ISelectionItemProvider.AddToSelection();
+        void System.Windows.Automation.Provider.ISelectionItemProvider.RemoveFromSelection();
+        void System.Windows.Automation.Provider.ISelectionItemProvider.Select();
+    }
+    public class UIElement3DAutomationPeer : AutomationPeer {
+        public UIElement3DAutomationPeer(UIElement3D owner);
+        public UIElement3D Owner { get; }
+        public static AutomationPeer CreatePeerForElement(UIElement3D element);
+        public static AutomationPeer FromElement(UIElement3D element);
+        protected override string GetAcceleratorKeyCore();
+        protected override string GetAccessKeyCore();
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetAutomationIdCore();
+        protected override Rect GetBoundingRectangleCore();
+        protected override List<AutomationPeer> GetChildrenCore();
+        protected override string GetClassNameCore();
+        protected override Point GetClickablePointCore();
+        protected override string GetHelpTextCore();
+        protected override string GetItemStatusCore();
+        protected override string GetItemTypeCore();
+        protected override AutomationPeer GetLabeledByCore();
+        protected override string GetNameCore();
+        protected override AutomationOrientation GetOrientationCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        protected override bool HasKeyboardFocusCore();
+        protected override bool IsContentElementCore();
+        protected override bool IsControlElementCore();
+        protected override bool IsEnabledCore();
+        protected override bool IsKeyboardFocusableCore();
+        protected override bool IsOffscreenCore();
+        protected override bool IsPasswordCore();
+        protected override bool IsRequiredForFormCore();
+        protected override void SetFocusCore();
+    }
+    public class UIElementAutomationPeer : AutomationPeer {
+        public UIElementAutomationPeer(UIElement owner);
+        public UIElement Owner { get; }
+        public static AutomationPeer CreatePeerForElement(UIElement element);
+        public static AutomationPeer FromElement(UIElement element);
+        protected override string GetAcceleratorKeyCore();
+        protected override string GetAccessKeyCore();
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetAutomationIdCore();
+        protected override Rect GetBoundingRectangleCore();
+        protected override List<AutomationPeer> GetChildrenCore();
+        protected override string GetClassNameCore();
+        protected override Point GetClickablePointCore();
+        protected override string GetHelpTextCore();
+        protected override string GetItemStatusCore();
+        protected override string GetItemTypeCore();
+        protected override AutomationPeer GetLabeledByCore();
+        protected override string GetNameCore();
+        protected override AutomationOrientation GetOrientationCore();
+        public override object GetPattern(PatternInterface patternInterface);
+        protected override bool HasKeyboardFocusCore();
+        protected override bool IsContentElementCore();
+        protected override bool IsControlElementCore();
+        protected override bool IsEnabledCore();
+        protected override bool IsKeyboardFocusableCore();
+        protected override bool IsOffscreenCore();
+        protected override bool IsPasswordCore();
+        protected override bool IsRequiredForFormCore();
+        protected override void SetFocusCore();
+    }
+    public class UserControlAutomationPeer : FrameworkElementAutomationPeer {
+        public UserControlAutomationPeer(UserControl owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+    }
+    public class Viewport3DAutomationPeer : FrameworkElementAutomationPeer {
+        public Viewport3DAutomationPeer(Viewport3D owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+    }
+    public class WindowAutomationPeer : FrameworkElementAutomationPeer {
+        public WindowAutomationPeer(Window owner);
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override Rect GetBoundingRectangleCore();
+        protected override string GetClassNameCore();
+        protected override string GetNameCore();
+    }
+    public sealed class WindowsFormsHostAutomationPeer : FrameworkElementAutomationPeer {
+        public WindowsFormsHostAutomationPeer(WindowsFormsHost owner);
+        protected internal override bool IsHwndHost { get; }
+        protected override AutomationControlType GetAutomationControlTypeCore();
+        protected override string GetClassNameCore();
+        protected override HostedWindowWrapper GetHostRawElementProviderCore();
+    }
+}
```

