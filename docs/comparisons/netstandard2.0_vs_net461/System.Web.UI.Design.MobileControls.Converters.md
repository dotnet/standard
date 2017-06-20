# System.Web.UI.Design.MobileControls.Converters

``` diff
+namespace System.Web.UI.Design.MobileControls.Converters {
+    public class DataFieldConverter : TypeConverter {
+        public DataFieldConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context);
+        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context);
+        public override bool GetStandardValuesSupported(ITypeDescriptorContext context);
+    }
+    public class DataMemberConverter : TypeConverter {
+        public DataMemberConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context);
+        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context);
+        public override bool GetStandardValuesSupported(ITypeDescriptorContext context);
+    }
+}
```

