# Microsoft.CSharp.Activities

``` diff
+namespace Microsoft.CSharp.Activities {
+    public class CSharpReference<TResult> : CodeActivity<Location<TResult>>, ITextExpression {
+        public CSharpReference();
+        public CSharpReference(string expressionText);
+        public string ExpressionText { get; set; }
+        public string Language { get; }
+        public bool RequiresCompilation { get; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override Location<TResult> Execute(CodeActivityContext context);
+        public Expression GetExpressionTree();
+    }
+    public class CSharpValue<TResult> : CodeActivity<TResult>, ITextExpression {
+        public CSharpValue();
+        public CSharpValue(string expressionText);
+        public string ExpressionText { get; set; }
+        public string Language { get; }
+        public bool RequiresCompilation { get; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override TResult Execute(CodeActivityContext context);
+        public Expression GetExpressionTree();
+    }
+}
```

