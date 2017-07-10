# System.Windows.Interop

``` diff
+namespace System.Windows.Interop {
+    public class ActiveXHost : HwndHost {
+        protected bool IsDisposed { get; }
+        protected override HandleRef BuildWindowCore(HandleRef hwndParent);
+        protected override void DestroyWindowCore(HandleRef hwnd);
+        protected override void Dispose(bool disposing);
+        protected override Size MeasureOverride(Size swConstraint);
+        protected override void OnAccessKey(AccessKeyEventArgs args);
+        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e);
+        protected override void OnWindowPositionChanged(Rect bounds);
+    }
+    public static class BrowserInteropHelper {
+        public static object ClientSite { get; }
+        public static object HostScript { get; }
+        public static bool IsBrowserHosted { get; }
+        public static Uri Source { get; }
+    }
+    public static class ComponentDispatcher {
+        public static MSG CurrentKeyboardMessage { get; }
+        public static bool IsThreadModal { get; }
+        public static event EventHandler EnterThreadModal;
+        public static event EventHandler LeaveThreadModal;
+        public static event ThreadMessageEventHandler ThreadFilterMessage;
+        public static event EventHandler ThreadIdle;
+        public static event ThreadMessageEventHandler ThreadPreprocessMessage;
+        public static void PopModal();
+        public static void PushModal();
+        public static void RaiseIdle();
+        public static bool RaiseThreadMessage(ref MSG msg);
+    }
+    public static class CursorInteropHelper {
+        public static Cursor Create(SafeHandle cursorHandle);
+    }
+    public class D3DImage : ImageSource, IAppDomainShutdownListener {
+        public static readonly DependencyProperty IsFrontBufferAvailableProperty;
+        public D3DImage();
+        public D3DImage(double dpiX, double dpiY);
+        public sealed override double Height { get; }
+        public bool IsFrontBufferAvailable { get; }
+        public sealed override ImageMetadata Metadata { get; }
+        public int PixelHeight { get; }
+        public int PixelWidth { get; }
+        public sealed override double Width { get; }
+        public event DependencyPropertyChangedEventHandler IsFrontBufferAvailableChanged;
+        public void AddDirtyRect(Int32Rect dirtyRect);
+        public new D3DImage Clone();
+        protected override void CloneCore(Freezable sourceFreezable);
+        public new D3DImage CloneCurrentValue();
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        protected internal virtual BitmapSource CopyBackBuffer();
+        protected override Freezable CreateInstanceCore();
+        ~D3DImage();
+        protected sealed override bool FreezeCore(bool isChecking);
+        protected override void GetAsFrozenCore(Freezable sourceFreezable);
+        protected override void GetCurrentValueAsFrozenCore(Freezable sourceFreezable);
+        public void Lock();
+        public void SetBackBuffer(D3DResourceType backBufferType, IntPtr backBuffer);
+        public void SetBackBuffer(D3DResourceType backBufferType, IntPtr backBuffer, bool enableSoftwareFallback);
+        public bool TryLock(Duration timeout);
+        public void Unlock();
+    }
+    public enum D3DResourceType {
+        IDirect3DSurface9 = 0,
+    }
+    public sealed class DocObjHost : MarshalByRefObject, IBrowserHostServices, IByteRangeDownloaderService, IHostService, IServiceProvider {
+        public DocObjHost();
+        public override object InitializeLifetimeService();
+        object System.IServiceProvider.GetService(Type serviceType);
+    }
+    public sealed class DynamicScriptObject : DynamicObject {
+        public override string ToString();
+        public override bool TryGetIndex(GetIndexBinder binder, object[] indexes, out object result);
+        public override bool TryGetMember(GetMemberBinder binder, out object result);
+        public override bool TryInvoke(InvokeBinder binder, object[] args, out object result);
+        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result);
+        public override bool TrySetIndex(SetIndexBinder binder, object[] indexes, object value);
+        public override bool TrySetMember(SetMemberBinder binder, object value);
+    }
+    public abstract class HwndHost : FrameworkElement, IDisposable, IKeyboardInputSink, IWin32Window {
+        protected HwndHost();
+        public IntPtr Handle { get; }
+        IKeyboardInputSite System.Windows.Interop.IKeyboardInputSink.KeyboardInputSite { get; set; }
+        public event HwndSourceHook MessageHook;
+        protected abstract HandleRef BuildWindowCore(HandleRef hwndParent);
+        protected abstract void DestroyWindowCore(HandleRef hwnd);
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        ~HwndHost();
+        protected virtual bool HasFocusWithinCore();
+        protected override Size MeasureOverride(Size constraint);
+        protected override AutomationPeer OnCreateAutomationPeer();
+        protected override void OnKeyDown(KeyEventArgs e);
+        protected override void OnKeyUp(KeyEventArgs e);
+        protected virtual bool OnMnemonicCore(ref MSG msg, ModifierKeys modifiers);
+        protected virtual void OnWindowPositionChanged(Rect rcBoundingBox);
+        protected virtual IKeyboardInputSite RegisterKeyboardInputSinkCore(IKeyboardInputSink sink);
+        bool System.Windows.Interop.IKeyboardInputSink.HasFocusWithin();
+        bool System.Windows.Interop.IKeyboardInputSink.OnMnemonic(ref MSG msg, ModifierKeys modifiers);
+        IKeyboardInputSite System.Windows.Interop.IKeyboardInputSink.RegisterKeyboardInputSink(IKeyboardInputSink sink);
+        bool System.Windows.Interop.IKeyboardInputSink.TabInto(TraversalRequest request);
+        bool System.Windows.Interop.IKeyboardInputSink.TranslateAccelerator(ref MSG msg, ModifierKeys modifiers);
+        bool System.Windows.Interop.IKeyboardInputSink.TranslateChar(ref MSG msg, ModifierKeys modifiers);
+        protected virtual bool TabIntoCore(TraversalRequest request);
+        protected virtual bool TranslateAcceleratorCore(ref MSG msg, ModifierKeys modifiers);
+        protected virtual bool TranslateCharCore(ref MSG msg, ModifierKeys modifiers);
+        public void UpdateWindowPos();
+        protected virtual IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled);
+    }
+    public class HwndSource : PresentationSource, IDisposable, IKeyboardInputSink, IWin32Window {
+        public HwndSource(int classStyle, int style, int exStyle, int x, int y, int width, int height, string name, IntPtr parent);
+        public HwndSource(int classStyle, int style, int exStyle, int x, int y, int width, int height, string name, IntPtr parent, bool adjustSizingForNonClientArea);
+        public HwndSource(int classStyle, int style, int exStyle, int x, int y, string name, IntPtr parent);
+        public HwndSource(HwndSourceParameters parameters);
+        public bool AcquireHwndFocusInMenuMode { get; }
+        public IEnumerable<IKeyboardInputSink> ChildKeyboardInputSinks { get; }
+        public new HwndTarget CompositionTarget { get; }
+        public static bool DefaultAcquireHwndFocusInMenuMode { get; set; }
+        public IntPtr Handle { get; }
+        public override bool IsDisposed { get; }
+        protected IKeyboardInputSite KeyboardInputSiteCore { get; set; }
+        public RestoreFocusMode RestoreFocusMode { get; }
+        public override Visual RootVisual { get; set; }
+        public SizeToContent SizeToContent { get; set; }
+        IKeyboardInputSite System.Windows.Interop.IKeyboardInputSink.KeyboardInputSite { get; set; }
+        public bool UsesPerPixelOpacity { get; }
+        public event AutoResizedEventHandler AutoResized;
+        public event EventHandler Disposed;
+        public event EventHandler SizeToContentChanged;
+        public void AddHook(HwndSourceHook hook);
+        public HandleRef CreateHandleRef();
+        public void Dispose();
+        public static HwndSource FromHwnd(IntPtr hwnd);
+        protected override CompositionTarget GetCompositionTargetCore();
+        protected virtual bool HasFocusWithinCore();
+        protected virtual bool OnMnemonicCore(ref MSG msg, ModifierKeys modifiers);
+        protected IKeyboardInputSite RegisterKeyboardInputSinkCore(IKeyboardInputSink sink);
+        public void RemoveHook(HwndSourceHook hook);
+        bool System.Windows.Interop.IKeyboardInputSink.HasFocusWithin();
+        bool System.Windows.Interop.IKeyboardInputSink.OnMnemonic(ref MSG msg, ModifierKeys modifiers);
+        IKeyboardInputSite System.Windows.Interop.IKeyboardInputSink.RegisterKeyboardInputSink(IKeyboardInputSink sink);
+        bool System.Windows.Interop.IKeyboardInputSink.TabInto(TraversalRequest request);
+        bool System.Windows.Interop.IKeyboardInputSink.TranslateAccelerator(ref MSG msg, ModifierKeys modifiers);
+        bool System.Windows.Interop.IKeyboardInputSink.TranslateChar(ref MSG msg, ModifierKeys modifiers);
+        protected virtual bool TabIntoCore(TraversalRequest request);
+        protected virtual bool TranslateAcceleratorCore(ref MSG msg, ModifierKeys modifiers);
+        protected virtual bool TranslateCharCore(ref MSG msg, ModifierKeys modifiers);
+    }
+    public delegate IntPtr HwndSourceHook(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled);
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct HwndSourceParameters {
+        public HwndSourceParameters(string name);
+        public HwndSourceParameters(string name, int width, int height);
+        public bool AcquireHwndFocusInMenuMode { get; set; }
+        public bool AdjustSizingForNonClientArea { get; set; }
+        public int ExtendedWindowStyle { get; set; }
+        public bool HasAssignedSize { get; }
+        public int Height { get; set; }
+        public HwndSourceHook HwndSourceHook { get; set; }
+        public IntPtr ParentWindow { get; set; }
+        public int PositionX { get; set; }
+        public int PositionY { get; set; }
+        public RestoreFocusMode RestoreFocusMode { get; set; }
+        public bool TreatAncestorsAsNonClientArea { get; set; }
+        public bool TreatAsInputRoot { get; set; }
+        public bool UsesPerPixelOpacity { get; set; }
+        public bool UsesPerPixelTransparency { get; set; }
+        public int Width { get; set; }
+        public int WindowClassStyle { get; set; }
+        public string WindowName { get; set; }
+        public int WindowStyle { get; set; }
+        public override bool Equals(object obj);
+        public bool Equals(HwndSourceParameters obj);
+        public override int GetHashCode();
+        public static bool operator ==(HwndSourceParameters a, HwndSourceParameters b);
+        public static bool operator !=(HwndSourceParameters a, HwndSourceParameters b);
+        public void SetPosition(int x, int y);
+        public void SetSize(int width, int height);
+    }
+    public class HwndTarget : CompositionTarget {
+        public HwndTarget(IntPtr hwnd);
+        public Color BackgroundColor { get; set; }
+        public RenderMode RenderMode { get; set; }
+        public override Visual RootVisual { set; }
+        public override Matrix TransformFromDevice { get; }
+        public override Matrix TransformToDevice { get; }
+        public bool UsesPerPixelOpacity { get; internal set; }
+        public override void Dispose();
+    }
+    public interface IErrorPage {
+        Uri DeploymentPath { get; set; }
+        bool ErrorFlag { get; set; }
+        string ErrorText { get; set; }
+        string ErrorTitle { get; set; }
+        DispatcherOperationCallback GetWinFxCallback { get; set; }
+        string LogFilePath { get; set; }
+        DispatcherOperationCallback RefreshCallback { get; set; }
+        Uri SupportUri { get; set; }
+    }
+    public interface IKeyboardInputSink {
+        IKeyboardInputSite KeyboardInputSite { get; set; }
+        bool HasFocusWithin();
+        bool OnMnemonic(ref MSG msg, ModifierKeys modifiers);
+        IKeyboardInputSite RegisterKeyboardInputSink(IKeyboardInputSink sink);
+        bool TabInto(TraversalRequest request);
+        bool TranslateAccelerator(ref MSG msg, ModifierKeys modifiers);
+        bool TranslateChar(ref MSG msg, ModifierKeys modifiers);
+    }
+    public interface IKeyboardInputSite {
+        IKeyboardInputSink Sink { get; }
+        bool OnNoMoreTabStops(TraversalRequest request);
+        void Unregister();
+    }
+    public static class Imaging {
+        public static BitmapSource CreateBitmapSourceFromHBitmap(IntPtr bitmap, IntPtr palette, Int32Rect sourceRect, BitmapSizeOptions sizeOptions);
+        public static BitmapSource CreateBitmapSourceFromHIcon(IntPtr icon, Int32Rect sourceRect, BitmapSizeOptions sizeOptions);
+        public static BitmapSource CreateBitmapSourceFromMemorySection(IntPtr section, int pixelWidth, int pixelHeight, PixelFormat format, int stride, int offset);
+    }
+    public sealed class InteropBitmap : BitmapSource {
+        protected override void CloneCore(Freezable sourceFreezable);
+        protected override void CloneCurrentValueCore(Freezable sourceFreezable);
+        protected override Freezable CreateInstanceCore();
+        protected override void GetAsFrozenCore(Freezable sourceFreezable);
+        protected override void GetCurrentValueAsFrozenCore(Freezable sourceFreezable);
+        public void Invalidate();
+        public void Invalidate(Nullable<Int32Rect> dirtyRect);
+    }
+    public interface IProgressPage {
+        string ApplicationName { get; set; }
+        Uri DeploymentPath { get; set; }
+        string PublisherName { get; set; }
+        DispatcherOperationCallback RefreshCallback { get; set; }
+        DispatcherOperationCallback StopCallback { get; set; }
+        void UpdateProgress(long bytesDownloaded, long bytesTotal);
+    }
+    public interface IWin32Window {
+        IntPtr Handle { get; }
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct MSG {
+        public IntPtr hwnd { get; set; }
+        public IntPtr lParam { get; set; }
+        public int message { get; set; }
+        public int pt_x { get; set; }
+        public int pt_y { get; set; }
+        public int time { get; set; }
+        public IntPtr wParam { get; set; }
+    }
+    public enum RenderMode {
+        Default = 0,
+        SoftwareOnly = 1,
+    }
+    public delegate void ThreadMessageEventHandler(ref MSG msg, ref bool handled);
+    public sealed class WindowInteropHelper {
+        public WindowInteropHelper(Window window);
+        public IntPtr Handle { get; }
+        public IntPtr Owner { get; set; }
+        public IntPtr EnsureHandle();
+    }
+}
```

