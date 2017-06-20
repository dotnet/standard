# System.Diagnostics

``` diff
 namespace System.Diagnostics {
+    public class ConsoleTraceListener : TextWriterTraceListener {
+        public ConsoleTraceListener();
+        public ConsoleTraceListener(bool useErrorStream);
+        public override void Close();
+    }
+    public class CounterCreationData {
+        public CounterCreationData();
+        public CounterCreationData(string counterName, string counterHelp, PerformanceCounterType counterType);
+        public string CounterHelp { get; set; }
+        public string CounterName { get; set; }
+        public PerformanceCounterType CounterType { get; set; }
+    }
+    public class CounterCreationDataCollection : CollectionBase {
+        public CounterCreationDataCollection();
+        public CounterCreationDataCollection(CounterCreationDataCollection value);
+        public CounterCreationDataCollection(CounterCreationData[] value);
+        public CounterCreationData this[int index] { get; set; }
+        public int Add(CounterCreationData value);
+        public void AddRange(CounterCreationDataCollection value);
+        public void AddRange(CounterCreationData[] value);
+        public bool Contains(CounterCreationData value);
+        public void CopyTo(CounterCreationData[] array, int index);
+        public int IndexOf(CounterCreationData value);
+        public void Insert(int index, CounterCreationData value);
+        protected override void OnValidate(object value);
+        public virtual void Remove(CounterCreationData value);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct CounterSample {
+        public static CounterSample Empty;
+        public CounterSample(long rawValue, long baseValue, long counterFrequency, long systemFrequency, long timeStamp, long timeStamp100nSec, PerformanceCounterType counterType);
+        public CounterSample(long rawValue, long baseValue, long counterFrequency, long systemFrequency, long timeStamp, long timeStamp100nSec, PerformanceCounterType counterType, long counterTimeStamp);
+        public long BaseValue { get; }
+        public long CounterFrequency { get; }
+        public long CounterTimeStamp { get; }
+        public PerformanceCounterType CounterType { get; }
+        public long RawValue { get; }
+        public long SystemFrequency { get; }
+        public long TimeStamp { get; }
+        public long TimeStamp100nSec { get; }
+        public static float Calculate(CounterSample counterSample);
+        public static float Calculate(CounterSample counterSample, CounterSample nextCounterSample);
+        public bool Equals(CounterSample sample);
+        public override bool Equals(object o);
+        public override int GetHashCode();
+        public static bool operator ==(CounterSample a, CounterSample b);
+        public static bool operator !=(CounterSample a, CounterSample b);
+    }
+    public static class CounterSampleCalculator {
+        public static float ComputeCounterValue(CounterSample newSample);
+        public static float ComputeCounterValue(CounterSample oldSample, CounterSample newSample);
+    }
     public static class Debug {
+        public static TraceListenerCollection Listeners { get; }
     }
-    public static class Debugger {
+    public sealed class Debugger {
+        public Debugger();
     }
     public class DelimitedListTraceListener : TextWriterTraceListener {
-        protected override string[] GetSupportedAttributes();
+        protected internal override string[] GetSupportedAttributes();
     }
+    public class DiagnosticsConfigurationHandler : IConfigurationSectionHandler {
+        public DiagnosticsConfigurationHandler();
+        public virtual object Create(object parent, object configContext, XmlNode section);
+    }
+    public class EntryWrittenEventArgs : EventArgs {
+        public EntryWrittenEventArgs();
+        public EntryWrittenEventArgs(EventLogEntry entry);
+        public EventLogEntry Entry { get; }
+    }
+    public delegate void EntryWrittenEventHandler(object sender, EntryWrittenEventArgs e);
+    public class EventInstance {
+        public EventInstance(long instanceId, int categoryId);
+        public EventInstance(long instanceId, int categoryId, EventLogEntryType entryType);
+        public int CategoryId { get; set; }
+        public EventLogEntryType EntryType { get; set; }
+        public long InstanceId { get; set; }
+    }
+    public class EventLog : Component, ISupportInitialize {
+        public EventLog();
+        public EventLog(string logName);
+        public EventLog(string logName, string machineName);
+        public EventLog(string logName, string machineName, string source);
+        public bool EnableRaisingEvents { get; set; }
+        public EventLogEntryCollection Entries { get; }
+        public string Log { get; set; }
+        public string LogDisplayName { get; }
+        public string MachineName { get; set; }
+        public long MaximumKilobytes { get; set; }
+        public int MinimumRetentionDays { get; }
+        public OverflowAction OverflowAction { get; }
+        public string Source { get; set; }
+        public ISynchronizeInvoke SynchronizingObject { get; set; }
+        public event EntryWrittenEventHandler EntryWritten;
+        public void BeginInit();
+        public void Clear();
+        public void Close();
+        public static void CreateEventSource(EventSourceCreationData sourceData);
+        public static void CreateEventSource(string source, string logName);
+        public static void CreateEventSource(string source, string logName, string machineName);
+        public static void Delete(string logName);
+        public static void Delete(string logName, string machineName);
+        public static void DeleteEventSource(string source);
+        public static void DeleteEventSource(string source, string machineName);
+        protected override void Dispose(bool disposing);
+        public void EndInit();
+        public static bool Exists(string logName);
+        public static bool Exists(string logName, string machineName);
+        public static EventLog[] GetEventLogs();
+        public static EventLog[] GetEventLogs(string machineName);
+        public static string LogNameFromSourceName(string source, string machineName);
+        public void ModifyOverflowPolicy(OverflowAction action, int retentionDays);
+        public void RegisterDisplayName(string resourceFile, long resourceId);
+        public static bool SourceExists(string source);
+        public static bool SourceExists(string source, string machineName);
+        public void WriteEntry(string message);
+        public void WriteEntry(string message, EventLogEntryType type);
+        public void WriteEntry(string message, EventLogEntryType type, int eventID);
+        public void WriteEntry(string message, EventLogEntryType type, int eventID, short category);
+        public void WriteEntry(string message, EventLogEntryType type, int eventID, short category, byte[] rawData);
+        public static void WriteEntry(string source, string message);
+        public static void WriteEntry(string source, string message, EventLogEntryType type);
+        public static void WriteEntry(string source, string message, EventLogEntryType type, int eventID);
+        public static void WriteEntry(string source, string message, EventLogEntryType type, int eventID, short category);
+        public static void WriteEntry(string source, string message, EventLogEntryType type, int eventID, short category, byte[] rawData);
+        public void WriteEvent(EventInstance instance, byte[] data, params object[] values);
+        public void WriteEvent(EventInstance instance, params object[] values);
+        public static void WriteEvent(string source, EventInstance instance, byte[] data, params object[] values);
+        public static void WriteEvent(string source, EventInstance instance, params object[] values);
+    }
+    public sealed class EventLogEntry : Component, ISerializable {
+        public string Category { get; }
+        public short CategoryNumber { get; }
+        public byte[] Data { get; }
+        public EventLogEntryType EntryType { get; }
+        public int EventID { get; }
+        public int Index { get; }
+        public long InstanceId { get; }
+        public string MachineName { get; }
+        public string Message { get; }
+        public string[] ReplacementStrings { get; }
+        public string Source { get; }
+        public DateTime TimeGenerated { get; }
+        public DateTime TimeWritten { get; }
+        public string UserName { get; }
+        public bool Equals(EventLogEntry otherEntry);
+        void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class EventLogEntryCollection : ICollection, IEnumerable {
+        public int Count { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        public virtual EventLogEntry this[int index] { get; }
+        public void CopyTo(EventLogEntry[] entries, int index);
+        public IEnumerator GetEnumerator();
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+    }
+    public enum EventLogEntryType {
+        Error = 1,
+        FailureAudit = 16,
+        Information = 4,
+        SuccessAudit = 8,
+        Warning = 2,
+    }
+    public class EventLogInstaller : ComponentInstaller {
+        public EventLogInstaller();
+        public int CategoryCount { get; set; }
+        public string CategoryResourceFile { get; set; }
+        public string Log { get; set; }
+        public string MessageResourceFile { get; set; }
+        public string ParameterResourceFile { get; set; }
+        public string Source { get; set; }
+        public UninstallAction UninstallAction { get; set; }
+        public override void CopyFromComponent(IComponent component);
+        public override void Install(IDictionary stateSaver);
+        public override bool IsEquivalentInstaller(ComponentInstaller otherInstaller);
+        public override void Rollback(IDictionary savedState);
+        public override void Uninstall(IDictionary savedState);
+    }
+    public sealed class EventLogPermission : ResourcePermissionBase {
+        public EventLogPermission();
+        public EventLogPermission(EventLogPermissionAccess permissionAccess, string machineName);
+        public EventLogPermission(EventLogPermissionEntry[] permissionAccessEntries);
+        public EventLogPermission(PermissionState state);
+        public EventLogPermissionEntryCollection PermissionEntries { get; }
+    }
+    public enum EventLogPermissionAccess {
+        Administer = 48,
+        Audit = 10,
+        Browse = 2,
+        Instrument = 6,
+        None = 0,
+        Write = 16,
+    }
+    public class EventLogPermissionAttribute : CodeAccessSecurityAttribute {
+        public EventLogPermissionAttribute(SecurityAction action);
+        public string MachineName { get; set; }
+        public EventLogPermissionAccess PermissionAccess { get; set; }
+        public override IPermission CreatePermission();
+    }
+    public class EventLogPermissionEntry {
+        public EventLogPermissionEntry(EventLogPermissionAccess permissionAccess, string machineName);
+        public string MachineName { get; }
+        public EventLogPermissionAccess PermissionAccess { get; }
+    }
+    public class EventLogPermissionEntryCollection : CollectionBase {
+        public EventLogPermissionEntry this[int index] { get; set; }
+        public int Add(EventLogPermissionEntry value);
+        public void AddRange(EventLogPermissionEntryCollection value);
+        public void AddRange(EventLogPermissionEntry[] value);
+        public bool Contains(EventLogPermissionEntry value);
+        public void CopyTo(EventLogPermissionEntry[] array, int index);
+        public int IndexOf(EventLogPermissionEntry value);
+        public void Insert(int index, EventLogPermissionEntry value);
+        protected override void OnClear();
+        protected override void OnInsert(int index, object value);
+        protected override void OnRemove(int index, object value);
+        protected override void OnSet(int index, object oldValue, object newValue);
+        public void Remove(EventLogPermissionEntry value);
+    }
+    public sealed class EventLogTraceListener : TraceListener {
+        public EventLogTraceListener();
+        public EventLogTraceListener(EventLog eventLog);
+        public EventLogTraceListener(string source);
+        public EventLog EventLog { get; set; }
+        public override string Name { get; set; }
+        public override void Close();
+        protected override void Dispose(bool disposing);
+        public override void TraceData(TraceEventCache eventCache, string source, TraceEventType severity, int id, object data);
+        public override void TraceData(TraceEventCache eventCache, string source, TraceEventType severity, int id, params object[] data);
+        public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType severity, int id, string message);
+        public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType severity, int id, string format, params object[] args);
+        public override void Write(string message);
+        public override void WriteLine(string message);
+    }
+    public class EventSchemaTraceListener : TextWriterTraceListener {
+        public EventSchemaTraceListener(string fileName);
+        public EventSchemaTraceListener(string fileName, string name);
+        public EventSchemaTraceListener(string fileName, string name, int bufferSize);
+        public EventSchemaTraceListener(string fileName, string name, int bufferSize, TraceLogRetentionOption logRetentionOption);
+        public EventSchemaTraceListener(string fileName, string name, int bufferSize, TraceLogRetentionOption logRetentionOption, long maximumFileSize);
+        public EventSchemaTraceListener(string fileName, string name, int bufferSize, TraceLogRetentionOption logRetentionOption, long maximumFileSize, int maximumNumberOfFiles);
+        public int BufferSize { get; }
+        public override bool IsThreadSafe { get; }
+        public long MaximumFileSize { get; }
+        public int MaximumNumberOfFiles { get; }
+        public TraceLogRetentionOption TraceLogRetentionOption { get; }
+        public new TextWriter Writer { get; set; }
+        public override void Close();
+        public override void Fail(string message, string detailMessage);
+        public override void Flush();
+        protected override string[] GetSupportedAttributes();
+        public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, object data);
+        public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, params object[] data);
+        public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message);
+        public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string format, params object[] args);
+        public override void TraceTransfer(TraceEventCache eventCache, string source, int id, string message, Guid relatedActivityId);
+        public override void Write(string message);
+        public override void WriteLine(string message);
+    }
+    public class EventSourceCreationData {
+        public EventSourceCreationData(string source, string logName);
+        public int CategoryCount { get; set; }
+        public string CategoryResourceFile { get; set; }
+        public string LogName { get; set; }
+        public string MachineName { get; set; }
+        public string MessageResourceFile { get; set; }
+        public string ParameterResourceFile { get; set; }
+        public string Source { get; set; }
+    }
+    public interface ICollectData {
+        void CloseData();
+        void CollectData(int id, IntPtr valueName, IntPtr data, int totalBytes, out IntPtr res);
+    }
+    public class InstanceData {
+        public InstanceData(string instanceName, CounterSample sample);
+        public string InstanceName { get; }
+        public long RawValue { get; }
+        public CounterSample Sample { get; }
+    }
+    public class InstanceDataCollection : DictionaryBase {
+        public InstanceDataCollection(string counterName);
+        public string CounterName { get; }
+        public ICollection Keys { get; }
+        public InstanceData this[string instanceName] { get; }
+        public ICollection Values { get; }
+        public bool Contains(string instanceName);
+        public void CopyTo(InstanceData[] instances, int index);
+    }
+    public class InstanceDataCollectionCollection : DictionaryBase {
+        public InstanceDataCollectionCollection();
+        public ICollection Keys { get; }
+        public InstanceDataCollection this[string counterName] { get; }
+        public ICollection Values { get; }
+        public bool Contains(string counterName);
+        public void CopyTo(InstanceDataCollection[] counters, int index);
+    }
+    public enum OverflowAction {
+        DoNotOverwrite = -1,
+        OverwriteAsNeeded = 0,
+        OverwriteOlder = 1,
+    }
+    public sealed class PerformanceCounter : Component, ISupportInitialize {
+        public static int DefaultFileMappingSize;
+        public PerformanceCounter();
+        public PerformanceCounter(string categoryName, string counterName);
+        public PerformanceCounter(string categoryName, string counterName, bool readOnly);
+        public PerformanceCounter(string categoryName, string counterName, string instanceName);
+        public PerformanceCounter(string categoryName, string counterName, string instanceName, bool readOnly);
+        public PerformanceCounter(string categoryName, string counterName, string instanceName, string machineName);
+        public string CategoryName { get; set; }
+        public string CounterHelp { get; }
+        public string CounterName { get; set; }
+        public PerformanceCounterType CounterType { get; }
+        public PerformanceCounterInstanceLifetime InstanceLifetime { get; set; }
+        public string InstanceName { get; set; }
+        public string MachineName { get; set; }
+        public long RawValue { get; set; }
+        public bool ReadOnly { get; set; }
+        public void BeginInit();
+        public void Close();
+        public static void CloseSharedResources();
+        public long Decrement();
+        protected override void Dispose(bool disposing);
+        public void EndInit();
+        public long Increment();
+        public long IncrementBy(long value);
+        public CounterSample NextSample();
+        public float NextValue();
+        public void RemoveInstance();
+    }
+    public sealed class PerformanceCounterCategory {
+        public PerformanceCounterCategory();
+        public PerformanceCounterCategory(string categoryName);
+        public PerformanceCounterCategory(string categoryName, string machineName);
+        public string CategoryHelp { get; }
+        public string CategoryName { get; set; }
+        public PerformanceCounterCategoryType CategoryType { get; }
+        public string MachineName { get; set; }
+        public bool CounterExists(string counterName);
+        public static bool CounterExists(string counterName, string categoryName);
+        public static bool CounterExists(string counterName, string categoryName, string machineName);
+        public static PerformanceCounterCategory Create(string categoryName, string categoryHelp, CounterCreationDataCollection counterData);
+        public static PerformanceCounterCategory Create(string categoryName, string categoryHelp, PerformanceCounterCategoryType categoryType, CounterCreationDataCollection counterData);
+        public static PerformanceCounterCategory Create(string categoryName, string categoryHelp, PerformanceCounterCategoryType categoryType, string counterName, string counterHelp);
+        public static PerformanceCounterCategory Create(string categoryName, string categoryHelp, string counterName, string counterHelp);
+        public static void Delete(string categoryName);
+        public static bool Exists(string categoryName);
+        public static bool Exists(string categoryName, string machineName);
+        public static PerformanceCounterCategory[] GetCategories();
+        public static PerformanceCounterCategory[] GetCategories(string machineName);
+        public PerformanceCounter[] GetCounters();
+        public PerformanceCounter[] GetCounters(string instanceName);
+        public string[] GetInstanceNames();
+        public bool InstanceExists(string instanceName);
+        public static bool InstanceExists(string instanceName, string categoryName);
+        public static bool InstanceExists(string instanceName, string categoryName, string machineName);
+        public InstanceDataCollectionCollection ReadCategory();
+    }
+    public enum PerformanceCounterCategoryType {
+        MultiInstance = 1,
+        SingleInstance = 0,
+        Unknown = -1,
+    }
+    public class PerformanceCounterInstaller : ComponentInstaller {
+        public PerformanceCounterInstaller();
+        public string CategoryHelp { get; set; }
+        public string CategoryName { get; set; }
+        public PerformanceCounterCategoryType CategoryType { get; set; }
+        public CounterCreationDataCollection Counters { get; }
+        public UninstallAction UninstallAction { get; set; }
+        public override void CopyFromComponent(IComponent component);
+        public override void Install(IDictionary stateSaver);
+        public override void Rollback(IDictionary savedState);
+        public override void Uninstall(IDictionary savedState);
+    }
+    public enum PerformanceCounterInstanceLifetime {
+        Global = 0,
+        Process = 1,
+    }
+    public sealed class PerformanceCounterManager : ICollectData {
+        public PerformanceCounterManager();
+        void System.Diagnostics.ICollectData.CloseData();
+        void System.Diagnostics.ICollectData.CollectData(int callIdx, IntPtr valueNamePtr, IntPtr dataPtr, int totalBytes, out IntPtr res);
+    }
+    public sealed class PerformanceCounterPermission : ResourcePermissionBase {
+        public PerformanceCounterPermission();
+        public PerformanceCounterPermission(PerformanceCounterPermissionAccess permissionAccess, string machineName, string categoryName);
+        public PerformanceCounterPermission(PerformanceCounterPermissionEntry[] permissionAccessEntries);
+        public PerformanceCounterPermission(PermissionState state);
+        public PerformanceCounterPermissionEntryCollection PermissionEntries { get; }
+    }
+    public enum PerformanceCounterPermissionAccess {
+        Administer = 7,
+        Browse = 1,
+        Instrument = 3,
+        None = 0,
+        Read = 1,
+        Write = 2,
+    }
+    public class PerformanceCounterPermissionAttribute : CodeAccessSecurityAttribute {
+        public PerformanceCounterPermissionAttribute(SecurityAction action);
+        public string CategoryName { get; set; }
+        public string MachineName { get; set; }
+        public PerformanceCounterPermissionAccess PermissionAccess { get; set; }
+        public override IPermission CreatePermission();
+    }
+    public class PerformanceCounterPermissionEntry {
+        public PerformanceCounterPermissionEntry(PerformanceCounterPermissionAccess permissionAccess, string machineName, string categoryName);
+        public string CategoryName { get; }
+        public string MachineName { get; }
+        public PerformanceCounterPermissionAccess PermissionAccess { get; }
+    }
+    public class PerformanceCounterPermissionEntryCollection : CollectionBase {
+        public PerformanceCounterPermissionEntry this[int index] { get; set; }
+        public int Add(PerformanceCounterPermissionEntry value);
+        public void AddRange(PerformanceCounterPermissionEntryCollection value);
+        public void AddRange(PerformanceCounterPermissionEntry[] value);
+        public bool Contains(PerformanceCounterPermissionEntry value);
+        public void CopyTo(PerformanceCounterPermissionEntry[] array, int index);
+        public int IndexOf(PerformanceCounterPermissionEntry value);
+        public void Insert(int index, PerformanceCounterPermissionEntry value);
+        protected override void OnClear();
+        protected override void OnInsert(int index, object value);
+        protected override void OnRemove(int index, object value);
+        protected override void OnSet(int index, object oldValue, object newValue);
+        public void Remove(PerformanceCounterPermissionEntry value);
+    }
+    public enum PerformanceCounterType {
+        AverageBase = 1073939458,
+        AverageCount64 = 1073874176,
+        AverageTimer32 = 805438464,
+        CounterDelta32 = 4195328,
+        CounterDelta64 = 4195584,
+        CounterMultiBase = 1107494144,
+        CounterMultiTimer = 574686464,
+        CounterMultiTimer100Ns = 575735040,
+        CounterMultiTimer100NsInverse = 592512256,
+        CounterMultiTimerInverse = 591463680,
+        CounterTimer = 541132032,
+        CounterTimerInverse = 557909248,
+        CountPerTimeInterval32 = 4523008,
+        CountPerTimeInterval64 = 4523264,
+        ElapsedTime = 807666944,
+        NumberOfItems32 = 65536,
+        NumberOfItems64 = 65792,
+        NumberOfItemsHEX32 = 0,
+        NumberOfItemsHEX64 = 256,
+        RateOfCountsPerSecond32 = 272696320,
+        RateOfCountsPerSecond64 = 272696576,
+        RawBase = 1073939459,
+        RawFraction = 537003008,
+        SampleBase = 1073939457,
+        SampleCounter = 4260864,
+        SampleFraction = 549585920,
+        Timer100Ns = 542180608,
+        Timer100NsInverse = 558957824,
+    }
+    public enum PresentationTraceLevel {
+        High = 3,
+        Low = 1,
+        Medium = 2,
+        None = 0,
+    }
+    public static class PresentationTraceSources {
+        public static readonly DependencyProperty TraceLevelProperty;
+        public static TraceSource AnimationSource { get; }
+        public static TraceSource DataBindingSource { get; }
+        public static TraceSource DependencyPropertySource { get; }
+        public static TraceSource DocumentsSource { get; }
+        public static TraceSource FreezableSource { get; }
+        public static TraceSource HwndHostSource { get; }
+        public static TraceSource MarkupSource { get; }
+        public static TraceSource NameScopeSource { get; }
+        public static TraceSource ResourceDictionarySource { get; }
+        public static TraceSource RoutedEventSource { get; }
+        public static TraceSource ShellSource { get; }
+        public static PresentationTraceLevel GetTraceLevel(object element);
+        public static void Refresh();
+        public static void SetTraceLevel(object element, PresentationTraceLevel traceLevel);
+    }
-    public static class StackFrameExtensions {
 {
-        public static IntPtr GetNativeImageBase(this StackFrame stackFrame);

-        public static IntPtr GetNativeIP(this StackFrame stackFrame);

-        public static bool HasILOffset(this StackFrame stackFrame);

-        public static bool HasMethod(this StackFrame stackFrame);

-        public static bool HasNativeImage(this StackFrame stackFrame);

-        public static bool HasSource(this StackFrame stackFrame);

-    }
     public class StackTrace {
+        public StackTrace(Thread targetThread, bool needFileInfo);
     }
     public abstract class Switch {
-        protected virtual string[] GetSupportedAttributes();
+        protected internal virtual string[] GetSupportedAttributes();
     }
     public abstract class TraceListener : MarshalByRefObject, IDisposable {
-        protected virtual string[] GetSupportedAttributes();
+        protected internal virtual string[] GetSupportedAttributes();
     }
+    public enum TraceLogRetentionOption {
+        LimitedCircularFiles = 1,
+        LimitedSequentialFiles = 3,
+        SingleFileBoundedSize = 4,
+        SingleFileUnboundedSize = 2,
+        UnlimitedSequentialFiles = 0,
+    }
     public class TraceSource {
-        protected virtual string[] GetSupportedAttributes();
+        protected internal virtual string[] GetSupportedAttributes();
     }
+    public class UnescapedXmlDiagnosticData {
+        public UnescapedXmlDiagnosticData(string xmlPayload);
+        public string UnescapedXml { get; set; }
+        public override string ToString();
+    }
+    public class XmlWriterTraceListener : TextWriterTraceListener {
+        public XmlWriterTraceListener(Stream stream);
+        public XmlWriterTraceListener(Stream stream, string name);
+        public XmlWriterTraceListener(TextWriter writer);
+        public XmlWriterTraceListener(TextWriter writer, string name);
+        public XmlWriterTraceListener(string filename);
+        public XmlWriterTraceListener(string filename, string name);
+        public override void Close();
+        public override void Fail(string message, string detailMessage);
+        public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, object data);
+        public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, params object[] data);
+        public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message);
+        public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string format, params object[] args);
+        public override void TraceTransfer(TraceEventCache eventCache, string source, int id, string message, Guid relatedActivityId);
+        public override void Write(string message);
+        public override void WriteLine(string message);
+    }
 }
```

