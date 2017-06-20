# System.Workflow.ComponentModel.Compiler

``` diff
+namespace System.Workflow.ComponentModel.Compiler {
+    public enum AccessTypes {
+        Read = 1,
+        ReadWrite = 3,
+        Write = 2,
+    }
+    public class ActivityCodeGenerator {
+        public ActivityCodeGenerator();
+        public virtual void GenerateCode(CodeGenerationManager manager, object obj);
+        protected CodeTypeDeclaration GetCodeTypeDeclaration(CodeGenerationManager manager, string fullClassName);
+    }
+    public sealed class ActivityCodeGeneratorAttribute : Attribute {
+        public ActivityCodeGeneratorAttribute(string codeGeneratorTypeName);
+        public ActivityCodeGeneratorAttribute(Type codeGeneratorType);
+        public string CodeGeneratorTypeName { get; }
+    }
+    public class ActivityValidator : DependencyObjectValidator {
+        public ActivityValidator();
+        public override ValidationErrorCollection Validate(ValidationManager manager, object obj);
+    }
+    public sealed class ActivityValidatorAttribute : Attribute {
+        public ActivityValidatorAttribute(string validatorTypeName);
+        public ActivityValidatorAttribute(Type validatorType);
+        public string ValidatorTypeName { get; }
+    }
+    public sealed class AttributeInfo {
+        public ReadOnlyCollection<object> ArgumentValues { get; }
+        public Type AttributeType { get; }
+        public bool Creatable { get; }
+        public Attribute CreateAttribute();
+        public object GetArgumentValueAs(IServiceProvider serviceProvider, int argumentIndex, Type requestedType);
+    }
+    public sealed class AttributeInfoAttribute : Attribute {
+        public AttributeInfo AttributeInfo { get; }
+    }
+    public sealed class AuthorizedType {
+        public AuthorizedType();
+        public string Assembly { get; set; }
+        public string Authorized { get; set; }
+        public string Namespace { get; set; }
+        public Regex RegularExpression { get; }
+        public string TypeName { get; set; }
+    }
+    public sealed class BindValidationContext {
+        public BindValidationContext(Type targetType);
+        public BindValidationContext(Type targetType, AccessTypes access);
+        public AccessTypes Access { get; }
+        public Type TargetType { get; }
+    }
+    public sealed class CodeGenerationManager : IServiceProvider {
+        public CodeGenerationManager(IServiceProvider serviceProvider);
+        public ContextStack Context { get; }
+        public ActivityCodeGenerator[] GetCodeGenerators(Type type);
+        public object GetService(Type serviceType);
+    }
+    public sealed class CompileWorkflowCleanupTask : Task, ITask {
+        public CompileWorkflowCleanupTask();
+        public ITaskItem[] TemporaryFiles { get; set; }
+        public override bool Execute();
+    }
+    public sealed class CompileWorkflowTask : Task, ITask {
+        public CompileWorkflowTask();
+        public string AssemblyName { get; set; }
+        public bool BuildingProject { get; set; }
+        public ITaskItem[] CompilationOptions { get; set; }
+        public bool DelaySign { get; set; }
+        public new object HostObject { get; }
+        public string Imports { get; set; }
+        public string KeepTemporaryFiles { get; }
+        public string KeyContainer { get; set; }
+        public string KeyFile { get; set; }
+        ITaskHost Microsoft.Build.Framework.ITask.HostObject { get; set; }
+        public ITaskItem[] OutputFiles { get; }
+        public string ProjectDirectory { get; set; }
+        public string ProjectExtension { get; set; }
+        public ITaskItem[] ReferenceFiles { get; set; }
+        public ITaskItem[] ResourceFiles { get; set; }
+        public string RootNamespace { get; set; }
+        public ITaskItem[] SourceCodeFiles { get; set; }
+        public string TargetFramework { get; set; }
+        public string[] TemporaryFiles { get; }
+        public ITaskItem[] WorkflowMarkupFiles { get; set; }
+        public override bool Execute();
+    }
+    public class CompositeActivityCodeGenerator : ActivityCodeGenerator {
+        public CompositeActivityCodeGenerator();
+        public override void GenerateCode(CodeGenerationManager manager, object obj);
+    }
+    public class CompositeActivityValidator : ActivityValidator {
+        public CompositeActivityValidator();
+        public override ValidationErrorCollection Validate(ValidationManager manager, object obj);
+        public override ValidationError ValidateActivityChange(Activity activity, ActivityChangeAction action);
+    }
+    public class ConditionValidator : DependencyObjectValidator {
+        public ConditionValidator();
+        public override ValidationErrorCollection Validate(ValidationManager manager, object obj);
+    }
+    public class DependencyObjectValidator : Validator {
+        public DependencyObjectValidator();
+        public override ValidationErrorCollection Validate(ValidationManager manager, object obj);
+    }
+    public interface ITypeProvider {
+        Assembly LocalAssembly { get; }
+        ICollection<Assembly> ReferencedAssemblies { get; }
+        IDictionary<object, Exception> TypeLoadErrors { get; }
+        event EventHandler TypeLoadErrorsChanged;
+        event EventHandler TypesChanged;
+        Type GetType(string name);
+        Type GetType(string name, bool throwOnError);
+        Type[] GetTypes();
+    }
+    public interface IWorkflowCompilerOptionsService {
+        bool CheckTypes { get; }
+        string Language { get; }
+        string RootNamespace { get; }
+    }
+    public sealed class PropertyValidationContext {
+        public PropertyValidationContext(object propertyOwner, PropertyInfo propertyInfo, string propertyName);
+        public PropertyValidationContext(object propertyOwner, DependencyProperty dependencyProperty);
+        public object Property { get; }
+        public string PropertyName { get; }
+        public object PropertyOwner { get; }
+    }
+    public sealed class TypeProvider : IDisposable, IServiceProvider, ITypeProvider {
+        public TypeProvider(IServiceProvider serviceProvider);
+        public Func<Type, string> AssemblyNameResolver { get; set; }
+        public Func<PropertyInfo, object, bool> IsSupportedPropertyResolver { get; set; }
+        public Assembly LocalAssembly { get; }
+        public ICollection<Assembly> ReferencedAssemblies { get; }
+        public IDictionary<object, Exception> TypeLoadErrors { get; }
+        public event EventHandler TypeLoadErrorsChanged;
+        public event EventHandler TypesChanged;
+        public void AddAssembly(Assembly assembly);
+        public void AddAssemblyReference(string path);
+        public void AddCodeCompileUnit(CodeCompileUnit codeCompileUnit);
+        public void Dispose();
+        public string GetAssemblyName(Type type);
+        public static string[] GetEnumNames(Type enumType);
+        public static Type GetEventHandlerType(EventInfo eventInfo);
+        public object GetService(Type serviceType);
+        public Type GetType(string name);
+        public Type GetType(string name, bool throwOnError);
+        public Type[] GetTypes();
+        public static bool IsAssignable(Type toType, Type fromType);
+        public static bool IsEnum(Type type);
+        public static bool IsSubclassOf(Type subclass, Type superClass);
+        public bool IsSupportedProperty(PropertyInfo property, object declaringInstance);
+        public void RefreshCodeCompileUnit(CodeCompileUnit codeCompileUnit, EventHandler refresher);
+        public void RemoveAssembly(Assembly assembly);
+        public void RemoveAssemblyReference(string path);
+        public void RemoveCodeCompileUnit(CodeCompileUnit codeCompileUnit);
+        public void SetLocalAssembly(Assembly assembly);
+    }
+    public sealed class ValidationError {
+        public ValidationError(string errorText, int errorNumber);
+        public ValidationError(string errorText, int errorNumber, bool isWarning);
+        public ValidationError(string errorText, int errorNumber, bool isWarning, string propertyName);
+        public int ErrorNumber { get; }
+        public string ErrorText { get; }
+        public bool IsWarning { get; }
+        public string PropertyName { get; set; }
+        public IDictionary UserData { get; }
+        public static ValidationError GetNotSetValidationError(string propertyName);
+        public override string ToString();
+    }
+    public sealed class ValidationErrorCollection : Collection<ValidationError> {
+        public ValidationErrorCollection();
+        public ValidationErrorCollection(IEnumerable<ValidationError> value);
+        public ValidationErrorCollection(ValidationErrorCollection value);
+        public bool HasErrors { get; }
+        public bool HasWarnings { get; }
+        public void AddRange(IEnumerable<ValidationError> value);
+        protected override void InsertItem(int index, ValidationError item);
+        protected override void SetItem(int index, ValidationError item);
+        public ValidationError[] ToArray();
+    }
+    public sealed class ValidationManager : IServiceProvider {
+        public ValidationManager(IServiceProvider serviceProvider);
+        public ValidationManager(IServiceProvider serviceProvider, bool validateChildActivities);
+        public ContextStack Context { get; }
+        public bool ValidateChildActivities { get; }
+        public object GetService(Type serviceType);
+        public Validator[] GetValidators(Type type);
+    }
+    public enum ValidationOption {
+        None = 0,
+        Optional = 1,
+        Required = 2,
+    }
+    public sealed class ValidationOptionAttribute : Attribute {
+        public ValidationOptionAttribute(ValidationOption validationOption);
+        public ValidationOption ValidationOption { get; }
+    }
+    public class Validator {
+        public Validator();
+        protected string GetFullPropertyName(ValidationManager manager);
+        public virtual ValidationErrorCollection Validate(ValidationManager manager, object obj);
+        public virtual ValidationError ValidateActivityChange(Activity activity, ActivityChangeAction action);
+        public virtual ValidationErrorCollection ValidateProperties(ValidationManager manager, object obj);
+        protected internal ValidationErrorCollection ValidateProperty(PropertyInfo propertyInfo, object propertyOwner, object propertyValue, ValidationManager manager);
+    }
+    public sealed class WorkflowCompilationContext {
+        public bool CheckTypes { get; }
+        public static WorkflowCompilationContext Current { get; private set; }
+        public string Language { get; }
+        public string RootNamespace { get; }
+        public static IDisposable CreateScope(IServiceProvider serviceProvider);
+        public IList<AuthorizedType> GetAuthorizedTypes();
+    }
+    public sealed class WorkflowCompiler {
+        public WorkflowCompiler();
+        public WorkflowCompilerResults Compile(WorkflowCompilerParameters parameters, params string[] files);
+    }
+    public sealed class WorkflowCompilerError : CompilerError, IWorkflowCompilerError {
+        public WorkflowCompilerError();
+        public WorkflowCompilerError(string fileName, int line, int column, string errorNumber, string errorText);
+        public WorkflowCompilerError(string fileName, WorkflowMarkupSerializationException exception);
+        public string PropertyName { get; set; }
+        public IDictionary UserData { get; }
+        public override string ToString();
+    }
+    public class WorkflowCompilerOptionsService : IWorkflowCompilerOptionsService {
+        public WorkflowCompilerOptionsService();
+        public virtual bool CheckTypes { get; }
+        public virtual string Language { get; }
+        public virtual string RootNamespace { get; }
+        public virtual string TargetFrameworkMoniker { get; }
+    }
+    public sealed class WorkflowCompilerParameters : CompilerParameters {
+        public WorkflowCompilerParameters();
+        public WorkflowCompilerParameters(string[] assemblyNames);
+        public WorkflowCompilerParameters(string[] assemblyNames, string outputName);
+        public WorkflowCompilerParameters(string[] assemblyNames, string outputName, bool includeDebugInformation);
+        public WorkflowCompilerParameters(WorkflowCompilerParameters parameters);
+        public new string CompilerOptions { get; set; }
+        public bool GenerateCodeCompileUnitOnly { get; set; }
+        public string LanguageToUse { get; set; }
+        public StringCollection LibraryPaths { get; }
+        public IList<CodeCompileUnit> UserCodeCompileUnits { get; }
+    }
+    public sealed class WorkflowCompilerResults : CompilerResults {
+        public CodeCompileUnit CompiledUnit { get; internal set; }
+    }
+    public sealed class WorkflowMarkupSourceAttribute : Attribute {
+        public WorkflowMarkupSourceAttribute(string fileName, string md5Digest);
+        public string FileName { get; }
+        public string MD5Digest { get; }
+    }
+    public sealed class WorkflowValidationFailedException : Exception {
+        public WorkflowValidationFailedException();
+        public WorkflowValidationFailedException(string message);
+        public WorkflowValidationFailedException(string message, Exception innerException);
+        public WorkflowValidationFailedException(string message, ValidationErrorCollection errors);
+        public ValidationErrorCollection Errors { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+}
```

