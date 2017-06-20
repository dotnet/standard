# System.Text

``` diff
 namespace System.Text {
+    public sealed class CodePagesEncodingProvider {
+        public static EncodingProvider Instance { get; }
+    }
     public abstract class Encoding : ICloneable {
+        public int GetByteCount(string s, int index, int count);
+        public byte[] GetBytes(string s, int index, int count);
     }
     public sealed class StringBuilder : ISerializable {
+        public StringBuilder AppendJoin(char separator, params object[] values);
+        public StringBuilder AppendJoin(char separator, params string[] values);
+        public StringBuilder AppendJoin(string separator, params object[] values);
+        public StringBuilder AppendJoin(string separator, params string[] values);
+        public StringBuilder AppendJoin<T>(char separator, IEnumerable<T> values);
+        public StringBuilder AppendJoin<T>(string separator, IEnumerable<T> values);
     }
 }
```

