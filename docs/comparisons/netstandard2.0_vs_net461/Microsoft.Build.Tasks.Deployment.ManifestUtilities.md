# Microsoft.Build.Tasks.Deployment.ManifestUtilities

``` diff
+namespace Microsoft.Build.Tasks.Deployment.ManifestUtilities {
+    public sealed class ApplicationIdentity {
+        public ApplicationIdentity(string url, AssemblyIdentity deployManifestIdentity, AssemblyIdentity applicationManifestIdentity);
+        public ApplicationIdentity(string url, string deployManifestPath, string applicationManifestPath);
+        public override string ToString();
+    }
+    public sealed class ApplicationManifest : AssemblyManifest {
+        public ApplicationManifest();
+        public ApplicationManifest(string targetFrameworkVersion);
+        public string ConfigFile { get; set; }
+        public override AssemblyReference EntryPoint { get; set; }
+        public string ErrorReportUrl { get; set; }
+        public FileAssociationCollection FileAssociations { get; }
+        public bool HostInBrowser { get; set; }
+        public string IconFile { get; set; }
+        public bool IsClickOnceManifest { get; set; }
+        public int MaxTargetPath { get; set; }
+        public string OSDescription { get; set; }
+        public string OSSupportUrl { get; set; }
+        public string OSVersion { get; set; }
+        public string Product { get; set; }
+        public string Publisher { get; set; }
+        public string SuiteName { get; set; }
+        public string SupportUrl { get; set; }
+        public string TargetFrameworkVersion { get; set; }
+        public TrustInfo TrustInfo { get; set; }
+        public bool UseApplicationTrust { get; set; }
+        public string XmlConfigFile { get; set; }
+        public AssemblyIdentity XmlEntryPointIdentity { get; set; }
+        public string XmlEntryPointParameters { get; set; }
+        public string XmlEntryPointPath { get; set; }
+        public string XmlErrorReportUrl { get; set; }
+        public FileAssociation[] XmlFileAssociations { get; set; }
+        public string XmlHostInBrowser { get; set; }
+        public string XmlIconFile { get; set; }
+        public string XmlIsClickOnceManifest { get; set; }
+        public string XmlOSBuild { get; set; }
+        public string XmlOSDescription { get; set; }
+        public string XmlOSMajor { get; set; }
+        public string XmlOSMinor { get; set; }
+        public string XmlOSRevision { get; set; }
+        public string XmlOSSupportUrl { get; set; }
+        public string XmlProduct { get; set; }
+        public string XmlPublisher { get; set; }
+        public string XmlSuiteName { get; set; }
+        public string XmlSupportUrl { get; set; }
+        public string XmlUseApplicationTrust { get; set; }
+        public override void Validate();
+    }
+    public sealed class AssemblyIdentity {
+        public AssemblyIdentity();
+        public AssemblyIdentity(AssemblyIdentity identity);
+        public AssemblyIdentity(string name);
+        public AssemblyIdentity(string name, string version);
+        public AssemblyIdentity(string name, string version, string publicKeyToken, string culture);
+        public AssemblyIdentity(string name, string version, string publicKeyToken, string culture, string processorArchitecture);
+        public AssemblyIdentity(string name, string version, string publicKeyToken, string culture, string processorArchitecture, string type);
+        public string Culture { get; set; }
+        public bool IsFrameworkAssembly { get; }
+        public bool IsNeutralPlatform { get; }
+        public bool IsStrongName { get; }
+        public string Name { get; set; }
+        public string ProcessorArchitecture { get; set; }
+        public string PublicKeyToken { get; set; }
+        public string Type { get; set; }
+        public string Version { get; set; }
+        public string XmlCulture { get; set; }
+        public string XmlName { get; set; }
+        public string XmlProcessorArchitecture { get; set; }
+        public string XmlPublicKeyToken { get; set; }
+        public string XmlType { get; set; }
+        public string XmlVersion { get; set; }
+        public static AssemblyIdentity FromAssemblyName(string assemblyName);
+        public static AssemblyIdentity FromFile(string path);
+        public static AssemblyIdentity FromManagedAssembly(string path);
+        public static AssemblyIdentity FromManifest(string path);
+        public static AssemblyIdentity FromNativeAssembly(string path);
+        public string GetFullName(AssemblyIdentity.FullNameFlags flags);
+        public override string ToString();
+        public enum FullNameFlags {
+            All = 3,
+            Default = 0,
+            ProcessorArchitecture = 1,
+            Type = 2,
+        }
+    }
+    public class AssemblyManifest : Manifest {
+        public AssemblyManifest();
+        public ProxyStub[] ExternalProxyStubs { get; }
+        public ProxyStub[] XmlExternalProxyStubs { get; set; }
+    }
+    public sealed class AssemblyReference : BaseReference {
+        public AssemblyReference();
+        public AssemblyReference(string path);
+        public AssemblyIdentity AssemblyIdentity { get; set; }
+        public bool IsPrerequisite { get; set; }
+        public AssemblyReferenceType ReferenceType { get; set; }
+        protected internal override string SortName { get; }
+        public AssemblyIdentity XmlAssemblyIdentity { get; set; }
+        public string XmlIsNative { get; set; }
+        public string XmlIsPrerequisite { get; set; }
+        public override string ToString();
+    }
+    public sealed class AssemblyReferenceCollection : IEnumerable {
+        public int Count { get; }
+        public AssemblyReference this[int index] { get; }
+        public AssemblyReference Add(AssemblyReference assembly);
+        public AssemblyReference Add(string path);
+        public void Clear();
+        public AssemblyReference Find(AssemblyIdentity identity);
+        public AssemblyReference Find(string name);
+        public AssemblyReference FindTargetPath(string targetPath);
+        public IEnumerator GetEnumerator();
+        public void Remove(AssemblyReference assemblyReference);
+    }
+    public enum AssemblyReferenceType {
+        ClickOnceManifest = 1,
+        ManagedAssembly = 2,
+        NativeAssembly = 3,
+        Unspecified = 0,
+    }
+    public abstract class BaseReference {
+        protected internal BaseReference();
+        protected internal BaseReference(string path);
+        public string Group { get; set; }
+        public string Hash { get; set; }
+        public bool IsOptional { get; set; }
+        public string ResolvedPath { get; set; }
+        public long Size { get; set; }
+        protected internal abstract string SortName { get; }
+        public string SourcePath { get; set; }
+        public string TargetPath { get; set; }
+        public string XmlGroup { get; set; }
+        public string XmlHash { get; set; }
+        public string XmlHashAlgorithm { get; set; }
+        public string XmlIsOptional { get; set; }
+        public string XmlPath { get; set; }
+        public string XmlSize { get; set; }
+        public override string ToString();
+    }
+    public class ComClass {
+        public ComClass();
+        public string ClsId { get; }
+        public string Description { get; }
+        public string ProgId { get; }
+        public string ThreadingModel { get; }
+        public string TlbId { get; }
+        public string XmlClsId { get; set; }
+        public string XmlDescription { get; set; }
+        public string XmlProgId { get; set; }
+        public string XmlThreadingModel { get; set; }
+        public string XmlTlbId { get; set; }
+    }
+    public sealed class CompatibleFramework {
+        public CompatibleFramework();
+        public string Profile { get; set; }
+        public string SupportedRuntime { get; set; }
+        public string Version { get; set; }
+        public string XmlProfile { get; set; }
+        public string XmlSupportedRuntime { get; set; }
+        public string XmlVersion { get; set; }
+    }
+    public sealed class CompatibleFrameworkCollection : IEnumerable {
+        public int Count { get; }
+        public CompatibleFramework this[int index] { get; }
+        public void Add(CompatibleFramework compatibleFramework);
+        public void Clear();
+        public IEnumerator GetEnumerator();
+    }
+    public sealed class DeployManifest : Manifest {
+        public DeployManifest();
+        public DeployManifest(string targetFrameworkMoniker);
+        public CompatibleFrameworkCollection CompatibleFrameworks { get; }
+        public bool CreateDesktopShortcut { get; set; }
+        public string DeploymentUrl { get; set; }
+        public bool DisallowUrlActivation { get; set; }
+        public override AssemblyReference EntryPoint { get; set; }
+        public string ErrorReportUrl { get; set; }
+        public bool Install { get; set; }
+        public bool MapFileExtensions { get; set; }
+        public string MinimumRequiredVersion { get; set; }
+        public string Product { get; set; }
+        public string Publisher { get; set; }
+        public string SuiteName { get; set; }
+        public string SupportUrl { get; set; }
+        public string TargetFrameworkMoniker { get; set; }
+        public bool TrustUrlParameters { get; set; }
+        public bool UpdateEnabled { get; set; }
+        public int UpdateInterval { get; set; }
+        public UpdateMode UpdateMode { get; set; }
+        public UpdateUnit UpdateUnit { get; set; }
+        public CompatibleFramework[] XmlCompatibleFrameworks { get; set; }
+        public string XmlCreateDesktopShortcut { get; set; }
+        public string XmlDeploymentUrl { get; set; }
+        public string XmlDisallowUrlActivation { get; set; }
+        public string XmlErrorReportUrl { get; set; }
+        public string XmlInstall { get; set; }
+        public string XmlMapFileExtensions { get; set; }
+        public string XmlMinimumRequiredVersion { get; set; }
+        public string XmlProduct { get; set; }
+        public string XmlPublisher { get; set; }
+        public string XmlSuiteName { get; set; }
+        public string XmlSupportUrl { get; set; }
+        public string XmlTrustUrlParameters { get; set; }
+        public string XmlUpdateEnabled { get; set; }
+        public string XmlUpdateInterval { get; set; }
+        public string XmlUpdateMode { get; set; }
+        public string XmlUpdateUnit { get; set; }
+        public override void Validate();
+    }
+    public sealed class FileAssociation {
+        public FileAssociation();
+        public string DefaultIcon { get; set; }
+        public string Description { get; set; }
+        public string Extension { get; set; }
+        public string ProgId { get; set; }
+        public string XmlDefaultIcon { get; set; }
+        public string XmlDescription { get; set; }
+        public string XmlExtension { get; set; }
+        public string XmlProgId { get; set; }
+    }
+    public sealed class FileAssociationCollection : IEnumerable {
+        public int Count { get; }
+        public FileAssociation this[int index] { get; }
+        public void Add(FileAssociation fileAssociation);
+        public void Clear();
+        public IEnumerator GetEnumerator();
+    }
+    public sealed class FileReference : BaseReference {
+        public FileReference();
+        public FileReference(string path);
+        public ComClass[] ComClasses { get; }
+        public bool IsDataFile { get; set; }
+        public ProxyStub[] ProxyStubs { get; }
+        protected internal override string SortName { get; }
+        public TypeLib[] TypeLibs { get; }
+        public ComClass[] XmlComClasses { get; set; }
+        public ProxyStub[] XmlProxyStubs { get; set; }
+        public TypeLib[] XmlTypeLibs { get; set; }
+        public string XmlWriteableType { get; set; }
+    }
+    public sealed class FileReferenceCollection : IEnumerable {
+        public int Count { get; }
+        public FileReference this[int index] { get; }
+        public FileReference Add(FileReference file);
+        public FileReference Add(string path);
+        public void Clear();
+        public FileReference FindTargetPath(string targetPath);
+        public IEnumerator GetEnumerator();
+        public void Remove(FileReference file);
+    }
+    public abstract class Manifest {
+        protected internal Manifest();
+        public AssemblyIdentity AssemblyIdentity { get; set; }
+        public AssemblyReferenceCollection AssemblyReferences { get; }
+        public string Description { get; set; }
+        public virtual AssemblyReference EntryPoint { get; set; }
+        public FileReferenceCollection FileReferences { get; }
+        public Stream InputStream { get; set; }
+        public OutputMessageCollection OutputMessages { get; }
+        public bool ReadOnly { get; set; }
+        public string SourcePath { get; set; }
+        public AssemblyIdentity XmlAssemblyIdentity { get; set; }
+        public AssemblyReference[] XmlAssemblyReferences { get; set; }
+        public string XmlDescription { get; set; }
+        public FileReference[] XmlFileReferences { get; set; }
+        public string XmlSchema { get; set; }
+        public void ResolveFiles();
+        public void ResolveFiles(string[] searchPaths);
+        public override string ToString();
+        public void UpdateFileInfo();
+        public void UpdateFileInfo(string targetFrameworkVersion);
+        public virtual void Validate();
+        protected void ValidatePlatform();
+    }
+    public static class ManifestReader {
+        public static Manifest ReadManifest(Stream input, bool preserveStream);
+        public static Manifest ReadManifest(string path, bool preserveStream);
+        public static Manifest ReadManifest(string manifestType, Stream input, bool preserveStream);
+        public static Manifest ReadManifest(string manifestType, string path, bool preserveStream);
+    }
+    public static class ManifestWriter {
+        public static void WriteManifest(Manifest manifest);
+        public static void WriteManifest(Manifest manifest, Stream output);
+        public static void WriteManifest(Manifest manifest, string path);
+        public static void WriteManifest(Manifest manifest, string path, string targetframeWorkVersion);
+    }
+    public sealed class OutputMessage {
+        public string Name { get; }
+        public string Text { get; }
+        public OutputMessageType Type { get; }
+        public string[] GetArguments();
+    }
+    public sealed class OutputMessageCollection : IEnumerable {
+        public int ErrorCount { get; }
+        public OutputMessage this[int index] { get; }
+        public int WarningCount { get; }
+        public void Clear();
+        public IEnumerator GetEnumerator();
+    }
+    public enum OutputMessageType {
+        Error = 2,
+        Info = 0,
+        Warning = 1,
+    }
+    public class ProxyStub {
+        public ProxyStub();
+        public string BaseInterface { get; }
+        public string IID { get; }
+        public string Name { get; }
+        public string NumMethods { get; }
+        public string TlbId { get; }
+        public string XmlBaseInterface { get; set; }
+        public string XmlIID { get; set; }
+        public string XmlName { get; set; }
+        public string XmlNumMethods { get; set; }
+        public string XmlTlbId { get; set; }
+    }
+    public static class SecurityUtilities {
+        public static PermissionSet ComputeZonePermissionSet(string targetZone, PermissionSet includedPermissionSet, string[] excludedPermissions);
+        public static PermissionSet IdentityListToPermissionSet(string[] ids);
+        public static string[] PermissionSetToIdentityList(PermissionSet permissionSet);
+        public static void SignFile(X509Certificate2 cert, Uri timestampUrl, string path);
+        public static void SignFile(string certPath, SecureString certPassword, Uri timestampUrl, string path);
+        public static void SignFile(string certThumbprint, Uri timestampUrl, string path);
+        public static PermissionSet XmlToPermissionSet(XmlElement element);
+    }
+    public sealed class TrustInfo {
+        public TrustInfo();
+        public bool HasUnmanagedCodePermission { get; }
+        public bool IsFullTrust { get; set; }
+        public PermissionSet PermissionSet { get; set; }
+        public bool PreserveFullTrustPermissionSet { get; set; }
+        public string SameSiteAccess { get; set; }
+        public void Clear();
+        public void Read(Stream input);
+        public void Read(string path);
+        public void ReadManifest(Stream input);
+        public void ReadManifest(string path);
+        public override string ToString();
+        public void Write(Stream output);
+        public void Write(string path);
+        public void WriteManifest(Stream output);
+        public void WriteManifest(Stream input, Stream output);
+        public void WriteManifest(string path);
+    }
+    public class TypeLib {
+        public TypeLib();
+        public string Flags { get; }
+        public string HelpDirectory { get; }
+        public string ResourceId { get; }
+        public string TlbId { get; }
+        public string Version { get; }
+        public string XmlFlags { get; set; }
+        public string XmlHelpDirectory { get; set; }
+        public string XmlResourceId { get; set; }
+        public string XmlTlbId { get; set; }
+        public string XmlVersion { get; set; }
+    }
+    public enum UpdateMode {
+        Background = 0,
+        Foreground = 1,
+    }
+    public enum UpdateUnit {
+        Days = 1,
+        Hours = 0,
+        Weeks = 2,
+    }
+    public class WindowClass {
+        public WindowClass();
+        public WindowClass(string name, bool versioned);
+        public string Name { get; }
+        public bool Versioned { get; }
+        public string XmlName { get; set; }
+        public string XmlVersioned { get; set; }
+    }
+}
```

