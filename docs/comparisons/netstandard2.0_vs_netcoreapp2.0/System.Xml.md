# System.Xml

``` diff
 namespace System.Xml {
+    public interface IApplicationResourceStreamResolver {
+        Stream GetApplicationResourceStream(Uri relativeUri);
+    }
 }
```

