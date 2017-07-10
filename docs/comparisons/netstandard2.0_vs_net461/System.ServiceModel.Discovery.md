# System.ServiceModel.Discovery

``` diff
+namespace System.ServiceModel.Discovery {
+    public sealed class AnnouncementClient : ICommunicationObject, IDisposable {
+        public AnnouncementClient();
+        public AnnouncementClient(AnnouncementEndpoint announcementEndpoint);
+        public AnnouncementClient(string endpointConfigurationName);
+        public ChannelFactory ChannelFactory { get; }
+        public ClientCredentials ClientCredentials { get; }
+        public ServiceEndpoint Endpoint { get; }
+        public IClientChannel InnerChannel { get; }
+        public DiscoveryMessageSequenceGenerator MessageSequenceGenerator { get; set; }
+        CommunicationState System.ServiceModel.ICommunicationObject.State { get; }
+        public event EventHandler<AsyncCompletedEventArgs> AnnounceOfflineCompleted;
+        public event EventHandler<AsyncCompletedEventArgs> AnnounceOnlineCompleted;
+        event EventHandler System.ServiceModel.ICommunicationObject.Closed;
+        event EventHandler System.ServiceModel.ICommunicationObject.Closing;
+        event EventHandler System.ServiceModel.ICommunicationObject.Faulted;
+        event EventHandler System.ServiceModel.ICommunicationObject.Opened;
+        event EventHandler System.ServiceModel.ICommunicationObject.Opening;
+        public void AnnounceOffline(EndpointDiscoveryMetadata discoveryMetadata);
+        public void AnnounceOfflineAsync(EndpointDiscoveryMetadata discoveryMetadata);
+        public void AnnounceOfflineAsync(EndpointDiscoveryMetadata discoveryMetadata, object userState);
+        public Task AnnounceOfflineTaskAsync(EndpointDiscoveryMetadata discoveryMetadata);
+        public void AnnounceOnline(EndpointDiscoveryMetadata discoveryMetadata);
+        public void AnnounceOnlineAsync(EndpointDiscoveryMetadata discoveryMetadata);
+        public void AnnounceOnlineAsync(EndpointDiscoveryMetadata discoveryMetadata, object userState);
+        public Task AnnounceOnlineTaskAsync(EndpointDiscoveryMetadata discoveryMetadata);
+        public IAsyncResult BeginAnnounceOffline(EndpointDiscoveryMetadata discoveryMetadata, AsyncCallback callback, object state);
+        public IAsyncResult BeginAnnounceOnline(EndpointDiscoveryMetadata discoveryMetadata, AsyncCallback callback, object state);
+        public void Close();
+        public void EndAnnounceOffline(IAsyncResult result);
+        public void EndAnnounceOnline(IAsyncResult result);
+        public void Open();
+        void System.IDisposable.Dispose();
+        void System.ServiceModel.ICommunicationObject.Abort();
+        IAsyncResult System.ServiceModel.ICommunicationObject.BeginClose(AsyncCallback callback, object state);
+        IAsyncResult System.ServiceModel.ICommunicationObject.BeginClose(TimeSpan timeout, AsyncCallback callback, object state);
+        IAsyncResult System.ServiceModel.ICommunicationObject.BeginOpen(AsyncCallback callback, object state);
+        IAsyncResult System.ServiceModel.ICommunicationObject.BeginOpen(TimeSpan timeout, AsyncCallback callback, object state);
+        void System.ServiceModel.ICommunicationObject.Close();
+        void System.ServiceModel.ICommunicationObject.Close(TimeSpan timeout);
+        void System.ServiceModel.ICommunicationObject.EndClose(IAsyncResult result);
+        void System.ServiceModel.ICommunicationObject.EndOpen(IAsyncResult result);
+        void System.ServiceModel.ICommunicationObject.Open();
+        void System.ServiceModel.ICommunicationObject.Open(TimeSpan timeout);
+    }
+    public class AnnouncementEndpoint : ServiceEndpoint {
+        public AnnouncementEndpoint();
+        public AnnouncementEndpoint(Binding binding, EndpointAddress address);
+        public AnnouncementEndpoint(DiscoveryVersion discoveryVersion);
+        public AnnouncementEndpoint(DiscoveryVersion discoveryVersion, Binding binding, EndpointAddress address);
+        public DiscoveryVersion DiscoveryVersion { get; }
+        public TimeSpan MaxAnnouncementDelay { get; set; }
+    }
+    public class AnnouncementEventArgs : EventArgs {
+        public EndpointDiscoveryMetadata EndpointDiscoveryMetadata { get; private set; }
+        public DiscoveryMessageSequence MessageSequence { get; private set; }
+    }
+    public class AnnouncementService : IAnnouncementContract11, IAnnouncementContractApril2005, IAnnouncementContractCD1, IAnnouncementServiceImplementation {
+        public AnnouncementService();
+        public AnnouncementService(int duplicateMessageHistoryLength);
+        public event EventHandler<AnnouncementEventArgs> OfflineAnnouncementReceived;
+        public event EventHandler<AnnouncementEventArgs> OnlineAnnouncementReceived;
+        protected virtual IAsyncResult OnBeginOfflineAnnouncement(DiscoveryMessageSequence messageSequence, EndpointDiscoveryMetadata endpointDiscoveryMetadata, AsyncCallback callback, object state);
+        protected virtual IAsyncResult OnBeginOnlineAnnouncement(DiscoveryMessageSequence messageSequence, EndpointDiscoveryMetadata endpointDiscoveryMetadata, AsyncCallback callback, object state);
+        protected virtual void OnEndOfflineAnnouncement(IAsyncResult result);
+        protected virtual void OnEndOnlineAnnouncement(IAsyncResult result);
+    }
+    public sealed class DiscoveryClient : ICommunicationObject, IDiscoveryInnerClientResponse, IDisposable {
+        public DiscoveryClient();
+        public DiscoveryClient(DiscoveryEndpoint discoveryEndpoint);
+        public DiscoveryClient(string endpointConfigurationName);
+        public ChannelFactory ChannelFactory { get; }
+        public ClientCredentials ClientCredentials { get; }
+        public ServiceEndpoint Endpoint { get; }
+        public IClientChannel InnerChannel { get; }
+        CommunicationState System.ServiceModel.ICommunicationObject.State { get; }
+        public event EventHandler<FindCompletedEventArgs> FindCompleted;
+        public event EventHandler<FindProgressChangedEventArgs> FindProgressChanged;
+        public event EventHandler<AnnouncementEventArgs> ProxyAvailable;
+        public event EventHandler<ResolveCompletedEventArgs> ResolveCompleted;
+        event EventHandler System.ServiceModel.ICommunicationObject.Closed;
+        event EventHandler System.ServiceModel.ICommunicationObject.Closing;
+        event EventHandler System.ServiceModel.ICommunicationObject.Faulted;
+        event EventHandler System.ServiceModel.ICommunicationObject.Opened;
+        event EventHandler System.ServiceModel.ICommunicationObject.Opening;
+        public void CancelAsync(object userState);
+        public void Close();
+        public FindResponse Find(FindCriteria criteria);
+        public void FindAsync(FindCriteria criteria);
+        public void FindAsync(FindCriteria criteria, object userState);
+        public Task<FindResponse> FindTaskAsync(FindCriteria criteria);
+        public Task<FindResponse> FindTaskAsync(FindCriteria criteria, CancellationToken cancellationToken);
+        public void Open();
+        public ResolveResponse Resolve(ResolveCriteria criteria);
+        public void ResolveAsync(ResolveCriteria criteria);
+        public void ResolveAsync(ResolveCriteria criteria, object userState);
+        public Task<ResolveResponse> ResolveTaskAsync(ResolveCriteria criteria);
+        public Task<ResolveResponse> ResolveTaskAsync(ResolveCriteria criteria, CancellationToken cancellationToken);
+        void System.IDisposable.Dispose();
+        void System.ServiceModel.ICommunicationObject.Abort();
+        IAsyncResult System.ServiceModel.ICommunicationObject.BeginClose(AsyncCallback callback, object state);
+        IAsyncResult System.ServiceModel.ICommunicationObject.BeginClose(TimeSpan timeout, AsyncCallback callback, object state);
+        IAsyncResult System.ServiceModel.ICommunicationObject.BeginOpen(AsyncCallback callback, object state);
+        IAsyncResult System.ServiceModel.ICommunicationObject.BeginOpen(TimeSpan timeout, AsyncCallback callback, object state);
+        void System.ServiceModel.ICommunicationObject.Close();
+        void System.ServiceModel.ICommunicationObject.Close(TimeSpan timeout);
+        void System.ServiceModel.ICommunicationObject.EndClose(IAsyncResult result);
+        void System.ServiceModel.ICommunicationObject.EndOpen(IAsyncResult result);
+        void System.ServiceModel.ICommunicationObject.Open();
+        void System.ServiceModel.ICommunicationObject.Open(TimeSpan timeout);
+    }
+    public sealed class DiscoveryClientBindingElement : BindingElement {
+        public static readonly EndpointAddress DiscoveryEndpointAddress;
+        public DiscoveryClientBindingElement();
+        public DiscoveryClientBindingElement(DiscoveryEndpointProvider discoveryEndpointProvider, FindCriteria findCriteria);
+        public DiscoveryEndpointProvider DiscoveryEndpointProvider { get; set; }
+        public FindCriteria FindCriteria { get; set; }
+        public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context);
+        public override IChannelListener<TChannel> BuildChannelListener<TChannel>(BindingContext context);
+        public override bool CanBuildChannelFactory<TChannel>(BindingContext context);
+        public override bool CanBuildChannelListener<TChannel>(BindingContext context);
+        public override BindingElement Clone();
+        public override T GetProperty<T>(BindingContext context);
+    }
+    public class DiscoveryEndpoint : ServiceEndpoint {
+        public DiscoveryEndpoint();
+        public DiscoveryEndpoint(Binding binding, EndpointAddress endpointAddress);
+        public DiscoveryEndpoint(DiscoveryVersion discoveryVersion, ServiceDiscoveryMode discoveryMode);
+        public DiscoveryEndpoint(DiscoveryVersion discoveryVersion, ServiceDiscoveryMode discoveryMode, Binding binding, EndpointAddress endpointAddress);
+        public ServiceDiscoveryMode DiscoveryMode { get; }
+        public DiscoveryVersion DiscoveryVersion { get; }
+        public TimeSpan MaxResponseDelay { get; set; }
+    }
+    public abstract class DiscoveryEndpointProvider {
+        protected DiscoveryEndpointProvider();
+        public abstract DiscoveryEndpoint GetDiscoveryEndpoint();
+    }
+    public class DiscoveryMessageSequence : IComparable<DiscoveryMessageSequence>, IEquatable<DiscoveryMessageSequence> {
+        public long InstanceId { get; private set; }
+        public long MessageNumber { get; private set; }
+        public Uri SequenceId { get; private set; }
+        public bool CanCompareTo(DiscoveryMessageSequence other);
+        public int CompareTo(DiscoveryMessageSequence other);
+        public override bool Equals(object obj);
+        public bool Equals(DiscoveryMessageSequence other);
+        public override int GetHashCode();
+        public static bool operator ==(DiscoveryMessageSequence messageSequence1, DiscoveryMessageSequence messageSequence2);
+        public static bool operator !=(DiscoveryMessageSequence messageSequence1, DiscoveryMessageSequence messageSequence2);
+        public override string ToString();
+    }
+    public class DiscoveryMessageSequenceGenerator {
+        public DiscoveryMessageSequenceGenerator();
+        public DiscoveryMessageSequenceGenerator(long instanceId, Uri sequenceId);
+        public DiscoveryMessageSequence Next();
+    }
+    public class DiscoveryOperationContextExtension : IExtension<OperationContext> {
+        public ServiceDiscoveryMode DiscoveryMode { get; }
+        public DiscoveryVersion DiscoveryVersion { get; }
+        public TimeSpan MaxResponseDelay { get; internal set; }
+        void System.ServiceModel.IExtension<System.ServiceModel.OperationContext>.Attach(OperationContext owner);
+        void System.ServiceModel.IExtension<System.ServiceModel.OperationContext>.Detach(OperationContext owner);
+    }
+    public abstract class DiscoveryProxy : IAnnouncementContract11, IAnnouncementContractApril2005, IAnnouncementContractCD1, IAnnouncementServiceImplementation, IDiscoveryContractAdhoc11, IDiscoveryContractAdhocApril2005, IDiscoveryContractAdhocCD1, IDiscoveryContractApril2005, IDiscoveryContractManaged11, IDiscoveryContractManagedApril2005, IDiscoveryContractManagedCD1, IDiscoveryServiceImplementation, IMulticastSuppressionImplementation {
+        protected DiscoveryProxy();
+        protected DiscoveryProxy(DiscoveryMessageSequenceGenerator messageSequenceGenerator);
+        protected DiscoveryProxy(DiscoveryMessageSequenceGenerator messageSequenceGenerator, int duplicateMessageHistoryLength);
+        protected virtual IAsyncResult BeginShouldRedirectFind(FindCriteria resolveCriteria, AsyncCallback callback, object state);
+        protected virtual IAsyncResult BeginShouldRedirectResolve(ResolveCriteria findCriteria, AsyncCallback callback, object state);
+        protected virtual bool EndShouldRedirectFind(IAsyncResult result, out Collection<EndpointDiscoveryMetadata> redirectionEndpoints);
+        protected virtual bool EndShouldRedirectResolve(IAsyncResult result, out Collection<EndpointDiscoveryMetadata> redirectionEndpoints);
+        protected abstract IAsyncResult OnBeginFind(FindRequestContext findRequestContext, AsyncCallback callback, object state);
+        protected abstract IAsyncResult OnBeginOfflineAnnouncement(DiscoveryMessageSequence messageSequence, EndpointDiscoveryMetadata endpointDiscoveryMetadata, AsyncCallback callback, object state);
+        protected abstract IAsyncResult OnBeginOnlineAnnouncement(DiscoveryMessageSequence messageSequence, EndpointDiscoveryMetadata endpointDiscoveryMetadata, AsyncCallback callback, object state);
+        protected abstract IAsyncResult OnBeginResolve(ResolveCriteria resolveCriteria, AsyncCallback callback, object state);
+        protected abstract void OnEndFind(IAsyncResult result);
+        protected abstract void OnEndOfflineAnnouncement(IAsyncResult result);
+        protected abstract void OnEndOnlineAnnouncement(IAsyncResult result);
+        protected abstract EndpointDiscoveryMetadata OnEndResolve(IAsyncResult result);
+    }
+    public abstract class DiscoveryService : IDiscoveryContractAdhoc11, IDiscoveryContractAdhocApril2005, IDiscoveryContractAdhocCD1, IDiscoveryContractApril2005, IDiscoveryContractManaged11, IDiscoveryContractManagedApril2005, IDiscoveryContractManagedCD1, IDiscoveryServiceImplementation {
+        protected DiscoveryService();
+        protected DiscoveryService(DiscoveryMessageSequenceGenerator discoveryMessageSequenceGenerator);
+        protected DiscoveryService(DiscoveryMessageSequenceGenerator discoveryMessageSequenceGenerator, int duplicateMessageHistoryLength);
+        protected abstract IAsyncResult OnBeginFind(FindRequestContext findRequestContext, AsyncCallback callback, object state);
+        protected abstract IAsyncResult OnBeginResolve(ResolveCriteria resolveCriteria, AsyncCallback callback, object state);
+        protected abstract void OnEndFind(IAsyncResult result);
+        protected abstract EndpointDiscoveryMetadata OnEndResolve(IAsyncResult result);
+    }
+    public abstract class DiscoveryServiceExtension : IExtension<ServiceHostBase> {
+        protected DiscoveryServiceExtension();
+        public ReadOnlyCollection<EndpointDiscoveryMetadata> PublishedEndpoints { get; }
+        protected abstract DiscoveryService GetDiscoveryService();
+        void System.ServiceModel.IExtension<System.ServiceModel.ServiceHostBase>.Attach(ServiceHostBase owner);
+        void System.ServiceModel.IExtension<System.ServiceModel.ServiceHostBase>.Detach(ServiceHostBase owner);
+    }
+    public sealed class DiscoveryVersion {
+        public Uri AdhocAddress { get; }
+        public MessageVersion MessageVersion { get; }
+        public string Name { get; }
+        public string Namespace { get; }
+        public static DiscoveryVersion WSDiscovery11 { get; }
+        public static DiscoveryVersion WSDiscoveryApril2005 { get; }
+        public static DiscoveryVersion WSDiscoveryCD1 { get; }
+        public static DiscoveryVersion FromName(string name);
+        public override string ToString();
+    }
+    public class DynamicEndpoint : ServiceEndpoint {
+        public DynamicEndpoint(ContractDescription contract, Binding binding);
+        public DiscoveryEndpointProvider DiscoveryEndpointProvider { get; set; }
+        public FindCriteria FindCriteria { get; set; }
+    }
+    public class EndpointDiscoveryBehavior : IEndpointBehavior {
+        public EndpointDiscoveryBehavior();
+        public Collection<XmlQualifiedName> ContractTypeNames { get; }
+        public bool Enabled { get; set; }
+        public Collection<XElement> Extensions { get; }
+        public Collection<Uri> Scopes { get; }
+        void System.ServiceModel.Description.IEndpointBehavior.AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters);
+        void System.ServiceModel.Description.IEndpointBehavior.ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime);
+        void System.ServiceModel.Description.IEndpointBehavior.ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher);
+        void System.ServiceModel.Description.IEndpointBehavior.Validate(ServiceEndpoint endpoint);
+    }
+    public class EndpointDiscoveryMetadata {
+        public EndpointDiscoveryMetadata();
+        public EndpointAddress Address { get; set; }
+        public Collection<XmlQualifiedName> ContractTypeNames { get; }
+        public Collection<XElement> Extensions { get; }
+        public Collection<Uri> ListenUris { get; }
+        public Collection<Uri> Scopes { get; }
+        public int Version { get; set; }
+        public static EndpointDiscoveryMetadata FromServiceEndpoint(ServiceEndpoint endpoint);
+        public static EndpointDiscoveryMetadata FromServiceEndpoint(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher);
+    }
+    public class FindCompletedEventArgs : AsyncCompletedEventArgs {
+        public FindResponse Result { get; }
+    }
+    public class FindCriteria {
+        public static readonly Uri ScopeMatchByExact;
+        public static readonly Uri ScopeMatchByLdap;
+        public static readonly Uri ScopeMatchByNone;
+        public static readonly Uri ScopeMatchByPrefix;
+        public static readonly Uri ScopeMatchByUuid;
+        public FindCriteria();
+        public FindCriteria(Type contractType);
+        public Collection<XmlQualifiedName> ContractTypeNames { get; }
+        public TimeSpan Duration { get; set; }
+        public Collection<XElement> Extensions { get; }
+        public int MaxResults { get; set; }
+        public Uri ScopeMatchBy { get; set; }
+        public Collection<Uri> Scopes { get; }
+        public static FindCriteria CreateMetadataExchangeEndpointCriteria();
+        public static FindCriteria CreateMetadataExchangeEndpointCriteria(IEnumerable<XmlQualifiedName> contractTypeNames);
+        public static FindCriteria CreateMetadataExchangeEndpointCriteria(Type contractType);
+        public bool IsMatch(EndpointDiscoveryMetadata endpointDiscoveryMetadata);
+    }
+    public class FindProgressChangedEventArgs : ProgressChangedEventArgs {
+        public EndpointDiscoveryMetadata EndpointDiscoveryMetadata { get; }
+        public DiscoveryMessageSequence MessageSequence { get; }
+    }
+    public class FindRequestContext {
+        protected FindRequestContext(FindCriteria criteria);
+        public FindCriteria Criteria { get; }
+        public void AddMatchingEndpoint(EndpointDiscoveryMetadata matchingEndpoint);
+        protected virtual void OnAddMatchingEndpoint(EndpointDiscoveryMetadata matchingEndpoint);
+    }
+    public class FindResponse {
+        public Collection<EndpointDiscoveryMetadata> Endpoints { get; }
+        public DiscoveryMessageSequence GetMessageSequence(EndpointDiscoveryMetadata endpointDiscoveryMetadata);
+    }
+    public class ResolveCompletedEventArgs : AsyncCompletedEventArgs {
+        public ResolveResponse Result { get; }
+    }
+    public class ResolveCriteria {
+        public ResolveCriteria();
+        public ResolveCriteria(EndpointAddress address);
+        public EndpointAddress Address { get; set; }
+        public TimeSpan Duration { get; set; }
+        public Collection<XElement> Extensions { get; }
+    }
+    public class ResolveResponse {
+        public EndpointDiscoveryMetadata EndpointDiscoveryMetadata { get; internal set; }
+        public DiscoveryMessageSequence MessageSequence { get; internal set; }
+    }
+    public class ServiceDiscoveryBehavior : IServiceBehavior {
+        public ServiceDiscoveryBehavior();
+        public Collection<AnnouncementEndpoint> AnnouncementEndpoints { get; }
+        void System.ServiceModel.Description.IServiceBehavior.AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection bindingParameters);
+        void System.ServiceModel.Description.IServiceBehavior.ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase);
+        void System.ServiceModel.Description.IServiceBehavior.Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase);
+    }
+    public enum ServiceDiscoveryMode {
+        Adhoc = 0,
+        Managed = 1,
+    }
+    public class UdpAnnouncementEndpoint : AnnouncementEndpoint {
+        public static readonly Uri DefaultIPv4MulticastAddress;
+        public static readonly Uri DefaultIPv6MulticastAddress;
+        public UdpAnnouncementEndpoint();
+        public UdpAnnouncementEndpoint(DiscoveryVersion discoveryVersion);
+        public UdpAnnouncementEndpoint(DiscoveryVersion discoveryVersion, string multicastAddress);
+        public UdpAnnouncementEndpoint(DiscoveryVersion discoveryVersion, Uri multicastAddress);
+        public UdpAnnouncementEndpoint(string multicastAddress);
+        public UdpAnnouncementEndpoint(Uri multicastAddress);
+        public Uri MulticastAddress { get; set; }
+        public UdpTransportSettings TransportSettings { get; }
+    }
+    public class UdpDiscoveryEndpoint : DiscoveryEndpoint {
+        public static readonly Uri DefaultIPv4MulticastAddress;
+        public static readonly Uri DefaultIPv6MulticastAddress;
+        public UdpDiscoveryEndpoint();
+        public UdpDiscoveryEndpoint(DiscoveryVersion discoveryVersion);
+        public UdpDiscoveryEndpoint(DiscoveryVersion discoveryVersion, string multicastAddress);
+        public UdpDiscoveryEndpoint(DiscoveryVersion discoveryVersion, Uri multicastAddress);
+        public UdpDiscoveryEndpoint(string multicastAddress);
+        public UdpDiscoveryEndpoint(Uri multicastAddress);
+        public Uri MulticastAddress { get; set; }
+        public UdpTransportSettings TransportSettings { get; }
+    }
+    public class UdpTransportSettings {
+        public int DuplicateMessageHistoryLength { get; set; }
+        public long MaxBufferPoolSize { get; set; }
+        public int MaxMulticastRetransmitCount { get; set; }
+        public int MaxPendingMessageCount { get; set; }
+        public long MaxReceivedMessageSize { get; set; }
+        public int MaxUnicastRetransmitCount { get; set; }
+        public string MulticastInterfaceId { get; set; }
+        public int SocketReceiveBufferSize { get; set; }
+        public int TimeToLive { get; set; }
+    }
+}
```

