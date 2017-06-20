# System.Runtime.Caching

``` diff
+namespace System.Runtime.Caching {
+    public abstract class CacheEntryChangeMonitor : ChangeMonitor {
+        protected CacheEntryChangeMonitor();
+        public abstract ReadOnlyCollection<string> CacheKeys { get; }
+        public abstract DateTimeOffset LastModified { get; }
+        public abstract string RegionName { get; }
+    }
+    public class CacheEntryRemovedArguments {
+        public CacheEntryRemovedArguments(ObjectCache source, CacheEntryRemovedReason reason, CacheItem cacheItem);
+        public CacheItem CacheItem { get; }
+        public CacheEntryRemovedReason RemovedReason { get; }
+        public ObjectCache Source { get; }
+    }
+    public delegate void CacheEntryRemovedCallback(CacheEntryRemovedArguments arguments);
+    public enum CacheEntryRemovedReason {
+        CacheSpecificEviction = 4,
+        ChangeMonitorChanged = 3,
+        Evicted = 2,
+        Expired = 1,
+        Removed = 0,
+    }
+    public class CacheEntryUpdateArguments {
+        public CacheEntryUpdateArguments(ObjectCache source, CacheEntryRemovedReason reason, string key, string regionName);
+        public string Key { get; }
+        public string RegionName { get; }
+        public CacheEntryRemovedReason RemovedReason { get; }
+        public ObjectCache Source { get; }
+        public CacheItem UpdatedCacheItem { get; set; }
+        public CacheItemPolicy UpdatedCacheItemPolicy { get; set; }
+    }
+    public delegate void CacheEntryUpdateCallback(CacheEntryUpdateArguments arguments);
+    public class CacheItem {
+        public CacheItem(string key);
+        public CacheItem(string key, object value);
+        public CacheItem(string key, object value, string regionName);
+        public string Key { get; set; }
+        public string RegionName { get; set; }
+        public object Value { get; set; }
+    }
+    public class CacheItemPolicy {
+        public CacheItemPolicy();
+        public DateTimeOffset AbsoluteExpiration { get; set; }
+        public Collection<ChangeMonitor> ChangeMonitors { get; }
+        public CacheItemPriority Priority { get; set; }
+        public CacheEntryRemovedCallback RemovedCallback { get; set; }
+        public TimeSpan SlidingExpiration { get; set; }
+        public CacheEntryUpdateCallback UpdateCallback { get; set; }
+    }
+    public enum CacheItemPriority {
+        Default = 0,
+        NotRemovable = 1,
+    }
+    public abstract class ChangeMonitor : IDisposable {
+        protected ChangeMonitor();
+        public bool HasChanged { get; }
+        public bool IsDisposed { get; }
+        public abstract string UniqueId { get; }
+        public void Dispose();
+        protected abstract void Dispose(bool disposing);
+        protected void InitializationComplete();
+        public void NotifyOnChanged(OnChangedCallback onChangedCallback);
+        protected void OnChanged(object state);
+    }
+    public enum DefaultCacheCapabilities {
+        AbsoluteExpirations = 8,
+        CacheEntryChangeMonitors = 4,
+        CacheEntryRemovedCallback = 64,
+        CacheEntryUpdateCallback = 32,
+        CacheRegions = 128,
+        InMemoryProvider = 1,
+        None = 0,
+        OutOfProcessProvider = 2,
+        SlidingExpirations = 16,
+    }
+    public abstract class FileChangeMonitor : ChangeMonitor {
+        protected FileChangeMonitor();
+        public abstract ReadOnlyCollection<string> FilePaths { get; }
+        public abstract DateTimeOffset LastModified { get; }
+    }
+    public sealed class HostFileChangeMonitor : FileChangeMonitor {
+        public HostFileChangeMonitor(IList<string> filePaths);
+        public override ReadOnlyCollection<string> FilePaths { get; }
+        public override DateTimeOffset LastModified { get; }
+        public override string UniqueId { get; }
+        protected override void Dispose(bool disposing);
+    }
+    public class MemoryCache : ObjectCache, IDisposable, IEnumerable {
+        public MemoryCache(string name, NameValueCollection config=null);
+        public long CacheMemoryLimit { get; }
+        public static MemoryCache Default { get; }
+        public override DefaultCacheCapabilities DefaultCacheCapabilities { get; }
+        public override string Name { get; }
+        public long PhysicalMemoryLimit { get; }
+        public TimeSpan PollingInterval { get; }
+        public override object this[string key] { get; set; }
+        public override bool Add(CacheItem item, CacheItemPolicy policy);
+        public override CacheItem AddOrGetExisting(CacheItem item, CacheItemPolicy policy);
+        public override object AddOrGetExisting(string key, object value, DateTimeOffset absoluteExpiration, string regionName=null);
+        public override object AddOrGetExisting(string key, object value, CacheItemPolicy policy, string regionName=null);
+        public override bool Contains(string key, string regionName=null);
+        public override CacheEntryChangeMonitor CreateCacheEntryChangeMonitor(IEnumerable<string> keys, string regionName=null);
+        public void Dispose();
+        public override object Get(string key, string regionName=null);
+        public override CacheItem GetCacheItem(string key, string regionName=null);
+        public override long GetCount(string regionName=null);
+        protected override IEnumerator<KeyValuePair<string, object>> GetEnumerator();
+        public override IDictionary<string, object> GetValues(IEnumerable<string> keys, string regionName=null);
+        public override object Remove(string key, string regionName=null);
+        public override void Set(CacheItem item, CacheItemPolicy policy);
+        public override void Set(string key, object value, DateTimeOffset absoluteExpiration, string regionName=null);
+        public override void Set(string key, object value, CacheItemPolicy policy, string regionName=null);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        public long Trim(int percent);
+    }
+    public abstract class ObjectCache : IEnumerable, IEnumerable<KeyValuePair<string, object>> {
+        public static readonly DateTimeOffset InfiniteAbsoluteExpiration;
+        public static readonly TimeSpan NoSlidingExpiration;
+        protected ObjectCache();
+        public abstract DefaultCacheCapabilities DefaultCacheCapabilities { get; }
+        public static IServiceProvider Host { get; set; }
+        public abstract string Name { get; }
+        public abstract object this[string key] { get; set; }
+        public virtual bool Add(CacheItem item, CacheItemPolicy policy);
+        public virtual bool Add(string key, object value, DateTimeOffset absoluteExpiration, string regionName=null);
+        public virtual bool Add(string key, object value, CacheItemPolicy policy, string regionName=null);
+        public abstract CacheItem AddOrGetExisting(CacheItem value, CacheItemPolicy policy);
+        public abstract object AddOrGetExisting(string key, object value, DateTimeOffset absoluteExpiration, string regionName=null);
+        public abstract object AddOrGetExisting(string key, object value, CacheItemPolicy policy, string regionName=null);
+        public abstract bool Contains(string key, string regionName=null);
+        public abstract CacheEntryChangeMonitor CreateCacheEntryChangeMonitor(IEnumerable<string> keys, string regionName=null);
+        public abstract object Get(string key, string regionName=null);
+        public abstract CacheItem GetCacheItem(string key, string regionName=null);
+        public abstract long GetCount(string regionName=null);
+        protected abstract IEnumerator<KeyValuePair<string, object>> GetEnumerator();
+        public abstract IDictionary<string, object> GetValues(IEnumerable<string> keys, string regionName=null);
+        public virtual IDictionary<string, object> GetValues(string regionName, params string[] keys);
+        public abstract object Remove(string key, string regionName=null);
+        public abstract void Set(CacheItem item, CacheItemPolicy policy);
+        public abstract void Set(string key, object value, DateTimeOffset absoluteExpiration, string regionName=null);
+        public abstract void Set(string key, object value, CacheItemPolicy policy, string regionName=null);
+        IEnumerator<KeyValuePair<string, object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+    }
+    public delegate void OnChangedCallback(object state);
+    public sealed class SqlChangeMonitor : ChangeMonitor {
+        public SqlChangeMonitor(SqlDependency dependency);
+        public override string UniqueId { get; }
+        protected override void Dispose(bool disposing);
+    }
+}
```

