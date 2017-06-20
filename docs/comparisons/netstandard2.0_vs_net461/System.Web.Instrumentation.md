# System.Web.Instrumentation

``` diff
+namespace System.Web.Instrumentation {
+    public class PageExecutionContext {
+        public PageExecutionContext();
+        public bool IsLiteral { get; set; }
+        public int Length { get; set; }
+        public int StartPosition { get; set; }
+        public TextWriter TextWriter { get; set; }
+        public string VirtualPath { get; set; }
+    }
+    public abstract class PageExecutionListener {
+        protected PageExecutionListener();
+        public abstract void BeginContext(PageExecutionContext context);
+        public abstract void EndContext(PageExecutionContext context);
+    }
+    public sealed class PageInstrumentationService {
+        public PageInstrumentationService();
+        public IList<PageExecutionListener> ExecutionListeners { get; }
+        public static bool IsEnabled { get; set; }
+    }
+}
```

