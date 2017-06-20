# Microsoft.Build.Utilities

``` diff
+namespace Microsoft.Build.Utilities {
+    public abstract class AppDomainIsolatedTask : MarshalByRefObject, ITask {
+        protected AppDomainIsolatedTask();
+        protected AppDomainIsolatedTask(ResourceManager taskResources);
+        protected AppDomainIsolatedTask(ResourceManager taskResources, string helpKeywordPrefix);
+        public IBuildEngine BuildEngine { get; set; }
+        protected string HelpKeywordPrefix { get; set; }
+        public ITaskHost HostObject { get; set; }
+        public TaskLoggingHelper Log { get; }
+        protected ResourceManager TaskResources { get; set; }
+        public abstract bool Execute();
+        public override object InitializeLifetimeService();
+    }
+    public class AssemblyFoldersExInfo {
+        public AssemblyFoldersExInfo(RegistryHive hive, RegistryView view, string registryKey, string directoryPath, Version targetFrameworkVersion);
+        public string DirectoryPath { get; private set; }
+        public RegistryHive Hive { get; private set; }
+        public string Key { get; private set; }
+        public Version TargetFrameworkVersion { get; private set; }
+        public RegistryView View { get; private set; }
+    }
+    public class CanonicalTrackedInputFiles {
+        public CanonicalTrackedInputFiles(ITask ownerTask, ITaskItem[] tlogFiles, ITaskItem sourceFile, ITaskItem[] excludedInputPaths, CanonicalTrackedOutputFiles outputs, bool useMinimalRebuildOptimization, bool maintainCompositeRootingMarkers);
+        public CanonicalTrackedInputFiles(ITask ownerTask, ITaskItem[] tlogFiles, ITaskItem[] sourceFiles, ITaskItem[] excludedInputPaths, ITaskItem[] outputs, bool useMinimalRebuildOptimization, bool maintainCompositeRootingMarkers);
+        public CanonicalTrackedInputFiles(ITask ownerTask, ITaskItem[] tlogFiles, ITaskItem[] sourceFiles, ITaskItem[] excludedInputPaths, CanonicalTrackedOutputFiles outputs, bool useMinimalRebuildOptimization, bool maintainCompositeRootingMarkers);
+        public CanonicalTrackedInputFiles(ITaskItem[] tlogFiles, ITaskItem[] sourceFiles, ITaskItem[] excludedInputPaths, CanonicalTrackedOutputFiles outputs, bool useMinimalRebuildOptimization, bool maintainCompositeRootingMarkers);
+        public CanonicalTrackedInputFiles(ITaskItem[] tlogFiles, ITaskItem[] sourceFiles, CanonicalTrackedOutputFiles outputs, bool useMinimalRebuildOptimization, bool maintainCompositeRootingMarkers);
+        public Dictionary<string, Dictionary<string, string>> DependencyTable { get; }
+        public ITaskItem[] ComputeSourcesNeedingCompilation();
+        public ITaskItem[] ComputeSourcesNeedingCompilation(bool searchForSubRootsInCompositeRootingMarkers);
+        public bool FileIsExcludedFromDependencyCheck(string fileName);
+        public void RemoveDependenciesFromEntryIfMissing(ITaskItem source);
+        public void RemoveDependenciesFromEntryIfMissing(ITaskItem source, ITaskItem correspondingOutput);
+        public void RemoveDependenciesFromEntryIfMissing(ITaskItem[] source);
+        public void RemoveDependenciesFromEntryIfMissing(ITaskItem[] source, ITaskItem[] correspondingOutputs);
+        public void RemoveDependencyFromEntry(ITaskItem source, ITaskItem dependencyToRemove);
+        public void RemoveDependencyFromEntry(ITaskItem[] sources, ITaskItem dependencyToRemove);
+        public void RemoveEntriesForSource(ITaskItem source);
+        public void RemoveEntriesForSource(ITaskItem[] source);
+        public void RemoveEntryForSourceRoot(string rootingMarker);
+        public void SaveTlog();
+        public void SaveTlog(DependencyFilter includeInTLog);
+    }
+    public class CanonicalTrackedOutputFiles {
+        public CanonicalTrackedOutputFiles(ITask ownerTask, ITaskItem[] tlogFiles);
+        public CanonicalTrackedOutputFiles(ITask ownerTask, ITaskItem[] tlogFiles, bool constructOutputsFromTLogs);
+        public CanonicalTrackedOutputFiles(ITaskItem[] tlogFiles);
+        public Dictionary<string, Dictionary<string, DateTime>> DependencyTable { get; }
+        public void AddComputedOutputForSourceRoot(string sourceKey, string computedOutput);
+        public void AddComputedOutputsForSourceRoot(string sourceKey, ITaskItem[] computedOutputs);
+        public void AddComputedOutputsForSourceRoot(string sourceKey, string[] computedOutputs);
+        public ITaskItem[] OutputsForNonCompositeSource(params ITaskItem[] sources);
+        public ITaskItem[] OutputsForSource(params ITaskItem[] sources);
+        public ITaskItem[] OutputsForSource(ITaskItem[] sources, bool searchForSubRootsInCompositeRootingMarkers);
+        public void RemoveDependenciesFromEntryIfMissing(ITaskItem source);
+        public void RemoveDependenciesFromEntryIfMissing(ITaskItem source, ITaskItem correspondingOutput);
+        public void RemoveDependenciesFromEntryIfMissing(ITaskItem[] source);
+        public void RemoveDependenciesFromEntryIfMissing(ITaskItem[] source, ITaskItem[] correspondingOutputs);
+        public void RemoveDependencyFromEntry(ITaskItem source, ITaskItem dependencyToRemove);
+        public void RemoveDependencyFromEntry(ITaskItem[] sources, ITaskItem dependencyToRemove);
+        public void RemoveEntriesForSource(ITaskItem source);
+        public void RemoveEntriesForSource(ITaskItem source, ITaskItem correspondingOutput);
+        public void RemoveEntriesForSource(ITaskItem[] source);
+        public void RemoveEntriesForSource(ITaskItem[] source, ITaskItem[] correspondingOutputs);
+        public bool RemoveOutputForSourceRoot(string sourceRoot, string outputPathToRemove);
+        public string[] RemoveRootsWithSharedOutputs(ITaskItem[] sources);
+        public void SaveTlog();
+        public void SaveTlog(DependencyFilter includeInTLog);
+    }
+    public class CommandLineBuilder {
+        public CommandLineBuilder();
+        public CommandLineBuilder(bool quoteHyphensOnCommandLine);
+        protected StringBuilder CommandLine { get; }
+        public int Length { get; }
+        public void AppendFileNameIfNotNull(ITaskItem fileItem);
+        public void AppendFileNameIfNotNull(string fileName);
+        public void AppendFileNamesIfNotNull(ITaskItem[] fileItems, string delimiter);
+        public void AppendFileNamesIfNotNull(string[] fileNames, string delimiter);
+        protected void AppendFileNameWithQuoting(string fileName);
+        protected void AppendQuotedTextToBuffer(StringBuilder buffer, string unquotedTextToAppend);
+        protected void AppendSpaceIfNotEmpty();
+        public void AppendSwitch(string switchName);
+        public void AppendSwitchIfNotNull(string switchName, ITaskItem parameter);
+        public void AppendSwitchIfNotNull(string switchName, ITaskItem[] parameters, string delimiter);
+        public void AppendSwitchIfNotNull(string switchName, string parameter);
+        public void AppendSwitchIfNotNull(string switchName, string[] parameters, string delimiter);
+        public void AppendSwitchUnquotedIfNotNull(string switchName, ITaskItem parameter);
+        public void AppendSwitchUnquotedIfNotNull(string switchName, ITaskItem[] parameters, string delimiter);
+        public void AppendSwitchUnquotedIfNotNull(string switchName, string parameter);
+        public void AppendSwitchUnquotedIfNotNull(string switchName, string[] parameters, string delimiter);
+        public void AppendTextUnquoted(string textToAppend);
+        protected void AppendTextWithQuoting(string textToAppend);
+        protected virtual bool IsQuotingRequired(string parameter);
+        public override string ToString();
+        protected virtual void VerifyThrowNoEmbeddedDoubleQuotes(string switchName, string parameter);
+    }
+    public delegate bool DependencyFilter(string fullPath);
+    public enum DotNetFrameworkArchitecture {
+        Bitness32 = 1,
+        Bitness64 = 2,
+        Current = 0,
+    }
+    public enum ExecutableType {
+        Managed32Bit = 3,
+        Managed64Bit = 4,
+        ManagedIL = 2,
+        Native32Bit = 0,
+        Native64Bit = 1,
+        SameAsCurrentProcess = 5,
+    }
+    public static class FileTracker {
+        public static string CreateRootingMarkerResponseFile(ITaskItem[] sources);
+        public static string CreateRootingMarkerResponseFile(string rootMarker);
+        public static void EndTrackingContext();
+        public static string EnsureFileTrackerOnPath();
+        public static string EnsureFileTrackerOnPath(string rootPath);
+        public static bool FileIsExcludedFromDependencies(string fileName);
+        public static bool FileIsUnderPath(string fileName, string path);
+        public static string FindTrackerOnPath();
+        public static bool ForceOutOfProcTracking(ExecutableType toolType);
+        public static bool ForceOutOfProcTracking(ExecutableType toolType, string dllName, string cancelEventName);
+        public static string FormatRootingMarker(ITaskItem source);
+        public static string FormatRootingMarker(ITaskItem source, ITaskItem output);
+        public static string FormatRootingMarker(ITaskItem[] sources);
+        public static string FormatRootingMarker(ITaskItem[] sources, ITaskItem[] outputs);
+        public static string GetFileTrackerPath(ExecutableType toolType);
+        public static string GetFileTrackerPath(ExecutableType toolType, string rootPath);
+        public static string GetTrackerPath(ExecutableType toolType);
+        public static string GetTrackerPath(ExecutableType toolType, string rootPath);
+        public static void ResumeTracking();
+        public static void SetThreadCount(int threadCount);
+        public static Process StartProcess(string command, string arguments, ExecutableType toolType);
+        public static Process StartProcess(string command, string arguments, ExecutableType toolType, string rootFiles);
+        public static Process StartProcess(string command, string arguments, ExecutableType toolType, string intermediateDirectory, string rootFiles);
+        public static Process StartProcess(string command, string arguments, ExecutableType toolType, string dllName, string intermediateDirectory, string rootFiles);
+        public static Process StartProcess(string command, string arguments, ExecutableType toolType, string dllName, string intermediateDirectory, string rootFiles, string cancelEventName);
+        public static void StartTrackingContext(string intermediateDirectory, string taskName);
+        public static void StartTrackingContextWithRoot(string intermediateDirectory, string taskName, string rootMarkerResponseFile);
+        public static void StopTrackingAndCleanup();
+        public static void SuspendTracking();
+        public static string TrackerArguments(string command, string arguments, string dllName, string intermediateDirectory, string rootFiles);
+        public static string TrackerArguments(string command, string arguments, string dllName, string intermediateDirectory, string rootFiles, string cancelEventName);
+        public static string TrackerCommandArguments(string command, string arguments);
+        public static string TrackerResponseFileArguments(string dllName, string intermediateDirectory, string rootFiles);
+        public static string TrackerResponseFileArguments(string dllName, string intermediateDirectory, string rootFiles, string cancelEventName);
+        public static void WriteAllTLogs(string intermediateDirectory, string taskName);
+        public static void WriteContextTLogs(string intermediateDirectory, string taskName);
+    }
+    public class FlatTrackingData {
+        public FlatTrackingData(ITask ownerTask, ITaskItem[] tlogFiles, bool skipMissingFiles);
+        public FlatTrackingData(ITask ownerTask, ITaskItem[] tlogFiles, DateTime missingFileTimeUtc);
+        public FlatTrackingData(ITaskItem[] tlogFiles, ITaskItem[] tlogFilesToIgnore, DateTime missingFileTimeUtc);
+        public FlatTrackingData(ITaskItem[] tlogFiles, ITaskItem[] tlogFilesToIgnore, DateTime missingFileTimeUtc, string[] excludedInputPaths, IDictionary<string, DateTime> sharedLastWriteTimeUtcCache);
+        public FlatTrackingData(ITaskItem[] tlogFiles, bool skipMissingFiles);
+        public FlatTrackingData(ITaskItem[] tlogFiles, DateTime missingFileTimeUtc);
+        public IDictionary<string, DateTime> DependencyTable { get; }
+        public List<string> MissingFiles { get; set; }
+        public string NewestFileName { get; set; }
+        public DateTime NewestFileTime { get; set; }
+        public DateTime NewestFileTimeUtc { get; set; }
+        public string NewestTLogFileName { get; set; }
+        public DateTime NewestTLogTime { get; set; }
+        public DateTime NewestTLogTimeUtc { get; set; }
+        public string OldestFileName { get; set; }
+        public DateTime OldestFileTime { get; set; }
+        public DateTime OldestFileTimeUtc { get; set; }
+        public bool SkipMissingFiles { get; set; }
+        public ITaskItem[] TlogFiles { get; set; }
+        public bool TlogsAvailable { get; set; }
+        public bool TreatRootMarkersAsEntries { get; set; }
+        public bool FileIsExcludedFromDependencyCheck(string fileName);
+        public static void FinalizeTLogs(bool trackedOperationsSucceeded, ITaskItem[] readTLogNames, ITaskItem[] writeTLogNames, ITaskItem[] trackedFilesToRemoveFromTLogs);
+        public DateTime GetLastWriteTimeUtc(string file);
+        public static bool IsUpToDate(Task hostTask, UpToDateCheckType upToDateCheckType, ITaskItem[] readTLogNames, ITaskItem[] writeTLogNames);
+        public static bool IsUpToDate(TaskLoggingHelper Log, UpToDateCheckType upToDateCheckType, FlatTrackingData inputs, FlatTrackingData outputs);
+        public void SaveTlog();
+        public void SaveTlog(DependencyFilter includeInTLog);
+        public void UpdateFileEntryDetails();
+    }
+    public enum HostObjectInitializationStatus {
+        NoActionReturnFailure = 3,
+        NoActionReturnSuccess = 2,
+        UseAlternateToolToExecute = 1,
+        UseHostObjectToExecute = 0,
+    }
+    public abstract class Logger : ILogger {
+        protected Logger();
+        public virtual string Parameters { get; set; }
+        public virtual LoggerVerbosity Verbosity { get; set; }
+        public virtual string FormatErrorEvent(BuildErrorEventArgs args);
+        public virtual string FormatWarningEvent(BuildWarningEventArgs args);
+        public abstract void Initialize(IEventSource eventSource);
+        public bool IsVerbosityAtLeast(LoggerVerbosity checkVerbosity);
+        public virtual void Shutdown();
+    }
+    public class MuxLogger : ILogger, INodeLogger {
+        public MuxLogger();
+        public string Parameters { get; set; }
+        public LoggerVerbosity Verbosity { get; set; }
+        public void Initialize(IEventSource eventSource);
+        public void Initialize(IEventSource eventSource, int maxNodeCount);
+        public void RegisterLogger(int submissionId, ILogger logger);
+        public void Shutdown();
+        public bool UnregisterLoggers(int submissionId);
+    }
+    public static class ProcessorArchitecture {
+        public const string AMD64 = "AMD64";
+        public const string ARM = "ARM";
+        public const string IA64 = "IA64";
+        public const string MSIL = "MSIL";
+        public const string X86 = "x86";
+        public static string CurrentProcessArchitecture { get; }
+    }
+    public enum TargetDotNetFrameworkVersion {
+        Version11 = 0,
+        Version20 = 1,
+        Version30 = 2,
+        Version35 = 3,
+        Version40 = 4,
+        Version45 = 5,
+        VersionLatest = 5,
+    }
+    public class TargetPlatformSDK : IEquatable<TargetPlatformSDK> {
+        public TargetPlatformSDK(string targetPlatformIdentifier, Version targetPlatformVersion, string path);
+        public string Path { get; set; }
+        public string TargetPlatformIdentifier { get; private set; }
+        public Version TargetPlatformVersion { get; private set; }
+        public bool Equals(TargetPlatformSDK other);
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+    }
+    public abstract class Task : ITask {
+        protected Task();
+        protected Task(ResourceManager taskResources);
+        protected Task(ResourceManager taskResources, string helpKeywordPrefix);
+        public IBuildEngine BuildEngine { get; set; }
+        public IBuildEngine2 BuildEngine2 { get; }
+        public IBuildEngine3 BuildEngine3 { get; }
+        public IBuildEngine4 BuildEngine4 { get; }
+        protected string HelpKeywordPrefix { get; set; }
+        public ITaskHost HostObject { get; set; }
+        public TaskLoggingHelper Log { get; }
+        protected ResourceManager TaskResources { get; set; }
+        public abstract bool Execute();
+    }
+    public sealed class TaskItem : MarshalByRefObject, ITaskItem, ITaskItem2 {
+        public TaskItem();
+        public TaskItem(ITaskItem sourceItem);
+        public TaskItem(string itemSpec);
+        public TaskItem(string itemSpec, IDictionary itemMetadata);
+        public string ItemSpec { get; set; }
+        public int MetadataCount { get; }
+        public ICollection MetadataNames { get; }
+        string Microsoft.Build.Framework.ITaskItem2.EvaluatedIncludeEscaped { get; set; }
+        public IDictionary CloneCustomMetadata();
+        public void CopyMetadataTo(ITaskItem destinationItem);
+        public string GetMetadata(string metadataName);
+        public override object InitializeLifetimeService();
+        IDictionary Microsoft.Build.Framework.ITaskItem2.CloneCustomMetadataEscaped();
+        string Microsoft.Build.Framework.ITaskItem2.GetMetadataValueEscaped(string metadataName);
+        void Microsoft.Build.Framework.ITaskItem2.SetMetadataValueLiteral(string metadataName, string metadataValue);
+        public static explicit operator string (TaskItem taskItemToCast);
+        public void RemoveMetadata(string metadataName);
+        public void SetMetadata(string metadataName, string metadataValue);
+        public override string ToString();
+    }
+    public class TaskLoggingHelper : MarshalByRefObject {
+        public TaskLoggingHelper(IBuildEngine buildEngine, string taskName);
+        public TaskLoggingHelper(ITask taskInstance);
+        protected IBuildEngine BuildEngine { get; }
+        public bool HasLoggedErrors { get; }
+        public string HelpKeywordPrefix { get; set; }
+        protected string TaskName { get; }
+        public ResourceManager TaskResources { get; set; }
+        public string ExtractMessageCode(string message, out string messageWithoutCodePrefix);
+        public virtual string FormatResourceString(string resourceName, params object[] args);
+        public virtual string FormatString(string unformatted, params object[] args);
+        public virtual string GetResourceMessage(string resourceName);
+        public override object InitializeLifetimeService();
+        public void LogCommandLine(MessageImportance importance, string commandLine);
+        public void LogCommandLine(string commandLine);
+        public void LogCriticalMessage(string subcategory, string code, string helpKeyword, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, params object[] messageArgs);
+        public void LogError(string message, params object[] messageArgs);
+        public void LogError(string subcategory, string errorCode, string helpKeyword, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, params object[] messageArgs);
+        public void LogErrorFromException(Exception exception);
+        public void LogErrorFromException(Exception exception, bool showStackTrace);
+        public void LogErrorFromException(Exception exception, bool showStackTrace, bool showDetail, string file);
+        public void LogErrorFromResources(string messageResourceName, params object[] messageArgs);
+        public void LogErrorFromResources(string subcategoryResourceName, string errorCode, string helpKeyword, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string messageResourceName, params object[] messageArgs);
+        public void LogErrorWithCodeFromResources(string messageResourceName, params object[] messageArgs);
+        public void LogErrorWithCodeFromResources(string subcategoryResourceName, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string messageResourceName, params object[] messageArgs);
+        public void LogExternalProjectFinished(string message, string helpKeyword, string projectFile, bool succeeded);
+        public void LogExternalProjectStarted(string message, string helpKeyword, string projectFile, string targetNames);
+        public void LogMessage(MessageImportance importance, string message, params object[] messageArgs);
+        public void LogMessage(string message, params object[] messageArgs);
+        public void LogMessage(string subcategory, string code, string helpKeyword, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, MessageImportance importance, string message, params object[] messageArgs);
+        public void LogMessageFromResources(MessageImportance importance, string messageResourceName, params object[] messageArgs);
+        public void LogMessageFromResources(string messageResourceName, params object[] messageArgs);
+        public bool LogMessageFromText(string lineOfText, MessageImportance messageImportance);
+        public bool LogMessagesFromFile(string fileName);
+        public bool LogMessagesFromFile(string fileName, MessageImportance messageImportance);
+        public bool LogMessagesFromStream(TextReader stream, MessageImportance messageImportance);
+        public void LogWarning(string message, params object[] messageArgs);
+        public void LogWarning(string subcategory, string warningCode, string helpKeyword, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, params object[] messageArgs);
+        public void LogWarningFromException(Exception exception);
+        public void LogWarningFromException(Exception exception, bool showStackTrace);
+        public void LogWarningFromResources(string messageResourceName, params object[] messageArgs);
+        public void LogWarningFromResources(string subcategoryResourceName, string warningCode, string helpKeyword, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string messageResourceName, params object[] messageArgs);
+        public void LogWarningWithCodeFromResources(string messageResourceName, params object[] messageArgs);
+        public void LogWarningWithCodeFromResources(string subcategoryResourceName, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string messageResourceName, params object[] messageArgs);
+        public void MarkAsInactive();
+    }
+    public static class ToolLocationHelper {
+        public static string PathToSystem { get; }
+        public static void ClearSDKStaticCache();
+        public static IList<AssemblyFoldersExInfo> GetAssemblyFoldersExInfo(string registryRoot, string targetFrameworkVersion, string registryKeySuffix, string osVersion, string platform, ProcessorArchitecture targetProcessorArchitecture);
+        public static string GetDisplayNameForTargetFrameworkDirectory(string targetFrameworkDirectory, FrameworkName frameworkName);
+        public static string GetDotNetFrameworkRootRegistryKey(TargetDotNetFrameworkVersion version);
+        public static string GetDotNetFrameworkSdkInstallKeyValue(TargetDotNetFrameworkVersion version);
+        public static string GetDotNetFrameworkSdkInstallKeyValue(TargetDotNetFrameworkVersion version, VisualStudioVersion visualStudioVersion);
+        public static string GetDotNetFrameworkSdkRootRegistryKey(TargetDotNetFrameworkVersion version);
+        public static string GetDotNetFrameworkSdkRootRegistryKey(TargetDotNetFrameworkVersion version, VisualStudioVersion visualStudioVersion);
+        public static string GetDotNetFrameworkVersionFolderPrefix(TargetDotNetFrameworkVersion version);
+        public static string GetPathToDotNetFramework(TargetDotNetFrameworkVersion version);
+        public static string GetPathToDotNetFramework(TargetDotNetFrameworkVersion version, DotNetFrameworkArchitecture architecture);
+        public static string GetPathToDotNetFrameworkFile(string fileName, TargetDotNetFrameworkVersion version);
+        public static string GetPathToDotNetFrameworkFile(string fileName, TargetDotNetFrameworkVersion version, DotNetFrameworkArchitecture architecture);
+        public static string GetPathToDotNetFrameworkReferenceAssemblies(TargetDotNetFrameworkVersion version);
+        public static string GetPathToDotNetFrameworkSdk(TargetDotNetFrameworkVersion version);
+        public static string GetPathToDotNetFrameworkSdk(TargetDotNetFrameworkVersion version, VisualStudioVersion visualStudioVersion);
+        public static string GetPathToDotNetFrameworkSdkFile(string fileName, TargetDotNetFrameworkVersion version);
+        public static string GetPathToDotNetFrameworkSdkFile(string fileName, TargetDotNetFrameworkVersion version, DotNetFrameworkArchitecture architecture);
+        public static string GetPathToDotNetFrameworkSdkFile(string fileName, TargetDotNetFrameworkVersion version, VisualStudioVersion visualStudioVersion);
+        public static string GetPathToDotNetFrameworkSdkFile(string fileName, TargetDotNetFrameworkVersion version, VisualStudioVersion visualStudioVersion, DotNetFrameworkArchitecture architecture);
+        public static IList<string> GetPathToReferenceAssemblies(FrameworkName frameworkName);
+        public static IList<string> GetPathToReferenceAssemblies(string targetFrameworkRootPath, FrameworkName frameworkName);
+        public static IList<string> GetPathToReferenceAssemblies(string targetFrameworkIdentifier, string targetFrameworkVersion, string targetFrameworkProfile);
+        public static string GetPathToStandardLibraries(string targetFrameworkIdentifier, string targetFrameworkVersion, string targetFrameworkProfile);
+        public static string GetPathToStandardLibraries(string targetFrameworkIdentifier, string targetFrameworkVersion, string targetFrameworkProfile, string platformTarget);
+        public static string GetPathToSystemFile(string fileName);
+        public static string GetPathToWindowsSdk(TargetDotNetFrameworkVersion version, VisualStudioVersion visualStudioVersion);
+        public static string GetPathToWindowsSdkFile(string fileName, TargetDotNetFrameworkVersion version, VisualStudioVersion visualStudioVersion);
+        public static string GetPathToWindowsSdkFile(string fileName, TargetDotNetFrameworkVersion version, VisualStudioVersion visualStudioVersion, DotNetFrameworkArchitecture architecture);
+        public static string GetPlatformExtensionSDKLocation(string sdkMoniker, string targetPlatformIdentifier, string targetPlatformVersion);
+        public static string GetPlatformExtensionSDKLocation(string sdkMoniker, string targetPlatformIdentifier, string targetPlatformVersion, string diskRoots, string registryRoot);
+        public static string GetPlatformExtensionSDKLocation(string sdkMoniker, string targetPlatformIdentifier, Version targetPlatformVersion);
+        public static string GetPlatformExtensionSDKLocation(string sdkMoniker, string targetPlatformIdentifier, Version targetPlatformVersion, string[] diskRoots, string registryRoot);
+        public static IDictionary<string, string> GetPlatformExtensionSDKLocations(string targetPlatformIdentifier, Version targetPlatformVersion);
+        public static IDictionary<string, string> GetPlatformExtensionSDKLocations(string[] diskRoots, string registryRoot, string targetPlatformIdentifier, Version targetPlatformVersion);
+        public static string GetPlatformSDKLocation(string targetPlatformIdentifier, string targetPlatformVersion);
+        public static string GetPlatformSDKLocation(string targetPlatformIdentifier, string targetPlatformVersion, string diskRoots, string registryRoot);
+        public static string GetPlatformSDKLocation(string targetPlatformIdentifier, Version targetPlatformVersion);
+        public static string GetPlatformSDKLocation(string targetPlatformIdentifier, Version targetPlatformVersion, string[] diskRoots, string registryRoot);
+        public static string GetProgramFilesReferenceAssemblyRoot();
+        public static IList<string> GetSDKDesignTimeFolders(string sdkRoot);
+        public static IList<string> GetSDKDesignTimeFolders(string sdkRoot, string targetConfiguration, string targetArchitecture);
+        public static IList<string> GetSDKRedistFolders(string sdkRoot);
+        public static IList<string> GetSDKRedistFolders(string sdkRoot, string targetConfiguration, string targetArchitecture);
+        public static IList<string> GetSDKReferenceFolders(string sdkRoot);
+        public static IList<string> GetSDKReferenceFolders(string sdkRoot, string targetConfiguration, string targetArchitecture);
+        public static IList<string> GetSupportedTargetFrameworks();
+        public static IList<TargetPlatformSDK> GetTargetPlatformSdks();
+        public static IList<TargetPlatformSDK> GetTargetPlatformSdks(string[] diskRoots, string registryRoot);
+        public static FrameworkName HighestVersionOfTargetFrameworkIdentifier(string targetFrameworkRootDirectory, string frameworkIdentifier);
+    }
+    public abstract class ToolTask : Task, ICancelableTask, ITask {
+        protected ToolTask();
+        protected ToolTask(ResourceManager taskResources);
+        protected ToolTask(ResourceManager taskResources, string helpKeywordPrefix);
+        public bool EchoOff { get; set; }
+        protected virtual StringDictionary EnvironmentOverride { get; }
+        public string[] EnvironmentVariables { get; set; }
+        public int ExitCode { get; }
+        protected virtual bool HasLoggedErrors { get; }
+        public bool LogStandardErrorAsError { get; set; }
+        protected virtual Encoding ResponseFileEncoding { get; }
+        protected virtual Encoding StandardErrorEncoding { get; }
+        public string StandardErrorImportance { get; set; }
+        protected MessageImportance StandardErrorImportanceToUse { get; }
+        protected virtual MessageImportance StandardErrorLoggingImportance { get; }
+        protected virtual Encoding StandardOutputEncoding { get; }
+        public string StandardOutputImportance { get; set; }
+        protected MessageImportance StandardOutputImportanceToUse { get; }
+        protected virtual MessageImportance StandardOutputLoggingImportance { get; }
+        protected int TaskProcessTerminationTimeout { get; set; }
+        public virtual int Timeout { get; set; }
+        protected ManualResetEvent ToolCanceled { get; private set; }
+        public virtual string ToolExe { get; set; }
+        protected abstract string ToolName { get; }
+        public string ToolPath { get; set; }
+        public bool UseCommandProcessor { get; set; }
+        public bool YieldDuringToolExecution { get; set; }
+        protected virtual bool CallHostObjectToExecute();
+        public virtual void Cancel();
+        protected void DeleteTempFile(string fileName);
+        public override bool Execute();
+        protected virtual int ExecuteTool(string pathToTool, string responseFileCommands, string commandLineCommands);
+        protected virtual string GenerateCommandLineCommands();
+        protected abstract string GenerateFullPathToTool();
+        protected virtual string GenerateResponseFileCommands();
+        protected ProcessStartInfo GetProcessStartInfo(string pathToTool, string commandLineCommands, string responseFileSwitch);
+        protected virtual string GetResponseFileSwitch(string responseFilePath);
+        protected virtual string GetWorkingDirectory();
+        protected virtual bool HandleTaskExecutionErrors();
+        protected virtual HostObjectInitializationStatus InitializeHostObject();
+        protected virtual void LogEventsFromTextOutput(string singleLine, MessageImportance messageImportance);
+        protected virtual void LogPathToTool(string toolName, string pathToTool);
+        protected virtual void LogToolCommand(string message);
+        protected virtual string ResponseFileEscape(string responseString);
+        protected virtual bool SkipTaskExecution();
+        protected internal virtual bool ValidateParameters();
+    }
+    public static class TrackedDependencies {
+        public static ITaskItem[] ExpandWildcards(ITaskItem[] expand);
+    }
+    public enum UpToDateCheckType {
+        InputNewerThanOutput = 0,
+        InputNewerThanTracking = 2,
+        InputOrOutputNewerThanTracking = 1,
+    }
+    public enum VisualStudioVersion {
+        Version100 = 0,
+        Version110 = 1,
+        VersionLatest = 1,
+    }
+}
```

