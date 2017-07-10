# System.Linq.Expressions

``` diff
 namespace System.Linq.Expressions {
+    public class DynamicExpression : Expression, IArgumentProvider, IDynamicExpression {
+        public ReadOnlyCollection<Expression> Arguments { get; }
+        public CallSiteBinder Binder { get; }
+        public Type DelegateType { get; }
+        public sealed override ExpressionType NodeType { get; }
+        int System.Linq.Expressions.IArgumentProvider.ArgumentCount { get; }
+        public override Type Type { get; }
+        protected override Expression Accept(ExpressionVisitor visitor);
+        public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, IEnumerable<Expression> arguments);
+        public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression arg0);
+        public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression arg0, Expression arg1);
+        public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression arg0, Expression arg1, Expression arg2);
+        public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression arg0, Expression arg1, Expression arg2, Expression arg3);
+        public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, params Expression[] arguments);
+        public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, IEnumerable<Expression> arguments);
+        public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0);
+        public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1);
+        public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2);
+        public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2, Expression arg3);
+        public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, params Expression[] arguments);
+        Expression System.Linq.Expressions.IArgumentProvider.GetArgument(int index);
+        object System.Linq.Expressions.IDynamicExpression.CreateCallSite();
+        Expression System.Linq.Expressions.IDynamicExpression.Rewrite(Expression[] args);
+        public DynamicExpression Update(IEnumerable<Expression> arguments);
+    }
+    public abstract class DynamicExpressionVisitor : ExpressionVisitor {
+        protected DynamicExpressionVisitor();
+        protected virtual Expression VisitDynamic(DynamicExpression node);
+    }
 }
```

