# System.ComponentModel

``` diff
 namespace System.ComponentModel {
     public class AsyncCompletedEventArgs : EventArgs {
+        public AsyncCompletedEventArgs();
     }
     public sealed class AsyncOperation {
+        ~AsyncOperation();
     }
+    public class CurrentChangedEventManager : WeakEventManager {
+        public static void AddHandler(ICollectionView source, EventHandler<EventArgs> handler);
+        public static void AddListener(ICollectionView source, IWeakEventListener listener);
+        protected override WeakEventManager.ListenerList NewListenerList();
+        public static void RemoveHandler(ICollectionView source, EventHandler<EventArgs> handler);
+        public static void RemoveListener(ICollectionView source, IWeakEventListener listener);
+        protected override void StartListening(object source);
+        protected override void StopListening(object source);
+    }
+    public class CurrentChangingEventArgs : EventArgs {
+        public CurrentChangingEventArgs();
+        public CurrentChangingEventArgs(bool isCancelable);
+        public bool Cancel { get; set; }
+        public bool IsCancelable { get; }
+    }
+    public delegate void CurrentChangingEventHandler(object sender, CurrentChangingEventArgs e);
+    public class CurrentChangingEventManager : WeakEventManager {
+        public static void AddHandler(ICollectionView source, EventHandler<CurrentChangingEventArgs> handler);
+        public static void AddListener(ICollectionView source, IWeakEventListener listener);
+        protected override WeakEventManager.ListenerList NewListenerList();
+        public static void RemoveHandler(ICollectionView source, EventHandler<CurrentChangingEventArgs> handler);
+        public static void RemoveListener(ICollectionView source, IWeakEventListener listener);
+        protected override void StartListening(object source);
+        protected override void StopListening(object source);
+    }
+    public sealed class DependencyPropertyDescriptor : PropertyDescriptor {
+        public override AttributeCollection Attributes { get; }
+        public override string Category { get; }
+        public override Type ComponentType { get; }
+        public override TypeConverter Converter { get; }
+        public DependencyProperty DependencyProperty { get; }
+        public override string Description { get; }
+        public CoerceValueCallback DesignerCoerceValueCallback { get; set; }
+        public override bool DesignTimeOnly { get; }
+        public override string DisplayName { get; }
+        public bool IsAttached { get; }
+        public override bool IsBrowsable { get; }
+        public override bool IsLocalizable { get; }
+        public override bool IsReadOnly { get; }
+        public PropertyMetadata Metadata { get; }
+        public override Type PropertyType { get; }
+        public override bool SupportsChangeEvents { get; }
+        public override void AddValueChanged(object component, EventHandler handler);
+        public override bool CanResetValue(object component);
+        public override bool Equals(object obj);
+        public static DependencyPropertyDescriptor FromName(string name, Type ownerType, Type targetType);
+        public static DependencyPropertyDescriptor FromName(string name, Type ownerType, Type targetType, bool ignorePropertyType);
+        public static DependencyPropertyDescriptor FromProperty(PropertyDescriptor property);
+        public static DependencyPropertyDescriptor FromProperty(DependencyProperty dependencyProperty, Type targetType);
+        public override PropertyDescriptorCollection GetChildProperties(object instance, Attribute[] filter);
+        public override object GetEditor(Type editorBaseType);
+        public override int GetHashCode();
+        public override object GetValue(object component);
+        public override void RemoveValueChanged(object component, EventHandler handler);
+        public override void ResetValue(object component);
+        public override void SetValue(object component, object value);
+        public override bool ShouldSerializeValue(object component);
+        public override string ToString();
+    }
+    public static class DesignerProperties {
+        public static readonly DependencyProperty IsInDesignModeProperty;
+        public static bool GetIsInDesignMode(DependencyObject element);
+        public static void SetIsInDesignMode(DependencyObject element, bool value);
+    }
+    public class ErrorsChangedEventManager : WeakEventManager {
+        public static void AddHandler(INotifyDataErrorInfo source, EventHandler<DataErrorsChangedEventArgs> handler);
+        protected override WeakEventManager.ListenerList NewListenerList();
+        public static void RemoveHandler(INotifyDataErrorInfo source, EventHandler<DataErrorsChangedEventArgs> handler);
+        protected override void StartListening(object source);
+        protected override void StopListening(object source);
+    }
+    public abstract class GroupDescription : INotifyPropertyChanged {
+        protected GroupDescription();
+        public ObservableCollection<object> GroupNames { get; }
+        protected virtual event PropertyChangedEventHandler PropertyChanged;
+        event PropertyChangedEventHandler System.ComponentModel.INotifyPropertyChanged.PropertyChanged;
+        public abstract object GroupNameFromItem(object item, int level, CultureInfo culture);
+        public virtual bool NamesMatch(object groupName, object itemName);
+        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e);
+        public bool ShouldSerializeGroupNames();
+    }
+    public interface ICollectionView : IEnumerable, INotifyCollectionChanged {
+        bool CanFilter { get; }
+        bool CanGroup { get; }
+        bool CanSort { get; }
+        CultureInfo Culture { get; set; }
+        object CurrentItem { get; }
+        int CurrentPosition { get; }
+        Predicate<object> Filter { get; set; }
+        ObservableCollection<GroupDescription> GroupDescriptions { get; }
+        ReadOnlyObservableCollection<object> Groups { get; }
+        bool IsCurrentAfterLast { get; }
+        bool IsCurrentBeforeFirst { get; }
+        bool IsEmpty { get; }
+        SortDescriptionCollection SortDescriptions { get; }
+        IEnumerable SourceCollection { get; }
+        event EventHandler CurrentChanged;
+        event CurrentChangingEventHandler CurrentChanging;
+        bool Contains(object item);
+        IDisposable DeferRefresh();
+        bool MoveCurrentTo(object item);
+        bool MoveCurrentToFirst();
+        bool MoveCurrentToLast();
+        bool MoveCurrentToNext();
+        bool MoveCurrentToPosition(int position);
+        bool MoveCurrentToPrevious();
+        void Refresh();
+    }
+    public interface ICollectionViewFactory {
+        ICollectionView CreateView();
+    }
+    public interface ICollectionViewLiveShaping {
+        bool CanChangeLiveFiltering { get; }
+        bool CanChangeLiveGrouping { get; }
+        bool CanChangeLiveSorting { get; }
+        Nullable<bool> IsLiveFiltering { get; set; }
+        Nullable<bool> IsLiveGrouping { get; set; }
+        Nullable<bool> IsLiveSorting { get; set; }
+        ObservableCollection<string> LiveFilteringProperties { get; }
+        ObservableCollection<string> LiveGroupingProperties { get; }
+        ObservableCollection<string> LiveSortingProperties { get; }
+    }
+    public interface IEditableCollectionView {
+        bool CanAddNew { get; }
+        bool CanCancelEdit { get; }
+        bool CanRemove { get; }
+        object CurrentAddItem { get; }
+        object CurrentEditItem { get; }
+        bool IsAddingNew { get; }
+        bool IsEditingItem { get; }
+        NewItemPlaceholderPosition NewItemPlaceholderPosition { get; set; }
+        object AddNew();
+        void CancelEdit();
+        void CancelNew();
+        void CommitEdit();
+        void CommitNew();
+        void EditItem(object item);
+        void Remove(object item);
+        void RemoveAt(int index);
+    }
+    public interface IEditableCollectionViewAddNewItem : IEditableCollectionView {
+        bool CanAddNewItem { get; }
+        object AddNewItem(object newItem);
+    }
+    public interface IItemProperties {
+        ReadOnlyCollection<ItemPropertyInfo> ItemProperties { get; }
+    }
+    public class ItemPropertyInfo {
+        public ItemPropertyInfo(string name, Type type, object descriptor);
+        public object Descriptor { get; }
+        public string Name { get; }
+        public Type PropertyType { get; }
+    }
+    public enum NewItemPlaceholderPosition {
+        AtBeginning = 1,
+        AtEnd = 2,
+        None = 0,
+    }
+    public class PropertyChangedEventManager : WeakEventManager {
+        public static void AddHandler(INotifyPropertyChanged source, EventHandler<PropertyChangedEventArgs> handler, string propertyName);
+        public static void AddListener(INotifyPropertyChanged source, IWeakEventListener listener, string propertyName);
+        protected override WeakEventManager.ListenerList NewListenerList();
+        protected override bool Purge(object source, object data, bool purgeAll);
+        public static void RemoveHandler(INotifyPropertyChanged source, EventHandler<PropertyChangedEventArgs> handler, string propertyName);
+        public static void RemoveListener(INotifyPropertyChanged source, IWeakEventListener listener, string propertyName);
+        protected override void StartListening(object source);
+        protected override void StopListening(object source);
+    }
+    public sealed class PropertyFilterAttribute : Attribute {
+        public static readonly PropertyFilterAttribute Default;
+        public PropertyFilterAttribute(PropertyFilterOptions filter);
+        public PropertyFilterOptions Filter { get; }
+        public override bool Equals(object value);
+        public override int GetHashCode();
+        public override bool Match(object value);
+    }
+    public enum PropertyFilterOptions {
+        All = 15,
+        Invalid = 1,
+        None = 0,
+        SetValues = 2,
+        UnsetValues = 4,
+        Valid = 8,
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct SortDescription {
+        public SortDescription(string propertyName, ListSortDirection direction);
+        public ListSortDirection Direction { get; set; }
+        public bool IsSealed { get; }
+        public string PropertyName { get; set; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public static bool operator ==(SortDescription sd1, SortDescription sd2);
+        public static bool operator !=(SortDescription sd1, SortDescription sd2);
+    }
+    public class SortDescriptionCollection : Collection<SortDescription>, INotifyCollectionChanged {
+        public static readonly SortDescriptionCollection Empty;
+        public SortDescriptionCollection();
+        protected event NotifyCollectionChangedEventHandler CollectionChanged;
+        event NotifyCollectionChangedEventHandler System.Collections.Specialized.INotifyCollectionChanged.CollectionChanged;
+        protected override void ClearItems();
+        protected override void InsertItem(int index, SortDescription item);
+        protected override void RemoveItem(int index);
+        protected override void SetItem(int index, SortDescription item);
+    }
 }
```

