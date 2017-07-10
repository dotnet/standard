# System.Collections

``` diff
 namespace System.Collections {
     public sealed class BitArray : ICloneable, ICollection, IEnumerable {
+        public BitArray LeftShift(int count);
+        public BitArray RightShift(int count);
     }
     [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
     public struct DictionaryEntry {
+        public void Deconstruct(out object key, out object value);
     }
 }
```

