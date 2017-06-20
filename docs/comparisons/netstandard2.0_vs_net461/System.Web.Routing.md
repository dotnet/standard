# System.Web.Routing

``` diff
+namespace System.Web.Routing {
+    public class HttpMethodConstraint : IRouteConstraint {
+        public HttpMethodConstraint(params string[] allowedMethods);
+        public ICollection<string> AllowedMethods { get; private set; }
+        protected virtual bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection);
+        bool System.Web.Routing.IRouteConstraint.Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection);
+    }
+    public interface IRouteConstraint {
+        bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection);
+    }
+    public interface IRouteHandler {
+        IHttpHandler GetHttpHandler(RequestContext requestContext);
+    }
+    public class PageRouteHandler : IRouteHandler {
+        public PageRouteHandler(string virtualPath);
+        public PageRouteHandler(string virtualPath, bool checkPhysicalUrlAccess);
+        public bool CheckPhysicalUrlAccess { get; private set; }
+        public string VirtualPath { get; private set; }
+        public virtual IHttpHandler GetHttpHandler(RequestContext requestContext);
+        public string GetSubstitutedVirtualPath(RequestContext requestContext);
+    }
+    public class RequestContext {
+        public RequestContext();
+        public RequestContext(HttpContextBase httpContext, RouteData routeData);
+        public virtual HttpContextBase HttpContext { get; set; }
+        public virtual RouteData RouteData { get; set; }
+    }
+    public class Route : RouteBase {
+        public Route(string url, IRouteHandler routeHandler);
+        public Route(string url, RouteValueDictionary defaults, IRouteHandler routeHandler);
+        public Route(string url, RouteValueDictionary defaults, RouteValueDictionary constraints, IRouteHandler routeHandler);
+        public Route(string url, RouteValueDictionary defaults, RouteValueDictionary constraints, RouteValueDictionary dataTokens, IRouteHandler routeHandler);
+        public RouteValueDictionary Constraints { get; set; }
+        public RouteValueDictionary DataTokens { get; set; }
+        public RouteValueDictionary Defaults { get; set; }
+        public IRouteHandler RouteHandler { get; set; }
+        public string Url { get; set; }
+        public override RouteData GetRouteData(HttpContextBase httpContext);
+        public override VirtualPathData GetVirtualPath(RequestContext requestContext, RouteValueDictionary values);
+        protected virtual bool ProcessConstraint(HttpContextBase httpContext, object constraint, string parameterName, RouteValueDictionary values, RouteDirection routeDirection);
+    }
+    public abstract class RouteBase {
+        protected RouteBase();
+        public bool RouteExistingFiles { get; set; }
+        public abstract RouteData GetRouteData(HttpContextBase httpContext);
+        public abstract VirtualPathData GetVirtualPath(RequestContext requestContext, RouteValueDictionary values);
+    }
+    public class RouteCollection : Collection<RouteBase> {
+        public RouteCollection();
+        public RouteCollection(VirtualPathProvider virtualPathProvider);
+        public bool AppendTrailingSlash { get; set; }
+        public bool LowercaseUrls { get; set; }
+        public bool RouteExistingFiles { get; set; }
+        public RouteBase this[string name] { get; }
+        public void Add(string name, RouteBase item);
+        protected override void ClearItems();
+        public IDisposable GetReadLock();
+        public RouteData GetRouteData(HttpContextBase httpContext);
+        public VirtualPathData GetVirtualPath(RequestContext requestContext, string name, RouteValueDictionary values);
+        public VirtualPathData GetVirtualPath(RequestContext requestContext, RouteValueDictionary values);
+        public IDisposable GetWriteLock();
+        public void Ignore(string url);
+        public void Ignore(string url, object constraints);
+        protected override void InsertItem(int index, RouteBase item);
+        public Route MapPageRoute(string routeName, string routeUrl, string physicalFile);
+        public Route MapPageRoute(string routeName, string routeUrl, string physicalFile, bool checkPhysicalUrlAccess);
+        public Route MapPageRoute(string routeName, string routeUrl, string physicalFile, bool checkPhysicalUrlAccess, RouteValueDictionary defaults);
+        public Route MapPageRoute(string routeName, string routeUrl, string physicalFile, bool checkPhysicalUrlAccess, RouteValueDictionary defaults, RouteValueDictionary constraints);
+        public Route MapPageRoute(string routeName, string routeUrl, string physicalFile, bool checkPhysicalUrlAccess, RouteValueDictionary defaults, RouteValueDictionary constraints, RouteValueDictionary dataTokens);
+        protected override void RemoveItem(int index);
+        protected override void SetItem(int index, RouteBase item);
+    }
+    public class RouteData {
+        public RouteData();
+        public RouteData(RouteBase route, IRouteHandler routeHandler);
+        public RouteValueDictionary DataTokens { get; }
+        public RouteBase Route { get; set; }
+        public IRouteHandler RouteHandler { get; set; }
+        public RouteValueDictionary Values { get; }
+        public string GetRequiredString(string valueName);
+    }
+    public enum RouteDirection {
+        IncomingRequest = 0,
+        UrlGeneration = 1,
+    }
+    public class RouteTable {
+        public RouteTable();
+        public static RouteCollection Routes { get; }
+    }
+    public class RouteValueDictionary : ICollection<KeyValuePair<string, object>>, IDictionary<string, object>, IEnumerable, IEnumerable<KeyValuePair<string, object>> {
+        public RouteValueDictionary();
+        public RouteValueDictionary(IDictionary<string, object> dictionary);
+        public RouteValueDictionary(object values);
+        public int Count { get; }
+        public Dictionary<string, object>.KeyCollection Keys { get; }
+        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.IsReadOnly { get; }
+        ICollection<string> System.Collections.Generic.IDictionary<System.String,System.Object>.Keys { get; }
+        ICollection<object> System.Collections.Generic.IDictionary<System.String,System.Object>.Values { get; }
+        public object this[string key] { get; set; }
+        public Dictionary<string, object>.ValueCollection Values { get; }
+        public void Add(string key, object value);
+        public void Clear();
+        public bool ContainsKey(string key);
+        public bool ContainsValue(object value);
+        public Dictionary<string, object>.Enumerator GetEnumerator();
+        public bool Remove(string key);
+        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Add(KeyValuePair<string, object> item);
+        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Contains(KeyValuePair<string, object> item);
+        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.CopyTo(KeyValuePair<string, object>[] array, int arrayIndex);
+        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Remove(KeyValuePair<string, object> item);
+        IEnumerator<KeyValuePair<string, object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        public bool TryGetValue(string key, out object value);
+    }
+    public class StopRoutingHandler : IRouteHandler {
+        public StopRoutingHandler();
+        protected virtual IHttpHandler GetHttpHandler(RequestContext requestContext);
+        IHttpHandler System.Web.Routing.IRouteHandler.GetHttpHandler(RequestContext requestContext);
+    }
+    public abstract class UrlRoutingHandler : IHttpHandler {
+        protected UrlRoutingHandler();
+        protected virtual bool IsReusable { get; }
+        public RouteCollection RouteCollection { get; set; }
+        bool System.Web.IHttpHandler.IsReusable { get; }
+        protected virtual void ProcessRequest(HttpContext httpContext);
+        protected virtual void ProcessRequest(HttpContextBase httpContext);
+        void System.Web.IHttpHandler.ProcessRequest(HttpContext context);
+        protected abstract void VerifyAndProcessRequest(IHttpHandler httpHandler, HttpContextBase httpContext);
+    }
+    public class UrlRoutingModule : IHttpModule {
+        public UrlRoutingModule();
+        public RouteCollection RouteCollection { get; set; }
+        protected virtual void Dispose();
+        protected virtual void Init(HttpApplication application);
+        public virtual void PostMapRequestHandler(HttpContextBase context);
+        public virtual void PostResolveRequestCache(HttpContextBase context);
+        void System.Web.IHttpModule.Dispose();
+        void System.Web.IHttpModule.Init(HttpApplication application);
+    }
+    public class VirtualPathData {
+        public VirtualPathData(RouteBase route, string virtualPath);
+        public RouteValueDictionary DataTokens { get; }
+        public RouteBase Route { get; set; }
+        public string VirtualPath { get; set; }
+    }
+}
```

