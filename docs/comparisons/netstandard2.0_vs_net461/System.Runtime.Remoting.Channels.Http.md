# System.Runtime.Remoting.Channels.Http

``` diff
+namespace System.Runtime.Remoting.Channels.Http {
+    public class HttpChannel : BaseChannelWithProperties, IChannel, IChannelReceiver, IChannelReceiverHook, IChannelSender, ISecurableChannel {
+        public HttpChannel();
+        public HttpChannel(IDictionary properties, IClientChannelSinkProvider clientSinkProvider, IServerChannelSinkProvider serverSinkProvider);
+        public HttpChannel(int port);
+        public object ChannelData { get; }
+        public string ChannelName { get; }
+        public int ChannelPriority { get; }
+        public string ChannelScheme { get; }
+        public IServerChannelSink ChannelSinkChain { get; }
+        public bool IsSecured { get; set; }
+        public override ICollection Keys { get; }
+        public override IDictionary Properties { get; }
+        public override object this[object key] { get; set; }
+        public bool WantsToListen { get; set; }
+        public void AddHookChannelUri(string channelUri);
+        public IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI);
+        public string[] GetUrlsForUri(string objectURI);
+        public string Parse(string url, out string objectURI);
+        public void StartListening(object data);
+        public void StopListening(object data);
+    }
+    public class HttpClientChannel : BaseChannelWithProperties, IChannel, IChannelSender, ISecurableChannel {
+        public HttpClientChannel();
+        public HttpClientChannel(IDictionary properties, IClientChannelSinkProvider sinkProvider);
+        public HttpClientChannel(string name, IClientChannelSinkProvider sinkProvider);
+        public string ChannelName { get; }
+        public int ChannelPriority { get; }
+        public bool IsSecured { get; set; }
+        public override ICollection Keys { get; }
+        public override object this[object key] { get; set; }
+        public virtual IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI);
+        public string Parse(string url, out string objectURI);
+    }
+    public class HttpRemotingHandler : IHttpHandler {
+        public HttpRemotingHandler();
+        public HttpRemotingHandler(Type type, object srvID);
+        public bool IsReusable { get; }
+        public void ProcessRequest(HttpContext context);
+    }
+    public class HttpRemotingHandlerFactory : IHttpHandlerFactory {
+        public HttpRemotingHandlerFactory();
+        public IHttpHandler GetHandler(HttpContext context, string verb, string url, string filePath);
+        public void ReleaseHandler(IHttpHandler handler);
+    }
+    public class HttpServerChannel : BaseChannelWithProperties, IChannel, IChannelReceiver, IChannelReceiverHook {
+        public HttpServerChannel();
+        public HttpServerChannel(IDictionary properties, IServerChannelSinkProvider sinkProvider);
+        public HttpServerChannel(int port);
+        public HttpServerChannel(string name, int port);
+        public HttpServerChannel(string name, int port, IServerChannelSinkProvider sinkProvider);
+        public object ChannelData { get; }
+        public string ChannelName { get; }
+        public int ChannelPriority { get; }
+        public string ChannelScheme { get; }
+        public IServerChannelSink ChannelSinkChain { get; }
+        public override ICollection Keys { get; }
+        public override object this[object key] { get; set; }
+        public bool WantsToListen { get; set; }
+        public void AddHookChannelUri(string channelUri);
+        public string GetChannelUri();
+        public virtual string[] GetUrlsForUri(string objectUri);
+        public string Parse(string url, out string objectURI);
+        public void StartListening(object data);
+        public void StopListening(object data);
+    }
+}
```

