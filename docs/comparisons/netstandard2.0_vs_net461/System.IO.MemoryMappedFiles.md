# System.IO.MemoryMappedFiles

``` diff
 namespace System.IO.MemoryMappedFiles {
     public class MemoryMappedFile : IDisposable {
+        public static MemoryMappedFile CreateFromFile(FileStream fileStream, string mapName, long capacity, MemoryMappedFileAccess access, MemoryMappedFileSecurity memoryMappedFileSecurity, HandleInheritability inheritability, bool leaveOpen);
+        public static MemoryMappedFile CreateNew(string mapName, long capacity, MemoryMappedFileAccess access, MemoryMappedFileOptions options, MemoryMappedFileSecurity memoryMappedFileSecurity, HandleInheritability inheritability);
+        public static MemoryMappedFile CreateOrOpen(string mapName, long capacity, MemoryMappedFileAccess access, MemoryMappedFileOptions options, MemoryMappedFileSecurity memoryMappedFileSecurity, HandleInheritability inheritability);
+        public MemoryMappedFileSecurity GetAccessControl();
+        public void SetAccessControl(MemoryMappedFileSecurity memoryMappedFileSecurity);
     }
+    public class MemoryMappedFileSecurity : ObjectSecurity<MemoryMappedFileRights> {
+        public MemoryMappedFileSecurity();
+    }
 }
```

