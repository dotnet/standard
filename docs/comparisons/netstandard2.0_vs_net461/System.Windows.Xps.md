# System.Windows.Xps

``` diff
+namespace System.Windows.Xps {
+    public class VisualsToXpsDocument : SerializerWriterCollator {
+        public override void BeginBatchWrite();
+        public override void Cancel();
+        public override void CancelAsync();
+        public override void EndBatchWrite();
+        public override void Write(Visual visual);
+        public override void Write(Visual visual, PrintTicket printTicket);
+        public override void WriteAsync(Visual visual);
+        public override void WriteAsync(Visual visual, object userSuppliedState);
+        public override void WriteAsync(Visual visual, PrintTicket printTicket);
+        public override void WriteAsync(Visual visual, PrintTicket printTicket, object userSuppliedState);
+    }
+    public enum XpsDocumentNotificationLevel {
+        None = 0,
+        ReceiveNotificationDisabled = 2,
+        ReceiveNotificationEnabled = 1,
+    }
+    public class XpsDocumentWriter : SerializerWriter {
+        public override event WritingCancelledEventHandler WritingCancelled;
+        public virtual event WritingCompletedEventHandler WritingCompleted;
+        public override event WritingPrintTicketRequiredEventHandler WritingPrintTicketRequired;
+        public override event WritingProgressChangedEventHandler WritingProgressChanged;
+        public override void CancelAsync();
+        public override SerializerWriterCollator CreateVisualsCollator();
+        public override SerializerWriterCollator CreateVisualsCollator(PrintTicket documentSequencePrintTicket, PrintTicket documentPrintTicket);
+        public virtual void raise_WritingCancelled(object sender, WritingCancelledEventArgs args);
+        public virtual void raise_WritingCompleted(object sender, WritingCompletedEventArgs e);
+        public virtual void raise_WritingPrintTicketRequired(object sender, WritingPrintTicketRequiredEventArgs e);
+        public virtual void raise_WritingProgressChanged(object sender, WritingProgressChangedEventArgs e);
+        protected void raise__WritingCancelled(object value0, WritingCancelledEventArgs value1);
+        protected void raise__WritingCompleted(object value0, WritingCompletedEventArgs value1);
+        protected void raise__WritingProgressChanged(object value0, WritingProgressChangedEventArgs value1);
+        public void Write(string documentPath);
+        public void Write(string documentPath, XpsDocumentNotificationLevel notificationLevel);
+        public override void Write(DocumentPaginator documentPaginator);
+        public override void Write(DocumentPaginator documentPaginator, PrintTicket printTicket);
+        public override void Write(FixedDocument fixedDocument);
+        public override void Write(FixedDocument fixedDocument, PrintTicket printTicket);
+        public override void Write(FixedDocumentSequence fixedDocumentSequence);
+        public override void Write(FixedDocumentSequence fixedDocumentSequence, PrintTicket printTicket);
+        public override void Write(FixedPage fixedPage);
+        public override void Write(FixedPage fixedPage, PrintTicket printTicket);
+        public override void Write(Visual visual);
+        public override void Write(Visual visual, PrintTicket printTicket);
+        public void WriteAsync(string documentPath);
+        public void WriteAsync(string documentPath, XpsDocumentNotificationLevel notificationLevel);
+        public override void WriteAsync(DocumentPaginator documentPaginator);
+        public override void WriteAsync(DocumentPaginator documentPaginator, object userSuppliedState);
+        public override void WriteAsync(DocumentPaginator documentPaginator, PrintTicket printTicket);
+        public override void WriteAsync(DocumentPaginator documentPaginator, PrintTicket printTicket, object userSuppliedState);
+        public override void WriteAsync(FixedDocument fixedDocument);
+        public override void WriteAsync(FixedDocument fixedDocument, object userSuppliedState);
+        public override void WriteAsync(FixedDocument fixedDocument, PrintTicket printTicket);
+        public override void WriteAsync(FixedDocument fixedDocument, PrintTicket printTicket, object userSuppliedState);
+        public override void WriteAsync(FixedDocumentSequence fixedDocumentSequence);
+        public override void WriteAsync(FixedDocumentSequence fixedDocumentSequence, object userSuppliedState);
+        public override void WriteAsync(FixedDocumentSequence fixedDocumentSequence, PrintTicket printTicket);
+        public override void WriteAsync(FixedDocumentSequence fixedDocumentSequence, PrintTicket printTicket, object userSuppliedState);
+        public override void WriteAsync(FixedPage fixedPage);
+        public override void WriteAsync(FixedPage fixedPage, object userSuppliedState);
+        public override void WriteAsync(FixedPage fixedPage, PrintTicket printTicket);
+        public override void WriteAsync(FixedPage fixedPage, PrintTicket printTicket, object userSuppliedState);
+        public override void WriteAsync(Visual visual);
+        public override void WriteAsync(Visual visual, object userSuppliedState);
+        public override void WriteAsync(Visual visual, PrintTicket printTicket);
+        public override void WriteAsync(Visual visual, PrintTicket printTicket, object userSuppliedState);
+    }
+    public class XpsException : Exception {
+        public XpsException();
+        protected XpsException(SerializationInfo info, StreamingContext context);
+        public XpsException(string message);
+        public XpsException(string message, Exception innerException);
+    }
+    public class XpsPackagingException : XpsException {
+        public XpsPackagingException();
+        protected XpsPackagingException(SerializationInfo info, StreamingContext context);
+        public XpsPackagingException(string message);
+        public XpsPackagingException(string message, Exception innerException);
+    }
+    public class XpsSerializationException : XpsException {
+        public XpsSerializationException();
+        protected XpsSerializationException(SerializationInfo info, StreamingContext context);
+        public XpsSerializationException(string message);
+        public XpsSerializationException(string message, Exception innerException);
+    }
+    public class XpsWriterException : Exception {
+        public XpsWriterException();
+        protected XpsWriterException(SerializationInfo info, StreamingContext context);
+        public XpsWriterException(string message);
+        public XpsWriterException(string message, Exception innerException);
+    }
+}
```

