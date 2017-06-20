# System.Activities.Tracking

``` diff
+namespace System.Activities.Tracking {
+    public sealed class ActivityInfo {
+        public ActivityInfo(string name, string id, string instanceId, string typeName);
+        public string Id { get; internal set; }
+        public string InstanceId { get; internal set; }
+        public string Name { get; internal set; }
+        public string TypeName { get; internal set; }
+        public override string ToString();
+    }
+    public sealed class ActivityScheduledQuery : TrackingQuery {
+        public ActivityScheduledQuery();
+        public string ActivityName { get; set; }
+        public string ChildActivityName { get; set; }
+    }
+    public sealed class ActivityScheduledRecord : TrackingRecord {
+        public ActivityScheduledRecord(Guid instanceId, long recordNumber, ActivityInfo activity, ActivityInfo child);
+        public ActivityInfo Activity { get; private set; }
+        public ActivityInfo Child { get; private set; }
+        protected internal override TrackingRecord Clone();
+        public override string ToString();
+    }
+    public class ActivityStateQuery : TrackingQuery {
+        public ActivityStateQuery();
+        public string ActivityName { get; set; }
+        public Collection<string> Arguments { get; }
+        public Collection<string> States { get; }
+        public Collection<string> Variables { get; }
+    }
+    public sealed class ActivityStateRecord : TrackingRecord {
+        public ActivityStateRecord(Guid instanceId, long recordNumber, ActivityInfo activity, string state);
+        public ActivityInfo Activity { get; private set; }
+        public IDictionary<string, object> Arguments { get; internal set; }
+        public string State { get; private set; }
+        public IDictionary<string, object> Variables { get; internal set; }
+        protected internal override TrackingRecord Clone();
+        public override string ToString();
+    }
+    public static class ActivityStates {
+        public const string Canceled = "Canceled";
+        public const string Closed = "Closed";
+        public const string Executing = "Executing";
+        public const string Faulted = "Faulted";
+    }
+    public sealed class BookmarkResumptionQuery : TrackingQuery {
+        public BookmarkResumptionQuery();
+        public string Name { get; set; }
+    }
+    public sealed class BookmarkResumptionRecord : TrackingRecord {
+        public BookmarkResumptionRecord(Guid instanceId, long recordNumber, Guid bookmarkScope, string bookmarkName, ActivityInfo owner);
+        public string BookmarkName { get; private set; }
+        public Guid BookmarkScope { get; private set; }
+        public ActivityInfo Owner { get; private set; }
+        public object Payload { get; internal set; }
+        protected internal override TrackingRecord Clone();
+        public override string ToString();
+    }
+    public sealed class CancelRequestedQuery : TrackingQuery {
+        public CancelRequestedQuery();
+        public string ActivityName { get; set; }
+        public string ChildActivityName { get; set; }
+    }
+    public sealed class CancelRequestedRecord : TrackingRecord {
+        public CancelRequestedRecord(Guid instanceId, long recordNumber, ActivityInfo activity, ActivityInfo child);
+        public ActivityInfo Activity { get; private set; }
+        public ActivityInfo Child { get; private set; }
+        protected internal override TrackingRecord Clone();
+        public override string ToString();
+    }
+    public class CustomTrackingQuery : TrackingQuery {
+        public CustomTrackingQuery();
+        public string ActivityName { get; set; }
+        public string Name { get; set; }
+    }
+    public class CustomTrackingRecord : TrackingRecord {
+        protected CustomTrackingRecord(CustomTrackingRecord record);
+        public CustomTrackingRecord(Guid instanceId, string name, TraceLevel level);
+        public CustomTrackingRecord(string name);
+        public CustomTrackingRecord(string name, TraceLevel level);
+        public ActivityInfo Activity { get; internal set; }
+        public IDictionary<string, object> Data { get; }
+        public string Name { get; private set; }
+        protected internal override TrackingRecord Clone();
+        public override string ToString();
+    }
+    public sealed class EtwTrackingParticipant : TrackingParticipant {
+        public EtwTrackingParticipant();
+        public string ApplicationReference { get; set; }
+        public Guid EtwProviderId { get; set; }
+        protected internal override IAsyncResult BeginTrack(TrackingRecord record, TimeSpan timeout, AsyncCallback callback, object state);
+        protected internal override void EndTrack(IAsyncResult result);
+        protected internal override void Track(TrackingRecord record, TimeSpan timeout);
+    }
+    public sealed class FaultPropagationQuery : TrackingQuery {
+        public FaultPropagationQuery();
+        public string FaultHandlerActivityName { get; set; }
+        public string FaultSourceActivityName { get; set; }
+    }
+    public sealed class FaultPropagationRecord : TrackingRecord {
+        public FaultPropagationRecord(Guid instanceId, long recordNumber, ActivityInfo faultSource, ActivityInfo faultHandler, bool isFaultSource, Exception fault);
+        public Exception Fault { get; private set; }
+        public ActivityInfo FaultHandler { get; private set; }
+        public ActivityInfo FaultSource { get; private set; }
+        public bool IsFaultSource { get; private set; }
+        protected internal override TrackingRecord Clone();
+        public override string ToString();
+    }
+    public enum ImplementationVisibility {
+        All = 1,
+        RootScope = 0,
+    }
+    public class InteropTrackingRecord : CustomTrackingRecord {
+        protected InteropTrackingRecord(InteropTrackingRecord record);
+        public InteropTrackingRecord(string activityDisplayName, TrackingRecord v1TrackingRecord);
+        public TrackingRecord TrackingRecord { get; private set; }
+        protected override TrackingRecord Clone();
+    }
+    public abstract class TrackingParticipant {
+        protected TrackingParticipant();
+        public virtual TrackingProfile TrackingProfile { get; set; }
+        protected internal virtual IAsyncResult BeginTrack(TrackingRecord record, TimeSpan timeout, AsyncCallback callback, object state);
+        protected internal virtual void EndTrack(IAsyncResult result);
+        protected internal abstract void Track(TrackingRecord record, TimeSpan timeout);
+    }
+    public class TrackingProfile {
+        public TrackingProfile();
+        public string ActivityDefinitionId { get; set; }
+        public ImplementationVisibility ImplementationVisibility { get; set; }
+        public string Name { get; set; }
+        public Collection<TrackingQuery> Queries { get; }
+    }
+    public abstract class TrackingQuery {
+        protected TrackingQuery();
+        public IDictionary<string, string> QueryAnnotations { get; }
+    }
+    public abstract class TrackingRecord {
+        protected TrackingRecord(TrackingRecord record);
+        protected TrackingRecord(Guid instanceId);
+        protected TrackingRecord(Guid instanceId, long recordNumber);
+        public IDictionary<string, string> Annotations { get; internal set; }
+        public DateTime EventTime { get; private set; }
+        public Guid InstanceId { get; internal set; }
+        public TraceLevel Level { get; protected set; }
+        public long RecordNumber { get; internal set; }
+        protected internal abstract TrackingRecord Clone();
+        public override string ToString();
+    }
+    public sealed class WorkflowInstanceAbortedRecord : WorkflowInstanceRecord {
+        public WorkflowInstanceAbortedRecord(Guid instanceId, long recordNumber, string activityDefinitionId, string reason);
+        public WorkflowInstanceAbortedRecord(Guid instanceId, long recordNumber, string activityDefinitionId, string reason, WorkflowIdentity workflowDefinitionIdentity);
+        public WorkflowInstanceAbortedRecord(Guid instanceId, string activityDefinitionId, string reason);
+        public WorkflowInstanceAbortedRecord(Guid instanceId, string activityDefinitionId, string reason, WorkflowIdentity workflowDefinitionIdentity);
+        public string Reason { get; private set; }
+        protected internal override TrackingRecord Clone();
+        public override string ToString();
+    }
+    public class WorkflowInstanceQuery : TrackingQuery {
+        public WorkflowInstanceQuery();
+        public Collection<string> States { get; }
+    }
+    public class WorkflowInstanceRecord : TrackingRecord {
+        protected WorkflowInstanceRecord(WorkflowInstanceRecord record);
+        public WorkflowInstanceRecord(Guid instanceId, long recordNumber, string activityDefinitionId, string state);
+        public WorkflowInstanceRecord(Guid instanceId, long recordNumber, string activityDefinitionId, string state, WorkflowIdentity workflowDefinitionIdentity);
+        public WorkflowInstanceRecord(Guid instanceId, string activityDefinitionId, string state);
+        public WorkflowInstanceRecord(Guid instanceId, string activityDefinitionId, string state, WorkflowIdentity workflowDefinitionIdentity);
+        public string ActivityDefinitionId { get; private set; }
+        public string State { get; private set; }
+        public WorkflowIdentity WorkflowDefinitionIdentity { get; protected set; }
+        protected internal override TrackingRecord Clone();
+        public override string ToString();
+    }
+    public static class WorkflowInstanceStates {
+        public const string Aborted = "Aborted";
+        public const string Canceled = "Canceled";
+        public const string Completed = "Completed";
+        public const string Deleted = "Deleted";
+        public const string Idle = "Idle";
+        public const string Persisted = "Persisted";
+        public const string Resumed = "Resumed";
+        public const string Started = "Started";
+        public const string Suspended = "Suspended";
+        public const string Terminated = "Terminated";
+        public const string UnhandledException = "UnhandledException";
+        public const string Unloaded = "Unloaded";
+        public const string Unsuspended = "Unsuspended";
+        public const string Updated = "Updated";
+        public const string UpdateFailed = "UpdateFailed";
+    }
+    public sealed class WorkflowInstanceSuspendedRecord : WorkflowInstanceRecord {
+        public WorkflowInstanceSuspendedRecord(Guid instanceId, long recordNumber, string activityDefinitionId, string reason);
+        public WorkflowInstanceSuspendedRecord(Guid instanceId, long recordNumber, string activityDefinitionId, string reason, WorkflowIdentity workflowDefinitionIdentity);
+        public WorkflowInstanceSuspendedRecord(Guid instanceId, string activityDefinitionId, string reason);
+        public WorkflowInstanceSuspendedRecord(Guid instanceId, string activityDefinitionId, string reason, WorkflowIdentity workflowDefinitionIdentity);
+        public string Reason { get; private set; }
+        protected internal override TrackingRecord Clone();
+        public override string ToString();
+    }
+    public sealed class WorkflowInstanceTerminatedRecord : WorkflowInstanceRecord {
+        public WorkflowInstanceTerminatedRecord(Guid instanceId, long recordNumber, string activityDefinitionId, string reason);
+        public WorkflowInstanceTerminatedRecord(Guid instanceId, long recordNumber, string activityDefinitionId, string reason, WorkflowIdentity workflowDefinitionIdentity);
+        public WorkflowInstanceTerminatedRecord(Guid instanceId, string activityDefinitionId, string reason);
+        public WorkflowInstanceTerminatedRecord(Guid instanceId, string activityDefinitionId, string reason, WorkflowIdentity workflowDefinitionIdentity);
+        public string Reason { get; private set; }
+        protected internal override TrackingRecord Clone();
+        public override string ToString();
+    }
+    public sealed class WorkflowInstanceUnhandledExceptionRecord : WorkflowInstanceRecord {
+        public WorkflowInstanceUnhandledExceptionRecord(Guid instanceId, long recordNumber, string activityDefinitionId, ActivityInfo faultSource, Exception exception);
+        public WorkflowInstanceUnhandledExceptionRecord(Guid instanceId, long recordNumber, string activityDefinitionId, ActivityInfo faultSource, Exception exception, WorkflowIdentity workflowDefinitionIdentity);
+        public WorkflowInstanceUnhandledExceptionRecord(Guid instanceId, string activityDefinitionId, ActivityInfo faultSource, Exception exception);
+        public WorkflowInstanceUnhandledExceptionRecord(Guid instanceId, string activityDefinitionId, ActivityInfo faultSource, Exception exception, WorkflowIdentity workflowDefinitionIdentity);
+        public ActivityInfo FaultSource { get; private set; }
+        public Exception UnhandledException { get; private set; }
+        protected internal override TrackingRecord Clone();
+        public override string ToString();
+    }
+    public sealed class WorkflowInstanceUpdatedRecord : WorkflowInstanceRecord {
+        public WorkflowInstanceUpdatedRecord(Guid instanceId, long recordNumber, string activityDefinitionId, WorkflowIdentity originalDefinitionIdentity, WorkflowIdentity updatedDefinitionIdentity);
+        public WorkflowInstanceUpdatedRecord(Guid instanceId, long recordNumber, string activityDefinitionId, WorkflowIdentity originalDefinitionIdentity, WorkflowIdentity updatedDefinitionIdentity, IList<ActivityBlockingUpdate> blockingActivities);
+        public WorkflowInstanceUpdatedRecord(Guid instanceId, string activityDefinitionId, WorkflowIdentity originalDefinitionIdentity, WorkflowIdentity updatedDefinitionIdentity);
+        public WorkflowInstanceUpdatedRecord(Guid instanceId, string activityDefinitionId, WorkflowIdentity originalDefinitionIdentity, WorkflowIdentity updatedDefinitionIdentity, IList<ActivityBlockingUpdate> blockingActivities);
+        public IList<ActivityBlockingUpdate> BlockingActivities { get; private set; }
+        public bool IsSuccessful { get; }
+        public WorkflowIdentity OriginalDefinitionIdentity { get; private set; }
+        protected internal override TrackingRecord Clone();
+        public override string ToString();
+    }
+}
```

