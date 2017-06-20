# System.Activities.Debugger

``` diff
+namespace System.Activities.Debugger {
+    public class DebugInfo
+    public interface IDebuggableWorkflowTree {
+        Activity GetWorkflowRoot();
+    }
+    public class LocalsItemDescription {
+        public LocalsItemDescription(string name, Type type);
+        public string Name { get; private set; }
+        public Type Type { get; private set; }
+        public override string ToString();
+    }
+    public class SourceLocation {
+        public SourceLocation(string fileName, int line);
+        public SourceLocation(string fileName, int startLine, int startColumn, int endLine, int endColumn);
+        public int EndColumn { get; }
+        public int EndLine { get; }
+        public string FileName { get; }
+        public bool IsSingleWholeLine { get; }
+        public int StartColumn { get; }
+        public int StartLine { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+    }
+    public sealed class SourceLocationFoundEventArgs : EventArgs {
+        public SourceLocationFoundEventArgs(object target, SourceLocation sourceLocation);
+        public SourceLocation SourceLocation { get; }
+        public object Target { get; }
+    }
+    public static class SourceLocationProvider {
+        public static void CollectMapping(Activity rootActivity1, Activity rootActivity2, Dictionary<object, SourceLocation> mapping, string path);
+        public static Dictionary<object, SourceLocation> GetSourceLocations(Activity rootActivity, WorkflowSymbol symbol);
+        public static ICollection<ActivitySymbol> GetSymbols(Activity rootActivity, Dictionary<object, SourceLocation> sourceLocations);
+    }
+    public class State
+    public sealed class StateManager : IDisposable {
+        public void Dispose();
+        public void Exit(int threadIndex);
+    }
+    public class ThreadWorkerController {
+        public ThreadWorkerController();
+        public static void IslandWorker(ThreadWorkerController controller);
+    }
+    public class VirtualStackFrame {
+        public VirtualStackFrame(State state);
+        public VirtualStackFrame(State state, IDictionary<string, object> locals);
+        public IDictionary<string, object> Locals { get; }
+        public State State { get; }
+        public override string ToString();
+    }
+    public class XamlDebuggerXmlReader : XamlReader, IXamlLineInfo {
+        public static readonly AttachableMemberIdentifier EndColumnName;
+        public static readonly AttachableMemberIdentifier EndLineName;
+        public static readonly AttachableMemberIdentifier FileNameName;
+        public static readonly AttachableMemberIdentifier StartColumnName;
+        public static readonly AttachableMemberIdentifier StartLineName;
+        public XamlDebuggerXmlReader(TextReader underlyingTextReader);
+        public XamlDebuggerXmlReader(TextReader underlyingTextReader, XamlSchemaContext schemaContext);
+        public XamlDebuggerXmlReader(XamlReader underlyingReader, TextReader textReader);
+        public XamlDebuggerXmlReader(XamlReader underlyingReader, IXamlLineInfo xamlLineInfo, TextReader textReader);
+        public bool CollectNonActivitySourceLocation { get; set; }
+        public bool HasLineInfo { get; }
+        public override bool IsEof { get; }
+        public int LineNumber { get; }
+        public int LinePosition { get; }
+        public override XamlMember Member { get; }
+        public override NamespaceDeclaration Namespace { get; }
+        public override XamlNodeType NodeType { get; }
+        public override XamlSchemaContext SchemaContext { get; }
+        public override XamlType Type { get; }
+        public override object Value { get; }
+        public event EventHandler<SourceLocationFoundEventArgs> SourceLocationFound;
+        public static void CopyAttachedSourceLocation(object source, object destination);
+        protected override void Dispose(bool disposing);
+        public static object GetEndColumn(object instance);
+        public static object GetEndLine(object instance);
+        public static object GetFileName(object instance);
+        public static object GetStartColumn(object instance);
+        public static object GetStartLine(object instance);
+        public override bool Read();
+        public static void SetEndColumn(object instance, object value);
+        public static void SetEndLine(object instance, object value);
+        public static void SetFileName(object instance, object value);
+        public static void SetStartColumn(object instance, object value);
+        public static void SetStartLine(object instance, object value);
+    }
+}
```

