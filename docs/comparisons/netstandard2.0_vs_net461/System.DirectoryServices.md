# System.DirectoryServices

``` diff
+namespace System.DirectoryServices {
+    public class ActiveDirectoryAccessRule : ObjectAccessRule {
+        public ActiveDirectoryAccessRule(IdentityReference identity, ActiveDirectoryRights adRights, AccessControlType type);
+        public ActiveDirectoryAccessRule(IdentityReference identity, ActiveDirectoryRights adRights, AccessControlType type, ActiveDirectorySecurityInheritance inheritanceType);
+        public ActiveDirectoryAccessRule(IdentityReference identity, ActiveDirectoryRights adRights, AccessControlType type, ActiveDirectorySecurityInheritance inheritanceType, Guid inheritedObjectType);
+        public ActiveDirectoryAccessRule(IdentityReference identity, ActiveDirectoryRights adRights, AccessControlType type, Guid objectType);
+        public ActiveDirectoryAccessRule(IdentityReference identity, ActiveDirectoryRights adRights, AccessControlType type, Guid objectType, ActiveDirectorySecurityInheritance inheritanceType);
+        public ActiveDirectoryAccessRule(IdentityReference identity, ActiveDirectoryRights adRights, AccessControlType type, Guid objectType, ActiveDirectorySecurityInheritance inheritanceType, Guid inheritedObjectType);
+        public ActiveDirectoryRights ActiveDirectoryRights { get; }
+        public ActiveDirectorySecurityInheritance InheritanceType { get; }
+    }
+    public class ActiveDirectoryAuditRule : ObjectAuditRule {
+        public ActiveDirectoryAuditRule(IdentityReference identity, ActiveDirectoryRights adRights, AuditFlags auditFlags);
+        public ActiveDirectoryAuditRule(IdentityReference identity, ActiveDirectoryRights adRights, AuditFlags auditFlags, ActiveDirectorySecurityInheritance inheritanceType);
+        public ActiveDirectoryAuditRule(IdentityReference identity, ActiveDirectoryRights adRights, AuditFlags auditFlags, ActiveDirectorySecurityInheritance inheritanceType, Guid inheritedObjectType);
+        public ActiveDirectoryAuditRule(IdentityReference identity, ActiveDirectoryRights adRights, AuditFlags auditFlags, Guid objectType);
+        public ActiveDirectoryAuditRule(IdentityReference identity, ActiveDirectoryRights adRights, AuditFlags auditFlags, Guid objectType, ActiveDirectorySecurityInheritance inheritanceType);
+        public ActiveDirectoryAuditRule(IdentityReference identity, ActiveDirectoryRights adRights, AuditFlags auditFlags, Guid objectType, ActiveDirectorySecurityInheritance inheritanceType, Guid inheritedObjectType);
+        public ActiveDirectoryRights ActiveDirectoryRights { get; }
+        public ActiveDirectorySecurityInheritance InheritanceType { get; }
+    }
+    public enum ActiveDirectoryRights {
+        AccessSystemSecurity = 16777216,
+        CreateChild = 1,
+        Delete = 65536,
+        DeleteChild = 2,
+        DeleteTree = 64,
+        ExtendedRight = 256,
+        GenericAll = 983551,
+        GenericExecute = 131076,
+        GenericRead = 131220,
+        GenericWrite = 131112,
+        ListChildren = 4,
+        ListObject = 128,
+        ReadControl = 131072,
+        ReadProperty = 16,
+        Self = 8,
+        Synchronize = 1048576,
+        WriteDacl = 262144,
+        WriteOwner = 524288,
+        WriteProperty = 32,
+    }
+    public class ActiveDirectorySecurity : DirectoryObjectSecurity {
+        public ActiveDirectorySecurity();
+        public override Type AccessRightType { get; }
+        public override Type AccessRuleType { get; }
+        public override Type AuditRuleType { get; }
+        public sealed override AccessRule AccessRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type);
+        public sealed override AccessRule AccessRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type, Guid objectGuid, Guid inheritedObjectGuid);
+        public void AddAccessRule(ActiveDirectoryAccessRule rule);
+        public void AddAuditRule(ActiveDirectoryAuditRule rule);
+        public sealed override AuditRule AuditRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags);
+        public sealed override AuditRule AuditRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags, Guid objectGuid, Guid inheritedObjectGuid);
+        public override bool ModifyAccessRule(AccessControlModification modification, AccessRule rule, out bool modified);
+        public override bool ModifyAuditRule(AccessControlModification modification, AuditRule rule, out bool modified);
+        public override void PurgeAccessRules(IdentityReference identity);
+        public override void PurgeAuditRules(IdentityReference identity);
+        public void RemoveAccess(IdentityReference identity, AccessControlType type);
+        public bool RemoveAccessRule(ActiveDirectoryAccessRule rule);
+        public void RemoveAccessRuleSpecific(ActiveDirectoryAccessRule rule);
+        public void RemoveAudit(IdentityReference identity);
+        public bool RemoveAuditRule(ActiveDirectoryAuditRule rule);
+        public void RemoveAuditRuleSpecific(ActiveDirectoryAuditRule rule);
+        public void ResetAccessRule(ActiveDirectoryAccessRule rule);
+        public void SetAccessRule(ActiveDirectoryAccessRule rule);
+        public void SetAuditRule(ActiveDirectoryAuditRule rule);
+    }
+    public enum ActiveDirectorySecurityInheritance {
+        All = 1,
+        Children = 4,
+        Descendents = 2,
+        None = 0,
+        SelfAndChildren = 3,
+    }
+    public enum AuthenticationTypes {
+        Anonymous = 16,
+        Delegation = 256,
+        Encryption = 2,
+        FastBind = 32,
+        None = 0,
+        ReadonlyServer = 4,
+        Sealing = 128,
+        Secure = 1,
+        SecureSocketsLayer = 2,
+        ServerBind = 512,
+        Signing = 64,
+    }
+    public sealed class CreateChildAccessRule : ActiveDirectoryAccessRule {
+        public CreateChildAccessRule(IdentityReference identity, AccessControlType type);
+        public CreateChildAccessRule(IdentityReference identity, AccessControlType type, ActiveDirectorySecurityInheritance inheritanceType);
+        public CreateChildAccessRule(IdentityReference identity, AccessControlType type, ActiveDirectorySecurityInheritance inheritanceType, Guid inheritedObjectType);
+        public CreateChildAccessRule(IdentityReference identity, AccessControlType type, Guid childType);
+        public CreateChildAccessRule(IdentityReference identity, AccessControlType type, Guid childType, ActiveDirectorySecurityInheritance inheritanceType);
+        public CreateChildAccessRule(IdentityReference identity, AccessControlType type, Guid childType, ActiveDirectorySecurityInheritance inheritanceType, Guid inheritedObjectType);
+    }
+    public sealed class DeleteChildAccessRule : ActiveDirectoryAccessRule {
+        public DeleteChildAccessRule(IdentityReference identity, AccessControlType type);
+        public DeleteChildAccessRule(IdentityReference identity, AccessControlType type, ActiveDirectorySecurityInheritance inheritanceType);
+        public DeleteChildAccessRule(IdentityReference identity, AccessControlType type, ActiveDirectorySecurityInheritance inheritanceType, Guid inheritedObjectType);
+        public DeleteChildAccessRule(IdentityReference identity, AccessControlType type, Guid childType);
+        public DeleteChildAccessRule(IdentityReference identity, AccessControlType type, Guid childType, ActiveDirectorySecurityInheritance inheritanceType);
+        public DeleteChildAccessRule(IdentityReference identity, AccessControlType type, Guid childType, ActiveDirectorySecurityInheritance inheritanceType, Guid inheritedObjectType);
+    }
+    public sealed class DeleteTreeAccessRule : ActiveDirectoryAccessRule {
+        public DeleteTreeAccessRule(IdentityReference identity, AccessControlType type);
+        public DeleteTreeAccessRule(IdentityReference identity, AccessControlType type, ActiveDirectorySecurityInheritance inheritanceType);
+        public DeleteTreeAccessRule(IdentityReference identity, AccessControlType type, ActiveDirectorySecurityInheritance inheritanceType, Guid inheritedObjectType);
+    }
+    public enum DereferenceAlias {
+        Always = 3,
+        FindingBaseObject = 2,
+        InSearching = 1,
+        Never = 0,
+    }
+    public class DirectoryEntries : IEnumerable {
+        public SchemaNameCollection SchemaFilter { get; }
+        public DirectoryEntry Add(string name, string schemaClassName);
+        public DirectoryEntry Find(string name);
+        public DirectoryEntry Find(string name, string schemaClassName);
+        public IEnumerator GetEnumerator();
+        public void Remove(DirectoryEntry entry);
+    }
+    public class DirectoryEntry : Component {
+        public DirectoryEntry();
+        public DirectoryEntry(object adsObject);
+        public DirectoryEntry(string path);
+        public DirectoryEntry(string path, string username, string password);
+        public DirectoryEntry(string path, string username, string password, AuthenticationTypes authenticationType);
+        public AuthenticationTypes AuthenticationType { get; set; }
+        public DirectoryEntries Children { get; }
+        public Guid Guid { get; }
+        public string Name { get; }
+        public string NativeGuid { get; }
+        public object NativeObject { get; }
+        public ActiveDirectorySecurity ObjectSecurity { get; set; }
+        public DirectoryEntryConfiguration Options { get; }
+        public DirectoryEntry Parent { get; }
+        public string Password { set; }
+        public string Path { get; set; }
+        public PropertyCollection Properties { get; }
+        public string SchemaClassName { get; }
+        public DirectoryEntry SchemaEntry { get; }
+        public bool UsePropertyCache { get; set; }
+        public string Username { get; set; }
+        public void Close();
+        public void CommitChanges();
+        public DirectoryEntry CopyTo(DirectoryEntry newParent);
+        public DirectoryEntry CopyTo(DirectoryEntry newParent, string newName);
+        public void DeleteTree();
+        protected override void Dispose(bool disposing);
+        public static bool Exists(string path);
+        public object Invoke(string methodName, params object[] args);
+        public object InvokeGet(string propertyName);
+        public void InvokeSet(string propertyName, params object[] args);
+        public void MoveTo(DirectoryEntry newParent);
+        public void MoveTo(DirectoryEntry newParent, string newName);
+        public void RefreshCache();
+        public void RefreshCache(string[] propertyNames);
+        public void Rename(string newName);
+    }
+    public class DirectoryEntryConfiguration {
+        public int PageSize { get; set; }
+        public PasswordEncodingMethod PasswordEncoding { get; set; }
+        public int PasswordPort { get; set; }
+        public ReferralChasingOption Referral { get; set; }
+        public SecurityMasks SecurityMasks { get; set; }
+        public string GetCurrentServerName();
+        public bool IsMutuallyAuthenticated();
+        public void SetUserNameQueryQuota(string accountName);
+    }
+    public class DirectorySearcher : Component {
+        public DirectorySearcher();
+        public DirectorySearcher(DirectoryEntry searchRoot);
+        public DirectorySearcher(DirectoryEntry searchRoot, string filter);
+        public DirectorySearcher(DirectoryEntry searchRoot, string filter, string[] propertiesToLoad);
+        public DirectorySearcher(DirectoryEntry searchRoot, string filter, string[] propertiesToLoad, SearchScope scope);
+        public DirectorySearcher(string filter);
+        public DirectorySearcher(string filter, string[] propertiesToLoad);
+        public DirectorySearcher(string filter, string[] propertiesToLoad, SearchScope scope);
+        public bool Asynchronous { get; set; }
+        public string AttributeScopeQuery { get; set; }
+        public bool CacheResults { get; set; }
+        public TimeSpan ClientTimeout { get; set; }
+        public DereferenceAlias DerefAlias { get; set; }
+        public DirectorySynchronization DirectorySynchronization { get; set; }
+        public ExtendedDN ExtendedDN { get; set; }
+        public string Filter { get; set; }
+        public int PageSize { get; set; }
+        public StringCollection PropertiesToLoad { get; }
+        public bool PropertyNamesOnly { get; set; }
+        public ReferralChasingOption ReferralChasing { get; set; }
+        public DirectoryEntry SearchRoot { get; set; }
+        public SearchScope SearchScope { get; set; }
+        public SecurityMasks SecurityMasks { get; set; }
+        public TimeSpan ServerPageTimeLimit { get; set; }
+        public TimeSpan ServerTimeLimit { get; set; }
+        public int SizeLimit { get; set; }
+        public SortOption Sort { get; set; }
+        public bool Tombstone { get; set; }
+        public DirectoryVirtualListView VirtualListView { get; set; }
+        protected override void Dispose(bool disposing);
+        public SearchResultCollection FindAll();
+        public SearchResult FindOne();
+    }
+    public class DirectoryServicesCOMException : COMException, ISerializable {
+        public DirectoryServicesCOMException();
+        protected DirectoryServicesCOMException(SerializationInfo info, StreamingContext context);
+        public DirectoryServicesCOMException(string message);
+        public DirectoryServicesCOMException(string message, Exception inner);
+        public int ExtendedError { get; }
+        public string ExtendedErrorMessage { get; }
+        public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext);
+    }
+    public sealed class DirectoryServicesPermission : ResourcePermissionBase {
+        public DirectoryServicesPermission();
+        public DirectoryServicesPermission(DirectoryServicesPermissionAccess permissionAccess, string path);
+        public DirectoryServicesPermission(DirectoryServicesPermissionEntry[] permissionAccessEntries);
+        public DirectoryServicesPermission(PermissionState state);
+        public DirectoryServicesPermissionEntryCollection PermissionEntries { get; }
+    }
+    public enum DirectoryServicesPermissionAccess {
+        Browse = 2,
+        None = 0,
+        Write = 6,
+    }
+    public class DirectoryServicesPermissionAttribute : CodeAccessSecurityAttribute {
+        public DirectoryServicesPermissionAttribute(SecurityAction action);
+        public string Path { get; set; }
+        public DirectoryServicesPermissionAccess PermissionAccess { get; set; }
+        public override IPermission CreatePermission();
+    }
+    public class DirectoryServicesPermissionEntry {
+        public DirectoryServicesPermissionEntry(DirectoryServicesPermissionAccess permissionAccess, string path);
+        public string Path { get; }
+        public DirectoryServicesPermissionAccess PermissionAccess { get; }
+    }
+    public class DirectoryServicesPermissionEntryCollection : CollectionBase {
+        public DirectoryServicesPermissionEntry this[int index] { get; set; }
+        public int Add(DirectoryServicesPermissionEntry value);
+        public void AddRange(DirectoryServicesPermissionEntryCollection value);
+        public void AddRange(DirectoryServicesPermissionEntry[] value);
+        public bool Contains(DirectoryServicesPermissionEntry value);
+        public void CopyTo(DirectoryServicesPermissionEntry[] array, int index);
+        public int IndexOf(DirectoryServicesPermissionEntry value);
+        public void Insert(int index, DirectoryServicesPermissionEntry value);
+        protected override void OnClear();
+        protected override void OnInsert(int index, object value);
+        protected override void OnRemove(int index, object value);
+        protected override void OnSet(int index, object oldValue, object newValue);
+        public void Remove(DirectoryServicesPermissionEntry value);
+    }
+    public class DirectorySynchronization {
+        public DirectorySynchronization();
+        public DirectorySynchronization(byte[] cookie);
+        public DirectorySynchronization(DirectorySynchronization sync);
+        public DirectorySynchronization(DirectorySynchronizationOptions option);
+        public DirectorySynchronization(DirectorySynchronizationOptions option, byte[] cookie);
+        public DirectorySynchronizationOptions Option { get; set; }
+        public DirectorySynchronization Copy();
+        public byte[] GetDirectorySynchronizationCookie();
+        public void ResetDirectorySynchronizationCookie();
+        public void ResetDirectorySynchronizationCookie(byte[] cookie);
+    }
+    public enum DirectorySynchronizationOptions : long {
+        IncrementalValues = (long)2147483648,
+        None = (long)0,
+        ObjectSecurity = (long)1,
+        ParentsFirst = (long)2048,
+        PublicDataOnly = (long)8192,
+    }
+    public class DirectoryVirtualListView {
+        public DirectoryVirtualListView();
+        public DirectoryVirtualListView(int afterCount);
+        public DirectoryVirtualListView(int beforeCount, int afterCount, int offset);
+        public DirectoryVirtualListView(int beforeCount, int afterCount, int offset, DirectoryVirtualListViewContext context);
+        public DirectoryVirtualListView(int beforeCount, int afterCount, string target);
+        public DirectoryVirtualListView(int beforeCount, int afterCount, string target, DirectoryVirtualListViewContext context);
+        public int AfterCount { get; set; }
+        public int ApproximateTotal { get; set; }
+        public int BeforeCount { get; set; }
+        public DirectoryVirtualListViewContext DirectoryVirtualListViewContext { get; set; }
+        public int Offset { get; set; }
+        public string Target { get; set; }
+        public int TargetPercentage { get; set; }
+    }
+    public class DirectoryVirtualListViewContext {
+        public DirectoryVirtualListViewContext();
+        public DirectoryVirtualListViewContext Copy();
+    }
+    public class DSDescriptionAttribute : DescriptionAttribute {
+        public DSDescriptionAttribute(string description);
+        public override string Description { get; }
+    }
+    public enum ExtendedDN {
+        HexString = 0,
+        None = -1,
+        Standard = 1,
+    }
+    public sealed class ExtendedRightAccessRule : ActiveDirectoryAccessRule {
+        public ExtendedRightAccessRule(IdentityReference identity, AccessControlType type);
+        public ExtendedRightAccessRule(IdentityReference identity, AccessControlType type, ActiveDirectorySecurityInheritance inheritanceType);
+        public ExtendedRightAccessRule(IdentityReference identity, AccessControlType type, ActiveDirectorySecurityInheritance inheritanceType, Guid inheritedObjectType);
+        public ExtendedRightAccessRule(IdentityReference identity, AccessControlType type, Guid extendedRightType);
+        public ExtendedRightAccessRule(IdentityReference identity, AccessControlType type, Guid extendedRightType, ActiveDirectorySecurityInheritance inheritanceType);
+        public ExtendedRightAccessRule(IdentityReference identity, AccessControlType type, Guid extendedRightType, ActiveDirectorySecurityInheritance inheritanceType, Guid inheritedObjectType);
+    }
+    public sealed class ListChildrenAccessRule : ActiveDirectoryAccessRule {
+        public ListChildrenAccessRule(IdentityReference identity, AccessControlType type);
+        public ListChildrenAccessRule(IdentityReference identity, AccessControlType type, ActiveDirectorySecurityInheritance inheritanceType);
+        public ListChildrenAccessRule(IdentityReference identity, AccessControlType type, ActiveDirectorySecurityInheritance inheritanceType, Guid inheritedObjectType);
+    }
+    public enum PasswordEncodingMethod {
+        PasswordEncodingClear = 1,
+        PasswordEncodingSsl = 0,
+    }
+    public enum PropertyAccess {
+        Read = 0,
+        Write = 1,
+    }
+    public sealed class PropertyAccessRule : ActiveDirectoryAccessRule {
+        public PropertyAccessRule(IdentityReference identity, AccessControlType type, PropertyAccess access);
+        public PropertyAccessRule(IdentityReference identity, AccessControlType type, PropertyAccess access, ActiveDirectorySecurityInheritance inheritanceType);
+        public PropertyAccessRule(IdentityReference identity, AccessControlType type, PropertyAccess access, ActiveDirectorySecurityInheritance inheritanceType, Guid inheritedObjectType);
+        public PropertyAccessRule(IdentityReference identity, AccessControlType type, PropertyAccess access, Guid propertyType);
+        public PropertyAccessRule(IdentityReference identity, AccessControlType type, PropertyAccess access, Guid propertyType, ActiveDirectorySecurityInheritance inheritanceType);
+        public PropertyAccessRule(IdentityReference identity, AccessControlType type, PropertyAccess access, Guid propertyType, ActiveDirectorySecurityInheritance inheritanceType, Guid inheritedObjectType);
+    }
+    public class PropertyCollection : ICollection, IDictionary, IEnumerable {
+        public int Count { get; }
+        public ICollection PropertyNames { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IDictionary.IsFixedSize { get; }
+        bool System.Collections.IDictionary.IsReadOnly { get; }
+        object System.Collections.IDictionary.this[object key] { get; set; }
+        ICollection System.Collections.IDictionary.Keys { get; }
+        public PropertyValueCollection this[string propertyName] { get; }
+        public ICollection Values { get; }
+        public bool Contains(string propertyName);
+        public void CopyTo(PropertyValueCollection[] array, int index);
+        public IDictionaryEnumerator GetEnumerator();
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        void System.Collections.IDictionary.Add(object key, object value);
+        void System.Collections.IDictionary.Clear();
+        bool System.Collections.IDictionary.Contains(object value);
+        void System.Collections.IDictionary.Remove(object key);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+    }
+    public sealed class PropertySetAccessRule : ActiveDirectoryAccessRule {
+        public PropertySetAccessRule(IdentityReference identity, AccessControlType type, PropertyAccess access, Guid propertySetType);
+        public PropertySetAccessRule(IdentityReference identity, AccessControlType type, PropertyAccess access, Guid propertySetType, ActiveDirectorySecurityInheritance inheritanceType);
+        public PropertySetAccessRule(IdentityReference identity, AccessControlType type, PropertyAccess access, Guid propertySetType, ActiveDirectorySecurityInheritance inheritanceType, Guid inheritedObjectType);
+    }
+    public class PropertyValueCollection : CollectionBase {
+        public string PropertyName { get; }
+        public object this[int index] { get; set; }
+        public object Value { get; set; }
+        public int Add(object value);
+        public void AddRange(PropertyValueCollection value);
+        public void AddRange(object[] value);
+        public bool Contains(object value);
+        public void CopyTo(object[] array, int index);
+        public int IndexOf(object value);
+        public void Insert(int index, object value);
+        protected override void OnClearComplete();
+        protected override void OnInsertComplete(int index, object value);
+        protected override void OnRemoveComplete(int index, object value);
+        protected override void OnSetComplete(int index, object oldValue, object newValue);
+        public void Remove(object value);
+    }
+    public enum ReferralChasingOption {
+        All = 96,
+        External = 64,
+        None = 0,
+        Subordinate = 32,
+    }
+    public class ResultPropertyCollection : DictionaryBase {
+        public ICollection PropertyNames { get; }
+        public ResultPropertyValueCollection this[string name] { get; }
+        public ICollection Values { get; }
+        public bool Contains(string propertyName);
+        public void CopyTo(ResultPropertyValueCollection[] array, int index);
+    }
+    public class ResultPropertyValueCollection : ReadOnlyCollectionBase {
+        public object this[int index] { get; }
+        public bool Contains(object value);
+        public void CopyTo(object[] values, int index);
+        public int IndexOf(object value);
+    }
+    public class SchemaNameCollection : ICollection, IEnumerable, IList {
+        public int Count { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public string this[int index] { get; set; }
+        public int Add(string value);
+        public void AddRange(SchemaNameCollection value);
+        public void AddRange(string[] value);
+        public void Clear();
+        public bool Contains(string value);
+        public void CopyTo(string[] stringArray, int index);
+        public IEnumerator GetEnumerator();
+        public int IndexOf(string value);
+        public void Insert(int index, string value);
+        public void Remove(string value);
+        public void RemoveAt(int index);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        int System.Collections.IList.Add(object value);
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+    }
+    public class SearchResult {
+        public string Path { get; }
+        public ResultPropertyCollection Properties { get; }
+        public DirectoryEntry GetDirectoryEntry();
+    }
+    public class SearchResultCollection : MarshalByRefObject, ICollection, IDisposable, IEnumerable {
+        public int Count { get; }
+        public IntPtr Handle { get; }
+        public string[] PropertiesLoaded { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        public SearchResult this[int index] { get; }
+        public bool Contains(SearchResult result);
+        public void CopyTo(SearchResult[] results, int index);
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        ~SearchResultCollection();
+        public IEnumerator GetEnumerator();
+        public int IndexOf(SearchResult result);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+    }
+    public enum SearchScope {
+        Base = 0,
+        OneLevel = 1,
+        Subtree = 2,
+    }
+    public enum SecurityMasks {
+        Dacl = 4,
+        Group = 2,
+        None = 0,
+        Owner = 1,
+        Sacl = 8,
+    }
+    public enum SortDirection {
+        Ascending = 0,
+        Descending = 1,
+    }
+    public class SortOption {
+        public SortOption();
+        public SortOption(string propertyName, SortDirection direction);
+        public SortDirection Direction { get; set; }
+        public string PropertyName { get; set; }
+    }
+}
```

