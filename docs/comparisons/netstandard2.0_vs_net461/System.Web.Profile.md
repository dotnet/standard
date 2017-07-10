# System.Web.Profile

``` diff
+namespace System.Web.Profile {
+    public sealed class CustomProviderDataAttribute : Attribute {
+        public CustomProviderDataAttribute(string customProviderData);
+        public string CustomProviderData { get; }
+        public override bool IsDefaultAttribute();
+    }
+    public class DefaultProfile : ProfileBase {
+        public DefaultProfile();
+    }
+    public enum ProfileAuthenticationOption {
+        All = 2,
+        Anonymous = 0,
+        Authenticated = 1,
+    }
+    public sealed class ProfileAutoSaveEventArgs : EventArgs {
+        public ProfileAutoSaveEventArgs(HttpContext context);
+        public HttpContext Context { get; }
+        public bool ContinueWithProfileAutoSave { get; set; }
+    }
+    public delegate void ProfileAutoSaveEventHandler(object sender, ProfileAutoSaveEventArgs e);
+    public class ProfileBase : SettingsBase {
+        public ProfileBase();
+        public bool IsAnonymous { get; }
+        public bool IsDirty { get; }
+        public DateTime LastActivityDate { get; }
+        public DateTime LastUpdatedDate { get; }
+        public static new SettingsPropertyCollection Properties { get; }
+        public override object this[string propertyName] { get; set; }
+        public string UserName { get; }
+        public static ProfileBase Create(string username);
+        public static ProfileBase Create(string username, bool isAuthenticated);
+        public ProfileGroupBase GetProfileGroup(string groupName);
+        public object GetPropertyValue(string propertyName);
+        public void Initialize(string username, bool isAuthenticated);
+        public override void Save();
+        public void SetPropertyValue(string propertyName, object propertyValue);
+    }
+    public sealed class ProfileEventArgs : EventArgs {
+        public ProfileEventArgs(HttpContext context);
+        public HttpContext Context { get; }
+        public ProfileBase Profile { get; set; }
+    }
+    public delegate void ProfileEventHandler(object sender, ProfileEventArgs e);
+    public class ProfileGroupBase {
+        public ProfileGroupBase();
+        public object this[string propertyName] { get; set; }
+        public object GetPropertyValue(string propertyName);
+        public void Init(ProfileBase parent, string myName);
+        public void SetPropertyValue(string propertyName, object propertyValue);
+    }
+    public class ProfileInfo {
+        protected ProfileInfo();
+        public ProfileInfo(string username, bool isAnonymous, DateTime lastActivityDate, DateTime lastUpdatedDate, int size);
+        public virtual bool IsAnonymous { get; }
+        public virtual DateTime LastActivityDate { get; }
+        public virtual DateTime LastUpdatedDate { get; }
+        public virtual int Size { get; }
+        public virtual string UserName { get; }
+    }
+    public sealed class ProfileInfoCollection : ICollection, IEnumerable {
+        public ProfileInfoCollection();
+        public int Count { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        public ProfileInfo this[string name] { get; }
+        public void Add(ProfileInfo profileInfo);
+        public void Clear();
+        public void CopyTo(Array array, int index);
+        public void CopyTo(ProfileInfo[] array, int index);
+        public IEnumerator GetEnumerator();
+        public void Remove(string name);
+        public void SetReadOnly();
+    }
+    public static class ProfileManager {
+        public static string ApplicationName { get; set; }
+        public static bool AutomaticSaveEnabled { get; }
+        public static bool Enabled { get; }
+        public static ProfileProvider Provider { get; }
+        public static ProfileProviderCollection Providers { get; }
+        public static void AddDynamicProfileProperty(ProfilePropertySettings property);
+        public static int DeleteInactiveProfiles(ProfileAuthenticationOption authenticationOption, DateTime userInactiveSinceDate);
+        public static bool DeleteProfile(string username);
+        public static int DeleteProfiles(string[] usernames);
+        public static int DeleteProfiles(ProfileInfoCollection profiles);
+        public static ProfileInfoCollection FindInactiveProfilesByUserName(ProfileAuthenticationOption authenticationOption, string usernameToMatch, DateTime userInactiveSinceDate);
+        public static ProfileInfoCollection FindInactiveProfilesByUserName(ProfileAuthenticationOption authenticationOption, string usernameToMatch, DateTime userInactiveSinceDate, int pageIndex, int pageSize, out int totalRecords);
+        public static ProfileInfoCollection FindProfilesByUserName(ProfileAuthenticationOption authenticationOption, string usernameToMatch);
+        public static ProfileInfoCollection FindProfilesByUserName(ProfileAuthenticationOption authenticationOption, string usernameToMatch, int pageIndex, int pageSize, out int totalRecords);
+        public static ProfileInfoCollection GetAllInactiveProfiles(ProfileAuthenticationOption authenticationOption, DateTime userInactiveSinceDate);
+        public static ProfileInfoCollection GetAllInactiveProfiles(ProfileAuthenticationOption authenticationOption, DateTime userInactiveSinceDate, int pageIndex, int pageSize, out int totalRecords);
+        public static ProfileInfoCollection GetAllProfiles(ProfileAuthenticationOption authenticationOption);
+        public static ProfileInfoCollection GetAllProfiles(ProfileAuthenticationOption authenticationOption, int pageIndex, int pageSize, out int totalRecords);
+        public static int GetNumberOfInactiveProfiles(ProfileAuthenticationOption authenticationOption, DateTime userInactiveSinceDate);
+        public static int GetNumberOfProfiles(ProfileAuthenticationOption authenticationOption);
+    }
+    public sealed class ProfileMigrateEventArgs : EventArgs {
+        public ProfileMigrateEventArgs(HttpContext context, string anonymousId);
+        public string AnonymousID { get; }
+        public HttpContext Context { get; }
+    }
+    public delegate void ProfileMigrateEventHandler(object sender, ProfileMigrateEventArgs e);
+    public sealed class ProfileModule : IHttpModule {
+        public ProfileModule();
+        public event ProfileMigrateEventHandler MigrateAnonymous;
+        public event ProfileEventHandler Personalize;
+        public event ProfileAutoSaveEventHandler ProfileAutoSaving;
+        public void Dispose();
+        public void Init(HttpApplication app);
+    }
+    public abstract class ProfileProvider : SettingsProvider {
+        protected ProfileProvider();
+        public abstract int DeleteInactiveProfiles(ProfileAuthenticationOption authenticationOption, DateTime userInactiveSinceDate);
+        public abstract int DeleteProfiles(string[] usernames);
+        public abstract int DeleteProfiles(ProfileInfoCollection profiles);
+        public abstract ProfileInfoCollection FindInactiveProfilesByUserName(ProfileAuthenticationOption authenticationOption, string usernameToMatch, DateTime userInactiveSinceDate, int pageIndex, int pageSize, out int totalRecords);
+        public abstract ProfileInfoCollection FindProfilesByUserName(ProfileAuthenticationOption authenticationOption, string usernameToMatch, int pageIndex, int pageSize, out int totalRecords);
+        public abstract ProfileInfoCollection GetAllInactiveProfiles(ProfileAuthenticationOption authenticationOption, DateTime userInactiveSinceDate, int pageIndex, int pageSize, out int totalRecords);
+        public abstract ProfileInfoCollection GetAllProfiles(ProfileAuthenticationOption authenticationOption, int pageIndex, int pageSize, out int totalRecords);
+        public abstract int GetNumberOfInactiveProfiles(ProfileAuthenticationOption authenticationOption, DateTime userInactiveSinceDate);
+    }
+    public sealed class ProfileProviderAttribute : Attribute {
+        public ProfileProviderAttribute(string providerName);
+        public string ProviderName { get; }
+    }
+    public sealed class ProfileProviderCollection : SettingsProviderCollection {
+        public ProfileProviderCollection();
+        public new ProfileProvider this[string name] { get; }
+        public override void Add(ProviderBase provider);
+    }
+    public sealed class SettingsAllowAnonymousAttribute : Attribute {
+        public SettingsAllowAnonymousAttribute(bool allow);
+        public bool Allow { get; }
+        public override bool IsDefaultAttribute();
+    }
+    public class SqlProfileProvider : ProfileProvider {
+        public SqlProfileProvider();
+        public override string ApplicationName { get; set; }
+        public override int DeleteInactiveProfiles(ProfileAuthenticationOption authenticationOption, DateTime userInactiveSinceDate);
+        public override int DeleteProfiles(string[] usernames);
+        public override int DeleteProfiles(ProfileInfoCollection profiles);
+        public override ProfileInfoCollection FindInactiveProfilesByUserName(ProfileAuthenticationOption authenticationOption, string usernameToMatch, DateTime userInactiveSinceDate, int pageIndex, int pageSize, out int totalRecords);
+        public override ProfileInfoCollection FindProfilesByUserName(ProfileAuthenticationOption authenticationOption, string usernameToMatch, int pageIndex, int pageSize, out int totalRecords);
+        public override ProfileInfoCollection GetAllInactiveProfiles(ProfileAuthenticationOption authenticationOption, DateTime userInactiveSinceDate, int pageIndex, int pageSize, out int totalRecords);
+        public override ProfileInfoCollection GetAllProfiles(ProfileAuthenticationOption authenticationOption, int pageIndex, int pageSize, out int totalRecords);
+        public override int GetNumberOfInactiveProfiles(ProfileAuthenticationOption authenticationOption, DateTime userInactiveSinceDate);
+        public override SettingsPropertyValueCollection GetPropertyValues(SettingsContext sc, SettingsPropertyCollection properties);
+        public override void Initialize(string name, NameValueCollection config);
+        public override void SetPropertyValues(SettingsContext sc, SettingsPropertyValueCollection properties);
+    }
+}
```

