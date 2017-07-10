# System.ServiceProcess.Design

``` diff
+namespace System.ServiceProcess.Design {
+    public class ServiceControllerDesigner : ComponentDesigner {
+        public ServiceControllerDesigner();
+        protected override void PreFilterProperties(IDictionary properties);
+    }
+    public class ServiceInstallerDialog : Form {
+        public ServiceInstallerDialog();
+        public string Password { get; set; }
+        public ServiceInstallerDialogResult Result { get; }
+        public string Username { get; set; }
+        public static void Main();
+    }
+    public enum ServiceInstallerDialogResult {
+        Canceled = 2,
+        OK = 0,
+        UseSystem = 1,
+    }
+}
```

