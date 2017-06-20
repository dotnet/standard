# System.Web.UI.Adapters

``` diff
+namespace System.Web.UI.Adapters {
+    public abstract class ControlAdapter {
+        protected ControlAdapter();
+        protected HttpBrowserCapabilities Browser { get; }
+        protected Control Control { get; }
+        protected Page Page { get; }
+        protected PageAdapter PageAdapter { get; }
+        protected internal virtual void BeginRender(HtmlTextWriter writer);
+        protected internal virtual void CreateChildControls();
+        protected internal virtual void EndRender(HtmlTextWriter writer);
+        protected internal virtual void LoadAdapterControlState(object state);
+        protected internal virtual void LoadAdapterViewState(object state);
+        protected internal virtual void OnInit(EventArgs e);
+        protected internal virtual void OnLoad(EventArgs e);
+        protected internal virtual void OnPreRender(EventArgs e);
+        protected internal virtual void OnUnload(EventArgs e);
+        protected internal virtual void Render(HtmlTextWriter writer);
+        protected virtual void RenderChildren(HtmlTextWriter writer);
+        protected internal virtual object SaveAdapterControlState();
+        protected internal virtual object SaveAdapterViewState();
+    }
+    public abstract class PageAdapter : ControlAdapter {
+        protected PageAdapter();
+        public virtual StringCollection CacheVaryByHeaders { get; }
+        public virtual StringCollection CacheVaryByParams { get; }
+        protected string ClientState { get; }
+        public virtual NameValueCollection DeterminePostBackMode();
+        public virtual NameValueCollection DeterminePostBackModeUnvalidated();
+        protected internal virtual string GetPostBackFormReference(string formId);
+        public virtual ICollection GetRadioButtonsByGroup(string groupName);
+        public virtual PageStatePersister GetStatePersister();
+        public virtual void RegisterRadioButton(RadioButton radioButton);
+        public virtual void RenderBeginHyperlink(HtmlTextWriter writer, string targetUrl, bool encodeUrl, string softkeyLabel);
+        public virtual void RenderBeginHyperlink(HtmlTextWriter writer, string targetUrl, bool encodeUrl, string softkeyLabel, string accessKey);
+        public virtual void RenderEndHyperlink(HtmlTextWriter writer);
+        public virtual void RenderPostBackEvent(HtmlTextWriter writer, string target, string argument, string softkeyLabel, string text);
+        public virtual void RenderPostBackEvent(HtmlTextWriter writer, string target, string argument, string softkeyLabel, string text, string postUrl, string accessKey);
+        protected void RenderPostBackEvent(HtmlTextWriter writer, string target, string argument, string softkeyLabel, string text, string postUrl, string accessKey, bool encode);
+        public virtual string TransformText(string text);
+    }
+}
```

