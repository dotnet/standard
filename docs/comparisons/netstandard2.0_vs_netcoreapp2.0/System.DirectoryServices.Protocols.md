# System.DirectoryServices.Protocols

``` diff
+namespace System.DirectoryServices.Protocols {
+    public class AddRequest : DirectoryRequest {
+        public AddRequest();
+        public AddRequest(string distinguishedName, params DirectoryAttribute[] attributes);
+        public AddRequest(string distinguishedName, string objectClass);
+        public DirectoryAttributeCollection Attributes { get; }
+        public string DistinguishedName { get; set; }
+    }
+    public class AddResponse : DirectoryResponse
+    public class AsqRequestControl : DirectoryControl {
+        public AsqRequestControl();
+        public AsqRequestControl(string attributeName);
+        public string AttributeName { get; set; }
+        public override byte[] GetValue();
+    }
+    public class AsqResponseControl : DirectoryControl {
+        public ResultCode Result { get; }
+    }
+    public enum AuthType {
+        Anonymous = 0,
+        Basic = 1,
+        Digest = 4,
+        Dpa = 6,
+        External = 8,
+        Kerberos = 9,
+        Msn = 7,
+        Negotiate = 2,
+        Ntlm = 3,
+        Sicily = 5,
+    }
+    public class BerConversionException : DirectoryException {
+        public BerConversionException();
+        protected BerConversionException(SerializationInfo info, StreamingContext context);
+        public BerConversionException(string message);
+        public BerConversionException(string message, Exception inner);
+    }
+    public sealed class BerConverter {
+        public static object[] Decode(string format, byte[] value);
+        public static byte[] Encode(string format, params object[] value);
+    }
+    public class CompareRequest : DirectoryRequest {
+        public CompareRequest();
+        public CompareRequest(string distinguishedName, DirectoryAttribute assertion);
+        public CompareRequest(string distinguishedName, string attributeName, byte[] value);
+        public CompareRequest(string distinguishedName, string attributeName, string value);
+        public CompareRequest(string distinguishedName, string attributeName, Uri value);
+        public DirectoryAttribute Assertion { get; }
+        public string DistinguishedName { get; set; }
+    }
+    public class CompareResponse : DirectoryResponse
+    public class CrossDomainMoveControl : DirectoryControl {
+        public CrossDomainMoveControl();
+        public CrossDomainMoveControl(string targetDomainController);
+        public string TargetDomainController { get; set; }
+        public override byte[] GetValue();
+    }
+    public class DeleteRequest : DirectoryRequest {
+        public DeleteRequest();
+        public DeleteRequest(string distinguishedName);
+        public string DistinguishedName { get; set; }
+    }
+    public class DeleteResponse : DirectoryResponse
+    public enum DereferenceAlias {
+        Always = 3,
+        FindingBaseObject = 2,
+        InSearching = 1,
+        Never = 0,
+    }
+    public delegate void DereferenceConnectionCallback(LdapConnection primaryConnection, LdapConnection connectionToDereference);
+    public class DirectoryAttribute : CollectionBase {
+        public DirectoryAttribute();
+        public DirectoryAttribute(string name, byte[] value);
+        public DirectoryAttribute(string name, params object[] values);
+        public DirectoryAttribute(string name, string value);
+        public DirectoryAttribute(string name, Uri value);
+        public string Name { get; set; }
+        public object this[int index] { get; set; }
+        public int Add(byte[] value);
+        public int Add(string value);
+        public int Add(Uri value);
+        public void AddRange(object[] values);
+        public bool Contains(object value);
+        public void CopyTo(object[] array, int index);
+        public object[] GetValues(Type valuesType);
+        public int IndexOf(object value);
+        public void Insert(int index, byte[] value);
+        public void Insert(int index, string value);
+        public void Insert(int index, Uri value);
+        protected override void OnValidate(object value);
+        public void Remove(object value);
+    }
+    public class DirectoryAttributeCollection : CollectionBase {
+        public DirectoryAttributeCollection();
+        public DirectoryAttribute this[int index] { get; set; }
+        public int Add(DirectoryAttribute attribute);
+        public void AddRange(DirectoryAttributeCollection attributeCollection);
+        public void AddRange(DirectoryAttribute[] attributes);
+        public bool Contains(DirectoryAttribute value);
+        public void CopyTo(DirectoryAttribute[] array, int index);
+        public int IndexOf(DirectoryAttribute value);
+        public void Insert(int index, DirectoryAttribute value);
+        protected override void OnValidate(object value);
+        public void Remove(DirectoryAttribute value);
+    }
+    public class DirectoryAttributeModification : DirectoryAttribute {
+        public DirectoryAttributeModification();
+        public DirectoryAttributeOperation Operation { get; set; }
+    }
+    public class DirectoryAttributeModificationCollection : CollectionBase {
+        public DirectoryAttributeModificationCollection();
+        public DirectoryAttributeModification this[int index] { get; set; }
+        public int Add(DirectoryAttributeModification attribute);
+        public void AddRange(DirectoryAttributeModificationCollection attributeCollection);
+        public void AddRange(DirectoryAttributeModification[] attributes);
+        public bool Contains(DirectoryAttributeModification value);
+        public void CopyTo(DirectoryAttributeModification[] array, int index);
+        public int IndexOf(DirectoryAttributeModification value);
+        public void Insert(int index, DirectoryAttributeModification value);
+        protected override void OnValidate(object value);
+        public void Remove(DirectoryAttributeModification value);
+    }
+    public enum DirectoryAttributeOperation {
+        Add = 0,
+        Delete = 1,
+        Replace = 2,
+    }
+    public abstract class DirectoryConnection {
+        protected DirectoryConnection();
+        public X509CertificateCollection ClientCertificates { get; }
+        public virtual NetworkCredential Credential { set; }
+        public virtual DirectoryIdentifier Directory { get; }
+        public virtual TimeSpan Timeout { get; set; }
+        public abstract DirectoryResponse SendRequest(DirectoryRequest request);
+    }
+    public class DirectoryControl {
+        public DirectoryControl(string type, byte[] value, bool isCritical, bool serverSide);
+        public bool IsCritical { get; set; }
+        public bool ServerSide { get; set; }
+        public string Type { get; }
+        public virtual byte[] GetValue();
+    }
+    public class DirectoryControlCollection : CollectionBase {
+        public DirectoryControlCollection();
+        public DirectoryControl this[int index] { get; set; }
+        public int Add(DirectoryControl control);
+        public void AddRange(DirectoryControlCollection controlCollection);
+        public void AddRange(DirectoryControl[] controls);
+        public bool Contains(DirectoryControl value);
+        public void CopyTo(DirectoryControl[] array, int index);
+        public int IndexOf(DirectoryControl value);
+        public void Insert(int index, DirectoryControl value);
+        protected override void OnValidate(object value);
+        public void Remove(DirectoryControl value);
+    }
+    public class DirectoryException : Exception {
+        public DirectoryException();
+        protected DirectoryException(SerializationInfo info, StreamingContext context);
+        public DirectoryException(string message);
+        public DirectoryException(string message, Exception inner);
+    }
+    public abstract class DirectoryIdentifier {
+        protected DirectoryIdentifier();
+    }
+    public class DirectoryNotificationControl : DirectoryControl {
+        public DirectoryNotificationControl();
+    }
+    public abstract class DirectoryOperation {
+        protected DirectoryOperation();
+    }
+    public class DirectoryOperationException : DirectoryException, ISerializable {
+        public DirectoryOperationException();
+        public DirectoryOperationException(DirectoryResponse response);
+        public DirectoryOperationException(DirectoryResponse response, string message);
+        public DirectoryOperationException(DirectoryResponse response, string message, Exception inner);
+        protected DirectoryOperationException(SerializationInfo info, StreamingContext context);
+        public DirectoryOperationException(string message);
+        public DirectoryOperationException(string message, Exception inner);
+        public DirectoryResponse Response { get; }
+        public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext);
+    }
+    public abstract class DirectoryRequest : DirectoryOperation {
+        public DirectoryControlCollection Controls { get; }
+        public string RequestId { get; set; }
+    }
+    public abstract class DirectoryResponse : DirectoryOperation {
+        public virtual DirectoryControl[] Controls { get; }
+        public virtual string ErrorMessage { get; }
+        public virtual string MatchedDN { get; }
+        public virtual Uri[] Referral { get; }
+        public string RequestId { get; }
+        public virtual ResultCode ResultCode { get; }
+    }
+    public enum DirectorySynchronizationOptions : long {
+        IncrementalValues = (long)2147483648,
+        None = (long)0,
+        ObjectSecurity = (long)1,
+        ParentsFirst = (long)2048,
+        PublicDataOnly = (long)8192,
+    }
+    public class DirSyncRequestControl : DirectoryControl {
+        public DirSyncRequestControl();
+        public DirSyncRequestControl(byte[] cookie);
+        public DirSyncRequestControl(byte[] cookie, DirectorySynchronizationOptions option);
+        public DirSyncRequestControl(byte[] cookie, DirectorySynchronizationOptions option, int attributeCount);
+        public int AttributeCount { get; set; }
+        public byte[] Cookie { get; set; }
+        public DirectorySynchronizationOptions Option { get; set; }
+        public override byte[] GetValue();
+    }
+    public class DirSyncResponseControl : DirectoryControl {
+        public byte[] Cookie { get; }
+        public bool MoreData { get; }
+        public int ResultSize { get; }
+    }
+    public class DomainScopeControl : DirectoryControl {
+        public DomainScopeControl();
+    }
+    public class DsmlAuthRequest : DirectoryRequest {
+        public DsmlAuthRequest();
+        public DsmlAuthRequest(string principal);
+        public string Principal { get; set; }
+    }
+    public class ExtendedDNControl : DirectoryControl {
+        public ExtendedDNControl();
+        public ExtendedDNControl(ExtendedDNFlag flag);
+        public ExtendedDNFlag Flag { get; set; }
+        public override byte[] GetValue();
+    }
+    public enum ExtendedDNFlag {
+        HexString = 0,
+        StandardString = 1,
+    }
+    public class ExtendedRequest : DirectoryRequest {
+        public ExtendedRequest();
+        public ExtendedRequest(string requestName);
+        public ExtendedRequest(string requestName, byte[] requestValue);
+        public string RequestName { get; set; }
+        public byte[] RequestValue { get; set; }
+    }
+    public class ExtendedResponse : DirectoryResponse {
+        public string ResponseName { get; }
+        public byte[] ResponseValue { get; }
+    }
+    public class LazyCommitControl : DirectoryControl {
+        public LazyCommitControl();
+    }
+    public class LdapConnection : DirectoryConnection, IDisposable {
+        public LdapConnection(LdapDirectoryIdentifier identifier);
+        public LdapConnection(LdapDirectoryIdentifier identifier, NetworkCredential credential);
+        public LdapConnection(LdapDirectoryIdentifier identifier, NetworkCredential credential, AuthType authType);
+        public LdapConnection(string server);
+        public AuthType AuthType { get; set; }
+        public bool AutoBind { get; set; }
+        public override NetworkCredential Credential { set; }
+        public LdapSessionOptions SessionOptions { get; }
+        public override TimeSpan Timeout { get; set; }
+        public void Abort(IAsyncResult asyncResult);
+        public IAsyncResult BeginSendRequest(DirectoryRequest request, PartialResultProcessing partialMode, AsyncCallback callback, object state);
+        public IAsyncResult BeginSendRequest(DirectoryRequest request, TimeSpan requestTimeout, PartialResultProcessing partialMode, AsyncCallback callback, object state);
+        public void Bind();
+        public void Bind(NetworkCredential newCredential);
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        public DirectoryResponse EndSendRequest(IAsyncResult asyncResult);
+        ~LdapConnection();
+        public PartialResultsCollection GetPartialResults(IAsyncResult asyncResult);
+        public override DirectoryResponse SendRequest(DirectoryRequest request);
+        public DirectoryResponse SendRequest(DirectoryRequest request, TimeSpan requestTimeout);
+    }
+    public class LdapDirectoryIdentifier : DirectoryIdentifier {
+        public LdapDirectoryIdentifier(string server);
+        public LdapDirectoryIdentifier(string server, bool fullyQualifiedDnsHostName, bool connectionless);
+        public LdapDirectoryIdentifier(string server, int portNumber);
+        public LdapDirectoryIdentifier(string server, int portNumber, bool fullyQualifiedDnsHostName, bool connectionless);
+        public LdapDirectoryIdentifier(string[] servers, bool fullyQualifiedDnsHostName, bool connectionless);
+        public LdapDirectoryIdentifier(string[] servers, int portNumber, bool fullyQualifiedDnsHostName, bool connectionless);
+        public bool Connectionless { get; }
+        public bool FullyQualifiedDnsHostName { get; }
+        public int PortNumber { get; }
+        public string[] Servers { get; }
+    }
+    public class LdapException : DirectoryException, ISerializable {
+        public LdapException();
+        public LdapException(int errorCode);
+        public LdapException(int errorCode, string message);
+        public LdapException(int errorCode, string message, Exception inner);
+        public LdapException(int errorCode, string message, string serverErrorMessage);
+        protected LdapException(SerializationInfo info, StreamingContext context);
+        public LdapException(string message);
+        public LdapException(string message, Exception inner);
+        public int ErrorCode { get; }
+        public PartialResultsCollection PartialResults { get; }
+        public string ServerErrorMessage { get; }
+        public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext);
+    }
+    public class LdapSessionOptions {
+        public bool AutoReconnect { get; set; }
+        public string DomainName { get; set; }
+        public string HostName { get; set; }
+        public bool HostReachable { get; }
+        public LocatorFlags LocatorFlag { get; set; }
+        public TimeSpan PingKeepAliveTimeout { get; set; }
+        public int PingLimit { get; set; }
+        public TimeSpan PingWaitTimeout { get; set; }
+        public int ProtocolVersion { get; set; }
+        public QueryClientCertificateCallback QueryClientCertificate { get; set; }
+        public ReferralCallback ReferralCallback { get; set; }
+        public ReferralChasingOptions ReferralChasing { get; set; }
+        public int ReferralHopLimit { get; set; }
+        public bool RootDseCache { get; set; }
+        public string SaslMethod { get; set; }
+        public bool Sealing { get; set; }
+        public bool SecureSocketLayer { get; set; }
+        public object SecurityContext { get; }
+        public TimeSpan SendTimeout { get; set; }
+        public bool Signing { get; set; }
+        public SecurityPackageContextConnectionInformation SslInformation { get; }
+        public int SspiFlag { get; set; }
+        public bool TcpKeepAlive { get; set; }
+        public VerifyServerCertificateCallback VerifyServerCertificate { get; set; }
+        public void FastConcurrentBind();
+        public void StartTransportLayerSecurity(DirectoryControlCollection controls);
+        public void StopTransportLayerSecurity();
+    }
+    public enum LocatorFlags : long {
+        AvoidSelf = (long)16384,
+        DirectoryServicesPreferred = (long)32,
+        DirectoryServicesRequired = (long)16,
+        ForceRediscovery = (long)1,
+        GCRequired = (long)64,
+        GoodTimeServerPreferred = (long)8192,
+        IPRequired = (long)512,
+        IsDnsName = (long)131072,
+        IsFlatName = (long)65536,
+        KdcRequired = (long)1024,
+        None = (long)0,
+        OnlyLdapNeeded = (long)32768,
+        PdcRequired = (long)128,
+        ReturnDnsName = (long)1073741824,
+        ReturnFlatName = (long)2147483648,
+        TimeServerRequired = (long)2048,
+        WriteableRequired = (long)4096,
+    }
+    public class ModifyDNRequest : DirectoryRequest {
+        public ModifyDNRequest();
+        public ModifyDNRequest(string distinguishedName, string newParentDistinguishedName, string newName);
+        public bool DeleteOldRdn { get; set; }
+        public string DistinguishedName { get; set; }
+        public string NewName { get; set; }
+        public string NewParentDistinguishedName { get; set; }
+    }
+    public class ModifyDNResponse : DirectoryResponse
+    public class ModifyRequest : DirectoryRequest {
+        public ModifyRequest();
+        public ModifyRequest(string distinguishedName, params DirectoryAttributeModification[] modifications);
+        public ModifyRequest(string distinguishedName, DirectoryAttributeOperation operation, string attributeName, params object[] values);
+        public string DistinguishedName { get; set; }
+        public DirectoryAttributeModificationCollection Modifications { get; }
+    }
+    public class ModifyResponse : DirectoryResponse
+    public delegate bool NotifyOfNewConnectionCallback(LdapConnection primaryConnection, LdapConnection referralFromConnection, string newDistinguishedName, LdapDirectoryIdentifier identifier, LdapConnection newConnection, NetworkCredential credential, long currentUserToken, int errorCodeFromBind);
+    public class PageResultRequestControl : DirectoryControl {
+        public PageResultRequestControl();
+        public PageResultRequestControl(byte[] cookie);
+        public PageResultRequestControl(int pageSize);
+        public byte[] Cookie { get; set; }
+        public int PageSize { get; set; }
+        public override byte[] GetValue();
+    }
+    public class PageResultResponseControl : DirectoryControl {
+        public byte[] Cookie { get; }
+        public int TotalCount { get; }
+    }
+    public enum PartialResultProcessing {
+        NoPartialResultSupport = 0,
+        ReturnPartialResults = 1,
+        ReturnPartialResultsAndNotifyCallback = 2,
+    }
+    public class PartialResultsCollection : ReadOnlyCollectionBase {
+        public object this[int index] { get; }
+        public bool Contains(object value);
+        public void CopyTo(object[] values, int index);
+        public int IndexOf(object value);
+    }
+    public class PermissiveModifyControl : DirectoryControl {
+        public PermissiveModifyControl();
+    }
+    public delegate X509Certificate QueryClientCertificateCallback(LdapConnection connection, byte[][] trustedCAs);
+    public delegate LdapConnection QueryForConnectionCallback(LdapConnection primaryConnection, LdapConnection referralFromConnection, string newDistinguishedName, LdapDirectoryIdentifier identifier, NetworkCredential credential, long currentUserToken);
+    public class QuotaControl : DirectoryControl {
+        public QuotaControl();
+        public QuotaControl(SecurityIdentifier querySid);
+        public SecurityIdentifier QuerySid { get; set; }
+        public override byte[] GetValue();
+    }
+    public sealed class ReferralCallback {
+        public ReferralCallback();
+        public DereferenceConnectionCallback DereferenceConnection { get; set; }
+        public NotifyOfNewConnectionCallback NotifyNewConnection { get; set; }
+        public QueryForConnectionCallback QueryForConnection { get; set; }
+    }
+    public enum ReferralChasingOptions {
+        All = 96,
+        External = 64,
+        None = 0,
+        Subordinate = 32,
+    }
+    public enum ResultCode {
+        AdminLimitExceeded = 11,
+        AffectsMultipleDsas = 71,
+        AliasDereferencingProblem = 36,
+        AliasProblem = 33,
+        AttributeOrValueExists = 20,
+        AuthMethodNotSupported = 7,
+        Busy = 51,
+        CompareFalse = 5,
+        CompareTrue = 6,
+        ConfidentialityRequired = 13,
+        ConstraintViolation = 19,
+        EntryAlreadyExists = 68,
+        InappropriateAuthentication = 48,
+        InappropriateMatching = 18,
+        InsufficientAccessRights = 50,
+        InvalidAttributeSyntax = 21,
+        InvalidDNSyntax = 34,
+        LoopDetect = 54,
+        NamingViolation = 64,
+        NoSuchAttribute = 16,
+        NoSuchObject = 32,
+        NotAllowedOnNonLeaf = 66,
+        NotAllowedOnRdn = 67,
+        ObjectClassModificationsProhibited = 69,
+        ObjectClassViolation = 65,
+        OffsetRangeError = 61,
+        OperationsError = 1,
+        Other = 80,
+        ProtocolError = 2,
+        Referral = 10,
+        ReferralV2 = 9,
+        ResultsTooLarge = 70,
+        SaslBindInProgress = 14,
+        SizeLimitExceeded = 4,
+        SortControlMissing = 60,
+        StrongAuthRequired = 8,
+        Success = 0,
+        TimeLimitExceeded = 3,
+        Unavailable = 52,
+        UnavailableCriticalExtension = 12,
+        UndefinedAttributeType = 17,
+        UnwillingToPerform = 53,
+        VirtualListViewError = 76,
+    }
+    public enum SearchOption {
+        DomainScope = 1,
+        PhantomRoot = 2,
+    }
+    public class SearchOptionsControl : DirectoryControl {
+        public SearchOptionsControl();
+        public SearchOptionsControl(SearchOption flags);
+        public SearchOption SearchOption { get; set; }
+        public override byte[] GetValue();
+    }
+    public class SearchRequest : DirectoryRequest {
+        public SearchRequest();
+        public SearchRequest(string distinguishedName, string ldapFilter, SearchScope searchScope, params string[] attributeList);
+        public DereferenceAlias Aliases { get; set; }
+        public StringCollection Attributes { get; }
+        public string DistinguishedName { get; set; }
+        public object Filter { get; set; }
+        public SearchScope Scope { get; set; }
+        public int SizeLimit { get; set; }
+        public TimeSpan TimeLimit { get; set; }
+        public bool TypesOnly { get; set; }
+    }
+    public class SearchResponse : DirectoryResponse {
+        public override DirectoryControl[] Controls { get; }
+        public SearchResultEntryCollection Entries { get; }
+        public override string ErrorMessage { get; }
+        public override string MatchedDN { get; }
+        public SearchResultReferenceCollection References { get; }
+        public override Uri[] Referral { get; }
+        public override ResultCode ResultCode { get; }
+    }
+    public class SearchResultAttributeCollection : DictionaryBase {
+        public ICollection AttributeNames { get; }
+        public DirectoryAttribute this[string attributeName] { get; }
+        public ICollection Values { get; }
+        public bool Contains(string attributeName);
+        public void CopyTo(DirectoryAttribute[] array, int index);
+    }
+    public class SearchResultEntry {
+        public SearchResultAttributeCollection Attributes { get; }
+        public DirectoryControl[] Controls { get; }
+        public string DistinguishedName { get; }
+    }
+    public class SearchResultEntryCollection : ReadOnlyCollectionBase {
+        public SearchResultEntry this[int index] { get; }
+        public bool Contains(SearchResultEntry value);
+        public void CopyTo(SearchResultEntry[] values, int index);
+        public int IndexOf(SearchResultEntry value);
+    }
+    public class SearchResultReference {
+        public DirectoryControl[] Controls { get; }
+        public Uri[] Reference { get; }
+    }
+    public class SearchResultReferenceCollection : ReadOnlyCollectionBase {
+        public SearchResultReference this[int index] { get; }
+        public bool Contains(SearchResultReference value);
+        public void CopyTo(SearchResultReference[] values, int index);
+        public int IndexOf(SearchResultReference value);
+    }
+    public enum SearchScope {
+        Base = 0,
+        OneLevel = 1,
+        Subtree = 2,
+    }
+    public class SecurityDescriptorFlagControl : DirectoryControl {
+        public SecurityDescriptorFlagControl();
+        public SecurityDescriptorFlagControl(SecurityMasks masks);
+        public SecurityMasks SecurityMasks { get; set; }
+        public override byte[] GetValue();
+    }
+    public enum SecurityMasks {
+        Dacl = 4,
+        Group = 2,
+        None = 0,
+        Owner = 1,
+        Sacl = 8,
+    }
+    public class SecurityPackageContextConnectionInformation {
+        public CipherAlgorithmType AlgorithmIdentifier { get; }
+        public int CipherStrength { get; }
+        public int ExchangeStrength { get; }
+        public HashAlgorithmType Hash { get; }
+        public int HashStrength { get; }
+        public int KeyExchangeAlgorithm { get; }
+        public SecurityProtocol Protocol { get; }
+    }
+    public enum SecurityProtocol {
+        Pct1Client = 2,
+        Pct1Server = 1,
+        Ssl2Client = 8,
+        Ssl2Server = 4,
+        Ssl3Client = 32,
+        Ssl3Server = 16,
+        Tls1Client = 128,
+        Tls1Server = 64,
+    }
+    public class ShowDeletedControl : DirectoryControl {
+        public ShowDeletedControl();
+    }
+    public class SortKey {
+        public SortKey();
+        public SortKey(string attributeName, string matchingRule, bool reverseOrder);
+        public string AttributeName { get; set; }
+        public string MatchingRule { get; set; }
+        public bool ReverseOrder { get; set; }
+    }
+    public class SortRequestControl : DirectoryControl {
+        public SortRequestControl(params SortKey[] sortKeys);
+        public SortRequestControl(string attributeName, bool reverseOrder);
+        public SortRequestControl(string attributeName, string matchingRule, bool reverseOrder);
+        public SortKey[] SortKeys { get; set; }
+        public override byte[] GetValue();
+    }
+    public class SortResponseControl : DirectoryControl {
+        public string AttributeName { get; }
+        public ResultCode Result { get; }
+    }
+    public class TlsOperationException : DirectoryOperationException {
+        public TlsOperationException();
+        public TlsOperationException(DirectoryResponse response);
+        public TlsOperationException(DirectoryResponse response, string message);
+        public TlsOperationException(DirectoryResponse response, string message, Exception inner);
+        protected TlsOperationException(SerializationInfo info, StreamingContext context);
+        public TlsOperationException(string message);
+        public TlsOperationException(string message, Exception inner);
+    }
+    public class TreeDeleteControl : DirectoryControl {
+        public TreeDeleteControl();
+    }
+    public class VerifyNameControl : DirectoryControl {
+        public VerifyNameControl();
+        public VerifyNameControl(string serverName);
+        public VerifyNameControl(string serverName, int flag);
+        public int Flag { get; set; }
+        public string ServerName { get; set; }
+        public override byte[] GetValue();
+    }
+    public delegate bool VerifyServerCertificateCallback(LdapConnection connection, X509Certificate certificate);
+    public class VlvRequestControl : DirectoryControl {
+        public VlvRequestControl();
+        public VlvRequestControl(int beforeCount, int afterCount, byte[] target);
+        public VlvRequestControl(int beforeCount, int afterCount, int offset);
+        public VlvRequestControl(int beforeCount, int afterCount, string target);
+        public int AfterCount { get; set; }
+        public int BeforeCount { get; set; }
+        public byte[] ContextId { get; set; }
+        public int EstimateCount { get; set; }
+        public int Offset { get; set; }
+        public byte[] Target { get; set; }
+        public override byte[] GetValue();
+    }
+    public class VlvResponseControl : DirectoryControl {
+        public int ContentCount { get; }
+        public byte[] ContextId { get; }
+        public ResultCode Result { get; }
+        public int TargetPosition { get; }
+    }
+}
```

