# System.Runtime.Serialization.Formatters.Binary

``` diff
 namespace System.Runtime.Serialization.Formatters.Binary {
-    public sealed class BinaryFormatter : IFormatter {
+    public sealed class BinaryFormatter : IFormatter, IRemotingFormatter {
+        public object Deserialize(Stream serializationStream, HeaderHandler handler);
+        public object DeserializeMethodResponse(Stream serializationStream, HeaderHandler handler, IMethodCallMessage methodCallMessage);
+        public void Serialize(Stream serializationStream, object graph, Header[] headers);
+        public object UnsafeDeserialize(Stream serializationStream, HeaderHandler handler);
+        public object UnsafeDeserializeMethodResponse(Stream serializationStream, HeaderHandler handler, IMethodCallMessage methodCallMessage);
     }
 }
```

