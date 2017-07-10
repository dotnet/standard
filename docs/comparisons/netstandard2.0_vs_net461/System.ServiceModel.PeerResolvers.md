# System.ServiceModel.PeerResolvers

``` diff
+namespace System.ServiceModel.PeerResolvers {
+    public class CustomPeerResolverService : IPeerResolverContract {
+        public CustomPeerResolverService();
+        public TimeSpan CleanupInterval { get; set; }
+        public bool ControlShape { get; set; }
+        public TimeSpan RefreshInterval { get; set; }
+        public virtual void Close();
+        public virtual ServiceSettingsResponseInfo GetServiceSettings();
+        public virtual void Open();
+        public virtual RefreshResponseInfo Refresh(RefreshInfo refreshInfo);
+        public virtual RegisterResponseInfo Register(Guid clientId, string meshId, PeerNodeAddress address);
+        public virtual RegisterResponseInfo Register(RegisterInfo registerInfo);
+        public virtual ResolveResponseInfo Resolve(ResolveInfo resolveInfo);
+        public virtual void Unregister(UnregisterInfo unregisterInfo);
+        public virtual RegisterResponseInfo Update(UpdateInfo updateInfo);
+    }
+    public interface IPeerResolverContract {
+        ServiceSettingsResponseInfo GetServiceSettings();
+        RefreshResponseInfo Refresh(RefreshInfo refreshInfo);
+        RegisterResponseInfo Register(RegisterInfo registerInfo);
+        ResolveResponseInfo Resolve(ResolveInfo resolveInfo);
+        void Unregister(UnregisterInfo unregisterInfo);
+        RegisterResponseInfo Update(UpdateInfo updateInfo);
+    }
+    public class PeerCustomResolverSettings {
+        public PeerCustomResolverSettings();
+        public EndpointAddress Address { get; set; }
+        public Binding Binding { get; set; }
+        public bool IsBindingSpecified { get; }
+        public PeerResolver Resolver { get; set; }
+    }
+    public enum PeerReferralPolicy {
+        DoNotShare = 2,
+        Service = 0,
+        Share = 1,
+    }
+    public enum PeerResolverMode {
+        Auto = 0,
+        Custom = 2,
+        Pnrp = 1,
+    }
+    public class PeerResolverSettings {
+        public PeerResolverSettings();
+        public PeerCustomResolverSettings Custom { get; }
+        public PeerResolverMode Mode { get; set; }
+        public PeerReferralPolicy ReferralPolicy { get; set; }
+    }
+    public class RefreshInfo {
+        public RefreshInfo();
+        public RefreshInfo(string meshId, Guid regId);
+        public string MeshId { get; }
+        public Guid RegistrationId { get; }
+        public bool HasBody();
+    }
+    public class RefreshResponseInfo {
+        public RefreshResponseInfo();
+        public RefreshResponseInfo(TimeSpan registrationLifetime, RefreshResult result);
+        public TimeSpan RegistrationLifetime { get; set; }
+        public RefreshResult Result { get; set; }
+        public bool HasBody();
+    }
+    public enum RefreshResult {
+        RegistrationNotFound = 1,
+        Success = 0,
+    }
+    public class RegisterInfo {
+        public RegisterInfo();
+        public RegisterInfo(Guid client, string meshId, PeerNodeAddress address);
+        public Guid ClientId { get; }
+        public string MeshId { get; }
+        public PeerNodeAddress NodeAddress { get; }
+        public bool HasBody();
+    }
+    public class RegisterResponseInfo {
+        public RegisterResponseInfo();
+        public RegisterResponseInfo(Guid registrationId, TimeSpan registrationLifetime);
+        public Guid RegistrationId { get; set; }
+        public TimeSpan RegistrationLifetime { get; set; }
+        public bool HasBody();
+    }
+    public class ResolveInfo {
+        public ResolveInfo();
+        public ResolveInfo(Guid clientId, string meshId, int maxAddresses);
+        public Guid ClientId { get; }
+        public int MaxAddresses { get; }
+        public string MeshId { get; }
+        public bool HasBody();
+    }
+    public class ResolveResponseInfo {
+        public ResolveResponseInfo();
+        public ResolveResponseInfo(PeerNodeAddress[] addresses);
+        public IList<PeerNodeAddress> Addresses { get; set; }
+        public bool HasBody();
+    }
+    public class ServiceSettingsResponseInfo {
+        public ServiceSettingsResponseInfo();
+        public ServiceSettingsResponseInfo(bool control);
+        public bool ControlMeshShape { get; set; }
+        public bool HasBody();
+    }
+    public class UnregisterInfo {
+        public UnregisterInfo();
+        public UnregisterInfo(string meshId, Guid registrationId);
+        public string MeshId { get; }
+        public Guid RegistrationId { get; }
+        public bool HasBody();
+    }
+    public class UpdateInfo {
+        public UpdateInfo();
+        public UpdateInfo(Guid registrationId, Guid client, string meshId, PeerNodeAddress address);
+        public Guid ClientId { get; }
+        public string MeshId { get; }
+        public PeerNodeAddress NodeAddress { get; }
+        public Guid RegistrationId { get; }
+        public bool HasBody();
+    }
+}
```

