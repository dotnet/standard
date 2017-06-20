# System.Security.Claims

``` diff
 namespace System.Security.Claims {
+    public class AuthenticationInformation {
+        public AuthenticationInformation();
+        public string Address { get; set; }
+        public Collection<AuthenticationContext> AuthorizationContexts { get; }
+        public string DnsName { get; set; }
+        public Nullable<DateTime> NotOnOrAfter { get; set; }
+        public string Session { get; set; }
+    }
+    public static class AuthenticationTypes {
+        public const string Basic = "Basic";
+        public const string Federation = "Federation";
+        public const string Kerberos = "Kerberos";
+        public const string Negotiate = "Negotiate";
+        public const string Password = "Password";
+        public const string Signature = "Signature";
+        public const string Windows = "Windows";
+        public const string X509 = "X509";
+    }
+    public class AuthorizationContext {
+        public AuthorizationContext(ClaimsPrincipal principal, Collection<Claim> resource, Collection<Claim> action);
+        public AuthorizationContext(ClaimsPrincipal principal, string resource, string action);
+        public Collection<Claim> Action { get; }
+        public ClaimsPrincipal Principal { get; }
+        public Collection<Claim> Resource { get; }
+    }
+    public static class ClaimProperties {
+        public const string Namespace = "http://schemas.xmlsoap.org/ws/2005/05/identity/claimproperties";
+        public const string SamlAttributeDisplayName = "http://schemas.xmlsoap.org/ws/2005/05/identity/claimproperties/displayname";
+        public const string SamlAttributeNameFormat = "http://schemas.xmlsoap.org/ws/2005/05/identity/claimproperties/attributename";
+        public const string SamlNameIdentifierFormat = "http://schemas.xmlsoap.org/ws/2005/05/identity/claimproperties/format";
+        public const string SamlNameIdentifierNameQualifier = "http://schemas.xmlsoap.org/ws/2005/05/identity/claimproperties/namequalifier";
+        public const string SamlNameIdentifierSPNameQualifier = "http://schemas.xmlsoap.org/ws/2005/05/identity/claimproperties/spnamequalifier";
+        public const string SamlNameIdentifierSPProvidedId = "http://schemas.xmlsoap.org/ws/2005/05/identity/claimproperties/spprovidedid";
+    }
+    public class ClaimsAuthenticationManager : ICustomIdentityConfiguration {
+        public ClaimsAuthenticationManager();
+        public virtual ClaimsPrincipal Authenticate(string resourceName, ClaimsPrincipal incomingPrincipal);
+        public virtual void LoadCustomConfiguration(XmlNodeList nodelist);
+    }
+    public class ClaimsAuthorizationManager : ICustomIdentityConfiguration {
+        public ClaimsAuthorizationManager();
+        public virtual bool CheckAccess(AuthorizationContext context);
+        public virtual void LoadCustomConfiguration(XmlNodeList nodelist);
+    }
+    public static class DynamicRoleClaimProvider {
+        public static void AddDynamicRoleClaims(ClaimsIdentity claimsIdentity, IEnumerable<Claim> claims);
+    }
 }
```

