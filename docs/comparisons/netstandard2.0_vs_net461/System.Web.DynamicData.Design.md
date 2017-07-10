# System.Web.DynamicData.Design

``` diff
+namespace System.Web.DynamicData.Design {
+    public class DataControlReferenceCollectionEditor : CollectionEditor {
+        public DataControlReferenceCollectionEditor(Type type);
+        protected override Type CreateCollectionItemType();
+    }
+    public class DataControlReferenceIDConverter : StringConverter {
+        public DataControlReferenceIDConverter();
+        public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context);
+        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context);
+        public override bool GetStandardValuesSupported(ITypeDescriptorContext context);
+    }
+    public class DynamicDataManagerDesigner : ControlDesigner {
+        public DynamicDataManagerDesigner();
+        public override DesignerActionListCollection ActionLists { get; }
+        public override string GetDesignTimeHtml();
+    }
+    public class DynamicFieldDesigner : DataControlFieldDesigner {
+        public DynamicFieldDesigner();
+        public override string DefaultNodeText { get; }
+        public override bool UsesSchema { get; }
+        public override DataControlField CreateField();
+        public override DataControlField CreateField(IDataSourceFieldSchema fieldSchema);
+        public override TemplateField CreateTemplateField(DataControlField dataControlField, DataBoundControl dataBoundControl);
+        public override string GetNodeText(DataControlField dataControlField);
+        public string GetTemplateContent(DataControlField dataControlField, DataBoundControlMode mode);
+        public override bool IsEnabled(DataBoundControl parent);
+    }
+}
```

