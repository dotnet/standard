# System.Diagnostics.Tracing

``` diff
 namespace System.Diagnostics.Tracing {
     public abstract class EventListener : IDisposable {
+        public event EventHandler<EventSourceCreatedEventArgs> EventSourceCreated;
+        public event EventHandler<EventWrittenEventArgs> EventWritten;
-        protected internal abstract void OnEventWritten(EventWrittenEventArgs eventData);
+        protected internal virtual void OnEventWritten(EventWrittenEventArgs eventData);
     }
+    public class EventSourceCreatedEventArgs : EventArgs {
+        public EventSourceCreatedEventArgs();
+        public EventSource EventSource { get; }
+    }
 }
```

