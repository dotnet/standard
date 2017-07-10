# System.Activities.XamlIntegration

``` diff
+namespace System.Activities.XamlIntegration {
+    public sealed class ActivityWithResultConverter : TypeConverterBase {
+        public ActivityWithResultConverter();
+        public ActivityWithResultConverter(Type type);
+    }
+    public sealed class ActivityWithResultValueSerializer : ValueSerializer {
+        public ActivityWithResultValueSerializer();
+        public override bool CanConvertToString(object value, IValueSerializerContext context);
+        public override string ConvertToString(object value, IValueSerializerContext context);
+    }
+    public static class ActivityXamlServices {
+        public static XamlReader CreateBuilderReader(XamlReader innerReader);
+        public static XamlReader CreateBuilderReader(XamlReader innerReader, XamlSchemaContext schemaContext);
+        public static XamlWriter CreateBuilderWriter(XamlWriter innerWriter);
+        public static Func<object> CreateFactory(XamlReader reader, Type resultType);
+        public static Func<T> CreateFactory<T>(XamlReader reader) where T : class;
+        public static XamlReader CreateReader(Stream stream);
+        public static XamlReader CreateReader(XamlReader innerReader);
+        public static XamlReader CreateReader(XamlReader innerReader, XamlSchemaContext schemaContext);
+        public static void InitializeComponent(Type componentType, object componentInstance);
+        public static Activity Load(Stream stream);
+        public static Activity Load(Stream stream, ActivityXamlServicesSettings settings);
+        public static Activity Load(TextReader textReader);
+        public static Activity Load(TextReader textReader, ActivityXamlServicesSettings settings);
+        public static Activity Load(string fileName);
+        public static Activity Load(string fileName, ActivityXamlServicesSettings settings);
+        public static Activity Load(XamlReader xamlReader);
+        public static Activity Load(XamlReader xamlReader, ActivityXamlServicesSettings settings);
+        public static Activity Load(XmlReader xmlReader);
+        public static Activity Load(XmlReader xmlReader, ActivityXamlServicesSettings settings);
+    }
+    public class ActivityXamlServicesSettings {
+        public ActivityXamlServicesSettings();
+        public bool CompileExpressions { get; set; }
+        public LocationReferenceEnvironment LocationReferenceEnvironment { get; set; }
+    }
+    public class ArgumentValueSerializer : ValueSerializer {
+        public ArgumentValueSerializer();
+        public override bool CanConvertToString(object value, IValueSerializerContext context);
+        public override string ConvertToString(object value, IValueSerializerContext context);
+    }
+    public class AssemblyReferenceConverter : TypeConverter {
+        public AssemblyReferenceConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public abstract class CompiledDataContext {
+        protected CompiledDataContext(IList<Location> locations);
+        protected CompiledDataContext(IList<LocationReference> locationReferences);
+        protected CompiledDataContext(IList<LocationReference> locationReferences, ActivityContext activityContext);
+        protected static CompiledDataContext[] GetCompiledDataContextCache(object dataContextActivities, ActivityContext activityContext, Activity compiledRoot, bool forImplementation, int compiledDataContextCount);
+        protected static object GetDataContextActivities(Activity compiledRoot, bool forImplementation);
+        public Location<T> GetLocation<T>(Func<T> getMethod, Action<T> setMethod);
+        public Location<T> GetLocation<T>(Func<T> getMethod, Action<T> setMethod, int expressionId, Activity compiledRootActivity, ActivityContext activityContext);
+        protected virtual void GetValueTypeValues();
+        protected object GetVariableValue(int index);
+        protected Expression RewriteExpressionTree(Expression originalExpression);
+        protected virtual void SetValueTypeValues();
+        protected void SetVariableValue(int index, object value);
+    }
+    public class DynamicUpdateMapConverter : TypeConverter {
+        public DynamicUpdateMapConverter();
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public class DynamicUpdateMapExtension : MarkupExtension {
+        public DynamicUpdateMapExtension();
+        public DynamicUpdateMapExtension(DynamicUpdateMap updateMap);
+        public DynamicUpdateMap UpdateMap { get; }
+        public IXmlSerializable XmlContent { get; }
+        public override object ProvideValue(IServiceProvider serviceProvider);
+    }
+    public class DynamicUpdateMapItemConverter : TypeConverter {
+        public DynamicUpdateMapItemConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public class FuncDeferringLoader : XamlDeferringLoader {
+        public FuncDeferringLoader();
+        public override object Load(XamlReader xamlReader, IServiceProvider context);
+        public override XamlReader Save(object value, IServiceProvider serviceProvider);
+    }
+    public interface ICompiledExpressionRoot {
+        bool CanExecuteExpression(string expressionText, bool isReference, IList<LocationReference> locations, out int expressionId);
+        Expression GetExpressionTreeForExpression(int expressionId, IList<LocationReference> locationReferences);
+        string GetLanguage();
+        IList<string> GetRequiredLocations(int expressionId);
+        object InvokeExpression(int expressionId, IList<Location> locations);
+        object InvokeExpression(int expressionId, IList<LocationReference> locations, ActivityContext activityContext);
+    }
+    public class ImplementationVersionConverter : TypeConverter {
+        public ImplementationVersionConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public sealed class InArgumentConverter : TypeConverterBase {
+        public InArgumentConverter();
+        public InArgumentConverter(Type type);
+    }
+    public sealed class InOutArgumentConverter : TypeConverterBase {
+        public InOutArgumentConverter();
+        public InOutArgumentConverter(Type type);
+    }
+    public interface IValueSerializableExpression {
+        bool CanConvertToString(IValueSerializerContext context);
+        string ConvertToString(IValueSerializerContext context);
+    }
+    public sealed class OutArgumentConverter : TypeConverterBase {
+        public OutArgumentConverter();
+        public OutArgumentConverter(Type type);
+    }
+    public sealed class PropertyReferenceExtension<T> : MarkupExtension {
+        public PropertyReferenceExtension();
+        public string PropertyName { get; set; }
+        public override object ProvideValue(IServiceProvider serviceProvider);
+    }
+    public class SerializableFuncDeferringLoader : XamlDeferringLoader {
+        public SerializableFuncDeferringLoader();
+        public override object Load(XamlReader xamlReader, IServiceProvider context);
+        public override XamlReader Save(object value, IServiceProvider serviceProvider);
+    }
+    public class TextExpressionCompiler {
+        public TextExpressionCompiler(TextExpressionCompilerSettings settings);
+        public TextExpressionCompilerResults Compile();
+        public bool GenerateSource(TextWriter textWriter);
+    }
+    public class TextExpressionCompilerError {
+        public bool IsWarning { get; internal set; }
+        public string Message { get; internal set; }
+        public string Number { get; internal set; }
+        public int SourceLineNumber { get; internal set; }
+    }
+    public class TextExpressionCompilerResults {
+        public ReadOnlyCollection<TextExpressionCompilerError> CompilerMessages { get; }
+        public bool HasErrors { get; internal set; }
+        public bool HasSourceInfo { get; internal set; }
+        public Type ResultType { get; internal set; }
+    }
+    public class TextExpressionCompilerSettings {
+        public TextExpressionCompilerSettings();
+        public Activity Activity { get; set; }
+        public string ActivityName { get; set; }
+        public string ActivityNamespace { get; set; }
+        public bool AlwaysGenerateSource { get; set; }
+        public bool ForImplementation { get; set; }
+        public bool GenerateAsPartialClass { get; set; }
+        public string Language { get; set; }
+        public Action<string> LogSourceGenerationMessage { get; set; }
+        public string RootNamespace { get; set; }
+    }
+    public abstract class TypeConverterBase : TypeConverter {
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
+    }
+    public class WorkflowIdentityConverter : TypeConverter {
+        public WorkflowIdentityConverter();
+        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
+        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
+    }
+}
```

