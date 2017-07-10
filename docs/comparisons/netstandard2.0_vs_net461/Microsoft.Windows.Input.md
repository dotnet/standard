# Microsoft.Windows.Input

``` diff
+namespace Microsoft.Windows.Input {
+    public interface IPreviewCommand : ICommand {
+        void CancelPreview();
+        void Preview(object parameter);
+    }
+    public interface IPreviewCommandSource : ICommandSource {
+        object PreviewCommandParameter { get; }
+    }
+}
```

