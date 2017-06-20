# System.ServiceModel.Discovery.VersionCD1

``` diff
+namespace System.ServiceModel.Discovery.VersionCD1 {
+    public class DiscoveryMessageSequenceCD1 : IXmlSerializable {
+        public static DiscoveryMessageSequenceCD1 FromDiscoveryMessageSequence(DiscoveryMessageSequence discoveryMessageSequence);
+        public XmlSchema GetSchema();
+        public static XmlQualifiedName GetSchema(XmlSchemaSet schemaSet);
+        public void ReadXml(XmlReader reader);
+        public DiscoveryMessageSequence ToDiscoveryMessageSequence();
+        public void WriteXml(XmlWriter writer);
+    }
+    public class EndpointDiscoveryMetadataCD1 : IXmlSerializable {
+        public static EndpointDiscoveryMetadataCD1 FromEndpointDiscoveryMetadata(EndpointDiscoveryMetadata endpointDiscoveryMetadata);
+        public XmlSchema GetSchema();
+        public static XmlQualifiedName GetSchema(XmlSchemaSet schemaSet);
+        public void ReadXml(XmlReader reader);
+        public EndpointDiscoveryMetadata ToEndpointDiscoveryMetadata();
+        public void WriteXml(XmlWriter writer);
+    }
+    public class FindCriteriaCD1 : IXmlSerializable {
+        public static FindCriteriaCD1 FromFindCriteria(FindCriteria findCriteria);
+        public XmlSchema GetSchema();
+        public static XmlQualifiedName GetSchema(XmlSchemaSet schemaSet);
+        public void ReadXml(XmlReader reader);
+        public FindCriteria ToFindCriteria();
+        public void WriteXml(XmlWriter writer);
+    }
+    public class ResolveCriteriaCD1 : IXmlSerializable {
+        public static ResolveCriteriaCD1 FromResolveCriteria(ResolveCriteria resolveCriteria);
+        public XmlSchema GetSchema();
+        public static XmlQualifiedName GetSchema(XmlSchemaSet schemaSet);
+        public void ReadXml(XmlReader reader);
+        public ResolveCriteria ToResolveCriteria();
+        public void WriteXml(XmlWriter writer);
+    }
+}
```

