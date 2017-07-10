# System.Workflow.ComponentModel

``` diff
+namespace System.Workflow.ComponentModel {
+    public class Activity : DependencyObject {
+        public static readonly DependencyProperty ActivityContextGuidProperty;
+        public static readonly DependencyProperty CancelingEvent;
+        public static readonly DependencyProperty ClosedEvent;
+        public static readonly DependencyProperty CompensatingEvent;
+        public static readonly DependencyProperty ExecutingEvent;
+        public static readonly DependencyProperty FaultingEvent;
+        public static readonly DependencyProperty StatusChangedEvent;
+        public Activity();
+        public Activity(string name);
+        public string Description { get; set; }
+        public bool Enabled { get; set; }
+        public ActivityExecutionResult ExecutionResult { get; }
+        public ActivityExecutionStatus ExecutionStatus { get; }
+        public bool IsDynamicActivity { get; }
+        public string Name { get; set; }
+        public CompositeActivity Parent { get; }
+        public string QualifiedName { get; }
+        protected Guid WorkflowInstanceId { get; }
+        public event EventHandler<ActivityExecutionStatusChangedEventArgs> Canceling;
+        public event EventHandler<ActivityExecutionStatusChangedEventArgs> Closed;
+        public event EventHandler<ActivityExecutionStatusChangedEventArgs> Compensating;
+        public event EventHandler<ActivityExecutionStatusChangedEventArgs> Executing;
+        public event EventHandler<ActivityExecutionStatusChangedEventArgs> Faulting;
+        public event EventHandler<ActivityExecutionStatusChangedEventArgs> StatusChanged;
+        protected internal virtual ActivityExecutionStatus Cancel(ActivityExecutionContext executionContext);
+        public Activity Clone();
+        protected internal virtual ActivityExecutionStatus Execute(ActivityExecutionContext executionContext);
+        public Activity GetActivityByName(string activityQualifiedName);
+        public Activity GetActivityByName(string activityQualifiedName, bool withinThisActivityOnly);
+        protected internal virtual ActivityExecutionStatus HandleFault(ActivityExecutionContext executionContext, Exception exception);
+        protected internal virtual void Initialize(IServiceProvider provider);
+        protected internal void Invoke<T>(EventHandler<T> handler, T e) where T : EventArgs;
+        protected internal void Invoke<T>(IActivityEventListener<T> eventListener, T e) where T : EventArgs;
+        public static Activity Load(Stream stream, Activity outerActivity);
+        public static Activity Load(Stream stream, Activity outerActivity, IFormatter formatter);
+        protected internal virtual void OnActivityExecutionContextLoad(IServiceProvider provider);
+        protected internal virtual void OnActivityExecutionContextUnload(IServiceProvider provider);
+        protected virtual void OnClosed(IServiceProvider provider);
+        protected internal void RaiseEvent(DependencyProperty dependencyEvent, object sender, EventArgs e);
+        protected internal void RaiseGenericEvent<T>(DependencyProperty dependencyEvent, object sender, T e) where T : EventArgs;
+        public void RegisterForStatusChange(DependencyProperty dependencyProp, IActivityEventListener<ActivityExecutionStatusChangedEventArgs> activityStatusChangeListener);
+        public void Save(Stream stream);
+        public void Save(Stream stream, IFormatter formatter);
+        public override string ToString();
+        protected void TrackData(object userData);
+        protected void TrackData(string userDataKey, object userData);
+        protected internal virtual void Uninitialize(IServiceProvider provider);
+        public void UnregisterForStatusChange(DependencyProperty dependencyProp, IActivityEventListener<ActivityExecutionStatusChangedEventArgs> activityStatusChangeListener);
+    }
+    public sealed class ActivityBind : MarkupExtension, IPropertyValueProvider {
+        public ActivityBind();
+        public ActivityBind(string name);
+        public ActivityBind(string name, string path);
+        public string Name { get; set; }
+        public string Path { get; set; }
+        public IDictionary UserData { get; }
+        public object GetRuntimeValue(Activity activity);
+        public object GetRuntimeValue(Activity activity, Type targetType);
+        public override object ProvideValue(IServiceProvider provider);
+        public void SetRuntimeValue(Activity activity, object value);
+        public override string ToString();
+    }
+    public abstract class ActivityChangeAction : WorkflowChangeAction {
+        protected ActivityChangeAction();
+        protected ActivityChangeAction(CompositeActivity compositeActivity);
+        public string OwnerActivityDottedPath { get; internal set; }
+        protected internal override ValidationErrorCollection ValidateChanges(Activity contextActivity);
+    }
+    public sealed class ActivityCollection : List<Activity>, ICollection, ICollection<Activity>, IEnumerable, IEnumerable<Activity>, IList, IList<Activity> {
+        public ActivityCollection(Activity owner);
+        public new int Count { get; }
+        int System.Collections.Generic.ICollection<System.Workflow.ComponentModel.Activity>.Count { get; }
+        bool System.Collections.Generic.ICollection<System.Workflow.ComponentModel.Activity>.IsReadOnly { get; }
+        Activity System.Collections.Generic.IList<System.Workflow.ComponentModel.Activity>.this[int index] { get; set; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public new Activity this[int index] { get; set; }
+        public Activity this[string key] { get; }
+        public event EventHandler<ActivityCollectionChangeEventArgs> ListChanged;
+        public new void Add(Activity item);
+        public new void Clear();
+        public new bool Contains(Activity item);
+        public new IEnumerator<Activity> GetEnumerator();
+        public new int IndexOf(Activity item);
+        public new void Insert(int index, Activity item);
+        public new bool Remove(Activity item);
+        public new void RemoveAt(int index);
+        void System.Collections.Generic.ICollection<System.Workflow.ComponentModel.Activity>.Add(Activity item);
+        void System.Collections.Generic.ICollection<System.Workflow.ComponentModel.Activity>.Clear();
+        bool System.Collections.Generic.ICollection<System.Workflow.ComponentModel.Activity>.Contains(Activity item);
+        void System.Collections.Generic.ICollection<System.Workflow.ComponentModel.Activity>.CopyTo(Activity[] array, int arrayIndex);
+        bool System.Collections.Generic.ICollection<System.Workflow.ComponentModel.Activity>.Remove(Activity item);
+        IEnumerator<Activity> System.Collections.Generic.IEnumerable<System.Workflow.ComponentModel.Activity>.GetEnumerator();
+        int System.Collections.Generic.IList<System.Workflow.ComponentModel.Activity>.IndexOf(Activity item);
+        void System.Collections.Generic.IList<System.Workflow.ComponentModel.Activity>.Insert(int index, Activity item);
+        void System.Collections.Generic.IList<System.Workflow.ComponentModel.Activity>.RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        void System.Collections.IList.Clear();
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+    }
+    public enum ActivityCollectionChangeAction {
+        Add = 0,
+        Remove = 1,
+        Replace = 2,
+    }
+    public sealed class ActivityCollectionChangeEventArgs : EventArgs {
+        public ActivityCollectionChangeEventArgs(int index, ICollection<Activity> removedItems, ICollection<Activity> addedItems, object owner, ActivityCollectionChangeAction action);
+        public ActivityCollectionChangeEventArgs(int index, Activity removedActivity, Activity addedActivity, object owner, ActivityCollectionChangeAction action);
+        public ActivityCollectionChangeAction Action { get; }
+        public IList<Activity> AddedItems { get; }
+        public int Index { get; }
+        public object Owner { get; }
+        public IList<Activity> RemovedItems { get; }
+    }
+    public abstract class ActivityCondition : DependencyObject {
+        protected ActivityCondition();
+        public abstract bool Evaluate(Activity activity, IServiceProvider provider);
+    }
+    public sealed class ActivityExecutionContext : IDisposable, IServiceProvider {
+        public static readonly DependencyProperty CurrentExceptionProperty;
+        public Activity Activity { get; }
+        public Guid ContextGuid { get; }
+        public ActivityExecutionContextManager ExecutionContextManager { get; }
+        public void CancelActivity(Activity activity);
+        public void CloseActivity();
+        public void ExecuteActivity(Activity activity);
+        public object GetService(Type serviceType);
+        public T GetService<T>();
+        void System.IDisposable.Dispose();
+        public void TrackData(object userData);
+        public void TrackData(string userDataKey, object userData);
+    }
+    public sealed class ActivityExecutionContextManager {
+        public ReadOnlyCollection<ActivityExecutionContext> ExecutionContexts { get; }
+        public IEnumerable<Guid> PersistedExecutionContexts { get; }
+        public void CompleteExecutionContext(ActivityExecutionContext childContext);
+        public void CompleteExecutionContext(ActivityExecutionContext childContext, bool forcePersist);
+        public ActivityExecutionContext CreateExecutionContext(Activity activity);
+        public ActivityExecutionContext GetExecutionContext(Activity activity);
+        public ActivityExecutionContext GetPersistedExecutionContext(Guid contextGuid);
+    }
+    public enum ActivityExecutionResult : byte {
+        Canceled = (byte)2,
+        Compensated = (byte)3,
+        Faulted = (byte)4,
+        None = (byte)0,
+        Succeeded = (byte)1,
+        Uninitialized = (byte)5,
+    }
+    public enum ActivityExecutionStatus : byte {
+        Canceling = (byte)2,
+        Closed = (byte)3,
+        Compensating = (byte)4,
+        Executing = (byte)1,
+        Faulting = (byte)5,
+        Initialized = (byte)0,
+    }
+    public sealed class ActivityExecutionStatusChangedEventArgs : EventArgs {
+        public Activity Activity { get; }
+        public ActivityExecutionResult ExecutionResult { get; }
+        public ActivityExecutionStatus ExecutionStatus { get; }
+        public override string ToString();
+    }
+    public sealed class AddedActivityAction : ActivityChangeAction {
+        public AddedActivityAction();
+        public AddedActivityAction(CompositeActivity compositeActivity, Activity activityAdded);
+        public Activity AddedActivity { get; internal set; }
+        public int Index { get; internal set; }
+        protected internal override bool ApplyTo(Activity rootActivity);
+    }
+    public sealed class AlternateFlowActivityAttribute : Attribute {
+        public AlternateFlowActivityAttribute();
+    }
+    public sealed class CancellationHandlerActivity : CompositeActivity, IActivityEventListener<ActivityExecutionStatusChangedEventArgs> {
+        public CancellationHandlerActivity();
+        public CancellationHandlerActivity(string name);
+        protected internal override ActivityExecutionStatus Cancel(ActivityExecutionContext executionContext);
+        protected internal override ActivityExecutionStatus Execute(ActivityExecutionContext executionContext);
+        protected internal override void Initialize(IServiceProvider provider);
+        protected internal override void OnActivityChangeRemove(ActivityExecutionContext executionContext, Activity removedActivity);
+        protected internal override void OnWorkflowChangesCompleted(ActivityExecutionContext executionContext);
+        void System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs>.OnEvent(object sender, ActivityExecutionStatusChangedEventArgs e);
+    }
+    public sealed class CompensatableTransactionScopeActivity : CompositeActivity, IActivityEventListener<ActivityExecutionStatusChangedEventArgs>, ICompensatableActivity {
+        public CompensatableTransactionScopeActivity();
+        public CompensatableTransactionScopeActivity(string name);
+        public WorkflowTransactionOptions TransactionOptions { get; set; }
+        protected internal override ActivityExecutionStatus Cancel(ActivityExecutionContext executionContext);
+        protected internal override ActivityExecutionStatus Execute(ActivityExecutionContext executionContext);
+        protected internal override void OnActivityChangeRemove(ActivityExecutionContext executionContext, Activity removedActivity);
+        protected internal override void OnWorkflowChangesCompleted(ActivityExecutionContext executionContext);
+        void System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs>.OnEvent(object sender, ActivityExecutionStatusChangedEventArgs e);
+        ActivityExecutionStatus System.Workflow.ComponentModel.ICompensatableActivity.Compensate(ActivityExecutionContext executionContext);
+    }
+    public sealed class CompensateActivity : Activity, IActivityEventListener<ActivityExecutionStatusChangedEventArgs>, IPropertyValueProvider {
+        public static readonly DependencyProperty TargetActivityNameProperty;
+        public CompensateActivity();
+        public CompensateActivity(string name);
+        public string TargetActivityName { get; set; }
+        protected internal override ActivityExecutionStatus Execute(ActivityExecutionContext executionContext);
+        protected internal override void Initialize(IServiceProvider provider);
+        void System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs>.OnEvent(object sender, ActivityExecutionStatusChangedEventArgs e);
+    }
+    public sealed class CompensationHandlerActivity : CompositeActivity, IActivityEventListener<ActivityExecutionStatusChangedEventArgs> {
+        public CompensationHandlerActivity();
+        public CompensationHandlerActivity(string name);
+        protected internal override ActivityExecutionStatus Cancel(ActivityExecutionContext executionContext);
+        protected internal override ActivityExecutionStatus Execute(ActivityExecutionContext executionContext);
+        protected internal override void Initialize(IServiceProvider provider);
+        protected internal override void OnActivityChangeRemove(ActivityExecutionContext executionContext, Activity removedActivity);
+        protected internal override void OnWorkflowChangesCompleted(ActivityExecutionContext executionContext);
+        void System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs>.OnEvent(object sender, ActivityExecutionStatusChangedEventArgs e);
+    }
+    public class CompositeActivity : Activity, ISupportAlternateFlow {
+        public CompositeActivity();
+        public CompositeActivity(IEnumerable<Activity> children);
+        public CompositeActivity(string name);
+        public ActivityCollection Activities { get; }
+        protected internal bool CanModifyActivities { get; set; }
+        public ReadOnlyCollection<Activity> EnabledActivities { get; }
+        protected void ApplyWorkflowChanges(WorkflowChanges workflowChanges);
+        protected override void Dispose(bool disposing);
+        protected Activity[] GetDynamicActivities(Activity activity);
+        protected internal override ActivityExecutionStatus HandleFault(ActivityExecutionContext executionContext, Exception exception);
+        protected internal override void Initialize(IServiceProvider provider);
+        protected internal virtual void OnActivityChangeAdd(ActivityExecutionContext executionContext, Activity addedActivity);
+        protected internal virtual void OnActivityChangeRemove(ActivityExecutionContext executionContext, Activity removedActivity);
+        protected internal override void OnActivityExecutionContextLoad(IServiceProvider provider);
+        protected internal override void OnActivityExecutionContextUnload(IServiceProvider provider);
+        protected virtual void OnListChanged(ActivityCollectionChangeEventArgs e);
+        protected virtual void OnListChanging(ActivityCollectionChangeEventArgs e);
+        protected internal virtual void OnWorkflowChangesCompleted(ActivityExecutionContext rootContext);
+        protected internal override void Uninitialize(IServiceProvider provider);
+    }
+    public abstract class DependencyObject : IComponent, IDependencyObjectAccessor, IDisposable {
+        protected DependencyObject();
+        protected internal bool DesignMode { get; }
+        protected DependencyObject ParentDependencyObject { get; }
+        public ISite Site { get; set; }
+        public IDictionary UserData { get; }
+        event EventHandler System.ComponentModel.IComponent.Disposed;
+        public void AddHandler(DependencyProperty dependencyEvent, object value);
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        ~DependencyObject();
+        public ActivityBind GetBinding(DependencyProperty dependencyProperty);
+        protected virtual object GetBoundValue(ActivityBind bind, Type targetType);
+        protected T[] GetInvocationList<T>(DependencyProperty dependencyEvent);
+        public object GetValue(DependencyProperty dependencyProperty);
+        public object GetValueBase(DependencyProperty dependencyProperty);
+        protected virtual void InitializeProperties();
+        public bool IsBindingSet(DependencyProperty dependencyProperty);
+        public bool MetaEquals(DependencyObject dependencyObject);
+        public void RemoveHandler(DependencyProperty dependencyEvent, object value);
+        public bool RemoveProperty(DependencyProperty dependencyProperty);
+        public void SetBinding(DependencyProperty dependencyProperty, ActivityBind bind);
+        protected virtual void SetBoundValue(ActivityBind bind, object value);
+        protected internal void SetReadOnlyPropertyValue(DependencyProperty dependencyProperty, object value);
+        public void SetValue(DependencyProperty dependencyProperty, object value);
+        public void SetValueBase(DependencyProperty dependencyProperty, object value);
+    }
+    public sealed class DependencyProperty : ISerializable {
+        public PropertyMetadata DefaultMetadata { get; }
+        public bool IsAttached { get; }
+        public bool IsEvent { get; }
+        public string Name { get; }
+        public Type OwnerType { get; }
+        public Type PropertyType { get; }
+        public Type ValidatorType { get; }
+        public static DependencyProperty FromName(string propertyName, Type ownerType);
+        public static IList<DependencyProperty> FromType(Type ownerType);
+        public override int GetHashCode();
+        public static DependencyProperty Register(string name, Type propertyType, Type ownerType);
+        public static DependencyProperty Register(string name, Type propertyType, Type ownerType, PropertyMetadata defaultMetadata);
+        public static DependencyProperty RegisterAttached(string name, Type propertyType, Type ownerType);
+        public static DependencyProperty RegisterAttached(string name, Type propertyType, Type ownerType, PropertyMetadata defaultMetadata);
+        public static DependencyProperty RegisterAttached(string name, Type propertyType, Type ownerType, PropertyMetadata defaultMetadata, Type validatorType);
+        void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context);
+        public override string ToString();
+    }
+    public enum DependencyPropertyOptions : byte {
+        Default = (byte)1,
+        DelegateProperty = (byte)32,
+        Metadata = (byte)8,
+        NonSerialized = (byte)16,
+        Optional = (byte)4,
+        ReadOnly = (byte)2,
+    }
+    public sealed class FaultHandlerActivity : CompositeActivity, IActivityEventListener<ActivityExecutionStatusChangedEventArgs>, IDynamicPropertyTypeProvider, ITypeFilterProvider {
+        public static readonly DependencyProperty FaultTypeProperty;
+        public FaultHandlerActivity();
+        public FaultHandlerActivity(string name);
+        public Exception Fault { get; }
+        public Type FaultType { get; set; }
+        string System.Workflow.ComponentModel.Design.ITypeFilterProvider.FilterDescription { get; }
+        protected internal override ActivityExecutionStatus Cancel(ActivityExecutionContext executionContext);
+        protected internal override ActivityExecutionStatus Execute(ActivityExecutionContext executionContext);
+        protected internal override void Initialize(IServiceProvider provider);
+        protected internal override void OnActivityChangeRemove(ActivityExecutionContext executionContext, Activity removedActivity);
+        protected internal override void OnWorkflowChangesCompleted(ActivityExecutionContext executionContext);
+        bool System.Workflow.ComponentModel.Design.ITypeFilterProvider.CanFilterType(Type type, bool throwOnError);
+        void System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs>.OnEvent(object sender, ActivityExecutionStatusChangedEventArgs e);
+        AccessTypes System.Workflow.ComponentModel.IDynamicPropertyTypeProvider.GetAccessType(IServiceProvider serviceProvider, string propertyName);
+        Type System.Workflow.ComponentModel.IDynamicPropertyTypeProvider.GetPropertyType(IServiceProvider serviceProvider, string propertyName);
+    }
+    public sealed class FaultHandlersActivity : CompositeActivity, IActivityEventListener<ActivityExecutionStatusChangedEventArgs> {
+        public FaultHandlersActivity();
+        public FaultHandlersActivity(string name);
+        protected internal override ActivityExecutionStatus Cancel(ActivityExecutionContext executionContext);
+        protected internal override ActivityExecutionStatus Execute(ActivityExecutionContext executionContext);
+        protected internal override void Initialize(IServiceProvider provider);
+        protected internal override void OnActivityChangeRemove(ActivityExecutionContext executionContext, Activity removedActivity);
+        protected override void OnClosed(IServiceProvider provider);
+        protected internal override void OnWorkflowChangesCompleted(ActivityExecutionContext executionContext);
+        void System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs>.OnEvent(object sender, ActivityExecutionStatusChangedEventArgs e);
+    }
+    public delegate object GetValueOverride(DependencyObject d);
+    public interface IActivityEventListener<T> where T : EventArgs {
+        void OnEvent(object sender, T e);
+    }
+    public interface ICompensatableActivity {
+        ActivityExecutionStatus Compensate(ActivityExecutionContext executionContext);
+    }
+    public interface IDynamicPropertyTypeProvider {
+        AccessTypes GetAccessType(IServiceProvider serviceProvider, string propertyName);
+        Type GetPropertyType(IServiceProvider serviceProvider, string propertyName);
+    }
+    public interface IStartWorkflow {
+        Guid StartWorkflow(Type workflowType, Dictionary<string, object> namedArgumentValues);
+    }
+    public interface IWorkflowChangeDiff {
+        IList<WorkflowChangeAction> Diff(object originalDefinition, object changedDefinition);
+    }
+    public sealed class PersistOnCloseAttribute : Attribute {
+        public PersistOnCloseAttribute();
+    }
+    public class PropertyMetadata {
+        public PropertyMetadata();
+        public PropertyMetadata(params Attribute[] attributes);
+        public PropertyMetadata(object defaultValue);
+        public PropertyMetadata(object defaultValue, params Attribute[] attributes);
+        public PropertyMetadata(object defaultValue, DependencyPropertyOptions options);
+        public PropertyMetadata(object defaultValue, DependencyPropertyOptions options, params Attribute[] attributes);
+        public PropertyMetadata(object defaultValue, DependencyPropertyOptions options, GetValueOverride getValueOverride, SetValueOverride setValueOverride);
+        public PropertyMetadata(object defaultValue, DependencyPropertyOptions options, GetValueOverride getValueOverride, SetValueOverride setValueOverride, params Attribute[] attributes);
+        public PropertyMetadata(DependencyPropertyOptions options);
+        public PropertyMetadata(DependencyPropertyOptions options, params Attribute[] attributes);
+        public object DefaultValue { get; set; }
+        public GetValueOverride GetValueOverride { get; set; }
+        public bool IsMetaProperty { get; }
+        public bool IsNonSerialized { get; }
+        public bool IsReadOnly { get; }
+        protected bool IsSealed { get; }
+        public DependencyPropertyOptions Options { get; set; }
+        public SetValueOverride SetValueOverride { get; set; }
+        public Attribute[] GetAttributes();
+        public Attribute[] GetAttributes(Type attributeType);
+        protected virtual void OnApply(DependencyProperty dependencyProperty, Type targetType);
+    }
+    public class QueueEventArgs : EventArgs {
+        public IComparable QueueName { get; }
+    }
+    public sealed class RemovedActivityAction : ActivityChangeAction {
+        public RemovedActivityAction();
+        public RemovedActivityAction(int removedActivityIndex, Activity originalActivity, CompositeActivity clonedParentActivity);
+        public Activity OriginalRemovedActivity { get; internal set; }
+        public int RemovedActivityIndex { get; internal set; }
+        protected internal override bool ApplyTo(Activity rootActivity);
+        protected internal override ValidationErrorCollection ValidateChanges(Activity contextActivity);
+    }
+    public delegate void SetValueOverride(DependencyObject d, object value);
+    public sealed class SuspendActivity : Activity {
+        public static readonly DependencyProperty ErrorProperty;
+        public SuspendActivity();
+        public SuspendActivity(string name);
+        public string Error { get; set; }
+        protected internal sealed override ActivityExecutionStatus Execute(ActivityExecutionContext executionContext);
+        protected internal override void Initialize(IServiceProvider provider);
+    }
+    public sealed class SynchronizationScopeActivity : CompositeActivity, IActivityEventListener<ActivityExecutionStatusChangedEventArgs> {
+        public SynchronizationScopeActivity();
+        public SynchronizationScopeActivity(string name);
+        public ICollection<string> SynchronizationHandles { get; set; }
+        protected internal override ActivityExecutionStatus Cancel(ActivityExecutionContext executionContext);
+        protected internal override ActivityExecutionStatus Execute(ActivityExecutionContext executionContext);
+        protected internal override void OnActivityChangeRemove(ActivityExecutionContext executionContext, Activity removedActivity);
+        protected internal override void OnWorkflowChangesCompleted(ActivityExecutionContext executionContext);
+        void System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs>.OnEvent(object sender, ActivityExecutionStatusChangedEventArgs e);
+    }
+    public sealed class TerminateActivity : Activity {
+        public static readonly DependencyProperty ErrorProperty;
+        public TerminateActivity();
+        public TerminateActivity(string name);
+        public string Error { get; set; }
+        protected internal sealed override ActivityExecutionStatus Execute(ActivityExecutionContext executionContext);
+        protected internal override void Initialize(IServiceProvider provider);
+    }
+    public sealed class ThrowActivity : Activity, IDynamicPropertyTypeProvider, ITypeFilterProvider {
+        public static readonly DependencyProperty FaultProperty;
+        public static readonly DependencyProperty FaultTypeProperty;
+        public ThrowActivity();
+        public ThrowActivity(string name);
+        public Exception Fault { get; set; }
+        public Type FaultType { get; set; }
+        string System.Workflow.ComponentModel.Design.ITypeFilterProvider.FilterDescription { get; }
+        protected internal sealed override ActivityExecutionStatus Execute(ActivityExecutionContext executionContext);
+        protected internal override void Initialize(IServiceProvider provider);
+        bool System.Workflow.ComponentModel.Design.ITypeFilterProvider.CanFilterType(Type type, bool throwOnError);
+        AccessTypes System.Workflow.ComponentModel.IDynamicPropertyTypeProvider.GetAccessType(IServiceProvider serviceProvider, string propertyName);
+        Type System.Workflow.ComponentModel.IDynamicPropertyTypeProvider.GetPropertyType(IServiceProvider serviceProvider, string propertyName);
+    }
+    public sealed class TransactionScopeActivity : CompositeActivity, IActivityEventListener<ActivityExecutionStatusChangedEventArgs> {
+        public TransactionScopeActivity();
+        public TransactionScopeActivity(string name);
+        public WorkflowTransactionOptions TransactionOptions { get; set; }
+        protected internal override ActivityExecutionStatus Cancel(ActivityExecutionContext executionContext);
+        protected internal override ActivityExecutionStatus Execute(ActivityExecutionContext executionContext);
+        protected internal override void OnActivityChangeRemove(ActivityExecutionContext executionContext, Activity removedActivity);
+        protected internal override void OnWorkflowChangesCompleted(ActivityExecutionContext executionContext);
+        void System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs>.OnEvent(object sender, ActivityExecutionStatusChangedEventArgs e);
+    }
+    public abstract class WorkflowChangeAction {
+        protected WorkflowChangeAction();
+        protected internal abstract bool ApplyTo(Activity rootActivity);
+        protected internal abstract ValidationErrorCollection ValidateChanges(Activity activity);
+    }
+    public sealed class WorkflowChanges {
+        public static readonly DependencyProperty ConditionProperty;
+        public WorkflowChanges(Activity rootActivity);
+        public CompositeActivity TransientWorkflow { get; }
+        public static object GetCondition(object dependencyObject);
+        public static void SetCondition(object dependencyObject, object value);
+        public ValidationErrorCollection Validate();
+    }
+    public sealed class WorkflowParameterBinding : DependencyObject {
+        public static readonly DependencyProperty ParameterNameProperty;
+        public static readonly DependencyProperty ValueProperty;
+        public WorkflowParameterBinding();
+        public WorkflowParameterBinding(string parameterName);
+        public string ParameterName { get; set; }
+        public object Value { get; set; }
+    }
+    public sealed class WorkflowParameterBindingCollection : KeyedCollection<string, WorkflowParameterBinding> {
+        public WorkflowParameterBindingCollection(Activity ownerActivity);
+        protected override void ClearItems();
+        public WorkflowParameterBinding GetItem(string key);
+        protected override string GetKeyForItem(WorkflowParameterBinding item);
+        protected override void InsertItem(int index, WorkflowParameterBinding item);
+        protected override void RemoveItem(int index);
+        protected override void SetItem(int index, WorkflowParameterBinding item);
+    }
+    public sealed class WorkflowTerminatedException : Exception {
+        public WorkflowTerminatedException();
+        public WorkflowTerminatedException(string message);
+        public WorkflowTerminatedException(string message, Exception exception);
+    }
+    public sealed class WorkflowTransactionOptions : DependencyObject {
+        public static readonly DependencyProperty IsolationLevelProperty;
+        public static readonly DependencyProperty TimeoutDurationProperty;
+        public WorkflowTransactionOptions();
+        public IsolationLevel IsolationLevel { get; set; }
+        public TimeSpan TimeoutDuration { get; set; }
+    }
+}
```

