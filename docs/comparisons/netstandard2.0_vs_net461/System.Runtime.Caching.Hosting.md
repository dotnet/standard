# System.Runtime.Caching.Hosting

``` diff
+namespace System.Runtime.Caching.Hosting {
+    public interface IApplicationIdentifier {
+        string GetApplicationId();
+    }
+    public interface IFileChangeNotificationSystem {
+        void StartMonitoring(string filePath, OnChangedCallback onChangedCallback, out object state, out DateTimeOffset lastWriteTime, out long fileSize);
+        void StopMonitoring(string filePath, object state);
+    }
+    public interface IMemoryCacheManager {
+        void ReleaseCache(MemoryCache cache);
+        void UpdateCacheSize(long size, MemoryCache cache);
+    }
+}
```

