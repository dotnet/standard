# System.Globalization

``` diff
 namespace System.Globalization {
+    public static class GlobalizationExtensions {
+        public static StringComparer GetStringComparer(this CompareInfo compareInfo, CompareOptions options);
+    }
+    public sealed class IdnMapping {
+        public IdnMapping();
+        public bool AllowUnassigned { get; set; }
+        public bool UseStd3AsciiRules { get; set; }
+        public override bool Equals(object obj);
+        public string GetAscii(string unicode);
+        public string GetAscii(string unicode, int index);
+        public string GetAscii(string unicode, int index, int count);
+        public override int GetHashCode();
+        public string GetUnicode(string ascii);
+        public string GetUnicode(string ascii, int index);
+        public string GetUnicode(string ascii, int index, int count);
+    }
 }
```

