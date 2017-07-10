# System.Drawing.Configuration

``` diff
+namespace System.Drawing.Configuration {
+    public sealed class SystemDrawingSection : ConfigurationSection {
+        public SystemDrawingSection();
+        public string BitmapSuffix { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+}
```

