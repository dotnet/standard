# System.Data.Odbc

``` diff
+namespace System.Data.Odbc {
+    public sealed class OdbcCommand : DbCommand, ICloneable {
+        public OdbcCommand();
+        public OdbcCommand(string cmdText);
+        public OdbcCommand(string cmdText, OdbcConnection connection);
+        public OdbcCommand(string cmdText, OdbcConnection connection, OdbcTransaction transaction);
+        public override string CommandText { get; set; }
+        public override int CommandTimeout { get; set; }
+        public override CommandType CommandType { get; set; }
+        public new OdbcConnection Connection { get; set; }
+        protected override DbConnection DbConnection { get; set; }
+        protected override DbParameterCollection DbParameterCollection { get; }
+        protected override DbTransaction DbTransaction { get; set; }
+        public override bool DesignTimeVisible { get; set; }
+        public new OdbcParameterCollection Parameters { get; }
+        public new OdbcTransaction Transaction { get; set; }
+        public override UpdateRowSource UpdatedRowSource { get; set; }
+        public override void Cancel();
+        protected override DbParameter CreateDbParameter();
+        public new OdbcParameter CreateParameter();
+        protected override void Dispose(bool disposing);
+        protected override DbDataReader ExecuteDbDataReader(CommandBehavior behavior);
+        public override int ExecuteNonQuery();
+        public new OdbcDataReader ExecuteReader();
+        public new OdbcDataReader ExecuteReader(CommandBehavior behavior);
+        public override object ExecuteScalar();
+        public override void Prepare();
+        public void ResetCommandTimeout();
+        object System.ICloneable.Clone();
+    }
+    public sealed class OdbcCommandBuilder : DbCommandBuilder {
+        public OdbcCommandBuilder();
+        public OdbcCommandBuilder(OdbcDataAdapter adapter);
+        public new OdbcDataAdapter DataAdapter { get; set; }
+        protected override void ApplyParameterInfo(DbParameter parameter, DataRow datarow, StatementType statementType, bool whereClause);
+        public static void DeriveParameters(OdbcCommand command);
+        public new OdbcCommand GetDeleteCommand();
+        public new OdbcCommand GetDeleteCommand(bool useColumnsForParameterNames);
+        public new OdbcCommand GetInsertCommand();
+        public new OdbcCommand GetInsertCommand(bool useColumnsForParameterNames);
+        protected override string GetParameterName(int parameterOrdinal);
+        protected override string GetParameterName(string parameterName);
+        protected override string GetParameterPlaceholder(int parameterOrdinal);
+        public new OdbcCommand GetUpdateCommand();
+        public new OdbcCommand GetUpdateCommand(bool useColumnsForParameterNames);
+        public override string QuoteIdentifier(string unquotedIdentifier);
+        public string QuoteIdentifier(string unquotedIdentifier, OdbcConnection connection);
+        protected override void SetRowUpdatingHandler(DbDataAdapter adapter);
+        public override string UnquoteIdentifier(string quotedIdentifier);
+        public string UnquoteIdentifier(string quotedIdentifier, OdbcConnection connection);
+    }
+    public sealed class OdbcConnection : DbConnection, ICloneable {
+        public OdbcConnection();
+        public OdbcConnection(string connectionString);
+        public override string ConnectionString { get; set; }
+        public new int ConnectionTimeout { get; set; }
+        public override string Database { get; }
+        public override string DataSource { get; }
+        public string Driver { get; }
+        public override string ServerVersion { get; }
+        public override ConnectionState State { get; }
+        public event OdbcInfoMessageEventHandler InfoMessage;
+        protected override DbTransaction BeginDbTransaction(IsolationLevel isolationLevel);
+        public new OdbcTransaction BeginTransaction();
+        public new OdbcTransaction BeginTransaction(IsolationLevel isolevel);
+        public override void ChangeDatabase(string value);
+        public override void Close();
+        public new OdbcCommand CreateCommand();
+        protected override DbCommand CreateDbCommand();
+        protected override void Dispose(bool disposing);
+        public void EnlistDistributedTransaction(ITransaction transaction);
+        public override void EnlistTransaction(Transaction transaction);
+        public override DataTable GetSchema();
+        public override DataTable GetSchema(string collectionName);
+        public override DataTable GetSchema(string collectionName, string[] restrictionValues);
+        public override void Open();
+        public static void ReleaseObjectPool();
+        object System.ICloneable.Clone();
+    }
+    public sealed class OdbcConnectionStringBuilder : DbConnectionStringBuilder {
+        public OdbcConnectionStringBuilder();
+        public OdbcConnectionStringBuilder(string connectionString);
+        public string Driver { get; set; }
+        public string Dsn { get; set; }
+        public override ICollection Keys { get; }
+        public override object this[string keyword] { get; set; }
+        public override void Clear();
+        public override bool ContainsKey(string keyword);
+        public override bool Remove(string keyword);
+        public override bool TryGetValue(string keyword, out object value);
+    }
+    public sealed class OdbcDataAdapter : DbDataAdapter, ICloneable, IDataAdapter, IDbDataAdapter {
+        public OdbcDataAdapter();
+        public OdbcDataAdapter(OdbcCommand selectCommand);
+        public OdbcDataAdapter(string selectCommandText, OdbcConnection selectConnection);
+        public OdbcDataAdapter(string selectCommandText, string selectConnectionString);
+        public new OdbcCommand DeleteCommand { get; set; }
+        public new OdbcCommand InsertCommand { get; set; }
+        public new OdbcCommand SelectCommand { get; set; }
+        IDbCommand System.Data.IDbDataAdapter.DeleteCommand { get; set; }
+        IDbCommand System.Data.IDbDataAdapter.InsertCommand { get; set; }
+        IDbCommand System.Data.IDbDataAdapter.SelectCommand { get; set; }
+        IDbCommand System.Data.IDbDataAdapter.UpdateCommand { get; set; }
+        public new OdbcCommand UpdateCommand { get; set; }
+        public event OdbcRowUpdatedEventHandler RowUpdated;
+        public event OdbcRowUpdatingEventHandler RowUpdating;
+        protected override RowUpdatedEventArgs CreateRowUpdatedEvent(DataRow dataRow, IDbCommand command, StatementType statementType, DataTableMapping tableMapping);
+        protected override RowUpdatingEventArgs CreateRowUpdatingEvent(DataRow dataRow, IDbCommand command, StatementType statementType, DataTableMapping tableMapping);
+        protected override void OnRowUpdated(RowUpdatedEventArgs value);
+        protected override void OnRowUpdating(RowUpdatingEventArgs value);
+        object System.ICloneable.Clone();
+    }
+    public sealed class OdbcDataReader : DbDataReader {
+        public override int Depth { get; }
+        public override int FieldCount { get; }
+        public override bool HasRows { get; }
+        public override bool IsClosed { get; }
+        public override int RecordsAffected { get; }
+        public override object this[int i] { get; }
+        public override object this[string value] { get; }
+        public override void Close();
+        protected override void Dispose(bool disposing);
+        public override bool GetBoolean(int i);
+        public override byte GetByte(int i);
+        public override long GetBytes(int i, long dataIndex, byte[] buffer, int bufferIndex, int length);
+        public override char GetChar(int i);
+        public override long GetChars(int i, long dataIndex, char[] buffer, int bufferIndex, int length);
+        public override string GetDataTypeName(int i);
+        public DateTime GetDate(int i);
+        public override DateTime GetDateTime(int i);
+        public override decimal GetDecimal(int i);
+        public override double GetDouble(int i);
+        public override IEnumerator GetEnumerator();
+        public override Type GetFieldType(int i);
+        public override float GetFloat(int i);
+        public override Guid GetGuid(int i);
+        public override short GetInt16(int i);
+        public override int GetInt32(int i);
+        public override long GetInt64(int i);
+        public override string GetName(int i);
+        public override int GetOrdinal(string value);
+        public override DataTable GetSchemaTable();
+        public override string GetString(int i);
+        public TimeSpan GetTime(int i);
+        public override object GetValue(int i);
+        public override int GetValues(object[] values);
+        public override bool IsDBNull(int i);
+        public override bool NextResult();
+        public override bool Read();
+    }
+    public sealed class OdbcError {
+        public string Message { get; }
+        public int NativeError { get; }
+        public string Source { get; }
+        public string SQLState { get; }
+        public override string ToString();
+    }
+    public sealed class OdbcErrorCollection : ICollection, IEnumerable {
+        public int Count { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        public OdbcError this[int i] { get; }
+        public void CopyTo(Array array, int i);
+        public void CopyTo(OdbcError[] array, int i);
+        public IEnumerator GetEnumerator();
+    }
+    public sealed class OdbcException : DbException {
+        public OdbcErrorCollection Errors { get; }
+        public override string Source { get; }
+        public override void GetObjectData(SerializationInfo si, StreamingContext context);
+    }
+    public sealed class OdbcFactory : DbProviderFactory {
+        public static readonly OdbcFactory Instance;
+        public override DbCommand CreateCommand();
+        public override DbCommandBuilder CreateCommandBuilder();
+        public override DbConnection CreateConnection();
+        public override DbConnectionStringBuilder CreateConnectionStringBuilder();
+        public override DbDataAdapter CreateDataAdapter();
+        public override DbParameter CreateParameter();
+        public override CodeAccessPermission CreatePermission(PermissionState state);
+    }
+    public sealed class OdbcInfoMessageEventArgs : EventArgs {
+        public OdbcErrorCollection Errors { get; }
+        public string Message { get; }
+        public override string ToString();
+    }
+    public delegate void OdbcInfoMessageEventHandler(object sender, OdbcInfoMessageEventArgs e);
+    public static class OdbcMetaDataCollectionNames {
+        public static readonly string Columns;
+        public static readonly string Indexes;
+        public static readonly string ProcedureColumns;
+        public static readonly string ProcedureParameters;
+        public static readonly string Procedures;
+        public static readonly string Tables;
+        public static readonly string Views;
+    }
+    public static class OdbcMetaDataColumnNames {
+        public static readonly string BooleanFalseLiteral;
+        public static readonly string BooleanTrueLiteral;
+        public static readonly string SQLType;
+    }
+    public sealed class OdbcParameter : DbParameter, ICloneable, IDataParameter, IDbDataParameter {
+        public OdbcParameter();
+        public OdbcParameter(string name, OdbcType type);
+        public OdbcParameter(string name, OdbcType type, int size);
+        public OdbcParameter(string parameterName, OdbcType odbcType, int size, ParameterDirection parameterDirection, bool isNullable, byte precision, byte scale, string srcColumn, DataRowVersion srcVersion, object value);
+        public OdbcParameter(string parameterName, OdbcType odbcType, int size, ParameterDirection parameterDirection, byte precision, byte scale, string sourceColumn, DataRowVersion sourceVersion, bool sourceColumnNullMapping, object value);
+        public OdbcParameter(string name, OdbcType type, int size, string sourcecolumn);
+        public OdbcParameter(string name, object value);
+        public override DbType DbType { get; set; }
+        public override ParameterDirection Direction { get; set; }
+        public override bool IsNullable { get; set; }
+        public OdbcType OdbcType { get; set; }
+        public override string ParameterName { get; set; }
+        public new byte Precision { get; set; }
+        public new byte Scale { get; set; }
+        public override int Size { get; set; }
+        public override string SourceColumn { get; set; }
+        public override bool SourceColumnNullMapping { get; set; }
+        public override DataRowVersion SourceVersion { get; set; }
+        public override object Value { get; set; }
+        public override void ResetDbType();
+        public void ResetOdbcType();
+        object System.ICloneable.Clone();
+        public override string ToString();
+    }
+    public sealed class OdbcParameterCollection : DbParameterCollection {
+        public override int Count { get; }
+        public override bool IsFixedSize { get; }
+        public override bool IsReadOnly { get; }
+        public override bool IsSynchronized { get; }
+        public override object SyncRoot { get; }
+        public new OdbcParameter this[int index] { get; set; }
+        public new OdbcParameter this[string parameterName] { get; set; }
+        public OdbcParameter Add(OdbcParameter value);
+        public override int Add(object value);
+        public OdbcParameter Add(string parameterName, OdbcType odbcType);
+        public OdbcParameter Add(string parameterName, OdbcType odbcType, int size);
+        public OdbcParameter Add(string parameterName, OdbcType odbcType, int size, string sourceColumn);
+        public OdbcParameter Add(string parameterName, object value);
+        public override void AddRange(Array values);
+        public void AddRange(OdbcParameter[] values);
+        public OdbcParameter AddWithValue(string parameterName, object value);
+        public override void Clear();
+        public bool Contains(OdbcParameter value);
+        public override bool Contains(object value);
+        public override bool Contains(string value);
+        public override void CopyTo(Array array, int index);
+        public void CopyTo(OdbcParameter[] array, int index);
+        public override IEnumerator GetEnumerator();
+        protected override DbParameter GetParameter(int index);
+        protected override DbParameter GetParameter(string parameterName);
+        public int IndexOf(OdbcParameter value);
+        public override int IndexOf(object value);
+        public override int IndexOf(string parameterName);
+        public void Insert(int index, OdbcParameter value);
+        public override void Insert(int index, object value);
+        public void Remove(OdbcParameter value);
+        public override void Remove(object value);
+        public override void RemoveAt(int index);
+        public override void RemoveAt(string parameterName);
+        protected override void SetParameter(int index, DbParameter value);
+        protected override void SetParameter(string parameterName, DbParameter value);
+    }
+    public sealed class OdbcPermission : DBDataPermission {
+        public OdbcPermission();
+        public OdbcPermission(PermissionState state);
+        public OdbcPermission(PermissionState state, bool allowBlankPassword);
+        public override void Add(string connectionString, string restrictions, KeyRestrictionBehavior behavior);
+        public override IPermission Copy();
+    }
+    public sealed class OdbcPermissionAttribute : DBDataPermissionAttribute {
+        public OdbcPermissionAttribute(SecurityAction action);
+        public override IPermission CreatePermission();
+    }
+    public sealed class OdbcRowUpdatedEventArgs : RowUpdatedEventArgs {
+        public OdbcRowUpdatedEventArgs(DataRow row, IDbCommand command, StatementType statementType, DataTableMapping tableMapping);
+        public new OdbcCommand Command { get; }
+    }
+    public delegate void OdbcRowUpdatedEventHandler(object sender, OdbcRowUpdatedEventArgs e);
+    public sealed class OdbcRowUpdatingEventArgs : RowUpdatingEventArgs {
+        public OdbcRowUpdatingEventArgs(DataRow row, IDbCommand command, StatementType statementType, DataTableMapping tableMapping);
+        protected override IDbCommand BaseCommand { get; set; }
+        public new OdbcCommand Command { get; set; }
+    }
+    public delegate void OdbcRowUpdatingEventHandler(object sender, OdbcRowUpdatingEventArgs e);
+    public sealed class OdbcTransaction : DbTransaction {
+        public new OdbcConnection Connection { get; }
+        protected override DbConnection DbConnection { get; }
+        public override IsolationLevel IsolationLevel { get; }
+        public override void Commit();
+        protected override void Dispose(bool disposing);
+        public override void Rollback();
+    }
+    public enum OdbcType {
+        BigInt = 1,
+        Binary = 2,
+        Bit = 3,
+        Char = 4,
+        Date = 23,
+        DateTime = 5,
+        Decimal = 6,
+        Double = 8,
+        Image = 9,
+        Int = 10,
+        NChar = 11,
+        NText = 12,
+        Numeric = 7,
+        NVarChar = 13,
+        Real = 14,
+        SmallDateTime = 16,
+        SmallInt = 17,
+        Text = 18,
+        Time = 24,
+        Timestamp = 19,
+        TinyInt = 20,
+        UniqueIdentifier = 15,
+        VarBinary = 21,
+        VarChar = 22,
+    }
+}
```

