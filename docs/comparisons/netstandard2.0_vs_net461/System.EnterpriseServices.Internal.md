# System.EnterpriseServices.Internal

``` diff
+namespace System.EnterpriseServices.Internal {
+    public class AppDomainHelper {
+        public AppDomainHelper();
+        ~AppDomainHelper();
+    }
+    public class AssemblyLocator : MarshalByRefObject {
+        public AssemblyLocator();
+    }
+    public class ClientRemotingConfig {
+        public ClientRemotingConfig();
+        public static bool Write(string DestinationDirectory, string VRoot, string BaseUrl, string AssemblyName, string TypeName, string ProgId, string Mode, string Transport);
+    }
+    public class ClrObjectFactory : IClrObjectFactory {
+        public ClrObjectFactory();
+        public object CreateFromAssembly(string AssemblyName, string TypeName, string Mode);
+        public object CreateFromMailbox(string Mailbox, string Mode);
+        public object CreateFromVroot(string VrootUrl, string Mode);
+        public object CreateFromWsdl(string WsdlUrl, string Mode);
+    }
+    public class ComManagedImportUtil : IComManagedImportUtil {
+        public ComManagedImportUtil();
+        public void GetComponentInfo(string assemblyPath, out string numComponents, out string componentInfo);
+        public void InstallAssembly(string asmpath, string parname, string appname);
+    }
+    public class ComSoapPublishError {
+        public ComSoapPublishError();
+        public static void Report(string s);
+    }
+    public class GenerateMetadata : IComSoapMetadata {
+        public GenerateMetadata();
+        public string Generate(string strSrcTypeLib, string outPath);
+        public string GenerateMetaData(string strSrcTypeLib, string outPath, byte[] PublicKey, StrongNameKeyPair KeyPair);
+        public string GenerateSigned(string strSrcTypeLib, string outPath, bool InstallGac, out string Error);
+        public static extern int SearchPath(string path, string fileName, string extension, int numBufferChars, string buffer, int[] filePart);
+    }
+    public interface IClrObjectFactory {
+        object CreateFromAssembly(string assembly, string type, string mode);
+        object CreateFromMailbox(string Mailbox, string Mode);
+        object CreateFromVroot(string VrootUrl, string Mode);
+        object CreateFromWsdl(string WsdlUrl, string Mode);
+    }
+    public interface IComManagedImportUtil {
+        void GetComponentInfo(string assemblyPath, out string numComponents, out string componentInfo);
+        void InstallAssembly(string filename, string parname, string appname);
+    }
+    public interface IComSoapIISVRoot {
+        void Create(string RootWeb, string PhysicalDirectory, string VirtualDirectory, out string Error);
+        void Delete(string RootWeb, string PhysicalDirectory, string VirtualDirectory, out string Error);
+    }
+    public interface IComSoapMetadata {
+        string Generate(string SrcTypeLibFileName, string OutPath);
+        string GenerateSigned(string SrcTypeLibFileName, string OutPath, bool InstallGac, out string Error);
+    }
+    public interface IComSoapPublisher {
+        void CreateMailBox(string RootMailServer, string MailBox, out string SmtpName, out string Domain, out string PhysicalPath, out string Error);
+        void CreateVirtualRoot(string Operation, string FullUrl, out string BaseUrl, out string VirtualRoot, out string PhysicalPath, out string Error);
+        void DeleteMailBox(string RootMailServer, string MailBox, out string Error);
+        void DeleteVirtualRoot(string RootWebServer, string FullUrl, out string Error);
+        void GacInstall(string AssemblyPath);
+        void GacRemove(string AssemblyPath);
+        void GetAssemblyNameForCache(string TypeLibPath, out string CachePath);
+        string GetTypeNameFromProgId(string AssemblyPath, string ProgId);
+        void ProcessClientTlb(string ProgId, string SrcTlbPath, string PhysicalPath, string VRoot, string BaseUrl, string Mode, string Transport, out string AssemblyName, out string TypeName, out string Error);
+        void ProcessServerTlb(string ProgId, string SrcTlbPath, string PhysicalPath, string Operation, out string AssemblyName, out string TypeName, out string Error);
+        void RegisterAssembly(string AssemblyPath);
+        void UnRegisterAssembly(string AssemblyPath);
+    }
+    public class IISVirtualRoot : IComSoapIISVRoot {
+        public IISVirtualRoot();
+        public void Create(string RootWeb, string inPhysicalDirectory, string VirtualDirectory, out string Error);
+        public void Delete(string RootWeb, string PhysicalDirectory, string VirtualDirectory, out string Error);
+    }
+    public interface IServerWebConfig {
+        void AddElement(string FilePath, string AssemblyName, string TypeName, string ProgId, string Mode, out string Error);
+        void Create(string FilePath, string FileRootName, out string Error);
+    }
+    public interface ISoapClientImport {
+        void ProcessClientTlbEx(string progId, string virtualRoot, string baseUrl, string authentication, string assemblyName, string typeName);
+    }
+    public interface ISoapServerTlb {
+        void AddServerTlb(string progId, string classId, string interfaceId, string srcTlbPath, string rootWebServer, string baseUrl, string virtualRoot, string clientActivated, string wellKnown, string discoFile, string operation, out string assemblyName, out string typeName);
+        void DeleteServerTlb(string progId, string classId, string interfaceId, string srcTlbPath, string rootWebServer, string baseUrl, string virtualRoot, string operation, string assemblyName, string typeName);
+    }
+    public interface ISoapServerVRoot {
+        void CreateVirtualRootEx(string rootWebServer, string inBaseUrl, string inVirtualRoot, string homePage, string discoFile, string secureSockets, string authentication, string operation, out string baseUrl, out string virtualRoot, out string physicalPath);
+        void DeleteVirtualRootEx(string rootWebServer, string baseUrl, string virtualRoot);
+        void GetVirtualRootStatus(string rootWebServer, string inBaseUrl, string inVirtualRoot, out string exists, out string secureSockets, out string windowsAuth, out string anonymous, out string homePage, out string discoFile, out string physicalPath, out string baseUrl, out string virtualRoot);
+    }
+    public interface ISoapUtility {
+        void GetServerBinPath(string rootWebServer, string inBaseUrl, string inVirtualRoot, out string binPath);
+        void GetServerPhysicalPath(string rootWebServer, string inBaseUrl, string inVirtualRoot, out string physicalPath);
+        void Present();
+    }
+    public class Publish : IComSoapPublisher {
+        public Publish();
+        public void CreateMailBox(string RootMailServer, string MailBox, out string SmtpName, out string Domain, out string PhysicalPath, out string Error);
+        public void CreateVirtualRoot(string Operation, string FullUrl, out string BaseUrl, out string VirtualRoot, out string PhysicalPath, out string Error);
+        public void DeleteMailBox(string RootMailServer, string MailBox, out string Error);
+        public void DeleteVirtualRoot(string RootWebServer, string FullUrl, out string Error);
+        public void GacInstall(string AssemblyPath);
+        public void GacRemove(string AssemblyPath);
+        public void GetAssemblyNameForCache(string TypeLibPath, out string CachePath);
+        public static string GetClientPhysicalPath(bool CreateDir);
+        public string GetTypeNameFromProgId(string AssemblyPath, string ProgId);
+        public static void ParseUrl(string FullUrl, out string BaseUrl, out string VirtualRoot);
+        public void ProcessClientTlb(string ProgId, string SrcTlbPath, string PhysicalPath, string VRoot, string BaseUrl, string Mode, string Transport, out string AssemblyName, out string TypeName, out string Error);
+        public void ProcessServerTlb(string ProgId, string SrcTlbPath, string PhysicalPath, string Operation, out string strAssemblyName, out string TypeName, out string Error);
+        public void RegisterAssembly(string AssemblyPath);
+        public void UnRegisterAssembly(string AssemblyPath);
+    }
+    public class ServerWebConfig : IServerWebConfig {
+        public ServerWebConfig();
+        public void AddElement(string FilePath, string AssemblyName, string TypeName, string ProgId, string WkoMode, out string Error);
+        public void Create(string FilePath, string FilePrefix, out string Error);
+    }
+    public sealed class SoapClientImport : ISoapClientImport {
+        public SoapClientImport();
+        public void ProcessClientTlbEx(string progId, string virtualRoot, string baseUrl, string authentication, string assemblyName, string typeName);
+    }
+    public sealed class SoapServerTlb : ISoapServerTlb {
+        public SoapServerTlb();
+        public void AddServerTlb(string progId, string classId, string interfaceId, string srcTlbPath, string rootWebServer, string inBaseUrl, string inVirtualRoot, string clientActivated, string wellKnown, string discoFile, string operation, out string strAssemblyName, out string typeName);
+        public void DeleteServerTlb(string progId, string classId, string interfaceId, string srcTlbPath, string rootWebServer, string baseUrl, string virtualRoot, string operation, string assemblyName, string typeName);
+    }
+    public sealed class SoapServerVRoot : ISoapServerVRoot {
+        public SoapServerVRoot();
+        public void CreateVirtualRootEx(string rootWebServer, string inBaseUrl, string inVirtualRoot, string homePage, string discoFile, string secureSockets, string authentication, string operation, out string baseUrl, out string virtualRoot, out string physicalPath);
+        public void DeleteVirtualRootEx(string rootWebServer, string inBaseUrl, string inVirtualRoot);
+        public void GetVirtualRootStatus(string RootWebServer, string inBaseUrl, string inVirtualRoot, out string Exists, out string SSL, out string WindowsAuth, out string Anonymous, out string HomePage, out string DiscoFile, out string PhysicalPath, out string BaseUrl, out string VirtualRoot);
+    }
+    public sealed class SoapUtility : ISoapUtility {
+        public SoapUtility();
+        public void GetServerBinPath(string rootWebServer, string inBaseUrl, string inVirtualRoot, out string binPath);
+        public void GetServerPhysicalPath(string rootWebServer, string inBaseUrl, string inVirtualRoot, out string physicalPath);
+        public void Present();
+    }
+}
```

