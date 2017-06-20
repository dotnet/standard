# System.DirectoryServices.AccountManagement

``` diff
+namespace System.DirectoryServices.AccountManagement {
+    public class AdvancedFilters {
+        protected internal AdvancedFilters(Principal p);
+        public void AccountExpirationDate(DateTime expirationTime, MatchType match);
+        public void AccountLockoutTime(DateTime lockoutTime, MatchType match);
+        protected void AdvancedFilterSet(string attribute, object value, Type objectType, MatchType mt);
+        public void BadLogonCount(int badLogonCount, MatchType match);
+        public void LastBadPasswordAttempt(DateTime lastAttempt, MatchType match);
+        public void LastLogonTime(DateTime logonTime, MatchType match);
+        public void LastPasswordSetTime(DateTime passwordSetTime, MatchType match);
+    }
+    public class AuthenticablePrincipal : Principal {
+        protected internal AuthenticablePrincipal(PrincipalContext context);
+        protected internal AuthenticablePrincipal(PrincipalContext context, string samAccountName, string password, bool enabled);
+        public Nullable<DateTime> AccountExpirationDate { get; set; }
+        public Nullable<DateTime> AccountLockoutTime { get; }
+        public virtual AdvancedFilters AdvancedSearchFilter { get; }
+        public bool AllowReversiblePasswordEncryption { get; set; }
+        public int BadLogonCount { get; }
+        public X509Certificate2Collection Certificates { get; }
+        public bool DelegationPermitted { get; set; }
+        public Nullable<bool> Enabled { get; set; }
+        public string HomeDirectory { get; set; }
+        public string HomeDrive { get; set; }
+        public Nullable<DateTime> LastBadPasswordAttempt { get; }
+        public Nullable<DateTime> LastLogon { get; }
+        public Nullable<DateTime> LastPasswordSet { get; }
+        public bool PasswordNeverExpires { get; set; }
+        public bool PasswordNotRequired { get; set; }
+        public byte[] PermittedLogonTimes { get; set; }
+        public PrincipalValueCollection<string> PermittedWorkstations { get; }
+        public string ScriptPath { get; set; }
+        public bool SmartcardLogonRequired { get; set; }
+        public bool UserCannotChangePassword { get; set; }
+        public void ChangePassword(string oldPassword, string newPassword);
+        public void ExpirePasswordNow();
+        public static PrincipalSearchResult<AuthenticablePrincipal> FindByBadPasswordAttempt(PrincipalContext context, DateTime time, MatchType type);
+        protected static PrincipalSearchResult<T> FindByBadPasswordAttempt<T>(PrincipalContext context, DateTime time, MatchType type);
+        public static PrincipalSearchResult<AuthenticablePrincipal> FindByExpirationTime(PrincipalContext context, DateTime time, MatchType type);
+        protected static PrincipalSearchResult<T> FindByExpirationTime<T>(PrincipalContext context, DateTime time, MatchType type);
+        public static PrincipalSearchResult<AuthenticablePrincipal> FindByLockoutTime(PrincipalContext context, DateTime time, MatchType type);
+        protected static PrincipalSearchResult<T> FindByLockoutTime<T>(PrincipalContext context, DateTime time, MatchType type);
+        public static PrincipalSearchResult<AuthenticablePrincipal> FindByLogonTime(PrincipalContext context, DateTime time, MatchType type);
+        protected static PrincipalSearchResult<T> FindByLogonTime<T>(PrincipalContext context, DateTime time, MatchType type);
+        public static PrincipalSearchResult<AuthenticablePrincipal> FindByPasswordSetTime(PrincipalContext context, DateTime time, MatchType type);
+        protected static PrincipalSearchResult<T> FindByPasswordSetTime<T>(PrincipalContext context, DateTime time, MatchType type);
+        public bool IsAccountLockedOut();
+        public void RefreshExpiredPassword();
+        public void SetPassword(string newPassword);
+        public void UnlockAccount();
+    }
+    public class ComputerPrincipal : AuthenticablePrincipal {
+        public ComputerPrincipal(PrincipalContext context);
+        public ComputerPrincipal(PrincipalContext context, string samAccountName, string password, bool enabled);
+        public PrincipalValueCollection<string> ServicePrincipalNames { get; }
+        public static new PrincipalSearchResult<ComputerPrincipal> FindByBadPasswordAttempt(PrincipalContext context, DateTime time, MatchType type);
+        public static new PrincipalSearchResult<ComputerPrincipal> FindByExpirationTime(PrincipalContext context, DateTime time, MatchType type);
+        public static new ComputerPrincipal FindByIdentity(PrincipalContext context, IdentityType identityType, string identityValue);
+        public static new ComputerPrincipal FindByIdentity(PrincipalContext context, string identityValue);
+        public static new PrincipalSearchResult<ComputerPrincipal> FindByLockoutTime(PrincipalContext context, DateTime time, MatchType type);
+        public static new PrincipalSearchResult<ComputerPrincipal> FindByLogonTime(PrincipalContext context, DateTime time, MatchType type);
+        public static new PrincipalSearchResult<ComputerPrincipal> FindByPasswordSetTime(PrincipalContext context, DateTime time, MatchType type);
+    }
+    public enum ContextOptions {
+        Negotiate = 1,
+        Sealing = 16,
+        SecureSocketLayer = 4,
+        ServerBind = 32,
+        Signing = 8,
+        SimpleBind = 2,
+    }
+    public enum ContextType {
+        ApplicationDirectory = 2,
+        Domain = 1,
+        Machine = 0,
+    }
+    public sealed class DirectoryObjectClassAttribute : Attribute {
+        public DirectoryObjectClassAttribute(string objectClass);
+        public Nullable<ContextType> Context { get; }
+        public string ObjectClass { get; }
+    }
+    public sealed class DirectoryPropertyAttribute : Attribute {
+        public DirectoryPropertyAttribute(string schemaAttributeName);
+        public Nullable<ContextType> Context { get; set; }
+        public string SchemaAttributeName { get; }
+    }
+    public sealed class DirectoryRdnPrefixAttribute : Attribute {
+        public DirectoryRdnPrefixAttribute(string rdnPrefix);
+        public Nullable<ContextType> Context { get; }
+        public string RdnPrefix { get; }
+    }
+    public class GroupPrincipal : Principal {
+        public GroupPrincipal(PrincipalContext context);
+        public GroupPrincipal(PrincipalContext context, string samAccountName);
+        public Nullable<GroupScope> GroupScope { get; set; }
+        public Nullable<bool> IsSecurityGroup { get; set; }
+        public PrincipalCollection Members { get; }
+        public override void Dispose();
+        public static new GroupPrincipal FindByIdentity(PrincipalContext context, IdentityType identityType, string identityValue);
+        public static new GroupPrincipal FindByIdentity(PrincipalContext context, string identityValue);
+        public PrincipalSearchResult<Principal> GetMembers();
+        public PrincipalSearchResult<Principal> GetMembers(bool recursive);
+    }
+    public enum GroupScope {
+        Global = 1,
+        Local = 0,
+        Universal = 2,
+    }
+    public enum IdentityType {
+        DistinguishedName = 3,
+        Guid = 5,
+        Name = 1,
+        SamAccountName = 0,
+        Sid = 4,
+        UserPrincipalName = 2,
+    }
+    public enum MatchType {
+        Equals = 0,
+        GreaterThan = 2,
+        GreaterThanOrEquals = 3,
+        LessThan = 4,
+        LessThanOrEquals = 5,
+        NotEquals = 1,
+    }
+    public class MultipleMatchesException : PrincipalException {
+        public MultipleMatchesException();
+        protected MultipleMatchesException(SerializationInfo info, StreamingContext context);
+        public MultipleMatchesException(string message);
+        public MultipleMatchesException(string message, Exception innerException);
+    }
+    public class NoMatchingPrincipalException : PrincipalException {
+        public NoMatchingPrincipalException();
+        protected NoMatchingPrincipalException(SerializationInfo info, StreamingContext context);
+        public NoMatchingPrincipalException(string message);
+        public NoMatchingPrincipalException(string message, Exception innerException);
+    }
+    public class PasswordException : PrincipalException {
+        public PasswordException();
+        protected PasswordException(SerializationInfo info, StreamingContext context);
+        public PasswordException(string message);
+        public PasswordException(string message, Exception innerException);
+    }
+    public abstract class Principal : IDisposable {
+        protected Principal();
+        public PrincipalContext Context { get; }
+        protected internal PrincipalContext ContextRaw { get; set; }
+        public ContextType ContextType { get; }
+        public string Description { get; set; }
+        public string DisplayName { get; set; }
+        public string DistinguishedName { get; }
+        public Nullable<Guid> Guid { get; }
+        public string Name { get; set; }
+        public string SamAccountName { get; set; }
+        public SecurityIdentifier Sid { get; }
+        public string StructuralObjectClass { get; }
+        public string UserPrincipalName { get; set; }
+        protected void CheckDisposedOrDeleted();
+        public void Delete();
+        public virtual void Dispose();
+        public override bool Equals(object o);
+        protected object[] ExtensionGet(string attribute);
+        protected void ExtensionSet(string attribute, object value);
+        public static Principal FindByIdentity(PrincipalContext context, IdentityType identityType, string identityValue);
+        public static Principal FindByIdentity(PrincipalContext context, string identityValue);
+        protected static Principal FindByIdentityWithType(PrincipalContext context, Type principalType, IdentityType identityType, string identityValue);
+        protected static Principal FindByIdentityWithType(PrincipalContext context, Type principalType, string identityValue);
+        public PrincipalSearchResult<Principal> GetGroups();
+        public PrincipalSearchResult<Principal> GetGroups(PrincipalContext contextToQuery);
+        public override int GetHashCode();
+        public object GetUnderlyingObject();
+        public Type GetUnderlyingObjectType();
+        public bool IsMemberOf(GroupPrincipal group);
+        public bool IsMemberOf(PrincipalContext context, IdentityType identityType, string identityValue);
+        public void Save();
+        public void Save(PrincipalContext context);
+        public override string ToString();
+    }
+    public class PrincipalCollection : ICollection, ICollection<Principal>, IEnumerable, IEnumerable<Principal> {
+        public int Count { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        int System.Collections.ICollection.Count { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        public void Add(ComputerPrincipal computer);
+        public void Add(GroupPrincipal group);
+        public void Add(Principal principal);
+        public void Add(PrincipalContext context, IdentityType identityType, string identityValue);
+        public void Add(UserPrincipal user);
+        public void Clear();
+        public bool Contains(ComputerPrincipal computer);
+        public bool Contains(GroupPrincipal group);
+        public bool Contains(Principal principal);
+        public bool Contains(PrincipalContext context, IdentityType identityType, string identityValue);
+        public bool Contains(UserPrincipal user);
+        public void CopyTo(Principal[] array, int index);
+        public IEnumerator<Principal> GetEnumerator();
+        public bool Remove(ComputerPrincipal computer);
+        public bool Remove(GroupPrincipal group);
+        public bool Remove(Principal principal);
+        public bool Remove(PrincipalContext context, IdentityType identityType, string identityValue);
+        public bool Remove(UserPrincipal user);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+    }
+    public class PrincipalContext : IDisposable {
+        public PrincipalContext(ContextType contextType);
+        public PrincipalContext(ContextType contextType, string name);
+        public PrincipalContext(ContextType contextType, string name, string container);
+        public PrincipalContext(ContextType contextType, string name, string container, ContextOptions options);
+        public PrincipalContext(ContextType contextType, string name, string container, ContextOptions options, string userName, string password);
+        public PrincipalContext(ContextType contextType, string name, string userName, string password);
+        public PrincipalContext(ContextType contextType, string name, string container, string userName, string password);
+        public string ConnectedServer { get; }
+        public string Container { get; }
+        public ContextType ContextType { get; }
+        public string Name { get; }
+        public ContextOptions Options { get; }
+        public string UserName { get; }
+        public void Dispose();
+        public bool ValidateCredentials(string userName, string password);
+        public bool ValidateCredentials(string userName, string password, ContextOptions options);
+    }
+    public abstract class PrincipalException : SystemException
+    public class PrincipalExistsException : PrincipalException {
+        public PrincipalExistsException();
+        protected PrincipalExistsException(SerializationInfo info, StreamingContext context);
+        public PrincipalExistsException(string message);
+        public PrincipalExistsException(string message, Exception innerException);
+    }
+    public class PrincipalOperationException : PrincipalException {
+        public PrincipalOperationException();
+        protected PrincipalOperationException(SerializationInfo info, StreamingContext context);
+        public PrincipalOperationException(string message);
+        public PrincipalOperationException(string message, Exception innerException);
+        public PrincipalOperationException(string message, Exception innerException, int errorCode);
+        public PrincipalOperationException(string message, int errorCode);
+        public int ErrorCode { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class PrincipalSearcher : IDisposable {
+        public PrincipalSearcher();
+        public PrincipalSearcher(Principal queryFilter);
+        public PrincipalContext Context { get; }
+        public Principal QueryFilter { get; set; }
+        public virtual void Dispose();
+        public PrincipalSearchResult<Principal> FindAll();
+        public Principal FindOne();
+        public object GetUnderlyingSearcher();
+        public Type GetUnderlyingSearcherType();
+    }
+    public class PrincipalSearchResult<T> : IDisposable, IEnumerable, IEnumerable<T> {
+        public void Dispose();
+        public IEnumerator<T> GetEnumerator();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+    }
+    public class PrincipalServerDownException : PrincipalException {
+        public PrincipalServerDownException();
+        protected PrincipalServerDownException(SerializationInfo info, StreamingContext context);
+        public PrincipalServerDownException(string message);
+        public PrincipalServerDownException(string message, Exception innerException);
+        public PrincipalServerDownException(string message, Exception innerException, int errorCode);
+        public PrincipalServerDownException(string message, Exception innerException, int errorCode, string serverName);
+        public PrincipalServerDownException(string message, int errorCode);
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class PrincipalValueCollection<T> : ICollection, ICollection<T>, IEnumerable, IEnumerable<T>, IList, IList<T> {
+        public int Count { get; }
+        public bool IsFixedSize { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        int System.Collections.ICollection.Count { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public T this[int index] { get; set; }
+        public void Add(T value);
+        public void Clear();
+        public bool Contains(T value);
+        public void CopyTo(T[] array, int index);
+        public IEnumerator<T> GetEnumerator();
+        public int IndexOf(T value);
+        public void Insert(int index, T value);
+        public bool Remove(T value);
+        public void RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        void System.Collections.IList.Clear();
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        void System.Collections.IList.RemoveAt(int index);
+    }
+    public class UserPrincipal : AuthenticablePrincipal {
+        public UserPrincipal(PrincipalContext context);
+        public UserPrincipal(PrincipalContext context, string samAccountName, string password, bool enabled);
+        public override AdvancedFilters AdvancedSearchFilter { get; }
+        public static UserPrincipal Current { get; }
+        public string EmailAddress { get; set; }
+        public string EmployeeId { get; set; }
+        public string GivenName { get; set; }
+        public string MiddleName { get; set; }
+        public string Surname { get; set; }
+        public string VoiceTelephoneNumber { get; set; }
+        public static new PrincipalSearchResult<UserPrincipal> FindByBadPasswordAttempt(PrincipalContext context, DateTime time, MatchType type);
+        public static new PrincipalSearchResult<UserPrincipal> FindByExpirationTime(PrincipalContext context, DateTime time, MatchType type);
+        public static new UserPrincipal FindByIdentity(PrincipalContext context, IdentityType identityType, string identityValue);
+        public static new UserPrincipal FindByIdentity(PrincipalContext context, string identityValue);
+        public static new PrincipalSearchResult<UserPrincipal> FindByLockoutTime(PrincipalContext context, DateTime time, MatchType type);
+        public static new PrincipalSearchResult<UserPrincipal> FindByLogonTime(PrincipalContext context, DateTime time, MatchType type);
+        public static new PrincipalSearchResult<UserPrincipal> FindByPasswordSetTime(PrincipalContext context, DateTime time, MatchType type);
+        public PrincipalSearchResult<Principal> GetAuthorizationGroups();
+    }
+}
```

