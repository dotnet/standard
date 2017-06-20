# System.Drawing.Text

``` diff
+namespace System.Drawing.Text {
+    public abstract class FontCollection : IDisposable {
+        public FontFamily[] Families { get; }
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        ~FontCollection();
+    }
+    public enum GenericFontFamilies {
+        Monospace = 2,
+        SansSerif = 1,
+        Serif = 0,
+    }
+    public enum HotkeyPrefix {
+        Hide = 2,
+        None = 0,
+        Show = 1,
+    }
+    public sealed class InstalledFontCollection : FontCollection {
+        public InstalledFontCollection();
+    }
+    public sealed class PrivateFontCollection : FontCollection {
+        public PrivateFontCollection();
+        public void AddFontFile(string filename);
+        public void AddMemoryFont(IntPtr memory, int length);
+        protected override void Dispose(bool disposing);
+    }
+    public enum TextRenderingHint {
+        AntiAlias = 4,
+        AntiAliasGridFit = 3,
+        ClearTypeGridFit = 5,
+        SingleBitPerPixel = 2,
+        SingleBitPerPixelGridFit = 1,
+        SystemDefault = 0,
+    }
+}
```

