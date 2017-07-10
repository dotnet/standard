# System.Web.Handlers

``` diff
+namespace System.Web.Handlers {
+    public sealed class AssemblyResourceLoader : IHttpHandler {
+        public AssemblyResourceLoader();
+        bool System.Web.IHttpHandler.IsReusable { get; }
+        void System.Web.IHttpHandler.ProcessRequest(HttpContext context);
+    }
+    public class ScriptModule : IHttpModule {
+        public ScriptModule();
+        protected virtual void Dispose();
+        protected virtual void Init(HttpApplication app);
+        void System.Web.IHttpModule.Dispose();
+        void System.Web.IHttpModule.Init(HttpApplication context);
+    }
+    public class ScriptResourceHandler : IHttpHandler {
+        public ScriptResourceHandler();
+        protected virtual bool IsReusable { get; }
+        bool System.Web.IHttpHandler.IsReusable { get; }
+        protected virtual void ProcessRequest(HttpContext context);
+        void System.Web.IHttpHandler.ProcessRequest(HttpContext context);
+    }
+    public class TraceHandler : IHttpHandler {
+        public TraceHandler();
+        protected bool IsReusable { get; }
+        bool System.Web.IHttpHandler.IsReusable { get; }
+        protected void ProcessRequest(HttpContext context);
+        protected void ShowDetails(DataSet data);
+        protected void ShowRequests(IList data);
+        protected void ShowVersionDetails();
+        void System.Web.IHttpHandler.ProcessRequest(HttpContext context);
+    }
+}
```

