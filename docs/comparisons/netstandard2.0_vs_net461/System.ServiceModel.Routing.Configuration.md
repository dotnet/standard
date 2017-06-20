# System.ServiceModel.Routing.Configuration

``` diff
+namespace System.ServiceModel.Routing.Configuration {
+    public class BackupEndpointCollection : ConfigurationElementCollection {
+        public BackupEndpointCollection();
+        public string Name { get; set; }
+        public void Add(BackupEndpointElement element);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public void Remove(BackupEndpointElement element);
+    }
+    public class BackupEndpointElement : ConfigurationElement {
+        public BackupEndpointElement();
+        public string EndpointName { get; set; }
+    }
+    public class BackupListCollection : ConfigurationElementCollection {
+        public BackupListCollection();
+        public new BackupEndpointCollection this[string name] { get; }
+        public void Add(BackupEndpointCollection element);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public void Remove(BackupEndpointCollection element);
+    }
+    public class FilterElement : ConfigurationElement {
+        public FilterElement();
+        public string CustomType { get; set; }
+        public string Filter1 { get; set; }
+        public string Filter2 { get; set; }
+        public string FilterData { get; set; }
+        public FilterType FilterType { get; set; }
+        public string Name { get; set; }
+    }
+    public class FilterElementCollection : ConfigurationElementCollection {
+        public FilterElementCollection();
+        public FilterElement this[int index] { get; set; }
+        public new FilterElement this[string name] { get; }
+        public void Add(FilterElement element);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        protected override bool IsElementRemovable(ConfigurationElement element);
+        public override bool IsReadOnly();
+        public void Remove(FilterElement element);
+    }
+    public class FilterTableCollection : ConfigurationElementCollection {
+        public FilterTableCollection();
+        public new FilterTableEntryCollection this[string name] { get; }
+        public void Add(FilterTableEntryCollection element);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public void Remove(FilterTableEntryCollection element);
+    }
+    public class FilterTableEntryCollection : ConfigurationElementCollection {
+        public FilterTableEntryCollection();
+        public string Name { get; set; }
+        public void Add(FilterTableEntryElement element);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public void Remove(FilterTableEntryElement element);
+    }
+    public class FilterTableEntryElement : ConfigurationElement {
+        public FilterTableEntryElement();
+        public string BackupList { get; set; }
+        public string EndpointName { get; set; }
+        public string FilterName { get; set; }
+        public int Priority { get; set; }
+    }
+    public enum FilterType {
+        Action = 0,
+        And = 3,
+        Custom = 4,
+        EndpointAddress = 1,
+        EndpointName = 5,
+        MatchAll = 6,
+        PrefixEndpointAddress = 2,
+        XPath = 7,
+    }
+    public class NamespaceElement : ConfigurationElement {
+        public NamespaceElement();
+        public string Namespace { get; set; }
+        public string Prefix { get; set; }
+    }
+    public class NamespaceElementCollection : ConfigurationElementCollection {
+        public NamespaceElementCollection();
+        public NamespaceElement this[int index] { get; set; }
+        public new NamespaceElement this[string name] { get; }
+        public void Add(NamespaceElement element);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public void Remove(NamespaceElement element);
+    }
+    public sealed class RoutingExtensionElement : BehaviorExtensionElement {
+        public RoutingExtensionElement();
+        public override Type BehaviorType { get; }
+        public bool EnsureOrderedDispatch { get; set; }
+        public string FilterTableName { get; set; }
+        public bool RouteOnHeadersOnly { get; set; }
+        public bool SoapProcessingEnabled { get; set; }
+        protected internal override object CreateBehavior();
+    }
+    public class RoutingSection : ConfigurationSection {
+        public RoutingSection();
+        public BackupListCollection BackupLists { get; }
+        public FilterElementCollection Filters { get; }
+        public FilterTableCollection FilterTables { get; }
+        public NamespaceElementCollection NamespaceTable { get; }
+        public static MessageFilterTable<IEnumerable<ServiceEndpoint>> CreateFilterTable(string name);
+    }
+    public class SoapProcessingExtensionElement : BehaviorExtensionElement {
+        public SoapProcessingExtensionElement();
+        public override Type BehaviorType { get; }
+        public bool ProcessMessages { get; set; }
+        protected internal override object CreateBehavior();
+    }
+}
```

