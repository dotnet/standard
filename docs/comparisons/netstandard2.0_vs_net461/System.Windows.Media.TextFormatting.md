# System.Windows.Media.TextFormatting

``` diff
+namespace System.Windows.Media.TextFormatting {
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct CharacterBufferRange : IEquatable<CharacterBufferRange> {
+        public unsafe CharacterBufferRange(char* unsafeCharacterString, int characterLength);
+        public CharacterBufferRange(char[] characterArray, int offsetToFirstChar, int characterLength);
+        public CharacterBufferRange(string characterString, int offsetToFirstChar, int characterLength);
+        public CharacterBufferReference CharacterBufferReference { get; }
+        public static CharacterBufferRange Empty { get; }
+        public int Length { get; }
+        public override bool Equals(object obj);
+        public bool Equals(CharacterBufferRange value);
+        public override int GetHashCode();
+        public static bool operator ==(CharacterBufferRange left, CharacterBufferRange right);
+        public static bool operator !=(CharacterBufferRange left, CharacterBufferRange right);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct CharacterBufferReference : IEquatable<CharacterBufferReference> {
+        public unsafe CharacterBufferReference(char* unsafeCharacterString, int characterLength);
+        public CharacterBufferReference(char[] characterArray, int offsetToFirstChar);
+        public CharacterBufferReference(string characterString, int offsetToFirstChar);
+        public override bool Equals(object obj);
+        public bool Equals(CharacterBufferReference value);
+        public override int GetHashCode();
+        public static bool operator ==(CharacterBufferReference left, CharacterBufferReference right);
+        public static bool operator !=(CharacterBufferReference left, CharacterBufferReference right);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct CharacterHit : IEquatable<CharacterHit> {
+        public CharacterHit(int firstCharacterIndex, int trailingLength);
+        public int FirstCharacterIndex { get; }
+        public int TrailingLength { get; }
+        public override bool Equals(object obj);
+        public bool Equals(CharacterHit obj);
+        public override int GetHashCode();
+        public static bool operator ==(CharacterHit left, CharacterHit right);
+        public static bool operator !=(CharacterHit left, CharacterHit right);
+    }
+    public class CultureSpecificCharacterBufferRange {
+        public CultureSpecificCharacterBufferRange(CultureInfo culture, CharacterBufferRange characterBufferRange);
+        public CharacterBufferRange CharacterBufferRange { get; }
+        public CultureInfo CultureInfo { get; }
+    }
+    public sealed class IndexedGlyphRun {
+        public GlyphRun GlyphRun { get; }
+        public int TextSourceCharacterIndex { get; }
+        public int TextSourceLength { get; }
+    }
+    public enum InvertAxes {
+        Both = 3,
+        Horizontal = 1,
+        None = 0,
+        Vertical = 2,
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct MinMaxParagraphWidth : IEquatable<MinMaxParagraphWidth> {
+        public double MaxWidth { get; }
+        public double MinWidth { get; }
+        public override bool Equals(object obj);
+        public bool Equals(MinMaxParagraphWidth value);
+        public override int GetHashCode();
+        public static bool operator ==(MinMaxParagraphWidth left, MinMaxParagraphWidth right);
+        public static bool operator !=(MinMaxParagraphWidth left, MinMaxParagraphWidth right);
+    }
+    public sealed class TextBounds {
+        public FlowDirection FlowDirection { get; }
+        public Rect Rectangle { get; }
+        public IList<TextRunBounds> TextRunBounds { get; }
+    }
+    public class TextCharacters : TextRun, IShapeableTextCollector, ITextSymbols {
+        public unsafe TextCharacters(char* unsafeCharacterString, int length, TextRunProperties textRunProperties);
+        public TextCharacters(char[] characterArray, int offsetToFirstChar, int length, TextRunProperties textRunProperties);
+        public TextCharacters(string characterString, int offsetToFirstChar, int length, TextRunProperties textRunProperties);
+        public TextCharacters(string characterString, TextRunProperties textRunProperties);
+        public sealed override CharacterBufferReference CharacterBufferReference { get; }
+        public sealed override int Length { get; }
+        public sealed override TextRunProperties Properties { get; }
+    }
+    public sealed class TextCollapsedRange {
+        public int Length { get; }
+        public int TextSourceCharacterIndex { get; }
+        public double Width { get; }
+    }
+    public abstract class TextCollapsingProperties {
+        protected TextCollapsingProperties();
+        public abstract TextCollapsingStyle Style { get; }
+        public abstract TextRun Symbol { get; }
+        public abstract double Width { get; }
+    }
+    public enum TextCollapsingStyle {
+        TrailingCharacter = 0,
+        TrailingWord = 1,
+    }
+    public abstract class TextEmbeddedObject : TextRun {
+        protected TextEmbeddedObject();
+        public abstract LineBreakCondition BreakAfter { get; }
+        public abstract LineBreakCondition BreakBefore { get; }
+        public abstract bool HasFixedSize { get; }
+        public abstract Rect ComputeBoundingBox(bool rightToLeft, bool sideways);
+        public abstract void Draw(DrawingContext drawingContext, Point origin, bool rightToLeft, bool sideways);
+        public abstract TextEmbeddedObjectMetrics Format(double remainingParagraphWidth);
+    }
+    public class TextEmbeddedObjectMetrics {
+        public TextEmbeddedObjectMetrics(double width, double height, double baseline);
+        public double Baseline { get; }
+        public double Height { get; }
+        public double Width { get; }
+    }
+    public class TextEndOfLine : TextRun {
+        public TextEndOfLine(int length);
+        public TextEndOfLine(int length, TextRunProperties textRunProperties);
+        public sealed override CharacterBufferReference CharacterBufferReference { get; }
+        public sealed override int Length { get; }
+        public sealed override TextRunProperties Properties { get; }
+    }
+    public class TextEndOfParagraph : TextEndOfLine {
+        public TextEndOfParagraph(int length);
+        public TextEndOfParagraph(int length, TextRunProperties textRunProperties);
+    }
+    public class TextEndOfSegment : TextRun {
+        public TextEndOfSegment(int length);
+        public sealed override CharacterBufferReference CharacterBufferReference { get; }
+        public sealed override int Length { get; }
+        public sealed override TextRunProperties Properties { get; }
+    }
+    public abstract class TextFormatter : IDisposable {
+        protected TextFormatter();
+        public static TextFormatter Create();
+        public static TextFormatter Create(TextFormattingMode textFormattingMode);
+        public virtual void Dispose();
+        public abstract TextLine FormatLine(TextSource textSource, int firstCharIndex, double paragraphWidth, TextParagraphProperties paragraphProperties, TextLineBreak previousLineBreak);
+        public abstract TextLine FormatLine(TextSource textSource, int firstCharIndex, double paragraphWidth, TextParagraphProperties paragraphProperties, TextLineBreak previousLineBreak, TextRunCache textRunCache);
+        public abstract MinMaxParagraphWidth FormatMinMaxParagraphWidth(TextSource textSource, int firstCharIndex, TextParagraphProperties paragraphProperties);
+        public abstract MinMaxParagraphWidth FormatMinMaxParagraphWidth(TextSource textSource, int firstCharIndex, TextParagraphProperties paragraphProperties, TextRunCache textRunCache);
+    }
+    public class TextHidden : TextRun {
+        public TextHidden(int length);
+        public sealed override CharacterBufferReference CharacterBufferReference { get; }
+        public sealed override int Length { get; }
+        public sealed override TextRunProperties Properties { get; }
+    }
+    public abstract class TextLine : IDisposable, ITextMetrics {
+        protected TextLine();
+        public abstract double Baseline { get; }
+        public abstract int DependentLength { get; }
+        public abstract double Extent { get; }
+        public abstract bool HasCollapsed { get; }
+        public abstract bool HasOverflowed { get; }
+        public abstract double Height { get; }
+        public virtual bool IsTruncated { get; }
+        public abstract int Length { get; }
+        public abstract double MarkerBaseline { get; }
+        public abstract double MarkerHeight { get; }
+        public abstract int NewlineLength { get; }
+        public abstract double OverhangAfter { get; }
+        public abstract double OverhangLeading { get; }
+        public abstract double OverhangTrailing { get; }
+        public abstract double Start { get; }
+        public abstract double TextBaseline { get; }
+        public abstract double TextHeight { get; }
+        public abstract int TrailingWhitespaceLength { get; }
+        public abstract double Width { get; }
+        public abstract double WidthIncludingTrailingWhitespace { get; }
+        public abstract TextLine Collapse(params TextCollapsingProperties[] collapsingPropertiesList);
+        public abstract void Dispose();
+        public abstract void Draw(DrawingContext drawingContext, Point origin, InvertAxes inversion);
+        public abstract CharacterHit GetBackspaceCaretCharacterHit(CharacterHit characterHit);
+        public abstract CharacterHit GetCharacterHitFromDistance(double distance);
+        public abstract double GetDistanceFromCharacterHit(CharacterHit characterHit);
+        public abstract IEnumerable<IndexedGlyphRun> GetIndexedGlyphRuns();
+        public abstract CharacterHit GetNextCaretCharacterHit(CharacterHit characterHit);
+        public abstract CharacterHit GetPreviousCaretCharacterHit(CharacterHit characterHit);
+        public abstract IList<TextBounds> GetTextBounds(int firstTextSourceCharacterIndex, int textLength);
+        public abstract IList<TextCollapsedRange> GetTextCollapsedRanges();
+        public abstract TextLineBreak GetTextLineBreak();
+        public abstract IList<TextSpan<TextRun>> GetTextRunSpans();
+    }
+    public sealed class TextLineBreak : IDisposable {
+        public TextLineBreak Clone();
+        public void Dispose();
+        ~TextLineBreak();
+    }
+    public abstract class TextMarkerProperties {
+        protected TextMarkerProperties();
+        public abstract double Offset { get; }
+        public abstract TextSource TextSource { get; }
+    }
+    public abstract class TextModifier : TextRun {
+        protected TextModifier();
+        public sealed override CharacterBufferReference CharacterBufferReference { get; }
+        public abstract FlowDirection FlowDirection { get; }
+        public abstract bool HasDirectionalEmbedding { get; }
+        public abstract TextRunProperties ModifyProperties(TextRunProperties properties);
+    }
+    public abstract class TextParagraphProperties {
+        protected TextParagraphProperties();
+        public virtual bool AlwaysCollapsible { get; }
+        public virtual double DefaultIncrementalTab { get; }
+        public abstract TextRunProperties DefaultTextRunProperties { get; }
+        public abstract bool FirstLineInParagraph { get; }
+        public abstract FlowDirection FlowDirection { get; }
+        public abstract double Indent { get; }
+        public abstract double LineHeight { get; }
+        public virtual double ParagraphIndent { get; }
+        public virtual IList<TextTabProperties> Tabs { get; }
+        public abstract TextAlignment TextAlignment { get; }
+        public virtual TextDecorationCollection TextDecorations { get; }
+        public abstract TextMarkerProperties TextMarkerProperties { get; }
+        public abstract TextWrapping TextWrapping { get; }
+    }
+    public abstract class TextRun {
+        protected TextRun();
+        public abstract CharacterBufferReference CharacterBufferReference { get; }
+        public abstract int Length { get; }
+        public abstract TextRunProperties Properties { get; }
+    }
+    public sealed class TextRunBounds {
+        public int Length { get; }
+        public Rect Rectangle { get; }
+        public TextRun TextRun { get; }
+        public int TextSourceCharacterIndex { get; }
+    }
+    public sealed class TextRunCache {
+        public TextRunCache();
+        public void Change(int textSourceCharacterIndex, int addition, int removal);
+        public void Invalidate();
+    }
+    public abstract class TextRunProperties {
+        protected TextRunProperties();
+        public abstract Brush BackgroundBrush { get; }
+        public virtual BaselineAlignment BaselineAlignment { get; }
+        public abstract CultureInfo CultureInfo { get; }
+        public abstract double FontHintingEmSize { get; }
+        public abstract double FontRenderingEmSize { get; }
+        public abstract Brush ForegroundBrush { get; }
+        public virtual NumberSubstitution NumberSubstitution { get; }
+        public abstract TextDecorationCollection TextDecorations { get; }
+        public abstract TextEffectCollection TextEffects { get; }
+        public abstract Typeface Typeface { get; }
+        public virtual TextRunTypographyProperties TypographyProperties { get; }
+    }
+    public abstract class TextRunTypographyProperties {
+        protected TextRunTypographyProperties();
+        public abstract int AnnotationAlternates { get; }
+        public abstract FontCapitals Capitals { get; }
+        public abstract bool CapitalSpacing { get; }
+        public abstract bool CaseSensitiveForms { get; }
+        public abstract bool ContextualAlternates { get; }
+        public abstract bool ContextualLigatures { get; }
+        public abstract int ContextualSwashes { get; }
+        public abstract bool DiscretionaryLigatures { get; }
+        public abstract bool EastAsianExpertForms { get; }
+        public abstract FontEastAsianLanguage EastAsianLanguage { get; }
+        public abstract FontEastAsianWidths EastAsianWidths { get; }
+        public abstract FontFraction Fraction { get; }
+        public abstract bool HistoricalForms { get; }
+        public abstract bool HistoricalLigatures { get; }
+        public abstract bool Kerning { get; }
+        public abstract bool MathematicalGreek { get; }
+        public abstract FontNumeralAlignment NumeralAlignment { get; }
+        public abstract FontNumeralStyle NumeralStyle { get; }
+        public abstract bool SlashedZero { get; }
+        public abstract bool StandardLigatures { get; }
+        public abstract int StandardSwashes { get; }
+        public abstract int StylisticAlternates { get; }
+        public abstract bool StylisticSet1 { get; }
+        public abstract bool StylisticSet10 { get; }
+        public abstract bool StylisticSet11 { get; }
+        public abstract bool StylisticSet12 { get; }
+        public abstract bool StylisticSet13 { get; }
+        public abstract bool StylisticSet14 { get; }
+        public abstract bool StylisticSet15 { get; }
+        public abstract bool StylisticSet16 { get; }
+        public abstract bool StylisticSet17 { get; }
+        public abstract bool StylisticSet18 { get; }
+        public abstract bool StylisticSet19 { get; }
+        public abstract bool StylisticSet2 { get; }
+        public abstract bool StylisticSet20 { get; }
+        public abstract bool StylisticSet3 { get; }
+        public abstract bool StylisticSet4 { get; }
+        public abstract bool StylisticSet5 { get; }
+        public abstract bool StylisticSet6 { get; }
+        public abstract bool StylisticSet7 { get; }
+        public abstract bool StylisticSet8 { get; }
+        public abstract bool StylisticSet9 { get; }
+        public abstract FontVariants Variants { get; }
+        protected void OnPropertiesChanged();
+    }
+    public class TextSimpleMarkerProperties : TextMarkerProperties {
+        public TextSimpleMarkerProperties(TextMarkerStyle style, double offset, int autoNumberingIndex, TextParagraphProperties textParagraphProperties);
+        public sealed override double Offset { get; }
+        public sealed override TextSource TextSource { get; }
+    }
+    public abstract class TextSource {
+        protected TextSource();
+        public abstract TextSpan<CultureSpecificCharacterBufferRange> GetPrecedingText(int textSourceCharacterIndexLimit);
+        public abstract int GetTextEffectCharacterIndexFromTextSourceCharacterIndex(int textSourceCharacterIndex);
+        public abstract TextRun GetTextRun(int textSourceCharacterIndex);
+    }
+    public class TextSpan<T> {
+        public TextSpan(int length, T value);
+        public int Length { get; }
+        public T Value { get; }
+    }
+    public enum TextTabAlignment {
+        Center = 1,
+        Character = 3,
+        Left = 0,
+        Right = 2,
+    }
+    public class TextTabProperties {
+        public TextTabProperties(TextTabAlignment alignment, double location, int tabLeader, int aligningChar);
+        public int AligningCharacter { get; }
+        public TextTabAlignment Alignment { get; }
+        public double Location { get; }
+        public int TabLeader { get; }
+    }
+    public class TextTrailingCharacterEllipsis : TextCollapsingProperties {
+        public TextTrailingCharacterEllipsis(double width, TextRunProperties textRunProperties);
+        public sealed override TextCollapsingStyle Style { get; }
+        public sealed override TextRun Symbol { get; }
+        public sealed override double Width { get; }
+    }
+    public class TextTrailingWordEllipsis : TextCollapsingProperties {
+        public TextTrailingWordEllipsis(double width, TextRunProperties textRunProperties);
+        public sealed override TextCollapsingStyle Style { get; }
+        public sealed override TextRun Symbol { get; }
+        public sealed override double Width { get; }
+    }
+}
```

