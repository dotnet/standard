# System.Messaging

``` diff
+namespace System.Messaging {
+    public class AccessControlEntry {
+        public AccessControlEntry();
+        public AccessControlEntry(Trustee trustee);
+        public AccessControlEntry(Trustee trustee, GenericAccessRights genericAccessRights, StandardAccessRights standardAccessRights, AccessControlEntryType entryType);
+        protected int CustomAccessRights { get; set; }
+        public AccessControlEntryType EntryType { get; set; }
+        public GenericAccessRights GenericAccessRights { get; set; }
+        public StandardAccessRights StandardAccessRights { get; set; }
+        public Trustee Trustee { get; set; }
+    }
+    public enum AccessControlEntryType {
+        Allow = 1,
+        Deny = 3,
+        Revoke = 4,
+        Set = 2,
+    }
+    public class AccessControlList : CollectionBase {
+        public AccessControlList();
+        public int Add(AccessControlEntry entry);
+        public bool Contains(AccessControlEntry entry);
+        public void CopyTo(AccessControlEntry[] array, int index);
+        public int IndexOf(AccessControlEntry entry);
+        public void Insert(int index, AccessControlEntry entry);
+        public void Remove(AccessControlEntry entry);
+    }
+    public enum AcknowledgeTypes {
+        FullReachQueue = 5,
+        FullReceive = 14,
+        NegativeReceive = 8,
+        None = 0,
+        NotAcknowledgeReachQueue = 4,
+        NotAcknowledgeReceive = 12,
+        PositiveArrival = 1,
+        PositiveReceive = 2,
+    }
+    public enum Acknowledgment {
+        AccessDenied = 32772,
+        BadDestinationQueue = 32768,
+        BadEncryption = 32775,
+        BadSignature = 32774,
+        CouldNotEncrypt = 32776,
+        HopCountExceeded = 32773,
+        None = 0,
+        NotTransactionalMessage = 32778,
+        NotTransactionalQueue = 32777,
+        Purged = 32769,
+        QueueDeleted = 49152,
+        QueueExceedMaximumSize = 32771,
+        QueuePurged = 49153,
+        ReachQueue = 2,
+        ReachQueueTimeout = 32770,
+        Receive = 16384,
+        ReceiveTimeout = 49154,
+    }
+    public class ActiveXMessageFormatter : ICloneable, IMessageFormatter {
+        public ActiveXMessageFormatter();
+        public bool CanRead(Message message);
+        public object Clone();
+        public static void InitStreamedObject(object streamedObject);
+        public object Read(Message message);
+        public void Write(Message message, object obj);
+    }
+    public class BinaryMessageFormatter : ICloneable, IMessageFormatter {
+        public BinaryMessageFormatter();
+        public BinaryMessageFormatter(FormatterAssemblyStyle topObjectFormat, FormatterTypeStyle typeFormat);
+        public FormatterAssemblyStyle TopObjectFormat { get; set; }
+        public FormatterTypeStyle TypeFormat { get; set; }
+        public bool CanRead(Message message);
+        public object Clone();
+        public object Read(Message message);
+        public void Write(Message message, object obj);
+    }
+    public enum CryptographicProviderType {
+        Dss = 3,
+        Fortezza = 4,
+        MicrosoftExchange = 5,
+        None = 0,
+        RsaFull = 1,
+        RsqSig = 2,
+        Ssl = 6,
+        SttAcq = 8,
+        SttBrnd = 9,
+        SttIss = 11,
+        SttMer = 7,
+        SttRoot = 10,
+    }
+    public sealed class Cursor : IDisposable {
+        public void Close();
+        public void Dispose();
+    }
+    public class DefaultPropertiesToSend {
+        public DefaultPropertiesToSend();
+        public AcknowledgeTypes AcknowledgeType { get; set; }
+        public MessageQueue AdministrationQueue { get; set; }
+        public int AppSpecific { get; set; }
+        public bool AttachSenderId { get; set; }
+        public EncryptionAlgorithm EncryptionAlgorithm { get; set; }
+        public byte[] Extension { get; set; }
+        public HashAlgorithm HashAlgorithm { get; set; }
+        public string Label { get; set; }
+        public MessagePriority Priority { get; set; }
+        public bool Recoverable { get; set; }
+        public MessageQueue ResponseQueue { get; set; }
+        public TimeSpan TimeToBeReceived { get; set; }
+        public TimeSpan TimeToReachQueue { get; set; }
+        public MessageQueue TransactionStatusQueue { get; set; }
+        public bool UseAuthentication { get; set; }
+        public bool UseDeadLetterQueue { get; set; }
+        public bool UseEncryption { get; set; }
+        public bool UseJournalQueue { get; set; }
+        public bool UseTracing { get; set; }
+    }
+    public enum EncryptionAlgorithm {
+        None = 0,
+        Rc2 = 26114,
+        Rc4 = 26625,
+    }
+    public enum EncryptionRequired {
+        Body = 2,
+        None = 0,
+        Optional = 1,
+    }
+    public enum GenericAccessRights {
+        All = 268435456,
+        Execute = 536870912,
+        None = 0,
+        Read = -2147483648,
+        Write = 1073741824,
+    }
+    public enum HashAlgorithm {
+        Mac = 32773,
+        Md2 = 32769,
+        Md4 = 32770,
+        Md5 = 32771,
+        None = 0,
+        Sha = 32772,
+    }
+    public interface IMessageFormatter : ICloneable {
+        bool CanRead(Message message);
+        object Read(Message message);
+        void Write(Message message, object obj);
+    }
+    public class Message : Component {
+        public static readonly TimeSpan InfiniteTimeout;
+        public Message();
+        public Message(object body);
+        public Message(object body, IMessageFormatter formatter);
+        public AcknowledgeTypes AcknowledgeType { get; set; }
+        public Acknowledgment Acknowledgment { get; }
+        public MessageQueue AdministrationQueue { get; set; }
+        public int AppSpecific { get; set; }
+        public DateTime ArrivedTime { get; }
+        public bool AttachSenderId { get; set; }
+        public bool Authenticated { get; }
+        public string AuthenticationProviderName { get; set; }
+        public CryptographicProviderType AuthenticationProviderType { get; set; }
+        public object Body { get; set; }
+        public Stream BodyStream { get; set; }
+        public int BodyType { get; set; }
+        public Guid ConnectorType { get; set; }
+        public string CorrelationId { get; set; }
+        public MessageQueue DestinationQueue { get; }
+        public byte[] DestinationSymmetricKey { get; set; }
+        public byte[] DigitalSignature { get; set; }
+        public EncryptionAlgorithm EncryptionAlgorithm { get; set; }
+        public byte[] Extension { get; set; }
+        public IMessageFormatter Formatter { get; set; }
+        public HashAlgorithm HashAlgorithm { get; set; }
+        public string Id { get; }
+        public bool IsFirstInTransaction { get; }
+        public bool IsLastInTransaction { get; }
+        public string Label { get; set; }
+        public long LookupId { get; }
+        public MessageType MessageType { get; }
+        public MessagePriority Priority { get; set; }
+        public bool Recoverable { get; set; }
+        public MessageQueue ResponseQueue { get; set; }
+        public SecurityContext SecurityContext { get; set; }
+        public byte[] SenderCertificate { get; set; }
+        public byte[] SenderId { get; }
+        public long SenderVersion { get; }
+        public DateTime SentTime { get; }
+        public string SourceMachine { get; }
+        public TimeSpan TimeToBeReceived { get; set; }
+        public TimeSpan TimeToReachQueue { get; set; }
+        public string TransactionId { get; }
+        public MessageQueue TransactionStatusQueue { get; set; }
+        public bool UseAuthentication { get; set; }
+        public bool UseDeadLetterQueue { get; set; }
+        public bool UseEncryption { get; set; }
+        public bool UseJournalQueue { get; set; }
+        public bool UseTracing { get; set; }
+    }
+    public class MessageEnumerator : MarshalByRefObject, IDisposable, IEnumerator {
+        public Message Current { get; }
+        public IntPtr CursorHandle { get; }
+        object System.Collections.IEnumerator.Current { get; }
+        public void Close();
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        public bool MoveNext();
+        public bool MoveNext(TimeSpan timeout);
+        public Message RemoveCurrent();
+        public Message RemoveCurrent(MessageQueueTransaction transaction);
+        public Message RemoveCurrent(MessageQueueTransactionType transactionType);
+        public Message RemoveCurrent(TimeSpan timeout);
+        public Message RemoveCurrent(TimeSpan timeout, MessageQueueTransaction transaction);
+        public Message RemoveCurrent(TimeSpan timeout, MessageQueueTransactionType transactionType);
+        public void Reset();
+    }
+    public enum MessageLookupAction {
+        Current = 0,
+        First = 4,
+        Last = 8,
+        Next = 1,
+        Previous = 2,
+    }
+    public enum MessagePriority {
+        AboveNormal = 4,
+        High = 5,
+        Highest = 7,
+        Low = 2,
+        Lowest = 0,
+        Normal = 3,
+        VeryHigh = 6,
+        VeryLow = 1,
+    }
+    public class MessagePropertyFilter : ICloneable {
+        public MessagePropertyFilter();
+        public bool AcknowledgeType { get; set; }
+        public bool Acknowledgment { get; set; }
+        public bool AdministrationQueue { get; set; }
+        public bool AppSpecific { get; set; }
+        public bool ArrivedTime { get; set; }
+        public bool AttachSenderId { get; set; }
+        public bool Authenticated { get; set; }
+        public bool AuthenticationProviderName { get; set; }
+        public bool AuthenticationProviderType { get; set; }
+        public bool Body { get; set; }
+        public bool ConnectorType { get; set; }
+        public bool CorrelationId { get; set; }
+        public int DefaultBodySize { get; set; }
+        public int DefaultExtensionSize { get; set; }
+        public int DefaultLabelSize { get; set; }
+        public bool DestinationQueue { get; set; }
+        public bool DestinationSymmetricKey { get; set; }
+        public bool DigitalSignature { get; set; }
+        public bool EncryptionAlgorithm { get; set; }
+        public bool Extension { get; set; }
+        public bool HashAlgorithm { get; set; }
+        public bool Id { get; set; }
+        public bool IsFirstInTransaction { get; set; }
+        public bool IsLastInTransaction { get; set; }
+        public bool Label { get; set; }
+        public bool LookupId { get; set; }
+        public bool MessageType { get; set; }
+        public bool Priority { get; set; }
+        public bool Recoverable { get; set; }
+        public bool ResponseQueue { get; set; }
+        public bool SenderCertificate { get; set; }
+        public bool SenderId { get; set; }
+        public bool SenderVersion { get; set; }
+        public bool SentTime { get; set; }
+        public bool SourceMachine { get; set; }
+        public bool TimeToBeReceived { get; set; }
+        public bool TimeToReachQueue { get; set; }
+        public bool TransactionId { get; set; }
+        public bool TransactionStatusQueue { get; set; }
+        public bool UseAuthentication { get; set; }
+        public bool UseDeadLetterQueue { get; set; }
+        public bool UseEncryption { get; set; }
+        public bool UseJournalQueue { get; set; }
+        public bool UseTracing { get; set; }
+        public void ClearAll();
+        public virtual object Clone();
+        public void SetAll();
+        public void SetDefaults();
+    }
+    public class MessageQueue : Component, IEnumerable {
+        public static readonly long InfiniteQueueSize;
+        public static readonly TimeSpan InfiniteTimeout;
+        public MessageQueue();
+        public MessageQueue(string path);
+        public MessageQueue(string path, bool sharedModeDenyReceive);
+        public MessageQueue(string path, bool sharedModeDenyReceive, bool enableCache);
+        public MessageQueue(string path, bool sharedModeDenyReceive, bool enableCache, QueueAccessMode accessMode);
+        public MessageQueue(string path, QueueAccessMode accessMode);
+        public QueueAccessMode AccessMode { get; }
+        public bool Authenticate { get; set; }
+        public short BasePriority { get; set; }
+        public bool CanRead { get; }
+        public bool CanWrite { get; }
+        public Guid Category { get; set; }
+        public DateTime CreateTime { get; }
+        public DefaultPropertiesToSend DefaultPropertiesToSend { get; set; }
+        public bool DenySharedReceive { get; set; }
+        public static bool EnableConnectionCache { get; set; }
+        public EncryptionRequired EncryptionRequired { get; set; }
+        public string FormatName { get; }
+        public IMessageFormatter Formatter { get; set; }
+        public Guid Id { get; }
+        public string Label { get; set; }
+        public DateTime LastModifyTime { get; }
+        public string MachineName { get; set; }
+        public long MaximumJournalSize { get; set; }
+        public long MaximumQueueSize { get; set; }
+        public MessagePropertyFilter MessageReadPropertyFilter { get; set; }
+        public string MulticastAddress { get; set; }
+        public string Path { get; set; }
+        public string QueueName { get; set; }
+        public IntPtr ReadHandle { get; }
+        public ISynchronizeInvoke SynchronizingObject { get; set; }
+        public bool Transactional { get; }
+        public bool UseJournalQueue { get; set; }
+        public IntPtr WriteHandle { get; }
+        public event PeekCompletedEventHandler PeekCompleted;
+        public event ReceiveCompletedEventHandler ReceiveCompleted;
+        public IAsyncResult BeginPeek();
+        public IAsyncResult BeginPeek(TimeSpan timeout);
+        public IAsyncResult BeginPeek(TimeSpan timeout, Cursor cursor, PeekAction action, object state, AsyncCallback callback);
+        public IAsyncResult BeginPeek(TimeSpan timeout, object stateObject);
+        public IAsyncResult BeginPeek(TimeSpan timeout, object stateObject, AsyncCallback callback);
+        public IAsyncResult BeginReceive();
+        public IAsyncResult BeginReceive(TimeSpan timeout);
+        public IAsyncResult BeginReceive(TimeSpan timeout, Cursor cursor, object state, AsyncCallback callback);
+        public IAsyncResult BeginReceive(TimeSpan timeout, object stateObject);
+        public IAsyncResult BeginReceive(TimeSpan timeout, object stateObject, AsyncCallback callback);
+        public static void ClearConnectionCache();
+        public void Close();
+        public static MessageQueue Create(string path);
+        public static MessageQueue Create(string path, bool transactional);
+        public Cursor CreateCursor();
+        public static void Delete(string path);
+        protected override void Dispose(bool disposing);
+        public Message EndPeek(IAsyncResult asyncResult);
+        public Message EndReceive(IAsyncResult asyncResult);
+        public static bool Exists(string path);
+        public Message[] GetAllMessages();
+        public IEnumerator GetEnumerator();
+        public static Guid GetMachineId(string machineName);
+        public MessageEnumerator GetMessageEnumerator();
+        public MessageEnumerator GetMessageEnumerator2();
+        public static MessageQueueEnumerator GetMessageQueueEnumerator();
+        public static MessageQueueEnumerator GetMessageQueueEnumerator(MessageQueueCriteria criteria);
+        public static MessageQueue[] GetPrivateQueuesByMachine(string machineName);
+        public static MessageQueue[] GetPublicQueues();
+        public static MessageQueue[] GetPublicQueues(MessageQueueCriteria criteria);
+        public static MessageQueue[] GetPublicQueuesByCategory(Guid category);
+        public static MessageQueue[] GetPublicQueuesByLabel(string label);
+        public static MessageQueue[] GetPublicQueuesByMachine(string machineName);
+        public static SecurityContext GetSecurityContext();
+        public Message Peek();
+        public Message Peek(TimeSpan timeout);
+        public Message Peek(TimeSpan timeout, Cursor cursor, PeekAction action);
+        public Message PeekByCorrelationId(string correlationId);
+        public Message PeekByCorrelationId(string correlationId, TimeSpan timeout);
+        public Message PeekById(string id);
+        public Message PeekById(string id, TimeSpan timeout);
+        public Message PeekByLookupId(long lookupId);
+        public Message PeekByLookupId(MessageLookupAction action, long lookupId);
+        public void Purge();
+        public Message Receive();
+        public Message Receive(MessageQueueTransaction transaction);
+        public Message Receive(MessageQueueTransactionType transactionType);
+        public Message Receive(TimeSpan timeout);
+        public Message Receive(TimeSpan timeout, Cursor cursor);
+        public Message Receive(TimeSpan timeout, Cursor cursor, MessageQueueTransaction transaction);
+        public Message Receive(TimeSpan timeout, Cursor cursor, MessageQueueTransactionType transactionType);
+        public Message Receive(TimeSpan timeout, MessageQueueTransaction transaction);
+        public Message Receive(TimeSpan timeout, MessageQueueTransactionType transactionType);
+        public Message ReceiveByCorrelationId(string correlationId);
+        public Message ReceiveByCorrelationId(string correlationId, MessageQueueTransaction transaction);
+        public Message ReceiveByCorrelationId(string correlationId, MessageQueueTransactionType transactionType);
+        public Message ReceiveByCorrelationId(string correlationId, TimeSpan timeout);
+        public Message ReceiveByCorrelationId(string correlationId, TimeSpan timeout, MessageQueueTransaction transaction);
+        public Message ReceiveByCorrelationId(string correlationId, TimeSpan timeout, MessageQueueTransactionType transactionType);
+        public Message ReceiveById(string id);
+        public Message ReceiveById(string id, MessageQueueTransaction transaction);
+        public Message ReceiveById(string id, MessageQueueTransactionType transactionType);
+        public Message ReceiveById(string id, TimeSpan timeout);
+        public Message ReceiveById(string id, TimeSpan timeout, MessageQueueTransaction transaction);
+        public Message ReceiveById(string id, TimeSpan timeout, MessageQueueTransactionType transactionType);
+        public Message ReceiveByLookupId(long lookupId);
+        public Message ReceiveByLookupId(MessageLookupAction action, long lookupId, MessageQueueTransaction transaction);
+        public Message ReceiveByLookupId(MessageLookupAction action, long lookupId, MessageQueueTransactionType transactionType);
+        public void Refresh();
+        public void ResetPermissions();
+        public void Send(object obj);
+        public void Send(object obj, MessageQueueTransaction transaction);
+        public void Send(object obj, MessageQueueTransactionType transactionType);
+        public void Send(object obj, string label);
+        public void Send(object obj, string label, MessageQueueTransaction transaction);
+        public void Send(object obj, string label, MessageQueueTransactionType transactionType);
+        public void SetPermissions(AccessControlList dacl);
+        public void SetPermissions(MessageQueueAccessControlEntry ace);
+        public void SetPermissions(string user, MessageQueueAccessRights rights);
+        public void SetPermissions(string user, MessageQueueAccessRights rights, AccessControlEntryType entryType);
+    }
+    public class MessageQueueAccessControlEntry : AccessControlEntry {
+        public MessageQueueAccessControlEntry(Trustee trustee, MessageQueueAccessRights rights);
+        public MessageQueueAccessControlEntry(Trustee trustee, MessageQueueAccessRights rights, AccessControlEntryType entryType);
+        public MessageQueueAccessRights MessageQueueAccessRights { get; set; }
+    }
+    public enum MessageQueueAccessRights {
+        ChangeQueuePermissions = 262144,
+        DeleteJournalMessage = 8,
+        DeleteMessage = 1,
+        DeleteQueue = 65536,
+        FullControl = 983103,
+        GenericRead = 131115,
+        GenericWrite = 131108,
+        GetQueuePermissions = 131072,
+        GetQueueProperties = 32,
+        PeekMessage = 2,
+        ReceiveJournalMessage = 10,
+        ReceiveMessage = 3,
+        SetQueueProperties = 16,
+        TakeQueueOwnership = 524288,
+        WriteMessage = 4,
+    }
+    public class MessageQueueCriteria {
+        public MessageQueueCriteria();
+        public Guid Category { get; set; }
+        public DateTime CreatedAfter { get; set; }
+        public DateTime CreatedBefore { get; set; }
+        public string Label { get; set; }
+        public string MachineName { get; set; }
+        public DateTime ModifiedAfter { get; set; }
+        public DateTime ModifiedBefore { get; set; }
+        public void ClearAll();
+    }
+    public class MessageQueueEnumerator : MarshalByRefObject, IDisposable, IEnumerator {
+        public MessageQueue Current { get; }
+        public IntPtr LocatorHandle { get; }
+        object System.Collections.IEnumerator.Current { get; }
+        public void Close();
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        public bool MoveNext();
+        public void Reset();
+    }
+    public enum MessageQueueErrorCode {
+        AccessDenied = -1072824283,
+        BadSecurityContext = -1072824267,
+        Base = -1072824320,
+        BufferOverflow = -1072824294,
+        CannotCreateCertificateStore = -1072824209,
+        CannotCreateHashEx = -1072824191,
+        CannotCreateOnGlobalCatalog = -1072824201,
+        CannotGetDistinguishedName = -1072824194,
+        CannotGrantAddGuid = -1072824206,
+        CannotHashDataEx = -1072824193,
+        CannotImpersonateClient = -1072824284,
+        CannotJoinDomain = -1072824202,
+        CannotLoadMsmqOcm = -1072824205,
+        CannotOpenCertificateStore = -1072824208,
+        CannotSetCryptographicSecurityDescriptor = -1072824212,
+        CannotSignDataEx = -1072824192,
+        CertificateNotProvided = -1072824211,
+        ComputerDoesNotSupportEncryption = -1072824269,
+        CorruptedInternalCertificate = -1072824275,
+        CorruptedPersonalCertStore = -1072824271,
+        CorruptedQueueWasDeleted = -1072824216,
+        CorruptedSecurityData = -1072824272,
+        CouldNotGetAccountInfo = -1072824265,
+        CouldNotGetUserSid = -1072824266,
+        DeleteConnectedNetworkInUse = -1072824248,
+        DependentClientLicenseOverflow = -1072824217,
+        DsError = -1072824253,
+        DsIsFull = -1072824254,
+        DtcConnect = -1072824244,
+        EncryptionProviderNotSupported = -1072824213,
+        FailVerifySignatureEx = -1072824190,
+        FormatNameBufferTooSmall = -1072824289,
+        Generic = -1072824319,
+        GuidNotMatching = -1072824200,
+        IllegalContext = -1072824229,
+        IllegalCriteriaColumns = -1072824264,
+        IllegalCursorAction = -1072824292,
+        IllegalEnterpriseOperation = -1072824207,
+        IllegalFormatName = -1072824290,
+        IllegalMessageProperties = -1072824255,
+        IllegalOperation = -1072824220,
+        IllegalPrivateProperties = -1072824197,
+        IllegalPropertyId = -1072824263,
+        IllegalPropertySize = -1072824261,
+        IllegalPropertyValue = -1072824296,
+        IllegalPropertyVt = -1072824295,
+        IllegalQueuePathName = -1072824300,
+        IllegalQueueProperties = -1072824259,
+        IllegalRelation = -1072824262,
+        IllegalRestrictionPropertyId = -1072824260,
+        IllegalSecurityDescriptor = -1072824287,
+        IllegalSort = -1072824304,
+        IllegalSortPropertyId = -1072824228,
+        IllegalUser = -1072824303,
+        InsufficientProperties = -1072824257,
+        InsufficientResources = -1072824281,
+        InvalidCertificate = -1072824276,
+        InvalidHandle = -1072824313,
+        InvalidOwner = -1072824252,
+        InvalidParameter = -1072824314,
+        IOTimeout = -1072824293,
+        LabelBufferTooSmall = -1072824226,
+        MachineExists = -1072824256,
+        MachineNotFound = -1072824307,
+        MessageAlreadyReceived = -1072824291,
+        MessageNotFound = -1072824184,
+        MessageStorageFailed = -1072824278,
+        MissingConnectorType = -1072824235,
+        MqisReadOnlyMode = -1072824224,
+        MqisServerEmpty = -1072824225,
+        NoDs = -1072824301,
+        NoEntryPointMsmqOcm = -1072824204,
+        NoGlobalCatalogInDomain = -1072824196,
+        NoInternalUserCertificate = -1072824273,
+        NoMsmqServersOnDc = -1072824203,
+        NoMsmqServersOnGlobalCatalog = -1072824195,
+        NoResponseFromObjectServer = -1072824247,
+        ObjectServerNotAvailable = -1072824246,
+        OperationCanceled = -1072824312,
+        PrivilegeNotHeld = -1072824282,
+        Property = -1072824318,
+        PropertyNotAllowed = -1072824258,
+        ProviderNameBufferTooSmall = -1072824221,
+        PublicKeyDoesNotExist = -1072824198,
+        PublicKeyNotFound = -1072824199,
+        QDnsPropertyNotSupported = -1072824210,
+        QueueDeleted = -1072824230,
+        QueueExists = -1072824315,
+        QueueNotAvailable = -1072824245,
+        QueueNotFound = -1072824317,
+        RemoteMachineNotAvailable = -1072824215,
+        ResultBufferTooSmall = -1072824250,
+        SecurityDescriptorBufferTooSmall = -1072824285,
+        SenderCertificateBufferTooSmall = -1072824277,
+        SenderIdBufferTooSmall = -1072824286,
+        ServiceNotAvailable = -1072824309,
+        SharingViolation = -1072824311,
+        SignatureBufferTooSmall = -1072824222,
+        StaleHandle = -1072824234,
+        SymmetricKeyBufferTooSmall = -1072824223,
+        TransactionEnlist = -1072824232,
+        TransactionImport = -1072824242,
+        TransactionSequence = -1072824239,
+        TransactionUsage = -1072824240,
+        UnsupportedAccessMode = -1072824251,
+        UnsupportedFormatNameOperation = -1072824288,
+        UnsupportedOperation = -1072824214,
+        UserBufferTooSmall = -1072824280,
+        WksCantServeClient = -1072824218,
+        WriteNotAllowed = -1072824219,
+    }
+    public class MessageQueueException : ExternalException, ISerializable {
+        protected MessageQueueException(SerializationInfo info, StreamingContext context);
+        public override string Message { get; }
+        public MessageQueueErrorCode MessageQueueErrorCode { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class MessageQueueInstaller : ComponentInstaller {
+        public MessageQueueInstaller();
+        public MessageQueueInstaller(MessageQueue componentToCopy);
+        public bool Authenticate { get; set; }
+        public short BasePriority { get; set; }
+        public Guid Category { get; set; }
+        public EncryptionRequired EncryptionRequired { get; set; }
+        public string Label { get; set; }
+        public long MaximumJournalSize { get; set; }
+        public long MaximumQueueSize { get; set; }
+        public string MulticastAddress { get; set; }
+        public string Path { get; set; }
+        public AccessControlList Permissions { get; set; }
+        public bool Transactional { get; set; }
+        public UninstallAction UninstallAction { get; set; }
+        public bool UseJournalQueue { get; set; }
+        public override void Commit(IDictionary savedState);
+        public override void CopyFromComponent(IComponent component);
+        public override void Install(IDictionary stateSaver);
+        public override bool IsEquivalentInstaller(ComponentInstaller otherInstaller);
+        public override void Rollback(IDictionary savedState);
+        public override void Uninstall(IDictionary savedState);
+    }
+    public sealed class MessageQueuePermission : CodeAccessPermission, IUnrestrictedPermission {
+        public MessageQueuePermission();
+        public MessageQueuePermission(MessageQueuePermissionAccess permissionAccess, string path);
+        public MessageQueuePermission(MessageQueuePermissionAccess permissionAccess, string machineName, string label, string category);
+        public MessageQueuePermission(MessageQueuePermissionEntry[] permissionAccessEntries);
+        public MessageQueuePermission(PermissionState state);
+        public MessageQueuePermissionEntryCollection PermissionEntries { get; }
+        public override IPermission Copy();
+        public override void FromXml(SecurityElement securityElement);
+        public override IPermission Intersect(IPermission target);
+        public override bool IsSubsetOf(IPermission target);
+        public bool IsUnrestricted();
+        public override SecurityElement ToXml();
+        public override IPermission Union(IPermission target);
+    }
+    public enum MessageQueuePermissionAccess {
+        Administer = 62,
+        Browse = 2,
+        None = 0,
+        Peek = 10,
+        Receive = 26,
+        Send = 6,
+    }
+    public class MessageQueuePermissionAttribute : CodeAccessSecurityAttribute {
+        public MessageQueuePermissionAttribute(SecurityAction action);
+        public string Category { get; set; }
+        public string Label { get; set; }
+        public string MachineName { get; set; }
+        public string Path { get; set; }
+        public MessageQueuePermissionAccess PermissionAccess { get; set; }
+        public override IPermission CreatePermission();
+    }
+    public class MessageQueuePermissionEntry {
+        public MessageQueuePermissionEntry(MessageQueuePermissionAccess permissionAccess, string path);
+        public MessageQueuePermissionEntry(MessageQueuePermissionAccess permissionAccess, string machineName, string label, string category);
+        public string Category { get; }
+        public string Label { get; }
+        public string MachineName { get; }
+        public string Path { get; }
+        public MessageQueuePermissionAccess PermissionAccess { get; }
+    }
+    public class MessageQueuePermissionEntryCollection : CollectionBase {
+        public MessageQueuePermissionEntry this[int index] { get; set; }
+        public int Add(MessageQueuePermissionEntry value);
+        public void AddRange(MessageQueuePermissionEntryCollection value);
+        public void AddRange(MessageQueuePermissionEntry[] value);
+        public bool Contains(MessageQueuePermissionEntry value);
+        public void CopyTo(MessageQueuePermissionEntry[] array, int index);
+        public int IndexOf(MessageQueuePermissionEntry value);
+        public void Insert(int index, MessageQueuePermissionEntry value);
+        protected override void OnClear();
+        protected override void OnInsert(int index, object value);
+        protected override void OnRemove(int index, object value);
+        protected override void OnSet(int index, object oldValue, object newValue);
+        public void Remove(MessageQueuePermissionEntry value);
+    }
+    public class MessageQueueTransaction : IDisposable {
+        public MessageQueueTransaction();
+        public MessageQueueTransactionStatus Status { get; }
+        public void Abort();
+        public void Begin();
+        public void Commit();
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        ~MessageQueueTransaction();
+    }
+    public enum MessageQueueTransactionStatus {
+        Aborted = 0,
+        Committed = 1,
+        Initialized = 2,
+        Pending = 3,
+    }
+    public enum MessageQueueTransactionType {
+        Automatic = 1,
+        None = 0,
+        Single = 3,
+    }
+    public enum MessageType {
+        Acknowledgment = 1,
+        Normal = 2,
+        Report = 3,
+    }
+    public class MessagingDescriptionAttribute : DescriptionAttribute {
+        public MessagingDescriptionAttribute(string description);
+        public override string Description { get; }
+    }
+    public enum PeekAction {
+        Current = -2147483648,
+        Next = -2147483647,
+    }
+    public class PeekCompletedEventArgs : EventArgs {
+        public IAsyncResult AsyncResult { get; set; }
+        public Message Message { get; }
+    }
+    public delegate void PeekCompletedEventHandler(object sender, PeekCompletedEventArgs e);
+    public enum QueueAccessMode {
+        Peek = 32,
+        PeekAndAdmin = 160,
+        Receive = 1,
+        ReceiveAndAdmin = 129,
+        Send = 2,
+        SendAndReceive = 3,
+    }
+    public class ReceiveCompletedEventArgs : EventArgs {
+        public IAsyncResult AsyncResult { get; set; }
+        public Message Message { get; }
+    }
+    public delegate void ReceiveCompletedEventHandler(object sender, ReceiveCompletedEventArgs e);
+    public sealed class SecurityContext : IDisposable {
+        public void Dispose();
+    }
+    public enum StandardAccessRights {
+        All = 2031616,
+        Delete = 65536,
+        Execute = 131072,
+        ModifyOwner = 524288,
+        None = 0,
+        Read = 131072,
+        ReadSecurity = 131072,
+        Required = 851968,
+        Synchronize = 1048576,
+        Write = 131072,
+        WriteSecurity = 262144,
+    }
+    public class Trustee {
+        public Trustee();
+        public Trustee(string name);
+        public Trustee(string name, string systemName);
+        public Trustee(string name, string systemName, TrusteeType trusteeType);
+        public string Name { get; set; }
+        public string SystemName { get; set; }
+        public TrusteeType TrusteeType { get; set; }
+    }
+    public enum TrusteeType {
+        Alias = 4,
+        Computer = 5,
+        Domain = 3,
+        Group = 2,
+        Unknown = 0,
+        User = 1,
+    }
+    public class XmlMessageFormatter : ICloneable, IMessageFormatter {
+        public XmlMessageFormatter();
+        public XmlMessageFormatter(string[] targetTypeNames);
+        public XmlMessageFormatter(Type[] targetTypes);
+        public string[] TargetTypeNames { get; set; }
+        public Type[] TargetTypes { get; set; }
+        public bool CanRead(Message message);
+        public object Clone();
+        public object Read(Message message);
+        public void Write(Message message, object obj);
+    }
+}
```

