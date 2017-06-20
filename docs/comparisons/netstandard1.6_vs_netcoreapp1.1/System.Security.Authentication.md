# System.Security.Authentication

``` diff
 namespace System.Security.Authentication {
+    public class AuthenticationException : Exception {
+        public AuthenticationException();
+        public AuthenticationException(string message);
+        public AuthenticationException(string message, Exception innerException);
+    }
+    public class InvalidCredentialException : AuthenticationException {
+        public InvalidCredentialException();
+        public InvalidCredentialException(string message);
+        public InvalidCredentialException(string message, Exception innerException);
+    }
 }
```

