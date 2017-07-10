# System.Runtime.Remoting.Services

``` diff
+namespace System.Runtime.Remoting.Services {
+    public sealed class EnterpriseServicesHelper {
+        public EnterpriseServicesHelper();
+        public static IConstructionReturnMessage CreateConstructionReturnMessage(IConstructionCallMessage ctorMsg, MarshalByRefObject retObj);
+        public static void SwitchWrappers(RealProxy oldcp, RealProxy newcp);
+        public static object WrapIUnknownWithComObject(IntPtr punk);
+    }
+    public interface ITrackingHandler {
+        void DisconnectedObject(object obj);
+        void MarshaledObject(object obj, ObjRef or);
+        void UnmarshaledObject(object obj, ObjRef or);
+    }
+    public abstract class RemotingClientProxy : Component {
+        protected object _tp;
+        protected string _url;
+        protected Type _type;
+        protected RemotingClientProxy();
+        public bool AllowAutoRedirect { get; set; }
+        public object Cookies { get; }
+        public string Domain { get; set; }
+        public bool EnableCookies { get; set; }
+        public string Password { get; set; }
+        public string Path { get; set; }
+        public bool PreAuthenticate { get; set; }
+        public string ProxyName { get; set; }
+        public int ProxyPort { get; set; }
+        public int Timeout { get; set; }
+        public string Url { get; set; }
+        public string UserAgent { get; set; }
+        public string Username { get; set; }
+        protected void ConfigureProxy(Type type, string url);
+        protected void ConnectProxy();
+    }
+    public class RemotingService : Component {
+        public RemotingService();
+        public HttpApplicationState Application { get; }
+        public HttpContext Context { get; }
+        public HttpServerUtility Server { get; }
+        public HttpSessionState Session { get; }
+        public IPrincipal User { get; }
+    }
+    public class TrackingServices {
+        public TrackingServices();
+        public static ITrackingHandler[] RegisteredHandlers { get; }
+        public static void RegisterTrackingHandler(ITrackingHandler handler);
+        public static void UnregisterTrackingHandler(ITrackingHandler handler);
+    }
+}
```

