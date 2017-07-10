# System.Web.UI.HtmlControls

``` diff
+namespace System.Web.UI.HtmlControls {
+    public class HtmlAnchor : HtmlContainerControl, IPostBackEventHandler {
+        public HtmlAnchor();
+        public virtual bool CausesValidation { get; set; }
+        public string HRef { get; set; }
+        public string Name { get; set; }
+        public string Target { get; set; }
+        public string Title { get; set; }
+        public virtual string ValidationGroup { get; set; }
+        public event EventHandler ServerClick;
+        protected internal override void OnPreRender(EventArgs e);
+        protected virtual void OnServerClick(EventArgs e);
+        protected virtual void RaisePostBackEvent(string eventArgument);
+        protected override void RenderAttributes(HtmlTextWriter writer);
+        void System.Web.UI.IPostBackEventHandler.RaisePostBackEvent(string eventArgument);
+    }
+    public class HtmlArea : HtmlControl {
+        public HtmlArea();
+        public string Href { get; set; }
+        protected override void RenderAttributes(HtmlTextWriter writer);
+    }
+    public class HtmlAudio : HtmlContainerControl {
+        public HtmlAudio();
+        public string Src { get; set; }
+        protected override void RenderAttributes(HtmlTextWriter writer);
+    }
+    public class HtmlButton : HtmlContainerControl, IPostBackEventHandler {
+        public HtmlButton();
+        public virtual bool CausesValidation { get; set; }
+        public virtual string ValidationGroup { get; set; }
+        public event EventHandler ServerClick;
+        protected internal override void OnPreRender(EventArgs e);
+        protected virtual void OnServerClick(EventArgs e);
+        protected virtual void RaisePostBackEvent(string eventArgument);
+        protected override void RenderAttributes(HtmlTextWriter writer);
+        void System.Web.UI.IPostBackEventHandler.RaisePostBackEvent(string eventArgument);
+    }
+    public abstract class HtmlContainerControl : HtmlControl {
+        protected HtmlContainerControl();
+        public HtmlContainerControl(string tag);
+        public virtual string InnerHtml { get; set; }
+        public virtual string InnerText { get; set; }
+        protected override ControlCollection CreateControlCollection();
+        protected override void LoadViewState(object savedState);
+        protected internal override void Render(HtmlTextWriter writer);
+        protected override void RenderAttributes(HtmlTextWriter writer);
+        protected virtual void RenderEndTag(HtmlTextWriter writer);
+    }
+    public abstract class HtmlControl : Control, IAttributeAccessor {
+        protected HtmlControl();
+        protected HtmlControl(string tag);
+        public AttributeCollection Attributes { get; }
+        public bool Disabled { get; set; }
+        public CssStyleCollection Style { get; }
+        public virtual string TagName { get; }
+        protected override bool ViewStateIgnoresCase { get; }
+        protected override ControlCollection CreateControlCollection();
+        protected virtual string GetAttribute(string name);
+        protected internal override void Render(HtmlTextWriter writer);
+        protected virtual void RenderAttributes(HtmlTextWriter writer);
+        protected virtual void RenderBeginTag(HtmlTextWriter writer);
+        protected virtual void SetAttribute(string name, string value);
+        string System.Web.UI.IAttributeAccessor.GetAttribute(string name);
+        void System.Web.UI.IAttributeAccessor.SetAttribute(string name, string value);
+    }
+    public class HtmlElement : HtmlContainerControl {
+        public HtmlElement();
+        public string Manifest { get; set; }
+        protected override void RenderAttributes(HtmlTextWriter writer);
+    }
+    public class HtmlEmbed : HtmlContainerControl {
+        public HtmlEmbed();
+        public string Src { get; set; }
+        protected override void RenderAttributes(HtmlTextWriter writer);
+    }
+    public sealed class HtmlEmptyTagControlBuilder : ControlBuilder {
+        public HtmlEmptyTagControlBuilder();
+        public override bool HasBody();
+    }
+    public class HtmlForm : HtmlContainerControl {
+        public HtmlForm();
+        public string Action { get; set; }
+        public override string ClientID { get; }
+        public string DefaultButton { get; set; }
+        public string DefaultFocus { get; set; }
+        public string Enctype { get; set; }
+        public string Method { get; set; }
+        public virtual string Name { get; set; }
+        public virtual bool SubmitDisabledControls { get; set; }
+        public string Target { get; set; }
+        public override string UniqueID { get; }
+        protected override ControlCollection CreateControlCollection();
+        protected internal override void OnInit(EventArgs e);
+        protected internal override void OnPreRender(EventArgs e);
+        protected internal override void Render(HtmlTextWriter output);
+        protected override void RenderAttributes(HtmlTextWriter writer);
+        protected internal override void RenderChildren(HtmlTextWriter writer);
+        public override void RenderControl(HtmlTextWriter writer);
+    }
+    public class HtmlGenericControl : HtmlContainerControl {
+        public HtmlGenericControl();
+        public HtmlGenericControl(string tag);
+        public new string TagName { get; set; }
+    }
+    public sealed class HtmlHead : HtmlGenericControl {
+        public HtmlHead();
+        public HtmlHead(string tag);
+        public string Description { get; set; }
+        public string Keywords { get; set; }
+        public IStyleSheet StyleSheet { get; }
+        public string Title { get; set; }
+        protected internal override void AddedControl(Control control, int index);
+        protected internal override void OnInit(EventArgs e);
+        protected internal override void RemovedControl(Control control);
+        protected internal override void RenderChildren(HtmlTextWriter writer);
+    }
+    public class HtmlHeadBuilder : ControlBuilder {
+        public HtmlHeadBuilder();
+        public override bool AllowWhitespaceLiterals();
+        public override Type GetChildControlType(string tagName, IDictionary attribs);
+    }
+    public class HtmlIframe : HtmlContainerControl {
+        public HtmlIframe();
+        public string Src { get; set; }
+        protected override void RenderAttributes(HtmlTextWriter writer);
+    }
+    public class HtmlImage : HtmlControl {
+        public HtmlImage();
+        public string Align { get; set; }
+        public string Alt { get; set; }
+        public int Border { get; set; }
+        public int Height { get; set; }
+        public string Src { get; set; }
+        public int Width { get; set; }
+        protected override void RenderAttributes(HtmlTextWriter writer);
+    }
+    public class HtmlInputButton : HtmlInputControl, IPostBackEventHandler {
+        public HtmlInputButton();
+        public HtmlInputButton(string type);
+        public virtual bool CausesValidation { get; set; }
+        public virtual string ValidationGroup { get; set; }
+        public event EventHandler ServerClick;
+        protected internal override void OnPreRender(EventArgs e);
+        protected virtual void OnServerClick(EventArgs e);
+        protected virtual void RaisePostBackEvent(string eventArgument);
+        protected override void RenderAttributes(HtmlTextWriter writer);
+        void System.Web.UI.IPostBackEventHandler.RaisePostBackEvent(string eventArgument);
+    }
+    public class HtmlInputCheckBox : HtmlInputControl, IPostBackDataHandler {
+        public HtmlInputCheckBox();
+        public bool Checked { get; set; }
+        public event EventHandler ServerChange;
+        protected virtual bool LoadPostData(string postDataKey, NameValueCollection postCollection);
+        protected internal override void OnPreRender(EventArgs e);
+        protected virtual void OnServerChange(EventArgs e);
+        protected virtual void RaisePostDataChangedEvent();
+        protected override void RenderAttributes(HtmlTextWriter writer);
+        bool System.Web.UI.IPostBackDataHandler.LoadPostData(string postDataKey, NameValueCollection postCollection);
+        void System.Web.UI.IPostBackDataHandler.RaisePostDataChangedEvent();
+    }
+    public abstract class HtmlInputControl : HtmlControl {
+        protected HtmlInputControl(string type);
+        public virtual string Name { get; set; }
+        public string Type { get; }
+        public virtual string Value { get; set; }
+        protected override void RenderAttributes(HtmlTextWriter writer);
+    }
+    public class HtmlInputFile : HtmlInputControl, IPostBackDataHandler {
+        public HtmlInputFile();
+        public string Accept { get; set; }
+        public int MaxLength { get; set; }
+        public HttpPostedFile PostedFile { get; }
+        public int Size { get; set; }
+        public override string Value { get; set; }
+        protected virtual bool LoadPostData(string postDataKey, NameValueCollection postCollection);
+        protected internal override void OnPreRender(EventArgs e);
+        protected virtual void RaisePostDataChangedEvent();
+        bool System.Web.UI.IPostBackDataHandler.LoadPostData(string postDataKey, NameValueCollection postCollection);
+        void System.Web.UI.IPostBackDataHandler.RaisePostDataChangedEvent();
+    }
+    public class HtmlInputGenericControl : HtmlInputControl, IPostBackDataHandler {
+        public HtmlInputGenericControl();
+        public HtmlInputGenericControl(string type);
+        public event EventHandler ServerChange;
+        protected virtual bool LoadPostData(string postDataKey, NameValueCollection postCollection);
+        protected internal override void OnPreRender(EventArgs e);
+        protected virtual void OnServerChange(EventArgs e);
+        protected virtual void RaisePostDataChangedEvent();
+        bool System.Web.UI.IPostBackDataHandler.LoadPostData(string postDataKey, NameValueCollection postCollection);
+        void System.Web.UI.IPostBackDataHandler.RaisePostDataChangedEvent();
+    }
+    public class HtmlInputHidden : HtmlInputControl, IPostBackDataHandler {
+        public HtmlInputHidden();
+        public event EventHandler ServerChange;
+        protected virtual bool LoadPostData(string postDataKey, NameValueCollection postCollection);
+        protected internal override void OnPreRender(EventArgs e);
+        protected virtual void OnServerChange(EventArgs e);
+        protected virtual void RaisePostDataChangedEvent();
+        protected override void RenderAttributes(HtmlTextWriter writer);
+        bool System.Web.UI.IPostBackDataHandler.LoadPostData(string postDataKey, NameValueCollection postCollection);
+        void System.Web.UI.IPostBackDataHandler.RaisePostDataChangedEvent();
+    }
+    public class HtmlInputImage : HtmlInputControl, IPostBackDataHandler, IPostBackEventHandler {
+        public HtmlInputImage();
+        public string Align { get; set; }
+        public string Alt { get; set; }
+        public int Border { get; set; }
+        public virtual bool CausesValidation { get; set; }
+        public string Src { get; set; }
+        public virtual string ValidationGroup { get; set; }
+        public event ImageClickEventHandler ServerClick;
+        protected virtual bool LoadPostData(string postDataKey, NameValueCollection postCollection);
+        protected internal override void OnPreRender(EventArgs e);
+        protected virtual void OnServerClick(ImageClickEventArgs e);
+        protected virtual void RaisePostBackEvent(string eventArgument);
+        protected virtual void RaisePostDataChangedEvent();
+        protected override void RenderAttributes(HtmlTextWriter writer);
+        bool System.Web.UI.IPostBackDataHandler.LoadPostData(string postDataKey, NameValueCollection postCollection);
+        void System.Web.UI.IPostBackDataHandler.RaisePostDataChangedEvent();
+        void System.Web.UI.IPostBackEventHandler.RaisePostBackEvent(string eventArgument);
+    }
+    public class HtmlInputPassword : HtmlInputText, IPostBackDataHandler {
+        public HtmlInputPassword();
+        protected override void RenderAttributes(HtmlTextWriter writer);
+    }
+    public class HtmlInputRadioButton : HtmlInputControl, IPostBackDataHandler {
+        public HtmlInputRadioButton();
+        public bool Checked { get; set; }
+        public override string Name { get; set; }
+        public override string Value { get; set; }
+        public event EventHandler ServerChange;
+        protected virtual bool LoadPostData(string postDataKey, NameValueCollection postCollection);
+        protected internal override void OnPreRender(EventArgs e);
+        protected virtual void OnServerChange(EventArgs e);
+        protected virtual void RaisePostDataChangedEvent();
+        protected override void RenderAttributes(HtmlTextWriter writer);
+        bool System.Web.UI.IPostBackDataHandler.LoadPostData(string postDataKey, NameValueCollection postCollection);
+        void System.Web.UI.IPostBackDataHandler.RaisePostDataChangedEvent();
+    }
+    public class HtmlInputReset : HtmlInputButton {
+        public HtmlInputReset();
+        public HtmlInputReset(string type);
+        public override bool CausesValidation { get; set; }
+        public override string ValidationGroup { get; set; }
+        public new event EventHandler ServerClick;
+    }
+    public class HtmlInputSubmit : HtmlInputButton, IPostBackEventHandler {
+        public HtmlInputSubmit();
+        public HtmlInputSubmit(string type);
+    }
+    public class HtmlInputText : HtmlInputControl, IPostBackDataHandler {
+        public HtmlInputText();
+        public HtmlInputText(string type);
+        public int MaxLength { get; set; }
+        public int Size { get; set; }
+        public override string Value { get; set; }
+        public event EventHandler ServerChange;
+        protected virtual bool LoadPostData(string postDataKey, NameValueCollection postCollection);
+        protected internal override void OnPreRender(EventArgs e);
+        protected virtual void OnServerChange(EventArgs e);
+        protected virtual void RaisePostDataChangedEvent();
+        protected override void RenderAttributes(HtmlTextWriter writer);
+        bool System.Web.UI.IPostBackDataHandler.LoadPostData(string postDataKey, NameValueCollection postCollection);
+        void System.Web.UI.IPostBackDataHandler.RaisePostDataChangedEvent();
+    }
+    public class HtmlLink : HtmlControl {
+        public HtmlLink();
+        public virtual string Href { get; set; }
+        protected internal override void Render(HtmlTextWriter writer);
+        protected override void RenderAttributes(HtmlTextWriter writer);
+    }
+    public class HtmlMeta : HtmlControl {
+        public HtmlMeta();
+        public virtual string Content { get; set; }
+        public virtual string HttpEquiv { get; set; }
+        public virtual string Name { get; set; }
+        public virtual string Scheme { get; set; }
+        protected internal override void Render(HtmlTextWriter writer);
+    }
+    public class HtmlSelect : HtmlContainerControl, IParserAccessor, IPostBackDataHandler {
+        public HtmlSelect();
+        public virtual string DataMember { get; set; }
+        public virtual object DataSource { get; set; }
+        public virtual string DataSourceID { get; set; }
+        public virtual string DataTextField { get; set; }
+        public virtual string DataValueField { get; set; }
+        public override string InnerHtml { get; set; }
+        public override string InnerText { get; set; }
+        protected bool IsBoundUsingDataSourceID { get; }
+        public ListItemCollection Items { get; }
+        public bool Multiple { get; set; }
+        public string Name { get; set; }
+        protected bool RequiresDataBinding { get; set; }
+        public virtual int SelectedIndex { get; set; }
+        protected virtual int[] SelectedIndices { get; }
+        public int Size { get; set; }
+        public string Value { get; set; }
+        public event EventHandler ServerChange;
+        protected override void AddParsedSubObject(object obj);
+        protected virtual void ClearSelection();
+        protected override ControlCollection CreateControlCollection();
+        protected void EnsureDataBound();
+        protected virtual IEnumerable GetData();
+        protected virtual bool LoadPostData(string postDataKey, NameValueCollection postCollection);
+        protected override void LoadViewState(object savedState);
+        protected override void OnDataBinding(EventArgs e);
+        protected virtual void OnDataPropertyChanged();
+        protected virtual void OnDataSourceViewChanged(object sender, EventArgs e);
+        protected internal override void OnInit(EventArgs e);
+        protected internal override void OnLoad(EventArgs e);
+        protected internal override void OnPreRender(EventArgs e);
+        protected virtual void OnServerChange(EventArgs e);
+        protected virtual void RaisePostDataChangedEvent();
+        protected override void RenderAttributes(HtmlTextWriter writer);
+        protected internal override void RenderChildren(HtmlTextWriter writer);
+        protected override object SaveViewState();
+        protected virtual void Select(int[] selectedIndices);
+        bool System.Web.UI.IPostBackDataHandler.LoadPostData(string postDataKey, NameValueCollection postCollection);
+        void System.Web.UI.IPostBackDataHandler.RaisePostDataChangedEvent();
+        protected override void TrackViewState();
+    }
+    public class HtmlSelectBuilder : ControlBuilder {
+        public HtmlSelectBuilder();
+        public override bool AllowWhitespaceLiterals();
+        public override Type GetChildControlType(string tagName, IDictionary attribs);
+    }
+    public class HtmlSource : HtmlControl {
+        public HtmlSource();
+        public string Src { get; set; }
+        protected override void RenderAttributes(HtmlTextWriter writer);
+    }
+    public class HtmlTable : HtmlContainerControl {
+        public HtmlTable();
+        public string Align { get; set; }
+        public string BgColor { get; set; }
+        public int Border { get; set; }
+        public string BorderColor { get; set; }
+        public int CellPadding { get; set; }
+        public int CellSpacing { get; set; }
+        public string Height { get; set; }
+        public override string InnerHtml { get; set; }
+        public override string InnerText { get; set; }
+        public virtual HtmlTableRowCollection Rows { get; }
+        public string Width { get; set; }
+        protected override ControlCollection CreateControlCollection();
+        protected internal override void RenderChildren(HtmlTextWriter writer);
+        protected override void RenderEndTag(HtmlTextWriter writer);
+        protected class HtmlTableRowControlCollection : ControlCollection {
+            public override void Add(Control child);
+            public override void AddAt(int index, Control child);
+        }
+    }
+    public class HtmlTableCell : HtmlContainerControl {
+        public HtmlTableCell();
+        public HtmlTableCell(string tagName);
+        public string Align { get; set; }
+        public string BgColor { get; set; }
+        public string BorderColor { get; set; }
+        public int ColSpan { get; set; }
+        public string Height { get; set; }
+        public bool NoWrap { get; set; }
+        public int RowSpan { get; set; }
+        public string VAlign { get; set; }
+        public string Width { get; set; }
+        protected override void RenderEndTag(HtmlTextWriter writer);
+    }
+    public sealed class HtmlTableCellCollection : ICollection, IEnumerable {
+        public int Count { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        public HtmlTableCell this[int index] { get; }
+        public void Add(HtmlTableCell cell);
+        public void Clear();
+        public void CopyTo(Array array, int index);
+        public IEnumerator GetEnumerator();
+        public void Insert(int index, HtmlTableCell cell);
+        public void Remove(HtmlTableCell cell);
+        public void RemoveAt(int index);
+    }
+    public class HtmlTableRow : HtmlContainerControl {
+        public HtmlTableRow();
+        public string Align { get; set; }
+        public string BgColor { get; set; }
+        public string BorderColor { get; set; }
+        public virtual HtmlTableCellCollection Cells { get; }
+        public string Height { get; set; }
+        public override string InnerHtml { get; set; }
+        public override string InnerText { get; set; }
+        public string VAlign { get; set; }
+        protected override ControlCollection CreateControlCollection();
+        protected internal override void RenderChildren(HtmlTextWriter writer);
+        protected override void RenderEndTag(HtmlTextWriter writer);
+        protected class HtmlTableCellControlCollection : ControlCollection {
+            public override void Add(Control child);
+            public override void AddAt(int index, Control child);
+        }
+    }
+    public sealed class HtmlTableRowCollection : ICollection, IEnumerable {
+        public int Count { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        public HtmlTableRow this[int index] { get; }
+        public void Add(HtmlTableRow row);
+        public void Clear();
+        public void CopyTo(Array array, int index);
+        public IEnumerator GetEnumerator();
+        public void Insert(int index, HtmlTableRow row);
+        public void Remove(HtmlTableRow row);
+        public void RemoveAt(int index);
+    }
+    public class HtmlTextArea : HtmlContainerControl, IPostBackDataHandler {
+        public HtmlTextArea();
+        public int Cols { get; set; }
+        public virtual string Name { get; set; }
+        public int Rows { get; set; }
+        public string Value { get; set; }
+        public event EventHandler ServerChange;
+        protected override void AddParsedSubObject(object obj);
+        protected virtual bool LoadPostData(string postDataKey, NameValueCollection postCollection);
+        protected internal override void OnPreRender(EventArgs e);
+        protected virtual void OnServerChange(EventArgs e);
+        protected virtual void RaisePostDataChangedEvent();
+        protected override void RenderAttributes(HtmlTextWriter writer);
+        bool System.Web.UI.IPostBackDataHandler.LoadPostData(string postDataKey, NameValueCollection postCollection);
+        void System.Web.UI.IPostBackDataHandler.RaisePostDataChangedEvent();
+    }
+    public class HtmlTitle : HtmlControl {
+        public HtmlTitle();
+        public virtual string Text { get; set; }
+        protected override void AddParsedSubObject(object obj);
+        protected override ControlCollection CreateControlCollection();
+        protected internal override void Render(HtmlTextWriter writer);
+    }
+    public class HtmlTrack : HtmlControl {
+        public HtmlTrack();
+        public string Src { get; set; }
+        protected override void RenderAttributes(HtmlTextWriter writer);
+    }
+    public class HtmlVideo : HtmlContainerControl {
+        public HtmlVideo();
+        public string Poster { get; set; }
+        public string Src { get; set; }
+        protected override void RenderAttributes(HtmlTextWriter writer);
+    }
+}
```

