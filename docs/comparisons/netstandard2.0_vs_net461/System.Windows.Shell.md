# System.Windows.Shell

``` diff
+namespace System.Windows.Shell {
+    public abstract class JumpItem {
+        public string CustomCategory { get; set; }
+    }
+    public enum JumpItemRejectionReason {
+        InvalidItem = 1,
+        None = 0,
+        NoRegisteredHandler = 2,
+        RemovedByUser = 3,
+    }
+    public sealed class JumpItemsRejectedEventArgs : EventArgs {
+        public JumpItemsRejectedEventArgs();
+        public JumpItemsRejectedEventArgs(IList<JumpItem> rejectedItems, IList<JumpItemRejectionReason> reasons);
+        public IList<JumpItem> RejectedItems { get; private set; }
+        public IList<JumpItemRejectionReason> RejectionReasons { get; private set; }
+    }
+    public sealed class JumpItemsRemovedEventArgs : EventArgs {
+        public JumpItemsRemovedEventArgs();
+        public JumpItemsRemovedEventArgs(IList<JumpItem> removedItems);
+        public IList<JumpItem> RemovedItems { get; private set; }
+    }
+    public sealed class JumpList : ISupportInitialize {
+        public JumpList();
+        public JumpList(IEnumerable<JumpItem> items, bool showFrequent, bool showRecent);
+        public List<JumpItem> JumpItems { get; }
+        public bool ShowFrequentCategory { get; set; }
+        public bool ShowRecentCategory { get; set; }
+        public event EventHandler<JumpItemsRejectedEventArgs> JumpItemsRejected;
+        public event EventHandler<JumpItemsRemovedEventArgs> JumpItemsRemovedByUser;
+        public static void AddToRecentCategory(string itemPath);
+        public static void AddToRecentCategory(JumpPath jumpPath);
+        public static void AddToRecentCategory(JumpTask jumpTask);
+        public void Apply();
+        public void BeginInit();
+        public void EndInit();
+        public static JumpList GetJumpList(Application application);
+        public static void SetJumpList(Application application, JumpList value);
+    }
+    public class JumpPath : JumpItem {
+        public JumpPath();
+        public string Path { get; set; }
+    }
+    public class JumpTask : JumpItem {
+        public JumpTask();
+        public string ApplicationPath { get; set; }
+        public string Arguments { get; set; }
+        public string Description { get; set; }
+        public int IconResourceIndex { get; set; }
+        public string IconResourcePath { get; set; }
+        public string Title { get; set; }
+        public string WorkingDirectory { get; set; }
+    }
+    public enum NonClientFrameEdges {
+        Bottom = 8,
+        Left = 1,
+        None = 0,
+        Right = 4,
+        Top = 2,
+    }
+    public enum ResizeGripDirection {
+        Bottom = 6,
+        BottomLeft = 7,
+        BottomRight = 5,
+        Left = 8,
+        None = 0,
+        Right = 4,
+        Top = 2,
+        TopLeft = 1,
+        TopRight = 3,
+    }
+    public sealed class TaskbarItemInfo : Freezable {
+        public static readonly DependencyProperty DescriptionProperty;
+        public static readonly DependencyProperty OverlayProperty;
+        public static readonly DependencyProperty ProgressStateProperty;
+        public static readonly DependencyProperty ProgressValueProperty;
+        public static readonly DependencyProperty ThumbButtonInfosProperty;
+        public static readonly DependencyProperty ThumbnailClipMarginProperty;
+        public TaskbarItemInfo();
+        public string Description { get; set; }
+        public ImageSource Overlay { get; set; }
+        public TaskbarItemProgressState ProgressState { get; set; }
+        public double ProgressValue { get; set; }
+        public ThumbButtonInfoCollection ThumbButtonInfos { get; set; }
+        public Thickness ThumbnailClipMargin { get; set; }
+        protected override Freezable CreateInstanceCore();
+    }
+    public enum TaskbarItemProgressState {
+        Error = 3,
+        Indeterminate = 1,
+        None = 0,
+        Normal = 2,
+        Paused = 4,
+    }
+    public sealed class ThumbButtonInfo : Freezable, ICommandSource {
+        public static readonly DependencyProperty CommandParameterProperty;
+        public static readonly DependencyProperty CommandProperty;
+        public static readonly DependencyProperty CommandTargetProperty;
+        public static readonly DependencyProperty DescriptionProperty;
+        public static readonly DependencyProperty DismissWhenClickedProperty;
+        public static readonly DependencyProperty ImageSourceProperty;
+        public static readonly DependencyProperty IsBackgroundVisibleProperty;
+        public static readonly DependencyProperty IsEnabledProperty;
+        public static readonly DependencyProperty IsInteractiveProperty;
+        public static readonly DependencyProperty VisibilityProperty;
+        public ThumbButtonInfo();
+        public ICommand Command { get; set; }
+        public object CommandParameter { get; set; }
+        public IInputElement CommandTarget { get; set; }
+        public string Description { get; set; }
+        public bool DismissWhenClicked { get; set; }
+        public ImageSource ImageSource { get; set; }
+        public bool IsBackgroundVisible { get; set; }
+        public bool IsEnabled { get; set; }
+        public bool IsInteractive { get; set; }
+        public Visibility Visibility { get; set; }
+        public event EventHandler Click;
+        protected override Freezable CreateInstanceCore();
+    }
+    public class ThumbButtonInfoCollection : FreezableCollection<ThumbButtonInfo> {
+        public ThumbButtonInfoCollection();
+        protected override Freezable CreateInstanceCore();
+    }
+    public class WindowChrome : Freezable {
+        public static readonly DependencyProperty CaptionHeightProperty;
+        public static readonly DependencyProperty CornerRadiusProperty;
+        public static readonly DependencyProperty GlassFrameThicknessProperty;
+        public static readonly DependencyProperty IsHitTestVisibleInChromeProperty;
+        public static readonly DependencyProperty NonClientFrameEdgesProperty;
+        public static readonly DependencyProperty ResizeBorderThicknessProperty;
+        public static readonly DependencyProperty ResizeGripDirectionProperty;
+        public static readonly DependencyProperty UseAeroCaptionButtonsProperty;
+        public static readonly DependencyProperty WindowChromeProperty;
+        public WindowChrome();
+        public double CaptionHeight { get; set; }
+        public CornerRadius CornerRadius { get; set; }
+        public static Thickness GlassFrameCompleteThickness { get; }
+        public Thickness GlassFrameThickness { get; set; }
+        public NonClientFrameEdges NonClientFrameEdges { get; set; }
+        public Thickness ResizeBorderThickness { get; set; }
+        public bool UseAeroCaptionButtons { get; set; }
+        protected override Freezable CreateInstanceCore();
+        public static bool GetIsHitTestVisibleInChrome(IInputElement inputElement);
+        public static ResizeGripDirection GetResizeGripDirection(IInputElement inputElement);
+        public static WindowChrome GetWindowChrome(Window window);
+        public static void SetIsHitTestVisibleInChrome(IInputElement inputElement, bool hitTestVisible);
+        public static void SetResizeGripDirection(IInputElement inputElement, ResizeGripDirection direction);
+        public static void SetWindowChrome(Window window, WindowChrome chrome);
+    }
+}
```

