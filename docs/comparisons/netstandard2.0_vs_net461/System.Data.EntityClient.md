# System.Data.EntityClient

``` diff
+namespace System.Data.EntityClient {
+    public sealed class EntityCommand : DbCommand {
+        public EntityCommand();
+        public EntityCommand(string statement);
+        public EntityCommand(string statement, EntityConnection connection);
+        public EntityCommand(string statement, EntityConnection connection, EntityTransaction transaction);
+        public override string CommandText { get; set; }
+        public override int CommandTimeout { get; set; }
+        public DbCommandTree CommandTree { get; set; }
+        public override CommandType CommandType { get; set; }
+        public new EntityConnection Connection { get; set; }
+        protected override DbConnection DbConnection { get; set; }
+        protected override DbParameterCollection DbParameterCollection { get; }
+        protected override DbTransaction DbTransaction { get; set; }
+        public override bool DesignTimeVisible { get; set; }
+        public bool EnablePlanCaching { get; set; }
+        public new EntityParameterCollection Parameters { get; }
+        public new EntityTransaction Transaction { get; set; }
+        public override UpdateRowSource UpdatedRowSource { get; set; }
+        public override void Cancel();
+        protected override DbParameter CreateDbParameter();
+        public new EntityParameter CreateParameter();
+        protected override DbDataReader ExecuteDbDataReader(CommandBehavior behavior);
+        public override int ExecuteNonQuery();
+        public new EntityDataReader ExecuteReader();
+        public new EntityDataReader ExecuteReader(CommandBehavior behavior);
+        public override object ExecuteScalar();
+        public override void Prepare();
+        public string ToTraceString();
+    }
+    public sealed class EntityConnection : DbConnection {
+        public EntityConnection();
+        public EntityConnection(MetadataWorkspace workspace, DbConnection connection);
+        public EntityConnection(string connectionString);
+        public override string ConnectionString { get; set; }
+        public override int ConnectionTimeout { get; }
+        public override string Database { get; }
+        public override string DataSource { get; }
+        protected override DbProviderFactory DbProviderFactory { get; }
+        public override string ServerVersion { get; }
+        public override ConnectionState State { get; }
+        public DbConnection StoreConnection { get; }
+        protected override DbTransaction BeginDbTransaction(IsolationLevel isolationLevel);
+        public new EntityTransaction BeginTransaction();
+        public new EntityTransaction BeginTransaction(IsolationLevel isolationLevel);
+        public override void ChangeDatabase(string databaseName);
+        public override void Close();
+        public new EntityCommand CreateCommand();
+        protected override DbCommand CreateDbCommand();
+        protected override void Dispose(bool disposing);
+        public override void EnlistTransaction(Transaction transaction);
+        public MetadataWorkspace GetMetadataWorkspace();
+        public override void Open();
+    }
+    public sealed class EntityConnectionStringBuilder : DbConnectionStringBuilder {
+        public EntityConnectionStringBuilder();
+        public EntityConnectionStringBuilder(string connectionString);
+        public override bool IsFixedSize { get; }
+        public override ICollection Keys { get; }
+        public string Metadata { get; set; }
+        public string Name { get; set; }
+        public string Provider { get; set; }
+        public string ProviderConnectionString { get; set; }
+        public override object this[string keyword] { get; set; }
+        public override void Clear();
+        public override bool ContainsKey(string keyword);
+        public override bool Remove(string keyword);
+        public override bool TryGetValue(string keyword, out object value);
+    }
+    public class EntityDataReader : DbDataReader, IDataRecord, IExtendedDataRecord {
+        public DataRecordInfo DataRecordInfo { get; }
+        public override int Depth { get; }
+        public override int FieldCount { get; }
+        public override bool HasRows { get; }
+        public override bool IsClosed { get; }
+        public override int RecordsAffected { get; }
+        public override object this[int ordinal] { get; }
+        public override object this[string name] { get; }
+        public override int VisibleFieldCount { get; }
+        public override void Close();
+        protected override void Dispose(bool disposing);
+        public override bool GetBoolean(int ordinal);
+        public override byte GetByte(int ordinal);
+        public override long GetBytes(int ordinal, long dataOffset, byte[] buffer, int bufferOffset, int length);
+        public override char GetChar(int ordinal);
+        public override long GetChars(int ordinal, long dataOffset, char[] buffer, int bufferOffset, int length);
+        public DbDataReader GetDataReader(int i);
+        public DbDataRecord GetDataRecord(int i);
+        public override string GetDataTypeName(int ordinal);
+        public override DateTime GetDateTime(int ordinal);
+        protected override DbDataReader GetDbDataReader(int ordinal);
+        public override decimal GetDecimal(int ordinal);
+        public override double GetDouble(int ordinal);
+        public override IEnumerator GetEnumerator();
+        public override Type GetFieldType(int ordinal);
+        public override float GetFloat(int ordinal);
+        public override Guid GetGuid(int ordinal);
+        public override short GetInt16(int ordinal);
+        public override int GetInt32(int ordinal);
+        public override long GetInt64(int ordinal);
+        public override string GetName(int ordinal);
+        public override int GetOrdinal(string name);
+        public override Type GetProviderSpecificFieldType(int ordinal);
+        public override object GetProviderSpecificValue(int ordinal);
+        public override int GetProviderSpecificValues(object[] values);
+        public override DataTable GetSchemaTable();
+        public override string GetString(int ordinal);
+        public override object GetValue(int ordinal);
+        public override int GetValues(object[] values);
+        public override bool IsDBNull(int ordinal);
+        public override bool NextResult();
+        public override bool Read();
+    }
+    public sealed class EntityParameter : DbParameter, IDataParameter, IDbDataParameter {
+        public EntityParameter();
+        public EntityParameter(string parameterName, DbType dbType);
+        public EntityParameter(string parameterName, DbType dbType, int size);
+        public EntityParameter(string parameterName, DbType dbType, int size, ParameterDirection direction, bool isNullable, byte precision, byte scale, string sourceColumn, DataRowVersion sourceVersion, object value);
+        public EntityParameter(string parameterName, DbType dbType, int size, string sourceColumn);
+        public override DbType DbType { get; set; }
+        public override ParameterDirection Direction { get; set; }
+        public EdmType EdmType { get; set; }
+        public override bool IsNullable { get; set; }
+        public override string ParameterName { get; set; }
+        public new byte Precision { get; set; }
+        public new byte Scale { get; set; }
+        public override int Size { get; set; }
+        public override string SourceColumn { get; set; }
+        public override bool SourceColumnNullMapping { get; set; }
+        public override DataRowVersion SourceVersion { get; set; }
+        public override object Value { get; set; }
+        public override void ResetDbType();
+        public override string ToString();
+    }
+    public sealed class EntityParameterCollection : DbParameterCollection {
+        public override int Count { get; }
+        public override bool IsFixedSize { get; }
+        public override bool IsReadOnly { get; }
+        public override bool IsSynchronized { get; }
+        public override object SyncRoot { get; }
+        public new EntityParameter this[int index] { get; set; }
+        public new EntityParameter this[string parameterName] { get; set; }
+        public EntityParameter Add(EntityParameter value);
+        public override int Add(object value);
+        public EntityParameter Add(string parameterName, DbType dbType);
+        public EntityParameter Add(string parameterName, DbType dbType, int size);
+        public override void AddRange(Array values);
+        public void AddRange(EntityParameter[] values);
+        public EntityParameter AddWithValue(string parameterName, object value);
+        public override void Clear();
+        public override bool Contains(object value);
+        public override bool Contains(string parameterName);
+        public override void CopyTo(Array array, int index);
+        public void CopyTo(EntityParameter[] array, int index);
+        public override IEnumerator GetEnumerator();
+        protected override DbParameter GetParameter(int index);
+        protected override DbParameter GetParameter(string parameterName);
+        public int IndexOf(EntityParameter value);
+        public override int IndexOf(object value);
+        public override int IndexOf(string parameterName);
+        public void Insert(int index, EntityParameter value);
+        public override void Insert(int index, object value);
+        public void Remove(EntityParameter value);
+        public override void Remove(object value);
+        public override void RemoveAt(int index);
+        public override void RemoveAt(string parameterName);
+        protected override void SetParameter(int index, DbParameter value);
+        protected override void SetParameter(string parameterName, DbParameter value);
+    }
+    public sealed class EntityProviderFactory : DbProviderFactory, IServiceProvider {
+        public static readonly EntityProviderFactory Instance;
+        public override DbCommand CreateCommand();
+        public override DbCommandBuilder CreateCommandBuilder();
+        public override DbConnection CreateConnection();
+        public override DbConnectionStringBuilder CreateConnectionStringBuilder();
+        public override DbDataAdapter CreateDataAdapter();
+        public override DbParameter CreateParameter();
+        public override CodeAccessPermission CreatePermission(PermissionState state);
+        object System.IServiceProvider.GetService(Type serviceType);
+    }
+    public sealed class EntityTransaction : DbTransaction {
+        public new EntityConnection Connection { get; }
+        protected override DbConnection DbConnection { get; }
+        public override IsolationLevel IsolationLevel { get; }
+        public override void Commit();
+        protected override void Dispose(bool disposing);
+        public override void Rollback();
+    }
+}
```

