# Microsoft.Win32

``` diff
+namespace Microsoft.Win32 {
+    public abstract class CommonDialog {
+        protected CommonDialog();
+        public object Tag { get; set; }
+        protected virtual void CheckPermissionsToShowDialog();
+        protected virtual IntPtr HookProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam);
+        public abstract void Reset();
+        protected abstract bool RunDialog(IntPtr hwndOwner);
+        public virtual Nullable<bool> ShowDialog();
+        public Nullable<bool> ShowDialog(Window owner);
+    }
+    public abstract class FileDialog : CommonDialog {
+        protected FileDialog();
+        public bool AddExtension { get; set; }
+        public virtual bool CheckFileExists { get; set; }
+        public bool CheckPathExists { get; set; }
+        public IList<FileDialogCustomPlace> CustomPlaces { get; set; }
+        public string DefaultExt { get; set; }
+        public bool DereferenceLinks { get; set; }
+        public string FileName { get; set; }
+        public string[] FileNames { get; }
+        public string Filter { get; set; }
+        public int FilterIndex { get; set; }
+        public string InitialDirectory { get; set; }
+        protected int Options { get; }
+        public bool RestoreDirectory { get; set; }
+        public string SafeFileName { get; }
+        public string[] SafeFileNames { get; }
+        public string Title { get; set; }
+        public bool ValidateNames { get; set; }
+        public event CancelEventHandler FileOk;
+        protected override IntPtr HookProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam);
+        protected void OnFileOk(CancelEventArgs e);
+        public override void Reset();
+        protected override bool RunDialog(IntPtr hwndOwner);
+        public override string ToString();
+    }
+    public sealed class FileDialogCustomPlace {
+        public FileDialogCustomPlace(Guid knownFolder);
+        public FileDialogCustomPlace(string path);
+        public Guid KnownFolder { get; private set; }
+        public string Path { get; private set; }
+    }
+    public static class FileDialogCustomPlaces {
+        public static FileDialogCustomPlace Contacts { get; }
+        public static FileDialogCustomPlace Cookies { get; }
+        public static FileDialogCustomPlace Desktop { get; }
+        public static FileDialogCustomPlace Documents { get; }
+        public static FileDialogCustomPlace Favorites { get; }
+        public static FileDialogCustomPlace LocalApplicationData { get; }
+        public static FileDialogCustomPlace Music { get; }
+        public static FileDialogCustomPlace Pictures { get; }
+        public static FileDialogCustomPlace ProgramFiles { get; }
+        public static FileDialogCustomPlace ProgramFilesCommon { get; }
+        public static FileDialogCustomPlace Programs { get; }
+        public static FileDialogCustomPlace RoamingApplicationData { get; }
+        public static FileDialogCustomPlace SendTo { get; }
+        public static FileDialogCustomPlace StartMenu { get; }
+        public static FileDialogCustomPlace Startup { get; }
+        public static FileDialogCustomPlace System { get; }
+        public static FileDialogCustomPlace Templates { get; }
+    }
+    public class IntranetZoneCredentialPolicy : ICredentialPolicy {
+        public IntranetZoneCredentialPolicy();
+        public virtual bool ShouldSendCredential(Uri challengeUri, WebRequest request, NetworkCredential credential, IAuthenticationModule authModule);
+    }
+    public sealed class OpenFileDialog : FileDialog {
+        public OpenFileDialog();
+        public bool Multiselect { get; set; }
+        public bool ReadOnlyChecked { get; set; }
+        public bool ShowReadOnly { get; set; }
+        protected override void CheckPermissionsToShowDialog();
+        public Stream OpenFile();
+        public Stream[] OpenFiles();
+        public override void Reset();
+    }
+    public class PowerModeChangedEventArgs : EventArgs {
+        public PowerModeChangedEventArgs(PowerModes mode);
+        public PowerModes Mode { get; }
+    }
+    public delegate void PowerModeChangedEventHandler(object sender, PowerModeChangedEventArgs e);
+    public enum PowerModes {
+        Resume = 1,
+        StatusChange = 2,
+        Suspend = 3,
+    }
+    public static class Registry {
+        public static readonly RegistryKey ClassesRoot;
+        public static readonly RegistryKey CurrentConfig;
+        public static readonly RegistryKey CurrentUser;
+        public static readonly RegistryKey DynData;
+        public static readonly RegistryKey LocalMachine;
+        public static readonly RegistryKey PerformanceData;
+        public static readonly RegistryKey Users;
+        public static object GetValue(string keyName, string valueName, object defaultValue);
+        public static void SetValue(string keyName, string valueName, object value);
+        public static void SetValue(string keyName, string valueName, object value, RegistryValueKind valueKind);
+    }
+    public enum RegistryHive {
+        ClassesRoot = -2147483648,
+        CurrentConfig = -2147483643,
+        CurrentUser = -2147483647,
+        DynData = -2147483642,
+        LocalMachine = -2147483646,
+        PerformanceData = -2147483644,
+        Users = -2147483645,
+    }
+    public sealed class RegistryKey : MarshalByRefObject, IDisposable {
+        public SafeRegistryHandle Handle { get; }
+        public string Name { get; }
+        public int SubKeyCount { get; }
+        public int ValueCount { get; }
+        public RegistryView View { get; }
+        public void Close();
+        public RegistryKey CreateSubKey(string subkey);
+        public RegistryKey CreateSubKey(string subkey, RegistryKeyPermissionCheck permissionCheck);
+        public RegistryKey CreateSubKey(string subkey, RegistryKeyPermissionCheck permissionCheck, RegistryOptions options);
+        public RegistryKey CreateSubKey(string subkey, RegistryKeyPermissionCheck permissionCheck, RegistryOptions registryOptions, RegistrySecurity registrySecurity);
+        public RegistryKey CreateSubKey(string subkey, RegistryKeyPermissionCheck permissionCheck, RegistrySecurity registrySecurity);
+        public RegistryKey CreateSubKey(string subkey, bool writable);
+        public RegistryKey CreateSubKey(string subkey, bool writable, RegistryOptions options);
+        public void DeleteSubKey(string subkey);
+        public void DeleteSubKey(string subkey, bool throwOnMissingSubKey);
+        public void DeleteSubKeyTree(string subkey);
+        public void DeleteSubKeyTree(string subkey, bool throwOnMissingSubKey);
+        public void DeleteValue(string name);
+        public void DeleteValue(string name, bool throwOnMissingValue);
+        public void Dispose();
+        public void Flush();
+        public static RegistryKey FromHandle(SafeRegistryHandle handle);
+        public static RegistryKey FromHandle(SafeRegistryHandle handle, RegistryView view);
+        public RegistrySecurity GetAccessControl();
+        public RegistrySecurity GetAccessControl(AccessControlSections includeSections);
+        public string[] GetSubKeyNames();
+        public object GetValue(string name);
+        public object GetValue(string name, object defaultValue);
+        public object GetValue(string name, object defaultValue, RegistryValueOptions options);
+        public RegistryValueKind GetValueKind(string name);
+        public string[] GetValueNames();
+        public static RegistryKey OpenBaseKey(RegistryHive hKey, RegistryView view);
+        public static RegistryKey OpenRemoteBaseKey(RegistryHive hKey, string machineName);
+        public static RegistryKey OpenRemoteBaseKey(RegistryHive hKey, string machineName, RegistryView view);
+        public RegistryKey OpenSubKey(string name);
+        public RegistryKey OpenSubKey(string name, RegistryKeyPermissionCheck permissionCheck);
+        public RegistryKey OpenSubKey(string name, RegistryKeyPermissionCheck permissionCheck, RegistryRights rights);
+        public RegistryKey OpenSubKey(string name, bool writable);
+        public RegistryKey OpenSubKey(string name, RegistryRights rights);
+        public void SetAccessControl(RegistrySecurity registrySecurity);
+        public void SetValue(string name, object value);
+        public void SetValue(string name, object value, RegistryValueKind valueKind);
+        public override string ToString();
+    }
+    public enum RegistryKeyPermissionCheck {
+        Default = 0,
+        ReadSubTree = 1,
+        ReadWriteSubTree = 2,
+    }
+    public enum RegistryOptions {
+        None = 0,
+        Volatile = 1,
+    }
+    public enum RegistryValueKind {
+        Binary = 3,
+        DWord = 4,
+        ExpandString = 2,
+        MultiString = 7,
+        None = -1,
+        QWord = 11,
+        String = 1,
+        Unknown = 0,
+    }
+    public enum RegistryValueOptions {
+        DoNotExpandEnvironmentNames = 1,
+        None = 0,
+    }
+    public enum RegistryView {
+        Default = 0,
+        Registry32 = 512,
+        Registry64 = 256,
+    }
+    public sealed class SaveFileDialog : FileDialog {
+        public SaveFileDialog();
+        public bool CreatePrompt { get; set; }
+        public bool OverwritePrompt { get; set; }
+        public Stream OpenFile();
+        public override void Reset();
+    }
+    public class SessionEndedEventArgs : EventArgs {
+        public SessionEndedEventArgs(SessionEndReasons reason);
+        public SessionEndReasons Reason { get; }
+    }
+    public delegate void SessionEndedEventHandler(object sender, SessionEndedEventArgs e);
+    public class SessionEndingEventArgs : EventArgs {
+        public SessionEndingEventArgs(SessionEndReasons reason);
+        public bool Cancel { get; set; }
+        public SessionEndReasons Reason { get; }
+    }
+    public delegate void SessionEndingEventHandler(object sender, SessionEndingEventArgs e);
+    public enum SessionEndReasons {
+        Logoff = 1,
+        SystemShutdown = 2,
+    }
+    public class SessionSwitchEventArgs : EventArgs {
+        public SessionSwitchEventArgs(SessionSwitchReason reason);
+        public SessionSwitchReason Reason { get; }
+    }
+    public delegate void SessionSwitchEventHandler(object sender, SessionSwitchEventArgs e);
+    public enum SessionSwitchReason {
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
+    public sealed class SystemEvents {
+        public static event EventHandler DisplaySettingsChanged;
+        public static event EventHandler DisplaySettingsChanging;
+        public static event EventHandler EventsThreadShutdown;
+        public static event EventHandler InstalledFontsChanged;
+        public static event EventHandler LowMemory;
+        public static event EventHandler PaletteChanged;
+        public static event PowerModeChangedEventHandler PowerModeChanged;
+        public static event SessionEndedEventHandler SessionEnded;
+        public static event SessionEndingEventHandler SessionEnding;
+        public static event SessionSwitchEventHandler SessionSwitch;
+        public static event EventHandler TimeChanged;
+        public static event TimerElapsedEventHandler TimerElapsed;
+        public static event UserPreferenceChangedEventHandler UserPreferenceChanged;
+        public static event UserPreferenceChangingEventHandler UserPreferenceChanging;
+        public static IntPtr CreateTimer(int interval);
+        public static void InvokeOnEventsThread(Delegate method);
+        public static void KillTimer(IntPtr timerId);
+    }
+    public class TimerElapsedEventArgs : EventArgs {
+        public TimerElapsedEventArgs(IntPtr timerId);
+        public IntPtr TimerId { get; }
+    }
+    public delegate void TimerElapsedEventHandler(object sender, TimerElapsedEventArgs e);
+    public enum UserPreferenceCategory {
+        Accessibility = 1,
+        Color = 2,
+        Desktop = 3,
+        General = 4,
+        Icon = 5,
+        Keyboard = 6,
+        Locale = 13,
+        Menu = 7,
+        Mouse = 8,
+        Policy = 9,
+        Power = 10,
+        Screensaver = 11,
+        VisualStyle = 14,
+        Window = 12,
+    }
+    public class UserPreferenceChangedEventArgs : EventArgs {
+        public UserPreferenceChangedEventArgs(UserPreferenceCategory category);
+        public UserPreferenceCategory Category { get; }
+    }
+    public delegate void UserPreferenceChangedEventHandler(object sender, UserPreferenceChangedEventArgs e);
+    public class UserPreferenceChangingEventArgs : EventArgs {
+        public UserPreferenceChangingEventArgs(UserPreferenceCategory category);
+        public UserPreferenceCategory Category { get; }
+    }
+    public delegate void UserPreferenceChangingEventHandler(object sender, UserPreferenceChangingEventArgs e);
+}
```

