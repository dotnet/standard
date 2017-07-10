# System.IO

``` diff
 namespace System.IO {
     public sealed class BufferedStream : Stream {
+        public int BufferSize { get; }
+        public Stream UnderlyingStream { get; }
     }
     public static class File {
+        public static Task AppendAllLinesAsync(string path, IEnumerable<string> contents, Encoding encoding, CancellationToken cancellationToken=default(CancellationToken));
+        public static Task AppendAllLinesAsync(string path, IEnumerable<string> contents, CancellationToken cancellationToken=default(CancellationToken));
+        public static Task AppendAllTextAsync(string path, string contents, Encoding encoding, CancellationToken cancellationToken=default(CancellationToken));
+        public static Task AppendAllTextAsync(string path, string contents, CancellationToken cancellationToken=default(CancellationToken));
+        public static Task<byte[]> ReadAllBytesAsync(string path, CancellationToken cancellationToken=default(CancellationToken));
+        public static Task<string[]> ReadAllLinesAsync(string path, Encoding encoding, CancellationToken cancellationToken=default(CancellationToken));
+        public static Task<string[]> ReadAllLinesAsync(string path, CancellationToken cancellationToken=default(CancellationToken));
+        public static Task<string> ReadAllTextAsync(string path, Encoding encoding, CancellationToken cancellationToken=default(CancellationToken));
+        public static Task<string> ReadAllTextAsync(string path, CancellationToken cancellationToken=default(CancellationToken));
+        public static Task WriteAllBytesAsync(string path, byte[] bytes, CancellationToken cancellationToken=default(CancellationToken));
+        public static Task WriteAllLinesAsync(string path, IEnumerable<string> contents, Encoding encoding, CancellationToken cancellationToken=default(CancellationToken));
+        public static Task WriteAllLinesAsync(string path, IEnumerable<string> contents, CancellationToken cancellationToken=default(CancellationToken));
+        public static Task WriteAllTextAsync(string path, string contents, Encoding encoding, CancellationToken cancellationToken=default(CancellationToken));
+        public static Task WriteAllTextAsync(string path, string contents, CancellationToken cancellationToken=default(CancellationToken));
     }
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
     public class FileStream : Stream {
-        public override IAsyncResult BeginRead(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject);
+        public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state);
-        public override IAsyncResult BeginWrite(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject);
+        public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state);
     }
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
     public class MemoryStream : Stream {
+        public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state);
+        public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state);
+        public override void CopyTo(Stream destination, int bufferSize);
+        public override int EndRead(IAsyncResult asyncResult);
+        public override void EndWrite(IAsyncResult asyncResult);
     }
     public static class Path {
+        public static string GetRelativePath(string relativeTo, string path);
     }
     public abstract class Stream : MarshalByRefObject, IDisposable {
-        public void CopyTo(Stream destination, int bufferSize);
+        public virtual void CopyTo(Stream destination, int bufferSize);
     }
 }
```

