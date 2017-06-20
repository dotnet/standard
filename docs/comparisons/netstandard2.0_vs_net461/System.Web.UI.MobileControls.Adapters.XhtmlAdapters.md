# System.Web.UI.MobileControls.Adapters.XhtmlAdapters

``` diff
+namespace System.Web.UI.MobileControls.Adapters.XhtmlAdapters {
+    public enum Doctype {
+        NotSet = 0,
+        Wml20 = 3,
+        XhtmlBasic = 1,
+        XhtmlMobileProfile = 2,
+    }
+    public enum StyleSheetLocation {
+        ApplicationCache = 1,
+        Internal = 4,
+        None = 5,
+        NotSet = 0,
+        PhysicalFile = 3,
+        SessionState = 2,
+    }
+    public class XhtmlCalendarAdapter : XhtmlControlAdapter {
+        public XhtmlCalendarAdapter();
+        protected new Calendar Control { get; }
+        public override bool HandlePostBackEvent(string eventArgument);
+        public override void LoadAdapterState(object state);
+        public override void OnInit(EventArgs e);
+        public override void OnLoad(EventArgs e);
+        public override void OnPreRender(EventArgs e);
+        public override void Render(XhtmlMobileTextWriter writer);
+        public override object SaveAdapterState();
+    }
+    public class XhtmlCommandAdapter : XhtmlControlAdapter {
+        public XhtmlCommandAdapter();
+        protected new Command Control { get; }
+        public override bool LoadPostData(string key, NameValueCollection data, object controlPrivateData, out bool dataChanged);
+        public override void Render(XhtmlMobileTextWriter writer);
+    }
+    public class XhtmlControlAdapter : ControlAdapter {
+        protected static readonly int NotSecondaryUI;
+        public XhtmlControlAdapter();
+        protected virtual StyleSheetLocation CssLocation { get; }
+        protected virtual Doctype DocumentType { get; }
+        protected XhtmlPageAdapter PageAdapter { get; }
+        protected virtual int SecondaryUIMode { get; set; }
+        protected virtual string StyleSheetLocationAttributeValue { get; }
+        protected virtual string StyleSheetStorageApplicationSetting { get; }
+        protected virtual void ClearPendingBreakIfDeviceBreaksOnBlockLevel(XhtmlMobileTextWriter writer);
+        protected virtual void ConditionalClearCachedEndTag(XhtmlMobileTextWriter writer, string s);
+        protected virtual void ConditionalClearPendingBreak(XhtmlMobileTextWriter writer);
+        protected virtual void ConditionalEnterFormat(XhtmlMobileTextWriter writer, Style style);
+        protected virtual void ConditionalEnterLayout(XhtmlMobileTextWriter writer, Style style);
+        protected virtual void ConditionalEnterStyle(XhtmlMobileTextWriter writer, Style style);
+        protected virtual void ConditionalEnterStyle(XhtmlMobileTextWriter writer, Style style, string tag);
+        protected virtual void ConditionalExitFormat(XhtmlMobileTextWriter writer, Style style);
+        protected virtual void ConditionalExitLayout(XhtmlMobileTextWriter writer, Style style);
+        protected virtual void ConditionalExitStyle(XhtmlMobileTextWriter writer, Style style);
+        protected virtual void ConditionalPopPhysicalCssClass(XhtmlMobileTextWriter writer);
+        protected virtual void ConditionalRenderClassAttribute(XhtmlMobileTextWriter writer);
+        protected virtual void ConditionalRenderClosingDivElement(XhtmlMobileTextWriter writer);
+        protected virtual void ConditionalRenderClosingSpanElement(XhtmlMobileTextWriter writer);
+        protected virtual void ConditionalRenderCustomAttribute(XhtmlMobileTextWriter writer, string attributeName);
+        protected virtual void ConditionalRenderCustomAttribute(XhtmlMobileTextWriter writer, string attributeName, string markupAttributeName);
+        protected virtual void ConditionalRenderOpeningDivElement(XhtmlMobileTextWriter writer);
+        protected virtual void ConditionalRenderOpeningSpanElement(XhtmlMobileTextWriter writer);
+        protected virtual void ConditionalSetPendingBreak(XhtmlMobileTextWriter writer);
+        protected virtual void ConditionalSetPendingBreakAfterInline(XhtmlMobileTextWriter writer);
+        protected virtual void ExitSecondaryUIMode();
+        protected virtual string GetCustomAttributeValue(string attributeName);
+        protected virtual string GetCustomAttributeValue(MobileControl control, string attributeName);
+        public override void LoadAdapterState(object state);
+        protected string PreprocessQueryString(string queryString);
+        public override void Render(HtmlTextWriter writer);
+        public virtual void Render(XhtmlMobileTextWriter writer);
+        protected virtual void RenderAsHiddenInputField(XhtmlMobileTextWriter writer);
+        protected virtual void RenderBeginLink(XhtmlMobileTextWriter writer, string target);
+        protected virtual void RenderBeginLink(XhtmlMobileTextWriter writer, string target, string accessKey, Style style, string cssClass);
+        protected virtual void RenderBeginLink(XhtmlMobileTextWriter writer, string target, string accessKey, Style style, string cssClass, string title);
+        protected virtual void RenderClosingListTag(XhtmlMobileTextWriter writer, string tagName);
+        protected virtual void RenderEndLink(XhtmlMobileTextWriter writer);
+        protected void RenderOffPageVariables(XhtmlMobileTextWriter writer, Control control, int page);
+        protected virtual void RenderOpeningListTag(XhtmlMobileTextWriter writer, string tagName);
+        protected virtual void RenderPostBackEventAsAnchor(XhtmlMobileTextWriter writer, string argument, string linkText);
+        protected virtual void RenderPostBackEventAsAnchor(XhtmlMobileTextWriter writer, string argument, string linkText, string accessKey);
+        protected virtual void RenderPostBackEventAsAnchor(XhtmlMobileTextWriter writer, string argument, string linkText, string accessKey, Style style, string cssClass);
+        public override object SaveAdapterState();
+    }
+    public class XhtmlCssHandler : IHttpHandler, IRequiresSessionState {
+        public XhtmlCssHandler();
+        public bool IsReusable { get; }
+        public void ProcessRequest(HttpContext context);
+    }
+    public class XhtmlFormAdapter : XhtmlControlAdapter {
+        public XhtmlFormAdapter();
+        public new Form Control { get; }
+        public override void Render(XhtmlMobileTextWriter writer);
+        protected virtual void RenderPager(XhtmlMobileTextWriter writer);
+        protected virtual void RenderPagerTag(XhtmlMobileTextWriter writer, int pageToNavigate, string text, string accessKeyCustomAttribute);
+    }
+    public class XhtmlImageAdapter : XhtmlControlAdapter {
+        public XhtmlImageAdapter();
+        protected new Image Control { get; }
+        public override void Render(XhtmlMobileTextWriter writer);
+        protected virtual void RenderImage(XhtmlMobileTextWriter writer);
+    }
+    public class XhtmlLabelAdapter : XhtmlControlAdapter {
+        public XhtmlLabelAdapter();
+        public new Label Control { get; }
+        public override void Render(XhtmlMobileTextWriter writer);
+    }
+    public class XhtmlLinkAdapter : XhtmlControlAdapter {
+        public XhtmlLinkAdapter();
+        protected new Link Control { get; }
+        public override void Render(XhtmlMobileTextWriter writer);
+    }
+    public class XhtmlListAdapter : XhtmlControlAdapter {
+        public XhtmlListAdapter();
+        protected new List Control { get; }
+        public override void Render(XhtmlMobileTextWriter writer);
+        protected virtual void RenderList(XhtmlMobileTextWriter writer);
+    }
+    public class XhtmlLiteralTextAdapter : XhtmlControlAdapter {
+        public XhtmlLiteralTextAdapter();
+        protected new LiteralText Control { get; }
+        public override void Render(XhtmlMobileTextWriter writer);
+    }
+    public class XhtmlMobileTextWriter : MobileTextWriter {
+        public XhtmlMobileTextWriter(TextWriter writer, MobileCapabilities device);
+        public virtual string CacheKey { get; }
+        public string CustomBodyStyles { get; set; }
+        public virtual string SessionKey { get; }
+        public virtual bool SupportsNoWrapStyle { get; set; }
+        public bool SuppressNewLine { get; set; }
+        public bool UseDivsForBreaks { get; set; }
+        public virtual void AddOnEnterForwardSetVar(string var);
+        public virtual void AddOnEnterForwardSetVar(string var, string value);
+        public virtual void BeginCachedRendering();
+        public virtual void ClearPendingBreak();
+        public virtual void EndCachedRendering();
+        public override void EnterFormat(Style style);
+        public override void EnterLayout(Style style);
+        public new void EnterStyle(Style style);
+        public override void ExitFormat(Style style);
+        public override void ExitFormat(Style style, bool breakafter);
+        public override void ExitLayout(Style style);
+        public override void ExitLayout(Style style, bool breakafter);
+        public new void ExitStyle(Style style);
+        public virtual bool IsStyleSheetEmpty();
+        public virtual void MarkWmlOnEventLocation();
+        public virtual void SetBodyStyle(Style style);
+        public virtual void SetCacheKey(Cache cache);
+        public virtual void SetPendingBreak();
+        public virtual void SetSessionKey(HttpSessionState session);
+        public override void WriteAttribute(string attribute, string value, bool encode);
+        public override void WriteBeginTag(string tag);
+        public virtual new void WriteBreak();
+        public virtual void WriteCachedMarkup();
+        public virtual void WriteDoctypeDeclaration(Doctype type);
+        public virtual void WriteEncodedAttributeValue(string value);
+        public override void WriteEndTag(string tag);
+        public override void WriteFullBeginTag(string tag);
+        public virtual void WriteHiddenField(string name);
+        public virtual void WriteHiddenField(string name, string value);
+        public override void WriteLine();
+        public override void WriteLine(bool v);
+        public override void WriteLine(char v);
+        public override void WriteLine(char[] v);
+        public override void WriteLine(char[] buffer, int index, int count);
+        public override void WriteLine(double v);
+        public override void WriteLine(int v);
+        public override void WriteLine(long v);
+        public override void WriteLine(object v);
+        public override void WriteLine(float v);
+        public override void WriteLine(string s);
+        public override void WriteLine(string format, object arg);
+        public override void WriteLine(string format, object arg0, object arg1);
+        public override void WriteLine(string format, params object[] arg);
+        public virtual void WritePendingBreak();
+        public virtual void WriteUrlParameter(string name, string value);
+        public virtual void WriteXmlDeclaration();
+    }
+    public class XhtmlObjectListAdapter : XhtmlControlAdapter {
+        protected internal static readonly string BackToList;
+        protected internal static readonly string ShowMore;
+        protected internal static readonly string ShowMoreFormat;
+        public XhtmlObjectListAdapter();
+        protected new ObjectList Control { get; }
+        public override void CreateTemplatedUI(bool doDataBind);
+        public override bool HandlePostBackEvent(string eventArgument);
+        protected bool HasCommands();
+        protected bool HasDefaultCommand();
+        protected virtual bool HasItemDetails();
+        protected bool OnlyHasDefaultCommand();
+        public override void OnPreRender(EventArgs e);
+        public override void Render(XhtmlMobileTextWriter writer);
+        protected virtual void RenderItemDetails(XhtmlMobileTextWriter writer, ObjectListItem item);
+        protected virtual void RenderItemsList(XhtmlMobileTextWriter writer);
+    }
+    public class XhtmlPageAdapter : XhtmlControlAdapter, IControlAdapter, IPageAdapter {
+        public XhtmlPageAdapter();
+        public virtual IList CacheVaryByHeaders { get; }
+        public IDictionary CookielessDataDictionary { get; set; }
+        public virtual string EventArgumentKey { get; }
+        public virtual string EventSourceKey { get; }
+        public virtual int OptimumPageWeight { get; }
+        public override MobilePage Page { get; set; }
+        public bool PersistCookielessData { get; set; }
+        public virtual HtmlTextWriter CreateTextWriter(TextWriter writer);
+        public virtual NameValueCollection DeterminePostBackMode(HttpRequest request, string postEventSourceID, string postEventArgumentID, NameValueCollection baseCollection);
+        public static bool DeviceQualifies(HttpContext context);
+        public virtual bool HandleError(Exception e, HtmlTextWriter writer);
+        public virtual bool HandlePagePostBackEvent(string eventSource, string eventArgument);
+        protected virtual void InitWriterState(XhtmlMobileTextWriter writer);
+        public override void OnPreRender(EventArgs e);
+        public override void Render(XhtmlMobileTextWriter writer);
+        public virtual void RenderUrlPostBackEvent(XhtmlMobileTextWriter writer, string target, string argument);
+    }
+    public class XhtmlPanelAdapter : XhtmlControlAdapter {
+        public XhtmlPanelAdapter();
+        protected new Panel Control { get; }
+        public override void Render(XhtmlMobileTextWriter writer);
+    }
+    public class XhtmlPhoneCallAdapter : XhtmlControlAdapter {
+        public XhtmlPhoneCallAdapter();
+        protected new PhoneCall Control { get; }
+        public override void Render(XhtmlMobileTextWriter writer);
+    }
+    public class XhtmlSelectionListAdapter : XhtmlControlAdapter {
+        public XhtmlSelectionListAdapter();
+        protected new SelectionList Control { get; }
+        public override bool LoadPostData(string key, NameValueCollection data, object controlPrivateData, out bool dataChanged);
+        public override void Render(XhtmlMobileTextWriter writer);
+        protected override void RenderAsHiddenInputField(XhtmlMobileTextWriter writer);
+    }
+    public class XhtmlTextBoxAdapter : XhtmlControlAdapter {
+        public XhtmlTextBoxAdapter();
+        public new TextBox Control { get; }
+        public override void OnInit(EventArgs e);
+        public override void Render(XhtmlMobileTextWriter writer);
+        protected override void RenderAsHiddenInputField(XhtmlMobileTextWriter writer);
+    }
+    public class XhtmlTextViewAdapter : XhtmlControlAdapter {
+        public XhtmlTextViewAdapter();
+        protected new TextView Control { get; }
+        public override void Render(XhtmlMobileTextWriter writer);
+        public void RenderElement(XhtmlMobileTextWriter writer, int index, int beginSubstring, int endSubstring);
+    }
+    public class XhtmlValidationSummaryAdapter : XhtmlControlAdapter {
+        public XhtmlValidationSummaryAdapter();
+        protected new ValidationSummary Control { get; }
+        public override void OnInit(EventArgs e);
+        public override void Render(XhtmlMobileTextWriter writer);
+    }
+    public class XhtmlValidatorAdapter : XhtmlControlAdapter {
+        public XhtmlValidatorAdapter();
+        protected new BaseValidator Control { get; }
+        public override void Render(XhtmlMobileTextWriter writer);
+    }
+}
```

