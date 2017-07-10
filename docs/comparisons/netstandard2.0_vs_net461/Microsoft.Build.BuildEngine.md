# Microsoft.Build.BuildEngine

``` diff
+namespace Microsoft.Build.BuildEngine {
+    public class BuildItem {
+        public BuildItem(string itemName, ITaskItem taskItem);
+        public BuildItem(string itemName, string itemInclude);
+        public string Condition { get; set; }
+        public int CustomMetadataCount { get; }
+        public ICollection CustomMetadataNames { get; }
+        public string Exclude { get; set; }
+        public string FinalItemSpec { get; }
+        public string Include { get; set; }
+        public bool IsImported { get; }
+        public int MetadataCount { get; }
+        public ICollection MetadataNames { get; }
+        public string Name { get; set; }
+        public BuildItem Clone();
+        public void CopyCustomMetadataTo(BuildItem destinationItem);
+        public string GetEvaluatedMetadata(string metadataName);
+        public string GetMetadata(string metadataName);
+        public bool HasMetadata(string metadataName);
+        public void RemoveMetadata(string metadataName);
+        public void SetMetadata(string metadataName, string metadataValue);
+        public void SetMetadata(string metadataName, string metadataValue, bool treatMetadataValueAsLiteral);
+    }
+    public class BuildItemGroup : IEnumerable, IItemPropertyGrouping {
+        public BuildItemGroup();
+        public string Condition { get; set; }
+        public int Count { get; }
+        public bool IsImported { get; }
+        public BuildItem this[int index] { get; }
+        public BuildItem AddNewItem(string itemName, string itemInclude);
+        public BuildItem AddNewItem(string itemName, string itemInclude, bool treatItemIncludeAsLiteral);
+        public void Clear();
+        public BuildItemGroup Clone(bool deepClone);
+        public IEnumerator GetEnumerator();
+        public void RemoveItem(BuildItem itemToRemove);
+        public void RemoveItemAt(int index);
+        public BuildItem[] ToArray();
+    }
+    public class BuildItemGroupCollection : ICollection, IEnumerable {
+        public int Count { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        public void CopyTo(Array array, int index);
+        public IEnumerator GetEnumerator();
+    }
+    public class BuildProperty {
+        public BuildProperty(string propertyName, string propertyValue);
+        public string Condition { get; set; }
+        public string FinalValue { get; }
+        public bool IsImported { get; }
+        public string Name { get; }
+        public string Value { get; set; }
+        public BuildProperty Clone(bool deepClone);
+        public static explicit operator string (BuildProperty propertyToCast);
+        public override string ToString();
+    }
+    public class BuildPropertyGroup : IEnumerable, IItemPropertyGrouping {
+        public BuildPropertyGroup();
+        public BuildPropertyGroup(Project parentProject);
+        public string Condition { get; set; }
+        public int Count { get; }
+        public bool IsImported { get; }
+        public BuildProperty this[string propertyName] { get; set; }
+        public BuildProperty AddNewProperty(string propertyName, string propertyValue);
+        public BuildProperty AddNewProperty(string propertyName, string propertyValue, bool treatPropertyValueAsLiteral);
+        public void Clear();
+        public BuildPropertyGroup Clone(bool deepClone);
+        public IEnumerator GetEnumerator();
+        public void RemoveProperty(BuildProperty property);
+        public void RemoveProperty(string propertyName);
+        public void SetImportedPropertyGroupCondition(string condition);
+        public void SetProperty(string propertyName, string propertyValue);
+        public void SetProperty(string propertyName, string propertyValue, bool treatPropertyValueAsLiteral);
+    }
+    public class BuildPropertyGroupCollection : ICollection, IEnumerable {
+        public int Count { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        public void CopyTo(Array array, int index);
+        public IEnumerator GetEnumerator();
+    }
+    public enum BuildSettings {
+        DoNotResetPreviouslyBuiltTargets = 1,
+        None = 0,
+    }
+    public class BuildTask {
+        public string Condition { get; set; }
+        public bool ContinueOnError { get; set; }
+        public ITaskHost HostObject { get; set; }
+        public string Name { get; }
+        public Type Type { get; }
+        public void AddOutputItem(string taskParameter, string itemName);
+        public void AddOutputProperty(string taskParameter, string propertyName);
+        public bool Execute();
+        public string[] GetParameterNames();
+        public string GetParameterValue(string attributeName);
+        public void SetParameterValue(string parameterName, string parameterValue);
+        public void SetParameterValue(string parameterName, string parameterValue, bool treatParameterValueAsLiteral);
+    }
+    public delegate void ColorResetter();
+    public delegate void ColorSetter(ConsoleColor color);
+    public class ConfigurableForwardingLogger : IForwardingLogger, ILogger, INodeLogger {
+        public ConfigurableForwardingLogger();
+        public IEventRedirector BuildEventRedirector { get; set; }
+        public int NodeId { get; set; }
+        public string Parameters { get; set; }
+        public LoggerVerbosity Verbosity { get; set; }
+        protected virtual void ForwardToCentralLogger(BuildEventArgs e);
+        public virtual void Initialize(IEventSource eventSource);
+        public void Initialize(IEventSource eventSource, int nodeCount);
+        public virtual void Shutdown();
+    }
+    public class ConsoleLogger : ILogger, INodeLogger {
+        public ConsoleLogger();
+        public ConsoleLogger(LoggerVerbosity verbosity);
+        public ConsoleLogger(LoggerVerbosity verbosity, WriteHandler write, ColorSetter colorSet, ColorResetter colorReset);
+        public string Parameters { get; set; }
+        public bool ShowSummary { get; set; }
+        public bool SkipProjectStartedText { get; set; }
+        public LoggerVerbosity Verbosity { get; set; }
+        protected WriteHandler WriteHandler { get; set; }
+        public void ApplyParameter(string parameterName, string parameterValue);
+        public void BuildFinishedHandler(object sender, BuildFinishedEventArgs e);
+        public void BuildStartedHandler(object sender, BuildStartedEventArgs e);
+        public void CustomEventHandler(object sender, CustomBuildEventArgs e);
+        public void ErrorHandler(object sender, BuildErrorEventArgs e);
+        public virtual void Initialize(IEventSource eventSource);
+        public virtual void Initialize(IEventSource eventSource, int nodeCount);
+        public void MessageHandler(object sender, BuildMessageEventArgs e);
+        public void ProjectFinishedHandler(object sender, ProjectFinishedEventArgs e);
+        public void ProjectStartedHandler(object sender, ProjectStartedEventArgs e);
+        public virtual void Shutdown();
+        public void TargetFinishedHandler(object sender, TargetFinishedEventArgs e);
+        public void TargetStartedHandler(object sender, TargetStartedEventArgs e);
+        public void TaskFinishedHandler(object sender, TaskFinishedEventArgs e);
+        public void TaskStartedHandler(object sender, TaskStartedEventArgs e);
+        public void WarningHandler(object sender, BuildWarningEventArgs e);
+    }
+    public class DistributedFileLogger : IForwardingLogger, ILogger, INodeLogger {
+        public DistributedFileLogger();
+        public IEventRedirector BuildEventRedirector { get; set; }
+        public int NodeId { get; set; }
+        public string Parameters { get; set; }
+        public LoggerVerbosity Verbosity { get; set; }
+        public void Initialize(IEventSource eventSource);
+        public void Initialize(IEventSource eventSource, int nodeCount);
+        public void Shutdown();
+    }
+    public class Engine {
+        public Engine();
+        public Engine(BuildPropertyGroup globalProperties);
+        public Engine(BuildPropertyGroup globalProperties, ToolsetDefinitionLocations locations);
+        public Engine(BuildPropertyGroup globalProperties, ToolsetDefinitionLocations locations, int numberOfCpus, string localNodeProviderParameters);
+        public Engine(ToolsetDefinitionLocations locations);
+        public Engine(string binPath);
+        public string BinPath { get; set; }
+        public bool BuildEnabled { get; set; }
+        public string DefaultToolsVersion { get; set; }
+        public static Engine GlobalEngine { get; }
+        public BuildPropertyGroup GlobalProperties { get; set; }
+        public bool IsBuilding { get; }
+        public bool OnlyLogCriticalEvents { get; set; }
+        public ToolsetCollection Toolsets { get; }
+        public static Version Version { get; }
+        public bool BuildProject(Project project);
+        public bool BuildProject(Project project, string targetName);
+        public bool BuildProject(Project project, string[] targetNames);
+        public bool BuildProject(Project project, string[] targetNames, IDictionary targetOutputs);
+        public bool BuildProject(Project project, string[] targetNames, IDictionary targetOutputs, BuildSettings buildFlags);
+        public bool BuildProjectFile(string projectFile);
+        public bool BuildProjectFile(string projectFile, string targetName);
+        public bool BuildProjectFile(string projectFile, string[] targetNames);
+        public bool BuildProjectFile(string projectFile, string[] targetNames, BuildPropertyGroup globalProperties);
+        public bool BuildProjectFile(string projectFile, string[] targetNames, BuildPropertyGroup globalProperties, IDictionary targetOutputs);
+        public bool BuildProjectFile(string projectFile, string[] targetNames, BuildPropertyGroup globalProperties, IDictionary targetOutputs, BuildSettings buildFlags);
+        public bool BuildProjectFile(string projectFile, string[] targetNames, BuildPropertyGroup globalProperties, IDictionary targetOutputs, BuildSettings buildFlags, string toolsVersion);
+        public bool BuildProjectFiles(string[] projectFiles, string[][] targetNamesPerProject, BuildPropertyGroup[] globalPropertiesPerProject, IDictionary[] targetOutputsPerProject, BuildSettings buildFlags, string[] toolsVersions);
+        public Project CreateNewProject();
+        public Project GetLoadedProject(string projectFullFileName);
+        public void RegisterDistributedLogger(ILogger centralLogger, LoggerDescription forwardingLogger);
+        public void RegisterLogger(ILogger logger);
+        public void Shutdown();
+        public void UnloadAllProjects();
+        public void UnloadProject(Project project);
+        public void UnregisterAllLoggers();
+    }
+    public class FileLogger : ConsoleLogger {
+        public FileLogger();
+        public override void Initialize(IEventSource eventSource);
+        public override void Initialize(IEventSource eventSource, int nodeCount);
+        public override void Shutdown();
+    }
+    public class Import : IItemPropertyGrouping {
+        public string Condition { get; set; }
+        public string EvaluatedProjectPath { get; }
+        public bool IsImported { get; }
+        public string ProjectPath { get; set; }
+    }
+    public class ImportCollection : ICollection, IEnumerable {
+        public int Count { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        public void AddNewImport(string projectFile, string condition);
+        public void CopyTo(Import[] array, int index);
+        public void CopyTo(Array array, int index);
+        public IEnumerator GetEnumerator();
+        public void RemoveImport(Import importToRemove);
+    }
+    public sealed class InternalLoggerException : Exception {
+        public InternalLoggerException();
+        public InternalLoggerException(string message);
+        public InternalLoggerException(string message, Exception innerException);
+        public BuildEventArgs BuildEventArgs { get; }
+        public string ErrorCode { get; }
+        public string HelpKeyword { get; }
+        public bool InitializationException { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public sealed class InvalidProjectFileException : Exception {
+        public InvalidProjectFileException();
+        public InvalidProjectFileException(string message);
+        public InvalidProjectFileException(string message, Exception innerException);
+        public InvalidProjectFileException(string projectFile, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string errorSubcategory, string errorCode, string helpKeyword);
+        public InvalidProjectFileException(XmlNode xmlNode, string message, string errorSubcategory, string errorCode, string helpKeyword);
+        public string BaseMessage { get; }
+        public int ColumnNumber { get; }
+        public int EndColumnNumber { get; }
+        public int EndLineNumber { get; }
+        public string ErrorCode { get; }
+        public string ErrorSubcategory { get; }
+        public string HelpKeyword { get; }
+        public int LineNumber { get; }
+        public override string Message { get; }
+        public string ProjectFile { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class InvalidToolsetDefinitionException : Exception {
+        public InvalidToolsetDefinitionException();
+        protected InvalidToolsetDefinitionException(SerializationInfo info, StreamingContext context);
+        public InvalidToolsetDefinitionException(string message);
+        public InvalidToolsetDefinitionException(string message, Exception innerException);
+        public InvalidToolsetDefinitionException(string message, string errorCode);
+        public InvalidToolsetDefinitionException(string message, string errorCode, Exception innerException);
+        public string ErrorCode { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class LocalNode {
+        public static void StartLocalNodeServer(int nodeNumber);
+    }
+    public class LoggerDescription {
+        public LoggerDescription(string loggerClassName, string loggerAssemblyName, string loggerAssemblyFile, string loggerSwitchParameters, LoggerVerbosity verbosity);
+        public string LoggerSwitchParameters { get; }
+        public LoggerVerbosity Verbosity { get; }
+    }
+    public class Project {
+        public Project();
+        public Project(Engine engine);
+        public Project(Engine engine, string toolsVersion);
+        public bool BuildEnabled { get; set; }
+        public string DefaultTargets { get; set; }
+        public string DefaultToolsVersion { get; set; }
+        public Encoding Encoding { get; }
+        public BuildItemGroup EvaluatedItems { get; }
+        public BuildItemGroup EvaluatedItemsIgnoringCondition { get; }
+        public BuildPropertyGroup EvaluatedProperties { get; }
+        public string FullFileName { get; set; }
+        public BuildPropertyGroup GlobalProperties { get; set; }
+        public bool HasToolsVersionAttribute { get; }
+        public ImportCollection Imports { get; }
+        public string InitialTargets { get; set; }
+        public bool IsDirty { get; }
+        public bool IsValidated { get; set; }
+        public BuildItemGroupCollection ItemGroups { get; }
+        public Engine ParentEngine { get; }
+        public BuildPropertyGroupCollection PropertyGroups { get; }
+        public string SchemaFile { get; set; }
+        public TargetCollection Targets { get; }
+        public DateTime TimeOfLastDirty { get; }
+        public string ToolsVersion { get; internal set; }
+        public UsingTaskCollection UsingTasks { get; }
+        public string Xml { get; }
+        public void AddNewImport(string projectFile, string condition);
+        public BuildItem AddNewItem(string itemName, string itemInclude);
+        public BuildItem AddNewItem(string itemName, string itemInclude, bool treatItemIncludeAsLiteral);
+        public BuildItemGroup AddNewItemGroup();
+        public BuildPropertyGroup AddNewPropertyGroup(bool insertAtEndOfProject);
+        public void AddNewUsingTaskFromAssemblyFile(string taskName, string assemblyFile);
+        public void AddNewUsingTaskFromAssemblyName(string taskName, string assemblyName);
+        public bool Build();
+        public bool Build(string targetName);
+        public bool Build(string[] targetNames);
+        public bool Build(string[] targetNames, IDictionary targetOutputs);
+        public bool Build(string[] targetNames, IDictionary targetOutputs, BuildSettings buildFlags);
+        public string[] GetConditionedPropertyValues(string propertyName);
+        public BuildItemGroup GetEvaluatedItemsByName(string itemName);
+        public BuildItemGroup GetEvaluatedItemsByNameIgnoringCondition(string itemName);
+        public string GetEvaluatedProperty(string propertyName);
+        public string GetProjectExtensions(string id);
+        public void Load(TextReader textReader);
+        public void Load(TextReader textReader, ProjectLoadSettings projectLoadSettings);
+        public void Load(string projectFileName);
+        public void Load(string projectFileName, ProjectLoadSettings projectLoadSettings);
+        public void LoadXml(string projectXml);
+        public void LoadXml(string projectXml, ProjectLoadSettings projectLoadSettings);
+        public void MarkProjectAsDirty();
+        public void RemoveAllItemGroups();
+        public void RemoveAllPropertyGroups();
+        public void RemoveImportedPropertyGroup(BuildPropertyGroup propertyGroupToRemove);
+        public void RemoveItem(BuildItem itemToRemove);
+        public void RemoveItemGroup(BuildItemGroup itemGroupToRemove);
+        public void RemoveItemGroupsWithMatchingCondition(string matchCondition);
+        public void RemoveItemsByName(string itemName);
+        public void RemovePropertyGroup(BuildPropertyGroup propertyGroupToRemove);
+        public void RemovePropertyGroupsWithMatchingCondition(string matchCondition);
+        public void RemovePropertyGroupsWithMatchingCondition(string matchCondition, bool includeImportedPropertyGroups);
+        public void ResetBuildStatus();
+        public void Save(TextWriter textWriter);
+        public void Save(string projectFileName);
+        public void Save(string projectFileName, Encoding encoding);
+        public void SetImportedProperty(string propertyName, string propertyValue, string condition, Project importProject);
+        public void SetImportedProperty(string propertyName, string propertyValue, string condition, Project importedProject, PropertyPosition position);
+        public void SetImportedProperty(string propertyName, string propertyValue, string condition, Project importedProject, PropertyPosition position, bool treatPropertyValueAsLiteral);
+        public void SetProjectExtensions(string id, string content);
+        public void SetProperty(string propertyName, string propertyValue);
+        public void SetProperty(string propertyName, string propertyValue, string condition);
+        public void SetProperty(string propertyName, string propertyValue, string condition, PropertyPosition position);
+        public void SetProperty(string propertyName, string propertyValue, string condition, PropertyPosition position, bool treatPropertyValueAsLiteral);
+    }
+    public enum ProjectLoadSettings {
+        IgnoreMissingImports = 1,
+        None = 0,
+    }
+    public enum PropertyPosition {
+        UseExistingOrCreateAfterLastImport = 1,
+        UseExistingOrCreateAfterLastPropertyGroup = 0,
+    }
+    public sealed class RemoteErrorException : Exception {
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public static class SolutionWrapperProject {
+        public static string Generate(string solutionPath, string toolsVersionOverride, BuildEventContext projectBuildEventContext);
+    }
+    public class Target : IEnumerable {
+        public string Condition { get; set; }
+        public string DependsOnTargets { get; set; }
+        public string Inputs { get; set; }
+        public bool IsImported { get; }
+        public string Name { get; }
+        public string Outputs { get; set; }
+        public BuildTask AddNewTask(string taskName);
+        public IEnumerator GetEnumerator();
+        public void RemoveTask(BuildTask taskElement);
+    }
+    public class TargetCollection : ICollection, IEnumerable {
+        public int Count { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        public Target this[string index] { get; }
+        public Target AddNewTarget(string targetName);
+        public void CopyTo(Array array, int index);
+        public bool Exists(string targetName);
+        public IEnumerator GetEnumerator();
+        public void RemoveTarget(Target targetToRemove);
+    }
+    public class Toolset {
+        public Toolset(string toolsVersion, string toolsPath);
+        public Toolset(string toolsVersion, string toolsPath, BuildPropertyGroup buildProperties);
+        public BuildPropertyGroup BuildProperties { get; }
+        public string ToolsPath { get; private set; }
+        public string ToolsVersion { get; }
+        public Toolset Clone();
+    }
+    public class ToolsetCollection : ICollection<Toolset>, IEnumerable, IEnumerable<Toolset> {
+        public int Count { get; }
+        public bool IsReadOnly { get; }
+        public Toolset this[string toolsVersion] { get; }
+        public IEnumerable<string> ToolsVersions { get; }
+        public void Add(Toolset item);
+        public void Clear();
+        public bool Contains(Toolset item);
+        public bool Contains(string toolsVersion);
+        public void CopyTo(Toolset[] array, int arrayIndex);
+        public IEnumerator<Toolset> GetEnumerator();
+        public bool Remove(Toolset item);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+    }
+    public enum ToolsetDefinitionLocations {
+        ConfigurationFile = 1,
+        None = 0,
+        Registry = 2,
+    }
+    public class UsingTask {
+        public string AssemblyFile { get; }
+        public string AssemblyName { get; }
+        public string Condition { get; }
+        public bool IsImported { get; }
+        public string TaskName { get; }
+    }
+    public class UsingTaskCollection : ICollection, IEnumerable {
+        public int Count { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        public void CopyTo(UsingTask[] array, int index);
+        public void CopyTo(Array array, int index);
+        public IEnumerator GetEnumerator();
+    }
+    public static class Utilities {
+        public static string Escape(string unescapedExpression);
+    }
+    public delegate void WriteHandler(string message);
+}
```

