# System.Activities.Statements.Tracking

``` diff
+namespace System.Activities.Statements.Tracking {
+    public sealed class StateMachineStateQuery : CustomTrackingQuery {
+        public StateMachineStateQuery();
+        public new string Name { get; }
+    }
+    public sealed class StateMachineStateRecord : CustomTrackingRecord {
+        public StateMachineStateRecord();
+        public string StateMachineName { get; internal set; }
+        public string StateName { get; internal set; }
+        protected internal override TrackingRecord Clone();
+    }
+}
```

