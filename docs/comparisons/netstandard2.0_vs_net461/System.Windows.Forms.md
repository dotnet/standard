# System.Windows.Forms

``` diff
+namespace System.Windows.Forms {
+    public enum AccessibleEvents {
+        AcceleratorChange = 32786,
+        Create = 32768,
+        DefaultActionChange = 32785,
+        DescriptionChange = 32781,
+        Destroy = 32769,
+        Focus = 32773,
+        HelpChange = 32784,
+        Hide = 32771,
+        LocationChange = 32779,
+        NameChange = 32780,
+        ParentChange = 32783,
+        Reorder = 32772,
+        Selection = 32774,
+        SelectionAdd = 32775,
+        SelectionRemove = 32776,
+        SelectionWithin = 32777,
+        Show = 32770,
+        StateChange = 32778,
+        SystemAlert = 2,
+        SystemCaptureEnd = 9,
+        SystemCaptureStart = 8,
+        SystemContextHelpEnd = 13,
+        SystemContextHelpStart = 12,
+        SystemDialogEnd = 17,
+        SystemDialogStart = 16,
+        SystemDragDropEnd = 15,
+        SystemDragDropStart = 14,
+        SystemForeground = 3,
+        SystemMenuEnd = 5,
+        SystemMenuPopupEnd = 7,
+        SystemMenuPopupStart = 6,
+        SystemMenuStart = 4,
+        SystemMinimizeEnd = 23,
+        SystemMinimizeStart = 22,
+        SystemMoveSizeEnd = 11,
+        SystemMoveSizeStart = 10,
+        SystemScrollingEnd = 19,
+        SystemScrollingStart = 18,
+        SystemSound = 1,
+        SystemSwitchEnd = 21,
+        SystemSwitchStart = 20,
+        ValueChange = 32782,
+    }
+    public enum AccessibleNavigation {
+        Down = 2,
+        FirstChild = 7,
+        LastChild = 8,
+        Left = 3,
+        Next = 5,
+        Previous = 6,
+        Right = 4,
+        Up = 1,
+    }
+    public class AccessibleObject : StandardOleMarshalObject, IAccessible, IReflect {
+        public AccessibleObject();
+        int Accessibility.IAccessible.accChildCount { get; }
+        object Accessibility.IAccessible.accFocus { get; }
+        object Accessibility.IAccessible.accParent { get; }
+        object Accessibility.IAccessible.accSelection { get; }
+        public virtual Rectangle Bounds { get; }
+        public virtual string DefaultAction { get; }
+        public virtual string Description { get; }
+        public virtual string Help { get; }
+        public virtual string KeyboardShortcut { get; }
+        public virtual string Name { get; set; }
+        public virtual AccessibleObject Parent { get; }
+        public virtual AccessibleRole Role { get; }
+        public virtual AccessibleStates State { get; }
+        Type System.Reflection.IReflect.UnderlyingSystemType { get; }
+        public virtual string Value { get; set; }
+        void Accessibility.IAccessible.accDoDefaultAction(object childID);
+        object Accessibility.IAccessible.accHitTest(int xLeft, int yTop);
+        void Accessibility.IAccessible.accLocation(out int pxLeft, out int pyTop, out int pcxWidth, out int pcyHeight, object childID);
+        object Accessibility.IAccessible.accNavigate(int navDir, object childID);
+        void Accessibility.IAccessible.accSelect(int flagsSelect, object childID);
+        object Accessibility.IAccessible.get_accChild(object childID);
+        string Accessibility.IAccessible.get_accDefaultAction(object childID);
+        string Accessibility.IAccessible.get_accDescription(object childID);
+        string Accessibility.IAccessible.get_accHelp(object childID);
+        int Accessibility.IAccessible.get_accHelpTopic(out string pszHelpFile, object childID);
+        string Accessibility.IAccessible.get_accKeyboardShortcut(object childID);
+        string Accessibility.IAccessible.get_accName(object childID);
+        object Accessibility.IAccessible.get_accRole(object childID);
+        object Accessibility.IAccessible.get_accState(object childID);
+        string Accessibility.IAccessible.get_accValue(object childID);
+        void Accessibility.IAccessible.set_accName(object childID, string newName);
+        void Accessibility.IAccessible.set_accValue(object childID, string newValue);
+        public virtual void DoDefaultAction();
+        public virtual AccessibleObject GetChild(int index);
+        public virtual int GetChildCount();
+        public virtual AccessibleObject GetFocused();
+        public virtual int GetHelpTopic(out string fileName);
+        public virtual AccessibleObject GetSelected();
+        public virtual AccessibleObject HitTest(int x, int y);
+        public virtual AccessibleObject Navigate(AccessibleNavigation navdir);
+        public virtual void Select(AccessibleSelection flags);
+        FieldInfo System.Reflection.IReflect.GetField(string name, BindingFlags bindingAttr);
+        FieldInfo[] System.Reflection.IReflect.GetFields(BindingFlags bindingAttr);
+        MemberInfo[] System.Reflection.IReflect.GetMember(string name, BindingFlags bindingAttr);
+        MemberInfo[] System.Reflection.IReflect.GetMembers(BindingFlags bindingAttr);
+        MethodInfo System.Reflection.IReflect.GetMethod(string name, BindingFlags bindingAttr);
+        MethodInfo System.Reflection.IReflect.GetMethod(string name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers);
+        MethodInfo[] System.Reflection.IReflect.GetMethods(BindingFlags bindingAttr);
+        PropertyInfo[] System.Reflection.IReflect.GetProperties(BindingFlags bindingAttr);
+        PropertyInfo System.Reflection.IReflect.GetProperty(string name, BindingFlags bindingAttr);
+        PropertyInfo System.Reflection.IReflect.GetProperty(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers);
+        object System.Reflection.IReflect.InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters);
+        protected void UseStdAccessibleObjects(IntPtr handle);
+        protected void UseStdAccessibleObjects(IntPtr handle, int objid);
+    }
+    public enum AccessibleRole {
+        Alert = 8,
+        Animation = 54,
+        Application = 14,
+        Border = 19,
+        ButtonDropDown = 56,
+        ButtonDropDownGrid = 58,
+        ButtonMenu = 57,
+        Caret = 7,
+        Cell = 29,
+        Character = 32,
+        Chart = 17,
+        CheckButton = 44,
+        Client = 10,
+        Clock = 61,
+        Column = 27,
+        ColumnHeader = 25,
+        ComboBox = 46,
+        Cursor = 6,
+        Default = -1,
+        Diagram = 53,
+        Dial = 49,
+        Dialog = 18,
+        Document = 15,
+        DropList = 47,
+        Equation = 55,
+        Graphic = 40,
+        Grip = 4,
+        Grouping = 20,
+        HelpBalloon = 31,
+        HotkeyField = 50,
+        Indicator = 39,
+        IpAddress = 63,
+        Link = 30,
+        List = 33,
+        ListItem = 34,
+        MenuBar = 2,
+        MenuItem = 12,
+        MenuPopup = 11,
+        None = 0,
+        Outline = 35,
+        OutlineButton = 64,
+        OutlineItem = 36,
+        PageTab = 37,
+        PageTabList = 60,
+        Pane = 16,
+        ProgressBar = 48,
+        PropertyPage = 38,
+        PushButton = 43,
+        RadioButton = 45,
+        Row = 28,
+        RowHeader = 26,
+        ScrollBar = 3,
+        Separator = 21,
+        Slider = 51,
+        Sound = 5,
+        SpinButton = 52,
+        SplitButton = 62,
+        StaticText = 41,
+        StatusBar = 23,
+        Table = 24,
+        Text = 42,
+        TitleBar = 1,
+        ToolBar = 22,
+        ToolTip = 13,
+        WhiteSpace = 59,
+        Window = 9,
+    }
+    public enum AccessibleSelection {
+        AddSelection = 8,
+        ExtendSelection = 4,
+        None = 0,
+        RemoveSelection = 16,
+        TakeFocus = 1,
+        TakeSelection = 2,
+    }
+    public enum AccessibleStates {
+        AlertHigh = 268435456,
+        AlertLow = 67108864,
+        AlertMedium = 134217728,
+        Animated = 16384,
+        Busy = 2048,
+        Checked = 16,
+        Collapsed = 1024,
+        Default = 256,
+        Expanded = 512,
+        ExtSelectable = 33554432,
+        Floating = 4096,
+        Focusable = 1048576,
+        Focused = 4,
+        HasPopup = 1073741824,
+        HotTracked = 128,
+        Indeterminate = 32,
+        Invisible = 32768,
+        Linked = 4194304,
+        Marqueed = 8192,
+        Mixed = 32,
+        Moveable = 262144,
+        MultiSelectable = 16777216,
+        None = 0,
+        Offscreen = 65536,
+        Pressed = 8,
+        Protected = 536870912,
+        ReadOnly = 64,
+        Selectable = 2097152,
+        Selected = 2,
+        SelfVoicing = 524288,
+        Sizeable = 131072,
+        Traversed = 8388608,
+        Unavailable = 1,
+        Valid = 1073741823,
+    }
+    public sealed class AmbientProperties {
+        public AmbientProperties();
+        public Color BackColor { get; set; }
+        public Cursor Cursor { get; set; }
+        public Font Font { get; set; }
+        public Color ForeColor { get; set; }
+    }
+    public enum AnchorStyles {
+        Bottom = 2,
+        Left = 4,
+        None = 0,
+        Right = 8,
+        Top = 1,
+    }
+    public enum Appearance {
+        Button = 1,
+        Normal = 0,
+    }
+    public sealed class Application {
+        public static bool AllowQuit { get; }
+        public static string CommonAppDataPath { get; }
+        public static RegistryKey CommonAppDataRegistry { get; }
+        public static string CompanyName { get; }
+        public static CultureInfo CurrentCulture { get; set; }
+        public static InputLanguage CurrentInputLanguage { get; set; }
+        public static string ExecutablePath { get; }
+        public static string LocalUserAppDataPath { get; }
+        public static bool MessageLoop { get; }
+        public static FormCollection OpenForms { get; }
+        public static string ProductName { get; }
+        public static string ProductVersion { get; }
+        public static bool RenderWithVisualStyles { get; }
+        public static string SafeTopLevelCaptionFormat { get; set; }
+        public static string StartupPath { get; }
+        public static string UserAppDataPath { get; }
+        public static RegistryKey UserAppDataRegistry { get; }
+        public static bool UseWaitCursor { get; set; }
+        public static VisualStyleState VisualStyleState { get; set; }
+        public static event EventHandler ApplicationExit;
+        public static event EventHandler EnterThreadModal;
+        public static event EventHandler Idle;
+        public static event EventHandler LeaveThreadModal;
+        public static event ThreadExceptionEventHandler ThreadException;
+        public static event EventHandler ThreadExit;
+        public static void AddMessageFilter(IMessageFilter value);
+        public static void DoEvents();
+        public static void EnableVisualStyles();
+        public static void Exit();
+        public static void Exit(CancelEventArgs e);
+        public static void ExitThread();
+        public static bool FilterMessage(ref Message message);
+        public static ApartmentState OleRequired();
+        public static void OnThreadException(Exception t);
+        public static void RaiseIdle(EventArgs e);
+        public static void RegisterMessageLoop(Application.MessageLoopCallback callback);
+        public static void RemoveMessageFilter(IMessageFilter value);
+        public static void Restart();
+        public static void Run();
+        public static void Run(ApplicationContext context);
+        public static void Run(Form mainForm);
+        public static void SetCompatibleTextRenderingDefault(bool defaultValue);
+        public static bool SetSuspendState(PowerState state, bool force, bool disableWakeEvent);
+        public static void SetUnhandledExceptionMode(UnhandledExceptionMode mode);
+        public static void SetUnhandledExceptionMode(UnhandledExceptionMode mode, bool threadScope);
+        public static void UnregisterMessageLoop();
+        public delegate bool MessageLoopCallback();
+    }
+    public class ApplicationContext : IDisposable {
+        public ApplicationContext();
+        public ApplicationContext(Form mainForm);
+        public Form MainForm { get; set; }
+        public object Tag { get; set; }
+        public event EventHandler ThreadExit;
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        public void ExitThread();
+        protected virtual void ExitThreadCore();
+        ~ApplicationContext();
+        protected virtual void OnMainFormClosed(object sender, EventArgs e);
+    }
+    public enum ArrangeDirection {
+        Down = 4,
+        Left = 0,
+        Right = 0,
+        Up = 4,
+    }
+    public enum ArrangeStartingPosition {
+        BottomLeft = 0,
+        BottomRight = 1,
+        Hide = 8,
+        TopLeft = 2,
+        TopRight = 3,
+    }
+    public enum ArrowDirection {
+        Down = 17,
+        Left = 0,
+        Right = 16,
+        Up = 1,
+    }
+    public enum AutoCompleteMode {
+        Append = 2,
+        None = 0,
+        Suggest = 1,
+        SuggestAppend = 3,
+    }
+    public enum AutoCompleteSource {
+        AllSystemSources = 7,
+        AllUrl = 6,
+        CustomSource = 64,
+        FileSystem = 1,
+        FileSystemDirectories = 32,
+        HistoryList = 2,
+        ListItems = 256,
+        None = 128,
+        RecentlyUsedList = 4,
+    }
+    public class AutoCompleteStringCollection : ICollection, IEnumerable, IList {
+        public AutoCompleteStringCollection();
+        public int Count { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public string this[int index] { get; set; }
+        public event CollectionChangeEventHandler CollectionChanged;
+        public int Add(string value);
+        public void AddRange(string[] value);
+        public void Clear();
+        public bool Contains(string value);
+        public void CopyTo(string[] array, int index);
+        public IEnumerator GetEnumerator();
+        public int IndexOf(string value);
+        public void Insert(int index, string value);
+        protected void OnCollectionChanged(CollectionChangeEventArgs e);
+        public void Remove(string value);
+        public void RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        int System.Collections.IList.Add(object value);
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+    }
+    public enum AutoScaleMode {
+        Dpi = 2,
+        Font = 1,
+        Inherit = 3,
+        None = 0,
+    }
+    public enum AutoSizeMode {
+        GrowAndShrink = 0,
+        GrowOnly = 1,
+    }
+    public enum AutoValidate {
+        Disable = 0,
+        EnableAllowFocusChange = 2,
+        EnablePreventFocusChange = 1,
+        Inherit = -1,
+    }
+    public abstract class AxHost : Control, ICustomTypeDescriptor, ISupportInitialize {
+        protected AxHost(string clsid);
+        protected AxHost(string clsid, int flags);
+        public override Color BackColor { get; set; }
+        public override Image BackgroundImage { get; set; }
+        public override ImageLayout BackgroundImageLayout { get; set; }
+        public ContainerControl ContainingControl { get; set; }
+        public override ContextMenu ContextMenu { get; set; }
+        protected override CreateParams CreateParams { get; }
+        public override Cursor Cursor { get; set; }
+        protected override Size DefaultSize { get; }
+        public bool EditMode { get; }
+        public virtual new bool Enabled { get; set; }
+        public override Font Font { get; set; }
+        public override Color ForeColor { get; set; }
+        public bool HasAboutBox { get; }
+        public new ImeMode ImeMode { get; set; }
+        public AxHost.State OcxState { get; set; }
+        public virtual new bool RightToLeft { get; set; }
+        public override ISite Site { set; }
+        public override string Text { get; set; }
+        public new event EventHandler BackColorChanged;
+        public new event EventHandler BackgroundImageChanged;
+        public new event EventHandler BackgroundImageLayoutChanged;
+        public new event EventHandler BindingContextChanged;
+        public new event UICuesEventHandler ChangeUICues;
+        public new event EventHandler Click;
+        public new event EventHandler ContextMenuChanged;
+        public new event EventHandler CursorChanged;
+        public new event EventHandler DoubleClick;
+        public new event DragEventHandler DragDrop;
+        public new event DragEventHandler DragEnter;
+        public new event EventHandler DragLeave;
+        public new event DragEventHandler DragOver;
+        public new event EventHandler EnabledChanged;
+        public new event EventHandler FontChanged;
+        public new event EventHandler ForeColorChanged;
+        public new event GiveFeedbackEventHandler GiveFeedback;
+        public new event HelpEventHandler HelpRequested;
+        public new event EventHandler ImeModeChanged;
+        public new event KeyEventHandler KeyDown;
+        public new event KeyPressEventHandler KeyPress;
+        public new event KeyEventHandler KeyUp;
+        public new event LayoutEventHandler Layout;
+        public new event EventHandler MouseClick;
+        public new event EventHandler MouseDoubleClick;
+        public new event MouseEventHandler MouseDown;
+        public new event EventHandler MouseEnter;
+        public new event EventHandler MouseHover;
+        public new event EventHandler MouseLeave;
+        public new event MouseEventHandler MouseMove;
+        public new event MouseEventHandler MouseUp;
+        public new event MouseEventHandler MouseWheel;
+        public new event PaintEventHandler Paint;
+        public new event QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
+        public new event QueryContinueDragEventHandler QueryContinueDrag;
+        public new event EventHandler RightToLeftChanged;
+        public new event EventHandler StyleChanged;
+        public new event EventHandler TextChanged;
+        protected virtual void AttachInterfaces();
+        public void BeginInit();
+        protected override void CreateHandle();
+        protected virtual object CreateInstanceCore(Guid clsid);
+        protected virtual void CreateSink();
+        protected override void DestroyHandle();
+        protected virtual void DetachSink();
+        protected override void Dispose(bool disposing);
+        public void DoVerb(int verb);
+        public new void DrawToBitmap(Bitmap bitmap, Rectangle targetBounds);
+        public void EndInit();
+        protected static Color GetColorFromOleColor(uint color);
+        protected static Font GetFontFromIFont(object font);
+        protected static Font GetFontFromIFontDisp(object font);
+        protected static object GetIFontDispFromFont(Font font);
+        protected static object GetIFontFromFont(Font font);
+        protected static object GetIPictureDispFromPicture(Image image);
+        protected static object GetIPictureFromCursor(Cursor cursor);
+        protected static object GetIPictureFromPicture(Image image);
+        protected static double GetOADateFromTime(DateTime time);
+        public object GetOcx();
+        protected static uint GetOleColorFromColor(Color color);
+        protected static Image GetPictureFromIPicture(object picture);
+        protected static Image GetPictureFromIPictureDisp(object picture);
+        protected override Rectangle GetScaledBounds(Rectangle bounds, SizeF factor, BoundsSpecified specified);
+        protected static DateTime GetTimeFromOADate(double date);
+        public bool HasPropertyPages();
+        public void InvokeEditMode();
+        protected override bool IsInputChar(char charCode);
+        public void MakeDirty();
+        protected override void OnBackColorChanged(EventArgs e);
+        protected override void OnFontChanged(EventArgs e);
+        protected override void OnForeColorChanged(EventArgs e);
+        protected override void OnHandleCreated(EventArgs e);
+        protected virtual void OnInPlaceActive();
+        protected override void OnLostFocus(EventArgs e);
+        public override bool PreProcessMessage(ref Message msg);
+        protected override bool ProcessDialogKey(Keys keyData);
+        protected internal override bool ProcessMnemonic(char charCode);
+        protected bool PropsValid();
+        protected void RaiseOnMouseDown(short button, short shift, int x, int y);
+        protected void RaiseOnMouseDown(short button, short shift, float x, float y);
+        protected void RaiseOnMouseDown(object o1, object o2, object o3, object o4);
+        protected void RaiseOnMouseMove(short button, short shift, int x, int y);
+        protected void RaiseOnMouseMove(short button, short shift, float x, float y);
+        protected void RaiseOnMouseMove(object o1, object o2, object o3, object o4);
+        protected void RaiseOnMouseUp(short button, short shift, int x, int y);
+        protected void RaiseOnMouseUp(short button, short shift, float x, float y);
+        protected void RaiseOnMouseUp(object o1, object o2, object o3, object o4);
+        protected void SetAboutBoxDelegate(AxHost.AboutBoxDelegate d);
+        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified);
+        protected override void SetVisibleCore(bool value);
+        public void ShowAboutBox();
+        public void ShowPropertyPages();
+        public void ShowPropertyPages(Control control);
+        AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes();
+        string System.ComponentModel.ICustomTypeDescriptor.GetClassName();
+        string System.ComponentModel.ICustomTypeDescriptor.GetComponentName();
+        TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter();
+        EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent();
+        PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty();
+        object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType);
+        EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents();
+        EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes);
+        PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties();
+        PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes);
+        object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd);
+        protected override void WndProc(ref Message m);
+        protected delegate void AboutBoxDelegate();
+        public enum ActiveXInvokeKind {
+            MethodInvoke = 0,
+            PropertyGet = 1,
+            PropertySet = 2,
+        }
+        public class AxComponentEditor : WindowsFormsComponentEditor {
+            public AxComponentEditor();
+            public override bool EditComponent(ITypeDescriptorContext context, object obj, IWin32Window parent);
+        }
+        public sealed class ClsidAttribute : Attribute {
+            public ClsidAttribute(string clsid);
+            public string Value { get; }
+        }
+        public class ConnectionPointCookie {
+            public ConnectionPointCookie(object source, object sink, Type eventInterface);
+            public void Disconnect();
+            ~ConnectionPointCookie();
+        }
+        public class InvalidActiveXStateException : Exception {
+            public InvalidActiveXStateException();
+            public InvalidActiveXStateException(string name, AxHost.ActiveXInvokeKind kind);
+            public override string ToString();
+        }
+        public class State : ISerializable {
+            public State(Stream ms, int storageType, bool manualUpdate, string licKey);
+            protected State(SerializationInfo info, StreamingContext context);
+            void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context);
+        }
+        public class StateConverter : TypeConverter {
+            public StateConverter();
+            public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+            public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+            public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+            public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+        }
+        public sealed class TypeLibraryTimeStampAttribute : Attribute {
+            public TypeLibraryTimeStampAttribute(string timestamp);
+            public DateTime Value { get; }
+        }
+    }
+    public class BaseCollection : MarshalByRefObject, ICollection, IEnumerable {
+        public BaseCollection();
+        public virtual int Count { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        protected virtual ArrayList List { get; }
+        public object SyncRoot { get; }
+        public void CopyTo(Array ar, int index);
+        public IEnumerator GetEnumerator();
+    }
+    public enum BatteryChargeStatus {
+        Charging = 8,
+        Critical = 4,
+        High = 1,
+        Low = 2,
+        NoSystemBattery = 128,
+        Unknown = 255,
+    }
+    public class Binding {
+        public Binding(string propertyName, object dataSource, string dataMember);
+        public Binding(string propertyName, object dataSource, string dataMember, bool formattingEnabled);
+        public Binding(string propertyName, object dataSource, string dataMember, bool formattingEnabled, DataSourceUpdateMode dataSourceUpdateMode);
+        public Binding(string propertyName, object dataSource, string dataMember, bool formattingEnabled, DataSourceUpdateMode dataSourceUpdateMode, object nullValue);
+        public Binding(string propertyName, object dataSource, string dataMember, bool formattingEnabled, DataSourceUpdateMode dataSourceUpdateMode, object nullValue, string formatString);
+        public Binding(string propertyName, object dataSource, string dataMember, bool formattingEnabled, DataSourceUpdateMode dataSourceUpdateMode, object nullValue, string formatString, IFormatProvider formatInfo);
+        public IBindableComponent BindableComponent { get; }
+        public BindingManagerBase BindingManagerBase { get; }
+        public BindingMemberInfo BindingMemberInfo { get; }
+        public Control Control { get; }
+        public ControlUpdateMode ControlUpdateMode { get; set; }
+        public object DataSource { get; }
+        public object DataSourceNullValue { get; set; }
+        public DataSourceUpdateMode DataSourceUpdateMode { get; set; }
+        public IFormatProvider FormatInfo { get; set; }
+        public string FormatString { get; set; }
+        public bool FormattingEnabled { get; set; }
+        public bool IsBinding { get; }
+        public object NullValue { get; set; }
+        public string PropertyName { get; }
+        public event BindingCompleteEventHandler BindingComplete;
+        public event ConvertEventHandler Format;
+        public event ConvertEventHandler Parse;
+        protected virtual void OnBindingComplete(BindingCompleteEventArgs e);
+        protected virtual void OnFormat(ConvertEventArgs cevent);
+        protected virtual void OnParse(ConvertEventArgs cevent);
+        public void ReadValue();
+        public void WriteValue();
+    }
+    public enum BindingCompleteContext {
+        ControlUpdate = 0,
+        DataSourceUpdate = 1,
+    }
+    public class BindingCompleteEventArgs : CancelEventArgs {
+        public BindingCompleteEventArgs(Binding binding, BindingCompleteState state, BindingCompleteContext context);
+        public BindingCompleteEventArgs(Binding binding, BindingCompleteState state, BindingCompleteContext context, string errorText);
+        public BindingCompleteEventArgs(Binding binding, BindingCompleteState state, BindingCompleteContext context, string errorText, Exception exception);
+        public BindingCompleteEventArgs(Binding binding, BindingCompleteState state, BindingCompleteContext context, string errorText, Exception exception, bool cancel);
+        public Binding Binding { get; }
+        public BindingCompleteContext BindingCompleteContext { get; }
+        public BindingCompleteState BindingCompleteState { get; }
+        public string ErrorText { get; }
+        public Exception Exception { get; }
+    }
+    public delegate void BindingCompleteEventHandler(object sender, BindingCompleteEventArgs e);
+    public enum BindingCompleteState {
+        DataError = 1,
+        Exception = 2,
+        Success = 0,
+    }
+    public class BindingContext : ICollection, IEnumerable {
+        public BindingContext();
+        public bool IsReadOnly { get; }
+        int System.Collections.ICollection.Count { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        public BindingManagerBase this[object dataSource, string dataMember] { get; }
+        public BindingManagerBase this[object dataSource] { get; }
+        public event CollectionChangeEventHandler CollectionChanged;
+        protected internal void Add(object dataSource, BindingManagerBase listManager);
+        protected virtual void AddCore(object dataSource, BindingManagerBase listManager);
+        protected internal void Clear();
+        protected virtual void ClearCore();
+        public bool Contains(object dataSource);
+        public bool Contains(object dataSource, string dataMember);
+        protected virtual void OnCollectionChanged(CollectionChangeEventArgs ccevent);
+        protected internal void Remove(object dataSource);
+        protected virtual void RemoveCore(object dataSource);
+        void System.Collections.ICollection.CopyTo(Array ar, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        public static void UpdateBinding(BindingContext newBindingContext, Binding binding);
+    }
+    public abstract class BindingManagerBase {
+        protected EventHandler onCurrentChangedHandler;
+        protected EventHandler onPositionChangedHandler;
+        public BindingManagerBase();
+        public BindingsCollection Bindings { get; }
+        public abstract int Count { get; }
+        public abstract object Current { get; }
+        public bool IsBindingSuspended { get; }
+        public abstract int Position { get; set; }
+        public event BindingCompleteEventHandler BindingComplete;
+        public event EventHandler CurrentChanged;
+        public event EventHandler CurrentItemChanged;
+        public event BindingManagerDataErrorEventHandler DataError;
+        public event EventHandler PositionChanged;
+        public abstract void AddNew();
+        public abstract void CancelCurrentEdit();
+        public abstract void EndCurrentEdit();
+        public virtual PropertyDescriptorCollection GetItemProperties();
+        protected internal virtual PropertyDescriptorCollection GetItemProperties(ArrayList dataSources, ArrayList listAccessors);
+        protected virtual PropertyDescriptorCollection GetItemProperties(Type listType, int offset, ArrayList dataSources, ArrayList listAccessors);
+        protected internal abstract string GetListName(ArrayList listAccessors);
+        protected internal void OnBindingComplete(BindingCompleteEventArgs args);
+        protected internal abstract void OnCurrentChanged(EventArgs e);
+        protected internal abstract void OnCurrentItemChanged(EventArgs e);
+        protected internal void OnDataError(Exception e);
+        protected void PullData();
+        protected void PushData();
+        public abstract void RemoveAt(int index);
+        public abstract void ResumeBinding();
+        public abstract void SuspendBinding();
+        protected abstract void UpdateIsBinding();
+    }
+    public class BindingManagerDataErrorEventArgs : EventArgs {
+        public BindingManagerDataErrorEventArgs(Exception exception);
+        public Exception Exception { get; }
+    }
+    public delegate void BindingManagerDataErrorEventHandler(object sender, BindingManagerDataErrorEventArgs e);
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct BindingMemberInfo {
+        public BindingMemberInfo(string dataMember);
+        public string BindingField { get; }
+        public string BindingMember { get; }
+        public string BindingPath { get; }
+        public override bool Equals(object otherObject);
+        public override int GetHashCode();
+        public static bool operator ==(BindingMemberInfo a, BindingMemberInfo b);
+        public static bool operator !=(BindingMemberInfo a, BindingMemberInfo b);
+    }
+    public class BindingNavigator : ToolStrip, ISupportInitialize {
+        public BindingNavigator();
+        public BindingNavigator(bool addStandardItems);
+        public BindingNavigator(IContainer container);
+        public BindingNavigator(BindingSource bindingSource);
+        public ToolStripItem AddNewItem { get; set; }
+        public BindingSource BindingSource { get; set; }
+        public ToolStripItem CountItem { get; set; }
+        public string CountItemFormat { get; set; }
+        public ToolStripItem DeleteItem { get; set; }
+        public ToolStripItem MoveFirstItem { get; set; }
+        public ToolStripItem MoveLastItem { get; set; }
+        public ToolStripItem MoveNextItem { get; set; }
+        public ToolStripItem MovePreviousItem { get; set; }
+        public ToolStripItem PositionItem { get; set; }
+        public event EventHandler RefreshItems;
+        public virtual void AddStandardItems();
+        public void BeginInit();
+        protected override void Dispose(bool disposing);
+        public void EndInit();
+        protected virtual void OnRefreshItems();
+        protected virtual void RefreshItemsCore();
+        public bool Validate();
+    }
+    public class BindingsCollection : BaseCollection {
+        public override int Count { get; }
+        protected override ArrayList List { get; }
+        public Binding this[int index] { get; }
+        public event CollectionChangeEventHandler CollectionChanged;
+        public event CollectionChangeEventHandler CollectionChanging;
+        protected internal void Add(Binding binding);
+        protected virtual void AddCore(Binding dataBinding);
+        protected internal void Clear();
+        protected virtual void ClearCore();
+        protected virtual void OnCollectionChanged(CollectionChangeEventArgs ccevent);
+        protected virtual void OnCollectionChanging(CollectionChangeEventArgs e);
+        protected internal void Remove(Binding binding);
+        protected internal void RemoveAt(int index);
+        protected virtual void RemoveCore(Binding dataBinding);
+        protected internal bool ShouldSerializeMyAll();
+    }
+    public class BindingSource : Component, IBindingList, IBindingListView, ICancelAddNew, ICollection, ICurrencyManagerProvider, IEnumerable, IList, ISupportInitialize, ISupportInitializeNotification, ITypedList {
+        public BindingSource();
+        public BindingSource(IContainer container);
+        public BindingSource(object dataSource, string dataMember);
+        public virtual bool AllowEdit { get; }
+        public virtual bool AllowNew { get; set; }
+        public virtual bool AllowRemove { get; }
+        public virtual int Count { get; }
+        public virtual CurrencyManager CurrencyManager { get; }
+        public object Current { get; }
+        public string DataMember { get; set; }
+        public object DataSource { get; set; }
+        public virtual string Filter { get; set; }
+        public bool IsBindingSuspended { get; }
+        public virtual bool IsFixedSize { get; }
+        public virtual bool IsReadOnly { get; }
+        public virtual bool IsSorted { get; }
+        public virtual bool IsSynchronized { get; }
+        public IList List { get; }
+        public int Position { get; set; }
+        public bool RaiseListChangedEvents { get; set; }
+        public string Sort { get; set; }
+        public virtual ListSortDescriptionCollection SortDescriptions { get; }
+        public virtual ListSortDirection SortDirection { get; }
+        public virtual PropertyDescriptor SortProperty { get; }
+        public virtual bool SupportsAdvancedSorting { get; }
+        public virtual bool SupportsChangeNotification { get; }
+        public virtual bool SupportsFiltering { get; }
+        public virtual bool SupportsSearching { get; }
+        public virtual bool SupportsSorting { get; }
+        public virtual object SyncRoot { get; }
+        bool System.ComponentModel.ISupportInitializeNotification.IsInitialized { get; }
+        public virtual object this[int index] { get; set; }
+        public event AddingNewEventHandler AddingNew;
+        public event BindingCompleteEventHandler BindingComplete;
+        public event EventHandler CurrentChanged;
+        public event EventHandler CurrentItemChanged;
+        public event BindingManagerDataErrorEventHandler DataError;
+        public event EventHandler DataMemberChanged;
+        public event EventHandler DataSourceChanged;
+        public event ListChangedEventHandler ListChanged;
+        public event EventHandler PositionChanged;
+        event EventHandler System.ComponentModel.ISupportInitializeNotification.Initialized;
+        public virtual int Add(object value);
+        public virtual object AddNew();
+        public virtual void ApplySort(ListSortDescriptionCollection sorts);
+        public virtual void ApplySort(PropertyDescriptor property, ListSortDirection sort);
+        public void CancelEdit();
+        public virtual void Clear();
+        public virtual bool Contains(object value);
+        public virtual void CopyTo(Array arr, int index);
+        protected override void Dispose(bool disposing);
+        public void EndEdit();
+        public virtual int Find(PropertyDescriptor prop, object key);
+        public int Find(string propertyName, object key);
+        public virtual IEnumerator GetEnumerator();
+        public virtual PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors);
+        public virtual string GetListName(PropertyDescriptor[] listAccessors);
+        public virtual CurrencyManager GetRelatedCurrencyManager(string dataMember);
+        public virtual int IndexOf(object value);
+        public virtual void Insert(int index, object value);
+        public void MoveFirst();
+        public void MoveLast();
+        public void MoveNext();
+        public void MovePrevious();
+        protected virtual void OnAddingNew(AddingNewEventArgs e);
+        protected virtual void OnBindingComplete(BindingCompleteEventArgs e);
+        protected virtual void OnCurrentChanged(EventArgs e);
+        protected virtual void OnCurrentItemChanged(EventArgs e);
+        protected virtual void OnDataError(BindingManagerDataErrorEventArgs e);
+        protected virtual void OnDataMemberChanged(EventArgs e);
+        protected virtual void OnDataSourceChanged(EventArgs e);
+        protected virtual void OnListChanged(ListChangedEventArgs e);
+        protected virtual void OnPositionChanged(EventArgs e);
+        public virtual void Remove(object value);
+        public virtual void RemoveAt(int index);
+        public void RemoveCurrent();
+        public virtual void RemoveFilter();
+        public virtual void RemoveSort();
+        public virtual void ResetAllowNew();
+        public void ResetBindings(bool metadataChanged);
+        public void ResetCurrentItem();
+        public void ResetItem(int itemIndex);
+        public void ResumeBinding();
+        public void SuspendBinding();
+        void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor property);
+        void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor prop);
+        void System.ComponentModel.ICancelAddNew.CancelNew(int position);
+        void System.ComponentModel.ICancelAddNew.EndNew(int position);
+        void System.ComponentModel.ISupportInitialize.BeginInit();
+        void System.ComponentModel.ISupportInitialize.EndInit();
+    }
+    public enum BootMode {
+        FailSafe = 1,
+        FailSafeWithNetwork = 2,
+        Normal = 0,
+    }
+    public enum Border3DSide {
+        All = 2063,
+        Bottom = 8,
+        Left = 1,
+        Middle = 2048,
+        Right = 4,
+        Top = 2,
+    }
+    public enum Border3DStyle {
+        Adjust = 8192,
+        Bump = 9,
+        Etched = 6,
+        Flat = 16394,
+        Raised = 5,
+        RaisedInner = 4,
+        RaisedOuter = 1,
+        Sunken = 10,
+        SunkenInner = 8,
+        SunkenOuter = 2,
+    }
+    public enum BorderStyle {
+        Fixed3D = 2,
+        FixedSingle = 1,
+        None = 0,
+    }
+    public enum BoundsSpecified {
+        All = 15,
+        Height = 8,
+        Location = 3,
+        None = 0,
+        Size = 12,
+        Width = 4,
+        X = 1,
+        Y = 2,
+    }
+    public class Button : ButtonBase, IButtonControl {
+        public Button();
+        public AutoSizeMode AutoSizeMode { get; set; }
+        protected override CreateParams CreateParams { get; }
+        public virtual DialogResult DialogResult { get; set; }
+        public new event EventHandler DoubleClick;
+        public new event MouseEventHandler MouseDoubleClick;
+        public virtual void NotifyDefault(bool value);
+        protected override void OnClick(EventArgs e);
+        protected override void OnFontChanged(EventArgs e);
+        protected override void OnMouseEnter(EventArgs e);
+        protected override void OnMouseLeave(EventArgs e);
+        protected override void OnMouseUp(MouseEventArgs mevent);
+        protected override void OnTextChanged(EventArgs e);
+        public void PerformClick();
+        protected internal override bool ProcessMnemonic(char charCode);
+        public override string ToString();
+        protected override void WndProc(ref Message m);
+    }
+    public abstract class ButtonBase : Control {
+        protected ButtonBase();
+        public bool AutoEllipsis { get; set; }
+        public override bool AutoSize { get; set; }
+        public override Color BackColor { get; set; }
+        protected override CreateParams CreateParams { get; }
+        protected override ImeMode DefaultImeMode { get; }
+        protected override Size DefaultSize { get; }
+        public FlatButtonAppearance FlatAppearance { get; }
+        public FlatStyle FlatStyle { get; set; }
+        public Image Image { get; set; }
+        public ContentAlignment ImageAlign { get; set; }
+        public int ImageIndex { get; set; }
+        public string ImageKey { get; set; }
+        public ImageList ImageList { get; set; }
+        public new ImeMode ImeMode { get; set; }
+        protected internal bool IsDefault { get; set; }
+        public override string Text { get; set; }
+        public virtual ContentAlignment TextAlign { get; set; }
+        public TextImageRelation TextImageRelation { get; set; }
+        public bool UseCompatibleTextRendering { get; set; }
+        public bool UseMnemonic { get; set; }
+        public bool UseVisualStyleBackColor { get; set; }
+        public new event EventHandler AutoSizeChanged;
+        public new event EventHandler ImeModeChanged;
+        protected override AccessibleObject CreateAccessibilityInstance();
+        protected override void Dispose(bool disposing);
+        public override Size GetPreferredSize(Size proposedSize);
+        protected override void OnEnabledChanged(EventArgs e);
+        protected override void OnGotFocus(EventArgs e);
+        protected override void OnKeyDown(KeyEventArgs kevent);
+        protected override void OnKeyUp(KeyEventArgs kevent);
+        protected override void OnLostFocus(EventArgs e);
+        protected override void OnMouseDown(MouseEventArgs mevent);
+        protected override void OnMouseEnter(EventArgs eventargs);
+        protected override void OnMouseLeave(EventArgs eventargs);
+        protected override void OnMouseMove(MouseEventArgs mevent);
+        protected override void OnMouseUp(MouseEventArgs mevent);
+        protected override void OnPaint(PaintEventArgs pevent);
+        protected override void OnParentChanged(EventArgs e);
+        protected override void OnTextChanged(EventArgs e);
+        protected override void OnVisibleChanged(EventArgs e);
+        protected void ResetFlagsandPaint();
+        protected override void WndProc(ref Message m);
+        public class ButtonBaseAccessibleObject : Control.ControlAccessibleObject {
+            public ButtonBaseAccessibleObject(Control owner);
+            public override AccessibleStates State { get; }
+            public override void DoDefaultAction();
+        }
+    }
+    public enum ButtonBorderStyle {
+        Dashed = 2,
+        Dotted = 1,
+        Inset = 4,
+        None = 0,
+        Outset = 5,
+        Solid = 3,
+    }
+    public sealed class ButtonRenderer {
+        public static bool RenderMatchingApplicationState { get; set; }
+        public static void DrawButton(Graphics g, Rectangle bounds, bool focused, PushButtonState state);
+        public static void DrawButton(Graphics g, Rectangle bounds, Image image, Rectangle imageBounds, bool focused, PushButtonState state);
+        public static void DrawButton(Graphics g, Rectangle bounds, string buttonText, Font font, bool focused, PushButtonState state);
+        public static void DrawButton(Graphics g, Rectangle bounds, string buttonText, Font font, Image image, Rectangle imageBounds, bool focused, PushButtonState state);
+        public static void DrawButton(Graphics g, Rectangle bounds, string buttonText, Font font, TextFormatFlags flags, bool focused, PushButtonState state);
+        public static void DrawButton(Graphics g, Rectangle bounds, string buttonText, Font font, TextFormatFlags flags, Image image, Rectangle imageBounds, bool focused, PushButtonState state);
+        public static void DrawButton(Graphics g, Rectangle bounds, PushButtonState state);
+        public static void DrawParentBackground(Graphics g, Rectangle bounds, Control childControl);
+        public static bool IsBackgroundPartiallyTransparent(PushButtonState state);
+    }
+    public enum ButtonState {
+        All = 18176,
+        Checked = 1024,
+        Flat = 16384,
+        Inactive = 256,
+        Normal = 0,
+        Pushed = 512,
+    }
+    public class CacheVirtualItemsEventArgs : EventArgs {
+        public CacheVirtualItemsEventArgs(int startIndex, int endIndex);
+        public int EndIndex { get; }
+        public int StartIndex { get; }
+    }
+    public delegate void CacheVirtualItemsEventHandler(object sender, CacheVirtualItemsEventArgs e);
+    public enum CaptionButton {
+        Close = 0,
+        Help = 4,
+        Maximize = 2,
+        Minimize = 1,
+        Restore = 3,
+    }
+    public enum CharacterCasing {
+        Lower = 2,
+        Normal = 0,
+        Upper = 1,
+    }
+    public class CheckBox : ButtonBase {
+        public CheckBox();
+        public Appearance Appearance { get; set; }
+        public bool AutoCheck { get; set; }
+        public ContentAlignment CheckAlign { get; set; }
+        public bool Checked { get; set; }
+        public CheckState CheckState { get; set; }
+        protected override CreateParams CreateParams { get; }
+        protected override Size DefaultSize { get; }
+        public override ContentAlignment TextAlign { get; set; }
+        public bool ThreeState { get; set; }
+        public event EventHandler AppearanceChanged;
+        public event EventHandler CheckedChanged;
+        public event EventHandler CheckStateChanged;
+        public new event EventHandler DoubleClick;
+        public new event MouseEventHandler MouseDoubleClick;
+        protected override AccessibleObject CreateAccessibilityInstance();
+        protected virtual void OnAppearanceChanged(EventArgs e);
+        protected virtual void OnCheckedChanged(EventArgs e);
+        protected virtual void OnCheckStateChanged(EventArgs e);
+        protected override void OnClick(EventArgs e);
+        protected override void OnHandleCreated(EventArgs e);
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected override void OnMouseUp(MouseEventArgs mevent);
+        protected internal override bool ProcessMnemonic(char charCode);
+        public override string ToString();
+        public class CheckBoxAccessibleObject : ButtonBase.ButtonBaseAccessibleObject {
+            public CheckBoxAccessibleObject(Control owner);
+            public override string DefaultAction { get; }
+            public override AccessibleRole Role { get; }
+            public override AccessibleStates State { get; }
+            public override void DoDefaultAction();
+        }
+    }
+    public sealed class CheckBoxRenderer {
+        public static bool RenderMatchingApplicationState { get; set; }
+        public static void DrawCheckBox(Graphics g, Point glyphLocation, Rectangle textBounds, string checkBoxText, Font font, bool focused, CheckBoxState state);
+        public static void DrawCheckBox(Graphics g, Point glyphLocation, Rectangle textBounds, string checkBoxText, Font font, Image image, Rectangle imageBounds, bool focused, CheckBoxState state);
+        public static void DrawCheckBox(Graphics g, Point glyphLocation, Rectangle textBounds, string checkBoxText, Font font, TextFormatFlags flags, bool focused, CheckBoxState state);
+        public static void DrawCheckBox(Graphics g, Point glyphLocation, Rectangle textBounds, string checkBoxText, Font font, TextFormatFlags flags, Image image, Rectangle imageBounds, bool focused, CheckBoxState state);
+        public static void DrawCheckBox(Graphics g, Point glyphLocation, CheckBoxState state);
+        public static void DrawParentBackground(Graphics g, Rectangle bounds, Control childControl);
+        public static Size GetGlyphSize(Graphics g, CheckBoxState state);
+        public static bool IsBackgroundPartiallyTransparent(CheckBoxState state);
+    }
+    public class CheckedListBox : ListBox {
+        public CheckedListBox();
+        public CheckedListBox.CheckedIndexCollection CheckedIndices { get; }
+        public CheckedListBox.CheckedItemCollection CheckedItems { get; }
+        public bool CheckOnClick { get; set; }
+        protected override CreateParams CreateParams { get; }
+        public new object DataSource { get; set; }
+        public new string DisplayMember { get; set; }
+        public override DrawMode DrawMode { get; set; }
+        public override int ItemHeight { get; set; }
+        public new CheckedListBox.ObjectCollection Items { get; }
+        public new Padding Padding { get; set; }
+        public override SelectionMode SelectionMode { get; set; }
+        public bool ThreeDCheckBoxes { get; set; }
+        public bool UseCompatibleTextRendering { get; set; }
+        public new string ValueMember { get; set; }
+        public new event EventHandler Click;
+        public new event EventHandler DataSourceChanged;
+        public new event EventHandler DisplayMemberChanged;
+        public new event DrawItemEventHandler DrawItem;
+        public event ItemCheckEventHandler ItemCheck;
+        public new event MeasureItemEventHandler MeasureItem;
+        public new event MouseEventHandler MouseClick;
+        public new event EventHandler ValueMemberChanged;
+        protected override AccessibleObject CreateAccessibilityInstance();
+        protected override ListBox.ObjectCollection CreateItemCollection();
+        public bool GetItemChecked(int index);
+        public CheckState GetItemCheckState(int index);
+        protected override void OnBackColorChanged(EventArgs e);
+        protected override void OnClick(EventArgs e);
+        protected override void OnDrawItem(DrawItemEventArgs e);
+        protected override void OnFontChanged(EventArgs e);
+        protected override void OnHandleCreated(EventArgs e);
+        protected virtual void OnItemCheck(ItemCheckEventArgs ice);
+        protected override void OnKeyPress(KeyPressEventArgs e);
+        protected override void OnMeasureItem(MeasureItemEventArgs e);
+        protected override void OnSelectedIndexChanged(EventArgs e);
+        protected override void RefreshItems();
+        public void SetItemChecked(int index, bool value);
+        public void SetItemCheckState(int index, CheckState value);
+        protected override void WmReflectCommand(ref Message m);
+        protected override void WndProc(ref Message m);
+        public class CheckedIndexCollection : ICollection, IEnumerable, IList {
+            public int Count { get; }
+            public bool IsReadOnly { get; }
+            bool System.Collections.ICollection.IsSynchronized { get; }
+            object System.Collections.ICollection.SyncRoot { get; }
+            bool System.Collections.IList.IsFixedSize { get; }
+            object System.Collections.IList.this[int index] { get; set; }
+            public int this[int index] { get; }
+            public bool Contains(int index);
+            public void CopyTo(Array dest, int index);
+            public IEnumerator GetEnumerator();
+            public int IndexOf(int index);
+            int System.Collections.IList.Add(object value);
+            void System.Collections.IList.Clear();
+            bool System.Collections.IList.Contains(object index);
+            int System.Collections.IList.IndexOf(object index);
+            void System.Collections.IList.Insert(int index, object value);
+            void System.Collections.IList.Remove(object value);
+            void System.Collections.IList.RemoveAt(int index);
+        }
+        public class CheckedItemCollection : ICollection, IEnumerable, IList {
+            public int Count { get; }
+            public bool IsReadOnly { get; }
+            bool System.Collections.ICollection.IsSynchronized { get; }
+            object System.Collections.ICollection.SyncRoot { get; }
+            bool System.Collections.IList.IsFixedSize { get; }
+            public object this[int index] { get; set; }
+            public bool Contains(object item);
+            public void CopyTo(Array dest, int index);
+            public IEnumerator GetEnumerator();
+            public int IndexOf(object item);
+            int System.Collections.IList.Add(object value);
+            void System.Collections.IList.Clear();
+            void System.Collections.IList.Insert(int index, object value);
+            void System.Collections.IList.Remove(object value);
+            void System.Collections.IList.RemoveAt(int index);
+        }
+        public class ObjectCollection : ListBox.ObjectCollection {
+            public ObjectCollection(CheckedListBox owner);
+            public int Add(object item, bool isChecked);
+            public int Add(object item, CheckState check);
+        }
+    }
+    public enum CheckState {
+        Checked = 1,
+        Indeterminate = 2,
+        Unchecked = 0,
+    }
+    public sealed class Clipboard {
+        public static void Clear();
+        public static bool ContainsAudio();
+        public static bool ContainsData(string format);
+        public static bool ContainsFileDropList();
+        public static bool ContainsImage();
+        public static bool ContainsText();
+        public static bool ContainsText(TextDataFormat format);
+        public static Stream GetAudioStream();
+        public static object GetData(string format);
+        public static IDataObject GetDataObject();
+        public static StringCollection GetFileDropList();
+        public static Image GetImage();
+        public static string GetText();
+        public static string GetText(TextDataFormat format);
+        public static void SetAudio(byte[] audioBytes);
+        public static void SetAudio(Stream audioStream);
+        public static void SetData(string format, object data);
+        public static void SetDataObject(object data);
+        public static void SetDataObject(object data, bool copy);
+        public static void SetDataObject(object data, bool copy, int retryTimes, int retryDelay);
+        public static void SetFileDropList(StringCollection filePaths);
+        public static void SetImage(Image image);
+        public static void SetText(string text);
+        public static void SetText(string text, TextDataFormat format);
+    }
+    public enum CloseReason {
+        ApplicationExitCall = 6,
+        FormOwnerClosing = 5,
+        MdiFormClosing = 2,
+        None = 0,
+        TaskManagerClosing = 4,
+        UserClosing = 3,
+        WindowsShutDown = 1,
+    }
+    public enum ColorDepth {
+        Depth16Bit = 16,
+        Depth24Bit = 24,
+        Depth32Bit = 32,
+        Depth4Bit = 4,
+        Depth8Bit = 8,
+    }
+    public class ColorDialog : CommonDialog {
+        public ColorDialog();
+        public virtual bool AllowFullOpen { get; set; }
+        public virtual bool AnyColor { get; set; }
+        public Color Color { get; set; }
+        public int[] CustomColors { get; set; }
+        public virtual bool FullOpen { get; set; }
+        protected virtual IntPtr Instance { get; }
+        protected virtual int Options { get; }
+        public virtual bool ShowHelp { get; set; }
+        public virtual bool SolidColorOnly { get; set; }
+        public override void Reset();
+        protected override bool RunDialog(IntPtr hwndOwner);
+        public override string ToString();
+    }
+    public class ColumnClickEventArgs : EventArgs {
+        public ColumnClickEventArgs(int column);
+        public int Column { get; }
+    }
+    public delegate void ColumnClickEventHandler(object sender, ColumnClickEventArgs e);
+    public class ColumnHeader : Component, ICloneable {
+        public ColumnHeader();
+        public ColumnHeader(int imageIndex);
+        public ColumnHeader(string imageKey);
+        public int DisplayIndex { get; set; }
+        public int ImageIndex { get; set; }
+        public string ImageKey { get; set; }
+        public ImageList ImageList { get; }
+        public int Index { get; }
+        public ListView ListView { get; }
+        public string Name { get; set; }
+        public object Tag { get; set; }
+        public string Text { get; set; }
+        public HorizontalAlignment TextAlign { get; set; }
+        public int Width { get; set; }
+        public void AutoResize(ColumnHeaderAutoResizeStyle headerAutoResize);
+        public object Clone();
+        protected override void Dispose(bool disposing);
+        public override string ToString();
+    }
+    public enum ColumnHeaderAutoResizeStyle {
+        ColumnContent = 2,
+        HeaderSize = 1,
+        None = 0,
+    }
+    public class ColumnHeaderConverter : ExpandableObjectConverter {
+        public ColumnHeaderConverter();
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public enum ColumnHeaderStyle {
+        Clickable = 2,
+        Nonclickable = 1,
+        None = 0,
+    }
+    public class ColumnReorderedEventArgs : CancelEventArgs {
+        public ColumnReorderedEventArgs(int oldDisplayIndex, int newDisplayIndex, ColumnHeader header);
+        public ColumnHeader Header { get; }
+        public int NewDisplayIndex { get; }
+        public int OldDisplayIndex { get; }
+    }
+    public delegate void ColumnReorderedEventHandler(object sender, ColumnReorderedEventArgs e);
+    public class ColumnStyle : TableLayoutStyle {
+        public ColumnStyle();
+        public ColumnStyle(SizeType sizeType);
+        public ColumnStyle(SizeType sizeType, float width);
+        public float Width { get; set; }
+    }
+    public class ColumnWidthChangedEventArgs : EventArgs {
+        public ColumnWidthChangedEventArgs(int columnIndex);
+        public int ColumnIndex { get; }
+    }
+    public delegate void ColumnWidthChangedEventHandler(object sender, ColumnWidthChangedEventArgs e);
+    public class ColumnWidthChangingEventArgs : CancelEventArgs {
+        public ColumnWidthChangingEventArgs(int columnIndex, int newWidth);
+        public ColumnWidthChangingEventArgs(int columnIndex, int newWidth, bool cancel);
+        public int ColumnIndex { get; }
+        public int NewWidth { get; set; }
+    }
+    public delegate void ColumnWidthChangingEventHandler(object sender, ColumnWidthChangingEventArgs e);
+    public class ComboBox : ListControl {
+        public ComboBox();
+        public AutoCompleteStringCollection AutoCompleteCustomSource { get; set; }
+        public AutoCompleteMode AutoCompleteMode { get; set; }
+        public AutoCompleteSource AutoCompleteSource { get; set; }
+        public override Color BackColor { get; set; }
+        public override Image BackgroundImage { get; set; }
+        public override ImageLayout BackgroundImageLayout { get; set; }
+        protected override CreateParams CreateParams { get; }
+        public new object DataSource { get; set; }
+        protected override Size DefaultSize { get; }
+        public DrawMode DrawMode { get; set; }
+        public int DropDownHeight { get; set; }
+        public ComboBoxStyle DropDownStyle { get; set; }
+        public int DropDownWidth { get; set; }
+        public bool DroppedDown { get; set; }
+        public FlatStyle FlatStyle { get; set; }
+        public override bool Focused { get; }
+        public override Color ForeColor { get; set; }
+        public bool IntegralHeight { get; set; }
+        public int ItemHeight { get; set; }
+        public ComboBox.ObjectCollection Items { get; }
+        public int MaxDropDownItems { get; set; }
+        public override Size MaximumSize { get; set; }
+        public int MaxLength { get; set; }
+        public override Size MinimumSize { get; set; }
+        public new Padding Padding { get; set; }
+        public int PreferredHeight { get; }
+        public override int SelectedIndex { get; set; }
+        public object SelectedItem { get; set; }
+        public string SelectedText { get; set; }
+        public int SelectionLength { get; set; }
+        public int SelectionStart { get; set; }
+        public bool Sorted { get; set; }
+        public override string Text { get; set; }
+        public new event EventHandler BackgroundImageChanged;
+        public new event EventHandler BackgroundImageLayoutChanged;
+        public new event EventHandler DoubleClick;
+        public event DrawItemEventHandler DrawItem;
+        public event EventHandler DropDown;
+        public event EventHandler DropDownClosed;
+        public event EventHandler DropDownStyleChanged;
+        public event MeasureItemEventHandler MeasureItem;
+        public new event EventHandler PaddingChanged;
+        public new event PaintEventHandler Paint;
+        public event EventHandler SelectedIndexChanged;
+        public event EventHandler SelectionChangeCommitted;
+        public event EventHandler TextUpdate;
+        protected virtual void AddItemsCore(object[] value);
+        public void BeginUpdate();
+        protected override AccessibleObject CreateAccessibilityInstance();
+        protected override void CreateHandle();
+        protected override void Dispose(bool disposing);
+        public void EndUpdate();
+        public int FindString(string s);
+        public int FindString(string s, int startIndex);
+        public int FindStringExact(string s);
+        public int FindStringExact(string s, int startIndex);
+        public int GetItemHeight(int index);
+        protected override bool IsInputKey(Keys keyData);
+        protected override void OnBackColorChanged(EventArgs e);
+        protected override void OnDataSourceChanged(EventArgs e);
+        protected override void OnDisplayMemberChanged(EventArgs e);
+        protected virtual void OnDrawItem(DrawItemEventArgs e);
+        protected virtual void OnDropDown(EventArgs e);
+        protected virtual void OnDropDownClosed(EventArgs e);
+        protected virtual void OnDropDownStyleChanged(EventArgs e);
+        protected override void OnFontChanged(EventArgs e);
+        protected override void OnForeColorChanged(EventArgs e);
+        protected override void OnGotFocus(EventArgs e);
+        protected override void OnHandleCreated(EventArgs e);
+        protected override void OnHandleDestroyed(EventArgs e);
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected override void OnKeyPress(KeyPressEventArgs e);
+        protected override void OnLostFocus(EventArgs e);
+        protected virtual void OnMeasureItem(MeasureItemEventArgs e);
+        protected override void OnMouseEnter(EventArgs e);
+        protected override void OnMouseLeave(EventArgs e);
+        protected override void OnParentBackColorChanged(EventArgs e);
+        protected override void OnResize(EventArgs e);
+        protected override void OnSelectedIndexChanged(EventArgs e);
+        protected virtual void OnSelectedItemChanged(EventArgs e);
+        protected override void OnSelectedValueChanged(EventArgs e);
+        protected virtual void OnSelectionChangeCommitted(EventArgs e);
+        protected override void OnTextChanged(EventArgs e);
+        protected virtual void OnTextUpdate(EventArgs e);
+        protected override void OnValidating(CancelEventArgs e);
+        protected override bool ProcessKeyEventArgs(ref Message m);
+        protected override void RefreshItem(int index);
+        protected override void RefreshItems();
+        public override void ResetText();
+        protected override void ScaleControl(SizeF factor, BoundsSpecified specified);
+        public void Select(int start, int length);
+        public void SelectAll();
+        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified);
+        protected override void SetItemCore(int index, object value);
+        protected override void SetItemsCore(IList value);
+        public override string ToString();
+        protected override void WndProc(ref Message m);
+        public class ChildAccessibleObject : AccessibleObject {
+            public ChildAccessibleObject(ComboBox owner, IntPtr handle);
+            public override string Name { get; }
+        }
+        public class ObjectCollection : ICollection, IEnumerable, IList {
+            public ObjectCollection(ComboBox owner);
+            public int Count { get; }
+            public bool IsReadOnly { get; }
+            bool System.Collections.ICollection.IsSynchronized { get; }
+            object System.Collections.ICollection.SyncRoot { get; }
+            bool System.Collections.IList.IsFixedSize { get; }
+            public virtual object this[int index] { get; set; }
+            public int Add(object item);
+            public void AddRange(object[] items);
+            public void Clear();
+            public bool Contains(object value);
+            public void CopyTo(object[] destination, int arrayIndex);
+            public IEnumerator GetEnumerator();
+            public int IndexOf(object value);
+            public void Insert(int index, object item);
+            public void Remove(object value);
+            public void RemoveAt(int index);
+            void System.Collections.ICollection.CopyTo(Array destination, int index);
+            int System.Collections.IList.Add(object item);
+        }
+    }
+    public sealed class ComboBoxRenderer {
+        public static bool IsSupported { get; }
+        public static void DrawDropDownButton(Graphics g, Rectangle bounds, ComboBoxState state);
+        public static void DrawTextBox(Graphics g, Rectangle bounds, string comboBoxText, Font font, Rectangle textBounds, TextFormatFlags flags, ComboBoxState state);
+        public static void DrawTextBox(Graphics g, Rectangle bounds, string comboBoxText, Font font, Rectangle textBounds, ComboBoxState state);
+        public static void DrawTextBox(Graphics g, Rectangle bounds, string comboBoxText, Font font, TextFormatFlags flags, ComboBoxState state);
+        public static void DrawTextBox(Graphics g, Rectangle bounds, string comboBoxText, Font font, ComboBoxState state);
+        public static void DrawTextBox(Graphics g, Rectangle bounds, ComboBoxState state);
+    }
+    public enum ComboBoxStyle {
+        DropDown = 1,
+        DropDownList = 2,
+        Simple = 0,
+    }
+    public abstract class CommonDialog : Component {
+        public CommonDialog();
+        public object Tag { get; set; }
+        public event EventHandler HelpRequest;
+        protected virtual IntPtr HookProc(IntPtr hWnd, int msg, IntPtr wparam, IntPtr lparam);
+        protected virtual void OnHelpRequest(EventArgs e);
+        protected virtual IntPtr OwnerWndProc(IntPtr hWnd, int msg, IntPtr wparam, IntPtr lparam);
+        public abstract void Reset();
+        protected abstract bool RunDialog(IntPtr hwndOwner);
+        public DialogResult ShowDialog();
+        public DialogResult ShowDialog(IWin32Window owner);
+    }
+    public class ContainerControl : ScrollableControl, IContainerControl {
+        public ContainerControl();
+        public Control ActiveControl { get; set; }
+        public SizeF AutoScaleDimensions { get; set; }
+        protected SizeF AutoScaleFactor { get; }
+        public AutoScaleMode AutoScaleMode { get; set; }
+        public virtual AutoValidate AutoValidate { get; set; }
+        public override BindingContext BindingContext { get; set; }
+        protected override bool CanEnableIme { get; }
+        protected override CreateParams CreateParams { get; }
+        public SizeF CurrentAutoScaleDimensions { get; }
+        public Form ParentForm { get; }
+        public event EventHandler AutoValidateChanged;
+        protected override void AdjustFormScrollbars(bool displayScrollbars);
+        protected override void Dispose(bool disposing);
+        protected virtual void OnAutoValidateChanged(EventArgs e);
+        protected override void OnCreateControl();
+        protected override void OnFontChanged(EventArgs e);
+        protected override void OnLayout(LayoutEventArgs e);
+        protected override void OnParentChanged(EventArgs e);
+        public void PerformAutoScale();
+        protected override bool ProcessCmdKey(ref Message msg, Keys keyData);
+        protected override bool ProcessDialogChar(char charCode);
+        protected override bool ProcessDialogKey(Keys keyData);
+        protected internal override bool ProcessMnemonic(char charCode);
+        protected virtual bool ProcessTabKey(bool forward);
+        protected override void Select(bool directed, bool forward);
+        bool System.Windows.Forms.IContainerControl.ActivateControl(Control control);
+        protected virtual void UpdateDefaultButton();
+        public bool Validate();
+        public bool Validate(bool checkAutoValidate);
+        public virtual bool ValidateChildren();
+        public virtual bool ValidateChildren(ValidationConstraints validationConstraints);
+        protected override void WndProc(ref Message m);
+    }
+    public class ContentsResizedEventArgs : EventArgs {
+        public ContentsResizedEventArgs(Rectangle newRectangle);
+        public Rectangle NewRectangle { get; }
+    }
+    public delegate void ContentsResizedEventHandler(object sender, ContentsResizedEventArgs e);
+    public class ContextMenu : Menu {
+        public ContextMenu();
+        public ContextMenu(MenuItem[] menuItems);
+        public virtual RightToLeft RightToLeft { get; set; }
+        public Control SourceControl { get; }
+        public event EventHandler Collapse;
+        public event EventHandler Popup;
+        protected internal virtual void OnCollapse(EventArgs e);
+        protected internal virtual void OnPopup(EventArgs e);
+        protected internal virtual bool ProcessCmdKey(ref Message msg, Keys keyData, Control control);
+        public void Show(Control control, Point pos);
+        public void Show(Control control, Point pos, LeftRightAlignment alignment);
+    }
+    public class ContextMenuStrip : ToolStripDropDownMenu {
+        public ContextMenuStrip();
+        public ContextMenuStrip(IContainer container);
+        public Control SourceControl { get; }
+        protected override void Dispose(bool disposing);
+        protected override void SetVisibleCore(bool visible);
+    }
+    public class Control : Component, IArrangedElement, IBindableComponent, IComponent, IDisposable, IDropTarget, ISynchronizeInvoke, IWin32Window {
+        public Control();
+        public Control(string text);
+        public Control(string text, int left, int top, int width, int height);
+        public Control(Control parent, string text);
+        public Control(Control parent, string text, int left, int top, int width, int height);
+        public AccessibleObject AccessibilityObject { get; }
+        public string AccessibleDefaultActionDescription { get; set; }
+        public string AccessibleDescription { get; set; }
+        public string AccessibleName { get; set; }
+        public AccessibleRole AccessibleRole { get; set; }
+        public virtual bool AllowDrop { get; set; }
+        public virtual AnchorStyles Anchor { get; set; }
+        public virtual Point AutoScrollOffset { get; set; }
+        public virtual bool AutoSize { get; set; }
+        public virtual Color BackColor { get; set; }
+        public virtual Image BackgroundImage { get; set; }
+        public virtual ImageLayout BackgroundImageLayout { get; set; }
+        public virtual BindingContext BindingContext { get; set; }
+        public int Bottom { get; }
+        public Rectangle Bounds { get; set; }
+        protected virtual bool CanEnableIme { get; }
+        public bool CanFocus { get; }
+        protected override bool CanRaiseEvents { get; }
+        public bool CanSelect { get; }
+        public bool Capture { get; set; }
+        public bool CausesValidation { get; set; }
+        public static bool CheckForIllegalCrossThreadCalls { get; set; }
+        public Rectangle ClientRectangle { get; }
+        public Size ClientSize { get; set; }
+        public string CompanyName { get; }
+        public bool ContainsFocus { get; }
+        public virtual ContextMenu ContextMenu { get; set; }
+        public virtual ContextMenuStrip ContextMenuStrip { get; set; }
+        public Control.ControlCollection Controls { get; }
+        public bool Created { get; }
+        protected virtual CreateParams CreateParams { get; }
+        public virtual Cursor Cursor { get; set; }
+        public ControlBindingsCollection DataBindings { get; }
+        public static Color DefaultBackColor { get; }
+        protected virtual Cursor DefaultCursor { get; }
+        public static Font DefaultFont { get; }
+        public static Color DefaultForeColor { get; }
+        protected virtual ImeMode DefaultImeMode { get; }
+        protected virtual Padding DefaultMargin { get; }
+        protected virtual Size DefaultMaximumSize { get; }
+        protected virtual Size DefaultMinimumSize { get; }
+        protected virtual Padding DefaultPadding { get; }
+        protected virtual Size DefaultSize { get; }
+        public virtual Rectangle DisplayRectangle { get; }
+        public bool Disposing { get; }
+        public virtual DockStyle Dock { get; set; }
+        protected virtual bool DoubleBuffered { get; set; }
+        public bool Enabled { get; set; }
+        public virtual bool Focused { get; }
+        public virtual Font Font { get; set; }
+        protected int FontHeight { get; set; }
+        public virtual Color ForeColor { get; set; }
+        public IntPtr Handle { get; }
+        public bool HasChildren { get; }
+        public int Height { get; set; }
+        public ImeMode ImeMode { get; set; }
+        protected virtual ImeMode ImeModeBase { get; set; }
+        public bool InvokeRequired { get; }
+        public bool IsAccessible { get; set; }
+        public bool IsDisposed { get; }
+        public bool IsHandleCreated { get; }
+        public bool IsMirrored { get; }
+        public virtual LayoutEngine LayoutEngine { get; }
+        public int Left { get; set; }
+        public Point Location { get; set; }
+        public Padding Margin { get; set; }
+        public virtual Size MaximumSize { get; set; }
+        public virtual Size MinimumSize { get; set; }
+        public static Keys ModifierKeys { get; }
+        public static MouseButtons MouseButtons { get; }
+        public static Point MousePosition { get; }
+        public string Name { get; set; }
+        public Padding Padding { get; set; }
+        public Control Parent { get; set; }
+        public Size PreferredSize { get; }
+        public string ProductName { get; }
+        public string ProductVersion { get; }
+        protected static ImeMode PropagatingImeMode { get; private set; }
+        public bool RecreatingHandle { get; }
+        public Region Region { get; set; }
+        protected internal bool RenderRightToLeft { get; }
+        protected bool ResizeRedraw { get; set; }
+        public int Right { get; }
+        public virtual RightToLeft RightToLeft { get; set; }
+        protected virtual bool ScaleChildren { get; }
+        protected internal virtual bool ShowFocusCues { get; }
+        protected internal virtual bool ShowKeyboardCues { get; }
+        public override ISite Site { get; set; }
+        public Size Size { get; set; }
+        public int TabIndex { get; set; }
+        public bool TabStop { get; set; }
+        public object Tag { get; set; }
+        public virtual string Text { get; set; }
+        public int Top { get; set; }
+        public Control TopLevelControl { get; }
+        public bool UseWaitCursor { get; set; }
+        public bool Visible { get; set; }
+        public int Width { get; set; }
+        public IWindowTarget WindowTarget { get; set; }
+        public event EventHandler AutoSizeChanged;
+        public event EventHandler BackColorChanged;
+        public event EventHandler BackgroundImageChanged;
+        public event EventHandler BackgroundImageLayoutChanged;
+        public event EventHandler BindingContextChanged;
+        public event EventHandler CausesValidationChanged;
+        public event UICuesEventHandler ChangeUICues;
+        public event EventHandler Click;
+        public event EventHandler ClientSizeChanged;
+        public event EventHandler ContextMenuChanged;
+        public event EventHandler ContextMenuStripChanged;
+        public event ControlEventHandler ControlAdded;
+        public event ControlEventHandler ControlRemoved;
+        public event EventHandler CursorChanged;
+        public event EventHandler DockChanged;
+        public event EventHandler DoubleClick;
+        public event DragEventHandler DragDrop;
+        public event DragEventHandler DragEnter;
+        public event EventHandler DragLeave;
+        public event DragEventHandler DragOver;
+        public event EventHandler EnabledChanged;
+        public event EventHandler Enter;
+        public event EventHandler FontChanged;
+        public event EventHandler ForeColorChanged;
+        public event GiveFeedbackEventHandler GiveFeedback;
+        public event EventHandler GotFocus;
+        public event EventHandler HandleCreated;
+        public event EventHandler HandleDestroyed;
+        public event HelpEventHandler HelpRequested;
+        public event EventHandler ImeModeChanged;
+        public event InvalidateEventHandler Invalidated;
+        public event KeyEventHandler KeyDown;
+        public event KeyPressEventHandler KeyPress;
+        public event KeyEventHandler KeyUp;
+        public event LayoutEventHandler Layout;
+        public event EventHandler Leave;
+        public event EventHandler LocationChanged;
+        public event EventHandler LostFocus;
+        public event EventHandler MarginChanged;
+        public event EventHandler MouseCaptureChanged;
+        public event MouseEventHandler MouseClick;
+        public event MouseEventHandler MouseDoubleClick;
+        public event MouseEventHandler MouseDown;
+        public event EventHandler MouseEnter;
+        public event EventHandler MouseHover;
+        public event EventHandler MouseLeave;
+        public event MouseEventHandler MouseMove;
+        public event MouseEventHandler MouseUp;
+        public event MouseEventHandler MouseWheel;
+        public event EventHandler Move;
+        public event EventHandler PaddingChanged;
+        public event PaintEventHandler Paint;
+        public event EventHandler ParentChanged;
+        public event PreviewKeyDownEventHandler PreviewKeyDown;
+        public event QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
+        public event QueryContinueDragEventHandler QueryContinueDrag;
+        public event EventHandler RegionChanged;
+        public event EventHandler Resize;
+        public event EventHandler RightToLeftChanged;
+        public event EventHandler SizeChanged;
+        public event EventHandler StyleChanged;
+        public event EventHandler SystemColorsChanged;
+        public event EventHandler TabIndexChanged;
+        public event EventHandler TabStopChanged;
+        public event EventHandler TextChanged;
+        public event EventHandler Validated;
+        public event CancelEventHandler Validating;
+        public event EventHandler VisibleChanged;
+        protected internal void AccessibilityNotifyClients(AccessibleEvents accEvent, int childID);
+        protected void AccessibilityNotifyClients(AccessibleEvents accEvent, int objectID, int childID);
+        public IAsyncResult BeginInvoke(Delegate method);
+        public IAsyncResult BeginInvoke(Delegate method, params object[] args);
+        public void BringToFront();
+        public bool Contains(Control ctl);
+        protected virtual AccessibleObject CreateAccessibilityInstance();
+        public void CreateControl();
+        protected virtual Control.ControlCollection CreateControlsInstance();
+        public Graphics CreateGraphics();
+        protected virtual void CreateHandle();
+        protected virtual void DefWndProc(ref Message m);
+        protected virtual void DestroyHandle();
+        protected override void Dispose(bool disposing);
+        public DragDropEffects DoDragDrop(object data, DragDropEffects allowedEffects);
+        public void DrawToBitmap(Bitmap bitmap, Rectangle targetBounds);
+        public object EndInvoke(IAsyncResult asyncResult);
+        public Form FindForm();
+        public bool Focus();
+        public static Control FromChildHandle(IntPtr handle);
+        public static Control FromHandle(IntPtr handle);
+        protected virtual AccessibleObject GetAccessibilityObjectById(int objectId);
+        protected AutoSizeMode GetAutoSizeMode();
+        public Control GetChildAtPoint(Point pt);
+        public Control GetChildAtPoint(Point pt, GetChildAtPointSkip skipValue);
+        public IContainerControl GetContainerControl();
+        public Control GetNextControl(Control ctl, bool forward);
+        public virtual Size GetPreferredSize(Size proposedSize);
+        protected virtual Rectangle GetScaledBounds(Rectangle bounds, SizeF factor, BoundsSpecified specified);
+        protected bool GetStyle(ControlStyles flag);
+        protected bool GetTopLevel();
+        public void Hide();
+        protected virtual void InitLayout();
+        public void Invalidate();
+        public void Invalidate(bool invalidateChildren);
+        public void Invalidate(Rectangle rc);
+        public void Invalidate(Rectangle rc, bool invalidateChildren);
+        public void Invalidate(Region region);
+        public void Invalidate(Region region, bool invalidateChildren);
+        public object Invoke(Delegate method);
+        public object Invoke(Delegate method, params object[] args);
+        protected void InvokeGotFocus(Control toInvoke, EventArgs e);
+        protected void InvokeLostFocus(Control toInvoke, EventArgs e);
+        protected void InvokeOnClick(Control toInvoke, EventArgs e);
+        protected void InvokePaint(Control c, PaintEventArgs e);
+        protected void InvokePaintBackground(Control c, PaintEventArgs e);
+        protected virtual bool IsInputChar(char charCode);
+        protected virtual bool IsInputKey(Keys keyData);
+        public static bool IsKeyLocked(Keys keyVal);
+        public static bool IsMnemonic(char charCode, string text);
+        protected virtual void NotifyInvalidate(Rectangle invalidatedArea);
+        protected virtual void OnAutoSizeChanged(EventArgs e);
+        protected virtual void OnBackColorChanged(EventArgs e);
+        protected virtual void OnBackgroundImageChanged(EventArgs e);
+        protected virtual void OnBackgroundImageLayoutChanged(EventArgs e);
+        protected virtual void OnBindingContextChanged(EventArgs e);
+        protected virtual void OnCausesValidationChanged(EventArgs e);
+        protected virtual void OnChangeUICues(UICuesEventArgs e);
+        protected virtual void OnClick(EventArgs e);
+        protected virtual void OnClientSizeChanged(EventArgs e);
+        protected virtual void OnContextMenuChanged(EventArgs e);
+        protected virtual void OnContextMenuStripChanged(EventArgs e);
+        protected virtual void OnControlAdded(ControlEventArgs e);
+        protected virtual void OnControlRemoved(ControlEventArgs e);
+        protected virtual void OnCreateControl();
+        protected virtual void OnCursorChanged(EventArgs e);
+        protected virtual void OnDockChanged(EventArgs e);
+        protected virtual void OnDoubleClick(EventArgs e);
+        protected virtual void OnDragDrop(DragEventArgs drgevent);
+        protected virtual void OnDragEnter(DragEventArgs drgevent);
+        protected virtual void OnDragLeave(EventArgs e);
+        protected virtual void OnDragOver(DragEventArgs drgevent);
+        protected virtual void OnEnabledChanged(EventArgs e);
+        protected virtual void OnEnter(EventArgs e);
+        protected virtual void OnFontChanged(EventArgs e);
+        protected virtual void OnForeColorChanged(EventArgs e);
+        protected virtual void OnGiveFeedback(GiveFeedbackEventArgs gfbevent);
+        protected virtual void OnGotFocus(EventArgs e);
+        protected virtual void OnHandleCreated(EventArgs e);
+        protected virtual void OnHandleDestroyed(EventArgs e);
+        protected virtual void OnHelpRequested(HelpEventArgs hevent);
+        protected virtual void OnImeModeChanged(EventArgs e);
+        protected virtual void OnInvalidated(InvalidateEventArgs e);
+        protected virtual void OnKeyDown(KeyEventArgs e);
+        protected virtual void OnKeyPress(KeyPressEventArgs e);
+        protected virtual void OnKeyUp(KeyEventArgs e);
+        protected virtual void OnLayout(LayoutEventArgs levent);
+        protected virtual void OnLeave(EventArgs e);
+        protected virtual void OnLocationChanged(EventArgs e);
+        protected virtual void OnLostFocus(EventArgs e);
+        protected virtual void OnMarginChanged(EventArgs e);
+        protected virtual void OnMouseCaptureChanged(EventArgs e);
+        protected virtual void OnMouseClick(MouseEventArgs e);
+        protected virtual void OnMouseDoubleClick(MouseEventArgs e);
+        protected virtual void OnMouseDown(MouseEventArgs e);
+        protected virtual void OnMouseEnter(EventArgs e);
+        protected virtual void OnMouseHover(EventArgs e);
+        protected virtual void OnMouseLeave(EventArgs e);
+        protected virtual void OnMouseMove(MouseEventArgs e);
+        protected virtual void OnMouseUp(MouseEventArgs e);
+        protected virtual void OnMouseWheel(MouseEventArgs e);
+        protected virtual void OnMove(EventArgs e);
+        protected virtual void OnNotifyMessage(Message m);
+        protected virtual void OnPaddingChanged(EventArgs e);
+        protected virtual void OnPaint(PaintEventArgs e);
+        protected virtual void OnPaintBackground(PaintEventArgs pevent);
+        protected virtual void OnParentBackColorChanged(EventArgs e);
+        protected virtual void OnParentBackgroundImageChanged(EventArgs e);
+        protected virtual void OnParentBindingContextChanged(EventArgs e);
+        protected virtual void OnParentChanged(EventArgs e);
+        protected virtual void OnParentCursorChanged(EventArgs e);
+        protected virtual void OnParentEnabledChanged(EventArgs e);
+        protected virtual void OnParentFontChanged(EventArgs e);
+        protected virtual void OnParentForeColorChanged(EventArgs e);
+        protected virtual void OnParentRightToLeftChanged(EventArgs e);
+        protected virtual void OnParentVisibleChanged(EventArgs e);
+        protected virtual void OnPreviewKeyDown(PreviewKeyDownEventArgs e);
+        protected virtual void OnPrint(PaintEventArgs e);
+        protected virtual void OnQueryContinueDrag(QueryContinueDragEventArgs qcdevent);
+        protected virtual void OnRegionChanged(EventArgs e);
+        protected virtual void OnResize(EventArgs e);
+        protected virtual void OnRightToLeftChanged(EventArgs e);
+        protected virtual void OnSizeChanged(EventArgs e);
+        protected virtual void OnStyleChanged(EventArgs e);
+        protected virtual void OnSystemColorsChanged(EventArgs e);
+        protected virtual void OnTabIndexChanged(EventArgs e);
+        protected virtual void OnTabStopChanged(EventArgs e);
+        protected virtual void OnTextChanged(EventArgs e);
+        protected virtual void OnValidated(EventArgs e);
+        protected virtual void OnValidating(CancelEventArgs e);
+        protected virtual void OnVisibleChanged(EventArgs e);
+        public void PerformLayout();
+        public void PerformLayout(Control affectedControl, string affectedProperty);
+        public Point PointToClient(Point p);
+        public Point PointToScreen(Point p);
+        public PreProcessControlState PreProcessControlMessage(ref Message msg);
+        public virtual bool PreProcessMessage(ref Message msg);
+        protected virtual bool ProcessCmdKey(ref Message msg, Keys keyData);
+        protected virtual bool ProcessDialogChar(char charCode);
+        protected virtual bool ProcessDialogKey(Keys keyData);
+        protected virtual bool ProcessKeyEventArgs(ref Message m);
+        protected internal virtual bool ProcessKeyMessage(ref Message m);
+        protected virtual bool ProcessKeyPreview(ref Message m);
+        protected internal virtual bool ProcessMnemonic(char charCode);
+        protected void RaiseDragEvent(object key, DragEventArgs e);
+        protected void RaiseKeyEvent(object key, KeyEventArgs e);
+        protected void RaiseMouseEvent(object key, MouseEventArgs e);
+        protected void RaisePaintEvent(object key, PaintEventArgs e);
+        protected void RecreateHandle();
+        public Rectangle RectangleToClient(Rectangle r);
+        public Rectangle RectangleToScreen(Rectangle r);
+        protected static bool ReflectMessage(IntPtr hWnd, ref Message m);
+        public virtual void Refresh();
+        public virtual void ResetBackColor();
+        public void ResetBindings();
+        public virtual void ResetCursor();
+        public virtual void ResetFont();
+        public virtual void ResetForeColor();
+        public void ResetImeMode();
+        protected void ResetMouseEventArgs();
+        public virtual void ResetRightToLeft();
+        public virtual void ResetText();
+        public void ResumeLayout();
+        public void ResumeLayout(bool performLayout);
+        protected ContentAlignment RtlTranslateAlignment(ContentAlignment align);
+        protected HorizontalAlignment RtlTranslateAlignment(HorizontalAlignment align);
+        protected LeftRightAlignment RtlTranslateAlignment(LeftRightAlignment align);
+        protected internal ContentAlignment RtlTranslateContent(ContentAlignment align);
+        protected HorizontalAlignment RtlTranslateHorizontal(HorizontalAlignment align);
+        protected LeftRightAlignment RtlTranslateLeftRight(LeftRightAlignment align);
+        public void Scale(SizeF factor);
+        public void Scale(float ratio);
+        public void Scale(float dx, float dy);
+        protected virtual void ScaleControl(SizeF factor, BoundsSpecified specified);
+        protected virtual void ScaleCore(float dx, float dy);
+        public void Select();
+        protected virtual void Select(bool directed, bool forward);
+        public bool SelectNextControl(Control ctl, bool forward, bool tabStopOnly, bool nested, bool wrap);
+        public void SendToBack();
+        protected void SetAutoSizeMode(AutoSizeMode mode);
+        public void SetBounds(int x, int y, int width, int height);
+        public void SetBounds(int x, int y, int width, int height, BoundsSpecified specified);
+        protected virtual void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified);
+        protected virtual void SetClientSizeCore(int x, int y);
+        protected void SetStyle(ControlStyles flag, bool value);
+        protected void SetTopLevel(bool value);
+        protected virtual void SetVisibleCore(bool value);
+        public void Show();
+        protected virtual Size SizeFromClientSize(Size clientSize);
+        public void SuspendLayout();
+        void System.Windows.Forms.IDropTarget.OnDragDrop(DragEventArgs drgEvent);
+        void System.Windows.Forms.IDropTarget.OnDragEnter(DragEventArgs drgEvent);
+        void System.Windows.Forms.IDropTarget.OnDragLeave(EventArgs e);
+        void System.Windows.Forms.IDropTarget.OnDragOver(DragEventArgs drgEvent);
+        public void Update();
+        protected internal void UpdateBounds();
+        protected void UpdateBounds(int x, int y, int width, int height);
+        protected void UpdateBounds(int x, int y, int width, int height, int clientWidth, int clientHeight);
+        protected void UpdateStyles();
+        protected void UpdateZOrder();
+        protected virtual void WndProc(ref Message m);
+        public class ControlAccessibleObject : AccessibleObject {
+            public ControlAccessibleObject(Control ownerControl);
+            public override string DefaultAction { get; }
+            public override string Description { get; }
+            public IntPtr Handle { get; set; }
+            public override string Help { get; }
+            public override string KeyboardShortcut { get; }
+            public override string Name { get; set; }
+            public Control Owner { get; }
+            public override AccessibleObject Parent { get; }
+            public override AccessibleRole Role { get; }
+            public override int GetHelpTopic(out string fileName);
+            public void NotifyClients(AccessibleEvents accEvent);
+            public void NotifyClients(AccessibleEvents accEvent, int childID);
+            public void NotifyClients(AccessibleEvents accEvent, int objectID, int childID);
+            public override string ToString();
+        }
+        public class ControlCollection : ArrangedElementCollection, ICloneable, ICollection, IEnumerable, IList {
+            public ControlCollection(Control owner);
+            public Control Owner { get; }
+            public virtual new Control this[int index] { get; }
+            public virtual Control this[string key] { get; }
+            public virtual void Add(Control value);
+            public virtual void AddRange(Control[] controls);
+            public virtual void Clear();
+            public bool Contains(Control control);
+            public virtual bool ContainsKey(string key);
+            public Control[] Find(string key, bool searchAllChildren);
+            public int GetChildIndex(Control child);
+            public virtual int GetChildIndex(Control child, bool throwException);
+            public override IEnumerator GetEnumerator();
+            public int IndexOf(Control control);
+            public virtual int IndexOfKey(string key);
+            public virtual void Remove(Control value);
+            public void RemoveAt(int index);
+            public virtual void RemoveByKey(string key);
+            public virtual void SetChildIndex(Control child, int newIndex);
+            int System.Collections.IList.Add(object control);
+            void System.Collections.IList.Remove(object control);
+            object System.ICloneable.Clone();
+        }
+    }
+    public class ControlBindingsCollection : BindingsCollection {
+        public ControlBindingsCollection(IBindableComponent control);
+        public IBindableComponent BindableComponent { get; }
+        public Control Control { get; }
+        public DataSourceUpdateMode DefaultDataSourceUpdateMode { get; set; }
+        public Binding this[string propertyName] { get; }
+        public Binding Add(string propertyName, object dataSource, string dataMember);
+        public Binding Add(string propertyName, object dataSource, string dataMember, bool formattingEnabled);
+        public Binding Add(string propertyName, object dataSource, string dataMember, bool formattingEnabled, DataSourceUpdateMode updateMode);
+        public Binding Add(string propertyName, object dataSource, string dataMember, bool formattingEnabled, DataSourceUpdateMode updateMode, object nullValue);
+        public Binding Add(string propertyName, object dataSource, string dataMember, bool formattingEnabled, DataSourceUpdateMode updateMode, object nullValue, string formatString);
+        public Binding Add(string propertyName, object dataSource, string dataMember, bool formattingEnabled, DataSourceUpdateMode updateMode, object nullValue, string formatString, IFormatProvider formatInfo);
+        public new void Add(Binding binding);
+        protected override void AddCore(Binding dataBinding);
+        public new void Clear();
+        protected override void ClearCore();
+        public new void Remove(Binding binding);
+        public new void RemoveAt(int index);
+        protected override void RemoveCore(Binding dataBinding);
+    }
+    public class ControlEventArgs : EventArgs {
+        public ControlEventArgs(Control control);
+        public Control Control { get; }
+    }
+    public delegate void ControlEventHandler(object sender, ControlEventArgs e);
+    public sealed class ControlPaint {
+        public static Color ContrastControlDark { get; }
+        public static IntPtr CreateHBitmap16Bit(Bitmap bitmap, Color background);
+        public static IntPtr CreateHBitmapColorMask(Bitmap bitmap, IntPtr monochromeMask);
+        public static IntPtr CreateHBitmapTransparencyMask(Bitmap bitmap);
+        public static Color Dark(Color baseColor);
+        public static Color Dark(Color baseColor, float percOfDarkDark);
+        public static Color DarkDark(Color baseColor);
+        public static void DrawBorder(Graphics graphics, Rectangle bounds, Color leftColor, int leftWidth, ButtonBorderStyle leftStyle, Color topColor, int topWidth, ButtonBorderStyle topStyle, Color rightColor, int rightWidth, ButtonBorderStyle rightStyle, Color bottomColor, int bottomWidth, ButtonBorderStyle bottomStyle);
+        public static void DrawBorder(Graphics graphics, Rectangle bounds, Color color, ButtonBorderStyle style);
+        public static void DrawBorder3D(Graphics graphics, Rectangle rectangle);
+        public static void DrawBorder3D(Graphics graphics, Rectangle rectangle, Border3DStyle style);
+        public static void DrawBorder3D(Graphics graphics, Rectangle rectangle, Border3DStyle style, Border3DSide sides);
+        public static void DrawBorder3D(Graphics graphics, int x, int y, int width, int height);
+        public static void DrawBorder3D(Graphics graphics, int x, int y, int width, int height, Border3DStyle style);
+        public static void DrawBorder3D(Graphics graphics, int x, int y, int width, int height, Border3DStyle style, Border3DSide sides);
+        public static void DrawButton(Graphics graphics, Rectangle rectangle, ButtonState state);
+        public static void DrawButton(Graphics graphics, int x, int y, int width, int height, ButtonState state);
+        public static void DrawCaptionButton(Graphics graphics, Rectangle rectangle, CaptionButton button, ButtonState state);
+        public static void DrawCaptionButton(Graphics graphics, int x, int y, int width, int height, CaptionButton button, ButtonState state);
+        public static void DrawCheckBox(Graphics graphics, Rectangle rectangle, ButtonState state);
+        public static void DrawCheckBox(Graphics graphics, int x, int y, int width, int height, ButtonState state);
+        public static void DrawComboButton(Graphics graphics, Rectangle rectangle, ButtonState state);
+        public static void DrawComboButton(Graphics graphics, int x, int y, int width, int height, ButtonState state);
+        public static void DrawContainerGrabHandle(Graphics graphics, Rectangle bounds);
+        public static void DrawFocusRectangle(Graphics graphics, Rectangle rectangle);
+        public static void DrawFocusRectangle(Graphics graphics, Rectangle rectangle, Color foreColor, Color backColor);
+        public static void DrawGrabHandle(Graphics graphics, Rectangle rectangle, bool primary, bool enabled);
+        public static void DrawGrid(Graphics graphics, Rectangle area, Size pixelsBetweenDots, Color backColor);
+        public static void DrawImageDisabled(Graphics graphics, Image image, int x, int y, Color background);
+        public static void DrawLockedFrame(Graphics graphics, Rectangle rectangle, bool primary);
+        public static void DrawMenuGlyph(Graphics graphics, Rectangle rectangle, MenuGlyph glyph);
+        public static void DrawMenuGlyph(Graphics graphics, Rectangle rectangle, MenuGlyph glyph, Color foreColor, Color backColor);
+        public static void DrawMenuGlyph(Graphics graphics, int x, int y, int width, int height, MenuGlyph glyph);
+        public static void DrawMenuGlyph(Graphics graphics, int x, int y, int width, int height, MenuGlyph glyph, Color foreColor, Color backColor);
+        public static void DrawMixedCheckBox(Graphics graphics, Rectangle rectangle, ButtonState state);
+        public static void DrawMixedCheckBox(Graphics graphics, int x, int y, int width, int height, ButtonState state);
+        public static void DrawRadioButton(Graphics graphics, Rectangle rectangle, ButtonState state);
+        public static void DrawRadioButton(Graphics graphics, int x, int y, int width, int height, ButtonState state);
+        public static void DrawReversibleFrame(Rectangle rectangle, Color backColor, FrameStyle style);
+        public static void DrawReversibleLine(Point start, Point end, Color backColor);
+        public static void DrawScrollButton(Graphics graphics, Rectangle rectangle, ScrollButton button, ButtonState state);
+        public static void DrawScrollButton(Graphics graphics, int x, int y, int width, int height, ScrollButton button, ButtonState state);
+        public static void DrawSelectionFrame(Graphics graphics, bool active, Rectangle outsideRect, Rectangle insideRect, Color backColor);
+        public static void DrawSizeGrip(Graphics graphics, Color backColor, Rectangle bounds);
+        public static void DrawSizeGrip(Graphics graphics, Color backColor, int x, int y, int width, int height);
+        public static void DrawStringDisabled(Graphics graphics, string s, Font font, Color color, RectangleF layoutRectangle, StringFormat format);
+        public static void DrawStringDisabled(IDeviceContext dc, string s, Font font, Color color, Rectangle layoutRectangle, TextFormatFlags format);
+        public static void DrawVisualStyleBorder(Graphics graphics, Rectangle bounds);
+        public static void FillReversibleRectangle(Rectangle rectangle, Color backColor);
+        public static Color Light(Color baseColor);
+        public static Color Light(Color baseColor, float percOfLightLight);
+        public static Color LightLight(Color baseColor);
+    }
+    public enum ControlStyles {
+        AllPaintingInWmPaint = 8192,
+        CacheText = 16384,
+        ContainerControl = 1,
+        DoubleBuffer = 65536,
+        EnableNotifyMessage = 32768,
+        FixedHeight = 64,
+        FixedWidth = 32,
+        Opaque = 4,
+        OptimizedDoubleBuffer = 131072,
+        ResizeRedraw = 16,
+        Selectable = 512,
+        StandardClick = 256,
+        StandardDoubleClick = 4096,
+        SupportsTransparentBackColor = 2048,
+        UserMouse = 1024,
+        UserPaint = 2,
+        UseTextForAccessibility = 262144,
+    }
+    public enum ControlUpdateMode {
+        Never = 1,
+        OnPropertyChanged = 0,
+    }
+    public class ConvertEventArgs : EventArgs {
+        public ConvertEventArgs(object value, Type desiredType);
+        public Type DesiredType { get; }
+        public object Value { get; set; }
+    }
+    public delegate void ConvertEventHandler(object sender, ConvertEventArgs e);
+    public class CreateParams {
+        public CreateParams();
+        public string Caption { get; set; }
+        public string ClassName { get; set; }
+        public int ClassStyle { get; set; }
+        public int ExStyle { get; set; }
+        public int Height { get; set; }
+        public object Param { get; set; }
+        public IntPtr Parent { get; set; }
+        public int Style { get; set; }
+        public int Width { get; set; }
+        public int X { get; set; }
+        public int Y { get; set; }
+        public override string ToString();
+    }
+    public class CurrencyManager : BindingManagerBase {
+        protected int listposition;
+        protected Type finalType;
+        public override int Count { get; }
+        public override object Current { get; }
+        public IList List { get; }
+        public override int Position { get; set; }
+        public event ItemChangedEventHandler ItemChanged;
+        public event ListChangedEventHandler ListChanged;
+        public event EventHandler MetaDataChanged;
+        public override void AddNew();
+        public override void CancelCurrentEdit();
+        protected void CheckEmpty();
+        public override void EndCurrentEdit();
+        public override PropertyDescriptorCollection GetItemProperties();
+        protected internal override string GetListName(ArrayList listAccessors);
+        protected internal override void OnCurrentChanged(EventArgs e);
+        protected internal override void OnCurrentItemChanged(EventArgs e);
+        protected virtual void OnItemChanged(ItemChangedEventArgs e);
+        protected internal void OnMetaDataChanged(EventArgs e);
+        protected virtual void OnPositionChanged(EventArgs e);
+        public void Refresh();
+        public override void RemoveAt(int index);
+        public override void ResumeBinding();
+        public override void SuspendBinding();
+        protected override void UpdateIsBinding();
+    }
+    public sealed class Cursor : IDisposable, ISerializable {
+        public Cursor(IntPtr handle);
+        public Cursor(Stream stream);
+        public Cursor(string fileName);
+        public Cursor(Type type, string resource);
+        public static Rectangle Clip { get; set; }
+        public static Cursor Current { get; set; }
+        public IntPtr Handle { get; }
+        public Point HotSpot { get; }
+        public static Point Position { get; set; }
+        public Size Size { get; }
+        public object Tag { get; set; }
+        public IntPtr CopyHandle();
+        public void Dispose();
+        public void Draw(Graphics g, Rectangle targetRect);
+        public void DrawStretched(Graphics g, Rectangle targetRect);
+        public override bool Equals(object obj);
+        ~Cursor();
+        public override int GetHashCode();
+        public static void Hide();
+        public static bool operator ==(Cursor left, Cursor right);
+        public static bool operator !=(Cursor left, Cursor right);
+        public static void Show();
+        void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context);
+        public override string ToString();
+    }
+    public class CursorConverter : TypeConverter {
+        public CursorConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+        public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context);
+        public override bool GetStandardValuesSupported(ITypeDescriptorContext context);
+    }
+    public sealed class Cursors {
+        public static Cursor AppStarting { get; }
+        public static Cursor Arrow { get; }
+        public static Cursor Cross { get; }
+        public static Cursor Default { get; }
+        public static Cursor Hand { get; }
+        public static Cursor Help { get; }
+        public static Cursor HSplit { get; }
+        public static Cursor IBeam { get; }
+        public static Cursor No { get; }
+        public static Cursor NoMove2D { get; }
+        public static Cursor NoMoveHoriz { get; }
+        public static Cursor NoMoveVert { get; }
+        public static Cursor PanEast { get; }
+        public static Cursor PanNE { get; }
+        public static Cursor PanNorth { get; }
+        public static Cursor PanNW { get; }
+        public static Cursor PanSE { get; }
+        public static Cursor PanSouth { get; }
+        public static Cursor PanSW { get; }
+        public static Cursor PanWest { get; }
+        public static Cursor SizeAll { get; }
+        public static Cursor SizeNESW { get; }
+        public static Cursor SizeNS { get; }
+        public static Cursor SizeNWSE { get; }
+        public static Cursor SizeWE { get; }
+        public static Cursor UpArrow { get; }
+        public static Cursor VSplit { get; }
+        public static Cursor WaitCursor { get; }
+    }
+    public class DataFormats {
+        public static readonly string Bitmap;
+        public static readonly string CommaSeparatedValue;
+        public static readonly string Dib;
+        public static readonly string Dif;
+        public static readonly string EnhancedMetafile;
+        public static readonly string FileDrop;
+        public static readonly string Html;
+        public static readonly string Locale;
+        public static readonly string MetafilePict;
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
+        public static DataFormats.Format GetFormat(int id);
+        public static DataFormats.Format GetFormat(string format);
+        public class Format {
+            public Format(string name, int id);
+            public int Id { get; }
+            public string Name { get; }
+        }
+    }
+    public class DataGrid : Control, IDataGridEditingService, ISupportInitialize {
+        public DataGrid();
+        public bool AllowNavigation { get; set; }
+        public bool AllowSorting { get; set; }
+        public Color AlternatingBackColor { get; set; }
+        public override Color BackColor { get; set; }
+        public Color BackgroundColor { get; set; }
+        public override Image BackgroundImage { get; set; }
+        public override ImageLayout BackgroundImageLayout { get; set; }
+        public BorderStyle BorderStyle { get; set; }
+        public Color CaptionBackColor { get; set; }
+        public Font CaptionFont { get; set; }
+        public Color CaptionForeColor { get; set; }
+        public string CaptionText { get; set; }
+        public bool CaptionVisible { get; set; }
+        public bool ColumnHeadersVisible { get; set; }
+        public DataGridCell CurrentCell { get; set; }
+        public int CurrentRowIndex { get; set; }
+        public override Cursor Cursor { get; set; }
+        public string DataMember { get; set; }
+        public object DataSource { get; set; }
+        protected override Size DefaultSize { get; }
+        public int FirstVisibleColumn { get; }
+        public bool FlatMode { get; set; }
+        public override Color ForeColor { get; set; }
+        public Color GridLineColor { get; set; }
+        public DataGridLineStyle GridLineStyle { get; set; }
+        public Color HeaderBackColor { get; set; }
+        public Font HeaderFont { get; set; }
+        public Color HeaderForeColor { get; set; }
+        protected ScrollBar HorizScrollBar { get; }
+        public Color LinkColor { get; set; }
+        public Color LinkHoverColor { get; set; }
+        protected internal CurrencyManager ListManager { get; set; }
+        public Color ParentRowsBackColor { get; set; }
+        public Color ParentRowsForeColor { get; set; }
+        public DataGridParentRowsLabelStyle ParentRowsLabelStyle { get; set; }
+        public bool ParentRowsVisible { get; set; }
+        public int PreferredColumnWidth { get; set; }
+        public int PreferredRowHeight { get; set; }
+        public bool ReadOnly { get; set; }
+        public bool RowHeadersVisible { get; set; }
+        public int RowHeaderWidth { get; set; }
+        public Color SelectionBackColor { get; set; }
+        public Color SelectionForeColor { get; set; }
+        public override ISite Site { get; set; }
+        public GridTableStylesCollection TableStyles { get; }
+        public override string Text { get; set; }
+        public object this[int rowIndex, int columnIndex] { get; set; }
+        public object this[DataGridCell cell] { get; set; }
+        protected ScrollBar VertScrollBar { get; }
+        public int VisibleColumnCount { get; }
+        public int VisibleRowCount { get; }
+        public event EventHandler AllowNavigationChanged;
+        public event EventHandler BackButtonClick;
+        public event EventHandler BackgroundColorChanged;
+        public new event EventHandler BackgroundImageChanged;
+        public new event EventHandler BackgroundImageLayoutChanged;
+        public event EventHandler BorderStyleChanged;
+        public event EventHandler CaptionVisibleChanged;
+        public event EventHandler CurrentCellChanged;
+        public new event EventHandler CursorChanged;
+        public event EventHandler DataSourceChanged;
+        public event EventHandler FlatModeChanged;
+        public event NavigateEventHandler Navigate;
+        public event EventHandler ParentRowsLabelStyleChanged;
+        public event EventHandler ParentRowsVisibleChanged;
+        public event EventHandler ReadOnlyChanged;
+        protected event EventHandler RowHeaderClick;
+        public event EventHandler Scroll;
+        public event EventHandler ShowParentDetailsButtonClick;
+        public new event EventHandler TextChanged;
+        public bool BeginEdit(DataGridColumnStyle gridColumn, int rowNumber);
+        public void BeginInit();
+        protected virtual void CancelEditing();
+        public void Collapse(int row);
+        protected internal virtual void ColumnStartedEditing(Rectangle bounds);
+        protected internal virtual void ColumnStartedEditing(Control editingControl);
+        protected override AccessibleObject CreateAccessibilityInstance();
+        protected virtual DataGridColumnStyle CreateGridColumn(PropertyDescriptor prop);
+        protected virtual DataGridColumnStyle CreateGridColumn(PropertyDescriptor prop, bool isDefault);
+        protected override void Dispose(bool disposing);
+        public bool EndEdit(DataGridColumnStyle gridColumn, int rowNumber, bool shouldAbort);
+        public void EndInit();
+        public void Expand(int row);
+        public Rectangle GetCellBounds(int row, int col);
+        public Rectangle GetCellBounds(DataGridCell dgc);
+        public Rectangle GetCurrentCellBounds();
+        protected virtual string GetOutputTextDelimiter();
+        protected virtual void GridHScrolled(object sender, ScrollEventArgs se);
+        protected virtual void GridVScrolled(object sender, ScrollEventArgs se);
+        public DataGrid.HitTestInfo HitTest(Point position);
+        public DataGrid.HitTestInfo HitTest(int x, int y);
+        public bool IsExpanded(int rowNumber);
+        public bool IsSelected(int row);
+        public void NavigateBack();
+        public void NavigateTo(int rowNumber, string relationName);
+        protected virtual void OnAllowNavigationChanged(EventArgs e);
+        protected void OnBackButtonClicked(object sender, EventArgs e);
+        protected override void OnBackColorChanged(EventArgs e);
+        protected virtual void OnBackgroundColorChanged(EventArgs e);
+        protected override void OnBindingContextChanged(EventArgs e);
+        protected virtual void OnBorderStyleChanged(EventArgs e);
+        protected virtual void OnCaptionVisibleChanged(EventArgs e);
+        protected virtual void OnCurrentCellChanged(EventArgs e);
+        protected virtual void OnDataSourceChanged(EventArgs e);
+        protected override void OnEnter(EventArgs e);
+        protected virtual void OnFlatModeChanged(EventArgs e);
+        protected override void OnFontChanged(EventArgs e);
+        protected override void OnForeColorChanged(EventArgs e);
+        protected override void OnHandleCreated(EventArgs e);
+        protected override void OnHandleDestroyed(EventArgs e);
+        protected override void OnKeyDown(KeyEventArgs ke);
+        protected override void OnKeyPress(KeyPressEventArgs kpe);
+        protected override void OnLayout(LayoutEventArgs levent);
+        protected override void OnLeave(EventArgs e);
+        protected override void OnMouseDown(MouseEventArgs e);
+        protected override void OnMouseLeave(EventArgs e);
+        protected override void OnMouseMove(MouseEventArgs e);
+        protected override void OnMouseUp(MouseEventArgs e);
+        protected override void OnMouseWheel(MouseEventArgs e);
+        protected void OnNavigate(NavigateEventArgs e);
+        protected override void OnPaint(PaintEventArgs pe);
+        protected override void OnPaintBackground(PaintEventArgs ebe);
+        protected virtual void OnParentRowsLabelStyleChanged(EventArgs e);
+        protected virtual void OnParentRowsVisibleChanged(EventArgs e);
+        protected virtual void OnReadOnlyChanged(EventArgs e);
+        protected override void OnResize(EventArgs e);
+        protected void OnRowHeaderClick(EventArgs e);
+        protected void OnScroll(EventArgs e);
+        protected void OnShowParentDetailsButtonClicked(object sender, EventArgs e);
+        protected override bool ProcessDialogKey(Keys keyData);
+        protected bool ProcessGridKey(KeyEventArgs ke);
+        protected override bool ProcessKeyPreview(ref Message m);
+        protected bool ProcessTabKey(Keys keyData);
+        public void ResetAlternatingBackColor();
+        public override void ResetBackColor();
+        public override void ResetForeColor();
+        public void ResetGridLineColor();
+        public void ResetHeaderBackColor();
+        public void ResetHeaderFont();
+        public void ResetHeaderForeColor();
+        public void ResetLinkColor();
+        public void ResetLinkHoverColor();
+        protected void ResetSelection();
+        public void ResetSelectionBackColor();
+        public void ResetSelectionForeColor();
+        public void Select(int row);
+        public void SetDataBinding(object dataSource, string dataMember);
+        protected virtual bool ShouldSerializeAlternatingBackColor();
+        protected virtual bool ShouldSerializeBackgroundColor();
+        protected virtual bool ShouldSerializeCaptionBackColor();
+        protected virtual bool ShouldSerializeCaptionForeColor();
+        protected virtual bool ShouldSerializeGridLineColor();
+        protected virtual bool ShouldSerializeHeaderBackColor();
+        protected bool ShouldSerializeHeaderFont();
+        protected virtual bool ShouldSerializeHeaderForeColor();
+        protected virtual bool ShouldSerializeLinkHoverColor();
+        protected virtual bool ShouldSerializeParentRowsBackColor();
+        protected virtual bool ShouldSerializeParentRowsForeColor();
+        protected bool ShouldSerializePreferredRowHeight();
+        protected bool ShouldSerializeSelectionBackColor();
+        protected virtual bool ShouldSerializeSelectionForeColor();
+        public void SubObjectsSiteChange(bool site);
+        public void UnSelect(int row);
+        public sealed class HitTestInfo {
+            public static readonly DataGrid.HitTestInfo Nowhere;
+            public int Column { get; }
+            public int Row { get; }
+            public DataGrid.HitTestType Type { get; }
+            public override bool Equals(object value);
+            public override int GetHashCode();
+            public override string ToString();
+        }
+        public enum HitTestType {
+            Caption = 32,
+            Cell = 1,
+            ColumnHeader = 2,
+            ColumnResize = 8,
+            None = 0,
+            ParentRows = 64,
+            RowHeader = 4,
+            RowResize = 16,
+        }
+    }
+    public class DataGridBoolColumn : DataGridColumnStyle {
+        public DataGridBoolColumn();
+        public DataGridBoolColumn(PropertyDescriptor prop);
+        public DataGridBoolColumn(PropertyDescriptor prop, bool isDefault);
+        public bool AllowNull { get; set; }
+        public object FalseValue { get; set; }
+        public object NullValue { get; set; }
+        public object TrueValue { get; set; }
+        public event EventHandler AllowNullChanged;
+        public event EventHandler FalseValueChanged;
+        public event EventHandler TrueValueChanged;
+        protected internal override void Abort(int rowNum);
+        protected internal override bool Commit(CurrencyManager dataSource, int rowNum);
+        protected internal override void ConcedeFocus();
+        protected internal override void Edit(CurrencyManager source, int rowNum, Rectangle bounds, bool readOnly, string displayText, bool cellIsVisible);
+        protected internal override void EnterNullValue();
+        protected internal override object GetColumnValueAtRow(CurrencyManager lm, int row);
+        protected internal override int GetMinimumHeight();
+        protected internal override int GetPreferredHeight(Graphics g, object value);
+        protected internal override Size GetPreferredSize(Graphics g, object value);
+        protected internal override void Paint(Graphics g, Rectangle bounds, CurrencyManager source, int rowNum);
+        protected internal override void Paint(Graphics g, Rectangle bounds, CurrencyManager source, int rowNum, bool alignToRight);
+        protected internal override void Paint(Graphics g, Rectangle bounds, CurrencyManager source, int rowNum, Brush backBrush, Brush foreBrush, bool alignToRight);
+        protected internal override void SetColumnValueAtRow(CurrencyManager lm, int row, object value);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct DataGridCell {
+        public DataGridCell(int r, int c);
+        public int ColumnNumber { get; set; }
+        public int RowNumber { get; set; }
+        public override bool Equals(object o);
+        public override int GetHashCode();
+        public override string ToString();
+    }
+    public abstract class DataGridColumnStyle : Component, IDataGridColumnStyleEditingNotificationService {
+        public DataGridColumnStyle();
+        public DataGridColumnStyle(PropertyDescriptor prop);
+        public virtual HorizontalAlignment Alignment { get; set; }
+        public virtual DataGridTableStyle DataGridTableStyle { get; }
+        protected int FontHeight { get; }
+        public AccessibleObject HeaderAccessibleObject { get; }
+        public virtual string HeaderText { get; set; }
+        public string MappingName { get; set; }
+        public virtual string NullText { get; set; }
+        public virtual PropertyDescriptor PropertyDescriptor { get; set; }
+        public virtual bool ReadOnly { get; set; }
+        public virtual int Width { get; set; }
+        public event EventHandler AlignmentChanged;
+        public event EventHandler FontChanged;
+        public event EventHandler HeaderTextChanged;
+        public event EventHandler MappingNameChanged;
+        public event EventHandler NullTextChanged;
+        public event EventHandler PropertyDescriptorChanged;
+        public event EventHandler ReadOnlyChanged;
+        public event EventHandler WidthChanged;
+        protected internal abstract void Abort(int rowNum);
+        protected void BeginUpdate();
+        protected void CheckValidDataSource(CurrencyManager value);
+        protected internal virtual void ColumnStartedEditing(Control editingControl);
+        protected internal abstract bool Commit(CurrencyManager dataSource, int rowNum);
+        protected internal virtual void ConcedeFocus();
+        protected virtual AccessibleObject CreateHeaderAccessibleObject();
+        protected internal virtual void Edit(CurrencyManager source, int rowNum, Rectangle bounds, bool readOnly);
+        protected internal virtual void Edit(CurrencyManager source, int rowNum, Rectangle bounds, bool readOnly, string displayText);
+        protected internal abstract void Edit(CurrencyManager source, int rowNum, Rectangle bounds, bool readOnly, string displayText, bool cellIsVisible);
+        protected void EndUpdate();
+        protected internal virtual void EnterNullValue();
+        protected internal virtual object GetColumnValueAtRow(CurrencyManager source, int rowNum);
+        protected internal abstract int GetMinimumHeight();
+        protected internal abstract int GetPreferredHeight(Graphics g, object value);
+        protected internal abstract Size GetPreferredSize(Graphics g, object value);
+        protected virtual void Invalidate();
+        protected internal abstract void Paint(Graphics g, Rectangle bounds, CurrencyManager source, int rowNum);
+        protected internal abstract void Paint(Graphics g, Rectangle bounds, CurrencyManager source, int rowNum, bool alignToRight);
+        protected internal virtual void Paint(Graphics g, Rectangle bounds, CurrencyManager source, int rowNum, Brush backBrush, Brush foreBrush, bool alignToRight);
+        protected internal virtual void ReleaseHostedControl();
+        public void ResetHeaderText();
+        protected internal virtual void SetColumnValueAtRow(CurrencyManager source, int rowNum, object value);
+        protected virtual void SetDataGrid(DataGrid value);
+        protected virtual void SetDataGridInColumn(DataGrid value);
+        void System.Windows.Forms.IDataGridColumnStyleEditingNotificationService.ColumnStartedEditing(Control editingControl);
+        protected internal virtual void UpdateUI(CurrencyManager source, int rowNum, string displayText);
+        protected class CompModSwitches {
+            public CompModSwitches();
+            public static TraceSwitch DGEditColumnEditing { get; }
+        }
+        protected class DataGridColumnHeaderAccessibleObject : AccessibleObject {
+            public DataGridColumnHeaderAccessibleObject();
+            public DataGridColumnHeaderAccessibleObject(DataGridColumnStyle owner);
+            public override Rectangle Bounds { get; }
+            public override string Name { get; }
+            protected DataGridColumnStyle Owner { get; }
+            public override AccessibleObject Parent { get; }
+            public override AccessibleRole Role { get; }
+            public override AccessibleObject Navigate(AccessibleNavigation navdir);
+        }
+    }
+    public enum DataGridLineStyle {
+        None = 0,
+        Solid = 1,
+    }
+    public enum DataGridParentRowsLabelStyle {
+        Both = 3,
+        ColumnName = 2,
+        None = 0,
+        TableName = 1,
+    }
+    public class DataGridPreferredColumnWidthTypeConverter : TypeConverter {
+        public DataGridPreferredColumnWidthTypeConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public class DataGridTableStyle : Component, IDataGridEditingService {
+        public static readonly DataGridTableStyle DefaultTableStyle;
+        public DataGridTableStyle();
+        public DataGridTableStyle(bool isDefaultTableStyle);
+        public DataGridTableStyle(CurrencyManager listManager);
+        public bool AllowSorting { get; set; }
+        public Color AlternatingBackColor { get; set; }
+        public Color BackColor { get; set; }
+        public bool ColumnHeadersVisible { get; set; }
+        public virtual DataGrid DataGrid { get; set; }
+        public Color ForeColor { get; set; }
+        public virtual GridColumnStylesCollection GridColumnStyles { get; }
+        public Color GridLineColor { get; set; }
+        public DataGridLineStyle GridLineStyle { get; set; }
+        public Color HeaderBackColor { get; set; }
+        public Font HeaderFont { get; set; }
+        public Color HeaderForeColor { get; set; }
+        public Color LinkColor { get; set; }
+        public Color LinkHoverColor { get; set; }
+        public string MappingName { get; set; }
+        public int PreferredColumnWidth { get; set; }
+        public int PreferredRowHeight { get; set; }
+        public virtual bool ReadOnly { get; set; }
+        public bool RowHeadersVisible { get; set; }
+        public int RowHeaderWidth { get; set; }
+        public Color SelectionBackColor { get; set; }
+        public Color SelectionForeColor { get; set; }
+        public event EventHandler AllowSortingChanged;
+        public event EventHandler AlternatingBackColorChanged;
+        public event EventHandler BackColorChanged;
+        public event EventHandler ColumnHeadersVisibleChanged;
+        public event EventHandler ForeColorChanged;
+        public event EventHandler GridLineColorChanged;
+        public event EventHandler GridLineStyleChanged;
+        public event EventHandler HeaderBackColorChanged;
+        public event EventHandler HeaderFontChanged;
+        public event EventHandler HeaderForeColorChanged;
+        public event EventHandler LinkColorChanged;
+        public event EventHandler LinkHoverColorChanged;
+        public event EventHandler MappingNameChanged;
+        public event EventHandler PreferredColumnWidthChanged;
+        public event EventHandler PreferredRowHeightChanged;
+        public event EventHandler ReadOnlyChanged;
+        public event EventHandler RowHeadersVisibleChanged;
+        public event EventHandler RowHeaderWidthChanged;
+        public event EventHandler SelectionBackColorChanged;
+        public event EventHandler SelectionForeColorChanged;
+        public bool BeginEdit(DataGridColumnStyle gridColumn, int rowNumber);
+        protected internal virtual DataGridColumnStyle CreateGridColumn(PropertyDescriptor prop);
+        protected internal virtual DataGridColumnStyle CreateGridColumn(PropertyDescriptor prop, bool isDefault);
+        protected override void Dispose(bool disposing);
+        public bool EndEdit(DataGridColumnStyle gridColumn, int rowNumber, bool shouldAbort);
+        protected virtual void OnAllowSortingChanged(EventArgs e);
+        protected virtual void OnAlternatingBackColorChanged(EventArgs e);
+        protected virtual void OnBackColorChanged(EventArgs e);
+        protected virtual void OnColumnHeadersVisibleChanged(EventArgs e);
+        protected virtual void OnForeColorChanged(EventArgs e);
+        protected virtual void OnGridLineColorChanged(EventArgs e);
+        protected virtual void OnGridLineStyleChanged(EventArgs e);
+        protected virtual void OnHeaderBackColorChanged(EventArgs e);
+        protected virtual void OnHeaderFontChanged(EventArgs e);
+        protected virtual void OnHeaderForeColorChanged(EventArgs e);
+        protected virtual void OnLinkColorChanged(EventArgs e);
+        protected virtual void OnLinkHoverColorChanged(EventArgs e);
+        protected virtual void OnMappingNameChanged(EventArgs e);
+        protected virtual void OnPreferredColumnWidthChanged(EventArgs e);
+        protected virtual void OnPreferredRowHeightChanged(EventArgs e);
+        protected virtual void OnReadOnlyChanged(EventArgs e);
+        protected virtual void OnRowHeadersVisibleChanged(EventArgs e);
+        protected virtual void OnRowHeaderWidthChanged(EventArgs e);
+        protected virtual void OnSelectionBackColorChanged(EventArgs e);
+        protected virtual void OnSelectionForeColorChanged(EventArgs e);
+        public void ResetAlternatingBackColor();
+        public void ResetBackColor();
+        public void ResetForeColor();
+        public void ResetGridLineColor();
+        public void ResetHeaderBackColor();
+        public void ResetHeaderFont();
+        public void ResetHeaderForeColor();
+        public void ResetLinkColor();
+        public void ResetLinkHoverColor();
+        public void ResetSelectionBackColor();
+        public void ResetSelectionForeColor();
+        protected virtual bool ShouldSerializeAlternatingBackColor();
+        protected bool ShouldSerializeBackColor();
+        protected bool ShouldSerializeForeColor();
+        protected virtual bool ShouldSerializeGridLineColor();
+        protected virtual bool ShouldSerializeHeaderBackColor();
+        protected virtual bool ShouldSerializeHeaderForeColor();
+        protected virtual bool ShouldSerializeLinkColor();
+        protected virtual bool ShouldSerializeLinkHoverColor();
+        protected bool ShouldSerializePreferredRowHeight();
+        protected bool ShouldSerializeSelectionBackColor();
+        protected virtual bool ShouldSerializeSelectionForeColor();
+    }
+    public class DataGridTextBox : TextBox {
+        public DataGridTextBox();
+        public bool IsInEditOrNavigateMode { get; set; }
+        protected override void OnKeyPress(KeyPressEventArgs e);
+        protected override void OnMouseWheel(MouseEventArgs e);
+        protected internal override bool ProcessKeyMessage(ref Message m);
+        public void SetDataGrid(DataGrid parentGrid);
+        protected override void WndProc(ref Message m);
+    }
+    public class DataGridTextBoxColumn : DataGridColumnStyle {
+        public DataGridTextBoxColumn();
+        public DataGridTextBoxColumn(PropertyDescriptor prop);
+        public DataGridTextBoxColumn(PropertyDescriptor prop, bool isDefault);
+        public DataGridTextBoxColumn(PropertyDescriptor prop, string format);
+        public DataGridTextBoxColumn(PropertyDescriptor prop, string format, bool isDefault);
+        public string Format { get; set; }
+        public IFormatProvider FormatInfo { get; set; }
+        public override PropertyDescriptor PropertyDescriptor { set; }
+        public override bool ReadOnly { get; set; }
+        public virtual TextBox TextBox { get; }
+        protected internal override void Abort(int rowNum);
+        protected internal override bool Commit(CurrencyManager dataSource, int rowNum);
+        protected internal override void ConcedeFocus();
+        protected internal override void Edit(CurrencyManager source, int rowNum, Rectangle bounds, bool readOnly, string displayText, bool cellIsVisible);
+        protected void EndEdit();
+        protected internal override void EnterNullValue();
+        protected internal override int GetMinimumHeight();
+        protected internal override int GetPreferredHeight(Graphics g, object value);
+        protected internal override Size GetPreferredSize(Graphics g, object value);
+        protected void HideEditBox();
+        protected internal override void Paint(Graphics g, Rectangle bounds, CurrencyManager source, int rowNum);
+        protected internal override void Paint(Graphics g, Rectangle bounds, CurrencyManager source, int rowNum, bool alignToRight);
+        protected internal override void Paint(Graphics g, Rectangle bounds, CurrencyManager source, int rowNum, Brush backBrush, Brush foreBrush, bool alignToRight);
+        protected void PaintText(Graphics g, Rectangle bounds, string text, bool alignToRight);
+        protected void PaintText(Graphics g, Rectangle textBounds, string text, Brush backBrush, Brush foreBrush, bool alignToRight);
+        protected internal override void ReleaseHostedControl();
+        protected override void SetDataGridInColumn(DataGrid value);
+        protected internal override void UpdateUI(CurrencyManager source, int rowNum, string displayText);
+    }
+    public class DataGridView : Control, ISupportInitialize {
+        public DataGridView();
+        public virtual DataGridViewAdvancedBorderStyle AdjustedTopLeftHeaderBorderStyle { get; }
+        public DataGridViewAdvancedBorderStyle AdvancedCellBorderStyle { get; }
+        public DataGridViewAdvancedBorderStyle AdvancedColumnHeadersBorderStyle { get; }
+        public DataGridViewAdvancedBorderStyle AdvancedRowHeadersBorderStyle { get; }
+        public bool AllowUserToAddRows { get; set; }
+        public bool AllowUserToDeleteRows { get; set; }
+        public bool AllowUserToOrderColumns { get; set; }
+        public bool AllowUserToResizeColumns { get; set; }
+        public bool AllowUserToResizeRows { get; set; }
+        public DataGridViewCellStyle AlternatingRowsDefaultCellStyle { get; set; }
+        public bool AutoGenerateColumns { get; set; }
+        public override bool AutoSize { get; set; }
+        public DataGridViewAutoSizeColumnsMode AutoSizeColumnsMode { get; set; }
+        public DataGridViewAutoSizeRowsMode AutoSizeRowsMode { get; set; }
+        public override Color BackColor { get; set; }
+        public Color BackgroundColor { get; set; }
+        public override Image BackgroundImage { get; set; }
+        public override ImageLayout BackgroundImageLayout { get; set; }
+        public BorderStyle BorderStyle { get; set; }
+        protected override bool CanEnableIme { get; }
+        public DataGridViewCellBorderStyle CellBorderStyle { get; set; }
+        public DataGridViewClipboardCopyMode ClipboardCopyMode { get; set; }
+        public int ColumnCount { get; set; }
+        public DataGridViewHeaderBorderStyle ColumnHeadersBorderStyle { get; set; }
+        public DataGridViewCellStyle ColumnHeadersDefaultCellStyle { get; set; }
+        public int ColumnHeadersHeight { get; set; }
+        public DataGridViewColumnHeadersHeightSizeMode ColumnHeadersHeightSizeMode { get; set; }
+        public bool ColumnHeadersVisible { get; set; }
+        public DataGridViewColumnCollection Columns { get; }
+        public DataGridViewCell CurrentCell { get; set; }
+        public Point CurrentCellAddress { get; }
+        public DataGridViewRow CurrentRow { get; }
+        public string DataMember { get; set; }
+        public object DataSource { get; set; }
+        public DataGridViewCellStyle DefaultCellStyle { get; set; }
+        protected override Size DefaultSize { get; }
+        public override Rectangle DisplayRectangle { get; }
+        public Control EditingControl { get; }
+        public Panel EditingPanel { get; }
+        public DataGridViewEditMode EditMode { get; set; }
+        public bool EnableHeadersVisualStyles { get; set; }
+        public DataGridViewCell FirstDisplayedCell { get; set; }
+        public int FirstDisplayedScrollingColumnHiddenWidth { get; }
+        public int FirstDisplayedScrollingColumnIndex { get; set; }
+        public int FirstDisplayedScrollingRowIndex { get; set; }
+        public override Font Font { get; set; }
+        public override Color ForeColor { get; set; }
+        public Color GridColor { get; set; }
+        protected ScrollBar HorizontalScrollBar { get; }
+        public int HorizontalScrollingOffset { get; set; }
+        public bool IsCurrentCellDirty { get; }
+        public bool IsCurrentCellInEditMode { get; }
+        public bool IsCurrentRowDirty { get; }
+        public bool MultiSelect { get; set; }
+        public int NewRowIndex { get; }
+        public new Padding Padding { get; set; }
+        public bool ReadOnly { get; set; }
+        public int RowCount { get; set; }
+        public DataGridViewHeaderBorderStyle RowHeadersBorderStyle { get; set; }
+        public DataGridViewCellStyle RowHeadersDefaultCellStyle { get; set; }
+        public bool RowHeadersVisible { get; set; }
+        public int RowHeadersWidth { get; set; }
+        public DataGridViewRowHeadersWidthSizeMode RowHeadersWidthSizeMode { get; set; }
+        public DataGridViewRowCollection Rows { get; }
+        public DataGridViewCellStyle RowsDefaultCellStyle { get; set; }
+        public DataGridViewRow RowTemplate { get; set; }
+        public ScrollBars ScrollBars { get; set; }
+        public DataGridViewSelectedCellCollection SelectedCells { get; }
+        public DataGridViewSelectedColumnCollection SelectedColumns { get; }
+        public DataGridViewSelectedRowCollection SelectedRows { get; }
+        public DataGridViewSelectionMode SelectionMode { get; set; }
+        public bool ShowCellErrors { get; set; }
+        public bool ShowCellToolTips { get; set; }
+        public bool ShowEditingIcon { get; set; }
+        public bool ShowRowErrors { get; set; }
+        public DataGridViewColumn SortedColumn { get; }
+        public SortOrder SortOrder { get; }
+        public bool StandardTab { get; set; }
+        public override string Text { get; set; }
+        public DataGridViewCell this[int columnIndex, int rowIndex] { get; set; }
+        public DataGridViewCell this[string columnName, int rowIndex] { get; set; }
+        public DataGridViewHeaderCell TopLeftHeaderCell { get; set; }
+        public Cursor UserSetCursor { get; }
+        protected ScrollBar VerticalScrollBar { get; }
+        public int VerticalScrollingOffset { get; }
+        public bool VirtualMode { get; set; }
+        public event EventHandler AllowUserToAddRowsChanged;
+        public event EventHandler AllowUserToDeleteRowsChanged;
+        public event EventHandler AllowUserToOrderColumnsChanged;
+        public event EventHandler AllowUserToResizeColumnsChanged;
+        public event EventHandler AllowUserToResizeRowsChanged;
+        public event EventHandler AlternatingRowsDefaultCellStyleChanged;
+        public event EventHandler AutoGenerateColumnsChanged;
+        public event DataGridViewAutoSizeColumnModeEventHandler AutoSizeColumnModeChanged;
+        public event DataGridViewAutoSizeColumnsModeEventHandler AutoSizeColumnsModeChanged;
+        public event DataGridViewAutoSizeModeEventHandler AutoSizeRowsModeChanged;
+        public new event EventHandler BackColorChanged;
+        public event EventHandler BackgroundColorChanged;
+        public new event EventHandler BackgroundImageChanged;
+        public new event EventHandler BackgroundImageLayoutChanged;
+        public event EventHandler BorderStyleChanged;
+        public event QuestionEventHandler CancelRowEdit;
+        public event DataGridViewCellCancelEventHandler CellBeginEdit;
+        public event EventHandler CellBorderStyleChanged;
+        public event DataGridViewCellEventHandler CellClick;
+        public event DataGridViewCellEventHandler CellContentClick;
+        public event DataGridViewCellEventHandler CellContentDoubleClick;
+        public event DataGridViewCellEventHandler CellContextMenuStripChanged;
+        public event DataGridViewCellContextMenuStripNeededEventHandler CellContextMenuStripNeeded;
+        public event DataGridViewCellEventHandler CellDoubleClick;
+        public event DataGridViewCellEventHandler CellEndEdit;
+        public event DataGridViewCellEventHandler CellEnter;
+        public event DataGridViewCellEventHandler CellErrorTextChanged;
+        public event DataGridViewCellErrorTextNeededEventHandler CellErrorTextNeeded;
+        public event DataGridViewCellFormattingEventHandler CellFormatting;
+        public event DataGridViewCellEventHandler CellLeave;
+        public event DataGridViewCellMouseEventHandler CellMouseClick;
+        public event DataGridViewCellMouseEventHandler CellMouseDoubleClick;
+        public event DataGridViewCellMouseEventHandler CellMouseDown;
+        public event DataGridViewCellEventHandler CellMouseEnter;
+        public event DataGridViewCellEventHandler CellMouseLeave;
+        public event DataGridViewCellMouseEventHandler CellMouseMove;
+        public event DataGridViewCellMouseEventHandler CellMouseUp;
+        public event DataGridViewCellPaintingEventHandler CellPainting;
+        public event DataGridViewCellParsingEventHandler CellParsing;
+        public event DataGridViewCellStateChangedEventHandler CellStateChanged;
+        public event DataGridViewCellEventHandler CellStyleChanged;
+        public event DataGridViewCellStyleContentChangedEventHandler CellStyleContentChanged;
+        public event DataGridViewCellEventHandler CellToolTipTextChanged;
+        public event DataGridViewCellToolTipTextNeededEventHandler CellToolTipTextNeeded;
+        public event DataGridViewCellEventHandler CellValidated;
+        public event DataGridViewCellValidatingEventHandler CellValidating;
+        public event DataGridViewCellEventHandler CellValueChanged;
+        public event DataGridViewCellValueEventHandler CellValueNeeded;
+        public event DataGridViewCellValueEventHandler CellValuePushed;
+        public event DataGridViewColumnEventHandler ColumnAdded;
+        public event DataGridViewColumnEventHandler ColumnContextMenuStripChanged;
+        public event DataGridViewColumnEventHandler ColumnDataPropertyNameChanged;
+        public event DataGridViewColumnEventHandler ColumnDefaultCellStyleChanged;
+        public event DataGridViewColumnEventHandler ColumnDisplayIndexChanged;
+        public event DataGridViewColumnDividerDoubleClickEventHandler ColumnDividerDoubleClick;
+        public event DataGridViewColumnEventHandler ColumnDividerWidthChanged;
+        public event DataGridViewColumnEventHandler ColumnHeaderCellChanged;
+        public event DataGridViewCellMouseEventHandler ColumnHeaderMouseClick;
+        public event DataGridViewCellMouseEventHandler ColumnHeaderMouseDoubleClick;
+        public event EventHandler ColumnHeadersBorderStyleChanged;
+        public event EventHandler ColumnHeadersDefaultCellStyleChanged;
+        public event EventHandler ColumnHeadersHeightChanged;
+        public event DataGridViewAutoSizeModeEventHandler ColumnHeadersHeightSizeModeChanged;
+        public event DataGridViewColumnEventHandler ColumnMinimumWidthChanged;
+        public event DataGridViewColumnEventHandler ColumnNameChanged;
+        public event DataGridViewColumnEventHandler ColumnRemoved;
+        public event DataGridViewColumnEventHandler ColumnSortModeChanged;
+        public event DataGridViewColumnStateChangedEventHandler ColumnStateChanged;
+        public event DataGridViewColumnEventHandler ColumnToolTipTextChanged;
+        public event DataGridViewColumnEventHandler ColumnWidthChanged;
+        public event EventHandler CurrentCellChanged;
+        public event EventHandler CurrentCellDirtyStateChanged;
+        public event DataGridViewBindingCompleteEventHandler DataBindingComplete;
+        public event DataGridViewDataErrorEventHandler DataError;
+        public event EventHandler DataMemberChanged;
+        public event EventHandler DataSourceChanged;
+        public event EventHandler DefaultCellStyleChanged;
+        public event DataGridViewRowEventHandler DefaultValuesNeeded;
+        public event DataGridViewEditingControlShowingEventHandler EditingControlShowing;
+        public event EventHandler EditModeChanged;
+        public new event EventHandler FontChanged;
+        public new event EventHandler ForeColorChanged;
+        public event EventHandler GridColorChanged;
+        public event EventHandler MultiSelectChanged;
+        public event DataGridViewRowEventHandler NewRowNeeded;
+        public new event EventHandler PaddingChanged;
+        public event EventHandler ReadOnlyChanged;
+        public event DataGridViewRowEventHandler RowContextMenuStripChanged;
+        public event DataGridViewRowContextMenuStripNeededEventHandler RowContextMenuStripNeeded;
+        public event DataGridViewRowEventHandler RowDefaultCellStyleChanged;
+        public event QuestionEventHandler RowDirtyStateNeeded;
+        public event DataGridViewRowDividerDoubleClickEventHandler RowDividerDoubleClick;
+        public event DataGridViewRowEventHandler RowDividerHeightChanged;
+        public event DataGridViewCellEventHandler RowEnter;
+        public event DataGridViewRowEventHandler RowErrorTextChanged;
+        public event DataGridViewRowErrorTextNeededEventHandler RowErrorTextNeeded;
+        public event DataGridViewRowEventHandler RowHeaderCellChanged;
+        public event DataGridViewCellMouseEventHandler RowHeaderMouseClick;
+        public event DataGridViewCellMouseEventHandler RowHeaderMouseDoubleClick;
+        public event EventHandler RowHeadersBorderStyleChanged;
+        public event EventHandler RowHeadersDefaultCellStyleChanged;
+        public event EventHandler RowHeadersWidthChanged;
+        public event DataGridViewAutoSizeModeEventHandler RowHeadersWidthSizeModeChanged;
+        public event DataGridViewRowEventHandler RowHeightChanged;
+        public event DataGridViewRowHeightInfoNeededEventHandler RowHeightInfoNeeded;
+        public event DataGridViewRowHeightInfoPushedEventHandler RowHeightInfoPushed;
+        public event DataGridViewCellEventHandler RowLeave;
+        public event DataGridViewRowEventHandler RowMinimumHeightChanged;
+        public event DataGridViewRowPostPaintEventHandler RowPostPaint;
+        public event DataGridViewRowPrePaintEventHandler RowPrePaint;
+        public event DataGridViewRowsAddedEventHandler RowsAdded;
+        public event EventHandler RowsDefaultCellStyleChanged;
+        public event DataGridViewRowsRemovedEventHandler RowsRemoved;
+        public event DataGridViewRowStateChangedEventHandler RowStateChanged;
+        public event DataGridViewRowEventHandler RowUnshared;
+        public event DataGridViewCellEventHandler RowValidated;
+        public event DataGridViewCellCancelEventHandler RowValidating;
+        public event ScrollEventHandler Scroll;
+        public event EventHandler SelectionChanged;
+        public event DataGridViewSortCompareEventHandler SortCompare;
+        public event EventHandler Sorted;
+        public new event EventHandler StyleChanged;
+        public new event EventHandler TextChanged;
+        public event DataGridViewRowEventHandler UserAddedRow;
+        public event DataGridViewRowEventHandler UserDeletedRow;
+        public event DataGridViewRowCancelEventHandler UserDeletingRow;
+        protected virtual void AccessibilityNotifyCurrentCellChanged(Point cellAddress);
+        public virtual DataGridViewAdvancedBorderStyle AdjustColumnHeaderBorderStyle(DataGridViewAdvancedBorderStyle dataGridViewAdvancedBorderStyleInput, DataGridViewAdvancedBorderStyle dataGridViewAdvancedBorderStylePlaceholder, bool isFirstDisplayedColumn, bool isLastVisibleColumn);
+        public bool AreAllCellsSelected(bool includeInvisibleCells);
+        public void AutoResizeColumn(int columnIndex);
+        public void AutoResizeColumn(int columnIndex, DataGridViewAutoSizeColumnMode autoSizeColumnMode);
+        protected void AutoResizeColumn(int columnIndex, DataGridViewAutoSizeColumnMode autoSizeColumnMode, bool fixedHeight);
+        public void AutoResizeColumnHeadersHeight();
+        protected void AutoResizeColumnHeadersHeight(bool fixedRowHeadersWidth, bool fixedColumnsWidth);
+        public void AutoResizeColumnHeadersHeight(int columnIndex);
+        protected void AutoResizeColumnHeadersHeight(int columnIndex, bool fixedRowHeadersWidth, bool fixedColumnWidth);
+        public void AutoResizeColumns();
+        public void AutoResizeColumns(DataGridViewAutoSizeColumnsMode autoSizeColumnsMode);
+        protected void AutoResizeColumns(DataGridViewAutoSizeColumnsMode autoSizeColumnsMode, bool fixedHeight);
+        public void AutoResizeRow(int rowIndex);
+        public void AutoResizeRow(int rowIndex, DataGridViewAutoSizeRowMode autoSizeRowMode);
+        protected void AutoResizeRow(int rowIndex, DataGridViewAutoSizeRowMode autoSizeRowMode, bool fixedWidth);
+        public void AutoResizeRowHeadersWidth(int rowIndex, DataGridViewRowHeadersWidthSizeMode rowHeadersWidthSizeMode);
+        protected void AutoResizeRowHeadersWidth(int rowIndex, DataGridViewRowHeadersWidthSizeMode rowHeadersWidthSizeMode, bool fixedColumnHeadersHeight, bool fixedRowHeight);
+        public void AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode rowHeadersWidthSizeMode);
+        protected void AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode rowHeadersWidthSizeMode, bool fixedColumnHeadersHeight, bool fixedRowsHeight);
+        public void AutoResizeRows();
+        protected void AutoResizeRows(int rowIndexStart, int rowsCount, DataGridViewAutoSizeRowMode autoSizeRowMode, bool fixedWidth);
+        public void AutoResizeRows(DataGridViewAutoSizeRowsMode autoSizeRowsMode);
+        protected void AutoResizeRows(DataGridViewAutoSizeRowsMode autoSizeRowsMode, bool fixedWidth);
+        public virtual bool BeginEdit(bool selectAll);
+        public bool CancelEdit();
+        public void ClearSelection();
+        protected void ClearSelection(int columnIndexException, int rowIndexException, bool selectExceptionElement);
+        public bool CommitEdit(DataGridViewDataErrorContexts context);
+        protected override AccessibleObject CreateAccessibilityInstance();
+        protected virtual DataGridViewColumnCollection CreateColumnsInstance();
+        protected override Control.ControlCollection CreateControlsInstance();
+        protected virtual DataGridViewRowCollection CreateRowsInstance();
+        public int DisplayedColumnCount(bool includePartialColumns);
+        public int DisplayedRowCount(bool includePartialRow);
+        protected override void Dispose(bool disposing);
+        public bool EndEdit();
+        public bool EndEdit(DataGridViewDataErrorContexts context);
+        protected override AccessibleObject GetAccessibilityObjectById(int objectId);
+        public int GetCellCount(DataGridViewElementStates includeFilter);
+        public Rectangle GetCellDisplayRectangle(int columnIndex, int rowIndex, bool cutOverflow);
+        public virtual DataObject GetClipboardContent();
+        public Rectangle GetColumnDisplayRectangle(int columnIndex, bool cutOverflow);
+        public Rectangle GetRowDisplayRectangle(int rowIndex, bool cutOverflow);
+        public DataGridView.HitTestInfo HitTest(int x, int y);
+        public void InvalidateCell(int columnIndex, int rowIndex);
+        public void InvalidateCell(DataGridViewCell dataGridViewCell);
+        public void InvalidateColumn(int columnIndex);
+        public void InvalidateRow(int rowIndex);
+        protected override bool IsInputChar(char charCode);
+        protected override bool IsInputKey(Keys keyData);
+        public virtual void NotifyCurrentCellDirty(bool dirty);
+        protected virtual void OnAllowUserToAddRowsChanged(EventArgs e);
+        protected virtual void OnAllowUserToDeleteRowsChanged(EventArgs e);
+        protected virtual void OnAllowUserToOrderColumnsChanged(EventArgs e);
+        protected virtual void OnAllowUserToResizeColumnsChanged(EventArgs e);
+        protected virtual void OnAllowUserToResizeRowsChanged(EventArgs e);
+        protected virtual void OnAlternatingRowsDefaultCellStyleChanged(EventArgs e);
+        protected virtual void OnAutoGenerateColumnsChanged(EventArgs e);
+        protected virtual void OnAutoSizeColumnModeChanged(DataGridViewAutoSizeColumnModeEventArgs e);
+        protected virtual void OnAutoSizeColumnsModeChanged(DataGridViewAutoSizeColumnsModeEventArgs e);
+        protected virtual void OnAutoSizeRowsModeChanged(DataGridViewAutoSizeModeEventArgs e);
+        protected virtual void OnBackgroundColorChanged(EventArgs e);
+        protected override void OnBindingContextChanged(EventArgs e);
+        protected virtual void OnBorderStyleChanged(EventArgs e);
+        protected virtual void OnCancelRowEdit(QuestionEventArgs e);
+        protected virtual void OnCellBeginEdit(DataGridViewCellCancelEventArgs e);
+        protected virtual void OnCellBorderStyleChanged(EventArgs e);
+        protected virtual void OnCellClick(DataGridViewCellEventArgs e);
+        protected virtual void OnCellContentClick(DataGridViewCellEventArgs e);
+        protected virtual void OnCellContentDoubleClick(DataGridViewCellEventArgs e);
+        protected virtual void OnCellContextMenuStripChanged(DataGridViewCellEventArgs e);
+        protected virtual void OnCellContextMenuStripNeeded(DataGridViewCellContextMenuStripNeededEventArgs e);
+        protected virtual void OnCellDoubleClick(DataGridViewCellEventArgs e);
+        protected virtual void OnCellEndEdit(DataGridViewCellEventArgs e);
+        protected virtual void OnCellEnter(DataGridViewCellEventArgs e);
+        protected virtual void OnCellErrorTextChanged(DataGridViewCellEventArgs e);
+        protected virtual void OnCellErrorTextNeeded(DataGridViewCellErrorTextNeededEventArgs e);
+        protected virtual void OnCellFormatting(DataGridViewCellFormattingEventArgs e);
+        protected virtual void OnCellLeave(DataGridViewCellEventArgs e);
+        protected virtual void OnCellMouseClick(DataGridViewCellMouseEventArgs e);
+        protected virtual void OnCellMouseDoubleClick(DataGridViewCellMouseEventArgs e);
+        protected virtual void OnCellMouseDown(DataGridViewCellMouseEventArgs e);
+        protected virtual void OnCellMouseEnter(DataGridViewCellEventArgs e);
+        protected virtual void OnCellMouseLeave(DataGridViewCellEventArgs e);
+        protected virtual void OnCellMouseMove(DataGridViewCellMouseEventArgs e);
+        protected virtual void OnCellMouseUp(DataGridViewCellMouseEventArgs e);
+        protected internal virtual void OnCellPainting(DataGridViewCellPaintingEventArgs e);
+        protected virtual void OnCellParsing(DataGridViewCellParsingEventArgs e);
+        protected virtual void OnCellStateChanged(DataGridViewCellStateChangedEventArgs e);
+        protected virtual void OnCellStyleChanged(DataGridViewCellEventArgs e);
+        protected virtual void OnCellStyleContentChanged(DataGridViewCellStyleContentChangedEventArgs e);
+        protected virtual void OnCellToolTipTextChanged(DataGridViewCellEventArgs e);
+        protected virtual void OnCellToolTipTextNeeded(DataGridViewCellToolTipTextNeededEventArgs e);
+        protected virtual void OnCellValidated(DataGridViewCellEventArgs e);
+        protected virtual void OnCellValidating(DataGridViewCellValidatingEventArgs e);
+        protected virtual void OnCellValueChanged(DataGridViewCellEventArgs e);
+        protected virtual void OnCellValueNeeded(DataGridViewCellValueEventArgs e);
+        protected virtual void OnCellValuePushed(DataGridViewCellValueEventArgs e);
+        protected virtual void OnColumnAdded(DataGridViewColumnEventArgs e);
+        protected virtual void OnColumnContextMenuStripChanged(DataGridViewColumnEventArgs e);
+        protected virtual void OnColumnDataPropertyNameChanged(DataGridViewColumnEventArgs e);
+        protected virtual void OnColumnDefaultCellStyleChanged(DataGridViewColumnEventArgs e);
+        protected virtual void OnColumnDisplayIndexChanged(DataGridViewColumnEventArgs e);
+        protected virtual void OnColumnDividerDoubleClick(DataGridViewColumnDividerDoubleClickEventArgs e);
+        protected virtual void OnColumnDividerWidthChanged(DataGridViewColumnEventArgs e);
+        protected virtual void OnColumnHeaderCellChanged(DataGridViewColumnEventArgs e);
+        protected virtual void OnColumnHeaderMouseClick(DataGridViewCellMouseEventArgs e);
+        protected virtual void OnColumnHeaderMouseDoubleClick(DataGridViewCellMouseEventArgs e);
+        protected virtual void OnColumnHeadersBorderStyleChanged(EventArgs e);
+        protected virtual void OnColumnHeadersDefaultCellStyleChanged(EventArgs e);
+        protected virtual void OnColumnHeadersHeightChanged(EventArgs e);
+        protected virtual void OnColumnHeadersHeightSizeModeChanged(DataGridViewAutoSizeModeEventArgs e);
+        protected virtual void OnColumnMinimumWidthChanged(DataGridViewColumnEventArgs e);
+        protected virtual void OnColumnNameChanged(DataGridViewColumnEventArgs e);
+        protected virtual void OnColumnRemoved(DataGridViewColumnEventArgs e);
+        protected virtual void OnColumnSortModeChanged(DataGridViewColumnEventArgs e);
+        protected virtual void OnColumnStateChanged(DataGridViewColumnStateChangedEventArgs e);
+        protected virtual void OnColumnToolTipTextChanged(DataGridViewColumnEventArgs e);
+        protected virtual void OnColumnWidthChanged(DataGridViewColumnEventArgs e);
+        protected virtual void OnCurrentCellChanged(EventArgs e);
+        protected virtual void OnCurrentCellDirtyStateChanged(EventArgs e);
+        protected override void OnCursorChanged(EventArgs e);
+        protected virtual void OnDataBindingComplete(DataGridViewBindingCompleteEventArgs e);
+        protected virtual void OnDataError(bool displayErrorDialogIfNoHandler, DataGridViewDataErrorEventArgs e);
+        protected virtual void OnDataMemberChanged(EventArgs e);
+        protected virtual void OnDataSourceChanged(EventArgs e);
+        protected virtual void OnDefaultCellStyleChanged(EventArgs e);
+        protected virtual void OnDefaultValuesNeeded(DataGridViewRowEventArgs e);
+        protected override void OnDoubleClick(EventArgs e);
+        protected virtual void OnEditingControlShowing(DataGridViewEditingControlShowingEventArgs e);
+        protected virtual void OnEditModeChanged(EventArgs e);
+        protected override void OnEnabledChanged(EventArgs e);
+        protected override void OnEnter(EventArgs e);
+        protected override void OnFontChanged(EventArgs e);
+        protected override void OnForeColorChanged(EventArgs e);
+        protected override void OnGotFocus(EventArgs e);
+        protected virtual void OnGridColorChanged(EventArgs e);
+        protected override void OnHandleCreated(EventArgs e);
+        protected override void OnHandleDestroyed(EventArgs e);
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected override void OnKeyPress(KeyPressEventArgs e);
+        protected override void OnKeyUp(KeyEventArgs e);
+        protected override void OnLayout(LayoutEventArgs e);
+        protected override void OnLeave(EventArgs e);
+        protected override void OnLostFocus(EventArgs e);
+        protected override void OnMouseClick(MouseEventArgs e);
+        protected override void OnMouseDoubleClick(MouseEventArgs e);
+        protected override void OnMouseDown(MouseEventArgs e);
+        protected override void OnMouseEnter(EventArgs e);
+        protected override void OnMouseLeave(EventArgs e);
+        protected override void OnMouseMove(MouseEventArgs e);
+        protected override void OnMouseUp(MouseEventArgs e);
+        protected override void OnMouseWheel(MouseEventArgs e);
+        protected virtual void OnMultiSelectChanged(EventArgs e);
+        protected virtual void OnNewRowNeeded(DataGridViewRowEventArgs e);
+        protected override void OnPaint(PaintEventArgs e);
+        protected virtual void OnReadOnlyChanged(EventArgs e);
+        protected override void OnResize(EventArgs e);
+        protected override void OnRightToLeftChanged(EventArgs e);
+        protected virtual void OnRowContextMenuStripChanged(DataGridViewRowEventArgs e);
+        protected virtual void OnRowContextMenuStripNeeded(DataGridViewRowContextMenuStripNeededEventArgs e);
+        protected virtual void OnRowDefaultCellStyleChanged(DataGridViewRowEventArgs e);
+        protected virtual void OnRowDirtyStateNeeded(QuestionEventArgs e);
+        protected virtual void OnRowDividerDoubleClick(DataGridViewRowDividerDoubleClickEventArgs e);
+        protected virtual void OnRowDividerHeightChanged(DataGridViewRowEventArgs e);
+        protected virtual void OnRowEnter(DataGridViewCellEventArgs e);
+        protected virtual void OnRowErrorTextChanged(DataGridViewRowEventArgs e);
+        protected virtual void OnRowErrorTextNeeded(DataGridViewRowErrorTextNeededEventArgs e);
+        protected virtual void OnRowHeaderCellChanged(DataGridViewRowEventArgs e);
+        protected virtual void OnRowHeaderMouseClick(DataGridViewCellMouseEventArgs e);
+        protected virtual void OnRowHeaderMouseDoubleClick(DataGridViewCellMouseEventArgs e);
+        protected virtual void OnRowHeadersBorderStyleChanged(EventArgs e);
+        protected virtual void OnRowHeadersDefaultCellStyleChanged(EventArgs e);
+        protected virtual void OnRowHeadersWidthChanged(EventArgs e);
+        protected virtual void OnRowHeadersWidthSizeModeChanged(DataGridViewAutoSizeModeEventArgs e);
+        protected virtual void OnRowHeightChanged(DataGridViewRowEventArgs e);
+        protected virtual void OnRowHeightInfoNeeded(DataGridViewRowHeightInfoNeededEventArgs e);
+        protected virtual void OnRowHeightInfoPushed(DataGridViewRowHeightInfoPushedEventArgs e);
+        protected virtual void OnRowLeave(DataGridViewCellEventArgs e);
+        protected virtual void OnRowMinimumHeightChanged(DataGridViewRowEventArgs e);
+        protected internal virtual void OnRowPostPaint(DataGridViewRowPostPaintEventArgs e);
+        protected internal virtual void OnRowPrePaint(DataGridViewRowPrePaintEventArgs e);
+        protected virtual void OnRowsAdded(DataGridViewRowsAddedEventArgs e);
+        protected virtual void OnRowsDefaultCellStyleChanged(EventArgs e);
+        protected virtual void OnRowsRemoved(DataGridViewRowsRemovedEventArgs e);
+        protected virtual void OnRowStateChanged(int rowIndex, DataGridViewRowStateChangedEventArgs e);
+        protected virtual void OnRowUnshared(DataGridViewRowEventArgs e);
+        protected virtual void OnRowValidated(DataGridViewCellEventArgs e);
+        protected virtual void OnRowValidating(DataGridViewCellCancelEventArgs e);
+        protected virtual void OnScroll(ScrollEventArgs e);
+        protected virtual void OnSelectionChanged(EventArgs e);
+        protected virtual void OnSortCompare(DataGridViewSortCompareEventArgs e);
+        protected virtual void OnSorted(EventArgs e);
+        protected virtual void OnUserAddedRow(DataGridViewRowEventArgs e);
+        protected virtual void OnUserDeletedRow(DataGridViewRowEventArgs e);
+        protected virtual void OnUserDeletingRow(DataGridViewRowCancelEventArgs e);
+        protected override void OnValidating(CancelEventArgs e);
+        protected override void OnVisibleChanged(EventArgs e);
+        protected virtual void PaintBackground(Graphics graphics, Rectangle clipBounds, Rectangle gridBounds);
+        protected bool ProcessAKey(Keys keyData);
+        protected virtual bool ProcessDataGridViewKey(KeyEventArgs e);
+        protected bool ProcessDeleteKey(Keys keyData);
+        protected override bool ProcessDialogKey(Keys keyData);
+        protected bool ProcessDownKey(Keys keyData);
+        protected bool ProcessEndKey(Keys keyData);
+        protected bool ProcessEnterKey(Keys keyData);
+        protected bool ProcessEscapeKey(Keys keyData);
+        protected bool ProcessF2Key(Keys keyData);
+        protected bool ProcessHomeKey(Keys keyData);
+        protected bool ProcessInsertKey(Keys keyData);
+        protected override bool ProcessKeyEventArgs(ref Message m);
+        protected override bool ProcessKeyPreview(ref Message m);
+        protected bool ProcessLeftKey(Keys keyData);
+        protected bool ProcessNextKey(Keys keyData);
+        protected bool ProcessPriorKey(Keys keyData);
+        protected bool ProcessRightKey(Keys keyData);
+        protected bool ProcessSpaceKey(Keys keyData);
+        protected bool ProcessTabKey(Keys keyData);
+        protected bool ProcessUpKey(Keys keyData);
+        protected bool ProcessZeroKey(Keys keyData);
+        public bool RefreshEdit();
+        public override void ResetText();
+        public void SelectAll();
+        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified);
+        protected virtual bool SetCurrentCellAddressCore(int columnIndex, int rowIndex, bool setAnchorCellAddress, bool validateCurrentCell, bool throughMouseClick);
+        protected virtual void SetSelectedCellCore(int columnIndex, int rowIndex, bool selected);
+        protected virtual void SetSelectedColumnCore(int columnIndex, bool selected);
+        protected virtual void SetSelectedRowCore(int rowIndex, bool selected);
+        public virtual void Sort(IComparer comparer);
+        public virtual void Sort(DataGridViewColumn dataGridViewColumn, ListSortDirection direction);
+        void System.ComponentModel.ISupportInitialize.BeginInit();
+        void System.ComponentModel.ISupportInitialize.EndInit();
+        public void UpdateCellErrorText(int columnIndex, int rowIndex);
+        public void UpdateCellValue(int columnIndex, int rowIndex);
+        public void UpdateRowErrorText(int rowIndex);
+        public void UpdateRowErrorText(int rowIndexStart, int rowIndexEnd);
+        public void UpdateRowHeightInfo(int rowIndex, bool updateToEnd);
+        protected override void WndProc(ref Message m);
+        protected class DataGridViewAccessibleObject : Control.ControlAccessibleObject {
+            public DataGridViewAccessibleObject(DataGridView owner);
+            public override string Name { get; }
+            public override AccessibleRole Role { get; }
+            public override AccessibleObject GetChild(int index);
+            public override int GetChildCount();
+            public override AccessibleObject GetFocused();
+            public override AccessibleObject GetSelected();
+            public override AccessibleObject HitTest(int x, int y);
+            public override AccessibleObject Navigate(AccessibleNavigation navigationDirection);
+        }
+        public class DataGridViewControlCollection : Control.ControlCollection {
+            public DataGridViewControlCollection(DataGridView owner);
+            public override void Clear();
+            public void CopyTo(Control[] array, int index);
+            public void Insert(int index, Control value);
+            public override void Remove(Control value);
+        }
+        protected class DataGridViewTopRowAccessibleObject : AccessibleObject {
+            public DataGridViewTopRowAccessibleObject();
+            public DataGridViewTopRowAccessibleObject(DataGridView owner);
+            public override Rectangle Bounds { get; }
+            public override string Name { get; }
+            public DataGridView Owner { get; set; }
+            public override AccessibleObject Parent { get; }
+            public override AccessibleRole Role { get; }
+            public override string Value { get; }
+            public override AccessibleObject GetChild(int index);
+            public override int GetChildCount();
+            public override AccessibleObject Navigate(AccessibleNavigation navigationDirection);
+        }
+        public sealed class HitTestInfo {
+            public static readonly DataGridView.HitTestInfo Nowhere;
+            public int ColumnIndex { get; }
+            public int ColumnX { get; }
+            public int RowIndex { get; }
+            public int RowY { get; }
+            public DataGridViewHitTestType Type { get; }
+            public override bool Equals(object value);
+            public override int GetHashCode();
+            public override string ToString();
+        }
+    }
+    public sealed class DataGridViewAdvancedBorderStyle : ICloneable {
+        public DataGridViewAdvancedBorderStyle();
+        public DataGridViewAdvancedCellBorderStyle All { get; set; }
+        public DataGridViewAdvancedCellBorderStyle Bottom { get; set; }
+        public DataGridViewAdvancedCellBorderStyle Left { get; set; }
+        public DataGridViewAdvancedCellBorderStyle Right { get; set; }
+        public DataGridViewAdvancedCellBorderStyle Top { get; set; }
+        public override bool Equals(object other);
+        public override int GetHashCode();
+        object System.ICloneable.Clone();
+        public override string ToString();
+    }
+    public enum DataGridViewAdvancedCellBorderStyle {
+        Inset = 3,
+        InsetDouble = 4,
+        None = 1,
+        NotSet = 0,
+        Outset = 5,
+        OutsetDouble = 6,
+        OutsetPartial = 7,
+        Single = 2,
+    }
+    public enum DataGridViewAutoSizeColumnMode {
+        AllCells = 6,
+        AllCellsExceptHeader = 4,
+        ColumnHeader = 2,
+        DisplayedCells = 10,
+        DisplayedCellsExceptHeader = 8,
+        Fill = 16,
+        None = 1,
+        NotSet = 0,
+    }
+    public class DataGridViewAutoSizeColumnModeEventArgs : EventArgs {
+        public DataGridViewAutoSizeColumnModeEventArgs(DataGridViewColumn dataGridViewColumn, DataGridViewAutoSizeColumnMode previousMode);
+        public DataGridViewColumn Column { get; }
+        public DataGridViewAutoSizeColumnMode PreviousMode { get; }
+    }
+    public delegate void DataGridViewAutoSizeColumnModeEventHandler(object sender, DataGridViewAutoSizeColumnModeEventArgs e);
+    public enum DataGridViewAutoSizeColumnsMode {
+        AllCells = 6,
+        AllCellsExceptHeader = 4,
+        ColumnHeader = 2,
+        DisplayedCells = 10,
+        DisplayedCellsExceptHeader = 8,
+        Fill = 16,
+        None = 1,
+    }
+    public class DataGridViewAutoSizeColumnsModeEventArgs : EventArgs {
+        public DataGridViewAutoSizeColumnsModeEventArgs(DataGridViewAutoSizeColumnMode[] previousModes);
+        public DataGridViewAutoSizeColumnMode[] PreviousModes { get; }
+    }
+    public delegate void DataGridViewAutoSizeColumnsModeEventHandler(object sender, DataGridViewAutoSizeColumnsModeEventArgs e);
+    public class DataGridViewAutoSizeModeEventArgs : EventArgs {
+        public DataGridViewAutoSizeModeEventArgs(bool previousModeAutoSized);
+        public bool PreviousModeAutoSized { get; }
+    }
+    public delegate void DataGridViewAutoSizeModeEventHandler(object sender, DataGridViewAutoSizeModeEventArgs e);
+    public enum DataGridViewAutoSizeRowMode {
+        AllCells = 3,
+        AllCellsExceptHeader = 2,
+        RowHeader = 1,
+    }
+    public enum DataGridViewAutoSizeRowsMode {
+        AllCells = 7,
+        AllCellsExceptHeaders = 6,
+        AllHeaders = 5,
+        DisplayedCells = 11,
+        DisplayedCellsExceptHeaders = 10,
+        DisplayedHeaders = 9,
+        None = 0,
+    }
+    public class DataGridViewBand : DataGridViewElement, ICloneable, IDisposable {
+        public virtual ContextMenuStrip ContextMenuStrip { get; set; }
+        public virtual DataGridViewCellStyle DefaultCellStyle { get; set; }
+        public Type DefaultHeaderCellType { get; set; }
+        public virtual bool Displayed { get; }
+        public virtual bool Frozen { get; set; }
+        public bool HasDefaultCellStyle { get; }
+        protected DataGridViewHeaderCell HeaderCellCore { get; set; }
+        public int Index { get; }
+        public virtual DataGridViewCellStyle InheritedStyle { get; }
+        protected bool IsRow { get; }
+        public virtual bool ReadOnly { get; set; }
+        public virtual DataGridViewTriState Resizable { get; set; }
+        public virtual bool Selected { get; set; }
+        public object Tag { get; set; }
+        public virtual bool Visible { get; set; }
+        public virtual object Clone();
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        ~DataGridViewBand();
+        protected override void OnDataGridViewChanged();
+        public override string ToString();
+    }
+    public class DataGridViewBindingCompleteEventArgs : EventArgs {
+        public DataGridViewBindingCompleteEventArgs(ListChangedType listChangedType);
+        public ListChangedType ListChangedType { get; }
+    }
+    public delegate void DataGridViewBindingCompleteEventHandler(object sender, DataGridViewBindingCompleteEventArgs e);
+    public class DataGridViewButtonCell : DataGridViewCell {
+        public DataGridViewButtonCell();
+        public override Type EditType { get; }
+        public FlatStyle FlatStyle { get; set; }
+        public override Type FormattedValueType { get; }
+        public bool UseColumnTextForButtonValue { get; set; }
+        public override Type ValueType { get; }
+        public override object Clone();
+        protected override AccessibleObject CreateAccessibilityInstance();
+        protected override Rectangle GetContentBounds(Graphics graphics, DataGridViewCellStyle cellStyle, int rowIndex);
+        protected override Rectangle GetErrorIconBounds(Graphics graphics, DataGridViewCellStyle cellStyle, int rowIndex);
+        protected override Size GetPreferredSize(Graphics graphics, DataGridViewCellStyle cellStyle, int rowIndex, Size constraintSize);
+        protected override object GetValue(int rowIndex);
+        protected override bool KeyDownUnsharesRow(KeyEventArgs e, int rowIndex);
+        protected override bool KeyUpUnsharesRow(KeyEventArgs e, int rowIndex);
+        protected override bool MouseDownUnsharesRow(DataGridViewCellMouseEventArgs e);
+        protected override bool MouseEnterUnsharesRow(int rowIndex);
+        protected override bool MouseLeaveUnsharesRow(int rowIndex);
+        protected override bool MouseUpUnsharesRow(DataGridViewCellMouseEventArgs e);
+        protected override void OnKeyDown(KeyEventArgs e, int rowIndex);
+        protected override void OnKeyUp(KeyEventArgs e, int rowIndex);
+        protected override void OnLeave(int rowIndex, bool throughMouseClick);
+        protected override void OnMouseDown(DataGridViewCellMouseEventArgs e);
+        protected override void OnMouseLeave(int rowIndex);
+        protected override void OnMouseMove(DataGridViewCellMouseEventArgs e);
+        protected override void OnMouseUp(DataGridViewCellMouseEventArgs e);
+        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates elementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts);
+        public override string ToString();
+        protected class DataGridViewButtonCellAccessibleObject : DataGridViewCell.DataGridViewCellAccessibleObject {
+            public DataGridViewButtonCellAccessibleObject(DataGridViewCell owner);
+            public override string DefaultAction { get; }
+            public override void DoDefaultAction();
+            public override int GetChildCount();
+        }
+    }
+    public class DataGridViewButtonColumn : DataGridViewColumn {
+        public DataGridViewButtonColumn();
+        public override DataGridViewCell CellTemplate { get; set; }
+        public override DataGridViewCellStyle DefaultCellStyle { get; set; }
+        public FlatStyle FlatStyle { get; set; }
+        public string Text { get; set; }
+        public bool UseColumnTextForButtonValue { get; set; }
+        public override object Clone();
+        public override string ToString();
+    }
+    public abstract class DataGridViewCell : DataGridViewElement, ICloneable, IDisposable {
+        protected DataGridViewCell();
+        public AccessibleObject AccessibilityObject { get; }
+        public int ColumnIndex { get; }
+        public Rectangle ContentBounds { get; }
+        public virtual ContextMenuStrip ContextMenuStrip { get; set; }
+        public virtual object DefaultNewRowValue { get; }
+        public virtual bool Displayed { get; }
+        public object EditedFormattedValue { get; }
+        public virtual Type EditType { get; }
+        public Rectangle ErrorIconBounds { get; }
+        public string ErrorText { get; set; }
+        public object FormattedValue { get; }
+        public virtual Type FormattedValueType { get; }
+        public virtual bool Frozen { get; }
+        public bool HasStyle { get; }
+        public DataGridViewElementStates InheritedState { get; }
+        public DataGridViewCellStyle InheritedStyle { get; }
+        public bool IsInEditMode { get; }
+        public DataGridViewColumn OwningColumn { get; }
+        public DataGridViewRow OwningRow { get; }
+        public Size PreferredSize { get; }
+        public virtual bool ReadOnly { get; set; }
+        public virtual bool Resizable { get; }
+        public int RowIndex { get; }
+        public virtual bool Selected { get; set; }
+        public Size Size { get; }
+        public DataGridViewCellStyle Style { get; set; }
+        public object Tag { get; set; }
+        public string ToolTipText { get; set; }
+        public object Value { get; set; }
+        public virtual Type ValueType { get; set; }
+        public virtual bool Visible { get; }
+        public virtual DataGridViewAdvancedBorderStyle AdjustCellBorderStyle(DataGridViewAdvancedBorderStyle dataGridViewAdvancedBorderStyleInput, DataGridViewAdvancedBorderStyle dataGridViewAdvancedBorderStylePlaceholder, bool singleVerticalBorderAdded, bool singleHorizontalBorderAdded, bool isFirstDisplayedColumn, bool isFirstDisplayedRow);
+        protected virtual Rectangle BorderWidths(DataGridViewAdvancedBorderStyle advancedBorderStyle);
+        protected virtual bool ClickUnsharesRow(DataGridViewCellEventArgs e);
+        public virtual object Clone();
+        protected virtual bool ContentClickUnsharesRow(DataGridViewCellEventArgs e);
+        protected virtual bool ContentDoubleClickUnsharesRow(DataGridViewCellEventArgs e);
+        protected virtual AccessibleObject CreateAccessibilityInstance();
+        public virtual void DetachEditingControl();
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        protected virtual bool DoubleClickUnsharesRow(DataGridViewCellEventArgs e);
+        protected virtual bool EnterUnsharesRow(int rowIndex, bool throughMouseClick);
+        ~DataGridViewCell();
+        protected virtual object GetClipboardContent(int rowIndex, bool firstCell, bool lastCell, bool inFirstRow, bool inLastRow, string format);
+        protected virtual Rectangle GetContentBounds(Graphics graphics, DataGridViewCellStyle cellStyle, int rowIndex);
+        public Rectangle GetContentBounds(int rowIndex);
+        public object GetEditedFormattedValue(int rowIndex, DataGridViewDataErrorContexts context);
+        protected virtual Rectangle GetErrorIconBounds(Graphics graphics, DataGridViewCellStyle cellStyle, int rowIndex);
+        protected internal virtual string GetErrorText(int rowIndex);
+        protected virtual object GetFormattedValue(object value, int rowIndex, ref DataGridViewCellStyle cellStyle, TypeConverter valueTypeConverter, TypeConverter formattedValueTypeConverter, DataGridViewDataErrorContexts context);
+        public virtual ContextMenuStrip GetInheritedContextMenuStrip(int rowIndex);
+        public virtual DataGridViewElementStates GetInheritedState(int rowIndex);
+        public virtual DataGridViewCellStyle GetInheritedStyle(DataGridViewCellStyle inheritedCellStyle, int rowIndex, bool includeColors);
+        protected virtual Size GetPreferredSize(Graphics graphics, DataGridViewCellStyle cellStyle, int rowIndex, Size constraintSize);
+        protected virtual Size GetSize(int rowIndex);
+        protected virtual object GetValue(int rowIndex);
+        public virtual void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle);
+        protected virtual bool KeyDownUnsharesRow(KeyEventArgs e, int rowIndex);
+        public virtual bool KeyEntersEditMode(KeyEventArgs e);
+        protected virtual bool KeyPressUnsharesRow(KeyPressEventArgs e, int rowIndex);
+        protected virtual bool KeyUpUnsharesRow(KeyEventArgs e, int rowIndex);
+        protected virtual bool LeaveUnsharesRow(int rowIndex, bool throughMouseClick);
+        public static int MeasureTextHeight(Graphics graphics, string text, Font font, int maxWidth, TextFormatFlags flags);
+        public static int MeasureTextHeight(Graphics graphics, string text, Font font, int maxWidth, TextFormatFlags flags, out bool widthTruncated);
+        public static Size MeasureTextPreferredSize(Graphics graphics, string text, Font font, float maxRatio, TextFormatFlags flags);
+        public static Size MeasureTextSize(Graphics graphics, string text, Font font, TextFormatFlags flags);
+        public static int MeasureTextWidth(Graphics graphics, string text, Font font, int maxHeight, TextFormatFlags flags);
+        protected virtual bool MouseClickUnsharesRow(DataGridViewCellMouseEventArgs e);
+        protected virtual bool MouseDoubleClickUnsharesRow(DataGridViewCellMouseEventArgs e);
+        protected virtual bool MouseDownUnsharesRow(DataGridViewCellMouseEventArgs e);
+        protected virtual bool MouseEnterUnsharesRow(int rowIndex);
+        protected virtual bool MouseLeaveUnsharesRow(int rowIndex);
+        protected virtual bool MouseMoveUnsharesRow(DataGridViewCellMouseEventArgs e);
+        protected virtual bool MouseUpUnsharesRow(DataGridViewCellMouseEventArgs e);
+        protected virtual void OnClick(DataGridViewCellEventArgs e);
+        protected virtual void OnContentClick(DataGridViewCellEventArgs e);
+        protected virtual void OnContentDoubleClick(DataGridViewCellEventArgs e);
+        protected override void OnDataGridViewChanged();
+        protected virtual void OnDoubleClick(DataGridViewCellEventArgs e);
+        protected virtual void OnEnter(int rowIndex, bool throughMouseClick);
+        protected virtual void OnKeyDown(KeyEventArgs e, int rowIndex);
+        protected virtual void OnKeyPress(KeyPressEventArgs e, int rowIndex);
+        protected virtual void OnKeyUp(KeyEventArgs e, int rowIndex);
+        protected virtual void OnLeave(int rowIndex, bool throughMouseClick);
+        protected virtual void OnMouseClick(DataGridViewCellMouseEventArgs e);
+        protected virtual void OnMouseDoubleClick(DataGridViewCellMouseEventArgs e);
+        protected virtual void OnMouseDown(DataGridViewCellMouseEventArgs e);
+        protected virtual void OnMouseEnter(int rowIndex);
+        protected virtual void OnMouseLeave(int rowIndex);
+        protected virtual void OnMouseMove(DataGridViewCellMouseEventArgs e);
+        protected virtual void OnMouseUp(DataGridViewCellMouseEventArgs e);
+        protected virtual void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts);
+        protected virtual void PaintBorder(Graphics graphics, Rectangle clipBounds, Rectangle bounds, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle);
+        protected virtual void PaintErrorIcon(Graphics graphics, Rectangle clipBounds, Rectangle cellValueBounds, string errorText);
+        public virtual object ParseFormattedValue(object formattedValue, DataGridViewCellStyle cellStyle, TypeConverter formattedValueTypeConverter, TypeConverter valueTypeConverter);
+        public virtual void PositionEditingControl(bool setLocation, bool setSize, Rectangle cellBounds, Rectangle cellClip, DataGridViewCellStyle cellStyle, bool singleVerticalBorderAdded, bool singleHorizontalBorderAdded, bool isFirstDisplayedColumn, bool isFirstDisplayedRow);
+        public virtual Rectangle PositionEditingPanel(Rectangle cellBounds, Rectangle cellClip, DataGridViewCellStyle cellStyle, bool singleVerticalBorderAdded, bool singleHorizontalBorderAdded, bool isFirstDisplayedColumn, bool isFirstDisplayedRow);
+        protected virtual bool SetValue(int rowIndex, object value);
+        public override string ToString();
+        protected class DataGridViewCellAccessibleObject : AccessibleObject {
+            public DataGridViewCellAccessibleObject();
+            public DataGridViewCellAccessibleObject(DataGridViewCell owner);
+            public override Rectangle Bounds { get; }
+            public override string DefaultAction { get; }
+            public override string Help { get; }
+            public override string Name { get; }
+            public DataGridViewCell Owner { get; set; }
+            public override AccessibleObject Parent { get; }
+            public override AccessibleRole Role { get; }
+            public override AccessibleStates State { get; }
+            public override string Value { get; set; }
+            public override void DoDefaultAction();
+            public override AccessibleObject GetChild(int index);
+            public override int GetChildCount();
+            public override AccessibleObject GetFocused();
+            public override AccessibleObject GetSelected();
+            public override AccessibleObject Navigate(AccessibleNavigation navigationDirection);
+            public override void Select(AccessibleSelection flags);
+        }
+    }
+    public enum DataGridViewCellBorderStyle {
+        Custom = 0,
+        None = 4,
+        Raised = 2,
+        RaisedHorizontal = 9,
+        RaisedVertical = 6,
+        Single = 1,
+        SingleHorizontal = 8,
+        SingleVertical = 5,
+        Sunken = 3,
+        SunkenHorizontal = 10,
+        SunkenVertical = 7,
+    }
+    public class DataGridViewCellCancelEventArgs : CancelEventArgs {
+        public DataGridViewCellCancelEventArgs(int columnIndex, int rowIndex);
+        public int ColumnIndex { get; }
+        public int RowIndex { get; }
+    }
+    public delegate void DataGridViewCellCancelEventHandler(object sender, DataGridViewCellCancelEventArgs e);
+    public class DataGridViewCellCollection : BaseCollection, ICollection, IEnumerable, IList {
+        public DataGridViewCellCollection(DataGridViewRow dataGridViewRow);
+        protected override ArrayList List { get; }
+        int System.Collections.ICollection.Count { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public DataGridViewCell this[int index] { get; set; }
+        public DataGridViewCell this[string columnName] { get; set; }
+        public event CollectionChangeEventHandler CollectionChanged;
+        public virtual int Add(DataGridViewCell dataGridViewCell);
+        public virtual void AddRange(params DataGridViewCell[] dataGridViewCells);
+        public virtual void Clear();
+        public virtual bool Contains(DataGridViewCell dataGridViewCell);
+        public void CopyTo(DataGridViewCell[] array, int index);
+        public int IndexOf(DataGridViewCell dataGridViewCell);
+        public virtual void Insert(int index, DataGridViewCell dataGridViewCell);
+        protected void OnCollectionChanged(CollectionChangeEventArgs e);
+        public virtual void Remove(DataGridViewCell cell);
+        public virtual void RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        void System.Collections.IList.Clear();
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        void System.Collections.IList.RemoveAt(int index);
+    }
+    public class DataGridViewCellContextMenuStripNeededEventArgs : DataGridViewCellEventArgs {
+        public DataGridViewCellContextMenuStripNeededEventArgs(int columnIndex, int rowIndex);
+        public ContextMenuStrip ContextMenuStrip { get; set; }
+    }
+    public delegate void DataGridViewCellContextMenuStripNeededEventHandler(object sender, DataGridViewCellContextMenuStripNeededEventArgs e);
+    public class DataGridViewCellErrorTextNeededEventArgs : DataGridViewCellEventArgs {
+        public string ErrorText { get; set; }
+    }
+    public delegate void DataGridViewCellErrorTextNeededEventHandler(object sender, DataGridViewCellErrorTextNeededEventArgs e);
+    public class DataGridViewCellEventArgs : EventArgs {
+        public DataGridViewCellEventArgs(int columnIndex, int rowIndex);
+        public int ColumnIndex { get; }
+        public int RowIndex { get; }
+    }
+    public delegate void DataGridViewCellEventHandler(object sender, DataGridViewCellEventArgs e);
+    public class DataGridViewCellFormattingEventArgs : ConvertEventArgs {
+        public DataGridViewCellFormattingEventArgs(int columnIndex, int rowIndex, object value, Type desiredType, DataGridViewCellStyle cellStyle);
+        public DataGridViewCellStyle CellStyle { get; set; }
+        public int ColumnIndex { get; }
+        public bool FormattingApplied { get; set; }
+        public int RowIndex { get; }
+    }
+    public delegate void DataGridViewCellFormattingEventHandler(object sender, DataGridViewCellFormattingEventArgs e);
+    public class DataGridViewCellMouseEventArgs : MouseEventArgs {
+        public DataGridViewCellMouseEventArgs(int columnIndex, int rowIndex, int localX, int localY, MouseEventArgs e);
+        public int ColumnIndex { get; }
+        public int RowIndex { get; }
+    }
+    public delegate void DataGridViewCellMouseEventHandler(object sender, DataGridViewCellMouseEventArgs e);
+    public class DataGridViewCellPaintingEventArgs : HandledEventArgs {
+        public DataGridViewCellPaintingEventArgs(DataGridView dataGridView, Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, int columnIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts);
+        public DataGridViewAdvancedBorderStyle AdvancedBorderStyle { get; }
+        public Rectangle CellBounds { get; }
+        public DataGridViewCellStyle CellStyle { get; }
+        public Rectangle ClipBounds { get; }
+        public int ColumnIndex { get; }
+        public string ErrorText { get; }
+        public object FormattedValue { get; }
+        public Graphics Graphics { get; }
+        public DataGridViewPaintParts PaintParts { get; }
+        public int RowIndex { get; }
+        public DataGridViewElementStates State { get; }
+        public object Value { get; }
+        public void Paint(Rectangle clipBounds, DataGridViewPaintParts paintParts);
+        public void PaintBackground(Rectangle clipBounds, bool cellsPaintSelectionBackground);
+        public void PaintContent(Rectangle clipBounds);
+    }
+    public delegate void DataGridViewCellPaintingEventHandler(object sender, DataGridViewCellPaintingEventArgs e);
+    public class DataGridViewCellParsingEventArgs : ConvertEventArgs {
+        public DataGridViewCellParsingEventArgs(int rowIndex, int columnIndex, object value, Type desiredType, DataGridViewCellStyle inheritedCellStyle);
+        public int ColumnIndex { get; }
+        public DataGridViewCellStyle InheritedCellStyle { get; set; }
+        public bool ParsingApplied { get; set; }
+        public int RowIndex { get; }
+    }
+    public delegate void DataGridViewCellParsingEventHandler(object sender, DataGridViewCellParsingEventArgs e);
+    public class DataGridViewCellStateChangedEventArgs : EventArgs {
+        public DataGridViewCellStateChangedEventArgs(DataGridViewCell dataGridViewCell, DataGridViewElementStates stateChanged);
+        public DataGridViewCell Cell { get; }
+        public DataGridViewElementStates StateChanged { get; }
+    }
+    public delegate void DataGridViewCellStateChangedEventHandler(object sender, DataGridViewCellStateChangedEventArgs e);
+    public class DataGridViewCellStyle : ICloneable {
+        public DataGridViewCellStyle();
+        public DataGridViewCellStyle(DataGridViewCellStyle dataGridViewCellStyle);
+        public DataGridViewContentAlignment Alignment { get; set; }
+        public Color BackColor { get; set; }
+        public object DataSourceNullValue { get; set; }
+        public Font Font { get; set; }
+        public Color ForeColor { get; set; }
+        public string Format { get; set; }
+        public IFormatProvider FormatProvider { get; set; }
+        public bool IsDataSourceNullValueDefault { get; }
+        public bool IsFormatProviderDefault { get; }
+        public bool IsNullValueDefault { get; }
+        public object NullValue { get; set; }
+        public Padding Padding { get; set; }
+        public Color SelectionBackColor { get; set; }
+        public Color SelectionForeColor { get; set; }
+        public object Tag { get; set; }
+        public DataGridViewTriState WrapMode { get; set; }
+        public virtual void ApplyStyle(DataGridViewCellStyle dataGridViewCellStyle);
+        public virtual DataGridViewCellStyle Clone();
+        public override bool Equals(object o);
+        public override int GetHashCode();
+        object System.ICloneable.Clone();
+        public override string ToString();
+    }
+    public class DataGridViewCellStyleContentChangedEventArgs : EventArgs {
+        public DataGridViewCellStyle CellStyle { get; }
+        public DataGridViewCellStyleScopes CellStyleScope { get; }
+    }
+    public delegate void DataGridViewCellStyleContentChangedEventHandler(object sender, DataGridViewCellStyleContentChangedEventArgs e);
+    public class DataGridViewCellStyleConverter : TypeConverter {
+        public DataGridViewCellStyleConverter();
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public enum DataGridViewCellStyleScopes {
+        AlternatingRows = 128,
+        Cell = 1,
+        Column = 2,
+        ColumnHeaders = 16,
+        DataGridView = 8,
+        None = 0,
+        Row = 4,
+        RowHeaders = 32,
+        Rows = 64,
+    }
+    public class DataGridViewCellToolTipTextNeededEventArgs : DataGridViewCellEventArgs {
+        public string ToolTipText { get; set; }
+    }
+    public delegate void DataGridViewCellToolTipTextNeededEventHandler(object sender, DataGridViewCellToolTipTextNeededEventArgs e);
+    public class DataGridViewCellValidatingEventArgs : CancelEventArgs {
+        public int ColumnIndex { get; }
+        public object FormattedValue { get; }
+        public int RowIndex { get; }
+    }
+    public delegate void DataGridViewCellValidatingEventHandler(object sender, DataGridViewCellValidatingEventArgs e);
+    public class DataGridViewCellValueEventArgs : EventArgs {
+        public DataGridViewCellValueEventArgs(int columnIndex, int rowIndex);
+        public int ColumnIndex { get; }
+        public int RowIndex { get; }
+        public object Value { get; set; }
+    }
+    public delegate void DataGridViewCellValueEventHandler(object sender, DataGridViewCellValueEventArgs e);
+    public class DataGridViewCheckBoxCell : DataGridViewCell, IDataGridViewEditingCell {
+        public DataGridViewCheckBoxCell();
+        public DataGridViewCheckBoxCell(bool threeState);
+        public virtual object EditingCellFormattedValue { get; set; }
+        public virtual bool EditingCellValueChanged { get; set; }
+        public override Type EditType { get; }
+        public object FalseValue { get; set; }
+        public FlatStyle FlatStyle { get; set; }
+        public override Type FormattedValueType { get; }
+        public object IndeterminateValue { get; set; }
+        public bool ThreeState { get; set; }
+        public object TrueValue { get; set; }
+        public override Type ValueType { get; set; }
+        public override object Clone();
+        protected override bool ContentClickUnsharesRow(DataGridViewCellEventArgs e);
+        protected override bool ContentDoubleClickUnsharesRow(DataGridViewCellEventArgs e);
+        protected override AccessibleObject CreateAccessibilityInstance();
+        protected override Rectangle GetContentBounds(Graphics graphics, DataGridViewCellStyle cellStyle, int rowIndex);
+        public virtual object GetEditingCellFormattedValue(DataGridViewDataErrorContexts context);
+        protected override Rectangle GetErrorIconBounds(Graphics graphics, DataGridViewCellStyle cellStyle, int rowIndex);
+        protected override object GetFormattedValue(object value, int rowIndex, ref DataGridViewCellStyle cellStyle, TypeConverter valueTypeConverter, TypeConverter formattedValueTypeConverter, DataGridViewDataErrorContexts context);
+        protected override Size GetPreferredSize(Graphics graphics, DataGridViewCellStyle cellStyle, int rowIndex, Size constraintSize);
+        protected override bool KeyDownUnsharesRow(KeyEventArgs e, int rowIndex);
+        protected override bool KeyUpUnsharesRow(KeyEventArgs e, int rowIndex);
+        protected override bool MouseDownUnsharesRow(DataGridViewCellMouseEventArgs e);
+        protected override bool MouseEnterUnsharesRow(int rowIndex);
+        protected override bool MouseLeaveUnsharesRow(int rowIndex);
+        protected override bool MouseUpUnsharesRow(DataGridViewCellMouseEventArgs e);
+        protected override void OnContentClick(DataGridViewCellEventArgs e);
+        protected override void OnContentDoubleClick(DataGridViewCellEventArgs e);
+        protected override void OnKeyDown(KeyEventArgs e, int rowIndex);
+        protected override void OnKeyUp(KeyEventArgs e, int rowIndex);
+        protected override void OnLeave(int rowIndex, bool throughMouseClick);
+        protected override void OnMouseDown(DataGridViewCellMouseEventArgs e);
+        protected override void OnMouseLeave(int rowIndex);
+        protected override void OnMouseMove(DataGridViewCellMouseEventArgs e);
+        protected override void OnMouseUp(DataGridViewCellMouseEventArgs e);
+        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates elementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts);
+        public override object ParseFormattedValue(object formattedValue, DataGridViewCellStyle cellStyle, TypeConverter formattedValueTypeConverter, TypeConverter valueTypeConverter);
+        public virtual void PrepareEditingCellForEdit(bool selectAll);
+        public override string ToString();
+        protected class DataGridViewCheckBoxCellAccessibleObject : DataGridViewCell.DataGridViewCellAccessibleObject {
+            public DataGridViewCheckBoxCellAccessibleObject(DataGridViewCell owner);
+            public override string DefaultAction { get; }
+            public override AccessibleStates State { get; }
+            public override void DoDefaultAction();
+            public override int GetChildCount();
+        }
+    }
+    public class DataGridViewCheckBoxColumn : DataGridViewColumn {
+        public DataGridViewCheckBoxColumn();
+        public DataGridViewCheckBoxColumn(bool threeState);
+        public override DataGridViewCell CellTemplate { get; set; }
+        public override DataGridViewCellStyle DefaultCellStyle { get; set; }
+        public object FalseValue { get; set; }
+        public FlatStyle FlatStyle { get; set; }
+        public object IndeterminateValue { get; set; }
+        public bool ThreeState { get; set; }
+        public object TrueValue { get; set; }
+        public override string ToString();
+    }
+    public enum DataGridViewClipboardCopyMode {
+        Disable = 0,
+        EnableAlwaysIncludeHeaderText = 3,
+        EnableWithAutoHeaderText = 1,
+        EnableWithoutHeaderText = 2,
+    }
+    public class DataGridViewColumn : DataGridViewBand, IComponent, IDisposable {
+        public DataGridViewColumn();
+        public DataGridViewColumn(DataGridViewCell cellTemplate);
+        public DataGridViewAutoSizeColumnMode AutoSizeMode { get; set; }
+        public virtual DataGridViewCell CellTemplate { get; set; }
+        public Type CellType { get; }
+        public override ContextMenuStrip ContextMenuStrip { get; set; }
+        public string DataPropertyName { get; set; }
+        public override DataGridViewCellStyle DefaultCellStyle { get; set; }
+        public int DisplayIndex { get; set; }
+        public int DividerWidth { get; set; }
+        public float FillWeight { get; set; }
+        public override bool Frozen { get; set; }
+        public DataGridViewColumnHeaderCell HeaderCell { get; set; }
+        public string HeaderText { get; set; }
+        public DataGridViewAutoSizeColumnMode InheritedAutoSizeMode { get; }
+        public override DataGridViewCellStyle InheritedStyle { get; }
+        public bool IsDataBound { get; }
+        public int MinimumWidth { get; set; }
+        public string Name { get; set; }
+        public override bool ReadOnly { get; set; }
+        public override DataGridViewTriState Resizable { get; set; }
+        public ISite Site { get; set; }
+        public DataGridViewColumnSortMode SortMode { get; set; }
+        public string ToolTipText { get; set; }
+        public Type ValueType { get; set; }
+        public override bool Visible { get; set; }
+        public int Width { get; set; }
+        public event EventHandler Disposed;
+        public override object Clone();
+        protected override void Dispose(bool disposing);
+        public virtual int GetPreferredWidth(DataGridViewAutoSizeColumnMode autoSizeColumnMode, bool fixedHeight);
+        public override string ToString();
+    }
+    public class DataGridViewColumnCollection : BaseCollection, ICollection, IEnumerable, IList {
+        public DataGridViewColumnCollection(DataGridView dataGridView);
+        protected DataGridView DataGridView { get; }
+        protected override ArrayList List { get; }
+        int System.Collections.ICollection.Count { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public DataGridViewColumn this[int index] { get; }
+        public DataGridViewColumn this[string columnName] { get; }
+        public event CollectionChangeEventHandler CollectionChanged;
+        public virtual int Add(string columnName, string headerText);
+        public virtual int Add(DataGridViewColumn dataGridViewColumn);
+        public virtual void AddRange(params DataGridViewColumn[] dataGridViewColumns);
+        public virtual void Clear();
+        public virtual bool Contains(string columnName);
+        public virtual bool Contains(DataGridViewColumn dataGridViewColumn);
+        public void CopyTo(DataGridViewColumn[] array, int index);
+        public int GetColumnCount(DataGridViewElementStates includeFilter);
+        public int GetColumnsWidth(DataGridViewElementStates includeFilter);
+        public DataGridViewColumn GetFirstColumn(DataGridViewElementStates includeFilter);
+        public DataGridViewColumn GetFirstColumn(DataGridViewElementStates includeFilter, DataGridViewElementStates excludeFilter);
+        public DataGridViewColumn GetLastColumn(DataGridViewElementStates includeFilter, DataGridViewElementStates excludeFilter);
+        public DataGridViewColumn GetNextColumn(DataGridViewColumn dataGridViewColumnStart, DataGridViewElementStates includeFilter, DataGridViewElementStates excludeFilter);
+        public DataGridViewColumn GetPreviousColumn(DataGridViewColumn dataGridViewColumnStart, DataGridViewElementStates includeFilter, DataGridViewElementStates excludeFilter);
+        public int IndexOf(DataGridViewColumn dataGridViewColumn);
+        public virtual void Insert(int columnIndex, DataGridViewColumn dataGridViewColumn);
+        protected virtual void OnCollectionChanged(CollectionChangeEventArgs e);
+        public virtual void Remove(string columnName);
+        public virtual void Remove(DataGridViewColumn dataGridViewColumn);
+        public virtual void RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        void System.Collections.IList.Clear();
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        void System.Collections.IList.RemoveAt(int index);
+    }
+    public sealed class DataGridViewColumnDesignTimeVisibleAttribute : Attribute {
+        public static readonly DataGridViewColumnDesignTimeVisibleAttribute Default;
+        public static readonly DataGridViewColumnDesignTimeVisibleAttribute No;
+        public static readonly DataGridViewColumnDesignTimeVisibleAttribute Yes;
+        public DataGridViewColumnDesignTimeVisibleAttribute();
+        public DataGridViewColumnDesignTimeVisibleAttribute(bool visible);
+        public bool Visible { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public override bool IsDefaultAttribute();
+    }
+    public class DataGridViewColumnDividerDoubleClickEventArgs : HandledMouseEventArgs {
+        public DataGridViewColumnDividerDoubleClickEventArgs(int columnIndex, HandledMouseEventArgs e);
+        public int ColumnIndex { get; }
+    }
+    public delegate void DataGridViewColumnDividerDoubleClickEventHandler(object sender, DataGridViewColumnDividerDoubleClickEventArgs e);
+    public class DataGridViewColumnEventArgs : EventArgs {
+        public DataGridViewColumnEventArgs(DataGridViewColumn dataGridViewColumn);
+        public DataGridViewColumn Column { get; }
+    }
+    public delegate void DataGridViewColumnEventHandler(object sender, DataGridViewColumnEventArgs e);
+    public class DataGridViewColumnHeaderCell : DataGridViewHeaderCell {
+        public DataGridViewColumnHeaderCell();
+        public SortOrder SortGlyphDirection { get; set; }
+        public override object Clone();
+        protected override AccessibleObject CreateAccessibilityInstance();
+        protected override object GetClipboardContent(int rowIndex, bool firstCell, bool lastCell, bool inFirstRow, bool inLastRow, string format);
+        protected override Rectangle GetContentBounds(Graphics graphics, DataGridViewCellStyle cellStyle, int rowIndex);
+        public override ContextMenuStrip GetInheritedContextMenuStrip(int rowIndex);
+        public override DataGridViewCellStyle GetInheritedStyle(DataGridViewCellStyle inheritedCellStyle, int rowIndex, bool includeColors);
+        protected override Size GetPreferredSize(Graphics graphics, DataGridViewCellStyle cellStyle, int rowIndex, Size constraintSize);
+        protected override object GetValue(int rowIndex);
+        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates dataGridViewElementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts);
+        protected override bool SetValue(int rowIndex, object value);
+        public override string ToString();
+        protected class DataGridViewColumnHeaderCellAccessibleObject : DataGridViewCell.DataGridViewCellAccessibleObject {
+            public DataGridViewColumnHeaderCellAccessibleObject(DataGridViewColumnHeaderCell owner);
+            public override Rectangle Bounds { get; }
+            public override string DefaultAction { get; }
+            public override string Name { get; }
+            public override AccessibleObject Parent { get; }
+            public override AccessibleRole Role { get; }
+            public override AccessibleStates State { get; }
+            public override string Value { get; }
+            public override void DoDefaultAction();
+            public override AccessibleObject Navigate(AccessibleNavigation navigationDirection);
+            public override void Select(AccessibleSelection flags);
+        }
+    }
+    public enum DataGridViewColumnHeadersHeightSizeMode {
+        AutoSize = 2,
+        DisableResizing = 1,
+        EnableResizing = 0,
+    }
+    public enum DataGridViewColumnSortMode {
+        Automatic = 1,
+        NotSortable = 0,
+        Programmatic = 2,
+    }
+    public class DataGridViewColumnStateChangedEventArgs : EventArgs {
+        public DataGridViewColumnStateChangedEventArgs(DataGridViewColumn dataGridViewColumn, DataGridViewElementStates stateChanged);
+        public DataGridViewColumn Column { get; }
+        public DataGridViewElementStates StateChanged { get; }
+    }
+    public delegate void DataGridViewColumnStateChangedEventHandler(object sender, DataGridViewColumnStateChangedEventArgs e);
+    public class DataGridViewComboBoxCell : DataGridViewCell {
+        public DataGridViewComboBoxCell();
+        public virtual bool AutoComplete { get; set; }
+        public virtual object DataSource { get; set; }
+        public virtual string DisplayMember { get; set; }
+        public DataGridViewComboBoxDisplayStyle DisplayStyle { get; set; }
+        public bool DisplayStyleForCurrentCellOnly { get; set; }
+        public virtual int DropDownWidth { get; set; }
+        public override Type EditType { get; }
+        public FlatStyle FlatStyle { get; set; }
+        public override Type FormattedValueType { get; }
+        public virtual DataGridViewComboBoxCell.ObjectCollection Items { get; }
+        public virtual int MaxDropDownItems { get; set; }
+        public virtual bool Sorted { get; set; }
+        public virtual string ValueMember { get; set; }
+        public override Type ValueType { get; }
+        public override object Clone();
+        public override void DetachEditingControl();
+        protected override Rectangle GetContentBounds(Graphics graphics, DataGridViewCellStyle cellStyle, int rowIndex);
+        protected override Rectangle GetErrorIconBounds(Graphics graphics, DataGridViewCellStyle cellStyle, int rowIndex);
+        protected override object GetFormattedValue(object value, int rowIndex, ref DataGridViewCellStyle cellStyle, TypeConverter valueTypeConverter, TypeConverter formattedValueTypeConverter, DataGridViewDataErrorContexts context);
+        protected override Size GetPreferredSize(Graphics graphics, DataGridViewCellStyle cellStyle, int rowIndex, Size constraintSize);
+        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle);
+        public override bool KeyEntersEditMode(KeyEventArgs e);
+        protected override void OnDataGridViewChanged();
+        protected override void OnEnter(int rowIndex, bool throughMouseClick);
+        protected override void OnLeave(int rowIndex, bool throughMouseClick);
+        protected override void OnMouseClick(DataGridViewCellMouseEventArgs e);
+        protected override void OnMouseEnter(int rowIndex);
+        protected override void OnMouseLeave(int rowIndex);
+        protected override void OnMouseMove(DataGridViewCellMouseEventArgs e);
+        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates elementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts);
+        public override object ParseFormattedValue(object formattedValue, DataGridViewCellStyle cellStyle, TypeConverter formattedValueTypeConverter, TypeConverter valueTypeConverter);
+        public override string ToString();
+        public class ObjectCollection : ICollection, IEnumerable, IList {
+            public ObjectCollection(DataGridViewComboBoxCell owner);
+            public int Count { get; }
+            public bool IsReadOnly { get; }
+            bool System.Collections.ICollection.IsSynchronized { get; }
+            object System.Collections.ICollection.SyncRoot { get; }
+            bool System.Collections.IList.IsFixedSize { get; }
+            public virtual object this[int index] { get; set; }
+            public int Add(object item);
+            public void AddRange(DataGridViewComboBoxCell.ObjectCollection value);
+            public void AddRange(params object[] items);
+            public void Clear();
+            public bool Contains(object value);
+            public void CopyTo(object[] destination, int arrayIndex);
+            public IEnumerator GetEnumerator();
+            public int IndexOf(object value);
+            public void Insert(int index, object item);
+            public void Remove(object value);
+            public void RemoveAt(int index);
+            void System.Collections.ICollection.CopyTo(Array destination, int index);
+            int System.Collections.IList.Add(object item);
+        }
+    }
+    public class DataGridViewComboBoxColumn : DataGridViewColumn {
+        public DataGridViewComboBoxColumn();
+        public bool AutoComplete { get; set; }
+        public override DataGridViewCell CellTemplate { get; set; }
+        public object DataSource { get; set; }
+        public string DisplayMember { get; set; }
+        public DataGridViewComboBoxDisplayStyle DisplayStyle { get; set; }
+        public bool DisplayStyleForCurrentCellOnly { get; set; }
+        public int DropDownWidth { get; set; }
+        public FlatStyle FlatStyle { get; set; }
+        public DataGridViewComboBoxCell.ObjectCollection Items { get; }
+        public int MaxDropDownItems { get; set; }
+        public bool Sorted { get; set; }
+        public string ValueMember { get; set; }
+        public override object Clone();
+        public override string ToString();
+    }
+    public enum DataGridViewComboBoxDisplayStyle {
+        ComboBox = 0,
+        DropDownButton = 1,
+        Nothing = 2,
+    }
+    public class DataGridViewComboBoxEditingControl : ComboBox, IDataGridViewEditingControl {
+        public DataGridViewComboBoxEditingControl();
+        public virtual DataGridView EditingControlDataGridView { get; set; }
+        public virtual object EditingControlFormattedValue { get; set; }
+        public virtual int EditingControlRowIndex { get; set; }
+        public virtual bool EditingControlValueChanged { get; set; }
+        public virtual Cursor EditingPanelCursor { get; }
+        public virtual bool RepositionEditingControlOnValueChange { get; }
+        public virtual void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle);
+        public virtual bool EditingControlWantsInputKey(Keys keyData, bool dataGridViewWantsInputKey);
+        public virtual object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context);
+        protected override void OnSelectedIndexChanged(EventArgs e);
+        public virtual void PrepareEditingControlForEdit(bool selectAll);
+    }
+    public enum DataGridViewContentAlignment {
+        BottomCenter = 512,
+        BottomLeft = 256,
+        BottomRight = 1024,
+        MiddleCenter = 32,
+        MiddleLeft = 16,
+        MiddleRight = 64,
+        NotSet = 0,
+        TopCenter = 2,
+        TopLeft = 1,
+        TopRight = 4,
+    }
+    public enum DataGridViewDataErrorContexts {
+        ClipboardContent = 16384,
+        Commit = 512,
+        CurrentCellChange = 4096,
+        Display = 2,
+        Formatting = 1,
+        InitialValueRestoration = 1024,
+        LeaveControl = 2048,
+        Parsing = 256,
+        PreferredSize = 4,
+        RowDeletion = 8,
+        Scroll = 8192,
+    }
+    public class DataGridViewDataErrorEventArgs : DataGridViewCellCancelEventArgs {
+        public DataGridViewDataErrorEventArgs(Exception exception, int columnIndex, int rowIndex, DataGridViewDataErrorContexts context);
+        public DataGridViewDataErrorContexts Context { get; }
+        public Exception Exception { get; }
+        public bool ThrowException { get; set; }
+    }
+    public delegate void DataGridViewDataErrorEventHandler(object sender, DataGridViewDataErrorEventArgs e);
+    public class DataGridViewEditingControlShowingEventArgs : EventArgs {
+        public DataGridViewEditingControlShowingEventArgs(Control control, DataGridViewCellStyle cellStyle);
+        public DataGridViewCellStyle CellStyle { get; set; }
+        public Control Control { get; }
+    }
+    public delegate void DataGridViewEditingControlShowingEventHandler(object sender, DataGridViewEditingControlShowingEventArgs e);
+    public enum DataGridViewEditMode {
+        EditOnEnter = 0,
+        EditOnF2 = 3,
+        EditOnKeystroke = 1,
+        EditOnKeystrokeOrF2 = 2,
+        EditProgrammatically = 4,
+    }
+    public class DataGridViewElement {
+        public DataGridViewElement();
+        public DataGridView DataGridView { get; }
+        public virtual DataGridViewElementStates State { get; }
+        protected virtual void OnDataGridViewChanged();
+        protected void RaiseCellClick(DataGridViewCellEventArgs e);
+        protected void RaiseCellContentClick(DataGridViewCellEventArgs e);
+        protected void RaiseCellContentDoubleClick(DataGridViewCellEventArgs e);
+        protected void RaiseCellValueChanged(DataGridViewCellEventArgs e);
+        protected void RaiseDataError(DataGridViewDataErrorEventArgs e);
+        protected void RaiseMouseWheel(MouseEventArgs e);
+    }
+    public enum DataGridViewElementStates {
+        Displayed = 1,
+        Frozen = 2,
+        None = 0,
+        ReadOnly = 4,
+        Resizable = 8,
+        ResizableSet = 16,
+        Selected = 32,
+        Visible = 64,
+    }
+    public enum DataGridViewHeaderBorderStyle {
+        Custom = 0,
+        None = 4,
+        Raised = 2,
+        Single = 1,
+        Sunken = 3,
+    }
+    public class DataGridViewHeaderCell : DataGridViewCell {
+        public DataGridViewHeaderCell();
+        protected ButtonState ButtonState { get; }
+        public override bool Displayed { get; }
+        public override Type FormattedValueType { get; }
+        public override bool Frozen { get; }
+        public override bool ReadOnly { get; set; }
+        public override bool Resizable { get; }
+        public override bool Selected { get; set; }
+        public override Type ValueType { get; set; }
+        public override bool Visible { get; }
+        public override object Clone();
+        protected override void Dispose(bool disposing);
+        public override ContextMenuStrip GetInheritedContextMenuStrip(int rowIndex);
+        public override DataGridViewElementStates GetInheritedState(int rowIndex);
+        protected override Size GetSize(int rowIndex);
+        protected override object GetValue(int rowIndex);
+        protected override bool MouseDownUnsharesRow(DataGridViewCellMouseEventArgs e);
+        protected override bool MouseEnterUnsharesRow(int rowIndex);
+        protected override bool MouseLeaveUnsharesRow(int rowIndex);
+        protected override bool MouseUpUnsharesRow(DataGridViewCellMouseEventArgs e);
+        protected override void OnMouseDown(DataGridViewCellMouseEventArgs e);
+        protected override void OnMouseEnter(int rowIndex);
+        protected override void OnMouseLeave(int rowIndex);
+        protected override void OnMouseUp(DataGridViewCellMouseEventArgs e);
+        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates dataGridViewElementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts);
+        public override string ToString();
+    }
+    public enum DataGridViewHitTestType {
+        Cell = 1,
+        ColumnHeader = 2,
+        HorizontalScrollBar = 5,
+        None = 0,
+        RowHeader = 3,
+        TopLeftHeader = 4,
+        VerticalScrollBar = 6,
+    }
+    public class DataGridViewImageCell : DataGridViewCell {
+        public DataGridViewImageCell();
+        public DataGridViewImageCell(bool valueIsIcon);
+        public override object DefaultNewRowValue { get; }
+        public string Description { get; set; }
+        public override Type EditType { get; }
+        public override Type FormattedValueType { get; }
+        public DataGridViewImageCellLayout ImageLayout { get; set; }
+        public bool ValueIsIcon { get; set; }
+        public override Type ValueType { get; set; }
+        public override object Clone();
+        protected override AccessibleObject CreateAccessibilityInstance();
+        protected override Rectangle GetContentBounds(Graphics graphics, DataGridViewCellStyle cellStyle, int rowIndex);
+        protected override Rectangle GetErrorIconBounds(Graphics graphics, DataGridViewCellStyle cellStyle, int rowIndex);
+        protected override object GetFormattedValue(object value, int rowIndex, ref DataGridViewCellStyle cellStyle, TypeConverter valueTypeConverter, TypeConverter formattedValueTypeConverter, DataGridViewDataErrorContexts context);
+        protected override Size GetPreferredSize(Graphics graphics, DataGridViewCellStyle cellStyle, int rowIndex, Size constraintSize);
+        protected override object GetValue(int rowIndex);
+        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates elementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts);
+        public override string ToString();
+        protected class DataGridViewImageCellAccessibleObject : DataGridViewCell.DataGridViewCellAccessibleObject {
+            public DataGridViewImageCellAccessibleObject(DataGridViewCell owner);
+            public override string DefaultAction { get; }
+            public override string Description { get; }
+            public override string Value { get; set; }
+            public override void DoDefaultAction();
+            public override int GetChildCount();
+        }
+    }
+    public enum DataGridViewImageCellLayout {
+        Normal = 1,
+        NotSet = 0,
+        Stretch = 2,
+        Zoom = 3,
+    }
+    public class DataGridViewImageColumn : DataGridViewColumn {
+        public DataGridViewImageColumn();
+        public DataGridViewImageColumn(bool valuesAreIcons);
+        public override DataGridViewCell CellTemplate { get; set; }
+        public override DataGridViewCellStyle DefaultCellStyle { get; set; }
+        public string Description { get; set; }
+        public Icon Icon { get; set; }
+        public Image Image { get; set; }
+        public DataGridViewImageCellLayout ImageLayout { get; set; }
+        public bool ValuesAreIcons { get; set; }
+        public override object Clone();
+        public override string ToString();
+    }
+    public class DataGridViewLinkCell : DataGridViewCell {
+        public DataGridViewLinkCell();
+        public Color ActiveLinkColor { get; set; }
+        public override Type EditType { get; }
+        public override Type FormattedValueType { get; }
+        public LinkBehavior LinkBehavior { get; set; }
+        public Color LinkColor { get; set; }
+        public bool LinkVisited { get; set; }
+        public bool TrackVisitedState { get; set; }
+        public bool UseColumnTextForLinkValue { get; set; }
+        public override Type ValueType { get; }
+        public Color VisitedLinkColor { get; set; }
+        public override object Clone();
+        protected override AccessibleObject CreateAccessibilityInstance();
+        protected override Rectangle GetContentBounds(Graphics graphics, DataGridViewCellStyle cellStyle, int rowIndex);
+        protected override Rectangle GetErrorIconBounds(Graphics graphics, DataGridViewCellStyle cellStyle, int rowIndex);
+        protected override Size GetPreferredSize(Graphics graphics, DataGridViewCellStyle cellStyle, int rowIndex, Size constraintSize);
+        protected override object GetValue(int rowIndex);
+        protected override bool KeyUpUnsharesRow(KeyEventArgs e, int rowIndex);
+        protected override bool MouseDownUnsharesRow(DataGridViewCellMouseEventArgs e);
+        protected override bool MouseLeaveUnsharesRow(int rowIndex);
+        protected override bool MouseMoveUnsharesRow(DataGridViewCellMouseEventArgs e);
+        protected override bool MouseUpUnsharesRow(DataGridViewCellMouseEventArgs e);
+        protected override void OnKeyUp(KeyEventArgs e, int rowIndex);
+        protected override void OnMouseDown(DataGridViewCellMouseEventArgs e);
+        protected override void OnMouseLeave(int rowIndex);
+        protected override void OnMouseMove(DataGridViewCellMouseEventArgs e);
+        protected override void OnMouseUp(DataGridViewCellMouseEventArgs e);
+        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts);
+        public override string ToString();
+        protected class DataGridViewLinkCellAccessibleObject : DataGridViewCell.DataGridViewCellAccessibleObject {
+            public DataGridViewLinkCellAccessibleObject(DataGridViewCell owner);
+            public override string DefaultAction { get; }
+            public override void DoDefaultAction();
+            public override int GetChildCount();
+        }
+    }
+    public class DataGridViewLinkColumn : DataGridViewColumn {
+        public DataGridViewLinkColumn();
+        public Color ActiveLinkColor { get; set; }
+        public override DataGridViewCell CellTemplate { get; set; }
+        public LinkBehavior LinkBehavior { get; set; }
+        public Color LinkColor { get; set; }
+        public string Text { get; set; }
+        public bool TrackVisitedState { get; set; }
+        public bool UseColumnTextForLinkValue { get; set; }
+        public Color VisitedLinkColor { get; set; }
+        public override object Clone();
+        public override string ToString();
+    }
+    public enum DataGridViewPaintParts {
+        All = 127,
+        Background = 1,
+        Border = 2,
+        ContentBackground = 4,
+        ContentForeground = 8,
+        ErrorIcon = 16,
+        Focus = 32,
+        None = 0,
+        SelectionBackground = 64,
+    }
+    public class DataGridViewRow : DataGridViewBand {
+        public DataGridViewRow();
+        public AccessibleObject AccessibilityObject { get; }
+        public DataGridViewCellCollection Cells { get; }
+        public override ContextMenuStrip ContextMenuStrip { get; set; }
+        public object DataBoundItem { get; }
+        public override DataGridViewCellStyle DefaultCellStyle { get; set; }
+        public override bool Displayed { get; }
+        public int DividerHeight { get; set; }
+        public string ErrorText { get; set; }
+        public override bool Frozen { get; set; }
+        public DataGridViewRowHeaderCell HeaderCell { get; set; }
+        public int Height { get; set; }
+        public override DataGridViewCellStyle InheritedStyle { get; }
+        public bool IsNewRow { get; }
+        public int MinimumHeight { get; set; }
+        public override bool ReadOnly { get; set; }
+        public override DataGridViewTriState Resizable { get; set; }
+        public override bool Selected { get; set; }
+        public override DataGridViewElementStates State { get; }
+        public override bool Visible { get; set; }
+        public virtual DataGridViewAdvancedBorderStyle AdjustRowHeaderBorderStyle(DataGridViewAdvancedBorderStyle dataGridViewAdvancedBorderStyleInput, DataGridViewAdvancedBorderStyle dataGridViewAdvancedBorderStylePlaceholder, bool singleVerticalBorderAdded, bool singleHorizontalBorderAdded, bool isFirstDisplayedRow, bool isLastVisibleRow);
+        public override object Clone();
+        protected virtual AccessibleObject CreateAccessibilityInstance();
+        public void CreateCells(DataGridView dataGridView);
+        public void CreateCells(DataGridView dataGridView, params object[] values);
+        protected virtual DataGridViewCellCollection CreateCellsInstance();
+        protected internal virtual void DrawFocus(Graphics graphics, Rectangle clipBounds, Rectangle bounds, int rowIndex, DataGridViewElementStates rowState, DataGridViewCellStyle cellStyle, bool cellsPaintSelectionBackground);
+        public ContextMenuStrip GetContextMenuStrip(int rowIndex);
+        public string GetErrorText(int rowIndex);
+        public virtual int GetPreferredHeight(int rowIndex, DataGridViewAutoSizeRowMode autoSizeRowMode, bool fixedWidth);
+        public virtual DataGridViewElementStates GetState(int rowIndex);
+        protected internal virtual void Paint(Graphics graphics, Rectangle clipBounds, Rectangle rowBounds, int rowIndex, DataGridViewElementStates rowState, bool isFirstDisplayedRow, bool isLastVisibleRow);
+        protected internal virtual void PaintCells(Graphics graphics, Rectangle clipBounds, Rectangle rowBounds, int rowIndex, DataGridViewElementStates rowState, bool isFirstDisplayedRow, bool isLastVisibleRow, DataGridViewPaintParts paintParts);
+        protected internal virtual void PaintHeader(Graphics graphics, Rectangle clipBounds, Rectangle rowBounds, int rowIndex, DataGridViewElementStates rowState, bool isFirstDisplayedRow, bool isLastVisibleRow, DataGridViewPaintParts paintParts);
+        public bool SetValues(params object[] values);
+        public override string ToString();
+        protected class DataGridViewRowAccessibleObject : AccessibleObject {
+            public DataGridViewRowAccessibleObject();
+            public DataGridViewRowAccessibleObject(DataGridViewRow owner);
+            public override Rectangle Bounds { get; }
+            public override string Name { get; }
+            public DataGridViewRow Owner { get; set; }
+            public override AccessibleObject Parent { get; }
+            public override AccessibleRole Role { get; }
+            public override AccessibleStates State { get; }
+            public override string Value { get; }
+            public override AccessibleObject GetChild(int index);
+            public override int GetChildCount();
+            public override AccessibleObject GetFocused();
+            public override AccessibleObject GetSelected();
+            public override AccessibleObject Navigate(AccessibleNavigation navigationDirection);
+            public override void Select(AccessibleSelection flags);
+        }
+    }
+    public class DataGridViewRowCancelEventArgs : CancelEventArgs {
+        public DataGridViewRowCancelEventArgs(DataGridViewRow dataGridViewRow);
+        public DataGridViewRow Row { get; }
+    }
+    public delegate void DataGridViewRowCancelEventHandler(object sender, DataGridViewRowCancelEventArgs e);
+    public class DataGridViewRowCollection : ICollection, IEnumerable, IList {
+        public DataGridViewRowCollection(DataGridView dataGridView);
+        public int Count { get; }
+        protected DataGridView DataGridView { get; }
+        protected ArrayList List { get; }
+        int System.Collections.ICollection.Count { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public DataGridViewRow this[int index] { get; }
+        public event CollectionChangeEventHandler CollectionChanged;
+        public virtual int Add();
+        public virtual int Add(int count);
+        public virtual int Add(params object[] values);
+        public virtual int Add(DataGridViewRow dataGridViewRow);
+        public virtual int AddCopies(int indexSource, int count);
+        public virtual int AddCopy(int indexSource);
+        public virtual void AddRange(params DataGridViewRow[] dataGridViewRows);
+        public virtual void Clear();
+        public virtual bool Contains(DataGridViewRow dataGridViewRow);
+        public void CopyTo(DataGridViewRow[] array, int index);
+        public int GetFirstRow(DataGridViewElementStates includeFilter);
+        public int GetFirstRow(DataGridViewElementStates includeFilter, DataGridViewElementStates excludeFilter);
+        public int GetLastRow(DataGridViewElementStates includeFilter);
+        public int GetNextRow(int indexStart, DataGridViewElementStates includeFilter);
+        public int GetNextRow(int indexStart, DataGridViewElementStates includeFilter, DataGridViewElementStates excludeFilter);
+        public int GetPreviousRow(int indexStart, DataGridViewElementStates includeFilter);
+        public int GetPreviousRow(int indexStart, DataGridViewElementStates includeFilter, DataGridViewElementStates excludeFilter);
+        public int GetRowCount(DataGridViewElementStates includeFilter);
+        public int GetRowsHeight(DataGridViewElementStates includeFilter);
+        public virtual DataGridViewElementStates GetRowState(int rowIndex);
+        public int IndexOf(DataGridViewRow dataGridViewRow);
+        public virtual void Insert(int rowIndex, int count);
+        public virtual void Insert(int rowIndex, params object[] values);
+        public virtual void Insert(int rowIndex, DataGridViewRow dataGridViewRow);
+        public virtual void InsertCopies(int indexSource, int indexDestination, int count);
+        public virtual void InsertCopy(int indexSource, int indexDestination);
+        public virtual void InsertRange(int rowIndex, params DataGridViewRow[] dataGridViewRows);
+        protected virtual void OnCollectionChanged(CollectionChangeEventArgs e);
+        public virtual void Remove(DataGridViewRow dataGridViewRow);
+        public virtual void RemoveAt(int index);
+        public DataGridViewRow SharedRow(int rowIndex);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        void System.Collections.IList.Clear();
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        void System.Collections.IList.RemoveAt(int index);
+    }
+    public class DataGridViewRowContextMenuStripNeededEventArgs : EventArgs {
+        public DataGridViewRowContextMenuStripNeededEventArgs(int rowIndex);
+        public ContextMenuStrip ContextMenuStrip { get; set; }
+        public int RowIndex { get; }
+    }
+    public delegate void DataGridViewRowContextMenuStripNeededEventHandler(object sender, DataGridViewRowContextMenuStripNeededEventArgs e);
+    public class DataGridViewRowDividerDoubleClickEventArgs : HandledMouseEventArgs {
+        public DataGridViewRowDividerDoubleClickEventArgs(int rowIndex, HandledMouseEventArgs e);
+        public int RowIndex { get; }
+    }
+    public delegate void DataGridViewRowDividerDoubleClickEventHandler(object sender, DataGridViewRowDividerDoubleClickEventArgs e);
+    public class DataGridViewRowErrorTextNeededEventArgs : EventArgs {
+        public string ErrorText { get; set; }
+        public int RowIndex { get; }
+    }
+    public delegate void DataGridViewRowErrorTextNeededEventHandler(object sender, DataGridViewRowErrorTextNeededEventArgs e);
+    public class DataGridViewRowEventArgs : EventArgs {
+        public DataGridViewRowEventArgs(DataGridViewRow dataGridViewRow);
+        public DataGridViewRow Row { get; }
+    }
+    public delegate void DataGridViewRowEventHandler(object sender, DataGridViewRowEventArgs e);
+    public class DataGridViewRowHeaderCell : DataGridViewHeaderCell {
+        public DataGridViewRowHeaderCell();
+        public override object Clone();
+        protected override AccessibleObject CreateAccessibilityInstance();
+        protected override object GetClipboardContent(int rowIndex, bool firstCell, bool lastCell, bool inFirstRow, bool inLastRow, string format);
+        protected override Rectangle GetContentBounds(Graphics graphics, DataGridViewCellStyle cellStyle, int rowIndex);
+        protected override Rectangle GetErrorIconBounds(Graphics graphics, DataGridViewCellStyle cellStyle, int rowIndex);
+        protected internal override string GetErrorText(int rowIndex);
+        public override ContextMenuStrip GetInheritedContextMenuStrip(int rowIndex);
+        public override DataGridViewCellStyle GetInheritedStyle(DataGridViewCellStyle inheritedCellStyle, int rowIndex, bool includeColors);
+        protected override Size GetPreferredSize(Graphics graphics, DataGridViewCellStyle cellStyle, int rowIndex, Size constraintSize);
+        protected override object GetValue(int rowIndex);
+        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts);
+        protected override bool SetValue(int rowIndex, object value);
+        public override string ToString();
+        protected class DataGridViewRowHeaderCellAccessibleObject : DataGridViewCell.DataGridViewCellAccessibleObject {
+            public DataGridViewRowHeaderCellAccessibleObject(DataGridViewRowHeaderCell owner);
+            public override Rectangle Bounds { get; }
+            public override string DefaultAction { get; }
+            public override string Name { get; }
+            public override AccessibleObject Parent { get; }
+            public override AccessibleRole Role { get; }
+            public override AccessibleStates State { get; }
+            public override string Value { get; }
+            public override void DoDefaultAction();
+            public override AccessibleObject Navigate(AccessibleNavigation navigationDirection);
+            public override void Select(AccessibleSelection flags);
+        }
+    }
+    public enum DataGridViewRowHeadersWidthSizeMode {
+        AutoSizeToAllHeaders = 2,
+        AutoSizeToDisplayedHeaders = 3,
+        AutoSizeToFirstHeader = 4,
+        DisableResizing = 1,
+        EnableResizing = 0,
+    }
+    public class DataGridViewRowHeightInfoNeededEventArgs : EventArgs {
+        public int Height { get; set; }
+        public int MinimumHeight { get; set; }
+        public int RowIndex { get; }
+    }
+    public delegate void DataGridViewRowHeightInfoNeededEventHandler(object sender, DataGridViewRowHeightInfoNeededEventArgs e);
+    public class DataGridViewRowHeightInfoPushedEventArgs : HandledEventArgs {
+        public int Height { get; }
+        public int MinimumHeight { get; }
+        public int RowIndex { get; }
+    }
+    public delegate void DataGridViewRowHeightInfoPushedEventHandler(object sender, DataGridViewRowHeightInfoPushedEventArgs e);
+    public class DataGridViewRowPostPaintEventArgs : EventArgs {
+        public DataGridViewRowPostPaintEventArgs(DataGridView dataGridView, Graphics graphics, Rectangle clipBounds, Rectangle rowBounds, int rowIndex, DataGridViewElementStates rowState, string errorText, DataGridViewCellStyle inheritedRowStyle, bool isFirstDisplayedRow, bool isLastVisibleRow);
+        public Rectangle ClipBounds { get; set; }
+        public string ErrorText { get; }
+        public Graphics Graphics { get; }
+        public DataGridViewCellStyle InheritedRowStyle { get; }
+        public bool IsFirstDisplayedRow { get; }
+        public bool IsLastVisibleRow { get; }
+        public Rectangle RowBounds { get; }
+        public int RowIndex { get; }
+        public DataGridViewElementStates State { get; }
+        public void DrawFocus(Rectangle bounds, bool cellsPaintSelectionBackground);
+        public void PaintCells(Rectangle clipBounds, DataGridViewPaintParts paintParts);
+        public void PaintCellsBackground(Rectangle clipBounds, bool cellsPaintSelectionBackground);
+        public void PaintCellsContent(Rectangle clipBounds);
+        public void PaintHeader(bool paintSelectionBackground);
+        public void PaintHeader(DataGridViewPaintParts paintParts);
+    }
+    public delegate void DataGridViewRowPostPaintEventHandler(object sender, DataGridViewRowPostPaintEventArgs e);
+    public class DataGridViewRowPrePaintEventArgs : HandledEventArgs {
+        public DataGridViewRowPrePaintEventArgs(DataGridView dataGridView, Graphics graphics, Rectangle clipBounds, Rectangle rowBounds, int rowIndex, DataGridViewElementStates rowState, string errorText, DataGridViewCellStyle inheritedRowStyle, bool isFirstDisplayedRow, bool isLastVisibleRow);
+        public Rectangle ClipBounds { get; set; }
+        public string ErrorText { get; }
+        public Graphics Graphics { get; }
+        public DataGridViewCellStyle InheritedRowStyle { get; }
+        public bool IsFirstDisplayedRow { get; }
+        public bool IsLastVisibleRow { get; }
+        public DataGridViewPaintParts PaintParts { get; set; }
+        public Rectangle RowBounds { get; }
+        public int RowIndex { get; }
+        public DataGridViewElementStates State { get; }
+        public void DrawFocus(Rectangle bounds, bool cellsPaintSelectionBackground);
+        public void PaintCells(Rectangle clipBounds, DataGridViewPaintParts paintParts);
+        public void PaintCellsBackground(Rectangle clipBounds, bool cellsPaintSelectionBackground);
+        public void PaintCellsContent(Rectangle clipBounds);
+        public void PaintHeader(bool paintSelectionBackground);
+        public void PaintHeader(DataGridViewPaintParts paintParts);
+    }
+    public delegate void DataGridViewRowPrePaintEventHandler(object sender, DataGridViewRowPrePaintEventArgs e);
+    public class DataGridViewRowsAddedEventArgs : EventArgs {
+        public DataGridViewRowsAddedEventArgs(int rowIndex, int rowCount);
+        public int RowCount { get; }
+        public int RowIndex { get; }
+    }
+    public delegate void DataGridViewRowsAddedEventHandler(object sender, DataGridViewRowsAddedEventArgs e);
+    public class DataGridViewRowsRemovedEventArgs : EventArgs {
+        public DataGridViewRowsRemovedEventArgs(int rowIndex, int rowCount);
+        public int RowCount { get; }
+        public int RowIndex { get; }
+    }
+    public delegate void DataGridViewRowsRemovedEventHandler(object sender, DataGridViewRowsRemovedEventArgs e);
+    public class DataGridViewRowStateChangedEventArgs : EventArgs {
+        public DataGridViewRowStateChangedEventArgs(DataGridViewRow dataGridViewRow, DataGridViewElementStates stateChanged);
+        public DataGridViewRow Row { get; }
+        public DataGridViewElementStates StateChanged { get; }
+    }
+    public delegate void DataGridViewRowStateChangedEventHandler(object sender, DataGridViewRowStateChangedEventArgs e);
+    public class DataGridViewSelectedCellCollection : BaseCollection, ICollection, IEnumerable, IList {
+        protected override ArrayList List { get; }
+        int System.Collections.ICollection.Count { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public DataGridViewCell this[int index] { get; }
+        public void Clear();
+        public bool Contains(DataGridViewCell dataGridViewCell);
+        public void CopyTo(DataGridViewCell[] array, int index);
+        public void Insert(int index, DataGridViewCell dataGridViewCell);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        void System.Collections.IList.Clear();
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        void System.Collections.IList.RemoveAt(int index);
+    }
+    public class DataGridViewSelectedColumnCollection : BaseCollection, ICollection, IEnumerable, IList {
+        protected override ArrayList List { get; }
+        int System.Collections.ICollection.Count { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public DataGridViewColumn this[int index] { get; }
+        public void Clear();
+        public bool Contains(DataGridViewColumn dataGridViewColumn);
+        public void CopyTo(DataGridViewColumn[] array, int index);
+        public void Insert(int index, DataGridViewColumn dataGridViewColumn);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        void System.Collections.IList.Clear();
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        void System.Collections.IList.RemoveAt(int index);
+    }
+    public class DataGridViewSelectedRowCollection : BaseCollection, ICollection, IEnumerable, IList {
+        protected override ArrayList List { get; }
+        int System.Collections.ICollection.Count { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public DataGridViewRow this[int index] { get; }
+        public void Clear();
+        public bool Contains(DataGridViewRow dataGridViewRow);
+        public void CopyTo(DataGridViewRow[] array, int index);
+        public void Insert(int index, DataGridViewRow dataGridViewRow);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        void System.Collections.IList.Clear();
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        void System.Collections.IList.RemoveAt(int index);
+    }
+    public enum DataGridViewSelectionMode {
+        CellSelect = 0,
+        ColumnHeaderSelect = 4,
+        FullColumnSelect = 2,
+        FullRowSelect = 1,
+        RowHeaderSelect = 3,
+    }
+    public class DataGridViewSortCompareEventArgs : HandledEventArgs {
+        public DataGridViewSortCompareEventArgs(DataGridViewColumn dataGridViewColumn, object cellValue1, object cellValue2, int rowIndex1, int rowIndex2);
+        public object CellValue1 { get; }
+        public object CellValue2 { get; }
+        public DataGridViewColumn Column { get; }
+        public int RowIndex1 { get; }
+        public int RowIndex2 { get; }
+        public int SortResult { get; set; }
+    }
+    public delegate void DataGridViewSortCompareEventHandler(object sender, DataGridViewSortCompareEventArgs e);
+    public class DataGridViewTextBoxCell : DataGridViewCell {
+        public DataGridViewTextBoxCell();
+        public override Type FormattedValueType { get; }
+        public virtual int MaxInputLength { get; set; }
+        public override Type ValueType { get; }
+        public override object Clone();
+        public override void DetachEditingControl();
+        protected override Rectangle GetContentBounds(Graphics graphics, DataGridViewCellStyle cellStyle, int rowIndex);
+        protected override Rectangle GetErrorIconBounds(Graphics graphics, DataGridViewCellStyle cellStyle, int rowIndex);
+        protected override Size GetPreferredSize(Graphics graphics, DataGridViewCellStyle cellStyle, int rowIndex, Size constraintSize);
+        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle);
+        public override bool KeyEntersEditMode(KeyEventArgs e);
+        protected override void OnEnter(int rowIndex, bool throughMouseClick);
+        protected override void OnLeave(int rowIndex, bool throughMouseClick);
+        protected override void OnMouseClick(DataGridViewCellMouseEventArgs e);
+        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts);
+        public override void PositionEditingControl(bool setLocation, bool setSize, Rectangle cellBounds, Rectangle cellClip, DataGridViewCellStyle cellStyle, bool singleVerticalBorderAdded, bool singleHorizontalBorderAdded, bool isFirstDisplayedColumn, bool isFirstDisplayedRow);
+        public override string ToString();
+    }
+    public class DataGridViewTextBoxColumn : DataGridViewColumn {
+        public DataGridViewTextBoxColumn();
+        public override DataGridViewCell CellTemplate { get; set; }
+        public int MaxInputLength { get; set; }
+        public new DataGridViewColumnSortMode SortMode { get; set; }
+        public override string ToString();
+    }
+    public class DataGridViewTextBoxEditingControl : TextBox, IDataGridViewEditingControl {
+        public DataGridViewTextBoxEditingControl();
+        public virtual DataGridView EditingControlDataGridView { get; set; }
+        public virtual object EditingControlFormattedValue { get; set; }
+        public virtual int EditingControlRowIndex { get; set; }
+        public virtual bool EditingControlValueChanged { get; set; }
+        public virtual Cursor EditingPanelCursor { get; }
+        public virtual bool RepositionEditingControlOnValueChange { get; }
+        public virtual void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle);
+        public virtual bool EditingControlWantsInputKey(Keys keyData, bool dataGridViewWantsInputKey);
+        public virtual object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context);
+        protected override void OnMouseWheel(MouseEventArgs e);
+        protected override void OnTextChanged(EventArgs e);
+        public virtual void PrepareEditingControlForEdit(bool selectAll);
+        protected override bool ProcessKeyEventArgs(ref Message m);
+    }
+    public class DataGridViewTopLeftHeaderCell : DataGridViewColumnHeaderCell {
+        public DataGridViewTopLeftHeaderCell();
+        protected override AccessibleObject CreateAccessibilityInstance();
+        protected override Rectangle GetContentBounds(Graphics graphics, DataGridViewCellStyle cellStyle, int rowIndex);
+        protected override Rectangle GetErrorIconBounds(Graphics graphics, DataGridViewCellStyle cellStyle, int rowIndex);
+        protected override Size GetPreferredSize(Graphics graphics, DataGridViewCellStyle cellStyle, int rowIndex, Size constraintSize);
+        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts);
+        protected override void PaintBorder(Graphics graphics, Rectangle clipBounds, Rectangle bounds, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle);
+        public override string ToString();
+        protected class DataGridViewTopLeftHeaderCellAccessibleObject : DataGridViewColumnHeaderCell.DataGridViewColumnHeaderCellAccessibleObject {
+            public DataGridViewTopLeftHeaderCellAccessibleObject(DataGridViewTopLeftHeaderCell owner);
+            public override Rectangle Bounds { get; }
+            public override string DefaultAction { get; }
+            public override string Name { get; }
+            public override AccessibleStates State { get; }
+            public override string Value { get; }
+            public override void DoDefaultAction();
+            public override AccessibleObject Navigate(AccessibleNavigation navigationDirection);
+            public override void Select(AccessibleSelection flags);
+        }
+    }
+    public enum DataGridViewTriState {
+        False = 2,
+        NotSet = 0,
+        True = 1,
+    }
+    public class DataObject : IDataObject, IDataObject {
+        public DataObject();
+        public DataObject(object data);
+        public DataObject(string format, object data);
+        public virtual bool ContainsAudio();
+        public virtual bool ContainsFileDropList();
+        public virtual bool ContainsImage();
+        public virtual bool ContainsText();
+        public virtual bool ContainsText(TextDataFormat format);
+        public virtual Stream GetAudioStream();
+        public virtual object GetData(string format);
+        public virtual object GetData(string format, bool autoConvert);
+        public virtual object GetData(Type format);
+        public virtual bool GetDataPresent(string format);
+        public virtual bool GetDataPresent(string format, bool autoConvert);
+        public virtual bool GetDataPresent(Type format);
+        public virtual StringCollection GetFileDropList();
+        public virtual string[] GetFormats();
+        public virtual string[] GetFormats(bool autoConvert);
+        public virtual Image GetImage();
+        public virtual string GetText();
+        public virtual string GetText(TextDataFormat format);
+        public virtual void SetAudio(byte[] audioBytes);
+        public virtual void SetAudio(Stream audioStream);
+        public virtual void SetData(object data);
+        public virtual void SetData(string format, bool autoConvert, object data);
+        public virtual void SetData(string format, object data);
+        public virtual void SetData(Type format, object data);
+        public virtual void SetFileDropList(StringCollection filePaths);
+        public virtual void SetImage(Image image);
+        public virtual void SetText(string textData);
+        public virtual void SetText(string textData, TextDataFormat format);
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
+    public enum DataSourceUpdateMode {
+        Never = 2,
+        OnPropertyChanged = 1,
+        OnValidation = 0,
+    }
+    public class DateBoldEventArgs : EventArgs {
+        public int[] DaysToBold { get; set; }
+        public int Size { get; }
+        public DateTime StartDate { get; }
+    }
+    public delegate void DateBoldEventHandler(object sender, DateBoldEventArgs e);
+    public class DateRangeEventArgs : EventArgs {
+        public DateRangeEventArgs(DateTime start, DateTime end);
+        public DateTime End { get; }
+        public DateTime Start { get; }
+    }
+    public delegate void DateRangeEventHandler(object sender, DateRangeEventArgs e);
+    public class DateTimePicker : Control {
+        public static readonly DateTime MaxDateTime;
+        public static readonly DateTime MinDateTime;
+        protected static readonly Color DefaultMonthBackColor;
+        protected static readonly Color DefaultTitleBackColor;
+        protected static readonly Color DefaultTitleForeColor;
+        protected static readonly Color DefaultTrailingForeColor;
+        public DateTimePicker();
+        public override Color BackColor { get; set; }
+        public override Image BackgroundImage { get; set; }
+        public override ImageLayout BackgroundImageLayout { get; set; }
+        public Font CalendarFont { get; set; }
+        public Color CalendarForeColor { get; set; }
+        public Color CalendarMonthBackground { get; set; }
+        public Color CalendarTitleBackColor { get; set; }
+        public Color CalendarTitleForeColor { get; set; }
+        public Color CalendarTrailingForeColor { get; set; }
+        public bool Checked { get; set; }
+        protected override CreateParams CreateParams { get; }
+        public string CustomFormat { get; set; }
+        protected override Size DefaultSize { get; }
+        protected override bool DoubleBuffered { get; set; }
+        public LeftRightAlignment DropDownAlign { get; set; }
+        public override Color ForeColor { get; set; }
+        public DateTimePickerFormat Format { get; set; }
+        public DateTime MaxDate { get; set; }
+        public static DateTime MaximumDateTime { get; }
+        public DateTime MinDate { get; set; }
+        public static DateTime MinimumDateTime { get; }
+        public new Padding Padding { get; set; }
+        public int PreferredHeight { get; }
+        public virtual bool RightToLeftLayout { get; set; }
+        public bool ShowCheckBox { get; set; }
+        public bool ShowUpDown { get; set; }
+        public override string Text { get; set; }
+        public DateTime Value { get; set; }
+        public new event EventHandler BackColorChanged;
+        public new event EventHandler BackgroundImageChanged;
+        public new event EventHandler BackgroundImageLayoutChanged;
+        public new event EventHandler Click;
+        public event EventHandler CloseUp;
+        public new event EventHandler DoubleClick;
+        public event EventHandler DropDown;
+        public new event EventHandler ForeColorChanged;
+        public event EventHandler FormatChanged;
+        public new event MouseEventHandler MouseClick;
+        public new event MouseEventHandler MouseDoubleClick;
+        public new event EventHandler PaddingChanged;
+        public new event PaintEventHandler Paint;
+        public event EventHandler RightToLeftLayoutChanged;
+        public new event EventHandler TextChanged;
+        public event EventHandler ValueChanged;
+        protected override AccessibleObject CreateAccessibilityInstance();
+        protected override void CreateHandle();
+        protected override void DestroyHandle();
+        protected override bool IsInputKey(Keys keyData);
+        protected virtual void OnCloseUp(EventArgs eventargs);
+        protected virtual void OnDropDown(EventArgs eventargs);
+        protected override void OnFontChanged(EventArgs e);
+        protected virtual void OnFormatChanged(EventArgs e);
+        protected override void OnHandleCreated(EventArgs e);
+        protected override void OnHandleDestroyed(EventArgs e);
+        protected virtual void OnRightToLeftLayoutChanged(EventArgs e);
+        protected override void OnSystemColorsChanged(EventArgs e);
+        protected virtual void OnValueChanged(EventArgs eventargs);
+        public override string ToString();
+        protected override void WndProc(ref Message m);
+        public class DateTimePickerAccessibleObject : Control.ControlAccessibleObject {
+            public DateTimePickerAccessibleObject(DateTimePicker owner);
+            public override string KeyboardShortcut { get; }
+            public override AccessibleRole Role { get; }
+            public override AccessibleStates State { get; }
+            public override string Value { get; }
+        }
+    }
+    public enum DateTimePickerFormat {
+        Custom = 8,
+        Long = 1,
+        Short = 2,
+        Time = 4,
+    }
+    public enum Day {
+        Default = 7,
+        Friday = 4,
+        Monday = 0,
+        Saturday = 5,
+        Sunday = 6,
+        Thursday = 3,
+        Tuesday = 1,
+        Wednesday = 2,
+    }
+    public enum DialogResult {
+        Abort = 3,
+        Cancel = 2,
+        Ignore = 5,
+        No = 7,
+        None = 0,
+        OK = 1,
+        Retry = 4,
+        Yes = 6,
+    }
+    public sealed class DockingAttribute : Attribute {
+        public static readonly DockingAttribute Default;
+        public DockingAttribute();
+        public DockingAttribute(DockingBehavior dockingBehavior);
+        public DockingBehavior DockingBehavior { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public override bool IsDefaultAttribute();
+    }
+    public enum DockingBehavior {
+        Ask = 1,
+        AutoDock = 2,
+        Never = 0,
+    }
+    public enum DockStyle {
+        Bottom = 2,
+        Fill = 5,
+        Left = 3,
+        None = 0,
+        Right = 4,
+        Top = 1,
+    }
+    public class DomainUpDown : UpDownBase {
+        public DomainUpDown();
+        public DomainUpDown.DomainUpDownItemCollection Items { get; }
+        public new Padding Padding { get; set; }
+        public int SelectedIndex { get; set; }
+        public object SelectedItem { get; set; }
+        public bool Sorted { get; set; }
+        public bool Wrap { get; set; }
+        public new event EventHandler PaddingChanged;
+        public event EventHandler SelectedItemChanged;
+        protected override AccessibleObject CreateAccessibilityInstance();
+        public override void DownButton();
+        protected override void OnChanged(object source, EventArgs e);
+        protected void OnSelectedItemChanged(object source, EventArgs e);
+        protected override void OnTextBoxKeyPress(object source, KeyPressEventArgs e);
+        public override string ToString();
+        public override void UpButton();
+        protected override void UpdateEditText();
+        public class DomainItemAccessibleObject : AccessibleObject {
+            public DomainItemAccessibleObject(string name, AccessibleObject parent);
+            public override string Name { get; set; }
+            public override AccessibleObject Parent { get; }
+            public override AccessibleRole Role { get; }
+            public override AccessibleStates State { get; }
+            public override string Value { get; }
+        }
+        public class DomainUpDownAccessibleObject : Control.ControlAccessibleObject {
+            public DomainUpDownAccessibleObject(Control owner);
+            public override AccessibleRole Role { get; }
+            public override AccessibleObject GetChild(int index);
+            public override int GetChildCount();
+        }
+        public class DomainUpDownItemCollection : ArrayList {
+            public override object this[int index] { get; set; }
+            public override int Add(object item);
+            public override void Insert(int index, object item);
+            public override void Remove(object item);
+            public override void RemoveAt(int item);
+        }
+    }
+    public enum DragAction {
+        Cancel = 2,
+        Continue = 0,
+        Drop = 1,
+    }
+    public enum DragDropEffects {
+        All = -2147483645,
+        Copy = 1,
+        Link = 4,
+        Move = 2,
+        None = 0,
+        Scroll = -2147483648,
+    }
+    public class DragEventArgs : EventArgs {
+        public DragEventArgs(IDataObject data, int keyState, int x, int y, DragDropEffects allowedEffect, DragDropEffects effect);
+        public DragDropEffects AllowedEffect { get; }
+        public IDataObject Data { get; }
+        public DragDropEffects Effect { get; set; }
+        public int KeyState { get; }
+        public int X { get; }
+        public int Y { get; }
+    }
+    public delegate void DragEventHandler(object sender, DragEventArgs e);
+    public class DrawItemEventArgs : EventArgs {
+        public DrawItemEventArgs(Graphics graphics, Font font, Rectangle rect, int index, DrawItemState state);
+        public DrawItemEventArgs(Graphics graphics, Font font, Rectangle rect, int index, DrawItemState state, Color foreColor, Color backColor);
+        public Color BackColor { get; }
+        public Rectangle Bounds { get; }
+        public Font Font { get; }
+        public Color ForeColor { get; }
+        public Graphics Graphics { get; }
+        public int Index { get; }
+        public DrawItemState State { get; }
+        public virtual void DrawBackground();
+        public virtual void DrawFocusRectangle();
+    }
+    public delegate void DrawItemEventHandler(object sender, DrawItemEventArgs e);
+    public enum DrawItemState {
+        Checked = 8,
+        ComboBoxEdit = 4096,
+        Default = 32,
+        Disabled = 4,
+        Focus = 16,
+        Grayed = 2,
+        HotLight = 64,
+        Inactive = 128,
+        NoAccelerator = 256,
+        NoFocusRect = 512,
+        None = 0,
+        Selected = 1,
+    }
+    public class DrawListViewColumnHeaderEventArgs : EventArgs {
+        public DrawListViewColumnHeaderEventArgs(Graphics graphics, Rectangle bounds, int columnIndex, ColumnHeader header, ListViewItemStates state, Color foreColor, Color backColor, Font font);
+        public Color BackColor { get; }
+        public Rectangle Bounds { get; }
+        public int ColumnIndex { get; }
+        public bool DrawDefault { get; set; }
+        public Font Font { get; }
+        public Color ForeColor { get; }
+        public Graphics Graphics { get; }
+        public ColumnHeader Header { get; }
+        public ListViewItemStates State { get; }
+        public void DrawBackground();
+        public void DrawText();
+        public void DrawText(TextFormatFlags flags);
+    }
+    public delegate void DrawListViewColumnHeaderEventHandler(object sender, DrawListViewColumnHeaderEventArgs e);
+    public class DrawListViewItemEventArgs : EventArgs {
+        public DrawListViewItemEventArgs(Graphics graphics, ListViewItem item, Rectangle bounds, int itemIndex, ListViewItemStates state);
+        public Rectangle Bounds { get; }
+        public bool DrawDefault { get; set; }
+        public Graphics Graphics { get; }
+        public ListViewItem Item { get; }
+        public int ItemIndex { get; }
+        public ListViewItemStates State { get; }
+        public void DrawBackground();
+        public void DrawFocusRectangle();
+        public void DrawText();
+        public void DrawText(TextFormatFlags flags);
+    }
+    public delegate void DrawListViewItemEventHandler(object sender, DrawListViewItemEventArgs e);
+    public class DrawListViewSubItemEventArgs : EventArgs {
+        public DrawListViewSubItemEventArgs(Graphics graphics, Rectangle bounds, ListViewItem item, ListViewItem.ListViewSubItem subItem, int itemIndex, int columnIndex, ColumnHeader header, ListViewItemStates itemState);
+        public Rectangle Bounds { get; }
+        public int ColumnIndex { get; }
+        public bool DrawDefault { get; set; }
+        public Graphics Graphics { get; }
+        public ColumnHeader Header { get; }
+        public ListViewItem Item { get; }
+        public int ItemIndex { get; }
+        public ListViewItemStates ItemState { get; }
+        public ListViewItem.ListViewSubItem SubItem { get; }
+        public void DrawBackground();
+        public void DrawFocusRectangle(Rectangle bounds);
+        public void DrawText();
+        public void DrawText(TextFormatFlags flags);
+    }
+    public delegate void DrawListViewSubItemEventHandler(object sender, DrawListViewSubItemEventArgs e);
+    public enum DrawMode {
+        Normal = 0,
+        OwnerDrawFixed = 1,
+        OwnerDrawVariable = 2,
+    }
+    public class DrawToolTipEventArgs : EventArgs {
+        public DrawToolTipEventArgs(Graphics graphics, IWin32Window associatedWindow, Control associatedControl, Rectangle bounds, string toolTipText, Color backColor, Color foreColor, Font font);
+        public Control AssociatedControl { get; }
+        public IWin32Window AssociatedWindow { get; }
+        public Rectangle Bounds { get; }
+        public Font Font { get; }
+        public Graphics Graphics { get; }
+        public string ToolTipText { get; }
+        public void DrawBackground();
+        public void DrawBorder();
+        public void DrawText();
+        public void DrawText(TextFormatFlags flags);
+    }
+    public delegate void DrawToolTipEventHandler(object sender, DrawToolTipEventArgs e);
+    public class DrawTreeNodeEventArgs : EventArgs {
+        public DrawTreeNodeEventArgs(Graphics graphics, TreeNode node, Rectangle bounds, TreeNodeStates state);
+        public Rectangle Bounds { get; }
+        public bool DrawDefault { get; set; }
+        public Graphics Graphics { get; }
+        public TreeNode Node { get; }
+        public TreeNodeStates State { get; }
+    }
+    public delegate void DrawTreeNodeEventHandler(object sender, DrawTreeNodeEventArgs e);
+    public enum ErrorBlinkStyle {
+        AlwaysBlink = 1,
+        BlinkIfDifferentError = 0,
+        NeverBlink = 2,
+    }
+    public enum ErrorIconAlignment {
+        BottomLeft = 4,
+        BottomRight = 5,
+        MiddleLeft = 2,
+        MiddleRight = 3,
+        TopLeft = 0,
+        TopRight = 1,
+    }
+    public class ErrorProvider : Component, IExtenderProvider, ISupportInitialize {
+        public ErrorProvider();
+        public ErrorProvider(IContainer container);
+        public ErrorProvider(ContainerControl parentControl);
+        public int BlinkRate { get; set; }
+        public ErrorBlinkStyle BlinkStyle { get; set; }
+        public ContainerControl ContainerControl { get; set; }
+        public string DataMember { get; set; }
+        public object DataSource { get; set; }
+        public Icon Icon { get; set; }
+        public virtual bool RightToLeft { get; set; }
+        public override ISite Site { set; }
+        public object Tag { get; set; }
+        public event EventHandler RightToLeftChanged;
+        public void BindToDataAndErrors(object newDataSource, string newDataMember);
+        public bool CanExtend(object extendee);
+        public void Clear();
+        protected override void Dispose(bool disposing);
+        public string GetError(Control control);
+        public ErrorIconAlignment GetIconAlignment(Control control);
+        public int GetIconPadding(Control control);
+        protected virtual void OnRightToLeftChanged(EventArgs e);
+        public void SetError(Control control, string value);
+        public void SetIconAlignment(Control control, ErrorIconAlignment value);
+        public void SetIconPadding(Control control, int padding);
+        void System.ComponentModel.ISupportInitialize.BeginInit();
+        void System.ComponentModel.ISupportInitialize.EndInit();
+        public void UpdateBinding();
+    }
+    public abstract class FeatureSupport : IFeatureSupport {
+        protected FeatureSupport();
+        public abstract Version GetVersionPresent(object feature);
+        public static Version GetVersionPresent(string featureClassName, string featureConstName);
+        public virtual bool IsPresent(object feature);
+        public virtual bool IsPresent(object feature, Version minimumVersion);
+        public static bool IsPresent(string featureClassName, string featureConstName);
+        public static bool IsPresent(string featureClassName, string featureConstName, Version minimumVersion);
+    }
+    public abstract class FileDialog : CommonDialog {
+        protected static readonly object EventFileOk;
+        public bool AddExtension { get; set; }
+        public bool AutoUpgradeEnabled { get; set; }
+        public virtual bool CheckFileExists { get; set; }
+        public bool CheckPathExists { get; set; }
+        public FileDialogCustomPlacesCollection CustomPlaces { get; }
+        public string DefaultExt { get; set; }
+        public bool DereferenceLinks { get; set; }
+        public string FileName { get; set; }
+        public string[] FileNames { get; }
+        public string Filter { get; set; }
+        public int FilterIndex { get; set; }
+        public string InitialDirectory { get; set; }
+        protected virtual IntPtr Instance { get; }
+        protected int Options { get; }
+        public bool RestoreDirectory { get; set; }
+        public bool ShowHelp { get; set; }
+        public bool SupportMultiDottedExtensions { get; set; }
+        public string Title { get; set; }
+        public bool ValidateNames { get; set; }
+        public event CancelEventHandler FileOk;
+        protected override IntPtr HookProc(IntPtr hWnd, int msg, IntPtr wparam, IntPtr lparam);
+        protected void OnFileOk(CancelEventArgs e);
+        public override void Reset();
+        protected override bool RunDialog(IntPtr hWndOwner);
+        public override string ToString();
+    }
+    public class FileDialogCustomPlace {
+        public FileDialogCustomPlace(Guid knownFolderGuid);
+        public FileDialogCustomPlace(string path);
+        public Guid KnownFolderGuid { get; set; }
+        public string Path { get; set; }
+        public override string ToString();
+    }
+    public class FileDialogCustomPlacesCollection : Collection<FileDialogCustomPlace> {
+        public FileDialogCustomPlacesCollection();
+        public void Add(Guid knownFolderGuid);
+        public void Add(string path);
+    }
+    public enum FixedPanel {
+        None = 0,
+        Panel1 = 1,
+        Panel2 = 2,
+    }
+    public class FlatButtonAppearance {
+        public Color BorderColor { get; set; }
+        public int BorderSize { get; set; }
+        public Color CheckedBackColor { get; set; }
+        public Color MouseDownBackColor { get; set; }
+        public Color MouseOverBackColor { get; set; }
+    }
+    public enum FlatStyle {
+        Flat = 0,
+        Popup = 1,
+        Standard = 2,
+        System = 3,
+    }
+    public enum FlowDirection {
+        BottomUp = 3,
+        LeftToRight = 0,
+        RightToLeft = 2,
+        TopDown = 1,
+    }
+    public class FlowLayoutPanel : Panel, IExtenderProvider {
+        public FlowLayoutPanel();
+        public FlowDirection FlowDirection { get; set; }
+        public override LayoutEngine LayoutEngine { get; }
+        public bool WrapContents { get; set; }
+        public bool GetFlowBreak(Control control);
+        public void SetFlowBreak(Control control, bool value);
+        bool System.ComponentModel.IExtenderProvider.CanExtend(object obj);
+    }
+    public class FlowLayoutSettings : LayoutSettings {
+        public FlowDirection FlowDirection { get; set; }
+        public override LayoutEngine LayoutEngine { get; }
+        public bool WrapContents { get; set; }
+        public bool GetFlowBreak(object child);
+        public void SetFlowBreak(object child, bool value);
+    }
+    public sealed class FolderBrowserDialog : CommonDialog {
+        public FolderBrowserDialog();
+        public string Description { get; set; }
+        public Environment.SpecialFolder RootFolder { get; set; }
+        public string SelectedPath { get; set; }
+        public bool ShowNewFolderButton { get; set; }
+        public new event EventHandler HelpRequest;
+        public override void Reset();
+        protected override bool RunDialog(IntPtr hWndOwner);
+    }
+    public class FontDialog : CommonDialog {
+        protected static readonly object EventApply;
+        public FontDialog();
+        public bool AllowScriptChange { get; set; }
+        public bool AllowSimulations { get; set; }
+        public bool AllowVectorFonts { get; set; }
+        public bool AllowVerticalFonts { get; set; }
+        public Color Color { get; set; }
+        public bool FixedPitchOnly { get; set; }
+        public Font Font { get; set; }
+        public bool FontMustExist { get; set; }
+        public int MaxSize { get; set; }
+        public int MinSize { get; set; }
+        protected int Options { get; }
+        public bool ScriptsOnly { get; set; }
+        public bool ShowApply { get; set; }
+        public bool ShowColor { get; set; }
+        public bool ShowEffects { get; set; }
+        public bool ShowHelp { get; set; }
+        public event EventHandler Apply;
+        protected override IntPtr HookProc(IntPtr hWnd, int msg, IntPtr wparam, IntPtr lparam);
+        protected virtual void OnApply(EventArgs e);
+        public override void Reset();
+        protected override bool RunDialog(IntPtr hWndOwner);
+        public override string ToString();
+    }
+    public class Form : ContainerControl {
+        public Form();
+        public IButtonControl AcceptButton { get; set; }
+        public static Form ActiveForm { get; }
+        public Form ActiveMdiChild { get; }
+        public bool AllowTransparency { get; set; }
+        public bool AutoScale { get; set; }
+        public virtual Size AutoScaleBaseSize { get; set; }
+        public override bool AutoScroll { get; set; }
+        public override bool AutoSize { get; set; }
+        public AutoSizeMode AutoSizeMode { get; set; }
+        public override AutoValidate AutoValidate { get; set; }
+        public override Color BackColor { get; set; }
+        public IButtonControl CancelButton { get; set; }
+        public new Size ClientSize { get; set; }
+        public bool ControlBox { get; set; }
+        protected override CreateParams CreateParams { get; }
+        protected override ImeMode DefaultImeMode { get; }
+        protected override Size DefaultSize { get; }
+        public Rectangle DesktopBounds { get; set; }
+        public Point DesktopLocation { get; set; }
+        public DialogResult DialogResult { get; set; }
+        public FormBorderStyle FormBorderStyle { get; set; }
+        public bool HelpButton { get; set; }
+        public Icon Icon { get; set; }
+        public bool IsMdiChild { get; }
+        public bool IsMdiContainer { get; set; }
+        public bool IsRestrictedWindow { get; }
+        public bool KeyPreview { get; set; }
+        public new Point Location { get; set; }
+        public MenuStrip MainMenuStrip { get; set; }
+        public new Padding Margin { get; set; }
+        public bool MaximizeBox { get; set; }
+        protected Rectangle MaximizedBounds { get; set; }
+        public override Size MaximumSize { get; set; }
+        public Form[] MdiChildren { get; }
+        public Form MdiParent { get; set; }
+        public MainMenu Menu { get; set; }
+        public MainMenu MergedMenu { get; }
+        public bool MinimizeBox { get; set; }
+        public override Size MinimumSize { get; set; }
+        public bool Modal { get; }
+        public double Opacity { get; set; }
+        public Form[] OwnedForms { get; }
+        public Form Owner { get; set; }
+        public Rectangle RestoreBounds { get; }
+        public virtual bool RightToLeftLayout { get; set; }
+        public bool ShowIcon { get; set; }
+        public bool ShowInTaskbar { get; set; }
+        protected virtual bool ShowWithoutActivation { get; }
+        public new Size Size { get; set; }
+        public SizeGripStyle SizeGripStyle { get; set; }
+        public FormStartPosition StartPosition { get; set; }
+        public new int TabIndex { get; set; }
+        public new bool TabStop { get; set; }
+        public override string Text { get; set; }
+        public bool TopLevel { get; set; }
+        public bool TopMost { get; set; }
+        public Color TransparencyKey { get; set; }
+        public FormWindowState WindowState { get; set; }
+        public event EventHandler Activated;
+        public new event EventHandler AutoSizeChanged;
+        public new event EventHandler AutoValidateChanged;
+        public event EventHandler Closed;
+        public event CancelEventHandler Closing;
+        public event EventHandler Deactivate;
+        public event FormClosedEventHandler FormClosed;
+        public event FormClosingEventHandler FormClosing;
+        public event CancelEventHandler HelpButtonClicked;
+        public event InputLanguageChangedEventHandler InputLanguageChanged;
+        public event InputLanguageChangingEventHandler InputLanguageChanging;
+        public event EventHandler Load;
+        public new event EventHandler MarginChanged;
+        public event EventHandler MaximizedBoundsChanged;
+        public event EventHandler MaximumSizeChanged;
+        public event EventHandler MdiChildActivate;
+        public event EventHandler MenuComplete;
+        public event EventHandler MenuStart;
+        public event EventHandler MinimumSizeChanged;
+        public event EventHandler ResizeBegin;
+        public event EventHandler ResizeEnd;
+        public event EventHandler RightToLeftLayoutChanged;
+        public event EventHandler Shown;
+        public new event EventHandler TabIndexChanged;
+        public new event EventHandler TabStopChanged;
+        public void Activate();
+        protected void ActivateMdiChild(Form form);
+        public void AddOwnedForm(Form ownedForm);
+        protected override void AdjustFormScrollbars(bool displayScrollbars);
+        protected void ApplyAutoScaling();
+        protected void CenterToParent();
+        protected void CenterToScreen();
+        public void Close();
+        protected override Control.ControlCollection CreateControlsInstance();
+        protected override void CreateHandle();
+        protected override void DefWndProc(ref Message m);
+        protected override void Dispose(bool disposing);
+        public static SizeF GetAutoScaleSize(Font font);
+        protected override Rectangle GetScaledBounds(Rectangle bounds, SizeF factor, BoundsSpecified specified);
+        public void LayoutMdi(MdiLayout value);
+        protected virtual void OnActivated(EventArgs e);
+        protected override void OnBackgroundImageChanged(EventArgs e);
+        protected override void OnBackgroundImageLayoutChanged(EventArgs e);
+        protected virtual void OnClosed(EventArgs e);
+        protected virtual void OnClosing(CancelEventArgs e);
+        protected override void OnCreateControl();
+        protected virtual void OnDeactivate(EventArgs e);
+        protected override void OnEnabledChanged(EventArgs e);
+        protected override void OnEnter(EventArgs e);
+        protected override void OnFontChanged(EventArgs e);
+        protected virtual void OnFormClosed(FormClosedEventArgs e);
+        protected virtual void OnFormClosing(FormClosingEventArgs e);
+        protected override void OnHandleCreated(EventArgs e);
+        protected override void OnHandleDestroyed(EventArgs e);
+        protected virtual void OnHelpButtonClicked(CancelEventArgs e);
+        protected virtual void OnInputLanguageChanged(InputLanguageChangedEventArgs e);
+        protected virtual void OnInputLanguageChanging(InputLanguageChangingEventArgs e);
+        protected override void OnLayout(LayoutEventArgs levent);
+        protected virtual void OnLoad(EventArgs e);
+        protected virtual void OnMaximizedBoundsChanged(EventArgs e);
+        protected virtual void OnMaximumSizeChanged(EventArgs e);
+        protected virtual void OnMdiChildActivate(EventArgs e);
+        protected virtual void OnMenuComplete(EventArgs e);
+        protected virtual void OnMenuStart(EventArgs e);
+        protected virtual void OnMinimumSizeChanged(EventArgs e);
+        protected override void OnPaint(PaintEventArgs e);
+        protected override void OnResize(EventArgs e);
+        protected virtual void OnResizeBegin(EventArgs e);
+        protected virtual void OnResizeEnd(EventArgs e);
+        protected virtual void OnRightToLeftLayoutChanged(EventArgs e);
+        protected virtual void OnShown(EventArgs e);
+        protected override void OnStyleChanged(EventArgs e);
+        protected override void OnTextChanged(EventArgs e);
+        protected override void OnVisibleChanged(EventArgs e);
+        protected override bool ProcessCmdKey(ref Message msg, Keys keyData);
+        protected override bool ProcessDialogChar(char charCode);
+        protected override bool ProcessDialogKey(Keys keyData);
+        protected override bool ProcessKeyPreview(ref Message m);
+        protected internal override bool ProcessMnemonic(char charCode);
+        protected override bool ProcessTabKey(bool forward);
+        public void RemoveOwnedForm(Form ownedForm);
+        protected override void ScaleControl(SizeF factor, BoundsSpecified specified);
+        protected override void ScaleCore(float x, float y);
+        protected override void Select(bool directed, bool forward);
+        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified);
+        protected override void SetClientSizeCore(int x, int y);
+        public void SetDesktopBounds(int x, int y, int width, int height);
+        public void SetDesktopLocation(int x, int y);
+        protected override void SetVisibleCore(bool value);
+        public void Show(IWin32Window owner);
+        public DialogResult ShowDialog();
+        public DialogResult ShowDialog(IWin32Window owner);
+        public override string ToString();
+        protected override void UpdateDefaultButton();
+        public override bool ValidateChildren();
+        public override bool ValidateChildren(ValidationConstraints validationConstraints);
+        protected override void WndProc(ref Message m);
+        public class ControlCollection : Control.ControlCollection {
+            public ControlCollection(Form owner);
+            public override void Add(Control value);
+            public override void Remove(Control value);
+        }
+    }
+    public enum FormBorderStyle {
+        Fixed3D = 2,
+        FixedDialog = 3,
+        FixedSingle = 1,
+        FixedToolWindow = 5,
+        None = 0,
+        Sizable = 4,
+        SizableToolWindow = 6,
+    }
+    public class FormClosedEventArgs : EventArgs {
+        public FormClosedEventArgs(CloseReason closeReason);
+        public CloseReason CloseReason { get; }
+    }
+    public delegate void FormClosedEventHandler(object sender, FormClosedEventArgs e);
+    public class FormClosingEventArgs : CancelEventArgs {
+        public FormClosingEventArgs(CloseReason closeReason, bool cancel);
+        public CloseReason CloseReason { get; }
+    }
+    public delegate void FormClosingEventHandler(object sender, FormClosingEventArgs e);
+    public class FormCollection : ReadOnlyCollectionBase {
+        public FormCollection();
+        public virtual Form this[int index] { get; }
+        public virtual Form this[string name] { get; }
+    }
+    public enum FormStartPosition {
+        CenterParent = 4,
+        CenterScreen = 1,
+        Manual = 0,
+        WindowsDefaultBounds = 3,
+        WindowsDefaultLocation = 2,
+    }
+    public enum FormWindowState {
+        Maximized = 2,
+        Minimized = 1,
+        Normal = 0,
+    }
+    public enum FrameStyle {
+        Dashed = 0,
+        Thick = 1,
+    }
+    public enum GetChildAtPointSkip {
+        Disabled = 2,
+        Invisible = 1,
+        None = 0,
+        Transparent = 4,
+    }
+    public class GiveFeedbackEventArgs : EventArgs {
+        public GiveFeedbackEventArgs(DragDropEffects effect, bool useDefaultCursors);
+        public DragDropEffects Effect { get; }
+        public bool UseDefaultCursors { get; set; }
+    }
+    public delegate void GiveFeedbackEventHandler(object sender, GiveFeedbackEventArgs e);
+    public class GridColumnStylesCollection : BaseCollection, ICollection, IEnumerable, IList {
+        protected override ArrayList List { get; }
+        int System.Collections.ICollection.Count { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public DataGridColumnStyle this[PropertyDescriptor propertyDesciptor] { get; }
+        public DataGridColumnStyle this[int index] { get; }
+        public DataGridColumnStyle this[string columnName] { get; }
+        public event CollectionChangeEventHandler CollectionChanged;
+        public virtual int Add(DataGridColumnStyle column);
+        public void AddRange(DataGridColumnStyle[] columns);
+        public void Clear();
+        public bool Contains(PropertyDescriptor propertyDescriptor);
+        public bool Contains(string name);
+        public bool Contains(DataGridColumnStyle column);
+        public int IndexOf(DataGridColumnStyle element);
+        protected void OnCollectionChanged(CollectionChangeEventArgs e);
+        public void Remove(DataGridColumnStyle column);
+        public void RemoveAt(int index);
+        public void ResetPropertyDescriptors();
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        void System.Collections.IList.Clear();
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        void System.Collections.IList.RemoveAt(int index);
+    }
+    public abstract class GridItem {
+        protected GridItem();
+        public virtual bool Expandable { get; }
+        public virtual bool Expanded { get; set; }
+        public abstract GridItemCollection GridItems { get; }
+        public abstract GridItemType GridItemType { get; }
+        public abstract string Label { get; }
+        public abstract GridItem Parent { get; }
+        public abstract PropertyDescriptor PropertyDescriptor { get; }
+        public object Tag { get; set; }
+        public abstract object Value { get; }
+        public abstract bool Select();
+    }
+    public class GridItemCollection : ICollection, IEnumerable {
+        public static GridItemCollection Empty;
+        public int Count { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        public GridItem this[int index] { get; }
+        public GridItem this[string label] { get; }
+        public IEnumerator GetEnumerator();
+        void System.Collections.ICollection.CopyTo(Array dest, int index);
+    }
+    public enum GridItemType {
+        ArrayValue = 2,
+        Category = 1,
+        Property = 0,
+        Root = 3,
+    }
+    public sealed class GridTablesFactory {
+        public static DataGridTableStyle[] CreateGridTables(DataGridTableStyle gridTable, object dataSource, string dataMember, BindingContext bindingManager);
+    }
+    public class GridTableStylesCollection : BaseCollection, ICollection, IEnumerable, IList {
+        protected override ArrayList List { get; }
+        int System.Collections.ICollection.Count { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public DataGridTableStyle this[int index] { get; }
+        public DataGridTableStyle this[string tableName] { get; }
+        public event CollectionChangeEventHandler CollectionChanged;
+        public virtual int Add(DataGridTableStyle table);
+        public virtual void AddRange(DataGridTableStyle[] tables);
+        public void Clear();
+        public bool Contains(string name);
+        public bool Contains(DataGridTableStyle table);
+        protected void OnCollectionChanged(CollectionChangeEventArgs e);
+        public void Remove(DataGridTableStyle table);
+        public void RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        void System.Collections.IList.Clear();
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        void System.Collections.IList.RemoveAt(int index);
+    }
+    public class GroupBox : Control {
+        public GroupBox();
+        public override bool AllowDrop { get; set; }
+        public override bool AutoSize { get; set; }
+        public AutoSizeMode AutoSizeMode { get; set; }
+        protected override CreateParams CreateParams { get; }
+        protected override Padding DefaultPadding { get; }
+        protected override Size DefaultSize { get; }
+        public override Rectangle DisplayRectangle { get; }
+        public FlatStyle FlatStyle { get; set; }
+        public new bool TabStop { get; set; }
+        public override string Text { get; set; }
+        public bool UseCompatibleTextRendering { get; set; }
+        public new event EventHandler AutoSizeChanged;
+        public new event EventHandler Click;
+        public new event EventHandler DoubleClick;
+        public new event KeyEventHandler KeyDown;
+        public new event KeyPressEventHandler KeyPress;
+        public new event KeyEventHandler KeyUp;
+        public new event MouseEventHandler MouseClick;
+        public new event MouseEventHandler MouseDoubleClick;
+        public new event MouseEventHandler MouseDown;
+        public new event EventHandler MouseEnter;
+        public new event EventHandler MouseLeave;
+        public new event MouseEventHandler MouseMove;
+        public new event MouseEventHandler MouseUp;
+        public new event EventHandler TabStopChanged;
+        protected override AccessibleObject CreateAccessibilityInstance();
+        protected override void OnFontChanged(EventArgs e);
+        protected override void OnPaint(PaintEventArgs e);
+        protected internal override bool ProcessMnemonic(char charCode);
+        protected override void ScaleControl(SizeF factor, BoundsSpecified specified);
+        public override string ToString();
+        protected override void WndProc(ref Message m);
+    }
+    public sealed class GroupBoxRenderer {
+        public static bool RenderMatchingApplicationState { get; set; }
+        public static void DrawGroupBox(Graphics g, Rectangle bounds, string groupBoxText, Font font, Color textColor, TextFormatFlags flags, GroupBoxState state);
+        public static void DrawGroupBox(Graphics g, Rectangle bounds, string groupBoxText, Font font, Color textColor, GroupBoxState state);
+        public static void DrawGroupBox(Graphics g, Rectangle bounds, string groupBoxText, Font font, TextFormatFlags flags, GroupBoxState state);
+        public static void DrawGroupBox(Graphics g, Rectangle bounds, string groupBoxText, Font font, GroupBoxState state);
+        public static void DrawGroupBox(Graphics g, Rectangle bounds, GroupBoxState state);
+        public static void DrawParentBackground(Graphics g, Rectangle bounds, Control childControl);
+        public static bool IsBackgroundPartiallyTransparent(GroupBoxState state);
+    }
+    public class HandledMouseEventArgs : MouseEventArgs {
+        public HandledMouseEventArgs(MouseButtons button, int clicks, int x, int y, int delta);
+        public HandledMouseEventArgs(MouseButtons button, int clicks, int x, int y, int delta, bool defaultHandledValue);
+        public bool Handled { get; set; }
+    }
+    public class Help {
+        public static void ShowHelp(Control parent, string url);
+        public static void ShowHelp(Control parent, string url, string keyword);
+        public static void ShowHelp(Control parent, string url, HelpNavigator navigator);
+        public static void ShowHelp(Control parent, string url, HelpNavigator command, object parameter);
+        public static void ShowHelpIndex(Control parent, string url);
+        public static void ShowPopup(Control parent, string caption, Point location);
+    }
+    public class HelpEventArgs : EventArgs {
+        public HelpEventArgs(Point mousePos);
+        public bool Handled { get; set; }
+        public Point MousePos { get; }
+    }
+    public delegate void HelpEventHandler(object sender, HelpEventArgs hlpevent);
+    public enum HelpNavigator {
+        AssociateIndex = -2147483643,
+        Find = -2147483644,
+        Index = -2147483645,
+        KeywordIndex = -2147483642,
+        TableOfContents = -2147483646,
+        Topic = -2147483647,
+        TopicId = -2147483641,
+    }
+    public class HelpProvider : Component, IExtenderProvider {
+        public HelpProvider();
+        public virtual string HelpNamespace { get; set; }
+        public object Tag { get; set; }
+        public virtual bool CanExtend(object target);
+        public virtual string GetHelpKeyword(Control ctl);
+        public virtual HelpNavigator GetHelpNavigator(Control ctl);
+        public virtual string GetHelpString(Control ctl);
+        public virtual bool GetShowHelp(Control ctl);
+        public virtual void ResetShowHelp(Control ctl);
+        public virtual void SetHelpKeyword(Control ctl, string keyword);
+        public virtual void SetHelpNavigator(Control ctl, HelpNavigator navigator);
+        public virtual void SetHelpString(Control ctl, string helpString);
+        public virtual void SetShowHelp(Control ctl, bool value);
+        public override string ToString();
+    }
+    public enum HorizontalAlignment {
+        Center = 2,
+        Left = 0,
+        Right = 1,
+    }
+    public class HScrollBar : ScrollBar {
+        public HScrollBar();
+        protected override CreateParams CreateParams { get; }
+        protected override Size DefaultSize { get; }
+    }
+    public class HScrollProperties : ScrollProperties {
+        public HScrollProperties(ScrollableControl container);
+    }
+    public sealed class HtmlDocument {
+        public HtmlElement ActiveElement { get; }
+        public Color ActiveLinkColor { get; set; }
+        public HtmlElementCollection All { get; }
+        public Color BackColor { get; set; }
+        public HtmlElement Body { get; }
+        public string Cookie { get; set; }
+        public string DefaultEncoding { get; }
+        public string Domain { get; set; }
+        public object DomDocument { get; }
+        public string Encoding { get; set; }
+        public bool Focused { get; }
+        public Color ForeColor { get; set; }
+        public HtmlElementCollection Forms { get; }
+        public HtmlElementCollection Images { get; }
+        public Color LinkColor { get; set; }
+        public HtmlElementCollection Links { get; }
+        public bool RightToLeft { get; set; }
+        public string Title { get; set; }
+        public Uri Url { get; }
+        public Color VisitedLinkColor { get; set; }
+        public HtmlWindow Window { get; }
+        public event HtmlElementEventHandler Click;
+        public event HtmlElementEventHandler ContextMenuShowing;
+        public event HtmlElementEventHandler Focusing;
+        public event HtmlElementEventHandler LosingFocus;
+        public event HtmlElementEventHandler MouseDown;
+        public event HtmlElementEventHandler MouseLeave;
+        public event HtmlElementEventHandler MouseMove;
+        public event HtmlElementEventHandler MouseOver;
+        public event HtmlElementEventHandler MouseUp;
+        public event HtmlElementEventHandler Stop;
+        public void AttachEventHandler(string eventName, EventHandler eventHandler);
+        public HtmlElement CreateElement(string elementTag);
+        public void DetachEventHandler(string eventName, EventHandler eventHandler);
+        public override bool Equals(object obj);
+        public void ExecCommand(string command, bool showUI, object value);
+        public void Focus();
+        public HtmlElement GetElementById(string id);
+        public HtmlElement GetElementFromPoint(Point point);
+        public HtmlElementCollection GetElementsByTagName(string tagName);
+        public override int GetHashCode();
+        public object InvokeScript(string scriptName);
+        public object InvokeScript(string scriptName, object[] args);
+        public HtmlDocument OpenNew(bool replaceInHistory);
+        public static bool operator ==(HtmlDocument left, HtmlDocument right);
+        public static bool operator !=(HtmlDocument left, HtmlDocument right);
+        public void Write(string text);
+    }
+    public sealed class HtmlElement {
+        public HtmlElementCollection All { get; }
+        public bool CanHaveChildren { get; }
+        public HtmlElementCollection Children { get; }
+        public Rectangle ClientRectangle { get; }
+        public HtmlDocument Document { get; }
+        public object DomElement { get; }
+        public bool Enabled { get; set; }
+        public HtmlElement FirstChild { get; }
+        public string Id { get; set; }
+        public string InnerHtml { get; set; }
+        public string InnerText { get; set; }
+        public string Name { get; set; }
+        public HtmlElement NextSibling { get; }
+        public HtmlElement OffsetParent { get; }
+        public Rectangle OffsetRectangle { get; }
+        public string OuterHtml { get; set; }
+        public string OuterText { get; set; }
+        public HtmlElement Parent { get; }
+        public int ScrollLeft { get; set; }
+        public Rectangle ScrollRectangle { get; }
+        public int ScrollTop { get; set; }
+        public string Style { get; set; }
+        public short TabIndex { get; set; }
+        public string TagName { get; }
+        public event HtmlElementEventHandler Click;
+        public event HtmlElementEventHandler DoubleClick;
+        public event HtmlElementEventHandler Drag;
+        public event HtmlElementEventHandler DragEnd;
+        public event HtmlElementEventHandler DragLeave;
+        public event HtmlElementEventHandler DragOver;
+        public event HtmlElementEventHandler Focusing;
+        public event HtmlElementEventHandler GotFocus;
+        public event HtmlElementEventHandler KeyDown;
+        public event HtmlElementEventHandler KeyPress;
+        public event HtmlElementEventHandler KeyUp;
+        public event HtmlElementEventHandler LosingFocus;
+        public event HtmlElementEventHandler LostFocus;
+        public event HtmlElementEventHandler MouseDown;
+        public event HtmlElementEventHandler MouseEnter;
+        public event HtmlElementEventHandler MouseLeave;
+        public event HtmlElementEventHandler MouseMove;
+        public event HtmlElementEventHandler MouseOver;
+        public event HtmlElementEventHandler MouseUp;
+        public HtmlElement AppendChild(HtmlElement newElement);
+        public void AttachEventHandler(string eventName, EventHandler eventHandler);
+        public void DetachEventHandler(string eventName, EventHandler eventHandler);
+        public override bool Equals(object obj);
+        public void Focus();
+        public string GetAttribute(string attributeName);
+        public HtmlElementCollection GetElementsByTagName(string tagName);
+        public override int GetHashCode();
+        public HtmlElement InsertAdjacentElement(HtmlElementInsertionOrientation orient, HtmlElement newElement);
+        public object InvokeMember(string methodName);
+        public object InvokeMember(string methodName, params object[] parameter);
+        public static bool operator ==(HtmlElement left, HtmlElement right);
+        public static bool operator !=(HtmlElement left, HtmlElement right);
+        public void RaiseEvent(string eventName);
+        public void RemoveFocus();
+        public void ScrollIntoView(bool alignWithTop);
+        public void SetAttribute(string attributeName, string value);
+    }
+    public sealed class HtmlElementCollection : ICollection, IEnumerable {
+        public int Count { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        public HtmlElement this[int index] { get; }
+        public HtmlElement this[string elementId] { get; }
+        public HtmlElementCollection GetElementsByName(string name);
+        public IEnumerator GetEnumerator();
+        void System.Collections.ICollection.CopyTo(Array dest, int index);
+    }
+    public sealed class HtmlElementErrorEventArgs : EventArgs {
+        public string Description { get; }
+        public bool Handled { get; set; }
+        public int LineNumber { get; }
+        public Uri Url { get; }
+    }
+    public delegate void HtmlElementErrorEventHandler(object sender, HtmlElementErrorEventArgs e);
+    public sealed class HtmlElementEventArgs : EventArgs {
+        public bool AltKeyPressed { get; }
+        public bool BubbleEvent { get; set; }
+        public Point ClientMousePosition { get; }
+        public bool CtrlKeyPressed { get; }
+        public string EventType { get; }
+        public HtmlElement FromElement { get; }
+        public int KeyPressedCode { get; }
+        public MouseButtons MouseButtonsPressed { get; }
+        public Point MousePosition { get; }
+        public Point OffsetMousePosition { get; }
+        public bool ReturnValue { get; set; }
+        public bool ShiftKeyPressed { get; }
+        public HtmlElement ToElement { get; }
+    }
+    public delegate void HtmlElementEventHandler(object sender, HtmlElementEventArgs e);
+    public enum HtmlElementInsertionOrientation {
+        AfterBegin = 1,
+        AfterEnd = 3,
+        BeforeBegin = 0,
+        BeforeEnd = 2,
+    }
+    public sealed class HtmlHistory : IDisposable {
+        public object DomHistory { get; }
+        public int Length { get; }
+        public void Back(int numberBack);
+        public void Dispose();
+        public void Forward(int numberForward);
+        public void Go(int relativePosition);
+        public void Go(string urlString);
+        public void Go(Uri url);
+    }
+    public sealed class HtmlWindow {
+        public HtmlDocument Document { get; }
+        public object DomWindow { get; }
+        public HtmlWindowCollection Frames { get; }
+        public HtmlHistory History { get; }
+        public bool IsClosed { get; }
+        public string Name { get; set; }
+        public HtmlWindow Opener { get; }
+        public HtmlWindow Parent { get; }
+        public Point Position { get; }
+        public Size Size { get; set; }
+        public string StatusBarText { get; set; }
+        public Uri Url { get; }
+        public HtmlElement WindowFrameElement { get; }
+        public event HtmlElementErrorEventHandler Error;
+        public event HtmlElementEventHandler GotFocus;
+        public event HtmlElementEventHandler Load;
+        public event HtmlElementEventHandler LostFocus;
+        public event HtmlElementEventHandler Resize;
+        public event HtmlElementEventHandler Scroll;
+        public event HtmlElementEventHandler Unload;
+        public void Alert(string message);
+        public void AttachEventHandler(string eventName, EventHandler eventHandler);
+        public void Close();
+        public bool Confirm(string message);
+        public void DetachEventHandler(string eventName, EventHandler eventHandler);
+        public override bool Equals(object obj);
+        public void Focus();
+        public override int GetHashCode();
+        public void MoveTo(Point point);
+        public void MoveTo(int x, int y);
+        public void Navigate(string urlString);
+        public void Navigate(Uri url);
+        public HtmlWindow Open(string urlString, string target, string windowOptions, bool replaceEntry);
+        public HtmlWindow Open(Uri url, string target, string windowOptions, bool replaceEntry);
+        public HtmlWindow OpenNew(string urlString, string windowOptions);
+        public HtmlWindow OpenNew(Uri url, string windowOptions);
+        public static bool operator ==(HtmlWindow left, HtmlWindow right);
+        public static bool operator !=(HtmlWindow left, HtmlWindow right);
+        public string Prompt(string message, string defaultInputValue);
+        public void RemoveFocus();
+        public void ResizeTo(Size size);
+        public void ResizeTo(int width, int height);
+        public void ScrollTo(Point point);
+        public void ScrollTo(int x, int y);
+    }
+    public class HtmlWindowCollection : ICollection, IEnumerable {
+        public int Count { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        public HtmlWindow this[int index] { get; }
+        public HtmlWindow this[string windowId] { get; }
+        public IEnumerator GetEnumerator();
+        void System.Collections.ICollection.CopyTo(Array dest, int index);
+    }
+    public interface IBindableComponent : IComponent, IDisposable {
+        BindingContext BindingContext { get; set; }
+        ControlBindingsCollection DataBindings { get; }
+    }
+    public interface IButtonControl {
+        DialogResult DialogResult { get; set; }
+        void NotifyDefault(bool value);
+        void PerformClick();
+    }
+    public interface ICommandExecutor {
+        void Execute();
+    }
+    public interface IComponentEditorPageSite {
+        Control GetControl();
+        void SetDirty();
+    }
+    public interface IContainerControl {
+        Control ActiveControl { get; set; }
+        bool ActivateControl(Control active);
+    }
+    public interface ICurrencyManagerProvider {
+        CurrencyManager CurrencyManager { get; }
+        CurrencyManager GetRelatedCurrencyManager(string dataMember);
+    }
+    public interface IDataGridColumnStyleEditingNotificationService {
+        void ColumnStartedEditing(Control editingControl);
+    }
+    public interface IDataGridEditingService {
+        bool BeginEdit(DataGridColumnStyle gridColumn, int rowNumber);
+        bool EndEdit(DataGridColumnStyle gridColumn, int rowNumber, bool shouldAbort);
+    }
+    public interface IDataGridViewEditingCell {
+        object EditingCellFormattedValue { get; set; }
+        bool EditingCellValueChanged { get; set; }
+        object GetEditingCellFormattedValue(DataGridViewDataErrorContexts context);
+        void PrepareEditingCellForEdit(bool selectAll);
+    }
+    public interface IDataGridViewEditingControl {
+        DataGridView EditingControlDataGridView { get; set; }
+        object EditingControlFormattedValue { get; set; }
+        int EditingControlRowIndex { get; set; }
+        bool EditingControlValueChanged { get; set; }
+        Cursor EditingPanelCursor { get; }
+        bool RepositionEditingControlOnValueChange { get; }
+        void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle);
+        bool EditingControlWantsInputKey(Keys keyData, bool dataGridViewWantsInputKey);
+        object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context);
+        void PrepareEditingControlForEdit(bool selectAll);
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
+        void SetData(string format, bool autoConvert, object data);
+        void SetData(string format, object data);
+        void SetData(Type format, object data);
+    }
+    public interface IDropTarget {
+        void OnDragDrop(DragEventArgs e);
+        void OnDragEnter(DragEventArgs e);
+        void OnDragLeave(EventArgs e);
+        void OnDragOver(DragEventArgs e);
+    }
+    public interface IFeatureSupport {
+        Version GetVersionPresent(object feature);
+        bool IsPresent(object feature);
+        bool IsPresent(object feature, Version minimumVersion);
+    }
+    public interface IFileReaderService {
+        Stream OpenFileFromSource(string relativePath);
+    }
+    public class ImageIndexConverter : Int32Converter {
+        public ImageIndexConverter();
+        protected virtual bool IncludeNoneAsStandardValue { get; }
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+        public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context);
+        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context);
+        public override bool GetStandardValuesSupported(ITypeDescriptorContext context);
+    }
+    public class ImageKeyConverter : StringConverter {
+        public ImageKeyConverter();
+        protected virtual bool IncludeNoneAsStandardValue { get; }
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+        public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context);
+        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context);
+        public override bool GetStandardValuesSupported(ITypeDescriptorContext context);
+    }
+    public enum ImageLayout {
+        Center = 2,
+        None = 0,
+        Stretch = 3,
+        Tile = 1,
+        Zoom = 4,
+    }
+    public sealed class ImageList : Component {
+        public ImageList();
+        public ImageList(IContainer container);
+        public ColorDepth ColorDepth { get; set; }
+        public IntPtr Handle { get; }
+        public bool HandleCreated { get; }
+        public ImageList.ImageCollection Images { get; }
+        public Size ImageSize { get; set; }
+        public ImageListStreamer ImageStream { get; set; }
+        public object Tag { get; set; }
+        public Color TransparentColor { get; set; }
+        public event EventHandler RecreateHandle;
+        protected override void Dispose(bool disposing);
+        public void Draw(Graphics g, Point pt, int index);
+        public void Draw(Graphics g, int x, int y, int index);
+        public void Draw(Graphics g, int x, int y, int width, int height, int index);
+        public override string ToString();
+        public sealed class ImageCollection : ICollection, IEnumerable, IList {
+            public int Count { get; }
+            public bool Empty { get; }
+            public bool IsReadOnly { get; }
+            public StringCollection Keys { get; }
+            bool System.Collections.ICollection.IsSynchronized { get; }
+            object System.Collections.ICollection.SyncRoot { get; }
+            bool System.Collections.IList.IsFixedSize { get; }
+            object System.Collections.IList.this[int index] { get; set; }
+            public Image this[int index] { get; set; }
+            public Image this[string key] { get; }
+            public void Add(Icon value);
+            public void Add(Image value);
+            public int Add(Image value, Color transparentColor);
+            public void Add(string key, Icon icon);
+            public void Add(string key, Image image);
+            public void AddRange(Image[] images);
+            public int AddStrip(Image value);
+            public void Clear();
+            public bool Contains(Image image);
+            public bool ContainsKey(string key);
+            public IEnumerator GetEnumerator();
+            public int IndexOf(Image image);
+            public int IndexOfKey(string key);
+            public void Remove(Image image);
+            public void RemoveAt(int index);
+            public void RemoveByKey(string key);
+            public void SetKeyName(int index, string name);
+            void System.Collections.ICollection.CopyTo(Array dest, int index);
+            int System.Collections.IList.Add(object value);
+            bool System.Collections.IList.Contains(object image);
+            int System.Collections.IList.IndexOf(object image);
+            void System.Collections.IList.Insert(int index, object value);
+            void System.Collections.IList.Remove(object image);
+        }
+    }
+    public sealed class ImageListStreamer : IDisposable, ISerializable {
+        public void Dispose();
+        public void GetObjectData(SerializationInfo si, StreamingContext context);
+    }
+    public static class ImeContext {
+        public static void Disable(IntPtr handle);
+        public static void Enable(IntPtr handle);
+        public static ImeMode GetImeMode(IntPtr handle);
+        public static bool IsOpen(IntPtr handle);
+        public static void SetImeStatus(ImeMode imeMode, IntPtr handle);
+        public static void SetOpenStatus(bool open, IntPtr handle);
+    }
+    public enum ImeMode {
+        Alpha = 8,
+        AlphaFull = 7,
+        Close = 11,
+        Disable = 3,
+        Hangul = 10,
+        HangulFull = 9,
+        Hiragana = 4,
+        Inherit = -1,
+        Katakana = 5,
+        KatakanaHalf = 6,
+        NoControl = 0,
+        Off = 2,
+        On = 1,
+        OnHalf = 12,
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct ImeModeConversion {
+        public static Dictionary<ImeMode, ImeModeConversion> ImeModeConversionBits { get; }
+        public static bool IsCurrentConversionTableSupported { get; }
+    }
+    public interface IMessageFilter {
+        bool PreFilterMessage(ref Message m);
+    }
+    public sealed class InputLanguage {
+        public CultureInfo Culture { get; }
+        public static InputLanguage CurrentInputLanguage { get; set; }
+        public static InputLanguage DefaultInputLanguage { get; }
+        public IntPtr Handle { get; }
+        public static InputLanguageCollection InstalledInputLanguages { get; }
+        public string LayoutName { get; }
+        public override bool Equals(object value);
+        public static InputLanguage FromCulture(CultureInfo culture);
+        public override int GetHashCode();
+    }
+    public class InputLanguageChangedEventArgs : EventArgs {
+        public InputLanguageChangedEventArgs(CultureInfo culture, byte charSet);
+        public InputLanguageChangedEventArgs(InputLanguage inputLanguage, byte charSet);
+        public byte CharSet { get; }
+        public CultureInfo Culture { get; }
+        public InputLanguage InputLanguage { get; }
+    }
+    public delegate void InputLanguageChangedEventHandler(object sender, InputLanguageChangedEventArgs e);
+    public class InputLanguageChangingEventArgs : CancelEventArgs {
+        public InputLanguageChangingEventArgs(CultureInfo culture, bool sysCharSet);
+        public InputLanguageChangingEventArgs(InputLanguage inputLanguage, bool sysCharSet);
+        public CultureInfo Culture { get; }
+        public InputLanguage InputLanguage { get; }
+        public bool SysCharSet { get; }
+    }
+    public delegate void InputLanguageChangingEventHandler(object sender, InputLanguageChangingEventArgs e);
+    public class InputLanguageCollection : ReadOnlyCollectionBase {
+        public InputLanguage this[int index] { get; }
+        public bool Contains(InputLanguage value);
+        public void CopyTo(InputLanguage[] array, int index);
+        public int IndexOf(InputLanguage value);
+    }
+    public enum InsertKeyMode {
+        Default = 0,
+        Insert = 1,
+        Overwrite = 2,
+    }
+    public class InvalidateEventArgs : EventArgs {
+        public InvalidateEventArgs(Rectangle invalidRect);
+        public Rectangle InvalidRect { get; }
+    }
+    public delegate void InvalidateEventHandler(object sender, InvalidateEventArgs e);
+    public enum ItemActivation {
+        OneClick = 1,
+        Standard = 0,
+        TwoClick = 2,
+    }
+    public enum ItemBoundsPortion {
+        Entire = 0,
+        Icon = 1,
+        ItemOnly = 3,
+        Label = 2,
+    }
+    public class ItemChangedEventArgs : EventArgs {
+        public int Index { get; }
+    }
+    public delegate void ItemChangedEventHandler(object sender, ItemChangedEventArgs e);
+    public class ItemCheckedEventArgs : EventArgs {
+        public ItemCheckedEventArgs(ListViewItem item);
+        public ListViewItem Item { get; }
+    }
+    public delegate void ItemCheckedEventHandler(object sender, ItemCheckedEventArgs e);
+    public class ItemCheckEventArgs : EventArgs {
+        public ItemCheckEventArgs(int index, CheckState newCheckValue, CheckState currentValue);
+        public CheckState CurrentValue { get; }
+        public int Index { get; }
+        public CheckState NewValue { get; set; }
+    }
+    public delegate void ItemCheckEventHandler(object sender, ItemCheckEventArgs e);
+    public class ItemDragEventArgs : EventArgs {
+        public ItemDragEventArgs(MouseButtons button);
+        public ItemDragEventArgs(MouseButtons button, object item);
+        public MouseButtons Button { get; }
+        public object Item { get; }
+    }
+    public delegate void ItemDragEventHandler(object sender, ItemDragEventArgs e);
+    public interface IWin32Window {
+        IntPtr Handle { get; }
+    }
+    public interface IWindowTarget {
+        void OnHandleChange(IntPtr newHandle);
+        void OnMessage(ref Message m);
+    }
+    public class KeyEventArgs : EventArgs {
+        public KeyEventArgs(Keys keyData);
+        public virtual bool Alt { get; }
+        public bool Control { get; }
+        public bool Handled { get; set; }
+        public Keys KeyCode { get; }
+        public Keys KeyData { get; }
+        public int KeyValue { get; }
+        public Keys Modifiers { get; }
+        public virtual bool Shift { get; }
+        public bool SuppressKeyPress { get; set; }
+    }
+    public delegate void KeyEventHandler(object sender, KeyEventArgs e);
+    public class KeyPressEventArgs : EventArgs {
+        public KeyPressEventArgs(char keyChar);
+        public bool Handled { get; set; }
+        public char KeyChar { get; set; }
+    }
+    public delegate void KeyPressEventHandler(object sender, KeyPressEventArgs e);
+    public enum Keys {
+        A = 65,
+        Add = 107,
+        Alt = 262144,
+        Apps = 93,
+        Attn = 246,
+        B = 66,
+        Back = 8,
+        BrowserBack = 166,
+        BrowserFavorites = 171,
+        BrowserForward = 167,
+        BrowserHome = 172,
+        BrowserRefresh = 168,
+        BrowserSearch = 170,
+        BrowserStop = 169,
+        C = 67,
+        Cancel = 3,
+        Capital = 20,
+        CapsLock = 20,
+        Clear = 12,
+        Control = 131072,
+        ControlKey = 17,
+        Crsel = 247,
+        D = 68,
+        D0 = 48,
+        D1 = 49,
+        D2 = 50,
+        D3 = 51,
+        D4 = 52,
+        D5 = 53,
+        D6 = 54,
+        D7 = 55,
+        D8 = 56,
+        D9 = 57,
+        Decimal = 110,
+        Delete = 46,
+        Divide = 111,
+        Down = 40,
+        E = 69,
+        End = 35,
+        Enter = 13,
+        EraseEof = 249,
+        Escape = 27,
+        Execute = 43,
+        Exsel = 248,
+        F = 70,
+        F1 = 112,
+        F10 = 121,
+        F11 = 122,
+        F12 = 123,
+        F13 = 124,
+        F14 = 125,
+        F15 = 126,
+        F16 = 127,
+        F17 = 128,
+        F18 = 129,
+        F19 = 130,
+        F2 = 113,
+        F20 = 131,
+        F21 = 132,
+        F22 = 133,
+        F23 = 134,
+        F24 = 135,
+        F3 = 114,
+        F4 = 115,
+        F5 = 116,
+        F6 = 117,
+        F7 = 118,
+        F8 = 119,
+        F9 = 120,
+        FinalMode = 24,
+        G = 71,
+        H = 72,
+        HanguelMode = 21,
+        HangulMode = 21,
+        HanjaMode = 25,
+        Help = 47,
+        Home = 36,
+        I = 73,
+        IMEAccept = 30,
+        IMEAceept = 30,
+        IMEConvert = 28,
+        IMEModeChange = 31,
+        IMENonconvert = 29,
+        Insert = 45,
+        J = 74,
+        JunjaMode = 23,
+        K = 75,
+        KanaMode = 21,
+        KanjiMode = 25,
+        KeyCode = 65535,
+        L = 76,
+        LaunchApplication1 = 182,
+        LaunchApplication2 = 183,
+        LaunchMail = 180,
+        LButton = 1,
+        LControlKey = 162,
+        Left = 37,
+        LineFeed = 10,
+        LMenu = 164,
+        LShiftKey = 160,
+        LWin = 91,
+        M = 77,
+        MButton = 4,
+        MediaNextTrack = 176,
+        MediaPlayPause = 179,
+        MediaPreviousTrack = 177,
+        MediaStop = 178,
+        Menu = 18,
+        Modifiers = -65536,
+        Multiply = 106,
+        N = 78,
+        Next = 34,
+        NoName = 252,
+        None = 0,
+        NumLock = 144,
+        NumPad0 = 96,
+        NumPad1 = 97,
+        NumPad2 = 98,
+        NumPad3 = 99,
+        NumPad4 = 100,
+        NumPad5 = 101,
+        NumPad6 = 102,
+        NumPad7 = 103,
+        NumPad8 = 104,
+        NumPad9 = 105,
+        O = 79,
+        Oem1 = 186,
+        Oem102 = 226,
+        Oem2 = 191,
+        Oem3 = 192,
+        Oem4 = 219,
+        Oem5 = 220,
+        Oem6 = 221,
+        Oem7 = 222,
+        Oem8 = 223,
+        OemBackslash = 226,
+        OemClear = 254,
+        OemCloseBrackets = 221,
+        Oemcomma = 188,
+        OemMinus = 189,
+        OemOpenBrackets = 219,
+        OemPeriod = 190,
+        OemPipe = 220,
+        Oemplus = 187,
+        OemQuestion = 191,
+        OemQuotes = 222,
+        OemSemicolon = 186,
+        Oemtilde = 192,
+        P = 80,
+        Pa1 = 253,
+        Packet = 231,
+        PageDown = 34,
+        PageUp = 33,
+        Pause = 19,
+        Play = 250,
+        Print = 42,
+        PrintScreen = 44,
+        Prior = 33,
+        ProcessKey = 229,
+        Q = 81,
+        R = 82,
+        RButton = 2,
+        RControlKey = 163,
+        Return = 13,
+        Right = 39,
+        RMenu = 165,
+        RShiftKey = 161,
+        RWin = 92,
+        S = 83,
+        Scroll = 145,
+        Select = 41,
+        SelectMedia = 181,
+        Separator = 108,
+        Shift = 65536,
+        ShiftKey = 16,
+        Sleep = 95,
+        Snapshot = 44,
+        Space = 32,
+        Subtract = 109,
+        T = 84,
+        Tab = 9,
+        U = 85,
+        Up = 38,
+        V = 86,
+        VolumeDown = 174,
+        VolumeMute = 173,
+        VolumeUp = 175,
+        W = 87,
+        X = 88,
+        XButton1 = 5,
+        XButton2 = 6,
+        Y = 89,
+        Z = 90,
+        Zoom = 251,
+    }
+    public class KeysConverter : TypeConverter, IComparer {
+        public KeysConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public int Compare(object a, object b);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+        public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context);
+        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context);
+        public override bool GetStandardValuesSupported(ITypeDescriptorContext context);
+    }
+    public class Label : Control {
+        public Label();
+        public bool AutoEllipsis { get; set; }
+        public override bool AutoSize { get; set; }
+        public override Image BackgroundImage { get; set; }
+        public override ImageLayout BackgroundImageLayout { get; set; }
+        public virtual BorderStyle BorderStyle { get; set; }
+        protected override CreateParams CreateParams { get; }
+        protected override ImeMode DefaultImeMode { get; }
+        protected override Padding DefaultMargin { get; }
+        protected override Size DefaultSize { get; }
+        public FlatStyle FlatStyle { get; set; }
+        public Image Image { get; set; }
+        public ContentAlignment ImageAlign { get; set; }
+        public int ImageIndex { get; set; }
+        public string ImageKey { get; set; }
+        public ImageList ImageList { get; set; }
+        public new ImeMode ImeMode { get; set; }
+        public virtual int PreferredHeight { get; }
+        public virtual int PreferredWidth { get; }
+        protected virtual new bool RenderTransparent { get; set; }
+        public new bool TabStop { get; set; }
+        public override string Text { get; set; }
+        public virtual ContentAlignment TextAlign { get; set; }
+        public bool UseCompatibleTextRendering { get; set; }
+        public bool UseMnemonic { get; set; }
+        public new event EventHandler AutoSizeChanged;
+        public new event EventHandler BackgroundImageChanged;
+        public new event EventHandler BackgroundImageLayoutChanged;
+        public new event EventHandler ImeModeChanged;
+        public new event KeyEventHandler KeyDown;
+        public new event KeyPressEventHandler KeyPress;
+        public new event KeyEventHandler KeyUp;
+        public new event EventHandler TabStopChanged;
+        public event EventHandler TextAlignChanged;
+        protected Rectangle CalcImageRenderBounds(Image image, Rectangle r, ContentAlignment align);
+        protected override AccessibleObject CreateAccessibilityInstance();
+        protected override void Dispose(bool disposing);
+        protected void DrawImage(Graphics g, Image image, Rectangle r, ContentAlignment align);
+        public override Size GetPreferredSize(Size proposedSize);
+        protected override void OnEnabledChanged(EventArgs e);
+        protected override void OnFontChanged(EventArgs e);
+        protected override void OnHandleDestroyed(EventArgs e);
+        protected override void OnMouseEnter(EventArgs e);
+        protected override void OnMouseLeave(EventArgs e);
+        protected override void OnPaddingChanged(EventArgs e);
+        protected override void OnPaint(PaintEventArgs e);
+        protected override void OnParentChanged(EventArgs e);
+        protected override void OnRightToLeftChanged(EventArgs e);
+        protected virtual void OnTextAlignChanged(EventArgs e);
+        protected override void OnTextChanged(EventArgs e);
+        protected override void OnVisibleChanged(EventArgs e);
+        protected internal override bool ProcessMnemonic(char charCode);
+        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified);
+        public override string ToString();
+        protected override void WndProc(ref Message m);
+    }
+    public class LabelEditEventArgs : EventArgs {
+        public LabelEditEventArgs(int item);
+        public LabelEditEventArgs(int item, string label);
+        public bool CancelEdit { get; set; }
+        public int Item { get; }
+        public string Label { get; }
+    }
+    public delegate void LabelEditEventHandler(object sender, LabelEditEventArgs e);
+    public sealed class LayoutEventArgs : EventArgs {
+        public LayoutEventArgs(IComponent affectedComponent, string affectedProperty);
+        public LayoutEventArgs(Control affectedControl, string affectedProperty);
+        public IComponent AffectedComponent { get; }
+        public Control AffectedControl { get; }
+        public string AffectedProperty { get; }
+    }
+    public delegate void LayoutEventHandler(object sender, LayoutEventArgs e);
+    public abstract class LayoutSettings {
+        protected LayoutSettings();
+        public virtual LayoutEngine LayoutEngine { get; }
+    }
+    public enum LeftRightAlignment {
+        Left = 0,
+        Right = 1,
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct LinkArea {
+        public LinkArea(int start, int length);
+        public bool IsEmpty { get; }
+        public int Length { get; set; }
+        public int Start { get; set; }
+        public override bool Equals(object o);
+        public override int GetHashCode();
+        public static bool operator ==(LinkArea linkArea1, LinkArea linkArea2);
+        public static bool operator !=(LinkArea linkArea1, LinkArea linkArea2);
+        public override string ToString();
+        public class LinkAreaConverter : TypeConverter {
+            public LinkAreaConverter();
+            public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+            public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+            public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+            public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+            public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues);
+            public override bool GetCreateInstanceSupported(ITypeDescriptorContext context);
+            public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes);
+            public override bool GetPropertiesSupported(ITypeDescriptorContext context);
+        }
+    }
+    public enum LinkBehavior {
+        AlwaysUnderline = 1,
+        HoverUnderline = 2,
+        NeverUnderline = 3,
+        SystemDefault = 0,
+    }
+    public class LinkClickedEventArgs : EventArgs {
+        public LinkClickedEventArgs(string linkText);
+        public string LinkText { get; }
+    }
+    public delegate void LinkClickedEventHandler(object sender, LinkClickedEventArgs e);
+    public class LinkConverter : TypeConverter {
+        public LinkConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public class LinkLabel : Label, IButtonControl {
+        public LinkLabel();
+        public Color ActiveLinkColor { get; set; }
+        public Color DisabledLinkColor { get; set; }
+        public new FlatStyle FlatStyle { get; set; }
+        public LinkArea LinkArea { get; set; }
+        public LinkBehavior LinkBehavior { get; set; }
+        public Color LinkColor { get; set; }
+        public LinkLabel.LinkCollection Links { get; }
+        public bool LinkVisited { get; set; }
+        protected Cursor OverrideCursor { get; set; }
+        public new Padding Padding { get; set; }
+        DialogResult System.Windows.Forms.IButtonControl.DialogResult { get; set; }
+        public new bool TabStop { get; set; }
+        public override string Text { get; set; }
+        public new bool UseCompatibleTextRendering { get; set; }
+        public Color VisitedLinkColor { get; set; }
+        public event LinkLabelLinkClickedEventHandler LinkClicked;
+        public new event EventHandler TabStopChanged;
+        protected override AccessibleObject CreateAccessibilityInstance();
+        protected override void CreateHandle();
+        protected override void OnAutoSizeChanged(EventArgs e);
+        protected override void OnEnabledChanged(EventArgs e);
+        protected override void OnFontChanged(EventArgs e);
+        protected override void OnGotFocus(EventArgs e);
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected virtual void OnLinkClicked(LinkLabelLinkClickedEventArgs e);
+        protected override void OnLostFocus(EventArgs e);
+        protected override void OnMouseDown(MouseEventArgs e);
+        protected override void OnMouseLeave(EventArgs e);
+        protected override void OnMouseMove(MouseEventArgs e);
+        protected override void OnMouseUp(MouseEventArgs e);
+        protected override void OnPaddingChanged(EventArgs e);
+        protected override void OnPaint(PaintEventArgs e);
+        protected override void OnPaintBackground(PaintEventArgs e);
+        protected override void OnTextAlignChanged(EventArgs e);
+        protected override void OnTextChanged(EventArgs e);
+        protected LinkLabel.Link PointInLink(int x, int y);
+        protected override bool ProcessDialogKey(Keys keyData);
+        protected override void Select(bool directed, bool forward);
+        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified);
+        void System.Windows.Forms.IButtonControl.NotifyDefault(bool value);
+        void System.Windows.Forms.IButtonControl.PerformClick();
+        protected override void WndProc(ref Message msg);
+        public class Link {
+            public Link();
+            public Link(int start, int length);
+            public Link(int start, int length, object linkData);
+            public string Description { get; set; }
+            public bool Enabled { get; set; }
+            public int Length { get; set; }
+            public object LinkData { get; set; }
+            public string Name { get; set; }
+            public int Start { get; set; }
+            public object Tag { get; set; }
+            public bool Visited { get; set; }
+        }
+        public class LinkCollection : ICollection, IEnumerable, IList {
+            public LinkCollection(LinkLabel owner);
+            public int Count { get; }
+            public bool IsReadOnly { get; }
+            public bool LinksAdded { get; }
+            bool System.Collections.ICollection.IsSynchronized { get; }
+            object System.Collections.ICollection.SyncRoot { get; }
+            bool System.Collections.IList.IsFixedSize { get; }
+            object System.Collections.IList.this[int index] { get; set; }
+            public virtual LinkLabel.Link this[int index] { get; set; }
+            public virtual LinkLabel.Link this[string key] { get; }
+            public int Add(LinkLabel.Link value);
+            public LinkLabel.Link Add(int start, int length);
+            public LinkLabel.Link Add(int start, int length, object linkData);
+            public virtual void Clear();
+            public bool Contains(LinkLabel.Link link);
+            public virtual bool ContainsKey(string key);
+            public IEnumerator GetEnumerator();
+            public int IndexOf(LinkLabel.Link link);
+            public virtual int IndexOfKey(string key);
+            public void Remove(LinkLabel.Link value);
+            public void RemoveAt(int index);
+            public virtual void RemoveByKey(string key);
+            void System.Collections.ICollection.CopyTo(Array dest, int index);
+            int System.Collections.IList.Add(object value);
+            bool System.Collections.IList.Contains(object link);
+            int System.Collections.IList.IndexOf(object link);
+            void System.Collections.IList.Insert(int index, object value);
+            void System.Collections.IList.Remove(object value);
+        }
+    }
+    public class LinkLabelLinkClickedEventArgs : EventArgs {
+        public LinkLabelLinkClickedEventArgs(LinkLabel.Link link);
+        public LinkLabelLinkClickedEventArgs(LinkLabel.Link link, MouseButtons button);
+        public MouseButtons Button { get; }
+        public LinkLabel.Link Link { get; }
+    }
+    public delegate void LinkLabelLinkClickedEventHandler(object sender, LinkLabelLinkClickedEventArgs e);
+    public enum LinkState {
+        Active = 2,
+        Hover = 1,
+        Normal = 0,
+        Visited = 4,
+    }
+    public class ListBindingConverter : TypeConverter {
+        public ListBindingConverter();
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+        public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues);
+        public override bool GetCreateInstanceSupported(ITypeDescriptorContext context);
+    }
+    public static class ListBindingHelper {
+        public static object GetList(object list);
+        public static object GetList(object dataSource, string dataMember);
+        public static PropertyDescriptorCollection GetListItemProperties(object list);
+        public static PropertyDescriptorCollection GetListItemProperties(object list, PropertyDescriptor[] listAccessors);
+        public static PropertyDescriptorCollection GetListItemProperties(object dataSource, string dataMember, PropertyDescriptor[] listAccessors);
+        public static Type GetListItemType(object list);
+        public static Type GetListItemType(object dataSource, string dataMember);
+        public static string GetListName(object list, PropertyDescriptor[] listAccessors);
+    }
+    public class ListBox : ListControl {
+        public const int DefaultItemHeight = 13;
+        public const int NoMatches = -1;
+        public ListBox();
+        protected override bool AllowSelection { get; }
+        public override Color BackColor { get; set; }
+        public override Image BackgroundImage { get; set; }
+        public override ImageLayout BackgroundImageLayout { get; set; }
+        public BorderStyle BorderStyle { get; set; }
+        public int ColumnWidth { get; set; }
+        protected override CreateParams CreateParams { get; }
+        public ListBox.IntegerCollection CustomTabOffsets { get; }
+        protected override Size DefaultSize { get; }
+        public virtual DrawMode DrawMode { get; set; }
+        public override Font Font { get; set; }
+        public override Color ForeColor { get; set; }
+        public int HorizontalExtent { get; set; }
+        public bool HorizontalScrollbar { get; set; }
+        public bool IntegralHeight { get; set; }
+        public virtual int ItemHeight { get; set; }
+        public ListBox.ObjectCollection Items { get; }
+        public bool MultiColumn { get; set; }
+        public new Padding Padding { get; set; }
+        public int PreferredHeight { get; }
+        public override RightToLeft RightToLeft { get; set; }
+        public bool ScrollAlwaysVisible { get; set; }
+        public override int SelectedIndex { get; set; }
+        public ListBox.SelectedIndexCollection SelectedIndices { get; }
+        public object SelectedItem { get; set; }
+        public ListBox.SelectedObjectCollection SelectedItems { get; }
+        public virtual SelectionMode SelectionMode { get; set; }
+        public bool Sorted { get; set; }
+        public override string Text { get; set; }
+        public int TopIndex { get; set; }
+        public bool UseCustomTabOffsets { get; set; }
+        public bool UseTabStops { get; set; }
+        public new event EventHandler BackgroundImageChanged;
+        public new event EventHandler BackgroundImageLayoutChanged;
+        public new event EventHandler Click;
+        public event DrawItemEventHandler DrawItem;
+        public event MeasureItemEventHandler MeasureItem;
+        public new event MouseEventHandler MouseClick;
+        public new event EventHandler PaddingChanged;
+        public new event PaintEventHandler Paint;
+        public event EventHandler SelectedIndexChanged;
+        public new event EventHandler TextChanged;
+        protected virtual void AddItemsCore(object[] value);
+        public void BeginUpdate();
+        public void ClearSelected();
+        protected virtual ListBox.ObjectCollection CreateItemCollection();
+        public void EndUpdate();
+        public int FindString(string s);
+        public int FindString(string s, int startIndex);
+        public int FindStringExact(string s);
+        public int FindStringExact(string s, int startIndex);
+        public int GetItemHeight(int index);
+        public Rectangle GetItemRectangle(int index);
+        protected override Rectangle GetScaledBounds(Rectangle bounds, SizeF factor, BoundsSpecified specified);
+        public bool GetSelected(int index);
+        public int IndexFromPoint(Point p);
+        public int IndexFromPoint(int x, int y);
+        protected override void OnChangeUICues(UICuesEventArgs e);
+        protected override void OnDataSourceChanged(EventArgs e);
+        protected override void OnDisplayMemberChanged(EventArgs e);
+        protected virtual void OnDrawItem(DrawItemEventArgs e);
+        protected override void OnFontChanged(EventArgs e);
+        protected override void OnHandleCreated(EventArgs e);
+        protected override void OnHandleDestroyed(EventArgs e);
+        protected virtual void OnMeasureItem(MeasureItemEventArgs e);
+        protected override void OnParentChanged(EventArgs e);
+        protected override void OnResize(EventArgs e);
+        protected override void OnSelectedIndexChanged(EventArgs e);
+        protected override void OnSelectedValueChanged(EventArgs e);
+        public override void Refresh();
+        protected override void RefreshItem(int index);
+        protected override void RefreshItems();
+        public override void ResetBackColor();
+        public override void ResetForeColor();
+        protected override void ScaleControl(SizeF factor, BoundsSpecified specified);
+        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified);
+        protected override void SetItemCore(int index, object value);
+        protected override void SetItemsCore(IList value);
+        public void SetSelected(int index, bool value);
+        protected virtual void Sort();
+        public override string ToString();
+        protected virtual void WmReflectCommand(ref Message m);
+        protected override void WndProc(ref Message m);
+        public class IntegerCollection : ICollection, IEnumerable, IList {
+            public IntegerCollection(ListBox owner);
+            public int Count { get; }
+            bool System.Collections.ICollection.IsSynchronized { get; }
+            object System.Collections.ICollection.SyncRoot { get; }
+            bool System.Collections.IList.IsFixedSize { get; }
+            bool System.Collections.IList.IsReadOnly { get; }
+            object System.Collections.IList.this[int index] { get; set; }
+            public int this[int index] { get; set; }
+            public int Add(int item);
+            public void AddRange(ListBox.IntegerCollection value);
+            public void AddRange(int[] items);
+            public void Clear();
+            public bool Contains(int item);
+            public void CopyTo(Array destination, int index);
+            public int IndexOf(int item);
+            public void Remove(int item);
+            public void RemoveAt(int index);
+            IEnumerator System.Collections.IEnumerable.GetEnumerator();
+            int System.Collections.IList.Add(object item);
+            void System.Collections.IList.Clear();
+            bool System.Collections.IList.Contains(object item);
+            int System.Collections.IList.IndexOf(object item);
+            void System.Collections.IList.Insert(int index, object value);
+            void System.Collections.IList.Remove(object value);
+            void System.Collections.IList.RemoveAt(int index);
+        }
+        public class ObjectCollection : ICollection, IEnumerable, IList {
+            public ObjectCollection(ListBox owner);
+            public ObjectCollection(ListBox owner, ListBox.ObjectCollection value);
+            public ObjectCollection(ListBox owner, object[] value);
+            public int Count { get; }
+            public bool IsReadOnly { get; }
+            bool System.Collections.ICollection.IsSynchronized { get; }
+            object System.Collections.ICollection.SyncRoot { get; }
+            bool System.Collections.IList.IsFixedSize { get; }
+            public virtual object this[int index] { get; set; }
+            public int Add(object item);
+            public void AddRange(ListBox.ObjectCollection value);
+            public void AddRange(object[] items);
+            public virtual void Clear();
+            public bool Contains(object value);
+            public void CopyTo(object[] destination, int arrayIndex);
+            public IEnumerator GetEnumerator();
+            public int IndexOf(object value);
+            public void Insert(int index, object item);
+            public void Remove(object value);
+            public void RemoveAt(int index);
+            void System.Collections.ICollection.CopyTo(Array destination, int index);
+            int System.Collections.IList.Add(object item);
+        }
+        public class SelectedIndexCollection : ICollection, IEnumerable, IList {
+            public SelectedIndexCollection(ListBox owner);
+            public int Count { get; }
+            public bool IsReadOnly { get; }
+            bool System.Collections.ICollection.IsSynchronized { get; }
+            object System.Collections.ICollection.SyncRoot { get; }
+            bool System.Collections.IList.IsFixedSize { get; }
+            object System.Collections.IList.this[int index] { get; set; }
+            public int this[int index] { get; }
+            public void Add(int index);
+            public void Clear();
+            public bool Contains(int selectedIndex);
+            public void CopyTo(Array destination, int index);
+            public IEnumerator GetEnumerator();
+            public int IndexOf(int selectedIndex);
+            public void Remove(int index);
+            int System.Collections.IList.Add(object value);
+            void System.Collections.IList.Clear();
+            bool System.Collections.IList.Contains(object selectedIndex);
+            int System.Collections.IList.IndexOf(object selectedIndex);
+            void System.Collections.IList.Insert(int index, object value);
+            void System.Collections.IList.Remove(object value);
+            void System.Collections.IList.RemoveAt(int index);
+        }
+        public class SelectedObjectCollection : ICollection, IEnumerable, IList {
+            public SelectedObjectCollection(ListBox owner);
+            public int Count { get; }
+            public bool IsReadOnly { get; }
+            bool System.Collections.ICollection.IsSynchronized { get; }
+            object System.Collections.ICollection.SyncRoot { get; }
+            bool System.Collections.IList.IsFixedSize { get; }
+            public object this[int index] { get; set; }
+            public void Add(object value);
+            public void Clear();
+            public bool Contains(object selectedObject);
+            public void CopyTo(Array destination, int index);
+            public IEnumerator GetEnumerator();
+            public int IndexOf(object selectedObject);
+            public void Remove(object value);
+            int System.Collections.IList.Add(object value);
+            void System.Collections.IList.Clear();
+            void System.Collections.IList.Insert(int index, object value);
+            void System.Collections.IList.Remove(object value);
+            void System.Collections.IList.RemoveAt(int index);
+        }
+    }
+    public abstract class ListControl : Control {
+        protected ListControl();
+        protected virtual bool AllowSelection { get; }
+        protected CurrencyManager DataManager { get; }
+        public object DataSource { get; set; }
+        public string DisplayMember { get; set; }
+        public IFormatProvider FormatInfo { get; set; }
+        public string FormatString { get; set; }
+        public bool FormattingEnabled { get; set; }
+        public abstract int SelectedIndex { get; set; }
+        public object SelectedValue { get; set; }
+        public string ValueMember { get; set; }
+        public event EventHandler DataSourceChanged;
+        public event EventHandler DisplayMemberChanged;
+        public event ListControlConvertEventHandler Format;
+        public event EventHandler FormatInfoChanged;
+        public event EventHandler FormatStringChanged;
+        public event EventHandler FormattingEnabledChanged;
+        public event EventHandler SelectedValueChanged;
+        public event EventHandler ValueMemberChanged;
+        protected object FilterItemOnProperty(object item);
+        protected object FilterItemOnProperty(object item, string field);
+        public string GetItemText(object item);
+        protected override bool IsInputKey(Keys keyData);
+        protected override void OnBindingContextChanged(EventArgs e);
+        protected virtual void OnDataSourceChanged(EventArgs e);
+        protected virtual void OnDisplayMemberChanged(EventArgs e);
+        protected virtual void OnFormat(ListControlConvertEventArgs e);
+        protected virtual void OnFormatInfoChanged(EventArgs e);
+        protected virtual void OnFormatStringChanged(EventArgs e);
+        protected virtual void OnFormattingEnabledChanged(EventArgs e);
+        protected virtual void OnSelectedIndexChanged(EventArgs e);
+        protected virtual void OnSelectedValueChanged(EventArgs e);
+        protected virtual void OnValueMemberChanged(EventArgs e);
+        protected abstract void RefreshItem(int index);
+        protected virtual void RefreshItems();
+        protected virtual void SetItemCore(int index, object value);
+        protected abstract void SetItemsCore(IList items);
+    }
+    public class ListControlConvertEventArgs : ConvertEventArgs {
+        public ListControlConvertEventArgs(object value, Type desiredType, object listItem);
+        public object ListItem { get; }
+    }
+    public delegate void ListControlConvertEventHandler(object sender, ListControlConvertEventArgs e);
+    public class ListView : Control {
+        public ListView();
+        public ItemActivation Activation { get; set; }
+        public ListViewAlignment Alignment { get; set; }
+        public bool AllowColumnReorder { get; set; }
+        public bool AutoArrange { get; set; }
+        public override Color BackColor { get; set; }
+        public override ImageLayout BackgroundImageLayout { get; set; }
+        public bool BackgroundImageTiled { get; set; }
+        public BorderStyle BorderStyle { get; set; }
+        public bool CheckBoxes { get; set; }
+        public ListView.CheckedIndexCollection CheckedIndices { get; }
+        public ListView.CheckedListViewItemCollection CheckedItems { get; }
+        public ListView.ColumnHeaderCollection Columns { get; }
+        protected override CreateParams CreateParams { get; }
+        protected override Size DefaultSize { get; }
+        protected override bool DoubleBuffered { get; set; }
+        public ListViewItem FocusedItem { get; set; }
+        public override Color ForeColor { get; set; }
+        public bool FullRowSelect { get; set; }
+        public bool GridLines { get; set; }
+        public ListViewGroupCollection Groups { get; }
+        public ColumnHeaderStyle HeaderStyle { get; set; }
+        public bool HideSelection { get; set; }
+        public bool HotTracking { get; set; }
+        public bool HoverSelection { get; set; }
+        public ListViewInsertionMark InsertionMark { get; }
+        public ListView.ListViewItemCollection Items { get; }
+        public bool LabelEdit { get; set; }
+        public bool LabelWrap { get; set; }
+        public ImageList LargeImageList { get; set; }
+        public IComparer ListViewItemSorter { get; set; }
+        public bool MultiSelect { get; set; }
+        public bool OwnerDraw { get; set; }
+        public new Padding Padding { get; set; }
+        public virtual bool RightToLeftLayout { get; set; }
+        public bool Scrollable { get; set; }
+        public ListView.SelectedIndexCollection SelectedIndices { get; }
+        public ListView.SelectedListViewItemCollection SelectedItems { get; }
+        public bool ShowGroups { get; set; }
+        public bool ShowItemToolTips { get; set; }
+        public ImageList SmallImageList { get; set; }
+        public SortOrder Sorting { get; set; }
+        public ImageList StateImageList { get; set; }
+        public override string Text { get; set; }
+        public Size TileSize { get; set; }
+        public ListViewItem TopItem { get; set; }
+        public bool UseCompatibleStateImageBehavior { get; set; }
+        public View View { get; set; }
+        public int VirtualListSize { get; set; }
+        public bool VirtualMode { get; set; }
+        public event LabelEditEventHandler AfterLabelEdit;
+        public new event EventHandler BackgroundImageLayoutChanged;
+        public event LabelEditEventHandler BeforeLabelEdit;
+        public event CacheVirtualItemsEventHandler CacheVirtualItems;
+        public event ColumnClickEventHandler ColumnClick;
+        public event ColumnReorderedEventHandler ColumnReordered;
+        public event ColumnWidthChangedEventHandler ColumnWidthChanged;
+        public event ColumnWidthChangingEventHandler ColumnWidthChanging;
+        public event DrawListViewColumnHeaderEventHandler DrawColumnHeader;
+        public event DrawListViewItemEventHandler DrawItem;
+        public event DrawListViewSubItemEventHandler DrawSubItem;
+        public event EventHandler ItemActivate;
+        public event ItemCheckEventHandler ItemCheck;
+        public event ItemCheckedEventHandler ItemChecked;
+        public event ItemDragEventHandler ItemDrag;
+        public event ListViewItemMouseHoverEventHandler ItemMouseHover;
+        public event ListViewItemSelectionChangedEventHandler ItemSelectionChanged;
+        public new event EventHandler PaddingChanged;
+        public new event PaintEventHandler Paint;
+        public event RetrieveVirtualItemEventHandler RetrieveVirtualItem;
+        public event EventHandler RightToLeftLayoutChanged;
+        public event SearchForVirtualItemEventHandler SearchForVirtualItem;
+        public event EventHandler SelectedIndexChanged;
+        public new event EventHandler TextChanged;
+        public event ListViewVirtualItemsSelectionRangeChangedEventHandler VirtualItemsSelectionRangeChanged;
+        public void ArrangeIcons();
+        public void ArrangeIcons(ListViewAlignment value);
+        public void AutoResizeColumn(int columnIndex, ColumnHeaderAutoResizeStyle headerAutoResize);
+        public void AutoResizeColumns(ColumnHeaderAutoResizeStyle headerAutoResize);
+        public void BeginUpdate();
+        public void Clear();
+        protected override void CreateHandle();
+        protected override void Dispose(bool disposing);
+        public void EndUpdate();
+        public void EnsureVisible(int index);
+        public ListViewItem FindItemWithText(string text);
+        public ListViewItem FindItemWithText(string text, bool includeSubItemsInSearch, int startIndex);
+        public ListViewItem FindItemWithText(string text, bool includeSubItemsInSearch, int startIndex, bool isPrefixSearch);
+        public ListViewItem FindNearestItem(SearchDirectionHint dir, Point point);
+        public ListViewItem FindNearestItem(SearchDirectionHint searchDirection, int x, int y);
+        public ListViewItem GetItemAt(int x, int y);
+        public Rectangle GetItemRect(int index);
+        public Rectangle GetItemRect(int index, ItemBoundsPortion portion);
+        public ListViewHitTestInfo HitTest(Point point);
+        public ListViewHitTestInfo HitTest(int x, int y);
+        protected override bool IsInputKey(Keys keyData);
+        protected virtual void OnAfterLabelEdit(LabelEditEventArgs e);
+        protected override void OnBackgroundImageChanged(EventArgs e);
+        protected virtual void OnBeforeLabelEdit(LabelEditEventArgs e);
+        protected virtual void OnCacheVirtualItems(CacheVirtualItemsEventArgs e);
+        protected virtual void OnColumnClick(ColumnClickEventArgs e);
+        protected virtual void OnColumnReordered(ColumnReorderedEventArgs e);
+        protected virtual void OnColumnWidthChanged(ColumnWidthChangedEventArgs e);
+        protected virtual void OnColumnWidthChanging(ColumnWidthChangingEventArgs e);
+        protected virtual void OnDrawColumnHeader(DrawListViewColumnHeaderEventArgs e);
+        protected virtual void OnDrawItem(DrawListViewItemEventArgs e);
+        protected virtual void OnDrawSubItem(DrawListViewSubItemEventArgs e);
+        protected override void OnFontChanged(EventArgs e);
+        protected override void OnHandleCreated(EventArgs e);
+        protected override void OnHandleDestroyed(EventArgs e);
+        protected virtual void OnItemActivate(EventArgs e);
+        protected virtual void OnItemCheck(ItemCheckEventArgs ice);
+        protected virtual void OnItemChecked(ItemCheckedEventArgs e);
+        protected virtual void OnItemDrag(ItemDragEventArgs e);
+        protected virtual void OnItemMouseHover(ListViewItemMouseHoverEventArgs e);
+        protected virtual void OnItemSelectionChanged(ListViewItemSelectionChangedEventArgs e);
+        protected override void OnMouseHover(EventArgs e);
+        protected override void OnMouseLeave(EventArgs e);
+        protected override void OnParentChanged(EventArgs e);
+        protected override void OnResize(EventArgs e);
+        protected virtual void OnRetrieveVirtualItem(RetrieveVirtualItemEventArgs e);
+        protected virtual void OnRightToLeftLayoutChanged(EventArgs e);
+        protected virtual void OnSearchForVirtualItem(SearchForVirtualItemEventArgs e);
+        protected virtual void OnSelectedIndexChanged(EventArgs e);
+        protected override void OnSystemColorsChanged(EventArgs e);
+        protected virtual void OnVirtualItemsSelectionRangeChanged(ListViewVirtualItemsSelectionRangeChangedEventArgs e);
+        protected void RealizeProperties();
+        public void RedrawItems(int startIndex, int endIndex, bool invalidateOnly);
+        public void Sort();
+        public override string ToString();
+        protected void UpdateExtendedStyles();
+        protected override void WndProc(ref Message m);
+        public class CheckedIndexCollection : ICollection, IEnumerable, IList {
+            public CheckedIndexCollection(ListView owner);
+            public int Count { get; }
+            public bool IsReadOnly { get; }
+            bool System.Collections.ICollection.IsSynchronized { get; }
+            object System.Collections.ICollection.SyncRoot { get; }
+            bool System.Collections.IList.IsFixedSize { get; }
+            object System.Collections.IList.this[int index] { get; set; }
+            public int this[int index] { get; }
+            public bool Contains(int checkedIndex);
+            public IEnumerator GetEnumerator();
+            public int IndexOf(int checkedIndex);
+            void System.Collections.ICollection.CopyTo(Array dest, int index);
+            int System.Collections.IList.Add(object value);
+            void System.Collections.IList.Clear();
+            bool System.Collections.IList.Contains(object checkedIndex);
+            int System.Collections.IList.IndexOf(object checkedIndex);
+            void System.Collections.IList.Insert(int index, object value);
+            void System.Collections.IList.Remove(object value);
+            void System.Collections.IList.RemoveAt(int index);
+        }
+        public class CheckedListViewItemCollection : ICollection, IEnumerable, IList {
+            public CheckedListViewItemCollection(ListView owner);
+            public int Count { get; }
+            public bool IsReadOnly { get; }
+            bool System.Collections.ICollection.IsSynchronized { get; }
+            object System.Collections.ICollection.SyncRoot { get; }
+            bool System.Collections.IList.IsFixedSize { get; }
+            object System.Collections.IList.this[int index] { get; set; }
+            public ListViewItem this[int index] { get; }
+            public virtual ListViewItem this[string key] { get; }
+            public bool Contains(ListViewItem item);
+            public virtual bool ContainsKey(string key);
+            public void CopyTo(Array dest, int index);
+            public IEnumerator GetEnumerator();
+            public int IndexOf(ListViewItem item);
+            public virtual int IndexOfKey(string key);
+            int System.Collections.IList.Add(object value);
+            void System.Collections.IList.Clear();
+            bool System.Collections.IList.Contains(object item);
+            int System.Collections.IList.IndexOf(object item);
+            void System.Collections.IList.Insert(int index, object value);
+            void System.Collections.IList.Remove(object value);
+            void System.Collections.IList.RemoveAt(int index);
+        }
+        public class ColumnHeaderCollection : ICollection, IEnumerable, IList {
+            public ColumnHeaderCollection(ListView owner);
+            public int Count { get; }
+            public bool IsReadOnly { get; }
+            bool System.Collections.ICollection.IsSynchronized { get; }
+            object System.Collections.ICollection.SyncRoot { get; }
+            bool System.Collections.IList.IsFixedSize { get; }
+            object System.Collections.IList.this[int index] { get; set; }
+            public virtual ColumnHeader this[int index] { get; }
+            public virtual ColumnHeader this[string key] { get; }
+            public virtual ColumnHeader Add(string text);
+            public virtual ColumnHeader Add(string text, int width);
+            public virtual ColumnHeader Add(string text, int width, HorizontalAlignment textAlign);
+            public virtual ColumnHeader Add(string key, string text);
+            public virtual ColumnHeader Add(string key, string text, int width);
+            public virtual ColumnHeader Add(string key, string text, int width, HorizontalAlignment textAlign, int imageIndex);
+            public virtual ColumnHeader Add(string key, string text, int width, HorizontalAlignment textAlign, string imageKey);
+            public virtual int Add(ColumnHeader value);
+            public virtual void AddRange(ColumnHeader[] values);
+            public virtual void Clear();
+            public bool Contains(ColumnHeader value);
+            public virtual bool ContainsKey(string key);
+            public IEnumerator GetEnumerator();
+            public int IndexOf(ColumnHeader value);
+            public virtual int IndexOfKey(string key);
+            public void Insert(int index, string text);
+            public void Insert(int index, string text, int width);
+            public void Insert(int index, string text, int width, HorizontalAlignment textAlign);
+            public void Insert(int index, string key, string text);
+            public void Insert(int index, string key, string text, int width);
+            public void Insert(int index, string key, string text, int width, HorizontalAlignment textAlign, int imageIndex);
+            public void Insert(int index, string key, string text, int width, HorizontalAlignment textAlign, string imageKey);
+            public void Insert(int index, ColumnHeader value);
+            public virtual void Remove(ColumnHeader column);
+            public virtual void RemoveAt(int index);
+            public virtual void RemoveByKey(string key);
+            void System.Collections.ICollection.CopyTo(Array dest, int index);
+            int System.Collections.IList.Add(object value);
+            bool System.Collections.IList.Contains(object value);
+            int System.Collections.IList.IndexOf(object value);
+            void System.Collections.IList.Insert(int index, object value);
+            void System.Collections.IList.Remove(object value);
+        }
+        public class ListViewItemCollection : ICollection, IEnumerable, IList {
+            public ListViewItemCollection(ListView owner);
+            public int Count { get; }
+            public bool IsReadOnly { get; }
+            bool System.Collections.ICollection.IsSynchronized { get; }
+            object System.Collections.ICollection.SyncRoot { get; }
+            bool System.Collections.IList.IsFixedSize { get; }
+            object System.Collections.IList.this[int index] { get; set; }
+            public virtual ListViewItem this[int index] { get; set; }
+            public virtual ListViewItem this[string key] { get; }
+            public virtual ListViewItem Add(string text);
+            public virtual ListViewItem Add(string text, int imageIndex);
+            public virtual ListViewItem Add(string text, string imageKey);
+            public virtual ListViewItem Add(string key, string text, int imageIndex);
+            public virtual ListViewItem Add(string key, string text, string imageKey);
+            public virtual ListViewItem Add(ListViewItem value);
+            public void AddRange(ListView.ListViewItemCollection items);
+            public void AddRange(ListViewItem[] items);
+            public virtual void Clear();
+            public bool Contains(ListViewItem item);
+            public virtual bool ContainsKey(string key);
+            public void CopyTo(Array dest, int index);
+            public ListViewItem[] Find(string key, bool searchAllSubItems);
+            public IEnumerator GetEnumerator();
+            public int IndexOf(ListViewItem item);
+            public virtual int IndexOfKey(string key);
+            public ListViewItem Insert(int index, string text);
+            public ListViewItem Insert(int index, string text, int imageIndex);
+            public ListViewItem Insert(int index, string text, string imageKey);
+            public virtual ListViewItem Insert(int index, string key, string text, int imageIndex);
+            public virtual ListViewItem Insert(int index, string key, string text, string imageKey);
+            public ListViewItem Insert(int index, ListViewItem item);
+            public virtual void Remove(ListViewItem item);
+            public virtual void RemoveAt(int index);
+            public virtual void RemoveByKey(string key);
+            int System.Collections.IList.Add(object item);
+            bool System.Collections.IList.Contains(object item);
+            int System.Collections.IList.IndexOf(object item);
+            void System.Collections.IList.Insert(int index, object item);
+            void System.Collections.IList.Remove(object item);
+        }
+        public class SelectedIndexCollection : ICollection, IEnumerable, IList {
+            public SelectedIndexCollection(ListView owner);
+            public int Count { get; }
+            public bool IsReadOnly { get; }
+            bool System.Collections.ICollection.IsSynchronized { get; }
+            object System.Collections.ICollection.SyncRoot { get; }
+            bool System.Collections.IList.IsFixedSize { get; }
+            object System.Collections.IList.this[int index] { get; set; }
+            public int this[int index] { get; }
+            public int Add(int itemIndex);
+            public void Clear();
+            public bool Contains(int selectedIndex);
+            public void CopyTo(Array dest, int index);
+            public IEnumerator GetEnumerator();
+            public int IndexOf(int selectedIndex);
+            public void Remove(int itemIndex);
+            int System.Collections.IList.Add(object value);
+            void System.Collections.IList.Clear();
+            bool System.Collections.IList.Contains(object selectedIndex);
+            int System.Collections.IList.IndexOf(object selectedIndex);
+            void System.Collections.IList.Insert(int index, object value);
+            void System.Collections.IList.Remove(object value);
+            void System.Collections.IList.RemoveAt(int index);
+        }
+        public class SelectedListViewItemCollection : ICollection, IEnumerable, IList {
+            public SelectedListViewItemCollection(ListView owner);
+            public int Count { get; }
+            public bool IsReadOnly { get; }
+            bool System.Collections.ICollection.IsSynchronized { get; }
+            object System.Collections.ICollection.SyncRoot { get; }
+            bool System.Collections.IList.IsFixedSize { get; }
+            object System.Collections.IList.this[int index] { get; set; }
+            public ListViewItem this[int index] { get; }
+            public virtual ListViewItem this[string key] { get; }
+            public void Clear();
+            public bool Contains(ListViewItem item);
+            public virtual bool ContainsKey(string key);
+            public void CopyTo(Array dest, int index);
+            public IEnumerator GetEnumerator();
+            public int IndexOf(ListViewItem item);
+            public virtual int IndexOfKey(string key);
+            int System.Collections.IList.Add(object value);
+            bool System.Collections.IList.Contains(object item);
+            int System.Collections.IList.IndexOf(object item);
+            void System.Collections.IList.Insert(int index, object value);
+            void System.Collections.IList.Remove(object value);
+            void System.Collections.IList.RemoveAt(int index);
+        }
+    }
+    public enum ListViewAlignment {
+        Default = 0,
+        Left = 1,
+        SnapToGrid = 5,
+        Top = 2,
+    }
+    public sealed class ListViewGroup : ISerializable {
+        public ListViewGroup();
+        public ListViewGroup(string header);
+        public ListViewGroup(string key, string headerText);
+        public ListViewGroup(string header, HorizontalAlignment headerAlignment);
+        public string Header { get; set; }
+        public HorizontalAlignment HeaderAlignment { get; set; }
+        public ListView.ListViewItemCollection Items { get; }
+        public ListView ListView { get; }
+        public string Name { get; set; }
+        public object Tag { get; set; }
+        void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context);
+        public override string ToString();
+    }
+    public class ListViewGroupCollection : ICollection, IEnumerable, IList {
+        public int Count { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public ListViewGroup this[int index] { get; set; }
+        public ListViewGroup this[string key] { get; set; }
+        public ListViewGroup Add(string key, string headerText);
+        public int Add(ListViewGroup group);
+        public void AddRange(ListViewGroupCollection groups);
+        public void AddRange(ListViewGroup[] groups);
+        public void Clear();
+        public bool Contains(ListViewGroup value);
+        public void CopyTo(Array array, int index);
+        public IEnumerator GetEnumerator();
+        public int IndexOf(ListViewGroup value);
+        public void Insert(int index, ListViewGroup group);
+        public void Remove(ListViewGroup group);
+        public void RemoveAt(int index);
+        int System.Collections.IList.Add(object value);
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+    }
+    public class ListViewHitTestInfo {
+        public ListViewHitTestInfo(ListViewItem hitItem, ListViewItem.ListViewSubItem hitSubItem, ListViewHitTestLocations hitLocation);
+        public ListViewItem Item { get; }
+        public ListViewHitTestLocations Location { get; }
+        public ListViewItem.ListViewSubItem SubItem { get; }
+    }
+    public enum ListViewHitTestLocations {
+        AboveClientArea = 256,
+        BelowClientArea = 16,
+        Image = 2,
+        Label = 4,
+        LeftOfClientArea = 64,
+        None = 1,
+        RightOfClientArea = 32,
+        StateImage = 512,
+    }
+    public sealed class ListViewInsertionMark {
+        public bool AppearsAfterItem { get; set; }
+        public Rectangle Bounds { get; }
+        public Color Color { get; set; }
+        public int Index { get; set; }
+        public int NearestIndex(Point pt);
+    }
+    public class ListViewItem : ICloneable, ISerializable {
+        public ListViewItem();
+        public ListViewItem(ListViewItem.ListViewSubItem[] subItems, int imageIndex);
+        public ListViewItem(ListViewItem.ListViewSubItem[] subItems, int imageIndex, ListViewGroup group);
+        public ListViewItem(ListViewItem.ListViewSubItem[] subItems, string imageKey);
+        public ListViewItem(ListViewItem.ListViewSubItem[] subItems, string imageKey, ListViewGroup group);
+        protected ListViewItem(SerializationInfo info, StreamingContext context);
+        public ListViewItem(string text);
+        public ListViewItem(string text, int imageIndex);
+        public ListViewItem(string text, int imageIndex, ListViewGroup group);
+        public ListViewItem(string text, string imageKey);
+        public ListViewItem(string text, string imageKey, ListViewGroup group);
+        public ListViewItem(string text, ListViewGroup group);
+        public ListViewItem(string[] items);
+        public ListViewItem(string[] items, int imageIndex);
+        public ListViewItem(string[] items, int imageIndex, Color foreColor, Color backColor, Font font);
+        public ListViewItem(string[] items, int imageIndex, Color foreColor, Color backColor, Font font, ListViewGroup group);
+        public ListViewItem(string[] items, int imageIndex, ListViewGroup group);
+        public ListViewItem(string[] items, string imageKey);
+        public ListViewItem(string[] items, string imageKey, Color foreColor, Color backColor, Font font);
+        public ListViewItem(string[] items, string imageKey, Color foreColor, Color backColor, Font font, ListViewGroup group);
+        public ListViewItem(string[] items, string imageKey, ListViewGroup group);
+        public ListViewItem(string[] items, ListViewGroup group);
+        public ListViewItem(ListViewGroup group);
+        public Color BackColor { get; set; }
+        public Rectangle Bounds { get; }
+        public bool Checked { get; set; }
+        public bool Focused { get; set; }
+        public Font Font { get; set; }
+        public Color ForeColor { get; set; }
+        public ListViewGroup Group { get; set; }
+        public int ImageIndex { get; set; }
+        public string ImageKey { get; set; }
+        public ImageList ImageList { get; }
+        public int IndentCount { get; set; }
+        public int Index { get; }
+        public ListView ListView { get; }
+        public string Name { get; set; }
+        public Point Position { get; set; }
+        public bool Selected { get; set; }
+        public int StateImageIndex { get; set; }
+        public ListViewItem.ListViewSubItemCollection SubItems { get; }
+        public object Tag { get; set; }
+        public string Text { get; set; }
+        public string ToolTipText { get; set; }
+        public bool UseItemStyleForSubItems { get; set; }
+        public void BeginEdit();
+        public virtual object Clone();
+        protected virtual void Deserialize(SerializationInfo info, StreamingContext context);
+        public virtual void EnsureVisible();
+        public ListViewItem FindNearestItem(SearchDirectionHint searchDirection);
+        public Rectangle GetBounds(ItemBoundsPortion portion);
+        public ListViewItem.ListViewSubItem GetSubItemAt(int x, int y);
+        public virtual void Remove();
+        protected virtual void Serialize(SerializationInfo info, StreamingContext context);
+        void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context);
+        public override string ToString();
+        public class ListViewSubItem {
+            public ListViewSubItem();
+            public ListViewSubItem(ListViewItem owner, string text);
+            public ListViewSubItem(ListViewItem owner, string text, Color foreColor, Color backColor, Font font);
+            public Color BackColor { get; set; }
+            public Rectangle Bounds { get; }
+            public Font Font { get; set; }
+            public Color ForeColor { get; set; }
+            public string Name { get; set; }
+            public object Tag { get; set; }
+            public string Text { get; set; }
+            public void ResetStyle();
+            public override string ToString();
+        }
+        public class ListViewSubItemCollection : ICollection, IEnumerable, IList {
+            public ListViewSubItemCollection(ListViewItem owner);
+            public int Count { get; }
+            public bool IsReadOnly { get; }
+            bool System.Collections.ICollection.IsSynchronized { get; }
+            object System.Collections.ICollection.SyncRoot { get; }
+            bool System.Collections.IList.IsFixedSize { get; }
+            object System.Collections.IList.this[int index] { get; set; }
+            public ListViewItem.ListViewSubItem this[int index] { get; set; }
+            public virtual ListViewItem.ListViewSubItem this[string key] { get; }
+            public ListViewItem.ListViewSubItem Add(ListViewItem.ListViewSubItem item);
+            public ListViewItem.ListViewSubItem Add(string text);
+            public ListViewItem.ListViewSubItem Add(string text, Color foreColor, Color backColor, Font font);
+            public void AddRange(ListViewItem.ListViewSubItem[] items);
+            public void AddRange(string[] items);
+            public void AddRange(string[] items, Color foreColor, Color backColor, Font font);
+            public void Clear();
+            public bool Contains(ListViewItem.ListViewSubItem subItem);
+            public virtual bool ContainsKey(string key);
+            public IEnumerator GetEnumerator();
+            public int IndexOf(ListViewItem.ListViewSubItem subItem);
+            public virtual int IndexOfKey(string key);
+            public void Insert(int index, ListViewItem.ListViewSubItem item);
+            public void Remove(ListViewItem.ListViewSubItem item);
+            public void RemoveAt(int index);
+            public virtual void RemoveByKey(string key);
+            void System.Collections.ICollection.CopyTo(Array dest, int index);
+            int System.Collections.IList.Add(object item);
+            bool System.Collections.IList.Contains(object subItem);
+            int System.Collections.IList.IndexOf(object subItem);
+            void System.Collections.IList.Insert(int index, object item);
+            void System.Collections.IList.Remove(object item);
+        }
+    }
+    public class ListViewItemConverter : ExpandableObjectConverter {
+        public ListViewItemConverter();
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public class ListViewItemMouseHoverEventArgs : EventArgs {
+        public ListViewItemMouseHoverEventArgs(ListViewItem item);
+        public ListViewItem Item { get; }
+    }
+    public delegate void ListViewItemMouseHoverEventHandler(object sender, ListViewItemMouseHoverEventArgs e);
+    public class ListViewItemSelectionChangedEventArgs : EventArgs {
+        public ListViewItemSelectionChangedEventArgs(ListViewItem item, int itemIndex, bool isSelected);
+        public bool IsSelected { get; }
+        public ListViewItem Item { get; }
+        public int ItemIndex { get; }
+    }
+    public delegate void ListViewItemSelectionChangedEventHandler(object sender, ListViewItemSelectionChangedEventArgs e);
+    public enum ListViewItemStates {
+        Checked = 8,
+        Default = 32,
+        Focused = 16,
+        Grayed = 2,
+        Hot = 64,
+        Indeterminate = 256,
+        Marked = 128,
+        Selected = 1,
+        ShowKeyboardCues = 512,
+    }
+    public class ListViewVirtualItemsSelectionRangeChangedEventArgs : EventArgs {
+        public ListViewVirtualItemsSelectionRangeChangedEventArgs(int startIndex, int endIndex, bool isSelected);
+        public int EndIndex { get; }
+        public bool IsSelected { get; }
+        public int StartIndex { get; }
+    }
+    public delegate void ListViewVirtualItemsSelectionRangeChangedEventHandler(object sender, ListViewVirtualItemsSelectionRangeChangedEventArgs e);
+    public class MainMenu : Menu {
+        public MainMenu();
+        public MainMenu(IContainer container);
+        public MainMenu(MenuItem[] items);
+        public virtual RightToLeft RightToLeft { get; set; }
+        public event EventHandler Collapse;
+        public virtual MainMenu CloneMenu();
+        protected override IntPtr CreateMenuHandle();
+        protected override void Dispose(bool disposing);
+        public Form GetForm();
+        protected internal virtual void OnCollapse(EventArgs e);
+        public override string ToString();
+    }
+    public class MaskedTextBox : TextBoxBase {
+        public MaskedTextBox();
+        public MaskedTextBox(MaskedTextProvider maskedTextProvider);
+        public MaskedTextBox(string mask);
+        public new bool AcceptsTab { get; set; }
+        public bool AllowPromptAsInput { get; set; }
+        public bool AsciiOnly { get; set; }
+        public bool BeepOnError { get; set; }
+        public new bool CanUndo { get; }
+        protected override CreateParams CreateParams { get; }
+        public CultureInfo Culture { get; set; }
+        public MaskFormat CutCopyMaskFormat { get; set; }
+        public IFormatProvider FormatProvider { get; set; }
+        public bool HidePromptOnLeave { get; set; }
+        public InsertKeyMode InsertKeyMode { get; set; }
+        public bool IsOverwriteMode { get; }
+        public new string[] Lines { get; set; }
+        public string Mask { get; set; }
+        public bool MaskCompleted { get; }
+        public MaskedTextProvider MaskedTextProvider { get; }
+        public bool MaskFull { get; }
+        public override int MaxLength { get; set; }
+        public override bool Multiline { get; set; }
+        public char PasswordChar { get; set; }
+        public char PromptChar { get; set; }
+        public new bool ReadOnly { get; set; }
+        public bool RejectInputOnFirstFailure { get; set; }
+        public bool ResetOnPrompt { get; set; }
+        public bool ResetOnSpace { get; set; }
+        public override string SelectedText { get; set; }
+        public bool SkipLiterals { get; set; }
+        public override string Text { get; set; }
+        public HorizontalAlignment TextAlign { get; set; }
+        public override int TextLength { get; }
+        public MaskFormat TextMaskFormat { get; set; }
+        public bool UseSystemPasswordChar { get; set; }
+        public Type ValidatingType { get; set; }
+        public new bool WordWrap { get; set; }
+        public new event EventHandler AcceptsTabChanged;
+        public event EventHandler IsOverwriteModeChanged;
+        public event EventHandler MaskChanged;
+        public event MaskInputRejectedEventHandler MaskInputRejected;
+        public new event EventHandler MultilineChanged;
+        public event EventHandler TextAlignChanged;
+        public event TypeValidationEventHandler TypeValidationCompleted;
+        public new void ClearUndo();
+        protected override void CreateHandle();
+        public override char GetCharFromPosition(Point pt);
+        public override int GetCharIndexFromPosition(Point pt);
+        public new int GetFirstCharIndexFromLine(int lineNumber);
+        public new int GetFirstCharIndexOfCurrentLine();
+        public override int GetLineFromCharIndex(int index);
+        public override Point GetPositionFromCharIndex(int index);
+        protected override bool IsInputKey(Keys keyData);
+        protected override void OnBackColorChanged(EventArgs e);
+        protected override void OnHandleCreated(EventArgs e);
+        protected virtual void OnIsOverwriteModeChanged(EventArgs e);
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected override void OnKeyPress(KeyPressEventArgs e);
+        protected override void OnKeyUp(KeyEventArgs e);
+        protected virtual void OnMaskChanged(EventArgs e);
+        protected override void OnMultilineChanged(EventArgs e);
+        protected virtual void OnTextAlignChanged(EventArgs e);
+        protected override void OnTextChanged(EventArgs e);
+        protected override void OnValidating(CancelEventArgs e);
+        protected override bool ProcessCmdKey(ref Message msg, Keys keyData);
+        protected internal override bool ProcessKeyMessage(ref Message m);
+        public new void ScrollToCaret();
+        public override string ToString();
+        public new void Undo();
+        public object ValidateText();
+        protected override void WndProc(ref Message m);
+    }
+    public enum MaskFormat {
+        ExcludePromptAndLiterals = 0,
+        IncludeLiterals = 2,
+        IncludePrompt = 1,
+        IncludePromptAndLiterals = 3,
+    }
+    public class MaskInputRejectedEventArgs : EventArgs {
+        public MaskInputRejectedEventArgs(int position, MaskedTextResultHint rejectionHint);
+        public int Position { get; }
+        public MaskedTextResultHint RejectionHint { get; }
+    }
+    public delegate void MaskInputRejectedEventHandler(object sender, MaskInputRejectedEventArgs e);
+    public sealed class MdiClient : Control {
+        public MdiClient();
+        public override Image BackgroundImage { get; set; }
+        public override ImageLayout BackgroundImageLayout { get; set; }
+        protected override CreateParams CreateParams { get; }
+        public Form[] MdiChildren { get; }
+        protected override Control.ControlCollection CreateControlsInstance();
+        public void LayoutMdi(MdiLayout value);
+        protected override void OnResize(EventArgs e);
+        protected override void ScaleControl(SizeF factor, BoundsSpecified specified);
+        protected override void ScaleCore(float dx, float dy);
+        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified);
+        protected override void WndProc(ref Message m);
+        public class ControlCollection : Control.ControlCollection {
+            public ControlCollection(MdiClient owner);
+            public override void Add(Control value);
+            public override void Remove(Control value);
+        }
+    }
+    public enum MdiLayout {
+        ArrangeIcons = 3,
+        Cascade = 0,
+        TileHorizontal = 1,
+        TileVertical = 2,
+    }
+    public class MeasureItemEventArgs : EventArgs {
+        public MeasureItemEventArgs(Graphics graphics, int index);
+        public MeasureItemEventArgs(Graphics graphics, int index, int itemHeight);
+        public Graphics Graphics { get; }
+        public int Index { get; }
+        public int ItemHeight { get; set; }
+        public int ItemWidth { get; set; }
+    }
+    public delegate void MeasureItemEventHandler(object sender, MeasureItemEventArgs e);
+    public abstract class Menu : Component {
+        public const int FindHandle = 0;
+        public const int FindShortcut = 1;
+        protected Menu(MenuItem[] items);
+        public IntPtr Handle { get; }
+        public virtual bool IsParent { get; }
+        public MenuItem MdiListItem { get; }
+        public Menu.MenuItemCollection MenuItems { get; }
+        public string Name { get; set; }
+        public object Tag { get; set; }
+        protected internal void CloneMenu(Menu menuSrc);
+        protected virtual IntPtr CreateMenuHandle();
+        protected override void Dispose(bool disposing);
+        public MenuItem FindMenuItem(int type, IntPtr value);
+        protected int FindMergePosition(int mergeOrder);
+        public ContextMenu GetContextMenu();
+        public MainMenu GetMainMenu();
+        public virtual void MergeMenu(Menu menuSrc);
+        protected internal virtual bool ProcessCmdKey(ref Message msg, Keys keyData);
+        public override string ToString();
+        public class MenuItemCollection : ICollection, IEnumerable, IList {
+            public MenuItemCollection(Menu owner);
+            public int Count { get; }
+            public bool IsReadOnly { get; }
+            bool System.Collections.ICollection.IsSynchronized { get; }
+            object System.Collections.ICollection.SyncRoot { get; }
+            bool System.Collections.IList.IsFixedSize { get; }
+            object System.Collections.IList.this[int index] { get; set; }
+            public virtual MenuItem this[int index] { get; }
+            public virtual MenuItem this[string key] { get; }
+            public virtual int Add(int index, MenuItem item);
+            public virtual MenuItem Add(string caption);
+            public virtual MenuItem Add(string caption, EventHandler onClick);
+            public virtual MenuItem Add(string caption, MenuItem[] items);
+            public virtual int Add(MenuItem item);
+            public virtual void AddRange(MenuItem[] items);
+            public virtual void Clear();
+            public bool Contains(MenuItem value);
+            public virtual bool ContainsKey(string key);
+            public void CopyTo(Array dest, int index);
+            public MenuItem[] Find(string key, bool searchAllChildren);
+            public IEnumerator GetEnumerator();
+            public int IndexOf(MenuItem value);
+            public virtual int IndexOfKey(string key);
+            public virtual void Remove(MenuItem item);
+            public virtual void RemoveAt(int index);
+            public virtual void RemoveByKey(string key);
+            int System.Collections.IList.Add(object value);
+            bool System.Collections.IList.Contains(object value);
+            int System.Collections.IList.IndexOf(object value);
+            void System.Collections.IList.Insert(int index, object value);
+            void System.Collections.IList.Remove(object value);
+        }
+    }
+    public enum MenuGlyph {
+        Arrow = 0,
+        Bullet = 2,
+        Checkmark = 1,
+        Max = 2,
+        Min = 0,
+    }
+    public class MenuItem : Menu {
+        public MenuItem();
+        public MenuItem(string text);
+        public MenuItem(string text, EventHandler onClick);
+        public MenuItem(string text, EventHandler onClick, Shortcut shortcut);
+        public MenuItem(string text, MenuItem[] items);
+        public MenuItem(MenuMerge mergeType, int mergeOrder, Shortcut shortcut, string text, EventHandler onClick, EventHandler onPopup, EventHandler onSelect, MenuItem[] items);
+        public bool BarBreak { get; set; }
+        public bool Break { get; set; }
+        public bool Checked { get; set; }
+        public bool DefaultItem { get; set; }
+        public bool Enabled { get; set; }
+        public int Index { get; set; }
+        public override bool IsParent { get; }
+        public bool MdiList { get; set; }
+        protected int MenuID { get; }
+        public int MergeOrder { get; set; }
+        public MenuMerge MergeType { get; set; }
+        public char Mnemonic { get; }
+        public bool OwnerDraw { get; set; }
+        public Menu Parent { get; }
+        public bool RadioCheck { get; set; }
+        public Shortcut Shortcut { get; set; }
+        public bool ShowShortcut { get; set; }
+        public string Text { get; set; }
+        public bool Visible { get; set; }
+        public event EventHandler Click;
+        public event DrawItemEventHandler DrawItem;
+        public event MeasureItemEventHandler MeasureItem;
+        public event EventHandler Popup;
+        public event EventHandler Select;
+        public virtual MenuItem CloneMenu();
+        protected void CloneMenu(MenuItem itemSrc);
+        protected override void Dispose(bool disposing);
+        public virtual MenuItem MergeMenu();
+        public void MergeMenu(MenuItem itemSrc);
+        protected virtual void OnClick(EventArgs e);
+        protected virtual void OnDrawItem(DrawItemEventArgs e);
+        protected virtual void OnInitMenuPopup(EventArgs e);
+        protected virtual void OnMeasureItem(MeasureItemEventArgs e);
+        protected virtual void OnPopup(EventArgs e);
+        protected virtual void OnSelect(EventArgs e);
+        public void PerformClick();
+        public virtual void PerformSelect();
+        public override string ToString();
+    }
+    public enum MenuMerge {
+        Add = 0,
+        MergeItems = 2,
+        Remove = 3,
+        Replace = 1,
+    }
+    public class MenuStrip : ToolStrip {
+        public MenuStrip();
+        public new bool CanOverflow { get; set; }
+        protected override Padding DefaultGripMargin { get; }
+        protected override Padding DefaultPadding { get; }
+        protected override bool DefaultShowItemToolTips { get; }
+        protected override Size DefaultSize { get; }
+        public new ToolStripGripStyle GripStyle { get; set; }
+        public ToolStripMenuItem MdiWindowListItem { get; set; }
+        public new bool ShowItemToolTips { get; set; }
+        public new bool Stretch { get; set; }
+        public event EventHandler MenuActivate;
+        public event EventHandler MenuDeactivate;
+        protected override AccessibleObject CreateAccessibilityInstance();
+        protected internal override ToolStripItem CreateDefaultItem(string text, Image image, EventHandler onClick);
+        protected virtual void OnMenuActivate(EventArgs e);
+        protected virtual void OnMenuDeactivate(EventArgs e);
+        protected override bool ProcessCmdKey(ref Message m, Keys keyData);
+        protected override void WndProc(ref Message m);
+    }
+    public enum MergeAction {
+        Append = 0,
+        Insert = 1,
+        MatchOnly = 4,
+        Remove = 3,
+        Replace = 2,
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct Message {
+        public IntPtr HWnd { get; set; }
+        public IntPtr LParam { get; set; }
+        public int Msg { get; set; }
+        public IntPtr Result { get; set; }
+        public IntPtr WParam { get; set; }
+        public static Message Create(IntPtr hWnd, int msg, IntPtr wparam, IntPtr lparam);
+        public override bool Equals(object o);
+        public override int GetHashCode();
+        public object GetLParam(Type cls);
+        public static bool operator ==(Message a, Message b);
+        public static bool operator !=(Message a, Message b);
+        public override string ToString();
+    }
+    public class MessageBox {
+        public static DialogResult Show(string text);
+        public static DialogResult Show(string text, string caption);
+        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons);
+        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon);
+        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton);
+        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options);
+        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options, bool displayHelpButton);
+        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options, string helpFilePath);
+        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options, string helpFilePath, string keyword);
+        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options, string helpFilePath, HelpNavigator navigator);
+        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options, string helpFilePath, HelpNavigator navigator, object param);
+        public static DialogResult Show(IWin32Window owner, string text);
+        public static DialogResult Show(IWin32Window owner, string text, string caption);
+        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons);
+        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon);
+        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton);
+        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options);
+        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options, string helpFilePath);
+        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options, string helpFilePath, string keyword);
+        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options, string helpFilePath, HelpNavigator navigator);
+        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options, string helpFilePath, HelpNavigator navigator, object param);
+    }
+    public enum MessageBoxButtons {
+        AbortRetryIgnore = 2,
+        OK = 0,
+        OKCancel = 1,
+        RetryCancel = 5,
+        YesNo = 4,
+        YesNoCancel = 3,
+    }
+    public enum MessageBoxDefaultButton {
+        Button1 = 0,
+        Button2 = 256,
+        Button3 = 512,
+    }
+    public enum MessageBoxIcon {
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
+        RightAlign = 524288,
+        RtlReading = 1048576,
+        ServiceNotification = 2097152,
+    }
+    public delegate void MethodInvoker();
+    public class MonthCalendar : Control {
+        public MonthCalendar();
+        public DateTime[] AnnuallyBoldedDates { get; set; }
+        public override Color BackColor { get; set; }
+        public override Image BackgroundImage { get; set; }
+        public override ImageLayout BackgroundImageLayout { get; set; }
+        public DateTime[] BoldedDates { get; set; }
+        public Size CalendarDimensions { get; set; }
+        protected override CreateParams CreateParams { get; }
+        protected override ImeMode DefaultImeMode { get; }
+        protected override Padding DefaultMargin { get; }
+        protected override Size DefaultSize { get; }
+        protected override bool DoubleBuffered { get; set; }
+        public Day FirstDayOfWeek { get; set; }
+        public override Color ForeColor { get; set; }
+        public new ImeMode ImeMode { get; set; }
+        public DateTime MaxDate { get; set; }
+        public int MaxSelectionCount { get; set; }
+        public DateTime MinDate { get; set; }
+        public DateTime[] MonthlyBoldedDates { get; set; }
+        public new Padding Padding { get; set; }
+        public virtual bool RightToLeftLayout { get; set; }
+        public int ScrollChange { get; set; }
+        public DateTime SelectionEnd { get; set; }
+        public SelectionRange SelectionRange { get; set; }
+        public DateTime SelectionStart { get; set; }
+        public bool ShowToday { get; set; }
+        public bool ShowTodayCircle { get; set; }
+        public bool ShowWeekNumbers { get; set; }
+        public Size SingleMonthSize { get; }
+        public new Size Size { get; set; }
+        public override string Text { get; set; }
+        public Color TitleBackColor { get; set; }
+        public Color TitleForeColor { get; set; }
+        public DateTime TodayDate { get; set; }
+        public bool TodayDateSet { get; }
+        public Color TrailingForeColor { get; set; }
+        public new event EventHandler BackgroundImageChanged;
+        public new event EventHandler BackgroundImageLayoutChanged;
+        public new event EventHandler Click;
+        public event DateRangeEventHandler DateChanged;
+        public event DateRangeEventHandler DateSelected;
+        public new event EventHandler DoubleClick;
+        public new event EventHandler ImeModeChanged;
+        public new event MouseEventHandler MouseClick;
+        public new event MouseEventHandler MouseDoubleClick;
+        public new event EventHandler PaddingChanged;
+        public new event PaintEventHandler Paint;
+        public event EventHandler RightToLeftLayoutChanged;
+        public new event EventHandler TextChanged;
+        public void AddAnnuallyBoldedDate(DateTime date);
+        public void AddBoldedDate(DateTime date);
+        public void AddMonthlyBoldedDate(DateTime date);
+        protected override void CreateHandle();
+        protected override void DefWndProc(ref Message m);
+        protected override void Dispose(bool disposing);
+        public SelectionRange GetDisplayRange(bool visible);
+        public MonthCalendar.HitTestInfo HitTest(Point point);
+        public MonthCalendar.HitTestInfo HitTest(int x, int y);
+        protected override bool IsInputKey(Keys keyData);
+        protected override void OnBackColorChanged(EventArgs e);
+        protected virtual void OnDateChanged(DateRangeEventArgs drevent);
+        protected virtual void OnDateSelected(DateRangeEventArgs drevent);
+        protected override void OnFontChanged(EventArgs e);
+        protected override void OnForeColorChanged(EventArgs e);
+        protected override void OnHandleCreated(EventArgs e);
+        protected override void OnHandleDestroyed(EventArgs e);
+        protected virtual void OnRightToLeftLayoutChanged(EventArgs e);
+        public void RemoveAllAnnuallyBoldedDates();
+        public void RemoveAllBoldedDates();
+        public void RemoveAllMonthlyBoldedDates();
+        public void RemoveAnnuallyBoldedDate(DateTime date);
+        public void RemoveBoldedDate(DateTime date);
+        public void RemoveMonthlyBoldedDate(DateTime date);
+        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified);
+        public void SetCalendarDimensions(int x, int y);
+        public void SetDate(DateTime date);
+        public void SetSelectionRange(DateTime date1, DateTime date2);
+        public override string ToString();
+        public void UpdateBoldedDates();
+        protected override void WndProc(ref Message m);
+        public enum HitArea {
+            CalendarBackground = 6,
+            Date = 7,
+            DayOfWeek = 10,
+            NextMonthButton = 4,
+            NextMonthDate = 8,
+            Nowhere = 0,
+            PrevMonthButton = 5,
+            PrevMonthDate = 9,
+            TitleBackground = 1,
+            TitleMonth = 2,
+            TitleYear = 3,
+            TodayLink = 12,
+            WeekNumbers = 11,
+        }
+        public sealed class HitTestInfo {
+            public MonthCalendar.HitArea HitArea { get; }
+            public Point Point { get; }
+            public DateTime Time { get; }
+        }
+    }
+    public enum MouseButtons {
+        Left = 1048576,
+        Middle = 4194304,
+        None = 0,
+        Right = 2097152,
+        XButton1 = 8388608,
+        XButton2 = 16777216,
+    }
+    public class MouseEventArgs : EventArgs {
+        public MouseEventArgs(MouseButtons button, int clicks, int x, int y, int delta);
+        public MouseButtons Button { get; }
+        public int Clicks { get; }
+        public int Delta { get; }
+        public Point Location { get; }
+        public int X { get; }
+        public int Y { get; }
+    }
+    public delegate void MouseEventHandler(object sender, MouseEventArgs e);
+    public class NativeWindow : MarshalByRefObject, IWin32Window {
+        public NativeWindow();
+        public IntPtr Handle { get; }
+        public void AssignHandle(IntPtr handle);
+        public virtual void CreateHandle(CreateParams cp);
+        public void DefWndProc(ref Message m);
+        public virtual void DestroyHandle();
+        ~NativeWindow();
+        public static NativeWindow FromHandle(IntPtr handle);
+        protected virtual void OnHandleChange();
+        protected virtual void OnThreadException(Exception e);
+        public virtual void ReleaseHandle();
+        protected virtual void WndProc(ref Message m);
+    }
+    public class NavigateEventArgs : EventArgs {
+        public NavigateEventArgs(bool isForward);
+        public bool Forward { get; }
+    }
+    public delegate void NavigateEventHandler(object sender, NavigateEventArgs ne);
+    public class NodeLabelEditEventArgs : EventArgs {
+        public NodeLabelEditEventArgs(TreeNode node);
+        public NodeLabelEditEventArgs(TreeNode node, string label);
+        public bool CancelEdit { get; set; }
+        public string Label { get; }
+        public TreeNode Node { get; }
+    }
+    public delegate void NodeLabelEditEventHandler(object sender, NodeLabelEditEventArgs e);
+    public sealed class NotifyIcon : Component {
+        public NotifyIcon();
+        public NotifyIcon(IContainer container);
+        public ToolTipIcon BalloonTipIcon { get; set; }
+        public string BalloonTipText { get; set; }
+        public string BalloonTipTitle { get; set; }
+        public ContextMenu ContextMenu { get; set; }
+        public ContextMenuStrip ContextMenuStrip { get; set; }
+        public Icon Icon { get; set; }
+        public object Tag { get; set; }
+        public string Text { get; set; }
+        public bool Visible { get; set; }
+        public event EventHandler BalloonTipClicked;
+        public event EventHandler BalloonTipClosed;
+        public event EventHandler BalloonTipShown;
+        public event EventHandler Click;
+        public event EventHandler DoubleClick;
+        public event MouseEventHandler MouseClick;
+        public event MouseEventHandler MouseDoubleClick;
+        public event MouseEventHandler MouseDown;
+        public event MouseEventHandler MouseMove;
+        public event MouseEventHandler MouseUp;
+        protected override void Dispose(bool disposing);
+        public void ShowBalloonTip(int timeout);
+        public void ShowBalloonTip(int timeout, string tipTitle, string tipText, ToolTipIcon tipIcon);
+    }
+    public class NumericUpDown : UpDownBase, ISupportInitialize {
+        public NumericUpDown();
+        public NumericUpDownAccelerationCollection Accelerations { get; }
+        public int DecimalPlaces { get; set; }
+        public bool Hexadecimal { get; set; }
+        public decimal Increment { get; set; }
+        public decimal Maximum { get; set; }
+        public decimal Minimum { get; set; }
+        public new Padding Padding { get; set; }
+        public override string Text { get; set; }
+        public bool ThousandsSeparator { get; set; }
+        public decimal Value { get; set; }
+        public new event EventHandler PaddingChanged;
+        public new event EventHandler TextChanged;
+        public event EventHandler ValueChanged;
+        public void BeginInit();
+        protected override AccessibleObject CreateAccessibilityInstance();
+        public override void DownButton();
+        public void EndInit();
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected override void OnKeyUp(KeyEventArgs e);
+        protected override void OnLostFocus(EventArgs e);
+        protected override void OnTextBoxKeyPress(object source, KeyPressEventArgs e);
+        protected virtual void OnValueChanged(EventArgs e);
+        protected void ParseEditText();
+        public override string ToString();
+        public override void UpButton();
+        protected override void UpdateEditText();
+        protected override void ValidateEditText();
+    }
+    public class NumericUpDownAcceleration {
+        public NumericUpDownAcceleration(int seconds, decimal increment);
+        public decimal Increment { get; set; }
+        public int Seconds { get; set; }
+    }
+    public class NumericUpDownAccelerationCollection : MarshalByRefObject, ICollection<NumericUpDownAcceleration>, IEnumerable, IEnumerable<NumericUpDownAcceleration> {
+        public NumericUpDownAccelerationCollection();
+        public int Count { get; }
+        public bool IsReadOnly { get; }
+        public NumericUpDownAcceleration this[int index] { get; }
+        public void Add(NumericUpDownAcceleration acceleration);
+        public void AddRange(params NumericUpDownAcceleration[] accelerations);
+        public void Clear();
+        public bool Contains(NumericUpDownAcceleration acceleration);
+        public void CopyTo(NumericUpDownAcceleration[] array, int index);
+        public bool Remove(NumericUpDownAcceleration acceleration);
+        IEnumerator<NumericUpDownAcceleration> System.Collections.Generic.IEnumerable<System.Windows.Forms.NumericUpDownAcceleration>.GetEnumerator();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+    }
+    public class OpacityConverter : TypeConverter {
+        public OpacityConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public sealed class OpenFileDialog : FileDialog {
+        public OpenFileDialog();
+        public override bool CheckFileExists { get; set; }
+        public bool Multiselect { get; set; }
+        public bool ReadOnlyChecked { get; set; }
+        public string SafeFileName { get; }
+        public string[] SafeFileNames { get; }
+        public bool ShowReadOnly { get; set; }
+        public Stream OpenFile();
+        public override void Reset();
+    }
+    public enum Orientation {
+        Horizontal = 0,
+        Vertical = 1,
+    }
+    public class OSFeature : FeatureSupport {
+        public static readonly object LayeredWindows;
+        public static readonly object Themes;
+        protected OSFeature();
+        public static OSFeature Feature { get; }
+        public override Version GetVersionPresent(object feature);
+        public static bool IsPresent(SystemParameter enumVal);
+    }
+    public class OwnerDrawPropertyBag : MarshalByRefObject, ISerializable {
+        protected OwnerDrawPropertyBag(SerializationInfo info, StreamingContext context);
+        public Color BackColor { get; set; }
+        public Font Font { get; set; }
+        public Color ForeColor { get; set; }
+        public static OwnerDrawPropertyBag Copy(OwnerDrawPropertyBag value);
+        public virtual bool IsEmpty();
+        void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct Padding {
+        public static readonly Padding Empty;
+        public Padding(int all);
+        public Padding(int left, int top, int right, int bottom);
+        public int All { get; set; }
+        public int Bottom { get; set; }
+        public int Horizontal { get; }
+        public int Left { get; set; }
+        public int Right { get; set; }
+        public Size Size { get; }
+        public int Top { get; set; }
+        public int Vertical { get; }
+        public static Padding Add(Padding p1, Padding p2);
+        public override bool Equals(object other);
+        public override int GetHashCode();
+        public static Padding operator +(Padding p1, Padding p2);
+        public static bool operator ==(Padding p1, Padding p2);
+        public static bool operator !=(Padding p1, Padding p2);
+        public static Padding operator -(Padding p1, Padding p2);
+        public static Padding Subtract(Padding p1, Padding p2);
+        public override string ToString();
+    }
+    public class PaddingConverter : TypeConverter {
+        public PaddingConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+        public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues);
+        public override bool GetCreateInstanceSupported(ITypeDescriptorContext context);
+        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes);
+        public override bool GetPropertiesSupported(ITypeDescriptorContext context);
+    }
+    public sealed class PageSetupDialog : CommonDialog {
+        public PageSetupDialog();
+        public bool AllowMargins { get; set; }
+        public bool AllowOrientation { get; set; }
+        public bool AllowPaper { get; set; }
+        public bool AllowPrinter { get; set; }
+        public PrintDocument Document { get; set; }
+        public bool EnableMetric { get; set; }
+        public Margins MinMargins { get; set; }
+        public PageSettings PageSettings { get; set; }
+        public PrinterSettings PrinterSettings { get; set; }
+        public bool ShowHelp { get; set; }
+        public bool ShowNetwork { get; set; }
+        public override void Reset();
+        protected override bool RunDialog(IntPtr hwndOwner);
+    }
+    public class PaintEventArgs : EventArgs, IDisposable {
+        public PaintEventArgs(Graphics graphics, Rectangle clipRect);
+        public Rectangle ClipRectangle { get; }
+        public Graphics Graphics { get; }
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        ~PaintEventArgs();
+    }
+    public delegate void PaintEventHandler(object sender, PaintEventArgs e);
+    public class Panel : ScrollableControl {
+        public Panel();
+        public override bool AutoSize { get; set; }
+        public virtual AutoSizeMode AutoSizeMode { get; set; }
+        public BorderStyle BorderStyle { get; set; }
+        protected override CreateParams CreateParams { get; }
+        protected override Size DefaultSize { get; }
+        public new bool TabStop { get; set; }
+        public override string Text { get; set; }
+        public new event EventHandler AutoSizeChanged;
+        public new event KeyEventHandler KeyDown;
+        public new event KeyPressEventHandler KeyPress;
+        public new event KeyEventHandler KeyUp;
+        public new event EventHandler TextChanged;
+        protected override void OnResize(EventArgs eventargs);
+        public override string ToString();
+    }
+    public class PictureBox : Control, ISupportInitialize {
+        public PictureBox();
+        public override bool AllowDrop { get; set; }
+        public BorderStyle BorderStyle { get; set; }
+        public new bool CausesValidation { get; set; }
+        protected override CreateParams CreateParams { get; }
+        protected override ImeMode DefaultImeMode { get; }
+        protected override Size DefaultSize { get; }
+        public Image ErrorImage { get; set; }
+        public override Font Font { get; set; }
+        public override Color ForeColor { get; set; }
+        public Image Image { get; set; }
+        public string ImageLocation { get; set; }
+        public new ImeMode ImeMode { get; set; }
+        public Image InitialImage { get; set; }
+        public override RightToLeft RightToLeft { get; set; }
+        public PictureBoxSizeMode SizeMode { get; set; }
+        public new int TabIndex { get; set; }
+        public new bool TabStop { get; set; }
+        public override string Text { get; set; }
+        public bool WaitOnLoad { get; set; }
+        public new event EventHandler CausesValidationChanged;
+        public new event EventHandler Enter;
+        public new event EventHandler FontChanged;
+        public new event EventHandler ForeColorChanged;
+        public new event EventHandler ImeModeChanged;
+        public new event KeyEventHandler KeyDown;
+        public new event KeyPressEventHandler KeyPress;
+        public new event KeyEventHandler KeyUp;
+        public new event EventHandler Leave;
+        public event AsyncCompletedEventHandler LoadCompleted;
+        public event ProgressChangedEventHandler LoadProgressChanged;
+        public new event EventHandler RightToLeftChanged;
+        public event EventHandler SizeModeChanged;
+        public new event EventHandler TabIndexChanged;
+        public new event EventHandler TabStopChanged;
+        public new event EventHandler TextChanged;
+        public void CancelAsync();
+        protected override void Dispose(bool disposing);
+        public void Load();
+        public void Load(string url);
+        public void LoadAsync();
+        public void LoadAsync(string url);
+        protected override void OnEnabledChanged(EventArgs e);
+        protected override void OnHandleCreated(EventArgs e);
+        protected override void OnHandleDestroyed(EventArgs e);
+        protected virtual void OnLoadCompleted(AsyncCompletedEventArgs e);
+        protected virtual void OnLoadProgressChanged(ProgressChangedEventArgs e);
+        protected override void OnPaint(PaintEventArgs pe);
+        protected override void OnParentChanged(EventArgs e);
+        protected override void OnResize(EventArgs e);
+        protected virtual void OnSizeModeChanged(EventArgs e);
+        protected override void OnVisibleChanged(EventArgs e);
+        void System.ComponentModel.ISupportInitialize.BeginInit();
+        void System.ComponentModel.ISupportInitialize.EndInit();
+        public override string ToString();
+    }
+    public enum PictureBoxSizeMode {
+        AutoSize = 2,
+        CenterImage = 3,
+        Normal = 0,
+        StretchImage = 1,
+        Zoom = 4,
+    }
+    public class PopupEventArgs : CancelEventArgs {
+        public PopupEventArgs(IWin32Window associatedWindow, Control associatedControl, bool isBalloon, Size size);
+        public Control AssociatedControl { get; }
+        public IWin32Window AssociatedWindow { get; }
+        public bool IsBalloon { get; }
+        public Size ToolTipSize { get; set; }
+    }
+    public delegate void PopupEventHandler(object sender, PopupEventArgs e);
+    public enum PowerLineStatus {
+        Offline = 0,
+        Online = 1,
+        Unknown = 255,
+    }
+    public enum PowerState {
+        Hibernate = 1,
+        Suspend = 0,
+    }
+    public class PowerStatus {
+        public BatteryChargeStatus BatteryChargeStatus { get; }
+        public int BatteryFullLifetime { get; }
+        public float BatteryLifePercent { get; }
+        public int BatteryLifeRemaining { get; }
+        public PowerLineStatus PowerLineStatus { get; }
+    }
+    public enum PreProcessControlState {
+        MessageNeeded = 1,
+        MessageNotNeeded = 2,
+        MessageProcessed = 0,
+    }
+    public class PreviewKeyDownEventArgs : EventArgs {
+        public PreviewKeyDownEventArgs(Keys keyData);
+        public bool Alt { get; }
+        public bool Control { get; }
+        public bool IsInputKey { get; set; }
+        public Keys KeyCode { get; }
+        public Keys KeyData { get; }
+        public int KeyValue { get; }
+        public Keys Modifiers { get; }
+        public bool Shift { get; }
+    }
+    public delegate void PreviewKeyDownEventHandler(object sender, PreviewKeyDownEventArgs e);
+    public class PrintControllerWithStatusDialog : PrintController {
+        public PrintControllerWithStatusDialog(PrintController underlyingController);
+        public PrintControllerWithStatusDialog(PrintController underlyingController, string dialogTitle);
+        public override bool IsPreview { get; }
+        public override void OnEndPage(PrintDocument document, PrintPageEventArgs e);
+        public override void OnEndPrint(PrintDocument document, PrintEventArgs e);
+        public override Graphics OnStartPage(PrintDocument document, PrintPageEventArgs e);
+        public override void OnStartPrint(PrintDocument document, PrintEventArgs e);
+    }
+    public sealed class PrintDialog : CommonDialog {
+        public PrintDialog();
+        public bool AllowCurrentPage { get; set; }
+        public bool AllowPrintToFile { get; set; }
+        public bool AllowSelection { get; set; }
+        public bool AllowSomePages { get; set; }
+        public PrintDocument Document { get; set; }
+        public PrinterSettings PrinterSettings { get; set; }
+        public bool PrintToFile { get; set; }
+        public bool ShowHelp { get; set; }
+        public bool ShowNetwork { get; set; }
+        public bool UseEXDialog { get; set; }
+        public override void Reset();
+        protected override bool RunDialog(IntPtr hwndOwner);
+    }
+    public class PrintPreviewControl : Control {
+        public PrintPreviewControl();
+        public bool AutoZoom { get; set; }
+        public int Columns { get; set; }
+        protected override CreateParams CreateParams { get; }
+        public PrintDocument Document { get; set; }
+        public override RightToLeft RightToLeft { get; set; }
+        public int Rows { get; set; }
+        public int StartPage { get; set; }
+        public override string Text { get; set; }
+        public bool UseAntiAlias { get; set; }
+        public double Zoom { get; set; }
+        public event EventHandler StartPageChanged;
+        public new event EventHandler TextChanged;
+        public void InvalidatePreview();
+        protected override void OnPaint(PaintEventArgs pevent);
+        protected override void OnResize(EventArgs eventargs);
+        protected virtual void OnStartPageChanged(EventArgs e);
+        public override void ResetBackColor();
+        public override void ResetForeColor();
+        protected override void WndProc(ref Message m);
+    }
+    public class PrintPreviewDialog : Form {
+        public PrintPreviewDialog();
+        public new IButtonControl AcceptButton { get; set; }
+        public new string AccessibleDescription { get; set; }
+        public new string AccessibleName { get; set; }
+        public new AccessibleRole AccessibleRole { get; set; }
+        public override bool AllowDrop { get; set; }
+        public override AnchorStyles Anchor { get; set; }
+        public new bool AutoScale { get; set; }
+        public override Size AutoScaleBaseSize { get; set; }
+        public override bool AutoScroll { get; set; }
+        public new Size AutoScrollMargin { get; set; }
+        public new Size AutoScrollMinSize { get; set; }
+        public override bool AutoSize { get; set; }
+        public override AutoValidate AutoValidate { get; set; }
+        public override Color BackColor { get; set; }
+        public override Image BackgroundImage { get; set; }
+        public override ImageLayout BackgroundImageLayout { get; set; }
+        public new IButtonControl CancelButton { get; set; }
+        public new bool CausesValidation { get; set; }
+        public override ContextMenu ContextMenu { get; set; }
+        public override ContextMenuStrip ContextMenuStrip { get; set; }
+        public new bool ControlBox { get; set; }
+        public override Cursor Cursor { get; set; }
+        public new ControlBindingsCollection DataBindings { get; }
+        protected override Size DefaultMinimumSize { get; }
+        public override DockStyle Dock { get; set; }
+        public new ScrollableControl.DockPaddingEdges DockPadding { get; }
+        public PrintDocument Document { get; set; }
+        public new bool Enabled { get; set; }
+        public override Font Font { get; set; }
+        public override Color ForeColor { get; set; }
+        public new FormBorderStyle FormBorderStyle { get; set; }
+        public new bool HelpButton { get; set; }
+        public new Icon Icon { get; set; }
+        public new ImeMode ImeMode { get; set; }
+        public new bool IsMdiContainer { get; set; }
+        public new bool KeyPreview { get; set; }
+        public new Point Location { get; set; }
+        public new Padding Margin { get; set; }
+        public new bool MaximizeBox { get; set; }
+        public new Size MaximumSize { get; set; }
+        public new MainMenu Menu { get; set; }
+        public new bool MinimizeBox { get; set; }
+        public new Size MinimumSize { get; set; }
+        public new double Opacity { get; set; }
+        public new Padding Padding { get; set; }
+        public PrintPreviewControl PrintPreviewControl { get; }
+        public override RightToLeft RightToLeft { get; set; }
+        public override bool RightToLeftLayout { get; set; }
+        public new bool ShowInTaskbar { get; set; }
+        public new Size Size { get; set; }
+        public new SizeGripStyle SizeGripStyle { get; set; }
+        public new FormStartPosition StartPosition { get; set; }
+        public new bool TabStop { get; set; }
+        public new object Tag { get; set; }
+        public override string Text { get; set; }
+        public new bool TopMost { get; set; }
+        public new Color TransparencyKey { get; set; }
+        public bool UseAntiAlias { get; set; }
+        public new bool UseWaitCursor { get; set; }
+        public new bool Visible { get; set; }
+        public new FormWindowState WindowState { get; set; }
+        public new event EventHandler AutoSizeChanged;
+        public new event EventHandler AutoValidateChanged;
+        public new event EventHandler BackColorChanged;
+        public new event EventHandler BackgroundImageChanged;
+        public new event EventHandler BackgroundImageLayoutChanged;
+        public new event EventHandler CausesValidationChanged;
+        public new event EventHandler ContextMenuChanged;
+        public new event EventHandler ContextMenuStripChanged;
+        public new event EventHandler CursorChanged;
+        public new event EventHandler DockChanged;
+        public new event EventHandler EnabledChanged;
+        public new event EventHandler FontChanged;
+        public new event EventHandler ForeColorChanged;
+        public new event EventHandler ImeModeChanged;
+        public new event EventHandler LocationChanged;
+        public new event EventHandler MarginChanged;
+        public new event EventHandler MaximumSizeChanged;
+        public new event EventHandler MinimumSizeChanged;
+        public new event EventHandler PaddingChanged;
+        public new event EventHandler RightToLeftChanged;
+        public new event EventHandler RightToLeftLayoutChanged;
+        public new event EventHandler SizeChanged;
+        public new event EventHandler TabStopChanged;
+        public new event EventHandler TextChanged;
+        public new event EventHandler VisibleChanged;
+        protected override void CreateHandle();
+        protected override void OnClosing(CancelEventArgs e);
+        protected override bool ProcessDialogKey(Keys keyData);
+        protected override bool ProcessTabKey(bool forward);
+    }
+    public sealed class ProfessionalColors {
+        public static Color ButtonCheckedGradientBegin { get; }
+        public static Color ButtonCheckedGradientEnd { get; }
+        public static Color ButtonCheckedGradientMiddle { get; }
+        public static Color ButtonCheckedHighlight { get; }
+        public static Color ButtonCheckedHighlightBorder { get; }
+        public static Color ButtonPressedBorder { get; }
+        public static Color ButtonPressedGradientBegin { get; }
+        public static Color ButtonPressedGradientEnd { get; }
+        public static Color ButtonPressedGradientMiddle { get; }
+        public static Color ButtonPressedHighlight { get; }
+        public static Color ButtonPressedHighlightBorder { get; }
+        public static Color ButtonSelectedBorder { get; }
+        public static Color ButtonSelectedGradientBegin { get; }
+        public static Color ButtonSelectedGradientEnd { get; }
+        public static Color ButtonSelectedGradientMiddle { get; }
+        public static Color ButtonSelectedHighlight { get; }
+        public static Color ButtonSelectedHighlightBorder { get; }
+        public static Color CheckBackground { get; }
+        public static Color CheckPressedBackground { get; }
+        public static Color CheckSelectedBackground { get; }
+        public static Color GripDark { get; }
+        public static Color GripLight { get; }
+        public static Color ImageMarginGradientBegin { get; }
+        public static Color ImageMarginGradientEnd { get; }
+        public static Color ImageMarginGradientMiddle { get; }
+        public static Color ImageMarginRevealedGradientBegin { get; }
+        public static Color ImageMarginRevealedGradientEnd { get; }
+        public static Color ImageMarginRevealedGradientMiddle { get; }
+        public static Color MenuBorder { get; }
+        public static Color MenuItemBorder { get; }
+        public static Color MenuItemPressedGradientBegin { get; }
+        public static Color MenuItemPressedGradientEnd { get; }
+        public static Color MenuItemPressedGradientMiddle { get; }
+        public static Color MenuItemSelected { get; }
+        public static Color MenuItemSelectedGradientBegin { get; }
+        public static Color MenuItemSelectedGradientEnd { get; }
+        public static Color MenuStripGradientBegin { get; }
+        public static Color MenuStripGradientEnd { get; }
+        public static Color OverflowButtonGradientBegin { get; }
+        public static Color OverflowButtonGradientEnd { get; }
+        public static Color OverflowButtonGradientMiddle { get; }
+        public static Color RaftingContainerGradientBegin { get; }
+        public static Color RaftingContainerGradientEnd { get; }
+        public static Color SeparatorDark { get; }
+        public static Color SeparatorLight { get; }
+        public static Color StatusStripGradientBegin { get; }
+        public static Color StatusStripGradientEnd { get; }
+        public static Color ToolStripBorder { get; }
+        public static Color ToolStripContentPanelGradientBegin { get; }
+        public static Color ToolStripContentPanelGradientEnd { get; }
+        public static Color ToolStripDropDownBackground { get; }
+        public static Color ToolStripGradientBegin { get; }
+        public static Color ToolStripGradientEnd { get; }
+        public static Color ToolStripGradientMiddle { get; }
+        public static Color ToolStripPanelGradientBegin { get; }
+        public static Color ToolStripPanelGradientEnd { get; }
+    }
+    public class ProfessionalColorTable {
+        public ProfessionalColorTable();
+        public virtual Color ButtonCheckedGradientBegin { get; }
+        public virtual Color ButtonCheckedGradientEnd { get; }
+        public virtual Color ButtonCheckedGradientMiddle { get; }
+        public virtual Color ButtonCheckedHighlight { get; }
+        public virtual Color ButtonCheckedHighlightBorder { get; }
+        public virtual Color ButtonPressedBorder { get; }
+        public virtual Color ButtonPressedGradientBegin { get; }
+        public virtual Color ButtonPressedGradientEnd { get; }
+        public virtual Color ButtonPressedGradientMiddle { get; }
+        public virtual Color ButtonPressedHighlight { get; }
+        public virtual Color ButtonPressedHighlightBorder { get; }
+        public virtual Color ButtonSelectedBorder { get; }
+        public virtual Color ButtonSelectedGradientBegin { get; }
+        public virtual Color ButtonSelectedGradientEnd { get; }
+        public virtual Color ButtonSelectedGradientMiddle { get; }
+        public virtual Color ButtonSelectedHighlight { get; }
+        public virtual Color ButtonSelectedHighlightBorder { get; }
+        public virtual Color CheckBackground { get; }
+        public virtual Color CheckPressedBackground { get; }
+        public virtual Color CheckSelectedBackground { get; }
+        public virtual Color GripDark { get; }
+        public virtual Color GripLight { get; }
+        public virtual Color ImageMarginGradientBegin { get; }
+        public virtual Color ImageMarginGradientEnd { get; }
+        public virtual Color ImageMarginGradientMiddle { get; }
+        public virtual Color ImageMarginRevealedGradientBegin { get; }
+        public virtual Color ImageMarginRevealedGradientEnd { get; }
+        public virtual Color ImageMarginRevealedGradientMiddle { get; }
+        public virtual Color MenuBorder { get; }
+        public virtual Color MenuItemBorder { get; }
+        public virtual Color MenuItemPressedGradientBegin { get; }
+        public virtual Color MenuItemPressedGradientEnd { get; }
+        public virtual Color MenuItemPressedGradientMiddle { get; }
+        public virtual Color MenuItemSelected { get; }
+        public virtual Color MenuItemSelectedGradientBegin { get; }
+        public virtual Color MenuItemSelectedGradientEnd { get; }
+        public virtual Color MenuStripGradientBegin { get; }
+        public virtual Color MenuStripGradientEnd { get; }
+        public virtual Color OverflowButtonGradientBegin { get; }
+        public virtual Color OverflowButtonGradientEnd { get; }
+        public virtual Color OverflowButtonGradientMiddle { get; }
+        public virtual Color RaftingContainerGradientBegin { get; }
+        public virtual Color RaftingContainerGradientEnd { get; }
+        public virtual Color SeparatorDark { get; }
+        public virtual Color SeparatorLight { get; }
+        public virtual Color StatusStripGradientBegin { get; }
+        public virtual Color StatusStripGradientEnd { get; }
+        public virtual Color ToolStripBorder { get; }
+        public virtual Color ToolStripContentPanelGradientBegin { get; }
+        public virtual Color ToolStripContentPanelGradientEnd { get; }
+        public virtual Color ToolStripDropDownBackground { get; }
+        public virtual Color ToolStripGradientBegin { get; }
+        public virtual Color ToolStripGradientEnd { get; }
+        public virtual Color ToolStripGradientMiddle { get; }
+        public virtual Color ToolStripPanelGradientBegin { get; }
+        public virtual Color ToolStripPanelGradientEnd { get; }
+        public bool UseSystemColors { get; set; }
+    }
+    public class ProgressBar : Control {
+        public ProgressBar();
+        public override bool AllowDrop { get; set; }
+        public override Image BackgroundImage { get; set; }
+        public override ImageLayout BackgroundImageLayout { get; set; }
+        public new bool CausesValidation { get; set; }
+        protected override CreateParams CreateParams { get; }
+        protected override ImeMode DefaultImeMode { get; }
+        protected override Size DefaultSize { get; }
+        protected override bool DoubleBuffered { get; set; }
+        public override Font Font { get; set; }
+        public new ImeMode ImeMode { get; set; }
+        public int MarqueeAnimationSpeed { get; set; }
+        public int Maximum { get; set; }
+        public int Minimum { get; set; }
+        public new Padding Padding { get; set; }
+        public virtual bool RightToLeftLayout { get; set; }
+        public int Step { get; set; }
+        public ProgressBarStyle Style { get; set; }
+        public new bool TabStop { get; set; }
+        public override string Text { get; set; }
+        public int Value { get; set; }
+        public new event EventHandler BackgroundImageChanged;
+        public new event EventHandler BackgroundImageLayoutChanged;
+        public new event EventHandler CausesValidationChanged;
+        public new event EventHandler DoubleClick;
+        public new event EventHandler Enter;
+        public new event EventHandler FontChanged;
+        public new event EventHandler ImeModeChanged;
+        public new event KeyEventHandler KeyDown;
+        public new event KeyPressEventHandler KeyPress;
+        public new event KeyEventHandler KeyUp;
+        public new event EventHandler Leave;
+        public new event MouseEventHandler MouseDoubleClick;
+        public new event EventHandler PaddingChanged;
+        public new event PaintEventHandler Paint;
+        public event EventHandler RightToLeftLayoutChanged;
+        public new event EventHandler TabStopChanged;
+        public new event EventHandler TextChanged;
+        protected override void CreateHandle();
+        public void Increment(int value);
+        protected override void OnBackColorChanged(EventArgs e);
+        protected override void OnForeColorChanged(EventArgs e);
+        protected override void OnHandleCreated(EventArgs e);
+        protected override void OnHandleDestroyed(EventArgs e);
+        protected virtual void OnRightToLeftLayoutChanged(EventArgs e);
+        public void PerformStep();
+        public override void ResetForeColor();
+        public override string ToString();
+    }
+    public sealed class ProgressBarRenderer {
+        public static int ChunkSpaceThickness { get; }
+        public static int ChunkThickness { get; }
+        public static bool IsSupported { get; }
+        public static void DrawHorizontalBar(Graphics g, Rectangle bounds);
+        public static void DrawHorizontalChunks(Graphics g, Rectangle bounds);
+        public static void DrawVerticalBar(Graphics g, Rectangle bounds);
+        public static void DrawVerticalChunks(Graphics g, Rectangle bounds);
+    }
+    public enum ProgressBarStyle {
+        Blocks = 0,
+        Continuous = 1,
+        Marquee = 2,
+    }
+    public class PropertyGrid : ContainerControl, IComPropertyBrowser {
+        public PropertyGrid();
+        public override bool AutoScroll { get; set; }
+        public override Color BackColor { get; set; }
+        public override Image BackgroundImage { get; set; }
+        public override ImageLayout BackgroundImageLayout { get; set; }
+        public AttributeCollection BrowsableAttributes { get; set; }
+        public virtual bool CanShowCommands { get; }
+        public bool CanShowVisualStyleGlyphs { get; set; }
+        public Color CategoryForeColor { get; set; }
+        public Color CategorySplitterColor { get; set; }
+        public Color CommandsActiveLinkColor { get; set; }
+        public Color CommandsBackColor { get; set; }
+        public Color CommandsBorderColor { get; set; }
+        public Color CommandsDisabledLinkColor { get; set; }
+        public Color CommandsForeColor { get; set; }
+        public Color CommandsLinkColor { get; set; }
+        public virtual bool CommandsVisible { get; }
+        public virtual bool CommandsVisibleIfAvailable { get; set; }
+        public Point ContextMenuDefaultLocation { get; }
+        public new Control.ControlCollection Controls { get; }
+        protected override Size DefaultSize { get; }
+        protected virtual Type DefaultTabType { get; }
+        public Color DisabledItemForeColor { get; set; }
+        protected bool DrawFlatToolbar { get; set; }
+        public override Color ForeColor { get; set; }
+        public Color HelpBackColor { get; set; }
+        public Color HelpBorderColor { get; set; }
+        public Color HelpForeColor { get; set; }
+        public virtual bool HelpVisible { get; set; }
+        public bool LargeButtons { get; set; }
+        public Color LineColor { get; set; }
+        public new Padding Padding { get; set; }
+        public PropertySort PropertySort { get; set; }
+        public PropertyGrid.PropertyTabCollection PropertyTabs { get; }
+        public GridItem SelectedGridItem { get; set; }
+        public Color SelectedItemWithFocusBackColor { get; set; }
+        public Color SelectedItemWithFocusForeColor { get; set; }
+        public object SelectedObject { get; set; }
+        public object[] SelectedObjects { get; set; }
+        public PropertyTab SelectedTab { get; }
+        protected internal override bool ShowFocusCues { get; }
+        protected virtual Bitmap ShowPropertyPageImage { get; }
+        public override ISite Site { get; set; }
+        protected virtual Bitmap SortByCategoryImage { get; }
+        protected virtual Bitmap SortByPropertyImage { get; }
+        bool System.Windows.Forms.ComponentModel.Com2Interop.IComPropertyBrowser.InPropertySet { get; }
+        public override string Text { get; set; }
+        public virtual bool ToolbarVisible { get; set; }
+        protected ToolStripRenderer ToolStripRenderer { get; set; }
+        public bool UseCompatibleTextRendering { get; set; }
+        public Color ViewBackColor { get; set; }
+        public Color ViewBorderColor { get; set; }
+        public Color ViewForeColor { get; set; }
+        public new event EventHandler BackgroundImageChanged;
+        public new event EventHandler BackgroundImageLayoutChanged;
+        public new event EventHandler ForeColorChanged;
+        public new event KeyEventHandler KeyDown;
+        public new event KeyPressEventHandler KeyPress;
+        public new event KeyEventHandler KeyUp;
+        public new event MouseEventHandler MouseDown;
+        public new event EventHandler MouseEnter;
+        public new event EventHandler MouseLeave;
+        public new event MouseEventHandler MouseMove;
+        public new event MouseEventHandler MouseUp;
+        public new event EventHandler PaddingChanged;
+        public event EventHandler PropertySortChanged;
+        public event PropertyTabChangedEventHandler PropertyTabChanged;
+        public event PropertyValueChangedEventHandler PropertyValueChanged;
+        public event SelectedGridItemChangedEventHandler SelectedGridItemChanged;
+        public event EventHandler SelectedObjectsChanged;
+        event ComponentRenameEventHandler System.Windows.Forms.ComponentModel.Com2Interop.IComPropertyBrowser.ComComponentNameChanged;
+        public new event EventHandler TextChanged;
+        public void CollapseAllGridItems();
+        protected virtual PropertyTab CreatePropertyTab(Type tabType);
+        protected override void Dispose(bool disposing);
+        public void ExpandAllGridItems();
+        protected void OnComComponentNameChanged(ComponentRenameEventArgs e);
+        protected override void OnEnabledChanged(EventArgs e);
+        protected override void OnFontChanged(EventArgs e);
+        protected override void OnGotFocus(EventArgs e);
+        protected override void OnHandleCreated(EventArgs e);
+        protected override void OnHandleDestroyed(EventArgs e);
+        protected override void OnMouseDown(MouseEventArgs me);
+        protected override void OnMouseMove(MouseEventArgs me);
+        protected override void OnMouseUp(MouseEventArgs me);
+        protected void OnNotifyPropertyValueUIItemsChanged(object sender, EventArgs e);
+        protected override void OnPaint(PaintEventArgs pevent);
+        protected virtual void OnPropertySortChanged(EventArgs e);
+        protected virtual void OnPropertyTabChanged(PropertyTabChangedEventArgs e);
+        protected virtual void OnPropertyValueChanged(PropertyValueChangedEventArgs e);
+        protected override void OnResize(EventArgs e);
+        protected virtual void OnSelectedGridItemChanged(SelectedGridItemChangedEventArgs e);
+        protected virtual void OnSelectedObjectsChanged(EventArgs e);
+        protected override void OnSystemColorsChanged(EventArgs e);
+        protected override void OnVisibleChanged(EventArgs e);
+        protected override bool ProcessDialogKey(Keys keyData);
+        public override void Refresh();
+        public void RefreshTabs(PropertyTabScope tabScope);
+        public void ResetSelectedProperty();
+        protected override void ScaleCore(float dx, float dy);
+        protected void ShowEventsButton(bool value);
+        void System.Windows.Forms.ComponentModel.Com2Interop.IComPropertyBrowser.DropDownDone();
+        bool System.Windows.Forms.ComponentModel.Com2Interop.IComPropertyBrowser.EnsurePendingChangesCommitted();
+        void System.Windows.Forms.ComponentModel.Com2Interop.IComPropertyBrowser.HandleF4();
+        void System.Windows.Forms.ComponentModel.Com2Interop.IComPropertyBrowser.LoadState(RegistryKey optRoot);
+        void System.Windows.Forms.ComponentModel.Com2Interop.IComPropertyBrowser.SaveState(RegistryKey optRoot);
+        protected override void WndProc(ref Message m);
+        public class PropertyTabCollection : ICollection, IEnumerable {
+            public int Count { get; }
+            bool System.Collections.ICollection.IsSynchronized { get; }
+            object System.Collections.ICollection.SyncRoot { get; }
+            public PropertyTab this[int index] { get; }
+            public void AddTabType(Type propertyTabType);
+            public void AddTabType(Type propertyTabType, PropertyTabScope tabScope);
+            public void Clear(PropertyTabScope tabScope);
+            public IEnumerator GetEnumerator();
+            public void RemoveTabType(Type propertyTabType);
+            void System.Collections.ICollection.CopyTo(Array dest, int index);
+        }
+    }
+    public class PropertyManager : BindingManagerBase {
+        public PropertyManager();
+        public override int Count { get; }
+        public override object Current { get; }
+        public override int Position { get; set; }
+        public override void AddNew();
+        public override void CancelCurrentEdit();
+        public override void EndCurrentEdit();
+        protected internal override string GetListName(ArrayList listAccessors);
+        protected internal override void OnCurrentChanged(EventArgs ea);
+        protected internal override void OnCurrentItemChanged(EventArgs ea);
+        public override void RemoveAt(int index);
+        public override void ResumeBinding();
+        public override void SuspendBinding();
+        protected override void UpdateIsBinding();
+    }
+    public enum PropertySort {
+        Alphabetical = 1,
+        Categorized = 2,
+        CategorizedAlphabetical = 3,
+        NoSort = 0,
+    }
+    public class PropertyTabChangedEventArgs : EventArgs {
+        public PropertyTabChangedEventArgs(PropertyTab oldTab, PropertyTab newTab);
+        public PropertyTab NewTab { get; }
+        public PropertyTab OldTab { get; }
+    }
+    public delegate void PropertyTabChangedEventHandler(object s, PropertyTabChangedEventArgs e);
+    public class PropertyValueChangedEventArgs : EventArgs {
+        public PropertyValueChangedEventArgs(GridItem changedItem, object oldValue);
+        public GridItem ChangedItem { get; }
+        public object OldValue { get; }
+    }
+    public delegate void PropertyValueChangedEventHandler(object s, PropertyValueChangedEventArgs e);
+    public class QueryAccessibilityHelpEventArgs : EventArgs {
+        public QueryAccessibilityHelpEventArgs();
+        public QueryAccessibilityHelpEventArgs(string helpNamespace, string helpString, string helpKeyword);
+        public string HelpKeyword { get; set; }
+        public string HelpNamespace { get; set; }
+        public string HelpString { get; set; }
+    }
+    public delegate void QueryAccessibilityHelpEventHandler(object sender, QueryAccessibilityHelpEventArgs e);
+    public class QueryContinueDragEventArgs : EventArgs {
+        public QueryContinueDragEventArgs(int keyState, bool escapePressed, DragAction action);
+        public DragAction Action { get; set; }
+        public bool EscapePressed { get; }
+        public int KeyState { get; }
+    }
+    public delegate void QueryContinueDragEventHandler(object sender, QueryContinueDragEventArgs e);
+    public class QuestionEventArgs : EventArgs {
+        public QuestionEventArgs();
+        public QuestionEventArgs(bool response);
+        public bool Response { get; set; }
+    }
+    public delegate void QuestionEventHandler(object sender, QuestionEventArgs e);
+    public class RadioButton : ButtonBase {
+        public RadioButton();
+        public Appearance Appearance { get; set; }
+        public bool AutoCheck { get; set; }
+        public ContentAlignment CheckAlign { get; set; }
+        public bool Checked { get; set; }
+        protected override CreateParams CreateParams { get; }
+        protected override Size DefaultSize { get; }
+        public new bool TabStop { get; set; }
+        public override ContentAlignment TextAlign { get; set; }
+        public event EventHandler AppearanceChanged;
+        public event EventHandler CheckedChanged;
+        public new event EventHandler DoubleClick;
+        public new event MouseEventHandler MouseDoubleClick;
+        protected override AccessibleObject CreateAccessibilityInstance();
+        protected virtual void OnCheckedChanged(EventArgs e);
+        protected override void OnClick(EventArgs e);
+        protected override void OnEnter(EventArgs e);
+        protected override void OnHandleCreated(EventArgs e);
+        protected override void OnMouseUp(MouseEventArgs mevent);
+        public void PerformClick();
+        protected internal override bool ProcessMnemonic(char charCode);
+        public override string ToString();
+        public class RadioButtonAccessibleObject : ButtonBase.ButtonBaseAccessibleObject {
+            public RadioButtonAccessibleObject(RadioButton owner);
+            public override string DefaultAction { get; }
+            public override AccessibleRole Role { get; }
+            public override AccessibleStates State { get; }
+            public override void DoDefaultAction();
+        }
+    }
+    public sealed class RadioButtonRenderer {
+        public static bool RenderMatchingApplicationState { get; set; }
+        public static void DrawParentBackground(Graphics g, Rectangle bounds, Control childControl);
+        public static void DrawRadioButton(Graphics g, Point glyphLocation, Rectangle textBounds, string radioButtonText, Font font, bool focused, RadioButtonState state);
+        public static void DrawRadioButton(Graphics g, Point glyphLocation, Rectangle textBounds, string radioButtonText, Font font, Image image, Rectangle imageBounds, bool focused, RadioButtonState state);
+        public static void DrawRadioButton(Graphics g, Point glyphLocation, Rectangle textBounds, string radioButtonText, Font font, TextFormatFlags flags, bool focused, RadioButtonState state);
+        public static void DrawRadioButton(Graphics g, Point glyphLocation, Rectangle textBounds, string radioButtonText, Font font, TextFormatFlags flags, Image image, Rectangle imageBounds, bool focused, RadioButtonState state);
+        public static void DrawRadioButton(Graphics g, Point glyphLocation, RadioButtonState state);
+        public static Size GetGlyphSize(Graphics g, RadioButtonState state);
+        public static bool IsBackgroundPartiallyTransparent(RadioButtonState state);
+    }
+    public sealed class RelatedImageListAttribute : Attribute {
+        public RelatedImageListAttribute(string relatedImageList);
+        public string RelatedImageList { get; }
+    }
+    public class RetrieveVirtualItemEventArgs : EventArgs {
+        public RetrieveVirtualItemEventArgs(int itemIndex);
+        public ListViewItem Item { get; set; }
+        public int ItemIndex { get; }
+    }
+    public delegate void RetrieveVirtualItemEventHandler(object sender, RetrieveVirtualItemEventArgs e);
+    public class RichTextBox : TextBoxBase {
+        public RichTextBox();
+        public override bool AllowDrop { get; set; }
+        public override bool AutoSize { get; set; }
+        public bool AutoWordSelection { get; set; }
+        public override Image BackgroundImage { get; set; }
+        public override ImageLayout BackgroundImageLayout { get; set; }
+        public int BulletIndent { get; set; }
+        public bool CanRedo { get; }
+        protected override CreateParams CreateParams { get; }
+        protected override Size DefaultSize { get; }
+        public bool DetectUrls { get; set; }
+        public bool EnableAutoDragDrop { get; set; }
+        public override Font Font { get; set; }
+        public override Color ForeColor { get; set; }
+        public RichTextBoxLanguageOptions LanguageOption { get; set; }
+        public override int MaxLength { get; set; }
+        public override bool Multiline { get; set; }
+        public string RedoActionName { get; }
+        public bool RichTextShortcutsEnabled { get; set; }
+        public int RightMargin { get; set; }
+        public string Rtf { get; set; }
+        public RichTextBoxScrollBars ScrollBars { get; set; }
+        public string SelectedRtf { get; set; }
+        public override string SelectedText { get; set; }
+        public HorizontalAlignment SelectionAlignment { get; set; }
+        public Color SelectionBackColor { get; set; }
+        public bool SelectionBullet { get; set; }
+        public int SelectionCharOffset { get; set; }
+        public Color SelectionColor { get; set; }
+        public Font SelectionFont { get; set; }
+        public int SelectionHangingIndent { get; set; }
+        public int SelectionIndent { get; set; }
+        public override int SelectionLength { get; set; }
+        public bool SelectionProtected { get; set; }
+        public int SelectionRightIndent { get; set; }
+        public int[] SelectionTabs { get; set; }
+        public RichTextBoxSelectionTypes SelectionType { get; }
+        public bool ShowSelectionMargin { get; set; }
+        public override string Text { get; set; }
+        public override int TextLength { get; }
+        public string UndoActionName { get; }
+        public float ZoomFactor { get; set; }
+        public new event EventHandler BackgroundImageChanged;
+        public new event EventHandler BackgroundImageLayoutChanged;
+        public event ContentsResizedEventHandler ContentsResized;
+        public new event DragEventHandler DragDrop;
+        public new event DragEventHandler DragEnter;
+        public new event EventHandler DragLeave;
+        public new event DragEventHandler DragOver;
+        public new event GiveFeedbackEventHandler GiveFeedback;
+        public event EventHandler HScroll;
+        public event EventHandler ImeChange;
+        public event LinkClickedEventHandler LinkClicked;
+        public event EventHandler Protected;
+        public new event QueryContinueDragEventHandler QueryContinueDrag;
+        public event EventHandler SelectionChanged;
+        public event EventHandler VScroll;
+        public bool CanPaste(DataFormats.Format clipFormat);
+        protected virtual object CreateRichEditOleCallback();
+        public new void DrawToBitmap(Bitmap bitmap, Rectangle targetBounds);
+        public int Find(char[] characterSet);
+        public int Find(char[] characterSet, int start);
+        public int Find(char[] characterSet, int start, int end);
+        public int Find(string str);
+        public int Find(string str, int start, int end, RichTextBoxFinds options);
+        public int Find(string str, int start, RichTextBoxFinds options);
+        public int Find(string str, RichTextBoxFinds options);
+        public override int GetCharIndexFromPosition(Point pt);
+        public override int GetLineFromCharIndex(int index);
+        public override Point GetPositionFromCharIndex(int index);
+        public void LoadFile(Stream data, RichTextBoxStreamType fileType);
+        public void LoadFile(string path);
+        public void LoadFile(string path, RichTextBoxStreamType fileType);
+        protected override void OnBackColorChanged(EventArgs e);
+        protected virtual void OnContentsResized(ContentsResizedEventArgs e);
+        protected override void OnContextMenuChanged(EventArgs e);
+        protected override void OnHandleCreated(EventArgs e);
+        protected override void OnHandleDestroyed(EventArgs e);
+        protected virtual void OnHScroll(EventArgs e);
+        protected virtual void OnImeChange(EventArgs e);
+        protected virtual void OnLinkClicked(LinkClickedEventArgs e);
+        protected virtual void OnProtected(EventArgs e);
+        protected override void OnRightToLeftChanged(EventArgs e);
+        protected virtual void OnSelectionChanged(EventArgs e);
+        protected virtual void OnVScroll(EventArgs e);
+        public void Paste(DataFormats.Format clipFormat);
+        protected override bool ProcessCmdKey(ref Message m, Keys keyData);
+        public void Redo();
+        public void SaveFile(Stream data, RichTextBoxStreamType fileType);
+        public void SaveFile(string path);
+        public void SaveFile(string path, RichTextBoxStreamType fileType);
+        protected override void WndProc(ref Message m);
+    }
+    public enum RichTextBoxFinds {
+        MatchCase = 4,
+        NoHighlight = 8,
+        None = 0,
+        Reverse = 16,
+        WholeWord = 2,
+    }
+    public enum RichTextBoxLanguageOptions {
+        AutoFont = 2,
+        AutoFontSizeAdjust = 16,
+        AutoKeyboard = 1,
+        DualFont = 128,
+        ImeAlwaysSendNotify = 8,
+        ImeCancelComplete = 4,
+        UIFonts = 32,
+    }
+    public enum RichTextBoxScrollBars {
+        Both = 3,
+        ForcedBoth = 19,
+        ForcedHorizontal = 17,
+        ForcedVertical = 18,
+        Horizontal = 1,
+        None = 0,
+        Vertical = 2,
+    }
+    public enum RichTextBoxSelectionAttribute {
+        All = 1,
+        Mixed = -1,
+        None = 0,
+    }
+    public enum RichTextBoxSelectionTypes {
+        Empty = 0,
+        MultiChar = 4,
+        MultiObject = 8,
+        Object = 2,
+        Text = 1,
+    }
+    public enum RichTextBoxStreamType {
+        PlainText = 1,
+        RichNoOleObjs = 2,
+        RichText = 0,
+        TextTextOleObjs = 3,
+        UnicodePlainText = 4,
+    }
+    public enum RichTextBoxWordPunctuations {
+        All = 896,
+        Custom = 512,
+        Level1 = 128,
+        Level2 = 256,
+    }
+    public enum RightToLeft {
+        Inherit = 2,
+        No = 0,
+        Yes = 1,
+    }
+    public class RowStyle : TableLayoutStyle {
+        public RowStyle();
+        public RowStyle(SizeType sizeType);
+        public RowStyle(SizeType sizeType, float height);
+        public float Height { get; set; }
+    }
+    public sealed class SaveFileDialog : FileDialog {
+        public SaveFileDialog();
+        public bool CreatePrompt { get; set; }
+        public bool OverwritePrompt { get; set; }
+        public Stream OpenFile();
+        public override void Reset();
+    }
+    public class Screen {
+        public static Screen[] AllScreens { get; }
+        public int BitsPerPixel { get; }
+        public Rectangle Bounds { get; }
+        public string DeviceName { get; }
+        public bool Primary { get; }
+        public static Screen PrimaryScreen { get; }
+        public Rectangle WorkingArea { get; }
+        public override bool Equals(object obj);
+        public static Screen FromControl(Control control);
+        public static Screen FromHandle(IntPtr hwnd);
+        public static Screen FromPoint(Point point);
+        public static Screen FromRectangle(Rectangle rect);
+        public static Rectangle GetBounds(Point pt);
+        public static Rectangle GetBounds(Rectangle rect);
+        public static Rectangle GetBounds(Control ctl);
+        public override int GetHashCode();
+        public static Rectangle GetWorkingArea(Point pt);
+        public static Rectangle GetWorkingArea(Rectangle rect);
+        public static Rectangle GetWorkingArea(Control ctl);
+        public override string ToString();
+    }
+    public enum ScreenOrientation {
+        Angle0 = 0,
+        Angle180 = 2,
+        Angle270 = 3,
+        Angle90 = 1,
+    }
+    public class ScrollableControl : Control, IArrangedElement, IComponent, IDisposable {
+        protected const int ScrollStateAutoScrolling = 1;
+        protected const int ScrollStateFullDrag = 16;
+        protected const int ScrollStateHScrollVisible = 2;
+        protected const int ScrollStateUserHasScrolled = 8;
+        protected const int ScrollStateVScrollVisible = 4;
+        public ScrollableControl();
+        public virtual bool AutoScroll { get; set; }
+        public Size AutoScrollMargin { get; set; }
+        public Size AutoScrollMinSize { get; set; }
+        public Point AutoScrollPosition { get; set; }
+        protected override CreateParams CreateParams { get; }
+        public override Rectangle DisplayRectangle { get; }
+        public ScrollableControl.DockPaddingEdges DockPadding { get; }
+        public HScrollProperties HorizontalScroll { get; }
+        protected bool HScroll { get; set; }
+        public VScrollProperties VerticalScroll { get; }
+        protected bool VScroll { get; set; }
+        public event ScrollEventHandler Scroll;
+        protected virtual void AdjustFormScrollbars(bool displayScrollbars);
+        protected bool GetScrollState(int bit);
+        protected override void OnLayout(LayoutEventArgs levent);
+        protected override void OnMouseWheel(MouseEventArgs e);
+        protected override void OnPaddingChanged(EventArgs e);
+        protected override void OnPaintBackground(PaintEventArgs e);
+        protected override void OnRightToLeftChanged(EventArgs e);
+        protected virtual void OnScroll(ScrollEventArgs se);
+        protected override void OnVisibleChanged(EventArgs e);
+        protected override void ScaleControl(SizeF factor, BoundsSpecified specified);
+        protected override void ScaleCore(float dx, float dy);
+        public void ScrollControlIntoView(Control activeControl);
+        protected virtual Point ScrollToControl(Control activeControl);
+        public void SetAutoScrollMargin(int x, int y);
+        protected void SetDisplayRectLocation(int x, int y);
+        protected void SetScrollState(int bit, bool value);
+        protected override void WndProc(ref Message m);
+        public class DockPaddingEdges : ICloneable {
+            public int All { get; set; }
+            public int Bottom { get; set; }
+            public int Left { get; set; }
+            public int Right { get; set; }
+            public int Top { get; set; }
+            public override bool Equals(object other);
+            public override int GetHashCode();
+            object System.ICloneable.Clone();
+            public override string ToString();
+        }
+        public class DockPaddingEdgesConverter : TypeConverter {
+            public DockPaddingEdgesConverter();
+            public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes);
+            public override bool GetPropertiesSupported(ITypeDescriptorContext context);
+        }
+    }
+    public abstract class ScrollBar : Control {
+        public ScrollBar();
+        public override bool AutoSize { get; set; }
+        public override Color BackColor { get; set; }
+        public override Image BackgroundImage { get; set; }
+        public override ImageLayout BackgroundImageLayout { get; set; }
+        protected override CreateParams CreateParams { get; }
+        protected override ImeMode DefaultImeMode { get; }
+        protected override Padding DefaultMargin { get; }
+        public override Font Font { get; set; }
+        public override Color ForeColor { get; set; }
+        public new ImeMode ImeMode { get; set; }
+        public int LargeChange { get; set; }
+        public int Maximum { get; set; }
+        public int Minimum { get; set; }
+        public int SmallChange { get; set; }
+        public new bool TabStop { get; set; }
+        public override string Text { get; set; }
+        public int Value { get; set; }
+        public new event EventHandler AutoSizeChanged;
+        public new event EventHandler BackColorChanged;
+        public new event EventHandler BackgroundImageChanged;
+        public new event EventHandler BackgroundImageLayoutChanged;
+        public new event EventHandler Click;
+        public new event EventHandler DoubleClick;
+        public new event EventHandler FontChanged;
+        public new event EventHandler ForeColorChanged;
+        public new event EventHandler ImeModeChanged;
+        public new event MouseEventHandler MouseClick;
+        public new event MouseEventHandler MouseDoubleClick;
+        public new event MouseEventHandler MouseDown;
+        public new event MouseEventHandler MouseMove;
+        public new event MouseEventHandler MouseUp;
+        public new event PaintEventHandler Paint;
+        public event ScrollEventHandler Scroll;
+        public new event EventHandler TextChanged;
+        public event EventHandler ValueChanged;
+        protected override Rectangle GetScaledBounds(Rectangle bounds, SizeF factor, BoundsSpecified specified);
+        protected override void OnEnabledChanged(EventArgs e);
+        protected override void OnHandleCreated(EventArgs e);
+        protected override void OnMouseWheel(MouseEventArgs e);
+        protected virtual void OnScroll(ScrollEventArgs se);
+        protected virtual void OnValueChanged(EventArgs e);
+        public override string ToString();
+        protected void UpdateScrollInfo();
+        protected override void WndProc(ref Message m);
+    }
+    public sealed class ScrollBarRenderer {
+        public static bool IsSupported { get; }
+        public static void DrawArrowButton(Graphics g, Rectangle bounds, ScrollBarArrowButtonState state);
+        public static void DrawHorizontalThumb(Graphics g, Rectangle bounds, ScrollBarState state);
+        public static void DrawHorizontalThumbGrip(Graphics g, Rectangle bounds, ScrollBarState state);
+        public static void DrawLeftHorizontalTrack(Graphics g, Rectangle bounds, ScrollBarState state);
+        public static void DrawLowerVerticalTrack(Graphics g, Rectangle bounds, ScrollBarState state);
+        public static void DrawRightHorizontalTrack(Graphics g, Rectangle bounds, ScrollBarState state);
+        public static void DrawSizeBox(Graphics g, Rectangle bounds, ScrollBarSizeBoxState state);
+        public static void DrawUpperVerticalTrack(Graphics g, Rectangle bounds, ScrollBarState state);
+        public static void DrawVerticalThumb(Graphics g, Rectangle bounds, ScrollBarState state);
+        public static void DrawVerticalThumbGrip(Graphics g, Rectangle bounds, ScrollBarState state);
+        public static Size GetSizeBoxSize(Graphics g, ScrollBarState state);
+        public static Size GetThumbGripSize(Graphics g, ScrollBarState state);
+    }
+    public enum ScrollBars {
+        Both = 3,
+        Horizontal = 1,
+        None = 0,
+        Vertical = 2,
+    }
+    public enum ScrollButton {
+        Down = 1,
+        Left = 2,
+        Max = 3,
+        Min = 0,
+        Right = 3,
+        Up = 0,
+    }
+    public class ScrollEventArgs : EventArgs {
+        public ScrollEventArgs(ScrollEventType type, int newValue);
+        public ScrollEventArgs(ScrollEventType type, int oldValue, int newValue);
+        public ScrollEventArgs(ScrollEventType type, int oldValue, int newValue, ScrollOrientation scroll);
+        public ScrollEventArgs(ScrollEventType type, int newValue, ScrollOrientation scroll);
+        public int NewValue { get; set; }
+        public int OldValue { get; }
+        public ScrollOrientation ScrollOrientation { get; }
+        public ScrollEventType Type { get; }
+    }
+    public delegate void ScrollEventHandler(object sender, ScrollEventArgs e);
+    public enum ScrollEventType {
+        EndScroll = 8,
+        First = 6,
+        LargeDecrement = 2,
+        LargeIncrement = 3,
+        Last = 7,
+        SmallDecrement = 0,
+        SmallIncrement = 1,
+        ThumbPosition = 4,
+        ThumbTrack = 5,
+    }
+    public enum ScrollOrientation {
+        HorizontalScroll = 0,
+        VerticalScroll = 1,
+    }
+    public abstract class ScrollProperties {
+        protected ScrollProperties(ScrollableControl container);
+        public bool Enabled { get; set; }
+        public int LargeChange { get; set; }
+        public int Maximum { get; set; }
+        public int Minimum { get; set; }
+        protected ScrollableControl ParentControl { get; }
+        public int SmallChange { get; set; }
+        public int Value { get; set; }
+        public bool Visible { get; set; }
+    }
+    public enum SearchDirectionHint {
+        Down = 40,
+        Left = 37,
+        Right = 39,
+        Up = 38,
+    }
+    public class SearchForVirtualItemEventArgs : EventArgs {
+        public SearchForVirtualItemEventArgs(bool isTextSearch, bool isPrefixSearch, bool includeSubItemsInSearch, string text, Point startingPoint, SearchDirectionHint direction, int startIndex);
+        public SearchDirectionHint Direction { get; }
+        public bool IncludeSubItemsInSearch { get; }
+        public int Index { get; set; }
+        public bool IsPrefixSearch { get; }
+        public bool IsTextSearch { get; }
+        public int StartIndex { get; }
+        public Point StartingPoint { get; }
+        public string Text { get; }
+    }
+    public delegate void SearchForVirtualItemEventHandler(object sender, SearchForVirtualItemEventArgs e);
+    public enum SecurityIDType {
+        Alias = 4,
+        Computer = 9,
+        DeletedAccount = 6,
+        Domain = 3,
+        Group = 2,
+        Invalid = 7,
+        Unknown = 8,
+        User = 1,
+        WellKnownGroup = 5,
+    }
+    public class SelectedGridItemChangedEventArgs : EventArgs {
+        public SelectedGridItemChangedEventArgs(GridItem oldSel, GridItem newSel);
+        public GridItem NewSelection { get; }
+        public GridItem OldSelection { get; }
+    }
+    public delegate void SelectedGridItemChangedEventHandler(object sender, SelectedGridItemChangedEventArgs e);
+    public enum SelectionMode {
+        MultiExtended = 3,
+        MultiSimple = 2,
+        None = 0,
+        One = 1,
+    }
+    public sealed class SelectionRange {
+        public SelectionRange();
+        public SelectionRange(DateTime lower, DateTime upper);
+        public SelectionRange(SelectionRange range);
+        public DateTime End { get; set; }
+        public DateTime Start { get; set; }
+        public override string ToString();
+    }
+    public class SelectionRangeConverter : TypeConverter {
+        public SelectionRangeConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+        public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues);
+        public override bool GetCreateInstanceSupported(ITypeDescriptorContext context);
+        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes);
+        public override bool GetPropertiesSupported(ITypeDescriptorContext context);
+    }
+    public class SendKeys {
+        public static void Flush();
+        public static void Send(string keys);
+        public static void SendWait(string keys);
+    }
+    public enum Shortcut {
+        Alt0 = 262192,
+        Alt1 = 262193,
+        Alt2 = 262194,
+        Alt3 = 262195,
+        Alt4 = 262196,
+        Alt5 = 262197,
+        Alt6 = 262198,
+        Alt7 = 262199,
+        Alt8 = 262200,
+        Alt9 = 262201,
+        AltBksp = 262152,
+        AltDownArrow = 262184,
+        AltF1 = 262256,
+        AltF10 = 262265,
+        AltF11 = 262266,
+        AltF12 = 262267,
+        AltF2 = 262257,
+        AltF3 = 262258,
+        AltF4 = 262259,
+        AltF5 = 262260,
+        AltF6 = 262261,
+        AltF7 = 262262,
+        AltF8 = 262263,
+        AltF9 = 262264,
+        AltLeftArrow = 262181,
+        AltRightArrow = 262183,
+        AltUpArrow = 262182,
+        Ctrl0 = 131120,
+        Ctrl1 = 131121,
+        Ctrl2 = 131122,
+        Ctrl3 = 131123,
+        Ctrl4 = 131124,
+        Ctrl5 = 131125,
+        Ctrl6 = 131126,
+        Ctrl7 = 131127,
+        Ctrl8 = 131128,
+        Ctrl9 = 131129,
+        CtrlA = 131137,
+        CtrlB = 131138,
+        CtrlC = 131139,
+        CtrlD = 131140,
+        CtrlDel = 131118,
+        CtrlE = 131141,
+        CtrlF = 131142,
+        CtrlF1 = 131184,
+        CtrlF10 = 131193,
+        CtrlF11 = 131194,
+        CtrlF12 = 131195,
+        CtrlF2 = 131185,
+        CtrlF3 = 131186,
+        CtrlF4 = 131187,
+        CtrlF5 = 131188,
+        CtrlF6 = 131189,
+        CtrlF7 = 131190,
+        CtrlF8 = 131191,
+        CtrlF9 = 131192,
+        CtrlG = 131143,
+        CtrlH = 131144,
+        CtrlI = 131145,
+        CtrlIns = 131117,
+        CtrlJ = 131146,
+        CtrlK = 131147,
+        CtrlL = 131148,
+        CtrlM = 131149,
+        CtrlN = 131150,
+        CtrlO = 131151,
+        CtrlP = 131152,
+        CtrlQ = 131153,
+        CtrlR = 131154,
+        CtrlS = 131155,
+        CtrlShift0 = 196656,
+        CtrlShift1 = 196657,
+        CtrlShift2 = 196658,
+        CtrlShift3 = 196659,
+        CtrlShift4 = 196660,
+        CtrlShift5 = 196661,
+        CtrlShift6 = 196662,
+        CtrlShift7 = 196663,
+        CtrlShift8 = 196664,
+        CtrlShift9 = 196665,
+        CtrlShiftA = 196673,
+        CtrlShiftB = 196674,
+        CtrlShiftC = 196675,
+        CtrlShiftD = 196676,
+        CtrlShiftE = 196677,
+        CtrlShiftF = 196678,
+        CtrlShiftF1 = 196720,
+        CtrlShiftF10 = 196729,
+        CtrlShiftF11 = 196730,
+        CtrlShiftF12 = 196731,
+        CtrlShiftF2 = 196721,
+        CtrlShiftF3 = 196722,
+        CtrlShiftF4 = 196723,
+        CtrlShiftF5 = 196724,
+        CtrlShiftF6 = 196725,
+        CtrlShiftF7 = 196726,
+        CtrlShiftF8 = 196727,
+        CtrlShiftF9 = 196728,
+        CtrlShiftG = 196679,
+        CtrlShiftH = 196680,
+        CtrlShiftI = 196681,
+        CtrlShiftJ = 196682,
+        CtrlShiftK = 196683,
+        CtrlShiftL = 196684,
+        CtrlShiftM = 196685,
+        CtrlShiftN = 196686,
+        CtrlShiftO = 196687,
+        CtrlShiftP = 196688,
+        CtrlShiftQ = 196689,
+        CtrlShiftR = 196690,
+        CtrlShiftS = 196691,
+        CtrlShiftT = 196692,
+        CtrlShiftU = 196693,
+        CtrlShiftV = 196694,
+        CtrlShiftW = 196695,
+        CtrlShiftX = 196696,
+        CtrlShiftY = 196697,
+        CtrlShiftZ = 196698,
+        CtrlT = 131156,
+        CtrlU = 131157,
+        CtrlV = 131158,
+        CtrlW = 131159,
+        CtrlX = 131160,
+        CtrlY = 131161,
+        CtrlZ = 131162,
+        Del = 46,
+        F1 = 112,
+        F10 = 121,
+        F11 = 122,
+        F12 = 123,
+        F2 = 113,
+        F3 = 114,
+        F4 = 115,
+        F5 = 116,
+        F6 = 117,
+        F7 = 118,
+        F8 = 119,
+        F9 = 120,
+        Ins = 45,
+        None = 0,
+        ShiftDel = 65582,
+        ShiftF1 = 65648,
+        ShiftF10 = 65657,
+        ShiftF11 = 65658,
+        ShiftF12 = 65659,
+        ShiftF2 = 65649,
+        ShiftF3 = 65650,
+        ShiftF4 = 65651,
+        ShiftF5 = 65652,
+        ShiftF6 = 65653,
+        ShiftF7 = 65654,
+        ShiftF8 = 65655,
+        ShiftF9 = 65656,
+        ShiftIns = 65581,
+    }
+    public enum SizeGripStyle {
+        Auto = 0,
+        Hide = 2,
+        Show = 1,
+    }
+    public enum SizeType {
+        Absolute = 1,
+        AutoSize = 0,
+        Percent = 2,
+    }
+    public enum SortOrder {
+        Ascending = 1,
+        Descending = 2,
+        None = 0,
+    }
+    public class SplitContainer : ContainerControl, ISupportInitialize {
+        public SplitContainer();
+        public override bool AutoScroll { get; set; }
+        public new Size AutoScrollMargin { get; set; }
+        public new Size AutoScrollMinSize { get; set; }
+        public override Point AutoScrollOffset { get; set; }
+        public new Point AutoScrollPosition { get; set; }
+        public override bool AutoSize { get; set; }
+        public override Image BackgroundImage { get; set; }
+        public override ImageLayout BackgroundImageLayout { get; set; }
+        public override BindingContext BindingContext { get; set; }
+        public BorderStyle BorderStyle { get; set; }
+        public new Control.ControlCollection Controls { get; }
+        protected override Size DefaultSize { get; }
+        public new DockStyle Dock { get; set; }
+        public FixedPanel FixedPanel { get; set; }
+        public bool IsSplitterFixed { get; set; }
+        public Orientation Orientation { get; set; }
+        public new Padding Padding { get; set; }
+        public SplitterPanel Panel1 { get; }
+        public bool Panel1Collapsed { get; set; }
+        public int Panel1MinSize { get; set; }
+        public SplitterPanel Panel2 { get; }
+        public bool Panel2Collapsed { get; set; }
+        public int Panel2MinSize { get; set; }
+        public int SplitterDistance { get; set; }
+        public int SplitterIncrement { get; set; }
+        public Rectangle SplitterRectangle { get; }
+        public int SplitterWidth { get; set; }
+        public new bool TabStop { get; set; }
+        public override string Text { get; set; }
+        public new event EventHandler AutoSizeChanged;
+        public new event EventHandler BackgroundImageChanged;
+        public new event EventHandler BackgroundImageLayoutChanged;
+        public new event ControlEventHandler ControlAdded;
+        public new event ControlEventHandler ControlRemoved;
+        public new event EventHandler PaddingChanged;
+        public event SplitterEventHandler SplitterMoved;
+        public event SplitterCancelEventHandler SplitterMoving;
+        public new event EventHandler TextChanged;
+        public void BeginInit();
+        protected override Control.ControlCollection CreateControlsInstance();
+        public void EndInit();
+        protected override void OnGotFocus(EventArgs e);
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected override void OnKeyUp(KeyEventArgs e);
+        protected override void OnLayout(LayoutEventArgs e);
+        protected override void OnLostFocus(EventArgs e);
+        protected override void OnMouseCaptureChanged(EventArgs e);
+        protected override void OnMouseDown(MouseEventArgs e);
+        protected override void OnMouseLeave(EventArgs e);
+        protected override void OnMouseMove(MouseEventArgs e);
+        protected override void OnMouseUp(MouseEventArgs e);
+        protected override void OnMove(EventArgs e);
+        protected override void OnPaint(PaintEventArgs e);
+        protected override void OnRightToLeftChanged(EventArgs e);
+        public void OnSplitterMoved(SplitterEventArgs e);
+        public void OnSplitterMoving(SplitterCancelEventArgs e);
+        protected override bool ProcessDialogKey(Keys keyData);
+        protected override bool ProcessTabKey(bool forward);
+        protected override void ScaleControl(SizeF factor, BoundsSpecified specified);
+        protected override void Select(bool directed, bool forward);
+        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified);
+        protected override void WndProc(ref Message msg);
+    }
+    public class Splitter : Control {
+        public Splitter();
+        public override bool AllowDrop { get; set; }
+        public override AnchorStyles Anchor { get; set; }
+        public override Image BackgroundImage { get; set; }
+        public override ImageLayout BackgroundImageLayout { get; set; }
+        public BorderStyle BorderStyle { get; set; }
+        protected override CreateParams CreateParams { get; }
+        protected override Cursor DefaultCursor { get; }
+        protected override ImeMode DefaultImeMode { get; }
+        protected override Size DefaultSize { get; }
+        public override DockStyle Dock { get; set; }
+        public override Font Font { get; set; }
+        public override Color ForeColor { get; set; }
+        public new ImeMode ImeMode { get; set; }
+        public int MinExtra { get; set; }
+        public int MinSize { get; set; }
+        public int SplitPosition { get; set; }
+        public new bool TabStop { get; set; }
+        public override string Text { get; set; }
+        public new event EventHandler BackgroundImageChanged;
+        public new event EventHandler BackgroundImageLayoutChanged;
+        public new event EventHandler Enter;
+        public new event EventHandler FontChanged;
+        public new event EventHandler ForeColorChanged;
+        public new event EventHandler ImeModeChanged;
+        public new event KeyEventHandler KeyDown;
+        public new event KeyPressEventHandler KeyPress;
+        public new event KeyEventHandler KeyUp;
+        public new event EventHandler Leave;
+        public event SplitterEventHandler SplitterMoved;
+        public event SplitterEventHandler SplitterMoving;
+        public new event EventHandler TabStopChanged;
+        public new event EventHandler TextChanged;
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected override void OnMouseDown(MouseEventArgs e);
+        protected override void OnMouseMove(MouseEventArgs e);
+        protected override void OnMouseUp(MouseEventArgs e);
+        protected virtual void OnSplitterMoved(SplitterEventArgs sevent);
+        protected virtual void OnSplitterMoving(SplitterEventArgs sevent);
+        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified);
+        public override string ToString();
+    }
+    public class SplitterCancelEventArgs : CancelEventArgs {
+        public SplitterCancelEventArgs(int mouseCursorX, int mouseCursorY, int splitX, int splitY);
+        public int MouseCursorX { get; }
+        public int MouseCursorY { get; }
+        public int SplitX { get; set; }
+        public int SplitY { get; set; }
+    }
+    public delegate void SplitterCancelEventHandler(object sender, SplitterCancelEventArgs e);
+    public class SplitterEventArgs : EventArgs {
+        public SplitterEventArgs(int x, int y, int splitX, int splitY);
+        public int SplitX { get; set; }
+        public int SplitY { get; set; }
+        public int X { get; }
+        public int Y { get; }
+    }
+    public delegate void SplitterEventHandler(object sender, SplitterEventArgs e);
+    public sealed class SplitterPanel : Panel {
+        public SplitterPanel(SplitContainer owner);
+        public new AnchorStyles Anchor { get; set; }
+        public new bool AutoSize { get; set; }
+        public override AutoSizeMode AutoSizeMode { get; set; }
+        public new BorderStyle BorderStyle { get; set; }
+        protected override Padding DefaultMargin { get; }
+        public new DockStyle Dock { get; set; }
+        public new ScrollableControl.DockPaddingEdges DockPadding { get; }
+        public new int Height { get; set; }
+        public new Point Location { get; set; }
+        public new Size MaximumSize { get; set; }
+        public new Size MinimumSize { get; set; }
+        public new string Name { get; set; }
+        public new Control Parent { get; set; }
+        public new Size Size { get; set; }
+        public new int TabIndex { get; set; }
+        public new bool TabStop { get; set; }
+        public new bool Visible { get; set; }
+        public new int Width { get; set; }
+        public new event EventHandler AutoSizeChanged;
+        public new event EventHandler DockChanged;
+        public new event EventHandler LocationChanged;
+        public new event EventHandler TabIndexChanged;
+        public new event EventHandler TabStopChanged;
+        public new event EventHandler VisibleChanged;
+    }
+    public class StatusBar : Control {
+        public StatusBar();
+        public override Color BackColor { get; set; }
+        public override Image BackgroundImage { get; set; }
+        public override ImageLayout BackgroundImageLayout { get; set; }
+        protected override CreateParams CreateParams { get; }
+        protected override ImeMode DefaultImeMode { get; }
+        protected override Size DefaultSize { get; }
+        public override DockStyle Dock { get; set; }
+        protected override bool DoubleBuffered { get; set; }
+        public override Font Font { get; set; }
+        public override Color ForeColor { get; set; }
+        public new ImeMode ImeMode { get; set; }
+        public StatusBar.StatusBarPanelCollection Panels { get; }
+        public bool ShowPanels { get; set; }
+        public bool SizingGrip { get; set; }
+        public new bool TabStop { get; set; }
+        public override string Text { get; set; }
+        public new event EventHandler BackColorChanged;
+        public new event EventHandler BackgroundImageChanged;
+        public new event EventHandler BackgroundImageLayoutChanged;
+        public event StatusBarDrawItemEventHandler DrawItem;
+        public new event EventHandler ForeColorChanged;
+        public new event EventHandler ImeModeChanged;
+        public new event PaintEventHandler Paint;
+        public event StatusBarPanelClickEventHandler PanelClick;
+        protected override void CreateHandle();
+        protected override void Dispose(bool disposing);
+        protected virtual void OnDrawItem(StatusBarDrawItemEventArgs sbdievent);
+        protected override void OnHandleCreated(EventArgs e);
+        protected override void OnHandleDestroyed(EventArgs e);
+        protected override void OnLayout(LayoutEventArgs levent);
+        protected override void OnMouseDown(MouseEventArgs e);
+        protected virtual void OnPanelClick(StatusBarPanelClickEventArgs e);
+        protected override void OnResize(EventArgs e);
+        public override string ToString();
+        protected override void WndProc(ref Message m);
+        public class StatusBarPanelCollection : ICollection, IEnumerable, IList {
+            public StatusBarPanelCollection(StatusBar owner);
+            public int Count { get; }
+            public bool IsReadOnly { get; }
+            bool System.Collections.ICollection.IsSynchronized { get; }
+            object System.Collections.ICollection.SyncRoot { get; }
+            bool System.Collections.IList.IsFixedSize { get; }
+            object System.Collections.IList.this[int index] { get; set; }
+            public virtual StatusBarPanel this[int index] { get; set; }
+            public virtual StatusBarPanel this[string key] { get; }
+            public virtual StatusBarPanel Add(string text);
+            public virtual int Add(StatusBarPanel value);
+            public virtual void AddRange(StatusBarPanel[] panels);
+            public virtual void Clear();
+            public bool Contains(StatusBarPanel panel);
+            public virtual bool ContainsKey(string key);
+            public IEnumerator GetEnumerator();
+            public int IndexOf(StatusBarPanel panel);
+            public virtual int IndexOfKey(string key);
+            public virtual void Insert(int index, StatusBarPanel value);
+            public virtual void Remove(StatusBarPanel value);
+            public virtual void RemoveAt(int index);
+            public virtual void RemoveByKey(string key);
+            void System.Collections.ICollection.CopyTo(Array dest, int index);
+            int System.Collections.IList.Add(object value);
+            bool System.Collections.IList.Contains(object panel);
+            int System.Collections.IList.IndexOf(object panel);
+            void System.Collections.IList.Insert(int index, object value);
+            void System.Collections.IList.Remove(object value);
+        }
+    }
+    public class StatusBarDrawItemEventArgs : DrawItemEventArgs {
+        public StatusBarDrawItemEventArgs(Graphics g, Font font, Rectangle r, int itemId, DrawItemState itemState, StatusBarPanel panel);
+        public StatusBarDrawItemEventArgs(Graphics g, Font font, Rectangle r, int itemId, DrawItemState itemState, StatusBarPanel panel, Color foreColor, Color backColor);
+        public StatusBarPanel Panel { get; }
+    }
+    public delegate void StatusBarDrawItemEventHandler(object sender, StatusBarDrawItemEventArgs sbdevent);
+    public class StatusBarPanel : Component, ISupportInitialize {
+        public StatusBarPanel();
+        public HorizontalAlignment Alignment { get; set; }
+        public StatusBarPanelAutoSize AutoSize { get; set; }
+        public StatusBarPanelBorderStyle BorderStyle { get; set; }
+        public Icon Icon { get; set; }
+        public int MinWidth { get; set; }
+        public string Name { get; set; }
+        public StatusBar Parent { get; }
+        public StatusBarPanelStyle Style { get; set; }
+        public object Tag { get; set; }
+        public string Text { get; set; }
+        public string ToolTipText { get; set; }
+        public int Width { get; set; }
+        public void BeginInit();
+        protected override void Dispose(bool disposing);
+        public void EndInit();
+        public override string ToString();
+    }
+    public enum StatusBarPanelAutoSize {
+        Contents = 3,
+        None = 1,
+        Spring = 2,
+    }
+    public enum StatusBarPanelBorderStyle {
+        None = 1,
+        Raised = 2,
+        Sunken = 3,
+    }
+    public class StatusBarPanelClickEventArgs : MouseEventArgs {
+        public StatusBarPanelClickEventArgs(StatusBarPanel statusBarPanel, MouseButtons button, int clicks, int x, int y);
+        public StatusBarPanel StatusBarPanel { get; }
+    }
+    public delegate void StatusBarPanelClickEventHandler(object sender, StatusBarPanelClickEventArgs e);
+    public enum StatusBarPanelStyle {
+        OwnerDraw = 2,
+        Text = 1,
+    }
+    public class StatusStrip : ToolStrip {
+        public StatusStrip();
+        public new bool CanOverflow { get; set; }
+        protected override DockStyle DefaultDock { get; }
+        protected override Padding DefaultPadding { get; }
+        protected override bool DefaultShowItemToolTips { get; }
+        protected override Size DefaultSize { get; }
+        public override DockStyle Dock { get; set; }
+        public new ToolStripGripStyle GripStyle { get; set; }
+        public new ToolStripLayoutStyle LayoutStyle { get; set; }
+        public new Padding Padding { get; set; }
+        public new bool ShowItemToolTips { get; set; }
+        public Rectangle SizeGripBounds { get; }
+        public bool SizingGrip { get; set; }
+        public new bool Stretch { get; set; }
+        public new event EventHandler PaddingChanged;
+        protected override AccessibleObject CreateAccessibilityInstance();
+        protected internal override ToolStripItem CreateDefaultItem(string text, Image image, EventHandler onClick);
+        protected override void Dispose(bool disposing);
+        protected override void OnLayout(LayoutEventArgs levent);
+        protected override void OnPaintBackground(PaintEventArgs e);
+        protected virtual void OnSpringTableLayoutCore();
+        protected override void SetDisplayedItems();
+        protected override void WndProc(ref Message m);
+    }
+    public enum StructFormat {
+        Ansi = 1,
+        Auto = 3,
+        Unicode = 2,
+    }
+    public class SystemInformation {
+        public static int ActiveWindowTrackingDelay { get; }
+        public static ArrangeDirection ArrangeDirection { get; }
+        public static ArrangeStartingPosition ArrangeStartingPosition { get; }
+        public static BootMode BootMode { get; }
+        public static Size Border3DSize { get; }
+        public static int BorderMultiplierFactor { get; }
+        public static Size BorderSize { get; }
+        public static Size CaptionButtonSize { get; }
+        public static int CaptionHeight { get; }
+        public static int CaretBlinkTime { get; }
+        public static int CaretWidth { get; }
+        public static string ComputerName { get; }
+        public static Size CursorSize { get; }
+        public static bool DbcsEnabled { get; }
+        public static bool DebugOS { get; }
+        public static Size DoubleClickSize { get; }
+        public static int DoubleClickTime { get; }
+        public static bool DragFullWindows { get; }
+        public static Size DragSize { get; }
+        public static Size FixedFrameBorderSize { get; }
+        public static int FontSmoothingContrast { get; }
+        public static int FontSmoothingType { get; }
+        public static Size FrameBorderSize { get; }
+        public static bool HighContrast { get; }
+        public static int HorizontalFocusThickness { get; }
+        public static int HorizontalResizeBorderThickness { get; }
+        public static int HorizontalScrollBarArrowWidth { get; }
+        public static int HorizontalScrollBarHeight { get; }
+        public static int HorizontalScrollBarThumbWidth { get; }
+        public static int IconHorizontalSpacing { get; }
+        public static Size IconSize { get; }
+        public static Size IconSpacingSize { get; }
+        public static int IconVerticalSpacing { get; }
+        public static bool IsActiveWindowTrackingEnabled { get; }
+        public static bool IsComboBoxAnimationEnabled { get; }
+        public static bool IsDropShadowEnabled { get; }
+        public static bool IsFlatMenuEnabled { get; }
+        public static bool IsFontSmoothingEnabled { get; }
+        public static bool IsHotTrackingEnabled { get; }
+        public static bool IsIconTitleWrappingEnabled { get; }
+        public static bool IsKeyboardPreferred { get; }
+        public static bool IsListBoxSmoothScrollingEnabled { get; }
+        public static bool IsMenuAnimationEnabled { get; }
+        public static bool IsMenuFadeEnabled { get; }
+        public static bool IsMinimizeRestoreAnimationEnabled { get; }
+        public static bool IsSelectionFadeEnabled { get; }
+        public static bool IsSnapToDefaultEnabled { get; }
+        public static bool IsTitleBarGradientEnabled { get; }
+        public static bool IsToolTipAnimationEnabled { get; }
+        public static int KanjiWindowHeight { get; }
+        public static int KeyboardDelay { get; }
+        public static int KeyboardSpeed { get; }
+        public static Size MaxWindowTrackSize { get; }
+        public static bool MenuAccessKeysUnderlined { get; }
+        public static Size MenuBarButtonSize { get; }
+        public static Size MenuButtonSize { get; }
+        public static Size MenuCheckSize { get; }
+        public static Font MenuFont { get; }
+        public static int MenuHeight { get; }
+        public static int MenuShowDelay { get; }
+        public static bool MidEastEnabled { get; }
+        public static Size MinimizedWindowSize { get; }
+        public static Size MinimizedWindowSpacingSize { get; }
+        public static Size MinimumWindowSize { get; }
+        public static Size MinWindowTrackSize { get; }
+        public static int MonitorCount { get; }
+        public static bool MonitorsSameDisplayFormat { get; }
+        public static int MouseButtons { get; }
+        public static bool MouseButtonsSwapped { get; }
+        public static Size MouseHoverSize { get; }
+        public static int MouseHoverTime { get; }
+        public static bool MousePresent { get; }
+        public static int MouseSpeed { get; }
+        public static bool MouseWheelPresent { get; }
+        public static int MouseWheelScrollDelta { get; }
+        public static int MouseWheelScrollLines { get; }
+        public static bool NativeMouseWheelSupport { get; }
+        public static bool Network { get; }
+        public static bool PenWindows { get; }
+        public static LeftRightAlignment PopupMenuAlignment { get; }
+        public static PowerStatus PowerStatus { get; }
+        public static Size PrimaryMonitorMaximizedWindowSize { get; }
+        public static Size PrimaryMonitorSize { get; }
+        public static bool RightAlignedMenus { get; }
+        public static ScreenOrientation ScreenOrientation { get; }
+        public static bool Secure { get; }
+        public static bool ShowSounds { get; }
+        public static int SizingBorderWidth { get; }
+        public static Size SmallCaptionButtonSize { get; }
+        public static Size SmallIconSize { get; }
+        public static bool TerminalServerSession { get; }
+        public static Size ToolWindowCaptionButtonSize { get; }
+        public static int ToolWindowCaptionHeight { get; }
+        public static bool UIEffectsEnabled { get; }
+        public static string UserDomainName { get; }
+        public static bool UserInteractive { get; }
+        public static string UserName { get; }
+        public static int VerticalFocusThickness { get; }
+        public static int VerticalResizeBorderThickness { get; }
+        public static int VerticalScrollBarArrowHeight { get; }
+        public static int VerticalScrollBarThumbHeight { get; }
+        public static int VerticalScrollBarWidth { get; }
+        public static Rectangle VirtualScreen { get; }
+        public static Rectangle WorkingArea { get; }
+    }
+    public enum SystemParameter {
+        CaretWidthMetric = 8,
+        DropShadow = 0,
+        FlatMenu = 1,
+        FontSmoothingContrastMetric = 2,
+        FontSmoothingTypeMetric = 3,
+        HorizontalFocusThicknessMetric = 10,
+        MenuFadeEnabled = 4,
+        SelectionFade = 5,
+        ToolTipAnimationMetric = 6,
+        UIEffects = 7,
+        VerticalFocusThicknessMetric = 9,
+    }
+    public enum TabAlignment {
+        Bottom = 1,
+        Left = 2,
+        Right = 3,
+        Top = 0,
+    }
+    public enum TabAppearance {
+        Buttons = 1,
+        FlatButtons = 2,
+        Normal = 0,
+    }
+    public class TabControl : Control {
+        public TabControl();
+        public TabAlignment Alignment { get; set; }
+        public TabAppearance Appearance { get; set; }
+        public override Color BackColor { get; set; }
+        public override Image BackgroundImage { get; set; }
+        public override ImageLayout BackgroundImageLayout { get; set; }
+        protected override CreateParams CreateParams { get; }
+        protected override Size DefaultSize { get; }
+        public override Rectangle DisplayRectangle { get; }
+        protected override bool DoubleBuffered { get; set; }
+        public TabDrawMode DrawMode { get; set; }
+        public override Color ForeColor { get; set; }
+        public bool HotTrack { get; set; }
+        public ImageList ImageList { get; set; }
+        public Size ItemSize { get; set; }
+        public bool Multiline { get; set; }
+        public new Point Padding { get; set; }
+        public virtual bool RightToLeftLayout { get; set; }
+        public int RowCount { get; }
+        public int SelectedIndex { get; set; }
+        public TabPage SelectedTab { get; set; }
+        public bool ShowToolTips { get; set; }
+        public TabSizeMode SizeMode { get; set; }
+        public int TabCount { get; }
+        public TabControl.TabPageCollection TabPages { get; }
+        public override string Text { get; set; }
+        public new event EventHandler BackColorChanged;
+        public new event EventHandler BackgroundImageChanged;
+        public new event EventHandler BackgroundImageLayoutChanged;
+        public event TabControlEventHandler Deselected;
+        public event TabControlCancelEventHandler Deselecting;
+        public event DrawItemEventHandler DrawItem;
+        public new event EventHandler ForeColorChanged;
+        public new event PaintEventHandler Paint;
+        public event EventHandler RightToLeftLayoutChanged;
+        public event TabControlEventHandler Selected;
+        public event EventHandler SelectedIndexChanged;
+        public event TabControlCancelEventHandler Selecting;
+        public new event EventHandler TextChanged;
+        protected override Control.ControlCollection CreateControlsInstance();
+        protected override void CreateHandle();
+        public void DeselectTab(int index);
+        public void DeselectTab(string tabPageName);
+        public void DeselectTab(TabPage tabPage);
+        protected override void Dispose(bool disposing);
+        public Control GetControl(int index);
+        protected virtual object[] GetItems();
+        protected virtual object[] GetItems(Type baseType);
+        public Rectangle GetTabRect(int index);
+        protected string GetToolTipText(object item);
+        protected override bool IsInputKey(Keys keyData);
+        protected virtual void OnDeselected(TabControlEventArgs e);
+        protected virtual void OnDeselecting(TabControlCancelEventArgs e);
+        protected virtual void OnDrawItem(DrawItemEventArgs e);
+        protected override void OnEnter(EventArgs e);
+        protected override void OnFontChanged(EventArgs e);
+        protected override void OnHandleCreated(EventArgs e);
+        protected override void OnHandleDestroyed(EventArgs e);
+        protected override void OnKeyDown(KeyEventArgs ke);
+        protected override void OnLeave(EventArgs e);
+        protected override void OnResize(EventArgs e);
+        protected virtual void OnRightToLeftLayoutChanged(EventArgs e);
+        protected virtual void OnSelected(TabControlEventArgs e);
+        protected virtual void OnSelectedIndexChanged(EventArgs e);
+        protected virtual void OnSelecting(TabControlCancelEventArgs e);
+        protected override void OnStyleChanged(EventArgs e);
+        protected override bool ProcessKeyPreview(ref Message m);
+        protected void RemoveAll();
+        protected override void ScaleCore(float dx, float dy);
+        public void SelectTab(int index);
+        public void SelectTab(string tabPageName);
+        public void SelectTab(TabPage tabPage);
+        public override string ToString();
+        protected void UpdateTabSelection(bool updateFocus);
+        protected override void WndProc(ref Message m);
+        public class ControlCollection : Control.ControlCollection {
+            public ControlCollection(TabControl owner);
+            public override void Add(Control value);
+            public override void Remove(Control value);
+        }
+        public class TabPageCollection : ICollection, IEnumerable, IList {
+            public TabPageCollection(TabControl owner);
+            public int Count { get; }
+            public bool IsReadOnly { get; }
+            bool System.Collections.ICollection.IsSynchronized { get; }
+            object System.Collections.ICollection.SyncRoot { get; }
+            bool System.Collections.IList.IsFixedSize { get; }
+            object System.Collections.IList.this[int index] { get; set; }
+            public virtual TabPage this[int index] { get; set; }
+            public virtual TabPage this[string key] { get; }
+            public void Add(string text);
+            public void Add(string key, string text);
+            public void Add(string key, string text, int imageIndex);
+            public void Add(string key, string text, string imageKey);
+            public void Add(TabPage value);
+            public void AddRange(TabPage[] pages);
+            public virtual void Clear();
+            public bool Contains(TabPage page);
+            public virtual bool ContainsKey(string key);
+            public IEnumerator GetEnumerator();
+            public int IndexOf(TabPage page);
+            public virtual int IndexOfKey(string key);
+            public void Insert(int index, string text);
+            public void Insert(int index, string key, string text);
+            public void Insert(int index, string key, string text, int imageIndex);
+            public void Insert(int index, string key, string text, string imageKey);
+            public void Insert(int index, TabPage tabPage);
+            public void Remove(TabPage value);
+            public void RemoveAt(int index);
+            public virtual void RemoveByKey(string key);
+            void System.Collections.ICollection.CopyTo(Array dest, int index);
+            int System.Collections.IList.Add(object value);
+            bool System.Collections.IList.Contains(object page);
+            int System.Collections.IList.IndexOf(object page);
+            void System.Collections.IList.Insert(int index, object tabPage);
+            void System.Collections.IList.Remove(object value);
+        }
+    }
+    public enum TabControlAction {
+        Deselected = 3,
+        Deselecting = 2,
+        Selected = 1,
+        Selecting = 0,
+    }
+    public class TabControlCancelEventArgs : CancelEventArgs {
+        public TabControlCancelEventArgs(TabPage tabPage, int tabPageIndex, bool cancel, TabControlAction action);
+        public TabControlAction Action { get; }
+        public TabPage TabPage { get; }
+        public int TabPageIndex { get; }
+    }
+    public delegate void TabControlCancelEventHandler(object sender, TabControlCancelEventArgs e);
+    public class TabControlEventArgs : EventArgs {
+        public TabControlEventArgs(TabPage tabPage, int tabPageIndex, TabControlAction action);
+        public TabControlAction Action { get; }
+        public TabPage TabPage { get; }
+        public int TabPageIndex { get; }
+    }
+    public delegate void TabControlEventHandler(object sender, TabControlEventArgs e);
+    public enum TabDrawMode {
+        Normal = 0,
+        OwnerDrawFixed = 1,
+    }
+    public class TableLayoutCellPaintEventArgs : PaintEventArgs {
+        public TableLayoutCellPaintEventArgs(Graphics g, Rectangle clipRectangle, Rectangle cellBounds, int column, int row);
+        public Rectangle CellBounds { get; }
+        public int Column { get; }
+        public int Row { get; }
+    }
+    public delegate void TableLayoutCellPaintEventHandler(object sender, TableLayoutCellPaintEventArgs e);
+    public class TableLayoutColumnStyleCollection : TableLayoutStyleCollection {
+        public new ColumnStyle this[int index] { get; set; }
+        public int Add(ColumnStyle columnStyle);
+        public bool Contains(ColumnStyle columnStyle);
+        public int IndexOf(ColumnStyle columnStyle);
+        public void Insert(int index, ColumnStyle columnStyle);
+        public void Remove(ColumnStyle columnStyle);
+    }
+    public class TableLayoutControlCollection : Control.ControlCollection {
+        public TableLayoutControlCollection(TableLayoutPanel container);
+        public TableLayoutPanel Container { get; }
+        public virtual void Add(Control control, int column, int row);
+    }
+    public class TableLayoutPanel : Panel, IExtenderProvider {
+        public TableLayoutPanel();
+        public new BorderStyle BorderStyle { get; set; }
+        public TableLayoutPanelCellBorderStyle CellBorderStyle { get; set; }
+        public int ColumnCount { get; set; }
+        public TableLayoutColumnStyleCollection ColumnStyles { get; }
+        public new TableLayoutControlCollection Controls { get; }
+        public TableLayoutPanelGrowStyle GrowStyle { get; set; }
+        public override LayoutEngine LayoutEngine { get; }
+        public TableLayoutSettings LayoutSettings { get; set; }
+        public int RowCount { get; set; }
+        public TableLayoutRowStyleCollection RowStyles { get; }
+        public event TableLayoutCellPaintEventHandler CellPaint;
+        protected override Control.ControlCollection CreateControlsInstance();
+        public TableLayoutPanelCellPosition GetCellPosition(Control control);
+        public int GetColumn(Control control);
+        public int GetColumnSpan(Control control);
+        public int[] GetColumnWidths();
+        public Control GetControlFromPosition(int column, int row);
+        public TableLayoutPanelCellPosition GetPositionFromControl(Control control);
+        public int GetRow(Control control);
+        public int[] GetRowHeights();
+        public int GetRowSpan(Control control);
+        protected virtual void OnCellPaint(TableLayoutCellPaintEventArgs e);
+        protected override void OnLayout(LayoutEventArgs levent);
+        protected override void OnPaintBackground(PaintEventArgs e);
+        protected override void ScaleControl(SizeF factor, BoundsSpecified specified);
+        protected override void ScaleCore(float dx, float dy);
+        public void SetCellPosition(Control control, TableLayoutPanelCellPosition position);
+        public void SetColumn(Control control, int column);
+        public void SetColumnSpan(Control control, int value);
+        public void SetRow(Control control, int row);
+        public void SetRowSpan(Control control, int value);
+        bool System.ComponentModel.IExtenderProvider.CanExtend(object obj);
+    }
+    public enum TableLayoutPanelCellBorderStyle {
+        Inset = 2,
+        InsetDouble = 3,
+        None = 0,
+        Outset = 4,
+        OutsetDouble = 5,
+        OutsetPartial = 6,
+        Single = 1,
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct TableLayoutPanelCellPosition {
+        public TableLayoutPanelCellPosition(int column, int row);
+        public int Column { get; set; }
+        public int Row { get; set; }
+        public override bool Equals(object other);
+        public override int GetHashCode();
+        public static bool operator ==(TableLayoutPanelCellPosition p1, TableLayoutPanelCellPosition p2);
+        public static bool operator !=(TableLayoutPanelCellPosition p1, TableLayoutPanelCellPosition p2);
+        public override string ToString();
+    }
+    public enum TableLayoutPanelGrowStyle {
+        AddColumns = 2,
+        AddRows = 1,
+        FixedSize = 0,
+    }
+    public class TableLayoutRowStyleCollection : TableLayoutStyleCollection {
+        public new RowStyle this[int index] { get; set; }
+        public int Add(RowStyle rowStyle);
+        public bool Contains(RowStyle rowStyle);
+        public int IndexOf(RowStyle rowStyle);
+        public void Insert(int index, RowStyle rowStyle);
+        public void Remove(RowStyle rowStyle);
+    }
+    public sealed class TableLayoutSettings : LayoutSettings, ISerializable {
+        public int ColumnCount { get; set; }
+        public TableLayoutColumnStyleCollection ColumnStyles { get; }
+        public TableLayoutPanelGrowStyle GrowStyle { get; set; }
+        public override LayoutEngine LayoutEngine { get; }
+        public int RowCount { get; set; }
+        public TableLayoutRowStyleCollection RowStyles { get; }
+        public TableLayoutPanelCellPosition GetCellPosition(object control);
+        public int GetColumn(object control);
+        public int GetColumnSpan(object control);
+        public int GetRow(object control);
+        public int GetRowSpan(object control);
+        public void SetCellPosition(object control, TableLayoutPanelCellPosition cellPosition);
+        public void SetColumn(object control, int column);
+        public void SetColumnSpan(object control, int value);
+        public void SetRow(object control, int row);
+        public void SetRowSpan(object control, int value);
+        void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context);
+    }
+    public abstract class TableLayoutStyle {
+        protected TableLayoutStyle();
+        public SizeType SizeType { get; set; }
+    }
+    public abstract class TableLayoutStyleCollection : ICollection, IEnumerable, IList {
+        public int Count { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public TableLayoutStyle this[int index] { get; set; }
+        public int Add(TableLayoutStyle style);
+        public void Clear();
+        public void RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int startIndex);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object style);
+        bool System.Collections.IList.Contains(object style);
+        int System.Collections.IList.IndexOf(object style);
+        void System.Collections.IList.Insert(int index, object style);
+        void System.Collections.IList.Remove(object style);
+    }
+    public class TabPage : Panel {
+        public TabPage();
+        public TabPage(string text);
+        public override AnchorStyles Anchor { get; set; }
+        public override bool AutoSize { get; set; }
+        public override AutoSizeMode AutoSizeMode { get; set; }
+        public override Color BackColor { get; set; }
+        public override DockStyle Dock { get; set; }
+        public new bool Enabled { get; set; }
+        public int ImageIndex { get; set; }
+        public string ImageKey { get; set; }
+        public new Point Location { get; set; }
+        public override Size MaximumSize { get; set; }
+        public override Size MinimumSize { get; set; }
+        public new Size PreferredSize { get; }
+        public new int TabIndex { get; set; }
+        public new bool TabStop { get; set; }
+        public override string Text { get; set; }
+        public string ToolTipText { get; set; }
+        public bool UseVisualStyleBackColor { get; set; }
+        public new bool Visible { get; set; }
+        public new event EventHandler AutoSizeChanged;
+        public new event EventHandler DockChanged;
+        public new event EventHandler EnabledChanged;
+        public new event EventHandler LocationChanged;
+        public new event EventHandler TabIndexChanged;
+        public new event EventHandler TabStopChanged;
+        public new event EventHandler TextChanged;
+        public new event EventHandler VisibleChanged;
+        protected override Control.ControlCollection CreateControlsInstance();
+        public static TabPage GetTabPageOfComponent(object comp);
+        protected override void OnEnter(EventArgs e);
+        protected override void OnLeave(EventArgs e);
+        protected override void OnPaintBackground(PaintEventArgs e);
+        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified);
+        public override string ToString();
+        public class TabPageControlCollection : Control.ControlCollection {
+            public TabPageControlCollection(TabPage owner);
+            public override void Add(Control value);
+        }
+    }
+    public sealed class TabRenderer {
+        public static bool IsSupported { get; }
+        public static void DrawTabItem(Graphics g, Rectangle bounds, bool focused, TabItemState state);
+        public static void DrawTabItem(Graphics g, Rectangle bounds, Image image, Rectangle imageRectangle, bool focused, TabItemState state);
+        public static void DrawTabItem(Graphics g, Rectangle bounds, string tabItemText, Font font, bool focused, TabItemState state);
+        public static void DrawTabItem(Graphics g, Rectangle bounds, string tabItemText, Font font, Image image, Rectangle imageRectangle, bool focused, TabItemState state);
+        public static void DrawTabItem(Graphics g, Rectangle bounds, string tabItemText, Font font, TextFormatFlags flags, bool focused, TabItemState state);
+        public static void DrawTabItem(Graphics g, Rectangle bounds, string tabItemText, Font font, TextFormatFlags flags, Image image, Rectangle imageRectangle, bool focused, TabItemState state);
+        public static void DrawTabItem(Graphics g, Rectangle bounds, string tabItemText, Font font, TabItemState state);
+        public static void DrawTabItem(Graphics g, Rectangle bounds, TabItemState state);
+        public static void DrawTabPage(Graphics g, Rectangle bounds);
+    }
+    public enum TabSizeMode {
+        FillToRight = 1,
+        Fixed = 2,
+        Normal = 0,
+    }
+    public class TextBox : TextBoxBase {
+        public TextBox();
+        public bool AcceptsReturn { get; set; }
+        public AutoCompleteStringCollection AutoCompleteCustomSource { get; set; }
+        public AutoCompleteMode AutoCompleteMode { get; set; }
+        public AutoCompleteSource AutoCompleteSource { get; set; }
+        public CharacterCasing CharacterCasing { get; set; }
+        protected override CreateParams CreateParams { get; }
+        public override bool Multiline { get; set; }
+        public char PasswordChar { get; set; }
+        public ScrollBars ScrollBars { get; set; }
+        public override string Text { get; set; }
+        public HorizontalAlignment TextAlign { get; set; }
+        public bool UseSystemPasswordChar { get; set; }
+        public event EventHandler TextAlignChanged;
+        protected override void Dispose(bool disposing);
+        protected override bool IsInputKey(Keys keyData);
+        protected override void OnBackColorChanged(EventArgs e);
+        protected override void OnFontChanged(EventArgs e);
+        protected override void OnGotFocus(EventArgs e);
+        protected override void OnHandleCreated(EventArgs e);
+        protected override void OnHandleDestroyed(EventArgs e);
+        protected virtual void OnTextAlignChanged(EventArgs e);
+        public void Paste(string text);
+        protected override bool ProcessCmdKey(ref Message m, Keys keyData);
+        protected override void WndProc(ref Message m);
+    }
+    public abstract class TextBoxBase : Control {
+        public bool AcceptsTab { get; set; }
+        public override bool AutoSize { get; set; }
+        public override Color BackColor { get; set; }
+        public override Image BackgroundImage { get; set; }
+        public override ImageLayout BackgroundImageLayout { get; set; }
+        public BorderStyle BorderStyle { get; set; }
+        protected override bool CanEnableIme { get; }
+        public bool CanUndo { get; }
+        protected override CreateParams CreateParams { get; }
+        protected override Cursor DefaultCursor { get; }
+        protected override Size DefaultSize { get; }
+        protected override bool DoubleBuffered { get; set; }
+        public override Color ForeColor { get; set; }
+        public bool HideSelection { get; set; }
+        protected override ImeMode ImeModeBase { get; set; }
+        public string[] Lines { get; set; }
+        public virtual int MaxLength { get; set; }
+        public bool Modified { get; set; }
+        public virtual bool Multiline { get; set; }
+        public new Padding Padding { get; set; }
+        public int PreferredHeight { get; }
+        public bool ReadOnly { get; set; }
+        public virtual string SelectedText { get; set; }
+        public virtual int SelectionLength { get; set; }
+        public int SelectionStart { get; set; }
+        public virtual bool ShortcutsEnabled { get; set; }
+        public override string Text { get; set; }
+        public virtual int TextLength { get; }
+        public bool WordWrap { get; set; }
+        public event EventHandler AcceptsTabChanged;
+        public new event EventHandler AutoSizeChanged;
+        public new event EventHandler BackgroundImageChanged;
+        public new event EventHandler BackgroundImageLayoutChanged;
+        public event EventHandler BorderStyleChanged;
+        public new event EventHandler Click;
+        public event EventHandler HideSelectionChanged;
+        public event EventHandler ModifiedChanged;
+        public new event MouseEventHandler MouseClick;
+        public event EventHandler MultilineChanged;
+        public new event EventHandler PaddingChanged;
+        public new event PaintEventHandler Paint;
+        public event EventHandler ReadOnlyChanged;
+        public void AppendText(string text);
+        public void Clear();
+        public void ClearUndo();
+        public void Copy();
+        protected override void CreateHandle();
+        public void Cut();
+        public void DeselectAll();
+        public virtual char GetCharFromPosition(Point pt);
+        public virtual int GetCharIndexFromPosition(Point pt);
+        public int GetFirstCharIndexFromLine(int lineNumber);
+        public int GetFirstCharIndexOfCurrentLine();
+        public virtual int GetLineFromCharIndex(int index);
+        public virtual Point GetPositionFromCharIndex(int index);
+        protected override bool IsInputKey(Keys keyData);
+        protected virtual void OnAcceptsTabChanged(EventArgs e);
+        protected virtual void OnBorderStyleChanged(EventArgs e);
+        protected override void OnFontChanged(EventArgs e);
+        protected override void OnHandleCreated(EventArgs e);
+        protected override void OnHandleDestroyed(EventArgs e);
+        protected virtual void OnHideSelectionChanged(EventArgs e);
+        protected virtual void OnModifiedChanged(EventArgs e);
+        protected override void OnMouseUp(MouseEventArgs mevent);
+        protected virtual void OnMultilineChanged(EventArgs e);
+        protected override void OnPaddingChanged(EventArgs e);
+        protected virtual void OnReadOnlyChanged(EventArgs e);
+        protected override void OnTextChanged(EventArgs e);
+        public void Paste();
+        protected override bool ProcessCmdKey(ref Message msg, Keys keyData);
+        protected override bool ProcessDialogKey(Keys keyData);
+        public void ScrollToCaret();
+        public void Select(int start, int length);
+        public void SelectAll();
+        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified);
+        public override string ToString();
+        public void Undo();
+        protected override void WndProc(ref Message m);
+    }
+    public sealed class TextBoxRenderer {
+        public static bool IsSupported { get; }
+        public static void DrawTextBox(Graphics g, Rectangle bounds, string textBoxText, Font font, Rectangle textBounds, TextFormatFlags flags, TextBoxState state);
+        public static void DrawTextBox(Graphics g, Rectangle bounds, string textBoxText, Font font, Rectangle textBounds, TextBoxState state);
+        public static void DrawTextBox(Graphics g, Rectangle bounds, string textBoxText, Font font, TextFormatFlags flags, TextBoxState state);
+        public static void DrawTextBox(Graphics g, Rectangle bounds, string textBoxText, Font font, TextBoxState state);
+        public static void DrawTextBox(Graphics g, Rectangle bounds, TextBoxState state);
+    }
+    public enum TextDataFormat {
+        CommaSeparatedValue = 4,
+        Html = 3,
+        Rtf = 2,
+        Text = 0,
+        UnicodeText = 1,
+    }
+    public enum TextFormatFlags {
+        Bottom = 8,
+        Default = 0,
+        EndEllipsis = 32768,
+        ExpandTabs = 64,
+        ExternalLeading = 512,
+        GlyphOverhangPadding = 0,
+        HidePrefix = 1048576,
+        HorizontalCenter = 1,
+        Internal = 4096,
+        Left = 0,
+        LeftAndRightPadding = 536870912,
+        ModifyString = 65536,
+        NoClipping = 256,
+        NoFullWidthCharacterBreak = 524288,
+        NoPadding = 268435456,
+        NoPrefix = 2048,
+        PathEllipsis = 16384,
+        PrefixOnly = 2097152,
+        PreserveGraphicsClipping = 16777216,
+        PreserveGraphicsTranslateTransform = 33554432,
+        Right = 2,
+        RightToLeft = 131072,
+        SingleLine = 32,
+        TextBoxControl = 8192,
+        Top = 0,
+        VerticalCenter = 4,
+        WordBreak = 16,
+        WordEllipsis = 262144,
+    }
+    public enum TextImageRelation {
+        ImageAboveText = 1,
+        ImageBeforeText = 4,
+        Overlay = 0,
+        TextAboveImage = 2,
+        TextBeforeImage = 8,
+    }
+    public sealed class TextRenderer {
+        public static void DrawText(IDeviceContext dc, string text, Font font, Point pt, Color foreColor);
+        public static void DrawText(IDeviceContext dc, string text, Font font, Point pt, Color foreColor, Color backColor);
+        public static void DrawText(IDeviceContext dc, string text, Font font, Point pt, Color foreColor, Color backColor, TextFormatFlags flags);
+        public static void DrawText(IDeviceContext dc, string text, Font font, Point pt, Color foreColor, TextFormatFlags flags);
+        public static void DrawText(IDeviceContext dc, string text, Font font, Rectangle bounds, Color foreColor);
+        public static void DrawText(IDeviceContext dc, string text, Font font, Rectangle bounds, Color foreColor, Color backColor);
+        public static void DrawText(IDeviceContext dc, string text, Font font, Rectangle bounds, Color foreColor, Color backColor, TextFormatFlags flags);
+        public static void DrawText(IDeviceContext dc, string text, Font font, Rectangle bounds, Color foreColor, TextFormatFlags flags);
+        public static Size MeasureText(IDeviceContext dc, string text, Font font);
+        public static Size MeasureText(IDeviceContext dc, string text, Font font, Size proposedSize);
+        public static Size MeasureText(IDeviceContext dc, string text, Font font, Size proposedSize, TextFormatFlags flags);
+        public static Size MeasureText(string text, Font font);
+        public static Size MeasureText(string text, Font font, Size proposedSize);
+        public static Size MeasureText(string text, Font font, Size proposedSize, TextFormatFlags flags);
+    }
+    public class ThreadExceptionDialog : Form {
+        public ThreadExceptionDialog(Exception t);
+        public override bool AutoSize { get; set; }
+        public new event EventHandler AutoSizeChanged;
+    }
+    public enum TickStyle {
+        Both = 3,
+        BottomRight = 2,
+        None = 0,
+        TopLeft = 1,
+    }
+    public class Timer : Component {
+        public Timer();
+        public Timer(IContainer container);
+        public virtual bool Enabled { get; set; }
+        public int Interval { get; set; }
+        public object Tag { get; set; }
+        public event EventHandler Tick;
+        protected override void Dispose(bool disposing);
+        protected virtual void OnTick(EventArgs e);
+        public void Start();
+        public void Stop();
+        public override string ToString();
+    }
+    public class ToolBar : Control {
+        public ToolBar();
+        public ToolBarAppearance Appearance { get; set; }
+        public override bool AutoSize { get; set; }
+        public override Color BackColor { get; set; }
+        public override Image BackgroundImage { get; set; }
+        public override ImageLayout BackgroundImageLayout { get; set; }
+        public BorderStyle BorderStyle { get; set; }
+        public ToolBar.ToolBarButtonCollection Buttons { get; }
+        public Size ButtonSize { get; set; }
+        protected override CreateParams CreateParams { get; }
+        protected override ImeMode DefaultImeMode { get; }
+        protected override Size DefaultSize { get; }
+        public bool Divider { get; set; }
+        public override DockStyle Dock { get; set; }
+        protected override bool DoubleBuffered { get; set; }
+        public bool DropDownArrows { get; set; }
+        public override Color ForeColor { get; set; }
+        public ImageList ImageList { get; set; }
+        public Size ImageSize { get; }
+        public new ImeMode ImeMode { get; set; }
+        public override RightToLeft RightToLeft { get; set; }
+        public bool ShowToolTips { get; set; }
+        public new bool TabStop { get; set; }
+        public override string Text { get; set; }
+        public ToolBarTextAlign TextAlign { get; set; }
+        public bool Wrappable { get; set; }
+        public new event EventHandler AutoSizeChanged;
+        public new event EventHandler BackColorChanged;
+        public new event EventHandler BackgroundImageChanged;
+        public new event EventHandler BackgroundImageLayoutChanged;
+        public event ToolBarButtonClickEventHandler ButtonClick;
+        public event ToolBarButtonClickEventHandler ButtonDropDown;
+        public new event EventHandler ForeColorChanged;
+        public new event EventHandler ImeModeChanged;
+        public new event PaintEventHandler Paint;
+        public new event EventHandler RightToLeftChanged;
+        public new event EventHandler TextChanged;
+        protected override void CreateHandle();
+        protected override void Dispose(bool disposing);
+        protected virtual void OnButtonClick(ToolBarButtonClickEventArgs e);
+        protected virtual void OnButtonDropDown(ToolBarButtonClickEventArgs e);
+        protected override void OnFontChanged(EventArgs e);
+        protected override void OnHandleCreated(EventArgs e);
+        protected override void OnResize(EventArgs e);
+        protected override void ScaleControl(SizeF factor, BoundsSpecified specified);
+        protected override void ScaleCore(float dx, float dy);
+        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified);
+        public override string ToString();
+        protected override void WndProc(ref Message m);
+        public class ToolBarButtonCollection : ICollection, IEnumerable, IList {
+            public ToolBarButtonCollection(ToolBar owner);
+            public int Count { get; }
+            public bool IsReadOnly { get; }
+            bool System.Collections.ICollection.IsSynchronized { get; }
+            object System.Collections.ICollection.SyncRoot { get; }
+            bool System.Collections.IList.IsFixedSize { get; }
+            object System.Collections.IList.this[int index] { get; set; }
+            public virtual ToolBarButton this[int index] { get; set; }
+            public virtual ToolBarButton this[string key] { get; }
+            public int Add(string text);
+            public int Add(ToolBarButton button);
+            public void AddRange(ToolBarButton[] buttons);
+            public void Clear();
+            public bool Contains(ToolBarButton button);
+            public virtual bool ContainsKey(string key);
+            public IEnumerator GetEnumerator();
+            public int IndexOf(ToolBarButton button);
+            public virtual int IndexOfKey(string key);
+            public void Insert(int index, ToolBarButton button);
+            public void Remove(ToolBarButton button);
+            public void RemoveAt(int index);
+            public virtual void RemoveByKey(string key);
+            void System.Collections.ICollection.CopyTo(Array dest, int index);
+            int System.Collections.IList.Add(object button);
+            bool System.Collections.IList.Contains(object button);
+            int System.Collections.IList.IndexOf(object button);
+            void System.Collections.IList.Insert(int index, object button);
+            void System.Collections.IList.Remove(object button);
+        }
+    }
+    public enum ToolBarAppearance {
+        Flat = 1,
+        Normal = 0,
+    }
+    public class ToolBarButton : Component {
+        public ToolBarButton();
+        public ToolBarButton(string text);
+        public Menu DropDownMenu { get; set; }
+        public bool Enabled { get; set; }
+        public int ImageIndex { get; set; }
+        public string ImageKey { get; set; }
+        public string Name { get; set; }
+        public ToolBar Parent { get; }
+        public bool PartialPush { get; set; }
+        public bool Pushed { get; set; }
+        public Rectangle Rectangle { get; }
+        public ToolBarButtonStyle Style { get; set; }
+        public object Tag { get; set; }
+        public string Text { get; set; }
+        public string ToolTipText { get; set; }
+        public bool Visible { get; set; }
+        protected override void Dispose(bool disposing);
+        public override string ToString();
+    }
+    public class ToolBarButtonClickEventArgs : EventArgs {
+        public ToolBarButtonClickEventArgs(ToolBarButton button);
+        public ToolBarButton Button { get; set; }
+    }
+    public delegate void ToolBarButtonClickEventHandler(object sender, ToolBarButtonClickEventArgs e);
+    public enum ToolBarButtonStyle {
+        DropDownButton = 4,
+        PushButton = 1,
+        Separator = 3,
+        ToggleButton = 2,
+    }
+    public enum ToolBarTextAlign {
+        Right = 1,
+        Underneath = 0,
+    }
+    public class ToolStrip : ScrollableControl, IArrangedElement, IComponent, IDisposable {
+        public ToolStrip();
+        public ToolStrip(params ToolStripItem[] items);
+        public override bool AllowDrop { get; set; }
+        public bool AllowItemReorder { get; set; }
+        public bool AllowMerge { get; set; }
+        public override AnchorStyles Anchor { get; set; }
+        public override bool AutoScroll { get; set; }
+        public new Size AutoScrollMargin { get; set; }
+        public new Size AutoScrollMinSize { get; set; }
+        public new Point AutoScrollPosition { get; set; }
+        public override bool AutoSize { get; set; }
+        public new Color BackColor { get; set; }
+        public override BindingContext BindingContext { get; set; }
+        public bool CanOverflow { get; set; }
+        public new bool CausesValidation { get; set; }
+        public new Control.ControlCollection Controls { get; }
+        public override Cursor Cursor { get; set; }
+        protected virtual DockStyle DefaultDock { get; }
+        public virtual ToolStripDropDownDirection DefaultDropDownDirection { get; set; }
+        protected virtual Padding DefaultGripMargin { get; }
+        protected override Padding DefaultMargin { get; }
+        protected override Padding DefaultPadding { get; }
+        protected virtual bool DefaultShowItemToolTips { get; }
+        protected override Size DefaultSize { get; }
+        protected internal virtual ToolStripItemCollection DisplayedItems { get; }
+        public override Rectangle DisplayRectangle { get; }
+        public override DockStyle Dock { get; set; }
+        public override Font Font { get; set; }
+        public new Color ForeColor { get; set; }
+        public ToolStripGripDisplayStyle GripDisplayStyle { get; }
+        public Padding GripMargin { get; set; }
+        public Rectangle GripRectangle { get; }
+        public ToolStripGripStyle GripStyle { get; set; }
+        public new bool HasChildren { get; }
+        public new HScrollProperties HorizontalScroll { get; }
+        public ImageList ImageList { get; set; }
+        public Size ImageScalingSize { get; set; }
+        public bool IsCurrentlyDragging { get; }
+        public bool IsDropDown { get; }
+        public virtual ToolStripItemCollection Items { get; }
+        public override LayoutEngine LayoutEngine { get; }
+        public LayoutSettings LayoutSettings { get; set; }
+        public ToolStripLayoutStyle LayoutStyle { get; set; }
+        protected internal virtual Size MaxItemSize { get; }
+        public Orientation Orientation { get; }
+        public ToolStripOverflowButton OverflowButton { get; }
+        public ToolStripRenderer Renderer { get; set; }
+        public ToolStripRenderMode RenderMode { get; set; }
+        public bool ShowItemToolTips { get; set; }
+        public bool Stretch { get; set; }
+        public new bool TabStop { get; set; }
+        public virtual ToolStripTextDirection TextDirection { get; set; }
+        public new VScrollProperties VerticalScroll { get; }
+        public new event EventHandler AutoSizeChanged;
+        public event EventHandler BeginDrag;
+        public new event EventHandler CausesValidationChanged;
+        public new event ControlEventHandler ControlAdded;
+        public new event ControlEventHandler ControlRemoved;
+        public new event EventHandler CursorChanged;
+        public event EventHandler EndDrag;
+        public new event EventHandler ForeColorChanged;
+        public event ToolStripItemEventHandler ItemAdded;
+        public event ToolStripItemClickedEventHandler ItemClicked;
+        public event ToolStripItemEventHandler ItemRemoved;
+        public event EventHandler LayoutCompleted;
+        public event EventHandler LayoutStyleChanged;
+        public event PaintEventHandler PaintGrip;
+        public event EventHandler RendererChanged;
+        protected override AccessibleObject CreateAccessibilityInstance();
+        protected override Control.ControlCollection CreateControlsInstance();
+        protected internal virtual ToolStripItem CreateDefaultItem(string text, Image image, EventHandler onClick);
+        protected virtual LayoutSettings CreateLayoutSettings(ToolStripLayoutStyle layoutStyle);
+        protected override void Dispose(bool disposing);
+        public new Control GetChildAtPoint(Point point);
+        public new Control GetChildAtPoint(Point pt, GetChildAtPointSkip skipValue);
+        public ToolStripItem GetItemAt(Point point);
+        public ToolStripItem GetItemAt(int x, int y);
+        public virtual ToolStripItem GetNextItem(ToolStripItem start, ArrowDirection direction);
+        protected override bool IsInputChar(char charCode);
+        protected override bool IsInputKey(Keys keyData);
+        protected virtual void OnBeginDrag(EventArgs e);
+        protected override void OnDockChanged(EventArgs e);
+        protected override void OnEnabledChanged(EventArgs e);
+        protected virtual void OnEndDrag(EventArgs e);
+        protected override void OnFontChanged(EventArgs e);
+        protected override void OnHandleCreated(EventArgs e);
+        protected override void OnHandleDestroyed(EventArgs e);
+        protected override void OnInvalidated(InvalidateEventArgs e);
+        protected internal virtual void OnItemAdded(ToolStripItemEventArgs e);
+        protected virtual void OnItemClicked(ToolStripItemClickedEventArgs e);
+        protected internal virtual void OnItemRemoved(ToolStripItemEventArgs e);
+        protected override void OnLayout(LayoutEventArgs e);
+        protected virtual void OnLayoutCompleted(EventArgs e);
+        protected virtual void OnLayoutStyleChanged(EventArgs e);
+        protected override void OnLeave(EventArgs e);
+        protected override void OnLostFocus(EventArgs e);
+        protected override void OnMouseCaptureChanged(EventArgs e);
+        protected override void OnMouseDown(MouseEventArgs mea);
+        protected override void OnMouseLeave(EventArgs e);
+        protected override void OnMouseMove(MouseEventArgs mea);
+        protected override void OnMouseUp(MouseEventArgs mea);
+        protected override void OnPaint(PaintEventArgs e);
+        protected override void OnPaintBackground(PaintEventArgs e);
+        protected internal virtual void OnPaintGrip(PaintEventArgs e);
+        protected virtual void OnRendererChanged(EventArgs e);
+        protected override void OnRightToLeftChanged(EventArgs e);
+        protected override void OnScroll(ScrollEventArgs se);
+        protected override void OnTabStopChanged(EventArgs e);
+        protected override void OnVisibleChanged(EventArgs e);
+        protected override bool ProcessCmdKey(ref Message m, Keys keyData);
+        protected override bool ProcessDialogKey(Keys keyData);
+        protected internal override bool ProcessMnemonic(char charCode);
+        public void ResetMinimumSize();
+        protected virtual void RestoreFocus();
+        protected override void Select(bool directed, bool forward);
+        public new void SetAutoScrollMargin(int x, int y);
+        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified);
+        protected virtual void SetDisplayedItems();
+        protected internal void SetItemLocation(ToolStripItem item, Point location);
+        protected static void SetItemParent(ToolStripItem item, ToolStrip parent);
+        protected override void SetVisibleCore(bool visible);
+        public override string ToString();
+        protected override void WndProc(ref Message m);
+        public class ToolStripAccessibleObject : Control.ControlAccessibleObject {
+            public ToolStripAccessibleObject(ToolStrip owner);
+            public override AccessibleRole Role { get; }
+            public override AccessibleObject GetChild(int index);
+            public override int GetChildCount();
+            public override AccessibleObject HitTest(int x, int y);
+        }
+    }
+    public class ToolStripArrowRenderEventArgs : EventArgs {
+        public ToolStripArrowRenderEventArgs(Graphics g, ToolStripItem toolStripItem, Rectangle arrowRectangle, Color arrowColor, ArrowDirection arrowDirection);
+        public Color ArrowColor { get; set; }
+        public Rectangle ArrowRectangle { get; set; }
+        public ArrowDirection Direction { get; set; }
+        public Graphics Graphics { get; }
+        public ToolStripItem Item { get; }
+    }
+    public delegate void ToolStripArrowRenderEventHandler(object sender, ToolStripArrowRenderEventArgs e);
+    public class ToolStripButton : ToolStripItem {
+        public ToolStripButton();
+        public ToolStripButton(Image image);
+        public ToolStripButton(string text);
+        public ToolStripButton(string text, Image image);
+        public ToolStripButton(string text, Image image, EventHandler onClick);
+        public ToolStripButton(string text, Image image, EventHandler onClick, string name);
+        public new bool AutoToolTip { get; set; }
+        public override bool CanSelect { get; }
+        public bool Checked { get; set; }
+        public bool CheckOnClick { get; set; }
+        public CheckState CheckState { get; set; }
+        protected override bool DefaultAutoToolTip { get; }
+        public event EventHandler CheckedChanged;
+        public event EventHandler CheckStateChanged;
+        protected override AccessibleObject CreateAccessibilityInstance();
+        public override Size GetPreferredSize(Size constrainingSize);
+        protected virtual void OnCheckedChanged(EventArgs e);
+        protected virtual void OnCheckStateChanged(EventArgs e);
+        protected override void OnClick(EventArgs e);
+        protected override void OnPaint(PaintEventArgs e);
+    }
+    public class ToolStripComboBox : ToolStripControlHost {
+        public ToolStripComboBox();
+        public ToolStripComboBox(string name);
+        public ToolStripComboBox(Control c);
+        public AutoCompleteStringCollection AutoCompleteCustomSource { get; set; }
+        public AutoCompleteMode AutoCompleteMode { get; set; }
+        public AutoCompleteSource AutoCompleteSource { get; set; }
+        public override Image BackgroundImage { get; set; }
+        public override ImageLayout BackgroundImageLayout { get; set; }
+        public ComboBox ComboBox { get; }
+        protected internal override Padding DefaultMargin { get; }
+        protected override Size DefaultSize { get; }
+        public int DropDownHeight { get; set; }
+        public ComboBoxStyle DropDownStyle { get; set; }
+        public int DropDownWidth { get; set; }
+        public bool DroppedDown { get; set; }
+        public FlatStyle FlatStyle { get; set; }
+        public bool IntegralHeight { get; set; }
+        public ComboBox.ObjectCollection Items { get; }
+        public int MaxDropDownItems { get; set; }
+        public int MaxLength { get; set; }
+        public int SelectedIndex { get; set; }
+        public object SelectedItem { get; set; }
+        public string SelectedText { get; set; }
+        public int SelectionLength { get; set; }
+        public int SelectionStart { get; set; }
+        public bool Sorted { get; set; }
+        public new event EventHandler DoubleClick;
+        public event EventHandler DropDown;
+        public event EventHandler DropDownClosed;
+        public event EventHandler DropDownStyleChanged;
+        public event EventHandler SelectedIndexChanged;
+        public event EventHandler TextUpdate;
+        public void BeginUpdate();
+        public void EndUpdate();
+        public int FindString(string s);
+        public int FindString(string s, int startIndex);
+        public int FindStringExact(string s);
+        public int FindStringExact(string s, int startIndex);
+        public int GetItemHeight(int index);
+        public override Size GetPreferredSize(Size constrainingSize);
+        protected virtual void OnDropDown(EventArgs e);
+        protected virtual void OnDropDownClosed(EventArgs e);
+        protected virtual void OnDropDownStyleChanged(EventArgs e);
+        protected virtual void OnSelectedIndexChanged(EventArgs e);
+        protected virtual void OnSelectionChangeCommitted(EventArgs e);
+        protected override void OnSubscribeControlEvents(Control control);
+        protected virtual void OnTextUpdate(EventArgs e);
+        protected override void OnUnsubscribeControlEvents(Control control);
+        public void Select(int start, int length);
+        public void SelectAll();
+        public override string ToString();
+    }
+    public class ToolStripContainer : ContainerControl {
+        public ToolStripContainer();
+        public override bool AutoScroll { get; set; }
+        public new Size AutoScrollMargin { get; set; }
+        public new Size AutoScrollMinSize { get; set; }
+        public new Color BackColor { get; set; }
+        public new Image BackgroundImage { get; set; }
+        public override ImageLayout BackgroundImageLayout { get; set; }
+        public ToolStripPanel BottomToolStripPanel { get; }
+        public bool BottomToolStripPanelVisible { get; set; }
+        public new bool CausesValidation { get; set; }
+        public ToolStripContentPanel ContentPanel { get; }
+        public new ContextMenuStrip ContextMenuStrip { get; set; }
+        public new Control.ControlCollection Controls { get; }
+        public override Cursor Cursor { get; set; }
+        protected override Size DefaultSize { get; }
+        public new Color ForeColor { get; set; }
+        public ToolStripPanel LeftToolStripPanel { get; }
+        public bool LeftToolStripPanelVisible { get; set; }
+        public ToolStripPanel RightToolStripPanel { get; }
+        public bool RightToolStripPanelVisible { get; set; }
+        public ToolStripPanel TopToolStripPanel { get; }
+        public bool TopToolStripPanelVisible { get; set; }
+        public new event EventHandler BackColorChanged;
+        public new event EventHandler BackgroundImageChanged;
+        public new event EventHandler BackgroundImageLayoutChanged;
+        public new event EventHandler CausesValidationChanged;
+        public new event EventHandler ContextMenuStripChanged;
+        public new event EventHandler CursorChanged;
+        public new event EventHandler ForeColorChanged;
+        protected override Control.ControlCollection CreateControlsInstance();
+        protected override void OnRightToLeftChanged(EventArgs e);
+        protected override void OnSizeChanged(EventArgs e);
+    }
+    public class ToolStripContentPanel : Panel {
+        public ToolStripContentPanel();
+        public override AnchorStyles Anchor { get; set; }
+        public override bool AutoScroll { get; set; }
+        public new Size AutoScrollMargin { get; set; }
+        public new Size AutoScrollMinSize { get; set; }
+        public override bool AutoSize { get; set; }
+        public override AutoSizeMode AutoSizeMode { get; set; }
+        public override Color BackColor { get; set; }
+        public new bool CausesValidation { get; set; }
+        public override DockStyle Dock { get; set; }
+        public new Point Location { get; set; }
+        public override Size MaximumSize { get; set; }
+        public override Size MinimumSize { get; set; }
+        public new string Name { get; set; }
+        public ToolStripRenderer Renderer { get; set; }
+        public ToolStripRenderMode RenderMode { get; set; }
+        public new int TabIndex { get; set; }
+        public new bool TabStop { get; set; }
+        public new event EventHandler AutoSizeChanged;
+        public new event EventHandler CausesValidationChanged;
+        public new event EventHandler DockChanged;
+        public event EventHandler Load;
+        public new event EventHandler LocationChanged;
+        public event EventHandler RendererChanged;
+        public new event EventHandler TabIndexChanged;
+        public new event EventHandler TabStopChanged;
+        protected override void OnHandleCreated(EventArgs e);
+        protected virtual void OnLoad(EventArgs e);
+        protected override void OnPaintBackground(PaintEventArgs e);
+        protected virtual void OnRendererChanged(EventArgs e);
+    }
+    public class ToolStripContentPanelRenderEventArgs : EventArgs {
+        public ToolStripContentPanelRenderEventArgs(Graphics g, ToolStripContentPanel contentPanel);
+        public Graphics Graphics { get; }
+        public bool Handled { get; set; }
+        public ToolStripContentPanel ToolStripContentPanel { get; }
+    }
+    public delegate void ToolStripContentPanelRenderEventHandler(object sender, ToolStripContentPanelRenderEventArgs e);
+    public class ToolStripControlHost : ToolStripItem {
+        public ToolStripControlHost(Control c);
+        public ToolStripControlHost(Control c, string name);
+        public override Color BackColor { get; set; }
+        public override Image BackgroundImage { get; set; }
+        public override ImageLayout BackgroundImageLayout { get; set; }
+        public override bool CanSelect { get; }
+        public bool CausesValidation { get; set; }
+        public Control Control { get; }
+        public ContentAlignment ControlAlign { get; set; }
+        protected override Size DefaultSize { get; }
+        public new ToolStripItemDisplayStyle DisplayStyle { get; set; }
+        public new bool DoubleClickEnabled { get; set; }
+        public override bool Enabled { get; set; }
+        public virtual bool Focused { get; }
+        public override Font Font { get; set; }
+        public override Color ForeColor { get; set; }
+        public override Image Image { get; set; }
+        public new ContentAlignment ImageAlign { get; set; }
+        public new ToolStripItemImageScaling ImageScaling { get; set; }
+        public new Color ImageTransparentColor { get; set; }
+        public override RightToLeft RightToLeft { get; set; }
+        public new bool RightToLeftAutoMirrorImage { get; set; }
+        public override bool Selected { get; }
+        public override ISite Site { get; set; }
+        public override Size Size { get; set; }
+        public override string Text { get; set; }
+        public new ContentAlignment TextAlign { get; set; }
+        public override ToolStripTextDirection TextDirection { get; set; }
+        public new TextImageRelation TextImageRelation { get; set; }
+        public new event EventHandler DisplayStyleChanged;
+        public event EventHandler Enter;
+        public event EventHandler GotFocus;
+        public event KeyEventHandler KeyDown;
+        public event KeyPressEventHandler KeyPress;
+        public event KeyEventHandler KeyUp;
+        public event EventHandler Leave;
+        public event EventHandler LostFocus;
+        public event EventHandler Validated;
+        public event CancelEventHandler Validating;
+        protected override AccessibleObject CreateAccessibilityInstance();
+        protected override void Dispose(bool disposing);
+        public void Focus();
+        public override Size GetPreferredSize(Size constrainingSize);
+        protected override void OnBoundsChanged();
+        protected virtual void OnEnter(EventArgs e);
+        protected virtual void OnGotFocus(EventArgs e);
+        protected virtual void OnHostedControlResize(EventArgs e);
+        protected virtual void OnKeyDown(KeyEventArgs e);
+        protected virtual void OnKeyPress(KeyPressEventArgs e);
+        protected virtual void OnKeyUp(KeyEventArgs e);
+        protected internal override void OnLayout(LayoutEventArgs e);
+        protected virtual void OnLeave(EventArgs e);
+        protected virtual void OnLostFocus(EventArgs e);
+        protected override void OnPaint(PaintEventArgs e);
+        protected override void OnParentChanged(ToolStrip oldParent, ToolStrip newParent);
+        protected virtual void OnSubscribeControlEvents(Control control);
+        protected virtual void OnUnsubscribeControlEvents(Control control);
+        protected virtual void OnValidated(EventArgs e);
+        protected virtual void OnValidating(CancelEventArgs e);
+        protected internal override bool ProcessCmdKey(ref Message m, Keys keyData);
+        protected internal override bool ProcessDialogKey(Keys keyData);
+        protected internal override bool ProcessMnemonic(char charCode);
+        public override void ResetBackColor();
+        public override void ResetForeColor();
+        protected override void SetVisibleCore(bool visible);
+    }
+    public class ToolStripDropDown : ToolStrip {
+        public ToolStripDropDown();
+        public new bool AllowItemReorder { get; set; }
+        public bool AllowTransparency { get; set; }
+        public override AnchorStyles Anchor { get; set; }
+        public bool AutoClose { get; set; }
+        public override bool AutoSize { get; set; }
+        public new bool CanOverflow { get; set; }
+        public new ContextMenu ContextMenu { get; set; }
+        public new ContextMenuStrip ContextMenuStrip { get; set; }
+        protected override CreateParams CreateParams { get; }
+        protected override DockStyle DefaultDock { get; }
+        public override ToolStripDropDownDirection DefaultDropDownDirection { get; set; }
+        protected override Padding DefaultPadding { get; }
+        protected override bool DefaultShowItemToolTips { get; }
+        public override DockStyle Dock { get; set; }
+        public bool DropShadowEnabled { get; set; }
+        public override Font Font { get; set; }
+        public new ToolStripGripDisplayStyle GripDisplayStyle { get; }
+        public new Padding GripMargin { get; set; }
+        public new Rectangle GripRectangle { get; }
+        public new ToolStripGripStyle GripStyle { get; set; }
+        public bool IsAutoGenerated { get; }
+        public new Point Location { get; set; }
+        protected internal override Size MaxItemSize { get; }
+        public double Opacity { get; set; }
+        public new ToolStripOverflowButton OverflowButton { get; }
+        public ToolStripItem OwnerItem { get; set; }
+        public new Region Region { get; set; }
+        public override RightToLeft RightToLeft { get; set; }
+        public new bool Stretch { get; set; }
+        public new int TabIndex { get; set; }
+        public override ToolStripTextDirection TextDirection { get; set; }
+        public bool TopLevel { get; set; }
+        protected virtual bool TopMost { get; }
+        public new bool Visible { get; set; }
+        public new event EventHandler BackgroundImageChanged;
+        public new event EventHandler BackgroundImageLayoutChanged;
+        public new event EventHandler BindingContextChanged;
+        public new event UICuesEventHandler ChangeUICues;
+        public event ToolStripDropDownClosedEventHandler Closed;
+        public event ToolStripDropDownClosingEventHandler Closing;
+        public new event EventHandler ContextMenuChanged;
+        public new event EventHandler ContextMenuStripChanged;
+        public new event EventHandler DockChanged;
+        public new event EventHandler Enter;
+        public new event EventHandler FontChanged;
+        public new event EventHandler ForeColorChanged;
+        public new event GiveFeedbackEventHandler GiveFeedback;
+        public new event HelpEventHandler HelpRequested;
+        public new event EventHandler ImeModeChanged;
+        public new event KeyEventHandler KeyDown;
+        public new event KeyPressEventHandler KeyPress;
+        public new event KeyEventHandler KeyUp;
+        public new event EventHandler Leave;
+        public event EventHandler Opened;
+        public event CancelEventHandler Opening;
+        public new event EventHandler RegionChanged;
+        public new event ScrollEventHandler Scroll;
+        public new event EventHandler StyleChanged;
+        public new event EventHandler TabIndexChanged;
+        public new event EventHandler TabStopChanged;
+        public new event EventHandler TextChanged;
+        public new event EventHandler Validated;
+        public new event CancelEventHandler Validating;
+        public void Close();
+        public void Close(ToolStripDropDownCloseReason reason);
+        protected override AccessibleObject CreateAccessibilityInstance();
+        protected override void CreateHandle();
+        protected override LayoutSettings CreateLayoutSettings(ToolStripLayoutStyle style);
+        protected override void Dispose(bool disposing);
+        protected virtual void OnClosed(ToolStripDropDownClosedEventArgs e);
+        protected virtual void OnClosing(ToolStripDropDownClosingEventArgs e);
+        protected override void OnHandleCreated(EventArgs e);
+        protected override void OnItemClicked(ToolStripItemClickedEventArgs e);
+        protected override void OnLayout(LayoutEventArgs e);
+        protected override void OnMouseUp(MouseEventArgs mea);
+        protected virtual void OnOpened(EventArgs e);
+        protected virtual void OnOpening(CancelEventArgs e);
+        protected override void OnParentChanged(EventArgs e);
+        protected override void OnVisibleChanged(EventArgs e);
+        protected override bool ProcessDialogChar(char charCode);
+        protected override bool ProcessDialogKey(Keys keyData);
+        protected internal override bool ProcessMnemonic(char charCode);
+        protected override void ScaleControl(SizeF factor, BoundsSpecified specified);
+        protected override void ScaleCore(float dx, float dy);
+        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified);
+        protected override void SetVisibleCore(bool visible);
+        public new void Show();
+        public void Show(Point screenLocation);
+        public void Show(Point position, ToolStripDropDownDirection direction);
+        public void Show(int x, int y);
+        public void Show(Control control, Point position);
+        public void Show(Control control, Point position, ToolStripDropDownDirection direction);
+        public void Show(Control control, int x, int y);
+        protected override void WndProc(ref Message m);
+        public class ToolStripDropDownAccessibleObject : ToolStrip.ToolStripAccessibleObject {
+            public ToolStripDropDownAccessibleObject(ToolStripDropDown owner);
+            public override string Name { get; set; }
+            public override AccessibleRole Role { get; }
+        }
+    }
+    public class ToolStripDropDownButton : ToolStripDropDownItem {
+        public ToolStripDropDownButton();
+        public ToolStripDropDownButton(Image image);
+        public ToolStripDropDownButton(string text);
+        public ToolStripDropDownButton(string text, Image image);
+        public ToolStripDropDownButton(string text, Image image, EventHandler onClick);
+        public ToolStripDropDownButton(string text, Image image, EventHandler onClick, string name);
+        public ToolStripDropDownButton(string text, Image image, params ToolStripItem[] dropDownItems);
+        public new bool AutoToolTip { get; set; }
+        protected override bool DefaultAutoToolTip { get; }
+        public bool ShowDropDownArrow { get; set; }
+        protected override ToolStripDropDown CreateDefaultDropDown();
+        protected override void OnMouseDown(MouseEventArgs e);
+        protected override void OnMouseLeave(EventArgs e);
+        protected override void OnMouseUp(MouseEventArgs e);
+        protected override void OnPaint(PaintEventArgs e);
+        protected internal override bool ProcessMnemonic(char charCode);
+    }
+    public class ToolStripDropDownClosedEventArgs : EventArgs {
+        public ToolStripDropDownClosedEventArgs(ToolStripDropDownCloseReason reason);
+        public ToolStripDropDownCloseReason CloseReason { get; }
+    }
+    public delegate void ToolStripDropDownClosedEventHandler(object sender, ToolStripDropDownClosedEventArgs e);
+    public enum ToolStripDropDownCloseReason {
+        AppClicked = 1,
+        AppFocusChange = 0,
+        CloseCalled = 4,
+        ItemClicked = 2,
+        Keyboard = 3,
+    }
+    public class ToolStripDropDownClosingEventArgs : CancelEventArgs {
+        public ToolStripDropDownClosingEventArgs(ToolStripDropDownCloseReason reason);
+        public ToolStripDropDownCloseReason CloseReason { get; }
+    }
+    public delegate void ToolStripDropDownClosingEventHandler(object sender, ToolStripDropDownClosingEventArgs e);
+    public enum ToolStripDropDownDirection {
+        AboveLeft = 0,
+        AboveRight = 1,
+        BelowLeft = 2,
+        BelowRight = 3,
+        Default = 7,
+        Left = 4,
+        Right = 5,
+    }
+    public abstract class ToolStripDropDownItem : ToolStripItem {
+        protected ToolStripDropDownItem();
+        protected ToolStripDropDownItem(string text, Image image, EventHandler onClick);
+        protected ToolStripDropDownItem(string text, Image image, EventHandler onClick, string name);
+        protected ToolStripDropDownItem(string text, Image image, params ToolStripItem[] dropDownItems);
+        public ToolStripDropDown DropDown { get; set; }
+        public ToolStripDropDownDirection DropDownDirection { get; set; }
+        public ToolStripItemCollection DropDownItems { get; }
+        protected internal virtual Point DropDownLocation { get; }
+        public bool HasDropDown { get; }
+        public virtual bool HasDropDownItems { get; }
+        public override bool Pressed { get; }
+        public event EventHandler DropDownClosed;
+        public event ToolStripItemClickedEventHandler DropDownItemClicked;
+        public event EventHandler DropDownOpened;
+        public event EventHandler DropDownOpening;
+        protected override AccessibleObject CreateAccessibilityInstance();
+        protected virtual ToolStripDropDown CreateDefaultDropDown();
+        protected override void Dispose(bool disposing);
+        public void HideDropDown();
+        protected override void OnBoundsChanged();
+        protected internal virtual void OnDropDownClosed(EventArgs e);
+        protected virtual void OnDropDownHide(EventArgs e);
+        protected internal virtual void OnDropDownItemClicked(ToolStripItemClickedEventArgs e);
+        protected internal virtual void OnDropDownOpened(EventArgs e);
+        protected virtual void OnDropDownShow(EventArgs e);
+        protected override void OnFontChanged(EventArgs e);
+        protected override void OnRightToLeftChanged(EventArgs e);
+        protected internal override bool ProcessCmdKey(ref Message m, Keys keyData);
+        protected internal override bool ProcessDialogKey(Keys keyData);
+        public void ShowDropDown();
+    }
+    public class ToolStripDropDownItemAccessibleObject : ToolStripItem.ToolStripItemAccessibleObject {
+        public ToolStripDropDownItemAccessibleObject(ToolStripDropDownItem item);
+        public override AccessibleRole Role { get; }
+        public override void DoDefaultAction();
+        public override AccessibleObject GetChild(int index);
+        public override int GetChildCount();
+    }
+    public class ToolStripDropDownMenu : ToolStripDropDown {
+        public ToolStripDropDownMenu();
+        protected override Padding DefaultPadding { get; }
+        public override Rectangle DisplayRectangle { get; }
+        public override LayoutEngine LayoutEngine { get; }
+        public new ToolStripLayoutStyle LayoutStyle { get; set; }
+        protected internal override Size MaxItemSize { get; }
+        public bool ShowCheckMargin { get; set; }
+        public bool ShowImageMargin { get; set; }
+        protected internal override ToolStripItem CreateDefaultItem(string text, Image image, EventHandler onClick);
+        protected override void OnFontChanged(EventArgs e);
+        protected override void OnLayout(LayoutEventArgs e);
+        protected override void OnPaintBackground(PaintEventArgs e);
+        protected override void SetDisplayedItems();
+    }
+    public enum ToolStripGripDisplayStyle {
+        Horizontal = 0,
+        Vertical = 1,
+    }
+    public class ToolStripGripRenderEventArgs : ToolStripRenderEventArgs {
+        public ToolStripGripRenderEventArgs(Graphics g, ToolStrip toolStrip);
+        public Rectangle GripBounds { get; }
+        public ToolStripGripDisplayStyle GripDisplayStyle { get; }
+        public ToolStripGripStyle GripStyle { get; }
+    }
+    public delegate void ToolStripGripRenderEventHandler(object sender, ToolStripGripRenderEventArgs e);
+    public enum ToolStripGripStyle {
+        Hidden = 0,
+        Visible = 1,
+    }
+    public abstract class ToolStripItem : Component, IArrangedElement, IComponent, IDisposable, IDropTarget {
+        protected ToolStripItem();
+        protected ToolStripItem(string text, Image image, EventHandler onClick);
+        protected ToolStripItem(string text, Image image, EventHandler onClick, string name);
+        public AccessibleObject AccessibilityObject { get; }
+        public string AccessibleDefaultActionDescription { get; set; }
+        public string AccessibleDescription { get; set; }
+        public string AccessibleName { get; set; }
+        public AccessibleRole AccessibleRole { get; set; }
+        public ToolStripItemAlignment Alignment { get; set; }
+        public virtual bool AllowDrop { get; set; }
+        public AnchorStyles Anchor { get; set; }
+        public bool AutoSize { get; set; }
+        public bool AutoToolTip { get; set; }
+        public bool Available { get; set; }
+        public virtual Color BackColor { get; set; }
+        public virtual Image BackgroundImage { get; set; }
+        public virtual ImageLayout BackgroundImageLayout { get; set; }
+        public virtual Rectangle Bounds { get; }
+        public virtual bool CanSelect { get; }
+        public Rectangle ContentRectangle { get; }
+        protected virtual bool DefaultAutoToolTip { get; }
+        protected virtual ToolStripItemDisplayStyle DefaultDisplayStyle { get; }
+        protected internal virtual Padding DefaultMargin { get; }
+        protected virtual Padding DefaultPadding { get; }
+        protected virtual Size DefaultSize { get; }
+        protected internal virtual bool DismissWhenClicked { get; }
+        public virtual ToolStripItemDisplayStyle DisplayStyle { get; set; }
+        public DockStyle Dock { get; set; }
+        public bool DoubleClickEnabled { get; set; }
+        public virtual bool Enabled { get; set; }
+        public virtual Font Font { get; set; }
+        public virtual Color ForeColor { get; set; }
+        public int Height { get; set; }
+        public virtual Image Image { get; set; }
+        public ContentAlignment ImageAlign { get; set; }
+        public int ImageIndex { get; set; }
+        public string ImageKey { get; set; }
+        public ToolStripItemImageScaling ImageScaling { get; set; }
+        public Color ImageTransparentColor { get; set; }
+        public bool IsDisposed { get; }
+        public bool IsOnDropDown { get; }
+        public bool IsOnOverflow { get; }
+        public Padding Margin { get; set; }
+        public MergeAction MergeAction { get; set; }
+        public int MergeIndex { get; set; }
+        public string Name { get; set; }
+        public ToolStripItemOverflow Overflow { get; set; }
+        public ToolStrip Owner { get; set; }
+        public ToolStripItem OwnerItem { get; }
+        public virtual Padding Padding { get; set; }
+        protected internal ToolStrip Parent { get; set; }
+        public ToolStripItemPlacement Placement { get; }
+        public virtual bool Pressed { get; }
+        public virtual RightToLeft RightToLeft { get; set; }
+        public bool RightToLeftAutoMirrorImage { get; set; }
+        public virtual bool Selected { get; }
+        protected internal virtual bool ShowKeyboardCues { get; }
+        public virtual Size Size { get; set; }
+        public object Tag { get; set; }
+        public virtual string Text { get; set; }
+        public virtual ContentAlignment TextAlign { get; set; }
+        public virtual ToolStripTextDirection TextDirection { get; set; }
+        public TextImageRelation TextImageRelation { get; set; }
+        public string ToolTipText { get; set; }
+        public bool Visible { get; set; }
+        public int Width { get; set; }
+        public event EventHandler AvailableChanged;
+        public event EventHandler BackColorChanged;
+        public event EventHandler Click;
+        public event EventHandler DisplayStyleChanged;
+        public event EventHandler DoubleClick;
+        public event DragEventHandler DragDrop;
+        public event DragEventHandler DragEnter;
+        public event EventHandler DragLeave;
+        public event DragEventHandler DragOver;
+        public event EventHandler EnabledChanged;
+        public event EventHandler ForeColorChanged;
+        public event GiveFeedbackEventHandler GiveFeedback;
+        public event EventHandler LocationChanged;
+        public event MouseEventHandler MouseDown;
+        public event EventHandler MouseEnter;
+        public event EventHandler MouseHover;
+        public event EventHandler MouseLeave;
+        public event MouseEventHandler MouseMove;
+        public event MouseEventHandler MouseUp;
+        public event EventHandler OwnerChanged;
+        public event PaintEventHandler Paint;
+        public event QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
+        public event QueryContinueDragEventHandler QueryContinueDrag;
+        public event EventHandler RightToLeftChanged;
+        public event EventHandler TextChanged;
+        public event EventHandler VisibleChanged;
+        protected virtual AccessibleObject CreateAccessibilityInstance();
+        protected override void Dispose(bool disposing);
+        public DragDropEffects DoDragDrop(object data, DragDropEffects allowedEffects);
+        public ToolStrip GetCurrentParent();
+        public virtual Size GetPreferredSize(Size constrainingSize);
+        public void Invalidate();
+        public void Invalidate(Rectangle r);
+        protected internal virtual bool IsInputChar(char charCode);
+        protected internal virtual bool IsInputKey(Keys keyData);
+        protected virtual void OnAvailableChanged(EventArgs e);
+        protected virtual void OnBackColorChanged(EventArgs e);
+        protected virtual void OnBoundsChanged();
+        protected virtual void OnClick(EventArgs e);
+        protected virtual void OnDisplayStyleChanged(EventArgs e);
+        protected virtual void OnDoubleClick(EventArgs e);
+        protected virtual void OnDragDrop(DragEventArgs dragEvent);
+        protected virtual void OnDragEnter(DragEventArgs dragEvent);
+        protected virtual void OnDragLeave(EventArgs e);
+        protected virtual void OnDragOver(DragEventArgs dragEvent);
+        protected virtual void OnEnabledChanged(EventArgs e);
+        protected virtual void OnFontChanged(EventArgs e);
+        protected virtual void OnForeColorChanged(EventArgs e);
+        protected virtual void OnGiveFeedback(GiveFeedbackEventArgs giveFeedbackEvent);
+        protected internal virtual void OnLayout(LayoutEventArgs e);
+        protected virtual void OnLocationChanged(EventArgs e);
+        protected virtual void OnMouseDown(MouseEventArgs e);
+        protected virtual void OnMouseEnter(EventArgs e);
+        protected virtual void OnMouseHover(EventArgs e);
+        protected virtual void OnMouseLeave(EventArgs e);
+        protected virtual void OnMouseMove(MouseEventArgs mea);
+        protected virtual void OnMouseUp(MouseEventArgs e);
+        protected virtual void OnOwnerChanged(EventArgs e);
+        protected internal virtual void OnOwnerFontChanged(EventArgs e);
+        protected virtual void OnPaint(PaintEventArgs e);
+        protected virtual void OnParentBackColorChanged(EventArgs e);
+        protected virtual void OnParentChanged(ToolStrip oldParent, ToolStrip newParent);
+        protected internal virtual void OnParentEnabledChanged(EventArgs e);
+        protected virtual void OnParentForeColorChanged(EventArgs e);
+        protected internal virtual void OnParentRightToLeftChanged(EventArgs e);
+        protected virtual void OnQueryContinueDrag(QueryContinueDragEventArgs queryContinueDragEvent);
+        protected virtual void OnRightToLeftChanged(EventArgs e);
+        protected virtual void OnTextChanged(EventArgs e);
+        protected virtual void OnVisibleChanged(EventArgs e);
+        public void PerformClick();
+        protected internal virtual bool ProcessCmdKey(ref Message m, Keys keyData);
+        protected internal virtual bool ProcessDialogKey(Keys keyData);
+        protected internal virtual bool ProcessMnemonic(char charCode);
+        public virtual void ResetBackColor();
+        public virtual void ResetDisplayStyle();
+        public virtual void ResetFont();
+        public virtual void ResetForeColor();
+        public virtual void ResetImage();
+        public void ResetMargin();
+        public void ResetPadding();
+        public virtual void ResetRightToLeft();
+        public virtual void ResetTextDirection();
+        public void Select();
+        protected internal virtual void SetBounds(Rectangle bounds);
+        protected virtual void SetVisibleCore(bool visible);
+        void System.Windows.Forms.IDropTarget.OnDragDrop(DragEventArgs dragEvent);
+        void System.Windows.Forms.IDropTarget.OnDragEnter(DragEventArgs dragEvent);
+        void System.Windows.Forms.IDropTarget.OnDragLeave(EventArgs e);
+        void System.Windows.Forms.IDropTarget.OnDragOver(DragEventArgs dragEvent);
+        public override string ToString();
+        public class ToolStripItemAccessibleObject : AccessibleObject {
+            public ToolStripItemAccessibleObject(ToolStripItem ownerItem);
+            public override Rectangle Bounds { get; }
+            public override string DefaultAction { get; }
+            public override string Description { get; }
+            public override string Help { get; }
+            public override string KeyboardShortcut { get; }
+            public override string Name { get; set; }
+            public override AccessibleObject Parent { get; }
+            public override AccessibleRole Role { get; }
+            public override AccessibleStates State { get; }
+            public void AddState(AccessibleStates state);
+            public override void DoDefaultAction();
+            public override int GetHelpTopic(out string fileName);
+            public override AccessibleObject Navigate(AccessibleNavigation navigationDirection);
+            public override string ToString();
+        }
+    }
+    public enum ToolStripItemAlignment {
+        Left = 0,
+        Right = 1,
+    }
+    public class ToolStripItemClickedEventArgs : EventArgs {
+        public ToolStripItemClickedEventArgs(ToolStripItem clickedItem);
+        public ToolStripItem ClickedItem { get; }
+    }
+    public delegate void ToolStripItemClickedEventHandler(object sender, ToolStripItemClickedEventArgs e);
+    public class ToolStripItemCollection : ArrangedElementCollection, ICollection, IEnumerable, IList {
+        public ToolStripItemCollection(ToolStrip owner, ToolStripItem[] value);
+        public override bool IsReadOnly { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public virtual new ToolStripItem this[int index] { get; }
+        public virtual ToolStripItem this[string key] { get; }
+        public ToolStripItem Add(Image image);
+        public ToolStripItem Add(string text);
+        public ToolStripItem Add(string text, Image image);
+        public ToolStripItem Add(string text, Image image, EventHandler onClick);
+        public int Add(ToolStripItem value);
+        public void AddRange(ToolStripItemCollection toolStripItems);
+        public void AddRange(ToolStripItem[] toolStripItems);
+        public virtual void Clear();
+        public bool Contains(ToolStripItem value);
+        public virtual bool ContainsKey(string key);
+        public void CopyTo(ToolStripItem[] array, int index);
+        public ToolStripItem[] Find(string key, bool searchAllChildren);
+        public int IndexOf(ToolStripItem value);
+        public virtual int IndexOfKey(string key);
+        public void Insert(int index, ToolStripItem value);
+        public void Remove(ToolStripItem value);
+        public void RemoveAt(int index);
+        public virtual void RemoveByKey(string key);
+        int System.Collections.IList.Add(object value);
+        void System.Collections.IList.Clear();
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        void System.Collections.IList.RemoveAt(int index);
+    }
+    public enum ToolStripItemDisplayStyle {
+        Image = 2,
+        ImageAndText = 3,
+        None = 0,
+        Text = 1,
+    }
+    public class ToolStripItemEventArgs : EventArgs {
+        public ToolStripItemEventArgs(ToolStripItem item);
+        public ToolStripItem Item { get; }
+    }
+    public delegate void ToolStripItemEventHandler(object sender, ToolStripItemEventArgs e);
+    public class ToolStripItemImageRenderEventArgs : ToolStripItemRenderEventArgs {
+        public ToolStripItemImageRenderEventArgs(Graphics g, ToolStripItem item, Image image, Rectangle imageRectangle);
+        public ToolStripItemImageRenderEventArgs(Graphics g, ToolStripItem item, Rectangle imageRectangle);
+        public Image Image { get; }
+        public Rectangle ImageRectangle { get; }
+    }
+    public delegate void ToolStripItemImageRenderEventHandler(object sender, ToolStripItemImageRenderEventArgs e);
+    public enum ToolStripItemImageScaling {
+        None = 0,
+        SizeToFit = 1,
+    }
+    public enum ToolStripItemOverflow {
+        Always = 1,
+        AsNeeded = 2,
+        Never = 0,
+    }
+    public enum ToolStripItemPlacement {
+        Main = 0,
+        None = 2,
+        Overflow = 1,
+    }
+    public class ToolStripItemRenderEventArgs : EventArgs {
+        public ToolStripItemRenderEventArgs(Graphics g, ToolStripItem item);
+        public Graphics Graphics { get; }
+        public ToolStripItem Item { get; }
+        public ToolStrip ToolStrip { get; }
+    }
+    public delegate void ToolStripItemRenderEventHandler(object sender, ToolStripItemRenderEventArgs e);
+    public class ToolStripItemTextRenderEventArgs : ToolStripItemRenderEventArgs {
+        public ToolStripItemTextRenderEventArgs(Graphics g, ToolStripItem item, string text, Rectangle textRectangle, Color textColor, Font textFont, ContentAlignment textAlign);
+        public ToolStripItemTextRenderEventArgs(Graphics g, ToolStripItem item, string text, Rectangle textRectangle, Color textColor, Font textFont, TextFormatFlags format);
+        public string Text { get; set; }
+        public Color TextColor { get; set; }
+        public ToolStripTextDirection TextDirection { get; set; }
+        public Font TextFont { get; set; }
+        public TextFormatFlags TextFormat { get; set; }
+        public Rectangle TextRectangle { get; set; }
+    }
+    public delegate void ToolStripItemTextRenderEventHandler(object sender, ToolStripItemTextRenderEventArgs e);
+    public class ToolStripLabel : ToolStripItem {
+        public ToolStripLabel();
+        public ToolStripLabel(Image image);
+        public ToolStripLabel(string text);
+        public ToolStripLabel(string text, Image image);
+        public ToolStripLabel(string text, Image image, bool isLink);
+        public ToolStripLabel(string text, Image image, bool isLink, EventHandler onClick);
+        public ToolStripLabel(string text, Image image, bool isLink, EventHandler onClick, string name);
+        public Color ActiveLinkColor { get; set; }
+        public override bool CanSelect { get; }
+        public bool IsLink { get; set; }
+        public LinkBehavior LinkBehavior { get; set; }
+        public Color LinkColor { get; set; }
+        public bool LinkVisited { get; set; }
+        public Color VisitedLinkColor { get; set; }
+        protected override AccessibleObject CreateAccessibilityInstance();
+        protected override void OnFontChanged(EventArgs e);
+        protected override void OnMouseEnter(EventArgs e);
+        protected override void OnMouseLeave(EventArgs e);
+        protected override void OnPaint(PaintEventArgs e);
+        protected internal override bool ProcessMnemonic(char charCode);
+    }
+    public enum ToolStripLayoutStyle {
+        Flow = 3,
+        HorizontalStackWithOverflow = 1,
+        StackWithOverflow = 0,
+        Table = 4,
+        VerticalStackWithOverflow = 2,
+    }
+    public sealed class ToolStripManager {
+        public static ToolStripRenderer Renderer { get; set; }
+        public static ToolStripManagerRenderMode RenderMode { get; set; }
+        public static bool VisualStylesEnabled { get; set; }
+        public static event EventHandler RendererChanged;
+        public static ToolStrip FindToolStrip(string toolStripName);
+        public static bool IsShortcutDefined(Keys shortcut);
+        public static bool IsValidShortcut(Keys shortcut);
+        public static void LoadSettings(Form targetForm);
+        public static void LoadSettings(Form targetForm, string key);
+        public static bool Merge(ToolStrip sourceToolStrip, string targetName);
+        public static bool Merge(ToolStrip sourceToolStrip, ToolStrip targetToolStrip);
+        public static bool RevertMerge(string targetName);
+        public static bool RevertMerge(ToolStrip targetToolStrip);
+        public static bool RevertMerge(ToolStrip targetToolStrip, ToolStrip sourceToolStrip);
+        public static void SaveSettings(Form sourceForm);
+        public static void SaveSettings(Form sourceForm, string key);
+    }
+    public enum ToolStripManagerRenderMode {
+        Custom = 0,
+        Professional = 2,
+        System = 1,
+    }
+    public class ToolStripMenuItem : ToolStripDropDownItem {
+        public ToolStripMenuItem();
+        public ToolStripMenuItem(Image image);
+        public ToolStripMenuItem(string text);
+        public ToolStripMenuItem(string text, Image image);
+        public ToolStripMenuItem(string text, Image image, EventHandler onClick);
+        public ToolStripMenuItem(string text, Image image, EventHandler onClick, string name);
+        public ToolStripMenuItem(string text, Image image, EventHandler onClick, Keys shortcutKeys);
+        public ToolStripMenuItem(string text, Image image, params ToolStripItem[] dropDownItems);
+        public bool Checked { get; set; }
+        public bool CheckOnClick { get; set; }
+        public CheckState CheckState { get; set; }
+        protected internal override Padding DefaultMargin { get; }
+        protected override Padding DefaultPadding { get; }
+        protected override Size DefaultSize { get; }
+        public override bool Enabled { get; set; }
+        public bool IsMdiWindowListEntry { get; }
+        public new ToolStripItemOverflow Overflow { get; set; }
+        public string ShortcutKeyDisplayString { get; set; }
+        public Keys ShortcutKeys { get; set; }
+        public bool ShowShortcutKeys { get; set; }
+        public event EventHandler CheckedChanged;
+        public event EventHandler CheckStateChanged;
+        protected override AccessibleObject CreateAccessibilityInstance();
+        protected override ToolStripDropDown CreateDefaultDropDown();
+        protected override void Dispose(bool disposing);
+        protected virtual void OnCheckedChanged(EventArgs e);
+        protected virtual void OnCheckStateChanged(EventArgs e);
+        protected override void OnClick(EventArgs e);
+        protected override void OnDropDownHide(EventArgs e);
+        protected override void OnDropDownShow(EventArgs e);
+        protected override void OnFontChanged(EventArgs e);
+        protected override void OnMouseDown(MouseEventArgs e);
+        protected override void OnMouseEnter(EventArgs e);
+        protected override void OnMouseLeave(EventArgs e);
+        protected override void OnMouseUp(MouseEventArgs e);
+        protected override void OnOwnerChanged(EventArgs e);
+        protected override void OnPaint(PaintEventArgs e);
+        protected internal override bool ProcessCmdKey(ref Message m, Keys keyData);
+        protected internal override bool ProcessMnemonic(char charCode);
+        protected internal override void SetBounds(Rectangle rect);
+    }
+    public class ToolStripOverflow : ToolStripDropDown, IArrangedElement, IComponent, IDisposable {
+        public ToolStripOverflow(ToolStripItem parentItem);
+        protected internal override ToolStripItemCollection DisplayedItems { get; }
+        public override ToolStripItemCollection Items { get; }
+        public override LayoutEngine LayoutEngine { get; }
+        protected override AccessibleObject CreateAccessibilityInstance();
+        public override Size GetPreferredSize(Size constrainingSize);
+        protected override void OnLayout(LayoutEventArgs e);
+        protected override void SetDisplayedItems();
+    }
+    public class ToolStripOverflowButton : ToolStripDropDownButton {
+        protected internal override Padding DefaultMargin { get; }
+        public override bool HasDropDownItems { get; }
+        public new bool RightToLeftAutoMirrorImage { get; set; }
+        protected override AccessibleObject CreateAccessibilityInstance();
+        protected override ToolStripDropDown CreateDefaultDropDown();
+        protected override void Dispose(bool disposing);
+        public override Size GetPreferredSize(Size constrainingSize);
+        protected override void OnPaint(PaintEventArgs e);
+        protected internal override void SetBounds(Rectangle bounds);
+    }
+    public class ToolStripPanel : ContainerControl, IArrangedElement, IComponent, IDisposable {
+        public ToolStripPanel();
+        public override bool AllowDrop { get; set; }
+        public override bool AutoScroll { get; set; }
+        public new Size AutoScrollMargin { get; set; }
+        public new Size AutoScrollMinSize { get; set; }
+        public override bool AutoSize { get; set; }
+        protected override Padding DefaultMargin { get; }
+        protected override Padding DefaultPadding { get; }
+        public override DockStyle Dock { get; set; }
+        public override LayoutEngine LayoutEngine { get; }
+        public bool Locked { get; set; }
+        public Orientation Orientation { get; set; }
+        public ToolStripRenderer Renderer { get; set; }
+        public ToolStripRenderMode RenderMode { get; set; }
+        public Padding RowMargin { get; set; }
+        public ToolStripPanelRow[] Rows { get; }
+        public new int TabIndex { get; set; }
+        public new bool TabStop { get; set; }
+        public override string Text { get; set; }
+        public new event EventHandler AutoSizeChanged;
+        public event EventHandler RendererChanged;
+        public new event EventHandler TabIndexChanged;
+        public new event EventHandler TabStopChanged;
+        public new event EventHandler TextChanged;
+        public void BeginInit();
+        protected override Control.ControlCollection CreateControlsInstance();
+        protected override void Dispose(bool disposing);
+        public void EndInit();
+        public void Join(ToolStrip toolStripToDrag);
+        public void Join(ToolStrip toolStripToDrag, Point location);
+        public void Join(ToolStrip toolStripToDrag, int row);
+        public void Join(ToolStrip toolStripToDrag, int x, int y);
+        protected override void OnControlAdded(ControlEventArgs e);
+        protected override void OnControlRemoved(ControlEventArgs e);
+        protected override void OnDockChanged(EventArgs e);
+        protected override void OnLayout(LayoutEventArgs e);
+        protected override void OnPaintBackground(PaintEventArgs e);
+        protected override void OnParentChanged(EventArgs e);
+        protected virtual void OnRendererChanged(EventArgs e);
+        protected override void OnRightToLeftChanged(EventArgs e);
+        public ToolStripPanelRow PointToRow(Point clientLocation);
+        public class ToolStripPanelRowCollection : ArrangedElementCollection, ICollection, IEnumerable, IList {
+            public ToolStripPanelRowCollection(ToolStripPanel owner);
+            public ToolStripPanelRowCollection(ToolStripPanel owner, ToolStripPanelRow[] value);
+            bool System.Collections.IList.IsFixedSize { get; }
+            bool System.Collections.IList.IsReadOnly { get; }
+            object System.Collections.IList.this[int index] { get; set; }
+            public virtual new ToolStripPanelRow this[int index] { get; }
+            public int Add(ToolStripPanelRow value);
+            public void AddRange(ToolStripPanelRow[] value);
+            public void AddRange(ToolStripPanel.ToolStripPanelRowCollection value);
+            public virtual void Clear();
+            public bool Contains(ToolStripPanelRow value);
+            public void CopyTo(ToolStripPanelRow[] array, int index);
+            public int IndexOf(ToolStripPanelRow value);
+            public void Insert(int index, ToolStripPanelRow value);
+            public void Remove(ToolStripPanelRow value);
+            public void RemoveAt(int index);
+            int System.Collections.IList.Add(object value);
+            void System.Collections.IList.Clear();
+            bool System.Collections.IList.Contains(object value);
+            int System.Collections.IList.IndexOf(object value);
+            void System.Collections.IList.Insert(int index, object value);
+            void System.Collections.IList.Remove(object value);
+            void System.Collections.IList.RemoveAt(int index);
+        }
+    }
+    public class ToolStripPanelRenderEventArgs : EventArgs {
+        public ToolStripPanelRenderEventArgs(Graphics g, ToolStripPanel toolStripPanel);
+        public Graphics Graphics { get; }
+        public bool Handled { get; set; }
+        public ToolStripPanel ToolStripPanel { get; }
+    }
+    public delegate void ToolStripPanelRenderEventHandler(object sender, ToolStripPanelRenderEventArgs e);
+    public class ToolStripPanelRow : Component, IArrangedElement, IComponent, IDisposable {
+        public ToolStripPanelRow(ToolStripPanel parent);
+        public Rectangle Bounds { get; }
+        public Control[] Controls { get; }
+        protected virtual Padding DefaultMargin { get; }
+        protected virtual Padding DefaultPadding { get; }
+        public Rectangle DisplayRectangle { get; }
+        public LayoutEngine LayoutEngine { get; }
+        public Padding Margin { get; set; }
+        public Orientation Orientation { get; }
+        public virtual Padding Padding { get; set; }
+        public ToolStripPanel ToolStripPanel { get; }
+        public bool CanMove(ToolStrip toolStripToDrag);
+        protected override void Dispose(bool disposing);
+        protected void OnBoundsChanged(Rectangle oldBounds, Rectangle newBounds);
+        protected internal virtual void OnControlAdded(Control control, int index);
+        protected internal virtual void OnControlRemoved(Control control, int index);
+        protected virtual void OnLayout(LayoutEventArgs e);
+        protected internal virtual void OnOrientationChanged();
+    }
+    public class ToolStripProfessionalRenderer : ToolStripRenderer {
+        public ToolStripProfessionalRenderer();
+        public ToolStripProfessionalRenderer(ProfessionalColorTable professionalColorTable);
+        public ProfessionalColorTable ColorTable { get; }
+        public bool RoundedEdges { get; set; }
+        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e);
+        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e);
+        protected override void OnRenderDropDownButtonBackground(ToolStripItemRenderEventArgs e);
+        protected override void OnRenderGrip(ToolStripGripRenderEventArgs e);
+        protected override void OnRenderImageMargin(ToolStripRenderEventArgs e);
+        protected override void OnRenderItemCheck(ToolStripItemImageRenderEventArgs e);
+        protected override void OnRenderItemImage(ToolStripItemImageRenderEventArgs e);
+        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e);
+        protected override void OnRenderLabelBackground(ToolStripItemRenderEventArgs e);
+        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e);
+        protected override void OnRenderOverflowButtonBackground(ToolStripItemRenderEventArgs e);
+        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e);
+        protected override void OnRenderSplitButtonBackground(ToolStripItemRenderEventArgs e);
+        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e);
+        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e);
+        protected override void OnRenderToolStripContentPanelBackground(ToolStripContentPanelRenderEventArgs e);
+        protected override void OnRenderToolStripPanelBackground(ToolStripPanelRenderEventArgs e);
+        protected override void OnRenderToolStripStatusLabelBackground(ToolStripItemRenderEventArgs e);
+    }
+    public class ToolStripProgressBar : ToolStripControlHost {
+        public ToolStripProgressBar();
+        public ToolStripProgressBar(string name);
+        public override Image BackgroundImage { get; set; }
+        public override ImageLayout BackgroundImageLayout { get; set; }
+        protected internal override Padding DefaultMargin { get; }
+        protected override Size DefaultSize { get; }
+        public int MarqueeAnimationSpeed { get; set; }
+        public int Maximum { get; set; }
+        public int Minimum { get; set; }
+        public ProgressBar ProgressBar { get; }
+        public virtual bool RightToLeftLayout { get; set; }
+        public int Step { get; set; }
+        public ProgressBarStyle Style { get; set; }
+        public override string Text { get; set; }
+        public int Value { get; set; }
+        public new event KeyEventHandler KeyDown;
+        public new event KeyPressEventHandler KeyPress;
+        public new event KeyEventHandler KeyUp;
+        public new event EventHandler LocationChanged;
+        public new event EventHandler OwnerChanged;
+        public event EventHandler RightToLeftLayoutChanged;
+        public new event EventHandler TextChanged;
+        public new event EventHandler Validated;
+        public new event CancelEventHandler Validating;
+        public void Increment(int value);
+        protected virtual void OnRightToLeftLayoutChanged(EventArgs e);
+        protected override void OnSubscribeControlEvents(Control control);
+        protected override void OnUnsubscribeControlEvents(Control control);
+        public void PerformStep();
+    }
+    public abstract class ToolStripRenderer {
+        protected static int Offset2X;
+        protected static int Offset2Y;
+        protected ToolStripRenderer();
+        public event ToolStripArrowRenderEventHandler RenderArrow;
+        public event ToolStripItemRenderEventHandler RenderButtonBackground;
+        public event ToolStripItemRenderEventHandler RenderDropDownButtonBackground;
+        public event ToolStripGripRenderEventHandler RenderGrip;
+        public event ToolStripRenderEventHandler RenderImageMargin;
+        public event ToolStripItemRenderEventHandler RenderItemBackground;
+        public event ToolStripItemImageRenderEventHandler RenderItemCheck;
+        public event ToolStripItemImageRenderEventHandler RenderItemImage;
+        public event ToolStripItemTextRenderEventHandler RenderItemText;
+        public event ToolStripItemRenderEventHandler RenderLabelBackground;
+        public event ToolStripItemRenderEventHandler RenderMenuItemBackground;
+        public event ToolStripItemRenderEventHandler RenderOverflowButtonBackground;
+        public event ToolStripSeparatorRenderEventHandler RenderSeparator;
+        public event ToolStripItemRenderEventHandler RenderSplitButtonBackground;
+        public event ToolStripRenderEventHandler RenderStatusStripSizingGrip;
+        public event ToolStripRenderEventHandler RenderToolStripBackground;
+        public event ToolStripRenderEventHandler RenderToolStripBorder;
+        public event ToolStripContentPanelRenderEventHandler RenderToolStripContentPanelBackground;
+        public event ToolStripPanelRenderEventHandler RenderToolStripPanelBackground;
+        public event ToolStripItemRenderEventHandler RenderToolStripStatusLabelBackground;
+        public static Image CreateDisabledImage(Image normalImage);
+        public void DrawArrow(ToolStripArrowRenderEventArgs e);
+        public void DrawButtonBackground(ToolStripItemRenderEventArgs e);
+        public void DrawDropDownButtonBackground(ToolStripItemRenderEventArgs e);
+        public void DrawGrip(ToolStripGripRenderEventArgs e);
+        public void DrawImageMargin(ToolStripRenderEventArgs e);
+        public void DrawItemBackground(ToolStripItemRenderEventArgs e);
+        public void DrawItemCheck(ToolStripItemImageRenderEventArgs e);
+        public void DrawItemImage(ToolStripItemImageRenderEventArgs e);
+        public void DrawItemText(ToolStripItemTextRenderEventArgs e);
+        public void DrawLabelBackground(ToolStripItemRenderEventArgs e);
+        public void DrawMenuItemBackground(ToolStripItemRenderEventArgs e);
+        public void DrawOverflowButtonBackground(ToolStripItemRenderEventArgs e);
+        public void DrawSeparator(ToolStripSeparatorRenderEventArgs e);
+        public void DrawSplitButton(ToolStripItemRenderEventArgs e);
+        public void DrawStatusStripSizingGrip(ToolStripRenderEventArgs e);
+        public void DrawToolStripBackground(ToolStripRenderEventArgs e);
+        public void DrawToolStripBorder(ToolStripRenderEventArgs e);
+        public void DrawToolStripContentPanelBackground(ToolStripContentPanelRenderEventArgs e);
+        public void DrawToolStripPanelBackground(ToolStripPanelRenderEventArgs e);
+        public void DrawToolStripStatusLabelBackground(ToolStripItemRenderEventArgs e);
+        protected internal virtual void Initialize(ToolStrip toolStrip);
+        protected internal virtual void InitializeContentPanel(ToolStripContentPanel contentPanel);
+        protected internal virtual void InitializeItem(ToolStripItem item);
+        protected internal virtual void InitializePanel(ToolStripPanel toolStripPanel);
+        protected virtual void OnRenderArrow(ToolStripArrowRenderEventArgs e);
+        protected virtual void OnRenderButtonBackground(ToolStripItemRenderEventArgs e);
+        protected virtual void OnRenderDropDownButtonBackground(ToolStripItemRenderEventArgs e);
+        protected virtual void OnRenderGrip(ToolStripGripRenderEventArgs e);
+        protected virtual void OnRenderImageMargin(ToolStripRenderEventArgs e);
+        protected virtual void OnRenderItemBackground(ToolStripItemRenderEventArgs e);
+        protected virtual void OnRenderItemCheck(ToolStripItemImageRenderEventArgs e);
+        protected virtual void OnRenderItemImage(ToolStripItemImageRenderEventArgs e);
+        protected virtual void OnRenderItemText(ToolStripItemTextRenderEventArgs e);
+        protected virtual void OnRenderLabelBackground(ToolStripItemRenderEventArgs e);
+        protected virtual void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e);
+        protected virtual void OnRenderOverflowButtonBackground(ToolStripItemRenderEventArgs e);
+        protected virtual void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e);
+        protected virtual void OnRenderSplitButtonBackground(ToolStripItemRenderEventArgs e);
+        protected virtual void OnRenderStatusStripSizingGrip(ToolStripRenderEventArgs e);
+        protected virtual void OnRenderToolStripBackground(ToolStripRenderEventArgs e);
+        protected virtual void OnRenderToolStripBorder(ToolStripRenderEventArgs e);
+        protected virtual void OnRenderToolStripContentPanelBackground(ToolStripContentPanelRenderEventArgs e);
+        protected virtual void OnRenderToolStripPanelBackground(ToolStripPanelRenderEventArgs e);
+        protected virtual void OnRenderToolStripStatusLabelBackground(ToolStripItemRenderEventArgs e);
+        protected static void ScaleArrowOffsetsIfNeeded();
+    }
+    public class ToolStripRenderEventArgs : EventArgs {
+        public ToolStripRenderEventArgs(Graphics g, ToolStrip toolStrip);
+        public ToolStripRenderEventArgs(Graphics g, ToolStrip toolStrip, Rectangle affectedBounds, Color backColor);
+        public Rectangle AffectedBounds { get; }
+        public Color BackColor { get; }
+        public Rectangle ConnectedArea { get; }
+        public Graphics Graphics { get; }
+        public ToolStrip ToolStrip { get; }
+    }
+    public delegate void ToolStripRenderEventHandler(object sender, ToolStripRenderEventArgs e);
+    public enum ToolStripRenderMode {
+        Custom = 0,
+        ManagerRenderMode = 3,
+        Professional = 2,
+        System = 1,
+    }
+    public class ToolStripSeparator : ToolStripItem {
+        public ToolStripSeparator();
+        public new bool AutoToolTip { get; set; }
+        public override Image BackgroundImage { get; set; }
+        public override ImageLayout BackgroundImageLayout { get; set; }
+        public override bool CanSelect { get; }
+        protected internal override Padding DefaultMargin { get; }
+        protected override Size DefaultSize { get; }
+        public new ToolStripItemDisplayStyle DisplayStyle { get; set; }
+        public new bool DoubleClickEnabled { get; set; }
+        public override bool Enabled { get; set; }
+        public override Font Font { get; set; }
+        public override Image Image { get; set; }
+        public new ContentAlignment ImageAlign { get; set; }
+        public new int ImageIndex { get; set; }
+        public new string ImageKey { get; set; }
+        public new ToolStripItemImageScaling ImageScaling { get; set; }
+        public new Color ImageTransparentColor { get; set; }
+        public new bool RightToLeftAutoMirrorImage { get; set; }
+        public override string Text { get; set; }
+        public new ContentAlignment TextAlign { get; set; }
+        public override ToolStripTextDirection TextDirection { get; set; }
+        public new TextImageRelation TextImageRelation { get; set; }
+        public new string ToolTipText { get; set; }
+        public new event EventHandler DisplayStyleChanged;
+        public new event EventHandler EnabledChanged;
+        public new event EventHandler TextChanged;
+        protected override AccessibleObject CreateAccessibilityInstance();
+        public override Size GetPreferredSize(Size constrainingSize);
+        protected override void OnFontChanged(EventArgs e);
+        protected override void OnPaint(PaintEventArgs e);
+        protected internal override void SetBounds(Rectangle rect);
+    }
+    public class ToolStripSeparatorRenderEventArgs : ToolStripItemRenderEventArgs {
+        public ToolStripSeparatorRenderEventArgs(Graphics g, ToolStripSeparator separator, bool vertical);
+        public bool Vertical { get; }
+    }
+    public delegate void ToolStripSeparatorRenderEventHandler(object sender, ToolStripSeparatorRenderEventArgs e);
+    public class ToolStripSplitButton : ToolStripDropDownItem {
+        public ToolStripSplitButton();
+        public ToolStripSplitButton(Image image);
+        public ToolStripSplitButton(string text);
+        public ToolStripSplitButton(string text, Image image);
+        public ToolStripSplitButton(string text, Image image, EventHandler onClick);
+        public ToolStripSplitButton(string text, Image image, EventHandler onClick, string name);
+        public ToolStripSplitButton(string text, Image image, params ToolStripItem[] dropDownItems);
+        public new bool AutoToolTip { get; set; }
+        public Rectangle ButtonBounds { get; }
+        public bool ButtonPressed { get; }
+        public bool ButtonSelected { get; }
+        protected override bool DefaultAutoToolTip { get; }
+        public ToolStripItem DefaultItem { get; set; }
+        protected internal override bool DismissWhenClicked { get; }
+        public Rectangle DropDownButtonBounds { get; }
+        public bool DropDownButtonPressed { get; }
+        public bool DropDownButtonSelected { get; }
+        public int DropDownButtonWidth { get; set; }
+        public Rectangle SplitterBounds { get; }
+        public event EventHandler ButtonClick;
+        public event EventHandler ButtonDoubleClick;
+        public event EventHandler DefaultItemChanged;
+        protected override AccessibleObject CreateAccessibilityInstance();
+        protected override ToolStripDropDown CreateDefaultDropDown();
+        public override Size GetPreferredSize(Size constrainingSize);
+        protected virtual void OnButtonClick(EventArgs e);
+        public virtual void OnButtonDoubleClick(EventArgs e);
+        protected virtual void OnDefaultItemChanged(EventArgs e);
+        protected override void OnMouseDown(MouseEventArgs e);
+        protected override void OnMouseLeave(EventArgs e);
+        protected override void OnMouseUp(MouseEventArgs e);
+        protected override void OnPaint(PaintEventArgs e);
+        protected override void OnRightToLeftChanged(EventArgs e);
+        public void PerformButtonClick();
+        protected internal override bool ProcessDialogKey(Keys keyData);
+        protected internal override bool ProcessMnemonic(char charCode);
+        public virtual void ResetDropDownButtonWidth();
+        public class ToolStripSplitButtonAccessibleObject : ToolStripItem.ToolStripItemAccessibleObject {
+            public ToolStripSplitButtonAccessibleObject(ToolStripSplitButton item);
+            public override void DoDefaultAction();
+        }
+    }
+    public class ToolStripStatusLabel : ToolStripLabel {
+        public ToolStripStatusLabel();
+        public ToolStripStatusLabel(Image image);
+        public ToolStripStatusLabel(string text);
+        public ToolStripStatusLabel(string text, Image image);
+        public ToolStripStatusLabel(string text, Image image, EventHandler onClick);
+        public ToolStripStatusLabel(string text, Image image, EventHandler onClick, string name);
+        public new ToolStripItemAlignment Alignment { get; set; }
+        public ToolStripStatusLabelBorderSides BorderSides { get; set; }
+        public Border3DStyle BorderStyle { get; set; }
+        protected internal override Padding DefaultMargin { get; }
+        public bool Spring { get; set; }
+        public override Size GetPreferredSize(Size constrainingSize);
+        protected override void OnPaint(PaintEventArgs e);
+    }
+    public enum ToolStripStatusLabelBorderSides {
+        All = 15,
+        Bottom = 8,
+        Left = 1,
+        None = 0,
+        Right = 4,
+        Top = 2,
+    }
+    public class ToolStripSystemRenderer : ToolStripRenderer {
+        public ToolStripSystemRenderer();
+        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e);
+        protected override void OnRenderDropDownButtonBackground(ToolStripItemRenderEventArgs e);
+        protected override void OnRenderGrip(ToolStripGripRenderEventArgs e);
+        protected override void OnRenderImageMargin(ToolStripRenderEventArgs e);
+        protected override void OnRenderItemBackground(ToolStripItemRenderEventArgs e);
+        protected override void OnRenderLabelBackground(ToolStripItemRenderEventArgs e);
+        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e);
+        protected override void OnRenderOverflowButtonBackground(ToolStripItemRenderEventArgs e);
+        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e);
+        protected override void OnRenderSplitButtonBackground(ToolStripItemRenderEventArgs e);
+        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e);
+        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e);
+        protected override void OnRenderToolStripStatusLabelBackground(ToolStripItemRenderEventArgs e);
+    }
+    public class ToolStripTextBox : ToolStripControlHost {
+        public ToolStripTextBox();
+        public ToolStripTextBox(string name);
+        public ToolStripTextBox(Control c);
+        public bool AcceptsReturn { get; set; }
+        public bool AcceptsTab { get; set; }
+        public AutoCompleteStringCollection AutoCompleteCustomSource { get; set; }
+        public AutoCompleteMode AutoCompleteMode { get; set; }
+        public AutoCompleteSource AutoCompleteSource { get; set; }
+        public override Image BackgroundImage { get; set; }
+        public override ImageLayout BackgroundImageLayout { get; set; }
+        public BorderStyle BorderStyle { get; set; }
+        public bool CanUndo { get; }
+        public CharacterCasing CharacterCasing { get; set; }
+        protected internal override Padding DefaultMargin { get; }
+        protected override Size DefaultSize { get; }
+        public bool HideSelection { get; set; }
+        public string[] Lines { get; set; }
+        public int MaxLength { get; set; }
+        public bool Modified { get; set; }
+        public bool Multiline { get; set; }
+        public bool ReadOnly { get; set; }
+        public string SelectedText { get; set; }
+        public int SelectionLength { get; set; }
+        public int SelectionStart { get; set; }
+        public bool ShortcutsEnabled { get; set; }
+        public TextBox TextBox { get; }
+        public HorizontalAlignment TextBoxTextAlign { get; set; }
+        public int TextLength { get; }
+        public bool WordWrap { get; set; }
+        public event EventHandler AcceptsTabChanged;
+        public event EventHandler BorderStyleChanged;
+        public event EventHandler HideSelectionChanged;
+        public event EventHandler ModifiedChanged;
+        public event EventHandler MultilineChanged;
+        public event EventHandler ReadOnlyChanged;
+        public event EventHandler TextBoxTextAlignChanged;
+        public void AppendText(string text);
+        public void Clear();
+        public void ClearUndo();
+        public void Copy();
+        public void Cut();
+        public void DeselectAll();
+        public char GetCharFromPosition(Point pt);
+        public int GetCharIndexFromPosition(Point pt);
+        public int GetFirstCharIndexFromLine(int lineNumber);
+        public int GetFirstCharIndexOfCurrentLine();
+        public int GetLineFromCharIndex(int index);
+        public Point GetPositionFromCharIndex(int index);
+        public override Size GetPreferredSize(Size constrainingSize);
+        protected virtual void OnAcceptsTabChanged(EventArgs e);
+        protected virtual void OnBorderStyleChanged(EventArgs e);
+        protected virtual void OnHideSelectionChanged(EventArgs e);
+        protected virtual void OnModifiedChanged(EventArgs e);
+        protected virtual void OnMultilineChanged(EventArgs e);
+        protected virtual void OnReadOnlyChanged(EventArgs e);
+        protected override void OnSubscribeControlEvents(Control control);
+        protected override void OnUnsubscribeControlEvents(Control control);
+        public void Paste();
+        public void ScrollToCaret();
+        public void Select(int start, int length);
+        public void SelectAll();
+        public void Undo();
+    }
+    public enum ToolStripTextDirection {
+        Horizontal = 1,
+        Inherit = 0,
+        Vertical270 = 3,
+        Vertical90 = 2,
+    }
+    public class ToolTip : Component, IExtenderProvider {
+        public ToolTip();
+        public ToolTip(IContainer cont);
+        public bool Active { get; set; }
+        public int AutomaticDelay { get; set; }
+        public int AutoPopDelay { get; set; }
+        public Color BackColor { get; set; }
+        protected virtual CreateParams CreateParams { get; }
+        public Color ForeColor { get; set; }
+        public int InitialDelay { get; set; }
+        public bool IsBalloon { get; set; }
+        public bool OwnerDraw { get; set; }
+        public int ReshowDelay { get; set; }
+        public bool ShowAlways { get; set; }
+        public bool StripAmpersands { get; set; }
+        public object Tag { get; set; }
+        public ToolTipIcon ToolTipIcon { get; set; }
+        public string ToolTipTitle { get; set; }
+        public bool UseAnimation { get; set; }
+        public bool UseFading { get; set; }
+        public event DrawToolTipEventHandler Draw;
+        public event PopupEventHandler Popup;
+        public bool CanExtend(object target);
+        protected override void Dispose(bool disposing);
+        ~ToolTip();
+        public string GetToolTip(Control control);
+        public void Hide(IWin32Window win);
+        public void RemoveAll();
+        public void SetToolTip(Control control, string caption);
+        public void Show(string text, IWin32Window window);
+        public void Show(string text, IWin32Window window, Point point);
+        public void Show(string text, IWin32Window window, Point point, int duration);
+        public void Show(string text, IWin32Window window, int duration);
+        public void Show(string text, IWin32Window window, int x, int y);
+        public void Show(string text, IWin32Window window, int x, int y, int duration);
+        protected void StopTimer();
+        public override string ToString();
+    }
+    public enum ToolTipIcon {
+        Error = 3,
+        Info = 1,
+        None = 0,
+        Warning = 2,
+    }
+    public class TrackBar : Control, ISupportInitialize {
+        public TrackBar();
+        public override bool AutoSize { get; set; }
+        public override Image BackgroundImage { get; set; }
+        public override ImageLayout BackgroundImageLayout { get; set; }
+        protected override CreateParams CreateParams { get; }
+        protected override ImeMode DefaultImeMode { get; }
+        protected override Size DefaultSize { get; }
+        protected override bool DoubleBuffered { get; set; }
+        public override Font Font { get; set; }
+        public override Color ForeColor { get; set; }
+        public new ImeMode ImeMode { get; set; }
+        public int LargeChange { get; set; }
+        public int Maximum { get; set; }
+        public int Minimum { get; set; }
+        public Orientation Orientation { get; set; }
+        public new Padding Padding { get; set; }
+        public virtual bool RightToLeftLayout { get; set; }
+        public int SmallChange { get; set; }
+        public override string Text { get; set; }
+        public int TickFrequency { get; set; }
+        public TickStyle TickStyle { get; set; }
+        public int Value { get; set; }
+        public new event EventHandler AutoSizeChanged;
+        public new event EventHandler BackgroundImageChanged;
+        public new event EventHandler BackgroundImageLayoutChanged;
+        public new event EventHandler Click;
+        public new event EventHandler DoubleClick;
+        public new event EventHandler FontChanged;
+        public new event EventHandler ForeColorChanged;
+        public new event EventHandler ImeModeChanged;
+        public new event MouseEventHandler MouseClick;
+        public new event MouseEventHandler MouseDoubleClick;
+        public new event EventHandler PaddingChanged;
+        public new event PaintEventHandler Paint;
+        public event EventHandler RightToLeftLayoutChanged;
+        public event EventHandler Scroll;
+        public new event EventHandler TextChanged;
+        public event EventHandler ValueChanged;
+        public void BeginInit();
+        protected override void CreateHandle();
+        public void EndInit();
+        protected override bool IsInputKey(Keys keyData);
+        protected override void OnBackColorChanged(EventArgs e);
+        protected override void OnHandleCreated(EventArgs e);
+        protected override void OnMouseWheel(MouseEventArgs e);
+        protected virtual void OnRightToLeftLayoutChanged(EventArgs e);
+        protected virtual void OnScroll(EventArgs e);
+        protected override void OnSystemColorsChanged(EventArgs e);
+        protected virtual void OnValueChanged(EventArgs e);
+        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified);
+        public void SetRange(int minValue, int maxValue);
+        public override string ToString();
+        protected override void WndProc(ref Message m);
+    }
+    public sealed class TrackBarRenderer {
+        public static bool IsSupported { get; }
+        public static void DrawBottomPointingThumb(Graphics g, Rectangle bounds, TrackBarThumbState state);
+        public static void DrawHorizontalThumb(Graphics g, Rectangle bounds, TrackBarThumbState state);
+        public static void DrawHorizontalTicks(Graphics g, Rectangle bounds, int numTicks, EdgeStyle edgeStyle);
+        public static void DrawHorizontalTrack(Graphics g, Rectangle bounds);
+        public static void DrawLeftPointingThumb(Graphics g, Rectangle bounds, TrackBarThumbState state);
+        public static void DrawRightPointingThumb(Graphics g, Rectangle bounds, TrackBarThumbState state);
+        public static void DrawTopPointingThumb(Graphics g, Rectangle bounds, TrackBarThumbState state);
+        public static void DrawVerticalThumb(Graphics g, Rectangle bounds, TrackBarThumbState state);
+        public static void DrawVerticalTicks(Graphics g, Rectangle bounds, int numTicks, EdgeStyle edgeStyle);
+        public static void DrawVerticalTrack(Graphics g, Rectangle bounds);
+        public static Size GetBottomPointingThumbSize(Graphics g, TrackBarThumbState state);
+        public static Size GetLeftPointingThumbSize(Graphics g, TrackBarThumbState state);
+        public static Size GetRightPointingThumbSize(Graphics g, TrackBarThumbState state);
+        public static Size GetTopPointingThumbSize(Graphics g, TrackBarThumbState state);
+    }
+    public class TreeNode : MarshalByRefObject, ICloneable, ISerializable {
+        public TreeNode();
+        protected TreeNode(SerializationInfo serializationInfo, StreamingContext context);
+        public TreeNode(string text);
+        public TreeNode(string text, int imageIndex, int selectedImageIndex);
+        public TreeNode(string text, int imageIndex, int selectedImageIndex, TreeNode[] children);
+        public TreeNode(string text, TreeNode[] children);
+        public Color BackColor { get; set; }
+        public Rectangle Bounds { get; }
+        public bool Checked { get; set; }
+        public virtual ContextMenu ContextMenu { get; set; }
+        public virtual ContextMenuStrip ContextMenuStrip { get; set; }
+        public TreeNode FirstNode { get; }
+        public Color ForeColor { get; set; }
+        public string FullPath { get; }
+        public IntPtr Handle { get; }
+        public int ImageIndex { get; set; }
+        public string ImageKey { get; set; }
+        public int Index { get; }
+        public bool IsEditing { get; }
+        public bool IsExpanded { get; }
+        public bool IsSelected { get; }
+        public bool IsVisible { get; }
+        public TreeNode LastNode { get; }
+        public int Level { get; }
+        public string Name { get; set; }
+        public TreeNode NextNode { get; }
+        public TreeNode NextVisibleNode { get; }
+        public Font NodeFont { get; set; }
+        public TreeNodeCollection Nodes { get; }
+        public TreeNode Parent { get; }
+        public TreeNode PrevNode { get; }
+        public TreeNode PrevVisibleNode { get; }
+        public int SelectedImageIndex { get; set; }
+        public string SelectedImageKey { get; set; }
+        public int StateImageIndex { get; set; }
+        public string StateImageKey { get; set; }
+        public object Tag { get; set; }
+        public string Text { get; set; }
+        public string ToolTipText { get; set; }
+        public TreeView TreeView { get; }
+        public void BeginEdit();
+        public virtual object Clone();
+        public void Collapse();
+        public void Collapse(bool ignoreChildren);
+        protected virtual void Deserialize(SerializationInfo serializationInfo, StreamingContext context);
+        public void EndEdit(bool cancel);
+        public void EnsureVisible();
+        public void Expand();
+        public void ExpandAll();
+        public static TreeNode FromHandle(TreeView tree, IntPtr handle);
+        public int GetNodeCount(bool includeSubTrees);
+        public void Remove();
+        protected virtual void Serialize(SerializationInfo si, StreamingContext context);
+        void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context);
+        public void Toggle();
+        public override string ToString();
+    }
+    public class TreeNodeCollection : ICollection, IEnumerable, IList {
+        public int Count { get; }
+        public bool IsReadOnly { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public virtual TreeNode this[int index] { get; set; }
+        public virtual TreeNode this[string key] { get; }
+        public virtual TreeNode Add(string text);
+        public virtual TreeNode Add(string key, string text);
+        public virtual TreeNode Add(string key, string text, int imageIndex);
+        public virtual TreeNode Add(string key, string text, int imageIndex, int selectedImageIndex);
+        public virtual TreeNode Add(string key, string text, string imageKey);
+        public virtual TreeNode Add(string key, string text, string imageKey, string selectedImageKey);
+        public virtual int Add(TreeNode node);
+        public virtual void AddRange(TreeNode[] nodes);
+        public virtual void Clear();
+        public bool Contains(TreeNode node);
+        public virtual bool ContainsKey(string key);
+        public void CopyTo(Array dest, int index);
+        public TreeNode[] Find(string key, bool searchAllChildren);
+        public IEnumerator GetEnumerator();
+        public int IndexOf(TreeNode node);
+        public virtual int IndexOfKey(string key);
+        public virtual TreeNode Insert(int index, string text);
+        public virtual TreeNode Insert(int index, string key, string text);
+        public virtual TreeNode Insert(int index, string key, string text, int imageIndex);
+        public virtual TreeNode Insert(int index, string key, string text, int imageIndex, int selectedImageIndex);
+        public virtual TreeNode Insert(int index, string key, string text, string imageKey);
+        public virtual TreeNode Insert(int index, string key, string text, string imageKey, string selectedImageKey);
+        public virtual void Insert(int index, TreeNode node);
+        public void Remove(TreeNode node);
+        public virtual void RemoveAt(int index);
+        public virtual void RemoveByKey(string key);
+        int System.Collections.IList.Add(object node);
+        bool System.Collections.IList.Contains(object node);
+        int System.Collections.IList.IndexOf(object node);
+        void System.Collections.IList.Insert(int index, object node);
+        void System.Collections.IList.Remove(object node);
+    }
+    public class TreeNodeConverter : TypeConverter {
+        public TreeNodeConverter();
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public class TreeNodeMouseClickEventArgs : MouseEventArgs {
+        public TreeNodeMouseClickEventArgs(TreeNode node, MouseButtons button, int clicks, int x, int y);
+        public TreeNode Node { get; }
+    }
+    public delegate void TreeNodeMouseClickEventHandler(object sender, TreeNodeMouseClickEventArgs e);
+    public class TreeNodeMouseHoverEventArgs : EventArgs {
+        public TreeNodeMouseHoverEventArgs(TreeNode node);
+        public TreeNode Node { get; }
+    }
+    public delegate void TreeNodeMouseHoverEventHandler(object sender, TreeNodeMouseHoverEventArgs e);
+    public enum TreeNodeStates {
+        Checked = 8,
+        Default = 32,
+        Focused = 16,
+        Grayed = 2,
+        Hot = 64,
+        Indeterminate = 256,
+        Marked = 128,
+        Selected = 1,
+        ShowKeyboardCues = 512,
+    }
+    public class TreeView : Control {
+        public TreeView();
+        public override Color BackColor { get; set; }
+        public override Image BackgroundImage { get; set; }
+        public override ImageLayout BackgroundImageLayout { get; set; }
+        public BorderStyle BorderStyle { get; set; }
+        public bool CheckBoxes { get; set; }
+        protected override CreateParams CreateParams { get; }
+        protected override Size DefaultSize { get; }
+        protected override bool DoubleBuffered { get; set; }
+        public TreeViewDrawMode DrawMode { get; set; }
+        public override Color ForeColor { get; set; }
+        public bool FullRowSelect { get; set; }
+        public bool HideSelection { get; set; }
+        public bool HotTracking { get; set; }
+        public int ImageIndex { get; set; }
+        public string ImageKey { get; set; }
+        public ImageList ImageList { get; set; }
+        public int Indent { get; set; }
+        public int ItemHeight { get; set; }
+        public bool LabelEdit { get; set; }
+        public Color LineColor { get; set; }
+        public TreeNodeCollection Nodes { get; }
+        public new Padding Padding { get; set; }
+        public string PathSeparator { get; set; }
+        public virtual bool RightToLeftLayout { get; set; }
+        public bool Scrollable { get; set; }
+        public int SelectedImageIndex { get; set; }
+        public string SelectedImageKey { get; set; }
+        public TreeNode SelectedNode { get; set; }
+        public bool ShowLines { get; set; }
+        public bool ShowNodeToolTips { get; set; }
+        public bool ShowPlusMinus { get; set; }
+        public bool ShowRootLines { get; set; }
+        public bool Sorted { get; set; }
+        public ImageList StateImageList { get; set; }
+        public override string Text { get; set; }
+        public TreeNode TopNode { get; set; }
+        public IComparer TreeViewNodeSorter { get; set; }
+        public int VisibleCount { get; }
+        public event TreeViewEventHandler AfterCheck;
+        public event TreeViewEventHandler AfterCollapse;
+        public event TreeViewEventHandler AfterExpand;
+        public event NodeLabelEditEventHandler AfterLabelEdit;
+        public event TreeViewEventHandler AfterSelect;
+        public new event EventHandler BackgroundImageChanged;
+        public new event EventHandler BackgroundImageLayoutChanged;
+        public event TreeViewCancelEventHandler BeforeCheck;
+        public event TreeViewCancelEventHandler BeforeCollapse;
+        public event TreeViewCancelEventHandler BeforeExpand;
+        public event NodeLabelEditEventHandler BeforeLabelEdit;
+        public event TreeViewCancelEventHandler BeforeSelect;
+        public event DrawTreeNodeEventHandler DrawNode;
+        public event ItemDragEventHandler ItemDrag;
+        public event TreeNodeMouseClickEventHandler NodeMouseClick;
+        public event TreeNodeMouseClickEventHandler NodeMouseDoubleClick;
+        public event TreeNodeMouseHoverEventHandler NodeMouseHover;
+        public new event EventHandler PaddingChanged;
+        public new event PaintEventHandler Paint;
+        public event EventHandler RightToLeftLayoutChanged;
+        public new event EventHandler TextChanged;
+        public void BeginUpdate();
+        public void CollapseAll();
+        protected override void CreateHandle();
+        protected override void Dispose(bool disposing);
+        public void EndUpdate();
+        public void ExpandAll();
+        protected OwnerDrawPropertyBag GetItemRenderStyles(TreeNode node, int state);
+        public TreeNode GetNodeAt(Point pt);
+        public TreeNode GetNodeAt(int x, int y);
+        public int GetNodeCount(bool includeSubTrees);
+        public TreeViewHitTestInfo HitTest(Point pt);
+        public TreeViewHitTestInfo HitTest(int x, int y);
+        protected override bool IsInputKey(Keys keyData);
+        protected virtual void OnAfterCheck(TreeViewEventArgs e);
+        protected internal virtual void OnAfterCollapse(TreeViewEventArgs e);
+        protected virtual void OnAfterExpand(TreeViewEventArgs e);
+        protected virtual void OnAfterLabelEdit(NodeLabelEditEventArgs e);
+        protected virtual void OnAfterSelect(TreeViewEventArgs e);
+        protected virtual void OnBeforeCheck(TreeViewCancelEventArgs e);
+        protected internal virtual void OnBeforeCollapse(TreeViewCancelEventArgs e);
+        protected virtual void OnBeforeExpand(TreeViewCancelEventArgs e);
+        protected virtual void OnBeforeLabelEdit(NodeLabelEditEventArgs e);
+        protected virtual void OnBeforeSelect(TreeViewCancelEventArgs e);
+        protected virtual void OnDrawNode(DrawTreeNodeEventArgs e);
+        protected override void OnHandleCreated(EventArgs e);
+        protected override void OnHandleDestroyed(EventArgs e);
+        protected virtual void OnItemDrag(ItemDragEventArgs e);
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected override void OnKeyPress(KeyPressEventArgs e);
+        protected override void OnKeyUp(KeyEventArgs e);
+        protected override void OnMouseHover(EventArgs e);
+        protected override void OnMouseLeave(EventArgs e);
+        protected virtual void OnNodeMouseClick(TreeNodeMouseClickEventArgs e);
+        protected virtual void OnNodeMouseDoubleClick(TreeNodeMouseClickEventArgs e);
+        protected virtual void OnNodeMouseHover(TreeNodeMouseHoverEventArgs e);
+        protected virtual void OnRightToLeftLayoutChanged(EventArgs e);
+        public void Sort();
+        public override string ToString();
+        protected override void WndProc(ref Message m);
+    }
+    public enum TreeViewAction {
+        ByKeyboard = 1,
+        ByMouse = 2,
+        Collapse = 3,
+        Expand = 4,
+        Unknown = 0,
+    }
+    public class TreeViewCancelEventArgs : CancelEventArgs {
+        public TreeViewCancelEventArgs(TreeNode node, bool cancel, TreeViewAction action);
+        public TreeViewAction Action { get; }
+        public TreeNode Node { get; }
+    }
+    public delegate void TreeViewCancelEventHandler(object sender, TreeViewCancelEventArgs e);
+    public enum TreeViewDrawMode {
+        Normal = 0,
+        OwnerDrawAll = 2,
+        OwnerDrawText = 1,
+    }
+    public class TreeViewEventArgs : EventArgs {
+        public TreeViewEventArgs(TreeNode node);
+        public TreeViewEventArgs(TreeNode node, TreeViewAction action);
+        public TreeViewAction Action { get; }
+        public TreeNode Node { get; }
+    }
+    public delegate void TreeViewEventHandler(object sender, TreeViewEventArgs e);
+    public class TreeViewHitTestInfo {
+        public TreeViewHitTestInfo(TreeNode hitNode, TreeViewHitTestLocations hitLocation);
+        public TreeViewHitTestLocations Location { get; }
+        public TreeNode Node { get; }
+    }
+    public enum TreeViewHitTestLocations {
+        AboveClientArea = 256,
+        BelowClientArea = 512,
+        Image = 2,
+        Indent = 8,
+        Label = 4,
+        LeftOfClientArea = 2048,
+        None = 1,
+        PlusMinus = 16,
+        RightOfClientArea = 1024,
+        RightOfLabel = 32,
+        StateImage = 64,
+    }
+    public class TreeViewImageIndexConverter : ImageIndexConverter {
+        public TreeViewImageIndexConverter();
+        protected override bool IncludeNoneAsStandardValue { get; }
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+        public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context);
+    }
+    public class TreeViewImageKeyConverter : ImageKeyConverter {
+        public TreeViewImageKeyConverter();
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public class TypeValidationEventArgs : EventArgs {
+        public TypeValidationEventArgs(Type validatingType, bool isValidInput, object returnValue, string message);
+        public bool Cancel { get; set; }
+        public bool IsValidInput { get; }
+        public string Message { get; }
+        public object ReturnValue { get; }
+        public Type ValidatingType { get; }
+    }
+    public delegate void TypeValidationEventHandler(object sender, TypeValidationEventArgs e);
+    public enum UICues {
+        Changed = 12,
+        ChangeFocus = 4,
+        ChangeKeyboard = 8,
+        None = 0,
+        ShowFocus = 1,
+        ShowKeyboard = 2,
+        Shown = 3,
+    }
+    public class UICuesEventArgs : EventArgs {
+        public UICuesEventArgs(UICues uicues);
+        public UICues Changed { get; }
+        public bool ChangeFocus { get; }
+        public bool ChangeKeyboard { get; }
+        public bool ShowFocus { get; }
+        public bool ShowKeyboard { get; }
+    }
+    public delegate void UICuesEventHandler(object sender, UICuesEventArgs e);
+    public enum UnhandledExceptionMode {
+        Automatic = 0,
+        CatchException = 2,
+        ThrowException = 1,
+    }
+    public abstract class UpDownBase : ContainerControl {
+        public UpDownBase();
+        public override bool AutoScroll { get; set; }
+        public new Size AutoScrollMargin { get; set; }
+        public new Size AutoScrollMinSize { get; set; }
+        public override bool AutoSize { get; set; }
+        public override Color BackColor { get; set; }
+        public override Image BackgroundImage { get; set; }
+        public override ImageLayout BackgroundImageLayout { get; set; }
+        public BorderStyle BorderStyle { get; set; }
+        protected bool ChangingText { get; set; }
+        public override ContextMenu ContextMenu { get; set; }
+        public override ContextMenuStrip ContextMenuStrip { get; set; }
+        protected override CreateParams CreateParams { get; }
+        protected override Size DefaultSize { get; }
+        public new ScrollableControl.DockPaddingEdges DockPadding { get; }
+        public override bool Focused { get; }
+        public override Color ForeColor { get; set; }
+        public bool InterceptArrowKeys { get; set; }
+        public override Size MaximumSize { get; set; }
+        public override Size MinimumSize { get; set; }
+        public int PreferredHeight { get; }
+        public bool ReadOnly { get; set; }
+        public override string Text { get; set; }
+        public HorizontalAlignment TextAlign { get; set; }
+        public LeftRightAlignment UpDownAlign { get; set; }
+        protected bool UserEdit { get; set; }
+        public new event EventHandler AutoSizeChanged;
+        public new event EventHandler BackgroundImageChanged;
+        public new event EventHandler BackgroundImageLayoutChanged;
+        public new event EventHandler MouseEnter;
+        public new event EventHandler MouseHover;
+        public new event EventHandler MouseLeave;
+        public new event MouseEventHandler MouseMove;
+        public abstract void DownButton();
+        protected virtual void OnChanged(object source, EventArgs e);
+        protected override void OnFontChanged(EventArgs e);
+        protected override void OnHandleCreated(EventArgs e);
+        protected override void OnHandleDestroyed(EventArgs e);
+        protected override void OnLayout(LayoutEventArgs e);
+        protected override void OnMouseDown(MouseEventArgs e);
+        protected override void OnMouseUp(MouseEventArgs mevent);
+        protected override void OnMouseWheel(MouseEventArgs e);
+        protected override void OnPaint(PaintEventArgs e);
+        protected virtual void OnTextBoxKeyDown(object source, KeyEventArgs e);
+        protected virtual void OnTextBoxKeyPress(object source, KeyPressEventArgs e);
+        protected virtual void OnTextBoxLostFocus(object source, EventArgs e);
+        protected virtual void OnTextBoxResize(object source, EventArgs e);
+        protected virtual void OnTextBoxTextChanged(object source, EventArgs e);
+        public void Select(int start, int length);
+        public abstract void UpButton();
+        protected abstract void UpdateEditText();
+        protected virtual void ValidateEditText();
+        protected override void WndProc(ref Message m);
+    }
+    public class UpDownEventArgs : EventArgs {
+        public UpDownEventArgs(int buttonPushed);
+        public int ButtonID { get; }
+    }
+    public delegate void UpDownEventHandler(object source, UpDownEventArgs e);
+    public class UserControl : ContainerControl {
+        public UserControl();
+        public override bool AutoSize { get; set; }
+        public AutoSizeMode AutoSizeMode { get; set; }
+        public override AutoValidate AutoValidate { get; set; }
+        public BorderStyle BorderStyle { get; set; }
+        protected override CreateParams CreateParams { get; }
+        protected override Size DefaultSize { get; }
+        public override string Text { get; set; }
+        public new event EventHandler AutoSizeChanged;
+        public new event EventHandler AutoValidateChanged;
+        public event EventHandler Load;
+        public new event EventHandler TextChanged;
+        protected override void OnCreateControl();
+        protected virtual void OnLoad(EventArgs e);
+        protected override void OnMouseDown(MouseEventArgs e);
+        protected override void OnResize(EventArgs e);
+        public override bool ValidateChildren();
+        public override bool ValidateChildren(ValidationConstraints validationConstraints);
+        protected override void WndProc(ref Message m);
+    }
+    public enum ValidationConstraints {
+        Enabled = 2,
+        ImmediateChildren = 16,
+        None = 0,
+        Selectable = 1,
+        TabStop = 8,
+        Visible = 4,
+    }
+    public enum View {
+        Details = 1,
+        LargeIcon = 0,
+        List = 3,
+        SmallIcon = 2,
+        Tile = 4,
+    }
+    public class VScrollBar : ScrollBar {
+        public VScrollBar();
+        protected override CreateParams CreateParams { get; }
+        protected override Size DefaultSize { get; }
+        public override RightToLeft RightToLeft { get; set; }
+        public new event EventHandler RightToLeftChanged;
+    }
+    public class VScrollProperties : ScrollProperties {
+        public VScrollProperties(ScrollableControl container);
+    }
+    public class WebBrowser : WebBrowserBase {
+        public WebBrowser();
+        public bool AllowNavigation { get; set; }
+        public bool AllowWebBrowserDrop { get; set; }
+        public bool CanGoBack { get; }
+        public bool CanGoForward { get; }
+        protected override Size DefaultSize { get; }
+        public HtmlDocument Document { get; }
+        public Stream DocumentStream { get; set; }
+        public string DocumentText { get; set; }
+        public string DocumentTitle { get; }
+        public string DocumentType { get; }
+        public WebBrowserEncryptionLevel EncryptionLevel { get; }
+        public override bool Focused { get; }
+        public bool IsBusy { get; }
+        public bool IsOffline { get; }
+        public bool IsWebBrowserContextMenuEnabled { get; set; }
+        public object ObjectForScripting { get; set; }
+        public new Padding Padding { get; set; }
+        public WebBrowserReadyState ReadyState { get; }
+        public bool ScriptErrorsSuppressed { get; set; }
+        public bool ScrollBarsEnabled { get; set; }
+        public virtual string StatusText { get; }
+        public Uri Url { get; set; }
+        public Version Version { get; }
+        public bool WebBrowserShortcutsEnabled { get; set; }
+        public event EventHandler CanGoBackChanged;
+        public event EventHandler CanGoForwardChanged;
+        public event WebBrowserDocumentCompletedEventHandler DocumentCompleted;
+        public event EventHandler DocumentTitleChanged;
+        public event EventHandler EncryptionLevelChanged;
+        public event EventHandler FileDownload;
+        public event WebBrowserNavigatedEventHandler Navigated;
+        public event WebBrowserNavigatingEventHandler Navigating;
+        public event CancelEventHandler NewWindow;
+        public new event EventHandler PaddingChanged;
+        public event WebBrowserProgressChangedEventHandler ProgressChanged;
+        public event EventHandler StatusTextChanged;
+        protected override void AttachInterfaces(object nativeActiveXObject);
+        protected override void CreateSink();
+        protected override WebBrowserSiteBase CreateWebBrowserSiteBase();
+        protected override void DetachInterfaces();
+        protected override void DetachSink();
+        protected override void Dispose(bool disposing);
+        public bool GoBack();
+        public bool GoForward();
+        public void GoHome();
+        public void GoSearch();
+        public void Navigate(string urlString);
+        public void Navigate(string urlString, bool newWindow);
+        public void Navigate(string urlString, string targetFrameName);
+        public void Navigate(string urlString, string targetFrameName, byte[] postData, string additionalHeaders);
+        public void Navigate(Uri url);
+        public void Navigate(Uri url, bool newWindow);
+        public void Navigate(Uri url, string targetFrameName);
+        public void Navigate(Uri url, string targetFrameName, byte[] postData, string additionalHeaders);
+        protected virtual void OnCanGoBackChanged(EventArgs e);
+        protected virtual void OnCanGoForwardChanged(EventArgs e);
+        protected virtual void OnDocumentCompleted(WebBrowserDocumentCompletedEventArgs e);
+        protected virtual void OnDocumentTitleChanged(EventArgs e);
+        protected virtual void OnEncryptionLevelChanged(EventArgs e);
+        protected virtual void OnFileDownload(EventArgs e);
+        protected virtual void OnNavigated(WebBrowserNavigatedEventArgs e);
+        protected virtual void OnNavigating(WebBrowserNavigatingEventArgs e);
+        protected virtual void OnNewWindow(CancelEventArgs e);
+        protected virtual void OnProgressChanged(WebBrowserProgressChangedEventArgs e);
+        protected virtual void OnStatusTextChanged(EventArgs e);
+        public void Print();
+        public override void Refresh();
+        public void Refresh(WebBrowserRefreshOption opt);
+        public void ShowPageSetupDialog();
+        public void ShowPrintDialog();
+        public void ShowPrintPreviewDialog();
+        public void ShowPropertiesDialog();
+        public void ShowSaveAsDialog();
+        public void Stop();
+        protected override void WndProc(ref Message m);
+        protected class WebBrowserSite : WebBrowserSiteBase {
+            public WebBrowserSite(WebBrowser host);
+        }
+    }
+    public class WebBrowserBase : Control {
+        public object ActiveXInstance { get; }
+        public override bool AllowDrop { get; set; }
+        public override Color BackColor { get; set; }
+        public override Image BackgroundImage { get; set; }
+        public override ImageLayout BackgroundImageLayout { get; set; }
+        public override Cursor Cursor { get; set; }
+        protected override Size DefaultSize { get; }
+        public new bool Enabled { get; set; }
+        public override Font Font { get; set; }
+        public override Color ForeColor { get; set; }
+        public new ImeMode ImeMode { get; set; }
+        public override RightToLeft RightToLeft { get; set; }
+        public override ISite Site { set; }
+        public override string Text { get; set; }
+        public new bool UseWaitCursor { get; set; }
+        public new event EventHandler BackColorChanged;
+        public new event EventHandler BackgroundImageChanged;
+        public new event EventHandler BackgroundImageLayoutChanged;
+        public new event EventHandler BindingContextChanged;
+        public new event UICuesEventHandler ChangeUICues;
+        public new event EventHandler Click;
+        public new event EventHandler CursorChanged;
+        public new event EventHandler DoubleClick;
+        public new event DragEventHandler DragDrop;
+        public new event DragEventHandler DragEnter;
+        public new event EventHandler DragLeave;
+        public new event DragEventHandler DragOver;
+        public new event EventHandler EnabledChanged;
+        public new event EventHandler Enter;
+        public new event EventHandler FontChanged;
+        public new event EventHandler ForeColorChanged;
+        public new event GiveFeedbackEventHandler GiveFeedback;
+        public new event HelpEventHandler HelpRequested;
+        public new event EventHandler ImeModeChanged;
+        public new event KeyEventHandler KeyDown;
+        public new event KeyPressEventHandler KeyPress;
+        public new event KeyEventHandler KeyUp;
+        public new event LayoutEventHandler Layout;
+        public new event EventHandler Leave;
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
+        public new event PaintEventHandler Paint;
+        public new event QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
+        public new event QueryContinueDragEventHandler QueryContinueDrag;
+        public new event EventHandler RightToLeftChanged;
+        public new event EventHandler StyleChanged;
+        public new event EventHandler TextChanged;
+        protected virtual void AttachInterfaces(object nativeActiveXObject);
+        protected virtual void CreateSink();
+        protected virtual WebBrowserSiteBase CreateWebBrowserSiteBase();
+        protected virtual void DetachInterfaces();
+        protected virtual void DetachSink();
+        protected override void Dispose(bool disposing);
+        public new void DrawToBitmap(Bitmap bitmap, Rectangle targetBounds);
+        protected override bool IsInputChar(char charCode);
+        protected override void OnBackColorChanged(EventArgs e);
+        protected override void OnFontChanged(EventArgs e);
+        protected override void OnForeColorChanged(EventArgs e);
+        protected override void OnGotFocus(EventArgs e);
+        protected override void OnHandleCreated(EventArgs e);
+        protected override void OnLostFocus(EventArgs e);
+        protected override void OnParentChanged(EventArgs e);
+        protected override void OnRightToLeftChanged(EventArgs e);
+        protected override void OnVisibleChanged(EventArgs e);
+        public override bool PreProcessMessage(ref Message msg);
+        protected override bool ProcessDialogKey(Keys keyData);
+        protected internal override bool ProcessMnemonic(char charCode);
+        protected override void WndProc(ref Message m);
+    }
+    public class WebBrowserDocumentCompletedEventArgs : EventArgs {
+        public WebBrowserDocumentCompletedEventArgs(Uri url);
+        public Uri Url { get; }
+    }
+    public delegate void WebBrowserDocumentCompletedEventHandler(object sender, WebBrowserDocumentCompletedEventArgs e);
+    public enum WebBrowserEncryptionLevel {
+        Bit128 = 6,
+        Bit40 = 3,
+        Bit56 = 4,
+        Fortezza = 5,
+        Insecure = 0,
+        Mixed = 1,
+        Unknown = 2,
+    }
+    public class WebBrowserNavigatedEventArgs : EventArgs {
+        public WebBrowserNavigatedEventArgs(Uri url);
+        public Uri Url { get; }
+    }
+    public delegate void WebBrowserNavigatedEventHandler(object sender, WebBrowserNavigatedEventArgs e);
+    public class WebBrowserNavigatingEventArgs : CancelEventArgs {
+        public WebBrowserNavigatingEventArgs(Uri url, string targetFrameName);
+        public string TargetFrameName { get; }
+        public Uri Url { get; }
+    }
+    public delegate void WebBrowserNavigatingEventHandler(object sender, WebBrowserNavigatingEventArgs e);
+    public class WebBrowserProgressChangedEventArgs : EventArgs {
+        public WebBrowserProgressChangedEventArgs(long currentProgress, long maximumProgress);
+        public long CurrentProgress { get; }
+        public long MaximumProgress { get; }
+    }
+    public delegate void WebBrowserProgressChangedEventHandler(object sender, WebBrowserProgressChangedEventArgs e);
+    public enum WebBrowserReadyState {
+        Complete = 4,
+        Interactive = 3,
+        Loaded = 2,
+        Loading = 1,
+        Uninitialized = 0,
+    }
+    public enum WebBrowserRefreshOption {
+        Completely = 3,
+        Continue = 2,
+        IfExpired = 1,
+        Normal = 0,
+    }
+    public class WebBrowserSiteBase : IDisposable {
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+    }
+    public sealed class WindowsFormsSection : ConfigurationSection {
+        public WindowsFormsSection();
+        public bool JitDebugging { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class WindowsFormsSynchronizationContext : SynchronizationContext, IDisposable {
+        public WindowsFormsSynchronizationContext();
+        public static bool AutoInstall { get; set; }
+        public override SynchronizationContext CreateCopy();
+        public void Dispose();
+        public override void Post(SendOrPostCallback d, object state);
+        public override void Send(SendOrPostCallback d, object state);
+        public static void Uninstall();
+    }
+}
```

