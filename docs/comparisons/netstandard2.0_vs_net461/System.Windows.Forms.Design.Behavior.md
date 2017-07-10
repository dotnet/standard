# System.Windows.Forms.Design.Behavior

``` diff
+namespace System.Windows.Forms.Design.Behavior {
+    public sealed class Adorner {
+        public Adorner();
+        public BehaviorService BehaviorService { get; set; }
+        public bool Enabled { get; set; }
+        public GlyphCollection Glyphs { get; }
+        public void Invalidate();
+        public void Invalidate(Rectangle rectangle);
+        public void Invalidate(Region region);
+    }
+    public abstract class Behavior {
+        protected Behavior();
+        protected Behavior(bool callParentBehavior, BehaviorService behaviorService);
+        public virtual Cursor Cursor { get; }
+        public virtual bool DisableAllCommands { get; }
+        public virtual MenuCommand FindCommand(CommandID commandId);
+        public virtual void OnDragDrop(Glyph g, DragEventArgs e);
+        public virtual void OnDragEnter(Glyph g, DragEventArgs e);
+        public virtual void OnDragLeave(Glyph g, EventArgs e);
+        public virtual void OnDragOver(Glyph g, DragEventArgs e);
+        public virtual void OnGiveFeedback(Glyph g, GiveFeedbackEventArgs e);
+        public virtual void OnLoseCapture(Glyph g, EventArgs e);
+        public virtual bool OnMouseDoubleClick(Glyph g, MouseButtons button, Point mouseLoc);
+        public virtual bool OnMouseDown(Glyph g, MouseButtons button, Point mouseLoc);
+        public virtual bool OnMouseEnter(Glyph g);
+        public virtual bool OnMouseHover(Glyph g, Point mouseLoc);
+        public virtual bool OnMouseLeave(Glyph g);
+        public virtual bool OnMouseMove(Glyph g, MouseButtons button, Point mouseLoc);
+        public virtual bool OnMouseUp(Glyph g, MouseButtons button);
+        public virtual void OnQueryContinueDrag(Glyph g, QueryContinueDragEventArgs e);
+    }
+    public class BehaviorDragDropEventArgs : EventArgs {
+        public BehaviorDragDropEventArgs(ICollection dragComponents);
+        public ICollection DragComponents { get; }
+    }
+    public delegate void BehaviorDragDropEventHandler(object sender, BehaviorDragDropEventArgs e);
+    public sealed class BehaviorService : IDisposable {
+        public BehaviorServiceAdornerCollection Adorners { get; }
+        public Graphics AdornerWindowGraphics { get; }
+        public Behavior CurrentBehavior { get; }
+        public event BehaviorDragDropEventHandler BeginDrag;
+        public event BehaviorDragDropEventHandler EndDrag;
+        public event EventHandler Synchronize;
+        public Point AdornerWindowPointToScreen(Point p);
+        public Point AdornerWindowToScreen();
+        public Rectangle ControlRectInAdornerWindow(Control c);
+        public Point ControlToAdornerWindow(Control c);
+        public void Dispose();
+        public Behavior GetNextBehavior(Behavior behavior);
+        public void Invalidate();
+        public void Invalidate(Rectangle rect);
+        public void Invalidate(Region r);
+        public Point MapAdornerWindowPoint(IntPtr handle, Point pt);
+        public Behavior PopBehavior(Behavior behavior);
+        public void PushBehavior(Behavior behavior);
+        public void PushCaptureBehavior(Behavior behavior);
+        public Point ScreenToAdornerWindow(Point p);
+        public void SyncSelection();
+    }
+    public sealed class BehaviorServiceAdornerCollection : CollectionBase {
+        public BehaviorServiceAdornerCollection(Adorner[] value);
+        public BehaviorServiceAdornerCollection(BehaviorService behaviorService);
+        public BehaviorServiceAdornerCollection(BehaviorServiceAdornerCollection value);
+        public Adorner this[int index] { get; set; }
+        public int Add(Adorner value);
+        public void AddRange(Adorner[] value);
+        public void AddRange(BehaviorServiceAdornerCollection value);
+        public bool Contains(Adorner value);
+        public void CopyTo(Adorner[] array, int index);
+        public new BehaviorServiceAdornerCollectionEnumerator GetEnumerator();
+        public int IndexOf(Adorner value);
+        public void Insert(int index, Adorner value);
+        public void Remove(Adorner value);
+    }
+    public class BehaviorServiceAdornerCollectionEnumerator : IEnumerator {
+        public BehaviorServiceAdornerCollectionEnumerator(BehaviorServiceAdornerCollection mappings);
+        public Adorner Current { get; }
+        object System.Collections.IEnumerator.Current { get; }
+        public bool MoveNext();
+        public void Reset();
+        bool System.Collections.IEnumerator.MoveNext();
+        void System.Collections.IEnumerator.Reset();
+    }
+    public class ComponentGlyph : Glyph {
+        public ComponentGlyph(IComponent relatedComponent);
+        public ComponentGlyph(IComponent relatedComponent, Behavior behavior);
+        public IComponent RelatedComponent { get; }
+        public override Cursor GetHitTest(Point p);
+        public override void Paint(PaintEventArgs pe);
+    }
+    public class ControlBodyGlyph : ComponentGlyph {
+        public ControlBodyGlyph(Rectangle bounds, Cursor cursor, IComponent relatedComponent, Behavior behavior);
+        public ControlBodyGlyph(Rectangle bounds, Cursor cursor, IComponent relatedComponent, ControlDesigner designer);
+        public override Rectangle Bounds { get; }
+        public override Cursor GetHitTest(Point p);
+    }
+    public abstract class Glyph {
+        protected Glyph(Behavior behavior);
+        public virtual Behavior Behavior { get; }
+        public virtual Rectangle Bounds { get; }
+        public abstract Cursor GetHitTest(Point p);
+        public abstract void Paint(PaintEventArgs pe);
+        protected void SetBehavior(Behavior behavior);
+    }
+    public class GlyphCollection : CollectionBase {
+        public GlyphCollection();
+        public GlyphCollection(GlyphCollection value);
+        public GlyphCollection(Glyph[] value);
+        public Glyph this[int index] { get; set; }
+        public int Add(Glyph value);
+        public void AddRange(GlyphCollection value);
+        public void AddRange(Glyph[] value);
+        public bool Contains(Glyph value);
+        public void CopyTo(Glyph[] array, int index);
+        public int IndexOf(Glyph value);
+        public void Insert(int index, Glyph value);
+        public void Remove(Glyph value);
+    }
+    public enum GlyphSelectionType {
+        NotSelected = 0,
+        Selected = 1,
+        SelectedPrimary = 2,
+    }
+    public sealed class SnapLine {
+        public SnapLine(SnapLineType type, int offset);
+        public SnapLine(SnapLineType type, int offset, string filter);
+        public SnapLine(SnapLineType type, int offset, string filter, SnapLinePriority priority);
+        public SnapLine(SnapLineType type, int offset, SnapLinePriority priority);
+        public string Filter { get; }
+        public bool IsHorizontal { get; }
+        public bool IsVertical { get; }
+        public int Offset { get; }
+        public SnapLinePriority Priority { get; }
+        public SnapLineType SnapLineType { get; }
+        public void AdjustOffset(int adjustment);
+        public static bool ShouldSnap(SnapLine line1, SnapLine line2);
+        public override string ToString();
+    }
+    public enum SnapLinePriority {
+        Always = 4,
+        High = 3,
+        Low = 1,
+        Medium = 2,
+    }
+    public enum SnapLineType {
+        Baseline = 6,
+        Bottom = 1,
+        Horizontal = 4,
+        Left = 2,
+        Right = 3,
+        Top = 0,
+        Vertical = 5,
+    }
+}
```

