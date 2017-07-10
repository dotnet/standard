# System.IdentityModel.Services

``` diff
+namespace System.IdentityModel.Services {
+    public enum ApplicationType {
+        AspNetWebApplication = 0,
+        WcfServiceApplication = 1,
+    }
+    public class AsynchronousOperationException : Exception {
+        public AsynchronousOperationException();
+        public AsynchronousOperationException(Exception innerException);
+        protected AsynchronousOperationException(SerializationInfo info, StreamingContext context);
+        public AsynchronousOperationException(string message);
+        public AsynchronousOperationException(string message, Exception innerException);
+    }
+    public class AttributeRequestMessage : WSFederationMessage {
+        public AttributeRequestMessage(Uri baseUrl);
+        public string Attribute { get; set; }
+        public string AttributePtr { get; set; }
+        public string Reply { get; set; }
+        public string Result { get; set; }
+        public string ResultPtr { get; set; }
+        protected override void Validate();
+        public override void Write(TextWriter writer);
+    }
+    public class AuthorizationFailedEventArgs : EventArgs {
+        public AuthorizationFailedEventArgs();
+        public bool RedirectToIdentityProvider { get; set; }
+    }
+    public sealed class ChunkedCookieHandler : CookieHandler {
+        public const int DefaultChunkSize = 2000;
+        public const int MinimumChunkSize = 1000;
+        public ChunkedCookieHandler();
+        public ChunkedCookieHandler(int chunkSize);
+        public int ChunkSize { get; }
+        protected override void DeleteCore(string name, string path, string domain, HttpContext context);
+        protected override byte[] ReadCore(string name, HttpContext context);
+        protected override void WriteCore(byte[] value, string name, string path, string domain, DateTime expirationTime, bool secure, bool httpOnly, HttpContext context);
+    }
+    public class ChunkedCookieHandlerElement : ConfigurationElement {
+        public ChunkedCookieHandlerElement();
+        public int ChunkSize { get; set; }
+    }
+    public class ClaimsAuthorizationModule : HttpModuleBase {
+        public ClaimsAuthorizationModule();
+        public ClaimsAuthorizationManager ClaimsAuthorizationManager { get; set; }
+        protected virtual bool Authorize();
+        public override void Dispose();
+        protected override void InitializeModule(HttpApplication context);
+        protected override void InitializePropertiesFromConfiguration();
+        protected virtual void OnAuthorizeRequest(object sender, EventArgs args);
+    }
+    public sealed class ClaimsPrincipalPermission : IPermission, ISecurityEncodable, IUnrestrictedPermission {
+        public ClaimsPrincipalPermission(string resource, string action);
+        public static void CheckAccess(string resource, string action);
+        public IPermission Copy();
+        public void Demand();
+        public void FromXml(SecurityElement element);
+        public IPermission Intersect(IPermission target);
+        public bool IsSubsetOf(IPermission target);
+        public bool IsUnrestricted();
+        public SecurityElement ToXml();
+        public IPermission Union(IPermission target);
+    }
+    public sealed class ClaimsPrincipalPermissionAttribute : CodeAccessSecurityAttribute {
+        public ClaimsPrincipalPermissionAttribute(SecurityAction action);
+        public string Operation { get; set; }
+        public string Resource { get; set; }
+        public override IPermission CreatePermission();
+    }
+    public abstract class CookieHandler {
+        protected CookieHandler();
+        public virtual string Domain { get; set; }
+        public virtual bool HideFromClientScript { get; set; }
+        public virtual string Name { get; set; }
+        public virtual string Path { get; set; }
+        public virtual Nullable<TimeSpan> PersistentSessionLifetime { get; set; }
+        public virtual bool RequireSsl { get; set; }
+        public void Delete();
+        public void Delete(string name);
+        public void Delete(string name, string path, string domain, HttpContext context);
+        public void Delete(string name, HttpContext context);
+        public void Delete(HttpContext context);
+        protected abstract void DeleteCore(string name, string path, string domain, HttpContext context);
+        public virtual string MatchCookiePath(Uri baseUri, Uri targetUri);
+        public byte[] Read();
+        public byte[] Read(string name);
+        public byte[] Read(string name, HttpContext context);
+        public byte[] Read(HttpContext context);
+        protected abstract byte[] ReadCore(string name, HttpContext context);
+        public void Write(byte[] value, bool isPersistent, DateTime tokenExpirationTime);
+        public void Write(byte[] value, string name, DateTime expirationTime);
+        public void Write(byte[] value, string name, DateTime expirationTime, HttpContext context);
+        public void Write(byte[] value, string name, string path, string domain, DateTime expirationTime, bool requiresSsl, bool hideFromClientScript, HttpContext context);
+        protected abstract void WriteCore(byte[] value, string name, string path, string domain, DateTime expirationTime, bool secure, bool httpOnly, HttpContext context);
+    }
+    public class CookieHandlerElement : ConfigurationElement {
+        public CookieHandlerElement();
+        public ChunkedCookieHandlerElement ChunkedCookieHandler { get; set; }
+        public CustomTypeElement CustomCookieHandler { get; set; }
+        public string Domain { get; set; }
+        public bool HideFromScript { get; set; }
+        public CookieHandlerMode Mode { get; set; }
+        public string Name { get; set; }
+        public string Path { get; set; }
+        public TimeSpan PersistentSessionLifetime { get; set; }
+        public bool RequireSsl { get; set; }
+        public CookieHandler GetConfiguredCookieHandler();
+    }
+    public enum CookieHandlerMode {
+        Chunked = 1,
+        Custom = 2,
+        Default = 0,
+    }
+    public class ErrorEventArgs : CancelEventArgs {
+        public ErrorEventArgs(bool cancel, Exception exception);
+        public ErrorEventArgs(Exception exception);
+        public Exception Exception { get; }
+    }
+    public static class FederatedAuthentication {
+        public static ClaimsAuthorizationModule ClaimsAuthorizationModule { get; }
+        public static FederationConfiguration FederationConfiguration { get; }
+        public static SessionAuthenticationModule SessionAuthenticationModule { get; }
+        public static WSFederationAuthenticationModule WSFederationAuthenticationModule { get; }
+        public static event EventHandler<FederationConfigurationCreatedEventArgs> FederationConfigurationCreated;
+        public static T GetHttpModule<T>() where T : class, IHttpModule;
+    }
+    public class FederatedAuthenticationSessionEndingException : Exception, ISerializable {
+        public FederatedAuthenticationSessionEndingException();
+        protected FederatedAuthenticationSessionEndingException(SerializationInfo info, StreamingContext context);
+        public FederatedAuthenticationSessionEndingException(string message);
+        public FederatedAuthenticationSessionEndingException(string message, Exception inner);
+    }
+    public static class FederatedPassiveSecurityTokenServiceOperations {
+        public static void ProcessRequest(HttpRequest request, ClaimsPrincipal principal, SecurityTokenService sts, HttpResponse response);
+        public static void ProcessRequest(HttpRequest request, ClaimsPrincipal principal, SecurityTokenService sts, HttpResponse response, WSFederationSerializer federationSerializer);
+        public static SignInResponseMessage ProcessSignInRequest(SignInRequestMessage requestMessage, ClaimsPrincipal principal, SecurityTokenService sts);
+        public static SignInResponseMessage ProcessSignInRequest(SignInRequestMessage requestMessage, ClaimsPrincipal principal, SecurityTokenService sts, WSFederationSerializer federationSerializer);
+        public static void ProcessSignInResponse(SignInResponseMessage signInResponseMessage, HttpResponse httpResponse);
+        public static void ProcessSignOutRequest(FederationMessage requestMessage, ClaimsPrincipal principal, string reply, HttpResponse httpResponse);
+    }
+    public class FederatedSessionExpiredException : FederatedAuthenticationSessionEndingException {
+        public FederatedSessionExpiredException();
+        public FederatedSessionExpiredException(DateTime tested, DateTime expired);
+        public FederatedSessionExpiredException(DateTime tested, DateTime expired, Exception inner);
+        protected FederatedSessionExpiredException(SerializationInfo info, StreamingContext context);
+        public FederatedSessionExpiredException(string message);
+        public FederatedSessionExpiredException(string message, Exception inner);
+        public DateTime Expired { get; }
+        public DateTime Tested { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class FederationException : Exception {
+        public FederationException();
+        protected FederationException(SerializationInfo info, StreamingContext context);
+        public FederationException(string message);
+        public FederationException(string message, Exception inner);
+    }
+    public static class FederationManagement {
+        public static XmlReader CreateApplicationFederationMetadata(Uri applicationUri, X509Certificate2 certificate, Collection<DisplayClaim> claimsRequired, ApplicationType applicationType, Collection<Uri> audienceUris);
+        public static XmlReader UpdateIdentityProviderTrustInfo(XmlReader metadataReader, XmlReader inputConfiguration, bool claimsOfferedUpdate);
+        public static XmlReader UpdateIdentityProviderTrustInfo(XmlReader metadataReader, XmlReader inputConfiguration, bool claimsOfferedUpdate, MetadataSerializer metadataSerializer);
+        public static void UpdateIdentityProviderTrustInfo(XmlReader metadataReader, XmlReader inputConfiguration, out XmlNodeReader newIssuerNameRegistry, out XmlNodeReader claimTypesOffered);
+        public static void UpdateIdentityProviderTrustInfo(XmlReader metadataReader, XmlReader inputConfiguration, out XmlNodeReader newIssuerNameRegistry, out XmlNodeReader claimTypesOffered, MetadataSerializer metadataSerializer);
+    }
+    public abstract class FederationMessage {
+        protected FederationMessage(Uri baseUrl);
+        public Uri BaseUri { get; set; }
+        public IDictionary<string, string> Parameters { get; }
+        public static Uri GetBaseUrl(Uri uri);
+        public string GetParameter(string parameter);
+        public static NameValueCollection ParseQueryString(Uri data);
+        public void RemoveParameter(string parameter);
+        public void SetParameter(string parameter, string value);
+        public void SetUriParameter(string parameter, string value);
+        protected virtual void Validate();
+        public abstract void Write(TextWriter writer);
+        public virtual string WriteFormPost();
+        public virtual string WriteQueryString();
+    }
+    public abstract class HttpModuleBase : IHttpModule {
+        protected HttpModuleBase();
+        public FederationConfiguration FederationConfiguration { get; set; }
+        public virtual void Dispose();
+        public void Init(HttpApplication context);
+        protected abstract void InitializeModule(HttpApplication context);
+        protected abstract void InitializePropertiesFromConfiguration();
+    }
+    public class MachineKeyTransform : CookieTransform {
+        public MachineKeyTransform();
+        public override byte[] Decode(byte[] encoded);
+        public override byte[] Encode(byte[] value);
+    }
+    public class PseudonymRequestMessage : WSFederationMessage {
+        public PseudonymRequestMessage(Uri baseUrl);
+        public string Pseudonym { get; set; }
+        public string PseudonymPtr { get; set; }
+        public string Reply { get; set; }
+        public string Result { get; set; }
+        public string ResultPtr { get; set; }
+        protected override void Validate();
+        public override void Write(TextWriter writer);
+    }
+    public class RedirectingToIdentityProviderEventArgs : CancelEventArgs {
+        public RedirectingToIdentityProviderEventArgs(SignInRequestMessage signInRequestMessage);
+        public SignInRequestMessage SignInRequestMessage { get; set; }
+    }
+    public class SecurityTokenReceivedEventArgs : CancelEventArgs {
+        public SecurityTokenReceivedEventArgs(SecurityToken securityToken);
+        public SecurityTokenReceivedEventArgs(SecurityToken securityToken, string signInContext);
+        public SecurityToken SecurityToken { get; set; }
+        public string SignInContext { get; }
+    }
+    public class SecurityTokenValidatedEventArgs : CancelEventArgs {
+        public SecurityTokenValidatedEventArgs(ClaimsPrincipal claimsPrincipal);
+        public ClaimsPrincipal ClaimsPrincipal { get; set; }
+    }
+    public class ServiceCertificateElement : ConfigurationElement {
+        public ServiceCertificateElement();
+        public CertificateReferenceElement CertificateReference { get; set; }
+    }
+    public class SessionAuthenticationModule : HttpModuleBase {
+        public SessionAuthenticationModule();
+        public virtual SessionSecurityToken ContextSessionSecurityToken { get; internal set; }
+        public CookieHandler CookieHandler { get; set; }
+        public bool IsReferenceMode { get; set; }
+        public event EventHandler<SessionSecurityTokenCreatedEventArgs> SessionSecurityTokenCreated;
+        public event EventHandler<SessionSecurityTokenReceivedEventArgs> SessionSecurityTokenReceived;
+        public event EventHandler SignedOut;
+        public event EventHandler<SigningOutEventArgs> SigningOut;
+        public event EventHandler<ErrorEventArgs> SignOutError;
+        public virtual void AuthenticateSessionSecurityToken(SessionSecurityToken sessionToken, bool writeCookie);
+        public bool ContainsSessionTokenCookie(HttpCookieCollection httpCookieCollection);
+        public SessionSecurityToken CreateSessionSecurityToken(ClaimsPrincipal principal, string context, DateTime validFrom, DateTime validTo, bool isPersistent);
+        public void DeleteSessionTokenCookie();
+        protected override void InitializeModule(HttpApplication context);
+        protected override void InitializePropertiesFromConfiguration();
+        protected virtual void OnAuthenticateRequest(object sender, EventArgs eventArgs);
+        protected virtual void OnPostAuthenticateRequest(object sender, EventArgs e);
+        protected virtual void OnSessionSecurityTokenCreated(SessionSecurityTokenCreatedEventArgs args);
+        protected virtual void OnSessionSecurityTokenReceived(SessionSecurityTokenReceivedEventArgs args);
+        protected virtual void OnSignedOut(EventArgs e);
+        protected virtual void OnSigningOut(SigningOutEventArgs e);
+        protected virtual void OnSignOutError(ErrorEventArgs e);
+        public SessionSecurityToken ReadSessionTokenFromCookie(byte[] sessionCookie);
+        protected virtual void SetPrincipalFromSessionToken(SessionSecurityToken sessionSecurityToken);
+        public virtual void SignOut();
+        public bool TryReadSessionTokenFromCookie(out SessionSecurityToken sessionToken);
+        protected ReadOnlyCollection<ClaimsIdentity> ValidateSessionToken(SessionSecurityToken sessionSecurityToken);
+        public void WriteSessionTokenToCookie(SessionSecurityToken sessionToken);
+    }
+    public class SessionSecurityTokenCreatedEventArgs : EventArgs {
+        public SessionSecurityTokenCreatedEventArgs(SessionSecurityToken sessionToken);
+        public SessionSecurityToken SessionToken { get; set; }
+        public bool WriteSessionCookie { get; set; }
+    }
+    public class SessionSecurityTokenReceivedEventArgs : CancelEventArgs {
+        public SessionSecurityTokenReceivedEventArgs(SessionSecurityToken sessionToken);
+        public bool ReissueCookie { get; set; }
+        public SessionSecurityToken SessionToken { get; set; }
+    }
+    public class SessionSecurityTokenResolver : SecurityTokenResolver {
+        public SessionSecurityTokenResolver(SessionSecurityTokenCache tokenCache, string endpointId);
+        protected override bool TryResolveSecurityKeyCore(SecurityKeyIdentifierClause keyIdentifierClause, out SecurityKey key);
+        protected override bool TryResolveTokenCore(SecurityKeyIdentifier keyIdentifier, out SecurityToken token);
+        protected override bool TryResolveTokenCore(SecurityKeyIdentifierClause keyIdentifierClause, out SecurityToken token);
+    }
+    public class SigningOutEventArgs : EventArgs {
+        public SigningOutEventArgs(bool isIPInitiated);
+        public static SigningOutEventArgs IPInitiated { get; }
+        public bool IsIPInitiated { get; }
+        public static SigningOutEventArgs RPInitiated { get; }
+    }
+    public class SignInRequestMessage : WSFederationMessage {
+        public SignInRequestMessage(Uri baseUrl, string realm);
+        public SignInRequestMessage(Uri baseUrl, string realm, string reply);
+        public string AuthenticationType { get; set; }
+        public string CurrentTime { get; set; }
+        public string Federation { get; set; }
+        public string Freshness { get; set; }
+        public string HomeRealm { get; set; }
+        public string Policy { get; set; }
+        public string Realm { get; set; }
+        public string Reply { get; set; }
+        public string Request { get; set; }
+        public string RequestPtr { get; set; }
+        public string RequestUrl { get; }
+        public string Resource { get; set; }
+        protected override void Validate();
+        public override void Write(TextWriter writer);
+    }
+    public class SignInResponseMessage : WSFederationMessage {
+        public SignInResponseMessage(Uri baseUrl, RequestSecurityTokenResponse response, WSFederationSerializer federationSerializer, WSTrustSerializationContext context);
+        public SignInResponseMessage(Uri baseUrl, string result);
+        public SignInResponseMessage(Uri baseUrl, Uri resultPtr);
+        public string Result { get; set; }
+        public string ResultPtr { get; set; }
+        protected override void Validate();
+        public override void Write(TextWriter writer);
+    }
+    public class SignOutCleanupRequestMessage : WSFederationMessage {
+        public SignOutCleanupRequestMessage(Uri baseUrl);
+        public SignOutCleanupRequestMessage(Uri baseUrl, string reply);
+        public string Reply { get; set; }
+        protected override void Validate();
+        public override void Write(TextWriter writer);
+    }
+    public class SignOutRequestMessage : WSFederationMessage {
+        public SignOutRequestMessage(Uri baseUrl);
+        public SignOutRequestMessage(Uri baseUrl, string reply);
+        public string Reply { get; set; }
+        protected override void Validate();
+        public override void Write(TextWriter writer);
+    }
+    public class WSFederationAuthenticationModule : HttpModuleBase {
+        public WSFederationAuthenticationModule();
+        public string AuthenticationType { get; set; }
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
+        public string SignInContext { get; set; }
+        public string SignInQueryString { get; set; }
+        public string SignOutQueryString { get; set; }
+        public string SignOutReply { get; set; }
+        public XmlDictionaryReaderQuotas XmlDictionaryReaderQuotas { get; set; }
+        public event EventHandler<AuthorizationFailedEventArgs> AuthorizationFailed;
+        public event EventHandler<RedirectingToIdentityProviderEventArgs> RedirectingToIdentityProvider;
+        public event EventHandler<SecurityTokenReceivedEventArgs> SecurityTokenReceived;
+        public event EventHandler<SecurityTokenValidatedEventArgs> SecurityTokenValidated;
+        public event EventHandler<SessionSecurityTokenCreatedEventArgs> SessionSecurityTokenCreated;
+        public event EventHandler SignedIn;
+        public event EventHandler SignedOut;
+        public event EventHandler<ErrorEventArgs> SignInError;
+        public event EventHandler<SigningOutEventArgs> SigningOut;
+        public event EventHandler<ErrorEventArgs> SignOutError;
+        public bool CanReadSignInResponse(HttpRequestBase request);
+        public virtual bool CanReadSignInResponse(HttpRequestBase request, bool onPage);
+        public SignInRequestMessage CreateSignInRequest(string uniqueId, string returnUrl, bool rememberMeSet);
+        public static void FederatedSignOut(Uri signOutUrl, Uri replyUrl);
+        public static string GetFederationPassiveSignOutUrl(string issuer, string signOutReply, string signOutQueryString);
+        protected virtual string GetReferencedResult(string resultPtr);
+        protected virtual string GetReturnUrlFromResponse(HttpRequestBase request);
+        public virtual SecurityToken GetSecurityToken(SignInResponseMessage message);
+        public virtual SecurityToken GetSecurityToken(HttpRequestBase request);
+        protected virtual string GetSessionTokenContext();
+        public virtual SignInResponseMessage GetSignInResponseMessage(HttpRequestBase request);
+        protected virtual string GetSignOutRedirectUrl(SignOutCleanupRequestMessage signOutMessage);
+        public virtual string GetXmlTokenFromMessage(SignInResponseMessage message);
+        public virtual string GetXmlTokenFromMessage(SignInResponseMessage message, WSFederationSerializer federationSerializer);
+        protected override void InitializeModule(HttpApplication context);
+        protected override void InitializePropertiesFromConfiguration();
+        public virtual bool IsSignInResponse(HttpRequestBase request);
+        protected virtual void OnAuthenticateRequest(object sender, EventArgs args);
+        protected virtual void OnAuthorizationFailed(AuthorizationFailedEventArgs e);
+        protected virtual void OnEndRequest(object sender, EventArgs args);
+        protected virtual void OnPostAuthenticateRequest(object sender, EventArgs e);
+        protected virtual void OnRedirectingToIdentityProvider(RedirectingToIdentityProviderEventArgs e);
+        protected virtual void OnSessionSecurityTokenCreated(SessionSecurityTokenCreatedEventArgs args);
+        protected virtual void OnSignedIn(EventArgs args);
+        protected virtual void OnSignedOut(EventArgs args);
+        protected virtual void OnSignInError(ErrorEventArgs args);
+        protected virtual void OnSigningOut(SigningOutEventArgs args);
+        protected virtual void OnSignOutError(ErrorEventArgs args);
+        public virtual void RedirectToIdentityProvider(string uniqueId, string returnUrl, bool persist);
+        public void SetPrincipalAndWriteSessionToken(SessionSecurityToken sessionToken, bool isSession);
+        public virtual void SignIn(string ControlId);
+        public virtual void SignOut();
+        public virtual void SignOut(bool isIPRequest);
+        public virtual void SignOut(string redirectUrl);
+        public virtual void SignOut(string redirectUrl, bool initiateSignoutCleanup);
+        public void VerifyProperties();
+    }
+    public abstract class WSFederationMessage : FederationMessage {
+        public WSFederationMessage(Uri baseUrl, string action);
+        public string Action { get; set; }
+        public string Context { get; set; }
+        public string Encoding { get; set; }
+        public static WSFederationMessage CreateFromFormPost(HttpRequestBase request);
+        public static WSFederationMessage CreateFromNameValueCollection(Uri baseUrl, NameValueCollection collection);
+        public static WSFederationMessage CreateFromUri(Uri requestUri);
+        public static bool TryCreateFromUri(Uri requestUri, out WSFederationMessage fedMsg);
+    }
+    public class WSFederationMessageException : Exception {
+        public WSFederationMessageException();
+        protected WSFederationMessageException(SerializationInfo info, StreamingContext context);
+        public WSFederationMessageException(string message);
+        public WSFederationMessageException(string message, Exception inner);
+    }
+    public class WSFederationSerializer {
+        public WSFederationSerializer();
+        public WSFederationSerializer(WSTrustRequestSerializer requestSerializer, WSTrustResponseSerializer responseSerializer);
+        public WSFederationSerializer(XmlDictionaryReader reader);
+        public virtual bool CanReadRequest(string trustMessage);
+        public virtual bool CanReadResponse(string trustMessage);
+        public virtual RequestSecurityToken CreateRequest(FederationMessage message, WSTrustSerializationContext context);
+        public virtual RequestSecurityTokenResponse CreateResponse(FederationMessage message, WSTrustSerializationContext context);
+        public virtual string GetReferencedRequest(string wreqptr);
+        public virtual string GetReferencedResult(string wresultptr);
+        public virtual string GetRequestAsString(RequestSecurityToken request, WSTrustSerializationContext context);
+        public virtual string GetResponseAsString(RequestSecurityTokenResponse response, WSTrustSerializationContext context);
+    }
+}
```

