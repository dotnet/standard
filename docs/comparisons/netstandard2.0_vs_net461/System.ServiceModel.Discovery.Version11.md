# System.ServiceModel.Discovery.Version11

``` diff
+namespace System.ServiceModel.Discovery.Version11 {
+    public class DiscoveryMessageSequence11 : IXmlSerializable {
+        public static DiscoveryMessageSequence11 FromDiscoveryMessageSequence(DiscoveryMessageSequence discoveryMessageSequence);
+        public XmlSchema GetSchema();
+        public static XmlQualifiedName GetSchema(XmlSchemaSet schemaSet);
+        public void ReadXml(XmlReader reader);
+        public DiscoveryMessageSequence ToDiscoveryMessageSequence();
+        public void WriteXml(XmlWriter writer);
+    }
+    public class EndpointDiscoveryMetadata11 : IXmlSerializable {
+        public static EndpointDiscoveryMetadata11 FromEndpointDiscoveryMetadata(EndpointDiscoveryMetadata endpointDiscoveryMetadata);
+        public XmlSchema GetSchema();
+        public static XmlQualifiedName GetSchema(XmlSchemaSet schemaSet);
+        public void ReadXml(XmlReader reader);
+        public EndpointDiscoveryMetadata ToEndpointDiscoveryMetadata();
+        public void WriteXml(XmlWriter writer);
+    }
+    public class FindCriteria11 : IXmlSerializable {
+        public static FindCriteria11 FromFindCriteria(FindCriteria findCriteria);
+        public XmlSchema GetSchema();
+        public static XmlQualifiedName GetSchema(XmlSchemaSet schemaSet);
+        public void ReadXml(XmlReader reader);
+        public FindCriteria ToFindCriteria();
+        public void WriteXml(XmlWriter writer);
+    }
+    public class ResolveCriteria11 : IXmlSerializable {
+        public static ResolveCriteria11 FromResolveCriteria(ResolveCriteria resolveCriteria);
+        public XmlSchema GetSchema();
+        public static XmlQualifiedName GetSchema(XmlSchemaSet schemaSet);
+        public void ReadXml(XmlReader reader);
+        public ResolveCriteria ToResolveCriteria();
+        public void WriteXml(XmlWriter writer);
+    }
+}
```

