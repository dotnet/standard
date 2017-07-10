# System.Activities.Core.Presentation.Themes

``` diff
+namespace System.Activities.Core.Presentation.Themes {
+    public sealed class DesignerStylesDictionary : ResourceDictionary, IComponentConnector {
+        public static Style SequenceStyle { get; }
+        public void InitializeComponent();
+        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target);
+    }
+}
```

