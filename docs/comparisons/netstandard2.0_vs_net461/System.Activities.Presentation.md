# System.Activities.Presentation

``` diff
+namespace System.Activities.Presentation {
+    public class ActivityDesigner : WorkflowViewElement {
+        public static readonly DependencyProperty IconProperty;
+        public ActivityDesigner();
+        public DrawingBrush Icon { get; set; }
+        protected override string GetAutomationIdMemberName();
+        protected internal override string GetAutomationItemStatus();
+        public override void OnApplyTemplate();
+        protected internal override void OnEditAnnotation();
+        protected override void OnModelItemChanged(object newItem);
+        protected override void OnMouseUp(MouseButtonEventArgs e);
+        protected override void OnPreviewMouseDown(MouseButtonEventArgs e);
+    }
+    public sealed class ActivityDesignerOptionsAttribute : Attribute {
+        public ActivityDesignerOptionsAttribute();
+        public bool AllowDrillIn { get; set; }
+        public bool AlwaysCollapseChildren { get; set; }
+        public Func<ModelItem, DrawingBrush> OutlineViewIconProvider { get; set; }
+    }
+    public class ArgumentAccessor {
+        public ArgumentAccessor();
+        public Func<Activity, Argument> Getter { get; set; }
+        public Action<Activity, Argument> Setter { get; set; }
+    }
+    public class CachedResourceDictionaryExtension : MarkupExtension {
+        public CachedResourceDictionaryExtension();
+        public Uri Source { get; set; }
+        public override object ProvideValue(IServiceProvider serviceProvider);
+    }
+    public class ClipboardData {
+        public ClipboardData();
+        public List<object> Data { get; set; }
+        public List<object> Metadata { get; set; }
+        public string Version { get; set; }
+    }
+    public abstract class ContextItem {
+        protected ContextItem();
+        public abstract Type ItemType { get; }
+        protected virtual void OnItemChanged(EditingContext context, ContextItem previousItem);
+    }
+    public abstract class ContextItemManager : IEnumerable, IEnumerable<ContextItem> {
+        protected ContextItemManager();
+        public abstract bool Contains(Type itemType);
+        public bool Contains<TItemType>() where TItemType : ContextItem;
+        public abstract IEnumerator<ContextItem> GetEnumerator();
+        protected static object GetTarget(Delegate callback);
+        public abstract ContextItem GetValue(Type itemType);
+        public TItemType GetValue<TItemType>() where TItemType : ContextItem;
+        protected static void NotifyItemChanged(EditingContext context, ContextItem item, ContextItem previousItem);
+        protected static Delegate RemoveCallback(Delegate existing, Delegate toRemove);
+        public abstract void SetValue(ContextItem value);
+        public abstract void Subscribe(Type contextItemType, SubscribeContextCallback callback);
+        public void Subscribe<TContextItemType>(SubscribeContextCallback<TContextItemType> callback) where TContextItemType : ContextItem;
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        public abstract void Unsubscribe(Type contextItemType, SubscribeContextCallback callback);
+        public void Unsubscribe<TContextItemType>(SubscribeContextCallback<TContextItemType> callback) where TContextItemType : ContextItem;
+    }
+    public static class CutCopyPasteHelper {
+        public static bool CanCopy(EditingContext context);
+        public static bool CanCut(EditingContext context);
+        public static bool CanPaste(EditingContext context);
+        public static void DoCopy(EditingContext context);
+        public static void DoCut(EditingContext context);
+        public static void DoPaste(EditingContext context);
+    }
+    public sealed class DefaultTypeArgumentAttribute : Attribute {
+        public DefaultTypeArgumentAttribute(Type type);
+        public Type Type { get; }
+    }
+    public sealed class DesignerConfigurationService {
+        public bool AnnotationEnabled { get; set; }
+        public bool AutoConnectEnabled { get; set; }
+        public bool AutoSplitEnabled { get; set; }
+        public bool AutoSurroundWithSequenceEnabled { get; set; }
+        public bool BackgroundValidationEnabled { get; set; }
+        public bool LoadingFromUntrustedSourceEnabled { get; set; }
+        public bool MultipleItemsContextMenuEnabled { get; set; }
+        public bool MultipleItemsDragDropEnabled { get; set; }
+        public bool NamespaceConversionEnabled { get; set; }
+        public bool PanModeEnabled { get; set; }
+        public bool RubberBandSelectionEnabled { get; set; }
+        public FrameworkName TargetFrameworkName { get; set; }
+    }
+    public static class DragDropHelper {
+        public static readonly string CompletedEffectsFormat;
+        public static readonly string CompositeViewFormat;
+        public static readonly string DragAnchorPointFormat;
+        public static readonly string ModelItemDataFormat;
+        public static readonly string WorkflowItemTypeNameFormat;
+        public static readonly DependencyProperty DragSourceProperty;
+        public static bool AllowDrop(IDataObject draggedDataObject, EditingContext context, params Type[] allowedItemTypes);
+        public static DragDropEffects DoDragMove(WorkflowViewElement draggedViewElement, Point referencePoint);
+        public static UIElement GetCompositeView(WorkflowViewElement workflowViewElement);
+        public static ICompositeView GetCompositeView(DragEventArgs e);
+        public static Point GetDragDropAnchorPoint(DragEventArgs e);
+        public static DragDropEffects GetDragDropCompletedEffects(DataObject data);
+        public static ModelItem GetDraggedModelItem(DragEventArgs e);
+        public static IEnumerable<ModelItem> GetDraggedModelItems(DragEventArgs e);
+        public static object GetDroppedObject(DependencyObject dropTarget, DragEventArgs e, EditingContext context);
+        public static IEnumerable<object> GetDroppedObjects(DependencyObject dropTarget, DragEventArgs e, EditingContext context);
+        public static void SetCompositeView(WorkflowViewElement workflowViewElement, UIElement dragSource);
+        public static void SetDragDropCompletedEffects(DragEventArgs e, DragDropEffects completedEffects);
+    }
+    public class DynamicArgumentDesignerOptions {
+        public DynamicArgumentDesignerOptions();
+        public string ArgumentPrefix { get; set; }
+        public string Title { get; set; }
+    }
+    public sealed class DynamicArgumentDialog : WorkflowElementDialog {
+        protected override void OnWorkflowElementDialogClosed(Nullable<bool> dialogResult);
+        public static bool ShowDialog(ModelItem activity, ModelItem data, EditingContext context, DependencyObject owner, DynamicArgumentDesignerOptions options);
+    }
+    public class EditingContext : IDisposable {
+        public EditingContext();
+        public ContextItemManager Items { get; }
+        public ServiceManager Services { get; }
+        public event EventHandler Disposing;
+        protected virtual ContextItemManager CreateContextItemManager();
+        protected virtual ServiceManager CreateServiceManager();
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+    }
+    public interface IActivityTemplateFactory {
+        Activity Create(DependencyObject target);
+    }
+    public interface IActivityTemplateFactory<T> where T : class {
+        T Create(DependencyObject target, IDataObject dataObject);
+    }
+    public interface IActivityToolboxService {
+        void AddCategory(string categoryName);
+        void AddItem(string qualifiedTypeName, string categoryName);
+        IList<string> EnumCategories();
+        IList<string> EnumItems(string categoryName);
+        void RemoveCategory(string categoryName);
+        void RemoveItem(string qualifiedTypeName, string categoryName);
+    }
+    public interface ICompositeView {
+        TypeResolvingOptions DroppingTypeResolvingOptions { get; }
+        bool IsDefaultContainer { get; }
+        bool CanPasteItems(List<object> itemsToPaste);
+        void OnItemMoved(ModelItem modelItem);
+        object OnItemsCopied(List<ModelItem> itemsToCopy);
+        object OnItemsCut(List<ModelItem> itemsToCut);
+        void OnItemsDelete(List<ModelItem> itemsToDelete);
+        void OnItemsPasted(List<object> itemsToPaste, List<object> metadata, Point pastePoint, WorkflowViewElement pastePointReference);
+    }
+    public interface ICompositeViewEvents {
+        void RegisterCompositeView(ICompositeView container);
+        void RegisterDefaultCompositeView(ICompositeView container);
+        void UnregisterCompositeView(ICompositeView container);
+        void UnregisterDefaultCompositeView(ICompositeView container);
+    }
+    public interface IIntegratedHelpService {
+        void AddContextAttribute(string name, string value, HelpKeywordType keywordType);
+        void RemoveContextAttribute(string name, string value);
+        void ShowHelpFromKeyword(string helpKeyword);
+        void ShowHelpFromUrl(string helpUrl);
+    }
+    public interface IModalService {
+        void SetModalState(bool isModal);
+    }
+    public interface IMultipleDragEnabledCompositeView : ICompositeView {
+        void OnItemsMoved(List<ModelItem> movedItems);
+        List<ModelItem> SortSelectedItems(List<ModelItem> selectedItems);
+    }
+    public interface IWorkflowDesignerStorageService {
+        void AddData(string key, object value);
+        bool ContainsKey(string key);
+        object GetData(string key);
+        void RemoveData(string key);
+        void SetData(string key, object value);
+    }
+    public interface IXamlLoadErrorService {
+        void ShowXamlLoadErrors(IList<XamlLoadErrorInfo> errors);
+    }
+    public sealed class ObjectReferenceService {
+        public ObjectReferenceService(EditingContext context);
+        public event EventHandler<SourceLocationUpdatedEventArgs> SourceLocationUpdated;
+        public Guid AcquireObjectReference(int startLine, int startColumn, int endLine, int endColumn);
+        public Guid AcquireObjectReference(object obj);
+        public void ReleaseObjectReference(Guid objectReferenceId);
+        public bool TryGetObject(Guid objectReferenceId, out object obj);
+    }
+    public delegate object PublishServiceCallback(Type serviceType);
+    public delegate TServiceType PublishServiceCallback<TServiceType>();
+    public abstract class ServiceManager : IEnumerable, IEnumerable<Type>, IServiceProvider {
+        protected ServiceManager();
+        public abstract bool Contains(Type serviceType);
+        public bool Contains<TServiceType>();
+        public abstract IEnumerator<Type> GetEnumerator();
+        public TServiceType GetRequiredService<TServiceType>();
+        public abstract object GetService(Type serviceType);
+        public TServiceType GetService<TServiceType>();
+        protected static object GetTarget(Delegate callback);
+        public abstract void Publish(Type serviceType, PublishServiceCallback callback);
+        public abstract void Publish(Type serviceType, object serviceInstance);
+        public void Publish<TServiceType>(PublishServiceCallback<TServiceType> callback);
+        public void Publish<TServiceType>(TServiceType serviceInstance);
+        protected static Delegate RemoveCallback(Delegate existing, Delegate toRemove);
+        public abstract void Subscribe(Type serviceType, SubscribeServiceCallback callback);
+        public void Subscribe<TServiceType>(SubscribeServiceCallback<TServiceType> callback);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        public abstract void Unsubscribe(Type serviceType, SubscribeServiceCallback callback);
+        public void Unsubscribe<TServiceType>(SubscribeServiceCallback<TServiceType> callback);
+    }
+    public class SourceLocationUpdatedEventArgs : EventArgs {
+        public SourceLocationUpdatedEventArgs(Guid objectReference, SourceLocation updatedSourceLocation);
+        public Guid ObjectReference { get; private set; }
+        public SourceLocation UpdatedSourceLocation { get; private set; }
+    }
+    public delegate void SubscribeContextCallback(ContextItem item);
+    public delegate void SubscribeContextCallback<TContextItemType>(TContextItemType item) where TContextItemType : ContextItem;
+    public delegate void SubscribeServiceCallback(Type serviceType, object serviceInstance);
+    public delegate void SubscribeServiceCallback<TServiceType>(TServiceType serviceInstance);
+    public sealed class TypeResolvingOptionsAttribute : Attribute {
+        public TypeResolvingOptionsAttribute();
+        public TypeResolvingOptionsAttribute(TypeResolvingOptions options);
+        public TypeResolvingOptions TypeResolvingOptions { get; set; }
+    }
+    public class UndoEngine : IUndoEngineOperations {
+        public UndoEngine(EditingContext context);
+        public bool IsUndoRedoInProgress { get; private set; }
+        public event EventHandler<UndoUnitEventArgs> RedoCompleted;
+        public event EventHandler<UndoUnitEventArgs> UndoCompleted;
+        public event EventHandler UndoRedoBufferChanged;
+        public event EventHandler<UndoUnitEventArgs> UndoUnitAdded;
+        public event EventHandler<UndoUnitEventArgs> UndoUnitCancelled;
+        public event EventHandler UndoUnitDiscarded;
+        public void AddUndoUnit(UndoUnit unit);
+        public IEnumerable<string> GetRedoActions();
+        public IEnumerable<string> GetUndoActions();
+        public bool Redo();
+        public bool Undo();
+    }
+    public abstract class UndoUnit {
+        protected UndoUnit(EditingContext context);
+        public string Description { get; set; }
+        protected void ApplyGlobalState();
+        public abstract void Redo();
+        protected void SaveGlobalState();
+        public abstract void Undo();
+    }
+    public class UndoUnitEventArgs : EventArgs {
+        public UndoUnitEventArgs();
+        public UndoUnit UndoUnit { get; set; }
+    }
+    public class WorkflowDesigner : IWorkflowDesignerXamlHelperExecutionContext {
+        public WorkflowDesigner();
+        public EditingContext Context { get; }
+        public ContextMenu ContextMenu { get; }
+        public IDesignerDebugView DebugManagerView { get; }
+        public UIElement OutlineView { get; }
+        public string PropertyInspectorFontAndColorData { set; }
+        public UIElement PropertyInspectorView { get; }
+        public string Text { get; set; }
+        public UIElement View { get; }
+        public event EventHandler ModelChanged;
+        public event TextChangedEventHandler TextChanged;
+        public void Flush();
+        public bool IsInErrorState();
+        public void Load();
+        public void Load(object instance);
+        public void Load(string fileName);
+        public void Save(string fileName);
+    }
+    public static class WorkflowDesignerColors {
+        public const string AnnotationBackgroundGradientBeginColorKey = "AnnotationBackgroundGradientBeginColorKey";
+        public const string AnnotationBackgroundGradientEndColorKey = "AnnotationBackgroundGradientEndColorKey";
+        public const string AnnotationBackgroundGradientMiddleColorKey = "AnnotationBackgroundGradientMiddleColorKey";
+        public const string AnnotationBorderColorKey = "AnnotationBorderColorKey";
+        public const string AnnotationDockButtonColorKey = "AnnotationDockButtonColorKey";
+        public const string AnnotationDockButtonHoverBackgroundColorKey = "AnnotationDockButtonHoverBackgroundColorKey";
+        public const string AnnotationDockButtonHoverBorderColorKey = "AnnotationDockButtonHoverBorderColorKey";
+        public const string AnnotationDockButtonHoverColorKey = "AnnotationDockButtonHoverColorKey";
+        public const string AnnotationDockTextColorKey = "AnnotationDockTextColorKey";
+        public const string AnnotationUndockTextColorKey = "AnnotationUndockTextColorKey";
+        public const string ContextMenuBackgroundGradientBeginColorKey = "ContextMenuColorGradientBeginColorKey";
+        public const string ContextMenuBackgroundGradientEndColorKey = "ContextMenuColorGradientEndColorKey";
+        public const string ContextMenuBorderColorKey = "ContextMenuBorderColorKey";
+        public const string ContextMenuIconAreaColorKey = "ContextMenuIconAreaColorKey";
+        public const string ContextMenuItemTextColorKey = "ContextMenuItemTextColorKey";
+        public const string ContextMenuItemTextDisabledColorKey = "ContextMenuItemTextDisabledColorKey";
+        public const string ContextMenuItemTextHoverColorKey = "ContextMenuItemTextHoverColorKey";
+        public const string ContextMenuItemTextSelectedColorKey = "ContextMenuItemTextSelectedColorKey";
+        public const string ContextMenuMouseOverBeginColorKey = "ContextMenuMouseOverBeginColorKey";
+        public const string ContextMenuMouseOverBorderColorKey = "ContextMenuMouseOverBorderColorKey";
+        public const string ContextMenuMouseOverEndColorKey = "ContextMenuMouseOverEndColorKey";
+        public const string ContextMenuMouseOverMiddle1ColorKey = "ContextMenuMouseOverMiddle1ColorKey";
+        public const string ContextMenuMouseOverMiddle2ColorKey = "ContextMenuMouseOverMiddle2ColorKey";
+        public const string ContextMenuSeparatorColorKey = "ContextMenuSeparatorColorKey";
+        public const string DesignerViewBackgroundColorKey = "DesignerViewBackgroundColorKey";
+        public const string DesignerViewExpandAllCollapseAllButtonColorKey = "DesignerViewExpandAllCollapseAllButtonColorKey";
+        public const string DesignerViewExpandAllCollapseAllButtonMouseOverColorKey = "DesignerViewExpandAllCollapseAllButtonMouseOverColorKey";
+        public const string DesignerViewExpandAllCollapseAllPressedColorKey = "DesignerViewExpandAllCollapseAllPressedColorKey";
+        public const string DesignerViewShellBarCaptionActiveColorKey = "DesignerViewShellBarCaptionActiveColorKey";
+        public const string DesignerViewShellBarCaptionColorKey = "DesignerViewShellBarCaptionColorKey";
+        public const string DesignerViewShellBarColorGradientBeginKey = "DesignerViewShellBarColorGradientBeginKey";
+        public const string DesignerViewShellBarColorGradientEndKey = "DesignerViewShellBarColorGradientEndKey";
+        public const string DesignerViewShellBarControlBackgroundColorKey = "DesignerViewShellBarControlBackgroundColorKey";
+        public const string DesignerViewShellBarHoverColorGradientBeginKey = "DesignerViewShellBarSelectedHoverGradientBeginKey";
+        public const string DesignerViewShellBarHoverColorGradientEndKey = "DesignerViewShellBarSelectedHoverGradientEndKey";
+        public const string DesignerViewShellBarSelectedColorGradientBeginKey = "DesignerViewShellBarSelectedColorGradientBeginKey";
+        public const string DesignerViewShellBarSelectedColorGradientEndKey = "DesignerViewShellBarSelectedColorGradientEndKey";
+        public const string DesignerViewStatusBarBackgroundColorKey = "DesignerViewStatusBarBackgroundColorKey";
+        public const string FlowchartExpressionButtonColorKey = "FlowchartExpressionButtonColorKey";
+        public const string FlowchartExpressionButtonMouseOverColorKey = "FlowchartExpressionButtonMouseOverColorKey";
+        public const string FlowchartExpressionButtonPressedColorKey = "FlowchartExpressionButtonPressedColorKey";
+        public static readonly string FontFamilyKey;
+        public static readonly string FontSizeKey;
+        public static readonly string FontWeightKey;
+        public const string OutlineViewBackgroundColorKey = "OutlineViewBackgroundColorKey";
+        public const string OutlineViewCollapsedArrowBorderColorKey = "OutlineViewCollapsedArrowBorderColorKey";
+        public const string OutlineViewCollapsedArrowHoverBorderColorKey = "OutlineViewCollapsedArrowHoverBorderColorKey";
+        public const string OutlineViewExpandedArrowBorderColorKey = "OutlineViewExpandedArrowBorderColorKey";
+        public const string OutlineViewExpandedArrowColorKey = "OutlineViewExpandedArrowColorKey";
+        public const string OutlineViewItemHighlightBackgroundColorKey = "OutlineViewItemHighlightBackgroundColorKey";
+        public const string OutlineViewItemSelectedTextColorKey = "OutlineViewTitemSelectedTextColorKey";
+        public const string OutlineViewItemTextColorKey = "OutlineViewItemTextColorKey";
+        public const string RubberBandRectangleColorKey = "RubberBandRectangleColorKey";
+        public const string WorkflowViewElementBackgroundColorKey = "WorkflowViewElementBackgroundColorKey";
+        public const string WorkflowViewElementBorderColorKey = "WorkflowViewElementBorderColorKey";
+        public const string WorkflowViewElementCaptionColorKey = "WorkflowViewElementCaptionBrushColorKey";
+        public const string WorkflowViewElementSelectedBackgroundColorKey = "WorkflowViewElementSelectedBackgroundColorKey";
+        public const string WorkflowViewElementSelectedBorderColorKey = "WorkflowViewElementSelectedBorderColorKey";
+        public static Color AnnotationBackgroundGradientBeginColor { get; }
+        public static Color AnnotationBackgroundGradientEndColor { get; }
+        public static Color AnnotationBackgroundGradientMiddleColor { get; }
+        public static Color AnnotationBorderColor { get; }
+        public static Color AnnotationDockButtonColor { get; }
+        public static Color AnnotationDockButtonHoverBackgroundColor { get; }
+        public static Color AnnotationDockButtonHoverBorderColor { get; }
+        public static Color AnnotationDockButtonHoverColor { get; }
+        public static Color AnnotationDockTextColor { get; }
+        public static Color AnnotationUndockTextColor { get; }
+        public static Color ContextMenuBackgroundGradientBeginColor { get; }
+        public static Color ContextMenuBackgroundGradientEndColor { get; }
+        public static Color ContextMenuBorderColor { get; }
+        public static Color ContextMenuIconAreaColor { get; }
+        public static Color ContextMenuItemTextColor { get; }
+        public static Color ContextMenuItemTextDisabledColor { get; }
+        public static Color ContextMenuItemTextHoverColor { get; }
+        public static Color ContextMenuItemTextSelectedColor { get; }
+        public static Color ContextMenuMouseOverBeginColor { get; }
+        public static Color ContextMenuMouseOverBorderColor { get; }
+        public static Color ContextMenuMouseOverEndColor { get; }
+        public static Color ContextMenuMouseOverMiddle1Color { get; }
+        public static Color ContextMenuMouseOverMiddle2Color { get; }
+        public static Color ContextMenuSeparatorColor { get; }
+        public static Color DesignerViewBackgroundColor { get; }
+        public static Brush DesignerViewExpandAllCollapseAllButtonBrush { get; }
+        public static Brush DesignerViewExpandAllCollapseAllButtonMouseOverBrush { get; }
+        public static Brush DesignerViewExpandAllCollapseAllPressedBrush { get; }
+        public static Color DesignerViewShellBarCaptionActiveColor { get; }
+        public static Color DesignerViewShellBarCaptionColor { get; }
+        public static Color DesignerViewShellBarColorGradientBeginColor { get; }
+        public static Color DesignerViewShellBarColorGradientEndColor { get; }
+        public static Color DesignerViewShellBarControlBackgroundColor { get; }
+        public static Color DesignerViewShellBarHoverColorGradientBeginColor { get; }
+        public static Color DesignerViewShellBarHoverColorGradientEndColor { get; }
+        public static Color DesignerViewShellBarSelectedColorGradientBeginColor { get; }
+        public static Color DesignerViewShellBarSelectedColorGradientEndColor { get; }
+        public static Color DesignerViewStatusBarBackgroundColor { get; }
+        public static Brush FlowchartExpressionButtonBrush { get; }
+        public static Brush FlowchartExpressionButtonMouseOverBrush { get; }
+        public static Brush FlowchartExpressionButtonPressedBrush { get; }
+        public static FontFamily FontFamily { get; }
+        public static double FontSize { get; }
+        public static FontWeight FontWeight { get; }
+        public static Color GridViewRowHoverColor { get; }
+        public static Color OutlineViewBackgroundColor { get; }
+        public static Color OutlineViewCollapsedArrowBorderColor { get; }
+        public static Color OutlineViewCollapsedArrowHoverBorderColor { get; }
+        public static Color OutlineViewExpandedArrowBorderColor { get; }
+        public static Color OutlineViewExpandedArrowColor { get; }
+        public static Color OutlineViewItemHighlightBackgroundColor { get; }
+        public static Color OutlineViewItemSelectedTextColor { get; }
+        public static Color OutlineViewItemTextColor { get; }
+        public static string PropertyInspectorBackgroundBrushKey { get; }
+        public static string PropertyInspectorBorderBrushKey { get; }
+        public static string PropertyInspectorCategoryCaptionTextBrushKey { get; }
+        public static string PropertyInspectorPaneBrushKey { get; }
+        public static string PropertyInspectorPopupBrushKey { get; }
+        public static string PropertyInspectorSelectedBackgroundBrushKey { get; }
+        public static string PropertyInspectorSelectedForegroundBrushKey { get; }
+        public static string PropertyInspectorTextBrushKey { get; }
+        public static string PropertyInspectorToolBarBackgroundBrushKey { get; }
+        public static string PropertyInspectorToolBarItemHoverBackgroundBrushKey { get; }
+        public static string PropertyInspectorToolBarItemHoverBorderBrushKey { get; }
+        public static string PropertyInspectorToolBarItemSelectedBackgroundBrushKey { get; }
+        public static string PropertyInspectorToolBarItemSelectedBorderBrushKey { get; }
+        public static string PropertyInspectorToolBarSeparatorBrushKey { get; }
+        public static string PropertyInspectorToolBarTextBoxBorderBrushKey { get; }
+        public static Color WorkflowViewElementBackgroundColor { get; }
+        public static Color WorkflowViewElementBorderColor { get; }
+        public static Color WorkflowViewElementCaptionColor { get; }
+        public static Color WorkflowViewElementSelectedBackgroundColor { get; }
+        public static Color WorkflowViewElementSelectedBorderColor { get; }
+    }
+    public static class WorkflowDesignerIcons {
+        public static void UseWindowsStoreAppStyleIcons();
+        public static class Activities {
+            public static DrawingBrush AddToCollection { get; set; }
+            public static DrawingBrush Assign { get; set; }
+            public static DrawingBrush CancellationScope { get; set; }
+            public static DrawingBrush ClearCollection { get; set; }
+            public static DrawingBrush CompensableActivity { get; set; }
+            public static DrawingBrush Compensate { get; set; }
+            public static DrawingBrush Confirm { get; set; }
+            public static DrawingBrush CorrelationScope { get; set; }
+            public static DrawingBrush DefaultCustomActivity { get; set; }
+            public static DrawingBrush Delay { get; set; }
+            public static DrawingBrush DoWhile { get; set; }
+            public static DrawingBrush ExistsInCollection { get; set; }
+            public static DrawingBrush FinalState { get; set; }
+            public static DrawingBrush Flowchart { get; set; }
+            public static DrawingBrush FlowDecision { get; set; }
+            public static DrawingBrush FlowDecisionNode { get; set; }
+            public static DrawingBrush FlowSwitch { get; set; }
+            public static DrawingBrush FlowSwitchNode { get; set; }
+            public static DrawingBrush ForEach { get; set; }
+            public static DrawingBrush If { get; set; }
+            public static DrawingBrush InitializeCorrelation { get; set; }
+            public static DrawingBrush Interop { get; set; }
+            public static DrawingBrush InvokeDelegate { get; set; }
+            public static DrawingBrush InvokeMethod { get; set; }
+            public static DrawingBrush NoPersistScope { get; set; }
+            public static DrawingBrush Parallel { get; set; }
+            public static DrawingBrush ParallelForEach { get; set; }
+            public static DrawingBrush Persist { get; set; }
+            public static DrawingBrush Pick { get; set; }
+            public static DrawingBrush PickBranch { get; set; }
+            public static DrawingBrush Receive { get; set; }
+            public static DrawingBrush ReceiveAndSendReply { get; set; }
+            public static DrawingBrush ReceiveReply { get; set; }
+            public static DrawingBrush RemoveFromCollection { get; set; }
+            public static DrawingBrush Rethrow { get; set; }
+            public static DrawingBrush Send { get; set; }
+            public static DrawingBrush SendAndReceiveReply { get; set; }
+            public static DrawingBrush SendReply { get; set; }
+            public static DrawingBrush Sequence { get; set; }
+            public static DrawingBrush StartNode { get; set; }
+            public static DrawingBrush State { get; set; }
+            public static DrawingBrush StateEntry { get; set; }
+            public static DrawingBrush StateExit { get; set; }
+            public static DrawingBrush StateMachine { get; set; }
+            public static DrawingBrush StateTransition { get; set; }
+            public static DrawingBrush Switch { get; set; }
+            public static DrawingBrush TerminateWorkflow { get; set; }
+            public static DrawingBrush Throw { get; set; }
+            public static DrawingBrush TransactedReceiveScope { get; set; }
+            public static DrawingBrush TransactionScope { get; set; }
+            public static DrawingBrush TryCatch { get; set; }
+            public static DrawingBrush While { get; set; }
+            public static DrawingBrush WriteLine { get; set; }
+        }
+        public static class ContextMenuItems {
+            public static DrawingBrush Copy { get; set; }
+            public static DrawingBrush CopyDisabled { get; set; }
+            public static DrawingBrush Cut { get; set; }
+            public static DrawingBrush CutDisabled { get; set; }
+            public static DrawingBrush Delete { get; set; }
+            public static DrawingBrush DeleteDisabled { get; set; }
+            public static DrawingBrush Paste { get; set; }
+            public static DrawingBrush PasteDisabled { get; set; }
+        }
+        public static class DesignerItems {
+            public static DrawingBrush ActivityErrorValidation { get; set; }
+            public static DrawingBrush Annotation { get; set; }
+            public static DrawingBrush DeleteButton { get; set; }
+            public static DrawingBrush DeleteDisabledButton { get; set; }
+            public static DrawingBrush FitToScreen { get; set; }
+            public static DrawingBrush MoveDownButton { get; set; }
+            public static DrawingBrush MoveDownDisabledButton { get; set; }
+            public static DrawingBrush MoveUpButton { get; set; }
+            public static DrawingBrush MoveUpDisabledButton { get; set; }
+            public static DrawingBrush Overview { get; set; }
+            public static DrawingBrush OverviewWindowCloseButton { get; set; }
+            public static DrawingBrush PanMode { get; set; }
+            public static DrawingBrush ResizeGrip { get; set; }
+            public static DrawingBrush TextBoxErrorValidation { get; set; }
+            public static DrawingBrush WarningValidation { get; set; }
+            public static DrawingBrush WorkflowErrorValidation { get; set; }
+            public static DrawingBrush Zoom { get; set; }
+        }
+    }
+    public class WorkflowElementDialog : ContentControl {
+        public static readonly DependencyProperty ContextProperty;
+        public static readonly DependencyProperty ModelItemProperty;
+        public static readonly DependencyProperty TitleProperty;
+        public static readonly DependencyProperty WindowResizeModeProperty;
+        public static readonly DependencyProperty WindowSizeToContentProperty;
+        protected WorkflowElementDialog();
+        public EditingContext Context { get; set; }
+        public bool EnableMaximizeButton { get; set; }
+        public bool EnableMinimizeButton { get; set; }
+        public string HelpKeyword { get; set; }
+        public ModelItem ModelItem { get; set; }
+        public DependencyObject Owner { get; set; }
+        public string Title { get; set; }
+        public ResizeMode WindowResizeMode { get; set; }
+        public SizeToContent WindowSizeToContent { get; set; }
+        protected void EnableOk(bool enabled);
+        protected override void OnInitialized(EventArgs e);
+        protected virtual void OnModelItemChanged(object newItem);
+        protected virtual void OnWorkflowElementDialogClosed(Nullable<bool> dialogResult);
+        public void Show();
+        public bool ShowOkCancel();
+    }
+    public class WorkflowFileItem : ContextItem {
+        public WorkflowFileItem();
+        public sealed override Type ItemType { get; }
+        public string LoadedFile { get; set; }
+    }
+    public sealed class WorkflowItemPresenter : ContentControl, ICompositeView {
+        public static readonly DependencyProperty AllowedItemTypeProperty;
+        public static readonly DependencyProperty DroppingTypeResolvingOptionsProperty;
+        public static readonly DependencyProperty HintTextProperty;
+        public static readonly DependencyProperty IsDefaultContainerProperty;
+        public static readonly DependencyProperty ItemProperty;
+        public WorkflowItemPresenter();
+        public Type AllowedItemType { get; set; }
+        public TypeResolvingOptions DroppingTypeResolvingOptions { get; set; }
+        public string HintText { get; set; }
+        public bool IsDefaultContainer { get; set; }
+        public ModelItem Item { get; set; }
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnDragEnter(DragEventArgs e);
+        protected override void OnDragOver(DragEventArgs e);
+        protected override void OnDrop(DragEventArgs e);
+        protected override void OnInitialized(EventArgs e);
+        protected override void OnMouseDown(MouseButtonEventArgs e);
+        protected override void OnRender(DrawingContext drawingContext);
+        bool System.Activities.Presentation.ICompositeView.CanPasteItems(List<object> itemsToPaste);
+        void System.Activities.Presentation.ICompositeView.OnItemMoved(ModelItem modelItem);
+        object System.Activities.Presentation.ICompositeView.OnItemsCopied(List<ModelItem> itemsToCopy);
+        object System.Activities.Presentation.ICompositeView.OnItemsCut(List<ModelItem> itemsToCut);
+        void System.Activities.Presentation.ICompositeView.OnItemsDelete(List<ModelItem> itemsToDelete);
+        void System.Activities.Presentation.ICompositeView.OnItemsPasted(List<object> itemsToPaste, List<object> metaData, Point pastePoint, WorkflowViewElement pastePointReference);
+    }
+    public class WorkflowItemsPresenter : ContentControl, ICompositeView, IMultipleDragEnabledCompositeView {
+        public static readonly DependencyProperty AllowedItemTypeProperty;
+        public static readonly DependencyProperty DroppingTypeResolvingOptionsProperty;
+        public static readonly DependencyProperty FooterTemplateProperty;
+        public static readonly DependencyProperty HeaderTemplateProperty;
+        public static readonly DependencyProperty HintTextProperty;
+        public static readonly DependencyProperty IndexProperty;
+        public static readonly DependencyProperty IsDefaultContainerProperty;
+        public static readonly DependencyProperty ItemsPanelProperty;
+        public static readonly DependencyProperty ItemsProperty;
+        public static readonly DependencyProperty SpacerTemplateProperty;
+        public WorkflowItemsPresenter();
+        public Type AllowedItemType { get; set; }
+        public TypeResolvingOptions DroppingTypeResolvingOptions { get; set; }
+        public DataTemplate FooterTemplate { get; set; }
+        public DataTemplate HeaderTemplate { get; set; }
+        public string HintText { get; set; }
+        public bool IsDefaultContainer { get; set; }
+        public ModelItemCollection Items { get; set; }
+        public ItemsPanelTemplate ItemsPanel { get; set; }
+        public DataTemplate SpacerTemplate { get; set; }
+        public bool CanPasteItems(List<object> itemsToPaste);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnDragEnter(DragEventArgs e);
+        protected override void OnDragOver(DragEventArgs e);
+        protected override void OnDrop(DragEventArgs e);
+        protected override void OnInitialized(EventArgs e);
+        public void OnItemMoved(ModelItem modelItem);
+        public object OnItemsCopied(List<ModelItem> itemsToCopy);
+        public object OnItemsCut(List<ModelItem> itemsToCut);
+        public void OnItemsDelete(List<ModelItem> itemsToDelete);
+        public void OnItemsMoved(List<ModelItem> movedItems);
+        public void OnItemsPasted(List<object> itemsToPaste, List<object> metaData, Point pastePoint, WorkflowViewElement pastePointReference);
+        public List<ModelItem> SortSelectedItems(List<ModelItem> selectedItems);
+    }
+    public class WorkflowViewElement : ContentControl, ICompositeViewEvents {
+        public static readonly DependencyProperty ContextProperty;
+        public static readonly DependencyProperty ExpandStateProperty;
+        public static readonly DependencyProperty ModelItemProperty;
+        public static readonly DependencyProperty PinStateProperty;
+        public static readonly DependencyProperty ShowExpandedProperty;
+        public WorkflowViewElement();
+        public bool Collapsible { get; set; }
+        protected IList<ICompositeView> CompositeViews { get; }
+        public EditingContext Context { get; set; }
+        protected ICompositeView DefaultCompositeView { get; }
+        protected internal DesignerView Designer { get; }
+        public FrameworkElement DragHandle { get; set; }
+        public bool ExpandState { get; set; }
+        protected bool IsReadOnly { get; private set; }
+        public bool IsRootDesigner { get; internal set; }
+        public ModelItem ModelItem { get; set; }
+        public bool PinState { get; set; }
+        public bool ShowExpanded { get; }
+        protected internal ViewService ViewService { get; }
+        protected internal ViewStateService ViewStateService { get; }
+        protected virtual string GetAutomationHelpText();
+        protected virtual string GetAutomationIdMemberName();
+        protected internal virtual string GetAutomationItemStatus();
+        protected virtual void OnContextMenuLoaded(ContextMenu menu);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnDragEnter(DragEventArgs e);
+        protected override void OnDragOver(DragEventArgs e);
+        protected internal virtual void OnEditAnnotation();
+        protected override void OnInitialized(EventArgs e);
+        protected virtual void OnModelItemChanged(object newItem);
+        protected override void OnMouseDown(MouseButtonEventArgs e);
+        protected override void OnMouseMove(MouseEventArgs e);
+        protected override void OnMouseUp(MouseButtonEventArgs e);
+        protected override void OnPreviewDragEnter(DragEventArgs e);
+        protected override void OnPreviewDragLeave(DragEventArgs e);
+        protected override void OnPreviewMouseUp(MouseButtonEventArgs e);
+        protected virtual void OnReadOnlyChanged(bool isReadOnly);
+        protected virtual void OnShowExpandedChanged(bool newValue);
+        public void RegisterCompositeView(ICompositeView container);
+        public void RegisterDefaultCompositeView(ICompositeView container);
+        public void UnregisterCompositeView(ICompositeView container);
+        public void UnregisterDefaultCompositeView(ICompositeView container);
+    }
+    public class XamlLoadErrorInfo {
+        public XamlLoadErrorInfo(string message, int lineNumber, int linePosition);
+        public string FileName { get; set; }
+        public int LineNumber { get; private set; }
+        public int LinePosition { get; private set; }
+        public string Message { get; private set; }
+    }
+}
```

