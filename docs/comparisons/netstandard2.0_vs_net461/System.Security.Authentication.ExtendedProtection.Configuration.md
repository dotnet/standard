# System.Security.Authentication.ExtendedProtection.Configuration

``` diff
+namespace System.Security.Authentication.ExtendedProtection.Configuration {
+    public sealed class ExtendedProtectionPolicyElement : ConfigurationElement {
+        public ExtendedProtectionPolicyElement();
+        public ServiceNameElementCollection CustomServiceNames { get; }
+        public PolicyEnforcement PolicyEnforcement { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public ProtectionScenario ProtectionScenario { get; set; }
+        public ExtendedProtectionPolicy BuildPolicy();
+    }
+    public sealed class ServiceNameElement : ConfigurationElement {
+        public ServiceNameElement();
+        public string Name { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class ServiceNameElementCollection : ConfigurationElementCollection {
+        public ServiceNameElementCollection();
+        public ServiceNameElement this[int index] { get; set; }
+        public new ServiceNameElement this[string name] { get; set; }
+        public void Add(ServiceNameElement element);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public int IndexOf(ServiceNameElement element);
+        public void Remove(ServiceNameElement element);
+        public void Remove(string name);
+        public void RemoveAt(int index);
+    }
+}
```

