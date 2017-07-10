# System.Activities.Presentation.Expressions

``` diff
+namespace System.Activities.Presentation.Expressions {
+    public delegate ActivityWithResult CreateExpressionFromStringCallback(string expressionText, bool useLocationExpression, Type expressionType);
+    public abstract class ExpressionActivityEditor : UserControl {
+        public static readonly DependencyProperty AcceptsReturnProperty;
+        public static readonly DependencyProperty AcceptsTabProperty;
+        public static readonly DependencyProperty ExplicitCommitProperty;
+        public static readonly DependencyProperty ExpressionProperty;
+        public static readonly DependencyProperty ExpressionTypeProperty;
+        public static readonly DependencyProperty HintTextProperty;
+        public static readonly DependencyProperty HorizontalScrollBarVisibilityProperty;
+        public static readonly DependencyProperty IsIndependentExpressionProperty;
+        public static readonly DependencyProperty IsReadOnlyProperty;
+        public static readonly DependencyProperty IsSupportedExpressionProperty;
+        public static readonly DependencyProperty OwnerActivityProperty;
+        public static readonly DependencyProperty PathToArgumentProperty;
+        public static readonly DependencyProperty UseLocationExpressionProperty;
+        public static readonly DependencyProperty VerticalScrollBarVisibilityProperty;
+        protected ExpressionActivityEditor();
+        public bool AcceptsReturn { get; set; }
+        public bool AcceptsTab { get; set; }
+        protected EditingContext Context { get; }
+        public bool ExplicitCommit { get; set; }
+        public ModelItem Expression { get; set; }
+        public Type ExpressionType { get; set; }
+        public string HintText { get; set; }
+        public ScrollBarVisibility HorizontalScrollBarVisibility { get; set; }
+        public bool IsIndependentExpression { get; set; }
+        public bool IsReadOnly { get; set; }
+        public bool IsSupportedExpression { get; set; }
+        public ModelItem OwnerActivity { get; set; }
+        public string PathToArgument { get; set; }
+        public bool UseLocationExpression { get; set; }
+        public ScrollBarVisibility VerticalScrollBarVisibility { get; set; }
+        public virtual void BeginEdit();
+        public virtual bool CanCommit();
+        public abstract bool Commit(bool isExplicitCommit);
+        public static string GetExpressionActivityEditor(object target);
+        public static void SetExpressionActivityEditor(object target, string name);
+    }
+    public abstract class ExpressionMorphHelper {
+        protected ExpressionMorphHelper();
+        public virtual bool TryInferReturnType(ActivityWithResult expression, EditingContext context, out Type returnType);
+        public abstract bool TryMorphExpression(ActivityWithResult expression, bool isLocationExpression, Type newType, EditingContext context, out ActivityWithResult newExpression);
+    }
+    public sealed class ExpressionMorphHelperAttribute : Attribute {
+        public ExpressionMorphHelperAttribute(Type expressionMorphHelperType);
+        public Type ExpressionMorphHelperType { get; }
+    }
+    public abstract class TextualExpressionEditor : ExpressionActivityEditor {
+        public static readonly DependencyProperty DefaultValueProperty;
+        public static readonly DependencyProperty MaxLinesProperty;
+        public static readonly DependencyProperty MinLinesProperty;
+        protected TextualExpressionEditor();
+        public string DefaultValue { get; set; }
+        public virtual IExpressionEditorService ExpressionEditorService { get; }
+        public int MaxLines { get; set; }
+        public int MinLines { get; set; }
+        public virtual void OnCompleteWordCommandCanExecute(CanExecuteRoutedEventArgs e);
+        public virtual void OnCompleteWordCommandExecute(ExecutedRoutedEventArgs e);
+        public virtual void OnDecreaseFilterLevelCommandCanExecute(CanExecuteRoutedEventArgs e);
+        public virtual void OnDecreaseFilterLevelCommandExecute(ExecutedRoutedEventArgs e);
+        public virtual void OnGlobalIntellisenseCommandCanExecute(CanExecuteRoutedEventArgs e);
+        public virtual void OnGlobalIntellisenseCommandExecute(ExecutedRoutedEventArgs e);
+        public virtual void OnIncreaseFilterLevelCommandCanExecute(CanExecuteRoutedEventArgs e);
+        public virtual void OnIncreaseFilterLevelCommandExecute(ExecutedRoutedEventArgs e);
+        public virtual void OnParameterInfoCommandCanExecute(CanExecuteRoutedEventArgs e);
+        public virtual void OnParameterInfoCommandExecute(ExecutedRoutedEventArgs e);
+        public virtual void OnQuickInfoCommandCanExecute(CanExecuteRoutedEventArgs e);
+        public virtual void OnQuickInfoCommandExecute(ExecutedRoutedEventArgs e);
+    }
+}
```

