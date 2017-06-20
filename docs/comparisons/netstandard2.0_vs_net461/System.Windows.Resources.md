# System.Windows.Resources

``` diff
+namespace System.Windows.Resources {
+    public sealed class AssemblyAssociatedContentFileAttribute : Attribute {
+        public AssemblyAssociatedContentFileAttribute(string relativeContentFilePath);
+        public string RelativeContentFilePath { get; }
+    }
+    public sealed class ContentTypes {
+        public const string XamlContentType = "applicaton/xaml+xml";
+        public ContentTypes();
+    }
+    public class StreamResourceInfo {
+        public StreamResourceInfo();
+        public StreamResourceInfo(Stream stream, string contentType);
+        public string ContentType { get; }
+        public Stream Stream { get; }
+    }
+}
```

