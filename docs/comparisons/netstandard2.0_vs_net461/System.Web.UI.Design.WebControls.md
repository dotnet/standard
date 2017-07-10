# System.Web.UI.Design.WebControls

``` diff
+namespace System.Web.UI.Design.WebControls {
+    public class AccessDataSourceDesigner : SqlDataSourceDesigner {
+        public AccessDataSourceDesigner();
+        public string DataFile { get; set; }
+        protected override string GetConnectionString();
+        protected override void PreFilterProperties(IDictionary properties);
+    }
+    public class AdRotatorDesigner : DataBoundControlDesigner {
+        public AdRotatorDesigner();
+        public override string GetDesignTimeHtml();
+    }
+    public abstract class BaseDataBoundControlDesigner : ControlDesigner {
+        protected BaseDataBoundControlDesigner();
+        public string DataSource { get; set; }
+        public string DataSourceID { get; set; }
+        protected abstract bool ConnectToDataSource();
+        protected abstract void CreateDataSource();
+        protected abstract void DataBind(BaseDataBoundControl dataBoundControl);
+        protected abstract void DisconnectFromDataSource();
+        protected override void Dispose(bool disposing);
+        public override string GetDesignTimeHtml();
+        protected override string GetEmptyDesignTimeHtml();
+        protected override string GetErrorDesignTimeHtml(Exception e);
+        public override void Initialize(IComponent component);
+        protected virtual void OnDataSourceChanged(bool forceUpdateView);
+        protected virtual void OnSchemaRefreshed();
+        protected override void PreFilterProperties(IDictionary properties);
+        public static DialogResult ShowCreateDataSourceDialog(ControlDesigner controlDesigner, Type dataSourceType, bool configure, out string dataSourceID);
+    }
+    public abstract class BaseDataListComponentEditor : WindowsFormsComponentEditor {
+        public BaseDataListComponentEditor(int initialPage);
+        public override bool EditComponent(ITypeDescriptorContext context, object obj, IWin32Window parent);
+        protected override int GetInitialComponentEditorPageIndex();
+    }
+    public abstract class BaseDataListDesigner : TemplatedControlDesigner, IDataBindingSchemaProvider, IDataSourceProvider {
+        protected BaseDataListDesigner();
+        public override DesignerActionListCollection ActionLists { get; }
+        public string DataKeyField { get; set; }
+        public string DataMember { get; set; }
+        public string DataSource { get; set; }
+        public IDataSourceDesigner DataSourceDesigner { get; }
+        public string DataSourceID { get; set; }
+        public DesignerDataSourceView DesignerView { get; }
+        bool System.Web.UI.Design.IDataBindingSchemaProvider.CanRefreshSchema { get; }
+        IDataSourceViewSchema System.Web.UI.Design.IDataBindingSchemaProvider.Schema { get; }
+        protected override void Dispose(bool disposing);
+        protected IEnumerable GetDesignTimeDataSource(IEnumerable selectedDataSource, int minimumRows, out bool dummyDataSource);
+        protected IEnumerable GetDesignTimeDataSource(int minimumRows, out bool dummyDataSource);
+        public IEnumerable GetResolvedSelectedDataSource();
+        public object GetSelectedDataSource();
+        public override IEnumerable GetTemplateContainerDataSource(string templateName);
+        public override void Initialize(IComponent component);
+        protected internal void InvokePropertyBuilder(int initialPage);
+        protected void OnAutoFormat(object sender, EventArgs e);
+        public override void OnAutoFormatApplied(DesignerAutoFormat appliedAutoFormat);
+        public override void OnComponentChanged(object sender, ComponentChangedEventArgs e);
+        protected internal virtual void OnDataSourceChanged();
+        protected void OnPropertyBuilder(object sender, EventArgs e);
+        protected virtual void OnSchemaRefreshed();
+        protected internal void OnStylesChanged();
+        protected abstract void OnTemplateEditingVerbsChanged();
+        protected override void PreFilterProperties(IDictionary properties);
+        void System.Web.UI.Design.IDataBindingSchemaProvider.RefreshSchema(bool preferSilent);
+    }
+    public class BaseValidatorDesigner : PreviewControlDesigner {
+        public BaseValidatorDesigner();
+        protected override Control CreateViewControl();
+        public override string GetDesignTimeHtml();
+        protected override void PreFilterProperties(IDictionary properties);
+    }
+    public class BulletedListDesigner : ListControlDesigner {
+        public BulletedListDesigner();
+        protected override bool UsePreviewControl { get; }
+        protected override void PostFilterEvents(IDictionary events);
+    }
+    public class ButtonDesigner : ControlDesigner {
+        public ButtonDesigner();
+        public override string GetDesignTimeHtml();
+    }
+    public class CalendarAutoFormatDialog : Form {
+        public CalendarAutoFormatDialog(Calendar calendar);
+        protected void DoDelayLoadActions();
+        protected void OnActivated(object source, EventArgs e);
+        protected void OnOKClicked(object source, EventArgs e);
+        protected void OnSelChangedScheme(object source, EventArgs e);
+        protected void SaveComponent();
+    }
+    public class CalendarDesigner : ControlDesigner {
+        public CalendarDesigner();
+        public override DesignerAutoFormatCollection AutoFormats { get; }
+        public override void Initialize(IComponent component);
+        protected void OnAutoFormat(object sender, EventArgs e);
+    }
+    public class ChangePasswordDesigner : ControlDesigner {
+        public ChangePasswordDesigner();
+        public override DesignerActionListCollection ActionLists { get; }
+        public override bool AllowResize { get; }
+        public override DesignerAutoFormatCollection AutoFormats { get; }
+        public bool RenderOuterTable { get; set; }
+        public override TemplateGroupCollection TemplateGroups { get; }
+        protected override bool UsePreviewControl { get; }
+        public override string GetDesignTimeHtml();
+        public override string GetDesignTimeHtml(DesignerRegionCollection regions);
+        public override string GetEditableDesignerRegionContent(EditableDesignerRegion region);
+        protected override string GetErrorDesignTimeHtml(Exception e);
+        public override void Initialize(IComponent component);
+        protected override void PreFilterProperties(IDictionary properties);
+        public override void SetEditableDesignerRegionContent(EditableDesignerRegion region, string content);
+    }
+    public class CheckBoxDesigner : ControlDesigner {
+        public CheckBoxDesigner();
+        public override string GetDesignTimeHtml();
+    }
+    public class CompositeControlDesigner : ControlDesigner {
+        public CompositeControlDesigner();
+        protected virtual void CreateChildControls();
+        public override string GetDesignTimeHtml();
+        public override void Initialize(IComponent component);
+    }
+    public class ContentDesigner : ControlDesigner {
+        public ContentDesigner();
+        public override DesignerActionListCollection ActionLists { get; }
+        public override bool AllowResize { get; }
+        public override string GetDesignTimeHtml(DesignerRegionCollection regions);
+        public override string GetEditableDesignerRegionContent(EditableDesignerRegion region);
+        public override string GetPersistenceContent();
+        protected override void PostFilterProperties(IDictionary properties);
+        protected override void PreFilterEvents(IDictionary events);
+        public override void SetEditableDesignerRegionContent(EditableDesignerRegion region, string content);
+    }
+    public class ContentPlaceHolderDesigner : ControlDesigner {
+        public ContentPlaceHolderDesigner();
+        public override bool AllowResize { get; }
+        public override string GetDesignTimeHtml();
+        public override string GetDesignTimeHtml(DesignerRegionCollection regions);
+        public override string GetEditableDesignerRegionContent(EditableDesignerRegion region);
+        public override string GetPersistenceContent();
+        public override void SetEditableDesignerRegionContent(EditableDesignerRegion region, string content);
+    }
+    public class CreateUserWizardDesigner : WizardDesigner {
+        public CreateUserWizardDesigner();
+        public override DesignerActionListCollection ActionLists { get; }
+        public override DesignerAutoFormatCollection AutoFormats { get; }
+        protected override bool UsePreviewControl { get; }
+        protected override void AddDesignerRegions(DesignerRegionCollection regions);
+        protected override void ConvertToCustomNavigationTemplate();
+        protected override string GetErrorDesignTimeHtml(Exception e);
+        public override void Initialize(IComponent component);
+        protected override void PreFilterProperties(IDictionary properties);
+    }
+    public class CreateUserWizardStepCollectionEditor : WizardStepCollectionEditor {
+        public CreateUserWizardStepCollectionEditor(Type type);
+        protected override string HelpTopic { get; }
+        protected override bool CanRemoveInstance(object value);
+        protected override CollectionEditor.CollectionForm CreateCollectionForm();
+    }
+    public class DataBoundControlDesigner : BaseDataBoundControlDesigner, IDataBindingSchemaProvider, IDataSourceProvider {
+        public DataBoundControlDesigner();
+        public override DesignerActionListCollection ActionLists { get; }
+        public string DataMember { get; set; }
+        public IDataSourceDesigner DataSourceDesigner { get; }
+        public DesignerDataSourceView DesignerView { get; }
+        protected virtual int SampleRowCount { get; }
+        bool System.Web.UI.Design.IDataBindingSchemaProvider.CanRefreshSchema { get; }
+        IDataSourceViewSchema System.Web.UI.Design.IDataBindingSchemaProvider.Schema { get; }
+        protected virtual bool UseDataSourcePickerActionList { get; }
+        protected override bool ConnectToDataSource();
+        protected override void CreateDataSource();
+        protected override void DataBind(BaseDataBoundControl dataBoundControl);
+        protected override void DisconnectFromDataSource();
+        protected override void Dispose(bool disposing);
+        protected virtual IEnumerable GetDesignTimeDataSource();
+        protected virtual IEnumerable GetSampleDataSource();
+        protected override void PreFilterProperties(IDictionary properties);
+        void System.Web.UI.Design.IDataBindingSchemaProvider.RefreshSchema(bool preferSilent);
+        IEnumerable System.Web.UI.Design.IDataSourceProvider.GetResolvedSelectedDataSource();
+        object System.Web.UI.Design.IDataSourceProvider.GetSelectedDataSource();
+    }
+    public abstract class DataControlFieldDesigner {
+        protected DataControlFieldDesigner();
+        public abstract string DefaultNodeText { get; }
+        protected IServiceProvider ServiceProvider { get; }
+        public abstract bool UsesSchema { get; }
+        public abstract DataControlField CreateField();
+        public abstract DataControlField CreateField(IDataSourceFieldSchema fieldSchema);
+        public abstract TemplateField CreateTemplateField(DataControlField dataControlField, DataBoundControl dataBoundControl);
+        protected string GetNewDataSourceName(Type controlType, DataBoundControlMode mode);
+        public abstract string GetNodeText(DataControlField dataControlField);
+        protected object GetService(Type serviceType);
+        protected ITemplate GetTemplate(DataBoundControl control, string templateContent);
+        protected TemplateField GetTemplateField(DataControlField dataControlField, DataBoundControl dataBoundControl);
+        public abstract bool IsEnabled(DataBoundControl parent);
+    }
+    public class DataControlFieldTypeEditor : UITypeEditor {
+        public DataControlFieldTypeEditor();
+        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value);
+        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context);
+    }
+    public class DataGridColumnCollectionEditor : UITypeEditor {
+        public DataGridColumnCollectionEditor();
+        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value);
+        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context);
+    }
+    public class DataGridComponentEditor : BaseDataListComponentEditor {
+        public DataGridComponentEditor();
+        public DataGridComponentEditor(int initialPage);
+        protected override Type[] GetComponentEditorPages();
+    }
+    public class DataGridDesigner : BaseDataListDesigner {
+        public DataGridDesigner();
+        public override DesignerAutoFormatCollection AutoFormats { get; }
+        protected override ITemplateEditingFrame CreateTemplateEditingFrame(TemplateEditingVerb verb);
+        protected override void Dispose(bool disposing);
+        protected override TemplateEditingVerb[] GetCachedTemplateEditingVerbs();
+        public override string GetDesignTimeHtml();
+        protected override string GetEmptyDesignTimeHtml();
+        protected override string GetErrorDesignTimeHtml(Exception e);
+        public override string GetTemplateContainerDataItemProperty(string templateName);
+        public override string GetTemplateContent(ITemplateEditingFrame editingFrame, string templateName, out bool allowEditing);
+        public override Type GetTemplatePropertyParentType(string templateName);
+        public override void Initialize(IComponent component);
+        public virtual void OnColumnsChanged();
+        protected override void OnTemplateEditingVerbsChanged();
+        public override void SetTemplateContent(ITemplateEditingFrame editingFrame, string templateName, string templateContent);
+    }
+    public class DataListComponentEditor : BaseDataListComponentEditor {
+        public DataListComponentEditor();
+        public DataListComponentEditor(int initialPage);
+        protected override Type[] GetComponentEditorPages();
+    }
+    public class DataListDesigner : BaseDataListDesigner {
+        public DataListDesigner();
+        public override bool AllowResize { get; }
+        public override DesignerAutoFormatCollection AutoFormats { get; }
+        protected bool TemplatesExist { get; }
+        protected override ITemplateEditingFrame CreateTemplateEditingFrame(TemplateEditingVerb verb);
+        protected override void Dispose(bool disposing);
+        protected override TemplateEditingVerb[] GetCachedTemplateEditingVerbs();
+        public override string GetDesignTimeHtml();
+        protected override string GetEmptyDesignTimeHtml();
+        protected override string GetErrorDesignTimeHtml(Exception e);
+        public override string GetTemplateContainerDataItemProperty(string templateName);
+        public override string GetTemplateContent(ITemplateEditingFrame editingFrame, string templateName, out bool allowEditing);
+        public override void Initialize(IComponent component);
+        protected override void OnSchemaRefreshed();
+        protected override void OnTemplateEditingVerbsChanged();
+        public override void SetTemplateContent(ITemplateEditingFrame editingFrame, string templateName, string templateContent);
+    }
+    public class DataPagerDesigner : ControlDesigner {
+        public DataPagerDesigner();
+        public override DesignerActionListCollection ActionLists { get; }
+        public string PagedControlID { get; set; }
+        public override TemplateGroupCollection TemplateGroups { get; }
+        protected override bool UsePreviewControl { get; }
+        public override string GetDesignTimeHtml();
+        protected override string GetEmptyDesignTimeHtml();
+        public override void Initialize(IComponent component);
+        protected override void PreFilterProperties(IDictionary properties);
+    }
+    public class DataPagerFieldTypeEditor : UITypeEditor {
+        public DataPagerFieldTypeEditor();
+        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value);
+        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context);
+    }
+    public class DataProviderNameConverter : StringConverter {
+        public DataProviderNameConverter();
+        public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context);
+        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context);
+        public override bool GetStandardValuesSupported(ITypeDescriptorContext context);
+    }
+    public class DataSourceIDConverter : TypeConverter {
+        public DataSourceIDConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context);
+        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context);
+        public override bool GetStandardValuesSupported(ITypeDescriptorContext context);
+        protected virtual bool IsValidDataSource(IComponent component);
+    }
+    public class DetailsViewDesigner : DataBoundControlDesigner {
+        public DetailsViewDesigner();
+        public override DesignerActionListCollection ActionLists { get; }
+        public override DesignerAutoFormatCollection AutoFormats { get; }
+        protected override int SampleRowCount { get; }
+        public override TemplateGroupCollection TemplateGroups { get; }
+        protected override bool UsePreviewControl { get; }
+        protected override void DataBind(BaseDataBoundControl dataBoundControl);
+        public override string GetDesignTimeHtml();
+        public override string GetDesignTimeHtml(DesignerRegionCollection regions);
+        public override string GetEditableDesignerRegionContent(EditableDesignerRegion region);
+        public override void Initialize(IComponent component);
+        protected override void OnClick(DesignerRegionMouseEventArgs e);
+        protected override void OnSchemaRefreshed();
+        protected override void PreFilterProperties(IDictionary properties);
+        public override void SetEditableDesignerRegionContent(EditableDesignerRegion region, string content);
+    }
+    public class EmbeddedMailObjectCollectionEditor : CollectionEditor {
+        public EmbeddedMailObjectCollectionEditor(Type type);
+        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value);
+    }
+    public class EntityDataSourceDesigner : DataSourceDesigner {
+        public EntityDataSourceDesigner();
+        public override bool CanConfigure { get; }
+        public override bool CanRefreshSchema { get; }
+        public string CommandText { get; set; }
+        public string ConnectionString { get; set; }
+        public string DefaultContainerName { get; set; }
+        public string EntitySetName { get; set; }
+        public string EntityTypeFilter { get; set; }
+        public string OrderBy { get; set; }
+        public string Select { get; set; }
+        public string Where { get; set; }
+        public override void Configure();
+        public override DesignerDataSourceView GetView(string viewName);
+        public override string[] GetViewNames();
+        public override void Initialize(IComponent component);
+        protected override void PreFilterProperties(IDictionary properties);
+        public override void RefreshSchema(bool preferSilent);
+    }
+    public class EntityDesignerDataSourceView : DesignerDataSourceView {
+        public EntityDesignerDataSourceView(EntityDataSourceDesigner owner);
+        public override bool CanDelete { get; }
+        public override bool CanInsert { get; }
+        public override bool CanPage { get; }
+        public override bool CanSort { get; }
+        public override bool CanUpdate { get; }
+        public override IDataSourceViewSchema Schema { get; }
+        public override IEnumerable GetDesignTimeData(int minimumRows, out bool isSampleData);
+    }
+    public class FormViewDesigner : DataBoundControlDesigner {
+        public FormViewDesigner();
+        public override DesignerActionListCollection ActionLists { get; }
+        public override DesignerAutoFormatCollection AutoFormats { get; }
+        public bool RenderOuterTable { get; set; }
+        protected override int SampleRowCount { get; }
+        public override TemplateGroupCollection TemplateGroups { get; }
+        protected override bool UsePreviewControl { get; }
+        public override string GetDesignTimeHtml();
+        protected override string GetEmptyDesignTimeHtml();
+        public override void Initialize(IComponent component);
+        protected override void OnSchemaRefreshed();
+        protected override void PreFilterProperties(IDictionary properties);
+    }
+    public class GridViewDesigner : DataBoundControlDesigner {
+        public GridViewDesigner();
+        public override DesignerActionListCollection ActionLists { get; }
+        public override DesignerAutoFormatCollection AutoFormats { get; }
+        protected override int SampleRowCount { get; }
+        public override TemplateGroupCollection TemplateGroups { get; }
+        protected override bool UsePreviewControl { get; }
+        protected override void DataBind(BaseDataBoundControl dataBoundControl);
+        public override string GetDesignTimeHtml();
+        public override string GetDesignTimeHtml(DesignerRegionCollection regions);
+        public override string GetEditableDesignerRegionContent(EditableDesignerRegion region);
+        public override void Initialize(IComponent component);
+        protected override void OnClick(DesignerRegionMouseEventArgs e);
+        protected override void OnSchemaRefreshed();
+        protected override void PreFilterProperties(IDictionary properties);
+        public override void SetEditableDesignerRegionContent(EditableDesignerRegion region, string content);
+    }
+    public class HiddenFieldDesigner : ControlDesigner {
+        public HiddenFieldDesigner();
+        public override string GetDesignTimeHtml();
+        public override void Initialize(IComponent component);
+    }
+    public class HierarchicalDataBoundControlDesigner : BaseDataBoundControlDesigner {
+        public HierarchicalDataBoundControlDesigner();
+        public override DesignerActionListCollection ActionLists { get; }
+        public IHierarchicalDataSourceDesigner DataSourceDesigner { get; }
+        public DesignerHierarchicalDataSourceView DesignerView { get; }
+        protected virtual bool UseDataSourcePickerActionList { get; }
+        protected override bool ConnectToDataSource();
+        protected override void CreateDataSource();
+        protected override void DataBind(BaseDataBoundControl dataBoundControl);
+        protected override void DisconnectFromDataSource();
+        protected virtual IHierarchicalEnumerable GetDesignTimeDataSource();
+        protected virtual IHierarchicalEnumerable GetSampleDataSource();
+        protected override void PreFilterProperties(IDictionary properties);
+    }
+    public class HierarchicalDataSourceIDConverter : DataSourceIDConverter {
+        public HierarchicalDataSourceIDConverter();
+        protected override bool IsValidDataSource(IComponent component);
+    }
+    public class HotSpotCollectionEditor : CollectionEditor {
+        public HotSpotCollectionEditor(Type type);
+        protected override string HelpTopic { get; }
+        protected override bool CanSelectMultipleInstances();
+        protected override Type[] CreateNewItemTypes();
+    }
+    public class HyperLinkDesigner : TextControlDesigner {
+        public HyperLinkDesigner();
+        public override string GetDesignTimeHtml();
+        public override void OnComponentChanged(object sender, ComponentChangedEventArgs ce);
+    }
+    public class LabelDesigner : TextControlDesigner {
+        public LabelDesigner();
+        public override void OnComponentChanged(object sender, ComponentChangedEventArgs ce);
+    }
+    public class LinkButtonDesigner : TextControlDesigner {
+        public LinkButtonDesigner();
+    }
+    public class LinqDataSourceDesigner : DataSourceDesigner {
+        public LinqDataSourceDesigner();
+        public override DesignerActionListCollection ActionLists { get; }
+        public override bool CanConfigure { get; }
+        public override bool CanRefreshSchema { get; }
+        public string ContextTypeName { get; set; }
+        public string Delete { get; set; }
+        public bool EnableDelete { get; set; }
+        public bool EnableInsert { get; set; }
+        public bool EnableUpdate { get; set; }
+        public string GroupBy { get; set; }
+        public string Insert { get; set; }
+        public string OrderBy { get; set; }
+        public string OrderGroupsBy { get; set; }
+        public string Select { get; set; }
+        public IServiceProvider ServiceProvider { get; }
+        public string TableName { get; set; }
+        public string Update { get; set; }
+        public string Where { get; set; }
+        public override void Configure();
+        public override DesignerDataSourceView GetView(string viewName);
+        public override string[] GetViewNames();
+        public override void Initialize(IComponent component);
+        protected override void PreFilterProperties(IDictionary properties);
+        public override void RefreshSchema(bool preferSilent);
+    }
+    public class LinqDesignerDataSourceView : DesignerDataSourceView {
+        public LinqDesignerDataSourceView(LinqDataSourceDesigner owner);
+        public override bool CanDelete { get; }
+        public override bool CanInsert { get; }
+        public override bool CanPage { get; }
+        public override bool CanSort { get; }
+        public override bool CanUpdate { get; }
+        public bool IsDataContext { get; }
+        public bool IsTableTypeTable { get; }
+        public override IDataSourceViewSchema Schema { get; }
+        public override IEnumerable GetDesignTimeData(int minimumRows, out bool isSampleData);
+    }
+    public class ListControlDataBindingHandler : DataBindingHandler {
+        public ListControlDataBindingHandler();
+        public override void DataBindControl(IDesignerHost designerHost, Control control);
+    }
+    public class ListControlDesigner : DataBoundControlDesigner {
+        public ListControlDesigner();
+        public override DesignerActionListCollection ActionLists { get; }
+        public string DataTextField { get; set; }
+        public string DataValueField { get; set; }
+        protected override bool UseDataSourcePickerActionList { get; }
+        protected override void DataBind(BaseDataBoundControl dataBoundControl);
+        public override string GetDesignTimeHtml();
+        public IEnumerable GetResolvedSelectedDataSource();
+        public object GetSelectedDataSource();
+        public override void Initialize(IComponent component);
+        public virtual void OnDataSourceChanged();
+        protected override void OnDataSourceChanged(bool forceUpdateView);
+        protected override void PreFilterProperties(IDictionary properties);
+    }
+    public class ListItemsCollectionEditor : CollectionEditor {
+        public ListItemsCollectionEditor(Type type);
+        protected override string HelpTopic { get; }
+        protected override bool CanSelectMultipleInstances();
+    }
+    public class ListViewDesigner : DataBoundControlDesigner {
+        public ListViewDesigner();
+        public override DesignerActionListCollection ActionLists { get; }
+        protected override int SampleRowCount { get; }
+        protected override bool UsePreviewControl { get; }
+        public override string GetDesignTimeHtml();
+        public override string GetDesignTimeHtml(DesignerRegionCollection regions);
+        public override string GetEditableDesignerRegionContent(EditableDesignerRegion region);
+        protected override string GetEmptyDesignTimeHtml();
+        public override void Initialize(IComponent component);
+        public override void OnComponentChanged(object sender, ComponentChangedEventArgs ce);
+        protected override void OnSchemaRefreshed();
+        public override void SetEditableDesignerRegionContent(EditableDesignerRegion region, string content);
+    }
+    public class LiteralDesigner : ControlDesigner {
+        public LiteralDesigner();
+        public override void OnComponentChanged(object sender, ComponentChangedEventArgs ce);
+    }
+    public class LoginDesigner : CompositeControlDesigner {
+        public LoginDesigner();
+        public override DesignerActionListCollection ActionLists { get; }
+        public override bool AllowResize { get; }
+        public override DesignerAutoFormatCollection AutoFormats { get; }
+        public bool RenderOuterTable { get; set; }
+        public override TemplateGroupCollection TemplateGroups { get; }
+        protected override bool UsePreviewControl { get; }
+        public override string GetDesignTimeHtml(DesignerRegionCollection regions);
+        public override string GetEditableDesignerRegionContent(EditableDesignerRegion region);
+        protected override string GetErrorDesignTimeHtml(Exception e);
+        public override void Initialize(IComponent component);
+        protected override void PreFilterProperties(IDictionary properties);
+        public override void SetEditableDesignerRegionContent(EditableDesignerRegion region, string content);
+    }
+    public class LoginNameDesigner : ControlDesigner {
+        public LoginNameDesigner();
+        protected override bool UsePreviewControl { get; }
+        protected override string GetErrorDesignTimeHtml(Exception e);
+    }
+    public class LoginStatusDesigner : CompositeControlDesigner {
+        public LoginStatusDesigner();
+        public override DesignerActionListCollection ActionLists { get; }
+        protected override bool UsePreviewControl { get; }
+        public override string GetDesignTimeHtml();
+        public override void Initialize(IComponent component);
+    }
+    public class LoginViewDesigner : ControlDesigner {
+        public LoginViewDesigner();
+        public override DesignerActionListCollection ActionLists { get; }
+        public override TemplateGroupCollection TemplateGroups { get; }
+        protected override bool UsePreviewControl { get; }
+        public override string GetDesignTimeHtml();
+        public override string GetDesignTimeHtml(DesignerRegionCollection regions);
+        public override string GetEditableDesignerRegionContent(EditableDesignerRegion region);
+        protected override string GetEmptyDesignTimeHtml();
+        protected override string GetErrorDesignTimeHtml(Exception e);
+        public override void Initialize(IComponent component);
+        public override void OnComponentChanged(object sender, ComponentChangedEventArgs e);
+        protected override void PreFilterProperties(IDictionary properties);
+        public override void SetEditableDesignerRegionContent(EditableDesignerRegion region, string content);
+    }
+    public class MailDefinitionBodyFileNameEditor : UrlEditor {
+        public MailDefinitionBodyFileNameEditor();
+        protected override string Caption { get; }
+        protected override string Filter { get; }
+    }
+    public class MenuBindingsEditor : UITypeEditor {
+        public MenuBindingsEditor();
+        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value);
+        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context);
+    }
+    public class MenuDesigner : HierarchicalDataBoundControlDesigner, IDataBindingSchemaProvider {
+        public MenuDesigner();
+        public override DesignerActionListCollection ActionLists { get; }
+        public override DesignerAutoFormatCollection AutoFormats { get; }
+        protected bool CanRefreshSchema { get; }
+        protected IDataSourceViewSchema Schema { get; }
+        bool System.Web.UI.Design.IDataBindingSchemaProvider.CanRefreshSchema { get; }
+        IDataSourceViewSchema System.Web.UI.Design.IDataBindingSchemaProvider.Schema { get; }
+        public override TemplateGroupCollection TemplateGroups { get; }
+        protected override bool UsePreviewControl { get; }
+        protected override void DataBind(BaseDataBoundControl dataBoundControl);
+        public override string GetDesignTimeHtml();
+        protected override string GetEmptyDesignTimeHtml();
+        protected override string GetErrorDesignTimeHtml(Exception e);
+        protected override IHierarchicalEnumerable GetSampleDataSource();
+        public override void Initialize(IComponent component);
+        protected void RefreshSchema(bool preferSilent);
+        void System.Web.UI.Design.IDataBindingSchemaProvider.RefreshSchema(bool preferSilent);
+    }
+    public class MenuItemCollectionEditor : UITypeEditor {
+        public MenuItemCollectionEditor();
+        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value);
+        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context);
+    }
+    public class MenuItemStyleCollectionEditor : CollectionEditor {
+        public MenuItemStyleCollectionEditor(Type type);
+        protected override bool CanSelectMultipleInstances();
+        protected override CollectionEditor.CollectionForm CreateCollectionForm();
+        protected override object CreateInstance(Type itemType);
+        protected override Type[] CreateNewItemTypes();
+    }
+    public class MultiViewDesigner : ContainerControlDesigner {
+        public MultiViewDesigner();
+        protected override bool NoWrap { get; }
+    }
+    public class ObjectDataSourceDesigner : DataSourceDesigner {
+        public ObjectDataSourceDesigner();
+        public override bool CanConfigure { get; }
+        public override bool CanRefreshSchema { get; }
+        public string SelectMethod { get; set; }
+        public string TypeName { get; set; }
+        public override void Configure();
+        public override DesignerDataSourceView GetView(string viewName);
+        public override string[] GetViewNames();
+        protected override void PreFilterProperties(IDictionary properties);
+        public override void RefreshSchema(bool preferSilent);
+    }
+    public class ObjectDesignerDataSourceView : DesignerDataSourceView {
+        public ObjectDesignerDataSourceView(ObjectDataSourceDesigner owner, string viewName);
+        public override bool CanDelete { get; }
+        public override bool CanInsert { get; }
+        public override bool CanPage { get; }
+        public override bool CanRetrieveTotalRowCount { get; }
+        public override bool CanSort { get; }
+        public override bool CanUpdate { get; }
+        public override IDataSourceViewSchema Schema { get; }
+        public override IEnumerable GetDesignTimeData(int minimumRows, out bool isSampleData);
+    }
+    public class PanelContainerDesigner : ContainerControlDesigner {
+        public PanelContainerDesigner();
+        public override string FrameCaption { get; }
+        public override Style FrameStyle { get; }
+        protected override bool UsePreviewControl { get; }
+        protected override void AddDesignTimeCssAttributes(IDictionary styleAttributes);
+        public override void Initialize(IComponent component);
+    }
+    public class PanelDesigner : ReadWriteControlDesigner {
+        public PanelDesigner();
+        protected override void MapPropertyToStyle(string propName, object varPropValue);
+        protected override void OnBehaviorAttached();
+    }
+    public class ParameterCollectionEditor : UITypeEditor {
+        public ParameterCollectionEditor();
+        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value);
+        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context);
+    }
+    public class ParameterEditorUserControl : UserControl {
+        public ParameterEditorUserControl(IServiceProvider serviceProvider);
+        public bool ParametersConfigured { get; }
+        public TypeDescriptionProvider TypeDescriptionProvider { get; }
+        public event EventHandler ParametersChanged;
+        public void AddParameters(Parameter[] parameters);
+        public void ClearParameters();
+        public Parameter[] GetParameters();
+        protected virtual void OnParametersChanged(object sender, EventArgs e);
+        public void SetAllowCollectionChanges(bool allowChanges);
+    }
+    public class PasswordRecoveryDesigner : ControlDesigner {
+        public PasswordRecoveryDesigner();
+        public override DesignerActionListCollection ActionLists { get; }
+        public override bool AllowResize { get; }
+        public override DesignerAutoFormatCollection AutoFormats { get; }
+        public bool RenderOuterTable { get; set; }
+        public override TemplateGroupCollection TemplateGroups { get; }
+        protected override bool UsePreviewControl { get; }
+        public override string GetDesignTimeHtml();
+        public override string GetDesignTimeHtml(DesignerRegionCollection regions);
+        public override string GetEditableDesignerRegionContent(EditableDesignerRegion region);
+        protected override string GetErrorDesignTimeHtml(Exception e);
+        public override void Initialize(IComponent component);
+        protected override void PreFilterProperties(IDictionary properties);
+        public override void SetEditableDesignerRegionContent(EditableDesignerRegion region, string content);
+    }
+    public class PreviewControlDesigner : ControlDesigner {
+        public PreviewControlDesigner();
+        protected override bool UsePreviewControl { get; }
+    }
+    public class RegexEditorDialog : Form {
+        public RegexEditorDialog(ISite site);
+        public string RegularExpression { get; set; }
+        protected void cmdHelp_Click(object sender, EventArgs e);
+        protected void cmdOK_Click(object sender, EventArgs e);
+        protected void cmdTestValidate_Click(object sender, EventArgs args);
+        protected override void Dispose(bool disposing);
+        protected void lstStandardExpressions_SelectedIndexChanged(object sender, EventArgs e);
+        protected void RegexTypeEditor_Activated(object sender, EventArgs e);
+        protected void txtExpression_TextChanged(object sender, EventArgs e);
+    }
+    public class RegexTypeEditor : UITypeEditor {
+        public RegexTypeEditor();
+        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value);
+        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context);
+    }
+    public class RepeaterDesigner : ControlDesigner, IDataSourceProvider {
+        public RepeaterDesigner();
+        public override DesignerActionListCollection ActionLists { get; }
+        public string DataMember { get; set; }
+        public string DataSource { get; set; }
+        public IDataSourceDesigner DataSourceDesigner { get; }
+        public string DataSourceID { get; set; }
+        public DesignerDataSourceView DesignerView { get; }
+        protected bool TemplatesExist { get; }
+        protected override void Dispose(bool disposing);
+        protected virtual void ExecuteChooseDataSourcePostSteps();
+        protected IEnumerable GetDesignTimeDataSource(IEnumerable selectedDataSource, int minimumRows);
+        protected IEnumerable GetDesignTimeDataSource(int minimumRows);
+        public override string GetDesignTimeHtml();
+        protected override string GetEmptyDesignTimeHtml();
+        protected override string GetErrorDesignTimeHtml(Exception e);
+        public IEnumerable GetResolvedSelectedDataSource();
+        public object GetSelectedDataSource();
+        public override void Initialize(IComponent component);
+        public override void OnComponentChanged(object source, ComponentChangedEventArgs ce);
+        public virtual void OnDataSourceChanged();
+        protected override void PreFilterProperties(IDictionary properties);
+    }
+    public class RoleGroupCollectionEditor : CollectionEditor {
+        public RoleGroupCollectionEditor(Type type);
+        protected override bool CanSelectMultipleInstances();
+    }
+    public class SiteMapDataSourceDesigner : HierarchicalDataSourceDesigner, IDataSourceDesigner {
+        public SiteMapDataSourceDesigner();
+        public override bool CanRefreshSchema { get; }
+        bool System.Web.UI.Design.IDataSourceDesigner.CanConfigure { get; }
+        bool System.Web.UI.Design.IDataSourceDesigner.CanRefreshSchema { get; }
+        event EventHandler System.Web.UI.Design.IDataSourceDesigner.DataSourceChanged;
+        event EventHandler System.Web.UI.Design.IDataSourceDesigner.SchemaRefreshed;
+        public override DesignerHierarchicalDataSourceView GetView(string viewPath);
+        public virtual string[] GetViewNames();
+        public override void Initialize(IComponent component);
+        public override void OnComponentChanged(object sender, ComponentChangedEventArgs e);
+        public override void RefreshSchema(bool preferSilent);
+        void System.Web.UI.Design.IDataSourceDesigner.Configure();
+        DesignerDataSourceView System.Web.UI.Design.IDataSourceDesigner.GetView(string viewName);
+        string[] System.Web.UI.Design.IDataSourceDesigner.GetViewNames();
+        void System.Web.UI.Design.IDataSourceDesigner.RefreshSchema(bool preferSilent);
+        void System.Web.UI.Design.IDataSourceDesigner.ResumeDataSourceEvents();
+        void System.Web.UI.Design.IDataSourceDesigner.SuppressDataSourceEvents();
+    }
+    public class SiteMapDesignerDataSourceView : DesignerDataSourceView {
+        public SiteMapDesignerDataSourceView(SiteMapDataSourceDesigner owner, string viewName);
+        public override IDataSourceViewSchema Schema { get; }
+        public override IEnumerable GetDesignTimeData(int minimumRows, out bool isSampleData);
+    }
+    public class SiteMapDesignerHierarchicalDataSourceView : DesignerHierarchicalDataSourceView {
+        public SiteMapDesignerHierarchicalDataSourceView(SiteMapDataSourceDesigner owner, string viewPath);
+        public override IDataSourceSchema Schema { get; }
+        public override IHierarchicalEnumerable GetDesignTimeData(out bool isSampleData);
+    }
+    public class SiteMapPathDesigner : ControlDesigner {
+        public SiteMapPathDesigner();
+        public override DesignerAutoFormatCollection AutoFormats { get; }
+        public override TemplateGroupCollection TemplateGroups { get; }
+        protected override bool UsePreviewControl { get; }
+        public override string GetDesignTimeHtml();
+        protected override string GetErrorDesignTimeHtml(Exception e);
+        public override void Initialize(IComponent component);
+    }
+    public class SqlDataSourceConnectionStringEditor : ConnectionStringEditor {
+        public SqlDataSourceConnectionStringEditor();
+        protected override string GetProviderName(object instance);
+        protected override void SetProviderName(object instance, DesignerDataConnection connection);
+    }
+    public class SqlDataSourceDesigner : DataSourceDesigner {
+        public SqlDataSourceDesigner();
+        public override bool CanConfigure { get; }
+        public override bool CanRefreshSchema { get; }
+        public string ConnectionString { get; set; }
+        public DataSourceOperation DeleteQuery { get; set; }
+        public DataSourceOperation InsertQuery { get; set; }
+        public string ProviderName { get; set; }
+        public string SelectCommand { get; set; }
+        public DataSourceOperation SelectQuery { get; set; }
+        public DataSourceOperation UpdateQuery { get; set; }
+        public override void Configure();
+        protected virtual SqlDesignerDataSourceView CreateView(string viewName);
+        protected virtual void DeriveParameters(string providerName, DbCommand command);
+        protected virtual string GetConnectionString();
+        public override DesignerDataSourceView GetView(string viewName);
+        public override string[] GetViewNames();
+        protected internal virtual Parameter[] InferParameterNames(DesignerDataConnection connection, string commandText, SqlDataSourceCommandType commandType);
+        protected override void PreFilterProperties(IDictionary properties);
+        public override void RefreshSchema(bool preferSilent);
+    }
+    public class SqlDesignerDataSourceView : DesignerDataSourceView {
+        public SqlDesignerDataSourceView(SqlDataSourceDesigner owner, string viewName);
+        public override bool CanDelete { get; }
+        public override bool CanInsert { get; }
+        public override bool CanPage { get; }
+        public override bool CanRetrieveTotalRowCount { get; }
+        public override bool CanSort { get; }
+        public override bool CanUpdate { get; }
+        public override IDataSourceViewSchema Schema { get; }
+        public override IEnumerable GetDesignTimeData(int minimumRows, out bool isSampleData);
+    }
+    public class StyleCollectionEditor : CollectionEditor {
+        public StyleCollectionEditor(Type type);
+        protected override object CreateInstance(Type itemType);
+    }
+    public class SubMenuStyleCollectionEditor : CollectionEditor {
+        public SubMenuStyleCollectionEditor(Type type);
+        protected override bool CanSelectMultipleInstances();
+        protected override CollectionEditor.CollectionForm CreateCollectionForm();
+        protected override object CreateInstance(Type itemType);
+        protected override Type[] CreateNewItemTypes();
+    }
+    public class SubstitutionDesigner : ControlDesigner {
+        public SubstitutionDesigner();
+        public override string GetDesignTimeHtml();
+    }
+    public class TableCellsCollectionEditor : CollectionEditor {
+        public TableCellsCollectionEditor(Type type);
+        protected override bool CanSelectMultipleInstances();
+        protected override object CreateInstance(Type itemType);
+    }
+    public class TableDesigner : ControlDesigner {
+        public TableDesigner();
+        public override string GetDesignTimeHtml();
+    }
+    public class TableRowsCollectionEditor : CollectionEditor {
+        public TableRowsCollectionEditor(Type type);
+        protected override bool CanSelectMultipleInstances();
+        protected override object CreateInstance(Type itemType);
+    }
+    public class TreeNodeBindingDepthConverter : Int32Converter {
+        public TreeNodeBindingDepthConverter();
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public class TreeNodeCollectionEditor : UITypeEditor {
+        public TreeNodeCollectionEditor();
+        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value);
+        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context);
+    }
+    public class TreeNodeStyleCollectionEditor : StyleCollectionEditor {
+        public TreeNodeStyleCollectionEditor(Type type);
+        protected override Type CreateCollectionItemType();
+    }
+    public class TreeViewBindingsEditor : UITypeEditor {
+        public TreeViewBindingsEditor();
+        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value);
+        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context);
+    }
+    public class TreeViewDesigner : HierarchicalDataBoundControlDesigner {
+        public TreeViewDesigner();
+        public override DesignerActionListCollection ActionLists { get; }
+        public override DesignerAutoFormatCollection AutoFormats { get; }
+        protected override bool UsePreviewControl { get; }
+        protected void CreateLineImages();
+        protected override void DataBind(BaseDataBoundControl dataBoundControl);
+        protected void EditBindings();
+        protected void EditNodes();
+        public override string GetDesignTimeHtml();
+        protected override string GetEmptyDesignTimeHtml();
+        protected override string GetErrorDesignTimeHtml(Exception e);
+        protected override IHierarchicalEnumerable GetSampleDataSource();
+        public override void Initialize(IComponent component);
+    }
+    public class ValidationSummaryDesigner : PreviewControlDesigner {
+        public ValidationSummaryDesigner();
+        protected override Control CreateViewControl();
+        protected override void PreFilterProperties(IDictionary properties);
+    }
+    public class ViewDesigner : ContainerControlDesigner {
+        public ViewDesigner();
+        protected override bool NoWrap { get; }
+        public override string GetDesignTimeHtml();
+        public override string GetDesignTimeHtml(DesignerRegionCollection regions);
+        public override void Initialize(IComponent component);
+    }
+    public class WizardDesigner : CompositeControlDesigner {
+        public WizardDesigner();
+        public override DesignerActionListCollection ActionLists { get; }
+        public override DesignerAutoFormatCollection AutoFormats { get; }
+        protected bool DisplaySideBar { get; set; }
+        public override TemplateGroupCollection TemplateGroups { get; }
+        protected override bool UsePreviewControl { get; }
+        protected virtual void AddDesignerRegions(DesignerRegionCollection regions);
+        protected virtual void ConvertToCustomNavigationTemplate();
+        protected void ConvertToTemplate(string description, IComponent component, string templateName, string[] keys);
+        protected override void CreateChildControls();
+        public override string GetDesignTimeHtml();
+        public override string GetDesignTimeHtml(DesignerRegionCollection regions);
+        public override string GetEditableDesignerRegionContent(EditableDesignerRegion region);
+        public override void Initialize(IComponent component);
+        protected override void OnClick(DesignerRegionMouseEventArgs e);
+        public override void OnComponentChanged(object sender, ComponentChangedEventArgs ce);
+        protected override void PreFilterProperties(IDictionary properties);
+        protected void ResetTemplate(string description, IComponent component, string templateName);
+        public override void SetEditableDesignerRegionContent(EditableDesignerRegion region, string content);
+    }
+    public class WizardStepCollectionEditor : CollectionEditor {
+        public WizardStepCollectionEditor(Type type);
+        protected override bool CanSelectMultipleInstances();
+        protected override CollectionEditor.CollectionForm CreateCollectionForm();
+        protected override object CreateInstance(Type itemType);
+        protected override Type[] CreateNewItemTypes();
+    }
+    public class WizardStepEditableRegion : EditableDesignerRegion, IWizardStepEditableRegion {
+        public WizardStepEditableRegion(WizardDesigner designer, WizardStepBase wizardStep);
+        public WizardStepBase Step { get; }
+    }
+    public class WizardStepTemplatedEditableRegion : TemplatedEditableDesignerRegion, IWizardStepEditableRegion {
+        public WizardStepTemplatedEditableRegion(TemplateDefinition templateDefinition, WizardStepBase wizardStep);
+        public WizardStepBase Step { get; }
+    }
+    public class XmlDataSourceDesigner : HierarchicalDataSourceDesigner, IDataSourceDesigner {
+        public XmlDataSourceDesigner();
+        public override bool CanConfigure { get; }
+        public override bool CanRefreshSchema { get; }
+        public string Data { get; set; }
+        public string DataFile { get; set; }
+        bool System.Web.UI.Design.IDataSourceDesigner.CanConfigure { get; }
+        bool System.Web.UI.Design.IDataSourceDesigner.CanRefreshSchema { get; }
+        public string Transform { get; set; }
+        public string TransformFile { get; set; }
+        public string XPath { get; set; }
+        event EventHandler System.Web.UI.Design.IDataSourceDesigner.DataSourceChanged;
+        event EventHandler System.Web.UI.Design.IDataSourceDesigner.SchemaRefreshed;
+        public override void Configure();
+        public override DesignerHierarchicalDataSourceView GetView(string viewPath);
+        public override void Initialize(IComponent component);
+        protected override void PreFilterProperties(IDictionary properties);
+        public override void RefreshSchema(bool preferSilent);
+        void System.Web.UI.Design.IDataSourceDesigner.Configure();
+        DesignerDataSourceView System.Web.UI.Design.IDataSourceDesigner.GetView(string viewName);
+        string[] System.Web.UI.Design.IDataSourceDesigner.GetViewNames();
+        void System.Web.UI.Design.IDataSourceDesigner.RefreshSchema(bool preferSilent);
+        void System.Web.UI.Design.IDataSourceDesigner.ResumeDataSourceEvents();
+        void System.Web.UI.Design.IDataSourceDesigner.SuppressDataSourceEvents();
+    }
+    public class XmlDesigner : ControlDesigner {
+        public XmlDesigner();
+        protected override void Dispose(bool disposing);
+        public override string GetDesignTimeHtml();
+        protected override string GetEmptyDesignTimeHtml();
+        public override void Initialize(IComponent component);
+    }
+    public class XmlDesignerDataSourceView : DesignerDataSourceView {
+        public XmlDesignerDataSourceView(XmlDataSourceDesigner owner, string viewName);
+        public override IDataSourceViewSchema Schema { get; }
+        public override IEnumerable GetDesignTimeData(int minimumRows, out bool isSampleData);
+    }
+    public class XmlDesignerHierarchicalDataSourceView : DesignerHierarchicalDataSourceView {
+        public XmlDesignerHierarchicalDataSourceView(XmlDataSourceDesigner owner, string viewPath);
+        public override IDataSourceSchema Schema { get; }
+        public override IHierarchicalEnumerable GetDesignTimeData(out bool isSampleData);
+    }
+}
```

