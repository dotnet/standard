/*
APIs removed/broken by this factoring:

    public static partial class Directory
    {
//ACLS        public static System.IO.DirectoryInfo CreateDirectory(string path, System.Security.AccessControl.DirectorySecurity directorySecurity) { throw null; }
//ACLS        public static System.Security.AccessControl.DirectorySecurity GetAccessControl(string path) { throw null; }
//ACLS        public static System.Security.AccessControl.DirectorySecurity GetAccessControl(string path, System.Security.AccessControl.AccessControlSections includeSections) { throw null; }
//ACLS        public static void SetAccessControl(string path, System.Security.AccessControl.DirectorySecurity directorySecurity) { }
    }
    public sealed partial class DirectoryInfo : System.IO.FileSystemInfo
    {
//ACLS        public void Create(System.Security.AccessControl.DirectorySecurity directorySecurity) { }
//ACLS        public System.IO.DirectoryInfo CreateSubdirectory(string path, System.Security.AccessControl.DirectorySecurity directorySecurity) { throw null; }
//ACLS        public System.Security.AccessControl.DirectorySecurity GetAccessControl() { throw null; }
//ACLS        public System.Security.AccessControl.DirectorySecurity GetAccessControl(System.Security.AccessControl.AccessControlSections includeSections) { throw null; }
//ACLS        public void SetAccessControl(System.Security.AccessControl.DirectorySecurity directorySecurity) { }
    }
    public static partial class File
    {
//ACLS        public static System.IO.FileStream Create(string path, int bufferSize, System.IO.FileOptions options, System.Security.AccessControl.FileSecurity fileSecurity) { throw null; }
//ACLS        public static System.Security.AccessControl.FileSecurity GetAccessControl(string path) { throw null; }
//ACLS        public static System.Security.AccessControl.FileSecurity GetAccessControl(string path, System.Security.AccessControl.AccessControlSections includeSections) { throw null; }
//ACLS        public static void SetAccessControl(string path, System.Security.AccessControl.FileSecurity fileSecurity) { }
    }
    public sealed partial class FileInfo : System.IO.FileSystemInfo
    {
//ACLS        public System.Security.AccessControl.FileSecurity GetAccessControl() { throw null; }
//ACLS        public System.Security.AccessControl.FileSecurity GetAccessControl(System.Security.AccessControl.AccessControlSections includeSections) { throw null; }
//ACLS        public void SetAccessControl(System.Security.AccessControl.FileSecurity fileSecurity) { }
    }
    public partial class FileStream : System.IO.Stream
    {
//ACLS        public FileStream(string path, System.IO.FileMode mode, System.Security.AccessControl.FileSystemRights rights, System.IO.FileShare share, int bufferSize, System.IO.FileOptions options) { }
//ACLS        public FileStream(string path, System.IO.FileMode mode, System.Security.AccessControl.FileSystemRights rights, System.IO.FileShare share, int bufferSize, System.IO.FileOptions options, System.Security.AccessControl.FileSecurity fileSecurity) { }
//ACLS        public System.Security.AccessControl.FileSecurity GetAccessControl() { throw null; }
//ACLS        public void SetAccessControl(System.Security.AccessControl.FileSecurity fileSecurity) { }
    }
    public sealed partial class CspKeyContainerInfo
    {
//ACLS        public System.Security.AccessControl.CryptoKeySecurity CryptoKeySecurity { get { throw null; } }
    }
    public sealed partial class CspParameters
    {
//ACLS        public CspParameters(int providerType, string providerName, string keyContainerName, System.Security.AccessControl.CryptoKeySecurity cryptoKeySecurity, System.IntPtr parentWindowHandle) { }
//ACLS        public CspParameters(int providerType, string providerName, string keyContainerName, System.Security.AccessControl.CryptoKeySecurity cryptoKeySecurity, System.Security.SecureString keyPassword) { }
//ACLS        public System.Security.AccessControl.CryptoKeySecurity CryptoKeySecurity { get { throw null; } set { } }
    }
    public partial class EventWaitHandle : System.Threading.WaitHandle
    {
//ACLS        public EventWaitHandle(bool initialState, System.Threading.EventResetMode mode, string name, out bool createdNew, System.Security.AccessControl.EventWaitHandleSecurity eventSecurity) { createdNew = default(bool); }
//ACLS        public System.Security.AccessControl.EventWaitHandleSecurity GetAccessControl() { throw null; }
//ACLS        public static System.Threading.EventWaitHandle OpenExisting(string name, System.Security.AccessControl.EventWaitHandleRights rights) { throw null; }
//ACLS        public void SetAccessControl(System.Security.AccessControl.EventWaitHandleSecurity eventSecurity) { }
//ACLS        public static bool TryOpenExisting(string name, System.Security.AccessControl.EventWaitHandleRights rights, out System.Threading.EventWaitHandle result) { result = default(System.Threading.EventWaitHandle); throw null; }
    }
    public sealed partial class Mutex : System.Threading.WaitHandle
    {
//ACLS        public Mutex(bool initiallyOwned, string name, out bool createdNew, System.Security.AccessControl.MutexSecurity mutexSecurity) { createdNew = default(bool); }
//ACLS        public System.Security.AccessControl.MutexSecurity GetAccessControl() { throw null; }
//ACLS        public static System.Threading.Mutex OpenExisting(string name, System.Security.AccessControl.MutexRights rights) { throw null; }
//ACLS        public void SetAccessControl(System.Security.AccessControl.MutexSecurity mutexSecurity) { }
//ACLS        public static bool TryOpenExisting(string name, System.Security.AccessControl.MutexRights rights, out System.Threading.Mutex result) { result = default(System.Threading.Mutex); throw null; }
    }
    public sealed partial class Semaphore : System.Threading.WaitHandle
    {
//ACLS        public Semaphore(int initialCount, int maximumCount, string name, out bool createdNew, System.Security.AccessControl.SemaphoreSecurity semaphoreSecurity) { createdNew = default(bool); }
//ACLS        public System.Security.AccessControl.SemaphoreSecurity GetAccessControl() { throw null; }
//ACLS        public static System.Threading.Semaphore OpenExisting(string name, System.Security.AccessControl.SemaphoreRights rights) { throw null; }
//ACLS        public void SetAccessControl(System.Security.AccessControl.SemaphoreSecurity semaphoreSecurity) { }
//ACLS        public static bool TryOpenExisting(string name, System.Security.AccessControl.SemaphoreRights rights, out System.Threading.Semaphore result) { result = default(System.Threading.Semaphore); throw null; }
    }
    public partial class MemoryMappedFile : System.IDisposable
    {
//ACLS        public static System.IO.MemoryMappedFiles.MemoryMappedFile CreateFromFile(System.IO.FileStream fileStream, string mapName, long capacity, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access, System.IO.MemoryMappedFiles.MemoryMappedFileSecurity memoryMappedFileSecurity, System.IO.HandleInheritability inheritability, bool leaveOpen) { throw null; }
//ACLS        public static System.IO.MemoryMappedFiles.MemoryMappedFile CreateNew(string mapName, long capacity, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access, System.IO.MemoryMappedFiles.MemoryMappedFileOptions options, System.IO.MemoryMappedFiles.MemoryMappedFileSecurity memoryMappedFileSecurity, System.IO.HandleInheritability inheritability) { throw null; }
//ACLS        public static System.IO.MemoryMappedFiles.MemoryMappedFile CreateOrOpen(string mapName, long capacity, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access, System.IO.MemoryMappedFiles.MemoryMappedFileOptions options, System.IO.MemoryMappedFiles.MemoryMappedFileSecurity memoryMappedFileSecurity, System.IO.HandleInheritability inheritability) { throw null; }
//ACLS        public System.IO.MemoryMappedFiles.MemoryMappedFileSecurity GetAccessControl() { throw null; }
//ACLS        public void SetAccessControl(System.IO.MemoryMappedFiles.MemoryMappedFileSecurity memoryMappedFileSecurity) { }
    }
    public sealed partial class AnonymousPipeServerStream : System.IO.Pipes.PipeStream
    {
//ACLS        public AnonymousPipeServerStream(System.IO.Pipes.PipeDirection direction, System.IO.HandleInheritability inheritability, int bufferSize, System.IO.Pipes.PipeSecurity pipeSecurity) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    }
    public sealed partial class NamedPipeClientStream : System.IO.Pipes.PipeStream
    {
//ACLS        public NamedPipeClientStream(string serverName, string pipeName, System.IO.Pipes.PipeAccessRights desiredAccessRights, System.IO.Pipes.PipeOptions options, System.Security.Principal.TokenImpersonationLevel impersonationLevel, System.IO.HandleInheritability inheritability) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    }
    public sealed partial class NamedPipeServerStream : System.IO.Pipes.PipeStream
    {
//ACLS        public NamedPipeServerStream(string pipeName, System.IO.Pipes.PipeDirection direction, int maxNumberOfServerInstances, System.IO.Pipes.PipeTransmissionMode transmissionMode, System.IO.Pipes.PipeOptions options, int inBufferSize, int outBufferSize, System.IO.Pipes.PipeSecurity pipeSecurity) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
//ACLS        public NamedPipeServerStream(string pipeName, System.IO.Pipes.PipeDirection direction, int maxNumberOfServerInstances, System.IO.Pipes.PipeTransmissionMode transmissionMode, System.IO.Pipes.PipeOptions options, int inBufferSize, int outBufferSize, System.IO.Pipes.PipeSecurity pipeSecurity, System.IO.HandleInheritability inheritability) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
//ACLS        public NamedPipeServerStream(string pipeName, System.IO.Pipes.PipeDirection direction, int maxNumberOfServerInstances, System.IO.Pipes.PipeTransmissionMode transmissionMode, System.IO.Pipes.PipeOptions options, int inBufferSize, int outBufferSize, System.IO.Pipes.PipeSecurity pipeSecurity, System.IO.HandleInheritability inheritability, System.IO.Pipes.PipeAccessRights additionalAccessRights) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    }
    public abstract partial class PipeStream : System.IO.Stream
    {
//ACLS        public System.IO.Pipes.PipeSecurity GetAccessControl() { throw null; }
//ACLS        public void SetAccessControl(System.IO.Pipes.PipeSecurity pipeSecurity) { }
    }

*/
namespace System.Security.AccessControl
{
    [System.FlagsAttribute]
    public enum AccessControlActions
    {
        Change = 2,
        None = 0,
        View = 1,
    }
    public enum AccessControlModification
    {
        Add = 0,
        Remove = 3,
        RemoveAll = 4,
        RemoveSpecific = 5,
        Reset = 2,
        Set = 1,
    }
    [System.FlagsAttribute]
    public enum AccessControlSections
    {
        Access = 2,
        All = 15,
        Audit = 1,
        Group = 8,
        None = 0,
        Owner = 4,
    }
    public enum AccessControlType
    {
        Allow = 0,
        Deny = 1,
    }
    public abstract partial class AccessRule : System.Security.AccessControl.AuthorizationRule
    {
        protected AccessRule(System.Security.Principal.IdentityReference identity, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags)) { }
        public System.Security.AccessControl.AccessControlType AccessControlType { get { throw null; } }
    }
    public partial class AccessRule<T> : System.Security.AccessControl.AccessRule where T : struct
    {
        public AccessRule(System.Security.Principal.IdentityReference identity, T rights, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
        public AccessRule(System.Security.Principal.IdentityReference identity, T rights, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
        public AccessRule(string identity, T rights, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
        public AccessRule(string identity, T rights, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
        public T Rights { get { throw null; } }
    }
    public sealed partial class AceEnumerator : System.Collections.IEnumerator
    {
        internal AceEnumerator() { }
        public System.Security.AccessControl.GenericAce Current { get { throw null; } }
        object System.Collections.IEnumerator.Current { get { throw null; } }
        public bool MoveNext() { throw null; }
        public void Reset() { }
    }
    [System.FlagsAttribute]
    public enum AceFlags : byte
    {
        AuditFlags = (byte)192,
        ContainerInherit = (byte)2,
        FailedAccess = (byte)128,
        InheritanceFlags = (byte)15,
        Inherited = (byte)16,
        InheritOnly = (byte)8,
        None = (byte)0,
        NoPropagateInherit = (byte)4,
        ObjectInherit = (byte)1,
        SuccessfulAccess = (byte)64,
    }
    public enum AceQualifier
    {
        AccessAllowed = 0,
        AccessDenied = 1,
        SystemAlarm = 3,
        SystemAudit = 2,
    }
    public enum AceType : byte
    {
        AccessAllowed = (byte)0,
        AccessAllowedCallback = (byte)9,
        AccessAllowedCallbackObject = (byte)11,
        AccessAllowedCompound = (byte)4,
        AccessAllowedObject = (byte)5,
        AccessDenied = (byte)1,
        AccessDeniedCallback = (byte)10,
        AccessDeniedCallbackObject = (byte)12,
        AccessDeniedObject = (byte)6,
        MaxDefinedAceType = (byte)16,
        SystemAlarm = (byte)3,
        SystemAlarmCallback = (byte)14,
        SystemAlarmCallbackObject = (byte)16,
        SystemAlarmObject = (byte)8,
        SystemAudit = (byte)2,
        SystemAuditCallback = (byte)13,
        SystemAuditCallbackObject = (byte)15,
        SystemAuditObject = (byte)7,
    }
    [System.FlagsAttribute]
    public enum AuditFlags
    {
        Failure = 2,
        None = 0,
        Success = 1,
    }
    public abstract partial class AuditRule : System.Security.AccessControl.AuthorizationRule
    {
        protected AuditRule(System.Security.Principal.IdentityReference identity, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AuditFlags auditFlags) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags)) { }
        public System.Security.AccessControl.AuditFlags AuditFlags { get { throw null; } }
    }
    public partial class AuditRule<T> : System.Security.AccessControl.AuditRule where T : struct
    {
        public AuditRule(System.Security.Principal.IdentityReference identity, T rights, System.Security.AccessControl.AuditFlags flags) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AuditFlags)) { }
        public AuditRule(System.Security.Principal.IdentityReference identity, T rights, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AuditFlags flags) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AuditFlags)) { }
        public AuditRule(string identity, T rights, System.Security.AccessControl.AuditFlags flags) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AuditFlags)) { }
        public AuditRule(string identity, T rights, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AuditFlags flags) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AuditFlags)) { }
        public T Rights { get { throw null; } }
    }
    public abstract partial class AuthorizationRule
    {
        protected internal AuthorizationRule(System.Security.Principal.IdentityReference identity, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags) { }
        protected internal int AccessMask { get { throw null; } }
        public System.Security.Principal.IdentityReference IdentityReference { get { throw null; } }
        public System.Security.AccessControl.InheritanceFlags InheritanceFlags { get { throw null; } }
        public bool IsInherited { get { throw null; } }
        public System.Security.AccessControl.PropagationFlags PropagationFlags { get { throw null; } }
    }
    public sealed partial class AuthorizationRuleCollection : System.Collections.ReadOnlyCollectionBase
    {
        public AuthorizationRuleCollection() { }
        public System.Security.AccessControl.AuthorizationRule this[int index] { get { throw null; } }
        public void AddRule(System.Security.AccessControl.AuthorizationRule rule) { }
        public void CopyTo(System.Security.AccessControl.AuthorizationRule[] rules, int index) { }
    }
    public sealed partial class CommonAce : System.Security.AccessControl.QualifiedAce
    {
        public CommonAce(System.Security.AccessControl.AceFlags flags, System.Security.AccessControl.AceQualifier qualifier, int accessMask, System.Security.Principal.SecurityIdentifier sid, bool isCallback, byte[] opaque) { }
        public override int BinaryLength { get { throw null; } }
        public override void GetBinaryForm(byte[] binaryForm, int offset) { }
        public static int MaxOpaqueLength(bool isCallback) { throw null; }
    }
    public abstract partial class CommonAcl : System.Security.AccessControl.GenericAcl
    {
        internal CommonAcl() { }
        public sealed override int BinaryLength { get { throw null; } }
        public sealed override int Count { get { throw null; } }
        public bool IsCanonical { get { throw null; } }
        public bool IsContainer { get { throw null; } }
        public bool IsDS { get { throw null; } }
        public sealed override System.Security.AccessControl.GenericAce this[int index] { get { throw null; } set { } }
        public sealed override byte Revision { get { throw null; } }
        public sealed override void GetBinaryForm(byte[] binaryForm, int offset) { }
        public void Purge(System.Security.Principal.SecurityIdentifier sid) { }
        public void RemoveInheritedAces() { }
    }
    public abstract partial class CommonObjectSecurity : System.Security.AccessControl.ObjectSecurity
    {
        protected CommonObjectSecurity(bool isContainer) { }
        protected void AddAccessRule(System.Security.AccessControl.AccessRule rule) { }
        protected void AddAuditRule(System.Security.AccessControl.AuditRule rule) { }
        public System.Security.AccessControl.AuthorizationRuleCollection GetAccessRules(bool includeExplicit, bool includeInherited, System.Type targetType) { throw null; }
        public System.Security.AccessControl.AuthorizationRuleCollection GetAuditRules(bool includeExplicit, bool includeInherited, System.Type targetType) { throw null; }
        protected override bool ModifyAccess(System.Security.AccessControl.AccessControlModification modification, System.Security.AccessControl.AccessRule rule, out bool modified) { modified = default(bool); throw null; }
        protected override bool ModifyAudit(System.Security.AccessControl.AccessControlModification modification, System.Security.AccessControl.AuditRule rule, out bool modified) { modified = default(bool); throw null; }
        protected bool RemoveAccessRule(System.Security.AccessControl.AccessRule rule) { throw null; }
        protected void RemoveAccessRuleAll(System.Security.AccessControl.AccessRule rule) { }
        protected void RemoveAccessRuleSpecific(System.Security.AccessControl.AccessRule rule) { }
        protected bool RemoveAuditRule(System.Security.AccessControl.AuditRule rule) { throw null; }
        protected void RemoveAuditRuleAll(System.Security.AccessControl.AuditRule rule) { }
        protected void RemoveAuditRuleSpecific(System.Security.AccessControl.AuditRule rule) { }
        protected void ResetAccessRule(System.Security.AccessControl.AccessRule rule) { }
        protected void SetAccessRule(System.Security.AccessControl.AccessRule rule) { }
        protected void SetAuditRule(System.Security.AccessControl.AuditRule rule) { }
    }
    public sealed partial class CommonSecurityDescriptor : System.Security.AccessControl.GenericSecurityDescriptor
    {
        public CommonSecurityDescriptor(bool isContainer, bool isDS, byte[] binaryForm, int offset) { }
        public CommonSecurityDescriptor(bool isContainer, bool isDS, System.Security.AccessControl.ControlFlags flags, System.Security.Principal.SecurityIdentifier owner, System.Security.Principal.SecurityIdentifier group, System.Security.AccessControl.SystemAcl systemAcl, System.Security.AccessControl.DiscretionaryAcl discretionaryAcl) { }
        public CommonSecurityDescriptor(bool isContainer, bool isDS, System.Security.AccessControl.RawSecurityDescriptor rawSecurityDescriptor) { }
        public CommonSecurityDescriptor(bool isContainer, bool isDS, string sddlForm) { }
        public override System.Security.AccessControl.ControlFlags ControlFlags { get { throw null; } }
        public System.Security.AccessControl.DiscretionaryAcl DiscretionaryAcl { get { throw null; } set { } }
        public override System.Security.Principal.SecurityIdentifier Group { get { throw null; } set { } }
        public bool IsContainer { get { throw null; } }
        public bool IsDiscretionaryAclCanonical { get { throw null; } }
        public bool IsDS { get { throw null; } }
        public bool IsSystemAclCanonical { get { throw null; } }
        public override System.Security.Principal.SecurityIdentifier Owner { get { throw null; } set { } }
        public System.Security.AccessControl.SystemAcl SystemAcl { get { throw null; } set { } }
        public void AddDiscretionaryAcl(byte revision, int trusted) { }
        public void AddSystemAcl(byte revision, int trusted) { }
        public void PurgeAccessControl(System.Security.Principal.SecurityIdentifier sid) { }
        public void PurgeAudit(System.Security.Principal.SecurityIdentifier sid) { }
        public void SetDiscretionaryAclProtection(bool isProtected, bool preserveInheritance) { }
        public void SetSystemAclProtection(bool isProtected, bool preserveInheritance) { }
    }
    public sealed partial class CompoundAce : System.Security.AccessControl.KnownAce
    {
        public CompoundAce(System.Security.AccessControl.AceFlags flags, int accessMask, System.Security.AccessControl.CompoundAceType compoundAceType, System.Security.Principal.SecurityIdentifier sid) { }
        public override int BinaryLength { get { throw null; } }
        public System.Security.AccessControl.CompoundAceType CompoundAceType { get { throw null; } set { } }
        public override void GetBinaryForm(byte[] binaryForm, int offset) { }
    }
    public enum CompoundAceType
    {
        Impersonation = 1,
    }
    [System.FlagsAttribute]
    public enum ControlFlags
    {
        DiscretionaryAclAutoInherited = 1024,
        DiscretionaryAclAutoInheritRequired = 256,
        DiscretionaryAclDefaulted = 8,
        DiscretionaryAclPresent = 4,
        DiscretionaryAclProtected = 4096,
        DiscretionaryAclUntrusted = 64,
        GroupDefaulted = 2,
        None = 0,
        OwnerDefaulted = 1,
        RMControlValid = 16384,
        SelfRelative = 32768,
        ServerSecurity = 128,
        SystemAclAutoInherited = 2048,
        SystemAclAutoInheritRequired = 512,
        SystemAclDefaulted = 32,
        SystemAclPresent = 16,
        SystemAclProtected = 8192,
    }
    public sealed partial class CryptoKeyAccessRule : System.Security.AccessControl.AccessRule
    {
        public CryptoKeyAccessRule(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.CryptoKeyRights cryptoKeyRights, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
        public CryptoKeyAccessRule(string identity, System.Security.AccessControl.CryptoKeyRights cryptoKeyRights, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
        public System.Security.AccessControl.CryptoKeyRights CryptoKeyRights { get { throw null; } }
    }
    public sealed partial class CryptoKeyAuditRule : System.Security.AccessControl.AuditRule
    {
        public CryptoKeyAuditRule(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.CryptoKeyRights cryptoKeyRights, System.Security.AccessControl.AuditFlags flags) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AuditFlags)) { }
        public CryptoKeyAuditRule(string identity, System.Security.AccessControl.CryptoKeyRights cryptoKeyRights, System.Security.AccessControl.AuditFlags flags) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AuditFlags)) { }
        public System.Security.AccessControl.CryptoKeyRights CryptoKeyRights { get { throw null; } }
    }
    [System.FlagsAttribute]
    public enum CryptoKeyRights
    {
        ChangePermissions = 262144,
        Delete = 65536,
        FullControl = 2032027,
        GenericAll = 268435456,
        GenericExecute = 536870912,
        GenericRead = -2147483648,
        GenericWrite = 1073741824,
        ReadAttributes = 128,
        ReadData = 1,
        ReadExtendedAttributes = 8,
        ReadPermissions = 131072,
        Synchronize = 1048576,
        TakeOwnership = 524288,
        WriteAttributes = 256,
        WriteData = 2,
        WriteExtendedAttributes = 16,
    }
    public sealed partial class CryptoKeySecurity : System.Security.AccessControl.NativeObjectSecurity
    {
        public CryptoKeySecurity() : base (default(bool), default(System.Security.AccessControl.ResourceType)) { }
        public CryptoKeySecurity(System.Security.AccessControl.CommonSecurityDescriptor securityDescriptor) : base (default(bool), default(System.Security.AccessControl.ResourceType)) { }
        public override System.Type AccessRightType { get { throw null; } }
        public override System.Type AccessRuleType { get { throw null; } }
        public override System.Type AuditRuleType { get { throw null; } }
        public sealed override System.Security.AccessControl.AccessRule AccessRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AccessControlType type) { throw null; }
        public void AddAccessRule(System.Security.AccessControl.CryptoKeyAccessRule rule) { }
        public void AddAuditRule(System.Security.AccessControl.CryptoKeyAuditRule rule) { }
        public sealed override System.Security.AccessControl.AuditRule AuditRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AuditFlags flags) { throw null; }
        public bool RemoveAccessRule(System.Security.AccessControl.CryptoKeyAccessRule rule) { throw null; }
        public void RemoveAccessRuleAll(System.Security.AccessControl.CryptoKeyAccessRule rule) { }
        public void RemoveAccessRuleSpecific(System.Security.AccessControl.CryptoKeyAccessRule rule) { }
        public bool RemoveAuditRule(System.Security.AccessControl.CryptoKeyAuditRule rule) { throw null; }
        public void RemoveAuditRuleAll(System.Security.AccessControl.CryptoKeyAuditRule rule) { }
        public void RemoveAuditRuleSpecific(System.Security.AccessControl.CryptoKeyAuditRule rule) { }
        public void ResetAccessRule(System.Security.AccessControl.CryptoKeyAccessRule rule) { }
        public void SetAccessRule(System.Security.AccessControl.CryptoKeyAccessRule rule) { }
        public void SetAuditRule(System.Security.AccessControl.CryptoKeyAuditRule rule) { }
    }
    public sealed partial class CustomAce : System.Security.AccessControl.GenericAce
    {
        public static readonly int MaxOpaqueLength;
        public CustomAce(System.Security.AccessControl.AceType type, System.Security.AccessControl.AceFlags flags, byte[] opaque) { }
        public override int BinaryLength { get { throw null; } }
        public int OpaqueLength { get { throw null; } }
        public override void GetBinaryForm(byte[] binaryForm, int offset) { }
        public byte[] GetOpaque() { throw null; }
        public void SetOpaque(byte[] opaque) { }
    }
    public abstract partial class DirectoryObjectSecurity : System.Security.AccessControl.ObjectSecurity
    {
        protected DirectoryObjectSecurity() { }
        protected DirectoryObjectSecurity(System.Security.AccessControl.CommonSecurityDescriptor securityDescriptor) { }
        public virtual System.Security.AccessControl.AccessRule AccessRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AccessControlType type, System.Guid objectType, System.Guid inheritedObjectType) { throw null; }
        protected void AddAccessRule(System.Security.AccessControl.ObjectAccessRule rule) { }
        protected void AddAuditRule(System.Security.AccessControl.ObjectAuditRule rule) { }
        public virtual System.Security.AccessControl.AuditRule AuditRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AuditFlags flags, System.Guid objectType, System.Guid inheritedObjectType) { throw null; }
        public System.Security.AccessControl.AuthorizationRuleCollection GetAccessRules(bool includeExplicit, bool includeInherited, System.Type targetType) { throw null; }
        public System.Security.AccessControl.AuthorizationRuleCollection GetAuditRules(bool includeExplicit, bool includeInherited, System.Type targetType) { throw null; }
        protected override bool ModifyAccess(System.Security.AccessControl.AccessControlModification modification, System.Security.AccessControl.AccessRule rule, out bool modified) { modified = default(bool); throw null; }
        protected override bool ModifyAudit(System.Security.AccessControl.AccessControlModification modification, System.Security.AccessControl.AuditRule rule, out bool modified) { modified = default(bool); throw null; }
        protected bool RemoveAccessRule(System.Security.AccessControl.ObjectAccessRule rule) { throw null; }
        protected void RemoveAccessRuleAll(System.Security.AccessControl.ObjectAccessRule rule) { }
        protected void RemoveAccessRuleSpecific(System.Security.AccessControl.ObjectAccessRule rule) { }
        protected bool RemoveAuditRule(System.Security.AccessControl.ObjectAuditRule rule) { throw null; }
        protected void RemoveAuditRuleAll(System.Security.AccessControl.ObjectAuditRule rule) { }
        protected void RemoveAuditRuleSpecific(System.Security.AccessControl.ObjectAuditRule rule) { }
        protected void ResetAccessRule(System.Security.AccessControl.ObjectAccessRule rule) { }
        protected void SetAccessRule(System.Security.AccessControl.ObjectAccessRule rule) { }
        protected void SetAuditRule(System.Security.AccessControl.ObjectAuditRule rule) { }
    }
    public sealed partial class DirectorySecurity : System.Security.AccessControl.FileSystemSecurity
    {
        public DirectorySecurity() { }
        public DirectorySecurity(string name, System.Security.AccessControl.AccessControlSections includeSections) { }
    }
    public sealed partial class DiscretionaryAcl : System.Security.AccessControl.CommonAcl
    {
        public DiscretionaryAcl(bool isContainer, bool isDS, byte revision, int capacity) { }
        public DiscretionaryAcl(bool isContainer, bool isDS, int capacity) { }
        public DiscretionaryAcl(bool isContainer, bool isDS, System.Security.AccessControl.RawAcl rawAcl) { }
        public void AddAccess(System.Security.AccessControl.AccessControlType accessType, System.Security.Principal.SecurityIdentifier sid, int accessMask, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags) { }
        public void AddAccess(System.Security.AccessControl.AccessControlType accessType, System.Security.Principal.SecurityIdentifier sid, int accessMask, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.ObjectAceFlags objectFlags, System.Guid objectType, System.Guid inheritedObjectType) { }
        public void AddAccess(System.Security.AccessControl.AccessControlType accessType, System.Security.Principal.SecurityIdentifier sid, System.Security.AccessControl.ObjectAccessRule rule) { }
        public bool RemoveAccess(System.Security.AccessControl.AccessControlType accessType, System.Security.Principal.SecurityIdentifier sid, int accessMask, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags) { throw null; }
        public bool RemoveAccess(System.Security.AccessControl.AccessControlType accessType, System.Security.Principal.SecurityIdentifier sid, int accessMask, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.ObjectAceFlags objectFlags, System.Guid objectType, System.Guid inheritedObjectType) { throw null; }
        public bool RemoveAccess(System.Security.AccessControl.AccessControlType accessType, System.Security.Principal.SecurityIdentifier sid, System.Security.AccessControl.ObjectAccessRule rule) { throw null; }
        public void RemoveAccessSpecific(System.Security.AccessControl.AccessControlType accessType, System.Security.Principal.SecurityIdentifier sid, int accessMask, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags) { }
        public void RemoveAccessSpecific(System.Security.AccessControl.AccessControlType accessType, System.Security.Principal.SecurityIdentifier sid, int accessMask, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.ObjectAceFlags objectFlags, System.Guid objectType, System.Guid inheritedObjectType) { }
        public void RemoveAccessSpecific(System.Security.AccessControl.AccessControlType accessType, System.Security.Principal.SecurityIdentifier sid, System.Security.AccessControl.ObjectAccessRule rule) { }
        public void SetAccess(System.Security.AccessControl.AccessControlType accessType, System.Security.Principal.SecurityIdentifier sid, int accessMask, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags) { }
        public void SetAccess(System.Security.AccessControl.AccessControlType accessType, System.Security.Principal.SecurityIdentifier sid, int accessMask, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.ObjectAceFlags objectFlags, System.Guid objectType, System.Guid inheritedObjectType) { }
        public void SetAccess(System.Security.AccessControl.AccessControlType accessType, System.Security.Principal.SecurityIdentifier sid, System.Security.AccessControl.ObjectAccessRule rule) { }
    }
    public sealed partial class EventWaitHandleAccessRule : System.Security.AccessControl.AccessRule
    {
        public EventWaitHandleAccessRule(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.EventWaitHandleRights eventRights, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
        public EventWaitHandleAccessRule(string identity, System.Security.AccessControl.EventWaitHandleRights eventRights, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
        public System.Security.AccessControl.EventWaitHandleRights EventWaitHandleRights { get { throw null; } }
    }
    public sealed partial class EventWaitHandleAuditRule : System.Security.AccessControl.AuditRule
    {
        public EventWaitHandleAuditRule(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.EventWaitHandleRights eventRights, System.Security.AccessControl.AuditFlags flags) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AuditFlags)) { }
        public System.Security.AccessControl.EventWaitHandleRights EventWaitHandleRights { get { throw null; } }
    }
    [System.FlagsAttribute]
    public enum EventWaitHandleRights
    {
        ChangePermissions = 262144,
        Delete = 65536,
        FullControl = 2031619,
        Modify = 2,
        ReadPermissions = 131072,
        Synchronize = 1048576,
        TakeOwnership = 524288,
    }
    public sealed partial class EventWaitHandleSecurity : System.Security.AccessControl.NativeObjectSecurity
    {
        public EventWaitHandleSecurity() : base (default(bool), default(System.Security.AccessControl.ResourceType)) { }
        public override System.Type AccessRightType { get { throw null; } }
        public override System.Type AccessRuleType { get { throw null; } }
        public override System.Type AuditRuleType { get { throw null; } }
        public override System.Security.AccessControl.AccessRule AccessRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AccessControlType type) { throw null; }
        public void AddAccessRule(System.Security.AccessControl.EventWaitHandleAccessRule rule) { }
        public void AddAuditRule(System.Security.AccessControl.EventWaitHandleAuditRule rule) { }
        public override System.Security.AccessControl.AuditRule AuditRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AuditFlags flags) { throw null; }
        public bool RemoveAccessRule(System.Security.AccessControl.EventWaitHandleAccessRule rule) { throw null; }
        public void RemoveAccessRuleAll(System.Security.AccessControl.EventWaitHandleAccessRule rule) { }
        public void RemoveAccessRuleSpecific(System.Security.AccessControl.EventWaitHandleAccessRule rule) { }
        public bool RemoveAuditRule(System.Security.AccessControl.EventWaitHandleAuditRule rule) { throw null; }
        public void RemoveAuditRuleAll(System.Security.AccessControl.EventWaitHandleAuditRule rule) { }
        public void RemoveAuditRuleSpecific(System.Security.AccessControl.EventWaitHandleAuditRule rule) { }
        public void ResetAccessRule(System.Security.AccessControl.EventWaitHandleAccessRule rule) { }
        public void SetAccessRule(System.Security.AccessControl.EventWaitHandleAccessRule rule) { }
        public void SetAuditRule(System.Security.AccessControl.EventWaitHandleAuditRule rule) { }
    }
    public sealed partial class FileSecurity : System.Security.AccessControl.FileSystemSecurity
    {
        public FileSecurity() { }
        public FileSecurity(string fileName, System.Security.AccessControl.AccessControlSections includeSections) { }
    }
    public sealed partial class FileSystemAccessRule : System.Security.AccessControl.AccessRule
    {
        public FileSystemAccessRule(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.FileSystemRights fileSystemRights, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
        public FileSystemAccessRule(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.FileSystemRights fileSystemRights, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
        public FileSystemAccessRule(string identity, System.Security.AccessControl.FileSystemRights fileSystemRights, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
        public FileSystemAccessRule(string identity, System.Security.AccessControl.FileSystemRights fileSystemRights, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
        public System.Security.AccessControl.FileSystemRights FileSystemRights { get { throw null; } }
    }
    public sealed partial class FileSystemAuditRule : System.Security.AccessControl.AuditRule
    {
        public FileSystemAuditRule(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.FileSystemRights fileSystemRights, System.Security.AccessControl.AuditFlags flags) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AuditFlags)) { }
        public FileSystemAuditRule(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.FileSystemRights fileSystemRights, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AuditFlags flags) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AuditFlags)) { }
        public FileSystemAuditRule(string identity, System.Security.AccessControl.FileSystemRights fileSystemRights, System.Security.AccessControl.AuditFlags flags) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AuditFlags)) { }
        public FileSystemAuditRule(string identity, System.Security.AccessControl.FileSystemRights fileSystemRights, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AuditFlags flags) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AuditFlags)) { }
        public System.Security.AccessControl.FileSystemRights FileSystemRights { get { throw null; } }
    }
    [System.FlagsAttribute]
    public enum FileSystemRights
    {
        AppendData = 4,
        ChangePermissions = 262144,
        CreateDirectories = 4,
        CreateFiles = 2,
        Delete = 65536,
        DeleteSubdirectoriesAndFiles = 64,
        ExecuteFile = 32,
        FullControl = 2032127,
        ListDirectory = 1,
        Modify = 197055,
        Read = 131209,
        ReadAndExecute = 131241,
        ReadAttributes = 128,
        ReadData = 1,
        ReadExtendedAttributes = 8,
        ReadPermissions = 131072,
        Synchronize = 1048576,
        TakeOwnership = 524288,
        Traverse = 32,
        Write = 278,
        WriteAttributes = 256,
        WriteData = 2,
        WriteExtendedAttributes = 16,
    }
    public abstract partial class FileSystemSecurity : System.Security.AccessControl.NativeObjectSecurity
    {
        internal FileSystemSecurity() : base (default(bool), default(System.Security.AccessControl.ResourceType)) { }
        public override System.Type AccessRightType { get { throw null; } }
        public override System.Type AccessRuleType { get { throw null; } }
        public override System.Type AuditRuleType { get { throw null; } }
        public sealed override System.Security.AccessControl.AccessRule AccessRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AccessControlType type) { throw null; }
        public void AddAccessRule(System.Security.AccessControl.FileSystemAccessRule rule) { }
        public void AddAuditRule(System.Security.AccessControl.FileSystemAuditRule rule) { }
        public sealed override System.Security.AccessControl.AuditRule AuditRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AuditFlags flags) { throw null; }
        public bool RemoveAccessRule(System.Security.AccessControl.FileSystemAccessRule rule) { throw null; }
        public void RemoveAccessRuleAll(System.Security.AccessControl.FileSystemAccessRule rule) { }
        public void RemoveAccessRuleSpecific(System.Security.AccessControl.FileSystemAccessRule rule) { }
        public bool RemoveAuditRule(System.Security.AccessControl.FileSystemAuditRule rule) { throw null; }
        public void RemoveAuditRuleAll(System.Security.AccessControl.FileSystemAuditRule rule) { }
        public void RemoveAuditRuleSpecific(System.Security.AccessControl.FileSystemAuditRule rule) { }
        public void ResetAccessRule(System.Security.AccessControl.FileSystemAccessRule rule) { }
        public void SetAccessRule(System.Security.AccessControl.FileSystemAccessRule rule) { }
        public void SetAuditRule(System.Security.AccessControl.FileSystemAuditRule rule) { }
    }
    public abstract partial class GenericAce
    {
        internal GenericAce() { }
        public System.Security.AccessControl.AceFlags AceFlags { get { throw null; } set { } }
        public System.Security.AccessControl.AceType AceType { get { throw null; } }
        public System.Security.AccessControl.AuditFlags AuditFlags { get { throw null; } }
        public abstract int BinaryLength { get; }
        public System.Security.AccessControl.InheritanceFlags InheritanceFlags { get { throw null; } }
        public bool IsInherited { get { throw null; } }
        public System.Security.AccessControl.PropagationFlags PropagationFlags { get { throw null; } }
        public System.Security.AccessControl.GenericAce Copy() { throw null; }
        public static System.Security.AccessControl.GenericAce CreateFromBinaryForm(byte[] binaryForm, int offset) { throw null; }
        public sealed override bool Equals(object o) { throw null; }
        public abstract void GetBinaryForm(byte[] binaryForm, int offset);
        public sealed override int GetHashCode() { throw null; }
        public static bool operator ==(System.Security.AccessControl.GenericAce left, System.Security.AccessControl.GenericAce right) { throw null; }
        public static bool operator !=(System.Security.AccessControl.GenericAce left, System.Security.AccessControl.GenericAce right) { throw null; }
    }
    public abstract partial class GenericAcl : System.Collections.ICollection, System.Collections.IEnumerable
    {
        public static readonly byte AclRevision;
        public static readonly byte AclRevisionDS;
        public static readonly int MaxBinaryLength;
        protected GenericAcl() { }
        public abstract int BinaryLength { get; }
        public abstract int Count { get; }
        public bool IsSynchronized { get { throw null; } }
        public abstract System.Security.AccessControl.GenericAce this[int index] { get; set; }
        public abstract byte Revision { get; }
        public virtual object SyncRoot { get { throw null; } }
        public void CopyTo(System.Security.AccessControl.GenericAce[] array, int index) { }
        public abstract void GetBinaryForm(byte[] binaryForm, int offset);
        public System.Security.AccessControl.AceEnumerator GetEnumerator() { throw null; }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public abstract partial class GenericSecurityDescriptor
    {
        protected GenericSecurityDescriptor() { }
        public int BinaryLength { get { throw null; } }
        public abstract System.Security.AccessControl.ControlFlags ControlFlags { get; }
        public abstract System.Security.Principal.SecurityIdentifier Group { get; set; }
        public abstract System.Security.Principal.SecurityIdentifier Owner { get; set; }
        public static byte Revision { get { throw null; } }
        public void GetBinaryForm(byte[] binaryForm, int offset) { }
        public string GetSddlForm(System.Security.AccessControl.AccessControlSections includeSections) { throw null; }
        public static bool IsSddlConversionSupported() { throw null; }
    }
    [System.FlagsAttribute]
    public enum InheritanceFlags
    {
        ContainerInherit = 1,
        None = 0,
        ObjectInherit = 2,
    }
    public abstract partial class KnownAce : System.Security.AccessControl.GenericAce
    {
        internal KnownAce() { }
        public int AccessMask { get { throw null; } set { } }
        public System.Security.Principal.SecurityIdentifier SecurityIdentifier { get { throw null; } set { } }
    }
    public sealed partial class MutexAccessRule : System.Security.AccessControl.AccessRule
    {
        public MutexAccessRule(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.MutexRights eventRights, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
        public MutexAccessRule(string identity, System.Security.AccessControl.MutexRights eventRights, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
        public System.Security.AccessControl.MutexRights MutexRights { get { throw null; } }
    }
    public sealed partial class MutexAuditRule : System.Security.AccessControl.AuditRule
    {
        public MutexAuditRule(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.MutexRights eventRights, System.Security.AccessControl.AuditFlags flags) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AuditFlags)) { }
        public System.Security.AccessControl.MutexRights MutexRights { get { throw null; } }
    }
    [System.FlagsAttribute]
    public enum MutexRights
    {
        ChangePermissions = 262144,
        Delete = 65536,
        FullControl = 2031617,
        Modify = 1,
        ReadPermissions = 131072,
        Synchronize = 1048576,
        TakeOwnership = 524288,
    }
    public sealed partial class MutexSecurity : System.Security.AccessControl.NativeObjectSecurity
    {
        public MutexSecurity() : base (default(bool), default(System.Security.AccessControl.ResourceType)) { }
        public MutexSecurity(string name, System.Security.AccessControl.AccessControlSections includeSections) : base (default(bool), default(System.Security.AccessControl.ResourceType)) { }
        public override System.Type AccessRightType { get { throw null; } }
        public override System.Type AccessRuleType { get { throw null; } }
        public override System.Type AuditRuleType { get { throw null; } }
        public override System.Security.AccessControl.AccessRule AccessRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AccessControlType type) { throw null; }
        public void AddAccessRule(System.Security.AccessControl.MutexAccessRule rule) { }
        public void AddAuditRule(System.Security.AccessControl.MutexAuditRule rule) { }
        public override System.Security.AccessControl.AuditRule AuditRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AuditFlags flags) { throw null; }
        public bool RemoveAccessRule(System.Security.AccessControl.MutexAccessRule rule) { throw null; }
        public void RemoveAccessRuleAll(System.Security.AccessControl.MutexAccessRule rule) { }
        public void RemoveAccessRuleSpecific(System.Security.AccessControl.MutexAccessRule rule) { }
        public bool RemoveAuditRule(System.Security.AccessControl.MutexAuditRule rule) { throw null; }
        public void RemoveAuditRuleAll(System.Security.AccessControl.MutexAuditRule rule) { }
        public void RemoveAuditRuleSpecific(System.Security.AccessControl.MutexAuditRule rule) { }
        public void ResetAccessRule(System.Security.AccessControl.MutexAccessRule rule) { }
        public void SetAccessRule(System.Security.AccessControl.MutexAccessRule rule) { }
        public void SetAuditRule(System.Security.AccessControl.MutexAuditRule rule) { }
    }
    public abstract partial class NativeObjectSecurity : System.Security.AccessControl.CommonObjectSecurity
    {
        protected NativeObjectSecurity(bool isContainer, System.Security.AccessControl.ResourceType resourceType) : base (default(bool)) { }
        protected NativeObjectSecurity(bool isContainer, System.Security.AccessControl.ResourceType resourceType, System.Runtime.InteropServices.SafeHandle handle, System.Security.AccessControl.AccessControlSections includeSections) : base (default(bool)) { }
        protected NativeObjectSecurity(bool isContainer, System.Security.AccessControl.ResourceType resourceType, System.Runtime.InteropServices.SafeHandle handle, System.Security.AccessControl.AccessControlSections includeSections, System.Security.AccessControl.NativeObjectSecurity.ExceptionFromErrorCode exceptionFromErrorCode, object exceptionContext) : base (default(bool)) { }
        protected NativeObjectSecurity(bool isContainer, System.Security.AccessControl.ResourceType resourceType, System.Security.AccessControl.NativeObjectSecurity.ExceptionFromErrorCode exceptionFromErrorCode, object exceptionContext) : base (default(bool)) { }
        protected NativeObjectSecurity(bool isContainer, System.Security.AccessControl.ResourceType resourceType, string name, System.Security.AccessControl.AccessControlSections includeSections) : base (default(bool)) { }
        protected NativeObjectSecurity(bool isContainer, System.Security.AccessControl.ResourceType resourceType, string name, System.Security.AccessControl.AccessControlSections includeSections, System.Security.AccessControl.NativeObjectSecurity.ExceptionFromErrorCode exceptionFromErrorCode, object exceptionContext) : base (default(bool)) { }
        protected sealed override void Persist(System.Runtime.InteropServices.SafeHandle handle, System.Security.AccessControl.AccessControlSections includeSections) { }
        protected void Persist(System.Runtime.InteropServices.SafeHandle handle, System.Security.AccessControl.AccessControlSections includeSections, object exceptionContext) { }
        protected sealed override void Persist(string name, System.Security.AccessControl.AccessControlSections includeSections) { }
        protected void Persist(string name, System.Security.AccessControl.AccessControlSections includeSections, object exceptionContext) { }
        protected internal delegate System.Exception ExceptionFromErrorCode(int errorCode, string name, System.Runtime.InteropServices.SafeHandle handle, object context);
    }
    public abstract partial class ObjectAccessRule : System.Security.AccessControl.AccessRule
    {
        protected ObjectAccessRule(System.Security.Principal.IdentityReference identity, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Guid objectType, System.Guid inheritedObjectType, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
        public System.Guid InheritedObjectType { get { throw null; } }
        public System.Security.AccessControl.ObjectAceFlags ObjectFlags { get { throw null; } }
        public System.Guid ObjectType { get { throw null; } }
    }
    public sealed partial class ObjectAce : System.Security.AccessControl.QualifiedAce
    {
        public ObjectAce(System.Security.AccessControl.AceFlags aceFlags, System.Security.AccessControl.AceQualifier qualifier, int accessMask, System.Security.Principal.SecurityIdentifier sid, System.Security.AccessControl.ObjectAceFlags flags, System.Guid type, System.Guid inheritedType, bool isCallback, byte[] opaque) { }
        public override int BinaryLength { get { throw null; } }
        public System.Guid InheritedObjectAceType { get { throw null; } set { } }
        public System.Security.AccessControl.ObjectAceFlags ObjectAceFlags { get { throw null; } set { } }
        public System.Guid ObjectAceType { get { throw null; } set { } }
        public override void GetBinaryForm(byte[] binaryForm, int offset) { }
        public static int MaxOpaqueLength(bool isCallback) { throw null; }
    }
    [System.FlagsAttribute]
    public enum ObjectAceFlags
    {
        InheritedObjectAceTypePresent = 2,
        None = 0,
        ObjectAceTypePresent = 1,
    }
    public abstract partial class ObjectAuditRule : System.Security.AccessControl.AuditRule
    {
        protected ObjectAuditRule(System.Security.Principal.IdentityReference identity, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Guid objectType, System.Guid inheritedObjectType, System.Security.AccessControl.AuditFlags auditFlags) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AuditFlags)) { }
        public System.Guid InheritedObjectType { get { throw null; } }
        public System.Security.AccessControl.ObjectAceFlags ObjectFlags { get { throw null; } }
        public System.Guid ObjectType { get { throw null; } }
    }
    public abstract partial class ObjectSecurity
    {
        protected ObjectSecurity() { }
        protected ObjectSecurity(bool isContainer, bool isDS) { }
        protected ObjectSecurity(System.Security.AccessControl.CommonSecurityDescriptor securityDescriptor) { }
        public abstract System.Type AccessRightType { get; }
        protected bool AccessRulesModified { get { throw null; } set { } }
        public abstract System.Type AccessRuleType { get; }
        public bool AreAccessRulesCanonical { get { throw null; } }
        public bool AreAccessRulesProtected { get { throw null; } }
        public bool AreAuditRulesCanonical { get { throw null; } }
        public bool AreAuditRulesProtected { get { throw null; } }
        protected bool AuditRulesModified { get { throw null; } set { } }
        public abstract System.Type AuditRuleType { get; }
        protected bool GroupModified { get { throw null; } set { } }
        protected bool IsContainer { get { throw null; } }
        protected bool IsDS { get { throw null; } }
        protected bool OwnerModified { get { throw null; } set { } }
        public abstract System.Security.AccessControl.AccessRule AccessRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AccessControlType type);
        public abstract System.Security.AccessControl.AuditRule AuditRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AuditFlags flags);
        public System.Security.Principal.IdentityReference GetGroup(System.Type targetType) { throw null; }
        public System.Security.Principal.IdentityReference GetOwner(System.Type targetType) { throw null; }
        public byte[] GetSecurityDescriptorBinaryForm() { throw null; }
        public string GetSecurityDescriptorSddlForm(System.Security.AccessControl.AccessControlSections includeSections) { throw null; }
        public static bool IsSddlConversionSupported() { throw null; }
        protected abstract bool ModifyAccess(System.Security.AccessControl.AccessControlModification modification, System.Security.AccessControl.AccessRule rule, out bool modified);
        public virtual bool ModifyAccessRule(System.Security.AccessControl.AccessControlModification modification, System.Security.AccessControl.AccessRule rule, out bool modified) { modified = default(bool); throw null; }
        protected abstract bool ModifyAudit(System.Security.AccessControl.AccessControlModification modification, System.Security.AccessControl.AuditRule rule, out bool modified);
        public virtual bool ModifyAuditRule(System.Security.AccessControl.AccessControlModification modification, System.Security.AccessControl.AuditRule rule, out bool modified) { modified = default(bool); throw null; }
        [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
        protected virtual void Persist(bool enableOwnershipPrivilege, string name, System.Security.AccessControl.AccessControlSections includeSections) { }
        protected virtual void Persist(System.Runtime.InteropServices.SafeHandle handle, System.Security.AccessControl.AccessControlSections includeSections) { }
        protected virtual void Persist(string name, System.Security.AccessControl.AccessControlSections includeSections) { }
        public virtual void PurgeAccessRules(System.Security.Principal.IdentityReference identity) { }
        public virtual void PurgeAuditRules(System.Security.Principal.IdentityReference identity) { }
        protected void ReadLock() { }
        protected void ReadUnlock() { }
        public void SetAccessRuleProtection(bool isProtected, bool preserveInheritance) { }
        public void SetAuditRuleProtection(bool isProtected, bool preserveInheritance) { }
        public void SetGroup(System.Security.Principal.IdentityReference identity) { }
        public void SetOwner(System.Security.Principal.IdentityReference identity) { }
        public void SetSecurityDescriptorBinaryForm(byte[] binaryForm) { }
        public void SetSecurityDescriptorBinaryForm(byte[] binaryForm, System.Security.AccessControl.AccessControlSections includeSections) { }
        public void SetSecurityDescriptorSddlForm(string sddlForm) { }
        public void SetSecurityDescriptorSddlForm(string sddlForm, System.Security.AccessControl.AccessControlSections includeSections) { }
        protected void WriteLock() { }
        protected void WriteUnlock() { }
    }
    public abstract partial class ObjectSecurity<T> : System.Security.AccessControl.NativeObjectSecurity where T : struct
    {
        protected ObjectSecurity(bool isContainer, System.Security.AccessControl.ResourceType resourceType) : base (default(bool), default(System.Security.AccessControl.ResourceType)) { }
        protected ObjectSecurity(bool isContainer, System.Security.AccessControl.ResourceType resourceType, System.Runtime.InteropServices.SafeHandle safeHandle, System.Security.AccessControl.AccessControlSections includeSections) : base (default(bool), default(System.Security.AccessControl.ResourceType)) { }
        protected ObjectSecurity(bool isContainer, System.Security.AccessControl.ResourceType resourceType, System.Runtime.InteropServices.SafeHandle safeHandle, System.Security.AccessControl.AccessControlSections includeSections, System.Security.AccessControl.NativeObjectSecurity.ExceptionFromErrorCode exceptionFromErrorCode, object exceptionContext) : base (default(bool), default(System.Security.AccessControl.ResourceType)) { }
        protected ObjectSecurity(bool isContainer, System.Security.AccessControl.ResourceType resourceType, string name, System.Security.AccessControl.AccessControlSections includeSections) : base (default(bool), default(System.Security.AccessControl.ResourceType)) { }
        protected ObjectSecurity(bool isContainer, System.Security.AccessControl.ResourceType resourceType, string name, System.Security.AccessControl.AccessControlSections includeSections, System.Security.AccessControl.NativeObjectSecurity.ExceptionFromErrorCode exceptionFromErrorCode, object exceptionContext) : base (default(bool), default(System.Security.AccessControl.ResourceType)) { }
        public override System.Type AccessRightType { get { throw null; } }
        public override System.Type AccessRuleType { get { throw null; } }
        public override System.Type AuditRuleType { get { throw null; } }
        public override System.Security.AccessControl.AccessRule AccessRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AccessControlType type) { throw null; }
        public virtual void AddAccessRule(System.Security.AccessControl.AccessRule<T> rule) { }
        public virtual void AddAuditRule(System.Security.AccessControl.AuditRule<T> rule) { }
        public override System.Security.AccessControl.AuditRule AuditRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AuditFlags flags) { throw null; }
        protected internal void Persist(System.Runtime.InteropServices.SafeHandle handle) { }
        protected internal void Persist(string name) { }
        public virtual bool RemoveAccessRule(System.Security.AccessControl.AccessRule<T> rule) { throw null; }
        public virtual void RemoveAccessRuleAll(System.Security.AccessControl.AccessRule<T> rule) { }
        public virtual void RemoveAccessRuleSpecific(System.Security.AccessControl.AccessRule<T> rule) { }
        public virtual bool RemoveAuditRule(System.Security.AccessControl.AuditRule<T> rule) { throw null; }
        public virtual void RemoveAuditRuleAll(System.Security.AccessControl.AuditRule<T> rule) { }
        public virtual void RemoveAuditRuleSpecific(System.Security.AccessControl.AuditRule<T> rule) { }
        public virtual void ResetAccessRule(System.Security.AccessControl.AccessRule<T> rule) { }
        public virtual void SetAccessRule(System.Security.AccessControl.AccessRule<T> rule) { }
        public virtual void SetAuditRule(System.Security.AccessControl.AuditRule<T> rule) { }
    }
    public sealed partial class PrivilegeNotHeldException : System.UnauthorizedAccessException, System.Runtime.Serialization.ISerializable
    {
        public PrivilegeNotHeldException() { }
        public PrivilegeNotHeldException(string privilege) { }
        public PrivilegeNotHeldException(string privilege, System.Exception inner) { }
        public string PrivilegeName { get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    [System.FlagsAttribute]
    public enum PropagationFlags
    {
        InheritOnly = 2,
        None = 0,
        NoPropagateInherit = 1,
    }
    public abstract partial class QualifiedAce : System.Security.AccessControl.KnownAce
    {
        internal QualifiedAce() { }
        public System.Security.AccessControl.AceQualifier AceQualifier { get { throw null; } }
        public bool IsCallback { get { throw null; } }
        public int OpaqueLength { get { throw null; } }
        public byte[] GetOpaque() { throw null; }
        public void SetOpaque(byte[] opaque) { }
    }
    public sealed partial class RawAcl : System.Security.AccessControl.GenericAcl
    {
        public RawAcl(byte revision, int capacity) { }
        public RawAcl(byte[] binaryForm, int offset) { }
        public override int BinaryLength { get { throw null; } }
        public override int Count { get { throw null; } }
        public override System.Security.AccessControl.GenericAce this[int index] { get { throw null; } set { } }
        public override byte Revision { get { throw null; } }
        public override void GetBinaryForm(byte[] binaryForm, int offset) { }
        public void InsertAce(int index, System.Security.AccessControl.GenericAce ace) { }
        public void RemoveAce(int index) { }
    }
    public sealed partial class RawSecurityDescriptor : System.Security.AccessControl.GenericSecurityDescriptor
    {
        public RawSecurityDescriptor(byte[] binaryForm, int offset) { }
        public RawSecurityDescriptor(System.Security.AccessControl.ControlFlags flags, System.Security.Principal.SecurityIdentifier owner, System.Security.Principal.SecurityIdentifier group, System.Security.AccessControl.RawAcl systemAcl, System.Security.AccessControl.RawAcl discretionaryAcl) { }
        public RawSecurityDescriptor(string sddlForm) { }
        public override System.Security.AccessControl.ControlFlags ControlFlags { get { throw null; } }
        public System.Security.AccessControl.RawAcl DiscretionaryAcl { get { throw null; } set { } }
        public override System.Security.Principal.SecurityIdentifier Group { get { throw null; } set { } }
        public override System.Security.Principal.SecurityIdentifier Owner { get { throw null; } set { } }
        public byte ResourceManagerControl { get { throw null; } set { } }
        public System.Security.AccessControl.RawAcl SystemAcl { get { throw null; } set { } }
        public void SetFlags(System.Security.AccessControl.ControlFlags flags) { }
    }
    public sealed partial class RegistryAccessRule : System.Security.AccessControl.AccessRule
    {
        public RegistryAccessRule(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.RegistryRights registryRights, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
        public RegistryAccessRule(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.RegistryRights registryRights, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
        public RegistryAccessRule(string identity, System.Security.AccessControl.RegistryRights registryRights, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
        public RegistryAccessRule(string identity, System.Security.AccessControl.RegistryRights registryRights, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
        public System.Security.AccessControl.RegistryRights RegistryRights { get { throw null; } }
    }
    public sealed partial class RegistryAuditRule : System.Security.AccessControl.AuditRule
    {
        public RegistryAuditRule(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.RegistryRights registryRights, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AuditFlags flags) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AuditFlags)) { }
        public RegistryAuditRule(string identity, System.Security.AccessControl.RegistryRights registryRights, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AuditFlags flags) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AuditFlags)) { }
        public System.Security.AccessControl.RegistryRights RegistryRights { get { throw null; } }
    }
    [System.FlagsAttribute]
    public enum RegistryRights
    {
        ChangePermissions = 262144,
        CreateLink = 32,
        CreateSubKey = 4,
        Delete = 65536,
        EnumerateSubKeys = 8,
        ExecuteKey = 131097,
        FullControl = 983103,
        Notify = 16,
        QueryValues = 1,
        ReadKey = 131097,
        ReadPermissions = 131072,
        SetValue = 2,
        TakeOwnership = 524288,
        WriteKey = 131078,
    }
    public sealed partial class RegistrySecurity : System.Security.AccessControl.NativeObjectSecurity
    {
        public RegistrySecurity() : base (default(bool), default(System.Security.AccessControl.ResourceType)) { }
        public override System.Type AccessRightType { get { throw null; } }
        public override System.Type AccessRuleType { get { throw null; } }
        public override System.Type AuditRuleType { get { throw null; } }
        public override System.Security.AccessControl.AccessRule AccessRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AccessControlType type) { throw null; }
        public void AddAccessRule(System.Security.AccessControl.RegistryAccessRule rule) { }
        public void AddAuditRule(System.Security.AccessControl.RegistryAuditRule rule) { }
        public override System.Security.AccessControl.AuditRule AuditRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AuditFlags flags) { throw null; }
        public bool RemoveAccessRule(System.Security.AccessControl.RegistryAccessRule rule) { throw null; }
        public void RemoveAccessRuleAll(System.Security.AccessControl.RegistryAccessRule rule) { }
        public void RemoveAccessRuleSpecific(System.Security.AccessControl.RegistryAccessRule rule) { }
        public bool RemoveAuditRule(System.Security.AccessControl.RegistryAuditRule rule) { throw null; }
        public void RemoveAuditRuleAll(System.Security.AccessControl.RegistryAuditRule rule) { }
        public void RemoveAuditRuleSpecific(System.Security.AccessControl.RegistryAuditRule rule) { }
        public void ResetAccessRule(System.Security.AccessControl.RegistryAccessRule rule) { }
        public void SetAccessRule(System.Security.AccessControl.RegistryAccessRule rule) { }
        public void SetAuditRule(System.Security.AccessControl.RegistryAuditRule rule) { }
    }
    public enum ResourceType
    {
        DSObject = 8,
        DSObjectAll = 9,
        FileObject = 1,
        KernelObject = 6,
        LMShare = 5,
        Printer = 3,
        ProviderDefined = 10,
        RegistryKey = 4,
        RegistryWow6432Key = 12,
        Service = 2,
        Unknown = 0,
        WindowObject = 7,
        WmiGuidObject = 11,
    }
    [System.FlagsAttribute]
    public enum SecurityInfos
    {
        DiscretionaryAcl = 4,
        Group = 2,
        Owner = 1,
        SystemAcl = 8,
    }
    public sealed partial class SystemAcl : System.Security.AccessControl.CommonAcl
    {
        public SystemAcl(bool isContainer, bool isDS, byte revision, int capacity) { }
        public SystemAcl(bool isContainer, bool isDS, int capacity) { }
        public SystemAcl(bool isContainer, bool isDS, System.Security.AccessControl.RawAcl rawAcl) { }
        public void AddAudit(System.Security.AccessControl.AuditFlags auditFlags, System.Security.Principal.SecurityIdentifier sid, int accessMask, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags) { }
        public void AddAudit(System.Security.AccessControl.AuditFlags auditFlags, System.Security.Principal.SecurityIdentifier sid, int accessMask, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.ObjectAceFlags objectFlags, System.Guid objectType, System.Guid inheritedObjectType) { }
        public void AddAudit(System.Security.Principal.SecurityIdentifier sid, System.Security.AccessControl.ObjectAuditRule rule) { }
        public bool RemoveAudit(System.Security.AccessControl.AuditFlags auditFlags, System.Security.Principal.SecurityIdentifier sid, int accessMask, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags) { throw null; }
        public bool RemoveAudit(System.Security.AccessControl.AuditFlags auditFlags, System.Security.Principal.SecurityIdentifier sid, int accessMask, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.ObjectAceFlags objectFlags, System.Guid objectType, System.Guid inheritedObjectType) { throw null; }
        public bool RemoveAudit(System.Security.Principal.SecurityIdentifier sid, System.Security.AccessControl.ObjectAuditRule rule) { throw null; }
        public void RemoveAuditSpecific(System.Security.AccessControl.AuditFlags auditFlags, System.Security.Principal.SecurityIdentifier sid, int accessMask, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags) { }
        public void RemoveAuditSpecific(System.Security.AccessControl.AuditFlags auditFlags, System.Security.Principal.SecurityIdentifier sid, int accessMask, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.ObjectAceFlags objectFlags, System.Guid objectType, System.Guid inheritedObjectType) { }
        public void RemoveAuditSpecific(System.Security.Principal.SecurityIdentifier sid, System.Security.AccessControl.ObjectAuditRule rule) { }
        public void SetAudit(System.Security.AccessControl.AuditFlags auditFlags, System.Security.Principal.SecurityIdentifier sid, int accessMask, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags) { }
        public void SetAudit(System.Security.AccessControl.AuditFlags auditFlags, System.Security.Principal.SecurityIdentifier sid, int accessMask, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.ObjectAceFlags objectFlags, System.Guid objectType, System.Guid inheritedObjectType) { }
        public void SetAudit(System.Security.Principal.SecurityIdentifier sid, System.Security.AccessControl.ObjectAuditRule rule) { }
    }
}
namespace System.Security.AccessControl
{
    public sealed partial class SemaphoreAccessRule : System.Security.AccessControl.AccessRule
    {
        public SemaphoreAccessRule(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.SemaphoreRights eventRights, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
        public SemaphoreAccessRule(string identity, System.Security.AccessControl.SemaphoreRights eventRights, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
        public System.Security.AccessControl.SemaphoreRights SemaphoreRights { get { throw null; } }
    }
    public sealed partial class SemaphoreAuditRule : System.Security.AccessControl.AuditRule
    {
        public SemaphoreAuditRule(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.SemaphoreRights eventRights, System.Security.AccessControl.AuditFlags flags) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AuditFlags)) { }
        public System.Security.AccessControl.SemaphoreRights SemaphoreRights { get { throw null; } }
    }
    [System.FlagsAttribute]
    public enum SemaphoreRights
    {
        ChangePermissions = 262144,
        Delete = 65536,
        FullControl = 2031619,
        Modify = 2,
        ReadPermissions = 131072,
        Synchronize = 1048576,
        TakeOwnership = 524288,
    }
    public sealed partial class SemaphoreSecurity : System.Security.AccessControl.NativeObjectSecurity
    {
        public SemaphoreSecurity() : base (default(bool), default(System.Security.AccessControl.ResourceType)) { }
        public SemaphoreSecurity(string name, System.Security.AccessControl.AccessControlSections includeSections) : base (default(bool), default(System.Security.AccessControl.ResourceType)) { }
        public override System.Type AccessRightType { get { throw null; } }
        public override System.Type AccessRuleType { get { throw null; } }
        public override System.Type AuditRuleType { get { throw null; } }
        public override System.Security.AccessControl.AccessRule AccessRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AccessControlType type) { throw null; }
        public void AddAccessRule(System.Security.AccessControl.SemaphoreAccessRule rule) { }
        public void AddAuditRule(System.Security.AccessControl.SemaphoreAuditRule rule) { }
        public override System.Security.AccessControl.AuditRule AuditRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AuditFlags flags) { throw null; }
        public bool RemoveAccessRule(System.Security.AccessControl.SemaphoreAccessRule rule) { throw null; }
        public void RemoveAccessRuleAll(System.Security.AccessControl.SemaphoreAccessRule rule) { }
        public void RemoveAccessRuleSpecific(System.Security.AccessControl.SemaphoreAccessRule rule) { }
        public bool RemoveAuditRule(System.Security.AccessControl.SemaphoreAuditRule rule) { throw null; }
        public void RemoveAuditRuleAll(System.Security.AccessControl.SemaphoreAuditRule rule) { }
        public void RemoveAuditRuleSpecific(System.Security.AccessControl.SemaphoreAuditRule rule) { }
        public void ResetAccessRule(System.Security.AccessControl.SemaphoreAccessRule rule) { }
        public void SetAccessRule(System.Security.AccessControl.SemaphoreAccessRule rule) { }
        public void SetAuditRule(System.Security.AccessControl.SemaphoreAuditRule rule) { }
    }
}
namespace System.IO.MemoryMappedFiles
{
    public partial class MemoryMappedFileSecurity : System.Security.AccessControl.ObjectSecurity<System.IO.MemoryMappedFiles.MemoryMappedFileRights>
    {
        public MemoryMappedFileSecurity() : base (default(bool), default(System.Security.AccessControl.ResourceType)) { }
    }
}
namespace System.IO.Pipes
{
    [System.FlagsAttribute]
    public enum PipeAccessRights
    {
        AccessSystemSecurity = 16777216,
        ChangePermissions = 262144,
        CreateNewInstance = 4,
        Delete = 65536,
        FullControl = 2032031,
        Read = 131209,
        ReadAttributes = 128,
        ReadData = 1,
        ReadExtendedAttributes = 8,
        ReadPermissions = 131072,
        ReadWrite = 131483,
        Synchronize = 1048576,
        TakeOwnership = 524288,
        Write = 274,
        WriteAttributes = 256,
        WriteData = 2,
        WriteExtendedAttributes = 16,
    }
    public sealed partial class PipeAccessRule : System.Security.AccessControl.AccessRule
    {
        public PipeAccessRule(System.Security.Principal.IdentityReference identity, System.IO.Pipes.PipeAccessRights rights, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
        public PipeAccessRule(string identity, System.IO.Pipes.PipeAccessRights rights, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
        public System.IO.Pipes.PipeAccessRights PipeAccessRights { get { throw null; } }
    }
    public sealed partial class PipeAuditRule : System.Security.AccessControl.AuditRule
    {
        public PipeAuditRule(System.Security.Principal.IdentityReference identity, System.IO.Pipes.PipeAccessRights rights, System.Security.AccessControl.AuditFlags flags) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AuditFlags)) { }
        public PipeAuditRule(string identity, System.IO.Pipes.PipeAccessRights rights, System.Security.AccessControl.AuditFlags flags) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AuditFlags)) { }
        public System.IO.Pipes.PipeAccessRights PipeAccessRights { get { throw null; } }
    }
    public partial class PipeSecurity : System.Security.AccessControl.NativeObjectSecurity
    {
        public PipeSecurity() : base (default(bool), default(System.Security.AccessControl.ResourceType)) { }
        public override System.Type AccessRightType { get { throw null; } }
        public override System.Type AccessRuleType { get { throw null; } }
        public override System.Type AuditRuleType { get { throw null; } }
        public override System.Security.AccessControl.AccessRule AccessRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AccessControlType type) { throw null; }
        public void AddAccessRule(System.IO.Pipes.PipeAccessRule rule) { }
        public void AddAuditRule(System.IO.Pipes.PipeAuditRule rule) { }
        public sealed override System.Security.AccessControl.AuditRule AuditRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AuditFlags flags) { throw null; }
        protected internal void Persist(System.Runtime.InteropServices.SafeHandle handle) { }
        protected internal void Persist(string name) { }
        public bool RemoveAccessRule(System.IO.Pipes.PipeAccessRule rule) { throw null; }
        public void RemoveAccessRuleSpecific(System.IO.Pipes.PipeAccessRule rule) { }
        public bool RemoveAuditRule(System.IO.Pipes.PipeAuditRule rule) { throw null; }
        public void RemoveAuditRuleAll(System.IO.Pipes.PipeAuditRule rule) { }
        public void RemoveAuditRuleSpecific(System.IO.Pipes.PipeAuditRule rule) { }
        public void ResetAccessRule(System.IO.Pipes.PipeAccessRule rule) { }
        public void SetAccessRule(System.IO.Pipes.PipeAccessRule rule) { }
        public void SetAuditRule(System.IO.Pipes.PipeAuditRule rule) { }
    }
}