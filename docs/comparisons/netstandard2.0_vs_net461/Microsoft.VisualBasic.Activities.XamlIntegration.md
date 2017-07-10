# Microsoft.VisualBasic.Activities.XamlIntegration

``` diff
+namespace Microsoft.VisualBasic.Activities.XamlIntegration {
+    public sealed class VisualBasicSettingsConverter : TypeConverter {
+        public VisualBasicSettingsConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public sealed class VisualBasicSettingsValueSerializer : ValueSerializer {
+        public VisualBasicSettingsValueSerializer();
+        public override bool CanConvertToString(object value, IValueSerializerContext context);
+        public override string ConvertToString(object value, IValueSerializerContext context);
+    }
+}
```

