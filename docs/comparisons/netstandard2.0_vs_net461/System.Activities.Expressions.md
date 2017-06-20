# System.Activities.Expressions

``` diff
+namespace System.Activities.Expressions {
+    public sealed class Add<TLeft, TRight, TResult> : CodeActivity<TResult> {
+        public Add();
+        public bool Checked { get; set; }
+        public InArgument<TLeft> Left { get; set; }
+        public InArgument<TRight> Right { get; set; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override TResult Execute(CodeActivityContext context);
+    }
+    public sealed class And<TLeft, TRight, TResult> : CodeActivity<TResult> {
+        public And();
+        public InArgument<TLeft> Left { get; set; }
+        public InArgument<TRight> Right { get; set; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override TResult Execute(CodeActivityContext context);
+    }
+    public sealed class AndAlso : Activity<bool> {
+        public AndAlso();
+        public Activity<bool> Left { get; set; }
+        public Activity<bool> Right { get; set; }
+        protected override void CacheMetadata(ActivityMetadata metadata);
+        protected override void OnCreateDynamicUpdateMap(UpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class ArgumentReference<T> : EnvironmentLocationReference<T> {
+        public ArgumentReference();
+        public ArgumentReference(string argumentName);
+        public string ArgumentName { get; set; }
+        public override LocationReference LocationReference { get; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        public override string ToString();
+    }
+    public sealed class ArgumentValue<T> : EnvironmentLocationValue<T> {
+        public ArgumentValue();
+        public ArgumentValue(string argumentName);
+        public string ArgumentName { get; set; }
+        public override LocationReference LocationReference { get; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        public override string ToString();
+    }
+    public sealed class ArrayItemReference<TItem> : CodeActivity<Location<TItem>> {
+        public ArrayItemReference();
+        public InArgument<TItem[]> Array { get; set; }
+        public InArgument<int> Index { get; set; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override Location<TItem> Execute(CodeActivityContext context);
+    }
+    public sealed class ArrayItemValue<TItem> : CodeActivity<TItem> {
+        public ArrayItemValue();
+        public InArgument<TItem[]> Array { get; set; }
+        public InArgument<int> Index { get; set; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override TItem Execute(CodeActivityContext context);
+    }
+    public sealed class As<TOperand, TResult> : CodeActivity<TResult> {
+        public As();
+        public InArgument<TOperand> Operand { get; set; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override TResult Execute(CodeActivityContext context);
+    }
+    public class AssemblyReference {
+        public AssemblyReference();
+        public Assembly Assembly { get; set; }
+        public AssemblyName AssemblyName { get; set; }
+        public void LoadAssembly();
+        public static implicit operator AssemblyReference (Assembly assembly);
+        public static implicit operator AssemblyReference (AssemblyName assemblyName);
+    }
+    public sealed class Cast<TOperand, TResult> : CodeActivity<TResult> {
+        public Cast();
+        public bool Checked { get; set; }
+        public InArgument<TOperand> Operand { get; set; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override TResult Execute(CodeActivityContext context);
+    }
+    public class CompiledExpressionInvoker {
+        public CompiledExpressionInvoker(ITextExpression expression, bool isReference, CodeActivityMetadata metadata);
+        public bool IsStaticallyCompiled { get; private set; }
+        public static object GetCompiledExpressionRoot(object target);
+        public static object GetCompiledExpressionRootForImplementation(object target);
+        public object InvokeExpression(ActivityContext activityContext);
+        public static void SetCompiledExpressionRoot(object target, ICompiledExpressionRoot compiledExpressionRoot);
+        public static void SetCompiledExpressionRootForImplementation(object target, ICompiledExpressionRoot compiledExpressionRoot);
+    }
+    public sealed class DelegateArgumentReference<T> : EnvironmentLocationReference<T> {
+        public DelegateArgumentReference();
+        public DelegateArgumentReference(DelegateArgument delegateArgument);
+        public DelegateArgument DelegateArgument { get; set; }
+        public override LocationReference LocationReference { get; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+    }
+    public sealed class DelegateArgumentValue<T> : EnvironmentLocationValue<T> {
+        public DelegateArgumentValue();
+        public DelegateArgumentValue(DelegateArgument delegateArgument);
+        public DelegateArgument DelegateArgument { get; set; }
+        public override LocationReference LocationReference { get; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+    }
+    public sealed class Divide<TLeft, TRight, TResult> : CodeActivity<TResult> {
+        public Divide();
+        public InArgument<TLeft> Left { get; set; }
+        public InArgument<TRight> Right { get; set; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override TResult Execute(CodeActivityContext context);
+    }
+    public class EnvironmentLocationReference<T> : CodeActivity<Location<T>>, IExpressionContainer, ILocationReferenceExpression {
+        public virtual LocationReference LocationReference { get; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected sealed override Location<T> Execute(CodeActivityContext context);
+    }
+    public class EnvironmentLocationValue<T> : CodeActivity<T>, IExpressionContainer, ILocationReferenceExpression {
+        public virtual LocationReference LocationReference { get; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override T Execute(CodeActivityContext context);
+    }
+    public sealed class Equal<TLeft, TRight, TResult> : CodeActivity<TResult> {
+        public Equal();
+        public InArgument<TLeft> Left { get; set; }
+        public InArgument<TRight> Right { get; set; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override TResult Execute(CodeActivityContext context);
+    }
+    public static class ExpressionServices {
+        public static Activity<TResult> Convert<TResult>(Expression<Func<ActivityContext, TResult>> expression);
+        public static Activity<Location<TResult>> ConvertReference<TResult>(Expression<Func<ActivityContext, TResult>> expression);
+        public static bool TryConvert<TResult>(Expression<Func<ActivityContext, TResult>> expression, out Activity<TResult> result);
+        public static bool TryConvertReference<TResult>(Expression<Func<ActivityContext, TResult>> expression, out Activity<Location<TResult>> result);
+    }
+    public sealed class FieldReference<TOperand, TResult> : CodeActivity<Location<TResult>> {
+        public FieldReference();
+        public string FieldName { get; set; }
+        public InArgument<TOperand> Operand { get; set; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override Location<TResult> Execute(CodeActivityContext context);
+    }
+    public sealed class FieldValue<TOperand, TResult> : CodeActivity<TResult> {
+        public FieldValue();
+        public string FieldName { get; set; }
+        public InArgument<TOperand> Operand { get; set; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override TResult Execute(CodeActivityContext context);
+    }
+    public sealed class GreaterThan<TLeft, TRight, TResult> : CodeActivity<TResult> {
+        public GreaterThan();
+        public InArgument<TLeft> Left { get; set; }
+        public InArgument<TRight> Right { get; set; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override TResult Execute(CodeActivityContext context);
+    }
+    public sealed class GreaterThanOrEqual<TLeft, TRight, TResult> : CodeActivity<TResult> {
+        public GreaterThanOrEqual();
+        public InArgument<TLeft> Left { get; set; }
+        public InArgument<TRight> Right { get; set; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override TResult Execute(CodeActivityContext context);
+    }
+    public sealed class IndexerReference<TOperand, TItem> : CodeActivity<Location<TItem>> {
+        public IndexerReference();
+        public Collection<InArgument> Indices { get; }
+        public InArgument<TOperand> Operand { get; set; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override Location<TItem> Execute(CodeActivityContext context);
+    }
+    public sealed class InvokeFunc<TResult> : NativeActivity<TResult> {
+        public InvokeFunc();
+        public ActivityFunc<TResult> Func { get; set; }
+        protected override void Execute(NativeActivityContext context);
+    }
+    public sealed class InvokeFunc<T, TResult> : NativeActivity<TResult> {
+        public InvokeFunc();
+        public InArgument<T> Argument { get; set; }
+        public ActivityFunc<T, TResult> Func { get; set; }
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class InvokeFunc<T1, T2, TResult> : NativeActivity<TResult> {
+        public InvokeFunc();
+        public InArgument<T1> Argument1 { get; set; }
+        public InArgument<T2> Argument2 { get; set; }
+        public ActivityFunc<T1, T2, TResult> Func { get; set; }
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class InvokeFunc<T1, T2, T3, TResult> : NativeActivity<TResult> {
+        public InvokeFunc();
+        public InArgument<T1> Argument1 { get; set; }
+        public InArgument<T2> Argument2 { get; set; }
+        public InArgument<T3> Argument3 { get; set; }
+        public ActivityFunc<T1, T2, T3, TResult> Func { get; set; }
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class InvokeFunc<T1, T2, T3, T4, TResult> : NativeActivity<TResult> {
+        public InvokeFunc();
+        public InArgument<T1> Argument1 { get; set; }
+        public InArgument<T2> Argument2 { get; set; }
+        public InArgument<T3> Argument3 { get; set; }
+        public InArgument<T4> Argument4 { get; set; }
+        public ActivityFunc<T1, T2, T3, T4, TResult> Func { get; set; }
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class InvokeFunc<T1, T2, T3, T4, T5, TResult> : NativeActivity<TResult> {
+        public InvokeFunc();
+        public InArgument<T1> Argument1 { get; set; }
+        public InArgument<T2> Argument2 { get; set; }
+        public InArgument<T3> Argument3 { get; set; }
+        public InArgument<T4> Argument4 { get; set; }
+        public InArgument<T5> Argument5 { get; set; }
+        public ActivityFunc<T1, T2, T3, T4, T5, TResult> Func { get; set; }
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class InvokeFunc<T1, T2, T3, T4, T5, T6, TResult> : NativeActivity<TResult> {
+        public InvokeFunc();
+        public InArgument<T1> Argument1 { get; set; }
+        public InArgument<T2> Argument2 { get; set; }
+        public InArgument<T3> Argument3 { get; set; }
+        public InArgument<T4> Argument4 { get; set; }
+        public InArgument<T5> Argument5 { get; set; }
+        public InArgument<T6> Argument6 { get; set; }
+        public ActivityFunc<T1, T2, T3, T4, T5, T6, TResult> Func { get; set; }
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class InvokeFunc<T1, T2, T3, T4, T5, T6, T7, TResult> : NativeActivity<TResult> {
+        public InvokeFunc();
+        public InArgument<T1> Argument1 { get; set; }
+        public InArgument<T2> Argument2 { get; set; }
+        public InArgument<T3> Argument3 { get; set; }
+        public InArgument<T4> Argument4 { get; set; }
+        public InArgument<T5> Argument5 { get; set; }
+        public InArgument<T6> Argument6 { get; set; }
+        public InArgument<T7> Argument7 { get; set; }
+        public ActivityFunc<T1, T2, T3, T4, T5, T6, T7, TResult> Func { get; set; }
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class InvokeFunc<T1, T2, T3, T4, T5, T6, T7, T8, TResult> : NativeActivity<TResult> {
+        public InvokeFunc();
+        public InArgument<T1> Argument1 { get; set; }
+        public InArgument<T2> Argument2 { get; set; }
+        public InArgument<T3> Argument3 { get; set; }
+        public InArgument<T4> Argument4 { get; set; }
+        public InArgument<T5> Argument5 { get; set; }
+        public InArgument<T6> Argument6 { get; set; }
+        public InArgument<T7> Argument7 { get; set; }
+        public InArgument<T8> Argument8 { get; set; }
+        public ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, TResult> Func { get; set; }
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class InvokeFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> : NativeActivity<TResult> {
+        public InvokeFunc();
+        public InArgument<T1> Argument1 { get; set; }
+        public InArgument<T2> Argument2 { get; set; }
+        public InArgument<T3> Argument3 { get; set; }
+        public InArgument<T4> Argument4 { get; set; }
+        public InArgument<T5> Argument5 { get; set; }
+        public InArgument<T6> Argument6 { get; set; }
+        public InArgument<T7> Argument7 { get; set; }
+        public InArgument<T8> Argument8 { get; set; }
+        public InArgument<T9> Argument9 { get; set; }
+        public ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> Func { get; set; }
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class InvokeFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> : NativeActivity<TResult> {
+        public InvokeFunc();
+        public InArgument<T1> Argument1 { get; set; }
+        public InArgument<T10> Argument10 { get; set; }
+        public InArgument<T2> Argument2 { get; set; }
+        public InArgument<T3> Argument3 { get; set; }
+        public InArgument<T4> Argument4 { get; set; }
+        public InArgument<T5> Argument5 { get; set; }
+        public InArgument<T6> Argument6 { get; set; }
+        public InArgument<T7> Argument7 { get; set; }
+        public InArgument<T8> Argument8 { get; set; }
+        public InArgument<T9> Argument9 { get; set; }
+        public ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Func { get; set; }
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class InvokeFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> : NativeActivity<TResult> {
+        public InvokeFunc();
+        public InArgument<T1> Argument1 { get; set; }
+        public InArgument<T10> Argument10 { get; set; }
+        public InArgument<T11> Argument11 { get; set; }
+        public InArgument<T2> Argument2 { get; set; }
+        public InArgument<T3> Argument3 { get; set; }
+        public InArgument<T4> Argument4 { get; set; }
+        public InArgument<T5> Argument5 { get; set; }
+        public InArgument<T6> Argument6 { get; set; }
+        public InArgument<T7> Argument7 { get; set; }
+        public InArgument<T8> Argument8 { get; set; }
+        public InArgument<T9> Argument9 { get; set; }
+        public ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Func { get; set; }
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class InvokeFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> : NativeActivity<TResult> {
+        public InvokeFunc();
+        public InArgument<T1> Argument1 { get; set; }
+        public InArgument<T10> Argument10 { get; set; }
+        public InArgument<T11> Argument11 { get; set; }
+        public InArgument<T12> Argument12 { get; set; }
+        public InArgument<T2> Argument2 { get; set; }
+        public InArgument<T3> Argument3 { get; set; }
+        public InArgument<T4> Argument4 { get; set; }
+        public InArgument<T5> Argument5 { get; set; }
+        public InArgument<T6> Argument6 { get; set; }
+        public InArgument<T7> Argument7 { get; set; }
+        public InArgument<T8> Argument8 { get; set; }
+        public InArgument<T9> Argument9 { get; set; }
+        public ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Func { get; set; }
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class InvokeFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> : NativeActivity<TResult> {
+        public InvokeFunc();
+        public InArgument<T1> Argument1 { get; set; }
+        public InArgument<T10> Argument10 { get; set; }
+        public InArgument<T11> Argument11 { get; set; }
+        public InArgument<T12> Argument12 { get; set; }
+        public InArgument<T13> Argument13 { get; set; }
+        public InArgument<T2> Argument2 { get; set; }
+        public InArgument<T3> Argument3 { get; set; }
+        public InArgument<T4> Argument4 { get; set; }
+        public InArgument<T5> Argument5 { get; set; }
+        public InArgument<T6> Argument6 { get; set; }
+        public InArgument<T7> Argument7 { get; set; }
+        public InArgument<T8> Argument8 { get; set; }
+        public InArgument<T9> Argument9 { get; set; }
+        public ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Func { get; set; }
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class InvokeFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> : NativeActivity<TResult> {
+        public InvokeFunc();
+        public InArgument<T1> Argument1 { get; set; }
+        public InArgument<T10> Argument10 { get; set; }
+        public InArgument<T11> Argument11 { get; set; }
+        public InArgument<T12> Argument12 { get; set; }
+        public InArgument<T13> Argument13 { get; set; }
+        public InArgument<T14> Argument14 { get; set; }
+        public InArgument<T2> Argument2 { get; set; }
+        public InArgument<T3> Argument3 { get; set; }
+        public InArgument<T4> Argument4 { get; set; }
+        public InArgument<T5> Argument5 { get; set; }
+        public InArgument<T6> Argument6 { get; set; }
+        public InArgument<T7> Argument7 { get; set; }
+        public InArgument<T8> Argument8 { get; set; }
+        public InArgument<T9> Argument9 { get; set; }
+        public ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Func { get; set; }
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class InvokeFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> : NativeActivity<TResult> {
+        public InvokeFunc();
+        public InArgument<T1> Argument1 { get; set; }
+        public InArgument<T10> Argument10 { get; set; }
+        public InArgument<T11> Argument11 { get; set; }
+        public InArgument<T12> Argument12 { get; set; }
+        public InArgument<T13> Argument13 { get; set; }
+        public InArgument<T14> Argument14 { get; set; }
+        public InArgument<T15> Argument15 { get; set; }
+        public InArgument<T2> Argument2 { get; set; }
+        public InArgument<T3> Argument3 { get; set; }
+        public InArgument<T4> Argument4 { get; set; }
+        public InArgument<T5> Argument5 { get; set; }
+        public InArgument<T6> Argument6 { get; set; }
+        public InArgument<T7> Argument7 { get; set; }
+        public InArgument<T8> Argument8 { get; set; }
+        public InArgument<T9> Argument9 { get; set; }
+        public ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Func { get; set; }
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class InvokeFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> : NativeActivity<TResult> {
+        public InvokeFunc();
+        public InArgument<T1> Argument1 { get; set; }
+        public InArgument<T10> Argument10 { get; set; }
+        public InArgument<T11> Argument11 { get; set; }
+        public InArgument<T12> Argument12 { get; set; }
+        public InArgument<T13> Argument13 { get; set; }
+        public InArgument<T14> Argument14 { get; set; }
+        public InArgument<T15> Argument15 { get; set; }
+        public InArgument<T16> Argument16 { get; set; }
+        public InArgument<T2> Argument2 { get; set; }
+        public InArgument<T3> Argument3 { get; set; }
+        public InArgument<T4> Argument4 { get; set; }
+        public InArgument<T5> Argument5 { get; set; }
+        public InArgument<T6> Argument6 { get; set; }
+        public InArgument<T7> Argument7 { get; set; }
+        public InArgument<T8> Argument8 { get; set; }
+        public InArgument<T9> Argument9 { get; set; }
+        public ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Func { get; set; }
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class InvokeMethod<TResult> : AsyncCodeActivity<TResult> {
+        public InvokeMethod();
+        public Collection<Type> GenericTypeArguments { get; }
+        public string MethodName { get; set; }
+        public Collection<Argument> Parameters { get; }
+        public bool RunAsynchronously { get; set; }
+        public InArgument TargetObject { get; set; }
+        public Type TargetType { get; set; }
+        protected override IAsyncResult BeginExecute(AsyncCodeActivityContext context, AsyncCallback callback, object state);
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override TResult EndExecute(AsyncCodeActivityContext context, IAsyncResult result);
+    }
+    public interface ITextExpression {
+        string ExpressionText { get; }
+        string Language { get; }
+        bool RequiresCompilation { get; }
+        Expression GetExpressionTree();
+    }
+    public sealed class LambdaReference<T> : CodeActivity<Location<T>>, IExpressionContainer, IValueSerializableExpression {
+        public LambdaReference(Expression<Func<ActivityContext, T>> locationExpression);
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        public bool CanConvertToString(IValueSerializerContext context);
+        public string ConvertToString(IValueSerializerContext context);
+        protected override Location<T> Execute(CodeActivityContext context);
+    }
+    public class LambdaSerializationException : Exception {
+        public LambdaSerializationException();
+        protected LambdaSerializationException(SerializationInfo info, StreamingContext context);
+        public LambdaSerializationException(string message);
+        public LambdaSerializationException(string message, Exception innerException);
+    }
+    public sealed class LambdaValue<TResult> : CodeActivity<TResult>, IExpressionContainer, IValueSerializableExpression {
+        public LambdaValue(Expression<Func<ActivityContext, TResult>> lambdaValue);
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        public bool CanConvertToString(IValueSerializerContext context);
+        public string ConvertToString(IValueSerializerContext context);
+        protected override TResult Execute(CodeActivityContext context);
+    }
+    public sealed class LessThan<TLeft, TRight, TResult> : CodeActivity<TResult> {
+        public LessThan();
+        public InArgument<TLeft> Left { get; set; }
+        public InArgument<TRight> Right { get; set; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override TResult Execute(CodeActivityContext context);
+    }
+    public sealed class LessThanOrEqual<TLeft, TRight, TResult> : CodeActivity<TResult> {
+        public LessThanOrEqual();
+        public InArgument<TLeft> Left { get; set; }
+        public InArgument<TRight> Right { get; set; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override TResult Execute(CodeActivityContext context);
+    }
+    public sealed class Literal<T> : CodeActivity<T>, IExpressionContainer, IValueSerializableExpression {
+        public Literal();
+        public Literal(T value);
+        public T Value { get; set; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        public bool CanConvertToString(IValueSerializerContext context);
+        public string ConvertToString(IValueSerializerContext context);
+        protected override T Execute(CodeActivityContext context);
+        public bool ShouldSerializeValue();
+        public override string ToString();
+    }
+    public sealed class MultidimensionalArrayItemReference<TItem> : CodeActivity<Location<TItem>> {
+        public MultidimensionalArrayItemReference();
+        public InArgument<Array> Array { get; set; }
+        public Collection<InArgument<int>> Indices { get; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override Location<TItem> Execute(CodeActivityContext context);
+    }
+    public sealed class Multiply<TLeft, TRight, TResult> : CodeActivity<TResult> {
+        public Multiply();
+        public bool Checked { get; set; }
+        public InArgument<TLeft> Left { get; set; }
+        public InArgument<TRight> Right { get; set; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override TResult Execute(CodeActivityContext context);
+    }
+    public sealed class New<TResult> : CodeActivity<TResult> {
+        public New();
+        public Collection<Argument> Arguments { get; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override TResult Execute(CodeActivityContext context);
+    }
+    public sealed class NewArray<TResult> : CodeActivity<TResult> {
+        public NewArray();
+        public Collection<Argument> Bounds { get; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override TResult Execute(CodeActivityContext context);
+    }
+    public sealed class Not<TOperand, TResult> : CodeActivity<TResult> {
+        public Not();
+        public InArgument<TOperand> Operand { get; set; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override TResult Execute(CodeActivityContext context);
+    }
+    public sealed class NotEqual<TLeft, TRight, TResult> : CodeActivity<TResult> {
+        public NotEqual();
+        public InArgument<TLeft> Left { get; set; }
+        public InArgument<TRight> Right { get; set; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override TResult Execute(CodeActivityContext context);
+    }
+    public sealed class Or<TLeft, TRight, TResult> : CodeActivity<TResult> {
+        public Or();
+        public InArgument<TLeft> Left { get; set; }
+        public InArgument<TRight> Right { get; set; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override TResult Execute(CodeActivityContext context);
+    }
+    public sealed class OrElse : Activity<bool> {
+        public OrElse();
+        public Activity<bool> Left { get; set; }
+        public Activity<bool> Right { get; set; }
+        protected override void CacheMetadata(ActivityMetadata metadata);
+        protected override void OnCreateDynamicUpdateMap(UpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class PropertyReference<TOperand, TResult> : CodeActivity<Location<TResult>> {
+        public PropertyReference();
+        public InArgument<TOperand> Operand { get; set; }
+        public string PropertyName { get; set; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override Location<TResult> Execute(CodeActivityContext context);
+    }
+    public sealed class PropertyValue<TOperand, TResult> : CodeActivity<TResult> {
+        public PropertyValue();
+        public InArgument<TOperand> Operand { get; set; }
+        public string PropertyName { get; set; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override TResult Execute(CodeActivityContext context);
+    }
+    public sealed class Subtract<TLeft, TRight, TResult> : CodeActivity<TResult> {
+        public Subtract();
+        public bool Checked { get; set; }
+        public InArgument<TLeft> Left { get; set; }
+        public InArgument<TRight> Right { get; set; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override TResult Execute(CodeActivityContext context);
+    }
+    public static class TextExpression {
+        public static IList<string> DefaultNamespaces { get; }
+        public static IList<AssemblyReference> DefaultReferences { get; }
+        public static IList<string> GetNamespaces(object target);
+        public static IList<string> GetNamespacesForImplementation(object target);
+        public static IList<string> GetNamespacesInScope(Activity activity);
+        public static IList<AssemblyReference> GetReferences(object target);
+        public static IList<AssemblyReference> GetReferencesForImplementation(object target);
+        public static IList<AssemblyReference> GetReferencesInScope(Activity activity);
+        public static void SetNamespaces(object target, IList<string> namespaces);
+        public static void SetNamespaces(object target, params string[] namespaces);
+        public static void SetNamespacesForImplementation(object target, IList<string> namespaces);
+        public static void SetNamespacesForImplementation(object target, params string[] namespaces);
+        public static void SetReferences(object target, params AssemblyReference[] references);
+        public static void SetReferences(object target, IList<AssemblyReference> references);
+        public static void SetReferencesForImplementation(object target, params AssemblyReference[] references);
+        public static void SetReferencesForImplementation(object target, IList<AssemblyReference> references);
+        public static bool ShouldSerializeNamespaces(object target);
+        public static bool ShouldSerializeNamespacesForImplementation(object target);
+        public static bool ShouldSerializeReferences(object target);
+        public static bool ShouldSerializeReferencesForImplementation(object target);
+    }
+    public sealed class ValueTypeFieldReference<TOperand, TResult> : CodeActivity<Location<TResult>> {
+        public ValueTypeFieldReference();
+        public string FieldName { get; set; }
+        public InOutArgument<TOperand> OperandLocation { get; set; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override Location<TResult> Execute(CodeActivityContext context);
+    }
+    public sealed class ValueTypeIndexerReference<TOperand, TItem> : CodeActivity<Location<TItem>> {
+        public ValueTypeIndexerReference();
+        public Collection<InArgument> Indices { get; }
+        public InOutArgument<TOperand> OperandLocation { get; set; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override Location<TItem> Execute(CodeActivityContext context);
+    }
+    public sealed class ValueTypePropertyReference<TOperand, TResult> : CodeActivity<Location<TResult>> {
+        public ValueTypePropertyReference();
+        public InOutArgument<TOperand> OperandLocation { get; set; }
+        public string PropertyName { get; set; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override Location<TResult> Execute(CodeActivityContext context);
+    }
+    public sealed class VariableReference<T> : EnvironmentLocationReference<T> {
+        public VariableReference();
+        public VariableReference(Variable variable);
+        public override LocationReference LocationReference { get; }
+        public Variable Variable { get; set; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        public override string ToString();
+    }
+    public sealed class VariableValue<T> : EnvironmentLocationValue<T> {
+        public VariableValue();
+        public VariableValue(Variable variable);
+        public override LocationReference LocationReference { get; }
+        public Variable Variable { get; set; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        public override string ToString();
+    }
+}
```

