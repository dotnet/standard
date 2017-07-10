# System.Data.Sql

``` diff
+namespace System.Data.Sql {
+    public sealed class SqlDataSourceEnumerator : DbDataSourceEnumerator {
+        public static SqlDataSourceEnumerator Instance { get; }
+        public override DataTable GetDataSources();
+    }
+    public sealed class SqlNotificationRequest {
+        public SqlNotificationRequest();
+        public SqlNotificationRequest(string userData, string options, int timeout);
+        public string Options { get; set; }
+        public int Timeout { get; set; }
+        public string UserData { get; set; }
+    }
+}
```

