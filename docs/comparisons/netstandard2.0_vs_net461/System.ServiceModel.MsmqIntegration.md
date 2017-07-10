# System.ServiceModel.MsmqIntegration

``` diff
+namespace System.ServiceModel.MsmqIntegration {
+    public class MsmqIntegrationBinding : MsmqBindingBase {
+        public MsmqIntegrationBinding();
+        public MsmqIntegrationBinding(MsmqIntegrationSecurityMode securityMode);
+        public MsmqIntegrationBinding(string configurationName);
+        public MsmqIntegrationSecurity Security { get; set; }
+        public MsmqMessageSerializationFormat SerializationFormat { get; set; }
+        public override BindingElementCollection CreateBindingElements();
+        public bool ShouldSerializeSecurity();
+    }
+    public sealed class MsmqIntegrationBindingElement : MsmqBindingElementBase {
+        public MsmqIntegrationBindingElement();
+        public override string Scheme { get; }
+        public MsmqMessageSerializationFormat SerializationFormat { get; set; }
+        public Type[] TargetSerializationTypes { get; set; }
+        public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context);
+        public override IChannelListener<TChannel> BuildChannelListener<TChannel>(BindingContext context);
+        public override bool CanBuildChannelFactory<TChannel>(BindingContext context);
+        public override bool CanBuildChannelListener<TChannel>(BindingContext context);
+        public override BindingElement Clone();
+        public override T GetProperty<T>(BindingContext context);
+    }
+    public sealed class MsmqIntegrationMessageProperty {
+        public const string Name = "MsmqIntegrationMessageProperty";
+        public MsmqIntegrationMessageProperty();
+        public Nullable<AcknowledgeTypes> AcknowledgeType { get; set; }
+        public Nullable<Acknowledgment> Acknowledgment { get; internal set; }
+        public Uri AdministrationQueue { get; set; }
+        public Nullable<int> AppSpecific { get; set; }
+        public Nullable<DateTime> ArrivedTime { get; internal set; }
+        public Nullable<bool> Authenticated { get; internal set; }
+        public object Body { get; set; }
+        public Nullable<int> BodyType { get; set; }
+        public string CorrelationId { get; set; }
+        public Uri DestinationQueue { get; internal set; }
+        public byte[] Extension { get; set; }
+        public string Id { get; internal set; }
+        public string Label { get; set; }
+        public Nullable<MessageType> MessageType { get; internal set; }
+        public Nullable<MessagePriority> Priority { get; set; }
+        public Uri ResponseQueue { get; set; }
+        public byte[] SenderId { get; internal set; }
+        public Nullable<DateTime> SentTime { get; internal set; }
+        public Nullable<TimeSpan> TimeToReachQueue { get; set; }
+        public static MsmqIntegrationMessageProperty Get(Message message);
+    }
+    public sealed class MsmqIntegrationSecurity {
+        public MsmqIntegrationSecurity();
+        public MsmqIntegrationSecurityMode Mode { get; set; }
+        public MsmqTransportSecurity Transport { get; set; }
+    }
+    public enum MsmqIntegrationSecurityMode {
+        None = 0,
+        Transport = 1,
+    }
+    public sealed class MsmqMessage<T> {
+        public MsmqMessage(T body);
+        public Nullable<AcknowledgeTypes> AcknowledgeType { get; set; }
+        public Nullable<Acknowledgment> Acknowledgment { get; }
+        public Uri AdministrationQueue { get; set; }
+        public Nullable<int> AppSpecific { get; set; }
+        public Nullable<DateTime> ArrivedTime { get; }
+        public Nullable<bool> Authenticated { get; }
+        public T Body { get; set; }
+        public Nullable<int> BodyType { get; set; }
+        public string CorrelationId { get; set; }
+        public Uri DestinationQueue { get; }
+        public byte[] Extension { get; set; }
+        public string Id { get; }
+        public string Label { get; set; }
+        public Nullable<MessageType> MessageType { get; }
+        public Nullable<MessagePriority> Priority { get; set; }
+        public Uri ResponseQueue { get; set; }
+        public byte[] SenderId { get; }
+        public Nullable<DateTime> SentTime { get; }
+        public Nullable<TimeSpan> TimeToReachQueue { get; set; }
+    }
+    public enum MsmqMessageSerializationFormat {
+        ActiveX = 2,
+        Binary = 1,
+        ByteArray = 3,
+        Stream = 4,
+        Xml = 0,
+    }
+}
```

