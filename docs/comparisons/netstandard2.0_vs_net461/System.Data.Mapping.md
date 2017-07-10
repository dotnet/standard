# System.Data.Mapping

``` diff
+namespace System.Data.Mapping {
+    public abstract class EntityViewContainer {
+        protected EntityViewContainer();
+        public string EdmEntityContainerName { get; set; }
+        public string HashOverAllExtentViews { get; set; }
+        public string HashOverMappingClosure { get; set; }
+        public string StoreEntityContainerName { get; set; }
+        public int ViewCount { get; protected set; }
+        protected abstract KeyValuePair<string, string> GetViewAt(int index);
+    }
+    public sealed class EntityViewGenerationAttribute : Attribute {
+        public EntityViewGenerationAttribute(Type viewGenerationType);
+        public Type ViewGenerationType { get; }
+    }
+    public abstract class MappingItemCollection : ItemCollection
+    public class StorageMappingItemCollection : MappingItemCollection {
+        public StorageMappingItemCollection(EdmItemCollection edmCollection, StoreItemCollection storeCollection, IEnumerable<XmlReader> xmlReaders);
+        public StorageMappingItemCollection(EdmItemCollection edmCollection, StoreItemCollection storeCollection, params string[] filePaths);
+        public double MappingVersion { get; }
+    }
+}
```

