# System.Windows.Forms.Design

``` diff
+namespace System.Windows.Forms.Design {
+    public sealed class AnchorEditor : UITypeEditor {
+        public AnchorEditor();
+        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value);
+        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context);
+    }
+    public class AxImporter {
+        public AxImporter(AxImporter.Options options);
+        public string[] GeneratedAssemblies { get; }
+        public string[] GeneratedSources { get; }
+        public TYPELIBATTR[] GeneratedTypeLibAttributes { get; }
+        public string GenerateFromFile(FileInfo file);
+        public string GenerateFromTypeLibrary(UCOMITypeLib typeLib);
+        public string GenerateFromTypeLibrary(UCOMITypeLib typeLib, Guid clsid);
+        public static string GetFileOfTypeLib(ref TYPELIBATTR tlibattr);
+        public interface IReferenceResolver {
+            string ResolveActiveXReference(UCOMITypeLib typeLib);
+            string ResolveComReference(AssemblyName name);
+            string ResolveComReference(UCOMITypeLib typeLib);
+            string ResolveManagedReference(string assemName);
+        }
+        public sealed class Options {
+            public AxImporter.IReferenceResolver references;
+            public bool delaySign;
+            public bool genSources;
+            public bool ignoreRegisteredOcx;
+            public bool msBuildErrors;
+            public bool noLogo;
+            public bool overwriteRCW;
+            public bool silentMode;
+            public bool verboseMode;
+            public byte[] publicKey;
+            public StrongNameKeyPair keyPair;
+            public string keyContainer;
+            public string keyFile;
+            public string outputDirectory;
+            public string outputName;
+            public Options();
+        }
+    }
+    public class AxParameterData {
+        public AxParameterData(ParameterInfo info);
+        public AxParameterData(ParameterInfo info, bool ignoreByRefs);
+        public AxParameterData(string inname, string typeName);
+        public AxParameterData(string inname, Type type);
+        public FieldDirection Direction { get; }
+        public bool IsByRef { get; }
+        public bool IsIn { get; }
+        public bool IsOptional { get; }
+        public bool IsOut { get; }
+        public string Name { get; set; }
+        public Type ParameterType { get; }
+        public string TypeName { get; }
+        public static AxParameterData[] Convert(ParameterInfo[] infos);
+        public static AxParameterData[] Convert(ParameterInfo[] infos, bool ignoreByRefs);
+    }
+    public class AxWrapperGen {
+        public static ArrayList GeneratedSources;
+        public AxWrapperGen(Type axType);
+    }
+    public class BorderSidesEditor : UITypeEditor {
+        public BorderSidesEditor();
+        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value);
+        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context);
+    }
+    public class ComponentDocumentDesigner : ComponentDesigner, IDesigner, IDisposable, IOleDragClient, IRootDesigner, IToolboxUser, ITypeDescriptorFilterService {
+        public ComponentDocumentDesigner();
+        public Control Control { get; }
+        ViewTechnology[] System.ComponentModel.Design.IRootDesigner.SupportedTechnologies { get; }
+        public bool TrayAutoArrange { get; set; }
+        public bool TrayLargeIcon { get; set; }
+        protected override void Dispose(bool disposing);
+        protected virtual bool GetToolSupported(ToolboxItem tool);
+        public override void Initialize(IComponent component);
+        protected override void PreFilterProperties(IDictionary properties);
+        object System.ComponentModel.Design.IRootDesigner.GetView(ViewTechnology technology);
+        bool System.ComponentModel.Design.ITypeDescriptorFilterService.FilterAttributes(IComponent component, IDictionary attributes);
+        bool System.ComponentModel.Design.ITypeDescriptorFilterService.FilterEvents(IComponent component, IDictionary events);
+        bool System.ComponentModel.Design.ITypeDescriptorFilterService.FilterProperties(IComponent component, IDictionary properties);
+        bool System.Drawing.Design.IToolboxUser.GetToolSupported(ToolboxItem tool);
+        void System.Drawing.Design.IToolboxUser.ToolPicked(ToolboxItem tool);
+    }
+    public class ComponentEditorForm : Form {
+        public ComponentEditorForm(object component, Type[] pageTypes);
+        public override bool AutoSize { get; set; }
+        public new event EventHandler AutoSizeChanged;
+        protected override void OnActivated(EventArgs e);
+        protected override void OnHelpRequested(HelpEventArgs e);
+        protected virtual void OnSelChangeSelector(object source, TreeViewEventArgs e);
+        public override bool PreProcessMessage(ref Message msg);
+        public virtual DialogResult ShowForm();
+        public virtual DialogResult ShowForm(int page);
+        public virtual DialogResult ShowForm(IWin32Window owner);
+        public virtual DialogResult ShowForm(IWin32Window owner, int page);
+    }
+    public abstract class ComponentEditorPage : Panel {
+        public ComponentEditorPage();
+        public override bool AutoSize { get; set; }
+        public bool CommitOnDeactivate { get; set; }
+        protected IComponent Component { get; set; }
+        protected override CreateParams CreateParams { get; }
+        protected bool FirstActivate { get; set; }
+        public Icon Icon { get; set; }
+        protected int Loading { get; set; }
+        protected bool LoadRequired { get; set; }
+        protected IComponentEditorPageSite PageSite { get; set; }
+        public virtual string Title { get; }
+        public new event EventHandler AutoSizeChanged;
+        public virtual void Activate();
+        public virtual void ApplyChanges();
+        public virtual void Deactivate();
+        protected void EnterLoadingMode();
+        protected void ExitLoadingMode();
+        public virtual Control GetControl();
+        protected IComponent GetSelectedComponent();
+        protected bool IsFirstActivate();
+        protected bool IsLoading();
+        public virtual bool IsPageMessage(ref Message msg);
+        protected abstract void LoadComponent();
+        public virtual void OnApplyComplete();
+        protected virtual void ReloadComponent();
+        protected abstract void SaveComponent();
+        public virtual void SetComponent(IComponent component);
+        protected virtual void SetDirty();
+        public virtual void SetSite(IComponentEditorPageSite site);
+        public virtual void ShowHelp();
+        public virtual bool SupportsHelp();
+    }
+    public class ComponentTray : ScrollableControl, IExtenderProvider, IOleDragClient, ISelectionUIHandler {
+        public ComponentTray(IDesigner mainDesigner, IServiceProvider serviceProvider);
+        public bool AutoArrange { get; set; }
+        public int ComponentCount { get; }
+        public bool ShowLargeIcons { get; set; }
+        public virtual void AddComponent(IComponent component);
+        protected virtual bool CanCreateComponentFromTool(ToolboxItem tool);
+        protected virtual bool CanDisplayComponent(IComponent component);
+        public void CreateComponentFromTool(ToolboxItem tool);
+        protected void DisplayError(Exception e);
+        protected override void Dispose(bool disposing);
+        public Point GetLocation(IComponent receiver);
+        public IComponent GetNextComponent(IComponent component, bool forward);
+        protected override object GetService(Type serviceType);
+        public Point GetTrayLocation(IComponent receiver);
+        public bool IsTrayComponent(IComponent comp);
+        protected override void OnDragDrop(DragEventArgs de);
+        protected override void OnDragEnter(DragEventArgs de);
+        protected override void OnDragLeave(EventArgs e);
+        protected override void OnDragOver(DragEventArgs de);
+        protected override void OnGiveFeedback(GiveFeedbackEventArgs gfevent);
+        protected override void OnLayout(LayoutEventArgs levent);
+        protected virtual void OnLostCapture();
+        protected override void OnMouseDoubleClick(MouseEventArgs e);
+        protected override void OnMouseDown(MouseEventArgs e);
+        protected override void OnMouseMove(MouseEventArgs e);
+        protected override void OnMouseUp(MouseEventArgs e);
+        protected override void OnPaint(PaintEventArgs pe);
+        protected virtual void OnSetCursor();
+        public virtual void RemoveComponent(IComponent component);
+        public void SetLocation(IComponent receiver, Point location);
+        public void SetTrayLocation(IComponent receiver, Point location);
+        bool System.ComponentModel.IExtenderProvider.CanExtend(object component);
+        protected override void WndProc(ref Message m);
+    }
+    public class ControlDesigner : ComponentDesigner {
+        protected static readonly Point InvalidPoint;
+        protected AccessibleObject accessibilityObj;
+        public ControlDesigner();
+        public virtual AccessibleObject AccessibilityObject { get; }
+        public override ICollection AssociatedComponents { get; }
+        public bool AutoResizeHandles { get; set; }
+        protected BehaviorService BehaviorService { get; }
+        public virtual Control Control { get; }
+        protected virtual bool EnableDragRect { get; }
+        protected override InheritanceAttribute InheritanceAttribute { get; }
+        protected override IComponent ParentComponent { get; }
+        public virtual bool ParticipatesWithSnapLines { get; }
+        public virtual SelectionRules SelectionRules { get; }
+        public virtual IList SnapLines { get; }
+        protected void BaseWndProc(ref Message m);
+        public virtual bool CanBeParentedTo(IDesigner parentDesigner);
+        protected void DefWndProc(ref Message m);
+        protected void DisplayError(Exception e);
+        protected override void Dispose(bool disposing);
+        protected bool EnableDesignMode(Control child, string name);
+        protected void EnableDragDrop(bool value);
+        protected virtual ControlBodyGlyph GetControlGlyph(GlyphSelectionType selectionType);
+        public virtual GlyphCollection GetGlyphs(GlyphSelectionType selectionType);
+        protected virtual bool GetHitTest(Point point);
+        protected void HookChildControls(Control firstChild);
+        public override void Initialize(IComponent component);
+        public override void InitializeExistingComponent(IDictionary defaultValues);
+        public override void InitializeNewComponent(IDictionary defaultValues);
+        public virtual ControlDesigner InternalControlDesigner(int internalControlIndex);
+        public virtual int NumberOfInternalControlDesigners();
+        protected virtual void OnContextMenu(int x, int y);
+        protected virtual void OnCreateHandle();
+        protected virtual void OnDragComplete(DragEventArgs de);
+        protected virtual void OnDragDrop(DragEventArgs de);
+        protected virtual void OnDragEnter(DragEventArgs de);
+        protected virtual void OnDragLeave(EventArgs e);
+        protected virtual void OnDragOver(DragEventArgs de);
+        protected virtual void OnGiveFeedback(GiveFeedbackEventArgs e);
+        protected virtual void OnMouseDragBegin(int x, int y);
+        protected virtual void OnMouseDragEnd(bool cancel);
+        protected virtual void OnMouseDragMove(int x, int y);
+        protected virtual void OnMouseEnter();
+        protected virtual void OnMouseHover();
+        protected virtual void OnMouseLeave();
+        protected virtual void OnPaintAdornments(PaintEventArgs pe);
+        public override void OnSetComponentDefaults();
+        protected virtual void OnSetCursor();
+        protected override void PreFilterProperties(IDictionary properties);
+        protected void UnhookChildControls(Control firstChild);
+        protected virtual void WndProc(ref Message m);
+        public class ControlDesignerAccessibleObject : AccessibleObject {
+            public ControlDesignerAccessibleObject(ControlDesigner designer, Control control);
+            public override Rectangle Bounds { get; }
+            public override string DefaultAction { get; }
+            public override string Description { get; }
+            public override string Name { get; }
+            public override AccessibleObject Parent { get; }
+            public override AccessibleRole Role { get; }
+            public override AccessibleStates State { get; }
+            public override string Value { get; }
+            public override AccessibleObject GetChild(int index);
+            public override int GetChildCount();
+            public override AccessibleObject GetFocused();
+            public override AccessibleObject GetSelected();
+            public override AccessibleObject HitTest(int x, int y);
+        }
+    }
+    public class DesignerOptions {
+        public DesignerOptions();
+        public virtual bool EnableInSituEditing { get; set; }
+        public virtual Size GridSize { get; set; }
+        public virtual bool ObjectBoundSmartTagAutoShow { get; set; }
+        public virtual bool ShowGrid { get; set; }
+        public virtual bool SnapToGrid { get; set; }
+        public virtual bool UseOptimizedCodeGeneration { get; set; }
+        public virtual bool UseSmartTags { get; set; }
+        public virtual bool UseSnapLines { get; set; }
+    }
+    public sealed class DockEditor : UITypeEditor {
+        public DockEditor();
+        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value);
+        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context);
+    }
+    public class DocumentDesigner : ScrollableControlDesigner, IDesigner, IDisposable, IOleDragClient, IRootDesigner, IToolboxUser {
+        protected IMenuEditorService menuEditorService;
+        public DocumentDesigner();
+        public override SelectionRules SelectionRules { get; }
+        ViewTechnology[] System.ComponentModel.Design.IRootDesigner.SupportedTechnologies { get; }
+        protected override void Dispose(bool disposing);
+        protected virtual void EnsureMenuEditorService(IComponent c);
+        public override GlyphCollection GetGlyphs(GlyphSelectionType selectionType);
+        protected virtual bool GetToolSupported(ToolboxItem tool);
+        public override void Initialize(IComponent component);
+        protected override void OnContextMenu(int x, int y);
+        protected override void OnCreateHandle();
+        protected override void PreFilterProperties(IDictionary properties);
+        object System.ComponentModel.Design.IRootDesigner.GetView(ViewTechnology technology);
+        bool System.Drawing.Design.IToolboxUser.GetToolSupported(ToolboxItem tool);
+        void System.Drawing.Design.IToolboxUser.ToolPicked(ToolboxItem tool);
+        protected virtual void ToolPicked(ToolboxItem tool);
+        protected override void WndProc(ref Message m);
+    }
+    public sealed class EventHandlerService : IEventHandlerService {
+        public EventHandlerService(Control focusWnd);
+        public Control FocusWindow { get; }
+        public event EventHandler EventHandlerChanged;
+        public object GetHandler(Type handlerType);
+        public void PopHandler(object handler);
+        public void PushHandler(object handler);
+    }
+    public class EventsTab : PropertyTab {
+        public EventsTab(IServiceProvider sp);
+        public override string HelpKeyword { get; }
+        public override string TabName { get; }
+        public override bool CanExtend(object extendee);
+        public override PropertyDescriptor GetDefaultProperty(object obj);
+        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object component, Attribute[] attributes);
+        public override PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes);
+    }
+    public class FileNameEditor : UITypeEditor {
+        public FileNameEditor();
+        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value);
+        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context);
+        protected virtual void InitializeDialog(OpenFileDialog openFileDialog);
+    }
+    public class FolderNameEditor : UITypeEditor {
+        public FolderNameEditor();
+        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value);
+        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context);
+        protected virtual void InitializeDialog(FolderNameEditor.FolderBrowser folderBrowser);
+        protected sealed class FolderBrowser : Component {
+            public FolderBrowser();
+            public string Description { get; set; }
+            public string DirectoryPath { get; }
+            public FolderNameEditor.FolderBrowserFolder StartLocation { get; set; }
+            public FolderNameEditor.FolderBrowserStyles Style { get; set; }
+            public DialogResult ShowDialog();
+            public DialogResult ShowDialog(IWin32Window owner);
+        }
+        protected enum FolderBrowserFolder {
+            Desktop = 0,
+            Favorites = 6,
+            MyComputer = 17,
+            MyDocuments = 5,
+            MyPictures = 39,
+            NetAndDialUpConnections = 49,
+            NetworkNeighborhood = 18,
+            Printers = 4,
+            Recent = 8,
+            SendTo = 9,
+            StartMenu = 11,
+            Templates = 21,
+        }
+        protected enum FolderBrowserStyles {
+            BrowseForComputer = 4096,
+            BrowseForEverything = 16384,
+            BrowseForPrinter = 8192,
+            RestrictToDomain = 2,
+            RestrictToFilesystem = 1,
+            RestrictToSubfolders = 8,
+            ShowTextBox = 16,
+        }
+    }
+    public interface IContainsThemedScrollbarWindows {
+        IEnumerable ThemedScrollbarWindows();
+    }
+    public class ImageListCodeDomSerializer : CodeDomSerializer {
+        public ImageListCodeDomSerializer();
+        public override object Deserialize(IDesignerSerializationManager manager, object codeObject);
+        public override object Serialize(IDesignerSerializationManager manager, object value);
+    }
+    public class ImageListImageEditor : ImageEditor {
+        public ImageListImageEditor();
+        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value);
+        protected override string GetFileDialogDescription();
+        protected override Type[] GetImageExtenders();
+        public override bool GetPaintValueSupported(ITypeDescriptorContext context);
+        public override void PaintValue(PaintValueEventArgs e);
+    }
+    public interface IMenuEditorService {
+        Menu GetMenu();
+        bool IsActive();
+        bool MessageFilter(ref Message m);
+        void SetMenu(Menu menu);
+        void SetSelection(MenuItem item);
+    }
+    public interface IUIService {
+        IDictionary Styles { get; }
+        bool CanShowComponentEditor(object component);
+        IWin32Window GetDialogOwnerWindow();
+        void SetUIDirty();
+        bool ShowComponentEditor(object component, IWin32Window parent);
+        DialogResult ShowDialog(Form form);
+        void ShowError(Exception ex);
+        void ShowError(Exception ex, string message);
+        void ShowError(string message);
+        void ShowMessage(string message);
+        void ShowMessage(string message, string caption);
+        DialogResult ShowMessage(string message, string caption, MessageBoxButtons buttons);
+        bool ShowToolWindow(Guid toolWindow);
+    }
+    public interface IWindowsFormsEditorService {
+        void CloseDropDown();
+        void DropDownControl(Control control);
+        DialogResult ShowDialog(Form dialog);
+    }
+    public abstract class MaskDescriptor {
+        protected MaskDescriptor();
+        public virtual CultureInfo Culture { get; }
+        public abstract string Mask { get; }
+        public abstract string Name { get; }
+        public abstract string Sample { get; }
+        public abstract Type ValidatingType { get; }
+        public override bool Equals(object maskDescriptor);
+        public override int GetHashCode();
+        public static bool IsValidMaskDescriptor(MaskDescriptor maskDescriptor);
+        public static bool IsValidMaskDescriptor(MaskDescriptor maskDescriptor, out string validationErrorDescription);
+        public override string ToString();
+    }
+    public sealed class MenuCommands : StandardCommands {
+        public static readonly CommandID ComponentTrayMenu;
+        public static readonly CommandID ContainerMenu;
+        public static readonly CommandID DesignerProperties;
+        public static readonly CommandID EditLabel;
+        public static readonly CommandID KeyCancel;
+        public static readonly CommandID KeyDefaultAction;
+        public static readonly CommandID KeyEnd;
+        public static readonly CommandID KeyHome;
+        public static readonly CommandID KeyInvokeSmartTag;
+        public static readonly CommandID KeyMoveDown;
+        public static readonly CommandID KeyMoveLeft;
+        public static readonly CommandID KeyMoveRight;
+        public static readonly CommandID KeyMoveUp;
+        public static readonly CommandID KeyNudgeDown;
+        public static readonly CommandID KeyNudgeHeightDecrease;
+        public static readonly CommandID KeyNudgeHeightIncrease;
+        public static readonly CommandID KeyNudgeLeft;
+        public static readonly CommandID KeyNudgeRight;
+        public static readonly CommandID KeyNudgeUp;
+        public static readonly CommandID KeyNudgeWidthDecrease;
+        public static readonly CommandID KeyNudgeWidthIncrease;
+        public static readonly CommandID KeyReverseCancel;
+        public static readonly CommandID KeySelectNext;
+        public static readonly CommandID KeySelectPrevious;
+        public static readonly CommandID KeyShiftEnd;
+        public static readonly CommandID KeyShiftHome;
+        public static readonly CommandID KeySizeHeightDecrease;
+        public static readonly CommandID KeySizeHeightIncrease;
+        public static readonly CommandID KeySizeWidthDecrease;
+        public static readonly CommandID KeySizeWidthIncrease;
+        public static readonly CommandID KeyTabOrderSelect;
+        public static readonly CommandID SelectionMenu;
+        public static readonly CommandID SetStatusRectangle;
+        public static readonly CommandID SetStatusText;
+        public static readonly CommandID TraySelectionMenu;
+        public MenuCommands();
+    }
+    public class ParentControlDesigner : ControlDesigner, IOleDragClient {
+        public ParentControlDesigner();
+        protected virtual bool AllowControlLasso { get; }
+        protected virtual bool AllowGenericDragBox { get; }
+        protected internal virtual bool AllowSetChildIndexOnDrop { get; }
+        protected virtual Point DefaultControlLocation { get; }
+        protected virtual bool DrawGrid { get; set; }
+        protected override bool EnableDragRect { get; }
+        protected Size GridSize { get; set; }
+        protected ToolboxItem MouseDragTool { get; }
+        public override IList SnapLines { get; }
+        protected void AddPaddingSnapLines(ref ArrayList snapLines);
+        protected internal virtual bool CanAddComponent(IComponent component);
+        public virtual bool CanParent(Control control);
+        public virtual bool CanParent(ControlDesigner controlDesigner);
+        protected void CreateTool(ToolboxItem tool);
+        protected void CreateTool(ToolboxItem tool, Point location);
+        protected void CreateTool(ToolboxItem tool, Rectangle bounds);
+        protected virtual IComponent[] CreateToolCore(ToolboxItem tool, int x, int y, int width, int height, bool hasLocation, bool hasSize);
+        protected override void Dispose(bool disposing);
+        protected Control GetControl(object component);
+        protected override ControlBodyGlyph GetControlGlyph(GlyphSelectionType selectionType);
+        public override GlyphCollection GetGlyphs(GlyphSelectionType selectionType);
+        protected virtual Control GetParentForComponent(IComponent component);
+        protected Rectangle GetUpdatedRect(Rectangle originalRect, Rectangle dragRect, bool updateSize);
+        public override void Initialize(IComponent component);
+        public override void InitializeNewComponent(IDictionary defaultValues);
+        protected static void InvokeCreateTool(ParentControlDesigner toInvoke, ToolboxItem tool);
+        protected override void OnDragComplete(DragEventArgs de);
+        protected override void OnDragDrop(DragEventArgs de);
+        protected override void OnDragEnter(DragEventArgs de);
+        protected override void OnDragLeave(EventArgs e);
+        protected override void OnDragOver(DragEventArgs de);
+        protected override void OnMouseDragBegin(int x, int y);
+        protected override void OnMouseDragEnd(bool cancel);
+        protected override void OnMouseDragMove(int x, int y);
+        protected override void OnPaintAdornments(PaintEventArgs pe);
+        protected override void OnSetCursor();
+        protected override void PreFilterProperties(IDictionary properties);
+    }
+    public abstract class PropertyTab : IExtenderProvider {
+        protected PropertyTab();
+        public virtual Bitmap Bitmap { get; }
+        public virtual object[] Components { get; set; }
+        public virtual string HelpKeyword { get; }
+        public abstract string TabName { get; }
+        public virtual bool CanExtend(object extendee);
+        public virtual void Dispose();
+        protected virtual void Dispose(bool disposing);
+        ~PropertyTab();
+        public virtual PropertyDescriptor GetDefaultProperty(object component);
+        public virtual PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object component, Attribute[] attributes);
+        public virtual PropertyDescriptorCollection GetProperties(object component);
+        public abstract PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes);
+    }
+    public class ScrollableControlDesigner : ParentControlDesigner {
+        public ScrollableControlDesigner();
+        protected override bool GetHitTest(Point pt);
+        protected override void WndProc(ref Message m);
+    }
+    public enum SelectionRules {
+        AllSizeable = 15,
+        BottomSizeable = 2,
+        LeftSizeable = 4,
+        Locked = -2147483648,
+        Moveable = 268435456,
+        None = 0,
+        RightSizeable = 8,
+        TopSizeable = 1,
+        Visible = 1073741824,
+    }
+    public class ShortcutKeysEditor : UITypeEditor {
+        public ShortcutKeysEditor();
+        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value);
+        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context);
+    }
+    public enum ThemedScrollbarMode {
+        All = 1,
+        None = 2,
+        OnlyTopLevel = 3,
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct ThemedScrollbarWindow {
+        public IntPtr Handle;
+        public ThemedScrollbarMode Mode;
+    }
+    public enum ToolStripItemDesignerAvailability {
+        All = 15,
+        ContextMenuStrip = 4,
+        MenuStrip = 2,
+        None = 0,
+        StatusStrip = 8,
+        ToolStrip = 1,
+    }
+    public sealed class ToolStripItemDesignerAvailabilityAttribute : Attribute {
+        public static readonly ToolStripItemDesignerAvailabilityAttribute Default;
+        public ToolStripItemDesignerAvailabilityAttribute();
+        public ToolStripItemDesignerAvailabilityAttribute(ToolStripItemDesignerAvailability visibility);
+        public ToolStripItemDesignerAvailability ItemAdditionVisibility { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public override bool IsDefaultAttribute();
+    }
+    public abstract class WindowsFormsComponentEditor : ComponentEditor {
+        protected WindowsFormsComponentEditor();
+        public override bool EditComponent(ITypeDescriptorContext context, object component);
+        public virtual bool EditComponent(ITypeDescriptorContext context, object component, IWin32Window owner);
+        public bool EditComponent(object component, IWin32Window owner);
+        protected virtual Type[] GetComponentEditorPages();
+        protected virtual int GetInitialComponentEditorPageIndex();
+    }
+    public class WindowsFormsDesignerOptionService : DesignerOptionService {
+        public WindowsFormsDesignerOptionService();
+        public virtual DesignerOptions CompatibilityOptions { get; }
+        protected override void PopulateOptionCollection(DesignerOptionService.DesignerOptionCollection options);
+    }
+}
```

