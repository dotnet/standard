# System.Web.SessionState

``` diff
+namespace System.Web.SessionState {
+    public sealed class HttpSessionState : ICollection, IEnumerable {
+        public int CodePage { get; set; }
+        public HttpSessionState Contents { get; }
+        public HttpCookieMode CookieMode { get; }
+        public int Count { get; }
+        public bool IsCookieless { get; }
+        public bool IsNewSession { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public NameObjectCollectionBase.KeysCollection Keys { get; }
+        public int LCID { get; set; }
+        public SessionStateMode Mode { get; }
+        public string SessionID { get; }
+        public HttpStaticObjectsCollection StaticObjects { get; }
+        public object SyncRoot { get; }
+        public object this[int index] { get; set; }
+        public object this[string name] { get; set; }
+        public int Timeout { get; set; }
+        public void Abandon();
+        public void Add(string name, object value);
+        public void Clear();
+        public void CopyTo(Array array, int index);
+        public IEnumerator GetEnumerator();
+        public void Remove(string name);
+        public void RemoveAll();
+        public void RemoveAt(int index);
+    }
+    public class HttpSessionStateContainer : IHttpSessionState {
+        public HttpSessionStateContainer(string id, ISessionStateItemCollection sessionItems, HttpStaticObjectsCollection staticObjects, int timeout, bool newSession, HttpCookieMode cookieMode, SessionStateMode mode, bool isReadonly);
+        public int CodePage { get; set; }
+        public HttpCookieMode CookieMode { get; }
+        public int Count { get; }
+        public bool IsAbandoned { get; }
+        public bool IsCookieless { get; }
+        public bool IsNewSession { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public NameObjectCollectionBase.KeysCollection Keys { get; }
+        public int LCID { get; set; }
+        public SessionStateMode Mode { get; }
+        public string SessionID { get; }
+        public HttpStaticObjectsCollection StaticObjects { get; }
+        public object SyncRoot { get; }
+        public object this[int index] { get; set; }
+        public object this[string name] { get; set; }
+        public int Timeout { get; set; }
+        public void Abandon();
+        public void Add(string name, object value);
+        public void Clear();
+        public void CopyTo(Array array, int index);
+        public IEnumerator GetEnumerator();
+        public void Remove(string name);
+        public void RemoveAll();
+        public void RemoveAt(int index);
+    }
+    public interface IHttpSessionState {
+        int CodePage { get; set; }
+        HttpCookieMode CookieMode { get; }
+        int Count { get; }
+        bool IsCookieless { get; }
+        bool IsNewSession { get; }
+        bool IsReadOnly { get; }
+        bool IsSynchronized { get; }
+        NameObjectCollectionBase.KeysCollection Keys { get; }
+        int LCID { get; set; }
+        SessionStateMode Mode { get; }
+        string SessionID { get; }
+        HttpStaticObjectsCollection StaticObjects { get; }
+        object SyncRoot { get; }
+        object this[int index] { get; set; }
+        object this[string name] { get; set; }
+        int Timeout { get; set; }
+        void Abandon();
+        void Add(string name, object value);
+        void Clear();
+        void CopyTo(Array array, int index);
+        IEnumerator GetEnumerator();
+        void Remove(string name);
+        void RemoveAll();
+        void RemoveAt(int index);
+    }
+    public interface IPartialSessionState {
+        IList<string> PartialSessionStateKeys { get; }
+    }
+    public interface IReadOnlySessionState : IRequiresSessionState
+    public interface IRequiresSessionState
+    public interface ISessionIDManager {
+        string CreateSessionID(HttpContext context);
+        string GetSessionID(HttpContext context);
+        void Initialize();
+        bool InitializeRequest(HttpContext context, bool suppressAutoDetectRedirect, out bool supportSessionIDReissue);
+        void RemoveSessionID(HttpContext context);
+        void SaveSessionID(HttpContext context, string id, out bool redirected, out bool cookieAdded);
+        bool Validate(string id);
+    }
+    public interface ISessionStateItemCollection : ICollection, IEnumerable {
+        bool Dirty { get; set; }
+        NameObjectCollectionBase.KeysCollection Keys { get; }
+        object this[int index] { get; set; }
+        object this[string name] { get; set; }
+        void Clear();
+        void Remove(string name);
+        void RemoveAt(int index);
+    }
+    public interface IStateRuntime {
+        void ProcessRequest(IntPtr tracker, int verb, string uri, int exclusive, int extraFlags, int timeout, int lockCookieExists, int lockCookie, int contentLength, IntPtr content);
+        void ProcessRequest(IntPtr tracker, int verb, string uri, int exclusive, int timeout, int lockCookieExists, int lockCookie, int contentLength, IntPtr content);
+        void StopProcessing();
+    }
+    public class SessionIDManager : ISessionIDManager {
+        public SessionIDManager();
+        public static int SessionIDMaxLength { get; }
+        public virtual string CreateSessionID(HttpContext context);
+        public virtual string Decode(string id);
+        public virtual string Encode(string id);
+        public string GetSessionID(HttpContext context);
+        public void Initialize();
+        public bool InitializeRequest(HttpContext context, bool suppressAutoDetectRedirect, out bool supportSessionIDReissue);
+        public void RemoveSessionID(HttpContext context);
+        public void SaveSessionID(HttpContext context, string id, out bool redirected, out bool cookieAdded);
+        public virtual bool Validate(string id);
+    }
+    public enum SessionStateActions {
+        InitializeItem = 1,
+        None = 0,
+    }
+    public enum SessionStateBehavior {
+        Default = 0,
+        Disabled = 3,
+        ReadOnly = 2,
+        Required = 1,
+    }
+    public sealed class SessionStateItemCollection : NameObjectCollectionBase, ICollection, IEnumerable, ISessionStateItemCollection {
+        public SessionStateItemCollection();
+        public bool Dirty { get; set; }
+        public override NameObjectCollectionBase.KeysCollection Keys { get; }
+        public object this[int index] { get; set; }
+        public object this[string name] { get; set; }
+        public void Clear();
+        public static SessionStateItemCollection Deserialize(BinaryReader reader);
+        public override IEnumerator GetEnumerator();
+        public void Remove(string name);
+        public void RemoveAt(int index);
+        public void Serialize(BinaryWriter writer);
+    }
+    public delegate void SessionStateItemExpireCallback(string id, SessionStateStoreData item);
+    public enum SessionStateMode {
+        Custom = 4,
+        InProc = 1,
+        Off = 0,
+        SQLServer = 3,
+        StateServer = 2,
+    }
+    public sealed class SessionStateModule : IHttpModule {
+        public SessionStateModule();
+        public event EventHandler End;
+        public event EventHandler Start;
+        public void Dispose();
+        public void Init(HttpApplication app);
+    }
+    public class SessionStateStoreData {
+        public SessionStateStoreData(ISessionStateItemCollection sessionItems, HttpStaticObjectsCollection staticObjects, int timeout);
+        public virtual ISessionStateItemCollection Items { get; }
+        public virtual HttpStaticObjectsCollection StaticObjects { get; }
+        public virtual int Timeout { get; set; }
+    }
+    public abstract class SessionStateStoreProviderBase : ProviderBase {
+        protected SessionStateStoreProviderBase();
+        public abstract SessionStateStoreData CreateNewStoreData(HttpContext context, int timeout);
+        public abstract void CreateUninitializedItem(HttpContext context, string id, int timeout);
+        public abstract void Dispose();
+        public abstract void EndRequest(HttpContext context);
+        public abstract SessionStateStoreData GetItem(HttpContext context, string id, out bool locked, out TimeSpan lockAge, out object lockId, out SessionStateActions actions);
+        public abstract SessionStateStoreData GetItemExclusive(HttpContext context, string id, out bool locked, out TimeSpan lockAge, out object lockId, out SessionStateActions actions);
+        public abstract void InitializeRequest(HttpContext context);
+        public abstract void ReleaseItemExclusive(HttpContext context, string id, object lockId);
+        public abstract void RemoveItem(HttpContext context, string id, object lockId, SessionStateStoreData item);
+        public abstract void ResetItemTimeout(HttpContext context, string id);
+        public abstract void SetAndReleaseItemExclusive(HttpContext context, string id, SessionStateStoreData item, object lockId, bool newItem);
+        public abstract bool SetItemExpireCallback(SessionStateItemExpireCallback expireCallback);
+    }
+    public static class SessionStateUtility {
+        public static ISurrogateSelector SerializationSurrogateSelector { get; set; }
+        public static void AddHttpSessionStateToContext(HttpContext context, IHttpSessionState container);
+        public static IHttpSessionState GetHttpSessionStateFromContext(HttpContext context);
+        public static HttpStaticObjectsCollection GetSessionStaticObjects(HttpContext context);
+        public static void RaiseSessionEnd(IHttpSessionState session, object eventSource, EventArgs eventArgs);
+        public static void RemoveHttpSessionStateFromContext(HttpContext context);
+    }
+    public sealed class StateRuntime : IStateRuntime {
+        public StateRuntime();
+        public void ProcessRequest(IntPtr tracker, int verb, string uri, int exclusive, int extraFlags, int timeout, int lockCookieExists, int lockCookie, int contentLength, IntPtr content);
+        public void ProcessRequest(IntPtr tracker, int verb, string uri, int exclusive, int timeout, int lockCookieExists, int lockCookie, int contentLength, IntPtr content);
+        public void StopProcessing();
+    }
+}
```

