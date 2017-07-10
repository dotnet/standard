# System.Configuration.Assemblies

``` diff
 namespace System.Configuration.Assemblies {
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct AssemblyHash : ICloneable {
+        public static readonly AssemblyHash Empty;
+        public AssemblyHash(byte[] value);
+        public AssemblyHash(AssemblyHashAlgorithm algorithm, byte[] value);
+        public AssemblyHashAlgorithm Algorithm { get; set; }
+        public object Clone();
+        public byte[] GetValue();
+        public void SetValue(byte[] value);
+    }
 }
```

