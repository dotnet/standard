# System.Runtime.Remoting.MetadataServices

``` diff
+namespace System.Runtime.Remoting.MetadataServices {
+    public class MetaData {
+        public MetaData();
+        public static void ConvertCodeSourceFileToAssemblyFile(string codePath, string assemblyPath, string strongNameFilename);
+        public static void ConvertCodeSourceStreamToAssemblyFile(ArrayList outCodeStreamList, string assemblyPath, string strongNameFilename);
+        public static void ConvertSchemaStreamToCodeSourceStream(bool clientProxy, string outputDirectory, Stream inputStream, ArrayList outCodeStreamList);
+        public static void ConvertSchemaStreamToCodeSourceStream(bool clientProxy, string outputDirectory, Stream inputStream, ArrayList outCodeStreamList, string proxyUrl);
+        public static void ConvertSchemaStreamToCodeSourceStream(bool clientProxy, string outputDirectory, Stream inputStream, ArrayList outCodeStreamList, string proxyUrl, string proxyNamespace);
+        public static void ConvertTypesToSchemaToFile(ServiceType[] types, SdlType sdlType, string path);
+        public static void ConvertTypesToSchemaToFile(Type[] types, SdlType sdlType, string path);
+        public static void ConvertTypesToSchemaToStream(ServiceType[] serviceTypes, SdlType sdlType, Stream outputStream);
+        public static void ConvertTypesToSchemaToStream(Type[] types, SdlType sdlType, Stream outputStream);
+        public static void RetrieveSchemaFromUrlToFile(string url, string path);
+        public static void RetrieveSchemaFromUrlToStream(string url, Stream outputStream);
+        public static void SaveStreamToFile(Stream inputStream, string path);
+    }
+    public class SdlChannelSink : IChannelSinkBase, IServerChannelSink {
+        public SdlChannelSink(IChannelReceiver receiver, IServerChannelSink nextSink);
+        public IServerChannelSink NextChannelSink { get; }
+        public IDictionary Properties { get; }
+        public void AsyncProcessResponse(IServerResponseChannelSinkStack sinkStack, object state, IMessage msg, ITransportHeaders headers, Stream stream);
+        public Stream GetResponseStream(IServerResponseChannelSinkStack sinkStack, object state, IMessage msg, ITransportHeaders headers);
+        public ServerProcessing ProcessMessage(IServerChannelSinkStack sinkStack, IMessage requestMsg, ITransportHeaders requestHeaders, Stream requestStream, out IMessage responseMsg, out ITransportHeaders responseHeaders, out Stream responseStream);
+    }
+    public class SdlChannelSinkProvider : IServerChannelSinkProvider {
+        public SdlChannelSinkProvider();
+        public SdlChannelSinkProvider(IDictionary properties, ICollection providerData);
+        public IServerChannelSinkProvider Next { get; set; }
+        public IServerChannelSink CreateSink(IChannelReceiver channel);
+        public void GetChannelData(IChannelDataStore localChannelData);
+    }
+    public enum SdlType {
+        Sdl = 0,
+        Wsdl = 1,
+    }
+    public class ServiceType {
+        public ServiceType(Type type);
+        public ServiceType(Type type, string url);
+        public Type ObjectType { get; }
+        public string Url { get; }
+    }
+    public class SUDSGeneratorException : Exception {
+        protected SUDSGeneratorException(SerializationInfo info, StreamingContext context);
+    }
+    public class SUDSParserException : Exception {
+        protected SUDSParserException(SerializationInfo info, StreamingContext context);
+    }
+}
```

