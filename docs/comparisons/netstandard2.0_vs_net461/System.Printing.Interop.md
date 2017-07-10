# System.Printing.Interop

``` diff
+namespace System.Printing.Interop {
+    public enum BaseDevModeType {
+        PrinterDefault = 1,
+        UserDefault = 0,
+    }
+    public sealed class PrintTicketConverter : IDisposable {
+        public PrintTicketConverter(string deviceName, int clientPrintSchemaVersion);
+        public static int MaxPrintSchemaVersion { get; }
+        public PrintTicket ConvertDevModeToPrintTicket(byte[] devMode);
+        public PrintTicket ConvertDevModeToPrintTicket(byte[] devMode, PrintTicketScope scope);
+        public byte[] ConvertPrintTicketToDevMode(PrintTicket printTicket, BaseDevModeType baseType);
+        public byte[] ConvertPrintTicketToDevMode(PrintTicket printTicket, BaseDevModeType baseType, PrintTicketScope scope);
+        public void Dispose();
+        void System.IDisposable.Dispose();
+    }
+}
```

