# System.Net

``` diff
 namespace System.Net {
+    public sealed class DnsPermission : CodeAccessPermission, IUnrestrictedPermission {
+        public DnsPermission(PermissionState state);
+        public override IPermission Copy();
+        public override void FromXml(SecurityElement securityElement);
+        public override IPermission Intersect(IPermission target);
+        public override bool IsSubsetOf(IPermission target);
+        public bool IsUnrestricted();
+        public override SecurityElement ToXml();
+        public override IPermission Union(IPermission target);
+    }
+    public sealed class DnsPermissionAttribute : CodeAccessSecurityAttribute {
+        public DnsPermissionAttribute(SecurityAction action);
+        public override IPermission CreatePermission();
+    }
+    public class EndpointPermission {
+        public string Hostname { get; }
+        public int Port { get; }
+        public TransportType Transport { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public override string ToString();
+    }
-    public static class HttpVersion {
+    public class HttpVersion {
+        public HttpVersion();
     }
     public class HttpWebRequest : WebRequest, ISerializable {
+        public HttpWebRequest();
     }
     public class HttpWebResponse : WebResponse, ISerializable {
+        public HttpWebResponse();
     }
+    public interface ICertificatePolicy {
+        bool CheckValidationResult(ServicePoint srvPoint, X509Certificate certificate, WebRequest request, int certificateProblem);
+    }
+    public interface INetworkProgress {
+        event EventHandler<NetworkProgressChangedEventArgs> ProgressChanged;
+        event EventHandler<NetworkProgressChangedEventArgs> ProgressCompleted;
+        event EventHandler<NetworkProgressChangedEventArgs> ProgressFailed;
+    }
+    public class IPEndPointCollection : Collection<IPEndPoint> {
+        public IPEndPointCollection();
+        protected override void InsertItem(int index, IPEndPoint item);
+        protected override void SetItem(int index, IPEndPoint item);
+    }
+    public interface IUnsafeWebRequestCreate {
+        WebRequest Create(Uri uri);
+    }
+    public enum NetworkAccess {
+        Accept = 128,
+        Connect = 64,
+    }
+    public class NetworkProgressChangedEventArgs : ProgressChangedEventArgs {
+        public NetworkProgressChangedEventArgs(int percentage, int processedBytes, int totalBytes, object userState);
+        public int ProcessedBytes { get; }
+        public int TotalBytes { get; }
+    }
     public class ServicePointManager {
+        public static ICertificatePolicy CertificatePolicy { get; set; }
     }
+    public sealed class SocketPermission : CodeAccessPermission, IUnrestrictedPermission {
+        public const int AllPorts = -1;
+        public SocketPermission(NetworkAccess access, TransportType transport, string hostName, int portNumber);
+        public SocketPermission(PermissionState state);
+        public IEnumerator AcceptList { get; }
+        public IEnumerator ConnectList { get; }
+        public void AddPermission(NetworkAccess access, TransportType transport, string hostName, int portNumber);
+        public override IPermission Copy();
+        public override void FromXml(SecurityElement securityElement);
+        public override IPermission Intersect(IPermission target);
+        public override bool IsSubsetOf(IPermission target);
+        public bool IsUnrestricted();
+        public override SecurityElement ToXml();
+        public override IPermission Union(IPermission target);
+    }
+    public sealed class SocketPermissionAttribute : CodeAccessSecurityAttribute {
+        public SocketPermissionAttribute(SecurityAction action);
+        public string Access { get; set; }
+        public string Host { get; set; }
+        public string Port { get; set; }
+        public string Transport { get; set; }
+        public override IPermission CreatePermission();
+    }
     public abstract class TransportContext {
+        public virtual IEnumerable<TokenBinding> GetTlsTokenBindings();
     }
+    public enum TransportType {
+        All = 3,
+        Connectionless = 1,
+        ConnectionOriented = 2,
+        Tcp = 2,
+        Udp = 1,
+    }
+    public static class UiSynchronizationContext {
+        public static SynchronizationContext Current { get; set; }
+        public static int ManagedUiThreadId { get; set; }
+    }
     public class WebClient : Component {
+        public bool AllowReadStreamBuffering { get; set; }
+        public bool AllowWriteStreamBuffering { get; set; }
+        public event WriteStreamClosedEventHandler WriteStreamClosed;
+        protected virtual void OnWriteStreamClosed(WriteStreamClosedEventArgs e);
     }
+    public sealed class WebPermission : CodeAccessPermission, IUnrestrictedPermission {
+        public WebPermission();
+        public WebPermission(NetworkAccess access, string uriString);
+        public WebPermission(NetworkAccess access, Regex uriRegex);
+        public WebPermission(PermissionState state);
+        public IEnumerator AcceptList { get; }
+        public IEnumerator ConnectList { get; }
+        public void AddPermission(NetworkAccess access, string uriString);
+        public void AddPermission(NetworkAccess access, Regex uriRegex);
+        public override IPermission Copy();
+        public override void FromXml(SecurityElement securityElement);
+        public override IPermission Intersect(IPermission target);
+        public override bool IsSubsetOf(IPermission target);
+        public bool IsUnrestricted();
+        public override SecurityElement ToXml();
+        public override IPermission Union(IPermission target);
+    }
+    public sealed class WebPermissionAttribute : CodeAccessSecurityAttribute {
+        public WebPermissionAttribute(SecurityAction action);
+        public string Accept { get; set; }
+        public string AcceptPattern { get; set; }
+        public string Connect { get; set; }
+        public string ConnectPattern { get; set; }
+        public override IPermission CreatePermission();
+    }
     public abstract class WebRequest : MarshalByRefObject, ISerializable {
+        public virtual IWebRequestCreate CreatorInstance { get; }
+        public static void RegisterPortableWebRequestCreator(IWebRequestCreate creator);
     }
+    public class WriteStreamClosedEventArgs : EventArgs {
+        public WriteStreamClosedEventArgs();
+        public Exception Error { get; }
+    }
+    public delegate void WriteStreamClosedEventHandler(object sender, WriteStreamClosedEventArgs e);
 }
```

