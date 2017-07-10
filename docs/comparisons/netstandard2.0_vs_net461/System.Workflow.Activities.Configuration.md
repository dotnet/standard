# System.Workflow.Activities.Configuration

``` diff
+namespace System.Workflow.Activities.Configuration {
+    public sealed class ActiveDirectoryRoleFactoryConfiguration : ConfigurationSection {
+        public ActiveDirectoryRoleFactoryConfiguration();
+        public string DirectReports { get; set; }
+        public string DistinguishedName { get; set; }
+        public string Group { get; set; }
+        public string Manager { get; set; }
+        public string Member { get; set; }
+        public string RootPath { get; set; }
+    }
+}
```

