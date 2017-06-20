# System.Activities.Presentation.PropertyEditing

``` diff
+namespace System.Activities.Presentation.PropertyEditing {
+    public abstract class CategoryEditor {
+        protected CategoryEditor();
+        public abstract DataTemplate EditorTemplate { get; }
+        public abstract string TargetCategory { get; }
+        public abstract bool ConsumesProperty(PropertyEntry propertyEntry);
+        public static EditorAttribute CreateEditorAttribute(CategoryEditor editor);
+        public static EditorAttribute CreateEditorAttribute(Type categoryEditorType);
+        public abstract object GetImage(Size desiredSize);
+    }
+    public abstract class CategoryEntry : INotifyPropertyChanged, IPropertyFilterTarget {
+        protected CategoryEntry(string name);
+        public string CategoryName { get; }
+        public virtual bool MatchesFilter { get; protected set; }
+        public abstract IEnumerable<PropertyEntry> Properties { get; }
+        public abstract PropertyEntry this[string propertyName] { get; }
+        public event EventHandler<PropertyFilterAppliedEventArgs> FilterApplied;
+        public event PropertyChangedEventHandler PropertyChanged;
+        public virtual void ApplyFilter(PropertyFilter filter);
+        public abstract bool MatchesPredicate(PropertyFilterPredicate predicate);
+        protected virtual void OnFilterApplied(PropertyFilter filter);
+        protected virtual void OnPropertyChanged(string propertyName);
+    }
+    public class DependencyPropertyValueSource : PropertyValueSource {
+        public static DependencyPropertyValueSource CustomMarkupExtension { get; }
+        public static DependencyPropertyValueSource DataBound { get; }
+        public static DependencyPropertyValueSource DefaultValue { get; }
+        public static DependencyPropertyValueSource Inherited { get; }
+        public bool IsCustomMarkupExtension { get; }
+        public bool IsDataBound { get; }
+        public bool IsDefaultValue { get; }
+        public bool IsExpression { get; }
+        public bool IsInherited { get; }
+        public bool IsLocal { get; }
+        public bool IsLocalResource { get; }
+        public bool IsResource { get; }
+        public bool IsSystemResource { get; }
+        public bool IsTemplateBinding { get; }
+        public static DependencyPropertyValueSource Local { get; }
+        public static DependencyPropertyValueSource LocalDynamicResource { get; }
+        public static DependencyPropertyValueSource LocalStaticResource { get; }
+        public static DependencyPropertyValueSource SystemResource { get; }
+        public static DependencyPropertyValueSource TemplateBinding { get; }
+    }
+    public class DialogPropertyValueEditor : PropertyValueEditor {
+        public DialogPropertyValueEditor();
+        public DialogPropertyValueEditor(DataTemplate dialogEditorTemplate, DataTemplate inlineEditorTemplate);
+        public DataTemplate DialogEditorTemplate { get; set; }
+        public virtual void ShowDialog(PropertyValue propertyValue, IInputElement commandSource);
+    }
+    public class EditModeSwitchButton : Button {
+        public static readonly DependencyProperty SyncModeToOwningContainerProperty;
+        public static readonly DependencyProperty TargetEditModeProperty;
+        public EditModeSwitchButton();
+        public bool SyncModeToOwningContainer { get; set; }
+        public PropertyContainerEditMode TargetEditMode { get; set; }
+        protected override void OnMouseDown(MouseButtonEventArgs e);
+        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e);
+    }
+    public sealed class EditorOptionAttribute : Attribute {
+        public EditorOptionAttribute();
+        public string Name { get; set; }
+        public override object TypeId { get; }
+        public object Value { get; set; }
+        public static bool TryGetOptionValue(IEnumerable attributes, string optionName, out object optionValue);
+    }
+    public sealed class EditorReuseAttribute : Attribute {
+        public EditorReuseAttribute(bool reuseEditor);
+        public bool ReuseEditor { get; }
+    }
+    public class ExtendedPropertyValueEditor : PropertyValueEditor {
+        public ExtendedPropertyValueEditor();
+        public ExtendedPropertyValueEditor(DataTemplate extendedEditorTemplate, DataTemplate inlineEditorTemplate);
+        public DataTemplate ExtendedEditorTemplate { get; set; }
+    }
+    public interface IPropertyFilterTarget {
+        bool MatchesFilter { get; }
+        event EventHandler<PropertyFilterAppliedEventArgs> FilterApplied;
+        void ApplyFilter(PropertyFilter filter);
+        bool MatchesPredicate(PropertyFilterPredicate predicate);
+    }
+    public enum PropertyContainerEditMode {
+        Dialog = 3,
+        ExtendedPinned = 2,
+        ExtendedPopup = 1,
+        Inline = 0,
+    }
+    public abstract class PropertyEntry : INotifyPropertyChanged, IPropertyFilterTarget {
+        protected PropertyEntry();
+        protected PropertyEntry(PropertyValue parentValue);
+        public abstract string CategoryName { get; }
+        public abstract string Description { get; }
+        public virtual string DisplayName { get; }
+        protected virtual bool HasStandardValues { get; }
+        public abstract bool IsAdvanced { get; }
+        public abstract bool IsReadOnly { get; }
+        public bool MatchesFilter { get; protected set; }
+        public PropertyValue ParentValue { get; }
+        public abstract string PropertyName { get; }
+        public abstract Type PropertyType { get; }
+        public PropertyValue PropertyValue { get; }
+        public abstract PropertyValueEditor PropertyValueEditor { get; }
+        public abstract ICollection StandardValues { get; }
+        public event EventHandler<PropertyFilterAppliedEventArgs> FilterApplied;
+        public event PropertyChangedEventHandler PropertyChanged;
+        public virtual void ApplyFilter(PropertyFilter filter);
+        protected abstract PropertyValue CreatePropertyValueInstance();
+        public virtual bool MatchesPredicate(PropertyFilterPredicate predicate);
+        protected virtual void OnFilterApplied(PropertyFilter filter);
+        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e);
+        protected virtual void OnPropertyChanged(string propertyName);
+    }
+    public abstract class PropertyEntryCollection : IEnumerable, IEnumerable<PropertyEntry> {
+        protected PropertyEntryCollection(PropertyValue parentValue);
+        public abstract int Count { get; }
+        public PropertyValue ParentValue { get; }
+        public abstract PropertyEntry this[string propertyName] { get; }
+        public abstract IEnumerator<PropertyEntry> GetEnumerator();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+    }
+    public class PropertyFilter {
+        public PropertyFilter(IEnumerable<PropertyFilterPredicate> predicates);
+        public PropertyFilter(string filterText);
+        public bool IsEmpty { get; }
+        public bool Match(IPropertyFilterTarget target);
+    }
+    public class PropertyFilterAppliedEventArgs : EventArgs {
+        public PropertyFilterAppliedEventArgs(PropertyFilter filter);
+        public PropertyFilter Filter { get; }
+    }
+    public class PropertyFilterPredicate {
+        public PropertyFilterPredicate(string matchText);
+        protected string MatchText { get; }
+        public virtual bool Match(string target);
+    }
+    public abstract class PropertyValue : INotifyPropertyChanged {
+        protected PropertyValue(PropertyEntry parentProperty);
+        public abstract bool CanConvertFromString { get; }
+        protected virtual bool CatchExceptions { get; }
+        public abstract PropertyValueCollection Collection { get; }
+        public abstract bool HasSubProperties { get; }
+        public abstract bool IsCollection { get; }
+        public abstract bool IsDefaultValue { get; }
+        public abstract bool IsMixedValue { get; }
+        public PropertyEntry ParentProperty { get; }
+        public abstract PropertyValueSource Source { get; }
+        public string StringValue { get; set; }
+        public abstract PropertyEntryCollection SubProperties { get; }
+        public object Value { get; set; }
+        public event PropertyChangedEventHandler PropertyChanged;
+        public event EventHandler<PropertyValueExceptionEventArgs> PropertyValueException;
+        public event EventHandler RootValueChanged;
+        public event EventHandler SubPropertyChanged;
+        public abstract void ClearValue();
+        protected abstract object ConvertStringToValue(string value);
+        protected abstract string ConvertValueToString(object value);
+        protected abstract object GetValueCore();
+        protected virtual void NotifyRootValueChanged();
+        protected void NotifySubPropertyChanged();
+        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e);
+        protected virtual void OnPropertyChanged(string propertyName);
+        protected virtual void OnPropertyValueException(PropertyValueExceptionEventArgs e);
+        protected abstract void SetValueCore(object value);
+        protected abstract void ValidateValue(object valueToValidate);
+    }
+    public abstract class PropertyValueCollection : IEnumerable, IEnumerable<PropertyValue>, INotifyCollectionChanged {
+        protected PropertyValueCollection(PropertyValue parentValue);
+        public abstract int Count { get; }
+        public PropertyValue ParentValue { get; }
+        public abstract PropertyValue this[int index] { get; }
+        public event NotifyCollectionChangedEventHandler CollectionChanged;
+        public abstract PropertyValue Add(object value);
+        public abstract IEnumerator<PropertyValue> GetEnumerator();
+        public abstract PropertyValue Insert(object value, int index);
+        protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e);
+        public abstract bool Remove(PropertyValue propertyValue);
+        public abstract void RemoveAt(int index);
+        public abstract void SetIndex(int currentIndex, int newIndex);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+    }
+    public class PropertyValueEditor {
+        public PropertyValueEditor();
+        public PropertyValueEditor(DataTemplate inlineEditorTemplate);
+        public DataTemplate InlineEditorTemplate { get; set; }
+        public static EditorAttribute CreateEditorAttribute(PropertyValueEditor editor);
+        public static EditorAttribute CreateEditorAttribute(Type propertyValueEditorType);
+    }
+    public static class PropertyValueEditorCommands {
+        public static RoutedCommand AbortTransaction { get; }
+        public static RoutedCommand BeginTransaction { get; }
+        public static RoutedCommand CommitTransaction { get; }
+        public static RoutedCommand FinishEditing { get; }
+        public static RoutedCommand ShowDialogEditor { get; }
+        public static RoutedCommand ShowExtendedPinnedEditor { get; }
+        public static RoutedCommand ShowExtendedPopupEditor { get; }
+        public static RoutedCommand ShowInlineEditor { get; }
+    }
+    public class PropertyValueExceptionEventArgs : EventArgs {
+        public PropertyValueExceptionEventArgs(string message, PropertyValue value, PropertyValueExceptionSource source, Exception exception);
+        public Exception Exception { get; }
+        public string Message { get; }
+        public PropertyValue PropertyValue { get; }
+        public PropertyValueExceptionSource Source { get; }
+    }
+    public enum PropertyValueExceptionSource {
+        Get = 0,
+        Set = 1,
+    }
+    public abstract class PropertyValueSource {
+        protected PropertyValueSource();
+    }
+}
```

