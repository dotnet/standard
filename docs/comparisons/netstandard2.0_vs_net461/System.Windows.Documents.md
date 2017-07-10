# System.Windows.Documents

``` diff
+namespace System.Windows.Documents {
+    public abstract class Adorner : FrameworkElement {
+        protected Adorner(UIElement adornedElement);
+        public UIElement AdornedElement { get; }
+        public bool IsClipEnabled { get; set; }
+        public virtual GeneralTransform GetDesiredTransform(GeneralTransform transform);
+        protected override Geometry GetLayoutClip(Size layoutSlotSize);
+        protected override Size MeasureOverride(Size constraint);
+    }
+    public class AdornerDecorator : Decorator {
+        public AdornerDecorator();
+        public AdornerLayer AdornerLayer { get; }
+        public override UIElement Child { get; set; }
+        protected override int VisualChildrenCount { get; }
+        protected override Size ArrangeOverride(Size finalSize);
+        protected override Visual GetVisualChild(int index);
+        protected override Size MeasureOverride(Size constraint);
+    }
+    public class AdornerLayer : FrameworkElement {
+        protected internal override IEnumerator LogicalChildren { get; }
+        protected override int VisualChildrenCount { get; }
+        public void Add(Adorner adorner);
+        public AdornerHitTestResult AdornerHitTest(Point point);
+        protected override Size ArrangeOverride(Size finalSize);
+        public static AdornerLayer GetAdornerLayer(Visual visual);
+        public Adorner[] GetAdorners(UIElement element);
+        protected override Visual GetVisualChild(int index);
+        protected override Size MeasureOverride(Size constraint);
+        public void Remove(Adorner adorner);
+        public void Update();
+        public void Update(UIElement element);
+    }
+    public abstract class AnchoredBlock : Inline {
+        public static readonly DependencyProperty BorderBrushProperty;
+        public static readonly DependencyProperty BorderThicknessProperty;
+        public static readonly DependencyProperty LineHeightProperty;
+        public static readonly DependencyProperty LineStackingStrategyProperty;
+        public static readonly DependencyProperty MarginProperty;
+        public static readonly DependencyProperty PaddingProperty;
+        public static readonly DependencyProperty TextAlignmentProperty;
+        protected AnchoredBlock(Block block, TextPointer insertionPosition);
+        public BlockCollection Blocks { get; }
+        public Brush BorderBrush { get; set; }
+        public Thickness BorderThickness { get; set; }
+        public double LineHeight { get; set; }
+        public LineStackingStrategy LineStackingStrategy { get; set; }
+        public Thickness Margin { get; set; }
+        public Thickness Padding { get; set; }
+        public TextAlignment TextAlignment { get; set; }
+        public bool ShouldSerializeBlocks(XamlDesignerSerializationManager manager);
+    }
+    public abstract class Block : TextElement {
+        public static readonly DependencyProperty BorderBrushProperty;
+        public static readonly DependencyProperty BorderThicknessProperty;
+        public static readonly DependencyProperty BreakColumnBeforeProperty;
+        public static readonly DependencyProperty BreakPageBeforeProperty;
+        public static readonly DependencyProperty ClearFloatersProperty;
+        public static readonly DependencyProperty FlowDirectionProperty;
+        public static readonly DependencyProperty IsHyphenationEnabledProperty;
+        public static readonly DependencyProperty LineHeightProperty;
+        public static readonly DependencyProperty LineStackingStrategyProperty;
+        public static readonly DependencyProperty MarginProperty;
+        public static readonly DependencyProperty PaddingProperty;
+        public static readonly DependencyProperty TextAlignmentProperty;
+        protected Block();
+        public Brush BorderBrush { get; set; }
+        public Thickness BorderThickness { get; set; }
+        public bool BreakColumnBefore { get; set; }
+        public bool BreakPageBefore { get; set; }
+        public WrapDirection ClearFloaters { get; set; }
+        public FlowDirection FlowDirection { get; set; }
+        public bool IsHyphenationEnabled { get; set; }
+        public double LineHeight { get; set; }
+        public LineStackingStrategy LineStackingStrategy { get; set; }
+        public Thickness Margin { get; set; }
+        public Block NextBlock { get; }
+        public Thickness Padding { get; set; }
+        public Block PreviousBlock { get; }
+        public BlockCollection SiblingBlocks { get; }
+        public TextAlignment TextAlignment { get; set; }
+        public static bool GetIsHyphenationEnabled(DependencyObject element);
+        public static double GetLineHeight(DependencyObject element);
+        public static LineStackingStrategy GetLineStackingStrategy(DependencyObject element);
+        public static TextAlignment GetTextAlignment(DependencyObject element);
+        public static void SetIsHyphenationEnabled(DependencyObject element, bool value);
+        public static void SetLineHeight(DependencyObject element, double value);
+        public static void SetLineStackingStrategy(DependencyObject element, LineStackingStrategy value);
+        public static void SetTextAlignment(DependencyObject element, TextAlignment value);
+    }
+    public class BlockCollection : TextElementCollection<Block> {
+        public Block FirstBlock { get; }
+        public Block LastBlock { get; }
+    }
+    public class BlockUIContainer : Block {
+        public BlockUIContainer();
+        public BlockUIContainer(UIElement uiElement);
+        public UIElement Child { get; set; }
+    }
+    public class Bold : Span {
+        public Bold();
+        public Bold(Inline childInline);
+        public Bold(Inline childInline, TextPointer insertionPosition);
+        public Bold(TextPointer start, TextPointer end);
+    }
+    public abstract class ContentPosition {
+        public static readonly ContentPosition Missing;
+        protected ContentPosition();
+    }
+    public class DocumentPage : IDisposable {
+        public static readonly DocumentPage Missing;
+        public DocumentPage(Visual visual);
+        public DocumentPage(Visual visual, Size pageSize, Rect bleedBox, Rect contentBox);
+        public virtual Rect BleedBox { get; }
+        public virtual Rect ContentBox { get; }
+        public virtual Size Size { get; }
+        public virtual Visual Visual { get; }
+        public event EventHandler PageDestroyed;
+        public virtual void Dispose();
+        protected void OnPageDestroyed(EventArgs e);
+        protected void SetBleedBox(Rect bleedBox);
+        protected void SetContentBox(Rect contentBox);
+        protected void SetSize(Size size);
+        protected void SetVisual(Visual visual);
+    }
+    public abstract class DocumentPaginator {
+        protected DocumentPaginator();
+        public abstract bool IsPageCountValid { get; }
+        public abstract int PageCount { get; }
+        public abstract Size PageSize { get; set; }
+        public abstract IDocumentPaginatorSource Source { get; }
+        public event AsyncCompletedEventHandler ComputePageCountCompleted;
+        public event GetPageCompletedEventHandler GetPageCompleted;
+        public event PagesChangedEventHandler PagesChanged;
+        public virtual void CancelAsync(object userState);
+        public virtual void ComputePageCount();
+        public virtual void ComputePageCountAsync();
+        public virtual void ComputePageCountAsync(object userState);
+        public abstract DocumentPage GetPage(int pageNumber);
+        public virtual void GetPageAsync(int pageNumber);
+        public virtual void GetPageAsync(int pageNumber, object userState);
+        protected virtual void OnComputePageCountCompleted(AsyncCompletedEventArgs e);
+        protected virtual void OnGetPageCompleted(GetPageCompletedEventArgs e);
+        protected virtual void OnPagesChanged(PagesChangedEventArgs e);
+    }
+    public sealed class DocumentReference : FrameworkElement, IUriContext {
+        public static readonly DependencyProperty SourceProperty;
+        public DocumentReference();
+        public Uri Source { get; set; }
+        Uri System.Windows.Markup.IUriContext.BaseUri { get; set; }
+        public FixedDocument GetDocument(bool forceReload);
+        public void SetDocument(FixedDocument doc);
+    }
+    public sealed class DocumentReferenceCollection : IEnumerable, IEnumerable<DocumentReference>, INotifyCollectionChanged {
+        public int Count { get; }
+        public DocumentReference this[int index] { get; }
+        public event NotifyCollectionChangedEventHandler CollectionChanged;
+        public void Add(DocumentReference item);
+        public void CopyTo(DocumentReference[] array, int arrayIndex);
+        public IEnumerator<DocumentReference> GetEnumerator();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+    }
+    public abstract class DynamicDocumentPaginator : DocumentPaginator {
+        protected DynamicDocumentPaginator();
+        public virtual bool IsBackgroundPaginationEnabled { get; set; }
+        public event GetPageNumberCompletedEventHandler GetPageNumberCompleted;
+        public event EventHandler PaginationCompleted;
+        public event PaginationProgressEventHandler PaginationProgress;
+        public abstract ContentPosition GetObjectPosition(object value);
+        public abstract int GetPageNumber(ContentPosition contentPosition);
+        public virtual void GetPageNumberAsync(ContentPosition contentPosition);
+        public virtual void GetPageNumberAsync(ContentPosition contentPosition, object userState);
+        public abstract ContentPosition GetPagePosition(DocumentPage page);
+        protected virtual void OnGetPageNumberCompleted(GetPageNumberCompletedEventArgs e);
+        protected virtual void OnPaginationCompleted(EventArgs e);
+        protected virtual void OnPaginationProgress(PaginationProgressEventArgs e);
+    }
+    public static class EditingCommands {
+        public static RoutedUICommand AlignCenter { get; }
+        public static RoutedUICommand AlignJustify { get; }
+        public static RoutedUICommand AlignLeft { get; }
+        public static RoutedUICommand AlignRight { get; }
+        public static RoutedUICommand Backspace { get; }
+        public static RoutedUICommand CorrectSpellingError { get; }
+        public static RoutedUICommand DecreaseFontSize { get; }
+        public static RoutedUICommand DecreaseIndentation { get; }
+        public static RoutedUICommand Delete { get; }
+        public static RoutedUICommand DeleteNextWord { get; }
+        public static RoutedUICommand DeletePreviousWord { get; }
+        public static RoutedUICommand EnterLineBreak { get; }
+        public static RoutedUICommand EnterParagraphBreak { get; }
+        public static RoutedUICommand IgnoreSpellingError { get; }
+        public static RoutedUICommand IncreaseFontSize { get; }
+        public static RoutedUICommand IncreaseIndentation { get; }
+        public static RoutedUICommand MoveDownByLine { get; }
+        public static RoutedUICommand MoveDownByPage { get; }
+        public static RoutedUICommand MoveDownByParagraph { get; }
+        public static RoutedUICommand MoveLeftByCharacter { get; }
+        public static RoutedUICommand MoveLeftByWord { get; }
+        public static RoutedUICommand MoveRightByCharacter { get; }
+        public static RoutedUICommand MoveRightByWord { get; }
+        public static RoutedUICommand MoveToDocumentEnd { get; }
+        public static RoutedUICommand MoveToDocumentStart { get; }
+        public static RoutedUICommand MoveToLineEnd { get; }
+        public static RoutedUICommand MoveToLineStart { get; }
+        public static RoutedUICommand MoveUpByLine { get; }
+        public static RoutedUICommand MoveUpByPage { get; }
+        public static RoutedUICommand MoveUpByParagraph { get; }
+        public static RoutedUICommand SelectDownByLine { get; }
+        public static RoutedUICommand SelectDownByPage { get; }
+        public static RoutedUICommand SelectDownByParagraph { get; }
+        public static RoutedUICommand SelectLeftByCharacter { get; }
+        public static RoutedUICommand SelectLeftByWord { get; }
+        public static RoutedUICommand SelectRightByCharacter { get; }
+        public static RoutedUICommand SelectRightByWord { get; }
+        public static RoutedUICommand SelectToDocumentEnd { get; }
+        public static RoutedUICommand SelectToDocumentStart { get; }
+        public static RoutedUICommand SelectToLineEnd { get; }
+        public static RoutedUICommand SelectToLineStart { get; }
+        public static RoutedUICommand SelectUpByLine { get; }
+        public static RoutedUICommand SelectUpByPage { get; }
+        public static RoutedUICommand SelectUpByParagraph { get; }
+        public static RoutedUICommand TabBackward { get; }
+        public static RoutedUICommand TabForward { get; }
+        public static RoutedUICommand ToggleBold { get; }
+        public static RoutedUICommand ToggleBullets { get; }
+        public static RoutedUICommand ToggleInsert { get; }
+        public static RoutedUICommand ToggleItalic { get; }
+        public static RoutedUICommand ToggleNumbering { get; }
+        public static RoutedUICommand ToggleSubscript { get; }
+        public static RoutedUICommand ToggleSuperscript { get; }
+        public static RoutedUICommand ToggleUnderline { get; }
+    }
+    public class Figure : AnchoredBlock {
+        public static readonly DependencyProperty CanDelayPlacementProperty;
+        public static readonly DependencyProperty HeightProperty;
+        public static readonly DependencyProperty HorizontalAnchorProperty;
+        public static readonly DependencyProperty HorizontalOffsetProperty;
+        public static readonly DependencyProperty VerticalAnchorProperty;
+        public static readonly DependencyProperty VerticalOffsetProperty;
+        public static readonly DependencyProperty WidthProperty;
+        public static readonly DependencyProperty WrapDirectionProperty;
+        public Figure();
+        public Figure(Block childBlock);
+        public Figure(Block childBlock, TextPointer insertionPosition);
+        public bool CanDelayPlacement { get; set; }
+        public FigureLength Height { get; set; }
+        public FigureHorizontalAnchor HorizontalAnchor { get; set; }
+        public double HorizontalOffset { get; set; }
+        public FigureVerticalAnchor VerticalAnchor { get; set; }
+        public double VerticalOffset { get; set; }
+        public FigureLength Width { get; set; }
+        public WrapDirection WrapDirection { get; set; }
+    }
+    public class FixedDocument : FrameworkContentElement, IAddChild, IAddChildInternal, IDocumentPaginatorSource, IFixedNavigate, IServiceProvider, IUriContext {
+        public static readonly DependencyProperty PrintTicketProperty;
+        public FixedDocument();
+        public DocumentPaginator DocumentPaginator { get; }
+        protected internal override IEnumerator LogicalChildren { get; }
+        public PageContentCollection Pages { get; }
+        public object PrintTicket { get; set; }
+        Uri System.Windows.Markup.IUriContext.BaseUri { get; set; }
+        protected override AutomationPeer OnCreateAutomationPeer();
+        object System.IServiceProvider.GetService(Type serviceType);
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public class FixedDocumentSequence : FrameworkContentElement, IAddChild, IAddChildInternal, IDocumentPaginatorSource, IFixedNavigate, IServiceProvider, IUriContext {
+        public static readonly DependencyProperty PrintTicketProperty;
+        public FixedDocumentSequence();
+        public DocumentPaginator DocumentPaginator { get; }
+        protected internal override IEnumerator LogicalChildren { get; }
+        public object PrintTicket { get; set; }
+        public DocumentReferenceCollection References { get; }
+        Uri System.Windows.Markup.IUriContext.BaseUri { get; set; }
+        protected override AutomationPeer OnCreateAutomationPeer();
+        object System.IServiceProvider.GetService(Type serviceType);
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public sealed class FixedPage : FrameworkElement, IAddChild, IAddChildInternal, IFixedNavigate, IUriContext {
+        public static readonly DependencyProperty BackgroundProperty;
+        public static readonly DependencyProperty BleedBoxProperty;
+        public static readonly DependencyProperty BottomProperty;
+        public static readonly DependencyProperty ContentBoxProperty;
+        public static readonly DependencyProperty LeftProperty;
+        public static readonly DependencyProperty NavigateUriProperty;
+        public static readonly DependencyProperty PrintTicketProperty;
+        public static readonly DependencyProperty RightProperty;
+        public static readonly DependencyProperty TopProperty;
+        public FixedPage();
+        public Brush Background { get; set; }
+        public Rect BleedBox { get; set; }
+        public UIElementCollection Children { get; }
+        public Rect ContentBox { get; set; }
+        protected internal override IEnumerator LogicalChildren { get; }
+        public object PrintTicket { get; set; }
+        Uri System.Windows.Markup.IUriContext.BaseUri { get; set; }
+        protected override int VisualChildrenCount { get; }
+        protected override Size ArrangeOverride(Size arrangeSize);
+        public static double GetBottom(UIElement element);
+        public static double GetLeft(UIElement element);
+        public static Uri GetNavigateUri(UIElement element);
+        public static double GetRight(UIElement element);
+        public static double GetTop(UIElement element);
+        protected override Visual GetVisualChild(int index);
+        protected override Size MeasureOverride(Size constraint);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnPreviewMouseWheel(MouseWheelEventArgs e);
+        protected override void OnRender(DrawingContext dc);
+        protected internal override void OnVisualParentChanged(DependencyObject oldParent);
+        public static void SetBottom(UIElement element, double length);
+        public static void SetLeft(UIElement element, double length);
+        public static void SetNavigateUri(UIElement element, Uri uri);
+        public static void SetRight(UIElement element, double length);
+        public static void SetTop(UIElement element, double length);
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public class Floater : AnchoredBlock {
+        public static readonly DependencyProperty HorizontalAlignmentProperty;
+        public static readonly DependencyProperty WidthProperty;
+        public Floater();
+        public Floater(Block childBlock);
+        public Floater(Block childBlock, TextPointer insertionPosition);
+        public HorizontalAlignment HorizontalAlignment { get; set; }
+        public double Width { get; set; }
+    }
+    public class FlowDocument : FrameworkContentElement, IAddChild, IDocumentPaginatorSource, IServiceProvider {
+        public static readonly DependencyProperty BackgroundProperty;
+        public static readonly DependencyProperty ColumnGapProperty;
+        public static readonly DependencyProperty ColumnRuleBrushProperty;
+        public static readonly DependencyProperty ColumnRuleWidthProperty;
+        public static readonly DependencyProperty ColumnWidthProperty;
+        public static readonly DependencyProperty FlowDirectionProperty;
+        public static readonly DependencyProperty FontFamilyProperty;
+        public static readonly DependencyProperty FontSizeProperty;
+        public static readonly DependencyProperty FontStretchProperty;
+        public static readonly DependencyProperty FontStyleProperty;
+        public static readonly DependencyProperty FontWeightProperty;
+        public static readonly DependencyProperty ForegroundProperty;
+        public static readonly DependencyProperty IsColumnWidthFlexibleProperty;
+        public static readonly DependencyProperty IsHyphenationEnabledProperty;
+        public static readonly DependencyProperty IsOptimalParagraphEnabledProperty;
+        public static readonly DependencyProperty LineHeightProperty;
+        public static readonly DependencyProperty LineStackingStrategyProperty;
+        public static readonly DependencyProperty MaxPageHeightProperty;
+        public static readonly DependencyProperty MaxPageWidthProperty;
+        public static readonly DependencyProperty MinPageHeightProperty;
+        public static readonly DependencyProperty MinPageWidthProperty;
+        public static readonly DependencyProperty PageHeightProperty;
+        public static readonly DependencyProperty PagePaddingProperty;
+        public static readonly DependencyProperty PageWidthProperty;
+        public static readonly DependencyProperty TextAlignmentProperty;
+        public static readonly DependencyProperty TextEffectsProperty;
+        public FlowDocument();
+        public FlowDocument(Block block);
+        public Brush Background { get; set; }
+        public BlockCollection Blocks { get; }
+        public double ColumnGap { get; set; }
+        public Brush ColumnRuleBrush { get; set; }
+        public double ColumnRuleWidth { get; set; }
+        public double ColumnWidth { get; set; }
+        public TextPointer ContentEnd { get; }
+        public TextPointer ContentStart { get; }
+        public FlowDirection FlowDirection { get; set; }
+        public FontFamily FontFamily { get; set; }
+        public double FontSize { get; set; }
+        public FontStretch FontStretch { get; set; }
+        public FontStyle FontStyle { get; set; }
+        public FontWeight FontWeight { get; set; }
+        public Brush Foreground { get; set; }
+        public bool IsColumnWidthFlexible { get; set; }
+        protected override bool IsEnabledCore { get; }
+        public bool IsHyphenationEnabled { get; set; }
+        public bool IsOptimalParagraphEnabled { get; set; }
+        public double LineHeight { get; set; }
+        public LineStackingStrategy LineStackingStrategy { get; set; }
+        protected internal override IEnumerator LogicalChildren { get; }
+        public double MaxPageHeight { get; set; }
+        public double MaxPageWidth { get; set; }
+        public double MinPageHeight { get; set; }
+        public double MinPageWidth { get; set; }
+        public double PageHeight { get; set; }
+        public Thickness PagePadding { get; set; }
+        public double PageWidth { get; set; }
+        DocumentPaginator System.Windows.Documents.IDocumentPaginatorSource.DocumentPaginator { get; }
+        public TextAlignment TextAlignment { get; set; }
+        public TextEffectCollection TextEffects { get; set; }
+        public Typography Typography { get; }
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected sealed override void OnPropertyChanged(DependencyPropertyChangedEventArgs e);
+        object System.IServiceProvider.GetService(Type serviceType);
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public sealed class FrameworkRichTextComposition : FrameworkTextComposition {
+        public TextPointer CompositionEnd { get; }
+        public TextPointer CompositionStart { get; }
+        public TextPointer ResultEnd { get; }
+        public TextPointer ResultStart { get; }
+    }
+    public class FrameworkTextComposition : TextComposition {
+        public int CompositionLength { get; }
+        public int CompositionOffset { get; }
+        public int ResultLength { get; }
+        public int ResultOffset { get; }
+        public override void Complete();
+    }
+    public class GetPageCompletedEventArgs : AsyncCompletedEventArgs {
+        public GetPageCompletedEventArgs(DocumentPage page, int pageNumber, Exception error, bool cancelled, object userState);
+        public DocumentPage DocumentPage { get; }
+        public int PageNumber { get; }
+    }
+    public delegate void GetPageCompletedEventHandler(object sender, GetPageCompletedEventArgs e);
+    public class GetPageNumberCompletedEventArgs : AsyncCompletedEventArgs {
+        public GetPageNumberCompletedEventArgs(ContentPosition contentPosition, int pageNumber, Exception error, bool cancelled, object userState);
+        public ContentPosition ContentPosition { get; }
+        public int PageNumber { get; }
+    }
+    public delegate void GetPageNumberCompletedEventHandler(object sender, GetPageNumberCompletedEventArgs e);
+    public sealed class GetPageRootCompletedEventArgs : AsyncCompletedEventArgs {
+        public FixedPage Result { get; }
+    }
+    public delegate void GetPageRootCompletedEventHandler(object sender, GetPageRootCompletedEventArgs e);
+    public sealed class Glyphs : FrameworkElement, IUriContext {
+        public static readonly DependencyProperty BidiLevelProperty;
+        public static readonly DependencyProperty CaretStopsProperty;
+        public static readonly DependencyProperty DeviceFontNameProperty;
+        public static readonly DependencyProperty FillProperty;
+        public static readonly DependencyProperty FontRenderingEmSizeProperty;
+        public static readonly DependencyProperty FontUriProperty;
+        public static readonly DependencyProperty IndicesProperty;
+        public static readonly DependencyProperty IsSidewaysProperty;
+        public static readonly DependencyProperty OriginXProperty;
+        public static readonly DependencyProperty OriginYProperty;
+        public static readonly DependencyProperty StyleSimulationsProperty;
+        public static readonly DependencyProperty UnicodeStringProperty;
+        public Glyphs();
+        public int BidiLevel { get; set; }
+        public string CaretStops { get; set; }
+        public string DeviceFontName { get; set; }
+        public Brush Fill { get; set; }
+        public double FontRenderingEmSize { get; set; }
+        public Uri FontUri { get; set; }
+        public string Indices { get; set; }
+        public bool IsSideways { get; set; }
+        public double OriginX { get; set; }
+        public double OriginY { get; set; }
+        public StyleSimulations StyleSimulations { get; set; }
+        Uri System.Windows.Markup.IUriContext.BaseUri { get; set; }
+        public string UnicodeString { get; set; }
+        protected override Size ArrangeOverride(Size finalSize);
+        protected override Size MeasureOverride(Size constraint);
+        protected override void OnRender(DrawingContext context);
+        public GlyphRun ToGlyphRun();
+    }
+    public class Hyperlink : Span, ICommandSource, IUriContext {
+        public static readonly DependencyProperty CommandParameterProperty;
+        public static readonly DependencyProperty CommandProperty;
+        public static readonly DependencyProperty CommandTargetProperty;
+        public static readonly DependencyProperty NavigateUriProperty;
+        public static readonly DependencyProperty TargetNameProperty;
+        public static readonly RoutedEvent ClickEvent;
+        public static readonly RoutedEvent RequestNavigateEvent;
+        public Hyperlink();
+        public Hyperlink(Inline childInline);
+        public Hyperlink(Inline childInline, TextPointer insertionPosition);
+        public Hyperlink(TextPointer start, TextPointer end);
+        protected virtual Uri BaseUri { get; set; }
+        public ICommand Command { get; set; }
+        public object CommandParameter { get; set; }
+        public IInputElement CommandTarget { get; set; }
+        protected override bool IsEnabledCore { get; }
+        public Uri NavigateUri { get; set; }
+        Uri System.Windows.Markup.IUriContext.BaseUri { get; set; }
+        public string TargetName { get; set; }
+        public event RoutedEventHandler Click;
+        public event RequestNavigateEventHandler RequestNavigate;
+        public void DoClick();
+        protected virtual void OnClick();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected internal override void OnKeyDown(KeyEventArgs e);
+        protected internal override void OnMouseLeftButtonDown(MouseButtonEventArgs e);
+        protected internal override void OnMouseLeftButtonUp(MouseButtonEventArgs e);
+    }
+    public interface IDocumentPaginatorSource {
+        DocumentPaginator DocumentPaginator { get; }
+    }
+    public abstract class Inline : TextElement {
+        public static readonly DependencyProperty BaselineAlignmentProperty;
+        public static readonly DependencyProperty FlowDirectionProperty;
+        public static readonly DependencyProperty TextDecorationsProperty;
+        protected Inline();
+        public BaselineAlignment BaselineAlignment { get; set; }
+        public FlowDirection FlowDirection { get; set; }
+        public Inline NextInline { get; }
+        public Inline PreviousInline { get; }
+        public InlineCollection SiblingInlines { get; }
+        public TextDecorationCollection TextDecorations { get; set; }
+    }
+    public class InlineCollection : TextElementCollection<Inline>, ICollection, IEnumerable, IList {
+        public Inline FirstInline { get; }
+        public Inline LastInline { get; }
+        public void Add(string text);
+        public void Add(UIElement uiElement);
+    }
+    public class InlineUIContainer : Inline {
+        public InlineUIContainer();
+        public InlineUIContainer(UIElement childUIElement);
+        public InlineUIContainer(UIElement childUIElement, TextPointer insertionPosition);
+        public UIElement Child { get; set; }
+    }
+    public class Italic : Span {
+        public Italic();
+        public Italic(Inline childInline);
+        public Italic(Inline childInline, TextPointer insertionPosition);
+        public Italic(TextPointer start, TextPointer end);
+    }
+    public class LineBreak : Inline {
+        public LineBreak();
+        public LineBreak(TextPointer insertionPosition);
+    }
+    public sealed class LinkTarget {
+        public LinkTarget();
+        public string Name { get; set; }
+    }
+    public sealed class LinkTargetCollection : CollectionBase {
+        public LinkTargetCollection();
+        public LinkTarget this[int index] { get; set; }
+        public int Add(LinkTarget value);
+        public bool Contains(LinkTarget value);
+        public void CopyTo(LinkTarget[] array, int index);
+        public int IndexOf(LinkTarget value);
+        public void Insert(int index, LinkTarget value);
+        public void Remove(LinkTarget value);
+    }
+    public class List : Block {
+        public static readonly DependencyProperty MarkerOffsetProperty;
+        public static readonly DependencyProperty MarkerStyleProperty;
+        public static readonly DependencyProperty StartIndexProperty;
+        public List();
+        public List(ListItem listItem);
+        public ListItemCollection ListItems { get; }
+        public double MarkerOffset { get; set; }
+        public TextMarkerStyle MarkerStyle { get; set; }
+        public int StartIndex { get; set; }
+    }
+    public class ListItem : TextElement {
+        public static readonly DependencyProperty BorderBrushProperty;
+        public static readonly DependencyProperty BorderThicknessProperty;
+        public static readonly DependencyProperty FlowDirectionProperty;
+        public static readonly DependencyProperty LineHeightProperty;
+        public static readonly DependencyProperty LineStackingStrategyProperty;
+        public static readonly DependencyProperty MarginProperty;
+        public static readonly DependencyProperty PaddingProperty;
+        public static readonly DependencyProperty TextAlignmentProperty;
+        public ListItem();
+        public ListItem(Paragraph paragraph);
+        public BlockCollection Blocks { get; }
+        public Brush BorderBrush { get; set; }
+        public Thickness BorderThickness { get; set; }
+        public FlowDirection FlowDirection { get; set; }
+        public double LineHeight { get; set; }
+        public LineStackingStrategy LineStackingStrategy { get; set; }
+        public List List { get; }
+        public Thickness Margin { get; set; }
+        public ListItem NextListItem { get; }
+        public Thickness Padding { get; set; }
+        public ListItem PreviousListItem { get; }
+        public ListItemCollection SiblingListItems { get; }
+        public TextAlignment TextAlignment { get; set; }
+        public bool ShouldSerializeBlocks(XamlDesignerSerializationManager manager);
+    }
+    public class ListItemCollection : TextElementCollection<ListItem> {
+        public ListItem FirstListItem { get; }
+        public ListItem LastListItem { get; }
+    }
+    public enum LogicalDirection {
+        Backward = 0,
+        Forward = 1,
+    }
+    public sealed class PageContent : FrameworkElement, IAddChild, IAddChildInternal, IUriContext {
+        public static readonly DependencyProperty SourceProperty;
+        public PageContent();
+        public FixedPage Child { get; set; }
+        public LinkTargetCollection LinkTargets { get; }
+        protected internal override IEnumerator LogicalChildren { get; }
+        public Uri Source { get; set; }
+        Uri System.Windows.Markup.IUriContext.BaseUri { get; set; }
+        public event GetPageRootCompletedEventHandler GetPageRootCompleted;
+        public FixedPage GetPageRoot(bool forceReload);
+        public void GetPageRootAsync(bool forceReload);
+        public void GetPageRootAsyncCancel();
+        public bool ShouldSerializeChild(XamlDesignerSerializationManager manager);
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public sealed class PageContentCollection : IEnumerable, IEnumerable<PageContent> {
+        public int Count { get; }
+        public PageContent this[int pageIndex] { get; }
+        public int Add(PageContent newPageContent);
+        public IEnumerator<PageContent> GetEnumerator();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+    }
+    public class PagesChangedEventArgs : EventArgs {
+        public PagesChangedEventArgs(int start, int count);
+        public int Count { get; }
+        public int Start { get; }
+    }
+    public delegate void PagesChangedEventHandler(object sender, PagesChangedEventArgs e);
+    public class PaginationProgressEventArgs : EventArgs {
+        public PaginationProgressEventArgs(int start, int count);
+        public int Count { get; }
+        public int Start { get; }
+    }
+    public delegate void PaginationProgressEventHandler(object sender, PaginationProgressEventArgs e);
+    public class Paragraph : Block {
+        public static readonly DependencyProperty KeepTogetherProperty;
+        public static readonly DependencyProperty KeepWithNextProperty;
+        public static readonly DependencyProperty MinOrphanLinesProperty;
+        public static readonly DependencyProperty MinWidowLinesProperty;
+        public static readonly DependencyProperty TextDecorationsProperty;
+        public static readonly DependencyProperty TextIndentProperty;
+        public Paragraph();
+        public Paragraph(Inline inline);
+        public InlineCollection Inlines { get; }
+        public bool KeepTogether { get; set; }
+        public bool KeepWithNext { get; set; }
+        public int MinOrphanLines { get; set; }
+        public int MinWidowLines { get; set; }
+        public TextDecorationCollection TextDecorations { get; set; }
+        public double TextIndent { get; set; }
+        public bool ShouldSerializeInlines(XamlDesignerSerializationManager manager);
+    }
+    public class Run : Inline {
+        public static readonly DependencyProperty TextProperty;
+        public Run();
+        public Run(string text);
+        public Run(string text, TextPointer insertionPosition);
+        public string Text { get; set; }
+        public bool ShouldSerializeText(XamlDesignerSerializationManager manager);
+    }
+    public class Section : Block {
+        public Section();
+        public Section(Block block);
+        public BlockCollection Blocks { get; }
+        public bool HasTrailingParagraphBreakOnPaste { get; set; }
+        public bool ShouldSerializeBlocks(XamlDesignerSerializationManager manager);
+    }
+    public class Span : Inline {
+        public Span();
+        public Span(Inline childInline);
+        public Span(Inline childInline, TextPointer insertionPosition);
+        public Span(TextPointer start, TextPointer end);
+        public InlineCollection Inlines { get; }
+        public bool ShouldSerializeInlines(XamlDesignerSerializationManager manager);
+    }
+    public class Table : Block, IAcceptInsertion, IAddChild {
+        public static readonly DependencyProperty CellSpacingProperty;
+        public Table();
+        public double CellSpacing { get; set; }
+        public TableColumnCollection Columns { get; }
+        protected internal override IEnumerator LogicalChildren { get; }
+        public TableRowGroupCollection RowGroups { get; }
+        public override void BeginInit();
+        public override void EndInit();
+        protected override AutomationPeer OnCreateAutomationPeer();
+        public bool ShouldSerializeColumns();
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public class TableCell : TextElement, IIndexedChild<TableRow> {
+        public static readonly DependencyProperty BorderBrushProperty;
+        public static readonly DependencyProperty BorderThicknessProperty;
+        public static readonly DependencyProperty ColumnSpanProperty;
+        public static readonly DependencyProperty FlowDirectionProperty;
+        public static readonly DependencyProperty LineHeightProperty;
+        public static readonly DependencyProperty LineStackingStrategyProperty;
+        public static readonly DependencyProperty PaddingProperty;
+        public static readonly DependencyProperty RowSpanProperty;
+        public static readonly DependencyProperty TextAlignmentProperty;
+        public TableCell();
+        public TableCell(Block blockItem);
+        public BlockCollection Blocks { get; }
+        public Brush BorderBrush { get; set; }
+        public Thickness BorderThickness { get; set; }
+        public int ColumnSpan { get; set; }
+        public FlowDirection FlowDirection { get; set; }
+        public double LineHeight { get; set; }
+        public LineStackingStrategy LineStackingStrategy { get; set; }
+        public Thickness Padding { get; set; }
+        public int RowSpan { get; set; }
+        public TextAlignment TextAlignment { get; set; }
+        protected override AutomationPeer OnCreateAutomationPeer();
+    }
+    public sealed class TableCellCollection : ICollection, ICollection<TableCell>, IEnumerable, IEnumerable<TableCell>, IList, IList<TableCell> {
+        public int Capacity { get; set; }
+        public int Count { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public TableCell this[int index] { get; set; }
+        public void Add(TableCell item);
+        public void Clear();
+        public bool Contains(TableCell item);
+        public void CopyTo(Array array, int index);
+        public void CopyTo(TableCell[] array, int index);
+        public int IndexOf(TableCell item);
+        public void Insert(int index, TableCell item);
+        public bool Remove(TableCell item);
+        public void RemoveAt(int index);
+        public void RemoveRange(int index, int count);
+        IEnumerator<TableCell> System.Collections.Generic.IEnumerable<System.Windows.Documents.TableCell>.GetEnumerator();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        void System.Collections.IList.Clear();
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        void System.Collections.IList.RemoveAt(int index);
+        public void TrimToSize();
+    }
+    public class TableColumn : FrameworkContentElement, IIndexedChild<Table> {
+        public static readonly DependencyProperty BackgroundProperty;
+        public static readonly DependencyProperty WidthProperty;
+        public TableColumn();
+        public Brush Background { get; set; }
+        public GridLength Width { get; set; }
+    }
+    public sealed class TableColumnCollection : ICollection, ICollection<TableColumn>, IEnumerable, IEnumerable<TableColumn>, IList, IList<TableColumn> {
+        public int Capacity { get; set; }
+        public int Count { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public TableColumn this[int index] { get; set; }
+        public void Add(TableColumn item);
+        public void Clear();
+        public bool Contains(TableColumn item);
+        public void CopyTo(Array array, int index);
+        public void CopyTo(TableColumn[] array, int index);
+        public int IndexOf(TableColumn item);
+        public void Insert(int index, TableColumn item);
+        public bool Remove(TableColumn item);
+        public void RemoveAt(int index);
+        public void RemoveRange(int index, int count);
+        IEnumerator<TableColumn> System.Collections.Generic.IEnumerable<System.Windows.Documents.TableColumn>.GetEnumerator();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        void System.Collections.IList.Clear();
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        void System.Collections.IList.RemoveAt(int index);
+        public void TrimToSize();
+    }
+    public class TableRow : TextElement, IAcceptInsertion, IAddChild, IIndexedChild<TableRowGroup> {
+        public TableRow();
+        public TableCellCollection Cells { get; }
+        public bool ShouldSerializeCells();
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public sealed class TableRowCollection : ICollection, ICollection<TableRow>, IEnumerable, IEnumerable<TableRow>, IList, IList<TableRow> {
+        public int Capacity { get; set; }
+        public int Count { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public TableRow this[int index] { get; set; }
+        public void Add(TableRow item);
+        public void Clear();
+        public bool Contains(TableRow item);
+        public void CopyTo(Array array, int index);
+        public void CopyTo(TableRow[] array, int index);
+        public int IndexOf(TableRow item);
+        public void Insert(int index, TableRow item);
+        public bool Remove(TableRow item);
+        public void RemoveAt(int index);
+        public void RemoveRange(int index, int count);
+        IEnumerator<TableRow> System.Collections.Generic.IEnumerable<System.Windows.Documents.TableRow>.GetEnumerator();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        void System.Collections.IList.Clear();
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        void System.Collections.IList.RemoveAt(int index);
+        public void TrimToSize();
+    }
+    public class TableRowGroup : TextElement, IAcceptInsertion, IAddChild, IIndexedChild<Table> {
+        public TableRowGroup();
+        public TableRowCollection Rows { get; }
+        public bool ShouldSerializeRows();
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public sealed class TableRowGroupCollection : ICollection, ICollection<TableRowGroup>, IEnumerable, IEnumerable<TableRowGroup>, IList, IList<TableRowGroup> {
+        public int Capacity { get; set; }
+        public int Count { get; }
+        public bool IsReadOnly { get; }
+        public bool IsSynchronized { get; }
+        public object SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public TableRowGroup this[int index] { get; set; }
+        public void Add(TableRowGroup item);
+        public void Clear();
+        public bool Contains(TableRowGroup item);
+        public void CopyTo(Array array, int index);
+        public void CopyTo(TableRowGroup[] array, int index);
+        public int IndexOf(TableRowGroup item);
+        public void Insert(int index, TableRowGroup item);
+        public bool Remove(TableRowGroup item);
+        public void RemoveAt(int index);
+        public void RemoveRange(int index, int count);
+        IEnumerator<TableRowGroup> System.Collections.Generic.IEnumerable<System.Windows.Documents.TableRowGroup>.GetEnumerator();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        void System.Collections.IList.Clear();
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        void System.Collections.IList.RemoveAt(int index);
+        public void TrimToSize();
+    }
+    public static class TextEffectResolver {
+        public static TextEffectTarget[] Resolve(TextPointer startPosition, TextPointer endPosition, TextEffect effect);
+    }
+    public class TextEffectTarget {
+        public DependencyObject Element { get; }
+        public bool IsEnabled { get; }
+        public TextEffect TextEffect { get; }
+        public void Disable();
+        public void Enable();
+    }
+    public abstract class TextElement : FrameworkContentElement, IAddChild {
+        public static readonly DependencyProperty BackgroundProperty;
+        public static readonly DependencyProperty FontFamilyProperty;
+        public static readonly DependencyProperty FontSizeProperty;
+        public static readonly DependencyProperty FontStretchProperty;
+        public static readonly DependencyProperty FontStyleProperty;
+        public static readonly DependencyProperty FontWeightProperty;
+        public static readonly DependencyProperty ForegroundProperty;
+        public static readonly DependencyProperty TextEffectsProperty;
+        public Brush Background { get; set; }
+        public TextPointer ContentEnd { get; }
+        public TextPointer ContentStart { get; }
+        public TextPointer ElementEnd { get; }
+        public TextPointer ElementStart { get; }
+        public FontFamily FontFamily { get; set; }
+        public double FontSize { get; set; }
+        public FontStretch FontStretch { get; set; }
+        public FontStyle FontStyle { get; set; }
+        public FontWeight FontWeight { get; set; }
+        public Brush Foreground { get; set; }
+        protected internal override IEnumerator LogicalChildren { get; }
+        public TextEffectCollection TextEffects { get; set; }
+        public Typography Typography { get; }
+        public static FontFamily GetFontFamily(DependencyObject element);
+        public static double GetFontSize(DependencyObject element);
+        public static FontStretch GetFontStretch(DependencyObject element);
+        public static FontStyle GetFontStyle(DependencyObject element);
+        public static FontWeight GetFontWeight(DependencyObject element);
+        public static Brush GetForeground(DependencyObject element);
+        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e);
+        public static void SetFontFamily(DependencyObject element, FontFamily value);
+        public static void SetFontSize(DependencyObject element, double value);
+        public static void SetFontStretch(DependencyObject element, FontStretch value);
+        public static void SetFontStyle(DependencyObject element, FontStyle value);
+        public static void SetFontWeight(DependencyObject element, FontWeight value);
+        public static void SetForeground(DependencyObject element, Brush value);
+        void System.Windows.Markup.IAddChild.AddChild(object value);
+        void System.Windows.Markup.IAddChild.AddText(string text);
+    }
+    public class TextElementCollection<TextElementType> : ICollection, ICollection<TextElementType>, IEnumerable, IEnumerable<TextElementType>, IList where TextElementType : TextElement {
+        public int Count { get; }
+        public bool IsReadOnly { get; }
+        int System.Collections.ICollection.Count { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        public void Add(TextElementType item);
+        public void AddRange(IEnumerable range);
+        public void Clear();
+        public bool Contains(TextElementType item);
+        public void CopyTo(TextElementType[] array, int arrayIndex);
+        public IEnumerator<TextElementType> GetEnumerator();
+        public void InsertAfter(TextElementType previousSibling, TextElementType newItem);
+        public void InsertBefore(TextElementType nextSibling, TextElementType newItem);
+        public bool Remove(TextElementType item);
+        void System.Collections.ICollection.CopyTo(Array array, int arrayIndex);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        void System.Collections.IList.Clear();
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        void System.Collections.IList.RemoveAt(int index);
+    }
+    public sealed class TextElementEditingBehaviorAttribute : Attribute {
+        public TextElementEditingBehaviorAttribute();
+        public bool IsMergeable { get; set; }
+        public bool IsTypographicOnly { get; set; }
+    }
+    public class TextPointer : ContentPosition, ITextPointer {
+        public TextPointer DocumentEnd { get; }
+        public TextPointer DocumentStart { get; }
+        public bool HasValidLayout { get; }
+        public bool IsAtInsertionPosition { get; }
+        public bool IsAtLineStartPosition { get; }
+        public LogicalDirection LogicalDirection { get; }
+        public Paragraph Paragraph { get; }
+        public DependencyObject Parent { get; }
+        public int CompareTo(TextPointer position);
+        public int DeleteTextInRun(int count);
+        public DependencyObject GetAdjacentElement(LogicalDirection direction);
+        public Rect GetCharacterRect(LogicalDirection direction);
+        public TextPointer GetInsertionPosition(LogicalDirection direction);
+        public TextPointer GetLineStartPosition(int count);
+        public TextPointer GetLineStartPosition(int count, out int actualCount);
+        public TextPointer GetNextContextPosition(LogicalDirection direction);
+        public TextPointer GetNextInsertionPosition(LogicalDirection direction);
+        public int GetOffsetToPosition(TextPointer position);
+        public TextPointerContext GetPointerContext(LogicalDirection direction);
+        public TextPointer GetPositionAtOffset(int offset);
+        public TextPointer GetPositionAtOffset(int offset, LogicalDirection direction);
+        public string GetTextInRun(LogicalDirection direction);
+        public int GetTextInRun(LogicalDirection direction, char[] textBuffer, int startIndex, int count);
+        public int GetTextRunLength(LogicalDirection direction);
+        public TextPointer InsertLineBreak();
+        public TextPointer InsertParagraphBreak();
+        public void InsertTextInRun(string textData);
+        public bool IsInSameDocument(TextPointer textPosition);
+        public override string ToString();
+    }
+    public enum TextPointerContext {
+        ElementEnd = 4,
+        ElementStart = 3,
+        EmbeddedElement = 2,
+        None = 0,
+        Text = 1,
+    }
+    public class TextRange : ITextRange {
+        public TextRange(TextPointer position1, TextPointer position2);
+        public TextPointer End { get; }
+        public bool IsEmpty { get; }
+        public TextPointer Start { get; }
+        public string Text { get; set; }
+        public event EventHandler Changed;
+        public void ApplyPropertyValue(DependencyProperty formattingProperty, object value);
+        public bool CanLoad(string dataFormat);
+        public bool CanSave(string dataFormat);
+        public void ClearAllProperties();
+        public bool Contains(TextPointer textPointer);
+        public object GetPropertyValue(DependencyProperty formattingProperty);
+        public void Load(Stream stream, string dataFormat);
+        public void Save(Stream stream, string dataFormat);
+        public void Save(Stream stream, string dataFormat, bool preserveTextElements);
+        public void Select(TextPointer position1, TextPointer position2);
+    }
+    public sealed class TextSelection : TextRange, ITextRange, ITextSelection
+    public sealed class Typography {
+        public static readonly DependencyProperty AnnotationAlternatesProperty;
+        public static readonly DependencyProperty CapitalSpacingProperty;
+        public static readonly DependencyProperty CapitalsProperty;
+        public static readonly DependencyProperty CaseSensitiveFormsProperty;
+        public static readonly DependencyProperty ContextualAlternatesProperty;
+        public static readonly DependencyProperty ContextualLigaturesProperty;
+        public static readonly DependencyProperty ContextualSwashesProperty;
+        public static readonly DependencyProperty DiscretionaryLigaturesProperty;
+        public static readonly DependencyProperty EastAsianExpertFormsProperty;
+        public static readonly DependencyProperty EastAsianLanguageProperty;
+        public static readonly DependencyProperty EastAsianWidthsProperty;
+        public static readonly DependencyProperty FractionProperty;
+        public static readonly DependencyProperty HistoricalFormsProperty;
+        public static readonly DependencyProperty HistoricalLigaturesProperty;
+        public static readonly DependencyProperty KerningProperty;
+        public static readonly DependencyProperty MathematicalGreekProperty;
+        public static readonly DependencyProperty NumeralAlignmentProperty;
+        public static readonly DependencyProperty NumeralStyleProperty;
+        public static readonly DependencyProperty SlashedZeroProperty;
+        public static readonly DependencyProperty StandardLigaturesProperty;
+        public static readonly DependencyProperty StandardSwashesProperty;
+        public static readonly DependencyProperty StylisticAlternatesProperty;
+        public static readonly DependencyProperty StylisticSet10Property;
+        public static readonly DependencyProperty StylisticSet11Property;
+        public static readonly DependencyProperty StylisticSet12Property;
+        public static readonly DependencyProperty StylisticSet13Property;
+        public static readonly DependencyProperty StylisticSet14Property;
+        public static readonly DependencyProperty StylisticSet15Property;
+        public static readonly DependencyProperty StylisticSet16Property;
+        public static readonly DependencyProperty StylisticSet17Property;
+        public static readonly DependencyProperty StylisticSet18Property;
+        public static readonly DependencyProperty StylisticSet19Property;
+        public static readonly DependencyProperty StylisticSet1Property;
+        public static readonly DependencyProperty StylisticSet20Property;
+        public static readonly DependencyProperty StylisticSet2Property;
+        public static readonly DependencyProperty StylisticSet3Property;
+        public static readonly DependencyProperty StylisticSet4Property;
+        public static readonly DependencyProperty StylisticSet5Property;
+        public static readonly DependencyProperty StylisticSet6Property;
+        public static readonly DependencyProperty StylisticSet7Property;
+        public static readonly DependencyProperty StylisticSet8Property;
+        public static readonly DependencyProperty StylisticSet9Property;
+        public static readonly DependencyProperty VariantsProperty;
+        public int AnnotationAlternates { get; set; }
+        public FontCapitals Capitals { get; set; }
+        public bool CapitalSpacing { get; set; }
+        public bool CaseSensitiveForms { get; set; }
+        public bool ContextualAlternates { get; set; }
+        public bool ContextualLigatures { get; set; }
+        public int ContextualSwashes { get; set; }
+        public bool DiscretionaryLigatures { get; set; }
+        public bool EastAsianExpertForms { get; set; }
+        public FontEastAsianLanguage EastAsianLanguage { get; set; }
+        public FontEastAsianWidths EastAsianWidths { get; set; }
+        public FontFraction Fraction { get; set; }
+        public bool HistoricalForms { get; set; }
+        public bool HistoricalLigatures { get; set; }
+        public bool Kerning { get; set; }
+        public bool MathematicalGreek { get; set; }
+        public FontNumeralAlignment NumeralAlignment { get; set; }
+        public FontNumeralStyle NumeralStyle { get; set; }
+        public bool SlashedZero { get; set; }
+        public bool StandardLigatures { get; set; }
+        public int StandardSwashes { get; set; }
+        public int StylisticAlternates { get; set; }
+        public bool StylisticSet1 { get; set; }
+        public bool StylisticSet10 { get; set; }
+        public bool StylisticSet11 { get; set; }
+        public bool StylisticSet12 { get; set; }
+        public bool StylisticSet13 { get; set; }
+        public bool StylisticSet14 { get; set; }
+        public bool StylisticSet15 { get; set; }
+        public bool StylisticSet16 { get; set; }
+        public bool StylisticSet17 { get; set; }
+        public bool StylisticSet18 { get; set; }
+        public bool StylisticSet19 { get; set; }
+        public bool StylisticSet2 { get; set; }
+        public bool StylisticSet20 { get; set; }
+        public bool StylisticSet3 { get; set; }
+        public bool StylisticSet4 { get; set; }
+        public bool StylisticSet5 { get; set; }
+        public bool StylisticSet6 { get; set; }
+        public bool StylisticSet7 { get; set; }
+        public bool StylisticSet8 { get; set; }
+        public bool StylisticSet9 { get; set; }
+        public FontVariants Variants { get; set; }
+        public static int GetAnnotationAlternates(DependencyObject element);
+        public static FontCapitals GetCapitals(DependencyObject element);
+        public static bool GetCapitalSpacing(DependencyObject element);
+        public static bool GetCaseSensitiveForms(DependencyObject element);
+        public static bool GetContextualAlternates(DependencyObject element);
+        public static bool GetContextualLigatures(DependencyObject element);
+        public static int GetContextualSwashes(DependencyObject element);
+        public static bool GetDiscretionaryLigatures(DependencyObject element);
+        public static bool GetEastAsianExpertForms(DependencyObject element);
+        public static FontEastAsianLanguage GetEastAsianLanguage(DependencyObject element);
+        public static FontEastAsianWidths GetEastAsianWidths(DependencyObject element);
+        public static FontFraction GetFraction(DependencyObject element);
+        public static bool GetHistoricalForms(DependencyObject element);
+        public static bool GetHistoricalLigatures(DependencyObject element);
+        public static bool GetKerning(DependencyObject element);
+        public static bool GetMathematicalGreek(DependencyObject element);
+        public static FontNumeralAlignment GetNumeralAlignment(DependencyObject element);
+        public static FontNumeralStyle GetNumeralStyle(DependencyObject element);
+        public static bool GetSlashedZero(DependencyObject element);
+        public static bool GetStandardLigatures(DependencyObject element);
+        public static int GetStandardSwashes(DependencyObject element);
+        public static int GetStylisticAlternates(DependencyObject element);
+        public static bool GetStylisticSet1(DependencyObject element);
+        public static bool GetStylisticSet10(DependencyObject element);
+        public static bool GetStylisticSet11(DependencyObject element);
+        public static bool GetStylisticSet12(DependencyObject element);
+        public static bool GetStylisticSet13(DependencyObject element);
+        public static bool GetStylisticSet14(DependencyObject element);
+        public static bool GetStylisticSet15(DependencyObject element);
+        public static bool GetStylisticSet16(DependencyObject element);
+        public static bool GetStylisticSet17(DependencyObject element);
+        public static bool GetStylisticSet18(DependencyObject element);
+        public static bool GetStylisticSet19(DependencyObject element);
+        public static bool GetStylisticSet2(DependencyObject element);
+        public static bool GetStylisticSet20(DependencyObject element);
+        public static bool GetStylisticSet3(DependencyObject element);
+        public static bool GetStylisticSet4(DependencyObject element);
+        public static bool GetStylisticSet5(DependencyObject element);
+        public static bool GetStylisticSet6(DependencyObject element);
+        public static bool GetStylisticSet7(DependencyObject element);
+        public static bool GetStylisticSet8(DependencyObject element);
+        public static bool GetStylisticSet9(DependencyObject element);
+        public static FontVariants GetVariants(DependencyObject element);
+        public static void SetAnnotationAlternates(DependencyObject element, int value);
+        public static void SetCapitals(DependencyObject element, FontCapitals value);
+        public static void SetCapitalSpacing(DependencyObject element, bool value);
+        public static void SetCaseSensitiveForms(DependencyObject element, bool value);
+        public static void SetContextualAlternates(DependencyObject element, bool value);
+        public static void SetContextualLigatures(DependencyObject element, bool value);
+        public static void SetContextualSwashes(DependencyObject element, int value);
+        public static void SetDiscretionaryLigatures(DependencyObject element, bool value);
+        public static void SetEastAsianExpertForms(DependencyObject element, bool value);
+        public static void SetEastAsianLanguage(DependencyObject element, FontEastAsianLanguage value);
+        public static void SetEastAsianWidths(DependencyObject element, FontEastAsianWidths value);
+        public static void SetFraction(DependencyObject element, FontFraction value);
+        public static void SetHistoricalForms(DependencyObject element, bool value);
+        public static void SetHistoricalLigatures(DependencyObject element, bool value);
+        public static void SetKerning(DependencyObject element, bool value);
+        public static void SetMathematicalGreek(DependencyObject element, bool value);
+        public static void SetNumeralAlignment(DependencyObject element, FontNumeralAlignment value);
+        public static void SetNumeralStyle(DependencyObject element, FontNumeralStyle value);
+        public static void SetSlashedZero(DependencyObject element, bool value);
+        public static void SetStandardLigatures(DependencyObject element, bool value);
+        public static void SetStandardSwashes(DependencyObject element, int value);
+        public static void SetStylisticAlternates(DependencyObject element, int value);
+        public static void SetStylisticSet1(DependencyObject element, bool value);
+        public static void SetStylisticSet10(DependencyObject element, bool value);
+        public static void SetStylisticSet11(DependencyObject element, bool value);
+        public static void SetStylisticSet12(DependencyObject element, bool value);
+        public static void SetStylisticSet13(DependencyObject element, bool value);
+        public static void SetStylisticSet14(DependencyObject element, bool value);
+        public static void SetStylisticSet15(DependencyObject element, bool value);
+        public static void SetStylisticSet16(DependencyObject element, bool value);
+        public static void SetStylisticSet17(DependencyObject element, bool value);
+        public static void SetStylisticSet18(DependencyObject element, bool value);
+        public static void SetStylisticSet19(DependencyObject element, bool value);
+        public static void SetStylisticSet2(DependencyObject element, bool value);
+        public static void SetStylisticSet20(DependencyObject element, bool value);
+        public static void SetStylisticSet3(DependencyObject element, bool value);
+        public static void SetStylisticSet4(DependencyObject element, bool value);
+        public static void SetStylisticSet5(DependencyObject element, bool value);
+        public static void SetStylisticSet6(DependencyObject element, bool value);
+        public static void SetStylisticSet7(DependencyObject element, bool value);
+        public static void SetStylisticSet8(DependencyObject element, bool value);
+        public static void SetStylisticSet9(DependencyObject element, bool value);
+        public static void SetVariants(DependencyObject element, FontVariants value);
+    }
+    public class Underline : Span {
+        public Underline();
+        public Underline(Inline childInline);
+        public Underline(Inline childInline, TextPointer insertionPosition);
+        public Underline(TextPointer start, TextPointer end);
+    }
+    public sealed class ZoomPercentageConverter : IValueConverter {
+        public ZoomPercentageConverter();
+        public object Convert(object value, Type targetType, object parameter, CultureInfo culture);
+        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);
+    }
+}
```

