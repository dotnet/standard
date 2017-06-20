# Microsoft.VisualC

``` diff
+namespace Microsoft.VisualC {
+    public sealed class DebugInfoInPDBAttribute : Attribute {
+        public DebugInfoInPDBAttribute();
+    }
+    public sealed class DecoratedNameAttribute : Attribute {
+        public DecoratedNameAttribute();
+        public DecoratedNameAttribute(string decoratedName);
+    }
+    public sealed class IsConstModifier {
+        public IsConstModifier();
+    }
+    public sealed class IsCXXReferenceModifier {
+        public IsCXXReferenceModifier();
+    }
+    public sealed class IsLongModifier {
+        public IsLongModifier();
+    }
+    public sealed class IsSignedModifier {
+        public IsSignedModifier();
+    }
+    public sealed class IsVolatileModifier {
+        public IsVolatileModifier();
+    }
+    public sealed class MiscellaneousBitsAttribute : Attribute {
+        public int m_dwAttrs;
+        public MiscellaneousBitsAttribute(int miscellaneousBits);
+    }
+    public sealed class NeedsCopyConstructorModifier {
+        public NeedsCopyConstructorModifier();
+    }
+    public sealed class NoSignSpecifiedModifier {
+        public NoSignSpecifiedModifier();
+    }
+}
```

