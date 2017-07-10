# System.Runtime.Serialization.Formatters

``` diff
 namespace System.Runtime.Serialization.Formatters {
+    public interface IFieldInfo {
+        string[] FieldNames { get; set; }
+        Type[] FieldTypes { get; set; }
+    }
 }
```

