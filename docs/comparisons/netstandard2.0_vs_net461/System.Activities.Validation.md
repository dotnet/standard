# System.Activities.Validation

``` diff
+namespace System.Activities.Validation {
+    public static class ActivityValidationServices {
+        public static Activity Resolve(Activity root, string id);
+        public static ValidationResults Validate(Activity toValidate);
+        public static ValidationResults Validate(Activity toValidate, ValidationSettings settings);
+    }
+    public sealed class AddValidationError : NativeActivity {
+        public AddValidationError();
+        public InArgument<bool> IsWarning { get; set; }
+        public InArgument<string> Message { get; set; }
+        public InArgument<string> PropertyName { get; set; }
+        protected override void CacheMetadata(NativeActivityMetadata metadata);
+        protected override void Execute(NativeActivityContext context);
+    }
+    public sealed class AssertValidation : NativeActivity {
+        public AssertValidation();
+        public InArgument<bool> Assertion { get; set; }
+        public InArgument<bool> IsWarning { get; set; }
+        public InArgument<string> Message { get; set; }
+        public InArgument<string> PropertyName { get; set; }
+        protected override void CacheMetadata(NativeActivityMetadata metadata);
+        protected override void Execute(NativeActivityContext context);
+    }
+    public abstract class Constraint : NativeActivity {
+        public const string ValidationErrorListPropertyName = "System.Activities.Validation.Constraint.ValidationErrorList";
+        public static void AddValidationError(NativeActivityContext context, ValidationError error);
+        protected override void CacheMetadata(NativeActivityMetadata metadata);
+        protected override void Execute(NativeActivityContext context);
+        protected abstract void OnExecute(NativeActivityContext context, object objectToValidate, ValidationContext objectToValidateContext);
+    }
+    public sealed class Constraint<T> : Constraint {
+        public Constraint();
+        public ActivityAction<T, ValidationContext> Body { get; set; }
+        protected override void CacheMetadata(NativeActivityMetadata metadata);
+        protected override void OnExecute(NativeActivityContext context, object objectToValidate, ValidationContext objectToValidateContext);
+    }
+    public sealed class GetChildSubtree : CodeActivity<IEnumerable<Activity>> {
+        public GetChildSubtree();
+        public InArgument<ValidationContext> ValidationContext { get; set; }
+        protected override IEnumerable<Activity> Execute(CodeActivityContext context);
+    }
+    public sealed class GetParentChain : CodeActivity<IEnumerable<Activity>> {
+        public GetParentChain();
+        public InArgument<ValidationContext> ValidationContext { get; set; }
+        protected override IEnumerable<Activity> Execute(CodeActivityContext context);
+    }
+    public sealed class GetWorkflowTree : CodeActivity<IEnumerable<Activity>> {
+        public GetWorkflowTree();
+        public InArgument<ValidationContext> ValidationContext { get; set; }
+        protected override IEnumerable<Activity> Execute(CodeActivityContext context);
+    }
+    public sealed class ValidationContext
+    public class ValidationError {
+        public ValidationError(string message);
+        public ValidationError(string message, bool isWarning);
+        public ValidationError(string message, bool isWarning, string propertyName);
+        public ValidationError(string message, bool isWarning, string propertyName, object sourceDetail);
+        public string Id { get; internal set; }
+        public bool IsWarning { get; private set; }
+        public string Message { get; internal set; }
+        public string PropertyName { get; private set; }
+        public Activity Source { get; internal set; }
+        public object SourceDetail { get; internal set; }
+        public override string ToString();
+    }
+    public class ValidationResults {
+        public ValidationResults(IList<ValidationError> allValidationErrors);
+        public ReadOnlyCollection<ValidationError> Errors { get; }
+        public ReadOnlyCollection<ValidationError> Warnings { get; }
+    }
+    public class ValidationSettings {
+        public ValidationSettings();
+        public IDictionary<Type, IList<Constraint>> AdditionalConstraints { get; }
+        public CancellationToken CancellationToken { get; set; }
+        public LocationReferenceEnvironment Environment { get; set; }
+        public bool OnlyUseAdditionalConstraints { get; set; }
+        public bool PrepareForRuntime { get; set; }
+        public bool SingleLevel { get; set; }
+        public bool SkipValidatingRootConfiguration { get; set; }
+    }
+}
```

