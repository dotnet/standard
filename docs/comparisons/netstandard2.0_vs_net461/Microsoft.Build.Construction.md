# Microsoft.Build.Construction

``` diff
+namespace Microsoft.Build.Construction {
+    public abstract class ElementLocation : IElementLocation, IImmutable, INodePacketTranslatable {
+        protected ElementLocation();
+        public abstract int Column { get; }
+        public abstract string File { get; }
+        public abstract int Line { get; }
+        public string LocationString { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public override string ToString();
+    }
+    public class ProjectChooseElement : ProjectElementContainer {
+        public override string Condition { get; set; }
+        public override ElementLocation ConditionLocation { get; }
+        public ProjectOtherwiseElement OtherwiseElement { get; }
+        public ICollection<ProjectWhenElement> WhenElements { get; }
+    }
+    public abstract class ProjectElement {
+        public IEnumerable<ProjectElementContainer> AllParents { get; }
+        public virtual string Condition { get; set; }
+        public virtual ElementLocation ConditionLocation { get; }
+        public ProjectRootElement ContainingProject { get; internal set; }
+        public string Label { get; set; }
+        public ElementLocation LabelLocation { get; }
+        public ElementLocation Location { get; }
+        public ProjectElement NextSibling { get; internal set; }
+        public ProjectElementContainer Parent { get; internal set; }
+        public ProjectElement PreviousSibling { get; internal set; }
+    }
+    public abstract class ProjectElementContainer : ProjectElement {
+        public IEnumerable<ProjectElement> AllChildren { get; }
+        public ICollection<ProjectElement> Children { get; }
+        public ICollection<ProjectElement> ChildrenReversed { get; }
+        public int Count { get; }
+        public ProjectElement FirstChild { get; private set; }
+        public ProjectElement LastChild { get; private set; }
+        public void AppendChild(ProjectElement child);
+        public void InsertAfterChild(ProjectElement child, ProjectElement reference);
+        public void InsertBeforeChild(ProjectElement child, ProjectElement reference);
+        public void PrependChild(ProjectElement child);
+        public void RemoveAllChildren();
+        public void RemoveChild(ProjectElement child);
+    }
+    public class ProjectExtensionsElement : ProjectElement {
+        public override string Condition { get; set; }
+        public override ElementLocation ConditionLocation { get; }
+        public string Content { get; set; }
+        public string this[string name] { get; set; }
+    }
+    public class ProjectImportElement : ProjectElement {
+        public string Project { get; set; }
+        public ElementLocation ProjectLocation { get; }
+    }
+    public class ProjectImportGroupElement : ProjectElementContainer {
+        public ICollection<ProjectImportElement> Imports { get; }
+        public ProjectImportElement AddImport(string project);
+    }
+    public class ProjectItemDefinitionElement : ProjectElementContainer {
+        public string ItemType { get; }
+        public ICollection<ProjectMetadataElement> Metadata { get; }
+        public ProjectMetadataElement AddMetadata(string name, string unevaluatedValue);
+    }
+    public class ProjectItemDefinitionGroupElement : ProjectElementContainer {
+        public ICollection<ProjectItemDefinitionElement> ItemDefinitions { get; }
+        public ProjectItemDefinitionElement AddItemDefinition(string itemType);
+    }
+    public class ProjectItemElement : ProjectElementContainer {
+        public string Exclude { get; set; }
+        public ElementLocation ExcludeLocation { get; }
+        public bool HasMetadata { get; }
+        public string Include { get; set; }
+        public ElementLocation IncludeLocation { get; }
+        public string ItemType { get; set; }
+        public string KeepDuplicates { get; set; }
+        public ElementLocation KeepDuplicatesLocation { get; }
+        public string KeepMetadata { get; set; }
+        public ElementLocation KeepMetadataLocation { get; }
+        public ICollection<ProjectMetadataElement> Metadata { get; }
+        public string Remove { get; set; }
+        public ElementLocation RemoveLocation { get; }
+        public string RemoveMetadata { get; set; }
+        public ElementLocation RemoveMetadataLocation { get; }
+        public ProjectMetadataElement AddMetadata(string name, string unevaluatedValue);
+    }
+    public class ProjectItemGroupElement : ProjectElementContainer {
+        public ICollection<ProjectItemElement> Items { get; }
+        public ProjectItemElement AddItem(string itemType, string include);
+        public ProjectItemElement AddItem(string itemType, string include, IEnumerable<KeyValuePair<string, string>> metadata);
+    }
+    public class ProjectMetadataElement : ProjectElement {
+        public string Name { get; set; }
+        public string Value { get; set; }
+    }
+    public class ProjectOnErrorElement : ProjectElement {
+        public string ExecuteTargetsAttribute { get; set; }
+        public ElementLocation ExecuteTargetsLocation { get; }
+    }
+    public class ProjectOtherwiseElement : ProjectElementContainer {
+        public ICollection<ProjectChooseElement> ChooseElements { get; }
+        public override string Condition { get; set; }
+        public override ElementLocation ConditionLocation { get; }
+        public ICollection<ProjectItemGroupElement> ItemGroups { get; }
+        public ICollection<ProjectPropertyGroupElement> PropertyGroups { get; }
+    }
+    public class ProjectOutputElement : ProjectElement {
+        public bool IsOutputItem { get; }
+        public bool IsOutputProperty { get; }
+        public string ItemType { get; set; }
+        public ElementLocation ItemTypeLocation { get; }
+        public string PropertyName { get; set; }
+        public ElementLocation PropertyNameLocation { get; }
+        public string TaskParameter { get; set; }
+        public ElementLocation TaskParameterLocation { get; }
+    }
+    public class ProjectPropertyElement : ProjectElement {
+        public string Name { get; set; }
+        public string Value { get; set; }
+    }
+    public class ProjectPropertyGroupElement : ProjectElementContainer {
+        public ICollection<ProjectPropertyElement> Properties { get; }
+        public ICollection<ProjectPropertyElement> PropertiesReversed { get; }
+        public ProjectPropertyElement AddProperty(string name, string unevaluatedValue);
+        public ProjectPropertyElement SetProperty(string name, string unevaluatedValue);
+    }
+    public class ProjectRootElement : ProjectElementContainer {
+        public ICollection<ProjectChooseElement> ChooseElements { get; }
+        public override string Condition { get; set; }
+        public override ElementLocation ConditionLocation { get; }
+        public string DefaultTargets { get; set; }
+        public ElementLocation DefaultTargetsLocation { get; }
+        public string DirectoryPath { get; internal set; }
+        public Encoding Encoding { get; }
+        public string FullPath { get; set; }
+        public bool HasUnsavedChanges { get; }
+        public ICollection<ProjectImportGroupElement> ImportGroups { get; }
+        public ICollection<ProjectImportGroupElement> ImportGroupsReversed { get; }
+        public ICollection<ProjectImportElement> Imports { get; }
+        public string InitialTargets { get; set; }
+        public ElementLocation InitialTargetsLocation { get; }
+        public ICollection<ProjectItemDefinitionGroupElement> ItemDefinitionGroups { get; }
+        public ICollection<ProjectItemDefinitionGroupElement> ItemDefinitionGroupsReversed { get; }
+        public ICollection<ProjectItemDefinitionElement> ItemDefinitions { get; }
+        public ICollection<ProjectItemGroupElement> ItemGroups { get; }
+        public ICollection<ProjectItemGroupElement> ItemGroupsReversed { get; }
+        public ICollection<ProjectItemElement> Items { get; }
+        public DateTime LastWriteTimeWhenRead { get; }
+        public ElementLocation ProjectFileLocation { get; }
+        public ICollection<ProjectPropertyElement> Properties { get; }
+        public ICollection<ProjectPropertyGroupElement> PropertyGroups { get; }
+        public ICollection<ProjectPropertyGroupElement> PropertyGroupsReversed { get; }
+        public string RawXml { get; }
+        public ICollection<ProjectTargetElement> Targets { get; }
+        public DateTime TimeLastChanged { get; }
+        public string ToolsVersion { get; set; }
+        public ElementLocation ToolsVersionLocation { get; }
+        public string TreatAsLocalProperty { get; set; }
+        public ElementLocation TreatAsLocalPropertyLocation { get; }
+        public ICollection<ProjectUsingTaskElement> UsingTasks { get; }
+        public int Version { get; }
+        public ProjectImportElement AddImport(string project);
+        public ProjectImportGroupElement AddImportGroup();
+        public ProjectItemElement AddItem(string itemType, string include);
+        public ProjectItemElement AddItem(string itemType, string include, IEnumerable<KeyValuePair<string, string>> metadata);
+        public ProjectItemDefinitionElement AddItemDefinition(string itemType);
+        public ProjectItemDefinitionGroupElement AddItemDefinitionGroup();
+        public ProjectItemGroupElement AddItemGroup();
+        public ProjectPropertyElement AddProperty(string name, string value);
+        public ProjectPropertyGroupElement AddPropertyGroup();
+        public ProjectTargetElement AddTarget(string name);
+        public ProjectUsingTaskElement AddUsingTask(string name, string assemblyFile, string assemblyName);
+        public static ProjectRootElement Create();
+        public static ProjectRootElement Create(ProjectCollection projectCollection);
+        public static ProjectRootElement Create(string path);
+        public static ProjectRootElement Create(string path, ProjectCollection projectCollection);
+        public static ProjectRootElement Create(XmlReader xmlReader);
+        public static ProjectRootElement Create(XmlReader xmlReader, ProjectCollection projectCollection);
+        public ProjectChooseElement CreateChooseElement();
+        public ProjectImportElement CreateImportElement(string project);
+        public ProjectImportGroupElement CreateImportGroupElement();
+        public ProjectItemDefinitionElement CreateItemDefinitionElement(string itemType);
+        public ProjectItemDefinitionGroupElement CreateItemDefinitionGroupElement();
+        public ProjectItemElement CreateItemElement(string itemType);
+        public ProjectItemElement CreateItemElement(string itemType, string include);
+        public ProjectItemGroupElement CreateItemGroupElement();
+        public ProjectMetadataElement CreateMetadataElement(string name);
+        public ProjectMetadataElement CreateMetadataElement(string name, string unevaluatedValue);
+        public ProjectOnErrorElement CreateOnErrorElement(string executeTargets);
+        public ProjectOtherwiseElement CreateOtherwiseElement();
+        public ProjectOutputElement CreateOutputElement(string taskParameter, string itemType, string propertyName);
+        public ProjectExtensionsElement CreateProjectExtensionsElement();
+        public ProjectPropertyElement CreatePropertyElement(string name);
+        public ProjectPropertyGroupElement CreatePropertyGroupElement();
+        public ProjectTargetElement CreateTargetElement(string name);
+        public ProjectTaskElement CreateTaskElement(string name);
+        public ProjectUsingTaskBodyElement CreateUsingTaskBodyElement(string evaluate, string body);
+        public ProjectUsingTaskElement CreateUsingTaskElement(string taskName, string assemblyFile, string assemblyName);
+        public ProjectUsingTaskElement CreateUsingTaskElement(string taskName, string assemblyFile, string assemblyName, string runtime, string architecture);
+        public ProjectUsingTaskParameterElement CreateUsingTaskParameterElement(string name, string output, string required, string parameterType);
+        public UsingTaskParameterGroupElement CreateUsingTaskParameterGroupElement();
+        public ProjectWhenElement CreateWhenElement(string condition);
+        public static ProjectRootElement Open(string path);
+        public static ProjectRootElement Open(string path, ProjectCollection projectCollection);
+        public void Save();
+        public void Save(TextWriter writer);
+        public void Save(string path);
+        public void Save(string path, Encoding encoding);
+        public void Save(Encoding saveEncoding);
+        public static ProjectRootElement TryOpen(string path);
+        public static ProjectRootElement TryOpen(string path, ProjectCollection projectCollection);
+    }
+    public class ProjectTargetElement : ProjectElementContainer {
+        public string AfterTargets { get; set; }
+        public ElementLocation AfterTargetsLocation { get; }
+        public string BeforeTargets { get; set; }
+        public ElementLocation BeforeTargetsLocation { get; }
+        public string DependsOnTargets { get; set; }
+        public ElementLocation DependsOnTargetsLocation { get; }
+        public string Inputs { get; set; }
+        public ElementLocation InputsLocation { get; }
+        public ICollection<ProjectItemGroupElement> ItemGroups { get; }
+        public string KeepDuplicateOutputs { get; set; }
+        public ElementLocation KeepDuplicateOutputsLocation { get; }
+        public string Name { get; set; }
+        public ElementLocation NameLocation { get; }
+        public ICollection<ProjectOnErrorElement> OnErrors { get; }
+        public string Outputs { get; set; }
+        public ElementLocation OutputsLocation { get; }
+        public ICollection<ProjectPropertyGroupElement> PropertyGroups { get; }
+        public string Returns { get; set; }
+        public ElementLocation ReturnsLocation { get; }
+        public ICollection<ProjectTaskElement> Tasks { get; }
+        public ProjectItemGroupElement AddItemGroup();
+        public ProjectPropertyGroupElement AddPropertyGroup();
+        public ProjectTaskElement AddTask(string taskName);
+    }
+    public class ProjectTaskElement : ProjectElementContainer {
+        public string ContinueOnError { get; set; }
+        public ElementLocation ContinueOnErrorLocation { get; }
+        public string MSBuildArchitecture { get; set; }
+        public ElementLocation MSBuildArchitectureLocation { get; }
+        public string MSBuildRuntime { get; set; }
+        public ElementLocation MSBuildRuntimeLocation { get; }
+        public string Name { get; }
+        public ICollection<ProjectOutputElement> Outputs { get; }
+        public IEnumerable<KeyValuePair<string, ElementLocation>> ParameterLocations { get; }
+        public IDictionary<string, string> Parameters { get; }
+        public ProjectOutputElement AddOutputItem(string taskParameter, string itemType);
+        public ProjectOutputElement AddOutputItem(string taskParameter, string itemType, string condition);
+        public ProjectOutputElement AddOutputProperty(string taskParameter, string propertyName);
+        public ProjectOutputElement AddOutputProperty(string taskParameter, string propertyName, string condition);
+        public string GetParameter(string name);
+        public void RemoveAllParameters();
+        public void RemoveParameter(string name);
+        public void SetParameter(string name, string unevaluatedValue);
+    }
+    public class ProjectUsingTaskBodyElement : ProjectElement {
+        public override string Condition { get; set; }
+        public override ElementLocation ConditionLocation { get; }
+        public string Evaluate { get; set; }
+        public ElementLocation EvaluateLocation { get; }
+        public string TaskBody { get; set; }
+    }
+    public class ProjectUsingTaskElement : ProjectElementContainer {
+        public string Architecture { get; set; }
+        public ElementLocation ArchitectureLocation { get; }
+        public string AssemblyFile { get; set; }
+        public ElementLocation AssemblyFileLocation { get; }
+        public string AssemblyName { get; set; }
+        public ElementLocation AssemblyNameLocation { get; }
+        public UsingTaskParameterGroupElement ParameterGroup { get; }
+        public string Runtime { get; set; }
+        public ElementLocation RuntimeLocation { get; }
+        public ProjectUsingTaskBodyElement TaskBody { get; }
+        public string TaskFactory { get; set; }
+        public ElementLocation TaskFactoryLocation { get; }
+        public string TaskName { get; set; }
+        public ElementLocation TaskNameLocation { get; }
+        public UsingTaskParameterGroupElement AddParameterGroup();
+        public ProjectUsingTaskBodyElement AddUsingTaskBody(string evaluate, string taskBody);
+    }
+    public class ProjectUsingTaskParameterElement : ProjectElement {
+        public override string Condition { get; set; }
+        public override ElementLocation ConditionLocation { get; }
+        public string Name { get; set; }
+        public string Output { get; set; }
+        public ElementLocation OutputLocation { get; }
+        public string ParameterType { get; set; }
+        public ElementLocation ParameterTypeLocation { get; }
+        public string Required { get; set; }
+        public ElementLocation RequiredLocation { get; }
+    }
+    public class ProjectWhenElement : ProjectElementContainer {
+        public ICollection<ProjectChooseElement> ChooseElements { get; }
+        public ICollection<ProjectItemGroupElement> ItemGroups { get; }
+        public ICollection<ProjectPropertyGroupElement> PropertyGroups { get; }
+    }
+    public class UsingTaskParameterGroupElement : ProjectElementContainer {
+        public override string Condition { get; set; }
+        public override ElementLocation ConditionLocation { get; }
+        public ICollection<ProjectUsingTaskParameterElement> Parameters { get; }
+        public ProjectUsingTaskParameterElement AddParameter(string name);
+        public ProjectUsingTaskParameterElement AddParameter(string name, string output, string required, string parameterType);
+    }
+}
```

