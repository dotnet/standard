/*
APIs removed/broken by this factoring:

*/
namespace System.Diagnostics
{
    public partial class ConsoleTraceListener : System.Diagnostics.TextWriterTraceListener
    {
        public ConsoleTraceListener() { }
        public ConsoleTraceListener(bool useErrorStream) { }
        public override void Close() { }
    }
    public partial class EventSchemaTraceListener : System.Diagnostics.TextWriterTraceListener
    {
        public EventSchemaTraceListener(string fileName) { }
        public EventSchemaTraceListener(string fileName, string name) { }
        public EventSchemaTraceListener(string fileName, string name, int bufferSize) { }
        public EventSchemaTraceListener(string fileName, string name, int bufferSize, System.Diagnostics.TraceLogRetentionOption logRetentionOption) { }
        public EventSchemaTraceListener(string fileName, string name, int bufferSize, System.Diagnostics.TraceLogRetentionOption logRetentionOption, long maximumFileSize) { }
        public EventSchemaTraceListener(string fileName, string name, int bufferSize, System.Diagnostics.TraceLogRetentionOption logRetentionOption, long maximumFileSize, int maximumNumberOfFiles) { }
        public int BufferSize { get { throw null; } }
        public override bool IsThreadSafe { get { throw null; } }
        public long MaximumFileSize { get { throw null; } }
        public int MaximumNumberOfFiles { get { throw null; } }
        public System.Diagnostics.TraceLogRetentionOption TraceLogRetentionOption { get { throw null; } }
        public new System.IO.TextWriter Writer { get { throw null; } set { } }
        public override void Close() { }
        public override void Fail(string message, string detailMessage) { }
        public override void Flush() { }
        public override void TraceData(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, object data) { }
        public override void TraceData(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, params object[] data) { }
        public override void TraceEvent(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, string message) { }
        public override void TraceEvent(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, string format, params object[] args) { }
        public override void TraceTransfer(System.Diagnostics.TraceEventCache eventCache, string source, int id, string message, System.Guid relatedActivityId) { }
        public override void Write(string message) { }
        public override void WriteLine(string message) { }
    }
    public enum TraceLogRetentionOption
    {
        LimitedCircularFiles = 1,
        LimitedSequentialFiles = 3,
        SingleFileBoundedSize = 4,
        SingleFileUnboundedSize = 2,
        UnlimitedSequentialFiles = 0,
    }
    public partial class UnescapedXmlDiagnosticData
    {
        public UnescapedXmlDiagnosticData(string xmlPayload) { }
        public string UnescapedXml { get { throw null; } set { } }
        public override string ToString() { throw null; }
    }
    public partial class XmlWriterTraceListener : System.Diagnostics.TextWriterTraceListener
    {
        public XmlWriterTraceListener(System.IO.Stream stream) { }
        public XmlWriterTraceListener(System.IO.Stream stream, string name) { }
        public XmlWriterTraceListener(System.IO.TextWriter writer) { }
        public XmlWriterTraceListener(System.IO.TextWriter writer, string name) { }
        public XmlWriterTraceListener(string filename) { }
        public XmlWriterTraceListener(string filename, string name) { }
        public override void Close() { }
        public override void Fail(string message, string detailMessage) { }
        public override void TraceData(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, object data) { }
        public override void TraceData(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, params object[] data) { }
        public override void TraceEvent(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, string message) { }
        public override void TraceEvent(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, string format, params object[] args) { }
        public override void TraceTransfer(System.Diagnostics.TraceEventCache eventCache, string source, int id, string message, System.Guid relatedActivityId) { }
        public override void Write(string message) { }
        public override void WriteLine(string message) { }
    }
}
