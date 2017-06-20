# Microsoft.VisualBasic.Logging

``` diff
+namespace Microsoft.VisualBasic.Logging {
+    public class AspLog : Log {
+        public AspLog();
+        public AspLog(string name);
+        protected internal override void InitializeWithDefaultsSinceNoConfigExists();
+    }
+    public enum DiskSpaceExhaustedOption {
+        DiscardMessages = 1,
+        ThrowException = 0,
+    }
+    public class FileLogTraceListener : TraceListener {
+        public FileLogTraceListener();
+        public FileLogTraceListener(string name);
+        public bool Append { get; set; }
+        public bool AutoFlush { get; set; }
+        public string BaseFileName { get; set; }
+        public string CustomLocation { get; set; }
+        public string Delimiter { get; set; }
+        public DiskSpaceExhaustedOption DiskSpaceExhaustedBehavior { get; set; }
+        public Encoding Encoding { get; set; }
+        public string FullLogFileName { get; }
+        public bool IncludeHostName { get; set; }
+        public LogFileLocation Location { get; set; }
+        public LogFileCreationScheduleOption LogFileCreationSchedule { get; set; }
+        public long MaxFileSize { get; set; }
+        public long ReserveDiskSpace { get; set; }
+        public override void Close();
+        protected override void Dispose(bool disposing);
+        public override void Flush();
+        protected override string[] GetSupportedAttributes();
+        public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, object data);
+        public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, params object[] data);
+        public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message);
+        public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string format, params object[] args);
+        public override void Write(string message);
+        public override void WriteLine(string message);
+    }
+    public class Log {
+        public Log();
+        public Log(string name);
+        public FileLogTraceListener DefaultFileLogWriter { get; }
+        public TraceSource TraceSource { get; }
+        protected internal virtual void InitializeWithDefaultsSinceNoConfigExists();
+        public void WriteEntry(string message);
+        public void WriteEntry(string message, TraceEventType severity);
+        public void WriteEntry(string message, TraceEventType severity, int id);
+        public void WriteException(Exception ex);
+        public void WriteException(Exception ex, TraceEventType severity, string additionalInfo);
+        public void WriteException(Exception ex, TraceEventType severity, string additionalInfo, int id);
+    }
+    public enum LogFileCreationScheduleOption {
+        Daily = 1,
+        None = 0,
+        Weekly = 2,
+    }
+    public enum LogFileLocation {
+        CommonApplicationDirectory = 2,
+        Custom = 4,
+        ExecutableDirectory = 3,
+        LocalUserApplicationDirectory = 1,
+        TempDirectory = 0,
+    }
+}
```

