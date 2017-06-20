# System.Configuration.Install

``` diff
+namespace System.Configuration.Install {
+    public class AssemblyInstaller : Installer {
+        public AssemblyInstaller();
+        public AssemblyInstaller(Assembly assembly, string[] commandLine);
+        public AssemblyInstaller(string fileName, string[] commandLine);
+        public Assembly Assembly { get; set; }
+        public string[] CommandLine { get; set; }
+        public override string HelpText { get; }
+        public string Path { get; set; }
+        public bool UseNewContext { get; set; }
+        public static void CheckIfInstallable(string assemblyName);
+        public override void Commit(IDictionary savedState);
+        public override void Install(IDictionary savedState);
+        public override void Rollback(IDictionary savedState);
+        public override void Uninstall(IDictionary savedState);
+    }
+    public abstract class ComponentInstaller : Installer {
+        protected ComponentInstaller();
+        public abstract void CopyFromComponent(IComponent component);
+        public virtual bool IsEquivalentInstaller(ComponentInstaller otherInstaller);
+    }
+    public interface IManagedInstaller {
+        int ManagedInstall(string commandLine, int hInstall);
+    }
+    public class InstallContext {
+        public InstallContext();
+        public InstallContext(string logFilePath, string[] commandLine);
+        public StringDictionary Parameters { get; }
+        public bool IsParameterTrue(string paramName);
+        public void LogMessage(string message);
+        protected static StringDictionary ParseCommandLine(string[] args);
+    }
+    public class Installer : Component {
+        public Installer();
+        public InstallContext Context { get; set; }
+        public virtual string HelpText { get; }
+        public InstallerCollection Installers { get; }
+        public Installer Parent { get; set; }
+        public event InstallEventHandler AfterInstall;
+        public event InstallEventHandler AfterRollback;
+        public event InstallEventHandler AfterUninstall;
+        public event InstallEventHandler BeforeInstall;
+        public event InstallEventHandler BeforeRollback;
+        public event InstallEventHandler BeforeUninstall;
+        public event InstallEventHandler Committed;
+        public event InstallEventHandler Committing;
+        public virtual void Commit(IDictionary savedState);
+        public virtual void Install(IDictionary stateSaver);
+        protected virtual void OnAfterInstall(IDictionary savedState);
+        protected virtual void OnAfterRollback(IDictionary savedState);
+        protected virtual void OnAfterUninstall(IDictionary savedState);
+        protected virtual void OnBeforeInstall(IDictionary savedState);
+        protected virtual void OnBeforeRollback(IDictionary savedState);
+        protected virtual void OnBeforeUninstall(IDictionary savedState);
+        protected virtual void OnCommitted(IDictionary savedState);
+        protected virtual void OnCommitting(IDictionary savedState);
+        public virtual void Rollback(IDictionary savedState);
+        public virtual void Uninstall(IDictionary savedState);
+    }
+    public class InstallerCollection : CollectionBase {
+        public Installer this[int index] { get; set; }
+        public int Add(Installer value);
+        public void AddRange(InstallerCollection value);
+        public void AddRange(Installer[] value);
+        public bool Contains(Installer value);
+        public void CopyTo(Installer[] array, int index);
+        public int IndexOf(Installer value);
+        public void Insert(int index, Installer value);
+        protected override void OnInsert(int index, object value);
+        protected override void OnRemove(int index, object value);
+        protected override void OnSet(int index, object oldValue, object newValue);
+        public void Remove(Installer value);
+    }
+    public class InstallEventArgs : EventArgs {
+        public InstallEventArgs();
+        public InstallEventArgs(IDictionary savedState);
+        public IDictionary SavedState { get; }
+    }
+    public delegate void InstallEventHandler(object sender, InstallEventArgs e);
+    public class InstallException : SystemException {
+        public InstallException();
+        protected InstallException(SerializationInfo info, StreamingContext context);
+        public InstallException(string message);
+        public InstallException(string message, Exception innerException);
+    }
+    public class ManagedInstallerClass : IManagedInstaller {
+        public ManagedInstallerClass();
+        public static void InstallHelper(string[] args);
+        int System.Configuration.Install.IManagedInstaller.ManagedInstall(string argString, int hInstall);
+    }
+    public class TransactedInstaller : Installer {
+        public TransactedInstaller();
+        public override void Install(IDictionary savedState);
+        public override void Uninstall(IDictionary savedState);
+    }
+    public enum UninstallAction {
+        NoAction = 1,
+        Remove = 0,
+    }
+}
```

