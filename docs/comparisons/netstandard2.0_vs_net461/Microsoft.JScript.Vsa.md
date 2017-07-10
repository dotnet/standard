# Microsoft.JScript.Vsa

``` diff
+namespace Microsoft.JScript.Vsa {
+    public abstract class BaseVsaEngine : IJSVsaEngine {
+        protected BaseVsaStartup startupInstance;
+        protected IJSVsaItems vsaItems;
+        protected IJSVsaSite engineSite;
+        protected bool failedCompilation;
+        protected bool genDebugInfo;
+        protected bool haveCompiledState;
+        protected bool isClosed;
+        protected bool isDebugInfoSupported;
+        protected bool isEngineCompiled;
+        protected bool isEngineDirty;
+        protected bool isEngineInitialized;
+        protected bool isEngineRunning;
+        protected static Hashtable nameTable;
+        protected int errorLocale;
+        protected Assembly loadedAssembly;
+        protected Evidence executionEvidence;
+        protected string applicationPath;
+        protected string assemblyVersion;
+        protected string compiledRootNamespace;
+        protected string engineMoniker;
+        protected string engineName;
+        protected string rootNamespace;
+        protected string scriptLanguage;
+        protected Type startupClass;
+        public _AppDomain AppDomain { get; set; }
+        public string ApplicationBase { get; set; }
+        public Assembly Assembly { get; }
+        public Evidence Evidence { get; set; }
+        public bool GenerateDebugInfo { get; set; }
+        public bool IsCompiled { get; }
+        public bool IsDirty { get; set; }
+        public bool IsRunning { get; }
+        public IJSVsaItems Items { get; }
+        public string Language { get; }
+        public int LCID { get; set; }
+        public string Name { get; set; }
+        public string RootMoniker { get; set; }
+        public string RootNamespace { get; set; }
+        public IJSVsaSite Site { get; set; }
+        public string Version { get; }
+        public virtual void Close();
+        public virtual bool Compile();
+        protected abstract void DoClose();
+        protected abstract bool DoCompile();
+        protected abstract void DoLoadSourceState(IJSVsaPersistSite site);
+        protected abstract void DoSaveCompiledState(out byte[] pe, out byte[] debugInfo);
+        protected abstract void DoSaveSourceState(IJSVsaPersistSite site);
+        protected JSVsaException Error(JSVsaError vsaErrorNumber);
+        protected abstract object GetCustomOption(string name);
+        public virtual object GetOption(string name);
+        public virtual void InitNew();
+        public abstract bool IsValidIdentifier(string ident);
+        protected abstract bool IsValidNamespaceName(string name);
+        protected virtual Assembly LoadCompiledState();
+        public virtual void LoadSourceState(IJSVsaPersistSite site);
+        protected void Preconditions(BaseVsaEngine.Pre flags);
+        public virtual void Reset();
+        protected abstract void ResetCompiledState();
+        public virtual void RevokeCache();
+        public virtual void Run();
+        public virtual void SaveCompiledState(out byte[] pe, out byte[] debugInfo);
+        public virtual void SaveSourceState(IJSVsaPersistSite site);
+        protected abstract void SetCustomOption(string name, object value);
+        public virtual void SetOption(string name, object value);
+        protected virtual void ValidateRootMoniker(string rootMoniker);
+        protected enum Pre {
+            EngineCompiled = 4,
+            EngineInitialised = 1024,
+            EngineNotClosed = 1,
+            EngineNotInitialised = 2048,
+            EngineNotRunning = 16,
+            EngineRunning = 8,
+            None = 0,
+            RootMonikerNotSet = 64,
+            RootMonikerSet = 32,
+            RootNamespaceSet = 128,
+            SiteNotSet = 512,
+            SiteSet = 256,
+            SupportForDebug = 2,
+        }
+    }
+    public class BaseVsaSite : IJSVsaSite {
+        public BaseVsaSite();
+        public virtual byte[] Assembly { get; }
+        public virtual byte[] DebugInfo { get; }
+        public virtual void GetCompiledState(out byte[] pe, out byte[] debugInfo);
+        public virtual object GetEventSourceInstance(string itemName, string eventSourceName);
+        public virtual object GetGlobalInstance(string name);
+        public virtual void Notify(string notify, object optional);
+        public virtual bool OnCompilerError(IJSVsaError error);
+    }
+    public abstract class BaseVsaStartup {
+        protected IJSVsaSite site;
+        protected BaseVsaStartup();
+        public void SetSite(IJSVsaSite site);
+        public abstract void Shutdown();
+        public abstract void Startup();
+    }
+    public interface IJSVsaCodeItem : IJSVsaItem {
+        CodeObject CodeDOM { get; }
+        string SourceText { get; set; }
+        void AddEventSource(string eventSourceName, string eventSourceType);
+        void AppendSourceText(string text);
+        void RemoveEventSource(string eventSourceName);
+    }
+    public interface IJSVsaEngine {
+        Assembly Assembly { get; }
+        Evidence Evidence { get; set; }
+        bool GenerateDebugInfo { get; set; }
+        bool IsCompiled { get; }
+        bool IsDirty { get; }
+        bool IsRunning { get; }
+        IJSVsaItems Items { get; }
+        string Language { get; }
+        int LCID { get; set; }
+        string Name { get; set; }
+        string RootMoniker { get; set; }
+        string RootNamespace { get; set; }
+        IJSVsaSite Site { get; set; }
+        string Version { get; }
+        void Close();
+        bool Compile();
+        object GetOption(string name);
+        void InitNew();
+        bool IsValidIdentifier(string identifier);
+        void LoadSourceState(IJSVsaPersistSite site);
+        void Reset();
+        void RevokeCache();
+        void Run();
+        void SaveCompiledState(out byte[] pe, out byte[] pdb);
+        void SaveSourceState(IJSVsaPersistSite site);
+        void SetOption(string name, object value);
+    }
+    public interface IJSVsaError {
+        string Description { get; }
+        int EndColumn { get; }
+        int Line { get; }
+        string LineText { get; }
+        int Number { get; }
+        int Severity { get; }
+        IJSVsaItem SourceItem { get; }
+        string SourceMoniker { get; }
+        int StartColumn { get; }
+    }
+    public interface IJSVsaGlobalItem : IJSVsaItem {
+        bool ExposeMembers { get; set; }
+        string TypeString { set; }
+    }
+    public interface IJSVsaItem {
+        bool IsDirty { get; }
+        JSVsaItemType ItemType { get; }
+        string Name { get; set; }
+        object GetOption(string name);
+        void SetOption(string name, object value);
+    }
+    public interface IJSVsaItems : IEnumerable {
+        int Count { get; }
+        IJSVsaItem this[int index] { get; }
+        IJSVsaItem this[string name] { get; }
+        IJSVsaItem CreateItem(string name, JSVsaItemType itemType, JSVsaItemFlag itemFlag);
+        void Remove(int index);
+        void Remove(string name);
+    }
+    public interface IJSVsaPersistSite {
+        string LoadElement(string name);
+        void SaveElement(string name, string source);
+    }
+    public interface IJSVsaReferenceItem : IJSVsaItem {
+        string AssemblyName { get; set; }
+    }
+    public interface IJSVsaSite {
+        void GetCompiledState(out byte[] pe, out byte[] debugInfo);
+        object GetEventSourceInstance(string itemName, string eventSourceName);
+        object GetGlobalInstance(string name);
+        void Notify(string notify, object info);
+        bool OnCompilerError(IJSVsaError error);
+    }
+    public enum JSVsaError {
+        AppDomainCannotBeSet = -2146226176,
+        AppDomainInvalid = -2146226175,
+        ApplicationBaseCannotBeSet = -2146226174,
+        ApplicationBaseInvalid = -2146226173,
+        AssemblyExpected = -2146226172,
+        AssemblyNameInvalid = -2146226171,
+        BadAssembly = -2146226170,
+        BrowserNotExist = -2146226115,
+        CachedAssemblyInvalid = -2146226169,
+        CallbackUnexpected = -2146226168,
+        CannotAttachToWebServer = -2146226100,
+        CodeDOMNotAvailable = -2146226167,
+        CompiledStateNotFound = -2146226166,
+        DebuggeeNotStarted = -2146226114,
+        DebugInfoNotSupported = -2146226165,
+        ElementNameInvalid = -2146226164,
+        ElementNotFound = -2146226163,
+        EngineBusy = -2146226162,
+        EngineCannotClose = -2146226161,
+        EngineCannotReset = -2146226160,
+        EngineClosed = -2146226159,
+        EngineEmpty = -2146226159,
+        EngineInitialized = -2146226157,
+        EngineNameInUse = -2146226156,
+        EngineNameInvalid = -2146226113,
+        EngineNameNotSet = -2146226099,
+        EngineNotCompiled = -2146226155,
+        EngineNotExist = -2146226112,
+        EngineNotInitialized = -2146226154,
+        EngineNotRunning = -2146226153,
+        EngineRunning = -2146226152,
+        EventSourceInvalid = -2146226151,
+        EventSourceNameInUse = -2146226150,
+        EventSourceNameInvalid = -2146226149,
+        EventSourceNotFound = -2146226148,
+        EventSourceTypeInvalid = -2146226147,
+        FileFormatUnsupported = -2146226111,
+        FileTypeUnknown = -2146226110,
+        GetCompiledStateFailed = -2146226146,
+        GlobalInstanceInvalid = -2146226145,
+        GlobalInstanceTypeInvalid = -2146226144,
+        InternalCompilerError = -2146226143,
+        ItemCannotBeRemoved = -2146226142,
+        ItemCannotBeRenamed = -2146226109,
+        ItemFlagNotSupported = -2146226141,
+        ItemNameInUse = -2146226140,
+        ItemNameInvalid = -2146226139,
+        ItemNotFound = -2146226138,
+        ItemTypeNotSupported = -2146226137,
+        LCIDNotSupported = -2146226136,
+        LoadElementFailed = -2146226135,
+        MissingPdb = -2146226102,
+        MissingSource = -2146226108,
+        NameTooLong = -2146226106,
+        NotClientSideAndNoUrl = -2146226101,
+        NotificationInvalid = -2146226134,
+        NotInitCompleted = -2146226107,
+        OptionInvalid = -2146226133,
+        OptionNotSupported = -2146226132,
+        ProcNameInUse = -2146226105,
+        ProcNameInvalid = -2146226104,
+        RevokeFailed = -2146226131,
+        RootMonikerAlreadySet = -2146226130,
+        RootMonikerInUse = -2146226129,
+        RootMonikerInvalid = -2146226128,
+        RootMonikerNotSet = -2146226127,
+        RootMonikerProtocolInvalid = -2146226126,
+        RootNamespaceInvalid = -2146226125,
+        RootNamespaceNotSet = -2146226124,
+        SaveCompiledStateFailed = -2146226123,
+        SaveElementFailed = -2146226122,
+        SiteAlreadySet = -2146226121,
+        SiteInvalid = -2146226120,
+        SiteNotSet = -2146226119,
+        SourceItemNotAvailable = -2146226118,
+        SourceMonikerNotAvailable = -2146226117,
+        UnknownError = -2146225921,
+        URLInvalid = -2146226116,
+        VsaServerDown = -2146226103,
+    }
+    public sealed class JSVsaException : ExternalException {
+        public JSVsaException();
+        public JSVsaException(JSVsaError error);
+        public JSVsaException(JSVsaError error, string message);
+        public JSVsaException(JSVsaError error, string message, Exception innerException);
+        public JSVsaException(SerializationInfo info, StreamingContext context);
+        public JSVsaException(string message);
+        public JSVsaException(string message, Exception innerException);
+        public new JSVsaError ErrorCode { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+        public override string ToString();
+    }
+    public enum JSVsaItemFlag {
+        Class = 2,
+        Module = 1,
+        None = 0,
+    }
+    public enum JSVsaItemType {
+        AppGlobal = 1,
+        Code = 2,
+        Reference = 0,
+    }
+    public class ResInfo {
+        public bool isLinked;
+        public bool isPublic;
+        public string filename;
+        public string fullpath;
+        public string name;
+        public ResInfo(string resinfo, bool isLinked);
+        public ResInfo(string filename, string name, bool isPublic, bool isLinked);
+    }
+    public sealed class VsaEngine : BaseVsaEngine, IEngine2, IRedirectOutput {
+        public VsaEngine();
+        public VsaEngine(bool fast);
+        public LenientGlobalObject LenientGlobalObject { get; }
+        public IJSVsaEngine Clone(AppDomain domain);
+        public bool CompileEmpty();
+        public void ConnectEvents();
+        public static VsaEngine CreateEngine();
+        public static GlobalScope CreateEngineAndGetGlobalScope(bool fast, string[] assemblyNames);
+        public static GlobalScope CreateEngineAndGetGlobalScopeWithType(bool fast, string[] assemblyNames, RuntimeTypeHandle callingTypeHandle);
+        public static GlobalScope CreateEngineAndGetGlobalScopeWithTypeAndRootNamespace(bool fast, string[] assemblyNames, RuntimeTypeHandle callingTypeHandle, string rootNamespace);
+        public static VsaEngine CreateEngineWithType(RuntimeTypeHandle callingTypeHandle);
+        public void DisconnectEvents();
+        protected override void DoClose();
+        protected override bool DoCompile();
+        protected override void DoLoadSourceState(IJSVsaPersistSite site);
+        protected override void DoSaveCompiledState(out byte[] pe, out byte[] pdb);
+        protected override void DoSaveSourceState(IJSVsaPersistSite site);
+        public Assembly GetAssembly();
+        protected override object GetCustomOption(string name);
+        public IVsaScriptScope GetGlobalScope();
+        public IJSVsaItem GetItem(string itemName);
+        public IJSVsaItem GetItemAtIndex(int index);
+        public int GetItemCount();
+        public GlobalScope GetMainScope();
+        public Module GetModule();
+        public ArrayConstructor GetOriginalArrayConstructor();
+        public ObjectConstructor GetOriginalObjectConstructor();
+        public RegExpConstructor GetOriginalRegExpConstructor();
+        public void InitVsaEngine(string rootMoniker, IJSVsaSite site);
+        public void Interrupt();
+        public override bool IsValidIdentifier(string ident);
+        protected override bool IsValidNamespaceName(string name);
+        protected override Assembly LoadCompiledState();
+        public ScriptObject PopScriptObject();
+        public void PushScriptObject(ScriptObject obj);
+        public void RegisterEventSource(string name);
+        public override void Reset();
+        protected override void ResetCompiledState();
+        public void Restart();
+        public void Run(AppDomain domain);
+        public void RunEmpty();
+        public ScriptObject ScriptObjectStackTop();
+        protected override void SetCustomOption(string name, object value);
+        public void SetOutputStream(IMessageReceiver output);
+        protected override void ValidateRootMoniker(string rootMoniker);
+    }
+}
```

