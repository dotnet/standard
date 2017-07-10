# System.Web.Util

``` diff
+namespace System.Web.Util {
+    public class HttpEncoder {
+        public HttpEncoder();
+        public static HttpEncoder Current { get; set; }
+        public static HttpEncoder Default { get; }
+        protected internal virtual void HeaderNameValueEncode(string headerName, string headerValue, out string encodedHeaderName, out string encodedHeaderValue);
+        protected internal virtual void HtmlAttributeEncode(string value, TextWriter output);
+        protected internal virtual void HtmlDecode(string value, TextWriter output);
+        protected internal virtual void HtmlEncode(string value, TextWriter output);
+        protected internal virtual string JavaScriptStringEncode(string value);
+        protected internal virtual byte[] UrlEncode(byte[] bytes, int offset, int count);
+        protected internal virtual string UrlPathEncode(string value);
+    }
+    public interface IWebObjectFactory {
+        object CreateInstance();
+    }
+    public interface IWebPropertyAccessor {
+        object GetProperty(object target);
+        void SetProperty(object target, object value);
+    }
+    public enum RequestValidationSource {
+        Cookies = 2,
+        Files = 3,
+        Form = 1,
+        Headers = 7,
+        Path = 5,
+        PathInfo = 6,
+        QueryString = 0,
+        RawUrl = 4,
+    }
+    public class RequestValidator {
+        public RequestValidator();
+        public static RequestValidator Current { get; set; }
+        public bool InvokeIsValidRequestString(HttpContext context, string value, RequestValidationSource requestValidationSource, string collectionKey, out int validationFailureIndex);
+        protected internal virtual bool IsValidRequestString(HttpContext context, string value, RequestValidationSource requestValidationSource, string collectionKey, out int validationFailureIndex);
+    }
+    public delegate void TransactedCallback();
+    public class Transactions {
+        public Transactions();
+        public static void InvokeTransacted(TransactedCallback callback, TransactionOption mode);
+        public static void InvokeTransacted(TransactedCallback callback, TransactionOption mode, ref bool transactionAborted);
+    }
+    public class WorkItem {
+        public WorkItem();
+        public static void Post(WorkItemCallback callback);
+    }
+    public delegate void WorkItemCallback();
+}
```

