# Microsoft.VisualBasic.ApplicationServices

``` diff
+namespace Microsoft.VisualBasic.ApplicationServices {
+    public class ApplicationBase {
+        public ApplicationBase();
+        public CultureInfo Culture { get; }
+        public AssemblyInfo Info { get; }
+        public Log Log { get; }
+        public CultureInfo UICulture { get; }
+        public void ChangeCulture(string cultureName);
+        public void ChangeUICulture(string cultureName);
+        public string GetEnvironmentVariable(string name);
+    }
+    public class AssemblyInfo {
+        public AssemblyInfo(Assembly currentAssembly);
+        public string AssemblyName { get; }
+        public string CompanyName { get; }
+        public string Copyright { get; }
+        public string Description { get; }
+        public string DirectoryPath { get; }
+        public ReadOnlyCollection<Assembly> LoadedAssemblies { get; }
+        public string ProductName { get; }
+        public string StackTrace { get; }
+        public string Title { get; }
+        public string Trademark { get; }
+        public Version Version { get; }
+        public long WorkingSet { get; }
+    }
+    public enum AuthenticationMode {
+        ApplicationDefined = 1,
+        Windows = 0,
+    }
+    public enum BuiltInRole {
+        AccountOperator = 548,
+        Administrator = 544,
+        BackupOperator = 551,
+        Guest = 546,
+        PowerUser = 547,
+        PrintOperator = 550,
+        Replicator = 552,
+        SystemOperator = 549,
+        User = 545,
+    }
+    public class BuiltInRoleConverter : TypeConverter {
+        public BuiltInRoleConverter();
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public class CantStartSingleInstanceException : Exception {
+        public CantStartSingleInstanceException();
+        protected CantStartSingleInstanceException(SerializationInfo info, StreamingContext context);
+        public CantStartSingleInstanceException(string message);
+        public CantStartSingleInstanceException(string message, Exception inner);
+    }
+    public class ConsoleApplicationBase : ApplicationBase {
+        public ConsoleApplicationBase();
+        public ReadOnlyCollection<string> CommandLineArgs { get; }
+        public ApplicationDeployment Deployment { get; }
+        protected ReadOnlyCollection<string> InternalCommandLine { set; }
+        public bool IsNetworkDeployed { get; }
+    }
+    public class NoStartupFormException : Exception {
+        public NoStartupFormException();
+        protected NoStartupFormException(SerializationInfo info, StreamingContext context);
+        public NoStartupFormException(string message);
+        public NoStartupFormException(string message, Exception inner);
+    }
+    public delegate void ShutdownEventHandler(object sender, EventArgs e);
+    public enum ShutdownMode {
+        AfterAllFormsClose = 1,
+        AfterMainFormCloses = 0,
+    }
+    public class StartupEventArgs : CancelEventArgs {
+        public StartupEventArgs(ReadOnlyCollection<string> args);
+        public ReadOnlyCollection<string> CommandLine { get; }
+    }
+    public delegate void StartupEventHandler(object sender, StartupEventArgs e);
+    public class StartupNextInstanceEventArgs : EventArgs {
+        public StartupNextInstanceEventArgs(ReadOnlyCollection<string> args, bool bringToForegroundFlag);
+        public bool BringToForeground { get; set; }
+        public ReadOnlyCollection<string> CommandLine { get; }
+    }
+    public delegate void StartupNextInstanceEventHandler(object sender, StartupNextInstanceEventArgs e);
+    public class UnhandledExceptionEventArgs : ThreadExceptionEventArgs {
+        public UnhandledExceptionEventArgs(bool exitApplication, Exception exception);
+        public bool ExitApplication { get; set; }
+    }
+    public delegate void UnhandledExceptionEventHandler(object sender, UnhandledExceptionEventArgs e);
+    public class User {
+        public User();
+        public IPrincipal CurrentPrincipal { get; set; }
+        protected virtual IPrincipal InternalPrincipal { get; set; }
+        public bool IsAuthenticated { get; }
+        public string Name { get; }
+        public void InitializeWithWindowsUser();
+        public bool IsInRole(BuiltInRole role);
+        public bool IsInRole(string role);
+    }
+    public class WebUser : User {
+        public WebUser();
+        protected override IPrincipal InternalPrincipal { get; set; }
+    }
+    public class WindowsFormsApplicationBase : ConsoleApplicationBase {
+        public WindowsFormsApplicationBase();
+        public WindowsFormsApplicationBase(AuthenticationMode authenticationMode);
+        public ApplicationContext ApplicationContext { get; }
+        protected bool EnableVisualStyles { get; set; }
+        protected bool IsSingleInstance { get; set; }
+        protected Form MainForm { get; set; }
+        public int MinimumSplashScreenDisplayTime { get; set; }
+        public FormCollection OpenForms { get; }
+        public bool SaveMySettingsOnExit { get; set; }
+        protected internal ShutdownMode ShutdownStyle { get; set; }
+        public Form SplashScreen { get; set; }
+        protected static bool UseCompatibleTextRendering { get; }
+        public event NetworkAvailableEventHandler NetworkAvailabilityChanged;
+        public event ShutdownEventHandler Shutdown;
+        public event StartupEventHandler Startup;
+        public event StartupNextInstanceEventHandler StartupNextInstance;
+        public event UnhandledExceptionEventHandler UnhandledException;
+        public void DoEvents();
+        protected void HideSplashScreen();
+        protected virtual void OnCreateMainForm();
+        protected virtual void OnCreateSplashScreen();
+        protected virtual bool OnInitialize(ReadOnlyCollection<string> commandLineArgs);
+        protected virtual void OnRun();
+        protected virtual void OnShutdown();
+        protected virtual bool OnStartup(StartupEventArgs eventArgs);
+        protected virtual void OnStartupNextInstance(StartupNextInstanceEventArgs eventArgs);
+        protected virtual bool OnUnhandledException(UnhandledExceptionEventArgs e);
+        public void Run(string[] commandLine);
+        protected void ShowSplashScreen();
+    }
+}
```

