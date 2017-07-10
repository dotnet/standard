# System.Security.Authentication.ExtendedProtection

``` diff
 namespace System.Security.Authentication.ExtendedProtection {
+    public class TokenBinding {
+        public TokenBindingType BindingType { get; private set; }
+        public byte[] GetRawTokenBindingId();
+    }
+    public enum TokenBindingType {
+        Provided = 0,
+        Referred = 1,
+    }
 }
```

