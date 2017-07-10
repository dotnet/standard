# System.Text

``` diff
 namespace System.Text {
+    public sealed class CodePagesEncodingProvider {
+        public static EncodingProvider Instance { get; }
+    }
+    public enum NormalizationForm {
+        FormC = 1,
+        FormD = 2,
+        FormKC = 5,
+        FormKD = 6,
+    }
 }
```

