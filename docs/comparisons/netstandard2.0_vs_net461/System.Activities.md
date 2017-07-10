# System.Activities

``` diff
+namespace System.Activities {
+    public abstract class Activity {
+        protected Activity();
+        protected internal int CacheId { get; }
+        protected Collection<Constraint> Constraints { get; }
+        public string DisplayName { get; set; }
+        public string Id { get; }
+        protected virtual Func<Activity> Implementation { get; set; }
+        protected internal virtual Version ImplementationVersion { get; set; }
+        protected virtual void CacheMetadata(ActivityMetadata metadata);
+        protected virtual void OnCreateDynamicUpdateMap(UpdateMapMetadata metadata, Activity originalActivity);
+        public bool ShouldSerializeDisplayName();
+        public override string ToString();
+    }
+    public abstract class Activity<TResult> : ActivityWithResult {
+        protected Activity();
+        public new OutArgument<TResult> Result { get; set; }
+        public static Activity<TResult> FromValue(TResult constValue);
+        public static Activity<TResult> FromVariable(Variable variable);
+        public static Activity<TResult> FromVariable(Variable<TResult> variable);
+        public static implicit operator Activity<TResult> (Variable variable);
+        public static implicit operator Activity<TResult> (Variable<TResult> variable);
+        public static implicit operator Activity<TResult> (TResult constValue);
+    }
+    public sealed class ActivityAction : ActivityDelegate {
+        public ActivityAction();
+    }
+    public sealed class ActivityAction<T> : ActivityDelegate {
+        public ActivityAction();
+        public DelegateInArgument<T> Argument { get; set; }
+    }
+    public sealed class ActivityAction<T1, T2> : ActivityDelegate {
+        public ActivityAction();
+        public DelegateInArgument<T1> Argument1 { get; set; }
+        public DelegateInArgument<T2> Argument2 { get; set; }
+    }
+    public sealed class ActivityAction<T1, T2, T3> : ActivityDelegate {
+        public ActivityAction();
+        public DelegateInArgument<T1> Argument1 { get; set; }
+        public DelegateInArgument<T2> Argument2 { get; set; }
+        public DelegateInArgument<T3> Argument3 { get; set; }
+    }
+    public sealed class ActivityAction<T1, T2, T3, T4> : ActivityDelegate {
+        public ActivityAction();
+        public DelegateInArgument<T1> Argument1 { get; set; }
+        public DelegateInArgument<T2> Argument2 { get; set; }
+        public DelegateInArgument<T3> Argument3 { get; set; }
+        public DelegateInArgument<T4> Argument4 { get; set; }
+    }
+    public sealed class ActivityAction<T1, T2, T3, T4, T5> : ActivityDelegate {
+        public ActivityAction();
+        public DelegateInArgument<T1> Argument1 { get; set; }
+        public DelegateInArgument<T2> Argument2 { get; set; }
+        public DelegateInArgument<T3> Argument3 { get; set; }
+        public DelegateInArgument<T4> Argument4 { get; set; }
+        public DelegateInArgument<T5> Argument5 { get; set; }
+    }
+    public sealed class ActivityAction<T1, T2, T3, T4, T5, T6> : ActivityDelegate {
+        public ActivityAction();
+        public DelegateInArgument<T1> Argument1 { get; set; }
+        public DelegateInArgument<T2> Argument2 { get; set; }
+        public DelegateInArgument<T3> Argument3 { get; set; }
+        public DelegateInArgument<T4> Argument4 { get; set; }
+        public DelegateInArgument<T5> Argument5 { get; set; }
+        public DelegateInArgument<T6> Argument6 { get; set; }
+    }
+    public sealed class ActivityAction<T1, T2, T3, T4, T5, T6, T7> : ActivityDelegate {
+        public ActivityAction();
+        public DelegateInArgument<T1> Argument1 { get; set; }
+        public DelegateInArgument<T2> Argument2 { get; set; }
+        public DelegateInArgument<T3> Argument3 { get; set; }
+        public DelegateInArgument<T4> Argument4 { get; set; }
+        public DelegateInArgument<T5> Argument5 { get; set; }
+        public DelegateInArgument<T6> Argument6 { get; set; }
+        public DelegateInArgument<T7> Argument7 { get; set; }
+    }
+    public sealed class ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8> : ActivityDelegate {
+        public ActivityAction();
+        public DelegateInArgument<T1> Argument1 { get; set; }
+        public DelegateInArgument<T2> Argument2 { get; set; }
+        public DelegateInArgument<T3> Argument3 { get; set; }
+        public DelegateInArgument<T4> Argument4 { get; set; }
+        public DelegateInArgument<T5> Argument5 { get; set; }
+        public DelegateInArgument<T6> Argument6 { get; set; }
+        public DelegateInArgument<T7> Argument7 { get; set; }
+        public DelegateInArgument<T8> Argument8 { get; set; }
+    }
+    public sealed class ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> : ActivityDelegate {
+        public ActivityAction();
+        public DelegateInArgument<T1> Argument1 { get; set; }
+        public DelegateInArgument<T2> Argument2 { get; set; }
+        public DelegateInArgument<T3> Argument3 { get; set; }
+        public DelegateInArgument<T4> Argument4 { get; set; }
+        public DelegateInArgument<T5> Argument5 { get; set; }
+        public DelegateInArgument<T6> Argument6 { get; set; }
+        public DelegateInArgument<T7> Argument7 { get; set; }
+        public DelegateInArgument<T8> Argument8 { get; set; }
+        public DelegateInArgument<T9> Argument9 { get; set; }
+    }
+    public sealed class ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : ActivityDelegate {
+        public ActivityAction();
+        public DelegateInArgument<T1> Argument1 { get; set; }
+        public DelegateInArgument<T10> Argument10 { get; set; }
+        public DelegateInArgument<T2> Argument2 { get; set; }
+        public DelegateInArgument<T3> Argument3 { get; set; }
+        public DelegateInArgument<T4> Argument4 { get; set; }
+        public DelegateInArgument<T5> Argument5 { get; set; }
+        public DelegateInArgument<T6> Argument6 { get; set; }
+        public DelegateInArgument<T7> Argument7 { get; set; }
+        public DelegateInArgument<T8> Argument8 { get; set; }
+        public DelegateInArgument<T9> Argument9 { get; set; }
+    }
+    public sealed class ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : ActivityDelegate {
+        public ActivityAction();
+        public DelegateInArgument<T1> Argument1 { get; set; }
+        public DelegateInArgument<T10> Argument10 { get; set; }
+        public DelegateInArgument<T11> Argument11 { get; set; }
+        public DelegateInArgument<T2> Argument2 { get; set; }
+        public DelegateInArgument<T3> Argument3 { get; set; }
+        public DelegateInArgument<T4> Argument4 { get; set; }
+        public DelegateInArgument<T5> Argument5 { get; set; }
+        public DelegateInArgument<T6> Argument6 { get; set; }
+        public DelegateInArgument<T7> Argument7 { get; set; }
+        public DelegateInArgument<T8> Argument8 { get; set; }
+        public DelegateInArgument<T9> Argument9 { get; set; }
+    }
+    public sealed class ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : ActivityDelegate {
+        public ActivityAction();
+        public DelegateInArgument<T1> Argument1 { get; set; }
+        public DelegateInArgument<T10> Argument10 { get; set; }
+        public DelegateInArgument<T11> Argument11 { get; set; }
+        public DelegateInArgument<T12> Argument12 { get; set; }
+        public DelegateInArgument<T2> Argument2 { get; set; }
+        public DelegateInArgument<T3> Argument3 { get; set; }
+        public DelegateInArgument<T4> Argument4 { get; set; }
+        public DelegateInArgument<T5> Argument5 { get; set; }
+        public DelegateInArgument<T6> Argument6 { get; set; }
+        public DelegateInArgument<T7> Argument7 { get; set; }
+        public DelegateInArgument<T8> Argument8 { get; set; }
+        public DelegateInArgument<T9> Argument9 { get; set; }
+    }
+    public sealed class ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : ActivityDelegate {
+        public ActivityAction();
+        public DelegateInArgument<T1> Argument1 { get; set; }
+        public DelegateInArgument<T10> Argument10 { get; set; }
+        public DelegateInArgument<T11> Argument11 { get; set; }
+        public DelegateInArgument<T12> Argument12 { get; set; }
+        public DelegateInArgument<T13> Argument13 { get; set; }
+        public DelegateInArgument<T2> Argument2 { get; set; }
+        public DelegateInArgument<T3> Argument3 { get; set; }
+        public DelegateInArgument<T4> Argument4 { get; set; }
+        public DelegateInArgument<T5> Argument5 { get; set; }
+        public DelegateInArgument<T6> Argument6 { get; set; }
+        public DelegateInArgument<T7> Argument7 { get; set; }
+        public DelegateInArgument<T8> Argument8 { get; set; }
+        public DelegateInArgument<T9> Argument9 { get; set; }
+    }
+    public sealed class ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : ActivityDelegate {
+        public ActivityAction();
+        public DelegateInArgument<T1> Argument1 { get; set; }
+        public DelegateInArgument<T10> Argument10 { get; set; }
+        public DelegateInArgument<T11> Argument11 { get; set; }
+        public DelegateInArgument<T12> Argument12 { get; set; }
+        public DelegateInArgument<T13> Argument13 { get; set; }
+        public DelegateInArgument<T14> Argument14 { get; set; }
+        public DelegateInArgument<T2> Argument2 { get; set; }
+        public DelegateInArgument<T3> Argument3 { get; set; }
+        public DelegateInArgument<T4> Argument4 { get; set; }
+        public DelegateInArgument<T5> Argument5 { get; set; }
+        public DelegateInArgument<T6> Argument6 { get; set; }
+        public DelegateInArgument<T7> Argument7 { get; set; }
+        public DelegateInArgument<T8> Argument8 { get; set; }
+        public DelegateInArgument<T9> Argument9 { get; set; }
+    }
+    public sealed class ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : ActivityDelegate {
+        public ActivityAction();
+        public DelegateInArgument<T1> Argument1 { get; set; }
+        public DelegateInArgument<T10> Argument10 { get; set; }
+        public DelegateInArgument<T11> Argument11 { get; set; }
+        public DelegateInArgument<T12> Argument12 { get; set; }
+        public DelegateInArgument<T13> Argument13 { get; set; }
+        public DelegateInArgument<T14> Argument14 { get; set; }
+        public DelegateInArgument<T15> Argument15 { get; set; }
+        public DelegateInArgument<T2> Argument2 { get; set; }
+        public DelegateInArgument<T3> Argument3 { get; set; }
+        public DelegateInArgument<T4> Argument4 { get; set; }
+        public DelegateInArgument<T5> Argument5 { get; set; }
+        public DelegateInArgument<T6> Argument6 { get; set; }
+        public DelegateInArgument<T7> Argument7 { get; set; }
+        public DelegateInArgument<T8> Argument8 { get; set; }
+        public DelegateInArgument<T9> Argument9 { get; set; }
+    }
+    public sealed class ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> : ActivityDelegate {
+        public ActivityAction();
+        public DelegateInArgument<T1> Argument1 { get; set; }
+        public DelegateInArgument<T10> Argument10 { get; set; }
+        public DelegateInArgument<T11> Argument11 { get; set; }
+        public DelegateInArgument<T12> Argument12 { get; set; }
+        public DelegateInArgument<T13> Argument13 { get; set; }
+        public DelegateInArgument<T14> Argument14 { get; set; }
+        public DelegateInArgument<T15> Argument15 { get; set; }
+        public DelegateInArgument<T16> Argument16 { get; set; }
+        public DelegateInArgument<T2> Argument2 { get; set; }
+        public DelegateInArgument<T3> Argument3 { get; set; }
+        public DelegateInArgument<T4> Argument4 { get; set; }
+        public DelegateInArgument<T5> Argument5 { get; set; }
+        public DelegateInArgument<T6> Argument6 { get; set; }
+        public DelegateInArgument<T7> Argument7 { get; set; }
+        public DelegateInArgument<T8> Argument8 { get; set; }
+        public DelegateInArgument<T9> Argument9 { get; set; }
+    }
+    public sealed class ActivityBuilder : IDebuggableWorkflowTree {
+        public ActivityBuilder();
+        public Collection<Attribute> Attributes { get; }
+        public Collection<Constraint> Constraints { get; }
+        public Activity Implementation { get; set; }
+        public Version ImplementationVersion { get; set; }
+        public string Name { get; set; }
+        public KeyedCollection<string, DynamicActivityProperty> Properties { get; }
+        public static ActivityPropertyReference GetPropertyReference(object target);
+        public static IList<ActivityPropertyReference> GetPropertyReferences(object target);
+        public static void SetPropertyReference(object target, ActivityPropertyReference value);
+        public static bool ShouldSerializePropertyReference(object target);
+        public static bool ShouldSerializePropertyReferences(object target);
+        Activity System.Activities.Debugger.IDebuggableWorkflowTree.GetWorkflowRoot();
+    }
+    public sealed class ActivityBuilder<TResult> : IDebuggableWorkflowTree {
+        public ActivityBuilder();
+        public Collection<Attribute> Attributes { get; }
+        public Collection<Constraint> Constraints { get; }
+        public Activity Implementation { get; set; }
+        public Version ImplementationVersion { get; set; }
+        public string Name { get; set; }
+        public KeyedCollection<string, DynamicActivityProperty> Properties { get; }
+        Activity System.Activities.Debugger.IDebuggableWorkflowTree.GetWorkflowRoot();
+    }
+    public class ActivityContext {
+        public string ActivityInstanceId { get; }
+        public WorkflowDataContext DataContext { get; }
+        public Guid WorkflowInstanceId { get; }
+        public T GetExtension<T>() where T : class;
+        public Location<T> GetLocation<T>(LocationReference locationReference);
+        public object GetValue(Argument argument);
+        public object GetValue(RuntimeArgument runtimeArgument);
+        public T GetValue<T>(InArgument<T> argument);
+        public T GetValue<T>(InOutArgument<T> argument);
+        public T GetValue<T>(LocationReference locationReference);
+        public T GetValue<T>(OutArgument<T> argument);
+        public void SetValue(Argument argument, object value);
+        public void SetValue<T>(InArgument<T> argument, T value);
+        public void SetValue<T>(InOutArgument<T> argument, T value);
+        public void SetValue<T>(LocationReference locationReference, T value);
+        public void SetValue<T>(OutArgument<T> argument, T value);
+    }
+    public abstract class ActivityDelegate {
+        protected ActivityDelegate();
+        public string DisplayName { get; set; }
+        public Activity Handler { get; set; }
+        protected internal virtual DelegateOutArgument GetResultArgument();
+        protected virtual void OnGetRuntimeDelegateArguments(IList<RuntimeDelegateArgument> runtimeDelegateArguments);
+        public bool ShouldSerializeDisplayName();
+        public override string ToString();
+    }
+    public sealed class ActivityFunc<TResult> : ActivityDelegate {
+        public ActivityFunc();
+        public DelegateOutArgument<TResult> Result { get; set; }
+        protected internal override DelegateOutArgument GetResultArgument();
+    }
+    public sealed class ActivityFunc<T, TResult> : ActivityDelegate {
+        public ActivityFunc();
+        public DelegateInArgument<T> Argument { get; set; }
+        public DelegateOutArgument<TResult> Result { get; set; }
+        protected internal override DelegateOutArgument GetResultArgument();
+    }
+    public sealed class ActivityFunc<T1, T2, TResult> : ActivityDelegate {
+        public ActivityFunc();
+        public DelegateInArgument<T1> Argument1 { get; set; }
+        public DelegateInArgument<T2> Argument2 { get; set; }
+        public DelegateOutArgument<TResult> Result { get; set; }
+        protected internal override DelegateOutArgument GetResultArgument();
+    }
+    public sealed class ActivityFunc<T1, T2, T3, TResult> : ActivityDelegate {
+        public ActivityFunc();
+        public DelegateInArgument<T1> Argument1 { get; set; }
+        public DelegateInArgument<T2> Argument2 { get; set; }
+        public DelegateInArgument<T3> Argument3 { get; set; }
+        public DelegateOutArgument<TResult> Result { get; set; }
+        protected internal override DelegateOutArgument GetResultArgument();
+    }
+    public sealed class ActivityFunc<T1, T2, T3, T4, TResult> : ActivityDelegate {
+        public ActivityFunc();
+        public DelegateInArgument<T1> Argument1 { get; set; }
+        public DelegateInArgument<T2> Argument2 { get; set; }
+        public DelegateInArgument<T3> Argument3 { get; set; }
+        public DelegateInArgument<T4> Argument4 { get; set; }
+        public DelegateOutArgument<TResult> Result { get; set; }
+        protected internal override DelegateOutArgument GetResultArgument();
+    }
+    public sealed class ActivityFunc<T1, T2, T3, T4, T5, TResult> : ActivityDelegate {
+        public ActivityFunc();
+        public DelegateInArgument<T1> Argument1 { get; set; }
+        public DelegateInArgument<T2> Argument2 { get; set; }
+        public DelegateInArgument<T3> Argument3 { get; set; }
+        public DelegateInArgument<T4> Argument4 { get; set; }
+        public DelegateInArgument<T5> Argument5 { get; set; }
+        public DelegateOutArgument<TResult> Result { get; set; }
+        protected internal override DelegateOutArgument GetResultArgument();
+    }
+    public sealed class ActivityFunc<T1, T2, T3, T4, T5, T6, TResult> : ActivityDelegate {
+        public ActivityFunc();
+        public DelegateInArgument<T1> Argument1 { get; set; }
+        public DelegateInArgument<T2> Argument2 { get; set; }
+        public DelegateInArgument<T3> Argument3 { get; set; }
+        public DelegateInArgument<T4> Argument4 { get; set; }
+        public DelegateInArgument<T5> Argument5 { get; set; }
+        public DelegateInArgument<T6> Argument6 { get; set; }
+        public DelegateOutArgument<TResult> Result { get; set; }
+        protected internal override DelegateOutArgument GetResultArgument();
+    }
+    public sealed class ActivityFunc<T1, T2, T3, T4, T5, T6, T7, TResult> : ActivityDelegate {
+        public ActivityFunc();
+        public DelegateInArgument<T1> Argument1 { get; set; }
+        public DelegateInArgument<T2> Argument2 { get; set; }
+        public DelegateInArgument<T3> Argument3 { get; set; }
+        public DelegateInArgument<T4> Argument4 { get; set; }
+        public DelegateInArgument<T5> Argument5 { get; set; }
+        public DelegateInArgument<T6> Argument6 { get; set; }
+        public DelegateInArgument<T7> Argument7 { get; set; }
+        public DelegateOutArgument<TResult> Result { get; set; }
+        protected internal override DelegateOutArgument GetResultArgument();
+    }
+    public sealed class ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, TResult> : ActivityDelegate {
+        public ActivityFunc();
+        public DelegateInArgument<T1> Argument1 { get; set; }
+        public DelegateInArgument<T2> Argument2 { get; set; }
+        public DelegateInArgument<T3> Argument3 { get; set; }
+        public DelegateInArgument<T4> Argument4 { get; set; }
+        public DelegateInArgument<T5> Argument5 { get; set; }
+        public DelegateInArgument<T6> Argument6 { get; set; }
+        public DelegateInArgument<T7> Argument7 { get; set; }
+        public DelegateInArgument<T8> Argument8 { get; set; }
+        public DelegateOutArgument<TResult> Result { get; set; }
+        protected internal override DelegateOutArgument GetResultArgument();
+    }
+    public sealed class ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> : ActivityDelegate {
+        public ActivityFunc();
+        public DelegateInArgument<T1> Argument1 { get; set; }
+        public DelegateInArgument<T2> Argument2 { get; set; }
+        public DelegateInArgument<T3> Argument3 { get; set; }
+        public DelegateInArgument<T4> Argument4 { get; set; }
+        public DelegateInArgument<T5> Argument5 { get; set; }
+        public DelegateInArgument<T6> Argument6 { get; set; }
+        public DelegateInArgument<T7> Argument7 { get; set; }
+        public DelegateInArgument<T8> Argument8 { get; set; }
+        public DelegateInArgument<T9> Argument9 { get; set; }
+        public DelegateOutArgument<TResult> Result { get; set; }
+        protected internal override DelegateOutArgument GetResultArgument();
+    }
+    public sealed class ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> : ActivityDelegate {
+        public ActivityFunc();
+        public DelegateInArgument<T1> Argument1 { get; set; }
+        public DelegateInArgument<T10> Argument10 { get; set; }
+        public DelegateInArgument<T2> Argument2 { get; set; }
+        public DelegateInArgument<T3> Argument3 { get; set; }
+        public DelegateInArgument<T4> Argument4 { get; set; }
+        public DelegateInArgument<T5> Argument5 { get; set; }
+        public DelegateInArgument<T6> Argument6 { get; set; }
+        public DelegateInArgument<T7> Argument7 { get; set; }
+        public DelegateInArgument<T8> Argument8 { get; set; }
+        public DelegateInArgument<T9> Argument9 { get; set; }
+        public DelegateOutArgument<TResult> Result { get; set; }
+        protected internal override DelegateOutArgument GetResultArgument();
+    }
+    public sealed class ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> : ActivityDelegate {
+        public ActivityFunc();
+        public DelegateInArgument<T1> Argument1 { get; set; }
+        public DelegateInArgument<T10> Argument10 { get; set; }
+        public DelegateInArgument<T11> Argument11 { get; set; }
+        public DelegateInArgument<T2> Argument2 { get; set; }
+        public DelegateInArgument<T3> Argument3 { get; set; }
+        public DelegateInArgument<T4> Argument4 { get; set; }
+        public DelegateInArgument<T5> Argument5 { get; set; }
+        public DelegateInArgument<T6> Argument6 { get; set; }
+        public DelegateInArgument<T7> Argument7 { get; set; }
+        public DelegateInArgument<T8> Argument8 { get; set; }
+        public DelegateInArgument<T9> Argument9 { get; set; }
+        public DelegateOutArgument<TResult> Result { get; set; }
+        protected internal override DelegateOutArgument GetResultArgument();
+    }
+    public sealed class ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> : ActivityDelegate {
+        public ActivityFunc();
+        public DelegateInArgument<T1> Argument1 { get; set; }
+        public DelegateInArgument<T10> Argument10 { get; set; }
+        public DelegateInArgument<T11> Argument11 { get; set; }
+        public DelegateInArgument<T12> Argument12 { get; set; }
+        public DelegateInArgument<T2> Argument2 { get; set; }
+        public DelegateInArgument<T3> Argument3 { get; set; }
+        public DelegateInArgument<T4> Argument4 { get; set; }
+        public DelegateInArgument<T5> Argument5 { get; set; }
+        public DelegateInArgument<T6> Argument6 { get; set; }
+        public DelegateInArgument<T7> Argument7 { get; set; }
+        public DelegateInArgument<T8> Argument8 { get; set; }
+        public DelegateInArgument<T9> Argument9 { get; set; }
+        public DelegateOutArgument<TResult> Result { get; set; }
+        protected internal override DelegateOutArgument GetResultArgument();
+    }
+    public sealed class ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> : ActivityDelegate {
+        public ActivityFunc();
+        public DelegateInArgument<T1> Argument1 { get; set; }
+        public DelegateInArgument<T10> Argument10 { get; set; }
+        public DelegateInArgument<T11> Argument11 { get; set; }
+        public DelegateInArgument<T12> Argument12 { get; set; }
+        public DelegateInArgument<T13> Argument13 { get; set; }
+        public DelegateInArgument<T2> Argument2 { get; set; }
+        public DelegateInArgument<T3> Argument3 { get; set; }
+        public DelegateInArgument<T4> Argument4 { get; set; }
+        public DelegateInArgument<T5> Argument5 { get; set; }
+        public DelegateInArgument<T6> Argument6 { get; set; }
+        public DelegateInArgument<T7> Argument7 { get; set; }
+        public DelegateInArgument<T8> Argument8 { get; set; }
+        public DelegateInArgument<T9> Argument9 { get; set; }
+        public DelegateOutArgument<TResult> Result { get; set; }
+        protected internal override DelegateOutArgument GetResultArgument();
+    }
+    public sealed class ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> : ActivityDelegate {
+        public ActivityFunc();
+        public DelegateInArgument<T1> Argument1 { get; set; }
+        public DelegateInArgument<T10> Argument10 { get; set; }
+        public DelegateInArgument<T11> Argument11 { get; set; }
+        public DelegateInArgument<T12> Argument12 { get; set; }
+        public DelegateInArgument<T13> Argument13 { get; set; }
+        public DelegateInArgument<T14> Argument14 { get; set; }
+        public DelegateInArgument<T2> Argument2 { get; set; }
+        public DelegateInArgument<T3> Argument3 { get; set; }
+        public DelegateInArgument<T4> Argument4 { get; set; }
+        public DelegateInArgument<T5> Argument5 { get; set; }
+        public DelegateInArgument<T6> Argument6 { get; set; }
+        public DelegateInArgument<T7> Argument7 { get; set; }
+        public DelegateInArgument<T8> Argument8 { get; set; }
+        public DelegateInArgument<T9> Argument9 { get; set; }
+        public DelegateOutArgument<TResult> Result { get; set; }
+        protected internal override DelegateOutArgument GetResultArgument();
+    }
+    public sealed class ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> : ActivityDelegate {
+        public ActivityFunc();
+        public DelegateInArgument<T1> Argument1 { get; set; }
+        public DelegateInArgument<T10> Argument10 { get; set; }
+        public DelegateInArgument<T11> Argument11 { get; set; }
+        public DelegateInArgument<T12> Argument12 { get; set; }
+        public DelegateInArgument<T13> Argument13 { get; set; }
+        public DelegateInArgument<T14> Argument14 { get; set; }
+        public DelegateInArgument<T15> Argument15 { get; set; }
+        public DelegateInArgument<T2> Argument2 { get; set; }
+        public DelegateInArgument<T3> Argument3 { get; set; }
+        public DelegateInArgument<T4> Argument4 { get; set; }
+        public DelegateInArgument<T5> Argument5 { get; set; }
+        public DelegateInArgument<T6> Argument6 { get; set; }
+        public DelegateInArgument<T7> Argument7 { get; set; }
+        public DelegateInArgument<T8> Argument8 { get; set; }
+        public DelegateInArgument<T9> Argument9 { get; set; }
+        public DelegateOutArgument<TResult> Result { get; set; }
+        protected internal override DelegateOutArgument GetResultArgument();
+    }
+    public sealed class ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> : ActivityDelegate {
+        public ActivityFunc();
+        public DelegateInArgument<T1> Argument1 { get; set; }
+        public DelegateInArgument<T10> Argument10 { get; set; }
+        public DelegateInArgument<T11> Argument11 { get; set; }
+        public DelegateInArgument<T12> Argument12 { get; set; }
+        public DelegateInArgument<T13> Argument13 { get; set; }
+        public DelegateInArgument<T14> Argument14 { get; set; }
+        public DelegateInArgument<T15> Argument15 { get; set; }
+        public DelegateInArgument<T16> Argument16 { get; set; }
+        public DelegateInArgument<T2> Argument2 { get; set; }
+        public DelegateInArgument<T3> Argument3 { get; set; }
+        public DelegateInArgument<T4> Argument4 { get; set; }
+        public DelegateInArgument<T5> Argument5 { get; set; }
+        public DelegateInArgument<T6> Argument6 { get; set; }
+        public DelegateInArgument<T7> Argument7 { get; set; }
+        public DelegateInArgument<T8> Argument8 { get; set; }
+        public DelegateInArgument<T9> Argument9 { get; set; }
+        public DelegateOutArgument<TResult> Result { get; set; }
+        protected internal override DelegateOutArgument GetResultArgument();
+    }
+    public sealed class ActivityInstance : ActivityInstanceMap.IActivityReference, ActivityInstanceMap.IActivityReferenceWithEnvironment {
+        public Activity Activity { get; internal set; }
+        public string Id { get; }
+        public Version ImplementationVersion { get; internal set; }
+        public bool IsCompleted { get; }
+        public ActivityInstanceState State { get; }
+    }
+    public enum ActivityInstanceState {
+        Canceled = 2,
+        Closed = 1,
+        Executing = 0,
+        Faulted = 3,
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct ActivityMetadata {
+        public LocationReferenceEnvironment Environment { get; }
+        public bool HasViolations { get; }
+        public void AddArgument(RuntimeArgument argument);
+        public void AddDefaultExtensionProvider<T>(Func<T> extensionProvider) where T : class;
+        public void AddImportedChild(Activity importedChild);
+        public void AddImportedChild(Activity importedChild, object origin);
+        public void AddImportedDelegate(ActivityDelegate importedDelegate);
+        public void AddImportedDelegate(ActivityDelegate importedDelegate, object origin);
+        public void AddValidationError(ValidationError validationError);
+        public void AddValidationError(string validationErrorMessage);
+        public void AddVariable(Variable variable);
+        public void AddVariable(Variable variable, object origin);
+        public void Bind(Argument binding, RuntimeArgument argument);
+        public override bool Equals(object obj);
+        public Collection<RuntimeArgument> GetArgumentsWithReflection();
+        public override int GetHashCode();
+        public Collection<Activity> GetImportedChildrenWithReflection();
+        public Collection<ActivityDelegate> GetImportedDelegatesWithReflection();
+        public Collection<Variable> GetVariablesWithReflection();
+        public static bool operator ==(ActivityMetadata left, ActivityMetadata right);
+        public static bool operator !=(ActivityMetadata left, ActivityMetadata right);
+        public void RequireExtension(Type extensionType);
+        public void RequireExtension<T>() where T : class;
+        public void SetArgumentsCollection(Collection<RuntimeArgument> arguments);
+        public void SetImportedChildrenCollection(Collection<Activity> importedChildren);
+        public void SetImportedDelegatesCollection(Collection<ActivityDelegate> importedDelegates);
+        public void SetValidationErrorsCollection(Collection<ValidationError> validationErrors);
+        public void SetVariablesCollection(Collection<Variable> variables);
+    }
+    public class ActivityPropertyReference {
+        public ActivityPropertyReference();
+        public string SourceProperty { get; set; }
+        public string TargetProperty { get; set; }
+    }
+    public abstract class ActivityWithResult : Activity {
+        public OutArgument Result { get; set; }
+        public Type ResultType { get; }
+    }
+    public abstract class Argument {
+        public static readonly int UnspecifiedEvaluationOrder;
+        public const string ResultValue = "Result";
+        public Type ArgumentType { get; internal set; }
+        public ArgumentDirection Direction { get; internal set; }
+        public int EvaluationOrder { get; set; }
+        public ActivityWithResult Expression { get; set; }
+        public static Argument Create(Type type, ArgumentDirection direction);
+        public static Argument CreateReference(Argument argumentToReference, string referencedArgumentName);
+        public object Get(ActivityContext context);
+        public T Get<T>(ActivityContext context);
+        public Location GetLocation(ActivityContext context);
+        public void Set(ActivityContext context, object value);
+    }
+    public enum ArgumentDirection {
+        In = 0,
+        InOut = 2,
+        Out = 1,
+    }
+    public abstract class AsyncCodeActivity : Activity, IAsyncCodeActivity {
+        protected AsyncCodeActivity();
+        protected sealed override Func<Activity> Implementation { get; set; }
+        protected internal sealed override Version ImplementationVersion { get; set; }
+        protected abstract IAsyncResult BeginExecute(AsyncCodeActivityContext context, AsyncCallback callback, object state);
+        protected sealed override void CacheMetadata(ActivityMetadata metadata);
+        protected virtual void CacheMetadata(CodeActivityMetadata metadata);
+        protected virtual void Cancel(AsyncCodeActivityContext context);
+        protected abstract void EndExecute(AsyncCodeActivityContext context, IAsyncResult result);
+        protected sealed override void OnCreateDynamicUpdateMap(UpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public abstract class AsyncCodeActivity<TResult> : Activity<TResult>, IAsyncCodeActivity {
+        protected AsyncCodeActivity();
+        protected sealed override Func<Activity> Implementation { get; set; }
+        protected internal sealed override Version ImplementationVersion { get; set; }
+        protected abstract IAsyncResult BeginExecute(AsyncCodeActivityContext context, AsyncCallback callback, object state);
+        protected sealed override void CacheMetadata(ActivityMetadata metadata);
+        protected virtual void CacheMetadata(CodeActivityMetadata metadata);
+        protected virtual void Cancel(AsyncCodeActivityContext context);
+        protected abstract TResult EndExecute(AsyncCodeActivityContext context, IAsyncResult result);
+        protected sealed override void OnCreateDynamicUpdateMap(UpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class AsyncCodeActivityContext : CodeActivityContext {
+        public bool IsCancellationRequested { get; }
+        public object UserState { get; set; }
+        public void MarkCanceled();
+    }
+    public class Bookmark : IEquatable<Bookmark> {
+        public Bookmark(string name);
+        public string Name { get; }
+        public bool Equals(Bookmark other);
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public override string ToString();
+    }
+    public delegate void BookmarkCallback(NativeActivityContext context, Bookmark bookmark, object value);
+    public enum BookmarkOptions {
+        MultipleResume = 1,
+        NonBlocking = 2,
+        None = 0,
+    }
+    public enum BookmarkResumptionResult {
+        NotFound = 1,
+        NotReady = 2,
+        Success = 0,
+    }
+    public sealed class BookmarkScope : IEquatable<BookmarkScope> {
+        public BookmarkScope(Guid id);
+        public static BookmarkScope Default { get; }
+        public Guid Id { get; internal set; }
+        public bool IsInitialized { get; }
+        public bool Equals(BookmarkScope other);
+        public override int GetHashCode();
+        public void Initialize(NativeActivityContext context, Guid id);
+    }
+    public sealed class BookmarkScopeHandle : Handle {
+        public BookmarkScopeHandle();
+        public BookmarkScope BookmarkScope { get; }
+        public static BookmarkScopeHandle Default { get; }
+        public void CreateBookmarkScope(NativeActivityContext context);
+        public void CreateBookmarkScope(NativeActivityContext context, Guid scopeId);
+        public void Initialize(NativeActivityContext context, Guid scope);
+        protected override void OnUninitialize(HandleInitializationContext context);
+    }
+    public abstract class CodeActivity : Activity {
+        protected CodeActivity();
+        protected sealed override Func<Activity> Implementation { get; set; }
+        protected internal sealed override Version ImplementationVersion { get; set; }
+        protected sealed override void CacheMetadata(ActivityMetadata metadata);
+        protected virtual void CacheMetadata(CodeActivityMetadata metadata);
+        protected abstract void Execute(CodeActivityContext context);
+        protected sealed override void OnCreateDynamicUpdateMap(UpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public abstract class CodeActivity<TResult> : Activity<TResult> {
+        protected CodeActivity();
+        protected sealed override Func<Activity> Implementation { get; set; }
+        protected internal sealed override Version ImplementationVersion { get; set; }
+        protected sealed override void CacheMetadata(ActivityMetadata metadata);
+        protected virtual void CacheMetadata(CodeActivityMetadata metadata);
+        protected abstract TResult Execute(CodeActivityContext context);
+        protected sealed override void OnCreateDynamicUpdateMap(UpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public class CodeActivityContext : ActivityContext {
+        public THandle GetProperty<THandle>() where THandle : Handle;
+        public void Track(CustomTrackingRecord record);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct CodeActivityMetadata {
+        public LocationReferenceEnvironment Environment { get; }
+        public bool HasViolations { get; }
+        public void AddArgument(RuntimeArgument argument);
+        public void AddDefaultExtensionProvider<T>(Func<T> extensionProvider) where T : class;
+        public void AddValidationError(ValidationError validationError);
+        public void AddValidationError(string validationErrorMessage);
+        public void Bind(Argument binding, RuntimeArgument argument);
+        public override bool Equals(object obj);
+        public Collection<RuntimeArgument> GetArgumentsWithReflection();
+        public override int GetHashCode();
+        public static bool operator ==(CodeActivityMetadata left, CodeActivityMetadata right);
+        public static bool operator !=(CodeActivityMetadata left, CodeActivityMetadata right);
+        public void RequireExtension(Type extensionType);
+        public void RequireExtension<T>() where T : class;
+        public void SetArgumentsCollection(Collection<RuntimeArgument> arguments);
+        public void SetValidationErrorsCollection(Collection<ValidationError> validationErrors);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct CodeActivityPublicEnvironmentAccessor {
+        public CodeActivityMetadata ActivityMetadata { get; }
+        public static CodeActivityPublicEnvironmentAccessor Create(CodeActivityMetadata metadata);
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public static bool operator ==(CodeActivityPublicEnvironmentAccessor left, CodeActivityPublicEnvironmentAccessor right);
+        public static bool operator !=(CodeActivityPublicEnvironmentAccessor left, CodeActivityPublicEnvironmentAccessor right);
+        public bool TryGetAccessToPublicLocation(LocationReference publicLocation, ArgumentDirection accessDirection, out LocationReference equivalentLocation);
+        public bool TryGetReferenceToPublicLocation(LocationReference publicReference, out LocationReference equivalentReference);
+    }
+    public delegate void CompletionCallback(NativeActivityContext context, ActivityInstance completedInstance);
+    public delegate void CompletionCallback<TResult>(NativeActivityContext context, ActivityInstance completedInstance, TResult result);
+    public abstract class DelegateArgument : LocationReference {
+        public ArgumentDirection Direction { get; internal set; }
+        public new string Name { get; set; }
+        protected override string NameCore { get; }
+        public object Get(ActivityContext context);
+        public override Location GetLocation(ActivityContext context);
+    }
+    public delegate void DelegateCompletionCallback(NativeActivityContext context, ActivityInstance completedInstance, IDictionary<string, object> outArguments);
+    public abstract class DelegateInArgument : DelegateArgument
+    public sealed class DelegateInArgument<T> : DelegateInArgument {
+        public DelegateInArgument();
+        public DelegateInArgument(string name);
+        protected override Type TypeCore { get; }
+        public new T Get(ActivityContext context);
+        public void Set(ActivityContext context, T value);
+    }
+    public abstract class DelegateOutArgument : DelegateArgument
+    public sealed class DelegateOutArgument<T> : DelegateOutArgument {
+        public DelegateOutArgument();
+        public DelegateOutArgument(string name);
+        protected override Type TypeCore { get; }
+        public new T Get(ActivityContext context);
+        public new Location<T> GetLocation(ActivityContext context);
+        public void Set(ActivityContext context, T value);
+    }
+    public sealed class DynamicActivity : Activity, ICustomTypeDescriptor, IDynamicActivity {
+        public DynamicActivity();
+        public Collection<Attribute> Attributes { get; }
+        public new Collection<Constraint> Constraints { get; }
+        public new Func<Activity> Implementation { get; set; }
+        public new Version ImplementationVersion { get; set; }
+        public string Name { get; set; }
+        public KeyedCollection<string, DynamicActivityProperty> Properties { get; }
+        AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes();
+        string System.ComponentModel.ICustomTypeDescriptor.GetClassName();
+        string System.ComponentModel.ICustomTypeDescriptor.GetComponentName();
+        TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter();
+        EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent();
+        PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty();
+        object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType);
+        EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents();
+        EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes);
+        PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties();
+        PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes);
+        object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd);
+    }
+    public sealed class DynamicActivity<TResult> : Activity<TResult>, ICustomTypeDescriptor, IDynamicActivity {
+        public DynamicActivity();
+        public Collection<Attribute> Attributes { get; }
+        public new Collection<Constraint> Constraints { get; }
+        public new Func<Activity> Implementation { get; set; }
+        public new Version ImplementationVersion { get; set; }
+        public string Name { get; set; }
+        public KeyedCollection<string, DynamicActivityProperty> Properties { get; }
+        AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes();
+        string System.ComponentModel.ICustomTypeDescriptor.GetClassName();
+        string System.ComponentModel.ICustomTypeDescriptor.GetComponentName();
+        TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter();
+        EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent();
+        PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty();
+        object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType);
+        EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents();
+        EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes);
+        PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties();
+        PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes);
+        object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd);
+    }
+    public class DynamicActivityProperty {
+        public DynamicActivityProperty();
+        public Collection<Attribute> Attributes { get; }
+        public string Name { get; set; }
+        public Type Type { get; set; }
+        public object Value { get; set; }
+        public override string ToString();
+    }
+    public class ExceptionPersistenceExtension {
+        public ExceptionPersistenceExtension();
+        public bool PersistExceptions { get; set; }
+    }
+    public class ExclusiveHandle : Handle {
+        public ExclusiveHandle();
+        public ReadOnlyCollection<BookmarkScopeHandle> RegisteredBookmarkScopes { get; }
+        protected override void OnInitialize(HandleInitializationContext context);
+        public void RegisterBookmarkScope(NativeActivityContext context, BookmarkScopeHandle bookmarkScopeHandle);
+        public void Reinitialize(NativeActivityContext context);
+    }
+    public sealed class ExecutionProperties : IEnumerable, IEnumerable<KeyValuePair<string, object>> {
+        public bool IsEmpty { get; }
+        public void Add(string name, object property);
+        public void Add(string name, object property, bool onlyVisibleToPublicChildren);
+        public object Find(string name);
+        public IEnumerator<KeyValuePair<string, object>> GetEnumerator();
+        public bool Remove(string name);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+    }
+    public delegate void FaultCallback(NativeActivityFaultContext faultContext, Exception propagatedException, ActivityInstance propagatedFrom);
+    public abstract class Handle {
+        protected Handle();
+        public string ExecutionPropertyName { get; }
+        public ActivityInstance Owner { get; }
+        protected virtual void OnInitialize(HandleInitializationContext context);
+        protected virtual void OnUninitialize(HandleInitializationContext context);
+        protected void ThrowIfUninitialized();
+    }
+    public sealed class HandleInitializationContext {
+        public THandle CreateAndInitializeHandle<THandle>() where THandle : Handle;
+        public T GetExtension<T>() where T : class;
+        public void UninitializeHandle(Handle handle);
+    }
+    public interface IExecutionProperty {
+        void CleanupWorkflowThread();
+        void SetupWorkflowThread();
+    }
+    public abstract class InArgument : Argument {
+        public static InArgument CreateReference(InArgument argumentToReference, string referencedArgumentName);
+        public static InArgument CreateReference(InOutArgument argumentToReference, string referencedArgumentName);
+    }
+    public sealed class InArgument<T> : InArgument {
+        public InArgument();
+        public InArgument(Activity<T> expression);
+        public InArgument(DelegateArgument delegateArgument);
+        public InArgument(Variable variable);
+        public InArgument(Expression<Func<ActivityContext, T>> expression);
+        public InArgument(T constValue);
+        public new Activity<T> Expression { get; set; }
+        public static InArgument<T> FromDelegateArgument(DelegateArgument delegateArgument);
+        public static InArgument<T> FromExpression(Activity<T> expression);
+        public static InArgument<T> FromValue(T constValue);
+        public static InArgument<T> FromVariable(Variable variable);
+        public new T Get(ActivityContext context);
+        public static implicit operator InArgument<T> (Activity<T> expression);
+        public static implicit operator InArgument<T> (DelegateArgument delegateArgument);
+        public static implicit operator InArgument<T> (Variable variable);
+        public static implicit operator InArgument<T> (T constValue);
+        public void Set(ActivityContext context, T value);
+    }
+    public abstract class InOutArgument : Argument {
+        public static InOutArgument CreateReference(InOutArgument argumentToReference, string referencedArgumentName);
+    }
+    public sealed class InOutArgument<T> : InOutArgument {
+        public InOutArgument();
+        public InOutArgument(Activity<Location<T>> expression);
+        public InOutArgument(Variable variable);
+        public InOutArgument(Variable<T> variable);
+        public InOutArgument(Expression<Func<ActivityContext, T>> expression);
+        public new Activity<Location<T>> Expression { get; set; }
+        public static InOutArgument<T> FromExpression(Activity<Location<T>> expression);
+        public static InOutArgument<T> FromVariable(Variable<T> variable);
+        public new T Get(ActivityContext context);
+        public new Location<T> GetLocation(ActivityContext context);
+        public static implicit operator InOutArgument<T> (Activity<Location<T>> expression);
+        public static implicit operator InOutArgument<T> (Variable<T> variable);
+        public void Set(ActivityContext context, T value);
+    }
+    public class InvalidWorkflowException : Exception {
+        public InvalidWorkflowException();
+        protected InvalidWorkflowException(SerializationInfo info, StreamingContext context);
+        public InvalidWorkflowException(string message);
+        public InvalidWorkflowException(string message, Exception innerException);
+    }
+    public class InvokeCompletedEventArgs : AsyncCompletedEventArgs {
+        public IDictionary<string, object> Outputs { get; private set; }
+    }
+    public interface IPropertyRegistrationCallback {
+        void Register(RegistrationContext context);
+        void Unregister(RegistrationContext context);
+    }
+    public abstract class Location {
+        protected Location();
+        public abstract Type LocationType { get; }
+        public object Value { get; set; }
+        protected abstract object ValueCore { get; set; }
+    }
+    public class Location<T> : Location {
+        public Location();
+        public override Type LocationType { get; }
+        public virtual new T Value { get; set; }
+        protected sealed override object ValueCore { get; set; }
+        public override string ToString();
+    }
+    public abstract class LocationReference {
+        protected LocationReference();
+        public string Name { get; }
+        protected abstract string NameCore { get; }
+        public Type Type { get; }
+        protected abstract Type TypeCore { get; }
+        public abstract Location GetLocation(ActivityContext context);
+    }
+    public abstract class LocationReferenceEnvironment {
+        protected LocationReferenceEnvironment();
+        public LocationReferenceEnvironment Parent { get; protected set; }
+        public abstract Activity Root { get; }
+        public abstract IEnumerable<LocationReference> GetLocationReferences();
+        public abstract bool IsVisible(LocationReference locationReference);
+        public abstract bool TryGetLocationReference(string name, out LocationReference result);
+    }
+    public abstract class NativeActivity : Activity, IInstanceUpdatable {
+        protected NativeActivity();
+        protected virtual bool CanInduceIdle { get; }
+        protected sealed override Func<Activity> Implementation { get; set; }
+        protected internal sealed override Version ImplementationVersion { get; set; }
+        protected virtual void Abort(NativeActivityAbortContext context);
+        protected sealed override void CacheMetadata(ActivityMetadata metadata);
+        protected virtual void CacheMetadata(NativeActivityMetadata metadata);
+        protected virtual void Cancel(NativeActivityContext context);
+        protected abstract void Execute(NativeActivityContext context);
+        protected virtual void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+        protected sealed override void OnCreateDynamicUpdateMap(UpdateMapMetadata metadata, Activity originalActivity);
+        protected virtual void UpdateInstance(NativeActivityUpdateContext updateContext);
+    }
+    public abstract class NativeActivity<TResult> : Activity<TResult>, IInstanceUpdatable {
+        protected NativeActivity();
+        protected virtual bool CanInduceIdle { get; }
+        protected sealed override Func<Activity> Implementation { get; set; }
+        protected internal sealed override Version ImplementationVersion { get; set; }
+        protected virtual void Abort(NativeActivityAbortContext context);
+        protected sealed override void CacheMetadata(ActivityMetadata metadata);
+        protected virtual void CacheMetadata(NativeActivityMetadata metadata);
+        protected virtual void Cancel(NativeActivityContext context);
+        protected abstract void Execute(NativeActivityContext context);
+        protected virtual void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+        protected sealed override void OnCreateDynamicUpdateMap(UpdateMapMetadata metadata, Activity originalActivity);
+        protected virtual void UpdateInstance(NativeActivityUpdateContext updateContext);
+    }
+    public sealed class NativeActivityAbortContext : ActivityContext {
+        public Exception Reason { get; }
+    }
+    public class NativeActivityContext : ActivityContext {
+        public BookmarkScope DefaultBookmarkScope { get; }
+        public bool IsCancellationRequested { get; }
+        public ExecutionProperties Properties { get; }
+        public void Abort();
+        public void Abort(Exception reason);
+        public void AbortChildInstance(ActivityInstance activity);
+        public void AbortChildInstance(ActivityInstance activity, Exception reason);
+        public void CancelChild(ActivityInstance activityInstance);
+        public void CancelChildren();
+        public Bookmark CreateBookmark();
+        public Bookmark CreateBookmark(BookmarkCallback callback);
+        public Bookmark CreateBookmark(BookmarkCallback callback, BookmarkOptions options);
+        public Bookmark CreateBookmark(string name);
+        public Bookmark CreateBookmark(string name, BookmarkCallback callback);
+        public Bookmark CreateBookmark(string name, BookmarkCallback callback, BookmarkOptions options);
+        public Bookmark CreateBookmark(string name, BookmarkCallback callback, BookmarkScope scope);
+        public Bookmark CreateBookmark(string name, BookmarkCallback callback, BookmarkScope scope, BookmarkOptions options);
+        public ReadOnlyCollection<ActivityInstance> GetChildren();
+        public object GetValue(Variable variable);
+        public T GetValue<T>(Variable<T> variable);
+        public void MarkCanceled();
+        public void RemoveAllBookmarks();
+        public bool RemoveBookmark(Bookmark bookmark);
+        public bool RemoveBookmark(string name);
+        public bool RemoveBookmark(string name, BookmarkScope scope);
+        public BookmarkResumptionResult ResumeBookmark(Bookmark bookmark, object value);
+        public ActivityInstance ScheduleAction(ActivityAction activityAction, CompletionCallback onCompleted=null, FaultCallback onFaulted=null);
+        public ActivityInstance ScheduleAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, T12 argument12, T13 argument13, T14 argument14, T15 argument15, T16 argument16, CompletionCallback onCompleted=null, FaultCallback onFaulted=null);
+        public ActivityInstance ScheduleAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, T12 argument12, T13 argument13, T14 argument14, T15 argument15, CompletionCallback onCompleted=null, FaultCallback onFaulted=null);
+        public ActivityInstance ScheduleAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, T12 argument12, T13 argument13, T14 argument14, CompletionCallback onCompleted=null, FaultCallback onFaulted=null);
+        public ActivityInstance ScheduleAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, T12 argument12, T13 argument13, CompletionCallback onCompleted=null, FaultCallback onFaulted=null);
+        public ActivityInstance ScheduleAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, T12 argument12, CompletionCallback onCompleted=null, FaultCallback onFaulted=null);
+        public ActivityInstance ScheduleAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, CompletionCallback onCompleted=null, FaultCallback onFaulted=null);
+        public ActivityInstance ScheduleAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, CompletionCallback onCompleted=null, FaultCallback onFaulted=null);
+        public ActivityInstance ScheduleAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>(ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, CompletionCallback onCompleted=null, FaultCallback onFaulted=null);
+        public ActivityInstance ScheduleAction<T1, T2, T3, T4, T5, T6, T7, T8>(ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, CompletionCallback onCompleted=null, FaultCallback onFaulted=null);
+        public ActivityInstance ScheduleAction<T1, T2, T3, T4, T5, T6, T7>(ActivityAction<T1, T2, T3, T4, T5, T6, T7> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, CompletionCallback onCompleted=null, FaultCallback onFaulted=null);
+        public ActivityInstance ScheduleAction<T1, T2, T3, T4, T5, T6>(ActivityAction<T1, T2, T3, T4, T5, T6> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, CompletionCallback onCompleted=null, FaultCallback onFaulted=null);
+        public ActivityInstance ScheduleAction<T1, T2, T3, T4, T5>(ActivityAction<T1, T2, T3, T4, T5> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, CompletionCallback onCompleted=null, FaultCallback onFaulted=null);
+        public ActivityInstance ScheduleAction<T1, T2, T3, T4>(ActivityAction<T1, T2, T3, T4> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, CompletionCallback onCompleted=null, FaultCallback onFaulted=null);
+        public ActivityInstance ScheduleAction<T1, T2, T3>(ActivityAction<T1, T2, T3> activityAction, T1 argument1, T2 argument2, T3 argument3, CompletionCallback onCompleted=null, FaultCallback onFaulted=null);
+        public ActivityInstance ScheduleAction<T1, T2>(ActivityAction<T1, T2> activityAction, T1 argument1, T2 argument2, CompletionCallback onCompleted=null, FaultCallback onFaulted=null);
+        public ActivityInstance ScheduleAction<T>(ActivityAction<T> activityAction, T argument, CompletionCallback onCompleted=null, FaultCallback onFaulted=null);
+        public ActivityInstance ScheduleActivity(Activity activity);
+        public ActivityInstance ScheduleActivity(Activity activity, CompletionCallback onCompleted);
+        public ActivityInstance ScheduleActivity(Activity activity, CompletionCallback onCompleted, FaultCallback onFaulted);
+        public ActivityInstance ScheduleActivity(Activity activity, FaultCallback onFaulted);
+        public ActivityInstance ScheduleActivity<TResult>(Activity<TResult> activity, CompletionCallback<TResult> onCompleted=null, FaultCallback onFaulted=null);
+        public ActivityInstance ScheduleDelegate(ActivityDelegate activityDelegate, IDictionary<string, object> inputParameters, DelegateCompletionCallback onCompleted=null, FaultCallback onFaulted=null);
+        public ActivityInstance ScheduleFunc<T, TResult>(ActivityFunc<T, TResult> activityFunc, T argument, CompletionCallback<TResult> onCompleted=null, FaultCallback onFaulted=null);
+        public ActivityInstance ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, T12 argument12, T13 argument13, T14 argument14, T15 argument15, T16 argument16, CompletionCallback<TResult> onCompleted=null, FaultCallback onFaulted=null);
+        public ActivityInstance ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, T12 argument12, T13 argument13, T14 argument14, T15 argument15, CompletionCallback<TResult> onCompleted=null, FaultCallback onFaulted=null);
+        public ActivityInstance ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, T12 argument12, T13 argument13, T14 argument14, CompletionCallback<TResult> onCompleted=null, FaultCallback onFaulted=null);
+        public ActivityInstance ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, T12 argument12, T13 argument13, CompletionCallback<TResult> onCompleted=null, FaultCallback onFaulted=null);
+        public ActivityInstance ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, T12 argument12, CompletionCallback<TResult> onCompleted=null, FaultCallback onFaulted=null);
+        public ActivityInstance ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, CompletionCallback<TResult> onCompleted=null, FaultCallback onFaulted=null);
+        public ActivityInstance ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, CompletionCallback<TResult> onCompleted=null, FaultCallback onFaulted=null);
+        public ActivityInstance ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, CompletionCallback<TResult> onCompleted=null, FaultCallback onFaulted=null);
+        public ActivityInstance ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, CompletionCallback<TResult> onCompleted=null, FaultCallback onFaulted=null);
+        public ActivityInstance ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, TResult>(ActivityFunc<T1, T2, T3, T4, T5, T6, T7, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, CompletionCallback<TResult> onCompleted=null, FaultCallback onFaulted=null);
+        public ActivityInstance ScheduleFunc<T1, T2, T3, T4, T5, T6, TResult>(ActivityFunc<T1, T2, T3, T4, T5, T6, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, CompletionCallback<TResult> onCompleted=null, FaultCallback onFaulted=null);
+        public ActivityInstance ScheduleFunc<T1, T2, T3, T4, T5, TResult>(ActivityFunc<T1, T2, T3, T4, T5, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, CompletionCallback<TResult> onCompleted=null, FaultCallback onFaulted=null);
+        public ActivityInstance ScheduleFunc<T1, T2, T3, T4, TResult>(ActivityFunc<T1, T2, T3, T4, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, CompletionCallback<TResult> onCompleted=null, FaultCallback onFaulted=null);
+        public ActivityInstance ScheduleFunc<T1, T2, T3, TResult>(ActivityFunc<T1, T2, T3, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, CompletionCallback<TResult> onCompleted=null, FaultCallback onFaulted=null);
+        public ActivityInstance ScheduleFunc<T1, T2, TResult>(ActivityFunc<T1, T2, TResult> activityFunc, T1 argument1, T2 argument2, CompletionCallback<TResult> onCompleted=null, FaultCallback onFaulted=null);
+        public ActivityInstance ScheduleFunc<TResult>(ActivityFunc<TResult> activityFunc, CompletionCallback<TResult> onCompleted=null, FaultCallback onFaulted=null);
+        public void SetValue(Variable variable, object value);
+        public void SetValue<T>(Variable<T> variable, T value);
+        public void Track(CustomTrackingRecord record);
+    }
+    public sealed class NativeActivityFaultContext : NativeActivityContext {
+        public void HandleFault();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct NativeActivityMetadata {
+        public LocationReferenceEnvironment Environment { get; }
+        public bool HasViolations { get; }
+        public void AddArgument(RuntimeArgument argument);
+        public void AddChild(Activity child);
+        public void AddChild(Activity child, object origin);
+        public void AddDefaultExtensionProvider<T>(Func<T> extensionProvider) where T : class;
+        public void AddDelegate(ActivityDelegate activityDelegate);
+        public void AddDelegate(ActivityDelegate activityDelegate, object origin);
+        public void AddImplementationChild(Activity implementationChild);
+        public void AddImplementationDelegate(ActivityDelegate implementationDelegate);
+        public void AddImplementationVariable(Variable implementationVariable);
+        public void AddImportedChild(Activity importedChild);
+        public void AddImportedChild(Activity importedChild, object origin);
+        public void AddImportedDelegate(ActivityDelegate importedDelegate);
+        public void AddImportedDelegate(ActivityDelegate importedDelegate, object origin);
+        public void AddValidationError(ValidationError validationError);
+        public void AddValidationError(string validationErrorMessage);
+        public void AddVariable(Variable variable);
+        public void AddVariable(Variable variable, object origin);
+        public void Bind(Argument binding, RuntimeArgument argument);
+        public override bool Equals(object obj);
+        public Collection<RuntimeArgument> GetArgumentsWithReflection();
+        public Collection<Activity> GetChildrenWithReflection();
+        public Collection<ActivityDelegate> GetDelegatesWithReflection();
+        public override int GetHashCode();
+        public Collection<Variable> GetVariablesWithReflection();
+        public static bool operator ==(NativeActivityMetadata left, NativeActivityMetadata right);
+        public static bool operator !=(NativeActivityMetadata left, NativeActivityMetadata right);
+        public void RequireExtension(Type extensionType);
+        public void RequireExtension<T>() where T : class;
+        public void SetArgumentsCollection(Collection<RuntimeArgument> arguments);
+        public void SetChildrenCollection(Collection<Activity> children);
+        public void SetDelegatesCollection(Collection<ActivityDelegate> delegates);
+        public void SetImplementationChildrenCollection(Collection<Activity> implementationChildren);
+        public void SetImplementationDelegatesCollection(Collection<ActivityDelegate> implementationDelegates);
+        public void SetImplementationVariablesCollection(Collection<Variable> implementationVariables);
+        public void SetImportedChildrenCollection(Collection<Activity> importedChildren);
+        public void SetImportedDelegatesCollection(Collection<ActivityDelegate> importedDelegates);
+        public void SetValidationErrorsCollection(Collection<ValidationError> validationErrors);
+        public void SetVariablesCollection(Collection<Variable> variables);
+    }
+    public sealed class NativeActivityTransactionContext : NativeActivityContext {
+        public void SetRuntimeTransaction(Transaction transaction);
+    }
+    public class NoPersistHandle : Handle {
+        public NoPersistHandle();
+        public void Enter(NativeActivityContext context);
+        public void Exit(NativeActivityContext context);
+    }
+    public abstract class OutArgument : Argument {
+        public static OutArgument CreateReference(InOutArgument argumentToReference, string referencedArgumentName);
+        public static OutArgument CreateReference(OutArgument argumentToReference, string referencedArgumentName);
+    }
+    public sealed class OutArgument<T> : OutArgument {
+        public OutArgument();
+        public OutArgument(Activity<Location<T>> expression);
+        public OutArgument(DelegateArgument delegateArgument);
+        public OutArgument(Variable variable);
+        public OutArgument(Expression<Func<ActivityContext, T>> expression);
+        public new Activity<Location<T>> Expression { get; set; }
+        public static OutArgument<T> FromDelegateArgument(DelegateArgument delegateArgument);
+        public static OutArgument<T> FromExpression(Activity<Location<T>> expression);
+        public static OutArgument<T> FromVariable(Variable variable);
+        public new T Get(ActivityContext context);
+        public new Location<T> GetLocation(ActivityContext context);
+        public static implicit operator OutArgument<T> (Activity<Location<T>> expression);
+        public static implicit operator OutArgument<T> (DelegateArgument delegateArgument);
+        public static implicit operator OutArgument<T> (Variable variable);
+        public void Set(ActivityContext context, T value);
+    }
+    public sealed class OverloadGroupAttribute : Attribute {
+        public OverloadGroupAttribute();
+        public OverloadGroupAttribute(string groupName);
+        public string GroupName { get; set; }
+        public override object TypeId { get; }
+    }
+    public enum PersistableIdleAction {
+        None = 0,
+        Persist = 2,
+        Unload = 1,
+    }
+    public sealed class RegistrationContext {
+        public object FindProperty(string name);
+    }
+    public sealed class RequiredArgumentAttribute : Attribute {
+        public RequiredArgumentAttribute();
+        public override object TypeId { get; }
+    }
+    public sealed class RuntimeArgument : LocationReference {
+        public RuntimeArgument(string name, Type argumentType, ArgumentDirection direction);
+        public RuntimeArgument(string name, Type argumentType, ArgumentDirection direction, bool isRequired);
+        public RuntimeArgument(string name, Type argumentType, ArgumentDirection direction, bool isRequired, List<string> overloadGroupNames);
+        public RuntimeArgument(string name, Type argumentType, ArgumentDirection direction, List<string> overloadGroupNames);
+        public ArgumentDirection Direction { get; private set; }
+        public bool IsRequired { get; private set; }
+        protected override string NameCore { get; }
+        public ReadOnlyCollection<string> OverloadGroupNames { get; }
+        protected override Type TypeCore { get; }
+        public object Get(ActivityContext context);
+        public T Get<T>(ActivityContext context);
+        public override Location GetLocation(ActivityContext context);
+        public void Set(ActivityContext context, object value);
+    }
+    public sealed class RuntimeDelegateArgument {
+        public RuntimeDelegateArgument(string name, Type type, ArgumentDirection direction, DelegateArgument boundArgument);
+        public DelegateArgument BoundArgument { get; private set; }
+        public ArgumentDirection Direction { get; private set; }
+        public string Name { get; private set; }
+        public Type Type { get; private set; }
+    }
+    public sealed class RuntimeTransactionHandle : Handle, IExecutionProperty, IPropertyRegistrationCallback {
+        public RuntimeTransactionHandle();
+        public RuntimeTransactionHandle(Transaction rootTransaction);
+        public bool AbortInstanceOnTransactionFailure { get; set; }
+        public bool SuppressTransaction { get; set; }
+        public void CompleteTransaction(NativeActivityContext context);
+        public void CompleteTransaction(NativeActivityContext context, BookmarkCallback callback);
+        public Transaction GetCurrentTransaction(AsyncCodeActivityContext context);
+        public Transaction GetCurrentTransaction(CodeActivityContext context);
+        public Transaction GetCurrentTransaction(NativeActivityContext context);
+        protected override void OnInitialize(HandleInitializationContext context);
+        protected override void OnUninitialize(HandleInitializationContext context);
+        public void RequestTransactionContext(NativeActivityContext context, Action<NativeActivityTransactionContext, object> callback, object state);
+        public void RequireTransactionContext(NativeActivityContext context, Action<NativeActivityTransactionContext, object> callback, object state);
+        void System.Activities.IExecutionProperty.CleanupWorkflowThread();
+        void System.Activities.IExecutionProperty.SetupWorkflowThread();
+        void System.Activities.IPropertyRegistrationCallback.Register(RegistrationContext context);
+        void System.Activities.IPropertyRegistrationCallback.Unregister(RegistrationContext context);
+    }
+    public enum UnhandledExceptionAction {
+        Abort = 0,
+        Cancel = 1,
+        Terminate = 2,
+    }
+    public class ValidationException : SystemException {
+        public ValidationException();
+        protected ValidationException(SerializationInfo info, StreamingContext context);
+        public ValidationException(string message);
+        public ValidationException(string message, Exception innerException);
+    }
+    public abstract class Variable : LocationReference {
+        public ActivityWithResult Default { get; set; }
+        public VariableModifiers Modifiers { get; set; }
+        public new string Name { get; set; }
+        protected override string NameCore { get; }
+        public static Variable Create(string name, Type type, VariableModifiers modifiers);
+        public object Get(ActivityContext context);
+        public override Location GetLocation(ActivityContext context);
+        public void Set(ActivityContext context, object value);
+    }
+    public sealed class Variable<T> : Variable {
+        public Variable();
+        public Variable(Expression<Func<ActivityContext, T>> defaultExpression);
+        public Variable(string name);
+        public Variable(string name, Expression<Func<ActivityContext, T>> defaultExpression);
+        public Variable(string name, T defaultValue);
+        public new Activity<T> Default { get; set; }
+        protected override Type TypeCore { get; }
+        public new T Get(ActivityContext context);
+        public new Location<T> GetLocation(ActivityContext context);
+        public void Set(ActivityContext context, T value);
+    }
+    public enum VariableModifiers {
+        Mapped = 2,
+        None = 0,
+        ReadOnly = 1,
+    }
+    public class VersionMismatchException : Exception {
+        public VersionMismatchException();
+        public VersionMismatchException(WorkflowIdentity expectedVersion, WorkflowIdentity actualVersion);
+        protected VersionMismatchException(SerializationInfo info, StreamingContext context);
+        public VersionMismatchException(string message);
+        public VersionMismatchException(string message, WorkflowIdentity expectedVersion, WorkflowIdentity actualVersion);
+        public VersionMismatchException(string message, WorkflowIdentity expectedVersion, WorkflowIdentity actualVersion, Exception innerException);
+        public VersionMismatchException(string message, Exception innerException);
+        public WorkflowIdentity ActualVersion { get; private set; }
+        public WorkflowIdentity ExpectedVersion { get; private set; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public sealed class WorkflowApplication : WorkflowInstance {
+        public WorkflowApplication(Activity workflowDefinition);
+        public WorkflowApplication(Activity workflowDefinition, WorkflowIdentity definitionIdentity);
+        public WorkflowApplication(Activity workflowDefinition, IDictionary<string, object> inputs);
+        public WorkflowApplication(Activity workflowDefinition, IDictionary<string, object> inputs, WorkflowIdentity definitionIdentity);
+        public Action<WorkflowApplicationAbortedEventArgs> Aborted { get; set; }
+        public Action<WorkflowApplicationCompletedEventArgs> Completed { get; set; }
+        public WorkflowInstanceExtensionManager Extensions { get; }
+        public override Guid Id { get; }
+        public Action<WorkflowApplicationIdleEventArgs> Idle { get; set; }
+        public InstanceStore InstanceStore { get; set; }
+        public Func<WorkflowApplicationUnhandledExceptionEventArgs, UnhandledExceptionAction> OnUnhandledException { get; set; }
+        public Func<WorkflowApplicationIdleEventArgs, PersistableIdleAction> PersistableIdle { get; set; }
+        protected internal override bool SupportsInstanceKeys { get; }
+        public Action<WorkflowApplicationEventArgs> Unloaded { get; set; }
+        public void Abort();
+        public void Abort(string reason);
+        public void AddInitialInstanceValues(IDictionary<XName, object> writeOnlyValues);
+        public IAsyncResult BeginCancel(AsyncCallback callback, object state);
+        public IAsyncResult BeginCancel(TimeSpan timeout, AsyncCallback callback, object state);
+        public static IAsyncResult BeginCreateDefaultInstanceOwner(InstanceStore instanceStore, WorkflowIdentity definitionIdentity, WorkflowIdentityFilter identityFilter, AsyncCallback callback, object state);
+        public static IAsyncResult BeginCreateDefaultInstanceOwner(InstanceStore instanceStore, WorkflowIdentity definitionIdentity, WorkflowIdentityFilter identityFilter, TimeSpan timeout, AsyncCallback callback, object state);
+        public static IAsyncResult BeginDeleteDefaultInstanceOwner(InstanceStore instanceStore, AsyncCallback callback, object state);
+        public static IAsyncResult BeginDeleteDefaultInstanceOwner(InstanceStore instanceStore, TimeSpan timeout, AsyncCallback callback, object state);
+        public static IAsyncResult BeginGetInstance(Guid instanceId, InstanceStore instanceStore, AsyncCallback callback, object state);
+        public static IAsyncResult BeginGetInstance(Guid instanceId, InstanceStore instanceStore, TimeSpan timeout, AsyncCallback callback, object state);
+        public static IAsyncResult BeginGetRunnableInstance(InstanceStore instanceStore, AsyncCallback callback, object state);
+        public static IAsyncResult BeginGetRunnableInstance(InstanceStore instanceStore, TimeSpan timeout, AsyncCallback callback, object state);
+        public IAsyncResult BeginLoad(WorkflowApplicationInstance instance, DynamicUpdateMap updateMap, AsyncCallback callback, object state);
+        public IAsyncResult BeginLoad(WorkflowApplicationInstance instance, DynamicUpdateMap updateMap, TimeSpan timeout, AsyncCallback callback, object state);
+        public IAsyncResult BeginLoad(WorkflowApplicationInstance instance, AsyncCallback callback, object state);
+        public IAsyncResult BeginLoad(WorkflowApplicationInstance instance, TimeSpan timeout, AsyncCallback callback, object state);
+        public IAsyncResult BeginLoad(Guid instanceId, AsyncCallback callback, object state);
+        public IAsyncResult BeginLoad(Guid instanceId, TimeSpan timeout, AsyncCallback callback, object state);
+        public IAsyncResult BeginLoadRunnableInstance(AsyncCallback callback, object state);
+        public IAsyncResult BeginLoadRunnableInstance(TimeSpan timeout, AsyncCallback callback, object state);
+        public IAsyncResult BeginPersist(AsyncCallback callback, object state);
+        public IAsyncResult BeginPersist(TimeSpan timeout, AsyncCallback callback, object state);
+        public IAsyncResult BeginResumeBookmark(Bookmark bookmark, object value, AsyncCallback callback, object state);
+        public IAsyncResult BeginResumeBookmark(Bookmark bookmark, object value, TimeSpan timeout, AsyncCallback callback, object state);
+        public IAsyncResult BeginResumeBookmark(string bookmarkName, object value, AsyncCallback callback, object state);
+        public IAsyncResult BeginResumeBookmark(string bookmarkName, object value, TimeSpan timeout, AsyncCallback callback, object state);
+        public IAsyncResult BeginRun(AsyncCallback callback, object state);
+        public IAsyncResult BeginRun(TimeSpan timeout, AsyncCallback callback, object state);
+        public IAsyncResult BeginTerminate(Exception reason, AsyncCallback callback, object state);
+        public IAsyncResult BeginTerminate(Exception reason, TimeSpan timeout, AsyncCallback callback, object state);
+        public IAsyncResult BeginTerminate(string reason, AsyncCallback callback, object state);
+        public IAsyncResult BeginTerminate(string reason, TimeSpan timeout, AsyncCallback callback, object state);
+        public IAsyncResult BeginUnload(AsyncCallback callback, object state);
+        public IAsyncResult BeginUnload(TimeSpan timeout, AsyncCallback callback, object state);
+        public void Cancel();
+        public void Cancel(TimeSpan timeout);
+        public static void CreateDefaultInstanceOwner(InstanceStore instanceStore, WorkflowIdentity definitionIdentity, WorkflowIdentityFilter identityFilter);
+        public static void CreateDefaultInstanceOwner(InstanceStore instanceStore, WorkflowIdentity definitionIdentity, WorkflowIdentityFilter identityFilter, TimeSpan timeout);
+        public static void DeleteDefaultInstanceOwner(InstanceStore instanceStore);
+        public static void DeleteDefaultInstanceOwner(InstanceStore instanceStore, TimeSpan timeout);
+        public void EndCancel(IAsyncResult result);
+        public static void EndCreateDefaultInstanceOwner(IAsyncResult asyncResult);
+        public static void EndDeleteDefaultInstanceOwner(IAsyncResult asyncResult);
+        public static WorkflowApplicationInstance EndGetInstance(IAsyncResult asyncResult);
+        public static WorkflowApplicationInstance EndGetRunnableInstance(IAsyncResult asyncResult);
+        public void EndLoad(IAsyncResult result);
+        public void EndLoadRunnableInstance(IAsyncResult result);
+        public void EndPersist(IAsyncResult result);
+        public BookmarkResumptionResult EndResumeBookmark(IAsyncResult result);
+        public void EndRun(IAsyncResult result);
+        public void EndTerminate(IAsyncResult result);
+        public void EndUnload(IAsyncResult result);
+        public ReadOnlyCollection<BookmarkInfo> GetBookmarks();
+        public ReadOnlyCollection<BookmarkInfo> GetBookmarks(TimeSpan timeout);
+        public static WorkflowApplicationInstance GetInstance(Guid instanceId, InstanceStore instanceStore);
+        public static WorkflowApplicationInstance GetInstance(Guid instanceId, InstanceStore instanceStore, TimeSpan timeout);
+        public static WorkflowApplicationInstance GetRunnableInstance(InstanceStore instanceStore);
+        public static WorkflowApplicationInstance GetRunnableInstance(InstanceStore instanceStore, TimeSpan timeout);
+        public void Load(WorkflowApplicationInstance instance);
+        public void Load(WorkflowApplicationInstance instance, DynamicUpdateMap updateMap);
+        public void Load(WorkflowApplicationInstance instance, DynamicUpdateMap updateMap, TimeSpan timeout);
+        public void Load(WorkflowApplicationInstance instance, TimeSpan timeout);
+        public void Load(Guid instanceId);
+        public void Load(Guid instanceId, TimeSpan timeout);
+        public void LoadRunnableInstance();
+        public void LoadRunnableInstance(TimeSpan timeout);
+        protected internal override IAsyncResult OnBeginAssociateKeys(ICollection<InstanceKey> keys, AsyncCallback callback, object state);
+        protected internal override IAsyncResult OnBeginPersist(AsyncCallback callback, object state);
+        protected internal override IAsyncResult OnBeginResumeBookmark(Bookmark bookmark, object value, TimeSpan timeout, AsyncCallback callback, object state);
+        protected internal override void OnDisassociateKeys(ICollection<InstanceKey> keys);
+        protected internal override void OnEndAssociateKeys(IAsyncResult result);
+        protected internal override void OnEndPersist(IAsyncResult result);
+        protected internal override BookmarkResumptionResult OnEndResumeBookmark(IAsyncResult result);
+        protected override void OnNotifyPaused();
+        protected override void OnNotifyUnhandledException(Exception exception, Activity exceptionSource, string exceptionSourceInstanceId);
+        protected internal override void OnRequestAbort(Exception reason);
+        public void Persist();
+        public void Persist(TimeSpan timeout);
+        public BookmarkResumptionResult ResumeBookmark(Bookmark bookmark, object value);
+        public BookmarkResumptionResult ResumeBookmark(Bookmark bookmark, object value, TimeSpan timeout);
+        public BookmarkResumptionResult ResumeBookmark(string bookmarkName, object value);
+        public BookmarkResumptionResult ResumeBookmark(string bookmarkName, object value, TimeSpan timeout);
+        public void Run();
+        public void Run(TimeSpan timeout);
+        public void Terminate(Exception reason);
+        public void Terminate(Exception reason, TimeSpan timeout);
+        public void Terminate(string reason);
+        public void Terminate(string reason, TimeSpan timeout);
+        public void Unload();
+        public void Unload(TimeSpan timeout);
+    }
+    public class WorkflowApplicationAbortedEventArgs : WorkflowApplicationEventArgs {
+        public Exception Reason { get; private set; }
+    }
+    public class WorkflowApplicationAbortedException : WorkflowApplicationException {
+        public WorkflowApplicationAbortedException();
+        protected WorkflowApplicationAbortedException(SerializationInfo info, StreamingContext context);
+        public WorkflowApplicationAbortedException(string message);
+        public WorkflowApplicationAbortedException(string message, Exception innerException);
+        public WorkflowApplicationAbortedException(string message, Guid instanceId);
+        public WorkflowApplicationAbortedException(string message, Guid instanceId, Exception innerException);
+    }
+    public class WorkflowApplicationCompletedEventArgs : WorkflowApplicationEventArgs {
+        public ActivityInstanceState CompletionState { get; }
+        public IDictionary<string, object> Outputs { get; }
+        public Exception TerminationException { get; }
+    }
+    public class WorkflowApplicationCompletedException : WorkflowApplicationException {
+        public WorkflowApplicationCompletedException();
+        protected WorkflowApplicationCompletedException(SerializationInfo info, StreamingContext context);
+        public WorkflowApplicationCompletedException(string message);
+        public WorkflowApplicationCompletedException(string message, Exception innerException);
+        public WorkflowApplicationCompletedException(string message, Guid instanceId);
+        public WorkflowApplicationCompletedException(string message, Guid instanceId, Exception innerException);
+    }
+    public class WorkflowApplicationEventArgs : EventArgs {
+        public Guid InstanceId { get; }
+        public IEnumerable<T> GetInstanceExtensions<T>() where T : class;
+    }
+    public class WorkflowApplicationException : Exception {
+        public WorkflowApplicationException();
+        protected WorkflowApplicationException(SerializationInfo info, StreamingContext context);
+        public WorkflowApplicationException(string message);
+        public WorkflowApplicationException(string message, Exception innerException);
+        public WorkflowApplicationException(string message, Guid instanceId);
+        public WorkflowApplicationException(string message, Guid instanceId, Exception innerException);
+        public Guid InstanceId { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class WorkflowApplicationIdleEventArgs : WorkflowApplicationEventArgs {
+        public ReadOnlyCollection<BookmarkInfo> Bookmarks { get; }
+    }
+    public class WorkflowApplicationInstance {
+        public WorkflowIdentity DefinitionIdentity { get; private set; }
+        public Guid InstanceId { get; }
+        public InstanceStore InstanceStore { get; }
+        public void Abandon();
+        public void Abandon(TimeSpan timeout);
+        public IAsyncResult BeginAbandon(AsyncCallback callback, object state);
+        public IAsyncResult BeginAbandon(TimeSpan timeout, AsyncCallback callback, object state);
+        public bool CanApplyUpdate(DynamicUpdateMap updateMap, out IList<ActivityBlockingUpdate> activitiesBlockingUpdate);
+        public void EndAbandon(IAsyncResult asyncResult);
+    }
+    public class WorkflowApplicationTerminatedException : WorkflowApplicationCompletedException {
+        public WorkflowApplicationTerminatedException();
+        protected WorkflowApplicationTerminatedException(SerializationInfo info, StreamingContext context);
+        public WorkflowApplicationTerminatedException(string message);
+        public WorkflowApplicationTerminatedException(string message, Exception innerException);
+        public WorkflowApplicationTerminatedException(string message, Guid instanceId);
+        public WorkflowApplicationTerminatedException(string message, Guid instanceId, Exception innerException);
+    }
+    public class WorkflowApplicationUnhandledExceptionEventArgs : WorkflowApplicationEventArgs {
+        public Activity ExceptionSource { get; private set; }
+        public string ExceptionSourceInstanceId { get; private set; }
+        public Exception UnhandledException { get; private set; }
+    }
+    public class WorkflowApplicationUnloadedException : WorkflowApplicationException {
+        public WorkflowApplicationUnloadedException();
+        protected WorkflowApplicationUnloadedException(SerializationInfo info, StreamingContext context);
+        public WorkflowApplicationUnloadedException(string message);
+        public WorkflowApplicationUnloadedException(string message, Exception innerException);
+        public WorkflowApplicationUnloadedException(string message, Guid instanceId);
+        public WorkflowApplicationUnloadedException(string message, Guid instanceId, Exception innerException);
+    }
+    public sealed class WorkflowDataContext : CustomTypeDescriptor, IDisposable, INotifyPropertyChanged {
+        public event PropertyChangedEventHandler PropertyChanged;
+        public void Dispose();
+        public override PropertyDescriptorCollection GetProperties();
+    }
+    public class WorkflowIdentity : IEquatable<WorkflowIdentity> {
+        public WorkflowIdentity();
+        public WorkflowIdentity(string name, Version version, string package);
+        public string Name { get; set; }
+        public string Package { get; set; }
+        public Version Version { get; set; }
+        public bool Equals(WorkflowIdentity other);
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public static WorkflowIdentity Parse(string identity);
+        public override string ToString();
+        public static bool TryParse(string identity, out WorkflowIdentity result);
+    }
+    public enum WorkflowIdentityFilter {
+        Any = 1,
+        AnyRevision = 2,
+        Exact = 0,
+    }
+    public static class WorkflowInspectionServices {
+        public static void CacheMetadata(Activity rootActivity);
+        public static void CacheMetadata(Activity rootActivity, LocationReferenceEnvironment hostEnvironment);
+        public static bool CanInduceIdle(Activity activity);
+        public static IEnumerable<Activity> GetActivities(Activity activity);
+        public static Version GetImplementationVersion(Activity activity);
+        public static Activity Resolve(Activity root, string id);
+    }
+    public sealed class WorkflowInvoker {
+        public WorkflowInvoker(Activity workflow);
+        public WorkflowInstanceExtensionManager Extensions { get; }
+        public event EventHandler<InvokeCompletedEventArgs> InvokeCompleted;
+        public IAsyncResult BeginInvoke(AsyncCallback callback, object state);
+        public IAsyncResult BeginInvoke(IDictionary<string, object> inputs, AsyncCallback callback, object state);
+        public IAsyncResult BeginInvoke(IDictionary<string, object> inputs, TimeSpan timeout, AsyncCallback callback, object state);
+        public IAsyncResult BeginInvoke(TimeSpan timeout, AsyncCallback callback, object state);
+        public void CancelAsync(object userState);
+        public IDictionary<string, object> EndInvoke(IAsyncResult result);
+        public IDictionary<string, object> Invoke();
+        public static IDictionary<string, object> Invoke(Activity workflow);
+        public static IDictionary<string, object> Invoke(Activity workflow, IDictionary<string, object> inputs);
+        public static IDictionary<string, object> Invoke(Activity workflow, IDictionary<string, object> inputs, TimeSpan timeout);
+        public static IDictionary<string, object> Invoke(Activity workflow, TimeSpan timeout);
+        public IDictionary<string, object> Invoke(IDictionary<string, object> inputs);
+        public IDictionary<string, object> Invoke(IDictionary<string, object> inputs, TimeSpan timeout);
+        public IDictionary<string, object> Invoke(TimeSpan timeout);
+        public static TResult Invoke<TResult>(Activity<TResult> workflow);
+        public static TResult Invoke<TResult>(Activity<TResult> workflow, IDictionary<string, object> inputs);
+        public static TResult Invoke<TResult>(Activity<TResult> workflow, IDictionary<string, object> inputs, out IDictionary<string, object> additionalOutputs, TimeSpan timeout);
+        public static TResult Invoke<TResult>(Activity<TResult> workflow, IDictionary<string, object> inputs, TimeSpan timeout);
+        public void InvokeAsync();
+        public void InvokeAsync(IDictionary<string, object> inputs);
+        public void InvokeAsync(IDictionary<string, object> inputs, object userState);
+        public void InvokeAsync(IDictionary<string, object> inputs, TimeSpan timeout);
+        public void InvokeAsync(IDictionary<string, object> inputs, TimeSpan timeout, object userState);
+        public void InvokeAsync(object userState);
+        public void InvokeAsync(TimeSpan timeout);
+        public void InvokeAsync(TimeSpan timeout, object userState);
+    }
+}
```

