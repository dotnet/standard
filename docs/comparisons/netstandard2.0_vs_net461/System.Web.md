# System.Web

``` diff
 namespace System.Web {
+    public enum ApplicationShutdownReason {
+        BinDirChangeOrDirectoryRename = 6,
+        BrowsersDirChangeOrDirectoryRename = 7,
+        BuildManagerChange = 15,
+        ChangeInGlobalAsax = 2,
+        ChangeInSecurityPolicyFile = 5,
+        CodeDirChangeOrDirectoryRename = 8,
+        ConfigurationChange = 3,
+        HostingEnvironment = 1,
+        HttpRuntimeClose = 12,
+        IdleTimeout = 10,
+        InitializationError = 13,
+        MaxRecompilationsReached = 14,
+        None = 0,
+        PhysicalApplicationPathChanged = 11,
+        ResourcesDirChangeOrDirectoryRename = 9,
+        UnloadAppDomainCalled = 4,
+    }
+    public sealed class AspNetHostingPermission : CodeAccessPermission, IUnrestrictedPermission {
+        public AspNetHostingPermission(PermissionState state);
+        public AspNetHostingPermission(AspNetHostingPermissionLevel level);
+        public AspNetHostingPermissionLevel Level { get; set; }
+        public override IPermission Copy();
+        public override void FromXml(SecurityElement securityElement);
+        public override IPermission Intersect(IPermission target);
+        public override bool IsSubsetOf(IPermission target);
+        public bool IsUnrestricted();
+        public override SecurityElement ToXml();
+        public override IPermission Union(IPermission target);
+    }
+    public sealed class AspNetHostingPermissionAttribute : CodeAccessSecurityAttribute {
+        public AspNetHostingPermissionAttribute(SecurityAction action);
+        public AspNetHostingPermissionLevel Level { get; set; }
+        public override IPermission CreatePermission();
+    }
+    public enum AspNetHostingPermissionLevel {
+        High = 500,
+        Low = 300,
+        Medium = 400,
+        Minimal = 200,
+        None = 100,
+        Unrestricted = 600,
+    }
+    public delegate IAsyncResult BeginEventHandler(object sender, EventArgs e, AsyncCallback cb, object extraData);
+    public class DefaultHttpHandler : IHttpAsyncHandler, IHttpHandler {
+        public DefaultHttpHandler();
+        protected HttpContext Context { get; }
+        protected NameValueCollection ExecuteUrlHeaders { get; }
+        public virtual bool IsReusable { get; }
+        public virtual IAsyncResult BeginProcessRequest(HttpContext context, AsyncCallback callback, object state);
+        public virtual void EndProcessRequest(IAsyncResult result);
+        public virtual void OnExecuteUrlPreconditionFailure();
+        public virtual string OverrideExecuteUrlPath();
+        public virtual void ProcessRequest(HttpContext context);
+    }
+    public delegate void EndEventHandler(IAsyncResult ar);
+    public sealed class EventHandlerTaskAsyncHelper {
+        public EventHandlerTaskAsyncHelper(TaskEventHandler handler);
+        public BeginEventHandler BeginEventHandler { get; private set; }
+        public EndEventHandler EndEventHandler { get; private set; }
+    }
+    public class HtmlString : IHtmlString {
+        public HtmlString(string value);
+        public string ToHtmlString();
+        public override string ToString();
+    }
+    public class HttpApplication : IComponent, IDisposable, IHttpAsyncHandler, IHttpHandler, IRequestCompletedNotifier, ISyncContext {
+        public HttpApplication();
+        public HttpApplicationState Application { get; }
+        public HttpContext Context { get; }
+        protected EventHandlerList Events { get; }
+        public HttpModuleCollection Modules { get; }
+        public HttpRequest Request { get; }
+        public HttpResponse Response { get; }
+        public HttpServerUtility Server { get; }
+        public HttpSessionState Session { get; }
+        public ISite Site { get; set; }
+        bool System.Web.IHttpHandler.IsReusable { get; }
+        public IPrincipal User { get; }
+        public event EventHandler AcquireRequestState;
+        public event EventHandler AuthenticateRequest;
+        public event EventHandler AuthorizeRequest;
+        public event EventHandler BeginRequest;
+        public event EventHandler Disposed;
+        public event EventHandler EndRequest;
+        public event EventHandler Error;
+        public event EventHandler LogRequest;
+        public event EventHandler MapRequestHandler;
+        public event EventHandler PostAcquireRequestState;
+        public event EventHandler PostAuthenticateRequest;
+        public event EventHandler PostAuthorizeRequest;
+        public event EventHandler PostLogRequest;
+        public event EventHandler PostMapRequestHandler;
+        public event EventHandler PostReleaseRequestState;
+        public event EventHandler PostRequestHandlerExecute;
+        public event EventHandler PostResolveRequestCache;
+        public event EventHandler PostUpdateRequestCache;
+        public event EventHandler PreRequestHandlerExecute;
+        public event EventHandler PreSendRequestContent;
+        public event EventHandler PreSendRequestHeaders;
+        public event EventHandler ReleaseRequestState;
+        public event EventHandler RequestCompleted;
+        public event EventHandler ResolveRequestCache;
+        public event EventHandler UpdateRequestCache;
+        public void AddOnAcquireRequestStateAsync(BeginEventHandler bh, EndEventHandler eh);
+        public void AddOnAcquireRequestStateAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state);
+        public void AddOnAuthenticateRequestAsync(BeginEventHandler bh, EndEventHandler eh);
+        public void AddOnAuthenticateRequestAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state);
+        public void AddOnAuthorizeRequestAsync(BeginEventHandler bh, EndEventHandler eh);
+        public void AddOnAuthorizeRequestAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state);
+        public void AddOnBeginRequestAsync(BeginEventHandler bh, EndEventHandler eh);
+        public void AddOnBeginRequestAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state);
+        public void AddOnEndRequestAsync(BeginEventHandler bh, EndEventHandler eh);
+        public void AddOnEndRequestAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state);
+        public void AddOnLogRequestAsync(BeginEventHandler bh, EndEventHandler eh);
+        public void AddOnLogRequestAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state);
+        public void AddOnMapRequestHandlerAsync(BeginEventHandler bh, EndEventHandler eh);
+        public void AddOnMapRequestHandlerAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state);
+        public void AddOnPostAcquireRequestStateAsync(BeginEventHandler bh, EndEventHandler eh);
+        public void AddOnPostAcquireRequestStateAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state);
+        public void AddOnPostAuthenticateRequestAsync(BeginEventHandler bh, EndEventHandler eh);
+        public void AddOnPostAuthenticateRequestAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state);
+        public void AddOnPostAuthorizeRequestAsync(BeginEventHandler bh, EndEventHandler eh);
+        public void AddOnPostAuthorizeRequestAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state);
+        public void AddOnPostLogRequestAsync(BeginEventHandler bh, EndEventHandler eh);
+        public void AddOnPostLogRequestAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state);
+        public void AddOnPostMapRequestHandlerAsync(BeginEventHandler bh, EndEventHandler eh);
+        public void AddOnPostMapRequestHandlerAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state);
+        public void AddOnPostReleaseRequestStateAsync(BeginEventHandler bh, EndEventHandler eh);
+        public void AddOnPostReleaseRequestStateAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state);
+        public void AddOnPostRequestHandlerExecuteAsync(BeginEventHandler bh, EndEventHandler eh);
+        public void AddOnPostRequestHandlerExecuteAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state);
+        public void AddOnPostResolveRequestCacheAsync(BeginEventHandler bh, EndEventHandler eh);
+        public void AddOnPostResolveRequestCacheAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state);
+        public void AddOnPostUpdateRequestCacheAsync(BeginEventHandler bh, EndEventHandler eh);
+        public void AddOnPostUpdateRequestCacheAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state);
+        public void AddOnPreRequestHandlerExecuteAsync(BeginEventHandler bh, EndEventHandler eh);
+        public void AddOnPreRequestHandlerExecuteAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state);
+        public void AddOnReleaseRequestStateAsync(BeginEventHandler bh, EndEventHandler eh);
+        public void AddOnReleaseRequestStateAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state);
+        public void AddOnResolveRequestCacheAsync(BeginEventHandler bh, EndEventHandler eh);
+        public void AddOnResolveRequestCacheAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state);
+        public void AddOnUpdateRequestCacheAsync(BeginEventHandler bh, EndEventHandler eh);
+        public void AddOnUpdateRequestCacheAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state);
+        public void CompleteRequest();
+        public virtual void Dispose();
+        public virtual string GetOutputCacheProviderName(HttpContext context);
+        public virtual string GetVaryByCustomString(HttpContext context, string custom);
+        public virtual void Init();
+        public static void RegisterModule(Type moduleType);
+        IAsyncResult System.Web.IHttpAsyncHandler.BeginProcessRequest(HttpContext context, AsyncCallback cb, object extraData);
+        void System.Web.IHttpAsyncHandler.EndProcessRequest(IAsyncResult result);
+        void System.Web.IHttpHandler.ProcessRequest(HttpContext context);
+    }
+    public sealed class HttpApplicationState : NameObjectCollectionBase {
+        public string[] AllKeys { get; }
+        public HttpApplicationState Contents { get; }
+        public override int Count { get; }
+        public HttpStaticObjectsCollection StaticObjects { get; }
+        public object this[int index] { get; }
+        public object this[string name] { get; set; }
+        public void Add(string name, object value);
+        public void Clear();
+        public object Get(int index);
+        public object Get(string name);
+        public string GetKey(int index);
+        public void Lock();
+        public void Remove(string name);
+        public void RemoveAll();
+        public void RemoveAt(int index);
+        public void Set(string name, object value);
+        public void UnLock();
+    }
+    public abstract class HttpApplicationStateBase : NameObjectCollectionBase, ICollection, IEnumerable {
+        protected HttpApplicationStateBase();
+        public virtual string[] AllKeys { get; }
+        public virtual HttpApplicationStateBase Contents { get; }
+        public override int Count { get; }
+        public virtual bool IsSynchronized { get; }
+        public virtual HttpStaticObjectsCollectionBase StaticObjects { get; }
+        public virtual object SyncRoot { get; }
+        public virtual object this[int index] { get; }
+        public virtual object this[string name] { get; set; }
+        public virtual void Add(string name, object value);
+        public virtual void Clear();
+        public virtual void CopyTo(Array array, int index);
+        public virtual object Get(int index);
+        public virtual object Get(string name);
+        public override IEnumerator GetEnumerator();
+        public virtual string GetKey(int index);
+        public virtual void Lock();
+        public virtual void Remove(string name);
+        public virtual void RemoveAll();
+        public virtual void RemoveAt(int index);
+        public virtual void Set(string name, object value);
+        public virtual void UnLock();
+    }
+    public class HttpApplicationStateWrapper : HttpApplicationStateBase {
+        public HttpApplicationStateWrapper(HttpApplicationState httpApplicationState);
+        public override string[] AllKeys { get; }
+        public override HttpApplicationStateBase Contents { get; }
+        public override int Count { get; }
+        public override bool IsSynchronized { get; }
+        public override NameObjectCollectionBase.KeysCollection Keys { get; }
+        public override HttpStaticObjectsCollectionBase StaticObjects { get; }
+        public override object SyncRoot { get; }
+        public override object this[int index] { get; }
+        public override object this[string name] { get; set; }
+        public override void Add(string name, object value);
+        public override void Clear();
+        public override void CopyTo(Array array, int index);
+        public override object Get(int index);
+        public override object Get(string name);
+        public override IEnumerator GetEnumerator();
+        public override string GetKey(int index);
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+        public override void Lock();
+        public override void OnDeserialization(object sender);
+        public override void Remove(string name);
+        public override void RemoveAll();
+        public override void RemoveAt(int index);
+        public override void Set(string name, object value);
+        public override void UnLock();
+    }
+    public class HttpBrowserCapabilities : HttpCapabilitiesBase {
+        public HttpBrowserCapabilities();
+    }
+    public abstract class HttpBrowserCapabilitiesBase : IFilterResolutionService {
+        protected HttpBrowserCapabilitiesBase();
+        public virtual bool ActiveXControls { get; }
+        public virtual IDictionary Adapters { get; }
+        public virtual bool AOL { get; }
+        public virtual bool BackgroundSounds { get; }
+        public virtual bool Beta { get; }
+        public virtual string Browser { get; }
+        public virtual ArrayList Browsers { get; }
+        public virtual bool CanCombineFormsInDeck { get; }
+        public virtual bool CanInitiateVoiceCall { get; }
+        public virtual bool CanRenderAfterInputOrSelectElement { get; }
+        public virtual bool CanRenderEmptySelects { get; }
+        public virtual bool CanRenderInputAndSelectElementsTogether { get; }
+        public virtual bool CanRenderMixedSelects { get; }
+        public virtual bool CanRenderOneventAndPrevElementsTogether { get; }
+        public virtual bool CanRenderPostBackCards { get; }
+        public virtual bool CanRenderSetvarZeroWithMultiSelectionList { get; }
+        public virtual bool CanSendMail { get; }
+        public virtual IDictionary Capabilities { get; set; }
+        public virtual bool CDF { get; }
+        public virtual Version ClrVersion { get; }
+        public virtual bool Cookies { get; }
+        public virtual bool Crawler { get; }
+        public virtual int DefaultSubmitButtonLimit { get; }
+        public virtual Version EcmaScriptVersion { get; }
+        public virtual bool Frames { get; }
+        public virtual int GatewayMajorVersion { get; }
+        public virtual double GatewayMinorVersion { get; }
+        public virtual string GatewayVersion { get; }
+        public virtual bool HasBackButton { get; }
+        public virtual bool HidesRightAlignedMultiselectScrollbars { get; }
+        public virtual string HtmlTextWriter { get; set; }
+        public virtual string Id { get; }
+        public virtual string InputType { get; }
+        public virtual bool IsColor { get; }
+        public virtual bool IsMobileDevice { get; }
+        public virtual bool JavaApplets { get; }
+        public virtual Version JScriptVersion { get; }
+        public virtual int MajorVersion { get; }
+        public virtual int MaximumHrefLength { get; }
+        public virtual int MaximumRenderedPageSize { get; }
+        public virtual int MaximumSoftkeyLabelLength { get; }
+        public virtual double MinorVersion { get; }
+        public virtual string MinorVersionString { get; }
+        public virtual string MobileDeviceManufacturer { get; }
+        public virtual string MobileDeviceModel { get; }
+        public virtual Version MSDomVersion { get; }
+        public virtual int NumberOfSoftkeys { get; }
+        public virtual string Platform { get; }
+        public virtual string PreferredImageMime { get; }
+        public virtual string PreferredRenderingMime { get; }
+        public virtual string PreferredRenderingType { get; }
+        public virtual string PreferredRequestEncoding { get; }
+        public virtual string PreferredResponseEncoding { get; }
+        public virtual bool RendersBreakBeforeWmlSelectAndInput { get; }
+        public virtual bool RendersBreaksAfterHtmlLists { get; }
+        public virtual bool RendersBreaksAfterWmlAnchor { get; }
+        public virtual bool RendersBreaksAfterWmlInput { get; }
+        public virtual bool RendersWmlDoAcceptsInline { get; }
+        public virtual bool RendersWmlSelectsAsMenuCards { get; }
+        public virtual string RequiredMetaTagNameValue { get; }
+        public virtual bool RequiresAttributeColonSubstitution { get; }
+        public virtual bool RequiresContentTypeMetaTag { get; }
+        public virtual bool RequiresControlStateInSession { get; }
+        public virtual bool RequiresDBCSCharacter { get; }
+        public virtual bool RequiresHtmlAdaptiveErrorReporting { get; }
+        public virtual bool RequiresLeadingPageBreak { get; }
+        public virtual bool RequiresNoBreakInFormatting { get; }
+        public virtual bool RequiresOutputOptimization { get; }
+        public virtual bool RequiresPhoneNumbersAsPlainText { get; }
+        public virtual bool RequiresSpecialViewStateEncoding { get; }
+        public virtual bool RequiresUniqueFilePathSuffix { get; }
+        public virtual bool RequiresUniqueHtmlCheckboxNames { get; }
+        public virtual bool RequiresUniqueHtmlInputNames { get; }
+        public virtual bool RequiresUrlEncodedPostfieldValues { get; }
+        public virtual int ScreenBitDepth { get; }
+        public virtual int ScreenCharactersHeight { get; }
+        public virtual int ScreenCharactersWidth { get; }
+        public virtual int ScreenPixelsHeight { get; }
+        public virtual int ScreenPixelsWidth { get; }
+        public virtual bool SupportsAccesskeyAttribute { get; }
+        public virtual bool SupportsBodyColor { get; }
+        public virtual bool SupportsBold { get; }
+        public virtual bool SupportsCacheControlMetaTag { get; }
+        public virtual bool SupportsCallback { get; }
+        public virtual bool SupportsCss { get; }
+        public virtual bool SupportsDivAlign { get; }
+        public virtual bool SupportsDivNoWrap { get; }
+        public virtual bool SupportsEmptyStringInCookieValue { get; }
+        public virtual bool SupportsFontColor { get; }
+        public virtual bool SupportsFontName { get; }
+        public virtual bool SupportsFontSize { get; }
+        public virtual bool SupportsImageSubmit { get; }
+        public virtual bool SupportsIModeSymbols { get; }
+        public virtual bool SupportsInputIStyle { get; }
+        public virtual bool SupportsInputMode { get; }
+        public virtual bool SupportsItalic { get; }
+        public virtual bool SupportsJPhoneMultiMediaAttributes { get; }
+        public virtual bool SupportsJPhoneSymbols { get; }
+        public virtual bool SupportsQueryStringInFormAction { get; }
+        public virtual bool SupportsRedirectWithCookie { get; }
+        public virtual bool SupportsSelectMultiple { get; }
+        public virtual bool SupportsUncheck { get; }
+        public virtual bool SupportsXmlHttp { get; }
+        public virtual bool Tables { get; }
+        public virtual Type TagWriter { get; }
+        public virtual string this[string key] { get; }
+        public virtual string Type { get; }
+        public virtual bool UseOptimizedCacheKey { get; }
+        public virtual bool VBScript { get; }
+        public virtual string Version { get; }
+        public virtual Version W3CDomVersion { get; }
+        public virtual bool Win16 { get; }
+        public virtual bool Win32 { get; }
+        public virtual void AddBrowser(string browserName);
+        public virtual int CompareFilters(string filter1, string filter2);
+        public virtual HtmlTextWriter CreateHtmlTextWriter(TextWriter w);
+        public virtual void DisableOptimizedCacheKey();
+        public virtual bool EvaluateFilter(string filterName);
+        public virtual Version[] GetClrVersions();
+        public virtual bool IsBrowser(string browserName);
+    }
+    public class HttpBrowserCapabilitiesWrapper : HttpBrowserCapabilitiesBase {
+        public HttpBrowserCapabilitiesWrapper(HttpBrowserCapabilities httpBrowserCapabilities);
+        public override bool ActiveXControls { get; }
+        public override IDictionary Adapters { get; }
+        public override bool AOL { get; }
+        public override bool BackgroundSounds { get; }
+        public override bool Beta { get; }
+        public override string Browser { get; }
+        public override ArrayList Browsers { get; }
+        public override bool CanCombineFormsInDeck { get; }
+        public override bool CanInitiateVoiceCall { get; }
+        public override bool CanRenderAfterInputOrSelectElement { get; }
+        public override bool CanRenderEmptySelects { get; }
+        public override bool CanRenderInputAndSelectElementsTogether { get; }
+        public override bool CanRenderMixedSelects { get; }
+        public override bool CanRenderOneventAndPrevElementsTogether { get; }
+        public override bool CanRenderPostBackCards { get; }
+        public override bool CanRenderSetvarZeroWithMultiSelectionList { get; }
+        public override bool CanSendMail { get; }
+        public override IDictionary Capabilities { get; set; }
+        public override bool CDF { get; }
+        public override Version ClrVersion { get; }
+        public override bool Cookies { get; }
+        public override bool Crawler { get; }
+        public override int DefaultSubmitButtonLimit { get; }
+        public override Version EcmaScriptVersion { get; }
+        public override bool Frames { get; }
+        public override int GatewayMajorVersion { get; }
+        public override double GatewayMinorVersion { get; }
+        public override string GatewayVersion { get; }
+        public override bool HasBackButton { get; }
+        public override bool HidesRightAlignedMultiselectScrollbars { get; }
+        public override string HtmlTextWriter { get; set; }
+        public override string Id { get; }
+        public override string InputType { get; }
+        public override bool IsColor { get; }
+        public override bool IsMobileDevice { get; }
+        public override bool JavaApplets { get; }
+        public override Version JScriptVersion { get; }
+        public override int MajorVersion { get; }
+        public override int MaximumHrefLength { get; }
+        public override int MaximumRenderedPageSize { get; }
+        public override int MaximumSoftkeyLabelLength { get; }
+        public override double MinorVersion { get; }
+        public override string MinorVersionString { get; }
+        public override string MobileDeviceManufacturer { get; }
+        public override string MobileDeviceModel { get; }
+        public override Version MSDomVersion { get; }
+        public override int NumberOfSoftkeys { get; }
+        public override string Platform { get; }
+        public override string PreferredImageMime { get; }
+        public override string PreferredRenderingMime { get; }
+        public override string PreferredRenderingType { get; }
+        public override string PreferredRequestEncoding { get; }
+        public override string PreferredResponseEncoding { get; }
+        public override bool RendersBreakBeforeWmlSelectAndInput { get; }
+        public override bool RendersBreaksAfterHtmlLists { get; }
+        public override bool RendersBreaksAfterWmlAnchor { get; }
+        public override bool RendersBreaksAfterWmlInput { get; }
+        public override bool RendersWmlDoAcceptsInline { get; }
+        public override bool RendersWmlSelectsAsMenuCards { get; }
+        public override string RequiredMetaTagNameValue { get; }
+        public override bool RequiresAttributeColonSubstitution { get; }
+        public override bool RequiresContentTypeMetaTag { get; }
+        public override bool RequiresControlStateInSession { get; }
+        public override bool RequiresDBCSCharacter { get; }
+        public override bool RequiresHtmlAdaptiveErrorReporting { get; }
+        public override bool RequiresLeadingPageBreak { get; }
+        public override bool RequiresNoBreakInFormatting { get; }
+        public override bool RequiresOutputOptimization { get; }
+        public override bool RequiresPhoneNumbersAsPlainText { get; }
+        public override bool RequiresSpecialViewStateEncoding { get; }
+        public override bool RequiresUniqueFilePathSuffix { get; }
+        public override bool RequiresUniqueHtmlCheckboxNames { get; }
+        public override bool RequiresUniqueHtmlInputNames { get; }
+        public override bool RequiresUrlEncodedPostfieldValues { get; }
+        public override int ScreenBitDepth { get; }
+        public override int ScreenCharactersHeight { get; }
+        public override int ScreenCharactersWidth { get; }
+        public override int ScreenPixelsHeight { get; }
+        public override int ScreenPixelsWidth { get; }
+        public override bool SupportsAccesskeyAttribute { get; }
+        public override bool SupportsBodyColor { get; }
+        public override bool SupportsBold { get; }
+        public override bool SupportsCacheControlMetaTag { get; }
+        public override bool SupportsCallback { get; }
+        public override bool SupportsCss { get; }
+        public override bool SupportsDivAlign { get; }
+        public override bool SupportsDivNoWrap { get; }
+        public override bool SupportsEmptyStringInCookieValue { get; }
+        public override bool SupportsFontColor { get; }
+        public override bool SupportsFontName { get; }
+        public override bool SupportsFontSize { get; }
+        public override bool SupportsImageSubmit { get; }
+        public override bool SupportsIModeSymbols { get; }
+        public override bool SupportsInputIStyle { get; }
+        public override bool SupportsInputMode { get; }
+        public override bool SupportsItalic { get; }
+        public override bool SupportsJPhoneMultiMediaAttributes { get; }
+        public override bool SupportsJPhoneSymbols { get; }
+        public override bool SupportsQueryStringInFormAction { get; }
+        public override bool SupportsRedirectWithCookie { get; }
+        public override bool SupportsSelectMultiple { get; }
+        public override bool SupportsUncheck { get; }
+        public override bool SupportsXmlHttp { get; }
+        public override bool Tables { get; }
+        public override Type TagWriter { get; }
+        public override string this[string key] { get; }
+        public override string Type { get; }
+        public override bool UseOptimizedCacheKey { get; }
+        public override bool VBScript { get; }
+        public override string Version { get; }
+        public override Version W3CDomVersion { get; }
+        public override bool Win16 { get; }
+        public override bool Win32 { get; }
+        public override void AddBrowser(string browserName);
+        public override int CompareFilters(string filter1, string filter2);
+        public override HtmlTextWriter CreateHtmlTextWriter(TextWriter w);
+        public override void DisableOptimizedCacheKey();
+        public override bool EvaluateFilter(string filterName);
+        public override Version[] GetClrVersions();
+        public override bool IsBrowser(string browserName);
+    }
+    public enum HttpCacheability {
+        NoCache = 1,
+        Private = 2,
+        Public = 4,
+        Server = 3,
+        ServerAndNoCache = 3,
+        ServerAndPrivate = 5,
+    }
+    public sealed class HttpCachePolicy {
+        public HttpCacheVaryByContentEncodings VaryByContentEncodings { get; }
+        public HttpCacheVaryByHeaders VaryByHeaders { get; }
+        public HttpCacheVaryByParams VaryByParams { get; }
+        public void AddValidationCallback(HttpCacheValidateHandler handler, object data);
+        public void AppendCacheExtension(string extension);
+        public void SetAllowResponseInBrowserHistory(bool allow);
+        public void SetCacheability(HttpCacheability cacheability);
+        public void SetCacheability(HttpCacheability cacheability, string field);
+        public void SetETag(string etag);
+        public void SetETagFromFileDependencies();
+        public void SetExpires(DateTime date);
+        public void SetLastModified(DateTime date);
+        public void SetLastModifiedFromFileDependencies();
+        public void SetMaxAge(TimeSpan delta);
+        public void SetNoServerCaching();
+        public void SetNoStore();
+        public void SetNoTransforms();
+        public void SetOmitVaryStar(bool omit);
+        public void SetProxyMaxAge(TimeSpan delta);
+        public void SetRevalidation(HttpCacheRevalidation revalidation);
+        public void SetSlidingExpiration(bool slide);
+        public void SetValidUntilExpires(bool validUntilExpires);
+        public void SetVaryByCustom(string custom);
+    }
+    public abstract class HttpCachePolicyBase {
+        protected HttpCachePolicyBase();
+        public virtual HttpCacheVaryByContentEncodings VaryByContentEncodings { get; }
+        public virtual HttpCacheVaryByHeaders VaryByHeaders { get; }
+        public virtual HttpCacheVaryByParams VaryByParams { get; }
+        public virtual void AddValidationCallback(HttpCacheValidateHandler handler, object data);
+        public virtual void AppendCacheExtension(string extension);
+        public virtual void SetAllowResponseInBrowserHistory(bool allow);
+        public virtual void SetCacheability(HttpCacheability cacheability);
+        public virtual void SetCacheability(HttpCacheability cacheability, string field);
+        public virtual void SetETag(string etag);
+        public virtual void SetETagFromFileDependencies();
+        public virtual void SetExpires(DateTime date);
+        public virtual void SetLastModified(DateTime date);
+        public virtual void SetLastModifiedFromFileDependencies();
+        public virtual void SetMaxAge(TimeSpan delta);
+        public virtual void SetNoServerCaching();
+        public virtual void SetNoStore();
+        public virtual void SetNoTransforms();
+        public virtual void SetOmitVaryStar(bool omit);
+        public virtual void SetProxyMaxAge(TimeSpan delta);
+        public virtual void SetRevalidation(HttpCacheRevalidation revalidation);
+        public virtual void SetSlidingExpiration(bool slide);
+        public virtual void SetValidUntilExpires(bool validUntilExpires);
+        public virtual void SetVaryByCustom(string custom);
+    }
+    public class HttpCachePolicyWrapper : HttpCachePolicyBase {
+        public HttpCachePolicyWrapper(HttpCachePolicy httpCachePolicy);
+        public override HttpCacheVaryByContentEncodings VaryByContentEncodings { get; }
+        public override HttpCacheVaryByHeaders VaryByHeaders { get; }
+        public override HttpCacheVaryByParams VaryByParams { get; }
+        public override void AddValidationCallback(HttpCacheValidateHandler handler, object data);
+        public override void AppendCacheExtension(string extension);
+        public override void SetAllowResponseInBrowserHistory(bool allow);
+        public override void SetCacheability(HttpCacheability cacheability);
+        public override void SetCacheability(HttpCacheability cacheability, string field);
+        public override void SetETag(string etag);
+        public override void SetETagFromFileDependencies();
+        public override void SetExpires(DateTime date);
+        public override void SetLastModified(DateTime date);
+        public override void SetLastModifiedFromFileDependencies();
+        public override void SetMaxAge(TimeSpan delta);
+        public override void SetNoServerCaching();
+        public override void SetNoStore();
+        public override void SetNoTransforms();
+        public override void SetOmitVaryStar(bool omit);
+        public override void SetProxyMaxAge(TimeSpan delta);
+        public override void SetRevalidation(HttpCacheRevalidation revalidation);
+        public override void SetSlidingExpiration(bool slide);
+        public override void SetValidUntilExpires(bool validUntilExpires);
+        public override void SetVaryByCustom(string custom);
+    }
+    public enum HttpCacheRevalidation {
+        AllCaches = 1,
+        None = 3,
+        ProxyCaches = 2,
+    }
+    public delegate void HttpCacheValidateHandler(HttpContext context, object data, ref HttpValidationStatus validationStatus);
+    public sealed class HttpCacheVaryByContentEncodings {
+        public HttpCacheVaryByContentEncodings();
+        public bool this[string contentEncoding] { get; set; }
+    }
+    public sealed class HttpCacheVaryByHeaders {
+        public HttpCacheVaryByHeaders();
+        public bool AcceptTypes { get; set; }
+        public bool this[string header] { get; set; }
+        public bool UserAgent { get; set; }
+        public bool UserCharSet { get; set; }
+        public bool UserLanguage { get; set; }
+        public void VaryByUnspecifiedParameters();
+    }
+    public sealed class HttpCacheVaryByParams {
+        public HttpCacheVaryByParams();
+        public bool IgnoreParams { get; set; }
+        public bool this[string header] { get; set; }
+    }
+    public class HttpClientCertificate : NameValueCollection {
+        public byte[] BinaryIssuer { get; }
+        public int CertEncoding { get; }
+        public byte[] Certificate { get; }
+        public string Cookie { get; }
+        public int Flags { get; }
+        public bool IsPresent { get; }
+        public string Issuer { get; }
+        public bool IsValid { get; }
+        public int KeySize { get; }
+        public byte[] PublicKey { get; }
+        public int SecretKeySize { get; }
+        public string SerialNumber { get; }
+        public string ServerIssuer { get; }
+        public string ServerSubject { get; }
+        public string Subject { get; }
+        public DateTime ValidFrom { get; }
+        public DateTime ValidUntil { get; }
+        public override string Get(string field);
+    }
+    public sealed class HttpCompileException : HttpException {
+        public HttpCompileException();
+        public HttpCompileException(CompilerResults results, string sourceCode);
+        public HttpCompileException(string message);
+        public HttpCompileException(string message, Exception innerException);
+        public override string Message { get; }
+        public CompilerResults Results { get; }
+        public string SourceCode { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public sealed class HttpContext : IPrincipalContainer, IServiceProvider {
+        public HttpContext(HttpRequest request, HttpResponse response);
+        public HttpContext(HttpWorkerRequest wr);
+        public Exception[] AllErrors { get; }
+        public bool AllowAsyncDuringSyncStages { get; set; }
+        public HttpApplicationState Application { get; }
+        public HttpApplication ApplicationInstance { get; set; }
+        public AsyncPreloadModeFlags AsyncPreloadMode { get; set; }
+        public Cache Cache { get; }
+        public static HttpContext Current { get; set; }
+        public IHttpHandler CurrentHandler { get; }
+        public RequestNotification CurrentNotification { get; internal set; }
+        public Exception Error { get; }
+        public IHttpHandler Handler { get; set; }
+        public bool IsCustomErrorEnabled { get; }
+        public bool IsDebuggingEnabled { get; }
+        public bool IsPostNotification { get; internal set; }
+        public bool IsWebSocketRequest { get; }
+        public bool IsWebSocketRequestUpgrading { get; }
+        public IDictionary Items { get; }
+        public PageInstrumentationService PageInstrumentation { get; }
+        public IHttpHandler PreviousHandler { get; }
+        public ProfileBase Profile { get; }
+        public HttpRequest Request { get; }
+        public HttpResponse Response { get; }
+        public HttpServerUtility Server { get; }
+        public HttpSessionState Session { get; }
+        public bool SkipAuthorization { get; set; }
+        public bool ThreadAbortOnTimeout { get; set; }
+        public DateTime Timestamp { get; }
+        public TraceContext Trace { get; }
+        public IPrincipal User { get; set; }
+        public string WebSocketNegotiatedProtocol { get; }
+        public IList<string> WebSocketRequestedProtocols { get; }
+        public void AcceptWebSocketRequest(Func<AspNetWebSocketContext, Task> userFunc);
+        public void AcceptWebSocketRequest(Func<AspNetWebSocketContext, Task> userFunc, AspNetWebSocketOptions options);
+        public void AddError(Exception errorInfo);
+        public ISubscriptionToken AddOnRequestCompleted(Action<HttpContext> callback);
+        public void ClearError();
+        public ISubscriptionToken DisposeOnPipelineCompleted(IDisposable target);
+        public static object GetAppConfig(string name);
+        public object GetConfig(string name);
+        public static object GetGlobalResourceObject(string classKey, string resourceKey);
+        public static object GetGlobalResourceObject(string classKey, string resourceKey, CultureInfo culture);
+        public static object GetLocalResourceObject(string virtualPath, string resourceKey);
+        public static object GetLocalResourceObject(string virtualPath, string resourceKey, CultureInfo culture);
+        public object GetSection(string sectionName);
+        public void RemapHandler(IHttpHandler handler);
+        public void RewritePath(string path);
+        public void RewritePath(string path, bool rebaseClientPath);
+        public void RewritePath(string filePath, string pathInfo, string queryString);
+        public void RewritePath(string filePath, string pathInfo, string queryString, bool setClientFilePath);
+        public void SetSessionStateBehavior(SessionStateBehavior sessionStateBehavior);
+        object System.IServiceProvider.GetService(Type service);
+    }
+    public abstract class HttpContextBase : IServiceProvider {
+        protected HttpContextBase();
+        public virtual Exception[] AllErrors { get; }
+        public virtual bool AllowAsyncDuringSyncStages { get; set; }
+        public virtual HttpApplicationStateBase Application { get; }
+        public virtual HttpApplication ApplicationInstance { get; set; }
+        public virtual AsyncPreloadModeFlags AsyncPreloadMode { get; set; }
+        public virtual Cache Cache { get; }
+        public virtual IHttpHandler CurrentHandler { get; }
+        public virtual RequestNotification CurrentNotification { get; }
+        public virtual Exception Error { get; }
+        public virtual IHttpHandler Handler { get; set; }
+        public virtual bool IsCustomErrorEnabled { get; }
+        public virtual bool IsDebuggingEnabled { get; }
+        public virtual bool IsPostNotification { get; }
+        public virtual bool IsWebSocketRequest { get; }
+        public virtual bool IsWebSocketRequestUpgrading { get; }
+        public virtual IDictionary Items { get; }
+        public virtual PageInstrumentationService PageInstrumentation { get; }
+        public virtual IHttpHandler PreviousHandler { get; }
+        public virtual ProfileBase Profile { get; }
+        public virtual HttpRequestBase Request { get; }
+        public virtual HttpResponseBase Response { get; }
+        public virtual HttpServerUtilityBase Server { get; }
+        public virtual HttpSessionStateBase Session { get; }
+        public virtual bool SkipAuthorization { get; set; }
+        public virtual bool ThreadAbortOnTimeout { get; set; }
+        public virtual DateTime Timestamp { get; }
+        public virtual TraceContext Trace { get; }
+        public virtual IPrincipal User { get; set; }
+        public virtual string WebSocketNegotiatedProtocol { get; }
+        public virtual IList<string> WebSocketRequestedProtocols { get; }
+        public virtual void AcceptWebSocketRequest(Func<AspNetWebSocketContext, Task> userFunc);
+        public virtual void AcceptWebSocketRequest(Func<AspNetWebSocketContext, Task> userFunc, AspNetWebSocketOptions options);
+        public virtual void AddError(Exception errorInfo);
+        public virtual ISubscriptionToken AddOnRequestCompleted(Action<HttpContextBase> callback);
+        public virtual void ClearError();
+        public virtual ISubscriptionToken DisposeOnPipelineCompleted(IDisposable target);
+        public virtual object GetGlobalResourceObject(string classKey, string resourceKey);
+        public virtual object GetGlobalResourceObject(string classKey, string resourceKey, CultureInfo culture);
+        public virtual object GetLocalResourceObject(string virtualPath, string resourceKey);
+        public virtual object GetLocalResourceObject(string virtualPath, string resourceKey, CultureInfo culture);
+        public virtual object GetSection(string sectionName);
+        public virtual object GetService(Type serviceType);
+        public virtual void RemapHandler(IHttpHandler handler);
+        public virtual void RewritePath(string path);
+        public virtual void RewritePath(string path, bool rebaseClientPath);
+        public virtual void RewritePath(string filePath, string pathInfo, string queryString);
+        public virtual void RewritePath(string filePath, string pathInfo, string queryString, bool setClientFilePath);
+        public virtual void SetSessionStateBehavior(SessionStateBehavior sessionStateBehavior);
+    }
+    public class HttpContextWrapper : HttpContextBase {
+        public HttpContextWrapper(HttpContext httpContext);
+        public override Exception[] AllErrors { get; }
+        public override bool AllowAsyncDuringSyncStages { get; set; }
+        public override HttpApplicationStateBase Application { get; }
+        public override HttpApplication ApplicationInstance { get; set; }
+        public override AsyncPreloadModeFlags AsyncPreloadMode { get; set; }
+        public override Cache Cache { get; }
+        public override IHttpHandler CurrentHandler { get; }
+        public override RequestNotification CurrentNotification { get; }
+        public override Exception Error { get; }
+        public override IHttpHandler Handler { get; set; }
+        public override bool IsCustomErrorEnabled { get; }
+        public override bool IsDebuggingEnabled { get; }
+        public override bool IsPostNotification { get; }
+        public override bool IsWebSocketRequest { get; }
+        public override bool IsWebSocketRequestUpgrading { get; }
+        public override IDictionary Items { get; }
+        public override PageInstrumentationService PageInstrumentation { get; }
+        public override IHttpHandler PreviousHandler { get; }
+        public override ProfileBase Profile { get; }
+        public override HttpRequestBase Request { get; }
+        public override HttpResponseBase Response { get; }
+        public override HttpServerUtilityBase Server { get; }
+        public override HttpSessionStateBase Session { get; }
+        public override bool SkipAuthorization { get; set; }
+        public override bool ThreadAbortOnTimeout { get; set; }
+        public override DateTime Timestamp { get; }
+        public override TraceContext Trace { get; }
+        public override IPrincipal User { get; set; }
+        public override string WebSocketNegotiatedProtocol { get; }
+        public override IList<string> WebSocketRequestedProtocols { get; }
+        public override void AcceptWebSocketRequest(Func<AspNetWebSocketContext, Task> userFunc);
+        public override void AcceptWebSocketRequest(Func<AspNetWebSocketContext, Task> userFunc, AspNetWebSocketOptions options);
+        public override void AddError(Exception errorInfo);
+        public override ISubscriptionToken AddOnRequestCompleted(Action<HttpContextBase> callback);
+        public override void ClearError();
+        public override ISubscriptionToken DisposeOnPipelineCompleted(IDisposable target);
+        public override object GetGlobalResourceObject(string classKey, string resourceKey);
+        public override object GetGlobalResourceObject(string classKey, string resourceKey, CultureInfo culture);
+        public override object GetLocalResourceObject(string virtualPath, string resourceKey);
+        public override object GetLocalResourceObject(string virtualPath, string resourceKey, CultureInfo culture);
+        public override object GetSection(string sectionName);
+        public override object GetService(Type serviceType);
+        public override void RemapHandler(IHttpHandler handler);
+        public override void RewritePath(string path);
+        public override void RewritePath(string path, bool rebaseClientPath);
+        public override void RewritePath(string filePath, string pathInfo, string queryString);
+        public override void RewritePath(string filePath, string pathInfo, string queryString, bool setClientFilePath);
+        public override void SetSessionStateBehavior(SessionStateBehavior sessionStateBehavior);
+    }
+    public sealed class HttpCookie {
+        public HttpCookie(string name);
+        public HttpCookie(string name, string value);
+        public string Domain { get; set; }
+        public DateTime Expires { get; set; }
+        public bool HasKeys { get; }
+        public bool HttpOnly { get; set; }
+        public string Name { get; set; }
+        public string Path { get; set; }
+        public bool Secure { get; set; }
+        public bool Shareable { get; set; }
+        public string this[string key] { get; set; }
+        public string Value { get; set; }
+        public NameValueCollection Values { get; }
+    }
+    public sealed class HttpCookieCollection : NameObjectCollectionBase {
+        public HttpCookieCollection();
+        public string[] AllKeys { get; }
+        public HttpCookie this[int index] { get; }
+        public HttpCookie this[string name] { get; }
+        public void Add(HttpCookie cookie);
+        public void Clear();
+        public void CopyTo(Array dest, int index);
+        public HttpCookie Get(int index);
+        public HttpCookie Get(string name);
+        public string GetKey(int index);
+        public void Remove(string name);
+        public void Set(HttpCookie cookie);
+    }
+    public enum HttpCookieMode {
+        AutoDetect = 2,
+        UseCookies = 1,
+        UseDeviceProfile = 3,
+        UseUri = 0,
+    }
+    public class HttpException : ExternalException {
+        public HttpException();
+        public HttpException(int httpCode, string message);
+        public HttpException(int httpCode, string message, Exception innerException);
+        public HttpException(int httpCode, string message, int hr);
+        protected HttpException(SerializationInfo info, StreamingContext context);
+        public HttpException(string message);
+        public HttpException(string message, Exception innerException);
+        public HttpException(string message, int hr);
+        public int WebEventCode { get; internal set; }
+        public static HttpException CreateFromLastError(string message);
+        public string GetHtmlErrorMessage();
+        public int GetHttpCode();
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public sealed class HttpFileCollection : NameObjectCollectionBase {
+        public string[] AllKeys { get; }
+        public HttpPostedFile this[int index] { get; }
+        public HttpPostedFile this[string name] { get; }
+        public void CopyTo(Array dest, int index);
+        public HttpPostedFile Get(int index);
+        public HttpPostedFile Get(string name);
+        public string GetKey(int index);
+        public IList<HttpPostedFile> GetMultiple(string name);
+    }
+    public abstract class HttpFileCollectionBase : NameObjectCollectionBase, ICollection, IEnumerable {
+        protected HttpFileCollectionBase();
+        public virtual string[] AllKeys { get; }
+        public override int Count { get; }
+        public virtual bool IsSynchronized { get; }
+        public virtual object SyncRoot { get; }
+        public virtual HttpPostedFileBase this[int index] { get; }
+        public virtual HttpPostedFileBase this[string name] { get; }
+        public virtual void CopyTo(Array dest, int index);
+        public virtual HttpPostedFileBase Get(int index);
+        public virtual HttpPostedFileBase Get(string name);
+        public override IEnumerator GetEnumerator();
+        public virtual string GetKey(int index);
+        public virtual IList<HttpPostedFileBase> GetMultiple(string name);
+    }
+    public class HttpFileCollectionWrapper : HttpFileCollectionBase {
+        public HttpFileCollectionWrapper(HttpFileCollection httpFileCollection);
+        public override string[] AllKeys { get; }
+        public override int Count { get; }
+        public override bool IsSynchronized { get; }
+        public override NameObjectCollectionBase.KeysCollection Keys { get; }
+        public override object SyncRoot { get; }
+        public override HttpPostedFileBase this[int index] { get; }
+        public override HttpPostedFileBase this[string name] { get; }
+        public override void CopyTo(Array dest, int index);
+        public override HttpPostedFileBase Get(int index);
+        public override HttpPostedFileBase Get(string name);
+        public override IEnumerator GetEnumerator();
+        public override string GetKey(int index);
+        public override IList<HttpPostedFileBase> GetMultiple(string name);
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+        public override void OnDeserialization(object sender);
+    }
+    public sealed class HttpModuleCollection : NameObjectCollectionBase {
+        public string[] AllKeys { get; }
+        public IHttpModule this[int index] { get; }
+        public IHttpModule this[string name] { get; }
+        public void CopyTo(Array dest, int index);
+        public IHttpModule Get(int index);
+        public IHttpModule Get(string name);
+        public string GetKey(int index);
+    }
+    public sealed class HttpParseException : HttpException {
+        public HttpParseException();
+        public HttpParseException(string message);
+        public HttpParseException(string message, Exception innerException);
+        public HttpParseException(string message, Exception innerException, string virtualPath, string sourceCode, int line);
+        public string FileName { get; }
+        public int Line { get; }
+        public ParserErrorCollection ParserErrors { get; }
+        public string VirtualPath { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public sealed class HttpPostedFile {
+        public int ContentLength { get; }
+        public string ContentType { get; }
+        public string FileName { get; }
+        public Stream InputStream { get; }
+        public void SaveAs(string filename);
+    }
+    public abstract class HttpPostedFileBase {
+        protected HttpPostedFileBase();
+        public virtual int ContentLength { get; }
+        public virtual string ContentType { get; }
+        public virtual string FileName { get; }
+        public virtual Stream InputStream { get; }
+        public virtual void SaveAs(string filename);
+    }
+    public class HttpPostedFileWrapper : HttpPostedFileBase {
+        public HttpPostedFileWrapper(HttpPostedFile httpPostedFile);
+        public override int ContentLength { get; }
+        public override string ContentType { get; }
+        public override string FileName { get; }
+        public override Stream InputStream { get; }
+        public override void SaveAs(string filename);
+    }
+    public sealed class HttpRequest {
+        public HttpRequest(string filename, string url, string queryString);
+        public string[] AcceptTypes { get; }
+        public string AnonymousID { get; internal set; }
+        public string ApplicationPath { get; }
+        public string AppRelativeCurrentExecutionFilePath { get; }
+        public HttpBrowserCapabilities Browser { get; set; }
+        public HttpClientCertificate ClientCertificate { get; }
+        public Encoding ContentEncoding { get; set; }
+        public int ContentLength { get; }
+        public string ContentType { get; set; }
+        public HttpCookieCollection Cookies { get; }
+        public string CurrentExecutionFilePath { get; }
+        public string CurrentExecutionFilePathExtension { get; }
+        public string FilePath { get; }
+        public HttpFileCollection Files { get; }
+        public Stream Filter { get; set; }
+        public NameValueCollection Form { get; }
+        public NameValueCollection Headers { get; }
+        public ChannelBinding HttpChannelBinding { get; }
+        public string HttpMethod { get; }
+        public Stream InputStream { get; }
+        public bool IsAuthenticated { get; }
+        public bool IsLocal { get; }
+        public bool IsSecureConnection { get; }
+        public WindowsIdentity LogonUserIdentity { get; }
+        public NameValueCollection Params { get; }
+        public string Path { get; }
+        public string PathInfo { get; }
+        public string PhysicalApplicationPath { get; }
+        public string PhysicalPath { get; }
+        public NameValueCollection QueryString { get; }
+        public string RawUrl { get; internal set; }
+        public ReadEntityBodyMode ReadEntityBodyMode { get; }
+        public RequestContext RequestContext { get; set; }
+        public string RequestType { get; set; }
+        public NameValueCollection ServerVariables { get; }
+        public string this[string key] { get; }
+        public CancellationToken TimedOutToken { get; }
+        public ITlsTokenBindingInfo TlsTokenBindingInfo { get; }
+        public int TotalBytes { get; }
+        public UnvalidatedRequestValues Unvalidated { get; }
+        public Uri Url { get; }
+        public Uri UrlReferrer { get; }
+        public string UserAgent { get; }
+        public string UserHostAddress { get; }
+        public string UserHostName { get; }
+        public string[] UserLanguages { get; }
+        public void Abort();
+        public byte[] BinaryRead(int count);
+        public Stream GetBufferedInputStream();
+        public Stream GetBufferlessInputStream();
+        public Stream GetBufferlessInputStream(bool disableMaxRequestLength);
+        public void InsertEntityBody();
+        public void InsertEntityBody(byte[] buffer, int offset, int count);
+        public int[] MapImageCoordinates(string imageFieldName);
+        public string MapPath(string virtualPath);
+        public string MapPath(string virtualPath, string baseVirtualDir, bool allowCrossAppMapping);
+        public double[] MapRawImageCoordinates(string imageFieldName);
+        public void SaveAs(string filename, bool includeHeaders);
+        public void ValidateInput();
+    }
+    public abstract class HttpRequestBase {
+        protected HttpRequestBase();
+        public virtual string[] AcceptTypes { get; }
+        public virtual string AnonymousID { get; }
+        public virtual string ApplicationPath { get; }
+        public virtual string AppRelativeCurrentExecutionFilePath { get; }
+        public virtual HttpBrowserCapabilitiesBase Browser { get; }
+        public virtual HttpClientCertificate ClientCertificate { get; }
+        public virtual Encoding ContentEncoding { get; set; }
+        public virtual int ContentLength { get; }
+        public virtual string ContentType { get; set; }
+        public virtual HttpCookieCollection Cookies { get; }
+        public virtual string CurrentExecutionFilePath { get; }
+        public virtual string CurrentExecutionFilePathExtension { get; }
+        public virtual string FilePath { get; }
+        public virtual HttpFileCollectionBase Files { get; }
+        public virtual Stream Filter { get; set; }
+        public virtual NameValueCollection Form { get; }
+        public virtual NameValueCollection Headers { get; }
+        public virtual ChannelBinding HttpChannelBinding { get; }
+        public virtual string HttpMethod { get; }
+        public virtual Stream InputStream { get; }
+        public virtual bool IsAuthenticated { get; }
+        public virtual bool IsLocal { get; }
+        public virtual bool IsSecureConnection { get; }
+        public virtual WindowsIdentity LogonUserIdentity { get; }
+        public virtual NameValueCollection Params { get; }
+        public virtual string Path { get; }
+        public virtual string PathInfo { get; }
+        public virtual string PhysicalApplicationPath { get; }
+        public virtual string PhysicalPath { get; }
+        public virtual NameValueCollection QueryString { get; }
+        public virtual string RawUrl { get; }
+        public virtual ReadEntityBodyMode ReadEntityBodyMode { get; }
+        public virtual RequestContext RequestContext { get; set; }
+        public virtual string RequestType { get; set; }
+        public virtual NameValueCollection ServerVariables { get; }
+        public virtual string this[string key] { get; }
+        public virtual CancellationToken TimedOutToken { get; }
+        public virtual ITlsTokenBindingInfo TlsTokenBindingInfo { get; }
+        public virtual int TotalBytes { get; }
+        public virtual UnvalidatedRequestValuesBase Unvalidated { get; }
+        public virtual Uri Url { get; }
+        public virtual Uri UrlReferrer { get; }
+        public virtual string UserAgent { get; }
+        public virtual string UserHostAddress { get; }
+        public virtual string UserHostName { get; }
+        public virtual string[] UserLanguages { get; }
+        public virtual void Abort();
+        public virtual byte[] BinaryRead(int count);
+        public virtual Stream GetBufferedInputStream();
+        public virtual Stream GetBufferlessInputStream();
+        public virtual Stream GetBufferlessInputStream(bool disableMaxRequestLength);
+        public virtual void InsertEntityBody();
+        public virtual void InsertEntityBody(byte[] buffer, int offset, int count);
+        public virtual int[] MapImageCoordinates(string imageFieldName);
+        public virtual string MapPath(string virtualPath);
+        public virtual string MapPath(string virtualPath, string baseVirtualDir, bool allowCrossAppMapping);
+        public virtual double[] MapRawImageCoordinates(string imageFieldName);
+        public virtual void SaveAs(string filename, bool includeHeaders);
+        public virtual void ValidateInput();
+    }
+    public sealed class HttpRequestValidationException : HttpException {
+        public HttpRequestValidationException();
+        public HttpRequestValidationException(string message);
+        public HttpRequestValidationException(string message, Exception innerException);
+    }
+    public class HttpRequestWrapper : HttpRequestBase {
+        public HttpRequestWrapper(HttpRequest httpRequest);
+        public override string[] AcceptTypes { get; }
+        public override string AnonymousID { get; }
+        public override string ApplicationPath { get; }
+        public override string AppRelativeCurrentExecutionFilePath { get; }
+        public override HttpBrowserCapabilitiesBase Browser { get; }
+        public override HttpClientCertificate ClientCertificate { get; }
+        public override Encoding ContentEncoding { get; set; }
+        public override int ContentLength { get; }
+        public override string ContentType { get; set; }
+        public override HttpCookieCollection Cookies { get; }
+        public override string CurrentExecutionFilePath { get; }
+        public override string CurrentExecutionFilePathExtension { get; }
+        public override string FilePath { get; }
+        public override HttpFileCollectionBase Files { get; }
+        public override Stream Filter { get; set; }
+        public override NameValueCollection Form { get; }
+        public override NameValueCollection Headers { get; }
+        public override ChannelBinding HttpChannelBinding { get; }
+        public override string HttpMethod { get; }
+        public override Stream InputStream { get; }
+        public override bool IsAuthenticated { get; }
+        public override bool IsLocal { get; }
+        public override bool IsSecureConnection { get; }
+        public override WindowsIdentity LogonUserIdentity { get; }
+        public override NameValueCollection Params { get; }
+        public override string Path { get; }
+        public override string PathInfo { get; }
+        public override string PhysicalApplicationPath { get; }
+        public override string PhysicalPath { get; }
+        public override NameValueCollection QueryString { get; }
+        public override string RawUrl { get; }
+        public override ReadEntityBodyMode ReadEntityBodyMode { get; }
+        public override RequestContext RequestContext { get; set; }
+        public override string RequestType { get; set; }
+        public override NameValueCollection ServerVariables { get; }
+        public override string this[string key] { get; }
+        public override CancellationToken TimedOutToken { get; }
+        public override ITlsTokenBindingInfo TlsTokenBindingInfo { get; }
+        public override int TotalBytes { get; }
+        public override UnvalidatedRequestValuesBase Unvalidated { get; }
+        public override Uri Url { get; }
+        public override Uri UrlReferrer { get; }
+        public override string UserAgent { get; }
+        public override string UserHostAddress { get; }
+        public override string UserHostName { get; }
+        public override string[] UserLanguages { get; }
+        public override void Abort();
+        public override byte[] BinaryRead(int count);
+        public override Stream GetBufferedInputStream();
+        public override Stream GetBufferlessInputStream();
+        public override Stream GetBufferlessInputStream(bool disableMaxRequestLength);
+        public override void InsertEntityBody();
+        public override void InsertEntityBody(byte[] buffer, int offset, int count);
+        public override int[] MapImageCoordinates(string imageFieldName);
+        public override string MapPath(string virtualPath);
+        public override string MapPath(string virtualPath, string baseVirtualDir, bool allowCrossAppMapping);
+        public override double[] MapRawImageCoordinates(string imageFieldName);
+        public override void SaveAs(string filename, bool includeHeaders);
+        public override void ValidateInput();
+    }
+    public sealed class HttpResponse {
+        public HttpResponse(TextWriter writer);
+        public bool Buffer { get; set; }
+        public bool BufferOutput { get; set; }
+        public HttpCachePolicy Cache { get; }
+        public string CacheControl { get; set; }
+        public string Charset { get; set; }
+        public CancellationToken ClientDisconnectedToken { get; }
+        public Encoding ContentEncoding { get; set; }
+        public string ContentType { get; set; }
+        public HttpCookieCollection Cookies { get; }
+        public int Expires { get; set; }
+        public DateTime ExpiresAbsolute { get; set; }
+        public Stream Filter { get; set; }
+        public Encoding HeaderEncoding { get; set; }
+        public NameValueCollection Headers { get; }
+        public bool HeadersWritten { get; internal set; }
+        public bool IsClientConnected { get; }
+        public bool IsRequestBeingRedirected { get; internal set; }
+        public TextWriter Output { get; set; }
+        public Stream OutputStream { get; }
+        public string RedirectLocation { get; set; }
+        public string Status { get; set; }
+        public int StatusCode { get; set; }
+        public string StatusDescription { get; set; }
+        public int SubStatusCode { get; set; }
+        public bool SupportsAsyncFlush { get; }
+        public bool SuppressContent { get; set; }
+        public bool SuppressDefaultCacheControlHeader { get; set; }
+        public bool SuppressFormsAuthenticationRedirect { get; set; }
+        public bool TrySkipIisCustomErrors { get; set; }
+        public void AddCacheDependency(params CacheDependency[] dependencies);
+        public void AddCacheItemDependencies(ArrayList cacheKeys);
+        public void AddCacheItemDependencies(string[] cacheKeys);
+        public void AddCacheItemDependency(string cacheKey);
+        public void AddFileDependencies(ArrayList filenames);
+        public void AddFileDependencies(string[] filenames);
+        public void AddFileDependency(string filename);
+        public void AddHeader(string name, string value);
+        public ISubscriptionToken AddOnSendingHeaders(Action<HttpContext> callback);
+        public void AppendCookie(HttpCookie cookie);
+        public void AppendHeader(string name, string value);
+        public void AppendToLog(string param);
+        public string ApplyAppPathModifier(string virtualPath);
+        public IAsyncResult BeginFlush(AsyncCallback callback, object state);
+        public void BinaryWrite(byte[] buffer);
+        public void Clear();
+        public void ClearContent();
+        public void ClearHeaders();
+        public void Close();
+        public void DisableKernelCache();
+        public void DisableUserCache();
+        public void End();
+        public void EndFlush(IAsyncResult asyncResult);
+        public void Flush();
+        public Task FlushAsync();
+        public void Pics(string value);
+        public void PushPromise(string path);
+        public void PushPromise(string path, string method, NameValueCollection headers);
+        public void Redirect(string url);
+        public void Redirect(string url, bool endResponse);
+        public void RedirectPermanent(string url);
+        public void RedirectPermanent(string url, bool endResponse);
+        public void RedirectToRoute(object routeValues);
+        public void RedirectToRoute(string routeName);
+        public void RedirectToRoute(string routeName, object routeValues);
+        public void RedirectToRoute(string routeName, RouteValueDictionary routeValues);
+        public void RedirectToRoute(RouteValueDictionary routeValues);
+        public void RedirectToRoutePermanent(object routeValues);
+        public void RedirectToRoutePermanent(string routeName);
+        public void RedirectToRoutePermanent(string routeName, object routeValues);
+        public void RedirectToRoutePermanent(string routeName, RouteValueDictionary routeValues);
+        public void RedirectToRoutePermanent(RouteValueDictionary routeValues);
+        public static void RemoveOutputCacheItem(string path);
+        public static void RemoveOutputCacheItem(string path, string providerName);
+        public void SetCookie(HttpCookie cookie);
+        public void TransmitFile(string filename);
+        public void TransmitFile(string filename, long offset, long length);
+        public void Write(char ch);
+        public void Write(char[] buffer, int index, int count);
+        public void Write(object obj);
+        public void Write(string s);
+        public void WriteFile(IntPtr fileHandle, long offset, long size);
+        public void WriteFile(string filename);
+        public void WriteFile(string filename, bool readIntoMemory);
+        public void WriteFile(string filename, long offset, long size);
+        public void WriteSubstitution(HttpResponseSubstitutionCallback callback);
+    }
+    public abstract class HttpResponseBase {
+        protected HttpResponseBase();
+        public virtual bool Buffer { get; set; }
+        public virtual bool BufferOutput { get; set; }
+        public virtual HttpCachePolicyBase Cache { get; }
+        public virtual string CacheControl { get; set; }
+        public virtual string Charset { get; set; }
+        public virtual CancellationToken ClientDisconnectedToken { get; }
+        public virtual Encoding ContentEncoding { get; set; }
+        public virtual string ContentType { get; set; }
+        public virtual HttpCookieCollection Cookies { get; }
+        public virtual int Expires { get; set; }
+        public virtual DateTime ExpiresAbsolute { get; set; }
+        public virtual Stream Filter { get; set; }
+        public virtual Encoding HeaderEncoding { get; set; }
+        public virtual NameValueCollection Headers { get; }
+        public virtual bool HeadersWritten { get; }
+        public virtual bool IsClientConnected { get; }
+        public virtual bool IsRequestBeingRedirected { get; }
+        public virtual TextWriter Output { get; set; }
+        public virtual Stream OutputStream { get; }
+        public virtual string RedirectLocation { get; set; }
+        public virtual string Status { get; set; }
+        public virtual int StatusCode { get; set; }
+        public virtual string StatusDescription { get; set; }
+        public virtual int SubStatusCode { get; set; }
+        public virtual bool SupportsAsyncFlush { get; }
+        public virtual bool SuppressContent { get; set; }
+        public virtual bool SuppressDefaultCacheControlHeader { get; set; }
+        public virtual bool SuppressFormsAuthenticationRedirect { get; set; }
+        public virtual bool TrySkipIisCustomErrors { get; set; }
+        public virtual void AddCacheDependency(params CacheDependency[] dependencies);
+        public virtual void AddCacheItemDependencies(ArrayList cacheKeys);
+        public virtual void AddCacheItemDependencies(string[] cacheKeys);
+        public virtual void AddCacheItemDependency(string cacheKey);
+        public virtual void AddFileDependencies(ArrayList filenames);
+        public virtual void AddFileDependencies(string[] filenames);
+        public virtual void AddFileDependency(string filename);
+        public virtual void AddHeader(string name, string value);
+        public virtual ISubscriptionToken AddOnSendingHeaders(Action<HttpContextBase> callback);
+        public virtual void AppendCookie(HttpCookie cookie);
+        public virtual void AppendHeader(string name, string value);
+        public virtual void AppendToLog(string param);
+        public virtual string ApplyAppPathModifier(string virtualPath);
+        public virtual IAsyncResult BeginFlush(AsyncCallback callback, object state);
+        public virtual void BinaryWrite(byte[] buffer);
+        public virtual void Clear();
+        public virtual void ClearContent();
+        public virtual void ClearHeaders();
+        public virtual void Close();
+        public virtual void DisableKernelCache();
+        public virtual void DisableUserCache();
+        public virtual void End();
+        public virtual void EndFlush(IAsyncResult asyncResult);
+        public virtual void Flush();
+        public virtual Task FlushAsync();
+        public virtual void Pics(string value);
+        public virtual void PushPromise(string path);
+        public virtual void PushPromise(string path, string method, NameValueCollection headers);
+        public virtual void Redirect(string url);
+        public virtual void Redirect(string url, bool endResponse);
+        public virtual void RedirectPermanent(string url);
+        public virtual void RedirectPermanent(string url, bool endResponse);
+        public virtual void RedirectToRoute(object routeValues);
+        public virtual void RedirectToRoute(string routeName);
+        public virtual void RedirectToRoute(string routeName, object routeValues);
+        public virtual void RedirectToRoute(string routeName, RouteValueDictionary routeValues);
+        public virtual void RedirectToRoute(RouteValueDictionary routeValues);
+        public virtual void RedirectToRoutePermanent(object routeValues);
+        public virtual void RedirectToRoutePermanent(string routeName);
+        public virtual void RedirectToRoutePermanent(string routeName, object routeValues);
+        public virtual void RedirectToRoutePermanent(string routeName, RouteValueDictionary routeValues);
+        public virtual void RedirectToRoutePermanent(RouteValueDictionary routeValues);
+        public virtual void RemoveOutputCacheItem(string path);
+        public virtual void RemoveOutputCacheItem(string path, string providerName);
+        public virtual void SetCookie(HttpCookie cookie);
+        public virtual void TransmitFile(string filename);
+        public virtual void TransmitFile(string filename, long offset, long length);
+        public virtual void Write(char ch);
+        public virtual void Write(char[] buffer, int index, int count);
+        public virtual void Write(object obj);
+        public virtual void Write(string s);
+        public virtual void WriteFile(IntPtr fileHandle, long offset, long size);
+        public virtual void WriteFile(string filename);
+        public virtual void WriteFile(string filename, bool readIntoMemory);
+        public virtual void WriteFile(string filename, long offset, long size);
+        public virtual void WriteSubstitution(HttpResponseSubstitutionCallback callback);
+    }
+    public delegate string HttpResponseSubstitutionCallback(HttpContext context);
+    public class HttpResponseWrapper : HttpResponseBase {
+        public HttpResponseWrapper(HttpResponse httpResponse);
+        public override bool Buffer { get; set; }
+        public override bool BufferOutput { get; set; }
+        public override HttpCachePolicyBase Cache { get; }
+        public override string CacheControl { get; set; }
+        public override string Charset { get; set; }
+        public override CancellationToken ClientDisconnectedToken { get; }
+        public override Encoding ContentEncoding { get; set; }
+        public override string ContentType { get; set; }
+        public override HttpCookieCollection Cookies { get; }
+        public override int Expires { get; set; }
+        public override DateTime ExpiresAbsolute { get; set; }
+        public override Stream Filter { get; set; }
+        public override Encoding HeaderEncoding { get; set; }
+        public override NameValueCollection Headers { get; }
+        public override bool HeadersWritten { get; }
+        public override bool IsClientConnected { get; }
+        public override bool IsRequestBeingRedirected { get; }
+        public override TextWriter Output { get; set; }
+        public override Stream OutputStream { get; }
+        public override string RedirectLocation { get; set; }
+        public override string Status { get; set; }
+        public override int StatusCode { get; set; }
+        public override string StatusDescription { get; set; }
+        public override int SubStatusCode { get; set; }
+        public override bool SupportsAsyncFlush { get; }
+        public override bool SuppressContent { get; set; }
+        public override bool SuppressDefaultCacheControlHeader { get; set; }
+        public override bool SuppressFormsAuthenticationRedirect { get; set; }
+        public override bool TrySkipIisCustomErrors { get; set; }
+        public override void AddCacheDependency(params CacheDependency[] dependencies);
+        public override void AddCacheItemDependencies(ArrayList cacheKeys);
+        public override void AddCacheItemDependencies(string[] cacheKeys);
+        public override void AddCacheItemDependency(string cacheKey);
+        public override void AddFileDependencies(ArrayList filenames);
+        public override void AddFileDependencies(string[] filenames);
+        public override void AddFileDependency(string filename);
+        public override void AddHeader(string name, string value);
+        public override ISubscriptionToken AddOnSendingHeaders(Action<HttpContextBase> callback);
+        public override void AppendCookie(HttpCookie cookie);
+        public override void AppendHeader(string name, string value);
+        public override void AppendToLog(string param);
+        public override string ApplyAppPathModifier(string virtualPath);
+        public override IAsyncResult BeginFlush(AsyncCallback callback, object state);
+        public override void BinaryWrite(byte[] buffer);
+        public override void Clear();
+        public override void ClearContent();
+        public override void ClearHeaders();
+        public override void Close();
+        public override void DisableKernelCache();
+        public override void DisableUserCache();
+        public override void End();
+        public override void EndFlush(IAsyncResult asyncResult);
+        public override void Flush();
+        public override Task FlushAsync();
+        public override void Pics(string value);
+        public override void PushPromise(string path);
+        public override void PushPromise(string path, string method, NameValueCollection headers);
+        public override void Redirect(string url);
+        public override void Redirect(string url, bool endResponse);
+        public override void RedirectPermanent(string url);
+        public override void RedirectPermanent(string url, bool endResponse);
+        public override void RedirectToRoute(object routeValues);
+        public override void RedirectToRoute(string routeName);
+        public override void RedirectToRoute(string routeName, object routeValues);
+        public override void RedirectToRoute(string routeName, RouteValueDictionary routeValues);
+        public override void RedirectToRoute(RouteValueDictionary routeValues);
+        public override void RedirectToRoutePermanent(object routeValues);
+        public override void RedirectToRoutePermanent(string routeName);
+        public override void RedirectToRoutePermanent(string routeName, object routeValues);
+        public override void RedirectToRoutePermanent(string routeName, RouteValueDictionary routeValues);
+        public override void RedirectToRoutePermanent(RouteValueDictionary routeValues);
+        public override void RemoveOutputCacheItem(string path);
+        public override void RemoveOutputCacheItem(string path, string providerName);
+        public override void SetCookie(HttpCookie cookie);
+        public override void TransmitFile(string filename);
+        public override void TransmitFile(string filename, long offset, long length);
+        public override void Write(char ch);
+        public override void Write(char[] buffer, int index, int count);
+        public override void Write(object obj);
+        public override void Write(string s);
+        public override void WriteFile(IntPtr fileHandle, long offset, long size);
+        public override void WriteFile(string filename);
+        public override void WriteFile(string filename, bool readIntoMemory);
+        public override void WriteFile(string filename, long offset, long size);
+        public override void WriteSubstitution(HttpResponseSubstitutionCallback callback);
+    }
+    public sealed class HttpRuntime {
+        public HttpRuntime();
+        public static string AppDomainAppId { get; }
+        public static string AppDomainAppPath { get; }
+        public static string AppDomainAppVirtualPath { get; }
+        public static string AppDomainId { get; }
+        public static string AspClientScriptPhysicalPath { get; }
+        public static string AspClientScriptVirtualPath { get; }
+        public static string AspInstallDirectory { get; }
+        public static string BinDirectory { get; }
+        public static Cache Cache { get; }
+        public static string ClrInstallDirectory { get; }
+        public static string CodegenDir { get; }
+        public static Version IISVersion { get; }
+        public static bool IsOnUNCShare { get; }
+        public static string MachineConfigurationDirectory { get; }
+        public static Version TargetFramework { get; }
+        public static bool UsingIntegratedPipeline { get; }
+        public static void Close();
+        public static NamedPermissionSet GetNamedPermissionSet();
+        public static void ProcessRequest(HttpWorkerRequest wr);
+        public static void UnloadAppDomain();
+    }
+    public sealed class HttpServerUtility {
+        public string MachineName { get; }
+        public int ScriptTimeout { get; set; }
+        public void ClearError();
+        public object CreateObject(string progID);
+        public object CreateObject(Type type);
+        public object CreateObjectFromClsid(string clsid);
+        public void Execute(string path);
+        public void Execute(string path, bool preserveForm);
+        public void Execute(string path, TextWriter writer);
+        public void Execute(string path, TextWriter writer, bool preserveForm);
+        public void Execute(IHttpHandler handler, TextWriter writer, bool preserveForm);
+        public Exception GetLastError();
+        public string HtmlDecode(string s);
+        public void HtmlDecode(string s, TextWriter output);
+        public string HtmlEncode(string s);
+        public void HtmlEncode(string s, TextWriter output);
+        public string MapPath(string path);
+        public void Transfer(string path);
+        public void Transfer(string path, bool preserveForm);
+        public void Transfer(IHttpHandler handler, bool preserveForm);
+        public void TransferRequest(string path);
+        public void TransferRequest(string path, bool preserveForm);
+        public void TransferRequest(string path, bool preserveForm, string method, NameValueCollection headers);
+        public void TransferRequest(string path, bool preserveForm, string method, NameValueCollection headers, bool preserveUser);
+        public string UrlDecode(string s);
+        public void UrlDecode(string s, TextWriter output);
+        public string UrlEncode(string s);
+        public void UrlEncode(string s, TextWriter output);
+        public string UrlPathEncode(string s);
+        public static byte[] UrlTokenDecode(string input);
+        public static string UrlTokenEncode(byte[] input);
+    }
+    public abstract class HttpServerUtilityBase {
+        protected HttpServerUtilityBase();
+        public virtual string MachineName { get; }
+        public virtual int ScriptTimeout { get; set; }
+        public virtual void ClearError();
+        public virtual object CreateObject(string progID);
+        public virtual object CreateObject(Type type);
+        public virtual object CreateObjectFromClsid(string clsid);
+        public virtual void Execute(string path);
+        public virtual void Execute(string path, bool preserveForm);
+        public virtual void Execute(string path, TextWriter writer);
+        public virtual void Execute(string path, TextWriter writer, bool preserveForm);
+        public virtual void Execute(IHttpHandler handler, TextWriter writer, bool preserveForm);
+        public virtual Exception GetLastError();
+        public virtual string HtmlDecode(string s);
+        public virtual void HtmlDecode(string s, TextWriter output);
+        public virtual string HtmlEncode(string s);
+        public virtual void HtmlEncode(string s, TextWriter output);
+        public virtual string MapPath(string path);
+        public virtual void Transfer(string path);
+        public virtual void Transfer(string path, bool preserveForm);
+        public virtual void Transfer(IHttpHandler handler, bool preserveForm);
+        public virtual void TransferRequest(string path);
+        public virtual void TransferRequest(string path, bool preserveForm);
+        public virtual void TransferRequest(string path, bool preserveForm, string method, NameValueCollection headers);
+        public virtual void TransferRequest(string path, bool preserveForm, string method, NameValueCollection headers, bool preserveUser);
+        public virtual string UrlDecode(string s);
+        public virtual void UrlDecode(string s, TextWriter output);
+        public virtual string UrlEncode(string s);
+        public virtual void UrlEncode(string s, TextWriter output);
+        public virtual string UrlPathEncode(string s);
+        public virtual byte[] UrlTokenDecode(string input);
+        public virtual string UrlTokenEncode(byte[] input);
+    }
+    public class HttpServerUtilityWrapper : HttpServerUtilityBase {
+        public HttpServerUtilityWrapper(HttpServerUtility httpServerUtility);
+        public override string MachineName { get; }
+        public override int ScriptTimeout { get; set; }
+        public override void ClearError();
+        public override object CreateObject(string progID);
+        public override object CreateObject(Type type);
+        public override object CreateObjectFromClsid(string clsid);
+        public override void Execute(string path);
+        public override void Execute(string path, bool preserveForm);
+        public override void Execute(string path, TextWriter writer);
+        public override void Execute(string path, TextWriter writer, bool preserveForm);
+        public override void Execute(IHttpHandler handler, TextWriter writer, bool preserveForm);
+        public override Exception GetLastError();
+        public override string HtmlDecode(string s);
+        public override void HtmlDecode(string s, TextWriter output);
+        public override string HtmlEncode(string s);
+        public override void HtmlEncode(string s, TextWriter output);
+        public override string MapPath(string path);
+        public override void Transfer(string path);
+        public override void Transfer(string path, bool preserveForm);
+        public override void Transfer(IHttpHandler handler, bool preserveForm);
+        public override void TransferRequest(string path);
+        public override void TransferRequest(string path, bool preserveForm);
+        public override void TransferRequest(string path, bool preserveForm, string method, NameValueCollection headers);
+        public override void TransferRequest(string path, bool preserveForm, string method, NameValueCollection headers, bool preserveUser);
+        public override string UrlDecode(string s);
+        public override void UrlDecode(string s, TextWriter output);
+        public override string UrlEncode(string s);
+        public override void UrlEncode(string s, TextWriter output);
+        public override string UrlPathEncode(string s);
+        public override byte[] UrlTokenDecode(string input);
+        public override string UrlTokenEncode(byte[] input);
+    }
+    public abstract class HttpSessionStateBase : ICollection, IEnumerable {
+        protected HttpSessionStateBase();
+        public virtual int CodePage { get; set; }
+        public virtual HttpSessionStateBase Contents { get; }
+        public virtual HttpCookieMode CookieMode { get; }
+        public virtual int Count { get; }
+        public virtual bool IsCookieless { get; }
+        public virtual bool IsNewSession { get; }
+        public virtual bool IsReadOnly { get; }
+        public virtual bool IsSynchronized { get; }
+        public virtual NameObjectCollectionBase.KeysCollection Keys { get; }
+        public virtual int LCID { get; set; }
+        public virtual SessionStateMode Mode { get; }
+        public virtual string SessionID { get; }
+        public virtual HttpStaticObjectsCollectionBase StaticObjects { get; }
+        public virtual object SyncRoot { get; }
+        public virtual object this[int index] { get; set; }
+        public virtual object this[string name] { get; set; }
+        public virtual int Timeout { get; set; }
+        public virtual void Abandon();
+        public virtual void Add(string name, object value);
+        public virtual void Clear();
+        public virtual void CopyTo(Array array, int index);
+        public virtual IEnumerator GetEnumerator();
+        public virtual void Remove(string name);
+        public virtual void RemoveAll();
+        public virtual void RemoveAt(int index);
+    }
+    public class HttpSessionStateWrapper : HttpSessionStateBase {
+        public HttpSessionStateWrapper(HttpSessionState httpSessionState);
+        public override int CodePage { get; set; }
+        public override HttpSessionStateBase Contents { get; }
+        public override HttpCookieMode CookieMode { get; }
+        public override int Count { get; }
+        public override bool IsCookieless { get; }
+        public override bool IsNewSession { get; }
+        public override bool IsReadOnly { get; }
+        public override bool IsSynchronized { get; }
+        public override NameObjectCollectionBase.KeysCollection Keys { get; }
+        public override int LCID { get; set; }
+        public override SessionStateMode Mode { get; }
+        public override string SessionID { get; }
+        public override HttpStaticObjectsCollectionBase StaticObjects { get; }
+        public override object SyncRoot { get; }
+        public override object this[int index] { get; set; }
+        public override object this[string name] { get; set; }
+        public override int Timeout { get; set; }
+        public override void Abandon();
+        public override void Add(string name, object value);
+        public override void Clear();
+        public override void CopyTo(Array array, int index);
+        public override IEnumerator GetEnumerator();
+        public override void Remove(string name);
+        public override void RemoveAll();
+        public override void RemoveAt(int index);
+    }
+    public sealed class HttpStaticObjectsCollection : ICollection, IEnumerable {
+        public HttpStaticObjectsCollection();
+        public int Count { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public bool NeverAccessed { get; }
+        public object SyncRoot { get; }
+        public object this[string name] { get; }
+        public void CopyTo(Array array, int index);
+        public static HttpStaticObjectsCollection Deserialize(BinaryReader reader);
+        public IEnumerator GetEnumerator();
+        public object GetObject(string name);
+        public void Serialize(BinaryWriter writer);
+    }
+    public abstract class HttpStaticObjectsCollectionBase : ICollection, IEnumerable {
+        protected HttpStaticObjectsCollectionBase();
+        public virtual int Count { get; }
+        public virtual bool IsReadOnly { get; }
+        public virtual bool IsSynchronized { get; }
+        public virtual bool NeverAccessed { get; }
+        public virtual object SyncRoot { get; }
+        public virtual object this[string name] { get; }
+        public virtual void CopyTo(Array array, int index);
+        public virtual IEnumerator GetEnumerator();
+        public virtual object GetObject(string name);
+        public virtual void Serialize(BinaryWriter writer);
+    }
+    public class HttpStaticObjectsCollectionWrapper : HttpStaticObjectsCollectionBase {
+        public HttpStaticObjectsCollectionWrapper(HttpStaticObjectsCollection httpStaticObjectsCollection);
+        public override int Count { get; }
+        public override bool IsReadOnly { get; }
+        public override bool IsSynchronized { get; }
+        public override bool NeverAccessed { get; }
+        public override object SyncRoot { get; }
+        public override object this[string name] { get; }
+        public override void CopyTo(Array array, int index);
+        public override IEnumerator GetEnumerator();
+        public override object GetObject(string name);
+        public override void Serialize(BinaryWriter writer);
+    }
+    public abstract class HttpTaskAsyncHandler : IHttpAsyncHandler, IHttpHandler {
+        protected HttpTaskAsyncHandler();
+        public virtual bool IsReusable { get; }
+        public virtual void ProcessRequest(HttpContext context);
+        public abstract Task ProcessRequestAsync(HttpContext context);
+        IAsyncResult System.Web.IHttpAsyncHandler.BeginProcessRequest(HttpContext context, AsyncCallback cb, object extraData);
+        void System.Web.IHttpAsyncHandler.EndProcessRequest(IAsyncResult result);
+    }
+    public sealed class HttpUnhandledException : HttpException {
+        public HttpUnhandledException();
+        public HttpUnhandledException(string message);
+        public HttpUnhandledException(string message, Exception innerException);
+    }
+    public enum HttpValidationStatus {
+        IgnoreThisRequest = 2,
+        Invalid = 1,
+        Valid = 3,
+    }
+    public abstract class HttpWorkerRequest {
+        public const int HeaderAccept = 20;
+        public const int HeaderAcceptCharset = 21;
+        public const int HeaderAcceptEncoding = 22;
+        public const int HeaderAcceptLanguage = 23;
+        public const int HeaderAcceptRanges = 20;
+        public const int HeaderAge = 21;
+        public const int HeaderAllow = 10;
+        public const int HeaderAuthorization = 24;
+        public const int HeaderCacheControl = 0;
+        public const int HeaderConnection = 1;
+        public const int HeaderContentEncoding = 13;
+        public const int HeaderContentLanguage = 14;
+        public const int HeaderContentLength = 11;
+        public const int HeaderContentLocation = 15;
+        public const int HeaderContentMd5 = 16;
+        public const int HeaderContentRange = 17;
+        public const int HeaderContentType = 12;
+        public const int HeaderCookie = 25;
+        public const int HeaderDate = 2;
+        public const int HeaderEtag = 22;
+        public const int HeaderExpect = 26;
+        public const int HeaderExpires = 18;
+        public const int HeaderFrom = 27;
+        public const int HeaderHost = 28;
+        public const int HeaderIfMatch = 29;
+        public const int HeaderIfModifiedSince = 30;
+        public const int HeaderIfNoneMatch = 31;
+        public const int HeaderIfRange = 32;
+        public const int HeaderIfUnmodifiedSince = 33;
+        public const int HeaderKeepAlive = 3;
+        public const int HeaderLastModified = 19;
+        public const int HeaderLocation = 23;
+        public const int HeaderMaxForwards = 34;
+        public const int HeaderPragma = 4;
+        public const int HeaderProxyAuthenticate = 24;
+        public const int HeaderProxyAuthorization = 35;
+        public const int HeaderRange = 37;
+        public const int HeaderReferer = 36;
+        public const int HeaderRetryAfter = 25;
+        public const int HeaderServer = 26;
+        public const int HeaderSetCookie = 27;
+        public const int HeaderTe = 38;
+        public const int HeaderTrailer = 5;
+        public const int HeaderTransferEncoding = 6;
+        public const int HeaderUpgrade = 7;
+        public const int HeaderUserAgent = 39;
+        public const int HeaderVary = 28;
+        public const int HeaderVia = 8;
+        public const int HeaderWarning = 9;
+        public const int HeaderWwwAuthenticate = 29;
+        public const int ReasonCachePolicy = 2;
+        public const int ReasonCacheSecurity = 3;
+        public const int ReasonClientDisconnect = 4;
+        public const int ReasonDefault = 0;
+        public const int ReasonFileHandleCacheMiss = 1;
+        public const int ReasonResponseCacheMiss = 0;
+        public const int RequestHeaderMaximum = 40;
+        public const int ResponseHeaderMaximum = 30;
+        protected HttpWorkerRequest();
+        public virtual string MachineConfigPath { get; }
+        public virtual string MachineInstallDirectory { get; }
+        public virtual Guid RequestTraceIdentifier { get; }
+        public virtual string RootWebConfigPath { get; }
+        public virtual bool SupportsAsyncFlush { get; }
+        public virtual bool SupportsAsyncRead { get; }
+        public virtual IAsyncResult BeginFlush(AsyncCallback callback, object state);
+        public virtual IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state);
+        public virtual void CloseConnection();
+        public virtual void EndFlush(IAsyncResult asyncResult);
+        public abstract void EndOfRequest();
+        public virtual int EndRead(IAsyncResult asyncResult);
+        public abstract void FlushResponse(bool finalFlush);
+        public virtual string GetAppPath();
+        public virtual string GetAppPathTranslated();
+        public virtual string GetAppPoolID();
+        public virtual long GetBytesRead();
+        public virtual byte[] GetClientCertificate();
+        public virtual byte[] GetClientCertificateBinaryIssuer();
+        public virtual int GetClientCertificateEncoding();
+        public virtual byte[] GetClientCertificatePublicKey();
+        public virtual DateTime GetClientCertificateValidFrom();
+        public virtual DateTime GetClientCertificateValidUntil();
+        public virtual long GetConnectionID();
+        public virtual string GetFilePath();
+        public virtual string GetFilePathTranslated();
+        public abstract string GetHttpVerbName();
+        public abstract string GetHttpVersion();
+        public virtual string GetKnownRequestHeader(int index);
+        public static int GetKnownRequestHeaderIndex(string header);
+        public static string GetKnownRequestHeaderName(int index);
+        public static int GetKnownResponseHeaderIndex(string header);
+        public static string GetKnownResponseHeaderName(int index);
+        public abstract string GetLocalAddress();
+        public abstract int GetLocalPort();
+        public virtual string GetPathInfo();
+        public virtual byte[] GetPreloadedEntityBody();
+        public virtual int GetPreloadedEntityBody(byte[] buffer, int offset);
+        public virtual int GetPreloadedEntityBodyLength();
+        public virtual string GetProtocol();
+        public abstract string GetQueryString();
+        public virtual byte[] GetQueryStringRawBytes();
+        public abstract string GetRawUrl();
+        public abstract string GetRemoteAddress();
+        public virtual string GetRemoteName();
+        public abstract int GetRemotePort();
+        public virtual int GetRequestReason();
+        public virtual string GetServerName();
+        public virtual string GetServerVariable(string name);
+        public static string GetStatusDescription(int code);
+        public virtual int GetTotalEntityBodyLength();
+        public virtual string GetUnknownRequestHeader(string name);
+        public virtual string[][] GetUnknownRequestHeaders();
+        public abstract string GetUriPath();
+        public virtual long GetUrlContextID();
+        public virtual IntPtr GetUserToken();
+        public virtual IntPtr GetVirtualPathToken();
+        public bool HasEntityBody();
+        public virtual bool HeadersSent();
+        public virtual bool IsClientConnected();
+        public virtual bool IsEntireEntityBodyIsPreloaded();
+        public virtual bool IsSecure();
+        public virtual string MapPath(string virtualPath);
+        public virtual int ReadEntityBody(byte[] buffer, int size);
+        public virtual int ReadEntityBody(byte[] buffer, int offset, int size);
+        public virtual void SendCalculatedContentLength(int contentLength);
+        public virtual void SendCalculatedContentLength(long contentLength);
+        public abstract void SendKnownResponseHeader(int index, string value);
+        public abstract void SendResponseFromFile(IntPtr handle, long offset, long length);
+        public abstract void SendResponseFromFile(string filename, long offset, long length);
+        public abstract void SendResponseFromMemory(byte[] data, int length);
+        public virtual void SendResponseFromMemory(IntPtr data, int length);
+        public abstract void SendStatus(int statusCode, string statusDescription);
+        public abstract void SendUnknownResponseHeader(string name, string value);
+        public virtual void SetEndOfSendNotification(HttpWorkerRequest.EndOfSendNotification callback, object extraData);
+        public delegate void EndOfSendNotification(HttpWorkerRequest wr, object extraData);
+    }
+    public sealed class HttpWriter : TextWriter {
+        public override Encoding Encoding { get; }
+        public Stream OutputStream { get; }
+        public override void Close();
+        public override void Flush();
+        public override void Write(char ch);
+        public override void Write(char[] buffer, int index, int count);
+        public override void Write(object obj);
+        public override void Write(string s);
+        public void WriteBytes(byte[] buffer, int index, int count);
+        public override void WriteLine();
+        public void WriteString(string s, int index, int count);
+    }
+    public interface IHtmlString {
+        string ToHtmlString();
+    }
+    public interface IHttpAsyncHandler : IHttpHandler {
+        IAsyncResult BeginProcessRequest(HttpContext context, AsyncCallback cb, object extraData);
+        void EndProcessRequest(IAsyncResult result);
+    }
+    public interface IHttpHandler {
+        bool IsReusable { get; }
+        void ProcessRequest(HttpContext context);
+    }
+    public interface IHttpHandlerFactory {
+        IHttpHandler GetHandler(HttpContext context, string requestType, string url, string pathTranslated);
+        void ReleaseHandler(IHttpHandler handler);
+    }
+    public interface IHttpModule {
+        void Dispose();
+        void Init(HttpApplication context);
+    }
+    public sealed class IisTraceListener : TraceListener {
+        public IisTraceListener();
+        public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, object data);
+        public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, params object[] data);
+        public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType severity, int id, string message);
+        public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType severity, int id, string format, params object[] args);
+        public override void Write(string message);
+        public override void Write(string message, string category);
+        public override void WriteLine(string message);
+        public override void WriteLine(string message, string category);
+    }
+    public interface IPartitionResolver {
+        void Initialize();
+        string ResolvePartition(object key);
+    }
+    public interface ISubscriptionToken {
+        bool IsActive { get; }
+        void Unsubscribe();
+    }
+    public interface ITlsTokenBindingInfo {
+        byte[] GetProvidedTokenBindingId();
+        byte[] GetReferredTokenBindingId();
+    }
+    public static class MimeMapping {
+        public static string GetMimeMapping(string fileName);
+    }
+    public sealed class ParserError {
+        public ParserError();
+        public ParserError(string errorText, string virtualPath, int line);
+        public string ErrorText { get; set; }
+        public int Line { get; set; }
+        public string VirtualPath { get; set; }
+    }
+    public sealed class ParserErrorCollection : CollectionBase {
+        public ParserErrorCollection();
+        public ParserErrorCollection(ParserError[] value);
+        public ParserError this[int index] { get; set; }
+        public int Add(ParserError value);
+        public void AddRange(ParserErrorCollection value);
+        public void AddRange(ParserError[] value);
+        public bool Contains(ParserError value);
+        public void CopyTo(ParserError[] array, int index);
+        public int IndexOf(ParserError value);
+        public void Insert(int index, ParserError value);
+        public void Remove(ParserError value);
+    }
+    public sealed class PreApplicationStartMethodAttribute : Attribute {
+        public PreApplicationStartMethodAttribute(Type type, string methodName);
+        public string MethodName { get; }
+        public Type Type { get; }
+    }
+    public class ProcessInfo {
+        public ProcessInfo();
+        public ProcessInfo(DateTime startTime, TimeSpan age, int processID, int requestCount, ProcessStatus status, ProcessShutdownReason shutdownReason, int peakMemoryUsed);
+        public TimeSpan Age { get; }
+        public int PeakMemoryUsed { get; }
+        public int ProcessID { get; }
+        public int RequestCount { get; }
+        public ProcessShutdownReason ShutdownReason { get; }
+        public DateTime StartTime { get; }
+        public ProcessStatus Status { get; }
+        public void SetAll(DateTime startTime, TimeSpan age, int processID, int requestCount, ProcessStatus status, ProcessShutdownReason shutdownReason, int peakMemoryUsed);
+    }
+    public class ProcessModelInfo {
+        public ProcessModelInfo();
+        public static ProcessInfo GetCurrentProcessInfo();
+        public static ProcessInfo[] GetHistory(int numRecords);
+    }
+    public enum ProcessShutdownReason {
+        DeadlockSuspected = 8,
+        IdleTimeout = 5,
+        MemoryLimitExceeded = 6,
+        None = 0,
+        PingFailed = 7,
+        RequestQueueLimit = 3,
+        RequestsLimit = 2,
+        Timeout = 4,
+        Unexpected = 1,
+    }
+    public enum ProcessStatus {
+        Alive = 1,
+        ShutDown = 3,
+        ShuttingDown = 2,
+        Terminated = 4,
+    }
+    public enum ReadEntityBodyMode {
+        Buffered = 3,
+        Bufferless = 2,
+        Classic = 1,
+        None = 0,
+    }
+    public enum RequestNotification {
+        AcquireRequestState = 32,
+        AuthenticateRequest = 2,
+        AuthorizeRequest = 4,
+        BeginRequest = 1,
+        EndRequest = 2048,
+        ExecuteRequestHandler = 128,
+        LogRequest = 1024,
+        MapRequestHandler = 16,
+        PreExecuteRequestHandler = 64,
+        ReleaseRequestState = 256,
+        ResolveRequestCache = 8,
+        SendResponse = 536870912,
+        UpdateRequestCache = 512,
+    }
+    public enum RequestNotificationStatus {
+        Continue = 0,
+        FinishRequest = 2,
+        Pending = 1,
+    }
+    public static class SiteMap {
+        public static SiteMapNode CurrentNode { get; }
+        public static bool Enabled { get; }
+        public static SiteMapProvider Provider { get; }
+        public static SiteMapProviderCollection Providers { get; }
+        public static SiteMapNode RootNode { get; }
+        public static event SiteMapResolveEventHandler SiteMapResolve;
+    }
+    public class SiteMapNode : ICloneable, IHierarchyData, INavigateUIData {
+        public SiteMapNode(SiteMapProvider provider, string key);
+        public SiteMapNode(SiteMapProvider provider, string key, string url);
+        public SiteMapNode(SiteMapProvider provider, string key, string url, string title);
+        public SiteMapNode(SiteMapProvider provider, string key, string url, string title, string description);
+        public SiteMapNode(SiteMapProvider provider, string key, string url, string title, string description, IList roles, NameValueCollection attributes, NameValueCollection explicitResourceKeys, string implicitResourceKey);
+        protected NameValueCollection Attributes { get; set; }
+        public virtual SiteMapNodeCollection ChildNodes { get; set; }
+        public virtual string Description { get; set; }
+        public virtual bool HasChildNodes { get; }
+        public string Key { get; }
+        public virtual SiteMapNode NextSibling { get; }
+        public virtual SiteMapNode ParentNode { get; set; }
+        public virtual SiteMapNode PreviousSibling { get; }
+        public SiteMapProvider Provider { get; }
+        public bool ReadOnly { get; set; }
+        public string ResourceKey { get; set; }
+        public IList Roles { get; set; }
+        public virtual SiteMapNode RootNode { get; }
+        bool System.Web.UI.IHierarchyData.HasChildren { get; }
+        object System.Web.UI.IHierarchyData.Item { get; }
+        string System.Web.UI.IHierarchyData.Path { get; }
+        string System.Web.UI.IHierarchyData.Type { get; }
+        string System.Web.UI.INavigateUIData.Description { get; }
+        string System.Web.UI.INavigateUIData.Name { get; }
+        string System.Web.UI.INavigateUIData.NavigateUrl { get; }
+        string System.Web.UI.INavigateUIData.Value { get; }
+        public virtual string this[string key] { get; set; }
+        public virtual string Title { get; set; }
+        public virtual string Url { get; set; }
+        public virtual SiteMapNode Clone();
+        public virtual SiteMapNode Clone(bool cloneParentNodes);
+        public override bool Equals(object obj);
+        public SiteMapNodeCollection GetAllNodes();
+        public SiteMapDataSourceView GetDataSourceView(SiteMapDataSource owner, string viewName);
+        protected string GetExplicitResourceString(string attributeName, string defaultValue, bool throwIfNotFound);
+        public override int GetHashCode();
+        public SiteMapHierarchicalDataSourceView GetHierarchicalDataSourceView();
+        protected string GetImplicitResourceString(string attributeName);
+        public virtual bool IsAccessibleToUser(HttpContext context);
+        public virtual bool IsDescendantOf(SiteMapNode node);
+        object System.ICloneable.Clone();
+        IHierarchicalEnumerable System.Web.UI.IHierarchyData.GetChildren();
+        IHierarchyData System.Web.UI.IHierarchyData.GetParent();
+        public override string ToString();
+    }
+    public class SiteMapNodeCollection : ICollection, IEnumerable, IHierarchicalEnumerable, IList {
+        public SiteMapNodeCollection();
+        public SiteMapNodeCollection(int capacity);
+        public SiteMapNodeCollection(SiteMapNode value);
+        public SiteMapNodeCollection(SiteMapNodeCollection value);
+        public SiteMapNodeCollection(SiteMapNode[] value);
+        public virtual int Count { get; }
+        public virtual bool IsFixedSize { get; }
+        public virtual bool IsReadOnly { get; }
+        public virtual bool IsSynchronized { get; }
+        public virtual object SyncRoot { get; }
+        int System.Collections.ICollection.Count { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public virtual SiteMapNode this[int index] { get; set; }
+        public virtual int Add(SiteMapNode value);
+        public virtual void AddRange(SiteMapNodeCollection value);
+        public virtual void AddRange(SiteMapNode[] value);
+        public virtual void Clear();
+        public virtual bool Contains(SiteMapNode value);
+        public virtual void CopyTo(SiteMapNode[] array, int index);
+        public SiteMapDataSourceView GetDataSourceView(SiteMapDataSource owner, string viewName);
+        public virtual IEnumerator GetEnumerator();
+        public SiteMapHierarchicalDataSourceView GetHierarchicalDataSourceView();
+        public virtual IHierarchyData GetHierarchyData(object enumeratedItem);
+        public virtual int IndexOf(SiteMapNode value);
+        public virtual void Insert(int index, SiteMapNode value);
+        protected virtual void OnValidate(object value);
+        public static SiteMapNodeCollection ReadOnly(SiteMapNodeCollection collection);
+        public virtual void Remove(SiteMapNode value);
+        public virtual void RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        void System.Collections.IList.Clear();
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        void System.Collections.IList.RemoveAt(int index);
+        IHierarchyData System.Web.UI.IHierarchicalEnumerable.GetHierarchyData(object enumeratedItem);
+    }
+    public abstract class SiteMapProvider : ProviderBase {
+        protected SiteMapProvider();
+        public virtual SiteMapNode CurrentNode { get; }
+        public bool EnableLocalization { get; set; }
+        public virtual SiteMapProvider ParentProvider { get; set; }
+        public string ResourceKey { get; set; }
+        public virtual SiteMapNode RootNode { get; }
+        public virtual SiteMapProvider RootProvider { get; }
+        public bool SecurityTrimmingEnabled { get; }
+        public event SiteMapResolveEventHandler SiteMapResolve;
+        protected virtual void AddNode(SiteMapNode node);
+        protected internal virtual void AddNode(SiteMapNode node, SiteMapNode parentNode);
+        public abstract SiteMapNode FindSiteMapNode(string rawUrl);
+        public virtual SiteMapNode FindSiteMapNode(HttpContext context);
+        public virtual SiteMapNode FindSiteMapNodeFromKey(string key);
+        public abstract SiteMapNodeCollection GetChildNodes(SiteMapNode node);
+        public virtual SiteMapNode GetCurrentNodeAndHintAncestorNodes(int upLevel);
+        public virtual SiteMapNode GetCurrentNodeAndHintNeighborhoodNodes(int upLevel, int downLevel);
+        public abstract SiteMapNode GetParentNode(SiteMapNode node);
+        public virtual SiteMapNode GetParentNodeRelativeToCurrentNodeAndHintDownFromParent(int walkupLevels, int relativeDepthFromWalkup);
+        public virtual SiteMapNode GetParentNodeRelativeToNodeAndHintDownFromParent(SiteMapNode node, int walkupLevels, int relativeDepthFromWalkup);
+        protected internal abstract SiteMapNode GetRootNodeCore();
+        protected static SiteMapNode GetRootNodeCoreFromProvider(SiteMapProvider provider);
+        public virtual void HintAncestorNodes(SiteMapNode node, int upLevel);
+        public virtual void HintNeighborhoodNodes(SiteMapNode node, int upLevel, int downLevel);
+        public override void Initialize(string name, NameValueCollection attributes);
+        public virtual bool IsAccessibleToUser(HttpContext context, SiteMapNode node);
+        protected internal virtual void RemoveNode(SiteMapNode node);
+        protected SiteMapNode ResolveSiteMapNode(HttpContext context);
+    }
+    public sealed class SiteMapProviderCollection : ProviderCollection {
+        public SiteMapProviderCollection();
+        public new SiteMapProvider this[string name] { get; }
+        public override void Add(ProviderBase provider);
+        public void Add(SiteMapProvider provider);
+        public void AddArray(SiteMapProvider[] providerArray);
+    }
+    public class SiteMapResolveEventArgs : EventArgs {
+        public SiteMapResolveEventArgs(HttpContext context, SiteMapProvider provider);
+        public HttpContext Context { get; }
+        public SiteMapProvider Provider { get; }
+    }
+    public delegate SiteMapNode SiteMapResolveEventHandler(object sender, SiteMapResolveEventArgs e);
+    public abstract class StaticSiteMapProvider : SiteMapProvider {
+        protected StaticSiteMapProvider();
+        protected internal override void AddNode(SiteMapNode node, SiteMapNode parentNode);
+        public abstract SiteMapNode BuildSiteMap();
+        protected virtual void Clear();
+        public override SiteMapNode FindSiteMapNode(string rawUrl);
+        public override SiteMapNode FindSiteMapNodeFromKey(string key);
+        public override SiteMapNodeCollection GetChildNodes(SiteMapNode node);
+        public override SiteMapNode GetParentNode(SiteMapNode node);
+        protected internal override void RemoveNode(SiteMapNode node);
+    }
+    public delegate Task TaskEventHandler(object sender, EventArgs e);
+    public sealed class TraceContext {
+        public TraceContext(HttpContext context);
+        public bool IsEnabled { get; set; }
+        public TraceMode TraceMode { get; set; }
+        public event TraceContextEventHandler TraceFinished;
+        public void Warn(string message);
+        public void Warn(string category, string message);
+        public void Warn(string category, string message, Exception errorInfo);
+        public void Write(string message);
+        public void Write(string category, string message);
+        public void Write(string category, string message, Exception errorInfo);
+    }
+    public sealed class TraceContextEventArgs : EventArgs {
+        public TraceContextEventArgs(ICollection records);
+        public ICollection TraceRecords { get; }
+    }
+    public delegate void TraceContextEventHandler(object sender, TraceContextEventArgs e);
+    public sealed class TraceContextRecord {
+        public TraceContextRecord(string category, string msg, bool isWarning, Exception errorInfo);
+        public string Category { get; }
+        public Exception ErrorInfo { get; }
+        public bool IsWarning { get; }
+        public string Message { get; }
+    }
+    public enum TraceMode {
+        Default = 2,
+        SortByCategory = 1,
+        SortByTime = 0,
+    }
+    public sealed class UnvalidatedRequestValues {
+        public HttpCookieCollection Cookies { get; }
+        public HttpFileCollection Files { get; }
+        public NameValueCollection Form { get; }
+        public NameValueCollection Headers { get; }
+        public string Path { get; }
+        public string PathInfo { get; }
+        public NameValueCollection QueryString { get; }
+        public string RawUrl { get; }
+        public string this[string field] { get; }
+        public Uri Url { get; }
+    }
+    public abstract class UnvalidatedRequestValuesBase {
+        protected UnvalidatedRequestValuesBase();
+        public virtual HttpCookieCollection Cookies { get; }
+        public virtual HttpFileCollectionBase Files { get; }
+        public virtual NameValueCollection Form { get; }
+        public virtual NameValueCollection Headers { get; }
+        public virtual string Path { get; }
+        public virtual string PathInfo { get; }
+        public virtual NameValueCollection QueryString { get; }
+        public virtual string RawUrl { get; }
+        public virtual string this[string field] { get; }
+        public virtual Uri Url { get; }
+    }
+    public class UnvalidatedRequestValuesWrapper : UnvalidatedRequestValuesBase {
+        public UnvalidatedRequestValuesWrapper(UnvalidatedRequestValues requestValues);
+        public override HttpCookieCollection Cookies { get; }
+        public override HttpFileCollectionBase Files { get; }
+        public override NameValueCollection Form { get; }
+        public override NameValueCollection Headers { get; }
+        public override string Path { get; }
+        public override string PathInfo { get; }
+        public override NameValueCollection QueryString { get; }
+        public override string RawUrl { get; }
+        public override string this[string field] { get; }
+        public override Uri Url { get; }
+    }
+    public static class VirtualPathUtility {
+        public static string AppendTrailingSlash(string virtualPath);
+        public static string Combine(string basePath, string relativePath);
+        public static string GetDirectory(string virtualPath);
+        public static string GetExtension(string virtualPath);
+        public static string GetFileName(string virtualPath);
+        public static bool IsAbsolute(string virtualPath);
+        public static bool IsAppRelative(string virtualPath);
+        public static string MakeRelative(string fromPath, string toPath);
+        public static string RemoveTrailingSlash(string virtualPath);
+        public static string ToAbsolute(string virtualPath);
+        public static string ToAbsolute(string virtualPath, string applicationPath);
+        public static string ToAppRelative(string virtualPath);
+        public static string ToAppRelative(string virtualPath, string applicationPath);
+    }
+    public class WebPageTraceListener : TraceListener {
+        public WebPageTraceListener();
+        public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType severity, int id, string message);
+        public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType severity, int id, string format, params object[] args);
+        public override void Write(string message);
+        public override void Write(string message, string category);
+        public override void WriteLine(string message);
+        public override void WriteLine(string message, string category);
+    }
+    public class XmlSiteMapProvider : StaticSiteMapProvider, IDisposable {
+        public XmlSiteMapProvider();
+        public override SiteMapNode CurrentNode { get; }
+        public override SiteMapNode RootNode { get; }
+        protected internal override void AddNode(SiteMapNode node, SiteMapNode parentNode);
+        protected virtual void AddProvider(string providerName, SiteMapNode parentNode);
+        public override SiteMapNode BuildSiteMap();
+        protected override void Clear();
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        public override SiteMapNode FindSiteMapNode(string rawUrl);
+        public override SiteMapNode FindSiteMapNodeFromKey(string key);
+        public override SiteMapNodeCollection GetChildNodes(SiteMapNode node);
+        public override SiteMapNode GetParentNode(SiteMapNode node);
+        protected internal override SiteMapNode GetRootNodeCore();
+        public override void Initialize(string name, NameValueCollection attributes);
+        protected internal override void RemoveNode(SiteMapNode node);
+        protected virtual void RemoveProvider(string providerName);
+    }
 }
```

