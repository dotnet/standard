# System.Windows.Annotations.Storage

``` diff
+namespace System.Windows.Annotations.Storage {
+    public abstract class AnnotationStore : IDisposable {
+        protected AnnotationStore();
+        public abstract bool AutoFlush { get; set; }
+        protected bool IsDisposed { get; }
+        protected object SyncRoot { get; }
+        public event AnnotationResourceChangedEventHandler AnchorChanged;
+        public event AnnotationAuthorChangedEventHandler AuthorChanged;
+        public event AnnotationResourceChangedEventHandler CargoChanged;
+        public event StoreContentChangedEventHandler StoreContentChanged;
+        public abstract void AddAnnotation(Annotation newAnnotation);
+        public abstract Annotation DeleteAnnotation(Guid annotationId);
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        ~AnnotationStore();
+        public abstract void Flush();
+        public abstract Annotation GetAnnotation(Guid annotationId);
+        public abstract IList<Annotation> GetAnnotations();
+        public abstract IList<Annotation> GetAnnotations(ContentLocator anchorLocator);
+        protected virtual void OnAnchorChanged(AnnotationResourceChangedEventArgs args);
+        protected virtual void OnAuthorChanged(AnnotationAuthorChangedEventArgs args);
+        protected virtual void OnCargoChanged(AnnotationResourceChangedEventArgs args);
+        protected virtual void OnStoreContentChanged(StoreContentChangedEventArgs e);
+    }
+    public enum StoreContentAction {
+        Added = 0,
+        Deleted = 1,
+    }
+    public class StoreContentChangedEventArgs : EventArgs {
+        public StoreContentChangedEventArgs(StoreContentAction action, Annotation annotation);
+        public StoreContentAction Action { get; }
+        public Annotation Annotation { get; }
+    }
+    public delegate void StoreContentChangedEventHandler(object sender, StoreContentChangedEventArgs e);
+    public sealed class XmlStreamStore : AnnotationStore {
+        public XmlStreamStore(Stream stream);
+        public XmlStreamStore(Stream stream, IDictionary<Uri, IList<Uri>> knownNamespaces);
+        public override bool AutoFlush { get; set; }
+        public IList<Uri> IgnoredNamespaces { get; }
+        public static IList<Uri> WellKnownNamespaces { get; }
+        public override void AddAnnotation(Annotation newAnnotation);
+        public override Annotation DeleteAnnotation(Guid annotationId);
+        protected override void Dispose(bool disposing);
+        public override void Flush();
+        public override Annotation GetAnnotation(Guid annotationId);
+        public override IList<Annotation> GetAnnotations();
+        public override IList<Annotation> GetAnnotations(ContentLocator anchorLocator);
+        public static IList<Uri> GetWellKnownCompatibleNamespaces(Uri name);
+        protected override void OnStoreContentChanged(StoreContentChangedEventArgs e);
+    }
+}
```

