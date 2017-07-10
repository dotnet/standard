# System.Windows

``` diff
+namespace System.Windows {
+    public class Application : DispatcherObject, IHaveResources, IQueryAmbient {
+        public Application();
+        public static Application Current { get; }
+        public Window MainWindow { get; set; }
+        public IDictionary Properties { get; }
+        public static Assembly ResourceAssembly { get; set; }
+        public ResourceDictionary Resources { get; set; }
+        public ShutdownMode ShutdownMode { get; set; }
+        public Uri StartupUri { get; set; }
+        public WindowCollection Windows { get; }
+        public event EventHandler Activated;
+        public event EventHandler Deactivated;
+        public event DispatcherUnhandledExceptionEventHandler DispatcherUnhandledException;
+        public event ExitEventHandler Exit;
+        public event FragmentNavigationEventHandler FragmentNavigation;
+        public event LoadCompletedEventHandler LoadCompleted;
+        public event NavigatedEventHandler Navigated;
+        public event NavigatingCancelEventHandler Navigating;
+        public event NavigationFailedEventHandler NavigationFailed;
+        public event NavigationProgressEventHandler NavigationProgress;
+        public event NavigationStoppedEventHandler NavigationStopped;
+        public event SessionEndingCancelEventHandler SessionEnding;
+        public event StartupEventHandler Startup;
+        public object FindResource(object resourceKey);
+        public static StreamResourceInfo GetContentStream(Uri uriContent);
+        public static string GetCookie(Uri uri);
+        public static StreamResourceInfo GetRemoteStream(Uri uriRemote);
+        public static StreamResourceInfo GetResourceStream(Uri uriResource);
+        public static void LoadComponent(object component, Uri resourceLocator);
+        public static object LoadComponent(Uri resourceLocator);
+        protected virtual void OnActivated(EventArgs e);
+        protected virtual void OnDeactivated(EventArgs e);
+        protected virtual void OnExit(ExitEventArgs e);
+        protected virtual void OnFragmentNavigation(FragmentNavigationEventArgs e);
+        protected virtual void OnLoadCompleted(NavigationEventArgs e);
+        protected virtual void OnNavigated(NavigationEventArgs e);
+        protected virtual void OnNavigating(NavigatingCancelEventArgs e);
+        protected virtual void OnNavigationFailed(NavigationFailedEventArgs e);
+        protected virtual void OnNavigationProgress(NavigationProgressEventArgs e);
+        protected virtual void OnNavigationStopped(NavigationEventArgs e);
+        protected virtual void OnSessionEnding(SessionEndingCancelEventArgs e);
+        protected virtual void OnStartup(StartupEventArgs e);
+        public int Run();
+        public int Run(Window window);
+        public static void SetCookie(Uri uri, string value);
+        public void Shutdown();
+        public void Shutdown(int exitCode);
+        bool System.Windows.Markup.IQueryAmbient.IsAmbientPropertyAvailable(string propertyName);
+        public object TryFindResource(object resourceKey);
+    }
+    public abstract class AttachedPropertyBrowsableAttribute : Attribute {
+        protected AttachedPropertyBrowsableAttribute();
+    }
+    public sealed class AttachedPropertyBrowsableForChildrenAttribute : AttachedPropertyBrowsableAttribute {
+        public AttachedPropertyBrowsableForChildrenAttribute();
+        public bool IncludeDescendants { get; set; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+    }
+    public sealed class AttachedPropertyBrowsableForTypeAttribute : AttachedPropertyBrowsableAttribute {
+        public AttachedPropertyBrowsableForTypeAttribute(Type targetType);
+        public Type TargetType { get; }
+        public override object TypeId { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+    }
+    public sealed class AttachedPropertyBrowsableWhenAttributePresentAttribute : AttachedPropertyBrowsableAttribute {
+        public AttachedPropertyBrowsableWhenAttributePresentAttribute(Type attributeType);
+        public Type AttributeType { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+    }
+    public class AutoResizedEventArgs : EventArgs {
+        public AutoResizedEventArgs(Size size);
+        public Size Size { get; }
+    }
+    public delegate void AutoResizedEventHandler(object sender, AutoResizedEventArgs e);
+    public static class BaseCompatibilityPreferences {
+        public static bool FlowDispatcherSynchronizationContextPriority { get; set; }
+        public static bool InlineDispatcherSynchronizationContextSend { get; set; }
+        public static bool ReuseDispatcherSynchronizationContextInstance { get; set; }
+    }
+    public enum BaselineAlignment {
+        Baseline = 3,
+        Bottom = 2,
+        Center = 1,
+        Subscript = 6,
+        Superscript = 7,
+        TextBottom = 5,
+        TextTop = 4,
+        Top = 0,
+    }
+    public enum BaseValueSource {
+        Default = 1,
+        DefaultStyle = 3,
+        DefaultStyleTrigger = 4,
+        ImplicitStyleReference = 8,
+        Inherited = 2,
+        Local = 11,
+        ParentTemplate = 9,
+        ParentTemplateTrigger = 10,
+        Style = 5,
+        StyleTrigger = 7,
+        TemplateTrigger = 6,
+        Unknown = 0,
+    }
+    public static class Clipboard {
+        public static void Clear();
+        public static bool ContainsAudio();
+        public static bool ContainsData(string format);
+        public static bool ContainsFileDropList();
+        public static bool ContainsImage();
+        public static bool ContainsText();
+        public static bool ContainsText(TextDataFormat format);
+        public static void Flush();
+        public static Stream GetAudioStream();
+        public static object GetData(string format);
+        public static IDataObject GetDataObject();
+        public static StringCollection GetFileDropList();
+        public static BitmapSource GetImage();
+        public static string GetText();
+        public static string GetText(TextDataFormat format);
+        public static bool IsCurrent(IDataObject data);
+        public static void SetAudio(byte[] audioBytes);
+        public static void SetAudio(Stream audioStream);
+        public static void SetData(string format, object data);
+        public static void SetDataObject(object data);
+        public static void SetDataObject(object data, bool copy);
+        public static void SetFileDropList(StringCollection fileDropList);
+        public static void SetImage(BitmapSource image);
+        public static void SetText(string text);
+        public static void SetText(string text, TextDataFormat format);
+    }
+    public delegate object CoerceValueCallback(DependencyObject d, object baseValue);
+    public class ColorConvertedBitmapExtension : MarkupExtension {
+        public ColorConvertedBitmapExtension();
+        public ColorConvertedBitmapExtension(object image);
+        public override object ProvideValue(IServiceProvider serviceProvider);
+    }
+    public enum ColumnSpaceDistribution {
+        Between = 2,
+        Left = 0,
+        Right = 1,
+    }
+    public class ComponentResourceKey : ResourceKey {
+        public ComponentResourceKey();
+        public ComponentResourceKey(Type typeInTargetAssembly, object resourceId);
+        public override Assembly Assembly { get; }
+        public object ResourceId { get; set; }
+        public Type TypeInTargetAssembly { get; set; }
+        public override bool Equals(object o);
+        public override int GetHashCode();
+        public override string ToString();
+    }
+    public sealed class Condition : ISupportInitialize {
+        public Condition();
+        public Condition(BindingBase binding, object conditionValue);
+        public Condition(DependencyProperty conditionProperty, object conditionValue);
+        public Condition(DependencyProperty conditionProperty, object conditionValue, string sourceName);
+        public BindingBase Binding { get; set; }
+        public DependencyProperty Property { get; set; }
+        public string SourceName { get; set; }
+        public object Value { get; set; }
+        public static void ReceiveMarkupExtension(object targetObject, XamlSetMarkupExtensionEventArgs eventArgs);
+        public static void ReceiveTypeConverter(object targetObject, XamlSetTypeConverterEventArgs eventArgs);
+        void System.ComponentModel.ISupportInitialize.BeginInit();
+        void System.ComponentModel.ISupportInitialize.EndInit();
+    }
+    public sealed class ConditionCollection : Collection<Condition> {
+        public ConditionCollection();
+        public bool IsSealed { get; }
+        protected override void ClearItems();
+        protected override void InsertItem(int index, Condition item);
+        protected override void RemoveItem(int index);
+        protected override void SetItem(int index, Condition item);
+    }
+    public class ContentElement : DependencyObject, IAnimatable, IInputElement {
+        public static readonly DependencyProperty AllowDropProperty;
+        public static readonly DependencyProperty AreAnyTouchesCapturedProperty;
+        public static readonly DependencyProperty AreAnyTouchesCapturedWithinProperty;
+        public static readonly DependencyProperty AreAnyTouchesDirectlyOverProperty;
+        public static readonly DependencyProperty AreAnyTouchesOverProperty;
+        public static readonly DependencyProperty FocusableProperty;
+        public static readonly DependencyProperty IsEnabledProperty;
+        public static readonly DependencyProperty IsFocusedProperty;
+        public static readonly DependencyProperty IsKeyboardFocusedProperty;
+        public static readonly DependencyProperty IsKeyboardFocusWithinProperty;
+        public static readonly DependencyProperty IsMouseCapturedProperty;
+        public static readonly DependencyProperty IsMouseCaptureWithinProperty;
+        public static readonly DependencyProperty IsMouseDirectlyOverProperty;
+        public static readonly DependencyProperty IsMouseOverProperty;
+        public static readonly DependencyProperty IsStylusCapturedProperty;
+        public static readonly DependencyProperty IsStylusCaptureWithinProperty;
+        public static readonly DependencyProperty IsStylusDirectlyOverProperty;
+        public static readonly DependencyProperty IsStylusOverProperty;
+        public static readonly RoutedEvent DragEnterEvent;
+        public static readonly RoutedEvent DragLeaveEvent;
+        public static readonly RoutedEvent DragOverEvent;
+        public static readonly RoutedEvent DropEvent;
+        public static readonly RoutedEvent GiveFeedbackEvent;
+        public static readonly RoutedEvent GotFocusEvent;
+        public static readonly RoutedEvent GotKeyboardFocusEvent;
+        public static readonly RoutedEvent GotMouseCaptureEvent;
+        public static readonly RoutedEvent GotStylusCaptureEvent;
+        public static readonly RoutedEvent GotTouchCaptureEvent;
+        public static readonly RoutedEvent KeyDownEvent;
+        public static readonly RoutedEvent KeyUpEvent;
+        public static readonly RoutedEvent LostFocusEvent;
+        public static readonly RoutedEvent LostKeyboardFocusEvent;
+        public static readonly RoutedEvent LostMouseCaptureEvent;
+        public static readonly RoutedEvent LostStylusCaptureEvent;
+        public static readonly RoutedEvent LostTouchCaptureEvent;
+        public static readonly RoutedEvent MouseDownEvent;
+        public static readonly RoutedEvent MouseEnterEvent;
+        public static readonly RoutedEvent MouseLeaveEvent;
+        public static readonly RoutedEvent MouseLeftButtonDownEvent;
+        public static readonly RoutedEvent MouseLeftButtonUpEvent;
+        public static readonly RoutedEvent MouseMoveEvent;
+        public static readonly RoutedEvent MouseRightButtonDownEvent;
+        public static readonly RoutedEvent MouseRightButtonUpEvent;
+        public static readonly RoutedEvent MouseUpEvent;
+        public static readonly RoutedEvent MouseWheelEvent;
+        public static readonly RoutedEvent PreviewDragEnterEvent;
+        public static readonly RoutedEvent PreviewDragLeaveEvent;
+        public static readonly RoutedEvent PreviewDragOverEvent;
+        public static readonly RoutedEvent PreviewDropEvent;
+        public static readonly RoutedEvent PreviewGiveFeedbackEvent;
+        public static readonly RoutedEvent PreviewGotKeyboardFocusEvent;
+        public static readonly RoutedEvent PreviewKeyDownEvent;
+        public static readonly RoutedEvent PreviewKeyUpEvent;
+        public static readonly RoutedEvent PreviewLostKeyboardFocusEvent;
+        public static readonly RoutedEvent PreviewMouseDownEvent;
+        public static readonly RoutedEvent PreviewMouseLeftButtonDownEvent;
+        public static readonly RoutedEvent PreviewMouseLeftButtonUpEvent;
+        public static readonly RoutedEvent PreviewMouseMoveEvent;
+        public static readonly RoutedEvent PreviewMouseRightButtonDownEvent;
+        public static readonly RoutedEvent PreviewMouseRightButtonUpEvent;
+        public static readonly RoutedEvent PreviewMouseUpEvent;
+        public static readonly RoutedEvent PreviewMouseWheelEvent;
+        public static readonly RoutedEvent PreviewQueryContinueDragEvent;
+        public static readonly RoutedEvent PreviewStylusButtonDownEvent;
+        public static readonly RoutedEvent PreviewStylusButtonUpEvent;
+        public static readonly RoutedEvent PreviewStylusDownEvent;
+        public static readonly RoutedEvent PreviewStylusInAirMoveEvent;
+        public static readonly RoutedEvent PreviewStylusInRangeEvent;
+        public static readonly RoutedEvent PreviewStylusMoveEvent;
+        public static readonly RoutedEvent PreviewStylusOutOfRangeEvent;
+        public static readonly RoutedEvent PreviewStylusSystemGestureEvent;
+        public static readonly RoutedEvent PreviewStylusUpEvent;
+        public static readonly RoutedEvent PreviewTextInputEvent;
+        public static readonly RoutedEvent PreviewTouchDownEvent;
+        public static readonly RoutedEvent PreviewTouchMoveEvent;
+        public static readonly RoutedEvent PreviewTouchUpEvent;
+        public static readonly RoutedEvent QueryContinueDragEvent;
+        public static readonly RoutedEvent QueryCursorEvent;
+        public static readonly RoutedEvent StylusButtonDownEvent;
+        public static readonly RoutedEvent StylusButtonUpEvent;
+        public static readonly RoutedEvent StylusDownEvent;
+        public static readonly RoutedEvent StylusEnterEvent;
+        public static readonly RoutedEvent StylusInAirMoveEvent;
+        public static readonly RoutedEvent StylusInRangeEvent;
+        public static readonly RoutedEvent StylusLeaveEvent;
+        public static readonly RoutedEvent StylusMoveEvent;
+        public static readonly RoutedEvent StylusOutOfRangeEvent;
+        public static readonly RoutedEvent StylusSystemGestureEvent;
+        public static readonly RoutedEvent StylusUpEvent;
+        public static readonly RoutedEvent TextInputEvent;
+        public static readonly RoutedEvent TouchDownEvent;
+        public static readonly RoutedEvent TouchEnterEvent;
+        public static readonly RoutedEvent TouchLeaveEvent;
+        public static readonly RoutedEvent TouchMoveEvent;
+        public static readonly RoutedEvent TouchUpEvent;
+        public ContentElement();
+        public bool AllowDrop { get; set; }
+        public bool AreAnyTouchesCaptured { get; }
+        public bool AreAnyTouchesCapturedWithin { get; }
+        public bool AreAnyTouchesDirectlyOver { get; }
+        public bool AreAnyTouchesOver { get; }
+        public CommandBindingCollection CommandBindings { get; }
+        public bool Focusable { get; set; }
+        public bool HasAnimatedProperties { get; }
+        public InputBindingCollection InputBindings { get; }
+        public bool IsEnabled { get; set; }
+        protected virtual bool IsEnabledCore { get; }
+        public bool IsFocused { get; }
+        public bool IsInputMethodEnabled { get; }
+        public bool IsKeyboardFocused { get; }
+        public bool IsKeyboardFocusWithin { get; }
+        public bool IsMouseCaptured { get; }
+        public bool IsMouseCaptureWithin { get; }
+        public bool IsMouseDirectlyOver { get; }
+        public bool IsMouseOver { get; }
+        public bool IsStylusCaptured { get; }
+        public bool IsStylusCaptureWithin { get; }
+        public bool IsStylusDirectlyOver { get; }
+        public bool IsStylusOver { get; }
+        public IEnumerable<TouchDevice> TouchesCaptured { get; }
+        public IEnumerable<TouchDevice> TouchesCapturedWithin { get; }
+        public IEnumerable<TouchDevice> TouchesDirectlyOver { get; }
+        public IEnumerable<TouchDevice> TouchesOver { get; }
+        public event DragEventHandler DragEnter;
+        public event DragEventHandler DragLeave;
+        public event DragEventHandler DragOver;
+        public event DragEventHandler Drop;
+        public event DependencyPropertyChangedEventHandler FocusableChanged;
+        public event GiveFeedbackEventHandler GiveFeedback;
+        public event RoutedEventHandler GotFocus;
+        public event KeyboardFocusChangedEventHandler GotKeyboardFocus;
+        public event MouseEventHandler GotMouseCapture;
+        public event StylusEventHandler GotStylusCapture;
+        public event EventHandler<TouchEventArgs> GotTouchCapture;
+        public event DependencyPropertyChangedEventHandler IsEnabledChanged;
+        public event DependencyPropertyChangedEventHandler IsKeyboardFocusedChanged;
+        public event DependencyPropertyChangedEventHandler IsKeyboardFocusWithinChanged;
+        public event DependencyPropertyChangedEventHandler IsMouseCapturedChanged;
+        public event DependencyPropertyChangedEventHandler IsMouseCaptureWithinChanged;
+        public event DependencyPropertyChangedEventHandler IsMouseDirectlyOverChanged;
+        public event DependencyPropertyChangedEventHandler IsStylusCapturedChanged;
+        public event DependencyPropertyChangedEventHandler IsStylusCaptureWithinChanged;
+        public event DependencyPropertyChangedEventHandler IsStylusDirectlyOverChanged;
+        public event KeyEventHandler KeyDown;
+        public event KeyEventHandler KeyUp;
+        public event RoutedEventHandler LostFocus;
+        public event KeyboardFocusChangedEventHandler LostKeyboardFocus;
+        public event MouseEventHandler LostMouseCapture;
+        public event StylusEventHandler LostStylusCapture;
+        public event EventHandler<TouchEventArgs> LostTouchCapture;
+        public event MouseButtonEventHandler MouseDown;
+        public event MouseEventHandler MouseEnter;
+        public event MouseEventHandler MouseLeave;
+        public event MouseButtonEventHandler MouseLeftButtonDown;
+        public event MouseButtonEventHandler MouseLeftButtonUp;
+        public event MouseEventHandler MouseMove;
+        public event MouseButtonEventHandler MouseRightButtonDown;
+        public event MouseButtonEventHandler MouseRightButtonUp;
+        public event MouseButtonEventHandler MouseUp;
+        public event MouseWheelEventHandler MouseWheel;
+        public event DragEventHandler PreviewDragEnter;
+        public event DragEventHandler PreviewDragLeave;
+        public event DragEventHandler PreviewDragOver;
+        public event DragEventHandler PreviewDrop;
+        public event GiveFeedbackEventHandler PreviewGiveFeedback;
+        public event KeyboardFocusChangedEventHandler PreviewGotKeyboardFocus;
+        public event KeyEventHandler PreviewKeyDown;
+        public event KeyEventHandler PreviewKeyUp;
+        public event KeyboardFocusChangedEventHandler PreviewLostKeyboardFocus;
+        public event MouseButtonEventHandler PreviewMouseDown;
+        public event MouseButtonEventHandler PreviewMouseLeftButtonDown;
+        public event MouseButtonEventHandler PreviewMouseLeftButtonUp;
+        public event MouseEventHandler PreviewMouseMove;
+        public event MouseButtonEventHandler PreviewMouseRightButtonDown;
+        public event MouseButtonEventHandler PreviewMouseRightButtonUp;
+        public event MouseButtonEventHandler PreviewMouseUp;
+        public event MouseWheelEventHandler PreviewMouseWheel;
+        public event QueryContinueDragEventHandler PreviewQueryContinueDrag;
+        public event StylusButtonEventHandler PreviewStylusButtonDown;
+        public event StylusButtonEventHandler PreviewStylusButtonUp;
+        public event StylusDownEventHandler PreviewStylusDown;
+        public event StylusEventHandler PreviewStylusInAirMove;
+        public event StylusEventHandler PreviewStylusInRange;
+        public event StylusEventHandler PreviewStylusMove;
+        public event StylusEventHandler PreviewStylusOutOfRange;
+        public event StylusSystemGestureEventHandler PreviewStylusSystemGesture;
+        public event StylusEventHandler PreviewStylusUp;
+        public event TextCompositionEventHandler PreviewTextInput;
+        public event EventHandler<TouchEventArgs> PreviewTouchDown;
+        public event EventHandler<TouchEventArgs> PreviewTouchMove;
+        public event EventHandler<TouchEventArgs> PreviewTouchUp;
+        public event QueryContinueDragEventHandler QueryContinueDrag;
+        public event QueryCursorEventHandler QueryCursor;
+        public event StylusButtonEventHandler StylusButtonDown;
+        public event StylusButtonEventHandler StylusButtonUp;
+        public event StylusDownEventHandler StylusDown;
+        public event StylusEventHandler StylusEnter;
+        public event StylusEventHandler StylusInAirMove;
+        public event StylusEventHandler StylusInRange;
+        public event StylusEventHandler StylusLeave;
+        public event StylusEventHandler StylusMove;
+        public event StylusEventHandler StylusOutOfRange;
+        public event StylusSystemGestureEventHandler StylusSystemGesture;
+        public event StylusEventHandler StylusUp;
+        public event TextCompositionEventHandler TextInput;
+        public event EventHandler<TouchEventArgs> TouchDown;
+        public event EventHandler<TouchEventArgs> TouchEnter;
+        public event EventHandler<TouchEventArgs> TouchLeave;
+        public event EventHandler<TouchEventArgs> TouchMove;
+        public event EventHandler<TouchEventArgs> TouchUp;
+        public void AddHandler(RoutedEvent routedEvent, Delegate handler);
+        public void AddHandler(RoutedEvent routedEvent, Delegate handler, bool handledEventsToo);
+        public void AddToEventRoute(EventRoute route, RoutedEventArgs e);
+        public void ApplyAnimationClock(DependencyProperty dp, AnimationClock clock);
+        public void ApplyAnimationClock(DependencyProperty dp, AnimationClock clock, HandoffBehavior handoffBehavior);
+        public void BeginAnimation(DependencyProperty dp, AnimationTimeline animation);
+        public void BeginAnimation(DependencyProperty dp, AnimationTimeline animation, HandoffBehavior handoffBehavior);
+        public bool CaptureMouse();
+        public bool CaptureStylus();
+        public bool CaptureTouch(TouchDevice touchDevice);
+        public bool Focus();
+        public object GetAnimationBaseValue(DependencyProperty dp);
+        protected internal virtual DependencyObject GetUIParentCore();
+        public virtual bool MoveFocus(TraversalRequest request);
+        protected virtual AutomationPeer OnCreateAutomationPeer();
+        protected internal virtual void OnDragEnter(DragEventArgs e);
+        protected internal virtual void OnDragLeave(DragEventArgs e);
+        protected internal virtual void OnDragOver(DragEventArgs e);
+        protected internal virtual void OnDrop(DragEventArgs e);
+        protected internal virtual void OnGiveFeedback(GiveFeedbackEventArgs e);
+        protected virtual void OnGotFocus(RoutedEventArgs e);
+        protected internal virtual void OnGotKeyboardFocus(KeyboardFocusChangedEventArgs e);
+        protected internal virtual void OnGotMouseCapture(MouseEventArgs e);
+        protected internal virtual void OnGotStylusCapture(StylusEventArgs e);
+        protected internal virtual void OnGotTouchCapture(TouchEventArgs e);
+        protected virtual void OnIsKeyboardFocusedChanged(DependencyPropertyChangedEventArgs e);
+        protected virtual void OnIsKeyboardFocusWithinChanged(DependencyPropertyChangedEventArgs e);
+        protected virtual void OnIsMouseCapturedChanged(DependencyPropertyChangedEventArgs e);
+        protected virtual void OnIsMouseCaptureWithinChanged(DependencyPropertyChangedEventArgs e);
+        protected virtual void OnIsMouseDirectlyOverChanged(DependencyPropertyChangedEventArgs e);
+        protected virtual void OnIsStylusCapturedChanged(DependencyPropertyChangedEventArgs e);
+        protected virtual void OnIsStylusCaptureWithinChanged(DependencyPropertyChangedEventArgs e);
+        protected virtual void OnIsStylusDirectlyOverChanged(DependencyPropertyChangedEventArgs e);
+        protected internal virtual void OnKeyDown(KeyEventArgs e);
+        protected internal virtual void OnKeyUp(KeyEventArgs e);
+        protected virtual void OnLostFocus(RoutedEventArgs e);
+        protected internal virtual void OnLostKeyboardFocus(KeyboardFocusChangedEventArgs e);
+        protected internal virtual void OnLostMouseCapture(MouseEventArgs e);
+        protected internal virtual void OnLostStylusCapture(StylusEventArgs e);
+        protected internal virtual void OnLostTouchCapture(TouchEventArgs e);
+        protected internal virtual void OnMouseDown(MouseButtonEventArgs e);
+        protected internal virtual void OnMouseEnter(MouseEventArgs e);
+        protected internal virtual void OnMouseLeave(MouseEventArgs e);
+        protected internal virtual void OnMouseLeftButtonDown(MouseButtonEventArgs e);
+        protected internal virtual void OnMouseLeftButtonUp(MouseButtonEventArgs e);
+        protected internal virtual void OnMouseMove(MouseEventArgs e);
+        protected internal virtual void OnMouseRightButtonDown(MouseButtonEventArgs e);
+        protected internal virtual void OnMouseRightButtonUp(MouseButtonEventArgs e);
+        protected internal virtual void OnMouseUp(MouseButtonEventArgs e);
+        protected internal virtual void OnMouseWheel(MouseWheelEventArgs e);
+        protected internal virtual void OnPreviewDragEnter(DragEventArgs e);
+        protected internal virtual void OnPreviewDragLeave(DragEventArgs e);
+        protected internal virtual void OnPreviewDragOver(DragEventArgs e);
+        protected internal virtual void OnPreviewDrop(DragEventArgs e);
+        protected internal virtual void OnPreviewGiveFeedback(GiveFeedbackEventArgs e);
+        protected internal virtual void OnPreviewGotKeyboardFocus(KeyboardFocusChangedEventArgs e);
+        protected internal virtual void OnPreviewKeyDown(KeyEventArgs e);
+        protected internal virtual void OnPreviewKeyUp(KeyEventArgs e);
+        protected internal virtual void OnPreviewLostKeyboardFocus(KeyboardFocusChangedEventArgs e);
+        protected internal virtual void OnPreviewMouseDown(MouseButtonEventArgs e);
+        protected internal virtual void OnPreviewMouseLeftButtonDown(MouseButtonEventArgs e);
+        protected internal virtual void OnPreviewMouseLeftButtonUp(MouseButtonEventArgs e);
+        protected internal virtual void OnPreviewMouseMove(MouseEventArgs e);
+        protected internal virtual void OnPreviewMouseRightButtonDown(MouseButtonEventArgs e);
+        protected internal virtual void OnPreviewMouseRightButtonUp(MouseButtonEventArgs e);
+        protected internal virtual void OnPreviewMouseUp(MouseButtonEventArgs e);
+        protected internal virtual void OnPreviewMouseWheel(MouseWheelEventArgs e);
+        protected internal virtual void OnPreviewQueryContinueDrag(QueryContinueDragEventArgs e);
+        protected internal virtual void OnPreviewStylusButtonDown(StylusButtonEventArgs e);
+        protected internal virtual void OnPreviewStylusButtonUp(StylusButtonEventArgs e);
+        protected internal virtual void OnPreviewStylusDown(StylusDownEventArgs e);
+        protected internal virtual void OnPreviewStylusInAirMove(StylusEventArgs e);
+        protected internal virtual void OnPreviewStylusInRange(StylusEventArgs e);
+        protected internal virtual void OnPreviewStylusMove(StylusEventArgs e);
+        protected internal virtual void OnPreviewStylusOutOfRange(StylusEventArgs e);
+        protected internal virtual void OnPreviewStylusSystemGesture(StylusSystemGestureEventArgs e);
+        protected internal virtual void OnPreviewStylusUp(StylusEventArgs e);
+        protected internal virtual void OnPreviewTextInput(TextCompositionEventArgs e);
+        protected internal virtual void OnPreviewTouchDown(TouchEventArgs e);
+        protected internal virtual void OnPreviewTouchMove(TouchEventArgs e);
+        protected internal virtual void OnPreviewTouchUp(TouchEventArgs e);
+        protected internal virtual void OnQueryContinueDrag(QueryContinueDragEventArgs e);
+        protected internal virtual void OnQueryCursor(QueryCursorEventArgs e);
+        protected internal virtual void OnStylusButtonDown(StylusButtonEventArgs e);
+        protected internal virtual void OnStylusButtonUp(StylusButtonEventArgs e);
+        protected internal virtual void OnStylusDown(StylusDownEventArgs e);
+        protected internal virtual void OnStylusEnter(StylusEventArgs e);
+        protected internal virtual void OnStylusInAirMove(StylusEventArgs e);
+        protected internal virtual void OnStylusInRange(StylusEventArgs e);
+        protected internal virtual void OnStylusLeave(StylusEventArgs e);
+        protected internal virtual void OnStylusMove(StylusEventArgs e);
+        protected internal virtual void OnStylusOutOfRange(StylusEventArgs e);
+        protected internal virtual void OnStylusSystemGesture(StylusSystemGestureEventArgs e);
+        protected internal virtual void OnStylusUp(StylusEventArgs e);
+        protected internal virtual void OnTextInput(TextCompositionEventArgs e);
+        protected internal virtual void OnTouchDown(TouchEventArgs e);
+        protected internal virtual void OnTouchEnter(TouchEventArgs e);
+        protected internal virtual void OnTouchLeave(TouchEventArgs e);
+        protected internal virtual void OnTouchMove(TouchEventArgs e);
+        protected internal virtual void OnTouchUp(TouchEventArgs e);
+        public virtual DependencyObject PredictFocus(FocusNavigationDirection direction);
+        public void RaiseEvent(RoutedEventArgs e);
+        public void ReleaseAllTouchCaptures();
+        public void ReleaseMouseCapture();
+        public void ReleaseStylusCapture();
+        public bool ReleaseTouchCapture(TouchDevice touchDevice);
+        public void RemoveHandler(RoutedEvent routedEvent, Delegate handler);
+        public bool ShouldSerializeCommandBindings();
+        public bool ShouldSerializeInputBindings();
+    }
+    public static class ContentOperations {
+        public static DependencyObject GetParent(ContentElement reference);
+        public static void SetParent(ContentElement reference, DependencyObject parent);
+    }
+    public static class CoreCompatibilityPreferences {
+        public static Nullable<bool> EnableMultiMonitorDisplayClipping { get; set; }
+        public static bool IsAltKeyRequiredInAccessKeyDefaultScope { get; set; }
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct CornerRadius : IEquatable<CornerRadius> {
+        public CornerRadius(double uniformRadius);
+        public CornerRadius(double topLeft, double topRight, double bottomRight, double bottomLeft);
+        public double BottomLeft { get; set; }
+        public double BottomRight { get; set; }
+        public double TopLeft { get; set; }
+        public double TopRight { get; set; }
+        public override bool Equals(object obj);
+        public bool Equals(CornerRadius cornerRadius);
+        public override int GetHashCode();
+        public static bool operator ==(CornerRadius cr1, CornerRadius cr2);
+        public static bool operator !=(CornerRadius cr1, CornerRadius cr2);
+        public override string ToString();
+    }
+    public class CornerRadiusConverter : TypeConverter {
+        public CornerRadiusConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext typeDescriptorContext, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext typeDescriptorContext, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext typeDescriptorContext, CultureInfo cultureInfo, object source);
+        public override object ConvertTo(ITypeDescriptorContext typeDescriptorContext, CultureInfo cultureInfo, object value, Type destinationType);
+    }
+    public class CultureInfoIetfLanguageTagConverter : TypeConverter {
+        public CultureInfoIetfLanguageTagConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext typeDescriptorContext, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext typeDescriptorContext, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext typeDescriptorContext, CultureInfo cultureInfo, object source);
+        public override object ConvertTo(ITypeDescriptorContext typeDescriptorContext, CultureInfo cultureInfo, object value, Type destinationType);
+    }
+    public sealed class DataFormat {
+        public DataFormat(string name, int id);
+        public int Id { get; }
+        public string Name { get; }
+    }
+    public static class DataFormats {
+        public static readonly string Bitmap;
+        public static readonly string CommaSeparatedValue;
+        public static readonly string Dib;
+        public static readonly string Dif;
+        public static readonly string EnhancedMetafile;
+        public static readonly string FileDrop;
+        public static readonly string Html;
+        public static readonly string Locale;
+        public static readonly string MetafilePicture;
+        public static readonly string OemText;
+        public static readonly string Palette;
+        public static readonly string PenData;
+        public static readonly string Riff;
+        public static readonly string Rtf;
+        public static readonly string Serializable;
+        public static readonly string StringFormat;
+        public static readonly string SymbolicLink;
+        public static readonly string Text;
+        public static readonly string Tiff;
+        public static readonly string UnicodeText;
+        public static readonly string WaveAudio;
+        public static readonly string Xaml;
+        public static readonly string XamlPackage;
+        public static DataFormat GetDataFormat(int id);
+        public static DataFormat GetDataFormat(string format);
+    }
+    public sealed class DataObject : IDataObject, IDataObject {
+        public static readonly RoutedEvent CopyingEvent;
+        public static readonly RoutedEvent PastingEvent;
+        public static readonly RoutedEvent SettingDataEvent;
+        public DataObject();
+        public DataObject(object data);
+        public DataObject(string format, object data);
+        public DataObject(string format, object data, bool autoConvert);
+        public DataObject(Type format, object data);
+        public static void AddCopyingHandler(DependencyObject element, DataObjectCopyingEventHandler handler);
+        public static void AddPastingHandler(DependencyObject element, DataObjectPastingEventHandler handler);
+        public static void AddSettingDataHandler(DependencyObject element, DataObjectSettingDataEventHandler handler);
+        public bool ContainsAudio();
+        public bool ContainsFileDropList();
+        public bool ContainsImage();
+        public bool ContainsText();
+        public bool ContainsText(TextDataFormat format);
+        public Stream GetAudioStream();
+        public object GetData(string format);
+        public object GetData(string format, bool autoConvert);
+        public object GetData(Type format);
+        public bool GetDataPresent(string format);
+        public bool GetDataPresent(string format, bool autoConvert);
+        public bool GetDataPresent(Type format);
+        public StringCollection GetFileDropList();
+        public string[] GetFormats();
+        public string[] GetFormats(bool autoConvert);
+        public BitmapSource GetImage();
+        public string GetText();
+        public string GetText(TextDataFormat format);
+        public static void RemoveCopyingHandler(DependencyObject element, DataObjectCopyingEventHandler handler);
+        public static void RemovePastingHandler(DependencyObject element, DataObjectPastingEventHandler handler);
+        public static void RemoveSettingDataHandler(DependencyObject element, DataObjectSettingDataEventHandler handler);
+        public void SetAudio(byte[] audioBytes);
+        public void SetAudio(Stream audioStream);
+        public void SetData(object data);
+        public void SetData(string format, object data);
+        public void SetData(string format, object data, bool autoConvert);
+        public void SetData(Type format, object data);
+        public void SetFileDropList(StringCollection fileDropList);
+        public void SetImage(BitmapSource image);
+        public void SetText(string textData);
+        public void SetText(string textData, TextDataFormat format);
+        int System.Runtime.InteropServices.ComTypes.IDataObject.DAdvise(ref FORMATETC pFormatetc, ADVF advf, IAdviseSink pAdvSink, out int pdwConnection);
+        void System.Runtime.InteropServices.ComTypes.IDataObject.DUnadvise(int dwConnection);
+        int System.Runtime.InteropServices.ComTypes.IDataObject.EnumDAdvise(out IEnumSTATDATA enumAdvise);
+        IEnumFORMATETC System.Runtime.InteropServices.ComTypes.IDataObject.EnumFormatEtc(DATADIR dwDirection);
+        int System.Runtime.InteropServices.ComTypes.IDataObject.GetCanonicalFormatEtc(ref FORMATETC pformatetcIn, out FORMATETC pformatetcOut);
+        void System.Runtime.InteropServices.ComTypes.IDataObject.GetData(ref FORMATETC formatetc, out STGMEDIUM medium);
+        void System.Runtime.InteropServices.ComTypes.IDataObject.GetDataHere(ref FORMATETC formatetc, ref STGMEDIUM medium);
+        int System.Runtime.InteropServices.ComTypes.IDataObject.QueryGetData(ref FORMATETC formatetc);
+        void System.Runtime.InteropServices.ComTypes.IDataObject.SetData(ref FORMATETC pFormatetcIn, ref STGMEDIUM pmedium, bool fRelease);
+    }
+    public sealed class DataObjectCopyingEventArgs : DataObjectEventArgs {
+        public DataObjectCopyingEventArgs(IDataObject dataObject, bool isDragDrop);
+        public IDataObject DataObject { get; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void DataObjectCopyingEventHandler(object sender, DataObjectCopyingEventArgs e);
+    public abstract class DataObjectEventArgs : RoutedEventArgs {
+        public bool CommandCancelled { get; }
+        public bool IsDragDrop { get; }
+        public void CancelCommand();
+    }
+    public sealed class DataObjectPastingEventArgs : DataObjectEventArgs {
+        public DataObjectPastingEventArgs(IDataObject dataObject, bool isDragDrop, string formatToApply);
+        public IDataObject DataObject { get; set; }
+        public string FormatToApply { get; set; }
+        public IDataObject SourceDataObject { get; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void DataObjectPastingEventHandler(object sender, DataObjectPastingEventArgs e);
+    public sealed class DataObjectSettingDataEventArgs : DataObjectEventArgs {
+        public DataObjectSettingDataEventArgs(IDataObject dataObject, string format);
+        public IDataObject DataObject { get; }
+        public string Format { get; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void DataObjectSettingDataEventHandler(object sender, DataObjectSettingDataEventArgs e);
+    public class DataTemplate : FrameworkTemplate {
+        public DataTemplate();
+        public DataTemplate(object dataType);
+        public object DataTemplateKey { get; }
+        public object DataType { get; set; }
+        public TriggerCollection Triggers { get; }
+        protected override void ValidateTemplatedParent(FrameworkElement templatedParent);
+    }
+    public class DataTemplateKey : TemplateKey {
+        public DataTemplateKey();
+        public DataTemplateKey(object dataType);
+    }
+    public class DataTrigger : TriggerBase, IAddChild {
+        public DataTrigger();
+        public BindingBase Binding { get; set; }
+        public SetterBaseCollection Setters { get; }
+        public object Value { get; set; }
+        public static void ReceiveMarkupExtension(object targetObject, XamlSetMarkupExtensionEventArgs eventArgs);
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public class DeferrableContent
+    public class DeferrableContentConverter : TypeConverter {
+        public DeferrableContentConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+    }
+    public class DependencyObject : DispatcherObject {
+        public DependencyObject();
+        public DependencyObjectType DependencyObjectType { get; }
+        public bool IsSealed { get; }
+        public void ClearValue(DependencyProperty dp);
+        public void ClearValue(DependencyPropertyKey key);
+        public void CoerceValue(DependencyProperty dp);
+        public sealed override bool Equals(object obj);
+        public sealed override int GetHashCode();
+        public LocalValueEnumerator GetLocalValueEnumerator();
+        public object GetValue(DependencyProperty dp);
+        public void InvalidateProperty(DependencyProperty dp);
+        protected virtual void OnPropertyChanged(DependencyPropertyChangedEventArgs e);
+        public object ReadLocalValue(DependencyProperty dp);
+        public void SetCurrentValue(DependencyProperty dp, object value);
+        public void SetValue(DependencyProperty dp, object value);
+        public void SetValue(DependencyPropertyKey key, object value);
+        protected internal virtual bool ShouldSerializeProperty(DependencyProperty dp);
+    }
+    public class DependencyObjectType {
+        public DependencyObjectType BaseType { get; }
+        public int Id { get; }
+        public string Name { get; }
+        public Type SystemType { get; }
+        public static DependencyObjectType FromSystemType(Type systemType);
+        public override int GetHashCode();
+        public bool IsInstanceOfType(DependencyObject dependencyObject);
+        public bool IsSubclassOf(DependencyObjectType dependencyObjectType);
+    }
+    public sealed class DependencyProperty {
+        public static readonly object UnsetValue;
+        public PropertyMetadata DefaultMetadata { get; }
+        public int GlobalIndex { get; }
+        public string Name { get; }
+        public Type OwnerType { get; }
+        public Type PropertyType { get; }
+        public bool ReadOnly { get; }
+        public ValidateValueCallback ValidateValueCallback { get; }
+        public DependencyProperty AddOwner(Type ownerType);
+        public DependencyProperty AddOwner(Type ownerType, PropertyMetadata typeMetadata);
+        public override int GetHashCode();
+        public PropertyMetadata GetMetadata(Type forType);
+        public PropertyMetadata GetMetadata(DependencyObject dependencyObject);
+        public PropertyMetadata GetMetadata(DependencyObjectType dependencyObjectType);
+        public bool IsValidType(object value);
+        public bool IsValidValue(object value);
+        public void OverrideMetadata(Type forType, PropertyMetadata typeMetadata);
+        public void OverrideMetadata(Type forType, PropertyMetadata typeMetadata, DependencyPropertyKey key);
+        public static DependencyProperty Register(string name, Type propertyType, Type ownerType);
+        public static DependencyProperty Register(string name, Type propertyType, Type ownerType, PropertyMetadata typeMetadata);
+        public static DependencyProperty Register(string name, Type propertyType, Type ownerType, PropertyMetadata typeMetadata, ValidateValueCallback validateValueCallback);
+        public static DependencyProperty RegisterAttached(string name, Type propertyType, Type ownerType);
+        public static DependencyProperty RegisterAttached(string name, Type propertyType, Type ownerType, PropertyMetadata defaultMetadata);
+        public static DependencyProperty RegisterAttached(string name, Type propertyType, Type ownerType, PropertyMetadata defaultMetadata, ValidateValueCallback validateValueCallback);
+        public static DependencyPropertyKey RegisterAttachedReadOnly(string name, Type propertyType, Type ownerType, PropertyMetadata defaultMetadata);
+        public static DependencyPropertyKey RegisterAttachedReadOnly(string name, Type propertyType, Type ownerType, PropertyMetadata defaultMetadata, ValidateValueCallback validateValueCallback);
+        public static DependencyPropertyKey RegisterReadOnly(string name, Type propertyType, Type ownerType, PropertyMetadata typeMetadata);
+        public static DependencyPropertyKey RegisterReadOnly(string name, Type propertyType, Type ownerType, PropertyMetadata typeMetadata, ValidateValueCallback validateValueCallback);
+        public override string ToString();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct DependencyPropertyChangedEventArgs {
+        public DependencyPropertyChangedEventArgs(DependencyProperty property, object oldValue, object newValue);
+        public object NewValue { get; }
+        public object OldValue { get; }
+        public DependencyProperty Property { get; }
+        public override bool Equals(object obj);
+        public bool Equals(DependencyPropertyChangedEventArgs args);
+        public override int GetHashCode();
+        public static bool operator ==(DependencyPropertyChangedEventArgs left, DependencyPropertyChangedEventArgs right);
+        public static bool operator !=(DependencyPropertyChangedEventArgs left, DependencyPropertyChangedEventArgs right);
+    }
+    public delegate void DependencyPropertyChangedEventHandler(object sender, DependencyPropertyChangedEventArgs e);
+    public static class DependencyPropertyHelper {
+        public static ValueSource GetValueSource(DependencyObject dependencyObject, DependencyProperty dependencyProperty);
+    }
+    public sealed class DependencyPropertyKey {
+        public DependencyProperty DependencyProperty { get; }
+        public void OverrideMetadata(Type forType, PropertyMetadata typeMetadata);
+    }
+    public class DialogResultConverter : TypeConverter {
+        public DialogResultConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext typeDescriptorContext, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext typeDescriptorContext, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext typeDescriptorContext, CultureInfo cultureInfo, object source);
+        public override object ConvertTo(ITypeDescriptorContext typeDescriptorContext, CultureInfo cultureInfo, object value, Type destinationType);
+    }
+    public enum DragAction {
+        Cancel = 2,
+        Continue = 0,
+        Drop = 1,
+    }
+    public static class DragDrop {
+        public static readonly RoutedEvent DragEnterEvent;
+        public static readonly RoutedEvent DragLeaveEvent;
+        public static readonly RoutedEvent DragOverEvent;
+        public static readonly RoutedEvent DropEvent;
+        public static readonly RoutedEvent GiveFeedbackEvent;
+        public static readonly RoutedEvent PreviewDragEnterEvent;
+        public static readonly RoutedEvent PreviewDragLeaveEvent;
+        public static readonly RoutedEvent PreviewDragOverEvent;
+        public static readonly RoutedEvent PreviewDropEvent;
+        public static readonly RoutedEvent PreviewGiveFeedbackEvent;
+        public static readonly RoutedEvent PreviewQueryContinueDragEvent;
+        public static readonly RoutedEvent QueryContinueDragEvent;
+        public static void AddDragEnterHandler(DependencyObject element, DragEventHandler handler);
+        public static void AddDragLeaveHandler(DependencyObject element, DragEventHandler handler);
+        public static void AddDragOverHandler(DependencyObject element, DragEventHandler handler);
+        public static void AddDropHandler(DependencyObject element, DragEventHandler handler);
+        public static void AddGiveFeedbackHandler(DependencyObject element, GiveFeedbackEventHandler handler);
+        public static void AddPreviewDragEnterHandler(DependencyObject element, DragEventHandler handler);
+        public static void AddPreviewDragLeaveHandler(DependencyObject element, DragEventHandler handler);
+        public static void AddPreviewDragOverHandler(DependencyObject element, DragEventHandler handler);
+        public static void AddPreviewDropHandler(DependencyObject element, DragEventHandler handler);
+        public static void AddPreviewGiveFeedbackHandler(DependencyObject element, GiveFeedbackEventHandler handler);
+        public static void AddPreviewQueryContinueDragHandler(DependencyObject element, QueryContinueDragEventHandler handler);
+        public static void AddQueryContinueDragHandler(DependencyObject element, QueryContinueDragEventHandler handler);
+        public static DragDropEffects DoDragDrop(DependencyObject dragSource, object data, DragDropEffects allowedEffects);
+        public static void RemoveDragEnterHandler(DependencyObject element, DragEventHandler handler);
+        public static void RemoveDragLeaveHandler(DependencyObject element, DragEventHandler handler);
+        public static void RemoveDragOverHandler(DependencyObject element, DragEventHandler handler);
+        public static void RemoveDropHandler(DependencyObject element, DragEventHandler handler);
+        public static void RemoveGiveFeedbackHandler(DependencyObject element, GiveFeedbackEventHandler handler);
+        public static void RemovePreviewDragEnterHandler(DependencyObject element, DragEventHandler handler);
+        public static void RemovePreviewDragLeaveHandler(DependencyObject element, DragEventHandler handler);
+        public static void RemovePreviewDragOverHandler(DependencyObject element, DragEventHandler handler);
+        public static void RemovePreviewDropHandler(DependencyObject element, DragEventHandler handler);
+        public static void RemovePreviewGiveFeedbackHandler(DependencyObject element, GiveFeedbackEventHandler handler);
+        public static void RemovePreviewQueryContinueDragHandler(DependencyObject element, QueryContinueDragEventHandler handler);
+        public static void RemoveQueryContinueDragHandler(DependencyObject element, QueryContinueDragEventHandler handler);
+    }
+    public enum DragDropEffects {
+        All = -2147483645,
+        Copy = 1,
+        Link = 4,
+        Move = 2,
+        None = 0,
+        Scroll = -2147483648,
+    }
+    public enum DragDropKeyStates {
+        AltKey = 32,
+        ControlKey = 8,
+        LeftMouseButton = 1,
+        MiddleMouseButton = 16,
+        None = 0,
+        RightMouseButton = 2,
+        ShiftKey = 4,
+    }
+    public sealed class DragEventArgs : RoutedEventArgs {
+        public DragDropEffects AllowedEffects { get; }
+        public IDataObject Data { get; }
+        public DragDropEffects Effects { get; set; }
+        public DragDropKeyStates KeyStates { get; }
+        public Point GetPosition(IInputElement relativeTo);
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void DragEventHandler(object sender, DragEventArgs e);
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct Duration {
+        public Duration(TimeSpan timeSpan);
+        public static Duration Automatic { get; }
+        public static Duration Forever { get; }
+        public bool HasTimeSpan { get; }
+        public TimeSpan TimeSpan { get; }
+        public Duration Add(Duration duration);
+        public static int Compare(Duration t1, Duration t2);
+        public override bool Equals(object value);
+        public bool Equals(Duration duration);
+        public static bool Equals(Duration t1, Duration t2);
+        public override int GetHashCode();
+        public static Duration operator +(Duration t1, Duration t2);
+        public static bool operator ==(Duration t1, Duration t2);
+        public static bool operator >(Duration t1, Duration t2);
+        public static bool operator >=(Duration t1, Duration t2);
+        public static implicit operator Duration (TimeSpan timeSpan);
+        public static bool operator !=(Duration t1, Duration t2);
+        public static bool operator <(Duration t1, Duration t2);
+        public static bool operator <=(Duration t1, Duration t2);
+        public static Duration operator -(Duration t1, Duration t2);
+        public static Duration operator +(Duration duration);
+        public static Duration Plus(Duration duration);
+        public Duration Subtract(Duration duration);
+        public override string ToString();
+    }
+    public class DurationConverter : TypeConverter {
+        public DurationConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext td, Type t);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext td, CultureInfo cultureInfo, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo cultureInfo, object value, Type destinationType);
+    }
+    public class DynamicResourceExtension : MarkupExtension {
+        public DynamicResourceExtension();
+        public DynamicResourceExtension(object resourceKey);
+        public object ResourceKey { get; set; }
+        public override object ProvideValue(IServiceProvider serviceProvider);
+    }
+    public class DynamicResourceExtensionConverter : TypeConverter {
+        public DynamicResourceExtensionConverter();
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public static class EventManager {
+        public static RoutedEvent[] GetRoutedEvents();
+        public static RoutedEvent[] GetRoutedEventsForOwner(Type ownerType);
+        public static void RegisterClassHandler(Type classType, RoutedEvent routedEvent, Delegate handler);
+        public static void RegisterClassHandler(Type classType, RoutedEvent routedEvent, Delegate handler, bool handledEventsToo);
+        public static RoutedEvent RegisterRoutedEvent(string name, RoutingStrategy routingStrategy, Type handlerType, Type ownerType);
+    }
+    public class EventPrivateKey {
+        public EventPrivateKey();
+    }
+    public sealed class EventRoute {
+        public EventRoute(RoutedEvent routedEvent);
+        public void Add(object target, Delegate handler, bool handledEventsToo);
+        public object PeekBranchNode();
+        public object PeekBranchSource();
+        public object PopBranchNode();
+        public void PushBranchNode(object node, object source);
+    }
+    public class EventSetter : SetterBase {
+        public EventSetter();
+        public EventSetter(RoutedEvent routedEvent, Delegate handler);
+        public RoutedEvent Event { get; set; }
+        public bool HandledEventsToo { get; set; }
+        public Delegate Handler { get; set; }
+    }
+    public class EventTrigger : TriggerBase, IAddChild {
+        public EventTrigger();
+        public EventTrigger(RoutedEvent routedEvent);
+        public TriggerActionCollection Actions { get; }
+        public RoutedEvent RoutedEvent { get; set; }
+        public string SourceName { get; set; }
+        protected virtual void AddChild(object value);
+        protected virtual void AddText(string text);
+        public bool ShouldSerializeActions();
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public sealed class ExceptionRoutedEventArgs : RoutedEventArgs {
+        public Exception ErrorException { get; }
+    }
+    public class ExitEventArgs : EventArgs {
+        public int ApplicationExitCode { get; set; }
+    }
+    public delegate void ExitEventHandler(object sender, ExitEventArgs e);
+    public class Expression
+    public class ExpressionConverter : TypeConverter {
+        public ExpressionConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public enum FigureHorizontalAnchor {
+        ColumnCenter = 7,
+        ColumnLeft = 6,
+        ColumnRight = 8,
+        ContentCenter = 4,
+        ContentLeft = 3,
+        ContentRight = 5,
+        PageCenter = 1,
+        PageLeft = 0,
+        PageRight = 2,
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct FigureLength : IEquatable<FigureLength> {
+        public FigureLength(double pixels);
+        public FigureLength(double value, FigureUnitType type);
+        public FigureUnitType FigureUnitType { get; }
+        public bool IsAbsolute { get; }
+        public bool IsAuto { get; }
+        public bool IsColumn { get; }
+        public bool IsContent { get; }
+        public bool IsPage { get; }
+        public double Value { get; }
+        public override bool Equals(object oCompare);
+        public bool Equals(FigureLength figureLength);
+        public override int GetHashCode();
+        public static bool operator ==(FigureLength fl1, FigureLength fl2);
+        public static bool operator !=(FigureLength fl1, FigureLength fl2);
+        public override string ToString();
+    }
+    public class FigureLengthConverter : TypeConverter {
+        public FigureLengthConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext typeDescriptorContext, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext typeDescriptorContext, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext typeDescriptorContext, CultureInfo cultureInfo, object source);
+        public override object ConvertTo(ITypeDescriptorContext typeDescriptorContext, CultureInfo cultureInfo, object value, Type destinationType);
+    }
+    public enum FigureUnitType {
+        Auto = 0,
+        Column = 2,
+        Content = 3,
+        Page = 4,
+        Pixel = 1,
+    }
+    public enum FigureVerticalAnchor {
+        ContentBottom = 5,
+        ContentCenter = 4,
+        ContentTop = 3,
+        PageBottom = 2,
+        PageCenter = 1,
+        PageTop = 0,
+        ParagraphTop = 6,
+    }
+    public enum FlowDirection {
+        LeftToRight = 0,
+        RightToLeft = 1,
+    }
+    public enum FontCapitals {
+        AllPetiteCaps = 3,
+        AllSmallCaps = 1,
+        Normal = 0,
+        PetiteCaps = 4,
+        SmallCaps = 2,
+        Titling = 6,
+        Unicase = 5,
+    }
+    public enum FontEastAsianLanguage {
+        HojoKanji = 5,
+        Jis04 = 4,
+        Jis78 = 1,
+        Jis83 = 2,
+        Jis90 = 3,
+        NlcKanji = 6,
+        Normal = 0,
+        Simplified = 7,
+        Traditional = 8,
+        TraditionalNames = 9,
+    }
+    public enum FontEastAsianWidths {
+        Full = 2,
+        Half = 3,
+        Normal = 0,
+        Proportional = 1,
+        Quarter = 5,
+        Third = 4,
+    }
+    public enum FontFraction {
+        Normal = 0,
+        Slashed = 1,
+        Stacked = 2,
+    }
+    public enum FontNumeralAlignment {
+        Normal = 0,
+        Proportional = 1,
+        Tabular = 2,
+    }
+    public enum FontNumeralStyle {
+        Lining = 1,
+        Normal = 0,
+        OldStyle = 2,
+    }
+    public class FontSizeConverter : TypeConverter {
+        public FontSizeConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct FontStretch : IFormattable {
+        public static int Compare(FontStretch left, FontStretch right);
+        public override bool Equals(object obj);
+        public bool Equals(FontStretch obj);
+        public static FontStretch FromOpenTypeStretch(int stretchValue);
+        public override int GetHashCode();
+        public static bool operator ==(FontStretch left, FontStretch right);
+        public static bool operator >(FontStretch left, FontStretch right);
+        public static bool operator >=(FontStretch left, FontStretch right);
+        public static bool operator !=(FontStretch left, FontStretch right);
+        public static bool operator <(FontStretch left, FontStretch right);
+        public static bool operator <=(FontStretch left, FontStretch right);
+        string System.IFormattable.ToString(string format, IFormatProvider provider);
+        public int ToOpenTypeStretch();
+        public override string ToString();
+    }
+    public sealed class FontStretchConverter : TypeConverter {
+        public FontStretchConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext td, Type t);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext td, CultureInfo ci, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public static class FontStretches {
+        public static FontStretch Condensed { get; }
+        public static FontStretch Expanded { get; }
+        public static FontStretch ExtraCondensed { get; }
+        public static FontStretch ExtraExpanded { get; }
+        public static FontStretch Medium { get; }
+        public static FontStretch Normal { get; }
+        public static FontStretch SemiCondensed { get; }
+        public static FontStretch SemiExpanded { get; }
+        public static FontStretch UltraCondensed { get; }
+        public static FontStretch UltraExpanded { get; }
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct FontStyle : IFormattable {
+        public override bool Equals(object obj);
+        public bool Equals(FontStyle obj);
+        public override int GetHashCode();
+        public static bool operator ==(FontStyle left, FontStyle right);
+        public static bool operator !=(FontStyle left, FontStyle right);
+        string System.IFormattable.ToString(string format, IFormatProvider provider);
+        public override string ToString();
+    }
+    public sealed class FontStyleConverter : TypeConverter {
+        public FontStyleConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext td, Type t);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext td, CultureInfo ci, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public static class FontStyles {
+        public static FontStyle Italic { get; }
+        public static FontStyle Normal { get; }
+        public static FontStyle Oblique { get; }
+    }
+    public enum FontVariants {
+        Inferior = 4,
+        Normal = 0,
+        Ordinal = 3,
+        Ruby = 5,
+        Subscript = 2,
+        Superscript = 1,
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct FontWeight : IFormattable {
+        public static int Compare(FontWeight left, FontWeight right);
+        public override bool Equals(object obj);
+        public bool Equals(FontWeight obj);
+        public static FontWeight FromOpenTypeWeight(int weightValue);
+        public override int GetHashCode();
+        public static bool operator ==(FontWeight left, FontWeight right);
+        public static bool operator >(FontWeight left, FontWeight right);
+        public static bool operator >=(FontWeight left, FontWeight right);
+        public static bool operator !=(FontWeight left, FontWeight right);
+        public static bool operator <(FontWeight left, FontWeight right);
+        public static bool operator <=(FontWeight left, FontWeight right);
+        string System.IFormattable.ToString(string format, IFormatProvider provider);
+        public int ToOpenTypeWeight();
+        public override string ToString();
+    }
+    public sealed class FontWeightConverter : TypeConverter {
+        public FontWeightConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext td, Type t);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext td, CultureInfo ci, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public static class FontWeights {
+        public static FontWeight Black { get; }
+        public static FontWeight Bold { get; }
+        public static FontWeight DemiBold { get; }
+        public static FontWeight ExtraBlack { get; }
+        public static FontWeight ExtraBold { get; }
+        public static FontWeight ExtraLight { get; }
+        public static FontWeight Heavy { get; }
+        public static FontWeight Light { get; }
+        public static FontWeight Medium { get; }
+        public static FontWeight Normal { get; }
+        public static FontWeight Regular { get; }
+        public static FontWeight SemiBold { get; }
+        public static FontWeight Thin { get; }
+        public static FontWeight UltraBlack { get; }
+        public static FontWeight UltraBold { get; }
+        public static FontWeight UltraLight { get; }
+    }
+    public static class FrameworkCompatibilityPreferences {
+        public static bool AreInactiveSelectionHighlightBrushKeysSupported { get; set; }
+        public static bool KeepTextBoxDisplaySynchronizedWithTextProperty { get; set; }
+    }
+    public class FrameworkContentElement : ContentElement, IFrameworkInputElement, IInputElement, IQueryAmbient, ISupportInitialize {
+        public static readonly DependencyProperty BindingGroupProperty;
+        public static readonly DependencyProperty ContextMenuProperty;
+        public static readonly DependencyProperty CursorProperty;
+        public static readonly DependencyProperty DataContextProperty;
+        protected internal static readonly DependencyProperty DefaultStyleKeyProperty;
+        public static readonly DependencyProperty FocusVisualStyleProperty;
+        public static readonly DependencyProperty ForceCursorProperty;
+        public static readonly DependencyProperty InputScopeProperty;
+        public static readonly DependencyProperty LanguageProperty;
+        public static readonly DependencyProperty NameProperty;
+        public static readonly DependencyProperty OverridesDefaultStyleProperty;
+        public static readonly DependencyProperty StyleProperty;
+        public static readonly DependencyProperty TagProperty;
+        public static readonly DependencyProperty ToolTipProperty;
+        public static readonly RoutedEvent ContextMenuClosingEvent;
+        public static readonly RoutedEvent ContextMenuOpeningEvent;
+        public static readonly RoutedEvent LoadedEvent;
+        public static readonly RoutedEvent ToolTipClosingEvent;
+        public static readonly RoutedEvent ToolTipOpeningEvent;
+        public static readonly RoutedEvent UnloadedEvent;
+        public FrameworkContentElement();
+        public BindingGroup BindingGroup { get; set; }
+        public ContextMenu ContextMenu { get; set; }
+        public Cursor Cursor { get; set; }
+        public object DataContext { get; set; }
+        protected internal object DefaultStyleKey { get; set; }
+        public Style FocusVisualStyle { get; set; }
+        public bool ForceCursor { get; set; }
+        public InputScope InputScope { get; set; }
+        public bool IsInitialized { get; }
+        public bool IsLoaded { get; }
+        public XmlLanguage Language { get; set; }
+        protected internal virtual IEnumerator LogicalChildren { get; }
+        public string Name { get; set; }
+        public bool OverridesDefaultStyle { get; set; }
+        public DependencyObject Parent { get; }
+        public ResourceDictionary Resources { get; set; }
+        public Style Style { get; set; }
+        public object Tag { get; set; }
+        public DependencyObject TemplatedParent { get; }
+        public object ToolTip { get; set; }
+        public event ContextMenuEventHandler ContextMenuClosing;
+        public event ContextMenuEventHandler ContextMenuOpening;
+        public event DependencyPropertyChangedEventHandler DataContextChanged;
+        public event EventHandler Initialized;
+        public event RoutedEventHandler Loaded;
+        public event EventHandler<DataTransferEventArgs> SourceUpdated;
+        public event EventHandler<DataTransferEventArgs> TargetUpdated;
+        public event ToolTipEventHandler ToolTipClosing;
+        public event ToolTipEventHandler ToolTipOpening;
+        public event RoutedEventHandler Unloaded;
+        protected internal void AddLogicalChild(object child);
+        public virtual void BeginInit();
+        public void BeginStoryboard(Storyboard storyboard);
+        public void BeginStoryboard(Storyboard storyboard, HandoffBehavior handoffBehavior);
+        public void BeginStoryboard(Storyboard storyboard, HandoffBehavior handoffBehavior, bool isControllable);
+        public void BringIntoView();
+        public virtual void EndInit();
+        public object FindName(string name);
+        public object FindResource(object resourceKey);
+        public BindingExpression GetBindingExpression(DependencyProperty dp);
+        protected internal override DependencyObject GetUIParentCore();
+        public sealed override bool MoveFocus(TraversalRequest request);
+        protected virtual void OnContextMenuClosing(ContextMenuEventArgs e);
+        protected virtual void OnContextMenuOpening(ContextMenuEventArgs e);
+        protected override void OnGotFocus(RoutedEventArgs e);
+        protected virtual void OnInitialized(EventArgs e);
+        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e);
+        protected internal virtual void OnStyleChanged(Style oldStyle, Style newStyle);
+        protected virtual void OnToolTipClosing(ToolTipEventArgs e);
+        protected virtual void OnToolTipOpening(ToolTipEventArgs e);
+        public sealed override DependencyObject PredictFocus(FocusNavigationDirection direction);
+        public void RegisterName(string name, object scopedElement);
+        protected internal void RemoveLogicalChild(object child);
+        public BindingExpression SetBinding(DependencyProperty dp, string path);
+        public BindingExpressionBase SetBinding(DependencyProperty dp, BindingBase binding);
+        public void SetResourceReference(DependencyProperty dp, object name);
+        public bool ShouldSerializeResources();
+        public bool ShouldSerializeStyle();
+        bool System.Windows.Markup.IQueryAmbient.IsAmbientPropertyAvailable(string propertyName);
+        public object TryFindResource(object resourceKey);
+        public void UnregisterName(string name);
+        public void UpdateDefaultStyle();
+    }
+    public class FrameworkElement : UIElement, IFrameworkInputElement, IHaveResources, IInputElement, IQueryAmbient, ISupportInitialize {
+        public static readonly DependencyProperty ActualHeightProperty;
+        public static readonly DependencyProperty ActualWidthProperty;
+        public static readonly DependencyProperty BindingGroupProperty;
+        public static readonly DependencyProperty ContextMenuProperty;
+        public static readonly DependencyProperty CursorProperty;
+        public static readonly DependencyProperty DataContextProperty;
+        protected internal static readonly DependencyProperty DefaultStyleKeyProperty;
+        public static readonly DependencyProperty FlowDirectionProperty;
+        public static readonly DependencyProperty FocusVisualStyleProperty;
+        public static readonly DependencyProperty ForceCursorProperty;
+        public static readonly DependencyProperty HeightProperty;
+        public static readonly DependencyProperty HorizontalAlignmentProperty;
+        public static readonly DependencyProperty InputScopeProperty;
+        public static readonly DependencyProperty LanguageProperty;
+        public static readonly DependencyProperty LayoutTransformProperty;
+        public static readonly DependencyProperty MarginProperty;
+        public static readonly DependencyProperty MaxHeightProperty;
+        public static readonly DependencyProperty MaxWidthProperty;
+        public static readonly DependencyProperty MinHeightProperty;
+        public static readonly DependencyProperty MinWidthProperty;
+        public static readonly DependencyProperty NameProperty;
+        public static readonly DependencyProperty OverridesDefaultStyleProperty;
+        public static readonly DependencyProperty StyleProperty;
+        public static readonly DependencyProperty TagProperty;
+        public static readonly DependencyProperty ToolTipProperty;
+        public static readonly DependencyProperty UseLayoutRoundingProperty;
+        public static readonly DependencyProperty VerticalAlignmentProperty;
+        public static readonly DependencyProperty WidthProperty;
+        public static readonly RoutedEvent ContextMenuClosingEvent;
+        public static readonly RoutedEvent ContextMenuOpeningEvent;
+        public static readonly RoutedEvent LoadedEvent;
+        public static readonly RoutedEvent RequestBringIntoViewEvent;
+        public static readonly RoutedEvent SizeChangedEvent;
+        public static readonly RoutedEvent ToolTipClosingEvent;
+        public static readonly RoutedEvent ToolTipOpeningEvent;
+        public static readonly RoutedEvent UnloadedEvent;
+        public FrameworkElement();
+        public double ActualHeight { get; }
+        public double ActualWidth { get; }
+        public BindingGroup BindingGroup { get; set; }
+        public ContextMenu ContextMenu { get; set; }
+        public Cursor Cursor { get; set; }
+        public object DataContext { get; set; }
+        protected internal object DefaultStyleKey { get; set; }
+        public FlowDirection FlowDirection { get; set; }
+        public Style FocusVisualStyle { get; set; }
+        public bool ForceCursor { get; set; }
+        public double Height { get; set; }
+        public HorizontalAlignment HorizontalAlignment { get; set; }
+        protected internal InheritanceBehavior InheritanceBehavior { get; set; }
+        public InputScope InputScope { get; set; }
+        public bool IsInitialized { get; }
+        public bool IsLoaded { get; }
+        public XmlLanguage Language { get; set; }
+        public Transform LayoutTransform { get; set; }
+        protected internal virtual IEnumerator LogicalChildren { get; }
+        public Thickness Margin { get; set; }
+        public double MaxHeight { get; set; }
+        public double MaxWidth { get; set; }
+        public double MinHeight { get; set; }
+        public double MinWidth { get; set; }
+        public string Name { get; set; }
+        public bool OverridesDefaultStyle { get; set; }
+        public DependencyObject Parent { get; }
+        public ResourceDictionary Resources { get; set; }
+        public Style Style { get; set; }
+        public object Tag { get; set; }
+        public DependencyObject TemplatedParent { get; }
+        public object ToolTip { get; set; }
+        public TriggerCollection Triggers { get; }
+        public bool UseLayoutRounding { get; set; }
+        public VerticalAlignment VerticalAlignment { get; set; }
+        protected override int VisualChildrenCount { get; }
+        public double Width { get; set; }
+        public event ContextMenuEventHandler ContextMenuClosing;
+        public event ContextMenuEventHandler ContextMenuOpening;
+        public event DependencyPropertyChangedEventHandler DataContextChanged;
+        public event EventHandler Initialized;
+        public event RoutedEventHandler Loaded;
+        public event RequestBringIntoViewEventHandler RequestBringIntoView;
+        public event SizeChangedEventHandler SizeChanged;
+        public event EventHandler<DataTransferEventArgs> SourceUpdated;
+        public event EventHandler<DataTransferEventArgs> TargetUpdated;
+        public event ToolTipEventHandler ToolTipClosing;
+        public event ToolTipEventHandler ToolTipOpening;
+        public event RoutedEventHandler Unloaded;
+        protected internal void AddLogicalChild(object child);
+        public bool ApplyTemplate();
+        protected sealed override void ArrangeCore(Rect finalRect);
+        protected virtual Size ArrangeOverride(Size finalSize);
+        public virtual void BeginInit();
+        public void BeginStoryboard(Storyboard storyboard);
+        public void BeginStoryboard(Storyboard storyboard, HandoffBehavior handoffBehavior);
+        public void BeginStoryboard(Storyboard storyboard, HandoffBehavior handoffBehavior, bool isControllable);
+        public void BringIntoView();
+        public void BringIntoView(Rect targetRectangle);
+        public virtual void EndInit();
+        public object FindName(string name);
+        public object FindResource(object resourceKey);
+        public BindingExpression GetBindingExpression(DependencyProperty dp);
+        public static FlowDirection GetFlowDirection(DependencyObject element);
+        protected override Geometry GetLayoutClip(Size layoutSlotSize);
+        protected internal DependencyObject GetTemplateChild(string childName);
+        protected internal override DependencyObject GetUIParentCore();
+        protected override Visual GetVisualChild(int index);
+        protected sealed override Size MeasureCore(Size availableSize);
+        protected virtual Size MeasureOverride(Size availableSize);
+        public sealed override bool MoveFocus(TraversalRequest request);
+        public virtual void OnApplyTemplate();
+        protected virtual void OnContextMenuClosing(ContextMenuEventArgs e);
+        protected virtual void OnContextMenuOpening(ContextMenuEventArgs e);
+        protected override void OnGotFocus(RoutedEventArgs e);
+        protected virtual void OnInitialized(EventArgs e);
+        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e);
+        protected internal override void OnRenderSizeChanged(SizeChangedInfo sizeInfo);
+        protected internal virtual void OnStyleChanged(Style oldStyle, Style newStyle);
+        protected virtual void OnToolTipClosing(ToolTipEventArgs e);
+        protected virtual void OnToolTipOpening(ToolTipEventArgs e);
+        protected internal override void OnVisualParentChanged(DependencyObject oldParent);
+        protected internal virtual void ParentLayoutInvalidated(UIElement child);
+        public sealed override DependencyObject PredictFocus(FocusNavigationDirection direction);
+        public void RegisterName(string name, object scopedElement);
+        protected internal void RemoveLogicalChild(object child);
+        public BindingExpression SetBinding(DependencyProperty dp, string path);
+        public BindingExpressionBase SetBinding(DependencyProperty dp, BindingBase binding);
+        public static void SetFlowDirection(DependencyObject element, FlowDirection value);
+        public void SetResourceReference(DependencyProperty dp, object name);
+        public bool ShouldSerializeResources();
+        public bool ShouldSerializeStyle();
+        public bool ShouldSerializeTriggers();
+        bool System.Windows.Markup.IQueryAmbient.IsAmbientPropertyAvailable(string propertyName);
+        public object TryFindResource(object resourceKey);
+        public void UnregisterName(string name);
+        public void UpdateDefaultStyle();
+    }
+    public class FrameworkElementFactory {
+        public FrameworkElementFactory();
+        public FrameworkElementFactory(string text);
+        public FrameworkElementFactory(Type type);
+        public FrameworkElementFactory(Type type, string name);
+        public FrameworkElementFactory FirstChild { get; }
+        public bool IsSealed { get; }
+        public string Name { get; set; }
+        public FrameworkElementFactory NextSibling { get; }
+        public FrameworkElementFactory Parent { get; }
+        public string Text { get; set; }
+        public Type Type { get; set; }
+        public void AddHandler(RoutedEvent routedEvent, Delegate handler);
+        public void AddHandler(RoutedEvent routedEvent, Delegate handler, bool handledEventsToo);
+        public void AppendChild(FrameworkElementFactory child);
+        public void RemoveHandler(RoutedEvent routedEvent, Delegate handler);
+        public void SetBinding(DependencyProperty dp, BindingBase binding);
+        public void SetResourceReference(DependencyProperty dp, object name);
+        public void SetValue(DependencyProperty dp, object value);
+    }
+    public class FrameworkPropertyMetadata : UIPropertyMetadata {
+        public FrameworkPropertyMetadata();
+        public FrameworkPropertyMetadata(object defaultValue);
+        public FrameworkPropertyMetadata(object defaultValue, FrameworkPropertyMetadataOptions flags);
+        public FrameworkPropertyMetadata(object defaultValue, FrameworkPropertyMetadataOptions flags, PropertyChangedCallback propertyChangedCallback);
+        public FrameworkPropertyMetadata(object defaultValue, FrameworkPropertyMetadataOptions flags, PropertyChangedCallback propertyChangedCallback, CoerceValueCallback coerceValueCallback);
+        public FrameworkPropertyMetadata(object defaultValue, FrameworkPropertyMetadataOptions flags, PropertyChangedCallback propertyChangedCallback, CoerceValueCallback coerceValueCallback, bool isAnimationProhibited);
+        public FrameworkPropertyMetadata(object defaultValue, FrameworkPropertyMetadataOptions flags, PropertyChangedCallback propertyChangedCallback, CoerceValueCallback coerceValueCallback, bool isAnimationProhibited, UpdateSourceTrigger defaultUpdateSourceTrigger);
+        public FrameworkPropertyMetadata(object defaultValue, PropertyChangedCallback propertyChangedCallback);
+        public FrameworkPropertyMetadata(object defaultValue, PropertyChangedCallback propertyChangedCallback, CoerceValueCallback coerceValueCallback);
+        public FrameworkPropertyMetadata(PropertyChangedCallback propertyChangedCallback);
+        public FrameworkPropertyMetadata(PropertyChangedCallback propertyChangedCallback, CoerceValueCallback coerceValueCallback);
+        public bool AffectsArrange { get; set; }
+        public bool AffectsMeasure { get; set; }
+        public bool AffectsParentArrange { get; set; }
+        public bool AffectsParentMeasure { get; set; }
+        public bool AffectsRender { get; set; }
+        public bool BindsTwoWayByDefault { get; set; }
+        public UpdateSourceTrigger DefaultUpdateSourceTrigger { get; set; }
+        public bool Inherits { get; set; }
+        public bool IsDataBindingAllowed { get; }
+        public bool IsNotDataBindable { get; set; }
+        public bool Journal { get; set; }
+        public bool OverridesInheritanceBehavior { get; set; }
+        public bool SubPropertiesDoNotAffectRender { get; set; }
+        protected override void Merge(PropertyMetadata baseMetadata, DependencyProperty dp);
+        protected override void OnApply(DependencyProperty dp, Type targetType);
+    }
+    public enum FrameworkPropertyMetadataOptions {
+        AffectsArrange = 2,
+        AffectsMeasure = 1,
+        AffectsParentArrange = 8,
+        AffectsParentMeasure = 4,
+        AffectsRender = 16,
+        BindsTwoWayByDefault = 256,
+        Inherits = 32,
+        Journal = 1024,
+        None = 0,
+        NotDataBindable = 128,
+        OverridesInheritanceBehavior = 64,
+        SubPropertiesDoNotAffectRender = 2048,
+    }
+    public abstract class FrameworkTemplate : DispatcherObject, IHaveResources, INameScope, IQueryAmbient, ISealable {
+        protected FrameworkTemplate();
+        public bool HasContent { get; }
+        public bool IsSealed { get; }
+        public ResourceDictionary Resources { get; set; }
+        public TemplateContent Template { get; set; }
+        public FrameworkElementFactory VisualTree { get; set; }
+        public object FindName(string name, FrameworkElement templatedParent);
+        public DependencyObject LoadContent();
+        public void RegisterName(string name, object scopedElement);
+        public void Seal();
+        public bool ShouldSerializeResources(XamlDesignerSerializationManager manager);
+        public bool ShouldSerializeVisualTree();
+        object System.Windows.Markup.INameScope.FindName(string name);
+        bool System.Windows.Markup.IQueryAmbient.IsAmbientPropertyAvailable(string propertyName);
+        public void UnregisterName(string name);
+        protected virtual void ValidateTemplatedParent(FrameworkElement templatedParent);
+    }
+    public abstract class Freezable : DependencyObject, ISealable {
+        protected Freezable();
+        public bool CanFreeze { get; }
+        public bool IsFrozen { get; }
+        public event EventHandler Changed;
+        public Freezable Clone();
+        protected virtual void CloneCore(Freezable sourceFreezable);
+        public Freezable CloneCurrentValue();
+        protected virtual void CloneCurrentValueCore(Freezable sourceFreezable);
+        protected Freezable CreateInstance();
+        protected abstract Freezable CreateInstanceCore();
+        public void Freeze();
+        protected internal static bool Freeze(Freezable freezable, bool isChecking);
+        protected virtual bool FreezeCore(bool isChecking);
+        public Freezable GetAsFrozen();
+        protected virtual void GetAsFrozenCore(Freezable sourceFreezable);
+        public Freezable GetCurrentValueAsFrozen();
+        protected virtual void GetCurrentValueAsFrozenCore(Freezable sourceFreezable);
+        protected virtual void OnChanged();
+        protected void OnFreezablePropertyChanged(DependencyObject oldValue, DependencyObject newValue);
+        protected void OnFreezablePropertyChanged(DependencyObject oldValue, DependencyObject newValue, DependencyProperty property);
+        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e);
+        protected void ReadPreamble();
+        protected void WritePostscript();
+        protected void WritePreamble();
+    }
+    public class FreezableCollection<T> : Animatable, ICollection, ICollection<T>, IEnumerable, IEnumerable<T>, IList, IList<T>, INotifyCollectionChanged, INotifyPropertyChanged where T : DependencyObject {
+        public FreezableCollection();
+        public FreezableCollection(IEnumerable<T> collection);
+        public FreezableCollection(int capacity);
+        public int Count { get; }
+        bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public T this[int index] { get; set; }
+        event NotifyCollectionChangedEventHandler System.Collections.Specialized.INotifyCollectionChanged.CollectionChanged;
+        event PropertyChangedEventHandler System.ComponentModel.INotifyPropertyChanged.PropertyChanged;
+        public void Add(T value);
+        public void Clear();
+        public new FreezableCollection<T> Clone();
+        protected override void CloneCore(Freezable source);
+        public new FreezableCollection<T> CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable source);
+        public bool Contains(T value);
+        public void CopyTo(T[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        public FreezableCollection<T>.Enumerator GetEnumerator();
+        public int IndexOf(T value);
+        public void Insert(int index, T value);
+        public bool Remove(T value);
+        public void RemoveAt(int index);
+        IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct Enumerator : IDisposable, IEnumerator, IEnumerator<T> {
+            public T Current { get; }
+            object System.Collections.IEnumerator.Current { get; }
+            public bool MoveNext();
+            public void Reset();
+            void System.IDisposable.Dispose();
+        }
+    }
+    public sealed class GiveFeedbackEventArgs : RoutedEventArgs {
+        public DragDropEffects Effects { get; }
+        public bool UseDefaultCursors { get; set; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void GiveFeedbackEventHandler(object sender, GiveFeedbackEventArgs e);
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct GridLength : IEquatable<GridLength> {
+        public GridLength(double pixels);
+        public GridLength(double value, GridUnitType type);
+        public static GridLength Auto { get; }
+        public GridUnitType GridUnitType { get; }
+        public bool IsAbsolute { get; }
+        public bool IsAuto { get; }
+        public bool IsStar { get; }
+        public double Value { get; }
+        public override bool Equals(object oCompare);
+        public bool Equals(GridLength gridLength);
+        public override int GetHashCode();
+        public static bool operator ==(GridLength gl1, GridLength gl2);
+        public static bool operator !=(GridLength gl1, GridLength gl2);
+        public override string ToString();
+    }
+    public class GridLengthConverter : TypeConverter {
+        public GridLengthConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext typeDescriptorContext, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext typeDescriptorContext, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext typeDescriptorContext, CultureInfo cultureInfo, object source);
+        public override object ConvertTo(ITypeDescriptorContext typeDescriptorContext, CultureInfo cultureInfo, object value, Type destinationType);
+    }
+    public enum GridUnitType {
+        Auto = 0,
+        Pixel = 1,
+        Star = 2,
+    }
+    public class HierarchicalDataTemplate : DataTemplate {
+        public HierarchicalDataTemplate();
+        public HierarchicalDataTemplate(object dataType);
+        public int AlternationCount { get; set; }
+        public BindingGroup ItemBindingGroup { get; set; }
+        public Style ItemContainerStyle { get; set; }
+        public StyleSelector ItemContainerStyleSelector { get; set; }
+        public BindingBase ItemsSource { get; set; }
+        public string ItemStringFormat { get; set; }
+        public DataTemplate ItemTemplate { get; set; }
+        public DataTemplateSelector ItemTemplateSelector { get; set; }
+    }
+    public enum HorizontalAlignment {
+        Center = 1,
+        Left = 0,
+        Right = 2,
+        Stretch = 3,
+    }
+    public interface IContentHost {
+        IEnumerator<IInputElement> HostedElements { get; }
+        ReadOnlyCollection<Rect> GetRectangles(ContentElement child);
+        IInputElement InputHitTest(Point point);
+        void OnChildDesiredSizeChanged(UIElement child);
+    }
+    public interface IDataObject {
+        object GetData(string format);
+        object GetData(string format, bool autoConvert);
+        object GetData(Type format);
+        bool GetDataPresent(string format);
+        bool GetDataPresent(string format, bool autoConvert);
+        bool GetDataPresent(Type format);
+        string[] GetFormats();
+        string[] GetFormats(bool autoConvert);
+        void SetData(object data);
+        void SetData(string format, object data);
+        void SetData(string format, object data, bool autoConvert);
+        void SetData(Type format, object data);
+    }
+    public interface IFrameworkInputElement : IInputElement {
+        string Name { get; set; }
+    }
+    public interface IInputElement {
+        bool Focusable { get; set; }
+        bool IsEnabled { get; }
+        bool IsKeyboardFocused { get; }
+        bool IsKeyboardFocusWithin { get; }
+        bool IsMouseCaptured { get; }
+        bool IsMouseDirectlyOver { get; }
+        bool IsMouseOver { get; }
+        bool IsStylusCaptured { get; }
+        bool IsStylusDirectlyOver { get; }
+        bool IsStylusOver { get; }
+        event KeyboardFocusChangedEventHandler GotKeyboardFocus;
+        event MouseEventHandler GotMouseCapture;
+        event StylusEventHandler GotStylusCapture;
+        event KeyEventHandler KeyDown;
+        event KeyEventHandler KeyUp;
+        event KeyboardFocusChangedEventHandler LostKeyboardFocus;
+        event MouseEventHandler LostMouseCapture;
+        event StylusEventHandler LostStylusCapture;
+        event MouseEventHandler MouseEnter;
+        event MouseEventHandler MouseLeave;
+        event MouseButtonEventHandler MouseLeftButtonDown;
+        event MouseButtonEventHandler MouseLeftButtonUp;
+        event MouseEventHandler MouseMove;
+        event MouseButtonEventHandler MouseRightButtonDown;
+        event MouseButtonEventHandler MouseRightButtonUp;
+        event MouseWheelEventHandler MouseWheel;
+        event KeyboardFocusChangedEventHandler PreviewGotKeyboardFocus;
+        event KeyEventHandler PreviewKeyDown;
+        event KeyEventHandler PreviewKeyUp;
+        event KeyboardFocusChangedEventHandler PreviewLostKeyboardFocus;
+        event MouseButtonEventHandler PreviewMouseLeftButtonDown;
+        event MouseButtonEventHandler PreviewMouseLeftButtonUp;
+        event MouseEventHandler PreviewMouseMove;
+        event MouseButtonEventHandler PreviewMouseRightButtonDown;
+        event MouseButtonEventHandler PreviewMouseRightButtonUp;
+        event MouseWheelEventHandler PreviewMouseWheel;
+        event StylusButtonEventHandler PreviewStylusButtonDown;
+        event StylusButtonEventHandler PreviewStylusButtonUp;
+        event StylusDownEventHandler PreviewStylusDown;
+        event StylusEventHandler PreviewStylusInAirMove;
+        event StylusEventHandler PreviewStylusInRange;
+        event StylusEventHandler PreviewStylusMove;
+        event StylusEventHandler PreviewStylusOutOfRange;
+        event StylusSystemGestureEventHandler PreviewStylusSystemGesture;
+        event StylusEventHandler PreviewStylusUp;
+        event TextCompositionEventHandler PreviewTextInput;
+        event StylusButtonEventHandler StylusButtonDown;
+        event StylusButtonEventHandler StylusButtonUp;
+        event StylusDownEventHandler StylusDown;
+        event StylusEventHandler StylusEnter;
+        event StylusEventHandler StylusInAirMove;
+        event StylusEventHandler StylusInRange;
+        event StylusEventHandler StylusLeave;
+        event StylusEventHandler StylusMove;
+        event StylusEventHandler StylusOutOfRange;
+        event StylusSystemGestureEventHandler StylusSystemGesture;
+        event StylusEventHandler StylusUp;
+        event TextCompositionEventHandler TextInput;
+        void AddHandler(RoutedEvent routedEvent, Delegate handler);
+        bool CaptureMouse();
+        bool CaptureStylus();
+        bool Focus();
+        void RaiseEvent(RoutedEventArgs e);
+        void ReleaseMouseCapture();
+        void ReleaseStylusCapture();
+        void RemoveHandler(RoutedEvent routedEvent, Delegate handler);
+    }
+    public enum InheritanceBehavior {
+        Default = 0,
+        SkipAllNext = 6,
+        SkipAllNow = 5,
+        SkipToAppNext = 2,
+        SkipToAppNow = 1,
+        SkipToThemeNext = 4,
+        SkipToThemeNow = 3,
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct Int32Rect : IFormattable {
+        public Int32Rect(int x, int y, int width, int height);
+        public static Int32Rect Empty { get; }
+        public bool HasArea { get; }
+        public int Height { get; set; }
+        public bool IsEmpty { get; }
+        public int Width { get; set; }
+        public int X { get; set; }
+        public int Y { get; set; }
+        public override bool Equals(object o);
+        public bool Equals(Int32Rect value);
+        public static bool Equals(Int32Rect int32Rect1, Int32Rect int32Rect2);
+        public override int GetHashCode();
+        public static bool operator ==(Int32Rect int32Rect1, Int32Rect int32Rect2);
+        public static bool operator !=(Int32Rect int32Rect1, Int32Rect int32Rect2);
+        public static Int32Rect Parse(string source);
+        string System.IFormattable.ToString(string format, IFormatProvider provider);
+        public override string ToString();
+        public string ToString(IFormatProvider provider);
+    }
+    public sealed class Int32RectConverter : TypeConverter {
+        public Int32RectConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public interface IWeakEventListener {
+        bool ReceiveWeakEvent(Type managerType, object sender, EventArgs e);
+    }
+    public class KeySplineConverter : TypeConverter {
+        public KeySplineConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext typeDescriptor, Type destinationType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo cultureInfo, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo cultureInfo, object value, Type destinationType);
+    }
+    public class KeyTimeConverter : TypeConverter {
+        public KeyTimeConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext typeDescriptorContext, Type type);
+        public override bool CanConvertTo(ITypeDescriptorContext typeDescriptorContext, Type type);
+        public override object ConvertFrom(ITypeDescriptorContext typeDescriptorContext, CultureInfo cultureInfo, object value);
+        public override object ConvertTo(ITypeDescriptorContext typeDescriptorContext, CultureInfo cultureInfo, object value, Type destinationType);
+    }
+    public class LengthConverter : TypeConverter {
+        public LengthConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext typeDescriptorContext, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext typeDescriptorContext, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext typeDescriptorContext, CultureInfo cultureInfo, object source);
+        public override object ConvertTo(ITypeDescriptorContext typeDescriptorContext, CultureInfo cultureInfo, object value, Type destinationType);
+    }
+    public enum LineBreakCondition {
+        BreakAlways = 3,
+        BreakDesired = 0,
+        BreakPossible = 1,
+        BreakRestrained = 2,
+    }
+    public enum LineStackingStrategy {
+        BlockLineHeight = 0,
+        MaxHeight = 1,
+    }
+    public sealed class LocalizabilityAttribute : Attribute {
+        public LocalizabilityAttribute(LocalizationCategory category);
+        public LocalizationCategory Category { get; }
+        public Modifiability Modifiability { get; set; }
+        public Readability Readability { get; set; }
+    }
+    public static class Localization {
+        public static readonly DependencyProperty AttributesProperty;
+        public static readonly DependencyProperty CommentsProperty;
+        public static string GetAttributes(object element);
+        public static string GetComments(object element);
+        public static void SetAttributes(object element, string attributes);
+        public static void SetComments(object element, string comments);
+    }
+    public enum LocalizationCategory {
+        Button = 4,
+        CheckBox = 5,
+        ComboBox = 6,
+        Font = 14,
+        Hyperlink = 11,
+        Ignore = 16,
+        Inherit = 15,
+        Label = 3,
+        ListBox = 7,
+        Menu = 8,
+        NeverLocalize = 17,
+        None = 0,
+        RadioButton = 9,
+        Text = 1,
+        TextFlow = 12,
+        Title = 2,
+        ToolTip = 10,
+        XmlData = 13,
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct LocalValueEntry {
+        public DependencyProperty Property { get; }
+        public object Value { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public static bool operator ==(LocalValueEntry obj1, LocalValueEntry obj2);
+        public static bool operator !=(LocalValueEntry obj1, LocalValueEntry obj2);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct LocalValueEnumerator : IEnumerator {
+        public int Count { get; }
+        public LocalValueEntry Current { get; }
+        object System.Collections.IEnumerator.Current { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public bool MoveNext();
+        public static bool operator ==(LocalValueEnumerator obj1, LocalValueEnumerator obj2);
+        public static bool operator !=(LocalValueEnumerator obj1, LocalValueEnumerator obj2);
+        public void Reset();
+    }
+    public static class LogicalTreeHelper {
+        public static void BringIntoView(DependencyObject current);
+        public static DependencyObject FindLogicalNode(DependencyObject logicalTreeNode, string elementName);
+        public static IEnumerable GetChildren(DependencyObject current);
+        public static IEnumerable GetChildren(FrameworkContentElement current);
+        public static IEnumerable GetChildren(FrameworkElement current);
+        public static DependencyObject GetParent(DependencyObject current);
+    }
+    public class LostFocusEventManager : WeakEventManager {
+        public static void AddHandler(DependencyObject source, EventHandler<RoutedEventArgs> handler);
+        public static void AddListener(DependencyObject source, IWeakEventListener listener);
+        protected override WeakEventManager.ListenerList NewListenerList();
+        public static void RemoveHandler(DependencyObject source, EventHandler<RoutedEventArgs> handler);
+        public static void RemoveListener(DependencyObject source, IWeakEventListener listener);
+        protected override void StartListening(object source);
+        protected override void StopListening(object source);
+    }
+    public sealed class MediaScriptCommandRoutedEventArgs : RoutedEventArgs {
+        public string ParameterType { get; }
+        public string ParameterValue { get; }
+    }
+    public sealed class MessageBox {
+        public static MessageBoxResult Show(string messageBoxText);
+        public static MessageBoxResult Show(string messageBoxText, string caption);
+        public static MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button);
+        public static MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon);
+        public static MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult);
+        public static MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult, MessageBoxOptions options);
+        public static MessageBoxResult Show(Window owner, string messageBoxText);
+        public static MessageBoxResult Show(Window owner, string messageBoxText, string caption);
+        public static MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button);
+        public static MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon);
+        public static MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult);
+        public static MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult, MessageBoxOptions options);
+    }
+    public enum MessageBoxButton {
+        OK = 0,
+        OKCancel = 1,
+        YesNo = 4,
+        YesNoCancel = 3,
+    }
+    public enum MessageBoxImage {
+        Asterisk = 64,
+        Error = 16,
+        Exclamation = 48,
+        Hand = 16,
+        Information = 64,
+        None = 0,
+        Question = 32,
+        Stop = 16,
+        Warning = 48,
+    }
+    public enum MessageBoxOptions {
+        DefaultDesktopOnly = 131072,
+        None = 0,
+        RightAlign = 524288,
+        RtlReading = 1048576,
+        ServiceNotification = 2097152,
+    }
+    public enum MessageBoxResult {
+        Cancel = 2,
+        No = 7,
+        None = 0,
+        OK = 1,
+        Yes = 6,
+    }
+    public enum Modifiability {
+        Inherit = 2,
+        Modifiable = 1,
+        Unmodifiable = 0,
+    }
+    public sealed class MultiDataTrigger : TriggerBase, IAddChild {
+        public MultiDataTrigger();
+        public ConditionCollection Conditions { get; }
+        public SetterBaseCollection Setters { get; }
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public sealed class MultiTrigger : TriggerBase, IAddChild {
+        public MultiTrigger();
+        public ConditionCollection Conditions { get; }
+        public SetterBaseCollection Setters { get; }
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public class NameScope : ICollection<KeyValuePair<string, object>>, IDictionary<string, object>, IEnumerable, IEnumerable<KeyValuePair<string, object>>, INameScope, INameScopeDictionary {
+        public static readonly DependencyProperty NameScopeProperty;
+        public NameScope();
+        public int Count { get; }
+        public bool IsReadOnly { get; }
+        public ICollection<string> Keys { get; }
+        public object this[string key] { get; set; }
+        public ICollection<object> Values { get; }
+        public void Add(KeyValuePair<string, object> item);
+        public void Add(string key, object value);
+        public void Clear();
+        public bool Contains(KeyValuePair<string, object> item);
+        public bool ContainsKey(string key);
+        public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex);
+        public object FindName(string name);
+        public static INameScope GetNameScope(DependencyObject dependencyObject);
+        public void RegisterName(string name, object scopedElement);
+        public bool Remove(KeyValuePair<string, object> item);
+        public bool Remove(string key);
+        public static void SetNameScope(DependencyObject dependencyObject, INameScope value);
+        IEnumerator<KeyValuePair<string, object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        public bool TryGetValue(string key, out object value);
+        public void UnregisterName(string name);
+    }
+    public class NullableBoolConverter : NullableConverter {
+        public NullableBoolConverter();
+        public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context);
+        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context);
+        public override bool GetStandardValuesSupported(ITypeDescriptorContext context);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct Point : IFormattable {
+        public Point(double x, double y);
+        public double X { get; set; }
+        public double Y { get; set; }
+        public static Point Add(Point point, Vector vector);
+        public override bool Equals(object o);
+        public bool Equals(Point value);
+        public static bool Equals(Point point1, Point point2);
+        public override int GetHashCode();
+        public static Point Multiply(Point point, Matrix matrix);
+        public void Offset(double offsetX, double offsetY);
+        public static Point operator +(Point point, Vector vector);
+        public static bool operator ==(Point point1, Point point2);
+        public static explicit operator Size (Point point);
+        public static explicit operator Vector (Point point);
+        public static bool operator !=(Point point1, Point point2);
+        public static Point operator *(Point point, Matrix matrix);
+        public static Vector operator -(Point point1, Point point2);
+        public static Point operator -(Point point, Vector vector);
+        public static Point Parse(string source);
+        public static Vector Subtract(Point point1, Point point2);
+        public static Point Subtract(Point point, Vector vector);
+        string System.IFormattable.ToString(string format, IFormatProvider provider);
+        public override string ToString();
+        public string ToString(IFormatProvider provider);
+    }
+    public sealed class PointConverter : TypeConverter {
+        public PointConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public enum PowerLineStatus {
+        Offline = 0,
+        Online = 1,
+        Unknown = 255,
+    }
+    public abstract class PresentationSource : DispatcherObject {
+        protected PresentationSource();
+        public CompositionTarget CompositionTarget { get; }
+        public static IEnumerable CurrentSources { get; }
+        public abstract bool IsDisposed { get; }
+        public abstract Visual RootVisual { get; set; }
+        public event EventHandler ContentRendered;
+        protected void AddSource();
+        public static void AddSourceChangedHandler(IInputElement element, SourceChangedEventHandler handler);
+        protected void ClearContentRenderedListeners();
+        public static PresentationSource FromDependencyObject(DependencyObject dependencyObject);
+        public static PresentationSource FromVisual(Visual visual);
+        protected abstract CompositionTarget GetCompositionTargetCore();
+        protected void RemoveSource();
+        public static void RemoveSourceChangedHandler(IInputElement e, SourceChangedEventHandler handler);
+        protected void RootChanged(Visual oldRoot, Visual newRoot);
+    }
+    public delegate void PropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e);
+    public class PropertyMetadata {
+        public PropertyMetadata();
+        public PropertyMetadata(object defaultValue);
+        public PropertyMetadata(object defaultValue, PropertyChangedCallback propertyChangedCallback);
+        public PropertyMetadata(object defaultValue, PropertyChangedCallback propertyChangedCallback, CoerceValueCallback coerceValueCallback);
+        public PropertyMetadata(PropertyChangedCallback propertyChangedCallback);
+        public CoerceValueCallback CoerceValueCallback { get; set; }
+        public object DefaultValue { get; set; }
+        protected bool IsSealed { get; }
+        public PropertyChangedCallback PropertyChangedCallback { get; set; }
+        protected virtual void Merge(PropertyMetadata baseMetadata, DependencyProperty dp);
+        protected virtual void OnApply(DependencyProperty dp, Type targetType);
+    }
+    public sealed class PropertyPath {
+        public PropertyPath(object parameter);
+        public PropertyPath(string path, params object[] pathParameters);
+        public string Path { get; set; }
+        public Collection<object> PathParameters { get; }
+    }
+    public sealed class PropertyPathConverter : TypeConverter {
+        public PropertyPathConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext typeDescriptorContext, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext typeDescriptorContext, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext typeDescriptorContext, CultureInfo cultureInfo, object source);
+        public override object ConvertTo(ITypeDescriptorContext typeDescriptorContext, CultureInfo cultureInfo, object value, Type destinationType);
+    }
+    public sealed class QueryContinueDragEventArgs : RoutedEventArgs {
+        public DragAction Action { get; set; }
+        public bool EscapePressed { get; }
+        public DragDropKeyStates KeyStates { get; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void QueryContinueDragEventHandler(object sender, QueryContinueDragEventArgs e);
+    public enum Readability {
+        Inherit = 2,
+        Readable = 1,
+        Unreadable = 0,
+    }
+    public enum ReasonSessionEnding : byte {
+        Logoff = (byte)0,
+        Shutdown = (byte)1,
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct Rect : IFormattable {
+        public Rect(double x, double y, double width, double height);
+        public Rect(Point point1, Point point2);
+        public Rect(Point location, Size size);
+        public Rect(Point point, Vector vector);
+        public Rect(Size size);
+        public double Bottom { get; }
+        public Point BottomLeft { get; }
+        public Point BottomRight { get; }
+        public static Rect Empty { get; }
+        public double Height { get; set; }
+        public bool IsEmpty { get; }
+        public double Left { get; }
+        public Point Location { get; set; }
+        public double Right { get; }
+        public Size Size { get; set; }
+        public double Top { get; }
+        public Point TopLeft { get; }
+        public Point TopRight { get; }
+        public double Width { get; set; }
+        public double X { get; set; }
+        public double Y { get; set; }
+        public bool Contains(double x, double y);
+        public bool Contains(Point point);
+        public bool Contains(Rect rect);
+        public override bool Equals(object o);
+        public bool Equals(Rect value);
+        public static bool Equals(Rect rect1, Rect rect2);
+        public override int GetHashCode();
+        public void Inflate(double width, double height);
+        public static Rect Inflate(Rect rect, double width, double height);
+        public static Rect Inflate(Rect rect, Size size);
+        public void Inflate(Size size);
+        public void Intersect(Rect rect);
+        public static Rect Intersect(Rect rect1, Rect rect2);
+        public bool IntersectsWith(Rect rect);
+        public void Offset(double offsetX, double offsetY);
+        public static Rect Offset(Rect rect, double offsetX, double offsetY);
+        public static Rect Offset(Rect rect, Vector offsetVector);
+        public void Offset(Vector offsetVector);
+        public static bool operator ==(Rect rect1, Rect rect2);
+        public static bool operator !=(Rect rect1, Rect rect2);
+        public static Rect Parse(string source);
+        public void Scale(double scaleX, double scaleY);
+        string System.IFormattable.ToString(string format, IFormatProvider provider);
+        public override string ToString();
+        public string ToString(IFormatProvider provider);
+        public void Transform(Matrix matrix);
+        public static Rect Transform(Rect rect, Matrix matrix);
+        public void Union(Point point);
+        public void Union(Rect rect);
+        public static Rect Union(Rect rect, Point point);
+        public static Rect Union(Rect rect1, Rect rect2);
+    }
+    public sealed class RectConverter : TypeConverter {
+        public RectConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public class RequestBringIntoViewEventArgs : RoutedEventArgs {
+        public DependencyObject TargetObject { get; }
+        public Rect TargetRect { get; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void RequestBringIntoViewEventHandler(object sender, RequestBringIntoViewEventArgs e);
+    public enum ResizeMode {
+        CanMinimize = 1,
+        CanResize = 2,
+        CanResizeWithGrip = 3,
+        NoResize = 0,
+    }
+    public class ResourceDictionary : ICollection, IDictionary, IEnumerable, INameScope, ISupportInitialize, IUriContext {
+        public ResourceDictionary();
+        public int Count { get; }
+        public DeferrableContent DeferrableContent { get; set; }
+        public bool IsFixedSize { get; }
+        public bool IsReadOnly { get; internal set; }
+        public ICollection Keys { get; }
+        public Collection<ResourceDictionary> MergedDictionaries { get; }
+        public Uri Source { get; set; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        Uri System.Windows.Markup.IUriContext.BaseUri { get; set; }
+        public object this[object key] { get; set; }
+        public ICollection Values { get; }
+        public void Add(object key, object value);
+        public void BeginInit();
+        public void Clear();
+        public bool Contains(object key);
+        public void CopyTo(DictionaryEntry[] array, int arrayIndex);
+        public void EndInit();
+        public object FindName(string name);
+        public IDictionaryEnumerator GetEnumerator();
+        protected virtual void OnGettingValue(object key, ref object value, out bool canCache);
+        public void RegisterName(string name, object scopedElement);
+        public void Remove(object key);
+        void System.Collections.ICollection.CopyTo(Array array, int arrayIndex);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        public void UnregisterName(string name);
+    }
+    public enum ResourceDictionaryLocation {
+        ExternalAssembly = 2,
+        None = 0,
+        SourceAssembly = 1,
+    }
+    public abstract class ResourceKey : MarkupExtension {
+        protected ResourceKey();
+        public abstract Assembly Assembly { get; }
+        public override object ProvideValue(IServiceProvider serviceProvider);
+    }
+    public class ResourceReferenceKeyNotFoundException : InvalidOperationException {
+        public ResourceReferenceKeyNotFoundException();
+        protected ResourceReferenceKeyNotFoundException(SerializationInfo info, StreamingContext context);
+        public ResourceReferenceKeyNotFoundException(string message, object resourceKey);
+        public object Key { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public sealed class RoutedEvent {
+        public Type HandlerType { get; }
+        public string Name { get; }
+        public Type OwnerType { get; }
+        public RoutingStrategy RoutingStrategy { get; }
+        public RoutedEvent AddOwner(Type ownerType);
+        public override string ToString();
+    }
+    public class RoutedEventArgs : EventArgs {
+        public RoutedEventArgs();
+        public RoutedEventArgs(RoutedEvent routedEvent);
+        public RoutedEventArgs(RoutedEvent routedEvent, object source);
+        public bool Handled { get; set; }
+        public object OriginalSource { get; }
+        public RoutedEvent RoutedEvent { get; set; }
+        public object Source { get; set; }
+        protected virtual void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+        protected virtual void OnSetSource(object source);
+    }
+    public delegate void RoutedEventHandler(object sender, RoutedEventArgs e);
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct RoutedEventHandlerInfo {
+        public Delegate Handler { get; }
+        public bool InvokeHandledEventsToo { get; }
+        public override bool Equals(object obj);
+        public bool Equals(RoutedEventHandlerInfo handlerInfo);
+        public override int GetHashCode();
+        public static bool operator ==(RoutedEventHandlerInfo handlerInfo1, RoutedEventHandlerInfo handlerInfo2);
+        public static bool operator !=(RoutedEventHandlerInfo handlerInfo1, RoutedEventHandlerInfo handlerInfo2);
+    }
+    public class RoutedPropertyChangedEventArgs<T> : RoutedEventArgs {
+        public RoutedPropertyChangedEventArgs(T oldValue, T newValue);
+        public RoutedPropertyChangedEventArgs(T oldValue, T newValue, RoutedEvent routedEvent);
+        public T NewValue { get; }
+        public T OldValue { get; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void RoutedPropertyChangedEventHandler<T>(object sender, RoutedPropertyChangedEventArgs<T> e);
+    public enum RoutingStrategy {
+        Bubble = 1,
+        Direct = 2,
+        Tunnel = 0,
+    }
+    public class SessionEndingCancelEventArgs : CancelEventArgs {
+        public ReasonSessionEnding ReasonSessionEnding { get; }
+    }
+    public delegate void SessionEndingCancelEventHandler(object sender, SessionEndingCancelEventArgs e);
+    public class Setter : SetterBase, ISupportInitialize {
+        public Setter();
+        public Setter(DependencyProperty property, object value);
+        public Setter(DependencyProperty property, object value, string targetName);
+        public DependencyProperty Property { get; set; }
+        public string TargetName { get; set; }
+        public object Value { get; set; }
+        public static void ReceiveMarkupExtension(object targetObject, XamlSetMarkupExtensionEventArgs eventArgs);
+        public static void ReceiveTypeConverter(object targetObject, XamlSetTypeConverterEventArgs eventArgs);
+        void System.ComponentModel.ISupportInitialize.BeginInit();
+        void System.ComponentModel.ISupportInitialize.EndInit();
+    }
+    public abstract class SetterBase {
+        public bool IsSealed { get; }
+        protected void CheckSealed();
+    }
+    public sealed class SetterBaseCollection : Collection<SetterBase> {
+        public SetterBaseCollection();
+        public bool IsSealed { get; }
+        protected override void ClearItems();
+        protected override void InsertItem(int index, SetterBase item);
+        protected override void RemoveItem(int index);
+        protected override void SetItem(int index, SetterBase item);
+    }
+    public enum ShutdownMode : byte {
+        OnExplicitShutdown = (byte)2,
+        OnLastWindowClose = (byte)0,
+        OnMainWindowClose = (byte)1,
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct Size : IFormattable {
+        public Size(double width, double height);
+        public static Size Empty { get; }
+        public double Height { get; set; }
+        public bool IsEmpty { get; }
+        public double Width { get; set; }
+        public override bool Equals(object o);
+        public bool Equals(Size value);
+        public static bool Equals(Size size1, Size size2);
+        public override int GetHashCode();
+        public static bool operator ==(Size size1, Size size2);
+        public static explicit operator Vector (Size size);
+        public static explicit operator Point (Size size);
+        public static bool operator !=(Size size1, Size size2);
+        public static Size Parse(string source);
+        string System.IFormattable.ToString(string format, IFormatProvider provider);
+        public override string ToString();
+        public string ToString(IFormatProvider provider);
+    }
+    public class SizeChangedEventArgs : RoutedEventArgs {
+        public bool HeightChanged { get; }
+        public Size NewSize { get; }
+        public Size PreviousSize { get; }
+        public bool WidthChanged { get; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void SizeChangedEventHandler(object sender, SizeChangedEventArgs e);
+    public class SizeChangedInfo {
+        public SizeChangedInfo(UIElement element, Size previousSize, bool widthChanged, bool heightChanged);
+        public bool HeightChanged { get; }
+        public Size NewSize { get; }
+        public Size PreviousSize { get; }
+        public bool WidthChanged { get; }
+    }
+    public sealed class SizeConverter : TypeConverter {
+        public SizeConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public enum SizeToContent {
+        Height = 2,
+        Manual = 0,
+        Width = 1,
+        WidthAndHeight = 3,
+    }
+    public sealed class SourceChangedEventArgs : RoutedEventArgs {
+        public SourceChangedEventArgs(PresentationSource oldSource, PresentationSource newSource);
+        public SourceChangedEventArgs(PresentationSource oldSource, PresentationSource newSource, IInputElement element, IInputElement oldParent);
+        public IInputElement Element { get; }
+        public PresentationSource NewSource { get; }
+        public IInputElement OldParent { get; }
+        public PresentationSource OldSource { get; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public delegate void SourceChangedEventHandler(object sender, SourceChangedEventArgs e);
+    public class SplashScreen {
+        public SplashScreen(Assembly resourceAssembly, string resourceName);
+        public SplashScreen(string resourceName);
+        public void Close(TimeSpan fadeoutDuration);
+        public void Show(bool autoClose);
+        public void Show(bool autoClose, bool topMost);
+    }
+    public class StartupEventArgs : EventArgs {
+        public string[] Args { get; }
+    }
+    public delegate void StartupEventHandler(object sender, StartupEventArgs e);
+    public class StaticResourceExtension : MarkupExtension {
+        public StaticResourceExtension();
+        public StaticResourceExtension(object resourceKey);
+        public object ResourceKey { get; set; }
+        public override object ProvideValue(IServiceProvider serviceProvider);
+    }
+    public class StrokeCollectionConverter : TypeConverter {
+        public StrokeCollectionConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+        public override bool GetStandardValuesSupported(ITypeDescriptorContext context);
+    }
+    public class Style : DispatcherObject, IAddChild, IHaveResources, INameScope, IQueryAmbient, ISealable {
+        public Style();
+        public Style(Type targetType);
+        public Style(Type targetType, Style basedOn);
+        public Style BasedOn { get; set; }
+        public bool IsSealed { get; }
+        public ResourceDictionary Resources { get; set; }
+        public SetterBaseCollection Setters { get; }
+        public Type TargetType { get; set; }
+        public TriggerCollection Triggers { get; }
+        public override int GetHashCode();
+        public void RegisterName(string name, object scopedElement);
+        public void Seal();
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+        object System.Windows.Markup.INameScope.FindName(string name);
+        bool System.Windows.Markup.IQueryAmbient.IsAmbientPropertyAvailable(string propertyName);
+        public void UnregisterName(string name);
+    }
+    public sealed class StyleTypedPropertyAttribute : Attribute {
+        public StyleTypedPropertyAttribute();
+        public string Property { get; set; }
+        public Type StyleTargetType { get; set; }
+    }
+    public static class SystemColors {
+        public static SolidColorBrush ActiveBorderBrush { get; }
+        public static ResourceKey ActiveBorderBrushKey { get; }
+        public static Color ActiveBorderColor { get; }
+        public static ResourceKey ActiveBorderColorKey { get; }
+        public static SolidColorBrush ActiveCaptionBrush { get; }
+        public static ResourceKey ActiveCaptionBrushKey { get; }
+        public static Color ActiveCaptionColor { get; }
+        public static ResourceKey ActiveCaptionColorKey { get; }
+        public static SolidColorBrush ActiveCaptionTextBrush { get; }
+        public static ResourceKey ActiveCaptionTextBrushKey { get; }
+        public static Color ActiveCaptionTextColor { get; }
+        public static ResourceKey ActiveCaptionTextColorKey { get; }
+        public static SolidColorBrush AppWorkspaceBrush { get; }
+        public static ResourceKey AppWorkspaceBrushKey { get; }
+        public static Color AppWorkspaceColor { get; }
+        public static ResourceKey AppWorkspaceColorKey { get; }
+        public static SolidColorBrush ControlBrush { get; }
+        public static ResourceKey ControlBrushKey { get; }
+        public static Color ControlColor { get; }
+        public static ResourceKey ControlColorKey { get; }
+        public static SolidColorBrush ControlDarkBrush { get; }
+        public static ResourceKey ControlDarkBrushKey { get; }
+        public static Color ControlDarkColor { get; }
+        public static ResourceKey ControlDarkColorKey { get; }
+        public static SolidColorBrush ControlDarkDarkBrush { get; }
+        public static ResourceKey ControlDarkDarkBrushKey { get; }
+        public static Color ControlDarkDarkColor { get; }
+        public static ResourceKey ControlDarkDarkColorKey { get; }
+        public static SolidColorBrush ControlLightBrush { get; }
+        public static ResourceKey ControlLightBrushKey { get; }
+        public static Color ControlLightColor { get; }
+        public static ResourceKey ControlLightColorKey { get; }
+        public static SolidColorBrush ControlLightLightBrush { get; }
+        public static ResourceKey ControlLightLightBrushKey { get; }
+        public static Color ControlLightLightColor { get; }
+        public static ResourceKey ControlLightLightColorKey { get; }
+        public static SolidColorBrush ControlTextBrush { get; }
+        public static ResourceKey ControlTextBrushKey { get; }
+        public static Color ControlTextColor { get; }
+        public static ResourceKey ControlTextColorKey { get; }
+        public static SolidColorBrush DesktopBrush { get; }
+        public static ResourceKey DesktopBrushKey { get; }
+        public static Color DesktopColor { get; }
+        public static ResourceKey DesktopColorKey { get; }
+        public static SolidColorBrush GradientActiveCaptionBrush { get; }
+        public static ResourceKey GradientActiveCaptionBrushKey { get; }
+        public static Color GradientActiveCaptionColor { get; }
+        public static ResourceKey GradientActiveCaptionColorKey { get; }
+        public static SolidColorBrush GradientInactiveCaptionBrush { get; }
+        public static ResourceKey GradientInactiveCaptionBrushKey { get; }
+        public static Color GradientInactiveCaptionColor { get; }
+        public static ResourceKey GradientInactiveCaptionColorKey { get; }
+        public static SolidColorBrush GrayTextBrush { get; }
+        public static ResourceKey GrayTextBrushKey { get; }
+        public static Color GrayTextColor { get; }
+        public static ResourceKey GrayTextColorKey { get; }
+        public static SolidColorBrush HighlightBrush { get; }
+        public static ResourceKey HighlightBrushKey { get; }
+        public static Color HighlightColor { get; }
+        public static ResourceKey HighlightColorKey { get; }
+        public static SolidColorBrush HighlightTextBrush { get; }
+        public static ResourceKey HighlightTextBrushKey { get; }
+        public static Color HighlightTextColor { get; }
+        public static ResourceKey HighlightTextColorKey { get; }
+        public static SolidColorBrush HotTrackBrush { get; }
+        public static ResourceKey HotTrackBrushKey { get; }
+        public static Color HotTrackColor { get; }
+        public static ResourceKey HotTrackColorKey { get; }
+        public static SolidColorBrush InactiveBorderBrush { get; }
+        public static ResourceKey InactiveBorderBrushKey { get; }
+        public static Color InactiveBorderColor { get; }
+        public static ResourceKey InactiveBorderColorKey { get; }
+        public static SolidColorBrush InactiveCaptionBrush { get; }
+        public static ResourceKey InactiveCaptionBrushKey { get; }
+        public static Color InactiveCaptionColor { get; }
+        public static ResourceKey InactiveCaptionColorKey { get; }
+        public static SolidColorBrush InactiveCaptionTextBrush { get; }
+        public static ResourceKey InactiveCaptionTextBrushKey { get; }
+        public static Color InactiveCaptionTextColor { get; }
+        public static ResourceKey InactiveCaptionTextColorKey { get; }
+        public static SolidColorBrush InactiveSelectionHighlightBrush { get; }
+        public static ResourceKey InactiveSelectionHighlightBrushKey { get; }
+        public static SolidColorBrush InactiveSelectionHighlightTextBrush { get; }
+        public static ResourceKey InactiveSelectionHighlightTextBrushKey { get; }
+        public static SolidColorBrush InfoBrush { get; }
+        public static ResourceKey InfoBrushKey { get; }
+        public static Color InfoColor { get; }
+        public static ResourceKey InfoColorKey { get; }
+        public static SolidColorBrush InfoTextBrush { get; }
+        public static ResourceKey InfoTextBrushKey { get; }
+        public static Color InfoTextColor { get; }
+        public static ResourceKey InfoTextColorKey { get; }
+        public static SolidColorBrush MenuBarBrush { get; }
+        public static ResourceKey MenuBarBrushKey { get; }
+        public static Color MenuBarColor { get; }
+        public static ResourceKey MenuBarColorKey { get; }
+        public static SolidColorBrush MenuBrush { get; }
+        public static ResourceKey MenuBrushKey { get; }
+        public static Color MenuColor { get; }
+        public static ResourceKey MenuColorKey { get; }
+        public static SolidColorBrush MenuHighlightBrush { get; }
+        public static ResourceKey MenuHighlightBrushKey { get; }
+        public static Color MenuHighlightColor { get; }
+        public static ResourceKey MenuHighlightColorKey { get; }
+        public static SolidColorBrush MenuTextBrush { get; }
+        public static ResourceKey MenuTextBrushKey { get; }
+        public static Color MenuTextColor { get; }
+        public static ResourceKey MenuTextColorKey { get; }
+        public static SolidColorBrush ScrollBarBrush { get; }
+        public static ResourceKey ScrollBarBrushKey { get; }
+        public static Color ScrollBarColor { get; }
+        public static ResourceKey ScrollBarColorKey { get; }
+        public static SolidColorBrush WindowBrush { get; }
+        public static ResourceKey WindowBrushKey { get; }
+        public static Color WindowColor { get; }
+        public static ResourceKey WindowColorKey { get; }
+        public static SolidColorBrush WindowFrameBrush { get; }
+        public static ResourceKey WindowFrameBrushKey { get; }
+        public static Color WindowFrameColor { get; }
+        public static ResourceKey WindowFrameColorKey { get; }
+        public static SolidColorBrush WindowTextBrush { get; }
+        public static ResourceKey WindowTextBrushKey { get; }
+        public static Color WindowTextColor { get; }
+        public static ResourceKey WindowTextColorKey { get; }
+    }
+    public static class SystemCommands {
+        public static RoutedCommand CloseWindowCommand { get; private set; }
+        public static RoutedCommand MaximizeWindowCommand { get; private set; }
+        public static RoutedCommand MinimizeWindowCommand { get; private set; }
+        public static RoutedCommand RestoreWindowCommand { get; private set; }
+        public static RoutedCommand ShowSystemMenuCommand { get; private set; }
+        public static void CloseWindow(Window window);
+        public static void MaximizeWindow(Window window);
+        public static void MinimizeWindow(Window window);
+        public static void RestoreWindow(Window window);
+        public static void ShowSystemMenu(Window window, Point screenLocation);
+    }
+    public static class SystemFonts {
+        public static FontFamily CaptionFontFamily { get; }
+        public static ResourceKey CaptionFontFamilyKey { get; }
+        public static double CaptionFontSize { get; }
+        public static ResourceKey CaptionFontSizeKey { get; }
+        public static FontStyle CaptionFontStyle { get; }
+        public static ResourceKey CaptionFontStyleKey { get; }
+        public static TextDecorationCollection CaptionFontTextDecorations { get; }
+        public static ResourceKey CaptionFontTextDecorationsKey { get; }
+        public static FontWeight CaptionFontWeight { get; }
+        public static ResourceKey CaptionFontWeightKey { get; }
+        public static FontFamily IconFontFamily { get; }
+        public static ResourceKey IconFontFamilyKey { get; }
+        public static double IconFontSize { get; }
+        public static ResourceKey IconFontSizeKey { get; }
+        public static FontStyle IconFontStyle { get; }
+        public static ResourceKey IconFontStyleKey { get; }
+        public static TextDecorationCollection IconFontTextDecorations { get; }
+        public static ResourceKey IconFontTextDecorationsKey { get; }
+        public static FontWeight IconFontWeight { get; }
+        public static ResourceKey IconFontWeightKey { get; }
+        public static FontFamily MenuFontFamily { get; }
+        public static ResourceKey MenuFontFamilyKey { get; }
+        public static double MenuFontSize { get; }
+        public static ResourceKey MenuFontSizeKey { get; }
+        public static FontStyle MenuFontStyle { get; }
+        public static ResourceKey MenuFontStyleKey { get; }
+        public static TextDecorationCollection MenuFontTextDecorations { get; }
+        public static ResourceKey MenuFontTextDecorationsKey { get; }
+        public static FontWeight MenuFontWeight { get; }
+        public static ResourceKey MenuFontWeightKey { get; }
+        public static FontFamily MessageFontFamily { get; }
+        public static ResourceKey MessageFontFamilyKey { get; }
+        public static double MessageFontSize { get; }
+        public static ResourceKey MessageFontSizeKey { get; }
+        public static FontStyle MessageFontStyle { get; }
+        public static ResourceKey MessageFontStyleKey { get; }
+        public static TextDecorationCollection MessageFontTextDecorations { get; }
+        public static ResourceKey MessageFontTextDecorationsKey { get; }
+        public static FontWeight MessageFontWeight { get; }
+        public static ResourceKey MessageFontWeightKey { get; }
+        public static FontFamily SmallCaptionFontFamily { get; }
+        public static ResourceKey SmallCaptionFontFamilyKey { get; }
+        public static double SmallCaptionFontSize { get; }
+        public static ResourceKey SmallCaptionFontSizeKey { get; }
+        public static FontStyle SmallCaptionFontStyle { get; }
+        public static ResourceKey SmallCaptionFontStyleKey { get; }
+        public static TextDecorationCollection SmallCaptionFontTextDecorations { get; }
+        public static ResourceKey SmallCaptionFontTextDecorationsKey { get; }
+        public static FontWeight SmallCaptionFontWeight { get; }
+        public static ResourceKey SmallCaptionFontWeightKey { get; }
+        public static FontFamily StatusFontFamily { get; }
+        public static ResourceKey StatusFontFamilyKey { get; }
+        public static double StatusFontSize { get; }
+        public static ResourceKey StatusFontSizeKey { get; }
+        public static FontStyle StatusFontStyle { get; }
+        public static ResourceKey StatusFontStyleKey { get; }
+        public static TextDecorationCollection StatusFontTextDecorations { get; }
+        public static ResourceKey StatusFontTextDecorationsKey { get; }
+        public static FontWeight StatusFontWeight { get; }
+        public static ResourceKey StatusFontWeightKey { get; }
+    }
+    public static class SystemParameters {
+        public static int Border { get; }
+        public static ResourceKey BorderKey { get; }
+        public static double BorderWidth { get; }
+        public static ResourceKey BorderWidthKey { get; }
+        public static double CaptionHeight { get; }
+        public static ResourceKey CaptionHeightKey { get; }
+        public static double CaptionWidth { get; }
+        public static ResourceKey CaptionWidthKey { get; }
+        public static double CaretWidth { get; }
+        public static ResourceKey CaretWidthKey { get; }
+        public static bool ClientAreaAnimation { get; }
+        public static ResourceKey ClientAreaAnimationKey { get; }
+        public static bool ComboBoxAnimation { get; }
+        public static ResourceKey ComboBoxAnimationKey { get; }
+        public static PopupAnimation ComboBoxPopupAnimation { get; }
+        public static ResourceKey ComboBoxPopupAnimationKey { get; }
+        public static double CursorHeight { get; }
+        public static ResourceKey CursorHeightKey { get; }
+        public static bool CursorShadow { get; }
+        public static ResourceKey CursorShadowKey { get; }
+        public static double CursorWidth { get; }
+        public static ResourceKey CursorWidthKey { get; }
+        public static bool DragFullWindows { get; }
+        public static ResourceKey DragFullWindowsKey { get; }
+        public static bool DropShadow { get; }
+        public static ResourceKey DropShadowKey { get; }
+        public static double FixedFrameHorizontalBorderHeight { get; }
+        public static ResourceKey FixedFrameHorizontalBorderHeightKey { get; }
+        public static double FixedFrameVerticalBorderWidth { get; }
+        public static ResourceKey FixedFrameVerticalBorderWidthKey { get; }
+        public static bool FlatMenu { get; }
+        public static ResourceKey FlatMenuKey { get; }
+        public static double FocusBorderHeight { get; }
+        public static ResourceKey FocusBorderHeightKey { get; }
+        public static double FocusBorderWidth { get; }
+        public static ResourceKey FocusBorderWidthKey { get; }
+        public static double FocusHorizontalBorderHeight { get; }
+        public static ResourceKey FocusHorizontalBorderHeightKey { get; }
+        public static double FocusVerticalBorderWidth { get; }
+        public static ResourceKey FocusVerticalBorderWidthKey { get; }
+        public static ResourceKey FocusVisualStyleKey { get; }
+        public static int ForegroundFlashCount { get; }
+        public static ResourceKey ForegroundFlashCountKey { get; }
+        public static double FullPrimaryScreenHeight { get; }
+        public static ResourceKey FullPrimaryScreenHeightKey { get; }
+        public static double FullPrimaryScreenWidth { get; }
+        public static ResourceKey FullPrimaryScreenWidthKey { get; }
+        public static bool GradientCaptions { get; }
+        public static ResourceKey GradientCaptionsKey { get; }
+        public static bool HighContrast { get; }
+        public static ResourceKey HighContrastKey { get; }
+        public static double HorizontalScrollBarButtonWidth { get; }
+        public static ResourceKey HorizontalScrollBarButtonWidthKey { get; }
+        public static double HorizontalScrollBarHeight { get; }
+        public static ResourceKey HorizontalScrollBarHeightKey { get; }
+        public static double HorizontalScrollBarThumbWidth { get; }
+        public static ResourceKey HorizontalScrollBarThumbWidthKey { get; }
+        public static bool HotTracking { get; }
+        public static ResourceKey HotTrackingKey { get; }
+        public static double IconGridHeight { get; }
+        public static ResourceKey IconGridHeightKey { get; }
+        public static double IconGridWidth { get; }
+        public static ResourceKey IconGridWidthKey { get; }
+        public static double IconHeight { get; }
+        public static ResourceKey IconHeightKey { get; }
+        public static double IconHorizontalSpacing { get; }
+        public static ResourceKey IconHorizontalSpacingKey { get; }
+        public static bool IconTitleWrap { get; }
+        public static ResourceKey IconTitleWrapKey { get; }
+        public static double IconVerticalSpacing { get; }
+        public static ResourceKey IconVerticalSpacingKey { get; }
+        public static double IconWidth { get; }
+        public static ResourceKey IconWidthKey { get; }
+        public static bool IsGlassEnabled { get; }
+        public static bool IsImmEnabled { get; }
+        public static ResourceKey IsImmEnabledKey { get; }
+        public static bool IsMediaCenter { get; }
+        public static ResourceKey IsMediaCenterKey { get; }
+        public static bool IsMenuDropRightAligned { get; }
+        public static ResourceKey IsMenuDropRightAlignedKey { get; }
+        public static bool IsMiddleEastEnabled { get; }
+        public static ResourceKey IsMiddleEastEnabledKey { get; }
+        public static bool IsMousePresent { get; }
+        public static ResourceKey IsMousePresentKey { get; }
+        public static bool IsMouseWheelPresent { get; }
+        public static ResourceKey IsMouseWheelPresentKey { get; }
+        public static bool IsPenWindows { get; }
+        public static ResourceKey IsPenWindowsKey { get; }
+        public static bool IsRemotelyControlled { get; }
+        public static ResourceKey IsRemotelyControlledKey { get; }
+        public static bool IsRemoteSession { get; }
+        public static ResourceKey IsRemoteSessionKey { get; }
+        public static bool IsSlowMachine { get; }
+        public static ResourceKey IsSlowMachineKey { get; }
+        public static bool IsTabletPC { get; }
+        public static ResourceKey IsTabletPCKey { get; }
+        public static double KanjiWindowHeight { get; }
+        public static ResourceKey KanjiWindowHeightKey { get; }
+        public static bool KeyboardCues { get; }
+        public static ResourceKey KeyboardCuesKey { get; }
+        public static int KeyboardDelay { get; }
+        public static ResourceKey KeyboardDelayKey { get; }
+        public static bool KeyboardPreference { get; }
+        public static ResourceKey KeyboardPreferenceKey { get; }
+        public static int KeyboardSpeed { get; }
+        public static ResourceKey KeyboardSpeedKey { get; }
+        public static bool ListBoxSmoothScrolling { get; }
+        public static ResourceKey ListBoxSmoothScrollingKey { get; }
+        public static double MaximizedPrimaryScreenHeight { get; }
+        public static ResourceKey MaximizedPrimaryScreenHeightKey { get; }
+        public static double MaximizedPrimaryScreenWidth { get; }
+        public static ResourceKey MaximizedPrimaryScreenWidthKey { get; }
+        public static double MaximumWindowTrackHeight { get; }
+        public static ResourceKey MaximumWindowTrackHeightKey { get; }
+        public static double MaximumWindowTrackWidth { get; }
+        public static ResourceKey MaximumWindowTrackWidthKey { get; }
+        public static bool MenuAnimation { get; }
+        public static ResourceKey MenuAnimationKey { get; }
+        public static double MenuBarHeight { get; }
+        public static ResourceKey MenuBarHeightKey { get; }
+        public static double MenuButtonHeight { get; }
+        public static ResourceKey MenuButtonHeightKey { get; }
+        public static double MenuButtonWidth { get; }
+        public static ResourceKey MenuButtonWidthKey { get; }
+        public static double MenuCheckmarkHeight { get; }
+        public static ResourceKey MenuCheckmarkHeightKey { get; }
+        public static double MenuCheckmarkWidth { get; }
+        public static ResourceKey MenuCheckmarkWidthKey { get; }
+        public static bool MenuDropAlignment { get; }
+        public static ResourceKey MenuDropAlignmentKey { get; }
+        public static bool MenuFade { get; }
+        public static ResourceKey MenuFadeKey { get; }
+        public static double MenuHeight { get; }
+        public static ResourceKey MenuHeightKey { get; }
+        public static PopupAnimation MenuPopupAnimation { get; }
+        public static ResourceKey MenuPopupAnimationKey { get; }
+        public static int MenuShowDelay { get; }
+        public static ResourceKey MenuShowDelayKey { get; }
+        public static double MenuWidth { get; }
+        public static ResourceKey MenuWidthKey { get; }
+        public static bool MinimizeAnimation { get; }
+        public static ResourceKey MinimizeAnimationKey { get; }
+        public static double MinimizedGridHeight { get; }
+        public static ResourceKey MinimizedGridHeightKey { get; }
+        public static double MinimizedGridWidth { get; }
+        public static ResourceKey MinimizedGridWidthKey { get; }
+        public static double MinimizedWindowHeight { get; }
+        public static ResourceKey MinimizedWindowHeightKey { get; }
+        public static double MinimizedWindowWidth { get; }
+        public static ResourceKey MinimizedWindowWidthKey { get; }
+        public static double MinimumHorizontalDragDistance { get; }
+        public static double MinimumVerticalDragDistance { get; }
+        public static double MinimumWindowHeight { get; }
+        public static ResourceKey MinimumWindowHeightKey { get; }
+        public static double MinimumWindowTrackHeight { get; }
+        public static ResourceKey MinimumWindowTrackHeightKey { get; }
+        public static double MinimumWindowTrackWidth { get; }
+        public static ResourceKey MinimumWindowTrackWidthKey { get; }
+        public static double MinimumWindowWidth { get; }
+        public static ResourceKey MinimumWindowWidthKey { get; }
+        public static double MouseHoverHeight { get; }
+        public static ResourceKey MouseHoverHeightKey { get; }
+        public static TimeSpan MouseHoverTime { get; }
+        public static ResourceKey MouseHoverTimeKey { get; }
+        public static double MouseHoverWidth { get; }
+        public static ResourceKey MouseHoverWidthKey { get; }
+        public static ResourceKey NavigationChromeDownLevelStyleKey { get; }
+        public static ResourceKey NavigationChromeStyleKey { get; }
+        public static PowerLineStatus PowerLineStatus { get; }
+        public static ResourceKey PowerLineStatusKey { get; }
+        public static double PrimaryScreenHeight { get; }
+        public static ResourceKey PrimaryScreenHeightKey { get; }
+        public static double PrimaryScreenWidth { get; }
+        public static ResourceKey PrimaryScreenWidthKey { get; }
+        public static double ResizeFrameHorizontalBorderHeight { get; }
+        public static ResourceKey ResizeFrameHorizontalBorderHeightKey { get; }
+        public static double ResizeFrameVerticalBorderWidth { get; }
+        public static ResourceKey ResizeFrameVerticalBorderWidthKey { get; }
+        public static double ScrollHeight { get; }
+        public static ResourceKey ScrollHeightKey { get; }
+        public static double ScrollWidth { get; }
+        public static ResourceKey ScrollWidthKey { get; }
+        public static bool SelectionFade { get; }
+        public static ResourceKey SelectionFadeKey { get; }
+        public static bool ShowSounds { get; }
+        public static ResourceKey ShowSoundsKey { get; }
+        public static double SmallCaptionHeight { get; }
+        public static ResourceKey SmallCaptionHeightKey { get; }
+        public static double SmallCaptionWidth { get; }
+        public static ResourceKey SmallCaptionWidthKey { get; }
+        public static double SmallIconHeight { get; }
+        public static ResourceKey SmallIconHeightKey { get; }
+        public static double SmallIconWidth { get; }
+        public static ResourceKey SmallIconWidthKey { get; }
+        public static double SmallWindowCaptionButtonHeight { get; }
+        public static ResourceKey SmallWindowCaptionButtonHeightKey { get; }
+        public static double SmallWindowCaptionButtonWidth { get; }
+        public static ResourceKey SmallWindowCaptionButtonWidthKey { get; }
+        public static bool SnapToDefaultButton { get; }
+        public static ResourceKey SnapToDefaultButtonKey { get; }
+        public static bool StylusHotTracking { get; }
+        public static ResourceKey StylusHotTrackingKey { get; }
+        public static bool SwapButtons { get; }
+        public static ResourceKey SwapButtonsKey { get; }
+        public static double ThickHorizontalBorderHeight { get; }
+        public static ResourceKey ThickHorizontalBorderHeightKey { get; }
+        public static double ThickVerticalBorderWidth { get; }
+        public static ResourceKey ThickVerticalBorderWidthKey { get; }
+        public static double ThinHorizontalBorderHeight { get; }
+        public static ResourceKey ThinHorizontalBorderHeightKey { get; }
+        public static double ThinVerticalBorderWidth { get; }
+        public static ResourceKey ThinVerticalBorderWidthKey { get; }
+        public static bool ToolTipAnimation { get; }
+        public static ResourceKey ToolTipAnimationKey { get; }
+        public static bool ToolTipFade { get; }
+        public static ResourceKey ToolTipFadeKey { get; }
+        public static PopupAnimation ToolTipPopupAnimation { get; }
+        public static ResourceKey ToolTipPopupAnimationKey { get; }
+        public static bool UIEffects { get; }
+        public static ResourceKey UIEffectsKey { get; }
+        public static string UxThemeColor { get; }
+        public static string UxThemeName { get; }
+        public static double VerticalScrollBarButtonHeight { get; }
+        public static ResourceKey VerticalScrollBarButtonHeightKey { get; }
+        public static double VerticalScrollBarThumbHeight { get; }
+        public static ResourceKey VerticalScrollBarThumbHeightKey { get; }
+        public static double VerticalScrollBarWidth { get; }
+        public static ResourceKey VerticalScrollBarWidthKey { get; }
+        public static double VirtualScreenHeight { get; }
+        public static ResourceKey VirtualScreenHeightKey { get; }
+        public static double VirtualScreenLeft { get; }
+        public static ResourceKey VirtualScreenLeftKey { get; }
+        public static double VirtualScreenTop { get; }
+        public static ResourceKey VirtualScreenTopKey { get; }
+        public static double VirtualScreenWidth { get; }
+        public static ResourceKey VirtualScreenWidthKey { get; }
+        public static int WheelScrollLines { get; }
+        public static ResourceKey WheelScrollLinesKey { get; }
+        public static double WindowCaptionButtonHeight { get; }
+        public static ResourceKey WindowCaptionButtonHeightKey { get; }
+        public static double WindowCaptionButtonWidth { get; }
+        public static ResourceKey WindowCaptionButtonWidthKey { get; }
+        public static double WindowCaptionHeight { get; }
+        public static ResourceKey WindowCaptionHeightKey { get; }
+        public static CornerRadius WindowCornerRadius { get; }
+        public static Brush WindowGlassBrush { get; }
+        public static Color WindowGlassColor { get; }
+        public static Thickness WindowNonClientFrameThickness { get; }
+        public static Thickness WindowResizeBorderThickness { get; }
+        public static Rect WorkArea { get; }
+        public static ResourceKey WorkAreaKey { get; }
+        public static event PropertyChangedEventHandler StaticPropertyChanged;
+    }
+    public class TemplateBindingExpression : Expression {
+        public TemplateBindingExtension TemplateBindingExtension { get; }
+    }
+    public class TemplateBindingExpressionConverter : TypeConverter {
+        public TemplateBindingExpressionConverter();
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public class TemplateBindingExtension : MarkupExtension {
+        public TemplateBindingExtension();
+        public TemplateBindingExtension(DependencyProperty property);
+        public IValueConverter Converter { get; set; }
+        public object ConverterParameter { get; set; }
+        public DependencyProperty Property { get; set; }
+        public override object ProvideValue(IServiceProvider serviceProvider);
+    }
+    public class TemplateBindingExtensionConverter : TypeConverter {
+        public TemplateBindingExtensionConverter();
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public class TemplateContent
+    public class TemplateContentLoader : XamlDeferringLoader {
+        public TemplateContentLoader();
+        public override object Load(XamlReader xamlReader, IServiceProvider serviceProvider);
+        public override XamlReader Save(object value, IServiceProvider serviceProvider);
+    }
+    public abstract class TemplateKey : ResourceKey, ISupportInitialize {
+        protected TemplateKey(TemplateKey.TemplateType templateType);
+        protected TemplateKey(TemplateKey.TemplateType templateType, object dataType);
+        public override Assembly Assembly { get; }
+        public object DataType { get; set; }
+        public override bool Equals(object o);
+        public override int GetHashCode();
+        void System.ComponentModel.ISupportInitialize.BeginInit();
+        void System.ComponentModel.ISupportInitialize.EndInit();
+        public override string ToString();
+        protected enum TemplateType {
+            DataTemplate = 0,
+            TableTemplate = 1,
+        }
+    }
+    public sealed class TemplatePartAttribute : Attribute {
+        public TemplatePartAttribute();
+        public string Name { get; set; }
+        public Type Type { get; set; }
+    }
+    public sealed class TemplateVisualStateAttribute : Attribute {
+        public TemplateVisualStateAttribute();
+        public string GroupName { get; set; }
+        public string Name { get; set; }
+    }
+    public enum TextAlignment {
+        Center = 2,
+        Justify = 3,
+        Left = 0,
+        Right = 1,
+    }
+    public enum TextDataFormat {
+        CommaSeparatedValue = 4,
+        Html = 3,
+        Rtf = 2,
+        Text = 0,
+        UnicodeText = 1,
+        Xaml = 5,
+    }
+    public sealed class TextDecoration : Animatable {
+        public static readonly DependencyProperty LocationProperty;
+        public static readonly DependencyProperty PenOffsetProperty;
+        public static readonly DependencyProperty PenOffsetUnitProperty;
+        public static readonly DependencyProperty PenProperty;
+        public static readonly DependencyProperty PenThicknessUnitProperty;
+        public TextDecoration();
+        public TextDecoration(TextDecorationLocation location, Pen pen, double penOffset, TextDecorationUnit penOffsetUnit, TextDecorationUnit penThicknessUnit);
+        public TextDecorationLocation Location { get; set; }
+        public Pen Pen { get; set; }
+        public double PenOffset { get; set; }
+        public TextDecorationUnit PenOffsetUnit { get; set; }
+        public TextDecorationUnit PenThicknessUnit { get; set; }
+        public new TextDecoration Clone();
+        public new TextDecoration CloneCurrentValue();
+        protected override Freezable CreateInstanceCore();
+    }
+    public sealed class TextDecorationCollection : Animatable, ICollection, ICollection<TextDecoration>, IEnumerable, IEnumerable<TextDecoration>, IList, IList<TextDecoration> {
+        public TextDecorationCollection();
+        public TextDecorationCollection(IEnumerable<TextDecoration> collection);
+        public TextDecorationCollection(int capacity);
+        public int Count { get; }
+        bool System.Collections.Generic.ICollection<System.Windows.TextDecoration>.IsReadOnly { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public TextDecoration this[int index] { get; set; }
+        public void Add(IEnumerable<TextDecoration> textDecorations);
+        public void Add(TextDecoration value);
+        public void Clear();
+        public new TextDecorationCollection Clone();
+        protected override void CloneCore(Freezable source);
+        public new TextDecorationCollection CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable source);
+        public bool Contains(TextDecoration value);
+        public void CopyTo(TextDecoration[] array, int index);
+        protected override Freezable CreateInstanceCore();
+        protected override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable source);
+        protected override void GetCurrentValueAsFrozenCore(Freezable source);
+        public TextDecorationCollection.Enumerator GetEnumerator();
+        public int IndexOf(TextDecoration value);
+        public void Insert(int index, TextDecoration value);
+        public bool Remove(TextDecoration value);
+        public void RemoveAt(int index);
+        IEnumerator<TextDecoration> System.Collections.Generic.IEnumerable<System.Windows.TextDecoration>.GetEnumerator();
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        public bool TryRemove(IEnumerable<TextDecoration> textDecorations, out TextDecorationCollection result);
+        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+        public struct Enumerator : IDisposable, IEnumerator, IEnumerator<TextDecoration> {
+            public TextDecoration Current { get; }
+            object System.Collections.IEnumerator.Current { get; }
+            public bool MoveNext();
+            public void Reset();
+            void System.IDisposable.Dispose();
+        }
+    }
+    public sealed class TextDecorationCollectionConverter : TypeConverter {
+        public TextDecorationCollectionConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object input);
+        public static new TextDecorationCollection ConvertFromString(string text);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public enum TextDecorationLocation {
+        Baseline = 3,
+        OverLine = 1,
+        Strikethrough = 2,
+        Underline = 0,
+    }
+    public static class TextDecorations {
+        public static TextDecorationCollection Baseline { get; }
+        public static TextDecorationCollection OverLine { get; }
+        public static TextDecorationCollection Strikethrough { get; }
+        public static TextDecorationCollection Underline { get; }
+    }
+    public enum TextDecorationUnit {
+        FontRecommended = 0,
+        FontRenderingEmSize = 1,
+        Pixel = 2,
+    }
+    public enum TextMarkerStyle {
+        Box = 4,
+        Circle = 2,
+        Decimal = 9,
+        Disc = 1,
+        LowerLatin = 7,
+        LowerRoman = 5,
+        None = 0,
+        Square = 3,
+        UpperLatin = 8,
+        UpperRoman = 6,
+    }
+    public enum TextTrimming {
+        CharacterEllipsis = 1,
+        None = 0,
+        WordEllipsis = 2,
+    }
+    public enum TextWrapping {
+        NoWrap = 1,
+        Wrap = 2,
+        WrapWithOverflow = 0,
+    }
+    public class ThemeDictionaryExtension : MarkupExtension {
+        public ThemeDictionaryExtension();
+        public ThemeDictionaryExtension(string assemblyName);
+        public string AssemblyName { get; set; }
+        public override object ProvideValue(IServiceProvider serviceProvider);
+    }
+    public sealed class ThemeInfoAttribute : Attribute {
+        public ThemeInfoAttribute(ResourceDictionaryLocation themeDictionaryLocation, ResourceDictionaryLocation genericDictionaryLocation);
+        public ResourceDictionaryLocation GenericDictionaryLocation { get; }
+        public ResourceDictionaryLocation ThemeDictionaryLocation { get; }
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct Thickness : IEquatable<Thickness> {
+        public Thickness(double uniformLength);
+        public Thickness(double left, double top, double right, double bottom);
+        public double Bottom { get; set; }
+        public double Left { get; set; }
+        public double Right { get; set; }
+        public double Top { get; set; }
+        public override bool Equals(object obj);
+        public bool Equals(Thickness thickness);
+        public override int GetHashCode();
+        public static bool operator ==(Thickness t1, Thickness t2);
+        public static bool operator !=(Thickness t1, Thickness t2);
+        public override string ToString();
+    }
+    public class ThicknessConverter : TypeConverter {
+        public ThicknessConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext typeDescriptorContext, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext typeDescriptorContext, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext typeDescriptorContext, CultureInfo cultureInfo, object source);
+        public override object ConvertTo(ITypeDescriptorContext typeDescriptorContext, CultureInfo cultureInfo, object value, Type destinationType);
+    }
+    public class Trigger : TriggerBase, IAddChild, ISupportInitialize {
+        public Trigger();
+        public DependencyProperty Property { get; set; }
+        public SetterBaseCollection Setters { get; }
+        public string SourceName { get; set; }
+        public object Value { get; set; }
+        public static void ReceiveTypeConverter(object targetObject, XamlSetTypeConverterEventArgs eventArgs);
+        void System.ComponentModel.ISupportInitialize.BeginInit();
+        void System.ComponentModel.ISupportInitialize.EndInit();
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public abstract class TriggerAction : DependencyObject
+    public sealed class TriggerActionCollection : ICollection, ICollection<TriggerAction>, IEnumerable, IEnumerable<TriggerAction>, IList, IList<TriggerAction> {
+        public TriggerActionCollection();
+        public TriggerActionCollection(int initialSize);
+        public int Count { get; }
+        public bool IsReadOnly { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public TriggerAction this[int index] { get; set; }
+        public void Add(TriggerAction value);
+        public void Clear();
+        public bool Contains(TriggerAction value);
+        public void CopyTo(TriggerAction[] array, int index);
+        public IEnumerator<TriggerAction> GetEnumerator();
+        public int IndexOf(TriggerAction value);
+        public void Insert(int index, TriggerAction value);
+        public bool Remove(TriggerAction value);
+        public void RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+    }
+    public abstract class TriggerBase : DependencyObject {
+        public TriggerActionCollection EnterActions { get; }
+        public TriggerActionCollection ExitActions { get; }
+    }
+    public sealed class TriggerCollection : Collection<TriggerBase> {
+        public bool IsSealed { get; }
+        protected override void ClearItems();
+        protected override void InsertItem(int index, TriggerBase item);
+        protected override void RemoveItem(int index);
+        protected override void SetItem(int index, TriggerBase item);
+    }
+    public class UIElement : Visual, IAnimatable, IInputElement {
+        public static readonly DependencyProperty AllowDropProperty;
+        public static readonly DependencyProperty AreAnyTouchesCapturedProperty;
+        public static readonly DependencyProperty AreAnyTouchesCapturedWithinProperty;
+        public static readonly DependencyProperty AreAnyTouchesDirectlyOverProperty;
+        public static readonly DependencyProperty AreAnyTouchesOverProperty;
+        public static readonly DependencyProperty BitmapEffectInputProperty;
+        public static readonly DependencyProperty BitmapEffectProperty;
+        public static readonly DependencyProperty CacheModeProperty;
+        public static readonly DependencyProperty ClipProperty;
+        public static readonly DependencyProperty ClipToBoundsProperty;
+        public static readonly DependencyProperty EffectProperty;
+        public static readonly DependencyProperty FocusableProperty;
+        public static readonly DependencyProperty IsEnabledProperty;
+        public static readonly DependencyProperty IsFocusedProperty;
+        public static readonly DependencyProperty IsHitTestVisibleProperty;
+        public static readonly DependencyProperty IsKeyboardFocusedProperty;
+        public static readonly DependencyProperty IsKeyboardFocusWithinProperty;
+        public static readonly DependencyProperty IsManipulationEnabledProperty;
+        public static readonly DependencyProperty IsMouseCapturedProperty;
+        public static readonly DependencyProperty IsMouseCaptureWithinProperty;
+        public static readonly DependencyProperty IsMouseDirectlyOverProperty;
+        public static readonly DependencyProperty IsMouseOverProperty;
+        public static readonly DependencyProperty IsStylusCapturedProperty;
+        public static readonly DependencyProperty IsStylusCaptureWithinProperty;
+        public static readonly DependencyProperty IsStylusDirectlyOverProperty;
+        public static readonly DependencyProperty IsStylusOverProperty;
+        public static readonly DependencyProperty IsVisibleProperty;
+        public static readonly DependencyProperty OpacityMaskProperty;
+        public static readonly DependencyProperty OpacityProperty;
+        public static readonly DependencyProperty RenderTransformOriginProperty;
+        public static readonly DependencyProperty RenderTransformProperty;
+        public static readonly DependencyProperty SnapsToDevicePixelsProperty;
+        public static readonly DependencyProperty UidProperty;
+        public static readonly DependencyProperty VisibilityProperty;
+        public static readonly RoutedEvent DragEnterEvent;
+        public static readonly RoutedEvent DragLeaveEvent;
+        public static readonly RoutedEvent DragOverEvent;
+        public static readonly RoutedEvent DropEvent;
+        public static readonly RoutedEvent GiveFeedbackEvent;
+        public static readonly RoutedEvent GotFocusEvent;
+        public static readonly RoutedEvent GotKeyboardFocusEvent;
+        public static readonly RoutedEvent GotMouseCaptureEvent;
+        public static readonly RoutedEvent GotStylusCaptureEvent;
+        public static readonly RoutedEvent GotTouchCaptureEvent;
+        public static readonly RoutedEvent KeyDownEvent;
+        public static readonly RoutedEvent KeyUpEvent;
+        public static readonly RoutedEvent LostFocusEvent;
+        public static readonly RoutedEvent LostKeyboardFocusEvent;
+        public static readonly RoutedEvent LostMouseCaptureEvent;
+        public static readonly RoutedEvent LostStylusCaptureEvent;
+        public static readonly RoutedEvent LostTouchCaptureEvent;
+        public static readonly RoutedEvent ManipulationBoundaryFeedbackEvent;
+        public static readonly RoutedEvent ManipulationCompletedEvent;
+        public static readonly RoutedEvent ManipulationDeltaEvent;
+        public static readonly RoutedEvent ManipulationInertiaStartingEvent;
+        public static readonly RoutedEvent ManipulationStartedEvent;
+        public static readonly RoutedEvent ManipulationStartingEvent;
+        public static readonly RoutedEvent MouseDownEvent;
+        public static readonly RoutedEvent MouseEnterEvent;
+        public static readonly RoutedEvent MouseLeaveEvent;
+        public static readonly RoutedEvent MouseLeftButtonDownEvent;
+        public static readonly RoutedEvent MouseLeftButtonUpEvent;
+        public static readonly RoutedEvent MouseMoveEvent;
+        public static readonly RoutedEvent MouseRightButtonDownEvent;
+        public static readonly RoutedEvent MouseRightButtonUpEvent;
+        public static readonly RoutedEvent MouseUpEvent;
+        public static readonly RoutedEvent MouseWheelEvent;
+        public static readonly RoutedEvent PreviewDragEnterEvent;
+        public static readonly RoutedEvent PreviewDragLeaveEvent;
+        public static readonly RoutedEvent PreviewDragOverEvent;
+        public static readonly RoutedEvent PreviewDropEvent;
+        public static readonly RoutedEvent PreviewGiveFeedbackEvent;
+        public static readonly RoutedEvent PreviewGotKeyboardFocusEvent;
+        public static readonly RoutedEvent PreviewKeyDownEvent;
+        public static readonly RoutedEvent PreviewKeyUpEvent;
+        public static readonly RoutedEvent PreviewLostKeyboardFocusEvent;
+        public static readonly RoutedEvent PreviewMouseDownEvent;
+        public static readonly RoutedEvent PreviewMouseLeftButtonDownEvent;
+        public static readonly RoutedEvent PreviewMouseLeftButtonUpEvent;
+        public static readonly RoutedEvent PreviewMouseMoveEvent;
+        public static readonly RoutedEvent PreviewMouseRightButtonDownEvent;
+        public static readonly RoutedEvent PreviewMouseRightButtonUpEvent;
+        public static readonly RoutedEvent PreviewMouseUpEvent;
+        public static readonly RoutedEvent PreviewMouseWheelEvent;
+        public static readonly RoutedEvent PreviewQueryContinueDragEvent;
+        public static readonly RoutedEvent PreviewStylusButtonDownEvent;
+        public static readonly RoutedEvent PreviewStylusButtonUpEvent;
+        public static readonly RoutedEvent PreviewStylusDownEvent;
+        public static readonly RoutedEvent PreviewStylusInAirMoveEvent;
+        public static readonly RoutedEvent PreviewStylusInRangeEvent;
+        public static readonly RoutedEvent PreviewStylusMoveEvent;
+        public static readonly RoutedEvent PreviewStylusOutOfRangeEvent;
+        public static readonly RoutedEvent PreviewStylusSystemGestureEvent;
+        public static readonly RoutedEvent PreviewStylusUpEvent;
+        public static readonly RoutedEvent PreviewTextInputEvent;
+        public static readonly RoutedEvent PreviewTouchDownEvent;
+        public static readonly RoutedEvent PreviewTouchMoveEvent;
+        public static readonly RoutedEvent PreviewTouchUpEvent;
+        public static readonly RoutedEvent QueryContinueDragEvent;
+        public static readonly RoutedEvent QueryCursorEvent;
+        public static readonly RoutedEvent StylusButtonDownEvent;
+        public static readonly RoutedEvent StylusButtonUpEvent;
+        public static readonly RoutedEvent StylusDownEvent;
+        public static readonly RoutedEvent StylusEnterEvent;
+        public static readonly RoutedEvent StylusInAirMoveEvent;
+        public static readonly RoutedEvent StylusInRangeEvent;
+        public static readonly RoutedEvent StylusLeaveEvent;
+        public static readonly RoutedEvent StylusMoveEvent;
+        public static readonly RoutedEvent StylusOutOfRangeEvent;
+        public static readonly RoutedEvent StylusSystemGestureEvent;
+        public static readonly RoutedEvent StylusUpEvent;
+        public static readonly RoutedEvent TextInputEvent;
+        public static readonly RoutedEvent TouchDownEvent;
+        public static readonly RoutedEvent TouchEnterEvent;
+        public static readonly RoutedEvent TouchLeaveEvent;
+        public static readonly RoutedEvent TouchMoveEvent;
+        public static readonly RoutedEvent TouchUpEvent;
+        public UIElement();
+        public bool AllowDrop { get; set; }
+        public bool AreAnyTouchesCaptured { get; }
+        public bool AreAnyTouchesCapturedWithin { get; }
+        public bool AreAnyTouchesDirectlyOver { get; }
+        public bool AreAnyTouchesOver { get; }
+        public BitmapEffect BitmapEffect { get; set; }
+        public BitmapEffectInput BitmapEffectInput { get; set; }
+        public CacheMode CacheMode { get; set; }
+        public Geometry Clip { get; set; }
+        public bool ClipToBounds { get; set; }
+        public CommandBindingCollection CommandBindings { get; }
+        public Size DesiredSize { get; }
+        public Effect Effect { get; set; }
+        public bool Focusable { get; set; }
+        public bool HasAnimatedProperties { get; }
+        protected internal virtual bool HasEffectiveKeyboardFocus { get; }
+        public InputBindingCollection InputBindings { get; }
+        public bool IsArrangeValid { get; }
+        public bool IsEnabled { get; set; }
+        protected virtual bool IsEnabledCore { get; }
+        public bool IsFocused { get; }
+        public bool IsHitTestVisible { get; set; }
+        public bool IsInputMethodEnabled { get; }
+        public bool IsKeyboardFocused { get; }
+        public bool IsKeyboardFocusWithin { get; }
+        public bool IsManipulationEnabled { get; set; }
+        public bool IsMeasureValid { get; }
+        public bool IsMouseCaptured { get; }
+        public bool IsMouseCaptureWithin { get; }
+        public bool IsMouseDirectlyOver { get; }
+        public bool IsMouseOver { get; }
+        public bool IsStylusCaptured { get; }
+        public bool IsStylusCaptureWithin { get; }
+        public bool IsStylusDirectlyOver { get; }
+        public bool IsStylusOver { get; }
+        public bool IsVisible { get; }
+        public double Opacity { get; set; }
+        public Brush OpacityMask { get; set; }
+        public int PersistId { get; }
+        public Size RenderSize { get; set; }
+        public Transform RenderTransform { get; set; }
+        public Point RenderTransformOrigin { get; set; }
+        public bool SnapsToDevicePixels { get; set; }
+        protected StylusPlugInCollection StylusPlugIns { get; }
+        public IEnumerable<TouchDevice> TouchesCaptured { get; }
+        public IEnumerable<TouchDevice> TouchesCapturedWithin { get; }
+        public IEnumerable<TouchDevice> TouchesDirectlyOver { get; }
+        public IEnumerable<TouchDevice> TouchesOver { get; }
+        public string Uid { get; set; }
+        public Visibility Visibility { get; set; }
+        public event DragEventHandler DragEnter;
+        public event DragEventHandler DragLeave;
+        public event DragEventHandler DragOver;
+        public event DragEventHandler Drop;
+        public event DependencyPropertyChangedEventHandler FocusableChanged;
+        public event GiveFeedbackEventHandler GiveFeedback;
+        public event RoutedEventHandler GotFocus;
+        public event KeyboardFocusChangedEventHandler GotKeyboardFocus;
+        public event MouseEventHandler GotMouseCapture;
+        public event StylusEventHandler GotStylusCapture;
+        public event EventHandler<TouchEventArgs> GotTouchCapture;
+        public event DependencyPropertyChangedEventHandler IsEnabledChanged;
+        public event DependencyPropertyChangedEventHandler IsHitTestVisibleChanged;
+        public event DependencyPropertyChangedEventHandler IsKeyboardFocusedChanged;
+        public event DependencyPropertyChangedEventHandler IsKeyboardFocusWithinChanged;
+        public event DependencyPropertyChangedEventHandler IsMouseCapturedChanged;
+        public event DependencyPropertyChangedEventHandler IsMouseCaptureWithinChanged;
+        public event DependencyPropertyChangedEventHandler IsMouseDirectlyOverChanged;
+        public event DependencyPropertyChangedEventHandler IsStylusCapturedChanged;
+        public event DependencyPropertyChangedEventHandler IsStylusCaptureWithinChanged;
+        public event DependencyPropertyChangedEventHandler IsStylusDirectlyOverChanged;
+        public event DependencyPropertyChangedEventHandler IsVisibleChanged;
+        public event KeyEventHandler KeyDown;
+        public event KeyEventHandler KeyUp;
+        public event EventHandler LayoutUpdated;
+        public event RoutedEventHandler LostFocus;
+        public event KeyboardFocusChangedEventHandler LostKeyboardFocus;
+        public event MouseEventHandler LostMouseCapture;
+        public event StylusEventHandler LostStylusCapture;
+        public event EventHandler<TouchEventArgs> LostTouchCapture;
+        public event EventHandler<ManipulationBoundaryFeedbackEventArgs> ManipulationBoundaryFeedback;
+        public event EventHandler<ManipulationCompletedEventArgs> ManipulationCompleted;
+        public event EventHandler<ManipulationDeltaEventArgs> ManipulationDelta;
+        public event EventHandler<ManipulationInertiaStartingEventArgs> ManipulationInertiaStarting;
+        public event EventHandler<ManipulationStartedEventArgs> ManipulationStarted;
+        public event EventHandler<ManipulationStartingEventArgs> ManipulationStarting;
+        public event MouseButtonEventHandler MouseDown;
+        public event MouseEventHandler MouseEnter;
+        public event MouseEventHandler MouseLeave;
+        public event MouseButtonEventHandler MouseLeftButtonDown;
+        public event MouseButtonEventHandler MouseLeftButtonUp;
+        public event MouseEventHandler MouseMove;
+        public event MouseButtonEventHandler MouseRightButtonDown;
+        public event MouseButtonEventHandler MouseRightButtonUp;
+        public event MouseButtonEventHandler MouseUp;
+        public event MouseWheelEventHandler MouseWheel;
+        public event DragEventHandler PreviewDragEnter;
+        public event DragEventHandler PreviewDragLeave;
+        public event DragEventHandler PreviewDragOver;
+        public event DragEventHandler PreviewDrop;
+        public event GiveFeedbackEventHandler PreviewGiveFeedback;
+        public event KeyboardFocusChangedEventHandler PreviewGotKeyboardFocus;
+        public event KeyEventHandler PreviewKeyDown;
+        public event KeyEventHandler PreviewKeyUp;
+        public event KeyboardFocusChangedEventHandler PreviewLostKeyboardFocus;
+        public event MouseButtonEventHandler PreviewMouseDown;
+        public event MouseButtonEventHandler PreviewMouseLeftButtonDown;
+        public event MouseButtonEventHandler PreviewMouseLeftButtonUp;
+        public event MouseEventHandler PreviewMouseMove;
+        public event MouseButtonEventHandler PreviewMouseRightButtonDown;
+        public event MouseButtonEventHandler PreviewMouseRightButtonUp;
+        public event MouseButtonEventHandler PreviewMouseUp;
+        public event MouseWheelEventHandler PreviewMouseWheel;
+        public event QueryContinueDragEventHandler PreviewQueryContinueDrag;
+        public event StylusButtonEventHandler PreviewStylusButtonDown;
+        public event StylusButtonEventHandler PreviewStylusButtonUp;
+        public event StylusDownEventHandler PreviewStylusDown;
+        public event StylusEventHandler PreviewStylusInAirMove;
+        public event StylusEventHandler PreviewStylusInRange;
+        public event StylusEventHandler PreviewStylusMove;
+        public event StylusEventHandler PreviewStylusOutOfRange;
+        public event StylusSystemGestureEventHandler PreviewStylusSystemGesture;
+        public event StylusEventHandler PreviewStylusUp;
+        public event TextCompositionEventHandler PreviewTextInput;
+        public event EventHandler<TouchEventArgs> PreviewTouchDown;
+        public event EventHandler<TouchEventArgs> PreviewTouchMove;
+        public event EventHandler<TouchEventArgs> PreviewTouchUp;
+        public event QueryContinueDragEventHandler QueryContinueDrag;
+        public event QueryCursorEventHandler QueryCursor;
+        public event StylusButtonEventHandler StylusButtonDown;
+        public event StylusButtonEventHandler StylusButtonUp;
+        public event StylusDownEventHandler StylusDown;
+        public event StylusEventHandler StylusEnter;
+        public event StylusEventHandler StylusInAirMove;
+        public event StylusEventHandler StylusInRange;
+        public event StylusEventHandler StylusLeave;
+        public event StylusEventHandler StylusMove;
+        public event StylusEventHandler StylusOutOfRange;
+        public event StylusSystemGestureEventHandler StylusSystemGesture;
+        public event StylusEventHandler StylusUp;
+        public event TextCompositionEventHandler TextInput;
+        public event EventHandler<TouchEventArgs> TouchDown;
+        public event EventHandler<TouchEventArgs> TouchEnter;
+        public event EventHandler<TouchEventArgs> TouchLeave;
+        public event EventHandler<TouchEventArgs> TouchMove;
+        public event EventHandler<TouchEventArgs> TouchUp;
+        public void AddHandler(RoutedEvent routedEvent, Delegate handler);
+        public void AddHandler(RoutedEvent routedEvent, Delegate handler, bool handledEventsToo);
+        public void AddToEventRoute(EventRoute route, RoutedEventArgs e);
+        public void ApplyAnimationClock(DependencyProperty dp, AnimationClock clock);
+        public void ApplyAnimationClock(DependencyProperty dp, AnimationClock clock, HandoffBehavior handoffBehavior);
+        public void Arrange(Rect finalRect);
+        protected virtual void ArrangeCore(Rect finalRect);
+        public void BeginAnimation(DependencyProperty dp, AnimationTimeline animation);
+        public void BeginAnimation(DependencyProperty dp, AnimationTimeline animation, HandoffBehavior handoffBehavior);
+        public bool CaptureMouse();
+        public bool CaptureStylus();
+        public bool CaptureTouch(TouchDevice touchDevice);
+        public bool Focus();
+        public object GetAnimationBaseValue(DependencyProperty dp);
+        protected virtual Geometry GetLayoutClip(Size layoutSlotSize);
+        protected internal virtual DependencyObject GetUIParentCore();
+        protected override GeometryHitTestResult HitTestCore(GeometryHitTestParameters hitTestParameters);
+        protected override HitTestResult HitTestCore(PointHitTestParameters hitTestParameters);
+        public IInputElement InputHitTest(Point point);
+        public void InvalidateArrange();
+        public void InvalidateMeasure();
+        public void InvalidateVisual();
+        public void Measure(Size availableSize);
+        protected virtual Size MeasureCore(Size availableSize);
+        public virtual bool MoveFocus(TraversalRequest request);
+        protected virtual void OnAccessKey(AccessKeyEventArgs e);
+        protected virtual void OnChildDesiredSizeChanged(UIElement child);
+        protected virtual AutomationPeer OnCreateAutomationPeer();
+        protected virtual void OnDragEnter(DragEventArgs e);
+        protected virtual void OnDragLeave(DragEventArgs e);
+        protected virtual void OnDragOver(DragEventArgs e);
+        protected virtual void OnDrop(DragEventArgs e);
+        protected virtual void OnGiveFeedback(GiveFeedbackEventArgs e);
+        protected virtual void OnGotFocus(RoutedEventArgs e);
+        protected virtual void OnGotKeyboardFocus(KeyboardFocusChangedEventArgs e);
+        protected virtual void OnGotMouseCapture(MouseEventArgs e);
+        protected virtual void OnGotStylusCapture(StylusEventArgs e);
+        protected virtual void OnGotTouchCapture(TouchEventArgs e);
+        protected virtual void OnIsKeyboardFocusedChanged(DependencyPropertyChangedEventArgs e);
+        protected virtual void OnIsKeyboardFocusWithinChanged(DependencyPropertyChangedEventArgs e);
+        protected virtual void OnIsMouseCapturedChanged(DependencyPropertyChangedEventArgs e);
+        protected virtual void OnIsMouseCaptureWithinChanged(DependencyPropertyChangedEventArgs e);
+        protected virtual void OnIsMouseDirectlyOverChanged(DependencyPropertyChangedEventArgs e);
+        protected virtual void OnIsStylusCapturedChanged(DependencyPropertyChangedEventArgs e);
+        protected virtual void OnIsStylusCaptureWithinChanged(DependencyPropertyChangedEventArgs e);
+        protected virtual void OnIsStylusDirectlyOverChanged(DependencyPropertyChangedEventArgs e);
+        protected virtual void OnKeyDown(KeyEventArgs e);
+        protected virtual void OnKeyUp(KeyEventArgs e);
+        protected virtual void OnLostFocus(RoutedEventArgs e);
+        protected virtual void OnLostKeyboardFocus(KeyboardFocusChangedEventArgs e);
+        protected virtual void OnLostMouseCapture(MouseEventArgs e);
+        protected virtual void OnLostStylusCapture(StylusEventArgs e);
+        protected virtual void OnLostTouchCapture(TouchEventArgs e);
+        protected virtual void OnManipulationBoundaryFeedback(ManipulationBoundaryFeedbackEventArgs e);
+        protected virtual void OnManipulationCompleted(ManipulationCompletedEventArgs e);
+        protected virtual void OnManipulationDelta(ManipulationDeltaEventArgs e);
+        protected virtual void OnManipulationInertiaStarting(ManipulationInertiaStartingEventArgs e);
+        protected virtual void OnManipulationStarted(ManipulationStartedEventArgs e);
+        protected virtual void OnManipulationStarting(ManipulationStartingEventArgs e);
+        protected virtual void OnMouseDown(MouseButtonEventArgs e);
+        protected virtual void OnMouseEnter(MouseEventArgs e);
+        protected virtual void OnMouseLeave(MouseEventArgs e);
+        protected virtual void OnMouseLeftButtonDown(MouseButtonEventArgs e);
+        protected virtual void OnMouseLeftButtonUp(MouseButtonEventArgs e);
+        protected virtual void OnMouseMove(MouseEventArgs e);
+        protected virtual void OnMouseRightButtonDown(MouseButtonEventArgs e);
+        protected virtual void OnMouseRightButtonUp(MouseButtonEventArgs e);
+        protected virtual void OnMouseUp(MouseButtonEventArgs e);
+        protected virtual void OnMouseWheel(MouseWheelEventArgs e);
+        protected virtual void OnPreviewDragEnter(DragEventArgs e);
+        protected virtual void OnPreviewDragLeave(DragEventArgs e);
+        protected virtual void OnPreviewDragOver(DragEventArgs e);
+        protected virtual void OnPreviewDrop(DragEventArgs e);
+        protected virtual void OnPreviewGiveFeedback(GiveFeedbackEventArgs e);
+        protected virtual void OnPreviewGotKeyboardFocus(KeyboardFocusChangedEventArgs e);
+        protected virtual void OnPreviewKeyDown(KeyEventArgs e);
+        protected virtual void OnPreviewKeyUp(KeyEventArgs e);
+        protected virtual void OnPreviewLostKeyboardFocus(KeyboardFocusChangedEventArgs e);
+        protected virtual void OnPreviewMouseDown(MouseButtonEventArgs e);
+        protected virtual void OnPreviewMouseLeftButtonDown(MouseButtonEventArgs e);
+        protected virtual void OnPreviewMouseLeftButtonUp(MouseButtonEventArgs e);
+        protected virtual void OnPreviewMouseMove(MouseEventArgs e);
+        protected virtual void OnPreviewMouseRightButtonDown(MouseButtonEventArgs e);
+        protected virtual void OnPreviewMouseRightButtonUp(MouseButtonEventArgs e);
+        protected virtual void OnPreviewMouseUp(MouseButtonEventArgs e);
+        protected virtual void OnPreviewMouseWheel(MouseWheelEventArgs e);
+        protected virtual void OnPreviewQueryContinueDrag(QueryContinueDragEventArgs e);
+        protected virtual void OnPreviewStylusButtonDown(StylusButtonEventArgs e);
+        protected virtual void OnPreviewStylusButtonUp(StylusButtonEventArgs e);
+        protected virtual void OnPreviewStylusDown(StylusDownEventArgs e);
+        protected virtual void OnPreviewStylusInAirMove(StylusEventArgs e);
+        protected virtual void OnPreviewStylusInRange(StylusEventArgs e);
+        protected virtual void OnPreviewStylusMove(StylusEventArgs e);
+        protected virtual void OnPreviewStylusOutOfRange(StylusEventArgs e);
+        protected virtual void OnPreviewStylusSystemGesture(StylusSystemGestureEventArgs e);
+        protected virtual void OnPreviewStylusUp(StylusEventArgs e);
+        protected virtual void OnPreviewTextInput(TextCompositionEventArgs e);
+        protected virtual void OnPreviewTouchDown(TouchEventArgs e);
+        protected virtual void OnPreviewTouchMove(TouchEventArgs e);
+        protected virtual void OnPreviewTouchUp(TouchEventArgs e);
+        protected virtual void OnQueryContinueDrag(QueryContinueDragEventArgs e);
+        protected virtual void OnQueryCursor(QueryCursorEventArgs e);
+        protected virtual void OnRender(DrawingContext drawingContext);
+        protected internal virtual void OnRenderSizeChanged(SizeChangedInfo info);
+        protected virtual void OnStylusButtonDown(StylusButtonEventArgs e);
+        protected virtual void OnStylusButtonUp(StylusButtonEventArgs e);
+        protected virtual void OnStylusDown(StylusDownEventArgs e);
+        protected virtual void OnStylusEnter(StylusEventArgs e);
+        protected virtual void OnStylusInAirMove(StylusEventArgs e);
+        protected virtual void OnStylusInRange(StylusEventArgs e);
+        protected virtual void OnStylusLeave(StylusEventArgs e);
+        protected virtual void OnStylusMove(StylusEventArgs e);
+        protected virtual void OnStylusOutOfRange(StylusEventArgs e);
+        protected virtual void OnStylusSystemGesture(StylusSystemGestureEventArgs e);
+        protected virtual void OnStylusUp(StylusEventArgs e);
+        protected virtual void OnTextInput(TextCompositionEventArgs e);
+        protected virtual void OnTouchDown(TouchEventArgs e);
+        protected virtual void OnTouchEnter(TouchEventArgs e);
+        protected virtual void OnTouchLeave(TouchEventArgs e);
+        protected virtual void OnTouchMove(TouchEventArgs e);
+        protected virtual void OnTouchUp(TouchEventArgs e);
+        protected internal override void OnVisualParentChanged(DependencyObject oldParent);
+        public virtual DependencyObject PredictFocus(FocusNavigationDirection direction);
+        public void RaiseEvent(RoutedEventArgs e);
+        public void ReleaseAllTouchCaptures();
+        public void ReleaseMouseCapture();
+        public void ReleaseStylusCapture();
+        public bool ReleaseTouchCapture(TouchDevice touchDevice);
+        public void RemoveHandler(RoutedEvent routedEvent, Delegate handler);
+        public bool ShouldSerializeCommandBindings();
+        public bool ShouldSerializeInputBindings();
+        public Point TranslatePoint(Point point, UIElement relativeTo);
+        public void UpdateLayout();
+    }
+    public abstract class UIElement3D : Visual3D, IInputElement {
+        public static readonly DependencyProperty AllowDropProperty;
+        public static readonly DependencyProperty AreAnyTouchesCapturedProperty;
+        public static readonly DependencyProperty AreAnyTouchesCapturedWithinProperty;
+        public static readonly DependencyProperty AreAnyTouchesDirectlyOverProperty;
+        public static readonly DependencyProperty AreAnyTouchesOverProperty;
+        public static readonly DependencyProperty FocusableProperty;
+        public static readonly DependencyProperty IsEnabledProperty;
+        public static readonly DependencyProperty IsFocusedProperty;
+        public static readonly DependencyProperty IsHitTestVisibleProperty;
+        public static readonly DependencyProperty IsKeyboardFocusedProperty;
+        public static readonly DependencyProperty IsKeyboardFocusWithinProperty;
+        public static readonly DependencyProperty IsMouseCapturedProperty;
+        public static readonly DependencyProperty IsMouseCaptureWithinProperty;
+        public static readonly DependencyProperty IsMouseDirectlyOverProperty;
+        public static readonly DependencyProperty IsMouseOverProperty;
+        public static readonly DependencyProperty IsStylusCapturedProperty;
+        public static readonly DependencyProperty IsStylusCaptureWithinProperty;
+        public static readonly DependencyProperty IsStylusDirectlyOverProperty;
+        public static readonly DependencyProperty IsStylusOverProperty;
+        public static readonly DependencyProperty IsVisibleProperty;
+        public static readonly DependencyProperty VisibilityProperty;
+        public static readonly RoutedEvent DragEnterEvent;
+        public static readonly RoutedEvent DragLeaveEvent;
+        public static readonly RoutedEvent DragOverEvent;
+        public static readonly RoutedEvent DropEvent;
+        public static readonly RoutedEvent GiveFeedbackEvent;
+        public static readonly RoutedEvent GotFocusEvent;
+        public static readonly RoutedEvent GotKeyboardFocusEvent;
+        public static readonly RoutedEvent GotMouseCaptureEvent;
+        public static readonly RoutedEvent GotStylusCaptureEvent;
+        public static readonly RoutedEvent GotTouchCaptureEvent;
+        public static readonly RoutedEvent KeyDownEvent;
+        public static readonly RoutedEvent KeyUpEvent;
+        public static readonly RoutedEvent LostFocusEvent;
+        public static readonly RoutedEvent LostKeyboardFocusEvent;
+        public static readonly RoutedEvent LostMouseCaptureEvent;
+        public static readonly RoutedEvent LostStylusCaptureEvent;
+        public static readonly RoutedEvent LostTouchCaptureEvent;
+        public static readonly RoutedEvent MouseDownEvent;
+        public static readonly RoutedEvent MouseEnterEvent;
+        public static readonly RoutedEvent MouseLeaveEvent;
+        public static readonly RoutedEvent MouseLeftButtonDownEvent;
+        public static readonly RoutedEvent MouseLeftButtonUpEvent;
+        public static readonly RoutedEvent MouseMoveEvent;
+        public static readonly RoutedEvent MouseRightButtonDownEvent;
+        public static readonly RoutedEvent MouseRightButtonUpEvent;
+        public static readonly RoutedEvent MouseUpEvent;
+        public static readonly RoutedEvent MouseWheelEvent;
+        public static readonly RoutedEvent PreviewDragEnterEvent;
+        public static readonly RoutedEvent PreviewDragLeaveEvent;
+        public static readonly RoutedEvent PreviewDragOverEvent;
+        public static readonly RoutedEvent PreviewDropEvent;
+        public static readonly RoutedEvent PreviewGiveFeedbackEvent;
+        public static readonly RoutedEvent PreviewGotKeyboardFocusEvent;
+        public static readonly RoutedEvent PreviewKeyDownEvent;
+        public static readonly RoutedEvent PreviewKeyUpEvent;
+        public static readonly RoutedEvent PreviewLostKeyboardFocusEvent;
+        public static readonly RoutedEvent PreviewMouseDownEvent;
+        public static readonly RoutedEvent PreviewMouseLeftButtonDownEvent;
+        public static readonly RoutedEvent PreviewMouseLeftButtonUpEvent;
+        public static readonly RoutedEvent PreviewMouseMoveEvent;
+        public static readonly RoutedEvent PreviewMouseRightButtonDownEvent;
+        public static readonly RoutedEvent PreviewMouseRightButtonUpEvent;
+        public static readonly RoutedEvent PreviewMouseUpEvent;
+        public static readonly RoutedEvent PreviewMouseWheelEvent;
+        public static readonly RoutedEvent PreviewQueryContinueDragEvent;
+        public static readonly RoutedEvent PreviewStylusButtonDownEvent;
+        public static readonly RoutedEvent PreviewStylusButtonUpEvent;
+        public static readonly RoutedEvent PreviewStylusDownEvent;
+        public static readonly RoutedEvent PreviewStylusInAirMoveEvent;
+        public static readonly RoutedEvent PreviewStylusInRangeEvent;
+        public static readonly RoutedEvent PreviewStylusMoveEvent;
+        public static readonly RoutedEvent PreviewStylusOutOfRangeEvent;
+        public static readonly RoutedEvent PreviewStylusSystemGestureEvent;
+        public static readonly RoutedEvent PreviewStylusUpEvent;
+        public static readonly RoutedEvent PreviewTextInputEvent;
+        public static readonly RoutedEvent PreviewTouchDownEvent;
+        public static readonly RoutedEvent PreviewTouchMoveEvent;
+        public static readonly RoutedEvent PreviewTouchUpEvent;
+        public static readonly RoutedEvent QueryContinueDragEvent;
+        public static readonly RoutedEvent QueryCursorEvent;
+        public static readonly RoutedEvent StylusButtonDownEvent;
+        public static readonly RoutedEvent StylusButtonUpEvent;
+        public static readonly RoutedEvent StylusDownEvent;
+        public static readonly RoutedEvent StylusEnterEvent;
+        public static readonly RoutedEvent StylusInAirMoveEvent;
+        public static readonly RoutedEvent StylusInRangeEvent;
+        public static readonly RoutedEvent StylusLeaveEvent;
+        public static readonly RoutedEvent StylusMoveEvent;
+        public static readonly RoutedEvent StylusOutOfRangeEvent;
+        public static readonly RoutedEvent StylusSystemGestureEvent;
+        public static readonly RoutedEvent StylusUpEvent;
+        public static readonly RoutedEvent TextInputEvent;
+        public static readonly RoutedEvent TouchDownEvent;
+        public static readonly RoutedEvent TouchEnterEvent;
+        public static readonly RoutedEvent TouchLeaveEvent;
+        public static readonly RoutedEvent TouchMoveEvent;
+        public static readonly RoutedEvent TouchUpEvent;
+        protected UIElement3D();
+        public bool AllowDrop { get; set; }
+        public bool AreAnyTouchesCaptured { get; }
+        public bool AreAnyTouchesCapturedWithin { get; }
+        public bool AreAnyTouchesDirectlyOver { get; }
+        public bool AreAnyTouchesOver { get; }
+        public CommandBindingCollection CommandBindings { get; }
+        public bool Focusable { get; set; }
+        public InputBindingCollection InputBindings { get; }
+        public bool IsEnabled { get; set; }
+        protected virtual bool IsEnabledCore { get; }
+        public bool IsFocused { get; }
+        public bool IsHitTestVisible { get; set; }
+        public bool IsInputMethodEnabled { get; }
+        public bool IsKeyboardFocused { get; }
+        public bool IsKeyboardFocusWithin { get; }
+        public bool IsMouseCaptured { get; }
+        public bool IsMouseCaptureWithin { get; }
+        public bool IsMouseDirectlyOver { get; }
+        public bool IsMouseOver { get; }
+        public bool IsStylusCaptured { get; }
+        public bool IsStylusCaptureWithin { get; }
+        public bool IsStylusDirectlyOver { get; }
+        public bool IsStylusOver { get; }
+        public bool IsVisible { get; }
+        public IEnumerable<TouchDevice> TouchesCaptured { get; }
+        public IEnumerable<TouchDevice> TouchesCapturedWithin { get; }
+        public IEnumerable<TouchDevice> TouchesDirectlyOver { get; }
+        public IEnumerable<TouchDevice> TouchesOver { get; }
+        public Visibility Visibility { get; set; }
+        public event DragEventHandler DragEnter;
+        public event DragEventHandler DragLeave;
+        public event DragEventHandler DragOver;
+        public event DragEventHandler Drop;
+        public event DependencyPropertyChangedEventHandler FocusableChanged;
+        public event GiveFeedbackEventHandler GiveFeedback;
+        public event RoutedEventHandler GotFocus;
+        public event KeyboardFocusChangedEventHandler GotKeyboardFocus;
+        public event MouseEventHandler GotMouseCapture;
+        public event StylusEventHandler GotStylusCapture;
+        public event EventHandler<TouchEventArgs> GotTouchCapture;
+        public event DependencyPropertyChangedEventHandler IsEnabledChanged;
+        public event DependencyPropertyChangedEventHandler IsHitTestVisibleChanged;
+        public event DependencyPropertyChangedEventHandler IsKeyboardFocusedChanged;
+        public event DependencyPropertyChangedEventHandler IsKeyboardFocusWithinChanged;
+        public event DependencyPropertyChangedEventHandler IsMouseCapturedChanged;
+        public event DependencyPropertyChangedEventHandler IsMouseCaptureWithinChanged;
+        public event DependencyPropertyChangedEventHandler IsMouseDirectlyOverChanged;
+        public event DependencyPropertyChangedEventHandler IsStylusCapturedChanged;
+        public event DependencyPropertyChangedEventHandler IsStylusCaptureWithinChanged;
+        public event DependencyPropertyChangedEventHandler IsStylusDirectlyOverChanged;
+        public event DependencyPropertyChangedEventHandler IsVisibleChanged;
+        public event KeyEventHandler KeyDown;
+        public event KeyEventHandler KeyUp;
+        public event RoutedEventHandler LostFocus;
+        public event KeyboardFocusChangedEventHandler LostKeyboardFocus;
+        public event MouseEventHandler LostMouseCapture;
+        public event StylusEventHandler LostStylusCapture;
+        public event EventHandler<TouchEventArgs> LostTouchCapture;
+        public event MouseButtonEventHandler MouseDown;
+        public event MouseEventHandler MouseEnter;
+        public event MouseEventHandler MouseLeave;
+        public event MouseButtonEventHandler MouseLeftButtonDown;
+        public event MouseButtonEventHandler MouseLeftButtonUp;
+        public event MouseEventHandler MouseMove;
+        public event MouseButtonEventHandler MouseRightButtonDown;
+        public event MouseButtonEventHandler MouseRightButtonUp;
+        public event MouseButtonEventHandler MouseUp;
+        public event MouseWheelEventHandler MouseWheel;
+        public event DragEventHandler PreviewDragEnter;
+        public event DragEventHandler PreviewDragLeave;
+        public event DragEventHandler PreviewDragOver;
+        public event DragEventHandler PreviewDrop;
+        public event GiveFeedbackEventHandler PreviewGiveFeedback;
+        public event KeyboardFocusChangedEventHandler PreviewGotKeyboardFocus;
+        public event KeyEventHandler PreviewKeyDown;
+        public event KeyEventHandler PreviewKeyUp;
+        public event KeyboardFocusChangedEventHandler PreviewLostKeyboardFocus;
+        public event MouseButtonEventHandler PreviewMouseDown;
+        public event MouseButtonEventHandler PreviewMouseLeftButtonDown;
+        public event MouseButtonEventHandler PreviewMouseLeftButtonUp;
+        public event MouseEventHandler PreviewMouseMove;
+        public event MouseButtonEventHandler PreviewMouseRightButtonDown;
+        public event MouseButtonEventHandler PreviewMouseRightButtonUp;
+        public event MouseButtonEventHandler PreviewMouseUp;
+        public event MouseWheelEventHandler PreviewMouseWheel;
+        public event QueryContinueDragEventHandler PreviewQueryContinueDrag;
+        public event StylusButtonEventHandler PreviewStylusButtonDown;
+        public event StylusButtonEventHandler PreviewStylusButtonUp;
+        public event StylusDownEventHandler PreviewStylusDown;
+        public event StylusEventHandler PreviewStylusInAirMove;
+        public event StylusEventHandler PreviewStylusInRange;
+        public event StylusEventHandler PreviewStylusMove;
+        public event StylusEventHandler PreviewStylusOutOfRange;
+        public event StylusSystemGestureEventHandler PreviewStylusSystemGesture;
+        public event StylusEventHandler PreviewStylusUp;
+        public event TextCompositionEventHandler PreviewTextInput;
+        public event EventHandler<TouchEventArgs> PreviewTouchDown;
+        public event EventHandler<TouchEventArgs> PreviewTouchMove;
+        public event EventHandler<TouchEventArgs> PreviewTouchUp;
+        public event QueryContinueDragEventHandler QueryContinueDrag;
+        public event QueryCursorEventHandler QueryCursor;
+        public event StylusButtonEventHandler StylusButtonDown;
+        public event StylusButtonEventHandler StylusButtonUp;
+        public event StylusDownEventHandler StylusDown;
+        public event StylusEventHandler StylusEnter;
+        public event StylusEventHandler StylusInAirMove;
+        public event StylusEventHandler StylusInRange;
+        public event StylusEventHandler StylusLeave;
+        public event StylusEventHandler StylusMove;
+        public event StylusEventHandler StylusOutOfRange;
+        public event StylusSystemGestureEventHandler StylusSystemGesture;
+        public event StylusEventHandler StylusUp;
+        public event TextCompositionEventHandler TextInput;
+        public event EventHandler<TouchEventArgs> TouchDown;
+        public event EventHandler<TouchEventArgs> TouchEnter;
+        public event EventHandler<TouchEventArgs> TouchLeave;
+        public event EventHandler<TouchEventArgs> TouchMove;
+        public event EventHandler<TouchEventArgs> TouchUp;
+        public void AddHandler(RoutedEvent routedEvent, Delegate handler);
+        public void AddHandler(RoutedEvent routedEvent, Delegate handler, bool handledEventsToo);
+        public void AddToEventRoute(EventRoute route, RoutedEventArgs e);
+        public bool CaptureMouse();
+        public bool CaptureStylus();
+        public bool CaptureTouch(TouchDevice touchDevice);
+        public bool Focus();
+        protected internal DependencyObject GetUIParentCore();
+        public void InvalidateModel();
+        public virtual bool MoveFocus(TraversalRequest request);
+        protected virtual void OnAccessKey(AccessKeyEventArgs e);
+        protected virtual AutomationPeer OnCreateAutomationPeer();
+        protected internal virtual void OnDragEnter(DragEventArgs e);
+        protected internal virtual void OnDragLeave(DragEventArgs e);
+        protected internal virtual void OnDragOver(DragEventArgs e);
+        protected internal virtual void OnDrop(DragEventArgs e);
+        protected internal virtual void OnGiveFeedback(GiveFeedbackEventArgs e);
+        protected virtual void OnGotFocus(RoutedEventArgs e);
+        protected internal virtual void OnGotKeyboardFocus(KeyboardFocusChangedEventArgs e);
+        protected internal virtual void OnGotMouseCapture(MouseEventArgs e);
+        protected internal virtual void OnGotStylusCapture(StylusEventArgs e);
+        protected internal virtual void OnGotTouchCapture(TouchEventArgs e);
+        protected virtual void OnIsKeyboardFocusedChanged(DependencyPropertyChangedEventArgs e);
+        protected virtual void OnIsKeyboardFocusWithinChanged(DependencyPropertyChangedEventArgs e);
+        protected virtual void OnIsMouseCapturedChanged(DependencyPropertyChangedEventArgs e);
+        protected virtual void OnIsMouseCaptureWithinChanged(DependencyPropertyChangedEventArgs e);
+        protected virtual void OnIsMouseDirectlyOverChanged(DependencyPropertyChangedEventArgs e);
+        protected virtual void OnIsStylusCapturedChanged(DependencyPropertyChangedEventArgs e);
+        protected virtual void OnIsStylusCaptureWithinChanged(DependencyPropertyChangedEventArgs e);
+        protected virtual void OnIsStylusDirectlyOverChanged(DependencyPropertyChangedEventArgs e);
+        protected internal virtual void OnKeyDown(KeyEventArgs e);
+        protected internal virtual void OnKeyUp(KeyEventArgs e);
+        protected virtual void OnLostFocus(RoutedEventArgs e);
+        protected internal virtual void OnLostKeyboardFocus(KeyboardFocusChangedEventArgs e);
+        protected internal virtual void OnLostMouseCapture(MouseEventArgs e);
+        protected internal virtual void OnLostStylusCapture(StylusEventArgs e);
+        protected internal virtual void OnLostTouchCapture(TouchEventArgs e);
+        protected internal virtual void OnMouseDown(MouseButtonEventArgs e);
+        protected internal virtual void OnMouseEnter(MouseEventArgs e);
+        protected internal virtual void OnMouseLeave(MouseEventArgs e);
+        protected internal virtual void OnMouseLeftButtonDown(MouseButtonEventArgs e);
+        protected internal virtual void OnMouseLeftButtonUp(MouseButtonEventArgs e);
+        protected internal virtual void OnMouseMove(MouseEventArgs e);
+        protected internal virtual void OnMouseRightButtonDown(MouseButtonEventArgs e);
+        protected internal virtual void OnMouseRightButtonUp(MouseButtonEventArgs e);
+        protected internal virtual void OnMouseUp(MouseButtonEventArgs e);
+        protected internal virtual void OnMouseWheel(MouseWheelEventArgs e);
+        protected internal virtual void OnPreviewDragEnter(DragEventArgs e);
+        protected internal virtual void OnPreviewDragLeave(DragEventArgs e);
+        protected internal virtual void OnPreviewDragOver(DragEventArgs e);
+        protected internal virtual void OnPreviewDrop(DragEventArgs e);
+        protected internal virtual void OnPreviewGiveFeedback(GiveFeedbackEventArgs e);
+        protected internal virtual void OnPreviewGotKeyboardFocus(KeyboardFocusChangedEventArgs e);
+        protected internal virtual void OnPreviewKeyDown(KeyEventArgs e);
+        protected internal virtual void OnPreviewKeyUp(KeyEventArgs e);
+        protected internal virtual void OnPreviewLostKeyboardFocus(KeyboardFocusChangedEventArgs e);
+        protected internal virtual void OnPreviewMouseDown(MouseButtonEventArgs e);
+        protected internal virtual void OnPreviewMouseLeftButtonDown(MouseButtonEventArgs e);
+        protected internal virtual void OnPreviewMouseLeftButtonUp(MouseButtonEventArgs e);
+        protected internal virtual void OnPreviewMouseMove(MouseEventArgs e);
+        protected internal virtual void OnPreviewMouseRightButtonDown(MouseButtonEventArgs e);
+        protected internal virtual void OnPreviewMouseRightButtonUp(MouseButtonEventArgs e);
+        protected internal virtual void OnPreviewMouseUp(MouseButtonEventArgs e);
+        protected internal virtual void OnPreviewMouseWheel(MouseWheelEventArgs e);
+        protected internal virtual void OnPreviewQueryContinueDrag(QueryContinueDragEventArgs e);
+        protected internal virtual void OnPreviewStylusButtonDown(StylusButtonEventArgs e);
+        protected internal virtual void OnPreviewStylusButtonUp(StylusButtonEventArgs e);
+        protected internal virtual void OnPreviewStylusDown(StylusDownEventArgs e);
+        protected internal virtual void OnPreviewStylusInAirMove(StylusEventArgs e);
+        protected internal virtual void OnPreviewStylusInRange(StylusEventArgs e);
+        protected internal virtual void OnPreviewStylusMove(StylusEventArgs e);
+        protected internal virtual void OnPreviewStylusOutOfRange(StylusEventArgs e);
+        protected internal virtual void OnPreviewStylusSystemGesture(StylusSystemGestureEventArgs e);
+        protected internal virtual void OnPreviewStylusUp(StylusEventArgs e);
+        protected internal virtual void OnPreviewTextInput(TextCompositionEventArgs e);
+        protected internal virtual void OnPreviewTouchDown(TouchEventArgs e);
+        protected internal virtual void OnPreviewTouchMove(TouchEventArgs e);
+        protected internal virtual void OnPreviewTouchUp(TouchEventArgs e);
+        protected internal virtual void OnQueryContinueDrag(QueryContinueDragEventArgs e);
+        protected internal virtual void OnQueryCursor(QueryCursorEventArgs e);
+        protected internal virtual void OnStylusButtonDown(StylusButtonEventArgs e);
+        protected internal virtual void OnStylusButtonUp(StylusButtonEventArgs e);
+        protected internal virtual void OnStylusDown(StylusDownEventArgs e);
+        protected internal virtual void OnStylusEnter(StylusEventArgs e);
+        protected internal virtual void OnStylusInAirMove(StylusEventArgs e);
+        protected internal virtual void OnStylusInRange(StylusEventArgs e);
+        protected internal virtual void OnStylusLeave(StylusEventArgs e);
+        protected internal virtual void OnStylusMove(StylusEventArgs e);
+        protected internal virtual void OnStylusOutOfRange(StylusEventArgs e);
+        protected internal virtual void OnStylusSystemGesture(StylusSystemGestureEventArgs e);
+        protected internal virtual void OnStylusUp(StylusEventArgs e);
+        protected internal virtual void OnTextInput(TextCompositionEventArgs e);
+        protected internal virtual void OnTouchDown(TouchEventArgs e);
+        protected internal virtual void OnTouchEnter(TouchEventArgs e);
+        protected internal virtual void OnTouchLeave(TouchEventArgs e);
+        protected internal virtual void OnTouchMove(TouchEventArgs e);
+        protected internal virtual void OnTouchUp(TouchEventArgs e);
+        protected virtual void OnUpdateModel();
+        protected internal override void OnVisualParentChanged(DependencyObject oldParent);
+        public virtual DependencyObject PredictFocus(FocusNavigationDirection direction);
+        public void RaiseEvent(RoutedEventArgs e);
+        public void ReleaseAllTouchCaptures();
+        public void ReleaseMouseCapture();
+        public void ReleaseStylusCapture();
+        public bool ReleaseTouchCapture(TouchDevice touchDevice);
+        public void RemoveHandler(RoutedEvent routedEvent, Delegate handler);
+        public bool ShouldSerializeCommandBindings();
+        public bool ShouldSerializeInputBindings();
+    }
+    public class UIPropertyMetadata : PropertyMetadata {
+        public UIPropertyMetadata();
+        public UIPropertyMetadata(object defaultValue);
+        public UIPropertyMetadata(object defaultValue, PropertyChangedCallback propertyChangedCallback);
+        public UIPropertyMetadata(object defaultValue, PropertyChangedCallback propertyChangedCallback, CoerceValueCallback coerceValueCallback);
+        public UIPropertyMetadata(object defaultValue, PropertyChangedCallback propertyChangedCallback, CoerceValueCallback coerceValueCallback, bool isAnimationProhibited);
+        public UIPropertyMetadata(PropertyChangedCallback propertyChangedCallback);
+        public bool IsAnimationProhibited { get; set; }
+    }
+    public delegate bool ValidateValueCallback(object value);
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct ValueSource {
+        public BaseValueSource BaseValueSource { get; }
+        public bool IsAnimated { get; }
+        public bool IsCoerced { get; }
+        public bool IsCurrent { get; }
+        public bool IsExpression { get; }
+        public override bool Equals(object o);
+        public override int GetHashCode();
+        public static bool operator ==(ValueSource vs1, ValueSource vs2);
+        public static bool operator !=(ValueSource vs1, ValueSource vs2);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct Vector : IFormattable {
+        public Vector(double x, double y);
+        public double Length { get; }
+        public double LengthSquared { get; }
+        public double X { get; set; }
+        public double Y { get; set; }
+        public static Point Add(Vector vector, Point point);
+        public static Vector Add(Vector vector1, Vector vector2);
+        public static double AngleBetween(Vector vector1, Vector vector2);
+        public static double CrossProduct(Vector vector1, Vector vector2);
+        public static double Determinant(Vector vector1, Vector vector2);
+        public static Vector Divide(Vector vector, double scalar);
+        public override bool Equals(object o);
+        public bool Equals(Vector value);
+        public static bool Equals(Vector vector1, Vector vector2);
+        public override int GetHashCode();
+        public static Vector Multiply(double scalar, Vector vector);
+        public static Vector Multiply(Vector vector, double scalar);
+        public static Vector Multiply(Vector vector, Matrix matrix);
+        public static double Multiply(Vector vector1, Vector vector2);
+        public void Negate();
+        public void Normalize();
+        public static Point operator +(Vector vector, Point point);
+        public static Vector operator +(Vector vector1, Vector vector2);
+        public static Vector operator /(Vector vector, double scalar);
+        public static bool operator ==(Vector vector1, Vector vector2);
+        public static explicit operator Size (Vector vector);
+        public static explicit operator Point (Vector vector);
+        public static bool operator !=(Vector vector1, Vector vector2);
+        public static Vector operator *(double scalar, Vector vector);
+        public static Vector operator *(Vector vector, double scalar);
+        public static Vector operator *(Vector vector, Matrix matrix);
+        public static double operator *(Vector vector1, Vector vector2);
+        public static Vector operator -(Vector vector1, Vector vector2);
+        public static Vector operator -(Vector vector);
+        public static Vector Parse(string source);
+        public static Vector Subtract(Vector vector1, Vector vector2);
+        string System.IFormattable.ToString(string format, IFormatProvider provider);
+        public override string ToString();
+        public string ToString(IFormatProvider provider);
+    }
+    public sealed class VectorConverter : TypeConverter {
+        public VectorConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public enum VerticalAlignment {
+        Bottom = 2,
+        Center = 1,
+        Stretch = 3,
+        Top = 0,
+    }
+    public enum Visibility : byte {
+        Collapsed = (byte)2,
+        Hidden = (byte)1,
+        Visible = (byte)0,
+    }
+    public class VisualState : DependencyObject {
+        public VisualState();
+        public string Name { get; set; }
+        public Storyboard Storyboard { get; set; }
+    }
+    public sealed class VisualStateChangedEventArgs : EventArgs {
+        public FrameworkElement Control { get; }
+        public VisualState NewState { get; }
+        public VisualState OldState { get; }
+        public FrameworkElement StateGroupsRoot { get; }
+    }
+    public class VisualStateGroup : DependencyObject {
+        public VisualStateGroup();
+        public VisualState CurrentState { get; internal set; }
+        public string Name { get; set; }
+        public IList States { get; }
+        public IList Transitions { get; }
+        public event EventHandler<VisualStateChangedEventArgs> CurrentStateChanged;
+        public event EventHandler<VisualStateChangedEventArgs> CurrentStateChanging;
+    }
+    public class VisualStateManager : DependencyObject {
+        public static readonly DependencyProperty CustomVisualStateManagerProperty;
+        public static readonly DependencyProperty VisualStateGroupsProperty;
+        public VisualStateManager();
+        public static VisualStateManager GetCustomVisualStateManager(FrameworkElement obj);
+        public static IList GetVisualStateGroups(FrameworkElement obj);
+        public static bool GoToElementState(FrameworkElement stateGroupsRoot, string stateName, bool useTransitions);
+        public static bool GoToState(FrameworkElement control, string stateName, bool useTransitions);
+        protected virtual bool GoToStateCore(FrameworkElement control, FrameworkElement stateGroupsRoot, string stateName, VisualStateGroup group, VisualState state, bool useTransitions);
+        protected void RaiseCurrentStateChanged(VisualStateGroup stateGroup, VisualState oldState, VisualState newState, FrameworkElement control, FrameworkElement stateGroupsRoot);
+        protected void RaiseCurrentStateChanging(VisualStateGroup stateGroup, VisualState oldState, VisualState newState, FrameworkElement control, FrameworkElement stateGroupsRoot);
+        public static void SetCustomVisualStateManager(FrameworkElement obj, VisualStateManager value);
+    }
+    public class VisualTransition : DependencyObject {
+        public VisualTransition();
+        public string From { get; set; }
+        public Duration GeneratedDuration { get; set; }
+        public IEasingFunction GeneratedEasingFunction { get; set; }
+        public Storyboard Storyboard { get; set; }
+        public string To { get; set; }
+    }
+    public abstract class WeakEventManager : DispatcherObject {
+        protected WeakEventManager();
+        protected IDisposable ReadLock { get; }
+        protected object this[object source] { get; set; }
+        protected IDisposable WriteLock { get; }
+        protected void DeliverEvent(object sender, EventArgs args);
+        protected void DeliverEventToList(object sender, EventArgs args, WeakEventManager.ListenerList list);
+        protected static WeakEventManager GetCurrentManager(Type managerType);
+        protected virtual WeakEventManager.ListenerList NewListenerList();
+        protected void ProtectedAddHandler(object source, Delegate handler);
+        protected void ProtectedAddListener(object source, IWeakEventListener listener);
+        protected void ProtectedRemoveHandler(object source, Delegate handler);
+        protected void ProtectedRemoveListener(object source, IWeakEventListener listener);
+        protected virtual bool Purge(object source, object data, bool purgeAll);
+        protected void Remove(object source);
+        protected void ScheduleCleanup();
+        protected static void SetCurrentManager(Type managerType, WeakEventManager manager);
+        protected abstract void StartListening(object source);
+        protected abstract void StopListening(object source);
+        protected class ListenerList {
+            public ListenerList();
+            public ListenerList(int capacity);
+            public int Count { get; }
+            public static WeakEventManager.ListenerList Empty { get; }
+            public bool IsEmpty { get; }
+            public IWeakEventListener this[int index] { get; }
+            public void Add(IWeakEventListener listener);
+            public void AddHandler(Delegate handler);
+            public bool BeginUse();
+            public virtual WeakEventManager.ListenerList Clone();
+            protected void CopyTo(WeakEventManager.ListenerList newList);
+            public virtual bool DeliverEvent(object sender, EventArgs args, Type managerType);
+            public void EndUse();
+            public static bool PrepareForWriting(ref WeakEventManager.ListenerList list);
+            public bool Purge();
+            public void Remove(IWeakEventListener listener);
+            public void RemoveHandler(Delegate handler);
+        }
+        protected class ListenerList<TEventArgs> : WeakEventManager.ListenerList where TEventArgs : EventArgs {
+            public ListenerList();
+            public ListenerList(int capacity);
+            public override WeakEventManager.ListenerList Clone();
+            public override bool DeliverEvent(object sender, EventArgs e, Type managerType);
+        }
+    }
+    public class WeakEventManager<TEventSource, TEventArgs> : WeakEventManager where TEventArgs : EventArgs {
+        public static void AddHandler(TEventSource source, string eventName, EventHandler<TEventArgs> handler);
+        protected override WeakEventManager.ListenerList NewListenerList();
+        public static void RemoveHandler(TEventSource source, string eventName, EventHandler<TEventArgs> handler);
+        protected override void StartListening(object source);
+        protected override void StopListening(object source);
+    }
+    public class Window : ContentControl, IWindowService {
+        public static readonly DependencyProperty AllowsTransparencyProperty;
+        public static readonly DependencyProperty IconProperty;
+        public static readonly DependencyProperty IsActiveProperty;
+        public static readonly DependencyProperty LeftProperty;
+        public static readonly DependencyProperty ResizeModeProperty;
+        public static readonly DependencyProperty ShowActivatedProperty;
+        public static readonly DependencyProperty ShowInTaskbarProperty;
+        public static readonly DependencyProperty SizeToContentProperty;
+        public static readonly DependencyProperty TaskbarItemInfoProperty;
+        public static readonly DependencyProperty TitleProperty;
+        public static readonly DependencyProperty TopmostProperty;
+        public static readonly DependencyProperty TopProperty;
+        public static readonly DependencyProperty WindowStateProperty;
+        public static readonly DependencyProperty WindowStyleProperty;
+        public Window();
+        public bool AllowsTransparency { get; set; }
+        public Nullable<bool> DialogResult { get; set; }
+        public ImageSource Icon { get; set; }
+        public bool IsActive { get; }
+        public double Left { get; set; }
+        protected internal override IEnumerator LogicalChildren { get; }
+        public WindowCollection OwnedWindows { get; }
+        public Window Owner { get; set; }
+        public ResizeMode ResizeMode { get; set; }
+        public Rect RestoreBounds { get; }
+        public bool ShowActivated { get; set; }
+        public bool ShowInTaskbar { get; set; }
+        public SizeToContent SizeToContent { get; set; }
+        public TaskbarItemInfo TaskbarItemInfo { get; set; }
+        public string Title { get; set; }
+        public double Top { get; set; }
+        public bool Topmost { get; set; }
+        public WindowStartupLocation WindowStartupLocation { get; set; }
+        public WindowState WindowState { get; set; }
+        public WindowStyle WindowStyle { get; set; }
+        public event EventHandler Activated;
+        public event EventHandler Closed;
+        public event CancelEventHandler Closing;
+        public event EventHandler ContentRendered;
+        public event EventHandler Deactivated;
+        public event EventHandler LocationChanged;
+        public event EventHandler SourceInitialized;
+        public event EventHandler StateChanged;
+        public bool Activate();
+        protected override Size ArrangeOverride(Size arrangeBounds);
+        public void Close();
+        public void DragMove();
+        public static Window GetWindow(DependencyObject dependencyObject);
+        public void Hide();
+        protected override Size MeasureOverride(Size availableSize);
+        protected virtual void OnActivated(EventArgs e);
+        protected virtual void OnClosed(EventArgs e);
+        protected virtual void OnClosing(CancelEventArgs e);
+        protected override void OnContentChanged(object oldContent, object newContent);
+        protected virtual void OnContentRendered(EventArgs e);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected virtual void OnDeactivated(EventArgs e);
+        protected virtual void OnLocationChanged(EventArgs e);
+        protected override void OnManipulationBoundaryFeedback(ManipulationBoundaryFeedbackEventArgs e);
+        protected virtual void OnSourceInitialized(EventArgs e);
+        protected virtual void OnStateChanged(EventArgs e);
+        protected internal sealed override void OnVisualParentChanged(DependencyObject oldParent);
+        public void Show();
+        public Nullable<bool> ShowDialog();
+    }
+    public sealed class WindowCollection : ICollection, IEnumerable {
+        public WindowCollection();
+        public int Count { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        public Window this[int index] { get; }
+        public void CopyTo(Window[] array, int index);
+        public IEnumerator GetEnumerator();
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+    }
+    public enum WindowStartupLocation {
+        CenterOwner = 2,
+        CenterScreen = 1,
+        Manual = 0,
+    }
+    public enum WindowState {
+        Maximized = 2,
+        Minimized = 1,
+        Normal = 0,
+    }
+    public enum WindowStyle {
+        None = 0,
+        SingleBorderWindow = 1,
+        ThreeDBorderWindow = 2,
+        ToolWindow = 3,
+    }
+    public enum WrapDirection {
+        Both = 3,
+        Left = 1,
+        None = 0,
+        Right = 2,
+    }
+}
```

