# System.Linq.Expressions

``` diff
 namespace System.Linq.Expressions {
     public sealed class Expression<TDelegate> : LambdaExpression {
-        public new TDelegate Compile(bool preferInterpretation);

     }
     public abstract class LambdaExpression : Expression {
-        public Delegate Compile(bool preferInterpretation);

+        public void CompileToMethod(MethodBuilder method);
+        public void CompileToMethod(MethodBuilder method, DebugInfoGenerator debugInfoGenerator);
     }
 }
```

