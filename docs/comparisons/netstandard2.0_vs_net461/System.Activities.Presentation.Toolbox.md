# System.Activities.Presentation.Toolbox

``` diff
+namespace System.Activities.Presentation.Toolbox {
+    public abstract class ActivityTemplateFactory : IActivityTemplateFactory {
+        protected ActivityTemplateFactory();
+        protected virtual Func<Activity> Implementation { get; set; }
+        public Activity Create(DependencyObject target);
+    }
+    public abstract class ActivityTemplateFactory<T> : IActivityTemplateFactory<T> where T : class {
+        protected ActivityTemplateFactory();
+        protected virtual Func<T> Implementation { get; set; }
+        public T Create(DependencyObject target, IDataObject dataObject);
+    }
+    public sealed class ActivityTemplateFactoryBuilder {
+        public ActivityTemplateFactoryBuilder();
+        public object Implementation { get; set; }
+        public string Name { get; set; }
+        public Type TargetType { get; set; }
+    }
+    public sealed class ToolboxCategory : ICollection, IEnumerable, IList, INotifyPropertyChanged {
+        public ToolboxCategory();
+        public ToolboxCategory(string name);
+        public string CategoryName { get; set; }
+        int System.Collections.ICollection.Count { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public ToolboxItemWrapper this[int index] { get; }
+        public ICollection<ToolboxItemWrapper> Tools { get; }
+        public event PropertyChangedEventHandler PropertyChanged;
+        public void Add(ToolboxItemWrapper tool);
+        public bool Remove(ToolboxItemWrapper tool);
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
+    public sealed class ToolboxCategoryItems : ICollection, ICollection<ToolboxCategory>, IEnumerable, IEnumerable<ToolboxCategory>, IList {
+        public ToolboxCategoryItems();
+        public int Count { get; }
+        public bool IsReadOnly { get; }
+        int System.Collections.ICollection.Count { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public ToolboxCategory this[int index] { get; }
+        public void Add(ToolboxCategory item);
+        public void Clear();
+        public bool Contains(ToolboxCategory item);
+        public void CopyTo(ToolboxCategory[] array, int arrayIndex);
+        public IEnumerator<ToolboxCategory> GetEnumerator();
+        public bool Remove(ToolboxCategory item);
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
+    public sealed class ToolboxControl : Control {
+        public static readonly DependencyProperty CategoryItemStyleProperty;
+        public static readonly DependencyProperty CategoryTemplateProperty;
+        public static readonly DependencyProperty SelectedToolProperty;
+        public static readonly DependencyProperty ToolboxFileProperty;
+        public static readonly DependencyProperty ToolItemStyleProperty;
+        public static readonly DependencyProperty ToolTemplateProperty;
+        public static readonly RoutedEvent ToolCreatedEvent;
+        public static readonly RoutedEvent ToolSelectedEvent;
+        public ToolboxControl();
+        public WorkflowDesigner AssociatedDesigner { get; set; }
+        public ToolboxCategoryItems Categories { get; set; }
+        public Style CategoryItemStyle { get; set; }
+        public DataTemplate CategoryTemplate { get; set; }
+        public ToolboxItem SelectedTool { get; private set; }
+        public string ToolboxFile { get; set; }
+        public Style ToolItemStyle { get; set; }
+        public DataTemplate ToolTemplate { get; set; }
+        public event ToolCreatedEventHandler ToolCreated;
+        public event RoutedEventHandler ToolSelected;
+        public override void OnApplyTemplate();
+        protected override void OnPreviewKeyDown(KeyEventArgs e);
+    }
+    public sealed class ToolboxItemWrapper : INotifyPropertyChanged {
+        public ToolboxItemWrapper();
+        public ToolboxItemWrapper(string toolName, string assemblyName, string bitmapName, string displayName);
+        public ToolboxItemWrapper(Type toolType);
+        public ToolboxItemWrapper(Type toolType, string displayName);
+        public ToolboxItemWrapper(Type toolType, string bitmapName, string displayName);
+        public string AssemblyName { get; set; }
+        public Bitmap Bitmap { get; }
+        public string BitmapName { get; set; }
+        public string DisplayName { get; set; }
+        public bool IsValid { get; }
+        public string ToolName { get; set; }
+        public Type Type { get; private set; }
+        public event PropertyChangedEventHandler PropertyChanged;
+        public override string ToString();
+    }
+    public sealed class ToolCreatedEventArgs : RoutedEventArgs {
+        public IComponent[] Components { get; }
+    }
+    public delegate void ToolCreatedEventHandler(object sender, ToolCreatedEventArgs e);
+}
```

