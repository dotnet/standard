# System.Activities.Presentation.Sqm

``` diff
+namespace System.Activities.Presentation.Sqm {
+    public interface IVSSqmService {
+        void AddArrayToStream(int dataPointId, uint[] data, int count);
+        void AddItemToStream(int dataPointId, uint value);
+        void SetDatapoint(int dataPointId, uint value);
+    }
+}
```

