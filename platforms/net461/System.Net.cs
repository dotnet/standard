namespace System.Net
{
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public partial interface INetworkProgress
    {
        event System.EventHandler<System.Net.NetworkProgressChangedEventArgs> ProgressChanged;
        event System.EventHandler<System.Net.NetworkProgressChangedEventArgs> ProgressCompleted;
        event System.EventHandler<System.Net.NetworkProgressChangedEventArgs> ProgressFailed;
    }
    public partial class IPEndPointCollection : System.Collections.ObjectModel.Collection<System.Net.IPEndPoint>
    {
        public IPEndPointCollection() { }
        protected override void InsertItem(int index, System.Net.IPEndPoint item) { }
        protected override void SetItem(int index, System.Net.IPEndPoint item) { }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public partial interface IUnsafeWebRequestCreate
    {
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        System.Net.WebRequest Create(System.Uri uri);
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public partial class NetworkProgressChangedEventArgs : System.ComponentModel.ProgressChangedEventArgs
    {
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public NetworkProgressChangedEventArgs(int percentage, int processedBytes, int totalBytes, object userState) : base (default(int), default(object)) { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public int ProcessedBytes { get { throw null; } }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public int TotalBytes { get { throw null; } }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public static partial class UiSynchronizationContext
    {
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public static System.Threading.SynchronizationContext Current { get { throw null; } set { } }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public static int ManagedUiThreadId { get { throw null; } set { } }
    }
}
namespace System.Net.PeerToPeer
{
    public partial class Cloud : System.IEquatable<System.Net.PeerToPeer.Cloud>, System.Runtime.Serialization.ISerializable
    {
        public static readonly System.Net.PeerToPeer.Cloud AllLinkLocal;
        public static readonly System.Net.PeerToPeer.Cloud Available;
        protected Cloud(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public static System.Net.PeerToPeer.Cloud Global { get { throw null; } }
        public string Name { get { throw null; } }
        public System.Net.PeerToPeer.PnrpScope Scope { get { throw null; } }
        public int ScopeId { get { throw null; } }
        public bool Equals(System.Net.PeerToPeer.Cloud other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public static System.Net.PeerToPeer.CloudCollection GetAvailableClouds() { throw null; }
        public static System.Net.PeerToPeer.Cloud GetCloudByName(string cloudName) { throw null; }
        public override int GetHashCode() { throw null; }
        protected virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public override string ToString() { throw null; }
    }
    public partial class CloudCollection : System.Collections.ObjectModel.Collection<System.Net.PeerToPeer.Cloud>
    {
        public CloudCollection() { }
        protected override void InsertItem(int index, System.Net.PeerToPeer.Cloud item) { }
        protected override void SetItem(int index, System.Net.PeerToPeer.Cloud item) { }
    }
    public partial class PeerName : System.IEquatable<System.Net.PeerToPeer.PeerName>, System.Runtime.Serialization.ISerializable
    {
        protected PeerName(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public PeerName(string remotePeerName) { }
        public PeerName(string classifier, System.Net.PeerToPeer.PeerNameType peerNameType) { }
        public string Authority { get { throw null; } }
        public string Classifier { get { throw null; } }
        public bool IsSecured { get { throw null; } }
        public string PeerHostName { get { throw null; } }
        public static System.Net.PeerToPeer.PeerName CreateFromPeerHostName(string peerHostName) { throw null; }
        public static System.Net.PeerToPeer.PeerName CreateRelativePeerName(System.Net.PeerToPeer.PeerName peerName, string classifier) { throw null; }
        public bool Equals(System.Net.PeerToPeer.PeerName other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        protected virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public override string ToString() { throw null; }
    }
    public partial class PeerNameRecord : System.Runtime.Serialization.ISerializable
    {
        public PeerNameRecord() { }
        protected PeerNameRecord(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public string Comment { get { throw null; } set { } }
        public byte[] Data { get { throw null; } set { } }
        public System.Net.IPEndPointCollection EndPointCollection { get { throw null; } }
        public System.Net.PeerToPeer.PeerName PeerName { get { throw null; } set { } }
        protected virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public partial class PeerNameRecordCollection : System.Collections.ObjectModel.Collection<System.Net.PeerToPeer.PeerNameRecord>
    {
        public PeerNameRecordCollection() { }
        protected override void InsertItem(int index, System.Net.PeerToPeer.PeerNameRecord item) { }
        protected override void SetItem(int index, System.Net.PeerToPeer.PeerNameRecord item) { }
    }
    public partial class PeerNameRegistration : System.IDisposable, System.Runtime.Serialization.ISerializable
    {
        public PeerNameRegistration() { }
        public PeerNameRegistration(System.Net.PeerToPeer.PeerName name, int port) { }
        public PeerNameRegistration(System.Net.PeerToPeer.PeerName name, int port, System.Net.PeerToPeer.Cloud cloud) { }
        protected PeerNameRegistration(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public System.Net.PeerToPeer.Cloud Cloud { get { throw null; } set { } }
        public string Comment { get { throw null; } set { } }
        public byte[] Data { get { throw null; } set { } }
        public System.Net.IPEndPointCollection EndPointCollection { get { throw null; } }
        public System.Net.PeerToPeer.PeerName PeerName { get { throw null; } set { } }
        public int Port { get { throw null; } set { } }
        public bool UseAutoEndPointSelection { get { throw null; } set { } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        protected virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public bool IsRegistered() { throw null; }
        public void Start() { }
        public void Stop() { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public void Update() { }
    }
    public partial class PeerNameResolver
    {
        public PeerNameResolver() { }
        public event System.EventHandler<System.Net.PeerToPeer.ResolveCompletedEventArgs> ResolveCompleted { add { } remove { } }
        public event System.EventHandler<System.Net.PeerToPeer.ResolveProgressChangedEventArgs> ResolveProgressChanged { add { } remove { } }
        protected void OnResolveCompleted(System.Net.PeerToPeer.ResolveCompletedEventArgs e) { }
        protected void OnResolveProgressChanged(System.Net.PeerToPeer.ResolveProgressChangedEventArgs e) { }
        public System.Net.PeerToPeer.PeerNameRecordCollection Resolve(System.Net.PeerToPeer.PeerName peerName) { throw null; }
        public System.Net.PeerToPeer.PeerNameRecordCollection Resolve(System.Net.PeerToPeer.PeerName peerName, int maxRecords) { throw null; }
        public System.Net.PeerToPeer.PeerNameRecordCollection Resolve(System.Net.PeerToPeer.PeerName peerName, System.Net.PeerToPeer.Cloud cloud) { throw null; }
        public System.Net.PeerToPeer.PeerNameRecordCollection Resolve(System.Net.PeerToPeer.PeerName peerName, System.Net.PeerToPeer.Cloud cloud, int maxRecords) { throw null; }
        public void ResolveAsync(System.Net.PeerToPeer.PeerName peerName, int maxRecords, object userState) { }
        public void ResolveAsync(System.Net.PeerToPeer.PeerName peerName, System.Net.PeerToPeer.Cloud cloud, int maxRecords, object userState) { }
        public void ResolveAsync(System.Net.PeerToPeer.PeerName peerName, System.Net.PeerToPeer.Cloud cloud, object userState) { }
        public void ResolveAsync(System.Net.PeerToPeer.PeerName peerName, object userState) { }
        public void ResolveAsyncCancel(object userState) { }
    }
    public enum PeerNameType
    {
        Secured = 0,
        Unsecured = 1,
    }
    public partial class PeerToPeerException : System.Exception, System.Runtime.Serialization.ISerializable
    {
        public PeerToPeerException() { }
        protected PeerToPeerException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public PeerToPeerException(string message) { }
        public PeerToPeerException(string message, System.Exception innerException) { }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public sealed partial class PnrpPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission
    {
        public PnrpPermission(System.Security.Permissions.PermissionState state) { }
        public override System.Security.IPermission Copy() { throw null; }
        public override void FromXml(System.Security.SecurityElement e) { }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { throw null; }
        public override bool IsSubsetOf(System.Security.IPermission target) { throw null; }
        public bool IsUnrestricted() { throw null; }
        public override System.Security.SecurityElement ToXml() { throw null; }
        public override System.Security.IPermission Union(System.Security.IPermission target) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    public sealed partial class PnrpPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public PnrpPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public override System.Security.IPermission CreatePermission() { throw null; }
    }
    public enum PnrpScope
    {
        All = 0,
        Global = 1,
        LinkLocal = 3,
        SiteLocal = 2,
    }
    public partial class ResolveCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        public ResolveCompletedEventArgs(System.Net.PeerToPeer.PeerNameRecordCollection peerNameRecordCollection, System.Exception error, bool canceled, object userToken) { }
        public System.Net.PeerToPeer.PeerNameRecordCollection PeerNameRecordCollection { get { throw null; } }
    }
    public partial class ResolveProgressChangedEventArgs : System.ComponentModel.ProgressChangedEventArgs
    {
        public ResolveProgressChangedEventArgs(System.Net.PeerToPeer.PeerNameRecord peerNameRecord, object userToken) : base (default(int), default(object)) { }
        public System.Net.PeerToPeer.PeerNameRecord PeerNameRecord { get { throw null; } }
    }
}
namespace System.Net.PeerToPeer.Collaboration
{
    public partial class ApplicationChangedEventArgs : System.EventArgs
    {
        internal ApplicationChangedEventArgs() { }
        public System.Net.PeerToPeer.Collaboration.PeerApplication PeerApplication { get { throw null; } }
        public System.Net.PeerToPeer.Collaboration.PeerChangeType PeerChangeType { get { throw null; } }
        public System.Net.PeerToPeer.Collaboration.PeerContact PeerContact { get { throw null; } }
        public System.Net.PeerToPeer.Collaboration.PeerEndPoint PeerEndPoint { get { throw null; } }
    }
    public sealed partial class ContactManager : System.IDisposable
    {
        internal ContactManager() { }
        public static System.Net.PeerToPeer.Collaboration.PeerContact LocalContact { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.DescriptionAttribute("SynchronizingObject")]
        public System.ComponentModel.ISynchronizeInvoke SynchronizingObject { get { throw null; } set { } }
        public event System.EventHandler<System.Net.PeerToPeer.Collaboration.ApplicationChangedEventArgs> ApplicationChanged { add { } remove { } }
        public event System.EventHandler<System.Net.PeerToPeer.Collaboration.CreateContactCompletedEventArgs> CreateContactCompleted { add { } remove { } }
        public event System.EventHandler<System.Net.PeerToPeer.Collaboration.NameChangedEventArgs> NameChanged { add { } remove { } }
        public event System.EventHandler<System.Net.PeerToPeer.Collaboration.ObjectChangedEventArgs> ObjectChanged { add { } remove { } }
        public event System.EventHandler<System.Net.PeerToPeer.Collaboration.PresenceChangedEventArgs> PresenceChanged { add { } remove { } }
        public event System.EventHandler<System.Net.PeerToPeer.Collaboration.SubscriptionListChangedEventArgs> SubscriptionListChanged { add { } remove { } }
        public void AddContact(System.Net.PeerToPeer.Collaboration.PeerContact peerContact) { }
        public System.Net.PeerToPeer.Collaboration.PeerContact CreateContact(System.Net.PeerToPeer.Collaboration.PeerNearMe peerNearMe) { throw null; }
        public void CreateContactAsync(System.Net.PeerToPeer.Collaboration.PeerNearMe peerNearMe, object userToken) { }
        public void DeleteContact(System.Net.PeerToPeer.Collaboration.PeerContact peerContact) { }
        public void DeleteContact(System.Net.PeerToPeer.PeerName peerName) { }
        public void Dispose() { }
        public System.Net.PeerToPeer.Collaboration.PeerContact GetContact(System.Net.PeerToPeer.PeerName peerName) { throw null; }
        public System.Net.PeerToPeer.Collaboration.PeerContactCollection GetContacts() { throw null; }
        public void UpdateContact(System.Net.PeerToPeer.Collaboration.PeerContact peerContact) { }
    }
    public partial class CreateContactCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        internal CreateContactCompletedEventArgs() { }
        public System.Net.PeerToPeer.Collaboration.PeerContact PeerContact { get { throw null; } }
    }
    public partial class InviteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        internal InviteCompletedEventArgs() { }
        public System.Net.PeerToPeer.Collaboration.PeerInvitationResponse InviteResponse { get { throw null; } }
    }
    public partial class NameChangedEventArgs : System.EventArgs
    {
        internal NameChangedEventArgs() { }
        public string Name { get { throw null; } }
        public System.Net.PeerToPeer.Collaboration.PeerContact PeerContact { get { throw null; } }
        public System.Net.PeerToPeer.Collaboration.PeerEndPoint PeerEndPoint { get { throw null; } }
    }
    public partial class ObjectChangedEventArgs : System.EventArgs
    {
        internal ObjectChangedEventArgs() { }
        public System.Net.PeerToPeer.Collaboration.PeerChangeType PeerChangeType { get { throw null; } }
        public System.Net.PeerToPeer.Collaboration.PeerContact PeerContact { get { throw null; } }
        public System.Net.PeerToPeer.Collaboration.PeerEndPoint PeerEndPoint { get { throw null; } }
        public System.Net.PeerToPeer.Collaboration.PeerObject PeerObject { get { throw null; } }
    }
    public abstract partial class Peer : System.IDisposable, System.IEquatable<System.Net.PeerToPeer.Collaboration.Peer>, System.Runtime.Serialization.ISerializable
    {
        protected Peer(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public bool IsOnline { get { throw null; } }
        public virtual System.Net.PeerToPeer.Collaboration.PeerEndPointCollection PeerEndPoints { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.DescriptionAttribute("SynchronizingObject")]
        public System.ComponentModel.ISynchronizeInvoke SynchronizingObject { get { throw null; } set { } }
        public event System.EventHandler<System.Net.PeerToPeer.Collaboration.InviteCompletedEventArgs> InviteCompleted { add { } remove { } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public bool Equals(System.Net.PeerToPeer.Collaboration.Peer other) { throw null; }
        protected virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public System.Net.PeerToPeer.Collaboration.PeerObjectCollection GetObjects() { throw null; }
        public System.Net.PeerToPeer.Collaboration.PeerObjectCollection GetObjects(System.Guid objectId) { throw null; }
        public System.Net.PeerToPeer.Collaboration.PeerPresenceInfo GetPresenceInfo(System.Net.PeerToPeer.Collaboration.PeerEndPoint peerEndPoint) { throw null; }
        public abstract System.Net.PeerToPeer.Collaboration.PeerInvitationResponse Invite();
        public abstract System.Net.PeerToPeer.Collaboration.PeerInvitationResponse Invite(System.Net.PeerToPeer.Collaboration.PeerApplication applicationToInvite, string message, byte[] invitationData);
        public abstract void InviteAsync(System.Net.PeerToPeer.Collaboration.PeerApplication applicationToInvite, string message, byte[] invitationData, object userToken);
        public abstract void InviteAsync(object userToken);
        public void InviteAsyncCancel(object userToken) { }
        protected virtual void OnInviteCompleted(System.Net.PeerToPeer.Collaboration.InviteCompletedEventArgs e) { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public override string ToString() { throw null; }
    }
    public partial class PeerApplication : System.IDisposable, System.IEquatable<System.Net.PeerToPeer.Collaboration.PeerApplication>, System.Runtime.Serialization.ISerializable
    {
        public PeerApplication() { }
        public PeerApplication(System.Guid id, string description, byte[] data, string path, string commandLineArgs, System.Net.PeerToPeer.Collaboration.PeerScope peerScope) { }
        protected PeerApplication(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public string CommandLineArgs { get { throw null; } set { } }
        public byte[] Data { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public System.Guid Id { get { throw null; } set { } }
        public string Path { get { throw null; } set { } }
        public System.Net.PeerToPeer.Collaboration.PeerScope PeerScope { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.DescriptionAttribute("SynchronizingObject")]
        public System.ComponentModel.ISynchronizeInvoke SynchronizingObject { get { throw null; } set { } }
        public event System.EventHandler<System.Net.PeerToPeer.Collaboration.ApplicationChangedEventArgs> ApplicationChanged { add { } remove { } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public bool Equals(System.Net.PeerToPeer.Collaboration.PeerApplication other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public static new bool Equals(object objA, object objB) { throw null; }
        public override int GetHashCode() { throw null; }
        protected virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        protected virtual void OnApplicationChanged(System.Net.PeerToPeer.Collaboration.ApplicationChangedEventArgs appChangedArgs) { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public override string ToString() { throw null; }
    }
    public partial class PeerApplicationCollection : System.Collections.ObjectModel.Collection<System.Net.PeerToPeer.Collaboration.PeerApplication>
    {
        internal PeerApplicationCollection() { }
        protected override void InsertItem(int index, System.Net.PeerToPeer.Collaboration.PeerApplication item) { }
        protected override void SetItem(int index, System.Net.PeerToPeer.Collaboration.PeerApplication item) { }
        public override string ToString() { throw null; }
    }
    public partial class PeerApplicationLaunchInfo
    {
        internal PeerApplicationLaunchInfo() { }
        public byte[] Data { get { throw null; } }
        public string Message { get { throw null; } }
        public System.Net.PeerToPeer.Collaboration.PeerApplication PeerApplication { get { throw null; } }
        public System.Net.PeerToPeer.Collaboration.PeerContact PeerContact { get { throw null; } }
        public System.Net.PeerToPeer.Collaboration.PeerEndPoint PeerEndPoint { get { throw null; } }
    }
    public enum PeerApplicationRegistrationType
    {
        AllUsers = 1,
        CurrentUser = 0,
    }
    public enum PeerChangeType
    {
        Added = 0,
        Deleted = 1,
        Updated = 2,
    }
    public static partial class PeerCollaboration
    {
        public static System.Net.PeerToPeer.Collaboration.PeerApplicationLaunchInfo ApplicationLaunchInfo { get { throw null; } }
        public static System.Net.PeerToPeer.Collaboration.ContactManager ContactManager { get { throw null; } }
        public static string LocalEndPointName { get { throw null; } set { } }
        public static System.Net.PeerToPeer.Collaboration.PeerPresenceInfo LocalPresenceInfo { get { throw null; } set { } }
        public static System.Net.PeerToPeer.Collaboration.PeerScope SignInScope { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.DescriptionAttribute("SynchronizingObject")]
        public static System.ComponentModel.ISynchronizeInvoke SynchronizingObject { get { throw null; } set { } }
        public static event System.EventHandler<System.Net.PeerToPeer.Collaboration.ApplicationChangedEventArgs> LocalApplicationChanged { add { } remove { } }
        public static event System.EventHandler<System.Net.PeerToPeer.Collaboration.NameChangedEventArgs> LocalNameChanged { add { } remove { } }
        public static event System.EventHandler<System.Net.PeerToPeer.Collaboration.ObjectChangedEventArgs> LocalObjectChanged { add { } remove { } }
        public static event System.EventHandler<System.Net.PeerToPeer.Collaboration.PresenceChangedEventArgs> LocalPresenceChanged { add { } remove { } }
        public static void DeleteObject(System.Net.PeerToPeer.Collaboration.PeerObject peerObject) { }
        public static System.Net.PeerToPeer.Collaboration.PeerApplicationCollection GetLocalRegisteredApplications() { throw null; }
        public static System.Net.PeerToPeer.Collaboration.PeerApplicationCollection GetLocalRegisteredApplications(System.Net.PeerToPeer.Collaboration.PeerApplicationRegistrationType type) { throw null; }
        public static System.Net.PeerToPeer.Collaboration.PeerObjectCollection GetLocalSetObjects() { throw null; }
        public static System.Net.PeerToPeer.Collaboration.PeerNearMeCollection GetPeersNearMe() { throw null; }
        public static void RegisterApplication(System.Net.PeerToPeer.Collaboration.PeerApplication application, System.Net.PeerToPeer.Collaboration.PeerApplicationRegistrationType type) { }
        public static void SetObject(System.Net.PeerToPeer.Collaboration.PeerObject peerObject) { }
        public static void SignIn(System.Net.PeerToPeer.Collaboration.PeerScope peerScope) { }
        public static void SignOut(System.Net.PeerToPeer.Collaboration.PeerScope peerScope) { }
        public static void UnregisterApplication(System.Net.PeerToPeer.Collaboration.PeerApplication application, System.Net.PeerToPeer.Collaboration.PeerApplicationRegistrationType type) { }
    }
    public sealed partial class PeerCollaborationPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission
    {
        public PeerCollaborationPermission(System.Security.Permissions.PermissionState state) { }
        public override System.Security.IPermission Copy() { throw null; }
        public override void FromXml(System.Security.SecurityElement e) { }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { throw null; }
        public override bool IsSubsetOf(System.Security.IPermission target) { throw null; }
        public bool IsUnrestricted() { throw null; }
        public override System.Security.SecurityElement ToXml() { throw null; }
        public override System.Security.IPermission Union(System.Security.IPermission target) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    public sealed partial class PeerCollaborationPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public PeerCollaborationPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public override System.Security.IPermission CreatePermission() { throw null; }
    }
    public partial class PeerContact : System.Net.PeerToPeer.Collaboration.Peer, System.IEquatable<System.Net.PeerToPeer.Collaboration.PeerContact>, System.Runtime.Serialization.ISerializable
    {
        protected PeerContact(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) : base (default(System.Runtime.Serialization.SerializationInfo), default(System.Runtime.Serialization.StreamingContext)) { }
        public System.Security.Cryptography.X509Certificates.X509Certificate2 Credentials { get { throw null; } }
        public string DisplayName { get { throw null; } set { } }
        public System.Net.Mail.MailAddress EmailAddress { get { throw null; } set { } }
        public bool IsSubscribed { get { throw null; } }
        public string Nickname { get { throw null; } set { } }
        public override System.Net.PeerToPeer.Collaboration.PeerEndPointCollection PeerEndPoints { get { throw null; } }
        public System.Net.PeerToPeer.PeerName PeerName { get { throw null; } }
        public System.Net.PeerToPeer.Collaboration.SubscriptionType SubscribeAllowed { get { throw null; } set { } }
        public event System.EventHandler<System.Net.PeerToPeer.Collaboration.ApplicationChangedEventArgs> ApplicationChanged { add { } remove { } }
        public event System.EventHandler<System.Net.PeerToPeer.Collaboration.ObjectChangedEventArgs> ObjectChanged { add { } remove { } }
        public event System.EventHandler<System.Net.PeerToPeer.Collaboration.PresenceChangedEventArgs> PresenceChanged { add { } remove { } }
        public event System.EventHandler<System.Net.PeerToPeer.Collaboration.SubscribeCompletedEventArgs> SubscribeCompleted { add { } remove { } }
        protected override void Dispose(bool disposing) { }
        public bool Equals(System.Net.PeerToPeer.Collaboration.PeerContact other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public static new bool Equals(object objA, object objB) { throw null; }
        public static System.Net.PeerToPeer.Collaboration.PeerContact FromXml(string peerContactXml) { throw null; }
        public System.Net.PeerToPeer.Collaboration.PeerApplicationCollection GetApplications() { throw null; }
        public System.Net.PeerToPeer.Collaboration.PeerApplicationCollection GetApplications(System.Guid applicationId) { throw null; }
        public System.Net.PeerToPeer.Collaboration.PeerApplicationCollection GetApplications(System.Net.PeerToPeer.Collaboration.PeerEndPoint peerEndPoint) { throw null; }
        public System.Net.PeerToPeer.Collaboration.PeerApplicationCollection GetApplications(System.Net.PeerToPeer.Collaboration.PeerEndPoint peerEndPoint, System.Guid applicationId) { throw null; }
        public override int GetHashCode() { throw null; }
        protected override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public System.Net.PeerToPeer.Collaboration.PeerObjectCollection GetObjects(System.Net.PeerToPeer.Collaboration.PeerEndPoint peerEndPoint) { throw null; }
        public System.Net.PeerToPeer.Collaboration.PeerObjectCollection GetObjects(System.Net.PeerToPeer.Collaboration.PeerEndPoint peerEndPoint, System.Guid objectId) { throw null; }
        public override System.Net.PeerToPeer.Collaboration.PeerInvitationResponse Invite() { throw null; }
        public override System.Net.PeerToPeer.Collaboration.PeerInvitationResponse Invite(System.Net.PeerToPeer.Collaboration.PeerApplication applicationToInvite, string message, byte[] invitationData) { throw null; }
        public System.Net.PeerToPeer.Collaboration.PeerInvitationResponse Invite(System.Net.PeerToPeer.Collaboration.PeerEndPoint peerEndPoint) { throw null; }
        public System.Net.PeerToPeer.Collaboration.PeerInvitationResponse Invite(System.Net.PeerToPeer.Collaboration.PeerEndPoint peerEndPoint, System.Net.PeerToPeer.Collaboration.PeerApplication applicationToInvite, string message, byte[] invitationData) { throw null; }
        public override void InviteAsync(System.Net.PeerToPeer.Collaboration.PeerApplication applicationToInvite, string message, byte[] invitationData, object userToken) { }
        public void InviteAsync(System.Net.PeerToPeer.Collaboration.PeerEndPoint peerEndPoint, object userToken) { }
        public void InviteAsync(System.Net.PeerToPeer.Collaboration.PeerEndPoint peerEndPoint, string message, byte[] invitationData, System.Net.PeerToPeer.Collaboration.PeerApplication applicationToInvite, object userToken) { }
        public override void InviteAsync(object userToken) { }
        protected virtual void OnApplicationChanged(System.Net.PeerToPeer.Collaboration.ApplicationChangedEventArgs appChangedArgs) { }
        protected virtual void OnObjectChanged(System.Net.PeerToPeer.Collaboration.ObjectChangedEventArgs objChangedArgs) { }
        protected virtual void OnPresenceChanged(System.Net.PeerToPeer.Collaboration.PresenceChangedEventArgs presenceChangedArgs) { }
        protected void OnSubscribeCompleted(System.Net.PeerToPeer.Collaboration.SubscribeCompletedEventArgs e) { }
        public virtual void Subscribe() { }
        public virtual void SubscribeAsync(object userToken) { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public override string ToString() { throw null; }
        public string ToXml() { throw null; }
        public virtual void Unsubscribe() { }
    }
    public partial class PeerContactCollection : System.Collections.ObjectModel.Collection<System.Net.PeerToPeer.Collaboration.PeerContact>
    {
        internal PeerContactCollection() { }
        protected override void InsertItem(int index, System.Net.PeerToPeer.Collaboration.PeerContact item) { }
        protected override void SetItem(int index, System.Net.PeerToPeer.Collaboration.PeerContact item) { }
        public override string ToString() { throw null; }
    }
    public partial class PeerEndPoint : System.IDisposable, System.IEquatable<System.Net.PeerToPeer.Collaboration.PeerEndPoint>, System.Runtime.Serialization.ISerializable
    {
        public PeerEndPoint() { }
        public PeerEndPoint(System.Net.IPEndPoint endPoint) { }
        public PeerEndPoint(System.Net.IPEndPoint endPoint, string endPointName) { }
        protected PeerEndPoint(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public System.Net.IPEndPoint EndPoint { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.DescriptionAttribute("SynchronizingObject")]
        public System.ComponentModel.ISynchronizeInvoke SynchronizingObject { get { throw null; } set { } }
        public event System.EventHandler<System.Net.PeerToPeer.Collaboration.NameChangedEventArgs> NameChanged { add { } remove { } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public bool Equals(System.Net.PeerToPeer.Collaboration.PeerEndPoint other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public static new bool Equals(object objA, object objB) { throw null; }
        public override int GetHashCode() { throw null; }
        protected virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        protected void OnNameChanged(System.Net.PeerToPeer.Collaboration.NameChangedEventArgs nameChangedArgs) { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public override string ToString() { throw null; }
    }
    public partial class PeerEndPointCollection : System.Collections.ObjectModel.Collection<System.Net.PeerToPeer.Collaboration.PeerEndPoint>, System.IEquatable<System.Net.PeerToPeer.Collaboration.PeerEndPointCollection>
    {
        internal PeerEndPointCollection() { }
        public bool Equals(System.Net.PeerToPeer.Collaboration.PeerEndPointCollection other) { throw null; }
        protected override void InsertItem(int index, System.Net.PeerToPeer.Collaboration.PeerEndPoint item) { }
        protected override void SetItem(int index, System.Net.PeerToPeer.Collaboration.PeerEndPoint item) { }
        public override string ToString() { throw null; }
    }
    public partial class PeerInvitationResponse
    {
        internal PeerInvitationResponse() { }
        public System.Net.PeerToPeer.Collaboration.PeerInvitationResponseType PeerInvitationResponseType { get { throw null; } }
    }
    public enum PeerInvitationResponseType
    {
        Accepted = 1,
        Declined = 0,
        Expired = 2,
    }
    public partial class PeerNearMe : System.Net.PeerToPeer.Collaboration.Peer, System.IEquatable<System.Net.PeerToPeer.Collaboration.PeerNearMe>, System.Runtime.Serialization.ISerializable
    {
        public PeerNearMe() : base (default(System.Runtime.Serialization.SerializationInfo), default(System.Runtime.Serialization.StreamingContext)) { }
        protected PeerNearMe(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) : base (default(System.Runtime.Serialization.SerializationInfo), default(System.Runtime.Serialization.StreamingContext)) { }
        public string Nickname { get { throw null; } }
        public static event System.EventHandler<System.Net.PeerToPeer.Collaboration.PeerNearMeChangedEventArgs> PeerNearMeChanged { add { } remove { } }
        public event System.EventHandler<System.Net.PeerToPeer.Collaboration.RefreshDataCompletedEventArgs> RefreshDataCompleted { add { } remove { } }
        public System.Net.PeerToPeer.Collaboration.PeerContact AddToContactManager() { throw null; }
        public System.Net.PeerToPeer.Collaboration.PeerContact AddToContactManager(string displayName, string nickname, System.Net.Mail.MailAddress emailAddress) { throw null; }
        public static System.Net.PeerToPeer.Collaboration.PeerNearMe CreateFromPeerEndPoint(System.Net.PeerToPeer.Collaboration.PeerEndPoint peerEndPoint) { throw null; }
        protected override void Dispose(bool disposing) { }
        public bool Equals(System.Net.PeerToPeer.Collaboration.PeerNearMe other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public static new bool Equals(object objA, object objB) { throw null; }
        public override int GetHashCode() { throw null; }
        protected override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        protected internal void InternalRefreshData(object state) { }
        public override System.Net.PeerToPeer.Collaboration.PeerInvitationResponse Invite() { throw null; }
        public override System.Net.PeerToPeer.Collaboration.PeerInvitationResponse Invite(System.Net.PeerToPeer.Collaboration.PeerApplication applicationToInvite, string message, byte[] invitationData) { throw null; }
        public override void InviteAsync(System.Net.PeerToPeer.Collaboration.PeerApplication applicationToInvite, string message, byte[] invitationData, object userToken) { }
        public override void InviteAsync(object userToken) { }
        protected void OnRefreshDataCompleted(System.Net.PeerToPeer.Collaboration.RefreshDataCompletedEventArgs e) { }
        public void RefreshData() { }
        public void RefreshDataAsync(object userToken) { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public override string ToString() { throw null; }
    }
    public partial class PeerNearMeChangedEventArgs : System.EventArgs
    {
        internal PeerNearMeChangedEventArgs() { }
        public System.Net.PeerToPeer.Collaboration.PeerChangeType PeerChangeType { get { throw null; } }
        public System.Net.PeerToPeer.Collaboration.PeerNearMe PeerNearMe { get { throw null; } }
    }
    public partial class PeerNearMeCollection : System.Collections.ObjectModel.Collection<System.Net.PeerToPeer.Collaboration.PeerNearMe>
    {
        internal PeerNearMeCollection() { }
        protected override void InsertItem(int index, System.Net.PeerToPeer.Collaboration.PeerNearMe item) { }
        protected override void SetItem(int index, System.Net.PeerToPeer.Collaboration.PeerNearMe item) { }
        public override string ToString() { throw null; }
    }
    public partial class PeerObject : System.IDisposable, System.IEquatable<System.Net.PeerToPeer.Collaboration.PeerObject>, System.Runtime.Serialization.ISerializable
    {
        public PeerObject() { }
        public PeerObject(System.Guid Id, byte[] data, System.Net.PeerToPeer.Collaboration.PeerScope peerScope) { }
        protected PeerObject(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public byte[] Data { get { throw null; } set { } }
        public System.Guid Id { get { throw null; } set { } }
        public System.Net.PeerToPeer.Collaboration.PeerScope PeerScope { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.DescriptionAttribute("SynchronizingObject")]
        public System.ComponentModel.ISynchronizeInvoke SynchronizingObject { get { throw null; } set { } }
        public event System.EventHandler<System.Net.PeerToPeer.Collaboration.ObjectChangedEventArgs> ObjectChanged { add { } remove { } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public bool Equals(System.Net.PeerToPeer.Collaboration.PeerObject other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public static new bool Equals(object objA, object objB) { throw null; }
        public override int GetHashCode() { throw null; }
        protected virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        protected virtual void OnObjectChanged(System.Net.PeerToPeer.Collaboration.ObjectChangedEventArgs objChangedArgs) { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public override string ToString() { throw null; }
    }
    public partial class PeerObjectCollection : System.Collections.ObjectModel.Collection<System.Net.PeerToPeer.Collaboration.PeerObject>
    {
        internal PeerObjectCollection() { }
        protected override void InsertItem(int index, System.Net.PeerToPeer.Collaboration.PeerObject item) { }
        protected override void SetItem(int index, System.Net.PeerToPeer.Collaboration.PeerObject item) { }
        public override string ToString() { throw null; }
    }
    public partial class PeerPresenceInfo
    {
        public PeerPresenceInfo() { }
        public PeerPresenceInfo(System.Net.PeerToPeer.Collaboration.PeerPresenceStatus presenceStatus, string description) { }
        public string DescriptiveText { get { throw null; } set { } }
        public System.Net.PeerToPeer.Collaboration.PeerPresenceStatus PresenceStatus { get { throw null; } set { } }
    }
    public enum PeerPresenceStatus
    {
        Away = 2,
        BeRightBack = 3,
        Busy = 5,
        Idle = 4,
        Offline = 0,
        Online = 7,
        OnThePhone = 6,
        OutToLunch = 1,
    }
    public enum PeerScope
    {
        All = 3,
        Internet = 2,
        NearMe = 1,
        None = 0,
    }
    public partial class PresenceChangedEventArgs : System.EventArgs
    {
        internal PresenceChangedEventArgs() { }
        public System.Net.PeerToPeer.Collaboration.PeerChangeType PeerChangeType { get { throw null; } }
        public System.Net.PeerToPeer.Collaboration.PeerContact PeerContact { get { throw null; } }
        public System.Net.PeerToPeer.Collaboration.PeerEndPoint PeerEndPoint { get { throw null; } }
        public System.Net.PeerToPeer.Collaboration.PeerPresenceInfo PeerPresenceInfo { get { throw null; } }
    }
    public partial class RefreshDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        internal RefreshDataCompletedEventArgs() { }
        public System.Net.PeerToPeer.Collaboration.PeerEndPoint PeerEndPoint { get { throw null; } }
    }
    public partial class SubscribeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        internal SubscribeCompletedEventArgs() { }
        public System.Net.PeerToPeer.Collaboration.PeerContact PeerContact { get { throw null; } }
        public System.Net.PeerToPeer.Collaboration.PeerNearMe PeerNearMe { get { throw null; } }
    }
    public partial class SubscriptionListChangedEventArgs : System.EventArgs
    {
        internal SubscriptionListChangedEventArgs() { }
        public System.Net.PeerToPeer.Collaboration.PeerChangeType PeerChangeType { get { throw null; } }
        public System.Net.PeerToPeer.Collaboration.PeerContact PeerContact { get { throw null; } }
        public System.Net.PeerToPeer.Collaboration.PeerEndPoint PeerEndPoint { get { throw null; } }
    }
    public enum SubscriptionType
    {
        Allowed = 1,
        Blocked = 0,
    }
}
namespace System.Net.Sockets
{
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public partial class HttpPolicyDownloaderProtocol
    {
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public HttpPolicyDownloaderProtocol(System.Uri appUri, System.Net.IPAddress address) { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public System.Net.Sockets.SocketPolicy Result { get { throw null; } }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public void Abort() { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public void BeginDownload(System.Net.Sockets.SecurityCriticalAction callback) { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public void DownloadCallback(System.IAsyncResult ar) { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public void ReadCallback(System.IAsyncResult ar) { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public static void RegisterUnsafeWebRequestCreator(System.Net.IUnsafeWebRequestCreate creator) { }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public delegate void SecurityCriticalAction();
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public partial class SocketPolicy
    {
        public SocketPolicy() { }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public partial class UdpAnySourceMulticastClient : System.IDisposable
    {
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public UdpAnySourceMulticastClient(System.Net.IPAddress groupAddress, int localPort) { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public bool MulticastLoopback { get { throw null; } set { } }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public int ReceiveBufferSize { get { throw null; } set { } }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public int SendBufferSize { get { throw null; } set { } }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public System.IAsyncResult BeginJoinGroup(System.AsyncCallback callback, object state) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public System.IAsyncResult BeginReceiveFromGroup(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public System.IAsyncResult BeginSendTo(byte[] buffer, int offset, int count, System.Net.IPEndPoint remoteEndPoint, System.AsyncCallback callback, object state) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public System.IAsyncResult BeginSendToGroup(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public void BlockSource(System.Net.IPAddress sourceAddress) { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public void Dispose() { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public void EndJoinGroup(System.IAsyncResult result) { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public int EndReceiveFromGroup(System.IAsyncResult result, out System.Net.IPEndPoint source) { source = default(System.Net.IPEndPoint); throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public void EndSendTo(System.IAsyncResult result) { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public void EndSendToGroup(System.IAsyncResult result) { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public void UnblockSource(System.Net.IPAddress sourceAddress) { }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
    public partial class UdpSingleSourceMulticastClient : System.IDisposable
    {
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public UdpSingleSourceMulticastClient(System.Net.IPAddress sourceAddress, System.Net.IPAddress groupAddress, int localPort) { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public int ReceiveBufferSize { get { throw null; } set { } }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public int SendBufferSize { get { throw null; } set { } }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public System.IAsyncResult BeginJoinGroup(System.AsyncCallback callback, object state) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public System.IAsyncResult BeginReceiveFromSource(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public System.IAsyncResult BeginSendToSource(byte[] buffer, int offset, int count, int remotePort, System.AsyncCallback callback, object state) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public void Dispose() { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public void EndJoinGroup(System.IAsyncResult result) { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public int EndReceiveFromSource(System.IAsyncResult result, out int sourcePort) { sourcePort = default(int); throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public void EndSendToSource(System.IAsyncResult result) { }
    }
}
