# System.Windows.Automation

``` diff
+namespace System.Windows.Automation {
+    public class AndCondition : Condition {
+        public AndCondition(params Condition[] conditions);
+        public Condition[] GetConditions();
+    }
+    public sealed class AsyncContentLoadedEventArgs : AutomationEventArgs {
+        public AsyncContentLoadedEventArgs(AsyncContentLoadedState asyncContentState, double percentComplete);
+        public AsyncContentLoadedState AsyncContentLoadedState { get; }
+        public double PercentComplete { get; }
+    }
+    public enum AsyncContentLoadedState {
+        Beginning = 0,
+        Completed = 2,
+        Progress = 1,
+    }
+    public static class Automation {
+        public static readonly Condition ContentViewCondition;
+        public static readonly Condition ControlViewCondition;
+        public static readonly Condition RawViewCondition;
+        public static void AddAutomationEventHandler(AutomationEvent eventId, AutomationElement element, TreeScope scope, AutomationEventHandler eventHandler);
+        public static void AddAutomationFocusChangedEventHandler(AutomationFocusChangedEventHandler eventHandler);
+        public static void AddAutomationPropertyChangedEventHandler(AutomationElement element, TreeScope scope, AutomationPropertyChangedEventHandler eventHandler, params AutomationProperty[] properties);
+        public static void AddStructureChangedEventHandler(AutomationElement element, TreeScope scope, StructureChangedEventHandler eventHandler);
+        public static bool Compare(int[] runtimeId1, int[] runtimeId2);
+        public static bool Compare(AutomationElement el1, AutomationElement el2);
+        public static string PatternName(AutomationPattern pattern);
+        public static string PropertyName(AutomationProperty property);
+        public static void RemoveAllEventHandlers();
+        public static void RemoveAutomationEventHandler(AutomationEvent eventId, AutomationElement element, AutomationEventHandler eventHandler);
+        public static void RemoveAutomationFocusChangedEventHandler(AutomationFocusChangedEventHandler eventHandler);
+        public static void RemoveAutomationPropertyChangedEventHandler(AutomationElement element, AutomationPropertyChangedEventHandler eventHandler);
+        public static void RemoveStructureChangedEventHandler(AutomationElement element, StructureChangedEventHandler eventHandler);
+    }
+    public sealed class AutomationElement {
+        public static readonly object NotSupported;
+        public static readonly AutomationEvent AsyncContentLoadedEvent;
+        public static readonly AutomationEvent AutomationFocusChangedEvent;
+        public static readonly AutomationEvent AutomationPropertyChangedEvent;
+        public static readonly AutomationEvent LayoutInvalidatedEvent;
+        public static readonly AutomationEvent MenuClosedEvent;
+        public static readonly AutomationEvent MenuOpenedEvent;
+        public static readonly AutomationEvent StructureChangedEvent;
+        public static readonly AutomationEvent ToolTipClosedEvent;
+        public static readonly AutomationEvent ToolTipOpenedEvent;
+        public static readonly AutomationProperty AcceleratorKeyProperty;
+        public static readonly AutomationProperty AccessKeyProperty;
+        public static readonly AutomationProperty AutomationIdProperty;
+        public static readonly AutomationProperty BoundingRectangleProperty;
+        public static readonly AutomationProperty ClassNameProperty;
+        public static readonly AutomationProperty ClickablePointProperty;
+        public static readonly AutomationProperty ControlTypeProperty;
+        public static readonly AutomationProperty CultureProperty;
+        public static readonly AutomationProperty FrameworkIdProperty;
+        public static readonly AutomationProperty HasKeyboardFocusProperty;
+        public static readonly AutomationProperty HelpTextProperty;
+        public static readonly AutomationProperty IsContentElementProperty;
+        public static readonly AutomationProperty IsControlElementProperty;
+        public static readonly AutomationProperty IsDockPatternAvailableProperty;
+        public static readonly AutomationProperty IsEnabledProperty;
+        public static readonly AutomationProperty IsExpandCollapsePatternAvailableProperty;
+        public static readonly AutomationProperty IsGridItemPatternAvailableProperty;
+        public static readonly AutomationProperty IsGridPatternAvailableProperty;
+        public static readonly AutomationProperty IsInvokePatternAvailableProperty;
+        public static readonly AutomationProperty IsItemContainerPatternAvailableProperty;
+        public static readonly AutomationProperty IsKeyboardFocusableProperty;
+        public static readonly AutomationProperty IsMultipleViewPatternAvailableProperty;
+        public static readonly AutomationProperty IsOffscreenProperty;
+        public static readonly AutomationProperty IsPasswordProperty;
+        public static readonly AutomationProperty IsRangeValuePatternAvailableProperty;
+        public static readonly AutomationProperty IsRequiredForFormProperty;
+        public static readonly AutomationProperty IsScrollItemPatternAvailableProperty;
+        public static readonly AutomationProperty IsScrollPatternAvailableProperty;
+        public static readonly AutomationProperty IsSelectionItemPatternAvailableProperty;
+        public static readonly AutomationProperty IsSelectionPatternAvailableProperty;
+        public static readonly AutomationProperty IsSynchronizedInputPatternAvailableProperty;
+        public static readonly AutomationProperty IsTableItemPatternAvailableProperty;
+        public static readonly AutomationProperty IsTablePatternAvailableProperty;
+        public static readonly AutomationProperty IsTextPatternAvailableProperty;
+        public static readonly AutomationProperty IsTogglePatternAvailableProperty;
+        public static readonly AutomationProperty IsTransformPatternAvailableProperty;
+        public static readonly AutomationProperty IsValuePatternAvailableProperty;
+        public static readonly AutomationProperty IsVirtualizedItemPatternAvailableProperty;
+        public static readonly AutomationProperty IsWindowPatternAvailableProperty;
+        public static readonly AutomationProperty ItemStatusProperty;
+        public static readonly AutomationProperty ItemTypeProperty;
+        public static readonly AutomationProperty LabeledByProperty;
+        public static readonly AutomationProperty LocalizedControlTypeProperty;
+        public static readonly AutomationProperty NameProperty;
+        public static readonly AutomationProperty NativeWindowHandleProperty;
+        public static readonly AutomationProperty OrientationProperty;
+        public static readonly AutomationProperty ProcessIdProperty;
+        public static readonly AutomationProperty RuntimeIdProperty;
+        public AutomationElement.AutomationElementInformation Cached { get; }
+        public AutomationElementCollection CachedChildren { get; }
+        public AutomationElement CachedParent { get; }
+        public AutomationElement.AutomationElementInformation Current { get; }
+        public static AutomationElement FocusedElement { get; }
+        public static AutomationElement RootElement { get; }
+        public override bool Equals(object obj);
+        ~AutomationElement();
+        public AutomationElementCollection FindAll(TreeScope scope, Condition condition);
+        public AutomationElement FindFirst(TreeScope scope, Condition condition);
+        public static AutomationElement FromHandle(IntPtr hwnd);
+        public static AutomationElement FromLocalProvider(IRawElementProviderSimple localImpl);
+        public static AutomationElement FromPoint(Point pt);
+        public object GetCachedPattern(AutomationPattern pattern);
+        public object GetCachedPropertyValue(AutomationProperty property);
+        public object GetCachedPropertyValue(AutomationProperty property, bool ignoreDefaultValue);
+        public Point GetClickablePoint();
+        public object GetCurrentPattern(AutomationPattern pattern);
+        public object GetCurrentPropertyValue(AutomationProperty property);
+        public object GetCurrentPropertyValue(AutomationProperty property, bool ignoreDefaultValue);
+        public override int GetHashCode();
+        public int[] GetRuntimeId();
+        public AutomationPattern[] GetSupportedPatterns();
+        public AutomationProperty[] GetSupportedProperties();
+        public AutomationElement GetUpdatedCache(CacheRequest request);
+        public static bool operator ==(AutomationElement left, AutomationElement right);
+        public static bool operator !=(AutomationElement left, AutomationElement right);
+        public void SetFocus();
+        public bool TryGetCachedPattern(AutomationPattern pattern, out object patternObject);
+        public bool TryGetClickablePoint(out Point pt);
+        public bool TryGetCurrentPattern(AutomationPattern pattern, out object patternObject);
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct AutomationElementInformation {
+            public string AcceleratorKey { get; }
+            public string AccessKey { get; }
+            public string AutomationId { get; }
+            public Rect BoundingRectangle { get; }
+            public string ClassName { get; }
+            public ControlType ControlType { get; }
+            public string FrameworkId { get; }
+            public bool HasKeyboardFocus { get; }
+            public string HelpText { get; }
+            public bool IsContentElement { get; }
+            public bool IsControlElement { get; }
+            public bool IsEnabled { get; }
+            public bool IsKeyboardFocusable { get; }
+            public bool IsOffscreen { get; }
+            public bool IsPassword { get; }
+            public bool IsRequiredForForm { get; }
+            public string ItemStatus { get; }
+            public string ItemType { get; }
+            public AutomationElement LabeledBy { get; }
+            public string LocalizedControlType { get; }
+            public string Name { get; }
+            public int NativeWindowHandle { get; }
+            public OrientationType Orientation { get; }
+            public int ProcessId { get; }
+        }
+    }
+    public class AutomationElementCollection : ICollection, IEnumerable {
+        public int Count { get; }
+        public virtual bool IsSynchronized { get; }
+        public virtual object SyncRoot { get; }
+        public AutomationElement this[int index] { get; }
+        public virtual void CopyTo(Array array, int index);
+        public void CopyTo(AutomationElement[] array, int index);
+        public IEnumerator GetEnumerator();
+    }
+    public static class AutomationElementIdentifiers {
+        public static readonly object NotSupported;
+        public static readonly AutomationEvent AsyncContentLoadedEvent;
+        public static readonly AutomationEvent AutomationFocusChangedEvent;
+        public static readonly AutomationEvent AutomationPropertyChangedEvent;
+        public static readonly AutomationEvent LayoutInvalidatedEvent;
+        public static readonly AutomationEvent MenuClosedEvent;
+        public static readonly AutomationEvent MenuOpenedEvent;
+        public static readonly AutomationEvent StructureChangedEvent;
+        public static readonly AutomationEvent ToolTipClosedEvent;
+        public static readonly AutomationEvent ToolTipOpenedEvent;
+        public static readonly AutomationProperty AcceleratorKeyProperty;
+        public static readonly AutomationProperty AccessKeyProperty;
+        public static readonly AutomationProperty AutomationIdProperty;
+        public static readonly AutomationProperty BoundingRectangleProperty;
+        public static readonly AutomationProperty ClassNameProperty;
+        public static readonly AutomationProperty ClickablePointProperty;
+        public static readonly AutomationProperty ControlTypeProperty;
+        public static readonly AutomationProperty CultureProperty;
+        public static readonly AutomationProperty FrameworkIdProperty;
+        public static readonly AutomationProperty HasKeyboardFocusProperty;
+        public static readonly AutomationProperty HelpTextProperty;
+        public static readonly AutomationProperty IsContentElementProperty;
+        public static readonly AutomationProperty IsControlElementProperty;
+        public static readonly AutomationProperty IsDockPatternAvailableProperty;
+        public static readonly AutomationProperty IsEnabledProperty;
+        public static readonly AutomationProperty IsExpandCollapsePatternAvailableProperty;
+        public static readonly AutomationProperty IsGridItemPatternAvailableProperty;
+        public static readonly AutomationProperty IsGridPatternAvailableProperty;
+        public static readonly AutomationProperty IsInvokePatternAvailableProperty;
+        public static readonly AutomationProperty IsItemContainerPatternAvailableProperty;
+        public static readonly AutomationProperty IsKeyboardFocusableProperty;
+        public static readonly AutomationProperty IsMultipleViewPatternAvailableProperty;
+        public static readonly AutomationProperty IsOffscreenProperty;
+        public static readonly AutomationProperty IsPasswordProperty;
+        public static readonly AutomationProperty IsRangeValuePatternAvailableProperty;
+        public static readonly AutomationProperty IsRequiredForFormProperty;
+        public static readonly AutomationProperty IsScrollItemPatternAvailableProperty;
+        public static readonly AutomationProperty IsScrollPatternAvailableProperty;
+        public static readonly AutomationProperty IsSelectionItemPatternAvailableProperty;
+        public static readonly AutomationProperty IsSelectionPatternAvailableProperty;
+        public static readonly AutomationProperty IsSynchronizedInputPatternAvailableProperty;
+        public static readonly AutomationProperty IsTableItemPatternAvailableProperty;
+        public static readonly AutomationProperty IsTablePatternAvailableProperty;
+        public static readonly AutomationProperty IsTextPatternAvailableProperty;
+        public static readonly AutomationProperty IsTogglePatternAvailableProperty;
+        public static readonly AutomationProperty IsTransformPatternAvailableProperty;
+        public static readonly AutomationProperty IsValuePatternAvailableProperty;
+        public static readonly AutomationProperty IsVirtualizedItemPatternAvailableProperty;
+        public static readonly AutomationProperty IsWindowPatternAvailableProperty;
+        public static readonly AutomationProperty ItemStatusProperty;
+        public static readonly AutomationProperty ItemTypeProperty;
+        public static readonly AutomationProperty LabeledByProperty;
+        public static readonly AutomationProperty LocalizedControlTypeProperty;
+        public static readonly AutomationProperty NameProperty;
+        public static readonly AutomationProperty NativeWindowHandleProperty;
+        public static readonly AutomationProperty OrientationProperty;
+        public static readonly AutomationProperty ProcessIdProperty;
+        public static readonly AutomationProperty RuntimeIdProperty;
+    }
+    public enum AutomationElementMode {
+        Full = 1,
+        None = 0,
+    }
+    public class AutomationEvent : AutomationIdentifier {
+        public static AutomationEvent LookupById(int id);
+    }
+    public class AutomationEventArgs : EventArgs {
+        public AutomationEventArgs(AutomationEvent eventId);
+        public AutomationEvent EventId { get; }
+    }
+    public delegate void AutomationEventHandler(object sender, AutomationEventArgs e);
+    public class AutomationFocusChangedEventArgs : AutomationEventArgs {
+        public AutomationFocusChangedEventArgs(int idObject, int idChild);
+        public int ChildId { get; }
+        public int ObjectId { get; }
+    }
+    public delegate void AutomationFocusChangedEventHandler(object sender, AutomationFocusChangedEventArgs e);
+    public class AutomationIdentifier : IComparable {
+        public int Id { get; }
+        public string ProgrammaticName { get; }
+        public int CompareTo(object obj);
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+    }
+    public class AutomationPattern : AutomationIdentifier {
+        public static AutomationPattern LookupById(int id);
+    }
+    public static class AutomationProperties {
+        public static readonly DependencyProperty AcceleratorKeyProperty;
+        public static readonly DependencyProperty AccessKeyProperty;
+        public static readonly DependencyProperty AutomationIdProperty;
+        public static readonly DependencyProperty HelpTextProperty;
+        public static readonly DependencyProperty IsColumnHeaderProperty;
+        public static readonly DependencyProperty IsOffscreenBehaviorProperty;
+        public static readonly DependencyProperty IsRequiredForFormProperty;
+        public static readonly DependencyProperty IsRowHeaderProperty;
+        public static readonly DependencyProperty ItemStatusProperty;
+        public static readonly DependencyProperty ItemTypeProperty;
+        public static readonly DependencyProperty LabeledByProperty;
+        public static readonly DependencyProperty NameProperty;
+        public static string GetAcceleratorKey(DependencyObject element);
+        public static string GetAccessKey(DependencyObject element);
+        public static string GetAutomationId(DependencyObject element);
+        public static string GetHelpText(DependencyObject element);
+        public static bool GetIsColumnHeader(DependencyObject element);
+        public static IsOffscreenBehavior GetIsOffscreenBehavior(DependencyObject element);
+        public static bool GetIsRequiredForForm(DependencyObject element);
+        public static bool GetIsRowHeader(DependencyObject element);
+        public static string GetItemStatus(DependencyObject element);
+        public static string GetItemType(DependencyObject element);
+        public static UIElement GetLabeledBy(DependencyObject element);
+        public static string GetName(DependencyObject element);
+        public static void SetAcceleratorKey(DependencyObject element, string value);
+        public static void SetAccessKey(DependencyObject element, string value);
+        public static void SetAutomationId(DependencyObject element, string value);
+        public static void SetHelpText(DependencyObject element, string value);
+        public static void SetIsColumnHeader(DependencyObject element, bool value);
+        public static void SetIsOffscreenBehavior(DependencyObject element, IsOffscreenBehavior value);
+        public static void SetIsRequiredForForm(DependencyObject element, bool value);
+        public static void SetIsRowHeader(DependencyObject element, bool value);
+        public static void SetItemStatus(DependencyObject element, string value);
+        public static void SetItemType(DependencyObject element, string value);
+        public static void SetLabeledBy(DependencyObject element, UIElement value);
+        public static void SetName(DependencyObject element, string value);
+    }
+    public class AutomationProperty : AutomationIdentifier {
+        public static AutomationProperty LookupById(int id);
+    }
+    public sealed class AutomationPropertyChangedEventArgs : AutomationEventArgs {
+        public AutomationPropertyChangedEventArgs(AutomationProperty property, object oldValue, object newValue);
+        public object NewValue { get; }
+        public object OldValue { get; }
+        public AutomationProperty Property { get; }
+    }
+    public delegate void AutomationPropertyChangedEventHandler(object sender, AutomationPropertyChangedEventArgs e);
+    public class AutomationTextAttribute : AutomationIdentifier {
+        public static AutomationTextAttribute LookupById(int id);
+    }
+    public class BasePattern {
+        ~BasePattern();
+    }
+    public sealed class CacheRequest {
+        public CacheRequest();
+        public AutomationElementMode AutomationElementMode { get; set; }
+        public static CacheRequest Current { get; }
+        public Condition TreeFilter { get; set; }
+        public TreeScope TreeScope { get; set; }
+        public IDisposable Activate();
+        public void Add(AutomationPattern pattern);
+        public void Add(AutomationProperty property);
+        public CacheRequest Clone();
+        public void Pop();
+        public void Push();
+    }
+    public static class ClientSettings {
+        public static void RegisterClientSideProviderAssembly(AssemblyName assemblyName);
+        public static void RegisterClientSideProviders(ClientSideProviderDescription[] clientSideProviderDescription);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct ClientSideProviderDescription {
+        public ClientSideProviderDescription(ClientSideProviderFactoryCallback clientSideProviderFactoryCallback, string className);
+        public ClientSideProviderDescription(ClientSideProviderFactoryCallback clientSideProviderFactoryCallback, string className, string imageName, ClientSideProviderMatchIndicator flags);
+        public string ClassName { get; }
+        public ClientSideProviderFactoryCallback ClientSideProviderFactoryCallback { get; }
+        public ClientSideProviderMatchIndicator Flags { get; }
+        public string ImageName { get; }
+    }
+    public delegate IRawElementProviderSimple ClientSideProviderFactoryCallback(IntPtr hwnd, int idChild, int idObject);
+    public enum ClientSideProviderMatchIndicator {
+        AllowSubstringMatch = 1,
+        DisallowBaseClassNameMatch = 2,
+        None = 0,
+    }
+    public abstract class Condition {
+        public static readonly Condition FalseCondition;
+        public static readonly Condition TrueCondition;
+    }
+    public class ControlType : AutomationIdentifier {
+        public static readonly ControlType Button;
+        public static readonly ControlType Calendar;
+        public static readonly ControlType CheckBox;
+        public static readonly ControlType ComboBox;
+        public static readonly ControlType Custom;
+        public static readonly ControlType DataGrid;
+        public static readonly ControlType DataItem;
+        public static readonly ControlType Document;
+        public static readonly ControlType Edit;
+        public static readonly ControlType Group;
+        public static readonly ControlType Header;
+        public static readonly ControlType HeaderItem;
+        public static readonly ControlType Hyperlink;
+        public static readonly ControlType Image;
+        public static readonly ControlType List;
+        public static readonly ControlType ListItem;
+        public static readonly ControlType Menu;
+        public static readonly ControlType MenuBar;
+        public static readonly ControlType MenuItem;
+        public static readonly ControlType Pane;
+        public static readonly ControlType ProgressBar;
+        public static readonly ControlType RadioButton;
+        public static readonly ControlType ScrollBar;
+        public static readonly ControlType Separator;
+        public static readonly ControlType Slider;
+        public static readonly ControlType Spinner;
+        public static readonly ControlType SplitButton;
+        public static readonly ControlType StatusBar;
+        public static readonly ControlType Tab;
+        public static readonly ControlType TabItem;
+        public static readonly ControlType Table;
+        public static readonly ControlType Text;
+        public static readonly ControlType Thumb;
+        public static readonly ControlType TitleBar;
+        public static readonly ControlType ToolBar;
+        public static readonly ControlType ToolTip;
+        public static readonly ControlType Tree;
+        public static readonly ControlType TreeItem;
+        public static readonly ControlType Window;
+        public string LocalizedControlType { get; }
+        public AutomationPattern[] GetNeverSupportedPatterns();
+        public AutomationPattern[][] GetRequiredPatternSets();
+        public AutomationProperty[] GetRequiredProperties();
+        public static ControlType LookupById(int id);
+    }
+    public class DockPattern : BasePattern {
+        public static readonly AutomationPattern Pattern;
+        public static readonly AutomationProperty DockPositionProperty;
+        public DockPattern.DockPatternInformation Cached { get; }
+        public DockPattern.DockPatternInformation Current { get; }
+        public void SetDockPosition(DockPosition dockPosition);
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct DockPatternInformation {
+            public DockPosition DockPosition { get; }
+        }
+    }
+    public static class DockPatternIdentifiers {
+        public static readonly AutomationPattern Pattern;
+        public static readonly AutomationProperty DockPositionProperty;
+    }
+    public enum DockPosition {
+        Bottom = 2,
+        Fill = 4,
+        Left = 1,
+        None = 5,
+        Right = 3,
+        Top = 0,
+    }
+    public class ElementNotAvailableException : SystemException {
+        public ElementNotAvailableException();
+        public ElementNotAvailableException(Exception innerException);
+        protected ElementNotAvailableException(SerializationInfo info, StreamingContext context);
+        public ElementNotAvailableException(string message);
+        public ElementNotAvailableException(string message, Exception innerException);
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class ElementNotEnabledException : InvalidOperationException {
+        public ElementNotEnabledException();
+        protected ElementNotEnabledException(SerializationInfo info, StreamingContext context);
+        public ElementNotEnabledException(string message);
+        public ElementNotEnabledException(string message, Exception innerException);
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class ExpandCollapsePattern : BasePattern {
+        public static readonly AutomationPattern Pattern;
+        public static readonly AutomationProperty ExpandCollapseStateProperty;
+        public ExpandCollapsePattern.ExpandCollapsePatternInformation Cached { get; }
+        public ExpandCollapsePattern.ExpandCollapsePatternInformation Current { get; }
+        public void Collapse();
+        public void Expand();
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct ExpandCollapsePatternInformation {
+            public ExpandCollapseState ExpandCollapseState { get; }
+        }
+    }
+    public static class ExpandCollapsePatternIdentifiers {
+        public static readonly AutomationPattern Pattern;
+        public static readonly AutomationProperty ExpandCollapseStateProperty;
+    }
+    public enum ExpandCollapseState {
+        Collapsed = 0,
+        Expanded = 1,
+        LeafNode = 3,
+        PartiallyExpanded = 2,
+    }
+    public class GridItemPattern : BasePattern {
+        public static readonly AutomationPattern Pattern;
+        public static readonly AutomationProperty ColumnProperty;
+        public static readonly AutomationProperty ColumnSpanProperty;
+        public static readonly AutomationProperty ContainingGridProperty;
+        public static readonly AutomationProperty RowProperty;
+        public static readonly AutomationProperty RowSpanProperty;
+        public GridItemPattern.GridItemPatternInformation Cached { get; }
+        public GridItemPattern.GridItemPatternInformation Current { get; }
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct GridItemPatternInformation {
+            public int Column { get; }
+            public int ColumnSpan { get; }
+            public AutomationElement ContainingGrid { get; }
+            public int Row { get; }
+            public int RowSpan { get; }
+        }
+    }
+    public static class GridItemPatternIdentifiers {
+        public static readonly AutomationPattern Pattern;
+        public static readonly AutomationProperty ColumnProperty;
+        public static readonly AutomationProperty ColumnSpanProperty;
+        public static readonly AutomationProperty ContainingGridProperty;
+        public static readonly AutomationProperty RowProperty;
+        public static readonly AutomationProperty RowSpanProperty;
+    }
+    public class GridPattern : BasePattern {
+        public static readonly AutomationPattern Pattern;
+        public static readonly AutomationProperty ColumnCountProperty;
+        public static readonly AutomationProperty RowCountProperty;
+        public GridPattern.GridPatternInformation Cached { get; }
+        public GridPattern.GridPatternInformation Current { get; }
+        public AutomationElement GetItem(int row, int column);
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct GridPatternInformation {
+            public int ColumnCount { get; }
+            public int RowCount { get; }
+        }
+    }
+    public static class GridPatternIdentifiers {
+        public static readonly AutomationPattern Pattern;
+        public static readonly AutomationProperty ColumnCountProperty;
+        public static readonly AutomationProperty RowCountProperty;
+    }
+    public class InvokePattern : BasePattern {
+        public static readonly AutomationEvent InvokedEvent;
+        public static readonly AutomationPattern Pattern;
+        public void Invoke();
+    }
+    public static class InvokePatternIdentifiers {
+        public static readonly AutomationEvent InvokedEvent;
+        public static readonly AutomationPattern Pattern;
+    }
+    public enum IsOffscreenBehavior {
+        Default = 0,
+        FromClip = 3,
+        Offscreen = 2,
+        Onscreen = 1,
+    }
+    public class ItemContainerPattern : BasePattern {
+        public static readonly AutomationPattern Pattern;
+        public AutomationElement FindItemByProperty(AutomationElement startAfter, AutomationProperty property, object value);
+    }
+    public static class ItemContainerPatternIdentifiers {
+        public static readonly AutomationPattern Pattern;
+    }
+    public class MultipleViewPattern : BasePattern {
+        public static readonly AutomationPattern Pattern;
+        public static readonly AutomationProperty CurrentViewProperty;
+        public static readonly AutomationProperty SupportedViewsProperty;
+        public MultipleViewPattern.MultipleViewPatternInformation Cached { get; }
+        public MultipleViewPattern.MultipleViewPatternInformation Current { get; }
+        public string GetViewName(int viewId);
+        public void SetCurrentView(int viewId);
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct MultipleViewPatternInformation {
+            public int CurrentView { get; }
+            public int[] GetSupportedViews();
+        }
+    }
+    public static class MultipleViewPatternIdentifiers {
+        public static readonly AutomationPattern Pattern;
+        public static readonly AutomationProperty CurrentViewProperty;
+        public static readonly AutomationProperty SupportedViewsProperty;
+    }
+    public class NoClickablePointException : Exception {
+        public NoClickablePointException();
+        protected NoClickablePointException(SerializationInfo info, StreamingContext context);
+        public NoClickablePointException(string message);
+        public NoClickablePointException(string message, Exception innerException);
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class NotCondition : Condition {
+        public NotCondition(Condition condition);
+        public Condition Condition { get; }
+    }
+    public class OrCondition : Condition {
+        public OrCondition(params Condition[] conditions);
+        public Condition[] GetConditions();
+    }
+    public enum OrientationType {
+        Horizontal = 1,
+        None = 0,
+        Vertical = 2,
+    }
+    public class PropertyCondition : Condition {
+        public PropertyCondition(AutomationProperty property, object value);
+        public PropertyCondition(AutomationProperty property, object value, PropertyConditionFlags flags);
+        public PropertyConditionFlags Flags { get; }
+        public AutomationProperty Property { get; }
+        public object Value { get; }
+    }
+    public enum PropertyConditionFlags {
+        IgnoreCase = 1,
+        None = 0,
+    }
+    public class ProxyAssemblyNotLoadedException : Exception {
+        public ProxyAssemblyNotLoadedException();
+        protected ProxyAssemblyNotLoadedException(SerializationInfo info, StreamingContext context);
+        public ProxyAssemblyNotLoadedException(string message);
+        public ProxyAssemblyNotLoadedException(string message, Exception innerException);
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class RangeValuePattern : BasePattern {
+        public static readonly AutomationPattern Pattern;
+        public static readonly AutomationProperty IsReadOnlyProperty;
+        public static readonly AutomationProperty LargeChangeProperty;
+        public static readonly AutomationProperty MaximumProperty;
+        public static readonly AutomationProperty MinimumProperty;
+        public static readonly AutomationProperty SmallChangeProperty;
+        public static readonly AutomationProperty ValueProperty;
+        public RangeValuePattern.RangeValuePatternInformation Cached { get; }
+        public RangeValuePattern.RangeValuePatternInformation Current { get; }
+        public void SetValue(double value);
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct RangeValuePatternInformation {
+            public bool IsReadOnly { get; }
+            public double LargeChange { get; }
+            public double Maximum { get; }
+            public double Minimum { get; }
+            public double SmallChange { get; }
+            public double Value { get; }
+        }
+    }
+    public static class RangeValuePatternIdentifiers {
+        public static readonly AutomationPattern Pattern;
+        public static readonly AutomationProperty IsReadOnlyProperty;
+        public static readonly AutomationProperty LargeChangeProperty;
+        public static readonly AutomationProperty MaximumProperty;
+        public static readonly AutomationProperty MinimumProperty;
+        public static readonly AutomationProperty SmallChangeProperty;
+        public static readonly AutomationProperty ValueProperty;
+    }
+    public enum RowOrColumnMajor {
+        ColumnMajor = 1,
+        Indeterminate = 2,
+        RowMajor = 0,
+    }
+    public enum ScrollAmount {
+        LargeDecrement = 0,
+        LargeIncrement = 3,
+        NoAmount = 2,
+        SmallDecrement = 1,
+        SmallIncrement = 4,
+    }
+    public class ScrollItemPattern : BasePattern {
+        public static readonly AutomationPattern Pattern;
+        public void ScrollIntoView();
+    }
+    public static class ScrollItemPatternIdentifiers {
+        public static readonly AutomationPattern Pattern;
+    }
+    public class ScrollPattern : BasePattern {
+        public const double NoScroll = -1;
+        public static readonly AutomationPattern Pattern;
+        public static readonly AutomationProperty HorizontallyScrollableProperty;
+        public static readonly AutomationProperty HorizontalScrollPercentProperty;
+        public static readonly AutomationProperty HorizontalViewSizeProperty;
+        public static readonly AutomationProperty VerticallyScrollableProperty;
+        public static readonly AutomationProperty VerticalScrollPercentProperty;
+        public static readonly AutomationProperty VerticalViewSizeProperty;
+        public ScrollPattern.ScrollPatternInformation Cached { get; }
+        public ScrollPattern.ScrollPatternInformation Current { get; }
+        public void Scroll(ScrollAmount horizontalAmount, ScrollAmount verticalAmount);
+        public void ScrollHorizontal(ScrollAmount amount);
+        public void ScrollVertical(ScrollAmount amount);
+        public void SetScrollPercent(double horizontalPercent, double verticalPercent);
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct ScrollPatternInformation {
+            public bool HorizontallyScrollable { get; }
+            public double HorizontalScrollPercent { get; }
+            public double HorizontalViewSize { get; }
+            public bool VerticallyScrollable { get; }
+            public double VerticalScrollPercent { get; }
+            public double VerticalViewSize { get; }
+        }
+    }
+    public static class ScrollPatternIdentifiers {
+        public const double NoScroll = -1;
+        public static readonly AutomationPattern Pattern;
+        public static readonly AutomationProperty HorizontallyScrollableProperty;
+        public static readonly AutomationProperty HorizontalScrollPercentProperty;
+        public static readonly AutomationProperty HorizontalViewSizeProperty;
+        public static readonly AutomationProperty VerticallyScrollableProperty;
+        public static readonly AutomationProperty VerticalScrollPercentProperty;
+        public static readonly AutomationProperty VerticalViewSizeProperty;
+    }
+    public class SelectionItemPattern : BasePattern {
+        public static readonly AutomationEvent ElementAddedToSelectionEvent;
+        public static readonly AutomationEvent ElementRemovedFromSelectionEvent;
+        public static readonly AutomationEvent ElementSelectedEvent;
+        public static readonly AutomationPattern Pattern;
+        public static readonly AutomationProperty IsSelectedProperty;
+        public static readonly AutomationProperty SelectionContainerProperty;
+        public SelectionItemPattern.SelectionItemPatternInformation Cached { get; }
+        public SelectionItemPattern.SelectionItemPatternInformation Current { get; }
+        public void AddToSelection();
+        public void RemoveFromSelection();
+        public void Select();
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct SelectionItemPatternInformation {
+            public bool IsSelected { get; }
+            public AutomationElement SelectionContainer { get; }
+        }
+    }
+    public static class SelectionItemPatternIdentifiers {
+        public static readonly AutomationEvent ElementAddedToSelectionEvent;
+        public static readonly AutomationEvent ElementRemovedFromSelectionEvent;
+        public static readonly AutomationEvent ElementSelectedEvent;
+        public static readonly AutomationPattern Pattern;
+        public static readonly AutomationProperty IsSelectedProperty;
+        public static readonly AutomationProperty SelectionContainerProperty;
+    }
+    public class SelectionPattern : BasePattern {
+        public static readonly AutomationEvent InvalidatedEvent;
+        public static readonly AutomationPattern Pattern;
+        public static readonly AutomationProperty CanSelectMultipleProperty;
+        public static readonly AutomationProperty IsSelectionRequiredProperty;
+        public static readonly AutomationProperty SelectionProperty;
+        public SelectionPattern.SelectionPatternInformation Cached { get; }
+        public SelectionPattern.SelectionPatternInformation Current { get; }
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct SelectionPatternInformation {
+            public bool CanSelectMultiple { get; }
+            public bool IsSelectionRequired { get; }
+            public AutomationElement[] GetSelection();
+        }
+    }
+    public static class SelectionPatternIdentifiers {
+        public static readonly AutomationEvent InvalidatedEvent;
+        public static readonly AutomationPattern Pattern;
+        public static readonly AutomationProperty CanSelectMultipleProperty;
+        public static readonly AutomationProperty IsSelectionRequiredProperty;
+        public static readonly AutomationProperty SelectionProperty;
+    }
+    public sealed class StructureChangedEventArgs : AutomationEventArgs {
+        public StructureChangedEventArgs(StructureChangeType structureChangeType, int[] runtimeId);
+        public StructureChangeType StructureChangeType { get; }
+        public int[] GetRuntimeId();
+    }
+    public delegate void StructureChangedEventHandler(object sender, StructureChangedEventArgs e);
+    public enum StructureChangeType {
+        ChildAdded = 0,
+        ChildRemoved = 1,
+        ChildrenBulkAdded = 3,
+        ChildrenBulkRemoved = 4,
+        ChildrenInvalidated = 2,
+        ChildrenReordered = 5,
+    }
+    public enum SupportedTextSelection {
+        Multiple = 2,
+        None = 0,
+        Single = 1,
+    }
+    public class SynchronizedInputPattern : BasePattern {
+        public static readonly AutomationEvent InputDiscardedEvent;
+        public static readonly AutomationEvent InputReachedOtherElementEvent;
+        public static readonly AutomationEvent InputReachedTargetEvent;
+        public static readonly AutomationPattern Pattern;
+        public void Cancel();
+        public void StartListening(SynchronizedInputType inputType);
+    }
+    public static class SynchronizedInputPatternIdentifiers {
+        public static readonly AutomationEvent InputDiscardedEvent;
+        public static readonly AutomationEvent InputReachedOtherElementEvent;
+        public static readonly AutomationEvent InputReachedTargetEvent;
+        public static readonly AutomationPattern Pattern;
+    }
+    public enum SynchronizedInputType {
+        KeyDown = 2,
+        KeyUp = 1,
+        MouseLeftButtonDown = 8,
+        MouseLeftButtonUp = 4,
+        MouseRightButtonDown = 32,
+        MouseRightButtonUp = 16,
+    }
+    public class TableItemPattern : GridItemPattern {
+        public static readonly new AutomationPattern Pattern;
+        public static readonly AutomationProperty ColumnHeaderItemsProperty;
+        public static readonly AutomationProperty RowHeaderItemsProperty;
+        public new TableItemPattern.TableItemPatternInformation Cached { get; }
+        public new TableItemPattern.TableItemPatternInformation Current { get; }
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct TableItemPatternInformation {
+            public int Column { get; }
+            public int ColumnSpan { get; }
+            public AutomationElement ContainingGrid { get; }
+            public int Row { get; }
+            public int RowSpan { get; }
+            public AutomationElement[] GetColumnHeaderItems();
+            public AutomationElement[] GetRowHeaderItems();
+        }
+    }
+    public static class TableItemPatternIdentifiers {
+        public static readonly AutomationPattern Pattern;
+        public static readonly AutomationProperty ColumnHeaderItemsProperty;
+        public static readonly AutomationProperty RowHeaderItemsProperty;
+    }
+    public class TablePattern : GridPattern {
+        public static readonly new AutomationPattern Pattern;
+        public static readonly AutomationProperty ColumnHeadersProperty;
+        public static readonly AutomationProperty RowHeadersProperty;
+        public static readonly AutomationProperty RowOrColumnMajorProperty;
+        public new TablePattern.TablePatternInformation Cached { get; }
+        public new TablePattern.TablePatternInformation Current { get; }
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct TablePatternInformation {
+            public int ColumnCount { get; }
+            public int RowCount { get; }
+            public RowOrColumnMajor RowOrColumnMajor { get; }
+            public AutomationElement[] GetColumnHeaders();
+            public AutomationElement[] GetRowHeaders();
+        }
+    }
+    public static class TablePatternIdentifiers {
+        public static readonly AutomationPattern Pattern;
+        public static readonly AutomationProperty ColumnHeadersProperty;
+        public static readonly AutomationProperty RowHeadersProperty;
+        public static readonly AutomationProperty RowOrColumnMajorProperty;
+    }
+    public class TextPattern : BasePattern {
+        public static readonly object MixedAttributeValue;
+        public static readonly AutomationEvent TextChangedEvent;
+        public static readonly AutomationEvent TextSelectionChangedEvent;
+        public static readonly AutomationPattern Pattern;
+        public static readonly AutomationTextAttribute AnimationStyleAttribute;
+        public static readonly AutomationTextAttribute BackgroundColorAttribute;
+        public static readonly AutomationTextAttribute BulletStyleAttribute;
+        public static readonly AutomationTextAttribute CapStyleAttribute;
+        public static readonly AutomationTextAttribute CultureAttribute;
+        public static readonly AutomationTextAttribute FontNameAttribute;
+        public static readonly AutomationTextAttribute FontSizeAttribute;
+        public static readonly AutomationTextAttribute FontWeightAttribute;
+        public static readonly AutomationTextAttribute ForegroundColorAttribute;
+        public static readonly AutomationTextAttribute HorizontalTextAlignmentAttribute;
+        public static readonly AutomationTextAttribute IndentationFirstLineAttribute;
+        public static readonly AutomationTextAttribute IndentationLeadingAttribute;
+        public static readonly AutomationTextAttribute IndentationTrailingAttribute;
+        public static readonly AutomationTextAttribute IsHiddenAttribute;
+        public static readonly AutomationTextAttribute IsItalicAttribute;
+        public static readonly AutomationTextAttribute IsReadOnlyAttribute;
+        public static readonly AutomationTextAttribute IsSubscriptAttribute;
+        public static readonly AutomationTextAttribute IsSuperscriptAttribute;
+        public static readonly AutomationTextAttribute MarginBottomAttribute;
+        public static readonly AutomationTextAttribute MarginLeadingAttribute;
+        public static readonly AutomationTextAttribute MarginTopAttribute;
+        public static readonly AutomationTextAttribute MarginTrailingAttribute;
+        public static readonly AutomationTextAttribute OutlineStylesAttribute;
+        public static readonly AutomationTextAttribute OverlineColorAttribute;
+        public static readonly AutomationTextAttribute OverlineStyleAttribute;
+        public static readonly AutomationTextAttribute StrikethroughColorAttribute;
+        public static readonly AutomationTextAttribute StrikethroughStyleAttribute;
+        public static readonly AutomationTextAttribute TabsAttribute;
+        public static readonly AutomationTextAttribute TextFlowDirectionsAttribute;
+        public static readonly AutomationTextAttribute UnderlineColorAttribute;
+        public static readonly AutomationTextAttribute UnderlineStyleAttribute;
+        public TextPatternRange DocumentRange { get; }
+        public SupportedTextSelection SupportedTextSelection { get; }
+        public TextPatternRange[] GetSelection();
+        public TextPatternRange[] GetVisibleRanges();
+        public TextPatternRange RangeFromChild(AutomationElement childElement);
+        public TextPatternRange RangeFromPoint(Point screenLocation);
+    }
+    public static class TextPatternIdentifiers {
+        public static readonly object MixedAttributeValue;
+        public static readonly AutomationEvent TextChangedEvent;
+        public static readonly AutomationEvent TextSelectionChangedEvent;
+        public static readonly AutomationPattern Pattern;
+        public static readonly AutomationTextAttribute AnimationStyleAttribute;
+        public static readonly AutomationTextAttribute BackgroundColorAttribute;
+        public static readonly AutomationTextAttribute BulletStyleAttribute;
+        public static readonly AutomationTextAttribute CapStyleAttribute;
+        public static readonly AutomationTextAttribute CultureAttribute;
+        public static readonly AutomationTextAttribute FontNameAttribute;
+        public static readonly AutomationTextAttribute FontSizeAttribute;
+        public static readonly AutomationTextAttribute FontWeightAttribute;
+        public static readonly AutomationTextAttribute ForegroundColorAttribute;
+        public static readonly AutomationTextAttribute HorizontalTextAlignmentAttribute;
+        public static readonly AutomationTextAttribute IndentationFirstLineAttribute;
+        public static readonly AutomationTextAttribute IndentationLeadingAttribute;
+        public static readonly AutomationTextAttribute IndentationTrailingAttribute;
+        public static readonly AutomationTextAttribute IsHiddenAttribute;
+        public static readonly AutomationTextAttribute IsItalicAttribute;
+        public static readonly AutomationTextAttribute IsReadOnlyAttribute;
+        public static readonly AutomationTextAttribute IsSubscriptAttribute;
+        public static readonly AutomationTextAttribute IsSuperscriptAttribute;
+        public static readonly AutomationTextAttribute MarginBottomAttribute;
+        public static readonly AutomationTextAttribute MarginLeadingAttribute;
+        public static readonly AutomationTextAttribute MarginTopAttribute;
+        public static readonly AutomationTextAttribute MarginTrailingAttribute;
+        public static readonly AutomationTextAttribute OutlineStylesAttribute;
+        public static readonly AutomationTextAttribute OverlineColorAttribute;
+        public static readonly AutomationTextAttribute OverlineStyleAttribute;
+        public static readonly AutomationTextAttribute StrikethroughColorAttribute;
+        public static readonly AutomationTextAttribute StrikethroughStyleAttribute;
+        public static readonly AutomationTextAttribute TabsAttribute;
+        public static readonly AutomationTextAttribute TextFlowDirectionsAttribute;
+        public static readonly AutomationTextAttribute UnderlineColorAttribute;
+        public static readonly AutomationTextAttribute UnderlineStyleAttribute;
+    }
+    public class TogglePattern : BasePattern {
+        public static readonly AutomationPattern Pattern;
+        public static readonly AutomationProperty ToggleStateProperty;
+        public TogglePattern.TogglePatternInformation Cached { get; }
+        public TogglePattern.TogglePatternInformation Current { get; }
+        public void Toggle();
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct TogglePatternInformation {
+            public ToggleState ToggleState { get; }
+        }
+    }
+    public static class TogglePatternIdentifiers {
+        public static readonly AutomationPattern Pattern;
+        public static readonly AutomationProperty ToggleStateProperty;
+    }
+    public enum ToggleState {
+        Indeterminate = 2,
+        Off = 0,
+        On = 1,
+    }
+    public class TransformPattern : BasePattern {
+        public static readonly AutomationPattern Pattern;
+        public static readonly AutomationProperty CanMoveProperty;
+        public static readonly AutomationProperty CanResizeProperty;
+        public static readonly AutomationProperty CanRotateProperty;
+        public TransformPattern.TransformPatternInformation Cached { get; }
+        public TransformPattern.TransformPatternInformation Current { get; }
+        public void Move(double x, double y);
+        public void Resize(double width, double height);
+        public void Rotate(double degrees);
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct TransformPatternInformation {
+            public bool CanMove { get; }
+            public bool CanResize { get; }
+            public bool CanRotate { get; }
+        }
+    }
+    public static class TransformPatternIdentifiers {
+        public static readonly AutomationPattern Pattern;
+        public static readonly AutomationProperty CanMoveProperty;
+        public static readonly AutomationProperty CanResizeProperty;
+        public static readonly AutomationProperty CanRotateProperty;
+    }
+    public enum TreeScope {
+        Ancestors = 16,
+        Children = 2,
+        Descendants = 4,
+        Element = 1,
+        Parent = 8,
+        Subtree = 7,
+    }
+    public sealed class TreeWalker {
+        public static readonly TreeWalker ContentViewWalker;
+        public static readonly TreeWalker ControlViewWalker;
+        public static readonly TreeWalker RawViewWalker;
+        public TreeWalker(Condition condition);
+        public Condition Condition { get; }
+        public AutomationElement GetFirstChild(AutomationElement element);
+        public AutomationElement GetFirstChild(AutomationElement element, CacheRequest request);
+        public AutomationElement GetLastChild(AutomationElement element);
+        public AutomationElement GetLastChild(AutomationElement element, CacheRequest request);
+        public AutomationElement GetNextSibling(AutomationElement element);
+        public AutomationElement GetNextSibling(AutomationElement element, CacheRequest request);
+        public AutomationElement GetParent(AutomationElement element);
+        public AutomationElement GetParent(AutomationElement element, CacheRequest request);
+        public AutomationElement GetPreviousSibling(AutomationElement element);
+        public AutomationElement GetPreviousSibling(AutomationElement element, CacheRequest request);
+        public AutomationElement Normalize(AutomationElement element);
+        public AutomationElement Normalize(AutomationElement element, CacheRequest request);
+    }
+    public class ValuePattern : BasePattern {
+        public static readonly AutomationPattern Pattern;
+        public static readonly AutomationProperty IsReadOnlyProperty;
+        public static readonly AutomationProperty ValueProperty;
+        public ValuePattern.ValuePatternInformation Cached { get; }
+        public ValuePattern.ValuePatternInformation Current { get; }
+        public void SetValue(string value);
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct ValuePatternInformation {
+            public bool IsReadOnly { get; }
+            public string Value { get; }
+        }
+    }
+    public static class ValuePatternIdentifiers {
+        public static readonly AutomationPattern Pattern;
+        public static readonly AutomationProperty IsReadOnlyProperty;
+        public static readonly AutomationProperty ValueProperty;
+    }
+    public class VirtualizedItemPattern : BasePattern {
+        public static readonly AutomationPattern Pattern;
+        public void Realize();
+    }
+    public static class VirtualizedItemPatternIdentifiers {
+        public static readonly AutomationPattern Pattern;
+    }
+    public sealed class WindowClosedEventArgs : AutomationEventArgs {
+        public WindowClosedEventArgs(int[] runtimeId);
+        public int[] GetRuntimeId();
+    }
+    public enum WindowInteractionState {
+        BlockedByModalWindow = 3,
+        Closing = 1,
+        NotResponding = 4,
+        ReadyForUserInteraction = 2,
+        Running = 0,
+    }
+    public class WindowPattern : BasePattern {
+        public static readonly AutomationEvent WindowClosedEvent;
+        public static readonly AutomationEvent WindowOpenedEvent;
+        public static readonly AutomationPattern Pattern;
+        public static readonly AutomationProperty CanMaximizeProperty;
+        public static readonly AutomationProperty CanMinimizeProperty;
+        public static readonly AutomationProperty IsModalProperty;
+        public static readonly AutomationProperty IsTopmostProperty;
+        public static readonly AutomationProperty WindowInteractionStateProperty;
+        public static readonly AutomationProperty WindowVisualStateProperty;
+        public WindowPattern.WindowPatternInformation Cached { get; }
+        public WindowPattern.WindowPatternInformation Current { get; }
+        public void Close();
+        public void SetWindowVisualState(WindowVisualState state);
+        public bool WaitForInputIdle(int milliseconds);
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct WindowPatternInformation {
+            public bool CanMaximize { get; }
+            public bool CanMinimize { get; }
+            public bool IsModal { get; }
+            public bool IsTopmost { get; }
+            public WindowInteractionState WindowInteractionState { get; }
+            public WindowVisualState WindowVisualState { get; }
+        }
+    }
+    public static class WindowPatternIdentifiers {
+        public static readonly AutomationEvent WindowClosedEvent;
+        public static readonly AutomationEvent WindowOpenedEvent;
+        public static readonly AutomationPattern Pattern;
+        public static readonly AutomationProperty CanMaximizeProperty;
+        public static readonly AutomationProperty CanMinimizeProperty;
+        public static readonly AutomationProperty IsModalProperty;
+        public static readonly AutomationProperty IsTopmostProperty;
+        public static readonly AutomationProperty WindowInteractionStateProperty;
+        public static readonly AutomationProperty WindowVisualStateProperty;
+    }
+    public enum WindowVisualState {
+        Maximized = 1,
+        Minimized = 2,
+        Normal = 0,
+    }
+}
```

