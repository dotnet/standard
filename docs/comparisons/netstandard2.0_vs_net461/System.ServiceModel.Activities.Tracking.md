# System.ServiceModel.Activities.Tracking

``` diff
+namespace System.ServiceModel.Activities.Tracking {
+    public class ReceiveMessageRecord : CustomTrackingRecord {
+        protected ReceiveMessageRecord(ReceiveMessageRecord record);
+        public ReceiveMessageRecord(string name);
+        public Guid E2EActivityId { get; internal set; }
+        public Guid MessageId { get; }
+        protected override TrackingRecord Clone();
+    }
+    public class SendMessageRecord : CustomTrackingRecord {
+        protected SendMessageRecord(SendMessageRecord record);
+        public SendMessageRecord(string name);
+        public Guid E2EActivityId { get; set; }
+        protected override TrackingRecord Clone();
+    }
+}
```

