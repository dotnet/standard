# System.Windows.Automation.Provider

``` diff
+namespace System.Windows.Automation.Provider {
+    public static class AutomationInteropProvider {
+        public const int AppendRuntimeId = 3;
+        public const int InvalidateLimit = 20;
+        public const int ItemsInvalidateLimit = 5;
+        public const int RootObjectId = -25;
+        public static bool ClientsAreListening { get; }
+        public static IRawElementProviderSimple HostProviderFromHandle(IntPtr hwnd);
+        public static void RaiseAutomationEvent(AutomationEvent eventId, IRawElementProviderSimple provider, AutomationEventArgs e);
+        public static void RaiseAutomationPropertyChangedEvent(IRawElementProviderSimple element, AutomationPropertyChangedEventArgs e);
+        public static void RaiseStructureChangedEvent(IRawElementProviderSimple provider, StructureChangedEventArgs e);
+        public static IntPtr ReturnRawElementProvider(IntPtr hwnd, IntPtr wParam, IntPtr lParam, IRawElementProviderSimple el);
+    }
+    public interface IDockProvider {
+        DockPosition DockPosition { get; }
+        void SetDockPosition(DockPosition dockPosition);
+    }
+    public interface IExpandCollapseProvider {
+        ExpandCollapseState ExpandCollapseState { get; }
+        void Collapse();
+        void Expand();
+    }
+    public interface IGridItemProvider {
+        int Column { get; }
+        int ColumnSpan { get; }
+        IRawElementProviderSimple ContainingGrid { get; }
+        int Row { get; }
+        int RowSpan { get; }
+    }
+    public interface IGridProvider {
+        int ColumnCount { get; }
+        int RowCount { get; }
+        IRawElementProviderSimple GetItem(int row, int column);
+    }
+    public interface IInvokeProvider {
+        void Invoke();
+    }
+    public interface IItemContainerProvider {
+        IRawElementProviderSimple FindItemByProperty(IRawElementProviderSimple startAfter, int propertyId, object value);
+    }
+    public interface IMultipleViewProvider {
+        int CurrentView { get; }
+        int[] GetSupportedViews();
+        string GetViewName(int viewId);
+        void SetCurrentView(int viewId);
+    }
+    public interface IRangeValueProvider {
+        bool IsReadOnly { get; }
+        double LargeChange { get; }
+        double Maximum { get; }
+        double Minimum { get; }
+        double SmallChange { get; }
+        double Value { get; }
+        void SetValue(double value);
+    }
+    public interface IRawElementProviderAdviseEvents : IRawElementProviderSimple {
+        void AdviseEventAdded(int eventId, int[] properties);
+        void AdviseEventRemoved(int eventId, int[] properties);
+    }
+    public interface IRawElementProviderFragment : IRawElementProviderSimple {
+        Rect BoundingRectangle { get; }
+        IRawElementProviderFragmentRoot FragmentRoot { get; }
+        IRawElementProviderSimple[] GetEmbeddedFragmentRoots();
+        int[] GetRuntimeId();
+        IRawElementProviderFragment Navigate(NavigateDirection direction);
+        void SetFocus();
+    }
+    public interface IRawElementProviderFragmentRoot : IRawElementProviderFragment, IRawElementProviderSimple {
+        IRawElementProviderFragment ElementProviderFromPoint(double x, double y);
+        IRawElementProviderFragment GetFocus();
+    }
+    public interface IRawElementProviderHwndOverride : IRawElementProviderSimple {
+        IRawElementProviderSimple GetOverrideProviderForHwnd(IntPtr hwnd);
+    }
+    public interface IRawElementProviderSimple {
+        IRawElementProviderSimple HostRawElementProvider { get; }
+        ProviderOptions ProviderOptions { get; }
+        object GetPatternProvider(int patternId);
+        object GetPropertyValue(int propertyId);
+    }
+    public interface IScrollItemProvider {
+        void ScrollIntoView();
+    }
+    public interface IScrollProvider {
+        bool HorizontallyScrollable { get; }
+        double HorizontalScrollPercent { get; }
+        double HorizontalViewSize { get; }
+        bool VerticallyScrollable { get; }
+        double VerticalScrollPercent { get; }
+        double VerticalViewSize { get; }
+        void Scroll(ScrollAmount horizontalAmount, ScrollAmount verticalAmount);
+        void SetScrollPercent(double horizontalPercent, double verticalPercent);
+    }
+    public interface ISelectionItemProvider {
+        bool IsSelected { get; }
+        IRawElementProviderSimple SelectionContainer { get; }
+        void AddToSelection();
+        void RemoveFromSelection();
+        void Select();
+    }
+    public interface ISelectionProvider {
+        bool CanSelectMultiple { get; }
+        bool IsSelectionRequired { get; }
+        IRawElementProviderSimple[] GetSelection();
+    }
+    public interface ISynchronizedInputProvider {
+        void Cancel();
+        void StartListening(SynchronizedInputType inputType);
+    }
+    public interface ITableItemProvider : IGridItemProvider {
+        IRawElementProviderSimple[] GetColumnHeaderItems();
+        IRawElementProviderSimple[] GetRowHeaderItems();
+    }
+    public interface ITableProvider : IGridProvider {
+        RowOrColumnMajor RowOrColumnMajor { get; }
+        IRawElementProviderSimple[] GetColumnHeaders();
+        IRawElementProviderSimple[] GetRowHeaders();
+    }
+    public interface ITextProvider {
+        ITextRangeProvider DocumentRange { get; }
+        SupportedTextSelection SupportedTextSelection { get; }
+        ITextRangeProvider[] GetSelection();
+        ITextRangeProvider[] GetVisibleRanges();
+        ITextRangeProvider RangeFromChild(IRawElementProviderSimple childElement);
+        ITextRangeProvider RangeFromPoint(Point screenLocation);
+    }
+    public interface ITextRangeProvider {
+        void AddToSelection();
+        ITextRangeProvider Clone();
+        bool Compare(ITextRangeProvider range);
+        int CompareEndpoints(TextPatternRangeEndpoint endpoint, ITextRangeProvider targetRange, TextPatternRangeEndpoint targetEndpoint);
+        void ExpandToEnclosingUnit(TextUnit unit);
+        ITextRangeProvider FindAttribute(int attribute, object value, bool backward);
+        ITextRangeProvider FindText(string text, bool backward, bool ignoreCase);
+        object GetAttributeValue(int attribute);
+        double[] GetBoundingRectangles();
+        IRawElementProviderSimple[] GetChildren();
+        IRawElementProviderSimple GetEnclosingElement();
+        string GetText(int maxLength);
+        int Move(TextUnit unit, int count);
+        void MoveEndpointByRange(TextPatternRangeEndpoint endpoint, ITextRangeProvider targetRange, TextPatternRangeEndpoint targetEndpoint);
+        int MoveEndpointByUnit(TextPatternRangeEndpoint endpoint, TextUnit unit, int count);
+        void RemoveFromSelection();
+        void ScrollIntoView(bool alignToTop);
+        void Select();
+    }
+    public interface IToggleProvider {
+        ToggleState ToggleState { get; }
+        void Toggle();
+    }
+    public interface ITransformProvider {
+        bool CanMove { get; }
+        bool CanResize { get; }
+        bool CanRotate { get; }
+        void Move(double x, double y);
+        void Resize(double width, double height);
+        void Rotate(double degrees);
+    }
+    public interface IValueProvider {
+        bool IsReadOnly { get; }
+        string Value { get; }
+        void SetValue(string value);
+    }
+    public interface IVirtualizedItemProvider {
+        void Realize();
+    }
+    public interface IWindowProvider {
+        WindowInteractionState InteractionState { get; }
+        bool IsModal { get; }
+        bool IsTopmost { get; }
+        bool Maximizable { get; }
+        bool Minimizable { get; }
+        WindowVisualState VisualState { get; }
+        void Close();
+        void SetVisualState(WindowVisualState state);
+        bool WaitForInputIdle(int milliseconds);
+    }
+    public enum NavigateDirection {
+        FirstChild = 3,
+        LastChild = 4,
+        NextSibling = 1,
+        Parent = 0,
+        PreviousSibling = 2,
+    }
+    public enum ProviderOptions {
+        ClientSideProvider = 1,
+        NonClientAreaProvider = 4,
+        OverrideProvider = 8,
+        ProviderOwnsSetFocus = 16,
+        ServerSideProvider = 2,
+        UseComThreading = 32,
+    }
+}
```

