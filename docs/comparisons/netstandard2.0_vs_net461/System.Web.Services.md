# System.Web.Services

``` diff
+namespace System.Web.Services {
+    public sealed class WebMethodAttribute : Attribute {
+        public WebMethodAttribute();
+        public WebMethodAttribute(bool enableSession);
+        public WebMethodAttribute(bool enableSession, TransactionOption transactionOption);
+        public WebMethodAttribute(bool enableSession, TransactionOption transactionOption, int cacheDuration);
+        public WebMethodAttribute(bool enableSession, TransactionOption transactionOption, int cacheDuration, bool bufferResponse);
+        public bool BufferResponse { get; set; }
+        public int CacheDuration { get; set; }
+        public string Description { get; set; }
+        public bool EnableSession { get; set; }
+        public string MessageName { get; set; }
+        public TransactionOption TransactionOption { get; set; }
+    }
+    public class WebService : MarshalByValueComponent {
+        public WebService();
+        public HttpApplicationState Application { get; }
+        public HttpContext Context { get; }
+        public HttpServerUtility Server { get; }
+        public HttpSessionState Session { get; }
+        public SoapProtocolVersion SoapVersion { get; }
+        public IPrincipal User { get; }
+    }
+    public sealed class WebServiceAttribute : Attribute {
+        public const string DefaultNamespace = "http://tempuri.org/";
+        public WebServiceAttribute();
+        public string Description { get; set; }
+        public string Name { get; set; }
+        public string Namespace { get; set; }
+    }
+    public sealed class WebServiceBindingAttribute : Attribute {
+        public WebServiceBindingAttribute();
+        public WebServiceBindingAttribute(string name);
+        public WebServiceBindingAttribute(string name, string ns);
+        public WebServiceBindingAttribute(string name, string ns, string location);
+        public WsiProfiles ConformsTo { get; set; }
+        public bool EmitConformanceClaims { get; set; }
+        public string Location { get; set; }
+        public string Name { get; set; }
+        public string Namespace { get; set; }
+    }
+    public enum WsiProfiles {
+        BasicProfile1_1 = 1,
+        None = 0,
+    }
+}
```

