# System.Web.ApplicationServices

``` diff
+namespace System.Web.ApplicationServices {
+    public class ApplicationServicesHostFactory : ServiceHostFactory {
+        public ApplicationServicesHostFactory();
+        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses);
+    }
+    public class AuthenticatingEventArgs : EventArgs {
+        public bool Authenticated { get; set; }
+        public bool AuthenticationIsComplete { get; set; }
+        public string CustomCredential { get; }
+        public string Password { get; }
+        public string UserName { get; }
+    }
+    public class AuthenticationService {
+        public AuthenticationService();
+        public static event EventHandler<AuthenticatingEventArgs> Authenticating;
+        public static event EventHandler<CreatingCookieEventArgs> CreatingCookie;
+        public bool IsLoggedIn();
+        public bool Login(string username, string password, string customCredential, bool isPersistent);
+        public void Logout();
+        public bool ValidateUser(string username, string password, string customCredential);
+    }
+    public class CreatingCookieEventArgs : EventArgs {
+        public bool CookieIsSet { get; set; }
+        public string CustomCredential { get; }
+        public bool IsPersistent { get; }
+        public string Password { get; }
+        public string UserName { get; }
+    }
+    public static class KnownTypesProvider {
+        public static Type[] GetKnownTypes(ICustomAttributeProvider knownTypeAttributeTarget);
+    }
+    public class ProfilePropertyMetadata : IExtensibleDataObject {
+        public ProfilePropertyMetadata();
+        public bool AllowAnonymousAccess { get; set; }
+        public string DefaultValue { get; set; }
+        public ExtensionDataObject ExtensionData { get; set; }
+        public bool IsReadOnly { get; set; }
+        public string PropertyName { get; set; }
+        public int SerializeAs { get; set; }
+        public string TypeName { get; set; }
+    }
+    public class ProfileService {
+        public ProfileService();
+        public static event EventHandler<ValidatingPropertiesEventArgs> ValidatingProperties;
+        public Dictionary<string, object> GetAllPropertiesForCurrentUser(bool authenticatedUserOnly);
+        public Dictionary<string, object> GetPropertiesForCurrentUser(IEnumerable<string> properties, bool authenticatedUserOnly);
+        public ProfilePropertyMetadata[] GetPropertiesMetadata();
+        public Collection<string> SetPropertiesForCurrentUser(IDictionary<string, object> values, bool authenticatedUserOnly);
+    }
+    public class RoleService {
+        public RoleService();
+        public static event EventHandler<SelectingProviderEventArgs> SelectingProvider;
+        public string[] GetRolesForCurrentUser();
+        public bool IsCurrentUserInRole(string role);
+    }
+    public class SelectingProviderEventArgs : EventArgs {
+        public string ProviderName { get; set; }
+        public IPrincipal User { get; }
+    }
+    public class ValidatingPropertiesEventArgs : EventArgs {
+        public Collection<string> FailedProperties { get; }
+        public IDictionary<string, object> Properties { get; }
+    }
+}
```

