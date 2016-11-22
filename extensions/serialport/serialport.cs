// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

/*
APIs removed/broken by this factoring:

*/

namespace System.IO.Ports
{
    public enum Handshake
    {
        None = 0,
        RequestToSend = 2,
        RequestToSendXOnXOff = 3,
        XOnXOff = 1,
    }
    public enum Parity
    {
        Even = 2,
        Mark = 3,
        None = 0,
        Odd = 1,
        Space = 4,
    }
    public enum SerialData
    {
        Chars = 1,
        Eof = 2,
    }
    public partial class SerialDataReceivedEventArgs : System.EventArgs
    {
        internal SerialDataReceivedEventArgs() { }
        public System.IO.Ports.SerialData EventType { get { throw null; } }
    }
    public delegate void SerialDataReceivedEventHandler(object sender, System.IO.Ports.SerialDataReceivedEventArgs e);
    public enum SerialError
    {
        Frame = 8,
        Overrun = 2,
        RXOver = 1,
        RXParity = 4,
        TXFull = 256,
    }
    public partial class SerialErrorReceivedEventArgs : System.EventArgs
    {
        internal SerialErrorReceivedEventArgs() { }
        public System.IO.Ports.SerialError EventType { get { throw null; } }
    }
    public delegate void SerialErrorReceivedEventHandler(object sender, System.IO.Ports.SerialErrorReceivedEventArgs e);
    public enum SerialPinChange
    {
        Break = 64,
        CDChanged = 32,
        CtsChanged = 8,
        DsrChanged = 16,
        Ring = 256,
    }
    public partial class SerialPinChangedEventArgs : System.EventArgs
    {
        internal SerialPinChangedEventArgs() { }
        public System.IO.Ports.SerialPinChange EventType { get { throw null; } }
    }
    public delegate void SerialPinChangedEventHandler(object sender, System.IO.Ports.SerialPinChangedEventArgs e);
    public partial class SerialPort : System.ComponentModel.Component
    {
        public const int InfiniteTimeout = -1;
        public SerialPort() { }
        public SerialPort(System.ComponentModel.IContainer container) { }
        public SerialPort(string portName) { }
        public SerialPort(string portName, int baudRate) { }
        public SerialPort(string portName, int baudRate, System.IO.Ports.Parity parity) { }
        public SerialPort(string portName, int baudRate, System.IO.Ports.Parity parity, int dataBits) { }
        public SerialPort(string portName, int baudRate, System.IO.Ports.Parity parity, int dataBits, System.IO.Ports.StopBits stopBits) { }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public System.IO.Stream BaseStream { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(true)]
        [System.ComponentModel.DefaultValueAttribute(9600)]
        public int BaudRate { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public bool BreakState { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public int BytesToRead { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public int BytesToWrite { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public bool CDHolding { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public bool CtsHolding { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(true)]
        [System.ComponentModel.DefaultValueAttribute(8)]
        public int DataBits { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(true)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool DiscardNull { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public bool DsrHolding { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(true)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool DtrEnable { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public System.Text.Encoding Encoding { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(true)]
        [System.ComponentModel.DefaultValueAttribute((System.IO.Ports.Handshake)(0))]
        public System.IO.Ports.Handshake Handshake { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public bool IsOpen { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute("\n")]
        public string NewLine { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(true)]
        [System.ComponentModel.DefaultValueAttribute((System.IO.Ports.Parity)(0))]
        public System.IO.Ports.Parity Parity { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(true)]
        [System.ComponentModel.DefaultValueAttribute((byte)63)]
        public byte ParityReplace { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(true)]
        [System.ComponentModel.DefaultValueAttribute("COM1")]
        public string PortName { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(true)]
        [System.ComponentModel.DefaultValueAttribute(4096)]
        public int ReadBufferSize { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(true)]
        [System.ComponentModel.DefaultValueAttribute(-1)]
        public int ReadTimeout { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(true)]
        [System.ComponentModel.DefaultValueAttribute(1)]
        public int ReceivedBytesThreshold { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(true)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool RtsEnable { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(true)]
        [System.ComponentModel.DefaultValueAttribute((System.IO.Ports.StopBits)(1))]
        public System.IO.Ports.StopBits StopBits { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(true)]
        [System.ComponentModel.DefaultValueAttribute(2048)]
        public int WriteBufferSize { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(true)]
        [System.ComponentModel.DefaultValueAttribute(-1)]
        public int WriteTimeout { get { throw null; } set { } }
        public event System.IO.Ports.SerialDataReceivedEventHandler DataReceived { add { } remove { } }
        public event System.IO.Ports.SerialErrorReceivedEventHandler ErrorReceived { add { } remove { } }
        public event System.IO.Ports.SerialPinChangedEventHandler PinChanged { add { } remove { } }
        public void Close() { }
        public void DiscardInBuffer() { }
        public void DiscardOutBuffer() { }
        protected override void Dispose(bool disposing) { }
        public static string[] GetPortNames() { throw null; }
        public void Open() { }
        public int Read(byte[] buffer, int offset, int count) { throw null; }
        public int Read(char[] buffer, int offset, int count) { throw null; }
        public int ReadByte() { throw null; }
        public int ReadChar() { throw null; }
        public string ReadExisting() { throw null; }
        public string ReadLine() { throw null; }
        public string ReadTo(string value) { throw null; }
        public void Write(byte[] buffer, int offset, int count) { }
        public void Write(char[] buffer, int offset, int count) { }
        public void Write(string text) { }
        public void WriteLine(string text) { }
    }
    public enum StopBits
    {
        None = 0,
        One = 1,
        OnePointFive = 3,
        Two = 2,
    }
}
