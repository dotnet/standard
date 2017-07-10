# System.Windows.Input.StylusPlugIns

``` diff
+namespace System.Windows.Input.StylusPlugIns {
+    public class DynamicRenderer : StylusPlugIn {
+        public DynamicRenderer();
+        public DrawingAttributes DrawingAttributes { get; set; }
+        public Visual RootVisual { get; }
+        protected Dispatcher GetDispatcher();
+        protected override void OnAdded();
+        protected virtual void OnDraw(DrawingContext drawingContext, StylusPointCollection stylusPoints, Geometry geometry, Brush fillBrush);
+        protected virtual void OnDrawingAttributesReplaced();
+        protected override void OnEnabledChanged();
+        protected override void OnIsActiveForInputChanged();
+        protected override void OnRemoved();
+        protected override void OnStylusDown(RawStylusInput rawStylusInput);
+        protected override void OnStylusDownProcessed(object callbackData, bool targetVerified);
+        protected override void OnStylusEnter(RawStylusInput rawStylusInput, bool confirmed);
+        protected override void OnStylusLeave(RawStylusInput rawStylusInput, bool confirmed);
+        protected override void OnStylusMove(RawStylusInput rawStylusInput);
+        protected override void OnStylusUp(RawStylusInput rawStylusInput);
+        protected override void OnStylusUpProcessed(object callbackData, bool targetVerified);
+        public virtual void Reset(StylusDevice stylusDevice, StylusPointCollection stylusPoints);
+    }
+    public class RawStylusInput {
+        public int StylusDeviceId { get; }
+        public int TabletDeviceId { get; }
+        public int Timestamp { get; }
+        public StylusPointCollection GetStylusPoints();
+        public void NotifyWhenProcessed(object callbackData);
+        public void SetStylusPoints(StylusPointCollection stylusPoints);
+    }
+    public abstract class StylusPlugIn {
+        protected StylusPlugIn();
+        public UIElement Element { get; }
+        public Rect ElementBounds { get; }
+        public bool Enabled { get; set; }
+        public bool IsActiveForInput { get; }
+        protected virtual void OnAdded();
+        protected virtual void OnEnabledChanged();
+        protected virtual void OnIsActiveForInputChanged();
+        protected virtual void OnRemoved();
+        protected virtual void OnStylusDown(RawStylusInput rawStylusInput);
+        protected virtual void OnStylusDownProcessed(object callbackData, bool targetVerified);
+        protected virtual void OnStylusEnter(RawStylusInput rawStylusInput, bool confirmed);
+        protected virtual void OnStylusLeave(RawStylusInput rawStylusInput, bool confirmed);
+        protected virtual void OnStylusMove(RawStylusInput rawStylusInput);
+        protected virtual void OnStylusMoveProcessed(object callbackData, bool targetVerified);
+        protected virtual void OnStylusUp(RawStylusInput rawStylusInput);
+        protected virtual void OnStylusUpProcessed(object callbackData, bool targetVerified);
+    }
+    public sealed class StylusPlugInCollection : Collection<StylusPlugIn> {
+        protected override void ClearItems();
+        protected override void InsertItem(int index, StylusPlugIn plugIn);
+        protected override void RemoveItem(int index);
+        protected override void SetItem(int index, StylusPlugIn plugIn);
+    }
+}
```

