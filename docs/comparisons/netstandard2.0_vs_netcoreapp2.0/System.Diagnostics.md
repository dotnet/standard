# System.Diagnostics

``` diff
 namespace System.Diagnostics {
+    public class Activity {
+        public Activity(string operationName);
+        public IEnumerable<KeyValuePair<string, string>> Baggage { get; }
+        public static Activity Current { get; private set; }
+        public TimeSpan Duration { get; private set; }
+        public string Id { get; private set; }
+        public string OperationName { get; }
+        public Activity Parent { get; private set; }
+        public string ParentId { get; private set; }
+        public string RootId { get; private set; }
+        public DateTime StartTimeUtc { get; private set; }
+        public IEnumerable<KeyValuePair<string, string>> Tags { get; }
+        public Activity AddBaggage(string key, string value);
+        public Activity AddTag(string key, string value);
+        public string GetBaggageItem(string key);
+        public Activity SetEndTime(DateTime endTimeUtc);
+        public Activity SetParentId(string parentId);
+        public Activity SetStartTime(DateTime startTimeUtc);
+        public Activity Start();
+        public void Stop();
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
+    public class DiagnosticListener : DiagnosticSource, IDisposable, IObservable<KeyValuePair<string, object>> {
+        public DiagnosticListener(string name);
+        public static IObservable<DiagnosticListener> AllListeners { get; }
+        public string Name { get; }
+        public virtual void Dispose();
+        public bool IsEnabled();
+        public override bool IsEnabled(string name);
+        public override bool IsEnabled(string name, object arg1, object arg2=null);
+        public virtual IDisposable Subscribe(IObserver<KeyValuePair<string, object>> observer);
+        public virtual IDisposable Subscribe(IObserver<KeyValuePair<string, object>> observer, Func<string, object, object, bool> isEnabled);
+        public virtual IDisposable Subscribe(IObserver<KeyValuePair<string, object>> observer, Predicate<string> isEnabled);
+        public override void Write(string name, object parameters);
+    }
+    public abstract class DiagnosticSource {
+        protected DiagnosticSource();
+        public abstract bool IsEnabled(string name);
+        public virtual bool IsEnabled(string name, object arg1, object arg2=null);
+        public Activity StartActivity(Activity activity, object args);
+        public void StopActivity(Activity activity, object args);
+        public abstract void Write(string name, object value);
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
+        public void EndInit();
+        public long Increment();
+        public long IncrementBy(long value);
+        public CounterSample NextSample();
+        public float NextValue();
+        public void RemoveInstance();
+    }
+    public enum PerformanceCounterInstanceLifetime {
+        Global = 0,
+        Process = 1,
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
 }
```

