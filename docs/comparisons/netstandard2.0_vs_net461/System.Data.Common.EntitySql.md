# System.Data.Common.EntitySql

``` diff
+namespace System.Data.Common.EntitySql {
+    public sealed class EntitySqlParser {
+        public ParseResult Parse(string query, params DbParameterReferenceExpression[] parameters);
+        public DbLambda ParseLambda(string query, params DbVariableReferenceExpression[] variables);
+    }
+    public sealed class FunctionDefinition {
+        public int EndPosition { get; }
+        public DbLambda Lambda { get; }
+        public string Name { get; }
+        public int StartPosition { get; }
+    }
+    public sealed class ParseResult {
+        public DbCommandTree CommandTree { get; }
+        public ReadOnlyCollection<FunctionDefinition> FunctionDefinitions { get; }
+    }
+}
```

