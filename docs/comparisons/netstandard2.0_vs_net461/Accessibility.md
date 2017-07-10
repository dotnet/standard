# Accessibility

``` diff
+namespace Accessibility {
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit, Size=4)]
+    public struct __MIDL_IWinTypes_0009 {
+        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
+        public int hInproc;
+        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
+        public int hRemote;
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct _RemotableHandle {
+        public __MIDL_IWinTypes_0009 u;
+        public int fContext;
+    }
+    public enum AnnoScope {
+        ANNO_CONTAINER = 1,
+        ANNO_THIS = 0,
+    }
+    public interface CAccPropServices : IAccPropServices
+    public class CAccPropServicesClass : CAccPropServices, IAccPropServices {
+        public CAccPropServicesClass();
+        virtual void ClearHmenuProps(ref _RemotableHandle hmenu, uint idChild, ref Guid paProps, int cProps);
+        virtual void ClearHwndProps(ref _RemotableHandle hwnd, uint idObject, uint idChild, ref Guid paProps, int cProps);
+        virtual void ClearProps(ref byte pIDString, uint dwIDStringLen, ref Guid paProps, int cProps);
+        virtual void ComposeHmenuIdentityString(ref _RemotableHandle hmenu, uint idChild, IntPtr ppIDString, out uint pdwIDStringLen);
+        virtual void ComposeHwndIdentityString(ref _RemotableHandle hwnd, uint idObject, uint idChild, IntPtr ppIDString, out uint pdwIDStringLen);
+        virtual void DecomposeHmenuIdentityString(ref byte pIDString, uint dwIDStringLen, IntPtr phmenu, out uint pidChild);
+        virtual void DecomposeHwndIdentityString(ref byte pIDString, uint dwIDStringLen, IntPtr phwnd, out uint pidObject, out uint pidChild);
+        virtual void SetHmenuProp(ref _RemotableHandle hmenu, uint idChild, Guid idProp, object var);
+        virtual void SetHmenuPropServer(ref _RemotableHandle hmenu, uint idChild, ref Guid paProps, int cProps, IAccPropServer pServer, AnnoScope AnnoScope);
+        virtual void SetHmenuPropStr(ref _RemotableHandle hmenu, uint idChild, Guid idProp, string str);
+        virtual void SetHwndProp(ref _RemotableHandle hwnd, uint idObject, uint idChild, Guid idProp, object var);
+        virtual void SetHwndPropServer(ref _RemotableHandle hwnd, uint idObject, uint idChild, ref Guid paProps, int cProps, IAccPropServer pServer, AnnoScope AnnoScope);
+        virtual void SetHwndPropStr(ref _RemotableHandle hwnd, uint idObject, uint idChild, Guid idProp, string str);
+        virtual void SetPropServer(ref byte pIDString, uint dwIDStringLen, ref Guid paProps, int cProps, IAccPropServer pServer, AnnoScope AnnoScope);
+        virtual void SetPropValue(ref byte pIDString, uint dwIDStringLen, Guid idProp, object var);
+    }
+    public interface IAccessible {
+        int accChildCount { get; }
+        [System.Runtime.CompilerServices.IndexerName("accChild")]
+        object this[object varChild] { get; }
+        [System.Runtime.CompilerServices.IndexerName("accDefaultAction")]
+        string this[object varChild] { get; }
+        [System.Runtime.CompilerServices.IndexerName("accDescription")]
+        string this[object varChild] { get; }
+        object accFocus { get; }
+        [System.Runtime.CompilerServices.IndexerName("accHelpTopic")]
+        int this[out string pszHelpFile, object varChild] { get; }
+        [System.Runtime.CompilerServices.IndexerName("accHelp")]
+        string this[object varChild] { get; }
+        [System.Runtime.CompilerServices.IndexerName("accKeyboardShortcut")]
+        string this[object varChild] { get; }
+        [System.Runtime.CompilerServices.IndexerName("accName")]
+        string this[object varChild] { get; set; }
+        object accParent { get; }
+        [System.Runtime.CompilerServices.IndexerName("accRole")]
+        object this[object varChild] { get; }
+        object accSelection { get; }
+        [System.Runtime.CompilerServices.IndexerName("accState")]
+        object this[object varChild] { get; }
+        [System.Runtime.CompilerServices.IndexerName("accValue")]
+        string this[object varChild] { get; set; }
+        void accDoDefaultAction(object varChild);
+        object accHitTest(int xLeft, int yTop);
+        void accLocation(out int pxLeft, out int pyTop, out int pcxWidth, out int pcyHeight, object varChild);
+        object accNavigate(int navDir, object varStart);
+        void accSelect(int flagsSelect, object varChild);
+    }
+    public interface IAccessibleHandler {
+        void AccessibleObjectFromID(int hwnd, int lObjectID, out IAccessible pIAccessible);
+    }
+    public interface IAccIdentity {
+        void GetIdentityString(uint dwIDChild, IntPtr ppIDString, out uint pdwIDStringLen);
+    }
+    public interface IAccPropServer {
+        void GetPropValue(ref byte pIDString, uint dwIDStringLen, Guid idProp, out object pvarValue, out int pfHasProp);
+    }
+    public interface IAccPropServices {
+        void ClearHmenuProps(ref _RemotableHandle hmenu, uint idChild, ref Guid paProps, int cProps);
+        void ClearHwndProps(ref _RemotableHandle hwnd, uint idObject, uint idChild, ref Guid paProps, int cProps);
+        void ClearProps(ref byte pIDString, uint dwIDStringLen, ref Guid paProps, int cProps);
+        void ComposeHmenuIdentityString(ref _RemotableHandle hmenu, uint idChild, IntPtr ppIDString, out uint pdwIDStringLen);
+        void ComposeHwndIdentityString(ref _RemotableHandle hwnd, uint idObject, uint idChild, IntPtr ppIDString, out uint pdwIDStringLen);
+        void DecomposeHmenuIdentityString(ref byte pIDString, uint dwIDStringLen, IntPtr phmenu, out uint pidChild);
+        void DecomposeHwndIdentityString(ref byte pIDString, uint dwIDStringLen, IntPtr phwnd, out uint pidObject, out uint pidChild);
+        void SetHmenuProp(ref _RemotableHandle hmenu, uint idChild, Guid idProp, object var);
+        void SetHmenuPropServer(ref _RemotableHandle hmenu, uint idChild, ref Guid paProps, int cProps, IAccPropServer pServer, AnnoScope AnnoScope);
+        void SetHmenuPropStr(ref _RemotableHandle hmenu, uint idChild, Guid idProp, string str);
+        void SetHwndProp(ref _RemotableHandle hwnd, uint idObject, uint idChild, Guid idProp, object var);
+        void SetHwndPropServer(ref _RemotableHandle hwnd, uint idObject, uint idChild, ref Guid paProps, int cProps, IAccPropServer pServer, AnnoScope AnnoScope);
+        void SetHwndPropStr(ref _RemotableHandle hwnd, uint idObject, uint idChild, Guid idProp, string str);
+        void SetPropServer(ref byte pIDString, uint dwIDStringLen, ref Guid paProps, int cProps, IAccPropServer pServer, AnnoScope AnnoScope);
+        void SetPropValue(ref byte pIDString, uint dwIDStringLen, Guid idProp, object var);
+    }
+}
```

