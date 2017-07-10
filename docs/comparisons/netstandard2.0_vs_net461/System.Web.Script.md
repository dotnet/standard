# System.Web.Script

``` diff
+namespace System.Web.Script {
+    public class AjaxFrameworkAssemblyAttribute : Attribute {
+        public AjaxFrameworkAssemblyAttribute();
+        protected internal virtual Assembly GetDefaultAjaxFrameworkAssembly(Assembly currentAssembly);
+    }
+}
```

