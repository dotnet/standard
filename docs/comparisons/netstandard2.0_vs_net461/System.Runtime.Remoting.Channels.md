# System.Runtime.Remoting.Channels

``` diff
+namespace System.Runtime.Remoting.Channels {
+    public abstract class BaseChannelObjectWithProperties : ICollection, IDictionary, IEnumerable {
+        protected BaseChannelObjectWithProperties();
+        public virtual int Count { get; }
+        public virtual bool IsFixedSize { get; }
+        public virtual bool IsReadOnly { get; }
+        public virtual bool IsSynchronized { get; }
+        public virtual ICollection Keys { get; }
+        public virtual IDictionary Properties { get; }
+        public virtual object SyncRoot { get; }
+        public virtual object this[object key] { get; set; }
+        public virtual ICollection Values { get; }
+        public virtual void Add(object key, object value);
+        public virtual void Clear();
+        public virtual bool Contains(object key);
+        public virtual void CopyTo(Array array, int index);
+        public virtual IDictionaryEnumerator GetEnumerator();
+        public virtual void Remove(object key);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+    }
+    public abstract class BaseChannelSinkWithProperties : BaseChannelObjectWithProperties {
+        protected BaseChannelSinkWithProperties();
+    }
+    public abstract class BaseChannelWithProperties : BaseChannelObjectWithProperties {
+        protected IChannelSinkBase SinksWithProperties;
+        protected BaseChannelWithProperties();
+        public override IDictionary Properties { get; }
+    }
+    public class BinaryClientFormatterSink : IChannelSinkBase, IClientChannelSink, IClientFormatterSink, IMessageSink {
+        public BinaryClientFormatterSink(IClientChannelSink nextSink);
+        public IClientChannelSink NextChannelSink { get; }
+        public IMessageSink NextSink { get; }
+        public IDictionary Properties { get; }
+        public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink);
+        public void AsyncProcessRequest(IClientChannelSinkStack sinkStack, IMessage msg, ITransportHeaders headers, Stream stream);
+        public void AsyncProcessResponse(IClientResponseChannelSinkStack sinkStack, object state, ITransportHeaders headers, Stream stream);
+        public Stream GetRequestStream(IMessage msg, ITransportHeaders headers);
+        public void ProcessMessage(IMessage msg, ITransportHeaders requestHeaders, Stream requestStream, out ITransportHeaders responseHeaders, out Stream responseStream);
+        public IMessage SyncProcessMessage(IMessage msg);
+    }
+    public class BinaryClientFormatterSinkProvider : IClientChannelSinkProvider, IClientFormatterSinkProvider {
+        public BinaryClientFormatterSinkProvider();
+        public BinaryClientFormatterSinkProvider(IDictionary properties, ICollection providerData);
+        public IClientChannelSinkProvider Next { get; set; }
+        public IClientChannelSink CreateSink(IChannelSender channel, string url, object remoteChannelData);
+    }
+    public class BinaryServerFormatterSink : IChannelSinkBase, IServerChannelSink {
+        public BinaryServerFormatterSink(BinaryServerFormatterSink.Protocol protocol, IServerChannelSink nextSink, IChannelReceiver receiver);
+        public IServerChannelSink NextChannelSink { get; }
+        public IDictionary Properties { get; }
+        public TypeFilterLevel TypeFilterLevel { get; set; }
+        public void AsyncProcessResponse(IServerResponseChannelSinkStack sinkStack, object state, IMessage msg, ITransportHeaders headers, Stream stream);
+        public Stream GetResponseStream(IServerResponseChannelSinkStack sinkStack, object state, IMessage msg, ITransportHeaders headers);
+        public ServerProcessing ProcessMessage(IServerChannelSinkStack sinkStack, IMessage requestMsg, ITransportHeaders requestHeaders, Stream requestStream, out IMessage responseMsg, out ITransportHeaders responseHeaders, out Stream responseStream);
+        public enum Protocol {
+            Http = 0,
+            Other = 1,
+        }
+    }
+    public class BinaryServerFormatterSinkProvider : IServerChannelSinkProvider, IServerFormatterSinkProvider {
+        public BinaryServerFormatterSinkProvider();
+        public BinaryServerFormatterSinkProvider(IDictionary properties, ICollection providerData);
+        public IServerChannelSinkProvider Next { get; set; }
+        public TypeFilterLevel TypeFilterLevel { get; set; }
+        public IServerChannelSink CreateSink(IChannelReceiver channel);
+        public void GetChannelData(IChannelDataStore channelData);
+    }
+    public class ChannelDataStore : IChannelDataStore {
+        public ChannelDataStore(string[] channelURIs);
+        public string[] ChannelUris { get; set; }
+        public object this[object key] { get; set; }
+    }
+    public sealed class ChannelServices {
+        public static IChannel[] RegisteredChannels { get; }
+        public static IMessageCtrl AsyncDispatchMessage(IMessage msg, IMessageSink replySink);
+        public static IServerChannelSink CreateServerChannelSinkChain(IServerChannelSinkProvider provider, IChannelReceiver channel);
+        public static ServerProcessing DispatchMessage(IServerChannelSinkStack sinkStack, IMessage msg, out IMessage replyMsg);
+        public static IChannel GetChannel(string name);
+        public static IDictionary GetChannelSinkProperties(object obj);
+        public static string[] GetUrlsForObject(MarshalByRefObject obj);
+        public static void RegisterChannel(IChannel chnl);
+        public static void RegisterChannel(IChannel chnl, bool ensureSecurity);
+        public static IMessage SyncDispatchMessage(IMessage msg);
+        public static void UnregisterChannel(IChannel chnl);
+    }
+    public class ClientChannelSinkStack : IClientChannelSinkStack, IClientResponseChannelSinkStack {
+        public ClientChannelSinkStack();
+        public ClientChannelSinkStack(IMessageSink replySink);
+        public void AsyncProcessResponse(ITransportHeaders headers, Stream stream);
+        public void DispatchException(Exception e);
+        public void DispatchReplyMessage(IMessage msg);
+        public object Pop(IClientChannelSink sink);
+        public void Push(IClientChannelSink sink, object state);
+    }
+    public class CommonTransportKeys {
+        public const string ConnectionId = "__ConnectionId";
+        public const string IPAddress = "__IPAddress";
+        public const string RequestUri = "__RequestUri";
+        public CommonTransportKeys();
+    }
+    public interface IAuthorizeRemotingConnection {
+        bool IsConnectingEndPointAuthorized(EndPoint endPoint);
+        bool IsConnectingIdentityAuthorized(IIdentity identity);
+    }
+    public interface IChannel {
+        string ChannelName { get; }
+        int ChannelPriority { get; }
+        string Parse(string url, out string objectURI);
+    }
+    public interface IChannelDataStore {
+        string[] ChannelUris { get; }
+        object this[object key] { get; set; }
+    }
+    public interface IChannelReceiver : IChannel {
+        object ChannelData { get; }
+        string[] GetUrlsForUri(string objectURI);
+        void StartListening(object data);
+        void StopListening(object data);
+    }
+    public interface IChannelReceiverHook {
+        string ChannelScheme { get; }
+        IServerChannelSink ChannelSinkChain { get; }
+        bool WantsToListen { get; }
+        void AddHookChannelUri(string channelUri);
+    }
+    public interface IChannelSender : IChannel {
+        IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI);
+    }
+    public interface IChannelSinkBase {
+        IDictionary Properties { get; }
+    }
+    public interface IClientChannelSink : IChannelSinkBase {
+        IClientChannelSink NextChannelSink { get; }
+        void AsyncProcessRequest(IClientChannelSinkStack sinkStack, IMessage msg, ITransportHeaders headers, Stream stream);
+        void AsyncProcessResponse(IClientResponseChannelSinkStack sinkStack, object state, ITransportHeaders headers, Stream stream);
+        Stream GetRequestStream(IMessage msg, ITransportHeaders headers);
+        void ProcessMessage(IMessage msg, ITransportHeaders requestHeaders, Stream requestStream, out ITransportHeaders responseHeaders, out Stream responseStream);
+    }
+    public interface IClientChannelSinkProvider {
+        IClientChannelSinkProvider Next { get; set; }
+        IClientChannelSink CreateSink(IChannelSender channel, string url, object remoteChannelData);
+    }
+    public interface IClientChannelSinkStack : IClientResponseChannelSinkStack {
+        object Pop(IClientChannelSink sink);
+        void Push(IClientChannelSink sink, object state);
+    }
+    public interface IClientFormatterSink : IChannelSinkBase, IClientChannelSink, IMessageSink
+    public interface IClientFormatterSinkProvider : IClientChannelSinkProvider
+    public interface IClientResponseChannelSinkStack {
+        void AsyncProcessResponse(ITransportHeaders headers, Stream stream);
+        void DispatchException(Exception e);
+        void DispatchReplyMessage(IMessage msg);
+    }
+    public interface ISecurableChannel {
+        bool IsSecured { get; set; }
+    }
+    public interface IServerChannelSink : IChannelSinkBase {
+        IServerChannelSink NextChannelSink { get; }
+        void AsyncProcessResponse(IServerResponseChannelSinkStack sinkStack, object state, IMessage msg, ITransportHeaders headers, Stream stream);
+        Stream GetResponseStream(IServerResponseChannelSinkStack sinkStack, object state, IMessage msg, ITransportHeaders headers);
+        ServerProcessing ProcessMessage(IServerChannelSinkStack sinkStack, IMessage requestMsg, ITransportHeaders requestHeaders, Stream requestStream, out IMessage responseMsg, out ITransportHeaders responseHeaders, out Stream responseStream);
+    }
+    public interface IServerChannelSinkProvider {
+        IServerChannelSinkProvider Next { get; set; }
+        IServerChannelSink CreateSink(IChannelReceiver channel);
+        void GetChannelData(IChannelDataStore channelData);
+    }
+    public interface IServerChannelSinkStack : IServerResponseChannelSinkStack {
+        object Pop(IServerChannelSink sink);
+        void Push(IServerChannelSink sink, object state);
+        void ServerCallback(IAsyncResult ar);
+        void Store(IServerChannelSink sink, object state);
+        void StoreAndDispatch(IServerChannelSink sink, object state);
+    }
+    public interface IServerFormatterSinkProvider : IServerChannelSinkProvider
+    public interface IServerResponseChannelSinkStack {
+        void AsyncProcessResponse(IMessage msg, ITransportHeaders headers, Stream stream);
+        Stream GetResponseStream(IMessage msg, ITransportHeaders headers);
+    }
+    public interface ITransportHeaders {
+        object this[object key] { get; set; }
+        IEnumerator GetEnumerator();
+    }
+    public class ServerChannelSinkStack : IServerChannelSinkStack, IServerResponseChannelSinkStack {
+        public ServerChannelSinkStack();
+        public void AsyncProcessResponse(IMessage msg, ITransportHeaders headers, Stream stream);
+        public Stream GetResponseStream(IMessage msg, ITransportHeaders headers);
+        public object Pop(IServerChannelSink sink);
+        public void Push(IServerChannelSink sink, object state);
+        public void ServerCallback(IAsyncResult ar);
+        public void Store(IServerChannelSink sink, object state);
+        public void StoreAndDispatch(IServerChannelSink sink, object state);
+    }
+    public enum ServerProcessing {
+        Async = 2,
+        Complete = 0,
+        OneWay = 1,
+    }
+    public class SinkProviderData {
+        public SinkProviderData(string name);
+        public IList Children { get; }
+        public string Name { get; }
+        public IDictionary Properties { get; }
+    }
+    public class SoapClientFormatterSink : IChannelSinkBase, IClientChannelSink, IClientFormatterSink, IMessageSink {
+        public SoapClientFormatterSink(IClientChannelSink nextSink);
+        public IClientChannelSink NextChannelSink { get; }
+        public IMessageSink NextSink { get; }
+        public IDictionary Properties { get; }
+        public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink);
+        public void AsyncProcessRequest(IClientChannelSinkStack sinkStack, IMessage msg, ITransportHeaders headers, Stream stream);
+        public void AsyncProcessResponse(IClientResponseChannelSinkStack sinkStack, object state, ITransportHeaders headers, Stream stream);
+        public Stream GetRequestStream(IMessage msg, ITransportHeaders headers);
+        public void ProcessMessage(IMessage msg, ITransportHeaders requestHeaders, Stream requestStream, out ITransportHeaders responseHeaders, out Stream responseStream);
+        public IMessage SyncProcessMessage(IMessage msg);
+    }
+    public class SoapClientFormatterSinkProvider : IClientChannelSinkProvider, IClientFormatterSinkProvider {
+        public SoapClientFormatterSinkProvider();
+        public SoapClientFormatterSinkProvider(IDictionary properties, ICollection providerData);
+        public IClientChannelSinkProvider Next { get; set; }
+        public IClientChannelSink CreateSink(IChannelSender channel, string url, object remoteChannelData);
+    }
+    public class SoapServerFormatterSink : IChannelSinkBase, IServerChannelSink {
+        public SoapServerFormatterSink(SoapServerFormatterSink.Protocol protocol, IServerChannelSink nextSink, IChannelReceiver receiver);
+        public IServerChannelSink NextChannelSink { get; }
+        public IDictionary Properties { get; }
+        public TypeFilterLevel TypeFilterLevel { get; set; }
+        public void AsyncProcessResponse(IServerResponseChannelSinkStack sinkStack, object state, IMessage msg, ITransportHeaders headers, Stream stream);
+        public Stream GetResponseStream(IServerResponseChannelSinkStack sinkStack, object state, IMessage msg, ITransportHeaders headers);
+        public ServerProcessing ProcessMessage(IServerChannelSinkStack sinkStack, IMessage requestMsg, ITransportHeaders requestHeaders, Stream requestStream, out IMessage responseMsg, out ITransportHeaders responseHeaders, out Stream responseStream);
+        public enum Protocol {
+            Http = 0,
+            Other = 1,
+        }
+    }
+    public class SoapServerFormatterSinkProvider : IServerChannelSinkProvider, IServerFormatterSinkProvider {
+        public SoapServerFormatterSinkProvider();
+        public SoapServerFormatterSinkProvider(IDictionary properties, ICollection providerData);
+        public IServerChannelSinkProvider Next { get; set; }
+        public TypeFilterLevel TypeFilterLevel { get; set; }
+        public IServerChannelSink CreateSink(IChannelReceiver channel);
+        public void GetChannelData(IChannelDataStore channelData);
+    }
+    public enum SocketCachePolicy {
+        AbsoluteTimeout = 1,
+        Default = 0,
+    }
+    public class TransportHeaders : ITransportHeaders {
+        public TransportHeaders();
+        public object this[object key] { get; set; }
+        public IEnumerator GetEnumerator();
+    }
+}
```

