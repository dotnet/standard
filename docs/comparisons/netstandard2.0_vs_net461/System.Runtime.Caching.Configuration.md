# System.Runtime.Caching.Configuration

``` diff
+namespace System.Runtime.Caching.Configuration {
+    public sealed class CachingSectionGroup : ConfigurationSectionGroup {
+        public CachingSectionGroup();
+        public MemoryCacheSection MemoryCaches { get; }
+    }
+    public sealed class MemoryCacheElement : ConfigurationElement {
+        public MemoryCacheElement(string name);
+        public int CacheMemoryLimitMegabytes { get; set; }
+        public string Name { get; set; }
+        public int PhysicalMemoryLimitPercentage { get; set; }
+        public TimeSpan PollingInterval { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class MemoryCacheSection : ConfigurationSection {
+        public MemoryCacheSection();
+        public MemoryCacheSettingsCollection NamedCaches { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class MemoryCacheSettingsCollection : ConfigurationElementCollection {
+        public MemoryCacheSettingsCollection();
+        public override ConfigurationElementCollectionType CollectionType { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public MemoryCacheElement this[int index] { get; set; }
+        public new MemoryCacheElement this[string key] { get; }
+        public void Add(MemoryCacheElement cache);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override ConfigurationElement CreateNewElement(string elementName);
+        protected override object GetElementKey(ConfigurationElement element);
+        public int IndexOf(MemoryCacheElement cache);
+        public void Remove(MemoryCacheElement cache);
+        public void RemoveAt(int index);
+    }
+}
```

