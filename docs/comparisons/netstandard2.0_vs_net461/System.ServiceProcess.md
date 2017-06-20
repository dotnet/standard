# System.ServiceProcess

``` diff
+namespace System.ServiceProcess {
+    public enum PowerBroadcastStatus {
+        BatteryLow = 9,
+        OemEvent = 11,
+        PowerStatusChange = 10,
+        QuerySuspend = 0,
+        QuerySuspendFailed = 2,
+        ResumeAutomatic = 18,
+        ResumeCritical = 6,
+        ResumeSuspend = 7,
+        Suspend = 4,
+    }
+    public enum ServiceAccount {
+        LocalService = 0,
+        LocalSystem = 2,
+        NetworkService = 1,
+        User = 3,
+    }
+    public class ServiceBase : Component {
+        public const int MaxNameLength = 80;
+        public ServiceBase();
+        public bool AutoLog { get; set; }
+        public bool CanHandlePowerEvent { get; set; }
+        public bool CanHandleSessionChangeEvent { get; set; }
+        public bool CanPauseAndContinue { get; set; }
+        public bool CanShutdown { get; set; }
+        public bool CanStop { get; set; }
+        public virtual EventLog EventLog { get; }
+        public int ExitCode { get; set; }
+        protected IntPtr ServiceHandle { get; }
+        public string ServiceName { get; set; }
+        protected override void Dispose(bool disposing);
+        protected virtual void OnContinue();
+        protected virtual void OnCustomCommand(int command);
+        protected virtual void OnPause();
+        protected virtual bool OnPowerEvent(PowerBroadcastStatus powerStatus);
+        protected virtual void OnSessionChange(SessionChangeDescription changeDescription);
+        protected virtual void OnShutdown();
+        protected virtual void OnStart(string[] args);
+        protected virtual void OnStop();
+        public void RequestAdditionalTime(int milliseconds);
+        public static void Run(ServiceBase service);
+        public static void Run(ServiceBase[] services);
+        public void ServiceMainCallback(int argCount, IntPtr argPointer);
+        public void Stop();
+    }
+    public class ServiceController : Component {
+        public ServiceController();
+        public ServiceController(string name);
+        public ServiceController(string name, string machineName);
+        public bool CanPauseAndContinue { get; }
+        public bool CanShutdown { get; }
+        public bool CanStop { get; }
+        public ServiceController[] DependentServices { get; }
+        public string DisplayName { get; set; }
+        public string MachineName { get; set; }
+        public SafeHandle ServiceHandle { get; }
+        public string ServiceName { get; set; }
+        public ServiceController[] ServicesDependedOn { get; }
+        public ServiceType ServiceType { get; }
+        public ServiceStartMode StartType { get; }
+        public ServiceControllerStatus Status { get; }
+        public void Close();
+        public void Continue();
+        protected override void Dispose(bool disposing);
+        public void ExecuteCommand(int command);
+        public static ServiceController[] GetDevices();
+        public static ServiceController[] GetDevices(string machineName);
+        public static ServiceController[] GetServices();
+        public static ServiceController[] GetServices(string machineName);
+        public void Pause();
+        public void Refresh();
+        public void Start();
+        public void Start(string[] args);
+        public void Stop();
+        public void WaitForStatus(ServiceControllerStatus desiredStatus);
+        public void WaitForStatus(ServiceControllerStatus desiredStatus, TimeSpan timeout);
+    }
+    public sealed class ServiceControllerPermission : ResourcePermissionBase {
+        public ServiceControllerPermission();
+        public ServiceControllerPermission(PermissionState state);
+        public ServiceControllerPermission(ServiceControllerPermissionAccess permissionAccess, string machineName, string serviceName);
+        public ServiceControllerPermission(ServiceControllerPermissionEntry[] permissionAccessEntries);
+        public ServiceControllerPermissionEntryCollection PermissionEntries { get; }
+    }
+    public enum ServiceControllerPermissionAccess {
+        Browse = 2,
+        Control = 6,
+        None = 0,
+    }
+    public class ServiceControllerPermissionAttribute : CodeAccessSecurityAttribute {
+        public ServiceControllerPermissionAttribute(SecurityAction action);
+        public string MachineName { get; set; }
+        public ServiceControllerPermissionAccess PermissionAccess { get; set; }
+        public string ServiceName { get; set; }
+        public override IPermission CreatePermission();
+    }
+    public class ServiceControllerPermissionEntry {
+        public ServiceControllerPermissionEntry();
+        public ServiceControllerPermissionEntry(ServiceControllerPermissionAccess permissionAccess, string machineName, string serviceName);
+        public string MachineName { get; }
+        public ServiceControllerPermissionAccess PermissionAccess { get; }
+        public string ServiceName { get; }
+    }
+    public class ServiceControllerPermissionEntryCollection : CollectionBase {
+        public ServiceControllerPermissionEntry this[int index] { get; set; }
+        public int Add(ServiceControllerPermissionEntry value);
+        public void AddRange(ServiceControllerPermissionEntryCollection value);
+        public void AddRange(ServiceControllerPermissionEntry[] value);
+        public bool Contains(ServiceControllerPermissionEntry value);
+        public void CopyTo(ServiceControllerPermissionEntry[] array, int index);
+        public int IndexOf(ServiceControllerPermissionEntry value);
+        public void Insert(int index, ServiceControllerPermissionEntry value);
+        protected override void OnClear();
+        protected override void OnInsert(int index, object value);
+        protected override void OnRemove(int index, object value);
+        protected override void OnSet(int index, object oldValue, object newValue);
+        public void Remove(ServiceControllerPermissionEntry value);
+    }
+    public enum ServiceControllerStatus {
+        ContinuePending = 5,
+        Paused = 7,
+        PausePending = 6,
+        Running = 4,
+        StartPending = 2,
+        Stopped = 1,
+        StopPending = 3,
+    }
+    public class ServiceInstaller : ComponentInstaller {
+        public ServiceInstaller();
+        public bool DelayedAutoStart { get; set; }
+        public string Description { get; set; }
+        public string DisplayName { get; set; }
+        public string ServiceName { get; set; }
+        public string[] ServicesDependedOn { get; set; }
+        public ServiceStartMode StartType { get; set; }
+        public override void CopyFromComponent(IComponent component);
+        public override void Install(IDictionary stateSaver);
+        public override bool IsEquivalentInstaller(ComponentInstaller otherInstaller);
+        public override void Rollback(IDictionary savedState);
+        public override void Uninstall(IDictionary savedState);
+    }
+    public class ServiceProcessDescriptionAttribute : DescriptionAttribute {
+        public ServiceProcessDescriptionAttribute(string description);
+        public override string Description { get; }
+    }
+    public class ServiceProcessInstaller : ComponentInstaller {
+        public ServiceProcessInstaller();
+        public ServiceAccount Account { get; set; }
+        public override string HelpText { get; }
+        public string Password { get; set; }
+        public string Username { get; set; }
+        public override void CopyFromComponent(IComponent comp);
+        public override void Install(IDictionary stateSaver);
+        public override void Rollback(IDictionary savedState);
+    }
+    public enum ServiceStartMode {
+        Automatic = 2,
+        Boot = 0,
+        Disabled = 4,
+        Manual = 3,
+        System = 1,
+    }
+    public enum ServiceType {
+        Adapter = 4,
+        FileSystemDriver = 2,
+        InteractiveProcess = 256,
+        KernelDriver = 1,
+        RecognizerDriver = 8,
+        Win32OwnProcess = 16,
+        Win32ShareProcess = 32,
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct SessionChangeDescription {
+        public SessionChangeReason Reason { get; }
+        public int SessionId { get; }
+        public override bool Equals(object obj);
+        public bool Equals(SessionChangeDescription changeDescription);
+        public override int GetHashCode();
+        public static bool operator ==(SessionChangeDescription a, SessionChangeDescription b);
+        public static bool operator !=(SessionChangeDescription a, SessionChangeDescription b);
+    }
+    public enum SessionChangeReason {
+        ConsoleConnect = 1,
+        ConsoleDisconnect = 2,
+        RemoteConnect = 3,
+        RemoteDisconnect = 4,
+        SessionLock = 7,
+        SessionLogoff = 6,
+        SessionLogon = 5,
+        SessionRemoteControl = 9,
+        SessionUnlock = 8,
+    }
+    public class TimeoutException : SystemException {
+        public TimeoutException();
+        protected TimeoutException(SerializationInfo info, StreamingContext context);
+        public TimeoutException(string message);
+        public TimeoutException(string message, Exception innerException);
+    }
+}
```

