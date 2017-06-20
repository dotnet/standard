# System.IdentityModel.Tokens

``` diff
+namespace System.IdentityModel.Tokens {
+    public class AggregateTokenResolver : SecurityTokenResolver {
+        public AggregateTokenResolver(IEnumerable<SecurityTokenResolver> tokenResolvers);
+        public ReadOnlyCollection<SecurityTokenResolver> TokenResolvers { get; }
+        protected override bool TryResolveSecurityKeyCore(SecurityKeyIdentifierClause keyIdentifierClause, out SecurityKey key);
+        protected override bool TryResolveTokenCore(SecurityKeyIdentifier keyIdentifier, out SecurityToken token);
+        protected override bool TryResolveTokenCore(SecurityKeyIdentifierClause keyIdentifierClause, out SecurityToken token);
+    }
+    public class AsymmetricProofDescriptor : ProofDescriptor {
+        public AsymmetricProofDescriptor();
+        public AsymmetricProofDescriptor(SecurityKeyIdentifier keyIdentifier);
+        public AsymmetricProofDescriptor(RSA rsaAlgorithm);
+        public override SecurityKeyIdentifier KeyIdentifier { get; }
+        public override void ApplyTo(RequestSecurityTokenResponse response);
+    }
+    public abstract class AsymmetricSecurityKey : SecurityKey {
+        protected AsymmetricSecurityKey();
+        public abstract AsymmetricAlgorithm GetAsymmetricAlgorithm(string algorithm, bool privateKey);
+        public abstract HashAlgorithm GetHashAlgorithmForSignature(string algorithm);
+        public abstract AsymmetricSignatureDeformatter GetSignatureDeformatter(string algorithm);
+        public abstract AsymmetricSignatureFormatter GetSignatureFormatter(string algorithm);
+        public abstract bool HasPrivateKey();
+    }
+    public class AudienceRestriction {
+        public AudienceRestriction();
+        public AudienceRestriction(AudienceUriMode audienceMode);
+        public Collection<Uri> AllowedAudienceUris { get; }
+        public AudienceUriMode AudienceMode { get; set; }
+    }
+    public class AudienceUriValidationFailedException : SecurityTokenValidationException {
+        public AudienceUriValidationFailedException();
+        protected AudienceUriValidationFailedException(SerializationInfo info, StreamingContext context);
+        public AudienceUriValidationFailedException(string message);
+        public AudienceUriValidationFailedException(string message, Exception inner);
+    }
+    public class AuthenticationContext {
+        public AuthenticationContext();
+        public Collection<string> Authorities { get; }
+        public string ContextClass { get; set; }
+        public string ContextDeclaration { get; set; }
+    }
+    public static class AuthenticationMethods {
+        public const string HardwareToken = "http://schemas.microsoft.com/ws/2008/06/identity/authenticationmethod/hardwaretoken";
+        public const string Kerberos = "http://schemas.microsoft.com/ws/2008/06/identity/authenticationmethod/kerberos";
+        public const string Namespace = "http://schemas.microsoft.com/ws/2008/06/identity/authenticationmethod/";
+        public const string Password = "http://schemas.microsoft.com/ws/2008/06/identity/authenticationmethod/password";
+        public const string Pgp = "http://schemas.microsoft.com/ws/2008/06/identity/authenticationmethod/pgp";
+        public const string SecureRemotePassword = "http://schemas.microsoft.com/ws/2008/06/identity/authenticationmethod/secureremotepassword";
+        public const string Signature = "http://schemas.microsoft.com/ws/2008/06/identity/authenticationmethod/signature";
+        public const string Smartcard = "http://schemas.microsoft.com/ws/2008/06/identity/authenticationmethod/smartcard";
+        public const string SmartcardPki = "http://schemas.microsoft.com/ws/2008/06/identity/authenticationmethod/smartcardpki";
+        public const string Spki = "http://schemas.microsoft.com/ws/2008/06/identity/authenticationmethod/spki";
+        public const string TlsClient = "http://schemas.microsoft.com/ws/2008/06/identity/authenticationmethod/tlsclient";
+        public const string Unspecified = "http://schemas.microsoft.com/ws/2008/06/identity/authenticationmethod/unspecified";
+        public const string Windows = "http://schemas.microsoft.com/ws/2008/06/identity/authenticationmethod/windows";
+        public const string X509 = "http://schemas.microsoft.com/ws/2008/06/identity/authenticationmethod/x509";
+        public const string Xkms = "http://schemas.microsoft.com/ws/2008/06/identity/authenticationmethod/xkms";
+    }
+    public abstract class BinaryKeyIdentifierClause : SecurityKeyIdentifierClause {
+        protected BinaryKeyIdentifierClause(string clauseType, byte[] identificationData, bool cloneBuffer);
+        protected BinaryKeyIdentifierClause(string clauseType, byte[] identificationData, bool cloneBuffer, byte[] derivationNonce, int derivationLength);
+        public byte[] GetBuffer();
+        protected byte[] GetRawBuffer();
+        public bool Matches(byte[] data);
+        public bool Matches(byte[] data, int offset);
+        public override bool Matches(SecurityKeyIdentifierClause keyIdentifierClause);
+    }
+    public class BootstrapContext : ISerializable {
+        public BootstrapContext(byte[] token);
+        public BootstrapContext(SecurityToken token, SecurityTokenHandler tokenHandler);
+        protected BootstrapContext(SerializationInfo info, StreamingContext context);
+        public BootstrapContext(string token);
+        public SecurityToken SecurityToken { get; }
+        public SecurityTokenHandler SecurityTokenHandler { get; }
+        public string Token { get; }
+        public byte[] TokenBytes { get; }
+        public virtual void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public static class ComputedKeyAlgorithms {
+        public const string Psha1 = "http://schemas.microsoft.com/idfx/computedkeyalgorithm/psha1";
+    }
+    public class ConfigurationBasedIssuerNameRegistry : IssuerNameRegistry {
+        public ConfigurationBasedIssuerNameRegistry();
+        public IDictionary<string, string> ConfiguredTrustedIssuers { get; }
+        public void AddTrustedIssuer(string certificateThumbprint, string name);
+        public override string GetIssuerName(SecurityToken securityToken);
+        public override void LoadCustomConfiguration(XmlNodeList customConfiguration);
+    }
+    public class EmptySecurityKeyIdentifierClause : SecurityKeyIdentifierClause {
+        public EmptySecurityKeyIdentifierClause();
+        public EmptySecurityKeyIdentifierClause(object context);
+        public object Context { get; }
+    }
+    public class EncryptedKeyEncryptingCredentials : EncryptingCredentials {
+        public EncryptedKeyEncryptingCredentials(EncryptingCredentials wrappingCredentials, int keySizeInBits, string encryptionAlgorithm);
+        public EncryptedKeyEncryptingCredentials(X509Certificate2 certificate);
+        public EncryptedKeyEncryptingCredentials(X509Certificate2 certificate, string keyWrappingAlgorithm, int keySizeInBits, string encryptionAlgorithm);
+        public EncryptingCredentials WrappingCredentials { get; }
+    }
+    public sealed class EncryptedKeyIdentifierClause : BinaryKeyIdentifierClause {
+        public EncryptedKeyIdentifierClause(byte[] encryptedKey, string encryptionMethod);
+        public EncryptedKeyIdentifierClause(byte[] encryptedKey, string encryptionMethod, SecurityKeyIdentifier encryptingKeyIdentifier);
+        public EncryptedKeyIdentifierClause(byte[] encryptedKey, string encryptionMethod, SecurityKeyIdentifier encryptingKeyIdentifier, string carriedKeyName);
+        public EncryptedKeyIdentifierClause(byte[] encryptedKey, string encryptionMethod, SecurityKeyIdentifier encryptingKeyIdentifier, string carriedKeyName, byte[] derivationNonce, int derivationLength);
+        public string CarriedKeyName { get; }
+        public SecurityKeyIdentifier EncryptingKeyIdentifier { get; }
+        public string EncryptionMethod { get; }
+        public byte[] GetEncryptedKey();
+        public bool Matches(byte[] encryptedKey, string encryptionMethod, string carriedKeyName);
+        public override bool Matches(SecurityKeyIdentifierClause keyIdentifierClause);
+        public override string ToString();
+    }
+    public class EncryptedSecurityToken : SecurityToken {
+        public EncryptedSecurityToken(SecurityToken token, EncryptingCredentials encryptingCredentials);
+        public EncryptingCredentials EncryptingCredentials { get; }
+        public override string Id { get; }
+        public override ReadOnlyCollection<SecurityKey> SecurityKeys { get; }
+        public SecurityToken Token { get; }
+        public override DateTime ValidFrom { get; }
+        public override DateTime ValidTo { get; }
+        public override bool CanCreateKeyIdentifierClause<T>();
+        public override T CreateKeyIdentifierClause<T>();
+        public override bool MatchesKeyIdentifierClause(SecurityKeyIdentifierClause keyIdentifierClause);
+        public override SecurityKey ResolveKeyIdentifierClause(SecurityKeyIdentifierClause keyIdentifierClause);
+    }
+    public class EncryptedSecurityTokenHandler : SecurityTokenHandler {
+        public EncryptedSecurityTokenHandler();
+        public override bool CanWriteToken { get; }
+        public SecurityTokenSerializer KeyInfoSerializer { get; set; }
+        public override Type TokenType { get; }
+        public override bool CanReadKeyIdentifierClause(XmlReader reader);
+        public override bool CanReadToken(XmlReader reader);
+        public override string[] GetTokenTypeIdentifiers();
+        public override SecurityKeyIdentifierClause ReadKeyIdentifierClause(XmlReader reader);
+        public override SecurityToken ReadToken(XmlReader reader);
+        public override void WriteToken(XmlWriter writer, SecurityToken token);
+    }
+    public class EncryptedTokenDecryptionFailedException : SecurityTokenException {
+        public EncryptedTokenDecryptionFailedException();
+        protected EncryptedTokenDecryptionFailedException(SerializationInfo info, StreamingContext context);
+        public EncryptedTokenDecryptionFailedException(string message);
+        public EncryptedTokenDecryptionFailedException(string message, Exception inner);
+    }
+    public class EncryptingCredentials {
+        public EncryptingCredentials();
+        public EncryptingCredentials(SecurityKey key, SecurityKeyIdentifier keyIdentifier, string algorithm);
+        public string Algorithm { get; set; }
+        public SecurityKey SecurityKey { get; set; }
+        public SecurityKeyIdentifier SecurityKeyIdentifier { get; set; }
+    }
+    public class GenericXmlSecurityKeyIdentifierClause : SecurityKeyIdentifierClause {
+        public GenericXmlSecurityKeyIdentifierClause(XmlElement referenceXml);
+        public GenericXmlSecurityKeyIdentifierClause(XmlElement referenceXml, byte[] derivationNonce, int derivationLength);
+        public XmlElement ReferenceXml { get; }
+        public override bool Matches(SecurityKeyIdentifierClause keyIdentifierClause);
+    }
+    public class GenericXmlSecurityToken : SecurityToken {
+        public GenericXmlSecurityToken(XmlElement tokenXml, SecurityToken proofToken, DateTime effectiveTime, DateTime expirationTime, SecurityKeyIdentifierClause internalTokenReference, SecurityKeyIdentifierClause externalTokenReference, ReadOnlyCollection<IAuthorizationPolicy> authorizationPolicies);
+        public ReadOnlyCollection<IAuthorizationPolicy> AuthorizationPolicies { get; }
+        public SecurityKeyIdentifierClause ExternalTokenReference { get; }
+        public override string Id { get; }
+        public SecurityKeyIdentifierClause InternalTokenReference { get; }
+        public SecurityToken ProofToken { get; }
+        public override ReadOnlyCollection<SecurityKey> SecurityKeys { get; }
+        public XmlElement TokenXml { get; }
+        public override DateTime ValidFrom { get; }
+        public override DateTime ValidTo { get; }
+        public override bool CanCreateKeyIdentifierClause<T>();
+        public override T CreateKeyIdentifierClause<T>();
+        public override bool MatchesKeyIdentifierClause(SecurityKeyIdentifierClause keyIdentifierClause);
+        public override string ToString();
+    }
+    public class InMemorySymmetricSecurityKey : SymmetricSecurityKey {
+        public InMemorySymmetricSecurityKey(byte[] symmetricKey);
+        public InMemorySymmetricSecurityKey(byte[] symmetricKey, bool cloneBuffer);
+        public override int KeySize { get; }
+        public override byte[] DecryptKey(string algorithm, byte[] keyData);
+        public override byte[] EncryptKey(string algorithm, byte[] keyData);
+        public override byte[] GenerateDerivedKey(string algorithm, byte[] label, byte[] nonce, int derivedKeyLength, int offset);
+        public override ICryptoTransform GetDecryptionTransform(string algorithm, byte[] iv);
+        public override ICryptoTransform GetEncryptionTransform(string algorithm, byte[] iv);
+        public override int GetIVSize(string algorithm);
+        public override KeyedHashAlgorithm GetKeyedHashAlgorithm(string algorithm);
+        public override SymmetricAlgorithm GetSymmetricAlgorithm(string algorithm);
+        public override byte[] GetSymmetricKey();
+        public override bool IsAsymmetricAlgorithm(string algorithm);
+        public override bool IsSupportedAlgorithm(string algorithm);
+        public override bool IsSymmetricAlgorithm(string algorithm);
+    }
+    public abstract class IssuerNameRegistry : ICustomIdentityConfiguration {
+        protected IssuerNameRegistry();
+        public abstract string GetIssuerName(SecurityToken securityToken);
+        public virtual string GetIssuerName(SecurityToken securityToken, string requestedIssuerName);
+        public virtual string GetWindowsIssuerName();
+        public virtual void LoadCustomConfiguration(XmlNodeList nodelist);
+    }
+    public class IssuerTokenResolver : SecurityTokenResolver {
+        public static readonly StoreLocation DefaultStoreLocation;
+        public static readonly StoreName DefaultStoreName;
+        public IssuerTokenResolver();
+        public IssuerTokenResolver(SecurityTokenResolver wrappedTokenResolver);
+        public SecurityTokenResolver WrappedTokenResolver { get; }
+        protected override bool TryResolveSecurityKeyCore(SecurityKeyIdentifierClause keyIdentifierClause, out SecurityKey key);
+        protected override bool TryResolveTokenCore(SecurityKeyIdentifier keyIdentifier, out SecurityToken token);
+        protected override bool TryResolveTokenCore(SecurityKeyIdentifierClause keyIdentifierClause, out SecurityToken token);
+    }
+    public class KerberosReceiverSecurityToken : WindowsSecurityToken {
+        public KerberosReceiverSecurityToken(byte[] request);
+        public KerberosReceiverSecurityToken(byte[] request, string id);
+        public KerberosReceiverSecurityToken(byte[] request, string id, string valueTypeUri);
+        public SymmetricSecurityKey SecurityKey { get; }
+        public override ReadOnlyCollection<SecurityKey> SecurityKeys { get; }
+        public override DateTime ValidFrom { get; }
+        public override DateTime ValidTo { get; }
+        public string ValueTypeUri { get; }
+        public override WindowsIdentity WindowsIdentity { get; }
+        public override bool CanCreateKeyIdentifierClause<T>();
+        public override T CreateKeyIdentifierClause<T>();
+        public byte[] GetRequest();
+        public override bool MatchesKeyIdentifierClause(SecurityKeyIdentifierClause keyIdentifierClause);
+    }
+    public class KerberosRequestorSecurityToken : SecurityToken {
+        public KerberosRequestorSecurityToken(string servicePrincipalName);
+        public KerberosRequestorSecurityToken(string servicePrincipalName, TokenImpersonationLevel tokenImpersonationLevel, NetworkCredential networkCredential, string id);
+        public override string Id { get; }
+        public SymmetricSecurityKey SecurityKey { get; }
+        public override ReadOnlyCollection<SecurityKey> SecurityKeys { get; }
+        public string ServicePrincipalName { get; }
+        public override DateTime ValidFrom { get; }
+        public override DateTime ValidTo { get; }
+        public override bool CanCreateKeyIdentifierClause<T>();
+        public override T CreateKeyIdentifierClause<T>();
+        public byte[] GetRequest();
+        public override bool MatchesKeyIdentifierClause(SecurityKeyIdentifierClause keyIdentifierClause);
+    }
+    public class KerberosSecurityTokenHandler : SecurityTokenHandler {
+        public KerberosSecurityTokenHandler();
+        public override bool CanValidateToken { get; }
+        public override Type TokenType { get; }
+        public override string[] GetTokenTypeIdentifiers();
+        public override ReadOnlyCollection<ClaimsIdentity> ValidateToken(SecurityToken token);
+    }
+    public sealed class KerberosTicketHashKeyIdentifierClause : BinaryKeyIdentifierClause {
+        public KerberosTicketHashKeyIdentifierClause(byte[] ticketHash);
+        public KerberosTicketHashKeyIdentifierClause(byte[] ticketHash, byte[] derivationNonce, int derivationLength);
+        public byte[] GetKerberosTicketHash();
+        public override string ToString();
+    }
+    public class LocalIdKeyIdentifierClause : SecurityKeyIdentifierClause {
+        public LocalIdKeyIdentifierClause(string localId);
+        public LocalIdKeyIdentifierClause(string localId, byte[] derivationNonce, int derivationLength, Type ownerType);
+        public LocalIdKeyIdentifierClause(string localId, Type ownerType);
+        public string LocalId { get; }
+        public Type OwnerType { get; }
+        public override bool Matches(SecurityKeyIdentifierClause keyIdentifierClause);
+        public bool Matches(string localId, Type ownerType);
+        public override string ToString();
+    }
+    public abstract class ProofDescriptor {
+        protected ProofDescriptor();
+        public abstract SecurityKeyIdentifier KeyIdentifier { get; }
+        public abstract void ApplyTo(RequestSecurityTokenResponse response);
+    }
+    public class RsaKeyIdentifierClause : SecurityKeyIdentifierClause {
+        public RsaKeyIdentifierClause(RSA rsa);
+        public override bool CanCreateKey { get; }
+        public RSA Rsa { get; }
+        public override SecurityKey CreateKey();
+        public byte[] GetExponent();
+        public byte[] GetModulus();
+        public override bool Matches(SecurityKeyIdentifierClause keyIdentifierClause);
+        public bool Matches(RSA rsa);
+        public override string ToString();
+        public void WriteExponentAsBase64(XmlWriter writer);
+        public void WriteModulusAsBase64(XmlWriter writer);
+    }
+    public sealed class RsaSecurityKey : AsymmetricSecurityKey {
+        public RsaSecurityKey(RSA rsa);
+        public override int KeySize { get; }
+        public override byte[] DecryptKey(string algorithm, byte[] keyData);
+        public override byte[] EncryptKey(string algorithm, byte[] keyData);
+        public override AsymmetricAlgorithm GetAsymmetricAlgorithm(string algorithm, bool requiresPrivateKey);
+        public override HashAlgorithm GetHashAlgorithmForSignature(string algorithm);
+        public override AsymmetricSignatureDeformatter GetSignatureDeformatter(string algorithm);
+        public override AsymmetricSignatureFormatter GetSignatureFormatter(string algorithm);
+        public override bool HasPrivateKey();
+        public override bool IsAsymmetricAlgorithm(string algorithm);
+        public override bool IsSupportedAlgorithm(string algorithm);
+        public override bool IsSymmetricAlgorithm(string algorithm);
+    }
+    public class RsaSecurityToken : SecurityToken {
+        public RsaSecurityToken(RSA rsa);
+        public RsaSecurityToken(RSA rsa, string id);
+        public override string Id { get; }
+        public RSA Rsa { get; }
+        public override ReadOnlyCollection<SecurityKey> SecurityKeys { get; }
+        public override DateTime ValidFrom { get; }
+        public override DateTime ValidTo { get; }
+        public override bool CanCreateKeyIdentifierClause<T>();
+        public override T CreateKeyIdentifierClause<T>();
+        ~RsaSecurityToken();
+        public override bool MatchesKeyIdentifierClause(SecurityKeyIdentifierClause keyIdentifierClause);
+    }
+    public class RsaSecurityTokenHandler : SecurityTokenHandler {
+        public RsaSecurityTokenHandler();
+        public override bool CanValidateToken { get; }
+        public override bool CanWriteToken { get; }
+        public override Type TokenType { get; }
+        public override bool CanReadToken(XmlReader reader);
+        public override string[] GetTokenTypeIdentifiers();
+        public override SecurityToken ReadToken(XmlReader reader);
+        public override ReadOnlyCollection<ClaimsIdentity> ValidateToken(SecurityToken token);
+        public override void WriteToken(XmlWriter writer, SecurityToken token);
+    }
+    public class Saml2Action {
+        public Saml2Action(string value, Uri actionNamespace);
+        public Uri Namespace { get; set; }
+        public string Value { get; set; }
+    }
+    public class Saml2Advice {
+        public Saml2Advice();
+        public Collection<Saml2Id> AssertionIdReferences { get; }
+        public Collection<Saml2Assertion> Assertions { get; }
+        public Collection<Uri> AssertionUriReferences { get; }
+    }
+    public class Saml2Assertion {
+        public Saml2Assertion(Saml2NameIdentifier issuer);
+        public Saml2Advice Advice { get; set; }
+        public virtual bool CanWriteSourceData { get; }
+        public Saml2Conditions Conditions { get; set; }
+        public EncryptingCredentials EncryptingCredentials { get; set; }
+        public Collection<EncryptedKeyIdentifierClause> ExternalEncryptedKeys { get; }
+        public Saml2Id Id { get; set; }
+        public DateTime IssueInstant { get; set; }
+        public Saml2NameIdentifier Issuer { get; set; }
+        public SigningCredentials SigningCredentials { get; set; }
+        public Collection<Saml2Statement> Statements { get; }
+        public Saml2Subject Subject { get; set; }
+        public string Version { get; }
+        public virtual void WriteSourceData(XmlWriter writer);
+    }
+    public class Saml2AssertionKeyIdentifierClause : SecurityKeyIdentifierClause {
+        public Saml2AssertionKeyIdentifierClause(string id);
+        public Saml2AssertionKeyIdentifierClause(string id, byte[] derivationNonce, int derivationLength);
+        public override bool Matches(SecurityKeyIdentifierClause keyIdentifierClause);
+        public static bool Matches(string assertionId, SecurityKeyIdentifierClause keyIdentifierClause);
+        public override string ToString();
+    }
+    public class Saml2Attribute {
+        public Saml2Attribute(string name);
+        public Saml2Attribute(string name, IEnumerable<string> values);
+        public Saml2Attribute(string name, string value);
+        public string AttributeValueXsiType { get; set; }
+        public string FriendlyName { get; set; }
+        public string Name { get; set; }
+        public Uri NameFormat { get; set; }
+        public string OriginalIssuer { get; set; }
+        public Collection<string> Values { get; }
+    }
+    public class Saml2AttributeStatement : Saml2Statement {
+        public Saml2AttributeStatement();
+        public Saml2AttributeStatement(IEnumerable<Saml2Attribute> attributes);
+        public Saml2AttributeStatement(Saml2Attribute attribute);
+        public Collection<Saml2Attribute> Attributes { get; }
+    }
+    public class Saml2AudienceRestriction {
+        public Saml2AudienceRestriction();
+        public Saml2AudienceRestriction(IEnumerable<Uri> audiences);
+        public Saml2AudienceRestriction(Uri audience);
+        public Collection<Uri> Audiences { get; }
+    }
+    public class Saml2AuthenticationContext {
+        public Saml2AuthenticationContext();
+        public Saml2AuthenticationContext(Uri classReference);
+        public Saml2AuthenticationContext(Uri classReference, Uri declarationReference);
+        public Collection<Uri> AuthenticatingAuthorities { get; }
+        public Uri ClassReference { get; set; }
+        public Uri DeclarationReference { get; set; }
+    }
+    public class Saml2AuthenticationStatement : Saml2Statement {
+        public Saml2AuthenticationStatement(Saml2AuthenticationContext authenticationContext);
+        public Saml2AuthenticationStatement(Saml2AuthenticationContext authenticationContext, DateTime authenticationInstant);
+        public Saml2AuthenticationContext AuthenticationContext { get; set; }
+        public DateTime AuthenticationInstant { get; set; }
+        public string SessionIndex { get; set; }
+        public Nullable<DateTime> SessionNotOnOrAfter { get; set; }
+        public Saml2SubjectLocality SubjectLocality { get; set; }
+    }
+    public class Saml2AuthorizationDecisionStatement : Saml2Statement {
+        public static readonly Uri EmptyResource;
+        public Saml2AuthorizationDecisionStatement(Uri resource, SamlAccessDecision decision);
+        public Saml2AuthorizationDecisionStatement(Uri resource, SamlAccessDecision decision, IEnumerable<Saml2Action> actions);
+        public Collection<Saml2Action> Actions { get; }
+        public SamlAccessDecision Decision { get; set; }
+        public Saml2Evidence Evidence { get; set; }
+        public Uri Resource { get; set; }
+    }
+    public class Saml2Conditions {
+        public Saml2Conditions();
+        public Collection<Saml2AudienceRestriction> AudienceRestrictions { get; }
+        public Nullable<DateTime> NotBefore { get; set; }
+        public Nullable<DateTime> NotOnOrAfter { get; set; }
+        public bool OneTimeUse { get; set; }
+        public Saml2ProxyRestriction ProxyRestriction { get; set; }
+    }
+    public class Saml2Evidence {
+        public Saml2Evidence();
+        public Saml2Evidence(Saml2Assertion assertion);
+        public Saml2Evidence(Saml2Id idReference);
+        public Saml2Evidence(Uri uriReference);
+        public Collection<Saml2Id> AssertionIdReferences { get; }
+        public Collection<Saml2Assertion> Assertions { get; }
+        public Collection<Uri> AssertionUriReferences { get; }
+    }
+    public class Saml2Id {
+        public Saml2Id();
+        public Saml2Id(string value);
+        public string Value { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public override string ToString();
+    }
+    public class Saml2NameIdentifier {
+        public Saml2NameIdentifier(string name);
+        public Saml2NameIdentifier(string name, Uri format);
+        public EncryptingCredentials EncryptingCredentials { get; set; }
+        public Collection<EncryptedKeyIdentifierClause> ExternalEncryptedKeys { get; }
+        public Uri Format { get; set; }
+        public string NameQualifier { get; set; }
+        public string SPNameQualifier { get; set; }
+        public string SPProvidedId { get; set; }
+        public string Value { get; set; }
+    }
+    public class Saml2ProxyRestriction {
+        public Saml2ProxyRestriction();
+        public Collection<Uri> Audiences { get; }
+        public Nullable<int> Count { get; set; }
+    }
+    public class Saml2SecurityKeyIdentifierClause : SecurityKeyIdentifierClause {
+        public Saml2SecurityKeyIdentifierClause(Saml2Assertion assertion);
+        public Saml2Assertion Assertion { get; }
+    }
+    public class Saml2SecurityToken : SecurityToken {
+        public Saml2SecurityToken(Saml2Assertion assertion);
+        public Saml2SecurityToken(Saml2Assertion assertion, ReadOnlyCollection<SecurityKey> keys, SecurityToken issuerToken);
+        public Saml2Assertion Assertion { get; }
+        public override string Id { get; }
+        public SecurityToken IssuerToken { get; }
+        public override ReadOnlyCollection<SecurityKey> SecurityKeys { get; }
+        public override DateTime ValidFrom { get; }
+        public override DateTime ValidTo { get; }
+        public override bool CanCreateKeyIdentifierClause<T>();
+        public override T CreateKeyIdentifierClause<T>();
+        public override bool MatchesKeyIdentifierClause(SecurityKeyIdentifierClause keyIdentifierClause);
+    }
+    public class Saml2SecurityTokenHandler : SecurityTokenHandler {
+        public const string TokenProfile11ValueType = "http://docs.oasis-open.org/wss/oasis-wss-saml-token-profile-1.1#SAMLID";
+        public Saml2SecurityTokenHandler();
+        public Saml2SecurityTokenHandler(SamlSecurityTokenRequirement samlSecurityTokenRequirement);
+        public override bool CanValidateToken { get; }
+        public override bool CanWriteToken { get; }
+        public X509CertificateValidator CertificateValidator { get; set; }
+        public SecurityTokenSerializer KeyInfoSerializer { get; set; }
+        public SamlSecurityTokenRequirement SamlSecurityTokenRequirement { get; set; }
+        public override Type TokenType { get; }
+        protected virtual void AddDelegateToAttributes(ClaimsIdentity subject, ICollection<Saml2Attribute> attributes, SecurityTokenDescriptor tokenDescriptor);
+        public override bool CanReadKeyIdentifierClause(XmlReader reader);
+        public override bool CanReadToken(XmlReader reader);
+        public override bool CanWriteKeyIdentifierClause(SecurityKeyIdentifierClause securityKeyIdentifierClause);
+        protected virtual ICollection<Saml2Attribute> CollectAttributeValues(ICollection<Saml2Attribute> attributes);
+        protected virtual Saml2Advice CreateAdvice(SecurityTokenDescriptor tokenDescriptor);
+        protected virtual Saml2Attribute CreateAttribute(Claim claim, SecurityTokenDescriptor tokenDescriptor);
+        protected virtual Saml2AttributeStatement CreateAttributeStatement(ClaimsIdentity subject, SecurityTokenDescriptor tokenDescriptor);
+        protected virtual Saml2AuthenticationStatement CreateAuthenticationStatement(AuthenticationInformation authInfo, SecurityTokenDescriptor tokenDescriptor);
+        protected virtual ClaimsIdentity CreateClaims(Saml2SecurityToken samlToken);
+        protected virtual Saml2Conditions CreateConditions(Lifetime tokenLifetime, string relyingPartyAddress, SecurityTokenDescriptor tokenDescriptor);
+        protected virtual Saml2NameIdentifier CreateIssuerNameIdentifier(SecurityTokenDescriptor tokenDescriptor);
+        protected virtual Saml2Subject CreateSamlSubject(SecurityTokenDescriptor tokenDescriptor);
+        public override SecurityKeyIdentifierClause CreateSecurityTokenReference(SecurityToken token, bool attached);
+        protected virtual IEnumerable<Saml2Statement> CreateStatements(SecurityTokenDescriptor tokenDescriptor);
+        public override SecurityToken CreateToken(SecurityTokenDescriptor tokenDescriptor);
+        protected virtual WindowsIdentity CreateWindowsIdentity(string upn);
+        protected virtual string CreateXmlStringFromAttributes(IEnumerable<Saml2Attribute> attributes);
+        protected virtual string DenormalizeAuthenticationType(string normalizedAuthenticationType);
+        protected override void DetectReplayedToken(SecurityToken token);
+        protected virtual string FindUpn(ClaimsIdentity claimsIdentity);
+        protected virtual EncryptingCredentials GetEncryptingCredentials(SecurityTokenDescriptor tokenDescriptor);
+        protected virtual SigningCredentials GetSigningCredentials(SecurityTokenDescriptor tokenDescriptor);
+        protected virtual DateTime GetTokenReplayCacheEntryExpirationTime(Saml2SecurityToken token);
+        public override string[] GetTokenTypeIdentifiers();
+        public override void LoadCustomConfiguration(XmlNodeList customConfigElements);
+        protected virtual string NormalizeAuthenticationContextClassReference(string saml2AuthenticationContextClassReference);
+        protected virtual void ProcessAttributeStatement(Saml2AttributeStatement statement, ClaimsIdentity subject, string issuer);
+        protected virtual void ProcessAuthenticationStatement(Saml2AuthenticationStatement statement, ClaimsIdentity subject, string issuer);
+        protected virtual void ProcessAuthorizationDecisionStatement(Saml2AuthorizationDecisionStatement statement, ClaimsIdentity subject, string issuer);
+        protected virtual void ProcessSamlSubject(Saml2Subject assertionSubject, ClaimsIdentity subject, string issuer);
+        protected virtual void ProcessStatement(Collection<Saml2Statement> statements, ClaimsIdentity subject, string issuer);
+        protected virtual Saml2Action ReadAction(XmlReader reader);
+        protected virtual Saml2Advice ReadAdvice(XmlReader reader);
+        protected virtual Saml2Assertion ReadAssertion(XmlReader reader);
+        protected virtual Saml2Attribute ReadAttribute(XmlReader reader);
+        protected virtual Saml2AttributeStatement ReadAttributeStatement(XmlReader reader);
+        protected virtual string ReadAttributeValue(XmlReader reader, Saml2Attribute attribute);
+        protected virtual Saml2AudienceRestriction ReadAudienceRestriction(XmlReader reader);
+        protected virtual Saml2AuthenticationContext ReadAuthenticationContext(XmlReader reader);
+        protected virtual Saml2AuthenticationStatement ReadAuthenticationStatement(XmlReader reader);
+        protected virtual Saml2AuthorizationDecisionStatement ReadAuthorizationDecisionStatement(XmlReader reader);
+        protected virtual Saml2Conditions ReadConditions(XmlReader reader);
+        protected virtual Saml2NameIdentifier ReadEncryptedId(XmlReader reader);
+        protected virtual Saml2Evidence ReadEvidence(XmlReader reader);
+        protected virtual Saml2NameIdentifier ReadIssuer(XmlReader reader);
+        public override SecurityKeyIdentifierClause ReadKeyIdentifierClause(XmlReader reader);
+        protected virtual Saml2NameIdentifier ReadNameId(XmlReader reader);
+        protected virtual Saml2NameIdentifier ReadNameIdType(XmlReader reader);
+        protected virtual Saml2ProxyRestriction ReadProxyRestriction(XmlReader reader);
+        protected virtual SecurityKeyIdentifier ReadSigningKeyInfo(XmlReader reader, Saml2Assertion assertion);
+        protected virtual Saml2Statement ReadStatement(XmlReader reader);
+        protected virtual Saml2Subject ReadSubject(XmlReader reader);
+        protected virtual Saml2SubjectConfirmation ReadSubjectConfirmation(XmlReader reader);
+        protected virtual Saml2SubjectConfirmationData ReadSubjectConfirmationData(XmlReader reader);
+        protected virtual Saml2NameIdentifier ReadSubjectId(XmlReader reader, string parentElement);
+        protected virtual SecurityKeyIdentifier ReadSubjectKeyInfo(XmlReader reader);
+        protected virtual Saml2SubjectLocality ReadSubjectLocality(XmlReader reader);
+        public override SecurityToken ReadToken(XmlReader reader);
+        protected virtual SecurityToken ResolveIssuerToken(Saml2Assertion assertion, SecurityTokenResolver issuerResolver);
+        protected virtual ReadOnlyCollection<SecurityKey> ResolveSecurityKeys(Saml2Assertion assertion, SecurityTokenResolver resolver);
+        protected virtual void SetDelegateFromAttribute(Saml2Attribute attribute, ClaimsIdentity subject, string issuer);
+        protected virtual bool TryResolveIssuerToken(Saml2Assertion assertion, SecurityTokenResolver issuerResolver, out SecurityToken token);
+        protected virtual void ValidateConditions(Saml2Conditions conditions, bool enforceAudienceRestriction);
+        protected virtual void ValidateConfirmationData(Saml2SubjectConfirmationData confirmationData);
+        public override ReadOnlyCollection<ClaimsIdentity> ValidateToken(SecurityToken token);
+        protected virtual void WriteAction(XmlWriter writer, Saml2Action data);
+        protected virtual void WriteAdvice(XmlWriter writer, Saml2Advice data);
+        protected virtual void WriteAssertion(XmlWriter writer, Saml2Assertion data);
+        protected virtual void WriteAttribute(XmlWriter writer, Saml2Attribute data);
+        protected virtual void WriteAttributeStatement(XmlWriter writer, Saml2AttributeStatement data);
+        protected virtual void WriteAttributeValue(XmlWriter writer, string value, Saml2Attribute attribute);
+        protected virtual void WriteAudienceRestriction(XmlWriter writer, Saml2AudienceRestriction data);
+        protected virtual void WriteAuthenticationContext(XmlWriter writer, Saml2AuthenticationContext data);
+        protected virtual void WriteAuthenticationStatement(XmlWriter writer, Saml2AuthenticationStatement data);
+        protected virtual void WriteAuthorizationDecisionStatement(XmlWriter writer, Saml2AuthorizationDecisionStatement data);
+        protected virtual void WriteConditions(XmlWriter writer, Saml2Conditions data);
+        protected virtual void WriteEvidence(XmlWriter writer, Saml2Evidence data);
+        protected virtual void WriteIssuer(XmlWriter writer, Saml2NameIdentifier data);
+        public override void WriteKeyIdentifierClause(XmlWriter writer, SecurityKeyIdentifierClause securityKeyIdentifierClause);
+        protected virtual void WriteNameId(XmlWriter writer, Saml2NameIdentifier data);
+        protected virtual void WriteNameIdType(XmlWriter writer, Saml2NameIdentifier data);
+        protected virtual void WriteProxyRestriction(XmlWriter writer, Saml2ProxyRestriction data);
+        protected virtual void WriteSigningKeyInfo(XmlWriter writer, SecurityKeyIdentifier data);
+        protected virtual void WriteStatement(XmlWriter writer, Saml2Statement data);
+        protected virtual void WriteSubject(XmlWriter writer, Saml2Subject data);
+        protected virtual void WriteSubjectConfirmation(XmlWriter writer, Saml2SubjectConfirmation data);
+        protected virtual void WriteSubjectConfirmationData(XmlWriter writer, Saml2SubjectConfirmationData data);
+        protected virtual void WriteSubjectKeyInfo(XmlWriter writer, SecurityKeyIdentifier data);
+        protected virtual void WriteSubjectLocality(XmlWriter writer, Saml2SubjectLocality data);
+        public override void WriteToken(XmlWriter writer, SecurityToken token);
+    }
+    public abstract class Saml2Statement {
+        protected Saml2Statement();
+    }
+    public class Saml2Subject {
+        public Saml2Subject();
+        public Saml2Subject(Saml2NameIdentifier nameId);
+        public Saml2Subject(Saml2SubjectConfirmation subjectConfirmation);
+        public Saml2NameIdentifier NameId { get; set; }
+        public Collection<Saml2SubjectConfirmation> SubjectConfirmations { get; }
+    }
+    public class Saml2SubjectConfirmation {
+        public Saml2SubjectConfirmation(Uri method);
+        public Saml2SubjectConfirmation(Uri method, Saml2SubjectConfirmationData data);
+        public Uri Method { get; set; }
+        public Saml2NameIdentifier NameIdentifier { get; set; }
+        public Saml2SubjectConfirmationData SubjectConfirmationData { get; set; }
+    }
+    public class Saml2SubjectConfirmationData {
+        public Saml2SubjectConfirmationData();
+        public string Address { get; set; }
+        public Saml2Id InResponseTo { get; set; }
+        public Collection<SecurityKeyIdentifier> KeyIdentifiers { get; }
+        public Nullable<DateTime> NotBefore { get; set; }
+        public Nullable<DateTime> NotOnOrAfter { get; set; }
+        public Uri Recipient { get; set; }
+    }
+    public class Saml2SubjectLocality {
+        public Saml2SubjectLocality();
+        public Saml2SubjectLocality(string address, string dnsName);
+        public string Address { get; set; }
+        public string DnsName { get; set; }
+    }
+    public enum SamlAccessDecision {
+        Deny = 1,
+        Indeterminate = 2,
+        Permit = 0,
+    }
+    public class SamlAction {
+        public SamlAction();
+        public SamlAction(string action);
+        public SamlAction(string action, string ns);
+        public string Action { get; set; }
+        public bool IsReadOnly { get; }
+        public string Namespace { get; set; }
+        public void MakeReadOnly();
+        public virtual void ReadXml(XmlDictionaryReader reader, SamlSerializer samlSerializer, SecurityTokenSerializer keyInfoSerializer, SecurityTokenResolver outOfBandTokenResolver);
+        public virtual void WriteXml(XmlDictionaryWriter writer, SamlSerializer samlSerializer, SecurityTokenSerializer keyInfoSerializer);
+    }
+    public class SamlAdvice {
+        public SamlAdvice();
+        public SamlAdvice(IEnumerable<SamlAssertion> assertions);
+        public SamlAdvice(IEnumerable<string> references);
+        public SamlAdvice(IEnumerable<string> references, IEnumerable<SamlAssertion> assertions);
+        public IList<string> AssertionIdReferences { get; }
+        public IList<SamlAssertion> Assertions { get; }
+        public bool IsReadOnly { get; }
+        public void MakeReadOnly();
+        public virtual void ReadXml(XmlDictionaryReader reader, SamlSerializer samlSerializer, SecurityTokenSerializer keyInfoSerializer, SecurityTokenResolver outOfBandTokenResolver);
+        public virtual void WriteXml(XmlDictionaryWriter writer, SamlSerializer samlSerializer, SecurityTokenSerializer keyInfoSerializer);
+    }
+    public class SamlAssertion : ICanonicalWriterEndRootElementCallback {
+        public SamlAssertion();
+        public SamlAssertion(string assertionId, string issuer, DateTime issueInstant, SamlConditions samlConditions, SamlAdvice samlAdvice, IEnumerable<SamlStatement> samlStatements);
+        public SamlAdvice Advice { get; set; }
+        public string AssertionId { get; set; }
+        public virtual bool CanWriteSourceData { get; }
+        public SamlConditions Conditions { get; set; }
+        public bool IsReadOnly { get; }
+        public DateTime IssueInstant { get; set; }
+        public string Issuer { get; set; }
+        public int MajorVersion { get; }
+        public int MinorVersion { get; }
+        public SigningCredentials SigningCredentials { get; set; }
+        public SecurityToken SigningToken { get; set; }
+        public IList<SamlStatement> Statements { get; }
+        public void MakeReadOnly();
+        protected void ReadSignature(XmlDictionaryReader reader, SecurityTokenSerializer keyInfoSerializer, SecurityTokenResolver outOfBandTokenResolver, SamlSerializer samlSerializer);
+        public virtual void ReadXml(XmlDictionaryReader reader, SamlSerializer samlSerializer, SecurityTokenSerializer keyInfoSerializer, SecurityTokenResolver outOfBandTokenResolver);
+        public virtual void WriteSourceData(XmlWriter writer);
+        public virtual void WriteXml(XmlDictionaryWriter writer, SamlSerializer samlSerializer, SecurityTokenSerializer keyInfoSerializer);
+    }
+    public class SamlAssertionKeyIdentifierClause : SecurityKeyIdentifierClause {
+        public SamlAssertionKeyIdentifierClause(string assertionId);
+        public SamlAssertionKeyIdentifierClause(string assertionId, byte[] derivationNonce, int derivationLength);
+        public string AssertionId { get; }
+        public override bool Matches(SecurityKeyIdentifierClause keyIdentifierClause);
+        public bool Matches(string assertionId);
+        public override string ToString();
+    }
+    public class SamlAttribute {
+        public SamlAttribute();
+        public SamlAttribute(Claim claim);
+        public SamlAttribute(string attributeNamespace, string attributeName, IEnumerable<string> attributeValues);
+        public IList<string> AttributeValues { get; }
+        public string AttributeValueXsiType { get; set; }
+        public bool IsReadOnly { get; }
+        public string Name { get; set; }
+        public string Namespace { get; set; }
+        public string OriginalIssuer { get; set; }
+        public virtual ReadOnlyCollection<Claim> ExtractClaims();
+        public void MakeReadOnly();
+        public virtual void ReadXml(XmlDictionaryReader reader, SamlSerializer samlSerializer, SecurityTokenSerializer keyInfoSerializer, SecurityTokenResolver outOfBandTokenResolver);
+        public virtual void WriteXml(XmlDictionaryWriter writer, SamlSerializer samlSerializer, SecurityTokenSerializer keyInfoSerializer);
+    }
+    public class SamlAttributeStatement : SamlSubjectStatement {
+        public SamlAttributeStatement();
+        public SamlAttributeStatement(SamlSubject samlSubject, IEnumerable<SamlAttribute> attributes);
+        public IList<SamlAttribute> Attributes { get; }
+        public override bool IsReadOnly { get; }
+        protected override void AddClaimsToList(IList<Claim> claims);
+        public override void MakeReadOnly();
+        public override void ReadXml(XmlDictionaryReader reader, SamlSerializer samlSerializer, SecurityTokenSerializer keyInfoSerializer, SecurityTokenResolver outOfBandTokenResolver);
+        public override void WriteXml(XmlDictionaryWriter writer, SamlSerializer samlSerializer, SecurityTokenSerializer keyInfoSerializer);
+    }
+    public class SamlAudienceRestrictionCondition : SamlCondition {
+        public SamlAudienceRestrictionCondition();
+        public SamlAudienceRestrictionCondition(IEnumerable<Uri> audiences);
+        public IList<Uri> Audiences { get; }
+        public override bool IsReadOnly { get; }
+        public override void MakeReadOnly();
+        public override void ReadXml(XmlDictionaryReader reader, SamlSerializer samlSerializer, SecurityTokenSerializer keyInfoSerializer, SecurityTokenResolver outOfBandTokenResolver);
+        public override void WriteXml(XmlDictionaryWriter writer, SamlSerializer samlSerializer, SecurityTokenSerializer keyInfoSerializer);
+    }
+    public class SamlAuthenticationClaimResource {
+        public SamlAuthenticationClaimResource(DateTime authenticationInstant, string authenticationMethod, string dnsAddress, string ipAddress);
+        public SamlAuthenticationClaimResource(DateTime authenticationInstant, string authenticationMethod, string dnsAddress, string ipAddress, IEnumerable<SamlAuthorityBinding> authorityBindings);
+        public SamlAuthenticationClaimResource(DateTime authenticationInstant, string authenticationMethod, string dnsAddress, string ipAddress, ReadOnlyCollection<SamlAuthorityBinding> authorityBindings);
+        public DateTime AuthenticationInstant { get; }
+        public string AuthenticationMethod { get; }
+        public ReadOnlyCollection<SamlAuthorityBinding> AuthorityBindings { get; }
+        public string DnsAddress { get; }
+        public string IPAddress { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+    }
+    public class SamlAuthenticationStatement : SamlSubjectStatement {
+        public SamlAuthenticationStatement();
+        public SamlAuthenticationStatement(SamlSubject samlSubject, string authenticationMethod, DateTime authenticationInstant, string dnsAddress, string ipAddress, IEnumerable<SamlAuthorityBinding> authorityBindings);
+        public DateTime AuthenticationInstant { get; set; }
+        public string AuthenticationMethod { get; set; }
+        public IList<SamlAuthorityBinding> AuthorityBindings { get; }
+        public static string ClaimType { get; }
+        public string DnsAddress { get; set; }
+        public string IPAddress { get; set; }
+        public override bool IsReadOnly { get; }
+        protected override void AddClaimsToList(IList<Claim> claims);
+        public override void MakeReadOnly();
+        public override void ReadXml(XmlDictionaryReader reader, SamlSerializer samlSerializer, SecurityTokenSerializer keyInfoSerializer, SecurityTokenResolver outOfBandTokenResolver);
+        public override void WriteXml(XmlDictionaryWriter writer, SamlSerializer samlSerializer, SecurityTokenSerializer keyInfoSerializer);
+    }
+    public class SamlAuthorityBinding {
+        public SamlAuthorityBinding();
+        public SamlAuthorityBinding(XmlQualifiedName authorityKind, string binding, string location);
+        public XmlQualifiedName AuthorityKind { get; set; }
+        public string Binding { get; set; }
+        public bool IsReadOnly { get; }
+        public string Location { get; set; }
+        public void MakeReadOnly();
+        public virtual void ReadXml(XmlDictionaryReader reader, SamlSerializer samlSerializer, SecurityTokenSerializer keyInfoSerializer, SecurityTokenResolver outOfBandTokenResolver);
+        public virtual void WriteXml(XmlDictionaryWriter writer, SamlSerializer samlSerializer, SecurityTokenSerializer keyInfoSerializer);
+    }
+    public class SamlAuthorizationDecisionClaimResource {
+        public SamlAuthorizationDecisionClaimResource(string resource, SamlAccessDecision accessDecision, string actionNamespace, string actionName);
+        public SamlAccessDecision AccessDecision { get; }
+        public string ActionName { get; }
+        public string ActionNamespace { get; }
+        public string Resource { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+    }
+    public class SamlAuthorizationDecisionStatement : SamlSubjectStatement {
+        public SamlAuthorizationDecisionStatement();
+        public SamlAuthorizationDecisionStatement(SamlSubject samlSubject, string resource, SamlAccessDecision accessDecision, IEnumerable<SamlAction> samlActions);
+        public SamlAuthorizationDecisionStatement(SamlSubject samlSubject, string resource, SamlAccessDecision accessDecision, IEnumerable<SamlAction> samlActions, SamlEvidence samlEvidence);
+        public SamlAccessDecision AccessDecision { get; set; }
+        public static string ClaimType { get; }
+        public SamlEvidence Evidence { get; set; }
+        public override bool IsReadOnly { get; }
+        public string Resource { get; set; }
+        public IList<SamlAction> SamlActions { get; }
+        protected override void AddClaimsToList(IList<Claim> claims);
+        public override void MakeReadOnly();
+        public override void ReadXml(XmlDictionaryReader reader, SamlSerializer samlSerializer, SecurityTokenSerializer keyInfoSerializer, SecurityTokenResolver outOfBandTokenResolver);
+        public override void WriteXml(XmlDictionaryWriter writer, SamlSerializer samlSerializer, SecurityTokenSerializer keyInfoSerializer);
+    }
+    public abstract class SamlCondition {
+        protected SamlCondition();
+        public abstract bool IsReadOnly { get; }
+        public abstract void MakeReadOnly();
+        public abstract void ReadXml(XmlDictionaryReader reader, SamlSerializer samlSerializer, SecurityTokenSerializer keyInfoSerializer, SecurityTokenResolver outOfBandTokenResolver);
+        public abstract void WriteXml(XmlDictionaryWriter writer, SamlSerializer samlSerializer, SecurityTokenSerializer keyInfoSerializer);
+    }
+    public class SamlConditions {
+        public SamlConditions();
+        public SamlConditions(DateTime notBefore, DateTime notOnOrAfter);
+        public SamlConditions(DateTime notBefore, DateTime notOnOrAfter, IEnumerable<SamlCondition> conditions);
+        public IList<SamlCondition> Conditions { get; }
+        public bool IsReadOnly { get; }
+        public DateTime NotBefore { get; set; }
+        public DateTime NotOnOrAfter { get; set; }
+        public void MakeReadOnly();
+        public virtual void ReadXml(XmlDictionaryReader reader, SamlSerializer samlSerializer, SecurityTokenSerializer keyInfoSerializer, SecurityTokenResolver outOfBandTokenResolver);
+        public virtual void WriteXml(XmlDictionaryWriter writer, SamlSerializer samlSerializer, SecurityTokenSerializer keyInfoSerializer);
+    }
+    public static class SamlConstants {
+        public const string Prefix = "saml";
+        public static string EmailName { get; }
+        public static string EmailNamespace { get; }
+        public static string HolderOfKey { get; }
+        public static int MajorVersionValue { get; }
+        public static int MinorVersionValue { get; }
+        public static string Namespace { get; }
+        public static string SenderVouches { get; }
+        public static string UserName { get; }
+        public static string UserNameNamespace { get; }
+    }
+    public class SamlDoNotCacheCondition : SamlCondition {
+        public SamlDoNotCacheCondition();
+        public override bool IsReadOnly { get; }
+        public override void MakeReadOnly();
+        public override void ReadXml(XmlDictionaryReader reader, SamlSerializer samlSerializer, SecurityTokenSerializer keyInfoSerializer, SecurityTokenResolver outOfBandTokenResolver);
+        public override void WriteXml(XmlDictionaryWriter writer, SamlSerializer samlSerializer, SecurityTokenSerializer keyInfoSerializer);
+    }
+    public class SamlEvidence {
+        public SamlEvidence();
+        public SamlEvidence(IEnumerable<SamlAssertion> assertions);
+        public SamlEvidence(IEnumerable<string> assertionIdReferences);
+        public SamlEvidence(IEnumerable<string> assertionIdReferences, IEnumerable<SamlAssertion> assertions);
+        public IList<string> AssertionIdReferences { get; }
+        public IList<SamlAssertion> Assertions { get; }
+        public bool IsReadOnly { get; }
+        public void MakeReadOnly();
+        public virtual void ReadXml(XmlDictionaryReader reader, SamlSerializer samlSerializer, SecurityTokenSerializer keyInfoSerializer, SecurityTokenResolver outOfBandTokenResolver);
+        public virtual void WriteXml(XmlDictionaryWriter writer, SamlSerializer samlSerializer, SecurityTokenSerializer keyInfoSerializer);
+    }
+    public class SamlNameIdentifierClaimResource {
+        public SamlNameIdentifierClaimResource(string name, string nameQualifier, string format);
+        public string Format { get; }
+        public string Name { get; }
+        public string NameQualifier { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+    }
+    public class SamlSecurityKeyIdentifierClause : SecurityKeyIdentifierClause {
+        public SamlSecurityKeyIdentifierClause(SamlAssertion assertion);
+        public SamlAssertion Assertion { get; }
+    }
+    public class SamlSecurityToken : SecurityToken {
+        protected SamlSecurityToken();
+        public SamlSecurityToken(SamlAssertion assertion);
+        public SamlAssertion Assertion { get; }
+        public override string Id { get; }
+        public override ReadOnlyCollection<SecurityKey> SecurityKeys { get; }
+        public override DateTime ValidFrom { get; }
+        public override DateTime ValidTo { get; }
+        public override bool CanCreateKeyIdentifierClause<T>();
+        public override T CreateKeyIdentifierClause<T>();
+        protected void Initialize(SamlAssertion assertion);
+        public override bool MatchesKeyIdentifierClause(SecurityKeyIdentifierClause keyIdentifierClause);
+    }
+    public class SamlSecurityTokenHandler : SecurityTokenHandler {
+        public const string Assertion = "urn:oasis:names:tc:SAML:1.0:assertion";
+        public const string BearerConfirmationMethod = "urn:oasis:names:tc:SAML:1.0:cm:bearer";
+        public const string Namespace = "urn:oasis:names:tc:SAML:1.0";
+        public const string UnspecifiedAuthenticationMethod = "urn:oasis:names:tc:SAML:1.0:am:unspecified";
+        public SamlSecurityTokenHandler();
+        public SamlSecurityTokenHandler(SamlSecurityTokenRequirement samlSecurityTokenRequirement);
+        public override bool CanValidateToken { get; }
+        public override bool CanWriteToken { get; }
+        public X509CertificateValidator CertificateValidator { get; set; }
+        public SecurityTokenSerializer KeyInfoSerializer { get; set; }
+        public SamlSecurityTokenRequirement SamlSecurityTokenRequirement { get; set; }
+        public override Type TokenType { get; }
+        protected virtual void AddDelegateToAttributes(ClaimsIdentity subject, ICollection<SamlAttribute> attributes, SecurityTokenDescriptor tokenDescriptor);
+        public override bool CanReadToken(XmlReader reader);
+        protected virtual ICollection<SamlAttribute> CollectAttributeValues(ICollection<SamlAttribute> attributes);
+        protected virtual SamlAdvice CreateAdvice(SecurityTokenDescriptor tokenDescriptor);
+        protected virtual SamlAssertion CreateAssertion(string issuer, SamlConditions conditions, SamlAdvice advice, IEnumerable<SamlStatement> statements);
+        protected virtual SamlAttribute CreateAttribute(Claim claim, SecurityTokenDescriptor tokenDescriptor);
+        protected virtual SamlAttributeStatement CreateAttributeStatement(SamlSubject samlSubject, ClaimsIdentity subject, SecurityTokenDescriptor tokenDescriptor);
+        protected virtual SamlAuthenticationStatement CreateAuthenticationStatement(SamlSubject samlSubject, AuthenticationInformation authInfo, SecurityTokenDescriptor tokenDescriptor);
+        protected virtual ClaimsIdentity CreateClaims(SamlSecurityToken samlSecurityToken);
+        protected virtual SamlConditions CreateConditions(Lifetime tokenLifetime, string relyingPartyAddress, SecurityTokenDescriptor tokenDescriptor);
+        protected virtual SamlSubject CreateSamlSubject(SecurityTokenDescriptor tokenDescriptor);
+        public override SecurityKeyIdentifierClause CreateSecurityTokenReference(SecurityToken token, bool attached);
+        protected virtual IEnumerable<SamlStatement> CreateStatements(SecurityTokenDescriptor tokenDescriptor);
+        public override SecurityToken CreateToken(SecurityTokenDescriptor tokenDescriptor);
+        protected virtual WindowsIdentity CreateWindowsIdentity(string upn);
+        protected virtual string CreateXmlStringFromAttributes(IEnumerable<SamlAttribute> attributes);
+        protected virtual string DenormalizeAuthenticationType(string normalizedAuthenticationType);
+        protected override void DetectReplayedToken(SecurityToken token);
+        protected virtual string FindUpn(ClaimsIdentity claimsIdentity);
+        protected virtual EncryptingCredentials GetEncryptingCredentials(SecurityTokenDescriptor tokenDescriptor);
+        protected virtual SigningCredentials GetSigningCredentials(SecurityTokenDescriptor tokenDescriptor);
+        protected virtual DateTime GetTokenReplayCacheEntryExpirationTime(SamlSecurityToken token);
+        public override string[] GetTokenTypeIdentifiers();
+        public override void LoadCustomConfiguration(XmlNodeList customConfigElements);
+        protected virtual string NormalizeAuthenticationType(string saml11AuthenticationMethod);
+        protected virtual void ProcessAttributeStatement(SamlAttributeStatement samlStatement, ClaimsIdentity subject, string issuer);
+        protected virtual void ProcessAuthenticationStatement(SamlAuthenticationStatement samlStatement, ClaimsIdentity subject, string issuer);
+        protected virtual void ProcessAuthorizationDecisionStatement(SamlAuthorizationDecisionStatement samlStatement, ClaimsIdentity subject, string issuer);
+        protected virtual void ProcessSamlSubject(SamlSubject samlSubject, ClaimsIdentity subject, string issuer);
+        protected virtual void ProcessStatement(IList<SamlStatement> statements, ClaimsIdentity subject, string issuer);
+        protected virtual SamlAction ReadAction(XmlReader reader);
+        protected virtual SamlAdvice ReadAdvice(XmlReader reader);
+        protected virtual SamlAssertion ReadAssertion(XmlReader reader);
+        protected virtual SamlAttribute ReadAttribute(XmlReader reader);
+        protected virtual SamlAttributeStatement ReadAttributeStatement(XmlReader reader);
+        protected virtual string ReadAttributeValue(XmlReader reader, SamlAttribute attribute);
+        protected virtual SamlAudienceRestrictionCondition ReadAudienceRestrictionCondition(XmlReader reader);
+        protected virtual SamlAuthenticationStatement ReadAuthenticationStatement(XmlReader reader);
+        protected virtual SamlAuthorityBinding ReadAuthorityBinding(XmlReader reader);
+        protected virtual SamlAuthorizationDecisionStatement ReadAuthorizationDecisionStatement(XmlReader reader);
+        protected virtual SamlCondition ReadCondition(XmlReader reader);
+        protected virtual SamlConditions ReadConditions(XmlReader reader);
+        protected virtual SamlDoNotCacheCondition ReadDoNotCacheCondition(XmlReader reader);
+        protected virtual SamlEvidence ReadEvidence(XmlReader reader);
+        protected virtual SecurityKeyIdentifier ReadSigningKeyInfo(XmlReader reader, SamlAssertion assertion);
+        protected virtual SamlStatement ReadStatement(XmlReader reader);
+        protected virtual SamlSubject ReadSubject(XmlReader reader);
+        protected virtual SecurityKeyIdentifier ReadSubjectKeyInfo(XmlReader reader);
+        public override SecurityToken ReadToken(XmlReader reader);
+        protected virtual SecurityToken ResolveIssuerToken(SamlAssertion assertion, SecurityTokenResolver issuerResolver);
+        protected virtual SecurityKey ResolveSubjectKeyIdentifier(SecurityKeyIdentifier subjectKeyIdentifier);
+        protected virtual void SetDelegateFromAttribute(SamlAttribute attribute, ClaimsIdentity subject, string issuer);
+        protected virtual bool TryResolveIssuerToken(SamlAssertion assertion, SecurityTokenResolver issuerResolver, out SecurityToken token);
+        protected virtual void ValidateConditions(SamlConditions conditions, bool enforceAudienceRestriction);
+        public override ReadOnlyCollection<ClaimsIdentity> ValidateToken(SecurityToken token);
+        protected virtual void WriteAction(XmlWriter writer, SamlAction action);
+        protected virtual void WriteAdvice(XmlWriter writer, SamlAdvice advice);
+        protected virtual void WriteAssertion(XmlWriter writer, SamlAssertion assertion);
+        protected virtual void WriteAttribute(XmlWriter writer, SamlAttribute attribute);
+        protected virtual void WriteAttributeStatement(XmlWriter writer, SamlAttributeStatement statement);
+        protected virtual void WriteAttributeValue(XmlWriter writer, string value, SamlAttribute attribute);
+        protected virtual void WriteAudienceRestrictionCondition(XmlWriter writer, SamlAudienceRestrictionCondition condition);
+        protected virtual void WriteAuthenticationStatement(XmlWriter writer, SamlAuthenticationStatement statement);
+        protected virtual void WriteAuthorityBinding(XmlWriter writer, SamlAuthorityBinding authorityBinding);
+        protected virtual void WriteAuthorizationDecisionStatement(XmlWriter writer, SamlAuthorizationDecisionStatement statement);
+        protected virtual void WriteCondition(XmlWriter writer, SamlCondition condition);
+        protected virtual void WriteConditions(XmlWriter writer, SamlConditions conditions);
+        protected virtual void WriteDoNotCacheCondition(XmlWriter writer, SamlDoNotCacheCondition condition);
+        protected virtual void WriteEvidence(XmlWriter writer, SamlEvidence evidence);
+        protected virtual void WriteSigningKeyInfo(XmlWriter writer, SecurityKeyIdentifier signingKeyIdentifier);
+        protected virtual void WriteStatement(XmlWriter writer, SamlStatement statement);
+        protected virtual void WriteSubject(XmlWriter writer, SamlSubject subject);
+        protected virtual void WriteSubjectKeyInfo(XmlWriter writer, SecurityKeyIdentifier subjectSki);
+        public override void WriteToken(XmlWriter writer, SecurityToken token);
+    }
+    public class SamlSecurityTokenRequirement {
+        public SamlSecurityTokenRequirement();
+        public SamlSecurityTokenRequirement(XmlElement element);
+        public X509CertificateValidator CertificateValidator { get; set; }
+        public bool MapToWindows { get; set; }
+        public string NameClaimType { get; set; }
+        public string RoleClaimType { get; set; }
+        public virtual bool ShouldEnforceAudienceRestriction(AudienceUriMode audienceUriMode, SecurityToken token);
+        public virtual void ValidateAudienceRestriction(IList<Uri> allowedAudienceUris, IList<Uri> tokenAudiences);
+    }
+    public class SamlSerializer {
+        public SamlSerializer();
+        public virtual SamlAdvice LoadAdvice(XmlDictionaryReader reader, SecurityTokenSerializer keyInfoSerializer, SecurityTokenResolver outOfBandTokenResolver);
+        public virtual SamlAssertion LoadAssertion(XmlDictionaryReader reader, SecurityTokenSerializer keyInfoSerializer, SecurityTokenResolver outOfBandTokenResolver);
+        public virtual SamlAttribute LoadAttribute(XmlDictionaryReader reader, SecurityTokenSerializer keyInfoSerializer, SecurityTokenResolver outOfBandTokenResolver);
+        public virtual SamlCondition LoadCondition(XmlDictionaryReader reader, SecurityTokenSerializer keyInfoSerializer, SecurityTokenResolver outOfBandTokenResolver);
+        public virtual SamlConditions LoadConditions(XmlDictionaryReader reader, SecurityTokenSerializer keyInfoSerializer, SecurityTokenResolver outOfBandTokenResolver);
+        public virtual SamlStatement LoadStatement(XmlDictionaryReader reader, SecurityTokenSerializer keyInfoSerializer, SecurityTokenResolver outOfBandTokenResolver);
+        public void PopulateDictionary(IXmlDictionary dictionary);
+        public virtual SamlSecurityToken ReadToken(XmlReader reader, SecurityTokenSerializer keyInfoSerializer, SecurityTokenResolver outOfBandTokenResolver);
+        public virtual void WriteToken(SamlSecurityToken token, XmlWriter writer, SecurityTokenSerializer keyInfoSerializer);
+    }
+    public abstract class SamlStatement {
+        protected SamlStatement();
+        public abstract bool IsReadOnly { get; }
+        public abstract IAuthorizationPolicy CreatePolicy(ClaimSet issuer, SamlSecurityTokenAuthenticator samlAuthenticator);
+        public abstract void MakeReadOnly();
+        public abstract void ReadXml(XmlDictionaryReader reader, SamlSerializer samlSerializer, SecurityTokenSerializer keyInfoSerializer, SecurityTokenResolver outOfBandTokenResolver);
+        public abstract void WriteXml(XmlDictionaryWriter writer, SamlSerializer samlSerializer, SecurityTokenSerializer keyInfoSerializer);
+    }
+    public class SamlSubject {
+        public SamlSubject();
+        public SamlSubject(string nameFormat, string nameQualifier, string name);
+        public SamlSubject(string nameFormat, string nameQualifier, string name, IEnumerable<string> confirmations, string confirmationData, SecurityKeyIdentifier securityKeyIdentifier);
+        public IList<string> ConfirmationMethods { get; }
+        public SecurityKey Crypto { get; set; }
+        public bool IsReadOnly { get; }
+        public SecurityKeyIdentifier KeyIdentifier { get; set; }
+        public string Name { get; set; }
+        public static string NameClaimType { get; }
+        public string NameFormat { get; set; }
+        public string NameQualifier { get; set; }
+        public string SubjectConfirmationData { get; set; }
+        public virtual ReadOnlyCollection<Claim> ExtractClaims();
+        public virtual ClaimSet ExtractSubjectKeyClaimSet(SamlSecurityTokenAuthenticator samlAuthenticator);
+        public void MakeReadOnly();
+        public virtual void ReadXml(XmlDictionaryReader reader, SamlSerializer samlSerializer, SecurityTokenSerializer keyInfoSerializer, SecurityTokenResolver outOfBandTokenResolver);
+        public virtual void WriteXml(XmlDictionaryWriter writer, SamlSerializer samlSerializer, SecurityTokenSerializer keyInfoSerializer);
+    }
+    public abstract class SamlSubjectStatement : SamlStatement {
+        protected SamlSubjectStatement();
+        protected SamlSubjectStatement(SamlSubject samlSubject);
+        public override bool IsReadOnly { get; }
+        public SamlSubject SamlSubject { get; set; }
+        protected abstract void AddClaimsToList(IList<Claim> claims);
+        public override IAuthorizationPolicy CreatePolicy(ClaimSet issuer, SamlSecurityTokenAuthenticator samlAuthenticator);
+        public override void MakeReadOnly();
+        protected void SetSubject(SamlSubject samlSubject);
+    }
+    public static class SecurityAlgorithms {
+        public const string Aes128Encryption = "http://www.w3.org/2001/04/xmlenc#aes128-cbc";
+        public const string Aes128KeyWrap = "http://www.w3.org/2001/04/xmlenc#kw-aes128";
+        public const string Aes192Encryption = "http://www.w3.org/2001/04/xmlenc#aes192-cbc";
+        public const string Aes192KeyWrap = "http://www.w3.org/2001/04/xmlenc#kw-aes192";
+        public const string Aes256Encryption = "http://www.w3.org/2001/04/xmlenc#aes256-cbc";
+        public const string Aes256KeyWrap = "http://www.w3.org/2001/04/xmlenc#kw-aes256";
+        public const string DesEncryption = "http://www.w3.org/2001/04/xmlenc#des-cbc";
+        public const string DsaSha1Signature = "http://www.w3.org/2000/09/xmldsig#dsa-sha1";
+        public const string ExclusiveC14n = "http://www.w3.org/2001/10/xml-exc-c14n#";
+        public const string ExclusiveC14nWithComments = "http://www.w3.org/2001/10/xml-exc-c14n#WithComments";
+        public const string HmacSha1Signature = "http://www.w3.org/2000/09/xmldsig#hmac-sha1";
+        public const string HmacSha256Signature = "http://www.w3.org/2001/04/xmldsig-more#hmac-sha256";
+        public const string Psha1KeyDerivation = "http://schemas.xmlsoap.org/ws/2005/02/sc/dk/p_sha1";
+        public const string Psha1KeyDerivationDec2005 = "http://docs.oasis-open.org/ws-sx/ws-secureconversation/200512/dk/p_sha1";
+        public const string Ripemd160Digest = "http://www.w3.org/2001/04/xmlenc#ripemd160";
+        public const string RsaOaepKeyWrap = "http://www.w3.org/2001/04/xmlenc#rsa-oaep-mgf1p";
+        public const string RsaSha1Signature = "http://www.w3.org/2000/09/xmldsig#rsa-sha1";
+        public const string RsaSha256Signature = "http://www.w3.org/2001/04/xmldsig-more#rsa-sha256";
+        public const string RsaV15KeyWrap = "http://www.w3.org/2001/04/xmlenc#rsa-1_5";
+        public const string Sha1Digest = "http://www.w3.org/2000/09/xmldsig#sha1";
+        public const string Sha256Digest = "http://www.w3.org/2001/04/xmlenc#sha256";
+        public const string Sha512Digest = "http://www.w3.org/2001/04/xmlenc#sha512";
+        public const string StrTransform = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-soap-message-security-1.0#STR-Transform";
+        public const string TlsSspiKeyWrap = "http://schemas.xmlsoap.org/2005/02/trust/tlsnego#TLS_Wrap";
+        public const string TripleDesEncryption = "http://www.w3.org/2001/04/xmlenc#tripledes-cbc";
+        public const string TripleDesKeyWrap = "http://www.w3.org/2001/04/xmlenc#kw-tripledes";
+        public const string WindowsSspiKeyWrap = "http://schemas.xmlsoap.org/2005/02/trust/spnego#GSS_Wrap";
+    }
+    public abstract class SecurityKey {
+        protected SecurityKey();
+        public abstract int KeySize { get; }
+        public abstract byte[] DecryptKey(string algorithm, byte[] keyData);
+        public abstract byte[] EncryptKey(string algorithm, byte[] keyData);
+        public abstract bool IsAsymmetricAlgorithm(string algorithm);
+        public abstract bool IsSupportedAlgorithm(string algorithm);
+        public abstract bool IsSymmetricAlgorithm(string algorithm);
+    }
+    public class SecurityKeyElement : SecurityKey {
+        public SecurityKeyElement(SecurityKeyIdentifier securityKeyIdentifier, SecurityTokenResolver securityTokenResolver);
+        public SecurityKeyElement(SecurityKeyIdentifierClause securityKeyIdentifierClause, SecurityTokenResolver securityTokenResolver);
+        public override int KeySize { get; }
+        public override byte[] DecryptKey(string algorithm, byte[] keyData);
+        public override byte[] EncryptKey(string algorithm, byte[] keyData);
+        public override bool IsAsymmetricAlgorithm(string algorithm);
+        public override bool IsSupportedAlgorithm(string algorithm);
+        public override bool IsSymmetricAlgorithm(string algorithm);
+    }
+    public class SecurityKeyIdentifier : IEnumerable, IEnumerable<SecurityKeyIdentifierClause> {
+        public SecurityKeyIdentifier();
+        public SecurityKeyIdentifier(params SecurityKeyIdentifierClause[] clauses);
+        public bool CanCreateKey { get; }
+        public int Count { get; }
+        public bool IsReadOnly { get; }
+        public SecurityKeyIdentifierClause this[int index] { get; }
+        public void Add(SecurityKeyIdentifierClause clause);
+        public SecurityKey CreateKey();
+        public TClause Find<TClause>() where TClause : SecurityKeyIdentifierClause;
+        public IEnumerator<SecurityKeyIdentifierClause> GetEnumerator();
+        public void MakeReadOnly();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        public override string ToString();
+        public bool TryFind<TClause>(out TClause clause) where TClause : SecurityKeyIdentifierClause;
+    }
+    public abstract class SecurityKeyIdentifierClause {
+        protected SecurityKeyIdentifierClause(string clauseType);
+        protected SecurityKeyIdentifierClause(string clauseType, byte[] nonce, int length);
+        public virtual bool CanCreateKey { get; }
+        public string ClauseType { get; }
+        public int DerivationLength { get; }
+        public string Id { get; set; }
+        public virtual SecurityKey CreateKey();
+        public byte[] GetDerivationNonce();
+        public virtual bool Matches(SecurityKeyIdentifierClause keyIdentifierClause);
+    }
+    public abstract class SecurityKeyIdentifierClauseSerializer {
+        protected SecurityKeyIdentifierClauseSerializer();
+        public abstract bool CanReadKeyIdentifierClause(XmlReader reader);
+        public abstract bool CanWriteKeyIdentifierClause(SecurityKeyIdentifierClause securityKeyIdentifierClause);
+        public abstract SecurityKeyIdentifierClause ReadKeyIdentifierClause(XmlReader reader);
+        public abstract void WriteKeyIdentifierClause(XmlWriter writer, SecurityKeyIdentifierClause securityKeyIdentifierClause);
+    }
+    public enum SecurityKeyType {
+        AsymmetricKey = 1,
+        BearerKey = 2,
+        SymmetricKey = 0,
+    }
+    public enum SecurityKeyUsage {
+        Exchange = 0,
+        Signature = 1,
+    }
+    public abstract class SecurityToken {
+        protected SecurityToken();
+        public abstract string Id { get; }
+        public abstract ReadOnlyCollection<SecurityKey> SecurityKeys { get; }
+        public abstract DateTime ValidFrom { get; }
+        public abstract DateTime ValidTo { get; }
+        public virtual bool CanCreateKeyIdentifierClause<T>() where T : SecurityKeyIdentifierClause;
+        public virtual T CreateKeyIdentifierClause<T>() where T : SecurityKeyIdentifierClause;
+        public virtual bool MatchesKeyIdentifierClause(SecurityKeyIdentifierClause keyIdentifierClause);
+        public virtual SecurityKey ResolveKeyIdentifierClause(SecurityKeyIdentifierClause keyIdentifierClause);
+    }
+    public class SecurityTokenDescriptor {
+        public SecurityTokenDescriptor();
+        public string AppliesToAddress { get; set; }
+        public SecurityKeyIdentifierClause AttachedReference { get; set; }
+        public AuthenticationInformation AuthenticationInfo { get; set; }
+        public EncryptingCredentials EncryptingCredentials { get; set; }
+        public Lifetime Lifetime { get; set; }
+        public ProofDescriptor Proof { get; set; }
+        public Dictionary<string, object> Properties { get; }
+        public string ReplyToAddress { get; set; }
+        public SigningCredentials SigningCredentials { get; set; }
+        public ClaimsIdentity Subject { get; set; }
+        public SecurityToken Token { get; set; }
+        public string TokenIssuerName { get; set; }
+        public string TokenType { get; set; }
+        public SecurityKeyIdentifierClause UnattachedReference { get; set; }
+        public void AddAuthenticationClaims(string authType);
+        public void AddAuthenticationClaims(string authType, DateTime time);
+        public virtual void ApplyTo(RequestSecurityTokenResponse response);
+    }
+    public class SecurityTokenElement {
+        public SecurityTokenElement(SecurityToken securityToken);
+        public SecurityTokenElement(XmlElement securityTokenXml, SecurityTokenHandlerCollection securityTokenHandlers);
+        public XmlElement SecurityTokenXml { get; }
+        public ReadOnlyCollection<ClaimsIdentity> GetIdentities();
+        public SecurityToken GetSecurityToken();
+        protected virtual SecurityToken ReadSecurityToken(XmlElement securityTokenXml, SecurityTokenHandlerCollection securityTokenHandlers);
+        protected virtual ReadOnlyCollection<ClaimsIdentity> ValidateToken(XmlElement securityTokenXml, SecurityTokenHandlerCollection securityTokenHandlers);
+    }
+    public class SecurityTokenException : SystemException {
+        public SecurityTokenException();
+        protected SecurityTokenException(SerializationInfo info, StreamingContext context);
+        public SecurityTokenException(string message);
+        public SecurityTokenException(string message, Exception innerException);
+    }
+    public class SecurityTokenExpiredException : SecurityTokenValidationException {
+        public SecurityTokenExpiredException();
+        protected SecurityTokenExpiredException(SerializationInfo info, StreamingContext context);
+        public SecurityTokenExpiredException(string message);
+        public SecurityTokenExpiredException(string message, Exception inner);
+    }
+    public abstract class SecurityTokenHandler : ICustomIdentityConfiguration {
+        protected SecurityTokenHandler();
+        public virtual bool CanValidateToken { get; }
+        public virtual bool CanWriteToken { get; }
+        public SecurityTokenHandlerConfiguration Configuration { get; set; }
+        public SecurityTokenHandlerCollection ContainingCollection { get; internal set; }
+        public abstract Type TokenType { get; }
+        public virtual bool CanReadKeyIdentifierClause(XmlReader reader);
+        public virtual bool CanReadToken(string tokenString);
+        public virtual bool CanReadToken(XmlReader reader);
+        public virtual bool CanWriteKeyIdentifierClause(SecurityKeyIdentifierClause securityKeyIdentifierClause);
+        public virtual SecurityKeyIdentifierClause CreateSecurityTokenReference(SecurityToken token, bool attached);
+        public virtual SecurityToken CreateToken(SecurityTokenDescriptor tokenDescriptor);
+        protected virtual void DetectReplayedToken(SecurityToken token);
+        public abstract string[] GetTokenTypeIdentifiers();
+        public virtual void LoadCustomConfiguration(XmlNodeList nodelist);
+        public virtual SecurityKeyIdentifierClause ReadKeyIdentifierClause(XmlReader reader);
+        public virtual SecurityToken ReadToken(string tokenString);
+        public virtual SecurityToken ReadToken(XmlReader reader);
+        public virtual SecurityToken ReadToken(XmlReader reader, SecurityTokenResolver tokenResolver);
+        protected void TraceTokenValidationFailure(SecurityToken token, string errorMessage);
+        protected void TraceTokenValidationSuccess(SecurityToken token);
+        public virtual ReadOnlyCollection<ClaimsIdentity> ValidateToken(SecurityToken token);
+        public virtual void WriteKeyIdentifierClause(XmlWriter writer, SecurityKeyIdentifierClause securityKeyIdentifierClause);
+        public virtual string WriteToken(SecurityToken token);
+        public virtual void WriteToken(XmlWriter writer, SecurityToken token);
+    }
+    public class SecurityTokenHandlerCollection : Collection<SecurityTokenHandler> {
+        public SecurityTokenHandlerCollection();
+        public SecurityTokenHandlerCollection(IEnumerable<SecurityTokenHandler> handlers);
+        public SecurityTokenHandlerCollection(IEnumerable<SecurityTokenHandler> handlers, SecurityTokenHandlerConfiguration configuration);
+        public SecurityTokenHandlerCollection(SecurityTokenHandlerConfiguration configuration);
+        public SecurityTokenHandlerConfiguration Configuration { get; }
+        public SecurityTokenHandler this[SecurityToken token] { get; }
+        public SecurityTokenHandler this[string tokenTypeIdentifier] { get; }
+        public SecurityTokenHandler this[Type tokenType] { get; }
+        public IEnumerable<string> TokenTypeIdentifiers { get; }
+        public IEnumerable<Type> TokenTypes { get; }
+        public void AddOrReplace(SecurityTokenHandler handler);
+        public bool CanReadKeyIdentifierClause(XmlReader reader);
+        protected virtual bool CanReadKeyIdentifierClauseCore(XmlReader reader);
+        public bool CanReadToken(string tokenString);
+        public bool CanReadToken(XmlReader reader);
+        public bool CanWriteToken(SecurityToken token);
+        protected override void ClearItems();
+        public static SecurityTokenHandlerCollection CreateDefaultSecurityTokenHandlerCollection();
+        public static SecurityTokenHandlerCollection CreateDefaultSecurityTokenHandlerCollection(SecurityTokenHandlerConfiguration configuration);
+        public SecurityToken CreateToken(SecurityTokenDescriptor tokenDescriptor);
+        protected override void InsertItem(int index, SecurityTokenHandler item);
+        public SecurityKeyIdentifierClause ReadKeyIdentifierClause(XmlReader reader);
+        protected virtual SecurityKeyIdentifierClause ReadKeyIdentifierClauseCore(XmlReader reader);
+        public SecurityToken ReadToken(string tokenString);
+        public SecurityToken ReadToken(XmlReader reader);
+        protected override void RemoveItem(int index);
+        protected override void SetItem(int index, SecurityTokenHandler item);
+        public ReadOnlyCollection<ClaimsIdentity> ValidateToken(SecurityToken token);
+        public void WriteKeyIdentifierClause(XmlWriter writer, SecurityKeyIdentifierClause keyIdentifierClause);
+        protected virtual void WriteKeyIdentifierClauseCore(XmlWriter writer, SecurityKeyIdentifierClause keyIdentifierClause);
+        public string WriteToken(SecurityToken token);
+        public void WriteToken(XmlWriter writer, SecurityToken token);
+    }
+    public class SecurityTokenHandlerCollectionManager {
+        public SecurityTokenHandlerCollectionManager(string serviceName);
+        public int Count { get; }
+        public IEnumerable<SecurityTokenHandlerCollection> SecurityTokenHandlerCollections { get; }
+        public string ServiceName { get; }
+        public SecurityTokenHandlerCollection this[string usage] { get; set; }
+        public bool ContainsKey(string usage);
+        public static SecurityTokenHandlerCollectionManager CreateDefaultSecurityTokenHandlerCollectionManager();
+        public static SecurityTokenHandlerCollectionManager CreateEmptySecurityTokenHandlerCollectionManager();
+        public static class Usage {
+            public const string ActAs = "ActAs";
+            public const string Default = "";
+            public const string OnBehalfOf = "OnBehalfOf";
+        }
+    }
+    public class SecurityTokenHandlerConfiguration {
+        public static readonly bool DefaultDetectReplayedTokens;
+        public static readonly bool DefaultSaveBootstrapContext;
+        public static readonly SecurityTokenResolver DefaultIssuerTokenResolver;
+        public static readonly X509CertificateValidator DefaultCertificateValidator;
+        public static readonly IssuerNameRegistry DefaultIssuerNameRegistry;
+        public static readonly StoreLocation DefaultTrustedStoreLocation;
+        public static readonly X509RevocationMode DefaultRevocationMode;
+        public static readonly X509CertificateValidationMode DefaultCertificateValidationMode;
+        public static readonly TimeSpan DefaultMaxClockSkew;
+        public static readonly TimeSpan DefaultTokenReplayCacheExpirationPeriod;
+        public SecurityTokenHandlerConfiguration();
+        public AudienceRestriction AudienceRestriction { get; set; }
+        public IdentityModelCaches Caches { get; set; }
+        public X509CertificateValidationMode CertificateValidationMode { get; set; }
+        public X509CertificateValidator CertificateValidator { get; set; }
+        public bool DetectReplayedTokens { get; set; }
+        public IssuerNameRegistry IssuerNameRegistry { get; set; }
+        public SecurityTokenResolver IssuerTokenResolver { get; set; }
+        public TimeSpan MaxClockSkew { get; set; }
+        public X509RevocationMode RevocationMode { get; set; }
+        public bool SaveBootstrapContext { get; set; }
+        public SecurityTokenResolver ServiceTokenResolver { get; set; }
+        public TimeSpan TokenReplayCacheExpirationPeriod { get; set; }
+        public StoreLocation TrustedStoreLocation { get; set; }
+    }
+    public class SecurityTokenNotYetValidException : SecurityTokenValidationException {
+        public SecurityTokenNotYetValidException();
+        protected SecurityTokenNotYetValidException(SerializationInfo info, StreamingContext context);
+        public SecurityTokenNotYetValidException(string message);
+        public SecurityTokenNotYetValidException(string message, Exception inner);
+    }
+    public class SecurityTokenReplayDetectedException : SecurityTokenValidationException {
+        public SecurityTokenReplayDetectedException();
+        protected SecurityTokenReplayDetectedException(SerializationInfo info, StreamingContext context);
+        public SecurityTokenReplayDetectedException(string message);
+        public SecurityTokenReplayDetectedException(string message, Exception inner);
+    }
+    public static class SecurityTokenTypes {
+        public static string Kerberos { get; }
+        public static string Rsa { get; }
+        public static string Saml { get; }
+        public static string UserName { get; }
+        public static string X509Certificate { get; }
+    }
+    public class SecurityTokenValidationException : SecurityTokenException {
+        public SecurityTokenValidationException();
+        protected SecurityTokenValidationException(SerializationInfo info, StreamingContext context);
+        public SecurityTokenValidationException(string message);
+        public SecurityTokenValidationException(string message, Exception innerException);
+    }
+    public class SessionSecurityToken : SecurityToken, ISerializable {
+        protected SessionSecurityToken(SerializationInfo info, StreamingContext context);
+        public SessionSecurityToken(ClaimsPrincipal claimsPrincipal);
+        public SessionSecurityToken(ClaimsPrincipal claimsPrincipal, string context);
+        public SessionSecurityToken(ClaimsPrincipal claimsPrincipal, string context, Nullable<DateTime> validFrom, Nullable<DateTime> validTo);
+        public SessionSecurityToken(ClaimsPrincipal claimsPrincipal, string context, string endpointId, Nullable<DateTime> validFrom, Nullable<DateTime> validTo);
+        public SessionSecurityToken(ClaimsPrincipal claimsPrincipal, TimeSpan lifetime);
+        public SessionSecurityToken(ClaimsPrincipal claimsPrincipal, UniqueId contextId, string context, string endpointId, DateTime validFrom, TimeSpan lifetime, SymmetricSecurityKey key);
+        public SessionSecurityToken(ClaimsPrincipal claimsPrincipal, UniqueId contextId, string context, string endpointId, Nullable<DateTime> validFrom, Nullable<DateTime> validTo, SymmetricSecurityKey key);
+        public SessionSecurityToken(ClaimsPrincipal claimsPrincipal, UniqueId contextId, string context, string endpointId, TimeSpan lifetime, SymmetricSecurityKey key);
+        public ClaimsPrincipal ClaimsPrincipal { get; }
+        public string Context { get; }
+        public UniqueId ContextId { get; }
+        public string EndpointId { get; }
+        public override string Id { get; }
+        public bool IsPersistent { get; set; }
+        public bool IsReferenceMode { get; set; }
+        public DateTime KeyEffectiveTime { get; }
+        public DateTime KeyExpirationTime { get; }
+        public UniqueId KeyGeneration { get; }
+        public Uri SecureConversationVersion { get; }
+        public override ReadOnlyCollection<SecurityKey> SecurityKeys { get; }
+        public override DateTime ValidFrom { get; }
+        public override DateTime ValidTo { get; }
+        public virtual void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public abstract class SessionSecurityTokenCache : ICustomIdentityConfiguration {
+        protected SessionSecurityTokenCache();
+        public abstract void AddOrUpdate(SessionSecurityTokenCacheKey key, SessionSecurityToken value, DateTime expiryTime);
+        public abstract SessionSecurityToken Get(SessionSecurityTokenCacheKey key);
+        public abstract IEnumerable<SessionSecurityToken> GetAll(string endpointId, UniqueId contextId);
+        public virtual void LoadCustomConfiguration(XmlNodeList nodelist);
+        public abstract void Remove(SessionSecurityTokenCacheKey key);
+        public abstract void RemoveAll(string endpointId);
+        public abstract void RemoveAll(string endpointId, UniqueId contextId);
+    }
+    public class SessionSecurityTokenCacheKey {
+        public SessionSecurityTokenCacheKey(string endpointId, UniqueId contextId, UniqueId keyGeneration);
+        public UniqueId ContextId { get; }
+        public string EndpointId { get; }
+        public bool IgnoreKeyGeneration { get; set; }
+        public UniqueId KeyGeneration { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public static bool operator ==(SessionSecurityTokenCacheKey first, SessionSecurityTokenCacheKey second);
+        public static bool operator !=(SessionSecurityTokenCacheKey first, SessionSecurityTokenCacheKey second);
+        public override string ToString();
+    }
+    public class SessionSecurityTokenHandler : SecurityTokenHandler {
+        public static readonly ReadOnlyCollection<CookieTransform> DefaultCookieTransforms;
+        public static readonly TimeSpan DefaultLifetime;
+        public SessionSecurityTokenHandler();
+        public SessionSecurityTokenHandler(ReadOnlyCollection<CookieTransform> transforms);
+        public SessionSecurityTokenHandler(ReadOnlyCollection<CookieTransform> transforms, TimeSpan tokenLifetime);
+        public override bool CanValidateToken { get; }
+        public override bool CanWriteToken { get; }
+        public virtual string CookieElementName { get; }
+        public virtual string CookieNamespace { get; }
+        public static TimeSpan DefaultTokenLifetime { get; }
+        public virtual TimeSpan TokenLifetime { get; set; }
+        public override Type TokenType { get; }
+        public ReadOnlyCollection<CookieTransform> Transforms { get; }
+        protected virtual byte[] ApplyTransforms(byte[] cookie, bool outbound);
+        public override bool CanReadToken(XmlReader reader);
+        public virtual SessionSecurityToken CreateSessionSecurityToken(ClaimsPrincipal principal, string context, string endpointId, DateTime validFrom, DateTime validTo);
+        public override SecurityToken CreateToken(SecurityTokenDescriptor tokenDescriptor);
+        public override string[] GetTokenTypeIdentifiers();
+        public override void LoadCustomConfiguration(XmlNodeList customConfigElements);
+        public virtual SecurityToken ReadToken(byte[] token, SecurityTokenResolver tokenResolver);
+        public override SecurityToken ReadToken(XmlReader reader);
+        public override SecurityToken ReadToken(XmlReader reader, SecurityTokenResolver tokenResolver);
+        protected void SetTransforms(IEnumerable<CookieTransform> transforms);
+        protected virtual void ValidateSession(SessionSecurityToken securityToken);
+        public override ReadOnlyCollection<ClaimsIdentity> ValidateToken(SecurityToken token);
+        public virtual ReadOnlyCollection<ClaimsIdentity> ValidateToken(SessionSecurityToken token, string endpointId);
+        public virtual byte[] WriteToken(SessionSecurityToken sessionToken);
+        public override void WriteToken(XmlWriter writer, SecurityToken token);
+    }
+    public class SigningCredentials {
+        public SigningCredentials(SecurityKey signingKey, string signatureAlgorithm, string digestAlgorithm);
+        public SigningCredentials(SecurityKey signingKey, string signatureAlgorithm, string digestAlgorithm, SecurityKeyIdentifier signingKeyIdentifier);
+        public string DigestAlgorithm { get; }
+        public string SignatureAlgorithm { get; }
+        public SecurityKey SigningKey { get; }
+        public SecurityKeyIdentifier SigningKeyIdentifier { get; }
+    }
+    public class SymmetricProofDescriptor : ProofDescriptor {
+        public SymmetricProofDescriptor(byte[] key, EncryptingCredentials targetWrappingCredentials);
+        public SymmetricProofDescriptor(EncryptingCredentials targetWrappingCredentials);
+        public SymmetricProofDescriptor(int keySizeInBits, EncryptingCredentials targetWrappingCredentials);
+        public SymmetricProofDescriptor(int keySizeInBits, EncryptingCredentials targetWrappingCredentials, EncryptingCredentials requestorWrappingCredentials);
+        public SymmetricProofDescriptor(int keySizeInBits, EncryptingCredentials targetWrappingCredentials, EncryptingCredentials requestorWrappingCredentials, byte[] sourceEntropy);
+        public SymmetricProofDescriptor(int keySizeInBits, EncryptingCredentials targetWrappingCredentials, EncryptingCredentials requestorWrappingCredentials, byte[] sourceEntropy, string encryptWith);
+        public SymmetricProofDescriptor(int keySizeInBits, EncryptingCredentials targetWrappingCredentials, EncryptingCredentials requestorWrappingCredentials, string encryptWith);
+        public override SecurityKeyIdentifier KeyIdentifier { get; }
+        protected EncryptingCredentials RequestorEncryptingCredentials { get; }
+        protected EncryptingCredentials TargetEncryptingCredentials { get; }
+        public override void ApplyTo(RequestSecurityTokenResponse response);
+        public byte[] GetKeyBytes();
+        protected byte[] GetSourceEntropy();
+        protected byte[] GetTargetEntropy();
+    }
+    public abstract class SymmetricSecurityKey : SecurityKey {
+        protected SymmetricSecurityKey();
+        public abstract byte[] GenerateDerivedKey(string algorithm, byte[] label, byte[] nonce, int derivedKeyLength, int offset);
+        public abstract ICryptoTransform GetDecryptionTransform(string algorithm, byte[] iv);
+        public abstract ICryptoTransform GetEncryptionTransform(string algorithm, byte[] iv);
+        public abstract int GetIVSize(string algorithm);
+        public abstract KeyedHashAlgorithm GetKeyedHashAlgorithm(string algorithm);
+        public abstract SymmetricAlgorithm GetSymmetricAlgorithm(string algorithm);
+        public abstract byte[] GetSymmetricKey();
+    }
+    public abstract class TokenReplayCache : ICustomIdentityConfiguration {
+        protected TokenReplayCache();
+        public abstract void AddOrUpdate(string key, SecurityToken securityToken, DateTime expirationTime);
+        public abstract bool Contains(string key);
+        public abstract SecurityToken Get(string key);
+        public virtual void LoadCustomConfiguration(XmlNodeList nodelist);
+        public abstract void Remove(string key);
+    }
+    public class UserNameSecurityToken : SecurityToken {
+        public UserNameSecurityToken(string userName, string password);
+        public UserNameSecurityToken(string userName, string password, string id);
+        public override string Id { get; }
+        public string Password { get; }
+        public override ReadOnlyCollection<SecurityKey> SecurityKeys { get; }
+        public string UserName { get; }
+        public override DateTime ValidFrom { get; }
+        public override DateTime ValidTo { get; }
+    }
+    public abstract class UserNameSecurityTokenHandler : SecurityTokenHandler {
+        protected UserNameSecurityTokenHandler();
+        public override bool CanWriteToken { get; }
+        public virtual bool RetainPassword { get; set; }
+        public override Type TokenType { get; }
+        public override bool CanReadToken(XmlReader reader);
+        public override string[] GetTokenTypeIdentifiers();
+        public override SecurityToken ReadToken(XmlReader reader);
+        public override void WriteToken(XmlWriter writer, SecurityToken token);
+    }
+    public class WindowsSecurityToken : SecurityToken, IDisposable {
+        protected WindowsSecurityToken();
+        public WindowsSecurityToken(WindowsIdentity windowsIdentity);
+        public WindowsSecurityToken(WindowsIdentity windowsIdentity, string id);
+        public WindowsSecurityToken(WindowsIdentity windowsIdentity, string id, string authenticationType);
+        public string AuthenticationType { get; }
+        public override string Id { get; }
+        public override ReadOnlyCollection<SecurityKey> SecurityKeys { get; }
+        public override DateTime ValidFrom { get; }
+        public override DateTime ValidTo { get; }
+        public virtual WindowsIdentity WindowsIdentity { get; }
+        public virtual void Dispose();
+        protected void Initialize(string id, DateTime effectiveTime, DateTime expirationTime, WindowsIdentity windowsIdentity, bool clone);
+        protected void Initialize(string id, string authenticationType, DateTime effectiveTime, DateTime expirationTime, WindowsIdentity windowsIdentity, bool clone);
+        protected void ThrowIfDisposed();
+    }
+    public class WindowsUserNameSecurityTokenHandler : UserNameSecurityTokenHandler {
+        public WindowsUserNameSecurityTokenHandler();
+        public override bool CanValidateToken { get; }
+        public override ReadOnlyCollection<ClaimsIdentity> ValidateToken(SecurityToken token);
+    }
+    public class X509AsymmetricSecurityKey : AsymmetricSecurityKey {
+        public X509AsymmetricSecurityKey(X509Certificate2 certificate);
+        public override int KeySize { get; }
+        public override byte[] DecryptKey(string algorithm, byte[] keyData);
+        public override byte[] EncryptKey(string algorithm, byte[] keyData);
+        public override AsymmetricAlgorithm GetAsymmetricAlgorithm(string algorithm, bool privateKey);
+        public override HashAlgorithm GetHashAlgorithmForSignature(string algorithm);
+        public override AsymmetricSignatureDeformatter GetSignatureDeformatter(string algorithm);
+        public override AsymmetricSignatureFormatter GetSignatureFormatter(string algorithm);
+        public override bool HasPrivateKey();
+        public override bool IsAsymmetricAlgorithm(string algorithm);
+        public override bool IsSupportedAlgorithm(string algorithm);
+        public override bool IsSymmetricAlgorithm(string algorithm);
+    }
+    public class X509CertificateStoreTokenResolver : SecurityTokenResolver {
+        public X509CertificateStoreTokenResolver();
+        public X509CertificateStoreTokenResolver(StoreName storeName, StoreLocation storeLocation);
+        public X509CertificateStoreTokenResolver(string storeName, StoreLocation storeLocation);
+        public StoreLocation StoreLocation { get; }
+        public string StoreName { get; }
+        protected override bool TryResolveSecurityKeyCore(SecurityKeyIdentifierClause keyIdentifierClause, out SecurityKey key);
+        protected override bool TryResolveTokenCore(SecurityKeyIdentifier keyIdentifier, out SecurityToken token);
+        protected override bool TryResolveTokenCore(SecurityKeyIdentifierClause keyIdentifierClause, out SecurityToken token);
+    }
+    public class X509DataSecurityKeyIdentifierClauseSerializer : SecurityKeyIdentifierClauseSerializer {
+        public X509DataSecurityKeyIdentifierClauseSerializer();
+        public override bool CanReadKeyIdentifierClause(XmlReader reader);
+        public override bool CanWriteKeyIdentifierClause(SecurityKeyIdentifierClause securityKeyIdentifierClause);
+        public override SecurityKeyIdentifierClause ReadKeyIdentifierClause(XmlReader reader);
+        public override void WriteKeyIdentifierClause(XmlWriter writer, SecurityKeyIdentifierClause securityKeyIdentifierClause);
+    }
+    public class X509EncryptingCredentials : EncryptingCredentials {
+        public X509EncryptingCredentials(X509Certificate2 certificate);
+        public X509EncryptingCredentials(X509Certificate2 certificate, SecurityKeyIdentifier ski);
+        public X509EncryptingCredentials(X509Certificate2 certificate, SecurityKeyIdentifier ski, string keyWrappingAlgorithm);
+        public X509EncryptingCredentials(X509Certificate2 certificate, string keyWrappingAlgorithm);
+        public X509Certificate2 Certificate { get; }
+    }
+    public class X509IssuerSerialKeyIdentifierClause : SecurityKeyIdentifierClause {
+        public X509IssuerSerialKeyIdentifierClause(X509Certificate2 certificate);
+        public X509IssuerSerialKeyIdentifierClause(string issuerName, string issuerSerialNumber);
+        public string IssuerName { get; }
+        public string IssuerSerialNumber { get; }
+        public override bool Matches(SecurityKeyIdentifierClause keyIdentifierClause);
+        public bool Matches(X509Certificate2 certificate);
+        public bool Matches(string issuerName, string issuerSerialNumber);
+        public override string ToString();
+    }
+    public class X509NTAuthChainTrustValidator : X509CertificateValidator {
+        public X509NTAuthChainTrustValidator();
+        public X509NTAuthChainTrustValidator(bool useMachineContext, X509ChainPolicy chainPolicy);
+        public override void Validate(X509Certificate2 certificate);
+    }
+    public class X509RawDataKeyIdentifierClause : BinaryKeyIdentifierClause {
+        public X509RawDataKeyIdentifierClause(byte[] certificateRawData);
+        public X509RawDataKeyIdentifierClause(X509Certificate2 certificate);
+        public override bool CanCreateKey { get; }
+        public override SecurityKey CreateKey();
+        public byte[] GetX509RawData();
+        public bool Matches(X509Certificate2 certificate);
+        public override string ToString();
+    }
+    public class X509SecurityToken : SecurityToken, IDisposable {
+        public X509SecurityToken(X509Certificate2 certificate);
+        public X509SecurityToken(X509Certificate2 certificate, string id);
+        public X509Certificate2 Certificate { get; }
+        public override string Id { get; }
+        public override ReadOnlyCollection<SecurityKey> SecurityKeys { get; }
+        public override DateTime ValidFrom { get; }
+        public override DateTime ValidTo { get; }
+        public override bool CanCreateKeyIdentifierClause<T>();
+        public override T CreateKeyIdentifierClause<T>();
+        public virtual void Dispose();
+        public override bool MatchesKeyIdentifierClause(SecurityKeyIdentifierClause keyIdentifierClause);
+        protected void ThrowIfDisposed();
+    }
+    public class X509SecurityTokenHandler : SecurityTokenHandler {
+        public X509SecurityTokenHandler();
+        public X509SecurityTokenHandler(bool mapToWindows);
+        public X509SecurityTokenHandler(bool mapToWindows, X509CertificateValidator certificateValidator);
+        public X509SecurityTokenHandler(X509CertificateValidator certificateValidator);
+        public override bool CanValidateToken { get; }
+        public override bool CanWriteToken { get; }
+        public X509CertificateValidator CertificateValidator { get; set; }
+        public bool MapToWindows { get; set; }
+        public override Type TokenType { get; }
+        public bool WriteXmlDSigDefinedClauseTypes { get; set; }
+        public X509NTAuthChainTrustValidator X509NTAuthChainTrustValidator { get; set; }
+        public override bool CanReadKeyIdentifierClause(XmlReader reader);
+        public override bool CanReadToken(XmlReader reader);
+        public override bool CanWriteKeyIdentifierClause(SecurityKeyIdentifierClause securityKeyIdentifierClause);
+        public override string[] GetTokenTypeIdentifiers();
+        public override void LoadCustomConfiguration(XmlNodeList customConfigElements);
+        public override SecurityKeyIdentifierClause ReadKeyIdentifierClause(XmlReader reader);
+        public override SecurityToken ReadToken(XmlReader reader);
+        public override ReadOnlyCollection<ClaimsIdentity> ValidateToken(SecurityToken token);
+        public override void WriteKeyIdentifierClause(XmlWriter writer, SecurityKeyIdentifierClause securityKeyIdentifierClause);
+        public override void WriteToken(XmlWriter writer, SecurityToken token);
+    }
+    public class X509SigningCredentials : SigningCredentials {
+        public X509SigningCredentials(X509Certificate2 certificate);
+        public X509SigningCredentials(X509Certificate2 certificate, SecurityKeyIdentifier ski);
+        public X509SigningCredentials(X509Certificate2 certificate, SecurityKeyIdentifier ski, string signatureAlgorithm, string digestAlgorithm);
+        public X509SigningCredentials(X509Certificate2 certificate, string signatureAlgorithm, string digestAlgorithm);
+        public X509Certificate2 Certificate { get; }
+    }
+    public class X509SubjectKeyIdentifierClause : BinaryKeyIdentifierClause {
+        public X509SubjectKeyIdentifierClause(byte[] ski);
+        public static bool CanCreateFrom(X509Certificate2 certificate);
+        public byte[] GetX509SubjectKeyIdentifier();
+        public bool Matches(X509Certificate2 certificate);
+        public override string ToString();
+        public static bool TryCreateFrom(X509Certificate2 certificate, out X509SubjectKeyIdentifierClause keyIdentifierClause);
+    }
+    public class X509ThumbprintKeyIdentifierClause : BinaryKeyIdentifierClause {
+        public X509ThumbprintKeyIdentifierClause(byte[] thumbprint);
+        public X509ThumbprintKeyIdentifierClause(X509Certificate2 certificate);
+        public byte[] GetX509Thumbprint();
+        public bool Matches(X509Certificate2 certificate);
+        public override string ToString();
+    }
+    public class X509WindowsSecurityToken : X509SecurityToken {
+        public X509WindowsSecurityToken(X509Certificate2 certificate, WindowsIdentity windowsIdentity);
+        public X509WindowsSecurityToken(X509Certificate2 certificate, WindowsIdentity windowsIdentity, string id);
+        public X509WindowsSecurityToken(X509Certificate2 certificate, WindowsIdentity windowsIdentity, string authenticationType, string id);
+        public string AuthenticationType { get; }
+        public WindowsIdentity WindowsIdentity { get; }
+        public override void Dispose();
+    }
+}
```

