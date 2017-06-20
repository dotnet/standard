# System.IO

``` diff
 namespace System.IO {
+    public sealed class DriveInfo {
+        public DriveInfo(string driveName);
+        public long AvailableFreeSpace { get; }
+        public string DriveFormat { get; }
+        public DriveType DriveType { get; }
+        public bool IsReady { get; }
+        public string Name { get; }
+        public DirectoryInfo RootDirectory { get; }
+        public long TotalFreeSpace { get; }
+        public long TotalSize { get; }
+        public string VolumeLabel { get; set; }
+        public static DriveInfo[] GetDrives();
+        public override string ToString();
+    }
+    public class DriveNotFoundException : IOException {
+        public DriveNotFoundException();
+        public DriveNotFoundException(string message);
+        public DriveNotFoundException(string message, Exception innerException);
+    }
+    public enum DriveType {
+        CDRom = 5,
+        Fixed = 3,
+        Network = 4,
+        NoRootDirectory = 1,
+        Ram = 6,
+        Removable = 2,
+        Unknown = 0,
+    }
+    public class ErrorEventArgs : EventArgs {
+        public ErrorEventArgs(Exception exception);
+        public virtual Exception GetException();
+    }
+    public delegate void ErrorEventHandler(object sender, ErrorEventArgs e);
+    public class FileFormatException : FormatException {
+        public FileFormatException();
+        public FileFormatException(string message);
+        public FileFormatException(string message, Exception innerException);
+        public FileFormatException(Uri sourceUri);
+        public FileFormatException(Uri sourceUri, Exception innerException);
+        public FileFormatException(Uri sourceUri, string message);
+        public FileFormatException(Uri sourceUri, string message, Exception innerException);
+        public Uri SourceUri { get; }
+    }
+    public static class FileSystemAclExtensions {
+        public static DirectorySecurity GetAccessControl(this DirectoryInfo directoryInfo);
+        public static DirectorySecurity GetAccessControl(this DirectoryInfo directoryInfo, AccessControlSections includeSections);
+        public static FileSecurity GetAccessControl(this FileInfo fileInfo);
+        public static FileSecurity GetAccessControl(this FileInfo fileInfo, AccessControlSections includeSections);
+        public static FileSecurity GetAccessControl(this FileStream fileStream);
+        public static void SetAccessControl(this DirectoryInfo directoryInfo, DirectorySecurity directorySecurity);
+        public static void SetAccessControl(this FileInfo fileInfo, FileSecurity fileSecurity);
+        public static void SetAccessControl(this FileStream fileStream, FileSecurity fileSecurity);
+    }
+    public class FileSystemEventArgs : EventArgs {
+        public FileSystemEventArgs(WatcherChangeTypes changeType, string directory, string name);
+        public WatcherChangeTypes ChangeType { get; }
+        public string FullPath { get; }
+        public string Name { get; }
+    }
+    public delegate void FileSystemEventHandler(object sender, FileSystemEventArgs e);
+    public class FileSystemWatcher : IDisposable {
+        public FileSystemWatcher();
+        public FileSystemWatcher(string path);
+        public FileSystemWatcher(string path, string filter);
+        public bool EnableRaisingEvents { get; set; }
+        public string Filter { get; set; }
+        public bool IncludeSubdirectories { get; set; }
+        public int InternalBufferSize { get; set; }
+        public NotifyFilters NotifyFilter { get; set; }
+        public string Path { get; set; }
+        public event FileSystemEventHandler Changed;
+        public event FileSystemEventHandler Created;
+        public event FileSystemEventHandler Deleted;
+        public event ErrorEventHandler Error;
+        public event RenamedEventHandler Renamed;
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        protected void OnChanged(FileSystemEventArgs e);
+        protected void OnCreated(FileSystemEventArgs e);
+        protected void OnDeleted(FileSystemEventArgs e);
+        protected void OnError(ErrorEventArgs e);
+        protected void OnRenamed(RenamedEventArgs e);
+        public WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType);
+        public WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType, int timeout);
+    }
+    public enum NotifyFilters {
+        Attributes = 4,
+        CreationTime = 64,
+        DirectoryName = 2,
+        FileName = 1,
+        LastAccess = 32,
+        LastWrite = 16,
+        Security = 256,
+        Size = 8,
+    }
+    public class RenamedEventArgs : FileSystemEventArgs {
+        public RenamedEventArgs(WatcherChangeTypes changeType, string directory, string name, string oldName);
+        public string OldFullPath { get; }
+        public string OldName { get; }
+    }
+    public delegate void RenamedEventHandler(object sender, RenamedEventArgs e);
+    public class UnmanagedMemoryAccessor : IDisposable {
+        protected UnmanagedMemoryAccessor();
+        public UnmanagedMemoryAccessor(SafeBuffer buffer, long offset, long capacity);
+        public UnmanagedMemoryAccessor(SafeBuffer buffer, long offset, long capacity, FileAccess access);
+        public bool CanRead { get; }
+        public bool CanWrite { get; }
+        public long Capacity { get; }
+        protected bool IsOpen { get; }
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        protected void Initialize(SafeBuffer buffer, long offset, long capacity, FileAccess access);
+        public bool ReadBoolean(long position);
+        public byte ReadByte(long position);
+        public char ReadChar(long position);
+        public decimal ReadDecimal(long position);
+        public double ReadDouble(long position);
+        public short ReadInt16(long position);
+        public int ReadInt32(long position);
+        public long ReadInt64(long position);
+        public sbyte ReadSByte(long position);
+        public float ReadSingle(long position);
+        public ushort ReadUInt16(long position);
+        public uint ReadUInt32(long position);
+        public ulong ReadUInt64(long position);
+        public void Write(long position, bool value);
+        public void Write(long position, byte value);
+        public void Write(long position, char value);
+        public void Write(long position, decimal value);
+        public void Write(long position, double value);
+        public void Write(long position, short value);
+        public void Write(long position, int value);
+        public void Write(long position, long value);
+        public void Write(long position, sbyte value);
+        public void Write(long position, float value);
+        public void Write(long position, ushort value);
+        public void Write(long position, uint value);
+        public void Write(long position, ulong value);
+    }
+    public class UnmanagedMemoryStream : Stream {
+        protected UnmanagedMemoryStream();
+        public unsafe UnmanagedMemoryStream(byte* pointer, long length);
+        public unsafe UnmanagedMemoryStream(byte* pointer, long length, long capacity, FileAccess access);
+        public UnmanagedMemoryStream(SafeBuffer buffer, long offset, long length);
+        public UnmanagedMemoryStream(SafeBuffer buffer, long offset, long length, FileAccess access);
+        public override bool CanRead { get; }
+        public override bool CanSeek { get; }
+        public override bool CanWrite { get; }
+        public long Capacity { get; }
+        public override long Length { get; }
+        public override long Position { get; set; }
+        public unsafe byte* PositionPointer { get; set; }
+        protected override void Dispose(bool disposing);
+        public override void Flush();
+        public override Task FlushAsync(CancellationToken cancellationToken);
+        protected unsafe void Initialize(byte* pointer, long length, long capacity, FileAccess access);
+        protected void Initialize(SafeBuffer buffer, long offset, long length, FileAccess access);
+        public override int Read(byte[] buffer, int offset, int count);
+        public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);
+        public override int ReadByte();
+        public override long Seek(long offset, SeekOrigin loc);
+        public override void SetLength(long value);
+        public override void Write(byte[] buffer, int offset, int count);
+        public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);
+        public override void WriteByte(byte value);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Size=1)]
+    public struct WaitForChangedResult {
+        public WatcherChangeTypes ChangeType { get; set; }
+        public string Name { get; set; }
+        public string OldName { get; set; }
+        public bool TimedOut { get; set; }
+    }
+    public enum WatcherChangeTypes {
+        All = 15,
+        Changed = 4,
+        Created = 1,
+        Deleted = 2,
+        Renamed = 8,
+    }
 }
```

