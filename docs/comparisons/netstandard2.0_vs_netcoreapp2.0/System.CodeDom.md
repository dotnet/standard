# System.CodeDom

``` diff
+namespace System.CodeDom {
+    public class CodeArgumentReferenceExpression : CodeExpression {
+        public CodeArgumentReferenceExpression();
+        public CodeArgumentReferenceExpression(string parameterName);
+        public string ParameterName { get; set; }
+    }
+    public class CodeArrayCreateExpression : CodeExpression {
+        public CodeArrayCreateExpression();
+        public CodeArrayCreateExpression(CodeTypeReference createType, CodeExpression size);
+        public CodeArrayCreateExpression(CodeTypeReference createType, params CodeExpression[] initializers);
+        public CodeArrayCreateExpression(CodeTypeReference createType, int size);
+        public CodeArrayCreateExpression(string createType, CodeExpression size);
+        public CodeArrayCreateExpression(string createType, params CodeExpression[] initializers);
+        public CodeArrayCreateExpression(string createType, int size);
+        public CodeArrayCreateExpression(Type createType, CodeExpression size);
+        public CodeArrayCreateExpression(Type createType, params CodeExpression[] initializers);
+        public CodeArrayCreateExpression(Type createType, int size);
+        public CodeTypeReference CreateType { get; set; }
+        public CodeExpressionCollection Initializers { get; }
+        public int Size { get; set; }
+        public CodeExpression SizeExpression { get; set; }
+    }
+    public class CodeArrayIndexerExpression : CodeExpression {
+        public CodeArrayIndexerExpression();
+        public CodeArrayIndexerExpression(CodeExpression targetObject, params CodeExpression[] indices);
+        public CodeExpressionCollection Indices { get; }
+        public CodeExpression TargetObject { get; set; }
+    }
+    public class CodeAssignStatement : CodeStatement {
+        public CodeAssignStatement();
+        public CodeAssignStatement(CodeExpression left, CodeExpression right);
+        public CodeExpression Left { get; set; }
+        public CodeExpression Right { get; set; }
+    }
+    public class CodeAttachEventStatement : CodeStatement {
+        public CodeAttachEventStatement();
+        public CodeAttachEventStatement(CodeEventReferenceExpression eventRef, CodeExpression listener);
+        public CodeAttachEventStatement(CodeExpression targetObject, string eventName, CodeExpression listener);
+        public CodeEventReferenceExpression Event { get; set; }
+        public CodeExpression Listener { get; set; }
+    }
+    public class CodeAttributeArgument {
+        public CodeAttributeArgument();
+        public CodeAttributeArgument(CodeExpression value);
+        public CodeAttributeArgument(string name, CodeExpression value);
+        public string Name { get; set; }
+        public CodeExpression Value { get; set; }
+    }
+    public class CodeAttributeArgumentCollection : CollectionBase {
+        public CodeAttributeArgumentCollection();
+        public CodeAttributeArgumentCollection(CodeAttributeArgumentCollection value);
+        public CodeAttributeArgumentCollection(CodeAttributeArgument[] value);
+        public CodeAttributeArgument this[int index] { get; set; }
+        public int Add(CodeAttributeArgument value);
+        public void AddRange(CodeAttributeArgumentCollection value);
+        public void AddRange(CodeAttributeArgument[] value);
+        public bool Contains(CodeAttributeArgument value);
+        public void CopyTo(CodeAttributeArgument[] array, int index);
+        public int IndexOf(CodeAttributeArgument value);
+        public void Insert(int index, CodeAttributeArgument value);
+        public void Remove(CodeAttributeArgument value);
+    }
+    public class CodeAttributeDeclaration {
+        public CodeAttributeDeclaration();
+        public CodeAttributeDeclaration(CodeTypeReference attributeType);
+        public CodeAttributeDeclaration(CodeTypeReference attributeType, params CodeAttributeArgument[] arguments);
+        public CodeAttributeDeclaration(string name);
+        public CodeAttributeDeclaration(string name, params CodeAttributeArgument[] arguments);
+        public CodeAttributeArgumentCollection Arguments { get; }
+        public CodeTypeReference AttributeType { get; }
+        public string Name { get; set; }
+    }
+    public class CodeAttributeDeclarationCollection : CollectionBase {
+        public CodeAttributeDeclarationCollection();
+        public CodeAttributeDeclarationCollection(CodeAttributeDeclarationCollection value);
+        public CodeAttributeDeclarationCollection(CodeAttributeDeclaration[] value);
+        public CodeAttributeDeclaration this[int index] { get; set; }
+        public int Add(CodeAttributeDeclaration value);
+        public void AddRange(CodeAttributeDeclarationCollection value);
+        public void AddRange(CodeAttributeDeclaration[] value);
+        public bool Contains(CodeAttributeDeclaration value);
+        public void CopyTo(CodeAttributeDeclaration[] array, int index);
+        public int IndexOf(CodeAttributeDeclaration value);
+        public void Insert(int index, CodeAttributeDeclaration value);
+        public void Remove(CodeAttributeDeclaration value);
+    }
+    public class CodeBaseReferenceExpression : CodeExpression {
+        public CodeBaseReferenceExpression();
+    }
+    public class CodeBinaryOperatorExpression : CodeExpression {
+        public CodeBinaryOperatorExpression();
+        public CodeBinaryOperatorExpression(CodeExpression left, CodeBinaryOperatorType op, CodeExpression right);
+        public CodeExpression Left { get; set; }
+        public CodeBinaryOperatorType Operator { get; set; }
+        public CodeExpression Right { get; set; }
+    }
+    public enum CodeBinaryOperatorType {
+        Add = 0,
+        Assign = 5,
+        BitwiseAnd = 10,
+        BitwiseOr = 9,
+        BooleanAnd = 12,
+        BooleanOr = 11,
+        Divide = 3,
+        GreaterThan = 15,
+        GreaterThanOrEqual = 16,
+        IdentityEquality = 7,
+        IdentityInequality = 6,
+        LessThan = 13,
+        LessThanOrEqual = 14,
+        Modulus = 4,
+        Multiply = 2,
+        Subtract = 1,
+        ValueEquality = 8,
+    }
+    public class CodeCastExpression : CodeExpression {
+        public CodeCastExpression();
+        public CodeCastExpression(CodeTypeReference targetType, CodeExpression expression);
+        public CodeCastExpression(string targetType, CodeExpression expression);
+        public CodeCastExpression(Type targetType, CodeExpression expression);
+        public CodeExpression Expression { get; set; }
+        public CodeTypeReference TargetType { get; set; }
+    }
+    public class CodeCatchClause {
+        public CodeCatchClause();
+        public CodeCatchClause(string localName);
+        public CodeCatchClause(string localName, CodeTypeReference catchExceptionType);
+        public CodeCatchClause(string localName, CodeTypeReference catchExceptionType, params CodeStatement[] statements);
+        public CodeTypeReference CatchExceptionType { get; set; }
+        public string LocalName { get; set; }
+        public CodeStatementCollection Statements { get; }
+    }
+    public class CodeCatchClauseCollection : CollectionBase {
+        public CodeCatchClauseCollection();
+        public CodeCatchClauseCollection(CodeCatchClauseCollection value);
+        public CodeCatchClauseCollection(CodeCatchClause[] value);
+        public CodeCatchClause this[int index] { get; set; }
+        public int Add(CodeCatchClause value);
+        public void AddRange(CodeCatchClauseCollection value);
+        public void AddRange(CodeCatchClause[] value);
+        public bool Contains(CodeCatchClause value);
+        public void CopyTo(CodeCatchClause[] array, int index);
+        public int IndexOf(CodeCatchClause value);
+        public void Insert(int index, CodeCatchClause value);
+        public void Remove(CodeCatchClause value);
+    }
+    public class CodeChecksumPragma : CodeDirective {
+        public CodeChecksumPragma();
+        public CodeChecksumPragma(string fileName, Guid checksumAlgorithmId, byte[] checksumData);
+        public Guid ChecksumAlgorithmId { get; set; }
+        public byte[] ChecksumData { get; set; }
+        public string FileName { get; set; }
+    }
+    public class CodeComment : CodeObject {
+        public CodeComment();
+        public CodeComment(string text);
+        public CodeComment(string text, bool docComment);
+        public bool DocComment { get; set; }
+        public string Text { get; set; }
+    }
+    public class CodeCommentStatement : CodeStatement {
+        public CodeCommentStatement();
+        public CodeCommentStatement(CodeComment comment);
+        public CodeCommentStatement(string text);
+        public CodeCommentStatement(string text, bool docComment);
+        public CodeComment Comment { get; set; }
+    }
+    public class CodeCommentStatementCollection : CollectionBase {
+        public CodeCommentStatementCollection();
+        public CodeCommentStatementCollection(CodeCommentStatementCollection value);
+        public CodeCommentStatementCollection(CodeCommentStatement[] value);
+        public CodeCommentStatement this[int index] { get; set; }
+        public int Add(CodeCommentStatement value);
+        public void AddRange(CodeCommentStatementCollection value);
+        public void AddRange(CodeCommentStatement[] value);
+        public bool Contains(CodeCommentStatement value);
+        public void CopyTo(CodeCommentStatement[] array, int index);
+        public int IndexOf(CodeCommentStatement value);
+        public void Insert(int index, CodeCommentStatement value);
+        public void Remove(CodeCommentStatement value);
+    }
+    public class CodeCompileUnit : CodeObject {
+        public CodeCompileUnit();
+        public CodeAttributeDeclarationCollection AssemblyCustomAttributes { get; }
+        public CodeDirectiveCollection EndDirectives { get; }
+        public CodeNamespaceCollection Namespaces { get; }
+        public StringCollection ReferencedAssemblies { get; }
+        public CodeDirectiveCollection StartDirectives { get; }
+    }
+    public class CodeConditionStatement : CodeStatement {
+        public CodeConditionStatement();
+        public CodeConditionStatement(CodeExpression condition, params CodeStatement[] trueStatements);
+        public CodeConditionStatement(CodeExpression condition, CodeStatement[] trueStatements, CodeStatement[] falseStatements);
+        public CodeExpression Condition { get; set; }
+        public CodeStatementCollection FalseStatements { get; }
+        public CodeStatementCollection TrueStatements { get; }
+    }
+    public class CodeConstructor : CodeMemberMethod {
+        public CodeConstructor();
+        public CodeExpressionCollection BaseConstructorArgs { get; }
+        public CodeExpressionCollection ChainedConstructorArgs { get; }
+    }
+    public class CodeDefaultValueExpression : CodeExpression {
+        public CodeDefaultValueExpression();
+        public CodeDefaultValueExpression(CodeTypeReference type);
+        public CodeTypeReference Type { get; set; }
+    }
+    public class CodeDelegateCreateExpression : CodeExpression {
+        public CodeDelegateCreateExpression();
+        public CodeDelegateCreateExpression(CodeTypeReference delegateType, CodeExpression targetObject, string methodName);
+        public CodeTypeReference DelegateType { get; set; }
+        public string MethodName { get; set; }
+        public CodeExpression TargetObject { get; set; }
+    }
+    public class CodeDelegateInvokeExpression : CodeExpression {
+        public CodeDelegateInvokeExpression();
+        public CodeDelegateInvokeExpression(CodeExpression targetObject);
+        public CodeDelegateInvokeExpression(CodeExpression targetObject, params CodeExpression[] parameters);
+        public CodeExpressionCollection Parameters { get; }
+        public CodeExpression TargetObject { get; set; }
+    }
+    public class CodeDirectionExpression : CodeExpression {
+        public CodeDirectionExpression();
+        public CodeDirectionExpression(FieldDirection direction, CodeExpression expression);
+        public FieldDirection Direction { get; set; }
+        public CodeExpression Expression { get; set; }
+    }
+    public class CodeDirective : CodeObject {
+        public CodeDirective();
+    }
+    public class CodeDirectiveCollection : CollectionBase {
+        public CodeDirectiveCollection();
+        public CodeDirectiveCollection(CodeDirectiveCollection value);
+        public CodeDirectiveCollection(CodeDirective[] value);
+        public CodeDirective this[int index] { get; set; }
+        public int Add(CodeDirective value);
+        public void AddRange(CodeDirectiveCollection value);
+        public void AddRange(CodeDirective[] value);
+        public bool Contains(CodeDirective value);
+        public void CopyTo(CodeDirective[] array, int index);
+        public int IndexOf(CodeDirective value);
+        public void Insert(int index, CodeDirective value);
+        public void Remove(CodeDirective value);
+    }
+    public class CodeEntryPointMethod : CodeMemberMethod {
+        public CodeEntryPointMethod();
+    }
+    public class CodeEventReferenceExpression : CodeExpression {
+        public CodeEventReferenceExpression();
+        public CodeEventReferenceExpression(CodeExpression targetObject, string eventName);
+        public string EventName { get; set; }
+        public CodeExpression TargetObject { get; set; }
+    }
+    public class CodeExpression : CodeObject {
+        public CodeExpression();
+    }
+    public class CodeExpressionCollection : CollectionBase {
+        public CodeExpressionCollection();
+        public CodeExpressionCollection(CodeExpressionCollection value);
+        public CodeExpressionCollection(CodeExpression[] value);
+        public CodeExpression this[int index] { get; set; }
+        public int Add(CodeExpression value);
+        public void AddRange(CodeExpressionCollection value);
+        public void AddRange(CodeExpression[] value);
+        public bool Contains(CodeExpression value);
+        public void CopyTo(CodeExpression[] array, int index);
+        public int IndexOf(CodeExpression value);
+        public void Insert(int index, CodeExpression value);
+        public void Remove(CodeExpression value);
+    }
+    public class CodeExpressionStatement : CodeStatement {
+        public CodeExpressionStatement();
+        public CodeExpressionStatement(CodeExpression expression);
+        public CodeExpression Expression { get; set; }
+    }
+    public class CodeFieldReferenceExpression : CodeExpression {
+        public CodeFieldReferenceExpression();
+        public CodeFieldReferenceExpression(CodeExpression targetObject, string fieldName);
+        public string FieldName { get; set; }
+        public CodeExpression TargetObject { get; set; }
+    }
+    public class CodeGotoStatement : CodeStatement {
+        public CodeGotoStatement();
+        public CodeGotoStatement(string label);
+        public string Label { get; set; }
+    }
+    public class CodeIndexerExpression : CodeExpression {
+        public CodeIndexerExpression();
+        public CodeIndexerExpression(CodeExpression targetObject, params CodeExpression[] indices);
+        public CodeExpressionCollection Indices { get; }
+        public CodeExpression TargetObject { get; set; }
+    }
+    public class CodeIterationStatement : CodeStatement {
+        public CodeIterationStatement();
+        public CodeIterationStatement(CodeStatement initStatement, CodeExpression testExpression, CodeStatement incrementStatement, params CodeStatement[] statements);
+        public CodeStatement IncrementStatement { get; set; }
+        public CodeStatement InitStatement { get; set; }
+        public CodeStatementCollection Statements { get; }
+        public CodeExpression TestExpression { get; set; }
+    }
+    public class CodeLabeledStatement : CodeStatement {
+        public CodeLabeledStatement();
+        public CodeLabeledStatement(string label);
+        public CodeLabeledStatement(string label, CodeStatement statement);
+        public string Label { get; set; }
+        public CodeStatement Statement { get; set; }
+    }
+    public class CodeLinePragma {
+        public CodeLinePragma();
+        public CodeLinePragma(string fileName, int lineNumber);
+        public string FileName { get; set; }
+        public int LineNumber { get; set; }
+    }
+    public class CodeMemberEvent : CodeTypeMember {
+        public CodeMemberEvent();
+        public CodeTypeReferenceCollection ImplementationTypes { get; }
+        public CodeTypeReference PrivateImplementationType { get; set; }
+        public CodeTypeReference Type { get; set; }
+    }
+    public class CodeMemberField : CodeTypeMember {
+        public CodeMemberField();
+        public CodeMemberField(CodeTypeReference type, string name);
+        public CodeMemberField(string type, string name);
+        public CodeMemberField(Type type, string name);
+        public CodeExpression InitExpression { get; set; }
+        public CodeTypeReference Type { get; set; }
+    }
+    public class CodeMemberMethod : CodeTypeMember {
+        public CodeMemberMethod();
+        public CodeTypeReferenceCollection ImplementationTypes { get; }
+        public CodeParameterDeclarationExpressionCollection Parameters { get; }
+        public CodeTypeReference PrivateImplementationType { get; set; }
+        public CodeTypeReference ReturnType { get; set; }
+        public CodeAttributeDeclarationCollection ReturnTypeCustomAttributes { get; }
+        public CodeStatementCollection Statements { get; }
+        public CodeTypeParameterCollection TypeParameters { get; }
+        public event EventHandler PopulateImplementationTypes;
+        public event EventHandler PopulateParameters;
+        public event EventHandler PopulateStatements;
+    }
+    public class CodeMemberProperty : CodeTypeMember {
+        public CodeMemberProperty();
+        public CodeStatementCollection GetStatements { get; }
+        public bool HasGet { get; set; }
+        public bool HasSet { get; set; }
+        public CodeTypeReferenceCollection ImplementationTypes { get; }
+        public CodeParameterDeclarationExpressionCollection Parameters { get; }
+        public CodeTypeReference PrivateImplementationType { get; set; }
+        public CodeStatementCollection SetStatements { get; }
+        public CodeTypeReference Type { get; set; }
+    }
+    public class CodeMethodInvokeExpression : CodeExpression {
+        public CodeMethodInvokeExpression();
+        public CodeMethodInvokeExpression(CodeExpression targetObject, string methodName, params CodeExpression[] parameters);
+        public CodeMethodInvokeExpression(CodeMethodReferenceExpression method, params CodeExpression[] parameters);
+        public CodeMethodReferenceExpression Method { get; set; }
+        public CodeExpressionCollection Parameters { get; }
+    }
+    public class CodeMethodReferenceExpression : CodeExpression {
+        public CodeMethodReferenceExpression();
+        public CodeMethodReferenceExpression(CodeExpression targetObject, string methodName);
+        public CodeMethodReferenceExpression(CodeExpression targetObject, string methodName, params CodeTypeReference[] typeParameters);
+        public string MethodName { get; set; }
+        public CodeExpression TargetObject { get; set; }
+        public CodeTypeReferenceCollection TypeArguments { get; }
+    }
+    public class CodeMethodReturnStatement : CodeStatement {
+        public CodeMethodReturnStatement();
+        public CodeMethodReturnStatement(CodeExpression expression);
+        public CodeExpression Expression { get; set; }
+    }
+    public class CodeNamespace : CodeObject {
+        public CodeNamespace();
+        public CodeNamespace(string name);
+        public CodeCommentStatementCollection Comments { get; }
+        public CodeNamespaceImportCollection Imports { get; }
+        public string Name { get; set; }
+        public CodeTypeDeclarationCollection Types { get; }
+        public event EventHandler PopulateComments;
+        public event EventHandler PopulateImports;
+        public event EventHandler PopulateTypes;
+    }
+    public class CodeNamespaceCollection : CollectionBase {
+        public CodeNamespaceCollection();
+        public CodeNamespaceCollection(CodeNamespaceCollection value);
+        public CodeNamespaceCollection(CodeNamespace[] value);
+        public CodeNamespace this[int index] { get; set; }
+        public int Add(CodeNamespace value);
+        public void AddRange(CodeNamespaceCollection value);
+        public void AddRange(CodeNamespace[] value);
+        public bool Contains(CodeNamespace value);
+        public void CopyTo(CodeNamespace[] array, int index);
+        public int IndexOf(CodeNamespace value);
+        public void Insert(int index, CodeNamespace value);
+        public void Remove(CodeNamespace value);
+    }
+    public class CodeNamespaceImport : CodeObject {
+        public CodeNamespaceImport();
+        public CodeNamespaceImport(string nameSpace);
+        public CodeLinePragma LinePragma { get; set; }
+        public string Namespace { get; set; }
+    }
+    public class CodeNamespaceImportCollection : ICollection, IEnumerable, IList {
+        public CodeNamespaceImportCollection();
+        public int Count { get; }
+        int System.Collections.ICollection.Count { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public CodeNamespaceImport this[int index] { get; set; }
+        public void Add(CodeNamespaceImport value);
+        public void AddRange(CodeNamespaceImport[] value);
+        public void Clear();
+        public IEnumerator GetEnumerator();
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        void System.Collections.IList.Clear();
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        void System.Collections.IList.RemoveAt(int index);
+    }
+    public class CodeObject {
+        public CodeObject();
+        public IDictionary UserData { get; }
+    }
+    public class CodeObjectCreateExpression : CodeExpression {
+        public CodeObjectCreateExpression();
+        public CodeObjectCreateExpression(CodeTypeReference createType, params CodeExpression[] parameters);
+        public CodeObjectCreateExpression(string createType, params CodeExpression[] parameters);
+        public CodeObjectCreateExpression(Type createType, params CodeExpression[] parameters);
+        public CodeTypeReference CreateType { get; set; }
+        public CodeExpressionCollection Parameters { get; }
+    }
+    public class CodeParameterDeclarationExpression : CodeExpression {
+        public CodeParameterDeclarationExpression();
+        public CodeParameterDeclarationExpression(CodeTypeReference type, string name);
+        public CodeParameterDeclarationExpression(string type, string name);
+        public CodeParameterDeclarationExpression(Type type, string name);
+        public CodeAttributeDeclarationCollection CustomAttributes { get; set; }
+        public FieldDirection Direction { get; set; }
+        public string Name { get; set; }
+        public CodeTypeReference Type { get; set; }
+    }
+    public class CodeParameterDeclarationExpressionCollection : CollectionBase {
+        public CodeParameterDeclarationExpressionCollection();
+        public CodeParameterDeclarationExpressionCollection(CodeParameterDeclarationExpressionCollection value);
+        public CodeParameterDeclarationExpressionCollection(CodeParameterDeclarationExpression[] value);
+        public CodeParameterDeclarationExpression this[int index] { get; set; }
+        public int Add(CodeParameterDeclarationExpression value);
+        public void AddRange(CodeParameterDeclarationExpressionCollection value);
+        public void AddRange(CodeParameterDeclarationExpression[] value);
+        public bool Contains(CodeParameterDeclarationExpression value);
+        public void CopyTo(CodeParameterDeclarationExpression[] array, int index);
+        public int IndexOf(CodeParameterDeclarationExpression value);
+        public void Insert(int index, CodeParameterDeclarationExpression value);
+        public void Remove(CodeParameterDeclarationExpression value);
+    }
+    public class CodePrimitiveExpression : CodeExpression {
+        public CodePrimitiveExpression();
+        public CodePrimitiveExpression(object value);
+        public object Value { get; set; }
+    }
+    public class CodePropertyReferenceExpression : CodeExpression {
+        public CodePropertyReferenceExpression();
+        public CodePropertyReferenceExpression(CodeExpression targetObject, string propertyName);
+        public string PropertyName { get; set; }
+        public CodeExpression TargetObject { get; set; }
+    }
+    public class CodePropertySetValueReferenceExpression : CodeExpression {
+        public CodePropertySetValueReferenceExpression();
+    }
+    public class CodeRegionDirective : CodeDirective {
+        public CodeRegionDirective();
+        public CodeRegionDirective(CodeRegionMode regionMode, string regionText);
+        public CodeRegionMode RegionMode { get; set; }
+        public string RegionText { get; set; }
+    }
+    public enum CodeRegionMode {
+        End = 2,
+        None = 0,
+        Start = 1,
+    }
+    public class CodeRemoveEventStatement : CodeStatement {
+        public CodeRemoveEventStatement();
+        public CodeRemoveEventStatement(CodeEventReferenceExpression eventRef, CodeExpression listener);
+        public CodeRemoveEventStatement(CodeExpression targetObject, string eventName, CodeExpression listener);
+        public CodeEventReferenceExpression Event { get; set; }
+        public CodeExpression Listener { get; set; }
+    }
+    public class CodeSnippetCompileUnit : CodeCompileUnit {
+        public CodeSnippetCompileUnit();
+        public CodeSnippetCompileUnit(string value);
+        public CodeLinePragma LinePragma { get; set; }
+        public string Value { get; set; }
+    }
+    public class CodeSnippetExpression : CodeExpression {
+        public CodeSnippetExpression();
+        public CodeSnippetExpression(string value);
+        public string Value { get; set; }
+    }
+    public class CodeSnippetStatement : CodeStatement {
+        public CodeSnippetStatement();
+        public CodeSnippetStatement(string value);
+        public string Value { get; set; }
+    }
+    public class CodeSnippetTypeMember : CodeTypeMember {
+        public CodeSnippetTypeMember();
+        public CodeSnippetTypeMember(string text);
+        public string Text { get; set; }
+    }
+    public class CodeStatement : CodeObject {
+        public CodeStatement();
+        public CodeDirectiveCollection EndDirectives { get; }
+        public CodeLinePragma LinePragma { get; set; }
+        public CodeDirectiveCollection StartDirectives { get; }
+    }
+    public class CodeStatementCollection : CollectionBase {
+        public CodeStatementCollection();
+        public CodeStatementCollection(CodeStatementCollection value);
+        public CodeStatementCollection(CodeStatement[] value);
+        public CodeStatement this[int index] { get; set; }
+        public int Add(CodeExpression value);
+        public int Add(CodeStatement value);
+        public void AddRange(CodeStatementCollection value);
+        public void AddRange(CodeStatement[] value);
+        public bool Contains(CodeStatement value);
+        public void CopyTo(CodeStatement[] array, int index);
+        public int IndexOf(CodeStatement value);
+        public void Insert(int index, CodeStatement value);
+        public void Remove(CodeStatement value);
+    }
+    public class CodeThisReferenceExpression : CodeExpression {
+        public CodeThisReferenceExpression();
+    }
+    public class CodeThrowExceptionStatement : CodeStatement {
+        public CodeThrowExceptionStatement();
+        public CodeThrowExceptionStatement(CodeExpression toThrow);
+        public CodeExpression ToThrow { get; set; }
+    }
+    public class CodeTryCatchFinallyStatement : CodeStatement {
+        public CodeTryCatchFinallyStatement();
+        public CodeTryCatchFinallyStatement(CodeStatement[] tryStatements, CodeCatchClause[] catchClauses);
+        public CodeTryCatchFinallyStatement(CodeStatement[] tryStatements, CodeCatchClause[] catchClauses, CodeStatement[] finallyStatements);
+        public CodeCatchClauseCollection CatchClauses { get; }
+        public CodeStatementCollection FinallyStatements { get; }
+        public CodeStatementCollection TryStatements { get; }
+    }
+    public class CodeTypeConstructor : CodeMemberMethod {
+        public CodeTypeConstructor();
+    }
+    public class CodeTypeDeclaration : CodeTypeMember {
+        public CodeTypeDeclaration();
+        public CodeTypeDeclaration(string name);
+        public CodeTypeReferenceCollection BaseTypes { get; }
+        public bool IsClass { get; set; }
+        public bool IsEnum { get; set; }
+        public bool IsInterface { get; set; }
+        public bool IsPartial { get; set; }
+        public bool IsStruct { get; set; }
+        public CodeTypeMemberCollection Members { get; }
+        public TypeAttributes TypeAttributes { get; set; }
+        public CodeTypeParameterCollection TypeParameters { get; }
+        public event EventHandler PopulateBaseTypes;
+        public event EventHandler PopulateMembers;
+    }
+    public class CodeTypeDeclarationCollection : CollectionBase {
+        public CodeTypeDeclarationCollection();
+        public CodeTypeDeclarationCollection(CodeTypeDeclarationCollection value);
+        public CodeTypeDeclarationCollection(CodeTypeDeclaration[] value);
+        public CodeTypeDeclaration this[int index] { get; set; }
+        public int Add(CodeTypeDeclaration value);
+        public void AddRange(CodeTypeDeclarationCollection value);
+        public void AddRange(CodeTypeDeclaration[] value);
+        public bool Contains(CodeTypeDeclaration value);
+        public void CopyTo(CodeTypeDeclaration[] array, int index);
+        public int IndexOf(CodeTypeDeclaration value);
+        public void Insert(int index, CodeTypeDeclaration value);
+        public void Remove(CodeTypeDeclaration value);
+    }
+    public class CodeTypeDelegate : CodeTypeDeclaration {
+        public CodeTypeDelegate();
+        public CodeTypeDelegate(string name);
+        public CodeParameterDeclarationExpressionCollection Parameters { get; }
+        public CodeTypeReference ReturnType { get; set; }
+    }
+    public class CodeTypeMember : CodeObject {
+        public CodeTypeMember();
+        public MemberAttributes Attributes { get; set; }
+        public CodeCommentStatementCollection Comments { get; }
+        public CodeAttributeDeclarationCollection CustomAttributes { get; set; }
+        public CodeDirectiveCollection EndDirectives { get; }
+        public CodeLinePragma LinePragma { get; set; }
+        public string Name { get; set; }
+        public CodeDirectiveCollection StartDirectives { get; }
+    }
+    public class CodeTypeMemberCollection : CollectionBase {
+        public CodeTypeMemberCollection();
+        public CodeTypeMemberCollection(CodeTypeMemberCollection value);
+        public CodeTypeMemberCollection(CodeTypeMember[] value);
+        public CodeTypeMember this[int index] { get; set; }
+        public int Add(CodeTypeMember value);
+        public void AddRange(CodeTypeMemberCollection value);
+        public void AddRange(CodeTypeMember[] value);
+        public bool Contains(CodeTypeMember value);
+        public void CopyTo(CodeTypeMember[] array, int index);
+        public int IndexOf(CodeTypeMember value);
+        public void Insert(int index, CodeTypeMember value);
+        public void Remove(CodeTypeMember value);
+    }
+    public class CodeTypeOfExpression : CodeExpression {
+        public CodeTypeOfExpression();
+        public CodeTypeOfExpression(CodeTypeReference type);
+        public CodeTypeOfExpression(string type);
+        public CodeTypeOfExpression(Type type);
+        public CodeTypeReference Type { get; set; }
+    }
+    public class CodeTypeParameter : CodeObject {
+        public CodeTypeParameter();
+        public CodeTypeParameter(string name);
+        public CodeTypeReferenceCollection Constraints { get; }
+        public CodeAttributeDeclarationCollection CustomAttributes { get; }
+        public bool HasConstructorConstraint { get; set; }
+        public string Name { get; set; }
+    }
+    public class CodeTypeParameterCollection : CollectionBase {
+        public CodeTypeParameterCollection();
+        public CodeTypeParameterCollection(CodeTypeParameterCollection value);
+        public CodeTypeParameterCollection(CodeTypeParameter[] value);
+        public CodeTypeParameter this[int index] { get; set; }
+        public int Add(CodeTypeParameter value);
+        public void Add(string value);
+        public void AddRange(CodeTypeParameterCollection value);
+        public void AddRange(CodeTypeParameter[] value);
+        public bool Contains(CodeTypeParameter value);
+        public void CopyTo(CodeTypeParameter[] array, int index);
+        public int IndexOf(CodeTypeParameter value);
+        public void Insert(int index, CodeTypeParameter value);
+        public void Remove(CodeTypeParameter value);
+    }
+    public class CodeTypeReference : CodeObject {
+        public CodeTypeReference();
+        public CodeTypeReference(CodeTypeParameter typeParameter);
+        public CodeTypeReference(CodeTypeReference arrayType, int rank);
+        public CodeTypeReference(string typeName);
+        public CodeTypeReference(string typeName, CodeTypeReferenceOptions codeTypeReferenceOption);
+        public CodeTypeReference(string typeName, params CodeTypeReference[] typeArguments);
+        public CodeTypeReference(string baseType, int rank);
+        public CodeTypeReference(Type type);
+        public CodeTypeReference(Type type, CodeTypeReferenceOptions codeTypeReferenceOption);
+        public CodeTypeReference ArrayElementType { get; set; }
+        public int ArrayRank { get; set; }
+        public string BaseType { get; set; }
+        public CodeTypeReferenceOptions Options { get; set; }
+        public CodeTypeReferenceCollection TypeArguments { get; }
+    }
+    public class CodeTypeReferenceCollection : CollectionBase {
+        public CodeTypeReferenceCollection();
+        public CodeTypeReferenceCollection(CodeTypeReferenceCollection value);
+        public CodeTypeReferenceCollection(CodeTypeReference[] value);
+        public CodeTypeReference this[int index] { get; set; }
+        public int Add(CodeTypeReference value);
+        public void Add(string value);
+        public void Add(Type value);
+        public void AddRange(CodeTypeReferenceCollection value);
+        public void AddRange(CodeTypeReference[] value);
+        public bool Contains(CodeTypeReference value);
+        public void CopyTo(CodeTypeReference[] array, int index);
+        public int IndexOf(CodeTypeReference value);
+        public void Insert(int index, CodeTypeReference value);
+        public void Remove(CodeTypeReference value);
+    }
+    public class CodeTypeReferenceExpression : CodeExpression {
+        public CodeTypeReferenceExpression();
+        public CodeTypeReferenceExpression(CodeTypeReference type);
+        public CodeTypeReferenceExpression(string type);
+        public CodeTypeReferenceExpression(Type type);
+        public CodeTypeReference Type { get; set; }
+    }
+    public enum CodeTypeReferenceOptions {
+        GenericTypeParameter = 2,
+        GlobalReference = 1,
+    }
+    public class CodeVariableDeclarationStatement : CodeStatement {
+        public CodeVariableDeclarationStatement();
+        public CodeVariableDeclarationStatement(CodeTypeReference type, string name);
+        public CodeVariableDeclarationStatement(CodeTypeReference type, string name, CodeExpression initExpression);
+        public CodeVariableDeclarationStatement(string type, string name);
+        public CodeVariableDeclarationStatement(string type, string name, CodeExpression initExpression);
+        public CodeVariableDeclarationStatement(Type type, string name);
+        public CodeVariableDeclarationStatement(Type type, string name, CodeExpression initExpression);
+        public CodeExpression InitExpression { get; set; }
+        public string Name { get; set; }
+        public CodeTypeReference Type { get; set; }
+    }
+    public class CodeVariableReferenceExpression : CodeExpression {
+        public CodeVariableReferenceExpression();
+        public CodeVariableReferenceExpression(string variableName);
+        public string VariableName { get; set; }
+    }
+    public enum FieldDirection {
+        In = 0,
+        Out = 1,
+        Ref = 2,
+    }
+    public enum MemberAttributes {
+        Abstract = 1,
+        AccessMask = 61440,
+        Assembly = 4096,
+        Const = 5,
+        Family = 12288,
+        FamilyAndAssembly = 8192,
+        FamilyOrAssembly = 16384,
+        Final = 2,
+        New = 16,
+        Overloaded = 256,
+        Override = 4,
+        Private = 20480,
+        Public = 24576,
+        ScopeMask = 15,
+        Static = 3,
+        VTableMask = 240,
+    }
+}
```

