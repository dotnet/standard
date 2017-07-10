# System.Web.UI.Design.WebControls.WebParts

``` diff
+namespace System.Web.UI.Design.WebControls.WebParts {
+    public class CatalogPartDesigner : PartDesigner {
+        public CatalogPartDesigner();
+        protected override Control CreateViewControl();
+        public override string GetDesignTimeHtml();
+        public override void Initialize(IComponent component);
+    }
+    public class CatalogZoneDesigner : ToolZoneDesigner {
+        public CatalogZoneDesigner();
+        public override DesignerAutoFormatCollection AutoFormats { get; }
+        public override TemplateGroupCollection TemplateGroups { get; }
+        public override string GetDesignTimeHtml();
+        public override string GetDesignTimeHtml(DesignerRegionCollection regions);
+        public override string GetEditableDesignerRegionContent(EditableDesignerRegion region);
+        protected override string GetEmptyDesignTimeHtml();
+        public override void Initialize(IComponent component);
+        public override void SetEditableDesignerRegionContent(EditableDesignerRegion region, string content);
+    }
+    public class ConnectionsZoneDesigner : ToolZoneDesigner {
+        public ConnectionsZoneDesigner();
+        public override DesignerAutoFormatCollection AutoFormats { get; }
+        public override string GetDesignTimeHtml();
+        public override void Initialize(IComponent component);
+        protected override void PreFilterProperties(IDictionary properties);
+    }
+    public class DeclarativeCatalogPartDesigner : CatalogPartDesigner {
+        public DeclarativeCatalogPartDesigner();
+        public override TemplateGroupCollection TemplateGroups { get; }
+        public override string GetDesignTimeHtml();
+        protected override string GetEmptyDesignTimeHtml();
+        public override void Initialize(IComponent component);
+    }
+    public class EditorPartDesigner : PartDesigner {
+        public EditorPartDesigner();
+        protected override Control CreateViewControl();
+        public override string GetDesignTimeHtml();
+        public override void Initialize(IComponent component);
+    }
+    public class EditorZoneDesigner : ToolZoneDesigner {
+        public EditorZoneDesigner();
+        public override DesignerAutoFormatCollection AutoFormats { get; }
+        public override TemplateGroupCollection TemplateGroups { get; }
+        public override string GetDesignTimeHtml();
+        public override string GetDesignTimeHtml(DesignerRegionCollection regions);
+        public override string GetEditableDesignerRegionContent(EditableDesignerRegion region);
+        protected override string GetEmptyDesignTimeHtml();
+        public override void Initialize(IComponent component);
+        public override void SetEditableDesignerRegionContent(EditableDesignerRegion region, string content);
+    }
+    public class PageCatalogPartDesigner : CatalogPartDesigner {
+        public PageCatalogPartDesigner();
+        public override string GetDesignTimeHtml();
+        public override void Initialize(IComponent component);
+    }
+    public abstract class PartDesigner : CompositeControlDesigner {
+        protected override bool UsePreviewControl { get; }
+        public override void Initialize(IComponent component);
+    }
+    public class ProxyWebPartManagerDesigner : ControlDesigner {
+        public ProxyWebPartManagerDesigner();
+        protected override bool UsePreviewControl { get; }
+        public override string GetDesignTimeHtml();
+        public override void Initialize(IComponent component);
+    }
+    public class ToolZoneDesigner : WebZoneDesigner {
+        public ToolZoneDesigner();
+        public override DesignerActionListCollection ActionLists { get; }
+        protected bool ViewInBrowseMode { get; private set; }
+        public override void Initialize(IComponent component);
+    }
+    public class WebPartDesigner : PartDesigner {
+        public WebPartDesigner();
+        public override void Initialize(IComponent component);
+    }
+    public class WebPartManagerDesigner : ControlDesigner {
+        public WebPartManagerDesigner();
+        protected override bool UsePreviewControl { get; }
+        public override string GetDesignTimeHtml();
+        public override void Initialize(IComponent component);
+    }
+    public class WebPartZoneBaseDesigner : WebZoneDesigner {
+        public WebPartZoneBaseDesigner();
+        public override void Initialize(IComponent component);
+        protected override void PreFilterProperties(IDictionary properties);
+    }
+    public class WebPartZoneDesigner : WebPartZoneBaseDesigner {
+        public WebPartZoneDesigner();
+        public override DesignerAutoFormatCollection AutoFormats { get; }
+        public override TemplateGroupCollection TemplateGroups { get; }
+        public override string GetDesignTimeHtml();
+        public override string GetDesignTimeHtml(DesignerRegionCollection regions);
+        public override string GetEditableDesignerRegionContent(EditableDesignerRegion region);
+        protected override string GetEmptyDesignTimeHtml();
+        public override void Initialize(IComponent component);
+        public override void SetEditableDesignerRegionContent(EditableDesignerRegion region, string content);
+    }
+    public abstract class WebZoneDesigner : ControlDesigner {
+        protected override bool UsePreviewControl { get; }
+        public override void Initialize(IComponent component);
+    }
+}
```

