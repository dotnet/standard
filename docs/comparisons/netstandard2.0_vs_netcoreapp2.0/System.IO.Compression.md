# System.IO.Compression

``` diff
 namespace System.IO.Compression {
     public class DeflateStream : Stream {
-        public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState);
+        public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState);
+        public override Task<int> ReadAsync(byte[] array, int offset, int count, CancellationToken cancellationToken);
+        public override Task WriteAsync(byte[] array, int offset, int count, CancellationToken cancellationToken);
     }
     public class GZipStream : Stream {
+        public override Task<int> ReadAsync(byte[] array, int offset, int count, CancellationToken cancellationToken);
+        public override Task WriteAsync(byte[] array, int offset, int count, CancellationToken cancellationToken);
     }
     public class ZipArchiveEntry {
+        public int ExternalAttributes { get; set; }
     }
     public static class ZipFile {
+        public static void ExtractToDirectory(string sourceArchiveFileName, string destinationDirectoryName, bool overwriteFiles);
+        public static void ExtractToDirectory(string sourceArchiveFileName, string destinationDirectoryName, Encoding entryNameEncoding, bool overwriteFiles);
     }
     public static class ZipFileExtensions {
+        public static void ExtractToDirectory(this ZipArchive source, string destinationDirectoryName, bool overwriteFiles);
     }
 }
```

