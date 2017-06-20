# System.ServiceModel.Routing

``` diff
+namespace System.ServiceModel.Routing {
+    public interface IDuplexSessionRouter {
+        IAsyncResult BeginProcessMessage(Message message, AsyncCallback callback, object state);
+        void EndProcessMessage(IAsyncResult result);
+    }
+    public interface IRequestReplyRouter {
+        IAsyncResult BeginProcessRequest(Message message, AsyncCallback callback, object state);
+        Message EndProcessRequest(IAsyncResult result);
+    }
+    public interface ISimplexDatagramRouter {
+        IAsyncResult BeginProcessMessage(Message message, AsyncCallback callback, object state);
+        void EndProcessMessage(IAsyncResult result);
+    }
+    public interface ISimplexSessionRouter {
+        IAsyncResult BeginProcessMessage(Message message, AsyncCallback callback, object state);
+        void EndProcessMessage(IAsyncResult result);
+    }
+    public sealed class RoutingBehavior : IServiceBehavior {
+        public RoutingBehavior(RoutingConfiguration routingConfiguration);
+        public static Type GetContractForDescription(ContractDescription description);
+        void System.ServiceModel.Description.IServiceBehavior.AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection bindingParameters);
+        void System.ServiceModel.Description.IServiceBehavior.ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase);
+        void System.ServiceModel.Description.IServiceBehavior.Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase);
+    }
+    public sealed class RoutingConfiguration {
+        public RoutingConfiguration();
+        public RoutingConfiguration(MessageFilterTable<IEnumerable<ServiceEndpoint>> filterTable, bool routeOnHeadersOnly);
+        public bool EnsureOrderedDispatch { get; set; }
+        public MessageFilterTable<IEnumerable<ServiceEndpoint>> FilterTable { get; }
+        public bool RouteOnHeadersOnly { get; set; }
+        public bool SoapProcessingEnabled { get; set; }
+    }
+    public sealed class RoutingExtension : IExtension<ServiceHostBase> {
+        public void ApplyConfiguration(RoutingConfiguration routingConfiguration);
+        void System.ServiceModel.IExtension<System.ServiceModel.ServiceHostBase>.Attach(ServiceHostBase owner);
+        void System.ServiceModel.IExtension<System.ServiceModel.ServiceHostBase>.Detach(ServiceHostBase owner);
+    }
+    public sealed class RoutingService : IDisposable, IDuplexSessionRouter, IRequestReplyRouter, ISimplexDatagramRouter, ISimplexSessionRouter {
+        void System.IDisposable.Dispose();
+        IAsyncResult System.ServiceModel.Routing.IDuplexSessionRouter.BeginProcessMessage(Message message, AsyncCallback callback, object state);
+        void System.ServiceModel.Routing.IDuplexSessionRouter.EndProcessMessage(IAsyncResult result);
+        IAsyncResult System.ServiceModel.Routing.IRequestReplyRouter.BeginProcessRequest(Message message, AsyncCallback callback, object state);
+        Message System.ServiceModel.Routing.IRequestReplyRouter.EndProcessRequest(IAsyncResult result);
+        IAsyncResult System.ServiceModel.Routing.ISimplexDatagramRouter.BeginProcessMessage(Message message, AsyncCallback callback, object state);
+        void System.ServiceModel.Routing.ISimplexDatagramRouter.EndProcessMessage(IAsyncResult result);
+        IAsyncResult System.ServiceModel.Routing.ISimplexSessionRouter.BeginProcessMessage(Message message, AsyncCallback callback, object state);
+        void System.ServiceModel.Routing.ISimplexSessionRouter.EndProcessMessage(IAsyncResult result);
+    }
+    public class SoapProcessingBehavior : IEndpointBehavior {
+        public SoapProcessingBehavior();
+        public bool ProcessMessages { get; set; }
+        public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters);
+        public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime);
+        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher);
+        public void Validate(ServiceEndpoint endpoint);
+    }
+}
```

