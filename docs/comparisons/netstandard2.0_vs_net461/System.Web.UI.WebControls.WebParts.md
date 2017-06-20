# System.Web.UI.WebControls.WebParts

``` diff
+namespace System.Web.UI.WebControls.WebParts {
+    public sealed class AppearanceEditorPart : EditorPart {
+        public AppearanceEditorPart();
+        public override string DefaultButton { get; set; }
+        public override string Title { get; set; }
+        public override bool ApplyChanges();
+        protected internal override void CreateChildControls();
+        protected internal override void OnPreRender(EventArgs e);
+        protected internal override void RenderContents(HtmlTextWriter writer);
+        public override void SyncChanges();
+    }
+    public sealed class BehaviorEditorPart : EditorPart {
+        public BehaviorEditorPart();
+        public override string DefaultButton { get; set; }
+        public override bool Display { get; }
+        public override string Title { get; set; }
+        public override bool ApplyChanges();
+        protected internal override void CreateChildControls();
+        protected internal override void OnPreRender(EventArgs e);
+        protected internal override void RenderContents(HtmlTextWriter writer);
+        public override void SyncChanges();
+    }
+    public abstract class CatalogPart : Part {
+        protected CatalogPart();
+        public string DisplayTitle { get; }
+        protected WebPartManager WebPartManager { get; }
+        protected CatalogZoneBase Zone { get; }
+        public abstract WebPartDescriptionCollection GetAvailableWebPartDescriptions();
+        protected override IDictionary GetDesignModeState();
+        public abstract WebPart GetWebPart(WebPartDescription description);
+        protected internal override void OnPreRender(EventArgs e);
+        protected override void SetDesignModeState(IDictionary data);
+    }
+    public class CatalogPartChrome {
+        public CatalogPartChrome(CatalogZoneBase zone);
+        protected CatalogZoneBase Zone { get; }
+        protected virtual Style CreateCatalogPartChromeStyle(CatalogPart catalogPart, PartChromeType chromeType);
+        public virtual void PerformPreRender();
+        public virtual void RenderCatalogPart(HtmlTextWriter writer, CatalogPart catalogPart);
+        protected virtual void RenderPartContents(HtmlTextWriter writer, CatalogPart catalogPart);
+    }
+    public sealed class CatalogPartCollection : ReadOnlyCollectionBase {
+        public static readonly CatalogPartCollection Empty;
+        public CatalogPartCollection();
+        public CatalogPartCollection(ICollection catalogParts);
+        public CatalogPartCollection(CatalogPartCollection existingCatalogParts, ICollection catalogParts);
+        public CatalogPart this[int index] { get; }
+        public CatalogPart this[string id] { get; }
+        public bool Contains(CatalogPart catalogPart);
+        public void CopyTo(CatalogPart[] array, int index);
+        public int IndexOf(CatalogPart catalogPart);
+    }
+    public class CatalogZone : CatalogZoneBase {
+        public CatalogZone();
+        public virtual ITemplate ZoneTemplate { get; set; }
+        protected override CatalogPartCollection CreateCatalogParts();
+    }
+    public abstract class CatalogZoneBase : ToolZone, IPostBackDataHandler {
+        protected CatalogZoneBase();
+        public virtual WebPartVerb AddVerb { get; }
+        public CatalogPartChrome CatalogPartChrome { get; }
+        public CatalogPartCollection CatalogParts { get; }
+        public virtual WebPartVerb CloseVerb { get; }
+        public override string EmptyZoneText { get; set; }
+        public override string HeaderText { get; set; }
+        public override string InstructionText { get; set; }
+        public Style PartLinkStyle { get; }
+        public string SelectedCatalogPartID { get; set; }
+        public Style SelectedPartLinkStyle { get; }
+        public virtual string SelectTargetZoneText { get; set; }
+        public virtual bool ShowCatalogIcons { get; set; }
+        protected override void Close();
+        protected virtual CatalogPartChrome CreateCatalogPartChrome();
+        protected abstract CatalogPartCollection CreateCatalogParts();
+        protected internal override void CreateChildControls();
+        protected void InvalidateCatalogParts();
+        protected internal override void LoadControlState(object savedState);
+        protected virtual bool LoadPostData(string postDataKey, NameValueCollection postCollection);
+        protected override void LoadViewState(object savedState);
+        protected internal override void OnInit(EventArgs e);
+        protected internal override void OnPreRender(EventArgs e);
+        protected override void RaisePostBackEvent(string eventArgument);
+        protected internal override void Render(HtmlTextWriter writer);
+        protected override void RenderBody(HtmlTextWriter writer);
+        protected virtual void RenderCatalogPartLinks(HtmlTextWriter writer);
+        protected override void RenderFooter(HtmlTextWriter writer);
+        protected override void RenderVerbs(HtmlTextWriter writer);
+        protected internal override object SaveControlState();
+        protected override object SaveViewState();
+        bool System.Web.UI.IPostBackDataHandler.LoadPostData(string postDataKey, NameValueCollection postCollection);
+        void System.Web.UI.IPostBackDataHandler.RaisePostDataChangedEvent();
+        protected override void TrackViewState();
+    }
+    public class ConnectionConsumerAttribute : Attribute {
+        public ConnectionConsumerAttribute(string displayName);
+        public ConnectionConsumerAttribute(string displayName, string id);
+        public ConnectionConsumerAttribute(string displayName, string id, Type connectionPointType);
+        public ConnectionConsumerAttribute(string displayName, Type connectionPointType);
+        public bool AllowsMultipleConnections { get; set; }
+        public Type ConnectionPointType { get; }
+        public virtual string DisplayName { get; }
+        protected string DisplayNameValue { get; set; }
+        public string ID { get; }
+    }
+    public sealed class ConnectionInterfaceCollection : ReadOnlyCollectionBase {
+        public static readonly ConnectionInterfaceCollection Empty;
+        public ConnectionInterfaceCollection();
+        public ConnectionInterfaceCollection(ICollection connectionInterfaces);
+        public ConnectionInterfaceCollection(ConnectionInterfaceCollection existingConnectionInterfaces, ICollection connectionInterfaces);
+        public Type this[int index] { get; }
+        public bool Contains(Type value);
+        public void CopyTo(Type[] array, int index);
+        public int IndexOf(Type value);
+    }
+    public abstract class ConnectionPoint {
+        public static readonly string DefaultID;
+        public bool AllowsMultipleConnections { get; }
+        public Type ControlType { get; }
+        public string DisplayName { get; }
+        public string ID { get; }
+        public Type InterfaceType { get; }
+        public virtual bool GetEnabled(Control control);
+    }
+    public class ConnectionProviderAttribute : Attribute {
+        public ConnectionProviderAttribute(string displayName);
+        public ConnectionProviderAttribute(string displayName, string id);
+        public ConnectionProviderAttribute(string displayName, string id, Type connectionPointType);
+        public ConnectionProviderAttribute(string displayName, Type connectionPointType);
+        public bool AllowsMultipleConnections { get; set; }
+        public Type ConnectionPointType { get; }
+        public virtual string DisplayName { get; }
+        protected string DisplayNameValue { get; set; }
+        public string ID { get; }
+    }
+    public class ConnectionsZone : ToolZone {
+        public ConnectionsZone();
+        public virtual WebPartVerb CancelVerb { get; }
+        public virtual WebPartVerb CloseVerb { get; }
+        public virtual string ConfigureConnectionTitle { get; set; }
+        public virtual WebPartVerb ConfigureVerb { get; }
+        public virtual string ConnectToConsumerInstructionText { get; set; }
+        public virtual string ConnectToConsumerText { get; set; }
+        public virtual string ConnectToConsumerTitle { get; set; }
+        public virtual string ConnectToProviderInstructionText { get; set; }
+        public virtual string ConnectToProviderText { get; set; }
+        public virtual string ConnectToProviderTitle { get; set; }
+        public virtual WebPartVerb ConnectVerb { get; }
+        public virtual string ConsumersInstructionText { get; set; }
+        public virtual string ConsumersTitle { get; set; }
+        public virtual WebPartVerb DisconnectVerb { get; }
+        protected override bool Display { get; }
+        public override string EmptyZoneText { get; set; }
+        public virtual string ExistingConnectionErrorMessage { get; set; }
+        public virtual string GetFromText { get; set; }
+        public virtual string GetText { get; set; }
+        public override string HeaderText { get; set; }
+        public override string InstructionText { get; set; }
+        public virtual string InstructionTitle { get; set; }
+        public virtual string NewConnectionErrorMessage { get; set; }
+        public virtual string NoExistingConnectionInstructionText { get; set; }
+        public virtual string NoExistingConnectionTitle { get; set; }
+        public override PartChromeType PartChromeType { get; set; }
+        public virtual string ProvidersInstructionText { get; set; }
+        public virtual string ProvidersTitle { get; set; }
+        public virtual string SendText { get; set; }
+        public virtual string SendToText { get; set; }
+        protected WebPart WebPartToConnect { get; }
+        protected override void Close();
+        protected internal override void CreateChildControls();
+        protected internal override void LoadControlState(object savedState);
+        protected override void LoadViewState(object savedState);
+        protected override void OnDisplayModeChanged(object sender, WebPartDisplayModeEventArgs e);
+        protected internal override void OnInit(EventArgs e);
+        protected override void OnSelectedWebPartChanged(object sender, WebPartEventArgs e);
+        protected override void RaisePostBackEvent(string eventArgument);
+        protected internal override void Render(HtmlTextWriter writer);
+        protected override void RenderBody(HtmlTextWriter writer);
+        protected override void RenderVerbs(HtmlTextWriter writer);
+        protected internal override object SaveControlState();
+        protected override object SaveViewState();
+        protected override void TrackViewState();
+    }
+    public class ConsumerConnectionPoint : ConnectionPoint {
+        public ConsumerConnectionPoint(MethodInfo callbackMethod, Type interfaceType, Type controlType, string displayName, string id, bool allowsMultipleConnections);
+        public virtual void SetObject(Control control, object data);
+        public virtual bool SupportsConnection(Control control, ConnectionInterfaceCollection secondaryInterfaces);
+    }
+    public sealed class ConsumerConnectionPointCollection : ReadOnlyCollectionBase {
+        public ConsumerConnectionPointCollection();
+        public ConsumerConnectionPointCollection(ICollection connectionPoints);
+        public ConsumerConnectionPoint Default { get; }
+        public ConsumerConnectionPoint this[int index] { get; }
+        public ConsumerConnectionPoint this[string id] { get; }
+        public bool Contains(ConsumerConnectionPoint connectionPoint);
+        public void CopyTo(ConsumerConnectionPoint[] array, int index);
+        public int IndexOf(ConsumerConnectionPoint connectionPoint);
+    }
+    public sealed class DeclarativeCatalogPart : CatalogPart {
+        public DeclarativeCatalogPart();
+        public override string AccessKey { get; set; }
+        public override Color BackColor { get; set; }
+        public override string BackImageUrl { get; set; }
+        public override Color BorderColor { get; set; }
+        public override BorderStyle BorderStyle { get; set; }
+        public override Unit BorderWidth { get; set; }
+        public override string CssClass { get; set; }
+        public override string DefaultButton { get; set; }
+        public override ContentDirection Direction { get; set; }
+        public override bool Enabled { get; set; }
+        public override bool EnableTheming { get; set; }
+        public override FontInfo Font { get; }
+        public override Color ForeColor { get; set; }
+        public override string GroupingText { get; set; }
+        public override Unit Height { get; set; }
+        public override HorizontalAlign HorizontalAlign { get; set; }
+        public override ScrollBars ScrollBars { get; set; }
+        public override string SkinID { get; set; }
+        public override short TabIndex { get; set; }
+        public override string Title { get; set; }
+        public override string ToolTip { get; set; }
+        public override bool Visible { get; set; }
+        public string WebPartsListUserControlPath { get; set; }
+        public ITemplate WebPartsTemplate { get; set; }
+        public override Unit Width { get; set; }
+        public override bool Wrap { get; set; }
+        public override WebPartDescriptionCollection GetAvailableWebPartDescriptions();
+        public override WebPart GetWebPart(WebPartDescription description);
+        protected internal override void Render(HtmlTextWriter writer);
+    }
+    public abstract class EditorPart : Part {
+        protected EditorPart();
+        public virtual bool Display { get; }
+        public string DisplayTitle { get; }
+        protected WebPartManager WebPartManager { get; }
+        protected WebPart WebPartToEdit { get; }
+        protected EditorZoneBase Zone { get; }
+        public abstract bool ApplyChanges();
+        protected override IDictionary GetDesignModeState();
+        protected internal override void OnPreRender(EventArgs e);
+        protected override void SetDesignModeState(IDictionary data);
+        public abstract void SyncChanges();
+    }
+    public class EditorPartChrome {
+        public EditorPartChrome(EditorZoneBase zone);
+        protected EditorZoneBase Zone { get; }
+        protected virtual Style CreateEditorPartChromeStyle(EditorPart editorPart, PartChromeType chromeType);
+        public virtual void PerformPreRender();
+        public virtual void RenderEditorPart(HtmlTextWriter writer, EditorPart editorPart);
+        protected virtual void RenderPartContents(HtmlTextWriter writer, EditorPart editorPart);
+    }
+    public sealed class EditorPartCollection : ReadOnlyCollectionBase {
+        public static readonly EditorPartCollection Empty;
+        public EditorPartCollection();
+        public EditorPartCollection(ICollection editorParts);
+        public EditorPartCollection(EditorPartCollection existingEditorParts, ICollection editorParts);
+        public EditorPart this[int index] { get; }
+        public bool Contains(EditorPart editorPart);
+        public void CopyTo(EditorPart[] array, int index);
+        public int IndexOf(EditorPart editorPart);
+    }
+    public class EditorZone : EditorZoneBase {
+        public EditorZone();
+        public virtual ITemplate ZoneTemplate { get; set; }
+        protected override EditorPartCollection CreateEditorParts();
+    }
+    public abstract class EditorZoneBase : ToolZone {
+        protected EditorZoneBase();
+        public virtual WebPartVerb ApplyVerb { get; }
+        public virtual WebPartVerb CancelVerb { get; }
+        protected override bool Display { get; }
+        public EditorPartChrome EditorPartChrome { get; }
+        public EditorPartCollection EditorParts { get; }
+        public override string EmptyZoneText { get; set; }
+        public virtual string ErrorText { get; set; }
+        public override string HeaderText { get; set; }
+        public override string InstructionText { get; set; }
+        public virtual WebPartVerb OKVerb { get; }
+        protected WebPart WebPartToEdit { get; }
+        protected override void Close();
+        protected internal override void CreateChildControls();
+        protected virtual EditorPartChrome CreateEditorPartChrome();
+        protected abstract EditorPartCollection CreateEditorParts();
+        protected void InvalidateEditorParts();
+        protected override void LoadViewState(object savedState);
+        protected override void OnDisplayModeChanged(object sender, WebPartDisplayModeEventArgs e);
+        protected internal override void OnPreRender(EventArgs e);
+        protected override void OnSelectedWebPartChanged(object sender, WebPartEventArgs e);
+        protected override void RaisePostBackEvent(string eventArgument);
+        protected internal override void Render(HtmlTextWriter writer);
+        protected override void RenderBody(HtmlTextWriter writer);
+        protected override void RenderVerbs(HtmlTextWriter writer);
+        protected override object SaveViewState();
+        protected override void TrackViewState();
+    }
+    public class ErrorWebPart : ProxyWebPart, ITrackingPersonalizable {
+        public ErrorWebPart(string originalID, string originalTypeName, string originalPath, string genericWebPartID);
+        public string ErrorMessage { get; set; }
+        bool System.Web.UI.WebControls.WebParts.ITrackingPersonalizable.TracksChanges { get; }
+        protected override void AddAttributesToRender(HtmlTextWriter writer);
+        protected virtual void EndLoadPersonalization();
+        protected internal override void RenderContents(HtmlTextWriter writer);
+        void System.Web.UI.WebControls.WebParts.ITrackingPersonalizable.BeginLoad();
+        void System.Web.UI.WebControls.WebParts.ITrackingPersonalizable.BeginSave();
+        void System.Web.UI.WebControls.WebParts.ITrackingPersonalizable.EndLoad();
+        void System.Web.UI.WebControls.WebParts.ITrackingPersonalizable.EndSave();
+    }
+    public delegate void FieldCallback(object fieldValue);
+    public class GenericWebPart : WebPart {
+        protected internal GenericWebPart(Control control);
+        public override string CatalogIconImageUrl { get; set; }
+        public Control ChildControl { get; }
+        public override string Description { get; set; }
+        public override Unit Height { get; set; }
+        public sealed override string ID { get; set; }
+        public override string Subtitle { get; }
+        public override string Title { get; set; }
+        public override string TitleIconImageUrl { get; set; }
+        public override string TitleUrl { get; set; }
+        public override WebPartVerbCollection Verbs { get; }
+        public override object WebBrowsableObject { get; }
+        public override Unit Width { get; set; }
+        protected internal override void CreateChildControls();
+        protected override ControlCollection CreateControlCollection();
+        public override EditorPartCollection CreateEditorParts();
+        protected internal override void Render(HtmlTextWriter writer);
+    }
+    public sealed class ImportCatalogPart : CatalogPart {
+        public ImportCatalogPart();
+        public string BrowseHelpText { get; set; }
+        public override string DefaultButton { get; set; }
+        public string ImportedPartLabelText { get; set; }
+        public string PartImportErrorLabelText { get; set; }
+        public override string Title { get; set; }
+        public string UploadButtonText { get; set; }
+        public string UploadHelpText { get; set; }
+        protected internal override void CreateChildControls();
+        public override WebPartDescriptionCollection GetAvailableWebPartDescriptions();
+        public override WebPart GetWebPart(WebPartDescription description);
+        protected internal override void LoadControlState(object savedState);
+        protected internal override void OnInit(EventArgs e);
+        protected internal override void Render(HtmlTextWriter writer);
+        protected internal override void RenderContents(HtmlTextWriter writer);
+        protected internal override object SaveControlState();
+    }
+    public interface IPersonalizable {
+        bool IsDirty { get; }
+        void Load(PersonalizationDictionary state);
+        void Save(PersonalizationDictionary state);
+    }
+    public interface ITrackingPersonalizable {
+        bool TracksChanges { get; }
+        void BeginLoad();
+        void BeginSave();
+        void EndLoad();
+        void EndSave();
+    }
+    public interface ITransformerConfigurationControl {
+        event EventHandler Cancelled;
+        event EventHandler Succeeded;
+    }
+    public interface IVersioningPersonalizable {
+        void Load(IDictionary unknownProperties);
+    }
+    public interface IWebActionable {
+        WebPartVerbCollection Verbs { get; }
+    }
+    public interface IWebEditable {
+        object WebBrowsableObject { get; }
+        EditorPartCollection CreateEditorParts();
+    }
+    public interface IWebPart {
+        string CatalogIconImageUrl { get; set; }
+        string Description { get; set; }
+        string Subtitle { get; }
+        string Title { get; set; }
+        string TitleIconImageUrl { get; set; }
+        string TitleUrl { get; set; }
+    }
+    public interface IWebPartField {
+        PropertyDescriptor Schema { get; }
+        void GetFieldValue(FieldCallback callback);
+    }
+    public interface IWebPartParameters {
+        PropertyDescriptorCollection Schema { get; }
+        void GetParametersData(ParametersCallback callback);
+        void SetConsumerSchema(PropertyDescriptorCollection schema);
+    }
+    public interface IWebPartRow {
+        PropertyDescriptorCollection Schema { get; }
+        void GetRowData(RowCallback callback);
+    }
+    public interface IWebPartTable {
+        PropertyDescriptorCollection Schema { get; }
+        void GetTableData(TableCallback callback);
+    }
+    public sealed class LayoutEditorPart : EditorPart {
+        public LayoutEditorPart();
+        public override string DefaultButton { get; set; }
+        public override bool Display { get; }
+        public override string Title { get; set; }
+        public override bool ApplyChanges();
+        protected internal override void CreateChildControls();
+        protected internal override void OnPreRender(EventArgs e);
+        protected internal override void RenderContents(HtmlTextWriter writer);
+        public override void SyncChanges();
+    }
+    public sealed class PageCatalogPart : CatalogPart {
+        public PageCatalogPart();
+        public override string AccessKey { get; set; }
+        public override Color BackColor { get; set; }
+        public override string BackImageUrl { get; set; }
+        public override Color BorderColor { get; set; }
+        public override BorderStyle BorderStyle { get; set; }
+        public override Unit BorderWidth { get; set; }
+        public override string CssClass { get; set; }
+        public override string DefaultButton { get; set; }
+        public override ContentDirection Direction { get; set; }
+        public override bool Enabled { get; set; }
+        public override bool EnableTheming { get; set; }
+        public override FontInfo Font { get; }
+        public override Color ForeColor { get; set; }
+        public override string GroupingText { get; set; }
+        public override Unit Height { get; set; }
+        public override HorizontalAlign HorizontalAlign { get; set; }
+        public override ScrollBars ScrollBars { get; set; }
+        public override string SkinID { get; set; }
+        public override short TabIndex { get; set; }
+        public override string Title { get; set; }
+        public override string ToolTip { get; set; }
+        public override bool Visible { get; set; }
+        public override Unit Width { get; set; }
+        public override bool Wrap { get; set; }
+        public override WebPartDescriptionCollection GetAvailableWebPartDescriptions();
+        public override WebPart GetWebPart(WebPartDescription description);
+        protected internal override void OnInit(EventArgs e);
+        protected internal override void OnPreRender(EventArgs e);
+        protected internal override void Render(HtmlTextWriter writer);
+    }
+    public delegate void ParametersCallback(IDictionary parametersData);
+    public abstract class Part : Panel, ICompositeControlDesignerAccessor, INamingContainer {
+        public virtual PartChromeState ChromeState { get; set; }
+        public virtual PartChromeType ChromeType { get; set; }
+        public override ControlCollection Controls { get; }
+        public virtual string Description { get; set; }
+        public virtual string Title { get; set; }
+        public override void DataBind();
+        void System.Web.UI.WebControls.ICompositeControlDesignerAccessor.RecreateChildControls();
+    }
+    public enum PartChromeState {
+        Minimized = 1,
+        Normal = 0,
+    }
+    public enum PartChromeType {
+        BorderOnly = 4,
+        Default = 0,
+        None = 2,
+        TitleAndBorder = 1,
+        TitleOnly = 3,
+    }
+    public sealed class PersonalizableAttribute : Attribute {
+        public static readonly PersonalizableAttribute Default;
+        public static readonly PersonalizableAttribute NotPersonalizable;
+        public static readonly PersonalizableAttribute Personalizable;
+        public static readonly PersonalizableAttribute SharedPersonalizable;
+        public static readonly PersonalizableAttribute UserPersonalizable;
+        public PersonalizableAttribute();
+        public PersonalizableAttribute(bool isPersonalizable);
+        public PersonalizableAttribute(PersonalizationScope scope);
+        public PersonalizableAttribute(PersonalizationScope scope, bool isSensitive);
+        public bool IsPersonalizable { get; }
+        public bool IsSensitive { get; }
+        public PersonalizationScope Scope { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public static ICollection GetPersonalizableProperties(Type type);
+        public override bool IsDefaultAttribute();
+        public override bool Match(object obj);
+    }
+    public static class PersonalizationAdministration {
+        public static string ApplicationName { get; set; }
+        public static PersonalizationProvider Provider { get; }
+        public static PersonalizationProviderCollection Providers { get; }
+        public static PersonalizationStateInfoCollection FindInactiveUserState(string pathToMatch, string usernameToMatch, DateTime userInactiveSinceDate);
+        public static PersonalizationStateInfoCollection FindInactiveUserState(string pathToMatch, string usernameToMatch, DateTime userInactiveSinceDate, int pageIndex, int pageSize, out int totalRecords);
+        public static PersonalizationStateInfoCollection FindSharedState(string pathToMatch);
+        public static PersonalizationStateInfoCollection FindSharedState(string pathToMatch, int pageIndex, int pageSize, out int totalRecords);
+        public static PersonalizationStateInfoCollection FindUserState(string pathToMatch, string usernameToMatch);
+        public static PersonalizationStateInfoCollection FindUserState(string pathToMatch, string usernameToMatch, int pageIndex, int pageSize, out int totalRecords);
+        public static PersonalizationStateInfoCollection GetAllInactiveUserState(DateTime userInactiveSinceDate);
+        public static PersonalizationStateInfoCollection GetAllInactiveUserState(DateTime userInactiveSinceDate, int pageIndex, int pageSize, out int totalRecords);
+        public static PersonalizationStateInfoCollection GetAllState(PersonalizationScope scope);
+        public static PersonalizationStateInfoCollection GetAllState(PersonalizationScope scope, int pageIndex, int pageSize, out int totalRecords);
+        public static int GetCountOfInactiveUserState(DateTime userInactiveSinceDate);
+        public static int GetCountOfInactiveUserState(string pathToMatch, DateTime userInactiveSinceDate);
+        public static int GetCountOfState(PersonalizationScope scope);
+        public static int GetCountOfState(PersonalizationScope scope, string pathToMatch);
+        public static int GetCountOfUserState(string usernameToMatch);
+        public static int ResetAllState(PersonalizationScope scope);
+        public static int ResetInactiveUserState(DateTime userInactiveSinceDate);
+        public static int ResetInactiveUserState(string path, DateTime userInactiveSinceDate);
+        public static bool ResetSharedState(string path);
+        public static int ResetSharedState(string[] paths);
+        public static int ResetState(PersonalizationStateInfoCollection data);
+        public static int ResetUserState(string path);
+        public static bool ResetUserState(string path, string username);
+        public static int ResetUserState(string path, string[] usernames);
+        public static int ResetUserState(string[] usernames);
+    }
+    public class PersonalizationDictionary : ICollection, IDictionary, IEnumerable {
+        public PersonalizationDictionary();
+        public PersonalizationDictionary(int initialSize);
+        public virtual int Count { get; }
+        public virtual bool IsFixedSize { get; }
+        public virtual bool IsReadOnly { get; }
+        public virtual bool IsSynchronized { get; }
+        public virtual ICollection Keys { get; }
+        public virtual object SyncRoot { get; }
+        object System.Collections.IDictionary.this[object key] { get; set; }
+        public virtual PersonalizationEntry this[string key] { get; set; }
+        public virtual ICollection Values { get; }
+        public virtual void Add(string key, PersonalizationEntry value);
+        public virtual void Clear();
+        public virtual bool Contains(string key);
+        public virtual void CopyTo(DictionaryEntry[] array, int index);
+        public virtual IDictionaryEnumerator GetEnumerator();
+        public virtual void Remove(string key);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        void System.Collections.IDictionary.Add(object key, object value);
+        bool System.Collections.IDictionary.Contains(object key);
+        void System.Collections.IDictionary.Remove(object key);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+    }
+    public sealed class PersonalizationEntry {
+        public PersonalizationEntry(object value, PersonalizationScope scope);
+        public PersonalizationEntry(object value, PersonalizationScope scope, bool isSensitive);
+        public bool IsSensitive { get; set; }
+        public PersonalizationScope Scope { get; set; }
+        public object Value { get; set; }
+    }
+    public abstract class PersonalizationProvider : ProviderBase {
+        protected PersonalizationProvider();
+        public abstract string ApplicationName { get; set; }
+        protected virtual IList CreateSupportedUserCapabilities();
+        public virtual PersonalizationScope DetermineInitialScope(WebPartManager webPartManager, PersonalizationState loadedState);
+        public virtual IDictionary DetermineUserCapabilities(WebPartManager webPartManager);
+        public abstract PersonalizationStateInfoCollection FindState(PersonalizationScope scope, PersonalizationStateQuery query, int pageIndex, int pageSize, out int totalRecords);
+        public abstract int GetCountOfState(PersonalizationScope scope, PersonalizationStateQuery query);
+        protected abstract void LoadPersonalizationBlobs(WebPartManager webPartManager, string path, string userName, ref byte[] sharedDataBlob, ref byte[] userDataBlob);
+        public virtual PersonalizationState LoadPersonalizationState(WebPartManager webPartManager, bool ignoreCurrentUser);
+        protected abstract void ResetPersonalizationBlob(WebPartManager webPartManager, string path, string userName);
+        public virtual void ResetPersonalizationState(WebPartManager webPartManager);
+        public abstract int ResetState(PersonalizationScope scope, string[] paths, string[] usernames);
+        public abstract int ResetUserState(string path, DateTime userInactiveSinceDate);
+        protected abstract void SavePersonalizationBlob(WebPartManager webPartManager, string path, string userName, byte[] dataBlob);
+        public virtual void SavePersonalizationState(PersonalizationState state);
+    }
+    public sealed class PersonalizationProviderCollection : ProviderCollection {
+        public PersonalizationProviderCollection();
+        public new PersonalizationProvider this[string name] { get; }
+        public override void Add(ProviderBase provider);
+        public void CopyTo(PersonalizationProvider[] array, int index);
+    }
+    public enum PersonalizationScope {
+        Shared = 1,
+        User = 0,
+    }
+    public abstract class PersonalizationState {
+        protected PersonalizationState(WebPartManager webPartManager);
+        public bool IsDirty { get; }
+        public abstract bool IsEmpty { get; }
+        public WebPartManager WebPartManager { get; }
+        public abstract void ApplyWebPartManagerPersonalization();
+        public abstract void ApplyWebPartPersonalization(WebPart webPart);
+        public abstract void ExtractWebPartManagerPersonalization();
+        public abstract void ExtractWebPartPersonalization(WebPart webPart);
+        public abstract string GetAuthorizationFilter(string webPartID);
+        protected void SetDirty();
+        public abstract void SetWebPartDirty(WebPart webPart);
+        public abstract void SetWebPartManagerDirty();
+        protected void ValidateWebPart(WebPart webPart);
+    }
+    public abstract class PersonalizationStateInfo {
+        public DateTime LastUpdatedDate { get; }
+        public string Path { get; }
+        public int Size { get; }
+    }
+    public sealed class PersonalizationStateInfoCollection : ICollection, IEnumerable {
+        public PersonalizationStateInfoCollection();
+        public int Count { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        public PersonalizationStateInfo this[int index] { get; }
+        public PersonalizationStateInfo this[string path, string username] { get; }
+        public void Add(PersonalizationStateInfo data);
+        public void Clear();
+        public void CopyTo(PersonalizationStateInfo[] array, int index);
+        public IEnumerator GetEnumerator();
+        public void Remove(string path, string username);
+        public void SetReadOnly();
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+    }
+    public sealed class PersonalizationStateQuery {
+        public PersonalizationStateQuery();
+        public string PathToMatch { get; set; }
+        public object this[string queryKey] { get; set; }
+        public DateTime UserInactiveSinceDate { get; set; }
+        public string UsernameToMatch { get; set; }
+    }
+    public sealed class PropertyGridEditorPart : EditorPart {
+        public PropertyGridEditorPart();
+        public override string DefaultButton { get; set; }
+        public override bool Display { get; }
+        public override string Title { get; set; }
+        public override bool ApplyChanges();
+        protected internal override void CreateChildControls();
+        protected internal override void OnPreRender(EventArgs e);
+        protected internal override void RenderContents(HtmlTextWriter writer);
+        public override void SyncChanges();
+    }
+    public class ProviderConnectionPoint : ConnectionPoint {
+        public ProviderConnectionPoint(MethodInfo callbackMethod, Type interfaceType, Type controlType, string displayName, string id, bool allowsMultipleConnections);
+        public virtual object GetObject(Control control);
+        public virtual ConnectionInterfaceCollection GetSecondaryInterfaces(Control control);
+    }
+    public sealed class ProviderConnectionPointCollection : ReadOnlyCollectionBase {
+        public ProviderConnectionPointCollection();
+        public ProviderConnectionPointCollection(ICollection connectionPoints);
+        public ProviderConnectionPoint Default { get; }
+        public ProviderConnectionPoint this[int index] { get; }
+        public ProviderConnectionPoint this[string id] { get; }
+        public bool Contains(ProviderConnectionPoint connectionPoint);
+        public void CopyTo(ProviderConnectionPoint[] array, int index);
+        public int IndexOf(ProviderConnectionPoint connectionPoint);
+    }
+    public abstract class ProxyWebPart : WebPart {
+        protected ProxyWebPart(string originalID, string originalTypeName, string originalPath, string genericWebPartID);
+        protected ProxyWebPart(WebPart webPart);
+        public string GenericWebPartID { get; }
+        public sealed override string ID { get; set; }
+        public string OriginalID { get; }
+        public string OriginalPath { get; }
+        public string OriginalTypeName { get; }
+        protected internal override void LoadControlState(object savedState);
+        protected override void LoadViewState(object savedState);
+        protected internal override object SaveControlState();
+        protected override object SaveViewState();
+    }
+    public sealed class ProxyWebPartConnectionCollection : CollectionBase {
+        public ProxyWebPartConnectionCollection();
+        public bool IsReadOnly { get; }
+        public WebPartConnection this[int index] { get; set; }
+        public WebPartConnection this[string id] { get; }
+        public int Add(WebPartConnection value);
+        public bool Contains(WebPartConnection value);
+        public void CopyTo(WebPartConnection[] array, int index);
+        public int IndexOf(WebPartConnection value);
+        public void Insert(int index, WebPartConnection value);
+        protected override void OnClear();
+        protected override void OnInsert(int index, object value);
+        protected override void OnRemove(int index, object value);
+        protected override void OnSet(int index, object oldValue, object newValue);
+        protected override void OnValidate(object value);
+        public void Remove(WebPartConnection value);
+    }
+    public class ProxyWebPartManager : Control {
+        public ProxyWebPartManager();
+        public override string ClientID { get; }
+        public override ControlCollection Controls { get; }
+        public override bool EnableTheming { get; set; }
+        public override string SkinID { get; set; }
+        public ProxyWebPartConnectionCollection StaticConnections { get; }
+        public override bool Visible { get; set; }
+        protected override ControlCollection CreateControlCollection();
+        public override void Focus();
+        protected internal override void OnInit(EventArgs e);
+    }
+    public delegate void RowCallback(object rowData);
+    public sealed class RowToFieldTransformer : WebPartTransformer, IWebPartField {
+        public RowToFieldTransformer();
+        public string FieldName { get; set; }
+        PropertyDescriptor System.Web.UI.WebControls.WebParts.IWebPartField.Schema { get; }
+        public override Control CreateConfigurationControl();
+        protected internal override void LoadConfigurationState(object savedState);
+        protected internal override object SaveConfigurationState();
+        void System.Web.UI.WebControls.WebParts.IWebPartField.GetFieldValue(FieldCallback callback);
+        public override object Transform(object providerData);
+    }
+    public sealed class RowToParametersTransformer : WebPartTransformer, IWebPartParameters {
+        public RowToParametersTransformer();
+        public string[] ConsumerFieldNames { get; set; }
+        public string[] ProviderFieldNames { get; set; }
+        PropertyDescriptorCollection System.Web.UI.WebControls.WebParts.IWebPartParameters.Schema { get; }
+        public override Control CreateConfigurationControl();
+        protected internal override void LoadConfigurationState(object savedState);
+        protected internal override object SaveConfigurationState();
+        void System.Web.UI.WebControls.WebParts.IWebPartParameters.GetParametersData(ParametersCallback callback);
+        void System.Web.UI.WebControls.WebParts.IWebPartParameters.SetConsumerSchema(PropertyDescriptorCollection schema);
+        public override object Transform(object providerData);
+    }
+    public sealed class SharedPersonalizationStateInfo : PersonalizationStateInfo {
+        public SharedPersonalizationStateInfo(string path, DateTime lastUpdatedDate, int size, int sizeOfPersonalizations, int countOfPersonalizations);
+        public int CountOfPersonalizations { get; }
+        public int SizeOfPersonalizations { get; }
+    }
+    public class SqlPersonalizationProvider : PersonalizationProvider {
+        public SqlPersonalizationProvider();
+        public override string ApplicationName { get; set; }
+        public override PersonalizationStateInfoCollection FindState(PersonalizationScope scope, PersonalizationStateQuery query, int pageIndex, int pageSize, out int totalRecords);
+        public override int GetCountOfState(PersonalizationScope scope, PersonalizationStateQuery query);
+        public override void Initialize(string name, NameValueCollection configSettings);
+        protected override void LoadPersonalizationBlobs(WebPartManager webPartManager, string path, string userName, ref byte[] sharedDataBlob, ref byte[] userDataBlob);
+        protected override void ResetPersonalizationBlob(WebPartManager webPartManager, string path, string userName);
+        public override int ResetState(PersonalizationScope scope, string[] paths, string[] usernames);
+        public override int ResetUserState(string path, DateTime userInactiveSinceDate);
+        protected override void SavePersonalizationBlob(WebPartManager webPartManager, string path, string userName, byte[] dataBlob);
+    }
+    public delegate void TableCallback(ICollection tableData);
+    public sealed class TitleStyle : TableItemStyle {
+        public TitleStyle();
+        public override bool Wrap { get; set; }
+    }
+    public abstract class ToolZone : WebZone, IPostBackEventHandler {
+        protected ToolZone(ICollection associatedDisplayModes);
+        protected ToolZone(WebPartDisplayMode associatedDisplayMode);
+        public WebPartDisplayModeCollection AssociatedDisplayModes { get; }
+        protected virtual bool Display { get; }
+        public Style EditUIStyle { get; }
+        public virtual WebPartVerb HeaderCloseVerb { get; }
+        public Style HeaderVerbStyle { get; }
+        public virtual string InstructionText { get; set; }
+        public Style InstructionTextStyle { get; }
+        public Style LabelStyle { get; }
+        public override bool Visible { get; set; }
+        protected abstract void Close();
+        protected override void LoadViewState(object savedState);
+        protected virtual void OnDisplayModeChanged(object sender, WebPartDisplayModeEventArgs e);
+        protected internal override void OnInit(EventArgs e);
+        protected virtual void OnSelectedWebPartChanged(object sender, WebPartEventArgs e);
+        protected virtual void RaisePostBackEvent(string eventArgument);
+        protected override void RenderFooter(HtmlTextWriter writer);
+        protected override void RenderHeader(HtmlTextWriter writer);
+        protected virtual void RenderVerb(HtmlTextWriter writer, WebPartVerb verb);
+        protected virtual void RenderVerbs(HtmlTextWriter writer);
+        protected override object SaveViewState();
+        void System.Web.UI.IPostBackEventHandler.RaisePostBackEvent(string eventArgument);
+        protected override void TrackViewState();
+    }
+    public sealed class TransformerTypeCollection : ReadOnlyCollectionBase {
+        public static readonly TransformerTypeCollection Empty;
+        public TransformerTypeCollection();
+        public TransformerTypeCollection(ICollection transformerTypes);
+        public TransformerTypeCollection(TransformerTypeCollection existingTransformerTypes, ICollection transformerTypes);
+        public Type this[int index] { get; }
+        public bool Contains(Type value);
+        public void CopyTo(Type[] array, int index);
+        public int IndexOf(Type value);
+    }
+    public sealed class UnauthorizedWebPart : ProxyWebPart {
+        public UnauthorizedWebPart(string originalID, string originalTypeName, string originalPath, string genericWebPartID);
+        public UnauthorizedWebPart(WebPart webPart);
+    }
+    public sealed class UserPersonalizationStateInfo : PersonalizationStateInfo {
+        public UserPersonalizationStateInfo(string path, DateTime lastUpdatedDate, int size, string username, DateTime lastActivityDate);
+        public DateTime LastActivityDate { get; }
+        public string Username { get; }
+    }
+    public sealed class WebBrowsableAttribute : Attribute {
+        public static readonly WebBrowsableAttribute Default;
+        public static readonly WebBrowsableAttribute No;
+        public static readonly WebBrowsableAttribute Yes;
+        public WebBrowsableAttribute();
+        public WebBrowsableAttribute(bool browsable);
+        public bool Browsable { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public override bool IsDefaultAttribute();
+    }
+    public class WebDescriptionAttribute : Attribute {
+        public static readonly WebDescriptionAttribute Default;
+        public WebDescriptionAttribute();
+        public WebDescriptionAttribute(string description);
+        public virtual string Description { get; }
+        protected string DescriptionValue { get; set; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public override bool IsDefaultAttribute();
+    }
+    public class WebDisplayNameAttribute : Attribute {
+        public static readonly WebDisplayNameAttribute Default;
+        public WebDisplayNameAttribute();
+        public WebDisplayNameAttribute(string displayName);
+        public virtual string DisplayName { get; }
+        protected string DisplayNameValue { get; set; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public override bool IsDefaultAttribute();
+    }
+    public abstract class WebPart : Part, IWebActionable, IWebEditable, IWebPart {
+        protected WebPart();
+        public virtual bool AllowClose { get; set; }
+        public virtual bool AllowConnect { get; set; }
+        public virtual bool AllowEdit { get; set; }
+        public virtual bool AllowHide { get; set; }
+        public virtual bool AllowMinimize { get; set; }
+        public virtual bool AllowZoneChange { get; set; }
+        public virtual string AuthorizationFilter { get; set; }
+        public virtual string CatalogIconImageUrl { get; set; }
+        public override PartChromeState ChromeState { get; set; }
+        public override PartChromeType ChromeType { get; set; }
+        public string ConnectErrorMessage { get; }
+        public override string Description { get; set; }
+        public override ContentDirection Direction { get; set; }
+        public string DisplayTitle { get; }
+        public virtual WebPartExportMode ExportMode { get; set; }
+        public bool HasSharedData { get; }
+        public bool HasUserData { get; }
+        public override Unit Height { get; set; }
+        public virtual WebPartHelpMode HelpMode { get; set; }
+        public virtual string HelpUrl { get; set; }
+        public virtual bool Hidden { get; set; }
+        public virtual string ImportErrorMessage { get; set; }
+        public bool IsClosed { get; }
+        public bool IsShared { get; }
+        public bool IsStandalone { get; }
+        public bool IsStatic { get; }
+        public virtual string Subtitle { get; }
+        public override string Title { get; set; }
+        public virtual string TitleIconImageUrl { get; set; }
+        public virtual string TitleUrl { get; set; }
+        public virtual WebPartVerbCollection Verbs { get; }
+        public virtual object WebBrowsableObject { get; }
+        protected WebPartManager WebPartManager { get; }
+        public override Unit Width { get; set; }
+        public WebPartZoneBase Zone { get; }
+        public int ZoneIndex { get; }
+        public virtual EditorPartCollection CreateEditorParts();
+        protected internal virtual void OnClosing(EventArgs e);
+        protected internal virtual void OnConnectModeChanged(EventArgs e);
+        protected internal virtual void OnDeleting(EventArgs e);
+        protected internal virtual void OnEditModeChanged(EventArgs e);
+        protected void SetPersonalizationDirty();
+        public static void SetPersonalizationDirty(Control control);
+        protected override void TrackViewState();
+    }
+    public class WebPartAddingEventArgs : WebPartCancelEventArgs {
+        public WebPartAddingEventArgs(WebPart webPart, WebPartZoneBase zone, int zoneIndex);
+        public WebPartZoneBase Zone { get; set; }
+        public int ZoneIndex { get; set; }
+    }
+    public delegate void WebPartAddingEventHandler(object sender, WebPartAddingEventArgs e);
+    public class WebPartAuthorizationEventArgs : EventArgs {
+        public WebPartAuthorizationEventArgs(Type type, string path, string authorizationFilter, bool isShared);
+        public string AuthorizationFilter { get; }
+        public bool IsAuthorized { get; set; }
+        public bool IsShared { get; }
+        public string Path { get; }
+        public Type Type { get; }
+    }
+    public delegate void WebPartAuthorizationEventHandler(object sender, WebPartAuthorizationEventArgs e);
+    public class WebPartCancelEventArgs : CancelEventArgs {
+        public WebPartCancelEventArgs(WebPart webPart);
+        public WebPart WebPart { get; set; }
+    }
+    public delegate void WebPartCancelEventHandler(object sender, WebPartCancelEventArgs e);
+    public class WebPartChrome {
+        public WebPartChrome(WebPartZoneBase zone, WebPartManager manager);
+        protected bool DragDropEnabled { get; }
+        protected WebPartManager WebPartManager { get; }
+        protected WebPartZoneBase Zone { get; }
+        protected virtual Style CreateWebPartChromeStyle(WebPart webPart, PartChromeType chromeType);
+        protected virtual WebPartVerbCollection FilterWebPartVerbs(WebPartVerbCollection verbs, WebPart webPart);
+        protected string GetWebPartChromeClientID(WebPart webPart);
+        protected string GetWebPartTitleClientID(WebPart webPart);
+        protected virtual WebPartVerbCollection GetWebPartVerbs(WebPart webPart);
+        public virtual void PerformPreRender();
+        protected virtual void RenderPartContents(HtmlTextWriter writer, WebPart webPart);
+        public virtual void RenderWebPart(HtmlTextWriter writer, WebPart webPart);
+    }
+    public sealed class WebPartCollection : ReadOnlyCollectionBase {
+        public WebPartCollection();
+        public WebPartCollection(ICollection webParts);
+        public WebPart this[int index] { get; }
+        public WebPart this[string id] { get; }
+        public bool Contains(WebPart value);
+        public void CopyTo(WebPart[] array, int index);
+        public int IndexOf(WebPart value);
+    }
+    public sealed class WebPartConnection {
+        public WebPartConnection();
+        public WebPart Consumer { get; }
+        public ConsumerConnectionPoint ConsumerConnectionPoint { get; }
+        public string ConsumerConnectionPointID { get; set; }
+        public string ConsumerID { get; set; }
+        public string ID { get; set; }
+        public bool IsActive { get; }
+        public bool IsShared { get; }
+        public bool IsStatic { get; }
+        public WebPart Provider { get; }
+        public ProviderConnectionPoint ProviderConnectionPoint { get; }
+        public string ProviderConnectionPointID { get; set; }
+        public string ProviderID { get; set; }
+        public WebPartTransformer Transformer { get; }
+        public WebPartTransformerCollection Transformers { get; }
+        public override string ToString();
+    }
+    public sealed class WebPartConnectionCollection : CollectionBase {
+        public bool IsReadOnly { get; }
+        public WebPartConnection this[int index] { get; set; }
+        public WebPartConnection this[string id] { get; }
+        public int Add(WebPartConnection value);
+        public bool Contains(WebPartConnection value);
+        public void CopyTo(WebPartConnection[] array, int index);
+        public int IndexOf(WebPartConnection value);
+        public void Insert(int index, WebPartConnection value);
+        protected override void OnClear();
+        protected override void OnInsert(int index, object value);
+        protected override void OnRemove(int index, object value);
+        protected override void OnSet(int index, object oldValue, object newValue);
+        protected override void OnValidate(object value);
+        public void Remove(WebPartConnection value);
+    }
+    public class WebPartConnectionsCancelEventArgs : CancelEventArgs {
+        public WebPartConnectionsCancelEventArgs(WebPart provider, ProviderConnectionPoint providerConnectionPoint, WebPart consumer, ConsumerConnectionPoint consumerConnectionPoint);
+        public WebPartConnectionsCancelEventArgs(WebPart provider, ProviderConnectionPoint providerConnectionPoint, WebPart consumer, ConsumerConnectionPoint consumerConnectionPoint, WebPartConnection connection);
+        public WebPartConnection Connection { get; }
+        public WebPart Consumer { get; }
+        public ConsumerConnectionPoint ConsumerConnectionPoint { get; }
+        public WebPart Provider { get; }
+        public ProviderConnectionPoint ProviderConnectionPoint { get; }
+    }
+    public delegate void WebPartConnectionsCancelEventHandler(object sender, WebPartConnectionsCancelEventArgs e);
+    public class WebPartConnectionsEventArgs : EventArgs {
+        public WebPartConnectionsEventArgs(WebPart provider, ProviderConnectionPoint providerConnectionPoint, WebPart consumer, ConsumerConnectionPoint consumerConnectionPoint);
+        public WebPartConnectionsEventArgs(WebPart provider, ProviderConnectionPoint providerConnectionPoint, WebPart consumer, ConsumerConnectionPoint consumerConnectionPoint, WebPartConnection connection);
+        public WebPartConnection Connection { get; }
+        public WebPart Consumer { get; }
+        public ConsumerConnectionPoint ConsumerConnectionPoint { get; }
+        public WebPart Provider { get; }
+        public ProviderConnectionPoint ProviderConnectionPoint { get; }
+    }
+    public delegate void WebPartConnectionsEventHandler(object sender, WebPartConnectionsEventArgs e);
+    public class WebPartDescription {
+        public WebPartDescription(string id, string title, string description, string imageUrl);
+        public WebPartDescription(WebPart part);
+        public string CatalogIconImageUrl { get; }
+        public string Description { get; }
+        public string ID { get; }
+        public string Title { get; }
+    }
+    public sealed class WebPartDescriptionCollection : ReadOnlyCollectionBase {
+        public WebPartDescriptionCollection();
+        public WebPartDescriptionCollection(ICollection webPartDescriptions);
+        public WebPartDescription this[int index] { get; }
+        public WebPartDescription this[string id] { get; }
+        public bool Contains(WebPartDescription value);
+        public void CopyTo(WebPartDescription[] array, int index);
+        public int IndexOf(WebPartDescription value);
+    }
+    public abstract class WebPartDisplayMode {
+        protected WebPartDisplayMode(string name);
+        public virtual bool AllowPageDesign { get; }
+        public virtual bool AssociatedWithToolZone { get; }
+        public string Name { get; }
+        public virtual bool RequiresPersonalization { get; }
+        public virtual bool ShowHiddenWebParts { get; }
+        public virtual bool IsEnabled(WebPartManager webPartManager);
+    }
+    public class WebPartDisplayModeCancelEventArgs : CancelEventArgs {
+        public WebPartDisplayModeCancelEventArgs(WebPartDisplayMode newDisplayMode);
+        public WebPartDisplayMode NewDisplayMode { get; set; }
+    }
+    public delegate void WebPartDisplayModeCancelEventHandler(object sender, WebPartDisplayModeCancelEventArgs e);
+    public sealed class WebPartDisplayModeCollection : CollectionBase {
+        public bool IsReadOnly { get; }
+        public WebPartDisplayMode this[int index] { get; }
+        public WebPartDisplayMode this[string modeName] { get; }
+        public int Add(WebPartDisplayMode value);
+        public bool Contains(WebPartDisplayMode value);
+        public void CopyTo(WebPartDisplayMode[] array, int index);
+        public int IndexOf(WebPartDisplayMode value);
+        public void Insert(int index, WebPartDisplayMode value);
+        protected override void OnClear();
+        protected override void OnInsert(int index, object value);
+        protected override void OnRemove(int index, object value);
+        protected override void OnSet(int index, object oldValue, object newValue);
+        protected override void OnValidate(object value);
+    }
+    public class WebPartDisplayModeEventArgs : EventArgs {
+        public WebPartDisplayModeEventArgs(WebPartDisplayMode oldDisplayMode);
+        public WebPartDisplayMode OldDisplayMode { get; set; }
+    }
+    public delegate void WebPartDisplayModeEventHandler(object sender, WebPartDisplayModeEventArgs e);
+    public class WebPartEventArgs : EventArgs {
+        public WebPartEventArgs(WebPart webPart);
+        public WebPart WebPart { get; }
+    }
+    public delegate void WebPartEventHandler(object sender, WebPartEventArgs e);
+    public enum WebPartExportMode {
+        All = 1,
+        None = 0,
+        NonSensitiveData = 2,
+    }
+    public enum WebPartHelpMode {
+        Modal = 0,
+        Modeless = 1,
+        Navigate = 2,
+    }
+    public class WebPartManager : Control, INamingContainer, IPersonalizable {
+        public static readonly WebPartDisplayMode BrowseDisplayMode;
+        public static readonly WebPartDisplayMode CatalogDisplayMode;
+        public static readonly WebPartDisplayMode ConnectDisplayMode;
+        public static readonly WebPartDisplayMode DesignDisplayMode;
+        public static readonly WebPartDisplayMode EditDisplayMode;
+        public WebPartManager();
+        public TransformerTypeCollection AvailableTransformers { get; }
+        public virtual string CloseProviderWarning { get; set; }
+        public WebPartConnectionCollection Connections { get; }
+        public override ControlCollection Controls { get; }
+        public virtual string DeleteWarning { get; set; }
+        public virtual WebPartDisplayMode DisplayMode { get; set; }
+        public WebPartDisplayModeCollection DisplayModes { get; }
+        protected internal WebPartConnectionCollection DynamicConnections { get; }
+        public virtual bool EnableClientScript { get; set; }
+        public override bool EnableTheming { get; set; }
+        public virtual string ExportSensitiveDataWarning { get; set; }
+        protected WebPartManagerInternals Internals { get; }
+        protected virtual bool IsCustomPersonalizationStateDirty { get; }
+        protected virtual PermissionSet MediumPermissionSet { get; }
+        protected virtual PermissionSet MinimalPermissionSet { get; }
+        public WebPartPersonalization Personalization { get; }
+        public WebPart SelectedWebPart { get; }
+        public override string SkinID { get; set; }
+        public WebPartConnectionCollection StaticConnections { get; }
+        public WebPartDisplayModeCollection SupportedDisplayModes { get; }
+        bool System.Web.UI.WebControls.WebParts.IPersonalizable.IsDirty { get; }
+        public override bool Visible { get; set; }
+        public WebPartCollection WebParts { get; }
+        public WebPartZoneCollection Zones { get; }
+        public event WebPartAuthorizationEventHandler AuthorizeWebPart;
+        public event EventHandler ConnectionsActivated;
+        public event EventHandler ConnectionsActivating;
+        public event WebPartDisplayModeEventHandler DisplayModeChanged;
+        public event WebPartDisplayModeCancelEventHandler DisplayModeChanging;
+        public event WebPartEventHandler SelectedWebPartChanged;
+        public event WebPartCancelEventHandler SelectedWebPartChanging;
+        public event WebPartEventHandler WebPartAdded;
+        public event WebPartAddingEventHandler WebPartAdding;
+        public event WebPartEventHandler WebPartClosed;
+        public event WebPartCancelEventHandler WebPartClosing;
+        public event WebPartEventHandler WebPartDeleted;
+        public event WebPartCancelEventHandler WebPartDeleting;
+        public event WebPartEventHandler WebPartMoved;
+        public event WebPartMovingEventHandler WebPartMoving;
+        public event WebPartConnectionsEventHandler WebPartsConnected;
+        public event WebPartConnectionsCancelEventHandler WebPartsConnecting;
+        public event WebPartConnectionsEventHandler WebPartsDisconnected;
+        public event WebPartConnectionsCancelEventHandler WebPartsDisconnecting;
+        protected virtual void ActivateConnections();
+        public WebPart AddWebPart(WebPart webPart, WebPartZoneBase zone, int zoneIndex);
+        public virtual void BeginWebPartConnecting(WebPart webPart);
+        public virtual void BeginWebPartEditing(WebPart webPart);
+        public bool CanConnectWebParts(WebPart provider, ProviderConnectionPoint providerConnectionPoint, WebPart consumer, ConsumerConnectionPoint consumerConnectionPoint);
+        public virtual bool CanConnectWebParts(WebPart provider, ProviderConnectionPoint providerConnectionPoint, WebPart consumer, ConsumerConnectionPoint consumerConnectionPoint, WebPartTransformer transformer);
+        protected virtual bool CheckRenderClientScript();
+        public void CloseWebPart(WebPart webPart);
+        public WebPartConnection ConnectWebParts(WebPart provider, ProviderConnectionPoint providerConnectionPoint, WebPart consumer, ConsumerConnectionPoint consumerConnectionPoint);
+        public virtual WebPartConnection ConnectWebParts(WebPart provider, ProviderConnectionPoint providerConnectionPoint, WebPart consumer, ConsumerConnectionPoint consumerConnectionPoint, WebPartTransformer transformer);
+        protected virtual WebPart CopyWebPart(WebPart webPart);
+        protected virtual TransformerTypeCollection CreateAvailableTransformers();
+        protected sealed override ControlCollection CreateControlCollection();
+        protected virtual WebPartDisplayModeCollection CreateDisplayModes();
+        protected virtual string CreateDynamicConnectionID();
+        protected virtual string CreateDynamicWebPartID(Type webPartType);
+        protected virtual ErrorWebPart CreateErrorWebPart(string originalID, string originalTypeName, string originalPath, string genericWebPartID, string errorMessage);
+        protected virtual WebPartPersonalization CreatePersonalization();
+        public virtual GenericWebPart CreateWebPart(Control control);
+        public void DeleteWebPart(WebPart webPart);
+        protected virtual void DisconnectWebPart(WebPart webPart);
+        public virtual void DisconnectWebParts(WebPartConnection connection);
+        public virtual void EndWebPartConnecting();
+        public virtual void EndWebPartEditing();
+        public virtual void ExportWebPart(WebPart webPart, XmlWriter writer);
+        public override void Focus();
+        public virtual ConsumerConnectionPointCollection GetConsumerConnectionPoints(WebPart webPart);
+        public static WebPartManager GetCurrentWebPartManager(Page page);
+        protected internal virtual string GetDisplayTitle(WebPart webPart);
+        public string GetExportUrl(WebPart webPart);
+        public GenericWebPart GetGenericWebPart(Control control);
+        public virtual ProviderConnectionPointCollection GetProviderConnectionPoints(WebPart webPart);
+        public virtual WebPart ImportWebPart(XmlReader reader, out string errorMessage);
+        public virtual bool IsAuthorized(Type type, string path, string authorizationFilter, bool isShared);
+        public bool IsAuthorized(WebPart webPart);
+        protected internal override void LoadControlState(object savedState);
+        protected virtual void LoadCustomPersonalizationState(PersonalizationDictionary state);
+        public virtual void MoveWebPart(WebPart webPart, WebPartZoneBase zone, int zoneIndex);
+        protected virtual void OnAuthorizeWebPart(WebPartAuthorizationEventArgs e);
+        protected virtual void OnConnectionsActivated(EventArgs e);
+        protected virtual void OnConnectionsActivating(EventArgs e);
+        protected virtual void OnDisplayModeChanged(WebPartDisplayModeEventArgs e);
+        protected virtual void OnDisplayModeChanging(WebPartDisplayModeCancelEventArgs e);
+        protected internal override void OnInit(EventArgs e);
+        protected internal override void OnPreRender(EventArgs e);
+        protected virtual void OnSelectedWebPartChanged(WebPartEventArgs e);
+        protected virtual void OnSelectedWebPartChanging(WebPartCancelEventArgs e);
+        protected internal override void OnUnload(EventArgs e);
+        protected virtual void OnWebPartAdded(WebPartEventArgs e);
+        protected virtual void OnWebPartAdding(WebPartAddingEventArgs e);
+        protected virtual void OnWebPartClosed(WebPartEventArgs e);
+        protected virtual void OnWebPartClosing(WebPartCancelEventArgs e);
+        protected virtual void OnWebPartDeleted(WebPartEventArgs e);
+        protected virtual void OnWebPartDeleting(WebPartCancelEventArgs e);
+        protected virtual void OnWebPartMoved(WebPartEventArgs e);
+        protected virtual void OnWebPartMoving(WebPartMovingEventArgs e);
+        protected virtual void OnWebPartsConnected(WebPartConnectionsEventArgs e);
+        protected virtual void OnWebPartsConnecting(WebPartConnectionsCancelEventArgs e);
+        protected virtual void OnWebPartsDisconnected(WebPartConnectionsEventArgs e);
+        protected virtual void OnWebPartsDisconnecting(WebPartConnectionsCancelEventArgs e);
+        protected virtual void RegisterClientScript();
+        protected internal override void Render(HtmlTextWriter writer);
+        protected internal override object SaveControlState();
+        protected virtual void SaveCustomPersonalizationState(PersonalizationDictionary state);
+        protected void SetPersonalizationDirty();
+        protected void SetSelectedWebPart(WebPart webPart);
+        void System.Web.UI.WebControls.WebParts.IPersonalizable.Load(PersonalizationDictionary state);
+        void System.Web.UI.WebControls.WebParts.IPersonalizable.Save(PersonalizationDictionary state);
+        protected override void TrackViewState();
+    }
+    public sealed class WebPartManagerInternals {
+        public void AddWebPart(WebPart webPart);
+        public void CallOnClosing(WebPart webPart);
+        public void CallOnConnectModeChanged(WebPart webPart);
+        public void CallOnDeleting(WebPart webPart);
+        public void CallOnEditModeChanged(WebPart webPart);
+        public bool ConnectionDeleted(WebPartConnection connection);
+        public object CreateObjectFromType(Type type);
+        public void DeleteConnection(WebPartConnection connection);
+        public string GetZoneID(WebPart webPart);
+        public void LoadConfigurationState(WebPartTransformer transformer, object savedState);
+        public void RemoveWebPart(WebPart webPart);
+        public object SaveConfigurationState(WebPartTransformer transformer);
+        public void SetConnectErrorMessage(WebPart webPart, string connectErrorMessage);
+        public void SetHasSharedData(WebPart webPart, bool hasSharedData);
+        public void SetHasUserData(WebPart webPart, bool hasUserData);
+        public void SetIsClosed(WebPart webPart, bool isClosed);
+        public void SetIsShared(WebPart webPart, bool isShared);
+        public void SetIsShared(WebPartConnection connection, bool isShared);
+        public void SetIsStandalone(WebPart webPart, bool isStandalone);
+        public void SetIsStatic(WebPart webPart, bool isStatic);
+        public void SetIsStatic(WebPartConnection connection, bool isStatic);
+        public void SetTransformer(WebPartConnection connection, WebPartTransformer transformer);
+        public void SetZoneID(WebPart webPart, string zoneID);
+        public void SetZoneIndex(WebPart webPart, int zoneIndex);
+    }
+    public sealed class WebPartMenuStyle : TableStyle, ICustomTypeDescriptor {
+        public WebPartMenuStyle();
+        public WebPartMenuStyle(StateBag bag);
+        public override HorizontalAlign HorizontalAlign { get; set; }
+        public Color ShadowColor { get; set; }
+        public override void CopyFrom(Style s);
+        protected override void FillStyleAttributes(CssStyleCollection attributes, IUrlResolutionService urlResolver);
+        public override void MergeWith(Style s);
+        public override void Reset();
+        AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes();
+        string System.ComponentModel.ICustomTypeDescriptor.GetClassName();
+        string System.ComponentModel.ICustomTypeDescriptor.GetComponentName();
+        TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter();
+        EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent();
+        PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty();
+        object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType);
+        EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents();
+        EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes);
+        PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties();
+        PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes);
+        object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd);
+    }
+    public class WebPartMovingEventArgs : WebPartCancelEventArgs {
+        public WebPartMovingEventArgs(WebPart webPart, WebPartZoneBase zone, int zoneIndex);
+        public WebPartZoneBase Zone { get; set; }
+        public int ZoneIndex { get; set; }
+    }
+    public delegate void WebPartMovingEventHandler(object sender, WebPartMovingEventArgs e);
+    public class WebPartPersonalization {
+        public static readonly WebPartUserCapability EnterSharedScopeUserCapability;
+        public static readonly WebPartUserCapability ModifyStateUserCapability;
+        public WebPartPersonalization(WebPartManager owner);
+        public bool CanEnterSharedScope { get; }
+        public virtual bool Enabled { get; set; }
+        public virtual bool HasPersonalizationState { get; }
+        public virtual PersonalizationScope InitialScope { get; set; }
+        public bool IsEnabled { get; }
+        protected bool IsInitialized { get; }
+        public bool IsModifiable { get; }
+        public virtual string ProviderName { get; set; }
+        public PersonalizationScope Scope { get; }
+        protected bool ShouldResetPersonalizationState { get; set; }
+        protected virtual IDictionary UserCapabilities { get; }
+        protected WebPartManager WebPartManager { get; }
+        protected internal virtual void ApplyPersonalizationState();
+        protected internal virtual void ApplyPersonalizationState(WebPart webPart);
+        protected virtual void ChangeScope(PersonalizationScope scope);
+        protected internal virtual void CopyPersonalizationState(WebPart webPartA, WebPart webPartB);
+        public void EnsureEnabled(bool ensureModifiable);
+        protected internal virtual void ExtractPersonalizationState();
+        protected internal virtual void ExtractPersonalizationState(WebPart webPart);
+        protected internal virtual string GetAuthorizationFilter(string webPartID);
+        protected virtual PersonalizationScope Load();
+        public virtual void ResetPersonalizationState();
+        protected virtual void Save();
+        protected internal virtual void SetDirty();
+        protected internal virtual void SetDirty(WebPart webPart);
+        public virtual void ToggleScope();
+    }
+    public sealed class WebPartTracker : IDisposable {
+        public WebPartTracker(WebPart webPart, ProviderConnectionPoint providerConnectionPoint);
+        public bool IsCircularConnection { get; }
+        void System.IDisposable.Dispose();
+    }
+    public abstract class WebPartTransformer {
+        protected WebPartTransformer();
+        public virtual Control CreateConfigurationControl();
+        protected internal virtual void LoadConfigurationState(object savedState);
+        protected internal virtual object SaveConfigurationState();
+        public abstract object Transform(object providerData);
+    }
+    public sealed class WebPartTransformerAttribute : Attribute {
+        public WebPartTransformerAttribute(Type consumerType, Type providerType);
+        public Type ConsumerType { get; }
+        public Type ProviderType { get; }
+        public static Type GetConsumerType(Type transformerType);
+        public static Type GetProviderType(Type transformerType);
+    }
+    public sealed class WebPartTransformerCollection : CollectionBase {
+        public WebPartTransformerCollection();
+        public bool IsReadOnly { get; }
+        public WebPartTransformer this[int index] { get; set; }
+        public int Add(WebPartTransformer transformer);
+        public bool Contains(WebPartTransformer transformer);
+        public void CopyTo(WebPartTransformer[] array, int index);
+        public int IndexOf(WebPartTransformer transformer);
+        public void Insert(int index, WebPartTransformer transformer);
+        protected override void OnClear();
+        protected override void OnInsert(int index, object value);
+        protected override void OnRemove(int index, object value);
+        protected override void OnSet(int index, object oldValue, object newValue);
+        protected override void OnValidate(object value);
+        public void Remove(WebPartTransformer transformer);
+    }
+    public sealed class WebPartUserCapability {
+        public WebPartUserCapability(string name);
+        public string Name { get; }
+        public override bool Equals(object o);
+        public override int GetHashCode();
+    }
+    public class WebPartVerb : IStateManager {
+        public WebPartVerb(string id, string clientClickHandler);
+        public WebPartVerb(string id, WebPartEventHandler serverClickHandler);
+        public WebPartVerb(string id, WebPartEventHandler serverClickHandler, string clientClickHandler);
+        public virtual bool Checked { get; set; }
+        public string ClientClickHandler { get; }
+        public virtual string Description { get; set; }
+        public virtual bool Enabled { get; set; }
+        public string ID { get; }
+        public virtual string ImageUrl { get; set; }
+        protected virtual bool IsTrackingViewState { get; }
+        public WebPartEventHandler ServerClickHandler { get; }
+        bool System.Web.UI.IStateManager.IsTrackingViewState { get; }
+        public virtual string Text { get; set; }
+        protected StateBag ViewState { get; }
+        public virtual bool Visible { get; set; }
+        protected virtual void LoadViewState(object savedState);
+        protected virtual object SaveViewState();
+        void System.Web.UI.IStateManager.LoadViewState(object savedState);
+        object System.Web.UI.IStateManager.SaveViewState();
+        void System.Web.UI.IStateManager.TrackViewState();
+        protected virtual void TrackViewState();
+    }
+    public sealed class WebPartVerbCollection : ReadOnlyCollectionBase {
+        public static readonly WebPartVerbCollection Empty;
+        public WebPartVerbCollection();
+        public WebPartVerbCollection(ICollection verbs);
+        public WebPartVerbCollection(WebPartVerbCollection existingVerbs, ICollection verbs);
+        public WebPartVerb this[int index] { get; }
+        public bool Contains(WebPartVerb value);
+        public void CopyTo(WebPartVerb[] array, int index);
+        public int IndexOf(WebPartVerb value);
+    }
+    public enum WebPartVerbRenderMode {
+        Menu = 0,
+        TitleBar = 1,
+    }
+    public class WebPartVerbsEventArgs : EventArgs {
+        public WebPartVerbsEventArgs();
+        public WebPartVerbsEventArgs(WebPartVerbCollection verbs);
+        public WebPartVerbCollection Verbs { get; set; }
+    }
+    public delegate void WebPartVerbsEventHandler(object sender, WebPartVerbsEventArgs e);
+    public class WebPartZone : WebPartZoneBase {
+        public WebPartZone();
+        public virtual ITemplate ZoneTemplate { get; set; }
+        protected internal override WebPartCollection GetInitialWebParts();
+        protected internal override void OnInit(EventArgs e);
+    }
+    public abstract class WebPartZoneBase : WebZone, IPostBackEventHandler, IWebPartMenuUser {
+        protected WebPartZoneBase();
+        public virtual bool AllowLayoutChange { get; set; }
+        public override Color BorderColor { get; set; }
+        public override BorderStyle BorderStyle { get; set; }
+        public override Unit BorderWidth { get; set; }
+        public virtual WebPartVerb CloseVerb { get; }
+        public virtual WebPartVerb ConnectVerb { get; }
+        public virtual WebPartVerb DeleteVerb { get; }
+        public virtual string DisplayTitle { get; }
+        protected internal bool DragDropEnabled { get; }
+        public virtual Color DragHighlightColor { get; set; }
+        public virtual WebPartVerb EditVerb { get; }
+        public override string EmptyZoneText { get; set; }
+        public virtual WebPartVerb ExportVerb { get; }
+        protected override bool HasFooter { get; }
+        protected override bool HasHeader { get; }
+        public virtual WebPartVerb HelpVerb { get; }
+        public virtual Orientation LayoutOrientation { get; set; }
+        public Style MenuCheckImageStyle { get; }
+        public virtual string MenuCheckImageUrl { get; set; }
+        public Style MenuLabelHoverStyle { get; }
+        public Style MenuLabelStyle { get; }
+        public virtual string MenuLabelText { get; set; }
+        public virtual string MenuPopupImageUrl { get; set; }
+        public WebPartMenuStyle MenuPopupStyle { get; }
+        public Style MenuVerbHoverStyle { get; }
+        public Style MenuVerbStyle { get; }
+        public virtual WebPartVerb MinimizeVerb { get; }
+        public virtual WebPartVerb RestoreVerb { get; }
+        public Style SelectedPartChromeStyle { get; }
+        public virtual bool ShowTitleIcons { get; set; }
+        public virtual ButtonType TitleBarVerbButtonType { get; set; }
+        public Style TitleBarVerbStyle { get; }
+        public override ButtonType VerbButtonType { get; set; }
+        public WebPartChrome WebPartChrome { get; }
+        public WebPartCollection WebParts { get; }
+        public virtual WebPartVerbRenderMode WebPartVerbRenderMode { get; set; }
+        public event WebPartVerbsEventHandler CreateVerbs;
+        protected virtual void CloseWebPart(WebPart webPart);
+        protected virtual void ConnectWebPart(WebPart webPart);
+        protected internal override void CreateChildControls();
+        protected override ControlCollection CreateControlCollection();
+        protected override Style CreateControlStyle();
+        protected virtual WebPartChrome CreateWebPartChrome();
+        protected virtual void DeleteWebPart(WebPart webPart);
+        protected virtual void EditWebPart(WebPart webPart);
+        public override PartChromeType GetEffectiveChromeType(Part part);
+        protected internal abstract WebPartCollection GetInitialWebParts();
+        protected override void LoadViewState(object savedState);
+        protected virtual void MinimizeWebPart(WebPart webPart);
+        protected virtual void OnCreateVerbs(WebPartVerbsEventArgs e);
+        protected internal override void OnPreRender(EventArgs e);
+        protected virtual void RaisePostBackEvent(string eventArgument);
+        protected internal override void Render(HtmlTextWriter writer);
+        protected override void RenderBody(HtmlTextWriter writer);
+        protected virtual void RenderDropCue(HtmlTextWriter writer);
+        protected override void RenderHeader(HtmlTextWriter writer);
+        protected virtual void RestoreWebPart(WebPart webPart);
+        protected override object SaveViewState();
+        void System.Web.UI.IPostBackEventHandler.RaisePostBackEvent(string eventArgument);
+        protected override void TrackViewState();
+    }
+    public sealed class WebPartZoneCollection : ReadOnlyCollectionBase {
+        public WebPartZoneCollection();
+        public WebPartZoneCollection(ICollection webPartZones);
+        public WebPartZoneBase this[int index] { get; }
+        public WebPartZoneBase this[string id] { get; }
+        public bool Contains(WebPartZoneBase value);
+        public void CopyTo(WebPartZoneBase[] array, int index);
+        public int IndexOf(WebPartZoneBase value);
+    }
+    public abstract class WebZone : CompositeControl {
+        public virtual string BackImageUrl { get; set; }
+        public virtual string EmptyZoneText { get; set; }
+        public Style EmptyZoneTextStyle { get; }
+        public Style ErrorStyle { get; }
+        public TitleStyle FooterStyle { get; }
+        protected virtual bool HasFooter { get; }
+        protected virtual bool HasHeader { get; }
+        public TitleStyle HeaderStyle { get; }
+        public virtual string HeaderText { get; set; }
+        public virtual int Padding { get; set; }
+        public Unit PartChromePadding { get; set; }
+        public Style PartChromeStyle { get; }
+        public virtual PartChromeType PartChromeType { get; set; }
+        public TableStyle PartStyle { get; }
+        public TitleStyle PartTitleStyle { get; }
+        protected internal bool RenderClientScript { get; }
+        protected override HtmlTextWriterTag TagKey { get; }
+        public virtual ButtonType VerbButtonType { get; set; }
+        public Style VerbStyle { get; }
+        protected WebPartManager WebPartManager { get; }
+        public virtual PartChromeType GetEffectiveChromeType(Part part);
+        protected override void LoadViewState(object savedState);
+        protected internal override void OnInit(EventArgs e);
+        protected internal override void OnPreRender(EventArgs e);
+        public override void RenderBeginTag(HtmlTextWriter writer);
+        protected virtual void RenderBody(HtmlTextWriter writer);
+        protected internal override void RenderContents(HtmlTextWriter writer);
+        protected virtual void RenderFooter(HtmlTextWriter writer);
+        protected virtual void RenderHeader(HtmlTextWriter writer);
+        protected override object SaveViewState();
+        protected override void TrackViewState();
+    }
+}
```

