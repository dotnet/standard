# Microsoft.Build.Framework

``` diff
+namespace Microsoft.Build.Framework {
+    public delegate void AnyEventHandler(object sender, BuildEventArgs e);
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct BuildEngineResult {
+        public BuildEngineResult(bool result, List<IDictionary<string, ITaskItem[]>> targetOutputsPerProject);
+        public bool Result { get; }
+        public IList<IDictionary<string, ITaskItem[]>> TargetOutputsPerProject { get; }
+    }
+    public class BuildErrorEventArgs : LazyFormattedBuildEventArgs {
+        protected BuildErrorEventArgs();
+        public BuildErrorEventArgs(string subcategory, string code, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string helpKeyword, string senderName);
+        public BuildErrorEventArgs(string subcategory, string code, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string helpKeyword, string senderName, DateTime eventTimestamp);
+        public BuildErrorEventArgs(string subcategory, string code, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string helpKeyword, string senderName, DateTime eventTimestamp, params object[] messageArgs);
+        public string Code { get; }
+        public int ColumnNumber { get; }
+        public int EndColumnNumber { get; }
+        public int EndLineNumber { get; }
+        public string File { get; }
+        public int LineNumber { get; }
+        public string ProjectFile { get; set; }
+        public string Subcategory { get; }
+    }
+    public delegate void BuildErrorEventHandler(object sender, BuildErrorEventArgs e);
+    public abstract class BuildEventArgs : EventArgs {
+        protected BuildEventArgs();
+        protected BuildEventArgs(string message, string helpKeyword, string senderName);
+        protected BuildEventArgs(string message, string helpKeyword, string senderName, DateTime eventTimestamp);
+        public BuildEventContext BuildEventContext { get; set; }
+        public string HelpKeyword { get; }
+        public virtual string Message { get; protected set; }
+        public string SenderName { get; }
+        public int ThreadId { get; }
+        public DateTime Timestamp { get; }
+    }
+    public class BuildEventContext {
+        public const int InvalidNodeId = -2;
+        public const int InvalidProjectContextId = -2;
+        public const int InvalidProjectInstanceId = -1;
+        public const int InvalidSubmissionId = -1;
+        public const int InvalidTargetId = -1;
+        public const int InvalidTaskId = -1;
+        public BuildEventContext(int nodeId, int targetId, int projectContextId, int taskId);
+        public BuildEventContext(int nodeId, int projectInstanceId, int projectContextId, int targetId, int taskId);
+        public BuildEventContext(int submissionId, int nodeId, int projectInstanceId, int projectContextId, int targetId, int taskId);
+        public long BuildRequestId { get; }
+        public static BuildEventContext Invalid { get; }
+        public int NodeId { get; }
+        public int ProjectContextId { get; }
+        public int ProjectInstanceId { get; }
+        public int SubmissionId { get; }
+        public int TargetId { get; }
+        public int TaskId { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public static bool operator ==(BuildEventContext left, BuildEventContext right);
+        public static bool operator !=(BuildEventContext left, BuildEventContext right);
+    }
+    public class BuildFinishedEventArgs : BuildStatusEventArgs {
+        protected BuildFinishedEventArgs();
+        public BuildFinishedEventArgs(string message, string helpKeyword, bool succeeded);
+        public BuildFinishedEventArgs(string message, string helpKeyword, bool succeeded, DateTime eventTimestamp);
+        public BuildFinishedEventArgs(string message, string helpKeyword, bool succeeded, DateTime eventTimestamp, params object[] messageArgs);
+        public bool Succeeded { get; }
+    }
+    public delegate void BuildFinishedEventHandler(object sender, BuildFinishedEventArgs e);
+    public class BuildMessageEventArgs : LazyFormattedBuildEventArgs {
+        protected BuildMessageEventArgs();
+        public BuildMessageEventArgs(string message, string helpKeyword, string senderName, MessageImportance importance);
+        public BuildMessageEventArgs(string message, string helpKeyword, string senderName, MessageImportance importance, DateTime eventTimestamp);
+        public BuildMessageEventArgs(string message, string helpKeyword, string senderName, MessageImportance importance, DateTime eventTimestamp, params object[] messageArgs);
+        public BuildMessageEventArgs(string subcategory, string code, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string helpKeyword, string senderName, MessageImportance importance);
+        public BuildMessageEventArgs(string subcategory, string code, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string helpKeyword, string senderName, MessageImportance importance, DateTime eventTimestamp);
+        public BuildMessageEventArgs(string subcategory, string code, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string helpKeyword, string senderName, MessageImportance importance, DateTime eventTimestamp, params object[] messageArgs);
+        public string Code { get; }
+        public int ColumnNumber { get; }
+        public int EndColumnNumber { get; }
+        public int EndLineNumber { get; }
+        public string File { get; }
+        public MessageImportance Importance { get; }
+        public int LineNumber { get; }
+        public string ProjectFile { get; set; }
+        public string Subcategory { get; }
+    }
+    public delegate void BuildMessageEventHandler(object sender, BuildMessageEventArgs e);
+    public class BuildStartedEventArgs : BuildStatusEventArgs {
+        protected BuildStartedEventArgs();
+        public BuildStartedEventArgs(string message, string helpKeyword);
+        public BuildStartedEventArgs(string message, string helpKeyword, IDictionary<string, string> environmentOfBuild);
+        public BuildStartedEventArgs(string message, string helpKeyword, DateTime eventTimestamp);
+        public BuildStartedEventArgs(string message, string helpKeyword, DateTime eventTimestamp, params object[] messageArgs);
+        public IDictionary<string, string> BuildEnvironment { get; }
+    }
+    public delegate void BuildStartedEventHandler(object sender, BuildStartedEventArgs e);
+    public abstract class BuildStatusEventArgs : LazyFormattedBuildEventArgs {
+        protected BuildStatusEventArgs();
+        protected BuildStatusEventArgs(string message, string helpKeyword, string senderName);
+        protected BuildStatusEventArgs(string message, string helpKeyword, string senderName, DateTime eventTimestamp);
+        protected BuildStatusEventArgs(string message, string helpKeyword, string senderName, DateTime eventTimestamp, params object[] messageArgs);
+    }
+    public delegate void BuildStatusEventHandler(object sender, BuildStatusEventArgs e);
+    public class BuildWarningEventArgs : LazyFormattedBuildEventArgs {
+        protected BuildWarningEventArgs();
+        public BuildWarningEventArgs(string subcategory, string code, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string helpKeyword, string senderName);
+        public BuildWarningEventArgs(string subcategory, string code, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string helpKeyword, string senderName, DateTime eventTimestamp);
+        public BuildWarningEventArgs(string subcategory, string code, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string helpKeyword, string senderName, DateTime eventTimestamp, params object[] messageArgs);
+        public string Code { get; }
+        public int ColumnNumber { get; }
+        public int EndColumnNumber { get; }
+        public int EndLineNumber { get; }
+        public string File { get; }
+        public int LineNumber { get; }
+        public string ProjectFile { get; set; }
+        public string Subcategory { get; }
+    }
+    public delegate void BuildWarningEventHandler(object sender, BuildWarningEventArgs e);
+    public class CriticalBuildMessageEventArgs : BuildMessageEventArgs {
+        protected CriticalBuildMessageEventArgs();
+        public CriticalBuildMessageEventArgs(string subcategory, string code, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string helpKeyword, string senderName);
+        public CriticalBuildMessageEventArgs(string subcategory, string code, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string helpKeyword, string senderName, DateTime eventTimestamp);
+        public CriticalBuildMessageEventArgs(string subcategory, string code, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string helpKeyword, string senderName, DateTime eventTimestamp, params object[] messageArgs);
+    }
+    public abstract class CustomBuildEventArgs : LazyFormattedBuildEventArgs {
+        protected CustomBuildEventArgs();
+        protected CustomBuildEventArgs(string message, string helpKeyword, string senderName);
+        protected CustomBuildEventArgs(string message, string helpKeyword, string senderName, DateTime eventTimestamp);
+        protected CustomBuildEventArgs(string message, string helpKeyword, string senderName, DateTime eventTimestamp, params object[] messageArgs);
+    }
+    public delegate void CustomBuildEventHandler(object sender, CustomBuildEventArgs e);
+    public class ExternalProjectFinishedEventArgs : CustomBuildEventArgs {
+        protected ExternalProjectFinishedEventArgs();
+        public ExternalProjectFinishedEventArgs(string message, string helpKeyword, string senderName, string projectFile, bool succeeded);
+        public ExternalProjectFinishedEventArgs(string message, string helpKeyword, string senderName, string projectFile, bool succeeded, DateTime eventTimestamp);
+        public string ProjectFile { get; }
+        public bool Succeeded { get; }
+    }
+    public class ExternalProjectStartedEventArgs : CustomBuildEventArgs {
+        protected ExternalProjectStartedEventArgs();
+        public ExternalProjectStartedEventArgs(string message, string helpKeyword, string senderName, string projectFile, string targetNames);
+        public ExternalProjectStartedEventArgs(string message, string helpKeyword, string senderName, string projectFile, string targetNames, DateTime eventTimestamp);
+        public string ProjectFile { get; }
+        public string TargetNames { get; }
+    }
+    public interface IBuildEngine {
+        int ColumnNumberOfTaskNode { get; }
+        bool ContinueOnError { get; }
+        int LineNumberOfTaskNode { get; }
+        string ProjectFileOfTaskNode { get; }
+        bool BuildProjectFile(string projectFileName, string[] targetNames, IDictionary globalProperties, IDictionary targetOutputs);
+        void LogCustomEvent(CustomBuildEventArgs e);
+        void LogErrorEvent(BuildErrorEventArgs e);
+        void LogMessageEvent(BuildMessageEventArgs e);
+        void LogWarningEvent(BuildWarningEventArgs e);
+    }
+    public interface IBuildEngine2 : IBuildEngine {
+        bool IsRunningMultipleNodes { get; }
+        bool BuildProjectFile(string projectFileName, string[] targetNames, IDictionary globalProperties, IDictionary targetOutputs, string toolsVersion);
+        bool BuildProjectFilesInParallel(string[] projectFileNames, string[] targetNames, IDictionary[] globalProperties, IDictionary[] targetOutputsPerProject, string[] toolsVersion, bool useResultsCache, bool unloadProjectsOnCompletion);
+    }
+    public interface IBuildEngine3 : IBuildEngine, IBuildEngine2 {
+        BuildEngineResult BuildProjectFilesInParallel(string[] projectFileNames, string[] targetNames, IDictionary[] globalProperties, IList<string>[] removeGlobalProperties, string[] toolsVersion, bool returnTargetOutputs);
+        void Reacquire();
+        void Yield();
+    }
+    public interface IBuildEngine4 : IBuildEngine, IBuildEngine2, IBuildEngine3 {
+        object GetRegisteredTaskObject(object key, RegisteredTaskObjectLifetime lifetime);
+        void RegisterTaskObject(object key, object obj, RegisteredTaskObjectLifetime lifetime, bool allowEarlyCollection);
+        object UnregisterTaskObject(object key, RegisteredTaskObjectLifetime lifetime);
+    }
+    public interface ICancelableTask : ITask {
+        void Cancel();
+    }
+    public interface IEventRedirector {
+        void ForwardEvent(BuildEventArgs buildEvent);
+    }
+    public interface IEventSource {
+        event AnyEventHandler AnyEventRaised;
+        event BuildFinishedEventHandler BuildFinished;
+        event BuildStartedEventHandler BuildStarted;
+        event CustomBuildEventHandler CustomEventRaised;
+        event BuildErrorEventHandler ErrorRaised;
+        event BuildMessageEventHandler MessageRaised;
+        event ProjectFinishedEventHandler ProjectFinished;
+        event ProjectStartedEventHandler ProjectStarted;
+        event BuildStatusEventHandler StatusEventRaised;
+        event TargetFinishedEventHandler TargetFinished;
+        event TargetStartedEventHandler TargetStarted;
+        event TaskFinishedEventHandler TaskFinished;
+        event TaskStartedEventHandler TaskStarted;
+        event BuildWarningEventHandler WarningRaised;
+    }
+    public interface IForwardingLogger : ILogger, INodeLogger {
+        IEventRedirector BuildEventRedirector { get; set; }
+        int NodeId { get; set; }
+    }
+    public interface IGeneratedTask : ITask {
+        object GetPropertyValue(TaskPropertyInfo property);
+        void SetPropertyValue(TaskPropertyInfo property, object value);
+    }
+    public interface ILogger {
+        string Parameters { get; set; }
+        LoggerVerbosity Verbosity { get; set; }
+        void Initialize(IEventSource eventSource);
+        void Shutdown();
+    }
+    public interface INodeLogger : ILogger {
+        void Initialize(IEventSource eventSource, int nodeCount);
+    }
+    public interface ITask {
+        IBuildEngine BuildEngine { get; set; }
+        ITaskHost HostObject { get; set; }
+        bool Execute();
+    }
+    public interface ITaskFactory {
+        string FactoryName { get; }
+        Type TaskType { get; }
+        void CleanupTask(ITask task);
+        ITask CreateTask(IBuildEngine taskFactoryLoggingHost);
+        TaskPropertyInfo[] GetTaskParameters();
+        bool Initialize(string taskName, IDictionary<string, TaskPropertyInfo> parameterGroup, string taskBody, IBuildEngine taskFactoryLoggingHost);
+    }
+    public interface ITaskFactory2 : ITaskFactory {
+        ITask CreateTask(IBuildEngine taskFactoryLoggingHost, IDictionary<string, string> taskIdentityParameters);
+        bool Initialize(string taskName, IDictionary<string, string> factoryIdentityParameters, IDictionary<string, TaskPropertyInfo> parameterGroup, string taskBody, IBuildEngine taskFactoryLoggingHost);
+    }
+    public interface ITaskHost
+    public interface ITaskItem {
+        string ItemSpec { get; set; }
+        int MetadataCount { get; }
+        ICollection MetadataNames { get; }
+        IDictionary CloneCustomMetadata();
+        void CopyMetadataTo(ITaskItem destinationItem);
+        string GetMetadata(string metadataName);
+        void RemoveMetadata(string metadataName);
+        void SetMetadata(string metadataName, string metadataValue);
+    }
+    public interface ITaskItem2 : ITaskItem {
+        string EvaluatedIncludeEscaped { get; set; }
+        IDictionary CloneCustomMetadataEscaped();
+        string GetMetadataValueEscaped(string metadataName);
+        void SetMetadataValueLiteral(string metadataName, string metadataValue);
+    }
+    public class LazyFormattedBuildEventArgs : BuildEventArgs {
+        protected LazyFormattedBuildEventArgs();
+        public LazyFormattedBuildEventArgs(string message, string helpKeyword, string senderName);
+        public LazyFormattedBuildEventArgs(string message, string helpKeyword, string senderName, DateTime eventTimestamp, params object[] messageArgs);
+        public override string Message { get; }
+    }
+    public sealed class LoadInSeparateAppDomainAttribute : Attribute {
+        public LoadInSeparateAppDomainAttribute();
+    }
+    public class LoggerException : Exception {
+        public LoggerException();
+        protected LoggerException(SerializationInfo info, StreamingContext context);
+        public LoggerException(string message);
+        public LoggerException(string message, Exception innerException);
+        public LoggerException(string message, Exception innerException, string errorCode, string helpKeyword);
+        public string ErrorCode { get; }
+        public string HelpKeyword { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public enum LoggerVerbosity {
+        Detailed = 3,
+        Diagnostic = 4,
+        Minimal = 1,
+        Normal = 2,
+        Quiet = 0,
+    }
+    public enum MessageImportance {
+        High = 0,
+        Low = 2,
+        Normal = 1,
+    }
+    public sealed class OutputAttribute : Attribute {
+        public OutputAttribute();
+    }
+    public class ProjectFinishedEventArgs : BuildStatusEventArgs {
+        protected ProjectFinishedEventArgs();
+        public ProjectFinishedEventArgs(string message, string helpKeyword, string projectFile, bool succeeded);
+        public ProjectFinishedEventArgs(string message, string helpKeyword, string projectFile, bool succeeded, DateTime eventTimestamp);
+        public string ProjectFile { get; }
+        public bool Succeeded { get; }
+    }
+    public delegate void ProjectFinishedEventHandler(object sender, ProjectFinishedEventArgs e);
+    public class ProjectStartedEventArgs : BuildStatusEventArgs {
+        public const int InvalidProjectId = -1;
+        protected ProjectStartedEventArgs();
+        public ProjectStartedEventArgs(int projectId, string message, string helpKeyword, string projectFile, string targetNames, IEnumerable properties, IEnumerable items, BuildEventContext parentBuildEventContext);
+        public ProjectStartedEventArgs(int projectId, string message, string helpKeyword, string projectFile, string targetNames, IEnumerable properties, IEnumerable items, BuildEventContext parentBuildEventContext, IDictionary<string, string> globalProperties, string toolsVersion);
+        public ProjectStartedEventArgs(int projectId, string message, string helpKeyword, string projectFile, string targetNames, IEnumerable properties, IEnumerable items, BuildEventContext parentBuildEventContext, DateTime eventTimestamp);
+        public ProjectStartedEventArgs(string message, string helpKeyword, string projectFile, string targetNames, IEnumerable properties, IEnumerable items);
+        public ProjectStartedEventArgs(string message, string helpKeyword, string projectFile, string targetNames, IEnumerable properties, IEnumerable items, DateTime eventTimestamp);
+        public IDictionary<string, string> GlobalProperties { get; internal set; }
+        public IEnumerable Items { get; }
+        public BuildEventContext ParentProjectBuildEventContext { get; }
+        public string ProjectFile { get; }
+        public int ProjectId { get; }
+        public IEnumerable Properties { get; }
+        public string TargetNames { get; }
+        public string ToolsVersion { get; internal set; }
+    }
+    public delegate void ProjectStartedEventHandler(object sender, ProjectStartedEventArgs e);
+    public enum RegisteredTaskObjectLifetime {
+        AppDomain = 1,
+        Build = 0,
+    }
+    public sealed class RequiredAttribute : Attribute {
+        public RequiredAttribute();
+    }
+    public sealed class RequiredRuntimeAttribute : Attribute {
+        public RequiredRuntimeAttribute(string runtimeVersion);
+        public string RuntimeVersion { get; }
+    }
+    public sealed class RunInMTAAttribute : Attribute {
+        public RunInMTAAttribute();
+    }
+    public sealed class RunInSTAAttribute : Attribute {
+        public RunInSTAAttribute();
+    }
+    public class TargetFinishedEventArgs : BuildStatusEventArgs {
+        protected TargetFinishedEventArgs();
+        public TargetFinishedEventArgs(string message, string helpKeyword, string targetName, string projectFile, string targetFile, bool succeeded);
+        public TargetFinishedEventArgs(string message, string helpKeyword, string targetName, string projectFile, string targetFile, bool succeeded, IEnumerable targetOutputs);
+        public TargetFinishedEventArgs(string message, string helpKeyword, string targetName, string projectFile, string targetFile, bool succeeded, DateTime eventTimestamp, IEnumerable targetOutputs);
+        public string ProjectFile { get; }
+        public bool Succeeded { get; }
+        public string TargetFile { get; }
+        public string TargetName { get; }
+        public IEnumerable TargetOutputs { get; set; }
+    }
+    public delegate void TargetFinishedEventHandler(object sender, TargetFinishedEventArgs e);
+    public class TargetStartedEventArgs : BuildStatusEventArgs {
+        protected TargetStartedEventArgs();
+        public TargetStartedEventArgs(string message, string helpKeyword, string targetName, string projectFile, string targetFile);
+        public TargetStartedEventArgs(string message, string helpKeyword, string targetName, string projectFile, string targetFile, string parentTarget, DateTime eventTimestamp);
+        public string ParentTarget { get; }
+        public string ProjectFile { get; }
+        public string TargetFile { get; }
+        public string TargetName { get; }
+    }
+    public delegate void TargetStartedEventHandler(object sender, TargetStartedEventArgs e);
+    public class TaskCommandLineEventArgs : BuildMessageEventArgs {
+        protected TaskCommandLineEventArgs();
+        public TaskCommandLineEventArgs(string commandLine, string taskName, MessageImportance importance);
+        public TaskCommandLineEventArgs(string commandLine, string taskName, MessageImportance importance, DateTime eventTimestamp);
+        public string CommandLine { get; }
+        public string TaskName { get; }
+    }
+    public class TaskFinishedEventArgs : BuildStatusEventArgs {
+        protected TaskFinishedEventArgs();
+        public TaskFinishedEventArgs(string message, string helpKeyword, string projectFile, string taskFile, string taskName, bool succeeded);
+        public TaskFinishedEventArgs(string message, string helpKeyword, string projectFile, string taskFile, string taskName, bool succeeded, DateTime eventTimestamp);
+        public string ProjectFile { get; }
+        public bool Succeeded { get; }
+        public string TaskFile { get; }
+        public string TaskName { get; }
+    }
+    public delegate void TaskFinishedEventHandler(object sender, TaskFinishedEventArgs e);
+    public class TaskPropertyInfo {
+        public TaskPropertyInfo(string name, Type typeOfParameter, bool output, bool required);
+        public string Name { get; private set; }
+        public bool Output { get; private set; }
+        public Type PropertyType { get; private set; }
+        public bool Required { get; private set; }
+    }
+    public class TaskStartedEventArgs : BuildStatusEventArgs {
+        protected TaskStartedEventArgs();
+        public TaskStartedEventArgs(string message, string helpKeyword, string projectFile, string taskFile, string taskName);
+        public TaskStartedEventArgs(string message, string helpKeyword, string projectFile, string taskFile, string taskName, DateTime eventTimestamp);
+        public string ProjectFile { get; }
+        public string TaskFile { get; }
+        public string TaskName { get; }
+    }
+    public delegate void TaskStartedEventHandler(object sender, TaskStartedEventArgs e);
+}
```

