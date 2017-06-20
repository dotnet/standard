# System.Activities.Presentation.Annotations

``` diff
+namespace System.Activities.Presentation.Annotations {
+    public static class Annotation {
+        public static readonly string AnnotationTextPropertyName;
+        public static readonly AttachableMemberIdentifier AnnotationTextProperty;
+        public static string GetAnnotationText(object instance);
+        public static void SetAnnotationText(object instance, string annotationText);
+    }
+}
```

