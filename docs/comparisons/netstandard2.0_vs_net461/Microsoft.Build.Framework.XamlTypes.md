# Microsoft.Build.Framework.XamlTypes

``` diff
+namespace Microsoft.Build.Framework.XamlTypes {
+    public sealed class Argument : ISupportInitialize {
+        public Argument();
+        public bool IsRequired { get; set; }
+        public string Property { get; set; }
+        public string Separator { get; set; }
+        public void BeginInit();
+        public void EndInit();
+    }
+    public abstract class BaseProperty : ISupportInitialize {
+        protected BaseProperty();
+        public List<Argument> Arguments { get; set; }
+        public string Category { get; set; }
+        public Rule ContainingRule { get; internal set; }
+        public DataSource DataSource { get; set; }
+        public string Default { get; set; }
+        public string Description { get; set; }
+        public string DisplayName { get; set; }
+        public string F1Keyword { get; set; }
+        public int HelpContext { get; set; }
+        public string HelpFile { get; set; }
+        public string HelpUrl { get; set; }
+        public bool IncludeInCommandLine { get; set; }
+        public bool IsRequired { get; set; }
+        public List<NameValuePair> Metadata { get; set; }
+        public bool MultipleValuesAllowed { get; set; }
+        public string Name { get; set; }
+        public bool ReadOnly { get; set; }
+        public string Separator { get; set; }
+        public string Subcategory { get; set; }
+        public string Switch { get; set; }
+        public string SwitchPrefix { get; set; }
+        public List<ValueEditor> ValueEditors { get; set; }
+        public bool Visible { get; set; }
+        public virtual void BeginInit();
+        public virtual void EndInit();
+    }
+    public sealed class BoolProperty : BaseProperty {
+        public BoolProperty();
+        public string ReverseSwitch { get; set; }
+    }
+    public sealed class Category : CategorySchema, ISupportInitialize {
+        public Category();
+        public string Description { get; set; }
+        public string DisplayName { get; set; }
+        public string HelpString { get; set; }
+        public string Name { get; set; }
+        public string Subtype { get; set; }
+        public void BeginInit();
+        public void EndInit();
+    }
+    public abstract class CategorySchema {
+        protected CategorySchema();
+    }
+    public sealed class ContentType : IProjectSchemaNode, ISupportInitialize {
+        public ContentType();
+        public bool DefaultContentTypeForItemType { get; set; }
+        public string DisplayName { get; set; }
+        public string ItemGroupName { get; set; }
+        public string ItemType { get; set; }
+        public List<NameValuePair> Metadata { get; set; }
+        public string Name { get; set; }
+        public void BeginInit();
+        public void EndInit();
+        public string GetMetadata(string metadataName);
+        public IEnumerable<object> GetSchemaObjects(Type type);
+        public IEnumerable<Type> GetSchemaObjectTypes();
+    }
+    public sealed class DataSource : ISupportInitialize {
+        public DataSource();
+        public bool HasConfigurationCondition { get; set; }
+        public string ItemType { get; set; }
+        public string Label { get; set; }
+        public string MSBuildTarget { get; set; }
+        public string PersistedName { get; set; }
+        public string Persistence { get; set; }
+        public DefaultValueSourceLocation SourceOfDefaultValue { get; set; }
+        public string SourceType { get; set; }
+        public void BeginInit();
+        public void EndInit();
+    }
+    public enum DefaultValueSourceLocation {
+        AfterContext = 1,
+        BeforeContext = 0,
+    }
+    public sealed class DynamicEnumProperty : BaseProperty {
+        public DynamicEnumProperty();
+        public string EnumProvider { get; set; }
+        public List<NameValuePair> ProviderSettings { get; set; }
+    }
+    public sealed class EnumProperty : BaseProperty {
+        public EnumProperty();
+        public List<EnumValue> AdmissibleValues { get; set; }
+        public override void EndInit();
+    }
+    public sealed class EnumValue {
+        public EnumValue();
+        public List<Argument> Arguments { get; set; }
+        public string Description { get; set; }
+        public string DisplayName { get; set; }
+        public string HelpString { get; set; }
+        public bool IsDefault { get; set; }
+        public List<NameValuePair> Metadata { get; set; }
+        public string Name { get; set; }
+        public string Switch { get; set; }
+        public string SwitchPrefix { get; set; }
+    }
+    public sealed class FileExtension : IProjectSchemaNode {
+        public FileExtension();
+        public string ContentType { get; set; }
+        public string Name { get; set; }
+        public IEnumerable<object> GetSchemaObjects(Type type);
+        public IEnumerable<Type> GetSchemaObjectTypes();
+    }
+    public sealed class IntProperty : BaseProperty {
+        public IntProperty();
+        public Nullable<int> MaxValue { get; set; }
+        public Nullable<int> MinValue { get; set; }
+        public override void EndInit();
+    }
+    public interface IProjectSchemaNode {
+        IEnumerable<object> GetSchemaObjects(Type type);
+        IEnumerable<Type> GetSchemaObjectTypes();
+    }
+    public sealed class ItemType : IProjectSchemaNode, ISupportInitialize {
+        public ItemType();
+        public string DefaultContentType { get; set; }
+        public string DisplayName { get; set; }
+        public string Name { get; set; }
+        public bool UpToDateCheckInput { get; set; }
+        public void BeginInit();
+        public void EndInit();
+        public IEnumerable<object> GetSchemaObjects(Type type);
+        public IEnumerable<Type> GetSchemaObjectTypes();
+    }
+    public class NameValuePair {
+        public NameValuePair();
+        public string Name { get; set; }
+        public string Value { get; set; }
+    }
+    public sealed class ProjectSchemaDefinitions : IProjectSchemaNode {
+        public ProjectSchemaDefinitions();
+        public List<IProjectSchemaNode> Nodes { get; set; }
+        public IEnumerable<object> GetSchemaObjects(Type type);
+        public IEnumerable<Type> GetSchemaObjectTypes();
+    }
+    public sealed class Rule : RuleSchema, IProjectSchemaNode, ISupportInitialize {
+        public Rule();
+        public string AdditionalInputs { get; set; }
+        public List<Category> Categories { get; set; }
+        public string CommandLine { get; set; }
+        public DataSource DataSource { get; set; }
+        public string Description { get; set; }
+        public string DisplayName { get; set; }
+        public List<Category> EvaluatedCategories { get; }
+        public string ExecutionDescription { get; set; }
+        public string FileExtension { get; set; }
+        public string HelpString { get; set; }
+        public Dictionary<string, object> Metadata { get; set; }
+        public string Name { get; set; }
+        public int Order { get; set; }
+        public string Outputs { get; set; }
+        public RuleOverrideMode OverrideMode { get; set; }
+        public string PageTemplate { get; set; }
+        public List<BaseProperty> Properties { get; set; }
+        public bool PropertyPagesHidden { get; set; }
+        public string Separator { get; set; }
+        public bool ShowOnlyRuleProperties { get; set; }
+        public bool SupportsFileBatching { get; set; }
+        public string SwitchPrefix { get; set; }
+        public string ToolName { get; set; }
+        public void BeginInit();
+        public void EndInit();
+        public OrderedDictionary GetPropertiesByCategory();
+        public IList<BaseProperty> GetPropertiesInCategory(string categoryName);
+        public BaseProperty GetProperty(string propertyName);
+        public IEnumerable<object> GetSchemaObjects(Type type);
+        public IEnumerable<Type> GetSchemaObjectTypes();
+    }
+    public sealed class RuleBag : IProjectSchemaNode, ISupportInitialize {
+        public RuleBag();
+        public List<Rule> Rules { get; set; }
+        public void BeginInit();
+        public void EndInit();
+        public IEnumerable<object> GetSchemaObjects(Type type);
+        public IEnumerable<Type> GetSchemaObjectTypes();
+    }
+    public enum RuleOverrideMode {
+        Extend = 1,
+        Replace = 0,
+    }
+    public abstract class RuleSchema {
+        protected RuleSchema();
+    }
+    public sealed class StringListProperty : BaseProperty {
+        public StringListProperty();
+        public string CommandLineValueSeparator { get; set; }
+        public string RendererValueSeparator { get; set; }
+        public string Subtype { get; set; }
+    }
+    public sealed class StringProperty : BaseProperty {
+        public StringProperty();
+        public string Subtype { get; set; }
+    }
+    public sealed class ValueEditor : ISupportInitialize {
+        public ValueEditor();
+        public string DisplayName { get; set; }
+        public string EditorType { get; set; }
+        public List<NameValuePair> Metadata { get; set; }
+        public void BeginInit();
+        public void EndInit();
+    }
+}
```

