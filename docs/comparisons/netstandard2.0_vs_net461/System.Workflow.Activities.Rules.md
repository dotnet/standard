# System.Workflow.Activities.Rules

``` diff
+namespace System.Workflow.Activities.Rules {
+    public sealed class AddedConditionAction : RuleConditionChangeAction {
+        public AddedConditionAction();
+        public AddedConditionAction(RuleCondition addedConditionDefinition);
+        public RuleCondition ConditionDefinition { get; set; }
+        public override string ConditionName { get; }
+        protected override bool ApplyTo(Activity rootActivity);
+    }
+    public sealed class AddedRuleSetAction : RuleSetChangeAction {
+        public AddedRuleSetAction();
+        public AddedRuleSetAction(RuleSet addedRuleSetDefinition);
+        public RuleSet RuleSetDefinition { get; set; }
+        public override string RuleSetName { get; }
+        protected override bool ApplyTo(Activity rootActivity);
+    }
+    public interface IRuleExpression {
+        void AnalyzeUsage(RuleAnalysis analysis, bool isRead, bool isWritten, RulePathQualifier qualifier);
+        CodeExpression Clone();
+        void Decompile(StringBuilder stringBuilder, CodeExpression parentExpression);
+        RuleExpressionResult Evaluate(RuleExecution execution);
+        bool Match(CodeExpression expression);
+        RuleExpressionInfo Validate(RuleValidation validation, bool isWritten);
+    }
+    public sealed class RemovedConditionAction : RuleConditionChangeAction {
+        public RemovedConditionAction();
+        public RemovedConditionAction(RuleCondition removedConditionDefinition);
+        public RuleCondition ConditionDefinition { get; set; }
+        public override string ConditionName { get; }
+        protected override bool ApplyTo(Activity rootActivity);
+    }
+    public sealed class RemovedRuleSetAction : RuleSetChangeAction {
+        public RemovedRuleSetAction();
+        public RemovedRuleSetAction(RuleSet removedRuleSetDefinition);
+        public RuleSet RuleSetDefinition { get; set; }
+        public override string RuleSetName { get; }
+        protected override bool ApplyTo(Activity rootActivity);
+    }
+    public class Rule {
+        public Rule();
+        public Rule(string name);
+        public Rule(string name, RuleCondition condition, IList<RuleAction> thenActions);
+        public Rule(string name, RuleCondition condition, IList<RuleAction> thenActions, IList<RuleAction> elseActions);
+        public bool Active { get; set; }
+        public RuleCondition Condition { get; set; }
+        public string Description { get; set; }
+        public IList<RuleAction> ElseActions { get; }
+        public string Name { get; set; }
+        public int Priority { get; set; }
+        public RuleReevaluationBehavior ReevaluationBehavior { get; set; }
+        public IList<RuleAction> ThenActions { get; }
+        public Rule Clone();
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+    }
+    public abstract class RuleAction {
+        protected RuleAction();
+        public abstract RuleAction Clone();
+        public abstract void Execute(RuleExecution context);
+        public abstract ICollection<string> GetSideEffects(RuleValidation validation);
+        public abstract bool Validate(RuleValidation validator);
+    }
+    public class RuleActionTrackingEvent {
+        public bool ConditionResult { get; }
+        public string RuleName { get; }
+    }
+    public class RuleAnalysis {
+        public RuleAnalysis(RuleValidation validation, bool forWrites);
+        public bool ForWrites { get; }
+        public void AddSymbol(string symbol);
+        public ICollection<string> GetSymbols();
+    }
+    public abstract class RuleAttribute : Attribute {
+        protected RuleAttribute();
+    }
+    public enum RuleAttributeTarget {
+        Parameter = 0,
+        This = 1,
+    }
+    public enum RuleChainingBehavior {
+        Full = 2,
+        None = 0,
+        UpdateOnly = 1,
+    }
+    public abstract class RuleCondition {
+        protected RuleCondition();
+        public abstract string Name { get; set; }
+        public abstract RuleCondition Clone();
+        public abstract bool Evaluate(RuleExecution execution);
+        public abstract ICollection<string> GetDependencies(RuleValidation validation);
+        public virtual void OnRuntimeInitialized();
+        public abstract bool Validate(RuleValidation validation);
+    }
+    public abstract class RuleConditionChangeAction : WorkflowChangeAction {
+        protected RuleConditionChangeAction();
+        public abstract string ConditionName { get; }
+        protected override ValidationErrorCollection ValidateChanges(Activity activity);
+    }
+    public sealed class RuleConditionCollection : KeyedCollection<string, RuleCondition>, IWorkflowChangeDiff {
+        public RuleConditionCollection();
+        public new void Add(RuleCondition item);
+        public IList<WorkflowChangeAction> Diff(object originalDefinition, object changedDefinition);
+        protected override string GetKeyForItem(RuleCondition item);
+        protected override void InsertItem(int index, RuleCondition item);
+        protected override void RemoveItem(int index);
+        protected override void SetItem(int index, RuleCondition item);
+    }
+    public class RuleConditionReference : ActivityCondition {
+        public RuleConditionReference();
+        public string ConditionName { get; set; }
+        public override bool Evaluate(Activity activity, IServiceProvider provider);
+        protected override void InitializeProperties();
+    }
+    public sealed class RuleDefinitions : IWorkflowChangeDiff {
+        public static readonly DependencyProperty RuleDefinitionsProperty;
+        public RuleDefinitions();
+        public RuleConditionCollection Conditions { get; }
+        public RuleSetCollection RuleSets { get; }
+        public IList<WorkflowChangeAction> Diff(object originalDefinition, object changedDefinition);
+    }
+    public class RuleEngine {
+        public RuleEngine(RuleSet ruleSet, Type objectType);
+        public RuleEngine(RuleSet ruleSet, RuleValidation validation);
+        public void Execute(object thisObject);
+        public void Execute(object thisObject, ActivityExecutionContext executionContext);
+    }
+    public class RuleEvaluationException : RuleException, ISerializable {
+        public RuleEvaluationException();
+        protected RuleEvaluationException(SerializationInfo serializeInfo, StreamingContext context);
+        public RuleEvaluationException(string message);
+        public RuleEvaluationException(string message, Exception ex);
+    }
+    public class RuleEvaluationIncompatibleTypesException : RuleException, ISerializable {
+        public RuleEvaluationIncompatibleTypesException();
+        protected RuleEvaluationIncompatibleTypesException(SerializationInfo serializeInfo, StreamingContext context);
+        public RuleEvaluationIncompatibleTypesException(string message);
+        public RuleEvaluationIncompatibleTypesException(string message, Exception ex);
+        public RuleEvaluationIncompatibleTypesException(string message, Type left, CodeBinaryOperatorType op, Type right);
+        public RuleEvaluationIncompatibleTypesException(string message, Type left, CodeBinaryOperatorType op, Type right, Exception ex);
+        public Type Left { get; set; }
+        public CodeBinaryOperatorType Operator { get; set; }
+        public Type Right { get; set; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class RuleException : Exception, ISerializable {
+        public RuleException();
+        protected RuleException(SerializationInfo serializeInfo, StreamingContext context);
+        public RuleException(string message);
+        public RuleException(string message, Exception ex);
+    }
+    public class RuleExecution {
+        public RuleExecution(RuleValidation validation, object thisObject);
+        public RuleExecution(RuleValidation validation, object thisObject, ActivityExecutionContext activityExecutionContext);
+        public Activity Activity { get; }
+        public ActivityExecutionContext ActivityExecutionContext { get; }
+        public bool Halted { get; set; }
+        public object ThisObject { get; }
+        public RuleValidation Validation { get; set; }
+    }
+    public sealed class RuleExpressionCondition : RuleCondition {
+        public RuleExpressionCondition();
+        public RuleExpressionCondition(CodeExpression expression);
+        public RuleExpressionCondition(string conditionName);
+        public RuleExpressionCondition(string conditionName, CodeExpression expression);
+        public CodeExpression Expression { get; set; }
+        public override string Name { get; set; }
+        public override RuleCondition Clone();
+        public override bool Equals(object obj);
+        public override bool Evaluate(RuleExecution execution);
+        public override ICollection<string> GetDependencies(RuleValidation validation);
+        public override int GetHashCode();
+        public override void OnRuntimeInitialized();
+        public override string ToString();
+        public override bool Validate(RuleValidation validation);
+    }
+    public class RuleExpressionInfo {
+        public RuleExpressionInfo(Type expressionType);
+        public Type ExpressionType { get; }
+    }
+    public abstract class RuleExpressionResult {
+        protected RuleExpressionResult();
+        public abstract object Value { get; set; }
+    }
+    public static class RuleExpressionWalker {
+        public static void AnalyzeUsage(RuleAnalysis analysis, CodeExpression expression, bool isRead, bool isWritten, RulePathQualifier qualifier);
+        public static CodeExpression Clone(CodeExpression originalExpression);
+        public static void Decompile(StringBuilder stringBuilder, CodeExpression expression, CodeExpression parentExpression);
+        public static RuleExpressionResult Evaluate(RuleExecution execution, CodeExpression expression);
+        public static bool Match(CodeExpression firstExpression, CodeExpression secondExpression);
+        public static RuleExpressionInfo Validate(RuleValidation validation, CodeExpression expression, bool isWritten);
+    }
+    public class RuleHaltAction : RuleAction {
+        public RuleHaltAction();
+        public override RuleAction Clone();
+        public override bool Equals(object obj);
+        public override void Execute(RuleExecution context);
+        public override int GetHashCode();
+        public override ICollection<string> GetSideEffects(RuleValidation validation);
+        public override string ToString();
+        public override bool Validate(RuleValidation validator);
+    }
+    public sealed class RuleInvokeAttribute : RuleAttribute {
+        public RuleInvokeAttribute(string methodInvoked);
+        public string MethodInvoked { get; }
+    }
+    public class RuleLiteralResult : RuleExpressionResult {
+        public RuleLiteralResult(object literal);
+        public override object Value { get; set; }
+    }
+    public class RulePathQualifier {
+        public RulePathQualifier(string name, RulePathQualifier next);
+        public string Name { get; }
+        public RulePathQualifier Next { get; }
+    }
+    public sealed class RuleReadAttribute : RuleReadWriteAttribute {
+        public RuleReadAttribute(string path);
+        public RuleReadAttribute(string path, RuleAttributeTarget target);
+    }
+    public abstract class RuleReadWriteAttribute : RuleAttribute {
+        protected RuleReadWriteAttribute(string path, RuleAttributeTarget target);
+        public string Path { get; }
+        public RuleAttributeTarget Target { get; }
+    }
+    public enum RuleReevaluationBehavior {
+        Always = 1,
+        Never = 0,
+    }
+    public class RuleSet {
+        public RuleSet();
+        public RuleSet(string name);
+        public RuleSet(string name, string description);
+        public RuleChainingBehavior ChainingBehavior { get; set; }
+        public string Description { get; set; }
+        public string Name { get; set; }
+        public ICollection<Rule> Rules { get; }
+        public RuleSet Clone();
+        public override bool Equals(object obj);
+        public void Execute(RuleExecution ruleExecution);
+        public override int GetHashCode();
+        public bool Validate(RuleValidation validation);
+    }
+    public abstract class RuleSetChangeAction : WorkflowChangeAction {
+        protected RuleSetChangeAction();
+        public abstract string RuleSetName { get; }
+        protected override ValidationErrorCollection ValidateChanges(Activity activity);
+    }
+    public sealed class RuleSetCollection : KeyedCollection<string, RuleSet>, IWorkflowChangeDiff {
+        public RuleSetCollection();
+        public new void Add(RuleSet item);
+        public IList<WorkflowChangeAction> Diff(object originalDefinition, object changedDefinition);
+        protected override string GetKeyForItem(RuleSet item);
+        protected override void InsertItem(int index, RuleSet item);
+        protected override void RemoveItem(int index);
+        protected override void SetItem(int index, RuleSet item);
+    }
+    public sealed class RuleSetReference : DependencyObject {
+        public RuleSetReference();
+        public RuleSetReference(string ruleSetName);
+        public string RuleSetName { get; set; }
+        protected override void InitializeProperties();
+    }
+    public class RuleSetValidationException : RuleException, ISerializable {
+        public RuleSetValidationException();
+        protected RuleSetValidationException(SerializationInfo serializeInfo, StreamingContext context);
+        public RuleSetValidationException(string message);
+        public RuleSetValidationException(string message, Exception ex);
+        public RuleSetValidationException(string message, ValidationErrorCollection errors);
+        public ValidationErrorCollection Errors { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class RuleStatementAction : RuleAction {
+        public RuleStatementAction();
+        public RuleStatementAction(CodeExpression codeDomExpression);
+        public RuleStatementAction(CodeStatement codeDomStatement);
+        public CodeStatement CodeDomStatement { get; set; }
+        public override RuleAction Clone();
+        public override bool Equals(object obj);
+        public override void Execute(RuleExecution context);
+        public override int GetHashCode();
+        public override ICollection<string> GetSideEffects(RuleValidation validation);
+        public override string ToString();
+        public override bool Validate(RuleValidation validator);
+    }
+    public class RuleUpdateAction : RuleAction {
+        public RuleUpdateAction();
+        public RuleUpdateAction(string path);
+        public string Path { get; set; }
+        public override RuleAction Clone();
+        public override bool Equals(object obj);
+        public override void Execute(RuleExecution context);
+        public override int GetHashCode();
+        public override ICollection<string> GetSideEffects(RuleValidation validation);
+        public override string ToString();
+        public override bool Validate(RuleValidation validator);
+    }
+    public class RuleValidation {
+        public RuleValidation(Type thisType, ITypeProvider typeProvider);
+        public RuleValidation(Activity activity, ITypeProvider typeProvider, bool checkStaticType);
+        public ValidationErrorCollection Errors { get; }
+        public Type ThisType { get; }
+        public RuleExpressionInfo ExpressionInfo(CodeExpression expression);
+        public void PopParentExpression();
+        public bool PushParentExpression(CodeExpression newParent);
+    }
+    public sealed class RuleWriteAttribute : RuleReadWriteAttribute {
+        public RuleWriteAttribute(string path);
+        public RuleWriteAttribute(string path, RuleAttributeTarget target);
+    }
+    public sealed class UpdatedConditionAction : RuleConditionChangeAction {
+        public UpdatedConditionAction();
+        public UpdatedConditionAction(RuleCondition conditionDefinition, RuleCondition newConditionDefinition);
+        public RuleCondition ConditionDefinition { get; set; }
+        public override string ConditionName { get; }
+        public RuleCondition NewConditionDefinition { get; set; }
+        protected override bool ApplyTo(Activity rootActivity);
+    }
+    public sealed class UpdatedRuleSetAction : RuleSetChangeAction {
+        public UpdatedRuleSetAction();
+        public UpdatedRuleSetAction(RuleSet originalRuleSetDefinition, RuleSet updatedRuleSetDefinition);
+        public RuleSet OriginalRuleSetDefinition { get; set; }
+        public override string RuleSetName { get; }
+        public RuleSet UpdatedRuleSetDefinition { get; set; }
+        protected override bool ApplyTo(Activity rootActivity);
+    }
+}
```

