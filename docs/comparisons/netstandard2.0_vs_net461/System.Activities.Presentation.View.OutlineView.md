# System.Activities.Presentation.View.OutlineView

``` diff
+namespace System.Activities.Presentation.View.OutlineView {
+    public sealed class HidePropertyInOutlineViewAttribute : Attribute {
+        public HidePropertyInOutlineViewAttribute();
+    }
+    public sealed class ShowInOutlineViewAttribute : Attribute {
+        public ShowInOutlineViewAttribute();
+        public string PromotedProperty { get; set; }
+    }
+    public sealed class ShowPropertyInOutlineViewAsSiblingAttribute : Attribute {
+        public ShowPropertyInOutlineViewAsSiblingAttribute();
+    }
+    public sealed class ShowPropertyInOutlineViewAttribute : Attribute {
+        public ShowPropertyInOutlineViewAttribute();
+        public string ChildNodePrefix { get; set; }
+        public bool CurrentPropertyVisible { get; set; }
+        public bool DuplicatedChildNodesVisible { get; set; }
+    }
+}
```

