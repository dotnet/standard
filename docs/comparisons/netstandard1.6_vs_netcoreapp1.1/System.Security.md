# System.Security

``` diff
 namespace System.Security {
+    public sealed class SecureString : IDisposable {
+        public SecureString();
+        public unsafe SecureString(char* value, int length);
+        public int Length { get; }
+        public void AppendChar(char c);
+        public void Clear();
+        public SecureString Copy();
+        public void Dispose();
+        public void InsertAt(int index, char c);
+        public bool IsReadOnly();
+        public void MakeReadOnly();
+        public void RemoveAt(int index);
+        public void SetAt(int index, char c);
+    }
+    public static class SecureStringMarshal {
+        public static IntPtr SecureStringToCoTaskMemAnsi(SecureString s);
+        public static IntPtr SecureStringToCoTaskMemUnicode(SecureString s);
+        public static IntPtr SecureStringToGlobalAllocAnsi(SecureString s);
+        public static IntPtr SecureStringToGlobalAllocUnicode(SecureString s);
+    }
 }
```

