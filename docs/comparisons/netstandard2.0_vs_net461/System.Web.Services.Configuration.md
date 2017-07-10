# System.Web.Services.Configuration

``` diff
+namespace System.Web.Services.Configuration {
+    public sealed class DiagnosticsElement : ConfigurationElement {
+        public DiagnosticsElement();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public bool SuppressReturningExceptions { get; set; }
+    }
+    public enum PriorityGroup {
+        High = 0,
+        Low = 1,
+    }
+    public sealed class ProtocolElement : ConfigurationElement {
+        public ProtocolElement();
+        public ProtocolElement(WebServiceProtocols protocol);
+        public WebServiceProtocols Name { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class ProtocolElementCollection : ConfigurationElementCollection {
+        public ProtocolElementCollection();
+        public ProtocolElement this[int index] { get; set; }
+        public ProtocolElement this[object key] { get; set; }
+        public void Add(ProtocolElement element);
+        public void Clear();
+        public bool ContainsKey(object key);
+        public void CopyTo(ProtocolElement[] array, int index);
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public int IndexOf(ProtocolElement element);
+        public void Remove(ProtocolElement element);
+        public void RemoveAt(int index);
+        public void RemoveAt(object key);
+    }
+    public sealed class SoapEnvelopeProcessingElement : ConfigurationElement {
+        public SoapEnvelopeProcessingElement();
+        public SoapEnvelopeProcessingElement(int readTimeout);
+        public SoapEnvelopeProcessingElement(int readTimeout, bool strict);
+        public bool IsStrict { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public int ReadTimeout { get; set; }
+    }
+    public sealed class SoapExtensionTypeElement : ConfigurationElement {
+        public SoapExtensionTypeElement();
+        public SoapExtensionTypeElement(string type, int priority, PriorityGroup group);
+        public SoapExtensionTypeElement(Type type, int priority, PriorityGroup group);
+        public PriorityGroup Group { get; set; }
+        public int Priority { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public Type Type { get; set; }
+    }
+    public sealed class SoapExtensionTypeElementCollection : ConfigurationElementCollection {
+        public SoapExtensionTypeElementCollection();
+        public SoapExtensionTypeElement this[int index] { get; set; }
+        public SoapExtensionTypeElement this[object key] { get; set; }
+        public void Add(SoapExtensionTypeElement element);
+        public void Clear();
+        public bool ContainsKey(object key);
+        public void CopyTo(SoapExtensionTypeElement[] array, int index);
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public int IndexOf(SoapExtensionTypeElement element);
+        public void Remove(SoapExtensionTypeElement element);
+        public void RemoveAt(int index);
+        public void RemoveAt(object key);
+    }
+    public sealed class TypeElement : ConfigurationElement {
+        public TypeElement();
+        public TypeElement(string type);
+        public TypeElement(Type type);
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public Type Type { get; set; }
+    }
+    public sealed class TypeElementCollection : ConfigurationElementCollection {
+        public TypeElementCollection();
+        public TypeElement this[int index] { get; set; }
+        public TypeElement this[object key] { get; set; }
+        public void Add(TypeElement element);
+        public void Clear();
+        public bool ContainsKey(object key);
+        public void CopyTo(TypeElement[] array, int index);
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public int IndexOf(TypeElement element);
+        public void Remove(TypeElement element);
+        public void RemoveAt(int index);
+        public void RemoveAt(object key);
+    }
+    public enum WebServiceProtocols {
+        AnyHttpSoap = 33,
+        Documentation = 8,
+        HttpGet = 2,
+        HttpPost = 4,
+        HttpPostLocalhost = 16,
+        HttpSoap = 1,
+        HttpSoap12 = 32,
+        Unknown = 0,
+    }
+    public sealed class WebServicesSection : ConfigurationSection {
+        public WebServicesSection();
+        public WsiProfilesElementCollection ConformanceWarnings { get; }
+        public static WebServicesSection Current { get; }
+        public DiagnosticsElement Diagnostics { get; set; }
+        public WebServiceProtocols EnabledProtocols { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public ProtocolElementCollection Protocols { get; }
+        public TypeElementCollection ServiceDescriptionFormatExtensionTypes { get; }
+        public SoapEnvelopeProcessingElement SoapEnvelopeProcessing { get; set; }
+        public TypeElementCollection SoapExtensionImporterTypes { get; }
+        public TypeElementCollection SoapExtensionReflectorTypes { get; }
+        public SoapExtensionTypeElementCollection SoapExtensionTypes { get; }
+        public TypeElement SoapServerProtocolFactoryType { get; }
+        public TypeElementCollection SoapTransportImporterTypes { get; }
+        public WsdlHelpGeneratorElement WsdlHelpGenerator { get; }
+        public static WebServicesSection GetSection(Configuration config);
+        protected override void InitializeDefault();
+        protected override void Reset(ConfigurationElement parentElement);
+    }
+    public sealed class WsdlHelpGeneratorElement : ConfigurationElement {
+        public WsdlHelpGeneratorElement();
+        public string Href { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey);
+        protected override void Reset(ConfigurationElement parentElement);
+    }
+    public sealed class WsiProfilesElement : ConfigurationElement {
+        public WsiProfilesElement();
+        public WsiProfilesElement(WsiProfiles name);
+        public WsiProfiles Name { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class WsiProfilesElementCollection : ConfigurationElementCollection {
+        public WsiProfilesElementCollection();
+        public WsiProfilesElement this[int index] { get; set; }
+        public WsiProfilesElement this[object key] { get; set; }
+        public void Add(WsiProfilesElement element);
+        public void Clear();
+        public bool ContainsKey(object key);
+        public void CopyTo(WsiProfilesElement[] array, int index);
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public int IndexOf(WsiProfilesElement element);
+        public void Remove(WsiProfilesElement element);
+        public void RemoveAt(int index);
+        public void RemoveAt(object key);
+    }
+    public sealed class XmlFormatExtensionAttribute : Attribute {
+        public XmlFormatExtensionAttribute();
+        public XmlFormatExtensionAttribute(string elementName, string ns, Type extensionPoint1);
+        public XmlFormatExtensionAttribute(string elementName, string ns, Type extensionPoint1, Type extensionPoint2);
+        public XmlFormatExtensionAttribute(string elementName, string ns, Type extensionPoint1, Type extensionPoint2, Type extensionPoint3);
+        public XmlFormatExtensionAttribute(string elementName, string ns, Type extensionPoint1, Type extensionPoint2, Type extensionPoint3, Type extensionPoint4);
+        public XmlFormatExtensionAttribute(string elementName, string ns, Type[] extensionPoints);
+        public string ElementName { get; set; }
+        public Type[] ExtensionPoints { get; set; }
+        public string Namespace { get; set; }
+    }
+    public sealed class XmlFormatExtensionPointAttribute : Attribute {
+        public XmlFormatExtensionPointAttribute(string memberName);
+        public bool AllowElements { get; set; }
+        public string MemberName { get; set; }
+    }
+    public sealed class XmlFormatExtensionPrefixAttribute : Attribute {
+        public XmlFormatExtensionPrefixAttribute();
+        public XmlFormatExtensionPrefixAttribute(string prefix, string ns);
+        public string Namespace { get; set; }
+        public string Prefix { get; set; }
+    }
+}
```

