# Microsoft.VisualBasic.Compatibility.VB6

``` diff
+namespace Microsoft.VisualBasic.Compatibility.VB6 {
+    public class ADODC : UserControl, DataSource {
+        public ADODC();
+        public override Color BackColor { get; set; }
+        public bool BOF { get; }
+        public ADODC.BOFActionEnum BOFAction { get; set; }
+        public int CacheSize { get; set; }
+        public int CommandTimeout { get; set; }
+        public CommandTypeEnum CommandType { get; set; }
+        public string ConnectionString { get; set; }
+        public int ConnectionTimeout { get; set; }
+        public CursorLocationEnum CursorLocation { get; set; }
+        public CursorTypeEnum CursorType { get; set; }
+        public bool EOF { get; }
+        public ADODC.EOFActionEnum EOFAction { get; set; }
+        public LockTypeEnum LockType { get; set; }
+        public int MaxRecords { get; set; }
+        public ConnectModeEnum Mode { get; set; }
+        public ADODC.OrientationEnum Orientation { get; set; }
+        public string Password { set; }
+        public Recordset Recordset { get; set; }
+        public string RecordSource { get; set; }
+        public override string Text { get; set; }
+        public string UserName { get; set; }
+        public event ADODC.EndOfRecordsetDelegate EndOfRecordset;
+        public event ADODC.ErrorDelegate Error;
+        public event ADODC.FetchCompleteDelegate FetchComplete;
+        public event ADODC.FetchProgressDelegate FetchProgress;
+        public event ADODC.FieldChangeCompleteDelegate FieldChangeComplete;
+        public event ADODC.MoveCompleteDelegate MoveComplete;
+        public event ADODC.RecordChangeCompleteDelegate RecordChangeComplete;
+        public event ADODC.RecordsetChangeCompleteDelegate RecordsetChangeComplete;
+        public event ADODC.WillChangeFieldDelegate WillChangeField;
+        public event ADODC.WillChangeRecordDelegate WillChangeRecord;
+        public event ADODC.WillChangeRecordsetDelegate WillChangeRecordset;
+        public event ADODC.WillMoveDelegate WillMove;
+        void addDataSourceListener(DataSourceListener dsl);
+        protected override void Dispose(bool disposing);
+        object getDataMember(string dataMember, ref Guid riid);
+        int getDataMemberCount();
+        string getDataMemberName(int index);
+        protected override void OnResize(EventArgs e);
+        public override void Refresh();
+        void removeDataSourceListener(DataSourceListener dsl);
+        public enum BOFActionEnum {
+            adDoMoveFirst = 0,
+            adStayBOF = 1,
+        }
+        public delegate void EndOfRecordsetDelegate(ref bool fMoreData, ref EventStatusEnum adStatus, Recordset pRecordset);
+        public enum EOFActionEnum {
+            adDoAddNew = 2,
+            adDoMoveLast = 0,
+            adStayEOF = 1,
+        }
+        public delegate void ErrorDelegate(int errorNumber, ref string description, int scode, string source, string helpFile, int helpContext, ref bool cancelDisplay);
+        public delegate void FetchCompleteDelegate(Error pError, ref EventStatusEnum adStatus, Recordset pRecordset);
+        public delegate void FetchProgressDelegate(int progress, int maxProgress, ref EventStatusEnum adStatus, Recordset pRecordset);
+        public delegate void FieldChangeCompleteDelegate(int cFields, ref object fields, Error pError, ref EventStatusEnum adStatus, Recordset pRecordset);
+        public delegate void MoveCompleteDelegate(EventReasonEnum adReason, Error pError, ref EventStatusEnum adStatus, Recordset pRecordset);
+        public enum OrientationEnum {
+            adHorizontal = 0,
+            adVertical = 1,
+        }
+        public delegate void RecordChangeCompleteDelegate(EventReasonEnum adReason, int cRecords, Error pError, ref EventStatusEnum adStatus, Recordset pRecordset);
+        public delegate void RecordsetChangeCompleteDelegate(EventReasonEnum adReason, Error pError, ref EventStatusEnum adStatus, Recordset pRecordset);
+        public delegate void WillChangeFieldDelegate(int cFields, ref object fields, ref EventStatusEnum adStatus, Recordset pRecordset);
+        public delegate void WillChangeRecordDelegate(EventReasonEnum adReason, int cRecords, ref EventStatusEnum adStatus, Recordset pRecordset);
+        public delegate void WillChangeRecordsetDelegate(EventReasonEnum adReason, ref EventStatusEnum adStatus, Recordset pRecordset);
+        public delegate void WillMoveDelegate(EventReasonEnum adReason, ref EventStatusEnum adStatus, Recordset pRecordset);
+    }
+    public class ADODCArray : BaseControlArray, IExtenderProvider {
+        public ADODCArray();
+        public ADODCArray(IContainer Container);
+        public ADODC this[short Index] { get; }
+        public event EventHandler BackColorChanged;
+        public event EventHandler BackgroundImageChanged;
+        public event EventHandler BindingContextChanged;
+        public event EventHandler CausesValidationChanged;
+        public event UICuesEventHandler ChangeUICues;
+        public event EventHandler Click;
+        public event EventHandler ContextMenuChanged;
+        public event EventHandler CtlLoad;
+        public event EventHandler CursorChanged;
+        public event EventHandler DockChanged;
+        public event EventHandler DoubleClick;
+        public event DragEventHandler DragDrop;
+        public event DragEventHandler DragEnter;
+        public event EventHandler DragLeave;
+        public event DragEventHandler DragOver;
+        public event EventHandler EnabledChanged;
+        public event ADODC.EndOfRecordsetDelegate EndOfRecordset;
+        public event EventHandler Enter;
+        public event ADODC.ErrorDelegate Error;
+        public event ADODC.FetchCompleteDelegate FetchComplete;
+        public event ADODC.FetchProgressDelegate FetchProgress;
+        public event ADODC.FieldChangeCompleteDelegate FieldChangeComplete;
+        public event EventHandler FontChanged;
+        public event EventHandler ForeColorChanged;
+        public event GiveFeedbackEventHandler GiveFeedback;
+        public event HelpEventHandler HelpRequested;
+        public event EventHandler ImeModeChanged;
+        public event KeyEventHandler KeyDown;
+        public event KeyPressEventHandler KeyPress;
+        public event KeyEventHandler KeyUp;
+        public event LayoutEventHandler Layout;
+        public event EventHandler Leave;
+        public event EventHandler LocationChanged;
+        public event MouseEventHandler MouseDown;
+        public event EventHandler MouseEnter;
+        public event EventHandler MouseHover;
+        public event EventHandler MouseLeave;
+        public event MouseEventHandler MouseMove;
+        public event MouseEventHandler MouseUp;
+        public event EventHandler Move;
+        public event ADODC.MoveCompleteDelegate MoveComplete;
+        public event PaintEventHandler Paint;
+        public event EventHandler ParentChanged;
+        public event QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
+        public event QueryContinueDragEventHandler QueryContinueDrag;
+        public event ADODC.RecordChangeCompleteDelegate RecordChangeComplete;
+        public event ADODC.RecordsetChangeCompleteDelegate RecordsetChangeComplete;
+        public event EventHandler Resize;
+        public event EventHandler RightToLeftChanged;
+        public event EventHandler SizeChanged;
+        public event EventHandler StyleChanged;
+        public event EventHandler SystemColorsChanged;
+        public event EventHandler TabIndexChanged;
+        public event EventHandler TabStopChanged;
+        public event EventHandler Validated;
+        public event CancelEventHandler Validating;
+        public event EventHandler VisibleChanged;
+        public event ADODC.WillChangeFieldDelegate WillChangeField;
+        public event ADODC.WillChangeRecordDelegate WillChangeRecord;
+        public event ADODC.WillChangeRecordsetDelegate WillChangeRecordset;
+        public event ADODC.WillMoveDelegate WillMove;
+        bool CanExtend(object target);
+        protected override Type GetControlInstanceType();
+        public short GetIndex(ADODC o);
+        protected override void HookUpControlEvents(object o);
+        public void ResetIndex(ADODC o);
+        public void SetIndex(ADODC o, short Index);
+        public bool ShouldSerializeIndex(ADODC o);
+    }
+    public abstract class BaseControlArray : Component, ISupportInitialize {
+        protected bool fIsEndInitCalled;
+        protected Hashtable controlAddedAtDesignTime;
+        protected Hashtable controls;
+        protected Hashtable indices;
+        protected IContainer components;
+        protected BaseControlArray();
+        protected BaseControlArray(IContainer Container);
+        protected bool BaseCanExtend(object target);
+        protected short BaseGetIndex(object ctl);
+        protected object BaseGetItem(short Index);
+        protected void BaseResetIndex(object o);
+        protected void BaseSetIndex(object ctl, short Index, bool fIsDynamic=false);
+        protected bool BaseShouldSerializeIndex(object o);
+        void BeginInit();
+        public short Count();
+        protected override void Dispose(bool disposing);
+        void EndInit();
+        protected abstract Type GetControlInstanceType();
+        public IEnumerator GetEnumerator();
+        protected abstract void HookUpControlEvents(object o);
+        public short LBound();
+        public void Load(short Index);
+        public short UBound();
+        public void Unload(short Index);
+    }
+    public abstract class BaseDataEnvironment : DataSource, IDisposable {
+        protected Collection m_Commands;
+        protected Collection m_Connections;
+        protected Collection m_NonRSReturningCommands;
+        protected Collection m_Recordsets;
+        protected BaseDataEnvironment();
+        public Collection Commands { get; }
+        [System.Runtime.CompilerServices.IndexerName("Commands")]
+        public Command this[object lpVar] { get; }
+        public Collection Connections { get; }
+        [System.Runtime.CompilerServices.IndexerName("Connections")]
+        public Connection this[object lpVar] { get; }
+        public object Object { get; }
+        public Collection Recordsets { get; }
+        [System.Runtime.CompilerServices.IndexerName("Recordsets")]
+        public Recordset this[object lpVar] { get; }
+        virtual void addDataSourceListener(DataSourceListener ds);
+        virtual void Dispose();
+        protected virtual void Dispose(bool disposing);
+        ~BaseDataEnvironment();
+        virtual object getDataMember(string strDataMember, ref Guid Id);
+        virtual int GetDataMemberCount();
+        virtual string GetDataMemberName(int Index);
+        virtual void removeDataSourceListener(DataSourceListener ds);
+    }
+    public abstract class BaseOcxArray : BaseControlArray {
+        protected BaseOcxArray();
+        protected BaseOcxArray(IContainer Container);
+        public event EventHandler CausesValidationChanged;
+        public event EventHandler ClientSizeChanged;
+        public event EventHandler ContextMenuChanged;
+        public event EventHandler ContextMenuStripChanged;
+        public event ControlEventHandler ControlAdded;
+        public event ControlEventHandler ControlRemoved;
+        public event EventHandler DockChanged;
+        public event EventHandler Enter;
+        public event EventHandler Leave;
+        public event EventHandler LocationChanged;
+        public event EventHandler MarginChanged;
+        public event EventHandler MouseCaptureChanged;
+        public event EventHandler Move;
+        public event EventHandler PaddingChanged;
+        public event EventHandler ParentChanged;
+        public event EventHandler RegionChanged;
+        public event EventHandler Resize;
+        public event EventHandler SizeChanged;
+        public event EventHandler SystemColorsChanged;
+        public event EventHandler Validated;
+        public event CancelEventHandler Validating;
+        public event EventHandler VisibleChanged;
+        protected override void HookUpControlEvents(object o);
+    }
+    public class BindingCollectionEnumerator : IEnumerator {
+        object Current { get; }
+        bool MoveNext();
+        void Reset();
+    }
+    public class ButtonArray : BaseControlArray, IExtenderProvider {
+        public ButtonArray();
+        public ButtonArray(IContainer Container);
+        public Button this[short Index] { get; }
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
+        public event DragEventHandler DragDrop;
+        public event DragEventHandler DragEnter;
+        public event EventHandler DragLeave;
+        public event DragEventHandler DragOver;
+        public event EventHandler EnabledChanged;
+        public event EventHandler Enter;
+        public event EventHandler FontChanged;
+        public event EventHandler ForeColorChanged;
+        public event GiveFeedbackEventHandler GiveFeedback;
+        public event HelpEventHandler HelpRequested;
+        public event KeyEventHandler KeyDown;
+        public event KeyPressEventHandler KeyPress;
+        public event KeyEventHandler KeyUp;
+        public event LayoutEventHandler Layout;
+        public event EventHandler Leave;
+        public event EventHandler LocationChanged;
+        public event EventHandler MarginChanged;
+        public event EventHandler MouseCaptureChanged;
+        public event MouseEventHandler MouseClick;
+        public event MouseEventHandler MouseDown;
+        public event EventHandler MouseEnter;
+        public event EventHandler MouseHover;
+        public event EventHandler MouseLeave;
+        public event MouseEventHandler MouseMove;
+        public event MouseEventHandler MouseUp;
+        public event EventHandler Move;
+        public event EventHandler PaddingChanged;
+        public event PaintEventHandler Paint;
+        public event EventHandler ParentChanged;
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
+        bool CanExtend(object target);
+        protected override Type GetControlInstanceType();
+        public short GetIndex(Button o);
+        protected override void HookUpControlEvents(object o);
+        public void ResetIndex(Button o);
+        public void SetIndex(Button o, short Index);
+        public bool ShouldSerializeIndex(Button o);
+    }
+    public class CheckBoxArray : BaseControlArray, IExtenderProvider {
+        public CheckBoxArray();
+        public CheckBoxArray(IContainer Container);
+        public CheckBox this[short Index] { get; }
+        public event EventHandler AppearanceChanged;
+        public event EventHandler AutoSizeChanged;
+        public event EventHandler BackColorChanged;
+        public event EventHandler BackgroundImageChanged;
+        public event EventHandler BackgroundImageLayoutChanged;
+        public event EventHandler BindingContextChanged;
+        public event EventHandler CausesValidationChanged;
+        public event UICuesEventHandler ChangeUICues;
+        public event EventHandler CheckedChanged;
+        public event EventHandler CheckStateChanged;
+        public event EventHandler Click;
+        public event EventHandler ClientSizeChanged;
+        public event EventHandler ContextMenuChanged;
+        public event EventHandler ContextMenuStripChanged;
+        public event ControlEventHandler ControlAdded;
+        public event ControlEventHandler ControlRemoved;
+        public event EventHandler CursorChanged;
+        public event EventHandler DockChanged;
+        public event DragEventHandler DragDrop;
+        public event DragEventHandler DragEnter;
+        public event EventHandler DragLeave;
+        public event DragEventHandler DragOver;
+        public event EventHandler EnabledChanged;
+        public event EventHandler Enter;
+        public event EventHandler FontChanged;
+        public event EventHandler ForeColorChanged;
+        public event GiveFeedbackEventHandler GiveFeedback;
+        public event HelpEventHandler HelpRequested;
+        public event KeyEventHandler KeyDown;
+        public event KeyPressEventHandler KeyPress;
+        public event KeyEventHandler KeyUp;
+        public event LayoutEventHandler Layout;
+        public event EventHandler Leave;
+        public event EventHandler LocationChanged;
+        public event EventHandler MarginChanged;
+        public event EventHandler MouseCaptureChanged;
+        public event MouseEventHandler MouseClick;
+        public event MouseEventHandler MouseDown;
+        public event EventHandler MouseEnter;
+        public event EventHandler MouseHover;
+        public event EventHandler MouseLeave;
+        public event MouseEventHandler MouseMove;
+        public event MouseEventHandler MouseUp;
+        public event EventHandler Move;
+        public event EventHandler PaddingChanged;
+        public event PaintEventHandler Paint;
+        public event EventHandler ParentChanged;
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
+        bool CanExtend(object target);
+        protected override Type GetControlInstanceType();
+        public short GetIndex(CheckBox o);
+        protected override void HookUpControlEvents(object o);
+        public void ResetIndex(CheckBox o);
+        public void SetIndex(CheckBox o, short Index);
+        public bool ShouldSerializeIndex(CheckBox o);
+    }
+    public class CheckedListBoxArray : BaseControlArray, IExtenderProvider {
+        public CheckedListBoxArray();
+        public CheckedListBoxArray(IContainer Container);
+        public CheckedListBox this[short Index] { get; }
+        public event EventHandler BackColorChanged;
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
+        public event ListControlConvertEventHandler Format;
+        public event EventHandler FormatStringChanged;
+        public event EventHandler FormattingEnabledChanged;
+        public event GiveFeedbackEventHandler GiveFeedback;
+        public event HelpEventHandler HelpRequested;
+        public event EventHandler ImeModeChanged;
+        public event ItemCheckEventHandler ItemCheck;
+        public event KeyEventHandler KeyDown;
+        public event KeyPressEventHandler KeyPress;
+        public event KeyEventHandler KeyUp;
+        public event LayoutEventHandler Layout;
+        public event EventHandler Leave;
+        public event EventHandler LocationChanged;
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
+        public event EventHandler Move;
+        public event EventHandler PaddingChanged;
+        public event EventHandler ParentChanged;
+        public event QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
+        public event QueryContinueDragEventHandler QueryContinueDrag;
+        public event EventHandler RegionChanged;
+        public event EventHandler Resize;
+        public event EventHandler RightToLeftChanged;
+        public event EventHandler SelectedIndexChanged;
+        public event EventHandler SelectedValueChanged;
+        public event EventHandler SizeChanged;
+        public event EventHandler StyleChanged;
+        public event EventHandler SystemColorsChanged;
+        public event EventHandler TabIndexChanged;
+        public event EventHandler TabStopChanged;
+        public event EventHandler Validated;
+        public event CancelEventHandler Validating;
+        public event EventHandler VisibleChanged;
+        bool CanExtend(object target);
+        protected override Type GetControlInstanceType();
+        public short GetIndex(CheckedListBox o);
+        protected override void HookUpControlEvents(object o);
+        public void ResetIndex(CheckedListBox o);
+        public void SetIndex(CheckedListBox o, short Index);
+        public bool ShouldSerializeIndex(CheckedListBox o);
+    }
+    public class ColorDialogArray : BaseControlArray, IExtenderProvider {
+        public ColorDialogArray();
+        public ColorDialogArray(IContainer Container);
+        public ColorDialog this[short Index] { get; }
+        public event EventHandler HelpRequest;
+        bool CanExtend(object target);
+        protected override Type GetControlInstanceType();
+        public short GetIndex(ColorDialog o);
+        protected override void HookUpControlEvents(object o);
+        public void ResetIndex(ColorDialog o);
+        public void SetIndex(ColorDialog o, short Index);
+        public bool ShouldSerializeIndex(ColorDialog o);
+    }
+    public class ComboBoxArray : BaseControlArray, IExtenderProvider {
+        public ComboBoxArray();
+        public ComboBoxArray(IContainer Container);
+        public ComboBox this[short Index] { get; }
+        public event EventHandler BackColorChanged;
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
+        public event EventHandler DataSourceChanged;
+        public event EventHandler DisplayMemberChanged;
+        public event EventHandler DockChanged;
+        public event EventHandler DoubleClick;
+        public event DragEventHandler DragDrop;
+        public event DragEventHandler DragEnter;
+        public event EventHandler DragLeave;
+        public event DragEventHandler DragOver;
+        public event DrawItemEventHandler DrawItem;
+        public event EventHandler DropDown;
+        public event EventHandler DropDownClosed;
+        public event EventHandler DropDownStyleChanged;
+        public event EventHandler EnabledChanged;
+        public event EventHandler Enter;
+        public event EventHandler FontChanged;
+        public event EventHandler ForeColorChanged;
+        public event ListControlConvertEventHandler Format;
+        public event EventHandler FormatStringChanged;
+        public event EventHandler FormattingEnabledChanged;
+        public event GiveFeedbackEventHandler GiveFeedback;
+        public event HelpEventHandler HelpRequested;
+        public event EventHandler ImeModeChanged;
+        public event KeyEventHandler KeyDown;
+        public event KeyPressEventHandler KeyPress;
+        public event KeyEventHandler KeyUp;
+        public event LayoutEventHandler Layout;
+        public event EventHandler Leave;
+        public event EventHandler LocationChanged;
+        public event EventHandler MarginChanged;
+        public event MeasureItemEventHandler MeasureItem;
+        public event EventHandler MouseCaptureChanged;
+        public event MouseEventHandler MouseClick;
+        public event MouseEventHandler MouseDoubleClick;
+        public event MouseEventHandler MouseDown;
+        public event EventHandler MouseEnter;
+        public event EventHandler MouseHover;
+        public event EventHandler MouseLeave;
+        public event MouseEventHandler MouseMove;
+        public event MouseEventHandler MouseUp;
+        public event EventHandler Move;
+        public event EventHandler PaddingChanged;
+        public event EventHandler ParentChanged;
+        public event QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
+        public event QueryContinueDragEventHandler QueryContinueDrag;
+        public event EventHandler RegionChanged;
+        public event EventHandler Resize;
+        public event EventHandler RightToLeftChanged;
+        public event EventHandler SelectedIndexChanged;
+        public event EventHandler SelectedValueChanged;
+        public event EventHandler SelectionChangeCommitted;
+        public event EventHandler SizeChanged;
+        public event EventHandler StyleChanged;
+        public event EventHandler SystemColorsChanged;
+        public event EventHandler TabIndexChanged;
+        public event EventHandler TabStopChanged;
+        public event EventHandler TextChanged;
+        public event EventHandler TextUpdate;
+        public event EventHandler Validated;
+        public event CancelEventHandler Validating;
+        public event EventHandler ValueMemberChanged;
+        public event EventHandler VisibleChanged;
+        bool CanExtend(object target);
+        protected override Type GetControlInstanceType();
+        public short GetIndex(ComboBox o);
+        protected override void HookUpControlEvents(object o);
+        public void ResetIndex(ComboBox o);
+        public void SetIndex(ComboBox o, short Index);
+        public bool ShouldSerializeIndex(ComboBox o);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct CONNECTDATA {
+        public int cookie;
+        public IntPtr pUnk;
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct DBBINDING {
+        public byte bPrecision;
+        public byte bScale;
+        public short wType;
+        public int cbMaxLen;
+        public int dwFlags;
+        public int eParamIO;
+        public int iOrdinal;
+        public int memOwner;
+        public int obLength;
+        public int obStatus;
+        public int obValue;
+        public int part;
+        public IntPtr pBindExt;
+        public IntPtr pObject;
+        public IntPtr typeInfo;
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct DBCOLUMNINFO {
+        public DBID columnId;
+        public byte precision;
+        public byte scale;
+        public short columnType;
+        public int columnFlags;
+        public int columnOrdinal;
+        public int columnSize;
+        public IntPtr name;
+        public IntPtr typeInfo;
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct DBID {
+        public DBKINDENUM dbkind;
+        public UGUID uGuid;
+        public UNAME uName;
+    }
+    public interface DBinding {
+        bool DataChanged { get; set; }
+        string DataField { get; }
+        IDataFormatDisp DataFormat { get; set; }
+        string Key { get; }
+        object Object { get; }
+        string PropertyName { get; }
+    }
+    public interface DBindingCollection : IEnumerable {
+        int Count { get; }
+        string DataMember { get; set; }
+        DataSource DataSource { get; set; }
+        DBinding this[object index] { get; }
+        UpdateMode UpdateMode { get; set; }
+        DBinding Add(object obj, string propertyName, string dataField, IDataFormatDisp dataFormat=null, string key=null);
+        void Clear();
+        void Remove(object index);
+        void UpdateControls();
+    }
+    public enum DBKINDENUM {
+        DBKIND_GUID = 6,
+        DBKIND_GUID_NAME = 0,
+        DBKIND_GUID_PROPID = 1,
+        DBKIND_NAME = 2,
+        DBKIND_PGUID_NAME = 3,
+        DBKIND_PGUID_PROPID = 4,
+        DBKIND_PROPID = 5,
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct DBPROPIDSET {
+        public Guid guidPropertySet;
+        public int cPropertyIDs;
+        public IntPtr rgPropertyIDs;
+    }
+    public class DirListBox : ListBox {
+        public DirListBox();
+        public new int ColumnWidth { get; set; }
+        public new object DataSource { get; set; }
+        public int DirListCount { get; }
+        public int DirListIndex { get; set; }
+        [System.Runtime.CompilerServices.IndexerName("DirList")]
+        public string this[int Index] { get; }
+        public override DrawMode DrawMode { get; set; }
+        public new int ItemHeight { get; }
+        public new ListBox.ObjectCollection Items { get; }
+        public new bool MultiColumn { get; set; }
+        public string Path { get; set; }
+        public new SelectionMode SelectionMode { get; set; }
+        public new bool Sorted { get; }
+        public new string ValueMember { get; set; }
+        public event EventHandler Change;
+        protected override void Dispose(bool Disposing);
+        protected override void OnBackColorChanged(EventArgs e);
+        protected virtual void OnChange(EventArgs e);
+        protected override void OnDoubleClick(EventArgs e);
+        protected override void OnDrawItem(DrawItemEventArgs e);
+        protected override void OnFontChanged(EventArgs e);
+        protected override void OnHandleCreated(EventArgs e);
+        protected override void OnSelectedIndexChanged(EventArgs e);
+        public override void Refresh();
+    }
+    public class DirListBoxArray : BaseControlArray, IExtenderProvider {
+        public DirListBoxArray();
+        public DirListBoxArray(IContainer Container);
+        public DirListBox this[short Index] { get; }
+        public event EventHandler BackColorChanged;
+        public event EventHandler BindingContextChanged;
+        public event EventHandler CausesValidationChanged;
+        public event EventHandler Change;
+        public event UICuesEventHandler ChangeUICues;
+        public event EventHandler ContextMenuChanged;
+        public event EventHandler CursorChanged;
+        public event EventHandler DataSourceChanged;
+        public event EventHandler DisplayMemberChanged;
+        public event EventHandler DockChanged;
+        public event EventHandler DoubleClick;
+        public event DragEventHandler DragDrop;
+        public event DragEventHandler DragEnter;
+        public event EventHandler DragLeave;
+        public event DragEventHandler DragOver;
+        public event DrawItemEventHandler DrawItem;
+        public event EventHandler EnabledChanged;
+        public event EventHandler Enter;
+        public event EventHandler FontChanged;
+        public event EventHandler ForeColorChanged;
+        public event GiveFeedbackEventHandler GiveFeedback;
+        public event HelpEventHandler HelpRequested;
+        public event EventHandler ImeModeChanged;
+        public event KeyEventHandler KeyDown;
+        public event KeyPressEventHandler KeyPress;
+        public event KeyEventHandler KeyUp;
+        public event LayoutEventHandler Layout;
+        public event EventHandler Leave;
+        public event EventHandler LocationChanged;
+        public event MeasureItemEventHandler MeasureItem;
+        public event MouseEventHandler MouseDown;
+        public event EventHandler MouseEnter;
+        public event EventHandler MouseHover;
+        public event EventHandler MouseLeave;
+        public event MouseEventHandler MouseMove;
+        public event MouseEventHandler MouseUp;
+        public event EventHandler Move;
+        public event EventHandler ParentChanged;
+        public event QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
+        public event QueryContinueDragEventHandler QueryContinueDrag;
+        public event EventHandler Resize;
+        public event EventHandler RightToLeftChanged;
+        public event EventHandler SelectedIndexChanged;
+        public event EventHandler SelectedValueChanged;
+        public event EventHandler SizeChanged;
+        public event EventHandler StyleChanged;
+        public event EventHandler SystemColorsChanged;
+        public event EventHandler TabIndexChanged;
+        public event EventHandler TabStopChanged;
+        public event EventHandler Validated;
+        public event CancelEventHandler Validating;
+        public event EventHandler ValueMemberChanged;
+        public event EventHandler VisibleChanged;
+        bool CanExtend(object target);
+        protected override Type GetControlInstanceType();
+        public short GetIndex(DirListBox o);
+        protected override void HookUpControlEvents(object o);
+        public void ResetIndex(DirListBox o);
+        public void SetIndex(DirListBox o, short Index);
+        public bool ShouldSerializeIndex(DirListBox o);
+    }
+    public class DriveListBox : ComboBox {
+        public DriveListBox();
+        public new object DataSource { get; set; }
+        public new string DisplayMember { get; set; }
+        public new DrawMode DrawMode { get; }
+        public string Drive { get; set; }
+        public new ComboBoxStyle DropDownStyle { get; set; }
+        public new int ItemHeight { get; }
+        public new ComboBox.ObjectCollection Items { get; }
+        [System.Runtime.CompilerServices.IndexerName("Items")]
+        public string this[int Index] { get; }
+        public new int MaxLength { get; set; }
+        public new bool Sorted { get; }
+        public new string Text { get; }
+        public new string ValueMember { get; set; }
+        protected override void Dispose(bool disposing);
+        protected override void OnBackColorChanged(EventArgs e);
+        protected override void OnDrawItem(DrawItemEventArgs e);
+        protected override void OnFontChanged(EventArgs e);
+        protected override void OnHandleCreated(EventArgs e);
+        protected override void OnSelectedIndexChanged(EventArgs e);
+        public override void Refresh();
+        protected override void WndProc(ref Message m);
+    }
+    public class DriveListBoxArray : BaseControlArray, IExtenderProvider {
+        public DriveListBoxArray();
+        public DriveListBoxArray(IContainer Container);
+        public DriveListBox this[short Index] { get; }
+        public event EventHandler BackColorChanged;
+        public event EventHandler BindingContextChanged;
+        public event EventHandler CausesValidationChanged;
+        public event UICuesEventHandler ChangeUICues;
+        public event EventHandler Click;
+        public event EventHandler ContextMenuChanged;
+        public event EventHandler CursorChanged;
+        public event EventHandler DataSourceChanged;
+        public event EventHandler DisplayMemberChanged;
+        public event EventHandler DockChanged;
+        public event EventHandler DoubleClick;
+        public event DragEventHandler DragDrop;
+        public event DragEventHandler DragEnter;
+        public event EventHandler DragLeave;
+        public event DragEventHandler DragOver;
+        public event DrawItemEventHandler DrawItem;
+        public event EventHandler DropDown;
+        public event EventHandler DropDownStyleChanged;
+        public event EventHandler EnabledChanged;
+        public event EventHandler Enter;
+        public event EventHandler FontChanged;
+        public event EventHandler ForeColorChanged;
+        public event GiveFeedbackEventHandler GiveFeedback;
+        public event HelpEventHandler HelpRequested;
+        public event EventHandler ImeModeChanged;
+        public event KeyEventHandler KeyDown;
+        public event KeyPressEventHandler KeyPress;
+        public event KeyEventHandler KeyUp;
+        public event LayoutEventHandler Layout;
+        public event EventHandler Leave;
+        public event EventHandler LocationChanged;
+        public event MeasureItemEventHandler MeasureItem;
+        public event MouseEventHandler MouseDown;
+        public event EventHandler MouseEnter;
+        public event EventHandler MouseHover;
+        public event EventHandler MouseLeave;
+        public event MouseEventHandler MouseMove;
+        public event MouseEventHandler MouseUp;
+        public event EventHandler Move;
+        public event EventHandler ParentChanged;
+        public event QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
+        public event QueryContinueDragEventHandler QueryContinueDrag;
+        public event EventHandler Resize;
+        public event EventHandler RightToLeftChanged;
+        public event EventHandler SelectedIndexChanged;
+        public event EventHandler SelectedValueChanged;
+        public event EventHandler SelectionChangeCommitted;
+        public event EventHandler SizeChanged;
+        public event EventHandler StyleChanged;
+        public event EventHandler SystemColorsChanged;
+        public event EventHandler TabIndexChanged;
+        public event EventHandler TabStopChanged;
+        public event EventHandler TextChanged;
+        public event EventHandler Validated;
+        public event CancelEventHandler Validating;
+        public event EventHandler ValueMemberChanged;
+        public event EventHandler VisibleChanged;
+        bool CanExtend(object target);
+        protected override Type GetControlInstanceType();
+        public short GetIndex(DriveListBox o);
+        protected override void HookUpControlEvents(object o);
+        public void ResetIndex(DriveListBox o);
+        public void SetIndex(DriveListBox o, short Index);
+        public bool ShouldSerializeIndex(DriveListBox o);
+    }
+    public class FileListBox : ListBox {
+        public FileListBox();
+        public bool Archive { get; set; }
+        public new object DataSource { get; set; }
+        public new string DisplayMember { get; set; }
+        public string FileName { get; set; }
+        public bool Hidden { get; set; }
+        public new int ItemHeight { get; set; }
+        public new ListBox.ObjectCollection Items { get; }
+        [System.Runtime.CompilerServices.IndexerName("Items")]
+        public string this[int Index] { get; }
+        public bool Normal { get; set; }
+        public string Path { get; set; }
+        public string Pattern { get; set; }
+        public bool ReadOnly { get; set; }
+        public new bool Sorted { get; }
+        public bool System { get; set; }
+        public new string ValueMember { get; set; }
+        public event EventHandler PathChange;
+        public event EventHandler PatternChange;
+        protected override void OnDoubleClick(EventArgs e);
+        protected virtual void OnPathChange(EventArgs e);
+        protected virtual void OnPatternChange(EventArgs e);
+        protected override void OnSelectedIndexChanged(EventArgs e);
+        public override void Refresh();
+    }
+    public class FileListBoxArray : BaseControlArray, IExtenderProvider {
+        public FileListBoxArray();
+        public FileListBoxArray(IContainer Container);
+        public FileListBox this[short Index] { get; }
+        public event EventHandler BackColorChanged;
+        public event EventHandler BindingContextChanged;
+        public event EventHandler CausesValidationChanged;
+        public event UICuesEventHandler ChangeUICues;
+        public event EventHandler ContextMenuChanged;
+        public event EventHandler CursorChanged;
+        public event EventHandler DataSourceChanged;
+        public event EventHandler DisplayMemberChanged;
+        public event EventHandler DockChanged;
+        public event EventHandler DoubleClick;
+        public event DragEventHandler DragDrop;
+        public event DragEventHandler DragEnter;
+        public event EventHandler DragLeave;
+        public event DragEventHandler DragOver;
+        public event DrawItemEventHandler DrawItem;
+        public event EventHandler EnabledChanged;
+        public event EventHandler Enter;
+        public event EventHandler FontChanged;
+        public event EventHandler ForeColorChanged;
+        public event GiveFeedbackEventHandler GiveFeedback;
+        public event HelpEventHandler HelpRequested;
+        public event EventHandler ImeModeChanged;
+        public event KeyEventHandler KeyDown;
+        public event KeyPressEventHandler KeyPress;
+        public event KeyEventHandler KeyUp;
+        public event LayoutEventHandler Layout;
+        public event EventHandler Leave;
+        public event EventHandler LocationChanged;
+        public event MeasureItemEventHandler MeasureItem;
+        public event MouseEventHandler MouseDown;
+        public event EventHandler MouseEnter;
+        public event EventHandler MouseHover;
+        public event EventHandler MouseLeave;
+        public event MouseEventHandler MouseMove;
+        public event MouseEventHandler MouseUp;
+        public event EventHandler Move;
+        public event EventHandler ParentChanged;
+        public event EventHandler PathChange;
+        public event EventHandler PatternChange;
+        public event QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
+        public event QueryContinueDragEventHandler QueryContinueDrag;
+        public event EventHandler Resize;
+        public event EventHandler RightToLeftChanged;
+        public event EventHandler SelectedIndexChanged;
+        public event EventHandler SelectedValueChanged;
+        public event EventHandler SizeChanged;
+        public event EventHandler StyleChanged;
+        public event EventHandler SystemColorsChanged;
+        public event EventHandler TabIndexChanged;
+        public event EventHandler TabStopChanged;
+        public event EventHandler Validated;
+        public event CancelEventHandler Validating;
+        public event EventHandler ValueMemberChanged;
+        public event EventHandler VisibleChanged;
+        bool CanExtend(object target);
+        protected override Type GetControlInstanceType();
+        public short GetIndex(FileListBox o);
+        protected override void HookUpControlEvents(object o);
+        public void ResetIndex(FileListBox o);
+        public void SetIndex(FileListBox o, short Index);
+        public bool ShouldSerializeIndex(FileListBox o);
+    }
+    public class FixedLengthString {
+        protected int m_nMaxChars;
+        protected string m_strValue;
+        public FixedLengthString(int MaxChars);
+        public FixedLengthString(int MaxChars, string InitialValue);
+        public string Value { get; set; }
+        public override string ToString();
+    }
+    public class FontDialogArray : BaseControlArray, IExtenderProvider {
+        public FontDialogArray();
+        public FontDialogArray(IContainer Container);
+        public FontDialog this[short Index] { get; }
+        public event EventHandler Apply;
+        public event EventHandler HelpRequest;
+        bool CanExtend(object target);
+        protected override Type GetControlInstanceType();
+        public short GetIndex(FontDialog o);
+        protected override void HookUpControlEvents(object o);
+        public void ResetIndex(FontDialog o);
+        public void SetIndex(FontDialog o, short Index);
+        public bool ShouldSerializeIndex(FontDialog o);
+    }
+    public enum FormShowConstants {
+        Modal = 1,
+        Modeless = 0,
+    }
+    public class GroupBoxArray : BaseControlArray, IExtenderProvider {
+        public GroupBoxArray();
+        public GroupBoxArray(IContainer Container);
+        public GroupBox this[short Index] { get; }
+        public event EventHandler AutoSizeChanged;
+        public event EventHandler BackColorChanged;
+        public event EventHandler BackgroundImageChanged;
+        public event EventHandler BackgroundImageLayoutChanged;
+        public event EventHandler BindingContextChanged;
+        public event EventHandler CausesValidationChanged;
+        public event UICuesEventHandler ChangeUICues;
+        public event EventHandler ClientSizeChanged;
+        public event EventHandler ContextMenuChanged;
+        public event EventHandler ContextMenuStripChanged;
+        public event ControlEventHandler ControlAdded;
+        public event ControlEventHandler ControlRemoved;
+        public event EventHandler CursorChanged;
+        public event EventHandler DockChanged;
+        public event DragEventHandler DragDrop;
+        public event DragEventHandler DragEnter;
+        public event EventHandler DragLeave;
+        public event DragEventHandler DragOver;
+        public event EventHandler EnabledChanged;
+        public event EventHandler Enter;
+        public event EventHandler FontChanged;
+        public event EventHandler ForeColorChanged;
+        public event GiveFeedbackEventHandler GiveFeedback;
+        public event HelpEventHandler HelpRequested;
+        public event EventHandler ImeModeChanged;
+        public event LayoutEventHandler Layout;
+        public event EventHandler Leave;
+        public event EventHandler LocationChanged;
+        public event EventHandler MarginChanged;
+        public event EventHandler MouseCaptureChanged;
+        public event EventHandler MouseHover;
+        public event EventHandler Move;
+        public event EventHandler PaddingChanged;
+        public event PaintEventHandler Paint;
+        public event EventHandler ParentChanged;
+        public event QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
+        public event QueryContinueDragEventHandler QueryContinueDrag;
+        public event EventHandler RegionChanged;
+        public event EventHandler Resize;
+        public event EventHandler RightToLeftChanged;
+        public event EventHandler SizeChanged;
+        public event EventHandler StyleChanged;
+        public event EventHandler SystemColorsChanged;
+        public event EventHandler TabIndexChanged;
+        public event EventHandler TextChanged;
+        public event EventHandler Validated;
+        public event CancelEventHandler Validating;
+        public event EventHandler VisibleChanged;
+        bool CanExtend(object target);
+        protected override Type GetControlInstanceType();
+        public short GetIndex(GroupBox o);
+        protected override void HookUpControlEvents(object o);
+        public void ResetIndex(GroupBox o);
+        public void SetIndex(GroupBox o, short Index);
+        public bool ShouldSerializeIndex(GroupBox o);
+    }
+    public class HScrollBarArray : BaseControlArray, IExtenderProvider {
+        public HScrollBarArray();
+        public HScrollBarArray(IContainer Container);
+        public HScrollBar this[short Index] { get; }
+        public event EventHandler BindingContextChanged;
+        public event EventHandler CausesValidationChanged;
+        public event UICuesEventHandler ChangeUICues;
+        public event EventHandler ClientSizeChanged;
+        public event EventHandler ContextMenuChanged;
+        public event EventHandler ContextMenuStripChanged;
+        public event ControlEventHandler ControlAdded;
+        public event ControlEventHandler ControlRemoved;
+        public event EventHandler CursorChanged;
+        public event EventHandler DockChanged;
+        public event DragEventHandler DragDrop;
+        public event DragEventHandler DragEnter;
+        public event EventHandler DragLeave;
+        public event DragEventHandler DragOver;
+        public event EventHandler EnabledChanged;
+        public event EventHandler Enter;
+        public event GiveFeedbackEventHandler GiveFeedback;
+        public event HelpEventHandler HelpRequested;
+        public event KeyEventHandler KeyDown;
+        public event KeyPressEventHandler KeyPress;
+        public event KeyEventHandler KeyUp;
+        public event LayoutEventHandler Layout;
+        public event EventHandler Leave;
+        public event EventHandler LocationChanged;
+        public event EventHandler MarginChanged;
+        public event EventHandler MouseCaptureChanged;
+        public event EventHandler MouseEnter;
+        public event EventHandler MouseHover;
+        public event EventHandler MouseLeave;
+        public event EventHandler Move;
+        public event EventHandler PaddingChanged;
+        public event EventHandler ParentChanged;
+        public event QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
+        public event QueryContinueDragEventHandler QueryContinueDrag;
+        public event EventHandler RegionChanged;
+        public event EventHandler Resize;
+        public event EventHandler RightToLeftChanged;
+        public event ScrollEventHandler Scroll;
+        public event EventHandler SizeChanged;
+        public event EventHandler StyleChanged;
+        public event EventHandler SystemColorsChanged;
+        public event EventHandler TabIndexChanged;
+        public event EventHandler TabStopChanged;
+        public event EventHandler Validated;
+        public event CancelEventHandler Validating;
+        public event EventHandler ValueChanged;
+        public event EventHandler VisibleChanged;
+        bool CanExtend(object target);
+        protected override Type GetControlInstanceType();
+        public short GetIndex(HScrollBar o);
+        protected override void HookUpControlEvents(object o);
+        public void ResetIndex(HScrollBar o);
+        public void SetIndex(HScrollBar o, short Index);
+        public bool ShouldSerializeIndex(HScrollBar o);
+    }
+    public interface IAccessor {
+        void AddRefAccessor(int hAccessor, ref int cRefCount);
+        void CreateAccessor(int accessorFlags, int cBindings, DBBINDING[] bindings, int cbRowSize, out int hAccessor, IntPtr pBindStatus);
+        void GetBindings(int hAccessor, out int accessorFlags, ref int cBindings, out IntPtr rgBindings);
+        void ReleaseAccessor(int hAccessor, ref int cRefCount);
+    }
+    public interface IChapteredRowset {
+        void AddRefChapter(int hChapter, out int cRefCount);
+        void ReleaseChapter(int hChapter, out int cRefCount);
+    }
+    public interface IColumnsInfo {
+        void GetColumnInfo(out int cColumns, out IntPtr pColumnInfo, out IntPtr pStringsBuffer);
+        void MapColumnIDs(int cColumnIDs, DBID[] columnIDs, int[] rgColumns);
+    }
+    public interface IConnectionPoint {
+        void Advise(IntPtr sink, out int cookie);
+        void EnumConnections(out IEnumConnections enumC);
+        void GetConnectionInterface(out Guid piid);
+        void GetConnectionPointContainer(out IConnectionPointContainer cpc);
+        void Unadvise(int cookie);
+    }
+    public interface IConnectionPointContainer {
+        void EnumConnectionPoints(out IEnumConnectionPoints enumC);
+        void FindConnectionPoint(ref Guid riid, out IConnectionPoint cp);
+    }
+    public interface IDataFormat {
+        void Clone(out IDataFormat newObject);
+        void Convert(int cookie, object from, out object varTo);
+        void Default(out bool fDefault);
+        void GetBinding(VarEnum vtPropHint, int rgfDataFormat, IRowset rowset, ref DBCOLUMNINFO columnInfo, out DBBINDING binding, out int size, out int cookie);
+        void GetData(int cookie, IntPtr from, out object varTo, out int dbStatus, object pObject);
+        void GetLcid(out int lcid);
+        void GetRawData(int cookie, IntPtr from, out object varTo, out int dbStatus);
+        void GetSubFormatType(out int subFormatType);
+        void ReleaseBinding(int cookie);
+        void ReleaseData(int cookie, IntPtr pv);
+        void SetData(int cookie, ref object from, IntPtr pVarTo, object pObject);
+        void SetLcid(int lcid);
+        void SetRawData(int cookie, object from, IntPtr pVarTo);
+        void SetSubFormatType(int subFormatType);
+    }
+    public interface IDataFormatDisp
+    public interface IEnumConnectionPoints {
+        void Clone(out IEnumConnectionPoints ecp);
+        void Next(int cConnections, out IConnectionPoint[] cp, out int cFetched);
+        void Reset();
+        void Skip(int cConnections);
+    }
+    public interface IEnumConnections {
+        void Clone(out IEnumConnections ec);
+        void Next(int cConnections, out CONNECTDATA[] cd, out int cFetched);
+        void Reset();
+        void Skip(int cConnections);
+    }
+    public class ImageListArray : BaseControlArray, IExtenderProvider {
+        public ImageListArray();
+        public ImageListArray(IContainer Container);
+        public ImageList this[short Index] { get; }
+        bool CanExtend(object target);
+        protected override Type GetControlInstanceType();
+        public short GetIndex(ImageList o);
+        protected override void HookUpControlEvents(object o);
+        public void ResetIndex(ImageList o);
+        public void SetIndex(ImageList o, short Index);
+        public bool ShouldSerializeIndex(ImageList o);
+    }
+    public interface IRowPosition {
+        void ClearRowPosition();
+        void GetRowPosition(out int hChapter, out int hRow, out int dbPositionFlags);
+        void GetRowset(ref Guid iid, out object rowset);
+        void Initialize(object rowset);
+        void SetRowPosition(int hChapter, int hRow, int dbPositionFlags);
+    }
+    public interface IRowPositionChange {
+        int OnRowPositionChange(int dbReason, int eventPhase, int fCantDeny);
+    }
+    public interface IRowset {
+        void AddRefRows(int cRows, int[] hRows, out int[] refCounts, out int[] rowStatus);
+        void GetData(int hRow, int hAccessor, IntPtr pData);
+        void GetNextRows(int hChapter, int lRowsOffset, int cRows, out int cRowsObtained, ref int[] hRows);
+        int ReleaseRows(int cRows, int[] hRows, IntPtr rowOptions, IntPtr rowRefCounts, IntPtr rgRowStatus);
+        int RestartPosition(int hChapter);
+    }
+    public interface IRowsetChange {
+        void DeleteRows(int hChapterReserved, int cRows, int[] rghRows, out int[] rgRowStatus);
+        void InsertRow(int hChapterReserved, int hAccessor, IntPtr pData, out int hRow);
+        void SetData(int hRow, int hAccessor, IntPtr pData);
+    }
+    public interface IRowsetIdentity {
+        int IsSameRow(int hThisRow, int hThatRow);
+    }
+    public interface IRowsetInfo {
+        void GetProperties(int cPropertyIDSets, DBPROPIDSET[] rgPropertyIDSets, out int cPropertySets, out IntPtr prgPropertySets);
+        void GetReferencedRowset(int iOrdinal, Guid riid, out object referencedRowset);
+        void GetSpecification(Guid riid, out object specification);
+    }
+    public interface IRowsetNotify {
+        int OnFieldChange(IRowset rowset, int hRow, int cColumns, int[] rgColumns, int dbReason, int eventPhase, int fCantDeny);
+        int OnRowChange(IRowset rowset, int cRows, int[] rghRows, int dbReason, int eventPhase, int fCantDeny);
+        int OnRowsetChange(IRowset rowset, int dbReason, int eventPhase, int fCantDeny);
+    }
+    public class LabelArray : BaseControlArray, IExtenderProvider {
+        public LabelArray();
+        public LabelArray(IContainer Container);
+        public Label this[short Index] { get; }
+        public event EventHandler AutoSizeChanged;
+        public event EventHandler BackColorChanged;
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
+        public event HelpEventHandler HelpRequested;
+        public event LayoutEventHandler Layout;
+        public event EventHandler Leave;
+        public event EventHandler LocationChanged;
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
+        public event EventHandler Move;
+        public event EventHandler PaddingChanged;
+        public event PaintEventHandler Paint;
+        public event EventHandler ParentChanged;
+        public event QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
+        public event QueryContinueDragEventHandler QueryContinueDrag;
+        public event EventHandler RegionChanged;
+        public event EventHandler Resize;
+        public event EventHandler RightToLeftChanged;
+        public event EventHandler SizeChanged;
+        public event EventHandler StyleChanged;
+        public event EventHandler SystemColorsChanged;
+        public event EventHandler TabIndexChanged;
+        public event EventHandler TextAlignChanged;
+        public event EventHandler TextChanged;
+        public event EventHandler Validated;
+        public event CancelEventHandler Validating;
+        public event EventHandler VisibleChanged;
+        bool CanExtend(object target);
+        protected override Type GetControlInstanceType();
+        public short GetIndex(Label o);
+        protected override void HookUpControlEvents(object o);
+        public void ResetIndex(Label o);
+        public void SetIndex(Label o, short Index);
+        public bool ShouldSerializeIndex(Label o);
+    }
+    public class ListBoxArray : BaseControlArray, IExtenderProvider {
+        public ListBoxArray();
+        public ListBoxArray(IContainer Container);
+        public ListBox this[short Index] { get; }
+        public event EventHandler BackColorChanged;
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
+        public event EventHandler DataSourceChanged;
+        public event EventHandler DisplayMemberChanged;
+        public event EventHandler DockChanged;
+        public event EventHandler DoubleClick;
+        public event DragEventHandler DragDrop;
+        public event DragEventHandler DragEnter;
+        public event EventHandler DragLeave;
+        public event DragEventHandler DragOver;
+        public event DrawItemEventHandler DrawItem;
+        public event EventHandler EnabledChanged;
+        public event EventHandler Enter;
+        public event EventHandler FontChanged;
+        public event EventHandler ForeColorChanged;
+        public event ListControlConvertEventHandler Format;
+        public event EventHandler FormatStringChanged;
+        public event EventHandler FormattingEnabledChanged;
+        public event GiveFeedbackEventHandler GiveFeedback;
+        public event HelpEventHandler HelpRequested;
+        public event EventHandler ImeModeChanged;
+        public event KeyEventHandler KeyDown;
+        public event KeyPressEventHandler KeyPress;
+        public event KeyEventHandler KeyUp;
+        public event LayoutEventHandler Layout;
+        public event EventHandler Leave;
+        public event EventHandler LocationChanged;
+        public event EventHandler MarginChanged;
+        public event MeasureItemEventHandler MeasureItem;
+        public event EventHandler MouseCaptureChanged;
+        public event MouseEventHandler MouseClick;
+        public event MouseEventHandler MouseDoubleClick;
+        public event MouseEventHandler MouseDown;
+        public event EventHandler MouseEnter;
+        public event EventHandler MouseHover;
+        public event EventHandler MouseLeave;
+        public event MouseEventHandler MouseMove;
+        public event MouseEventHandler MouseUp;
+        public event EventHandler Move;
+        public event EventHandler PaddingChanged;
+        public event EventHandler ParentChanged;
+        public event QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
+        public event QueryContinueDragEventHandler QueryContinueDrag;
+        public event EventHandler RegionChanged;
+        public event EventHandler Resize;
+        public event EventHandler RightToLeftChanged;
+        public event EventHandler SelectedIndexChanged;
+        public event EventHandler SelectedValueChanged;
+        public event EventHandler SizeChanged;
+        public event EventHandler StyleChanged;
+        public event EventHandler SystemColorsChanged;
+        public event EventHandler TabIndexChanged;
+        public event EventHandler TabStopChanged;
+        public event EventHandler Validated;
+        public event CancelEventHandler Validating;
+        public event EventHandler ValueMemberChanged;
+        public event EventHandler VisibleChanged;
+        bool CanExtend(object target);
+        protected override Type GetControlInstanceType();
+        public short GetIndex(ListBox o);
+        protected override void HookUpControlEvents(object o);
+        public void ResetIndex(ListBox o);
+        public void SetIndex(ListBox o, short Index);
+        public bool ShouldSerializeIndex(ListBox o);
+    }
+    public class ListBoxItem {
+        public int ItemData;
+        public string ItemString;
+        public ListBoxItem(string ItemString);
+        public ListBoxItem(string ItemString, int ItemData);
+        public override string ToString();
+    }
+    public class ListViewArray : BaseControlArray, IExtenderProvider {
+        public ListViewArray();
+        public ListViewArray(IContainer Container);
+        public ListView this[short Index] { get; }
+        public event LabelEditEventHandler AfterLabelEdit;
+        public event EventHandler BackColorChanged;
+        public event EventHandler BackgroundImageChanged;
+        public event LabelEditEventHandler BeforeLabelEdit;
+        public event EventHandler BindingContextChanged;
+        public event CacheVirtualItemsEventHandler CacheVirtualItems;
+        public event EventHandler CausesValidationChanged;
+        public event UICuesEventHandler ChangeUICues;
+        public event EventHandler Click;
+        public event EventHandler ClientSizeChanged;
+        public event ColumnClickEventHandler ColumnClick;
+        public event ColumnReorderedEventHandler ColumnReordered;
+        public event ColumnWidthChangedEventHandler ColumnWidthChanged;
+        public event ColumnWidthChangingEventHandler ColumnWidthChanging;
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
+        public event DrawListViewColumnHeaderEventHandler DrawColumnHeader;
+        public event DrawListViewItemEventHandler DrawItem;
+        public event DrawListViewSubItemEventHandler DrawSubItem;
+        public event EventHandler EnabledChanged;
+        public event EventHandler Enter;
+        public event EventHandler FontChanged;
+        public event EventHandler ForeColorChanged;
+        public event GiveFeedbackEventHandler GiveFeedback;
+        public event HelpEventHandler HelpRequested;
+        public event EventHandler ImeModeChanged;
+        public event EventHandler ItemActivate;
+        public event ItemCheckEventHandler ItemCheck;
+        public event ItemCheckedEventHandler ItemChecked;
+        public event ItemDragEventHandler ItemDrag;
+        public event ListViewItemMouseHoverEventHandler ItemMouseHover;
+        public event ListViewItemSelectionChangedEventHandler ItemSelectionChanged;
+        public event KeyEventHandler KeyDown;
+        public event KeyPressEventHandler KeyPress;
+        public event KeyEventHandler KeyUp;
+        public event LayoutEventHandler Layout;
+        public event EventHandler Leave;
+        public event EventHandler LocationChanged;
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
+        public event EventHandler Move;
+        public event EventHandler PaddingChanged;
+        public event EventHandler ParentChanged;
+        public event QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
+        public event QueryContinueDragEventHandler QueryContinueDrag;
+        public event EventHandler RegionChanged;
+        public event EventHandler Resize;
+        public event RetrieveVirtualItemEventHandler RetrieveVirtualItem;
+        public event EventHandler RightToLeftChanged;
+        public event EventHandler RightToLeftLayoutChanged;
+        public event SearchForVirtualItemEventHandler SearchForVirtualItem;
+        public event EventHandler SelectedIndexChanged;
+        public event EventHandler SizeChanged;
+        public event EventHandler StyleChanged;
+        public event EventHandler SystemColorsChanged;
+        public event EventHandler TabIndexChanged;
+        public event EventHandler TabStopChanged;
+        public event EventHandler Validated;
+        public event CancelEventHandler Validating;
+        public event ListViewVirtualItemsSelectionRangeChangedEventHandler VirtualItemsSelectionRangeChanged;
+        public event EventHandler VisibleChanged;
+        bool CanExtend(object target);
+        protected override Type GetControlInstanceType();
+        public short GetIndex(ListView o);
+        protected override void HookUpControlEvents(object o);
+        public void ResetIndex(ListView o);
+        public void SetIndex(ListView o, short Index);
+        public bool ShouldSerializeIndex(ListView o);
+    }
+    public enum LoadResConstants {
+        ResBitmap = 0,
+        ResCursor = 2,
+        ResIcon = 1,
+    }
+    public class MaskedTextBoxArray : BaseControlArray, IExtenderProvider {
+        public MaskedTextBoxArray();
+        public MaskedTextBoxArray(IContainer Container);
+        public MaskedTextBox this[short Index] { get; }
+        public event EventHandler BackColorChanged;
+        public event EventHandler BindingContextChanged;
+        public event EventHandler BorderStyleChanged;
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
+        public event HelpEventHandler HelpRequested;
+        public event EventHandler HideSelectionChanged;
+        public event EventHandler ImeModeChanged;
+        public event EventHandler IsOverwriteModeChanged;
+        public event KeyEventHandler KeyDown;
+        public event KeyPressEventHandler KeyPress;
+        public event KeyEventHandler KeyUp;
+        public event LayoutEventHandler Layout;
+        public event EventHandler Leave;
+        public event EventHandler LocationChanged;
+        public event EventHandler MarginChanged;
+        public event EventHandler MaskChanged;
+        public event MaskInputRejectedEventHandler MaskInputRejected;
+        public event EventHandler ModifiedChanged;
+        public event EventHandler MouseCaptureChanged;
+        public event MouseEventHandler MouseClick;
+        public event MouseEventHandler MouseDoubleClick;
+        public event MouseEventHandler MouseDown;
+        public event EventHandler MouseEnter;
+        public event EventHandler MouseHover;
+        public event EventHandler MouseLeave;
+        public event MouseEventHandler MouseMove;
+        public event MouseEventHandler MouseUp;
+        public event EventHandler Move;
+        public event EventHandler ParentChanged;
+        public event QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
+        public event QueryContinueDragEventHandler QueryContinueDrag;
+        public event EventHandler ReadOnlyChanged;
+        public event EventHandler RegionChanged;
+        public event EventHandler Resize;
+        public event EventHandler RightToLeftChanged;
+        public event EventHandler SizeChanged;
+        public event EventHandler StyleChanged;
+        public event EventHandler SystemColorsChanged;
+        public event EventHandler TabIndexChanged;
+        public event EventHandler TabStopChanged;
+        public event EventHandler TextAlignChanged;
+        public event EventHandler TextChanged;
+        public event TypeValidationEventHandler TypeValidationCompleted;
+        public event EventHandler Validated;
+        public event CancelEventHandler Validating;
+        public event EventHandler VisibleChanged;
+        bool CanExtend(object target);
+        protected override Type GetControlInstanceType();
+        public short GetIndex(MaskedTextBox o);
+        protected override void HookUpControlEvents(object o);
+        public void ResetIndex(MaskedTextBox o);
+        public void SetIndex(MaskedTextBox o, short Index);
+        public bool ShouldSerializeIndex(MaskedTextBox o);
+    }
+    public class MBinding : DBinding, IDisposable {
+        bool DataChanged { get; set; }
+        string DataField { get; }
+        IDataFormatDisp DataFormat { get; set; }
+        string Key { get; }
+        object Object { get; }
+        string PropertyName { get; }
+        void Dispose();
+        protected virtual void Dispose(bool disposing);
+    }
+    public class MBindingCollection : DBindingCollection, IDisposable {
+        public MBindingCollection();
+        int Count { get; }
+        string DataMember { get; set; }
+        DataSource DataSource { get; set; }
+        DBinding this[object index] { get; }
+        UpdateMode UpdateMode { get; set; }
+        DBinding Add(object obj, string propertyName, string dataField, IDataFormatDisp dataFormat=null, string key=null);
+        public DBinding Add(object obj, string propertyName, string dataField, IDataFormatDisp dataFormat, string key, bool immediateBind);
+        void Clear();
+        void Dispose();
+        protected void Dispose(bool disposing);
+        IEnumerator GetEnumerator();
+        void Remove(object index);
+        public void SavePendingChanges();
+        void UpdateControls();
+    }
+    public class MenuItemArray : BaseControlArray, IExtenderProvider {
+        public MenuItemArray();
+        public MenuItemArray(IContainer Container);
+        public MenuItem this[short Index] { get; }
+        public event EventHandler Click;
+        public event DrawItemEventHandler DrawItem;
+        public event MeasureItemEventHandler MeasureItem;
+        public event EventHandler Popup;
+        public event EventHandler Select;
+        bool CanExtend(object target);
+        protected override Type GetControlInstanceType();
+        public short GetIndex(MenuItem o);
+        protected override void HookUpControlEvents(object o);
+        public void ResetIndex(MenuItem o);
+        public void SetIndex(MenuItem o, short Index);
+        public bool ShouldSerializeIndex(MenuItem o);
+    }
+    public enum MouseButtonConstants {
+        LeftButton = 1,
+        MiddleButton = 4,
+        RightButton = 2,
+    }
+    public class OpenFileDialogArray : BaseControlArray, IExtenderProvider {
+        public OpenFileDialogArray();
+        public OpenFileDialogArray(IContainer Container);
+        public OpenFileDialog this[short Index] { get; }
+        public event CancelEventHandler FileOk;
+        public event EventHandler HelpRequest;
+        bool CanExtend(object target);
+        protected override Type GetControlInstanceType();
+        public short GetIndex(OpenFileDialog o);
+        protected override void HookUpControlEvents(object o);
+        public void ResetIndex(OpenFileDialog o);
+        public void SetIndex(OpenFileDialog o, short Index);
+        public bool ShouldSerializeIndex(OpenFileDialog o);
+    }
+    public class PanelArray : BaseControlArray, IExtenderProvider {
+        public PanelArray();
+        public PanelArray(IContainer Container);
+        public Panel this[short Index] { get; }
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
+        public event HelpEventHandler HelpRequested;
+        public event EventHandler ImeModeChanged;
+        public event LayoutEventHandler Layout;
+        public event EventHandler Leave;
+        public event EventHandler LocationChanged;
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
+        public event EventHandler Move;
+        public event EventHandler PaddingChanged;
+        public event PaintEventHandler Paint;
+        public event EventHandler ParentChanged;
+        public event QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
+        public event QueryContinueDragEventHandler QueryContinueDrag;
+        public event EventHandler RegionChanged;
+        public event EventHandler Resize;
+        public event EventHandler RightToLeftChanged;
+        public event ScrollEventHandler Scroll;
+        public event EventHandler SizeChanged;
+        public event EventHandler StyleChanged;
+        public event EventHandler SystemColorsChanged;
+        public event EventHandler TabIndexChanged;
+        public event EventHandler TabStopChanged;
+        public event EventHandler Validated;
+        public event CancelEventHandler Validating;
+        public event EventHandler VisibleChanged;
+        bool CanExtend(object target);
+        protected override Type GetControlInstanceType();
+        public short GetIndex(Panel o);
+        protected override void HookUpControlEvents(object o);
+        public void ResetIndex(Panel o);
+        public void SetIndex(Panel o, short Index);
+        public bool ShouldSerializeIndex(Panel o);
+    }
+    public class PictureBoxArray : BaseControlArray, IExtenderProvider {
+        public PictureBoxArray();
+        public PictureBoxArray(IContainer Container);
+        public PictureBox this[short Index] { get; }
+        public event EventHandler BackColorChanged;
+        public event EventHandler BackgroundImageChanged;
+        public event EventHandler BackgroundImageLayoutChanged;
+        public event EventHandler BindingContextChanged;
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
+        public event GiveFeedbackEventHandler GiveFeedback;
+        public event HelpEventHandler HelpRequested;
+        public event LayoutEventHandler Layout;
+        public event AsyncCompletedEventHandler LoadCompleted;
+        public event ProgressChangedEventHandler LoadProgressChanged;
+        public event EventHandler LocationChanged;
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
+        public event EventHandler Move;
+        public event EventHandler PaddingChanged;
+        public event PaintEventHandler Paint;
+        public event EventHandler ParentChanged;
+        public event QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
+        public event QueryContinueDragEventHandler QueryContinueDrag;
+        public event EventHandler RegionChanged;
+        public event EventHandler Resize;
+        public event EventHandler SizeChanged;
+        public event EventHandler SizeModeChanged;
+        public event EventHandler StyleChanged;
+        public event EventHandler SystemColorsChanged;
+        public event EventHandler Validated;
+        public event CancelEventHandler Validating;
+        public event EventHandler VisibleChanged;
+        bool CanExtend(object target);
+        protected override Type GetControlInstanceType();
+        public short GetIndex(PictureBox o);
+        protected override void HookUpControlEvents(object o);
+        public void ResetIndex(PictureBox o);
+        public void SetIndex(PictureBox o, short Index);
+        public bool ShouldSerializeIndex(PictureBox o);
+    }
+    public class PrintDialogArray : BaseControlArray, IExtenderProvider {
+        public PrintDialogArray();
+        public PrintDialogArray(IContainer Container);
+        public PrintDialog this[short Index] { get; }
+        public event EventHandler HelpRequest;
+        bool CanExtend(object target);
+        protected override Type GetControlInstanceType();
+        public short GetIndex(PrintDialog o);
+        protected override void HookUpControlEvents(object o);
+        public void ResetIndex(PrintDialog o);
+        public void SetIndex(PrintDialog o, short Index);
+        public bool ShouldSerializeIndex(PrintDialog o);
+    }
+    public class ProgressBarArray : BaseControlArray, IExtenderProvider {
+        public ProgressBarArray();
+        public ProgressBarArray(IContainer Container);
+        public ProgressBar this[short Index] { get; }
+        public event EventHandler BackColorChanged;
+        public event EventHandler BindingContextChanged;
+        public event UICuesEventHandler ChangeUICues;
+        public event EventHandler Click;
+        public event EventHandler ClientSizeChanged;
+        public event EventHandler ContextMenuChanged;
+        public event EventHandler ContextMenuStripChanged;
+        public event ControlEventHandler ControlAdded;
+        public event ControlEventHandler ControlRemoved;
+        public event EventHandler CursorChanged;
+        public event EventHandler DockChanged;
+        public event DragEventHandler DragDrop;
+        public event DragEventHandler DragEnter;
+        public event EventHandler DragLeave;
+        public event DragEventHandler DragOver;
+        public event EventHandler EnabledChanged;
+        public event EventHandler ForeColorChanged;
+        public event GiveFeedbackEventHandler GiveFeedback;
+        public event HelpEventHandler HelpRequested;
+        public event LayoutEventHandler Layout;
+        public event EventHandler LocationChanged;
+        public event EventHandler MarginChanged;
+        public event EventHandler MouseCaptureChanged;
+        public event MouseEventHandler MouseClick;
+        public event MouseEventHandler MouseDown;
+        public event EventHandler MouseEnter;
+        public event EventHandler MouseHover;
+        public event EventHandler MouseLeave;
+        public event MouseEventHandler MouseMove;
+        public event MouseEventHandler MouseUp;
+        public event EventHandler Move;
+        public event EventHandler PaddingChanged;
+        public event EventHandler ParentChanged;
+        public event QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
+        public event QueryContinueDragEventHandler QueryContinueDrag;
+        public event EventHandler RegionChanged;
+        public event EventHandler Resize;
+        public event EventHandler RightToLeftChanged;
+        public event EventHandler RightToLeftLayoutChanged;
+        public event EventHandler SizeChanged;
+        public event EventHandler StyleChanged;
+        public event EventHandler SystemColorsChanged;
+        public event EventHandler TabIndexChanged;
+        public event EventHandler Validated;
+        public event CancelEventHandler Validating;
+        public event EventHandler VisibleChanged;
+        bool CanExtend(object target);
+        protected override Type GetControlInstanceType();
+        public short GetIndex(ProgressBar o);
+        protected override void HookUpControlEvents(object o);
+        public void ResetIndex(ProgressBar o);
+        public void SetIndex(ProgressBar o, short Index);
+        public bool ShouldSerializeIndex(ProgressBar o);
+    }
+    public class RadioButtonArray : BaseControlArray, IExtenderProvider {
+        public RadioButtonArray();
+        public RadioButtonArray(IContainer Container);
+        public RadioButton this[short Index] { get; }
+        public event EventHandler AppearanceChanged;
+        public event EventHandler AutoSizeChanged;
+        public event EventHandler BackColorChanged;
+        public event EventHandler BackgroundImageChanged;
+        public event EventHandler BackgroundImageLayoutChanged;
+        public event EventHandler BindingContextChanged;
+        public event EventHandler CausesValidationChanged;
+        public event UICuesEventHandler ChangeUICues;
+        public event EventHandler CheckedChanged;
+        public event EventHandler Click;
+        public event EventHandler ClientSizeChanged;
+        public event EventHandler ContextMenuChanged;
+        public event EventHandler ContextMenuStripChanged;
+        public event ControlEventHandler ControlAdded;
+        public event ControlEventHandler ControlRemoved;
+        public event EventHandler CursorChanged;
+        public event EventHandler DockChanged;
+        public event DragEventHandler DragDrop;
+        public event DragEventHandler DragEnter;
+        public event EventHandler DragLeave;
+        public event DragEventHandler DragOver;
+        public event EventHandler EnabledChanged;
+        public event EventHandler Enter;
+        public event EventHandler FontChanged;
+        public event EventHandler ForeColorChanged;
+        public event GiveFeedbackEventHandler GiveFeedback;
+        public event HelpEventHandler HelpRequested;
+        public event KeyEventHandler KeyDown;
+        public event KeyPressEventHandler KeyPress;
+        public event KeyEventHandler KeyUp;
+        public event LayoutEventHandler Layout;
+        public event EventHandler Leave;
+        public event EventHandler LocationChanged;
+        public event EventHandler MarginChanged;
+        public event EventHandler MouseCaptureChanged;
+        public event MouseEventHandler MouseClick;
+        public event MouseEventHandler MouseDown;
+        public event EventHandler MouseEnter;
+        public event EventHandler MouseHover;
+        public event EventHandler MouseLeave;
+        public event MouseEventHandler MouseMove;
+        public event MouseEventHandler MouseUp;
+        public event EventHandler Move;
+        public event EventHandler PaddingChanged;
+        public event PaintEventHandler Paint;
+        public event EventHandler ParentChanged;
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
+        bool CanExtend(object target);
+        protected override Type GetControlInstanceType();
+        public short GetIndex(RadioButton o);
+        protected override void HookUpControlEvents(object o);
+        public void ResetIndex(RadioButton o);
+        public void SetIndex(RadioButton o, short Index);
+        public bool ShouldSerializeIndex(RadioButton o);
+    }
+    public class RichTextBoxArray : BaseControlArray, IExtenderProvider {
+        public RichTextBoxArray();
+        public RichTextBoxArray(IContainer Container);
+        public RichTextBox this[short Index] { get; }
+        public event EventHandler AcceptsTabChanged;
+        public event EventHandler BackColorChanged;
+        public event EventHandler BindingContextChanged;
+        public event EventHandler BorderStyleChanged;
+        public event EventHandler CausesValidationChanged;
+        public event UICuesEventHandler ChangeUICues;
+        public event EventHandler Click;
+        public event EventHandler ClientSizeChanged;
+        public event ContentsResizedEventHandler ContentsResized;
+        public event EventHandler ContextMenuChanged;
+        public event EventHandler ContextMenuStripChanged;
+        public event ControlEventHandler ControlAdded;
+        public event ControlEventHandler ControlRemoved;
+        public event EventHandler CursorChanged;
+        public event EventHandler DockChanged;
+        public event EventHandler DoubleClick;
+        public event EventHandler EnabledChanged;
+        public event EventHandler Enter;
+        public event EventHandler FontChanged;
+        public event EventHandler ForeColorChanged;
+        public event HelpEventHandler HelpRequested;
+        public event EventHandler HideSelectionChanged;
+        public event EventHandler HScroll;
+        public event EventHandler ImeChange;
+        public event EventHandler ImeModeChanged;
+        public event KeyEventHandler KeyDown;
+        public event KeyPressEventHandler KeyPress;
+        public event KeyEventHandler KeyUp;
+        public event LayoutEventHandler Layout;
+        public event EventHandler Leave;
+        public event LinkClickedEventHandler LinkClicked;
+        public event EventHandler LocationChanged;
+        public event EventHandler MarginChanged;
+        public event EventHandler ModifiedChanged;
+        public event EventHandler MouseCaptureChanged;
+        public event MouseEventHandler MouseClick;
+        public event MouseEventHandler MouseDoubleClick;
+        public event MouseEventHandler MouseDown;
+        public event EventHandler MouseEnter;
+        public event EventHandler MouseHover;
+        public event EventHandler MouseLeave;
+        public event MouseEventHandler MouseMove;
+        public event MouseEventHandler MouseUp;
+        public event EventHandler Move;
+        public event EventHandler MultilineChanged;
+        public event EventHandler ParentChanged;
+        public event EventHandler Protected;
+        public event QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
+        public event EventHandler ReadOnlyChanged;
+        public event EventHandler RegionChanged;
+        public event EventHandler Resize;
+        public event EventHandler RightToLeftChanged;
+        public event EventHandler SelectionChanged;
+        public event EventHandler SizeChanged;
+        public event EventHandler StyleChanged;
+        public event EventHandler SystemColorsChanged;
+        public event EventHandler TabIndexChanged;
+        public event EventHandler TabStopChanged;
+        public event EventHandler TextChanged;
+        public event EventHandler Validated;
+        public event CancelEventHandler Validating;
+        public event EventHandler VisibleChanged;
+        public event EventHandler VScroll;
+        bool CanExtend(object target);
+        protected override Type GetControlInstanceType();
+        public short GetIndex(RichTextBox o);
+        protected override void HookUpControlEvents(object o);
+        public void ResetIndex(RichTextBox o);
+        public void SetIndex(RichTextBox o, short Index);
+        public bool ShouldSerializeIndex(RichTextBox o);
+    }
+    public class SaveFileDialogArray : BaseControlArray, IExtenderProvider {
+        public SaveFileDialogArray();
+        public SaveFileDialogArray(IContainer Container);
+        public SaveFileDialog this[short Index] { get; }
+        public event CancelEventHandler FileOk;
+        public event EventHandler HelpRequest;
+        bool CanExtend(object target);
+        protected override Type GetControlInstanceType();
+        public short GetIndex(SaveFileDialog o);
+        protected override void HookUpControlEvents(object o);
+        public void ResetIndex(SaveFileDialog o);
+        public void SetIndex(SaveFileDialog o, short Index);
+        public bool ShouldSerializeIndex(SaveFileDialog o);
+    }
+    public enum ScaleMode {
+        Centimeters = 7,
+        Characters = 4,
+        Himetric = 8,
+        Inches = 5,
+        Millimeters = 6,
+        Points = 2,
+    }
+    public enum ShiftConstants {
+        AltMask = 4,
+        CtrlMask = 2,
+        ShiftMask = 1,
+    }
+    public sealed class SRDescriptionAttribute : DescriptionAttribute {
+        public SRDescriptionAttribute(string description);
+        public override string Description { get; }
+    }
+    public class StatusBarArray : BaseControlArray, IExtenderProvider {
+        public StatusBarArray();
+        public StatusBarArray(IContainer Container);
+        public StatusBar this[short Index] { get; }
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
+        public event StatusBarDrawItemEventHandler DrawItem;
+        public event EventHandler EnabledChanged;
+        public event EventHandler Enter;
+        public event EventHandler FontChanged;
+        public event GiveFeedbackEventHandler GiveFeedback;
+        public event HelpEventHandler HelpRequested;
+        public event KeyEventHandler KeyDown;
+        public event KeyPressEventHandler KeyPress;
+        public event KeyEventHandler KeyUp;
+        public event LayoutEventHandler Layout;
+        public event EventHandler Leave;
+        public event EventHandler LocationChanged;
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
+        public event EventHandler Move;
+        public event EventHandler PaddingChanged;
+        public event StatusBarPanelClickEventHandler PanelClick;
+        public event EventHandler ParentChanged;
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
+        bool CanExtend(object target);
+        protected override Type GetControlInstanceType();
+        public short GetIndex(StatusBar o);
+        protected override void HookUpControlEvents(object o);
+        public void ResetIndex(StatusBar o);
+        public void SetIndex(StatusBar o, short Index);
+        public bool ShouldSerializeIndex(StatusBar o);
+    }
+    public class StatusStripArray : BaseControlArray, IExtenderProvider {
+        public StatusStripArray();
+        public StatusStripArray(IContainer Container);
+        public StatusStrip this[short Index] { get; }
+        public event EventHandler AutoSizeChanged;
+        public event EventHandler BackColorChanged;
+        public event EventHandler BackgroundImageChanged;
+        public event EventHandler BackgroundImageLayoutChanged;
+        public event EventHandler BeginDrag;
+        public event EventHandler BindingContextChanged;
+        public event UICuesEventHandler ChangeUICues;
+        public event EventHandler Click;
+        public event EventHandler ClientSizeChanged;
+        public event EventHandler ContextMenuChanged;
+        public event EventHandler ContextMenuStripChanged;
+        public event EventHandler DockChanged;
+        public event EventHandler DoubleClick;
+        public event DragEventHandler DragDrop;
+        public event DragEventHandler DragEnter;
+        public event EventHandler DragLeave;
+        public event DragEventHandler DragOver;
+        public event EventHandler EnabledChanged;
+        public event EventHandler EndDrag;
+        public event EventHandler Enter;
+        public event EventHandler FontChanged;
+        public event GiveFeedbackEventHandler GiveFeedback;
+        public event HelpEventHandler HelpRequested;
+        public event EventHandler ImeModeChanged;
+        public event ToolStripItemEventHandler ItemAdded;
+        public event ToolStripItemClickedEventHandler ItemClicked;
+        public event ToolStripItemEventHandler ItemRemoved;
+        public event KeyEventHandler KeyDown;
+        public event KeyPressEventHandler KeyPress;
+        public event KeyEventHandler KeyUp;
+        public event LayoutEventHandler Layout;
+        public event EventHandler LayoutCompleted;
+        public event EventHandler LayoutStyleChanged;
+        public event EventHandler Leave;
+        public event EventHandler LocationChanged;
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
+        public event EventHandler Move;
+        public event PaintEventHandler Paint;
+        public event PaintEventHandler PaintGrip;
+        public event EventHandler ParentChanged;
+        public event QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
+        public event QueryContinueDragEventHandler QueryContinueDrag;
+        public event EventHandler RegionChanged;
+        public event EventHandler Resize;
+        public event EventHandler RightToLeftChanged;
+        public event ScrollEventHandler Scroll;
+        public event EventHandler SizeChanged;
+        public event EventHandler StyleChanged;
+        public event EventHandler SystemColorsChanged;
+        public event EventHandler TabIndexChanged;
+        public event EventHandler TabStopChanged;
+        public event EventHandler TextChanged;
+        public event EventHandler Validated;
+        public event CancelEventHandler Validating;
+        public event EventHandler VisibleChanged;
+        bool CanExtend(object target);
+        protected override Type GetControlInstanceType();
+        public short GetIndex(StatusStrip o);
+        protected override void HookUpControlEvents(object o);
+        public void ResetIndex(StatusStrip o);
+        public void SetIndex(StatusStrip o, short Index);
+        public bool ShouldSerializeIndex(StatusStrip o);
+    }
+    public sealed class Support {
+        public static Array CopyArray(Array SourceArray);
+        public static object CursorToIPicture(Cursor curs);
+        public static bool Eqv(bool a, bool b);
+        public static byte Eqv(byte a, byte b);
+        public static short Eqv(short a, short b);
+        public static int Eqv(int a, int b);
+        public static long Eqv(long a, long b);
+        public static object Eqv(object a, object b);
+        public static Font FontChangeBold(Font CurrentFont, bool Bold);
+        public static Font FontChangeGdiCharSet(Font CurrentFont, byte GdiCharSet);
+        public static Font FontChangeItalic(Font CurrentFont, bool Italic);
+        public static Font FontChangeName(Font CurrentFont, string Name);
+        public static Font FontChangeSize(Font CurrentFont, float Size);
+        public static Font FontChangeStrikeout(Font CurrentFont, bool Strikeout);
+        public static Font FontChangeUnderline(Font CurrentFont, bool Underline);
+        public static object FontToIFont(Font fnt);
+        public static string Format(object Expression, string Style="", FirstDayOfWeek DayOfWeek=(FirstDayOfWeek)(1), FirstWeekOfYear WeekOfYear=(FirstWeekOfYear)(1));
+        public static double FromPixelsUserHeight(double Height, double ScaleHeight, int OriginalHeightInPixels);
+        public static double FromPixelsUserWidth(double Width, double ScaleWidth, int OriginalWidthInPixels);
+        public static double FromPixelsUserX(double X, double ScaleLeft, double ScaleWidth, int OriginalWidthInPixels);
+        public static double FromPixelsUserY(double Y, double ScaleTop, double ScaleHeight, int OriginalHeightInPixels);
+        public static double FromPixelsX(double X, ScaleMode ToScale);
+        public static double FromPixelsY(double Y, ScaleMode ToScale);
+        public static Control GetActiveControl();
+        public static bool GetCancel(Button btn);
+        public static bool GetDefault(Button btn);
+        public static string GetEXEName();
+        public static IntPtr GetHInstance();
+        public static int GetItemData(Control Control, int Index);
+        public static string GetItemString(Control Control, int Index);
+        public static string GetPath();
+        public static object IconToIPicture(Icon ico);
+        public static Font IFontToFont(object objFnt);
+        public static object ImageToIPicture(Image img);
+        public static object ImageToIPictureDisp(Image img);
+        public static bool Imp(bool a, bool b);
+        public static byte Imp(byte a, byte b);
+        public static short Imp(short a, short b);
+        public static int Imp(int a, int b);
+        public static long Imp(long a, long b);
+        public static object Imp(object a, object b);
+        public static Image IPictureDispToImage(object pict);
+        public static Image IPictureToImage(object pict);
+        public static object LoadResData(object ID, object restype);
+        public static object LoadResData(object ID, object restype, CultureInfo Culture);
+        public static object LoadResPicture(object ID, LoadResConstants restype);
+        public static object LoadResPicture(object ID, LoadResConstants restype, CultureInfo Culture);
+        public static string LoadResString(int ID);
+        public static string LoadResString(int ID, CultureInfo Culture);
+        public static double PixelsToTwipsX(double X);
+        public static double PixelsToTwipsY(double Y);
+        public static void SendKeys(string Keys, bool Wait=false);
+        public static void SetCancel(Button btn, bool Cancel);
+        public static void SetDefault(Button btn, bool Default);
+        public static void SetItemData(Control Control, int Index, int ItemData);
+        public static void SetItemString(Control Control, int Index, string ItemString);
+        public static void SetResourceBaseName(string BaseFileName);
+        public static void SetResourceBaseName(string ProjectNamespace, string BaseFileName);
+        public static void ShowForm(Form Form, int Modal=0, Form OwnerForm=null);
+        public static string TabLayout(params object[] Args);
+        public static double ToPixelsUserHeight(double Height, double ScaleHeight, int OriginalHeightInPixels);
+        public static double ToPixelsUserWidth(double Width, double ScaleWidth, int OriginalWidthInPixels);
+        public static double ToPixelsUserX(double X, double ScaleLeft, double ScaleWidth, int OriginalWidthInPixels);
+        public static double ToPixelsUserY(double Y, double ScaleTop, double ScaleHeight, int OriginalHeightInPixels);
+        public static double ToPixelsX(double X, ScaleMode FromScale);
+        public static double ToPixelsY(double Y, ScaleMode FromScale);
+        public static float TwipsPerPixelX();
+        public static float TwipsPerPixelY();
+        public static double TwipsToPixelsX(double X);
+        public static double TwipsToPixelsY(double Y);
+        public static void ValidateControls(ContainerControl Form);
+        public static void WhatsThisMode(Form Form);
+        public static void ZOrder(Control Control, int Position);
+    }
+    public class TabControlArray : BaseControlArray, IExtenderProvider {
+        public TabControlArray();
+        public TabControlArray(IContainer Container);
+        public TabControl this[short Index] { get; }
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
+        public event TabControlEventHandler Deselected;
+        public event TabControlCancelEventHandler Deselecting;
+        public event EventHandler DockChanged;
+        public event EventHandler DoubleClick;
+        public event DragEventHandler DragDrop;
+        public event DragEventHandler DragEnter;
+        public event EventHandler DragLeave;
+        public event DragEventHandler DragOver;
+        public event DrawItemEventHandler DrawItem;
+        public event EventHandler EnabledChanged;
+        public event EventHandler Enter;
+        public event EventHandler FontChanged;
+        public event GiveFeedbackEventHandler GiveFeedback;
+        public event HelpEventHandler HelpRequested;
+        public event EventHandler ImeModeChanged;
+        public event KeyEventHandler KeyDown;
+        public event KeyPressEventHandler KeyPress;
+        public event KeyEventHandler KeyUp;
+        public event LayoutEventHandler Layout;
+        public event EventHandler Leave;
+        public event EventHandler LocationChanged;
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
+        public event EventHandler Move;
+        public event EventHandler PaddingChanged;
+        public event EventHandler ParentChanged;
+        public event QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
+        public event QueryContinueDragEventHandler QueryContinueDrag;
+        public event EventHandler RegionChanged;
+        public event EventHandler Resize;
+        public event EventHandler RightToLeftChanged;
+        public event EventHandler RightToLeftLayoutChanged;
+        public event TabControlEventHandler Selected;
+        public event EventHandler SelectedIndexChanged;
+        public event TabControlCancelEventHandler Selecting;
+        public event EventHandler SizeChanged;
+        public event EventHandler StyleChanged;
+        public event EventHandler SystemColorsChanged;
+        public event EventHandler TabIndexChanged;
+        public event EventHandler TabStopChanged;
+        public event EventHandler Validated;
+        public event CancelEventHandler Validating;
+        public event EventHandler VisibleChanged;
+        bool CanExtend(object target);
+        protected override Type GetControlInstanceType();
+        public short GetIndex(TabControl o);
+        protected override void HookUpControlEvents(object o);
+        public void ResetIndex(TabControl o);
+        public void SetIndex(TabControl o, short Index);
+        public bool ShouldSerializeIndex(TabControl o);
+    }
+    public class TextBoxArray : BaseControlArray, IExtenderProvider {
+        public TextBoxArray();
+        public TextBoxArray(IContainer Container);
+        public TextBox this[short Index] { get; }
+        public event EventHandler AcceptsTabChanged;
+        public event EventHandler AutoSizeChanged;
+        public event EventHandler BackColorChanged;
+        public event EventHandler BindingContextChanged;
+        public event EventHandler BorderStyleChanged;
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
+        public event HelpEventHandler HelpRequested;
+        public event EventHandler HideSelectionChanged;
+        public event EventHandler ImeModeChanged;
+        public event KeyEventHandler KeyDown;
+        public event KeyPressEventHandler KeyPress;
+        public event KeyEventHandler KeyUp;
+        public event LayoutEventHandler Layout;
+        public event EventHandler Leave;
+        public event EventHandler LocationChanged;
+        public event EventHandler MarginChanged;
+        public event EventHandler ModifiedChanged;
+        public event EventHandler MouseCaptureChanged;
+        public event MouseEventHandler MouseClick;
+        public event MouseEventHandler MouseDoubleClick;
+        public event MouseEventHandler MouseDown;
+        public event EventHandler MouseEnter;
+        public event EventHandler MouseHover;
+        public event EventHandler MouseLeave;
+        public event MouseEventHandler MouseMove;
+        public event MouseEventHandler MouseUp;
+        public event EventHandler Move;
+        public event EventHandler MultilineChanged;
+        public event EventHandler ParentChanged;
+        public event QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
+        public event QueryContinueDragEventHandler QueryContinueDrag;
+        public event EventHandler ReadOnlyChanged;
+        public event EventHandler RegionChanged;
+        public event EventHandler Resize;
+        public event EventHandler RightToLeftChanged;
+        public event EventHandler SizeChanged;
+        public event EventHandler StyleChanged;
+        public event EventHandler SystemColorsChanged;
+        public event EventHandler TabIndexChanged;
+        public event EventHandler TabStopChanged;
+        public event EventHandler TextAlignChanged;
+        public event EventHandler TextChanged;
+        public event EventHandler Validated;
+        public event CancelEventHandler Validating;
+        public event EventHandler VisibleChanged;
+        bool CanExtend(object target);
+        protected override Type GetControlInstanceType();
+        public short GetIndex(TextBox o);
+        protected override void HookUpControlEvents(object o);
+        public void ResetIndex(TextBox o);
+        public void SetIndex(TextBox o, short Index);
+        public bool ShouldSerializeIndex(TextBox o);
+    }
+    public class TimerArray : BaseControlArray, IExtenderProvider {
+        public TimerArray();
+        public TimerArray(IContainer Container);
+        public Timer this[short Index] { get; }
+        public event EventHandler Tick;
+        bool CanExtend(object target);
+        protected override Type GetControlInstanceType();
+        public short GetIndex(Timer o);
+        protected override void HookUpControlEvents(object o);
+        public void ResetIndex(Timer o);
+        public void SetIndex(Timer o, short Index);
+        public bool ShouldSerializeIndex(Timer o);
+    }
+    public class ToolBarArray : BaseControlArray, IExtenderProvider {
+        public ToolBarArray();
+        public ToolBarArray(IContainer Container);
+        public ToolBar this[short Index] { get; }
+        public event EventHandler AutoSizeChanged;
+        public event EventHandler BindingContextChanged;
+        public event ToolBarButtonClickEventHandler ButtonClick;
+        public event ToolBarButtonClickEventHandler ButtonDropDown;
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
+        public event GiveFeedbackEventHandler GiveFeedback;
+        public event HelpEventHandler HelpRequested;
+        public event KeyEventHandler KeyDown;
+        public event KeyPressEventHandler KeyPress;
+        public event KeyEventHandler KeyUp;
+        public event LayoutEventHandler Layout;
+        public event EventHandler Leave;
+        public event EventHandler LocationChanged;
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
+        public event EventHandler Move;
+        public event EventHandler PaddingChanged;
+        public event EventHandler ParentChanged;
+        public event QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
+        public event QueryContinueDragEventHandler QueryContinueDrag;
+        public event EventHandler RegionChanged;
+        public event EventHandler Resize;
+        public event EventHandler SizeChanged;
+        public event EventHandler StyleChanged;
+        public event EventHandler SystemColorsChanged;
+        public event EventHandler TabIndexChanged;
+        public event EventHandler TabStopChanged;
+        public event EventHandler Validated;
+        public event CancelEventHandler Validating;
+        public event EventHandler VisibleChanged;
+        bool CanExtend(object target);
+        protected override Type GetControlInstanceType();
+        public short GetIndex(ToolBar o);
+        protected override void HookUpControlEvents(object o);
+        public void ResetIndex(ToolBar o);
+        public void SetIndex(ToolBar o, short Index);
+        public bool ShouldSerializeIndex(ToolBar o);
+    }
+    public class ToolStripArray : BaseControlArray, IExtenderProvider {
+        public ToolStripArray();
+        public ToolStripArray(IContainer Container);
+        public ToolStrip this[short Index] { get; }
+        public event EventHandler AutoSizeChanged;
+        public event EventHandler BackColorChanged;
+        public event EventHandler BackgroundImageChanged;
+        public event EventHandler BackgroundImageLayoutChanged;
+        public event EventHandler BeginDrag;
+        public event EventHandler BindingContextChanged;
+        public event UICuesEventHandler ChangeUICues;
+        public event EventHandler Click;
+        public event EventHandler ClientSizeChanged;
+        public event EventHandler ContextMenuChanged;
+        public event EventHandler ContextMenuStripChanged;
+        public event EventHandler DockChanged;
+        public event EventHandler DoubleClick;
+        public event DragEventHandler DragDrop;
+        public event DragEventHandler DragEnter;
+        public event EventHandler DragLeave;
+        public event DragEventHandler DragOver;
+        public event EventHandler EnabledChanged;
+        public event EventHandler EndDrag;
+        public event EventHandler Enter;
+        public event EventHandler FontChanged;
+        public event GiveFeedbackEventHandler GiveFeedback;
+        public event HelpEventHandler HelpRequested;
+        public event EventHandler ImeModeChanged;
+        public event ToolStripItemEventHandler ItemAdded;
+        public event ToolStripItemClickedEventHandler ItemClicked;
+        public event ToolStripItemEventHandler ItemRemoved;
+        public event KeyEventHandler KeyDown;
+        public event KeyPressEventHandler KeyPress;
+        public event KeyEventHandler KeyUp;
+        public event LayoutEventHandler Layout;
+        public event EventHandler LayoutCompleted;
+        public event EventHandler LayoutStyleChanged;
+        public event EventHandler Leave;
+        public event EventHandler LocationChanged;
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
+        public event EventHandler Move;
+        public event EventHandler PaddingChanged;
+        public event PaintEventHandler Paint;
+        public event PaintEventHandler PaintGrip;
+        public event EventHandler ParentChanged;
+        public event QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
+        public event QueryContinueDragEventHandler QueryContinueDrag;
+        public event EventHandler RegionChanged;
+        public event EventHandler Resize;
+        public event EventHandler RightToLeftChanged;
+        public event ScrollEventHandler Scroll;
+        public event EventHandler SizeChanged;
+        public event EventHandler StyleChanged;
+        public event EventHandler SystemColorsChanged;
+        public event EventHandler TabIndexChanged;
+        public event EventHandler TabStopChanged;
+        public event EventHandler TextChanged;
+        public event EventHandler Validated;
+        public event CancelEventHandler Validating;
+        public event EventHandler VisibleChanged;
+        bool CanExtend(object target);
+        protected override Type GetControlInstanceType();
+        public short GetIndex(ToolStrip o);
+        protected override void HookUpControlEvents(object o);
+        public void ResetIndex(ToolStrip o);
+        public void SetIndex(ToolStrip o, short Index);
+        public bool ShouldSerializeIndex(ToolStrip o);
+    }
+    public class ToolStripMenuItemArray : BaseControlArray, IExtenderProvider {
+        public ToolStripMenuItemArray();
+        public ToolStripMenuItemArray(IContainer Container);
+        public ToolStripMenuItem this[short Index] { get; }
+        public event EventHandler BackColorChanged;
+        public event EventHandler CheckedChanged;
+        public event EventHandler CheckStateChanged;
+        public event EventHandler Click;
+        public event EventHandler DisplayStyleChanged;
+        public event EventHandler DoubleClick;
+        public event EventHandler DropDownClosed;
+        public event ToolStripItemClickedEventHandler DropDownItemClicked;
+        public event EventHandler DropDownOpened;
+        public event EventHandler DropDownOpening;
+        public event EventHandler EnabledChanged;
+        public event EventHandler ForeColorChanged;
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
+        public event EventHandler RightToLeftChanged;
+        public event EventHandler TextChanged;
+        public event EventHandler VisibleChanged;
+        bool CanExtend(object target);
+        protected override Type GetControlInstanceType();
+        public short GetIndex(ToolStripMenuItem o);
+        protected override void HookUpControlEvents(object o);
+        public void ResetIndex(ToolStripMenuItem o);
+        public void SetIndex(ToolStripMenuItem o, short Index);
+        public bool ShouldSerializeIndex(ToolStripMenuItem o);
+    }
+    public class TreeViewArray : BaseControlArray, IExtenderProvider {
+        public TreeViewArray();
+        public TreeViewArray(IContainer Container);
+        public TreeView this[short Index] { get; }
+        public event TreeViewEventHandler AfterCheck;
+        public event TreeViewEventHandler AfterCollapse;
+        public event TreeViewEventHandler AfterExpand;
+        public event NodeLabelEditEventHandler AfterLabelEdit;
+        public event TreeViewEventHandler AfterSelect;
+        public event EventHandler BackColorChanged;
+        public event TreeViewCancelEventHandler BeforeCheck;
+        public event TreeViewCancelEventHandler BeforeCollapse;
+        public event TreeViewCancelEventHandler BeforeExpand;
+        public event NodeLabelEditEventHandler BeforeLabelEdit;
+        public event TreeViewCancelEventHandler BeforeSelect;
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
+        public event DrawTreeNodeEventHandler DrawNode;
+        public event EventHandler EnabledChanged;
+        public event EventHandler Enter;
+        public event EventHandler FontChanged;
+        public event EventHandler ForeColorChanged;
+        public event GiveFeedbackEventHandler GiveFeedback;
+        public event HelpEventHandler HelpRequested;
+        public event EventHandler ImeModeChanged;
+        public event ItemDragEventHandler ItemDrag;
+        public event KeyEventHandler KeyDown;
+        public event KeyPressEventHandler KeyPress;
+        public event KeyEventHandler KeyUp;
+        public event LayoutEventHandler Layout;
+        public event EventHandler Leave;
+        public event EventHandler LocationChanged;
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
+        public event EventHandler Move;
+        public event TreeNodeMouseClickEventHandler NodeMouseClick;
+        public event TreeNodeMouseClickEventHandler NodeMouseDoubleClick;
+        public event TreeNodeMouseHoverEventHandler NodeMouseHover;
+        public event EventHandler PaddingChanged;
+        public event EventHandler ParentChanged;
+        public event QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
+        public event QueryContinueDragEventHandler QueryContinueDrag;
+        public event EventHandler RegionChanged;
+        public event EventHandler Resize;
+        public event EventHandler RightToLeftChanged;
+        public event EventHandler RightToLeftLayoutChanged;
+        public event EventHandler SizeChanged;
+        public event EventHandler StyleChanged;
+        public event EventHandler SystemColorsChanged;
+        public event EventHandler TabIndexChanged;
+        public event EventHandler TabStopChanged;
+        public event EventHandler Validated;
+        public event CancelEventHandler Validating;
+        public event EventHandler VisibleChanged;
+        bool CanExtend(object target);
+        protected override Type GetControlInstanceType();
+        public short GetIndex(TreeView o);
+        protected override void HookUpControlEvents(object o);
+        public void ResetIndex(TreeView o);
+        public void SetIndex(TreeView o, short Index);
+        public bool ShouldSerializeIndex(TreeView o);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
+    public struct UGUID {
+        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
+        public Guid guid;
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
+    public struct UNAME {
+        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
+        public IntPtr name;
+    }
+    public enum UpdateMode {
+        vbUpdateWhenPropertyChanges = 1,
+        vbUpdateWhenRowChanges = 2,
+        vbUsePropertyAttributes = 0,
+    }
+    public class VScrollBarArray : BaseControlArray, IExtenderProvider {
+        public VScrollBarArray();
+        public VScrollBarArray(IContainer Container);
+        public VScrollBar this[short Index] { get; }
+        public event EventHandler BindingContextChanged;
+        public event EventHandler CausesValidationChanged;
+        public event UICuesEventHandler ChangeUICues;
+        public event EventHandler ClientSizeChanged;
+        public event EventHandler ContextMenuChanged;
+        public event EventHandler ContextMenuStripChanged;
+        public event ControlEventHandler ControlAdded;
+        public event ControlEventHandler ControlRemoved;
+        public event EventHandler CursorChanged;
+        public event EventHandler DockChanged;
+        public event DragEventHandler DragDrop;
+        public event DragEventHandler DragEnter;
+        public event EventHandler DragLeave;
+        public event DragEventHandler DragOver;
+        public event EventHandler EnabledChanged;
+        public event EventHandler Enter;
+        public event GiveFeedbackEventHandler GiveFeedback;
+        public event HelpEventHandler HelpRequested;
+        public event KeyEventHandler KeyDown;
+        public event KeyPressEventHandler KeyPress;
+        public event KeyEventHandler KeyUp;
+        public event LayoutEventHandler Layout;
+        public event EventHandler Leave;
+        public event EventHandler LocationChanged;
+        public event EventHandler MarginChanged;
+        public event EventHandler MouseCaptureChanged;
+        public event EventHandler MouseEnter;
+        public event EventHandler MouseHover;
+        public event EventHandler MouseLeave;
+        public event EventHandler Move;
+        public event EventHandler PaddingChanged;
+        public event EventHandler ParentChanged;
+        public event QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
+        public event QueryContinueDragEventHandler QueryContinueDrag;
+        public event EventHandler RegionChanged;
+        public event EventHandler Resize;
+        public event ScrollEventHandler Scroll;
+        public event EventHandler SizeChanged;
+        public event EventHandler StyleChanged;
+        public event EventHandler SystemColorsChanged;
+        public event EventHandler TabIndexChanged;
+        public event EventHandler TabStopChanged;
+        public event EventHandler Validated;
+        public event CancelEventHandler Validating;
+        public event EventHandler ValueChanged;
+        public event EventHandler VisibleChanged;
+        bool CanExtend(object target);
+        protected override Type GetControlInstanceType();
+        public short GetIndex(VScrollBar o);
+        protected override void HookUpControlEvents(object o);
+        public void ResetIndex(VScrollBar o);
+        public void SetIndex(VScrollBar o, short Index);
+        public bool ShouldSerializeIndex(VScrollBar o);
+    }
+    public class WebBrowserArray : BaseControlArray, IExtenderProvider {
+        public WebBrowserArray();
+        public WebBrowserArray(IContainer Container);
+        public WebBrowser this[short Index] { get; }
+        public event EventHandler CausesValidationChanged;
+        public event EventHandler ClientSizeChanged;
+        public event EventHandler ContextMenuChanged;
+        public event EventHandler ContextMenuStripChanged;
+        public event ControlEventHandler ControlAdded;
+        public event ControlEventHandler ControlRemoved;
+        public event EventHandler DockChanged;
+        public event WebBrowserDocumentCompletedEventHandler DocumentCompleted;
+        public event EventHandler FileDownload;
+        public event EventHandler LocationChanged;
+        public event EventHandler MarginChanged;
+        public event EventHandler Move;
+        public event WebBrowserNavigatedEventHandler Navigated;
+        public event WebBrowserNavigatingEventHandler Navigating;
+        public event CancelEventHandler NewWindow;
+        public event EventHandler ParentChanged;
+        public event WebBrowserProgressChangedEventHandler ProgressChanged;
+        public event EventHandler RegionChanged;
+        public event EventHandler Resize;
+        public event EventHandler SizeChanged;
+        public event EventHandler SystemColorsChanged;
+        public event EventHandler Validated;
+        public event CancelEventHandler Validating;
+        public event EventHandler VisibleChanged;
+        bool CanExtend(object target);
+        protected override Type GetControlInstanceType();
+        public short GetIndex(WebBrowser o);
+        protected override void HookUpControlEvents(object o);
+        public void ResetIndex(WebBrowser o);
+        public void SetIndex(WebBrowser o, short Index);
+        public bool ShouldSerializeIndex(WebBrowser o);
+    }
+    public class WebClass {
+        public WebClass(string UserWebClassName, string WebClassFileName, object ContainingClass);
+        public string Name { get; }
+        public WebItem NextItem { get; set; }
+        public string UrlData { get; set; }
+        public void ProcessEvents(HttpRequest Request);
+        public string URLFor(WebItem obj, string EventName="");
+        public string URLFor(string objName, string EventName="");
+    }
+    public class WebClassContainingClassNotOptional : Exception {
+        public WebClassContainingClassNotOptional();
+    }
+    public class WebClassCouldNotFindEvent : Exception {
+        public WebClassCouldNotFindEvent();
+        public WebClassCouldNotFindEvent(string eventName);
+    }
+    public class WebClassNextItemCannotBeCurrentWebItem : Exception {
+        public WebClassNextItemCannotBeCurrentWebItem();
+    }
+    public class WebClassNextItemRespondNotFound : Exception {
+        public WebClassNextItemRespondNotFound();
+    }
+    public class WebClassUserWebClassNameNotOptional : Exception {
+        public WebClassUserWebClassNameNotOptional();
+    }
+    public class WebClassWebClassFileNameNotOptional : Exception {
+        public WebClassWebClassFileNameNotOptional();
+    }
+    public class WebClassWebItemNotValid : Exception {
+        public WebClassWebItemNotValid(string itemName);
+    }
+    public class WebItem {
+        public WebItem(string Name, WebClass AssociatedWebClass, string HtmlTemplateFilename="");
+        public string Name { get; }
+        public bool ReScanReplacements { get; set; }
+        public string TagPrefix { get; set; }
+        public void WriteTemplate(HttpResponse Response, string HtmlTemplateFilename="");
+    }
+    public class WebItemAssociatedWebClassNotOptional : Exception {
+        public WebItemAssociatedWebClassNotOptional();
+    }
+    public class WebItemClosingTagNotFound : Exception {
+        public WebItemClosingTagNotFound(string TagName);
+    }
+    public class WebItemCouldNotLoadEmbeddedResource : Exception {
+        public WebItemCouldNotLoadEmbeddedResource();
+    }
+    public class WebItemCouldNotLoadTemplateFile : Exception {
+        public WebItemCouldNotLoadTemplateFile();
+    }
+    public class WebItemNameNotOptional : Exception {
+        public WebItemNameNotOptional();
+    }
+    public class WebItemNoTemplateSpecified : Exception {
+        public WebItemNoTemplateSpecified();
+    }
+    public class WebItemTooManyNestedTags : Exception {
+        public WebItemTooManyNestedTags();
+    }
+    public class WebItemUnexpectedErrorReadingTemplateFile : Exception {
+        public WebItemUnexpectedErrorReadingTemplateFile(string innerMessage);
+    }
+    public enum ZOrderConstants {
+        BringToFront = 0,
+        SendToBack = 1,
+    }
+}
```

