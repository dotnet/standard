# System.Windows.Forms.PropertyGridInternal

``` diff
+namespace System.Windows.Forms.PropertyGridInternal {
+    public interface IRootGridEntry {
+        AttributeCollection BrowsableAttributes { get; set; }
+        void ResetBrowsableAttributes();
+        void ShowCategories(bool showCategories);
+    }
+    public class PropertiesTab : PropertyTab {
+        public PropertiesTab();
+        public override string HelpKeyword { get; }
+        public override string TabName { get; }
+        public override PropertyDescriptor GetDefaultProperty(object obj);
+        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object component, Attribute[] attributes);
+        public override PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes);
+    }
+    public class PropertyGridCommands {
+        public static readonly CommandID Commands;
+        public static readonly CommandID Description;
+        public static readonly CommandID Hide;
+        public static readonly CommandID Reset;
+        protected static readonly Guid wfcMenuCommand;
+        protected static readonly Guid wfcMenuGroup;
+        public PropertyGridCommands();
+    }
+}
```

