# System.Diagnostics.Tracing

``` diff
 namespace System.Diagnostics.Tracing {
-    public class EventCounter {
 {
-        public EventCounter(string name, EventSource eventSource);

-        public void WriteMetric(float value);

-    }
     public class EventSource : IDisposable {
-        public event EventHandler<EventCommandEventArgs> EventCommandExecuted;

     }
 }
```

