# System.Web.UI.Design.Directives

``` diff
+namespace System.Web.UI.Design.Directives {
+    public sealed class DirectiveAttribute : Attribute {
+        public DirectiveAttribute();
+        public bool AllowedOnMobilePages { get; set; }
+        public string BuilderType { get; set; }
+        public bool Culture { get; set; }
+        public string RenameType { get; set; }
+        public bool ServerLanguageExtensions { get; set; }
+        public bool ServerLanguageNames { get; set; }
+    }
+    public static class DirectiveRegistry {
+        public static ReadOnlyCollection<Type> GetDirectives(Version frameworkVersion, string extension);
+    }
+    public sealed class SchemaElementNameAttribute : Attribute {
+        public SchemaElementNameAttribute(string value);
+        public string Value { get; private set; }
+    }
+}
```

