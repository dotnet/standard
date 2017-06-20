# Microsoft.Build.Execution

``` diff
+namespace Microsoft.Build.Execution {
+    public class BuildManager : IBuildComponentHost, IDisposable, INodePacketHandler {
+        public BuildManager();
+        public BuildManager(string hostName);
+        public static BuildManager DefaultBuildManager { get; }
+        public void BeginBuild(BuildParameters parameters);
+        public BuildResult Build(BuildParameters parameters, BuildRequestData requestData);
+        public BuildResult BuildRequest(BuildRequestData requestData);
+        public void CancelAllSubmissions();
+        public void Dispose();
+        public void EndBuild();
+        ~BuildManager();
+        public ProjectInstance GetProjectInstanceForBuild(Project project);
+        public BuildSubmission PendBuildRequest(BuildRequestData requestData);
+        public void ResetCaches();
+    }
+    public class BuildParameters : INodePacketTranslatable {
+        public BuildParameters();
+        public BuildParameters(ProjectCollection projectCollection);
+        public IDictionary<string, string> BuildProcessEnvironment { get; }
+        public ThreadPriority BuildThreadPriority { get; set; }
+        public CultureInfo Culture { get; set; }
+        public string DefaultToolsVersion { get; set; }
+        public bool DetailedSummary { get; set; }
+        public bool DisableInProcNode { get; set; }
+        public bool EnableNodeReuse { get; set; }
+        public IDictionary<string, string> EnvironmentProperties { get; }
+        public IEnumerable<ForwardingLoggerRecord> ForwardingLoggers { get; set; }
+        public IDictionary<string, string> GlobalProperties { get; set; }
+        public HostServices HostServices { get; set; }
+        public bool LegacyThreadingSemantics { get; set; }
+        public IEnumerable<ILogger> Loggers { get; set; }
+        public bool LogInitialPropertiesAndItems { get; set; }
+        public bool LogTaskInputs { get; set; }
+        public int MaxNodeCount { get; set; }
+        public int MemoryUseLimit { get; set; }
+        public string NodeExeLocation { get; set; }
+        public bool OnlyLogCriticalEvents { get; set; }
+        public bool ResetCaches { get; set; }
+        public bool SaveOperatingEnvironment { get; set; }
+        public bool ShutdownInProcNodeOnBuildFinish { get; set; }
+        public ToolsetDefinitionLocations ToolsetDefinitionLocations { get; set; }
+        public ICollection<Toolset> Toolsets { get; }
+        public CultureInfo UICulture { get; set; }
+        public bool UseSynchronousLogging { get; set; }
+        public BuildParameters Clone();
+        public Toolset GetToolset(string toolsVersion);
+    }
+    public class BuildRequestData {
+        public BuildRequestData(ProjectInstance projectInstance, string[] targetsToBuild);
+        public BuildRequestData(ProjectInstance projectInstance, string[] targetsToBuild, HostServices hostServices);
+        public BuildRequestData(ProjectInstance projectInstance, string[] targetsToBuild, HostServices hostServices, BuildRequestDataFlags flags);
+        public BuildRequestData(ProjectInstance projectInstance, string[] targetsToBuild, HostServices hostServices, BuildRequestDataFlags flags, IEnumerable<string> propertiesToTransfer);
+        public BuildRequestData(string projectFullPath, IDictionary<string, string> globalProperties, string toolsVersion, string[] targetsToBuild, HostServices hostServices);
+        public BuildRequestData(string projectFullPath, IDictionary<string, string> globalProperties, string toolsVersion, string[] targetsToBuild, HostServices hostServices, BuildRequestDataFlags flags);
+        public string ExplicitlySpecifiedToolsVersion { get; private set; }
+        public BuildRequestDataFlags Flags { get; private set; }
+        public ICollection<ProjectPropertyInstance> GlobalProperties { get; }
+        public HostServices HostServices { get; private set; }
+        public string ProjectFullPath { get; internal set; }
+        public ProjectInstance ProjectInstance { get; private set; }
+        public IEnumerable<string> PropertiesToTransfer { get; private set; }
+        public ICollection<string> TargetNames { get; private set; }
+    }
+    public enum BuildRequestDataFlags {
+        IgnoreExistingProjectState = 4,
+        None = 0,
+        ProvideProjectStateAfterBuild = 2,
+        ReplaceExistingProjectInstance = 1,
+    }
+    public class BuildResult : IBuildResults, INodePacket, INodePacketTranslatable {
+        public BuildResult();
+        public bool CircularDependency { get; }
+        public int ConfigurationId { get; }
+        public Exception Exception { get; internal set; }
+        public int GlobalRequestId { get; }
+        public int NodeRequestId { get; }
+        public BuildResultCode OverallResult { get; }
+        public int ParentGlobalRequestId { get; }
+        public ProjectInstance ProjectStateAfterBuild { get; set; }
+        public IDictionary<string, TargetResult> ResultsByTarget { get; }
+        public int SubmissionId { get; }
+        public ITargetResult this[string target] { get; }
+        public void AddResultsForTarget(string target, TargetResult result);
+        public bool HasResultsForTarget(string target);
+        public void MergeResults(BuildResult results);
+    }
+    public enum BuildResultCode {
+        Failure = 1,
+        Success = 0,
+    }
+    public class BuildSubmission {
+        public object AsyncContext { get; private set; }
+        public BuildManager BuildManager { get; private set; }
+        public BuildResult BuildResult { get; set; }
+        public bool IsCompleted { get; }
+        public int SubmissionId { get; private set; }
+        public WaitHandle WaitHandle { get; }
+        public BuildResult Execute();
+        public void ExecuteAsync(BuildSubmissionCompleteCallback callback, object context);
+    }
+    public delegate void BuildSubmissionCompleteCallback(BuildSubmission submission);
+    public class HostServices {
+        public HostServices();
+        public ITaskHost GetHostObject(string projectFile, string targetName, string taskName);
+        public NodeAffinity GetNodeAffinity(string projectFile);
+        public void OnRenameProject(string oldFullPath, string newFullPath);
+        public void RegisterHostObject(string projectFile, string targetName, string taskName, ITaskHost hostObject);
+        public void SetNodeAffinity(string projectFile, NodeAffinity nodeAffinity);
+        public void UnregisterProject(string projectFullPath);
+    }
+    public interface ITargetResult {
+        Exception Exception { get; }
+        ITaskItem[] Items { get; }
+        TargetResultCode ResultCode { get; }
+    }
+    public enum NodeAffinity {
+        Any = 2,
+        InProc = 0,
+        OutOfProc = 1,
+    }
+    public enum NodeEngineShutdownReason {
+        BuildComplete = 0,
+        BuildCompleteReuse = 1,
+        ConnectionFailed = 2,
+        Error = 3,
+    }
+    public class OutOfProcNode : IBuildComponentHost, INode, INodePacketFactory, INodePacketHandler {
+        public OutOfProcNode();
+        public NodeEngineShutdownReason Run(out Exception shutdownException);
+    }
+    public class ProjectInstance : IEvaluatorData<ProjectPropertyInstance, ProjectItemInstance, ProjectMetadataInstance, ProjectItemDefinitionInstance>, IItemProvider<ProjectItemInstance>, INodePacketTranslatable, IPropertyProvider<ProjectPropertyInstance> {
+        public ProjectInstance(ProjectRootElement xml);
+        public ProjectInstance(ProjectRootElement xml, IDictionary<string, string> globalProperties, string toolsVersion, ProjectCollection projectCollection);
+        public ProjectInstance(ProjectRootElement xml, IDictionary<string, string> globalProperties, string toolsVersion, string subToolsetVersion, ProjectCollection projectCollection);
+        public ProjectInstance(string projectFile);
+        public ProjectInstance(string projectFile, IDictionary<string, string> globalProperties, string toolsVersion);
+        public ProjectInstance(string projectFile, IDictionary<string, string> globalProperties, string toolsVersion, ProjectCollection projectCollection);
+        public ProjectInstance(string projectFile, IDictionary<string, string> globalProperties, string toolsVersion, string subToolsetVersion, ProjectCollection projectCollection);
+        public List<string> DefaultTargets { get; private set; }
+        public string Directory { get; }
+        public string FullPath { get; }
+        public IDictionary<string, string> GlobalProperties { get; }
+        public List<string> InitialTargets { get; private set; }
+        public bool IsImmutable { get; }
+        public IDictionary<string, ProjectItemDefinitionInstance> ItemDefinitions { get; }
+        public ICollection<ProjectItemInstance> Items { get; }
+        public ICollection<string> ItemTypes { get; }
+        public ElementLocation ProjectFileLocation { get; }
+        public ICollection<ProjectPropertyInstance> Properties { get; }
+        public IDictionary<string, ProjectTargetInstance> Targets { get; }
+        public string ToolsVersion { get; }
+        public ProjectItemInstance AddItem(string itemType, string evaluatedInclude);
+        public ProjectItemInstance AddItem(string itemType, string evaluatedInclude, IEnumerable<KeyValuePair<string, string>> metadata);
+        public bool Build();
+        public bool Build(IEnumerable<ILogger> loggers);
+        public bool Build(IEnumerable<ILogger> loggers, IEnumerable<ForwardingLoggerRecord> remoteLoggers);
+        public bool Build(string target, IEnumerable<ILogger> loggers);
+        public bool Build(string target, IEnumerable<ILogger> loggers, IEnumerable<ForwardingLoggerRecord> remoteLoggers);
+        public bool Build(string[] targets, IEnumerable<ILogger> loggers);
+        public bool Build(string[] targets, IEnumerable<ILogger> loggers, out IDictionary<string, TargetResult> targetOutputs);
+        public bool Build(string[] targets, IEnumerable<ILogger> loggers, IEnumerable<ForwardingLoggerRecord> remoteLoggers);
+        public bool Build(string[] targets, IEnumerable<ILogger> loggers, IEnumerable<ForwardingLoggerRecord> remoteLoggers, out IDictionary<string, TargetResult> targetOutputs);
+        public ProjectInstance DeepCopy();
+        public ProjectInstance DeepCopy(bool isImmutable);
+        public bool EvaluateCondition(string condition);
+        public string ExpandString(string unexpandedValue);
+        public static string GetEvaluatedItemIncludeEscaped(ProjectItemDefinitionInstance item);
+        public static string GetEvaluatedItemIncludeEscaped(ProjectItemInstance item);
+        public ICollection<ProjectItemInstance> GetItems(string itemType);
+        public IEnumerable<ProjectItemInstance> GetItemsByItemTypeAndEvaluatedInclude(string itemType, string evaluatedInclude);
+        public static string GetMetadataValueEscaped(ProjectItemDefinitionInstance item, string name);
+        public static string GetMetadataValueEscaped(ProjectItemInstance item, string name);
+        public static string GetMetadataValueEscaped(ProjectMetadataInstance metadatum);
+        public ProjectPropertyInstance GetProperty(string name);
+        public string GetPropertyValue(string name);
+        public static string GetPropertyValueEscaped(ProjectPropertyInstance property);
+        public bool RemoveItem(ProjectItemInstance item);
+        public bool RemoveProperty(string name);
+        public ProjectPropertyInstance SetProperty(string name, string evaluatedValue);
+        public ProjectRootElement ToProjectRootElement();
+        public void UpdateStateFrom(ProjectInstance projectState);
+    }
+    public enum ProjectInstanceSettings {
+        Immutable = 1,
+        ImmutableWithFastItemLookup = 3,
+        None = 0,
+    }
+    public class ProjectItemDefinitionInstance : IItemDefinition<ProjectMetadataInstance>, IKeyed, IMetadataTable {
+        public string ItemType { get; }
+        public ICollection<ProjectMetadataInstance> Metadata { get; }
+        public int MetadataCount { get; }
+        public IEnumerable<string> MetadataNames { get; }
+        public ProjectMetadataInstance GetMetadata(string name);
+    }
+    public class ProjectItemGroupTaskInstance : ProjectTargetInstanceChild {
+        public override string Condition { get; }
+        public override ElementLocation ConditionLocation { get; }
+        public ICollection<ProjectItemGroupTaskItemInstance> Items { get; }
+        public override ElementLocation Location { get; }
+    }
+    public class ProjectItemGroupTaskItemInstance {
+        public string Condition { get; }
+        public ElementLocation ConditionLocation { get; }
+        public string Exclude { get; }
+        public ElementLocation ExcludeLocation { get; }
+        public string Include { get; }
+        public ElementLocation IncludeLocation { get; }
+        public string ItemType { get; }
+        public string KeepDuplicates { get; }
+        public ElementLocation KeepDuplicatesLocation { get; }
+        public string KeepMetadata { get; }
+        public ElementLocation KeepMetadataLocation { get; }
+        public ElementLocation Location { get; }
+        public ICollection<ProjectItemGroupTaskMetadataInstance> Metadata { get; }
+        public string Remove { get; }
+        public ElementLocation RemoveLocation { get; }
+        public string RemoveMetadata { get; }
+        public ElementLocation RemoveMetadataLocation { get; }
+    }
+    public class ProjectItemGroupTaskMetadataInstance {
+        public string Condition { get; }
+        public ElementLocation ConditionLocation { get; }
+        public ElementLocation Location { get; }
+        public string Name { get; }
+        public string Value { get; }
+    }
+    public class ProjectItemInstance : IDeepCloneable<ProjectItemInstance>, IItem, IItem<ProjectMetadataInstance>, IKeyed, IMetadataTable, INodePacketTranslatable, ITaskItem, ITaskItem2 {
+        public int DirectMetadataCount { get; }
+        public string EvaluatedInclude { get; set; }
+        public string ItemType { get; }
+        public IEnumerable<ProjectMetadataInstance> Metadata { get; }
+        public int MetadataCount { get; }
+        public ICollection<string> MetadataNames { get; }
+        string Microsoft.Build.Framework.ITaskItem.ItemSpec { get; set; }
+        ICollection Microsoft.Build.Framework.ITaskItem.MetadataNames { get; }
+        string Microsoft.Build.Framework.ITaskItem2.EvaluatedIncludeEscaped { get; set; }
+        public ProjectInstance Project { get; }
+        public ProjectMetadataInstance GetMetadata(string name);
+        public string GetMetadataValue(string name);
+        public bool HasMetadata(string name);
+        IDictionary Microsoft.Build.Framework.ITaskItem.CloneCustomMetadata();
+        void Microsoft.Build.Framework.ITaskItem.CopyMetadataTo(ITaskItem destinationItem);
+        string Microsoft.Build.Framework.ITaskItem.GetMetadata(string metadataName);
+        void Microsoft.Build.Framework.ITaskItem.SetMetadata(string metadataName, string metadataValue);
+        IDictionary Microsoft.Build.Framework.ITaskItem2.CloneCustomMetadataEscaped();
+        string Microsoft.Build.Framework.ITaskItem2.GetMetadataValueEscaped(string name);
+        void Microsoft.Build.Framework.ITaskItem2.SetMetadataValueLiteral(string metadataName, string metadataValue);
+        public void RemoveMetadata(string metadataName);
+        public void SetMetadata(IEnumerable<KeyValuePair<string, string>> metadataDictionary);
+        public ProjectMetadataInstance SetMetadata(string name, string evaluatedValue);
+        public override string ToString();
+    }
+    public class ProjectMetadataInstance : IDeepCloneable<ProjectMetadataInstance>, IEquatable<ProjectMetadataInstance>, IImmutable, IKeyed, IMetadatum, INodePacketTranslatable, IValued {
+        public string EvaluatedValue { get; }
+        public string Name { get; }
+        public ProjectMetadataInstance DeepClone();
+        bool System.IEquatable<Microsoft.Build.Execution.ProjectMetadataInstance>.Equals(ProjectMetadataInstance other);
+        public override string ToString();
+    }
+    public sealed class ProjectOnErrorInstance : ProjectTargetInstanceChild {
+        public override string Condition { get; }
+        public override ElementLocation ConditionLocation { get; }
+        public string ExecuteTargets { get; }
+        public ElementLocation ExecuteTargetsLocation { get; }
+        public override ElementLocation Location { get; }
+    }
+    public class ProjectPropertyGroupTaskInstance : ProjectTargetInstanceChild {
+        public override string Condition { get; }
+        public override ElementLocation ConditionLocation { get; }
+        public override ElementLocation Location { get; }
+        public ICollection<ProjectPropertyGroupTaskPropertyInstance> Properties { get; }
+    }
+    public class ProjectPropertyGroupTaskPropertyInstance {
+        public string Condition { get; }
+        public ElementLocation ConditionLocation { get; }
+        public ElementLocation Location { get; }
+        public string Name { get; }
+        public string Value { get; }
+    }
+    public class ProjectPropertyInstance : IDeepCloneable<ProjectPropertyInstance>, IEquatable<ProjectPropertyInstance>, IKeyed, INodePacketTranslatable, IProperty, IValued {
+        public string EvaluatedValue { get; set; }
+        public virtual bool IsImmutable { get; }
+        public string Name { get; }
+        bool System.IEquatable<Microsoft.Build.Execution.ProjectPropertyInstance>.Equals(ProjectPropertyInstance other);
+        public override string ToString();
+    }
+    public sealed class ProjectTargetInstance : IImmutable, IKeyed {
+        public ElementLocation AfterTargetsLocation { get; }
+        public ElementLocation BeforeTargetsLocation { get; }
+        public IList<ProjectTargetInstanceChild> Children { get; }
+        public string Condition { get; }
+        public ElementLocation ConditionLocation { get; }
+        public string DependsOnTargets { get; }
+        public ElementLocation DependsOnTargetsLocation { get; }
+        public string FullPath { get; }
+        public string Inputs { get; }
+        public ElementLocation InputsLocation { get; }
+        public string KeepDuplicateOutputs { get; }
+        public ElementLocation KeepDuplicateOutputsLocation { get; }
+        public ElementLocation Location { get; }
+        public string Name { get; }
+        public IList<ProjectOnErrorInstance> OnErrorChildren { get; }
+        public string Outputs { get; }
+        public ElementLocation OutputsLocation { get; }
+        public string Returns { get; }
+        public ElementLocation ReturnsLocation { get; }
+        public ICollection<ProjectTaskInstance> Tasks { get; }
+    }
+    public abstract class ProjectTargetInstanceChild {
+        protected ProjectTargetInstanceChild();
+        public abstract string Condition { get; }
+        public abstract ElementLocation ConditionLocation { get; }
+        public string FullPath { get; }
+        public abstract ElementLocation Location { get; }
+    }
+    public sealed class ProjectTaskInstance : ProjectTargetInstanceChild {
+        public override string Condition { get; }
+        public override ElementLocation ConditionLocation { get; }
+        public string ContinueOnError { get; }
+        public ElementLocation ContinueOnErrorLocation { get; }
+        public override ElementLocation Location { get; }
+        public string MSBuildArchitecture { get; }
+        public ElementLocation MSBuildArchitectureLocation { get; }
+        public string MSBuildRuntime { get; }
+        public ElementLocation MSBuildRuntimeLocation { get; }
+        public string Name { get; }
+        public IList<ProjectTaskInstanceChild> Outputs { get; }
+        public IDictionary<string, string> Parameters { get; }
+    }
+    public abstract class ProjectTaskInstanceChild {
+        protected ProjectTaskInstanceChild();
+        public abstract string Condition { get; }
+        public abstract ElementLocation ConditionLocation { get; }
+        public abstract ElementLocation Location { get; }
+        public abstract ElementLocation TaskParameterLocation { get; }
+    }
+    public sealed class ProjectTaskOutputItemInstance : ProjectTaskInstanceChild {
+        public override string Condition { get; }
+        public override ElementLocation ConditionLocation { get; }
+        public string ItemType { get; }
+        public ElementLocation ItemTypeLocation { get; }
+        public override ElementLocation Location { get; }
+        public string TaskParameter { get; }
+        public override ElementLocation TaskParameterLocation { get; }
+    }
+    public sealed class ProjectTaskOutputPropertyInstance : ProjectTaskInstanceChild {
+        public override string Condition { get; }
+        public override ElementLocation ConditionLocation { get; }
+        public override ElementLocation Location { get; }
+        public string PropertyName { get; }
+        public ElementLocation PropertyNameLocation { get; }
+        public string TaskParameter { get; }
+        public override ElementLocation TaskParameterLocation { get; }
+    }
+    public class TargetResult : INodePacketTranslatable, ITargetResult {
+        public Exception Exception { get; }
+        public ITaskItem[] Items { get; }
+        public TargetResultCode ResultCode { get; }
+    }
+    public enum TargetResultCode : byte {
+        Failure = (byte)2,
+        Skipped = (byte)0,
+        Success = (byte)1,
+    }
+}
```

