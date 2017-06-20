# System.Windows.Data

``` diff
+namespace System.Windows.Data {
+    public class Binding : BindingBase {
+        public static readonly object DoNothing;
+        public const string IndexerName = "Item[]";
+        public static readonly DependencyProperty XmlNamespaceManagerProperty;
+        public static readonly RoutedEvent SourceUpdatedEvent;
+        public static readonly RoutedEvent TargetUpdatedEvent;
+        public Binding();
+        public Binding(string path);
+        public object AsyncState { get; set; }
+        public bool BindsDirectlyToSource { get; set; }
+        public IValueConverter Converter { get; set; }
+        public CultureInfo ConverterCulture { get; set; }
+        public object ConverterParameter { get; set; }
+        public string ElementName { get; set; }
+        public bool IsAsync { get; set; }
+        public BindingMode Mode { get; set; }
+        public bool NotifyOnSourceUpdated { get; set; }
+        public bool NotifyOnTargetUpdated { get; set; }
+        public bool NotifyOnValidationError { get; set; }
+        public PropertyPath Path { get; set; }
+        public RelativeSource RelativeSource { get; set; }
+        public object Source { get; set; }
+        public UpdateSourceExceptionFilterCallback UpdateSourceExceptionFilter { get; set; }
+        public UpdateSourceTrigger UpdateSourceTrigger { get; set; }
+        public bool ValidatesOnDataErrors { get; set; }
+        public bool ValidatesOnExceptions { get; set; }
+        public bool ValidatesOnNotifyDataErrors { get; set; }
+        public Collection<ValidationRule> ValidationRules { get; }
+        public string XPath { get; set; }
+        public static void AddSourceUpdatedHandler(DependencyObject element, EventHandler<DataTransferEventArgs> handler);
+        public static void AddTargetUpdatedHandler(DependencyObject element, EventHandler<DataTransferEventArgs> handler);
+        public static XmlNamespaceManager GetXmlNamespaceManager(DependencyObject target);
+        public static void RemoveSourceUpdatedHandler(DependencyObject element, EventHandler<DataTransferEventArgs> handler);
+        public static void RemoveTargetUpdatedHandler(DependencyObject element, EventHandler<DataTransferEventArgs> handler);
+        public static void SetXmlNamespaceManager(DependencyObject target, XmlNamespaceManager value);
+        public bool ShouldSerializePath();
+        public bool ShouldSerializeSource();
+        public bool ShouldSerializeValidationRules();
+    }
+    public abstract class BindingBase : MarkupExtension {
+        public string BindingGroupName { get; set; }
+        public int Delay { get; set; }
+        public object FallbackValue { get; set; }
+        public string StringFormat { get; set; }
+        public object TargetNullValue { get; set; }
+        public sealed override object ProvideValue(IServiceProvider serviceProvider);
+        public bool ShouldSerializeFallbackValue();
+        public bool ShouldSerializeTargetNullValue();
+    }
+    public sealed class BindingExpression : BindingExpressionBase, IDataBindEngineClient, IWeakEventListener {
+        public object DataItem { get; }
+        public Binding ParentBinding { get; }
+        public object ResolvedSource { get; }
+        public string ResolvedSourcePropertyName { get; }
+        bool System.Windows.IWeakEventListener.ReceiveWeakEvent(Type managerType, object sender, EventArgs e);
+        public override void UpdateSource();
+        public override void UpdateTarget();
+    }
+    public abstract class BindingExpressionBase : Expression, IWeakEventListener {
+        public BindingGroup BindingGroup { get; }
+        public virtual bool HasError { get; }
+        public virtual bool HasValidationError { get; }
+        public bool IsDirty { get; }
+        public BindingBase ParentBindingBase { get; }
+        public BindingStatus Status { get; }
+        public DependencyObject Target { get; }
+        public DependencyProperty TargetProperty { get; }
+        public virtual ValidationError ValidationError { get; }
+        public virtual ReadOnlyCollection<ValidationError> ValidationErrors { get; }
+        bool System.Windows.IWeakEventListener.ReceiveWeakEvent(Type managerType, object sender, EventArgs e);
+        public virtual void UpdateSource();
+        public virtual void UpdateTarget();
+        public bool ValidateWithoutUpdate();
+    }
+    public class BindingGroup : DependencyObject {
+        public BindingGroup();
+        public Collection<BindingExpressionBase> BindingExpressions { get; }
+        public bool CanRestoreValues { get; }
+        public bool HasValidationError { get; }
+        public bool IsDirty { get; }
+        public IList Items { get; }
+        public string Name { get; set; }
+        public bool NotifyOnValidationError { get; set; }
+        public DependencyObject Owner { get; }
+        public bool SharesProposedValues { get; set; }
+        public bool ValidatesOnNotifyDataError { get; set; }
+        public ReadOnlyCollection<ValidationError> ValidationErrors { get; }
+        public Collection<ValidationRule> ValidationRules { get; }
+        public void BeginEdit();
+        public void CancelEdit();
+        public bool CommitEdit();
+        public object GetValue(object item, string propertyName);
+        public bool TryGetValue(object item, string propertyName, out object value);
+        public bool UpdateSources();
+        public bool ValidateWithoutUpdate();
+    }
+    public sealed class BindingListCollectionView : CollectionView, ICollectionViewLiveShaping, IComparer, IEditableCollectionView, IItemProperties {
+        public BindingListCollectionView(IBindingList list);
+        public bool CanAddNew { get; }
+        public bool CanCancelEdit { get; }
+        public bool CanChangeLiveFiltering { get; }
+        public bool CanChangeLiveGrouping { get; }
+        public bool CanChangeLiveSorting { get; }
+        public bool CanCustomFilter { get; }
+        public override bool CanFilter { get; }
+        public override bool CanGroup { get; }
+        public bool CanRemove { get; }
+        public override bool CanSort { get; }
+        public override int Count { get; }
+        public object CurrentAddItem { get; }
+        public object CurrentEditItem { get; }
+        public string CustomFilter { get; set; }
+        public GroupDescriptionSelectorCallback GroupBySelector { get; set; }
+        public override ObservableCollection<GroupDescription> GroupDescriptions { get; }
+        public override ReadOnlyObservableCollection<object> Groups { get; }
+        public bool IsAddingNew { get; }
+        public bool IsDataInGroupOrder { get; set; }
+        public bool IsEditingItem { get; }
+        public override bool IsEmpty { get; }
+        public Nullable<bool> IsLiveFiltering { get; set; }
+        public Nullable<bool> IsLiveGrouping { get; set; }
+        public Nullable<bool> IsLiveSorting { get; set; }
+        public ReadOnlyCollection<ItemPropertyInfo> ItemProperties { get; }
+        public ObservableCollection<string> LiveFilteringProperties { get; }
+        public ObservableCollection<string> LiveGroupingProperties { get; }
+        public ObservableCollection<string> LiveSortingProperties { get; }
+        public NewItemPlaceholderPosition NewItemPlaceholderPosition { get; set; }
+        public override SortDescriptionCollection SortDescriptions { get; }
+        public object AddNew();
+        public void CancelEdit();
+        public void CancelNew();
+        public void CommitEdit();
+        public void CommitNew();
+        public override bool Contains(object item);
+        public override void DetachFromSourceCollection();
+        public void EditItem(object item);
+        protected override IEnumerator GetEnumerator();
+        public override object GetItemAt(int index);
+        public override int IndexOf(object item);
+        public override bool MoveCurrentToPosition(int position);
+        protected override void OnAllowsCrossThreadChangesChanged();
+        protected override void OnBeginChangeLogging(NotifyCollectionChangedEventArgs args);
+        public override bool PassesFilter(object item);
+        protected override void ProcessCollectionChanged(NotifyCollectionChangedEventArgs args);
+        protected override void RefreshOverride();
+        public void Remove(object item);
+        public void RemoveAt(int index);
+        int System.Collections.IComparer.Compare(object o1, object o2);
+    }
+    public enum BindingMode {
+        Default = 4,
+        OneTime = 2,
+        OneWay = 1,
+        OneWayToSource = 3,
+        TwoWay = 0,
+    }
+    public static class BindingOperations {
+        public static object DisconnectedSource { get; }
+        public static event EventHandler<CollectionRegisteringEventArgs> CollectionRegistering;
+        public static event EventHandler<CollectionViewRegisteringEventArgs> CollectionViewRegistering;
+        public static void AccessCollection(IEnumerable collection, Action accessMethod, bool writeAccess);
+        public static void ClearAllBindings(DependencyObject target);
+        public static void ClearBinding(DependencyObject target, DependencyProperty dp);
+        public static void DisableCollectionSynchronization(IEnumerable collection);
+        public static void EnableCollectionSynchronization(IEnumerable collection, object lockObject);
+        public static void EnableCollectionSynchronization(IEnumerable collection, object context, CollectionSynchronizationCallback synchronizationCallback);
+        public static Binding GetBinding(DependencyObject target, DependencyProperty dp);
+        public static BindingBase GetBindingBase(DependencyObject target, DependencyProperty dp);
+        public static BindingExpression GetBindingExpression(DependencyObject target, DependencyProperty dp);
+        public static BindingExpressionBase GetBindingExpressionBase(DependencyObject target, DependencyProperty dp);
+        public static MultiBinding GetMultiBinding(DependencyObject target, DependencyProperty dp);
+        public static MultiBindingExpression GetMultiBindingExpression(DependencyObject target, DependencyProperty dp);
+        public static PriorityBinding GetPriorityBinding(DependencyObject target, DependencyProperty dp);
+        public static PriorityBindingExpression GetPriorityBindingExpression(DependencyObject target, DependencyProperty dp);
+        public static ReadOnlyCollection<BindingGroup> GetSourceUpdatingBindingGroups(DependencyObject root);
+        public static ReadOnlyCollection<BindingExpressionBase> GetSourceUpdatingBindings(DependencyObject root);
+        public static bool IsDataBound(DependencyObject target, DependencyProperty dp);
+        public static BindingExpressionBase SetBinding(DependencyObject target, DependencyProperty dp, BindingBase binding);
+    }
+    public enum BindingStatus {
+        Active = 2,
+        AsyncRequestPending = 4,
+        Detached = 3,
+        Inactive = 1,
+        PathError = 5,
+        Unattached = 0,
+        UpdateSourceError = 7,
+        UpdateTargetError = 6,
+    }
+    public class CollectionContainer : DependencyObject, INotifyCollectionChanged, IWeakEventListener {
+        public static readonly DependencyProperty CollectionProperty;
+        public CollectionContainer();
+        public IEnumerable Collection { get; set; }
+        protected virtual event NotifyCollectionChangedEventHandler CollectionChanged;
+        event NotifyCollectionChangedEventHandler System.Collections.Specialized.INotifyCollectionChanged.CollectionChanged;
+        protected virtual void OnContainedCollectionChanged(NotifyCollectionChangedEventArgs args);
+        protected virtual bool ReceiveWeakEvent(Type managerType, object sender, EventArgs e);
+        public bool ShouldSerializeCollection();
+        bool System.Windows.IWeakEventListener.ReceiveWeakEvent(Type managerType, object sender, EventArgs e);
+    }
+    public class CollectionRegisteringEventArgs : EventArgs {
+        public IEnumerable Collection { get; }
+        public object Parent { get; }
+    }
+    public delegate void CollectionSynchronizationCallback(IEnumerable collection, object context, Action accessMethod, bool writeAccess);
+    public class CollectionView : DispatcherObject, ICollectionView, IEnumerable, INotifyCollectionChanged, INotifyPropertyChanged {
+        public CollectionView(IEnumerable collection);
+        protected bool AllowsCrossThreadChanges { get; }
+        public virtual bool CanFilter { get; }
+        public virtual bool CanGroup { get; }
+        public virtual bool CanSort { get; }
+        public virtual IComparer Comparer { get; }
+        public virtual int Count { get; }
+        public virtual CultureInfo Culture { get; set; }
+        public virtual object CurrentItem { get; }
+        public virtual int CurrentPosition { get; }
+        public virtual Predicate<object> Filter { get; set; }
+        public virtual ObservableCollection<GroupDescription> GroupDescriptions { get; }
+        public virtual ReadOnlyObservableCollection<object> Groups { get; }
+        public virtual bool IsCurrentAfterLast { get; }
+        public virtual bool IsCurrentBeforeFirst { get; }
+        protected bool IsCurrentInSync { get; }
+        protected bool IsDynamic { get; }
+        public virtual bool IsEmpty { get; }
+        public virtual bool IsInUse { get; }
+        protected bool IsRefreshDeferred { get; }
+        public virtual bool NeedsRefresh { get; }
+        public static object NewItemPlaceholder { get; }
+        public virtual SortDescriptionCollection SortDescriptions { get; }
+        public virtual IEnumerable SourceCollection { get; }
+        protected bool UpdatedOutsideDispatcher { get; }
+        protected virtual event NotifyCollectionChangedEventHandler CollectionChanged;
+        public virtual event EventHandler CurrentChanged;
+        public virtual event CurrentChangingEventHandler CurrentChanging;
+        protected virtual event PropertyChangedEventHandler PropertyChanged;
+        event NotifyCollectionChangedEventHandler System.Collections.Specialized.INotifyCollectionChanged.CollectionChanged;
+        event PropertyChangedEventHandler System.ComponentModel.INotifyPropertyChanged.PropertyChanged;
+        protected void ClearChangeLog();
+        protected void ClearPendingChanges();
+        public virtual bool Contains(object item);
+        public virtual IDisposable DeferRefresh();
+        public virtual void DetachFromSourceCollection();
+        protected virtual IEnumerator GetEnumerator();
+        public virtual object GetItemAt(int index);
+        public virtual int IndexOf(object item);
+        public virtual bool MoveCurrentTo(object item);
+        public virtual bool MoveCurrentToFirst();
+        public virtual bool MoveCurrentToLast();
+        public virtual bool MoveCurrentToNext();
+        public virtual bool MoveCurrentToPosition(int position);
+        public virtual bool MoveCurrentToPrevious();
+        protected bool OKToChangeCurrent();
+        protected virtual void OnAllowsCrossThreadChangesChanged();
+        protected virtual void OnBeginChangeLogging(NotifyCollectionChangedEventArgs args);
+        protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs args);
+        protected void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs args);
+        protected virtual void OnCurrentChanged();
+        protected void OnCurrentChanging();
+        protected virtual void OnCurrentChanging(CurrentChangingEventArgs args);
+        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e);
+        public virtual bool PassesFilter(object item);
+        protected virtual void ProcessCollectionChanged(NotifyCollectionChangedEventArgs args);
+        protected void ProcessPendingChanges();
+        public virtual void Refresh();
+        protected void RefreshOrDefer();
+        protected virtual void RefreshOverride();
+        protected void SetCurrent(object newItem, int newPosition);
+        protected void SetCurrent(object newItem, int newPosition, int count);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+    }
+    public abstract class CollectionViewGroup : INotifyPropertyChanged {
+        protected CollectionViewGroup(object name);
+        public abstract bool IsBottomLevel { get; }
+        public int ItemCount { get; }
+        public ReadOnlyObservableCollection<object> Items { get; }
+        public object Name { get; }
+        protected int ProtectedItemCount { get; set; }
+        protected ObservableCollection<object> ProtectedItems { get; }
+        protected virtual event PropertyChangedEventHandler PropertyChanged;
+        event PropertyChangedEventHandler System.ComponentModel.INotifyPropertyChanged.PropertyChanged;
+        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e);
+    }
+    public class CollectionViewRegisteringEventArgs : EventArgs {
+        public CollectionView CollectionView { get; }
+    }
+    public class CollectionViewSource : DependencyObject, ISupportInitialize, IWeakEventListener {
+        public static readonly DependencyProperty CanChangeLiveFilteringProperty;
+        public static readonly DependencyProperty CanChangeLiveGroupingProperty;
+        public static readonly DependencyProperty CanChangeLiveSortingProperty;
+        public static readonly DependencyProperty CollectionViewTypeProperty;
+        public static readonly DependencyProperty IsLiveFilteringProperty;
+        public static readonly DependencyProperty IsLiveFilteringRequestedProperty;
+        public static readonly DependencyProperty IsLiveGroupingProperty;
+        public static readonly DependencyProperty IsLiveGroupingRequestedProperty;
+        public static readonly DependencyProperty IsLiveSortingProperty;
+        public static readonly DependencyProperty IsLiveSortingRequestedProperty;
+        public static readonly DependencyProperty SourceProperty;
+        public static readonly DependencyProperty ViewProperty;
+        public CollectionViewSource();
+        public bool CanChangeLiveFiltering { get; private set; }
+        public bool CanChangeLiveGrouping { get; private set; }
+        public bool CanChangeLiveSorting { get; private set; }
+        public Type CollectionViewType { get; set; }
+        public CultureInfo Culture { get; set; }
+        public ObservableCollection<GroupDescription> GroupDescriptions { get; }
+        public Nullable<bool> IsLiveFiltering { get; private set; }
+        public bool IsLiveFilteringRequested { get; set; }
+        public Nullable<bool> IsLiveGrouping { get; private set; }
+        public bool IsLiveGroupingRequested { get; set; }
+        public Nullable<bool> IsLiveSorting { get; private set; }
+        public bool IsLiveSortingRequested { get; set; }
+        public ObservableCollection<string> LiveFilteringProperties { get; }
+        public ObservableCollection<string> LiveGroupingProperties { get; }
+        public ObservableCollection<string> LiveSortingProperties { get; }
+        public SortDescriptionCollection SortDescriptions { get; }
+        public object Source { get; set; }
+        public ICollectionView View { get; }
+        public event FilterEventHandler Filter;
+        public IDisposable DeferRefresh();
+        public static ICollectionView GetDefaultView(object source);
+        public static bool IsDefaultView(ICollectionView view);
+        protected virtual void OnCollectionViewTypeChanged(Type oldCollectionViewType, Type newCollectionViewType);
+        protected virtual void OnSourceChanged(object oldSource, object newSource);
+        protected virtual bool ReceiveWeakEvent(Type managerType, object sender, EventArgs e);
+        void System.ComponentModel.ISupportInitialize.BeginInit();
+        void System.ComponentModel.ISupportInitialize.EndInit();
+        bool System.Windows.IWeakEventListener.ReceiveWeakEvent(Type managerType, object sender, EventArgs e);
+    }
+    public class CompositeCollection : ICollection, ICollectionViewFactory, IEnumerable, IList, INotifyCollectionChanged, IWeakEventListener {
+        public CompositeCollection();
+        public CompositeCollection(int capacity);
+        public int Count { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        public object this[int itemIndex] { get; set; }
+        protected event NotifyCollectionChangedEventHandler CollectionChanged;
+        event NotifyCollectionChangedEventHandler System.Collections.Specialized.INotifyCollectionChanged.CollectionChanged;
+        public int Add(object newItem);
+        public void Clear();
+        public bool Contains(object containItem);
+        public void CopyTo(Array array, int index);
+        public int IndexOf(object indexItem);
+        public void Insert(int insertIndex, object insertItem);
+        protected virtual bool ReceiveWeakEvent(Type managerType, object sender, EventArgs e);
+        public void Remove(object removeItem);
+        public void RemoveAt(int removeIndex);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        ICollectionView System.ComponentModel.ICollectionViewFactory.CreateView();
+        bool System.Windows.IWeakEventListener.ReceiveWeakEvent(Type managerType, object sender, EventArgs e);
+    }
+    public class DataChangedEventManager : WeakEventManager {
+        public static void AddHandler(DataSourceProvider source, EventHandler<EventArgs> handler);
+        public static void AddListener(DataSourceProvider source, IWeakEventListener listener);
+        protected override WeakEventManager.ListenerList NewListenerList();
+        public static void RemoveHandler(DataSourceProvider source, EventHandler<EventArgs> handler);
+        public static void RemoveListener(DataSourceProvider source, IWeakEventListener listener);
+        protected override void StartListening(object source);
+        protected override void StopListening(object source);
+    }
+    public abstract class DataSourceProvider : INotifyPropertyChanged, ISupportInitialize {
+        protected DataSourceProvider();
+        public object Data { get; }
+        protected Dispatcher Dispatcher { get; set; }
+        public Exception Error { get; }
+        public bool IsInitialLoadEnabled { get; set; }
+        protected bool IsRefreshDeferred { get; }
+        public event EventHandler DataChanged;
+        protected virtual event PropertyChangedEventHandler PropertyChanged;
+        event PropertyChangedEventHandler System.ComponentModel.INotifyPropertyChanged.PropertyChanged;
+        protected virtual void BeginInit();
+        protected virtual void BeginQuery();
+        public virtual IDisposable DeferRefresh();
+        protected virtual void EndInit();
+        public void InitialLoad();
+        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e);
+        protected void OnQueryFinished(object newData);
+        protected virtual void OnQueryFinished(object newData, Exception error, DispatcherOperationCallback completionWork, object callbackArguments);
+        public void Refresh();
+        void System.ComponentModel.ISupportInitialize.BeginInit();
+        void System.ComponentModel.ISupportInitialize.EndInit();
+    }
+    public class DataTransferEventArgs : RoutedEventArgs {
+        public DependencyProperty Property { get; }
+        public DependencyObject TargetObject { get; }
+        protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget);
+    }
+    public class FilterEventArgs : EventArgs {
+        public bool Accepted { get; set; }
+        public object Item { get; }
+    }
+    public delegate void FilterEventHandler(object sender, FilterEventArgs e);
+    public delegate GroupDescription GroupDescriptionSelectorCallback(CollectionViewGroup group, int level);
+    public interface IMultiValueConverter {
+        object Convert(object[] values, Type targetType, object parameter, CultureInfo culture);
+        object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture);
+    }
+    public interface IValueConverter {
+        object Convert(object value, Type targetType, object parameter, CultureInfo culture);
+        object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);
+    }
+    public class ListCollectionView : CollectionView, ICollectionViewLiveShaping, IComparer, IEditableCollectionView, IEditableCollectionViewAddNewItem, IItemProperties {
+        public ListCollectionView(IList list);
+        protected IComparer ActiveComparer { get; set; }
+        protected Predicate<object> ActiveFilter { get; set; }
+        public bool CanAddNew { get; }
+        public bool CanAddNewItem { get; }
+        public bool CanCancelEdit { get; }
+        public bool CanChangeLiveFiltering { get; }
+        public bool CanChangeLiveGrouping { get; }
+        public bool CanChangeLiveSorting { get; }
+        public override bool CanFilter { get; }
+        public override bool CanGroup { get; }
+        public bool CanRemove { get; }
+        public override bool CanSort { get; }
+        public override int Count { get; }
+        public object CurrentAddItem { get; }
+        public object CurrentEditItem { get; }
+        public IComparer CustomSort { get; set; }
+        public override Predicate<object> Filter { get; set; }
+        public virtual GroupDescriptionSelectorCallback GroupBySelector { get; set; }
+        public override ObservableCollection<GroupDescription> GroupDescriptions { get; }
+        public override ReadOnlyObservableCollection<object> Groups { get; }
+        protected int InternalCount { get; }
+        protected IList InternalList { get; }
+        public bool IsAddingNew { get; }
+        public bool IsDataInGroupOrder { get; set; }
+        public bool IsEditingItem { get; }
+        public override bool IsEmpty { get; }
+        protected bool IsGrouping { get; }
+        public Nullable<bool> IsLiveFiltering { get; set; }
+        public Nullable<bool> IsLiveGrouping { get; set; }
+        public Nullable<bool> IsLiveSorting { get; set; }
+        public ReadOnlyCollection<ItemPropertyInfo> ItemProperties { get; }
+        public ObservableCollection<string> LiveFilteringProperties { get; }
+        public ObservableCollection<string> LiveGroupingProperties { get; }
+        public ObservableCollection<string> LiveSortingProperties { get; }
+        public NewItemPlaceholderPosition NewItemPlaceholderPosition { get; set; }
+        public override SortDescriptionCollection SortDescriptions { get; }
+        protected bool UsesLocalArray { get; }
+        public object AddNew();
+        public object AddNewItem(object newItem);
+        public void CancelEdit();
+        public void CancelNew();
+        public void CommitEdit();
+        public void CommitNew();
+        protected virtual int Compare(object o1, object o2);
+        public override bool Contains(object item);
+        public void EditItem(object item);
+        protected override IEnumerator GetEnumerator();
+        public override object GetItemAt(int index);
+        public override int IndexOf(object item);
+        protected bool InternalContains(object item);
+        protected IEnumerator InternalGetEnumerator();
+        protected int InternalIndexOf(object item);
+        protected object InternalItemAt(int index);
+        public override bool MoveCurrentToPosition(int position);
+        protected override void OnAllowsCrossThreadChangesChanged();
+        protected override void OnBeginChangeLogging(NotifyCollectionChangedEventArgs args);
+        public override bool PassesFilter(object item);
+        protected override void ProcessCollectionChanged(NotifyCollectionChangedEventArgs args);
+        protected override void RefreshOverride();
+        public void Remove(object item);
+        public void RemoveAt(int index);
+        int System.Collections.IComparer.Compare(object o1, object o2);
+    }
+    public class MultiBinding : BindingBase, IAddChild {
+        public MultiBinding();
+        public Collection<BindingBase> Bindings { get; }
+        public IMultiValueConverter Converter { get; set; }
+        public CultureInfo ConverterCulture { get; set; }
+        public object ConverterParameter { get; set; }
+        public BindingMode Mode { get; set; }
+        public bool NotifyOnSourceUpdated { get; set; }
+        public bool NotifyOnTargetUpdated { get; set; }
+        public bool NotifyOnValidationError { get; set; }
+        public UpdateSourceExceptionFilterCallback UpdateSourceExceptionFilter { get; set; }
+        public UpdateSourceTrigger UpdateSourceTrigger { get; set; }
+        public bool ValidatesOnDataErrors { get; set; }
+        public bool ValidatesOnExceptions { get; set; }
+        public bool ValidatesOnNotifyDataErrors { get; set; }
+        public Collection<ValidationRule> ValidationRules { get; }
+        public bool ShouldSerializeBindings();
+        public bool ShouldSerializeValidationRules();
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public sealed class MultiBindingExpression : BindingExpressionBase, IDataBindEngineClient {
+        public ReadOnlyCollection<BindingExpressionBase> BindingExpressions { get; }
+        public override bool HasError { get; }
+        public override bool HasValidationError { get; }
+        public MultiBinding ParentMultiBinding { get; }
+        public override ValidationError ValidationError { get; }
+        public override void UpdateSource();
+        public override void UpdateTarget();
+    }
+    public class ObjectDataProvider : DataSourceProvider {
+        public ObjectDataProvider();
+        public IList ConstructorParameters { get; }
+        public bool IsAsynchronous { get; set; }
+        public string MethodName { get; set; }
+        public IList MethodParameters { get; }
+        public object ObjectInstance { get; set; }
+        public Type ObjectType { get; set; }
+        protected override void BeginQuery();
+        public bool ShouldSerializeConstructorParameters();
+        public bool ShouldSerializeMethodParameters();
+        public bool ShouldSerializeObjectInstance();
+        public bool ShouldSerializeObjectType();
+    }
+    public class PriorityBinding : BindingBase, IAddChild {
+        public PriorityBinding();
+        public Collection<BindingBase> Bindings { get; }
+        public bool ShouldSerializeBindings();
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public sealed class PriorityBindingExpression : BindingExpressionBase {
+        public BindingExpressionBase ActiveBindingExpression { get; }
+        public ReadOnlyCollection<BindingExpressionBase> BindingExpressions { get; }
+        public override bool HasValidationError { get; }
+        public PriorityBinding ParentPriorityBinding { get; }
+        public override void UpdateSource();
+        public override void UpdateTarget();
+    }
+    public class PropertyGroupDescription : GroupDescription {
+        public PropertyGroupDescription();
+        public PropertyGroupDescription(string propertyName);
+        public PropertyGroupDescription(string propertyName, IValueConverter converter);
+        public PropertyGroupDescription(string propertyName, IValueConverter converter, StringComparison stringComparison);
+        public IValueConverter Converter { get; set; }
+        public string PropertyName { get; set; }
+        public StringComparison StringComparison { get; set; }
+        public override object GroupNameFromItem(object item, int level, CultureInfo culture);
+        public override bool NamesMatch(object groupName, object itemName);
+    }
+    public class RelativeSource : MarkupExtension, ISupportInitialize {
+        public RelativeSource();
+        public RelativeSource(RelativeSourceMode mode);
+        public RelativeSource(RelativeSourceMode mode, Type ancestorType, int ancestorLevel);
+        public int AncestorLevel { get; set; }
+        public Type AncestorType { get; set; }
+        public RelativeSourceMode Mode { get; set; }
+        public static RelativeSource PreviousData { get; }
+        public static RelativeSource Self { get; }
+        public static RelativeSource TemplatedParent { get; }
+        public override object ProvideValue(IServiceProvider serviceProvider);
+        public bool ShouldSerializeAncestorLevel();
+        public bool ShouldSerializeAncestorType();
+        void System.ComponentModel.ISupportInitialize.BeginInit();
+        void System.ComponentModel.ISupportInitialize.EndInit();
+    }
+    public enum RelativeSourceMode {
+        FindAncestor = 3,
+        PreviousData = 0,
+        Self = 2,
+        TemplatedParent = 1,
+    }
+    public delegate object UpdateSourceExceptionFilterCallback(object bindExpression, Exception exception);
+    public enum UpdateSourceTrigger {
+        Default = 0,
+        Explicit = 3,
+        LostFocus = 2,
+        PropertyChanged = 1,
+    }
+    public sealed class ValueConversionAttribute : Attribute {
+        public ValueConversionAttribute(Type sourceType, Type targetType);
+        public Type ParameterType { get; set; }
+        public Type SourceType { get; }
+        public Type TargetType { get; }
+        public override object TypeId { get; }
+        public override int GetHashCode();
+    }
+    public class ValueUnavailableException : SystemException {
+        public ValueUnavailableException();
+        protected ValueUnavailableException(SerializationInfo info, StreamingContext context);
+        public ValueUnavailableException(string message);
+        public ValueUnavailableException(string message, Exception innerException);
+    }
+    public class XmlDataProvider : DataSourceProvider, IUriContext {
+        public XmlDataProvider();
+        protected virtual Uri BaseUri { get; set; }
+        public XmlDocument Document { get; set; }
+        public bool IsAsynchronous { get; set; }
+        public Uri Source { get; set; }
+        Uri System.Windows.Markup.IUriContext.BaseUri { get; set; }
+        public XmlNamespaceManager XmlNamespaceManager { get; set; }
+        public IXmlSerializable XmlSerializer { get; }
+        public string XPath { get; set; }
+        protected override void BeginQuery();
+        protected override void EndInit();
+        public bool ShouldSerializeSource();
+        public bool ShouldSerializeXmlSerializer();
+        public bool ShouldSerializeXPath();
+    }
+    public class XmlNamespaceMapping : ISupportInitialize {
+        public XmlNamespaceMapping();
+        public XmlNamespaceMapping(string prefix, Uri uri);
+        public string Prefix { get; set; }
+        public Uri Uri { get; set; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public static bool operator ==(XmlNamespaceMapping mappingA, XmlNamespaceMapping mappingB);
+        public static bool operator !=(XmlNamespaceMapping mappingA, XmlNamespaceMapping mappingB);
+        void System.ComponentModel.ISupportInitialize.BeginInit();
+        void System.ComponentModel.ISupportInitialize.EndInit();
+    }
+    public class XmlNamespaceMappingCollection : XmlNamespaceManager, IAddChild, IAddChildInternal, ICollection<XmlNamespaceMapping>, IEnumerable, IEnumerable<XmlNamespaceMapping> {
+        public XmlNamespaceMappingCollection();
+        public int Count { get; }
+        public bool IsReadOnly { get; }
+        public void Add(XmlNamespaceMapping mapping);
+        protected virtual void AddChild(object value);
+        protected virtual void AddText(string text);
+        public void Clear();
+        public bool Contains(XmlNamespaceMapping mapping);
+        public void CopyTo(XmlNamespaceMapping[] array, int arrayIndex);
+        public override IEnumerator GetEnumerator();
+        protected IEnumerator<XmlNamespaceMapping> ProtectedGetEnumerator();
+        public bool Remove(XmlNamespaceMapping mapping);
+        IEnumerator<XmlNamespaceMapping> System.Collections.Generic.IEnumerable<System.Windows.Data.XmlNamespaceMapping>.GetEnumerator();
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+}
```

