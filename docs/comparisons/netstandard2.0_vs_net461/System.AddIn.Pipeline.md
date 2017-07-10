# System.AddIn.Pipeline

``` diff
+namespace System.AddIn.Pipeline {
+    public sealed class AddInAdapterAttribute : Attribute {
+        public AddInAdapterAttribute();
+    }
+    public sealed class AddInBaseAttribute : Attribute {
+        public AddInBaseAttribute();
+        public Type[] ActivatableAs { get; set; }
+    }
+    public sealed class AddInContractAttribute : Attribute {
+        public AddInContractAttribute();
+    }
+    public static class CollectionAdapters {
+        public static IList<T> ToIList<T>(IListContract<T> collection);
+        public static IList<TView> ToIList<TContract, TView>(IListContract<TContract> collection, Converter<TContract, TView> contractViewAdapter, Converter<TView, TContract> viewContractAdapter);
+        public static IListContract<T> ToIListContract<T>(IList<T> collection);
+        public static IListContract<TContract> ToIListContract<TView, TContract>(IList<TView> collection, Converter<TView, TContract> viewContractAdapter, Converter<TContract, TView> contractViewAdapter);
+    }
+    public static class ContractAdapter {
+        public static TView ContractToViewAdapter<TView>(ContractHandle contract, PipelineStoreLocation location);
+        public static TView ContractToViewAdapter<TView>(ContractHandle contract, string pipelineRoot);
+        public static ContractHandle ViewToContractAdapter(object view);
+    }
+    public class ContractBase : MarshalByRefObject, IContract, ISponsor {
+        public ContractBase();
+        public int AcquireLifetimeToken();
+        public virtual int GetRemoteHashCode();
+        protected virtual void OnFinalRevoke();
+        public virtual IContract QueryContract(string contractIdentifier);
+        public virtual bool RemoteEquals(IContract contract);
+        public virtual string RemoteToString();
+        public TimeSpan Renewal(ILease lease);
+        public void RevokeLifetimeToken(int token);
+    }
+    public class ContractHandle : IDisposable {
+        public ContractHandle(IContract contract);
+        public IContract Contract { get; }
+        public static IContract AppDomainOwner(AppDomain domain);
+        public static bool ContractOwnsAppDomain(IContract contract, AppDomain domain);
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        ~ContractHandle();
+    }
+    public static class FrameworkElementAdapters {
+        public static FrameworkElement ContractToViewAdapter(INativeHandleContract nativeHandleContract);
+        public static INativeHandleContract ViewToContractAdapter(FrameworkElement root);
+    }
+    public sealed class HostAdapterAttribute : Attribute {
+        public HostAdapterAttribute();
+    }
+    public sealed class QualificationDataAttribute : Attribute {
+        public QualificationDataAttribute(string name, string value);
+        public string Name { get; }
+        public string Value { get; }
+    }
+}
```

