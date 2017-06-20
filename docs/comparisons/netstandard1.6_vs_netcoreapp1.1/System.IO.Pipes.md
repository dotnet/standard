# System.IO.Pipes

``` diff
+namespace System.IO.Pipes {
+    public sealed class AnonymousPipeClientStream : PipeStream {
+        public AnonymousPipeClientStream(PipeDirection direction, SafePipeHandle safePipeHandle);
+        public AnonymousPipeClientStream(PipeDirection direction, string pipeHandleAsString);
+        public AnonymousPipeClientStream(string pipeHandleAsString);
+        public override PipeTransmissionMode ReadMode { set; }
+        public override PipeTransmissionMode TransmissionMode { get; }
+        ~AnonymousPipeClientStream();
+    }
+    public sealed class AnonymousPipeServerStream : PipeStream {
+        public AnonymousPipeServerStream();
+        public AnonymousPipeServerStream(PipeDirection direction);
+        public AnonymousPipeServerStream(PipeDirection direction, SafePipeHandle serverSafePipeHandle, SafePipeHandle clientSafePipeHandle);
+        public AnonymousPipeServerStream(PipeDirection direction, HandleInheritability inheritability);
+        public AnonymousPipeServerStream(PipeDirection direction, HandleInheritability inheritability, int bufferSize);
+        public SafePipeHandle ClientSafePipeHandle { get; }
+        public override PipeTransmissionMode ReadMode { set; }
+        public override PipeTransmissionMode TransmissionMode { get; }
+        protected override void Dispose(bool disposing);
+        public void DisposeLocalCopyOfClientHandle();
+        ~AnonymousPipeServerStream();
+        public string GetClientHandleAsString();
+    }
+    public sealed class NamedPipeClientStream : PipeStream {
+        public NamedPipeClientStream(PipeDirection direction, bool isAsync, bool isConnected, SafePipeHandle safePipeHandle);
+        public NamedPipeClientStream(string pipeName);
+        public NamedPipeClientStream(string serverName, string pipeName);
+        public NamedPipeClientStream(string serverName, string pipeName, PipeDirection direction);
+        public NamedPipeClientStream(string serverName, string pipeName, PipeDirection direction, PipeOptions options);
+        public NamedPipeClientStream(string serverName, string pipeName, PipeDirection direction, PipeOptions options, TokenImpersonationLevel impersonationLevel);
+        public int NumberOfServerInstances { get; }
+        public void Connect();
+        public void Connect(int timeout);
+        public Task ConnectAsync();
+        public Task ConnectAsync(int timeout);
+        public Task ConnectAsync(int timeout, CancellationToken cancellationToken);
+        public Task ConnectAsync(CancellationToken cancellationToken);
+        ~NamedPipeClientStream();
+    }
+    public sealed class NamedPipeServerStream : PipeStream {
+        public NamedPipeServerStream(PipeDirection direction, bool isAsync, bool isConnected, SafePipeHandle safePipeHandle);
+        public NamedPipeServerStream(string pipeName);
+        public NamedPipeServerStream(string pipeName, PipeDirection direction);
+        public NamedPipeServerStream(string pipeName, PipeDirection direction, int maxNumberOfServerInstances);
+        public NamedPipeServerStream(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode);
+        public NamedPipeServerStream(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode, PipeOptions options);
+        public NamedPipeServerStream(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode, PipeOptions options, int inBufferSize, int outBufferSize);
+        public void Disconnect();
+        ~NamedPipeServerStream();
+        public string GetImpersonationUserName();
+        public void WaitForConnection();
+        public Task WaitForConnectionAsync();
+        public Task WaitForConnectionAsync(CancellationToken cancellationToken);
+    }
+    public enum PipeAccessRights {
+        AccessSystemSecurity = 16777216,
+        ChangePermissions = 262144,
+        CreateNewInstance = 4,
+        Delete = 65536,
+        FullControl = 2032031,
+        Read = 131209,
+        ReadAttributes = 128,
+        ReadData = 1,
+        ReadExtendedAttributes = 8,
+        ReadPermissions = 131072,
+        ReadWrite = 131483,
+        Synchronize = 1048576,
+        TakeOwnership = 524288,
+        Write = 274,
+        WriteAttributes = 256,
+        WriteData = 2,
+        WriteExtendedAttributes = 16,
+    }
+    public sealed class PipeAccessRule : AccessRule {
+        public PipeAccessRule(IdentityReference identity, PipeAccessRights rights, AccessControlType type);
+        public PipeAccessRule(string identity, PipeAccessRights rights, AccessControlType type);
+        public PipeAccessRights PipeAccessRights { get; }
+    }
+    public sealed class PipeAuditRule : AuditRule {
+        public PipeAuditRule(IdentityReference identity, PipeAccessRights rights, AuditFlags flags);
+        public PipeAuditRule(string identity, PipeAccessRights rights, AuditFlags flags);
+        public PipeAccessRights PipeAccessRights { get; }
+    }
+    public enum PipeDirection {
+        In = 1,
+        InOut = 3,
+        Out = 2,
+    }
+    public enum PipeOptions {
+        Asynchronous = 1073741824,
+        None = 0,
+        WriteThrough = -2147483648,
+    }
+    public static class PipesAclExtensions {
+        public static PipeSecurity GetAccessControl(this PipeStream stream);
+        public static void SetAccessControl(this PipeStream stream, PipeSecurity pipeSecurity);
+    }
+    public class PipeSecurity : NativeObjectSecurity {
+        public PipeSecurity();
+        public override Type AccessRightType { get; }
+        public override Type AccessRuleType { get; }
+        public override Type AuditRuleType { get; }
+        public override AccessRule AccessRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type);
+        public void AddAccessRule(PipeAccessRule rule);
+        public void AddAuditRule(PipeAuditRule rule);
+        public sealed override AuditRule AuditRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags);
+        protected internal void Persist(SafeHandle handle);
+        protected internal void Persist(string name);
+        public bool RemoveAccessRule(PipeAccessRule rule);
+        public void RemoveAccessRuleSpecific(PipeAccessRule rule);
+        public bool RemoveAuditRule(PipeAuditRule rule);
+        public void RemoveAuditRuleAll(PipeAuditRule rule);
+        public void RemoveAuditRuleSpecific(PipeAuditRule rule);
+        public void ResetAccessRule(PipeAccessRule rule);
+        public void SetAccessRule(PipeAccessRule rule);
+        public void SetAuditRule(PipeAuditRule rule);
+    }
+    public abstract class PipeStream : Stream {
+        protected PipeStream(PipeDirection direction, int bufferSize);
+        protected PipeStream(PipeDirection direction, PipeTransmissionMode transmissionMode, int outBufferSize);
+        public override bool CanRead { get; }
+        public override bool CanSeek { get; }
+        public override bool CanWrite { get; }
+        public virtual int InBufferSize { get; }
+        public bool IsAsync { get; }
+        public bool IsConnected { get; protected set; }
+        public bool IsMessageComplete { get; }
+        public override long Length { get; }
+        public virtual int OutBufferSize { get; }
+        public override long Position { get; set; }
+        public virtual PipeTransmissionMode ReadMode { get; set; }
+        public SafePipeHandle SafePipeHandle { get; }
+        public virtual PipeTransmissionMode TransmissionMode { get; }
+        protected override void Dispose(bool disposing);
+        public override void Flush();
+        public override int Read(byte[] buffer, int offset, int count);
+        public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);
+        public override int ReadByte();
+        public override long Seek(long offset, SeekOrigin origin);
+        public override void SetLength(long value);
+        public void WaitForPipeDrain();
+        public override void Write(byte[] buffer, int offset, int count);
+        public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);
+        public override void WriteByte(byte value);
+    }
+    public enum PipeTransmissionMode {
+        Byte = 0,
+        Message = 1,
+    }
+}
```

