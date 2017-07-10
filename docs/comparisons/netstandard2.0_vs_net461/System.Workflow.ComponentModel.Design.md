# System.Workflow.ComponentModel.Design

``` diff
+namespace System.Workflow.ComponentModel.Design {
+    public class ActivityBindTypeConverter : TypeConverter {
+        public ActivityBindTypeConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object valueToConvert);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes);
+        public override bool GetPropertiesSupported(ITypeDescriptorContext context);
+        public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context);
+        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context);
+        public override bool GetStandardValuesSupported(ITypeDescriptorContext context);
+    }
+    public class ActivityChangedEventArgs : EventArgs {
+        public ActivityChangedEventArgs(Activity activity, MemberDescriptor member, object oldValue, object newValue);
+        public Activity Activity { get; }
+        public MemberDescriptor Member { get; }
+        public object NewValue { get; }
+        public object OldValue { get; }
+    }
+    public class ActivityDesigner : IConnectableDesigner, IDesigner, IDesignerFilter, IDisposable, IPersistUIState, IRootDesigner, IToolboxUser, IWorkflowDesignerMessageSink, IWorkflowRootDesigner {
+        public ActivityDesigner();
+        public virtual AccessibleObject AccessibilityObject { get; }
+        public Activity Activity { get; }
+        public Rectangle Bounds { get; }
+        protected internal virtual ReadOnlyCollection<DesignerAction> DesignerActions { get; }
+        public ActivityDesignerTheme DesignerTheme { get; }
+        protected internal virtual bool EnableVisualResizing { get; }
+        protected internal virtual ActivityDesignerGlyphCollection Glyphs { get; }
+        public virtual Image Image { get; protected set; }
+        protected virtual Rectangle ImageRectangle { get; }
+        protected virtual CompositeActivityDesigner InvokingDesigner { get; set; }
+        public bool IsLocked { get; }
+        public bool IsPrimarySelection { get; }
+        public bool IsRootDesigner { get; }
+        public bool IsSelected { get; }
+        public virtual bool IsVisible { get; }
+        public virtual Point Location { get; set; }
+        protected virtual ReadOnlyCollection<WorkflowDesignerMessageFilter> MessageFilters { get; }
+        public virtual Size MinimumSize { get; }
+        public CompositeActivityDesigner ParentDesigner { get; }
+        protected internal WorkflowView ParentView { get; }
+        protected virtual bool ShowSmartTag { get; }
+        public virtual Size Size { get; set; }
+        protected virtual Rectangle SmartTagRectangle { get; }
+        protected virtual ReadOnlyCollection<ActivityDesignerVerb> SmartTagVerbs { get; }
+        IComponent System.ComponentModel.Design.IDesigner.Component { get; }
+        DesignerVerbCollection System.ComponentModel.Design.IDesigner.Verbs { get; }
+        ViewTechnology[] System.ComponentModel.Design.IRootDesigner.SupportedTechnologies { get; }
+        CompositeActivityDesigner System.Workflow.ComponentModel.Design.IWorkflowRootDesigner.InvokingDesigner { get; set; }
+        ReadOnlyCollection<WorkflowDesignerMessageFilter> System.Workflow.ComponentModel.Design.IWorkflowRootDesigner.MessageFilters { get; }
+        bool System.Workflow.ComponentModel.Design.IWorkflowRootDesigner.SupportsLayoutPersistence { get; }
+        public virtual string Text { get; protected set; }
+        protected virtual Rectangle TextRectangle { get; }
+        protected virtual ActivityDesignerVerbCollection Verbs { get; }
+        public virtual bool CanBeParentedTo(CompositeActivityDesigner parentActivityDesigner);
+        protected virtual bool CanConnect(ConnectionPoint source, ConnectionPoint target);
+        protected virtual WorkflowView CreateView(ViewTechnology viewTechnology);
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        protected virtual void DoDefaultAction();
+        public void EnsureVisible();
+        ~ActivityDesigner();
+        public virtual ReadOnlyCollection<ConnectionPoint> GetConnectionPoints(DesignerEdges edges);
+        protected internal virtual ReadOnlyCollection<Point> GetConnections(DesignerEdges edges);
+        public Image GetPreviewImage(Graphics compatibleGraphics);
+        public static ActivityDesigner GetRootDesigner(IServiceProvider serviceProvider);
+        protected object GetService(Type serviceType);
+        public virtual HitTestInfo HitTest(Point point);
+        protected virtual void Initialize(Activity activity);
+        public void Invalidate();
+        public void Invalidate(Rectangle rectangle);
+        public static bool IsCommentedActivity(Activity activity);
+        protected virtual bool IsSupportedActivityType(Type activityType);
+        protected virtual void LoadViewState(BinaryReader reader);
+        protected virtual void OnActivityChanged(ActivityChangedEventArgs e);
+        protected virtual void OnBeginResizing(ActivityDesignerResizeEventArgs e);
+        protected virtual void OnConnected(ConnectionPoint source, ConnectionPoint target);
+        protected virtual void OnDragDrop(ActivityDragEventArgs e);
+        protected virtual void OnDragEnter(ActivityDragEventArgs e);
+        protected virtual void OnDragLeave();
+        protected virtual void OnDragOver(ActivityDragEventArgs e);
+        protected virtual void OnEndResizing();
+        protected internal virtual void OnExecuteDesignerAction(DesignerAction designerAction);
+        protected virtual void OnGiveFeedback(GiveFeedbackEventArgs e);
+        protected virtual void OnKeyDown(KeyEventArgs e);
+        protected virtual void OnKeyUp(KeyEventArgs e);
+        protected virtual void OnLayoutPosition(ActivityDesignerLayoutEventArgs e);
+        protected virtual Size OnLayoutSize(ActivityDesignerLayoutEventArgs e);
+        protected virtual void OnMouseCaptureChanged();
+        protected virtual void OnMouseDoubleClick(MouseEventArgs e);
+        protected virtual void OnMouseDown(MouseEventArgs e);
+        protected virtual void OnMouseDragBegin(Point initialDragPoint, MouseEventArgs e);
+        protected virtual void OnMouseDragEnd();
+        protected virtual void OnMouseDragMove(MouseEventArgs e);
+        protected virtual void OnMouseEnter(MouseEventArgs e);
+        protected virtual void OnMouseHover(MouseEventArgs e);
+        protected virtual void OnMouseLeave();
+        protected virtual void OnMouseMove(MouseEventArgs e);
+        protected virtual void OnMouseUp(MouseEventArgs e);
+        protected virtual void OnPaint(ActivityDesignerPaintEventArgs e);
+        protected virtual void OnProcessMessage(Message message);
+        protected virtual void OnQueryContinueDrag(QueryContinueDragEventArgs e);
+        protected virtual void OnResizing(ActivityDesignerResizeEventArgs e);
+        protected virtual void OnScroll(ScrollBar sender, int value);
+        protected virtual void OnShowSmartTagVerbs(Point smartTagPoint);
+        protected virtual void OnSmartTagVisibilityChanged(bool visible);
+        protected virtual void OnThemeChange(ActivityDesignerTheme newTheme);
+        protected void PerformLayout();
+        protected Point PointToLogical(Point point);
+        protected Point PointToScreen(Point point);
+        protected virtual void PostFilterAttributes(IDictionary attributes);
+        protected virtual void PostFilterEvents(IDictionary events);
+        protected virtual void PostFilterProperties(IDictionary properties);
+        protected virtual void PreFilterAttributes(IDictionary attributes);
+        protected virtual void PreFilterEvents(IDictionary events);
+        protected virtual void PreFilterProperties(IDictionary properties);
+        protected Rectangle RectangleToLogical(Rectangle rectangle);
+        protected Rectangle RectangleToScreen(Rectangle rectangle);
+        protected internal virtual void RefreshDesignerActions();
+        protected void RefreshDesignerVerbs();
+        protected virtual void SaveViewState(BinaryWriter writer);
+        protected void ShowInfoTip(string infoTip);
+        protected void ShowInfoTip(string title, string infoTip);
+        protected void ShowInPlaceTip(string infoTip, Rectangle rectangle);
+        void System.ComponentModel.Design.IDesigner.DoDefaultAction();
+        void System.ComponentModel.Design.IDesigner.Initialize(IComponent component);
+        void System.ComponentModel.Design.IDesignerFilter.PostFilterAttributes(IDictionary attributes);
+        void System.ComponentModel.Design.IDesignerFilter.PostFilterEvents(IDictionary events);
+        void System.ComponentModel.Design.IDesignerFilter.PostFilterProperties(IDictionary properties);
+        void System.ComponentModel.Design.IDesignerFilter.PreFilterAttributes(IDictionary attributes);
+        void System.ComponentModel.Design.IDesignerFilter.PreFilterEvents(IDictionary events);
+        void System.ComponentModel.Design.IDesignerFilter.PreFilterProperties(IDictionary properties);
+        object System.ComponentModel.Design.IRootDesigner.GetView(ViewTechnology technology);
+        bool System.Drawing.Design.IToolboxUser.GetToolSupported(ToolboxItem toolboxItem);
+        void System.Drawing.Design.IToolboxUser.ToolPicked(ToolboxItem toolboxItem);
+        void System.Workflow.ComponentModel.Design.IPersistUIState.LoadViewState(BinaryReader reader);
+        void System.Workflow.ComponentModel.Design.IPersistUIState.SaveViewState(BinaryWriter writer);
+        bool System.Workflow.ComponentModel.Design.IWorkflowRootDesigner.IsSupportedActivityType(Type activityType);
+    }
+    public class ActivityDesignerAccessibleObject : AccessibleObject {
+        public ActivityDesignerAccessibleObject(ActivityDesigner activityDesigner);
+        protected ActivityDesigner ActivityDesigner { get; }
+        public override Rectangle Bounds { get; }
+        public override string DefaultAction { get; }
+        public override string Description { get; }
+        public override string Help { get; }
+        public override string Name { get; set; }
+        public override AccessibleObject Parent { get; }
+        public override AccessibleRole Role { get; }
+        public override AccessibleStates State { get; }
+        public override void DoDefaultAction();
+        protected object GetService(Type serviceType);
+        public override AccessibleObject Navigate(AccessibleNavigation navdir);
+        public override void Select(AccessibleSelection flags);
+    }
+    public sealed class ActivityDesignerGlyphCollection : List<DesignerGlyph> {
+        public ActivityDesignerGlyphCollection();
+        public ActivityDesignerGlyphCollection(IEnumerable<DesignerGlyph> glyphs);
+        public ActivityDesignerGlyphCollection(ActivityDesignerGlyphCollection glyphs);
+    }
+    public class ActivityDesignerLayoutEventArgs : EventArgs {
+        public ActivityDesignerLayoutEventArgs(Graphics graphics, ActivityDesignerTheme designerTheme);
+        public AmbientTheme AmbientTheme { get; }
+        public ActivityDesignerTheme DesignerTheme { get; }
+        public Graphics Graphics { get; }
+    }
+    public class ActivityDesignerLayoutSerializer : WorkflowMarkupSerializer {
+        public ActivityDesignerLayoutSerializer();
+        protected override object CreateInstance(WorkflowMarkupSerializationManager serializationManager, Type type);
+        protected internal override PropertyInfo[] GetProperties(WorkflowMarkupSerializationManager serializationManager, object obj);
+        protected override void OnBeforeSerialize(WorkflowMarkupSerializationManager serializationManager, object obj);
+    }
+    public static class ActivityDesignerPaint {
+        public static void Draw3DButton(Graphics graphics, Image image, Rectangle bounds, float transparency, ButtonState buttonState);
+        public static void DrawExpandButton(Graphics graphics, Rectangle boundingRect, bool drawExpanded, CompositeDesignerTheme compositeDesignerTheme);
+        public static void DrawImage(Graphics graphics, Image image, Rectangle destination, Rectangle source, DesignerContentAlignment alignment, float transparency, bool grayscale);
+        public static void DrawImage(Graphics graphics, Image image, Rectangle destination, DesignerContentAlignment alignment);
+        public static void DrawRoundedRectangle(Graphics graphics, Pen drawingPen, Rectangle rectangle, int radius);
+        public static void DrawText(Graphics graphics, Font font, string text, Rectangle boundingRect, StringAlignment alignment, TextQuality textQuality, Brush textBrush);
+        public static GraphicsPath GetRoundedRectanglePath(Rectangle rectangle, int radius);
+    }
+    public class ActivityDesignerPaintEventArgs : EventArgs {
+        public ActivityDesignerPaintEventArgs(Graphics graphics, Rectangle clipRectangle, Rectangle viewPort, ActivityDesignerTheme designerTheme);
+        public AmbientTheme AmbientTheme { get; }
+        public Rectangle ClipRectangle { get; }
+        public ActivityDesignerTheme DesignerTheme { get; }
+        public Graphics Graphics { get; }
+    }
+    public class ActivityDesignerResizeEventArgs : EventArgs {
+        public ActivityDesignerResizeEventArgs(DesignerEdges sizingEdge, Rectangle newBounds);
+        public Rectangle Bounds { get; }
+        public DesignerEdges SizingEdge { get; }
+    }
+    public class ActivityDesignerTheme : DesignerTheme {
+        public ActivityDesignerTheme(WorkflowTheme theme);
+        public virtual Color BackColorEnd { get; set; }
+        public virtual Color BackColorStart { get; set; }
+        public virtual LinearGradientMode BackgroundStyle { get; set; }
+        public Font BoldFont { get; }
+        public virtual Color BorderColor { get; set; }
+        public Pen BorderPen { get; }
+        public virtual DashStyle BorderStyle { get; set; }
+        public int BorderWidth { get; }
+        public DesignerGeometry DesignerGeometry { get; }
+        public Image DesignerImage { get; }
+        public virtual string DesignerImagePath { get; set; }
+        public Font Font { get; }
+        public virtual Color ForeColor { get; set; }
+        public Brush ForegroundBrush { get; }
+        public Pen ForegroundPen { get; }
+        public Size ImageSize { get; }
+        public Size Size { get; }
+        protected override void Dispose(bool disposing);
+        public Brush GetBackgroundBrush(Rectangle rectangle);
+        public override void Initialize();
+        public override void OnAmbientPropertyChanged(AmbientProperty ambientProperty);
+    }
+    public sealed class ActivityDesignerThemeAttribute : Attribute {
+        public ActivityDesignerThemeAttribute(Type designerThemeType);
+        public Type DesignerThemeType { get; }
+        public string Xml { get; set; }
+    }
+    public class ActivityDesignerVerb : DesignerVerb {
+        public ActivityDesignerVerb(ActivityDesigner activityDesigner, DesignerVerbGroup verbGroup, string text, EventHandler invokeHandler);
+        public ActivityDesignerVerb(ActivityDesigner activityDesigner, DesignerVerbGroup verbGroup, string text, EventHandler invokeHandler, EventHandler statusHandler);
+        public override CommandID CommandID { get; }
+        public DesignerVerbGroup Group { get; }
+        public override int OleStatus { get; }
+    }
+    public sealed class ActivityDesignerVerbCollection : DesignerVerbCollection {
+        public ActivityDesignerVerbCollection();
+        public ActivityDesignerVerbCollection(IEnumerable<ActivityDesignerVerb> verbs);
+        protected override void OnValidate(object value);
+    }
+    public class ActivityDragEventArgs : DragEventArgs {
+        public ReadOnlyCollection<Activity> Activities { get; }
+        public Point DragImageSnapPoint { get; set; }
+        public Point DragInitiationPoint { get; }
+    }
+    public class ActivityPreviewDesigner : SequentialActivityDesigner {
+        public ActivityPreviewDesigner();
+        public override AccessibleObject AccessibilityObject { get; }
+        public override ReadOnlyCollection<ActivityDesigner> ContainedDesigners { get; }
+        protected override int CurrentDropTarget { get; set; }
+        public override object FirstSelectableObject { get; }
+        protected internal override ActivityDesignerGlyphCollection Glyphs { get; }
+        protected override string HelpText { get; set; }
+        public override object LastSelectableObject { get; }
+        public override Point Location { get; set; }
+        public ActivityDesigner PreviewedDesigner { get; }
+        public bool ShowPreview { get; set; }
+        protected override ActivityDesignerVerbCollection Verbs { get; }
+        protected override void Dispose(bool disposing);
+        public override void EnsureVisibleContainedDesigner(ActivityDesigner containedDesigner);
+        protected internal override Rectangle[] GetConnectors();
+        protected override Rectangle[] GetDropTargets(Point dropPoint);
+        public override object GetNextSelectableObject(object obj, DesignerNavigationDirection direction);
+        public override HitTestInfo HitTest(Point point);
+        protected override void Initialize(Activity activity);
+        public override bool IsContainedDesignerVisible(ActivityDesigner containedDesigner);
+        protected override void LoadViewState(BinaryReader reader);
+        protected override void OnContainedActivitiesChanged(ActivityCollectionChangeEventArgs listChangeArgs);
+        protected override void OnDragEnter(ActivityDragEventArgs e);
+        protected override void OnDragOver(ActivityDragEventArgs e);
+        protected override void OnLayoutPosition(ActivityDesignerLayoutEventArgs e);
+        protected override Size OnLayoutSize(ActivityDesignerLayoutEventArgs e);
+        protected override void OnMouseDoubleClick(MouseEventArgs e);
+        protected override void OnMouseDown(MouseEventArgs e);
+        protected override void OnMouseLeave();
+        protected override void OnMouseUp(MouseEventArgs e);
+        protected override void OnPaint(ActivityDesignerPaintEventArgs e);
+        protected override void OnThemeChange(ActivityDesignerTheme newTheme);
+        protected internal override void RefreshDesignerActions();
+        public void RefreshPreview();
+        protected override void SaveViewState(BinaryWriter writer);
+    }
+    public class ActivityPreviewDesignerTheme : CompositeDesignerTheme {
+        public ActivityPreviewDesignerTheme(WorkflowTheme theme);
+        public Color PreviewBackColor { get; set; }
+        public Color PreviewBorderColor { get; set; }
+        public Color PreviewForeColor { get; set; }
+        protected override void Dispose(bool disposing);
+        public override void Initialize();
+        public override void OnAmbientPropertyChanged(AmbientProperty ambientProperty);
+    }
+    public class ActivityToolboxItem : ToolboxItem {
+        public ActivityToolboxItem();
+        protected ActivityToolboxItem(SerializationInfo info, StreamingContext context);
+        public ActivityToolboxItem(Type type);
+        protected override IComponent[] CreateComponentsCore(IDesignerHost host);
+        public virtual IComponent[] CreateComponentsWithUI(IDesignerHost host);
+        public static string GetToolboxDisplayName(Type activityType);
+        public static Image GetToolboxImage(Type activityType);
+    }
+    public enum AmbientProperty {
+        DesignerSize = 0,
+        OperatingSystemSetting = 1,
+    }
+    public class AmbientTheme : DesignerTheme {
+        public AmbientTheme(WorkflowTheme theme);
+        public virtual Color BackColor { get; set; }
+        public Brush BackgroundBrush { get; }
+        public Font BoldFont { get; }
+        public virtual int BorderWidth { get; }
+        public Brush CommentIndicatorBrush { get; }
+        public virtual Color CommentIndicatorColor { get; set; }
+        public Pen CommentIndicatorPen { get; }
+        public virtual DesignerSize DesignerSize { get; set; }
+        public virtual bool DrawGrayscale { get; set; }
+        public virtual bool DrawRounded { get; set; }
+        public virtual bool DrawShadow { get; set; }
+        public Brush DropIndicatorBrush { get; }
+        public virtual Color DropIndicatorColor { get; set; }
+        public Pen DropIndicatorPen { get; }
+        public Font Font { get; }
+        public virtual string FontName { get; set; }
+        public virtual Color ForeColor { get; set; }
+        public Brush ForegroundBrush { get; }
+        public Pen ForegroundPen { get; }
+        public virtual Size GlyphSize { get; }
+        public virtual Color GridColor { get; set; }
+        public virtual Size GridSize { get; }
+        public virtual DashStyle GridStyle { get; set; }
+        public Brush MajorGridBrush { get; }
+        public Pen MajorGridPen { get; }
+        public virtual Size Margin { get; }
+        public Pen MinorGridPen { get; }
+        public Brush ReadonlyIndicatorBrush { get; }
+        public virtual Color ReadonlyIndicatorColor { get; set; }
+        public virtual Color SelectionForeColor { get; set; }
+        public Brush SelectionForegroundBrush { get; }
+        public Pen SelectionForegroundPen { get; }
+        public virtual Color SelectionPatternColor { get; set; }
+        public Pen SelectionPatternPen { get; }
+        public virtual Size SelectionSize { get; }
+        public virtual bool ShowConfigErrors { get; set; }
+        public virtual bool ShowDesignerBorder { get; set; }
+        public virtual bool ShowGrid { get; set; }
+        public virtual TextQuality TextQuality { get; set; }
+        public virtual bool UseOperatingSystemSettings { get; internal set; }
+        public virtual DesignerContentAlignment WatermarkAlignment { get; set; }
+        public virtual string WatermarkImagePath { get; set; }
+        public Image WorkflowWatermarkImage { get; }
+        protected override void Dispose(bool disposing);
+        public override void Initialize();
+        public override void OnAmbientPropertyChanged(AmbientProperty ambientProperty);
+    }
+    public class BindUITypeEditor : UITypeEditor {
+        public BindUITypeEditor();
+        public override object EditValue(ITypeDescriptorContext context, IServiceProvider serviceProvider, object value);
+        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext typeDescriptorContext);
+    }
+    public class CommentGlyph : DesignerGlyph {
+        public CommentGlyph();
+        public override int Priority { get; }
+        public override Rectangle GetBounds(ActivityDesigner designer, bool activated);
+        protected override void OnPaint(Graphics graphics, bool activated, AmbientTheme ambientTheme, ActivityDesigner designer);
+    }
+    public abstract class CompositeActivityDesigner : ActivityDesigner {
+        protected CompositeActivityDesigner();
+        public override AccessibleObject AccessibilityObject { get; }
+        public virtual bool CanExpandCollapse { get; }
+        public virtual ReadOnlyCollection<ActivityDesigner> ContainedDesigners { get; }
+        protected virtual Rectangle ExpandButtonRectangle { get; }
+        public virtual bool Expanded { get; set; }
+        public virtual object FirstSelectableObject { get; }
+        protected internal override ActivityDesignerGlyphCollection Glyphs { get; }
+        protected override Rectangle ImageRectangle { get; }
+        public bool IsEditable { get; }
+        public virtual object LastSelectableObject { get; }
+        public override Point Location { get; set; }
+        protected override Rectangle TextRectangle { get; }
+        protected virtual int TitleHeight { get; }
+        public virtual bool CanInsertActivities(HitTestInfo insertLocation, ReadOnlyCollection<Activity> activitiesToInsert);
+        public virtual bool CanMoveActivities(HitTestInfo moveLocation, ReadOnlyCollection<Activity> activitiesToMove);
+        public virtual bool CanRemoveActivities(ReadOnlyCollection<Activity> activitiesToRemove);
+        public static Activity[] DeserializeActivitiesFromDataObject(IServiceProvider serviceProvider, IDataObject dataObj);
+        protected override void Dispose(bool disposing);
+        public virtual void EnsureVisibleContainedDesigner(ActivityDesigner containedDesigner);
+        public static ActivityDesigner[] GetIntersectingDesigners(ActivityDesigner topLevelDesigner, Rectangle rectangle);
+        public virtual object GetNextSelectableObject(object current, DesignerNavigationDirection direction);
+        public override HitTestInfo HitTest(Point point);
+        protected override void Initialize(Activity activity);
+        public static void InsertActivities(CompositeActivityDesigner compositeActivityDesigner, HitTestInfo insertLocation, ReadOnlyCollection<Activity> activitiesToInsert, string undoTransactionDescription);
+        public virtual void InsertActivities(HitTestInfo insertLocation, ReadOnlyCollection<Activity> activitiesToInsert);
+        public virtual bool IsContainedDesignerVisible(ActivityDesigner containedDesigner);
+        protected override void LoadViewState(BinaryReader reader);
+        public virtual void MoveActivities(HitTestInfo moveLocation, ReadOnlyCollection<Activity> activitiesToMove);
+        public static void MoveDesigners(ActivityDesigner activityDesigner, bool moveBack);
+        protected virtual void OnContainedActivitiesChanged(ActivityCollectionChangeEventArgs listChangeArgs);
+        protected virtual void OnContainedActivitiesChanging(ActivityCollectionChangeEventArgs listChangeArgs);
+        protected virtual void OnContainedActivityChanged(ActivityChangedEventArgs e);
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected override void OnLayoutPosition(ActivityDesignerLayoutEventArgs e);
+        protected override Size OnLayoutSize(ActivityDesignerLayoutEventArgs e);
+        protected override void OnMouseDown(MouseEventArgs e);
+        protected override void OnPaint(ActivityDesignerPaintEventArgs e);
+        protected override void OnThemeChange(ActivityDesignerTheme designerTheme);
+        protected void PaintContainedDesigners(ActivityDesignerPaintEventArgs e);
+        public virtual void RemoveActivities(ReadOnlyCollection<Activity> activitiesToRemove);
+        public static void RemoveActivities(IServiceProvider serviceProvider, ReadOnlyCollection<Activity> activitiesToRemove, string transactionDescription);
+        protected override void SaveViewState(BinaryWriter writer);
+        public static IDataObject SerializeActivitiesToDataObject(IServiceProvider serviceProvider, Activity[] activities);
+    }
+    public class CompositeActivityDesignerLayoutSerializer : ActivityDesignerLayoutSerializer {
+        public CompositeActivityDesignerLayoutSerializer();
+        protected internal override PropertyInfo[] GetProperties(WorkflowMarkupSerializationManager serializationManager, object obj);
+    }
+    public class CompositeDesignerAccessibleObject : ActivityDesignerAccessibleObject {
+        public CompositeDesignerAccessibleObject(CompositeActivityDesigner activityDesigner);
+        public override AccessibleStates State { get; }
+        public override AccessibleObject GetChild(int index);
+        public override int GetChildCount();
+    }
+    public class CompositeDesignerTheme : ActivityDesignerTheme {
+        public CompositeDesignerTheme(WorkflowTheme theme);
+        public virtual LineAnchor ConnectorEndCap { get; set; }
+        public virtual Size ConnectorSize { get; }
+        public virtual LineAnchor ConnectorStartCap { get; set; }
+        public virtual Size ExpandButtonSize { get; }
+        public virtual bool ShowDropShadow { get; set; }
+        public virtual DesignerContentAlignment WatermarkAlignment { get; set; }
+        public Image WatermarkImage { get; }
+        public virtual string WatermarkImagePath { get; set; }
+        protected override void Dispose(bool disposing);
+        public Brush GetExpandButtonBackgroundBrush(Rectangle rectangle);
+        public override void Initialize();
+        public override void OnAmbientPropertyChanged(AmbientProperty ambientProperty);
+    }
+    public class ConfigErrorGlyph : DesignerGlyph {
+        public ConfigErrorGlyph();
+        public override bool CanBeActivated { get; }
+        public override int Priority { get; }
+        public override Rectangle GetBounds(ActivityDesigner designer, bool activated);
+        protected override void OnActivate(ActivityDesigner designer);
+        protected override void OnPaint(Graphics graphics, bool activated, AmbientTheme ambientTheme, ActivityDesigner designer);
+    }
+    public class ConnectionPoint {
+        public ConnectionPoint(ActivityDesigner associatedDesigner, DesignerEdges designerEdge, int connectionIndex);
+        public ActivityDesigner AssociatedDesigner { get; }
+        public virtual Rectangle Bounds { get; }
+        public DesignerEdges ConnectionEdge { get; }
+        public int ConnectionIndex { get; }
+        public virtual Point Location { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public void OnPaint(ActivityDesignerPaintEventArgs e, bool drawHighlighted);
+    }
+    public class Connector : IDisposable {
+        public Connector(ConnectionPoint source, ConnectionPoint target);
+        public virtual AccessibleObject AccessibilityObject { get; }
+        public Rectangle Bounds { get; }
+        public bool ConnectorModified { get; }
+        public virtual ReadOnlyCollection<Point> ConnectorSegments { get; }
+        protected internal virtual ICollection<Rectangle> ExcludedRoutingRectangles { get; }
+        public FreeformActivityDesigner ParentDesigner { get; }
+        protected WorkflowView ParentView { get; }
+        public ConnectionPoint Source { get; set; }
+        public ConnectionPoint Target { get; set; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        protected virtual object GetService(Type serviceType);
+        public virtual bool HitTest(Point point);
+        public void Invalidate();
+        public virtual void Offset(Size size);
+        protected internal virtual void OnLayout(ActivityDesignerLayoutEventArgs e);
+        protected internal virtual void OnPaint(ActivityDesignerPaintEventArgs e);
+        protected internal virtual void OnPaintEdited(ActivityDesignerPaintEventArgs e, Point[] segments, Point[] segmentEditPoints);
+        protected internal virtual void OnPaintSelected(ActivityDesignerPaintEventArgs e, bool primarySelection, Point[] segmentEditPoints);
+        protected void PerformLayout();
+        protected internal void SetConnectorSegments(ICollection<Point> segments);
+        void System.IDisposable.Dispose();
+    }
+    public class ConnectorAccessibleObject : AccessibleObject {
+        public ConnectorAccessibleObject(Connector connector);
+        public override Rectangle Bounds { get; }
+        public override string Name { get; set; }
+        public override AccessibleObject Parent { get; }
+        public override AccessibleRole Role { get; }
+        public override AccessibleObject HitTest(int x, int y);
+    }
+    public class ConnectorEventArgs : EventArgs {
+        public Connector Connector { get; }
+    }
+    public delegate void ConnectorEventHandler(object sender, ConnectorEventArgs e);
+    public class ConnectorHitTestInfo : HitTestInfo {
+        public ConnectorHitTestInfo(CompositeActivityDesigner compositeActivityDesigner, HitTestLocations flags, int connector);
+        public override Rectangle Bounds { get; }
+        public override object SelectableObject { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public override int MapToIndex();
+    }
+    public class ConnectorLayoutSerializer : WorkflowMarkupSerializer {
+        public ConnectorLayoutSerializer();
+        protected override object CreateInstance(WorkflowMarkupSerializationManager serializationManager, Type type);
+        protected Dictionary<string, string> GetConnectorConstructionArguments(WorkflowMarkupSerializationManager serializationManager, Type type);
+        protected internal override PropertyInfo[] GetProperties(WorkflowMarkupSerializationManager serializationManager, object obj);
+        protected override void OnAfterDeserialize(WorkflowMarkupSerializationManager serializationManager, object obj);
+    }
+    public sealed class DesignerAction {
+        public DesignerAction(ActivityDesigner activityDesigner, int actionId, string text);
+        public DesignerAction(ActivityDesigner activityDesigner, int actionId, string text, Image image);
+        public int ActionId { get; }
+        public Image Image { get; }
+        public string PropertyName { get; set; }
+        public string Text { get; }
+        public IDictionary UserData { get; }
+        public void Invoke();
+    }
+    public enum DesignerContentAlignment {
+        Bottom = 8,
+        BottomCenter = 24,
+        BottomLeft = 9,
+        BottomRight = 12,
+        Center = 16,
+        CenterLeft = 17,
+        CenterRight = 20,
+        Fill = 32,
+        Left = 1,
+        Right = 4,
+        Top = 2,
+        TopCenter = 18,
+        TopLeft = 3,
+        TopRight = 6,
+    }
+    public enum DesignerEdges {
+        All = 15,
+        Bottom = 8,
+        Left = 1,
+        None = 0,
+        Right = 4,
+        Top = 2,
+    }
+    public enum DesignerGeometry {
+        Rectangle = 0,
+        RoundedRectangle = 1,
+    }
+    public abstract class DesignerGlyph {
+        public const int HighestPriority = 0;
+        public const int LowestPriority = 1000000;
+        public const int NormalPriority = 10000;
+        protected DesignerGlyph();
+        public virtual bool CanBeActivated { get; }
+        public virtual int Priority { get; }
+        public virtual Rectangle GetBounds(ActivityDesigner designer, bool activated);
+        protected virtual void OnActivate(ActivityDesigner designer);
+        protected abstract void OnPaint(Graphics graphics, bool activated, AmbientTheme ambientTheme, ActivityDesigner designer);
+    }
+    public enum DesignerNavigationDirection {
+        Down = 0,
+        Left = 2,
+        Right = 3,
+        Up = 1,
+    }
+    public enum DesignerSize {
+        Large = 2,
+        Medium = 1,
+        Small = 0,
+    }
+    public abstract class DesignerTheme : IDisposable, IPropertyValueProvider {
+        protected DesignerTheme(WorkflowTheme theme);
+        public virtual string ApplyTo { get; set; }
+        protected WorkflowTheme ContainingTheme { get; }
+        public virtual Type DesignerType { get; set; }
+        public bool ReadOnly { get; internal set; }
+        protected virtual void Dispose(bool disposing);
+        ~DesignerTheme();
+        public virtual void Initialize();
+        public virtual void OnAmbientPropertyChanged(AmbientProperty ambientProperty);
+        void System.IDisposable.Dispose();
+    }
+    public enum DesignerVerbGroup {
+        Actions = 4,
+        Edit = 2,
+        General = 0,
+        Misc = 5,
+        Options = 3,
+        View = 1,
+    }
+    public class DesignerView {
+        public DesignerView(int viewId, string text, Image image);
+        public DesignerView(int viewId, string text, Image image, ActivityDesigner associatedDesigner);
+        public virtual ActivityDesigner AssociatedDesigner { get; }
+        public Image Image { get; }
+        public string Text { get; }
+        public IDictionary UserData { get; }
+        public int ViewId { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public virtual void OnActivate();
+        public virtual void OnDeactivate();
+    }
+    public class FreeformActivityDesigner : CompositeActivityDesigner {
+        public FreeformActivityDesigner();
+        public override AccessibleObject AccessibilityObject { get; }
+        public bool AutoSize { get; set; }
+        public Size AutoSizeMargin { get; set; }
+        public AutoSizeMode AutoSizeMode { get; set; }
+        public override bool CanExpandCollapse { get; }
+        public ReadOnlyCollection<Connector> Connectors { get; }
+        public bool EnableUserDrawnConnectors { get; set; }
+        protected internal override bool EnableVisualResizing { get; }
+        public override object FirstSelectableObject { get; }
+        protected internal override ActivityDesignerGlyphCollection Glyphs { get; }
+        public override object LastSelectableObject { get; }
+        public override Point Location { get; set; }
+        public override Size MinimumSize { get; }
+        protected virtual bool ShowConnectorsInForeground { get; }
+        public event ConnectorEventHandler ConnectorAdded;
+        public event ConnectorEventHandler ConnectorChanged;
+        public event ConnectorEventHandler ConnectorRemoved;
+        public Connector AddConnector(ConnectionPoint source, ConnectionPoint target);
+        public void BringToFront(ActivityDesigner containedDesigner);
+        protected internal virtual bool CanConnectContainedDesigners(ConnectionPoint source, ConnectionPoint target);
+        protected internal virtual bool CanResizeContainedDesigner(ActivityDesigner containedDesigner);
+        protected internal virtual Connector CreateConnector(ConnectionPoint source, ConnectionPoint target);
+        protected override void Dispose(bool disposing);
+        public override object GetNextSelectableObject(object current, DesignerNavigationDirection navigate);
+        public override HitTestInfo HitTest(Point point);
+        protected override void Initialize(Activity activity);
+        public override void InsertActivities(HitTestInfo insertLocation, ReadOnlyCollection<Activity> activitiesToInsert);
+        public override void MoveActivities(HitTestInfo moveLocation, ReadOnlyCollection<Activity> activitiesToMove);
+        public void MoveContainedDesigner(ActivityDesigner containedDesigner, Point newLocation);
+        protected virtual void OnConnectorAdded(ConnectorEventArgs e);
+        protected internal virtual void OnConnectorChanged(ConnectorEventArgs e);
+        protected virtual void OnConnectorRemoved(ConnectorEventArgs e);
+        protected override void OnContainedActivitiesChanging(ActivityCollectionChangeEventArgs listChangeArgs);
+        protected internal virtual void OnContainedDesignersConnected(ConnectionPoint source, ConnectionPoint target);
+        protected override void OnDragDrop(ActivityDragEventArgs e);
+        protected override void OnDragOver(ActivityDragEventArgs e);
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected override void OnLayoutPosition(ActivityDesignerLayoutEventArgs e);
+        protected override Size OnLayoutSize(ActivityDesignerLayoutEventArgs e);
+        protected override void OnResizing(ActivityDesignerResizeEventArgs e);
+        protected override void OnThemeChange(ActivityDesignerTheme newTheme);
+        public void RemoveConnector(Connector connector);
+        public void ResizeContainedDesigner(ActivityDesigner containedDesigner, Size newSize);
+        public void SendToBack(ActivityDesigner containedDesigner);
+    }
+    public class FreeformActivityDesignerLayoutSerializer : CompositeActivityDesignerLayoutSerializer {
+        public FreeformActivityDesignerLayoutSerializer();
+        protected internal override PropertyInfo[] GetProperties(WorkflowMarkupSerializationManager serializationManager, object obj);
+    }
+    public class HitTestInfo {
+        public HitTestInfo(ActivityDesigner designer, HitTestLocations location);
+        public ActivityDesigner AssociatedDesigner { get; }
+        public virtual Rectangle Bounds { get; }
+        public HitTestLocations HitLocation { get; }
+        public static HitTestInfo Nowhere { get; }
+        public virtual object SelectableObject { get; }
+        public IDictionary UserData { get; }
+        public virtual int MapToIndex();
+    }
+    public enum HitTestLocations {
+        ActionArea = 2,
+        Bottom = 32,
+        Connector = 64,
+        Designer = 1,
+        Left = 4,
+        None = 0,
+        Right = 16,
+        Top = 8,
+    }
+    public interface IDesignerGlyphProvider {
+        ActivityDesignerGlyphCollection GetGlyphs(ActivityDesigner activityDesigner);
+    }
+    public interface IDesignerGlyphProviderService {
+        ReadOnlyCollection<IDesignerGlyphProvider> GlyphProviders { get; }
+        void AddGlyphProvider(IDesignerGlyphProvider glyphProvider);
+        void RemoveGlyphProvider(IDesignerGlyphProvider glyphProvider);
+    }
+    public interface IDesignerVerbProvider {
+        ActivityDesignerVerbCollection GetVerbs(ActivityDesigner activityDesigner);
+    }
+    public interface IDesignerVerbProviderService {
+        ReadOnlyCollection<IDesignerVerbProvider> VerbProviders { get; }
+        void AddVerbProvider(IDesignerVerbProvider verbProvider);
+        void RemoveVerbProvider(IDesignerVerbProvider verbProvider);
+    }
+    public interface IExtendedUIService {
+        void AddAssemblyReference(AssemblyName assemblyName);
+        void AddDesignerActions(DesignerAction[] actions);
+        DialogResult AddWebReference(out Uri url, out Type proxyClass);
+        Type GetProxyClassForUrl(Uri url);
+        ITypeDescriptorContext GetSelectedPropertyContext();
+        Uri GetUrlForProxyClass(Type proxyClass);
+        Dictionary<string, Type> GetXsdProjectItemsInfo();
+        bool NavigateToProperty(string propName);
+        void RemoveDesignerActions();
+        void ShowToolsOptions();
+    }
+    public interface IExtendedUIService2 {
+        Assembly GetReflectionAssembly(AssemblyName assemblyName);
+        Type GetRuntimeType(Type reflectionType);
+        long GetTargetFrameworkVersion();
+        bool IsSupportedType(Type type);
+    }
+    public interface IIdentifierCreationService {
+        void EnsureUniqueIdentifiers(CompositeActivity parentActivity, ICollection childActivities);
+        void ValidateIdentifier(Activity activity, string identifier);
+    }
+    public interface IMemberCreationService {
+        void CreateEvent(string className, string eventName, Type eventType, AttributeInfo[] attributes, bool emitDependencyProperty);
+        void CreateField(string className, string fieldName, Type fieldType, Type[] genericParameterTypes, MemberAttributes attributes, CodeSnippetExpression initializationExpression, bool overwriteExisting);
+        void CreateProperty(string className, string propertyName, Type propertyType, AttributeInfo[] attributes, bool emitDependencyProperty, bool isMetaProperty, bool isAttached, Type ownerType, bool isReadOnly);
+        void RemoveEvent(string className, string eventName, Type eventType);
+        void RemoveProperty(string className, string propertyName, Type propertyType);
+        void ShowCode();
+        void ShowCode(Activity activity, string methodName, Type delegateType);
+        void UpdateBaseType(string className, Type baseType);
+        void UpdateEvent(string className, string oldEventName, Type oldEventType, string newEventName, Type newEventType, AttributeInfo[] attributes, bool emitDependencyProperty, bool isMetaProperty);
+        void UpdateProperty(string className, string oldPropertyName, Type oldPropertyType, string newPropertyName, Type newPropertyType, AttributeInfo[] attributes, bool emitDependencyProperty, bool isMetaProperty);
+        void UpdateTypeName(string oldClassName, string newClassName);
+    }
+    public interface IPersistUIState {
+        void LoadViewState(BinaryReader reader);
+        void SaveViewState(BinaryWriter writer);
+    }
+    public interface ITypeFilterProvider {
+        string FilterDescription { get; }
+        bool CanFilterType(Type type, bool throwOnError);
+    }
+    public interface ITypeProviderCreator {
+        Assembly GetLocalAssembly(object obj);
+        Assembly GetTransientAssembly(AssemblyName assemblyName);
+        ITypeProvider GetTypeProvider(object obj);
+        ITypeResolutionService GetTypeResolutionService(object obj);
+    }
+    public interface IWorkflowRootDesigner : IDesigner, IDisposable, IRootDesigner {
+        CompositeActivityDesigner InvokingDesigner { get; set; }
+        ReadOnlyCollection<WorkflowDesignerMessageFilter> MessageFilters { get; }
+        bool SupportsLayoutPersistence { get; }
+        bool IsSupportedActivityType(Type activityType);
+    }
+    public enum LineAnchor {
+        Arrow = 1,
+        ArrowAnchor = 2,
+        Diamond = 3,
+        DiamondAnchor = 4,
+        None = 0,
+        Rectangle = 7,
+        RectangleAnchor = 8,
+        Round = 5,
+        RoundAnchor = 6,
+        RoundedRectangle = 9,
+        RoundedRectangleAnchor = 10,
+    }
+    public class LockedActivityGlyph : DesignerGlyph {
+        public LockedActivityGlyph();
+        public override int Priority { get; }
+        public override Rectangle GetBounds(ActivityDesigner designer, bool activated);
+        protected override void OnPaint(Graphics graphics, bool activated, AmbientTheme ambientTheme, ActivityDesigner designer);
+    }
+    public class ParallelActivityDesigner : StructuredCompositeActivityDesigner {
+        public ParallelActivityDesigner();
+        public override object FirstSelectableObject { get; }
+        public override object LastSelectableObject { get; }
+        protected override ActivityDesignerVerbCollection Verbs { get; }
+        public override bool CanMoveActivities(HitTestInfo moveLocation, ReadOnlyCollection<Activity> activitiesToMove);
+        public override bool CanRemoveActivities(ReadOnlyCollection<Activity> activitiesToRemove);
+        protected override Rectangle[] GetDropTargets(Point dropPoint);
+        public override object GetNextSelectableObject(object obj, DesignerNavigationDirection direction);
+        protected virtual CompositeActivity OnCreateNewBranch();
+        protected override void OnLayoutPosition(ActivityDesignerLayoutEventArgs e);
+        protected override Size OnLayoutSize(ActivityDesignerLayoutEventArgs e);
+        protected override void OnPaint(ActivityDesignerPaintEventArgs e);
+    }
+    public class ReadOnlyActivityGlyph : DesignerGlyph {
+        public ReadOnlyActivityGlyph();
+        public override int Priority { get; }
+        public override Rectangle GetBounds(ActivityDesigner designer, bool activated);
+        protected override void OnPaint(Graphics graphics, bool activated, AmbientTheme ambientTheme, ActivityDesigner designer);
+    }
+    public abstract class SelectionGlyph : DesignerGlyph {
+        protected SelectionGlyph();
+        public abstract bool IsPrimarySelection { get; }
+        public override int Priority { get; }
+        public override Rectangle GetBounds(ActivityDesigner designer, bool activated);
+        public virtual Rectangle[] GetGrabHandles(ActivityDesigner designer);
+        protected override void OnPaint(Graphics graphics, bool activated, AmbientTheme ambientTheme, ActivityDesigner designer);
+    }
+    public class SequenceDesigner : SequentialActivityDesigner {
+        public SequenceDesigner();
+    }
+    public class SequenceDesignerAccessibleObject : CompositeDesignerAccessibleObject {
+        public SequenceDesignerAccessibleObject(SequentialActivityDesigner activityDesigner);
+        public override AccessibleObject GetChild(int index);
+        public override int GetChildCount();
+        public override AccessibleObject Navigate(AccessibleNavigation navdir);
+    }
+    public class SequentialActivityDesigner : StructuredCompositeActivityDesigner {
+        public SequentialActivityDesigner();
+        public override AccessibleObject AccessibilityObject { get; }
+        public override bool CanExpandCollapse { get; }
+        public override bool Expanded { get; set; }
+        public override object FirstSelectableObject { get; }
+        protected internal override ActivityDesignerGlyphCollection Glyphs { get; }
+        protected virtual string HelpText { get; set; }
+        protected virtual Rectangle HelpTextRectangle { get; }
+        protected Size HelpTextSize { get; }
+        public override object LastSelectableObject { get; }
+        protected internal virtual Rectangle[] GetConnectors();
+        protected override Rectangle[] GetDropTargets(Point dropPoint);
+        public override object GetNextSelectableObject(object obj, DesignerNavigationDirection direction);
+        public override HitTestInfo HitTest(Point point);
+        protected override void Initialize(Activity activity);
+        protected override void OnLayoutPosition(ActivityDesignerLayoutEventArgs e);
+        protected override Size OnLayoutSize(ActivityDesignerLayoutEventArgs e);
+        protected override void OnPaint(ActivityDesignerPaintEventArgs e);
+    }
+    public class SequentialWorkflowHeaderFooter {
+        public SequentialWorkflowHeaderFooter(SequentialWorkflowRootDesigner parent, bool isHeader);
+        protected SequentialWorkflowRootDesigner AssociatedDesigner { get; }
+        public virtual Rectangle Bounds { get; }
+        public virtual Image Image { get; set; }
+        public virtual Rectangle ImageRectangle { get; }
+        public virtual string Text { get; set; }
+        public virtual Rectangle TextRectangle { get; }
+        public virtual void OnLayout(ActivityDesignerLayoutEventArgs e);
+        public virtual void OnPaint(ActivityDesignerPaintEventArgs e);
+    }
+    public class SequentialWorkflowRootDesigner : SequentialActivityDesigner {
+        public SequentialWorkflowRootDesigner();
+        public override bool CanExpandCollapse { get; }
+        protected virtual SequentialWorkflowHeaderFooter Footer { get; }
+        protected internal override ActivityDesignerGlyphCollection Glyphs { get; }
+        protected virtual SequentialWorkflowHeaderFooter Header { get; }
+        public override Image Image { get; }
+        protected override Rectangle ImageRectangle { get; }
+        protected override CompositeActivityDesigner InvokingDesigner { get; set; }
+        public override Size MinimumSize { get; }
+        protected override bool ShowSmartTag { get; }
+        protected override Rectangle SmartTagRectangle { get; }
+        public override string Text { get; }
+        protected override int TitleHeight { get; }
+        public override bool CanBeParentedTo(CompositeActivityDesigner parentActivityDesigner);
+        protected override ReadOnlyCollection<Point> GetInnerConnections(DesignerEdges edges);
+        protected override Size OnLayoutSize(ActivityDesignerLayoutEventArgs e);
+        protected override void OnPaint(ActivityDesignerPaintEventArgs e);
+        protected override void OnSmartTagVisibilityChanged(bool visible);
+    }
+    public sealed class ShadowGlyph : DesignerGlyph {
+        public ShadowGlyph();
+        public override int Priority { get; }
+        public override Rectangle GetBounds(ActivityDesigner designer, bool activated);
+        protected override void OnPaint(Graphics graphics, bool activated, AmbientTheme ambientTheme, ActivityDesigner designer);
+    }
+    public abstract class StructuredCompositeActivityDesigner : CompositeActivityDesigner {
+        protected StructuredCompositeActivityDesigner();
+        public DesignerView ActiveView { get; set; }
+        public override ReadOnlyCollection<ActivityDesigner> ContainedDesigners { get; }
+        protected virtual int CurrentDropTarget { get; set; }
+        public override object FirstSelectableObject { get; }
+        public override object LastSelectableObject { get; }
+        public override Size MinimumSize { get; }
+        protected override bool ShowSmartTag { get; }
+        protected override ReadOnlyCollection<ActivityDesignerVerb> SmartTagVerbs { get; }
+        public virtual ReadOnlyCollection<DesignerView> Views { get; }
+        public override bool CanInsertActivities(HitTestInfo insertLocation, ReadOnlyCollection<Activity> activitiesToInsert);
+        public override bool CanRemoveActivities(ReadOnlyCollection<Activity> activitiesToRemove);
+        protected void DrawConnectors(Graphics graphics, Pen pen, Point[] points, LineAnchor startCap, LineAnchor endCap);
+        public override void EnsureVisibleContainedDesigner(ActivityDesigner containedDesigner);
+        protected virtual Rectangle[] GetDropTargets(Point dropPoint);
+        protected virtual ReadOnlyCollection<Point> GetInnerConnections(DesignerEdges edges);
+        public override object GetNextSelectableObject(object current, DesignerNavigationDirection direction);
+        protected override void Initialize(Activity activity);
+        public override void InsertActivities(HitTestInfo insertLocation, ReadOnlyCollection<Activity> activitiesToInsert);
+        protected override void LoadViewState(BinaryReader reader);
+        public override void MoveActivities(HitTestInfo moveLocation, ReadOnlyCollection<Activity> activitiesToMove);
+        protected override void OnActivityChanged(ActivityChangedEventArgs e);
+        protected override void OnContainedActivitiesChanging(ActivityCollectionChangeEventArgs listChangeArgs);
+        protected override void OnDragDrop(ActivityDragEventArgs e);
+        protected override void OnDragEnter(ActivityDragEventArgs e);
+        protected override void OnDragLeave();
+        protected override void OnDragOver(ActivityDragEventArgs e);
+        protected override void OnLayoutPosition(ActivityDesignerLayoutEventArgs e);
+        protected override Size OnLayoutSize(ActivityDesignerLayoutEventArgs e);
+        protected override void OnShowSmartTagVerbs(Point smartTagPoint);
+        protected virtual void OnViewChanged(DesignerView view);
+        protected override void SaveViewState(BinaryWriter writer);
+    }
+    public enum TextQuality {
+        Aliased = 0,
+        AntiAliased = 1,
+    }
+    public sealed class ThemeConfigurationDialog : Form {
+        public ThemeConfigurationDialog(IServiceProvider serviceProvider);
+        public ThemeConfigurationDialog(IServiceProvider serviceProvider, WorkflowTheme theme);
+        public WorkflowTheme ComposedTheme { get; }
+        protected override void Dispose(bool disposing);
+        protected override void OnClosing(CancelEventArgs e);
+        protected override void OnHelpRequested(HelpEventArgs e);
+        protected override void OnLoad(EventArgs e);
+    }
+    public enum ThemeType {
+        Default = 0,
+        System = 1,
+        UserDefined = 2,
+    }
+    public sealed class TypeBrowserDialog : Form, IServiceProvider, ISite {
+        public TypeBrowserDialog(IServiceProvider serviceProvider, ITypeFilterProvider filterProvider, string selectedTypeName);
+        public TypeBrowserDialog(IServiceProvider serviceProvider, ITypeFilterProvider filterProvider, string selectedTypeName, TypeProvider typeProvider);
+        public Type SelectedType { get; }
+        IComponent System.ComponentModel.ISite.Component { get; }
+        IContainer System.ComponentModel.ISite.Container { get; }
+        bool System.ComponentModel.ISite.DesignMode { get; }
+        string System.ComponentModel.ISite.Name { get; set; }
+        protected override void Dispose(bool disposing);
+        protected override void OnClosing(CancelEventArgs e);
+        protected override void OnHelpRequested(HelpEventArgs e);
+        protected override void OnLoad(EventArgs e);
+        protected override void OnPaint(PaintEventArgs paintArgs);
+        protected override bool ProcessCmdKey(ref Message msg, Keys keyData);
+        object System.IServiceProvider.GetService(Type serviceType);
+    }
+    public class TypeBrowserEditor : UITypeEditor {
+        public TypeBrowserEditor();
+        public override object EditValue(ITypeDescriptorContext typeDescriptorContext, IServiceProvider serviceProvider, object value);
+        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext typeDescriptorContext);
+    }
+    public sealed class TypeFilterProviderAttribute : Attribute {
+        public TypeFilterProviderAttribute(string typeName);
+        public TypeFilterProviderAttribute(Type type);
+        public string TypeFilterProviderTypeName { get; }
+    }
+    public abstract class WorkflowDesignerLoader : BasicDesignerLoader {
+        protected WorkflowDesignerLoader();
+        public abstract string FileName { get; }
+        public virtual bool InDebugMode { get; }
+        protected virtual TypeDescriptionProvider TargetFrameworkTypeDescriptionProvider { get; }
+        public void AddActivityToDesigner(Activity activity);
+        public override void Dispose();
+        public override void Flush();
+        public virtual void ForceReload();
+        public abstract TextReader GetFileReader(string filePath);
+        public abstract TextWriter GetFileWriter(string filePath);
+        protected override void Initialize();
+        protected void LoadDesignerLayout(XmlReader layoutReader, out IList layoutLoadErrors);
+        protected void LoadDesignerLayoutFromResource(Type type, string manifestResourceName, out IList errors);
+        protected override void OnEndLoad(bool successful, ICollection errors);
+        protected override void PerformFlush(IDesignerSerializationManager serializationManager);
+        protected override void PerformLoad(IDesignerSerializationManager serializationManager);
+        public void RemoveActivityFromDesigner(Activity activity);
+        protected void SaveDesignerLayout(XmlWriter layoutWriter, ActivityDesigner rootDesigner, out IList layoutSaveErrors);
+    }
+    public abstract class WorkflowDesignerMessageFilter : IDisposable, IWorkflowDesignerMessageSink {
+        protected WorkflowDesignerMessageFilter();
+        protected HitTestInfo MessageHitTestContext { get; }
+        protected WorkflowView ParentView { get; }
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        ~WorkflowDesignerMessageFilter();
+        protected virtual void Initialize(WorkflowView parentView);
+        protected virtual bool OnDragDrop(DragEventArgs eventArgs);
+        protected virtual bool OnDragEnter(DragEventArgs eventArgs);
+        protected virtual bool OnDragLeave();
+        protected virtual bool OnDragOver(DragEventArgs eventArgs);
+        protected virtual bool OnGiveFeedback(GiveFeedbackEventArgs eventArgs);
+        protected virtual bool OnKeyDown(KeyEventArgs eventArgs);
+        protected virtual bool OnKeyUp(KeyEventArgs eventArgs);
+        protected virtual void OnLayout(LayoutEventArgs eventArgs);
+        protected virtual bool OnMouseCaptureChanged();
+        protected virtual bool OnMouseDoubleClick(MouseEventArgs eventArgs);
+        protected virtual bool OnMouseDown(MouseEventArgs eventArgs);
+        protected virtual bool OnMouseEnter(MouseEventArgs eventArgs);
+        protected virtual bool OnMouseHover(MouseEventArgs eventArgs);
+        protected virtual bool OnMouseLeave();
+        protected virtual bool OnMouseMove(MouseEventArgs eventArgs);
+        protected virtual bool OnMouseUp(MouseEventArgs eventArgs);
+        protected virtual bool OnMouseWheel(MouseEventArgs eventArgs);
+        protected virtual bool OnPaint(PaintEventArgs eventArgs, Rectangle viewPort, AmbientTheme ambientTheme);
+        protected virtual bool OnPaintWorkflowAdornments(PaintEventArgs eventArgs, Rectangle viewPort, AmbientTheme ambientTheme);
+        protected virtual bool OnQueryContinueDrag(QueryContinueDragEventArgs eventArgs);
+        protected virtual bool OnScroll(ScrollBar sender, int value);
+        protected virtual bool OnShowContextMenu(Point screenMenuPoint);
+        protected virtual void OnThemeChange();
+        protected virtual bool ProcessMessage(Message message);
+    }
+    public sealed class WorkflowMenuCommands : StandardCommands {
+        public static readonly CommandID BreakpointActionMenu;
+        public static readonly CommandID BreakpointConditionMenu;
+        public static readonly CommandID BreakpointConstraintsMenu;
+        public static readonly CommandID BreakpointHitCountMenu;
+        public static readonly CommandID BreakpointLocationMenu;
+        public static readonly CommandID ChangeTheme;
+        public static readonly CommandID ClearBreakpointsMenu;
+        public static readonly CommandID Collapse;
+        public static readonly CommandID CopyToClipboard;
+        public static readonly CommandID CreateTheme;
+        public static readonly CommandID DebugStepBranchMenu;
+        public static readonly CommandID DebugStepInstanceMenu;
+        public static readonly CommandID DefaultFilter;
+        public static readonly CommandID DefaultPage;
+        public static readonly CommandID DesignerActionsMenu;
+        public static readonly CommandID DesignerProperties;
+        public static readonly CommandID Disable;
+        public static readonly CommandID Enable;
+        public static readonly CommandID EnableBreakpointMenu;
+        public static readonly CommandID ExecutionStateMenu;
+        public static readonly CommandID Expand;
+        public static readonly CommandID GotoDisassemblyMenu;
+        public static readonly CommandID InsertBreakpointMenu;
+        public static readonly CommandID InsertTracePointMenu;
+        public static readonly CommandID NewDataBreakpointMenu;
+        public static readonly CommandID NewFileTracePointMenu;
+        public static readonly CommandID PageDown;
+        public static readonly CommandID PageLayoutMenu;
+        public static readonly CommandID PageSetup;
+        public static readonly CommandID PageUp;
+        public static readonly CommandID Pan;
+        public static readonly CommandID PanMenu;
+        public static readonly CommandID Print;
+        public static readonly CommandID PrintPreview;
+        public static readonly CommandID PrintPreviewPage;
+        public static readonly CommandID RunToCursorMenu;
+        public static readonly CommandID SaveAsImage;
+        public static readonly CommandID SelectionMenu;
+        public static readonly CommandID SetNextStatementMenu;
+        public static readonly CommandID ShowAll;
+        public static readonly CommandID ShowNextStatementMenu;
+        public static readonly CommandID ToggleBreakpointMenu;
+        public static readonly CommandID Zoom100Mode;
+        public static readonly CommandID Zoom150Mode;
+        public static readonly CommandID Zoom200Mode;
+        public static readonly CommandID Zoom300Mode;
+        public static readonly CommandID Zoom400Mode;
+        public static readonly CommandID Zoom50Mode;
+        public static readonly CommandID Zoom75Mode;
+        public static readonly CommandID ZoomIn;
+        public static readonly CommandID ZoomLevelCombo;
+        public static readonly CommandID ZoomLevelListHandler;
+        public static readonly CommandID ZoomMenu;
+        public static readonly CommandID ZoomOut;
+        public static readonly Guid DebugCommandSetId;
+        public static readonly Guid DebugWorkflowGroupId;
+        public static readonly Guid MenuGuid;
+        public static readonly Guid WorkflowCommandSetId;
+        public const int FirstZoomCommand = 12544;
+        public const int LastZoomCommand = 12551;
+        public static readonly int VerbGroupActions;
+        public static readonly int VerbGroupDesignerActions;
+        public static readonly int VerbGroupEdit;
+        public static readonly int VerbGroupGeneral;
+        public static readonly int VerbGroupMisc;
+        public static readonly int VerbGroupOptions;
+        public static readonly int VerbGroupView;
+        public const int WorkflowToolBar = 1292;
+        public WorkflowMenuCommands();
+    }
+    public class WorkflowOutline : UserControl {
+        public WorkflowOutline(IServiceProvider serviceProvider);
+        protected internal bool NeedsExpandAll { get; set; }
+        protected internal TreeNode RootNode { get; }
+        protected internal TreeView TreeView { get; }
+        protected internal event TreeViewCancelEventHandler Expanding;
+        protected virtual WorkflowOutlineNode CreateNewNode(Activity activity);
+        protected override void Dispose(bool disposing);
+        protected WorkflowOutlineNode GetNode(Activity activity);
+        protected override object GetService(Type serviceType);
+        protected virtual void OnBeginUpdate();
+        protected virtual void OnEndUpdate();
+        protected override void OnLoad(EventArgs e);
+        protected virtual void OnNodeAdded(WorkflowOutlineNode node);
+        protected virtual void OnNodeSelected(WorkflowOutlineNode node);
+        protected virtual void OnRefreshNode(WorkflowOutlineNode node);
+        protected void RefreshNode(WorkflowOutlineNode nodeToUpdate, bool refreshChildNodes);
+        public void RefreshWorkflowOutline();
+        public void ReloadWorkflowOutline();
+    }
+    public class WorkflowOutlineNode : TreeNode {
+        public WorkflowOutlineNode(Activity activity);
+        public Activity Activity { get; }
+        public virtual void OnActivityRename(string newName);
+        public virtual void RefreshNode();
+    }
+    public sealed class WorkflowPageSetupDialog : Form {
+        public WorkflowPageSetupDialog(IServiceProvider serviceProvider);
+        protected override void Dispose(bool disposing);
+        protected override void OnHelpRequested(HelpEventArgs hlpevent);
+    }
+    public sealed class WorkflowTheme : IDisposable {
+        public WorkflowTheme();
+        public AmbientTheme AmbientTheme { get; }
+        public string ContainingFileDirectory { get; }
+        public static WorkflowTheme CurrentTheme { get; set; }
+        public string Description { get; set; }
+        public IList DesignerThemes { get; }
+        public static bool EnableChangeNotification { get; set; }
+        public string FilePath { get; set; }
+        public static string LookupPath { get; }
+        public string Name { get; set; }
+        public bool ReadOnly { get; set; }
+        public static string RegistryKeyPath { get; }
+        public static IDictionary<ThemeType, string[]> StandardThemes { get; }
+        public ThemeType Type { get; }
+        public string Version { get; set; }
+        public static event EventHandler ThemeChanged;
+        public WorkflowTheme Clone();
+        public static WorkflowTheme CreateStandardTheme(ThemeType standardThemeType);
+        ~WorkflowTheme();
+        public static string GenerateThemeFilePath();
+        public ActivityDesignerTheme GetDesignerTheme(ActivityDesigner designer);
+        public static WorkflowTheme Load(IDesignerSerializationManager serializationManager, string themeFilePath);
+        public static WorkflowTheme Load(string themeFilePath);
+        public static WorkflowTheme LoadThemeSettingFromRegistry();
+        public void Save(string themeFilePath);
+        public static void SaveThemeSettingToRegistry();
+        void System.IDisposable.Dispose();
+    }
+    public class WorkflowView : UserControl, IMessageFilter, IServiceProvider {
+        public WorkflowView();
+        public WorkflowView(IServiceProvider serviceProvider);
+        public bool EnableFitToScreen { get; set; }
+        public HScrollBar HScrollBar { get; }
+        public PrintDocument PrintDocument { get; }
+        public bool PrintPreviewMode { get; set; }
+        public ActivityDesigner RootDesigner { get; set; }
+        public Point ScrollPosition { get; set; }
+        public int ShadowDepth { get; set; }
+        public Rectangle ViewPortRectangle { get; }
+        public Size ViewPortSize { get; }
+        public VScrollBar VScrollBar { get; }
+        public int Zoom { get; set; }
+        public event EventHandler Idle;
+        public event EventHandler RootDesignerChanged;
+        public event EventHandler ZoomChanged;
+        public void AddDesignerMessageFilter(WorkflowDesignerMessageFilter designerMessageFilter);
+        public Point ClientPointToLogical(Point clientPoint);
+        public Rectangle ClientRectangleToLogical(Rectangle rectangle);
+        public Size ClientSizeToLogical(Size clientSize);
+        protected override AccessibleObject CreateAccessibilityInstance();
+        protected override void Dispose(bool disposing);
+        public void EnsureVisible(object selectableObject);
+        public void FitToScreenSize();
+        public void FitToWorkflowSize();
+        protected override object GetService(Type serviceType);
+        public void InvalidateClientRectangle(Rectangle clientRectangle);
+        public void InvalidateLogicalRectangle(Rectangle logicalRectangle);
+        public void LoadViewState(Stream viewState);
+        public Point LogicalPointToClient(Point logicalPoint);
+        public Point LogicalPointToScreen(Point logicalPoint);
+        public Rectangle LogicalRectangleToClient(Rectangle rectangle);
+        public Size LogicalSizeToClient(Size logicalSize);
+        protected override void OnControlAdded(ControlEventArgs e);
+        protected override void OnDragDrop(DragEventArgs dragEventArgs);
+        protected override void OnDragEnter(DragEventArgs dragEventArgs);
+        protected override void OnDragLeave(EventArgs e);
+        protected override void OnDragOver(DragEventArgs dragEventArgs);
+        protected override void OnGiveFeedback(GiveFeedbackEventArgs gfbevent);
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected override void OnKeyUp(KeyEventArgs e);
+        protected override void OnLayout(LayoutEventArgs levent);
+        protected override void OnMouseCaptureChanged(EventArgs e);
+        protected override void OnMouseDoubleClick(MouseEventArgs e);
+        protected override void OnMouseDown(MouseEventArgs e);
+        protected override void OnMouseEnter(EventArgs e);
+        protected override void OnMouseHover(EventArgs e);
+        protected override void OnMouseLeave(EventArgs e);
+        protected override void OnMouseMove(MouseEventArgs e);
+        protected override void OnMouseUp(MouseEventArgs e);
+        protected override void OnMouseWheel(MouseEventArgs e);
+        protected override void OnPaint(PaintEventArgs e);
+        protected override void OnQueryContinueDrag(QueryContinueDragEventArgs qcdevent);
+        protected virtual void OnRootDesignerChanged();
+        protected virtual void OnZoomChanged();
+        public void PerformLayout(bool immediateUpdate);
+        public void RemoveDesignerMessageFilter(WorkflowDesignerMessageFilter designerMessageFilter);
+        public void SaveViewState(Stream viewState);
+        public void SaveWorkflowImage(Stream stream, ImageFormat imageFormat);
+        public void SaveWorkflowImage(string imageFile, ImageFormat imageFormat);
+        public void SaveWorkflowImageToClipboard();
+        public Point ScreenPointToLogical(Point screenPoint);
+        public void ShowInfoTip(string text);
+        public void ShowInfoTip(string title, string text);
+        public void ShowInPlaceToolTip(string toolTipText, Rectangle toolTipRectangle);
+        object System.IServiceProvider.GetService(Type serviceType);
+        bool System.Windows.Forms.IMessageFilter.PreFilterMessage(ref Message m);
+        protected override void WndProc(ref Message m);
+    }
+    public class WorkflowViewAccessibleObject : Control.ControlAccessibleObject {
+        public WorkflowViewAccessibleObject(WorkflowView workflowView);
+        public override Rectangle Bounds { get; }
+        public override string DefaultAction { get; }
+        public override string Description { get; }
+        public override string Help { get; }
+        public override string Name { get; set; }
+        public override AccessibleRole Role { get; }
+        public override AccessibleObject GetChild(int index);
+        public override int GetChildCount();
+        public override AccessibleObject Navigate(AccessibleNavigation navdir);
+    }
+}
```

