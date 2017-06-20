# System.Diagnostics.Eventing

``` diff
+namespace System.Diagnostics.Eventing {
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit, Size=16)]
+    public struct EventDescriptor {
+        public EventDescriptor(int id, byte version, byte channel, byte level, byte opcode, int task, long keywords);
+        public byte Channel { get; }
+        public int EventId { get; }
+        public long Keywords { get; }
+        public byte Level { get; }
+        public byte Opcode { get; }
+        public int Task { get; }
+        public byte Version { get; }
+    }
+    public class EventProvider : IDisposable {
+        public EventProvider(Guid providerGuid);
+        public virtual void Close();
+        public static Guid CreateActivityId();
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        ~EventProvider();
+        public static EventProvider.WriteEventErrorCode GetLastWriteEventError();
+        public bool IsEnabled();
+        public bool IsEnabled(byte level, long keywords);
+        public static void SetActivityId(ref Guid id);
+        protected bool WriteEvent(ref EventDescriptor eventDescriptor, int dataCount, IntPtr data);
+        public bool WriteEvent(ref EventDescriptor eventDescriptor, params object[] eventPayload);
+        public bool WriteEvent(ref EventDescriptor eventDescriptor, string data);
+        public bool WriteMessageEvent(string eventMessage);
+        public bool WriteMessageEvent(string eventMessage, byte eventLevel, long eventKeywords);
+        protected bool WriteTransferEvent(ref EventDescriptor eventDescriptor, Guid relatedActivityId, int dataCount, IntPtr data);
+        public bool WriteTransferEvent(ref EventDescriptor eventDescriptor, Guid relatedActivityId, params object[] eventPayload);
+        public enum WriteEventErrorCode {
+            EventTooBig = 2,
+            NoError = 0,
+            NoFreeBuffers = 1,
+        }
+    }
+    public class EventProviderTraceListener : TraceListener {
+        public EventProviderTraceListener(string providerId);
+        public EventProviderTraceListener(string providerId, string name);
+        public EventProviderTraceListener(string providerId, string name, string delimiter);
+        public string Delimiter { get; set; }
+        public sealed override bool IsThreadSafe { get; }
+        public override void Close();
+        public override void Fail(string message, string detailMessage);
+        public sealed override void Flush();
+        protected override string[] GetSupportedAttributes();
+        public sealed override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, object data);
+        public sealed override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, params object[] data);
+        public sealed override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id);
+        public sealed override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message);
+        public sealed override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string format, params object[] args);
+        public sealed override void TraceTransfer(TraceEventCache eventCache, string source, int id, string message, Guid relatedActivityId);
+        public sealed override void Write(string message);
+        public sealed override void WriteLine(string message);
+    }
+}
```

