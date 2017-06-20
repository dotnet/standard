# System.Web.UI.WebControls.Adapters

``` diff
+namespace System.Web.UI.WebControls.Adapters {
+    public class DataBoundControlAdapter : WebControlAdapter {
+        public DataBoundControlAdapter();
+        protected new DataBoundControl Control { get; }
+        protected internal virtual void PerformDataBinding(IEnumerable data);
+    }
+    public class HideDisabledControlAdapter : WebControlAdapter {
+        public HideDisabledControlAdapter();
+        protected internal override void Render(HtmlTextWriter writer);
+    }
+    public class HierarchicalDataBoundControlAdapter : WebControlAdapter {
+        public HierarchicalDataBoundControlAdapter();
+        protected new HierarchicalDataBoundControl Control { get; }
+        protected internal virtual void PerformDataBinding();
+    }
+    public class MenuAdapter : WebControlAdapter, IPostBackEventHandler {
+        public MenuAdapter();
+        protected new Menu Control { get; }
+        protected internal override void LoadAdapterControlState(object state);
+        protected internal override void OnInit(EventArgs e);
+        protected internal override void OnPreRender(EventArgs e);
+        protected virtual void RaisePostBackEvent(string eventArgument);
+        protected override void RenderBeginTag(HtmlTextWriter writer);
+        protected override void RenderContents(HtmlTextWriter writer);
+        protected override void RenderEndTag(HtmlTextWriter writer);
+        protected internal virtual void RenderItem(HtmlTextWriter writer, MenuItem item, int position);
+        protected internal override object SaveAdapterControlState();
+        void System.Web.UI.IPostBackEventHandler.RaisePostBackEvent(string eventArgument);
+    }
+    public class WebControlAdapter : ControlAdapter {
+        public WebControlAdapter();
+        protected new WebControl Control { get; }
+        protected bool IsEnabled { get; }
+        protected internal override void Render(HtmlTextWriter writer);
+        protected virtual void RenderBeginTag(HtmlTextWriter writer);
+        protected virtual void RenderContents(HtmlTextWriter writer);
+        protected virtual void RenderEndTag(HtmlTextWriter writer);
+    }
+}
```

