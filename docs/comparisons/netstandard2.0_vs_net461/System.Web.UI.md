# System.Web.UI

``` diff
+namespace System.Web.UI {
+    public enum AjaxFrameworkMode {
+        Disabled = 1,
+        Enabled = 0,
+        Explicit = 2,
+    }
+    public class AsyncPostBackErrorEventArgs : EventArgs {
+        public AsyncPostBackErrorEventArgs(Exception exception);
+        public Exception Exception { get; }
+    }
+    public class AsyncPostBackTrigger : UpdatePanelControlTrigger {
+        public AsyncPostBackTrigger();
+        public new string ControlID { get; set; }
+        public string EventName { get; set; }
+        protected internal override bool HasTriggered();
+        protected internal override void Initialize();
+        public void OnEvent(object sender, EventArgs e);
+        public override string ToString();
+    }
+    public sealed class AttributeCollection {
+        public AttributeCollection(StateBag bag);
+        public int Count { get; }
+        public CssStyleCollection CssStyle { get; }
+        public ICollection Keys { get; }
+        public string this[string key] { get; set; }
+        public void Add(string key, string value);
+        public void AddAttributes(HtmlTextWriter writer);
+        public void Clear();
+        public override bool Equals(object o);
+        public override int GetHashCode();
+        public void Remove(string key);
+        public void Render(HtmlTextWriter writer);
+    }
+    public class AuthenticationServiceManager {
+        public AuthenticationServiceManager();
+        public string Path { get; set; }
+    }
+    public class BaseParser {
+        public BaseParser();
+    }
+    public abstract class BasePartialCachingControl : Control {
+        protected BasePartialCachingControl();
+        public ControlCachePolicy CachePolicy { get; }
+        public CacheDependency Dependency { get; set; }
+        public override void Dispose();
+        protected internal override void Render(HtmlTextWriter output);
+    }
+    public abstract class BaseTemplateParser : TemplateParser {
+        protected BaseTemplateParser();
+        protected Type GetReferencedType(string virtualPath);
+        protected internal Type GetUserControlType(string virtualPath);
+    }
+    public sealed class BindableTemplateBuilder : TemplateBuilder, IBindableTemplate, ITemplate {
+        public BindableTemplateBuilder();
+        public IOrderedDictionary ExtractValues(Control container);
+        public override void OnAppendToParentBuilder(ControlBuilder parentBuilder);
+    }
+    public class BoundPropertyEntry : PropertyEntry {
+        public string ControlID { get; set; }
+        public Type ControlType { get; set; }
+        public string Expression { get; set; }
+        public ExpressionBuilder ExpressionBuilder { get; set; }
+        public string ExpressionPrefix { get; set; }
+        public string FieldName { get; set; }
+        public string FormatString { get; set; }
+        public bool Generated { get; set; }
+        public bool IsEncoded { get; set; }
+        public object ParsedExpressionData { get; set; }
+        public bool ReadOnlyProperty { get; set; }
+        public bool TwoWayBound { get; set; }
+        public bool UseSetAttribute { get; set; }
+    }
+    public abstract class BuilderPropertyEntry : PropertyEntry {
+        public ControlBuilder Builder { get; set; }
+    }
+    public delegate Control BuildMethod();
+    public delegate void BuildTemplateMethod(Control control);
+    public class ChtmlTextWriter : Html32TextWriter {
+        public ChtmlTextWriter(TextWriter writer);
+        public ChtmlTextWriter(TextWriter writer, string tabString);
+        protected Hashtable GlobalSuppressedAttributes { get; }
+        protected Hashtable RecognizedAttributes { get; }
+        protected Hashtable SuppressedAttributes { get; }
+        public virtual void AddRecognizedAttribute(string elementName, string attributeName);
+        protected override bool OnAttributeRender(string name, string value, HtmlTextWriterAttribute key);
+        protected override bool OnStyleAttributeRender(string name, string value, HtmlTextWriterStyle key);
+        protected override bool OnTagRender(string name, HtmlTextWriterTag key);
+        public virtual void RemoveRecognizedAttribute(string elementName, string attributeName);
+        public override void WriteBreak();
+        public override void WriteEncodedText(string text);
+    }
+    public enum ClientIDMode {
+        AutoID = 1,
+        Inherit = 0,
+        Predictable = 2,
+        Static = 3,
+    }
+    public sealed class ClientScriptManager {
+        public string GetCallbackEventReference(string target, string argument, string clientCallback, string context, string clientErrorCallback, bool useAsync);
+        public string GetCallbackEventReference(Control control, string argument, string clientCallback, string context);
+        public string GetCallbackEventReference(Control control, string argument, string clientCallback, string context, bool useAsync);
+        public string GetCallbackEventReference(Control control, string argument, string clientCallback, string context, string clientErrorCallback, bool useAsync);
+        public string GetPostBackClientHyperlink(Control control, string argument);
+        public string GetPostBackClientHyperlink(Control control, string argument, bool registerForEventValidation);
+        public string GetPostBackEventReference(Control control, string argument);
+        public string GetPostBackEventReference(Control control, string argument, bool registerForEventValidation);
+        public string GetPostBackEventReference(PostBackOptions options);
+        public string GetPostBackEventReference(PostBackOptions options, bool registerForEventValidation);
+        public string GetWebResourceUrl(Type type, string resourceName);
+        public bool IsClientScriptBlockRegistered(string key);
+        public bool IsClientScriptBlockRegistered(Type type, string key);
+        public bool IsClientScriptIncludeRegistered(string key);
+        public bool IsClientScriptIncludeRegistered(Type type, string key);
+        public bool IsOnSubmitStatementRegistered(string key);
+        public bool IsOnSubmitStatementRegistered(Type type, string key);
+        public bool IsStartupScriptRegistered(string key);
+        public bool IsStartupScriptRegistered(Type type, string key);
+        public void RegisterArrayDeclaration(string arrayName, string arrayValue);
+        public void RegisterClientScriptBlock(Type type, string key, string script);
+        public void RegisterClientScriptBlock(Type type, string key, string script, bool addScriptTags);
+        public void RegisterClientScriptInclude(string key, string url);
+        public void RegisterClientScriptInclude(Type type, string key, string url);
+        public void RegisterClientScriptResource(Type type, string resourceName);
+        public void RegisterExpandoAttribute(string controlId, string attributeName, string attributeValue);
+        public void RegisterExpandoAttribute(string controlId, string attributeName, string attributeValue, bool encode);
+        public void RegisterForEventValidation(string uniqueId);
+        public void RegisterForEventValidation(string uniqueId, string argument);
+        public void RegisterForEventValidation(PostBackOptions options);
+        public void RegisterHiddenField(string hiddenFieldName, string hiddenFieldInitialValue);
+        public void RegisterOnSubmitStatement(Type type, string key, string script);
+        public void RegisterStartupScript(Type type, string key, string script);
+        public void RegisterStartupScript(Type type, string key, string script, bool addScriptTags);
+        public void ValidateEvent(string uniqueId);
+        public void ValidateEvent(string uniqueId, string argument);
+    }
+    public enum CodeBlockType {
+        Code = 0,
+        DataBinding = 2,
+        EncodedExpression = 3,
+        Expression = 1,
+    }
+    public enum CodeConstructType {
+        CodeSnippet = 0,
+        DataBindingSnippet = 2,
+        EncodedExpressionSnippet = 4,
+        ExpressionSnippet = 1,
+        ScriptTag = 3,
+    }
+    public abstract class CodeStatementBuilder : ControlBuilder {
+        protected CodeStatementBuilder();
+        public abstract CodeStatement BuildStatement(CodeArgumentReferenceExpression writerReferenceExpression);
+    }
+    public enum CompilationMode {
+        Always = 2,
+        Auto = 0,
+        Never = 1,
+    }
+    public sealed class CompiledBindableTemplateBuilder : IBindableTemplate, ITemplate {
+        public CompiledBindableTemplateBuilder(BuildTemplateMethod buildTemplateMethod, ExtractTemplateValuesMethod extractTemplateValuesMethod);
+        public IOrderedDictionary ExtractValues(Control container);
+        public void InstantiateIn(Control container);
+    }
+    public sealed class CompiledTemplateBuilder : ITemplate {
+        public CompiledTemplateBuilder(BuildTemplateMethod buildTemplateMethod);
+        public void InstantiateIn(Control container);
+    }
+    public class ComplexPropertyEntry : BuilderPropertyEntry {
+        public bool IsCollectionItem { get; }
+        public bool ReadOnly { get; set; }
+    }
+    public class CompositeScriptReference : ScriptReferenceBase {
+        public CompositeScriptReference();
+        public ScriptReferenceCollection Scripts { get; }
+        protected internal override string GetUrl(ScriptManager scriptManager, bool zip);
+        protected internal override bool IsAjaxFrameworkScript(ScriptManager scriptManager);
+        protected internal override bool IsFromSystemWebExtensions();
+    }
+    public class CompositeScriptReferenceEventArgs : EventArgs {
+        public CompositeScriptReferenceEventArgs(CompositeScriptReference compositeScript);
+        public CompositeScriptReference CompositeScript { get; }
+    }
+    public enum ConflictOptions {
+        CompareAllValues = 1,
+        OverwriteChanges = 0,
+    }
+    public sealed class ConstructorNeedsTagAttribute : Attribute {
+        public ConstructorNeedsTagAttribute();
+        public ConstructorNeedsTagAttribute(bool needsTag);
+        public bool NeedsTag { get; }
+    }
+    public class Control : IComponent, IControlBuilderAccessor, IControlDesignerAccessor, IDataBindingsAccessor, IDisposable, IExpressionsAccessor, IParserAccessor, IUrlResolutionService {
+        public Control();
+        protected ControlAdapter Adapter { get; }
+        public string AppRelativeTemplateSourceDirectory { get; set; }
+        public Control BindingContainer { get; }
+        protected bool ChildControlsCreated { get; set; }
+        public virtual string ClientID { get; }
+        public virtual ClientIDMode ClientIDMode { get; set; }
+        protected char ClientIDSeparator { get; }
+        protected internal virtual HttpContext Context { get; }
+        public virtual ControlCollection Controls { get; }
+        public Control DataItemContainer { get; }
+        public Control DataKeysContainer { get; }
+        protected internal bool DesignMode { get; }
+        public virtual bool EnableTheming { get; set; }
+        public virtual bool EnableViewState { get; set; }
+        protected EventHandlerList Events { get; }
+        protected bool HasChildViewState { get; }
+        public virtual string ID { get; set; }
+        protected char IdSeparator { get; }
+        protected internal bool IsChildControlStateCleared { get; }
+        protected bool IsTrackingViewState { get; }
+        protected internal bool IsViewStateEnabled { get; }
+        protected bool LoadViewStateByID { get; }
+        public virtual Control NamingContainer { get; }
+        public virtual Page Page { get; set; }
+        public virtual Control Parent { get; }
+        public virtual Version RenderingCompatibility { get; set; }
+        public ISite Site { get; set; }
+        public virtual string SkinID { get; set; }
+        ControlBuilder System.Web.UI.IControlBuilderAccessor.ControlBuilder { get; }
+        IDictionary System.Web.UI.IControlDesignerAccessor.UserData { get; }
+        DataBindingCollection System.Web.UI.IDataBindingsAccessor.DataBindings { get; }
+        bool System.Web.UI.IDataBindingsAccessor.HasDataBindings { get; }
+        ExpressionBindingCollection System.Web.UI.IExpressionsAccessor.Expressions { get; }
+        bool System.Web.UI.IExpressionsAccessor.HasExpressions { get; }
+        public TemplateControl TemplateControl { get; set; }
+        public virtual string TemplateSourceDirectory { get; }
+        public virtual string UniqueID { get; }
+        public virtual ValidateRequestMode ValidateRequestMode { get; set; }
+        protected virtual StateBag ViewState { get; }
+        protected virtual bool ViewStateIgnoresCase { get; }
+        public virtual ViewStateMode ViewStateMode { get; set; }
+        public virtual bool Visible { get; set; }
+        public event EventHandler DataBinding;
+        public event EventHandler Disposed;
+        public event EventHandler Init;
+        public event EventHandler Load;
+        public event EventHandler PreRender;
+        public event EventHandler Unload;
+        protected internal virtual void AddedControl(Control control, int index);
+        protected virtual void AddParsedSubObject(object obj);
+        public virtual void ApplyStyleSheetSkin(Page page);
+        protected void BeginRenderTracing(TextWriter writer, object traceObject);
+        protected void BuildProfileTree(string parentId, bool calcViewState);
+        protected void ClearCachedClientID();
+        protected void ClearChildControlState();
+        protected void ClearChildState();
+        protected void ClearChildViewState();
+        protected void ClearEffectiveClientIDMode();
+        protected internal virtual void CreateChildControls();
+        protected virtual ControlCollection CreateControlCollection();
+        public virtual void DataBind();
+        protected virtual void DataBind(bool raiseOnDataBinding);
+        protected virtual void DataBindChildren();
+        public virtual void Dispose();
+        protected void EndRenderTracing(TextWriter writer, object traceObject);
+        protected virtual void EnsureChildControls();
+        protected void EnsureID();
+        public virtual Control FindControl(string id);
+        protected virtual Control FindControl(string id, int pathOffset);
+        public virtual void Focus();
+        protected virtual IDictionary GetDesignModeState();
+        public string GetRouteUrl(object routeParameters);
+        public string GetRouteUrl(string routeName, object routeParameters);
+        public string GetRouteUrl(string routeName, RouteValueDictionary routeParameters);
+        public string GetRouteUrl(RouteValueDictionary routeParameters);
+        public string GetUniqueIDRelativeTo(Control control);
+        public virtual bool HasControls();
+        protected bool HasEvents();
+        protected bool IsLiteralContent();
+        protected internal virtual void LoadControlState(object savedState);
+        protected virtual void LoadViewState(object savedState);
+        protected internal string MapPathSecure(string virtualPath);
+        protected virtual bool OnBubbleEvent(object source, EventArgs args);
+        protected virtual void OnDataBinding(EventArgs e);
+        protected internal virtual void OnInit(EventArgs e);
+        protected internal virtual void OnLoad(EventArgs e);
+        protected internal virtual void OnPreRender(EventArgs e);
+        protected internal virtual void OnUnload(EventArgs e);
+        protected internal Stream OpenFile(string path);
+        protected void RaiseBubbleEvent(object source, EventArgs args);
+        protected internal virtual void RemovedControl(Control control);
+        protected internal virtual void Render(HtmlTextWriter writer);
+        protected internal virtual void RenderChildren(HtmlTextWriter writer);
+        public virtual void RenderControl(HtmlTextWriter writer);
+        protected void RenderControl(HtmlTextWriter writer, ControlAdapter adapter);
+        protected virtual ControlAdapter ResolveAdapter();
+        public string ResolveClientUrl(string relativeUrl);
+        public string ResolveUrl(string relativeUrl);
+        protected internal virtual object SaveControlState();
+        protected virtual object SaveViewState();
+        protected virtual void SetDesignModeState(IDictionary data);
+        public void SetRenderMethodDelegate(RenderMethod renderMethod);
+        public void SetTraceData(object traceDataKey, object traceDataValue);
+        public void SetTraceData(object tracedObject, object traceDataKey, object traceDataValue);
+        IDictionary System.Web.UI.IControlDesignerAccessor.GetDesignModeState();
+        void System.Web.UI.IControlDesignerAccessor.SetDesignModeState(IDictionary data);
+        void System.Web.UI.IControlDesignerAccessor.SetOwnerControl(Control owner);
+        void System.Web.UI.IParserAccessor.AddParsedSubObject(object obj);
+        protected virtual void TrackViewState();
+    }
+    public class ControlBuilder {
+        public static readonly string DesignerFilter;
+        public ControlBuilder();
+        public virtual ControlBuilder BindingContainerBuilder { get; }
+        public virtual Type BindingContainerType { get; }
+        public ICollection ComplexPropertyEntries { get; }
+        public Type ControlType { get; }
+        public IFilterResolutionService CurrentFilterResolutionService { get; }
+        public virtual Type DeclareType { get; }
+        protected bool FChildrenAsProperties { get; }
+        protected bool FIsNonParserAccessor { get; }
+        public virtual bool HasAspCode { get; }
+        public string ID { get; set; }
+        protected bool InDesigner { get; }
+        protected bool InPageTheme { get; }
+        public virtual string ItemType { get; }
+        public bool Localize { get; }
+        public Type NamingContainerType { get; }
+        public string PageVirtualPath { get; }
+        protected internal TemplateParser Parser { get; }
+        public IServiceProvider ServiceProvider { get; }
+        public ArrayList SubBuilders { get; }
+        public string TagName { get; }
+        public ICollection TemplatePropertyEntries { get; }
+        public IThemeResolutionService ThemeResolutionService { get; }
+        public virtual bool AllowWhitespaceLiterals();
+        public virtual void AppendLiteralString(string s);
+        public virtual void AppendSubBuilder(ControlBuilder subBuilder);
+        public virtual object BuildObject();
+        public virtual void CloseControl();
+        public static ControlBuilder CreateBuilderFromType(TemplateParser parser, ControlBuilder parentBuilder, Type type, string tagName, string id, IDictionary attribs, int line, string sourceFileName);
+        public virtual Type GetChildControlType(string tagName, IDictionary attribs);
+        public ObjectPersistData GetObjectPersistData();
+        public string GetResourceKey();
+        public virtual bool HasBody();
+        public virtual bool HtmlDecodeLiterals();
+        public virtual void Init(TemplateParser parser, ControlBuilder parentBuilder, Type type, string tagName, string id, IDictionary attribs);
+        public virtual bool NeedsTagInnerText();
+        public virtual void OnAppendToParentBuilder(ControlBuilder parentBuilder);
+        public virtual void ProcessGeneratedCode(CodeCompileUnit codeCompileUnit, CodeTypeDeclaration baseType, CodeTypeDeclaration derivedType, CodeMemberMethod buildMethod, CodeMemberMethod dataBindingMethod);
+        public void SetResourceKey(string resourceKey);
+        public void SetServiceProvider(IServiceProvider serviceProvider);
+        public virtual void SetTagInnerText(string text);
+    }
+    public sealed class ControlBuilderAttribute : Attribute {
+        public static readonly ControlBuilderAttribute Default;
+        public ControlBuilderAttribute(Type builderType);
+        public Type BuilderType { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public override bool IsDefaultAttribute();
+    }
+    public sealed class ControlCachePolicy {
+        public bool Cached { get; set; }
+        public CacheDependency Dependency { get; set; }
+        public TimeSpan Duration { get; set; }
+        public string ProviderName { get; set; }
+        public bool SupportsCaching { get; }
+        public string VaryByControl { get; set; }
+        public HttpCacheVaryByParams VaryByParams { get; }
+        public void SetExpires(DateTime expirationTime);
+        public void SetSlidingExpiration(bool useSlidingExpiration);
+        public void SetVaryByCustom(string varyByCustom);
+    }
+    public class ControlCollection : ICollection, IEnumerable {
+        public ControlCollection(Control owner);
+        public virtual int Count { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        protected Control Owner { get; }
+        public object SyncRoot { get; }
+        public virtual Control this[int index] { get; }
+        public virtual void Add(Control child);
+        public virtual void AddAt(int index, Control child);
+        public virtual void Clear();
+        public virtual bool Contains(Control c);
+        public virtual void CopyTo(Array array, int index);
+        public virtual IEnumerator GetEnumerator();
+        public virtual int IndexOf(Control value);
+        public virtual void Remove(Control value);
+        public virtual void RemoveAt(int index);
+    }
+    public class ControlSkin {
+        public ControlSkin(Type controlType, ControlSkinDelegate themeDelegate);
+        public Type ControlType { get; }
+        public void ApplySkin(Control control);
+    }
+    public delegate Control ControlSkinDelegate(Control control);
+    public sealed class ControlValuePropertyAttribute : Attribute {
+        public ControlValuePropertyAttribute(string name);
+        public ControlValuePropertyAttribute(string name, object defaultValue);
+        public ControlValuePropertyAttribute(string name, Type type, string defaultValue);
+        public object DefaultValue { get; }
+        public string Name { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+    }
+    public sealed class CssClassPropertyAttribute : Attribute {
+        public CssClassPropertyAttribute();
+    }
+    public sealed class CssStyleCollection {
+        public int Count { get; }
+        public ICollection Keys { get; }
+        public string this[string key] { get; set; }
+        public string this[HtmlTextWriterStyle key] { get; set; }
+        public string Value { get; set; }
+        public void Add(string key, string value);
+        public void Add(HtmlTextWriterStyle key, string value);
+        public void Clear();
+        public void Remove(string key);
+        public void Remove(HtmlTextWriterStyle key);
+    }
+    public sealed class DataBinder {
+        public DataBinder();
+        public static bool EnableCaching { get; set; }
+        public static object Eval(object container, string expression);
+        public static string Eval(object container, string expression, string format);
+        public static object GetDataItem(object container);
+        public static object GetDataItem(object container, out bool foundDataItem);
+        public static object GetIndexedPropertyValue(object container, string expr);
+        public static string GetIndexedPropertyValue(object container, string propName, string format);
+        public static object GetPropertyValue(object container, string propName);
+        public static string GetPropertyValue(object container, string propName, string format);
+        public static bool IsBindableType(Type type);
+    }
+    public sealed class DataBinding {
+        public DataBinding(string propertyName, Type propertyType, string expression);
+        public string Expression { get; set; }
+        public string PropertyName { get; }
+        public Type PropertyType { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+    }
+    public sealed class DataBindingCollection : ICollection, IEnumerable {
+        public DataBindingCollection();
+        public int Count { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public string[] RemovedBindings { get; }
+        public object SyncRoot { get; }
+        public DataBinding this[string propertyName] { get; }
+        public event EventHandler Changed;
+        public void Add(DataBinding binding);
+        public void Clear();
+        public bool Contains(string propertyName);
+        public void CopyTo(Array array, int index);
+        public IEnumerator GetEnumerator();
+        public void Remove(string propertyName);
+        public void Remove(string propertyName, bool addToRemovedList);
+        public void Remove(DataBinding binding);
+    }
+    public sealed class DataBindingHandlerAttribute : Attribute {
+        public static readonly DataBindingHandlerAttribute Default;
+        public DataBindingHandlerAttribute();
+        public DataBindingHandlerAttribute(string typeName);
+        public DataBindingHandlerAttribute(Type type);
+        public string HandlerTypeName { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+    }
+    public sealed class DataBoundLiteralControl : Control, ITextControl {
+        public DataBoundLiteralControl(int staticLiteralsCount, int dataBoundLiteralCount);
+        string System.Web.UI.ITextControl.Text { get; set; }
+        public string Text { get; }
+        protected override ControlCollection CreateControlCollection();
+        protected override void LoadViewState(object savedState);
+        protected internal override void Render(HtmlTextWriter output);
+        protected override object SaveViewState();
+        public void SetDataBoundString(int index, string s);
+        public void SetStaticString(int index, string s);
+    }
+    public static class DataControlExtensions {
+        public static void EnableDynamicData(this INamingContainer control, Type entityType);
+        public static void EnableDynamicData(this INamingContainer control, Type entityType, IDictionary<string, object> defaultValues);
+        public static void EnableDynamicData(this INamingContainer control, Type entityType, object defaults);
+    }
+    public sealed class DataKeyPropertyAttribute : Attribute {
+        public DataKeyPropertyAttribute(string name);
+        public string Name { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+    }
+    public class DataSourceCacheDurationConverter : Int32Converter {
+        public DataSourceCacheDurationConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+        public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context);
+        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context);
+        public override bool GetStandardValuesSupported(ITypeDescriptorContext context);
+    }
+    public enum DataSourceCacheExpiry {
+        Absolute = 0,
+        Sliding = 1,
+    }
+    public enum DataSourceCapabilities {
+        None = 0,
+        Page = 2,
+        RetrieveTotalRowCount = 4,
+        Sort = 1,
+    }
+    public abstract class DataSourceControl : Control, IDataSource, IListSource {
+        protected DataSourceControl();
+        public override string ClientID { get; }
+        public override ClientIDMode ClientIDMode { get; set; }
+        public override ControlCollection Controls { get; }
+        public override bool EnableTheming { get; set; }
+        public override string SkinID { get; set; }
+        bool System.ComponentModel.IListSource.ContainsListCollection { get; }
+        public override bool Visible { get; set; }
+        event EventHandler System.Web.UI.IDataSource.DataSourceChanged;
+        public override void ApplyStyleSheetSkin(Page page);
+        protected override ControlCollection CreateControlCollection();
+        public override Control FindControl(string id);
+        public override void Focus();
+        protected abstract DataSourceView GetView(string viewName);
+        protected virtual ICollection GetViewNames();
+        public override bool HasControls();
+        protected virtual void RaiseDataSourceChangedEvent(EventArgs e);
+        public override void RenderControl(HtmlTextWriter writer);
+        IList System.ComponentModel.IListSource.GetList();
+        DataSourceView System.Web.UI.IDataSource.GetView(string viewName);
+        ICollection System.Web.UI.IDataSource.GetViewNames();
+    }
+    public sealed class DataSourceControlBuilder : ControlBuilder {
+        public DataSourceControlBuilder();
+        public override bool AllowWhitespaceLiterals();
+    }
+    public enum DataSourceOperation {
+        Delete = 0,
+        Insert = 1,
+        Select = 2,
+        SelectCount = 4,
+        Update = 3,
+    }
+    public sealed class DataSourceSelectArguments {
+        public DataSourceSelectArguments();
+        public DataSourceSelectArguments(int startRowIndex, int maximumRows);
+        public DataSourceSelectArguments(string sortExpression);
+        public DataSourceSelectArguments(string sortExpression, int startRowIndex, int maximumRows);
+        public static DataSourceSelectArguments Empty { get; }
+        public int MaximumRows { get; set; }
+        public bool RetrieveTotalRowCount { get; set; }
+        public string SortExpression { get; set; }
+        public int StartRowIndex { get; set; }
+        public int TotalRowCount { get; set; }
+        public void AddSupportedCapabilities(DataSourceCapabilities capabilities);
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public void RaiseUnsupportedCapabilitiesError(DataSourceView view);
+    }
+    public abstract class DataSourceView {
+        protected DataSourceView(IDataSource owner, string viewName);
+        public virtual bool CanDelete { get; }
+        public virtual bool CanInsert { get; }
+        public virtual bool CanPage { get; }
+        public virtual bool CanRetrieveTotalRowCount { get; }
+        public virtual bool CanSort { get; }
+        public virtual bool CanUpdate { get; }
+        protected EventHandlerList Events { get; }
+        public string Name { get; }
+        public event EventHandler DataSourceViewChanged;
+        public virtual bool CanExecute(string commandName);
+        public virtual void Delete(IDictionary keys, IDictionary oldValues, DataSourceViewOperationCallback callback);
+        protected virtual int ExecuteCommand(string commandName, IDictionary keys, IDictionary values);
+        public virtual void ExecuteCommand(string commandName, IDictionary keys, IDictionary values, DataSourceViewOperationCallback callback);
+        protected virtual int ExecuteDelete(IDictionary keys, IDictionary oldValues);
+        protected virtual int ExecuteInsert(IDictionary values);
+        protected internal abstract IEnumerable ExecuteSelect(DataSourceSelectArguments arguments);
+        protected virtual int ExecuteUpdate(IDictionary keys, IDictionary values, IDictionary oldValues);
+        public virtual void Insert(IDictionary values, DataSourceViewOperationCallback callback);
+        protected virtual void OnDataSourceViewChanged(EventArgs e);
+        protected internal virtual void RaiseUnsupportedCapabilityError(DataSourceCapabilities capability);
+        public virtual void Select(DataSourceSelectArguments arguments, DataSourceViewSelectCallback callback);
+        public virtual void Update(IDictionary keys, IDictionary values, IDictionary oldValues, DataSourceViewOperationCallback callback);
+    }
+    public delegate bool DataSourceViewOperationCallback(int affectedRecords, Exception ex);
+    public delegate void DataSourceViewSelectCallback(IEnumerable data);
+    public sealed class DesignerDataBoundLiteralControl : Control {
+        public DesignerDataBoundLiteralControl();
+        public string Text { get; set; }
+        protected override ControlCollection CreateControlCollection();
+        protected override void LoadViewState(object savedState);
+        protected internal override void Render(HtmlTextWriter output);
+        protected override object SaveViewState();
+    }
+    public sealed class DesignTimeParseData {
+        public DesignTimeParseData(IDesignerHost designerHost, string parseText);
+        public DesignTimeParseData(IDesignerHost designerHost, string parseText, string filter);
+        public EventHandler DataBindingHandler { get; set; }
+        public IDesignerHost DesignerHost { get; }
+        public string DocumentUrl { get; set; }
+        public string Filter { get; }
+        public string ParseText { get; }
+        public bool ShouldApplyTheme { get; set; }
+        public ICollection UserControlRegisterEntries { get; }
+    }
+    public static class DesignTimeTemplateParser {
+        public static Control ParseControl(DesignTimeParseData data);
+        public static Control[] ParseControls(DesignTimeParseData data);
+        public static ITemplate ParseTemplate(DesignTimeParseData data);
+        public static ControlBuilder ParseTheme(IDesignerHost host, string theme, string themePath);
+    }
+    public class EmptyControlCollection : ControlCollection {
+        public EmptyControlCollection(Control owner);
+        public override void Add(Control child);
+        public override void AddAt(int index, Control child);
+    }
+    public class EventEntry {
+        public EventEntry();
+        public string HandlerMethodName { get; set; }
+        public Type HandlerType { get; set; }
+        public string Name { get; set; }
+    }
+    public sealed class ExpressionBinding {
+        public ExpressionBinding(string propertyName, Type propertyType, string expressionPrefix, string expression);
+        public string Expression { get; set; }
+        public string ExpressionPrefix { get; set; }
+        public bool Generated { get; }
+        public object ParsedExpressionData { get; }
+        public string PropertyName { get; }
+        public Type PropertyType { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+    }
+    public sealed class ExpressionBindingCollection : ICollection, IEnumerable {
+        public ExpressionBindingCollection();
+        public int Count { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public ICollection RemovedBindings { get; }
+        public object SyncRoot { get; }
+        public ExpressionBinding this[string propertyName] { get; }
+        public event EventHandler Changed;
+        public void Add(ExpressionBinding binding);
+        public void Clear();
+        public bool Contains(string propName);
+        public void CopyTo(Array array, int index);
+        public void CopyTo(ExpressionBinding[] array, int index);
+        public IEnumerator GetEnumerator();
+        public void Remove(string propertyName);
+        public void Remove(string propertyName, bool addToRemovedList);
+        public void Remove(ExpressionBinding binding);
+    }
+    public abstract class ExtenderControl : Control, IExtenderControl {
+        protected ExtenderControl();
+        public string TargetControlID { get; set; }
+        public override bool Visible { get; set; }
+        protected abstract IEnumerable<ScriptDescriptor> GetScriptDescriptors(Control targetControl);
+        protected abstract IEnumerable<ScriptReference> GetScriptReferences();
+        protected internal override void OnPreRender(EventArgs e);
+        protected internal override void Render(HtmlTextWriter writer);
+        IEnumerable<ScriptDescriptor> System.Web.UI.IExtenderControl.GetScriptDescriptors(Control targetControl);
+        IEnumerable<ScriptReference> System.Web.UI.IExtenderControl.GetScriptReferences();
+    }
+    public delegate IOrderedDictionary ExtractTemplateValuesMethod(Control control);
+    public sealed class FileLevelControlBuilderAttribute : Attribute {
+        public static readonly FileLevelControlBuilderAttribute Default;
+        public FileLevelControlBuilderAttribute(Type builderType);
+        public Type BuilderType { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public override bool IsDefaultAttribute();
+    }
+    public class FileLevelMasterPageControlBuilder : FileLevelPageControlBuilder {
+        public FileLevelMasterPageControlBuilder();
+    }
+    public class FileLevelPageControlBuilder : RootBuilder {
+        public FileLevelPageControlBuilder();
+        public override void AppendLiteralString(string text);
+        public override void AppendSubBuilder(ControlBuilder subBuilder);
+    }
+    public class FileLevelUserControlBuilder : RootBuilder {
+        public FileLevelUserControlBuilder();
+    }
+    public sealed class FilterableAttribute : Attribute {
+        public static readonly FilterableAttribute Default;
+        public static readonly FilterableAttribute No;
+        public static readonly FilterableAttribute Yes;
+        public FilterableAttribute(bool filterable);
+        public bool Filterable { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public override bool IsDefaultAttribute();
+        public static bool IsObjectFilterable(object instance);
+        public static bool IsPropertyFilterable(PropertyDescriptor propertyDescriptor);
+        public static bool IsTypeFilterable(Type type);
+    }
+    public class HiddenFieldPageStatePersister : PageStatePersister {
+        public HiddenFieldPageStatePersister(Page page);
+        public override void Load();
+        public override void Save();
+    }
+    public abstract class HierarchicalDataSourceControl : Control, IHierarchicalDataSource {
+        protected HierarchicalDataSourceControl();
+        public override string ClientID { get; }
+        public override ClientIDMode ClientIDMode { get; set; }
+        public override ControlCollection Controls { get; }
+        public override bool EnableTheming { get; set; }
+        public override string SkinID { get; set; }
+        public override bool Visible { get; set; }
+        event EventHandler System.Web.UI.IHierarchicalDataSource.DataSourceChanged;
+        public override void ApplyStyleSheetSkin(Page page);
+        protected override ControlCollection CreateControlCollection();
+        public override Control FindControl(string id);
+        public override void Focus();
+        protected abstract HierarchicalDataSourceView GetHierarchicalView(string viewPath);
+        public override bool HasControls();
+        protected virtual void OnDataSourceChanged(EventArgs e);
+        public override void RenderControl(HtmlTextWriter writer);
+        HierarchicalDataSourceView System.Web.UI.IHierarchicalDataSource.GetHierarchicalView(string viewPath);
+    }
+    public abstract class HierarchicalDataSourceView {
+        protected HierarchicalDataSourceView();
+        public abstract IHierarchicalEnumerable Select();
+    }
+    public class HistoryEventArgs : EventArgs {
+        public HistoryEventArgs(NameValueCollection state);
+        public NameValueCollection State { get; }
+    }
+    public class Html32TextWriter : HtmlTextWriter {
+        public Html32TextWriter(TextWriter writer);
+        public Html32TextWriter(TextWriter writer, string tabString);
+        protected Stack FontStack { get; }
+        public bool ShouldPerformDivTableSubstitution { get; set; }
+        public bool SupportsBold { get; set; }
+        public bool SupportsItalic { get; set; }
+        protected override string GetTagName(HtmlTextWriterTag tagKey);
+        protected override bool OnStyleAttributeRender(string name, string value, HtmlTextWriterStyle key);
+        protected override bool OnTagRender(string name, HtmlTextWriterTag key);
+        protected override string RenderAfterContent();
+        protected override string RenderAfterTag();
+        protected override string RenderBeforeContent();
+        protected override string RenderBeforeTag();
+        public override void RenderBeginTag(HtmlTextWriterTag tagKey);
+        public override void RenderEndTag();
+    }
+    public class HtmlTextWriter : TextWriter {
+        public const char DoubleQuoteChar = '"';
+        public const char EqualsChar = '=';
+        public const char SemicolonChar = ';';
+        public const char SingleQuoteChar = '\'';
+        public const char SlashChar = '/';
+        public const char SpaceChar = ' ';
+        public const char StyleEqualsChar = ':';
+        public const char TagLeftChar = '<';
+        public const char TagRightChar = '>';
+        public const string DefaultTabString = "\t";
+        public const string EndTagLeftChars = "</";
+        public const string EqualsDoubleQuoteString = "=\"";
+        public const string SelfClosingChars = " /";
+        public const string SelfClosingTagEnd = " />";
+        public HtmlTextWriter(TextWriter writer);
+        public HtmlTextWriter(TextWriter writer, string tabString);
+        public override Encoding Encoding { get; }
+        public int Indent { get; set; }
+        public TextWriter InnerWriter { get; set; }
+        public override string NewLine { get; set; }
+        protected HtmlTextWriterTag TagKey { get; set; }
+        protected string TagName { get; set; }
+        public virtual void AddAttribute(string name, string value);
+        public virtual void AddAttribute(string name, string value, bool fEndode);
+        protected virtual void AddAttribute(string name, string value, HtmlTextWriterAttribute key);
+        public virtual void AddAttribute(HtmlTextWriterAttribute key, string value);
+        public virtual void AddAttribute(HtmlTextWriterAttribute key, string value, bool fEncode);
+        public virtual void AddStyleAttribute(string name, string value);
+        protected virtual void AddStyleAttribute(string name, string value, HtmlTextWriterStyle key);
+        public virtual void AddStyleAttribute(HtmlTextWriterStyle key, string value);
+        public virtual void BeginRender();
+        public override void Close();
+        protected string EncodeAttributeValue(string value, bool fEncode);
+        protected virtual string EncodeAttributeValue(HtmlTextWriterAttribute attrKey, string value);
+        protected string EncodeUrl(string url);
+        public virtual void EndRender();
+        public virtual void EnterStyle(Style style);
+        public virtual void EnterStyle(Style style, HtmlTextWriterTag tag);
+        public virtual void ExitStyle(Style style);
+        public virtual void ExitStyle(Style style, HtmlTextWriterTag tag);
+        protected virtual void FilterAttributes();
+        public override void Flush();
+        protected HtmlTextWriterAttribute GetAttributeKey(string attrName);
+        protected string GetAttributeName(HtmlTextWriterAttribute attrKey);
+        protected HtmlTextWriterStyle GetStyleKey(string styleName);
+        protected string GetStyleName(HtmlTextWriterStyle styleKey);
+        protected virtual HtmlTextWriterTag GetTagKey(string tagName);
+        protected virtual string GetTagName(HtmlTextWriterTag tagKey);
+        protected bool IsAttributeDefined(HtmlTextWriterAttribute key);
+        protected bool IsAttributeDefined(HtmlTextWriterAttribute key, out string value);
+        protected bool IsStyleAttributeDefined(HtmlTextWriterStyle key);
+        protected bool IsStyleAttributeDefined(HtmlTextWriterStyle key, out string value);
+        public virtual bool IsValidFormAttribute(string attribute);
+        protected virtual bool OnAttributeRender(string name, string value, HtmlTextWriterAttribute key);
+        protected virtual bool OnStyleAttributeRender(string name, string value, HtmlTextWriterStyle key);
+        protected virtual bool OnTagRender(string name, HtmlTextWriterTag key);
+        protected virtual void OutputTabs();
+        protected string PopEndTag();
+        protected void PushEndTag(string endTag);
+        protected static void RegisterAttribute(string name, HtmlTextWriterAttribute key);
+        protected static void RegisterStyle(string name, HtmlTextWriterStyle key);
+        protected static void RegisterTag(string name, HtmlTextWriterTag key);
+        protected virtual string RenderAfterContent();
+        protected virtual string RenderAfterTag();
+        protected virtual string RenderBeforeContent();
+        protected virtual string RenderBeforeTag();
+        public virtual void RenderBeginTag(string tagName);
+        public virtual void RenderBeginTag(HtmlTextWriterTag tagKey);
+        public virtual void RenderEndTag();
+        public override void Write(bool value);
+        public override void Write(char value);
+        public override void Write(char[] buffer);
+        public override void Write(char[] buffer, int index, int count);
+        public override void Write(double value);
+        public override void Write(int value);
+        public override void Write(long value);
+        public override void Write(object value);
+        public override void Write(float value);
+        public override void Write(string s);
+        public override void Write(string format, object arg0);
+        public override void Write(string format, object arg0, object arg1);
+        public override void Write(string format, params object[] arg);
+        public virtual void WriteAttribute(string name, string value);
+        public virtual void WriteAttribute(string name, string value, bool fEncode);
+        public virtual void WriteBeginTag(string tagName);
+        public virtual void WriteBreak();
+        public virtual void WriteEncodedText(string text);
+        public virtual void WriteEncodedUrl(string url);
+        public virtual void WriteEncodedUrlParameter(string urlText);
+        public virtual void WriteEndTag(string tagName);
+        public virtual void WriteFullBeginTag(string tagName);
+        public override void WriteLine();
+        public override void WriteLine(bool value);
+        public override void WriteLine(char value);
+        public override void WriteLine(char[] buffer);
+        public override void WriteLine(char[] buffer, int index, int count);
+        public override void WriteLine(double value);
+        public override void WriteLine(int value);
+        public override void WriteLine(long value);
+        public override void WriteLine(object value);
+        public override void WriteLine(float value);
+        public override void WriteLine(string s);
+        public override void WriteLine(string format, object arg0);
+        public override void WriteLine(string format, object arg0, object arg1);
+        public override void WriteLine(string format, params object[] arg);
+        public override void WriteLine(uint value);
+        public void WriteLineNoTabs(string s);
+        public virtual void WriteStyleAttribute(string name, string value);
+        public virtual void WriteStyleAttribute(string name, string value, bool fEncode);
+        protected void WriteUrlEncodedString(string text, bool argument);
+    }
+    public enum HtmlTextWriterAttribute {
+        Abbr = 40,
+        Accesskey = 0,
+        Align = 1,
+        Alt = 2,
+        AutoComplete = 41,
+        Axis = 42,
+        Background = 3,
+        Bgcolor = 4,
+        Border = 5,
+        Bordercolor = 6,
+        Cellpadding = 7,
+        Cellspacing = 8,
+        Checked = 9,
+        Class = 10,
+        Cols = 11,
+        Colspan = 12,
+        Content = 43,
+        Coords = 44,
+        DesignerRegion = 45,
+        Dir = 46,
+        Disabled = 13,
+        For = 14,
+        Headers = 47,
+        Height = 15,
+        Href = 16,
+        Id = 17,
+        Longdesc = 48,
+        Maxlength = 18,
+        Multiple = 19,
+        Name = 20,
+        Nowrap = 21,
+        Onchange = 22,
+        Onclick = 23,
+        ReadOnly = 24,
+        Rel = 49,
+        Rows = 25,
+        Rowspan = 26,
+        Rules = 27,
+        Scope = 50,
+        Selected = 28,
+        Shape = 51,
+        Size = 29,
+        Src = 30,
+        Style = 31,
+        Tabindex = 32,
+        Target = 33,
+        Title = 34,
+        Type = 35,
+        Usemap = 52,
+        Valign = 36,
+        Value = 37,
+        VCardName = 53,
+        Width = 38,
+        Wrap = 39,
+    }
+    public enum HtmlTextWriterStyle {
+        BackgroundColor = 0,
+        BackgroundImage = 1,
+        BorderCollapse = 2,
+        BorderColor = 3,
+        BorderStyle = 4,
+        BorderWidth = 5,
+        Color = 6,
+        Cursor = 16,
+        Direction = 17,
+        Display = 18,
+        Filter = 19,
+        FontFamily = 7,
+        FontSize = 8,
+        FontStyle = 9,
+        FontVariant = 20,
+        FontWeight = 10,
+        Height = 11,
+        Left = 21,
+        ListStyleImage = 14,
+        ListStyleType = 15,
+        Margin = 22,
+        MarginBottom = 23,
+        MarginLeft = 24,
+        MarginRight = 25,
+        MarginTop = 26,
+        Overflow = 27,
+        OverflowX = 28,
+        OverflowY = 29,
+        Padding = 30,
+        PaddingBottom = 31,
+        PaddingLeft = 32,
+        PaddingRight = 33,
+        PaddingTop = 34,
+        Position = 35,
+        TextAlign = 36,
+        TextDecoration = 12,
+        TextOverflow = 38,
+        Top = 39,
+        VerticalAlign = 37,
+        Visibility = 40,
+        WhiteSpace = 41,
+        Width = 13,
+        ZIndex = 42,
+    }
+    public enum HtmlTextWriterTag {
+        A = 1,
+        Acronym = 2,
+        Address = 3,
+        Area = 4,
+        B = 5,
+        Base = 6,
+        Basefont = 7,
+        Bdo = 8,
+        Bgsound = 9,
+        Big = 10,
+        Blockquote = 11,
+        Body = 12,
+        Br = 13,
+        Button = 14,
+        Caption = 15,
+        Center = 16,
+        Cite = 17,
+        Code = 18,
+        Col = 19,
+        Colgroup = 20,
+        Dd = 21,
+        Del = 22,
+        Dfn = 23,
+        Dir = 24,
+        Div = 25,
+        Dl = 26,
+        Dt = 27,
+        Em = 28,
+        Embed = 29,
+        Fieldset = 30,
+        Font = 31,
+        Form = 32,
+        Frame = 33,
+        Frameset = 34,
+        H1 = 35,
+        H2 = 36,
+        H3 = 37,
+        H4 = 38,
+        H5 = 39,
+        H6 = 40,
+        Head = 41,
+        Hr = 42,
+        Html = 43,
+        I = 44,
+        Iframe = 45,
+        Img = 46,
+        Input = 47,
+        Ins = 48,
+        Isindex = 49,
+        Kbd = 50,
+        Label = 51,
+        Legend = 52,
+        Li = 53,
+        Link = 54,
+        Map = 55,
+        Marquee = 56,
+        Menu = 57,
+        Meta = 58,
+        Nobr = 59,
+        Noframes = 60,
+        Noscript = 61,
+        Object = 62,
+        Ol = 63,
+        Option = 64,
+        P = 65,
+        Param = 66,
+        Pre = 67,
+        Q = 68,
+        Rt = 69,
+        Ruby = 70,
+        S = 71,
+        Samp = 72,
+        Script = 73,
+        Select = 74,
+        Small = 75,
+        Span = 76,
+        Strike = 77,
+        Strong = 78,
+        Style = 79,
+        Sub = 80,
+        Sup = 81,
+        Table = 82,
+        Tbody = 83,
+        Td = 84,
+        Textarea = 85,
+        Tfoot = 86,
+        Th = 87,
+        Thead = 88,
+        Title = 89,
+        Tr = 90,
+        Tt = 91,
+        U = 92,
+        Ul = 93,
+        Unknown = 0,
+        Var = 94,
+        Wbr = 95,
+        Xml = 96,
+    }
+    public interface IAttributeAccessor {
+        string GetAttribute(string key);
+        void SetAttribute(string key, string value);
+    }
+    public interface IAutoFieldGenerator {
+        ICollection GenerateFields(Control control);
+    }
+    public interface IBindableControl {
+        void ExtractValues(IOrderedDictionary dictionary);
+    }
+    public interface IBindableTemplate : ITemplate {
+        IOrderedDictionary ExtractValues(Control container);
+    }
+    public interface ICallbackEventHandler {
+        string GetCallbackResult();
+        void RaiseCallbackEvent(string eventArgument);
+    }
+    public interface ICheckBoxControl {
+        bool Checked { get; set; }
+        event EventHandler CheckedChanged;
+    }
+    public interface ICodeBlockTypeAccessor {
+        CodeBlockType BlockType { get; }
+    }
+    public interface IControlBuilderAccessor {
+        ControlBuilder ControlBuilder { get; }
+    }
+    public interface IControlDesignerAccessor {
+        IDictionary UserData { get; }
+        IDictionary GetDesignModeState();
+        void SetDesignModeState(IDictionary data);
+        void SetOwnerControl(Control owner);
+    }
+    public interface IDataBindingsAccessor {
+        DataBindingCollection DataBindings { get; }
+        bool HasDataBindings { get; }
+    }
+    public interface IDataItemContainer : INamingContainer {
+        object DataItem { get; }
+        int DataItemIndex { get; }
+        int DisplayIndex { get; }
+    }
+    public interface IDataKeysControl {
+        string[] ClientIDRowSuffix { get; }
+        DataKeyArray ClientIDRowSuffixDataKeys { get; }
+    }
+    public interface IDataSource {
+        event EventHandler DataSourceChanged;
+        DataSourceView GetView(string viewName);
+        ICollection GetViewNames();
+    }
+    public interface IDataSourceViewSchemaAccessor {
+        object DataSourceViewSchema { get; set; }
+    }
+    public sealed class IDReferencePropertyAttribute : Attribute {
+        public IDReferencePropertyAttribute();
+        public IDReferencePropertyAttribute(Type referencedControlType);
+        public Type ReferencedControlType { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+    }
+    public interface IEditableTextControl : ITextControl {
+        event EventHandler TextChanged;
+    }
+    public interface IExpressionsAccessor {
+        ExpressionBindingCollection Expressions { get; }
+        bool HasExpressions { get; }
+    }
+    public interface IExtenderControl {
+        IEnumerable<ScriptDescriptor> GetScriptDescriptors(Control targetControl);
+        IEnumerable<ScriptReference> GetScriptReferences();
+    }
+    public interface IFilterResolutionService {
+        int CompareFilters(string filter1, string filter2);
+        bool EvaluateFilter(string filterName);
+    }
+    public interface IHierarchicalDataSource {
+        event EventHandler DataSourceChanged;
+        HierarchicalDataSourceView GetHierarchicalView(string viewPath);
+    }
+    public interface IHierarchicalEnumerable : IEnumerable {
+        IHierarchyData GetHierarchyData(object enumeratedItem);
+    }
+    public interface IHierarchyData {
+        bool HasChildren { get; }
+        object Item { get; }
+        string Path { get; }
+        string Type { get; }
+        IHierarchicalEnumerable GetChildren();
+        IHierarchyData GetParent();
+    }
+    public sealed class ImageClickEventArgs : EventArgs {
+        public double XRaw;
+        public double YRaw;
+        public int X;
+        public int Y;
+        public ImageClickEventArgs(int x, int y);
+        public ImageClickEventArgs(int x, int y, double xRaw, double yRaw);
+    }
+    public delegate void ImageClickEventHandler(object sender, ImageClickEventArgs e);
+    public interface INamingContainer
+    public interface INavigateUIData {
+        string Description { get; }
+        string Name { get; }
+        string NavigateUrl { get; }
+        string Value { get; }
+    }
+    public sealed class IndexedString {
+        public IndexedString(string s);
+        public string Value { get; }
+    }
+    public interface IParserAccessor {
+        void AddParsedSubObject(object obj);
+    }
+    public interface IPostBackDataHandler {
+        bool LoadPostData(string postDataKey, NameValueCollection postCollection);
+        void RaisePostDataChangedEvent();
+    }
+    public interface IPostBackEventHandler {
+        void RaisePostBackEvent(string eventArgument);
+    }
+    public interface IResourceUrlGenerator {
+        string GetResourceUrl(Type type, string resourceName);
+    }
+    public interface IScriptControl {
+        IEnumerable<ScriptDescriptor> GetScriptDescriptors();
+        IEnumerable<ScriptReference> GetScriptReferences();
+    }
+    public interface IStateFormatter {
+        object Deserialize(string serializedState);
+        string Serialize(object state);
+    }
+    public interface IStateManager {
+        bool IsTrackingViewState { get; }
+        void LoadViewState(object state);
+        object SaveViewState();
+        void TrackViewState();
+    }
+    public interface IStyleSheet {
+        void CreateStyleRule(Style style, IUrlResolutionService urlResolver, string selector);
+        void RegisterStyle(Style style, IUrlResolutionService urlResolver);
+    }
+    public interface ITemplate {
+        void InstantiateIn(Control container);
+    }
+    public interface ITextControl {
+        string Text { get; set; }
+    }
+    public interface IThemeResolutionService {
+        ThemeProvider[] GetAllThemeProviders();
+        ThemeProvider GetStylesheetThemeProvider();
+        ThemeProvider GetThemeProvider();
+    }
+    public interface IUrlResolutionService {
+        string ResolveClientUrl(string relativeUrl);
+    }
+    public interface IUserControlDesignerAccessor {
+        string InnerText { get; set; }
+        string TagName { get; set; }
+    }
+    public interface IUserControlTypeResolutionService {
+        Type GetType(string tagPrefix, string tagName);
+    }
+    public interface IValidator {
+        string ErrorMessage { get; set; }
+        bool IsValid { get; set; }
+        void Validate();
+    }
+    public static class ListSourceHelper {
+        public static bool ContainsListCollection(IDataSource dataSource);
+        public static IList GetList(IDataSource dataSource);
+    }
+    public class LiteralControl : Control, ITextControl {
+        public LiteralControl();
+        public LiteralControl(string text);
+        public virtual string Text { get; set; }
+        protected override ControlCollection CreateControlCollection();
+        protected internal override void Render(HtmlTextWriter output);
+    }
+    public sealed class LosFormatter {
+        public LosFormatter();
+        public LosFormatter(bool enableMac, byte[] macKeyModifier);
+        public LosFormatter(bool enableMac, string macKeyModifier);
+        public object Deserialize(Stream stream);
+        public object Deserialize(TextReader input);
+        public object Deserialize(string input);
+        public void Serialize(Stream stream, object value);
+        public void Serialize(TextWriter output, object value);
+    }
+    public class MasterPage : UserControl {
+        public MasterPage();
+        protected internal IList ContentPlaceHolders { get; }
+        protected internal IDictionary ContentTemplates { get; }
+        public MasterPage Master { get; }
+        public string MasterPageFile { get; set; }
+        protected internal void AddContentTemplate(string templateName, ITemplate template);
+        public void InstantiateInContentPlaceHolder(Control contentPlaceHolder, ITemplate template);
+    }
+    public class MasterPageControlBuilder : UserControlControlBuilder {
+        public MasterPageControlBuilder();
+    }
+    public sealed class NonVisualControlAttribute : Attribute {
+        public static readonly NonVisualControlAttribute Default;
+        public static readonly NonVisualControlAttribute NonVisual;
+        public static readonly NonVisualControlAttribute Visual;
+        public NonVisualControlAttribute();
+        public NonVisualControlAttribute(bool nonVisual);
+        public bool IsNonVisual { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public override bool IsDefaultAttribute();
+    }
+    public sealed class ObjectConverter {
+        public ObjectConverter();
+        public static object ConvertValue(object value, Type toType, string formatString);
+    }
+    public class ObjectPersistData {
+        public ObjectPersistData(ControlBuilder builder, IDictionary builtObjects);
+        public ICollection AllPropertyEntries { get; }
+        public IDictionary BuiltObjects { get; }
+        public ICollection CollectionItems { get; }
+        public ICollection EventEntries { get; }
+        public bool IsCollection { get; }
+        public bool Localize { get; }
+        public Type ObjectType { get; }
+        public string ResourceKey { get; }
+        public void AddToObjectControlBuilderTable(IDictionary table);
+        public IDictionary GetFilteredProperties(string filter);
+        public PropertyEntry GetFilteredProperty(string filter, string name);
+        public ICollection GetPropertyAllFilters(string name);
+    }
+    public sealed class ObjectStateFormatter : IFormatter, IStateFormatter, IStateFormatter2 {
+        public ObjectStateFormatter();
+        SerializationBinder System.Runtime.Serialization.IFormatter.Binder { get; set; }
+        StreamingContext System.Runtime.Serialization.IFormatter.Context { get; set; }
+        ISurrogateSelector System.Runtime.Serialization.IFormatter.SurrogateSelector { get; set; }
+        public object Deserialize(Stream inputStream);
+        public object Deserialize(string inputString);
+        public void Serialize(Stream outputStream, object stateGraph);
+        public string Serialize(object stateGraph);
+        object System.Runtime.Serialization.IFormatter.Deserialize(Stream serializationStream);
+        void System.Runtime.Serialization.IFormatter.Serialize(Stream serializationStream, object stateGraph);
+        object System.Web.UI.IStateFormatter.Deserialize(string serializedState);
+        string System.Web.UI.IStateFormatter.Serialize(object state);
+    }
+    public sealed class ObjectTagBuilder : ControlBuilder {
+        public ObjectTagBuilder();
+        public override void AppendLiteralString(string s);
+        public override void AppendSubBuilder(ControlBuilder subBuilder);
+        public override void Init(TemplateParser parser, ControlBuilder parentBuilder, Type type, string tagName, string id, IDictionary attribs);
+    }
+    public enum OutputCacheLocation {
+        Any = 0,
+        Client = 1,
+        Downstream = 2,
+        None = 4,
+        Server = 3,
+        ServerAndClient = 5,
+    }
+    public sealed class OutputCacheParameters {
+        public OutputCacheParameters();
+        public string CacheProfile { get; set; }
+        public int Duration { get; set; }
+        public bool Enabled { get; set; }
+        public OutputCacheLocation Location { get; set; }
+        public bool NoStore { get; set; }
+        public string SqlDependency { get; set; }
+        public string VaryByContentEncoding { get; set; }
+        public string VaryByControl { get; set; }
+        public string VaryByCustom { get; set; }
+        public string VaryByHeader { get; set; }
+        public string VaryByParam { get; set; }
+    }
+    public class Page : TemplateControl, IHttpHandler {
+        public const string postEventArgumentID = "__EVENTARGUMENT";
+        public const string postEventSourceID = "__EVENTTARGET";
+        public Page();
+        public HttpApplicationState Application { get; }
+        protected bool AspCompatMode { get; set; }
+        protected bool AsyncMode { get; set; }
+        public TimeSpan AsyncTimeout { get; set; }
+        public Control AutoPostBackControl { get; set; }
+        public bool Buffer { get; set; }
+        public Cache Cache { get; }
+        public string ClientQueryString { get; }
+        public ClientScriptManager ClientScript { get; }
+        public string ClientTarget { get; set; }
+        public int CodePage { get; set; }
+        public string ContentType { get; set; }
+        protected internal override HttpContext Context { get; }
+        public string Culture { get; set; }
+        public virtual bool EnableEventValidation { get; set; }
+        public override bool EnableViewState { get; set; }
+        public bool EnableViewStateMac { get; set; }
+        public string ErrorPage { get; set; }
+        protected ArrayList FileDependencies { set; }
+        public HtmlForm Form { get; }
+        public HtmlHead Header { get; }
+        public override string ID { get; set; }
+        public virtual new char IdSeparator { get; }
+        public bool IsAsync { get; }
+        public bool IsCallback { get; }
+        public bool IsCrossPagePostBack { get; }
+        public bool IsPostBack { get; }
+        public bool IsPostBackEventControlRegistered { get; }
+        public bool IsReusable { get; }
+        public bool IsValid { get; }
+        public IDictionary Items { get; }
+        public int LCID { get; set; }
+        public bool MaintainScrollPositionOnPostBack { get; set; }
+        public MasterPage Master { get; }
+        public virtual string MasterPageFile { get; set; }
+        public int MaxPageStateFieldLength { get; set; }
+        public string MetaDescription { get; set; }
+        public string MetaKeywords { get; set; }
+        public ModelBindingExecutionContext ModelBindingExecutionContext { get; }
+        public ModelStateDictionary ModelState { get; }
+        public PageAdapter PageAdapter { get; }
+        protected virtual PageStatePersister PageStatePersister { get; }
+        public Page PreviousPage { get; }
+        public HttpRequest Request { get; }
+        public HttpResponse Response { get; }
+        public string ResponseEncoding { get; set; }
+        public RouteData RouteData { get; }
+        public HttpServerUtility Server { get; }
+        public virtual HttpSessionState Session { get; }
+        public bool SkipFormActionValidation { get; set; }
+        public bool SmartNavigation { get; set; }
+        public virtual string StyleSheetTheme { get; set; }
+        public virtual string Theme { get; set; }
+        public string Title { get; set; }
+        public TraceContext Trace { get; }
+        public bool TraceEnabled { get; set; }
+        public TraceMode TraceModeValue { get; set; }
+        protected int TransactionMode { get; set; }
+        public string UICulture { get; set; }
+        protected internal virtual string UniqueFilePathSuffix { get; }
+        public UnobtrusiveValidationMode UnobtrusiveValidationMode { get; set; }
+        public IPrincipal User { get; }
+        public override ValidateRequestMode ValidateRequestMode { get; set; }
+        public ValidatorCollection Validators { get; }
+        public ViewStateEncryptionMode ViewStateEncryptionMode { get; set; }
+        public string ViewStateUserKey { get; set; }
+        public override bool Visible { get; set; }
+        public event EventHandler InitComplete;
+        public event EventHandler LoadComplete;
+        public event EventHandler PreInit;
+        public event EventHandler PreLoad;
+        public event EventHandler PreRenderComplete;
+        public event EventHandler SaveStateComplete;
+        protected internal void AddContentTemplate(string templateName, ITemplate template);
+        public void AddOnPreRenderCompleteAsync(BeginEventHandler beginHandler, EndEventHandler endHandler);
+        public void AddOnPreRenderCompleteAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state);
+        protected internal void AddWrappedFileDependencies(object virtualFileDependencies);
+        protected IAsyncResult AspCompatBeginProcessRequest(HttpContext context, AsyncCallback cb, object extraData);
+        protected void AspCompatEndProcessRequest(IAsyncResult result);
+        protected IAsyncResult AsyncPageBeginProcessRequest(HttpContext context, AsyncCallback callback, object extraData);
+        protected void AsyncPageEndProcessRequest(IAsyncResult result);
+        protected internal virtual HtmlTextWriter CreateHtmlTextWriter(TextWriter tw);
+        public static HtmlTextWriter CreateHtmlTextWriterFromType(TextWriter tw, Type writerType);
+        public void DesignerInitialize();
+        protected internal virtual NameValueCollection DeterminePostBackMode();
+        protected internal virtual NameValueCollection DeterminePostBackModeUnvalidated();
+        public void ExecuteRegisteredAsyncTasks();
+        public override Control FindControl(string id);
+        protected override void FrameworkInitialize();
+        public object GetDataItem();
+        public string GetPostBackClientEvent(Control control, string argument);
+        public string GetPostBackClientHyperlink(Control control, string argument);
+        public string GetPostBackEventReference(Control control);
+        public string GetPostBackEventReference(Control control, string argument);
+        public virtual int GetTypeHashCode();
+        public ValidatorCollection GetValidators(string validationGroup);
+        protected object GetWrappedFileDependencies(string[] virtualFileDependencies);
+        protected virtual void InitializeCulture();
+        protected virtual void InitOutputCache(int duration, string varyByContentEncoding, string varyByHeader, string varyByCustom, OutputCacheLocation location, string varyByParam);
+        protected virtual void InitOutputCache(int duration, string varyByHeader, string varyByCustom, OutputCacheLocation location, string varyByParam);
+        protected internal virtual void InitOutputCache(OutputCacheParameters cacheSettings);
+        public bool IsClientScriptBlockRegistered(string key);
+        public bool IsStartupScriptRegistered(string key);
+        protected internal virtual object LoadPageStateFromPersistenceMedium();
+        public string MapPath(string virtualPath);
+        protected internal override void OnInit(EventArgs e);
+        protected virtual void OnInitComplete(EventArgs e);
+        protected virtual void OnLoadComplete(EventArgs e);
+        protected virtual void OnPreInit(EventArgs e);
+        protected virtual void OnPreLoad(EventArgs e);
+        protected virtual void OnPreRenderComplete(EventArgs e);
+        protected virtual void OnSaveStateComplete(EventArgs e);
+        public virtual void ProcessRequest(HttpContext context);
+        protected virtual void RaisePostBackEvent(IPostBackEventHandler sourceControl, string eventArgument);
+        public void RegisterArrayDeclaration(string arrayName, string arrayValue);
+        public void RegisterAsyncTask(PageAsyncTask task);
+        public virtual void RegisterClientScriptBlock(string key, string script);
+        public virtual void RegisterHiddenField(string hiddenFieldName, string hiddenFieldInitialValue);
+        public void RegisterOnSubmitStatement(string key, string script);
+        public void RegisterRequiresControlState(Control control);
+        public void RegisterRequiresPostBack(Control control);
+        public virtual void RegisterRequiresRaiseEvent(IPostBackEventHandler control);
+        public void RegisterRequiresViewStateEncryption();
+        public virtual void RegisterStartupScript(string key, string script);
+        public void RegisterViewStateHandler();
+        protected internal override void Render(HtmlTextWriter writer);
+        public bool RequiresControlState(Control control);
+        protected internal virtual void SavePageStateToPersistenceMedium(object state);
+        public void SetFocus(string clientID);
+        public void SetFocus(Control control);
+        public virtual bool TryUpdateModel<TModel>(TModel model) where TModel : class;
+        public virtual bool TryUpdateModel<TModel>(TModel model, IValueProvider valueProvider) where TModel : class;
+        public void UnregisterRequiresControlState(Control control);
+        public virtual void UpdateModel<TModel>(TModel model) where TModel : class;
+        public virtual void UpdateModel<TModel>(TModel model, IValueProvider valueProvider) where TModel : class;
+        public virtual void Validate();
+        public virtual void Validate(string validationGroup);
+        public virtual void VerifyRenderingInServerForm(Control control);
+    }
+    public sealed class PageAsyncTask {
+        public PageAsyncTask(Func<CancellationToken, Task> handler);
+        public PageAsyncTask(Func<Task> handler);
+        public PageAsyncTask(BeginEventHandler beginHandler, EndEventHandler endHandler, EndEventHandler timeoutHandler, object state);
+        public PageAsyncTask(BeginEventHandler beginHandler, EndEventHandler endHandler, EndEventHandler timeoutHandler, object state, bool executeInParallel);
+        public BeginEventHandler BeginHandler { get; private set; }
+        public EndEventHandler EndHandler { get; private set; }
+        public bool ExecuteInParallel { get; private set; }
+        public object State { get; private set; }
+        public EndEventHandler TimeoutHandler { get; private set; }
+    }
+    public class PageHandlerFactory : IHttpHandlerFactory, IHttpHandlerFactory2 {
+        protected internal PageHandlerFactory();
+        public virtual IHttpHandler GetHandler(HttpContext context, string requestType, string virtualPath, string path);
+        public virtual void ReleaseHandler(IHttpHandler handler);
+    }
+    public sealed class PageParser : TemplateControlParser {
+        public PageParser();
+        public static Type DefaultApplicationBaseType { get; set; }
+        public static Type DefaultPageBaseType { get; set; }
+        public static Type DefaultPageParserFilterType { get; set; }
+        public static Type DefaultUserControlBaseType { get; set; }
+        public static bool EnableLongStringsAsResources { get; set; }
+        public static IHttpHandler GetCompiledPageInstance(string virtualPath, string inputFile, HttpContext context);
+    }
+    public abstract class PageParserFilter {
+        protected PageParserFilter();
+        public virtual bool AllowCode { get; }
+        protected bool CalledFromParseControl { get; private set; }
+        protected int Line { get; }
+        public virtual int NumberOfControlsAllowed { get; }
+        public virtual int NumberOfDirectDependenciesAllowed { get; }
+        public virtual int TotalNumberOfDependenciesAllowed { get; }
+        protected string VirtualPath { get; }
+        protected void AddControl(Type type, IDictionary attributes);
+        public virtual bool AllowBaseType(Type baseType);
+        public virtual bool AllowControl(Type controlType, ControlBuilder builder);
+        public virtual bool AllowServerSideInclude(string includeVirtualPath);
+        public virtual bool AllowVirtualReference(string referenceVirtualPath, VirtualReferenceType referenceType);
+        public virtual CompilationMode GetCompilationMode(CompilationMode current);
+        public virtual Type GetNoCompileUserControlType();
+        protected virtual void Initialize();
+        public virtual void ParseComplete(ControlBuilder rootBuilder);
+        public virtual void PreprocessDirective(string directiveName, IDictionary attributes);
+        public virtual bool ProcessCodeConstruct(CodeConstructType codeType, string code);
+        public virtual bool ProcessDataBindingAttribute(string controlId, string name, string value);
+        public virtual bool ProcessEventHookup(string controlId, string eventName, string handlerName);
+        protected void SetPageProperty(string filter, string name, string value);
+    }
+    public abstract class PageStatePersister {
+        protected PageStatePersister(Page page);
+        public object ControlState { get; set; }
+        protected Page Page { get; set; }
+        protected IStateFormatter StateFormatter { get; }
+        public object ViewState { get; set; }
+        public abstract void Load();
+        public abstract void Save();
+    }
+    public abstract class PageTheme {
+        protected PageTheme();
+        protected abstract string AppRelativeTemplateSourceDirectory { get; }
+        protected abstract IDictionary ControlSkins { get; }
+        protected abstract string[] LinkedStyleSheets { get; }
+        protected Page Page { get; }
+        public static object CreateSkinKey(Type controlType, string skinID);
+        protected object Eval(string expression);
+        protected string Eval(string expression, string format);
+        public bool TestDeviceFilter(string deviceFilterName);
+        protected object XPath(string xPathExpression);
+        protected string XPath(string xPathExpression, string format);
+        protected string XPath(string xPathExpression, string format, IXmlNamespaceResolver resolver);
+        protected object XPath(string xPathExpression, IXmlNamespaceResolver resolver);
+        protected IEnumerable XPathSelect(string xPathExpression);
+        protected IEnumerable XPathSelect(string xPathExpression, IXmlNamespaceResolver resolver);
+    }
+    public sealed class Pair {
+        public object First;
+        public object Second;
+        public Pair();
+        public Pair(object x, object y);
+    }
+    public sealed class ParseChildrenAttribute : Attribute {
+        public static readonly ParseChildrenAttribute Default;
+        public static readonly ParseChildrenAttribute ParseAsChildren;
+        public static readonly ParseChildrenAttribute ParseAsProperties;
+        public ParseChildrenAttribute();
+        public ParseChildrenAttribute(bool childrenAsProperties);
+        public ParseChildrenAttribute(bool childrenAsProperties, string defaultProperty);
+        public ParseChildrenAttribute(Type childControlType);
+        public Type ChildControlType { get; }
+        public bool ChildrenAsProperties { get; set; }
+        public string DefaultProperty { get; set; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public override bool IsDefaultAttribute();
+    }
+    public abstract class ParseRecorder {
+        protected ParseRecorder();
+        public static IList<Func<ParseRecorder>> RecorderFactories { get; }
+        public virtual void Initialize(TemplateParser parser);
+        public virtual void ParseComplete(ControlBuilder root);
+        public virtual void ProcessGeneratedCode(ControlBuilder builder, CodeCompileUnit codeCompileUnit, CodeTypeDeclaration baseType, CodeTypeDeclaration derivedType, CodeMemberMethod buildMethod, CodeMemberMethod dataBindingMethod);
+        public virtual void RecordBeginTag(ControlBuilder builder, Match tag);
+        public virtual void RecordCodeBlock(ControlBuilder builder, Match codeBlock);
+        public virtual void RecordEmptyTag(ControlBuilder builder, Match tag);
+        public virtual void RecordEndTag(ControlBuilder builder, Match tag);
+    }
+    public sealed class PartialCachingAttribute : Attribute {
+        public PartialCachingAttribute(int duration);
+        public PartialCachingAttribute(int duration, string varyByParams, string varyByControls, string varyByCustom);
+        public PartialCachingAttribute(int duration, string varyByParams, string varyByControls, string varyByCustom, bool shared);
+        public PartialCachingAttribute(int duration, string varyByParams, string varyByControls, string varyByCustom, string sqlDependency, bool shared);
+        public int Duration { get; set; }
+        public string ProviderName { get; set; }
+        public bool Shared { get; set; }
+        public string SqlDependency { get; set; }
+        public string VaryByControls { get; set; }
+        public string VaryByCustom { get; set; }
+        public string VaryByParams { get; set; }
+    }
+    public class PartialCachingControl : BasePartialCachingControl {
+        public Control CachedControl { get; }
+    }
+    public sealed class PersistChildrenAttribute : Attribute {
+        public static readonly PersistChildrenAttribute Default;
+        public static readonly PersistChildrenAttribute No;
+        public static readonly PersistChildrenAttribute Yes;
+        public PersistChildrenAttribute(bool persist);
+        public PersistChildrenAttribute(bool persist, bool usesCustomPersistence);
+        public bool Persist { get; }
+        public bool UsesCustomPersistence { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public override bool IsDefaultAttribute();
+    }
+    public enum PersistenceMode {
+        Attribute = 0,
+        EncodedInnerDefaultProperty = 3,
+        InnerDefaultProperty = 2,
+        InnerProperty = 1,
+    }
+    public sealed class PersistenceModeAttribute : Attribute {
+        public static readonly PersistenceModeAttribute Attribute;
+        public static readonly PersistenceModeAttribute Default;
+        public static readonly PersistenceModeAttribute EncodedInnerDefaultProperty;
+        public static readonly PersistenceModeAttribute InnerDefaultProperty;
+        public static readonly PersistenceModeAttribute InnerProperty;
+        public PersistenceModeAttribute(PersistenceMode mode);
+        public PersistenceMode Mode { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public override bool IsDefaultAttribute();
+    }
+    public sealed class PostBackOptions {
+        public PostBackOptions(Control targetControl);
+        public PostBackOptions(Control targetControl, string argument);
+        public PostBackOptions(Control targetControl, string argument, string actionUrl, bool autoPostBack, bool requiresJavaScriptProtocol, bool trackFocus, bool clientSubmit, bool performValidation, string validationGroup);
+        public string ActionUrl { get; set; }
+        public string Argument { get; set; }
+        public bool AutoPostBack { get; set; }
+        public bool ClientSubmit { get; set; }
+        public bool PerformValidation { get; set; }
+        public bool RequiresJavaScriptProtocol { get; set; }
+        public Control TargetControl { get; }
+        public bool TrackFocus { get; set; }
+        public string ValidationGroup { get; set; }
+    }
+    public class PostBackTrigger : UpdatePanelControlTrigger {
+        public PostBackTrigger();
+        public new string ControlID { get; set; }
+        protected internal override bool HasTriggered();
+        protected internal override void Initialize();
+        public override string ToString();
+    }
+    public class ProfileServiceManager {
+        public ProfileServiceManager();
+        public string[] LoadProperties { get; set; }
+        public string Path { get; set; }
+    }
+    public static class PropertyConverter {
+        public static object EnumFromString(Type enumType, string value);
+        public static string EnumToString(Type enumType, object enumValue);
+        public static object ObjectFromString(Type objType, MemberInfo propertyInfo, string value);
+    }
+    public abstract class PropertyEntry {
+        public Type DeclaringType { get; }
+        public string Filter { get; set; }
+        public string Name { get; set; }
+        public PropertyInfo PropertyInfo { get; set; }
+        public Type Type { get; set; }
+    }
+    public sealed class RegisteredArrayDeclaration {
+        public Control Control { get; }
+        public string Name { get; }
+        public string Value { get; }
+    }
+    public sealed class RegisteredDisposeScript {
+        public Control Control { get; }
+        public string Script { get; }
+    }
+    public sealed class RegisteredExpandoAttribute {
+        public Control Control { get; }
+        public string ControlId { get; }
+        public bool Encode { get; }
+        public string Name { get; }
+        public string Value { get; }
+    }
+    public sealed class RegisteredHiddenField {
+        public Control Control { get; }
+        public string InitialValue { get; }
+        public string Name { get; }
+    }
+    public sealed class RegisteredScript {
+        public bool AddScriptTags { get; }
+        public Control Control { get; }
+        public string Key { get; }
+        public string Script { get; }
+        public RegisteredScriptType ScriptType { get; }
+        public Type Type { get; }
+        public string Url { get; }
+    }
+    public enum RegisteredScriptType {
+        ClientScriptBlock = 1,
+        ClientScriptInclude = 0,
+        ClientStartupScript = 2,
+        OnSubmitStatement = 3,
+    }
+    public delegate void RenderMethod(HtmlTextWriter output, Control container);
+    public abstract class RenderTraceListener {
+        protected RenderTraceListener();
+        public static IList<Func<RenderTraceListener>> ListenerFactories { get; }
+        public virtual void BeginRendering(TextWriter writer, object renderedObject);
+        public virtual void EndRendering(TextWriter writer, object renderedObject);
+        public virtual void Initialize(HttpContext context);
+        public virtual void SetTraceData(object tracedObject, object traceDataKey, object traceDataValue);
+        public virtual void ShareTraceData(object source, object destination);
+    }
+    public class RoleServiceManager {
+        public RoleServiceManager();
+        public bool LoadRoles { get; set; }
+        public string Path { get; set; }
+    }
+    public class RootBuilder : TemplateBuilder {
+        public RootBuilder();
+        public RootBuilder(TemplateParser parser);
+        public IDictionary BuiltObjects { get; }
+        public override Type GetChildControlType(string tagName, IDictionary attribs);
+        protected internal virtual void OnCodeGenerationComplete();
+    }
+    public class ScriptBehaviorDescriptor : ScriptComponentDescriptor {
+        public ScriptBehaviorDescriptor(string type, string elementID);
+        public override string ClientID { get; }
+        public string ElementID { get; }
+        public string Name { get; set; }
+        protected internal override string GetScript();
+    }
+    public class ScriptComponentDescriptor : ScriptDescriptor {
+        public ScriptComponentDescriptor(string type);
+        public virtual string ClientID { get; }
+        public virtual string ID { get; set; }
+        public string Type { get; set; }
+        public void AddComponentProperty(string name, string componentID);
+        public void AddElementProperty(string name, string elementID);
+        public void AddEvent(string name, string handler);
+        public void AddProperty(string name, object value);
+        public void AddScriptProperty(string name, string script);
+        protected internal override string GetScript();
+    }
+    public abstract class ScriptControl : WebControl, IScriptControl {
+        protected ScriptControl();
+        protected abstract IEnumerable<ScriptDescriptor> GetScriptDescriptors();
+        protected abstract IEnumerable<ScriptReference> GetScriptReferences();
+        protected internal override void OnPreRender(EventArgs e);
+        protected internal override void Render(HtmlTextWriter writer);
+        IEnumerable<ScriptDescriptor> System.Web.UI.IScriptControl.GetScriptDescriptors();
+        IEnumerable<ScriptReference> System.Web.UI.IScriptControl.GetScriptReferences();
+    }
+    public class ScriptControlDescriptor : ScriptComponentDescriptor {
+        public ScriptControlDescriptor(string type, string elementID);
+        public override string ClientID { get; }
+        public string ElementID { get; }
+        public override string ID { get; set; }
+    }
+    public abstract class ScriptDescriptor {
+        protected ScriptDescriptor();
+        protected internal abstract string GetScript();
+    }
+    public class ScriptManager : Control, IClientUrlResolver, IControl, IPostBackDataHandler, IPostBackEventHandler, IScriptManager, IScriptManagerInternal {
+        public ScriptManager();
+        public virtual Assembly AjaxFrameworkAssembly { get; }
+        public AjaxFrameworkMode AjaxFrameworkMode { get; set; }
+        public bool AllowCustomErrorsRedirect { get; set; }
+        public string AsyncPostBackErrorMessage { get; set; }
+        public string AsyncPostBackSourceElementID { get; }
+        public int AsyncPostBackTimeout { get; set; }
+        public AuthenticationServiceManager AuthenticationService { get; }
+        public string ClientNavigateHandler { get; set; }
+        public CompositeScriptReference CompositeScript { get; }
+        public virtual string EmptyPageUrl { get; set; }
+        public bool EnableCdn { get; set; }
+        public bool EnableCdnFallback { get; set; }
+        public bool EnableHistory { get; set; }
+        public bool EnablePageMethods { get; set; }
+        public bool EnablePartialRendering { get; set; }
+        public bool EnableScriptGlobalization { get; set; }
+        public bool EnableScriptLocalization { get; set; }
+        public bool EnableSecureHistoryState { get; set; }
+        public bool IsDebuggingEnabled { get; }
+        public bool IsInAsyncPostBack { get; }
+        public bool IsNavigating { get; }
+        public bool LoadScriptsBeforeUI { get; set; }
+        public ProfileServiceManager ProfileService { get; }
+        public RoleServiceManager RoleService { get; }
+        public ScriptMode ScriptMode { get; set; }
+        public string ScriptPath { get; set; }
+        public static ScriptResourceMapping ScriptResourceMapping { get; }
+        public ScriptReferenceCollection Scripts { get; }
+        public ServiceReferenceCollection Services { get; }
+        public bool SupportsPartialRendering { get; set; }
+        public override bool Visible { get; set; }
+        public event EventHandler<AsyncPostBackErrorEventArgs> AsyncPostBackError;
+        public event EventHandler<HistoryEventArgs> Navigate;
+        public event EventHandler<CompositeScriptReferenceEventArgs> ResolveCompositeScriptReference;
+        public event EventHandler<ScriptReferenceEventArgs> ResolveScriptReference;
+        public void AddHistoryPoint(NameValueCollection state, string title);
+        public void AddHistoryPoint(string key, string value);
+        public void AddHistoryPoint(string key, string value, string title);
+        public static ScriptManager GetCurrent(Page page);
+        public ReadOnlyCollection<RegisteredArrayDeclaration> GetRegisteredArrayDeclarations();
+        public ReadOnlyCollection<RegisteredScript> GetRegisteredClientScriptBlocks();
+        public ReadOnlyCollection<RegisteredDisposeScript> GetRegisteredDisposeScripts();
+        public ReadOnlyCollection<RegisteredExpandoAttribute> GetRegisteredExpandoAttributes();
+        public ReadOnlyCollection<RegisteredHiddenField> GetRegisteredHiddenFields();
+        public ReadOnlyCollection<RegisteredScript> GetRegisteredOnSubmitStatements();
+        public ReadOnlyCollection<RegisteredScript> GetRegisteredStartupScripts();
+        public string GetStateString();
+        protected virtual bool LoadPostData(string postDataKey, NameValueCollection postCollection);
+        protected internal virtual void OnAsyncPostBackError(AsyncPostBackErrorEventArgs e);
+        protected internal override void OnInit(EventArgs e);
+        protected internal override void OnPreRender(EventArgs e);
+        protected virtual void OnResolveCompositeScriptReference(CompositeScriptReferenceEventArgs e);
+        protected virtual void OnResolveScriptReference(ScriptReferenceEventArgs e);
+        protected virtual void RaisePostBackEvent(string eventArgument);
+        protected virtual void RaisePostDataChangedEvent();
+        public static void RegisterArrayDeclaration(Control control, string arrayName, string arrayValue);
+        public static void RegisterArrayDeclaration(Page page, string arrayName, string arrayValue);
+        public void RegisterAsyncPostBackControl(Control control);
+        public static void RegisterClientScriptBlock(Control control, Type type, string key, string script, bool addScriptTags);
+        public static void RegisterClientScriptBlock(Page page, Type type, string key, string script, bool addScriptTags);
+        public static void RegisterClientScriptInclude(Control control, Type type, string key, string url);
+        public static void RegisterClientScriptInclude(Page page, Type type, string key, string url);
+        public static void RegisterClientScriptResource(Control control, Type type, string resourceName);
+        public static void RegisterClientScriptResource(Page page, Type type, string resourceName);
+        public void RegisterDataItem(Control control, string dataItem);
+        public void RegisterDataItem(Control control, string dataItem, bool isJsonSerialized);
+        public void RegisterDispose(Control control, string disposeScript);
+        public static void RegisterExpandoAttribute(Control control, string controlId, string attributeName, string attributeValue, bool encode);
+        public void RegisterExtenderControl<TExtenderControl>(TExtenderControl extenderControl, Control targetControl) where TExtenderControl : Control, IExtenderControl;
+        public static void RegisterHiddenField(Control control, string hiddenFieldName, string hiddenFieldInitialValue);
+        public static void RegisterHiddenField(Page page, string hiddenFieldName, string hiddenFieldInitialValue);
+        public static void RegisterNamedClientScriptResource(Control control, string resourceName);
+        public static void RegisterNamedClientScriptResource(Page page, string resourceName);
+        public static void RegisterOnSubmitStatement(Control control, Type type, string key, string script);
+        public static void RegisterOnSubmitStatement(Page page, Type type, string key, string script);
+        public void RegisterPostBackControl(Control control);
+        public void RegisterScriptControl<TScriptControl>(TScriptControl scriptControl) where TScriptControl : Control, IScriptControl;
+        public void RegisterScriptDescriptors(IExtenderControl extenderControl);
+        public void RegisterScriptDescriptors(IScriptControl scriptControl);
+        public static void RegisterStartupScript(Control control, Type type, string key, string script, bool addScriptTags);
+        public static void RegisterStartupScript(Page page, Type type, string key, string script, bool addScriptTags);
+        protected internal override void Render(HtmlTextWriter writer);
+        public void SetFocus(string clientID);
+        public void SetFocus(Control control);
+        bool System.Web.UI.IPostBackDataHandler.LoadPostData(string postDataKey, NameValueCollection postCollection);
+        void System.Web.UI.IPostBackDataHandler.RaisePostDataChangedEvent();
+        void System.Web.UI.IPostBackEventHandler.RaisePostBackEvent(string eventArgument);
+    }
+    public class ScriptManagerProxy : Control, IClientUrlResolver, IControl {
+        public ScriptManagerProxy();
+        public AuthenticationServiceManager AuthenticationService { get; }
+        public CompositeScriptReference CompositeScript { get; }
+        public ProfileServiceManager ProfileService { get; }
+        public RoleServiceManager RoleService { get; }
+        public ScriptReferenceCollection Scripts { get; }
+        public ServiceReferenceCollection Services { get; }
+        public override bool Visible { get; set; }
+        public event EventHandler<HistoryEventArgs> Navigate;
+        protected internal override void OnInit(EventArgs e);
+    }
+    public enum ScriptMode {
+        Auto = 0,
+        Debug = 2,
+        Inherit = 1,
+        Release = 3,
+    }
+    public class ScriptReference : ScriptReferenceBase {
+        public ScriptReference();
+        public ScriptReference(string path);
+        public ScriptReference(string name, string assembly);
+        public string Assembly { get; set; }
+        public bool IgnoreScriptPath { get; set; }
+        public string Name { get; set; }
+        protected internal override string GetUrl(ScriptManager scriptManager, bool zip);
+        protected internal override bool IsAjaxFrameworkScript(ScriptManager scriptManager);
+        protected internal override bool IsFromSystemWebExtensions();
+        public override string ToString();
+    }
+    public abstract class ScriptReferenceBase {
+        protected ScriptReferenceBase();
+        public bool NotifyScriptLoaded { get; set; }
+        public string Path { get; set; }
+        public string[] ResourceUICultures { get; set; }
+        public ScriptMode ScriptMode { get; set; }
+        protected internal abstract string GetUrl(ScriptManager scriptManager, bool zip);
+        protected internal virtual bool IsAjaxFrameworkScript(ScriptManager scriptManager);
+        protected internal abstract bool IsFromSystemWebExtensions();
+        protected static string ReplaceExtension(string pathOrName);
+    }
+    public class ScriptReferenceCollection : Collection<ScriptReference> {
+        public ScriptReferenceCollection();
+    }
+    public class ScriptReferenceEventArgs : EventArgs {
+        public ScriptReferenceEventArgs(ScriptReference script);
+        public ScriptReference Script { get; }
+    }
+    public sealed class ScriptResourceAttribute : Attribute {
+        public ScriptResourceAttribute(string scriptName);
+        public ScriptResourceAttribute(string scriptName, string stringResourceName, string stringResourceClientTypeName);
+        public string ScriptName { get; }
+        public string ScriptResourceName { get; }
+        public string StringResourceClientTypeName { get; }
+        public string StringResourceName { get; }
+        public string TypeName { get; }
+    }
+    public class ScriptResourceDefinition : IScriptResourceDefinition {
+        public ScriptResourceDefinition();
+        public string CdnDebugPath { get; set; }
+        public string CdnPath { get; set; }
+        public bool CdnSupportsSecureConnection { get; set; }
+        public string DebugPath { get; set; }
+        public string LoadSuccessExpression { get; set; }
+        public string Path { get; set; }
+        public Assembly ResourceAssembly { get; set; }
+        public string ResourceName { get; set; }
+    }
+    public class ScriptResourceMapping : IScriptResourceMapping {
+        public ScriptResourceMapping();
+        public void AddDefinition(string name, Assembly assembly, ScriptResourceDefinition definition);
+        public void AddDefinition(string name, ScriptResourceDefinition definition);
+        public void Clear();
+        public ScriptResourceDefinition GetDefinition(string name);
+        public ScriptResourceDefinition GetDefinition(string name, Assembly assembly);
+        public ScriptResourceDefinition GetDefinition(ScriptReference scriptReference);
+        public ScriptResourceDefinition RemoveDefinition(string name);
+        public ScriptResourceDefinition RemoveDefinition(string name, Assembly assembly);
+    }
+    public class ServiceReference {
+        public ServiceReference();
+        public ServiceReference(string path);
+        public virtual bool InlineScript { get; set; }
+        public virtual string Path { get; set; }
+        protected internal virtual string GetProxyScript(ScriptManager scriptManager, Control containingControl);
+        protected internal virtual string GetProxyUrl(ScriptManager scriptManager, Control containingControl);
+        public override string ToString();
+    }
+    public class ServiceReferenceCollection : Collection<ServiceReference> {
+        public ServiceReferenceCollection();
+    }
+    public class SessionPageStatePersister : PageStatePersister {
+        public SessionPageStatePersister(Page page);
+        public override void Load();
+        public override void Save();
+    }
+    public class SimplePropertyEntry : PropertyEntry {
+        public string PersistedValue { get; set; }
+        public bool UseSetAttribute { get; set; }
+        public object Value { get; set; }
+    }
+    public abstract class SimpleWebHandlerParser : IAssemblyDependencyParser {
+        protected SimpleWebHandlerParser(HttpContext context, string virtualPath, string physicalPath);
+        protected abstract string DefaultDirectiveName { get; }
+        protected Type GetCompiledTypeFromCache();
+    }
+    public sealed class SkinBuilder : ControlBuilder {
+        public SkinBuilder(ThemeProvider provider, Control control, ControlBuilder skinBuilder, string themePath);
+        public Control ApplyTheme();
+    }
+    public sealed class StateBag : ICollection, IDictionary, IEnumerable, IStateManager {
+        public StateBag();
+        public StateBag(bool ignoreCase);
+        public int Count { get; }
+        public ICollection Keys { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IDictionary.IsFixedSize { get; }
+        bool System.Collections.IDictionary.IsReadOnly { get; }
+        object System.Collections.IDictionary.this[object key] { get; set; }
+        bool System.Web.UI.IStateManager.IsTrackingViewState { get; }
+        public object this[string key] { get; set; }
+        public ICollection Values { get; }
+        public StateItem Add(string key, object value);
+        public void Clear();
+        public IDictionaryEnumerator GetEnumerator();
+        public bool IsItemDirty(string key);
+        public void Remove(string key);
+        public void SetDirty(bool dirty);
+        public void SetItemDirty(string key, bool dirty);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        void System.Collections.IDictionary.Add(object key, object value);
+        bool System.Collections.IDictionary.Contains(object key);
+        void System.Collections.IDictionary.Remove(object key);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        void System.Web.UI.IStateManager.LoadViewState(object state);
+        object System.Web.UI.IStateManager.SaveViewState();
+        void System.Web.UI.IStateManager.TrackViewState();
+    }
+    public sealed class StateItem {
+        public bool IsDirty { get; set; }
+        public object Value { get; set; }
+    }
+    public abstract class StateManagedCollection : ICollection, IEnumerable, IList, IStateManager {
+        protected StateManagedCollection();
+        public int Count { get; }
+        int System.Collections.ICollection.Count { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        bool System.Web.UI.IStateManager.IsTrackingViewState { get; }
+        public void Clear();
+        public void CopyTo(Array array, int index);
+        protected virtual object CreateKnownType(int index);
+        public IEnumerator GetEnumerator();
+        protected virtual Type[] GetKnownTypes();
+        protected virtual void OnClear();
+        protected virtual void OnClearComplete();
+        protected virtual void OnInsert(int index, object value);
+        protected virtual void OnInsertComplete(int index, object value);
+        protected virtual void OnRemove(int index, object value);
+        protected virtual void OnRemoveComplete(int index, object value);
+        protected virtual void OnValidate(object value);
+        public void SetDirty();
+        protected abstract void SetDirtyObject(object o);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        void System.Collections.IList.Clear();
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        void System.Collections.IList.RemoveAt(int index);
+        void System.Web.UI.IStateManager.LoadViewState(object savedState);
+        object System.Web.UI.IStateManager.SaveViewState();
+        void System.Web.UI.IStateManager.TrackViewState();
+    }
+    public class StaticPartialCachingControl : BasePartialCachingControl {
+        public StaticPartialCachingControl(string ctrlID, string guid, int duration, string varyByParams, string varyByControls, string varyByCustom, string sqlDependency, BuildMethod buildMethod);
+        public StaticPartialCachingControl(string ctrlID, string guid, int duration, string varyByParams, string varyByControls, string varyByCustom, string sqlDependency, BuildMethod buildMethod, string providerName);
+        public StaticPartialCachingControl(string ctrlID, string guid, int duration, string varyByParams, string varyByControls, string varyByCustom, BuildMethod buildMethod);
+        public static void BuildCachedControl(Control parent, string ctrlID, string guid, int duration, string varyByParams, string varyByControls, string varyByCustom, string sqlDependency, BuildMethod buildMethod);
+        public static void BuildCachedControl(Control parent, string ctrlID, string guid, int duration, string varyByParams, string varyByControls, string varyByCustom, string sqlDependency, BuildMethod buildMethod, string providerName);
+        public static void BuildCachedControl(Control parent, string ctrlID, string guid, int duration, string varyByParams, string varyByControls, string varyByCustom, BuildMethod buildMethod);
+    }
+    public sealed class SupportsEventValidationAttribute : Attribute {
+        public SupportsEventValidationAttribute();
+    }
+    public sealed class TagPrefixAttribute : Attribute {
+        public TagPrefixAttribute(string namespaceName, string tagPrefix);
+        public string NamespaceName { get; }
+        public string TagPrefix { get; }
+    }
+    public sealed class TargetControlTypeAttribute : Attribute {
+        public TargetControlTypeAttribute(Type targetControlType);
+        public Type TargetControlType { get; }
+        public override object TypeId { get; }
+    }
+    public class TemplateBuilder : ControlBuilder, ITemplate {
+        public TemplateBuilder();
+        public virtual string Text { get; set; }
+        public override object BuildObject();
+        public override void CloseControl();
+        public override void Init(TemplateParser parser, ControlBuilder parentBuilder, Type type, string tagName, string ID, IDictionary attribs);
+        public virtual void InstantiateIn(Control container);
+        public override bool NeedsTagInnerText();
+        public override void SetTagInnerText(string text);
+    }
+    public sealed class TemplateContainerAttribute : Attribute {
+        public TemplateContainerAttribute(Type containerType);
+        public TemplateContainerAttribute(Type containerType, BindingDirection bindingDirection);
+        public BindingDirection BindingDirection { get; }
+        public Type ContainerType { get; }
+    }
+    public abstract class TemplateControl : Control, IFilterResolutionService, INamingContainer {
+        protected TemplateControl();
+        public string AppRelativeVirtualPath { get; set; }
+        protected virtual int AutoHandlers { get; set; }
+        public override bool EnableTheming { get; set; }
+        protected virtual bool SupportAutoEvents { get; }
+        public event EventHandler AbortTransaction;
+        public event EventHandler CommitTransaction;
+        public event EventHandler Error;
+        protected virtual void Construct();
+        protected LiteralControl CreateResourceBasedLiteralControl(int offset, int size, bool fAsciiOnly);
+        protected internal object Eval(string expression);
+        protected internal string Eval(string expression, string format);
+        protected virtual void FrameworkInitialize();
+        protected object GetGlobalResourceObject(string className, string resourceKey);
+        protected object GetGlobalResourceObject(string className, string resourceKey, Type objType, string propName);
+        protected object GetLocalResourceObject(string resourceKey);
+        protected object GetLocalResourceObject(string resourceKey, Type objType, string propName);
+        public Control LoadControl(string virtualPath);
+        public Control LoadControl(Type t, object[] parameters);
+        public ITemplate LoadTemplate(string virtualPath);
+        protected virtual void OnAbortTransaction(EventArgs e);
+        protected virtual void OnCommitTransaction(EventArgs e);
+        protected virtual void OnError(EventArgs e);
+        public Control ParseControl(string content);
+        public Control ParseControl(string content, bool ignoreParserFilter);
+        public object ReadStringResource();
+        public static object ReadStringResource(Type t);
+        protected void SetStringResourcePointer(object stringResourcePointer, int maxResourceOffset);
+        int System.Web.UI.IFilterResolutionService.CompareFilters(string filter1, string filter2);
+        bool System.Web.UI.IFilterResolutionService.EvaluateFilter(string filterName);
+        public virtual bool TestDeviceFilter(string filterName);
+        protected void WriteUTF8ResourceString(HtmlTextWriter output, int offset, int size, bool fAsciiOnly);
+        protected internal object XPath(string xPathExpression);
+        protected internal string XPath(string xPathExpression, string format);
+        protected internal string XPath(string xPathExpression, string format, IXmlNamespaceResolver resolver);
+        protected internal object XPath(string xPathExpression, IXmlNamespaceResolver resolver);
+        protected internal IEnumerable XPathSelect(string xPathExpression);
+        protected internal IEnumerable XPathSelect(string xPathExpression, IXmlNamespaceResolver resolver);
+    }
+    public abstract class TemplateControlParser : BaseTemplateParser {
+        protected TemplateControlParser();
+    }
+    public enum TemplateInstance {
+        Multiple = 0,
+        Single = 1,
+    }
+    public sealed class TemplateInstanceAttribute : Attribute {
+        public static readonly TemplateInstanceAttribute Default;
+        public static readonly TemplateInstanceAttribute Multiple;
+        public static readonly TemplateInstanceAttribute Single;
+        public TemplateInstanceAttribute(TemplateInstance instances);
+        public TemplateInstance Instances { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public override bool IsDefaultAttribute();
+    }
+    public abstract class TemplateParser : BaseParser, IAssemblyDependencyParser {
+        public string Text { get; internal set; }
+        protected void ParseFile(string physicalPath, string virtualPath);
+        public static ITemplate ParseTemplate(string content, string virtualPath, bool ignoreFilter);
+        protected void ProcessError(string message);
+        protected void ProcessException(Exception ex);
+    }
+    public class TemplatePropertyEntry : BuilderPropertyEntry {
+        public bool BindableTemplate { get; }
+    }
+    public sealed class ThemeableAttribute : Attribute {
+        public static readonly ThemeableAttribute Default;
+        public static readonly ThemeableAttribute No;
+        public static readonly ThemeableAttribute Yes;
+        public ThemeableAttribute(bool themeable);
+        public bool Themeable { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public override bool IsDefaultAttribute();
+        public static bool IsObjectThemeable(object instance);
+        public static bool IsTypeThemeable(Type type);
+    }
+    public sealed class ThemeProvider {
+        public ThemeProvider(IDesignerHost host, string name, string themeDefinition, string[] cssFiles, string themePath);
+        public int ContentHashCode { get; }
+        public ICollection CssFiles { get; }
+        public IDesignerHost DesignerHost { get; }
+        public string ThemeName { get; }
+        public SkinBuilder GetSkinBuilder(Control control);
+        public IDictionary GetSkinControlBuildersForControlType(Type type);
+        public ICollection GetSkinsForControl(Type type);
+    }
+    public class Timer : Control, IPostBackEventHandler, IScriptControl {
+        public Timer();
+        public bool Enabled { get; set; }
+        public int Interval { get; set; }
+        public override bool Visible { get; set; }
+        public event EventHandler<EventArgs> Tick;
+        protected virtual IEnumerable<ScriptDescriptor> GetScriptDescriptors();
+        protected virtual IEnumerable<ScriptReference> GetScriptReferences();
+        protected internal override void OnPreRender(EventArgs e);
+        protected virtual void OnTick(EventArgs e);
+        protected virtual void RaisePostBackEvent(string eventArgument);
+        protected internal override void Render(HtmlTextWriter writer);
+        void System.Web.UI.IPostBackEventHandler.RaisePostBackEvent(string eventArgument);
+        IEnumerable<ScriptDescriptor> System.Web.UI.IScriptControl.GetScriptDescriptors();
+        IEnumerable<ScriptReference> System.Web.UI.IScriptControl.GetScriptReferences();
+    }
+    public sealed class ToolboxDataAttribute : Attribute {
+        public static readonly ToolboxDataAttribute Default;
+        public ToolboxDataAttribute(string data);
+        public string Data { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public override bool IsDefaultAttribute();
+    }
+    public sealed class Triplet {
+        public object First;
+        public object Second;
+        public object Third;
+        public Triplet();
+        public Triplet(object x, object y);
+        public Triplet(object x, object y, object z);
+    }
+    public enum UnobtrusiveValidationMode {
+        None = 0,
+        WebForms = 1,
+    }
+    public class UpdatePanel : Control, IAttributeAccessor, IUpdatePanel {
+        public UpdatePanel();
+        public AttributeCollection Attributes { get; }
+        public bool ChildrenAsTriggers { get; set; }
+        public ITemplate ContentTemplate { get; set; }
+        public Control ContentTemplateContainer { get; }
+        public sealed override ControlCollection Controls { get; }
+        public bool IsInPartialRendering { get; }
+        public UpdatePanelRenderMode RenderMode { get; set; }
+        protected internal virtual bool RequiresUpdate { get; }
+        public UpdatePanelTriggerCollection Triggers { get; }
+        public UpdatePanelUpdateMode UpdateMode { get; set; }
+        protected virtual Control CreateContentTemplateContainer();
+        protected sealed override ControlCollection CreateControlCollection();
+        protected internal virtual void Initialize();
+        protected internal override void OnInit(EventArgs e);
+        protected internal override void OnLoad(EventArgs e);
+        protected internal override void OnPreRender(EventArgs e);
+        protected internal override void OnUnload(EventArgs e);
+        protected internal override void Render(HtmlTextWriter writer);
+        protected internal override void RenderChildren(HtmlTextWriter writer);
+        string System.Web.UI.IAttributeAccessor.GetAttribute(string key);
+        void System.Web.UI.IAttributeAccessor.SetAttribute(string key, string value);
+        public void Update();
+    }
+    public abstract class UpdatePanelControlTrigger : UpdatePanelTrigger {
+        protected UpdatePanelControlTrigger();
+        public string ControlID { get; set; }
+        protected Control FindTargetControl(bool searchNamingContainers);
+    }
+    public enum UpdatePanelRenderMode {
+        Block = 0,
+        Inline = 1,
+    }
+    public abstract class UpdatePanelTrigger {
+        protected UpdatePanelTrigger();
+        public UpdatePanel Owner { get; }
+        protected internal abstract bool HasTriggered();
+        protected internal virtual void Initialize();
+    }
+    public class UpdatePanelTriggerCollection : Collection<UpdatePanelTrigger> {
+        public UpdatePanelTriggerCollection(UpdatePanel owner);
+        public UpdatePanel Owner { get; }
+        protected override void ClearItems();
+        protected override void InsertItem(int index, UpdatePanelTrigger item);
+        protected override void RemoveItem(int index);
+        protected override void SetItem(int index, UpdatePanelTrigger item);
+    }
+    public enum UpdatePanelUpdateMode {
+        Always = 0,
+        Conditional = 1,
+    }
+    public class UpdateProgress : Control, IAttributeAccessor, IScriptControl {
+        public UpdateProgress();
+        public string AssociatedUpdatePanelID { get; set; }
+        public AttributeCollection Attributes { get; }
+        public override ControlCollection Controls { get; }
+        public int DisplayAfter { get; set; }
+        public bool DynamicLayout { get; set; }
+        public ITemplate ProgressTemplate { get; set; }
+        protected internal override void CreateChildControls();
+        public override void DataBind();
+        protected virtual IEnumerable<ScriptDescriptor> GetScriptDescriptors();
+        protected virtual IEnumerable<ScriptReference> GetScriptReferences();
+        protected internal override void OnPreRender(EventArgs e);
+        protected internal override void Render(HtmlTextWriter writer);
+        string System.Web.UI.IAttributeAccessor.GetAttribute(string key);
+        void System.Web.UI.IAttributeAccessor.SetAttribute(string key, string value);
+        IEnumerable<ScriptDescriptor> System.Web.UI.IScriptControl.GetScriptDescriptors();
+        IEnumerable<ScriptReference> System.Web.UI.IScriptControl.GetScriptReferences();
+    }
+    public sealed class UrlPropertyAttribute : Attribute {
+        public UrlPropertyAttribute();
+        public UrlPropertyAttribute(string filter);
+        public string Filter { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+    }
+    public class UserControl : TemplateControl, IAttributeAccessor, INamingContainer, INonBindingContainer, IUserControlDesignerAccessor {
+        public UserControl();
+        public HttpApplicationState Application { get; }
+        public AttributeCollection Attributes { get; }
+        public Cache Cache { get; }
+        public ControlCachePolicy CachePolicy { get; }
+        public bool IsPostBack { get; }
+        public HttpRequest Request { get; }
+        public HttpResponse Response { get; }
+        public HttpServerUtility Server { get; }
+        public HttpSessionState Session { get; }
+        string System.Web.UI.IUserControlDesignerAccessor.InnerText { get; set; }
+        string System.Web.UI.IUserControlDesignerAccessor.TagName { get; set; }
+        public TraceContext Trace { get; }
+        public void DesignerInitialize();
+        public void InitializeAsUserControl(Page page);
+        protected override void LoadViewState(object savedState);
+        public string MapPath(string virtualPath);
+        protected internal override void OnInit(EventArgs e);
+        protected override object SaveViewState();
+        string System.Web.UI.IAttributeAccessor.GetAttribute(string name);
+        void System.Web.UI.IAttributeAccessor.SetAttribute(string name, string value);
+        public virtual bool TryUpdateModel<TModel>(TModel model) where TModel : class;
+        public virtual bool TryUpdateModel<TModel>(TModel model, IValueProvider valueProvider) where TModel : class;
+        public virtual void UpdateModel<TModel>(TModel model) where TModel : class;
+        public virtual void UpdateModel<TModel>(TModel model, IValueProvider valueProvider) where TModel : class;
+    }
+    public class UserControlControlBuilder : ControlBuilder {
+        public UserControlControlBuilder();
+        public override object BuildObject();
+        public override bool NeedsTagInnerText();
+        public override void SetTagInnerText(string text);
+    }
+    public enum ValidateRequestMode {
+        Disabled = 1,
+        Enabled = 2,
+        Inherit = 0,
+    }
+    public sealed class ValidationPropertyAttribute : Attribute {
+        public ValidationPropertyAttribute(string name);
+        public string Name { get; }
+    }
+    public static class ValidationSettings {
+        public static UnobtrusiveValidationMode UnobtrusiveValidationMode { get; set; }
+    }
+    public sealed class ValidatorCollection : ICollection, IEnumerable {
+        public ValidatorCollection();
+        public int Count { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        public IValidator this[int index] { get; }
+        public void Add(IValidator validator);
+        public bool Contains(IValidator validator);
+        public void CopyTo(Array array, int index);
+        public IEnumerator GetEnumerator();
+        public void Remove(IValidator validator);
+    }
+    public sealed class VerificationAttribute : Attribute {
+        public VerificationAttribute(string guideline, string checkpoint, VerificationReportLevel reportLevel, int priority, string message);
+        public VerificationAttribute(string guideline, string checkpoint, VerificationReportLevel reportLevel, int priority, string message, VerificationRule rule, string conditionalProperty);
+        public VerificationAttribute(string guideline, string checkpoint, VerificationReportLevel reportLevel, int priority, string message, VerificationRule rule, string conditionalProperty, VerificationConditionalOperator conditionalOperator, string conditionalValue, string guidelineUrl);
+        public string Checkpoint { get; }
+        public string ConditionalProperty { get; }
+        public string ConditionalValue { get; }
+        public string Guideline { get; }
+        public string GuidelineUrl { get; }
+        public string Message { get; }
+        public int Priority { get; }
+        public VerificationConditionalOperator VerificationConditionalOperator { get; }
+        public VerificationReportLevel VerificationReportLevel { get; }
+        public VerificationRule VerificationRule { get; }
+    }
+    public enum VerificationConditionalOperator {
+        Equals = 0,
+        NotEquals = 1,
+    }
+    public enum VerificationReportLevel {
+        Error = 0,
+        Guideline = 2,
+        Warning = 1,
+    }
+    public enum VerificationRule {
+        NotEmptyString = 2,
+        Prohibited = 1,
+        Required = 0,
+    }
+    public enum ViewStateEncryptionMode {
+        Always = 1,
+        Auto = 0,
+        Never = 2,
+    }
+    public sealed class ViewStateException : Exception, ISerializable {
+        public ViewStateException();
+        public bool IsConnected { get; }
+        public override string Message { get; }
+        public string Path { get; }
+        public string PersistedState { get; }
+        public string Referer { get; }
+        public string RemoteAddress { get; }
+        public string RemotePort { get; }
+        public string UserAgent { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public enum ViewStateMode {
+        Disabled = 2,
+        Enabled = 1,
+        Inherit = 0,
+    }
+    public sealed class ViewStateModeByIdAttribute : Attribute {
+        public ViewStateModeByIdAttribute();
+    }
+    public enum VirtualReferenceType {
+        Master = 2,
+        Other = 4,
+        Page = 0,
+        SourceFile = 3,
+        UserControl = 1,
+    }
+    public sealed class WebResourceAttribute : Attribute {
+        public WebResourceAttribute(string webResource, string contentType);
+        public string CdnPath { get; set; }
+        public bool CdnSupportsSecureConnection { get; set; }
+        public string ContentType { get; }
+        public string LoadSuccessExpression { get; set; }
+        public bool PerformSubstitution { get; set; }
+        public string WebResource { get; }
+    }
+    public class WebServiceParser : SimpleWebHandlerParser {
+        protected override string DefaultDirectiveName { get; }
+        public static Type GetCompiledType(string inputFile, HttpContext context);
+    }
+    public enum XhtmlMobileDocType {
+        Wml20 = 2,
+        XhtmlBasic = 0,
+        XhtmlMobileProfile = 1,
+    }
+    public class XhtmlTextWriter : HtmlTextWriter {
+        public XhtmlTextWriter(TextWriter writer);
+        public XhtmlTextWriter(TextWriter writer, string tabString);
+        protected Hashtable CommonAttributes { get; }
+        protected Hashtable ElementSpecificAttributes { get; }
+        protected Hashtable SuppressCommonAttributes { get; }
+        public virtual void AddRecognizedAttribute(string elementName, string attributeName);
+        public override bool IsValidFormAttribute(string attributeName);
+        protected override bool OnAttributeRender(string name, string value, HtmlTextWriterAttribute key);
+        protected override bool OnStyleAttributeRender(string name, string value, HtmlTextWriterStyle key);
+        public virtual void RemoveRecognizedAttribute(string elementName, string attributeName);
+        public virtual void SetDocType(XhtmlMobileDocType docType);
+        public override void WriteBreak();
+    }
+    public sealed class XPathBinder {
+        public static object Eval(object container, string xPath);
+        public static string Eval(object container, string xPath, string format);
+        public static string Eval(object container, string xPath, string format, IXmlNamespaceResolver resolver);
+        public static object Eval(object container, string xPath, IXmlNamespaceResolver resolver);
+        public static IEnumerable Select(object container, string xPath);
+        public static IEnumerable Select(object container, string xPath, IXmlNamespaceResolver resolver);
+    }
+}
```

