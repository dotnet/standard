# System.IO.Log

``` diff
+namespace System.IO.Log {
+    public sealed class FileRecordSequence : IDisposable, IRecordSequence {
+        public FileRecordSequence(string path);
+        public FileRecordSequence(string path, FileAccess access);
+        public FileRecordSequence(string path, FileAccess access, int size);
+        public SequenceNumber BaseSequenceNumber { get; }
+        public SequenceNumber LastSequenceNumber { get; }
+        public long MaximumRecordLength { get; }
+        public long ReservedBytes { get; }
+        public SequenceNumber RestartSequenceNumber { get; }
+        public bool RetryAppend { get; set; }
+        public event EventHandler<TailPinnedEventArgs> TailPinned;
+        public void AdvanceBaseSequenceNumber(SequenceNumber newBaseSequenceNumber);
+        public SequenceNumber Append(ArraySegment<byte> data, SequenceNumber nextUndoRecord, SequenceNumber previousRecord, RecordAppendOptions recordAppendOptions);
+        public SequenceNumber Append(ArraySegment<byte> data, SequenceNumber nextUndoRecord, SequenceNumber previousRecord, RecordAppendOptions recordAppendOptions, ReservationCollection reservations);
+        public SequenceNumber Append(IList<ArraySegment<byte>> data, SequenceNumber nextUndoRecord, SequenceNumber previousRecord, RecordAppendOptions recordAppendOptions);
+        public SequenceNumber Append(IList<ArraySegment<byte>> data, SequenceNumber nextUndoRecord, SequenceNumber previousRecord, RecordAppendOptions recordAppendOptions, ReservationCollection reservations);
+        public IAsyncResult BeginAppend(ArraySegment<byte> data, SequenceNumber nextUndoRecord, SequenceNumber previousRecord, RecordAppendOptions recordAppendOptions, AsyncCallback callback, object state);
+        public IAsyncResult BeginAppend(ArraySegment<byte> data, SequenceNumber nextUndoRecord, SequenceNumber previousRecord, RecordAppendOptions recordAppendOptions, ReservationCollection reservations, AsyncCallback callback, object state);
+        public IAsyncResult BeginAppend(IList<ArraySegment<byte>> data, SequenceNumber nextUndoRecord, SequenceNumber previousRecord, RecordAppendOptions recordAppendOptions, AsyncCallback callback, object state);
+        public IAsyncResult BeginAppend(IList<ArraySegment<byte>> data, SequenceNumber nextUndoRecord, SequenceNumber previousRecord, RecordAppendOptions recordAppendOptions, ReservationCollection reservations, AsyncCallback callback, object state);
+        public IAsyncResult BeginFlush(SequenceNumber sequenceNumber, AsyncCallback callback, object state);
+        public IAsyncResult BeginReserveAndAppend(ArraySegment<byte> data, SequenceNumber nextUndoRecord, SequenceNumber previousRecord, RecordAppendOptions recordAppendOptions, ReservationCollection reservationCollection, long[] reservations, AsyncCallback callback, object state);
+        public IAsyncResult BeginReserveAndAppend(IList<ArraySegment<byte>> data, SequenceNumber nextUndoRecord, SequenceNumber previousRecord, RecordAppendOptions recordAppendOptions, ReservationCollection reservationCollection, long[] reservations, AsyncCallback callback, object state);
+        public IAsyncResult BeginWriteRestartArea(ArraySegment<byte> data, SequenceNumber newBaseSeqNum, ReservationCollection reservation, AsyncCallback callback, object state);
+        public IAsyncResult BeginWriteRestartArea(IList<ArraySegment<byte>> data, SequenceNumber newBaseSeqNum, ReservationCollection reservation, AsyncCallback callback, object state);
+        public ReservationCollection CreateReservationCollection();
+        public void Dispose();
+        public SequenceNumber EndAppend(IAsyncResult result);
+        public SequenceNumber EndFlush(IAsyncResult result);
+        public SequenceNumber EndReserveAndAppend(IAsyncResult result);
+        public SequenceNumber EndWriteRestartArea(IAsyncResult result);
+        public SequenceNumber Flush();
+        public SequenceNumber Flush(SequenceNumber sequenceNumber);
+        public IEnumerable<LogRecord> ReadLogRecords(SequenceNumber start, LogRecordEnumeratorType logRecordEnum);
+        public IEnumerable<LogRecord> ReadRestartAreas();
+        public SequenceNumber ReserveAndAppend(ArraySegment<byte> data, SequenceNumber nextUndoRecord, SequenceNumber previousRecord, RecordAppendOptions recordAppendOptions, ReservationCollection reservationCollection, params long[] reservations);
+        public SequenceNumber ReserveAndAppend(IList<ArraySegment<byte>> data, SequenceNumber nextUndoRecord, SequenceNumber previousRecord, RecordAppendOptions recordAppendOptions, ReservationCollection reservationCollection, params long[] reservations);
+        public SequenceNumber WriteRestartArea(ArraySegment<byte> data);
+        public SequenceNumber WriteRestartArea(ArraySegment<byte> data, SequenceNumber newBaseSeqNum);
+        public SequenceNumber WriteRestartArea(ArraySegment<byte> data, SequenceNumber newBaseSeqNum, ReservationCollection reservations);
+        public SequenceNumber WriteRestartArea(IList<ArraySegment<byte>> data);
+        public SequenceNumber WriteRestartArea(IList<ArraySegment<byte>> data, SequenceNumber newBaseSeqNum);
+        public SequenceNumber WriteRestartArea(IList<ArraySegment<byte>> data, SequenceNumber newBaseSeqNum, ReservationCollection reservations);
+    }
+    public sealed class FileRegion {
+        public long FileLength { get; }
+        public long Offset { get; }
+        public string Path { get; }
+        public Stream GetStream();
+    }
+    public interface IRecordSequence : IDisposable {
+        SequenceNumber BaseSequenceNumber { get; }
+        SequenceNumber LastSequenceNumber { get; }
+        long MaximumRecordLength { get; }
+        long ReservedBytes { get; }
+        SequenceNumber RestartSequenceNumber { get; }
+        bool RetryAppend { get; set; }
+        event EventHandler<TailPinnedEventArgs> TailPinned;
+        void AdvanceBaseSequenceNumber(SequenceNumber newBaseSequenceNumber);
+        SequenceNumber Append(ArraySegment<byte> data, SequenceNumber nextUndoRecord, SequenceNumber previousRecord, RecordAppendOptions recordAppendOptions);
+        SequenceNumber Append(ArraySegment<byte> data, SequenceNumber nextUndoRecord, SequenceNumber previousRecord, RecordAppendOptions recordAppendOptions, ReservationCollection reservations);
+        SequenceNumber Append(IList<ArraySegment<byte>> data, SequenceNumber nextUndoRecord, SequenceNumber previousRecord, RecordAppendOptions recordAppendOptions);
+        SequenceNumber Append(IList<ArraySegment<byte>> data, SequenceNumber nextUndoRecord, SequenceNumber previousRecord, RecordAppendOptions recordAppendOptions, ReservationCollection reservations);
+        IAsyncResult BeginAppend(ArraySegment<byte> data, SequenceNumber nextUndoRecord, SequenceNumber previousRecord, RecordAppendOptions recordAppendOptions, AsyncCallback callback, object state);
+        IAsyncResult BeginAppend(ArraySegment<byte> data, SequenceNumber nextUndoRecord, SequenceNumber previousRecord, RecordAppendOptions recordAppendOptions, ReservationCollection reservations, AsyncCallback callback, object state);
+        IAsyncResult BeginAppend(IList<ArraySegment<byte>> data, SequenceNumber nextUndoRecord, SequenceNumber previousRecord, RecordAppendOptions recordAppendOptions, AsyncCallback callback, object state);
+        IAsyncResult BeginAppend(IList<ArraySegment<byte>> data, SequenceNumber nextUndoRecord, SequenceNumber previousUndoRecord, RecordAppendOptions recordAppendOptions, ReservationCollection reservations, AsyncCallback callback, object state);
+        IAsyncResult BeginFlush(SequenceNumber sequenceNumber, AsyncCallback callback, object state);
+        IAsyncResult BeginReserveAndAppend(ArraySegment<byte> data, SequenceNumber nextUndoRecord, SequenceNumber previousRecord, RecordAppendOptions recordAppendOptions, ReservationCollection reservationCollection, long[] reservations, AsyncCallback callback, object state);
+        IAsyncResult BeginReserveAndAppend(IList<ArraySegment<byte>> data, SequenceNumber nextUndoRecord, SequenceNumber previousRecord, RecordAppendOptions recordAppendOptions, ReservationCollection reservationCollection, long[] reservations, AsyncCallback callback, object state);
+        IAsyncResult BeginWriteRestartArea(ArraySegment<byte> data, SequenceNumber newBaseSequenceNumber, ReservationCollection reservation, AsyncCallback callback, object state);
+        IAsyncResult BeginWriteRestartArea(IList<ArraySegment<byte>> data, SequenceNumber newBaseSequenceNumber, ReservationCollection reservation, AsyncCallback callback, object state);
+        ReservationCollection CreateReservationCollection();
+        SequenceNumber EndAppend(IAsyncResult result);
+        SequenceNumber EndFlush(IAsyncResult result);
+        SequenceNumber EndReserveAndAppend(IAsyncResult result);
+        SequenceNumber EndWriteRestartArea(IAsyncResult result);
+        SequenceNumber Flush();
+        SequenceNumber Flush(SequenceNumber sequenceNumber);
+        IEnumerable<LogRecord> ReadLogRecords(SequenceNumber start, LogRecordEnumeratorType logRecordEnum);
+        IEnumerable<LogRecord> ReadRestartAreas();
+        SequenceNumber ReserveAndAppend(ArraySegment<byte> data, SequenceNumber nextUndoRecord, SequenceNumber previousRecord, RecordAppendOptions recordAppendOptions, ReservationCollection reservationCollection, params long[] reservations);
+        SequenceNumber ReserveAndAppend(IList<ArraySegment<byte>> data, SequenceNumber nextUndoRecord, SequenceNumber previousRecord, RecordAppendOptions recordAppendOptions, ReservationCollection reservationCollection, params long[] reservations);
+        SequenceNumber WriteRestartArea(ArraySegment<byte> data);
+        SequenceNumber WriteRestartArea(ArraySegment<byte> data, SequenceNumber newBaseSequenceNumber);
+        SequenceNumber WriteRestartArea(ArraySegment<byte> data, SequenceNumber newBaseSequenceNumber, ReservationCollection reservation);
+        SequenceNumber WriteRestartArea(IList<ArraySegment<byte>> data);
+        SequenceNumber WriteRestartArea(IList<ArraySegment<byte>> data, SequenceNumber newBaseSequenceNumber);
+        SequenceNumber WriteRestartArea(IList<ArraySegment<byte>> data, SequenceNumber newBaseSequenceNumber, ReservationCollection reservation);
+    }
+    public sealed class LogArchiveSnapshot {
+        public IEnumerable<FileRegion> ArchiveRegions { get; }
+        public SequenceNumber ArchiveTail { get; }
+        public SequenceNumber BaseSequenceNumber { get; }
+        public SequenceNumber LastSequenceNumber { get; }
+    }
+    public sealed class LogExtent {
+        public string Path { get; }
+        public long Size { get; }
+        public LogExtentState State { get; }
+    }
+    public sealed class LogExtentCollection : IEnumerable, IEnumerable<LogExtent> {
+        public int Count { get; }
+        public int FreeCount { get; }
+        public void Add(string path);
+        public void Add(string path, long size);
+        public IEnumerator<LogExtent> GetEnumerator();
+        public void Remove(LogExtent extent, bool force);
+        public void Remove(string path, bool force);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+    }
+    public enum LogExtentState {
+        Active = 4,
+        ActivePendingDelete = 8,
+        Inactive = 2,
+        Initializing = 1,
+        PendingArchive = 16,
+        PendingArchiveAndDelete = 32,
+        Unknown = 0,
+    }
+    public sealed class LogPolicy {
+        public bool AutoGrow { get; set; }
+        public int AutoShrinkPercentage { get; set; }
+        public PolicyUnit GrowthRate { get; set; }
+        public int MaximumExtentCount { get; set; }
+        public int MinimumExtentCount { get; set; }
+        public string NewExtentPrefix { get; set; }
+        public long NextExtentSuffix { get; set; }
+        public PolicyUnit PinnedTailThreshold { get; set; }
+        public void Commit();
+        public void Refresh();
+    }
+    public abstract class LogRecord : IDisposable {
+        protected LogRecord();
+        public abstract Stream Data { get; }
+        public abstract SequenceNumber Previous { get; }
+        public abstract SequenceNumber SequenceNumber { get; }
+        public abstract SequenceNumber User { get; }
+        public abstract void Dispose();
+    }
+    public enum LogRecordEnumeratorType {
+        Next = 2,
+        Previous = 1,
+        User = 0,
+    }
+    public sealed class LogRecordSequence : IDisposable, IRecordSequence {
+        public LogRecordSequence(LogStore logStore);
+        public LogRecordSequence(LogStore logStore, int bufferSize, int bufferCount);
+        public LogRecordSequence(string path, FileMode mode);
+        public LogRecordSequence(string path, FileMode mode, FileAccess access);
+        public LogRecordSequence(string path, FileMode mode, FileAccess access, FileShare share);
+        public LogRecordSequence(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, int bufferCount);
+        public LogRecordSequence(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, int bufferCount, FileSecurity fileSecurity);
+        public SequenceNumber BaseSequenceNumber { get; }
+        public SequenceNumber LastSequenceNumber { get; }
+        public LogStore LogStore { get; }
+        public long MaximumRecordLength { get; }
+        public long ReservedBytes { get; }
+        public SequenceNumber RestartSequenceNumber { get; }
+        public bool RetryAppend { get; set; }
+        public event EventHandler<TailPinnedEventArgs> TailPinned;
+        public void AdvanceBaseSequenceNumber(SequenceNumber newBaseSequenceNumber);
+        public SequenceNumber Append(ArraySegment<byte> data, SequenceNumber nextUndoRecord, SequenceNumber previousRecord, RecordAppendOptions recordAppendOptions);
+        public SequenceNumber Append(ArraySegment<byte> data, SequenceNumber nextUndoRecord, SequenceNumber previousRecord, RecordAppendOptions recordAppendOptions, ReservationCollection reservations);
+        public SequenceNumber Append(IList<ArraySegment<byte>> data, SequenceNumber userRecord, SequenceNumber previousRecord, RecordAppendOptions recordAppendOptions);
+        public SequenceNumber Append(IList<ArraySegment<byte>> data, SequenceNumber userRecord, SequenceNumber previousRecord, RecordAppendOptions recordAppendOptions, ReservationCollection reservations);
+        public IAsyncResult BeginAppend(ArraySegment<byte> data, SequenceNumber nextUndoRecord, SequenceNumber previousRecord, RecordAppendOptions recordAppendOptions, AsyncCallback callback, object state);
+        public IAsyncResult BeginAppend(ArraySegment<byte> data, SequenceNumber nextUndoRecord, SequenceNumber previousRecord, RecordAppendOptions recordAppendOptions, ReservationCollection reservations, AsyncCallback callback, object state);
+        public IAsyncResult BeginAppend(IList<ArraySegment<byte>> data, SequenceNumber userRecord, SequenceNumber previousRecord, RecordAppendOptions recordAppendOptions, AsyncCallback callback, object state);
+        public IAsyncResult BeginAppend(IList<ArraySegment<byte>> data, SequenceNumber userRecord, SequenceNumber previousRecord, RecordAppendOptions recordAppendOptions, ReservationCollection reservations, AsyncCallback callback, object state);
+        public IAsyncResult BeginFlush(SequenceNumber sequenceNumber, AsyncCallback callback, object state);
+        public IAsyncResult BeginReserveAndAppend(ArraySegment<byte> data, SequenceNumber nextUndoRecord, SequenceNumber previousRecord, RecordAppendOptions recordAppendOptions, ReservationCollection reservationCollection, long[] reservations, AsyncCallback callback, object state);
+        public IAsyncResult BeginReserveAndAppend(IList<ArraySegment<byte>> data, SequenceNumber userRecord, SequenceNumber previousRecord, RecordAppendOptions recordAppendOptions, ReservationCollection reservationCollection, long[] reservations, AsyncCallback callback, object state);
+        public IAsyncResult BeginWriteRestartArea(ArraySegment<byte> data, SequenceNumber newBaseSeqNum, ReservationCollection reservation, AsyncCallback callback, object state);
+        public IAsyncResult BeginWriteRestartArea(IList<ArraySegment<byte>> data, SequenceNumber newBaseSeqNum, ReservationCollection reservationCollection, AsyncCallback callback, object state);
+        public ReservationCollection CreateReservationCollection();
+        public void Dispose();
+        public SequenceNumber EndAppend(IAsyncResult result);
+        public SequenceNumber EndFlush(IAsyncResult result);
+        public SequenceNumber EndReserveAndAppend(IAsyncResult result);
+        public SequenceNumber EndWriteRestartArea(IAsyncResult result);
+        public SequenceNumber Flush();
+        public SequenceNumber Flush(SequenceNumber sequenceNumber);
+        public IEnumerable<LogRecord> ReadLogRecords(SequenceNumber start, LogRecordEnumeratorType logRecordEnum);
+        public IEnumerable<LogRecord> ReadRestartAreas();
+        public SequenceNumber ReserveAndAppend(ArraySegment<byte> data, SequenceNumber nextUndoRecord, SequenceNumber previousRecord, RecordAppendOptions recordAppendOptions, ReservationCollection reservationCollection, params long[] reservations);
+        public SequenceNumber ReserveAndAppend(IList<ArraySegment<byte>> data, SequenceNumber userRecord, SequenceNumber previousRecord, RecordAppendOptions recordAppendOptions, ReservationCollection reservationCollection, params long[] reservations);
+        public void SetLastRecord(SequenceNumber sequenceNumber);
+        public SequenceNumber WriteRestartArea(ArraySegment<byte> data);
+        public SequenceNumber WriteRestartArea(ArraySegment<byte> data, SequenceNumber newBaseSeqNum);
+        public SequenceNumber WriteRestartArea(ArraySegment<byte> data, SequenceNumber newBaseSeqNum, ReservationCollection reservations);
+        public SequenceNumber WriteRestartArea(IList<ArraySegment<byte>> data);
+        public SequenceNumber WriteRestartArea(IList<ArraySegment<byte>> data, SequenceNumber newBaseSeqNum);
+        public SequenceNumber WriteRestartArea(IList<ArraySegment<byte>> data, SequenceNumber newBaseSeqNum, ReservationCollection reservationCollection);
+    }
+    public sealed class LogStore : IDisposable {
+        public LogStore(SafeFileHandle handle);
+        public LogStore(string path, FileMode mode);
+        public LogStore(string path, FileMode mode, FileAccess access);
+        public LogStore(string path, FileMode mode, FileAccess access, FileShare share);
+        public LogStore(string path, FileMode mode, FileAccess access, FileShare share, FileSecurity fileSecurity);
+        public bool Archivable { get; set; }
+        public SequenceNumber BaseSequenceNumber { get; }
+        public LogExtentCollection Extents { get; }
+        public long FreeBytes { get; }
+        public SafeFileHandle Handle { get; }
+        public SequenceNumber LastSequenceNumber { get; }
+        public long Length { get; }
+        public LogPolicy Policy { get; }
+        public int StreamCount { get; }
+        public LogArchiveSnapshot CreateLogArchiveSnapshot();
+        public LogArchiveSnapshot CreateLogArchiveSnapshot(SequenceNumber first, SequenceNumber last);
+        public static void Delete(string path);
+        public void Dispose();
+        public void SetArchiveTail(SequenceNumber archiveTail);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct PolicyUnit {
+        public PolicyUnit(long value, PolicyUnitType type);
+        public PolicyUnitType Type { get; }
+        public long Value { get; }
+        public override bool Equals(object obj);
+        public static PolicyUnit Extents(long value);
+        public override int GetHashCode();
+        public static bool operator ==(PolicyUnit left, PolicyUnit right);
+        public static bool operator !=(PolicyUnit left, PolicyUnit right);
+        public static PolicyUnit Percentage(long value);
+        public override string ToString();
+    }
+    public enum PolicyUnitType {
+        Extents = 0,
+        Percentage = 1,
+    }
+    public enum RecordAppendOptions {
+        ForceAppend = 1,
+        ForceFlush = 2,
+        None = 0,
+    }
+    public abstract class ReservationCollection : ICollection<long>, IEnumerable, IEnumerable<long> {
+        protected ReservationCollection();
+        public int Count { get; }
+        public bool IsReadOnly { get; }
+        public void Add(long size);
+        public void Clear();
+        public bool Contains(long size);
+        public void CopyTo(long[] array, int arrayIndex);
+        ~ReservationCollection();
+        protected abstract void FreeReservation(long size);
+        protected long GetBestMatchingReservation(long size);
+        public IEnumerator<long> GetEnumerator();
+        protected abstract void MakeReservation(long size);
+        public bool Remove(long item);
+        protected void ReservationFreed(long size);
+        protected void ReservationMade(long size);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+    }
+    public class ReservationNotFoundException : ArgumentException {
+        public ReservationNotFoundException();
+        protected ReservationNotFoundException(SerializationInfo info, StreamingContext context);
+        public ReservationNotFoundException(string message);
+        public ReservationNotFoundException(string message, Exception inner);
+    }
+    public class SequenceFullException : Exception {
+        public SequenceFullException();
+        protected SequenceFullException(SerializationInfo info, StreamingContext context);
+        public SequenceFullException(string message);
+        public SequenceFullException(string message, Exception inner);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct SequenceNumber : IComparable<SequenceNumber> {
+        public SequenceNumber(byte[] sequenceNumber);
+        public static SequenceNumber Invalid { get; }
+        public int CompareTo(SequenceNumber other);
+        public bool Equals(SequenceNumber other);
+        public override bool Equals(object other);
+        public byte[] GetBytes();
+        public override int GetHashCode();
+        public static bool operator ==(SequenceNumber c1, SequenceNumber c2);
+        public static bool operator >(SequenceNumber c1, SequenceNumber c2);
+        public static bool operator >=(SequenceNumber c1, SequenceNumber c2);
+        public static bool operator !=(SequenceNumber c1, SequenceNumber c2);
+        public static bool operator <(SequenceNumber c1, SequenceNumber c2);
+        public static bool operator <=(SequenceNumber c1, SequenceNumber c2);
+    }
+    public sealed class TailPinnedEventArgs : EventArgs {
+        public TailPinnedEventArgs(SequenceNumber sequenceNumber);
+        public SequenceNumber TargetSequenceNumber { get; }
+    }
+}
```

