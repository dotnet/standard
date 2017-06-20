# System.Diagnostics.SymbolStore

``` diff
 namespace System.Diagnostics.SymbolStore {
+    public class SymBinder : SymBinderBase, IDisposable, ISymbolBinder, ISymbolBinder1 {
+        public SymBinder();
+        public sealed override void Dispose();
+        protected virtual void Dispose(bool A_0);
+        ~SymBinder();
+        public virtual ISymbolReader GetReader(int importer, string filename, string searchPath);
+        public virtual ISymbolReader GetReader(IntPtr importer, string filename, string searchPath);
+    }
+    public class SymBinderBase {
+        protected SymBinderBase();
+        public void {dtor}();
+    }
+    public class SymDocument : SymDocumentBase, IDisposable, ISymbolDocument {
+        public unsafe SymDocument(ISymUnmanagedDocument* pDocument);
+        public virtual Guid CheckSumAlgorithmId { get; }
+        public virtual Guid DocumentType { get; }
+        public virtual bool HasEmbeddedSource { get; }
+        public virtual Guid Language { get; }
+        public virtual Guid LanguageVendor { get; }
+        public virtual int SourceLength { get; }
+        public virtual string URL { get; }
+        public sealed override void Dispose();
+        protected virtual void Dispose(bool A_0);
+        ~SymDocument();
+        public virtual int FindClosestLine(int line);
+        public virtual byte[] GetCheckSum();
+        public virtual byte[] GetSourceRange(int startLine, int startColumn, int endLine, int endColumn);
+        public unsafe ISymUnmanagedDocument* GetUnmanaged();
+    }
+    public class SymDocumentBase {
+        protected SymDocumentBase();
+        public void {dtor}();
+    }
+    public class SymDocumentWriter : SymDocumentWriterBase, IDisposable, ISymbolDocumentWriter {
+        public unsafe SymDocumentWriter(ISymUnmanagedDocumentWriter* pDocumentWriter);
+        public sealed override void Dispose();
+        protected virtual void Dispose(bool A_0);
+        ~SymDocumentWriter();
+        public unsafe ISymUnmanagedDocumentWriter* GetUnmanaged();
+        public virtual void SetCheckSum(Guid algorithmId, byte[] source);
+        public virtual void SetSource(byte[] source);
+    }
+    public class SymDocumentWriterBase {
+        protected SymDocumentWriterBase();
+        public void {dtor}();
+    }
+    public class SymMethod : SymMethodBase, IDisposable, ISymbolMethod {
+        public unsafe SymMethod(ISymUnmanagedMethod* pMethod);
+        public virtual ISymbolScope RootScope { get; }
+        public virtual int SequencePointCount { get; }
+        public virtual SymbolToken Token { get; }
+        public sealed override void Dispose();
+        protected virtual void Dispose(bool A_0);
+        ~SymMethod();
+        public virtual ISymbolNamespace GetNamespace();
+        public virtual int GetOffset(ISymbolDocument document, int line, int column);
+        public virtual ISymbolVariable[] GetParameters();
+        public virtual int[] GetRanges(ISymbolDocument document, int line, int column);
+        public virtual ISymbolScope GetScope(int offset);
+        public virtual void GetSequencePoints(int[] offsets, ISymbolDocument[] documents, int[] lines, int[] columns, int[] endLines, int[] endColumns);
+        public virtual bool GetSourceStartEnd(ISymbolDocument[] docs, int[] lines, int[] columns);
+        public virtual ISymbolScope RootScopeInternal();
+    }
+    public class SymMethodBase {
+        protected SymMethodBase();
+        public void {dtor}();
+    }
+    public class SymReader : SymReaderBase, IDisposable, ISymbolReader {
+        public unsafe SymReader(ISymUnmanagedReader* pReader);
+        public virtual SymbolToken UserEntryPoint { get; }
+        public sealed override void Dispose();
+        protected virtual void Dispose(bool A_0);
+        ~SymReader();
+        public virtual ISymbolDocument GetDocument(string url, Guid language, Guid languageVendor, Guid documentType);
+        public virtual ISymbolDocument[] GetDocuments();
+        public virtual ISymbolVariable[] GetGlobalVariables();
+        public virtual ISymbolMethod GetMethod(SymbolToken method);
+        public virtual ISymbolMethod GetMethod(SymbolToken method, int version);
+        public virtual ISymbolMethod GetMethodFromDocumentPosition(ISymbolDocument document, int line, int column);
+        public virtual ISymbolNamespace[] GetNamespaces();
+        public virtual byte[] GetSymAttribute(SymbolToken parent, string name);
+        public virtual ISymbolVariable[] GetVariables(SymbolToken parent);
+        public virtual void ReplaceSymbolStore(string fileName, IntPtr stream);
+        public virtual void UpdateSymbolStore(string fileName, IntPtr stream);
+    }
+    public class SymReaderBase {
+        protected SymReaderBase();
+        public void {dtor}();
+    }
+    public class SymScope : SymScopeBase, IDisposable, ISymbolScope {
+        public unsafe SymScope(ISymUnmanagedScope* pScope);
+        public virtual int EndOffset { get; }
+        public virtual ISymbolMethod Method { get; }
+        public virtual ISymbolScope Parent { get; }
+        public virtual int StartOffset { get; }
+        public sealed override void Dispose();
+        protected virtual void Dispose(bool A_0);
+        ~SymScope();
+        public virtual ISymbolScope[] GetChildren();
+        public virtual ISymbolVariable[] GetLocals();
+        public virtual ISymbolNamespace[] GetNamespaces();
+    }
+    public class SymScopeBase {
+        protected SymScopeBase();
+        public void {dtor}();
+    }
+    public class SymVariable : SymVariableBase, IDisposable, ISymbolVariable {
+        public unsafe SymVariable(ISymUnmanagedVariable* pVariable);
+        public virtual int AddressField1 { get; }
+        public virtual int AddressField2 { get; }
+        public virtual int AddressField3 { get; }
+        public virtual SymAddressKind AddressKind { get; }
+        public virtual object Attributes { get; }
+        public virtual int EndOffset { get; }
+        public virtual string Name { get; }
+        public virtual int StartOffset { get; }
+        public sealed override void Dispose();
+        protected virtual void Dispose(bool A_0);
+        ~SymVariable();
+        public virtual byte[] GetSignature();
+    }
+    public class SymVariableBase {
+        protected SymVariableBase();
+        public void {dtor}();
+    }
+    public class SymWriter : SymWriterBase, IDisposable, ISymbolWriter {
+        public SymWriter();
+        public SymWriter(bool noUnderlyingWriter);
+        public virtual void Close();
+        public virtual void CloseMethod();
+        public virtual void CloseNamespace();
+        public virtual void CloseScope(int endOffset);
+        public virtual ISymbolDocumentWriter DefineDocument(string url, Guid language, Guid languageVendor, Guid documentType);
+        public virtual void DefineField(SymbolToken parent, string name, FieldAttributes attributes, byte[] signature, SymAddressKind addrKind, int addr1, int addr2, int addr3);
+        public virtual void DefineGlobalVariable(string name, FieldAttributes attributes, byte[] signature, SymAddressKind addrKind, int addr1, int addr2, int addr3);
+        public virtual void DefineLocalVariable(string name, FieldAttributes attributes, byte[] signature, SymAddressKind addrKind, int addr1, int addr2, int addr3, int startOffset, int endOffset);
+        public virtual void DefineParameter(string name, ParameterAttributes attributes, int sequence, SymAddressKind addrKind, int addr1, int addr2, int addr3);
+        public virtual void DefineSequencePoints(ISymbolDocumentWriter document, int[] offsets, int[] lines, int[] columns, int[] endLines, int[] endColumns);
+        public sealed override void Dispose();
+        protected virtual void Dispose(bool A_0);
+        ~SymWriter();
+        public unsafe ISymUnmanagedWriter* GetWriter();
+        public virtual void Initialize(IntPtr emitter, string filename, bool fFullBuild);
+        public void InitWriter(bool noUnderlyingWriter);
+        public virtual void OpenMethod(SymbolToken method);
+        public virtual void OpenNamespace(string name);
+        public virtual int OpenScope(int startOffset);
+        public virtual void SetMethodSourceRange(ISymbolDocumentWriter startDoc, int startLine, int startColumn, ISymbolDocumentWriter endDoc, int endLine, int endColumn);
+        public virtual void SetScopeRange(int scopeID, int startOffset, int endOffset);
+        public virtual void SetSymAttribute(SymbolToken parent, string name, byte[] data);
+        public virtual void SetUnderlyingWriter(IntPtr underlyingWriter);
+        public virtual void SetUserEntryPoint(SymbolToken entryMethod);
+        public virtual void UsingNamespace(string fullName);
+    }
+    public class SymWriterBase {
+        protected SymWriterBase();
+        public void {dtor}();
+    }
 }
```

