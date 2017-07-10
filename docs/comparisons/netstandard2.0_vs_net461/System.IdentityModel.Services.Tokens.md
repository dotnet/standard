# System.IdentityModel.Services.Tokens

``` diff
+namespace System.IdentityModel.Services.Tokens {
+    public class MachineKeySessionSecurityTokenHandler : SessionSecurityTokenHandler {
+        public MachineKeySessionSecurityTokenHandler();
+        public MachineKeySessionSecurityTokenHandler(TimeSpan tokenLifetime);
+    }
+    public class MembershipUserNameSecurityTokenHandler : UserNameSecurityTokenHandler {
+        public MembershipUserNameSecurityTokenHandler();
+        public MembershipUserNameSecurityTokenHandler(MembershipProvider provider);
+        public override bool CanValidateToken { get; }
+        public MembershipProvider MembershipProvider { get; set; }
+        public override void LoadCustomConfiguration(XmlNodeList customConfigElements);
+        public override ReadOnlyCollection<ClaimsIdentity> ValidateToken(SecurityToken token);
+    }
+}
```

