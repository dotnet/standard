# System.Deployment.Internal

``` diff
+namespace System.Deployment.Internal {
+    public static class InternalActivationContextHelper {
+        public static object GetActivationContextData(ActivationContext appInfo);
+        public static object GetApplicationComponentManifest(ActivationContext appInfo);
+        public static byte[] GetApplicationManifestBytes(ActivationContext appInfo);
+        public static object GetDeploymentComponentManifest(ActivationContext appInfo);
+        public static byte[] GetDeploymentManifestBytes(ActivationContext appInfo);
+        public static bool IsFirstRun(ActivationContext appInfo);
+        public static void PrepareForExecution(ActivationContext appInfo);
+    }
+    public static class InternalApplicationIdentityHelper {
+        public static object GetInternalAppId(ApplicationIdentity id);
+    }
+}
```

