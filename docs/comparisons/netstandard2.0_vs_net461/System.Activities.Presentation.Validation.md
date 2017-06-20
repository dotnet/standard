# System.Activities.Presentation.Validation

``` diff
+namespace System.Activities.Presentation.Validation {
+    public interface IValidationErrorService {
+        void ShowValidationErrors(IList<ValidationErrorInfo> errors);
+    }
+    public class ValidationErrorInfo {
+        public ValidationErrorInfo(ValidationError validationError);
+        public ValidationErrorInfo(string message);
+        public string FileName { get; set; }
+        public string Id { get; private set; }
+        public bool IsWarning { get; private set; }
+        public string Message { get; private set; }
+        public string PropertyName { get; private set; }
+        public Guid SourceReferenceId { get; set; }
+    }
+    public class ValidationService {
+        public ValidationService(EditingContext context);
+        public ValidationSettings Settings { get; }
+        public void NavigateToError(ValidationErrorInfo validationErrorInfo);
+        public void NavigateToError(string id);
+        protected virtual void OnValidationCompleted();
+        public void ValidateWorkflow();
+    }
+    public enum ValidationState {
+        ChildInvalid = 1,
+        Error = 3,
+        Valid = 0,
+        Warning = 2,
+    }
+}
```

