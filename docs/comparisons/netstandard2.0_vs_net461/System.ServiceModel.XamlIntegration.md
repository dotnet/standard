# System.ServiceModel.XamlIntegration

``` diff
+namespace System.ServiceModel.XamlIntegration {
+    public class EndpointIdentityConverter : TypeConverter {
+        public EndpointIdentityConverter();
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public class ServiceXNameTypeConverter : TypeConverter {
+        public ServiceXNameTypeConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public class SpnEndpointIdentityExtension : MarkupExtension {
+        public SpnEndpointIdentityExtension();
+        public SpnEndpointIdentityExtension(SpnEndpointIdentity identity);
+        public string SpnName { get; set; }
+        public override object ProvideValue(IServiceProvider serviceProvider);
+    }
+    public class UpnEndpointIdentityExtension : MarkupExtension {
+        public UpnEndpointIdentityExtension();
+        public UpnEndpointIdentityExtension(UpnEndpointIdentity identity);
+        public string UpnName { get; set; }
+        public override object ProvideValue(IServiceProvider serviceProvider);
+    }
+    public class XPathMessageContextMarkupExtension : MarkupExtension {
+        public XPathMessageContextMarkupExtension();
+        public XPathMessageContextMarkupExtension(XPathMessageContext context);
+        public Dictionary<string, string> Namespaces { get; }
+        public override object ProvideValue(IServiceProvider serviceProvider);
+    }
+    public class XPathMessageContextTypeConverter : TypeConverter {
+        public XPathMessageContextTypeConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+}
```

