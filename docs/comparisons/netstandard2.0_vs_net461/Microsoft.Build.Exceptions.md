# Microsoft.Build.Exceptions

``` diff
+namespace Microsoft.Build.Exceptions {
+    public class BuildAbortedException : Exception {
+        public BuildAbortedException();
+        protected BuildAbortedException(SerializationInfo info, StreamingContext context);
+        public BuildAbortedException(string message);
+        public BuildAbortedException(string message, Exception innerException);
+        public string ErrorCode { get; private set; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public sealed class InternalLoggerException : Exception {
+        public InternalLoggerException();
+        public InternalLoggerException(string message);
+        public InternalLoggerException(string message, Exception innerException);
+        public BuildEventArgs BuildEventArgs { get; }
+        public string ErrorCode { get; }
+        public string HelpKeyword { get; }
+        public bool InitializationException { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public sealed class InvalidProjectFileException : Exception {
+        public InvalidProjectFileException();
+        public InvalidProjectFileException(string message);
+        public InvalidProjectFileException(string message, Exception innerException);
+        public InvalidProjectFileException(string projectFile, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string errorSubcategory, string errorCode, string helpKeyword);
+        public string BaseMessage { get; }
+        public int ColumnNumber { get; }
+        public int EndColumnNumber { get; }
+        public int EndLineNumber { get; }
+        public string ErrorCode { get; }
+        public string ErrorSubcategory { get; }
+        public bool HasBeenLogged { get; internal set; }
+        public string HelpKeyword { get; }
+        public int LineNumber { get; }
+        public override string Message { get; }
+        public string ProjectFile { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class InvalidToolsetDefinitionException : Exception {
+        public InvalidToolsetDefinitionException();
+        protected InvalidToolsetDefinitionException(SerializationInfo info, StreamingContext context);
+        public InvalidToolsetDefinitionException(string message);
+        public InvalidToolsetDefinitionException(string message, Exception innerException);
+        public InvalidToolsetDefinitionException(string message, string errorCode);
+        public InvalidToolsetDefinitionException(string message, string errorCode, Exception innerException);
+        public string ErrorCode { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+}
```

