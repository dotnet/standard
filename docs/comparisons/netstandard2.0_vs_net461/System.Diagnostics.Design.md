# System.Diagnostics.Design

``` diff
+namespace System.Diagnostics.Design {
+    public class LogConverter : TypeConverter {
+        public LogConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context);
+        public override bool GetStandardValuesSupported(ITypeDescriptorContext context);
+    }
+    public class ProcessDesigner : ComponentDesigner {
+        public ProcessDesigner();
+        protected override void PreFilterProperties(IDictionary properties);
+    }
+    public class ProcessModuleDesigner : ComponentDesigner {
+        public ProcessModuleDesigner();
+        protected override void PreFilterProperties(IDictionary properties);
+    }
+    public class ProcessThreadDesigner : ComponentDesigner {
+        public ProcessThreadDesigner();
+        protected override void PreFilterProperties(IDictionary properties);
+    }
+}
```

