# System.Web.UI.Design.MobileControls

``` diff
+namespace System.Web.UI.Design.MobileControls {
+    public interface IMobileDesigner {
+        void UpdateRendering();
+    }
+    public interface IMobileWebFormServices {
+        void ClearUndoStack();
+        object GetCache(string controlID, object key);
+        void RefreshPageView();
+        void SetCache(string controlID, object key, object value);
+        void UpdateRenderingRecursive(Control rootControl);
+    }
+    public sealed class MobileResource {
+        public static string GetString(string name);
+    }
+}
```

