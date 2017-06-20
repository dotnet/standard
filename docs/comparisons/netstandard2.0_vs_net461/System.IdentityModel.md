# System.IdentityModel

``` diff
+namespace System.IdentityModel {
+    public class AsynchronousOperationException : Exception {
+        public AsynchronousOperationException();
+        public AsynchronousOperationException(Exception innerException);
+        protected AsynchronousOperationException(SerializationInfo info, StreamingContext context);
+        public AsynchronousOperationException(string message);
+        public AsynchronousOperationException(string message, Exception innerException);
+    }
+    public abstract class AsyncResult : IAsyncResult, IDisposable {
+        protected AsyncResult();
+        protected AsyncResult(AsyncCallback callback, object state);
+        protected AsyncResult(object state);
+        public object AsyncState { get; }
+        public virtual WaitHandle AsyncWaitHandle { get; }
+        public bool CompletedSynchronously { get; }
+        public bool IsCompleted { get; }
+        protected void Complete(bool completedSynchronously);
+        protected void Complete(bool completedSynchronously, Exception exception);
+        public void Dispose();
+        protected virtual void Dispose(bool isExplicitDispose);
+        public static void End(IAsyncResult result);
+        ~AsyncResult();
+    }
+    public class BadRequestException : RequestException {
+        public BadRequestException();
+        protected BadRequestException(SerializationInfo info, StreamingContext context);
+        public BadRequestException(string message);
+        public BadRequestException(string message, Exception innerException);
+    }
+    public abstract class CookieTransform {
+        protected CookieTransform();
+        public abstract byte[] Decode(byte[] encoded);
+        public abstract byte[] Encode(byte[] value);
+    }
+    public sealed class DeflateCookieTransform : CookieTransform {
+        public DeflateCookieTransform();
+        public int MaxDecompressedSize { get; set; }
+        public override byte[] Decode(byte[] encoded);
+        public override byte[] Encode(byte[] value);
+    }
+    public class DelegatingXmlDictionaryReader : XmlDictionaryReader {
+        protected DelegatingXmlDictionaryReader();
+        public override int AttributeCount { get; }
+        public override string BaseURI { get; }
+        public override int Depth { get; }
+        public override bool EOF { get; }
+        public override bool HasValue { get; }
+        protected XmlDictionaryReader InnerReader { get; }
+        public override bool IsDefault { get; }
+        public override bool IsEmptyElement { get; }
+        public override string LocalName { get; }
+        public override string Name { get; }
+        public override string NamespaceURI { get; }
+        public override XmlNameTable NameTable { get; }
+        public override XmlNodeType NodeType { get; }
+        public override string Prefix { get; }
+        public override char QuoteChar { get; }
+        public override ReadState ReadState { get; }
+        public override string this[int i] { get; }
+        public override string this[string name, string namespaceURI] { get; }
+        public override string this[string name] { get; }
+        public override string Value { get; }
+        public override Type ValueType { get; }
+        public override string XmlLang { get; }
+        public override XmlSpace XmlSpace { get; }
+        public override void Close();
+        public override string GetAttribute(int i);
+        public override string GetAttribute(string name);
+        public override string GetAttribute(string name, string namespaceURI);
+        protected void InitializeInnerReader(XmlDictionaryReader innerReader);
+        public override string LookupNamespace(string prefix);
+        public override void MoveToAttribute(int i);
+        public override bool MoveToAttribute(string name);
+        public override bool MoveToAttribute(string name, string ns);
+        public override bool MoveToElement();
+        public override bool MoveToFirstAttribute();
+        public override bool MoveToNextAttribute();
+        public override bool Read();
+        public override bool ReadAttributeValue();
+        public override int ReadContentAsBase64(byte[] buffer, int index, int count);
+        public override int ReadContentAsBinHex(byte[] buffer, int index, int count);
+        public override UniqueId ReadContentAsUniqueId();
+        public override int ReadValueChunk(char[] buffer, int index, int count);
+        public override void ResolveEntity();
+    }
+    public class DelegatingXmlDictionaryWriter : XmlDictionaryWriter {
+        protected DelegatingXmlDictionaryWriter();
+        public override bool CanCanonicalize { get; }
+        protected XmlDictionaryWriter InnerWriter { get; }
+        public override WriteState WriteState { get; }
+        public override void Close();
+        public override void EndCanonicalization();
+        public override void Flush();
+        protected void InitializeInnerWriter(XmlDictionaryWriter innerWriter);
+        protected void InitializeTracingWriter(XmlWriter tracingWriter);
+        public override string LookupPrefix(string ns);
+        public override void StartCanonicalization(Stream stream, bool includeComments, string[] inclusivePrefixes);
+        public override void WriteBase64(byte[] buffer, int index, int count);
+        public override void WriteCData(string text);
+        public override void WriteCharEntity(char ch);
+        public override void WriteChars(char[] buffer, int index, int count);
+        public override void WriteComment(string text);
+        public override void WriteDocType(string name, string pubid, string sysid, string subset);
+        public override void WriteEndAttribute();
+        public override void WriteEndDocument();
+        public override void WriteEndElement();
+        public override void WriteEntityRef(string name);
+        public override void WriteFullEndElement();
+        public override void WriteProcessingInstruction(string name, string text);
+        public override void WriteRaw(char[] buffer, int index, int count);
+        public override void WriteRaw(string data);
+        public override void WriteStartAttribute(string prefix, string localName, string ns);
+        public override void WriteStartDocument();
+        public override void WriteStartDocument(bool standalone);
+        public override void WriteStartElement(string prefix, string localName, string ns);
+        public override void WriteString(string text);
+        public override void WriteSurrogateCharEntity(char lowChar, char highChar);
+        public override void WriteWhitespace(string ws);
+        public override void WriteXmlAttribute(string localName, string value);
+        public override void WriteXmlnsAttribute(string prefix, string namespaceUri);
+    }
+    public sealed class EnvelopedSignatureReader : DelegatingXmlDictionaryReader {
+        public EnvelopedSignatureReader(XmlReader reader, SecurityTokenSerializer securityTokenSerializer);
+        public EnvelopedSignatureReader(XmlReader reader, SecurityTokenSerializer securityTokenSerializer, SecurityTokenResolver signingTokenResolver);
+        public EnvelopedSignatureReader(XmlReader reader, SecurityTokenSerializer securityTokenSerializer, SecurityTokenResolver signingTokenResolver, bool requireSignature, bool automaticallyReadSignature, bool resolveIntrinsicSigningKeys);
+        public SigningCredentials SigningCredentials { get; }
+        protected override void Dispose(bool disposing);
+        public override bool Read();
+        public bool TryReadSignature();
+    }
+    public sealed class EnvelopedSignatureWriter : DelegatingXmlDictionaryWriter {
+        public EnvelopedSignatureWriter(XmlWriter innerWriter, SigningCredentials signingCredentials, string referenceId, SecurityTokenSerializer securityTokenSerializer);
+        protected override void Dispose(bool disposing);
+        public override void WriteEndElement();
+        public override void WriteFullEndElement();
+        public void WriteSignature();
+        public override void WriteStartElement(string prefix, string localName, string ns);
+    }
+    public class LimitExceededException : SystemException {
+        public LimitExceededException();
+        protected LimitExceededException(SerializationInfo info, StreamingContext context);
+        public LimitExceededException(string message);
+        public LimitExceededException(string message, Exception innerException);
+    }
+    public abstract class OpenObject {
+        protected OpenObject();
+        public Dictionary<string, object> Properties { get; }
+    }
+    public sealed class ProtectedDataCookieTransform : CookieTransform {
+        public ProtectedDataCookieTransform();
+        public override byte[] Decode(byte[] encoded);
+        public override byte[] Encode(byte[] value);
+    }
+    public abstract class RequestException : Exception {
+        protected RequestException();
+        protected RequestException(SerializationInfo info, StreamingContext context);
+        protected RequestException(string message);
+        protected RequestException(string message, Exception innerException);
+    }
+    public class RequestFailedException : RequestException {
+        public RequestFailedException();
+        protected RequestFailedException(SerializationInfo info, StreamingContext context);
+        public RequestFailedException(string message);
+        public RequestFailedException(string message, Exception innerException);
+    }
+    public class RsaEncryptionCookieTransform : CookieTransform {
+        public RsaEncryptionCookieTransform(RSA key);
+        public RsaEncryptionCookieTransform(X509Certificate2 certificate);
+        protected virtual ReadOnlyCollection<RSA> DecryptionKeys { get; }
+        public virtual RSA EncryptionKey { get; set; }
+        public string HashName { get; set; }
+        public override byte[] Decode(byte[] encoded);
+        public override byte[] Encode(byte[] value);
+    }
+    public class RsaSignatureCookieTransform : CookieTransform {
+        public RsaSignatureCookieTransform(RSA key);
+        public RsaSignatureCookieTransform(X509Certificate2 certificate);
+        public string HashName { get; set; }
+        public virtual RSA SigningKey { get; set; }
+        protected virtual ReadOnlyCollection<RSA> VerificationKeys { get; }
+        public override byte[] Decode(byte[] encoded);
+        public override byte[] Encode(byte[] value);
+    }
+    public class Scope {
+        public Scope();
+        public Scope(string appliesToAddress);
+        public Scope(string appliesToAddress, EncryptingCredentials encryptingCredentials);
+        public Scope(string appliesToAddress, SigningCredentials signingCredentials);
+        public Scope(string appliesToAddress, SigningCredentials signingCredentials, EncryptingCredentials encryptingCredentials);
+        public virtual string AppliesToAddress { get; set; }
+        public virtual EncryptingCredentials EncryptingCredentials { get; set; }
+        public virtual Dictionary<string, object> Properties { get; }
+        public virtual string ReplyToAddress { get; set; }
+        public virtual SigningCredentials SigningCredentials { get; set; }
+        public virtual bool SymmetricKeyEncryptionRequired { get; set; }
+        public virtual bool TokenEncryptionRequired { get; set; }
+    }
+    public class SecurityMessageSerializationException : SystemException {
+        public SecurityMessageSerializationException();
+        protected SecurityMessageSerializationException(SerializationInfo info, StreamingContext context);
+        public SecurityMessageSerializationException(string message);
+        public SecurityMessageSerializationException(string message, Exception innerException);
+    }
+    public abstract class SecurityTokenService {
+        protected SecurityTokenService(SecurityTokenServiceConfiguration securityTokenServiceConfiguration);
+        public ClaimsPrincipal Principal { get; set; }
+        public RequestSecurityToken Request { get; set; }
+        public Scope Scope { get; set; }
+        protected SecurityTokenDescriptor SecurityTokenDescriptor { get; set; }
+        public SecurityTokenServiceConfiguration SecurityTokenServiceConfiguration { get; }
+        public virtual IAsyncResult BeginCancel(ClaimsPrincipal principal, RequestSecurityToken request, AsyncCallback callback, object state);
+        protected virtual IAsyncResult BeginGetOutputClaimsIdentity(ClaimsPrincipal principal, RequestSecurityToken request, Scope scope, AsyncCallback callback, object state);
+        protected virtual IAsyncResult BeginGetScope(ClaimsPrincipal principal, RequestSecurityToken request, AsyncCallback callback, object state);
+        public virtual IAsyncResult BeginIssue(ClaimsPrincipal principal, RequestSecurityToken request, AsyncCallback callback, object state);
+        public virtual IAsyncResult BeginRenew(ClaimsPrincipal principal, RequestSecurityToken request, AsyncCallback callback, object state);
+        public virtual IAsyncResult BeginValidate(ClaimsPrincipal principal, RequestSecurityToken request, AsyncCallback callback, object state);
+        public virtual RequestSecurityTokenResponse Cancel(ClaimsPrincipal principal, RequestSecurityToken request);
+        protected virtual SecurityTokenDescriptor CreateSecurityTokenDescriptor(RequestSecurityToken request, Scope scope);
+        public virtual RequestSecurityTokenResponse EndCancel(IAsyncResult result);
+        protected virtual ClaimsIdentity EndGetOutputClaimsIdentity(IAsyncResult result);
+        protected virtual Scope EndGetScope(IAsyncResult result);
+        public virtual RequestSecurityTokenResponse EndIssue(IAsyncResult result);
+        public virtual RequestSecurityTokenResponse EndRenew(IAsyncResult result);
+        public virtual RequestSecurityTokenResponse EndValidate(IAsyncResult result);
+        protected virtual string GetIssuerName();
+        protected abstract ClaimsIdentity GetOutputClaimsIdentity(ClaimsPrincipal principal, RequestSecurityToken request, Scope scope);
+        protected virtual ProofDescriptor GetProofToken(RequestSecurityToken request, Scope scope);
+        protected virtual EncryptingCredentials GetRequestorProofEncryptingCredentials(RequestSecurityToken request);
+        protected virtual RequestSecurityTokenResponse GetResponse(RequestSecurityToken request, SecurityTokenDescriptor tokenDescriptor);
+        protected abstract Scope GetScope(ClaimsPrincipal principal, RequestSecurityToken request);
+        protected virtual SecurityTokenHandler GetSecurityTokenHandler(string requestedTokenType);
+        protected virtual Lifetime GetTokenLifetime(Lifetime requestLifetime);
+        public virtual RequestSecurityTokenResponse Issue(ClaimsPrincipal principal, RequestSecurityToken request);
+        public virtual RequestSecurityTokenResponse Renew(ClaimsPrincipal principal, RequestSecurityToken request);
+        public virtual RequestSecurityTokenResponse Validate(ClaimsPrincipal principal, RequestSecurityToken request);
+        protected virtual void ValidateRequest(RequestSecurityToken request);
+        protected class FederatedAsyncState {
+            public FederatedAsyncState(SecurityTokenService.FederatedAsyncState federatedAsyncState);
+            public FederatedAsyncState(RequestSecurityToken request, ClaimsPrincipal principal, IAsyncResult result);
+            public ClaimsPrincipal ClaimsPrincipal { get; }
+            public RequestSecurityToken Request { get; }
+            public IAsyncResult Result { get; }
+            public SecurityTokenHandler SecurityTokenHandler { get; set; }
+        }
+    }
+    public class SignatureVerificationFailedException : SecurityTokenException {
+        public SignatureVerificationFailedException();
+        protected SignatureVerificationFailedException(SerializationInfo info, StreamingContext context);
+        public SignatureVerificationFailedException(string message);
+        public SignatureVerificationFailedException(string message, Exception inner);
+    }
+    public class TypedAsyncResult<T> : AsyncResult {
+        public TypedAsyncResult(AsyncCallback callback, object state);
+        public TypedAsyncResult(object state);
+        public T Result { get; }
+        public void Complete(T result, bool completedSynchronously);
+        public void Complete(T result, bool completedSynchronously, Exception exception);
+        public static new T End(IAsyncResult result);
+    }
+    public class UnsupportedTokenTypeBadRequestException : BadRequestException {
+        public UnsupportedTokenTypeBadRequestException();
+        protected UnsupportedTokenTypeBadRequestException(SerializationInfo info, StreamingContext context);
+        public UnsupportedTokenTypeBadRequestException(string tokenType);
+        public UnsupportedTokenTypeBadRequestException(string message, Exception exception);
+        public string TokenType { get; set; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+}
```

