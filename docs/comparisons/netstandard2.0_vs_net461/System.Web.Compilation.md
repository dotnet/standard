# System.Web.Compilation

``` diff
+namespace System.Web.Compilation {
+    public class AppSettingsExpressionBuilder : ExpressionBuilder {
+        public AppSettingsExpressionBuilder();
+        public override bool SupportsEvaluate { get; }
+        public override object EvaluateExpression(object target, BoundPropertyEntry entry, object parsedData, ExpressionBuilderContext context);
+        public static object GetAppSetting(string key);
+        public static object GetAppSetting(string key, Type targetType, string propertyName);
+        public override CodeExpression GetCodeExpression(BoundPropertyEntry entry, object parsedData, ExpressionBuilderContext context);
+    }
+    public class AssemblyBuilder {
+        public CodeDomProvider CodeDomProvider { get; }
+        public void AddAssemblyReference(Assembly a);
+        public void AddCodeCompileUnit(BuildProvider buildProvider, CodeCompileUnit compileUnit);
+        public TextWriter CreateCodeFile(BuildProvider buildProvider);
+        public Stream CreateEmbeddedResource(BuildProvider buildProvider, string name);
+        public void GenerateTypeFactory(string typeName);
+        public string GetTempFilePhysicalPath(string extension);
+    }
+    public sealed class BuildDependencySet {
+        public string HashCode { get; }
+        public IEnumerable VirtualPaths { get; }
+    }
+    public sealed class BuildManager {
+        public static Nullable<bool> BatchCompilationEnabled { get; set; }
+        public static IList CodeAssemblies { get; }
+        public static bool IsPrecompiledApp { get; }
+        public static bool IsUpdatablePrecompiledApp { get; }
+        public static FrameworkName TargetFramework { get; }
+        public static void AddCompilationDependency(string dependency);
+        public static void AddReferencedAssembly(Assembly assembly);
+        public static Stream CreateCachedFile(string fileName);
+        public static object CreateInstanceFromVirtualPath(string virtualPath, Type requiredBaseType);
+        public static BuildDependencySet GetCachedBuildDependencySet(HttpContext context, string virtualPath);
+        public static BuildDependencySet GetCachedBuildDependencySet(HttpContext context, string virtualPath, bool ensureIsUpToDate);
+        public static Assembly GetCompiledAssembly(string virtualPath);
+        public static string GetCompiledCustomString(string virtualPath);
+        public static Type GetCompiledType(string virtualPath);
+        public static Type GetGlobalAsaxType();
+        public static IWebObjectFactory GetObjectFactory(string virtualPath, bool throwIfNotFound);
+        public static ICollection GetReferencedAssemblies();
+        public static Type GetType(string typeName, bool throwOnError);
+        public static Type GetType(string typeName, bool throwOnError, bool ignoreCase);
+        public static ICollection GetVirtualPathDependencies(string virtualPath);
+        public static Stream ReadCachedFile(string fileName);
+    }
+    public class BuildManagerHostUnloadEventArgs : EventArgs {
+        public BuildManagerHostUnloadEventArgs(ApplicationShutdownReason reason);
+        public ApplicationShutdownReason Reason { get; }
+    }
+    public delegate void BuildManagerHostUnloadEventHandler(object sender, BuildManagerHostUnloadEventArgs e);
+    public abstract class BuildProvider {
+        protected BuildProvider();
+        public virtual CompilerType CodeCompilerType { get; }
+        protected ICollection ReferencedAssemblies { get; }
+        protected internal string VirtualPath { get; }
+        public virtual ICollection VirtualPathDependencies { get; }
+        public virtual void GenerateCode(AssemblyBuilder assemblyBuilder);
+        protected internal virtual CodeCompileUnit GetCodeCompileUnit(out IDictionary linePragmasTable);
+        public virtual string GetCustomString(CompilerResults results);
+        protected CompilerType GetDefaultCompilerType();
+        protected CompilerType GetDefaultCompilerTypeForLanguage(string language);
+        public virtual Type GetGeneratedType(CompilerResults results);
+        public virtual BuildProviderResultFlags GetResultFlags(CompilerResults results);
+        protected TextReader OpenReader();
+        protected TextReader OpenReader(string virtualPath);
+        protected Stream OpenStream();
+        protected Stream OpenStream(string virtualPath);
+        public virtual void ProcessCompileErrors(CompilerResults results);
+        public static void RegisterBuildProvider(string extension, Type providerType);
+    }
+    public enum BuildProviderAppliesTo {
+        All = 7,
+        Code = 2,
+        Resources = 4,
+        Web = 1,
+    }
+    public sealed class BuildProviderAppliesToAttribute : Attribute {
+        public BuildProviderAppliesToAttribute(BuildProviderAppliesTo appliesTo);
+        public BuildProviderAppliesTo AppliesTo { get; }
+    }
+    public enum BuildProviderResultFlags {
+        Default = 0,
+        ShutdownAppDomainOnChange = 1,
+    }
+    public sealed class ClientBuildManager : MarshalByRefObject, IDisposable {
+        public ClientBuildManager(string appVirtualDir, string appPhysicalSourceDir);
+        public ClientBuildManager(string appVirtualDir, string appPhysicalSourceDir, string appPhysicalTargetDir);
+        public ClientBuildManager(string appVirtualDir, string appPhysicalSourceDir, string appPhysicalTargetDir, ClientBuildManagerParameter parameter);
+        public ClientBuildManager(string appVirtualDir, string appPhysicalSourceDir, string appPhysicalTargetDir, ClientBuildManagerParameter parameter, TypeDescriptionProvider typeDescriptionProvider);
+        public string CodeGenDir { get; }
+        public bool IsHostCreated { get; }
+        public event BuildManagerHostUnloadEventHandler AppDomainShutdown;
+        public event EventHandler AppDomainStarted;
+        public event BuildManagerHostUnloadEventHandler AppDomainUnloaded;
+        public void CompileApplicationDependencies();
+        public void CompileFile(string virtualPath);
+        public void CompileFile(string virtualPath, ClientBuildManagerCallback callback);
+        public IRegisteredObject CreateObject(Type type, bool failIfExists);
+        public string GenerateCode(string virtualPath, string virtualFileString, out IDictionary linePragmasTable);
+        public CodeCompileUnit GenerateCodeCompileUnit(string virtualPath, string virtualFileString, out Type codeDomProviderType, out CompilerParameters compilerParameters, out IDictionary linePragmasTable);
+        public CodeCompileUnit GenerateCodeCompileUnit(string virtualPath, out Type codeDomProviderType, out CompilerParameters compilerParameters, out IDictionary linePragmasTable);
+        public string[] GetAppDomainShutdownDirectories();
+        public IDictionary GetBrowserDefinitions();
+        public void GetCodeDirectoryInformation(string virtualCodeDir, out Type codeDomProviderType, out CompilerParameters compilerParameters, out string generatedFilesDir);
+        public Type GetCompiledType(string virtualPath);
+        public void GetCompilerParameters(string virtualPath, out Type codeDomProviderType, out CompilerParameters compilerParameters);
+        public string GetGeneratedFileVirtualPath(string filePath);
+        public string GetGeneratedSourceFile(string virtualPath);
+        public string[] GetTopLevelAssemblyReferences(string virtualPath);
+        public string[] GetVirtualCodeDirectories();
+        public override object InitializeLifetimeService();
+        public bool IsCodeAssembly(string assemblyName);
+        public void PrecompileApplication();
+        public void PrecompileApplication(ClientBuildManagerCallback callback);
+        public void PrecompileApplication(ClientBuildManagerCallback callback, bool forceCleanBuild);
+        void System.IDisposable.Dispose();
+        public bool Unload();
+    }
+    public class ClientBuildManagerCallback : MarshalByRefObject {
+        public ClientBuildManagerCallback();
+        public override object InitializeLifetimeService();
+        public virtual void ReportCompilerError(CompilerError error);
+        public virtual void ReportParseError(ParserError error);
+        public virtual void ReportProgress(string message);
+    }
+    public class ClientBuildManagerParameter {
+        public ClientBuildManagerParameter();
+        public List<string> ExcludedVirtualPaths { get; }
+        public PrecompilationFlags PrecompilationFlags { get; set; }
+        public string StrongNameKeyContainer { get; set; }
+        public string StrongNameKeyFile { get; set; }
+    }
+    public sealed class CompilerType {
+        public Type CodeDomProviderType { get; }
+        public CompilerParameters CompilerParameters { get; }
+        public override bool Equals(object o);
+        public override int GetHashCode();
+    }
+    public class ConnectionStringsExpressionBuilder : ExpressionBuilder {
+        public ConnectionStringsExpressionBuilder();
+        public override bool SupportsEvaluate { get; }
+        public override object EvaluateExpression(object target, BoundPropertyEntry entry, object parsedData, ExpressionBuilderContext context);
+        public override CodeExpression GetCodeExpression(BoundPropertyEntry entry, object parsedData, ExpressionBuilderContext context);
+        public static string GetConnectionString(string connectionStringName);
+        public static string GetConnectionStringProviderName(string connectionStringName);
+        public override object ParseExpression(string expression, Type propertyType, ExpressionBuilderContext context);
+    }
+    public abstract class ControlBuilderInterceptor {
+        protected ControlBuilderInterceptor();
+        public virtual void OnProcessGeneratedCode(ControlBuilder controlBuilder, CodeCompileUnit codeCompileUnit, CodeTypeDeclaration baseType, CodeTypeDeclaration derivedType, CodeMemberMethod buildMethod, CodeMemberMethod dataBindingMethod, IDictionary additionalState);
+        public virtual void PreControlBuilderInit(ControlBuilder controlBuilder, TemplateParser parser, ControlBuilder parentBuilder, Type type, string tagName, string id, IDictionary attributes, IDictionary additionalState);
+    }
+    public sealed class DesignTimeResourceProviderFactoryAttribute : Attribute {
+        public DesignTimeResourceProviderFactoryAttribute(string factoryTypeName);
+        public DesignTimeResourceProviderFactoryAttribute(Type factoryType);
+        public string FactoryTypeName { get; }
+        public override bool IsDefaultAttribute();
+    }
+    public abstract class ExpressionBuilder {
+        protected ExpressionBuilder();
+        public virtual bool SupportsEvaluate { get; }
+        public virtual object EvaluateExpression(object target, BoundPropertyEntry entry, object parsedData, ExpressionBuilderContext context);
+        public abstract CodeExpression GetCodeExpression(BoundPropertyEntry entry, object parsedData, ExpressionBuilderContext context);
+        public virtual object ParseExpression(string expression, Type propertyType, ExpressionBuilderContext context);
+    }
+    public sealed class ExpressionBuilderContext {
+        public ExpressionBuilderContext(string virtualPath);
+        public ExpressionBuilderContext(TemplateControl templateControl);
+        public TemplateControl TemplateControl { get; }
+        public string VirtualPath { get; }
+    }
+    public sealed class ExpressionEditorAttribute : Attribute {
+        public ExpressionEditorAttribute(string typeName);
+        public ExpressionEditorAttribute(Type type);
+        public string EditorTypeName { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+    }
+    public sealed class ExpressionPrefixAttribute : Attribute {
+        public ExpressionPrefixAttribute(string expressionPrefix);
+        public string ExpressionPrefix { get; }
+    }
+    public enum FolderLevelBuildProviderAppliesTo {
+        Code = 1,
+        GlobalResources = 8,
+        LocalResources = 4,
+        None = 0,
+        WebReferences = 2,
+    }
+    public sealed class FolderLevelBuildProviderAppliesToAttribute : Attribute {
+        public FolderLevelBuildProviderAppliesToAttribute(FolderLevelBuildProviderAppliesTo appliesTo);
+        public FolderLevelBuildProviderAppliesTo AppliesTo { get; }
+    }
+    public interface IAssemblyPostProcessor : IDisposable {
+        void PostProcessAssembly(string path);
+    }
+    public interface IImplicitResourceProvider {
+        ICollection GetImplicitResourceKeys(string keyPrefix);
+        object GetObject(ImplicitResourceKey key, CultureInfo culture);
+    }
+    public sealed class ImplicitResourceKey {
+        public ImplicitResourceKey();
+        public ImplicitResourceKey(string filter, string keyPrefix, string property);
+        public string Filter { get; set; }
+        public string KeyPrefix { get; set; }
+        public string Property { get; set; }
+    }
+    public interface IResourceProvider {
+        IResourceReader ResourceReader { get; }
+        object GetObject(string resourceKey, CultureInfo culture);
+    }
+    public interface IWcfReferenceReceiveContextInformation {
+        void ReceiveImportContextInformation(IDictionary<string, byte[]> serviceReferenceExtensionFileContents, IServiceProvider serviceProvider);
+    }
+    public sealed class LinePragmaCodeInfo {
+        public LinePragmaCodeInfo();
+        public LinePragmaCodeInfo(int startLine, int startColumn, int startGeneratedColumn, int codeLength, bool isCodeNugget);
+        public int CodeLength { get; }
+        public bool IsCodeNugget { get; }
+        public int StartColumn { get; }
+        public int StartGeneratedColumn { get; }
+        public int StartLine { get; }
+    }
+    public enum PrecompilationFlags {
+        AllowPartiallyTrustedCallers = 32,
+        Clean = 8,
+        CodeAnalysis = 16,
+        Default = 0,
+        DelaySign = 64,
+        FixedNames = 128,
+        ForceDebug = 4,
+        IgnoreBadImageFormatException = 256,
+        OverwriteTarget = 2,
+        Updatable = 1,
+    }
+    public class ResourceExpressionBuilder : ExpressionBuilder {
+        public ResourceExpressionBuilder();
+        public override bool SupportsEvaluate { get; }
+        public override object EvaluateExpression(object target, BoundPropertyEntry entry, object parsedData, ExpressionBuilderContext context);
+        public override CodeExpression GetCodeExpression(BoundPropertyEntry entry, object parsedData, ExpressionBuilderContext context);
+        public static ResourceExpressionFields ParseExpression(string expression);
+        public override object ParseExpression(string expression, Type propertyType, ExpressionBuilderContext context);
+    }
+    public sealed class ResourceExpressionFields {
+        public string ClassKey { get; }
+        public string ResourceKey { get; }
+    }
+    public abstract class ResourceProviderFactory {
+        protected ResourceProviderFactory();
+        public abstract IResourceProvider CreateGlobalResourceProvider(string classKey);
+        public abstract IResourceProvider CreateLocalResourceProvider(string virtualPath);
+    }
+    public class RouteUrlExpressionBuilder : ExpressionBuilder {
+        public RouteUrlExpressionBuilder();
+        public override bool SupportsEvaluate { get; }
+        public override object EvaluateExpression(object target, BoundPropertyEntry entry, object parsedData, ExpressionBuilderContext context);
+        public override CodeExpression GetCodeExpression(BoundPropertyEntry entry, object parsedData, ExpressionBuilderContext context);
+        public static string GetRouteUrl(Control control, string expression);
+        public static bool TryParseRouteExpression(string expression, RouteValueDictionary routeValues, out string routeName);
+    }
+    public class RouteValueExpressionBuilder : ExpressionBuilder {
+        public RouteValueExpressionBuilder();
+        public override bool SupportsEvaluate { get; }
+        public override object EvaluateExpression(object target, BoundPropertyEntry entry, object parsedData, ExpressionBuilderContext context);
+        public override CodeExpression GetCodeExpression(BoundPropertyEntry entry, object parsedData, ExpressionBuilderContext context);
+        public static object GetRouteValue(Page page, string key, Type controlType, string propertyName);
+    }
+    public class WCFBuildProvider : BuildProvider {
+        public WCFBuildProvider();
+        public override void GenerateCode(AssemblyBuilder assemblyBuilder);
+    }
+}
```

