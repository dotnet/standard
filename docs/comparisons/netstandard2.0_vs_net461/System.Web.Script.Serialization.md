# System.Web.Script.Serialization

``` diff
+namespace System.Web.Script.Serialization {
+    public abstract class JavaScriptConverter {
+        protected JavaScriptConverter();
+        public abstract IEnumerable<Type> SupportedTypes { get; }
+        public abstract object Deserialize(IDictionary<string, object> dictionary, Type type, JavaScriptSerializer serializer);
+        public abstract IDictionary<string, object> Serialize(object obj, JavaScriptSerializer serializer);
+    }
+    public class JavaScriptSerializer {
+        public JavaScriptSerializer();
+        public JavaScriptSerializer(JavaScriptTypeResolver resolver);
+        public int MaxJsonLength { get; set; }
+        public int RecursionLimit { get; set; }
+        public object ConvertToType(object obj, Type targetType);
+        public T ConvertToType<T>(object obj);
+        public object Deserialize(string input, Type targetType);
+        public T Deserialize<T>(string input);
+        public object DeserializeObject(string input);
+        public void RegisterConverters(IEnumerable<JavaScriptConverter> converters);
+        public string Serialize(object obj);
+        public void Serialize(object obj, StringBuilder output);
+    }
+    public abstract class JavaScriptTypeResolver {
+        protected JavaScriptTypeResolver();
+        public abstract Type ResolveType(string id);
+        public abstract string ResolveTypeId(Type type);
+    }
+    public sealed class ScriptIgnoreAttribute : Attribute {
+        public ScriptIgnoreAttribute();
+        public bool ApplyToOverrides { get; set; }
+    }
+    public class SimpleTypeResolver : JavaScriptTypeResolver {
+        public SimpleTypeResolver();
+        public override Type ResolveType(string id);
+        public override string ResolveTypeId(Type type);
+    }
+}
```

