# Microsoft.Build.Tasks

``` diff
+namespace Microsoft.Build.Tasks {
+    public class AL : ToolTaskExtension {
+        public AL();
+        public string AlgorithmId { get; set; }
+        public string BaseAddress { get; set; }
+        public string CompanyName { get; set; }
+        public string Configuration { get; set; }
+        public string Copyright { get; set; }
+        public string Culture { get; set; }
+        public bool DelaySign { get; set; }
+        public string Description { get; set; }
+        public ITaskItem[] EmbedResources { get; set; }
+        public string EvidenceFile { get; set; }
+        public string FileVersion { get; set; }
+        public string Flags { get; set; }
+        public bool GenerateFullPaths { get; set; }
+        public string KeyContainer { get; set; }
+        public string KeyFile { get; set; }
+        public ITaskItem[] LinkResources { get; set; }
+        public string MainEntryPoint { get; set; }
+        public ITaskItem OutputAssembly { get; set; }
+        public string Platform { get; set; }
+        public bool Prefer32Bit { get; set; }
+        public string ProductName { get; set; }
+        public string ProductVersion { get; set; }
+        public string[] ResponseFiles { get; set; }
+        public string SdkToolsPath { get; set; }
+        public ITaskItem[] SourceModules { get; set; }
+        public string TargetType { get; set; }
+        public string TemplateFile { get; set; }
+        public string Title { get; set; }
+        protected override string ToolName { get; }
+        public string Trademark { get; set; }
+        public string Version { get; set; }
+        public string Win32Icon { get; set; }
+        public string Win32Resource { get; set; }
+        protected internal override void AddResponseFileCommands(CommandLineBuilderExtension commandLine);
+        public override bool Execute();
+        protected override string GenerateFullPathToTool();
+    }
+    public abstract class AppDomainIsolatedTaskExtension : AppDomainIsolatedTask {
+        public new TaskLoggingHelper Log { get; }
+    }
+    public class AspNetCompiler : ToolTaskExtension {
+        public AspNetCompiler();
+        public bool AllowPartiallyTrustedCallers { get; set; }
+        public bool Clean { get; set; }
+        public bool Debug { get; set; }
+        public bool DelaySign { get; set; }
+        public bool FixedNames { get; set; }
+        public bool Force { get; set; }
+        public string KeyContainer { get; set; }
+        public string KeyFile { get; set; }
+        public string MetabasePath { get; set; }
+        public string PhysicalPath { get; set; }
+        public string TargetFrameworkMoniker { get; set; }
+        public string TargetPath { get; set; }
+        protected override string ToolName { get; }
+        public bool Updateable { get; set; }
+        public string VirtualPath { get; set; }
+        protected internal override void AddCommandLineCommands(CommandLineBuilderExtension commandLine);
+        public override bool Execute();
+        protected override string GenerateFullPathToTool();
+        protected override bool ValidateParameters();
+    }
+    public class AssignCulture : TaskExtension {
+        public AssignCulture();
+        public ITaskItem[] AssignedFiles { get; }
+        public ITaskItem[] AssignedFilesWithCulture { get; }
+        public ITaskItem[] AssignedFilesWithNoCulture { get; }
+        public ITaskItem[] CultureNeutralAssignedFiles { get; }
+        public ITaskItem[] Files { get; set; }
+        public override bool Execute();
+    }
+    public class AssignProjectConfiguration : ResolveProjectBase {
+        public AssignProjectConfiguration();
+        public bool AddSyntheticProjectReferencesForSolutionDependencies { get; set; }
+        public ITaskItem[] AssignedProjects { get; set; }
+        public string CurrentProject { get; set; }
+        public string CurrentProjectConfiguration { get; set; }
+        public string CurrentProjectPlatform { get; set; }
+        public string DefaultToVcxPlatformMapping { get; set; }
+        public bool OnlyReferenceAndBuildProjectsEnabledInSolutionConfiguration { get; set; }
+        public string OutputType { get; set; }
+        public bool ResolveConfigurationPlatformUsingMappings { get; set; }
+        public bool ShouldUnsetParentConfigurationAndPlatform { get; set; }
+        public string SolutionConfigurationContents { get; set; }
+        public ITaskItem[] UnassignedProjects { get; set; }
+        public string VcxToDefaultPlatformMapping { get; set; }
+        public override bool Execute();
+    }
+    public class AssignTargetPath : TaskExtension {
+        public AssignTargetPath();
+        public ITaskItem[] AssignedFiles { get; }
+        public ITaskItem[] Files { get; set; }
+        public string RootFolder { get; set; }
+        public override bool Execute();
+    }
+    public class CallTarget : TaskExtension {
+        public CallTarget();
+        public bool RunEachTargetSeparately { get; set; }
+        public ITaskItem[] TargetOutputs { get; }
+        public string[] Targets { get; set; }
+        public bool UseResultsCache { get; set; }
+        public override bool Execute();
+    }
+    public class CodeTaskFactory : ITaskFactory {
+        public CodeTaskFactory();
+        public string FactoryName { get; }
+        public Type TaskType { get; private set; }
+        public void CleanupTask(ITask task);
+        public ITask CreateTask(IBuildEngine loggingHost);
+        public TaskPropertyInfo[] GetTaskParameters();
+        public bool Initialize(string taskName, IDictionary<string, TaskPropertyInfo> taskParameters, string taskElementContents, IBuildEngine taskFactoryLoggingHost);
+    }
+    public class CombinePath : TaskExtension {
+        public CombinePath();
+        public string BasePath { get; set; }
+        public ITaskItem[] CombinedPaths { get; set; }
+        public ITaskItem[] Paths { get; set; }
+        public override bool Execute();
+    }
+    public class CommandLineBuilderExtension : CommandLineBuilder {
+        public CommandLineBuilderExtension();
+        protected string GetQuotedText(string unquotedText);
+    }
+    public class ConvertToAbsolutePath : TaskExtension {
+        public ConvertToAbsolutePath();
+        public ITaskItem[] AbsolutePaths { get; set; }
+        public ITaskItem[] Paths { get; set; }
+        public override bool Execute();
+    }
+    public class Copy : TaskExtension, ICancelableTask, ITask {
+        public Copy();
+        public ITaskItem[] CopiedFiles { get; }
+        public ITaskItem[] DestinationFiles { get; set; }
+        public ITaskItem DestinationFolder { get; set; }
+        public bool OverwriteReadOnlyFiles { get; set; }
+        public int Retries { get; set; }
+        public int RetryDelayMilliseconds { get; set; }
+        public bool SkipUnchangedFiles { get; set; }
+        public ITaskItem[] SourceFiles { get; set; }
+        public bool UseHardlinksIfPossible { get; set; }
+        public void Cancel();
+        public override bool Execute();
+    }
+    public class CreateCSharpManifestResourceName : CreateManifestResourceName {
+        public CreateCSharpManifestResourceName();
+        protected override string CreateManifestName(string fileName, string linkFileName, string rootNamespace, string dependentUponFileName, Stream binaryStream);
+        protected override bool IsSourceFile(string fileName);
+    }
+    public class CreateItem : TaskExtension {
+        public CreateItem();
+        public string[] AdditionalMetadata { get; set; }
+        public ITaskItem[] Exclude { get; set; }
+        public ITaskItem[] Include { get; set; }
+        public bool PreserveExistingMetadata { get; set; }
+        public override bool Execute();
+    }
+    public abstract class CreateManifestResourceName : TaskExtension {
+        protected Dictionary<string, ITaskItem> itemSpecToTaskitem;
+        protected CreateManifestResourceName();
+        public ITaskItem[] ManifestResourceNames { get; }
+        public bool PrependCultureAsDirectory { get; set; }
+        public ITaskItem[] ResourceFiles { get; set; }
+        public ITaskItem[] ResourceFilesWithManifestResourceNames { get; set; }
+        public string RootNamespace { get; set; }
+        protected abstract string CreateManifestName(string fileName, string linkFileName, string rootNamespaceName, string dependentUponFileName, Stream binaryStream);
+        public override bool Execute();
+        protected abstract bool IsSourceFile(string fileName);
+        public static string MakeValidEverettIdentifier(string name);
+    }
+    public class CreateProperty : TaskExtension {
+        public CreateProperty();
+        public string[] Value { get; set; }
+        public string[] ValueSetByTask { get; }
+        public override bool Execute();
+    }
+    public class CreateVisualBasicManifestResourceName : CreateManifestResourceName {
+        public CreateVisualBasicManifestResourceName();
+        protected override string CreateManifestName(string fileName, string linkFileName, string rootNamespace, string dependentUponFileName, Stream binaryStream);
+        protected override bool IsSourceFile(string fileName);
+    }
+    public class Csc : ManagedCompiler {
+        public Csc();
+        public bool AllowUnsafeBlocks { get; set; }
+        public string ApplicationConfiguration { get; set; }
+        public string BaseAddress { get; set; }
+        public bool CheckForOverflowUnderflow { get; set; }
+        public string DisabledWarnings { get; set; }
+        public string DocumentationFile { get; set; }
+        public bool ErrorEndLocation { get; set; }
+        public string ErrorReport { get; set; }
+        public bool GenerateFullPaths { get; set; }
+        public string LangVersion { get; set; }
+        public string ModuleAssemblyName { get; set; }
+        public bool NoStandardLib { get; set; }
+        public string PdbFile { get; set; }
+        public string PreferredUILang { get; set; }
+        protected override string ToolName { get; }
+        public bool UseHostCompilerIfAvailable { get; set; }
+        public int WarningLevel { get; set; }
+        public string WarningsAsErrors { get; set; }
+        public string WarningsNotAsErrors { get; set; }
+        protected internal override void AddResponseFileCommands(CommandLineBuilderExtension commandLine);
+        protected override bool CallHostObjectToExecute();
+        protected override string GenerateFullPathToTool();
+        protected override HostObjectInitializationStatus InitializeHostObject();
+    }
+    public sealed class Delete : TaskExtension, ICancelableTask, ITask {
+        public Delete();
+        public ITaskItem[] DeletedFiles { get; set; }
+        public ITaskItem[] Files { get; set; }
+        public bool TreatErrorsAsWarnings { get; set; }
+        public void Cancel();
+        public override bool Execute();
+    }
+    public sealed class Error : TaskExtension {
+        public Error();
+        public string Code { get; set; }
+        public string File { get; set; }
+        public string HelpKeyword { get; set; }
+        public string Text { get; set; }
+        public override bool Execute();
+    }
+    public class Exec : ToolTaskExtension {
+        public Exec();
+        public string Command { get; set; }
+        public ITaskItem[] ConsoleOutput { get; set; }
+        public bool ConsoleToMSBuild { get; set; }
+        public string CustomErrorRegularExpression { get; set; }
+        public string CustomWarningRegularExpression { get; set; }
+        public bool IgnoreExitCode { get; set; }
+        public bool IgnoreStandardErrorWarningFormat { get; set; }
+        public ITaskItem[] Outputs { get; set; }
+        protected override Encoding StandardErrorEncoding { get; }
+        protected override MessageImportance StandardErrorLoggingImportance { get; }
+        protected override Encoding StandardOutputEncoding { get; }
+        protected override MessageImportance StandardOutputLoggingImportance { get; }
+        public string StdErrEncoding { get; set; }
+        public string StdOutEncoding { get; set; }
+        protected override string ToolName { get; }
+        public string WorkingDirectory { get; set; }
+        protected internal override void AddCommandLineCommands(CommandLineBuilderExtension commandLine);
+        protected override int ExecuteTool(string pathToTool, string responseFileCommands, string commandLineCommands);
+        protected override string GenerateFullPathToTool();
+        protected override string GetWorkingDirectory();
+        protected override bool HandleTaskExecutionErrors();
+        protected override void LogEventsFromTextOutput(string singleLine, MessageImportance messageImportance);
+        protected override void LogPathToTool(string toolName, string pathToTool);
+        protected override void LogToolCommand(string message);
+        protected override bool ValidateParameters();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct ExtractedClassName {
+        public bool IsInsideConditionalBlock { get; set; }
+        public string Name { get; set; }
+    }
+    public class FindAppConfigFile : TaskExtension {
+        public FindAppConfigFile();
+        public ITaskItem AppConfigFile { get; set; }
+        public ITaskItem[] PrimaryList { get; set; }
+        public ITaskItem[] SecondaryList { get; set; }
+        public string TargetPath { get; set; }
+        public override bool Execute();
+    }
+    public class FindInList : TaskExtension {
+        public FindInList();
+        public bool CaseSensitive { get; set; }
+        public bool FindLastMatch { get; set; }
+        public ITaskItem ItemFound { get; set; }
+        public string ItemSpecToFind { get; set; }
+        public ITaskItem[] List { get; set; }
+        public bool MatchFileNameOnly { get; set; }
+        public override bool Execute();
+    }
+    public class FindUnderPath : TaskExtension {
+        public FindUnderPath();
+        public ITaskItem[] Files { get; set; }
+        public ITaskItem[] InPath { get; set; }
+        public ITaskItem[] OutOfPath { get; set; }
+        public ITaskItem Path { get; set; }
+        public bool UpdateToAbsolutePaths { get; set; }
+        public override bool Execute();
+    }
+    public sealed class FormatUrl : TaskExtension {
+        public FormatUrl();
+        public string InputUrl { get; set; }
+        public string OutputUrl { get; set; }
+        public override bool Execute();
+    }
+    public sealed class FormatVersion : TaskExtension {
+        public FormatVersion();
+        public string FormatType { get; set; }
+        public string OutputVersion { get; set; }
+        public int Revision { get; set; }
+        public string Version { get; set; }
+        public override bool Execute();
+    }
+    public sealed class GenerateApplicationManifest : GenerateManifestBase {
+        public GenerateApplicationManifest();
+        public string ClrVersion { get; set; }
+        public ITaskItem ConfigFile { get; set; }
+        public ITaskItem[] Dependencies { get; set; }
+        public string ErrorReportUrl { get; set; }
+        public ITaskItem[] FileAssociations { get; set; }
+        public ITaskItem[] Files { get; set; }
+        public bool HostInBrowser { get; set; }
+        public ITaskItem IconFile { get; set; }
+        public ITaskItem[] IsolatedComReferences { get; set; }
+        public string ManifestType { get; set; }
+        public string OSVersion { get; set; }
+        public string Product { get; set; }
+        public string Publisher { get; set; }
+        public bool RequiresMinimumFramework35SP1 { get; set; }
+        public string SuiteName { get; set; }
+        public string SupportUrl { get; set; }
+        public string TargetFrameworkProfile { get; set; }
+        public string TargetFrameworkSubset { get; set; }
+        public ITaskItem TrustInfoFile { get; set; }
+        public bool UseApplicationTrust { get; set; }
+        protected override Type GetObjectType();
+        protected override bool OnManifestLoaded(Manifest manifest);
+        protected override bool OnManifestResolved(Manifest manifest);
+        protected internal override bool ValidateInputs();
+    }
+    public sealed class GenerateBootstrapper : TaskExtension {
+        public GenerateBootstrapper();
+        public string ApplicationFile { get; set; }
+        public string ApplicationName { get; set; }
+        public bool ApplicationRequiresElevation { get; set; }
+        public string ApplicationUrl { get; set; }
+        public string[] BootstrapperComponentFiles { get; set; }
+        public ITaskItem[] BootstrapperItems { get; set; }
+        public string BootstrapperKeyFile { get; set; }
+        public string ComponentsLocation { get; set; }
+        public string ComponentsUrl { get; set; }
+        public bool CopyComponents { get; set; }
+        public string Culture { get; set; }
+        public string FallbackCulture { get; set; }
+        public string OutputPath { get; set; }
+        public string Path { get; set; }
+        public string SupportUrl { get; set; }
+        public bool Validate { get; set; }
+        public string VisualStudioVersion { get; set; }
+        public override bool Execute();
+    }
+    public sealed class GenerateDeploymentManifest : GenerateManifestBase {
+        public GenerateDeploymentManifest();
+        public bool CreateDesktopShortcut { get; set; }
+        public string DeploymentUrl { get; set; }
+        public bool DisallowUrlActivation { get; set; }
+        public string ErrorReportUrl { get; set; }
+        public bool Install { get; set; }
+        public bool MapFileExtensions { get; set; }
+        public string MinimumRequiredVersion { get; set; }
+        public string Product { get; set; }
+        public string Publisher { get; set; }
+        public string SuiteName { get; set; }
+        public string SupportUrl { get; set; }
+        public bool TrustUrlParameters { get; set; }
+        public bool UpdateEnabled { get; set; }
+        public int UpdateInterval { get; set; }
+        public string UpdateMode { get; set; }
+        public string UpdateUnit { get; set; }
+        protected override Type GetObjectType();
+        protected override bool OnManifestLoaded(Manifest manifest);
+        protected override bool OnManifestResolved(Manifest manifest);
+        protected internal override bool ValidateInputs();
+    }
+    public abstract class GenerateManifestBase : Task {
+        protected GenerateManifestBase();
+        public string AssemblyName { get; set; }
+        public string AssemblyVersion { get; set; }
+        public string Description { get; set; }
+        public ITaskItem EntryPoint { get; set; }
+        public ITaskItem InputManifest { get; set; }
+        public int MaxTargetPath { get; set; }
+        public ITaskItem OutputManifest { get; set; }
+        public string Platform { get; set; }
+        public string TargetCulture { get; set; }
+        public string TargetFrameworkMoniker { get; set; }
+        public string TargetFrameworkVersion { get; set; }
+        protected internal AssemblyReference AddAssemblyFromItem(ITaskItem item);
+        protected internal AssemblyReference AddAssemblyNameFromItem(ITaskItem item, AssemblyReferenceType referenceType);
+        protected internal AssemblyReference AddEntryPointFromItem(ITaskItem item, AssemblyReferenceType referenceType);
+        protected internal FileReference AddFileFromItem(ITaskItem item);
+        public override bool Execute();
+        protected internal FileReference FindFileFromItem(ITaskItem item);
+        protected abstract Type GetObjectType();
+        protected abstract bool OnManifestLoaded(Manifest manifest);
+        protected abstract bool OnManifestResolved(Manifest manifest);
+        protected internal virtual bool ValidateInputs();
+        protected internal virtual bool ValidateOutput();
+    }
+    public sealed class GenerateResource : TaskExtension {
+        public GenerateResource();
+        public ITaskItem[] AdditionalInputs { get; set; }
+        public string[] EnvironmentVariables { get; set; }
+        public ITaskItem[] ExcludedInputPaths { get; set; }
+        public bool ExecuteAsTool { get; set; }
+        public bool ExtractResWFiles { get; set; }
+        public ITaskItem[] FilesWritten { get; }
+        public bool MinimalRebuildFromTracking { get; set; }
+        public bool NeverLockTypeAssemblies { get; set; }
+        public string OutputDirectory { get; set; }
+        public ITaskItem[] OutputResources { get; set; }
+        public bool PublicClass { get; set; }
+        public ITaskItem[] References { get; set; }
+        public string SdkToolsPath { get; set; }
+        public ITaskItem[] Sources { get; set; }
+        public ITaskItem StateFile { get; set; }
+        public string StronglyTypedClassName { get; set; }
+        public string StronglyTypedFileName { get; set; }
+        public string StronglyTypedLanguage { get; set; }
+        public string StronglyTypedManifestPrefix { get; set; }
+        public string StronglyTypedNamespace { get; set; }
+        public ITaskItem[] TLogReadFiles { get; }
+        public ITaskItem[] TLogWriteFiles { get; }
+        public string ToolArchitecture { get; set; }
+        public string TrackerFrameworkPath { get; set; }
+        public string TrackerLogDirectory { get; set; }
+        public string TrackerSdkPath { get; set; }
+        public bool TrackFileAccess { get; set; }
+        public bool UseSourcePath { get; set; }
+        public override bool Execute();
+    }
+    public sealed class GenerateTrustInfo : TaskExtension {
+        public GenerateTrustInfo();
+        public ITaskItem[] ApplicationDependencies { get; set; }
+        public ITaskItem BaseManifest { get; set; }
+        public string ExcludedPermissions { get; set; }
+        public string TargetFrameworkMoniker { get; set; }
+        public string TargetZone { get; set; }
+        public ITaskItem TrustInfoFile { get; set; }
+        public override bool Execute();
+    }
+    public class GetAssemblyIdentity : TaskExtension {
+        public GetAssemblyIdentity();
+        public ITaskItem[] Assemblies { get; set; }
+        public ITaskItem[] AssemblyFiles { get; set; }
+        public override bool Execute();
+    }
+    public class GetFrameworkPath : TaskExtension {
+        public GetFrameworkPath();
+        public string FrameworkVersion11Path { get; }
+        public string FrameworkVersion20Path { get; }
+        public string FrameworkVersion30Path { get; }
+        public string FrameworkVersion35Path { get; }
+        public string FrameworkVersion40Path { get; }
+        public string FrameworkVersion45Path { get; }
+        public string Path { get; set; }
+        public override bool Execute();
+    }
+    public class GetFrameworkSdkPath : TaskExtension {
+        public GetFrameworkSdkPath();
+        public string FrameworkSdkVersion20Path { get; }
+        public string FrameworkSdkVersion35Path { get; }
+        public string FrameworkSdkVersion40Path { get; }
+        public string FrameworkSdkVersion45Path { get; }
+        public string Path { get; set; }
+        public override bool Execute();
+    }
+    public class GetInstalledSDKLocations : TaskExtension {
+        public GetInstalledSDKLocations();
+        public ITaskItem[] InstalledSDKs { get; set; }
+        public string[] SDKDirectoryRoots { get; set; }
+        public string SDKRegistryRoot { get; set; }
+        public string TargetPlatformIdentifier { get; set; }
+        public string TargetPlatformVersion { get; set; }
+        public override bool Execute();
+    }
+    public class GetReferenceAssemblyPaths : TaskExtension {
+        public GetReferenceAssemblyPaths();
+        public bool BypassFrameworkInstallChecks { get; set; }
+        public string[] FullFrameworkReferenceAssemblyPaths { get; }
+        public string[] ReferenceAssemblyPaths { get; }
+        public string RootPath { get; set; }
+        public string TargetFrameworkMoniker { get; set; }
+        public string TargetFrameworkMonikerDisplayName { get; set; }
+        public override bool Execute();
+    }
+    public class GetSDKReferenceFiles : TaskExtension {
+        public GetSDKReferenceFiles();
+        public string CacheFileFolderPath { get; set; }
+        public ITaskItem[] CopyLocalFiles { get; }
+        public bool LogCacheFileExceptions { get; set; }
+        public bool LogRedistConflictBetweenSDKsAsWarning { get; set; }
+        public bool LogRedistConflictWithinSDKAsWarning { get; set; }
+        public bool LogRedistFilesList { get; set; }
+        public bool LogReferenceConflictBetweenSDKsAsWarning { get; set; }
+        public bool LogReferenceConflictWithinSDKAsWarning { get; set; }
+        public bool LogReferencesList { get; set; }
+        public ITaskItem[] RedistFiles { get; }
+        public string[] ReferenceExtensions { get; set; }
+        public ITaskItem[] References { get; }
+        public ITaskItem[] ResolvedSDKReferences { get; set; }
+        public override bool Execute();
+    }
+    public interface IFixedTypeInfo {
+        void AddressOfMember(int memid, INVOKEKIND invKind, out IntPtr ppv);
+        void CreateInstance(object pUnkOuter, ref Guid riid, out object ppvObj);
+        void GetContainingTypeLib(out ITypeLib ppTLB, out int pIndex);
+        void GetDllEntry(int memid, INVOKEKIND invKind, IntPtr pBstrDllName, IntPtr pBstrName, IntPtr pwOrdinal);
+        void GetDocumentation(int index, out string strName, out string strDocString, out int dwHelpContext, out string strHelpFile);
+        void GetFuncDesc(int index, out IntPtr ppFuncDesc);
+        void GetIDsOfNames(string[] rgszNames, int cNames, int[] pMemId);
+        void GetImplTypeFlags(int index, out IMPLTYPEFLAGS pImplTypeFlags);
+        void GetMops(int memid, out string pBstrMops);
+        void GetNames(int memid, string[] rgBstrNames, int cMaxNames, out int pcNames);
+        void GetRefTypeInfo(IntPtr hRef, out IFixedTypeInfo ppTI);
+        void GetRefTypeOfImplType(int index, out IntPtr href);
+        void GetTypeAttr(out IntPtr ppTypeAttr);
+        void GetTypeComp(out ITypeComp ppTComp);
+        void GetVarDesc(int index, out IntPtr ppVarDesc);
+        void Invoke(object pvInstance, int memid, short wFlags, ref DISPPARAMS pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, out int puArgErr);
+        void ReleaseFuncDesc(IntPtr pFuncDesc);
+        void ReleaseTypeAttr(IntPtr pTypeAttr);
+        void ReleaseVarDesc(IntPtr pVarDesc);
+    }
+    public class LC : ToolTaskExtension {
+        public LC();
+        public ITaskItem LicenseTarget { get; set; }
+        public bool NoLogo { get; set; }
+        public string OutputDirectory { get; set; }
+        public ITaskItem OutputLicense { get; set; }
+        public ITaskItem[] ReferencedAssemblies { get; set; }
+        public string SdkToolsPath { get; set; }
+        public ITaskItem[] Sources { get; set; }
+        protected override string ToolName { get; }
+        protected internal override void AddCommandLineCommands(CommandLineBuilderExtension commandLine);
+        protected override string GenerateFullPathToTool();
+        protected override bool ValidateParameters();
+    }
+    public class MakeDir : TaskExtension {
+        public MakeDir();
+        public ITaskItem[] Directories { get; set; }
+        public ITaskItem[] DirectoriesCreated { get; }
+        public override bool Execute();
+    }
+    public abstract class ManagedCompiler : ToolTaskExtension {
+        protected ManagedCompiler();
+        public string[] AdditionalLibPaths { get; set; }
+        public string[] AddModules { get; set; }
+        public int CodePage { get; set; }
+        public string DebugType { get; set; }
+        public string DefineConstants { get; set; }
+        public bool DelaySign { get; set; }
+        public bool EmitDebugInformation { get; set; }
+        public int FileAlignment { get; set; }
+        public bool HighEntropyVA { get; set; }
+        protected bool HostCompilerSupportsAllParameters { get; set; }
+        public string KeyContainer { get; set; }
+        public string KeyFile { get; set; }
+        public ITaskItem[] LinkResources { get; set; }
+        public string MainEntryPoint { get; set; }
+        public bool NoConfig { get; set; }
+        public bool NoLogo { get; set; }
+        public bool NoWin32Manifest { get; set; }
+        public bool Optimize { get; set; }
+        public ITaskItem OutputAssembly { get; set; }
+        public string Platform { get; set; }
+        public bool Prefer32Bit { get; set; }
+        public ITaskItem[] References { get; set; }
+        public ITaskItem[] Resources { get; set; }
+        public ITaskItem[] ResponseFiles { get; set; }
+        public ITaskItem[] Sources { get; set; }
+        protected override Encoding StandardOutputEncoding { get; }
+        public string SubsystemVersion { get; set; }
+        public string TargetType { get; set; }
+        public bool TreatWarningsAsErrors { get; set; }
+        protected bool UsedCommandLineTool { get; set; }
+        public bool Utf8Output { get; set; }
+        public string Win32Icon { get; set; }
+        public string Win32Manifest { get; set; }
+        public string Win32Resource { get; set; }
+        protected internal override void AddCommandLineCommands(CommandLineBuilderExtension commandLine);
+        protected internal override void AddResponseFileCommands(CommandLineBuilderExtension commandLine);
+        protected bool CheckAllReferencesExistOnDisk();
+        protected void CheckHostObjectSupport(string parameterName, bool resultFromHostObjectSetOperation);
+        protected override bool HandleTaskExecutionErrors();
+        protected bool ListHasNoDuplicateItems(ITaskItem[] itemList, string parameterName);
+        protected internal virtual bool UseAlternateCommandLineToolToExecute();
+        protected override bool ValidateParameters();
+    }
+    public sealed class Message : TaskExtension {
+        public Message();
+        public string Code { get; set; }
+        public string File { get; set; }
+        public string HelpKeyword { get; set; }
+        public string Importance { get; set; }
+        public bool IsCritical { get; set; }
+        public string Text { get; set; }
+        public override bool Execute();
+    }
+    public class Move : TaskExtension, ICancelableTask, ITask {
+        public Move();
+        public ITaskItem[] DestinationFiles { get; set; }
+        public ITaskItem DestinationFolder { get; set; }
+        public ITaskItem[] MovedFiles { get; }
+        public bool OverwriteReadOnlyFiles { get; set; }
+        public ITaskItem[] SourceFiles { get; set; }
+        public void Cancel();
+        public override bool Execute();
+    }
+    public class MSBuild : TaskExtension {
+        public MSBuild();
+        public bool BuildInParallel { get; set; }
+        public ITaskItem[] Projects { get; set; }
+        public string[] Properties { get; set; }
+        public bool RebaseOutputs { get; set; }
+        public string RemoveProperties { get; set; }
+        public bool RunEachTargetSeparately { get; set; }
+        public string SkipNonexistentProjects { get; set; }
+        public bool StopOnFirstFailure { get; set; }
+        public string[] TargetAndPropertyListSeparators { get; set; }
+        public ITaskItem[] TargetOutputs { get; }
+        public string[] Targets { get; set; }
+        public string ToolsVersion { get; set; }
+        public bool UnloadProjectsOnCompletion { get; set; }
+        public bool UseResultsCache { get; set; }
+        public override bool Execute();
+    }
+    public class ReadLinesFromFile : TaskExtension {
+        public ReadLinesFromFile();
+        public ITaskItem File { get; set; }
+        public ITaskItem[] Lines { get; set; }
+        public override bool Execute();
+    }
+    public class RegisterAssembly : AppDomainIsolatedTaskExtension, ITypeLibExporterNotifySink {
+        public RegisterAssembly();
+        public ITaskItem[] Assemblies { get; set; }
+        public ITaskItem AssemblyListFile { get; set; }
+        public bool CreateCodeBase { get; set; }
+        public ITaskItem[] TypeLibFiles { get; set; }
+        public override bool Execute();
+        public void ReportEvent(ExporterEventKind kind, int code, string msg);
+        public object ResolveRef(Assembly assemblyToResolve);
+    }
+    public class RemoveDir : TaskExtension {
+        public RemoveDir();
+        public ITaskItem[] Directories { get; set; }
+        public ITaskItem[] RemovedDirectories { get; set; }
+        public override bool Execute();
+    }
+    public class RemoveDuplicates : TaskExtension {
+        public RemoveDuplicates();
+        public ITaskItem[] Filtered { get; set; }
+        public ITaskItem[] Inputs { get; set; }
+        public override bool Execute();
+    }
+    public sealed class RequiresFramework35SP1Assembly : TaskExtension {
+        public RequiresFramework35SP1Assembly();
+        public ITaskItem[] Assemblies { get; set; }
+        public bool CreateDesktopShortcut { get; set; }
+        public ITaskItem DeploymentManifestEntryPoint { get; set; }
+        public ITaskItem EntryPoint { get; set; }
+        public string ErrorReportUrl { get; set; }
+        public ITaskItem[] Files { get; set; }
+        public ITaskItem[] ReferencedAssemblies { get; set; }
+        public bool RequiresMinimumFramework35SP1 { get; set; }
+        public bool SigningManifests { get; set; }
+        public string SuiteName { get; set; }
+        public string TargetFrameworkVersion { get; set; }
+        public override bool Execute();
+    }
+    public class ResolveAssemblyReference : TaskExtension {
+        public ResolveAssemblyReference();
+        public string[] AllowedAssemblyExtensions { get; set; }
+        public string[] AllowedRelatedFileExtensions { get; set; }
+        public string AppConfigFile { get; set; }
+        public ITaskItem[] Assemblies { get; set; }
+        public ITaskItem[] AssemblyFiles { get; set; }
+        public bool AutoUnify { get; set; }
+        public string[] CandidateAssemblyFiles { get; set; }
+        public bool CopyLocalDependenciesWhenParentReferenceInGac { get; set; }
+        public ITaskItem[] CopyLocalFiles { get; }
+        public ITaskItem[] FilesWritten { get; set; }
+        public bool FindDependencies { get; set; }
+        public bool FindRelatedFiles { get; set; }
+        public bool FindSatellites { get; set; }
+        public bool FindSerializationAssemblies { get; set; }
+        public ITaskItem[] FullFrameworkAssemblyTables { get; set; }
+        public string[] FullFrameworkFolders { get; set; }
+        public string[] FullTargetFrameworkSubsetNames { get; set; }
+        public bool IgnoreDefaultInstalledAssemblySubsetTables { get; set; }
+        public bool IgnoreDefaultInstalledAssemblyTables { get; set; }
+        public bool IgnoreTargetFrameworkAttributeVersionMismatch { get; set; }
+        public bool IgnoreVersionForFrameworkReferences { get; set; }
+        public ITaskItem[] InstalledAssemblySubsetTables { get; set; }
+        public ITaskItem[] InstalledAssemblyTables { get; set; }
+        public string[] LatestTargetFrameworkDirectories { get; set; }
+        public string ProfileName { get; set; }
+        public ITaskItem[] RelatedFiles { get; }
+        public ITaskItem[] ResolvedDependencyFiles { get; }
+        public ITaskItem[] ResolvedFiles { get; }
+        public ITaskItem[] ResolvedSDKReferences { get; set; }
+        public ITaskItem[] SatelliteFiles { get; }
+        public ITaskItem[] ScatterFiles { get; }
+        public string[] SearchPaths { get; set; }
+        public ITaskItem[] SerializationAssemblyFiles { get; }
+        public bool Silent { get; set; }
+        public string StateFile { get; set; }
+        public ITaskItem[] SuggestedRedirects { get; }
+        public string TargetedRuntimeVersion { get; set; }
+        public string[] TargetFrameworkDirectories { get; set; }
+        public string TargetFrameworkMoniker { get; set; }
+        public string TargetFrameworkMonikerDisplayName { get; set; }
+        public string[] TargetFrameworkSubsets { get; set; }
+        public string TargetFrameworkVersion { get; set; }
+        public string TargetProcessorArchitecture { get; set; }
+        public string WarnOrErrorOnTargetArchitectureMismatch { get; set; }
+        public override bool Execute();
+    }
+    public sealed class ResolveComReference : AppDomainIsolatedTaskExtension, IComReferenceResolver {
+        public ResolveComReference();
+        public bool DelaySign { get; set; }
+        public string[] EnvironmentVariables { get; set; }
+        public bool ExecuteAsTool { get; set; }
+        public bool IncludeVersionInInteropName { get; set; }
+        public string KeyContainer { get; set; }
+        public string KeyFile { get; set; }
+        public bool NoClassMembers { get; set; }
+        public ITaskItem[] ResolvedAssemblyReferences { get; set; }
+        public ITaskItem[] ResolvedFiles { get; set; }
+        public ITaskItem[] ResolvedModules { get; set; }
+        public string SdkToolsPath { get; set; }
+        public bool Silent { get; set; }
+        public string StateFile { get; set; }
+        public string TargetFrameworkVersion { get; set; }
+        public string TargetProcessorArchitecture { get; set; }
+        public ITaskItem[] TypeLibFiles { get; set; }
+        public ITaskItem[] TypeLibNames { get; set; }
+        public string WrapperOutputDirectory { get; set; }
+        public override bool Execute();
+    }
+    public class ResolveKeySource : TaskExtension {
+        public ResolveKeySource();
+        public int AutoClosePasswordPromptShow { get; set; }
+        public int AutoClosePasswordPromptTimeout { get; set; }
+        public string CertificateFile { get; set; }
+        public string CertificateThumbprint { get; set; }
+        public string KeyFile { get; set; }
+        public string ResolvedKeyContainer { get; set; }
+        public string ResolvedKeyFile { get; set; }
+        public string ResolvedThumbprint { get; set; }
+        public bool ShowImportDialogDespitePreviousFailures { get; set; }
+        public bool SuppressAutoClosePasswordPrompt { get; set; }
+        public override bool Execute();
+    }
+    public sealed class ResolveManifestFiles : TaskExtension {
+        public ResolveManifestFiles();
+        public ITaskItem DeploymentManifestEntryPoint { get; set; }
+        public ITaskItem EntryPoint { get; set; }
+        public ITaskItem[] ExtraFiles { get; set; }
+        public ITaskItem[] Files { get; set; }
+        public ITaskItem[] ManagedAssemblies { get; set; }
+        public ITaskItem[] NativeAssemblies { get; set; }
+        public ITaskItem[] OutputAssemblies { get; set; }
+        public ITaskItem OutputDeploymentManifestEntryPoint { get; set; }
+        public ITaskItem OutputEntryPoint { get; set; }
+        public ITaskItem[] OutputFiles { get; set; }
+        public ITaskItem[] PublishFiles { get; set; }
+        public ITaskItem[] SatelliteAssemblies { get; set; }
+        public bool SigningManifests { get; set; }
+        public string TargetCulture { get; set; }
+        public string TargetFrameworkVersion { get; set; }
+        public override bool Execute();
+    }
+    public class ResolveNativeReference : TaskExtension {
+        public ResolveNativeReference();
+        public string[] AdditionalSearchPaths { get; set; }
+        public ITaskItem[] ContainedComComponents { get; set; }
+        public ITaskItem[] ContainedLooseEtcFiles { get; set; }
+        public ITaskItem[] ContainedLooseTlbFiles { get; set; }
+        public ITaskItem[] ContainedPrerequisiteAssemblies { get; set; }
+        public ITaskItem[] ContainedTypeLibraries { get; set; }
+        public ITaskItem[] ContainingReferenceFiles { get; set; }
+        public ITaskItem[] NativeReferences { get; set; }
+        public override bool Execute();
+    }
+    public class ResolveNonMSBuildProjectOutput : ResolveProjectBase {
+        public ResolveNonMSBuildProjectOutput();
+        public string PreresolvedProjectOutputs { get; set; }
+        public ITaskItem[] ResolvedOutputPaths { get; set; }
+        public ITaskItem[] UnresolvedProjectReferences { get; set; }
+        public override bool Execute();
+    }
+    public abstract class ResolveProjectBase : TaskExtension {
+        protected ResolveProjectBase();
+        public ITaskItem[] ProjectReferences { get; set; }
+        protected void AddSyntheticProjectReferences(string currentProjectAbsolutePath);
+        protected XmlElement GetProjectElement(ITaskItem projectRef);
+        protected string GetProjectItem(ITaskItem projectRef);
+    }
+    public class ResolveSDKReference : TaskExtension {
+        public ResolveSDKReference();
+        public ITaskItem[] InstalledSDKs { get; set; }
+        public bool LogResolutionErrorsAsWarnings { get; set; }
+        public bool Prefer32Bit { get; set; }
+        public ITaskItem[] References { get; set; }
+        public ITaskItem[] ResolvedSDKReferences { get; private set; }
+        public ITaskItem[] SDKReferences { get; set; }
+        public string TargetedSDKArchitecture { get; set; }
+        public string TargetedSDKConfiguration { get; set; }
+        public override bool Execute();
+    }
+    public class SGen : ToolTaskExtension {
+        public SGen();
+        public string BuildAssemblyName { get; set; }
+        public string BuildAssemblyPath { get; set; }
+        public bool DelaySign { get; set; }
+        public string KeyContainer { get; set; }
+        public string KeyFile { get; set; }
+        public string Platform { get; set; }
+        public string[] References { get; set; }
+        public string SdkToolsPath { get; set; }
+        public ITaskItem[] SerializationAssembly { get; set; }
+        public string SerializationAssemblyName { get; }
+        public bool ShouldGenerateSerializer { get; set; }
+        protected override string ToolName { get; }
+        public string[] Types { get; set; }
+        public bool UseProxyTypes { get; set; }
+        protected override string GenerateCommandLineCommands();
+        protected override string GenerateFullPathToTool();
+        protected override bool SkipTaskExecution();
+        protected override bool ValidateParameters();
+    }
+    public sealed class SignFile : Task {
+        public SignFile();
+        public string CertificateThumbprint { get; set; }
+        public ITaskItem SigningTarget { get; set; }
+        public string TimestampUrl { get; set; }
+        public override bool Execute();
+    }
+    public abstract class TaskExtension : Task {
+        public new TaskLoggingHelper Log { get; }
+    }
+    public class TaskLoggingHelperExtension : TaskLoggingHelper {
+        public TaskLoggingHelperExtension(ITask taskInstance, ResourceManager primaryResources, ResourceManager sharedResources, string helpKeywordPrefix);
+        public ResourceManager TaskSharedResources { get; set; }
+        public override string FormatResourceString(string resourceName, params object[] args);
+    }
+    public abstract class ToolTaskExtension : ToolTask {
+        protected internal Hashtable Bag { get; }
+        protected override bool HasLoggedErrors { get; }
+        public new TaskLoggingHelper Log { get; }
+        protected internal virtual void AddCommandLineCommands(CommandLineBuilderExtension commandLine);
+        protected internal virtual void AddResponseFileCommands(CommandLineBuilderExtension commandLine);
+        protected override string GenerateCommandLineCommands();
+        protected override string GenerateResponseFileCommands();
+        protected internal bool GetBoolParameterWithDefault(string parameterName, bool defaultValue);
+        protected internal int GetIntParameterWithDefault(string parameterName, int defaultValue);
+    }
+    public class Touch : TaskExtension {
+        public Touch();
+        public bool AlwaysCreate { get; set; }
+        public ITaskItem[] Files { get; set; }
+        public bool ForceTouch { get; set; }
+        public string Time { get; set; }
+        public ITaskItem[] TouchedFiles { get; set; }
+        public override bool Execute();
+    }
+    public class UnregisterAssembly : AppDomainIsolatedTaskExtension {
+        public UnregisterAssembly();
+        public ITaskItem[] Assemblies { get; set; }
+        public ITaskItem AssemblyListFile { get; set; }
+        public ITaskItem[] TypeLibFiles { get; set; }
+        public override bool Execute();
+    }
+    public class UpdateManifest : Task {
+        public UpdateManifest();
+        public ITaskItem ApplicationManifest { get; set; }
+        public string ApplicationPath { get; set; }
+        public ITaskItem InputManifest { get; set; }
+        public ITaskItem OutputManifest { get; set; }
+        public string TargetFrameworkVersion { get; set; }
+        public override bool Execute();
+    }
+    public class Vbc : ManagedCompiler {
+        public Vbc();
+        public string BaseAddress { get; set; }
+        public string DisabledWarnings { get; set; }
+        public string DocumentationFile { get; set; }
+        public string ErrorReport { get; set; }
+        public bool GenerateDocumentation { get; set; }
+        public ITaskItem[] Imports { get; set; }
+        public string LangVersion { get; set; }
+        public string ModuleAssemblyName { get; set; }
+        public bool NoStandardLib { get; set; }
+        public bool NoVBRuntimeReference { get; set; }
+        public bool NoWarnings { get; set; }
+        public string OptionCompare { get; set; }
+        public bool OptionExplicit { get; set; }
+        public bool OptionInfer { get; set; }
+        public bool OptionStrict { get; set; }
+        public string OptionStrictType { get; set; }
+        public string PdbFile { get; set; }
+        public bool RemoveIntegerChecks { get; set; }
+        public string RootNamespace { get; set; }
+        public string SdkPath { get; set; }
+        public bool TargetCompactFramework { get; set; }
+        protected override string ToolName { get; }
+        public bool UseHostCompilerIfAvailable { get; set; }
+        public string VBRuntime { get; set; }
+        public string VBRuntimePath { get; set; }
+        public string Verbosity { get; set; }
+        public string WarningsAsErrors { get; set; }
+        public string WarningsNotAsErrors { get; set; }
+        protected internal override void AddResponseFileCommands(CommandLineBuilderExtension commandLine);
+        protected override bool CallHostObjectToExecute();
+        public override bool Execute();
+        protected override string GenerateFullPathToTool();
+        protected override HostObjectInitializationStatus InitializeHostObject();
+        protected override void LogEventsFromTextOutput(string singleLine, MessageImportance messageImportance);
+        protected override bool ValidateParameters();
+    }
+    public sealed class Warning : TaskExtension {
+        public Warning();
+        public string Code { get; set; }
+        public string File { get; set; }
+        public string HelpKeyword { get; set; }
+        public string Text { get; set; }
+        public override bool Execute();
+    }
+    public class WinMDExp : ToolTaskExtension {
+        public WinMDExp();
+        public string DisabledWarnings { get; set; }
+        public string InputDocumentationFile { get; set; }
+        public string InputPDBFile { get; set; }
+        public string OutputDocumentationFile { get; set; }
+        public string OutputPDBFile { get; set; }
+        public string OutputWindowsMetadataFile { get; set; }
+        public ITaskItem[] References { get; set; }
+        public string SdkToolsPath { get; set; }
+        protected override Encoding StandardErrorEncoding { get; }
+        protected override Encoding StandardOutputEncoding { get; }
+        protected override string ToolName { get; }
+        public bool TreatWarningsAsErrors { get; set; }
+        public bool UTF8Output { get; set; }
+        public string WinMDModule { get; set; }
+        protected internal override void AddCommandLineCommands(CommandLineBuilderExtension commandLine);
+        protected override string GenerateFullPathToTool();
+        protected override bool SkipTaskExecution();
+        protected override bool ValidateParameters();
+    }
+    public class WriteCodeFragment : TaskExtension {
+        public WriteCodeFragment();
+        public ITaskItem[] AssemblyAttributes { get; set; }
+        public string Language { get; set; }
+        public ITaskItem OutputDirectory { get; set; }
+        public ITaskItem OutputFile { get; set; }
+        public override bool Execute();
+    }
+    public class WriteLinesToFile : TaskExtension {
+        public WriteLinesToFile();
+        public string Encoding { get; set; }
+        public ITaskItem File { get; set; }
+        public ITaskItem[] Lines { get; set; }
+        public bool Overwrite { get; set; }
+        public override bool Execute();
+    }
+    public class XamlTaskFactory : ITaskFactory {
+        public XamlTaskFactory();
+        public string FactoryName { get; }
+        public string TaskElementContents { get; private set; }
+        public string TaskName { get; private set; }
+        public string TaskNamespace { get; private set; }
+        public Type TaskType { get; }
+        public void CleanupTask(ITask task);
+        public ITask CreateTask(IBuildEngine taskFactoryLoggingHost);
+        public TaskPropertyInfo[] GetTaskParameters();
+        public bool Initialize(string taskName, IDictionary<string, TaskPropertyInfo> taskParameters, string taskElementContents, IBuildEngine taskFactoryLoggingHost);
+    }
+    public class XmlPeek : TaskExtension {
+        public XmlPeek();
+        public string Namespaces { get; set; }
+        public string Query { get; set; }
+        public ITaskItem[] Result { get; }
+        public string XmlContent { get; set; }
+        public ITaskItem XmlInputPath { get; set; }
+        public override bool Execute();
+    }
+    public class XmlPoke : TaskExtension {
+        public XmlPoke();
+        public string Namespaces { get; set; }
+        public string Query { get; set; }
+        public ITaskItem Value { get; set; }
+        public ITaskItem XmlInputPath { get; set; }
+        public override bool Execute();
+    }
+    public class XslTransformation : TaskExtension {
+        public XslTransformation();
+        public ITaskItem[] OutputPaths { get; set; }
+        public string Parameters { get; set; }
+        public string XmlContent { get; set; }
+        public ITaskItem[] XmlInputPaths { get; set; }
+        public ITaskItem XslCompiledDllPath { get; set; }
+        public string XslContent { get; set; }
+        public ITaskItem XslInputPath { get; set; }
+        public override bool Execute();
+    }
+}
```

