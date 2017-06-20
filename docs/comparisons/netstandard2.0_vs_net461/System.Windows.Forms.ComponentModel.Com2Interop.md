# System.Windows.Forms.ComponentModel.Com2Interop

``` diff
+namespace System.Windows.Forms.ComponentModel.Com2Interop {
+    public class Com2Variant {
+        public Com2Variant();
+    }
+    public interface ICom2PropertyPageDisplayService {
+        void ShowPropertyPage(string title, object component, int dispid, Guid pageGuid, IntPtr parentHandle);
+    }
+    public interface IComPropertyBrowser {
+        bool InPropertySet { get; }
+        event ComponentRenameEventHandler ComComponentNameChanged;
+        void DropDownDone();
+        bool EnsurePendingChangesCommitted();
+        void HandleF4();
+        void LoadState(RegistryKey key);
+        void SaveState(RegistryKey key);
+    }
+}
```

