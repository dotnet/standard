# System.Net.Configuration

``` diff
+namespace System.Net.Configuration {
+    public sealed class AuthenticationModuleElement : ConfigurationElement {
+        public AuthenticationModuleElement();
+        public AuthenticationModuleElement(string typeName);
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string Type { get; set; }
+    }
+    public sealed class AuthenticationModuleElementCollection : ConfigurationElementCollection {
+        public AuthenticationModuleElementCollection();
+        public AuthenticationModuleElement this[int index] { get; set; }
+        public new AuthenticationModuleElement this[string name] { get; set; }
+        public void Add(AuthenticationModuleElement element);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public int IndexOf(AuthenticationModuleElement element);
+        public void Remove(AuthenticationModuleElement element);
+        public void Remove(string name);
+        public void RemoveAt(int index);
+    }
+    public sealed class AuthenticationModulesSection : ConfigurationSection {
+        public AuthenticationModulesSection();
+        public AuthenticationModuleElementCollection AuthenticationModules { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected override void InitializeDefault();
+        protected override void PostDeserialize();
+    }
+    public sealed class BypassElement : ConfigurationElement {
+        public BypassElement();
+        public BypassElement(string address);
+        public string Address { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class BypassElementCollection : ConfigurationElementCollection {
+        public BypassElementCollection();
+        public BypassElement this[int index] { get; set; }
+        public new BypassElement this[string name] { get; set; }
+        protected override bool ThrowOnDuplicate { get; }
+        public void Add(BypassElement element);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public int IndexOf(BypassElement element);
+        public void Remove(BypassElement element);
+        public void Remove(string name);
+        public void RemoveAt(int index);
+    }
+    public sealed class ConnectionManagementElement : ConfigurationElement {
+        public ConnectionManagementElement();
+        public ConnectionManagementElement(string address, int maxConnection);
+        public string Address { get; set; }
+        public int MaxConnection { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class ConnectionManagementElementCollection : ConfigurationElementCollection {
+        public ConnectionManagementElementCollection();
+        public ConnectionManagementElement this[int index] { get; set; }
+        public new ConnectionManagementElement this[string name] { get; set; }
+        public void Add(ConnectionManagementElement element);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public int IndexOf(ConnectionManagementElement element);
+        public void Remove(ConnectionManagementElement element);
+        public void Remove(string name);
+        public void RemoveAt(int index);
+    }
+    public sealed class ConnectionManagementSection : ConfigurationSection {
+        public ConnectionManagementSection();
+        public ConnectionManagementElementCollection ConnectionManagement { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class DefaultProxySection : ConfigurationSection {
+        public DefaultProxySection();
+        public BypassElementCollection BypassList { get; }
+        public bool Enabled { get; set; }
+        public ModuleElement Module { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public ProxyElement Proxy { get; }
+        public bool UseDefaultCredentials { get; set; }
+        protected override void PostDeserialize();
+        protected override void Reset(ConfigurationElement parentElement);
+    }
+    public sealed class FtpCachePolicyElement : ConfigurationElement {
+        public FtpCachePolicyElement();
+        public RequestCacheLevel PolicyLevel { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey);
+        protected override void Reset(ConfigurationElement parentElement);
+    }
+    public sealed class HttpCachePolicyElement : ConfigurationElement {
+        public HttpCachePolicyElement();
+        public TimeSpan MaximumAge { get; set; }
+        public TimeSpan MaximumStale { get; set; }
+        public TimeSpan MinimumFresh { get; set; }
+        public HttpRequestCacheLevel PolicyLevel { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey);
+        protected override void Reset(ConfigurationElement parentElement);
+    }
+    public sealed class HttpListenerElement : ConfigurationElement {
+        public HttpListenerElement();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public HttpListenerTimeoutsElement Timeouts { get; }
+        public bool UnescapeRequestUrl { get; }
+    }
+    public sealed class HttpListenerTimeoutsElement : ConfigurationElement {
+        public HttpListenerTimeoutsElement();
+        public TimeSpan DrainEntityBody { get; }
+        public TimeSpan EntityBody { get; }
+        public TimeSpan HeaderWait { get; }
+        public TimeSpan IdleConnection { get; }
+        public long MinSendBytesPerSecond { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public TimeSpan RequestQueue { get; }
+    }
+    public sealed class HttpWebRequestElement : ConfigurationElement {
+        public HttpWebRequestElement();
+        public int MaximumErrorResponseLength { get; set; }
+        public int MaximumResponseHeadersLength { get; set; }
+        public int MaximumUnauthorizedUploadLength { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public bool UseUnsafeHeaderParsing { get; set; }
+        protected override void PostDeserialize();
+    }
+    public sealed class Ipv6Element : ConfigurationElement {
+        public Ipv6Element();
+        public bool Enabled { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class MailSettingsSectionGroup : ConfigurationSectionGroup {
+        public MailSettingsSectionGroup();
+        public SmtpSection Smtp { get; }
+    }
+    public sealed class ModuleElement : ConfigurationElement {
+        public ModuleElement();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string Type { get; set; }
+    }
+    public sealed class NetSectionGroup : ConfigurationSectionGroup {
+        public NetSectionGroup();
+        public AuthenticationModulesSection AuthenticationModules { get; }
+        public ConnectionManagementSection ConnectionManagement { get; }
+        public DefaultProxySection DefaultProxy { get; }
+        public MailSettingsSectionGroup MailSettings { get; }
+        public RequestCachingSection RequestCaching { get; }
+        public SettingsSection Settings { get; }
+        public WebRequestModulesSection WebRequestModules { get; }
+        public static NetSectionGroup GetSectionGroup(Configuration config);
+    }
+    public sealed class PerformanceCountersElement : ConfigurationElement {
+        public PerformanceCountersElement();
+        public bool Enabled { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class ProxyElement : ConfigurationElement {
+        public ProxyElement();
+        public ProxyElement.AutoDetectValues AutoDetect { get; set; }
+        public ProxyElement.BypassOnLocalValues BypassOnLocal { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public Uri ProxyAddress { get; set; }
+        public Uri ScriptLocation { get; set; }
+        public ProxyElement.UseSystemDefaultValues UseSystemDefault { get; set; }
+        public enum AutoDetectValues {
+            False = 0,
+            True = 1,
+            Unspecified = -1,
+        }
+        public enum BypassOnLocalValues {
+            False = 0,
+            True = 1,
+            Unspecified = -1,
+        }
+        public enum UseSystemDefaultValues {
+            False = 0,
+            True = 1,
+            Unspecified = -1,
+        }
+    }
+    public sealed class RequestCachingSection : ConfigurationSection {
+        public RequestCachingSection();
+        public FtpCachePolicyElement DefaultFtpCachePolicy { get; }
+        public HttpCachePolicyElement DefaultHttpCachePolicy { get; }
+        public RequestCacheLevel DefaultPolicyLevel { get; set; }
+        public bool DisableAllCaching { get; set; }
+        public bool IsPrivateCache { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public TimeSpan UnspecifiedMaximumAge { get; set; }
+        protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey);
+        protected override void PostDeserialize();
+    }
+    public sealed class ServicePointManagerElement : ConfigurationElement {
+        public ServicePointManagerElement();
+        public bool CheckCertificateName { get; set; }
+        public bool CheckCertificateRevocationList { get; set; }
+        public int DnsRefreshTimeout { get; set; }
+        public bool EnableDnsRoundRobin { get; set; }
+        public EncryptionPolicy EncryptionPolicy { get; set; }
+        public bool Expect100Continue { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public bool UseNagleAlgorithm { get; set; }
+        protected override void PostDeserialize();
+    }
+    public sealed class SettingsSection : ConfigurationSection {
+        public SettingsSection();
+        public HttpListenerElement HttpListener { get; }
+        public HttpWebRequestElement HttpWebRequest { get; }
+        public Ipv6Element Ipv6 { get; }
+        public PerformanceCountersElement PerformanceCounters { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public ServicePointManagerElement ServicePointManager { get; }
+        public SocketElement Socket { get; }
+        public WebProxyScriptElement WebProxyScript { get; }
+        public WebUtilityElement WebUtility { get; }
+    }
+    public sealed class SmtpNetworkElement : ConfigurationElement {
+        public SmtpNetworkElement();
+        public string ClientDomain { get; set; }
+        public bool DefaultCredentials { get; set; }
+        public bool EnableSsl { get; set; }
+        public string Host { get; set; }
+        public string Password { get; set; }
+        public int Port { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string TargetName { get; set; }
+        public string UserName { get; set; }
+        protected override void PostDeserialize();
+    }
+    public sealed class SmtpSection : ConfigurationSection {
+        public SmtpSection();
+        public SmtpDeliveryFormat DeliveryFormat { get; set; }
+        public SmtpDeliveryMethod DeliveryMethod { get; set; }
+        public string From { get; set; }
+        public SmtpNetworkElement Network { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public SmtpSpecifiedPickupDirectoryElement SpecifiedPickupDirectory { get; }
+    }
+    public sealed class SmtpSpecifiedPickupDirectoryElement : ConfigurationElement {
+        public SmtpSpecifiedPickupDirectoryElement();
+        public string PickupDirectoryLocation { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class SocketElement : ConfigurationElement {
+        public SocketElement();
+        public bool AlwaysUseCompletionPortsForAccept { get; set; }
+        public bool AlwaysUseCompletionPortsForConnect { get; set; }
+        public IPProtectionLevel IPProtectionLevel { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected override void PostDeserialize();
+    }
+    public enum UnicodeDecodingConformance {
+        Auto = 0,
+        Compat = 2,
+        Loose = 3,
+        Strict = 1,
+    }
+    public enum UnicodeEncodingConformance {
+        Auto = 0,
+        Compat = 2,
+        Strict = 1,
+    }
+    public sealed class WebProxyScriptElement : ConfigurationElement {
+        public WebProxyScriptElement();
+        public TimeSpan DownloadTimeout { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected override void PostDeserialize();
+    }
+    public sealed class WebRequestModuleElement : ConfigurationElement {
+        public WebRequestModuleElement();
+        public WebRequestModuleElement(string prefix, string type);
+        public WebRequestModuleElement(string prefix, Type type);
+        public string Prefix { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public Type Type { get; set; }
+    }
+    public sealed class WebRequestModuleElementCollection : ConfigurationElementCollection {
+        public WebRequestModuleElementCollection();
+        public WebRequestModuleElement this[int index] { get; set; }
+        public new WebRequestModuleElement this[string name] { get; set; }
+        public void Add(WebRequestModuleElement element);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public int IndexOf(WebRequestModuleElement element);
+        public void Remove(WebRequestModuleElement element);
+        public void Remove(string name);
+        public void RemoveAt(int index);
+    }
+    public sealed class WebRequestModulesSection : ConfigurationSection {
+        public WebRequestModulesSection();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public WebRequestModuleElementCollection WebRequestModules { get; }
+        protected override void InitializeDefault();
+        protected override void PostDeserialize();
+    }
+    public sealed class WebUtilityElement : ConfigurationElement {
+        public WebUtilityElement();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public UnicodeDecodingConformance UnicodeDecodingConformance { get; set; }
+        public UnicodeEncodingConformance UnicodeEncodingConformance { get; set; }
+    }
+}
```

