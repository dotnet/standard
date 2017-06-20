# System.Windows.Automation.Text

``` diff
+namespace System.Windows.Automation.Text {
+    public enum AnimationStyle {
+        BlinkingBackground = 2,
+        LasVegasLights = 1,
+        MarchingBlackAnts = 4,
+        MarchingRedAnts = 5,
+        None = 0,
+        Other = -1,
+        Shimmer = 6,
+        SparkleText = 3,
+    }
+    public enum BulletStyle {
+        DashBullet = 5,
+        FilledRoundBullet = 2,
+        FilledSquareBullet = 4,
+        HollowRoundBullet = 1,
+        HollowSquareBullet = 3,
+        None = 0,
+        Other = -1,
+    }
+    public enum CapStyle {
+        AllCap = 2,
+        AllPetiteCaps = 3,
+        None = 0,
+        Other = -1,
+        PetiteCaps = 4,
+        SmallCap = 1,
+        Titling = 6,
+        Unicase = 5,
+    }
+    public enum FlowDirections {
+        BottomToTop = 2,
+        Default = 0,
+        RightToLeft = 1,
+        Vertical = 4,
+    }
+    public enum HorizontalTextAlignment {
+        Centered = 1,
+        Justified = 3,
+        Left = 0,
+        Right = 2,
+    }
+    public enum OutlineStyles {
+        Embossed = 8,
+        Engraved = 4,
+        None = 0,
+        Outline = 1,
+        Shadow = 2,
+    }
+    public enum TextDecorationLineStyle {
+        Dash = 5,
+        DashDot = 6,
+        DashDotDot = 7,
+        Dot = 4,
+        Double = 3,
+        DoubleWavy = 11,
+        LongDash = 13,
+        None = 0,
+        Other = -1,
+        Single = 1,
+        ThickDash = 14,
+        ThickDashDot = 15,
+        ThickDashDotDot = 16,
+        ThickDot = 17,
+        ThickLongDash = 18,
+        ThickSingle = 9,
+        ThickWavy = 12,
+        Wavy = 8,
+        WordsOnly = 2,
+    }
+    public class TextPatternRange {
+        public TextPattern TextPattern { get; }
+        public void AddToSelection();
+        public TextPatternRange Clone();
+        public bool Compare(TextPatternRange range);
+        public int CompareEndpoints(TextPatternRangeEndpoint endpoint, TextPatternRange targetRange, TextPatternRangeEndpoint targetEndpoint);
+        public void ExpandToEnclosingUnit(TextUnit unit);
+        public TextPatternRange FindAttribute(AutomationTextAttribute attribute, object value, bool backward);
+        public TextPatternRange FindText(string text, bool backward, bool ignoreCase);
+        public object GetAttributeValue(AutomationTextAttribute attribute);
+        public Rect[] GetBoundingRectangles();
+        public AutomationElement[] GetChildren();
+        public AutomationElement GetEnclosingElement();
+        public string GetText(int maxLength);
+        public int Move(TextUnit unit, int count);
+        public void MoveEndpointByRange(TextPatternRangeEndpoint endpoint, TextPatternRange targetRange, TextPatternRangeEndpoint targetEndpoint);
+        public int MoveEndpointByUnit(TextPatternRangeEndpoint endpoint, TextUnit unit, int count);
+        public void RemoveFromSelection();
+        public void ScrollIntoView(bool alignToTop);
+        public void Select();
+    }
+    public enum TextPatternRangeEndpoint {
+        End = 1,
+        Start = 0,
+    }
+    public enum TextUnit {
+        Character = 0,
+        Document = 6,
+        Format = 1,
+        Line = 3,
+        Page = 5,
+        Paragraph = 4,
+        Word = 2,
+    }
+}
```

