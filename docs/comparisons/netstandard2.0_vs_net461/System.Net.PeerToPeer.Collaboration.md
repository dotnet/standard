# System.Net.PeerToPeer.Collaboration

``` diff
+namespace System.Net.PeerToPeer.Collaboration {
+    public class ApplicationChangedEventArgs : EventArgs {
+        public PeerApplication PeerApplication { get; }
+        public PeerChangeType PeerChangeType { get; }
+        public PeerContact PeerContact { get; }
+        public PeerEndPoint PeerEndPoint { get; }
+    }
+    public sealed class ContactManager : IDisposable {
+        public static PeerContact LocalContact { get; }
+        public ISynchronizeInvoke SynchronizingObject { get; set; }
+        public event EventHandler<ApplicationChangedEventArgs> ApplicationChanged;
+        public event EventHandler<CreateContactCompletedEventArgs> CreateContactCompleted;
+        public event EventHandler<NameChangedEventArgs> NameChanged;
+        public event EventHandler<ObjectChangedEventArgs> ObjectChanged;
+        public event EventHandler<PresenceChangedEventArgs> PresenceChanged;
+        public event EventHandler<SubscriptionListChangedEventArgs> SubscriptionListChanged;
+        public void AddContact(PeerContact peerContact);
+        public PeerContact CreateContact(PeerNearMe peerNearMe);
+        public void CreateContactAsync(PeerNearMe peerNearMe, object userToken);
+        public void DeleteContact(PeerContact peerContact);
+        public void DeleteContact(PeerName peerName);
+        public void Dispose();
+        public PeerContact GetContact(PeerName peerName);
+        public PeerContactCollection GetContacts();
+        public void UpdateContact(PeerContact peerContact);
+    }
+    public class CreateContactCompletedEventArgs : AsyncCompletedEventArgs {
+        public PeerContact PeerContact { get; }
+    }
+    public class InviteCompletedEventArgs : AsyncCompletedEventArgs {
+        public PeerInvitationResponse InviteResponse { get; }
+    }
+    public class NameChangedEventArgs : EventArgs {
+        public string Name { get; }
+        public PeerContact PeerContact { get; }
+        public PeerEndPoint PeerEndPoint { get; }
+    }
+    public class ObjectChangedEventArgs : EventArgs {
+        public PeerChangeType PeerChangeType { get; }
+        public PeerContact PeerContact { get; }
+        public PeerEndPoint PeerEndPoint { get; }
+        public PeerObject PeerObject { get; }
+    }
+    public abstract class Peer : IDisposable, IEquatable<Peer>, ISerializable {
+        protected Peer(SerializationInfo serializationInfo, StreamingContext streamingContext);
+        public bool IsOnline { get; }
+        public virtual PeerEndPointCollection PeerEndPoints { get; }
+        public ISynchronizeInvoke SynchronizingObject { get; set; }
+        public event EventHandler<InviteCompletedEventArgs> InviteCompleted;
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        public bool Equals(Peer other);
+        protected virtual void GetObjectData(SerializationInfo info, StreamingContext context);
+        public PeerObjectCollection GetObjects();
+        public PeerObjectCollection GetObjects(Guid objectId);
+        public PeerPresenceInfo GetPresenceInfo(PeerEndPoint peerEndPoint);
+        public abstract PeerInvitationResponse Invite();
+        public abstract PeerInvitationResponse Invite(PeerApplication applicationToInvite, string message, byte[] invitationData);
+        public abstract void InviteAsync(PeerApplication applicationToInvite, string message, byte[] invitationData, object userToken);
+        public abstract void InviteAsync(object userToken);
+        public void InviteAsyncCancel(object userToken);
+        protected virtual void OnInviteCompleted(InviteCompletedEventArgs e);
+        void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context);
+        public override string ToString();
+    }
+    public class PeerApplication : IDisposable, IEquatable<PeerApplication>, ISerializable {
+        public PeerApplication();
+        public PeerApplication(Guid id, string description, byte[] data, string path, string commandLineArgs, PeerScope peerScope);
+        protected PeerApplication(SerializationInfo serializationInfo, StreamingContext streamingContext);
+        public string CommandLineArgs { get; set; }
+        public byte[] Data { get; set; }
+        public string Description { get; set; }
+        public Guid Id { get; set; }
+        public string Path { get; set; }
+        public PeerScope PeerScope { get; set; }
+        public ISynchronizeInvoke SynchronizingObject { get; set; }
+        public event EventHandler<ApplicationChangedEventArgs> ApplicationChanged;
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        public bool Equals(PeerApplication other);
+        public override bool Equals(object obj);
+        public static new bool Equals(object objA, object objB);
+        public override int GetHashCode();
+        protected virtual void GetObjectData(SerializationInfo info, StreamingContext context);
+        protected virtual void OnApplicationChanged(ApplicationChangedEventArgs appChangedArgs);
+        void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context);
+        public override string ToString();
+    }
+    public class PeerApplicationCollection : Collection<PeerApplication> {
+        protected override void InsertItem(int index, PeerApplication item);
+        protected override void SetItem(int index, PeerApplication item);
+        public override string ToString();
+    }
+    public class PeerApplicationLaunchInfo {
+        public byte[] Data { get; internal set; }
+        public string Message { get; internal set; }
+        public PeerApplication PeerApplication { get; internal set; }
+        public PeerContact PeerContact { get; internal set; }
+        public PeerEndPoint PeerEndPoint { get; internal set; }
+    }
+    public enum PeerApplicationRegistrationType {
+        AllUsers = 1,
+        CurrentUser = 0,
+    }
+    public enum PeerChangeType {
+        Added = 0,
+        Deleted = 1,
+        Updated = 2,
+    }
+    public static class PeerCollaboration {
+        public static PeerApplicationLaunchInfo ApplicationLaunchInfo { get; }
+        public static ContactManager ContactManager { get; }
+        public static string LocalEndPointName { get; set; }
+        public static PeerPresenceInfo LocalPresenceInfo { get; set; }
+        public static PeerScope SignInScope { get; }
+        public static ISynchronizeInvoke SynchronizingObject { get; set; }
+        public static event EventHandler<ApplicationChangedEventArgs> LocalApplicationChanged;
+        public static event EventHandler<NameChangedEventArgs> LocalNameChanged;
+        public static event EventHandler<ObjectChangedEventArgs> LocalObjectChanged;
+        public static event EventHandler<PresenceChangedEventArgs> LocalPresenceChanged;
+        public static void DeleteObject(PeerObject peerObject);
+        public static PeerApplicationCollection GetLocalRegisteredApplications();
+        public static PeerApplicationCollection GetLocalRegisteredApplications(PeerApplicationRegistrationType type);
+        public static PeerObjectCollection GetLocalSetObjects();
+        public static PeerNearMeCollection GetPeersNearMe();
+        public static void RegisterApplication(PeerApplication application, PeerApplicationRegistrationType type);
+        public static void SetObject(PeerObject peerObject);
+        public static void SignIn(PeerScope peerScope);
+        public static void SignOut(PeerScope peerScope);
+        public static void UnregisterApplication(PeerApplication application, PeerApplicationRegistrationType type);
+    }
+    public sealed class PeerCollaborationPermission : CodeAccessPermission, IUnrestrictedPermission {
+        public PeerCollaborationPermission(PermissionState state);
+        public override IPermission Copy();
+        public override void FromXml(SecurityElement e);
+        public override IPermission Intersect(IPermission target);
+        public override bool IsSubsetOf(IPermission target);
+        public bool IsUnrestricted();
+        public override SecurityElement ToXml();
+        public override IPermission Union(IPermission target);
+    }
+    public sealed class PeerCollaborationPermissionAttribute : CodeAccessSecurityAttribute {
+        public PeerCollaborationPermissionAttribute(SecurityAction action);
+        public override IPermission CreatePermission();
+    }
+    public class PeerContact : Peer, IEquatable<PeerContact>, ISerializable {
+        protected PeerContact(SerializationInfo serializationInfo, StreamingContext streamingContext);
+        public X509Certificate2 Credentials { get; internal set; }
+        public string DisplayName { get; set; }
+        public MailAddress EmailAddress { get; set; }
+        public bool IsSubscribed { get; internal set; }
+        public string Nickname { get; set; }
+        public override PeerEndPointCollection PeerEndPoints { get; }
+        public PeerName PeerName { get; internal set; }
+        public SubscriptionType SubscribeAllowed { get; set; }
+        public event EventHandler<ApplicationChangedEventArgs> ApplicationChanged;
+        public event EventHandler<ObjectChangedEventArgs> ObjectChanged;
+        public event EventHandler<PresenceChangedEventArgs> PresenceChanged;
+        public event EventHandler<SubscribeCompletedEventArgs> SubscribeCompleted;
+        protected override void Dispose(bool disposing);
+        public bool Equals(PeerContact other);
+        public override bool Equals(object obj);
+        public static new bool Equals(object objA, object objB);
+        public static PeerContact FromXml(string peerContactXml);
+        public PeerApplicationCollection GetApplications();
+        public PeerApplicationCollection GetApplications(Guid applicationId);
+        public PeerApplicationCollection GetApplications(PeerEndPoint peerEndPoint);
+        public PeerApplicationCollection GetApplications(PeerEndPoint peerEndPoint, Guid applicationId);
+        public override int GetHashCode();
+        protected override void GetObjectData(SerializationInfo info, StreamingContext context);
+        public PeerObjectCollection GetObjects(PeerEndPoint peerEndPoint);
+        public PeerObjectCollection GetObjects(PeerEndPoint peerEndPoint, Guid objectId);
+        public override PeerInvitationResponse Invite();
+        public override PeerInvitationResponse Invite(PeerApplication applicationToInvite, string message, byte[] invitationData);
+        public PeerInvitationResponse Invite(PeerEndPoint peerEndPoint);
+        public PeerInvitationResponse Invite(PeerEndPoint peerEndPoint, PeerApplication applicationToInvite, string message, byte[] invitationData);
+        public override void InviteAsync(PeerApplication applicationToInvite, string message, byte[] invitationData, object userToken);
+        public void InviteAsync(PeerEndPoint peerEndPoint, object userToken);
+        public void InviteAsync(PeerEndPoint peerEndPoint, string message, byte[] invitationData, PeerApplication applicationToInvite, object userToken);
+        public override void InviteAsync(object userToken);
+        protected virtual void OnApplicationChanged(ApplicationChangedEventArgs appChangedArgs);
+        protected virtual void OnObjectChanged(ObjectChangedEventArgs objChangedArgs);
+        protected virtual void OnPresenceChanged(PresenceChangedEventArgs presenceChangedArgs);
+        protected void OnSubscribeCompleted(SubscribeCompletedEventArgs e);
+        public virtual void Subscribe();
+        public virtual void SubscribeAsync(object userToken);
+        void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context);
+        public override string ToString();
+        public string ToXml();
+        public virtual void Unsubscribe();
+    }
+    public class PeerContactCollection : Collection<PeerContact> {
+        protected override void InsertItem(int index, PeerContact item);
+        protected override void SetItem(int index, PeerContact item);
+        public override string ToString();
+    }
+    public class PeerEndPoint : IDisposable, IEquatable<PeerEndPoint>, ISerializable {
+        public PeerEndPoint();
+        public PeerEndPoint(IPEndPoint endPoint);
+        public PeerEndPoint(IPEndPoint endPoint, string endPointName);
+        protected PeerEndPoint(SerializationInfo serializationInfo, StreamingContext streamingContext);
+        public IPEndPoint EndPoint { get; set; }
+        public string Name { get; set; }
+        public ISynchronizeInvoke SynchronizingObject { get; set; }
+        public event EventHandler<NameChangedEventArgs> NameChanged;
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        public bool Equals(PeerEndPoint other);
+        public override bool Equals(object obj);
+        public static new bool Equals(object objA, object objB);
+        public override int GetHashCode();
+        protected virtual void GetObjectData(SerializationInfo info, StreamingContext context);
+        protected void OnNameChanged(NameChangedEventArgs nameChangedArgs);
+        void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context);
+        public override string ToString();
+    }
+    public class PeerEndPointCollection : Collection<PeerEndPoint>, IEquatable<PeerEndPointCollection> {
+        public bool Equals(PeerEndPointCollection other);
+        protected override void InsertItem(int index, PeerEndPoint item);
+        protected override void SetItem(int index, PeerEndPoint item);
+        public override string ToString();
+    }
+    public class PeerInvitationResponse {
+        public PeerInvitationResponseType PeerInvitationResponseType { get; internal set; }
+    }
+    public enum PeerInvitationResponseType {
+        Accepted = 1,
+        Declined = 0,
+        Expired = 2,
+    }
+    public class PeerNearMe : Peer, IEquatable<PeerNearMe>, ISerializable {
+        public PeerNearMe();
+        protected PeerNearMe(SerializationInfo serializationInfo, StreamingContext streamingContext);
+        public string Nickname { get; internal set; }
+        public static event EventHandler<PeerNearMeChangedEventArgs> PeerNearMeChanged;
+        public event EventHandler<RefreshDataCompletedEventArgs> RefreshDataCompleted;
+        public PeerContact AddToContactManager();
+        public PeerContact AddToContactManager(string displayName, string nickname, MailAddress emailAddress);
+        public static PeerNearMe CreateFromPeerEndPoint(PeerEndPoint peerEndPoint);
+        protected override void Dispose(bool disposing);
+        public bool Equals(PeerNearMe other);
+        public override bool Equals(object obj);
+        public static new bool Equals(object objA, object objB);
+        public override int GetHashCode();
+        protected override void GetObjectData(SerializationInfo info, StreamingContext context);
+        protected internal void InternalRefreshData(object state);
+        public override PeerInvitationResponse Invite();
+        public override PeerInvitationResponse Invite(PeerApplication applicationToInvite, string message, byte[] invitationData);
+        public override void InviteAsync(PeerApplication applicationToInvite, string message, byte[] invitationData, object userToken);
+        public override void InviteAsync(object userToken);
+        protected void OnRefreshDataCompleted(RefreshDataCompletedEventArgs e);
+        public void RefreshData();
+        public void RefreshDataAsync(object userToken);
+        void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context);
+        public override string ToString();
+    }
+    public class PeerNearMeChangedEventArgs : EventArgs {
+        public PeerChangeType PeerChangeType { get; }
+        public PeerNearMe PeerNearMe { get; }
+    }
+    public class PeerNearMeCollection : Collection<PeerNearMe> {
+        protected override void InsertItem(int index, PeerNearMe item);
+        protected override void SetItem(int index, PeerNearMe item);
+        public override string ToString();
+    }
+    public class PeerObject : IDisposable, IEquatable<PeerObject>, ISerializable {
+        public PeerObject();
+        public PeerObject(Guid Id, byte[] data, PeerScope peerScope);
+        protected PeerObject(SerializationInfo serializationInfo, StreamingContext streamingContext);
+        public byte[] Data { get; set; }
+        public Guid Id { get; set; }
+        public PeerScope PeerScope { get; set; }
+        public ISynchronizeInvoke SynchronizingObject { get; set; }
+        public event EventHandler<ObjectChangedEventArgs> ObjectChanged;
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        public bool Equals(PeerObject other);
+        public override bool Equals(object obj);
+        public static new bool Equals(object objA, object objB);
+        public override int GetHashCode();
+        protected virtual void GetObjectData(SerializationInfo info, StreamingContext context);
+        protected virtual void OnObjectChanged(ObjectChangedEventArgs objChangedArgs);
+        void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context);
+        public override string ToString();
+    }
+    public class PeerObjectCollection : Collection<PeerObject> {
+        protected override void InsertItem(int index, PeerObject item);
+        protected override void SetItem(int index, PeerObject item);
+        public override string ToString();
+    }
+    public class PeerPresenceInfo {
+        public PeerPresenceInfo();
+        public PeerPresenceInfo(PeerPresenceStatus presenceStatus, string description);
+        public string DescriptiveText { get; set; }
+        public PeerPresenceStatus PresenceStatus { get; set; }
+    }
+    public enum PeerPresenceStatus {
+        Away = 2,
+        BeRightBack = 3,
+        Busy = 5,
+        Idle = 4,
+        Offline = 0,
+        Online = 7,
+        OnThePhone = 6,
+        OutToLunch = 1,
+    }
+    public enum PeerScope {
+        All = 3,
+        Internet = 2,
+        NearMe = 1,
+        None = 0,
+    }
+    public class PresenceChangedEventArgs : EventArgs {
+        public PeerChangeType PeerChangeType { get; }
+        public PeerContact PeerContact { get; }
+        public PeerEndPoint PeerEndPoint { get; }
+        public PeerPresenceInfo PeerPresenceInfo { get; }
+    }
+    public class RefreshDataCompletedEventArgs : AsyncCompletedEventArgs {
+        public PeerEndPoint PeerEndPoint { get; }
+    }
+    public class SubscribeCompletedEventArgs : AsyncCompletedEventArgs {
+        public PeerContact PeerContact { get; }
+        public PeerNearMe PeerNearMe { get; }
+    }
+    public class SubscriptionListChangedEventArgs : EventArgs {
+        public PeerChangeType PeerChangeType { get; }
+        public PeerContact PeerContact { get; }
+        public PeerEndPoint PeerEndPoint { get; }
+    }
+    public enum SubscriptionType {
+        Allowed = 1,
+        Blocked = 0,
+    }
+}
```

