# System.DirectoryServices.ActiveDirectory

``` diff
+namespace System.DirectoryServices.ActiveDirectory {
+    public class ActiveDirectoryInterSiteTransport : IDisposable {
+        public bool BridgeAllSiteLinks { get; set; }
+        public bool IgnoreReplicationSchedule { get; set; }
+        public ReadOnlySiteLinkBridgeCollection SiteLinkBridges { get; }
+        public ReadOnlySiteLinkCollection SiteLinks { get; }
+        public ActiveDirectoryTransportType TransportType { get; }
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        public static ActiveDirectoryInterSiteTransport FindByTransportType(DirectoryContext context, ActiveDirectoryTransportType transport);
+        public DirectoryEntry GetDirectoryEntry();
+        public void Save();
+        public override string ToString();
+    }
+    public class ActiveDirectoryObjectExistsException : Exception {
+        public ActiveDirectoryObjectExistsException();
+        protected ActiveDirectoryObjectExistsException(SerializationInfo info, StreamingContext context);
+        public ActiveDirectoryObjectExistsException(string message);
+        public ActiveDirectoryObjectExistsException(string message, Exception inner);
+    }
+    public class ActiveDirectoryObjectNotFoundException : Exception, ISerializable {
+        public ActiveDirectoryObjectNotFoundException();
+        protected ActiveDirectoryObjectNotFoundException(SerializationInfo info, StreamingContext context);
+        public ActiveDirectoryObjectNotFoundException(string message);
+        public ActiveDirectoryObjectNotFoundException(string message, Exception inner);
+        public ActiveDirectoryObjectNotFoundException(string message, Type type, string name);
+        public string Name { get; }
+        public Type Type { get; }
+        public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext);
+    }
+    public class ActiveDirectoryOperationException : Exception, ISerializable {
+        public ActiveDirectoryOperationException();
+        protected ActiveDirectoryOperationException(SerializationInfo info, StreamingContext context);
+        public ActiveDirectoryOperationException(string message);
+        public ActiveDirectoryOperationException(string message, Exception inner);
+        public ActiveDirectoryOperationException(string message, Exception inner, int errorCode);
+        public ActiveDirectoryOperationException(string message, int errorCode);
+        public int ErrorCode { get; }
+        public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext);
+    }
+    public abstract class ActiveDirectoryPartition : IDisposable {
+        protected ActiveDirectoryPartition();
+        public string Name { get; }
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        public abstract DirectoryEntry GetDirectoryEntry();
+        public override string ToString();
+    }
+    public class ActiveDirectoryReplicationMetadata : DictionaryBase {
+        public ReadOnlyStringCollection AttributeNames { get; }
+        public AttributeMetadata this[string name] { get; }
+        public AttributeMetadataCollection Values { get; }
+        public bool Contains(string attributeName);
+        public void CopyTo(AttributeMetadata[] array, int index);
+    }
+    public enum ActiveDirectoryRole {
+        InfrastructureRole = 4,
+        NamingRole = 1,
+        PdcRole = 2,
+        RidRole = 3,
+        SchemaRole = 0,
+    }
+    public class ActiveDirectoryRoleCollection : ReadOnlyCollectionBase {
+        public ActiveDirectoryRole this[int index] { get; }
+        public bool Contains(ActiveDirectoryRole role);
+        public void CopyTo(ActiveDirectoryRole[] roles, int index);
+        public int IndexOf(ActiveDirectoryRole role);
+    }
+    public class ActiveDirectorySchedule {
+        public ActiveDirectorySchedule();
+        public ActiveDirectorySchedule(ActiveDirectorySchedule schedule);
+        public bool[,,] RawSchedule { get; set; }
+        public void ResetSchedule();
+        public void SetDailySchedule(HourOfDay fromHour, MinuteOfHour fromMinute, HourOfDay toHour, MinuteOfHour toMinute);
+        public void SetSchedule(DayOfWeek day, HourOfDay fromHour, MinuteOfHour fromMinute, HourOfDay toHour, MinuteOfHour toMinute);
+        public void SetSchedule(DayOfWeek[] days, HourOfDay fromHour, MinuteOfHour fromMinute, HourOfDay toHour, MinuteOfHour toMinute);
+    }
+    public class ActiveDirectorySchema : ActiveDirectoryPartition {
+        public DirectoryServer SchemaRoleOwner { get; }
+        protected override void Dispose(bool disposing);
+        public ReadOnlyActiveDirectorySchemaClassCollection FindAllClasses();
+        public ReadOnlyActiveDirectorySchemaClassCollection FindAllClasses(SchemaClassType type);
+        public ReadOnlyActiveDirectorySchemaClassCollection FindAllDefunctClasses();
+        public ReadOnlyActiveDirectorySchemaPropertyCollection FindAllDefunctProperties();
+        public ReadOnlyActiveDirectorySchemaPropertyCollection FindAllProperties();
+        public ReadOnlyActiveDirectorySchemaPropertyCollection FindAllProperties(PropertyTypes type);
+        public ActiveDirectorySchemaClass FindClass(string ldapDisplayName);
+        public ActiveDirectorySchemaClass FindDefunctClass(string commonName);
+        public ActiveDirectorySchemaProperty FindDefunctProperty(string commonName);
+        public ActiveDirectorySchemaProperty FindProperty(string ldapDisplayName);
+        public static ActiveDirectorySchema GetCurrentSchema();
+        public override DirectoryEntry GetDirectoryEntry();
+        public static ActiveDirectorySchema GetSchema(DirectoryContext context);
+        public void RefreshSchema();
+    }
+    public class ActiveDirectorySchemaClass : IDisposable {
+        public ActiveDirectorySchemaClass(DirectoryContext context, string ldapDisplayName);
+        public ActiveDirectorySchemaClassCollection AuxiliaryClasses { get; }
+        public string CommonName { get; set; }
+        public ActiveDirectorySecurity DefaultObjectSecurityDescriptor { get; set; }
+        public string Description { get; set; }
+        public bool IsDefunct { get; set; }
+        public ActiveDirectorySchemaPropertyCollection MandatoryProperties { get; }
+        public string Name { get; }
+        public string Oid { get; set; }
+        public ActiveDirectorySchemaPropertyCollection OptionalProperties { get; }
+        public ReadOnlyActiveDirectorySchemaClassCollection PossibleInferiors { get; }
+        public ActiveDirectorySchemaClassCollection PossibleSuperiors { get; }
+        public Guid SchemaGuid { get; set; }
+        public ActiveDirectorySchemaClass SubClassOf { get; set; }
+        public SchemaClassType Type { get; set; }
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        public static ActiveDirectorySchemaClass FindByName(DirectoryContext context, string ldapDisplayName);
+        public ReadOnlyActiveDirectorySchemaPropertyCollection GetAllProperties();
+        public DirectoryEntry GetDirectoryEntry();
+        public void Save();
+        public override string ToString();
+    }
+    public class ActiveDirectorySchemaClassCollection : CollectionBase {
+        public ActiveDirectorySchemaClass this[int index] { get; set; }
+        public int Add(ActiveDirectorySchemaClass schemaClass);
+        public void AddRange(ActiveDirectorySchemaClassCollection schemaClasses);
+        public void AddRange(ActiveDirectorySchemaClass[] schemaClasses);
+        public void AddRange(ReadOnlyActiveDirectorySchemaClassCollection schemaClasses);
+        public bool Contains(ActiveDirectorySchemaClass schemaClass);
+        public void CopyTo(ActiveDirectorySchemaClass[] schemaClasses, int index);
+        public int IndexOf(ActiveDirectorySchemaClass schemaClass);
+        public void Insert(int index, ActiveDirectorySchemaClass schemaClass);
+        protected override void OnClearComplete();
+        protected override void OnInsertComplete(int index, object value);
+        protected override void OnRemoveComplete(int index, object value);
+        protected override void OnSetComplete(int index, object oldValue, object newValue);
+        protected override void OnValidate(object value);
+        public void Remove(ActiveDirectorySchemaClass schemaClass);
+    }
+    public class ActiveDirectorySchemaProperty : IDisposable {
+        public ActiveDirectorySchemaProperty(DirectoryContext context, string ldapDisplayName);
+        public string CommonName { get; set; }
+        public string Description { get; set; }
+        public bool IsDefunct { get; set; }
+        public bool IsInAnr { get; set; }
+        public bool IsIndexed { get; set; }
+        public bool IsIndexedOverContainer { get; set; }
+        public bool IsInGlobalCatalog { get; set; }
+        public bool IsOnTombstonedObject { get; set; }
+        public bool IsSingleValued { get; set; }
+        public bool IsTupleIndexed { get; set; }
+        public ActiveDirectorySchemaProperty Link { get; }
+        public Nullable<int> LinkId { get; set; }
+        public string Name { get; }
+        public string Oid { get; set; }
+        public Nullable<int> RangeLower { get; set; }
+        public Nullable<int> RangeUpper { get; set; }
+        public Guid SchemaGuid { get; set; }
+        public ActiveDirectorySyntax Syntax { get; set; }
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        public static ActiveDirectorySchemaProperty FindByName(DirectoryContext context, string ldapDisplayName);
+        public DirectoryEntry GetDirectoryEntry();
+        public void Save();
+        public override string ToString();
+    }
+    public class ActiveDirectorySchemaPropertyCollection : CollectionBase {
+        public ActiveDirectorySchemaProperty this[int index] { get; set; }
+        public int Add(ActiveDirectorySchemaProperty schemaProperty);
+        public void AddRange(ActiveDirectorySchemaPropertyCollection properties);
+        public void AddRange(ActiveDirectorySchemaProperty[] properties);
+        public void AddRange(ReadOnlyActiveDirectorySchemaPropertyCollection properties);
+        public bool Contains(ActiveDirectorySchemaProperty schemaProperty);
+        public void CopyTo(ActiveDirectorySchemaProperty[] properties, int index);
+        public int IndexOf(ActiveDirectorySchemaProperty schemaProperty);
+        public void Insert(int index, ActiveDirectorySchemaProperty schemaProperty);
+        protected override void OnClearComplete();
+        protected override void OnInsertComplete(int index, object value);
+        protected override void OnRemoveComplete(int index, object value);
+        protected override void OnSetComplete(int index, object oldValue, object newValue);
+        protected override void OnValidate(object value);
+        public void Remove(ActiveDirectorySchemaProperty schemaProperty);
+    }
+    public class ActiveDirectoryServerDownException : Exception, ISerializable {
+        public ActiveDirectoryServerDownException();
+        protected ActiveDirectoryServerDownException(SerializationInfo info, StreamingContext context);
+        public ActiveDirectoryServerDownException(string message);
+        public ActiveDirectoryServerDownException(string message, Exception inner);
+        public ActiveDirectoryServerDownException(string message, Exception inner, int errorCode, string name);
+        public ActiveDirectoryServerDownException(string message, int errorCode, string name);
+        public int ErrorCode { get; }
+        public override string Message { get; }
+        public string Name { get; }
+        public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext);
+    }
+    public class ActiveDirectorySite : IDisposable {
+        public ActiveDirectorySite(DirectoryContext context, string siteName);
+        public ReadOnlySiteCollection AdjacentSites { get; }
+        public ReadOnlyDirectoryServerCollection BridgeheadServers { get; }
+        public DomainCollection Domains { get; }
+        public DirectoryServer InterSiteTopologyGenerator { get; set; }
+        public ActiveDirectorySchedule IntraSiteReplicationSchedule { get; set; }
+        public string Location { get; set; }
+        public string Name { get; }
+        public ActiveDirectorySiteOptions Options { get; set; }
+        public DirectoryServerCollection PreferredRpcBridgeheadServers { get; }
+        public DirectoryServerCollection PreferredSmtpBridgeheadServers { get; }
+        public ReadOnlyDirectoryServerCollection Servers { get; }
+        public ReadOnlySiteLinkCollection SiteLinks { get; }
+        public ActiveDirectorySubnetCollection Subnets { get; }
+        public void Delete();
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        public static ActiveDirectorySite FindByName(DirectoryContext context, string siteName);
+        public static ActiveDirectorySite GetComputerSite();
+        public DirectoryEntry GetDirectoryEntry();
+        public void Save();
+        public override string ToString();
+    }
+    public class ActiveDirectorySiteCollection : CollectionBase {
+        public ActiveDirectorySite this[int index] { get; set; }
+        public int Add(ActiveDirectorySite site);
+        public void AddRange(ActiveDirectorySiteCollection sites);
+        public void AddRange(ActiveDirectorySite[] sites);
+        public bool Contains(ActiveDirectorySite site);
+        public void CopyTo(ActiveDirectorySite[] array, int index);
+        public int IndexOf(ActiveDirectorySite site);
+        public void Insert(int index, ActiveDirectorySite site);
+        protected override void OnClearComplete();
+        protected override void OnInsertComplete(int index, object value);
+        protected override void OnRemoveComplete(int index, object value);
+        protected override void OnSetComplete(int index, object oldValue, object newValue);
+        protected override void OnValidate(object value);
+        public void Remove(ActiveDirectorySite site);
+    }
+    public class ActiveDirectorySiteLink : IDisposable {
+        public ActiveDirectorySiteLink(DirectoryContext context, string siteLinkName);
+        public ActiveDirectorySiteLink(DirectoryContext context, string siteLinkName, ActiveDirectoryTransportType transport);
+        public ActiveDirectorySiteLink(DirectoryContext context, string siteLinkName, ActiveDirectoryTransportType transport, ActiveDirectorySchedule schedule);
+        public int Cost { get; set; }
+        public bool DataCompressionEnabled { get; set; }
+        public ActiveDirectorySchedule InterSiteReplicationSchedule { get; set; }
+        public string Name { get; }
+        public bool NotificationEnabled { get; set; }
+        public bool ReciprocalReplicationEnabled { get; set; }
+        public TimeSpan ReplicationInterval { get; set; }
+        public ActiveDirectorySiteCollection Sites { get; }
+        public ActiveDirectoryTransportType TransportType { get; }
+        public void Delete();
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        public static ActiveDirectorySiteLink FindByName(DirectoryContext context, string siteLinkName);
+        public static ActiveDirectorySiteLink FindByName(DirectoryContext context, string siteLinkName, ActiveDirectoryTransportType transport);
+        public DirectoryEntry GetDirectoryEntry();
+        public void Save();
+        public override string ToString();
+    }
+    public class ActiveDirectorySiteLinkBridge : IDisposable {
+        public ActiveDirectorySiteLinkBridge(DirectoryContext context, string bridgeName);
+        public ActiveDirectorySiteLinkBridge(DirectoryContext context, string bridgeName, ActiveDirectoryTransportType transport);
+        public string Name { get; }
+        public ActiveDirectorySiteLinkCollection SiteLinks { get; }
+        public ActiveDirectoryTransportType TransportType { get; }
+        public void Delete();
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        public static ActiveDirectorySiteLinkBridge FindByName(DirectoryContext context, string bridgeName);
+        public static ActiveDirectorySiteLinkBridge FindByName(DirectoryContext context, string bridgeName, ActiveDirectoryTransportType transport);
+        public DirectoryEntry GetDirectoryEntry();
+        public void Save();
+        public override string ToString();
+    }
+    public class ActiveDirectorySiteLinkCollection : CollectionBase {
+        public ActiveDirectorySiteLink this[int index] { get; set; }
+        public int Add(ActiveDirectorySiteLink link);
+        public void AddRange(ActiveDirectorySiteLinkCollection links);
+        public void AddRange(ActiveDirectorySiteLink[] links);
+        public bool Contains(ActiveDirectorySiteLink link);
+        public void CopyTo(ActiveDirectorySiteLink[] array, int index);
+        public int IndexOf(ActiveDirectorySiteLink link);
+        public void Insert(int index, ActiveDirectorySiteLink link);
+        protected override void OnClearComplete();
+        protected override void OnInsertComplete(int index, object value);
+        protected override void OnRemoveComplete(int index, object value);
+        protected override void OnSetComplete(int index, object oldValue, object newValue);
+        protected override void OnValidate(object value);
+        public void Remove(ActiveDirectorySiteLink link);
+    }
+    public enum ActiveDirectorySiteOptions {
+        AutoInterSiteTopologyDisabled = 16,
+        AutoMinimumHopDisabled = 4,
+        AutoTopologyDisabled = 1,
+        ForceKccWindows2003Behavior = 64,
+        GroupMembershipCachingEnabled = 32,
+        None = 0,
+        RandomBridgeHeaderServerSelectionDisabled = 256,
+        RedundantServerTopologyEnabled = 1024,
+        StaleServerDetectDisabled = 8,
+        TopologyCleanupDisabled = 2,
+        UseHashingForReplicationSchedule = 512,
+        UseWindows2000IstgElection = 128,
+    }
+    public class ActiveDirectorySubnet : IDisposable {
+        public ActiveDirectorySubnet(DirectoryContext context, string subnetName);
+        public ActiveDirectorySubnet(DirectoryContext context, string subnetName, string siteName);
+        public string Location { get; set; }
+        public string Name { get; }
+        public ActiveDirectorySite Site { get; set; }
+        public void Delete();
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        public static ActiveDirectorySubnet FindByName(DirectoryContext context, string subnetName);
+        public DirectoryEntry GetDirectoryEntry();
+        public void Save();
+        public override string ToString();
+    }
+    public class ActiveDirectorySubnetCollection : CollectionBase {
+        public ActiveDirectorySubnet this[int index] { get; set; }
+        public int Add(ActiveDirectorySubnet subnet);
+        public void AddRange(ActiveDirectorySubnetCollection subnets);
+        public void AddRange(ActiveDirectorySubnet[] subnets);
+        public bool Contains(ActiveDirectorySubnet subnet);
+        public void CopyTo(ActiveDirectorySubnet[] array, int index);
+        public int IndexOf(ActiveDirectorySubnet subnet);
+        public void Insert(int index, ActiveDirectorySubnet subnet);
+        protected override void OnClear();
+        protected override void OnClearComplete();
+        protected override void OnInsertComplete(int index, object value);
+        protected override void OnRemoveComplete(int index, object value);
+        protected override void OnSetComplete(int index, object oldValue, object newValue);
+        protected override void OnValidate(object value);
+        public void Remove(ActiveDirectorySubnet subnet);
+    }
+    public enum ActiveDirectorySyntax {
+        AccessPointDN = 19,
+        Bool = 8,
+        CaseExactString = 0,
+        CaseIgnoreString = 1,
+        DirectoryString = 3,
+        DN = 12,
+        DNWithBinary = 13,
+        DNWithString = 14,
+        Enumeration = 15,
+        GeneralizedTime = 10,
+        IA5String = 16,
+        Int = 6,
+        Int64 = 7,
+        NumericString = 2,
+        OctetString = 4,
+        Oid = 9,
+        ORName = 20,
+        PresentationAddress = 21,
+        PrintableString = 17,
+        ReplicaLink = 22,
+        SecurityDescriptor = 5,
+        Sid = 18,
+        UtcTime = 11,
+    }
+    public enum ActiveDirectoryTransportType {
+        Rpc = 0,
+        Smtp = 1,
+    }
+    public class AdamInstance : DirectoryServer {
+        public ConfigurationSet ConfigurationSet { get; }
+        public string DefaultPartition { get; set; }
+        public string HostName { get; }
+        public override ReplicationConnectionCollection InboundConnections { get; }
+        public override string IPAddress { get; }
+        public int LdapPort { get; }
+        public override ReplicationConnectionCollection OutboundConnections { get; }
+        public AdamRoleCollection Roles { get; }
+        public override string SiteName { get; }
+        public int SslPort { get; }
+        public override SyncUpdateCallback SyncFromAllServersCallback { get; set; }
+        public override void CheckReplicationConsistency();
+        protected override void Dispose(bool disposing);
+        ~AdamInstance();
+        public static AdamInstanceCollection FindAll(DirectoryContext context, string partitionName);
+        public static AdamInstance FindOne(DirectoryContext context, string partitionName);
+        public static AdamInstance GetAdamInstance(DirectoryContext context);
+        public override ReplicationNeighborCollection GetAllReplicationNeighbors();
+        public override ReplicationFailureCollection GetReplicationConnectionFailures();
+        public override ReplicationCursorCollection GetReplicationCursors(string partition);
+        public override ActiveDirectoryReplicationMetadata GetReplicationMetadata(string objectPath);
+        public override ReplicationNeighborCollection GetReplicationNeighbors(string partition);
+        public override ReplicationOperationInformation GetReplicationOperationInformation();
+        public void Save();
+        public void SeizeRoleOwnership(AdamRole role);
+        public override void SyncReplicaFromAllServers(string partition, SyncFromAllServersOptions options);
+        public override void SyncReplicaFromServer(string partition, string sourceServer);
+        public void TransferRoleOwnership(AdamRole role);
+        public override void TriggerSyncReplicaFromNeighbors(string partition);
+    }
+    public class AdamInstanceCollection : ReadOnlyCollectionBase {
+        public AdamInstance this[int index] { get; }
+        public bool Contains(AdamInstance adamInstance);
+        public void CopyTo(AdamInstance[] adamInstances, int index);
+        public int IndexOf(AdamInstance adamInstance);
+    }
+    public enum AdamRole {
+        NamingRole = 1,
+        SchemaRole = 0,
+    }
+    public class AdamRoleCollection : ReadOnlyCollectionBase {
+        public AdamRole this[int index] { get; }
+        public bool Contains(AdamRole role);
+        public void CopyTo(AdamRole[] roles, int index);
+        public int IndexOf(AdamRole role);
+    }
+    public class ApplicationPartition : ActiveDirectoryPartition {
+        public ApplicationPartition(DirectoryContext context, string distinguishedName);
+        public ApplicationPartition(DirectoryContext context, string distinguishedName, string objectClass);
+        public DirectoryServerCollection DirectoryServers { get; }
+        public string SecurityReferenceDomain { get; set; }
+        public void Delete();
+        protected override void Dispose(bool disposing);
+        public ReadOnlyDirectoryServerCollection FindAllDirectoryServers();
+        public ReadOnlyDirectoryServerCollection FindAllDirectoryServers(string siteName);
+        public ReadOnlyDirectoryServerCollection FindAllDiscoverableDirectoryServers();
+        public ReadOnlyDirectoryServerCollection FindAllDiscoverableDirectoryServers(string siteName);
+        public static ApplicationPartition FindByName(DirectoryContext context, string distinguishedName);
+        public DirectoryServer FindDirectoryServer();
+        public DirectoryServer FindDirectoryServer(bool forceRediscovery);
+        public DirectoryServer FindDirectoryServer(string siteName);
+        public DirectoryServer FindDirectoryServer(string siteName, bool forceRediscovery);
+        public static ApplicationPartition GetApplicationPartition(DirectoryContext context);
+        public override DirectoryEntry GetDirectoryEntry();
+        public void Save();
+    }
+    public class ApplicationPartitionCollection : ReadOnlyCollectionBase {
+        public ApplicationPartition this[int index] { get; }
+        public bool Contains(ApplicationPartition applicationPartition);
+        public void CopyTo(ApplicationPartition[] applicationPartitions, int index);
+        public int IndexOf(ApplicationPartition applicationPartition);
+    }
+    public class AttributeMetadata {
+        public DateTime LastOriginatingChangeTime { get; }
+        public Guid LastOriginatingInvocationId { get; }
+        public long LocalChangeUsn { get; }
+        public string Name { get; }
+        public long OriginatingChangeUsn { get; }
+        public string OriginatingServer { get; }
+        public int Version { get; }
+    }
+    public class AttributeMetadataCollection : ReadOnlyCollectionBase {
+        public AttributeMetadata this[int index] { get; }
+        public bool Contains(AttributeMetadata metadata);
+        public void CopyTo(AttributeMetadata[] metadata, int index);
+        public int IndexOf(AttributeMetadata metadata);
+    }
+    public class ConfigurationSet {
+        public AdamInstanceCollection AdamInstances { get; }
+        public ApplicationPartitionCollection ApplicationPartitions { get; }
+        public string Name { get; }
+        public AdamInstance NamingRoleOwner { get; }
+        public ActiveDirectorySchema Schema { get; }
+        public AdamInstance SchemaRoleOwner { get; }
+        public ReadOnlySiteCollection Sites { get; }
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        public AdamInstance FindAdamInstance();
+        public AdamInstance FindAdamInstance(string partitionName);
+        public AdamInstance FindAdamInstance(string partitionName, string siteName);
+        public AdamInstanceCollection FindAllAdamInstances();
+        public AdamInstanceCollection FindAllAdamInstances(string partitionName);
+        public AdamInstanceCollection FindAllAdamInstances(string partitionName, string siteName);
+        public static ConfigurationSet GetConfigurationSet(DirectoryContext context);
+        public DirectoryEntry GetDirectoryEntry();
+        public ReplicationSecurityLevel GetSecurityLevel();
+        public void SetSecurityLevel(ReplicationSecurityLevel securityLevel);
+        public override string ToString();
+    }
+    public class DirectoryContext {
+        public DirectoryContext(DirectoryContextType contextType);
+        public DirectoryContext(DirectoryContextType contextType, string name);
+        public DirectoryContext(DirectoryContextType contextType, string username, string password);
+        public DirectoryContext(DirectoryContextType contextType, string name, string username, string password);
+        public DirectoryContextType ContextType { get; }
+        public string Name { get; }
+        public string UserName { get; }
+    }
+    public enum DirectoryContextType {
+        ApplicationPartition = 4,
+        ConfigurationSet = 3,
+        DirectoryServer = 2,
+        Domain = 0,
+        Forest = 1,
+    }
+    public abstract class DirectoryServer : IDisposable {
+        protected DirectoryServer();
+        public abstract ReplicationConnectionCollection InboundConnections { get; }
+        public abstract string IPAddress { get; }
+        public string Name { get; }
+        public abstract ReplicationConnectionCollection OutboundConnections { get; }
+        public ReadOnlyStringCollection Partitions { get; }
+        public abstract string SiteName { get; }
+        public abstract SyncUpdateCallback SyncFromAllServersCallback { get; set; }
+        public abstract void CheckReplicationConsistency();
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        ~DirectoryServer();
+        public abstract ReplicationNeighborCollection GetAllReplicationNeighbors();
+        public DirectoryEntry GetDirectoryEntry();
+        public abstract ReplicationFailureCollection GetReplicationConnectionFailures();
+        public abstract ReplicationCursorCollection GetReplicationCursors(string partition);
+        public abstract ActiveDirectoryReplicationMetadata GetReplicationMetadata(string objectPath);
+        public abstract ReplicationNeighborCollection GetReplicationNeighbors(string partition);
+        public abstract ReplicationOperationInformation GetReplicationOperationInformation();
+        public void MoveToAnotherSite(string siteName);
+        public abstract void SyncReplicaFromAllServers(string partition, SyncFromAllServersOptions options);
+        public abstract void SyncReplicaFromServer(string partition, string sourceServer);
+        public override string ToString();
+        public abstract void TriggerSyncReplicaFromNeighbors(string partition);
+    }
+    public class DirectoryServerCollection : CollectionBase {
+        public DirectoryServer this[int index] { get; set; }
+        public int Add(DirectoryServer server);
+        public void AddRange(DirectoryServer[] servers);
+        public bool Contains(DirectoryServer server);
+        public void CopyTo(DirectoryServer[] array, int index);
+        public int IndexOf(DirectoryServer server);
+        public void Insert(int index, DirectoryServer server);
+        protected override void OnClear();
+        protected override void OnClearComplete();
+        protected override void OnInsertComplete(int index, object value);
+        protected override void OnRemoveComplete(int index, object value);
+        protected override void OnSetComplete(int index, object oldValue, object newValue);
+        protected override void OnValidate(object value);
+        public void Remove(DirectoryServer server);
+    }
+    public class Domain : ActiveDirectoryPartition {
+        public DomainCollection Children { get; }
+        public DomainControllerCollection DomainControllers { get; }
+        public DomainMode DomainMode { get; }
+        public int DomainModeLevel { get; }
+        public Forest Forest { get; }
+        public DomainController InfrastructureRoleOwner { get; }
+        public Domain Parent { get; }
+        public DomainController PdcRoleOwner { get; }
+        public DomainController RidRoleOwner { get; }
+        public void CreateLocalSideOfTrustRelationship(string targetDomainName, TrustDirection direction, string trustPassword);
+        public void CreateTrustRelationship(Domain targetDomain, TrustDirection direction);
+        public void DeleteLocalSideOfTrustRelationship(string targetDomainName);
+        public void DeleteTrustRelationship(Domain targetDomain);
+        public DomainControllerCollection FindAllDiscoverableDomainControllers();
+        public DomainControllerCollection FindAllDiscoverableDomainControllers(string siteName);
+        public DomainControllerCollection FindAllDomainControllers();
+        public DomainControllerCollection FindAllDomainControllers(string siteName);
+        public DomainController FindDomainController();
+        public DomainController FindDomainController(LocatorOptions flag);
+        public DomainController FindDomainController(string siteName);
+        public DomainController FindDomainController(string siteName, LocatorOptions flag);
+        public TrustRelationshipInformationCollection GetAllTrustRelationships();
+        public static Domain GetComputerDomain();
+        public static Domain GetCurrentDomain();
+        public override DirectoryEntry GetDirectoryEntry();
+        public static Domain GetDomain(DirectoryContext context);
+        public bool GetSelectiveAuthenticationStatus(string targetDomainName);
+        public bool GetSidFilteringStatus(string targetDomainName);
+        public TrustRelationshipInformation GetTrustRelationship(string targetDomainName);
+        public void RaiseDomainFunctionality(DomainMode domainMode);
+        public void RaiseDomainFunctionalityLevel(int domainMode);
+        public void RepairTrustRelationship(Domain targetDomain);
+        public void SetSelectiveAuthenticationStatus(string targetDomainName, bool enable);
+        public void SetSidFilteringStatus(string targetDomainName, bool enable);
+        public void UpdateLocalSideOfTrustRelationship(string targetDomainName, TrustDirection newTrustDirection, string newTrustPassword);
+        public void UpdateLocalSideOfTrustRelationship(string targetDomainName, string newTrustPassword);
+        public void UpdateTrustRelationship(Domain targetDomain, TrustDirection newTrustDirection);
+        public void VerifyOutboundTrustRelationship(string targetDomainName);
+        public void VerifyTrustRelationship(Domain targetDomain, TrustDirection direction);
+    }
+    public class DomainCollection : ReadOnlyCollectionBase {
+        public Domain this[int index] { get; }
+        public bool Contains(Domain domain);
+        public void CopyTo(Domain[] domains, int index);
+        public int IndexOf(Domain domain);
+    }
+    public enum DomainCollisionOptions {
+        NetBiosNameDisabledByAdmin = 4,
+        NetBiosNameDisabledByConflict = 8,
+        None = 0,
+        SidDisabledByAdmin = 1,
+        SidDisabledByConflict = 2,
+    }
+    public class DomainController : DirectoryServer {
+        protected DomainController();
+        public DateTime CurrentTime { get; }
+        public Domain Domain { get; }
+        public Forest Forest { get; }
+        public long HighestCommittedUsn { get; }
+        public override ReplicationConnectionCollection InboundConnections { get; }
+        public override string IPAddress { get; }
+        public string OSVersion { get; }
+        public override ReplicationConnectionCollection OutboundConnections { get; }
+        public ActiveDirectoryRoleCollection Roles { get; }
+        public override string SiteName { get; }
+        public override SyncUpdateCallback SyncFromAllServersCallback { get; set; }
+        public override void CheckReplicationConsistency();
+        protected override void Dispose(bool disposing);
+        public virtual GlobalCatalog EnableGlobalCatalog();
+        ~DomainController();
+        public static DomainControllerCollection FindAll(DirectoryContext context);
+        public static DomainControllerCollection FindAll(DirectoryContext context, string siteName);
+        public static DomainController FindOne(DirectoryContext context);
+        public static DomainController FindOne(DirectoryContext context, LocatorOptions flag);
+        public static DomainController FindOne(DirectoryContext context, string siteName);
+        public static DomainController FindOne(DirectoryContext context, string siteName, LocatorOptions flag);
+        public override ReplicationNeighborCollection GetAllReplicationNeighbors();
+        public virtual DirectorySearcher GetDirectorySearcher();
+        public static DomainController GetDomainController(DirectoryContext context);
+        public override ReplicationFailureCollection GetReplicationConnectionFailures();
+        public override ReplicationCursorCollection GetReplicationCursors(string partition);
+        public override ActiveDirectoryReplicationMetadata GetReplicationMetadata(string objectPath);
+        public override ReplicationNeighborCollection GetReplicationNeighbors(string partition);
+        public override ReplicationOperationInformation GetReplicationOperationInformation();
+        public virtual bool IsGlobalCatalog();
+        public void SeizeRoleOwnership(ActiveDirectoryRole role);
+        public override void SyncReplicaFromAllServers(string partition, SyncFromAllServersOptions options);
+        public override void SyncReplicaFromServer(string partition, string sourceServer);
+        public void TransferRoleOwnership(ActiveDirectoryRole role);
+        public override void TriggerSyncReplicaFromNeighbors(string partition);
+    }
+    public class DomainControllerCollection : ReadOnlyCollectionBase {
+        public DomainController this[int index] { get; }
+        public bool Contains(DomainController domainController);
+        public void CopyTo(DomainController[] domainControllers, int index);
+        public int IndexOf(DomainController domainController);
+    }
+    public enum DomainMode {
+        Unknown = -1,
+        Windows2000MixedDomain = 0,
+        Windows2000NativeDomain = 1,
+        Windows2003Domain = 3,
+        Windows2003InterimDomain = 2,
+        Windows2008Domain = 4,
+        Windows2008R2Domain = 5,
+        Windows2012R2Domain = 7,
+        Windows8Domain = 6,
+    }
+    public class Forest : IDisposable {
+        public ApplicationPartitionCollection ApplicationPartitions { get; }
+        public DomainCollection Domains { get; }
+        public ForestMode ForestMode { get; }
+        public int ForestModeLevel { get; }
+        public GlobalCatalogCollection GlobalCatalogs { get; }
+        public string Name { get; }
+        public DomainController NamingRoleOwner { get; }
+        public Domain RootDomain { get; }
+        public ActiveDirectorySchema Schema { get; }
+        public DomainController SchemaRoleOwner { get; }
+        public ReadOnlySiteCollection Sites { get; }
+        public void CreateLocalSideOfTrustRelationship(string targetForestName, TrustDirection direction, string trustPassword);
+        public void CreateTrustRelationship(Forest targetForest, TrustDirection direction);
+        public void DeleteLocalSideOfTrustRelationship(string targetForestName);
+        public void DeleteTrustRelationship(Forest targetForest);
+        public void Dispose();
+        protected void Dispose(bool disposing);
+        public GlobalCatalogCollection FindAllDiscoverableGlobalCatalogs();
+        public GlobalCatalogCollection FindAllDiscoverableGlobalCatalogs(string siteName);
+        public GlobalCatalogCollection FindAllGlobalCatalogs();
+        public GlobalCatalogCollection FindAllGlobalCatalogs(string siteName);
+        public GlobalCatalog FindGlobalCatalog();
+        public GlobalCatalog FindGlobalCatalog(LocatorOptions flag);
+        public GlobalCatalog FindGlobalCatalog(string siteName);
+        public GlobalCatalog FindGlobalCatalog(string siteName, LocatorOptions flag);
+        public TrustRelationshipInformationCollection GetAllTrustRelationships();
+        public static Forest GetCurrentForest();
+        public static Forest GetForest(DirectoryContext context);
+        public bool GetSelectiveAuthenticationStatus(string targetForestName);
+        public bool GetSidFilteringStatus(string targetForestName);
+        public ForestTrustRelationshipInformation GetTrustRelationship(string targetForestName);
+        public void RaiseForestFunctionality(ForestMode forestMode);
+        public void RaiseForestFunctionalityLevel(int forestMode);
+        public void RepairTrustRelationship(Forest targetForest);
+        public void SetSelectiveAuthenticationStatus(string targetForestName, bool enable);
+        public void SetSidFilteringStatus(string targetForestName, bool enable);
+        public override string ToString();
+        public void UpdateLocalSideOfTrustRelationship(string targetForestName, TrustDirection newTrustDirection, string newTrustPassword);
+        public void UpdateLocalSideOfTrustRelationship(string targetForestName, string newTrustPassword);
+        public void UpdateTrustRelationship(Forest targetForest, TrustDirection newTrustDirection);
+        public void VerifyOutboundTrustRelationship(string targetForestName);
+        public void VerifyTrustRelationship(Forest targetForest, TrustDirection direction);
+    }
+    public enum ForestMode {
+        Unknown = -1,
+        Windows2000Forest = 0,
+        Windows2003Forest = 2,
+        Windows2003InterimForest = 1,
+        Windows2008Forest = 3,
+        Windows2008R2Forest = 4,
+        Windows2012R2Forest = 6,
+        Windows8Forest = 5,
+    }
+    public class ForestTrustCollisionException : ActiveDirectoryOperationException, ISerializable {
+        public ForestTrustCollisionException();
+        protected ForestTrustCollisionException(SerializationInfo info, StreamingContext context);
+        public ForestTrustCollisionException(string message);
+        public ForestTrustCollisionException(string message, Exception inner);
+        public ForestTrustCollisionException(string message, Exception inner, ForestTrustRelationshipCollisionCollection collisions);
+        public ForestTrustRelationshipCollisionCollection Collisions { get; }
+        public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext);
+    }
+    public enum ForestTrustCollisionType {
+        Domain = 1,
+        Other = 2,
+        TopLevelName = 0,
+    }
+    public class ForestTrustDomainInfoCollection : ReadOnlyCollectionBase {
+        public ForestTrustDomainInformation this[int index] { get; }
+        public bool Contains(ForestTrustDomainInformation information);
+        public void CopyTo(ForestTrustDomainInformation[] array, int index);
+        public int IndexOf(ForestTrustDomainInformation information);
+    }
+    public class ForestTrustDomainInformation {
+        public string DnsName { get; }
+        public string DomainSid { get; }
+        public string NetBiosName { get; }
+        public ForestTrustDomainStatus Status { get; set; }
+    }
+    public enum ForestTrustDomainStatus {
+        Enabled = 0,
+        NetBiosNameAdminDisabled = 4,
+        NetBiosNameConflictDisabled = 8,
+        SidAdminDisabled = 1,
+        SidConflictDisabled = 2,
+    }
+    public class ForestTrustRelationshipCollision {
+        public string CollisionRecord { get; }
+        public ForestTrustCollisionType CollisionType { get; }
+        public DomainCollisionOptions DomainCollisionOption { get; }
+        public TopLevelNameCollisionOptions TopLevelNameCollisionOption { get; }
+    }
+    public class ForestTrustRelationshipCollisionCollection : ReadOnlyCollectionBase {
+        public ForestTrustRelationshipCollision this[int index] { get; }
+        public bool Contains(ForestTrustRelationshipCollision collision);
+        public void CopyTo(ForestTrustRelationshipCollision[] array, int index);
+        public int IndexOf(ForestTrustRelationshipCollision collision);
+    }
+    public class ForestTrustRelationshipInformation : TrustRelationshipInformation {
+        public StringCollection ExcludedTopLevelNames { get; }
+        public TopLevelNameCollection TopLevelNames { get; }
+        public ForestTrustDomainInfoCollection TrustedDomainInformation { get; }
+        public void Save();
+    }
+    public class GlobalCatalog : DomainController {
+        public DomainController DisableGlobalCatalog();
+        public override GlobalCatalog EnableGlobalCatalog();
+        public static new GlobalCatalogCollection FindAll(DirectoryContext context);
+        public static new GlobalCatalogCollection FindAll(DirectoryContext context, string siteName);
+        public ReadOnlyActiveDirectorySchemaPropertyCollection FindAllProperties();
+        public static new GlobalCatalog FindOne(DirectoryContext context);
+        public static new GlobalCatalog FindOne(DirectoryContext context, LocatorOptions flag);
+        public static new GlobalCatalog FindOne(DirectoryContext context, string siteName);
+        public static new GlobalCatalog FindOne(DirectoryContext context, string siteName, LocatorOptions flag);
+        public override DirectorySearcher GetDirectorySearcher();
+        public static GlobalCatalog GetGlobalCatalog(DirectoryContext context);
+        public override bool IsGlobalCatalog();
+    }
+    public class GlobalCatalogCollection : ReadOnlyCollectionBase {
+        public GlobalCatalog this[int index] { get; }
+        public bool Contains(GlobalCatalog globalCatalog);
+        public void CopyTo(GlobalCatalog[] globalCatalogs, int index);
+        public int IndexOf(GlobalCatalog globalCatalog);
+    }
+    public enum HourOfDay {
+        Eight = 8,
+        Eighteen = 18,
+        Eleven = 11,
+        Fifteen = 15,
+        Five = 5,
+        Four = 4,
+        Fourteen = 14,
+        Nine = 9,
+        Nineteen = 19,
+        One = 1,
+        Seven = 7,
+        Seventeen = 17,
+        Six = 6,
+        Sixteen = 16,
+        Ten = 10,
+        Thirteen = 13,
+        Three = 3,
+        Twelve = 12,
+        Twenty = 20,
+        TwentyOne = 21,
+        TwentyThree = 23,
+        TwentyTwo = 22,
+        Two = 2,
+        Zero = 0,
+    }
+    public enum LocatorOptions : long {
+        AvoidSelf = (long)16384,
+        ForceRediscovery = (long)1,
+        KdcRequired = (long)1024,
+        TimeServerRequired = (long)2048,
+        WriteableRequired = (long)4096,
+    }
+    public enum MinuteOfHour {
+        Fifteen = 15,
+        FortyFive = 45,
+        Thirty = 30,
+        Zero = 0,
+    }
+    public enum NotificationStatus {
+        IntraSiteOnly = 1,
+        NoNotification = 0,
+        NotificationAlways = 2,
+    }
+    public enum PropertyTypes {
+        Indexed = 2,
+        InGlobalCatalog = 4,
+    }
+    public class ReadOnlyActiveDirectorySchemaClassCollection : ReadOnlyCollectionBase {
+        public ActiveDirectorySchemaClass this[int index] { get; }
+        public bool Contains(ActiveDirectorySchemaClass schemaClass);
+        public void CopyTo(ActiveDirectorySchemaClass[] classes, int index);
+        public int IndexOf(ActiveDirectorySchemaClass schemaClass);
+    }
+    public class ReadOnlyActiveDirectorySchemaPropertyCollection : ReadOnlyCollectionBase {
+        public ActiveDirectorySchemaProperty this[int index] { get; }
+        public bool Contains(ActiveDirectorySchemaProperty schemaProperty);
+        public void CopyTo(ActiveDirectorySchemaProperty[] properties, int index);
+        public int IndexOf(ActiveDirectorySchemaProperty schemaProperty);
+    }
+    public class ReadOnlyDirectoryServerCollection : ReadOnlyCollectionBase {
+        public DirectoryServer this[int index] { get; }
+        public bool Contains(DirectoryServer directoryServer);
+        public void CopyTo(DirectoryServer[] directoryServers, int index);
+        public int IndexOf(DirectoryServer directoryServer);
+    }
+    public class ReadOnlySiteCollection : ReadOnlyCollectionBase {
+        public ActiveDirectorySite this[int index] { get; }
+        public bool Contains(ActiveDirectorySite site);
+        public void CopyTo(ActiveDirectorySite[] sites, int index);
+        public int IndexOf(ActiveDirectorySite site);
+    }
+    public class ReadOnlySiteLinkBridgeCollection : ReadOnlyCollectionBase {
+        public ActiveDirectorySiteLinkBridge this[int index] { get; }
+        public bool Contains(ActiveDirectorySiteLinkBridge bridge);
+        public void CopyTo(ActiveDirectorySiteLinkBridge[] bridges, int index);
+        public int IndexOf(ActiveDirectorySiteLinkBridge bridge);
+    }
+    public class ReadOnlySiteLinkCollection : ReadOnlyCollectionBase {
+        public ActiveDirectorySiteLink this[int index] { get; }
+        public bool Contains(ActiveDirectorySiteLink link);
+        public void CopyTo(ActiveDirectorySiteLink[] links, int index);
+        public int IndexOf(ActiveDirectorySiteLink link);
+    }
+    public class ReadOnlyStringCollection : ReadOnlyCollectionBase {
+        public string this[int index] { get; }
+        public bool Contains(string value);
+        public void CopyTo(string[] values, int index);
+        public int IndexOf(string value);
+    }
+    public class ReplicationConnection : IDisposable {
+        public ReplicationConnection(DirectoryContext context, string name, DirectoryServer sourceServer);
+        public ReplicationConnection(DirectoryContext context, string name, DirectoryServer sourceServer, ActiveDirectorySchedule schedule);
+        public ReplicationConnection(DirectoryContext context, string name, DirectoryServer sourceServer, ActiveDirectorySchedule schedule, ActiveDirectoryTransportType transport);
+        public ReplicationConnection(DirectoryContext context, string name, DirectoryServer sourceServer, ActiveDirectoryTransportType transport);
+        public NotificationStatus ChangeNotificationStatus { get; set; }
+        public bool DataCompressionEnabled { get; set; }
+        public string DestinationServer { get; }
+        public bool Enabled { get; set; }
+        public bool GeneratedByKcc { get; set; }
+        public string Name { get; }
+        public bool ReciprocalReplicationEnabled { get; set; }
+        public ActiveDirectorySchedule ReplicationSchedule { get; set; }
+        public bool ReplicationScheduleOwnedByUser { get; set; }
+        public ReplicationSpan ReplicationSpan { get; }
+        public string SourceServer { get; }
+        public ActiveDirectoryTransportType TransportType { get; }
+        public void Delete();
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        ~ReplicationConnection();
+        public static ReplicationConnection FindByName(DirectoryContext context, string name);
+        public DirectoryEntry GetDirectoryEntry();
+        public void Save();
+        public override string ToString();
+    }
+    public class ReplicationConnectionCollection : ReadOnlyCollectionBase {
+        public ReplicationConnection this[int index] { get; }
+        public bool Contains(ReplicationConnection connection);
+        public void CopyTo(ReplicationConnection[] connections, int index);
+        public int IndexOf(ReplicationConnection connection);
+    }
+    public class ReplicationCursor {
+        public DateTime LastSuccessfulSyncTime { get; }
+        public string PartitionName { get; }
+        public Guid SourceInvocationId { get; }
+        public string SourceServer { get; }
+        public long UpToDatenessUsn { get; }
+    }
+    public class ReplicationCursorCollection : ReadOnlyCollectionBase {
+        public ReplicationCursor this[int index] { get; }
+        public bool Contains(ReplicationCursor cursor);
+        public void CopyTo(ReplicationCursor[] values, int index);
+        public int IndexOf(ReplicationCursor cursor);
+    }
+    public class ReplicationFailure {
+        public int ConsecutiveFailureCount { get; }
+        public DateTime FirstFailureTime { get; }
+        public int LastErrorCode { get; }
+        public string LastErrorMessage { get; }
+        public string SourceServer { get; }
+    }
+    public class ReplicationFailureCollection : ReadOnlyCollectionBase {
+        public ReplicationFailure this[int index] { get; }
+        public bool Contains(ReplicationFailure failure);
+        public void CopyTo(ReplicationFailure[] failures, int index);
+        public int IndexOf(ReplicationFailure failure);
+    }
+    public class ReplicationNeighbor {
+        public int ConsecutiveFailureCount { get; }
+        public DateTime LastAttemptedSync { get; }
+        public DateTime LastSuccessfulSync { get; }
+        public string LastSyncMessage { get; }
+        public int LastSyncResult { get; }
+        public string PartitionName { get; }
+        public ReplicationNeighbor.ReplicationNeighborOptions ReplicationNeighborOption { get; }
+        public Guid SourceInvocationId { get; }
+        public string SourceServer { get; }
+        public ActiveDirectoryTransportType TransportType { get; }
+        public long UsnAttributeFilter { get; }
+        public long UsnLastObjectChangeSynced { get; }
+        public enum ReplicationNeighborOptions : long {
+            CompressChanges = (long)268435456,
+            DisableScheduledSync = (long)134217728,
+            FullSyncInProgress = (long)65536,
+            FullSyncNextPacket = (long)131072,
+            IgnoreChangeNotifications = (long)67108864,
+            NeverSynced = (long)2097152,
+            NoChangeNotifications = (long)536870912,
+            PartialAttributeSet = (long)1073741824,
+            Preempted = (long)16777216,
+            ReturnObjectParent = (long)2048,
+            ScheduledSync = (long)64,
+            SyncOnStartup = (long)32,
+            TwoWaySync = (long)512,
+            UseInterSiteTransport = (long)128,
+            Writeable = (long)16,
+        }
+    }
+    public class ReplicationNeighborCollection : ReadOnlyCollectionBase {
+        public ReplicationNeighbor this[int index] { get; }
+        public bool Contains(ReplicationNeighbor neighbor);
+        public void CopyTo(ReplicationNeighbor[] neighbors, int index);
+        public int IndexOf(ReplicationNeighbor neighbor);
+    }
+    public class ReplicationOperation {
+        public int OperationNumber { get; }
+        public ReplicationOperationType OperationType { get; }
+        public string PartitionName { get; }
+        public int Priority { get; }
+        public string SourceServer { get; }
+        public DateTime TimeEnqueued { get; }
+    }
+    public class ReplicationOperationCollection : ReadOnlyCollectionBase {
+        public ReplicationOperation this[int index] { get; }
+        public bool Contains(ReplicationOperation operation);
+        public void CopyTo(ReplicationOperation[] operations, int index);
+        public int IndexOf(ReplicationOperation operation);
+    }
+    public class ReplicationOperationInformation {
+        public ReplicationOperationInformation();
+        public ReplicationOperation CurrentOperation { get; }
+        public DateTime OperationStartTime { get; }
+        public ReplicationOperationCollection PendingOperations { get; }
+    }
+    public enum ReplicationOperationType {
+        Add = 1,
+        Delete = 2,
+        Modify = 3,
+        Sync = 0,
+        UpdateReference = 4,
+    }
+    public enum ReplicationSecurityLevel {
+        MutualAuthentication = 2,
+        Negotiate = 1,
+        NegotiatePassThrough = 0,
+    }
+    public enum ReplicationSpan {
+        InterSite = 1,
+        IntraSite = 0,
+    }
+    public enum SchemaClassType {
+        Abstract = 2,
+        Auxiliary = 3,
+        Structural = 1,
+        Type88 = 0,
+    }
+    public enum SyncFromAllServersErrorCategory {
+        ErrorContactingServer = 0,
+        ErrorReplicating = 1,
+        ServerUnreachable = 2,
+    }
+    public class SyncFromAllServersErrorInformation {
+        public SyncFromAllServersErrorCategory ErrorCategory { get; }
+        public int ErrorCode { get; }
+        public string ErrorMessage { get; }
+        public string SourceServer { get; }
+        public string TargetServer { get; }
+    }
+    public enum SyncFromAllServersEvent {
+        Error = 0,
+        Finished = 3,
+        SyncCompleted = 2,
+        SyncStarted = 1,
+    }
+    public class SyncFromAllServersOperationException : ActiveDirectoryOperationException, ISerializable {
+        public SyncFromAllServersOperationException();
+        protected SyncFromAllServersOperationException(SerializationInfo info, StreamingContext context);
+        public SyncFromAllServersOperationException(string message);
+        public SyncFromAllServersOperationException(string message, Exception inner);
+        public SyncFromAllServersOperationException(string message, Exception inner, SyncFromAllServersErrorInformation[] errors);
+        public SyncFromAllServersErrorInformation[] ErrorInformation { get; }
+        public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext);
+    }
+    public enum SyncFromAllServersOptions {
+        AbortIfServerUnavailable = 1,
+        CheckServerAlivenessOnly = 8,
+        CrossSite = 64,
+        None = 0,
+        PushChangeOutward = 32,
+        SkipInitialCheck = 16,
+        SyncAdjacentServerOnly = 2,
+    }
+    public delegate bool SyncUpdateCallback(SyncFromAllServersEvent eventType, string targetServer, string sourceServer, SyncFromAllServersOperationException exception);
+    public class TopLevelName {
+        public string Name { get; }
+        public TopLevelNameStatus Status { get; set; }
+    }
+    public class TopLevelNameCollection : ReadOnlyCollectionBase {
+        public TopLevelName this[int index] { get; }
+        public bool Contains(TopLevelName name);
+        public void CopyTo(TopLevelName[] names, int index);
+        public int IndexOf(TopLevelName name);
+    }
+    public enum TopLevelNameCollisionOptions {
+        DisabledByAdmin = 2,
+        DisabledByConflict = 4,
+        NewlyCreated = 1,
+        None = 0,
+    }
+    public enum TopLevelNameStatus {
+        AdminDisabled = 2,
+        ConflictDisabled = 4,
+        Enabled = 0,
+        NewlyCreated = 1,
+    }
+    public enum TrustDirection {
+        Bidirectional = 3,
+        Inbound = 1,
+        Outbound = 2,
+    }
+    public class TrustRelationshipInformation {
+        public string SourceName { get; }
+        public string TargetName { get; }
+        public TrustDirection TrustDirection { get; }
+        public TrustType TrustType { get; }
+    }
+    public class TrustRelationshipInformationCollection : ReadOnlyCollectionBase {
+        public TrustRelationshipInformation this[int index] { get; }
+        public bool Contains(TrustRelationshipInformation information);
+        public void CopyTo(TrustRelationshipInformation[] array, int index);
+        public int IndexOf(TrustRelationshipInformation information);
+    }
+    public enum TrustType {
+        CrossLink = 2,
+        External = 3,
+        Forest = 4,
+        Kerberos = 5,
+        ParentChild = 1,
+        TreeRoot = 0,
+        Unknown = 6,
+    }
+}
```

