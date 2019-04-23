// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.IO
{
    public partial class BinaryReader : System.IDisposable
    {
        public BinaryReader(System.IO.Stream input) { }
        public BinaryReader(System.IO.Stream input, System.Text.Encoding encoding) { }
        public BinaryReader(System.IO.Stream input, System.Text.Encoding encoding, bool leaveOpen) { }
        public virtual System.IO.Stream BaseStream { get { throw null; } }
        public virtual void Close() { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        protected virtual void FillBuffer(int numBytes) { }
        public virtual int PeekChar() { throw null; }
        public virtual int Read() { throw null; }
        public virtual int Read(byte[] buffer, int index, int count) { throw null; }
        public virtual int Read(char[] buffer, int index, int count) { throw null; }
        public virtual int Read(System.Span<byte> buffer) { throw null; }
        public virtual int Read(System.Span<char> buffer) { throw null; }
        protected internal int Read7BitEncodedInt() { throw null; }
        public virtual bool ReadBoolean() { throw null; }
        public virtual byte ReadByte() { throw null; }
        public virtual byte[] ReadBytes(int count) { throw null; }
        public virtual char ReadChar() { throw null; }
        public virtual char[] ReadChars(int count) { throw null; }
        public virtual decimal ReadDecimal() { throw null; }
        public virtual double ReadDouble() { throw null; }
        public virtual short ReadInt16() { throw null; }
        public virtual int ReadInt32() { throw null; }
        public virtual long ReadInt64() { throw null; }
        [System.CLSCompliantAttribute(false)]
        public virtual sbyte ReadSByte() { throw null; }
        public virtual float ReadSingle() { throw null; }
        public virtual string ReadString() { throw null; }
        [System.CLSCompliantAttribute(false)]
        public virtual ushort ReadUInt16() { throw null; }
        [System.CLSCompliantAttribute(false)]
        public virtual uint ReadUInt32() { throw null; }
        [System.CLSCompliantAttribute(false)]
        public virtual ulong ReadUInt64() { throw null; }
    }
    public partial class BinaryWriter : System.IAsyncDisposable, System.IDisposable
    {
        public static readonly System.IO.BinaryWriter Null;
        protected System.IO.Stream OutStream;
        protected BinaryWriter() { }
        public BinaryWriter(System.IO.Stream output) { }
        public BinaryWriter(System.IO.Stream output, System.Text.Encoding encoding) { }
        public BinaryWriter(System.IO.Stream output, System.Text.Encoding encoding, bool leaveOpen) { }
        public virtual System.IO.Stream BaseStream { get { throw null; } }
        public virtual void Close() { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public virtual System.Threading.Tasks.ValueTask DisposeAsync() { throw null; }
        public virtual void Flush() { }
        public virtual long Seek(int offset, System.IO.SeekOrigin origin) { throw null; }
        public virtual void Write(bool value) { }
        public virtual void Write(byte value) { }
        public virtual void Write(byte[] buffer) { }
        public virtual void Write(byte[] buffer, int index, int count) { }
        public virtual void Write(char ch) { }
        public virtual void Write(char[] chars) { }
        public virtual void Write(char[] chars, int index, int count) { }
        public virtual void Write(decimal value) { }
        public virtual void Write(double value) { }
        public virtual void Write(short value) { }
        public virtual void Write(int value) { }
        public virtual void Write(long value) { }
        public virtual void Write(System.ReadOnlySpan<byte> buffer) { }
        public virtual void Write(System.ReadOnlySpan<char> chars) { }
        [System.CLSCompliantAttribute(false)]
        public virtual void Write(sbyte value) { }
        public virtual void Write(float value) { }
        public virtual void Write(string value) { }
        [System.CLSCompliantAttribute(false)]
        public virtual void Write(ushort value) { }
        [System.CLSCompliantAttribute(false)]
        public virtual void Write(uint value) { }
        [System.CLSCompliantAttribute(false)]
        public virtual void Write(ulong value) { }
        protected void Write7BitEncodedInt(int value) { }
    }
    public sealed partial class BufferedStream : System.IO.Stream
    {
        public BufferedStream(System.IO.Stream stream) { }
        public BufferedStream(System.IO.Stream stream, int bufferSize) { }
        public int BufferSize { get { throw null; } }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public override long Length { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        public System.IO.Stream UnderlyingStream { get { throw null; } }
        public override System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { throw null; }
        public override System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { throw null; }
        protected override void Dispose(bool disposing) { }
        public override System.Threading.Tasks.ValueTask DisposeAsync() { throw null; }
        public override int EndRead(System.IAsyncResult asyncResult) { throw null; }
        public override void EndWrite(System.IAsyncResult asyncResult) { }
        public override void Flush() { }
        public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public override int Read(byte[] array, int offset, int count) { throw null; }
        public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override int ReadByte() { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long value) { }
        public override void Write(byte[] array, int offset, int count) { }
        public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override void WriteByte(byte value) { }
    }
    public static partial class Directory
    {
        public static System.IO.DirectoryInfo CreateDirectory(string path) { throw null; }
//ACLS        public static System.IO.DirectoryInfo CreateDirectory(string path, System.Security.AccessControl.DirectorySecurity directorySecurity) { throw null; }
        public static void Delete(string path) { }
        public static void Delete(string path, bool recursive) { }
        public static System.Collections.Generic.IEnumerable<string> EnumerateDirectories(string path) { throw null; }
        public static System.Collections.Generic.IEnumerable<string> EnumerateDirectories(string path, string searchPattern) { throw null; }
        public static System.Collections.Generic.IEnumerable<string> EnumerateDirectories(string path, string searchPattern, System.IO.EnumerationOptions enumerationOptions) { throw null; }
        public static System.Collections.Generic.IEnumerable<string> EnumerateDirectories(string path, string searchPattern, System.IO.SearchOption searchOption) { throw null; }
        public static System.Collections.Generic.IEnumerable<string> EnumerateFiles(string path) { throw null; }
        public static System.Collections.Generic.IEnumerable<string> EnumerateFiles(string path, string searchPattern) { throw null; }
        public static System.Collections.Generic.IEnumerable<string> EnumerateFiles(string path, string searchPattern, System.IO.EnumerationOptions enumerationOptions) { throw null; }
        public static System.Collections.Generic.IEnumerable<string> EnumerateFiles(string path, string searchPattern, System.IO.SearchOption searchOption) { throw null; }
        public static System.Collections.Generic.IEnumerable<string> EnumerateFileSystemEntries(string path) { throw null; }
        public static System.Collections.Generic.IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern) { throw null; }
        public static System.Collections.Generic.IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, System.IO.EnumerationOptions enumerationOptions) { throw null; }
        public static System.Collections.Generic.IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, System.IO.SearchOption searchOption) { throw null; }
        public static bool Exists(string path) { throw null; }
//ACLS        public static System.Security.AccessControl.DirectorySecurity GetAccessControl(string path) { throw null; }
//ACLS        public static System.Security.AccessControl.DirectorySecurity GetAccessControl(string path, System.Security.AccessControl.AccessControlSections includeSections) { throw null; }
        public static System.DateTime GetCreationTime(string path) { throw null; }
        public static System.DateTime GetCreationTimeUtc(string path) { throw null; }
        public static string GetCurrentDirectory() { throw null; }
        public static string[] GetDirectories(string path) { throw null; }
        public static string[] GetDirectories(string path, string searchPattern) { throw null; }
        public static string[] GetDirectories(string path, string searchPattern, System.IO.EnumerationOptions enumerationOptions) { throw null; }
        public static string[] GetDirectories(string path, string searchPattern, System.IO.SearchOption searchOption) { throw null; }
        public static string GetDirectoryRoot(string path) { throw null; }
        public static string[] GetFiles(string path) { throw null; }
        public static string[] GetFiles(string path, string searchPattern) { throw null; }
        public static string[] GetFiles(string path, string searchPattern, System.IO.EnumerationOptions enumerationOptions) { throw null; }
        public static string[] GetFiles(string path, string searchPattern, System.IO.SearchOption searchOption) { throw null; }
        public static string[] GetFileSystemEntries(string path) { throw null; }
        public static string[] GetFileSystemEntries(string path, string searchPattern) { throw null; }
        public static string[] GetFileSystemEntries(string path, string searchPattern, System.IO.EnumerationOptions enumerationOptions) { throw null; }
        public static string[] GetFileSystemEntries(string path, string searchPattern, System.IO.SearchOption searchOption) { throw null; }
        public static System.DateTime GetLastAccessTime(string path) { throw null; }
        public static System.DateTime GetLastAccessTimeUtc(string path) { throw null; }
        public static System.DateTime GetLastWriteTime(string path) { throw null; }
        public static System.DateTime GetLastWriteTimeUtc(string path) { throw null; }
        public static string[] GetLogicalDrives() { throw null; }
        public static System.IO.DirectoryInfo GetParent(string path) { throw null; }
        public static void Move(string sourceDirName, string destDirName) { }
//ACLS        public static void SetAccessControl(string path, System.Security.AccessControl.DirectorySecurity directorySecurity) { }
        public static void SetCreationTime(string path, System.DateTime creationTime) { }
        public static void SetCreationTimeUtc(string path, System.DateTime creationTimeUtc) { }
        public static void SetCurrentDirectory(string path) { }
        public static void SetLastAccessTime(string path, System.DateTime lastAccessTime) { }
        public static void SetLastAccessTimeUtc(string path, System.DateTime lastAccessTimeUtc) { }
        public static void SetLastWriteTime(string path, System.DateTime lastWriteTime) { }
        public static void SetLastWriteTimeUtc(string path, System.DateTime lastWriteTimeUtc) { }
    }
    public sealed partial class DirectoryInfo : System.IO.FileSystemInfo
    {
        public DirectoryInfo(string path) { }
        public override bool Exists { get { throw null; } }
        public override string Name { get { throw null; } }
        public System.IO.DirectoryInfo Parent { get { throw null; } }
        public System.IO.DirectoryInfo Root { get { throw null; } }
        public void Create() { }
//ACLS        public void Create(System.Security.AccessControl.DirectorySecurity directorySecurity) { }
        public System.IO.DirectoryInfo CreateSubdirectory(string path) { throw null; }
//ACLS        public System.IO.DirectoryInfo CreateSubdirectory(string path, System.Security.AccessControl.DirectorySecurity directorySecurity) { throw null; }
        public override void Delete() { }
        public void Delete(bool recursive) { }
        public System.Collections.Generic.IEnumerable<System.IO.DirectoryInfo> EnumerateDirectories() { throw null; }
        public System.Collections.Generic.IEnumerable<System.IO.DirectoryInfo> EnumerateDirectories(string searchPattern) { throw null; }
        public System.Collections.Generic.IEnumerable<System.IO.DirectoryInfo> EnumerateDirectories(string searchPattern, System.IO.EnumerationOptions enumerationOptions) { throw null; }
        public System.Collections.Generic.IEnumerable<System.IO.DirectoryInfo> EnumerateDirectories(string searchPattern, System.IO.SearchOption searchOption) { throw null; }
        public System.Collections.Generic.IEnumerable<System.IO.FileInfo> EnumerateFiles() { throw null; }
        public System.Collections.Generic.IEnumerable<System.IO.FileInfo> EnumerateFiles(string searchPattern) { throw null; }
        public System.Collections.Generic.IEnumerable<System.IO.FileInfo> EnumerateFiles(string searchPattern, System.IO.EnumerationOptions enumerationOptions) { throw null; }
        public System.Collections.Generic.IEnumerable<System.IO.FileInfo> EnumerateFiles(string searchPattern, System.IO.SearchOption searchOption) { throw null; }
        public System.Collections.Generic.IEnumerable<System.IO.FileSystemInfo> EnumerateFileSystemInfos() { throw null; }
        public System.Collections.Generic.IEnumerable<System.IO.FileSystemInfo> EnumerateFileSystemInfos(string searchPattern) { throw null; }
        public System.Collections.Generic.IEnumerable<System.IO.FileSystemInfo> EnumerateFileSystemInfos(string searchPattern, System.IO.EnumerationOptions enumerationOptions) { throw null; }
        public System.Collections.Generic.IEnumerable<System.IO.FileSystemInfo> EnumerateFileSystemInfos(string searchPattern, System.IO.SearchOption searchOption) { throw null; }
//ACLS        public System.Security.AccessControl.DirectorySecurity GetAccessControl() { throw null; }
//ACLS        public System.Security.AccessControl.DirectorySecurity GetAccessControl(System.Security.AccessControl.AccessControlSections includeSections) { throw null; }
        public System.IO.DirectoryInfo[] GetDirectories() { throw null; }
        public System.IO.DirectoryInfo[] GetDirectories(string searchPattern) { throw null; }
        public System.IO.DirectoryInfo[] GetDirectories(string searchPattern, System.IO.EnumerationOptions enumerationOptions) { throw null; }
        public System.IO.DirectoryInfo[] GetDirectories(string searchPattern, System.IO.SearchOption searchOption) { throw null; }
        public System.IO.FileInfo[] GetFiles() { throw null; }
        public System.IO.FileInfo[] GetFiles(string searchPattern) { throw null; }
        public System.IO.FileInfo[] GetFiles(string searchPattern, System.IO.EnumerationOptions enumerationOptions) { throw null; }
        public System.IO.FileInfo[] GetFiles(string searchPattern, System.IO.SearchOption searchOption) { throw null; }
        public System.IO.FileSystemInfo[] GetFileSystemInfos() { throw null; }
        public System.IO.FileSystemInfo[] GetFileSystemInfos(string searchPattern) { throw null; }
        public System.IO.FileSystemInfo[] GetFileSystemInfos(string searchPattern, System.IO.EnumerationOptions enumerationOptions) { throw null; }
        public System.IO.FileSystemInfo[] GetFileSystemInfos(string searchPattern, System.IO.SearchOption searchOption) { throw null; }
        public void MoveTo(string destDirName) { }
//ACLS        public void SetAccessControl(System.Security.AccessControl.DirectorySecurity directorySecurity) { }
        public override string ToString() { throw null; }
    }
    public partial class DirectoryNotFoundException : System.IO.IOException
    {
        public DirectoryNotFoundException() { }
        protected DirectoryNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public DirectoryNotFoundException(string message) { }
        public DirectoryNotFoundException(string message, System.Exception innerException) { }
    }
    public sealed partial class DriveInfo : System.Runtime.Serialization.ISerializable
    {
        public DriveInfo(string driveName) { }
        public long AvailableFreeSpace { get { throw null; } }
        public string DriveFormat { get { throw null; } }
        public System.IO.DriveType DriveType { get { throw null; } }
        public bool IsReady { get { throw null; } }
        public string Name { get { throw null; } }
        public System.IO.DirectoryInfo RootDirectory { get { throw null; } }
        public long TotalFreeSpace { get { throw null; } }
        public long TotalSize { get { throw null; } }
        public string VolumeLabel { get { throw null; } set { } }
        public static System.IO.DriveInfo[] GetDrives() { throw null; }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public override string ToString() { throw null; }
    }
    public partial class DriveNotFoundException : System.IO.IOException
    {
        public DriveNotFoundException() { }
        protected DriveNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public DriveNotFoundException(string message) { }
        public DriveNotFoundException(string message, System.Exception innerException) { }
    }
    public enum DriveType
    {
        CDRom = 5,
        Fixed = 3,
        Network = 4,
        NoRootDirectory = 1,
        Ram = 6,
        Removable = 2,
        Unknown = 0,
    }
    public partial class EndOfStreamException : System.IO.IOException
    {
        public EndOfStreamException() { }
        protected EndOfStreamException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public EndOfStreamException(string message) { }
        public EndOfStreamException(string message, System.Exception innerException) { }
    }
    public partial class EnumerationOptions
    {
        public EnumerationOptions() { }
        public System.IO.FileAttributes AttributesToSkip { get { throw null; } set { } }
        public int BufferSize { get { throw null; } set { } }
        public bool IgnoreInaccessible { get { throw null; } set { } }
        public System.IO.MatchCasing MatchCasing { get { throw null; } set { } }
        public System.IO.MatchType MatchType { get { throw null; } set { } }
        public bool RecurseSubdirectories { get { throw null; } set { } }
        public bool ReturnSpecialDirectories { get { throw null; } set { } }
    }
    public partial class ErrorEventArgs : System.EventArgs
    {
        public ErrorEventArgs(System.Exception exception) { }
        public virtual System.Exception GetException() { throw null; }
    }
    public delegate void ErrorEventHandler(object sender, System.IO.ErrorEventArgs e);
    public static partial class File
    {
        public static void AppendAllLines(string path, System.Collections.Generic.IEnumerable<string> contents) { }
        public static void AppendAllLines(string path, System.Collections.Generic.IEnumerable<string> contents, System.Text.Encoding encoding) { }
        public static System.Threading.Tasks.Task AppendAllLinesAsync(string path, System.Collections.Generic.IEnumerable<string> contents, System.Text.Encoding encoding, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task AppendAllLinesAsync(string path, System.Collections.Generic.IEnumerable<string> contents, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static void AppendAllText(string path, string contents) { }
        public static void AppendAllText(string path, string contents, System.Text.Encoding encoding) { }
        public static System.Threading.Tasks.Task AppendAllTextAsync(string path, string contents, System.Text.Encoding encoding, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task AppendAllTextAsync(string path, string contents, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.IO.StreamWriter AppendText(string path) { throw null; }
        public static void Copy(string sourceFileName, string destFileName) { }
        public static void Copy(string sourceFileName, string destFileName, bool overwrite) { }
        public static System.IO.FileStream Create(string path) { throw null; }
        public static System.IO.FileStream Create(string path, int bufferSize) { throw null; }
        public static System.IO.FileStream Create(string path, int bufferSize, System.IO.FileOptions options) { throw null; }
//ACLS        public static System.IO.FileStream Create(string path, int bufferSize, System.IO.FileOptions options, System.Security.AccessControl.FileSecurity fileSecurity) { throw null; }
        public static System.IO.StreamWriter CreateText(string path) { throw null; }
        public static void Decrypt(string path) { }
        public static void Delete(string path) { }
        public static void Encrypt(string path) { }
        public static bool Exists(string path) { throw null; }
//ACLS        public static System.Security.AccessControl.FileSecurity GetAccessControl(string path) { throw null; }
//ACLS        public static System.Security.AccessControl.FileSecurity GetAccessControl(string path, System.Security.AccessControl.AccessControlSections includeSections) { throw null; }
        public static System.IO.FileAttributes GetAttributes(string path) { throw null; }
        public static System.DateTime GetCreationTime(string path) { throw null; }
        public static System.DateTime GetCreationTimeUtc(string path) { throw null; }
        public static System.DateTime GetLastAccessTime(string path) { throw null; }
        public static System.DateTime GetLastAccessTimeUtc(string path) { throw null; }
        public static System.DateTime GetLastWriteTime(string path) { throw null; }
        public static System.DateTime GetLastWriteTimeUtc(string path) { throw null; }
        public static void Move(string sourceFileName, string destFileName) { }
        public static System.IO.FileStream Open(string path, System.IO.FileMode mode) { throw null; }
        public static System.IO.FileStream Open(string path, System.IO.FileMode mode, System.IO.FileAccess access) { throw null; }
        public static System.IO.FileStream Open(string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share) { throw null; }
        public static System.IO.FileStream OpenRead(string path) { throw null; }
        public static System.IO.StreamReader OpenText(string path) { throw null; }
        public static System.IO.FileStream OpenWrite(string path) { throw null; }
        public static byte[] ReadAllBytes(string path) { throw null; }
        public static System.Threading.Tasks.Task<byte[]> ReadAllBytesAsync(string path, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static string[] ReadAllLines(string path) { throw null; }
        public static string[] ReadAllLines(string path, System.Text.Encoding encoding) { throw null; }
        public static System.Threading.Tasks.Task<string[]> ReadAllLinesAsync(string path, System.Text.Encoding encoding, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<string[]> ReadAllLinesAsync(string path, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static string ReadAllText(string path) { throw null; }
        public static string ReadAllText(string path, System.Text.Encoding encoding) { throw null; }
        public static System.Threading.Tasks.Task<string> ReadAllTextAsync(string path, System.Text.Encoding encoding, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<string> ReadAllTextAsync(string path, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Collections.Generic.IEnumerable<string> ReadLines(string path) { throw null; }
        public static System.Collections.Generic.IEnumerable<string> ReadLines(string path, System.Text.Encoding encoding) { throw null; }
        public static void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName) { }
        public static void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors) { }
//ACLS        public static void SetAccessControl(string path, System.Security.AccessControl.FileSecurity fileSecurity) { }
        public static void SetAttributes(string path, System.IO.FileAttributes fileAttributes) { }
        public static void SetCreationTime(string path, System.DateTime creationTime) { }
        public static void SetCreationTimeUtc(string path, System.DateTime creationTimeUtc) { }
        public static void SetLastAccessTime(string path, System.DateTime lastAccessTime) { }
        public static void SetLastAccessTimeUtc(string path, System.DateTime lastAccessTimeUtc) { }
        public static void SetLastWriteTime(string path, System.DateTime lastWriteTime) { }
        public static void SetLastWriteTimeUtc(string path, System.DateTime lastWriteTimeUtc) { }
        public static void WriteAllBytes(string path, byte[] bytes) { }
        public static System.Threading.Tasks.Task WriteAllBytesAsync(string path, byte[] bytes, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static void WriteAllLines(string path, System.Collections.Generic.IEnumerable<string> contents) { }
        public static void WriteAllLines(string path, System.Collections.Generic.IEnumerable<string> contents, System.Text.Encoding encoding) { }
        public static void WriteAllLines(string path, string[] contents) { }
        public static void WriteAllLines(string path, string[] contents, System.Text.Encoding encoding) { }
        public static System.Threading.Tasks.Task WriteAllLinesAsync(string path, System.Collections.Generic.IEnumerable<string> contents, System.Text.Encoding encoding, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task WriteAllLinesAsync(string path, System.Collections.Generic.IEnumerable<string> contents, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static void WriteAllText(string path, string contents) { }
        public static void WriteAllText(string path, string contents, System.Text.Encoding encoding) { }
        public static System.Threading.Tasks.Task WriteAllTextAsync(string path, string contents, System.Text.Encoding encoding, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task WriteAllTextAsync(string path, string contents, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    [System.FlagsAttribute]
    public enum FileAccess
    {
        Read = 1,
        ReadWrite = 3,
        Write = 2,
    }
    [System.FlagsAttribute]
    public enum FileAttributes
    {
        Archive = 32,
        Compressed = 2048,
        Device = 64,
        Directory = 16,
        Encrypted = 16384,
        Hidden = 2,
        IntegrityStream = 32768,
        Normal = 128,
        NoScrubData = 131072,
        NotContentIndexed = 8192,
        Offline = 4096,
        ReadOnly = 1,
        ReparsePoint = 1024,
        SparseFile = 512,
        System = 4,
        Temporary = 256,
    }
    public sealed partial class FileInfo : System.IO.FileSystemInfo
    {
        public FileInfo(string fileName) { }
        public System.IO.DirectoryInfo Directory { get { throw null; } }
        public string DirectoryName { get { throw null; } }
        public override bool Exists { get { throw null; } }
        public bool IsReadOnly { get { throw null; } set { } }
        public long Length { get { throw null; } }
        public override string Name { get { throw null; } }
        public System.IO.StreamWriter AppendText() { throw null; }
        public System.IO.FileInfo CopyTo(string destFileName) { throw null; }
        public System.IO.FileInfo CopyTo(string destFileName, bool overwrite) { throw null; }
        public System.IO.FileStream Create() { throw null; }
        public System.IO.StreamWriter CreateText() { throw null; }
        public void Decrypt() { }
        public override void Delete() { }
        public void Encrypt() { }
//ACLS        public System.Security.AccessControl.FileSecurity GetAccessControl() { throw null; }
//ACLS        public System.Security.AccessControl.FileSecurity GetAccessControl(System.Security.AccessControl.AccessControlSections includeSections) { throw null; }
        public void MoveTo(string destFileName) { }
        public System.IO.FileStream Open(System.IO.FileMode mode) { throw null; }
        public System.IO.FileStream Open(System.IO.FileMode mode, System.IO.FileAccess access) { throw null; }
        public System.IO.FileStream Open(System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share) { throw null; }
        public System.IO.FileStream OpenRead() { throw null; }
        public System.IO.StreamReader OpenText() { throw null; }
        public System.IO.FileStream OpenWrite() { throw null; }
        public System.IO.FileInfo Replace(string destinationFileName, string destinationBackupFileName) { throw null; }
        public System.IO.FileInfo Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors) { throw null; }
//ACLS        public void SetAccessControl(System.Security.AccessControl.FileSecurity fileSecurity) { }
        public override string ToString() { throw null; }
    }
    public partial class FileLoadException : System.IO.IOException
    {
        public FileLoadException() { }
        protected FileLoadException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public FileLoadException(string message) { }
        public FileLoadException(string message, System.Exception inner) { }
        public FileLoadException(string message, string fileName) { }
        public FileLoadException(string message, string fileName, System.Exception inner) { }
        public string FileName { get { throw null; } }
        public string FusionLog { get { throw null; } }
        public override string Message { get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public override string ToString() { throw null; }
    }
    public enum FileMode
    {
        Append = 6,
        Create = 2,
        CreateNew = 1,
        Open = 3,
        OpenOrCreate = 4,
        Truncate = 5,
    }
    public partial class FileNotFoundException : System.IO.IOException
    {
        public FileNotFoundException() { }
        protected FileNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public FileNotFoundException(string message) { }
        public FileNotFoundException(string message, System.Exception innerException) { }
        public FileNotFoundException(string message, string fileName) { }
        public FileNotFoundException(string message, string fileName, System.Exception innerException) { }
        public string FileName { get { throw null; } }
        public string FusionLog { get { throw null; } }
        public override string Message { get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public override string ToString() { throw null; }
    }
    [System.FlagsAttribute]
    public enum FileOptions
    {
        Asynchronous = 1073741824,
        DeleteOnClose = 67108864,
        Encrypted = 16384,
        None = 0,
        RandomAccess = 268435456,
        SequentialScan = 134217728,
        WriteThrough = -2147483648,
    }
    [System.FlagsAttribute]
    public enum FileShare
    {
        Delete = 4,
        Inheritable = 16,
        None = 0,
        Read = 1,
        ReadWrite = 3,
        Write = 2,
    }
    public partial class FileStream : System.IO.Stream
    {
        public FileStream(Microsoft.Win32.SafeHandles.SafeFileHandle handle, System.IO.FileAccess access) { }
        public FileStream(Microsoft.Win32.SafeHandles.SafeFileHandle handle, System.IO.FileAccess access, int bufferSize) { }
        public FileStream(Microsoft.Win32.SafeHandles.SafeFileHandle handle, System.IO.FileAccess access, int bufferSize, bool isAsync) { }
        [System.ObsoleteAttribute("This constructor has been deprecated.  Please use new FileStream(SafeFileHandle handle, FileAccess access) instead.  https://go.microsoft.com/fwlink/?linkid=14202")]
        public FileStream(System.IntPtr handle, System.IO.FileAccess access) { }
        [System.ObsoleteAttribute("This constructor has been deprecated.  Please use new FileStream(SafeFileHandle handle, FileAccess access) instead, and optionally make a new SafeFileHandle with ownsHandle=false if needed.  https://go.microsoft.com/fwlink/?linkid=14202")]
        public FileStream(System.IntPtr handle, System.IO.FileAccess access, bool ownsHandle) { }
        [System.ObsoleteAttribute("This constructor has been deprecated.  Please use new FileStream(SafeFileHandle handle, FileAccess access, int bufferSize) instead, and optionally make a new SafeFileHandle with ownsHandle=false if needed.  https://go.microsoft.com/fwlink/?linkid=14202")]
        public FileStream(System.IntPtr handle, System.IO.FileAccess access, bool ownsHandle, int bufferSize) { }
        [System.ObsoleteAttribute("This constructor has been deprecated.  Please use new FileStream(SafeFileHandle handle, FileAccess access, int bufferSize, bool isAsync) instead, and optionally make a new SafeFileHandle with ownsHandle=false if needed.  https://go.microsoft.com/fwlink/?linkid=14202")]
        public FileStream(System.IntPtr handle, System.IO.FileAccess access, bool ownsHandle, int bufferSize, bool isAsync) { }
        public FileStream(string path, System.IO.FileMode mode) { }
        public FileStream(string path, System.IO.FileMode mode, System.IO.FileAccess access) { }
        public FileStream(string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share) { }
        public FileStream(string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share, int bufferSize) { }
        public FileStream(string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share, int bufferSize, bool useAsync) { }
        public FileStream(string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share, int bufferSize, System.IO.FileOptions options) { }
//ACLS        public FileStream(string path, System.IO.FileMode mode, System.Security.AccessControl.FileSystemRights rights, System.IO.FileShare share, int bufferSize, System.IO.FileOptions options) { }
//ACLS        public FileStream(string path, System.IO.FileMode mode, System.Security.AccessControl.FileSystemRights rights, System.IO.FileShare share, int bufferSize, System.IO.FileOptions options, System.Security.AccessControl.FileSecurity fileSecurity) { }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        [System.ObsoleteAttribute("This property has been deprecated.  Please use FileStream's SafeFileHandle property instead.  https://go.microsoft.com/fwlink/?linkid=14202")]
        public virtual System.IntPtr Handle { get { throw null; } }
        public virtual bool IsAsync { get { throw null; } }
        public override long Length { get { throw null; } }
        public virtual string Name { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        public virtual Microsoft.Win32.SafeHandles.SafeFileHandle SafeFileHandle { get { throw null; } }
        public override System.IAsyncResult BeginRead(byte[] array, int offset, int numBytes, System.AsyncCallback callback, object state) { throw null; }
        public override System.IAsyncResult BeginWrite(byte[] array, int offset, int numBytes, System.AsyncCallback callback, object state) { throw null; }
        public override System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination, int bufferSize, System.Threading.CancellationToken cancellationToken) { throw null; }
        protected override void Dispose(bool disposing) { }
        public override System.Threading.Tasks.ValueTask DisposeAsync() { throw null; }
        public override int EndRead(System.IAsyncResult asyncResult) { throw null; }
        public override void EndWrite(System.IAsyncResult asyncResult) { }
        ~FileStream() { }
        public override void Flush() { }
        public virtual void Flush(bool flushToDisk) { }
        public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
//ACLS        public System.Security.AccessControl.FileSecurity GetAccessControl() { throw null; }
        public virtual void Lock(long position, long length) { }
        public override int Read(byte[] array, int offset, int count) { throw null; }
        public override int Read(System.Span<byte> buffer) { throw null; }
        public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.ValueTask<int> ReadAsync(System.Memory<byte> buffer, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override int ReadByte() { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
//ACLS        public void SetAccessControl(System.Security.AccessControl.FileSecurity fileSecurity) { }
        public override void SetLength(long value) { }
        public virtual void Unlock(long position, long length) { }
        public override void Write(byte[] array, int offset, int count) { }
        public override void Write(System.ReadOnlySpan<byte> buffer) { }
        public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<byte> buffer, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override void WriteByte(byte value) { }
    }
    public partial class FileSystemEventArgs : System.EventArgs
    {
        public FileSystemEventArgs(System.IO.WatcherChangeTypes changeType, string directory, string name) { }
        public System.IO.WatcherChangeTypes ChangeType { get { throw null; } }
        public string FullPath { get { throw null; } }
        public string Name { get { throw null; } }
    }
    public delegate void FileSystemEventHandler(object sender, System.IO.FileSystemEventArgs e);
    public abstract partial class FileSystemInfo : System.MarshalByRefObject, System.Runtime.Serialization.ISerializable
    {
        protected string FullPath;
        protected string OriginalPath;
        protected FileSystemInfo() { }
        protected FileSystemInfo(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public System.IO.FileAttributes Attributes { get { throw null; } set { } }
        public System.DateTime CreationTime { get { throw null; } set { } }
        public System.DateTime CreationTimeUtc { get { throw null; } set { } }
        public abstract bool Exists { get; }
        public string Extension { get { throw null; } }
        public virtual string FullName { get { throw null; } }
        public System.DateTime LastAccessTime { get { throw null; } set { } }
        public System.DateTime LastAccessTimeUtc { get { throw null; } set { } }
        public System.DateTime LastWriteTime { get { throw null; } set { } }
        public System.DateTime LastWriteTimeUtc { get { throw null; } set { } }
        public abstract string Name { get; }
        public abstract void Delete();
        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public void Refresh() { }
        public override string ToString() { throw null; }
    }
    [System.ComponentModel.DefaultEventAttribute("Changed")]
    public partial class FileSystemWatcher : System.ComponentModel.Component, System.ComponentModel.ISupportInitialize
    {
        public FileSystemWatcher() { }
        public FileSystemWatcher(string path) { }
        public FileSystemWatcher(string path, string filter) { }
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool EnableRaisingEvents { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("*.*")]
        [System.ComponentModel.SettingsBindableAttribute(true)]
        public string Filter { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool IncludeSubdirectories { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute(8192)]
        public int InternalBufferSize { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(System.IO.NotifyFilters.DirectoryName | System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.LastWrite)]
        public System.IO.NotifyFilters NotifyFilter { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.SettingsBindableAttribute(true)]
        public string Path { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public override System.ComponentModel.ISite Site { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute(null)]
        public System.ComponentModel.ISynchronizeInvoke SynchronizingObject { get { throw null; } set { } }
        public event System.IO.FileSystemEventHandler Changed { add { } remove { } }
        public event System.IO.FileSystemEventHandler Created { add { } remove { } }
        public event System.IO.FileSystemEventHandler Deleted { add { } remove { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public event System.IO.ErrorEventHandler Error { add { } remove { } }
        public event System.IO.RenamedEventHandler Renamed { add { } remove { } }
        public void BeginInit() { }
        protected override void Dispose(bool disposing) { }
        public void EndInit() { }
        protected void OnChanged(System.IO.FileSystemEventArgs e) { }
        protected void OnCreated(System.IO.FileSystemEventArgs e) { }
        protected void OnDeleted(System.IO.FileSystemEventArgs e) { }
        protected void OnError(System.IO.ErrorEventArgs e) { }
        protected void OnRenamed(System.IO.RenamedEventArgs e) { }
        public System.IO.WaitForChangedResult WaitForChanged(System.IO.WatcherChangeTypes changeType) { throw null; }
        public System.IO.WaitForChangedResult WaitForChanged(System.IO.WatcherChangeTypes changeType, int timeout) { throw null; }
    }
    public enum HandleInheritability
    {
        Inheritable = 1,
        None = 0,
    }
    public partial class InternalBufferOverflowException : System.SystemException
    {
        public InternalBufferOverflowException() { }
        protected InternalBufferOverflowException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public InternalBufferOverflowException(string message) { }
        public InternalBufferOverflowException(string message, System.Exception inner) { }
    }
    public sealed partial class InvalidDataException : System.SystemException
    {
        public InvalidDataException() { }
        public InvalidDataException(string message) { }
        public InvalidDataException(string message, System.Exception innerException) { }
    }
    public partial class IOException : System.SystemException
    {
        public IOException() { }
        protected IOException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public IOException(string message) { }
        public IOException(string message, System.Exception innerException) { }
        public IOException(string message, int hresult) { }
    }
    public enum MatchCasing
    {
        CaseInsensitive = 2,
        CaseSensitive = 1,
        PlatformDefault = 0,
    }
    public enum MatchType
    {
        Simple = 0,
        Win32 = 1,
    }
    public partial class MemoryStream : System.IO.Stream
    {
        public MemoryStream() { }
        public MemoryStream(byte[] buffer) { }
        public MemoryStream(byte[] buffer, bool writable) { }
        public MemoryStream(byte[] buffer, int index, int count) { }
        public MemoryStream(byte[] buffer, int index, int count, bool writable) { }
        public MemoryStream(byte[] buffer, int index, int count, bool writable, bool publiclyVisible) { }
        public MemoryStream(int capacity) { }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public virtual int Capacity { get { throw null; } set { } }
        public override long Length { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        public override System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { throw null; }
        public override System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { throw null; }
        public override void CopyTo(System.IO.Stream destination, int bufferSize) { }
        public override System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination, int bufferSize, System.Threading.CancellationToken cancellationToken) { throw null; }
        protected override void Dispose(bool disposing) { }
        public override int EndRead(System.IAsyncResult asyncResult) { throw null; }
        public override void EndWrite(System.IAsyncResult asyncResult) { }
        public override void Flush() { }
        public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual byte[] GetBuffer() { throw null; }
        public override int Read(byte[] buffer, int offset, int count) { throw null; }
        public override int Read(System.Span<byte> destination) { throw null; }
        public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.ValueTask<int> ReadAsync(System.Memory<byte> destination, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override int ReadByte() { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin loc) { throw null; }
        public override void SetLength(long value) { }
        public virtual byte[] ToArray() { throw null; }
        public virtual bool TryGetBuffer(out System.ArraySegment<byte> buffer) { throw null; }
        public override void Write(byte[] buffer, int offset, int count) { }
        public override void Write(System.ReadOnlySpan<byte> source) { }
        public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<byte> source, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override void WriteByte(byte value) { }
        public virtual void WriteTo(System.IO.Stream stream) { }
    }
    [System.FlagsAttribute]
    public enum NotifyFilters
    {
        Attributes = 4,
        CreationTime = 64,
        DirectoryName = 2,
        FileName = 1,
        LastAccess = 32,
        LastWrite = 16,
        Security = 256,
        Size = 8,
    }
    public static partial class Path
    {
        public static readonly char AltDirectorySeparatorChar;
        public static readonly char DirectorySeparatorChar;
        [System.ObsoleteAttribute("Please use GetInvalidPathChars or GetInvalidFileNameChars instead.")]
        public static readonly char[] InvalidPathChars;
        public static readonly char PathSeparator;
        public static readonly char VolumeSeparatorChar;
        public static string ChangeExtension(string path, string extension) { throw null; }
        public static string Combine(string path1, string path2) { throw null; }
        public static string Combine(string path1, string path2, string path3) { throw null; }
        public static string Combine(string path1, string path2, string path3, string path4) { throw null; }
        public static string Combine(params string[] paths) { throw null; }
        public static System.ReadOnlySpan<char> GetDirectoryName(System.ReadOnlySpan<char> path) { throw null; }
        public static string GetDirectoryName(string path) { throw null; }
        public static System.ReadOnlySpan<char> GetExtension(System.ReadOnlySpan<char> path) { throw null; }
        public static string GetExtension(string path) { throw null; }
        public static System.ReadOnlySpan<char> GetFileName(System.ReadOnlySpan<char> path) { throw null; }
        public static string GetFileName(string path) { throw null; }
        public static System.ReadOnlySpan<char> GetFileNameWithoutExtension(System.ReadOnlySpan<char> path) { throw null; }
        public static string GetFileNameWithoutExtension(string path) { throw null; }
        public static string GetFullPath(string path) { throw null; }
        public static string GetFullPath(string path, string basePath) { throw null; }
        public static char[] GetInvalidFileNameChars() { throw null; }
        public static char[] GetInvalidPathChars() { throw null; }
        public static System.ReadOnlySpan<char> GetPathRoot(System.ReadOnlySpan<char> path) { throw null; }
        public static string GetPathRoot(string path) { throw null; }
        public static string GetRandomFileName() { throw null; }
        public static string GetRelativePath(string relativeTo, string path) { throw null; }
        public static string GetTempFileName() { throw null; }
        public static string GetTempPath() { throw null; }
        public static bool HasExtension(System.ReadOnlySpan<char> path) { throw null; }
        public static bool HasExtension(string path) { throw null; }
        public static bool IsPathFullyQualified(System.ReadOnlySpan<char> path) { throw null; }
        public static bool IsPathFullyQualified(string path) { throw null; }
        public static bool IsPathRooted(System.ReadOnlySpan<char> path) { throw null; }
        public static bool IsPathRooted(string path) { throw null; }
        public static string Join(System.ReadOnlySpan<char> path1, System.ReadOnlySpan<char> path2) { throw null; }
        public static string Join(System.ReadOnlySpan<char> path1, System.ReadOnlySpan<char> path2, System.ReadOnlySpan<char> path3) { throw null; }
        public static bool TryJoin(System.ReadOnlySpan<char> path1, System.ReadOnlySpan<char> path2, System.ReadOnlySpan<char> path3, System.Span<char> destination, out int charsWritten) { throw null; }
        public static bool TryJoin(System.ReadOnlySpan<char> path1, System.ReadOnlySpan<char> path2, System.Span<char> destination, out int charsWritten) { throw null; }
    }
    public partial class PathTooLongException : System.IO.IOException
    {
        public PathTooLongException() { }
        protected PathTooLongException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public PathTooLongException(string message) { }
        public PathTooLongException(string message, System.Exception innerException) { }
    }
    public partial class RenamedEventArgs : System.IO.FileSystemEventArgs
    {
        public RenamedEventArgs(System.IO.WatcherChangeTypes changeType, string directory, string name, string oldName) : base (default(System.IO.WatcherChangeTypes), default(string), default(string)) { }
        public string OldFullPath { get { throw null; } }
        public string OldName { get { throw null; } }
    }
    public delegate void RenamedEventHandler(object sender, System.IO.RenamedEventArgs e);
    public enum SearchOption
    {
        AllDirectories = 1,
        TopDirectoryOnly = 0,
    }
    public enum SeekOrigin
    {
        Begin = 0,
        Current = 1,
        End = 2,
    }
    public abstract partial class Stream : System.MarshalByRefObject, System.IAsyncDisposable, System.IDisposable
    {
        public static readonly System.IO.Stream Null;
        protected Stream() { }
        public abstract bool CanRead { get; }
        public abstract bool CanSeek { get; }
        public virtual bool CanTimeout { get { throw null; } }
        public abstract bool CanWrite { get; }
        public abstract long Length { get; }
        public abstract long Position { get; set; }
        public virtual int ReadTimeout { get { throw null; } set { } }
        public virtual int WriteTimeout { get { throw null; } set { } }
        public virtual System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { throw null; }
        public virtual System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { throw null; }
        public virtual void Close() { }
        public void CopyTo(System.IO.Stream destination) { }
        public virtual void CopyTo(System.IO.Stream destination, int bufferSize) { }
        public System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination) { throw null; }
        public System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination, int bufferSize) { throw null; }
        public virtual System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination, int bufferSize, System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination, System.Threading.CancellationToken cancellationToken) { throw null; }
        [System.ObsoleteAttribute("CreateWaitHandle will be removed eventually.  Please use \"new ManualResetEvent(false)\" instead.")]
        protected virtual System.Threading.WaitHandle CreateWaitHandle() { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public virtual System.Threading.Tasks.ValueTask DisposeAsync() { throw null; }
        public virtual int EndRead(System.IAsyncResult asyncResult) { throw null; }
        public virtual void EndWrite(System.IAsyncResult asyncResult) { }
        public abstract void Flush();
        public System.Threading.Tasks.Task FlushAsync() { throw null; }
        public virtual System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        [System.ObsoleteAttribute("Do not call or override this method.")]
        protected virtual void ObjectInvariant() { }
        public abstract int Read(byte[] buffer, int offset, int count);
        public virtual int Read(System.Span<byte> buffer) { throw null; }
        public System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count) { throw null; }
        public virtual System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual System.Threading.Tasks.ValueTask<int> ReadAsync(System.Memory<byte> buffer, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual int ReadByte() { throw null; }
        public abstract long Seek(long offset, System.IO.SeekOrigin origin);
        public abstract void SetLength(long value);
        public static System.IO.Stream Synchronized(System.IO.Stream stream) { throw null; }
        public abstract void Write(byte[] buffer, int offset, int count);
        public virtual void Write(System.ReadOnlySpan<byte> buffer) { }
        public System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count) { throw null; }
        public virtual System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<byte> buffer, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual void WriteByte(byte value) { }
    }
    public partial class StreamReader : System.IO.TextReader
    {
        public static readonly new System.IO.StreamReader Null;
        public StreamReader(System.IO.Stream stream) { }
        public StreamReader(System.IO.Stream stream, bool detectEncodingFromByteOrderMarks) { }
        public StreamReader(System.IO.Stream stream, System.Text.Encoding encoding) { }
        public StreamReader(System.IO.Stream stream, System.Text.Encoding encoding, bool detectEncodingFromByteOrderMarks) { }
        public StreamReader(System.IO.Stream stream, System.Text.Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize) { }
        public StreamReader(System.IO.Stream stream, System.Text.Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }
        public StreamReader(string path) { }
        public StreamReader(string path, bool detectEncodingFromByteOrderMarks) { }
        public StreamReader(string path, System.Text.Encoding encoding) { }
        public StreamReader(string path, System.Text.Encoding encoding, bool detectEncodingFromByteOrderMarks) { }
        public StreamReader(string path, System.Text.Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize) { }
        public virtual System.IO.Stream BaseStream { get { throw null; } }
        public virtual System.Text.Encoding CurrentEncoding { get { throw null; } }
        public bool EndOfStream { get { throw null; } }
        public override void Close() { }
        public void DiscardBufferedData() { }
        protected override void Dispose(bool disposing) { }
        public override int Peek() { throw null; }
        public override int Read() { throw null; }
        public override int Read(char[] buffer, int index, int count) { throw null; }
        public override int Read(System.Span<char> buffer) { throw null; }
        public override System.Threading.Tasks.Task<int> ReadAsync(char[] buffer, int index, int count) { throw null; }
        public override System.Threading.Tasks.ValueTask<int> ReadAsync(System.Memory<char> buffer, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override int ReadBlock(char[] buffer, int index, int count) { throw null; }
        public override int ReadBlock(System.Span<char> buffer) { throw null; }
        public override System.Threading.Tasks.Task<int> ReadBlockAsync(char[] buffer, int index, int count) { throw null; }
        public override System.Threading.Tasks.ValueTask<int> ReadBlockAsync(System.Memory<char> buffer, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override string ReadLine() { throw null; }
        public override System.Threading.Tasks.Task<string> ReadLineAsync() { throw null; }
        public override string ReadToEnd() { throw null; }
        public override System.Threading.Tasks.Task<string> ReadToEndAsync() { throw null; }
    }
    public partial class StreamWriter : System.IO.TextWriter
    {
        public static readonly new System.IO.StreamWriter Null;
        public StreamWriter(System.IO.Stream stream) { }
        public StreamWriter(System.IO.Stream stream, System.Text.Encoding encoding) { }
        public StreamWriter(System.IO.Stream stream, System.Text.Encoding encoding, int bufferSize) { }
        public StreamWriter(System.IO.Stream stream, System.Text.Encoding encoding, int bufferSize, bool leaveOpen) { }
        public StreamWriter(string path) { }
        public StreamWriter(string path, bool append) { }
        public StreamWriter(string path, bool append, System.Text.Encoding encoding) { }
        public StreamWriter(string path, bool append, System.Text.Encoding encoding, int bufferSize) { }
        public virtual bool AutoFlush { get { throw null; } set { } }
        public virtual System.IO.Stream BaseStream { get { throw null; } }
        public override System.Text.Encoding Encoding { get { throw null; } }
        public override void Close() { }
        protected override void Dispose(bool disposing) { }
        public override System.Threading.Tasks.ValueTask DisposeAsync() { throw null; }
        public override void Flush() { }
        public override System.Threading.Tasks.Task FlushAsync() { throw null; }
        public override void Write(char value) { }
        public override void Write(char[] buffer) { }
        public override void Write(char[] buffer, int index, int count) { }
        public override void Write(System.ReadOnlySpan<char> buffer) { }
        public override void Write(string value) { }
        public override System.Threading.Tasks.Task WriteAsync(char value) { throw null; }
        public override System.Threading.Tasks.Task WriteAsync(char[] buffer, int index, int count) { throw null; }
        public override System.Threading.Tasks.Task WriteAsync(System.ReadOnlyMemory<char> buffer, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.Task WriteAsync(string value) { throw null; }
        public override void WriteLine(System.ReadOnlySpan<char> buffer) { }
        public override void WriteLine(string value) { }
        public override System.Threading.Tasks.Task WriteLineAsync() { throw null; }
        public override System.Threading.Tasks.Task WriteLineAsync(char value) { throw null; }
        public override System.Threading.Tasks.Task WriteLineAsync(char[] buffer, int index, int count) { throw null; }
        public override System.Threading.Tasks.Task WriteLineAsync(System.ReadOnlyMemory<char> buffer, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.Task WriteLineAsync(string value) { throw null; }
    }
    public partial class StringReader : System.IO.TextReader
    {
        public StringReader(string s) { }
        public override void Close() { }
        protected override void Dispose(bool disposing) { }
        public override int Peek() { throw null; }
        public override int Read() { throw null; }
        public override int Read(char[] buffer, int index, int count) { throw null; }
        public override int Read(System.Span<char> buffer) { throw null; }
        public override System.Threading.Tasks.Task<int> ReadAsync(char[] buffer, int index, int count) { throw null; }
        public override System.Threading.Tasks.ValueTask<int> ReadAsync(System.Memory<char> buffer, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override int ReadBlock(System.Span<char> buffer) { throw null; }
        public override System.Threading.Tasks.Task<int> ReadBlockAsync(char[] buffer, int index, int count) { throw null; }
        public override System.Threading.Tasks.ValueTask<int> ReadBlockAsync(System.Memory<char> buffer, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override string ReadLine() { throw null; }
        public override System.Threading.Tasks.Task<string> ReadLineAsync() { throw null; }
        public override string ReadToEnd() { throw null; }
        public override System.Threading.Tasks.Task<string> ReadToEndAsync() { throw null; }
    }
    public partial class StringWriter : System.IO.TextWriter
    {
        public StringWriter() { }
        public StringWriter(System.IFormatProvider formatProvider) { }
        public StringWriter(System.Text.StringBuilder sb) { }
        public StringWriter(System.Text.StringBuilder sb, System.IFormatProvider formatProvider) { }
        public override System.Text.Encoding Encoding { get { throw null; } }
        public override void Close() { }
        protected override void Dispose(bool disposing) { }
        public override System.Threading.Tasks.Task FlushAsync() { throw null; }
        public virtual System.Text.StringBuilder GetStringBuilder() { throw null; }
        public override string ToString() { throw null; }
        public override void Write(char value) { }
        public override void Write(char[] buffer, int index, int count) { }
        public override void Write(System.ReadOnlySpan<char> buffer) { }
        public override void Write(string value) { }
        public override System.Threading.Tasks.Task WriteAsync(char value) { throw null; }
        public override System.Threading.Tasks.Task WriteAsync(char[] buffer, int index, int count) { throw null; }
        public override System.Threading.Tasks.Task WriteAsync(System.ReadOnlyMemory<char> buffer, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.Task WriteAsync(string value) { throw null; }
        public override void WriteLine(System.ReadOnlySpan<char> buffer) { }
        public override System.Threading.Tasks.Task WriteLineAsync(char value) { throw null; }
        public override System.Threading.Tasks.Task WriteLineAsync(char[] buffer, int index, int count) { throw null; }
        public override System.Threading.Tasks.Task WriteLineAsync(System.ReadOnlyMemory<char> buffer, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.Task WriteLineAsync(string value) { throw null; }
    }
    public abstract partial class TextReader : System.MarshalByRefObject, System.IDisposable
    {
        public static readonly System.IO.TextReader Null;
        protected TextReader() { }
        public virtual void Close() { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public virtual int Peek() { throw null; }
        public virtual int Read() { throw null; }
        public virtual int Read(char[] buffer, int index, int count) { throw null; }
        public virtual int Read(System.Span<char> buffer) { throw null; }
        public virtual System.Threading.Tasks.Task<int> ReadAsync(char[] buffer, int index, int count) { throw null; }
        public virtual System.Threading.Tasks.ValueTask<int> ReadAsync(System.Memory<char> buffer, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual int ReadBlock(char[] buffer, int index, int count) { throw null; }
        public virtual int ReadBlock(System.Span<char> buffer) { throw null; }
        public virtual System.Threading.Tasks.Task<int> ReadBlockAsync(char[] buffer, int index, int count) { throw null; }
        public virtual System.Threading.Tasks.ValueTask<int> ReadBlockAsync(System.Memory<char> buffer, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual string ReadLine() { throw null; }
        public virtual System.Threading.Tasks.Task<string> ReadLineAsync() { throw null; }
        public virtual string ReadToEnd() { throw null; }
        public virtual System.Threading.Tasks.Task<string> ReadToEndAsync() { throw null; }
        public static System.IO.TextReader Synchronized(System.IO.TextReader reader) { throw null; }
    }
    public abstract partial class TextWriter : System.MarshalByRefObject, System.IAsyncDisposable, System.IDisposable
    {
        protected char[] CoreNewLine;
        public static readonly System.IO.TextWriter Null;
        protected TextWriter() { }
        protected TextWriter(System.IFormatProvider formatProvider) { }
        public abstract System.Text.Encoding Encoding { get; }
        public virtual System.IFormatProvider FormatProvider { get { throw null; } }
        public virtual string NewLine { get { throw null; } set { } }
        public virtual void Close() { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public virtual System.Threading.Tasks.ValueTask DisposeAsync() { throw null; }
        public virtual void Flush() { }
        public virtual System.Threading.Tasks.Task FlushAsync() { throw null; }
        public static System.IO.TextWriter Synchronized(System.IO.TextWriter writer) { throw null; }
        public virtual void Write(bool value) { }
        public virtual void Write(char value) { }
        public virtual void Write(char[] buffer) { }
        public virtual void Write(char[] buffer, int index, int count) { }
        public virtual void Write(decimal value) { }
        public virtual void Write(double value) { }
        public virtual void Write(int value) { }
        public virtual void Write(long value) { }
        public virtual void Write(object value) { }
        public virtual void Write(System.ReadOnlySpan<char> buffer) { }
        public virtual void Write(float value) { }
        public virtual void Write(string value) { }
        public virtual void Write(string format, object arg0) { }
        public virtual void Write(string format, object arg0, object arg1) { }
        public virtual void Write(string format, object arg0, object arg1, object arg2) { }
        public virtual void Write(string format, params object[] arg) { }
        [System.CLSCompliantAttribute(false)]
        public virtual void Write(uint value) { }
        [System.CLSCompliantAttribute(false)]
        public virtual void Write(ulong value) { }
        public virtual System.Threading.Tasks.Task WriteAsync(char value) { throw null; }
        public System.Threading.Tasks.Task WriteAsync(char[] buffer) { throw null; }
        public virtual System.Threading.Tasks.Task WriteAsync(char[] buffer, int index, int count) { throw null; }
        public virtual System.Threading.Tasks.Task WriteAsync(System.ReadOnlyMemory<char> buffer, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task WriteAsync(string value) { throw null; }
        public virtual void WriteLine() { }
        public virtual void WriteLine(bool value) { }
        public virtual void WriteLine(char value) { }
        public virtual void WriteLine(char[] buffer) { }
        public virtual void WriteLine(char[] buffer, int index, int count) { }
        public virtual void WriteLine(decimal value) { }
        public virtual void WriteLine(double value) { }
        public virtual void WriteLine(int value) { }
        public virtual void WriteLine(long value) { }
        public virtual void WriteLine(object value) { }
        public virtual void WriteLine(System.ReadOnlySpan<char> buffer) { }
        public virtual void WriteLine(float value) { }
        public virtual void WriteLine(string value) { }
        public virtual void WriteLine(string format, object arg0) { }
        public virtual void WriteLine(string format, object arg0, object arg1) { }
        public virtual void WriteLine(string format, object arg0, object arg1, object arg2) { }
        public virtual void WriteLine(string format, params object[] arg) { }
        [System.CLSCompliantAttribute(false)]
        public virtual void WriteLine(uint value) { }
        [System.CLSCompliantAttribute(false)]
        public virtual void WriteLine(ulong value) { }
        public virtual System.Threading.Tasks.Task WriteLineAsync() { throw null; }
        public virtual System.Threading.Tasks.Task WriteLineAsync(char value) { throw null; }
        public System.Threading.Tasks.Task WriteLineAsync(char[] buffer) { throw null; }
        public virtual System.Threading.Tasks.Task WriteLineAsync(char[] buffer, int index, int count) { throw null; }
        public virtual System.Threading.Tasks.Task WriteLineAsync(System.ReadOnlyMemory<char> buffer, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task WriteLineAsync(string value) { throw null; }
    }
    public partial class UnmanagedMemoryAccessor : System.IDisposable
    {
        protected UnmanagedMemoryAccessor() { }
        public UnmanagedMemoryAccessor(System.Runtime.InteropServices.SafeBuffer buffer, long offset, long capacity) { }
        public UnmanagedMemoryAccessor(System.Runtime.InteropServices.SafeBuffer buffer, long offset, long capacity, System.IO.FileAccess access) { }
        public bool CanRead { get { throw null; } }
        public bool CanWrite { get { throw null; } }
        public long Capacity { get { throw null; } }
        protected bool IsOpen { get { throw null; } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        protected void Initialize(System.Runtime.InteropServices.SafeBuffer buffer, long offset, long capacity, System.IO.FileAccess access) { }
        public int ReadArray<T>(long position, T[] array, int offset, int count) where T : struct { throw null; }
        public bool ReadBoolean(long position) { throw null; }
        public byte ReadByte(long position) { throw null; }
        public char ReadChar(long position) { throw null; }
        public decimal ReadDecimal(long position) { throw null; }
        public double ReadDouble(long position) { throw null; }
        public short ReadInt16(long position) { throw null; }
        public int ReadInt32(long position) { throw null; }
        public long ReadInt64(long position) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public sbyte ReadSByte(long position) { throw null; }
        public float ReadSingle(long position) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public ushort ReadUInt16(long position) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public uint ReadUInt32(long position) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public ulong ReadUInt64(long position) { throw null; }
        public void Read<T>(long position, out T structure) where T : struct { throw null; }
        public void Write(long position, bool value) { }
        public void Write(long position, byte value) { }
        public void Write(long position, char value) { }
        public void Write(long position, decimal value) { }
        public void Write(long position, double value) { }
        public void Write(long position, short value) { }
        public void Write(long position, int value) { }
        public void Write(long position, long value) { }
        [System.CLSCompliantAttribute(false)]
        public void Write(long position, sbyte value) { }
        public void Write(long position, float value) { }
        [System.CLSCompliantAttribute(false)]
        public void Write(long position, ushort value) { }
        [System.CLSCompliantAttribute(false)]
        public void Write(long position, uint value) { }
        [System.CLSCompliantAttribute(false)]
        public void Write(long position, ulong value) { }
        public void WriteArray<T>(long position, T[] array, int offset, int count) where T : struct { }
        public void Write<T>(long position, ref T structure) where T : struct { }
    }
    public partial class UnmanagedMemoryStream : System.IO.Stream
    {
        protected UnmanagedMemoryStream() { }
        [System.CLSCompliantAttribute(false)]
        public unsafe UnmanagedMemoryStream(byte* pointer, long length) { }
        [System.CLSCompliantAttribute(false)]
        public unsafe UnmanagedMemoryStream(byte* pointer, long length, long capacity, System.IO.FileAccess access) { }
        public UnmanagedMemoryStream(System.Runtime.InteropServices.SafeBuffer buffer, long offset, long length) { }
        public UnmanagedMemoryStream(System.Runtime.InteropServices.SafeBuffer buffer, long offset, long length, System.IO.FileAccess access) { }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public long Capacity { get { throw null; } }
        public override long Length { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        [System.CLSCompliantAttribute(false)]
        public unsafe byte* PositionPointer { get { throw null; } set { } }
        protected override void Dispose(bool disposing) { }
        public override void Flush() { }
        public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        [System.CLSCompliantAttribute(false)]
        protected unsafe void Initialize(byte* pointer, long length, long capacity, System.IO.FileAccess access) { }
        protected void Initialize(System.Runtime.InteropServices.SafeBuffer buffer, long offset, long length, System.IO.FileAccess access) { }
        public override int Read(byte[] buffer, int offset, int count) { throw null; }
        public override int Read(System.Span<byte> destination) { throw null; }
        public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.ValueTask<int> ReadAsync(System.Memory<byte> buffer, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override int ReadByte() { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin loc) { throw null; }
        public override void SetLength(long value) { }
        public override void Write(byte[] buffer, int offset, int count) { }
        public override void Write(System.ReadOnlySpan<byte> source) { }
        public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<byte> buffer, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override void WriteByte(byte value) { }
    }
    public partial struct WaitForChangedResult
    {
        private object _dummy;
        public System.IO.WatcherChangeTypes ChangeType { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string OldName { get { throw null; } set { } }
        public bool TimedOut { get { throw null; } set { } }
    }
    [System.FlagsAttribute]
    public enum WatcherChangeTypes
    {
        All = 15,
        Changed = 4,
        Created = 1,
        Deleted = 2,
        Renamed = 8,
    }
}
