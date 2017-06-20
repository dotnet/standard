# System.ServiceModel.Activation

``` diff
+namespace System.ServiceModel.Activation {
+    public sealed class AspNetCompatibilityRequirementsAttribute : Attribute, IServiceBehavior {
+        public AspNetCompatibilityRequirementsAttribute();
+        public AspNetCompatibilityRequirementsMode RequirementsMode { get; set; }
+        void System.ServiceModel.Description.IServiceBehavior.AddBindingParameters(ServiceDescription description, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection parameters);
+        void System.ServiceModel.Description.IServiceBehavior.ApplyDispatchBehavior(ServiceDescription description, ServiceHostBase serviceHostBase);
+        void System.ServiceModel.Description.IServiceBehavior.Validate(ServiceDescription description, ServiceHostBase serviceHostBase);
+    }
+    public enum AspNetCompatibilityRequirementsMode {
+        Allowed = 1,
+        NotAllowed = 0,
+        Required = 2,
+    }
+    public abstract class HostedTransportConfiguration {
+        protected HostedTransportConfiguration();
+        public abstract Uri[] GetBaseAddresses(string virtualPath);
+    }
+    public sealed class ServiceActivationBuildProviderAttribute : Attribute {
+        public ServiceActivationBuildProviderAttribute();
+    }
+    public sealed class ServiceBuildProvider : BuildProvider {
+        public ServiceBuildProvider();
+        public override CompilerType CodeCompilerType { get; }
+        public override ICollection VirtualPathDependencies { get; }
+        public override void GenerateCode(AssemblyBuilder assemblyBuilder);
+        protected override CodeCompileUnit GetCodeCompileUnit(out IDictionary linePragmasTable);
+        public override string GetCustomString(CompilerResults results);
+        public override BuildProviderResultFlags GetResultFlags(CompilerResults results);
+    }
+    public class ServiceHostFactory : ServiceHostFactoryBase {
+        public ServiceHostFactory();
+        public override ServiceHostBase CreateServiceHost(string constructorString, Uri[] baseAddresses);
+        protected virtual ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses);
+    }
+    public abstract class ServiceHostFactoryBase {
+        protected ServiceHostFactoryBase();
+        public abstract ServiceHostBase CreateServiceHost(string constructorString, Uri[] baseAddresses);
+    }
+    public class ServiceRoute : Route {
+        public ServiceRoute(string routePrefix, ServiceHostFactoryBase serviceHostFactory, Type serviceType);
+    }
+    public sealed class VirtualPathExtension : IExtension<ServiceHostBase> {
+        public string ApplicationVirtualPath { get; private set; }
+        public string SiteName { get; private set; }
+        public string VirtualPath { get; private set; }
+        public void Attach(ServiceHostBase owner);
+        public void Detach(ServiceHostBase owner);
+    }
+    public class WebScriptServiceHostFactory : ServiceHostFactory {
+        public WebScriptServiceHostFactory();
+        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses);
+    }
+    public class WebServiceHostFactory : ServiceHostFactory {
+        public WebServiceHostFactory();
+        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses);
+    }
+    public class WorkflowServiceHostFactory : ServiceHostFactoryBase {
+        public WorkflowServiceHostFactory();
+        public override ServiceHostBase CreateServiceHost(string constructorString, Uri[] baseAddresses);
+    }
+}
```

