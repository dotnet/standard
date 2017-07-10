# System.Runtime.CompilerServices

``` diff
 namespace System.Runtime.CompilerServices {
+    public static class CallSiteOps {
+        public static void AddRule<T>(CallSite<T> site, T rule) where T : class;
+        public static T Bind<T>(CallSiteBinder binder, CallSite<T> site, object[] args) where T : class;
+        public static void ClearMatch(CallSite site);
+        public static CallSite<T> CreateMatchmaker<T>(CallSite<T> site) where T : class;
+        public static T[] GetCachedRules<T>(RuleCache<T> cache) where T : class;
+        public static bool GetMatch(CallSite site);
+        public static RuleCache<T> GetRuleCache<T>(CallSite<T> site) where T : class;
+        public static T[] GetRules<T>(CallSite<T> site) where T : class;
+        public static void MoveRule<T>(RuleCache<T> cache, T rule, int i) where T : class;
+        public static bool SetNotMatched(CallSite site);
+        public static void UpdateRules<T>(CallSite<T> @this, int matched) where T : class;
+    }
+    public sealed class Closure {
+        public readonly object[] Constants;
+        public readonly object[] Locals;
+        public Closure(object[] constants, object[] locals);
+    }
     public sealed class ConditionalWeakTable<TKey, TValue> where TKey : class where TValue : class {
+        ~ConditionalWeakTable();
     }
+    public class ExecutionScope {
+        public object[] Globals;
+        public object[] Locals;
+        public ExecutionScope Parent;
+        public Delegate CreateDelegate(int indexLambda, object[] locals);
+        public object[] CreateHoistedLocals();
+        public Expression IsolateExpression(Expression expression, object[] locals);
+    }
+    public sealed class IDispatchConstantAttribute : CustomConstantAttribute {
+        public IDispatchConstantAttribute();
+        public override object Value { get; }
+    }
+    public static class RuntimeOps {
+        public static IRuntimeVariables CreateRuntimeVariables();
+        public static IRuntimeVariables CreateRuntimeVariables(object[] data, long[] indexes);
+        public static bool ExpandoCheckVersion(ExpandoObject expando, object version);
+        public static void ExpandoPromoteClass(ExpandoObject expando, object oldClass, object newClass);
+        public static bool ExpandoTryDeleteValue(ExpandoObject expando, object indexClass, int index, string name, bool ignoreCase);
+        public static bool ExpandoTryGetValue(ExpandoObject expando, object indexClass, int index, string name, bool ignoreCase, out object value);
+        public static object ExpandoTrySetValue(ExpandoObject expando, object indexClass, int index, object value, string name, bool ignoreCase);
+        public static IRuntimeVariables MergeRuntimeVariables(IRuntimeVariables first, IRuntimeVariables second, int[] indexes);
+        public static Expression Quote(Expression expression, object hoistedLocals, object[] locals);
+    }
-    public sealed class TupleElementNamesAttribute : Attribute {
 {
-        public TupleElementNamesAttribute(string[] transformNames);

-        public IList<string> TransformNames { get; }

-    }
 }
```

