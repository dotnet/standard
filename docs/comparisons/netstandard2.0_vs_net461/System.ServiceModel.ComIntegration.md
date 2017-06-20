# System.ServiceModel.ComIntegration

``` diff
+namespace System.ServiceModel.ComIntegration {
+    public class DllHostInitializer : IProcessInitializer {
+        public DllHostInitializer();
+        public void Shutdown();
+        public void Startup(object punkProcessControl);
+    }
+    public interface IChannelCredentials {
+        void SetClientCertificateFromFile(string fileName, string password, string keyStorageFlags);
+        void SetClientCertificateFromStore(string storeLocation, string storeName, string findType, object findValue);
+        void SetClientCertificateFromStoreByName(string subjectName, string storeLocation, string storeName);
+        void SetDefaultServiceCertificateFromFile(string fileName, string password, string keyStorageFlags);
+        void SetDefaultServiceCertificateFromStore(string storeLocation, string storeName, string findType, object findValue);
+        void SetDefaultServiceCertificateFromStoreByName(string subjectName, string storeLocation, string storeName);
+        void SetIssuedToken(string localIssuerAddres, string localIssuerBindingType, string localIssuerBinding);
+        void SetServiceCertificateAuthentication(string storeLocation, string revocationMode, string certificationValidationMode);
+        void SetUserNameCredential(string userName, string password);
+        void SetWindowsCredential(string domain, string userName, string password, int impersonationLevel, bool allowNtlm);
+    }
+    public class PersistStreamTypeWrapper : IExtensibleDataObject {
+        public PersistStreamTypeWrapper();
+        public ExtensionDataObject ExtensionData { get; set; }
+        public void GetObject<T>(ref T obj);
+        public void SetObject<T>(T obj);
+    }
+    public sealed class ServiceMoniker : ContextBoundObject {
+        public ServiceMoniker();
+    }
+    public sealed class WasHostedComPlusFactory : ServiceHostFactoryBase {
+        public WasHostedComPlusFactory();
+        public override ServiceHostBase CreateServiceHost(string constructorString, Uri[] baseAddresses);
+    }
+}
```

