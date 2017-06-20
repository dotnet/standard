# System.Activities.Statements

``` diff
+namespace System.Activities.Statements {
+    public sealed class AddToCollection<T> : CodeActivity {
+        public AddToCollection();
+        public InArgument<ICollection<T>> Collection { get; set; }
+        public InArgument<T> Item { get; set; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override void Execute(CodeActivityContext context);
+    }
+    public sealed class Assign : CodeActivity {
+        public Assign();
+        public OutArgument To { get; set; }
+        public InArgument Value { get; set; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override void Execute(CodeActivityContext context);
+    }
+    public sealed class Assign<T> : CodeActivity {
+        public Assign();
+        public OutArgument<T> To { get; set; }
+        public InArgument<T> Value { get; set; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override void Execute(CodeActivityContext context);
+    }
+    public sealed class CancellationScope : NativeActivity {
+        public CancellationScope();
+        public Activity Body { get; set; }
+        public Activity CancellationHandler { get; set; }
+        public Collection<Variable> Variables { get; }
+        protected override void CacheMetadata(NativeActivityMetadata metadata);
+        protected override void Cancel(NativeActivityContext context);
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public abstract class Catch {
+        public abstract Type ExceptionType { get; }
+    }
+    public sealed class Catch<TException> : Catch where TException : Exception {
+        public Catch();
+        public ActivityAction<TException> Action { get; set; }
+        public override Type ExceptionType { get; }
+    }
+    public sealed class ClearCollection<T> : CodeActivity {
+        public ClearCollection();
+        public InArgument<ICollection<T>> Collection { get; set; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override void Execute(CodeActivityContext context);
+    }
+    public sealed class CompensableActivity : NativeActivity<CompensationToken> {
+        public CompensableActivity();
+        public Activity Body { get; set; }
+        public Activity CancellationHandler { get; set; }
+        protected override bool CanInduceIdle { get; }
+        public Activity CompensationHandler { get; set; }
+        public Activity ConfirmationHandler { get; set; }
+        public Collection<Variable> Variables { get; }
+        protected override void CacheMetadata(NativeActivityMetadata metadata);
+        protected override void Cancel(NativeActivityContext context);
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class Compensate : NativeActivity {
+        public Compensate();
+        public InArgument<CompensationToken> Target { get; set; }
+        protected override void CacheMetadata(NativeActivityMetadata metadata);
+        protected override void Cancel(NativeActivityContext context);
+        protected override void Execute(NativeActivityContext context);
+    }
+    public class CompensationExtension : PersistenceParticipant, IWorkflowInstanceExtension {
+        public CompensationExtension();
+        protected override void CollectValues(out IDictionary<XName, object> readWriteValues, out IDictionary<XName, object> writeOnlyValues);
+        protected override void PublishValues(IDictionary<XName, object> readWriteValues);
+        IEnumerable<object> System.Activities.Hosting.IWorkflowInstanceExtension.GetAdditionalExtensions();
+        void System.Activities.Hosting.IWorkflowInstanceExtension.SetInstance(WorkflowInstanceProxy instance);
+    }
+    public sealed class CompensationToken
+    public sealed class Confirm : NativeActivity {
+        public Confirm();
+        public InArgument<CompensationToken> Target { get; set; }
+        protected override void CacheMetadata(NativeActivityMetadata metadata);
+        protected override void Cancel(NativeActivityContext context);
+        protected override void Execute(NativeActivityContext context);
+    }
+    public sealed class CreateBookmarkScope : NativeActivity<BookmarkScope> {
+        public CreateBookmarkScope();
+        protected override void CacheMetadata(NativeActivityMetadata metadata);
+        protected override void Execute(NativeActivityContext context);
+    }
+    public sealed class Delay : NativeActivity {
+        public Delay();
+        protected override bool CanInduceIdle { get; }
+        public InArgument<TimeSpan> Duration { get; set; }
+        protected override void Abort(NativeActivityAbortContext context);
+        protected override void CacheMetadata(NativeActivityMetadata metadata);
+        protected override void Cancel(NativeActivityContext context);
+        protected override void Execute(NativeActivityContext context);
+    }
+    public sealed class DeleteBookmarkScope : NativeActivity {
+        public DeleteBookmarkScope();
+        public InArgument<BookmarkScope> Scope { get; set; }
+        protected override void CacheMetadata(NativeActivityMetadata metadata);
+        protected override void Execute(NativeActivityContext context);
+    }
+    public sealed class DoWhile : NativeActivity {
+        public DoWhile();
+        public DoWhile(Activity<bool> condition);
+        public DoWhile(Expression<Func<ActivityContext, bool>> condition);
+        public Activity Body { get; set; }
+        public Activity<bool> Condition { get; set; }
+        public Collection<Variable> Variables { get; }
+        protected override void CacheMetadata(NativeActivityMetadata metadata);
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public class DurableTimerExtension : TimerExtension, ICancelable, IDisposable, IWorkflowInstanceExtension {
+        public DurableTimerExtension();
+        public void Dispose();
+        public virtual IEnumerable<object> GetAdditionalExtensions();
+        protected override void OnCancelTimer(Bookmark bookmark);
+        protected override void OnRegisterTimer(TimeSpan timeout, Bookmark bookmark);
+        public virtual void SetInstance(WorkflowInstanceProxy instance);
+    }
+    public sealed class ExistsInCollection<T> : CodeActivity<bool> {
+        public ExistsInCollection();
+        public InArgument<ICollection<T>> Collection { get; set; }
+        public InArgument<T> Item { get; set; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override bool Execute(CodeActivityContext context);
+    }
+    public sealed class Flowchart : NativeActivity {
+        public Flowchart();
+        public Collection<FlowNode> Nodes { get; }
+        public FlowNode StartNode { get; set; }
+        public bool ValidateUnconnectedNodes { get; set; }
+        public Collection<Variable> Variables { get; }
+        protected override void CacheMetadata(NativeActivityMetadata metadata);
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+        protected override void UpdateInstance(NativeActivityUpdateContext updateContext);
+    }
+    public sealed class FlowDecision : FlowNode {
+        public FlowDecision();
+        public FlowDecision(Activity<bool> condition);
+        public FlowDecision(Expression<Func<ActivityContext, bool>> condition);
+        public Activity<bool> Condition { get; set; }
+        public string DisplayName { get; set; }
+        public FlowNode False { get; set; }
+        public FlowNode True { get; set; }
+    }
+    public abstract class FlowNode
+    public sealed class FlowStep : FlowNode {
+        public FlowStep();
+        public Activity Action { get; set; }
+        public FlowNode Next { get; set; }
+    }
+    public sealed class FlowSwitch<T> : FlowNode, IFlowSwitch {
+        public FlowSwitch();
+        public IDictionary<T, FlowNode> Cases { get; }
+        public FlowNode Default { get; set; }
+        public string DisplayName { get; set; }
+        public Activity<T> Expression { get; set; }
+    }
+    public sealed class ForEach<T> : NativeActivity {
+        public ForEach();
+        public ActivityAction<T> Body { get; set; }
+        public InArgument<IEnumerable<T>> Values { get; set; }
+        protected override void CacheMetadata(NativeActivityMetadata metadata);
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class HandleScope<THandle> : NativeActivity where THandle : Handle {
+        public HandleScope();
+        public Activity Body { get; set; }
+        public InArgument<THandle> Handle { get; set; }
+        protected override void CacheMetadata(NativeActivityMetadata metadata);
+        protected override void Execute(NativeActivityContext context);
+    }
+    public sealed class If : NativeActivity {
+        public If();
+        public If(Activity<bool> condition);
+        public If(InArgument<bool> condition);
+        public If(Expression<Func<ActivityContext, bool>> condition);
+        public InArgument<bool> Condition { get; set; }
+        public Activity Else { get; set; }
+        public Activity Then { get; set; }
+        protected override void CacheMetadata(NativeActivityMetadata metadata);
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class Interop : NativeActivity, ICustomTypeDescriptor {
+        public Interop();
+        public IDictionary<string, object> ActivityMetaProperties { get; }
+        public IDictionary<string, Argument> ActivityProperties { get; }
+        public Type ActivityType { get; set; }
+        protected override bool CanInduceIdle { get; }
+        protected override void CacheMetadata(NativeActivityMetadata metadata);
+        protected override void Cancel(NativeActivityContext context);
+        protected override void Execute(NativeActivityContext context);
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
+    public sealed class InvokeAction : NativeActivity {
+        public InvokeAction();
+        public ActivityAction Action { get; set; }
+        protected override void CacheMetadata(NativeActivityMetadata metadata);
+        protected override void Execute(NativeActivityContext context);
+    }
+    public sealed class InvokeAction<T> : NativeActivity {
+        public InvokeAction();
+        public ActivityAction<T> Action { get; set; }
+        public InArgument<T> Argument { get; set; }
+        protected override void CacheMetadata(NativeActivityMetadata metadata);
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class InvokeAction<T1, T2> : NativeActivity {
+        public InvokeAction();
+        public ActivityAction<T1, T2> Action { get; set; }
+        public InArgument<T1> Argument1 { get; set; }
+        public InArgument<T2> Argument2 { get; set; }
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class InvokeAction<T1, T2, T3> : NativeActivity {
+        public InvokeAction();
+        public ActivityAction<T1, T2, T3> Action { get; set; }
+        public InArgument<T1> Argument1 { get; set; }
+        public InArgument<T2> Argument2 { get; set; }
+        public InArgument<T3> Argument3 { get; set; }
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class InvokeAction<T1, T2, T3, T4> : NativeActivity {
+        public InvokeAction();
+        public ActivityAction<T1, T2, T3, T4> Action { get; set; }
+        public InArgument<T1> Argument1 { get; set; }
+        public InArgument<T2> Argument2 { get; set; }
+        public InArgument<T3> Argument3 { get; set; }
+        public InArgument<T4> Argument4 { get; set; }
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class InvokeAction<T1, T2, T3, T4, T5> : NativeActivity {
+        public InvokeAction();
+        public ActivityAction<T1, T2, T3, T4, T5> Action { get; set; }
+        public InArgument<T1> Argument1 { get; set; }
+        public InArgument<T2> Argument2 { get; set; }
+        public InArgument<T3> Argument3 { get; set; }
+        public InArgument<T4> Argument4 { get; set; }
+        public InArgument<T5> Argument5 { get; set; }
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class InvokeAction<T1, T2, T3, T4, T5, T6> : NativeActivity {
+        public InvokeAction();
+        public ActivityAction<T1, T2, T3, T4, T5, T6> Action { get; set; }
+        public InArgument<T1> Argument1 { get; set; }
+        public InArgument<T2> Argument2 { get; set; }
+        public InArgument<T3> Argument3 { get; set; }
+        public InArgument<T4> Argument4 { get; set; }
+        public InArgument<T5> Argument5 { get; set; }
+        public InArgument<T6> Argument6 { get; set; }
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class InvokeAction<T1, T2, T3, T4, T5, T6, T7> : NativeActivity {
+        public InvokeAction();
+        public ActivityAction<T1, T2, T3, T4, T5, T6, T7> Action { get; set; }
+        public InArgument<T1> Argument1 { get; set; }
+        public InArgument<T2> Argument2 { get; set; }
+        public InArgument<T3> Argument3 { get; set; }
+        public InArgument<T4> Argument4 { get; set; }
+        public InArgument<T5> Argument5 { get; set; }
+        public InArgument<T6> Argument6 { get; set; }
+        public InArgument<T7> Argument7 { get; set; }
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class InvokeAction<T1, T2, T3, T4, T5, T6, T7, T8> : NativeActivity {
+        public InvokeAction();
+        public ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8> Action { get; set; }
+        public InArgument<T1> Argument1 { get; set; }
+        public InArgument<T2> Argument2 { get; set; }
+        public InArgument<T3> Argument3 { get; set; }
+        public InArgument<T4> Argument4 { get; set; }
+        public InArgument<T5> Argument5 { get; set; }
+        public InArgument<T6> Argument6 { get; set; }
+        public InArgument<T7> Argument7 { get; set; }
+        public InArgument<T8> Argument8 { get; set; }
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class InvokeAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> : NativeActivity {
+        public InvokeAction();
+        public ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> Action { get; set; }
+        public InArgument<T1> Argument1 { get; set; }
+        public InArgument<T2> Argument2 { get; set; }
+        public InArgument<T3> Argument3 { get; set; }
+        public InArgument<T4> Argument4 { get; set; }
+        public InArgument<T5> Argument5 { get; set; }
+        public InArgument<T6> Argument6 { get; set; }
+        public InArgument<T7> Argument7 { get; set; }
+        public InArgument<T8> Argument8 { get; set; }
+        public InArgument<T9> Argument9 { get; set; }
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class InvokeAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : NativeActivity {
+        public InvokeAction();
+        public ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Action { get; set; }
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
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class InvokeAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : NativeActivity {
+        public InvokeAction();
+        public ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Action { get; set; }
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
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class InvokeAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : NativeActivity {
+        public InvokeAction();
+        public ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Action { get; set; }
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
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class InvokeAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : NativeActivity {
+        public InvokeAction();
+        public ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Action { get; set; }
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
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class InvokeAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : NativeActivity {
+        public InvokeAction();
+        public ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Action { get; set; }
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
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class InvokeAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : NativeActivity {
+        public InvokeAction();
+        public ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Action { get; set; }
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
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class InvokeAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> : NativeActivity {
+        public InvokeAction();
+        public ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Action { get; set; }
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
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class InvokeDelegate : NativeActivity {
+        public InvokeDelegate();
+        public Activity Default { get; set; }
+        public ActivityDelegate Delegate { get; set; }
+        public IDictionary<string, Argument> DelegateArguments { get; }
+        protected override void CacheMetadata(NativeActivityMetadata metadata);
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class InvokeMethod : AsyncCodeActivity {
+        public InvokeMethod();
+        public Collection<Type> GenericTypeArguments { get; }
+        public string MethodName { get; set; }
+        public Collection<Argument> Parameters { get; }
+        public OutArgument Result { get; set; }
+        public bool RunAsynchronously { get; set; }
+        public InArgument TargetObject { get; set; }
+        public Type TargetType { get; set; }
+        protected override IAsyncResult BeginExecute(AsyncCodeActivityContext context, AsyncCallback callback, object state);
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override void EndExecute(AsyncCodeActivityContext context, IAsyncResult result);
+    }
+    public sealed class NoPersistScope : NativeActivity {
+        public NoPersistScope();
+        public Activity Body { get; set; }
+        protected override void CacheMetadata(NativeActivityMetadata metadata);
+        protected override void Execute(NativeActivityContext context);
+    }
+    public sealed class Parallel : NativeActivity {
+        public Parallel();
+        public Collection<Activity> Branches { get; }
+        public Activity<bool> CompletionCondition { get; set; }
+        public Collection<Variable> Variables { get; }
+        protected override void CacheMetadata(NativeActivityMetadata metadata);
+        protected override void Cancel(NativeActivityContext context);
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+        protected override void UpdateInstance(NativeActivityUpdateContext updateContext);
+    }
+    public sealed class ParallelForEach<T> : NativeActivity {
+        public ParallelForEach();
+        public ActivityAction<T> Body { get; set; }
+        public Activity<bool> CompletionCondition { get; set; }
+        public InArgument<IEnumerable<T>> Values { get; set; }
+        protected override void CacheMetadata(NativeActivityMetadata metadata);
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class Persist : NativeActivity {
+        public Persist();
+        protected override bool CanInduceIdle { get; }
+        protected override void CacheMetadata(NativeActivityMetadata metadata);
+        protected override void Execute(NativeActivityContext context);
+    }
+    public sealed class Pick : NativeActivity {
+        public Pick();
+        public Collection<PickBranch> Branches { get; }
+        protected override bool CanInduceIdle { get; }
+        protected override void CacheMetadata(NativeActivityMetadata metadata);
+        protected override void Cancel(NativeActivityContext context);
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+        protected override void UpdateInstance(NativeActivityUpdateContext updateContext);
+    }
+    public sealed class PickBranch {
+        public PickBranch();
+        public Activity Action { get; set; }
+        public string DisplayName { get; set; }
+        public Activity Trigger { get; set; }
+        public Collection<Variable> Variables { get; }
+    }
+    public sealed class RemoveFromCollection<T> : CodeActivity<bool> {
+        public RemoveFromCollection();
+        public InArgument<ICollection<T>> Collection { get; set; }
+        public InArgument<T> Item { get; set; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override bool Execute(CodeActivityContext context);
+    }
+    public sealed class Rethrow : NativeActivity {
+        public Rethrow();
+        protected override void CacheMetadata(NativeActivityMetadata metadata);
+        protected override void Execute(NativeActivityContext context);
+    }
+    public sealed class Sequence : NativeActivity {
+        public Sequence();
+        public Collection<Activity> Activities { get; }
+        public Collection<Variable> Variables { get; }
+        protected override void CacheMetadata(NativeActivityMetadata metadata);
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class State {
+        public State();
+        public string DisplayName { get; set; }
+        public Activity Entry { get; set; }
+        public Activity Exit { get; set; }
+        public bool IsFinal { get; set; }
+        public Collection<Transition> Transitions { get; }
+        public Collection<Variable> Variables { get; }
+    }
+    public sealed class StateMachine : NativeActivity {
+        public StateMachine();
+        public State InitialState { get; set; }
+        public Collection<State> States { get; }
+        public Collection<Variable> Variables { get; }
+        protected override void CacheMetadata(NativeActivityMetadata metadata);
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class Switch<T> : NativeActivity {
+        public Switch();
+        public Switch(Activity<T> expression);
+        public Switch(InArgument<T> expression);
+        public Switch(Expression<Func<ActivityContext, T>> expression);
+        public IDictionary<T, Activity> Cases { get; }
+        public Activity Default { get; set; }
+        public InArgument<T> Expression { get; set; }
+        protected override void CacheMetadata(NativeActivityMetadata metadata);
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public sealed class TerminateWorkflow : NativeActivity {
+        public TerminateWorkflow();
+        public InArgument<Exception> Exception { get; set; }
+        public InArgument<string> Reason { get; set; }
+        protected override void CacheMetadata(NativeActivityMetadata metadata);
+        protected override void Execute(NativeActivityContext context);
+    }
+    public sealed class Throw : CodeActivity {
+        public Throw();
+        public InArgument<Exception> Exception { get; set; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override void Execute(CodeActivityContext context);
+    }
+    public abstract class TimerExtension {
+        protected TimerExtension();
+        public void CancelTimer(Bookmark bookmark);
+        protected abstract void OnCancelTimer(Bookmark bookmark);
+        protected abstract void OnRegisterTimer(TimeSpan timeout, Bookmark bookmark);
+        public void RegisterTimer(TimeSpan timeout, Bookmark bookmark);
+    }
+    public sealed class TransactionScope : NativeActivity {
+        public TransactionScope();
+        public bool AbortInstanceOnTransactionFailure { get; set; }
+        public Activity Body { get; set; }
+        protected override bool CanInduceIdle { get; }
+        public IsolationLevel IsolationLevel { get; set; }
+        public InArgument<TimeSpan> Timeout { get; set; }
+        protected override void CacheMetadata(NativeActivityMetadata metadata);
+        protected override void Execute(NativeActivityContext context);
+        public bool ShouldSerializeIsolationLevel();
+        public bool ShouldSerializeTimeout();
+    }
+    public sealed class Transition {
+        public Transition();
+        public Activity Action { get; set; }
+        public Activity<bool> Condition { get; set; }
+        public string DisplayName { get; set; }
+        public State To { get; set; }
+        public Activity Trigger { get; set; }
+    }
+    public sealed class TryCatch : NativeActivity {
+        public TryCatch();
+        public Collection<Catch> Catches { get; }
+        public Activity Finally { get; set; }
+        public Activity Try { get; set; }
+        public Collection<Variable> Variables { get; }
+        protected override void CacheMetadata(NativeActivityMetadata metadata);
+        protected override void Cancel(NativeActivityContext context);
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+        protected override void UpdateInstance(NativeActivityUpdateContext updateContext);
+    }
+    public sealed class While : NativeActivity {
+        public While();
+        public While(Activity<bool> condition);
+        public While(Expression<Func<ActivityContext, bool>> condition);
+        public Activity Body { get; set; }
+        public Activity<bool> Condition { get; set; }
+        public Collection<Variable> Variables { get; }
+        protected override void CacheMetadata(NativeActivityMetadata metadata);
+        protected override void Execute(NativeActivityContext context);
+        protected override void OnCreateDynamicUpdateMap(NativeActivityUpdateMapMetadata metadata, Activity originalActivity);
+    }
+    public class WorkflowTerminatedException : Exception {
+        public WorkflowTerminatedException();
+        protected WorkflowTerminatedException(SerializationInfo info, StreamingContext context);
+        public WorkflowTerminatedException(string message);
+        public WorkflowTerminatedException(string message, Exception innerException);
+    }
+    public sealed class WriteLine : CodeActivity {
+        public WriteLine();
+        public InArgument<string> Text { get; set; }
+        public InArgument<TextWriter> TextWriter { get; set; }
+        protected override void CacheMetadata(CodeActivityMetadata metadata);
+        protected override void Execute(CodeActivityContext context);
+    }
+}
```

