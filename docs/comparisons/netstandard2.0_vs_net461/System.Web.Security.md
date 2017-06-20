# System.Web.Security

``` diff
+namespace System.Web.Security {
+    public enum ActiveDirectoryConnectionProtection {
+        None = 0,
+        SignAndSeal = 2,
+        Ssl = 1,
+    }
+    public class ActiveDirectoryMembershipProvider : MembershipProvider {
+        public ActiveDirectoryMembershipProvider();
+        public override string ApplicationName { get; set; }
+        public ActiveDirectoryConnectionProtection CurrentConnectionProtection { get; }
+        public override bool EnablePasswordReset { get; }
+        public override bool EnablePasswordRetrieval { get; }
+        public bool EnableSearchMethods { get; }
+        public override int MaxInvalidPasswordAttempts { get; }
+        public override int MinRequiredNonAlphanumericCharacters { get; }
+        public override int MinRequiredPasswordLength { get; }
+        public int PasswordAnswerAttemptLockoutDuration { get; }
+        public override int PasswordAttemptWindow { get; }
+        public override MembershipPasswordFormat PasswordFormat { get; }
+        public override string PasswordStrengthRegularExpression { get; }
+        public override bool RequiresQuestionAndAnswer { get; }
+        public override bool RequiresUniqueEmail { get; }
+        public override bool ChangePassword(string username, string oldPassword, string newPassword);
+        public override bool ChangePasswordQuestionAndAnswer(string username, string password, string newPasswordQuestion, string newPasswordAnswer);
+        public override MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved, object providerUserKey, out MembershipCreateStatus status);
+        public override bool DeleteUser(string username, bool deleteAllRelatedData);
+        public override MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords);
+        public override MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords);
+        public virtual string GeneratePassword();
+        public override MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords);
+        public override int GetNumberOfUsersOnline();
+        public override string GetPassword(string username, string passwordAnswer);
+        public override MembershipUser GetUser(object providerUserKey, bool userIsOnline);
+        public override MembershipUser GetUser(string username, bool userIsOnline);
+        public override string GetUserNameByEmail(string email);
+        public override void Initialize(string name, NameValueCollection config);
+        public override string ResetPassword(string username, string passwordAnswer);
+        public override bool UnlockUser(string username);
+        public override void UpdateUser(MembershipUser user);
+        public override bool ValidateUser(string username, string password);
+    }
+    public class ActiveDirectoryMembershipUser : MembershipUser {
+        protected ActiveDirectoryMembershipUser();
+        public ActiveDirectoryMembershipUser(string providerName, string name, object providerUserKey, string email, string passwordQuestion, string comment, bool isApproved, bool isLockedOut, DateTime creationDate, DateTime lastLoginDate, DateTime lastActivityDate, DateTime lastPasswordChangedDate, DateTime lastLockoutDate);
+        public override string Comment { get; set; }
+        public override string Email { get; set; }
+        public override bool IsApproved { get; set; }
+        public override DateTime LastActivityDate { get; set; }
+        public override DateTime LastLoginDate { get; set; }
+        public override object ProviderUserKey { get; }
+    }
+    public sealed class AnonymousIdentificationEventArgs : EventArgs {
+        public AnonymousIdentificationEventArgs(HttpContext context);
+        public string AnonymousID { get; set; }
+        public HttpContext Context { get; }
+    }
+    public delegate void AnonymousIdentificationEventHandler(object sender, AnonymousIdentificationEventArgs e);
+    public sealed class AnonymousIdentificationModule : IHttpModule {
+        public AnonymousIdentificationModule();
+        public static bool Enabled { get; }
+        public event AnonymousIdentificationEventHandler Creating;
+        public static void ClearAnonymousIdentifier();
+        public void Dispose();
+        public void Init(HttpApplication app);
+    }
+    public class AuthorizationStoreRoleProvider : RoleProvider {
+        public AuthorizationStoreRoleProvider();
+        public override string ApplicationName { get; set; }
+        public int CacheRefreshInterval { get; }
+        public string ScopeName { get; set; }
+        public override void AddUsersToRoles(string[] usernames, string[] roleNames);
+        public override void CreateRole(string roleName);
+        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole);
+        public override string[] FindUsersInRole(string roleName, string usernameToMatch);
+        public override string[] GetAllRoles();
+        public override string[] GetRolesForUser(string username);
+        public override string[] GetUsersInRole(string roleName);
+        public override void Initialize(string name, NameValueCollection config);
+        public override bool IsUserInRole(string username, string roleName);
+        public override void RemoveUsersFromRoles(string[] userNames, string[] roleNames);
+        public override bool RoleExists(string roleName);
+    }
+    public enum CookieProtection {
+        All = 3,
+        Encryption = 2,
+        None = 0,
+        Validation = 1,
+    }
+    public sealed class DefaultAuthenticationEventArgs : EventArgs {
+        public DefaultAuthenticationEventArgs(HttpContext context);
+        public HttpContext Context { get; }
+    }
+    public delegate void DefaultAuthenticationEventHandler(object sender, DefaultAuthenticationEventArgs e);
+    public sealed class DefaultAuthenticationModule : IHttpModule {
+        public DefaultAuthenticationModule();
+        public event DefaultAuthenticationEventHandler Authenticate;
+        public void Dispose();
+        public void Init(HttpApplication app);
+    }
+    public sealed class FileAuthorizationModule : IHttpModule {
+        public FileAuthorizationModule();
+        public static bool CheckFileAccessForUser(string virtualPath, IntPtr token, string verb);
+        public void Dispose();
+        public void Init(HttpApplication app);
+    }
+    public sealed class FormsAuthentication {
+        public FormsAuthentication();
+        public static string CookieDomain { get; }
+        public static HttpCookieMode CookieMode { get; }
+        public static bool CookiesSupported { get; }
+        public static string DefaultUrl { get; }
+        public static bool EnableCrossAppRedirects { get; }
+        public static string FormsCookieName { get; }
+        public static string FormsCookiePath { get; }
+        public static bool IsEnabled { get; }
+        public static string LoginUrl { get; }
+        public static bool RequireSSL { get; }
+        public static bool SlidingExpiration { get; }
+        public static TicketCompatibilityMode TicketCompatibilityMode { get; }
+        public static TimeSpan Timeout { get; }
+        public static bool Authenticate(string name, string password);
+        public static FormsAuthenticationTicket Decrypt(string encryptedTicket);
+        public static void EnableFormsAuthentication(NameValueCollection configurationData);
+        public static string Encrypt(FormsAuthenticationTicket ticket);
+        public static HttpCookie GetAuthCookie(string userName, bool createPersistentCookie);
+        public static HttpCookie GetAuthCookie(string userName, bool createPersistentCookie, string strCookiePath);
+        public static string GetRedirectUrl(string userName, bool createPersistentCookie);
+        public static string HashPasswordForStoringInConfigFile(string password, string passwordFormat);
+        public static void Initialize();
+        public static void RedirectFromLoginPage(string userName, bool createPersistentCookie);
+        public static void RedirectFromLoginPage(string userName, bool createPersistentCookie, string strCookiePath);
+        public static void RedirectToLoginPage();
+        public static void RedirectToLoginPage(string extraQueryString);
+        public static FormsAuthenticationTicket RenewTicketIfOld(FormsAuthenticationTicket tOld);
+        public static void SetAuthCookie(string userName, bool createPersistentCookie);
+        public static void SetAuthCookie(string userName, bool createPersistentCookie, string strCookiePath);
+        public static void SignOut();
+    }
+    public sealed class FormsAuthenticationEventArgs : EventArgs {
+        public FormsAuthenticationEventArgs(HttpContext context);
+        public HttpContext Context { get; }
+        public IPrincipal User { get; set; }
+    }
+    public delegate void FormsAuthenticationEventHandler(object sender, FormsAuthenticationEventArgs e);
+    public sealed class FormsAuthenticationModule : IHttpModule {
+        public FormsAuthenticationModule();
+        public event FormsAuthenticationEventHandler Authenticate;
+        public void Dispose();
+        public void Init(HttpApplication app);
+    }
+    public sealed class FormsAuthenticationTicket {
+        public FormsAuthenticationTicket(int version, string name, DateTime issueDate, DateTime expiration, bool isPersistent, string userData);
+        public FormsAuthenticationTicket(int version, string name, DateTime issueDate, DateTime expiration, bool isPersistent, string userData, string cookiePath);
+        public FormsAuthenticationTicket(string name, bool isPersistent, int timeout);
+        public string CookiePath { get; }
+        public DateTime Expiration { get; }
+        public bool Expired { get; }
+        public bool IsPersistent { get; }
+        public DateTime IssueDate { get; }
+        public string Name { get; }
+        public string UserData { get; }
+        public int Version { get; }
+    }
+    public class FormsIdentity : ClaimsIdentity {
+        public FormsIdentity(FormsAuthenticationTicket ticket);
+        protected FormsIdentity(FormsIdentity identity);
+        public override string AuthenticationType { get; }
+        public override IEnumerable<Claim> Claims { get; }
+        public override bool IsAuthenticated { get; }
+        public override string Name { get; }
+        public FormsAuthenticationTicket Ticket { get; }
+        public override ClaimsIdentity Clone();
+    }
+    public static class MachineKey {
+        public static byte[] Decode(string encodedData, MachineKeyProtection protectionOption);
+        public static string Encode(byte[] data, MachineKeyProtection protectionOption);
+        public static byte[] Protect(byte[] userData, params string[] purposes);
+        public static byte[] Unprotect(byte[] protectedData, params string[] purposes);
+    }
+    public enum MachineKeyProtection {
+        All = 0,
+        Encryption = 1,
+        Validation = 2,
+    }
+    public static class Membership {
+        public static string ApplicationName { get; set; }
+        public static bool EnablePasswordReset { get; }
+        public static bool EnablePasswordRetrieval { get; }
+        public static string HashAlgorithmType { get; }
+        public static int MaxInvalidPasswordAttempts { get; }
+        public static int MinRequiredNonAlphanumericCharacters { get; }
+        public static int MinRequiredPasswordLength { get; }
+        public static int PasswordAttemptWindow { get; }
+        public static string PasswordStrengthRegularExpression { get; }
+        public static MembershipProvider Provider { get; }
+        public static MembershipProviderCollection Providers { get; }
+        public static bool RequiresQuestionAndAnswer { get; }
+        public static int UserIsOnlineTimeWindow { get; }
+        public static event MembershipValidatePasswordEventHandler ValidatingPassword;
+        public static MembershipUser CreateUser(string username, string password);
+        public static MembershipUser CreateUser(string username, string password, string email);
+        public static MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved, object providerUserKey, out MembershipCreateStatus status);
+        public static MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved, out MembershipCreateStatus status);
+        public static bool DeleteUser(string username);
+        public static bool DeleteUser(string username, bool deleteAllRelatedData);
+        public static MembershipUserCollection FindUsersByEmail(string emailToMatch);
+        public static MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords);
+        public static MembershipUserCollection FindUsersByName(string usernameToMatch);
+        public static MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords);
+        public static string GeneratePassword(int length, int numberOfNonAlphanumericCharacters);
+        public static MembershipUserCollection GetAllUsers();
+        public static MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords);
+        public static int GetNumberOfUsersOnline();
+        public static MembershipUser GetUser();
+        public static MembershipUser GetUser(bool userIsOnline);
+        public static MembershipUser GetUser(object providerUserKey);
+        public static MembershipUser GetUser(object providerUserKey, bool userIsOnline);
+        public static MembershipUser GetUser(string username);
+        public static MembershipUser GetUser(string username, bool userIsOnline);
+        public static string GetUserNameByEmail(string emailToMatch);
+        public static void UpdateUser(MembershipUser user);
+        public static bool ValidateUser(string username, string password);
+    }
+    public enum MembershipCreateStatus {
+        DuplicateEmail = 7,
+        DuplicateProviderUserKey = 10,
+        DuplicateUserName = 6,
+        InvalidAnswer = 4,
+        InvalidEmail = 5,
+        InvalidPassword = 2,
+        InvalidProviderUserKey = 9,
+        InvalidQuestion = 3,
+        InvalidUserName = 1,
+        ProviderError = 11,
+        Success = 0,
+        UserRejected = 8,
+    }
+    public class MembershipCreateUserException : Exception {
+        public MembershipCreateUserException();
+        protected MembershipCreateUserException(SerializationInfo info, StreamingContext context);
+        public MembershipCreateUserException(string message);
+        public MembershipCreateUserException(string message, Exception innerException);
+        public MembershipCreateUserException(MembershipCreateStatus statusCode);
+        public MembershipCreateStatus StatusCode { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class MembershipPasswordAttribute : ValidationAttribute {
+        public MembershipPasswordAttribute();
+        public string MinNonAlphanumericCharactersError { get; set; }
+        public string MinPasswordLengthError { get; set; }
+        public int MinRequiredNonAlphanumericCharacters { get; set; }
+        public int MinRequiredPasswordLength { get; set; }
+        public string PasswordStrengthError { get; set; }
+        public Nullable<int> PasswordStrengthRegexTimeout { get; set; }
+        public string PasswordStrengthRegularExpression { get; set; }
+        public Type ResourceType { get; set; }
+        public override string FormatErrorMessage(string name);
+        protected override ValidationResult IsValid(object value, ValidationContext validationContext);
+    }
+    public class MembershipPasswordException : Exception {
+        public MembershipPasswordException();
+        protected MembershipPasswordException(SerializationInfo info, StreamingContext context);
+        public MembershipPasswordException(string message);
+        public MembershipPasswordException(string message, Exception innerException);
+    }
+    public enum MembershipPasswordFormat {
+        Clear = 0,
+        Encrypted = 2,
+        Hashed = 1,
+    }
+    public abstract class MembershipProvider : ProviderBase {
+        protected MembershipProvider();
+        public abstract string ApplicationName { get; set; }
+        public abstract bool EnablePasswordReset { get; }
+        public abstract bool EnablePasswordRetrieval { get; }
+        public abstract int MaxInvalidPasswordAttempts { get; }
+        public abstract int MinRequiredNonAlphanumericCharacters { get; }
+        public abstract int MinRequiredPasswordLength { get; }
+        public abstract int PasswordAttemptWindow { get; }
+        public abstract MembershipPasswordFormat PasswordFormat { get; }
+        public abstract string PasswordStrengthRegularExpression { get; }
+        public abstract bool RequiresQuestionAndAnswer { get; }
+        public abstract bool RequiresUniqueEmail { get; }
+        public event MembershipValidatePasswordEventHandler ValidatingPassword;
+        public abstract bool ChangePassword(string username, string oldPassword, string newPassword);
+        public abstract bool ChangePasswordQuestionAndAnswer(string username, string password, string newPasswordQuestion, string newPasswordAnswer);
+        public abstract MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved, object providerUserKey, out MembershipCreateStatus status);
+        protected virtual byte[] DecryptPassword(byte[] encodedPassword);
+        public abstract bool DeleteUser(string username, bool deleteAllRelatedData);
+        protected virtual byte[] EncryptPassword(byte[] password);
+        protected virtual byte[] EncryptPassword(byte[] password, MembershipPasswordCompatibilityMode legacyPasswordCompatibilityMode);
+        public abstract MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords);
+        public abstract MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords);
+        public abstract MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords);
+        public abstract int GetNumberOfUsersOnline();
+        public abstract string GetPassword(string username, string answer);
+        public abstract MembershipUser GetUser(object providerUserKey, bool userIsOnline);
+        public abstract MembershipUser GetUser(string username, bool userIsOnline);
+        public abstract string GetUserNameByEmail(string email);
+        protected virtual void OnValidatingPassword(ValidatePasswordEventArgs e);
+        public abstract string ResetPassword(string username, string answer);
+        public abstract bool UnlockUser(string userName);
+        public abstract void UpdateUser(MembershipUser user);
+        public abstract bool ValidateUser(string username, string password);
+    }
+    public sealed class MembershipProviderCollection : ProviderCollection {
+        public MembershipProviderCollection();
+        public new MembershipProvider this[string name] { get; }
+        public override void Add(ProviderBase provider);
+        public void CopyTo(MembershipProvider[] array, int index);
+    }
+    public class MembershipUser {
+        protected MembershipUser();
+        public MembershipUser(string providerName, string name, object providerUserKey, string email, string passwordQuestion, string comment, bool isApproved, bool isLockedOut, DateTime creationDate, DateTime lastLoginDate, DateTime lastActivityDate, DateTime lastPasswordChangedDate, DateTime lastLockoutDate);
+        public virtual string Comment { get; set; }
+        public virtual DateTime CreationDate { get; }
+        public virtual string Email { get; set; }
+        public virtual bool IsApproved { get; set; }
+        public virtual bool IsLockedOut { get; }
+        public virtual bool IsOnline { get; }
+        public virtual DateTime LastActivityDate { get; set; }
+        public virtual DateTime LastLockoutDate { get; }
+        public virtual DateTime LastLoginDate { get; set; }
+        public virtual DateTime LastPasswordChangedDate { get; }
+        public virtual string PasswordQuestion { get; }
+        public virtual string ProviderName { get; }
+        public virtual object ProviderUserKey { get; }
+        public virtual string UserName { get; }
+        public virtual bool ChangePassword(string oldPassword, string newPassword);
+        public virtual bool ChangePasswordQuestionAndAnswer(string password, string newPasswordQuestion, string newPasswordAnswer);
+        public virtual string GetPassword();
+        public virtual string GetPassword(string passwordAnswer);
+        public virtual string ResetPassword();
+        public virtual string ResetPassword(string passwordAnswer);
+        public override string ToString();
+        public virtual bool UnlockUser();
+    }
+    public sealed class MembershipUserCollection : ICollection, IEnumerable {
+        public MembershipUserCollection();
+        public int Count { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        public MembershipUser this[string name] { get; }
+        public void Add(MembershipUser user);
+        public void Clear();
+        public void CopyTo(MembershipUser[] array, int index);
+        public IEnumerator GetEnumerator();
+        public void Remove(string name);
+        public void SetReadOnly();
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+    }
+    public delegate void MembershipValidatePasswordEventHandler(object sender, ValidatePasswordEventArgs e);
+    public sealed class PassportAuthenticationEventArgs : EventArgs {
+        public PassportAuthenticationEventArgs(PassportIdentity identity, HttpContext context);
+        public HttpContext Context { get; }
+        public PassportIdentity Identity { get; }
+        public IPrincipal User { get; set; }
+    }
+    public delegate void PassportAuthenticationEventHandler(object sender, PassportAuthenticationEventArgs e);
+    public sealed class PassportAuthenticationModule : IHttpModule {
+        public PassportAuthenticationModule();
+        public event PassportAuthenticationEventHandler Authenticate;
+        public void Dispose();
+        public void Init(HttpApplication app);
+    }
+    public sealed class PassportIdentity : IDisposable, IIdentity {
+        public PassportIdentity();
+        public string AuthenticationType { get; }
+        public int Error { get; }
+        public bool GetFromNetworkServer { get; }
+        public bool HasSavedPassword { get; }
+        public bool HasTicket { get; }
+        public string HexPUID { get; }
+        public bool IsAuthenticated { get; }
+        public string Name { get; }
+        public string this[string strProfileName] { get; }
+        public int TicketAge { get; }
+        public int TimeSinceSignIn { get; }
+        public string AuthUrl();
+        public string AuthUrl(string strReturnUrl);
+        public string AuthUrl(string strReturnUrl, int iTimeWindow, bool fForceLogin, string strCoBrandedArgs, int iLangID, string strNameSpace, int iKPP, bool bUseSecureAuth);
+        public string AuthUrl(string strReturnUrl, int iTimeWindow, int iForceLogin, string strCoBrandedArgs, int iLangID, string strNameSpace, int iKPP, int iUseSecureAuth);
+        public string AuthUrl2();
+        public string AuthUrl2(string strReturnUrl);
+        public string AuthUrl2(string strReturnUrl, int iTimeWindow, bool fForceLogin, string strCoBrandedArgs, int iLangID, string strNameSpace, int iKPP, bool bUseSecureAuth);
+        public string AuthUrl2(string strReturnUrl, int iTimeWindow, int iForceLogin, string strCoBrandedArgs, int iLangID, string strNameSpace, int iKPP, int iUseSecureAuth);
+        public static string Compress(string strData);
+        public static bool CryptIsValid();
+        public static int CryptPutHost(string strHost);
+        public static int CryptPutSite(string strSite);
+        public static string Decompress(string strData);
+        public static string Decrypt(string strData);
+        public static string Encrypt(string strData);
+        ~PassportIdentity();
+        public object GetCurrentConfig(string strAttribute);
+        public string GetDomainAttribute(string strAttribute, int iLCID, string strDomain);
+        public string GetDomainFromMemberName(string strMemberName);
+        public bool GetIsAuthenticated(int iTimeWindow, bool bForceLogin, bool bCheckSecure);
+        public bool GetIsAuthenticated(int iTimeWindow, int iForceLogin, int iCheckSecure);
+        public string GetLoginChallenge();
+        public string GetLoginChallenge(string strReturnUrl);
+        public string GetLoginChallenge(string szRetURL, int iTimeWindow, int fForceLogin, string szCOBrandArgs, int iLangID, string strNameSpace, int iKPP, int iUseSecureAuth, object oExtraParams);
+        public object GetOption(string strOpt);
+        public object GetProfileObject(string strProfileName);
+        public bool HasFlag(int iFlagMask);
+        public bool HasProfile(string strProfile);
+        public bool HaveConsent(bool bNeedFullConsent, bool bNeedBirthdate);
+        public int LoginUser();
+        public int LoginUser(string strReturnUrl);
+        public int LoginUser(string szRetURL, int iTimeWindow, bool fForceLogin, string szCOBrandArgs, int iLangID, string strNameSpace, int iKPP, bool fUseSecureAuth, object oExtraParams);
+        public int LoginUser(string szRetURL, int iTimeWindow, int fForceLogin, string szCOBrandArgs, int iLangID, string strNameSpace, int iKPP, int iUseSecureAuth, object oExtraParams);
+        public string LogoTag();
+        public string LogoTag(string strReturnUrl);
+        public string LogoTag(string strReturnUrl, int iTimeWindow, bool fForceLogin, string strCoBrandedArgs, int iLangID, bool fSecure, string strNameSpace, int iKPP, bool bUseSecureAuth);
+        public string LogoTag(string strReturnUrl, int iTimeWindow, int iForceLogin, string strCoBrandedArgs, int iLangID, int iSecure, string strNameSpace, int iKPP, int iUseSecureAuth);
+        public string LogoTag2();
+        public string LogoTag2(string strReturnUrl);
+        public string LogoTag2(string strReturnUrl, int iTimeWindow, bool fForceLogin, string strCoBrandedArgs, int iLangID, bool fSecure, string strNameSpace, int iKPP, bool bUseSecureAuth);
+        public string LogoTag2(string strReturnUrl, int iTimeWindow, int iForceLogin, string strCoBrandedArgs, int iLangID, int iSecure, string strNameSpace, int iKPP, int iUseSecureAuth);
+        public string LogoutURL();
+        public string LogoutURL(string szReturnURL, string szCOBrandArgs, int iLangID, string strDomain, int iUseSecureAuth);
+        public void SetOption(string strOpt, object vOpt);
+        public static void SignOut(string strSignOutDotGifFileName);
+        void System.IDisposable.Dispose();
+        public object Ticket(string strAttribute);
+    }
+    public sealed class PassportPrincipal : GenericPrincipal {
+        public PassportPrincipal(PassportIdentity identity, string[] roles);
+    }
+    public sealed class RoleManagerEventArgs : EventArgs {
+        public RoleManagerEventArgs(HttpContext context);
+        public HttpContext Context { get; }
+        public bool RolesPopulated { get; set; }
+    }
+    public delegate void RoleManagerEventHandler(object sender, RoleManagerEventArgs e);
+    public sealed class RoleManagerModule : IHttpModule {
+        public RoleManagerModule();
+        public event RoleManagerEventHandler GetRoles;
+        public void Dispose();
+        public void Init(HttpApplication app);
+    }
+    public class RolePrincipal : ClaimsPrincipal, ISerializable {
+        protected RolePrincipal(SerializationInfo info, StreamingContext context);
+        public RolePrincipal(IIdentity identity);
+        public RolePrincipal(IIdentity identity, string encryptedTicket);
+        public RolePrincipal(string providerName, IIdentity identity);
+        public RolePrincipal(string providerName, IIdentity identity, string encryptedTicket);
+        public bool CachedListChanged { get; }
+        public string CookiePath { get; }
+        public bool Expired { get; }
+        public DateTime ExpireDate { get; }
+        public override IIdentity Identity { get; }
+        public bool IsRoleListCached { get; }
+        public DateTime IssueDate { get; }
+        public string ProviderName { get; }
+        public int Version { get; }
+        protected override void GetObjectData(SerializationInfo info, StreamingContext context);
+        public string[] GetRoles();
+        public override bool IsInRole(string role);
+        public void SetDirty();
+        void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context);
+        public string ToEncryptedTicket();
+    }
+    public abstract class RoleProvider : ProviderBase {
+        protected RoleProvider();
+        public abstract string ApplicationName { get; set; }
+        public abstract void AddUsersToRoles(string[] usernames, string[] roleNames);
+        public abstract void CreateRole(string roleName);
+        public abstract bool DeleteRole(string roleName, bool throwOnPopulatedRole);
+        public abstract string[] FindUsersInRole(string roleName, string usernameToMatch);
+        public abstract string[] GetAllRoles();
+        public abstract string[] GetRolesForUser(string username);
+        public abstract string[] GetUsersInRole(string roleName);
+        public abstract bool IsUserInRole(string username, string roleName);
+        public abstract void RemoveUsersFromRoles(string[] usernames, string[] roleNames);
+        public abstract bool RoleExists(string roleName);
+    }
+    public sealed class RoleProviderCollection : ProviderCollection {
+        public RoleProviderCollection();
+        public new RoleProvider this[string name] { get; }
+        public override void Add(ProviderBase provider);
+        public void CopyTo(RoleProvider[] array, int index);
+    }
+    public static class Roles {
+        public static string ApplicationName { get; set; }
+        public static bool CacheRolesInCookie { get; }
+        public static string CookieName { get; }
+        public static string CookiePath { get; }
+        public static CookieProtection CookieProtectionValue { get; }
+        public static bool CookieRequireSSL { get; }
+        public static bool CookieSlidingExpiration { get; }
+        public static int CookieTimeout { get; }
+        public static bool CreatePersistentCookie { get; }
+        public static string Domain { get; }
+        public static bool Enabled { get; set; }
+        public static int MaxCachedResults { get; }
+        public static RoleProvider Provider { get; }
+        public static RoleProviderCollection Providers { get; }
+        public static void AddUsersToRole(string[] usernames, string roleName);
+        public static void AddUsersToRoles(string[] usernames, string[] roleNames);
+        public static void AddUserToRole(string username, string roleName);
+        public static void AddUserToRoles(string username, string[] roleNames);
+        public static void CreateRole(string roleName);
+        public static void DeleteCookie();
+        public static bool DeleteRole(string roleName);
+        public static bool DeleteRole(string roleName, bool throwOnPopulatedRole);
+        public static string[] FindUsersInRole(string roleName, string usernameToMatch);
+        public static string[] GetAllRoles();
+        public static string[] GetRolesForUser();
+        public static string[] GetRolesForUser(string username);
+        public static string[] GetUsersInRole(string roleName);
+        public static bool IsUserInRole(string roleName);
+        public static bool IsUserInRole(string username, string roleName);
+        public static void RemoveUserFromRole(string username, string roleName);
+        public static void RemoveUserFromRoles(string username, string[] roleNames);
+        public static void RemoveUsersFromRole(string[] usernames, string roleName);
+        public static void RemoveUsersFromRoles(string[] usernames, string[] roleNames);
+        public static bool RoleExists(string roleName);
+    }
+    public class SqlMembershipProvider : MembershipProvider {
+        public SqlMembershipProvider();
+        public override string ApplicationName { get; set; }
+        public override bool EnablePasswordReset { get; }
+        public override bool EnablePasswordRetrieval { get; }
+        public override int MaxInvalidPasswordAttempts { get; }
+        public override int MinRequiredNonAlphanumericCharacters { get; }
+        public override int MinRequiredPasswordLength { get; }
+        public override int PasswordAttemptWindow { get; }
+        public override MembershipPasswordFormat PasswordFormat { get; }
+        public override string PasswordStrengthRegularExpression { get; }
+        public override bool RequiresQuestionAndAnswer { get; }
+        public override bool RequiresUniqueEmail { get; }
+        public override bool ChangePassword(string username, string oldPassword, string newPassword);
+        public override bool ChangePasswordQuestionAndAnswer(string username, string password, string newPasswordQuestion, string newPasswordAnswer);
+        public override MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved, object providerUserKey, out MembershipCreateStatus status);
+        public override bool DeleteUser(string username, bool deleteAllRelatedData);
+        public override MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords);
+        public override MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords);
+        public virtual string GeneratePassword();
+        public override MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords);
+        public override int GetNumberOfUsersOnline();
+        public override string GetPassword(string username, string passwordAnswer);
+        public override MembershipUser GetUser(object providerUserKey, bool userIsOnline);
+        public override MembershipUser GetUser(string username, bool userIsOnline);
+        public override string GetUserNameByEmail(string email);
+        public override void Initialize(string name, NameValueCollection config);
+        public override string ResetPassword(string username, string passwordAnswer);
+        public override bool UnlockUser(string username);
+        public override void UpdateUser(MembershipUser user);
+        public override bool ValidateUser(string username, string password);
+    }
+    public class SqlRoleProvider : RoleProvider {
+        public SqlRoleProvider();
+        public override string ApplicationName { get; set; }
+        public override void AddUsersToRoles(string[] usernames, string[] roleNames);
+        public override void CreateRole(string roleName);
+        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole);
+        public override string[] FindUsersInRole(string roleName, string usernameToMatch);
+        public override string[] GetAllRoles();
+        public override string[] GetRolesForUser(string username);
+        public override string[] GetUsersInRole(string roleName);
+        public override void Initialize(string name, NameValueCollection config);
+        public override bool IsUserInRole(string username, string roleName);
+        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames);
+        public override bool RoleExists(string roleName);
+    }
+    public sealed class UrlAuthorizationModule : IHttpModule {
+        public UrlAuthorizationModule();
+        public static bool CheckUrlAccessForPrincipal(string virtualPath, IPrincipal user, string verb);
+        public void Dispose();
+        public void Init(HttpApplication app);
+    }
+    public sealed class ValidatePasswordEventArgs : EventArgs {
+        public ValidatePasswordEventArgs(string userName, string password, bool isNewUser);
+        public bool Cancel { get; set; }
+        public Exception FailureInformation { get; set; }
+        public bool IsNewUser { get; }
+        public string Password { get; }
+        public string UserName { get; }
+    }
+    public sealed class WindowsAuthenticationEventArgs : EventArgs {
+        public WindowsAuthenticationEventArgs(WindowsIdentity identity, HttpContext context);
+        public HttpContext Context { get; }
+        public WindowsIdentity Identity { get; }
+        public IPrincipal User { get; set; }
+    }
+    public delegate void WindowsAuthenticationEventHandler(object sender, WindowsAuthenticationEventArgs e);
+    public sealed class WindowsAuthenticationModule : IHttpModule {
+        public WindowsAuthenticationModule();
+        public event WindowsAuthenticationEventHandler Authenticate;
+        public void Dispose();
+        public void Init(HttpApplication app);
+    }
+    public class WindowsTokenRoleProvider : RoleProvider {
+        public WindowsTokenRoleProvider();
+        public override string ApplicationName { get; set; }
+        public override void AddUsersToRoles(string[] usernames, string[] roleNames);
+        public override void CreateRole(string roleName);
+        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole);
+        public override string[] FindUsersInRole(string roleName, string usernameToMatch);
+        public override string[] GetAllRoles();
+        public override string[] GetRolesForUser(string username);
+        public override string[] GetUsersInRole(string roleName);
+        public override void Initialize(string name, NameValueCollection config);
+        public bool IsUserInRole(string username, WindowsBuiltInRole role);
+        public override bool IsUserInRole(string username, string roleName);
+        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames);
+        public override bool RoleExists(string roleName);
+    }
+}
```

