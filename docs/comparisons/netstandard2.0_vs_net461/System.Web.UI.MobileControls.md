# System.Web.UI.MobileControls

``` diff
+namespace System.Web.UI.MobileControls {
+    public class AdRotator : MobileControl {
+        public AdRotator();
+        public string AdvertisementFile { get; set; }
+        public string ImageKey { get; set; }
+        public string KeywordFilter { get; set; }
+        public string NavigateUrlKey { get; set; }
+        public event AdCreatedEventHandler AdCreated;
+        protected virtual AdRotator CreateWebAdRotator();
+        protected virtual void OnAdCreated(AdCreatedEventArgs e);
+        protected override void Render(HtmlTextWriter writer);
+    }
+    public enum Alignment {
+        Center = 2,
+        Left = 1,
+        NotSet = 0,
+        Right = 3,
+    }
+    public class ArrayListCollectionBase : ICollection, IEnumerable {
+        public int Count { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        protected ArrayList Items { get; set; }
+        public object SyncRoot { get; }
+        public void CopyTo(Array array, int index);
+        public IEnumerator GetEnumerator();
+    }
+    public abstract class BaseValidator : TextControl, IValidator {
+        protected BaseValidator();
+        public string ControlToValidate { get; set; }
+        public ValidatorDisplay Display { get; set; }
+        public string ErrorMessage { get; set; }
+        public bool IsValid { get; set; }
+        public override string StyleReference { get; set; }
+        public override int VisibleWeight { get; }
+        protected void CheckControlValidationProperty(string name, string propertyName);
+        protected virtual bool ControlPropertiesValid();
+        protected override Style CreateStyle();
+        protected virtual BaseValidator CreateWebValidator();
+        protected abstract bool EvaluateIsValid();
+        protected override void OnInit(EventArgs e);
+        protected override void OnPreRender(EventArgs e);
+        public void Validate();
+    }
+    public enum BooleanOption {
+        False = 0,
+        NotSet = -1,
+        True = 1,
+    }
+    public class Calendar : MobileControl, IPostBackEventHandler {
+        public Calendar();
+        public string CalendarEntryText { get; set; }
+        public FirstDayOfWeek FirstDayOfWeek { get; set; }
+        public DateTime SelectedDate { get; set; }
+        public SelectedDatesCollection SelectedDates { get; }
+        public CalendarSelectionMode SelectionMode { get; set; }
+        public bool ShowDayHeader { get; set; }
+        public DateTime VisibleDate { get; set; }
+        public Calendar WebCalendar { get; }
+        public event EventHandler SelectionChanged;
+        protected virtual Calendar CreateWebCalendar();
+        protected virtual void OnSelectionChanged();
+        protected void RaisePostBackEvent(string eventArgument);
+        public void RaiseSelectionChangedEvent();
+        void System.Web.UI.IPostBackEventHandler.RaisePostBackEvent(string eventArgument);
+    }
+    public class Command : TextControl, IPostBackDataHandler, IPostBackEventHandler {
+        public Command();
+        public bool CausesValidation { get; set; }
+        public string CommandArgument { get; set; }
+        public string CommandName { get; set; }
+        public CommandFormat Format { get; set; }
+        public string ImageUrl { get; set; }
+        public string SoftkeyLabel { get; set; }
+        public event EventHandler Click;
+        public event CommandEventHandler ItemCommand;
+        protected override bool IsFormSubmitControl();
+        protected bool LoadPostData(string key, NameValueCollection data);
+        protected virtual void OnClick(EventArgs e);
+        protected virtual void OnItemCommand(CommandEventArgs e);
+        protected override void OnPreRender(EventArgs e);
+        protected void RaisePostBackEvent(string argument);
+        protected void RaisePostDataChangedEvent();
+        bool System.Web.UI.IPostBackDataHandler.LoadPostData(string key, NameValueCollection data);
+        void System.Web.UI.IPostBackDataHandler.RaisePostDataChangedEvent();
+        void System.Web.UI.IPostBackEventHandler.RaisePostBackEvent(string eventArgument);
+    }
+    public enum CommandFormat {
+        Button = 0,
+        Link = 1,
+    }
+    public class CompareValidator : BaseValidator {
+        public CompareValidator();
+        public string ControlToCompare { get; set; }
+        public ValidationCompareOperator Operator { get; set; }
+        public ValidationDataType Type { get; set; }
+        public string ValueToCompare { get; set; }
+        protected override bool ControlPropertiesValid();
+        protected override BaseValidator CreateWebValidator();
+        protected override bool EvaluateIsValid();
+    }
+    public class Constants {
+        public static readonly char SelectionListSpecialCharacter;
+        public static readonly int DefaultSessionsStateHistorySize;
+        public static readonly string AlternatingItemTemplateTag;
+        public static readonly string ContentTemplateTag;
+        public static readonly string EventArgumentID;
+        public static readonly string EventSourceID;
+        public static readonly string FooterTemplateTag;
+        public static readonly string FormIDPrefix;
+        public static readonly string HeaderTemplateTag;
+        public static readonly string ItemDetailsTemplateTag;
+        public static readonly string ItemTemplateTag;
+        public static readonly string LabelTemplateTag;
+        public static readonly string OptimumPageWeightParameter;
+        public static readonly string PagePrefix;
+        public static readonly string ScreenCharactersHeightParameter;
+        public static readonly string ScriptTemplateTag;
+        public static readonly string SeparatorTemplateTag;
+        public static readonly string SymbolProtocol;
+        public static readonly string UniqueFilePathSuffixVariable;
+        public static readonly string UniqueFilePathSuffixVariableWithoutEqual;
+        public Constants();
+    }
+    public sealed class ControlElement : ConfigurationElement {
+        public ControlElement(string name, Type adapter);
+        public Type Adapter { get; set; }
+        public Type Control { get; set; }
+        protected override ConfigurationElementProperty ElementProperty { get; }
+        public string Name { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class ControlElementCollection : ConfigurationElementCollection {
+        public ControlElementCollection();
+        public object[] AllKeys { get; }
+        public override ConfigurationElementCollectionType CollectionType { get; }
+        protected override string ElementName { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public ControlElement this[int index] { get; set; }
+        public new ControlElement this[string name] { get; }
+        protected override bool ThrowOnDuplicate { get; }
+        public void Add(ControlElement controlElement);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public void Remove(string name);
+        public void Remove(ControlElement controlElement);
+        public void RemoveAt(int index);
+    }
+    public class ControlPager {
+        public static readonly int DefaultWeight;
+        public static readonly int UseDefaultWeight;
+        public ControlPager(Form form, int pageWeight);
+        public int PageCount { get; set; }
+        public int PageWeight { get; }
+        public int RemainingWeight { get; set; }
+        public ItemPager GetItemPager(MobileControl control, int itemCount, int itemsPerPage, int itemWeight);
+        public int GetPage(int weight);
+    }
+    public class CustomValidator : BaseValidator {
+        public CustomValidator();
+        public event ServerValidateEventHandler ServerValidate;
+        protected override bool ControlPropertiesValid();
+        protected override BaseValidator CreateWebValidator();
+        protected override bool EvaluateIsValid();
+        protected virtual bool OnServerValidate(string value);
+    }
+    public class DesignerAdapterAttribute : Attribute {
+        public DesignerAdapterAttribute(string adapterTypeName);
+        public DesignerAdapterAttribute(Type adapterType);
+        public virtual string TypeName { get; }
+    }
+    public sealed class DeviceElement : ConfigurationElement {
+        public DeviceElement(string name, string inheritsFrom);
+        public DeviceElement(string name, string inheritsFrom, Type predicateClass, string predicateMethod, Type pageAdapter);
+        public DeviceElement(string name, Type predicateClass, string predicateMethod, Type pageAdapter);
+        public ControlElementCollection Controls { get; }
+        protected override ConfigurationElementProperty ElementProperty { get; }
+        public string InheritsFrom { get; set; }
+        public string Name { get; set; }
+        public Type PageAdapter { get; set; }
+        public Type PredicateClass { get; set; }
+        public string PredicateMethod { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class DeviceElementCollection : ConfigurationElementCollection {
+        public DeviceElementCollection();
+        public object[] AllKeys { get; }
+        public override ConfigurationElementCollectionType CollectionType { get; }
+        protected override string ElementName { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public DeviceElement this[int index] { get; set; }
+        public new DeviceElement this[string name] { get; }
+        protected override bool ThrowOnDuplicate { get; }
+        public void Add(DeviceElement deviceElement);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public void Remove(string name);
+        public void Remove(DeviceElement deviceElement);
+        public void RemoveAt(int index);
+    }
+    public class DeviceOverridableAttribute : Attribute {
+        public DeviceOverridableAttribute();
+        public DeviceOverridableAttribute(bool overridable);
+        public bool Overridable { get; }
+    }
+    public class DeviceSpecific : Control {
+        public DeviceSpecific();
+        public DeviceSpecificChoiceCollection Choices { get; }
+        public override bool EnableViewState { get; set; }
+        public bool HasTemplates { get; }
+        public MobilePage MobilePage { get; }
+        public object Owner { get; }
+        public DeviceSpecificChoice SelectedChoice { get; }
+        public override bool Visible { get; set; }
+        public new event EventHandler DataBinding;
+        public new event EventHandler Disposed;
+        public new event EventHandler Init;
+        public new event EventHandler Load;
+        public new event EventHandler PreRender;
+        public new event EventHandler Unload;
+        protected override void AddParsedSubObject(object obj);
+        public ITemplate GetTemplate(string templateName);
+    }
+    public class DeviceSpecificChoice : IAttributeAccessor, IParserAccessor {
+        public DeviceSpecificChoice();
+        public string Argument { get; set; }
+        public IDictionary Contents { get; }
+        public string Filter { get; set; }
+        public bool HasTemplates { get; }
+        public IDictionary Templates { get; }
+        public string Xmlns { get; set; }
+        protected void AddParsedSubObject(object obj);
+        protected string GetAttribute(string key);
+        protected void SetAttribute(string key, string value);
+        string System.Web.UI.IAttributeAccessor.GetAttribute(string name);
+        void System.Web.UI.IAttributeAccessor.SetAttribute(string name, string value);
+        void System.Web.UI.IParserAccessor.AddParsedSubObject(object obj);
+    }
+    public class DeviceSpecificChoiceCollection : ArrayListCollectionBase {
+        public ArrayList All { get; }
+        public DeviceSpecificChoice this[int index] { get; }
+        public void Add(DeviceSpecificChoice choice);
+        public void AddAt(int index, DeviceSpecificChoice choice);
+        public void Clear();
+        public void Remove(DeviceSpecificChoice choice);
+        public void RemoveAt(int index);
+    }
+    public class DeviceSpecificChoiceControlBuilder : ControlBuilder {
+        public DeviceSpecificChoiceControlBuilder();
+        public override void AppendLiteralString(string text);
+        public override void AppendSubBuilder(ControlBuilder subBuilder);
+        public override Type GetChildControlType(string tagName, IDictionary attributes);
+        public override void Init(TemplateParser parser, ControlBuilder parentBuilder, Type type, string tagName, string id, IDictionary attributes);
+    }
+    public class DeviceSpecificChoiceTemplateBuilder : TemplateBuilder {
+        public DeviceSpecificChoiceTemplateBuilder();
+        public override void AppendLiteralString(string text);
+        public override void AppendSubBuilder(ControlBuilder subBuilder);
+        public override void Init(TemplateParser parser, ControlBuilder parentBuilder, Type type, string tagName, string id, IDictionary attributes);
+    }
+    public class DeviceSpecificChoiceTemplateContainer {
+        public DeviceSpecificChoiceTemplateContainer();
+        public string Name { get; set; }
+        public ITemplate Template { get; set; }
+    }
+    public class DeviceSpecificControlBuilder : ControlBuilder {
+        public DeviceSpecificControlBuilder();
+        public override void AppendLiteralString(string text);
+        public override Type GetChildControlType(string tagName, IDictionary attributes);
+    }
+    public class ErrorFormatterPage : MobilePage {
+        public ErrorFormatterPage();
+        protected MobileErrorInfo ErrorInfo { get; }
+        protected virtual void InitContent();
+        protected override object LoadPageStateFromPersistenceMedium();
+        protected override void OnInit(EventArgs e);
+        protected override void SavePageStateToPersistenceMedium(object viewState);
+    }
+    public class FontInfo {
+        public BooleanOption Bold { get; set; }
+        public BooleanOption Italic { get; set; }
+        public string Name { get; set; }
+        public FontSize Size { get; set; }
+        public override string ToString();
+    }
+    public enum FontSize {
+        Large = 3,
+        Normal = 1,
+        NotSet = 0,
+        Small = 2,
+    }
+    public class Form : Panel, IPostBackEventHandler, ITemplateable {
+        public Form();
+        public string Action { get; set; }
+        public override bool BreakAfter { get; set; }
+        public Control ControlToPaginate { get; set; }
+        public int CurrentPage { get; set; }
+        public Panel Footer { get; }
+        public Panel Header { get; }
+        public FormMethod Method { get; set; }
+        public int PageCount { get; }
+        public PagerStyle PagerStyle { get; }
+        protected override bool PaginateChildren { get; }
+        public Panel Script { get; }
+        public string Title { get; set; }
+        public event EventHandler Activate;
+        public event EventHandler Deactivate;
+        public event EventHandler Paginated;
+        public override void CreateDefaultTemplatedUI(bool doDataBind);
+        public IList GetLinkedForms(int optimumPageWeight);
+        public virtual bool HasActivateHandler();
+        public virtual bool HasDeactivateHandler();
+        protected override void LoadPrivateViewState(object state);
+        protected virtual void OnActivate(EventArgs e);
+        protected override void OnDataBinding(EventArgs e);
+        protected virtual void OnDeactivate(EventArgs e);
+        protected override void OnInit(EventArgs e);
+        protected virtual void OnPaginated(EventArgs e);
+        protected override void OnPreRender(EventArgs e);
+        public override void PaginateRecursive(ControlPager pager);
+        protected void RaisePostBackEvent(string eventArgument);
+        protected override void Render(HtmlTextWriter writer);
+        protected override object SavePrivateViewState();
+        void System.Web.UI.IPostBackEventHandler.RaisePostBackEvent(string eventArgument);
+    }
+    public class FormControlBuilder : LiteralTextContainerControlBuilder {
+        public FormControlBuilder();
+        public override void AppendSubBuilder(ControlBuilder subBuilder);
+    }
+    public enum FormMethod {
+        Get = 0,
+        Post = 1,
+    }
+    public interface IControlAdapter {
+        MobileControl Control { get; set; }
+        int ItemWeight { get; }
+        MobilePage Page { get; }
+        int VisibleWeight { get; }
+        void CreateTemplatedUI(bool doDataBind);
+        bool HandlePostBackEvent(string eventArgument);
+        void LoadAdapterState(object state);
+        bool LoadPostData(string postDataKey, NameValueCollection postCollection, object controlPrivateData, out bool dataChanged);
+        void OnInit(EventArgs e);
+        void OnLoad(EventArgs e);
+        void OnPreRender(EventArgs e);
+        void OnUnload(EventArgs e);
+        void Render(HtmlTextWriter writer);
+        object SaveAdapterState();
+    }
+    public class Image : MobileControl, IPostBackEventHandler {
+        public Image();
+        public string AlternateText { get; set; }
+        public string ImageUrl { get; set; }
+        public string NavigateUrl { get; set; }
+        public string SoftkeyLabel { get; set; }
+        protected void RaisePostBackEvent(string argument);
+        void System.Web.UI.IPostBackEventHandler.RaisePostBackEvent(string eventArgument);
+    }
+    public interface IObjectListFieldCollection : ICollection, IEnumerable {
+        ObjectListField this[int index] { get; }
+        ObjectListField[] GetAll();
+        int IndexOf(string fieldIDOrTitle);
+        int IndexOf(ObjectListField field);
+    }
+    public interface IPageAdapter : IControlAdapter {
+        IList CacheVaryByHeaders { get; }
+        IDictionary CookielessDataDictionary { get; set; }
+        int OptimumPageWeight { get; }
+        new MobilePage Page { get; set; }
+        bool PersistCookielessData { get; set; }
+        HtmlTextWriter CreateTextWriter(TextWriter writer);
+        NameValueCollection DeterminePostBackMode(HttpRequest request, string postEventSourceID, string postEventArgumentID, NameValueCollection baseCollection);
+        bool HandleError(Exception e, HtmlTextWriter writer);
+        bool HandlePagePostBackEvent(string eventSource, string eventArgument);
+    }
+    public class ItemPager {
+        public ItemPager();
+        public ItemPager(ControlPager pager, MobileControl control, int itemCount, int itemsPerPage, int itemWeight);
+        public int ItemCount { get; }
+        public int ItemIndex { get; }
+    }
+    public interface ITemplateable
+    public class Label : TextControl {
+        public Label();
+    }
+    public class Link : TextControl, IPostBackEventHandler {
+        public Link();
+        public string NavigateUrl { get; set; }
+        public string SoftkeyLabel { get; set; }
+        public override void AddLinkedForms(IList linkedForms);
+        protected void RaisePostBackEvent(string argument);
+        void System.Web.UI.IPostBackEventHandler.RaisePostBackEvent(string eventArgument);
+    }
+    public class List : PagedControl, INamingContainer, IPostBackEventHandler, ITemplateable {
+        public List();
+        public virtual string DataMember { get; set; }
+        public virtual object DataSource { get; set; }
+        public string DataTextField { get; set; }
+        public string DataValueField { get; set; }
+        public ListDecoration Decoration { get; set; }
+        public bool HasItemCommandHandler { get; }
+        protected override int InternalItemCount { get; }
+        public MobileListItemCollection Items { get; }
+        public bool ItemsAsLinks { get; set; }
+        public event ListCommandEventHandler ItemCommand;
+        public event ListDataBindEventHandler ItemDataBind;
+        protected override void AddParsedSubObject(object obj);
+        protected override void CreateChildControls();
+        public override void CreateDefaultTemplatedUI(bool doDataBind);
+        protected virtual void CreateItems(IEnumerable dataSource);
+        protected override void EnsureChildControls();
+        public override void EnsureTemplatedUI();
+        protected override void LoadViewState(object savedState);
+        protected override bool OnBubbleEvent(object sender, EventArgs e);
+        protected override void OnDataBinding(EventArgs e);
+        protected virtual void OnItemCommand(ListCommandEventArgs e);
+        protected virtual void OnItemDataBind(ListDataBindEventArgs e);
+        protected override void OnLoadItems(LoadItemsEventArgs e);
+        protected override void OnPageChange(int oldPageIndex, int newPageIndex);
+        protected override void OnPreRender(EventArgs e);
+        protected void RaisePostBackEvent(string eventArgument);
+        protected override object SaveViewState();
+        void System.Web.UI.IPostBackEventHandler.RaisePostBackEvent(string eventArgument);
+        protected override void TrackViewState();
+    }
+    public class ListCommandEventArgs : CommandEventArgs {
+        protected static readonly string DefaultCommand;
+        public ListCommandEventArgs(MobileListItem item, object commandSource);
+        public ListCommandEventArgs(MobileListItem item, object commandSource, CommandEventArgs originalArgs);
+        public object CommandSource { get; }
+        public MobileListItem ListItem { get; }
+    }
+    public delegate void ListCommandEventHandler(object sender, ListCommandEventArgs e);
+    public class ListControlBuilder : MobileControlBuilder {
+        public ListControlBuilder();
+        public override Type GetChildControlType(string tagName, IDictionary attributes);
+    }
+    public class ListDataBindEventArgs : EventArgs {
+        public ListDataBindEventArgs(MobileListItem item, object dataItem);
+        public object DataItem { get; }
+        public MobileListItem ListItem { get; }
+    }
+    public delegate void ListDataBindEventHandler(object sender, ListDataBindEventArgs e);
+    public enum ListDecoration {
+        Bulleted = 1,
+        None = 0,
+        Numbered = 2,
+    }
+    public enum ListSelectType {
+        CheckBox = 4,
+        DropDown = 0,
+        ListBox = 1,
+        MultiSelectListBox = 3,
+        Radio = 2,
+    }
+    public class LiteralLink : Link {
+        public LiteralLink();
+    }
+    public class LiteralText : PagedControl {
+        public LiteralText();
+        protected override int InternalItemCount { get; }
+        protected override int ItemWeight { get; }
+        public string PagedText { get; }
+        public string Text { get; set; }
+    }
+    public class LiteralTextContainerControlBuilder : MobileControlBuilder {
+        public override void AppendLiteralString(string text);
+        public override void AppendSubBuilder(ControlBuilder subBuilder);
+    }
+    public class LiteralTextControlBuilder : MobileControlBuilder {
+        public LiteralTextControlBuilder();
+        public override bool AllowWhitespaceLiterals();
+    }
+    public class LoadItemsEventArgs : EventArgs {
+        public LoadItemsEventArgs(int index, int count);
+        public int ItemCount { get; }
+        public int ItemIndex { get; }
+    }
+    public delegate void LoadItemsEventHandler(object sender, LoadItemsEventArgs e);
+    public abstract class MobileControl : Control, IAttributeAccessor {
+        protected MobileControl();
+        public new IControlAdapter Adapter { get; }
+        public virtual Alignment Alignment { get; set; }
+        public virtual Color BackColor { get; set; }
+        public virtual bool BreakAfter { get; set; }
+        public StateBag CustomAttributes { get; }
+        public DeviceSpecific DeviceSpecific { get; set; }
+        public sealed override bool EnableTheming { get; set; }
+        public int FirstPage { get; set; }
+        public virtual FontInfo Font { get; }
+        public virtual Color ForeColor { get; set; }
+        public Form Form { get; }
+        protected string InnerText { get; set; }
+        public virtual bool IsTemplated { get; }
+        public int LastPage { get; set; }
+        public MobilePage MobilePage { get; }
+        protected virtual bool PaginateChildren { get; }
+        public sealed override string SkinID { get; set; }
+        protected internal virtual Style Style { get; }
+        public virtual string StyleReference { get; set; }
+        public virtual int VisibleWeight { get; }
+        public virtual Wrapping Wrapping { get; set; }
+        protected override void AddedControl(Control control, int index);
+        public virtual void AddLinkedForms(IList linkedForms);
+        protected override void AddParsedSubObject(object obj);
+        public sealed override void ApplyStyleSheetSkin(Page page);
+        public virtual void CreateDefaultTemplatedUI(bool doDataBind);
+        protected virtual Style CreateStyle();
+        protected virtual void CreateTemplatedUI(bool doDataBind);
+        public virtual void EnsureTemplatedUI();
+        protected string GetAttribute(string name);
+        public virtual ITemplate GetTemplate(string templateName);
+        protected virtual bool IsFormSubmitControl();
+        public bool IsVisibleOnPage(int pageNumber);
+        protected virtual void LoadPrivateViewState(object state);
+        protected override void LoadViewState(object savedState);
+        protected override void OnDataBinding(EventArgs e);
+        protected override void OnInit(EventArgs e);
+        protected override void OnLoad(EventArgs e);
+        protected virtual void OnPageChange(int oldPageIndex, int newPageIndex);
+        protected override void OnPreRender(EventArgs e);
+        protected virtual void OnRender(HtmlTextWriter writer);
+        protected override void OnUnload(EventArgs e);
+        public virtual void PaginateRecursive(ControlPager pager);
+        protected override void RemovedControl(Control control);
+        protected override void Render(HtmlTextWriter writer);
+        public new void RenderChildren(HtmlTextWriter writer);
+        public Form ResolveFormReference(string formID);
+        public new string ResolveUrl(string relativeUrl);
+        protected virtual object SavePrivateViewState();
+        protected override object SaveViewState();
+        protected void SetAttribute(string name, string value);
+        string System.Web.UI.IAttributeAccessor.GetAttribute(string name);
+        void System.Web.UI.IAttributeAccessor.SetAttribute(string name, string value);
+        protected override void TrackViewState();
+    }
+    public class MobileControlBuilder : ControlBuilder {
+        public MobileControlBuilder();
+        public override bool AllowWhitespaceLiterals();
+        public override Type GetChildControlType(string tagName, IDictionary attributes);
+    }
+    public sealed class MobileControlsSection : ConfigurationSection {
+        public MobileControlsSection();
+        public bool AllowCustomAttributes { get; set; }
+        public Type CookielessDataDictionaryType { get; set; }
+        public DeviceElementCollection Devices { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public int SessionStateHistorySize { get; set; }
+    }
+    public class MobileControlsSectionHandler : IConfigurationSectionHandler {
+        public MobileControlsSectionHandler();
+        protected object Create(object parent, object context, XmlNode input);
+        object System.Configuration.IConfigurationSectionHandler.Create(object parent, object context, XmlNode input);
+    }
+    public class MobileListItem : TemplateContainer, IStateManager {
+        public MobileListItem();
+        public MobileListItem(object dataItem, string text, string value);
+        public MobileListItem(string text);
+        public MobileListItem(string text, string value);
+        public MobileListItem(MobileListItemType itemType);
+        public object DataItem { get; set; }
+        public int Index { get; }
+        protected new bool IsTrackingViewState { get; }
+        public bool Selected { get; set; }
+        bool System.Web.UI.IStateManager.IsTrackingViewState { get; }
+        public string Text { get; set; }
+        public string Value { get; set; }
+        public override bool Equals(object o);
+        public static MobileListItem FromString(string s);
+        public override int GetHashCode();
+        protected new void LoadViewState(object state);
+        protected override bool OnBubbleEvent(object source, EventArgs e);
+        public static implicit operator MobileListItem (string s);
+        protected new object SaveViewState();
+        void System.Web.UI.IStateManager.LoadViewState(object state);
+        object System.Web.UI.IStateManager.SaveViewState();
+        void System.Web.UI.IStateManager.TrackViewState();
+        public override string ToString();
+        protected new void TrackViewState();
+    }
+    public class MobileListItemCollection : ArrayListCollectionBase, IStateManager {
+        public MobileListItemCollection();
+        public MobileListItemCollection(ArrayList items);
+        protected bool IsTrackingViewState { get; }
+        bool System.Web.UI.IStateManager.IsTrackingViewState { get; }
+        public MobileListItem this[int index] { get; }
+        public virtual void Add(string item);
+        public void Add(MobileListItem item);
+        public void Clear();
+        public bool Contains(MobileListItem item);
+        public MobileListItem[] GetAll();
+        public int IndexOf(MobileListItem item);
+        public virtual void Insert(int index, string item);
+        public void Insert(int index, MobileListItem item);
+        protected void LoadViewState(object state);
+        public virtual void Remove(string item);
+        public void Remove(MobileListItem item);
+        public void RemoveAt(int index);
+        protected object SaveViewState();
+        public void SetAll(MobileListItem[] value);
+        void System.Web.UI.IStateManager.LoadViewState(object state);
+        object System.Web.UI.IStateManager.SaveViewState();
+        void System.Web.UI.IStateManager.TrackViewState();
+        protected void TrackViewState();
+    }
+    public enum MobileListItemType {
+        FooterItem = 2,
+        HeaderItem = 0,
+        ListItem = 1,
+        SeparatorItem = 3,
+    }
+    public class MobilePage : Page {
+        public static readonly string HiddenPostEventArgumentId;
+        public static readonly string HiddenPostEventSourceId;
+        public static readonly string HiddenVariablePrefix;
+        public static readonly string PageClientViewStateKey;
+        public static readonly string ViewStateID;
+        public MobilePage();
+        public string AbsoluteFilePath { get; }
+        public Form ActiveForm { get; set; }
+        public new IPageAdapter Adapter { get; }
+        public bool AllowCustomAttributes { get; set; }
+        public string ClientViewState { get; }
+        public new bool DesignMode { get; }
+        public virtual MobileCapabilities Device { get; }
+        public override bool EnableEventValidation { get; set; }
+        public override bool EnableTheming { get; set; }
+        public IList Forms { get; }
+        public IDictionary HiddenVariables { get; }
+        public override char IdSeparator { get; }
+        public sealed override string MasterPageFile { get; set; }
+        public string QueryStringText { get; }
+        public string RelativeFilePath { get; }
+        public StyleSheet StyleSheet { get; set; }
+        public override string StyleSheetTheme { get; set; }
+        public override string Theme { get; set; }
+        public new string Title { get; set; }
+        public new string UniqueFilePathSuffix { get; }
+        protected override void AddedControl(Control control, int index);
+        protected override void AddParsedSubObject(object o);
+        protected override HtmlTextWriter CreateHtmlTextWriter(TextWriter writer);
+        protected override NameValueCollection DeterminePostBackMode();
+        public virtual IControlAdapter GetControlAdapter(MobileControl control);
+        public Form GetForm(string id);
+        public object GetPrivateViewState(MobileControl ctl);
+        public bool HasHiddenVariables();
+        protected override void InitOutputCache(int duration, string varyByContentEncoding, string varyByHeader, string varyByCustom, OutputCacheLocation location, string varyByParam);
+        protected override void InitOutputCache(int duration, string varyByHeader, string varyByCustom, OutputCacheLocation location, string varyByParam);
+        protected override object LoadPageStateFromPersistenceMedium();
+        protected override void LoadViewState(object savedState);
+        public string MakePathAbsolute(string virtualPath);
+        protected virtual void OnDeviceCustomize(EventArgs e);
+        protected override void OnError(EventArgs e);
+        protected override void OnInit(EventArgs e);
+        protected override void OnLoad(EventArgs e);
+        protected override void OnPreInit(EventArgs e);
+        protected override void OnPreRender(EventArgs e);
+        protected override void OnUnload(EventArgs e);
+        protected virtual void OnViewStateExpire(EventArgs e);
+        protected override void RaisePostBackEvent(IPostBackEventHandler sourceControl, string eventArgument);
+        public void RedirectToMobilePage(string url);
+        public void RedirectToMobilePage(string url, bool endResponse);
+        protected override void RemovedControl(Control control);
+        protected override void Render(HtmlTextWriter writer);
+        public override void RenderControl(HtmlTextWriter writer);
+        protected override void SavePageStateToPersistenceMedium(object view);
+        protected override object SaveViewState();
+        public override void Validate();
+        public override void VerifyRenderingInServerForm(Control control);
+    }
+    public sealed class MobileTypeNameConverter : ConfigurationConverterBase {
+        public MobileTypeNameConverter();
+        public override object ConvertFrom(ITypeDescriptorContext ctx, CultureInfo ci, object data);
+        public override object ConvertTo(ITypeDescriptorContext ctx, CultureInfo ci, object value, Type targetType);
+    }
+    public class MobileUserControl : UserControl {
+        public MobileUserControl();
+        protected override void AddParsedSubObject(object o);
+    }
+    public class ObjectList : PagedControl, INamingContainer, IPostBackEventHandler, ITemplateable {
+        public ObjectList();
+        public IObjectListFieldCollection AllFields { get; }
+        public bool AutoGenerateFields { get; set; }
+        public string BackCommandText { get; set; }
+        public virtual ObjectListCommandCollection Commands { get; }
+        public Style CommandStyle { get; set; }
+        public virtual string DataMember { get; set; }
+        public virtual object DataSource { get; set; }
+        public string DefaultCommand { get; set; }
+        public Panel Details { get; }
+        public string DetailsCommandText { get; set; }
+        public virtual ObjectListFieldCollection Fields { get; }
+        public bool HasItemCommandHandler { get; }
+        protected override int InternalItemCount { get; }
+        public virtual ObjectListItemCollection Items { get; }
+        public string LabelField { get; set; }
+        public int LabelFieldIndex { get; }
+        public Style LabelStyle { get; set; }
+        public string MoreText { get; set; }
+        public int SelectedIndex { get; set; }
+        public ObjectListItem Selection { get; }
+        public static string SelectMoreCommand { get; }
+        public int[] TableFieldIndices { get; }
+        public string TableFields { get; set; }
+        public ObjectListViewMode ViewMode { get; set; }
+        public event ObjectListCommandEventHandler ItemCommand;
+        public event ObjectListDataBindEventHandler ItemDataBind;
+        public event ObjectListSelectEventHandler ItemSelect;
+        public event ObjectListShowCommandsEventHandler ShowItemCommands;
+        protected override void AddParsedSubObject(object obj);
+        protected void CreateAutoGeneratedFields(IEnumerable dataSource);
+        protected override void CreateChildControls();
+        protected virtual ObjectListItem CreateItem(object dataItem);
+        protected virtual void CreateItems(IEnumerable dataSource);
+        public void CreateTemplatedItemDetails(bool doDataBind);
+        public void CreateTemplatedItemsList(bool doDataBind);
+        public override void DataBind();
+        protected override void EnsureChildControls();
+        public override void EnsureTemplatedUI();
+        protected override void LoadPrivateViewState(object state);
+        protected override void LoadViewState(object savedState);
+        protected override bool OnBubbleEvent(object sender, EventArgs e);
+        protected override void OnDataBinding(EventArgs e);
+        protected virtual void OnItemCommand(ObjectListCommandEventArgs e);
+        protected virtual void OnItemDataBind(ObjectListDataBindEventArgs e);
+        protected virtual void OnItemSelect(ObjectListSelectEventArgs e);
+        protected override void OnLoadItems(LoadItemsEventArgs e);
+        protected override void OnPreRender(EventArgs e);
+        protected virtual void OnShowItemCommands(ObjectListShowCommandsEventArgs e);
+        public void PreShowItemCommands(int itemIndex);
+        public void RaiseDefaultItemEvent(int itemIndex);
+        protected void RaisePostBackEvent(string eventArgument);
+        protected override object SavePrivateViewState();
+        protected override object SaveViewState();
+        public bool SelectListItem(int itemIndex, bool selectMore);
+        void System.Web.UI.IPostBackEventHandler.RaisePostBackEvent(string eventArgument);
+        protected override void TrackViewState();
+    }
+    public class ObjectListCommand {
+        public ObjectListCommand();
+        public ObjectListCommand(string name, string text);
+        public string Name { get; set; }
+        public string Text { get; set; }
+    }
+    public class ObjectListCommandCollection : ArrayListCollectionBase, IStateManager {
+        protected bool IsTrackingViewState { get; }
+        bool System.Web.UI.IStateManager.IsTrackingViewState { get; }
+        public ObjectListCommand this[int index] { get; }
+        public void Add(ObjectListCommand command);
+        public void AddAt(int index, ObjectListCommand command);
+        public void Clear();
+        public int IndexOf(string s);
+        protected void LoadViewState(object state);
+        public void Remove(string s);
+        public void RemoveAt(int index);
+        protected object SaveViewState();
+        void System.Web.UI.IStateManager.LoadViewState(object state);
+        object System.Web.UI.IStateManager.SaveViewState();
+        void System.Web.UI.IStateManager.TrackViewState();
+        protected void TrackViewState();
+    }
+    public class ObjectListCommandEventArgs : CommandEventArgs {
+        protected static readonly string DefaultCommand;
+        public ObjectListCommandEventArgs(ObjectListItem item, object commandSource, CommandEventArgs originalArgs);
+        public ObjectListCommandEventArgs(ObjectListItem item, string commandName);
+        public object CommandSource { get; }
+        public ObjectListItem ListItem { get; }
+    }
+    public delegate void ObjectListCommandEventHandler(object sender, ObjectListCommandEventArgs e);
+    public class ObjectListControlBuilder : MobileControlBuilder {
+        public ObjectListControlBuilder();
+        public override Type GetChildControlType(string tagName, IDictionary attributes);
+    }
+    public class ObjectListDataBindEventArgs : EventArgs {
+        public ObjectListDataBindEventArgs(ObjectListItem item, object dataItem);
+        public object DataItem { get; }
+        public ObjectListItem ListItem { get; }
+    }
+    public delegate void ObjectListDataBindEventHandler(object sender, ObjectListDataBindEventArgs e);
+    public sealed class ObjectListField : IStateManager {
+        public ObjectListField();
+        public string DataField { get; set; }
+        public string DataFormatString { get; set; }
+        public string Name { get; set; }
+        bool System.Web.UI.IStateManager.IsTrackingViewState { get; }
+        public string Title { get; set; }
+        public bool Visible { get; set; }
+        public void DataBindItem(int fieldIndex, ObjectListItem item);
+        void System.Web.UI.IStateManager.LoadViewState(object state);
+        object System.Web.UI.IStateManager.SaveViewState();
+        void System.Web.UI.IStateManager.TrackViewState();
+    }
+    public class ObjectListFieldCollection : ArrayListCollectionBase, ICollection, IEnumerable, IObjectListFieldCollection, IStateManager {
+        protected bool IsTrackingViewState { get; }
+        bool System.Web.UI.IStateManager.IsTrackingViewState { get; }
+        public ObjectListField this[int index] { get; }
+        public void Add(ObjectListField field);
+        public void AddAt(int index, ObjectListField field);
+        public void Clear();
+        public ObjectListField[] GetAll();
+        public int IndexOf(string fieldIDOrName);
+        public int IndexOf(ObjectListField field);
+        protected void LoadViewState(object savedState);
+        public void Remove(ObjectListField field);
+        public void RemoveAt(int index);
+        protected object SaveViewState();
+        public void SetAll(ObjectListField[] value);
+        void System.Web.UI.IStateManager.LoadViewState(object state);
+        object System.Web.UI.IStateManager.SaveViewState();
+        void System.Web.UI.IStateManager.TrackViewState();
+        protected void TrackViewState();
+    }
+    public class ObjectListItem : MobileListItem {
+        public string this[int index] { get; set; }
+        public string this[string key] { get; set; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        protected override bool OnBubbleEvent(object source, EventArgs e);
+    }
+    public class ObjectListItemCollection : ArrayListCollectionBase, IStateManager {
+        protected bool IsTrackingViewState { get; }
+        bool System.Web.UI.IStateManager.IsTrackingViewState { get; }
+        public ObjectListItem this[int index] { get; }
+        public void Clear();
+        public bool Contains(ObjectListItem item);
+        public ObjectListItem[] GetAll();
+        public int IndexOf(ObjectListItem item);
+        protected void LoadViewState(object state);
+        protected object SaveViewState();
+        void System.Web.UI.IStateManager.LoadViewState(object state);
+        object System.Web.UI.IStateManager.SaveViewState();
+        void System.Web.UI.IStateManager.TrackViewState();
+        protected void TrackViewState();
+    }
+    public class ObjectListSelectEventArgs : EventArgs {
+        public ObjectListSelectEventArgs(ObjectListItem item, bool selectMore);
+        public ObjectListItem ListItem { get; }
+        public bool SelectMore { get; }
+        public bool UseDefaultHandling { get; set; }
+    }
+    public delegate void ObjectListSelectEventHandler(object sender, ObjectListSelectEventArgs e);
+    public class ObjectListShowCommandsEventArgs : EventArgs {
+        public ObjectListShowCommandsEventArgs(ObjectListItem item, ObjectListCommandCollection commands);
+        public ObjectListCommandCollection Commands { get; }
+        public ObjectListItem ListItem { get; }
+    }
+    public delegate void ObjectListShowCommandsEventHandler(object sender, ObjectListShowCommandsEventArgs e);
+    public class ObjectListTitleAttribute : Attribute {
+        public ObjectListTitleAttribute(string title);
+        public virtual string Title { get; }
+    }
+    public enum ObjectListViewMode {
+        Commands = 1,
+        Details = 2,
+        List = 0,
+    }
+    public abstract class PagedControl : MobileControl {
+        protected PagedControl();
+        public int FirstVisibleItemIndex { get; }
+        protected abstract int InternalItemCount { get; }
+        public int ItemCount { get; set; }
+        public int ItemsPerPage { get; set; }
+        protected virtual int ItemWeight { get; }
+        public int VisibleItemCount { get; }
+        public override int VisibleWeight { get; }
+        public event LoadItemsEventHandler LoadItems;
+        protected override void LoadPrivateViewState(object state);
+        protected virtual void OnLoadItems(LoadItemsEventArgs e);
+        protected override void OnPageChange(int oldPageIndex, int newPageIndex);
+        protected override void OnPreRender(EventArgs e);
+        public override void PaginateRecursive(ControlPager pager);
+        protected override object SavePrivateViewState();
+    }
+    public class PagerStyle : Style {
+        public static readonly object NextPageTextKey;
+        public static readonly object PageLabelKey;
+        public static readonly object PreviousPageTextKey;
+        public PagerStyle();
+        public string NextPageText { get; set; }
+        public string PageLabel { get; set; }
+        public string PreviousPageText { get; set; }
+        public string GetNextPageText(int currentPageIndex);
+        public string GetPageLabelText(int currentPageIndex, int pageCount);
+        public string GetPreviousPageText(int currentPageIndex);
+    }
+    public class Panel : MobileControl, ITemplateable {
+        public Panel();
+        public override bool BreakAfter { get; set; }
+        public Panel Content { get; }
+        public virtual bool Paginate { get; set; }
+        protected override bool PaginateChildren { get; }
+        public override void AddLinkedForms(IList linkedForms);
+        public override void CreateDefaultTemplatedUI(bool doDataBind);
+        protected override void OnInit(EventArgs e);
+        public override void PaginateRecursive(ControlPager pager);
+    }
+    public class PanelControlBuilder : LiteralTextContainerControlBuilder {
+        public PanelControlBuilder();
+    }
+    public class PersistNameAttribute : Attribute {
+        public static readonly PersistNameAttribute Default;
+        public PersistNameAttribute(string name);
+        public string Name { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public override bool IsDefaultAttribute();
+    }
+    public class PhoneCall : TextControl, IPostBackEventHandler {
+        public PhoneCall();
+        public string AlternateFormat { get; set; }
+        public string AlternateUrl { get; set; }
+        public string PhoneNumber { get; set; }
+        public string SoftkeyLabel { get; set; }
+        public override void AddLinkedForms(IList linkedForms);
+        protected override void OnPreRender(EventArgs e);
+        protected void RaisePostBackEvent(string argument);
+        void System.Web.UI.IPostBackEventHandler.RaisePostBackEvent(string eventArgument);
+    }
+    public class RangeValidator : BaseValidator {
+        public RangeValidator();
+        public string MaximumValue { get; set; }
+        public string MinimumValue { get; set; }
+        public ValidationDataType Type { get; set; }
+        protected override bool ControlPropertiesValid();
+        protected override BaseValidator CreateWebValidator();
+        protected override bool EvaluateIsValid();
+    }
+    public class RegularExpressionValidator : BaseValidator {
+        public RegularExpressionValidator();
+        public string ValidationExpression { get; set; }
+        protected override BaseValidator CreateWebValidator();
+        protected override bool EvaluateIsValid();
+    }
+    public class RequiredFieldValidator : BaseValidator {
+        public RequiredFieldValidator();
+        public string InitialValue { get; set; }
+        protected override BaseValidator CreateWebValidator();
+        protected override bool EvaluateIsValid();
+    }
+    public class SelectionList : MobileControl, IPostBackDataHandler {
+        public SelectionList();
+        public virtual string DataMember { get; set; }
+        public virtual object DataSource { get; set; }
+        public string DataTextField { get; set; }
+        public string DataValueField { get; set; }
+        public bool IsMultiSelect { get; }
+        public MobileListItemCollection Items { get; }
+        public int Rows { get; set; }
+        public int SelectedIndex { get; set; }
+        public MobileListItem Selection { get; }
+        public ListSelectType SelectType { get; set; }
+        public string Title { get; set; }
+        public event ListDataBindEventHandler ItemDataBind;
+        public event EventHandler SelectedIndexChanged;
+        protected override void AddParsedSubObject(object obj);
+        protected virtual void CreateItems(IEnumerable dataSource);
+        protected bool LoadPostData(string postDataKey, NameValueCollection postCollection);
+        protected override void LoadViewState(object savedState);
+        protected override void OnDataBinding(EventArgs e);
+        protected virtual void OnItemDataBind(ListDataBindEventArgs e);
+        protected override void OnPreRender(EventArgs e);
+        protected virtual void OnSelectedIndexChanged(EventArgs e);
+        protected void RaisePostDataChangedEvent();
+        protected override object SaveViewState();
+        bool System.Web.UI.IPostBackDataHandler.LoadPostData(string key, NameValueCollection data);
+        void System.Web.UI.IPostBackDataHandler.RaisePostDataChangedEvent();
+        protected override void TrackViewState();
+    }
+    public class Style : ICloneable, IParserAccessor, IStateManager, ITemplateable {
+        public static readonly object AlignmentKey;
+        public static readonly object BackColorKey;
+        public static readonly object BoldKey;
+        public static readonly object FontNameKey;
+        public static readonly object FontSizeKey;
+        public static readonly object ForeColorKey;
+        public static readonly object ItalicKey;
+        public static readonly object WrappingKey;
+        public Style();
+        public Alignment Alignment { get; set; }
+        public Color BackColor { get; set; }
+        public MobileControl Control { get; }
+        public DeviceSpecific DeviceSpecific { get; set; }
+        public FontInfo Font { get; }
+        public Color ForeColor { get; set; }
+        public bool IsTemplated { get; }
+        protected bool IsTrackingViewState { get; }
+        public string Name { get; set; }
+        protected internal StateBag State { get; }
+        public virtual string StyleReference { get; set; }
+        bool System.Web.UI.IStateManager.IsTrackingViewState { get; }
+        public object this[object key, bool inherit] { get; }
+        public object this[object key] { get; set; }
+        public Wrapping Wrapping { get; set; }
+        protected void AddParsedSubObject(object o);
+        public void ApplyTo(WebControl control);
+        public object Clone();
+        public ITemplate GetTemplate(string templateName);
+        protected void LoadViewState(object state);
+        public static object RegisterStyle(string name, Type type, object defaultValue, bool inherit);
+        protected object SaveViewState();
+        void System.Web.UI.IParserAccessor.AddParsedSubObject(object o);
+        void System.Web.UI.IStateManager.LoadViewState(object state);
+        object System.Web.UI.IStateManager.SaveViewState();
+        void System.Web.UI.IStateManager.TrackViewState();
+        protected void TrackViewState();
+    }
+    public class StyleSheet : MobileControl {
+        public StyleSheet();
+        public override Alignment Alignment { get; set; }
+        public override Color BackColor { get; set; }
+        public override bool BreakAfter { get; set; }
+        public static StyleSheet Default { get; }
+        public override bool EnableViewState { get; set; }
+        public override FontInfo Font { get; }
+        public override Color ForeColor { get; set; }
+        public string ReferencePath { get; set; }
+        public override string StyleReference { get; set; }
+        public ICollection Styles { get; }
+        public Style this[string name] { get; set; }
+        public override bool Visible { get; set; }
+        public override Wrapping Wrapping { get; set; }
+        protected override void AddParsedSubObject(object o);
+        public void Clear();
+        protected override void LoadViewState(object savedState);
+        public void Remove(string name);
+        protected override object SaveViewState();
+        protected override void TrackViewState();
+    }
+    public class StyleSheetControlBuilder : MobileControlBuilder {
+        public StyleSheetControlBuilder();
+        public override Type GetChildControlType(string name, IDictionary attributes);
+    }
+    public class TemplateContainer : Panel, INamingContainer {
+        public TemplateContainer();
+        public override bool BreakAfter { get; set; }
+    }
+    public class TextBox : TextControl, IPostBackDataHandler {
+        public TextBox();
+        public int MaxLength { get; set; }
+        public bool Numeric { get; set; }
+        public bool Password { get; set; }
+        public int Size { get; set; }
+        public string Title { get; set; }
+        public event EventHandler TextChanged;
+        protected bool LoadPostData(string key, NameValueCollection data);
+        protected virtual void OnTextChanged(EventArgs e);
+        protected void RaisePostDataChangedEvent();
+        bool System.Web.UI.IPostBackDataHandler.LoadPostData(string key, NameValueCollection data);
+        void System.Web.UI.IPostBackDataHandler.RaisePostDataChangedEvent();
+    }
+    public class TextBoxControlBuilder : MobileControlBuilder {
+        public TextBoxControlBuilder();
+        public override bool AllowWhitespaceLiterals();
+    }
+    public abstract class TextControl : MobileControl {
+        protected TextControl();
+        public string Text { get; set; }
+    }
+    public class TextView : PagedControl {
+        public TextView();
+        public int FirstVisibleElementIndex { get; }
+        public int FirstVisibleElementOffset { get; }
+        protected override int InternalItemCount { get; }
+        public new int ItemCount { get; set; }
+        public new int ItemsPerPage { get; set; }
+        protected override int ItemWeight { get; }
+        public int LastVisibleElementIndex { get; }
+        public int LastVisibleElementOffset { get; }
+        public string Text { get; set; }
+        public new event LoadItemsEventHandler LoadItems;
+        public TextViewElement GetElement(int index);
+        protected override void OnRender(HtmlTextWriter writer);
+        public override void PaginateRecursive(ControlPager pager);
+    }
+    public class TextViewElement {
+        public bool BreakAfter { get; }
+        public bool IsBold { get; }
+        public bool IsItalic { get; }
+        public string Text { get; }
+        public string Url { get; }
+    }
+    public class ValidationSummary : MobileControl {
+        public ValidationSummary();
+        public string BackLabel { get; set; }
+        public string FormToValidate { get; set; }
+        public string HeaderText { get; set; }
+        public override string StyleReference { get; set; }
+        public string[] GetErrorMessages();
+        protected override void OnLoad(EventArgs e);
+    }
+    public enum Wrapping {
+        NotSet = 0,
+        NoWrap = 2,
+        Wrap = 1,
+    }
+}
```

