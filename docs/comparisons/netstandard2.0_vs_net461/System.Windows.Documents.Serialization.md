# System.Windows.Documents.Serialization

``` diff
+namespace System.Windows.Documents.Serialization {
+    public interface ISerializerFactory {
+        string DefaultFileExtension { get; }
+        string DisplayName { get; }
+        string ManufacturerName { get; }
+        Uri ManufacturerWebsite { get; }
+        SerializerWriter CreateSerializerWriter(Stream stream);
+    }
+    public sealed class SerializerDescriptor {
+        public string AssemblyName { get; }
+        public string AssemblyPath { get; }
+        public Version AssemblyVersion { get; }
+        public string DefaultFileExtension { get; }
+        public string DisplayName { get; }
+        public string FactoryInterfaceName { get; }
+        public bool IsLoadable { get; }
+        public string ManufacturerName { get; }
+        public Uri ManufacturerWebsite { get; }
+        public Version WinFXVersion { get; }
+        public static SerializerDescriptor CreateFromFactoryInstance(ISerializerFactory factoryInstance);
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+    }
+    public sealed class SerializerProvider {
+        public SerializerProvider();
+        public ReadOnlyCollection<SerializerDescriptor> InstalledSerializers { get; }
+        public SerializerWriter CreateSerializerWriter(SerializerDescriptor serializerDescriptor, Stream stream);
+        public static void RegisterSerializer(SerializerDescriptor serializerDescriptor, bool overwrite);
+        public static void UnregisterSerializer(SerializerDescriptor serializerDescriptor);
+    }
+    public abstract class SerializerWriter {
+        protected SerializerWriter();
+        public abstract event WritingCancelledEventHandler WritingCancelled;
+        public abstract event WritingCompletedEventHandler WritingCompleted;
+        public abstract event WritingPrintTicketRequiredEventHandler WritingPrintTicketRequired;
+        public abstract event WritingProgressChangedEventHandler WritingProgressChanged;
+        public abstract void CancelAsync();
+        public abstract SerializerWriterCollator CreateVisualsCollator();
+        public abstract SerializerWriterCollator CreateVisualsCollator(PrintTicket documentSequencePT, PrintTicket documentPT);
+        public abstract void Write(DocumentPaginator documentPaginator);
+        public abstract void Write(DocumentPaginator documentPaginator, PrintTicket printTicket);
+        public abstract void Write(FixedDocument fixedDocument);
+        public abstract void Write(FixedDocument fixedDocument, PrintTicket printTicket);
+        public abstract void Write(FixedDocumentSequence fixedDocumentSequence);
+        public abstract void Write(FixedDocumentSequence fixedDocumentSequence, PrintTicket printTicket);
+        public abstract void Write(FixedPage fixedPage);
+        public abstract void Write(FixedPage fixedPage, PrintTicket printTicket);
+        public abstract void Write(Visual visual);
+        public abstract void Write(Visual visual, PrintTicket printTicket);
+        public abstract void WriteAsync(DocumentPaginator documentPaginator);
+        public abstract void WriteAsync(DocumentPaginator documentPaginator, object userState);
+        public abstract void WriteAsync(DocumentPaginator documentPaginator, PrintTicket printTicket);
+        public abstract void WriteAsync(DocumentPaginator documentPaginator, PrintTicket printTicket, object userState);
+        public abstract void WriteAsync(FixedDocument fixedDocument);
+        public abstract void WriteAsync(FixedDocument fixedDocument, object userState);
+        public abstract void WriteAsync(FixedDocument fixedDocument, PrintTicket printTicket);
+        public abstract void WriteAsync(FixedDocument fixedDocument, PrintTicket printTicket, object userState);
+        public abstract void WriteAsync(FixedDocumentSequence fixedDocumentSequence);
+        public abstract void WriteAsync(FixedDocumentSequence fixedDocumentSequence, object userState);
+        public abstract void WriteAsync(FixedDocumentSequence fixedDocumentSequence, PrintTicket printTicket);
+        public abstract void WriteAsync(FixedDocumentSequence fixedDocumentSequence, PrintTicket printTicket, object userState);
+        public abstract void WriteAsync(FixedPage fixedPage);
+        public abstract void WriteAsync(FixedPage fixedPage, object userState);
+        public abstract void WriteAsync(FixedPage fixedPage, PrintTicket printTicket);
+        public abstract void WriteAsync(FixedPage fixedPage, PrintTicket printTicket, object userState);
+        public abstract void WriteAsync(Visual visual);
+        public abstract void WriteAsync(Visual visual, object userState);
+        public abstract void WriteAsync(Visual visual, PrintTicket printTicket);
+        public abstract void WriteAsync(Visual visual, PrintTicket printTicket, object userState);
+    }
+    public abstract class SerializerWriterCollator {
+        protected SerializerWriterCollator();
+        public abstract void BeginBatchWrite();
+        public abstract void Cancel();
+        public abstract void CancelAsync();
+        public abstract void EndBatchWrite();
+        public abstract void Write(Visual visual);
+        public abstract void Write(Visual visual, PrintTicket printTicket);
+        public abstract void WriteAsync(Visual visual);
+        public abstract void WriteAsync(Visual visual, object userState);
+        public abstract void WriteAsync(Visual visual, PrintTicket printTicket);
+        public abstract void WriteAsync(Visual visual, PrintTicket printTicket, object userState);
+    }
+    public class WritingCancelledEventArgs : EventArgs {
+        public WritingCancelledEventArgs(Exception exception);
+        public Exception Error { get; }
+    }
+    public delegate void WritingCancelledEventHandler(object sender, WritingCancelledEventArgs e);
+    public class WritingCompletedEventArgs : AsyncCompletedEventArgs {
+        public WritingCompletedEventArgs(bool cancelled, object state, Exception exception);
+    }
+    public delegate void WritingCompletedEventHandler(object sender, WritingCompletedEventArgs e);
+    public class WritingPrintTicketRequiredEventArgs : EventArgs {
+        public WritingPrintTicketRequiredEventArgs(PrintTicketLevel printTicketLevel, int sequence);
+        public PrintTicket CurrentPrintTicket { get; set; }
+        public PrintTicketLevel CurrentPrintTicketLevel { get; }
+        public int Sequence { get; }
+    }
+    public delegate void WritingPrintTicketRequiredEventHandler(object sender, WritingPrintTicketRequiredEventArgs e);
+    public class WritingProgressChangedEventArgs : ProgressChangedEventArgs {
+        public WritingProgressChangedEventArgs(WritingProgressChangeLevel writingLevel, int number, int progressPercentage, object state);
+        public int Number { get; }
+        public WritingProgressChangeLevel WritingLevel { get; }
+    }
+    public delegate void WritingProgressChangedEventHandler(object sender, WritingProgressChangedEventArgs e);
+    public enum WritingProgressChangeLevel {
+        FixedDocumentSequenceWritingProgress = 1,
+        FixedDocumentWritingProgress = 2,
+        FixedPageWritingProgress = 3,
+        None = 0,
+    }
+}
```

