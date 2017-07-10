# System.Activities.ExpressionParser

``` diff
+namespace System.Activities.ExpressionParser {
+    public class SourceExpressionException : Exception, ISerializable {
+        public SourceExpressionException();
+        protected SourceExpressionException(SerializationInfo info, StreamingContext context);
+        public SourceExpressionException(string message);
+        public SourceExpressionException(string message, CompilerErrorCollection errors);
+        public SourceExpressionException(string message, Exception innerException);
+        public IEnumerable<CompilerError> Errors { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+}
```

