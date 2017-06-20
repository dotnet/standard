# System.Web.UI.Design

``` diff
+namespace System.Web.UI.Design {
+    public class AppSettingsExpressionEditor : ExpressionEditor {
+        public AppSettingsExpressionEditor();
+        public override object EvaluateExpression(string expression, object parseTimeData, Type propertyType, IServiceProvider serviceProvider);
+        public override ExpressionEditorSheet GetExpressionEditorSheet(string expression, IServiceProvider serviceProvider);
+    }
+    public class AsyncPostBackTriggerControlIDConverter : StringConverter {
+        public AsyncPostBackTriggerControlIDConverter();
+        public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context);
+        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context);
+        public override bool GetStandardValuesSupported(ITypeDescriptorContext context);
+    }
+    public class AsyncPostBackTriggerEventNameConverter : StringConverter {
+        public AsyncPostBackTriggerEventNameConverter();
+        public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context);
+        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context);
+        public override bool GetStandardValuesSupported(ITypeDescriptorContext context);
+    }
+    public class CalendarDataBindingHandler : DataBindingHandler {
+        public CalendarDataBindingHandler();
+        public override void DataBindControl(IDesignerHost designerHost, Control control);
+    }
+    public sealed class ClientScriptItem {
+        public ClientScriptItem(string text, string source, string language, string type, string id);
+        public string Id { get; }
+        public string Language { get; }
+        public string Source { get; }
+        public string Text { get; }
+        public string Type { get; }
+    }
+    public sealed class ClientScriptItemCollection : ReadOnlyCollectionBase {
+        public ClientScriptItemCollection(ClientScriptItem[] clientScriptItems);
+    }
+    public class CollectionEditorBase : CollectionEditor {
+        public CollectionEditorBase(Type type);
+        protected override CollectionEditor.CollectionForm CreateCollectionForm();
+    }
+    public sealed class ColorBuilder {
+        public static string BuildColor(IComponent component, Control owner, string initialColor);
+    }
+    public class ConnectionStringEditor : UITypeEditor {
+        public ConnectionStringEditor();
+        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value);
+        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context);
+        protected virtual string GetProviderName(object instance);
+        protected virtual void SetProviderName(object instance, DesignerDataConnection connection);
+    }
+    public class ConnectionStringsExpressionEditor : ExpressionEditor {
+        public ConnectionStringsExpressionEditor();
+        public override object EvaluateExpression(string expression, object parseTimeData, Type propertyType, IServiceProvider serviceProvider);
+        public override ExpressionEditorSheet GetExpressionEditorSheet(string expression, IServiceProvider serviceProvider);
+    }
+    public class ContainerControlDesigner : ControlDesigner {
+        public ContainerControlDesigner();
+        public override bool AllowResize { get; }
+        public virtual string FrameCaption { get; }
+        public virtual Style FrameStyle { get; }
+        protected virtual bool NoWrap { get; }
+        protected virtual void AddDesignTimeCssAttributes(IDictionary styleAttributes);
+        public virtual IDictionary GetDesignTimeCssAttributes();
+        public override string GetDesignTimeHtml(DesignerRegionCollection regions);
+        public override string GetEditableDesignerRegionContent(EditableDesignerRegion region);
+        public override string GetPersistenceContent();
+        public override void SetEditableDesignerRegionContent(EditableDesignerRegion region, string content);
+    }
+    public class ContentDefinition {
+        public ContentDefinition(string id, string content, string designTimeHtml);
+        public string ContentPlaceHolderID { get; }
+        public string DefaultContent { get; }
+        public string DefaultDesignTimeHtml { get; }
+    }
+    public enum ContentDesignerState {
+        ShowDefaultContent = 0,
+        ShowUserContent = 1,
+    }
+    public class ControlDesigner : HtmlControlDesigner {
+        public ControlDesigner();
+        public override DesignerActionListCollection ActionLists { get; }
+        public virtual bool AllowResize { get; }
+        public virtual DesignerAutoFormatCollection AutoFormats { get; }
+        protected virtual bool DataBindingsEnabled { get; }
+        protected ControlDesignerState DesignerState { get; }
+        protected object DesignTimeElementView { get; }
+        public virtual bool DesignTimeHtmlRequiresLoadComplete { get; }
+        protected internal virtual bool HidePropertiesInTemplateMode { get; }
+        public virtual string ID { get; set; }
+        protected bool InTemplateMode { get; }
+        public bool IsDirty { get; set; }
+        public bool ReadOnly { get; set; }
+        protected WebFormsRootDesigner RootDesigner { get; }
+        protected IControlDesignerTag Tag { get; }
+        public virtual TemplateGroupCollection TemplateGroups { get; }
+        protected virtual bool UsePreviewControl { get; }
+        public Control ViewControl { get; set; }
+        public virtual bool ViewControlCreated { get; set; }
+        protected virtual bool Visible { get; }
+        protected string CreateErrorDesignTimeHtml(string errorMessage);
+        protected string CreateErrorDesignTimeHtml(string errorMessage, Exception e);
+        protected string CreatePlaceHolderDesignTimeHtml();
+        protected string CreatePlaceHolderDesignTimeHtml(string instruction);
+        protected virtual Control CreateViewControl();
+        public Rectangle GetBounds();
+        public virtual string GetDesignTimeHtml();
+        public virtual string GetDesignTimeHtml(DesignerRegionCollection regions);
+        public static DesignTimeResourceProviderFactory GetDesignTimeResourceProviderFactory(IServiceProvider serviceProvider);
+        public virtual string GetEditableDesignerRegionContent(EditableDesignerRegion region);
+        protected virtual string GetEmptyDesignTimeHtml();
+        protected virtual string GetErrorDesignTimeHtml(Exception e);
+        public virtual string GetPersistenceContent();
+        public virtual string GetPersistInnerHtml();
+        public ViewRendering GetViewRendering();
+        public static ViewRendering GetViewRendering(Control control);
+        public static ViewRendering GetViewRendering(ControlDesigner designer);
+        public override void Initialize(IComponent component);
+        public void Invalidate();
+        public void Invalidate(Rectangle rectangle);
+        public static void InvokeTransactedChange(IComponent component, TransactedChangeCallback callback, object context, string description);
+        public static void InvokeTransactedChange(IComponent component, TransactedChangeCallback callback, object context, string description, MemberDescriptor member);
+        public static void InvokeTransactedChange(IServiceProvider serviceProvider, IComponent component, TransactedChangeCallback callback, object context, string description, MemberDescriptor member);
+        public bool IsPropertyBound(string propName);
+        public void Localize(IDesignTimeResourceWriter resourceWriter);
+        public virtual void OnAutoFormatApplied(DesignerAutoFormat appliedAutoFormat);
+        protected override void OnBindingsCollectionChanged(string propName);
+        protected virtual void OnClick(DesignerRegionMouseEventArgs e);
+        public virtual void OnComponentChanged(object sender, ComponentChangedEventArgs ce);
+        public virtual void OnComponentChanging(object sender, ComponentChangingEventArgs ce);
+        protected virtual void OnControlResize();
+        protected virtual void OnPaint(PaintEventArgs e);
+        protected override void PreFilterProperties(IDictionary properties);
+        public void RaiseResizeEvent();
+        public void RegisterClone(object original, object clone);
+        public virtual void SetEditableDesignerRegionContent(EditableDesignerRegion region, string content);
+        protected void SetRegionContent(EditableDesignerRegion region, string content);
+        protected void SetViewFlags(ViewFlags viewFlags, bool setFlag);
+        public virtual void UpdateDesignTimeHtml();
+    }
+    public sealed class ControlDesignerState {
+        public object this[string key] { get; set; }
+    }
+    public enum ControlLocation {
+        After = 1,
+        Before = 0,
+        First = 2,
+        FirstChild = 4,
+        Last = 3,
+        LastChild = 5,
+    }
+    public sealed class ControlParser {
+        public static Control ParseControl(IDesignerHost designerHost, string controlText);
+        public static Control ParseControl(IDesignerHost designerHost, string controlText, string directives);
+        public static Control[] ParseControls(IDesignerHost designerHost, string controlText);
+        public static ITemplate ParseTemplate(IDesignerHost designerHost, string templateText);
+        public static ITemplate ParseTemplate(IDesignerHost designerHost, string templateText, string directives);
+    }
+    public sealed class ControlPersister {
+        public static void PersistControl(TextWriter sw, Control control);
+        public static void PersistControl(TextWriter sw, Control control, IDesignerHost host);
+        public static string PersistControl(Control control);
+        public static string PersistControl(Control control, IDesignerHost host);
+        public static void PersistInnerProperties(TextWriter sw, object component, IDesignerHost host);
+        public static string PersistInnerProperties(object component, IDesignerHost host);
+        public static void PersistTemplate(TextWriter writer, ITemplate template, IDesignerHost host);
+        public static string PersistTemplate(ITemplate template, IDesignerHost host);
+    }
+    public class DataBindingCollectionConverter : TypeConverter {
+        public DataBindingCollectionConverter();
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public class DataBindingCollectionEditor : UITypeEditor {
+        public DataBindingCollectionEditor();
+        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value);
+        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context);
+    }
+    public abstract class DataBindingHandler {
+        protected DataBindingHandler();
+        public abstract void DataBindControl(IDesignerHost designerHost, Control control);
+    }
+    public class DataBindingValueUIHandler {
+        public DataBindingValueUIHandler();
+        public void OnGetUIValueItem(ITypeDescriptorContext context, PropertyDescriptor propDesc, ArrayList valueUIItemList);
+    }
+    public class DataColumnSelectionConverter : TypeConverter {
+        public DataColumnSelectionConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context);
+        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context);
+        public override bool GetStandardValuesSupported(ITypeDescriptorContext context);
+    }
+    public class DataFieldConverter : TypeConverter {
+        public DataFieldConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context);
+        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context);
+        public override bool GetStandardValuesSupported(ITypeDescriptorContext context);
+    }
+    public class DataMemberConverter : TypeConverter {
+        public DataMemberConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context);
+        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context);
+        public override bool GetStandardValuesSupported(ITypeDescriptorContext context);
+    }
+    public sealed class DataSetFieldSchema : IDataSourceFieldSchema {
+        public DataSetFieldSchema(DataColumn column);
+        public Type DataType { get; }
+        public bool Identity { get; }
+        public bool IsReadOnly { get; }
+        public bool IsUnique { get; }
+        public int Length { get; }
+        public string Name { get; }
+        public bool Nullable { get; }
+        public int Precision { get; }
+        public bool PrimaryKey { get; }
+        public int Scale { get; }
+    }
+    public sealed class DataSetSchema : IDataSourceSchema {
+        public DataSetSchema(DataSet dataSet);
+        public IDataSourceViewSchema[] GetViews();
+    }
+    public sealed class DataSetViewSchema : IDataSourceViewSchema {
+        public DataSetViewSchema(DataTable dataTable);
+        public string Name { get; }
+        public IDataSourceViewSchema[] GetChildren();
+        public IDataSourceFieldSchema[] GetFields();
+    }
+    public class DataSourceBooleanViewSchemaConverter : DataSourceViewSchemaConverter {
+        public DataSourceBooleanViewSchemaConverter();
+        public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context);
+    }
+    public class DataSourceConverter : TypeConverter {
+        public DataSourceConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context);
+        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context);
+        public override bool GetStandardValuesSupported(ITypeDescriptorContext context);
+        protected virtual bool IsValidDataSource(IComponent component);
+    }
+    public class DataSourceDesigner : ControlDesigner, IDataSourceDesigner {
+        public DataSourceDesigner();
+        public override DesignerActionListCollection ActionLists { get; }
+        public virtual bool CanConfigure { get; }
+        public virtual bool CanRefreshSchema { get; }
+        protected bool SuppressingDataSourceEvents { get; }
+        public event EventHandler DataSourceChanged;
+        public event EventHandler SchemaRefreshed;
+        public virtual void Configure();
+        public override string GetDesignTimeHtml();
+        public virtual DesignerDataSourceView GetView(string viewName);
+        public virtual string[] GetViewNames();
+        protected virtual void OnDataSourceChanged(EventArgs e);
+        protected virtual void OnSchemaRefreshed(EventArgs e);
+        public virtual void RefreshSchema(bool preferSilent);
+        public virtual void ResumeDataSourceEvents();
+        public static bool SchemasEquivalent(IDataSourceSchema schema1, IDataSourceSchema schema2);
+        public virtual void SuppressDataSourceEvents();
+        public static bool ViewSchemasEquivalent(IDataSourceViewSchema viewSchema1, IDataSourceViewSchema viewSchema2);
+    }
+    public class DataSourceViewSchemaConverter : TypeConverter {
+        public DataSourceViewSchemaConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context);
+        public virtual TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context, Type typeFilter);
+        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context);
+        public override bool GetStandardValuesSupported(ITypeDescriptorContext context);
+    }
+    public abstract class DesignerAutoFormat {
+        protected DesignerAutoFormat(string name);
+        public string Name { get; }
+        public DesignerAutoFormatStyle Style { get; }
+        public abstract void Apply(Control control);
+        public virtual Control GetPreviewControl(Control runtimeControl);
+        public override string ToString();
+    }
+    public sealed class DesignerAutoFormatCollection : ICollection, IEnumerable, IList {
+        public DesignerAutoFormatCollection();
+        public int Count { get; }
+        public Size PreviewSize { get; }
+        public object SyncRoot { get; }
+        int System.Collections.ICollection.Count { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public DesignerAutoFormat this[int index] { get; }
+        public int Add(DesignerAutoFormat format);
+        public void Clear();
+        public bool Contains(DesignerAutoFormat format);
+        public int IndexOf(DesignerAutoFormat format);
+        public void Insert(int index, DesignerAutoFormat format);
+        public void Remove(DesignerAutoFormat format);
+        public void RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        void System.Collections.IList.RemoveAt(int index);
+    }
+    public class DesignerAutoFormatStyle : Style {
+        public DesignerAutoFormatStyle();
+        public VerticalAlign VerticalAlign { get; set; }
+    }
+    public abstract class DesignerDataSourceView {
+        protected DesignerDataSourceView(IDataSourceDesigner owner, string viewName);
+        public virtual bool CanDelete { get; }
+        public virtual bool CanInsert { get; }
+        public virtual bool CanPage { get; }
+        public virtual bool CanRetrieveTotalRowCount { get; }
+        public virtual bool CanSort { get; }
+        public virtual bool CanUpdate { get; }
+        public IDataSourceDesigner DataSourceDesigner { get; }
+        public string Name { get; }
+        public virtual IDataSourceViewSchema Schema { get; }
+        public virtual IEnumerable GetDesignTimeData(int minimumRows, out bool isSampleData);
+    }
+    public abstract class DesignerHierarchicalDataSourceView {
+        protected DesignerHierarchicalDataSourceView(IHierarchicalDataSourceDesigner owner, string viewPath);
+        public IHierarchicalDataSourceDesigner DataSourceDesigner { get; }
+        public string Path { get; }
+        public virtual IDataSourceSchema Schema { get; }
+        public virtual IHierarchicalEnumerable GetDesignTimeData(out bool isSampleData);
+    }
+    public abstract class DesignerObject : IServiceProvider {
+        protected DesignerObject(ControlDesigner designer, string name);
+        public ControlDesigner Designer { get; }
+        public string Name { get; }
+        public IDictionary Properties { get; }
+        protected object GetService(Type serviceType);
+        object System.IServiceProvider.GetService(Type serviceType);
+    }
+    public class DesignerRegion : DesignerObject {
+        public static readonly string DesignerRegionAttributeName;
+        public DesignerRegion(ControlDesigner designer, string name);
+        public DesignerRegion(ControlDesigner designer, string name, bool selectable);
+        public virtual string Description { get; set; }
+        public virtual string DisplayName { get; set; }
+        public bool EnsureSize { get; set; }
+        public virtual bool Highlight { get; set; }
+        public virtual bool Selectable { get; set; }
+        public virtual bool Selected { get; set; }
+        public object UserData { get; set; }
+        public Rectangle GetBounds();
+    }
+    public class DesignerRegionCollection : ICollection, IEnumerable, IList {
+        public DesignerRegionCollection();
+        public DesignerRegionCollection(ControlDesigner owner);
+        public int Count { get; }
+        public bool IsFixedSize { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public ControlDesigner Owner { get; }
+        public object SyncRoot { get; }
+        int System.Collections.ICollection.Count { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public DesignerRegion this[int index] { get; set; }
+        public int Add(DesignerRegion region);
+        public void Clear();
+        public bool Contains(DesignerRegion region);
+        public void CopyTo(Array array, int index);
+        public IEnumerator GetEnumerator();
+        public int IndexOf(DesignerRegion region);
+        public void Insert(int index, DesignerRegion region);
+        public void Remove(DesignerRegion region);
+        public void RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object o);
+        void System.Collections.IList.Clear();
+        bool System.Collections.IList.Contains(object o);
+        int System.Collections.IList.IndexOf(object o);
+        void System.Collections.IList.Insert(int index, object o);
+        void System.Collections.IList.Remove(object o);
+        void System.Collections.IList.RemoveAt(int index);
+    }
+    public sealed class DesignerRegionMouseEventArgs : EventArgs {
+        public DesignerRegionMouseEventArgs(DesignerRegion region, Point location);
+        public Point Location { get; }
+        public DesignerRegion Region { get; }
+    }
+    public sealed class DesignTimeData {
+        public static readonly EventHandler DataBindingHandler;
+        public static DataTable CreateDummyDataBoundDataTable();
+        public static DataTable CreateDummyDataTable();
+        public static DataTable CreateSampleDataTable(IEnumerable referenceData);
+        public static DataTable CreateSampleDataTable(IEnumerable referenceData, bool useDataBoundData);
+        public static PropertyDescriptorCollection GetDataFields(IEnumerable dataSource);
+        public static IEnumerable GetDataMember(IListSource dataSource, string dataMember);
+        public static string[] GetDataMembers(object dataSource);
+        public static IEnumerable GetDesignTimeDataSource(DataTable dataTable, int minimumRows);
+        public static object GetSelectedDataSource(IComponent component, string dataSource);
+        public static IEnumerable GetSelectedDataSource(IComponent component, string dataSource, string dataMember);
+    }
+    public abstract class DesignTimeResourceProviderFactory {
+        protected DesignTimeResourceProviderFactory();
+        public abstract IResourceProvider CreateDesignTimeGlobalResourceProvider(IServiceProvider serviceProvider, string classKey);
+        public abstract IResourceProvider CreateDesignTimeLocalResourceProvider(IServiceProvider serviceProvider);
+        public abstract IDesignTimeResourceWriter CreateDesignTimeLocalResourceWriter(IServiceProvider serviceProvider);
+    }
+    public class EditableDesignerRegion : DesignerRegion {
+        public EditableDesignerRegion(ControlDesigner owner, string name);
+        public EditableDesignerRegion(ControlDesigner owner, string name, bool serverControlsOnly);
+        public virtual string Content { get; set; }
+        public bool ServerControlsOnly { get; set; }
+        public virtual bool SupportsDataBinding { get; set; }
+        public virtual ViewRendering GetChildViewRendering(Control control);
+    }
+    public abstract class ExpressionEditor {
+        protected ExpressionEditor();
+        public string ExpressionPrefix { get; }
+        public abstract object EvaluateExpression(string expression, object parseTimeData, Type propertyType, IServiceProvider serviceProvider);
+        public static ExpressionEditor GetExpressionEditor(string expressionPrefix, IServiceProvider serviceProvider);
+        public static ExpressionEditor GetExpressionEditor(Type expressionBuilderType, IServiceProvider serviceProvider);
+        public virtual ExpressionEditorSheet GetExpressionEditorSheet(string expression, IServiceProvider serviceProvider);
+    }
+    public abstract class ExpressionEditorSheet {
+        protected ExpressionEditorSheet(IServiceProvider serviceProvider);
+        public virtual bool IsValid { get; }
+        public IServiceProvider ServiceProvider { get; }
+        public abstract string GetExpression();
+    }
+    public class ExpressionsCollectionConverter : TypeConverter {
+        public ExpressionsCollectionConverter();
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public class ExpressionsCollectionEditor : UITypeEditor {
+        public ExpressionsCollectionEditor();
+        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value);
+        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context);
+    }
+    public class ExtenderControlDesigner : ControlDesigner, IControlDesigner {
+        public ExtenderControlDesigner();
+        protected override bool Visible { get; }
+        protected override void Dispose(bool disposing);
+        public override string GetDesignTimeHtml();
+        public override void Initialize(IComponent component);
+        protected override void PreFilterProperties(IDictionary properties);
+    }
+    public class ExtenderControlToolboxItem : WebControlToolboxItem {
+        public ExtenderControlToolboxItem();
+        protected ExtenderControlToolboxItem(SerializationInfo info, StreamingContext context);
+        public ExtenderControlToolboxItem(Type type);
+        public ReadOnlyCollection<Type> GetTargetControlTypes(IDesignerHost host);
+        public override void Initialize(Type type);
+    }
+    public class HierarchicalDataSourceConverter : DataSourceConverter {
+        public HierarchicalDataSourceConverter();
+        protected override bool IsValidDataSource(IComponent component);
+    }
+    public class HierarchicalDataSourceDesigner : ControlDesigner, IHierarchicalDataSourceDesigner {
+        public HierarchicalDataSourceDesigner();
+        public override DesignerActionListCollection ActionLists { get; }
+        public virtual bool CanConfigure { get; }
+        public virtual bool CanRefreshSchema { get; }
+        protected bool SuppressingDataSourceEvents { get; }
+        public event EventHandler DataSourceChanged;
+        public event EventHandler SchemaRefreshed;
+        public virtual void Configure();
+        public override string GetDesignTimeHtml();
+        public virtual DesignerHierarchicalDataSourceView GetView(string viewPath);
+        protected virtual void OnDataSourceChanged(EventArgs e);
+        protected virtual void OnSchemaRefreshed(EventArgs e);
+        public virtual void RefreshSchema(bool preferSilent);
+        public virtual void ResumeDataSourceEvents();
+        public virtual void SuppressDataSourceEvents();
+    }
+    public class HtmlControlDesigner : ComponentDesigner {
+        public HtmlControlDesigner();
+        public IHtmlControlDesignerBehavior Behavior { get; set; }
+        public DataBindingCollection DataBindings { get; }
+        protected object DesignTimeElement { get; }
+        public ExpressionBindingCollection Expressions { get; }
+        public virtual bool ShouldCodeSerialize { get; set; }
+        protected override void Dispose(bool disposing);
+        public override void Initialize(IComponent component);
+        protected virtual void OnBehaviorAttached();
+        protected virtual void OnBehaviorDetaching();
+        protected virtual void OnBindingsCollectionChanged(string propName);
+        public virtual void OnSetParent();
+        protected override void PreFilterEvents(IDictionary events);
+        protected override void PreFilterProperties(IDictionary properties);
+    }
+    public class HtmlIntrinsicControlDesigner : HtmlControlDesigner {
+        public HtmlIntrinsicControlDesigner();
+    }
+    public class HyperLinkDataBindingHandler : DataBindingHandler {
+        public HyperLinkDataBindingHandler();
+        public override void DataBindControl(IDesignerHost designerHost, Control control);
+    }
+    public interface IContentResolutionService {
+        IDictionary ContentDefinitions { get; }
+        ContentDesignerState GetContentDesignerState(string identifier);
+        void SetContentDesignerState(string identifier, ContentDesignerState state);
+    }
+    public interface IControlDesignerBehavior {
+        object DesignTimeElementView { get; }
+        string DesignTimeHtml { get; set; }
+        void OnTemplateModeChanged();
+    }
+    public interface IControlDesignerTag {
+        bool IsDirty { get; }
+        string GetAttribute(string name);
+        string GetContent();
+        string GetOuterContent();
+        void RemoveAttribute(string name);
+        void SetAttribute(string name, string value);
+        void SetContent(string content);
+        void SetDirty(bool dirty);
+    }
+    public interface IControlDesignerView {
+        DesignerRegion ContainingRegion { get; }
+        IDesigner NamingContainerDesigner { get; }
+        bool SupportsRegions { get; }
+        event ViewEventHandler ViewEvent;
+        Rectangle GetBounds(DesignerRegion region);
+        void Invalidate(Rectangle rectangle);
+        void SetFlags(ViewFlags viewFlags, bool setFlag);
+        void SetRegionContent(EditableDesignerRegion region, string content);
+        void Update();
+    }
+    public interface IDataBindingSchemaProvider {
+        bool CanRefreshSchema { get; }
+        IDataSourceViewSchema Schema { get; }
+        void RefreshSchema(bool preferSilent);
+    }
+    public interface IDataSourceDesigner {
+        bool CanConfigure { get; }
+        bool CanRefreshSchema { get; }
+        event EventHandler DataSourceChanged;
+        event EventHandler SchemaRefreshed;
+        void Configure();
+        DesignerDataSourceView GetView(string viewName);
+        string[] GetViewNames();
+        void RefreshSchema(bool preferSilent);
+        void ResumeDataSourceEvents();
+        void SuppressDataSourceEvents();
+    }
+    public interface IDataSourceFieldSchema {
+        Type DataType { get; }
+        bool Identity { get; }
+        bool IsReadOnly { get; }
+        bool IsUnique { get; }
+        int Length { get; }
+        string Name { get; }
+        bool Nullable { get; }
+        int Precision { get; }
+        bool PrimaryKey { get; }
+        int Scale { get; }
+    }
+    public interface IDataSourceProvider {
+        IEnumerable GetResolvedSelectedDataSource();
+        object GetSelectedDataSource();
+    }
+    public interface IDataSourceSchema {
+        IDataSourceViewSchema[] GetViews();
+    }
+    public interface IDataSourceViewSchema {
+        string Name { get; }
+        IDataSourceViewSchema[] GetChildren();
+        IDataSourceFieldSchema[] GetFields();
+    }
+    public interface IDesignTimeResourceProviderFactoryService {
+        DesignTimeResourceProviderFactory GetFactory();
+    }
+    public interface IDesignTimeResourceWriter : IDisposable, IResourceWriter {
+        string CreateResourceKey(string resourceName, object obj);
+    }
+    public interface IDocumentProjectItem {
+        Stream GetContents();
+        void Open();
+    }
+    public interface IFolderProjectItem {
+        ICollection Children { get; }
+        IDocumentProjectItem AddDocument(string name, byte[] content);
+        IFolderProjectItem AddFolder(string name);
+    }
+    public interface IHierarchicalDataSourceDesigner {
+        bool CanConfigure { get; }
+        bool CanRefreshSchema { get; }
+        event EventHandler DataSourceChanged;
+        event EventHandler SchemaRefreshed;
+        void Configure();
+        DesignerHierarchicalDataSourceView GetView(string viewPath);
+        void RefreshSchema(bool preferSilent);
+        void ResumeDataSourceEvents();
+        void SuppressDataSourceEvents();
+    }
+    public interface IHtmlControlDesignerBehavior {
+        HtmlControlDesigner Designer { get; set; }
+        object DesignTimeElement { get; }
+        object GetAttribute(string attribute, bool ignoreCase);
+        object GetStyleAttribute(string attribute, bool designTimeOnly, bool ignoreCase);
+        void RemoveAttribute(string attribute, bool ignoreCase);
+        void RemoveStyleAttribute(string attribute, bool designTimeOnly, bool ignoreCase);
+        void SetAttribute(string attribute, object value, bool ignoreCase);
+        void SetStyleAttribute(string attribute, bool designTimeOnly, object value, bool ignoreCase);
+    }
+    public class ImageUrlEditor : UrlEditor {
+        public ImageUrlEditor();
+        protected override string Caption { get; }
+        protected override string Filter { get; }
+    }
+    public interface IProjectItem {
+        string AppRelativeUrl { get; }
+        string Name { get; }
+        IProjectItem Parent { get; }
+        string PhysicalPath { get; }
+    }
+    public interface ITemplateEditingFrame : IDisposable {
+        Style ControlStyle { get; }
+        int InitialHeight { get; set; }
+        int InitialWidth { get; set; }
+        string Name { get; }
+        string[] TemplateNames { get; }
+        Style[] TemplateStyles { get; }
+        TemplateEditingVerb Verb { get; set; }
+        void Close(bool saveChanges);
+        void Open();
+        void Resize(int width, int height);
+        void Save();
+        void UpdateControlName(string newName);
+    }
+    public interface ITemplateEditingService {
+        bool SupportsNestedTemplateEditing { get; }
+        ITemplateEditingFrame CreateFrame(TemplatedControlDesigner designer, string frameName, string[] templateNames);
+        ITemplateEditingFrame CreateFrame(TemplatedControlDesigner designer, string frameName, string[] templateNames, Style controlStyle, Style[] templateStyles);
+        string GetContainingTemplateName(Control control);
+    }
+    public interface IWebAdministrationService {
+        void Start(IDictionary arguments);
+    }
+    public interface IWebApplication : IServiceProvider {
+        IProjectItem RootProjectItem { get; }
+        IProjectItem GetProjectItemFromUrl(string appRelativeUrl);
+        Configuration OpenWebConfiguration(bool isReadOnly);
+    }
+    public interface IWebFormReferenceManager {
+        Type GetObjectType(string tagPrefix, string typeName);
+        string GetRegisterDirectives();
+        string GetTagPrefix(Type objectType);
+    }
+    public interface IWebFormsBuilderUIService {
+        string BuildColor(Control owner, string initialColor);
+        string BuildUrl(Control owner, string initialUrl, string baseUrl, string caption, string filter, UrlBuilderOptions options);
+    }
+    public interface IWebFormsDocumentService {
+        string DocumentUrl { get; }
+        bool IsLoading { get; }
+        event EventHandler LoadComplete;
+        object CreateDiscardableUndoUnit();
+        void DiscardUndoUnit(object discardableUndoUnit);
+        void EnableUndo(bool enable);
+        void UpdateSelection();
+    }
+    public class MailFileEditor : UrlEditor {
+        public MailFileEditor();
+        protected override string Caption { get; }
+        protected override string Filter { get; }
+    }
+    public class MdbDataFileEditor : UrlEditor {
+        public MdbDataFileEditor();
+        protected override string Caption { get; }
+        protected override string Filter { get; }
+    }
+    public class PostBackTriggerControlIDConverter : StringConverter {
+        public PostBackTriggerControlIDConverter();
+        public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context);
+        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context);
+        public override bool GetStandardValuesSupported(ITypeDescriptorContext context);
+    }
+    public class QueryExtenderDesigner : ControlDesigner, IControlDesigner {
+        public QueryExtenderDesigner();
+        public override string GetDesignTimeHtml();
+    }
+    public class ReadWriteControlDesigner : ControlDesigner {
+        public ReadWriteControlDesigner();
+        public override string GetDesignTimeHtml();
+        protected virtual void MapPropertyToStyle(string propName, object varPropValue);
+        protected override void OnBehaviorAttached();
+        public override void OnComponentChanged(object sender, ComponentChangedEventArgs ce);
+        public override void UpdateDesignTimeHtml();
+    }
+    public class ResourceExpressionEditor : ExpressionEditor {
+        public ResourceExpressionEditor();
+        public override object EvaluateExpression(string expression, object parseTimeData, Type propertyType, IServiceProvider serviceProvider);
+        public override ExpressionEditorSheet GetExpressionEditorSheet(string expression, IServiceProvider serviceProvider);
+    }
+    public class ResourceExpressionEditorSheet : ExpressionEditorSheet {
+        public ResourceExpressionEditorSheet(string expression, IServiceProvider serviceProvider);
+        public string ClassKey { get; set; }
+        public override bool IsValid { get; }
+        public string ResourceKey { get; set; }
+        public override string GetExpression();
+    }
+    public class RouteUrlExpressionEditor : ExpressionEditor {
+        public RouteUrlExpressionEditor();
+        public override object EvaluateExpression(string expression, object parseTimeData, Type propertyType, IServiceProvider serviceProvider);
+        public override ExpressionEditorSheet GetExpressionEditorSheet(string expression, IServiceProvider serviceProvider);
+    }
+    public class RouteUrlExpressionEditorSheet : ExpressionEditorSheet {
+        public RouteUrlExpressionEditorSheet(string expression, IServiceProvider serviceProvider);
+        public override bool IsValid { get; }
+        public string RouteName { get; set; }
+        public string RouteValues { get; set; }
+        public override string GetExpression();
+    }
+    public class RouteValueExpressionEditor : ExpressionEditor {
+        public RouteValueExpressionEditor();
+        public override object EvaluateExpression(string expression, object parseTimeData, Type propertyType, IServiceProvider serviceProvider);
+        public override ExpressionEditorSheet GetExpressionEditorSheet(string expression, IServiceProvider serviceProvider);
+    }
+    public class RouteValueExpressionEditorSheet : ExpressionEditorSheet {
+        public RouteValueExpressionEditorSheet(string expression, IServiceProvider serviceProvider);
+        public override bool IsValid { get; }
+        public string RouteValue { get; set; }
+        public override string GetExpression();
+    }
+    public class ScriptManagerDesigner : ControlDesigner {
+        public ScriptManagerDesigner();
+        public static string GetApplicationServices(ScriptManager scriptManager, IEnumerable<ScriptManagerProxy> proxies);
+        public override string GetDesignTimeHtml();
+        public static string GetProxyScript(ScriptManager scriptManager, ServiceReference serviceReference);
+        public static string GetProxyUrl(ScriptManager scriptManager, ServiceReference serviceReference);
+        public static string GetScriptFromWebResource(Assembly assembly, string resourceName, CultureInfo culture);
+        public static ReadOnlyCollection<ScriptReference> GetScriptReferences(ScriptManager scriptManager, IEnumerable<ScriptManagerProxy> proxies);
+        public static ReadOnlyCollection<ServiceReference> GetServiceReferences(ScriptManager scriptManager, IEnumerable<ScriptManagerProxy> proxies);
+        public override void Initialize(IComponent component);
+    }
+    public class ScriptManagerProxyDesigner : ControlDesigner {
+        public ScriptManagerProxyDesigner();
+        public override string GetDesignTimeHtml();
+        public override void Initialize(IComponent component);
+    }
+    public class ServiceReferenceCollectionEditor : CollectionEditorBase {
+        public ServiceReferenceCollectionEditor(Type type);
+        protected override bool CanSelectMultipleInstances();
+        protected override Type[] CreateNewItemTypes();
+    }
+    public class SkinIDTypeConverter : TypeConverter {
+        public SkinIDTypeConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+        public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context);
+        public override bool GetStandardValuesSupported(ITypeDescriptorContext context);
+    }
+    public sealed class SupportsPreviewControlAttribute : Attribute {
+        public static readonly SupportsPreviewControlAttribute Default;
+        public SupportsPreviewControlAttribute(bool supportsPreviewControl);
+        public bool SupportsPreviewControl { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public override bool IsDefaultAttribute();
+    }
+    public abstract class TemplatedControlDesigner : ControlDesigner {
+        public TemplatedControlDesigner();
+        public ITemplateEditingFrame ActiveTemplateEditingFrame { get; }
+        public bool CanEnterTemplateMode { get; }
+        protected override bool DataBindingsEnabled { get; }
+        public new bool InTemplateMode { get; }
+        public override TemplateGroupCollection TemplateGroups { get; }
+        protected abstract ITemplateEditingFrame CreateTemplateEditingFrame(TemplateEditingVerb verb);
+        public void EnterTemplateMode(ITemplateEditingFrame newTemplateEditingFrame);
+        public void ExitTemplateMode(bool fSwitchingTemplates, bool fNested, bool fSave);
+        protected abstract TemplateEditingVerb[] GetCachedTemplateEditingVerbs();
+        public virtual string GetTemplateContainerDataItemProperty(string templateName);
+        public virtual IEnumerable GetTemplateContainerDataSource(string templateName);
+        public abstract string GetTemplateContent(ITemplateEditingFrame editingFrame, string templateName, out bool allowEditing);
+        public TemplateEditingVerb[] GetTemplateEditingVerbs();
+        protected ITemplate GetTemplateFromText(string text);
+        public virtual Type GetTemplatePropertyParentType(string templateName);
+        protected string GetTextFromTemplate(ITemplate template);
+        public override void Initialize(IComponent component);
+        protected override void OnBehaviorAttached();
+        public override void OnComponentChanged(object sender, ComponentChangedEventArgs ce);
+        public override void OnSetParent();
+        protected virtual void OnTemplateModeChanged();
+        protected void SaveActiveTemplateEditingFrame();
+        public abstract void SetTemplateContent(ITemplateEditingFrame editingFrame, string templateName, string templateContent);
+        public override void UpdateDesignTimeHtml();
+    }
+    public class TemplatedEditableDesignerRegion : EditableDesignerRegion {
+        public TemplatedEditableDesignerRegion(TemplateDefinition templateDefinition);
+        public virtual bool IsSingleInstanceTemplate { get; set; }
+        public override bool SupportsDataBinding { get; set; }
+        public TemplateDefinition TemplateDefinition { get; }
+    }
+    public class TemplateDefinition : DesignerObject {
+        public TemplateDefinition(ControlDesigner designer, string name, object templatedObject, string templatePropertyName);
+        public TemplateDefinition(ControlDesigner designer, string name, object templatedObject, string templatePropertyName, bool serverControlsOnly);
+        public TemplateDefinition(ControlDesigner designer, string name, object templatedObject, string templatePropertyName, Style style);
+        public TemplateDefinition(ControlDesigner designer, string name, object templatedObject, string templatePropertyName, Style style, bool serverControlsOnly);
+        public virtual bool AllowEditing { get; }
+        public virtual string Content { get; set; }
+        public bool ServerControlsOnly { get; }
+        public Style Style { get; }
+        public bool SupportsDataBinding { get; set; }
+        public object TemplatedObject { get; }
+        public string TemplatePropertyName { get; }
+    }
+    public sealed class TemplateEditingService : IDisposable, ITemplateEditingService {
+        public TemplateEditingService(IDesignerHost designerHost);
+        public bool SupportsNestedTemplateEditing { get; }
+        public ITemplateEditingFrame CreateFrame(TemplatedControlDesigner designer, string frameName, string[] templateNames);
+        public ITemplateEditingFrame CreateFrame(TemplatedControlDesigner designer, string frameName, string[] templateNames, Style controlStyle, Style[] templateStyles);
+        public void Dispose();
+        ~TemplateEditingService();
+        public string GetContainingTemplateName(Control control);
+    }
+    public class TemplateEditingVerb : DesignerVerb, IDisposable {
+        public TemplateEditingVerb(string text, int index);
+        public TemplateEditingVerb(string text, int index, TemplatedControlDesigner designer);
+        public int Index { get; }
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        ~TemplateEditingVerb();
+    }
+    public class TemplateGroup {
+        public TemplateGroup(string groupName);
+        public TemplateGroup(string groupName, Style groupStyle);
+        public string GroupName { get; }
+        public Style GroupStyle { get; }
+        public bool IsEmpty { get; }
+        public TemplateDefinition[] Templates { get; }
+        public void AddTemplateDefinition(TemplateDefinition templateDefinition);
+    }
+    public sealed class TemplateGroupCollection : ICollection, IEnumerable, IList {
+        public TemplateGroupCollection();
+        public int Count { get; }
+        int System.Collections.ICollection.Count { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public TemplateGroup this[int index] { get; set; }
+        public int Add(TemplateGroup group);
+        public void AddRange(TemplateGroupCollection groups);
+        public void Clear();
+        public bool Contains(TemplateGroup group);
+        public void CopyTo(TemplateGroup[] array, int index);
+        public int IndexOf(TemplateGroup group);
+        public void Insert(int index, TemplateGroup group);
+        public void Remove(TemplateGroup group);
+        public void RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object o);
+        void System.Collections.IList.Clear();
+        bool System.Collections.IList.Contains(object o);
+        int System.Collections.IList.IndexOf(object o);
+        void System.Collections.IList.Insert(int index, object o);
+        void System.Collections.IList.Remove(object o);
+        void System.Collections.IList.RemoveAt(int index);
+    }
+    public class TemplateModeChangedEventArgs : EventArgs {
+        public TemplateModeChangedEventArgs(TemplateGroup newTemplateGroup);
+        public TemplateGroup NewTemplateGroup { get; }
+    }
+    public class TextControlDesigner : ControlDesigner {
+        public TextControlDesigner();
+        public override string GetDesignTimeHtml();
+    }
+    public class TextDataBindingHandler : DataBindingHandler {
+        public TextDataBindingHandler();
+        public override void DataBindControl(IDesignerHost designerHost, Control control);
+    }
+    public class TimerDesigner : ControlDesigner {
+        public TimerDesigner();
+        public override string GetDesignTimeHtml();
+    }
+    public delegate bool TransactedChangeCallback(object context);
+    public sealed class TypeSchema : IDataSourceSchema {
+        public TypeSchema(Type type);
+        public IDataSourceViewSchema[] GetViews();
+    }
+    public class UpdatePanelDesigner : ControlDesigner {
+        public UpdatePanelDesigner();
+        protected override bool UsePreviewControl { get; }
+        public override string GetDesignTimeHtml(DesignerRegionCollection regions);
+        public override string GetEditableDesignerRegionContent(EditableDesignerRegion region);
+        public override void Initialize(IComponent component);
+        public override void OnComponentChanged(object sender, ComponentChangedEventArgs ce);
+        public override void SetEditableDesignerRegionContent(EditableDesignerRegion region, string content);
+    }
+    public class UpdatePanelTriggerCollectionEditor : CollectionEditorBase {
+        public UpdatePanelTriggerCollectionEditor(Type type);
+        protected override bool CanSelectMultipleInstances();
+        protected override Type CreateCollectionItemType();
+        protected override Type[] CreateNewItemTypes();
+        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value);
+    }
+    public class UpdateProgressAssociatedUpdatePanelIDConverter : StringConverter {
+        public UpdateProgressAssociatedUpdatePanelIDConverter();
+        public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context);
+        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context);
+        public override bool GetStandardValuesSupported(ITypeDescriptorContext context);
+    }
+    public class UpdateProgressDesigner : ControlDesigner {
+        public UpdateProgressDesigner();
+        protected override bool UsePreviewControl { get; }
+        public override string GetDesignTimeHtml(DesignerRegionCollection regions);
+        public override string GetEditableDesignerRegionContent(EditableDesignerRegion region);
+        public override void SetEditableDesignerRegionContent(EditableDesignerRegion region, string content);
+    }
+    public sealed class UrlBuilder {
+        public static string BuildUrl(IComponent component, Control owner, string initialUrl, string caption, string filter);
+        public static string BuildUrl(IComponent component, Control owner, string initialUrl, string caption, string filter, UrlBuilderOptions options);
+        public static string BuildUrl(IServiceProvider serviceProvider, Control owner, string initialUrl, string caption, string filter, UrlBuilderOptions options);
+    }
+    public enum UrlBuilderOptions {
+        NoAbsolute = 1,
+        None = 0,
+    }
+    public class UrlEditor : UITypeEditor {
+        public UrlEditor();
+        protected virtual string Caption { get; }
+        protected virtual string Filter { get; }
+        protected virtual UrlBuilderOptions Options { get; }
+        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value);
+        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context);
+    }
+    public class UserControlDesigner : ControlDesigner {
+        public UserControlDesigner();
+        public override DesignerActionListCollection ActionLists { get; }
+        public override bool AllowResize { get; }
+        public override string GetDesignTimeHtml();
+    }
+    public class UserControlFileEditor : UrlEditor {
+        public UserControlFileEditor();
+        protected override string Caption { get; }
+        protected override string Filter { get; }
+    }
+    public sealed class ViewEvent {
+        public static readonly ViewEvent Click;
+        public static readonly ViewEvent Paint;
+        public static readonly ViewEvent TemplateModeChanged;
+    }
+    public class ViewEventArgs : EventArgs {
+        public ViewEventArgs(ViewEvent eventType, DesignerRegion region, EventArgs eventArgs);
+        public EventArgs EventArgs { get; }
+        public ViewEvent EventType { get; }
+        public DesignerRegion Region { get; }
+    }
+    public delegate void ViewEventHandler(object sender, ViewEventArgs e);
+    public enum ViewFlags {
+        CustomPaint = 1,
+        DesignTimeHtmlRequiresLoadComplete = 2,
+        TemplateEditing = 4,
+    }
+    public class ViewRendering {
+        public ViewRendering(string content, DesignerRegionCollection regions);
+        public ViewRendering(string content, DesignerRegionCollection regions, bool visible);
+        public string Content { get; }
+        public DesignerRegionCollection Regions { get; }
+        public bool Visible { get; }
+    }
+    public class WebControlToolboxItem : ToolboxItem {
+        public WebControlToolboxItem();
+        protected WebControlToolboxItem(SerializationInfo info, StreamingContext context);
+        public WebControlToolboxItem(Type type);
+        protected override IComponent[] CreateComponentsCore(IDesignerHost host);
+        protected override void Deserialize(SerializationInfo info, StreamingContext context);
+        public object GetToolAttributeValue(IDesignerHost host, Type attributeType);
+        public string GetToolHtml(IDesignerHost host);
+        public Type GetToolType(IDesignerHost host);
+        public override void Initialize(Type type);
+        protected override void Serialize(SerializationInfo info, StreamingContext context);
+    }
+    public class WebFormsDesignerActionService : DesignerActionService {
+        public WebFormsDesignerActionService(IServiceProvider serviceProvider);
+        protected override void GetComponentDesignerActions(IComponent component, DesignerActionListCollection actionLists);
+    }
+    public abstract class WebFormsReferenceManager {
+        protected WebFormsReferenceManager();
+        public abstract ICollection GetRegisterDirectives();
+        public abstract string GetTagPrefix(Type objectType);
+        public abstract Type GetType(string tagPrefix, string tagName);
+        public abstract string GetUserControlPath(string tagPrefix, string tagName);
+        public abstract string RegisterTagPrefix(Type objectType);
+    }
+    public abstract class WebFormsRootDesigner : IDesigner, IDesignerFilter, IDisposable, IRootDesigner {
+        protected WebFormsRootDesigner();
+        public virtual IComponent Component { get; set; }
+        public CultureInfo CurrentCulture { get; }
+        public abstract string DocumentUrl { get; }
+        public abstract bool IsDesignerViewLocked { get; }
+        public abstract bool IsLoading { get; }
+        public abstract WebFormsReferenceManager ReferenceManager { get; }
+        protected ViewTechnology[] SupportedTechnologies { get; }
+        DesignerVerbCollection System.ComponentModel.Design.IDesigner.Verbs { get; }
+        ViewTechnology[] System.ComponentModel.Design.IRootDesigner.SupportedTechnologies { get; }
+        protected DesignerVerbCollection Verbs { get; }
+        public event EventHandler LoadComplete;
+        public abstract void AddClientScriptToDocument(ClientScriptItem scriptItem);
+        public abstract string AddControlToDocument(Control newControl, Control referenceControl, ControlLocation location);
+        protected virtual DesignerActionService CreateDesignerActionService(IServiceProvider serviceProvider);
+        protected virtual IUrlResolutionService CreateUrlResolutionService();
+        protected virtual void Dispose(bool disposing);
+        ~WebFormsRootDesigner();
+        public virtual string GenerateEmptyDesignTimeHtml(Control control);
+        public virtual string GenerateErrorDesignTimeHtml(Control control, Exception e, string errorMessage);
+        public abstract ClientScriptItemCollection GetClientScriptsInDocument();
+        protected internal abstract void GetControlViewAndTag(Control control, out IControlDesignerView view, out IControlDesignerTag tag);
+        protected internal virtual object GetService(Type serviceType);
+        protected object GetView(ViewTechnology viewTechnology);
+        public virtual void Initialize(IComponent component);
+        protected virtual void OnLoadComplete(EventArgs e);
+        protected virtual void PostFilterAttributes(IDictionary attributes);
+        protected virtual void PostFilterEvents(IDictionary events);
+        protected virtual void PostFilterProperties(IDictionary properties);
+        protected virtual void PreFilterAttributes(IDictionary attributes);
+        protected virtual void PreFilterEvents(IDictionary events);
+        protected virtual void PreFilterProperties(IDictionary properties);
+        public abstract void RemoveClientScriptFromDocument(string clientScriptId);
+        public abstract void RemoveControlFromDocument(Control control);
+        public string ResolveUrl(string relativeUrl);
+        public virtual void SetControlID(Control control, string id);
+        void System.ComponentModel.Design.IDesigner.DoDefaultAction();
+        void System.ComponentModel.Design.IDesignerFilter.PostFilterAttributes(IDictionary attributes);
+        void System.ComponentModel.Design.IDesignerFilter.PostFilterEvents(IDictionary events);
+        void System.ComponentModel.Design.IDesignerFilter.PostFilterProperties(IDictionary properties);
+        void System.ComponentModel.Design.IDesignerFilter.PreFilterAttributes(IDictionary attributes);
+        void System.ComponentModel.Design.IDesignerFilter.PreFilterEvents(IDictionary events);
+        void System.ComponentModel.Design.IDesignerFilter.PreFilterProperties(IDictionary properties);
+        object System.ComponentModel.Design.IRootDesigner.GetView(ViewTechnology viewTechnology);
+        void System.IDisposable.Dispose();
+    }
+    public class XmlDataFileEditor : UrlEditor {
+        public XmlDataFileEditor();
+        protected override string Caption { get; }
+        protected override string Filter { get; }
+    }
+    public sealed class XmlDocumentSchema : IDataSourceSchema {
+        public XmlDocumentSchema(XmlDocument xmlDocument, string xPath);
+        public IDataSourceViewSchema[] GetViews();
+    }
+    public class XmlFileEditor : UITypeEditor {
+        public XmlFileEditor();
+        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value);
+        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context);
+    }
+    public class XmlUrlEditor : UrlEditor {
+        public XmlUrlEditor();
+        protected override string Caption { get; }
+        protected override string Filter { get; }
+        protected override UrlBuilderOptions Options { get; }
+    }
+    public class XsdSchemaFileEditor : UrlEditor {
+        public XsdSchemaFileEditor();
+        protected override string Caption { get; }
+        protected override string Filter { get; }
+    }
+    public class XslTransformFileEditor : UrlEditor {
+        public XslTransformFileEditor();
+        protected override string Caption { get; }
+        protected override string Filter { get; }
+    }
+    public class XslUrlEditor : UrlEditor {
+        public XslUrlEditor();
+        protected override string Caption { get; }
+        protected override string Filter { get; }
+        protected override UrlBuilderOptions Options { get; }
+    }
+}
```

