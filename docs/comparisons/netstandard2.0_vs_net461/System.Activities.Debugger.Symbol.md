# System.Activities.Debugger.Symbol

``` diff
+namespace System.Activities.Debugger.Symbol {
+    public class ActivitySymbol {
+        public int EndColumn { get; internal set; }
+        public int EndLine { get; internal set; }
+        public string Id { get; }
+        public int StartColumn { get; internal set; }
+        public int StartLine { get; internal set; }
+        public override string ToString();
+    }
+    public static class DebugSymbol {
+        public static readonly AttachableMemberIdentifier SymbolName;
+        public static object GetSymbol(object instance);
+        public static void SetSymbol(object instance, object value);
+    }
+    public class WorkflowSymbol {
+        public WorkflowSymbol();
+        public string FileName { get; set; }
+        public ICollection<ActivitySymbol> Symbols { get; set; }
+        public bool CalculateChecksum();
+        public static WorkflowSymbol Decode(string symbolString);
+        public string Encode();
+        public byte[] GetChecksum();
+        public override string ToString();
+    }
+}
```

