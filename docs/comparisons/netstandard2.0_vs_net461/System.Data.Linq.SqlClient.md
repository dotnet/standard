# System.Data.Linq.SqlClient

``` diff
+namespace System.Data.Linq.SqlClient {
+    public sealed class Sql2000Provider : SqlProvider {
+        public Sql2000Provider();
+    }
+    public sealed class Sql2005Provider : SqlProvider {
+        public Sql2005Provider();
+    }
+    public sealed class Sql2008Provider : SqlProvider {
+        public Sql2008Provider();
+    }
+    public static class SqlHelpers {
+        public static string GetStringContainsPattern(string text, char escape);
+        public static string GetStringEndsWithPattern(string text, char escape);
+        public static string GetStringStartsWithPattern(string text, char escape);
+        public static string TranslateVBLikePattern(string pattern, char escape);
+    }
+    public static class SqlMethods {
+        public static int DateDiffDay(DateTime startDate, DateTime endDate);
+        public static int DateDiffDay(DateTimeOffset startDate, DateTimeOffset endDate);
+        public static Nullable<int> DateDiffDay(Nullable<DateTime> startDate, Nullable<DateTime> endDate);
+        public static Nullable<int> DateDiffDay(Nullable<DateTimeOffset> startDate, Nullable<DateTimeOffset> endDate);
+        public static int DateDiffHour(DateTime startDate, DateTime endDate);
+        public static int DateDiffHour(DateTimeOffset startDate, DateTimeOffset endDate);
+        public static Nullable<int> DateDiffHour(Nullable<DateTime> startDate, Nullable<DateTime> endDate);
+        public static Nullable<int> DateDiffHour(Nullable<DateTimeOffset> startDate, Nullable<DateTimeOffset> endDate);
+        public static int DateDiffMicrosecond(DateTime startDate, DateTime endDate);
+        public static int DateDiffMicrosecond(DateTimeOffset startDate, DateTimeOffset endDate);
+        public static Nullable<int> DateDiffMicrosecond(Nullable<DateTime> startDate, Nullable<DateTime> endDate);
+        public static Nullable<int> DateDiffMicrosecond(Nullable<DateTimeOffset> startDate, Nullable<DateTimeOffset> endDate);
+        public static int DateDiffMillisecond(DateTime startDate, DateTime endDate);
+        public static int DateDiffMillisecond(DateTimeOffset startDate, DateTimeOffset endDate);
+        public static Nullable<int> DateDiffMillisecond(Nullable<DateTime> startDate, Nullable<DateTime> endDate);
+        public static Nullable<int> DateDiffMillisecond(Nullable<DateTimeOffset> startDate, Nullable<DateTimeOffset> endDate);
+        public static int DateDiffMinute(DateTime startDate, DateTime endDate);
+        public static int DateDiffMinute(DateTimeOffset startDate, DateTimeOffset endDate);
+        public static Nullable<int> DateDiffMinute(Nullable<DateTime> startDate, Nullable<DateTime> endDate);
+        public static Nullable<int> DateDiffMinute(Nullable<DateTimeOffset> startDate, Nullable<DateTimeOffset> endDate);
+        public static int DateDiffMonth(DateTime startDate, DateTime endDate);
+        public static int DateDiffMonth(DateTimeOffset startDate, DateTimeOffset endDate);
+        public static Nullable<int> DateDiffMonth(Nullable<DateTime> startDate, Nullable<DateTime> endDate);
+        public static Nullable<int> DateDiffMonth(Nullable<DateTimeOffset> startDate, Nullable<DateTimeOffset> endDate);
+        public static int DateDiffNanosecond(DateTime startDate, DateTime endDate);
+        public static int DateDiffNanosecond(DateTimeOffset startDate, DateTimeOffset endDate);
+        public static Nullable<int> DateDiffNanosecond(Nullable<DateTime> startDate, Nullable<DateTime> endDate);
+        public static Nullable<int> DateDiffNanosecond(Nullable<DateTimeOffset> startDate, Nullable<DateTimeOffset> endDate);
+        public static int DateDiffSecond(DateTime startDate, DateTime endDate);
+        public static int DateDiffSecond(DateTimeOffset startDate, DateTimeOffset endDate);
+        public static Nullable<int> DateDiffSecond(Nullable<DateTime> startDate, Nullable<DateTime> endDate);
+        public static Nullable<int> DateDiffSecond(Nullable<DateTimeOffset> startDate, Nullable<DateTimeOffset> endDate);
+        public static int DateDiffYear(DateTime startDate, DateTime endDate);
+        public static int DateDiffYear(DateTimeOffset startDate, DateTimeOffset endDate);
+        public static Nullable<int> DateDiffYear(Nullable<DateTime> startDate, Nullable<DateTime> endDate);
+        public static Nullable<int> DateDiffYear(Nullable<DateTimeOffset> startDate, Nullable<DateTimeOffset> endDate);
+        public static bool Like(string matchExpression, string pattern);
+        public static bool Like(string matchExpression, string pattern, char escapeCharacter);
+    }
+    public class SqlProvider : IConnectionUser, IDisposable, IProvider, IReaderProvider {
+        public SqlProvider();
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+    }
+}
```

