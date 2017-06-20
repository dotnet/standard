# System.Windows.Forms.VisualStyles

``` diff
+namespace System.Windows.Forms.VisualStyles {
+    public enum BackgroundType {
+        BorderFill = 1,
+        ImageFile = 0,
+        None = 2,
+    }
+    public enum BooleanProperty {
+        AlwaysShowSizingBar = 2208,
+        AutoSize = 2202,
+        BackgroundFill = 2205,
+        BorderOnly = 2203,
+        Composited = 2204,
+        GlyphOnly = 2207,
+        GlyphTransparent = 2206,
+        IntegralSizing = 2211,
+        MirrorImage = 2209,
+        SourceGrow = 2212,
+        SourceShrink = 2213,
+        Transparent = 2201,
+        UniformSizing = 2210,
+    }
+    public enum BorderType {
+        Ellipse = 2,
+        Rectangle = 0,
+        RoundedRectangle = 1,
+    }
+    public enum CheckBoxState {
+        CheckedDisabled = 8,
+        CheckedHot = 6,
+        CheckedNormal = 5,
+        CheckedPressed = 7,
+        MixedDisabled = 12,
+        MixedHot = 10,
+        MixedNormal = 9,
+        MixedPressed = 11,
+        UncheckedDisabled = 4,
+        UncheckedHot = 2,
+        UncheckedNormal = 1,
+        UncheckedPressed = 3,
+    }
+    public enum ColorProperty {
+        AccentColorHint = 3823,
+        BorderColor = 3801,
+        BorderColorHint = 3822,
+        EdgeDarkShadowColor = 3807,
+        EdgeFillColor = 3808,
+        EdgeHighlightColor = 3805,
+        EdgeLightColor = 3804,
+        EdgeShadowColor = 3806,
+        FillColor = 3802,
+        FillColorHint = 3821,
+        GlowColor = 3816,
+        GlyphTextColor = 3819,
+        GlyphTransparentColor = 3820,
+        GradientColor1 = 3810,
+        GradientColor2 = 3811,
+        GradientColor3 = 3812,
+        GradientColor4 = 3813,
+        GradientColor5 = 3814,
+        ShadowColor = 3815,
+        TextBorderColor = 3817,
+        TextColor = 3803,
+        TextShadowColor = 3818,
+        TransparentColor = 3809,
+    }
+    public enum ComboBoxState {
+        Disabled = 4,
+        Hot = 2,
+        Normal = 1,
+        Pressed = 3,
+    }
+    public enum ContentAlignment {
+        Center = 1,
+        Left = 0,
+        Right = 2,
+    }
+    public enum EdgeEffects {
+        FillInterior = 2048,
+        Flat = 4096,
+        Mono = 32768,
+        None = 0,
+        Soft = 16384,
+    }
+    public enum Edges {
+        Bottom = 8,
+        Diagonal = 16,
+        Left = 1,
+        Right = 4,
+        Top = 2,
+    }
+    public enum EdgeStyle {
+        Bump = 9,
+        Etched = 6,
+        Raised = 5,
+        Sunken = 10,
+    }
+    public enum EnumProperty {
+        BackgroundType = 4001,
+        BorderType = 4002,
+        ContentAlignment = 4006,
+        FillType = 4003,
+        GlyphFontSizingType = 4014,
+        GlyphType = 4012,
+        HorizontalAlignment = 4005,
+        IconEffect = 4009,
+        ImageLayout = 4011,
+        ImageSelectType = 4013,
+        OffsetType = 4008,
+        SizingType = 4004,
+        TextShadowType = 4010,
+        TrueSizeScalingType = 4015,
+        VerticalAlignment = 4007,
+    }
+    public enum FilenameProperty {
+        GlyphImageFile = 3008,
+        ImageFile = 3001,
+        ImageFile1 = 3002,
+        ImageFile2 = 3003,
+        ImageFile3 = 3004,
+        ImageFile4 = 3005,
+        ImageFile5 = 3006,
+        StockImageFile = 3007,
+    }
+    public enum FillType {
+        HorizontalGradient = 2,
+        RadialGradient = 3,
+        Solid = 0,
+        TileImage = 4,
+        VerticalGradient = 1,
+    }
+    public enum FontProperty {
+        GlyphFont = 2601,
+    }
+    public enum GlyphFontSizingType {
+        Dpi = 2,
+        None = 0,
+        Size = 1,
+    }
+    public enum GlyphType {
+        FontGlyph = 2,
+        ImageGlyph = 1,
+        None = 0,
+    }
+    public enum GroupBoxState {
+        Disabled = 2,
+        Normal = 1,
+    }
+    public enum HitTestCode {
+        Bottom = 15,
+        BottomLeft = 16,
+        BottomRight = 17,
+        Client = 1,
+        Left = 10,
+        Nowhere = 0,
+        Right = 11,
+        Top = 12,
+        TopLeft = 13,
+        TopRight = 14,
+    }
+    public enum HitTestOptions {
+        BackgroundSegment = 0,
+        Caption = 4,
+        FixedBorder = 2,
+        ResizingBorder = 240,
+        ResizingBorderBottom = 128,
+        ResizingBorderLeft = 16,
+        ResizingBorderRight = 64,
+        ResizingBorderTop = 32,
+        SizingTemplate = 256,
+        SystemSizingMargins = 512,
+    }
+    public enum HorizontalAlign {
+        Center = 1,
+        Left = 0,
+        Right = 2,
+    }
+    public enum IconEffect {
+        Alpha = 4,
+        Glow = 1,
+        None = 0,
+        Pulse = 3,
+        Shadow = 2,
+    }
+    public enum ImageOrientation {
+        Horizontal = 1,
+        Vertical = 0,
+    }
+    public enum ImageSelectType {
+        Dpi = 2,
+        None = 0,
+        Size = 1,
+    }
+    public enum IntegerProperty {
+        AlphaLevel = 2402,
+        AlphaThreshold = 2415,
+        BorderSize = 2403,
+        GlyphIndex = 2418,
+        GradientRatio1 = 2406,
+        GradientRatio2 = 2407,
+        GradientRatio3 = 2408,
+        GradientRatio4 = 2409,
+        GradientRatio5 = 2410,
+        Height = 2417,
+        ImageCount = 2401,
+        MinDpi1 = 2420,
+        MinDpi2 = 2421,
+        MinDpi3 = 2422,
+        MinDpi4 = 2423,
+        MinDpi5 = 2424,
+        ProgressChunkSize = 2411,
+        ProgressSpaceSize = 2412,
+        RoundCornerHeight = 2405,
+        RoundCornerWidth = 2404,
+        Saturation = 2413,
+        TextBorderSize = 2414,
+        TrueSizeStretchMark = 2419,
+        Width = 2416,
+    }
+    public enum MarginProperty {
+        CaptionMargins = 3603,
+        ContentMargins = 3602,
+        SizingMargins = 3601,
+    }
+    public enum OffsetType {
+        AboveLastButton = 12,
+        BelowLastButton = 13,
+        BottomLeft = 3,
+        BottomMiddle = 5,
+        BottomRight = 4,
+        LeftOfCaption = 8,
+        LeftOfLastButton = 10,
+        MiddleLeft = 6,
+        MiddleRight = 7,
+        RightOfCaption = 9,
+        RightOfLastButton = 11,
+        TopLeft = 0,
+        TopMiddle = 2,
+        TopRight = 1,
+    }
+    public enum PointProperty {
+        MinSize = 3403,
+        MinSize1 = 3404,
+        MinSize2 = 3405,
+        MinSize3 = 3406,
+        MinSize4 = 3407,
+        MinSize5 = 3408,
+        Offset = 3401,
+        TextShadowOffset = 3402,
+    }
+    public enum PushButtonState {
+        Default = 5,
+        Disabled = 4,
+        Hot = 2,
+        Normal = 1,
+        Pressed = 3,
+    }
+    public enum RadioButtonState {
+        CheckedDisabled = 8,
+        CheckedHot = 6,
+        CheckedNormal = 5,
+        CheckedPressed = 7,
+        UncheckedDisabled = 4,
+        UncheckedHot = 2,
+        UncheckedNormal = 1,
+        UncheckedPressed = 3,
+    }
+    public enum ScrollBarArrowButtonState {
+        DownDisabled = 8,
+        DownHot = 6,
+        DownNormal = 5,
+        DownPressed = 7,
+        LeftDisabled = 12,
+        LeftHot = 10,
+        LeftNormal = 9,
+        LeftPressed = 11,
+        RightDisabled = 16,
+        RightHot = 14,
+        RightNormal = 13,
+        RightPressed = 15,
+        UpDisabled = 4,
+        UpHot = 2,
+        UpNormal = 1,
+        UpPressed = 3,
+    }
+    public enum ScrollBarSizeBoxState {
+        LeftAlign = 2,
+        RightAlign = 1,
+    }
+    public enum ScrollBarState {
+        Disabled = 4,
+        Hot = 2,
+        Normal = 1,
+        Pressed = 3,
+    }
+    public enum SizingType {
+        FixedSize = 0,
+        Stretch = 1,
+        Tile = 2,
+    }
+    public enum StringProperty {
+        Text = 3201,
+    }
+    public enum TabItemState {
+        Disabled = 4,
+        Hot = 2,
+        Normal = 1,
+        Selected = 3,
+    }
+    public enum TextBoxState {
+        Assist = 7,
+        Disabled = 4,
+        Hot = 2,
+        Normal = 1,
+        Readonly = 6,
+        Selected = 3,
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct TextMetrics {
+        public int Ascent { get; set; }
+        public int AverageCharWidth { get; set; }
+        public char BreakChar { get; set; }
+        public TextMetricsCharacterSet CharSet { get; set; }
+        public char DefaultChar { get; set; }
+        public int Descent { get; set; }
+        public int DigitizedAspectX { get; set; }
+        public int DigitizedAspectY { get; set; }
+        public int ExternalLeading { get; set; }
+        public char FirstChar { get; set; }
+        public int Height { get; set; }
+        public int InternalLeading { get; set; }
+        public bool Italic { get; set; }
+        public char LastChar { get; set; }
+        public int MaxCharWidth { get; set; }
+        public int Overhang { get; set; }
+        public TextMetricsPitchAndFamilyValues PitchAndFamily { get; set; }
+        public bool StruckOut { get; set; }
+        public bool Underlined { get; set; }
+        public int Weight { get; set; }
+    }
+    public enum TextMetricsCharacterSet {
+        Ansi = 0,
+        Arabic = 178,
+        Baltic = 186,
+        ChineseBig5 = 136,
+        Default = 1,
+        EastEurope = 238,
+        Gb2312 = 134,
+        Greek = 161,
+        Hangul = 129,
+        Hebrew = 177,
+        Johab = 130,
+        Mac = 77,
+        Oem = 255,
+        Russian = 204,
+        ShiftJis = 128,
+        Symbol = 2,
+        Thai = 222,
+        Turkish = 162,
+        Vietnamese = 163,
+    }
+    public enum TextMetricsPitchAndFamilyValues {
+        Device = 8,
+        FixedPitch = 1,
+        TrueType = 4,
+        Vector = 2,
+    }
+    public enum TextShadowType {
+        Continuous = 2,
+        None = 0,
+        Single = 1,
+    }
+    public enum ThemeSizeType {
+        Draw = 2,
+        Minimum = 0,
+        True = 1,
+    }
+    public enum ToolBarState {
+        Checked = 5,
+        Disabled = 4,
+        Hot = 2,
+        HotChecked = 6,
+        Normal = 1,
+        Pressed = 3,
+    }
+    public enum TrackBarThumbState {
+        Disabled = 5,
+        Hot = 2,
+        Normal = 1,
+        Pressed = 3,
+    }
+    public enum TrueSizeScalingType {
+        Dpi = 2,
+        None = 0,
+        Size = 1,
+    }
+    public enum VerticalAlignment {
+        Bottom = 2,
+        Center = 1,
+        Top = 0,
+    }
+    public class VisualStyleElement {
+        public string ClassName { get; }
+        public int Part { get; }
+        public int State { get; }
+        public static VisualStyleElement CreateElement(string className, int part, int state);
+        public static class Button {
+            public static class CheckBox {
+                public static VisualStyleElement CheckedDisabled { get; }
+                public static VisualStyleElement CheckedHot { get; }
+                public static VisualStyleElement CheckedNormal { get; }
+                public static VisualStyleElement CheckedPressed { get; }
+                public static VisualStyleElement MixedDisabled { get; }
+                public static VisualStyleElement MixedHot { get; }
+                public static VisualStyleElement MixedNormal { get; }
+                public static VisualStyleElement MixedPressed { get; }
+                public static VisualStyleElement UncheckedDisabled { get; }
+                public static VisualStyleElement UncheckedHot { get; }
+                public static VisualStyleElement UncheckedNormal { get; }
+                public static VisualStyleElement UncheckedPressed { get; }
+            }
+            public static class GroupBox {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class PushButton {
+                public static VisualStyleElement Default { get; }
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class RadioButton {
+                public static VisualStyleElement CheckedDisabled { get; }
+                public static VisualStyleElement CheckedHot { get; }
+                public static VisualStyleElement CheckedNormal { get; }
+                public static VisualStyleElement CheckedPressed { get; }
+                public static VisualStyleElement UncheckedDisabled { get; }
+                public static VisualStyleElement UncheckedHot { get; }
+                public static VisualStyleElement UncheckedNormal { get; }
+                public static VisualStyleElement UncheckedPressed { get; }
+            }
+            public static class UserButton {
+                public static VisualStyleElement Normal { get; }
+            }
+        }
+        public static class ComboBox {
+            public static class DropDownButton {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+        }
+        public static class ExplorerBar {
+            public static class HeaderBackground {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class HeaderClose {
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class HeaderPin {
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+                public static VisualStyleElement SelectedHot { get; }
+                public static VisualStyleElement SelectedNormal { get; }
+                public static VisualStyleElement SelectedPressed { get; }
+            }
+            public static class IEBarMenu {
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class NormalGroupBackground {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class NormalGroupCollapse {
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class NormalGroupExpand {
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class NormalGroupHead {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class SpecialGroupBackground {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class SpecialGroupCollapse {
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class SpecialGroupExpand {
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class SpecialGroupHead {
+                public static VisualStyleElement Normal { get; }
+            }
+        }
+        public static class Header {
+            public static class Item {
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class ItemLeft {
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class ItemRight {
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class SortArrow {
+                public static VisualStyleElement SortedDown { get; }
+                public static VisualStyleElement SortedUp { get; }
+            }
+        }
+        public static class ListView {
+            public static class Detail {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class EmptyText {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class Group {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class Item {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Selected { get; }
+                public static VisualStyleElement SelectedNotFocus { get; }
+            }
+            public static class SortedDetail {
+                public static VisualStyleElement Normal { get; }
+            }
+        }
+        public static class Menu {
+            public static class BarDropDown {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class BarItem {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class Chevron {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class DropDown {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class Item {
+                public static VisualStyleElement Demoted { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Selected { get; }
+            }
+            public static class Separator {
+                public static VisualStyleElement Normal { get; }
+            }
+        }
+        public static class MenuBand {
+            public static class NewApplicationButton {
+                public static VisualStyleElement Checked { get; }
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement HotChecked { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class Separator {
+                public static VisualStyleElement Normal { get; }
+            }
+        }
+        public static class Page {
+            public static class Down {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class DownHorizontal {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class Up {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class UpHorizontal {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+        }
+        public static class ProgressBar {
+            public static class Bar {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class BarVertical {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class Chunk {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class ChunkVertical {
+                public static VisualStyleElement Normal { get; }
+            }
+        }
+        public static class Rebar {
+            public static class Band {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class Chevron {
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class ChevronVertical {
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class Gripper {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class GripperVertical {
+                public static VisualStyleElement Normal { get; }
+            }
+        }
+        public static class ScrollBar {
+            public static class ArrowButton {
+                public static VisualStyleElement DownDisabled { get; }
+                public static VisualStyleElement DownHot { get; }
+                public static VisualStyleElement DownNormal { get; }
+                public static VisualStyleElement DownPressed { get; }
+                public static VisualStyleElement LeftDisabled { get; }
+                public static VisualStyleElement LeftHot { get; }
+                public static VisualStyleElement LeftNormal { get; }
+                public static VisualStyleElement LeftPressed { get; }
+                public static VisualStyleElement RightDisabled { get; }
+                public static VisualStyleElement RightHot { get; }
+                public static VisualStyleElement RightNormal { get; }
+                public static VisualStyleElement RightPressed { get; }
+                public static VisualStyleElement UpDisabled { get; }
+                public static VisualStyleElement UpHot { get; }
+                public static VisualStyleElement UpNormal { get; }
+                public static VisualStyleElement UpPressed { get; }
+            }
+            public static class GripperHorizontal {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class GripperVertical {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class LeftTrackHorizontal {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class LowerTrackVertical {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class RightTrackHorizontal {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class SizeBox {
+                public static VisualStyleElement LeftAlign { get; }
+                public static VisualStyleElement RightAlign { get; }
+            }
+            public static class ThumbButtonHorizontal {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class ThumbButtonVertical {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class UpperTrackVertical {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+        }
+        public static class Spin {
+            public static class Down {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class DownHorizontal {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class Up {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class UpHorizontal {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+        }
+        public static class StartPanel {
+            public static class LogOff {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class LogOffButtons {
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class MorePrograms {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class MoreProgramsArrow {
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class PlaceList {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class PlaceListSeparator {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class Preview {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class ProgList {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class ProgListSeparator {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class UserPane {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class UserPicture {
+                public static VisualStyleElement Normal { get; }
+            }
+        }
+        public static class Status {
+            public static class Bar {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class Gripper {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class GripperPane {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class Pane {
+                public static VisualStyleElement Normal { get; }
+            }
+        }
+        public static class Tab {
+            public static class Body {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class Pane {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class TabItem {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class TabItemBothEdges {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class TabItemLeftEdge {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class TabItemRightEdge {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class TopTabItem {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class TopTabItemBothEdges {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class TopTabItemLeftEdge {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class TopTabItemRightEdge {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+        }
+        public static class TaskBand {
+            public static class FlashButton {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class FlashButtonGroupMenu {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class GroupCount {
+                public static VisualStyleElement Normal { get; }
+            }
+        }
+        public static class Taskbar {
+            public static class BackgroundBottom {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class BackgroundLeft {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class BackgroundRight {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class BackgroundTop {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class SizingBarBottom {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class SizingBarLeft {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class SizingBarRight {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class SizingBarTop {
+                public static VisualStyleElement Normal { get; }
+            }
+        }
+        public static class TaskbarClock {
+            public static class Time {
+                public static VisualStyleElement Normal { get; }
+            }
+        }
+        public static class TextBox {
+            public static class Caret {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class TextEdit {
+                public static VisualStyleElement Assist { get; }
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Focused { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement ReadOnly { get; }
+                public static VisualStyleElement Selected { get; }
+            }
+        }
+        public static class ToolBar {
+            public static class Button {
+                public static VisualStyleElement Checked { get; }
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement HotChecked { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class DropDownButton {
+                public static VisualStyleElement Checked { get; }
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement HotChecked { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class SeparatorHorizontal {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class SeparatorVertical {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class SplitButton {
+                public static VisualStyleElement Checked { get; }
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement HotChecked { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class SplitButtonDropDown {
+                public static VisualStyleElement Checked { get; }
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement HotChecked { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+        }
+        public static class ToolTip {
+            public static class Balloon {
+                public static VisualStyleElement Link { get; }
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class BalloonTitle {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class Close {
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class Standard {
+                public static VisualStyleElement Link { get; }
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class StandardTitle {
+                public static VisualStyleElement Normal { get; }
+            }
+        }
+        public static class TrackBar {
+            public static class Thumb {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Focused { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class ThumbBottom {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Focused { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class ThumbLeft {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Focused { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class ThumbRight {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Focused { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class ThumbTop {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Focused { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class ThumbVertical {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Focused { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class Ticks {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class TicksVertical {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class Track {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class TrackVertical {
+                public static VisualStyleElement Normal { get; }
+            }
+        }
+        public static class TrayNotify {
+            public static class AnimateBackground {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class Background {
+                public static VisualStyleElement Normal { get; }
+            }
+        }
+        public static class TreeView {
+            public static class Branch {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class Glyph {
+                public static VisualStyleElement Closed { get; }
+                public static VisualStyleElement Opened { get; }
+            }
+            public static class Item {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Selected { get; }
+                public static VisualStyleElement SelectedNotFocus { get; }
+            }
+        }
+        public static class Window {
+            public static class Caption {
+                public static VisualStyleElement Active { get; }
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Inactive { get; }
+            }
+            public static class CaptionSizingTemplate {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class CloseButton {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class Dialog {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class FrameBottom {
+                public static VisualStyleElement Active { get; }
+                public static VisualStyleElement Inactive { get; }
+            }
+            public static class FrameBottomSizingTemplate {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class FrameLeft {
+                public static VisualStyleElement Active { get; }
+                public static VisualStyleElement Inactive { get; }
+            }
+            public static class FrameLeftSizingTemplate {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class FrameRight {
+                public static VisualStyleElement Active { get; }
+                public static VisualStyleElement Inactive { get; }
+            }
+            public static class FrameRightSizingTemplate {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class HelpButton {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class HorizontalScroll {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class HorizontalThumb {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class MaxButton {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class MaxCaption {
+                public static VisualStyleElement Active { get; }
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Inactive { get; }
+            }
+            public static class MdiCloseButton {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class MdiHelpButton {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class MdiMinButton {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class MdiRestoreButton {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class MdiSysButton {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class MinButton {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class MinCaption {
+                public static VisualStyleElement Active { get; }
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Inactive { get; }
+            }
+            public static class RestoreButton {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class SmallCaption {
+                public static VisualStyleElement Active { get; }
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Inactive { get; }
+            }
+            public static class SmallCaptionSizingTemplate {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class SmallCloseButton {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class SmallFrameBottom {
+                public static VisualStyleElement Active { get; }
+                public static VisualStyleElement Inactive { get; }
+            }
+            public static class SmallFrameBottomSizingTemplate {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class SmallFrameLeft {
+                public static VisualStyleElement Active { get; }
+                public static VisualStyleElement Inactive { get; }
+            }
+            public static class SmallFrameLeftSizingTemplate {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class SmallFrameRight {
+                public static VisualStyleElement Active { get; }
+                public static VisualStyleElement Inactive { get; }
+            }
+            public static class SmallFrameRightSizingTemplate {
+                public static VisualStyleElement Normal { get; }
+            }
+            public static class SmallMaxCaption {
+                public static VisualStyleElement Active { get; }
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Inactive { get; }
+            }
+            public static class SmallMinCaption {
+                public static VisualStyleElement Active { get; }
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Inactive { get; }
+            }
+            public static class SysButton {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class VerticalScroll {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+            public static class VerticalThumb {
+                public static VisualStyleElement Disabled { get; }
+                public static VisualStyleElement Hot { get; }
+                public static VisualStyleElement Normal { get; }
+                public static VisualStyleElement Pressed { get; }
+            }
+        }
+    }
+    public static class VisualStyleInformation {
+        public static string Author { get; }
+        public static string ColorScheme { get; }
+        public static string Company { get; }
+        public static Color ControlHighlightHot { get; }
+        public static string Copyright { get; }
+        public static string Description { get; }
+        public static string DisplayName { get; }
+        public static bool IsEnabledByUser { get; }
+        public static bool IsSupportedByOS { get; }
+        public static int MinimumColorDepth { get; }
+        public static string Size { get; }
+        public static bool SupportsFlatMenus { get; }
+        public static Color TextControlBorder { get; }
+        public static string Url { get; }
+        public static string Version { get; }
+    }
+    public sealed class VisualStyleRenderer {
+        public VisualStyleRenderer(string className, int part, int state);
+        public VisualStyleRenderer(VisualStyleElement element);
+        public string Class { get; }
+        public IntPtr Handle { get; }
+        public static bool IsSupported { get; }
+        public int LastHResult { get; }
+        public int Part { get; }
+        public int State { get; }
+        public void DrawBackground(IDeviceContext dc, Rectangle bounds);
+        public void DrawBackground(IDeviceContext dc, Rectangle bounds, Rectangle clipRectangle);
+        public Rectangle DrawEdge(IDeviceContext dc, Rectangle bounds, Edges edges, EdgeStyle style, EdgeEffects effects);
+        public void DrawImage(Graphics g, Rectangle bounds, Image image);
+        public void DrawImage(Graphics g, Rectangle bounds, ImageList imageList, int imageIndex);
+        public void DrawParentBackground(IDeviceContext dc, Rectangle bounds, Control childControl);
+        public void DrawText(IDeviceContext dc, Rectangle bounds, string textToDraw);
+        public void DrawText(IDeviceContext dc, Rectangle bounds, string textToDraw, bool drawDisabled);
+        public void DrawText(IDeviceContext dc, Rectangle bounds, string textToDraw, bool drawDisabled, TextFormatFlags flags);
+        public Rectangle GetBackgroundContentRectangle(IDeviceContext dc, Rectangle bounds);
+        public Rectangle GetBackgroundExtent(IDeviceContext dc, Rectangle contentBounds);
+        public Region GetBackgroundRegion(IDeviceContext dc, Rectangle bounds);
+        public bool GetBoolean(BooleanProperty prop);
+        public Color GetColor(ColorProperty prop);
+        public int GetEnumValue(EnumProperty prop);
+        public string GetFilename(FilenameProperty prop);
+        public Font GetFont(IDeviceContext dc, FontProperty prop);
+        public int GetInteger(IntegerProperty prop);
+        public Padding GetMargins(IDeviceContext dc, MarginProperty prop);
+        public Size GetPartSize(IDeviceContext dc, Rectangle bounds, ThemeSizeType type);
+        public Size GetPartSize(IDeviceContext dc, ThemeSizeType type);
+        public Point GetPoint(PointProperty prop);
+        public string GetString(StringProperty prop);
+        public Rectangle GetTextExtent(IDeviceContext dc, Rectangle bounds, string textToDraw, TextFormatFlags flags);
+        public Rectangle GetTextExtent(IDeviceContext dc, string textToDraw, TextFormatFlags flags);
+        public TextMetrics GetTextMetrics(IDeviceContext dc);
+        public HitTestCode HitTestBackground(Graphics g, Rectangle backgroundRectangle, Region region, Point pt, HitTestOptions options);
+        public HitTestCode HitTestBackground(IDeviceContext dc, Rectangle backgroundRectangle, Point pt, HitTestOptions options);
+        public HitTestCode HitTestBackground(IDeviceContext dc, Rectangle backgroundRectangle, IntPtr hRgn, Point pt, HitTestOptions options);
+        public bool IsBackgroundPartiallyTransparent();
+        public static bool IsElementDefined(VisualStyleElement element);
+        public void SetParameters(string className, int part, int state);
+        public void SetParameters(VisualStyleElement element);
+    }
+    public enum VisualStyleState {
+        ClientAndNonClientAreasEnabled = 3,
+        ClientAreaEnabled = 2,
+        NonClientAreaEnabled = 1,
+        NoneEnabled = 0,
+    }
+}
```

