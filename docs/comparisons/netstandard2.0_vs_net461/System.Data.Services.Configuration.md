# System.Data.Services.Configuration

``` diff
+namespace System.Data.Services.Configuration {
+    public sealed class DataServicesFeaturesSection : ConfigurationSection {
+        public DataServicesFeaturesSection();
+        public DataServicesReplaceFunctionFeature ReplaceFunction { get; set; }
+    }
+    public class DataServicesReplaceFunctionFeature : ConfigurationElement {
+        public DataServicesReplaceFunctionFeature();
+        public bool Enable { get; set; }
+    }
+    public sealed class DataServicesSectionGroup : ConfigurationSectionGroup {
+        public DataServicesSectionGroup();
+        public DataServicesFeaturesSection Features { get; }
+    }
+}
```

