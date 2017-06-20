# System.IdentityModel.Configuration

``` diff
+namespace System.IdentityModel.Configuration {
+    public sealed class AudienceUriElement : ConfigurationElement {
+        public AudienceUriElement();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string Value { get; set; }
+    }
+    public sealed class AudienceUriElementCollection : ConfigurationElementCollection {
+        public AudienceUriElementCollection();
+        public AudienceUriMode Mode { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        protected override void Init();
+    }
+    public class ConfigurationElementInterceptor : ConfigurationElement {
+        public ConfigurationElementInterceptor();
+        public XmlNodeList ChildNodes { get; }
+        public XmlElement ElementAsXml { get; }
+        protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey);
+        protected override bool OnDeserializeUnrecognizedAttribute(string name, string value);
+        protected override bool OnDeserializeUnrecognizedElement(string elementName, XmlReader reader);
+        protected override void Reset(ConfigurationElement parentElement);
+    }
+    public sealed class CustomTypeElement : ConfigurationElementInterceptor {
+        public CustomTypeElement();
+        public bool IsConfigured { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public Type Type { get; set; }
+        public static T Resolve<T>(CustomTypeElement customTypeElement) where T : class;
+    }
+    public interface ICustomIdentityConfiguration {
+        void LoadCustomConfiguration(XmlNodeList nodeList);
+    }
+    public class IdentityConfiguration {
+        public static readonly StoreLocation DefaultTrustedStoreLocation;
+        public static readonly X509RevocationMode DefaultRevocationMode;
+        public static readonly X509CertificateValidationMode DefaultCertificateValidationMode;
+        public const string DefaultServiceName = "";
+        public static readonly TimeSpan DefaultMaxClockSkew;
+        public static readonly Type DefaultIssuerNameRegistryType;
+        public IdentityConfiguration();
+        public IdentityConfiguration(bool loadConfig);
+        public IdentityConfiguration(bool loadConfig, X509Certificate2 serviceCertificate);
+        public IdentityConfiguration(X509Certificate2 serviceCertificate);
+        public IdentityConfiguration(string identityConfigurationName);
+        public IdentityConfiguration(string identityConfigurationName, X509Certificate2 serviceCertificate);
+        public AudienceRestriction AudienceRestriction { get; set; }
+        public IdentityModelCaches Caches { get; set; }
+        public X509CertificateValidationMode CertificateValidationMode { get; set; }
+        public X509CertificateValidator CertificateValidator { get; set; }
+        public ClaimsAuthenticationManager ClaimsAuthenticationManager { get; set; }
+        public ClaimsAuthorizationManager ClaimsAuthorizationManager { get; set; }
+        public bool DetectReplayedTokens { get; set; }
+        public virtual bool IsInitialized { get; protected set; }
+        public IssuerNameRegistry IssuerNameRegistry { get; set; }
+        public SecurityTokenResolver IssuerTokenResolver { get; set; }
+        public TimeSpan MaxClockSkew { get; set; }
+        public string Name { get; }
+        public X509RevocationMode RevocationMode { get; set; }
+        public bool SaveBootstrapContext { get; set; }
+        public SecurityTokenHandlerCollectionManager SecurityTokenHandlerCollectionManager { get; }
+        public SecurityTokenHandlerCollection SecurityTokenHandlers { get; }
+        public X509Certificate2 ServiceCertificate { get; set; }
+        public SecurityTokenResolver ServiceTokenResolver { get; set; }
+        public TimeSpan TokenReplayCacheExpirationPeriod { get; set; }
+        public StoreLocation TrustedStoreLocation { get; set; }
+        public virtual void Initialize();
+        protected void LoadConfiguration(IdentityConfigurationElement element);
+        protected SecurityTokenHandlerConfiguration LoadHandlerConfiguration(IdentityConfigurationElement element);
+        protected SecurityTokenHandlerConfiguration LoadHandlerConfiguration(SecurityTokenHandlerConfiguration baseConfiguration, SecurityTokenHandlerConfigurationElement element);
+        protected SecurityTokenHandlerCollectionManager LoadHandlers(IdentityConfigurationElement serviceElement);
+    }
+    public sealed class IdentityConfigurationElement : ConfigurationElement {
+        public IdentityConfigurationElement();
+        public AudienceUriElementCollection AudienceUris { get; }
+        public IdentityModelCachesElement Caches { get; set; }
+        public X509CertificateValidationElement CertificateValidation { get; set; }
+        public CustomTypeElement ClaimsAuthenticationManager { get; set; }
+        public CustomTypeElement ClaimsAuthorizationManager { get; set; }
+        public IssuerNameRegistryElement IssuerNameRegistry { get; set; }
+        public CustomTypeElement IssuerTokenResolver { get; set; }
+        public TimeSpan MaximumClockSkew { get; set; }
+        public string Name { get; set; }
+        public bool SaveBootstrapContext { get; set; }
+        public SecurityTokenHandlerSetElementCollection SecurityTokenHandlerSets { get; }
+        public CustomTypeElement ServiceTokenResolver { get; set; }
+        public TokenReplayDetectionElement TokenReplayDetection { get; set; }
+    }
+    public sealed class IdentityConfigurationElementCollection : ConfigurationElementCollection {
+        public IdentityConfigurationElementCollection();
+        protected override bool ThrowOnDuplicate { get; }
+        protected override void BaseAdd(ConfigurationElement element);
+        protected override ConfigurationElement CreateNewElement();
+        public IdentityConfigurationElement GetElement(string name);
+        protected override object GetElementKey(ConfigurationElement element);
+    }
+    public sealed class IdentityModelCaches {
+        public IdentityModelCaches();
+        public SessionSecurityTokenCache SessionSecurityTokenCache { get; set; }
+        public TokenReplayCache TokenReplayCache { get; set; }
+    }
+    public sealed class IdentityModelCachesElement : ConfigurationElement {
+        public IdentityModelCachesElement();
+        public bool IsConfigured { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public CustomTypeElement SessionSecurityTokenCache { get; set; }
+        public CustomTypeElement TokenReplayCache { get; set; }
+    }
+    public sealed class IssuerNameRegistryElement : ConfigurationElementInterceptor {
+        public IssuerNameRegistryElement();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string Type { get; set; }
+    }
+    public sealed class SecurityTokenHandlerConfigurationElement : ConfigurationElement {
+        public SecurityTokenHandlerConfigurationElement();
+        public AudienceUriElementCollection AudienceUris { get; }
+        public IdentityModelCachesElement Caches { get; set; }
+        public X509CertificateValidationElement CertificateValidation { get; set; }
+        public IssuerNameRegistryElement IssuerNameRegistry { get; set; }
+        public CustomTypeElement IssuerTokenResolver { get; set; }
+        public TimeSpan MaximumClockSkew { get; set; }
+        public string Name { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public bool SaveBootstrapContext { get; set; }
+        public CustomTypeElement ServiceTokenResolver { get; set; }
+        public TokenReplayDetectionElement TokenReplayDetection { get; set; }
+        protected override void Init();
+    }
+    public sealed class SecurityTokenHandlerElementCollection : ConfigurationElementCollection {
+        public SecurityTokenHandlerElementCollection();
+        public string Name { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public SecurityTokenHandlerConfigurationElement SecurityTokenHandlerConfiguration { get; set; }
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        protected override void Init();
+    }
+    public sealed class SecurityTokenHandlerSetElementCollection : ConfigurationElementCollection {
+        public SecurityTokenHandlerSetElementCollection();
+        public bool IsConfigured { get; }
+        protected override bool ThrowOnDuplicate { get; }
+        protected override void BaseAdd(ConfigurationElement element);
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+    }
+    public class SecurityTokenServiceConfiguration : IdentityConfiguration {
+        public SecurityTokenServiceConfiguration();
+        public SecurityTokenServiceConfiguration(bool loadConfig);
+        public SecurityTokenServiceConfiguration(string issuerName);
+        public SecurityTokenServiceConfiguration(string issuerName, bool loadConfig);
+        public SecurityTokenServiceConfiguration(string issuerName, SigningCredentials signingCredentials);
+        public SecurityTokenServiceConfiguration(string issuerName, SigningCredentials signingCredentials, bool loadConfig);
+        public SecurityTokenServiceConfiguration(string issuerName, SigningCredentials signingCredentials, string serviceName);
+        public int DefaultMaxSymmetricKeySizeInBits { get; set; }
+        public int DefaultSymmetricKeySizeInBits { get; set; }
+        public TimeSpan DefaultTokenLifetime { get; set; }
+        public string DefaultTokenType { get; set; }
+        public bool DisableWsdl { get; set; }
+        public TimeSpan MaximumTokenLifetime { get; set; }
+        public Type SecurityTokenService { get; set; }
+        public SigningCredentials SigningCredentials { get; set; }
+        public string TokenIssuerName { get; set; }
+        public WSTrust13RequestSerializer WSTrust13RequestSerializer { get; set; }
+        public WSTrust13ResponseSerializer WSTrust13ResponseSerializer { get; set; }
+        public WSTrustFeb2005RequestSerializer WSTrustFeb2005RequestSerializer { get; set; }
+        public WSTrustFeb2005ResponseSerializer WSTrustFeb2005ResponseSerializer { get; set; }
+        public virtual SecurityTokenService CreateSecurityTokenService();
+    }
+    public sealed class SystemIdentityModelSection : ConfigurationSection {
+        public const string SectionName = "system.identityModel";
+        public SystemIdentityModelSection();
+        public static SystemIdentityModelSection Current { get; }
+        public static IdentityConfigurationElement DefaultIdentityConfigurationElement { get; }
+        public IdentityConfigurationElementCollection IdentityConfigurationElements { get; }
+    }
+    public sealed class TokenReplayDetectionElement : ConfigurationElement {
+        public TokenReplayDetectionElement();
+        public bool Enabled { get; set; }
+        public TimeSpan ExpirationPeriod { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class X509CertificateValidationElement : ConfigurationElement {
+        public X509CertificateValidationElement();
+        public X509CertificateValidationMode CertificateValidationMode { get; set; }
+        public CustomTypeElement CertificateValidator { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public X509RevocationMode RevocationMode { get; set; }
+        public StoreLocation TrustedStoreLocation { get; set; }
+    }
+}
```

