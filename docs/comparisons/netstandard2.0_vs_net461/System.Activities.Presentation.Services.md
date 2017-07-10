# System.Activities.Presentation.Services

``` diff
+namespace System.Activities.Presentation.Services {
+    public abstract class ModelChangedEventArgs : EventArgs {
+        protected ModelChangedEventArgs();
+        public abstract IEnumerable<ModelItem> ItemsAdded { get; }
+        public abstract IEnumerable<ModelItem> ItemsRemoved { get; }
+        public virtual ModelChangeInfo ModelChangeInfo { get; }
+        public abstract IEnumerable<ModelProperty> PropertiesChanged { get; }
+    }
+    public abstract class ModelChangeInfo {
+        protected ModelChangeInfo();
+        public abstract ModelItem Key { get; }
+        public abstract ModelChangeType ModelChangeType { get; }
+        public abstract ModelItem OldValue { get; }
+        public abstract string PropertyName { get; }
+        public abstract ModelItem Subject { get; }
+        public abstract ModelItem Value { get; }
+    }
+    public enum ModelChangeType {
+        CollectionItemAdded = 2,
+        CollectionItemRemoved = 3,
+        DictionaryKeyValueAdded = 4,
+        DictionaryKeyValueRemoved = 5,
+        DictionaryValueChanged = 6,
+        None = 0,
+        PropertyChanged = 1,
+    }
+    public abstract class ModelSearchService {
+        protected ModelSearchService();
+        public abstract TextImage GenerateTextImage();
+        public abstract bool NavigateTo(int location);
+        public abstract bool NavigateTo(int startLine, int startColumn, int endLine, int endColumn);
+    }
+    public abstract class ModelService {
+        protected ModelService();
+        public abstract ModelItem Root { get; }
+        public abstract event EventHandler<ModelChangedEventArgs> ModelChanged;
+        protected abstract ModelItem CreateItem(object item);
+        protected abstract ModelItem CreateItem(Type itemType, CreateOptions options, params object[] arguments);
+        protected abstract ModelItem CreateStaticMemberItem(Type type, string memberName);
+        public abstract IEnumerable<ModelItem> Find(ModelItem startingItem, Predicate<Type> match);
+        public abstract IEnumerable<ModelItem> Find(ModelItem startingItem, Type type);
+        public ModelItem FromName(ModelItem scope, string name);
+        public abstract ModelItem FromName(ModelItem scope, string name, StringComparison comparison);
+    }
+    public abstract class ViewService {
+        protected ViewService();
+        public abstract ModelItem GetModel(DependencyObject view);
+        public abstract DependencyObject GetView(ModelItem model);
+    }
+}
```

