# System.Web.Configuration

``` diff
+namespace System.Web.Configuration {
+    public class AdapterDictionary : OrderedDictionary {
+        public AdapterDictionary();
+        public string this[string key] { get; set; }
+    }
+    public sealed class AnonymousIdentificationSection : ConfigurationSection {
+        public AnonymousIdentificationSection();
+        public HttpCookieMode Cookieless { get; set; }
+        public string CookieName { get; set; }
+        public string CookiePath { get; set; }
+        public CookieProtection CookieProtection { get; set; }
+        public bool CookieRequireSSL { get; set; }
+        public bool CookieSlidingExpiration { get; set; }
+        public TimeSpan CookieTimeout { get; set; }
+        public string Domain { get; set; }
+        public bool Enabled { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class AssemblyCollection : ConfigurationElementCollection {
+        public AssemblyCollection();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public AssemblyInfo this[int index] { get; set; }
+        public new AssemblyInfo this[string assemblyName] { get; }
+        public void Add(AssemblyInfo assemblyInformation);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public void Remove(string key);
+        public void RemoveAt(int index);
+    }
+    public sealed class AssemblyInfo : ConfigurationElement {
+        public AssemblyInfo(string assemblyName);
+        public string Assembly { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public enum AsyncPreloadModeFlags {
+        All = 7,
+        AllFormTypes = 3,
+        Form = 1,
+        FormMultiPart = 2,
+        None = 0,
+        NonForm = 4,
+    }
+    public enum AuthenticationMode {
+        Forms = 3,
+        None = 0,
+        Passport = 2,
+        Windows = 1,
+    }
+    public sealed class AuthenticationSection : ConfigurationSection {
+        public AuthenticationSection();
+        public FormsAuthenticationConfiguration Forms { get; }
+        public AuthenticationMode Mode { get; set; }
+        public PassportAuthentication Passport { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected override void Reset(ConfigurationElement parentElement);
+    }
+    public sealed class AuthorizationRule : ConfigurationElement {
+        public AuthorizationRule(AuthorizationRuleAction action);
+        public AuthorizationRuleAction Action { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public StringCollection Roles { get; }
+        public StringCollection Users { get; }
+        public StringCollection Verbs { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        protected override bool IsModified();
+        protected override void PostDeserialize();
+        protected override void PreSerialize(XmlWriter writer);
+        protected override void Reset(ConfigurationElement parentElement);
+        protected override void ResetModified();
+        protected override bool SerializeElement(XmlWriter writer, bool serializeCollectionKey);
+        protected override void SetReadOnly();
+        protected override void Unmerge(ConfigurationElement sourceElement, ConfigurationElement parentElement, ConfigurationSaveMode saveMode);
+    }
+    public enum AuthorizationRuleAction {
+        Allow = 1,
+        Deny = 0,
+    }
+    public sealed class AuthorizationRuleCollection : ConfigurationElementCollection {
+        public AuthorizationRuleCollection();
+        public override ConfigurationElementCollectionType CollectionType { get; }
+        protected override string ElementName { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public AuthorizationRule this[int index] { get; set; }
+        public void Add(AuthorizationRule rule);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override ConfigurationElement CreateNewElement(string elementName);
+        public AuthorizationRule Get(int index);
+        protected override object GetElementKey(ConfigurationElement element);
+        public int IndexOf(AuthorizationRule rule);
+        protected override bool IsElementName(string elementname);
+        public void Remove(AuthorizationRule rule);
+        public void RemoveAt(int index);
+        public void Set(int index, AuthorizationRule rule);
+    }
+    public sealed class AuthorizationSection : ConfigurationSection {
+        public AuthorizationSection();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public AuthorizationRuleCollection Rules { get; }
+        protected override void PostDeserialize();
+    }
+    public class BrowserCapabilitiesCodeGenerator {
+        public BrowserCapabilitiesCodeGenerator();
+        public virtual void Create();
+        protected void ProcessBrowserFiles(bool useVirtualPath, string virtualDir);
+        public bool Uninstall();
+    }
+    public class BrowserCapabilitiesFactory : BrowserCapabilitiesFactoryBase {
+        public BrowserCapabilitiesFactory();
+        protected virtual void BlackberryProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void BlackberryProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void ChromeProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void ChromeProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        public override void ConfigureBrowserCapabilities(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void CpuProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void CpuProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void CrawlerProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void CrawlerProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void DefaultDefaultProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void DefaultProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void DefaultProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void DefaultWmlProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void DefaultXhtmlmpProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Firefox35ProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Firefox35ProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Firefox3plusProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Firefox3plusProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Firefox3ProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Firefox3ProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void FirefoxProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void FirefoxProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void GenericdownlevelProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void GenericdownlevelProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Ie10plusProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Ie10plusProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Ie6plusProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Ie6plusProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Ie6to9ProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Ie6to9ProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Ie7ProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Ie7ProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Ie8ProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Ie8ProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Ie9ProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Ie9ProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void IebetaProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void IebetaProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void IemobileProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void IemobileProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void IeProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void IeProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void InternetexplorerProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void InternetexplorerProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void IpadProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void IpadProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void IphoneProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void IphoneProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void IpodProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void IpodProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void MonoProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void MonoProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void MozillaProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void MozillaProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Opera10ProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Opera10ProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Opera8plusProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Opera8plusProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Opera8to9ProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Opera8to9ProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void OperaminiProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void OperaminiProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void OperamobileProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void OperamobileProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void OperaProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void OperaProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void OSProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void OSProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void PixelsProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void PixelsProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Platformmac68kProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Platformmac68kProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void PlatformmacppcProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void PlatformmacppcProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void PlatformProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void PlatformProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void PlatformunixProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void PlatformunixProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void PlatformwebtvProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void PlatformwebtvProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Platformwin16ProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Platformwin16ProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Platformwin2000aProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Platformwin2000aProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Platformwin2000bProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Platformwin2000bProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Platformwin95ProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Platformwin95ProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Platformwin98ProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Platformwin98ProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void PlatformwinceProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void PlatformwinceProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void PlatformwinntProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void PlatformwinntProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void PlatformwinxpProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void PlatformwinxpProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected override void PopulateBrowserElements(IDictionary dictionary);
+        protected override void PopulateMatchedHeaders(IDictionary dictionary);
+        protected virtual void Safari3plusProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Safari3plusProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Safari3to4ProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Safari3to4ProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Safari4ProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Safari4ProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void SafariProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void SafariProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void UcbrowserProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void UcbrowserProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void VoiceProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void VoiceProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void WebkitmobileProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void WebkitmobileProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void WebkitProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void WebkitProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Win16ProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Win16ProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Win32ProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void Win32ProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void WindowsphoneProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void WindowsphoneProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void WinProcessBrowsers(bool ignoreApplicationBrowsers, NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected virtual void WinProcessGateways(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+    }
+    public class BrowserCapabilitiesFactoryBase {
+        public BrowserCapabilitiesFactoryBase();
+        protected IDictionary BrowserElements { get; }
+        protected IDictionary MatchedHeaders { get; }
+        public virtual void ConfigureBrowserCapabilities(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        public virtual void ConfigureCustomCapabilities(NameValueCollection headers, HttpBrowserCapabilities browserCaps);
+        protected bool IsBrowserUnknown(HttpCapabilitiesBase browserCaps);
+        protected virtual void PopulateBrowserElements(IDictionary dictionary);
+        protected virtual void PopulateMatchedHeaders(IDictionary dictionary);
+    }
+    public sealed class BufferModesCollection : ConfigurationElementCollection {
+        public BufferModesCollection();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public BufferModeSettings this[int index] { get; set; }
+        public new BufferModeSettings this[string key] { get; }
+        public void Add(BufferModeSettings bufferModeSettings);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public void Remove(string s);
+    }
+    public sealed class BufferModeSettings : ConfigurationElement {
+        public BufferModeSettings(string name, int maxBufferSize, int maxFlushSize, int urgentFlushThreshold, TimeSpan regularFlushInterval, TimeSpan urgentFlushInterval, int maxBufferThreads);
+        protected override ConfigurationElementProperty ElementProperty { get; }
+        public int MaxBufferSize { get; set; }
+        public int MaxBufferThreads { get; set; }
+        public int MaxFlushSize { get; set; }
+        public string Name { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public TimeSpan RegularFlushInterval { get; set; }
+        public TimeSpan UrgentFlushInterval { get; set; }
+        public int UrgentFlushThreshold { get; set; }
+    }
+    public sealed class BuildProvider : ConfigurationElement {
+        public BuildProvider(string extension, string type);
+        public string Extension { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string Type { get; set; }
+        public override bool Equals(object provider);
+        public override int GetHashCode();
+    }
+    public sealed class BuildProviderCollection : ConfigurationElementCollection {
+        public BuildProviderCollection();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public BuildProvider this[int index] { get; set; }
+        public new BuildProvider this[string name] { get; }
+        public void Add(BuildProvider buildProvider);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public void Remove(string name);
+        public void RemoveAt(int index);
+    }
+    public sealed class CacheSection : ConfigurationSection {
+        public CacheSection();
+        public bool DisableExpiration { get; set; }
+        public bool DisableMemoryCollection { get; set; }
+        public int PercentagePhysicalMemoryUsedLimit { get; set; }
+        public long PrivateBytesLimit { get; set; }
+        public TimeSpan PrivateBytesPollTime { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class ClientTarget : ConfigurationElement {
+        public ClientTarget(string alias, string userAgent);
+        public string Alias { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string UserAgent { get; }
+    }
+    public sealed class ClientTargetCollection : ConfigurationElementCollection {
+        public ClientTargetCollection();
+        public string[] AllKeys { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public ClientTarget this[int index] { get; set; }
+        public new ClientTarget this[string name] { get; }
+        public void Add(ClientTarget clientTarget);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public string GetKey(int index);
+        public void Remove(string name);
+        public void Remove(ClientTarget clientTarget);
+        public void RemoveAt(int index);
+    }
+    public sealed class ClientTargetSection : ConfigurationSection {
+        public ClientTargetSection();
+        public ClientTargetCollection ClientTargets { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class CodeSubDirectoriesCollection : ConfigurationElementCollection {
+        public CodeSubDirectoriesCollection();
+        public override ConfigurationElementCollectionType CollectionType { get; }
+        protected override string ElementName { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public CodeSubDirectory this[int index] { get; set; }
+        public void Add(CodeSubDirectory codeSubDirectory);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public void Remove(string directoryName);
+        public void RemoveAt(int index);
+    }
+    public sealed class CodeSubDirectory : ConfigurationElement {
+        public CodeSubDirectory(string directoryName);
+        public string DirectoryName { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class CompilationSection : ConfigurationSection {
+        public CompilationSection();
+        public AssemblyCollection Assemblies { get; }
+        public string AssemblyPostProcessorType { get; set; }
+        public bool Batch { get; set; }
+        public TimeSpan BatchTimeout { get; set; }
+        public BuildProviderCollection BuildProviders { get; }
+        public CodeSubDirectoriesCollection CodeSubDirectories { get; }
+        public CompilerCollection Compilers { get; }
+        public string ControlBuilderInterceptorType { get; set; }
+        public bool Debug { get; set; }
+        public string DefaultLanguage { get; set; }
+        public bool DisableObsoleteWarnings { get; set; }
+        public bool EnablePrefetchOptimization { get; set; }
+        public bool Explicit { get; set; }
+        public ExpressionBuilderCollection ExpressionBuilders { get; }
+        public FolderLevelBuildProviderCollection FolderLevelBuildProviders { get; }
+        public int MaxBatchGeneratedFileSize { get; set; }
+        public int MaxBatchSize { get; set; }
+        public int MaxConcurrentCompilations { get; set; }
+        public int NumRecompilesBeforeAppRestart { get; set; }
+        public bool OptimizeCompilations { get; set; }
+        public ProfileGuidedOptimizationsFlags ProfileGuidedOptimizations { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public bool Strict { get; set; }
+        public string TargetFramework { get; set; }
+        public string TempDirectory { get; set; }
+        public bool UrlLinePragmas { get; set; }
+        protected override object GetRuntimeObject();
+        protected override void PostDeserialize();
+        protected override void SetReadOnly();
+    }
+    public sealed class Compiler : ConfigurationElement {
+        public Compiler(string compilerOptions, string extension, string language, string type, int warningLevel);
+        public string CompilerOptions { get; }
+        public string Extension { get; }
+        public string Language { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string Type { get; }
+        public int WarningLevel { get; }
+    }
+    public sealed class CompilerCollection : ConfigurationElementCollection {
+        public CompilerCollection();
+        public string[] AllKeys { get; }
+        public override ConfigurationElementCollectionType CollectionType { get; }
+        protected override string ElementName { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public Compiler this[int index] { get; }
+        public new Compiler this[string language] { get; }
+        protected override ConfigurationElement CreateNewElement();
+        public Compiler Get(int index);
+        public Compiler Get(string language);
+        protected override object GetElementKey(ConfigurationElement element);
+        public string GetKey(int index);
+    }
+    public class Converter : ConfigurationElement {
+        public Converter();
+        public string Name { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string Type { get; set; }
+    }
+    public class ConvertersCollection : ConfigurationElementCollection {
+        public ConvertersCollection();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public Converter this[int index] { get; set; }
+        public void Add(Converter converter);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public void Remove(Converter converter);
+    }
+    public sealed class CustomError : ConfigurationElement {
+        public CustomError(int statusCode, string redirect);
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string Redirect { get; set; }
+        public int StatusCode { get; set; }
+        public override bool Equals(object customError);
+        public override int GetHashCode();
+    }
+    public sealed class CustomErrorCollection : ConfigurationElementCollection {
+        public CustomErrorCollection();
+        public string[] AllKeys { get; }
+        public override ConfigurationElementCollectionType CollectionType { get; }
+        protected override string ElementName { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public CustomError this[int index] { get; set; }
+        public new CustomError this[string statusCode] { get; }
+        public void Add(CustomError customError);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        public CustomError Get(int index);
+        public CustomError Get(string statusCode);
+        protected override object GetElementKey(ConfigurationElement element);
+        public string GetKey(int index);
+        public void Remove(string statusCode);
+        public void RemoveAt(int index);
+        public void Set(CustomError customError);
+    }
+    public enum CustomErrorsMode {
+        Off = 2,
+        On = 1,
+        RemoteOnly = 0,
+    }
+    public enum CustomErrorsRedirectMode {
+        ResponseRedirect = 0,
+        ResponseRewrite = 1,
+    }
+    public sealed class CustomErrorsSection : ConfigurationSection {
+        public CustomErrorsSection();
+        public bool AllowNestedErrors { get; set; }
+        public string DefaultRedirect { get; set; }
+        public CustomErrorCollection Errors { get; }
+        public CustomErrorsMode Mode { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public CustomErrorsRedirectMode RedirectMode { get; set; }
+        protected override void DeserializeSection(XmlReader reader);
+        protected override void Reset(ConfigurationElement parentElement);
+    }
+    public sealed class DeploymentSection : ConfigurationSection {
+        public DeploymentSection();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public bool Retail { get; set; }
+    }
+    public sealed class EventMappingSettings : ConfigurationElement {
+        public EventMappingSettings(string name, string type);
+        public EventMappingSettings(string name, string type, int startEventCode, int endEventCode);
+        public int EndEventCode { get; set; }
+        public string Name { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public int StartEventCode { get; set; }
+        public string Type { get; set; }
+    }
+    public sealed class EventMappingSettingsCollection : ConfigurationElementCollection {
+        public EventMappingSettingsCollection();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public EventMappingSettings this[int index] { get; set; }
+        public new EventMappingSettings this[string key] { get; }
+        public void Add(EventMappingSettings eventMappingSettings);
+        public void Clear();
+        public bool Contains(string name);
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public int IndexOf(string name);
+        public void Insert(int index, EventMappingSettings eventMappingSettings);
+        public void Remove(string name);
+        public void RemoveAt(int index);
+    }
+    public sealed class ExpressionBuilder : ConfigurationElement {
+        public ExpressionBuilder(string expressionPrefix, string theType);
+        public string ExpressionPrefix { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string Type { get; set; }
+    }
+    public sealed class ExpressionBuilderCollection : ConfigurationElementCollection {
+        public ExpressionBuilderCollection();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public ExpressionBuilder this[int index] { get; set; }
+        public new ExpressionBuilder this[string name] { get; }
+        public void Add(ExpressionBuilder buildProvider);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public void Remove(string name);
+        public void RemoveAt(int index);
+    }
+    public enum FcnMode {
+        Default = 1,
+        Disabled = 2,
+        NotSet = 0,
+        Single = 3,
+    }
+    public sealed class FolderLevelBuildProvider : ConfigurationElement {
+        public FolderLevelBuildProvider(string name, string type);
+        public string Name { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string Type { get; set; }
+        public override bool Equals(object provider);
+        public override int GetHashCode();
+    }
+    public sealed class FolderLevelBuildProviderCollection : ConfigurationElementCollection {
+        public FolderLevelBuildProviderCollection();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public FolderLevelBuildProvider this[int index] { get; set; }
+        public new BuildProvider this[string name] { get; }
+        public void Add(FolderLevelBuildProvider buildProvider);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public void Remove(string name);
+        public void RemoveAt(int index);
+    }
+    public sealed class FormsAuthenticationConfiguration : ConfigurationElement {
+        public FormsAuthenticationConfiguration();
+        public HttpCookieMode Cookieless { get; set; }
+        public FormsAuthenticationCredentials Credentials { get; }
+        public string DefaultUrl { get; set; }
+        public string Domain { get; set; }
+        protected override ConfigurationElementProperty ElementProperty { get; }
+        public bool EnableCrossAppRedirects { get; set; }
+        public string LoginUrl { get; set; }
+        public string Name { get; set; }
+        public string Path { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public FormsProtectionEnum Protection { get; set; }
+        public bool RequireSSL { get; set; }
+        public bool SlidingExpiration { get; set; }
+        public TicketCompatibilityMode TicketCompatibilityMode { get; set; }
+        public TimeSpan Timeout { get; set; }
+    }
+    public sealed class FormsAuthenticationCredentials : ConfigurationElement {
+        public FormsAuthenticationCredentials();
+        public FormsAuthPasswordFormat PasswordFormat { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public FormsAuthenticationUserCollection Users { get; }
+    }
+    public sealed class FormsAuthenticationUser : ConfigurationElement {
+        public FormsAuthenticationUser(string name, string password);
+        public string Name { get; set; }
+        public string Password { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class FormsAuthenticationUserCollection : ConfigurationElementCollection {
+        public FormsAuthenticationUserCollection();
+        public string[] AllKeys { get; }
+        public override ConfigurationElementCollectionType CollectionType { get; }
+        protected override string ElementName { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public FormsAuthenticationUser this[int index] { get; set; }
+        public new FormsAuthenticationUser this[string name] { get; }
+        protected override bool ThrowOnDuplicate { get; }
+        public void Add(FormsAuthenticationUser user);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        public FormsAuthenticationUser Get(int index);
+        public FormsAuthenticationUser Get(string name);
+        protected override object GetElementKey(ConfigurationElement element);
+        public string GetKey(int index);
+        public void Remove(string name);
+        public void RemoveAt(int index);
+        public void Set(FormsAuthenticationUser user);
+    }
+    public enum FormsAuthPasswordFormat {
+        Clear = 0,
+        MD5 = 2,
+        SHA1 = 1,
+    }
+    public enum FormsProtectionEnum {
+        All = 0,
+        Encryption = 2,
+        None = 1,
+        Validation = 3,
+    }
+    public sealed class FullTrustAssembliesSection : ConfigurationSection {
+        public FullTrustAssembliesSection();
+        public FullTrustAssemblyCollection FullTrustAssemblies { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class FullTrustAssembly : ConfigurationElement {
+        public FullTrustAssembly(string assemblyName, string version, string publicKey);
+        public string AssemblyName { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string PublicKey { get; set; }
+        public string Version { get; set; }
+    }
+    public sealed class FullTrustAssemblyCollection : ConfigurationElementCollection {
+        public FullTrustAssemblyCollection();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public FullTrustAssembly this[int index] { get; set; }
+        public void Add(FullTrustAssembly fullTrustAssembly);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public void Remove(string key);
+        public void RemoveAt(int index);
+    }
+    public sealed class GlobalizationSection : ConfigurationSection {
+        public GlobalizationSection();
+        public string Culture { get; set; }
+        public bool EnableBestFitResponseEncoding { get; set; }
+        public bool EnableClientBasedCulture { get; set; }
+        public Encoding FileEncoding { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public Encoding RequestEncoding { get; set; }
+        public string ResourceProviderFactoryType { get; set; }
+        public Encoding ResponseEncoding { get; set; }
+        public Encoding ResponseHeaderEncoding { get; set; }
+        public string UICulture { get; set; }
+        protected override void PostDeserialize();
+        protected override void PreSerialize(XmlWriter writer);
+    }
+    public sealed class HealthMonitoringSection : ConfigurationSection {
+        public HealthMonitoringSection();
+        public BufferModesCollection BufferModes { get; }
+        public bool Enabled { get; set; }
+        public EventMappingSettingsCollection EventMappings { get; }
+        public TimeSpan HeartbeatInterval { get; set; }
+        public ProfileSettingsCollection Profiles { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public ProviderSettingsCollection Providers { get; }
+        public RuleSettingsCollection Rules { get; }
+    }
+    public sealed class HostingEnvironmentSection : ConfigurationSection {
+        public HostingEnvironmentSection();
+        public TimeSpan IdleTimeout { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public bool ShadowCopyBinAssemblies { get; set; }
+        public TimeSpan ShutdownTimeout { get; set; }
+        public TimeSpan UrlMetadataSlidingExpiration { get; set; }
+    }
+    public class HttpCapabilitiesBase : IFilterResolutionService {
+        public HttpCapabilitiesBase();
+        public bool ActiveXControls { get; }
+        public IDictionary Adapters { get; }
+        public bool AOL { get; }
+        public bool BackgroundSounds { get; }
+        public bool Beta { get; }
+        public string Browser { get; }
+        public static HttpCapabilitiesProvider BrowserCapabilitiesProvider { get; set; }
+        public ArrayList Browsers { get; }
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
+        public IDictionary Capabilities { get; set; }
+        public bool CDF { get; }
+        public Version ClrVersion { get; }
+        public bool Cookies { get; }
+        public bool Crawler { get; }
+        public virtual int DefaultSubmitButtonLimit { get; }
+        public Version EcmaScriptVersion { get; }
+        public bool Frames { get; }
+        public virtual int GatewayMajorVersion { get; }
+        public virtual double GatewayMinorVersion { get; }
+        public virtual string GatewayVersion { get; }
+        public virtual bool HasBackButton { get; }
+        public virtual bool HidesRightAlignedMultiselectScrollbars { get; }
+        public string HtmlTextWriter { get; set; }
+        public string Id { get; }
+        public virtual string InputType { get; }
+        public virtual bool IsColor { get; }
+        public virtual bool IsMobileDevice { get; }
+        public bool JavaApplets { get; }
+        public bool JavaScript { get; }
+        public Version JScriptVersion { get; }
+        public int MajorVersion { get; }
+        public virtual int MaximumHrefLength { get; }
+        public virtual int MaximumRenderedPageSize { get; }
+        public virtual int MaximumSoftkeyLabelLength { get; }
+        public double MinorVersion { get; }
+        public string MinorVersionString { get; }
+        public virtual string MobileDeviceManufacturer { get; }
+        public virtual string MobileDeviceModel { get; }
+        public Version MSDomVersion { get; }
+        public virtual int NumberOfSoftkeys { get; }
+        public string Platform { get; }
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
+        public bool RequiresControlStateInSession { get; }
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
+        public bool Tables { get; }
+        public Type TagWriter { get; }
+        public virtual string this[string key] { get; }
+        public string Type { get; }
+        public bool UseOptimizedCacheKey { get; }
+        public bool VBScript { get; }
+        public string Version { get; }
+        public Version W3CDomVersion { get; }
+        public bool Win16 { get; }
+        public bool Win32 { get; }
+        public void AddBrowser(string browserName);
+        public HtmlTextWriter CreateHtmlTextWriter(TextWriter w);
+        public void DisableOptimizedCacheKey();
+        public Version[] GetClrVersions();
+        public static HttpCapabilitiesBase GetConfigCapabilities(string configKey, HttpRequest request);
+        protected virtual void Init();
+        public bool IsBrowser(string browserName);
+        int System.Web.UI.IFilterResolutionService.CompareFilters(string filter1, string filter2);
+        bool System.Web.UI.IFilterResolutionService.EvaluateFilter(string filterName);
+    }
+    public class HttpCapabilitiesDefaultProvider : HttpCapabilitiesProvider {
+        public HttpCapabilitiesDefaultProvider();
+        public HttpCapabilitiesDefaultProvider(HttpCapabilitiesDefaultProvider parent);
+        public TimeSpan CacheTime { get; set; }
+        public Type ResultType { get; set; }
+        public int UserAgentCacheKeyLength { get; set; }
+        public void AddDependency(string variable);
+        public virtual void AddRuleList(ArrayList ruleList);
+        public override HttpBrowserCapabilities GetBrowserCapabilities(HttpRequest request);
+    }
+    public abstract class HttpCapabilitiesProvider {
+        protected HttpCapabilitiesProvider();
+        public abstract HttpBrowserCapabilities GetBrowserCapabilities(HttpRequest request);
+    }
+    public class HttpCapabilitiesSectionHandler : IConfigurationSectionHandler {
+        public HttpCapabilitiesSectionHandler();
+        public object Create(object parent, object configurationContext, XmlNode section);
+    }
+    public class HttpConfigurationContext {
+        public string VirtualPath { get; }
+    }
+    public sealed class HttpCookiesSection : ConfigurationSection {
+        public HttpCookiesSection();
+        public string Domain { get; set; }
+        public bool HttpOnlyCookies { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public bool RequireSSL { get; set; }
+    }
+    public sealed class HttpHandlerAction : ConfigurationElement {
+        public HttpHandlerAction(string path, string type, string verb);
+        public HttpHandlerAction(string path, string type, string verb, bool validate);
+        public string Path { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string Type { get; set; }
+        public bool Validate { get; set; }
+        public string Verb { get; set; }
+    }
+    public sealed class HttpHandlerActionCollection : ConfigurationElementCollection {
+        public HttpHandlerActionCollection();
+        public override ConfigurationElementCollectionType CollectionType { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public HttpHandlerAction this[int index] { get; set; }
+        protected override bool ThrowOnDuplicate { get; }
+        public void Add(HttpHandlerAction httpHandlerAction);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public int IndexOf(HttpHandlerAction action);
+        public void Remove(string verb, string path);
+        public void Remove(HttpHandlerAction action);
+        public void RemoveAt(int index);
+    }
+    public sealed class HttpHandlersSection : ConfigurationSection {
+        public HttpHandlersSection();
+        public HttpHandlerActionCollection Handlers { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class HttpModuleAction : ConfigurationElement {
+        public HttpModuleAction(string name, string type);
+        protected override ConfigurationElementProperty ElementProperty { get; }
+        public string Name { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string Type { get; set; }
+    }
+    public sealed class HttpModuleActionCollection : ConfigurationElementCollection {
+        public HttpModuleActionCollection();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public HttpModuleAction this[int index] { get; set; }
+        public void Add(HttpModuleAction httpModule);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public int IndexOf(HttpModuleAction action);
+        protected override bool IsElementRemovable(ConfigurationElement element);
+        public void Remove(string name);
+        public void Remove(HttpModuleAction action);
+        public void RemoveAt(int index);
+    }
+    public sealed class HttpModulesSection : ConfigurationSection {
+        public HttpModulesSection();
+        public HttpModuleActionCollection Modules { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class HttpRuntimeSection : ConfigurationSection {
+        public HttpRuntimeSection();
+        public bool AllowDynamicModuleRegistration { get; set; }
+        public bool ApartmentThreading { get; set; }
+        public int AppRequestQueueLimit { get; set; }
+        public AsyncPreloadModeFlags AsyncPreloadMode { get; set; }
+        public TimeSpan DefaultRegexMatchTimeout { get; set; }
+        public TimeSpan DelayNotificationTimeout { get; set; }
+        public bool Enable { get; set; }
+        public bool EnableHeaderChecking { get; set; }
+        public bool EnableKernelOutputCache { get; set; }
+        public bool EnableVersionHeader { get; set; }
+        public string EncoderType { get; set; }
+        public TimeSpan ExecutionTimeout { get; set; }
+        public FcnMode FcnMode { get; set; }
+        public int MaxQueryStringLength { get; set; }
+        public int MaxRequestLength { get; set; }
+        public int MaxUrlLength { get; set; }
+        public int MaxWaitChangeNotification { get; set; }
+        public int MinFreeThreads { get; set; }
+        public int MinLocalRequestFreeThreads { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public bool RelaxedUrlToFileSystemMapping { get; set; }
+        public int RequestLengthDiskThreshold { get; set; }
+        public string RequestPathInvalidCharacters { get; set; }
+        public Version RequestValidationMode { get; set; }
+        public string RequestValidationType { get; set; }
+        public bool RequireRootedSaveAsPath { get; set; }
+        public bool SendCacheControlHeader { get; set; }
+        public TimeSpan ShutdownTimeout { get; set; }
+        public string TargetFramework { get; set; }
+        public bool UseFullyQualifiedRedirectUrl { get; set; }
+        public int WaitChangeNotification { get; set; }
+        protected override void SetReadOnly();
+    }
+    public interface IConfigMapPath {
+        string GetAppPathForPath(string siteID, string path);
+        void GetDefaultSiteNameAndID(out string siteName, out string siteID);
+        string GetMachineConfigFilename();
+        void GetPathConfigFilename(string siteID, string path, out string directory, out string baseName);
+        string GetRootWebConfigFilename();
+        string MapPath(string siteID, string path);
+        void ResolveSiteArgument(string siteArgument, out string siteName, out string siteID);
+    }
+    public interface IConfigMapPathFactory {
+        IConfigMapPath Create(string virtualPath, string physicalPath);
+    }
+    public sealed class IdentitySection : ConfigurationSection {
+        public IdentitySection();
+        public bool Impersonate { get; set; }
+        public string Password { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string UserName { get; set; }
+        protected override object GetRuntimeObject();
+        protected override void Reset(ConfigurationElement parentElement);
+        protected override void Unmerge(ConfigurationElement sourceElement, ConfigurationElement parentElement, ConfigurationSaveMode saveMode);
+    }
+    public sealed class IgnoreDeviceFilterElement : ConfigurationElement {
+        public IgnoreDeviceFilterElement(string name);
+        protected override ConfigurationElementProperty ElementProperty { get; }
+        public string Name { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class IgnoreDeviceFilterElementCollection : ConfigurationElementCollection {
+        public IgnoreDeviceFilterElementCollection();
+        public override ConfigurationElementCollectionType CollectionType { get; }
+        protected override string ElementName { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public IgnoreDeviceFilterElement this[int index] { get; set; }
+        public new IgnoreDeviceFilterElement this[string name] { get; }
+        public void Add(IgnoreDeviceFilterElement deviceFilter);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public void Remove(string name);
+        public void Remove(IgnoreDeviceFilterElement deviceFilter);
+        public void RemoveAt(int index);
+    }
+    public interface IRemoteWebConfigurationHostServer {
+        string DoEncryptOrDecrypt(bool doEncrypt, string xmlString, string protectionProviderName, string protectionProviderType, string[] parameterKeys, string[] parameterValues);
+        byte[] GetData(string fileName, bool getReadTimeOnly, out long readTime);
+        void GetFileDetails(string name, out bool exists, out long size, out long createDate, out long lastWriteDate);
+        string GetFilePaths(int webLevel, string path, string site, string locationSubPath);
+        void WriteData(string fileName, string templateFileName, byte[] data, ref long readTime);
+    }
+    public sealed class LowerCaseStringConverter : TypeConverter {
+        public LowerCaseStringConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext ctx, Type type);
+        public override bool CanConvertTo(ITypeDescriptorContext ctx, Type type);
+        public override object ConvertFrom(ITypeDescriptorContext ctx, CultureInfo ci, object data);
+        public override object ConvertTo(ITypeDescriptorContext ctx, CultureInfo ci, object value, Type type);
+    }
+    public enum MachineKeyCompatibilityMode {
+        Framework20SP1 = 0,
+        Framework20SP2 = 1,
+        Framework45 = 2,
+    }
+    public sealed class MachineKeySection : ConfigurationSection {
+        public MachineKeySection();
+        public string ApplicationName { get; set; }
+        public MachineKeyCompatibilityMode CompatibilityMode { get; set; }
+        public string DataProtectorType { get; set; }
+        public string Decryption { get; set; }
+        public string DecryptionKey { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public MachineKeyValidation Validation { get; set; }
+        public string ValidationAlgorithm { get; set; }
+        public string ValidationKey { get; set; }
+        protected override void Reset(ConfigurationElement parentElement);
+        protected override void SetReadOnly();
+    }
+    public enum MachineKeyValidation {
+        AES = 3,
+        Custom = 7,
+        HMACSHA256 = 4,
+        HMACSHA384 = 5,
+        HMACSHA512 = 6,
+        MD5 = 0,
+        SHA1 = 1,
+        TripleDES = 2,
+    }
+    public sealed class MachineKeyValidationConverter : ConfigurationConverterBase {
+        public MachineKeyValidationConverter();
+        public override object ConvertFrom(ITypeDescriptorContext ctx, CultureInfo ci, object data);
+        public override object ConvertTo(ITypeDescriptorContext ctx, CultureInfo ci, object value, Type type);
+    }
+    public enum MembershipPasswordCompatibilityMode {
+        Framework20 = 0,
+        Framework40 = 1,
+    }
+    public sealed class MembershipSection : ConfigurationSection {
+        public MembershipSection();
+        public string DefaultProvider { get; set; }
+        public string HashAlgorithmType { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public ProviderSettingsCollection Providers { get; }
+        public TimeSpan UserIsOnlineTimeWindow { get; set; }
+    }
+    public sealed class NamespaceCollection : ConfigurationElementCollection {
+        public NamespaceCollection();
+        public bool AutoImportVBNamespace { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public NamespaceInfo this[int index] { get; set; }
+        public void Add(NamespaceInfo namespaceInformation);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public void Remove(string s);
+        public void RemoveAt(int index);
+    }
+    public sealed class NamespaceInfo : ConfigurationElement {
+        public NamespaceInfo(string name);
+        public string Namespace { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public override bool Equals(object namespaceInformation);
+        public override int GetHashCode();
+    }
+    public sealed class OutputCacheProfile : ConfigurationElement {
+        public OutputCacheProfile(string name);
+        public int Duration { get; set; }
+        public bool Enabled { get; set; }
+        public OutputCacheLocation Location { get; set; }
+        public string Name { get; set; }
+        public bool NoStore { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string SqlDependency { get; set; }
+        public string VaryByContentEncoding { get; set; }
+        public string VaryByControl { get; set; }
+        public string VaryByCustom { get; set; }
+        public string VaryByHeader { get; set; }
+        public string VaryByParam { get; set; }
+    }
+    public sealed class OutputCacheProfileCollection : ConfigurationElementCollection {
+        public OutputCacheProfileCollection();
+        public string[] AllKeys { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public OutputCacheProfile this[int index] { get; set; }
+        public new OutputCacheProfile this[string name] { get; }
+        public void Add(OutputCacheProfile name);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        public OutputCacheProfile Get(int index);
+        public OutputCacheProfile Get(string name);
+        protected override object GetElementKey(ConfigurationElement element);
+        public string GetKey(int index);
+        public void Remove(string name);
+        public void RemoveAt(int index);
+        public void Set(OutputCacheProfile user);
+    }
+    public sealed class OutputCacheSection : ConfigurationSection {
+        public OutputCacheSection();
+        public string DefaultProviderName { get; set; }
+        public bool EnableFragmentCache { get; set; }
+        public bool EnableKernelCacheForVaryByStar { get; set; }
+        public bool EnableOutputCache { get; set; }
+        public bool OmitVaryStar { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public ProviderSettingsCollection Providers { get; }
+        public bool SendCacheControlHeader { get; set; }
+    }
+    public sealed class OutputCacheSettingsSection : ConfigurationSection {
+        public OutputCacheSettingsSection();
+        public OutputCacheProfileCollection OutputCacheProfiles { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public enum PagesEnableSessionState {
+        False = 0,
+        ReadOnly = 1,
+        True = 2,
+    }
+    public sealed class PagesSection : ConfigurationSection {
+        public PagesSection();
+        public TimeSpan AsyncTimeout { get; set; }
+        public bool AutoEventWireup { get; set; }
+        public bool Buffer { get; set; }
+        public ClientIDMode ClientIDMode { get; set; }
+        public CompilationMode CompilationMode { get; set; }
+        public Version ControlRenderingCompatibilityVersion { get; set; }
+        public TagPrefixCollection Controls { get; }
+        public bool EnableEventValidation { get; set; }
+        public PagesEnableSessionState EnableSessionState { get; set; }
+        public bool EnableViewState { get; set; }
+        public bool EnableViewStateMac { get; set; }
+        public IgnoreDeviceFilterElementCollection IgnoreDeviceFilters { get; }
+        public bool MaintainScrollPositionOnPostBack { get; set; }
+        public string MasterPageFile { get; set; }
+        public int MaxPageStateFieldLength { get; set; }
+        public NamespaceCollection Namespaces { get; }
+        public string PageBaseType { get; set; }
+        public string PageParserFilterType { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public bool RenderAllHiddenFieldsAtTopOfForm { get; set; }
+        public bool SmartNavigation { get; set; }
+        public string StyleSheetTheme { get; set; }
+        public TagMapCollection TagMapping { get; }
+        public string Theme { get; set; }
+        public string UserControlBaseType { get; set; }
+        public bool ValidateRequest { get; set; }
+        public ViewStateEncryptionMode ViewStateEncryptionMode { get; set; }
+        protected override void DeserializeSection(XmlReader reader);
+        protected override void SetReadOnly();
+    }
+    public sealed class PartialTrustVisibleAssembliesSection : ConfigurationSection {
+        public PartialTrustVisibleAssembliesSection();
+        public PartialTrustVisibleAssemblyCollection PartialTrustVisibleAssemblies { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class PartialTrustVisibleAssembly : ConfigurationElement {
+        public PartialTrustVisibleAssembly(string assemblyName, string publicKey);
+        public string AssemblyName { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string PublicKey { get; set; }
+    }
+    public sealed class PartialTrustVisibleAssemblyCollection : ConfigurationElementCollection {
+        public PartialTrustVisibleAssemblyCollection();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public PartialTrustVisibleAssembly this[int index] { get; set; }
+        public void Add(PartialTrustVisibleAssembly partialTrustVisibleAssembly);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public void Remove(string key);
+        public void RemoveAt(int index);
+    }
+    public sealed class PassportAuthentication : ConfigurationElement {
+        public PassportAuthentication();
+        protected override ConfigurationElementProperty ElementProperty { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string RedirectUrl { get; set; }
+    }
+    public enum ProcessModelComAuthenticationLevel {
+        Call = 1,
+        Connect = 2,
+        Default = 3,
+        None = 0,
+        Pkt = 4,
+        PktIntegrity = 5,
+        PktPrivacy = 6,
+    }
+    public enum ProcessModelComImpersonationLevel {
+        Anonymous = 1,
+        Default = 0,
+        Delegate = 2,
+        Identify = 3,
+        Impersonate = 4,
+    }
+    public enum ProcessModelLogLevel {
+        All = 1,
+        Errors = 2,
+        None = 0,
+    }
+    public sealed class ProcessModelSection : ConfigurationSection {
+        public ProcessModelSection();
+        public bool AutoConfig { get; set; }
+        public TimeSpan ClientConnectedCheck { get; set; }
+        public ProcessModelComAuthenticationLevel ComAuthenticationLevel { get; set; }
+        public ProcessModelComImpersonationLevel ComImpersonationLevel { get; set; }
+        public int CpuMask { get; set; }
+        protected override ConfigurationElementProperty ElementProperty { get; }
+        public bool Enable { get; set; }
+        public TimeSpan IdleTimeout { get; set; }
+        public ProcessModelLogLevel LogLevel { get; set; }
+        public int MaxAppDomains { get; set; }
+        public int MaxIOThreads { get; set; }
+        public int MaxWorkerThreads { get; set; }
+        public int MemoryLimit { get; set; }
+        public int MinIOThreads { get; set; }
+        public int MinWorkerThreads { get; set; }
+        public string Password { get; set; }
+        public TimeSpan PingFrequency { get; set; }
+        public TimeSpan PingTimeout { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public int RequestLimit { get; set; }
+        public int RequestQueueLimit { get; set; }
+        public TimeSpan ResponseDeadlockInterval { get; set; }
+        public TimeSpan ResponseRestartDeadlockInterval { get; set; }
+        public int RestartQueueLimit { get; set; }
+        public string ServerErrorMessageFile { get; set; }
+        public TimeSpan ShutdownTimeout { get; set; }
+        public TimeSpan Timeout { get; set; }
+        public string UserName { get; set; }
+        public bool WebGarden { get; set; }
+    }
+    public sealed class ProfileGroupSettings : ConfigurationElement {
+        public ProfileGroupSettings(string name);
+        public string Name { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public ProfilePropertySettingsCollection PropertySettings { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+    }
+    public sealed class ProfileGroupSettingsCollection : ConfigurationElementCollection {
+        public ProfileGroupSettingsCollection();
+        public string[] AllKeys { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public ProfileGroupSettings this[int index] { get; set; }
+        public new ProfileGroupSettings this[string name] { get; }
+        public void Add(ProfileGroupSettings group);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        public ProfileGroupSettings Get(int index);
+        public ProfileGroupSettings Get(string name);
+        protected override object GetElementKey(ConfigurationElement element);
+        public string GetKey(int index);
+        public int IndexOf(ProfileGroupSettings group);
+        protected override bool IsModified();
+        public void Remove(string name);
+        public void RemoveAt(int index);
+        protected override void ResetModified();
+        public void Set(ProfileGroupSettings group);
+    }
+    public enum ProfileGuidedOptimizationsFlags {
+        All = 1,
+        None = 0,
+    }
+    public sealed class ProfilePropertySettings : ConfigurationElement {
+        public ProfilePropertySettings(string name);
+        public ProfilePropertySettings(string name, bool readOnly, SerializationMode serializeAs, string providerName, string defaultValue, string profileType, bool allowAnonymous, string customProviderData);
+        public bool AllowAnonymous { get; set; }
+        public string CustomProviderData { get; set; }
+        public string DefaultValue { get; set; }
+        public string Name { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string Provider { get; set; }
+        public bool ReadOnly { get; set; }
+        public SerializationMode SerializeAs { get; set; }
+        public string Type { get; set; }
+    }
+    public class ProfilePropertySettingsCollection : ConfigurationElementCollection {
+        public ProfilePropertySettingsCollection();
+        public string[] AllKeys { get; }
+        protected virtual bool AllowClear { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public ProfilePropertySettings this[int index] { get; set; }
+        public new ProfilePropertySettings this[string name] { get; }
+        protected override bool ThrowOnDuplicate { get; }
+        public void Add(ProfilePropertySettings propertySettings);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        public ProfilePropertySettings Get(int index);
+        public ProfilePropertySettings Get(string name);
+        protected override object GetElementKey(ConfigurationElement element);
+        public string GetKey(int index);
+        public int IndexOf(ProfilePropertySettings propertySettings);
+        protected override bool OnDeserializeUnrecognizedElement(string elementName, XmlReader reader);
+        public void Remove(string name);
+        public void RemoveAt(int index);
+        public void Set(ProfilePropertySettings propertySettings);
+    }
+    public sealed class ProfileSection : ConfigurationSection {
+        public ProfileSection();
+        public bool AutomaticSaveEnabled { get; set; }
+        public string DefaultProvider { get; set; }
+        public bool Enabled { get; set; }
+        public string Inherits { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public RootProfilePropertySettingsCollection PropertySettings { get; }
+        public ProviderSettingsCollection Providers { get; }
+    }
+    public sealed class ProfileSettings : ConfigurationElement {
+        public ProfileSettings(string name);
+        public ProfileSettings(string name, int minInstances, int maxLimit, TimeSpan minInterval);
+        public ProfileSettings(string name, int minInstances, int maxLimit, TimeSpan minInterval, string custom);
+        public string Custom { get; set; }
+        public int MaxLimit { get; set; }
+        public int MinInstances { get; set; }
+        public TimeSpan MinInterval { get; set; }
+        public string Name { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class ProfileSettingsCollection : ConfigurationElementCollection {
+        public ProfileSettingsCollection();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public ProfileSettings this[int index] { get; set; }
+        public new ProfileSettings this[string key] { get; }
+        public void Add(ProfileSettings profilesSettings);
+        public void Clear();
+        public bool Contains(string name);
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public int IndexOf(string name);
+        public void Insert(int index, ProfileSettings authorizationSettings);
+        public void Remove(string name);
+        public void RemoveAt(int index);
+    }
+    public sealed class ProtocolCollection : ConfigurationElementCollection {
+        public ProtocolCollection();
+        public string[] AllKeys { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public ProtocolElement this[int index] { get; set; }
+        public new ProtocolElement this[string name] { get; }
+        public void Add(ProtocolElement protocolElement);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public void Remove(string name);
+        public void Remove(ProtocolElement protocolElement);
+        public void RemoveAt(int index);
+    }
+    public sealed class ProtocolElement : ConfigurationElement {
+        public ProtocolElement();
+        public ProtocolElement(string name);
+        public string AppDomainHandlerType { get; set; }
+        public string Name { get; set; }
+        public string ProcessHandlerType { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public bool Validate { get; set; }
+        protected override void PostDeserialize();
+    }
+    public sealed class ProtocolsConfigurationHandler : IConfigurationSectionHandler {
+        public ProtocolsConfigurationHandler();
+        public object Create(object parent, object configContextObj, XmlNode section);
+    }
+    public sealed class ProtocolsSection : ConfigurationSection {
+        public ProtocolsSection();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public ProtocolCollection Protocols { get; }
+    }
+    public static class ProvidersHelper {
+        public static ProviderBase InstantiateProvider(ProviderSettings providerSettings, Type providerType);
+        public static void InstantiateProviders(ProviderSettingsCollection configProviders, ProviderCollection providers, Type providerType);
+    }
+    public class RegexWorker {
+        public RegexWorker(HttpBrowserCapabilities browserCaps);
+        public string this[string key] { get; }
+        public bool ProcessRegex(string target, string regexExpression);
+    }
+    public class RemoteWebConfigurationHostServer : IRemoteWebConfigurationHostServer {
+        public RemoteWebConfigurationHostServer();
+        public string DoEncryptOrDecrypt(bool doEncrypt, string xmlString, string protectionProviderName, string protectionProviderType, string[] paramKeys, string[] paramValues);
+        public byte[] GetData(string fileName, bool getReadTimeOnly, out long readTime);
+        public void GetFileDetails(string name, out bool exists, out long size, out long createDate, out long lastWriteDate);
+        public string GetFilePaths(int webLevelAsInt, string path, string site, string locationSubPath);
+        public void WriteData(string fileName, string templateFileName, byte[] data, ref long readTime);
+    }
+    public sealed class RoleManagerSection : ConfigurationSection {
+        public RoleManagerSection();
+        public bool CacheRolesInCookie { get; set; }
+        public string CookieName { get; set; }
+        public string CookiePath { get; set; }
+        public CookieProtection CookieProtection { get; set; }
+        public bool CookieRequireSSL { get; set; }
+        public bool CookieSlidingExpiration { get; set; }
+        public TimeSpan CookieTimeout { get; set; }
+        public bool CreatePersistentCookie { get; set; }
+        public string DefaultProvider { get; set; }
+        public string Domain { get; set; }
+        public bool Enabled { get; set; }
+        public int MaxCachedResults { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public ProviderSettingsCollection Providers { get; }
+    }
+    public sealed class RootProfilePropertySettingsCollection : ProfilePropertySettingsCollection {
+        public RootProfilePropertySettingsCollection();
+        protected override bool AllowClear { get; }
+        public ProfileGroupSettingsCollection GroupSettings { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected override bool ThrowOnDuplicate { get; }
+        public override bool Equals(object rootProfilePropertySettingsCollection);
+        public override int GetHashCode();
+        protected override bool IsModified();
+        protected override bool OnDeserializeUnrecognizedElement(string elementName, XmlReader reader);
+        protected override void Reset(ConfigurationElement parentElement);
+        protected override void ResetModified();
+        protected override bool SerializeElement(XmlWriter writer, bool serializeCollectionKey);
+        protected override void Unmerge(ConfigurationElement sourceElement, ConfigurationElement parentElement, ConfigurationSaveMode saveMode);
+    }
+    public sealed class RuleSettings : ConfigurationElement {
+        public RuleSettings(string name, string eventName, string provider);
+        public RuleSettings(string name, string eventName, string provider, string profile, int minInstances, int maxLimit, TimeSpan minInterval);
+        public RuleSettings(string name, string eventName, string provider, string profile, int minInstances, int maxLimit, TimeSpan minInterval, string custom);
+        public string Custom { get; set; }
+        public string EventName { get; set; }
+        public int MaxLimit { get; set; }
+        public int MinInstances { get; set; }
+        public TimeSpan MinInterval { get; set; }
+        public string Name { get; set; }
+        public string Profile { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string Provider { get; set; }
+    }
+    public sealed class RuleSettingsCollection : ConfigurationElementCollection {
+        public RuleSettingsCollection();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public RuleSettings this[int index] { get; set; }
+        public new RuleSettings this[string key] { get; }
+        public void Add(RuleSettings ruleSettings);
+        public void Clear();
+        public bool Contains(string name);
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public int IndexOf(string name);
+        public void Insert(int index, RuleSettings eventSettings);
+        public void Remove(string name);
+        public void RemoveAt(int index);
+    }
+    public sealed class ScriptingAuthenticationServiceSection : ConfigurationSection {
+        public ScriptingAuthenticationServiceSection();
+        public bool Enabled { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public bool RequireSSL { get; set; }
+    }
+    public sealed class ScriptingJsonSerializationSection : ConfigurationSection {
+        public ScriptingJsonSerializationSection();
+        public ConvertersCollection Converters { get; }
+        public int MaxJsonLength { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public int RecursionLimit { get; set; }
+    }
+    public sealed class ScriptingProfileServiceSection : ConfigurationSection {
+        public ScriptingProfileServiceSection();
+        public bool Enabled { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string[] ReadAccessProperties { get; set; }
+        public string[] WriteAccessProperties { get; set; }
+    }
+    public sealed class ScriptingRoleServiceSection : ConfigurationSection {
+        public ScriptingRoleServiceSection();
+        public bool Enabled { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class ScriptingScriptResourceHandlerSection : ConfigurationSection {
+        public ScriptingScriptResourceHandlerSection();
+        public bool EnableCaching { get; set; }
+        public bool EnableCompression { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class ScriptingSectionGroup : ConfigurationSectionGroup {
+        public ScriptingSectionGroup();
+        public ScriptingScriptResourceHandlerSection ScriptResourceHandler { get; }
+        public ScriptingWebServicesSectionGroup WebServices { get; }
+    }
+    public sealed class ScriptingWebServicesSectionGroup : ConfigurationSectionGroup {
+        public ScriptingWebServicesSectionGroup();
+        public ScriptingAuthenticationServiceSection AuthenticationService { get; }
+        public ScriptingJsonSerializationSection JsonSerialization { get; }
+        public ScriptingProfileServiceSection ProfileService { get; }
+        public ScriptingRoleServiceSection RoleService { get; }
+    }
+    public sealed class SecurityPolicySection : ConfigurationSection {
+        public SecurityPolicySection();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public TrustLevelCollection TrustLevels { get; }
+    }
+    public enum SerializationMode {
+        Binary = 2,
+        ProviderSpecific = 3,
+        String = 0,
+        Xml = 1,
+    }
+    public sealed class SessionPageStateSection : ConfigurationSection {
+        public const int DefaultHistorySize = 9;
+        public SessionPageStateSection();
+        public int HistorySize { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class SessionStateSection : ConfigurationSection {
+        public SessionStateSection();
+        public bool AllowCustomSqlDatabase { get; set; }
+        public bool CompressionEnabled { get; set; }
+        public HttpCookieMode Cookieless { get; set; }
+        public string CookieName { get; set; }
+        public string CustomProvider { get; set; }
+        protected override ConfigurationElementProperty ElementProperty { get; }
+        public SessionStateMode Mode { get; set; }
+        public string PartitionResolverType { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public ProviderSettingsCollection Providers { get; }
+        public bool RegenerateExpiredSessionId { get; set; }
+        public string SessionIDManagerType { get; set; }
+        public TimeSpan SqlCommandTimeout { get; set; }
+        public TimeSpan SqlConnectionRetryInterval { get; set; }
+        public string SqlConnectionString { get; set; }
+        public string StateConnectionString { get; set; }
+        public TimeSpan StateNetworkTimeout { get; set; }
+        public TimeSpan Timeout { get; set; }
+        public bool UseHostingIdentity { get; set; }
+        protected override void PostDeserialize();
+    }
+    public sealed class SiteMapSection : ConfigurationSection {
+        public SiteMapSection();
+        public string DefaultProvider { get; set; }
+        public bool Enabled { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public ProviderSettingsCollection Providers { get; }
+    }
+    public sealed class SqlCacheDependencyDatabase : ConfigurationElement {
+        public SqlCacheDependencyDatabase(string name, string connectionStringName);
+        public SqlCacheDependencyDatabase(string name, string connectionStringName, int pollTime);
+        public string ConnectionStringName { get; set; }
+        protected override ConfigurationElementProperty ElementProperty { get; }
+        public string Name { get; set; }
+        public int PollTime { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class SqlCacheDependencyDatabaseCollection : ConfigurationElementCollection {
+        public SqlCacheDependencyDatabaseCollection();
+        public string[] AllKeys { get; }
+        public SqlCacheDependencyDatabase this[int index] { get; set; }
+        public new SqlCacheDependencyDatabase this[string name] { get; }
+        public void Add(SqlCacheDependencyDatabase name);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        public SqlCacheDependencyDatabase Get(int index);
+        public SqlCacheDependencyDatabase Get(string name);
+        protected override object GetElementKey(ConfigurationElement element);
+        public string GetKey(int index);
+        public void Remove(string name);
+        public void RemoveAt(int index);
+        public void Set(SqlCacheDependencyDatabase user);
+    }
+    public sealed class SqlCacheDependencySection : ConfigurationSection {
+        public SqlCacheDependencySection();
+        public SqlCacheDependencyDatabaseCollection Databases { get; }
+        protected override ConfigurationElementProperty ElementProperty { get; }
+        public bool Enabled { get; set; }
+        public int PollTime { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected override void PostDeserialize();
+    }
+    public sealed class SystemWebCachingSectionGroup : ConfigurationSectionGroup {
+        public SystemWebCachingSectionGroup();
+        public CacheSection Cache { get; }
+        public OutputCacheSection OutputCache { get; }
+        public OutputCacheSettingsSection OutputCacheSettings { get; }
+        public SqlCacheDependencySection SqlCacheDependency { get; }
+    }
+    public sealed class SystemWebExtensionsSectionGroup : ConfigurationSectionGroup {
+        public SystemWebExtensionsSectionGroup();
+        public ScriptingSectionGroup Scripting { get; }
+    }
+    public sealed class SystemWebSectionGroup : ConfigurationSectionGroup {
+        public SystemWebSectionGroup();
+        public AnonymousIdentificationSection AnonymousIdentification { get; }
+        public AuthenticationSection Authentication { get; }
+        public AuthorizationSection Authorization { get; }
+        public DefaultSection BrowserCaps { get; }
+        public ClientTargetSection ClientTarget { get; }
+        public CompilationSection Compilation { get; }
+        public CustomErrorsSection CustomErrors { get; }
+        public DeploymentSection Deployment { get; }
+        public DefaultSection DeviceFilters { get; }
+        public FullTrustAssembliesSection FullTrustAssemblies { get; }
+        public GlobalizationSection Globalization { get; }
+        public HealthMonitoringSection HealthMonitoring { get; }
+        public HostingEnvironmentSection HostingEnvironment { get; }
+        public HttpCookiesSection HttpCookies { get; }
+        public HttpHandlersSection HttpHandlers { get; }
+        public HttpModulesSection HttpModules { get; }
+        public HttpRuntimeSection HttpRuntime { get; }
+        public IdentitySection Identity { get; }
+        public MachineKeySection MachineKey { get; }
+        public MembershipSection Membership { get; }
+        public ConfigurationSection MobileControls { get; }
+        public PagesSection Pages { get; }
+        public PartialTrustVisibleAssembliesSection PartialTrustVisibleAssemblies { get; }
+        public ProcessModelSection ProcessModel { get; }
+        public ProfileSection Profile { get; }
+        public DefaultSection Protocols { get; }
+        public RoleManagerSection RoleManager { get; }
+        public SecurityPolicySection SecurityPolicy { get; }
+        public SessionStateSection SessionState { get; }
+        public SiteMapSection SiteMap { get; }
+        public TraceSection Trace { get; }
+        public TrustSection Trust { get; }
+        public UrlMappingsSection UrlMappings { get; }
+        public WebControlsSection WebControls { get; }
+        public WebPartsSection WebParts { get; }
+        public WebServicesSection WebServices { get; }
+        public XhtmlConformanceSection XhtmlConformance { get; }
+    }
+    public sealed class TagMapCollection : ConfigurationElementCollection {
+        public TagMapCollection();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public TagMapInfo this[int index] { get; set; }
+        public void Add(TagMapInfo tagMapInformation);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public void Remove(TagMapInfo tagMapInformation);
+    }
+    public sealed class TagMapInfo : ConfigurationElement {
+        public TagMapInfo(string tagTypeName, string mappedTagTypeName);
+        public string MappedTagType { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string TagType { get; set; }
+        public override bool Equals(object o);
+        public override int GetHashCode();
+        protected override bool SerializeElement(XmlWriter writer, bool serializeCollectionKey);
+    }
+    public sealed class TagPrefixCollection : ConfigurationElementCollection {
+        public TagPrefixCollection();
+        public override ConfigurationElementCollectionType CollectionType { get; }
+        protected override string ElementName { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public TagPrefixInfo this[int index] { get; set; }
+        protected override bool ThrowOnDuplicate { get; }
+        public void Add(TagPrefixInfo tagPrefixInformation);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public void Remove(TagPrefixInfo tagPrefixInformation);
+    }
+    public sealed class TagPrefixInfo : ConfigurationElement {
+        public TagPrefixInfo(string tagPrefix, string nameSpace, string assembly, string tagName, string source);
+        public string Assembly { get; set; }
+        protected override ConfigurationElementProperty ElementProperty { get; }
+        public string Namespace { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string Source { get; set; }
+        public string TagName { get; set; }
+        public string TagPrefix { get; set; }
+        public override bool Equals(object prefix);
+        public override int GetHashCode();
+    }
+    public enum TicketCompatibilityMode {
+        Framework20 = 0,
+        Framework40 = 1,
+    }
+    public enum TraceDisplayMode {
+        SortByCategory = 2,
+        SortByTime = 1,
+    }
+    public sealed class TraceSection : ConfigurationSection {
+        public TraceSection();
+        public bool Enabled { get; set; }
+        public bool LocalOnly { get; set; }
+        public bool MostRecent { get; set; }
+        public bool PageOutput { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public int RequestLimit { get; set; }
+        public TraceDisplayMode TraceMode { get; set; }
+        public bool WriteToDiagnosticsTrace { get; set; }
+    }
+    public sealed class TransformerInfo : ConfigurationElement {
+        public TransformerInfo(string name, string type);
+        public string Name { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string Type { get; set; }
+        public override bool Equals(object o);
+        public override int GetHashCode();
+    }
+    public sealed class TransformerInfoCollection : ConfigurationElementCollection {
+        public TransformerInfoCollection();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public TransformerInfo this[int index] { get; set; }
+        public void Add(TransformerInfo transformerInfo);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public void Remove(string s);
+        public void RemoveAt(int index);
+    }
+    public sealed class TrustLevel : ConfigurationElement {
+        public TrustLevel(string name, string policyFile);
+        public string Name { get; set; }
+        public string PolicyFile { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class TrustLevelCollection : ConfigurationElementCollection {
+        public TrustLevelCollection();
+        public override ConfigurationElementCollectionType CollectionType { get; }
+        protected override string ElementName { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public TrustLevel this[int index] { get; set; }
+        public new TrustLevel this[string key] { get; }
+        protected override bool ThrowOnDuplicate { get; }
+        public void Add(TrustLevel trustLevel);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        public TrustLevel Get(int index);
+        protected override object GetElementKey(ConfigurationElement element);
+        protected override bool IsElementName(string elementname);
+        public void Remove(TrustLevel trustLevel);
+        public void RemoveAt(int index);
+        public void Set(int index, TrustLevel trustLevel);
+    }
+    public sealed class TrustSection : ConfigurationSection {
+        public TrustSection();
+        public string HostSecurityPolicyResolverType { get; set; }
+        public bool LegacyCasModel { get; set; }
+        public string Level { get; set; }
+        public string OriginUrl { get; set; }
+        public string PermissionSetName { get; set; }
+        public bool ProcessRequestInApplicationTrust { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class UrlMapping : ConfigurationElement {
+        public UrlMapping(string url, string mappedUrl);
+        public string MappedUrl { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string Url { get; }
+    }
+    public sealed class UrlMappingCollection : ConfigurationElementCollection {
+        public UrlMappingCollection();
+        public string[] AllKeys { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public UrlMapping this[int index] { get; set; }
+        public new UrlMapping this[string name] { get; }
+        public void Add(UrlMapping urlMapping);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public string GetKey(int index);
+        public void Remove(string name);
+        public void Remove(UrlMapping urlMapping);
+        public void RemoveAt(int index);
+    }
+    public sealed class UrlMappingsSection : ConfigurationSection {
+        public UrlMappingsSection();
+        public bool IsEnabled { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public UrlMappingCollection UrlMappings { get; }
+    }
+    public class UserMapPath : IConfigMapPath {
+        public UserMapPath(ConfigurationFileMap fileMap);
+        public string GetAppPathForPath(string siteID, string path);
+        public void GetDefaultSiteNameAndID(out string siteName, out string siteID);
+        public string GetMachineConfigFilename();
+        public void GetPathConfigFilename(string siteID, string path, out string directory, out string baseName);
+        public string GetRootWebConfigFilename();
+        public string MapPath(string siteID, string path);
+        public void ResolveSiteArgument(string siteArgument, out string siteName, out string siteID);
+    }
+    public sealed class VirtualDirectoryMapping {
+        public VirtualDirectoryMapping(string physicalDirectory, bool isAppRoot);
+        public VirtualDirectoryMapping(string physicalDirectory, bool isAppRoot, string configFileBaseName);
+        public string ConfigFileBaseName { get; set; }
+        public bool IsAppRoot { get; set; }
+        public string PhysicalDirectory { get; set; }
+        public string VirtualDirectory { get; }
+    }
+    public sealed class VirtualDirectoryMappingCollection : NameObjectCollectionBase {
+        public VirtualDirectoryMappingCollection();
+        public ICollection AllKeys { get; }
+        public VirtualDirectoryMapping this[int index] { get; }
+        public VirtualDirectoryMapping this[string virtualDirectory] { get; }
+        public void Add(string virtualDirectory, VirtualDirectoryMapping mapping);
+        public void Clear();
+        public void CopyTo(VirtualDirectoryMapping[] array, int index);
+        public VirtualDirectoryMapping Get(int index);
+        public VirtualDirectoryMapping Get(string virtualDirectory);
+        public string GetKey(int index);
+        public void Remove(string virtualDirectory);
+        public void RemoveAt(int index);
+    }
+    public enum WebApplicationLevel {
+        AboveApplication = 10,
+        AtApplication = 20,
+        BelowApplication = 30,
+    }
+    public sealed class WebConfigurationFileMap : ConfigurationFileMap {
+        public WebConfigurationFileMap();
+        public WebConfigurationFileMap(string machineConfigFileName);
+        public VirtualDirectoryMappingCollection VirtualDirectories { get; }
+        public override object Clone();
+    }
+    public static class WebConfigurationManager {
+        public static NameValueCollection AppSettings { get; }
+        public static ConnectionStringSettingsCollection ConnectionStrings { get; }
+        public static object GetSection(string sectionName);
+        public static object GetSection(string sectionName, string path);
+        public static object GetWebApplicationSection(string sectionName);
+        public static Configuration OpenMachineConfiguration();
+        public static Configuration OpenMachineConfiguration(string locationSubPath);
+        public static Configuration OpenMachineConfiguration(string locationSubPath, string server);
+        public static Configuration OpenMachineConfiguration(string locationSubPath, string server, IntPtr userToken);
+        public static Configuration OpenMachineConfiguration(string locationSubPath, string server, string userName, string password);
+        public static Configuration OpenMappedMachineConfiguration(ConfigurationFileMap fileMap);
+        public static Configuration OpenMappedMachineConfiguration(ConfigurationFileMap fileMap, string locationSubPath);
+        public static Configuration OpenMappedWebConfiguration(WebConfigurationFileMap fileMap, string path);
+        public static Configuration OpenMappedWebConfiguration(WebConfigurationFileMap fileMap, string path, string site);
+        public static Configuration OpenMappedWebConfiguration(WebConfigurationFileMap fileMap, string path, string site, string locationSubPath);
+        public static Configuration OpenWebConfiguration(string path);
+        public static Configuration OpenWebConfiguration(string path, string site);
+        public static Configuration OpenWebConfiguration(string path, string site, string locationSubPath);
+        public static Configuration OpenWebConfiguration(string path, string site, string locationSubPath, string server);
+        public static Configuration OpenWebConfiguration(string path, string site, string locationSubPath, string server, IntPtr userToken);
+        public static Configuration OpenWebConfiguration(string path, string site, string locationSubPath, string server, string userName, string password);
+    }
+    public sealed class WebContext {
+        public WebContext(WebApplicationLevel pathLevel, string site, string applicationPath, string path, string locationSubPath, string appConfigPath);
+        public WebApplicationLevel ApplicationLevel { get; }
+        public string ApplicationPath { get; }
+        public string LocationSubPath { get; }
+        public string Path { get; }
+        public string Site { get; }
+        public override string ToString();
+    }
+    public sealed class WebControlsSection : ConfigurationSection {
+        public WebControlsSection();
+        public string ClientScriptsLocation { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected override object GetRuntimeObject();
+    }
+    public sealed class WebPartsPersonalization : ConfigurationElement {
+        public WebPartsPersonalization();
+        public WebPartsPersonalizationAuthorization Authorization { get; }
+        public string DefaultProvider { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public ProviderSettingsCollection Providers { get; }
+    }
+    public sealed class WebPartsPersonalizationAuthorization : ConfigurationElement {
+        public WebPartsPersonalizationAuthorization();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public AuthorizationRuleCollection Rules { get; }
+    }
+    public sealed class WebPartsSection : ConfigurationSection {
+        public WebPartsSection();
+        public bool EnableExport { get; set; }
+        public WebPartsPersonalization Personalization { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public TransformerInfoCollection Transformers { get; }
+        protected override object GetRuntimeObject();
+    }
+    public enum XhtmlConformanceMode {
+        Legacy = 1,
+        Strict = 2,
+        Transitional = 0,
+    }
+    public sealed class XhtmlConformanceSection : ConfigurationSection {
+        public XhtmlConformanceSection();
+        public XhtmlConformanceMode Mode { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+}
```

