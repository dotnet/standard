# System.Workflow.Runtime.Tracking

``` diff
+namespace System.Workflow.Runtime.Tracking {
+    public class ActivityDataTrackingExtract : TrackingExtract {
+        public ActivityDataTrackingExtract();
+        public ActivityDataTrackingExtract(string member);
+        public override TrackingAnnotationCollection Annotations { get; }
+        public override string Member { get; set; }
+    }
+    public class ActivityTrackingCondition : TrackingCondition {
+        public ActivityTrackingCondition();
+        public ActivityTrackingCondition(string member, string value);
+        public override string Member { get; set; }
+        public override ComparisonOperator Operator { get; set; }
+        public override string Value { get; set; }
+    }
+    public sealed class ActivityTrackingLocation {
+        public ActivityTrackingLocation();
+        public ActivityTrackingLocation(string activityTypeName);
+        public ActivityTrackingLocation(string activityTypeName, bool matchDerivedTypes, IEnumerable<ActivityExecutionStatus> executionStatusEvents);
+        public ActivityTrackingLocation(string activityTypeName, IEnumerable<ActivityExecutionStatus> executionStatusEvents);
+        public ActivityTrackingLocation(Type activityType);
+        public ActivityTrackingLocation(Type activityType, bool matchDerivedTypes, IEnumerable<ActivityExecutionStatus> executionStatusEvents);
+        public ActivityTrackingLocation(Type activityType, IEnumerable<ActivityExecutionStatus> executionStatusEvents);
+        public Type ActivityType { get; set; }
+        public string ActivityTypeName { get; set; }
+        public TrackingConditionCollection Conditions { get; }
+        public IList<ActivityExecutionStatus> ExecutionStatusEvents { get; }
+        public bool MatchDerivedTypes { get; set; }
+    }
+    public class ActivityTrackingLocationCollection : List<ActivityTrackingLocation> {
+        public ActivityTrackingLocationCollection();
+        public ActivityTrackingLocationCollection(IEnumerable<ActivityTrackingLocation> locations);
+    }
+    public class ActivityTrackingRecord : TrackingRecord {
+        public ActivityTrackingRecord();
+        public ActivityTrackingRecord(Type activityType, string qualifiedName, Guid contextGuid, Guid parentContextGuid, ActivityExecutionStatus executionStatus, DateTime eventDateTime, int eventOrder, EventArgs eventArgs);
+        public Type ActivityType { get; set; }
+        public override TrackingAnnotationCollection Annotations { get; }
+        public IList<TrackingDataItem> Body { get; }
+        public Guid ContextGuid { get; set; }
+        public override EventArgs EventArgs { get; set; }
+        public override DateTime EventDateTime { get; set; }
+        public override int EventOrder { get; set; }
+        public ActivityExecutionStatus ExecutionStatus { get; set; }
+        public Guid ParentContextGuid { get; set; }
+        public string QualifiedName { get; set; }
+    }
+    public sealed class ActivityTrackPoint {
+        public ActivityTrackPoint();
+        public TrackingAnnotationCollection Annotations { get; }
+        public ActivityTrackingLocationCollection ExcludedLocations { get; }
+        public ExtractCollection Extracts { get; }
+        public ActivityTrackingLocationCollection MatchingLocations { get; }
+    }
+    public class ActivityTrackPointCollection : List<ActivityTrackPoint> {
+        public ActivityTrackPointCollection();
+        public ActivityTrackPointCollection(IEnumerable<ActivityTrackPoint> points);
+    }
+    public enum ComparisonOperator {
+        Equals = 0,
+        NotEquals = 1,
+    }
+    public class ExtractCollection : List<TrackingExtract> {
+        public ExtractCollection();
+        public ExtractCollection(IEnumerable<TrackingExtract> extracts);
+    }
+    public interface IProfileNotification {
+        event EventHandler<ProfileRemovedEventArgs> ProfileRemoved;
+        event EventHandler<ProfileUpdatedEventArgs> ProfileUpdated;
+    }
+    public sealed class PreviousTrackingServiceAttribute : Attribute {
+        public PreviousTrackingServiceAttribute(string assemblyQualifiedName);
+        public string AssemblyQualifiedName { get; }
+    }
+    public sealed class ProfileRemovedEventArgs : EventArgs {
+        public ProfileRemovedEventArgs();
+        public ProfileRemovedEventArgs(Type workflowType);
+        public Type WorkflowType { get; set; }
+    }
+    public sealed class ProfileUpdatedEventArgs : EventArgs {
+        public ProfileUpdatedEventArgs();
+        public ProfileUpdatedEventArgs(Type workflowType, TrackingProfile profile);
+        public TrackingProfile TrackingProfile { get; set; }
+        public Type WorkflowType { get; set; }
+    }
+    public sealed class SqlTrackingQuery {
+        public SqlTrackingQuery();
+        public SqlTrackingQuery(string connectionString);
+        public string ConnectionString { get; set; }
+        public IList<SqlTrackingWorkflowInstance> GetWorkflows(SqlTrackingQueryOptions options);
+        public bool TryGetWorkflow(Guid workflowInstanceId, out SqlTrackingWorkflowInstance workflowInstance);
+    }
+    public class SqlTrackingQueryOptions {
+        public SqlTrackingQueryOptions();
+        public DateTime StatusMaxDateTime { get; set; }
+        public DateTime StatusMinDateTime { get; set; }
+        public IList<TrackingDataItemValue> TrackingDataItems { get; }
+        public Nullable<WorkflowStatus> WorkflowStatus { get; set; }
+        public Type WorkflowType { get; set; }
+        public void Clear();
+    }
+    public sealed class SqlTrackingService : TrackingService, IProfileNotification {
+        public SqlTrackingService(NameValueCollection parameters);
+        public SqlTrackingService(string connectionString);
+        public string ConnectionString { get; }
+        public bool EnableRetries { get; set; }
+        public bool IsTransactional { get; set; }
+        public bool PartitionOnCompletion { get; set; }
+        public double ProfileChangeCheckInterval { get; set; }
+        public bool UseDefaultProfile { get; set; }
+        public event EventHandler<ProfileRemovedEventArgs> ProfileRemoved;
+        public event EventHandler<ProfileUpdatedEventArgs> ProfileUpdated;
+        protected internal override TrackingProfile GetProfile(Guid scheduleInstanceId);
+        protected internal override TrackingProfile GetProfile(Type workflowType, Version profileVersion);
+        protected internal override TrackingChannel GetTrackingChannel(TrackingParameters parameters);
+        protected internal override void Start();
+        protected internal override bool TryGetProfile(Type workflowType, out TrackingProfile profile);
+        protected internal override bool TryReloadProfile(Type workflowType, Guid scheduleInstanceId, out TrackingProfile profile);
+    }
+    public class SqlTrackingWorkflowInstance {
+        public IList<ActivityTrackingRecord> ActivityEvents { get; }
+        public bool AutoRefresh { get; set; }
+        public DateTime Initialized { get; set; }
+        public IList<SqlTrackingWorkflowInstance> InvokedWorkflows { get; }
+        public Guid InvokingWorkflowInstanceId { get; set; }
+        public WorkflowStatus Status { get; set; }
+        public IList<UserTrackingRecord> UserEvents { get; }
+        public Activity WorkflowDefinition { get; }
+        public bool WorkflowDefinitionUpdated { get; }
+        public IList<WorkflowTrackingRecord> WorkflowEvents { get; }
+        public Guid WorkflowInstanceId { get; set; }
+        public long WorkflowInstanceInternalId { get; set; }
+        public Type WorkflowType { get; set; }
+        public void Refresh();
+    }
+    public class TrackingAnnotationCollection : List<string> {
+        public TrackingAnnotationCollection();
+        public TrackingAnnotationCollection(IEnumerable<string> annotations);
+    }
+    public abstract class TrackingChannel {
+        protected TrackingChannel();
+        protected internal abstract void InstanceCompletedOrTerminated();
+        protected internal abstract void Send(TrackingRecord record);
+    }
+    public abstract class TrackingCondition {
+        protected TrackingCondition();
+        public abstract string Member { get; set; }
+        public abstract ComparisonOperator Operator { get; set; }
+        public abstract string Value { get; set; }
+    }
+    public class TrackingConditionCollection : List<TrackingCondition> {
+        public TrackingConditionCollection();
+        public TrackingConditionCollection(IEnumerable<TrackingCondition> conditions);
+    }
+    public class TrackingDataItem {
+        public TrackingDataItem();
+        public TrackingAnnotationCollection Annotations { get; }
+        public object Data { get; set; }
+        public string FieldName { get; set; }
+    }
+    public class TrackingDataItemValue {
+        public TrackingDataItemValue();
+        public TrackingDataItemValue(string qualifiedName, string fieldName, string dataValue);
+        public string DataValue { get; set; }
+        public string FieldName { get; set; }
+        public string QualifiedName { get; set; }
+    }
+    public abstract class TrackingExtract {
+        protected TrackingExtract();
+        public abstract TrackingAnnotationCollection Annotations { get; }
+        public abstract string Member { get; set; }
+    }
+    public sealed class TrackingParameters {
+        public TrackingParameters(Guid instanceId, Type workflowType, Activity rootActivity, IList<string> callPath, Guid callerInstanceId, Guid contextGuid, Guid callerContextGuid, Guid callerParentContextGuid);
+        public Guid CallerContextGuid { get; }
+        public Guid CallerInstanceId { get; }
+        public Guid CallerParentContextGuid { get; }
+        public IList<string> CallPath { get; }
+        public Guid ContextGuid { get; }
+        public Guid InstanceId { get; }
+        public Activity RootActivity { get; }
+        public Type WorkflowType { get; }
+    }
+    public class TrackingProfile {
+        public TrackingProfile();
+        public ActivityTrackPointCollection ActivityTrackPoints { get; }
+        public UserTrackPointCollection UserTrackPoints { get; }
+        public Version Version { get; set; }
+        public WorkflowTrackPointCollection WorkflowTrackPoints { get; }
+    }
+    public static class TrackingProfileCache {
+        public static void Clear();
+    }
+    public sealed class TrackingProfileDeserializationException : SystemException {
+        public TrackingProfileDeserializationException();
+        public TrackingProfileDeserializationException(string message);
+        public TrackingProfileDeserializationException(string message, Exception innerException);
+        public IList<ValidationEventArgs> ValidationEventArgs { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class TrackingProfileSerializer {
+        public TrackingProfileSerializer();
+        public XmlSchema Schema { get; }
+        public TrackingProfile Deserialize(TextReader reader);
+        public void Serialize(TextWriter writer, TrackingProfile profile);
+    }
+    public abstract class TrackingRecord {
+        protected TrackingRecord();
+        public abstract TrackingAnnotationCollection Annotations { get; }
+        public abstract EventArgs EventArgs { get; set; }
+        public abstract DateTime EventDateTime { get; set; }
+        public abstract int EventOrder { get; set; }
+    }
+    public abstract class TrackingService : WorkflowRuntimeService {
+        protected TrackingService();
+        protected internal abstract TrackingProfile GetProfile(Guid workflowInstanceId);
+        protected internal abstract TrackingProfile GetProfile(Type workflowType, Version profileVersionId);
+        protected internal abstract TrackingChannel GetTrackingChannel(TrackingParameters parameters);
+        protected internal abstract bool TryGetProfile(Type workflowType, out TrackingProfile profile);
+        protected internal abstract bool TryReloadProfile(Type workflowType, Guid workflowInstanceId, out TrackingProfile profile);
+    }
+    public class TrackingWorkflowChangedEventArgs : EventArgs {
+        public IList<WorkflowChangeAction> Changes { get; }
+        public Activity Definition { get; }
+    }
+    public enum TrackingWorkflowEvent {
+        Aborted = 10,
+        Changed = 11,
+        Completed = 1,
+        Created = 0,
+        Exception = 8,
+        Idle = 2,
+        Loaded = 7,
+        Persisted = 5,
+        Resumed = 4,
+        Started = 12,
+        Suspended = 3,
+        Terminated = 9,
+        Unloaded = 6,
+    }
+    public class TrackingWorkflowExceptionEventArgs : EventArgs {
+        public Guid ContextGuid { get; }
+        public string CurrentActivityPath { get; }
+        public Exception Exception { get; }
+        public string OriginalActivityPath { get; }
+        public Guid ParentContextGuid { get; }
+    }
+    public class TrackingWorkflowSuspendedEventArgs : EventArgs {
+        public string Error { get; }
+    }
+    public class TrackingWorkflowTerminatedEventArgs : EventArgs {
+        public Exception Exception { get; }
+    }
+    public sealed class UserTrackingLocation {
+        public UserTrackingLocation();
+        public UserTrackingLocation(string argumentTypeName);
+        public UserTrackingLocation(string argumentTypeName, string activityTypeName);
+        public UserTrackingLocation(string argumentTypeName, Type activityType);
+        public UserTrackingLocation(Type argumentType);
+        public UserTrackingLocation(Type argumentType, string activityTypeName);
+        public UserTrackingLocation(Type argumentType, Type activityType);
+        public Type ActivityType { get; set; }
+        public string ActivityTypeName { get; set; }
+        public Type ArgumentType { get; set; }
+        public string ArgumentTypeName { get; set; }
+        public TrackingConditionCollection Conditions { get; }
+        public string KeyName { get; set; }
+        public bool MatchDerivedActivityTypes { get; set; }
+        public bool MatchDerivedArgumentTypes { get; set; }
+    }
+    public class UserTrackingLocationCollection : List<UserTrackingLocation> {
+        public UserTrackingLocationCollection();
+        public UserTrackingLocationCollection(IEnumerable<UserTrackingLocation> locations);
+    }
+    public class UserTrackingRecord : TrackingRecord {
+        public UserTrackingRecord();
+        public UserTrackingRecord(Type activityType, string qualifiedName, Guid contextGuid, Guid parentContextGuid, DateTime eventDateTime, int eventOrder, string userDataKey, object userData);
+        public Type ActivityType { get; set; }
+        public override TrackingAnnotationCollection Annotations { get; }
+        public IList<TrackingDataItem> Body { get; }
+        public Guid ContextGuid { get; set; }
+        public override EventArgs EventArgs { get; set; }
+        public override DateTime EventDateTime { get; set; }
+        public override int EventOrder { get; set; }
+        public Guid ParentContextGuid { get; set; }
+        public string QualifiedName { get; set; }
+        public object UserData { get; set; }
+        public string UserDataKey { get; set; }
+    }
+    public sealed class UserTrackPoint {
+        public UserTrackPoint();
+        public TrackingAnnotationCollection Annotations { get; }
+        public UserTrackingLocationCollection ExcludedLocations { get; }
+        public ExtractCollection Extracts { get; }
+        public UserTrackingLocationCollection MatchingLocations { get; }
+    }
+    public class UserTrackPointCollection : List<UserTrackPoint> {
+        public UserTrackPointCollection();
+        public UserTrackPointCollection(IEnumerable<UserTrackPoint> points);
+    }
+    public class WorkflowDataTrackingExtract : TrackingExtract {
+        public WorkflowDataTrackingExtract();
+        public WorkflowDataTrackingExtract(string member);
+        public override TrackingAnnotationCollection Annotations { get; }
+        public override string Member { get; set; }
+    }
+    public sealed class WorkflowTrackingLocation {
+        public WorkflowTrackingLocation();
+        public WorkflowTrackingLocation(IList<TrackingWorkflowEvent> events);
+        public IList<TrackingWorkflowEvent> Events { get; }
+    }
+    public class WorkflowTrackingRecord : TrackingRecord {
+        public WorkflowTrackingRecord();
+        public WorkflowTrackingRecord(TrackingWorkflowEvent trackingWorkflowEvent, DateTime eventDateTime, int eventOrder, EventArgs eventArgs);
+        public override TrackingAnnotationCollection Annotations { get; }
+        public override EventArgs EventArgs { get; set; }
+        public override DateTime EventDateTime { get; set; }
+        public override int EventOrder { get; set; }
+        public TrackingWorkflowEvent TrackingWorkflowEvent { get; set; }
+    }
+    public sealed class WorkflowTrackPoint {
+        public WorkflowTrackPoint();
+        public TrackingAnnotationCollection Annotations { get; }
+        public WorkflowTrackingLocation MatchingLocation { get; set; }
+    }
+    public class WorkflowTrackPointCollection : List<WorkflowTrackPoint> {
+        public WorkflowTrackPointCollection();
+        public WorkflowTrackPointCollection(IEnumerable<WorkflowTrackPoint> points);
+    }
+}
```

