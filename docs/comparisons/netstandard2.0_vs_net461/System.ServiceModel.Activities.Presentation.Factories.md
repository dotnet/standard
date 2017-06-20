# System.ServiceModel.Activities.Presentation.Factories

``` diff
+namespace System.ServiceModel.Activities.Presentation.Factories {
+    public sealed class ReceiveAndSendReplyFactory : IActivityTemplateFactory {
+        public ReceiveAndSendReplyFactory();
+        public Activity Create(DependencyObject target);
+    }
+    public sealed class SendAndReceiveReplyFactory : IActivityTemplateFactory {
+        public SendAndReceiveReplyFactory();
+        public Activity Create(DependencyObject target);
+    }
+}
```

