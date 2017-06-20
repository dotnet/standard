# System.Web.Mobile

``` diff
+namespace System.Web.Mobile {
+    public class CookielessData : HybridDictionary {
+        public CookielessData();
+    }
+    public sealed class DeviceFilterElement : ConfigurationElement {
+        public DeviceFilterElement(string name, string compareName, string argument);
+        public DeviceFilterElement(string name, Type filterClass, string method);
+        public string Argument { get; set; }
+        public string Compare { get; set; }
+        protected override ConfigurationElementProperty ElementProperty { get; }
+        public Type FilterClass { get; set; }
+        public string Method { get; set; }
+        public string Name { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class DeviceFilterElementCollection : ConfigurationElementCollection {
+        public DeviceFilterElementCollection();
+        public object[] AllKeys { get; }
+        public override ConfigurationElementCollectionType CollectionType { get; }
+        protected override string ElementName { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public DeviceFilterElement this[int index] { get; set; }
+        public new DeviceFilterElement this[string name] { get; }
+        public void Add(DeviceFilterElement deviceFilter);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public void Remove(string name);
+        public void Remove(DeviceFilterElement deviceFilter);
+        public void RemoveAt(int index);
+    }
+    public sealed class DeviceFiltersSection : ConfigurationSection {
+        public DeviceFiltersSection();
+        public DeviceFilterElementCollection Filters { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public class ErrorHandlerModule : IHttpModule {
+        public ErrorHandlerModule();
+        void System.Web.IHttpModule.Dispose();
+        void System.Web.IHttpModule.Init(HttpApplication application);
+    }
+    public class MobileCapabilities : HttpBrowserCapabilities {
+        public static readonly string PreferredRenderingTypeChtml10;
+        public static readonly string PreferredRenderingTypeHtml32;
+        public static readonly string PreferredRenderingTypeWml11;
+        public static readonly string PreferredRenderingTypeWml12;
+        public MobileCapabilities();
+        public bool HasCapability(string delegateName, string optionalParameter);
+    }
+    public class MobileDeviceCapabilitiesSectionHandler : IConfigurationSectionHandler {
+        public MobileDeviceCapabilitiesSectionHandler();
+        protected object Create(object parent, object context, XmlNode node);
+        object System.Configuration.IConfigurationSectionHandler.Create(object parent, object context, XmlNode node);
+    }
+    public class MobileErrorInfo {
+        public static readonly string ContextKey;
+        public string Description { get; set; }
+        public string File { get; set; }
+        public string LineNumber { get; set; }
+        public string MiscText { get; set; }
+        public string MiscTitle { get; set; }
+        public string this[string key] { get; set; }
+        public string Type { get; set; }
+    }
+    public class MobileFormsAuthentication {
+        public static void RedirectFromLoginPage(string userName, bool createPersistentCookie);
+        public static void RedirectFromLoginPage(string userName, bool createPersistentCookie, string strCookiePath);
+        public static void SignOut();
+    }
+}
```

