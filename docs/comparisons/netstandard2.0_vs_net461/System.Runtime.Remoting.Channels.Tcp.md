# System.Runtime.Remoting.Channels.Tcp

``` diff
+namespace System.Runtime.Remoting.Channels.Tcp {
+    public class TcpChannel : IChannel, IChannelReceiver, IChannelSender, ISecurableChannel {
+        public TcpChannel();
+        public TcpChannel(IDictionary properties, IClientChannelSinkProvider clientSinkProvider, IServerChannelSinkProvider serverSinkProvider);
+        public TcpChannel(int port);
+        public object ChannelData { get; }
+        public string ChannelName { get; }
+        public int ChannelPriority { get; }
+        public bool IsSecured { get; set; }
+        public IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI);
+        public string[] GetUrlsForUri(string objectURI);
+        public string Parse(string url, out string objectURI);
+        public void StartListening(object data);
+        public void StopListening(object data);
+    }
+    public class TcpClientChannel : IChannel, IChannelSender, ISecurableChannel {
+        public TcpClientChannel();
+        public TcpClientChannel(IDictionary properties, IClientChannelSinkProvider sinkProvider);
+        public TcpClientChannel(string name, IClientChannelSinkProvider sinkProvider);
+        public string ChannelName { get; }
+        public int ChannelPriority { get; }
+        public bool IsSecured { get; set; }
+        public virtual IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI);
+        public string Parse(string url, out string objectURI);
+    }
+    public class TcpServerChannel : IChannel, IChannelReceiver, ISecurableChannel {
+        public TcpServerChannel(IDictionary properties, IServerChannelSinkProvider sinkProvider);
+        public TcpServerChannel(IDictionary properties, IServerChannelSinkProvider sinkProvider, IAuthorizeRemotingConnection authorizeCallback);
+        public TcpServerChannel(int port);
+        public TcpServerChannel(string name, int port);
+        public TcpServerChannel(string name, int port, IServerChannelSinkProvider sinkProvider);
+        public object ChannelData { get; }
+        public string ChannelName { get; }
+        public int ChannelPriority { get; }
+        public bool IsSecured { get; set; }
+        public string GetChannelUri();
+        public virtual string[] GetUrlsForUri(string objectUri);
+        public string Parse(string url, out string objectURI);
+        public void StartListening(object data);
+        public void StopListening(object data);
+    }
+}
```

