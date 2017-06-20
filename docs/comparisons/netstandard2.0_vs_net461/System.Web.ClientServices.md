# System.Web.ClientServices

``` diff
+namespace System.Web.ClientServices {
+    public class ClientFormsIdentity : IDisposable, IIdentity {
+        public ClientFormsIdentity(string name, string password, MembershipProvider provider, string authenticationType, bool isAuthenticated, CookieContainer authenticationCookies);
+        public CookieContainer AuthenticationCookies { get; }
+        public string AuthenticationType { get; }
+        public bool IsAuthenticated { get; }
+        public string Name { get; }
+        public MembershipProvider Provider { get; }
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        public void RevalidateUser();
+    }
+    public class ClientRolePrincipal : IPrincipal {
+        public ClientRolePrincipal(IIdentity identity);
+        public IIdentity Identity { get; }
+        public bool IsInRole(string role);
+    }
+    public static class ConnectivityStatus {
+        public static bool IsOffline { get; set; }
+    }
+}
```

