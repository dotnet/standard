# System.Web.Caching

``` diff
+namespace System.Web.Caching {
+    public sealed class AggregateCacheDependency : CacheDependency, ICacheDependencyChanged {
+        public AggregateCacheDependency();
+        public void Add(params CacheDependency[] dependencies);
+        protected override void DependencyDispose();
+        public override string GetUniqueID();
+    }
+    public sealed class Cache : IEnumerable {
+        public static readonly DateTime NoAbsoluteExpiration;
+        public static readonly TimeSpan NoSlidingExpiration;
+        public Cache();
+        public int Count { get; }
+        public long EffectivePercentagePhysicalMemoryLimit { get; }
+        public long EffectivePrivateBytesLimit { get; }
+        public object this[string key] { get; set; }
+        public object Add(string key, object value, CacheDependency dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration, CacheItemPriority priority, CacheItemRemovedCallback onRemoveCallback);
+        public object Get(string key);
+        public IDictionaryEnumerator GetEnumerator();
+        public void Insert(string key, object value);
+        public void Insert(string key, object value, CacheDependency dependencies);
+        public void Insert(string key, object value, CacheDependency dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration);
+        public void Insert(string key, object value, CacheDependency dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration, CacheItemPriority priority, CacheItemRemovedCallback onRemoveCallback);
+        public void Insert(string key, object value, CacheDependency dependencies, DateTime absoluteExpiration, TimeSpan slidingExpiration, CacheItemUpdateCallback onUpdateCallback);
+        public object Remove(string key);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+    }
+    public class CacheDependency : IDisposable {
+        protected CacheDependency();
+        public CacheDependency(string filename);
+        public CacheDependency(string filename, DateTime start);
+        public CacheDependency(string[] filenames);
+        public CacheDependency(string[] filenames, DateTime start);
+        public CacheDependency(string[] filenames, string[] cachekeys);
+        public CacheDependency(string[] filenames, string[] cachekeys, DateTime start);
+        public CacheDependency(string[] filenames, string[] cachekeys, CacheDependency dependency);
+        public CacheDependency(string[] filenames, string[] cachekeys, CacheDependency dependency, DateTime start);
+        public bool HasChanged { get; }
+        public DateTime UtcLastModified { get; }
+        protected virtual void DependencyDispose();
+        public void Dispose();
+        protected internal void FinishInit();
+        public virtual string GetUniqueID();
+        protected void NotifyDependencyChanged(object sender, EventArgs e);
+        protected void SetUtcLastModified(DateTime utcLastModified);
+    }
+    public enum CacheItemPriority {
+        AboveNormal = 4,
+        BelowNormal = 2,
+        Default = 3,
+        High = 5,
+        Low = 1,
+        Normal = 3,
+        NotRemovable = 6,
+    }
+    public delegate void CacheItemRemovedCallback(string key, object value, CacheItemRemovedReason reason);
+    public enum CacheItemRemovedReason {
+        DependencyChanged = 4,
+        Expired = 2,
+        Removed = 1,
+        Underused = 3,
+    }
+    public delegate void CacheItemUpdateCallback(string key, CacheItemUpdateReason reason, out object expensiveObject, out CacheDependency dependency, out DateTime absoluteExpiration, out TimeSpan slidingExpiration);
+    public enum CacheItemUpdateReason {
+        DependencyChanged = 2,
+        Expired = 1,
+    }
+    public sealed class DatabaseNotEnabledForNotificationException : SystemException {
+        public DatabaseNotEnabledForNotificationException();
+        public DatabaseNotEnabledForNotificationException(string message);
+        public DatabaseNotEnabledForNotificationException(string message, Exception innerException);
+    }
+    public class FileResponseElement : ResponseElement {
+        public FileResponseElement(string path, long offset, long length);
+        public long Length { get; }
+        public long Offset { get; }
+        public string Path { get; }
+    }
+    public sealed class HeaderElement {
+        public HeaderElement(string name, string value);
+        public string Name { get; }
+        public string Value { get; }
+    }
+    public interface IOutputCacheEntry {
+        List<HeaderElement> HeaderElements { get; set; }
+        List<ResponseElement> ResponseElements { get; set; }
+    }
+    public class MemoryResponseElement : ResponseElement {
+        public MemoryResponseElement(byte[] buffer, long length);
+        public byte[] Buffer { get; }
+        public long Length { get; }
+    }
+    public static class OutputCache {
+        public static string DefaultProviderName { get; }
+        public static OutputCacheProviderCollection Providers { get; }
+        public static object Deserialize(Stream stream);
+        public static void Serialize(Stream stream, object data);
+    }
+    public abstract class OutputCacheProvider : ProviderBase {
+        protected OutputCacheProvider();
+        public abstract object Add(string key, object entry, DateTime utcExpiry);
+        public abstract object Get(string key);
+        public abstract void Remove(string key);
+        public abstract void Set(string key, object entry, DateTime utcExpiry);
+    }
+    public sealed class OutputCacheProviderCollection : ProviderCollection {
+        public OutputCacheProviderCollection();
+        public new OutputCacheProvider this[string name] { get; }
+        public override void Add(ProviderBase provider);
+        public void CopyTo(OutputCacheProvider[] array, int index);
+    }
+    public abstract class ResponseElement {
+        protected ResponseElement();
+    }
+    public sealed class SqlCacheDependency : CacheDependency {
+        public SqlCacheDependency(SqlCommand sqlCmd);
+        public SqlCacheDependency(string databaseEntryName, string tableName);
+        public static CacheDependency CreateOutputCacheDependency(string dependency);
+        protected override void DependencyDispose();
+        public override string GetUniqueID();
+    }
+    public static class SqlCacheDependencyAdmin {
+        public static void DisableNotifications(string connectionString);
+        public static void DisableTableForNotifications(string connectionString, string table);
+        public static void DisableTableForNotifications(string connectionString, string[] tables);
+        public static void EnableNotifications(string connectionString);
+        public static void EnableTableForNotifications(string connectionString, string table);
+        public static void EnableTableForNotifications(string connectionString, string[] tables);
+        public static string[] GetTablesEnabledForNotifications(string connectionString);
+    }
+    public class SubstitutionResponseElement : ResponseElement {
+        public SubstitutionResponseElement(HttpResponseSubstitutionCallback callback);
+        public HttpResponseSubstitutionCallback Callback { get; }
+    }
+    public sealed class TableNotEnabledForNotificationException : SystemException {
+        public TableNotEnabledForNotificationException();
+        public TableNotEnabledForNotificationException(string message);
+        public TableNotEnabledForNotificationException(string message, Exception innerException);
+    }
+}
```

