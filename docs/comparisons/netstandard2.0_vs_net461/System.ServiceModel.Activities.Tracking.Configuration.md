# System.ServiceModel.Activities.Tracking.Configuration

``` diff
+namespace System.ServiceModel.Activities.Tracking.Configuration {
+    public class ActivityScheduledQueryElement : TrackingQueryElement {
+        public ActivityScheduledQueryElement();
+        public string ActivityName { get; set; }
+        public string ChildActivityName { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected override TrackingQuery NewTrackingQuery();
+    }
+    public class ActivityScheduledQueryElementCollection : TrackingConfigurationCollection<ActivityScheduledQueryElement> {
+        public ActivityScheduledQueryElementCollection();
+        protected override string ElementName { get; }
+    }
+    public class ActivityStateQueryElement : TrackingQueryElement {
+        public ActivityStateQueryElement();
+        public string ActivityName { get; set; }
+        public ArgumentElementCollection Arguments { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public StateElementCollection States { get; }
+        public VariableElementCollection Variables { get; }
+        protected override TrackingQuery NewTrackingQuery();
+    }
+    public class ActivityStateQueryElementCollection : TrackingConfigurationCollection<ActivityStateQueryElement> {
+        public ActivityStateQueryElementCollection();
+        protected override string ElementName { get; }
+    }
+    public class AnnotationElement : TrackingConfigurationElement {
+        public AnnotationElement();
+        public override object ElementKey { get; }
+        public string Name { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public string Value { get; set; }
+    }
+    public class AnnotationElementCollection : TrackingConfigurationCollection<AnnotationElement> {
+        public AnnotationElementCollection();
+        protected override string ElementName { get; }
+    }
+    public class ArgumentElement : TrackingConfigurationElement {
+        public ArgumentElement();
+        public override object ElementKey { get; }
+        public string Name { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public class ArgumentElementCollection : TrackingConfigurationCollection<ArgumentElement> {
+        public ArgumentElementCollection();
+        protected override string ElementName { get; }
+    }
+    public class BookmarkResumptionQueryElement : TrackingQueryElement {
+        public BookmarkResumptionQueryElement();
+        public string Name { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected override TrackingQuery NewTrackingQuery();
+    }
+    public class BookmarkResumptionQueryElementCollection : TrackingConfigurationCollection<BookmarkResumptionQueryElement> {
+        public BookmarkResumptionQueryElementCollection();
+        protected override string ElementName { get; }
+    }
+    public class CancelRequestedQueryElement : TrackingQueryElement {
+        public CancelRequestedQueryElement();
+        public string ActivityName { get; set; }
+        public string ChildActivityName { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected override TrackingQuery NewTrackingQuery();
+    }
+    public class CancelRequestedQueryElementCollection : TrackingConfigurationCollection<CancelRequestedQueryElement> {
+        public CancelRequestedQueryElementCollection();
+        protected override string ElementName { get; }
+    }
+    public class CustomTrackingQueryElement : TrackingQueryElement {
+        public CustomTrackingQueryElement();
+        public string ActivityName { get; set; }
+        public string Name { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected override TrackingQuery NewTrackingQuery();
+    }
+    public class CustomTrackingQueryElementCollection : TrackingConfigurationCollection<CustomTrackingQueryElement> {
+        public CustomTrackingQueryElementCollection();
+        protected override string ElementName { get; }
+    }
+    public class FaultPropagationQueryElement : TrackingQueryElement {
+        public FaultPropagationQueryElement();
+        public string FaultHandlerActivityName { get; set; }
+        public string FaultSourceActivityName { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected override TrackingQuery NewTrackingQuery();
+    }
+    public class FaultPropagationQueryElementCollection : TrackingConfigurationCollection<FaultPropagationQueryElement> {
+        public FaultPropagationQueryElementCollection();
+        protected override string ElementName { get; }
+    }
+    public class ProfileElement : TrackingConfigurationElement {
+        public ProfileElement();
+        public override object ElementKey { get; }
+        public ImplementationVisibility ImplementationVisibility { get; set; }
+        public string Name { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public ProfileWorkflowElementCollection Workflows { get; }
+    }
+    public sealed class ProfileElementCollection : TrackingConfigurationCollection<ProfileElement> {
+        public override ConfigurationElementCollectionType CollectionType { get; }
+    }
+    public class ProfileWorkflowElement : TrackingConfigurationElement {
+        public ProfileWorkflowElement();
+        public string ActivityDefinitionId { get; set; }
+        public ActivityScheduledQueryElementCollection ActivityScheduledQueries { get; }
+        public ActivityStateQueryElementCollection ActivityStateQueries { get; }
+        public BookmarkResumptionQueryElementCollection BookmarkResumptionQueries { get; }
+        public CancelRequestedQueryElementCollection CancelRequestedQueries { get; }
+        public CustomTrackingQueryElementCollection CustomTrackingQueries { get; }
+        public override object ElementKey { get; }
+        public FaultPropagationQueryElementCollection FaultPropagationQueries { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public StateMachineStateQueryElementCollection StateMachineStateQueries { get; }
+        public WorkflowInstanceQueryElementCollection WorkflowInstanceQueries { get; }
+    }
+    public class ProfileWorkflowElementCollection : TrackingConfigurationCollection<ProfileWorkflowElement> {
+        public ProfileWorkflowElementCollection();
+        protected override string ElementName { get; }
+    }
+    public class StateElement : TrackingConfigurationElement {
+        public StateElement();
+        public override object ElementKey { get; }
+        public string Name { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public sealed class StateElementCollection : TrackingConfigurationCollection<StateElement> {
+        public StateElementCollection();
+        protected override string ElementName { get; }
+    }
+    public class StateMachineStateQueryElement : TrackingQueryElement {
+        public StateMachineStateQueryElement();
+        public string ActivityName { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected override TrackingQuery NewTrackingQuery();
+    }
+    public class StateMachineStateQueryElementCollection : TrackingConfigurationCollection<StateMachineStateQueryElement> {
+        public StateMachineStateQueryElementCollection();
+        protected override string ElementName { get; }
+    }
+    public class TrackingConfigurationCollection<TConfigurationElement> : ConfigurationElementCollection where TConfigurationElement : TrackingConfigurationElement, new() {
+        public TrackingConfigurationCollection();
+        public override ConfigurationElementCollectionType CollectionType { get; }
+        public TConfigurationElement this[int index] { get; set; }
+        public void Add(TConfigurationElement element);
+        public void Clear();
+        protected override ConfigurationElement CreateNewElement();
+        protected override object GetElementKey(ConfigurationElement element);
+        public int IndexOf(TConfigurationElement element);
+        public void Remove(TConfigurationElement element);
+        public void RemoveAt(int index);
+    }
+    public abstract class TrackingConfigurationElement : ConfigurationElement {
+        protected TrackingConfigurationElement();
+        public abstract object ElementKey { get; }
+        protected static string GetStringPairKey(string value1, string value2);
+    }
+    public abstract class TrackingQueryElement : TrackingConfigurationElement {
+        protected TrackingQueryElement();
+        public AnnotationElementCollection Annotations { get; }
+        public override object ElementKey { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        protected abstract TrackingQuery NewTrackingQuery();
+        protected virtual void UpdateTrackingQuery(TrackingQuery trackingQuery);
+    }
+    public class TrackingSection : ConfigurationSection {
+        public TrackingSection();
+        public ProfileElementCollection Profiles { get; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public Collection<TrackingProfile> TrackingProfiles { get; }
+    }
+    public class VariableElement : TrackingConfigurationElement {
+        public VariableElement();
+        public override object ElementKey { get; }
+        public string Name { get; set; }
+        protected override ConfigurationPropertyCollection Properties { get; }
+    }
+    public class VariableElementCollection : TrackingConfigurationCollection<VariableElement> {
+        public VariableElementCollection();
+        protected override string ElementName { get; }
+    }
+    public class WorkflowInstanceQueryElement : TrackingQueryElement {
+        public WorkflowInstanceQueryElement();
+        protected override ConfigurationPropertyCollection Properties { get; }
+        public StateElementCollection States { get; }
+        protected override TrackingQuery NewTrackingQuery();
+    }
+    public sealed class WorkflowInstanceQueryElementCollection : TrackingConfigurationCollection<WorkflowInstanceQueryElement> {
+        public WorkflowInstanceQueryElementCollection();
+        protected override string ElementName { get; }
+    }
+}
```

