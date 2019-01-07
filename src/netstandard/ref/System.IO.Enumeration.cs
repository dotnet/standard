namespace System.IO.Enumeration
{
    public ref partial struct FileSystemEntry
    {
        public System.IO.FileAttributes Attributes { get { throw null; } }
        public System.DateTimeOffset CreationTimeUtc { get { throw null; } }
        public System.ReadOnlySpan<char> Directory { get { throw null; } }
        public System.ReadOnlySpan<char> FileName { get { throw null; } }
        public bool IsDirectory { get { throw null; } }
        public bool IsHidden { get { throw null; } }
        public System.DateTimeOffset LastAccessTimeUtc { get { throw null; } }
        public System.DateTimeOffset LastWriteTimeUtc { get { throw null; } }
        public long Length { get { throw null; } }
        public System.ReadOnlySpan<char> OriginalRootDirectory { get { throw null; } }
        public System.ReadOnlySpan<char> RootDirectory { get { throw null; } }
        public System.IO.FileSystemInfo ToFileSystemInfo() { throw null; }
        public string ToFullPath() { throw null; }
        public string ToSpecifiedFullPath() { throw null; }
    }
    public partial class FileSystemEnumerable<TResult> : System.Collections.Generic.IEnumerable<TResult>, System.Collections.IEnumerable
    {
        public FileSystemEnumerable(string directory, System.IO.Enumeration.FileSystemEnumerable<TResult>.FindTransform transform, System.IO.EnumerationOptions options = null) { }
        public System.IO.Enumeration.FileSystemEnumerable<TResult>.FindPredicate ShouldIncludePredicate { get { throw null; } set { } }
        public System.IO.Enumeration.FileSystemEnumerable<TResult>.FindPredicate ShouldRecursePredicate { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerator<TResult> GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public delegate bool FindPredicate(ref System.IO.Enumeration.FileSystemEntry entry);
        public delegate TResult FindTransform(ref System.IO.Enumeration.FileSystemEntry entry);
    }
    public abstract partial class FileSystemEnumerator<TResult> : System.Runtime.ConstrainedExecution.CriticalFinalizerObject, System.Collections.Generic.IEnumerator<TResult>, System.Collections.IEnumerator, System.IDisposable
    {
        public FileSystemEnumerator(string directory, System.IO.EnumerationOptions options = null) { }
        public TResult Current { get { throw null; } }
        object System.Collections.IEnumerator.Current { get { throw null; } }
        protected virtual bool ContinueOnError(int error) { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public bool MoveNext() { throw null; }
        protected virtual void OnDirectoryFinished(System.ReadOnlySpan<char> directory) { }
        public void Reset() { }
        protected virtual bool ShouldIncludeEntry(ref System.IO.Enumeration.FileSystemEntry entry) { throw null; }
        protected virtual bool ShouldRecurseIntoEntry(ref System.IO.Enumeration.FileSystemEntry entry) { throw null; }
        protected abstract TResult TransformEntry(ref System.IO.Enumeration.FileSystemEntry entry);
    }
    public static partial class FileSystemName
    {
        public static bool MatchesSimpleExpression(System.ReadOnlySpan<char> expression, System.ReadOnlySpan<char> name, bool ignoreCase = true) { throw null; }
        public static bool MatchesWin32Expression(System.ReadOnlySpan<char> expression, System.ReadOnlySpan<char> name, bool ignoreCase = true) { throw null; }
        public static string TranslateWin32Expression(string expression) { throw null; }
    }
}
