# System.Runtime.Hosting

``` diff
+namespace System.Runtime.Hosting {
+    public sealed class ActivationArguments : EvidenceBase {
+        public ActivationArguments(ActivationContext activationData);
+        public ActivationArguments(ActivationContext activationContext, string[] activationData);
+        public ActivationArguments(ApplicationIdentity applicationIdentity);
+        public ActivationArguments(ApplicationIdentity applicationIdentity, string[] activationData);
+        public ActivationContext ActivationContext { get; }
+        public string[] ActivationData { get; }
+        public ApplicationIdentity ApplicationIdentity { get; }
+        public override EvidenceBase Clone();
+    }
+    public class ApplicationActivator {
+        public ApplicationActivator();
+        public virtual ObjectHandle CreateInstance(ActivationContext activationContext);
+        public virtual ObjectHandle CreateInstance(ActivationContext activationContext, string[] activationCustomData);
+        protected static ObjectHandle CreateInstanceHelper(AppDomainSetup adSetup);
+    }
+}
```

