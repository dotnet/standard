# System.IdentityModel.Services.Configuration

``` diff
+namespace System.IdentityModel.Services.Configuration {
+    public class FederationConfiguration {
+        public static readonly string DefaultFederationConfigurationName;
+        public FederationConfiguration();
+        public FederationConfiguration(bool loadConfig);
+        public FederationConfiguration(string federationConfigurationName);
+        public CookieHandler CookieHandler { get; set; }
+        public XmlElement CustomElement { get; set; }
+        public IdentityConfiguration IdentityConfiguration { get; set; }
+        public virtual bool IsInitialized { get; protected set; }
+        public string Name { get; }
+        public X509Certificate2 ServiceCertificate { get; set; }
+        public WsFederationConfiguration WsFederationConfiguration { get; set; }
+        public virtual void Initialize();
+        protected void LoadConfiguration(FederationConfigurationElement element);
+    }
+    public class FederationConfigurationCreatedEventArgs : EventArgs {
+        public FederationConfigurationCreatedEventArgs(FederationConfiguration config);
+        public FederationConfiguration FederationConfiguration { get; set; }
+    }
+    public sealed class FederationConfigurationElement : ConfigurationElement {
+        public FederationConfigurationElement();
+        public CookieHandlerElement CookieHandler { get; set; }
+        public XmlElement CustomElement { get; set; }
+        public string IdentityConfigurationName { get; set; }
+        public bool IsConfigured { get; }
+        public string Name { get; set; }
+        public ServiceCertificateElement ServiceCertificate { get; set; }
+        public WSFederationElement WsFederation { get; set; }
+        protected override bool OnDeserializeUnrecognizedElement(string elementName, XmlReader reader);
+    }
+    public sealed class FederationConfigurationElementCollection : ConfigurationElementCollection {
+        public FederationConfigurationElementCollection();
+        protected override bool ThrowOnDuplicate { get; }
+        protected override void BaseAdd(ConfigurationElement element);
+        protected override ConfigurationElement CreateNewElement();
+        public FederationConfigurationElement GetElement(string name);
+        protected override object GetElementKey(ConfigurationElement element);
+    }
+    public sealed class SystemIdentityModelServicesSection : ConfigurationSection {
+        public const string SectionName = "system.identityModel.services";
+        public SystemIdentityModelServicesSection();
+        public static SystemIdentityModelServicesSection Current { get; }
+        public static FederationConfigurationElement DefaultFederationConfigurationElement { get; }
+        public FederationConfigurationElementCollection FederationConfigurationElements { get; }
+    }
+    public class WsFederationConfiguration {
+        public const bool DefaultPassiveRedirectEnabled = true;
+        public const bool DefaultPersistentCookiesOnPassiveRedirects = false;
+        public const bool DefaultRequireHttps = true;
+        public const int DefaultMaxArrayLength = 2097152;
+        public const int DefaultMaxStringContentLength = 2097152;
+        public const string DefaultFreshness = null;
+        public WsFederationConfiguration(WSFederationElement federationElement);
+        public WsFederationConfiguration(string issuer, string realm);
+        public string AuthenticationType { get; set; }
+        public Dictionary<string, string> CustomAttributes { get; }
+        public string Freshness { get; set; }
+        public string HomeRealm { get; set; }
+        public string Issuer { get; set; }
+        public bool PassiveRedirectEnabled { get; set; }
+        public bool PersistentCookiesOnPassiveRedirects { get; set; }
+        public string Policy { get; set; }
+        public string Realm { get; set; }
+        public string Reply { get; set; }
+        public string Request { get; set; }
+        public string RequestPtr { get; set; }
+        public bool RequireHttps { get; set; }
+        public string Resource { get; set; }
+        public string SignInQueryString { get; set; }
+        public string SignOutQueryString { get; set; }
+        public string SignOutReply { get; set; }
+        public XmlDictionaryReaderQuotas XmlDictionaryReaderQuotas { get; set; }
+    }
+    public sealed class WSFederationElement : ConfigurationElement {
+        public WSFederationElement();
+        public string AuthenticationType { get; set; }
+        public Dictionary<string, string> CustomAttributes { get; }
+        public string Freshness { get; set; }
+        public string HomeRealm { get; set; }
+        public bool IsConfigured { get; }
+        public string Issuer { get; set; }
+        public bool PassiveRedirectEnabled { get; set; }
+        public bool PersistentCookiesOnPassiveRedirects { get; set; }
+        public string Policy { get; set; }
+        public string Realm { get; set; }
+        public string Reply { get; set; }
+        public string Request { get; set; }
+        public string RequestPtr { get; set; }
+        public bool RequireHttps { get; set; }
+        public string Resource { get; set; }
+        public string SignInQueryString { get; set; }
+        public string SignOutQueryString { get; set; }
+        public string SignOutReply { get; set; }
+        protected override bool OnDeserializeUnrecognizedAttribute(string name, string value);
+    }
+}
```

