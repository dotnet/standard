# System.Windows.Annotations

``` diff
+namespace System.Windows.Annotations {
+    public sealed class Annotation : IXmlSerializable {
+        public Annotation();
+        public Annotation(XmlQualifiedName annotationType);
+        public Annotation(XmlQualifiedName annotationType, Guid id, DateTime creationTime, DateTime lastModificationTime);
+        public Collection<AnnotationResource> Anchors { get; }
+        public XmlQualifiedName AnnotationType { get; }
+        public Collection<string> Authors { get; }
+        public Collection<AnnotationResource> Cargos { get; }
+        public DateTime CreationTime { get; }
+        public Guid Id { get; }
+        public DateTime LastModificationTime { get; }
+        public event AnnotationResourceChangedEventHandler AnchorChanged;
+        public event AnnotationAuthorChangedEventHandler AuthorChanged;
+        public event AnnotationResourceChangedEventHandler CargoChanged;
+        public XmlSchema GetSchema();
+        public void ReadXml(XmlReader reader);
+        public void WriteXml(XmlWriter writer);
+    }
+    public enum AnnotationAction {
+        Added = 0,
+        Modified = 2,
+        Removed = 1,
+    }
+    public sealed class AnnotationAuthorChangedEventArgs : EventArgs {
+        public AnnotationAuthorChangedEventArgs(Annotation annotation, AnnotationAction action, object author);
+        public AnnotationAction Action { get; }
+        public Annotation Annotation { get; }
+        public object Author { get; }
+    }
+    public delegate void AnnotationAuthorChangedEventHandler(object sender, AnnotationAuthorChangedEventArgs e);
+    public sealed class AnnotationDocumentPaginator : DocumentPaginator {
+        public AnnotationDocumentPaginator(DocumentPaginator originalPaginator, Stream annotationStore);
+        public AnnotationDocumentPaginator(DocumentPaginator originalPaginator, Stream annotationStore, FlowDirection flowDirection);
+        public AnnotationDocumentPaginator(DocumentPaginator originalPaginator, AnnotationStore annotationStore);
+        public AnnotationDocumentPaginator(DocumentPaginator originalPaginator, AnnotationStore annotationStore, FlowDirection flowDirection);
+        public override bool IsPageCountValid { get; }
+        public override int PageCount { get; }
+        public override Size PageSize { get; set; }
+        public override IDocumentPaginatorSource Source { get; }
+        public override void CancelAsync(object userState);
+        public override void ComputePageCount();
+        public override void ComputePageCountAsync(object userState);
+        public override DocumentPage GetPage(int pageNumber);
+        public override void GetPageAsync(int pageNumber, object userState);
+    }
+    public static class AnnotationHelper {
+        public static void ClearHighlightsForSelection(AnnotationService service);
+        public static Annotation CreateHighlightForSelection(AnnotationService service, string author, Brush highlightBrush);
+        public static Annotation CreateInkStickyNoteForSelection(AnnotationService service, string author);
+        public static Annotation CreateTextStickyNoteForSelection(AnnotationService service, string author);
+        public static void DeleteInkStickyNotesForSelection(AnnotationService service);
+        public static void DeleteTextStickyNotesForSelection(AnnotationService service);
+        public static IAnchorInfo GetAnchorInfo(AnnotationService service, Annotation annotation);
+    }
+    public sealed class AnnotationResource : INotifyPropertyChanged, INotifyPropertyChanged2, IOwnedObject, IXmlSerializable {
+        public AnnotationResource();
+        public AnnotationResource(Guid id);
+        public AnnotationResource(string name);
+        public Collection<ContentLocatorBase> ContentLocators { get; }
+        public Collection<XmlElement> Contents { get; }
+        public Guid Id { get; }
+        public string Name { get; set; }
+        event PropertyChangedEventHandler System.ComponentModel.INotifyPropertyChanged.PropertyChanged;
+        public XmlSchema GetSchema();
+        public void ReadXml(XmlReader reader);
+        public void WriteXml(XmlWriter writer);
+    }
+    public sealed class AnnotationResourceChangedEventArgs : EventArgs {
+        public AnnotationResourceChangedEventArgs(Annotation annotation, AnnotationAction action, AnnotationResource resource);
+        public AnnotationAction Action { get; }
+        public Annotation Annotation { get; }
+        public AnnotationResource Resource { get; }
+    }
+    public delegate void AnnotationResourceChangedEventHandler(object sender, AnnotationResourceChangedEventArgs e);
+    public sealed class AnnotationService : DispatcherObject {
+        public static readonly RoutedUICommand ClearHighlightsCommand;
+        public static readonly RoutedUICommand CreateHighlightCommand;
+        public static readonly RoutedUICommand CreateInkStickyNoteCommand;
+        public static readonly RoutedUICommand CreateTextStickyNoteCommand;
+        public static readonly RoutedUICommand DeleteAnnotationsCommand;
+        public static readonly RoutedUICommand DeleteStickyNotesCommand;
+        public AnnotationService(FlowDocumentReader viewer);
+        public AnnotationService(FlowDocumentScrollViewer viewer);
+        public AnnotationService(DocumentViewerBase viewer);
+        public bool IsEnabled { get; }
+        public AnnotationStore Store { get; }
+        public void Disable();
+        public void Enable(AnnotationStore annotationStore);
+        public static AnnotationService GetService(FlowDocumentReader reader);
+        public static AnnotationService GetService(FlowDocumentScrollViewer viewer);
+        public static AnnotationService GetService(DocumentViewerBase viewer);
+    }
+    public sealed class ContentLocator : ContentLocatorBase, IXmlSerializable {
+        public ContentLocator();
+        public Collection<ContentLocatorPart> Parts { get; }
+        public override object Clone();
+        public XmlSchema GetSchema();
+        public void ReadXml(XmlReader reader);
+        public bool StartsWith(ContentLocator locator);
+        public void WriteXml(XmlWriter writer);
+    }
+    public abstract class ContentLocatorBase : INotifyPropertyChanged, INotifyPropertyChanged2, IOwnedObject {
+        event PropertyChangedEventHandler System.ComponentModel.INotifyPropertyChanged.PropertyChanged;
+        public abstract object Clone();
+    }
+    public sealed class ContentLocatorGroup : ContentLocatorBase, IXmlSerializable {
+        public ContentLocatorGroup();
+        public Collection<ContentLocator> Locators { get; }
+        public override object Clone();
+        public XmlSchema GetSchema();
+        public void ReadXml(XmlReader reader);
+        public void WriteXml(XmlWriter writer);
+    }
+    public sealed class ContentLocatorPart : INotifyPropertyChanged, INotifyPropertyChanged2, IOwnedObject {
+        public ContentLocatorPart(XmlQualifiedName partType);
+        public IDictionary<string, string> NameValuePairs { get; }
+        public XmlQualifiedName PartType { get; }
+        event PropertyChangedEventHandler System.ComponentModel.INotifyPropertyChanged.PropertyChanged;
+        public object Clone();
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+    }
+    public interface IAnchorInfo {
+        AnnotationResource Anchor { get; }
+        Annotation Annotation { get; }
+        object ResolvedAnchor { get; }
+    }
+    public sealed class TextAnchor {
+        public ContentPosition BoundingEnd { get; }
+        public ContentPosition BoundingStart { get; }
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+    }
+}
```

