// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.ComponentModel.Design
{
    public partial class ActiveDesignerEventArgs : System.EventArgs
    {
        public ActiveDesignerEventArgs(System.ComponentModel.Design.IDesignerHost oldDesigner, System.ComponentModel.Design.IDesignerHost newDesigner) { }
        public System.ComponentModel.Design.IDesignerHost NewDesigner { get { throw null; } }
        public System.ComponentModel.Design.IDesignerHost OldDesigner { get { throw null; } }
    }
    public delegate void ActiveDesignerEventHandler(object sender, System.ComponentModel.Design.ActiveDesignerEventArgs e);
    public partial class CheckoutException : System.Runtime.InteropServices.ExternalException
    {
        public static readonly System.ComponentModel.Design.CheckoutException Canceled;
        public CheckoutException() { }
        protected CheckoutException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public CheckoutException(string message) { }
        public CheckoutException(string message, System.Exception innerException) { }
        public CheckoutException(string message, int errorCode) { }
    }
    public partial class CommandID
    {
        public CommandID(System.Guid menuGroup, int commandID) { }
        public virtual System.Guid Guid { get { throw null; } }
        public virtual int ID { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public sealed partial class ComponentChangedEventArgs : System.EventArgs
    {
        public ComponentChangedEventArgs(object component, System.ComponentModel.MemberDescriptor member, object oldValue, object newValue) { }
        public object Component { get { throw null; } }
        public System.ComponentModel.MemberDescriptor Member { get { throw null; } }
        public object NewValue { get { throw null; } }
        public object OldValue { get { throw null; } }
    }
    public delegate void ComponentChangedEventHandler(object sender, System.ComponentModel.Design.ComponentChangedEventArgs e);
    public sealed partial class ComponentChangingEventArgs : System.EventArgs
    {
        public ComponentChangingEventArgs(object component, System.ComponentModel.MemberDescriptor member) { }
        public object Component { get { throw null; } }
        public System.ComponentModel.MemberDescriptor Member { get { throw null; } }
    }
    public delegate void ComponentChangingEventHandler(object sender, System.ComponentModel.Design.ComponentChangingEventArgs e);
    public partial class ComponentEventArgs : System.EventArgs
    {
        public ComponentEventArgs(System.ComponentModel.IComponent component) { }
        public virtual System.ComponentModel.IComponent Component { get { throw null; } }
    }
    public delegate void ComponentEventHandler(object sender, System.ComponentModel.Design.ComponentEventArgs e);
    public partial class ComponentRenameEventArgs : System.EventArgs
    {
        public ComponentRenameEventArgs(object component, string oldName, string newName) { }
        public object Component { get { throw null; } }
        public virtual string NewName { get { throw null; } }
        public virtual string OldName { get { throw null; } }
    }
    public delegate void ComponentRenameEventHandler(object sender, System.ComponentModel.Design.ComponentRenameEventArgs e);
    public partial class DesignerCollection : System.Collections.ICollection, System.Collections.IEnumerable
    {
        public DesignerCollection(System.Collections.IList designers) { }
        public DesignerCollection(System.ComponentModel.Design.IDesignerHost[] designers) { }
        public int Count { get { throw null; } }
        public virtual System.ComponentModel.Design.IDesignerHost this[int index] { get { throw null; } }
        int System.Collections.ICollection.Count { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class DesignerEventArgs : System.EventArgs
    {
        public DesignerEventArgs(System.ComponentModel.Design.IDesignerHost host) { }
        public System.ComponentModel.Design.IDesignerHost Designer { get { throw null; } }
    }
    public delegate void DesignerEventHandler(object sender, System.ComponentModel.Design.DesignerEventArgs e);
    public abstract partial class DesignerOptionService : System.ComponentModel.Design.IDesignerOptionService
    {
        protected DesignerOptionService() { }
        public System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection Options { get { throw null; } }
        protected System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection CreateOptionCollection(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection parent, string name, object value) { throw null; }
        protected virtual void PopulateOptionCollection(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection options) { }
        protected virtual bool ShowDialog(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection options, object optionObject) { throw null; }
        object System.ComponentModel.Design.IDesignerOptionService.GetOptionValue(string pageName, string valueName) { throw null; }
        void System.ComponentModel.Design.IDesignerOptionService.SetOptionValue(string pageName, string valueName, object value) { }
        public sealed partial class DesignerOptionCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
        {
            internal DesignerOptionCollection() { }
            public int Count { get { throw null; } }
            public System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection this[int index] { get { throw null; } }
            public System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection this[string name] { get { throw null; } }
            public string Name { get { throw null; } }
            public System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection Parent { get { throw null; } }
            public System.ComponentModel.PropertyDescriptorCollection Properties { get { throw null; } }
            bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
            object System.Collections.ICollection.SyncRoot { get { throw null; } }
            bool System.Collections.IList.IsFixedSize { get { throw null; } }
            bool System.Collections.IList.IsReadOnly { get { throw null; } }
            object System.Collections.IList.this[int index] { get { throw null; } set { } }
            public void CopyTo(System.Array array, int index) { }
            public System.Collections.IEnumerator GetEnumerator() { throw null; }
            public int IndexOf(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection value) { throw null; }
            public bool ShowDialog() { throw null; }
            int System.Collections.IList.Add(object value) { throw null; }
            void System.Collections.IList.Clear() { }
            bool System.Collections.IList.Contains(object value) { throw null; }
            int System.Collections.IList.IndexOf(object value) { throw null; }
            void System.Collections.IList.Insert(int index, object value) { }
            void System.Collections.IList.Remove(object value) { }
            void System.Collections.IList.RemoveAt(int index) { }
        }
    }
    public abstract partial class DesignerTransaction : System.IDisposable
    {
        protected DesignerTransaction() { }
        protected DesignerTransaction(string description) { }
        public bool Canceled { get { throw null; } }
        public bool Committed { get { throw null; } }
        public string Description { get { throw null; } }
        public void Cancel() { }
        public void Commit() { }
        protected virtual void Dispose(bool disposing) { }
        ~DesignerTransaction() { }
        protected abstract void OnCancel();
        protected abstract void OnCommit();
        void System.IDisposable.Dispose() { }
    }
    public partial class DesignerTransactionCloseEventArgs : System.EventArgs
    {
        [System.ObsoleteAttribute("This constructor is obsolete. Use DesignerTransactionCloseEventArgs(bool, bool) instead.  https://go.microsoft.com/fwlink/?linkid=14202")]
        public DesignerTransactionCloseEventArgs(bool commit) { }
        public DesignerTransactionCloseEventArgs(bool commit, bool lastTransaction) { }
        public bool LastTransaction { get { throw null; } }
        public bool TransactionCommitted { get { throw null; } }
    }
    public delegate void DesignerTransactionCloseEventHandler(object sender, System.ComponentModel.Design.DesignerTransactionCloseEventArgs e);
    public partial class DesignerVerb : System.ComponentModel.Design.MenuCommand
    {
        public DesignerVerb(string text, System.EventHandler handler) : base (default(System.EventHandler), default(System.ComponentModel.Design.CommandID)) { }
        public DesignerVerb(string text, System.EventHandler handler, System.ComponentModel.Design.CommandID startCommandID) : base (default(System.EventHandler), default(System.ComponentModel.Design.CommandID)) { }
        public string Description { get { throw null; } set { } }
        public string Text { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public partial class DesignerVerbCollection : System.Collections.CollectionBase
    {
        public DesignerVerbCollection() { }
        public DesignerVerbCollection(System.ComponentModel.Design.DesignerVerb[] value) { }
        public System.ComponentModel.Design.DesignerVerb this[int index] { get { throw null; } set { } }
        public int Add(System.ComponentModel.Design.DesignerVerb value) { throw null; }
        public void AddRange(System.ComponentModel.Design.DesignerVerbCollection value) { }
        public void AddRange(System.ComponentModel.Design.DesignerVerb[] value) { }
        public bool Contains(System.ComponentModel.Design.DesignerVerb value) { throw null; }
        public void CopyTo(System.ComponentModel.Design.DesignerVerb[] array, int index) { }
        public int IndexOf(System.ComponentModel.Design.DesignerVerb value) { throw null; }
        public void Insert(int index, System.ComponentModel.Design.DesignerVerb value) { }
        protected override void OnClear() { }
        protected override void OnInsert(int index, object value) { }
        protected override void OnRemove(int index, object value) { }
        protected override void OnSet(int index, object oldValue, object newValue) { }
        protected override void OnValidate(object value) { }
        public void Remove(System.ComponentModel.Design.DesignerVerb value) { }
    }
    public partial class DesigntimeLicenseContext : System.ComponentModel.LicenseContext
    {
        public DesigntimeLicenseContext() { }
        public override System.ComponentModel.LicenseUsageMode UsageMode { get { throw null; } }
        public override string GetSavedLicenseKey(System.Type type, System.Reflection.Assembly resourceAssembly) { throw null; }
        public override void SetSavedLicenseKey(System.Type type, string key) { }
    }
    public partial class DesigntimeLicenseContextSerializer
    {
        internal DesigntimeLicenseContextSerializer() { }
        public static void Serialize(System.IO.Stream o, string cryptoKey, System.ComponentModel.Design.DesigntimeLicenseContext context) { }
    }
    public enum HelpContextType
    {
        Ambient = 0,
        Selection = 2,
        ToolWindowSelection = 3,
        Window = 1,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All, AllowMultiple=false, Inherited=false)]
    public sealed partial class HelpKeywordAttribute : System.Attribute
    {
        public static readonly System.ComponentModel.Design.HelpKeywordAttribute Default;
        public HelpKeywordAttribute() { }
        public HelpKeywordAttribute(string keyword) { }
        public HelpKeywordAttribute(System.Type t) { }
        public string HelpKeyword { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override bool IsDefaultAttribute() { throw null; }
    }
    public enum HelpKeywordType
    {
        F1Keyword = 0,
        FilterKeyword = 2,
        GeneralKeyword = 1,
    }
    public partial interface IComponentChangeService
    {
        event System.ComponentModel.Design.ComponentEventHandler ComponentAdded;
        event System.ComponentModel.Design.ComponentEventHandler ComponentAdding;
        event System.ComponentModel.Design.ComponentChangedEventHandler ComponentChanged;
        event System.ComponentModel.Design.ComponentChangingEventHandler ComponentChanging;
        event System.ComponentModel.Design.ComponentEventHandler ComponentRemoved;
        event System.ComponentModel.Design.ComponentEventHandler ComponentRemoving;
        event System.ComponentModel.Design.ComponentRenameEventHandler ComponentRename;
        void OnComponentChanged(object component, System.ComponentModel.MemberDescriptor member, object oldValue, object newValue);
        void OnComponentChanging(object component, System.ComponentModel.MemberDescriptor member);
    }
    public partial interface IComponentDiscoveryService
    {
        System.Collections.ICollection GetComponentTypes(System.ComponentModel.Design.IDesignerHost designerHost, System.Type baseType);
    }
    public partial interface IComponentInitializer
    {
        void InitializeExistingComponent(System.Collections.IDictionary defaultValues);
        void InitializeNewComponent(System.Collections.IDictionary defaultValues);
    }
    public partial interface IDesigner : System.IDisposable
    {
        System.ComponentModel.IComponent Component { get; }
        System.ComponentModel.Design.DesignerVerbCollection Verbs { get; }
        void DoDefaultAction();
        void Initialize(System.ComponentModel.IComponent component);
    }
    public partial interface IDesignerEventService
    {
        System.ComponentModel.Design.IDesignerHost ActiveDesigner { get; }
        System.ComponentModel.Design.DesignerCollection Designers { get; }
        event System.ComponentModel.Design.ActiveDesignerEventHandler ActiveDesignerChanged;
        event System.ComponentModel.Design.DesignerEventHandler DesignerCreated;
        event System.ComponentModel.Design.DesignerEventHandler DesignerDisposed;
        event System.EventHandler SelectionChanged;
    }
    public partial interface IDesignerFilter
    {
        void PostFilterAttributes(System.Collections.IDictionary attributes);
        void PostFilterEvents(System.Collections.IDictionary events);
        void PostFilterProperties(System.Collections.IDictionary properties);
        void PreFilterAttributes(System.Collections.IDictionary attributes);
        void PreFilterEvents(System.Collections.IDictionary events);
        void PreFilterProperties(System.Collections.IDictionary properties);
    }
    public partial interface IDesignerHost : System.ComponentModel.Design.IServiceContainer, System.IServiceProvider
    {
        System.ComponentModel.IContainer Container { get; }
        bool InTransaction { get; }
        bool Loading { get; }
        System.ComponentModel.IComponent RootComponent { get; }
        string RootComponentClassName { get; }
        string TransactionDescription { get; }
        event System.EventHandler Activated;
        event System.EventHandler Deactivated;
        event System.EventHandler LoadComplete;
        event System.ComponentModel.Design.DesignerTransactionCloseEventHandler TransactionClosed;
        event System.ComponentModel.Design.DesignerTransactionCloseEventHandler TransactionClosing;
        event System.EventHandler TransactionOpened;
        event System.EventHandler TransactionOpening;
        void Activate();
        System.ComponentModel.IComponent CreateComponent(System.Type componentClass);
        System.ComponentModel.IComponent CreateComponent(System.Type componentClass, string name);
        System.ComponentModel.Design.DesignerTransaction CreateTransaction();
        System.ComponentModel.Design.DesignerTransaction CreateTransaction(string description);
        void DestroyComponent(System.ComponentModel.IComponent component);
        System.ComponentModel.Design.IDesigner GetDesigner(System.ComponentModel.IComponent component);
        System.Type GetType(string typeName);
    }
    public partial interface IDesignerHostTransactionState
    {
        bool IsClosingTransaction { get; }
    }
    public partial interface IDesignerOptionService
    {
        object GetOptionValue(string pageName, string valueName);
        void SetOptionValue(string pageName, string valueName, object value);
    }
    public partial interface IDictionaryService
    {
        object GetKey(object value);
        object GetValue(object key);
        void SetValue(object key, object value);
    }
    public partial interface IEventBindingService
    {
        string CreateUniqueMethodName(System.ComponentModel.IComponent component, System.ComponentModel.EventDescriptor e);
        System.Collections.ICollection GetCompatibleMethods(System.ComponentModel.EventDescriptor e);
        System.ComponentModel.EventDescriptor GetEvent(System.ComponentModel.PropertyDescriptor property);
        System.ComponentModel.PropertyDescriptorCollection GetEventProperties(System.ComponentModel.EventDescriptorCollection events);
        System.ComponentModel.PropertyDescriptor GetEventProperty(System.ComponentModel.EventDescriptor e);
        bool ShowCode();
        bool ShowCode(System.ComponentModel.IComponent component, System.ComponentModel.EventDescriptor e);
        bool ShowCode(int lineNumber);
    }
    public partial interface IExtenderListService
    {
        System.ComponentModel.IExtenderProvider[] GetExtenderProviders();
    }
    public partial interface IExtenderProviderService
    {
        void AddExtenderProvider(System.ComponentModel.IExtenderProvider provider);
        void RemoveExtenderProvider(System.ComponentModel.IExtenderProvider provider);
    }
    public partial interface IHelpService
    {
        void AddContextAttribute(string name, string value, System.ComponentModel.Design.HelpKeywordType keywordType);
        void ClearContextAttributes();
        System.ComponentModel.Design.IHelpService CreateLocalContext(System.ComponentModel.Design.HelpContextType contextType);
        void RemoveContextAttribute(string name, string value);
        void RemoveLocalContext(System.ComponentModel.Design.IHelpService localContext);
        void ShowHelpFromKeyword(string helpKeyword);
        void ShowHelpFromUrl(string helpUrl);
    }
    public partial interface IInheritanceService
    {
        void AddInheritedComponents(System.ComponentModel.IComponent component, System.ComponentModel.IContainer container);
        System.ComponentModel.InheritanceAttribute GetInheritanceAttribute(System.ComponentModel.IComponent component);
    }
    public partial interface IMenuCommandService
    {
        System.ComponentModel.Design.DesignerVerbCollection Verbs { get; }
        void AddCommand(System.ComponentModel.Design.MenuCommand command);
        void AddVerb(System.ComponentModel.Design.DesignerVerb verb);
        System.ComponentModel.Design.MenuCommand FindCommand(System.ComponentModel.Design.CommandID commandID);
        bool GlobalInvoke(System.ComponentModel.Design.CommandID commandID);
        void RemoveCommand(System.ComponentModel.Design.MenuCommand command);
        void RemoveVerb(System.ComponentModel.Design.DesignerVerb verb);
        void ShowContextMenu(System.ComponentModel.Design.CommandID menuID, int x, int y);
    }
    public partial interface IReferenceService
    {
        System.ComponentModel.IComponent GetComponent(object reference);
        string GetName(object reference);
        object GetReference(string name);
        object[] GetReferences();
        object[] GetReferences(System.Type baseType);
    }
    public partial interface IResourceService
    {
        System.Resources.IResourceReader GetResourceReader(System.Globalization.CultureInfo info);
        System.Resources.IResourceWriter GetResourceWriter(System.Globalization.CultureInfo info);
    }
    public partial interface IRootDesigner : System.ComponentModel.Design.IDesigner, System.IDisposable
    {
        System.ComponentModel.Design.ViewTechnology[] SupportedTechnologies { get; }
        object GetView(System.ComponentModel.Design.ViewTechnology technology);
    }
    public partial interface ISelectionService
    {
        object PrimarySelection { get; }
        int SelectionCount { get; }
        event System.EventHandler SelectionChanged;
        event System.EventHandler SelectionChanging;
        bool GetComponentSelected(object component);
        System.Collections.ICollection GetSelectedComponents();
        void SetSelectedComponents(System.Collections.ICollection components);
        void SetSelectedComponents(System.Collections.ICollection components, System.ComponentModel.Design.SelectionTypes selectionType);
    }
    public partial interface IServiceContainer : System.IServiceProvider
    {
        void AddService(System.Type serviceType, System.ComponentModel.Design.ServiceCreatorCallback callback);
        void AddService(System.Type serviceType, System.ComponentModel.Design.ServiceCreatorCallback callback, bool promote);
        void AddService(System.Type serviceType, object serviceInstance);
        void AddService(System.Type serviceType, object serviceInstance, bool promote);
        void RemoveService(System.Type serviceType);
        void RemoveService(System.Type serviceType, bool promote);
    }
    public partial interface ITreeDesigner : System.ComponentModel.Design.IDesigner, System.IDisposable
    {
        System.Collections.ICollection Children { get; }
        System.ComponentModel.Design.IDesigner Parent { get; }
    }
    public partial interface ITypeDescriptorFilterService
    {
        bool FilterAttributes(System.ComponentModel.IComponent component, System.Collections.IDictionary attributes);
        bool FilterEvents(System.ComponentModel.IComponent component, System.Collections.IDictionary events);
        bool FilterProperties(System.ComponentModel.IComponent component, System.Collections.IDictionary properties);
    }
    public partial interface ITypeDiscoveryService
    {
        System.Collections.ICollection GetTypes(System.Type baseType, bool excludeGlobalTypes);
    }
    public partial interface ITypeResolutionService
    {
        System.Reflection.Assembly GetAssembly(System.Reflection.AssemblyName name);
        System.Reflection.Assembly GetAssembly(System.Reflection.AssemblyName name, bool throwOnError);
        string GetPathOfAssembly(System.Reflection.AssemblyName name);
        System.Type GetType(string name);
        System.Type GetType(string name, bool throwOnError);
        System.Type GetType(string name, bool throwOnError, bool ignoreCase);
        void ReferenceAssembly(System.Reflection.AssemblyName name);
    }
    public partial class MenuCommand
    {
        public MenuCommand(System.EventHandler handler, System.ComponentModel.Design.CommandID command) { }
        public virtual bool Checked { get { throw null; } set { } }
        public virtual System.ComponentModel.Design.CommandID CommandID { get { throw null; } }
        public virtual bool Enabled { get { throw null; } set { } }
        public virtual int OleStatus { get { throw null; } }
        public virtual System.Collections.IDictionary Properties { get { throw null; } }
        public virtual bool Supported { get { throw null; } set { } }
        public virtual bool Visible { get { throw null; } set { } }
        public event System.EventHandler CommandChanged { add { } remove { } }
        public virtual void Invoke() { }
        public virtual void Invoke(object arg) { }
        protected virtual void OnCommandChanged(System.EventArgs e) { }
        public override string ToString() { throw null; }
    }
    [System.FlagsAttribute]
    public enum SelectionTypes
    {
        Add = 64,
        Auto = 1,
        [System.ObsoleteAttribute("This value has been deprecated. Use SelectionTypes.Primary instead.  https://go.microsoft.com/fwlink/?linkid=14202")]
        Click = 16,
        [System.ObsoleteAttribute("This value has been deprecated.  It is no longer supported. https://go.microsoft.com/fwlink/?linkid=14202")]
        MouseDown = 4,
        [System.ObsoleteAttribute("This value has been deprecated.  It is no longer supported. https://go.microsoft.com/fwlink/?linkid=14202")]
        MouseUp = 8,
        [System.ObsoleteAttribute("This value has been deprecated. Use SelectionTypes.Auto instead.  https://go.microsoft.com/fwlink/?linkid=14202")]
        Normal = 1,
        Primary = 16,
        Remove = 128,
        Replace = 2,
        Toggle = 32,
        [System.ObsoleteAttribute("This value has been deprecated. Use Enum class methods to determine valid values, or use a type converter. https://go.microsoft.com/fwlink/?linkid=14202")]
        Valid = 31,
    }
    public partial class ServiceContainer : System.ComponentModel.Design.IServiceContainer, System.IDisposable, System.IServiceProvider
    {
        public ServiceContainer() { }
        public ServiceContainer(System.IServiceProvider parentProvider) { }
        protected virtual System.Type[] DefaultServices { get { throw null; } }
        public void AddService(System.Type serviceType, System.ComponentModel.Design.ServiceCreatorCallback callback) { }
        public virtual void AddService(System.Type serviceType, System.ComponentModel.Design.ServiceCreatorCallback callback, bool promote) { }
        public void AddService(System.Type serviceType, object serviceInstance) { }
        public virtual void AddService(System.Type serviceType, object serviceInstance, bool promote) { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public virtual object GetService(System.Type serviceType) { throw null; }
        public void RemoveService(System.Type serviceType) { }
        public virtual void RemoveService(System.Type serviceType, bool promote) { }
    }
    public delegate object ServiceCreatorCallback(System.ComponentModel.Design.IServiceContainer container, System.Type serviceType);
    public partial class StandardCommands
    {
        public static readonly System.ComponentModel.Design.CommandID AlignBottom;
        public static readonly System.ComponentModel.Design.CommandID AlignHorizontalCenters;
        public static readonly System.ComponentModel.Design.CommandID AlignLeft;
        public static readonly System.ComponentModel.Design.CommandID AlignRight;
        public static readonly System.ComponentModel.Design.CommandID AlignToGrid;
        public static readonly System.ComponentModel.Design.CommandID AlignTop;
        public static readonly System.ComponentModel.Design.CommandID AlignVerticalCenters;
        public static readonly System.ComponentModel.Design.CommandID ArrangeBottom;
        public static readonly System.ComponentModel.Design.CommandID ArrangeIcons;
        public static readonly System.ComponentModel.Design.CommandID ArrangeRight;
        public static readonly System.ComponentModel.Design.CommandID BringForward;
        public static readonly System.ComponentModel.Design.CommandID BringToFront;
        public static readonly System.ComponentModel.Design.CommandID CenterHorizontally;
        public static readonly System.ComponentModel.Design.CommandID CenterVertically;
        public static readonly System.ComponentModel.Design.CommandID Copy;
        public static readonly System.ComponentModel.Design.CommandID Cut;
        public static readonly System.ComponentModel.Design.CommandID Delete;
        public static readonly System.ComponentModel.Design.CommandID DocumentOutline;
        public static readonly System.ComponentModel.Design.CommandID F1Help;
        public static readonly System.ComponentModel.Design.CommandID Group;
        public static readonly System.ComponentModel.Design.CommandID HorizSpaceConcatenate;
        public static readonly System.ComponentModel.Design.CommandID HorizSpaceDecrease;
        public static readonly System.ComponentModel.Design.CommandID HorizSpaceIncrease;
        public static readonly System.ComponentModel.Design.CommandID HorizSpaceMakeEqual;
        public static readonly System.ComponentModel.Design.CommandID LineupIcons;
        public static readonly System.ComponentModel.Design.CommandID LockControls;
        public static readonly System.ComponentModel.Design.CommandID MultiLevelRedo;
        public static readonly System.ComponentModel.Design.CommandID MultiLevelUndo;
        public static readonly System.ComponentModel.Design.CommandID Paste;
        public static readonly System.ComponentModel.Design.CommandID Properties;
        public static readonly System.ComponentModel.Design.CommandID PropertiesWindow;
        public static readonly System.ComponentModel.Design.CommandID Redo;
        public static readonly System.ComponentModel.Design.CommandID Replace;
        public static readonly System.ComponentModel.Design.CommandID SelectAll;
        public static readonly System.ComponentModel.Design.CommandID SendBackward;
        public static readonly System.ComponentModel.Design.CommandID SendToBack;
        public static readonly System.ComponentModel.Design.CommandID ShowGrid;
        public static readonly System.ComponentModel.Design.CommandID ShowLargeIcons;
        public static readonly System.ComponentModel.Design.CommandID SizeToControl;
        public static readonly System.ComponentModel.Design.CommandID SizeToControlHeight;
        public static readonly System.ComponentModel.Design.CommandID SizeToControlWidth;
        public static readonly System.ComponentModel.Design.CommandID SizeToFit;
        public static readonly System.ComponentModel.Design.CommandID SizeToGrid;
        public static readonly System.ComponentModel.Design.CommandID SnapToGrid;
        public static readonly System.ComponentModel.Design.CommandID TabOrder;
        public static readonly System.ComponentModel.Design.CommandID Undo;
        public static readonly System.ComponentModel.Design.CommandID Ungroup;
        public static readonly System.ComponentModel.Design.CommandID VerbFirst;
        public static readonly System.ComponentModel.Design.CommandID VerbLast;
        public static readonly System.ComponentModel.Design.CommandID VertSpaceConcatenate;
        public static readonly System.ComponentModel.Design.CommandID VertSpaceDecrease;
        public static readonly System.ComponentModel.Design.CommandID VertSpaceIncrease;
        public static readonly System.ComponentModel.Design.CommandID VertSpaceMakeEqual;
        public static readonly System.ComponentModel.Design.CommandID ViewCode;
        public static readonly System.ComponentModel.Design.CommandID ViewGrid;
        public StandardCommands() { }
    }
    public partial class StandardToolWindows
    {
        public static readonly System.Guid ObjectBrowser;
        public static readonly System.Guid OutputWindow;
        public static readonly System.Guid ProjectExplorer;
        public static readonly System.Guid PropertyBrowser;
        public static readonly System.Guid RelatedLinks;
        public static readonly System.Guid ServerExplorer;
        public static readonly System.Guid TaskList;
        public static readonly System.Guid Toolbox;
        public StandardToolWindows() { }
    }
    public abstract partial class TypeDescriptionProviderService
    {
        protected TypeDescriptionProviderService() { }
        public abstract System.ComponentModel.TypeDescriptionProvider GetProvider(object instance);
        public abstract System.ComponentModel.TypeDescriptionProvider GetProvider(System.Type type);
    }
    public enum ViewTechnology
    {
        Default = 2,
        [System.ObsoleteAttribute("This value has been deprecated. Use ViewTechnology.Default instead.  https://go.microsoft.com/fwlink/?linkid=14202")]
        Passthrough = 0,
        [System.ObsoleteAttribute("This value has been deprecated. Use ViewTechnology.Default instead.  https://go.microsoft.com/fwlink/?linkid=14202")]
        WindowsForms = 1,
    }
}
