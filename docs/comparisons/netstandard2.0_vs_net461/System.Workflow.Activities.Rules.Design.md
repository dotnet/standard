# System.Workflow.Activities.Rules.Design

``` diff
+namespace System.Workflow.Activities.Rules.Design {
+    public class RuleConditionDialog : Form {
+        public RuleConditionDialog(Type activityType, ITypeProvider typeProvider, CodeExpression expression);
+        public RuleConditionDialog(Activity activity, CodeExpression expression);
+        public CodeExpression Expression { get; }
+        protected override void Dispose(bool disposing);
+    }
+    public class RuleSetDialog : Form {
+        public RuleSetDialog(Type activityType, ITypeProvider typeProvider, RuleSet ruleSet);
+        public RuleSetDialog(Activity activity, RuleSet ruleSet);
+        public RuleSet RuleSet { get; }
+        protected override void Dispose(bool disposing);
+        protected override bool ProcessCmdKey(ref Message msg, Keys keyData);
+    }
+}
```

