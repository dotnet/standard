# System.Runtime.Serialization.Formatters.Soap

``` diff
+namespace System.Runtime.Serialization.Formatters.Soap {
+    public sealed class SoapFormatter : IFormatter, IRemotingFormatter {
+        public SoapFormatter();
+        public SoapFormatter(ISurrogateSelector selector, StreamingContext context);
+        public FormatterAssemblyStyle AssemblyFormat { get; set; }
+        public SerializationBinder Binder { get; set; }
+        public StreamingContext Context { get; set; }
+        public TypeFilterLevel FilterLevel { get; set; }
+        public ISurrogateSelector SurrogateSelector { get; set; }
+        public ISoapMessage TopObject { get; set; }
+        public FormatterTypeStyle TypeFormat { get; set; }
+        public object Deserialize(Stream serializationStream);
+        public object Deserialize(Stream serializationStream, HeaderHandler handler);
+        public void Serialize(Stream serializationStream, object graph);
+        public void Serialize(Stream serializationStream, object graph, Header[] headers);
+    }
+}
```

