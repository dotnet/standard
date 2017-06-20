# Microsoft.Build.Evaluation

``` diff
+namespace Microsoft.Build.Evaluation {
+    public class Project {
+        public Project();
+        public Project(ProjectRootElement xml);
+        public Project(ProjectRootElement xml, IDictionary<string, string> globalProperties, string toolsVersion);
+        public Project(ProjectRootElement xml, IDictionary<string, string> globalProperties, string toolsVersion, ProjectCollection projectCollection);
+        public Project(ProjectRootElement xml, IDictionary<string, string> globalProperties, string toolsVersion, ProjectCollection projectCollection, ProjectLoadSettings loadSettings);
+        public Project(ProjectRootElement xml, IDictionary<string, string> globalProperties, string toolsVersion, string subToolsetVersion, ProjectCollection projectCollection, ProjectLoadSettings loadSettings);
+        public Project(ProjectCollection projectCollection);
+        public Project(IDictionary<string, string> globalProperties, string toolsVersion, ProjectCollection projectCollection);
+        public Project(string projectFile);
+        public Project(string projectFile, IDictionary<string, string> globalProperties, string toolsVersion);
+        public Project(string projectFile, IDictionary<string, string> globalProperties, string toolsVersion, ProjectCollection projectCollection);
+        public Project(string projectFile, IDictionary<string, string> globalProperties, string toolsVersion, ProjectCollection projectCollection, ProjectLoadSettings loadSettings);
+        public Project(string projectFile, IDictionary<string, string> globalProperties, string toolsVersion, string subToolsetVersion, ProjectCollection projectCollection, ProjectLoadSettings loadSettings);
+        public Project(XmlReader xmlReader);
+        public Project(XmlReader xmlReader, IDictionary<string, string> globalProperties, string toolsVersion);
+        public Project(XmlReader xmlReader, IDictionary<string, string> globalProperties, string toolsVersion, ProjectCollection projectCollection);
+        public Project(XmlReader xmlReader, IDictionary<string, string> globalProperties, string toolsVersion, ProjectCollection projectCollection, ProjectLoadSettings loadSettings);
+        public Project(XmlReader xmlReader, IDictionary<string, string> globalProperties, string toolsVersion, string subToolsetVersion, ProjectCollection projectCollection, ProjectLoadSettings loadSettings);
+        public ICollection<ProjectMetadata> AllEvaluatedItemDefinitionMetadata { get; }
+        public ICollection<ProjectItem> AllEvaluatedItems { get; }
+        public ICollection<ProjectProperty> AllEvaluatedProperties { get; }
+        public IDictionary<string, List<string>> ConditionedProperties { get; }
+        public string DirectoryPath { get; }
+        public bool DisableMarkDirty { get; set; }
+        public int EvaluationCounter { get; }
+        public string FullPath { get; set; }
+        public IDictionary<string, string> GlobalProperties { get; }
+        public IList<ResolvedImport> Imports { get; }
+        public IList<ResolvedImport> ImportsIncludingDuplicates { get; }
+        public bool IsBuildEnabled { get; set; }
+        public bool IsDirty { get; }
+        public IDictionary<string, ProjectItemDefinition> ItemDefinitions { get; }
+        public ICollection<ProjectItem> Items { get; }
+        public ICollection<ProjectItem> ItemsIgnoringCondition { get; }
+        public ICollection<string> ItemTypes { get; }
+        public ProjectCollection ProjectCollection { get; }
+        public ElementLocation ProjectFileLocation { get; }
+        public ICollection<ProjectProperty> Properties { get; }
+        public bool SkipEvaluation { get; set; }
+        public string SubToolsetVersion { get; }
+        public IDictionary<string, ProjectTargetInstance> Targets { get; }
+        public string ToolsVersion { get; }
+        public ProjectRootElement Xml { get; }
+        public IList<ProjectItem> AddItem(string itemType, string unevaluatedInclude);
+        public IList<ProjectItem> AddItem(string itemType, string unevaluatedInclude, IEnumerable<KeyValuePair<string, string>> metadata);
+        public IList<ProjectItem> AddItemFast(string itemType, string unevaluatedInclude);
+        public IList<ProjectItem> AddItemFast(string itemType, string unevaluatedInclude, IEnumerable<KeyValuePair<string, string>> metadata);
+        public bool Build();
+        public bool Build(ILogger logger);
+        public bool Build(IEnumerable<ILogger> loggers);
+        public bool Build(IEnumerable<ILogger> loggers, IEnumerable<ForwardingLoggerRecord> remoteLoggers);
+        public bool Build(string target);
+        public bool Build(string target, IEnumerable<ILogger> loggers);
+        public bool Build(string target, IEnumerable<ILogger> loggers, IEnumerable<ForwardingLoggerRecord> remoteLoggers);
+        public bool Build(string[] targets);
+        public bool Build(string[] targets, IEnumerable<ILogger> loggers);
+        public bool Build(string[] targets, IEnumerable<ILogger> loggers, IEnumerable<ForwardingLoggerRecord> remoteLoggers);
+        public ProjectInstance CreateProjectInstance();
+        public ProjectInstance CreateProjectInstance(ProjectInstanceSettings settings);
+        public string ExpandString(string unexpandedValue);
+        public static string GetEvaluatedItemIncludeEscaped(ProjectItem item);
+        public static string GetEvaluatedItemIncludeEscaped(ProjectItemDefinition item);
+        public ICollection<ProjectItem> GetItems(string itemType);
+        public ICollection<ProjectItem> GetItemsByEvaluatedInclude(string evaluatedInclude);
+        public ICollection<ProjectItem> GetItemsIgnoringCondition(string itemType);
+        public IEnumerable<ProjectElement> GetLogicalProject();
+        public static string GetMetadataValueEscaped(ProjectItem item, string name);
+        public static string GetMetadataValueEscaped(ProjectItemDefinition item, string name);
+        public static string GetMetadataValueEscaped(ProjectMetadata metadatum);
+        public ProjectProperty GetProperty(string name);
+        public string GetPropertyValue(string name);
+        public static string GetPropertyValueEscaped(ProjectProperty property);
+        public void MarkDirty();
+        public void ReevaluateIfNecessary();
+        public bool RemoveGlobalProperty(string name);
+        public bool RemoveItem(ProjectItem item);
+        public void RemoveItems(IEnumerable<ProjectItem> items);
+        public bool RemoveProperty(ProjectProperty property);
+        public void Save();
+        public void Save(TextWriter writer);
+        public void Save(string path);
+        public void Save(string path, Encoding encoding);
+        public void Save(Encoding encoding);
+        public void SaveLogicalProject(TextWriter writer);
+        public bool SetGlobalProperty(string name, string escapedValue);
+        public ProjectProperty SetProperty(string name, string unevaluatedValue);
+    }
+    public class ProjectChangedEventArgs : EventArgs {
+        public Project Project { get; private set; }
+    }
+    public class ProjectCollection : IBuildComponent, IDisposable, IToolsetProvider {
+        public ProjectCollection();
+        public ProjectCollection(ToolsetDefinitionLocations toolsetLocations);
+        public ProjectCollection(IDictionary<string, string> globalProperties);
+        public ProjectCollection(IDictionary<string, string> globalProperties, IEnumerable<ILogger> loggers, ToolsetDefinitionLocations toolsetDefinitionLocations);
+        public ProjectCollection(IDictionary<string, string> globalProperties, IEnumerable<ILogger> loggers, IEnumerable<ForwardingLoggerRecord> remoteLoggers, ToolsetDefinitionLocations toolsetDefinitionLocations, int maxNodeCount, bool onlyLogCriticalEvents);
+        public int Count { get; }
+        public string DefaultToolsVersion { get; set; }
+        public bool DisableMarkDirty { get; set; }
+        public static ProjectCollection GlobalProjectCollection { get; }
+        public IDictionary<string, string> GlobalProperties { get; }
+        public HostServices HostServices { get; set; }
+        public bool IsBuildEnabled { get; set; }
+        public ICollection<Project> LoadedProjects { get; }
+        public ICollection<ILogger> Loggers { get; }
+        public bool OnlyLogCriticalEvents { get; set; }
+        public bool SkipEvaluation { get; set; }
+        public ToolsetDefinitionLocations ToolsetLocations { get; }
+        public ICollection<Toolset> Toolsets { get; }
+        public static Version Version { get; }
+        public event ProjectCollection.ProjectAddedEventHandler ProjectAdded;
+        public event EventHandler<ProjectChangedEventArgs> ProjectChanged;
+        public event EventHandler<ProjectCollectionChangedEventArgs> ProjectCollectionChanged;
+        public event EventHandler<ProjectXmlChangedEventArgs> ProjectXmlChanged;
+        public void AddToolset(Toolset toolset);
+        public bool ContainsToolset(string toolsVersion);
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        public static string Escape(string unescapedString);
+        public ProjectPropertyInstance GetGlobalProperty(string name);
+        public ICollection<Project> GetLoadedProjects(string fullPath);
+        public Toolset GetToolset(string toolsVersion);
+        public Project LoadProject(string fileName);
+        public Project LoadProject(string fileName, IDictionary<string, string> globalProperties, string toolsVersion);
+        public Project LoadProject(string fileName, string toolsVersion);
+        public Project LoadProject(XmlReader xmlReader);
+        public Project LoadProject(XmlReader xmlReader, IDictionary<string, string> globalProperties, string toolsVersion);
+        public Project LoadProject(XmlReader xmlReader, string toolsVersion);
+        public void RegisterForwardingLoggers(IEnumerable<ForwardingLoggerRecord> remoteLoggers);
+        public void RegisterLogger(ILogger logger);
+        public void RegisterLoggers(IEnumerable<ILogger> loggers);
+        public void RemoveAllToolsets();
+        public bool RemoveGlobalProperty(string name);
+        public bool RemoveToolset(string toolsVersion);
+        public void SetGlobalProperty(string name, string value);
+        public bool TryUnloadProject(ProjectRootElement projectRootElement);
+        public static string Unescape(string escapedString);
+        public void UnloadAllProjects();
+        public void UnloadProject(ProjectRootElement projectRootElement);
+        public void UnloadProject(Project project);
+        public void UnregisterAllLoggers();
+        public delegate void ProjectAddedEventHandler(object sender, ProjectCollection.ProjectAddedToProjectCollectionEventArgs e);
+        public class ProjectAddedToProjectCollectionEventArgs : EventArgs {
+            public ProjectAddedToProjectCollectionEventArgs(ProjectRootElement element);
+            public ProjectRootElement ProjectRootElement { get; }
+        }
+    }
+    public class ProjectCollectionChangedEventArgs : EventArgs {
+        public ProjectCollectionChangedState Changed { get; private set; }
+    }
+    public enum ProjectCollectionChangedState {
+        DefaultToolsVersion = 0,
+        DisableMarkDirty = 7,
+        GlobalProperties = 3,
+        HostServices = 6,
+        IsBuildEnabled = 4,
+        Loggers = 2,
+        OnlyLogCriticalEvents = 5,
+        SkipEvaluation = 8,
+        Toolsets = 1,
+    }
+    public class ProjectItem : IItem, IItem<ProjectMetadata>, IKeyed, IMetadataTable, IProjectMetadataParent {
+        public IEnumerable<ProjectMetadata> DirectMetadata { get; }
+        public int DirectMetadataCount { get; }
+        public string EvaluatedInclude { get; }
+        public bool IsImported { get; }
+        public string ItemType { get; set; }
+        public ICollection<ProjectMetadata> Metadata { get; }
+        public int MetadataCount { get; }
+        public Project Project { get; }
+        public string UnevaluatedInclude { get; set; }
+        public ProjectItemElement Xml { get; }
+        public ProjectMetadata GetMetadata(string name);
+        public string GetMetadataValue(string name);
+        public bool HasMetadata(string name);
+        public bool RemoveMetadata(string name);
+        public void Rename(string name);
+        public ProjectMetadata SetMetadataValue(string name, string unevaluatedValue);
+    }
+    public class ProjectItemDefinition : IItemDefinition<ProjectMetadata>, IKeyed, IMetadataTable, IProjectMetadataParent {
+        public string ItemType { get; }
+        public IEnumerable<ProjectMetadata> Metadata { get; }
+        public int MetadataCount { get; }
+        public Project Project { get; }
+        public ProjectMetadata GetMetadata(string name);
+        public string GetMetadataValue(string name);
+        public ProjectMetadata SetMetadataValue(string name, string unevaluatedValue);
+    }
+    public enum ProjectLoadSettings {
+        Default = 0,
+        IgnoreMissingImports = 1,
+        RecordDuplicateButNotCircularImports = 2,
+        RejectCircularImports = 4,
+    }
+    public class ProjectMetadata : IEquatable<ProjectMetadata>, IKeyed, IMetadatum, IValued {
+        public ElementLocation ConditionLocation { get; }
+        public string EvaluatedValue { get; }
+        public bool IsImported { get; }
+        public string ItemType { get; }
+        public ElementLocation Location { get; }
+        public string Name { get; }
+        public ProjectMetadata Predecessor { get; }
+        public Project Project { get; }
+        public string UnevaluatedValue { get; set; }
+        public ProjectMetadataElement Xml { get; }
+        bool System.IEquatable<Microsoft.Build.Evaluation.ProjectMetadata>.Equals(ProjectMetadata other);
+    }
+    public abstract class ProjectProperty : IEquatable<ProjectProperty>, IKeyed, IProperty, IValued {
+        public string EvaluatedValue { get; }
+        public abstract bool IsEnvironmentProperty { get; }
+        public abstract bool IsGlobalProperty { get; }
+        public abstract bool IsImported { get; }
+        public abstract bool IsReservedProperty { get; }
+        public abstract string Name { get; }
+        public abstract ProjectProperty Predecessor { get; }
+        public Project Project { get; }
+        public abstract string UnevaluatedValue { get; set; }
+        public abstract ProjectPropertyElement Xml { get; }
+        bool System.IEquatable<Microsoft.Build.Evaluation.ProjectProperty>.Equals(ProjectProperty other);
+    }
+    public class ProjectXmlChangedEventArgs : EventArgs {
+        public ProjectRootElement ProjectXml { get; private set; }
+        public string Reason { get; }
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct ResolvedImport {
+        public ProjectRootElement ImportedProject { get; }
+        public ProjectImportElement ImportingElement { get; }
+        public bool IsImported { get; }
+    }
+    public class SubToolset : INodePacketTranslatable {
+        public IDictionary<string, ProjectPropertyInstance> Properties { get; }
+        public string SubToolsetVersion { get; }
+    }
+    public class Toolset : INodePacketTranslatable {
+        public Toolset(string toolsVersion, string toolsPath, ProjectCollection projectCollection, string msbuildOverrideTasksPath);
+        public Toolset(string toolsVersion, string toolsPath, IDictionary<string, string> buildProperties, ProjectCollection projectCollection, IDictionary<string, SubToolset> subToolsets, string msbuildOverrideTasksPath);
+        public Toolset(string toolsVersion, string toolsPath, IDictionary<string, string> buildProperties, ProjectCollection projectCollection, string msbuildOverrideTasksPath);
+        public string DefaultSubToolsetVersion { get; }
+        public IDictionary<string, ProjectPropertyInstance> Properties { get; }
+        public IDictionary<string, SubToolset> SubToolsets { get; }
+        public string ToolsPath { get; private set; }
+        public string ToolsVersion { get; }
+        public string GenerateSubToolsetVersion();
+        public string GenerateSubToolsetVersion(IDictionary<string, string> overrideGlobalProperties, int solutionVersion);
+        public ProjectPropertyInstance GetProperty(string propertyName, string subToolsetVersion);
+    }
+    public enum ToolsetDefinitionLocations {
+        ConfigurationFile = 1,
+        None = 0,
+        Registry = 2,
+    }
+}
```

