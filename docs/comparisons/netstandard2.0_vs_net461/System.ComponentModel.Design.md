# System.ComponentModel.Design

``` diff
 namespace System.ComponentModel.Design {
+    public class ActiveDesignSurfaceChangedEventArgs : EventArgs {
+        public ActiveDesignSurfaceChangedEventArgs(DesignSurface oldSurface, DesignSurface newSurface);
+        public DesignSurface NewSurface { get; }
+        public DesignSurface OldSurface { get; }
+    }
+    public delegate void ActiveDesignSurfaceChangedEventHandler(object sender, ActiveDesignSurfaceChangedEventArgs e);
+    public class ArrayEditor : CollectionEditor {
+        public ArrayEditor(Type type);
+        protected override Type CreateCollectionItemType();
+        protected override object[] GetItems(object editValue);
+        protected override object SetItems(object editValue, object[] value);
+    }
+    public sealed class BinaryEditor : UITypeEditor {
+        public BinaryEditor();
+        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value);
+        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context);
+    }
+    public class ByteViewer : TableLayoutPanel {
+        public ByteViewer();
+        public virtual byte[] GetBytes();
+        public virtual DisplayMode GetDisplayMode();
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected override void OnLayout(LayoutEventArgs e);
+        protected override void OnPaint(PaintEventArgs e);
+        public virtual void SaveToFile(string path);
+        protected virtual void ScrollChanged(object source, EventArgs e);
+        public virtual void SetBytes(byte[] bytes);
+        public virtual void SetDisplayMode(DisplayMode mode);
+        public virtual void SetFile(string path);
+        public virtual void SetStartLine(int line);
+    }
+    public class CollectionEditor : UITypeEditor {
+        public CollectionEditor(Type type);
+        protected Type CollectionItemType { get; }
+        protected Type CollectionType { get; }
+        protected ITypeDescriptorContext Context { get; }
+        protected virtual string HelpTopic { get; }
+        protected Type[] NewItemTypes { get; }
+        protected virtual void CancelChanges();
+        protected virtual bool CanRemoveInstance(object value);
+        protected virtual bool CanSelectMultipleInstances();
+        protected virtual CollectionEditor.CollectionForm CreateCollectionForm();
+        protected virtual Type CreateCollectionItemType();
+        protected virtual object CreateInstance(Type itemType);
+        protected virtual Type[] CreateNewItemTypes();
+        protected virtual void DestroyInstance(object instance);
+        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value);
+        protected virtual string GetDisplayText(object value);
+        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context);
+        protected virtual object[] GetItems(object editValue);
+        protected virtual IList GetObjectsFromInstance(object instance);
+        protected object GetService(Type serviceType);
+        protected virtual object SetItems(object editValue, object[] value);
+        protected virtual void ShowHelp();
+        protected abstract class CollectionForm : Form {
+            public CollectionForm(CollectionEditor editor);
+            protected Type CollectionItemType { get; }
+            protected Type CollectionType { get; }
+            protected ITypeDescriptorContext Context { get; }
+            public object EditValue { get; set; }
+            protected object[] Items { get; set; }
+            protected Type[] NewItemTypes { get; }
+            protected bool CanRemoveInstance(object value);
+            protected virtual bool CanSelectMultipleInstances();
+            protected object CreateInstance(Type itemType);
+            protected void DestroyInstance(object instance);
+            protected virtual void DisplayError(Exception e);
+            protected override object GetService(Type serviceType);
+            protected abstract void OnEditValueChanged();
+            protected internal virtual DialogResult ShowEditorDialog(IWindowsFormsEditorService edSvc);
+        }
+    }
+    public enum ComponentActionsType {
+        All = 0,
+        Component = 1,
+        Service = 2,
+    }
+    public class ComponentDesigner : IComponentInitializer, IDesigner, IDesignerFilter, IDisposable, ITreeDesigner {
+        public ComponentDesigner();
+        public virtual DesignerActionListCollection ActionLists { get; }
+        public virtual ICollection AssociatedComponents { get; }
+        public IComponent Component { get; }
+        protected virtual InheritanceAttribute InheritanceAttribute { get; }
+        protected bool Inherited { get; }
+        protected virtual IComponent ParentComponent { get; }
+        protected ComponentDesigner.ShadowPropertyCollection ShadowProperties { get; }
+        ICollection System.ComponentModel.Design.ITreeDesigner.Children { get; }
+        IDesigner System.ComponentModel.Design.ITreeDesigner.Parent { get; }
+        public virtual DesignerVerbCollection Verbs { get; }
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        public virtual void DoDefaultAction();
+        ~ComponentDesigner();
+        protected virtual object GetService(Type serviceType);
+        public virtual void Initialize(IComponent component);
+        public virtual void InitializeExistingComponent(IDictionary defaultValues);
+        public virtual void InitializeNewComponent(IDictionary defaultValues);
+        public virtual void InitializeNonDefault();
+        protected InheritanceAttribute InvokeGetInheritanceAttribute(ComponentDesigner toInvoke);
+        public virtual void OnSetComponentDefaults();
+        protected virtual void PostFilterAttributes(IDictionary attributes);
+        protected virtual void PostFilterEvents(IDictionary events);
+        protected virtual void PostFilterProperties(IDictionary properties);
+        protected virtual void PreFilterAttributes(IDictionary attributes);
+        protected virtual void PreFilterEvents(IDictionary events);
+        protected virtual void PreFilterProperties(IDictionary properties);
+        protected void RaiseComponentChanged(MemberDescriptor member, object oldValue, object newValue);
+        protected void RaiseComponentChanging(MemberDescriptor member);
+        void System.ComponentModel.Design.IDesignerFilter.PostFilterAttributes(IDictionary attributes);
+        void System.ComponentModel.Design.IDesignerFilter.PostFilterEvents(IDictionary events);
+        void System.ComponentModel.Design.IDesignerFilter.PostFilterProperties(IDictionary properties);
+        void System.ComponentModel.Design.IDesignerFilter.PreFilterAttributes(IDictionary attributes);
+        void System.ComponentModel.Design.IDesignerFilter.PreFilterEvents(IDictionary events);
+        void System.ComponentModel.Design.IDesignerFilter.PreFilterProperties(IDictionary properties);
+        protected sealed class ShadowPropertyCollection {
+            public object this[string propertyName] { get; set; }
+            public bool Contains(string propertyName);
+        }
+    }
+    public class DateTimeEditor : UITypeEditor {
+        public DateTimeEditor();
+        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value);
+        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context);
+    }
+    public sealed class DesignerActionHeaderItem : DesignerActionTextItem {
+        public DesignerActionHeaderItem(string displayName);
+        public DesignerActionHeaderItem(string displayName, string category);
+    }
+    public abstract class DesignerActionItem {
+        public DesignerActionItem(string displayName, string category, string description);
+        public bool AllowAssociate { get; set; }
+        public virtual string Category { get; }
+        public virtual string Description { get; }
+        public virtual string DisplayName { get; }
+        public IDictionary Properties { get; }
+        public bool ShowInSourceView { get; set; }
+    }
+    public class DesignerActionItemCollection : CollectionBase {
+        public DesignerActionItemCollection();
+        public DesignerActionItem this[int index] { get; set; }
+        public int Add(DesignerActionItem value);
+        public bool Contains(DesignerActionItem value);
+        public void CopyTo(DesignerActionItem[] array, int index);
+        public int IndexOf(DesignerActionItem value);
+        public void Insert(int index, DesignerActionItem value);
+        public void Remove(DesignerActionItem value);
+    }
+    public class DesignerActionList {
+        public DesignerActionList(IComponent component);
+        public virtual bool AutoShow { get; set; }
+        public IComponent Component { get; }
+        public object GetService(Type serviceType);
+        public virtual DesignerActionItemCollection GetSortedActionItems();
+    }
+    public class DesignerActionListCollection : CollectionBase {
+        public DesignerActionListCollection();
+        public DesignerActionListCollection(DesignerActionList[] value);
+        public DesignerActionList this[int index] { get; set; }
+        public int Add(DesignerActionList value);
+        public void AddRange(DesignerActionListCollection value);
+        public void AddRange(DesignerActionList[] value);
+        public bool Contains(DesignerActionList value);
+        public void CopyTo(DesignerActionList[] array, int index);
+        public int IndexOf(DesignerActionList value);
+        public void Insert(int index, DesignerActionList value);
+        protected override void OnClear();
+        protected override void OnInsert(int index, object value);
+        protected override void OnRemove(int index, object value);
+        protected override void OnSet(int index, object oldValue, object newValue);
+        protected override void OnValidate(object value);
+        public void Remove(DesignerActionList value);
+    }
+    public class DesignerActionListsChangedEventArgs : EventArgs {
+        public DesignerActionListsChangedEventArgs(object relatedObject, DesignerActionListsChangedType changeType, DesignerActionListCollection actionLists);
+        public DesignerActionListCollection ActionLists { get; }
+        public DesignerActionListsChangedType ChangeType { get; }
+        public object RelatedObject { get; }
+    }
+    public delegate void DesignerActionListsChangedEventHandler(object sender, DesignerActionListsChangedEventArgs e);
+    public enum DesignerActionListsChangedType {
+        ActionListsAdded = 0,
+        ActionListsRemoved = 1,
+    }
+    public class DesignerActionMethodItem : DesignerActionItem {
+        public DesignerActionMethodItem(DesignerActionList actionList, string memberName, string displayName);
+        public DesignerActionMethodItem(DesignerActionList actionList, string memberName, string displayName, bool includeAsDesignerVerb);
+        public DesignerActionMethodItem(DesignerActionList actionList, string memberName, string displayName, string category);
+        public DesignerActionMethodItem(DesignerActionList actionList, string memberName, string displayName, string category, bool includeAsDesignerVerb);
+        public DesignerActionMethodItem(DesignerActionList actionList, string memberName, string displayName, string category, string description);
+        public DesignerActionMethodItem(DesignerActionList actionList, string memberName, string displayName, string category, string description, bool includeAsDesignerVerb);
+        public virtual bool IncludeAsDesignerVerb { get; }
+        public virtual string MemberName { get; }
+        public IComponent RelatedComponent { get; set; }
+        public virtual void Invoke();
+    }
+    public sealed class DesignerActionPropertyItem : DesignerActionItem {
+        public DesignerActionPropertyItem(string memberName, string displayName);
+        public DesignerActionPropertyItem(string memberName, string displayName, string category);
+        public DesignerActionPropertyItem(string memberName, string displayName, string category, string description);
+        public string MemberName { get; }
+        public IComponent RelatedComponent { get; set; }
+    }
+    public class DesignerActionService : IDisposable {
+        public DesignerActionService(IServiceProvider serviceProvider);
+        public event DesignerActionListsChangedEventHandler DesignerActionListsChanged;
+        public void Add(IComponent comp, DesignerActionList actionList);
+        public void Add(IComponent comp, DesignerActionListCollection designerActionListCollection);
+        public void Clear();
+        public bool Contains(IComponent comp);
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        public DesignerActionListCollection GetComponentActions(IComponent component);
+        public virtual DesignerActionListCollection GetComponentActions(IComponent component, ComponentActionsType type);
+        protected virtual void GetComponentDesignerActions(IComponent component, DesignerActionListCollection actionLists);
+        protected virtual void GetComponentServiceActions(IComponent component, DesignerActionListCollection actionLists);
+        public void Remove(DesignerActionList actionList);
+        public void Remove(IComponent comp);
+        public void Remove(IComponent comp, DesignerActionList actionList);
+    }
+    public class DesignerActionTextItem : DesignerActionItem {
+        public DesignerActionTextItem(string displayName, string category);
+    }
+    public sealed class DesignerActionUIService : IDisposable {
+        public event DesignerActionUIStateChangeEventHandler DesignerActionUIStateChange;
+        public void Dispose();
+        public void HideUI(IComponent component);
+        public void Refresh(IComponent component);
+        public bool ShouldAutoShow(IComponent component);
+        public void ShowUI(IComponent component);
+    }
+    public class DesignerActionUIStateChangeEventArgs : EventArgs {
+        public DesignerActionUIStateChangeEventArgs(object relatedObject, DesignerActionUIStateChangeType changeType);
+        public DesignerActionUIStateChangeType ChangeType { get; }
+        public object RelatedObject { get; }
+    }
+    public delegate void DesignerActionUIStateChangeEventHandler(object sender, DesignerActionUIStateChangeEventArgs e);
+    public enum DesignerActionUIStateChangeType {
+        Hide = 1,
+        Refresh = 2,
+        Show = 0,
+    }
+    public class DesignerCommandSet {
+        public DesignerCommandSet();
+        public DesignerActionListCollection ActionLists { get; }
+        public DesignerVerbCollection Verbs { get; }
+        public virtual ICollection GetCommands(string name);
+    }
+    public class DesignSurface : IDisposable, IServiceProvider {
+        public DesignSurface();
+        public DesignSurface(IServiceProvider parentProvider);
+        public DesignSurface(IServiceProvider parentProvider, Type rootComponentType);
+        public DesignSurface(Type rootComponentType);
+        public IContainer ComponentContainer { get; }
+        public bool DtelLoading { get; set; }
+        public bool IsLoaded { get; }
+        public ICollection LoadErrors { get; }
+        protected ServiceContainer ServiceContainer { get; }
+        public object View { get; }
+        public event EventHandler Disposed;
+        public event EventHandler Flushed;
+        public event LoadedEventHandler Loaded;
+        public event EventHandler Loading;
+        public event EventHandler Unloaded;
+        public event EventHandler Unloading;
+        public event EventHandler ViewActivated;
+        public void BeginLoad(DesignerLoader loader);
+        public void BeginLoad(Type rootComponentType);
+        protected internal virtual IComponent CreateComponent(Type componentType);
+        protected internal virtual IDesigner CreateDesigner(IComponent component, bool rootDesigner);
+        protected internal virtual object CreateInstance(Type type);
+        public INestedContainer CreateNestedContainer(IComponent owningComponent);
+        public INestedContainer CreateNestedContainer(IComponent owningComponent, string containerName);
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        public void Flush();
+        public object GetService(Type serviceType);
+        protected virtual void OnLoaded(LoadedEventArgs e);
+        protected virtual void OnLoading(EventArgs e);
+        protected virtual void OnUnloaded(EventArgs e);
+        protected virtual void OnUnloading(EventArgs e);
+        protected virtual void OnViewActivate(EventArgs e);
+    }
+    public sealed class DesignSurfaceCollection : ICollection, IEnumerable {
+        public int Count { get; }
+        int System.Collections.ICollection.Count { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        public DesignSurface this[int index] { get; }
+        public void CopyTo(DesignSurface[] array, int index);
+        public IEnumerator GetEnumerator();
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+    }
+    public class DesignSurfaceEventArgs : EventArgs {
+        public DesignSurfaceEventArgs(DesignSurface surface);
+        public DesignSurface Surface { get; }
+    }
+    public delegate void DesignSurfaceEventHandler(object sender, DesignSurfaceEventArgs e);
+    public class DesignSurfaceManager : IDisposable, IServiceProvider {
+        public DesignSurfaceManager();
+        public DesignSurfaceManager(IServiceProvider parentProvider);
+        public virtual DesignSurface ActiveDesignSurface { get; set; }
+        public DesignSurfaceCollection DesignSurfaces { get; }
+        protected ServiceContainer ServiceContainer { get; }
+        public event ActiveDesignSurfaceChangedEventHandler ActiveDesignSurfaceChanged;
+        public event DesignSurfaceEventHandler DesignSurfaceCreated;
+        public event DesignSurfaceEventHandler DesignSurfaceDisposed;
+        public event EventHandler SelectionChanged;
+        public DesignSurface CreateDesignSurface();
+        public DesignSurface CreateDesignSurface(IServiceProvider parentProvider);
+        protected virtual DesignSurface CreateDesignSurfaceCore(IServiceProvider parentProvider);
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        public object GetService(Type serviceType);
+    }
+    public enum DisplayMode {
+        Ansi = 2,
+        Auto = 4,
+        Hexdump = 1,
+        Unicode = 3,
+    }
+    public abstract class EventBindingService : IEventBindingService {
+        protected EventBindingService(IServiceProvider provider);
+        protected abstract string CreateUniqueMethodName(IComponent component, EventDescriptor e);
+        protected virtual void FreeMethod(IComponent component, EventDescriptor e, string methodName);
+        protected abstract ICollection GetCompatibleMethods(EventDescriptor e);
+        protected object GetService(Type serviceType);
+        protected abstract bool ShowCode();
+        protected abstract bool ShowCode(IComponent component, EventDescriptor e, string methodName);
+        protected abstract bool ShowCode(int lineNumber);
+        string System.ComponentModel.Design.IEventBindingService.CreateUniqueMethodName(IComponent component, EventDescriptor e);
+        ICollection System.ComponentModel.Design.IEventBindingService.GetCompatibleMethods(EventDescriptor e);
+        EventDescriptor System.ComponentModel.Design.IEventBindingService.GetEvent(PropertyDescriptor property);
+        PropertyDescriptorCollection System.ComponentModel.Design.IEventBindingService.GetEventProperties(EventDescriptorCollection events);
+        PropertyDescriptor System.ComponentModel.Design.IEventBindingService.GetEventProperty(EventDescriptor e);
+        bool System.ComponentModel.Design.IEventBindingService.ShowCode();
+        bool System.ComponentModel.Design.IEventBindingService.ShowCode(IComponent component, EventDescriptor e);
+        bool System.ComponentModel.Design.IEventBindingService.ShowCode(int lineNumber);
+        protected virtual void UseMethod(IComponent component, EventDescriptor e, string methodName);
+        protected virtual void ValidateMethodName(string methodName);
+    }
+    public sealed class ExceptionCollection : Exception {
+        public ExceptionCollection(ArrayList exceptions);
+        public ArrayList Exceptions { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public interface IComponentDesignerDebugService {
+        int IndentLevel { get; set; }
+        TraceListenerCollection Listeners { get; }
+        void Assert(bool condition, string message);
+        void Fail(string message);
+        void Trace(string message, string category);
+    }
+    public interface IComponentDesignerStateService {
+        object GetState(IComponent component, string key);
+        void SetState(IComponent component, string key, object value);
+    }
+    public interface IDesignTimeAssemblyLoader {
+        string GetTargetAssemblyPath(AssemblyName runtimeOrTargetAssemblyName, string suggestedAssemblyPath, FrameworkName targetFramework);
+        Assembly LoadRuntimeAssembly(AssemblyName targetAssemblyName);
+    }
+    public interface IMultitargetHelperService {
+        string GetAssemblyQualifiedName(Type type);
+    }
+    public class InheritanceService : IDisposable, IInheritanceService {
+        public InheritanceService();
+        public void AddInheritedComponents(IComponent component, IContainer container);
+        protected virtual void AddInheritedComponents(Type type, IComponent component, IContainer container);
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        public InheritanceAttribute GetInheritanceAttribute(IComponent component);
+        protected virtual bool IgnoreInheritedMember(MemberInfo member, IComponent component);
+    }
+    public sealed class LoadedEventArgs : EventArgs {
+        public LoadedEventArgs(bool succeeded, ICollection errors);
+        public ICollection Errors { get; }
+        public bool HasSucceeded { get; }
+    }
+    public delegate void LoadedEventHandler(object sender, LoadedEventArgs e);
+    public class LocalizationExtenderProvider : IDisposable, IExtenderProvider {
+        public LocalizationExtenderProvider(ISite serviceProvider, IComponent baseComponent);
+        public bool CanExtend(object o);
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        public CultureInfo GetLanguage(object o);
+        public CultureInfo GetLoadLanguage(object o);
+        public bool GetLocalizable(object o);
+        public void ResetLanguage(object o);
+        public void SetLanguage(object o, CultureInfo language);
+        public void SetLocalizable(object o, bool localizable);
+        public bool ShouldSerializeLanguage(object o);
+    }
+    public class MenuCommandsChangedEventArgs : EventArgs {
+        public MenuCommandsChangedEventArgs(MenuCommandsChangedType changeType, MenuCommand command);
+        public MenuCommandsChangedType ChangeType { get; }
+        public MenuCommand Command { get; }
+    }
+    public delegate void MenuCommandsChangedEventHandler(object sender, MenuCommandsChangedEventArgs e);
+    public enum MenuCommandsChangedType {
+        CommandAdded = 0,
+        CommandChanged = 2,
+        CommandRemoved = 1,
+    }
+    public class MenuCommandService : IDisposable, IMenuCommandService {
+        public MenuCommandService(IServiceProvider serviceProvider);
+        public virtual DesignerVerbCollection Verbs { get; }
+        public event MenuCommandsChangedEventHandler MenuCommandsChanged;
+        public virtual void AddCommand(MenuCommand command);
+        public virtual void AddVerb(DesignerVerb verb);
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        protected void EnsureVerbs();
+        public MenuCommand FindCommand(CommandID commandID);
+        protected MenuCommand FindCommand(Guid guid, int id);
+        protected ICollection GetCommandList(Guid guid);
+        protected object GetService(Type serviceType);
+        public virtual bool GlobalInvoke(CommandID commandID);
+        public virtual bool GlobalInvoke(CommandID commandId, object arg);
+        protected virtual void OnCommandsChanged(MenuCommandsChangedEventArgs e);
+        public virtual void RemoveCommand(MenuCommand command);
+        public virtual void RemoveVerb(DesignerVerb verb);
+        public virtual void ShowContextMenu(CommandID menuID, int x, int y);
+    }
+    public sealed class MultilineStringEditor : UITypeEditor {
+        public MultilineStringEditor();
+        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value);
+        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context);
+        public override bool GetPaintValueSupported(ITypeDescriptorContext context);
+    }
+    public abstract class ObjectSelectorEditor : UITypeEditor {
+        public bool SubObjectSelector;
+        protected object currValue;
+        protected object prevValue;
+        public ObjectSelectorEditor();
+        public ObjectSelectorEditor(bool subObjectSelector);
+        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value);
+        public bool EqualsToValue(object value);
+        protected virtual void FillTreeWithData(ObjectSelectorEditor.Selector selector, ITypeDescriptorContext context, IServiceProvider provider);
+        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context);
+        public virtual void SetValue(object value);
+        public class Selector : TreeView {
+            public bool clickSeen;
+            public Selector(ObjectSelectorEditor editor);
+            public ObjectSelectorEditor.SelectorNode AddNode(string label, object value, ObjectSelectorEditor.SelectorNode parent);
+            public void Clear();
+            protected void OnAfterSelect(object sender, TreeViewEventArgs e);
+            protected override void OnKeyDown(KeyEventArgs e);
+            protected override void OnKeyPress(KeyPressEventArgs e);
+            protected override void OnNodeMouseClick(TreeNodeMouseClickEventArgs e);
+            public bool SetSelection(object value, TreeNodeCollection nodes);
+            public void Start(IWindowsFormsEditorService edSvc, object value);
+            public void Stop();
+            protected override void WndProc(ref Message m);
+        }
+        public class SelectorNode : TreeNode {
+            public object value;
+            public SelectorNode(string label, object value);
+        }
+    }
+    public sealed class ProjectTargetFrameworkAttribute : Attribute {
+        public ProjectTargetFrameworkAttribute(string targetFrameworkMoniker);
+        public string TargetFrameworkMoniker { get; }
+    }
+    public abstract class UndoEngine : IDisposable {
+        protected UndoEngine(IServiceProvider provider);
+        public bool Enabled { get; set; }
+        public bool UndoInProgress { get; }
+        public event EventHandler Undoing;
+        public event EventHandler Undone;
+        protected abstract void AddUndoUnit(UndoEngine.UndoUnit unit);
+        protected virtual UndoEngine.UndoUnit CreateUndoUnit(string name, bool primary);
+        protected virtual void DiscardUndoUnit(UndoEngine.UndoUnit unit);
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        protected object GetRequiredService(Type serviceType);
+        protected object GetService(Type serviceType);
+        protected virtual void OnUndoing(EventArgs e);
+        protected virtual void OnUndone(EventArgs e);
+        protected class UndoUnit {
+            public UndoUnit(UndoEngine engine, string name);
+            public virtual bool IsEmpty { get; }
+            public string Name { get; }
+            protected UndoEngine UndoEngine { get; }
+            public virtual void Close();
+            public virtual void ComponentAdded(ComponentEventArgs e);
+            public virtual void ComponentAdding(ComponentEventArgs e);
+            public virtual void ComponentChanged(ComponentChangedEventArgs e);
+            public virtual void ComponentChanging(ComponentChangingEventArgs e);
+            public virtual void ComponentRemoved(ComponentEventArgs e);
+            public virtual void ComponentRemoving(ComponentEventArgs e);
+            public virtual void ComponentRename(ComponentRenameEventArgs e);
+            protected object GetService(Type serviceType);
+            public override string ToString();
+            public void Undo();
+            protected virtual void UndoCore();
+        }
+    }
 }
```

