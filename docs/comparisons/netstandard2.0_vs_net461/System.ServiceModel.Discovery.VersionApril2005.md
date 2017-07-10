# System.ServiceModel.Discovery.VersionApril2005

``` diff
+namespace System.ServiceModel.Discovery.VersionApril2005 {
+    public class DiscoveryMessageSequenceApril2005 : IXmlSerializable {
+        public static DiscoveryMessageSequenceApril2005 FromDiscoveryMessageSequence(DiscoveryMessageSequence discoveryMessageSequence);
+        public XmlSchema GetSchema();
+        public static XmlQualifiedName GetSchema(XmlSchemaSet schemaSet);
+        public void ReadXml(XmlReader reader);
+        public DiscoveryMessageSequence ToDiscoveryMessageSequence();
+        public void WriteXml(XmlWriter writer);
+    }
+    public class EndpointDiscoveryMetadataApril2005 : IXmlSerializable {
+        public static EndpointDiscoveryMetadataApril2005 FromEndpointDiscoveryMetadata(EndpointDiscoveryMetadata endpointDiscoveryMetadata);
+        public XmlSchema GetSchema();
+        public static XmlQualifiedName GetSchema(XmlSchemaSet schemaSet);
+        public void ReadXml(XmlReader reader);
+        public EndpointDiscoveryMetadata ToEndpointDiscoveryMetadata();
+        public void WriteXml(XmlWriter writer);
+    }
+    public class FindCriteriaApril2005 : IXmlSerializable {
+        public static FindCriteriaApril2005 FromFindCriteria(FindCriteria findCriteria);
+        public XmlSchema GetSchema();
+        public static XmlQualifiedName GetSchema(XmlSchemaSet schemaSet);
+        public void ReadXml(XmlReader reader);
+        public FindCriteria ToFindCriteria();
+        public void WriteXml(XmlWriter writer);
+    }
+    public class ResolveCriteriaApril2005 : IXmlSerializable {
+        public static ResolveCriteriaApril2005 FromResolveCriteria(ResolveCriteria resolveCriteria);
+        public XmlSchema GetSchema();
+        public static XmlQualifiedName GetSchema(XmlSchemaSet schemaSet);
+        public void ReadXml(XmlReader reader);
+        public ResolveCriteria ToResolveCriteria();
+        public void WriteXml(XmlWriter writer);
+    }
+}
```

