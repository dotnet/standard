# System.Management

``` diff
+namespace System.Management {
+    public enum AuthenticationLevel {
+        Call = 3,
+        Connect = 2,
+        Default = 0,
+        None = 1,
+        Packet = 4,
+        PacketIntegrity = 5,
+        PacketPrivacy = 6,
+        Unchanged = -1,
+    }
+    public enum CimType {
+        Boolean = 11,
+        Char16 = 103,
+        DateTime = 101,
+        None = 0,
+        Object = 13,
+        Real32 = 4,
+        Real64 = 5,
+        Reference = 102,
+        SInt16 = 2,
+        SInt32 = 3,
+        SInt64 = 20,
+        SInt8 = 16,
+        String = 8,
+        UInt16 = 18,
+        UInt32 = 19,
+        UInt64 = 21,
+        UInt8 = 17,
+    }
+    public enum CodeLanguage {
+        CSharp = 0,
+        JScript = 1,
+        Mcpp = 4,
+        VB = 2,
+        VJSharp = 3,
+    }
+    public enum ComparisonSettings {
+        IgnoreCase = 16,
+        IgnoreClass = 8,
+        IgnoreDefaultValues = 4,
+        IgnoreFlavor = 32,
+        IgnoreObjectSource = 2,
+        IgnoreQualifiers = 1,
+        IncludeAll = 0,
+    }
+    public class CompletedEventArgs : ManagementEventArgs {
+        public ManagementStatus Status { get; }
+        public ManagementBaseObject StatusObject { get; }
+    }
+    public delegate void CompletedEventHandler(object sender, CompletedEventArgs e);
+    public class ConnectionOptions : ManagementOptions {
+        public ConnectionOptions();
+        public ConnectionOptions(string locale, string username, SecureString password, string authority, ImpersonationLevel impersonation, AuthenticationLevel authentication, bool enablePrivileges, ManagementNamedValueCollection context, TimeSpan timeout);
+        public ConnectionOptions(string locale, string username, string password, string authority, ImpersonationLevel impersonation, AuthenticationLevel authentication, bool enablePrivileges, ManagementNamedValueCollection context, TimeSpan timeout);
+        public AuthenticationLevel Authentication { get; set; }
+        public string Authority { get; set; }
+        public bool EnablePrivileges { get; set; }
+        public ImpersonationLevel Impersonation { get; set; }
+        public string Locale { get; set; }
+        public string Password { set; }
+        public SecureString SecurePassword { set; }
+        public string Username { get; set; }
+        public override object Clone();
+    }
+    public class DeleteOptions : ManagementOptions {
+        public DeleteOptions();
+        public DeleteOptions(ManagementNamedValueCollection context, TimeSpan timeout);
+        public override object Clone();
+    }
+    public class EnumerationOptions : ManagementOptions {
+        public EnumerationOptions();
+        public EnumerationOptions(ManagementNamedValueCollection context, TimeSpan timeout, int blockSize, bool rewindable, bool returnImmediatley, bool useAmendedQualifiers, bool ensureLocatable, bool prototypeOnly, bool directRead, bool enumerateDeep);
+        public int BlockSize { get; set; }
+        public bool DirectRead { get; set; }
+        public bool EnsureLocatable { get; set; }
+        public bool EnumerateDeep { get; set; }
+        public bool PrototypeOnly { get; set; }
+        public bool ReturnImmediately { get; set; }
+        public bool Rewindable { get; set; }
+        public bool UseAmendedQualifiers { get; set; }
+        public override object Clone();
+    }
+    public class EventArrivedEventArgs : ManagementEventArgs {
+        public ManagementBaseObject NewEvent { get; }
+    }
+    public delegate void EventArrivedEventHandler(object sender, EventArrivedEventArgs e);
+    public class EventQuery : ManagementQuery {
+        public EventQuery();
+        public EventQuery(string query);
+        public EventQuery(string language, string query);
+        public override object Clone();
+    }
+    public class EventWatcherOptions : ManagementOptions {
+        public EventWatcherOptions();
+        public EventWatcherOptions(ManagementNamedValueCollection context, TimeSpan timeout, int blockSize);
+        public int BlockSize { get; set; }
+        public override object Clone();
+    }
+    public enum ImpersonationLevel {
+        Anonymous = 1,
+        Default = 0,
+        Delegate = 4,
+        Identify = 2,
+        Impersonate = 3,
+    }
+    public class InvokeMethodOptions : ManagementOptions {
+        public InvokeMethodOptions();
+        public InvokeMethodOptions(ManagementNamedValueCollection context, TimeSpan timeout);
+        public override object Clone();
+    }
+    public class ManagementBaseObject : Component, ICloneable, ISerializable {
+        protected ManagementBaseObject(SerializationInfo info, StreamingContext context);
+        public virtual ManagementPath ClassPath { get; }
+        public virtual PropertyDataCollection Properties { get; }
+        public virtual QualifierDataCollection Qualifiers { get; }
+        public virtual PropertyDataCollection SystemProperties { get; }
+        public object this[string propertyName] { get; set; }
+        public virtual object Clone();
+        public bool CompareTo(ManagementBaseObject otherObject, ComparisonSettings settings);
+        public new void Dispose();
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        protected virtual void GetObjectData(SerializationInfo info, StreamingContext context);
+        public object GetPropertyQualifierValue(string propertyName, string qualifierName);
+        public object GetPropertyValue(string propertyName);
+        public object GetQualifierValue(string qualifierName);
+        public string GetText(TextFormat format);
+        public static explicit operator IntPtr (ManagementBaseObject managementObject);
+        public void SetPropertyQualifierValue(string propertyName, string qualifierName, object qualifierValue);
+        public void SetPropertyValue(string propertyName, object propertyValue);
+        public void SetQualifierValue(string qualifierName, object qualifierValue);
+        void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class ManagementClass : ManagementObject {
+        public ManagementClass();
+        public ManagementClass(ManagementPath path);
+        public ManagementClass(ManagementPath path, ObjectGetOptions options);
+        public ManagementClass(ManagementScope scope, ManagementPath path, ObjectGetOptions options);
+        protected ManagementClass(SerializationInfo info, StreamingContext context);
+        public ManagementClass(string path);
+        public ManagementClass(string path, ObjectGetOptions options);
+        public ManagementClass(string scope, string path, ObjectGetOptions options);
+        public StringCollection Derivation { get; }
+        public MethodDataCollection Methods { get; }
+        public override ManagementPath Path { get; set; }
+        public override object Clone();
+        public ManagementObject CreateInstance();
+        public ManagementClass Derive(string newClassName);
+        public ManagementObjectCollection GetInstances();
+        public ManagementObjectCollection GetInstances(EnumerationOptions options);
+        public void GetInstances(ManagementOperationObserver watcher);
+        public void GetInstances(ManagementOperationObserver watcher, EnumerationOptions options);
+        protected override void GetObjectData(SerializationInfo info, StreamingContext context);
+        public ManagementObjectCollection GetRelatedClasses();
+        public void GetRelatedClasses(ManagementOperationObserver watcher);
+        public void GetRelatedClasses(ManagementOperationObserver watcher, string relatedClass);
+        public void GetRelatedClasses(ManagementOperationObserver watcher, string relatedClass, string relationshipClass, string relationshipQualifier, string relatedQualifier, string relatedRole, string thisRole, EnumerationOptions options);
+        public ManagementObjectCollection GetRelatedClasses(string relatedClass);
+        public ManagementObjectCollection GetRelatedClasses(string relatedClass, string relationshipClass, string relationshipQualifier, string relatedQualifier, string relatedRole, string thisRole, EnumerationOptions options);
+        public ManagementObjectCollection GetRelationshipClasses();
+        public void GetRelationshipClasses(ManagementOperationObserver watcher);
+        public void GetRelationshipClasses(ManagementOperationObserver watcher, string relationshipClass);
+        public void GetRelationshipClasses(ManagementOperationObserver watcher, string relationshipClass, string relationshipQualifier, string thisRole, EnumerationOptions options);
+        public ManagementObjectCollection GetRelationshipClasses(string relationshipClass);
+        public ManagementObjectCollection GetRelationshipClasses(string relationshipClass, string relationshipQualifier, string thisRole, EnumerationOptions options);
+        public CodeTypeDeclaration GetStronglyTypedClassCode(bool includeSystemClassInClassDef, bool systemPropertyClass);
+        public bool GetStronglyTypedClassCode(CodeLanguage lang, string filePath, string classNamespace);
+        public ManagementObjectCollection GetSubclasses();
+        public ManagementObjectCollection GetSubclasses(EnumerationOptions options);
+        public void GetSubclasses(ManagementOperationObserver watcher);
+        public void GetSubclasses(ManagementOperationObserver watcher, EnumerationOptions options);
+    }
+    public sealed class ManagementDateTimeConverter {
+        public static DateTime ToDateTime(string dmtfDate);
+        public static string ToDmtfDateTime(DateTime date);
+        public static string ToDmtfTimeInterval(TimeSpan timespan);
+        public static TimeSpan ToTimeSpan(string dmtfTimespan);
+    }
+    public abstract class ManagementEventArgs : EventArgs {
+        public object Context { get; }
+    }
+    public class ManagementEventWatcher : Component {
+        public ManagementEventWatcher();
+        public ManagementEventWatcher(EventQuery query);
+        public ManagementEventWatcher(ManagementScope scope, EventQuery query);
+        public ManagementEventWatcher(ManagementScope scope, EventQuery query, EventWatcherOptions options);
+        public ManagementEventWatcher(string query);
+        public ManagementEventWatcher(string scope, string query);
+        public ManagementEventWatcher(string scope, string query, EventWatcherOptions options);
+        public EventWatcherOptions Options { get; set; }
+        public EventQuery Query { get; set; }
+        public ManagementScope Scope { get; set; }
+        public event EventArrivedEventHandler EventArrived;
+        public event StoppedEventHandler Stopped;
+        ~ManagementEventWatcher();
+        public void Start();
+        public void Stop();
+        public ManagementBaseObject WaitForNextEvent();
+    }
+    public class ManagementException : SystemException {
+        public ManagementException();
+        protected ManagementException(SerializationInfo info, StreamingContext context);
+        public ManagementException(string message);
+        public ManagementException(string message, Exception innerException);
+        public ManagementStatus ErrorCode { get; }
+        public ManagementBaseObject ErrorInformation { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public class ManagementNamedValueCollection : NameObjectCollectionBase {
+        public ManagementNamedValueCollection();
+        protected ManagementNamedValueCollection(SerializationInfo info, StreamingContext context);
+        public object this[string name] { get; }
+        public void Add(string name, object value);
+        public ManagementNamedValueCollection Clone();
+        public void Remove(string name);
+        public void RemoveAll();
+    }
+    public class ManagementObject : ManagementBaseObject, ICloneable {
+        public ManagementObject();
+        public ManagementObject(ManagementPath path);
+        public ManagementObject(ManagementPath path, ObjectGetOptions options);
+        public ManagementObject(ManagementScope scope, ManagementPath path, ObjectGetOptions options);
+        protected ManagementObject(SerializationInfo info, StreamingContext context);
+        public ManagementObject(string path);
+        public ManagementObject(string path, ObjectGetOptions options);
+        public ManagementObject(string scopeString, string pathString, ObjectGetOptions options);
+        public override ManagementPath ClassPath { get; }
+        public ObjectGetOptions Options { get; set; }
+        public virtual ManagementPath Path { get; set; }
+        public ManagementScope Scope { get; set; }
+        public override object Clone();
+        public void CopyTo(ManagementOperationObserver watcher, ManagementPath path);
+        public void CopyTo(ManagementOperationObserver watcher, ManagementPath path, PutOptions options);
+        public void CopyTo(ManagementOperationObserver watcher, string path);
+        public void CopyTo(ManagementOperationObserver watcher, string path, PutOptions options);
+        public ManagementPath CopyTo(ManagementPath path);
+        public ManagementPath CopyTo(ManagementPath path, PutOptions options);
+        public ManagementPath CopyTo(string path);
+        public ManagementPath CopyTo(string path, PutOptions options);
+        public void Delete();
+        public void Delete(DeleteOptions options);
+        public void Delete(ManagementOperationObserver watcher);
+        public void Delete(ManagementOperationObserver watcher, DeleteOptions options);
+        public new void Dispose();
+        public void Get();
+        public void Get(ManagementOperationObserver watcher);
+        public ManagementBaseObject GetMethodParameters(string methodName);
+        protected override void GetObjectData(SerializationInfo info, StreamingContext context);
+        public ManagementObjectCollection GetRelated();
+        public void GetRelated(ManagementOperationObserver watcher);
+        public void GetRelated(ManagementOperationObserver watcher, string relatedClass);
+        public void GetRelated(ManagementOperationObserver watcher, string relatedClass, string relationshipClass, string relationshipQualifier, string relatedQualifier, string relatedRole, string thisRole, bool classDefinitionsOnly, EnumerationOptions options);
+        public ManagementObjectCollection GetRelated(string relatedClass);
+        public ManagementObjectCollection GetRelated(string relatedClass, string relationshipClass, string relationshipQualifier, string relatedQualifier, string relatedRole, string thisRole, bool classDefinitionsOnly, EnumerationOptions options);
+        public ManagementObjectCollection GetRelationships();
+        public void GetRelationships(ManagementOperationObserver watcher);
+        public void GetRelationships(ManagementOperationObserver watcher, string relationshipClass);
+        public void GetRelationships(ManagementOperationObserver watcher, string relationshipClass, string relationshipQualifier, string thisRole, bool classDefinitionsOnly, EnumerationOptions options);
+        public ManagementObjectCollection GetRelationships(string relationshipClass);
+        public ManagementObjectCollection GetRelationships(string relationshipClass, string relationshipQualifier, string thisRole, bool classDefinitionsOnly, EnumerationOptions options);
+        public void InvokeMethod(ManagementOperationObserver watcher, string methodName, ManagementBaseObject inParameters, InvokeMethodOptions options);
+        public void InvokeMethod(ManagementOperationObserver watcher, string methodName, object[] args);
+        public ManagementBaseObject InvokeMethod(string methodName, ManagementBaseObject inParameters, InvokeMethodOptions options);
+        public object InvokeMethod(string methodName, object[] args);
+        public ManagementPath Put();
+        public void Put(ManagementOperationObserver watcher);
+        public void Put(ManagementOperationObserver watcher, PutOptions options);
+        public ManagementPath Put(PutOptions options);
+        public override string ToString();
+    }
+    public class ManagementObjectCollection : ICollection, IDisposable, IEnumerable {
+        public int Count { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        public void CopyTo(Array array, int index);
+        public void CopyTo(ManagementBaseObject[] objectCollection, int index);
+        public void Dispose();
+        ~ManagementObjectCollection();
+        public ManagementObjectCollection.ManagementObjectEnumerator GetEnumerator();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        public class ManagementObjectEnumerator : IDisposable, IEnumerator {
+            public ManagementBaseObject Current { get; }
+            object System.Collections.IEnumerator.Current { get; }
+            public void Dispose();
+            ~ManagementObjectEnumerator();
+            public bool MoveNext();
+            public void Reset();
+        }
+    }
+    public class ManagementObjectSearcher : Component {
+        public ManagementObjectSearcher();
+        public ManagementObjectSearcher(ManagementScope scope, ObjectQuery query);
+        public ManagementObjectSearcher(ManagementScope scope, ObjectQuery query, EnumerationOptions options);
+        public ManagementObjectSearcher(ObjectQuery query);
+        public ManagementObjectSearcher(string queryString);
+        public ManagementObjectSearcher(string scope, string queryString);
+        public ManagementObjectSearcher(string scope, string queryString, EnumerationOptions options);
+        public EnumerationOptions Options { get; set; }
+        public ObjectQuery Query { get; set; }
+        public ManagementScope Scope { get; set; }
+        public ManagementObjectCollection Get();
+        public void Get(ManagementOperationObserver watcher);
+    }
+    public class ManagementOperationObserver {
+        public ManagementOperationObserver();
+        public event CompletedEventHandler Completed;
+        public event ObjectPutEventHandler ObjectPut;
+        public event ObjectReadyEventHandler ObjectReady;
+        public event ProgressEventHandler Progress;
+        public void Cancel();
+    }
+    public abstract class ManagementOptions : ICloneable {
+        public static readonly TimeSpan InfiniteTimeout;
+        public ManagementNamedValueCollection Context { get; set; }
+        public TimeSpan Timeout { get; set; }
+        public abstract object Clone();
+    }
+    public class ManagementPath : ICloneable {
+        public ManagementPath();
+        public ManagementPath(string path);
+        public string ClassName { get; set; }
+        public static ManagementPath DefaultPath { get; set; }
+        public bool IsClass { get; }
+        public bool IsInstance { get; }
+        public bool IsSingleton { get; }
+        public string NamespacePath { get; set; }
+        public string Path { get; set; }
+        public string RelativePath { get; set; }
+        public string Server { get; set; }
+        public ManagementPath Clone();
+        public void SetAsClass();
+        public void SetAsSingleton();
+        object System.ICloneable.Clone();
+        public override string ToString();
+    }
+    public abstract class ManagementQuery : ICloneable {
+        public virtual string QueryLanguage { get; set; }
+        public virtual string QueryString { get; set; }
+        public abstract object Clone();
+        protected internal virtual void ParseQuery(string query);
+    }
+    public class ManagementScope : ICloneable {
+        public ManagementScope();
+        public ManagementScope(ManagementPath path);
+        public ManagementScope(ManagementPath path, ConnectionOptions options);
+        public ManagementScope(string path);
+        public ManagementScope(string path, ConnectionOptions options);
+        public bool IsConnected { get; }
+        public ConnectionOptions Options { get; set; }
+        public ManagementPath Path { get; set; }
+        public ManagementScope Clone();
+        public void Connect();
+        object System.ICloneable.Clone();
+    }
+    public enum ManagementStatus {
+        AccessDenied = -2147217405,
+        AggregatingByObject = -2147217315,
+        AlreadyExists = -2147217383,
+        AmendedObject = -2147217306,
+        BackupRestoreWinmgmtRunning = -2147217312,
+        BufferTooSmall = -2147217348,
+        CallCanceled = -2147217358,
+        CannotBeAbstract = -2147217307,
+        CannotBeKey = -2147217377,
+        CannotBeSingleton = -2147217364,
+        CannotChangeIndexInheritance = -2147217328,
+        CannotChangeKeyInheritance = -2147217335,
+        CircularReference = -2147217337,
+        ClassHasChildren = -2147217371,
+        ClassHasInstances = -2147217370,
+        ClientTooSlow = -2147217305,
+        CriticalError = -2147217398,
+        Different = 262147,
+        DuplicateObjects = 262152,
+        Failed = -2147217407,
+        False = 1,
+        IllegalNull = -2147217368,
+        IllegalOperation = -2147217378,
+        IncompleteClass = -2147217376,
+        InitializationFailure = -2147217388,
+        InvalidCimType = -2147217363,
+        InvalidClass = -2147217392,
+        InvalidContext = -2147217401,
+        InvalidDuplicateParameter = -2147217341,
+        InvalidFlavor = -2147217338,
+        InvalidMethod = -2147217362,
+        InvalidMethodParameters = -2147217361,
+        InvalidNamespace = -2147217394,
+        InvalidObject = -2147217393,
+        InvalidObjectPath = -2147217350,
+        InvalidOperation = -2147217386,
+        InvalidOperator = -2147217309,
+        InvalidParameter = -2147217400,
+        InvalidParameterID = -2147217353,
+        InvalidProperty = -2147217359,
+        InvalidPropertyType = -2147217366,
+        InvalidProviderRegistration = -2147217390,
+        InvalidQualifier = -2147217342,
+        InvalidQualifierType = -2147217367,
+        InvalidQuery = -2147217385,
+        InvalidQueryType = -2147217384,
+        InvalidStream = -2147217397,
+        InvalidSuperclass = -2147217395,
+        InvalidSyntax = -2147217375,
+        LocalCredentials = -2147217308,
+        MarshalInvalidSignature = -2147217343,
+        MarshalVersionMismatch = -2147217344,
+        MethodDisabled = -2147217322,
+        MethodNotImplemented = -2147217323,
+        MissingAggregationList = -2147217317,
+        MissingGroupWithin = -2147217318,
+        MissingParameterID = -2147217354,
+        NoError = 0,
+        NoMoreData = 262149,
+        NonconsecutiveParameterIDs = -2147217352,
+        NondecoratedObject = -2147217374,
+        NotAvailable = -2147217399,
+        NotEventClass = -2147217319,
+        NotFound = -2147217406,
+        NotSupported = -2147217396,
+        OperationCanceled = 262150,
+        OutOfDiskSpace = -2147217349,
+        OutOfMemory = -2147217402,
+        OverrideNotAllowed = -2147217382,
+        ParameterIDOnRetval = -2147217351,
+        PartialResults = 262160,
+        Pending = 262151,
+        PrivilegeNotHeld = -2147217310,
+        PropagatedMethod = -2147217356,
+        PropagatedProperty = -2147217380,
+        PropagatedQualifier = -2147217381,
+        PropertyNotAnObject = -2147217316,
+        ProviderFailure = -2147217404,
+        ProviderLoadFailure = -2147217389,
+        ProviderNotCapable = -2147217372,
+        ProviderNotFound = -2147217391,
+        QueryNotImplemented = -2147217369,
+        QueueOverflow = -2147217311,
+        ReadOnly = -2147217373,
+        RefresherBusy = -2147217321,
+        RegistrationTooBroad = -2147213311,
+        RegistrationTooPrecise = -2147213310,
+        ResetToDefault = 262146,
+        ServerTooBusy = -2147217339,
+        ShuttingDown = -2147217357,
+        SystemProperty = -2147217360,
+        Timedout = 262148,
+        TooManyProperties = -2147217327,
+        TooMuchData = -2147217340,
+        TransportFailure = -2147217387,
+        TypeMismatch = -2147217403,
+        Unexpected = -2147217379,
+        UninterpretableProviderQuery = -2147217313,
+        UnknownObjectType = -2147217346,
+        UnknownPacketType = -2147217345,
+        UnparsableQuery = -2147217320,
+        UnsupportedClassUpdate = -2147217336,
+        UnsupportedParameter = -2147217355,
+        UnsupportedPutExtension = -2147217347,
+        UpdateOverrideNotAllowed = -2147217325,
+        UpdatePropagatedMethod = -2147217324,
+        UpdateTypeMismatch = -2147217326,
+        ValueOutOfRange = -2147217365,
+    }
+    public class MethodData {
+        public ManagementBaseObject InParameters { get; }
+        public string Name { get; }
+        public string Origin { get; }
+        public ManagementBaseObject OutParameters { get; }
+        public QualifierDataCollection Qualifiers { get; }
+    }
+    public class MethodDataCollection : ICollection, IEnumerable {
+        public int Count { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        public virtual MethodData this[string methodName] { get; }
+        public virtual void Add(string methodName);
+        public virtual void Add(string methodName, ManagementBaseObject inParameters, ManagementBaseObject outParameters);
+        public void CopyTo(Array array, int index);
+        public void CopyTo(MethodData[] methodArray, int index);
+        public MethodDataCollection.MethodDataEnumerator GetEnumerator();
+        public virtual void Remove(string methodName);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        public class MethodDataEnumerator : IEnumerator {
+            public MethodData Current { get; }
+            object System.Collections.IEnumerator.Current { get; }
+            public bool MoveNext();
+            public void Reset();
+        }
+    }
+    public class ObjectGetOptions : ManagementOptions {
+        public ObjectGetOptions();
+        public ObjectGetOptions(ManagementNamedValueCollection context);
+        public ObjectGetOptions(ManagementNamedValueCollection context, TimeSpan timeout, bool useAmendedQualifiers);
+        public bool UseAmendedQualifiers { get; set; }
+        public override object Clone();
+    }
+    public class ObjectPutEventArgs : ManagementEventArgs {
+        public ManagementPath Path { get; }
+    }
+    public delegate void ObjectPutEventHandler(object sender, ObjectPutEventArgs e);
+    public class ObjectQuery : ManagementQuery {
+        public ObjectQuery();
+        public ObjectQuery(string query);
+        public ObjectQuery(string language, string query);
+        public override object Clone();
+    }
+    public class ObjectReadyEventArgs : ManagementEventArgs {
+        public ManagementBaseObject NewObject { get; }
+    }
+    public delegate void ObjectReadyEventHandler(object sender, ObjectReadyEventArgs e);
+    public class ProgressEventArgs : ManagementEventArgs {
+        public int Current { get; }
+        public string Message { get; }
+        public int UpperBound { get; }
+    }
+    public delegate void ProgressEventHandler(object sender, ProgressEventArgs e);
+    public class PropertyData {
+        public bool IsArray { get; }
+        public bool IsLocal { get; }
+        public string Name { get; }
+        public string Origin { get; }
+        public QualifierDataCollection Qualifiers { get; }
+        public CimType Type { get; }
+        public object Value { get; set; }
+    }
+    public class PropertyDataCollection : ICollection, IEnumerable {
+        public int Count { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        public virtual PropertyData this[string propertyName] { get; }
+        public void Add(string propertyName, CimType propertyType, bool isArray);
+        public virtual void Add(string propertyName, object propertyValue);
+        public void Add(string propertyName, object propertyValue, CimType propertyType);
+        public void CopyTo(Array array, int index);
+        public void CopyTo(PropertyData[] propertyArray, int index);
+        public PropertyDataCollection.PropertyDataEnumerator GetEnumerator();
+        public virtual void Remove(string propertyName);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        public class PropertyDataEnumerator : IEnumerator {
+            public PropertyData Current { get; }
+            object System.Collections.IEnumerator.Current { get; }
+            public bool MoveNext();
+            public void Reset();
+        }
+    }
+    public class PutOptions : ManagementOptions {
+        public PutOptions();
+        public PutOptions(ManagementNamedValueCollection context);
+        public PutOptions(ManagementNamedValueCollection context, TimeSpan timeout, bool useAmendedQualifiers, PutType putType);
+        public PutType Type { get; set; }
+        public bool UseAmendedQualifiers { get; set; }
+        public override object Clone();
+    }
+    public enum PutType {
+        CreateOnly = 2,
+        None = 0,
+        UpdateOnly = 1,
+        UpdateOrCreate = 3,
+    }
+    public class QualifierData {
+        public bool IsAmended { get; set; }
+        public bool IsLocal { get; }
+        public bool IsOverridable { get; set; }
+        public string Name { get; }
+        public bool PropagatesToInstance { get; set; }
+        public bool PropagatesToSubclass { get; set; }
+        public object Value { get; set; }
+    }
+    public class QualifierDataCollection : ICollection, IEnumerable {
+        public int Count { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        public virtual QualifierData this[string qualifierName] { get; }
+        public virtual void Add(string qualifierName, object qualifierValue);
+        public virtual void Add(string qualifierName, object qualifierValue, bool isAmended, bool propagatesToInstance, bool propagatesToSubclass, bool isOverridable);
+        public void CopyTo(Array array, int index);
+        public void CopyTo(QualifierData[] qualifierArray, int index);
+        public QualifierDataCollection.QualifierDataEnumerator GetEnumerator();
+        public virtual void Remove(string qualifierName);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        public class QualifierDataEnumerator : IEnumerator {
+            public QualifierData Current { get; }
+            object System.Collections.IEnumerator.Current { get; }
+            public bool MoveNext();
+            public void Reset();
+        }
+    }
+    public class RelatedObjectQuery : WqlObjectQuery {
+        public RelatedObjectQuery();
+        public RelatedObjectQuery(bool isSchemaQuery, string sourceObject, string relatedClass, string relationshipClass, string relatedQualifier, string relationshipQualifier, string relatedRole, string thisRole);
+        public RelatedObjectQuery(string queryOrSourceObject);
+        public RelatedObjectQuery(string sourceObject, string relatedClass);
+        public RelatedObjectQuery(string sourceObject, string relatedClass, string relationshipClass, string relatedQualifier, string relationshipQualifier, string relatedRole, string thisRole, bool classDefinitionsOnly);
+        public bool ClassDefinitionsOnly { get; set; }
+        public bool IsSchemaQuery { get; set; }
+        public string RelatedClass { get; set; }
+        public string RelatedQualifier { get; set; }
+        public string RelatedRole { get; set; }
+        public string RelationshipClass { get; set; }
+        public string RelationshipQualifier { get; set; }
+        public string SourceObject { get; set; }
+        public string ThisRole { get; set; }
+        protected internal void BuildQuery();
+        public override object Clone();
+        protected internal override void ParseQuery(string query);
+    }
+    public class RelationshipQuery : WqlObjectQuery {
+        public RelationshipQuery();
+        public RelationshipQuery(bool isSchemaQuery, string sourceObject, string relationshipClass, string relationshipQualifier, string thisRole);
+        public RelationshipQuery(string queryOrSourceObject);
+        public RelationshipQuery(string sourceObject, string relationshipClass);
+        public RelationshipQuery(string sourceObject, string relationshipClass, string relationshipQualifier, string thisRole, bool classDefinitionsOnly);
+        public bool ClassDefinitionsOnly { get; set; }
+        public bool IsSchemaQuery { get; set; }
+        public string RelationshipClass { get; set; }
+        public string RelationshipQualifier { get; set; }
+        public string SourceObject { get; set; }
+        public string ThisRole { get; set; }
+        protected internal void BuildQuery();
+        public override object Clone();
+        protected internal override void ParseQuery(string query);
+    }
+    public class SelectQuery : WqlObjectQuery {
+        public SelectQuery();
+        public SelectQuery(bool isSchemaQuery, string condition);
+        public SelectQuery(string queryOrClassName);
+        public SelectQuery(string className, string condition);
+        public SelectQuery(string className, string condition, string[] selectedProperties);
+        public string ClassName { get; set; }
+        public string Condition { get; set; }
+        public bool IsSchemaQuery { get; set; }
+        public override string QueryString { get; set; }
+        public StringCollection SelectedProperties { get; set; }
+        protected internal void BuildQuery();
+        public override object Clone();
+        protected internal override void ParseQuery(string query);
+    }
+    public class StoppedEventArgs : ManagementEventArgs {
+        public ManagementStatus Status { get; }
+    }
+    public delegate void StoppedEventHandler(object sender, StoppedEventArgs e);
+    public enum TextFormat {
+        CimDtd20 = 1,
+        Mof = 0,
+        WmiDtd20 = 2,
+    }
+    public class WqlEventQuery : EventQuery {
+        public WqlEventQuery();
+        public WqlEventQuery(string queryOrEventClassName);
+        public WqlEventQuery(string eventClassName, string condition);
+        public WqlEventQuery(string eventClassName, string condition, TimeSpan groupWithinInterval);
+        public WqlEventQuery(string eventClassName, string condition, TimeSpan groupWithinInterval, string[] groupByPropertyList);
+        public WqlEventQuery(string eventClassName, TimeSpan withinInterval);
+        public WqlEventQuery(string eventClassName, TimeSpan withinInterval, string condition);
+        public WqlEventQuery(string eventClassName, TimeSpan withinInterval, string condition, TimeSpan groupWithinInterval, string[] groupByPropertyList, string havingCondition);
+        public string Condition { get; set; }
+        public string EventClassName { get; set; }
+        public StringCollection GroupByPropertyList { get; set; }
+        public TimeSpan GroupWithinInterval { get; set; }
+        public string HavingCondition { get; set; }
+        public override string QueryLanguage { get; }
+        public override string QueryString { get; set; }
+        public TimeSpan WithinInterval { get; set; }
+        protected internal void BuildQuery();
+        public override object Clone();
+        protected internal override void ParseQuery(string query);
+    }
+    public class WqlObjectQuery : ObjectQuery {
+        public WqlObjectQuery();
+        public WqlObjectQuery(string query);
+        public override string QueryLanguage { get; }
+        public override object Clone();
+    }
+}
```

