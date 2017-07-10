# System.ServiceModel.Activation.Configuration

``` diff
+namespace System.ServiceModel.Activation.Configuration {
+    public sealed class DiagnosticSection : ConfigurationSection {
+        public DiagnosticSection();
+        public bool PerformanceCountersEnabled { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class NetPipeSection : ConfigurationSection {
+        public NetPipeSection();
+        public SecurityIdentifierElementCollection AllowAccounts { get; }
+        public int MaxPendingAccepts { get; set; }
+        public int MaxPendingConnections { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public TimeSpan ReceiveTimeout { get; set; }
+        protected override void InitializeDefault();
+    }
+    public sealed class NetTcpSection : ConfigurationSection {
+        public NetTcpSection();
+        public SecurityIdentifierElementCollection AllowAccounts { get; }
+        public int ListenBacklog { get; set; }
+        public int MaxPendingAccepts { get; set; }
+        public int MaxPendingConnections { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public TimeSpan ReceiveTimeout { get; set; }
+        public bool TeredoEnabled { get; set; }
+        protected override void InitializeDefault();
+    }
+    public sealed class SecurityIdentifierElement : ConfigurationElement {
+        public SecurityIdentifierElement();
+        public SecurityIdentifierElement(SecurityIdentifier sid);
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public SecurityIdentifier SecurityIdentifier { get; set; }
+    }
+    public sealed class SecurityIdentifierElementCollection : ServiceModelConfigurationElementCollection<SecurityIdentifierElement> {
+        public SecurityIdentifierElementCollection();
+        protected override object GetElementKey(ConfigurationElement element);
+    }
+    public sealed class ServiceModelActivationSectionGroup : ConfigurationSectionGroup {
+        public ServiceModelActivationSectionGroup();
+        public DiagnosticSection Diagnostics { get; }
+        public NetPipeSection NetPipe { get; }
+        public NetTcpSection NetTcp { get; }
+        public static ServiceModelActivationSectionGroup GetSectionGroup(Configuration config);
+    }
+}
```

