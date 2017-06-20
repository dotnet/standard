# System.Activities.Presentation.Model

``` diff
+namespace System.Activities.Presentation.Model {
+    public class AttachedPropertiesService {
+        public AttachedPropertiesService();
+        public void AddProperty(AttachedProperty property);
+    }
+    public abstract class AttachedProperty {
+        protected AttachedProperty();
+        public bool IsBrowsable { get; set; }
+        public abstract bool IsReadOnly { get; }
+        public string Name { get; set; }
+        public Type OwnerType { get; set; }
+        public abstract Type Type { get; }
+        public abstract object GetValue(ModelItem modelItem);
+        public void NotifyPropertyChanged(ModelItem modelItem);
+        public abstract void ResetValue(ModelItem modelItem);
+        public abstract void SetValue(ModelItem modelItem, object value);
+    }
+    public class AttachedProperty<T> : AttachedProperty {
+        public AttachedProperty();
+        public Func<ModelItem, T> Getter { get; set; }
+        public override bool IsReadOnly { get; }
+        public Action<ModelItem, T> Setter { get; set; }
+        public override Type Type { get; }
+        public override object GetValue(ModelItem modelItem);
+        public override void ResetValue(ModelItem modelItem);
+        public override void SetValue(ModelItem modelItem, object Value);
+    }
+    public abstract class AttachedPropertyInfo {
+        protected AttachedPropertyInfo();
+        public string PropertyName { get; set; }
+    }
+    public sealed class AttachedPropertyInfo<T> : AttachedPropertyInfo {
+        public AttachedPropertyInfo();
+        public T DefaultValue { get; set; }
+    }
+    public abstract class Change {
+        protected Change();
+        public abstract string Description { get; }
+        public abstract bool Apply();
+        public abstract Change GetInverse();
+    }
+    public enum CreateOptions {
+        InitializeDefaults = 1,
+        None = 0,
+    }
+    public class EditingScope : ModelEditingScope {
+        public List<Change> Changes { get; }
+        public bool HasEffectiveChanges { get; internal set; }
+        protected override bool CanComplete();
+        protected override void OnComplete();
+        protected override bool OnException(Exception e);
+        protected override void OnRevert(bool finalizing);
+    }
+    public class EditingScopeEventArgs : EventArgs {
+        public EditingScopeEventArgs();
+        public EditingScope EditingScope { get; set; }
+    }
+    public abstract class ModelEditingScope : IDisposable {
+        protected ModelEditingScope();
+        public string Description { get; set; }
+        protected abstract bool CanComplete();
+        public void Complete();
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        protected abstract void OnComplete();
+        protected abstract bool OnException(Exception exception);
+        protected abstract void OnRevert(bool finalizing);
+        public void Revert();
+    }
+    public static class ModelFactory {
+        public static ModelItem CreateItem(EditingContext context, object item);
+        public static ModelItem CreateItem(EditingContext context, Type itemType, CreateOptions options, params object[] arguments);
+        public static ModelItem CreateItem(EditingContext context, Type itemType, params object[] arguments);
+        public static ModelItem CreateStaticMemberItem(EditingContext context, Type type, string memberName);
+    }
+    public abstract class ModelItem : INotifyPropertyChanged {
+        protected ModelItem();
+        public abstract AttributeCollection Attributes { get; }
+        public abstract ModelProperty Content { get; }
+        public abstract Type ItemType { get; }
+        public abstract string Name { get; set; }
+        public abstract ModelItem Parent { get; }
+        public abstract IEnumerable<ModelItem> Parents { get; }
+        public abstract ModelPropertyCollection Properties { get; }
+        public abstract ModelItem Root { get; }
+        public abstract ModelProperty Source { get; }
+        public abstract IEnumerable<ModelProperty> Sources { get; }
+        public abstract DependencyObject View { get; }
+        public abstract event PropertyChangedEventHandler PropertyChanged;
+        public abstract ModelEditingScope BeginEdit();
+        public virtual ModelEditingScope BeginEdit(bool shouldApplyChangesImmediately);
+        public abstract ModelEditingScope BeginEdit(string description);
+        public virtual ModelEditingScope BeginEdit(string description, bool shouldApplyChangesImmediately);
+        public abstract object GetCurrentValue();
+        public override string ToString();
+    }
+    public abstract class ModelItemCollection : ModelItem, ICollection, ICollection<ModelItem>, IEnumerable, IEnumerable<ModelItem>, IList, IList<ModelItem>, INotifyCollectionChanged {
+        public static readonly DependencyProperty ItemProperty;
+        protected ModelItemCollection();
+        public abstract int Count { get; }
+        protected virtual bool IsFixedSize { get; }
+        public abstract bool IsReadOnly { get; }
+        protected virtual bool IsSynchronized { get; }
+        protected virtual object SyncRoot { get; }
+        int System.Collections.ICollection.Count { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public abstract ModelItem this[int index] { get; set; }
+        public abstract event NotifyCollectionChangedEventHandler CollectionChanged;
+        public abstract void Add(ModelItem item);
+        public abstract ModelItem Add(object value);
+        public abstract void Clear();
+        public abstract bool Contains(ModelItem item);
+        public abstract bool Contains(object value);
+        public abstract void CopyTo(ModelItem[] array, int arrayIndex);
+        public abstract IEnumerator<ModelItem> GetEnumerator();
+        public abstract int IndexOf(ModelItem item);
+        public abstract void Insert(int index, ModelItem item);
+        public abstract ModelItem Insert(int index, object value);
+        public abstract void Move(int fromIndex, int toIndex);
+        public abstract bool Remove(ModelItem item);
+        public abstract bool Remove(object value);
+        public abstract void RemoveAt(int index);
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
+    public abstract class ModelItemDictionary : ModelItem, ICollection, ICollection<KeyValuePair<ModelItem, ModelItem>>, IDictionary, IDictionary<ModelItem, ModelItem>, IEnumerable, IEnumerable<KeyValuePair<ModelItem, ModelItem>>, INotifyCollectionChanged {
+        public static readonly DependencyProperty KeyProperty;
+        protected ModelItemDictionary();
+        public abstract int Count { get; }
+        protected virtual bool IsFixedSize { get; }
+        public abstract bool IsReadOnly { get; }
+        protected virtual bool IsSynchronized { get; }
+        public abstract ICollection<ModelItem> Keys { get; }
+        protected virtual object SyncRoot { get; }
+        int System.Collections.ICollection.Count { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IDictionary.IsFixedSize { get; }
+        bool System.Collections.IDictionary.IsReadOnly { get; }
+        object System.Collections.IDictionary.this[object key] { get; set; }
+        ICollection System.Collections.IDictionary.Keys { get; }
+        ICollection System.Collections.IDictionary.Values { get; }
+        public abstract ModelItem this[ModelItem key] { get; set; }
+        public abstract ModelItem this[object key] { get; set; }
+        public abstract ICollection<ModelItem> Values { get; }
+        public abstract event NotifyCollectionChangedEventHandler CollectionChanged;
+        public abstract void Add(ModelItem key, ModelItem value);
+        public abstract ModelItem Add(object key, object value);
+        public abstract void Clear();
+        protected virtual bool Contains(KeyValuePair<ModelItem, ModelItem> item);
+        public abstract bool ContainsKey(ModelItem key);
+        public abstract bool ContainsKey(object key);
+        protected virtual void CopyTo(KeyValuePair<ModelItem, ModelItem>[] array, int arrayIndex);
+        public abstract IEnumerator<KeyValuePair<ModelItem, ModelItem>> GetEnumerator();
+        public abstract bool Remove(ModelItem key);
+        public abstract bool Remove(object key);
+        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.Activities.Presentation.Model.ModelItem,System.Activities.Presentation.Model.ModelItem>>.Add(KeyValuePair<ModelItem, ModelItem> item);
+        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.Activities.Presentation.Model.ModelItem,System.Activities.Presentation.Model.ModelItem>>.Contains(KeyValuePair<ModelItem, ModelItem> item);
+        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.Activities.Presentation.Model.ModelItem,System.Activities.Presentation.Model.ModelItem>>.CopyTo(KeyValuePair<ModelItem, ModelItem>[] array, int arrayIndex);
+        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.Activities.Presentation.Model.ModelItem,System.Activities.Presentation.Model.ModelItem>>.Remove(KeyValuePair<ModelItem, ModelItem> item);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        void System.Collections.IDictionary.Add(object key, object value);
+        void System.Collections.IDictionary.Clear();
+        bool System.Collections.IDictionary.Contains(object key);
+        IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator();
+        void System.Collections.IDictionary.Remove(object key);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        public abstract bool TryGetValue(ModelItem key, out ModelItem value);
+        public abstract bool TryGetValue(object key, out ModelItem value);
+    }
+    public static class ModelItemExtensions {
+        public static void Focus(this ModelItem item);
+        public static void Focus(this ModelItem item, int level);
+        public static EditingContext GetEditingContext(this ModelItem modelItem);
+        public static ModelItem GetModelItemFromPath(string path, ModelItem root);
+        public static string GetModelPath(this ModelItem modelItem);
+        public static bool IsParentOf(this ModelItem item, ModelItem child);
+    }
+    public abstract class ModelMemberCollection<TItemType, TFindType> : IEnumerable, IEnumerable<TItemType> {
+        public TItemType this[string name] { get; }
+        public TItemType this[TFindType value] { get; }
+        public TItemType Find(string name);
+        protected abstract TItemType Find(string name, bool throwOnError);
+        public TItemType Find(TFindType value);
+        protected abstract TItemType Find(TFindType value, bool throwOnError);
+        public abstract IEnumerator<TItemType> GetEnumerator();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+    }
+    public abstract class ModelProperty {
+        protected ModelProperty();
+        public abstract Type AttachedOwnerType { get; }
+        public abstract AttributeCollection Attributes { get; }
+        public abstract ModelItemCollection Collection { get; }
+        public abstract object ComputedValue { get; set; }
+        public abstract TypeConverter Converter { get; }
+        public abstract object DefaultValue { get; }
+        public abstract ModelItemDictionary Dictionary { get; }
+        public abstract bool IsAttached { get; }
+        public abstract bool IsBrowsable { get; }
+        public abstract bool IsCollection { get; }
+        public abstract bool IsDictionary { get; }
+        public abstract bool IsReadOnly { get; }
+        public abstract bool IsSet { get; }
+        public abstract string Name { get; }
+        public abstract ModelItem Parent { get; }
+        public abstract Type PropertyType { get; }
+        public abstract ModelItem Value { get; }
+        public abstract void ClearValue();
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public static bool operator ==(ModelProperty first, ModelProperty second);
+        public static bool operator !=(ModelProperty first, ModelProperty second);
+        public abstract ModelItem SetValue(object value);
+    }
+    public abstract class ModelPropertyCollection : ModelMemberCollection<ModelProperty, DependencyProperty> {
+        protected ModelPropertyCollection();
+    }
+    public class ModelTreeManager {
+        public ModelTreeManager(EditingContext context);
+        public ModelItem Root { get; }
+        public event EventHandler<EditingScopeEventArgs> EditingScopeCompleted;
+        public ModelItem CreateModelItem(ModelItem parent, object instance);
+        public ModelItem GetModelItem(object instance, bool shouldExpandModelTree);
+        public void Load(object rootInstance);
+    }
+    public static class MorphHelper {
+        public static void AddPropertyValueMorphHelper(Type propertyType, PropertyValueMorphHelper extension);
+        public static PropertyValueMorphHelper GetPropertyValueMorphHelper(Type propertyType);
+        public static void MorphObject(ModelItem oldModelItem, ModelItem newModelitem);
+        public static void MorphProperties(ModelItem oldModelItem, ModelItem newModelitem);
+    }
+    public delegate object PropertyValueMorphHelper(ModelItem originalValue, ModelProperty newModelProperty);
+    public sealed class TextImage {
+        public TextImage();
+        public IList<string> Lines { get; internal set; }
+        public int StartLineIndex { get; set; }
+    }
+}
```

