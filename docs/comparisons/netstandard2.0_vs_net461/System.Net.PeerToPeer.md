# System.Net.PeerToPeer

``` diff
+namespace System.Net.PeerToPeer {
+    public class Cloud : IEquatable<Cloud>, ISerializable {
+        public static readonly Cloud AllLinkLocal;
+        public static readonly Cloud Available;
+        protected Cloud(SerializationInfo info, StreamingContext context);
+        public static Cloud Global { get; }
+        public string Name { get; }
+        public PnrpScope Scope { get; }
+        public int ScopeId { get; }
+        public bool Equals(Cloud other);
+        public override bool Equals(object obj);
+        public static CloudCollection GetAvailableClouds();
+        public static Cloud GetCloudByName(string cloudName);
+        public override int GetHashCode();
+        protected virtual void GetObjectData(SerializationInfo info, StreamingContext context);
+        void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context);
+        public override string ToString();
+    }
+    public class CloudCollection : Collection<Cloud> {
+        public CloudCollection();
+        protected override void InsertItem(int index, Cloud item);
+        protected override void SetItem(int index, Cloud item);
+    }
+    public class PeerName : IEquatable<PeerName>, ISerializable {
+        protected PeerName(SerializationInfo info, StreamingContext context);
+        public PeerName(string remotePeerName);
+        public PeerName(string classifier, PeerNameType peerNameType);
+        public string Authority { get; }
+        public string Classifier { get; }
+        public bool IsSecured { get; }
+        public string PeerHostName { get; }
+        public static PeerName CreateFromPeerHostName(string peerHostName);
+        public static PeerName CreateRelativePeerName(PeerName peerName, string classifier);
+        public bool Equals(PeerName other);
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        protected virtual void GetObjectData(SerializationInfo info, StreamingContext context);
+        void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context);
+        public override string ToString();
+    }
+    public class PeerNameRecord : ISerializable {
+        public PeerNameRecord();
+        protected PeerNameRecord(SerializationInfo info, StreamingContext context);
+        public string Comment { get; set; }
+        public byte[] Data { get; set; }
+        public IPEndPointCollection EndPointCollection { get; }
+        public PeerName PeerName { get; set; }
+        protected virtual void GetObjectData(SerializationInfo info, StreamingContext context);
+        void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class PeerNameRecordCollection : Collection<PeerNameRecord> {
+        public PeerNameRecordCollection();
+        protected override void InsertItem(int index, PeerNameRecord item);
+        protected override void SetItem(int index, PeerNameRecord item);
+    }
+    public class PeerNameRegistration : IDisposable, ISerializable {
+        public PeerNameRegistration();
+        public PeerNameRegistration(PeerName name, int port);
+        public PeerNameRegistration(PeerName name, int port, Cloud cloud);
+        protected PeerNameRegistration(SerializationInfo info, StreamingContext context);
+        public Cloud Cloud { get; set; }
+        public string Comment { get; set; }
+        public byte[] Data { get; set; }
+        public IPEndPointCollection EndPointCollection { get; }
+        public PeerName PeerName { get; set; }
+        public int Port { get; set; }
+        public bool UseAutoEndPointSelection { get; set; }
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        protected virtual void GetObjectData(SerializationInfo info, StreamingContext context);
+        public bool IsRegistered();
+        public void Start();
+        public void Stop();
+        void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context);
+        public void Update();
+    }
+    public class PeerNameResolver {
+        public PeerNameResolver();
+        public event EventHandler<ResolveCompletedEventArgs> ResolveCompleted;
+        public event EventHandler<ResolveProgressChangedEventArgs> ResolveProgressChanged;
+        protected void OnResolveCompleted(ResolveCompletedEventArgs e);
+        protected void OnResolveProgressChanged(ResolveProgressChangedEventArgs e);
+        public PeerNameRecordCollection Resolve(PeerName peerName);
+        public PeerNameRecordCollection Resolve(PeerName peerName, int maxRecords);
+        public PeerNameRecordCollection Resolve(PeerName peerName, Cloud cloud);
+        public PeerNameRecordCollection Resolve(PeerName peerName, Cloud cloud, int maxRecords);
+        public void ResolveAsync(PeerName peerName, int maxRecords, object userState);
+        public void ResolveAsync(PeerName peerName, Cloud cloud, int maxRecords, object userState);
+        public void ResolveAsync(PeerName peerName, Cloud cloud, object userState);
+        public void ResolveAsync(PeerName peerName, object userState);
+        public void ResolveAsyncCancel(object userState);
+    }
+    public enum PeerNameType {
+        Secured = 0,
+        Unsecured = 1,
+    }
+    public class PeerToPeerException : Exception, ISerializable {
+        public PeerToPeerException();
+        protected PeerToPeerException(SerializationInfo info, StreamingContext context);
+        public PeerToPeerException(string message);
+        public PeerToPeerException(string message, Exception innerException);
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+        void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public sealed class PnrpPermission : CodeAccessPermission, IUnrestrictedPermission {
+        public PnrpPermission(PermissionState state);
+        public override IPermission Copy();
+        public override void FromXml(SecurityElement e);
+        public override IPermission Intersect(IPermission target);
+        public override bool IsSubsetOf(IPermission target);
+        public bool IsUnrestricted();
+        public override SecurityElement ToXml();
+        public override IPermission Union(IPermission target);
+    }
+    public sealed class PnrpPermissionAttribute : CodeAccessSecurityAttribute {
+        public PnrpPermissionAttribute(SecurityAction action);
+        public override IPermission CreatePermission();
+    }
+    public enum PnrpScope {
+        All = 0,
+        Global = 1,
+        LinkLocal = 3,
+        SiteLocal = 2,
+    }
+    public class ResolveCompletedEventArgs : AsyncCompletedEventArgs {
+        public ResolveCompletedEventArgs(PeerNameRecordCollection peerNameRecordCollection, Exception error, bool canceled, object userToken);
+        public PeerNameRecordCollection PeerNameRecordCollection { get; }
+    }
+    public class ResolveProgressChangedEventArgs : ProgressChangedEventArgs {
+        public ResolveProgressChangedEventArgs(PeerNameRecord peerNameRecord, object userToken);
+        public PeerNameRecord PeerNameRecord { get; }
+    }
+}
```

