# System.Activities.DynamicUpdate

``` diff
+namespace System.Activities.DynamicUpdate {
+    public class ActivityBlockingUpdate {
+        public ActivityBlockingUpdate(Activity activity, string originalActivityId, string reason);
+        public ActivityBlockingUpdate(Activity activity, string originalActivityId, string reason, string activityInstanceId);
+        public ActivityBlockingUpdate(string updatedActivityId, string originalActivityId, string reason);
+        public ActivityBlockingUpdate(string updatedActivityId, string originalActivityId, string reason, string activityInstanceId);
+        public Activity Activity { get; }
+        public string ActivityInstanceId { get; private set; }
+        public string OriginalActivityId { get; private set; }
+        public string Reason { get; private set; }
+        public string UpdatedActivityId { get; private set; }
+    }
+    public static class DynamicUpdateInfo {
+        public static DynamicUpdateMapItem GetMapItem(object instance);
+        public static ActivityBuilder GetOriginalActivityBuilder(object instance);
+        public static Activity GetOriginalDefinition(object instance);
+        public static void SetMapItem(object instance, DynamicUpdateMapItem mapItem);
+        public static void SetOriginalActivityBuilder(object instance, ActivityBuilder originalActivityBuilder);
+        public static void SetOriginalDefinition(object instance, Activity originalDefinition);
+    }
+    public class DynamicUpdateMap {
+        public static DynamicUpdateMap NoChanges { get; }
+        public static IDictionary<object, DynamicUpdateMapItem> CalculateImplementationMapItems(Activity activityDefinitionToBeUpdated);
+        public static IDictionary<object, DynamicUpdateMapItem> CalculateImplementationMapItems(Activity activityDefinitionToBeUpdated, LocationReferenceEnvironment environment);
+        public static IDictionary<object, DynamicUpdateMapItem> CalculateMapItems(Activity workflowDefinitionToBeUpdated);
+        public static IDictionary<object, DynamicUpdateMapItem> CalculateMapItems(Activity workflowDefinitionToBeUpdated, LocationReferenceEnvironment environment);
+        public static DynamicUpdateMap Merge(params DynamicUpdateMap[] maps);
+        public static DynamicUpdateMap Merge(IEnumerable<DynamicUpdateMap> maps);
+        public DynamicUpdateMapQuery Query(Activity updatedWorkflowDefinition, Activity originalWorkflowDefinition);
+    }
+    public class DynamicUpdateMapBuilder {
+        public DynamicUpdateMapBuilder();
+        public ISet<Activity> DisallowUpdateInside { get; }
+        public bool ForImplementation { get; set; }
+        public Func<Activity, DynamicUpdateMap> LookupImplementationMap { get; set; }
+        public Func<object, DynamicUpdateMapItem> LookupMapItem { get; set; }
+        public LocationReferenceEnvironment OriginalEnvironment { get; set; }
+        public Activity OriginalWorkflowDefinition { get; set; }
+        public LocationReferenceEnvironment UpdatedEnvironment { get; set; }
+        public Activity UpdatedWorkflowDefinition { get; set; }
+        public DynamicUpdateMap CreateMap();
+        public DynamicUpdateMap CreateMap(out IList<ActivityBlockingUpdate> activitiesBlockingUpdate);
+    }
+    public class DynamicUpdateMapItem
+    public class DynamicUpdateMapQuery {
+        public bool CanApplyUpdateWhileRunning(Activity activity);
+        public Activity FindMatch(Activity activity);
+        public Variable FindMatch(Variable variable);
+    }
+    public static class DynamicUpdateServices {
+        public static DynamicUpdateMap CreateUpdateMap(Activity updatedWorkflowDefinition);
+        public static DynamicUpdateMap CreateUpdateMap(Activity updatedWorkflowDefinition, IEnumerable<Activity> disallowUpdateInsideActivities);
+        public static DynamicUpdateMap CreateUpdateMap(Activity updatedWorkflowDefinition, IEnumerable<Activity> disallowUpdateInsideActivities, out IList<ActivityBlockingUpdate> activitiesBlockingUpdate);
+        public static DynamicUpdateMap CreateUpdateMap(ActivityBuilder updatedActivityDefinition);
+        public static DynamicUpdateMap CreateUpdateMap(ActivityBuilder updatedActivityDefinition, IEnumerable<Activity> disallowUpdateInsideActivities);
+        public static DynamicUpdateMap CreateUpdateMap(ActivityBuilder updatedActivityDefinition, IEnumerable<Activity> disallowUpdateInsideActivities, out IList<ActivityBlockingUpdate> activitiesBlockingUpdate);
+        public static DynamicUpdateMap GetImplementationMap(Activity targetActivity);
+        public static void PrepareForUpdate(Activity workflowDefinitionToBeUpdated);
+        public static void PrepareForUpdate(ActivityBuilder activityDefinitionToBeUpdated);
+        public static void SetImplementationMap(Activity targetActivity, DynamicUpdateMap implementationMap);
+    }
+    public class InstanceUpdateException : Exception {
+        public InstanceUpdateException();
+        public InstanceUpdateException(IList<ActivityBlockingUpdate> blockingActivities);
+        protected InstanceUpdateException(SerializationInfo info, StreamingContext context);
+        public InstanceUpdateException(string message);
+        public InstanceUpdateException(string message, IList<ActivityBlockingUpdate> blockingActivities);
+        public InstanceUpdateException(string message, IList<ActivityBlockingUpdate> blockingActivities, Exception innerException);
+        public InstanceUpdateException(string message, Exception innerException);
+        public IList<ActivityBlockingUpdate> BlockingActivities { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class NativeActivityUpdateContext {
+        public string ActivityInstanceId { get; }
+        public BookmarkScope DefaultBookmarkScope { get; }
+        public bool IsCancellationRequested { get; }
+        public Bookmark CreateBookmark();
+        public Bookmark CreateBookmark(BookmarkCallback callback);
+        public Bookmark CreateBookmark(BookmarkCallback callback, BookmarkOptions options);
+        public Bookmark CreateBookmark(string name);
+        public Bookmark CreateBookmark(string name, BookmarkCallback callback);
+        public Bookmark CreateBookmark(string name, BookmarkCallback callback, BookmarkOptions options);
+        public Bookmark CreateBookmark(string name, BookmarkCallback callback, BookmarkScope scope);
+        public Bookmark CreateBookmark(string name, BookmarkCallback callback, BookmarkScope scope, BookmarkOptions options);
+        public void DisallowUpdate(string reason);
+        public object FindExecutionProperty(string name);
+        public Location<T> GetLocation<T>(Variable variable);
+        public object GetSavedOriginalValue(Activity childActivity);
+        public object GetSavedOriginalValue(string propertyName);
+        public object GetValue(Argument argument);
+        public object GetValue(RuntimeArgument runtimeArgument);
+        public object GetValue(Variable variable);
+        public T GetValue<T>(Variable<T> variable);
+        public bool IsNewlyAdded(Activity childActivity);
+        public void RemoveAllBookmarks();
+        public bool RemoveBookmark(Bookmark bookmark);
+        public bool RemoveBookmark(string name);
+        public bool RemoveBookmark(string name, BookmarkScope scope);
+        public void ScheduleAction(ActivityAction activityAction, CompletionCallback onCompleted=null, FaultCallback onFaulted=null);
+        public void ScheduleAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, T12 argument12, T13 argument13, T14 argument14, T15 argument15, T16 argument16, CompletionCallback onCompleted=null, FaultCallback onFaulted=null);
+        public void ScheduleAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, T12 argument12, T13 argument13, T14 argument14, T15 argument15, CompletionCallback onCompleted=null, FaultCallback onFaulted=null);
+        public void ScheduleAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, T12 argument12, T13 argument13, T14 argument14, CompletionCallback onCompleted=null, FaultCallback onFaulted=null);
+        public void ScheduleAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, T12 argument12, T13 argument13, CompletionCallback onCompleted=null, FaultCallback onFaulted=null);
+        public void ScheduleAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, T12 argument12, CompletionCallback onCompleted=null, FaultCallback onFaulted=null);
+        public void ScheduleAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, CompletionCallback onCompleted=null, FaultCallback onFaulted=null);
+        public void ScheduleAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, CompletionCallback onCompleted=null, FaultCallback onFaulted=null);
+        public void ScheduleAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>(ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, CompletionCallback onCompleted=null, FaultCallback onFaulted=null);
+        public void ScheduleAction<T1, T2, T3, T4, T5, T6, T7, T8>(ActivityAction<T1, T2, T3, T4, T5, T6, T7, T8> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, CompletionCallback onCompleted=null, FaultCallback onFaulted=null);
+        public void ScheduleAction<T1, T2, T3, T4, T5, T6, T7>(ActivityAction<T1, T2, T3, T4, T5, T6, T7> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, CompletionCallback onCompleted=null, FaultCallback onFaulted=null);
+        public void ScheduleAction<T1, T2, T3, T4, T5, T6>(ActivityAction<T1, T2, T3, T4, T5, T6> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, CompletionCallback onCompleted=null, FaultCallback onFaulted=null);
+        public void ScheduleAction<T1, T2, T3, T4, T5>(ActivityAction<T1, T2, T3, T4, T5> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, CompletionCallback onCompleted=null, FaultCallback onFaulted=null);
+        public void ScheduleAction<T1, T2, T3, T4>(ActivityAction<T1, T2, T3, T4> activityAction, T1 argument1, T2 argument2, T3 argument3, T4 argument4, CompletionCallback onCompleted=null, FaultCallback onFaulted=null);
+        public void ScheduleAction<T1, T2, T3>(ActivityAction<T1, T2, T3> activityAction, T1 argument1, T2 argument2, T3 argument3, CompletionCallback onCompleted=null, FaultCallback onFaulted=null);
+        public void ScheduleAction<T1, T2>(ActivityAction<T1, T2> activityAction, T1 argument1, T2 argument2, CompletionCallback onCompleted=null, FaultCallback onFaulted=null);
+        public void ScheduleAction<T>(ActivityAction<T> activityAction, T argument, CompletionCallback onCompleted=null, FaultCallback onFaulted=null);
+        public void ScheduleActivity(Activity activity);
+        public void ScheduleActivity(Activity activity, CompletionCallback onCompleted);
+        public void ScheduleActivity(Activity activity, CompletionCallback onCompleted, FaultCallback onFaulted);
+        public void ScheduleActivity(Activity activity, FaultCallback onFaulted);
+        public void ScheduleActivity<TResult>(Activity<TResult> activity, CompletionCallback<TResult> onCompleted=null, FaultCallback onFaulted=null);
+        public void ScheduleDelegate(ActivityDelegate activityDelegate, IDictionary<string, object> inputParameters, DelegateCompletionCallback onCompleted=null, FaultCallback onFaulted=null);
+        public void ScheduleFunc<T, TResult>(ActivityFunc<T, TResult> activityFunc, T argument, CompletionCallback<TResult> onCompleted=null, FaultCallback onFaulted=null);
+        public void ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, T12 argument12, T13 argument13, T14 argument14, T15 argument15, T16 argument16, CompletionCallback<TResult> onCompleted=null, FaultCallback onFaulted=null);
+        public void ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, T12 argument12, T13 argument13, T14 argument14, T15 argument15, CompletionCallback<TResult> onCompleted=null, FaultCallback onFaulted=null);
+        public void ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, T12 argument12, T13 argument13, T14 argument14, CompletionCallback<TResult> onCompleted=null, FaultCallback onFaulted=null);
+        public void ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, T12 argument12, T13 argument13, CompletionCallback<TResult> onCompleted=null, FaultCallback onFaulted=null);
+        public void ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, T12 argument12, CompletionCallback<TResult> onCompleted=null, FaultCallback onFaulted=null);
+        public void ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, T11 argument11, CompletionCallback<TResult> onCompleted=null, FaultCallback onFaulted=null);
+        public void ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, T10 argument10, CompletionCallback<TResult> onCompleted=null, FaultCallback onFaulted=null);
+        public void ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, T9 argument9, CompletionCallback<TResult> onCompleted=null, FaultCallback onFaulted=null);
+        public void ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(ActivityFunc<T1, T2, T3, T4, T5, T6, T7, T8, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, T8 argument8, CompletionCallback<TResult> onCompleted=null, FaultCallback onFaulted=null);
+        public void ScheduleFunc<T1, T2, T3, T4, T5, T6, T7, TResult>(ActivityFunc<T1, T2, T3, T4, T5, T6, T7, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, T7 argument7, CompletionCallback<TResult> onCompleted=null, FaultCallback onFaulted=null);
+        public void ScheduleFunc<T1, T2, T3, T4, T5, T6, TResult>(ActivityFunc<T1, T2, T3, T4, T5, T6, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, T6 argument6, CompletionCallback<TResult> onCompleted=null, FaultCallback onFaulted=null);
+        public void ScheduleFunc<T1, T2, T3, T4, T5, TResult>(ActivityFunc<T1, T2, T3, T4, T5, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, T5 argument5, CompletionCallback<TResult> onCompleted=null, FaultCallback onFaulted=null);
+        public void ScheduleFunc<T1, T2, T3, T4, TResult>(ActivityFunc<T1, T2, T3, T4, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, T4 argument4, CompletionCallback<TResult> onCompleted=null, FaultCallback onFaulted=null);
+        public void ScheduleFunc<T1, T2, T3, TResult>(ActivityFunc<T1, T2, T3, TResult> activityFunc, T1 argument1, T2 argument2, T3 argument3, CompletionCallback<TResult> onCompleted=null, FaultCallback onFaulted=null);
+        public void ScheduleFunc<T1, T2, TResult>(ActivityFunc<T1, T2, TResult> activityFunc, T1 argument1, T2 argument2, CompletionCallback<TResult> onCompleted=null, FaultCallback onFaulted=null);
+        public void ScheduleFunc<TResult>(ActivityFunc<TResult> activityFunc, CompletionCallback<TResult> onCompleted=null, FaultCallback onFaulted=null);
+        public void SetValue(Argument argument, object value);
+        public void SetValue(Variable variable, object value);
+        public void SetValue<T>(Variable<T> variable, T value);
+    }
+    public class NativeActivityUpdateMapMetadata : UpdateMapMetadata {
+        public void SaveOriginalValue(Activity updatedChildActivity, object originalValue);
+        public void SaveOriginalValue(string propertyName, object originalValue);
+    }
+    public class UpdateMapMetadata {
+        public void AddMatch(Activity updatedChild, Activity originalChild);
+        public void AddMatch(Variable updatedVariable, Variable originalVariable);
+        public void AllowUpdateInsideThisActivity();
+        public void DisallowUpdateInsideThisActivity(string reason);
+        public Activity GetMatch(Activity updatedChild);
+        public Variable GetMatch(Variable updatedVariable);
+        public bool IsReferenceToImportedChild(Activity childActivity);
+    }
+}
```

