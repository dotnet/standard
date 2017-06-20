# System.EnterpriseServices.CompensatingResourceManager

``` diff
+namespace System.EnterpriseServices.CompensatingResourceManager {
+    public sealed class ApplicationCrmEnabledAttribute : Attribute {
+        public ApplicationCrmEnabledAttribute();
+        public ApplicationCrmEnabledAttribute(bool val);
+        public bool Value { get; }
+    }
+    public sealed class Clerk {
+        public Clerk(string compensator, string description, CompensatorOptions flags);
+        public Clerk(Type compensator, string description, CompensatorOptions flags);
+        public int LogRecordCount { get; }
+        public string TransactionUOW { get; }
+        ~Clerk();
+        public void ForceLog();
+        public void ForceTransactionToAbort();
+        public void ForgetLogRecord();
+        public void WriteLogRecord(object record);
+    }
+    public sealed class ClerkInfo {
+        public string ActivityId { get; }
+        public Clerk Clerk { get; }
+        public string Compensator { get; }
+        public string Description { get; }
+        public string InstanceId { get; }
+        public string TransactionUOW { get; }
+        ~ClerkInfo();
+    }
+    public sealed class ClerkMonitor : IEnumerable {
+        public ClerkMonitor();
+        public int Count { get; }
+        public ClerkInfo this[int index] { get; }
+        public ClerkInfo this[string index] { get; }
+        ~ClerkMonitor();
+        public IEnumerator GetEnumerator();
+        public void Populate();
+    }
+    public class Compensator : ServicedComponent {
+        public Compensator();
+        public Clerk Clerk { get; }
+        public virtual bool AbortRecord(LogRecord rec);
+        public virtual void BeginAbort(bool fRecovery);
+        public virtual void BeginCommit(bool fRecovery);
+        public virtual void BeginPrepare();
+        public virtual bool CommitRecord(LogRecord rec);
+        public virtual void EndAbort();
+        public virtual void EndCommit();
+        public virtual bool EndPrepare();
+        public virtual bool PrepareRecord(LogRecord rec);
+    }
+    public enum CompensatorOptions {
+        AbortPhase = 4,
+        AllPhases = 7,
+        CommitPhase = 2,
+        FailIfInDoubtsRemain = 16,
+        PreparePhase = 1,
+    }
+    public sealed class LogRecord {
+        public LogRecordFlags Flags { get; }
+        public object Record { get; }
+        public int Sequence { get; }
+    }
+    public enum LogRecordFlags {
+        ForgetTarget = 1,
+        ReplayInProgress = 64,
+        WrittenDuringAbort = 8,
+        WrittenDuringCommit = 4,
+        WrittenDuringPrepare = 2,
+        WrittenDuringReplay = 32,
+        WrittenDurringRecovery = 16,
+    }
+    public enum TransactionState {
+        Aborted = 2,
+        Active = 0,
+        Committed = 1,
+        Indoubt = 3,
+    }
+}
```

