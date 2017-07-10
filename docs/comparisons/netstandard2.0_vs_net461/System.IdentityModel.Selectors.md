# System.IdentityModel.Selectors

``` diff
+namespace System.IdentityModel.Selectors {
+    public enum AudienceUriMode {
+        Always = 1,
+        BearerKeyOnly = 2,
+        Never = 0,
+    }
+    public static class AudienceUriModeValidationHelper {
+        public static bool IsDefined(AudienceUriMode validationMode);
+    }
+    public class CardSpaceException : Exception {
+        public CardSpaceException();
+        protected CardSpaceException(SerializationInfo info, StreamingContext context);
+        public CardSpaceException(string message);
+        public CardSpaceException(string message, Exception innerException);
+    }
+    public class CardSpacePolicyElement {
+        public CardSpacePolicyElement(XmlElement target, XmlElement issuer, Collection<XmlElement> parameters, Uri privacyNoticeLink, int privacyNoticeVersion, bool isManagedIssuer);
+        public bool IsManagedIssuer { get; set; }
+        public XmlElement Issuer { get; set; }
+        public Collection<XmlElement> Parameters { get; }
+        public Uri PolicyNoticeLink { get; set; }
+        public int PolicyNoticeVersion { get; set; }
+        public XmlElement Target { get; set; }
+    }
+    public static class CardSpaceSelector {
+        public static GenericXmlSecurityToken GetToken(CardSpacePolicyElement[] policyChain, SecurityTokenSerializer tokenSerializer);
+        public static GenericXmlSecurityToken GetToken(XmlElement endpoint, IEnumerable<XmlElement> policy, XmlElement requiredRemoteTokenIssuer, SecurityTokenSerializer tokenSerializer);
+        public static void Import(string fileName);
+        public static void Manage();
+    }
+    public class CustomUserNameSecurityTokenAuthenticator : UserNameSecurityTokenAuthenticator {
+        public CustomUserNameSecurityTokenAuthenticator(UserNamePasswordValidator validator);
+        protected override ReadOnlyCollection<IAuthorizationPolicy> ValidateUserNamePasswordCore(string userName, string password);
+    }
+    public class IdentityValidationException : Exception {
+        public IdentityValidationException();
+        protected IdentityValidationException(SerializationInfo info, StreamingContext context);
+        public IdentityValidationException(string message);
+        public IdentityValidationException(string message, Exception innerException);
+    }
+    public class KerberosSecurityTokenAuthenticator : WindowsSecurityTokenAuthenticator {
+        public KerberosSecurityTokenAuthenticator();
+        public KerberosSecurityTokenAuthenticator(bool includeWindowsGroups);
+        protected override bool CanValidateTokenCore(SecurityToken token);
+    }
+    public class KerberosSecurityTokenProvider : SecurityTokenProvider {
+        public KerberosSecurityTokenProvider(string servicePrincipalName);
+        public KerberosSecurityTokenProvider(string servicePrincipalName, TokenImpersonationLevel tokenImpersonationLevel);
+        public KerberosSecurityTokenProvider(string servicePrincipalName, TokenImpersonationLevel tokenImpersonationLevel, NetworkCredential networkCredential);
+        public NetworkCredential NetworkCredential { get; }
+        public string ServicePrincipalName { get; }
+        public TokenImpersonationLevel TokenImpersonationLevel { get; }
+        protected override SecurityToken GetTokenCore(TimeSpan timeout);
+    }
+    public class PolicyValidationException : Exception {
+        public PolicyValidationException();
+        protected PolicyValidationException(SerializationInfo info, StreamingContext context);
+        public PolicyValidationException(string message);
+        public PolicyValidationException(string message, Exception innerException);
+    }
+    public class RsaSecurityTokenAuthenticator : SecurityTokenAuthenticator {
+        public RsaSecurityTokenAuthenticator();
+        protected override bool CanValidateTokenCore(SecurityToken token);
+        protected override ReadOnlyCollection<IAuthorizationPolicy> ValidateTokenCore(SecurityToken token);
+    }
+    public class SamlSecurityTokenAuthenticator : SecurityTokenAuthenticator {
+        public SamlSecurityTokenAuthenticator(IList<SecurityTokenAuthenticator> supportingAuthenticators);
+        public SamlSecurityTokenAuthenticator(IList<SecurityTokenAuthenticator> supportingAuthenticators, TimeSpan maxClockSkew);
+        public IList<string> AllowedAudienceUris { get; }
+        public AudienceUriMode AudienceUriMode { get; set; }
+        protected override bool CanValidateTokenCore(SecurityToken token);
+        public virtual ClaimSet ResolveClaimSet(SecurityKeyIdentifier keyIdentifier);
+        public virtual ClaimSet ResolveClaimSet(SecurityToken token);
+        public virtual IIdentity ResolveIdentity(SecurityKeyIdentifier keyIdentifier);
+        public virtual IIdentity ResolveIdentity(SecurityToken token);
+        protected virtual bool ValidateAudienceRestriction(SamlAudienceRestrictionCondition audienceRestrictionCondition);
+        protected override ReadOnlyCollection<IAuthorizationPolicy> ValidateTokenCore(SecurityToken token);
+    }
+    public abstract class SecurityTokenAuthenticator {
+        protected SecurityTokenAuthenticator();
+        public bool CanValidateToken(SecurityToken token);
+        protected abstract bool CanValidateTokenCore(SecurityToken token);
+        public ReadOnlyCollection<IAuthorizationPolicy> ValidateToken(SecurityToken token);
+        protected abstract ReadOnlyCollection<IAuthorizationPolicy> ValidateTokenCore(SecurityToken token);
+    }
+    public abstract class SecurityTokenManager {
+        protected SecurityTokenManager();
+        public abstract SecurityTokenAuthenticator CreateSecurityTokenAuthenticator(SecurityTokenRequirement tokenRequirement, out SecurityTokenResolver outOfBandTokenResolver);
+        public abstract SecurityTokenProvider CreateSecurityTokenProvider(SecurityTokenRequirement tokenRequirement);
+        public abstract SecurityTokenSerializer CreateSecurityTokenSerializer(SecurityTokenVersion version);
+    }
+    public abstract class SecurityTokenProvider {
+        protected SecurityTokenProvider();
+        public virtual bool SupportsTokenCancellation { get; }
+        public virtual bool SupportsTokenRenewal { get; }
+        public IAsyncResult BeginCancelToken(TimeSpan timeout, SecurityToken token, AsyncCallback callback, object state);
+        protected virtual IAsyncResult BeginCancelTokenCore(TimeSpan timeout, SecurityToken token, AsyncCallback callback, object state);
+        public IAsyncResult BeginGetToken(TimeSpan timeout, AsyncCallback callback, object state);
+        protected virtual IAsyncResult BeginGetTokenCore(TimeSpan timeout, AsyncCallback callback, object state);
+        public IAsyncResult BeginRenewToken(TimeSpan timeout, SecurityToken tokenToBeRenewed, AsyncCallback callback, object state);
+        protected virtual IAsyncResult BeginRenewTokenCore(TimeSpan timeout, SecurityToken tokenToBeRenewed, AsyncCallback callback, object state);
+        public void CancelToken(TimeSpan timeout, SecurityToken token);
+        protected virtual void CancelTokenCore(TimeSpan timeout, SecurityToken token);
+        public void EndCancelToken(IAsyncResult result);
+        protected virtual void EndCancelTokenCore(IAsyncResult result);
+        public SecurityToken EndGetToken(IAsyncResult result);
+        protected virtual SecurityToken EndGetTokenCore(IAsyncResult result);
+        public SecurityToken EndRenewToken(IAsyncResult result);
+        protected virtual SecurityToken EndRenewTokenCore(IAsyncResult result);
+        public SecurityToken GetToken(TimeSpan timeout);
+        protected abstract SecurityToken GetTokenCore(TimeSpan timeout);
+        public SecurityToken RenewToken(TimeSpan timeout, SecurityToken tokenToBeRenewed);
+        protected virtual SecurityToken RenewTokenCore(TimeSpan timeout, SecurityToken tokenToBeRenewed);
+        protected internal class SecurityTokenAsyncResult : IAsyncResult {
+            public SecurityTokenAsyncResult(SecurityToken token, AsyncCallback callback, object state);
+            public object AsyncState { get; }
+            public WaitHandle AsyncWaitHandle { get; }
+            public bool CompletedSynchronously { get; }
+            public bool IsCompleted { get; }
+            public static SecurityToken End(IAsyncResult result);
+        }
+    }
+    public class SecurityTokenRequirement {
+        public SecurityTokenRequirement();
+        public static string IsOptionalTokenProperty { get; }
+        public int KeySize { get; set; }
+        public static string KeySizeProperty { get; }
+        public SecurityKeyType KeyType { get; set; }
+        public static string KeyTypeProperty { get; }
+        public SecurityKeyUsage KeyUsage { get; set; }
+        public static string KeyUsageProperty { get; }
+        public static string PeerAuthenticationMode { get; }
+        public IDictionary<string, object> Properties { get; }
+        public bool RequireCryptographicToken { get; set; }
+        public static string RequireCryptographicTokenProperty { get; }
+        public string TokenType { get; set; }
+        public static string TokenTypeProperty { get; }
+        public TValue GetProperty<TValue>(string propertyName);
+        public bool TryGetProperty<TValue>(string propertyName, out TValue result);
+    }
+    public abstract class SecurityTokenResolver : ICustomIdentityConfiguration {
+        protected SecurityTokenResolver();
+        public static SecurityTokenResolver CreateDefaultSecurityTokenResolver(ReadOnlyCollection<SecurityToken> tokens, bool canMatchLocalId);
+        public virtual void LoadCustomConfiguration(XmlNodeList nodelist);
+        public SecurityKey ResolveSecurityKey(SecurityKeyIdentifierClause keyIdentifierClause);
+        public SecurityToken ResolveToken(SecurityKeyIdentifier keyIdentifier);
+        public SecurityToken ResolveToken(SecurityKeyIdentifierClause keyIdentifierClause);
+        public bool TryResolveSecurityKey(SecurityKeyIdentifierClause keyIdentifierClause, out SecurityKey key);
+        protected abstract bool TryResolveSecurityKeyCore(SecurityKeyIdentifierClause keyIdentifierClause, out SecurityKey key);
+        public bool TryResolveToken(SecurityKeyIdentifier keyIdentifier, out SecurityToken token);
+        public bool TryResolveToken(SecurityKeyIdentifierClause keyIdentifierClause, out SecurityToken token);
+        protected abstract bool TryResolveTokenCore(SecurityKeyIdentifier keyIdentifier, out SecurityToken token);
+        protected abstract bool TryResolveTokenCore(SecurityKeyIdentifierClause keyIdentifierClause, out SecurityToken token);
+    }
+    public abstract class SecurityTokenSerializer {
+        protected SecurityTokenSerializer();
+        public bool CanReadKeyIdentifier(XmlReader reader);
+        public bool CanReadKeyIdentifierClause(XmlReader reader);
+        protected abstract bool CanReadKeyIdentifierClauseCore(XmlReader reader);
+        protected abstract bool CanReadKeyIdentifierCore(XmlReader reader);
+        public bool CanReadToken(XmlReader reader);
+        protected abstract bool CanReadTokenCore(XmlReader reader);
+        public bool CanWriteKeyIdentifier(SecurityKeyIdentifier keyIdentifier);
+        public bool CanWriteKeyIdentifierClause(SecurityKeyIdentifierClause keyIdentifierClause);
+        protected abstract bool CanWriteKeyIdentifierClauseCore(SecurityKeyIdentifierClause keyIdentifierClause);
+        protected abstract bool CanWriteKeyIdentifierCore(SecurityKeyIdentifier keyIdentifier);
+        public bool CanWriteToken(SecurityToken token);
+        protected abstract bool CanWriteTokenCore(SecurityToken token);
+        public SecurityKeyIdentifier ReadKeyIdentifier(XmlReader reader);
+        public SecurityKeyIdentifierClause ReadKeyIdentifierClause(XmlReader reader);
+        protected abstract SecurityKeyIdentifierClause ReadKeyIdentifierClauseCore(XmlReader reader);
+        protected abstract SecurityKeyIdentifier ReadKeyIdentifierCore(XmlReader reader);
+        public SecurityToken ReadToken(XmlReader reader, SecurityTokenResolver tokenResolver);
+        protected abstract SecurityToken ReadTokenCore(XmlReader reader, SecurityTokenResolver tokenResolver);
+        public void WriteKeyIdentifier(XmlWriter writer, SecurityKeyIdentifier keyIdentifier);
+        public void WriteKeyIdentifierClause(XmlWriter writer, SecurityKeyIdentifierClause keyIdentifierClause);
+        protected abstract void WriteKeyIdentifierClauseCore(XmlWriter writer, SecurityKeyIdentifierClause keyIdentifierClause);
+        protected abstract void WriteKeyIdentifierCore(XmlWriter writer, SecurityKeyIdentifier keyIdentifier);
+        public void WriteToken(XmlWriter writer, SecurityToken token);
+        protected abstract void WriteTokenCore(XmlWriter writer, SecurityToken token);
+    }
+    public abstract class SecurityTokenVersion {
+        protected SecurityTokenVersion();
+        public abstract ReadOnlyCollection<string> GetSecuritySpecifications();
+    }
+    public class ServiceBusyException : Exception {
+        public ServiceBusyException();
+        protected ServiceBusyException(SerializationInfo info, StreamingContext context);
+        public ServiceBusyException(string message);
+        public ServiceBusyException(string message, Exception innerException);
+    }
+    public class ServiceNotStartedException : Exception {
+        public ServiceNotStartedException();
+        protected ServiceNotStartedException(SerializationInfo info, StreamingContext context);
+        public ServiceNotStartedException(string message);
+        public ServiceNotStartedException(string message, Exception innerException);
+    }
+    public class StsCommunicationException : Exception {
+        public StsCommunicationException();
+        protected StsCommunicationException(SerializationInfo info, StreamingContext context);
+        public StsCommunicationException(string message);
+        public StsCommunicationException(string message, Exception innerException);
+    }
+    public class UnsupportedPolicyOptionsException : Exception {
+        public UnsupportedPolicyOptionsException();
+        protected UnsupportedPolicyOptionsException(SerializationInfo info, StreamingContext context);
+        public UnsupportedPolicyOptionsException(string message);
+        public UnsupportedPolicyOptionsException(string message, Exception innerException);
+    }
+    public class UntrustedRecipientException : Exception {
+        public UntrustedRecipientException();
+        protected UntrustedRecipientException(SerializationInfo info, StreamingContext context);
+        public UntrustedRecipientException(string message);
+        public UntrustedRecipientException(string message, Exception innerException);
+    }
+    public class UserCancellationException : Exception {
+        public UserCancellationException();
+        protected UserCancellationException(SerializationInfo info, StreamingContext context);
+        public UserCancellationException(string message);
+        public UserCancellationException(string message, Exception innerException);
+    }
+    public abstract class UserNamePasswordValidator {
+        protected UserNamePasswordValidator();
+        public static UserNamePasswordValidator None { get; }
+        public static UserNamePasswordValidator CreateMembershipProviderValidator(MembershipProvider provider);
+        public abstract void Validate(string userName, string password);
+    }
+    public abstract class UserNameSecurityTokenAuthenticator : SecurityTokenAuthenticator {
+        protected UserNameSecurityTokenAuthenticator();
+        protected override bool CanValidateTokenCore(SecurityToken token);
+        protected override ReadOnlyCollection<IAuthorizationPolicy> ValidateTokenCore(SecurityToken token);
+        protected abstract ReadOnlyCollection<IAuthorizationPolicy> ValidateUserNamePasswordCore(string userName, string password);
+    }
+    public class UserNameSecurityTokenProvider : SecurityTokenProvider {
+        public UserNameSecurityTokenProvider(string userName, string password);
+        protected override SecurityToken GetTokenCore(TimeSpan timeout);
+    }
+    public class WindowsSecurityTokenAuthenticator : SecurityTokenAuthenticator {
+        public WindowsSecurityTokenAuthenticator();
+        public WindowsSecurityTokenAuthenticator(bool includeWindowsGroups);
+        protected override bool CanValidateTokenCore(SecurityToken token);
+        protected override ReadOnlyCollection<IAuthorizationPolicy> ValidateTokenCore(SecurityToken token);
+    }
+    public class WindowsUserNameSecurityTokenAuthenticator : UserNameSecurityTokenAuthenticator {
+        public WindowsUserNameSecurityTokenAuthenticator();
+        public WindowsUserNameSecurityTokenAuthenticator(bool includeWindowsGroups);
+        protected override ReadOnlyCollection<IAuthorizationPolicy> ValidateUserNamePasswordCore(string userName, string password);
+    }
+    public abstract class X509CertificateValidator : ICustomIdentityConfiguration {
+        protected X509CertificateValidator();
+        public static X509CertificateValidator ChainTrust { get; }
+        public static X509CertificateValidator None { get; }
+        public static X509CertificateValidator PeerOrChainTrust { get; }
+        public static X509CertificateValidator PeerTrust { get; }
+        public static X509CertificateValidator CreateChainTrustValidator(bool useMachineContext, X509ChainPolicy chainPolicy);
+        public static X509CertificateValidator CreatePeerOrChainTrustValidator(bool useMachineContext, X509ChainPolicy chainPolicy);
+        public virtual void LoadCustomConfiguration(XmlNodeList nodelist);
+        public abstract void Validate(X509Certificate2 certificate);
+    }
+    public class X509SecurityTokenAuthenticator : SecurityTokenAuthenticator {
+        public X509SecurityTokenAuthenticator();
+        public X509SecurityTokenAuthenticator(X509CertificateValidator validator);
+        public X509SecurityTokenAuthenticator(X509CertificateValidator validator, bool mapToWindows);
+        public X509SecurityTokenAuthenticator(X509CertificateValidator validator, bool mapToWindows, bool includeWindowsGroups);
+        public bool MapCertificateToWindowsAccount { get; }
+        protected override bool CanValidateTokenCore(SecurityToken token);
+        protected override ReadOnlyCollection<IAuthorizationPolicy> ValidateTokenCore(SecurityToken token);
+    }
+    public class X509SecurityTokenProvider : SecurityTokenProvider, IDisposable {
+        public X509SecurityTokenProvider(StoreLocation storeLocation, StoreName storeName, X509FindType findType, object findValue);
+        public X509SecurityTokenProvider(X509Certificate2 certificate);
+        public X509Certificate2 Certificate { get; }
+        public void Dispose();
+        protected override SecurityToken GetTokenCore(TimeSpan timeout);
+    }
+}
```

