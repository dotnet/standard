# System.Messaging.Design

``` diff
+namespace System.Messaging.Design {
+    public class MessageDesigner : ComponentDesigner {
+        public MessageDesigner();
+        protected override void PreFilterProperties(IDictionary properties);
+    }
+    public class QueuePathDialog : Form {
+        public QueuePathDialog(IServiceProvider provider);
+        public QueuePathDialog(IUIService uiService);
+        public string Path { get; }
+        public void ChoosePath();
+        public void DoubleClicked(object source, EventArgs e);
+        protected override void OnFormClosing(FormClosingEventArgs e);
+        protected override void OnHandleCreated(EventArgs e);
+        public void SelectQueue(MessageQueue queue);
+    }
+    public class QueuePathEditor : UITypeEditor {
+        public QueuePathEditor();
+        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value);
+        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context);
+    }
+}
```

