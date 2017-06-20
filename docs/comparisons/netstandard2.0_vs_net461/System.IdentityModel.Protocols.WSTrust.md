# System.IdentityModel.Protocols.WSTrust

``` diff
+namespace System.IdentityModel.Protocols.WSTrust {
+    public class AdditionalContext {
+        public AdditionalContext();
+        public AdditionalContext(IEnumerable<ContextItem> items);
+        public IList<ContextItem> Items { get; }
+    }
+    public class BinaryExchange {
+        public BinaryExchange(byte[] binaryData, Uri valueType);
+        public BinaryExchange(byte[] binaryData, Uri valueType, Uri encodingType);
+        public byte[] BinaryData { get; }
+        public Uri EncodingType { get; }
+        public Uri ValueType { get; }
+    }
+    public class ContextItem {
+        public ContextItem(Uri name);
+        public ContextItem(Uri name, string value);
+        public ContextItem(Uri name, string value, Uri scope);
+        public Uri Name { get; set; }
+        public Uri Scope { get; set; }
+        public string Value { get; set; }
+    }
+    public class EndpointReference {
+        public EndpointReference(string uri);
+        public Collection<XmlElement> Details { get; }
+        public Uri Uri { get; }
+        public static EndpointReference ReadFrom(XmlDictionaryReader reader);
+        public static EndpointReference ReadFrom(XmlReader reader);
+        public void WriteTo(XmlWriter writer);
+    }
+    public class Entropy : ProtectedKey {
+        public Entropy(byte[] secret);
+        public Entropy(byte[] secret, EncryptingCredentials wrappingCredentials);
+        public Entropy(ProtectedKey protectedKey);
+        public Entropy(int entropySizeInBits);
+    }
+    public class InvalidRequestException : RequestException {
+        public InvalidRequestException();
+        protected InvalidRequestException(SerializationInfo info, StreamingContext context);
+        public InvalidRequestException(string message);
+        public InvalidRequestException(string message, Exception innerException);
+    }
+    public static class KeyTypes {
+        public const string Asymmetric = "http://schemas.microsoft.com/idfx/keytype/asymmetric";
+        public const string Bearer = "http://schemas.microsoft.com/idfx/keytype/bearer";
+        public const string Symmetric = "http://schemas.microsoft.com/idfx/keytype/symmetric";
+    }
+    public class Lifetime {
+        public Lifetime(DateTime created, DateTime expires);
+        public Lifetime(Nullable<DateTime> created, Nullable<DateTime> expires);
+        public Nullable<DateTime> Created { get; set; }
+        public Nullable<DateTime> Expires { get; set; }
+    }
+    public class Participants {
+        public Participants();
+        public List<EndpointReference> Participant { get; }
+        public EndpointReference Primary { get; set; }
+    }
+    public class ProtectedKey {
+        public ProtectedKey(byte[] secret);
+        public ProtectedKey(byte[] secret, EncryptingCredentials wrappingCredentials);
+        public EncryptingCredentials WrappingCredentials { get; }
+        public byte[] GetKeyBytes();
+    }
+    public class Renewing {
+        public Renewing();
+        public Renewing(bool allowRenewal, bool okForRenewalAfterExpiration);
+        public bool AllowRenewal { get; set; }
+        public bool OkForRenewalAfterExpiration { get; set; }
+    }
+    public class RequestClaim {
+        public RequestClaim(string claimType);
+        public RequestClaim(string claimType, bool isOptional);
+        public RequestClaim(string claimType, bool isOptional, string value);
+        public string ClaimType { get; }
+        public bool IsOptional { get; set; }
+        public string Value { get; set; }
+    }
+    public class RequestClaimCollection : Collection<RequestClaim> {
+        public RequestClaimCollection();
+        public string Dialect { get; set; }
+    }
+    public class RequestedProofToken {
+        public RequestedProofToken(byte[] secret);
+        public RequestedProofToken(byte[] secret, EncryptingCredentials wrappingCredentials);
+        public RequestedProofToken(ProtectedKey protectedKey);
+        public RequestedProofToken(string computedKeyAlgorithm);
+        public string ComputedKeyAlgorithm { get; }
+        public ProtectedKey ProtectedKey { get; }
+    }
+    public class RequestedSecurityToken {
+        public RequestedSecurityToken(SecurityToken token);
+        public RequestedSecurityToken(XmlElement tokenAsXml);
+        public SecurityToken SecurityToken { get; }
+        public virtual XmlElement SecurityTokenXml { get; }
+    }
+    public class RequestSecurityToken : WSTrustMessage {
+        public RequestSecurityToken();
+        public RequestSecurityToken(string requestType);
+        public RequestSecurityToken(string requestType, string keyType);
+        public SecurityTokenElement ActAs { get; set; }
+        public AdditionalContext AdditionalContext { get; set; }
+        public SecurityTokenElement CancelTarget { get; set; }
+        public RequestClaimCollection Claims { get; }
+        public string ComputedKeyAlgorithm { get; set; }
+        public Nullable<bool> Delegatable { get; set; }
+        public SecurityTokenElement DelegateTo { get; set; }
+        public SecurityTokenElement Encryption { get; set; }
+        public Nullable<bool> Forwardable { get; set; }
+        public EndpointReference Issuer { get; set; }
+        public SecurityTokenElement OnBehalfOf { get; set; }
+        public Participants Participants { get; set; }
+        public SecurityTokenElement ProofEncryption { get; set; }
+        public Renewing Renewing { get; set; }
+        public SecurityTokenElement RenewTarget { get; set; }
+        public RequestSecurityToken SecondaryParameters { get; set; }
+        public SecurityTokenElement ValidateTarget { get; set; }
+    }
+    public class RequestSecurityTokenResponse : WSTrustMessage {
+        public RequestSecurityTokenResponse();
+        public RequestSecurityTokenResponse(WSTrustMessage message);
+        public bool IsFinal { get; set; }
+        public SecurityKeyIdentifierClause RequestedAttachedReference { get; set; }
+        public RequestedProofToken RequestedProofToken { get; set; }
+        public RequestedSecurityToken RequestedSecurityToken { get; set; }
+        public bool RequestedTokenCancelled { get; set; }
+        public SecurityKeyIdentifierClause RequestedUnattachedReference { get; set; }
+        public Status Status { get; set; }
+    }
+    public static class RequestTypes {
+        public const string Cancel = "http://schemas.microsoft.com/idfx/requesttype/cancel";
+        public const string GetMetadata = "http://schemas.microsoft.com/idfx/requesttype/getMetadata";
+        public const string Issue = "http://schemas.microsoft.com/idfx/requesttype/issue";
+        public const string IssueCard = "http://schemas.microsoft.com/idfx/requesttype/issueCard";
+        public const string Renew = "http://schemas.microsoft.com/idfx/requesttype/renew";
+        public const string Validate = "http://schemas.microsoft.com/idfx/requesttype/validate";
+    }
+    public class Status {
+        public Status(string code, string reason);
+        public string Code { get; set; }
+        public string Reason { get; set; }
+    }
+    public class UseKey {
+        public UseKey();
+        public UseKey(SecurityKeyIdentifier ski);
+        public UseKey(SecurityKeyIdentifier ski, SecurityToken token);
+        public UseKey(SecurityToken token);
+        public SecurityKeyIdentifier SecurityKeyIdentifier { get; }
+        public SecurityToken Token { get; }
+    }
+    public class WSTrust13RequestSerializer : WSTrustRequestSerializer {
+        public WSTrust13RequestSerializer();
+        public override bool CanRead(XmlReader reader);
+        protected virtual RequestSecurityToken ReadSecondaryParameters(XmlReader reader, WSTrustSerializationContext context);
+        public override RequestSecurityToken ReadXml(XmlReader reader, WSTrustSerializationContext context);
+        public override void ReadXmlElement(XmlReader reader, RequestSecurityToken rst, WSTrustSerializationContext context);
+        public override void WriteKnownRequestElement(RequestSecurityToken rst, XmlWriter writer, WSTrustSerializationContext context);
+        public override void WriteXml(RequestSecurityToken request, XmlWriter writer, WSTrustSerializationContext context);
+        public override void WriteXmlElement(XmlWriter writer, string elementName, object elementValue, RequestSecurityToken rst, WSTrustSerializationContext context);
+    }
+    public class WSTrust13ResponseSerializer : WSTrustResponseSerializer {
+        public WSTrust13ResponseSerializer();
+        public override bool CanRead(XmlReader reader);
+        public override RequestSecurityTokenResponse ReadXml(XmlReader reader, WSTrustSerializationContext context);
+        public override void ReadXmlElement(XmlReader reader, RequestSecurityTokenResponse rstr, WSTrustSerializationContext context);
+        public override void WriteKnownResponseElement(RequestSecurityTokenResponse rstr, XmlWriter writer, WSTrustSerializationContext context);
+        public override void WriteXml(RequestSecurityTokenResponse response, XmlWriter writer, WSTrustSerializationContext context);
+        public override void WriteXmlElement(XmlWriter writer, string elementName, object elementValue, RequestSecurityTokenResponse rstr, WSTrustSerializationContext context);
+    }
+    public class WSTrustFeb2005RequestSerializer : WSTrustRequestSerializer {
+        public WSTrustFeb2005RequestSerializer();
+        public override bool CanRead(XmlReader reader);
+        public override RequestSecurityToken ReadXml(XmlReader reader, WSTrustSerializationContext context);
+        public override void ReadXmlElement(XmlReader reader, RequestSecurityToken rst, WSTrustSerializationContext context);
+        public override void WriteKnownRequestElement(RequestSecurityToken rst, XmlWriter writer, WSTrustSerializationContext context);
+        public override void WriteXml(RequestSecurityToken request, XmlWriter writer, WSTrustSerializationContext context);
+        public override void WriteXmlElement(XmlWriter writer, string elementName, object elementValue, RequestSecurityToken rst, WSTrustSerializationContext context);
+    }
+    public class WSTrustFeb2005ResponseSerializer : WSTrustResponseSerializer {
+        public WSTrustFeb2005ResponseSerializer();
+        public override bool CanRead(XmlReader reader);
+        public override RequestSecurityTokenResponse ReadXml(XmlReader reader, WSTrustSerializationContext context);
+        public override void ReadXmlElement(XmlReader reader, RequestSecurityTokenResponse rstr, WSTrustSerializationContext context);
+        public override void WriteKnownResponseElement(RequestSecurityTokenResponse rstr, XmlWriter writer, WSTrustSerializationContext context);
+        public override void WriteXml(RequestSecurityTokenResponse response, XmlWriter writer, WSTrustSerializationContext context);
+        public override void WriteXmlElement(XmlWriter writer, string elementName, object elementValue, RequestSecurityTokenResponse rstr, WSTrustSerializationContext context);
+    }
+    public abstract class WSTrustMessage : OpenObject {
+        protected WSTrustMessage();
+        public bool AllowPostdating { get; set; }
+        public EndpointReference AppliesTo { get; set; }
+        public string AuthenticationType { get; set; }
+        public BinaryExchange BinaryExchange { get; set; }
+        public string CanonicalizationAlgorithm { get; set; }
+        public string Context { get; set; }
+        public string EncryptionAlgorithm { get; set; }
+        public string EncryptWith { get; set; }
+        public Entropy Entropy { get; set; }
+        public Nullable<int> KeySizeInBits { get; set; }
+        public string KeyType { get; set; }
+        public string KeyWrapAlgorithm { get; set; }
+        public Lifetime Lifetime { get; set; }
+        public string ReplyTo { get; set; }
+        public string RequestType { get; set; }
+        public string SignatureAlgorithm { get; set; }
+        public string SignWith { get; set; }
+        public string TokenType { get; set; }
+        public UseKey UseKey { get; set; }
+    }
+    public abstract class WSTrustRequestSerializer {
+        protected WSTrustRequestSerializer();
+        public abstract bool CanRead(XmlReader reader);
+        public virtual RequestSecurityToken CreateRequestSecurityToken();
+        protected virtual void ReadCustomElement(XmlReader reader, WSTrustSerializationContext context);
+        public abstract RequestSecurityToken ReadXml(XmlReader reader, WSTrustSerializationContext context);
+        public abstract void ReadXmlElement(XmlReader reader, RequestSecurityToken requestSecurityToken, WSTrustSerializationContext context);
+        public virtual void Validate(RequestSecurityToken requestSecurityToken);
+        public abstract void WriteKnownRequestElement(RequestSecurityToken requestSecurityToken, XmlWriter writer, WSTrustSerializationContext context);
+        public abstract void WriteXml(RequestSecurityToken request, XmlWriter writer, WSTrustSerializationContext context);
+        public abstract void WriteXmlElement(XmlWriter writer, string elementName, object elementValue, RequestSecurityToken requestSecurityToken, WSTrustSerializationContext context);
+    }
+    public abstract class WSTrustResponseSerializer {
+        protected WSTrustResponseSerializer();
+        public abstract bool CanRead(XmlReader reader);
+        public virtual RequestSecurityTokenResponse CreateInstance();
+        public abstract RequestSecurityTokenResponse ReadXml(XmlReader reader, WSTrustSerializationContext context);
+        public abstract void ReadXmlElement(XmlReader reader, RequestSecurityTokenResponse requestSecurityTokenResponse, WSTrustSerializationContext context);
+        public virtual void Validate(RequestSecurityTokenResponse requestSecurityTokenResponse);
+        public abstract void WriteKnownResponseElement(RequestSecurityTokenResponse requestSecurityTokenResponse, XmlWriter writer, WSTrustSerializationContext context);
+        public abstract void WriteXml(RequestSecurityTokenResponse response, XmlWriter writer, WSTrustSerializationContext context);
+        public abstract void WriteXmlElement(XmlWriter writer, string elementName, object elementValue, RequestSecurityTokenResponse requestSecurityTokenResponse, WSTrustSerializationContext context);
+    }
+    public class WSTrustSerializationContext {
+        public WSTrustSerializationContext();
+        public WSTrustSerializationContext(SecurityTokenHandlerCollectionManager securityTokenHandlerCollectionManager);
+        public WSTrustSerializationContext(SecurityTokenHandlerCollectionManager securityTokenHandlerCollectionManager, SecurityTokenResolver securityTokenResolver, SecurityTokenResolver useKeyTokenResolver);
+        public SecurityTokenHandlerCollectionManager SecurityTokenHandlerCollectionManager { get; set; }
+        public SecurityTokenHandlerCollection SecurityTokenHandlers { get; }
+        public SecurityTokenResolver TokenResolver { get; set; }
+        public SecurityTokenResolver UseKeyTokenResolver { get; set; }
+    }
+    public class WSTrustSerializationException : Exception, ISerializable {
+        public WSTrustSerializationException();
+        protected WSTrustSerializationException(SerializationInfo info, StreamingContext context);
+        public WSTrustSerializationException(string message);
+        public WSTrustSerializationException(string message, Exception inner);
+    }
+}
```

