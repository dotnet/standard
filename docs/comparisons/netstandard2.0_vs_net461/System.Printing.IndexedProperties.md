# System.Printing.IndexedProperties

``` diff
+namespace System.Printing.IndexedProperties {
+    public sealed class PrintBooleanProperty : PrintProperty {
+        public PrintBooleanProperty(string attributeName);
+        public PrintBooleanProperty(string attributeName, object attributeValue);
+        public override object Value { get; set; }
+        protected sealed override void InternalDispose(bool disposing);
+        public static implicit operator bool (PrintBooleanProperty attribRef);
+    }
+    public sealed class PrintByteArrayProperty : PrintProperty {
+        public PrintByteArrayProperty(string attributeName);
+        public PrintByteArrayProperty(string attributeName, object attributeValue);
+        public override object Value { get; set; }
+        protected sealed override void InternalDispose(bool disposing);
+        public static implicit operator byte[] (PrintByteArrayProperty attribRef);
+    }
+    public sealed class PrintDateTimeProperty : PrintProperty {
+        public PrintDateTimeProperty(string attributeName);
+        public PrintDateTimeProperty(string attributeName, object attributeValue);
+        public override object Value { get; set; }
+        protected sealed override void InternalDispose(bool disposing);
+        public static implicit operator ValueType (PrintDateTimeProperty attribRef);
+    }
+    public sealed class PrintDriverProperty : PrintProperty {
+        public PrintDriverProperty(string attributeName);
+        public PrintDriverProperty(string attributeName, object attributeValue);
+        public override object Value { get; set; }
+        protected sealed override void InternalDispose(bool disposing);
+        public static implicit operator PrintDriver (PrintDriverProperty attribRef);
+    }
+    public sealed class PrintInt32Property : PrintProperty {
+        public PrintInt32Property(string attributeName);
+        public PrintInt32Property(string attributeName, object attributeValue);
+        public override object Value { get; set; }
+        protected sealed override void InternalDispose(bool disposing);
+        public static implicit operator int (PrintInt32Property attribRef);
+    }
+    public sealed class PrintJobPriorityProperty : PrintProperty {
+        public PrintJobPriorityProperty(string attributeName);
+        public PrintJobPriorityProperty(string attributeName, object attributeValue);
+        public override object Value { get; set; }
+        protected sealed override void InternalDispose(bool disposing);
+        public static implicit operator PrintJobPriority (PrintJobPriorityProperty attribRef);
+    }
+    public sealed class PrintJobStatusProperty : PrintProperty {
+        public PrintJobStatusProperty(string attributeName);
+        public PrintJobStatusProperty(string attributeName, object attributeValue);
+        public override object Value { get; set; }
+        protected sealed override void InternalDispose(bool disposing);
+        public static implicit operator PrintJobStatus (PrintJobStatusProperty attribRef);
+    }
+    public sealed class PrintPortProperty : PrintProperty {
+        public PrintPortProperty(string attributeName);
+        public PrintPortProperty(string attributeName, object attributeValue);
+        public override object Value { get; set; }
+        protected sealed override void InternalDispose(bool disposing);
+        public static implicit operator PrintPort (PrintPortProperty attribRef);
+    }
+    public sealed class PrintProcessorProperty : PrintProperty {
+        public PrintProcessorProperty(string attributeName);
+        public PrintProcessorProperty(string attributeName, object attributeValue);
+        public override object Value { get; set; }
+        protected sealed override void InternalDispose(bool disposing);
+        public static implicit operator PrintProcessor (PrintProcessorProperty attribRef);
+    }
+    public abstract class PrintProperty : IDeserializationCallback, IDisposable {
+        protected PrintProperty(string attributeName);
+        protected bool IsDisposed { get; set; }
+        protected internal bool IsInitialized { internal get; protected set; }
+        public virtual string Name { get; }
+        public abstract object Value { get; set; }
+        public sealed override void Dispose();
+        protected virtual void Dispose(bool A_0);
+        ~PrintProperty();
+        protected virtual void InternalDispose(bool disposing);
+        public virtual void OnDeserialization(object sender);
+    }
+    public class PrintPropertyDictionary : Hashtable, IDeserializationCallback, IDisposable, ISerializable {
+        public PrintPropertyDictionary();
+        protected PrintPropertyDictionary(SerializationInfo info, StreamingContext context);
+        public void Add(PrintProperty attributeValue);
+        public sealed override void Dispose();
+        protected virtual void Dispose(bool A_0);
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+        public PrintProperty GetProperty(string attribName);
+        public override void OnDeserialization(object sender);
+        public void SetProperty(string attribName, PrintProperty attribValue);
+    }
+    public sealed class PrintQueueAttributeProperty : PrintProperty {
+        public PrintQueueAttributeProperty(string attributeName);
+        public PrintQueueAttributeProperty(string attributeName, object attributeValue);
+        public override object Value { get; set; }
+        protected sealed override void InternalDispose(bool disposing);
+        public static implicit operator PrintQueueAttributes (PrintQueueAttributeProperty attributeRef);
+    }
+    public sealed class PrintQueueProperty : PrintProperty {
+        public PrintQueueProperty(string attributeName);
+        public PrintQueueProperty(string attributeName, object attributeValue);
+        public override object Value { get; set; }
+        protected sealed override void InternalDispose(bool disposing);
+        public static implicit operator PrintQueue (PrintQueueProperty attribRef);
+    }
+    public sealed class PrintQueueStatusProperty : PrintProperty {
+        public PrintQueueStatusProperty(string attributeName);
+        public PrintQueueStatusProperty(string attributeName, object attributeValue);
+        public override object Value { get; set; }
+        protected sealed override void InternalDispose(bool disposing);
+        public static implicit operator PrintQueueStatus (PrintQueueStatusProperty attributeRef);
+    }
+    public sealed class PrintServerLoggingProperty : PrintProperty {
+        public PrintServerLoggingProperty(string attributeName);
+        public PrintServerLoggingProperty(string attributeName, object attributeValue);
+        public override object Value { get; set; }
+        protected sealed override void InternalDispose(bool disposing);
+        public static implicit operator PrintServerEventLoggingTypes (PrintServerLoggingProperty attribRef);
+    }
+    public sealed class PrintServerProperty : PrintProperty {
+        public PrintServerProperty(string attributeName);
+        public PrintServerProperty(string attributeName, object attributeValue);
+        public override object Value { get; set; }
+        protected sealed override void InternalDispose(bool disposing);
+        public static implicit operator PrintServer (PrintServerProperty attribRef);
+    }
+    public sealed class PrintStreamProperty : PrintProperty {
+        public PrintStreamProperty(string attributeName);
+        public PrintStreamProperty(string attributeName, object attributeValue);
+        public override object Value { get; set; }
+        protected sealed override void InternalDispose(bool disposing);
+        public static implicit operator Stream (PrintStreamProperty attributeRef);
+    }
+    public sealed class PrintStringProperty : PrintProperty {
+        public PrintStringProperty(string attributeName);
+        public PrintStringProperty(string attributeName, object attributeValue);
+        public override object Value { get; set; }
+        protected sealed override void InternalDispose(bool disposing);
+        public static implicit operator string (PrintStringProperty attributeRef);
+    }
+    public sealed class PrintSystemTypeProperty : PrintProperty {
+        public PrintSystemTypeProperty(string attributeName);
+        public PrintSystemTypeProperty(string attributeName, object attributeValue);
+        public override object Value { get; set; }
+        protected sealed override void InternalDispose(bool disposing);
+        public static implicit operator Type (PrintSystemTypeProperty attribRef);
+    }
+    public sealed class PrintThreadPriorityProperty : PrintProperty {
+        public PrintThreadPriorityProperty(string attributeName);
+        public PrintThreadPriorityProperty(string attributeName, object attributeValue);
+        public override object Value { get; set; }
+        protected sealed override void InternalDispose(bool disposing);
+        public static implicit operator ThreadPriority (PrintThreadPriorityProperty attribRef);
+    }
+    public sealed class PrintTicketProperty : PrintProperty {
+        public PrintTicketProperty(string attributeName);
+        public PrintTicketProperty(string attributeName, object attributeValue);
+        public override object Value { get; set; }
+        protected sealed override void InternalDispose(bool disposing);
+        public static implicit operator PrintTicket (PrintTicketProperty attribRef);
+    }
+}
```

