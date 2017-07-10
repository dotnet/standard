# Microsoft.Build.Tasks.Xaml

``` diff
+namespace Microsoft.Build.Tasks.Xaml {
+    public sealed class AttributeData {
+        public AttributeData();
+        public IList<AttributeParameterData> Parameters { get; }
+        public IDictionary<string, AttributeParameterData> Properties { get; }
+        public XamlType Type { get; set; }
+    }
+    public sealed class AttributeParameterData {
+        public AttributeParameterData(XamlType type, IEnumerable<AttributeParameterData> arrayContents);
+        public AttributeParameterData(XamlType type, object value);
+        public AttributeParameterData(XamlType type, string textValue);
+        public ReadOnlyCollection<AttributeParameterData> ArrayContents { get; }
+        public string TextValue { get; internal set; }
+        public XamlType Type { get; internal set; }
+        public object Value { get; internal set; }
+    }
+    public class BuildExtensionContext {
+        public string AssemblyName { get; internal set; }
+        public ReadOnlyCollection<string> GeneratedFiles { get; }
+        public ReadOnlyCollection<string> GeneratedResourceFiles { get; }
+        public bool IsInProcessXamlMarkupCompile { get; internal set; }
+        public string Language { get; internal set; }
+        public string LocalAssembly { get; internal set; }
+        public string OutputPath { get; internal set; }
+        public ReadOnlyCollection<string> References { get; }
+        public string RootNamespace { get; internal set; }
+        public ReadOnlyCollection<string> SourceCodeFiles { get; }
+        public TaskLoggingHelper XamlBuildLogger { get; internal set; }
+        public void AddGeneratedFile(string fileName);
+        public void AddGeneratedResourceFile(string fileName);
+    }
+    public class ClassData {
+        public ClassData();
+        public IList<AttributeData> Attributes { get; }
+        public XamlType BaseType { get; set; }
+        public IList<string> CodeSnippets { get; }
+        public string EmbeddedResourceFileName { get; internal set; }
+        public XamlNodeList EmbeddedResourceXaml { get; set; }
+        public string FileName { get; internal set; }
+        public string HelperClassFullName { get; internal set; }
+        public bool IsPublic { get; set; }
+        public string Name { get; internal set; }
+        public IList<NamedObject> NamedObjects { get; }
+        public string Namespace { get; internal set; }
+        public KeyedCollection<string, PropertyData> Properties { get; }
+    }
+    public class CommandLineArgumentRelation : PropertyRelation {
+        public CommandLineArgumentRelation(string argument, string value, bool required, string separator);
+        public string Separator { get; set; }
+    }
+    public class CommandLineGenerator {
+        public CommandLineGenerator(Rule rule, Dictionary<string, object> parameterValues);
+        public string AdditionalOptions { get; set; }
+        public string AlwaysAppend { get; set; }
+        public string CommandLineTemplate { get; set; }
+        public string GenerateCommandLine();
+    }
+    public class CommandLineToolSwitch {
+        public CommandLineToolSwitch();
+        public CommandLineToolSwitch(CommandLineToolSwitchType toolType);
+        public bool AllowMultipleValues { get; set; }
+        public bool ArgumentRequired { get; set; }
+        public ICollection<Tuple<string, bool>> Arguments { get; set; }
+        public bool BooleanValue { get; set; }
+        public string Description { get; set; }
+        public string DisplayName { get; set; }
+        public string FallbackArgumentParameter { get; set; }
+        public string FalseSuffix { get; set; }
+        public bool IncludeInCommandLine { get; set; }
+        public bool IsValid { get; set; }
+        public string Name { get; set; }
+        public int Number { get; set; }
+        public LinkedList<KeyValuePair<string, string>> Overrides { get; }
+        public LinkedList<string> Parents { get; }
+        public bool Required { get; set; }
+        public string ReverseSwitchValue { get; set; }
+        public bool Reversible { get; set; }
+        public string Separator { get; set; }
+        public string[] StringList { get; set; }
+        public string SwitchValue { get; set; }
+        public ITaskItem[] TaskItemArray { get; set; }
+        public string TrueSuffix { get; set; }
+        public CommandLineToolSwitchType Type { get; set; }
+        public string Value { get; set; }
+    }
+    public enum CommandLineToolSwitchType {
+        Boolean = 0,
+        Integer = 1,
+        ITaskItemArray = 4,
+        String = 2,
+        StringArray = 3,
+    }
+    public class CompilationPass2Task : Task {
+        public CompilationPass2Task();
+        public ITaskItem[] ApplicationMarkup { get; set; }
+        public ITaskItem[] ApplicationMarkupWithTypeName { get; set; }
+        public string AssemblyName { get; set; }
+        public string BuildTaskPath { get; set; }
+        public ITaskItem[] ExtensionGeneratedCodeFiles { get; set; }
+        public bool IsInProcessXamlMarkupCompile { get; set; }
+        public string Language { get; set; }
+        public string LocalAssemblyReference { get; set; }
+        public string MSBuildProjectDirectory { get; set; }
+        public string OutputPath { get; set; }
+        public ITaskItem[] References { get; set; }
+        public string RootNamespace { get; set; }
+        public ITaskItem[] SourceCodeFiles { get; set; }
+        public ITaskItem[] XamlBuildTypeInspectionExtensionNames { get; set; }
+        public override bool Execute();
+    }
+    public class GenerateTemporaryAssemblyTask : Task {
+        public GenerateTemporaryAssemblyTask();
+        public string ApplicationMarkupTypeName { get; set; }
+        public string AssemblyName { get; set; }
+        public string CompileTargetName { get; set; }
+        public string CurrentProject { get; set; }
+        public ITaskItem[] GeneratedResourcesFiles { get; set; }
+        public string OutputPath { get; set; }
+        public ITaskItem[] ReferencePaths { get; set; }
+        public ITaskItem[] SourceCodeFiles { get; set; }
+        public override bool Execute();
+    }
+    public interface IXamlBuildTypeGenerationExtension {
+        bool Execute(ClassData classData, XamlBuildTypeGenerationExtensionContext buildContext);
+    }
+    public interface IXamlBuildTypeInspectionExtension {
+        bool Execute(XamlBuildTypeInspectionExtensionContext buildContext);
+    }
+    public enum MemberVisibility {
+        Assembly = 3,
+        Family = 2,
+        FamilyAndAssembly = 5,
+        FamilyOrAssembly = 4,
+        Private = 1,
+        Public = 0,
+    }
+    public class NamedObject {
+        public NamedObject();
+        public string Name { get; set; }
+        public XamlType Type { get; set; }
+        public MemberVisibility Visibility { get; set; }
+    }
+    public class PartialClassGenerationTask : Task {
+        public PartialClassGenerationTask();
+        public ITaskItem[] ApplicationMarkup { get; set; }
+        public string AssemblyName { get; set; }
+        public string BuildTaskPath { get; set; }
+        public ITaskItem[] GeneratedCodeFiles { get; set; }
+        public ITaskItem[] GeneratedResources { get; set; }
+        public string GeneratedSourceExtension { get; set; }
+        public bool IsInProcessXamlMarkupCompile { get; set; }
+        public string[] KnownReferencePaths { get; set; }
+        public string Language { get; set; }
+        public string MSBuildProjectDirectory { get; set; }
+        public string OutputPath { get; set; }
+        public ITaskItem[] References { get; set; }
+        public bool RequiresCompilationPass2 { get; set; }
+        public string RootNamespace { get; set; }
+        public ITaskItem[] SourceCodeFiles { get; set; }
+        public ITaskItem[] XamlBuildTypeGenerationExtensionNames { get; set; }
+        public ITaskItem[] XamlBuildTypeInspectionExtensionNames { get; set; }
+        public override bool Execute();
+    }
+    public sealed class PropertyData {
+        public PropertyData();
+        public IList<AttributeData> Attributes { get; }
+        public string Name { get; set; }
+        public XamlType Type { get; set; }
+        public MemberVisibility Visibility { get; set; }
+    }
+    public class PropertyRelation {
+        public PropertyRelation();
+        public PropertyRelation(string argument, string value, bool required);
+        public string Argument { get; set; }
+        public bool Required { get; set; }
+        public string Value { get; set; }
+    }
+    public sealed class XamlBuildTypeGenerationExtensionContext : BuildExtensionContext {
+        public XamlBuildTypeGenerationExtensionContext();
+        public ITaskItem InputTaskItem { get; internal set; }
+    }
+    public sealed class XamlBuildTypeInspectionExtensionContext : BuildExtensionContext {
+        public XamlBuildTypeInspectionExtensionContext();
+        public IDictionary<string, ITaskItem> MarkupItemsByTypeName { get; }
+    }
+    public abstract class XamlDataDrivenToolTask : ToolTask {
+        protected XamlDataDrivenToolTask(string[] switchOrderList, ResourceManager taskResources);
+        public virtual string[] AcceptableNonZeroExitCodes { get; set; }
+        protected internal Dictionary<string, CommandLineToolSwitch> ActiveToolSwitches { get; }
+        public Dictionary<string, CommandLineToolSwitch> ActiveToolSwitchesValues { get; set; }
+        public string AdditionalOptions { get; set; }
+        public string CommandLineTemplate { get; set; }
+        protected override Encoding ResponseFileEncoding { get; }
+        public void AddActiveSwitchToolValue(CommandLineToolSwitch switchToAdd);
+        public string CreateSwitchValue(string propertyName, string baseSwitch, string separator, Tuple<string, bool>[] arguments);
+        public override bool Execute();
+        protected override string GenerateCommandLineCommands();
+        protected override string GenerateFullPathToTool();
+        protected override string GenerateResponseFileCommands();
+        protected override bool HandleTaskExecutionErrors();
+        public bool IsPropertySet(string propertyName);
+        public string ReadSwitchMap(string propertyName, string[][] switchMap, string value);
+        public int ReadSwitchMap2(string propertyName, Tuple<string, string, Tuple<string, bool>[]>[] switchMap, string value);
+        public void ReplaceToolSwitch(CommandLineToolSwitch switchToAdd);
+        public bool ValidateInteger(string switchName, int min, int max, int value);
+        protected override bool ValidateParameters();
+    }
+}
```

