# System.CodeDom.Compiler

``` diff
 namespace System.CodeDom.Compiler {
+    public abstract class CodeCompiler : CodeGenerator, ICodeCompiler {
+        protected CodeCompiler();
+        protected abstract string CompilerName { get; }
+        protected abstract string FileExtension { get; }
+        protected abstract string CmdArgsFromParameters(CompilerParameters options);
+        protected virtual CompilerResults FromDom(CompilerParameters options, CodeCompileUnit e);
+        protected virtual CompilerResults FromDomBatch(CompilerParameters options, CodeCompileUnit[] ea);
+        protected virtual CompilerResults FromFile(CompilerParameters options, string fileName);
+        protected virtual CompilerResults FromFileBatch(CompilerParameters options, string[] fileNames);
+        protected virtual CompilerResults FromSource(CompilerParameters options, string source);
+        protected virtual CompilerResults FromSourceBatch(CompilerParameters options, string[] sources);
+        protected virtual string GetResponseFileCmdArgs(CompilerParameters options, string cmdArgs);
+        protected static string JoinStringArray(string[] sa, string separator);
+        protected abstract void ProcessCompilerOutputLine(CompilerResults results, string line);
+        CompilerResults System.CodeDom.Compiler.ICodeCompiler.CompileAssemblyFromDom(CompilerParameters options, CodeCompileUnit e);
+        CompilerResults System.CodeDom.Compiler.ICodeCompiler.CompileAssemblyFromDomBatch(CompilerParameters options, CodeCompileUnit[] ea);
+        CompilerResults System.CodeDom.Compiler.ICodeCompiler.CompileAssemblyFromFile(CompilerParameters options, string fileName);
+        CompilerResults System.CodeDom.Compiler.ICodeCompiler.CompileAssemblyFromFileBatch(CompilerParameters options, string[] fileNames);
+        CompilerResults System.CodeDom.Compiler.ICodeCompiler.CompileAssemblyFromSource(CompilerParameters options, string source);
+        CompilerResults System.CodeDom.Compiler.ICodeCompiler.CompileAssemblyFromSourceBatch(CompilerParameters options, string[] sources);
+    }
+    public abstract class CodeDomProvider : Component {
+        protected CodeDomProvider();
+        public virtual string FileExtension { get; }
+        public virtual LanguageOptions LanguageOptions { get; }
+        public virtual CompilerResults CompileAssemblyFromDom(CompilerParameters options, params CodeCompileUnit[] compilationUnits);
+        public virtual CompilerResults CompileAssemblyFromFile(CompilerParameters options, params string[] fileNames);
+        public virtual CompilerResults CompileAssemblyFromSource(CompilerParameters options, params string[] sources);
+        public abstract ICodeCompiler CreateCompiler();
+        public virtual string CreateEscapedIdentifier(string value);
+        public abstract ICodeGenerator CreateGenerator();
+        public virtual ICodeGenerator CreateGenerator(TextWriter output);
+        public virtual ICodeGenerator CreateGenerator(string fileName);
+        public virtual ICodeParser CreateParser();
+        public static CodeDomProvider CreateProvider(string language);
+        public static CodeDomProvider CreateProvider(string language, IDictionary<string, string> providerOptions);
+        public virtual string CreateValidIdentifier(string value);
+        public virtual void GenerateCodeFromCompileUnit(CodeCompileUnit compileUnit, TextWriter writer, CodeGeneratorOptions options);
+        public virtual void GenerateCodeFromExpression(CodeExpression expression, TextWriter writer, CodeGeneratorOptions options);
+        public virtual void GenerateCodeFromMember(CodeTypeMember member, TextWriter writer, CodeGeneratorOptions options);
+        public virtual void GenerateCodeFromNamespace(CodeNamespace codeNamespace, TextWriter writer, CodeGeneratorOptions options);
+        public virtual void GenerateCodeFromStatement(CodeStatement statement, TextWriter writer, CodeGeneratorOptions options);
+        public virtual void GenerateCodeFromType(CodeTypeDeclaration codeType, TextWriter writer, CodeGeneratorOptions options);
+        public static CompilerInfo[] GetAllCompilerInfo();
+        public static CompilerInfo GetCompilerInfo(string language);
+        public virtual TypeConverter GetConverter(Type type);
+        public static string GetLanguageFromExtension(string extension);
+        public virtual string GetTypeOutput(CodeTypeReference type);
+        public static bool IsDefinedExtension(string extension);
+        public static bool IsDefinedLanguage(string language);
+        public virtual bool IsValidIdentifier(string value);
+        public virtual CodeCompileUnit Parse(TextReader codeStream);
+        public virtual bool Supports(GeneratorSupport generatorSupport);
+    }
+    public abstract class CodeGenerator : ICodeGenerator {
+        protected CodeGenerator();
+        protected CodeTypeDeclaration CurrentClass { get; }
+        protected CodeTypeMember CurrentMember { get; }
+        protected string CurrentMemberName { get; }
+        protected string CurrentTypeName { get; }
+        protected int Indent { get; set; }
+        protected bool IsCurrentClass { get; }
+        protected bool IsCurrentDelegate { get; }
+        protected bool IsCurrentEnum { get; }
+        protected bool IsCurrentInterface { get; }
+        protected bool IsCurrentStruct { get; }
+        protected abstract string NullToken { get; }
+        protected CodeGeneratorOptions Options { get; }
+        protected TextWriter Output { get; }
+        protected virtual void ContinueOnNewLine(string st);
+        protected abstract string CreateEscapedIdentifier(string value);
+        protected abstract string CreateValidIdentifier(string value);
+        protected abstract void GenerateArgumentReferenceExpression(CodeArgumentReferenceExpression e);
+        protected abstract void GenerateArrayCreateExpression(CodeArrayCreateExpression e);
+        protected abstract void GenerateArrayIndexerExpression(CodeArrayIndexerExpression e);
+        protected abstract void GenerateAssignStatement(CodeAssignStatement e);
+        protected abstract void GenerateAttachEventStatement(CodeAttachEventStatement e);
+        protected abstract void GenerateAttributeDeclarationsEnd(CodeAttributeDeclarationCollection attributes);
+        protected abstract void GenerateAttributeDeclarationsStart(CodeAttributeDeclarationCollection attributes);
+        protected abstract void GenerateBaseReferenceExpression(CodeBaseReferenceExpression e);
+        protected virtual void GenerateBinaryOperatorExpression(CodeBinaryOperatorExpression e);
+        protected abstract void GenerateCastExpression(CodeCastExpression e);
+        public virtual void GenerateCodeFromMember(CodeTypeMember member, TextWriter writer, CodeGeneratorOptions options);
+        protected abstract void GenerateComment(CodeComment e);
+        protected virtual void GenerateCommentStatement(CodeCommentStatement e);
+        protected virtual void GenerateCommentStatements(CodeCommentStatementCollection e);
+        protected virtual void GenerateCompileUnit(CodeCompileUnit e);
+        protected virtual void GenerateCompileUnitEnd(CodeCompileUnit e);
+        protected virtual void GenerateCompileUnitStart(CodeCompileUnit e);
+        protected abstract void GenerateConditionStatement(CodeConditionStatement e);
+        protected abstract void GenerateConstructor(CodeConstructor e, CodeTypeDeclaration c);
+        protected virtual void GenerateDecimalValue(decimal d);
+        protected virtual void GenerateDefaultValueExpression(CodeDefaultValueExpression e);
+        protected abstract void GenerateDelegateCreateExpression(CodeDelegateCreateExpression e);
+        protected abstract void GenerateDelegateInvokeExpression(CodeDelegateInvokeExpression e);
+        protected virtual void GenerateDirectionExpression(CodeDirectionExpression e);
+        protected virtual void GenerateDirectives(CodeDirectiveCollection directives);
+        protected virtual void GenerateDoubleValue(double d);
+        protected abstract void GenerateEntryPointMethod(CodeEntryPointMethod e, CodeTypeDeclaration c);
+        protected abstract void GenerateEvent(CodeMemberEvent e, CodeTypeDeclaration c);
+        protected abstract void GenerateEventReferenceExpression(CodeEventReferenceExpression e);
+        protected void GenerateExpression(CodeExpression e);
+        protected abstract void GenerateExpressionStatement(CodeExpressionStatement e);
+        protected abstract void GenerateField(CodeMemberField e);
+        protected abstract void GenerateFieldReferenceExpression(CodeFieldReferenceExpression e);
+        protected abstract void GenerateGotoStatement(CodeGotoStatement e);
+        protected abstract void GenerateIndexerExpression(CodeIndexerExpression e);
+        protected abstract void GenerateIterationStatement(CodeIterationStatement e);
+        protected abstract void GenerateLabeledStatement(CodeLabeledStatement e);
+        protected abstract void GenerateLinePragmaEnd(CodeLinePragma e);
+        protected abstract void GenerateLinePragmaStart(CodeLinePragma e);
+        protected abstract void GenerateMethod(CodeMemberMethod e, CodeTypeDeclaration c);
+        protected abstract void GenerateMethodInvokeExpression(CodeMethodInvokeExpression e);
+        protected abstract void GenerateMethodReferenceExpression(CodeMethodReferenceExpression e);
+        protected abstract void GenerateMethodReturnStatement(CodeMethodReturnStatement e);
+        protected virtual void GenerateNamespace(CodeNamespace e);
+        protected abstract void GenerateNamespaceEnd(CodeNamespace e);
+        protected abstract void GenerateNamespaceImport(CodeNamespaceImport e);
+        protected void GenerateNamespaceImports(CodeNamespace e);
+        protected void GenerateNamespaces(CodeCompileUnit e);
+        protected abstract void GenerateNamespaceStart(CodeNamespace e);
+        protected abstract void GenerateObjectCreateExpression(CodeObjectCreateExpression e);
+        protected virtual void GenerateParameterDeclarationExpression(CodeParameterDeclarationExpression e);
+        protected virtual void GeneratePrimitiveExpression(CodePrimitiveExpression e);
+        protected abstract void GenerateProperty(CodeMemberProperty e, CodeTypeDeclaration c);
+        protected abstract void GeneratePropertyReferenceExpression(CodePropertyReferenceExpression e);
+        protected abstract void GeneratePropertySetValueReferenceExpression(CodePropertySetValueReferenceExpression e);
+        protected abstract void GenerateRemoveEventStatement(CodeRemoveEventStatement e);
+        protected virtual void GenerateSingleFloatValue(float s);
+        protected virtual void GenerateSnippetCompileUnit(CodeSnippetCompileUnit e);
+        protected abstract void GenerateSnippetExpression(CodeSnippetExpression e);
+        protected abstract void GenerateSnippetMember(CodeSnippetTypeMember e);
+        protected virtual void GenerateSnippetStatement(CodeSnippetStatement e);
+        protected void GenerateStatement(CodeStatement e);
+        protected void GenerateStatements(CodeStatementCollection stms);
+        protected abstract void GenerateThisReferenceExpression(CodeThisReferenceExpression e);
+        protected abstract void GenerateThrowExceptionStatement(CodeThrowExceptionStatement e);
+        protected abstract void GenerateTryCatchFinallyStatement(CodeTryCatchFinallyStatement e);
+        protected abstract void GenerateTypeConstructor(CodeTypeConstructor e);
+        protected abstract void GenerateTypeEnd(CodeTypeDeclaration e);
+        protected virtual void GenerateTypeOfExpression(CodeTypeOfExpression e);
+        protected virtual void GenerateTypeReferenceExpression(CodeTypeReferenceExpression e);
+        protected void GenerateTypes(CodeNamespace e);
+        protected abstract void GenerateTypeStart(CodeTypeDeclaration e);
+        protected abstract void GenerateVariableDeclarationStatement(CodeVariableDeclarationStatement e);
+        protected abstract void GenerateVariableReferenceExpression(CodeVariableReferenceExpression e);
+        protected abstract string GetTypeOutput(CodeTypeReference value);
+        protected abstract bool IsValidIdentifier(string value);
+        public static bool IsValidLanguageIndependentIdentifier(string value);
+        protected virtual void OutputAttributeArgument(CodeAttributeArgument arg);
+        protected virtual void OutputAttributeDeclarations(CodeAttributeDeclarationCollection attributes);
+        protected virtual void OutputDirection(FieldDirection dir);
+        protected virtual void OutputExpressionList(CodeExpressionCollection expressions);
+        protected virtual void OutputExpressionList(CodeExpressionCollection expressions, bool newlineBetweenItems);
+        protected virtual void OutputFieldScopeModifier(MemberAttributes attributes);
+        protected virtual void OutputIdentifier(string ident);
+        protected virtual void OutputMemberAccessModifier(MemberAttributes attributes);
+        protected virtual void OutputMemberScopeModifier(MemberAttributes attributes);
+        protected virtual void OutputOperator(CodeBinaryOperatorType op);
+        protected virtual void OutputParameters(CodeParameterDeclarationExpressionCollection parameters);
+        protected abstract void OutputType(CodeTypeReference typeRef);
+        protected virtual void OutputTypeAttributes(TypeAttributes attributes, bool isStruct, bool isEnum);
+        protected virtual void OutputTypeNamePair(CodeTypeReference typeRef, string name);
+        protected abstract string QuoteSnippetString(string value);
+        protected abstract bool Supports(GeneratorSupport support);
+        string System.CodeDom.Compiler.ICodeGenerator.CreateEscapedIdentifier(string value);
+        string System.CodeDom.Compiler.ICodeGenerator.CreateValidIdentifier(string value);
+        void System.CodeDom.Compiler.ICodeGenerator.GenerateCodeFromCompileUnit(CodeCompileUnit e, TextWriter w, CodeGeneratorOptions o);
+        void System.CodeDom.Compiler.ICodeGenerator.GenerateCodeFromExpression(CodeExpression e, TextWriter w, CodeGeneratorOptions o);
+        void System.CodeDom.Compiler.ICodeGenerator.GenerateCodeFromNamespace(CodeNamespace e, TextWriter w, CodeGeneratorOptions o);
+        void System.CodeDom.Compiler.ICodeGenerator.GenerateCodeFromStatement(CodeStatement e, TextWriter w, CodeGeneratorOptions o);
+        void System.CodeDom.Compiler.ICodeGenerator.GenerateCodeFromType(CodeTypeDeclaration e, TextWriter w, CodeGeneratorOptions o);
+        string System.CodeDom.Compiler.ICodeGenerator.GetTypeOutput(CodeTypeReference type);
+        bool System.CodeDom.Compiler.ICodeGenerator.IsValidIdentifier(string value);
+        bool System.CodeDom.Compiler.ICodeGenerator.Supports(GeneratorSupport support);
+        void System.CodeDom.Compiler.ICodeGenerator.ValidateIdentifier(string value);
+        protected virtual void ValidateIdentifier(string value);
+        public static void ValidateIdentifiers(CodeObject e);
+    }
+    public class CodeGeneratorOptions {
+        public CodeGeneratorOptions();
+        public bool BlankLinesBetweenMembers { get; set; }
+        public string BracingStyle { get; set; }
+        public bool ElseOnClosing { get; set; }
+        public string IndentString { get; set; }
+        public object this[string index] { get; set; }
+        public bool VerbatimOrder { get; set; }
+    }
+    public abstract class CodeParser : ICodeParser {
+        protected CodeParser();
+        public abstract CodeCompileUnit Parse(TextReader codeStream);
+    }
+    public class CompilerError {
+        public CompilerError();
+        public CompilerError(string fileName, int line, int column, string errorNumber, string errorText);
+        public int Column { get; set; }
+        public string ErrorNumber { get; set; }
+        public string ErrorText { get; set; }
+        public string FileName { get; set; }
+        public bool IsWarning { get; set; }
+        public int Line { get; set; }
+        public override string ToString();
+    }
+    public class CompilerErrorCollection : CollectionBase {
+        public CompilerErrorCollection();
+        public CompilerErrorCollection(CompilerErrorCollection value);
+        public CompilerErrorCollection(CompilerError[] value);
+        public bool HasErrors { get; }
+        public bool HasWarnings { get; }
+        public CompilerError this[int index] { get; set; }
+        public int Add(CompilerError value);
+        public void AddRange(CompilerErrorCollection value);
+        public void AddRange(CompilerError[] value);
+        public bool Contains(CompilerError value);
+        public void CopyTo(CompilerError[] array, int index);
+        public int IndexOf(CompilerError value);
+        public void Insert(int index, CompilerError value);
+        public void Remove(CompilerError value);
+    }
+    public sealed class CompilerInfo {
+        public Type CodeDomProviderType { get; }
+        public bool IsCodeDomProviderTypeValid { get; }
+        public CompilerParameters CreateDefaultCompilerParameters();
+        public CodeDomProvider CreateProvider();
+        public CodeDomProvider CreateProvider(IDictionary<string, string> providerOptions);
+        public override bool Equals(object o);
+        public string[] GetExtensions();
+        public override int GetHashCode();
+        public string[] GetLanguages();
+    }
+    public class CompilerParameters {
+        public CompilerParameters();
+        public CompilerParameters(string[] assemblyNames);
+        public CompilerParameters(string[] assemblyNames, string outputName);
+        public CompilerParameters(string[] assemblyNames, string outputName, bool includeDebugInformation);
+        public string CompilerOptions { get; set; }
+        public string CoreAssemblyFileName { get; set; }
+        public StringCollection EmbeddedResources { get; }
+        public Evidence Evidence { get; set; }
+        public bool GenerateExecutable { get; set; }
+        public bool GenerateInMemory { get; set; }
+        public bool IncludeDebugInformation { get; set; }
+        public StringCollection LinkedResources { get; }
+        public string MainClass { get; set; }
+        public string OutputAssembly { get; set; }
+        public StringCollection ReferencedAssemblies { get; }
+        public TempFileCollection TempFiles { get; set; }
+        public bool TreatWarningsAsErrors { get; set; }
+        public IntPtr UserToken { get; set; }
+        public int WarningLevel { get; set; }
+        public string Win32Resource { get; set; }
+    }
+    public class CompilerResults {
+        public CompilerResults(TempFileCollection tempFiles);
+        public Assembly CompiledAssembly { get; set; }
+        public CompilerErrorCollection Errors { get; }
+        public Evidence Evidence { get; set; }
+        public int NativeCompilerReturnValue { get; set; }
+        public StringCollection Output { get; }
+        public string PathToAssembly { get; set; }
+        public TempFileCollection TempFiles { get; set; }
+    }
+    public static class Executor {
+        public static void ExecWait(string cmd, TempFileCollection tempFiles);
+        public static int ExecWaitWithCapture(IntPtr userToken, string cmd, TempFileCollection tempFiles, ref string outputName, ref string errorName);
+        public static int ExecWaitWithCapture(IntPtr userToken, string cmd, string currentDir, TempFileCollection tempFiles, ref string outputName, ref string errorName);
+        public static int ExecWaitWithCapture(string cmd, TempFileCollection tempFiles, ref string outputName, ref string errorName);
+        public static int ExecWaitWithCapture(string cmd, string currentDir, TempFileCollection tempFiles, ref string outputName, ref string errorName);
+    }
+    public enum GeneratorSupport {
+        ArraysOfArrays = 1,
+        AssemblyAttributes = 4096,
+        ChainedConstructorArguments = 32768,
+        ComplexExpressions = 524288,
+        DeclareDelegates = 512,
+        DeclareEnums = 256,
+        DeclareEvents = 2048,
+        DeclareIndexerProperties = 33554432,
+        DeclareInterfaces = 1024,
+        DeclareValueTypes = 128,
+        EntryPointMethod = 2,
+        GenericTypeDeclaration = 16777216,
+        GenericTypeReference = 8388608,
+        GotoStatements = 4,
+        MultidimensionalArrays = 8,
+        MultipleInterfaceMembers = 131072,
+        NestedTypes = 65536,
+        ParameterAttributes = 8192,
+        PartialTypes = 4194304,
+        PublicStaticMembers = 262144,
+        ReferenceParameters = 16384,
+        Resources = 2097152,
+        ReturnTypeAttributes = 64,
+        StaticConstructors = 16,
+        TryCatchStatements = 32,
+        Win32Resources = 1048576,
+    }
+    public interface ICodeCompiler {
+        CompilerResults CompileAssemblyFromDom(CompilerParameters options, CodeCompileUnit compilationUnit);
+        CompilerResults CompileAssemblyFromDomBatch(CompilerParameters options, CodeCompileUnit[] compilationUnits);
+        CompilerResults CompileAssemblyFromFile(CompilerParameters options, string fileName);
+        CompilerResults CompileAssemblyFromFileBatch(CompilerParameters options, string[] fileNames);
+        CompilerResults CompileAssemblyFromSource(CompilerParameters options, string source);
+        CompilerResults CompileAssemblyFromSourceBatch(CompilerParameters options, string[] sources);
+    }
+    public interface ICodeGenerator {
+        string CreateEscapedIdentifier(string value);
+        string CreateValidIdentifier(string value);
+        void GenerateCodeFromCompileUnit(CodeCompileUnit e, TextWriter w, CodeGeneratorOptions o);
+        void GenerateCodeFromExpression(CodeExpression e, TextWriter w, CodeGeneratorOptions o);
+        void GenerateCodeFromNamespace(CodeNamespace e, TextWriter w, CodeGeneratorOptions o);
+        void GenerateCodeFromStatement(CodeStatement e, TextWriter w, CodeGeneratorOptions o);
+        void GenerateCodeFromType(CodeTypeDeclaration e, TextWriter w, CodeGeneratorOptions o);
+        string GetTypeOutput(CodeTypeReference type);
+        bool IsValidIdentifier(string value);
+        bool Supports(GeneratorSupport supports);
+        void ValidateIdentifier(string value);
+    }
+    public interface ICodeParser {
+        CodeCompileUnit Parse(TextReader codeStream);
+    }
+    public enum LanguageOptions {
+        CaseInsensitive = 1,
+        None = 0,
+    }
+    public class TempFileCollection : ICollection, IDisposable, IEnumerable {
+        public TempFileCollection();
+        public TempFileCollection(string tempDir);
+        public TempFileCollection(string tempDir, bool keepFiles);
+        public string BasePath { get; }
+        public int Count { get; }
+        public bool KeepFiles { get; set; }
+        int System.Collections.ICollection.Count { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        public string TempDir { get; }
+        public string AddExtension(string fileExtension);
+        public string AddExtension(string fileExtension, bool keepFile);
+        public void AddFile(string fileName, bool keepFile);
+        public void CopyTo(string[] fileNames, int start);
+        public void Delete();
+        protected virtual void Dispose(bool disposing);
+        ~TempFileCollection();
+        public IEnumerator GetEnumerator();
+        void System.Collections.ICollection.CopyTo(Array array, int start);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        void System.IDisposable.Dispose();
+    }
 }
```

