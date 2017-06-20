# System.Web.Script.Services

``` diff
+namespace System.Web.Script.Services {
+    public sealed class GenerateScriptTypeAttribute : Attribute {
+        public GenerateScriptTypeAttribute(Type type);
+        public string ScriptTypeId { get; set; }
+        public Type Type { get; }
+    }
+    public static class ProxyGenerator {
+        public static string GetClientProxyScript(Type type, string path, bool debug);
+        public static string GetClientProxyScript(Type type, string path, bool debug, ServiceEndpoint serviceEndpoint);
+    }
+    public enum ResponseFormat {
+        Json = 0,
+        Xml = 1,
+    }
+    public sealed class ScriptMethodAttribute : Attribute {
+        public ScriptMethodAttribute();
+        public ResponseFormat ResponseFormat { get; set; }
+        public bool UseHttpGet { get; set; }
+        public bool XmlSerializeString { get; set; }
+    }
+    public sealed class ScriptServiceAttribute : Attribute {
+        public ScriptServiceAttribute();
+    }
+}
```

