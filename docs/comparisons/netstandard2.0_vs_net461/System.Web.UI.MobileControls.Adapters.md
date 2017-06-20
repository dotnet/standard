# System.Web.UI.MobileControls.Adapters

``` diff
+namespace System.Web.UI.MobileControls.Adapters {
+    public class ChtmlCalendarAdapter : HtmlControlAdapter {
+        public ChtmlCalendarAdapter();
+        protected new Calendar Control { get; }
+        public override bool RequiresFormTag { get; }
+        public override bool HandlePostBackEvent(string eventArgument);
+        public override void LoadAdapterState(object state);
+        public override void OnInit(EventArgs e);
+        public override void OnLoad(EventArgs e);
+        public override void OnPreRender(EventArgs e);
+        public override void Render(HtmlMobileTextWriter writer);
+        public override object SaveAdapterState();
+    }
+    public class ChtmlCommandAdapter : HtmlCommandAdapter {
+        public ChtmlCommandAdapter();
+        public override bool RequiresFormTag { get; }
+        protected override void AddAttributes(HtmlMobileTextWriter writer);
+    }
+    public class ChtmlFormAdapter : HtmlFormAdapter {
+        public ChtmlFormAdapter();
+        protected override bool RenderExtraHeadElements(HtmlMobileTextWriter writer);
+        protected internal override void RenderPagerTag(HtmlMobileTextWriter writer, int pageToNavigate, string text);
+        protected override bool ShouldRenderFormTag();
+    }
+    public class ChtmlImageAdapter : HtmlImageAdapter {
+        public ChtmlImageAdapter();
+        protected override void AddAttributes(HtmlMobileTextWriter writer);
+        protected internal override void RenderImage(HtmlMobileTextWriter writer);
+    }
+    public class ChtmlLinkAdapter : HtmlLinkAdapter {
+        public ChtmlLinkAdapter();
+        protected override void AddAttributes(HtmlMobileTextWriter writer);
+    }
+    public class ChtmlMobileTextWriter : HtmlMobileTextWriter {
+        public ChtmlMobileTextWriter(TextWriter writer, MobileCapabilities device);
+    }
+    public class ChtmlPageAdapter : HtmlPageAdapter {
+        public ChtmlPageAdapter();
+        protected override string EventArgumentKey { get; }
+        protected override string EventSourceKey { get; }
+        public override HtmlTextWriter CreateTextWriter(TextWriter writer);
+        public override NameValueCollection DeterminePostBackMode(HttpRequest request, string postEventSourceID, string postEventArgumentID, NameValueCollection baseCollection);
+        public static new bool DeviceQualifies(HttpContext context);
+        public override void RenderPostBackEvent(HtmlMobileTextWriter writer, string target, string argument);
+        public override void RenderPostBackHeader(HtmlMobileTextWriter writer, Form form);
+    }
+    public class ChtmlPhoneCallAdapter : HtmlPhoneCallAdapter {
+        public ChtmlPhoneCallAdapter();
+        protected override void AddAttributes(HtmlMobileTextWriter writer);
+    }
+    public class ChtmlSelectionListAdapter : HtmlSelectionListAdapter {
+        public ChtmlSelectionListAdapter();
+        public override bool RequiresFormTag { get; }
+        public override void Render(HtmlMobileTextWriter writer);
+    }
+    public class ChtmlTextBoxAdapter : HtmlTextBoxAdapter {
+        public ChtmlTextBoxAdapter();
+        public override bool RequiresFormTag { get; }
+        protected override void AddAttributes(HtmlMobileTextWriter writer);
+    }
+    public abstract class ControlAdapter : IControlAdapter {
+        protected static readonly int BackLabel;
+        protected static readonly int CallLabel;
+        protected static readonly int GoLabel;
+        protected static readonly int LinkLabel;
+        protected static readonly int MoreLabel;
+        protected static readonly int NextLabel;
+        protected static readonly int OKLabel;
+        protected static readonly int OptionsLabel;
+        protected static readonly int PreviousLabel;
+        protected ControlAdapter();
+        public MobileControl Control { get; set; }
+        public virtual MobileCapabilities Device { get; }
+        public virtual int ItemWeight { get; }
+        public virtual MobilePage Page { get; set; }
+        public Style Style { get; }
+        public virtual int VisibleWeight { get; }
+        protected virtual int CalculateOptimumPageWeight(int defaultPageWeight);
+        public virtual void CreateTemplatedUI(bool doDataBind);
+        protected string GetDefaultLabel(int labelID);
+        public virtual bool HandlePostBackEvent(string eventArgument);
+        public virtual void LoadAdapterState(object state);
+        public virtual bool LoadPostData(string key, NameValueCollection data, object controlPrivateData, out bool dataChanged);
+        public virtual void OnInit(EventArgs e);
+        public virtual void OnLoad(EventArgs e);
+        public virtual void OnPreRender(EventArgs e);
+        public virtual void OnUnload(EventArgs e);
+        public virtual void Render(HtmlTextWriter writer);
+        protected void RenderChildren(HtmlTextWriter writer);
+        public virtual object SaveAdapterState();
+    }
+    public class HtmlCalendarAdapter : HtmlControlAdapter {
+        public HtmlCalendarAdapter();
+        protected new Calendar Control { get; }
+        public override void Render(HtmlMobileTextWriter writer);
+    }
+    public class HtmlCommandAdapter : HtmlControlAdapter {
+        public HtmlCommandAdapter();
+        protected new Command Control { get; }
+        public override bool LoadPostData(string key, NameValueCollection data, object controlPrivateData, out bool dataChanged);
+        public override void Render(HtmlMobileTextWriter writer);
+    }
+    public class HtmlControlAdapter : ControlAdapter {
+        protected static readonly int NotSecondaryUI;
+        public HtmlControlAdapter();
+        protected HtmlFormAdapter FormAdapter { get; }
+        protected HtmlPageAdapter PageAdapter { get; }
+        public virtual bool RequiresFormTag { get; }
+        protected int SecondaryUIMode { get; set; }
+        protected virtual void AddAccesskeyAttribute(HtmlMobileTextWriter writer);
+        protected virtual void AddAttributes(HtmlMobileTextWriter writer);
+        protected virtual void AddJPhoneMultiMediaAttributes(HtmlMobileTextWriter writer);
+        protected void ExitSecondaryUIMode();
+        public override void LoadAdapterState(object state);
+        public override void Render(HtmlTextWriter writer);
+        public virtual void Render(HtmlMobileTextWriter writer);
+        protected virtual void RenderAsHiddenInputField(HtmlMobileTextWriter writer);
+        protected void RenderBeginLink(HtmlMobileTextWriter writer, string target);
+        protected void RenderEndLink(HtmlMobileTextWriter writer);
+        protected void RenderPostBackEventAsAnchor(HtmlMobileTextWriter writer, string argument, string linkText);
+        protected void RenderPostBackEventAsAttribute(HtmlMobileTextWriter writer, string attributeName, string argument);
+        protected void RenderPostBackEventReference(HtmlMobileTextWriter writer, string argument);
+        public override object SaveAdapterState();
+    }
+    public class HtmlFormAdapter : HtmlControlAdapter {
+        public HtmlFormAdapter();
+        protected new Form Control { get; }
+        protected internal void DisablePager();
+        public override void Render(HtmlMobileTextWriter writer);
+        protected virtual void RenderBodyTag(HtmlMobileTextWriter writer, IDictionary attributes);
+        protected virtual bool RenderExtraHeadElements(HtmlMobileTextWriter writer);
+        protected virtual void RenderPager(HtmlMobileTextWriter writer);
+        protected internal virtual void RenderPagerTag(HtmlMobileTextWriter writer, int pageToNavigate, string text);
+        protected virtual bool ShouldRenderFormTag();
+    }
+    public class HtmlImageAdapter : HtmlControlAdapter {
+        public HtmlImageAdapter();
+        protected new Image Control { get; }
+        public override void Render(HtmlMobileTextWriter writer);
+        protected internal virtual void RenderImage(HtmlMobileTextWriter writer);
+    }
+    public class HtmlLabelAdapter : HtmlControlAdapter {
+        public HtmlLabelAdapter();
+        protected new TextControl Control { get; }
+        public override void Render(HtmlMobileTextWriter writer);
+        protected internal bool WhiteSpace(string s);
+    }
+    public class HtmlLinkAdapter : HtmlControlAdapter {
+        public HtmlLinkAdapter();
+        protected new Link Control { get; }
+        public override void Render(HtmlMobileTextWriter writer);
+    }
+    public class HtmlListAdapter : HtmlControlAdapter {
+        public HtmlListAdapter();
+        protected new List Control { get; }
+        public override void Render(HtmlMobileTextWriter writer);
+        protected virtual void RenderList(HtmlMobileTextWriter writer);
+    }
+    public class HtmlLiteralTextAdapter : HtmlControlAdapter {
+        public HtmlLiteralTextAdapter();
+        protected new LiteralText Control { get; }
+        public override void Render(HtmlMobileTextWriter writer);
+    }
+    public class HtmlMobileTextWriter : MobileTextWriter {
+        public HtmlMobileTextWriter(TextWriter writer, MobileCapabilities device);
+        protected internal bool RenderBodyColor { get; set; }
+        protected internal bool RenderBold { get; set; }
+        protected internal bool RenderDivAlign { get; set; }
+        protected internal bool RenderDivNoWrap { get; set; }
+        protected internal bool RenderFontColor { get; set; }
+        protected internal bool RenderFontName { get; set; }
+        protected internal bool RenderFontSize { get; set; }
+        protected internal bool RenderItalic { get; set; }
+        protected internal bool RequiresNoBreakInFormatting { get; set; }
+        public void BeginStyleContext();
+        public void EndStyleContext();
+        public override void EnterFormat(Style style);
+        public override void EnterLayout(Style style);
+        public new void EnterStyle(Style style);
+        public override void ExitFormat(Style style);
+        public override void ExitFormat(Style style, bool breakAfter);
+        public override void ExitLayout(Style style);
+        public override void ExitLayout(Style style, bool breakAfter);
+        public new void ExitStyle(Style style);
+        public void ExitStyle(Style style, bool breakAfter);
+        protected internal void MarkStyleContext();
+        protected internal void UnMarkStyleContext();
+        public override void Write(char c);
+        public override void Write(string text);
+        public override void WriteBeginTag(string tag);
+        public new void WriteBreak();
+        public override void WriteEncodedText(string text);
+        public override void WriteFullBeginTag(string tag);
+        public void WriteHiddenField(string name, string value);
+        public override void WriteLine(string text);
+        public void WriteText(string text, bool encodeText);
+        public void WriteUrlParameter(string name, string value);
+    }
+    public class HtmlObjectListAdapter : HtmlControlAdapter {
+        protected internal static readonly string BackToList;
+        protected internal static readonly string ShowMore;
+        protected internal static readonly string ShowMoreFormat;
+        public HtmlObjectListAdapter();
+        protected new ObjectList Control { get; }
+        public override void CreateTemplatedUI(bool doDataBind);
+        public override bool HandlePostBackEvent(string eventArgument);
+        protected bool HasCommands();
+        protected bool HasDefaultCommand();
+        protected bool HasItemDetails();
+        public override void OnInit(EventArgs e);
+        protected bool OnlyHasDefaultCommand();
+        public override void OnPreRender(EventArgs e);
+        public override void Render(HtmlMobileTextWriter writer);
+        protected virtual void RenderItemDetails(HtmlMobileTextWriter writer, ObjectListItem item);
+        protected virtual void RenderItemsList(HtmlMobileTextWriter writer);
+        protected virtual bool ShouldRenderAsTable();
+    }
+    public class HtmlPageAdapter : HtmlControlAdapter, IControlAdapter, IPageAdapter {
+        public HtmlPageAdapter();
+        protected internal HtmlPageAdapter(int defaultPageWeight);
+        public virtual IList CacheVaryByHeaders { get; }
+        public IDictionary CookielessDataDictionary { get; set; }
+        protected virtual string EventArgumentKey { get; }
+        protected virtual string EventSourceKey { get; }
+        public virtual int OptimumPageWeight { get; }
+        public override MobilePage Page { get; set; }
+        public bool PersistCookielessData { get; set; }
+        public virtual HtmlTextWriter CreateTextWriter(TextWriter writer);
+        public virtual NameValueCollection DeterminePostBackMode(HttpRequest request, string postEventSourceID, string postEventArgumentID, NameValueCollection baseCollection);
+        public static bool DeviceQualifies(HttpContext context);
+        public string GetFormUrl(Form form);
+        public virtual bool HandleError(Exception e, HtmlTextWriter writer);
+        public virtual bool HandlePagePostBackEvent(string eventSource, string eventArgument);
+        public virtual bool IsFormRendered(Form form);
+        public override void Render(HtmlMobileTextWriter writer);
+        public virtual void RenderForm(HtmlMobileTextWriter writer, Form form);
+        protected void RenderHiddenVariables(HtmlMobileTextWriter writer);
+        public virtual void RenderPostBackEvent(HtmlMobileTextWriter writer, string target, string argument);
+        public virtual void RenderPostBackHeader(HtmlMobileTextWriter writer, Form form);
+        public virtual void RenderUrlPostBackEvent(HtmlMobileTextWriter writer, string target, string argument);
+    }
+    public class HtmlPanelAdapter : HtmlControlAdapter {
+        public HtmlPanelAdapter();
+        protected new Panel Control { get; }
+        public override void OnInit(EventArgs e);
+        public override void Render(HtmlMobileTextWriter writer);
+    }
+    public class HtmlPhoneCallAdapter : HtmlControlAdapter {
+        public HtmlPhoneCallAdapter();
+        protected new PhoneCall Control { get; }
+        public override void Render(HtmlMobileTextWriter writer);
+    }
+    public class HtmlSelectionListAdapter : HtmlControlAdapter {
+        public HtmlSelectionListAdapter();
+        protected new SelectionList Control { get; }
+        public override bool LoadPostData(string key, NameValueCollection data, object controlPrivateData, out bool dataChanged);
+        public override void OnInit(EventArgs e);
+        public override void Render(HtmlMobileTextWriter writer);
+        protected override void RenderAsHiddenInputField(HtmlMobileTextWriter writer);
+    }
+    public class HtmlTextBoxAdapter : HtmlControlAdapter {
+        public HtmlTextBoxAdapter();
+        protected new TextBox Control { get; }
+        public override void OnInit(EventArgs e);
+        public override void Render(HtmlMobileTextWriter writer);
+        protected override void RenderAsHiddenInputField(HtmlMobileTextWriter writer);
+    }
+    public class HtmlTextViewAdapter : HtmlControlAdapter {
+        public HtmlTextViewAdapter();
+        protected new TextView Control { get; }
+        public override void Render(HtmlMobileTextWriter writer);
+    }
+    public class HtmlValidationSummaryAdapter : HtmlControlAdapter {
+        public HtmlValidationSummaryAdapter();
+        protected new ValidationSummary Control { get; }
+        public override void OnInit(EventArgs e);
+        public override void Render(HtmlMobileTextWriter writer);
+    }
+    public class HtmlValidatorAdapter : HtmlControlAdapter {
+        public HtmlValidatorAdapter();
+        protected new BaseValidator Control { get; }
+        public override void Render(HtmlMobileTextWriter writer);
+    }
+    public class MobileTextWriter : MultiPartWriter {
+        public MobileTextWriter(TextWriter writer, MobileCapabilities device);
+        public MobileCapabilities Device { get; }
+        public override bool SupportsMultiPart { get; }
+        public override void AddResource(string url, string contentType);
+        public override void BeginFile(string url, string contentType, string charset);
+        public override void BeginResponse();
+        public override void EndFile();
+        public override void EndResponse();
+        public virtual void EnterFormat(Style style);
+        public virtual void EnterLayout(Style style);
+        public void EnterStyle(Style style);
+        public virtual void ExitFormat(Style style);
+        public virtual void ExitFormat(Style style, bool breakAfter);
+        public virtual void ExitLayout(Style style);
+        public virtual void ExitLayout(Style style, bool breakAfter);
+        public void ExitStyle(Style style);
+    }
+    public abstract class MultiPartWriter : HtmlTextWriter {
+        protected MultiPartWriter(TextWriter writer);
+        public virtual bool SupportsMultiPart { get; }
+        public void AddResource(string url);
+        public abstract void AddResource(string url, string contentType);
+        public abstract void BeginFile(string url, string contentType, string charset);
+        public abstract void BeginResponse();
+        public abstract void EndFile();
+        public abstract void EndResponse();
+        public virtual string NewUrl(string filetype);
+    }
+    public class SR {
+        public const string CalendarAdapterFirstPrompt = "CalendarAdapterFirstPrompt";
+        public const string CalendarAdapterOptionChooseDate = "CalendarAdapterOptionChooseDate";
+        public const string CalendarAdapterOptionChooseMonth = "CalendarAdapterOptionChooseMonth";
+        public const string CalendarAdapterOptionChooseWeek = "CalendarAdapterOptionChooseWeek";
+        public const string CalendarAdapterOptionEra = "CalendarAdapterOptionEra";
+        public const string CalendarAdapterOptionPrompt = "CalendarAdapterOptionPrompt";
+        public const string CalendarAdapterOptionType = "CalendarAdapterOptionType";
+        public const string CalendarAdapterTextBoxErrorMessage = "CalendarAdapterTextBoxErrorMessage";
+        public const string ChtmlImageAdapterDecimalCodeExpectedAfterGroupChar = "ChtmlImageAdapterDecimalCodeExpectedAfterGroupChar";
+        public const string ChtmlPageAdapterRedirectLinkLabel = "ChtmlPageAdapterRedirectLinkLabel";
+        public const string ChtmlPageAdapterRedirectPageContent = "ChtmlPageAdapterRedirectPageContent";
+        public const string ControlAdapterBasePagePropertyShouldNotBeSet = "ControlAdapterBasePagePropertyShouldNotBeSet";
+        public const string FormAdapterMultiControlsAttemptSecondaryUI = "FormAdapterMultiControlsAttemptSecondaryUI";
+        public const string MobileTextWriterNotMultiPart = "MobileTextWriterNotMultiPart";
+        public const string ObjectListAdapter_InvalidPostedData = "ObjectListAdapter_InvalidPostedData";
+        public const string WmlMobileTextWriterBackLabel = "WmlMobileTextWriterBackLabel";
+        public const string WmlMobileTextWriterGoLabel = "WmlMobileTextWriterGoLabel";
+        public const string WmlMobileTextWriterOKLabel = "WmlMobileTextWriterOKLabel";
+        public const string WmlObjectListAdapterDetails = "WmlObjectListAdapterDetails";
+        public const string WmlPageAdapterMethod = "WmlPageAdapterMethod";
+        public const string WmlPageAdapterPartialStackTrace = "WmlPageAdapterPartialStackTrace";
+        public const string WmlPageAdapterServerError = "WmlPageAdapterServerError";
+        public const string WmlPageAdapterStackTrace = "WmlPageAdapterStackTrace";
+        public const string XhtmlCssHandler_IdNotPresent = "XhtmlCssHandler_IdNotPresent";
+        public const string XhtmlCssHandler_StylesheetNotFound = "XhtmlCssHandler_StylesheetNotFound";
+        public const string XhtmlMobileTextWriter_CacheKeyNotSet = "XhtmlMobileTextWriter_CacheKeyNotSet";
+        public const string XhtmlMobileTextWriter_SessionKeyNotSet = "XhtmlMobileTextWriter_SessionKeyNotSet";
+        public const string XhtmlObjectListAdapter_InvalidPostedData = "XhtmlObjectListAdapter_InvalidPostedData";
+        public SR();
+        public static bool GetBoolean(CultureInfo culture, string name);
+        public static bool GetBoolean(string name);
+        public static byte GetByte(CultureInfo culture, string name);
+        public static byte GetByte(string name);
+        public static char GetChar(CultureInfo culture, string name);
+        public static char GetChar(string name);
+        public static double GetDouble(CultureInfo culture, string name);
+        public static double GetDouble(string name);
+        public static float GetFloat(CultureInfo culture, string name);
+        public static float GetFloat(string name);
+        public static int GetInt(CultureInfo culture, string name);
+        public static int GetInt(string name);
+        public static long GetLong(CultureInfo culture, string name);
+        public static long GetLong(string name);
+        public static object GetObject(CultureInfo culture, string name);
+        public static object GetObject(string name);
+        public static short GetShort(CultureInfo culture, string name);
+        public static short GetShort(string name);
+        public static string GetString(CultureInfo culture, string name);
+        public static string GetString(CultureInfo culture, string name, params object[] args);
+        public static string GetString(string name);
+        public static string GetString(string name, params object[] args);
+    }
+    public class UpWmlMobileTextWriter : WmlMobileTextWriter {
+        public UpWmlMobileTextWriter(TextWriter writer, MobileCapabilities device, MobilePage page);
+        protected override void AnalyzePostBack(bool includeVariables, WmlPostFieldType postBackType);
+        public override void BeginCustomMarkup();
+        public override void BeginForm(Form form);
+        protected override string CalculateFormPostBackUrl(bool externalSubmit, ref bool encode);
+        protected override string CalculateFormQueryString();
+        public override void EndForm();
+        protected override void OpenParagraph(WmlMobileTextWriter.WmlLayout layout, bool writeAlignment, bool writeWrapping);
+        protected override void PostAnalyzeForm();
+        public override void RenderBeginHyperlink(string targetUrl, bool encodeUrl, string softkeyLabel, bool implicitSoftkeyLabel, bool mapToSoftkey);
+        public override void RenderBeginPostBack(string softkeyLabel, bool implicitSoftkeyLabel, bool mapToSoftkey);
+        public override void RenderBeginSelect(string name, string iname, string ivalue, string title, bool multiSelect);
+        protected override void RenderEndForm();
+        public override void RenderEndHyperlink(bool breakAfter);
+        public override void RenderEndPostBack(string target, string argument, WmlPostFieldType postBackType, bool includeVariables, bool breakAfter);
+        public override void RenderEndSelect(bool breakAfter);
+        public override void RenderImage(string source, string localSource, string alternateText, bool breakAfter);
+        public override void RenderSelectOption(string text);
+        public override void RenderSelectOption(string text, string value);
+        public override void RenderText(string text, bool breakAfter, bool encodeText);
+        public override void RenderTextBox(string id, string value, string format, string title, bool password, int size, int maxLength, bool generateRandomID, bool breakAfter);
+    }
+    public class UpWmlPageAdapter : WmlPageAdapter {
+        public UpWmlPageAdapter();
+        public override HtmlTextWriter CreateTextWriter(TextWriter writer);
+        public static new bool DeviceQualifies(HttpContext context);
+    }
+    public class WmlCalendarAdapter : WmlControlAdapter {
+        public WmlCalendarAdapter();
+        protected new Calendar Control { get; }
+        public override bool HandlePostBackEvent(string eventArgument);
+        public override void LoadAdapterState(object state);
+        public override void OnInit(EventArgs e);
+        public override void OnLoad(EventArgs e);
+        public override void OnPreRender(EventArgs e);
+        public override void Render(WmlMobileTextWriter writer);
+        public override object SaveAdapterState();
+    }
+    public class WmlCommandAdapter : WmlControlAdapter {
+        public WmlCommandAdapter();
+        protected new Command Control { get; }
+        public override void Render(WmlMobileTextWriter writer);
+    }
+    public class WmlControlAdapter : ControlAdapter {
+        protected static readonly int NotSecondaryUI;
+        public WmlControlAdapter();
+        protected WmlFormAdapter FormAdapter { get; }
+        protected WmlPageAdapter PageAdapter { get; }
+        protected int SecondaryUIMode { get; set; }
+        protected string DeterminePostBack(string target);
+        protected void ExitSecondaryUIMode();
+        protected virtual string GetPostBackValue();
+        public override void LoadAdapterState(object state);
+        public override void Render(HtmlTextWriter writer);
+        public virtual void Render(WmlMobileTextWriter writer);
+        protected void RenderBeginLink(WmlMobileTextWriter writer, string targetUrl, string softkeyLabel, bool implicitSoftkeyLabel, bool mapToSoftkey);
+        protected void RenderEndLink(WmlMobileTextWriter writer, string targetUrl, bool breakAfter);
+        protected void RenderLink(WmlMobileTextWriter writer, string targetUrl, string softkeyLabel, bool implicitSoftkeyLabel, bool mapToSoftkey, string text, bool breakAfter);
+        protected void RenderPostBackEvent(WmlMobileTextWriter writer, string argument, string softkeyLabel, bool mapToSoftkey, string text, bool breakAfter);
+        protected void RenderPostBackEvent(WmlMobileTextWriter writer, string argument, string softkeyLabel, bool mapToSoftkey, string text, bool breakAfter, WmlPostFieldType postBackType);
+        protected void RenderSubmitEvent(WmlMobileTextWriter writer, string softkeyLabel, string text, bool breakAfter);
+        public override object SaveAdapterState();
+    }
+    public class WmlFormAdapter : WmlControlAdapter {
+        public WmlFormAdapter();
+        protected new Form Control { get; }
+        public virtual IDictionary CalculatePostBackVariables();
+        public override bool HandlePostBackEvent(string eventArgument);
+        public override void Render(WmlMobileTextWriter writer);
+        protected internal virtual void RenderCardTag(WmlMobileTextWriter writer, IDictionary attributes);
+        protected internal virtual void RenderExtraCardElements(WmlMobileTextWriter writer);
+        protected virtual void RenderPager(WmlMobileTextWriter writer);
+    }
+    public class WmlImageAdapter : WmlControlAdapter {
+        public WmlImageAdapter();
+        protected new Image Control { get; }
+        public override void Render(WmlMobileTextWriter writer);
+    }
+    public class WmlLabelAdapter : WmlControlAdapter {
+        public WmlLabelAdapter();
+        protected new TextControl Control { get; }
+        public override void Render(WmlMobileTextWriter writer);
+    }
+    public class WmlLinkAdapter : WmlControlAdapter {
+        public WmlLinkAdapter();
+        protected new Link Control { get; }
+        public override void Render(WmlMobileTextWriter writer);
+    }
+    public class WmlListAdapter : WmlControlAdapter {
+        public WmlListAdapter();
+        protected new List Control { get; }
+        public override void OnInit(EventArgs e);
+        public override void Render(WmlMobileTextWriter writer);
+    }
+    public class WmlLiteralTextAdapter : WmlControlAdapter {
+        public WmlLiteralTextAdapter();
+        protected new LiteralText Control { get; }
+        public override void Render(WmlMobileTextWriter writer);
+    }
+    public class WmlMobileTextWriter : MobileTextWriter {
+        public WmlMobileTextWriter(TextWriter writer, MobileCapabilities device, MobilePage page);
+        public bool AnalyzeMode { get; set; }
+        protected Form CurrentForm { get; }
+        protected virtual WmlMobileTextWriter.WmlFormat DefaultFormat { get; }
+        protected virtual WmlMobileTextWriter.WmlLayout DefaultLayout { get; }
+        protected int NumberOfSoftkeys { get; }
+        protected MobilePage Page { get; }
+        protected bool PendingBreak { get; set; }
+        public void AddFormVariable(string clientID, string value, bool generateRandomID);
+        protected virtual void AnalyzePostBack(bool includeVariables, WmlPostFieldType postBackType);
+        public virtual void BeginCustomMarkup();
+        public virtual void BeginForm(Form form);
+        protected virtual string CalculateFormPostBackUrl(bool externalSubmit, ref bool encode);
+        protected virtual string CalculateFormQueryString();
+        protected virtual void CloseCharacterFormat();
+        protected virtual void CloseParagraph();
+        public virtual void EndCustomMarkup();
+        public virtual void EndForm();
+        protected virtual void EnsureFormat();
+        protected virtual void EnsureLayout();
+        public override void EnterFormat(Style style);
+        public override void EnterLayout(Style style);
+        public override void ExitFormat(Style style);
+        public override void ExitLayout(Style style, bool breakAfter);
+        public virtual bool IsValidSoftkeyLabel(string label);
+        protected internal string MapClientIDToShortName(string clientID, bool generateRandomID);
+        protected virtual void OpenCharacterFormat(WmlMobileTextWriter.WmlFormat format, bool writeBold, bool writeItalic, bool writeSize);
+        protected virtual void OpenParagraph(WmlMobileTextWriter.WmlLayout layout, bool writeAlignment, bool writeWrapping);
+        protected virtual void PostAnalyzeForm();
+        protected virtual void RenderBeginForm(Form form);
+        public virtual void RenderBeginHyperlink(string targetUrl, bool encodeUrl, string softkeyLabel, bool implicitSoftkeyLabel, bool mapToSoftkey);
+        public virtual void RenderBeginPostBack(string softkeyLabel, bool implicitSoftkeyLabel, bool mapToSoftkey);
+        public virtual void RenderBeginSelect(string name, string iname, string ivalue, string title, bool multiSelect);
+        protected void RenderDoEvent(string doType, string target, string arg, WmlPostFieldType postBackType, string text, bool includeVariables);
+        protected virtual void RenderEndForm();
+        public virtual void RenderEndHyperlink(bool breakAfter);
+        public virtual void RenderEndPostBack(string target, string argument, WmlPostFieldType postBackType, bool includeVariables, bool breakAfter);
+        public virtual void RenderEndSelect(bool breakAfter);
+        public virtual void RenderExtraCards();
+        protected void RenderFormDoEvent(string doType, string arg, WmlPostFieldType postBackType, string text);
+        public virtual void RenderGoAction(string target, string argument, WmlPostFieldType postBackType, bool includeVariables);
+        public virtual void RenderImage(string source, string localSource, string alternateText, bool breakAfter);
+        public virtual void RenderSelectOption(string text);
+        public virtual void RenderSelectOption(string text, string value);
+        public void RenderText(string text);
+        public void RenderText(string text, bool breakAfter);
+        public virtual void RenderText(string text, bool breakAfter, bool encodeText);
+        public virtual void RenderTextBox(string id, string value, string format, string title, bool password, int size, int maxLength, bool generateRandomID, bool breakAfter);
+        public virtual void ResetFormattingState();
+        protected virtual bool UsePostBackCard(bool includeVariables);
+        public override void WriteAttribute(string attribute, string value, bool encode);
+        protected new void WriteBreak();
+        public override void WriteEncodedText(string text);
+        public override void WriteEncodedUrl(string url);
+        public void WritePostField(string name, string value);
+        public void WritePostField(string name, string value, WmlPostFieldType type);
+        public void WritePostFieldVariable(string name, string arg);
+        public void WriteText(string text, bool encodeText);
+        protected void WriteTextEncodedAttribute(string attribute, string value);
+        protected class WmlFormat {
+            public WmlFormat(bool bold, bool italic, FontSize size);
+            public WmlFormat(Style style, WmlMobileTextWriter.WmlFormat currentFormat);
+            public bool Bold { get; set; }
+            public bool Italic { get; set; }
+            public FontSize Size { get; set; }
+            public bool WrittenBold { get; set; }
+            public bool WrittenItalic { get; set; }
+            public bool WrittenSize { get; set; }
+            public virtual bool Compare(WmlMobileTextWriter.WmlFormat format);
+        }
+        protected class WmlLayout {
+            public WmlLayout(Alignment alignment, Wrapping wrapping);
+            public WmlLayout(Style style, WmlMobileTextWriter.WmlLayout currentLayout);
+            public Alignment Align { get; set; }
+            public Wrapping Wrap { get; set; }
+            public virtual bool Compare(WmlMobileTextWriter.WmlLayout layout);
+        }
+    }
+    public class WmlObjectListAdapter : WmlControlAdapter {
+        public WmlObjectListAdapter();
+        protected new ObjectList Control { get; }
+        public override void CreateTemplatedUI(bool doDataBind);
+        public override bool HandlePostBackEvent(string eventArgument);
+        protected bool HasCommands();
+        protected bool HasDefaultCommand();
+        protected bool HasItemDetails();
+        protected bool OnlyHasDefaultCommand();
+        public override void OnPreRender(EventArgs e);
+        public override void Render(WmlMobileTextWriter writer);
+        protected virtual void RenderItemDetails(WmlMobileTextWriter writer, ObjectListItem item);
+        protected virtual void RenderItemMenu(WmlMobileTextWriter writer, ObjectListItem item);
+        protected virtual void RenderItemsList(WmlMobileTextWriter writer);
+        protected virtual bool ShouldRenderAsTable();
+    }
+    public class WmlPageAdapter : WmlControlAdapter, IControlAdapter, IPageAdapter {
+        public WmlPageAdapter();
+        public virtual IList CacheVaryByHeaders { get; }
+        public IDictionary CookielessDataDictionary { get; set; }
+        public virtual int OptimumPageWeight { get; }
+        public override MobilePage Page { get; set; }
+        public bool PersistCookielessData { get; set; }
+        public virtual HtmlTextWriter CreateTextWriter(TextWriter writer);
+        public virtual NameValueCollection DeterminePostBackMode(HttpRequest request, string postEventSourceID, string postEventArgumentID, NameValueCollection baseCollection);
+        public static bool DeviceQualifies(HttpContext context);
+        public virtual bool HandleError(Exception e, HtmlTextWriter writer);
+        public virtual bool HandlePagePostBackEvent(string eventSource, string eventArgument);
+        public virtual bool IsFormRendered(Form form);
+        public override void Render(WmlMobileTextWriter writer);
+        protected virtual void RenderForm(WmlMobileTextWriter writer, Form form);
+        public virtual bool RendersMultipleForms();
+    }
+    public class WmlPanelAdapter : WmlControlAdapter {
+        public WmlPanelAdapter();
+        protected new Panel Control { get; }
+        public override void Render(WmlMobileTextWriter writer);
+    }
+    public class WmlPhoneCallAdapter : WmlControlAdapter {
+        public WmlPhoneCallAdapter();
+        protected new PhoneCall Control { get; }
+        public override void Render(WmlMobileTextWriter writer);
+    }
+    public enum WmlPostFieldType {
+        Normal = 0,
+        Raw = 3,
+        Submit = 1,
+        Variable = 2,
+    }
+    public class WmlSelectionListAdapter : WmlControlAdapter {
+        public WmlSelectionListAdapter();
+        protected new SelectionList Control { get; }
+        protected override string GetPostBackValue();
+        public override bool LoadPostData(string key, NameValueCollection data, object controlPrivateData, out bool dataChanged);
+        public override void OnInit(EventArgs e);
+        public override void OnPreRender(EventArgs e);
+        public override void Render(WmlMobileTextWriter writer);
+    }
+    public class WmlTextBoxAdapter : WmlControlAdapter {
+        public WmlTextBoxAdapter();
+        protected new TextBox Control { get; }
+        protected override string GetPostBackValue();
+        public override void OnInit(EventArgs e);
+        public override void Render(WmlMobileTextWriter writer);
+    }
+    public class WmlTextViewAdapter : WmlControlAdapter {
+        public WmlTextViewAdapter();
+        protected new TextView Control { get; }
+        public override void Render(WmlMobileTextWriter writer);
+    }
+    public class WmlValidationSummaryAdapter : WmlControlAdapter {
+        public WmlValidationSummaryAdapter();
+        protected new ValidationSummary Control { get; }
+        public override void OnInit(EventArgs e);
+        public override void Render(WmlMobileTextWriter writer);
+    }
+    public class WmlValidatorAdapter : WmlControlAdapter {
+        public WmlValidatorAdapter();
+        protected new BaseValidator Control { get; }
+        public override void Render(WmlMobileTextWriter writer);
+    }
+}
```

