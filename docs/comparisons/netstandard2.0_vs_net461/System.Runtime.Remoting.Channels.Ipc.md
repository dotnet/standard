# System.Runtime.Remoting.Channels.Ipc

``` diff
+namespace System.Runtime.Remoting.Channels.Ipc {
+    public class IpcChannel : IChannel, IChannelReceiver, IChannelSender, ISecurableChannel {
+        public IpcChannel();
+        public IpcChannel(IDictionary properties, IClientChannelSinkProvider clientSinkProvider, IServerChannelSinkProvider serverSinkProvider);
+        public IpcChannel(IDictionary properties, IClientChannelSinkProvider clientSinkProvider, IServerChannelSinkProvider serverSinkProvider, CommonSecurityDescriptor securityDescriptor);
+        public IpcChannel(string portName);
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
+    public class IpcClientChannel : IChannel, IChannelSender, ISecurableChannel {
+        public IpcClientChannel();
+        public IpcClientChannel(IDictionary properties, IClientChannelSinkProvider sinkProvider);
+        public IpcClientChannel(string name, IClientChannelSinkProvider sinkProvider);
+        public string ChannelName { get; }
+        public int ChannelPriority { get; }
+        public bool IsSecured { get; set; }
+        public virtual IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI);
+        public string Parse(string url, out string objectURI);
+    }
+    public class IpcServerChannel : IChannel, IChannelReceiver, ISecurableChannel {
+        public IpcServerChannel(IDictionary properties, IServerChannelSinkProvider sinkProvider);
+        public IpcServerChannel(IDictionary properties, IServerChannelSinkProvider sinkProvider, CommonSecurityDescriptor securityDescriptor);
+        public IpcServerChannel(string portName);
+        public IpcServerChannel(string name, string portName);
+        public IpcServerChannel(string name, string portName, IServerChannelSinkProvider sinkProvider);
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

