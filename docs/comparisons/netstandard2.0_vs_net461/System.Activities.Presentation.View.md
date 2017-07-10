# System.Activities.Presentation.View

``` diff
+namespace System.Activities.Presentation.View {
+    public sealed class CommandMenuMode {
+        public static readonly CommandMenuMode FullCommandMenu;
+        public static readonly CommandMenuMode NoCommandMenu;
+    }
+    public class DesignerView : UserControl, IComponentConnector, IStyleConnector {
+        public const string CustomMenuItemsSeparatorCommand = "6F455692-EA19-4ac9-ABEE-57F6DF20A687";
+        public static readonly DependencyProperty ActivitySchemaProperty;
+        public static readonly DependencyProperty CommandMenuModeProperty;
+        public static readonly DependencyProperty FocusedViewElementProperty;
+        public static readonly DependencyProperty InPanModeProperty;
+        public static readonly DependencyProperty IsReadOnlyProperty;
+        public static readonly DependencyProperty MenuItemStyleProperty;
+        public static readonly DependencyProperty MenuSeparatorStyleProperty;
+        public static readonly DependencyProperty RootDesignerProperty;
+        public static readonly ICommand AddAnnotationCommand;
+        public static readonly ICommand CollapseAllCommand;
+        public static readonly ICommand CollapseCommand;
+        public static readonly ICommand CommitCommand;
+        public static readonly ICommand CopyAsImageCommand;
+        public static readonly ICommand CopyCommand;
+        public static readonly ICommand CreateArgumentCommand;
+        public static readonly ICommand CreateVariableCommand;
+        public static readonly ICommand CreateWorkflowElementCommand;
+        public static readonly ICommand CutCommand;
+        public static readonly ICommand CycleThroughDesignerCommand;
+        public static readonly ICommand DeleteAllAnnotationCommand;
+        public static readonly ICommand DeleteAnnotationCommand;
+        public static readonly ICommand DeleteBreakpointCommand;
+        public static readonly ICommand DisableBreakpointCommand;
+        public static readonly ICommand EditAnnotationCommand;
+        public static readonly ICommand EnableBreakpointCommand;
+        public static readonly ICommand ExpandAllCommand;
+        public static readonly ICommand ExpandCommand;
+        public static readonly ICommand ExpandInPlaceCommand;
+        public static readonly ICommand FitToScreenCommand;
+        public static readonly ICommand GoToParentCommand;
+        public static readonly ICommand HideAllAnnotationCommand;
+        public static readonly ICommand InsertBreakpointCommand;
+        public static readonly ICommand MoveFocusCommand;
+        public static readonly ICommand PasteCommand;
+        public static readonly ICommand RedoCommand;
+        public static readonly ICommand ResetZoomCommand;
+        public static readonly ICommand RestoreCommand;
+        public static readonly ICommand SaveAsImageCommand;
+        public static readonly ICommand SelectAllCommand;
+        public static readonly ICommand ShowAllAnnotationCommand;
+        public static readonly ICommand ToggleArgumentDesignerCommand;
+        public static readonly ICommand ToggleImportsDesignerCommand;
+        public static readonly ICommand ToggleMiniMapCommand;
+        public static readonly ICommand ToggleSelectionCommand;
+        public static readonly ICommand ToggleVariableDesignerCommand;
+        public static readonly ICommand UndoCommand;
+        public static readonly ICommand ZoomInCommand;
+        public static readonly ICommand ZoomOutCommand;
+        public ModelItem ActivitySchema { get; private set; }
+        public EditingContext Context { get; }
+        public WorkflowViewElement FocusedViewElement { get; private set; }
+        public bool IsMultipleSelectionMode { get; private set; }
+        public bool IsReadOnly { get; set; }
+        public Style MenuItemStyle { get; set; }
+        public Style MenuSeparatorStyle { get; set; }
+        public UIElement RootDesigner { get; set; }
+        public bool ShouldCollapseAll { get; set; }
+        public bool ShouldExpandAll { get; set; }
+        public ShellBarItemVisibility WorkflowShellBarItemVisibility { get; set; }
+        public ShellHeaderItemsVisibility WorkflowShellHeaderItemsVisibility { get; set; }
+        public double ZoomFactor { get; }
+        public void FlushState();
+        public static CommandMenuMode GetCommandMenuMode(DependencyObject obj);
+        public void InitializeComponent();
+        public void MakeRootDesigner(ModelItem modelItem);
+        protected override void OnContextMenuOpening(ContextMenuEventArgs e);
+        protected override void OnInitialized(EventArgs e);
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected override void OnPreviewDragOver(DragEventArgs e);
+        protected override void OnPreviewMouseLeftButtonDown(MouseButtonEventArgs e);
+        protected override void OnPreviewMouseWheel(MouseWheelEventArgs e);
+        public void OnReferenceUpdated(AssemblyName updatedReference, bool isAdded);
+        public void RegisterViewElement(WorkflowViewElement viewElement);
+        public static void SetCommandMenuMode(DependencyObject obj, CommandMenuMode value);
+        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target);
+        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target);
+        public void UnregisterViewElement(WorkflowViewElement viewElement);
+    }
+    public enum EditingState {
+        Editing = 0,
+        Idle = 2,
+        Validating = 1,
+    }
+    public sealed class ExpressionTextBox : UserControl, IComponentConnector {
+        public const string ExpressionActivityEditorOptionName = "ExpressionActivityEditorName";
+        public static readonly DependencyProperty AcceptsReturnProperty;
+        public static readonly DependencyProperty AcceptsTabProperty;
+        public static readonly DependencyProperty DefaultValueProperty;
+        public static readonly DependencyProperty ExplicitCommitProperty;
+        public static readonly DependencyProperty ExpressionActivityEditorProperty;
+        public static readonly DependencyProperty ExpressionProperty;
+        public static readonly DependencyProperty ExpressionTypeProperty;
+        public static readonly DependencyProperty HintTextProperty;
+        public static readonly DependencyProperty HorizontalScrollBarVisibilityProperty;
+        public static readonly DependencyProperty IsReadOnlyProperty;
+        public static readonly DependencyProperty IsSupportedExpressionProperty;
+        public static readonly DependencyProperty MaxLinesProperty;
+        public static readonly DependencyProperty MinLinesProperty;
+        public static readonly DependencyProperty OwnerActivityProperty;
+        public static readonly DependencyProperty PathToArgumentProperty;
+        public static readonly DependencyProperty UseLocationExpressionProperty;
+        public static readonly DependencyProperty VerticalScrollBarVisibilityProperty;
+        public static readonly ICommand CompleteWordCommand;
+        public static readonly ICommand DecreaseFilterLevelCommand;
+        public static readonly ICommand GlobalIntellisenseCommand;
+        public static readonly ICommand IncreaseFilterLevelCommand;
+        public static readonly ICommand ParameterInfoCommand;
+        public static readonly ICommand QuickInfoCommand;
+        public static readonly RoutedEvent EditorLostLogicalFocusEvent;
+        public ExpressionTextBox();
+        public bool AcceptsReturn { get; set; }
+        public bool AcceptsTab { get; set; }
+        public string DefaultValue { get; set; }
+        public bool ExplicitCommit { get; set; }
+        public ModelItem Expression { get; set; }
+        public string ExpressionActivityEditor { get; set; }
+        public IExpressionEditorService ExpressionEditorService { get; }
+        public Type ExpressionType { get; set; }
+        public string HintText { get; set; }
+        public ScrollBarVisibility HorizontalScrollBarVisibility { get; set; }
+        public bool IsReadOnly { get; set; }
+        public bool IsSupportedExpression { get; set; }
+        public int MaxLines { get; set; }
+        public int MinLines { get; set; }
+        public ModelItem OwnerActivity { get; set; }
+        public string PathToArgument { get; set; }
+        public bool UseLocationExpression { get; set; }
+        public ScrollBarVisibility VerticalScrollBarVisibility { get; set; }
+        public event RoutedEventHandler EditorLostLogicalFocus;
+        public void BeginEdit();
+        public void InitializeComponent();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnInitialized(EventArgs e);
+        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e);
+        public static void RegisterExpressionActivityEditor(string name, Type expressionActivityEditorType, CreateExpressionFromStringCallback convertFromString);
+        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target);
+    }
+    public interface IExpressionEditorInstance {
+        bool AcceptsReturn { get; set; }
+        bool AcceptsTab { get; set; }
+        bool HasAggregateFocus { get; }
+        ScrollBarVisibility HorizontalScrollBarVisibility { get; set; }
+        Control HostControl { get; }
+        int MaxLines { get; set; }
+        int MinLines { get; set; }
+        string Text { get; set; }
+        ScrollBarVisibility VerticalScrollBarVisibility { get; set; }
+        event EventHandler Closing;
+        event EventHandler GotAggregateFocus;
+        event EventHandler LostAggregateFocus;
+        event EventHandler TextChanged;
+        bool CanCompleteWord();
+        bool CanCopy();
+        bool CanCut();
+        bool CanDecreaseFilterLevel();
+        bool CanGlobalIntellisense();
+        bool CanIncreaseFilterLevel();
+        bool CanParameterInfo();
+        bool CanPaste();
+        bool CanQuickInfo();
+        bool CanRedo();
+        bool CanUndo();
+        void ClearSelection();
+        void Close();
+        bool CompleteWord();
+        bool Copy();
+        bool Cut();
+        bool DecreaseFilterLevel();
+        void Focus();
+        string GetCommittedText();
+        bool GlobalIntellisense();
+        bool IncreaseFilterLevel();
+        bool ParameterInfo();
+        bool Paste();
+        bool QuickInfo();
+        bool Redo();
+        bool Undo();
+    }
+    public interface IExpressionEditorService {
+        void CloseExpressionEditors();
+        IExpressionEditorInstance CreateExpressionEditor(AssemblyContextControlItem assemblies, ImportedNamespaceContextItem importedNamespaces, List<ModelItem> variables, string text);
+        IExpressionEditorInstance CreateExpressionEditor(AssemblyContextControlItem assemblies, ImportedNamespaceContextItem importedNamespaces, List<ModelItem> variables, string text, Type expressionType);
+        IExpressionEditorInstance CreateExpressionEditor(AssemblyContextControlItem assemblies, ImportedNamespaceContextItem importedNamespaces, List<ModelItem> variables, string text, Type expressionType, Size initialSize);
+        IExpressionEditorInstance CreateExpressionEditor(AssemblyContextControlItem assemblies, ImportedNamespaceContextItem importedNamespaces, List<ModelItem> variables, string text, Size initialSize);
+        void UpdateContext(AssemblyContextControlItem assemblies, ImportedNamespaceContextItem importedNamespaces);
+    }
+    public enum PropertyKind {
+        InArgument = 0,
+        InOutArgument = 1,
+        OutArgument = 2,
+        Property = 3,
+    }
+    public class Selection : ContextItem {
+        public Selection();
+        public Selection(params ModelItem[] selectedObjects);
+        public Selection(IEnumerable<ModelItem> selectedObjects);
+        public Selection(IEnumerable<ModelItem> selectedObjects, Predicate<ModelItem> match);
+        public Selection(IEnumerable selectedObjects);
+        public Selection(IEnumerable selectedObjects, Predicate<ModelItem> match);
+        public sealed override Type ItemType { get; }
+        public ModelItem PrimarySelection { get; }
+        public IEnumerable<ModelItem> SelectedObjects { get; }
+        public int SelectionCount { get; }
+        public static Selection Select(EditingContext context, ModelItem itemToSelect);
+        public static Selection SelectOnly(EditingContext context, ModelItem itemToSelect);
+        public static void Subscribe(EditingContext context, SubscribeContextCallback<Selection> handler);
+        public static Selection Toggle(EditingContext context, ModelItem itemToToggle);
+        public static Selection Union(EditingContext context, ModelItem itemToAdd);
+        public static void Unsubscribe(EditingContext context, SubscribeContextCallback<Selection> handler);
+    }
+    public enum ShellBarItemVisibility {
+        All = -1,
+        Arguments = 2,
+        Imports = 4,
+        MiniMap = 16,
+        None = 0,
+        PanMode = 32,
+        Variables = 1,
+        Zoom = 8,
+    }
+    public enum ShellHeaderItemsVisibility {
+        All = -1,
+        Breadcrumb = 1,
+        CollapseAll = 4,
+        ExpandAll = 2,
+        None = 0,
+    }
+    public sealed class TypePresenter : ContentControl, IComponentConnector, INotifyPropertyChanged {
+        public static readonly DependencyProperty AllowNullProperty;
+        public static readonly DependencyProperty BrowseTypeDirectlyProperty;
+        public static readonly DependencyProperty CenterActivityTypeResolverDialogProperty;
+        public static readonly DependencyProperty CenterTypeBrowserDialogProperty;
+        public static readonly DependencyProperty ContextProperty;
+        public static readonly DependencyProperty FilterProperty;
+        public static readonly DependencyProperty LabelProperty;
+        public static readonly DependencyProperty MostRecentlyUsedTypesProperty;
+        public static readonly DependencyProperty TextProperty;
+        public static readonly DependencyProperty TypeProperty;
+        public static readonly RoutedEvent TypeBrowserClosedEvent;
+        public static readonly RoutedEvent TypeBrowserOpenedEvent;
+        public static readonly RoutedEvent TypeChangedEvent;
+        public TypePresenter();
+        public bool AllowNull { get; set; }
+        public bool BrowseTypeDirectly { get; set; }
+        public bool CenterActivityTypeResolverDialog { get; set; }
+        public bool CenterTypeBrowserDialog { get; set; }
+        public EditingContext Context { get; set; }
+        public static ObservableCollection<Type> DefaultMostRecentlyUsedTypes { get; }
+        public Func<Type, bool> Filter { get; set; }
+        public IEnumerable<TypeWrapper> Items { get; }
+        public string Label { get; set; }
+        public ObservableCollection<Type> MostRecentlyUsedTypes { get; set; }
+        public string Text { get; private set; }
+        public Type Type { get; set; }
+        public string TypeName { get; }
+        public event PropertyChangedEventHandler PropertyChanged;
+        public event RoutedEventHandler TypeBrowserClosed;
+        public event RoutedEventHandler TypeBrowserOpened;
+        public event RoutedEventHandler TypeChanged;
+        public void FocusOnVisibleControl();
+        public void InitializeComponent();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e);
+        protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e);
+        protected override void OnPreviewKeyDown(KeyEventArgs e);
+        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target);
+    }
+    public class TypeResolvingOptions {
+        public TypeResolvingOptions();
+        public TypeResolvingOptions(IEnumerable<Type> defaultTypes);
+        public bool BrowseTypeDirectly { get; set; }
+        public Func<Type, bool> Filter { get; set; }
+    }
+    public sealed class TypeWrapper {
+        public string DisplayName { get; }
+        public bool IsTypeDefinition { get; }
+        public object Tag { get; private set; }
+        public Type Type { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public override string ToString();
+    }
+    public class ViewCreatedEventArgs : EventArgs {
+        public ViewCreatedEventArgs(WorkflowViewElement view);
+        public WorkflowViewElement View { get; }
+    }
+    public class ViewStateChangedEventArgs : EventArgs {
+        public ViewStateChangedEventArgs(ModelItem modelItem, string key, object newValue, object oldValue);
+        public string Key { get; }
+        public object NewValue { get; }
+        public object OldValue { get; }
+        public ModelItem ParentModelItem { get; }
+    }
+    public delegate void ViewStateChangedEventHandler(object sender, ViewStateChangedEventArgs e);
+    public abstract class ViewStateService {
+        protected ViewStateService();
+        public abstract event ViewStateChangedEventHandler UndoableViewStateChanged;
+        public abstract event ViewStateChangedEventHandler ViewStateChanged;
+        public abstract bool RemoveViewState(ModelItem modelItem, string key);
+        public abstract Dictionary<string, object> RetrieveAllViewState(ModelItem modelItem);
+        public abstract object RetrieveViewState(ModelItem modelItem, string key);
+        public abstract void StoreViewState(ModelItem modelItem, string key, object value);
+        public abstract void StoreViewStateWithUndo(ModelItem modelItem, string key, object value);
+    }
+    public class VirtualizedContainerService {
+        public static readonly AttachableMemberIdentifier HintSizeName;
+        public VirtualizedContainerService(EditingContext context);
+        public UIElement GetContainer(ModelItem modelItem, ICompositeView sourceContainer);
+        public static object GetHintSize(object instance);
+        public WorkflowViewElement GetViewElement(ModelItem modelItem, ICompositeView sourceContainer);
+        public static void SetHintSize(object instance, object value);
+    }
+    public class WorkflowViewService : ViewService {
+        public WorkflowViewService(EditingContext context);
+        public event EventHandler<ViewCreatedEventArgs> ViewCreated;
+        protected WorkflowViewElement CreateViewElement(ModelItem modelItem);
+        public override ModelItem GetModel(DependencyObject view);
+        public override DependencyObject GetView(ModelItem model);
+        public WorkflowViewElement GetViewElement(ModelItem modelItem);
+    }
+    public class WorkflowViewStateService : ViewStateService {
+        public static readonly AttachableMemberIdentifier ViewStateName;
+        public WorkflowViewStateService(EditingContext context);
+        public override event ViewStateChangedEventHandler UndoableViewStateChanged;
+        public override event ViewStateChangedEventHandler ViewStateChanged;
+        public static Dictionary<string, object> GetViewState(object instance);
+        public override bool RemoveViewState(ModelItem modelItem, string key);
+        public override Dictionary<string, object> RetrieveAllViewState(ModelItem modelItem);
+        public override object RetrieveViewState(ModelItem modelItem, string key);
+        public static void SetViewState(object instance, Dictionary<string, object> value);
+        public override void StoreViewState(ModelItem modelItem, string key, object value);
+        public override void StoreViewStateWithUndo(ModelItem modelItem, string key, object value);
+    }
+}
```

