# System.Transactions.Configuration

``` diff
+namespace System.Transactions.Configuration {
+    public sealed class DefaultSettingsSection : ConfigurationSection {
+        public DefaultSettingsSection();
+        public string DistributedTransactionManagerName { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public TimeSpan Timeout { get; set; }
+    }
+    public sealed class MachineSettingsSection : ConfigurationSection {
+        public MachineSettingsSection();
+        public TimeSpan MaxTimeout { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class TransactionsSectionGroup : ConfigurationSectionGroup {
+        public TransactionsSectionGroup();
+        public DefaultSettingsSection DefaultSettings { get; }
+        public MachineSettingsSection MachineSettings { get; }
+        public static TransactionsSectionGroup GetSectionGroup(Configuration config);
+    }
+}
```

