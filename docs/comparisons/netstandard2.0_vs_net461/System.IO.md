# System.IO

``` diff
 namespace System.IO {
     public static class Directory {
+        public static DirectoryInfo CreateDirectory(string path, DirectorySecurity directorySecurity);
+        public static DirectorySecurity GetAccessControl(string path);
+        public static DirectorySecurity GetAccessControl(string path, AccessControlSections includeSections);
+        public static void SetAccessControl(string path, DirectorySecurity directorySecurity);
     }
     public sealed class DirectoryInfo : FileSystemInfo {
+        public void Create(DirectorySecurity directorySecurity);
+        public DirectoryInfo CreateSubdirectory(string path, DirectorySecurity directorySecurity);
+        public DirectorySecurity GetAccessControl();
+        public DirectorySecurity GetAccessControl(AccessControlSections includeSections);
+        public void SetAccessControl(DirectorySecurity directorySecurity);
     }
     public static class File {
+        public static FileStream Create(string path, int bufferSize, FileOptions options, FileSecurity fileSecurity);
+        public static FileSecurity GetAccessControl(string path);
+        public static FileSecurity GetAccessControl(string path, AccessControlSections includeSections);
+        public static void SetAccessControl(string path, FileSecurity fileSecurity);
     }
+    public class FileFormatException : FormatException, ISerializable {
+        public FileFormatException();
+        protected FileFormatException(SerializationInfo info, StreamingContext context);
+        public FileFormatException(string message);
+        public FileFormatException(string message, Exception innerException);
+        public FileFormatException(Uri sourceUri);
+        public FileFormatException(Uri sourceUri, Exception innerException);
+        public FileFormatException(Uri sourceUri, string message);
+        public FileFormatException(Uri sourceUri, string message, Exception innerException);
+        public Uri SourceUri { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
     public sealed class FileInfo : FileSystemInfo {
+        public FileSecurity GetAccessControl();
+        public FileSecurity GetAccessControl(AccessControlSections includeSections);
+        public void SetAccessControl(FileSecurity fileSecurity);
     }
     public class FileStream : Stream {
+        public FileStream(string path, FileMode mode, FileSystemRights rights, FileShare share, int bufferSize, FileOptions options);
+        public FileStream(string path, FileMode mode, FileSystemRights rights, FileShare share, int bufferSize, FileOptions options, FileSecurity fileSecurity);
+        public FileSecurity GetAccessControl();
+        public void SetAccessControl(FileSecurity fileSecurity);
     }
+    public class IODescriptionAttribute : DescriptionAttribute {
+        public IODescriptionAttribute(string description);
+        public override string Description { get; }
+    }
+    public class PipeException : IOException {
+        public PipeException();
+        protected PipeException(SerializationInfo info, StreamingContext context);
+        public PipeException(string message);
+        public PipeException(string message, Exception inner);
+        public PipeException(string message, int errorCode);
+        public virtual int ErrorCode { get; }
+    }
 }
```

