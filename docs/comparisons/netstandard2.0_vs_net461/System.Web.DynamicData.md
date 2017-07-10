# System.Web.DynamicData

``` diff
+namespace System.Web.DynamicData {
+    public enum ContainerType {
+        Item = 1,
+        List = 0,
+    }
+    public class ContextConfiguration {
+        public ContextConfiguration();
+        public Func<Type, TypeDescriptionProvider> MetadataProviderFactory { get; set; }
+        public bool ScaffoldAllTables { get; set; }
+    }
+    public class ControlFilterExpression : DataSourceExpression {
+        public ControlFilterExpression();
+        public string Column { get; set; }
+        public string ControlID { get; set; }
+        public override IQueryable GetQueryable(IQueryable source);
+        protected override void LoadViewState(object savedState);
+        protected override object SaveViewState();
+        public override void SetContext(Control owner, HttpContext context, IQueryableDataSource dataSource);
+        protected override void TrackViewState();
+    }
+    public class DataControlReference {
+        public DataControlReference();
+        public string ControlID { get; set; }
+        public DynamicDataManager Owner { get; internal set; }
+        public override string ToString();
+    }
+    public class DataControlReferenceCollection : Collection<DataControlReference> {
+        public DataControlReferenceCollection(DynamicDataManager owner);
+        public DynamicDataManager Owner { get; private set; }
+        protected override void InsertItem(int index, DataControlReference item);
+        protected override void RemoveItem(int index);
+        protected override void SetItem(int index, DataControlReference item);
+    }
+    public class DefaultAutoFieldGenerator : IAutoFieldGenerator {
+        public DefaultAutoFieldGenerator(MetaTable table);
+        protected virtual DynamicField CreateField(MetaColumn column, ContainerType containerType, DataBoundControlMode mode);
+        public ICollection GenerateFields(Control control);
+    }
+    public class DynamicControl : Control, IAttributeAccessor, IFieldFormattingOptions, IFieldTemplateHost {
+        public DynamicControl();
+        public DynamicControl(DataBoundControlMode mode);
+        public bool ApplyFormatInEditMode { get; set; }
+        public MetaColumn Column { get; set; }
+        public bool ConvertEmptyStringToNull { get; set; }
+        public virtual string CssClass { get; set; }
+        public string DataField { get; set; }
+        public string DataFormatString { get; set; }
+        public Control FieldTemplate { get; private set; }
+        public bool HtmlEncode { get; set; }
+        public DataBoundControlMode Mode { get; set; }
+        public string NullDisplayText { get; set; }
+        IFieldFormattingOptions System.Web.DynamicData.IFieldTemplateHost.FormattingOptions { get; }
+        public virtual MetaTable Table { get; }
+        public virtual string UIHint { get; set; }
+        public virtual string ValidationGroup { get; set; }
+        public string GetAttribute(string key);
+        protected override void OnInit(EventArgs e);
+        protected override void Render(HtmlTextWriter writer);
+        public void SetAttribute(string key, string value);
+    }
+    public class DynamicControlParameter : Parameter, IWhereParametersProvider {
+        public DynamicControlParameter();
+        public DynamicControlParameter(string controlId);
+        public string ControlId { get; set; }
+        protected override object Evaluate(HttpContext context, Control control);
+        public virtual IEnumerable<Parameter> GetWhereParameters(IDynamicDataSource dataSource);
+    }
+    public static class DynamicDataExtensions {
+        public static object ConvertEditedValue(this IFieldFormattingOptions formattingOptions, string value);
+        public static void EnablePersistedSelection(this BaseDataBoundControl dataBoundControl);
+        public static void ExpandDynamicWhereParameters(this IDynamicDataSource dataSource);
+        public static IDynamicDataSource FindDataSourceControl(this Control current);
+        public static Control FindFieldTemplate(this Control control, string columnName);
+        public static MetaTable FindMetaTable(this Control current);
+        public static string FormatEditValue(this IFieldFormattingOptions formattingOptions, object fieldValue);
+        public static string FormatValue(this IFieldFormattingOptions formattingOptions, object fieldValue);
+        public static IDictionary<string, object> GetDefaultValues(this IDataSource dataSource);
+        public static IDictionary<string, object> GetDefaultValues(this INamingContainer control);
+        public static Type GetEnumType(this MetaColumn column);
+        public static MetaTable GetMetaTable(this IDataSource dataSource);
+        public static MetaTable GetMetaTable(this INamingContainer control);
+        public static MetaTable GetTable(this IDynamicDataSource dataSource);
+        public static void LoadWith<TEntity>(this LinqDataSource dataSource);
+        public static void LoadWithForeignKeys(this LinqDataSource dataSource, Type rowType);
+        public static void SetMetaTable(this INamingContainer control, MetaTable table);
+        public static void SetMetaTable(this INamingContainer control, MetaTable table, IDictionary<string, object> defaultValues);
+        public static void SetMetaTable(this INamingContainer control, MetaTable table, object defaultValues);
+        public static bool TryGetMetaTable(this IDataSource dataSource, out MetaTable table);
+        public static bool TryGetMetaTable(this INamingContainer control, out MetaTable table);
+    }
+    public class DynamicDataManager : Control {
+        public DynamicDataManager();
+        public bool AutoLoadForeignKeys { get; set; }
+        public override string ClientID { get; }
+        public override ClientIDMode ClientIDMode { get; set; }
+        public DataControlReferenceCollection DataControls { get; }
+        public override bool Visible { get; set; }
+        protected override void OnInit(EventArgs e);
+        protected override void OnLoad(EventArgs e);
+        public void RegisterControl(Control control);
+        public void RegisterControl(Control control, bool setSelectionFromUrl);
+    }
+    public class DynamicDataRoute : Route {
+        public DynamicDataRoute(string url);
+        public string Action { get; set; }
+        public MetaModel Model { get; set; }
+        public new DynamicDataRouteHandler RouteHandler { get; set; }
+        public string Table { get; set; }
+        public string ViewName { get; set; }
+        public string GetActionFromRouteData(RouteData routeData);
+        public override RouteData GetRouteData(HttpContextBase httpContext);
+        public MetaTable GetTableFromRouteData(RouteData routeData);
+        public override VirtualPathData GetVirtualPath(RequestContext requestContext, RouteValueDictionary values);
+    }
+    public class DynamicDataRouteHandler : IRouteHandler {
+        public DynamicDataRouteHandler();
+        public MetaModel Model { get; internal set; }
+        public virtual IHttpHandler CreateHandler(DynamicDataRoute route, MetaTable table, string action);
+        protected virtual string GetCustomPageVirtualPath(MetaTable table, string viewName);
+        public static RequestContext GetRequestContext(HttpContext httpContext);
+        public static MetaTable GetRequestMetaTable(HttpContext httpContext);
+        protected virtual string GetScaffoldPageVirtualPath(MetaTable table, string viewName);
+        public static void SetRequestMetaTable(HttpContext httpContext, MetaTable table);
+        IHttpHandler System.Web.Routing.IRouteHandler.GetHttpHandler(RequestContext requestContext);
+    }
+    public enum DynamicDataSourceOperation {
+        ContextCreate = 4,
+        Delete = 0,
+        Insert = 1,
+        Select = 2,
+        Update = 3,
+    }
+    public class DynamicEntity : Control {
+        public DynamicEntity();
+        public DataBoundControlMode Mode { get; set; }
+        public string UIHint { get; set; }
+        public string ValidationGroup { get; set; }
+        protected override void OnLoad(EventArgs e);
+        protected override void Render(HtmlTextWriter writer);
+    }
+    public class DynamicField : DataControlField, IAttributeAccessor, IFieldFormattingOptions {
+        public DynamicField();
+        public bool ApplyFormatInEditMode { get; set; }
+        protected MetaColumn Column { get; }
+        public bool ConvertEmptyStringToNull { get; set; }
+        public virtual string DataField { get; set; }
+        public string DataFormatString { get; set; }
+        public override string HeaderText { get; set; }
+        public bool HtmlEncode { get; set; }
+        public string NullDisplayText { get; set; }
+        public virtual bool ReadOnly { get; set; }
+        public override string SortExpression { get; set; }
+        public virtual string UIHint { get; set; }
+        public new ValidateRequestMode ValidateRequestMode { get; set; }
+        public virtual string ValidationGroup { get; set; }
+        protected virtual void ConfigureDynamicControl(DynamicControl control);
+        protected override void CopyProperties(DataControlField newField);
+        protected virtual DynamicControl CreateDynamicControl();
+        protected override DataControlField CreateField();
+        public override void ExtractValuesFromCell(IOrderedDictionary dictionary, DataControlFieldCell cell, DataControlRowState rowState, bool includeReadOnly);
+        public string GetAttribute(string key);
+        public override void InitializeCell(DataControlFieldCell cell, DataControlCellType cellType, DataControlRowState rowState, int rowIndex);
+        public void SetAttribute(string key, string value);
+    }
+    public class DynamicFilter : Control, IFilterExpressionProvider {
+        public DynamicFilter();
+        protected internal MetaColumn Column { get; private set; }
+        public string DataField { get; set; }
+        public Control FilterTemplate { get; }
+        public string FilterUIHint { get; set; }
+        public event EventHandler FilterChanged;
+        protected override void Render(HtmlTextWriter writer);
+        IQueryable System.Web.DynamicData.IFilterExpressionProvider.GetQueryable(IQueryable source);
+        void System.Web.DynamicData.IFilterExpressionProvider.Initialize(IQueryableDataSource dataSource);
+    }
+    public class DynamicFilterExpression : DataSourceExpression {
+        public DynamicFilterExpression();
+        public string ControlID { get; set; }
+        public override IQueryable GetQueryable(IQueryable source);
+        public override void SetContext(Control owner, HttpContext context, IQueryableDataSource dataSource);
+    }
+    public class DynamicHyperLink : HyperLink, IAttributeAccessor {
+        public DynamicHyperLink();
+        public string Action { get; set; }
+        public string ContextTypeName { get; set; }
+        public string DataField { get; set; }
+        public string TableName { get; set; }
+        protected override void OnDataBinding(EventArgs e);
+        protected override void OnPreRender(EventArgs e);
+        string System.Web.UI.IAttributeAccessor.GetAttribute(string key);
+        void System.Web.UI.IAttributeAccessor.SetAttribute(string key, string value);
+    }
+    public class DynamicQueryStringParameter : Parameter, IWhereParametersProvider {
+        public DynamicQueryStringParameter();
+        protected override object Evaluate(HttpContext context, Control control);
+        public virtual IEnumerable<Parameter> GetWhereParameters(IDynamicDataSource dataSource);
+    }
+    public class DynamicRouteExpression : DataSourceExpression {
+        public DynamicRouteExpression();
+        public string ColumnName { get; set; }
+        public override IQueryable GetQueryable(IQueryable source);
+        public override void SetContext(Control owner, HttpContext context, IQueryableDataSource dataSource);
+    }
+    public class DynamicValidator : BaseValidator {
+        public DynamicValidator();
+        public MetaColumn Column { get; set; }
+        public string ColumnName { get; }
+        protected virtual Exception ValidationException { get; set; }
+        protected override bool ControlPropertiesValid();
+        protected override bool EvaluateIsValid();
+        protected override void OnInit(EventArgs e);
+        protected virtual void ValidateException(Exception exception);
+    }
+    public class DynamicValidatorEventArgs : EventArgs {
+        public DynamicValidatorEventArgs(Exception exception, DynamicDataSourceOperation operation);
+        public Exception Exception { get; }
+        public DynamicDataSourceOperation Operation { get; }
+    }
+    public class EntityTemplate : Control {
+        public EntityTemplate();
+        public virtual ITemplate ItemTemplate { get; set; }
+    }
+    public class EntityTemplateFactory {
+        public EntityTemplateFactory();
+        public virtual string BuildEntityTemplateVirtualPath(string templateName, DataBoundControlMode mode);
+        public virtual EntityTemplateUserControl CreateEntityTemplate(MetaTable table, DataBoundControlMode mode, string uiHint);
+        public virtual string GetEntityTemplateVirtualPath(MetaTable table, DataBoundControlMode mode, string uiHint);
+    }
+    public class EntityTemplateUserControl : UserControl {
+        public EntityTemplateUserControl();
+        public virtual ContainerType ContainerType { get; }
+        public DataBoundControlMode Mode { get; internal set; }
+        public MetaTable Table { get; internal set; }
+        public string ValidationGroup { get; internal set; }
+    }
+    public class FieldTemplateFactory : IFieldTemplateFactory {
+        public FieldTemplateFactory();
+        public MetaModel Model { get; private set; }
+        public string TemplateFolderVirtualPath { get; set; }
+        public virtual string BuildVirtualPath(string templateName, MetaColumn column, DataBoundControlMode mode);
+        public virtual IFieldTemplate CreateFieldTemplate(MetaColumn column, DataBoundControlMode mode, string uiHint);
+        public virtual string GetFieldTemplateVirtualPath(MetaColumn column, DataBoundControlMode mode, string uiHint);
+        public virtual void Initialize(MetaModel model);
+        public virtual DataBoundControlMode PreprocessMode(MetaColumn column, DataBoundControlMode mode);
+    }
+    public class FieldTemplateUserControl : UserControl, IBindableControl, IFieldTemplate {
+        public FieldTemplateUserControl();
+        public MetaChildrenColumn ChildrenColumn { get; }
+        protected string ChildrenPath { get; }
+        public MetaColumn Column { get; }
+        public virtual ContainerType ContainerType { get; }
+        public virtual Control DataControl { get; }
+        public virtual object FieldValue { get; set; }
+        public virtual string FieldValueEditString { get; }
+        public virtual string FieldValueString { get; }
+        public MetaForeignKeyColumn ForeignKeyColumn { get; }
+        protected string ForeignKeyPath { get; }
+        public IFieldFormattingOptions FormattingOptions { get; private set; }
+        public IFieldTemplateHost Host { get; private set; }
+        public AttributeCollection MetadataAttributes { get; }
+        public DataBoundControlMode Mode { get; }
+        public virtual object Row { get; internal set; }
+        public MetaTable Table { get; }
+        protected string BuildChildrenPath(string path);
+        protected string BuildForeignKeyPath(string path);
+        protected virtual object ConvertEditedValue(string value);
+        protected virtual void ExtractForeignKey(IDictionary dictionary, string selectedValue);
+        protected virtual void ExtractValues(IOrderedDictionary dictionary);
+        protected FieldTemplateUserControl FindOtherFieldTemplate(string columnName);
+        public virtual string FormatFieldValue(object fieldValue);
+        protected virtual object GetColumnValue(MetaColumn column);
+        protected string GetSelectedValueString();
+        protected void IgnoreModelValidationAttribute(Type attributeType);
+        protected void PopulateListControl(ListControl listControl);
+        protected virtual void SetUpValidator(BaseValidator validator);
+        protected virtual void SetUpValidator(BaseValidator validator, MetaColumn column);
+        void System.Web.DynamicData.IFieldTemplate.SetHost(IFieldTemplateHost host);
+        void System.Web.UI.IBindableControl.ExtractValues(IOrderedDictionary dictionary);
+    }
+    public class FilterFactory {
+        public FilterFactory();
+        public virtual QueryableFilterUserControl CreateFilterControl(MetaColumn column, string filterUIHint);
+        public virtual string GetFilterVirtualPath(MetaColumn column, string filterUIHint);
+    }
+    public class FilterRepeater : Repeater, IWhereParametersProvider {
+        public FilterRepeater();
+        public string ContextTypeName { get; set; }
+        public string DynamicFilterContainerId { get; set; }
+        public MetaTable Table { get; }
+        public string TableName { get; set; }
+        public override bool Visible { get; set; }
+        public override void DataBind();
+        protected internal virtual IEnumerable<MetaColumn> GetFilteredColumns();
+        public virtual IEnumerable<Parameter> GetWhereParameters(IDynamicDataSource dataSource);
+        protected virtual void OnFilterItemCreated(RepeaterItem item);
+        protected override void OnInit(EventArgs e);
+        protected override void OnItemCreated(RepeaterItemEventArgs e);
+    }
+    public class FilterUserControlBase : UserControl, IControlParameterTarget {
+        public FilterUserControlBase();
+        public MetaColumn Column { get; }
+        public string ContextTypeName { get; set; }
+        public string DataField { get; set; }
+        public string InitialValue { get; }
+        public virtual DataKey SelectedDataKey { get; }
+        public virtual string SelectedValue { get; }
+        MetaColumn System.Web.DynamicData.IControlParameterTarget.FilteredColumn { get; }
+        MetaTable System.Web.DynamicData.IControlParameterTarget.Table { get; }
+        public string TableName { get; set; }
+        public void PopulateListControl(ListControl listControl);
+        string System.Web.DynamicData.IControlParameterTarget.GetPropertyNameExpression(string columnName);
+    }
+    public interface IControlParameterTarget {
+        MetaColumn FilteredColumn { get; }
+        MetaTable Table { get; }
+        string GetPropertyNameExpression(string columnName);
+    }
+    public interface IDynamicDataSource : IDataSource {
+        bool AutoGenerateWhereClause { get; set; }
+        Type ContextType { get; set; }
+        bool EnableDelete { get; set; }
+        bool EnableInsert { get; set; }
+        bool EnableUpdate { get; set; }
+        string EntitySetName { get; set; }
+        string Where { get; set; }
+        ParameterCollection WhereParameters { get; }
+        event EventHandler<DynamicValidatorEventArgs> Exception;
+    }
+    public interface IDynamicValidatorException {
+        IDictionary<string, Exception> InnerExceptions { get; }
+    }
+    public interface IFieldFormattingOptions {
+        bool ApplyFormatInEditMode { get; }
+        bool ConvertEmptyStringToNull { get; }
+        string DataFormatString { get; }
+        bool HtmlEncode { get; }
+        string NullDisplayText { get; }
+    }
+    public interface IFieldTemplate {
+        void SetHost(IFieldTemplateHost host);
+    }
+    public interface IFieldTemplateFactory {
+        IFieldTemplate CreateFieldTemplate(MetaColumn column, DataBoundControlMode mode, string uiHint);
+        void Initialize(MetaModel model);
+    }
+    public interface IFieldTemplateHost {
+        MetaColumn Column { get; }
+        IFieldFormattingOptions FormattingOptions { get; }
+        DataBoundControlMode Mode { get; }
+        string ValidationGroup { get; }
+    }
+    public interface IFilterExpressionProvider {
+        IQueryable GetQueryable(IQueryable source);
+        void Initialize(IQueryableDataSource dataSource);
+    }
+    public interface IWhereParametersProvider {
+        IEnumerable<Parameter> GetWhereParameters(IDynamicDataSource dataSource);
+    }
+    public class MetaChildrenColumn : MetaColumn, IMetaChildrenColumn, IMetaColumn {
+        public MetaChildrenColumn(MetaTable table, ColumnProvider entityMember);
+        public MetaTable ChildTable { get; private set; }
+        public MetaColumn ColumnInOtherTable { get; private set; }
+        public bool IsManyToMany { get; }
+        public string GetChildrenListPath(object row);
+        public string GetChildrenPath(string action, object row);
+        public string GetChildrenPath(string action, object row, string path);
+        protected internal override void Initialize();
+    }
+    public class MetaColumn : IFieldFormattingOptions, IMetaColumn {
+        public MetaColumn(MetaTable table, ColumnProvider columnProvider);
+        public bool AllowInitialValue { get; }
+        public bool ApplyFormatInEditMode { get; }
+        public AttributeCollection Attributes { get; }
+        public Type ColumnType { get; }
+        public bool ConvertEmptyStringToNull { get; }
+        public string DataFormatString { get; }
+        public DataTypeAttribute DataTypeAttribute { get; }
+        public object DefaultValue { get; }
+        public virtual string Description { get; }
+        public virtual string DisplayName { get; }
+        public PropertyInfo EntityTypeProperty { get; }
+        public string FilterUIHint { get; }
+        public bool HtmlEncode { get; }
+        public bool IsBinaryData { get; }
+        public bool IsCustomProperty { get; }
+        public bool IsFloatingPoint { get; }
+        public bool IsForeignKeyComponent { get; }
+        public bool IsGenerated { get; }
+        public bool IsInteger { get; }
+        public bool IsLongString { get; }
+        public bool IsPrimaryKey { get; }
+        public virtual bool IsReadOnly { get; }
+        public bool IsRequired { get; }
+        public bool IsString { get; }
+        public int MaxLength { get; }
+        public MetaModel Model { get; }
+        public string Name { get; }
+        public string NullDisplayText { get; }
+        public virtual string Prompt { get; }
+        public ColumnProvider Provider { get; private set; }
+        public string RequiredErrorMessage { get; }
+        public virtual bool Scaffold { get; set; }
+        public virtual string ShortDisplayName { get; }
+        public string SortExpression { get; }
+        public MetaTable Table { get; private set; }
+        public TypeCode TypeCode { get; }
+        public virtual string UIHint { get; }
+        protected virtual AttributeCollection BuildAttributeCollection();
+        protected internal virtual void Initialize();
+        public void ResetMetadata();
+        public override string ToString();
+    }
+    public class MetaForeignKeyColumn : MetaColumn, IMetaColumn, IMetaForeignKeyColumn {
+        public MetaForeignKeyColumn(MetaTable table, ColumnProvider entityMember);
+        public ReadOnlyCollection<string> ForeignKeyNames { get; }
+        public bool IsPrimaryKeyInThisTable { get; }
+        public MetaTable ParentTable { get; internal set; }
+        public void ExtractForeignKey(IDictionary dictionary, string value);
+        public string GetFilterExpression(string foreignKeyName);
+        public string GetForeignKeyDetailsPath(object row);
+        public string GetForeignKeyPath(string action, object row);
+        public string GetForeignKeyPath(string action, object row, string path);
+        public string GetForeignKeyString(object row);
+        public IList<object> GetForeignKeyValues(object row);
+        protected internal override void Initialize();
+    }
+    public class MetaModel : IMetaModel {
+        public MetaModel();
+        public MetaModel(bool registerGlobally);
+        public static MetaModel Default { get; internal set; }
+        public string DynamicDataFolderVirtualPath { get; set; }
+        public EntityTemplateFactory EntityTemplateFactory { get; set; }
+        public IFieldTemplateFactory FieldTemplateFactory { get; set; }
+        public FilterFactory FilterFactory { get; set; }
+        public ReadOnlyCollection<MetaTable> Tables { get; }
+        public List<MetaTable> VisibleTables { get; }
+        protected virtual MetaTable CreateTable(TableProvider provider);
+        public string GetActionPath(string tableName, string action, object row);
+        public static MetaModel GetModel(Type contextType);
+        public MetaTable GetTable(string uniqueTableName);
+        public MetaTable GetTable(string tableName, Type contextType);
+        public MetaTable GetTable(Type entityType);
+        public void RegisterContext(Func<object> contextFactory);
+        public void RegisterContext(Func<object> contextFactory, ContextConfiguration configuration);
+        public void RegisterContext(Type contextType);
+        public void RegisterContext(Type contextType, ContextConfiguration configuration);
+        public void RegisterContext(DataModelProvider dataModelProvider);
+        public virtual void RegisterContext(DataModelProvider dataModelProvider, ContextConfiguration configuration);
+        public static void ResetRegistrationException();
+        public bool TryGetTable(string uniqueTableName, out MetaTable table);
+        public bool TryGetTable(Type entityType, out MetaTable table);
+    }
+    public class MetaTable : IMetaTable {
+        public MetaTable(MetaModel metaModel, TableProvider tableProvider);
+        public AttributeCollection Attributes { get; }
+        public ReadOnlyCollection<MetaColumn> Columns { get; internal set; }
+        public string DataContextPropertyName { get; }
+        public Type DataContextType { get; }
+        public virtual MetaColumn DisplayColumn { get; }
+        public virtual string DisplayName { get; }
+        public Type EntityType { get; }
+        public string ForeignKeyColumnsNames { get; }
+        public bool HasPrimaryKey { get; }
+        public virtual bool IsReadOnly { get; }
+        public string ListActionPath { get; internal set; }
+        public MetaModel Model { get; private set; }
+        public string Name { get; private set; }
+        public ReadOnlyCollection<MetaColumn> PrimaryKeyColumns { get; }
+        public TableProvider Provider { get; }
+        public Type RootEntityType { get; }
+        public virtual bool Scaffold { get; }
+        public virtual MetaColumn SortColumn { get; }
+        public virtual bool SortDescending { get; }
+        protected virtual AttributeCollection BuildAttributeCollection();
+        public virtual bool CanDelete(IPrincipal principal);
+        public virtual bool CanInsert(IPrincipal principal);
+        public virtual bool CanRead(IPrincipal principal);
+        public virtual bool CanUpdate(IPrincipal principal);
+        protected virtual MetaChildrenColumn CreateChildrenColumn(ColumnProvider columnProvider);
+        protected virtual MetaColumn CreateColumn(ColumnProvider columnProvider);
+        public virtual object CreateContext();
+        protected virtual MetaForeignKeyColumn CreateForeignKeyColumn(ColumnProvider columnProvider);
+        public static MetaTable CreateTable(ICustomTypeDescriptor typeDescriptor);
+        public static MetaTable CreateTable(Type entityType);
+        public string GetActionPath(string action);
+        public string GetActionPath(string action, IList<object> primaryKeyValues);
+        public string GetActionPath(string action, IList<object> primaryKeyValues, string path);
+        public string GetActionPath(string action, object row);
+        public string GetActionPath(string action, object row, string path);
+        public string GetActionPath(string action, RouteValueDictionary routeValues);
+        public MetaColumn GetColumn(string columnName);
+        public IDictionary<string, object> GetColumnValuesFromRoute(HttpContext context);
+        public DataKey GetDataKeyFromRoute();
+        public virtual string GetDisplayString(object row);
+        public virtual IEnumerable<MetaColumn> GetFilteredColumns();
+        public IDictionary<string, object> GetPrimaryKeyDictionary(object row);
+        public string GetPrimaryKeyString(IList<object> primaryKeyValues);
+        public string GetPrimaryKeyString(object row);
+        public IList<object> GetPrimaryKeyValues(object row);
+        public IQueryable GetQuery();
+        public virtual IQueryable GetQuery(object context);
+        public virtual IEnumerable<MetaColumn> GetScaffoldColumns(DataBoundControlMode mode, ContainerType containerType);
+        public static MetaTable GetTable(Type entityType);
+        protected internal virtual void Initialize();
+        public void ResetMetadata();
+        public override string ToString();
+        public bool TryGetColumn(string columnName, out MetaColumn column);
+        public static bool TryGetTable(Type entityType, out MetaTable table);
+    }
+    public static class PageAction {
+        public static string Details { get; }
+        public static string Edit { get; }
+        public static string Insert { get; }
+        public static string List { get; }
+    }
+    public class QueryableFilterRepeater : Control, IFilterExpressionProvider {
+        public QueryableFilterRepeater();
+        public string DynamicFilterContainerId { get; set; }
+        public virtual ITemplate ItemTemplate { get; set; }
+        protected override void OnPreRender(EventArgs e);
+        IQueryable System.Web.DynamicData.IFilterExpressionProvider.GetQueryable(IQueryable source);
+        void System.Web.DynamicData.IFilterExpressionProvider.Initialize(IQueryableDataSource dataSource);
+    }
+    public abstract class QueryableFilterUserControl : UserControl {
+        protected QueryableFilterUserControl();
+        protected internal MetaColumn Column { get; private set; }
+        public string DefaultValue { get; }
+        public IDictionary<string, object> DefaultValues { get; }
+        public virtual Control FilterControl { get; }
+        public event EventHandler FilterChanged;
+        public static IQueryable ApplyEqualityFilter(IQueryable source, string propertyName, object value);
+        public abstract IQueryable GetQueryable(IQueryable source);
+        protected void OnFilterChanged();
+        public void PopulateListControl(ListControl listControl);
+    }
+    public sealed class TableNameAttribute : Attribute {
+        public TableNameAttribute(string name);
+        public string Name { get; private set; }
+    }
+}
```

