# Microsoft.VisualBasic.Activities

``` diff
+namespace Microsoft.VisualBasic.Activities {
+    public static class VisualBasic {
+        public static VisualBasicSettings GetSettings(object target);
+        public static void SetSettings(object target, VisualBasicSettings value);
+        public static void SetSettingsForImplementation(object target, VisualBasicSettings value);
+        public static bool ShouldSerializeSettings(object target);
+    }
+    public static class VisualBasicDesignerHelper {
+        public static Constraint NameShadowingConstraint { get; }
+        public static Activity CreatePrecompiledVisualBasicReference(Type targetType, string expressionText, IEnumerable<string> namespaces, IEnumerable<string> referencedAssemblies, LocationReferenceEnvironment environment, out Type returnType, out SourceExpressionException compileError, out VisualBasicSettings vbSettings);
+        public static Activity CreatePrecompiledVisualBasicValue(Type targetType, string expressionText, IEnumerable<string> namespaces, IEnumerable<string> referencedAssemblies, LocationReferenceEnvironment environment, out Type returnType, out SourceExpressionException compileError, out VisualBasicSettings vbSettings);
+        public static Activity RecompileVisualBasicReference(ActivityWithResult visualBasicReference, out Type returnType, out SourceExpressionException compileError, out VisualBasicSettings vbSettings);
+        public static Activity RecompileVisualBasicValue(ActivityWithResult visualBasicValue, out Type returnType, out SourceExpressionException compileError, out VisualBasicSettings vbSettings);
+    }
+    public class VisualBasicImportReference : IEquatable<VisualBasicImportReference> {
+        public VisualBasicImportReference();
+        public string Assembly { get; set; }
+        public string Import { get; set; }
+        public bool Equals(VisualBasicImportReference other);
+        public override int GetHashCode();
+    }
+    public sealed class VisualBasicReference<TResult> : CodeActivity<Location<TResult>>, IExpressionContainer, ITextExpression, IValueSerializableExpression {
+        public VisualBasicReference();
+        public VisualBasicReference(string expressionText);
+        public string ExpressionText { get; set; }
+        public string Language { get; }
+        public bool RequiresCompilation { get; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        public bool CanConvertToString(IValueSerializerContext context);
+        public string ConvertToString(IValueSerializerContext context);
+        protected override Location<TResult> Execute(CodeActivityContext context);
+        public Expression GetExpressionTree();
+    }
+    public class VisualBasicSettings {
+        public VisualBasicSettings();
+        public static VisualBasicSettings Default { get; }
+        public ISet<VisualBasicImportReference> ImportReferences { get; private set; }
+    }
+    public sealed class VisualBasicValue<TResult> : CodeActivity<TResult>, IExpressionContainer, ITextExpression, IValueSerializableExpression {
+        public VisualBasicValue();
+        public VisualBasicValue(string expressionText);
+        public string ExpressionText { get; set; }
+        public string Language { get; }
+        public bool RequiresCompilation { get; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        public bool CanConvertToString(IValueSerializerContext context);
+        public string ConvertToString(IValueSerializerContext context);
+        protected override TResult Execute(CodeActivityContext context);
+        public Expression GetExpressionTree();
+    }
+}
```

