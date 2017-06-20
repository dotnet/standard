# System.ServiceModel.Security

``` diff
+namespace System.ServiceModel.Security {
+    public class Basic128SecurityAlgorithmSuite : SecurityAlgorithmSuite {
+        public Basic128SecurityAlgorithmSuite();
+        public override string DefaultAsymmetricKeyWrapAlgorithm { get; }
+        public override string DefaultAsymmetricSignatureAlgorithm { get; }
+        public override string DefaultCanonicalizationAlgorithm { get; }
+        public override string DefaultDigestAlgorithm { get; }
+        public override string DefaultEncryptionAlgorithm { get; }
+        public override int DefaultEncryptionKeyDerivationLength { get; }
+        public override int DefaultSignatureKeyDerivationLength { get; }
+        public override int DefaultSymmetricKeyLength { get; }
+        public override string DefaultSymmetricKeyWrapAlgorithm { get; }
+        public override string DefaultSymmetricSignatureAlgorithm { get; }
+        public override bool IsAsymmetricKeyLengthSupported(int length);
+        public override bool IsSymmetricKeyLengthSupported(int length);
+        public override string ToString();
+    }
+    public class Basic192SecurityAlgorithmSuite : SecurityAlgorithmSuite {
+        public Basic192SecurityAlgorithmSuite();
+        public override string DefaultAsymmetricKeyWrapAlgorithm { get; }
+        public override string DefaultAsymmetricSignatureAlgorithm { get; }
+        public override string DefaultCanonicalizationAlgorithm { get; }
+        public override string DefaultDigestAlgorithm { get; }
+        public override string DefaultEncryptionAlgorithm { get; }
+        public override int DefaultEncryptionKeyDerivationLength { get; }
+        public override int DefaultSignatureKeyDerivationLength { get; }
+        public override int DefaultSymmetricKeyLength { get; }
+        public override string DefaultSymmetricKeyWrapAlgorithm { get; }
+        public override string DefaultSymmetricSignatureAlgorithm { get; }
+        public override bool IsAsymmetricKeyLengthSupported(int length);
+        public override bool IsSymmetricKeyLengthSupported(int length);
+        public override string ToString();
+    }
+    public class Basic256SecurityAlgorithmSuite : SecurityAlgorithmSuite {
+        public Basic256SecurityAlgorithmSuite();
+        public override string DefaultAsymmetricKeyWrapAlgorithm { get; }
+        public override string DefaultAsymmetricSignatureAlgorithm { get; }
+        public override string DefaultCanonicalizationAlgorithm { get; }
+        public override string DefaultDigestAlgorithm { get; }
+        public override string DefaultEncryptionAlgorithm { get; }
+        public override int DefaultEncryptionKeyDerivationLength { get; }
+        public override int DefaultSignatureKeyDerivationLength { get; }
+        public override int DefaultSymmetricKeyLength { get; }
+        public override string DefaultSymmetricKeyWrapAlgorithm { get; }
+        public override string DefaultSymmetricSignatureAlgorithm { get; }
+        public override bool IsAsymmetricKeyLengthSupported(int length);
+        public override bool IsSymmetricKeyLengthSupported(int length);
+        public override string ToString();
+    }
+    public abstract class BasicSecurityProfileVersion {
+        public static BasicSecurityProfileVersion BasicSecurityProfile10 { get; }
+    }
+    public class BinarySecretKeyIdentifierClause : BinaryKeyIdentifierClause {
+        public BinarySecretKeyIdentifierClause(byte[] key);
+        public BinarySecretKeyIdentifierClause(byte[] key, bool cloneBuffer);
+        public BinarySecretKeyIdentifierClause(byte[] key, bool cloneBuffer, byte[] derivationNonce, int derivationLength);
+        public override bool CanCreateKey { get; }
+        public override SecurityKey CreateKey();
+        public byte[] GetKeyBytes();
+        public override bool Matches(SecurityKeyIdentifierClause keyIdentifierClause);
+    }
+    public class ChannelProtectionRequirements {
+        public ChannelProtectionRequirements();
+        public ChannelProtectionRequirements(ChannelProtectionRequirements other);
+        public ScopedMessagePartSpecification IncomingEncryptionParts { get; }
+        public ScopedMessagePartSpecification IncomingSignatureParts { get; }
+        public bool IsReadOnly { get; }
+        public ScopedMessagePartSpecification OutgoingEncryptionParts { get; }
+        public ScopedMessagePartSpecification OutgoingSignatureParts { get; }
+        public void Add(ChannelProtectionRequirements protectionRequirements);
+        public void Add(ChannelProtectionRequirements protectionRequirements, bool channelScopeOnly);
+        public ChannelProtectionRequirements CreateInverse();
+        public void MakeReadOnly();
+    }
+    public class DataProtectionSecurityStateEncoder : SecurityStateEncoder {
+        public DataProtectionSecurityStateEncoder();
+        public DataProtectionSecurityStateEncoder(bool useCurrentUserProtectionScope);
+        public DataProtectionSecurityStateEncoder(bool useCurrentUserProtectionScope, byte[] entropy);
+        public bool UseCurrentUserProtectionScope { get; }
+        protected internal override byte[] DecodeSecurityState(byte[] data);
+        protected internal override byte[] EncodeSecurityState(byte[] data);
+        public byte[] GetEntropy();
+        public override string ToString();
+    }
+    public class DispatchContext {
+        public DispatchContext();
+        public ClaimsPrincipal Principal { get; set; }
+        public string RequestAction { get; set; }
+        public WSTrustMessage RequestMessage { get; set; }
+        public string ResponseAction { get; set; }
+        public RequestSecurityTokenResponse ResponseMessage { get; set; }
+        public SecurityTokenService SecurityTokenService { get; set; }
+        public string TrustNamespace { get; set; }
+    }
+    public class ExpiredSecurityTokenException : MessageSecurityException {
+        public ExpiredSecurityTokenException();
+        protected ExpiredSecurityTokenException(SerializationInfo info, StreamingContext context);
+        public ExpiredSecurityTokenException(string message);
+        public ExpiredSecurityTokenException(string message, Exception innerException);
+    }
+    public sealed class HttpDigestClientCredential {
+        public TokenImpersonationLevel AllowedImpersonationLevel { get; set; }
+        public NetworkCredential ClientCredential { get; set; }
+    }
+    public abstract class IdentityVerifier {
+        protected IdentityVerifier();
+        public abstract bool CheckAccess(EndpointIdentity identity, AuthorizationContext authContext);
+        public static IdentityVerifier CreateDefault();
+        public abstract bool TryGetIdentity(EndpointAddress reference, out EndpointIdentity identity);
+    }
+    public interface IEndpointIdentityProvider {
+        EndpointIdentity GetIdentityOfSelf(SecurityTokenRequirement tokenRequirement);
+    }
+    public class ImpersonateOnSerializingReplyMessageProperty : IMessageProperty {
+        public static string Name { get; }
+        public IMessageProperty CreateCopy();
+        public void StartImpersonation(out IDisposable impersonationContext, out IPrincipal originalPrincipal, out bool isThreadPrincipalSet);
+        public void StopImpersonation(IDisposable impersonationContext, IPrincipal originalPrincipal, bool isThreadPrincipalSet);
+        public static bool TryGet(Message message, out ImpersonateOnSerializingReplyMessageProperty property);
+        public static bool TryGet(MessageProperties properties, out ImpersonateOnSerializingReplyMessageProperty property);
+    }
+    public class InfocardInteractiveChannelInitializer : IInteractiveChannelInitializer {
+        public InfocardInteractiveChannelInitializer(ClientCredentials credentials, Binding binding);
+        public Binding Binding { get; }
+        public virtual IAsyncResult BeginDisplayInitializationUI(IClientChannel channel, AsyncCallback callback, object state);
+        public virtual void EndDisplayInitializationUI(IAsyncResult result);
+    }
+    public interface ISecureConversationSession : ISecuritySession, ISession {
+        bool TryReadSessionTokenIdentifier(XmlReader reader);
+        void WriteSessionTokenIdentifier(XmlDictionaryWriter writer);
+    }
+    public interface ISecuritySession : ISession {
+        EndpointIdentity RemoteIdentity { get; }
+    }
+    public sealed class IssuedTokenClientCredential {
+        public bool CacheIssuedTokens { get; set; }
+        public SecurityKeyEntropyMode DefaultKeyEntropyMode { get; set; }
+        public int IssuedTokenRenewalThresholdPercentage { get; set; }
+        public Dictionary<Uri, KeyedByTypeCollection<IEndpointBehavior>> IssuerChannelBehaviors { get; }
+        public EndpointAddress LocalIssuerAddress { get; set; }
+        public Binding LocalIssuerBinding { get; set; }
+        public KeyedByTypeCollection<IEndpointBehavior> LocalIssuerChannelBehaviors { get; }
+        public TimeSpan MaxIssuedTokenCachingTime { get; set; }
+    }
+    public class IssuedTokenServiceCredential {
+        public IList<string> AllowedAudienceUris { get; }
+        public bool AllowUntrustedRsaIssuers { get; set; }
+        public AudienceUriMode AudienceUriMode { get; set; }
+        public X509CertificateValidationMode CertificateValidationMode { get; set; }
+        public X509CertificateValidator CustomCertificateValidator { get; set; }
+        public IList<X509Certificate2> KnownCertificates { get; }
+        public X509RevocationMode RevocationMode { get; set; }
+        public SamlSerializer SamlSerializer { get; set; }
+        public StoreLocation TrustedStoreLocation { get; set; }
+    }
+    public interface IWSTrust13AsyncContract {
+        IAsyncResult BeginTrust13Cancel(Message request, AsyncCallback callback, object state);
+        IAsyncResult BeginTrust13CancelResponse(Message request, AsyncCallback callback, object state);
+        IAsyncResult BeginTrust13Issue(Message request, AsyncCallback callback, object state);
+        IAsyncResult BeginTrust13IssueResponse(Message request, AsyncCallback callback, object state);
+        IAsyncResult BeginTrust13Renew(Message request, AsyncCallback callback, object state);
+        IAsyncResult BeginTrust13RenewResponse(Message request, AsyncCallback callback, object state);
+        IAsyncResult BeginTrust13Validate(Message request, AsyncCallback callback, object state);
+        IAsyncResult BeginTrust13ValidateResponse(Message request, AsyncCallback callback, object state);
+        Message EndTrust13Cancel(IAsyncResult ar);
+        Message EndTrust13CancelResponse(IAsyncResult ar);
+        Message EndTrust13Issue(IAsyncResult ar);
+        Message EndTrust13IssueResponse(IAsyncResult ar);
+        Message EndTrust13Renew(IAsyncResult ar);
+        Message EndTrust13RenewResponse(IAsyncResult ar);
+        Message EndTrust13Validate(IAsyncResult ar);
+        Message EndTrust13ValidateResponse(IAsyncResult ar);
+    }
+    public interface IWSTrust13SyncContract {
+        Message ProcessTrust13Cancel(Message message);
+        Message ProcessTrust13CancelResponse(Message message);
+        Message ProcessTrust13Issue(Message message);
+        Message ProcessTrust13IssueResponse(Message message);
+        Message ProcessTrust13Renew(Message message);
+        Message ProcessTrust13RenewResponse(Message message);
+        Message ProcessTrust13Validate(Message message);
+        Message ProcessTrust13ValidateResponse(Message message);
+    }
+    public interface IWSTrustChannelContract : IWSTrustContract {
+        IAsyncResult BeginCancel(RequestSecurityToken request, AsyncCallback callback, object state);
+        IAsyncResult BeginIssue(RequestSecurityToken request, AsyncCallback callback, object asyncState);
+        IAsyncResult BeginRenew(RequestSecurityToken request, AsyncCallback callback, object state);
+        IAsyncResult BeginValidate(RequestSecurityToken request, AsyncCallback callback, object state);
+        RequestSecurityTokenResponse Cancel(RequestSecurityToken request);
+        void EndCancel(IAsyncResult result, out RequestSecurityTokenResponse response);
+        SecurityToken EndIssue(IAsyncResult result, out RequestSecurityTokenResponse response);
+        void EndRenew(IAsyncResult result, out RequestSecurityTokenResponse response);
+        void EndValidate(IAsyncResult result, out RequestSecurityTokenResponse response);
+        SecurityToken Issue(RequestSecurityToken request);
+        SecurityToken Issue(RequestSecurityToken request, out RequestSecurityTokenResponse response);
+        RequestSecurityTokenResponse Renew(RequestSecurityToken request);
+        RequestSecurityTokenResponse Validate(RequestSecurityToken request);
+    }
+    public interface IWSTrustContract {
+        IAsyncResult BeginCancel(Message message, AsyncCallback callback, object asyncState);
+        IAsyncResult BeginIssue(Message message, AsyncCallback callback, object asyncState);
+        IAsyncResult BeginRenew(Message message, AsyncCallback callback, object asyncState);
+        IAsyncResult BeginValidate(Message message, AsyncCallback callback, object asyncState);
+        Message Cancel(Message message);
+        Message EndCancel(IAsyncResult asyncResult);
+        Message EndIssue(IAsyncResult asyncResult);
+        Message EndRenew(IAsyncResult asyncResult);
+        Message EndValidate(IAsyncResult asyncResult);
+        Message Issue(Message message);
+        Message Renew(Message message);
+        Message Validate(Message message);
+    }
+    public interface IWSTrustFeb2005AsyncContract {
+        IAsyncResult BeginTrustFeb2005Cancel(Message request, AsyncCallback callback, object state);
+        IAsyncResult BeginTrustFeb2005CancelResponse(Message request, AsyncCallback callback, object state);
+        IAsyncResult BeginTrustFeb2005Issue(Message request, AsyncCallback callback, object state);
+        IAsyncResult BeginTrustFeb2005IssueResponse(Message request, AsyncCallback callback, object state);
+        IAsyncResult BeginTrustFeb2005Renew(Message request, AsyncCallback callback, object state);
+        IAsyncResult BeginTrustFeb2005RenewResponse(Message request, AsyncCallback callback, object state);
+        IAsyncResult BeginTrustFeb2005Validate(Message request, AsyncCallback callback, object state);
+        IAsyncResult BeginTrustFeb2005ValidateResponse(Message request, AsyncCallback callback, object state);
+        Message EndTrustFeb2005Cancel(IAsyncResult ar);
+        Message EndTrustFeb2005CancelResponse(IAsyncResult ar);
+        Message EndTrustFeb2005Issue(IAsyncResult ar);
+        Message EndTrustFeb2005IssueResponse(IAsyncResult ar);
+        Message EndTrustFeb2005Renew(IAsyncResult ar);
+        Message EndTrustFeb2005RenewResponse(IAsyncResult ar);
+        Message EndTrustFeb2005Validate(IAsyncResult ar);
+        Message EndTrustFeb2005ValidateResponse(IAsyncResult ar);
+    }
+    public interface IWSTrustFeb2005SyncContract {
+        Message ProcessTrustFeb2005Cancel(Message message);
+        Message ProcessTrustFeb2005CancelResponse(Message message);
+        Message ProcessTrustFeb2005Issue(Message message);
+        Message ProcessTrustFeb2005IssueResponse(Message message);
+        Message ProcessTrustFeb2005Renew(Message message);
+        Message ProcessTrustFeb2005RenewResponse(Message message);
+        Message ProcessTrustFeb2005Validate(Message message);
+        Message ProcessTrustFeb2005ValidateResponse(Message message);
+    }
+    public class KeyNameIdentifierClause : SecurityKeyIdentifierClause {
+        public KeyNameIdentifierClause(string keyName);
+        public string KeyName { get; }
+        public override bool Matches(SecurityKeyIdentifierClause keyIdentifierClause);
+        public bool Matches(string keyName);
+        public override string ToString();
+    }
+    public class MessagePartSpecification {
+        public MessagePartSpecification();
+        public MessagePartSpecification(bool isBodyIncluded);
+        public MessagePartSpecification(bool isBodyIncluded, params XmlQualifiedName[] headerTypes);
+        public MessagePartSpecification(params XmlQualifiedName[] headerTypes);
+        public ICollection<XmlQualifiedName> HeaderTypes { get; }
+        public bool IsBodyIncluded { get; set; }
+        public bool IsReadOnly { get; }
+        public static MessagePartSpecification NoParts { get; }
+        public void Clear();
+        public void MakeReadOnly();
+        public void Union(MessagePartSpecification specification);
+    }
+    public enum MessageProtectionOrder {
+        EncryptBeforeSign = 2,
+        SignBeforeEncrypt = 0,
+        SignBeforeEncryptAndEncryptSignature = 1,
+    }
+    public class MessageSecurityException : CommunicationException {
+        public MessageSecurityException();
+        protected MessageSecurityException(SerializationInfo info, StreamingContext context);
+        public MessageSecurityException(string message);
+        public MessageSecurityException(string message, Exception innerException);
+    }
+    public abstract class NonceCache {
+        protected NonceCache();
+        public int CacheSize { get; set; }
+        public TimeSpan CachingTimeSpan { get; set; }
+        public abstract bool CheckNonce(byte[] nonce);
+        public abstract bool TryAddNonce(byte[] nonce);
+    }
+    public class PeerCredential {
+        public X509Certificate2 Certificate { get; set; }
+        public string MeshPassword { get; set; }
+        public X509PeerCertificateAuthentication MessageSenderAuthentication { get; set; }
+        public X509PeerCertificateAuthentication PeerAuthentication { get; set; }
+        public void SetCertificate(StoreLocation storeLocation, StoreName storeName, X509FindType findType, object findValue);
+        public void SetCertificate(string subjectName, StoreLocation storeLocation, StoreName storeName);
+    }
+    public class ScopedMessagePartSpecification {
+        public ScopedMessagePartSpecification();
+        public ScopedMessagePartSpecification(ScopedMessagePartSpecification other);
+        public ICollection<string> Actions { get; }
+        public MessagePartSpecification ChannelParts { get; }
+        public bool IsReadOnly { get; }
+        public void AddParts(MessagePartSpecification parts);
+        public void AddParts(MessagePartSpecification parts, string action);
+        public void MakeReadOnly();
+        public bool TryGetParts(string action, bool excludeChannelScope, out MessagePartSpecification parts);
+        public bool TryGetParts(string action, out MessagePartSpecification parts);
+    }
+    public sealed class SecureConversationServiceCredential {
+        public Collection<Type> SecurityContextClaimTypes { get; }
+        public SecurityStateEncoder SecurityStateEncoder { get; set; }
+    }
+    public abstract class SecureConversationVersion {
+        public static SecureConversationVersion Default { get; }
+        public XmlDictionaryString Namespace { get; }
+        public XmlDictionaryString Prefix { get; }
+        public static SecureConversationVersion WSSecureConversation13 { get; }
+        public static SecureConversationVersion WSSecureConversationFeb2005 { get; }
+    }
+    public class SecurityAccessDeniedException : CommunicationException {
+        public SecurityAccessDeniedException();
+        protected SecurityAccessDeniedException(SerializationInfo info, StreamingContext context);
+        public SecurityAccessDeniedException(string message);
+        public SecurityAccessDeniedException(string message, Exception innerException);
+    }
+    public abstract class SecurityAlgorithmSuite {
+        protected SecurityAlgorithmSuite();
+        public static SecurityAlgorithmSuite Basic128 { get; }
+        public static SecurityAlgorithmSuite Basic128Rsa15 { get; }
+        public static SecurityAlgorithmSuite Basic128Sha256 { get; }
+        public static SecurityAlgorithmSuite Basic128Sha256Rsa15 { get; }
+        public static SecurityAlgorithmSuite Basic192 { get; }
+        public static SecurityAlgorithmSuite Basic192Rsa15 { get; }
+        public static SecurityAlgorithmSuite Basic192Sha256 { get; }
+        public static SecurityAlgorithmSuite Basic192Sha256Rsa15 { get; }
+        public static SecurityAlgorithmSuite Basic256 { get; }
+        public static SecurityAlgorithmSuite Basic256Rsa15 { get; }
+        public static SecurityAlgorithmSuite Basic256Sha256 { get; }
+        public static SecurityAlgorithmSuite Basic256Sha256Rsa15 { get; }
+        public static SecurityAlgorithmSuite Default { get; }
+        public abstract string DefaultAsymmetricKeyWrapAlgorithm { get; }
+        public abstract string DefaultAsymmetricSignatureAlgorithm { get; }
+        public abstract string DefaultCanonicalizationAlgorithm { get; }
+        public abstract string DefaultDigestAlgorithm { get; }
+        public abstract string DefaultEncryptionAlgorithm { get; }
+        public abstract int DefaultEncryptionKeyDerivationLength { get; }
+        public abstract int DefaultSignatureKeyDerivationLength { get; }
+        public abstract int DefaultSymmetricKeyLength { get; }
+        public abstract string DefaultSymmetricKeyWrapAlgorithm { get; }
+        public abstract string DefaultSymmetricSignatureAlgorithm { get; }
+        public static SecurityAlgorithmSuite TripleDes { get; }
+        public static SecurityAlgorithmSuite TripleDesRsa15 { get; }
+        public static SecurityAlgorithmSuite TripleDesSha256 { get; }
+        public static SecurityAlgorithmSuite TripleDesSha256Rsa15 { get; }
+        public abstract bool IsAsymmetricKeyLengthSupported(int length);
+        public virtual bool IsAsymmetricKeyWrapAlgorithmSupported(string algorithm);
+        public virtual bool IsAsymmetricSignatureAlgorithmSupported(string algorithm);
+        public virtual bool IsCanonicalizationAlgorithmSupported(string algorithm);
+        public virtual bool IsDigestAlgorithmSupported(string algorithm);
+        public virtual bool IsEncryptionAlgorithmSupported(string algorithm);
+        public virtual bool IsEncryptionKeyDerivationAlgorithmSupported(string algorithm);
+        public virtual bool IsSignatureKeyDerivationAlgorithmSupported(string algorithm);
+        public abstract bool IsSymmetricKeyLengthSupported(int length);
+        public virtual bool IsSymmetricKeyWrapAlgorithmSupported(string algorithm);
+        public virtual bool IsSymmetricSignatureAlgorithmSupported(string algorithm);
+    }
+    public class SecurityContextKeyIdentifierClause : SecurityKeyIdentifierClause {
+        public SecurityContextKeyIdentifierClause(UniqueId contextId);
+        public SecurityContextKeyIdentifierClause(UniqueId contextId, UniqueId generation);
+        public SecurityContextKeyIdentifierClause(UniqueId contextId, UniqueId generation, byte[] derivationNonce, int derivationLength);
+        public UniqueId ContextId { get; }
+        public UniqueId Generation { get; }
+        public override bool Matches(SecurityKeyIdentifierClause keyIdentifierClause);
+        public bool Matches(UniqueId contextId, UniqueId generation);
+        public override string ToString();
+    }
+    public abstract class SecurityCredentialsManager {
+        protected SecurityCredentialsManager();
+        public abstract SecurityTokenManager CreateSecurityTokenManager();
+    }
+    public enum SecurityKeyEntropyMode {
+        ClientEntropy = 0,
+        CombinedEntropy = 2,
+        ServerEntropy = 1,
+    }
+    public class SecurityMessageProperty : IDisposable, IMessageProperty {
+        public SecurityMessageProperty();
+        public ReadOnlyCollection<IAuthorizationPolicy> ExternalAuthorizationPolicies { get; set; }
+        public bool HasIncomingSupportingTokens { get; }
+        public Collection<SupportingTokenSpecification> IncomingSupportingTokens { get; }
+        public SecurityTokenSpecification InitiatorToken { get; set; }
+        public Collection<SupportingTokenSpecification> OutgoingSupportingTokens { get; }
+        public SecurityTokenSpecification ProtectionToken { get; set; }
+        public SecurityTokenSpecification RecipientToken { get; set; }
+        public string SenderIdPrefix { get; set; }
+        public ServiceSecurityContext ServiceSecurityContext { get; set; }
+        public SecurityTokenSpecification TransportToken { get; set; }
+        public IMessageProperty CreateCopy();
+        public void Dispose();
+        public static SecurityMessageProperty GetOrCreate(Message message);
+    }
+    public class SecurityNegotiationException : CommunicationException {
+        public SecurityNegotiationException();
+        protected SecurityNegotiationException(SerializationInfo info, StreamingContext context);
+        public SecurityNegotiationException(string message);
+        public SecurityNegotiationException(string message, Exception innerException);
+    }
+    public abstract class SecurityPolicyVersion {
+        public string Namespace { get; }
+        public string Prefix { get; }
+        public static SecurityPolicyVersion WSSecurityPolicy11 { get; }
+        public static SecurityPolicyVersion WSSecurityPolicy12 { get; }
+    }
+    public abstract class SecurityStateEncoder {
+        protected SecurityStateEncoder();
+        protected internal abstract byte[] DecodeSecurityState(byte[] data);
+        protected internal abstract byte[] EncodeSecurityState(byte[] data);
+    }
+    public enum SecurityTokenAttachmentMode {
+        Endorsing = 1,
+        Signed = 0,
+        SignedEncrypted = 3,
+        SignedEndorsing = 2,
+    }
+    public class SecurityTokenSpecification {
+        public SecurityTokenSpecification(SecurityToken token, ReadOnlyCollection<IAuthorizationPolicy> tokenPolicies);
+        public SecurityToken SecurityToken { get; }
+        public ReadOnlyCollection<IAuthorizationPolicy> SecurityTokenPolicies { get; }
+    }
+    public abstract class SecurityVersion {
+        public static SecurityVersion WSSecurity10 { get; }
+        public static SecurityVersion WSSecurity11 { get; }
+    }
+    public class ServiceCredentialsSecurityTokenManager : SecurityTokenManager, IEndpointIdentityProvider {
+        public ServiceCredentialsSecurityTokenManager(ServiceCredentials parent);
+        public ServiceCredentials ServiceCredentials { get; }
+        protected SecurityTokenAuthenticator CreateSecureConversationTokenAuthenticator(RecipientServiceModelSecurityTokenRequirement recipientRequirement, bool preserveBootstrapTokens, out SecurityTokenResolver sctResolver);
+        public override SecurityTokenAuthenticator CreateSecurityTokenAuthenticator(SecurityTokenRequirement tokenRequirement, out SecurityTokenResolver outOfBandTokenResolver);
+        public override SecurityTokenProvider CreateSecurityTokenProvider(SecurityTokenRequirement requirement);
+        public override SecurityTokenSerializer CreateSecurityTokenSerializer(SecurityTokenVersion version);
+        public virtual EndpointIdentity GetIdentityOfSelf(SecurityTokenRequirement tokenRequirement);
+        protected bool IsIssuedSecurityTokenRequirement(SecurityTokenRequirement requirement);
+    }
+    public class SimpleSecurityTokenProvider : SecurityTokenProvider {
+        public SimpleSecurityTokenProvider(SecurityToken token, SecurityTokenRequirement tokenRequirement);
+        protected override SecurityToken GetTokenCore(TimeSpan timeout);
+    }
+    public class SspiSecurityTokenProvider : SecurityTokenProvider {
+        public SspiSecurityTokenProvider(NetworkCredential credential, bool extractGroupsForWindowsAccounts, bool allowUnauthenticatedCallers);
+        public SspiSecurityTokenProvider(NetworkCredential credential, bool allowNtlm, TokenImpersonationLevel impersonationLevel);
+        protected override SecurityToken GetTokenCore(TimeSpan timeout);
+    }
+    public class SupportingTokenSpecification : SecurityTokenSpecification {
+        public SupportingTokenSpecification(SecurityToken token, ReadOnlyCollection<IAuthorizationPolicy> tokenPolicies, SecurityTokenAttachmentMode attachmentMode);
+        public SupportingTokenSpecification(SecurityToken token, ReadOnlyCollection<IAuthorizationPolicy> tokenPolicies, SecurityTokenAttachmentMode attachmentMode, SecurityTokenParameters tokenParameters);
+        public SecurityTokenAttachmentMode SecurityTokenAttachmentMode { get; }
+    }
+    public class TripleDesSecurityAlgorithmSuite : SecurityAlgorithmSuite {
+        public TripleDesSecurityAlgorithmSuite();
+        public override string DefaultAsymmetricKeyWrapAlgorithm { get; }
+        public override string DefaultAsymmetricSignatureAlgorithm { get; }
+        public override string DefaultCanonicalizationAlgorithm { get; }
+        public override string DefaultDigestAlgorithm { get; }
+        public override string DefaultEncryptionAlgorithm { get; }
+        public override int DefaultEncryptionKeyDerivationLength { get; }
+        public override int DefaultSignatureKeyDerivationLength { get; }
+        public override int DefaultSymmetricKeyLength { get; }
+        public override string DefaultSymmetricKeyWrapAlgorithm { get; }
+        public override string DefaultSymmetricSignatureAlgorithm { get; }
+        public override bool IsAsymmetricKeyLengthSupported(int length);
+        public override bool IsSymmetricKeyLengthSupported(int length);
+        public override string ToString();
+    }
+    public abstract class TrustVersion {
+        public static TrustVersion Default { get; }
+        public XmlDictionaryString Namespace { get; }
+        public XmlDictionaryString Prefix { get; }
+        public static TrustVersion WSTrust13 { get; }
+        public static TrustVersion WSTrustFeb2005 { get; }
+    }
+    public sealed class UserNamePasswordClientCredential {
+        public string Password { get; set; }
+        public string UserName { get; set; }
+    }
+    public sealed class UserNamePasswordServiceCredential {
+        public TimeSpan CachedLogonTokenLifetime { get; set; }
+        public bool CacheLogonTokens { get; set; }
+        public UserNamePasswordValidator CustomUserNamePasswordValidator { get; set; }
+        public bool IncludeWindowsGroups { get; set; }
+        public int MaxCachedLogonTokens { get; set; }
+        public MembershipProvider MembershipProvider { get; set; }
+        public UserNamePasswordValidationMode UserNamePasswordValidationMode { get; set; }
+    }
+    public enum UserNamePasswordValidationMode {
+        Custom = 2,
+        MembershipProvider = 1,
+        Windows = 0,
+    }
+    public sealed class WindowsClientCredential {
+        public TokenImpersonationLevel AllowedImpersonationLevel { get; set; }
+        public bool AllowNtlm { get; set; }
+        public NetworkCredential ClientCredential { get; set; }
+    }
+    public sealed class WindowsServiceCredential {
+        public bool AllowAnonymousLogons { get; set; }
+        public bool IncludeWindowsGroups { get; set; }
+    }
+    public class WSSecurityTokenSerializer : SecurityTokenSerializer {
+        public WSSecurityTokenSerializer();
+        public WSSecurityTokenSerializer(bool emitBspRequiredAttributes);
+        public WSSecurityTokenSerializer(SecurityVersion securityVersion);
+        public WSSecurityTokenSerializer(SecurityVersion securityVersion, bool emitBspRequiredAttributes);
+        public WSSecurityTokenSerializer(SecurityVersion securityVersion, bool emitBspRequiredAttributes, SamlSerializer samlSerializer);
+        public WSSecurityTokenSerializer(SecurityVersion securityVersion, bool emitBspRequiredAttributes, SamlSerializer samlSerializer, SecurityStateEncoder securityStateEncoder, IEnumerable<Type> knownTypes);
+        public WSSecurityTokenSerializer(SecurityVersion securityVersion, bool emitBspRequiredAttributes, SamlSerializer samlSerializer, SecurityStateEncoder securityStateEncoder, IEnumerable<Type> knownTypes, int maximumKeyDerivationOffset, int maximumKeyDerivationLabelLength, int maximumKeyDerivationNonceLength);
+        public WSSecurityTokenSerializer(SecurityVersion securityVersion, TrustVersion trustVersion, SecureConversationVersion secureConversationVersion, bool emitBspRequiredAttributes, SamlSerializer samlSerializer, SecurityStateEncoder securityStateEncoder, IEnumerable<Type> knownTypes);
+        public WSSecurityTokenSerializer(SecurityVersion securityVersion, TrustVersion trustVersion, SecureConversationVersion secureConversationVersion, bool emitBspRequiredAttributes, SamlSerializer samlSerializer, SecurityStateEncoder securityStateEncoder, IEnumerable<Type> knownTypes, int maximumKeyDerivationOffset, int maximumKeyDerivationLabelLength, int maximumKeyDerivationNonceLength);
+        public static WSSecurityTokenSerializer DefaultInstance { get; }
+        public bool EmitBspRequiredAttributes { get; }
+        public int MaximumKeyDerivationLabelLength { get; }
+        public int MaximumKeyDerivationNonceLength { get; }
+        public int MaximumKeyDerivationOffset { get; }
+        public SecurityVersion SecurityVersion { get; }
+        protected override bool CanReadKeyIdentifierClauseCore(XmlReader reader);
+        protected override bool CanReadKeyIdentifierCore(XmlReader reader);
+        protected override bool CanReadTokenCore(XmlReader reader);
+        protected override bool CanWriteKeyIdentifierClauseCore(SecurityKeyIdentifierClause keyIdentifierClause);
+        protected override bool CanWriteKeyIdentifierCore(SecurityKeyIdentifier keyIdentifier);
+        protected override bool CanWriteTokenCore(SecurityToken token);
+        public virtual SecurityKeyIdentifierClause CreateKeyIdentifierClauseFromTokenXml(XmlElement element, SecurityTokenReferenceStyle tokenReferenceStyle);
+        protected internal virtual string GetTokenTypeUri(Type tokenType);
+        protected override SecurityKeyIdentifierClause ReadKeyIdentifierClauseCore(XmlReader reader);
+        protected override SecurityKeyIdentifier ReadKeyIdentifierCore(XmlReader reader);
+        protected override SecurityToken ReadTokenCore(XmlReader reader, SecurityTokenResolver tokenResolver);
+        public virtual bool TryCreateKeyIdentifierClauseFromTokenXml(XmlElement element, SecurityTokenReferenceStyle tokenReferenceStyle, out SecurityKeyIdentifierClause securityKeyIdentifierClause);
+        protected override void WriteKeyIdentifierClauseCore(XmlWriter writer, SecurityKeyIdentifierClause keyIdentifierClause);
+        protected override void WriteKeyIdentifierCore(XmlWriter writer, SecurityKeyIdentifier keyIdentifier);
+        protected override void WriteTokenCore(XmlWriter writer, SecurityToken token);
+    }
+    public class WSTrustChannel : IChannel, ICommunicationObject, IWSTrustChannelContract, IWSTrustContract {
+        public WSTrustChannel(WSTrustChannelFactory factory, IWSTrustChannelContract inner, TrustVersion trustVersion, WSTrustSerializationContext context, WSTrustRequestSerializer requestSerializer, WSTrustResponseSerializer responseSerializer);
+        public IChannel Channel { get; protected set; }
+        public WSTrustChannelFactory ChannelFactory { get; protected set; }
+        public IWSTrustChannelContract Contract { get; protected set; }
+        public CommunicationState State { get; }
+        public TrustVersion TrustVersion { get; protected set; }
+        public WSTrustRequestSerializer WSTrustRequestSerializer { get; protected set; }
+        public WSTrustResponseSerializer WSTrustResponseSerializer { get; protected set; }
+        public WSTrustSerializationContext WSTrustSerializationContext { get; protected set; }
+        public event EventHandler Closed;
+        public event EventHandler Closing;
+        public event EventHandler Faulted;
+        public event EventHandler Opened;
+        public event EventHandler Opening;
+        public void Abort();
+        public IAsyncResult BeginCancel(RequestSecurityToken rst, AsyncCallback callback, object state);
+        public IAsyncResult BeginCancel(Message message, AsyncCallback callback, object asyncState);
+        public IAsyncResult BeginClose(AsyncCallback callback, object state);
+        public IAsyncResult BeginClose(TimeSpan timeout, AsyncCallback callback, object state);
+        public IAsyncResult BeginIssue(RequestSecurityToken rst, AsyncCallback callback, object asyncState);
+        public IAsyncResult BeginIssue(Message message, AsyncCallback callback, object asyncState);
+        public IAsyncResult BeginOpen(AsyncCallback callback, object state);
+        public IAsyncResult BeginOpen(TimeSpan timeout, AsyncCallback callback, object state);
+        public IAsyncResult BeginRenew(RequestSecurityToken rst, AsyncCallback callback, object state);
+        public IAsyncResult BeginRenew(Message message, AsyncCallback callback, object asyncState);
+        public IAsyncResult BeginValidate(RequestSecurityToken rst, AsyncCallback callback, object state);
+        public IAsyncResult BeginValidate(Message message, AsyncCallback callback, object asyncState);
+        public virtual RequestSecurityTokenResponse Cancel(RequestSecurityToken rst);
+        public Message Cancel(Message message);
+        public void Close();
+        public void Close(TimeSpan timeout);
+        protected virtual Message CreateRequest(RequestSecurityToken request, string requestType);
+        public Message EndCancel(IAsyncResult asyncResult);
+        public void EndCancel(IAsyncResult result, out RequestSecurityTokenResponse rstr);
+        public void EndClose(IAsyncResult result);
+        public Message EndIssue(IAsyncResult asyncResult);
+        public SecurityToken EndIssue(IAsyncResult result, out RequestSecurityTokenResponse rstr);
+        public void EndOpen(IAsyncResult result);
+        public Message EndRenew(IAsyncResult asyncResult);
+        public void EndRenew(IAsyncResult result, out RequestSecurityTokenResponse rstr);
+        public Message EndValidate(IAsyncResult asyncResult);
+        public void EndValidate(IAsyncResult result, out RequestSecurityTokenResponse rstr);
+        public T GetProperty<T>() where T : class;
+        protected static string GetRequestAction(string requestType, TrustVersion trustVersion);
+        public virtual SecurityToken GetTokenFromResponse(RequestSecurityToken request, RequestSecurityTokenResponse response);
+        public virtual SecurityToken Issue(RequestSecurityToken rst);
+        public virtual SecurityToken Issue(RequestSecurityToken rst, out RequestSecurityTokenResponse rstr);
+        public Message Issue(Message message);
+        public void Open();
+        public void Open(TimeSpan timeout);
+        protected virtual RequestSecurityTokenResponse ReadResponse(Message response);
+        public virtual RequestSecurityTokenResponse Renew(RequestSecurityToken rst);
+        public Message Renew(Message message);
+        public virtual RequestSecurityTokenResponse Validate(RequestSecurityToken rst);
+        public Message Validate(Message message);
+    }
+    public class WSTrustChannelFactory : ChannelFactory<IWSTrustChannelContract> {
+        public WSTrustChannelFactory();
+        public WSTrustChannelFactory(Binding binding);
+        public WSTrustChannelFactory(Binding binding, EndpointAddress remoteAddress);
+        public WSTrustChannelFactory(Binding binding, string remoteAddress);
+        public WSTrustChannelFactory(ServiceEndpoint endpoint);
+        public WSTrustChannelFactory(string endpointConfigurationName);
+        public WSTrustChannelFactory(string endpointConfigurationName, EndpointAddress remoteAddress);
+        public SecurityTokenHandlerCollectionManager SecurityTokenHandlerCollectionManager { get; set; }
+        public SecurityTokenResolver SecurityTokenResolver { get; set; }
+        public TrustVersion TrustVersion { get; set; }
+        public SecurityTokenResolver UseKeyTokenResolver { get; set; }
+        public WSTrustRequestSerializer WSTrustRequestSerializer { get; set; }
+        public WSTrustResponseSerializer WSTrustResponseSerializer { get; set; }
+        public override IWSTrustChannelContract CreateChannel(EndpointAddress address, Uri via);
+        protected virtual WSTrustSerializationContext CreateSerializationContext();
+        protected virtual WSTrustChannel CreateTrustChannel(IWSTrustChannelContract innerChannel, TrustVersion trustVersion, WSTrustSerializationContext context, WSTrustRequestSerializer requestSerializer, WSTrustResponseSerializer responseSerializer);
+    }
+    public class WSTrustRequestBodyWriter : BodyWriter {
+        public WSTrustRequestBodyWriter(RequestSecurityToken requestSecurityToken, WSTrustRequestSerializer serializer, WSTrustSerializationContext serializationContext);
+        protected override void OnWriteBodyContents(XmlDictionaryWriter writer);
+    }
+    public class WSTrustRequestProcessingErrorEventArgs : EventArgs {
+        public WSTrustRequestProcessingErrorEventArgs(string requestType, Exception exception);
+        public Exception Exception { get; }
+        public string RequestType { get; }
+    }
+    public class WSTrustResponseBodyWriter : BodyWriter {
+        public WSTrustResponseBodyWriter(RequestSecurityTokenResponse requestSecurityTokenResponse, WSTrustResponseSerializer serializer, WSTrustSerializationContext context);
+        protected override void OnWriteBodyContents(XmlDictionaryWriter writer);
+    }
+    public class WSTrustServiceContract : IContractBehavior, IWsdlExportExtension, IWSTrust13AsyncContract, IWSTrust13SyncContract, IWSTrustFeb2005AsyncContract, IWSTrustFeb2005SyncContract {
+        public WSTrustServiceContract(SecurityTokenServiceConfiguration securityTokenServiceConfiguration);
+        public SecurityTokenServiceConfiguration SecurityTokenServiceConfiguration { get; }
+        public event EventHandler<WSTrustRequestProcessingErrorEventArgs> RequestFailed;
+        public void AddBindingParameters(ContractDescription contractDescription, ServiceEndpoint endpoint, BindingParameterCollection bindingParameters);
+        public void ApplyClientBehavior(ContractDescription contractDescription, ServiceEndpoint endpoint, ClientRuntime clientRuntime);
+        public void ApplyDispatchBehavior(ContractDescription contractDescription, ServiceEndpoint endpoint, DispatchRuntime dispatchRuntime);
+        protected virtual IAsyncResult BeginDispatchRequest(DispatchContext dispatchContext, AsyncCallback asyncCallback, object asyncState);
+        protected virtual IAsyncResult BeginProcessCore(Message requestMessage, WSTrustRequestSerializer requestSerializer, WSTrustResponseSerializer responseSerializer, string requestAction, string responseAction, string trustNamespace, AsyncCallback callback, object state);
+        public IAsyncResult BeginTrust13Cancel(Message request, AsyncCallback callback, object state);
+        public IAsyncResult BeginTrust13CancelResponse(Message request, AsyncCallback callback, object state);
+        public IAsyncResult BeginTrust13Issue(Message request, AsyncCallback callback, object state);
+        public IAsyncResult BeginTrust13IssueResponse(Message request, AsyncCallback callback, object state);
+        public IAsyncResult BeginTrust13Renew(Message request, AsyncCallback callback, object state);
+        public IAsyncResult BeginTrust13RenewResponse(Message request, AsyncCallback callback, object state);
+        public IAsyncResult BeginTrust13Validate(Message request, AsyncCallback callback, object state);
+        public IAsyncResult BeginTrust13ValidateResponse(Message request, AsyncCallback callback, object state);
+        public IAsyncResult BeginTrustFeb2005Cancel(Message request, AsyncCallback callback, object state);
+        public IAsyncResult BeginTrustFeb2005CancelResponse(Message request, AsyncCallback callback, object state);
+        public IAsyncResult BeginTrustFeb2005Issue(Message request, AsyncCallback callback, object state);
+        public IAsyncResult BeginTrustFeb2005IssueResponse(Message request, AsyncCallback callback, object state);
+        public IAsyncResult BeginTrustFeb2005Renew(Message request, AsyncCallback callback, object state);
+        public IAsyncResult BeginTrustFeb2005RenewResponse(Message request, AsyncCallback callback, object state);
+        public IAsyncResult BeginTrustFeb2005Validate(Message request, AsyncCallback callback, object state);
+        public IAsyncResult BeginTrustFeb2005ValidateResponse(Message request, AsyncCallback callback, object state);
+        protected virtual DispatchContext CreateDispatchContext(Message requestMessage, string requestAction, string responseAction, string trustNamespace, WSTrustRequestSerializer requestSerializer, WSTrustResponseSerializer responseSerializer, WSTrustSerializationContext serializationContext);
+        protected virtual WSTrustSerializationContext CreateSerializationContext();
+        protected virtual void DispatchRequest(DispatchContext dispatchContext);
+        protected virtual DispatchContext EndDispatchRequest(IAsyncResult ar);
+        protected virtual Message EndProcessCore(IAsyncResult ar, string requestAction, string responseAction, string trustNamespace);
+        public Message EndTrust13Cancel(IAsyncResult ar);
+        public Message EndTrust13CancelResponse(IAsyncResult ar);
+        public Message EndTrust13Issue(IAsyncResult ar);
+        public Message EndTrust13IssueResponse(IAsyncResult ar);
+        public Message EndTrust13Renew(IAsyncResult ar);
+        public Message EndTrust13RenewResponse(IAsyncResult ar);
+        public Message EndTrust13Validate(IAsyncResult ar);
+        public Message EndTrust13ValidateResponse(IAsyncResult ar);
+        public Message EndTrustFeb2005Cancel(IAsyncResult ar);
+        public Message EndTrustFeb2005CancelResponse(IAsyncResult ar);
+        public Message EndTrustFeb2005Issue(IAsyncResult ar);
+        public Message EndTrustFeb2005IssueResponse(IAsyncResult ar);
+        public Message EndTrustFeb2005Renew(IAsyncResult ar);
+        public Message EndTrustFeb2005RenewResponse(IAsyncResult ar);
+        public Message EndTrustFeb2005Validate(IAsyncResult ar);
+        public Message EndTrustFeb2005ValidateResponse(IAsyncResult ar);
+        public virtual void ExportContract(WsdlExporter exporter, WsdlContractConversionContext context);
+        public virtual void ExportEndpoint(WsdlExporter exporter, WsdlEndpointConversionContext context);
+        protected virtual void FixMessageElement(ServiceDescription serviceDescription, PortType portType, WsdlEndpointConversionContext context, string operationName, XmlQualifiedName inputMessageElement, XmlQualifiedName outputMessageElement);
+        protected virtual SecurityTokenResolver GetRstSecurityTokenResolver();
+        protected virtual SecurityTokenResolver GetSecurityHeaderTokenResolver(RequestContext requestContext);
+        protected virtual bool HandleException(Exception ex, string trustNamespace, string action, EnvelopeVersion requestEnvelopeVersion);
+        protected virtual void ImportSchema(WsdlExporter exporter, WsdlEndpointConversionContext context, string ns);
+        protected virtual void IncludeNamespace(WsdlEndpointConversionContext context, string prefix, string ns);
+        protected virtual Message ProcessCore(Message requestMessage, WSTrustRequestSerializer requestSerializer, WSTrustResponseSerializer responseSerializer, string requestAction, string responseAction, string trustNamespace);
+        public Message ProcessTrust13Cancel(Message message);
+        public Message ProcessTrust13CancelResponse(Message message);
+        public Message ProcessTrust13Issue(Message message);
+        public Message ProcessTrust13IssueResponse(Message message);
+        public Message ProcessTrust13Renew(Message message);
+        public Message ProcessTrust13RenewResponse(Message message);
+        public Message ProcessTrust13Validate(Message message);
+        public Message ProcessTrust13ValidateResponse(Message message);
+        public Message ProcessTrustFeb2005Cancel(Message message);
+        public Message ProcessTrustFeb2005CancelResponse(Message message);
+        public Message ProcessTrustFeb2005Issue(Message message);
+        public Message ProcessTrustFeb2005IssueResponse(Message message);
+        public Message ProcessTrustFeb2005Renew(Message message);
+        public Message ProcessTrustFeb2005RenewResponse(Message message);
+        public Message ProcessTrustFeb2005Validate(Message message);
+        public Message ProcessTrustFeb2005ValidateResponse(Message message);
+        public void Validate(ContractDescription contractDescription, ServiceEndpoint endpoint);
+        protected virtual void ValidateDispatchContext(DispatchContext dispatchContext);
+    }
+    public class WSTrustServiceHost : ServiceHost {
+        public WSTrustServiceHost(SecurityTokenServiceConfiguration securityTokenServiceConfiguration, params Uri[] baseAddresses);
+        public WSTrustServiceHost(WSTrustServiceContract serviceContract, params Uri[] baseAddresses);
+        public SecurityTokenServiceConfiguration SecurityTokenServiceConfiguration { get; }
+        public WSTrustServiceContract ServiceContract { get; }
+        protected override void ApplyConfiguration();
+        protected virtual void ConfigureMetadata();
+        protected override void InitializeRuntime();
+        protected virtual void UpdateServiceConfiguration();
+    }
+    public sealed class X509CertificateInitiatorClientCredential {
+        public X509Certificate2 Certificate { get; set; }
+        public void SetCertificate(StoreLocation storeLocation, StoreName storeName, X509FindType findType, object findValue);
+        public void SetCertificate(string subjectName, StoreLocation storeLocation, StoreName storeName);
+    }
+    public sealed class X509CertificateInitiatorServiceCredential {
+        public X509ClientCertificateAuthentication Authentication { get; }
+        public X509Certificate2 Certificate { get; set; }
+        public void SetCertificate(StoreLocation storeLocation, StoreName storeName, X509FindType findType, object findValue);
+        public void SetCertificate(string subjectName, StoreLocation storeLocation, StoreName storeName);
+    }
+    public sealed class X509CertificateRecipientClientCredential {
+        public X509ServiceCertificateAuthentication Authentication { get; }
+        public X509Certificate2 DefaultCertificate { get; set; }
+        public Dictionary<Uri, X509Certificate2> ScopedCertificates { get; }
+        public X509ServiceCertificateAuthentication SslCertificateAuthentication { get; set; }
+        public void SetDefaultCertificate(StoreLocation storeLocation, StoreName storeName, X509FindType findType, object findValue);
+        public void SetDefaultCertificate(string subjectName, StoreLocation storeLocation, StoreName storeName);
+        public void SetScopedCertificate(StoreLocation storeLocation, StoreName storeName, X509FindType findType, object findValue, Uri targetService);
+        public void SetScopedCertificate(string subjectName, StoreLocation storeLocation, StoreName storeName, Uri targetService);
+    }
+    public sealed class X509CertificateRecipientServiceCredential {
+        public X509Certificate2 Certificate { get; set; }
+        public void SetCertificate(StoreLocation storeLocation, StoreName storeName, X509FindType findType, object findValue);
+        public void SetCertificate(string subjectName);
+        public void SetCertificate(string subjectName, StoreLocation storeLocation, StoreName storeName);
+    }
+    public enum X509CertificateValidationMode {
+        ChainTrust = 2,
+        Custom = 4,
+        None = 0,
+        PeerOrChainTrust = 3,
+        PeerTrust = 1,
+    }
+    public class X509ClientCertificateAuthentication {
+        public X509CertificateValidationMode CertificateValidationMode { get; set; }
+        public X509CertificateValidator CustomCertificateValidator { get; set; }
+        public bool IncludeWindowsGroups { get; set; }
+        public bool MapClientCertificateToWindowsAccount { get; set; }
+        public X509RevocationMode RevocationMode { get; set; }
+        public StoreLocation TrustedStoreLocation { get; set; }
+    }
+    public class X509PeerCertificateAuthentication {
+        public X509CertificateValidationMode CertificateValidationMode { get; set; }
+        public X509CertificateValidator CustomCertificateValidator { get; set; }
+        public X509RevocationMode RevocationMode { get; set; }
+        public StoreLocation TrustedStoreLocation { get; set; }
+    }
+    public sealed class X509ServiceCertificateAuthentication {
+        public X509ServiceCertificateAuthentication();
+        public X509CertificateValidationMode CertificateValidationMode { get; set; }
+        public X509CertificateValidator CustomCertificateValidator { get; set; }
+        public X509RevocationMode RevocationMode { get; set; }
+        public StoreLocation TrustedStoreLocation { get; set; }
+    }
+}
```

