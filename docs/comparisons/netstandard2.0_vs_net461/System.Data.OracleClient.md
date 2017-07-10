# System.Data.OracleClient

``` diff
+namespace System.Data.OracleClient {
+    public sealed class OracleBFile : Stream, ICloneable, IDisposable, INullable {
+        public static readonly new OracleBFile Null;
+        public override bool CanRead { get; }
+        public override bool CanSeek { get; }
+        public override bool CanWrite { get; }
+        public OracleConnection Connection { get; }
+        public string DirectoryName { get; }
+        public bool FileExists { get; }
+        public string FileName { get; }
+        public bool IsNull { get; }
+        public override long Length { get; }
+        public override long Position { get; set; }
+        public object Value { get; }
+        public object Clone();
+        public long CopyTo(OracleLob destination);
+        public long CopyTo(OracleLob destination, long destinationOffset);
+        public long CopyTo(long sourceOffset, OracleLob destination, long destinationOffset, long amount);
+        protected override void Dispose(bool disposing);
+        public override void Flush();
+        public override int Read(byte[] buffer, int offset, int count);
+        public override long Seek(long offset, SeekOrigin origin);
+        public void SetFileName(string directory, string file);
+        public override void SetLength(long value);
+        public override void Write(byte[] buffer, int offset, int count);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct OracleBinary : IComparable, INullable {
+        public static readonly OracleBinary Null;
+        public OracleBinary(byte[] b);
+        public bool IsNull { get; }
+        public int Length { get; }
+        public byte this[int index] { get; }
+        public byte[] Value { get; }
+        public int CompareTo(object obj);
+        public static OracleBinary Concat(OracleBinary x, OracleBinary y);
+        public static OracleBoolean Equals(OracleBinary x, OracleBinary y);
+        public override bool Equals(object value);
+        public override int GetHashCode();
+        public static OracleBoolean GreaterThan(OracleBinary x, OracleBinary y);
+        public static OracleBoolean GreaterThanOrEqual(OracleBinary x, OracleBinary y);
+        public static OracleBoolean LessThan(OracleBinary x, OracleBinary y);
+        public static OracleBoolean LessThanOrEqual(OracleBinary x, OracleBinary y);
+        public static OracleBoolean NotEquals(OracleBinary x, OracleBinary y);
+        public static OracleBinary operator +(OracleBinary x, OracleBinary y);
+        public static OracleBoolean operator ==(OracleBinary x, OracleBinary y);
+        public static explicit operator byte[] (OracleBinary x);
+        public static OracleBoolean operator >(OracleBinary x, OracleBinary y);
+        public static OracleBoolean operator >=(OracleBinary x, OracleBinary y);
+        public static implicit operator OracleBinary (byte[] b);
+        public static OracleBoolean operator !=(OracleBinary x, OracleBinary y);
+        public static OracleBoolean operator <(OracleBinary x, OracleBinary y);
+        public static OracleBoolean operator <=(OracleBinary x, OracleBinary y);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct OracleBoolean : IComparable {
+        public static readonly OracleBoolean False;
+        public static readonly OracleBoolean Null;
+        public static readonly OracleBoolean One;
+        public static readonly OracleBoolean True;
+        public static readonly OracleBoolean Zero;
+        public OracleBoolean(bool value);
+        public OracleBoolean(int value);
+        public bool IsFalse { get; }
+        public bool IsNull { get; }
+        public bool IsTrue { get; }
+        public bool Value { get; }
+        public static OracleBoolean And(OracleBoolean x, OracleBoolean y);
+        public int CompareTo(object obj);
+        public static OracleBoolean Equals(OracleBoolean x, OracleBoolean y);
+        public override bool Equals(object value);
+        public override int GetHashCode();
+        public static OracleBoolean NotEquals(OracleBoolean x, OracleBoolean y);
+        public static OracleBoolean OnesComplement(OracleBoolean x);
+        public static OracleBoolean operator &(OracleBoolean x, OracleBoolean y);
+        public static OracleBoolean operator |(OracleBoolean x, OracleBoolean y);
+        public static OracleBoolean operator ==(OracleBoolean x, OracleBoolean y);
+        public static OracleBoolean operator ^(OracleBoolean x, OracleBoolean y);
+        public static explicit operator bool (OracleBoolean x);
+        public static explicit operator OracleBoolean (OracleNumber x);
+        public static explicit operator OracleBoolean (string x);
+        public static bool operator false(OracleBoolean x);
+        public static implicit operator OracleBoolean (bool x);
+        public static OracleBoolean operator !=(OracleBoolean x, OracleBoolean y);
+        public static OracleBoolean operator !(OracleBoolean x);
+        public static OracleBoolean operator ~(OracleBoolean x);
+        public static bool operator true(OracleBoolean x);
+        public static OracleBoolean Or(OracleBoolean x, OracleBoolean y);
+        public static OracleBoolean Parse(string s);
+        public override string ToString();
+        public static OracleBoolean Xor(OracleBoolean x, OracleBoolean y);
+    }
+    public sealed class OracleClientFactory : DbProviderFactory {
+        public static readonly OracleClientFactory Instance;
+        public override DbCommand CreateCommand();
+        public override DbCommandBuilder CreateCommandBuilder();
+        public override DbConnection CreateConnection();
+        public override DbConnectionStringBuilder CreateConnectionStringBuilder();
+        public override DbDataAdapter CreateDataAdapter();
+        public override DbParameter CreateParameter();
+        public override CodeAccessPermission CreatePermission(PermissionState state);
+    }
+    public sealed class OracleCommand : DbCommand, ICloneable {
+        public OracleCommand();
+        public OracleCommand(string commandText);
+        public OracleCommand(string commandText, OracleConnection connection);
+        public OracleCommand(string commandText, OracleConnection connection, OracleTransaction tx);
+        public override string CommandText { get; set; }
+        public override int CommandTimeout { get; set; }
+        public override CommandType CommandType { get; set; }
+        public new OracleConnection Connection { get; set; }
+        protected override DbConnection DbConnection { get; set; }
+        protected override DbParameterCollection DbParameterCollection { get; }
+        protected override DbTransaction DbTransaction { get; set; }
+        public override bool DesignTimeVisible { get; set; }
+        public new OracleParameterCollection Parameters { get; }
+        public new OracleTransaction Transaction { get; set; }
+        public override UpdateRowSource UpdatedRowSource { get; set; }
+        public override void Cancel();
+        public object Clone();
+        protected override DbParameter CreateDbParameter();
+        public new OracleParameter CreateParameter();
+        protected override DbDataReader ExecuteDbDataReader(CommandBehavior behavior);
+        public override int ExecuteNonQuery();
+        public int ExecuteOracleNonQuery(out OracleString rowid);
+        public object ExecuteOracleScalar();
+        public new OracleDataReader ExecuteReader();
+        public new OracleDataReader ExecuteReader(CommandBehavior behavior);
+        public override object ExecuteScalar();
+        public override void Prepare();
+        public void ResetCommandTimeout();
+    }
+    public sealed class OracleCommandBuilder : DbCommandBuilder {
+        public OracleCommandBuilder();
+        public OracleCommandBuilder(OracleDataAdapter adapter);
+        public override CatalogLocation CatalogLocation { get; set; }
+        public override string CatalogSeparator { get; set; }
+        public new OracleDataAdapter DataAdapter { get; set; }
+        public override string SchemaSeparator { get; set; }
+        protected override void ApplyParameterInfo(DbParameter parameter, DataRow datarow, StatementType statementType, bool whereClause);
+        public static void DeriveParameters(OracleCommand command);
+        public new OracleCommand GetDeleteCommand();
+        public new OracleCommand GetDeleteCommand(bool useColumnsForParameterNames);
+        public new OracleCommand GetInsertCommand();
+        public new OracleCommand GetInsertCommand(bool useColumnsForParameterNames);
+        protected override string GetParameterName(int parameterOrdinal);
+        protected override string GetParameterName(string parameterName);
+        protected override string GetParameterPlaceholder(int parameterOrdinal);
+        public new OracleCommand GetUpdateCommand();
+        public new OracleCommand GetUpdateCommand(bool useColumnsForParameterNames);
+        public override string QuoteIdentifier(string unquotedIdentifier);
+        protected override void SetRowUpdatingHandler(DbDataAdapter adapter);
+        public override string UnquoteIdentifier(string quotedIdentifier);
+    }
+    public sealed class OracleConnection : DbConnection, ICloneable {
+        public OracleConnection();
+        public OracleConnection(string connectionString);
+        public override string ConnectionString { get; set; }
+        public override int ConnectionTimeout { get; }
+        public override string Database { get; }
+        public override string DataSource { get; }
+        public override string ServerVersion { get; }
+        public override ConnectionState State { get; }
+        public event OracleInfoMessageEventHandler InfoMessage;
+        protected override DbTransaction BeginDbTransaction(IsolationLevel isolationLevel);
+        public new OracleTransaction BeginTransaction();
+        public new OracleTransaction BeginTransaction(IsolationLevel il);
+        public override void ChangeDatabase(string value);
+        public static void ClearAllPools();
+        public static void ClearPool(OracleConnection connection);
+        public override void Close();
+        public new OracleCommand CreateCommand();
+        protected override DbCommand CreateDbCommand();
+        protected override void Dispose(bool disposing);
+        public void EnlistDistributedTransaction(ITransaction distributedTransaction);
+        public override void EnlistTransaction(Transaction transaction);
+        public override DataTable GetSchema();
+        public override DataTable GetSchema(string collectionName);
+        public override DataTable GetSchema(string collectionName, string[] restrictionValues);
+        public override void Open();
+        object System.ICloneable.Clone();
+    }
+    public sealed class OracleConnectionStringBuilder : DbConnectionStringBuilder {
+        public OracleConnectionStringBuilder();
+        public OracleConnectionStringBuilder(string connectionString);
+        public string DataSource { get; set; }
+        public bool Enlist { get; set; }
+        public bool IntegratedSecurity { get; set; }
+        public override bool IsFixedSize { get; }
+        public override ICollection Keys { get; }
+        public int LoadBalanceTimeout { get; set; }
+        public int MaxPoolSize { get; set; }
+        public int MinPoolSize { get; set; }
+        public bool OmitOracleConnectionName { get; set; }
+        public string Password { get; set; }
+        public bool PersistSecurityInfo { get; set; }
+        public bool Pooling { get; set; }
+        public override object this[string keyword] { get; set; }
+        public bool Unicode { get; set; }
+        public string UserID { get; set; }
+        public override ICollection Values { get; }
+        public override void Clear();
+        public override bool ContainsKey(string keyword);
+        protected override void GetProperties(Hashtable propertyDescriptors);
+        public override bool Remove(string keyword);
+        public override bool ShouldSerialize(string keyword);
+        public override bool TryGetValue(string keyword, out object value);
+    }
+    public sealed class OracleDataAdapter : DbDataAdapter, ICloneable, IDataAdapter, IDbDataAdapter {
+        public OracleDataAdapter();
+        public OracleDataAdapter(OracleCommand selectCommand);
+        public OracleDataAdapter(string selectCommandText, OracleConnection selectConnection);
+        public OracleDataAdapter(string selectCommandText, string selectConnectionString);
+        public new OracleCommand DeleteCommand { get; set; }
+        public new OracleCommand InsertCommand { get; set; }
+        public new OracleCommand SelectCommand { get; set; }
+        IDbCommand System.Data.IDbDataAdapter.DeleteCommand { get; set; }
+        IDbCommand System.Data.IDbDataAdapter.InsertCommand { get; set; }
+        IDbCommand System.Data.IDbDataAdapter.SelectCommand { get; set; }
+        IDbCommand System.Data.IDbDataAdapter.UpdateCommand { get; set; }
+        public override int UpdateBatchSize { get; set; }
+        public new OracleCommand UpdateCommand { get; set; }
+        public event OracleRowUpdatedEventHandler RowUpdated;
+        public event OracleRowUpdatingEventHandler RowUpdating;
+        protected override int AddToBatch(IDbCommand command);
+        protected override void ClearBatch();
+        protected override RowUpdatedEventArgs CreateRowUpdatedEvent(DataRow dataRow, IDbCommand command, StatementType statementType, DataTableMapping tableMapping);
+        protected override RowUpdatingEventArgs CreateRowUpdatingEvent(DataRow dataRow, IDbCommand command, StatementType statementType, DataTableMapping tableMapping);
+        protected override int ExecuteBatch();
+        protected override IDataParameter GetBatchedParameter(int commandIdentifier, int parameterIndex);
+        protected override bool GetBatchedRecordsAffected(int commandIdentifier, out int recordsAffected, out Exception error);
+        protected override void InitializeBatching();
+        protected override void OnRowUpdated(RowUpdatedEventArgs value);
+        protected override void OnRowUpdating(RowUpdatingEventArgs value);
+        object System.ICloneable.Clone();
+        protected override void TerminateBatching();
+    }
+    public sealed class OracleDataReader : DbDataReader {
+        public override int Depth { get; }
+        public override int FieldCount { get; }
+        public override bool HasRows { get; }
+        public override bool IsClosed { get; }
+        public override int RecordsAffected { get; }
+        public override object this[int i] { get; }
+        public override object this[string name] { get; }
+        public override void Close();
+        public override bool GetBoolean(int i);
+        public override byte GetByte(int i);
+        public override long GetBytes(int i, long fieldOffset, byte[] buffer2, int bufferoffset, int length);
+        public override char GetChar(int i);
+        public override long GetChars(int i, long fieldOffset, char[] buffer2, int bufferoffset, int length);
+        public override string GetDataTypeName(int i);
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
+        public OracleBFile GetOracleBFile(int i);
+        public OracleBinary GetOracleBinary(int i);
+        public OracleDateTime GetOracleDateTime(int i);
+        public OracleLob GetOracleLob(int i);
+        public OracleMonthSpan GetOracleMonthSpan(int i);
+        public OracleNumber GetOracleNumber(int i);
+        public OracleString GetOracleString(int i);
+        public OracleTimeSpan GetOracleTimeSpan(int i);
+        public object GetOracleValue(int i);
+        public int GetOracleValues(object[] values);
+        public override int GetOrdinal(string name);
+        public override Type GetProviderSpecificFieldType(int i);
+        public override object GetProviderSpecificValue(int i);
+        public override int GetProviderSpecificValues(object[] values);
+        public override DataTable GetSchemaTable();
+        public override string GetString(int i);
+        public TimeSpan GetTimeSpan(int i);
+        public override object GetValue(int i);
+        public override int GetValues(object[] values);
+        public override bool IsDBNull(int i);
+        public override bool NextResult();
+        public override bool Read();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct OracleDateTime : IComparable, INullable {
+        public static readonly OracleDateTime MaxValue;
+        public static readonly OracleDateTime MinValue;
+        public static readonly OracleDateTime Null;
+        public OracleDateTime(OracleDateTime from);
+        public OracleDateTime(DateTime dt);
+        public OracleDateTime(int year, int month, int day);
+        public OracleDateTime(int year, int month, int day, Calendar calendar);
+        public OracleDateTime(int year, int month, int day, int hour, int minute, int second);
+        public OracleDateTime(int year, int month, int day, int hour, int minute, int second, Calendar calendar);
+        public OracleDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond);
+        public OracleDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar);
+        public OracleDateTime(long ticks);
+        public int Day { get; }
+        public int Hour { get; }
+        public bool IsNull { get; }
+        public int Millisecond { get; }
+        public int Minute { get; }
+        public int Month { get; }
+        public int Second { get; }
+        public DateTime Value { get; }
+        public int Year { get; }
+        public int CompareTo(object obj);
+        public static OracleBoolean Equals(OracleDateTime x, OracleDateTime y);
+        public override bool Equals(object value);
+        public override int GetHashCode();
+        public static OracleBoolean GreaterThan(OracleDateTime x, OracleDateTime y);
+        public static OracleBoolean GreaterThanOrEqual(OracleDateTime x, OracleDateTime y);
+        public static OracleBoolean LessThan(OracleDateTime x, OracleDateTime y);
+        public static OracleBoolean LessThanOrEqual(OracleDateTime x, OracleDateTime y);
+        public static OracleBoolean NotEquals(OracleDateTime x, OracleDateTime y);
+        public static OracleBoolean operator ==(OracleDateTime x, OracleDateTime y);
+        public static explicit operator DateTime (OracleDateTime x);
+        public static explicit operator OracleDateTime (string x);
+        public static OracleBoolean operator >(OracleDateTime x, OracleDateTime y);
+        public static OracleBoolean operator >=(OracleDateTime x, OracleDateTime y);
+        public static OracleBoolean operator !=(OracleDateTime x, OracleDateTime y);
+        public static OracleBoolean operator <(OracleDateTime x, OracleDateTime y);
+        public static OracleBoolean operator <=(OracleDateTime x, OracleDateTime y);
+        public static OracleDateTime Parse(string s);
+        public override string ToString();
+    }
+    public sealed class OracleException : DbException {
+        public int Code { get; }
+        public override void GetObjectData(SerializationInfo si, StreamingContext context);
+    }
+    public sealed class OracleInfoMessageEventArgs : EventArgs {
+        public int Code { get; }
+        public string Message { get; }
+        public string Source { get; }
+        public override string ToString();
+    }
+    public delegate void OracleInfoMessageEventHandler(object sender, OracleInfoMessageEventArgs e);
+    public sealed class OracleLob : Stream, ICloneable, IDisposable, INullable {
+        public static readonly new OracleLob Null;
+        public override bool CanRead { get; }
+        public override bool CanSeek { get; }
+        public override bool CanWrite { get; }
+        public int ChunkSize { get; }
+        public OracleConnection Connection { get; }
+        public bool IsBatched { get; }
+        public bool IsNull { get; }
+        public bool IsTemporary { get; }
+        public override long Length { get; }
+        public OracleType LobType { get; }
+        public override long Position { get; set; }
+        public object Value { get; }
+        public void Append(OracleLob source);
+        public void BeginBatch();
+        public void BeginBatch(OracleLobOpenMode mode);
+        public object Clone();
+        public long CopyTo(OracleLob destination);
+        public long CopyTo(OracleLob destination, long destinationOffset);
+        public long CopyTo(long sourceOffset, OracleLob destination, long destinationOffset, long amount);
+        protected override void Dispose(bool disposing);
+        public void EndBatch();
+        public long Erase();
+        public long Erase(long offset, long amount);
+        public override void Flush();
+        public override int Read(byte[] buffer, int offset, int count);
+        public override long Seek(long offset, SeekOrigin origin);
+        public override void SetLength(long value);
+        public override void Write(byte[] buffer, int offset, int count);
+        public override void WriteByte(byte value);
+    }
+    public enum OracleLobOpenMode {
+        ReadOnly = 1,
+        ReadWrite = 2,
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct OracleMonthSpan : IComparable, INullable {
+        public static readonly OracleMonthSpan MaxValue;
+        public static readonly OracleMonthSpan MinValue;
+        public static readonly OracleMonthSpan Null;
+        public OracleMonthSpan(OracleMonthSpan from);
+        public OracleMonthSpan(int months);
+        public OracleMonthSpan(int years, int months);
+        public bool IsNull { get; }
+        public int Value { get; }
+        public int CompareTo(object obj);
+        public static OracleBoolean Equals(OracleMonthSpan x, OracleMonthSpan y);
+        public override bool Equals(object value);
+        public override int GetHashCode();
+        public static OracleBoolean GreaterThan(OracleMonthSpan x, OracleMonthSpan y);
+        public static OracleBoolean GreaterThanOrEqual(OracleMonthSpan x, OracleMonthSpan y);
+        public static OracleBoolean LessThan(OracleMonthSpan x, OracleMonthSpan y);
+        public static OracleBoolean LessThanOrEqual(OracleMonthSpan x, OracleMonthSpan y);
+        public static OracleBoolean NotEquals(OracleMonthSpan x, OracleMonthSpan y);
+        public static OracleBoolean operator ==(OracleMonthSpan x, OracleMonthSpan y);
+        public static explicit operator int (OracleMonthSpan x);
+        public static explicit operator OracleMonthSpan (string x);
+        public static OracleBoolean operator >(OracleMonthSpan x, OracleMonthSpan y);
+        public static OracleBoolean operator >=(OracleMonthSpan x, OracleMonthSpan y);
+        public static OracleBoolean operator !=(OracleMonthSpan x, OracleMonthSpan y);
+        public static OracleBoolean operator <(OracleMonthSpan x, OracleMonthSpan y);
+        public static OracleBoolean operator <=(OracleMonthSpan x, OracleMonthSpan y);
+        public static OracleMonthSpan Parse(string s);
+        public override string ToString();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct OracleNumber : IComparable, INullable {
+        public static readonly OracleNumber E;
+        public static readonly OracleNumber MaxValue;
+        public static readonly OracleNumber MinusOne;
+        public static readonly OracleNumber MinValue;
+        public static readonly OracleNumber Null;
+        public static readonly OracleNumber One;
+        public static readonly OracleNumber PI;
+        public static readonly OracleNumber Zero;
+        public static readonly int MaxPrecision;
+        public static readonly int MaxScale;
+        public static readonly int MinScale;
+        public OracleNumber(OracleNumber from);
+        public OracleNumber(decimal decValue);
+        public OracleNumber(double dblValue);
+        public OracleNumber(int intValue);
+        public OracleNumber(long longValue);
+        public bool IsNull { get; }
+        public decimal Value { get; }
+        public static OracleNumber Abs(OracleNumber n);
+        public static OracleNumber Acos(OracleNumber n);
+        public static OracleNumber Add(OracleNumber x, OracleNumber y);
+        public static OracleNumber Asin(OracleNumber n);
+        public static OracleNumber Atan(OracleNumber n);
+        public static OracleNumber Atan2(OracleNumber y, OracleNumber x);
+        public static OracleNumber Ceiling(OracleNumber n);
+        public int CompareTo(object obj);
+        public static OracleNumber Cos(OracleNumber n);
+        public static OracleNumber Cosh(OracleNumber n);
+        public static OracleNumber Divide(OracleNumber x, OracleNumber y);
+        public static OracleBoolean Equals(OracleNumber x, OracleNumber y);
+        public override bool Equals(object value);
+        public static OracleNumber Exp(OracleNumber p);
+        public static OracleNumber Floor(OracleNumber n);
+        public override int GetHashCode();
+        public static OracleBoolean GreaterThan(OracleNumber x, OracleNumber y);
+        public static OracleBoolean GreaterThanOrEqual(OracleNumber x, OracleNumber y);
+        public static OracleBoolean LessThan(OracleNumber x, OracleNumber y);
+        public static OracleBoolean LessThanOrEqual(OracleNumber x, OracleNumber y);
+        public static OracleNumber Log(OracleNumber n);
+        public static OracleNumber Log(OracleNumber n, OracleNumber newBase);
+        public static OracleNumber Log(OracleNumber n, int newBase);
+        public static OracleNumber Log10(OracleNumber n);
+        public static OracleNumber Max(OracleNumber x, OracleNumber y);
+        public static OracleNumber Min(OracleNumber x, OracleNumber y);
+        public static OracleNumber Modulo(OracleNumber x, OracleNumber y);
+        public static OracleNumber Multiply(OracleNumber x, OracleNumber y);
+        public static OracleNumber Negate(OracleNumber x);
+        public static OracleBoolean NotEquals(OracleNumber x, OracleNumber y);
+        public static OracleNumber operator +(OracleNumber x, OracleNumber y);
+        public static OracleNumber operator /(OracleNumber x, OracleNumber y);
+        public static OracleBoolean operator ==(OracleNumber x, OracleNumber y);
+        public static explicit operator decimal (OracleNumber x);
+        public static explicit operator double (OracleNumber x);
+        public static explicit operator int (OracleNumber x);
+        public static explicit operator long (OracleNumber x);
+        public static explicit operator OracleNumber (decimal x);
+        public static explicit operator OracleNumber (double x);
+        public static explicit operator OracleNumber (int x);
+        public static explicit operator OracleNumber (long x);
+        public static explicit operator OracleNumber (string x);
+        public static OracleBoolean operator >(OracleNumber x, OracleNumber y);
+        public static OracleBoolean operator >=(OracleNumber x, OracleNumber y);
+        public static OracleBoolean operator !=(OracleNumber x, OracleNumber y);
+        public static OracleBoolean operator <(OracleNumber x, OracleNumber y);
+        public static OracleBoolean operator <=(OracleNumber x, OracleNumber y);
+        public static OracleNumber operator %(OracleNumber x, OracleNumber y);
+        public static OracleNumber operator *(OracleNumber x, OracleNumber y);
+        public static OracleNumber operator -(OracleNumber x, OracleNumber y);
+        public static OracleNumber operator -(OracleNumber x);
+        public static OracleNumber Parse(string s);
+        public static OracleNumber Pow(OracleNumber x, OracleNumber y);
+        public static OracleNumber Pow(OracleNumber x, int y);
+        public static OracleNumber Round(OracleNumber n, int position);
+        public static OracleNumber Shift(OracleNumber n, int digits);
+        public static OracleNumber Sign(OracleNumber n);
+        public static OracleNumber Sin(OracleNumber n);
+        public static OracleNumber Sinh(OracleNumber n);
+        public static OracleNumber Sqrt(OracleNumber n);
+        public static OracleNumber Subtract(OracleNumber x, OracleNumber y);
+        public static OracleNumber Tan(OracleNumber n);
+        public static OracleNumber Tanh(OracleNumber n);
+        public override string ToString();
+        public static OracleNumber Truncate(OracleNumber n, int position);
+    }
+    public sealed class OracleParameter : DbParameter, ICloneable, IDataParameter, IDbDataParameter {
+        public OracleParameter();
+        public OracleParameter(string name, OracleType oracleType);
+        public OracleParameter(string name, OracleType oracleType, int size);
+        public OracleParameter(string name, OracleType oracleType, int size, ParameterDirection direction, bool isNullable, byte precision, byte scale, string srcColumn, DataRowVersion srcVersion, object value);
+        public OracleParameter(string name, OracleType oracleType, int size, ParameterDirection direction, string sourceColumn, DataRowVersion sourceVersion, bool sourceColumnNullMapping, object value);
+        public OracleParameter(string name, OracleType oracleType, int size, string srcColumn);
+        public OracleParameter(string name, object value);
+        public override DbType DbType { get; set; }
+        public override ParameterDirection Direction { get; set; }
+        public override bool IsNullable { get; set; }
+        public int Offset { get; set; }
+        public OracleType OracleType { get; set; }
+        public override string ParameterName { get; set; }
+        public new byte Precision { get; set; }
+        public new byte Scale { get; set; }
+        public override int Size { get; set; }
+        public override string SourceColumn { get; set; }
+        public override bool SourceColumnNullMapping { get; set; }
+        public override DataRowVersion SourceVersion { get; set; }
+        public override object Value { get; set; }
+        public override void ResetDbType();
+        public void ResetOracleType();
+        object System.ICloneable.Clone();
+        public override string ToString();
+    }
+    public sealed class OracleParameterCollection : DbParameterCollection {
+        public OracleParameterCollection();
+        public override int Count { get; }
+        public override bool IsFixedSize { get; }
+        public override bool IsReadOnly { get; }
+        public override bool IsSynchronized { get; }
+        public override object SyncRoot { get; }
+        public new OracleParameter this[int index] { get; set; }
+        public new OracleParameter this[string parameterName] { get; set; }
+        public OracleParameter Add(OracleParameter value);
+        public override int Add(object value);
+        public OracleParameter Add(string parameterName, OracleType dataType);
+        public OracleParameter Add(string parameterName, OracleType dataType, int size);
+        public OracleParameter Add(string parameterName, OracleType dataType, int size, string srcColumn);
+        public OracleParameter Add(string parameterName, object value);
+        public override void AddRange(Array values);
+        public void AddRange(OracleParameter[] values);
+        public OracleParameter AddWithValue(string parameterName, object value);
+        public override void Clear();
+        public bool Contains(OracleParameter value);
+        public override bool Contains(object value);
+        public override bool Contains(string parameterName);
+        public override void CopyTo(Array array, int index);
+        public void CopyTo(OracleParameter[] array, int index);
+        public override IEnumerator GetEnumerator();
+        protected override DbParameter GetParameter(int index);
+        protected override DbParameter GetParameter(string parameterName);
+        public int IndexOf(OracleParameter value);
+        public override int IndexOf(object value);
+        public override int IndexOf(string parameterName);
+        public void Insert(int index, OracleParameter value);
+        public override void Insert(int index, object value);
+        public void Remove(OracleParameter value);
+        public override void Remove(object value);
+        public override void RemoveAt(int index);
+        public override void RemoveAt(string parameterName);
+        protected override void SetParameter(int index, DbParameter value);
+        protected override void SetParameter(string parameterName, DbParameter value);
+    }
+    public sealed class OraclePermission : CodeAccessPermission, IUnrestrictedPermission {
+        public OraclePermission(PermissionState state);
+        public bool AllowBlankPassword { get; set; }
+        public void Add(string connectionString, string restrictions, KeyRestrictionBehavior behavior);
+        public override IPermission Copy();
+        public override void FromXml(SecurityElement securityElement);
+        public override IPermission Intersect(IPermission target);
+        public override bool IsSubsetOf(IPermission target);
+        public bool IsUnrestricted();
+        public override SecurityElement ToXml();
+        public override IPermission Union(IPermission target);
+    }
+    public sealed class OraclePermissionAttribute : CodeAccessSecurityAttribute {
+        public OraclePermissionAttribute(SecurityAction action);
+        public bool AllowBlankPassword { get; set; }
+        public string ConnectionString { get; set; }
+        public KeyRestrictionBehavior KeyRestrictionBehavior { get; set; }
+        public string KeyRestrictions { get; set; }
+        public override IPermission CreatePermission();
+        public bool ShouldSerializeConnectionString();
+        public bool ShouldSerializeKeyRestrictions();
+    }
+    public sealed class OracleRowUpdatedEventArgs : RowUpdatedEventArgs {
+        public OracleRowUpdatedEventArgs(DataRow row, IDbCommand command, StatementType statementType, DataTableMapping tableMapping);
+        public new OracleCommand Command { get; }
+    }
+    public delegate void OracleRowUpdatedEventHandler(object sender, OracleRowUpdatedEventArgs e);
+    public sealed class OracleRowUpdatingEventArgs : RowUpdatingEventArgs {
+        public OracleRowUpdatingEventArgs(DataRow row, IDbCommand command, StatementType statementType, DataTableMapping tableMapping);
+        protected override IDbCommand BaseCommand { get; set; }
+        public new OracleCommand Command { get; set; }
+    }
+    public delegate void OracleRowUpdatingEventHandler(object sender, OracleRowUpdatingEventArgs e);
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct OracleString : IComparable, INullable {
+        public static readonly OracleString Empty;
+        public static readonly OracleString Null;
+        public OracleString(string s);
+        public bool IsNull { get; }
+        public int Length { get; }
+        public char this[int index] { get; }
+        public string Value { get; }
+        public int CompareTo(object obj);
+        public static OracleString Concat(OracleString x, OracleString y);
+        public static OracleBoolean Equals(OracleString x, OracleString y);
+        public override bool Equals(object value);
+        public override int GetHashCode();
+        public static OracleBoolean GreaterThan(OracleString x, OracleString y);
+        public static OracleBoolean GreaterThanOrEqual(OracleString x, OracleString y);
+        public static OracleBoolean LessThan(OracleString x, OracleString y);
+        public static OracleBoolean LessThanOrEqual(OracleString x, OracleString y);
+        public static OracleBoolean NotEquals(OracleString x, OracleString y);
+        public static OracleString operator +(OracleString x, OracleString y);
+        public static OracleBoolean operator ==(OracleString x, OracleString y);
+        public static explicit operator string (OracleString x);
+        public static OracleBoolean operator >(OracleString x, OracleString y);
+        public static OracleBoolean operator >=(OracleString x, OracleString y);
+        public static implicit operator OracleString (string s);
+        public static OracleBoolean operator !=(OracleString x, OracleString y);
+        public static OracleBoolean operator <(OracleString x, OracleString y);
+        public static OracleBoolean operator <=(OracleString x, OracleString y);
+        public override string ToString();
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct OracleTimeSpan : IComparable, INullable {
+        public static readonly OracleTimeSpan MaxValue;
+        public static readonly OracleTimeSpan MinValue;
+        public static readonly OracleTimeSpan Null;
+        public OracleTimeSpan(OracleTimeSpan from);
+        public OracleTimeSpan(int hours, int minutes, int seconds);
+        public OracleTimeSpan(int days, int hours, int minutes, int seconds);
+        public OracleTimeSpan(int days, int hours, int minutes, int seconds, int milliseconds);
+        public OracleTimeSpan(long ticks);
+        public OracleTimeSpan(TimeSpan ts);
+        public int Days { get; }
+        public int Hours { get; }
+        public bool IsNull { get; }
+        public int Milliseconds { get; }
+        public int Minutes { get; }
+        public int Seconds { get; }
+        public TimeSpan Value { get; }
+        public int CompareTo(object obj);
+        public static OracleBoolean Equals(OracleTimeSpan x, OracleTimeSpan y);
+        public override bool Equals(object value);
+        public override int GetHashCode();
+        public static OracleBoolean GreaterThan(OracleTimeSpan x, OracleTimeSpan y);
+        public static OracleBoolean GreaterThanOrEqual(OracleTimeSpan x, OracleTimeSpan y);
+        public static OracleBoolean LessThan(OracleTimeSpan x, OracleTimeSpan y);
+        public static OracleBoolean LessThanOrEqual(OracleTimeSpan x, OracleTimeSpan y);
+        public static OracleBoolean NotEquals(OracleTimeSpan x, OracleTimeSpan y);
+        public static OracleBoolean operator ==(OracleTimeSpan x, OracleTimeSpan y);
+        public static explicit operator TimeSpan (OracleTimeSpan x);
+        public static explicit operator OracleTimeSpan (string x);
+        public static OracleBoolean operator >(OracleTimeSpan x, OracleTimeSpan y);
+        public static OracleBoolean operator >=(OracleTimeSpan x, OracleTimeSpan y);
+        public static OracleBoolean operator !=(OracleTimeSpan x, OracleTimeSpan y);
+        public static OracleBoolean operator <(OracleTimeSpan x, OracleTimeSpan y);
+        public static OracleBoolean operator <=(OracleTimeSpan x, OracleTimeSpan y);
+        public static OracleTimeSpan Parse(string s);
+        public override string ToString();
+    }
+    public sealed class OracleTransaction : DbTransaction {
+        public new OracleConnection Connection { get; }
+        protected override DbConnection DbConnection { get; }
+        public override IsolationLevel IsolationLevel { get; }
+        public override void Commit();
+        protected override void Dispose(bool disposing);
+        public override void Rollback();
+    }
+    public enum OracleType {
+        BFile = 1,
+        Blob = 2,
+        Byte = 23,
+        Char = 3,
+        Clob = 4,
+        Cursor = 5,
+        DateTime = 6,
+        Double = 30,
+        Float = 29,
+        Int16 = 27,
+        Int32 = 28,
+        IntervalDayToSecond = 7,
+        IntervalYearToMonth = 8,
+        LongRaw = 9,
+        LongVarChar = 10,
+        NChar = 11,
+        NClob = 12,
+        Number = 13,
+        NVarChar = 14,
+        Raw = 15,
+        RowId = 16,
+        SByte = 26,
+        Timestamp = 18,
+        TimestampLocal = 19,
+        TimestampWithTZ = 20,
+        UInt16 = 24,
+        UInt32 = 25,
+        VarChar = 22,
+    }
+}
```

