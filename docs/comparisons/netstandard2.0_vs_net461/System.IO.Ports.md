# System.IO.Ports

``` diff
+namespace System.IO.Ports {
+    public enum Handshake {
+        None = 0,
+        RequestToSend = 2,
+        RequestToSendXOnXOff = 3,
+        XOnXOff = 1,
+    }
+    public enum Parity {
+        Even = 2,
+        Mark = 3,
+        None = 0,
+        Odd = 1,
+        Space = 4,
+    }
+    public enum SerialData {
+        Chars = 1,
+        Eof = 2,
+    }
+    public class SerialDataReceivedEventArgs : EventArgs {
+        public SerialData EventType { get; }
+    }
+    public delegate void SerialDataReceivedEventHandler(object sender, SerialDataReceivedEventArgs e);
+    public enum SerialError {
+        Frame = 8,
+        Overrun = 2,
+        RXOver = 1,
+        RXParity = 4,
+        TXFull = 256,
+    }
+    public class SerialErrorReceivedEventArgs : EventArgs {
+        public SerialError EventType { get; }
+    }
+    public delegate void SerialErrorReceivedEventHandler(object sender, SerialErrorReceivedEventArgs e);
+    public enum SerialPinChange {
+        Break = 64,
+        CDChanged = 32,
+        CtsChanged = 8,
+        DsrChanged = 16,
+        Ring = 256,
+    }
+    public class SerialPinChangedEventArgs : EventArgs {
+        public SerialPinChange EventType { get; }
+    }
+    public delegate void SerialPinChangedEventHandler(object sender, SerialPinChangedEventArgs e);
+    public class SerialPort : Component {
+        public const int InfiniteTimeout = -1;
+        public SerialPort();
+        public SerialPort(IContainer container);
+        public SerialPort(string portName);
+        public SerialPort(string portName, int baudRate);
+        public SerialPort(string portName, int baudRate, Parity parity);
+        public SerialPort(string portName, int baudRate, Parity parity, int dataBits);
+        public SerialPort(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits);
+        public Stream BaseStream { get; }
+        public int BaudRate { get; set; }
+        public bool BreakState { get; set; }
+        public int BytesToRead { get; }
+        public int BytesToWrite { get; }
+        public bool CDHolding { get; }
+        public bool CtsHolding { get; }
+        public int DataBits { get; set; }
+        public bool DiscardNull { get; set; }
+        public bool DsrHolding { get; }
+        public bool DtrEnable { get; set; }
+        public Encoding Encoding { get; set; }
+        public Handshake Handshake { get; set; }
+        public bool IsOpen { get; }
+        public string NewLine { get; set; }
+        public Parity Parity { get; set; }
+        public byte ParityReplace { get; set; }
+        public string PortName { get; set; }
+        public int ReadBufferSize { get; set; }
+        public int ReadTimeout { get; set; }
+        public int ReceivedBytesThreshold { get; set; }
+        public bool RtsEnable { get; set; }
+        public StopBits StopBits { get; set; }
+        public int WriteBufferSize { get; set; }
+        public int WriteTimeout { get; set; }
+        public event SerialDataReceivedEventHandler DataReceived;
+        public event SerialErrorReceivedEventHandler ErrorReceived;
+        public event SerialPinChangedEventHandler PinChanged;
+        public void Close();
+        public void DiscardInBuffer();
+        public void DiscardOutBuffer();
+        protected override void Dispose(bool disposing);
+        public static string[] GetPortNames();
+        public void Open();
+        public int Read(byte[] buffer, int offset, int count);
+        public int Read(char[] buffer, int offset, int count);
+        public int ReadByte();
+        public int ReadChar();
+        public string ReadExisting();
+        public string ReadLine();
+        public string ReadTo(string value);
+        public void Write(byte[] buffer, int offset, int count);
+        public void Write(char[] buffer, int offset, int count);
+        public void Write(string text);
+        public void WriteLine(string text);
+    }
+    public enum StopBits {
+        None = 0,
+        One = 1,
+        OnePointFive = 3,
+        Two = 2,
+    }
+}
```

