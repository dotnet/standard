# System.ServiceModel.Security.Tokens

``` diff
+namespace System.ServiceModel.Security.Tokens {
+    public class BinarySecretSecurityToken : SecurityToken {
+        public BinarySecretSecurityToken(byte[] key);
+        public BinarySecretSecurityToken(int keySizeInBits);
+        public BinarySecretSecurityToken(string id, byte[] key);
+        protected BinarySecretSecurityToken(string id, byte[] key, bool allowCrypto);
+        public BinarySecretSecurityToken(string id, int keySizeInBits);
+        protected BinarySecretSecurityToken(string id, int keySizeInBits, bool allowCrypto);
+        public override string Id { get; }
+        public int KeySize { get; }
+        public override ReadOnlyCollection<SecurityKey> SecurityKeys { get; }
+        public override DateTime ValidFrom { get; }
+        public override DateTime ValidTo { get; }
+        public byte[] GetKeyBytes();
+    }
+    public class ClaimTypeRequirement {
+        public ClaimTypeRequirement(string claimType);
+        public ClaimTypeRequirement(string claimType, bool isOptional);
+        public string ClaimType { get; }
+        public bool IsOptional { get; }
+    }
+    public interface IIssuanceSecurityTokenAuthenticator {
+        IssuedSecurityTokenHandler IssuedSecurityTokenHandler { get; set; }
+        RenewedSecurityTokenHandler RenewedSecurityTokenHandler { get; set; }
+    }
+    public interface ILogonTokenCacheManager {
+        void FlushLogonTokenCache();
+        bool RemoveCachedLogonToken(string username);
+    }
+    public sealed class InitiatorServiceModelSecurityTokenRequirement : ServiceModelSecurityTokenRequirement {
+        public InitiatorServiceModelSecurityTokenRequirement();
+        public EndpointAddress TargetAddress { get; set; }
+        public Uri Via { get; set; }
+        public override string ToString();
+    }
+    public interface ISecurityContextSecurityTokenCache {
+        void AddContext(SecurityContextSecurityToken token);
+        void ClearContexts();
+        Collection<SecurityContextSecurityToken> GetAllContexts(UniqueId contextId);
+        SecurityContextSecurityToken GetContext(UniqueId contextId, UniqueId generation);
+        void RemoveAllContexts(UniqueId contextId);
+        void RemoveContext(UniqueId contextId, UniqueId generation);
+        bool TryAddContext(SecurityContextSecurityToken token);
+        void UpdateContextCachingTime(SecurityContextSecurityToken context, DateTime expirationTime);
+    }
+    public delegate void IssuedSecurityTokenHandler(SecurityToken issuedToken, EndpointAddress tokenRequestor);
+    public class IssuedSecurityTokenParameters : SecurityTokenParameters {
+        public IssuedSecurityTokenParameters();
+        protected IssuedSecurityTokenParameters(IssuedSecurityTokenParameters other);
+        public IssuedSecurityTokenParameters(string tokenType);
+        public IssuedSecurityTokenParameters(string tokenType, EndpointAddress issuerAddress);
+        public IssuedSecurityTokenParameters(string tokenType, EndpointAddress issuerAddress, Binding issuerBinding);
+        public Collection<XmlElement> AdditionalRequestParameters { get; }
+        public Collection<ClaimTypeRequirement> ClaimTypeRequirements { get; }
+        public MessageSecurityVersion DefaultMessageSecurityVersion { get; set; }
+        protected internal override bool HasAsymmetricKey { get; }
+        public EndpointAddress IssuerAddress { get; set; }
+        public Binding IssuerBinding { get; set; }
+        public EndpointAddress IssuerMetadataAddress { get; set; }
+        public int KeySize { get; set; }
+        public SecurityKeyType KeyType { get; set; }
+        protected internal override bool SupportsClientAuthentication { get; }
+        protected internal override bool SupportsClientWindowsIdentity { get; }
+        protected internal override bool SupportsServerAuthentication { get; }
+        public string TokenType { get; set; }
+        public bool UseStrTransform { get; set; }
+        protected override SecurityTokenParameters CloneCore();
+        protected internal override SecurityKeyIdentifierClause CreateKeyIdentifierClause(SecurityToken token, SecurityTokenReferenceStyle referenceStyle);
+        public Collection<XmlElement> CreateRequestParameters(MessageSecurityVersion messageSecurityVersion, SecurityTokenSerializer securityTokenSerializer);
+        protected internal override void InitializeSecurityTokenRequirement(SecurityTokenRequirement requirement);
+        public override string ToString();
+    }
+    public class IssuedSecurityTokenProvider : SecurityTokenProvider, ICommunicationObject {
+        public IssuedSecurityTokenProvider();
+        public bool CacheIssuedTokens { get; set; }
+        public virtual TimeSpan DefaultCloseTimeout { get; }
+        public virtual TimeSpan DefaultOpenTimeout { get; }
+        public IdentityVerifier IdentityVerifier { get; set; }
+        public int IssuedTokenRenewalThresholdPercentage { get; set; }
+        public EndpointAddress IssuerAddress { get; set; }
+        public Binding IssuerBinding { get; set; }
+        public KeyedByTypeCollection<IEndpointBehavior> IssuerChannelBehaviors { get; }
+        public SecurityKeyEntropyMode KeyEntropyMode { get; set; }
+        public TimeSpan MaxIssuedTokenCachingTime { get; set; }
+        public MessageSecurityVersion MessageSecurityVersion { get; set; }
+        public SecurityAlgorithmSuite SecurityAlgorithmSuite { get; set; }
+        public SecurityTokenSerializer SecurityTokenSerializer { get; set; }
+        public CommunicationState State { get; }
+        public override bool SupportsTokenCancellation { get; }
+        public EndpointAddress TargetAddress { get; set; }
+        public Collection<XmlElement> TokenRequestParameters { get; }
+        public event EventHandler Closed;
+        public event EventHandler Closing;
+        public event EventHandler Faulted;
+        public event EventHandler Opened;
+        public event EventHandler Opening;
+        public void Abort();
+        public IAsyncResult BeginClose(AsyncCallback callback, object state);
+        public IAsyncResult BeginClose(TimeSpan timeout, AsyncCallback callback, object state);
+        protected override IAsyncResult BeginGetTokenCore(TimeSpan timeout, AsyncCallback callback, object state);
+        public IAsyncResult BeginOpen(AsyncCallback callback, object state);
+        public IAsyncResult BeginOpen(TimeSpan timeout, AsyncCallback callback, object state);
+        public void Close();
+        public void Close(TimeSpan timeout);
+        public void Dispose();
+        public void EndClose(IAsyncResult result);
+        protected override SecurityToken EndGetTokenCore(IAsyncResult result);
+        public void EndOpen(IAsyncResult result);
+        protected override SecurityToken GetTokenCore(TimeSpan timeout);
+        public void Open();
+        public void Open(TimeSpan timeout);
+    }
+    public class KerberosSecurityTokenParameters : SecurityTokenParameters {
+        public KerberosSecurityTokenParameters();
+        protected KerberosSecurityTokenParameters(KerberosSecurityTokenParameters other);
+        protected internal override bool HasAsymmetricKey { get; }
+        protected internal override bool SupportsClientAuthentication { get; }
+        protected internal override bool SupportsClientWindowsIdentity { get; }
+        protected internal override bool SupportsServerAuthentication { get; }
+        protected override SecurityTokenParameters CloneCore();
+        protected internal override SecurityKeyIdentifierClause CreateKeyIdentifierClause(SecurityToken token, SecurityTokenReferenceStyle referenceStyle);
+        protected internal override void InitializeSecurityTokenRequirement(SecurityTokenRequirement requirement);
+    }
+    public sealed class RecipientServiceModelSecurityTokenRequirement : ServiceModelSecurityTokenRequirement {
+        public RecipientServiceModelSecurityTokenRequirement();
+        public AuditLogLocation AuditLogLocation { get; set; }
+        public Uri ListenUri { get; set; }
+        public AuditLevel MessageAuthenticationAuditLevel { get; set; }
+        public bool SuppressAuditFailure { get; set; }
+        public override string ToString();
+    }
+    public delegate void RenewedSecurityTokenHandler(SecurityToken newSecurityToken, SecurityToken oldSecurityToken);
+    public class RsaSecurityTokenParameters : SecurityTokenParameters {
+        public RsaSecurityTokenParameters();
+        protected RsaSecurityTokenParameters(RsaSecurityTokenParameters other);
+        protected internal override bool HasAsymmetricKey { get; }
+        protected internal override bool SupportsClientAuthentication { get; }
+        protected internal override bool SupportsClientWindowsIdentity { get; }
+        protected internal override bool SupportsServerAuthentication { get; }
+        protected override SecurityTokenParameters CloneCore();
+        protected internal override SecurityKeyIdentifierClause CreateKeyIdentifierClause(SecurityToken token, SecurityTokenReferenceStyle referenceStyle);
+        protected internal override void InitializeSecurityTokenRequirement(SecurityTokenRequirement requirement);
+    }
+    public class SecureConversationSecurityTokenParameters : SecurityTokenParameters {
+        public SecureConversationSecurityTokenParameters();
+        public SecureConversationSecurityTokenParameters(SecurityBindingElement bootstrapSecurityBindingElement);
+        public SecureConversationSecurityTokenParameters(SecurityBindingElement bootstrapSecurityBindingElement, bool requireCancellation);
+        public SecureConversationSecurityTokenParameters(SecurityBindingElement bootstrapSecurityBindingElement, bool requireCancellation, bool canRenewSession);
+        public SecureConversationSecurityTokenParameters(SecurityBindingElement bootstrapSecurityBindingElement, bool requireCancellation, bool canRenewSession, ChannelProtectionRequirements bootstrapProtectionRequirements);
+        public SecureConversationSecurityTokenParameters(SecurityBindingElement bootstrapSecurityBindingElement, bool requireCancellation, ChannelProtectionRequirements bootstrapProtectionRequirements);
+        protected SecureConversationSecurityTokenParameters(SecureConversationSecurityTokenParameters other);
+        public ChannelProtectionRequirements BootstrapProtectionRequirements { get; }
+        public SecurityBindingElement BootstrapSecurityBindingElement { get; set; }
+        public bool CanRenewSession { get; set; }
+        protected internal override bool HasAsymmetricKey { get; }
+        public bool RequireCancellation { get; set; }
+        protected internal override bool SupportsClientAuthentication { get; }
+        protected internal override bool SupportsClientWindowsIdentity { get; }
+        protected internal override bool SupportsServerAuthentication { get; }
+        protected override SecurityTokenParameters CloneCore();
+        protected internal override SecurityKeyIdentifierClause CreateKeyIdentifierClause(SecurityToken token, SecurityTokenReferenceStyle referenceStyle);
+        protected internal override void InitializeSecurityTokenRequirement(SecurityTokenRequirement requirement);
+        public override string ToString();
+    }
+    public class SecurityContextSecurityToken : SecurityToken, IDisposable, TimeBoundedCache.IExpirableItem {
+        public SecurityContextSecurityToken(UniqueId contextId, byte[] key, DateTime validFrom, DateTime validTo);
+        public SecurityContextSecurityToken(UniqueId contextId, string id, byte[] key, DateTime validFrom, DateTime validTo);
+        public SecurityContextSecurityToken(UniqueId contextId, string id, byte[] key, DateTime validFrom, DateTime validTo, ReadOnlyCollection<IAuthorizationPolicy> authorizationPolicies);
+        public SecurityContextSecurityToken(UniqueId contextId, string id, byte[] key, DateTime validFrom, DateTime validTo, UniqueId keyGeneration, DateTime keyEffectiveTime, DateTime keyExpirationTime, ReadOnlyCollection<IAuthorizationPolicy> authorizationPolicies);
+        public ReadOnlyCollection<IAuthorizationPolicy> AuthorizationPolicies { get; internal set; }
+        public SecurityMessageProperty BootstrapMessageProperty { get; set; }
+        public UniqueId ContextId { get; }
+        public override string Id { get; }
+        public bool IsCookieMode { get; }
+        public DateTime KeyEffectiveTime { get; }
+        public DateTime KeyExpirationTime { get; }
+        public UniqueId KeyGeneration { get; }
+        public override ReadOnlyCollection<SecurityKey> SecurityKeys { get; }
+        public override DateTime ValidFrom { get; }
+        public override DateTime ValidTo { get; }
+        public override bool CanCreateKeyIdentifierClause<T>();
+        public static SecurityContextSecurityToken CreateCookieSecurityContextToken(UniqueId contextId, string id, byte[] key, DateTime validFrom, DateTime validTo, ReadOnlyCollection<IAuthorizationPolicy> authorizationPolicies, SecurityStateEncoder securityStateEncoder);
+        public static SecurityContextSecurityToken CreateCookieSecurityContextToken(UniqueId contextId, string id, byte[] key, DateTime validFrom, DateTime validTo, UniqueId keyGeneration, DateTime keyEffectiveTime, DateTime keyExpirationTime, ReadOnlyCollection<IAuthorizationPolicy> authorizationPolicies, SecurityStateEncoder securityStateEncoder);
+        public override T CreateKeyIdentifierClause<T>();
+        public void Dispose();
+        public override bool MatchesKeyIdentifierClause(SecurityKeyIdentifierClause keyIdentifierClause);
+        public override string ToString();
+    }
+    public class SecurityContextSecurityTokenAuthenticator : SecurityTokenAuthenticator {
+        public SecurityContextSecurityTokenAuthenticator();
+        protected override bool CanValidateTokenCore(SecurityToken token);
+        protected override ReadOnlyCollection<IAuthorizationPolicy> ValidateTokenCore(SecurityToken token);
+    }
+    public class SecurityContextSecurityTokenResolver : SecurityTokenResolver, ISecurityContextSecurityTokenCache {
+        public SecurityContextSecurityTokenResolver(int securityContextCacheCapacity, bool removeOldestTokensOnCacheFull);
+        public SecurityContextSecurityTokenResolver(int securityContextCacheCapacity, bool removeOldestTokensOnCacheFull, TimeSpan clockSkew);
+        public TimeSpan ClockSkew { get; }
+        public bool RemoveOldestTokensOnCacheFull { get; }
+        public int SecurityContextTokenCacheCapacity { get; }
+        public void AddContext(SecurityContextSecurityToken token);
+        public void ClearContexts();
+        public Collection<SecurityContextSecurityToken> GetAllContexts(UniqueId contextId);
+        public SecurityContextSecurityToken GetContext(UniqueId contextId, UniqueId generation);
+        public void RemoveAllContexts(UniqueId contextId);
+        public void RemoveContext(UniqueId contextId, UniqueId generation);
+        public bool TryAddContext(SecurityContextSecurityToken token);
+        protected override bool TryResolveSecurityKeyCore(SecurityKeyIdentifierClause keyIdentifierClause, out SecurityKey key);
+        protected override bool TryResolveTokenCore(SecurityKeyIdentifier keyIdentifier, out SecurityToken token);
+        protected override bool TryResolveTokenCore(SecurityKeyIdentifierClause keyIdentifierClause, out SecurityToken token);
+        public void UpdateContextCachingTime(SecurityContextSecurityToken context, DateTime expirationTime);
+    }
+    public enum SecurityTokenInclusionMode {
+        AlwaysToInitiator = 3,
+        AlwaysToRecipient = 0,
+        Never = 1,
+        Once = 2,
+    }
+    public abstract class SecurityTokenParameters {
+        protected SecurityTokenParameters();
+        protected SecurityTokenParameters(SecurityTokenParameters other);
+        protected internal abstract bool HasAsymmetricKey { get; }
+        public SecurityTokenInclusionMode InclusionMode { get; set; }
+        public SecurityTokenReferenceStyle ReferenceStyle { get; set; }
+        public bool RequireDerivedKeys { get; set; }
+        protected internal abstract bool SupportsClientAuthentication { get; }
+        protected internal abstract bool SupportsClientWindowsIdentity { get; }
+        protected internal abstract bool SupportsServerAuthentication { get; }
+        public SecurityTokenParameters Clone();
+        protected abstract SecurityTokenParameters CloneCore();
+        protected internal abstract SecurityKeyIdentifierClause CreateKeyIdentifierClause(SecurityToken token, SecurityTokenReferenceStyle referenceStyle);
+        protected internal abstract void InitializeSecurityTokenRequirement(SecurityTokenRequirement requirement);
+        protected internal virtual bool MatchesKeyIdentifierClause(SecurityToken token, SecurityKeyIdentifierClause keyIdentifierClause, SecurityTokenReferenceStyle referenceStyle);
+        public override string ToString();
+    }
+    public enum SecurityTokenReferenceStyle {
+        External = 1,
+        Internal = 0,
+    }
+    public abstract class ServiceModelSecurityTokenRequirement : SecurityTokenRequirement {
+        protected const string Namespace = "http://schemas.microsoft.com/ws/2006/05/servicemodel/securitytokenrequirement";
+        protected ServiceModelSecurityTokenRequirement();
+        public static string AuditLogLocationProperty { get; }
+        public static string ChannelParametersCollectionProperty { get; }
+        public static string DuplexClientLocalAddressProperty { get; }
+        public static string EndpointFilterTableProperty { get; }
+        public static string ExtendedProtectionPolicy { get; }
+        public static string HttpAuthenticationSchemeProperty { get; }
+        public bool IsInitiator { get; }
+        public static string IsInitiatorProperty { get; }
+        public static string IsOutOfBandTokenProperty { get; }
+        public static string IssuedSecurityTokenParametersProperty { get; }
+        public EndpointAddress IssuerAddress { get; set; }
+        public static string IssuerAddressProperty { get; }
+        public Binding IssuerBinding { get; set; }
+        public static string IssuerBindingContextProperty { get; }
+        public static string IssuerBindingProperty { get; }
+        public static string ListenUriProperty { get; }
+        public static string MessageAuthenticationAuditLevelProperty { get; }
+        public static string MessageDirectionProperty { get; }
+        public SecurityTokenVersion MessageSecurityVersion { get; set; }
+        public static string MessageSecurityVersionProperty { get; }
+        public static string PreferSslCertificateAuthenticatorProperty { get; }
+        public static string PrivacyNoticeUriProperty { get; }
+        public static string PrivacyNoticeVersionProperty { get; }
+        public SecurityBindingElement SecureConversationSecurityBindingElement { get; set; }
+        public static string SecureConversationSecurityBindingElementProperty { get; }
+        public SecurityAlgorithmSuite SecurityAlgorithmSuite { get; set; }
+        public static string SecurityAlgorithmSuiteProperty { get; }
+        public SecurityBindingElement SecurityBindingElement { get; set; }
+        public static string SecurityBindingElementProperty { get; }
+        public static string SupportingTokenAttachmentModeProperty { get; }
+        public static string SupportSecurityContextCancellationProperty { get; }
+        public static string SuppressAuditFailureProperty { get; }
+        public static string TargetAddressProperty { get; }
+        public string TransportScheme { get; set; }
+        public static string TransportSchemeProperty { get; }
+        public static string ViaProperty { get; }
+    }
+    public static class ServiceModelSecurityTokenTypes {
+        public static string AnonymousSslnego { get; }
+        public static string MutualSslnego { get; }
+        public static string SecureConversation { get; }
+        public static string SecurityContext { get; }
+        public static string Spnego { get; }
+        public static string SspiCredential { get; }
+    }
+    public class SslSecurityTokenParameters : SecurityTokenParameters {
+        public SslSecurityTokenParameters();
+        public SslSecurityTokenParameters(bool requireClientCertificate);
+        public SslSecurityTokenParameters(bool requireClientCertificate, bool requireCancellation);
+        protected SslSecurityTokenParameters(SslSecurityTokenParameters other);
+        protected internal override bool HasAsymmetricKey { get; }
+        public bool RequireCancellation { get; set; }
+        public bool RequireClientCertificate { get; set; }
+        protected internal override bool SupportsClientAuthentication { get; }
+        protected internal override bool SupportsClientWindowsIdentity { get; }
+        protected internal override bool SupportsServerAuthentication { get; }
+        protected override SecurityTokenParameters CloneCore();
+        protected internal override SecurityKeyIdentifierClause CreateKeyIdentifierClause(SecurityToken token, SecurityTokenReferenceStyle referenceStyle);
+        protected internal override void InitializeSecurityTokenRequirement(SecurityTokenRequirement requirement);
+        public override string ToString();
+    }
+    public class SspiSecurityToken : SecurityToken {
+        public SspiSecurityToken(NetworkCredential networkCredential, bool extractGroupsForWindowsAccounts, bool allowUnauthenticatedCallers);
+        public SspiSecurityToken(TokenImpersonationLevel impersonationLevel, bool allowNtlm, NetworkCredential networkCredential);
+        public bool AllowNtlm { get; }
+        public bool AllowUnauthenticatedCallers { get; }
+        public bool ExtractGroupsForWindowsAccounts { get; }
+        public override string Id { get; }
+        public TokenImpersonationLevel ImpersonationLevel { get; }
+        public NetworkCredential NetworkCredential { get; }
+        public override ReadOnlyCollection<SecurityKey> SecurityKeys { get; }
+        public override DateTime ValidFrom { get; }
+        public override DateTime ValidTo { get; }
+    }
+    public class SspiSecurityTokenParameters : SecurityTokenParameters {
+        public SspiSecurityTokenParameters();
+        public SspiSecurityTokenParameters(bool requireCancellation);
+        protected SspiSecurityTokenParameters(SspiSecurityTokenParameters other);
+        protected internal override bool HasAsymmetricKey { get; }
+        public bool RequireCancellation { get; set; }
+        protected internal override bool SupportsClientAuthentication { get; }
+        protected internal override bool SupportsClientWindowsIdentity { get; }
+        protected internal override bool SupportsServerAuthentication { get; }
+        protected override SecurityTokenParameters CloneCore();
+        protected internal override SecurityKeyIdentifierClause CreateKeyIdentifierClause(SecurityToken token, SecurityTokenReferenceStyle referenceStyle);
+        protected internal override void InitializeSecurityTokenRequirement(SecurityTokenRequirement requirement);
+        public override string ToString();
+    }
+    public class SupportingTokenParameters {
+        public SupportingTokenParameters();
+        public Collection<SecurityTokenParameters> Endorsing { get; }
+        public Collection<SecurityTokenParameters> Signed { get; }
+        public Collection<SecurityTokenParameters> SignedEncrypted { get; }
+        public Collection<SecurityTokenParameters> SignedEndorsing { get; }
+        public SupportingTokenParameters Clone();
+        protected virtual SupportingTokenParameters CloneCore();
+        public void SetKeyDerivation(bool requireDerivedKeys);
+        public override string ToString();
+    }
+    public class UserNameSecurityTokenParameters : SecurityTokenParameters {
+        public UserNameSecurityTokenParameters();
+        protected UserNameSecurityTokenParameters(UserNameSecurityTokenParameters other);
+        protected internal override bool HasAsymmetricKey { get; }
+        protected internal override bool SupportsClientAuthentication { get; }
+        protected internal override bool SupportsClientWindowsIdentity { get; }
+        protected internal override bool SupportsServerAuthentication { get; }
+        protected override SecurityTokenParameters CloneCore();
+        protected internal override SecurityKeyIdentifierClause CreateKeyIdentifierClause(SecurityToken token, SecurityTokenReferenceStyle referenceStyle);
+        protected internal override void InitializeSecurityTokenRequirement(SecurityTokenRequirement requirement);
+    }
+    public class WrappedKeySecurityToken : SecurityToken {
+        public WrappedKeySecurityToken(string id, byte[] keyToWrap, string wrappingAlgorithm, SecurityToken wrappingToken, SecurityKeyIdentifier wrappingTokenReference);
+        public override string Id { get; }
+        public override ReadOnlyCollection<SecurityKey> SecurityKeys { get; }
+        public override DateTime ValidFrom { get; }
+        public override DateTime ValidTo { get; }
+        public string WrappingAlgorithm { get; }
+        public SecurityToken WrappingToken { get; }
+        public SecurityKeyIdentifier WrappingTokenReference { get; }
+        public override bool CanCreateKeyIdentifierClause<T>();
+        public override T CreateKeyIdentifierClause<T>();
+        public byte[] GetWrappedKey();
+        public override bool MatchesKeyIdentifierClause(SecurityKeyIdentifierClause keyIdentifierClause);
+    }
+    public enum X509KeyIdentifierClauseType {
+        Any = 0,
+        IssuerSerial = 2,
+        RawDataKeyIdentifier = 4,
+        SubjectKeyIdentifier = 3,
+        Thumbprint = 1,
+    }
+    public class X509SecurityTokenParameters : SecurityTokenParameters {
+        public X509SecurityTokenParameters();
+        public X509SecurityTokenParameters(X509KeyIdentifierClauseType x509ReferenceStyle);
+        public X509SecurityTokenParameters(X509KeyIdentifierClauseType x509ReferenceStyle, SecurityTokenInclusionMode inclusionMode);
+        protected X509SecurityTokenParameters(X509SecurityTokenParameters other);
+        protected internal override bool HasAsymmetricKey { get; }
+        protected internal override bool SupportsClientAuthentication { get; }
+        protected internal override bool SupportsClientWindowsIdentity { get; }
+        protected internal override bool SupportsServerAuthentication { get; }
+        public X509KeyIdentifierClauseType X509ReferenceStyle { get; set; }
+        protected override SecurityTokenParameters CloneCore();
+        protected internal override SecurityKeyIdentifierClause CreateKeyIdentifierClause(SecurityToken token, SecurityTokenReferenceStyle referenceStyle);
+        protected internal override void InitializeSecurityTokenRequirement(SecurityTokenRequirement requirement);
+        public override string ToString();
+    }
+}
```

