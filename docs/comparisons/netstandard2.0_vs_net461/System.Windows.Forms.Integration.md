# System.Windows.Forms.Integration

``` diff
+namespace System.Windows.Forms.Integration {
+    public class ChildChangedEventArgs : EventArgs {
+        public ChildChangedEventArgs(object previousChild);
+        public object PreviousChild { get; }
+    }
+    public class ElementHost : Control {
+        public ElementHost();
+        public override bool AutoSize { get; set; }
+        public bool BackColorTransparent { get; set; }
+        protected override bool CanEnableIme { get; }
+        public UIElement Child { get; set; }
+        protected override Size DefaultSize { get; }
+        public override bool Focused { get; }
+        public Panel HostContainer { get; }
+        protected override ImeMode ImeModeBase { get; set; }
+        public PropertyMap PropertyMap { get; }
+        public new event EventHandler BindingContextChanged;
+        public event EventHandler<ChildChangedEventArgs> ChildChanged;
+        public new event EventHandler Click;
+        public new event EventHandler ClientSizeChanged;
+        public new event ControlEventHandler ControlAdded;
+        public new event ControlEventHandler ControlRemoved;
+        public new event EventHandler CursorChanged;
+        public new event EventHandler DoubleClick;
+        public new event DragEventHandler DragDrop;
+        public new event DragEventHandler DragEnter;
+        public new event EventHandler DragLeave;
+        public new event DragEventHandler DragOver;
+        public new event EventHandler Enter;
+        public new event EventHandler FontChanged;
+        public new event EventHandler ForeColorChanged;
+        public new event GiveFeedbackEventHandler GiveFeedback;
+        public new event EventHandler GotFocus;
+        public new event InvalidateEventHandler Invalidated;
+        public new event KeyEventHandler KeyDown;
+        public new event KeyPressEventHandler KeyPress;
+        public new event KeyEventHandler KeyUp;
+        public new event LayoutEventHandler Layout;
+        public new event EventHandler Leave;
+        public new event EventHandler LostFocus;
+        public new event EventHandler MouseCaptureChanged;
+        public new event MouseEventHandler MouseClick;
+        public new event MouseEventHandler MouseDoubleClick;
+        public new event MouseEventHandler MouseDown;
+        public new event EventHandler MouseEnter;
+        public new event EventHandler MouseHover;
+        public new event EventHandler MouseLeave;
+        public new event MouseEventHandler MouseMove;
+        public new event MouseEventHandler MouseUp;
+        public new event MouseEventHandler MouseWheel;
+        public new event EventHandler PaddingChanged;
+        public new event PaintEventHandler Paint;
+        public new event PreviewKeyDownEventHandler PreviewKeyDown;
+        public new event QueryContinueDragEventHandler QueryContinueDrag;
+        public new event EventHandler Resize;
+        public new event EventHandler RightToLeftChanged;
+        public new event EventHandler SizeChanged;
+        public new event EventHandler TextChanged;
+        protected override void Dispose(bool disposing);
+        public static void EnableModelessKeyboardInterop(Window window);
+        public override Size GetPreferredSize(Size proposedSize);
+        protected override bool IsInputChar(char charCode);
+        protected override void OnEnabledChanged(EventArgs e);
+        protected override void OnGotFocus(EventArgs e);
+        protected override void OnHandleCreated(EventArgs e);
+        protected override void OnLeave(EventArgs e);
+        protected override void OnPaint(PaintEventArgs e);
+        protected override void OnPaintBackground(PaintEventArgs pevent);
+        protected override void OnPrint(PaintEventArgs e);
+        public virtual void OnPropertyChanged(string propertyName, object value);
+        protected override void OnVisibleChanged(EventArgs e);
+        protected override bool ProcessCmdKey(ref Message msg, Keys keyData);
+        protected override bool ProcessMnemonic(char charCode);
+        protected override void ScaleCore(float dx, float dy);
+        protected override void Select(bool directed, bool forward);
+        protected override void WndProc(ref Message m);
+    }
+    public class IntegrationExceptionEventArgs : EventArgs {
+        public IntegrationExceptionEventArgs(bool throwException, Exception exception);
+        public Exception Exception { get; }
+        public bool ThrowException { get; set; }
+    }
+    public class LayoutExceptionEventArgs : IntegrationExceptionEventArgs {
+        public LayoutExceptionEventArgs(Exception exception);
+    }
+    public class PropertyMap {
+        public PropertyMap();
+        public PropertyMap(object source);
+        protected Dictionary<string, PropertyTranslator> DefaultTranslators { get; }
+        public ICollection Keys { get; }
+        protected object SourceObject { get; }
+        public PropertyTranslator this[string propertyName] { get; set; }
+        public ICollection Values { get; }
+        public event EventHandler<PropertyMappingExceptionEventArgs> PropertyMappingError;
+        public void Add(string propertyName, PropertyTranslator translator);
+        public void Apply(string propertyName);
+        public void ApplyAll();
+        public void Clear();
+        public bool Contains(string propertyName);
+        public void Remove(string propertyName);
+        public void Reset(string propertyName);
+        public void ResetAll();
+    }
+    public class PropertyMappingExceptionEventArgs : IntegrationExceptionEventArgs {
+        public PropertyMappingExceptionEventArgs(Exception exception, string propertyName, object propertyValue);
+        public string PropertyName { get; }
+        public object PropertyValue { get; }
+    }
+    public delegate void PropertyTranslator(object host, string propertyName, object value);
+    public class WindowsFormsHost : HwndHost, IKeyboardInputSink {
+        public static readonly DependencyProperty BackgroundProperty;
+        public static readonly DependencyProperty FontFamilyProperty;
+        public static readonly DependencyProperty FontSizeProperty;
+        public static readonly DependencyProperty FontStyleProperty;
+        public static readonly DependencyProperty FontWeightProperty;
+        public static readonly DependencyProperty ForegroundProperty;
+        public static readonly DependencyProperty PaddingProperty;
+        public static readonly DependencyProperty TabIndexProperty;
+        public WindowsFormsHost();
+        public Brush Background { get; set; }
+        public Control Child { get; set; }
+        public FontFamily FontFamily { get; set; }
+        public double FontSize { get; set; }
+        public FontStyle FontStyle { get; set; }
+        public FontWeight FontWeight { get; set; }
+        public Brush Foreground { get; set; }
+        public Thickness Padding { get; set; }
+        public PropertyMap PropertyMap { get; }
+        public int TabIndex { get; set; }
+        public event EventHandler<ChildChangedEventArgs> ChildChanged;
+        public event EventHandler<LayoutExceptionEventArgs> LayoutError;
+        protected override Size ArrangeOverride(Size finalSize);
+        protected override HandleRef BuildWindowCore(HandleRef hwndParent);
+        protected override void DestroyWindowCore(HandleRef hwnd);
+        protected override void Dispose(bool disposing);
+        public static void EnableWindowsFormsInterop();
+        protected override Size MeasureOverride(Size constraint);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e);
+        protected virtual Vector ScaleChild(Vector newScale);
+        public virtual bool TabInto(TraversalRequest request);
+        protected override IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled);
+    }
+}
```

