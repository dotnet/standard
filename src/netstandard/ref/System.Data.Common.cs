// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Data.Common
{
    public enum CatalogLocation
    {
        End = 2,
        Start = 1,
    }
    public partial class DataAdapter : System.ComponentModel.Component, System.Data.IDataAdapter
    {
        protected DataAdapter() { }
        protected DataAdapter(System.Data.Common.DataAdapter from) { }
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool AcceptChangesDuringFill { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool AcceptChangesDuringUpdate { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool ContinueUpdateOnError { get { throw null; } set { } }
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        public System.Data.LoadOption FillLoadOption { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(System.Data.MissingMappingAction.Passthrough)]
        public System.Data.MissingMappingAction MissingMappingAction { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(System.Data.MissingSchemaAction.Add)]
        public System.Data.MissingSchemaAction MissingSchemaAction { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        public virtual bool ReturnProviderSpecificTypes { get { throw null; } set { } }
        System.Data.ITableMappingCollection System.Data.IDataAdapter.TableMappings { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public System.Data.Common.DataTableMappingCollection TableMappings { get { throw null; } }
        public event System.Data.FillErrorEventHandler FillError { add { } remove { } }
        [System.ObsoleteAttribute("CloneInternals() has been deprecated.  Use the DataAdapter(DataAdapter from) constructor.  https://go.microsoft.com/fwlink/?linkid=14202")]
        protected virtual System.Data.Common.DataAdapter CloneInternals() { throw null; }
        protected virtual System.Data.Common.DataTableMappingCollection CreateTableMappings() { throw null; }
        protected override void Dispose(bool disposing) { }
        public virtual int Fill(System.Data.DataSet dataSet) { throw null; }
        protected virtual int Fill(System.Data.DataSet dataSet, string srcTable, System.Data.IDataReader dataReader, int startRecord, int maxRecords) { throw null; }
        protected virtual int Fill(System.Data.DataTable dataTable, System.Data.IDataReader dataReader) { throw null; }
        protected virtual int Fill(System.Data.DataTable[] dataTables, System.Data.IDataReader dataReader, int startRecord, int maxRecords) { throw null; }
        public virtual System.Data.DataTable[] FillSchema(System.Data.DataSet dataSet, System.Data.SchemaType schemaType) { throw null; }
        protected virtual System.Data.DataTable[] FillSchema(System.Data.DataSet dataSet, System.Data.SchemaType schemaType, string srcTable, System.Data.IDataReader dataReader) { throw null; }
        protected virtual System.Data.DataTable FillSchema(System.Data.DataTable dataTable, System.Data.SchemaType schemaType, System.Data.IDataReader dataReader) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public virtual System.Data.IDataParameter[] GetFillParameters() { throw null; }
        protected bool HasTableMappings() { throw null; }
        protected virtual void OnFillError(System.Data.FillErrorEventArgs value) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public void ResetFillLoadOption() { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual bool ShouldSerializeAcceptChangesDuringFill() { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual bool ShouldSerializeFillLoadOption() { throw null; }
        protected virtual bool ShouldSerializeTableMappings() { throw null; }
        public virtual int Update(System.Data.DataSet dataSet) { throw null; }
    }
    public sealed partial class DataColumnMapping : System.MarshalByRefObject, System.Data.IColumnMapping, System.ICloneable
    {
        public DataColumnMapping() { }
        public DataColumnMapping(string sourceColumn, string dataSetColumn) { }
        [System.ComponentModel.DefaultValueAttribute("")]
        public string DataSetColumn { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        public string SourceColumn { get { throw null; } set { } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.Data.DataColumn GetDataColumnBySchemaAction(System.Data.DataTable dataTable, System.Type dataType, System.Data.MissingSchemaAction schemaAction) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Data.DataColumn GetDataColumnBySchemaAction(string sourceColumn, string dataSetColumn, System.Data.DataTable dataTable, System.Type dataType, System.Data.MissingSchemaAction schemaAction) { throw null; }
        object System.ICloneable.Clone() { throw null; }
        public override string ToString() { throw null; }
    }
    public sealed partial class DataColumnMappingCollection : System.MarshalByRefObject, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.Data.IColumnMappingCollection
    {
        public DataColumnMappingCollection() { }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public int Count { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public System.Data.Common.DataColumnMapping this[int index] { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public System.Data.Common.DataColumnMapping this[string sourceColumn] { get { throw null; } set { } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        bool System.Collections.IList.IsFixedSize { get { throw null; } }
        bool System.Collections.IList.IsReadOnly { get { throw null; } }
        object System.Collections.IList.this[int index] { get { throw null; } set { } }
        object System.Data.IColumnMappingCollection.this[string index] { get { throw null; } set { } }
        public int Add(object value) { throw null; }
        public System.Data.Common.DataColumnMapping Add(string sourceColumn, string dataSetColumn) { throw null; }
        public void AddRange(System.Array values) { }
        public void AddRange(System.Data.Common.DataColumnMapping[] values) { }
        public void Clear() { }
        public bool Contains(object value) { throw null; }
        public bool Contains(string value) { throw null; }
        public void CopyTo(System.Array array, int index) { }
        public void CopyTo(System.Data.Common.DataColumnMapping[] array, int index) { }
        public System.Data.Common.DataColumnMapping GetByDataSetColumn(string value) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Data.Common.DataColumnMapping GetColumnMappingBySchemaAction(System.Data.Common.DataColumnMappingCollection columnMappings, string sourceColumn, System.Data.MissingMappingAction mappingAction) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Data.DataColumn GetDataColumn(System.Data.Common.DataColumnMappingCollection columnMappings, string sourceColumn, System.Type dataType, System.Data.DataTable dataTable, System.Data.MissingMappingAction mappingAction, System.Data.MissingSchemaAction schemaAction) { throw null; }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        public int IndexOf(object value) { throw null; }
        public int IndexOf(string sourceColumn) { throw null; }
        public int IndexOfDataSetColumn(string dataSetColumn) { throw null; }
        public void Insert(int index, System.Data.Common.DataColumnMapping value) { }
        public void Insert(int index, object value) { }
        public void Remove(System.Data.Common.DataColumnMapping value) { }
        public void Remove(object value) { }
        public void RemoveAt(int index) { }
        public void RemoveAt(string sourceColumn) { }
        System.Data.IColumnMapping System.Data.IColumnMappingCollection.Add(string sourceColumnName, string dataSetColumnName) { throw null; }
        System.Data.IColumnMapping System.Data.IColumnMappingCollection.GetByDataSetColumn(string dataSetColumnName) { throw null; }
    }
    public sealed partial class DataTableMapping : System.MarshalByRefObject, System.Data.ITableMapping, System.ICloneable
    {
        public DataTableMapping() { }
        public DataTableMapping(string sourceTable, string dataSetTable) { }
        public DataTableMapping(string sourceTable, string dataSetTable, System.Data.Common.DataColumnMapping[] columnMappings) { }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public System.Data.Common.DataColumnMappingCollection ColumnMappings { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute("")]
        public string DataSetTable { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        public string SourceTable { get { throw null; } set { } }
        System.Data.IColumnMappingCollection System.Data.ITableMapping.ColumnMappings { get { throw null; } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.Data.Common.DataColumnMapping GetColumnMappingBySchemaAction(string sourceColumn, System.Data.MissingMappingAction mappingAction) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.Data.DataColumn GetDataColumn(string sourceColumn, System.Type dataType, System.Data.DataTable dataTable, System.Data.MissingMappingAction mappingAction, System.Data.MissingSchemaAction schemaAction) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.Data.DataTable GetDataTableBySchemaAction(System.Data.DataSet dataSet, System.Data.MissingSchemaAction schemaAction) { throw null; }
        object System.ICloneable.Clone() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.ComponentModel.ListBindableAttribute(false)]
    public sealed partial class DataTableMappingCollection : System.MarshalByRefObject, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.Data.ITableMappingCollection
    {
        public DataTableMappingCollection() { }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public int Count { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public System.Data.Common.DataTableMapping this[int index] { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public System.Data.Common.DataTableMapping this[string sourceTable] { get { throw null; } set { } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        bool System.Collections.IList.IsFixedSize { get { throw null; } }
        bool System.Collections.IList.IsReadOnly { get { throw null; } }
        object System.Collections.IList.this[int index] { get { throw null; } set { } }
        object System.Data.ITableMappingCollection.this[string index] { get { throw null; } set { } }
        public int Add(object value) { throw null; }
        public System.Data.Common.DataTableMapping Add(string sourceTable, string dataSetTable) { throw null; }
        public void AddRange(System.Array values) { }
        public void AddRange(System.Data.Common.DataTableMapping[] values) { }
        public void Clear() { }
        public bool Contains(object value) { throw null; }
        public bool Contains(string value) { throw null; }
        public void CopyTo(System.Array array, int index) { }
        public void CopyTo(System.Data.Common.DataTableMapping[] array, int index) { }
        public System.Data.Common.DataTableMapping GetByDataSetTable(string dataSetTable) { throw null; }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Data.Common.DataTableMapping GetTableMappingBySchemaAction(System.Data.Common.DataTableMappingCollection tableMappings, string sourceTable, string dataSetTable, System.Data.MissingMappingAction mappingAction) { throw null; }
        public int IndexOf(object value) { throw null; }
        public int IndexOf(string sourceTable) { throw null; }
        public int IndexOfDataSetTable(string dataSetTable) { throw null; }
        public void Insert(int index, System.Data.Common.DataTableMapping value) { }
        public void Insert(int index, object value) { }
        public void Remove(System.Data.Common.DataTableMapping value) { }
        public void Remove(object value) { }
        public void RemoveAt(int index) { }
        public void RemoveAt(string sourceTable) { }
        System.Data.ITableMapping System.Data.ITableMappingCollection.Add(string sourceTableName, string dataSetTableName) { throw null; }
        System.Data.ITableMapping System.Data.ITableMappingCollection.GetByDataSetTable(string dataSetTableName) { throw null; }
    }
    public abstract partial class DbColumn
    {
        protected DbColumn() { }
        public System.Nullable<bool> AllowDBNull { get { throw null; } protected set { } }
        public string BaseCatalogName { get { throw null; } protected set { } }
        public string BaseColumnName { get { throw null; } protected set { } }
        public string BaseSchemaName { get { throw null; } protected set { } }
        public string BaseServerName { get { throw null; } protected set { } }
        public string BaseTableName { get { throw null; } protected set { } }
        public string ColumnName { get { throw null; } protected set { } }
        public System.Nullable<int> ColumnOrdinal { get { throw null; } protected set { } }
        public System.Nullable<int> ColumnSize { get { throw null; } protected set { } }
        public System.Type DataType { get { throw null; } protected set { } }
        public string DataTypeName { get { throw null; } protected set { } }
        public System.Nullable<bool> IsAliased { get { throw null; } protected set { } }
        public System.Nullable<bool> IsAutoIncrement { get { throw null; } protected set { } }
        public System.Nullable<bool> IsExpression { get { throw null; } protected set { } }
        public System.Nullable<bool> IsHidden { get { throw null; } protected set { } }
        public System.Nullable<bool> IsIdentity { get { throw null; } protected set { } }
        public System.Nullable<bool> IsKey { get { throw null; } protected set { } }
        public System.Nullable<bool> IsLong { get { throw null; } protected set { } }
        public System.Nullable<bool> IsReadOnly { get { throw null; } protected set { } }
        public System.Nullable<bool> IsUnique { get { throw null; } protected set { } }
        public virtual object this[string property] { get { throw null; } }
        public System.Nullable<int> NumericPrecision { get { throw null; } protected set { } }
        public System.Nullable<int> NumericScale { get { throw null; } protected set { } }
        public string UdtAssemblyQualifiedName { get { throw null; } protected set { } }
    }
    public abstract partial class DbCommand : System.ComponentModel.Component, System.Data.IDbCommand, System.IDisposable
    {
        protected DbCommand() { }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        public abstract string CommandText { get; set; }
        public abstract int CommandTimeout { get; set; }
        [System.ComponentModel.DefaultValueAttribute(System.Data.CommandType.Text)]
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        public abstract System.Data.CommandType CommandType { get; set; }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public System.Data.Common.DbConnection Connection { get { throw null; } set { } }
        protected abstract System.Data.Common.DbConnection DbConnection { get; set; }
        protected abstract System.Data.Common.DbParameterCollection DbParameterCollection { get; }
        protected abstract System.Data.Common.DbTransaction DbTransaction { get; set; }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.ComponentModel.DesignOnlyAttribute(true)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public abstract bool DesignTimeVisible { get; set; }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public System.Data.Common.DbParameterCollection Parameters { get { throw null; } }
        System.Data.IDbConnection System.Data.IDbCommand.Connection { get { throw null; } set { } }
        System.Data.IDataParameterCollection System.Data.IDbCommand.Parameters { get { throw null; } }
        System.Data.IDbTransaction System.Data.IDbCommand.Transaction { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public System.Data.Common.DbTransaction Transaction { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(System.Data.UpdateRowSource.Both)]
        public abstract System.Data.UpdateRowSource UpdatedRowSource { get; set; }
        public abstract void Cancel();
        protected abstract System.Data.Common.DbParameter CreateDbParameter();
        public System.Data.Common.DbParameter CreateParameter() { throw null; }
        protected abstract System.Data.Common.DbDataReader ExecuteDbDataReader(System.Data.CommandBehavior behavior);
        protected virtual System.Threading.Tasks.Task<System.Data.Common.DbDataReader> ExecuteDbDataReaderAsync(System.Data.CommandBehavior behavior, System.Threading.CancellationToken cancellationToken) { throw null; }
        public abstract int ExecuteNonQuery();
        public System.Threading.Tasks.Task<int> ExecuteNonQueryAsync() { throw null; }
        public virtual System.Threading.Tasks.Task<int> ExecuteNonQueryAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Data.Common.DbDataReader ExecuteReader() { throw null; }
        public System.Data.Common.DbDataReader ExecuteReader(System.Data.CommandBehavior behavior) { throw null; }
        public System.Threading.Tasks.Task<System.Data.Common.DbDataReader> ExecuteReaderAsync() { throw null; }
        public System.Threading.Tasks.Task<System.Data.Common.DbDataReader> ExecuteReaderAsync(System.Data.CommandBehavior behavior) { throw null; }
        public System.Threading.Tasks.Task<System.Data.Common.DbDataReader> ExecuteReaderAsync(System.Data.CommandBehavior behavior, System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task<System.Data.Common.DbDataReader> ExecuteReaderAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public abstract object ExecuteScalar();
        public System.Threading.Tasks.Task<object> ExecuteScalarAsync() { throw null; }
        public virtual System.Threading.Tasks.Task<object> ExecuteScalarAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public abstract void Prepare();
        System.Data.IDbDataParameter System.Data.IDbCommand.CreateParameter() { throw null; }
        System.Data.IDataReader System.Data.IDbCommand.ExecuteReader() { throw null; }
        System.Data.IDataReader System.Data.IDbCommand.ExecuteReader(System.Data.CommandBehavior behavior) { throw null; }
    }
    public abstract partial class DbCommandBuilder : System.ComponentModel.Component
    {
        protected DbCommandBuilder() { }
        [System.ComponentModel.DefaultValueAttribute(System.Data.Common.CatalogLocation.Start)]
        public virtual System.Data.Common.CatalogLocation CatalogLocation { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(".")]
        public virtual string CatalogSeparator { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(System.Data.ConflictOption.CompareAllSearchableValues)]
        public virtual System.Data.ConflictOption ConflictOption { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public System.Data.Common.DbDataAdapter DataAdapter { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        public virtual string QuotePrefix { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        public virtual string QuoteSuffix { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(".")]
        public virtual string SchemaSeparator { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool SetAllValues { get { throw null; } set { } }
        protected abstract void ApplyParameterInfo(System.Data.Common.DbParameter parameter, System.Data.DataRow row, System.Data.StatementType statementType, bool whereClause);
        protected override void Dispose(bool disposing) { }
        public System.Data.Common.DbCommand GetDeleteCommand() { throw null; }
        public System.Data.Common.DbCommand GetDeleteCommand(bool useColumnsForParameterNames) { throw null; }
        public System.Data.Common.DbCommand GetInsertCommand() { throw null; }
        public System.Data.Common.DbCommand GetInsertCommand(bool useColumnsForParameterNames) { throw null; }
        protected abstract string GetParameterName(int parameterOrdinal);
        protected abstract string GetParameterName(string parameterName);
        protected abstract string GetParameterPlaceholder(int parameterOrdinal);
        protected virtual System.Data.DataTable GetSchemaTable(System.Data.Common.DbCommand sourceCommand) { throw null; }
        public System.Data.Common.DbCommand GetUpdateCommand() { throw null; }
        public System.Data.Common.DbCommand GetUpdateCommand(bool useColumnsForParameterNames) { throw null; }
        protected virtual System.Data.Common.DbCommand InitializeCommand(System.Data.Common.DbCommand command) { throw null; }
        public virtual string QuoteIdentifier(string unquotedIdentifier) { throw null; }
        public virtual void RefreshSchema() { }
        protected void RowUpdatingHandler(System.Data.Common.RowUpdatingEventArgs rowUpdatingEvent) { }
        protected abstract void SetRowUpdatingHandler(System.Data.Common.DbDataAdapter adapter);
        public virtual string UnquoteIdentifier(string quotedIdentifier) { throw null; }
    }
    public abstract partial class DbConnection : System.ComponentModel.Component, System.Data.IDbConnection, System.IDisposable
    {
        protected DbConnection() { }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.RecommendedAsConfigurableAttribute(true)]
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        [System.ComponentModel.SettingsBindableAttribute(true)]
        public abstract string ConnectionString { get; set; }
        public virtual int ConnectionTimeout { get { throw null; } }
        public abstract string Database { get; }
        public abstract string DataSource { get; }
        protected virtual System.Data.Common.DbProviderFactory DbProviderFactory { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public abstract string ServerVersion { get; }
        [System.ComponentModel.BrowsableAttribute(false)]
        public abstract System.Data.ConnectionState State { get; }
        public virtual event System.Data.StateChangeEventHandler StateChange { add { } remove { } }
        protected abstract System.Data.Common.DbTransaction BeginDbTransaction(System.Data.IsolationLevel isolationLevel);
        public System.Data.Common.DbTransaction BeginTransaction() { throw null; }
        public System.Data.Common.DbTransaction BeginTransaction(System.Data.IsolationLevel isolationLevel) { throw null; }
        public abstract void ChangeDatabase(string databaseName);
        public abstract void Close();
        public System.Data.Common.DbCommand CreateCommand() { throw null; }
        protected abstract System.Data.Common.DbCommand CreateDbCommand();
        public virtual void EnlistTransaction(System.Transactions.Transaction transaction) { }
        public virtual System.Data.DataTable GetSchema() { throw null; }
        public virtual System.Data.DataTable GetSchema(string collectionName) { throw null; }
        public virtual System.Data.DataTable GetSchema(string collectionName, string[] restrictionValues) { throw null; }
        protected virtual void OnStateChange(System.Data.StateChangeEventArgs stateChange) { }
        public abstract void Open();
        public System.Threading.Tasks.Task OpenAsync() { throw null; }
        public virtual System.Threading.Tasks.Task OpenAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Data.IDbTransaction System.Data.IDbConnection.BeginTransaction() { throw null; }
        System.Data.IDbTransaction System.Data.IDbConnection.BeginTransaction(System.Data.IsolationLevel isolationLevel) { throw null; }
        System.Data.IDbCommand System.Data.IDbConnection.CreateCommand() { throw null; }
    }
    public partial class DbConnectionStringBuilder : System.Collections.ICollection, System.Collections.IDictionary, System.Collections.IEnumerable, System.ComponentModel.ICustomTypeDescriptor
    {
        public DbConnectionStringBuilder() { }
        public DbConnectionStringBuilder(bool useOdbcRules) { }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.DesignOnlyAttribute(true)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool BrowsableConnectionString { get { throw null; } set { } }
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        public string ConnectionString { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public virtual int Count { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public virtual bool IsFixedSize { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public bool IsReadOnly { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public virtual object this[string keyword] { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public virtual System.Collections.ICollection Keys { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        object System.Collections.IDictionary.this[object keyword] { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public virtual System.Collections.ICollection Values { get { throw null; } }
        public void Add(string keyword, object value) { }
        public static void AppendKeyValuePair(System.Text.StringBuilder builder, string keyword, string value) { }
        public static void AppendKeyValuePair(System.Text.StringBuilder builder, string keyword, string value, bool useOdbcRules) { }
        public virtual void Clear() { }
        protected internal void ClearPropertyDescriptors() { }
        public virtual bool ContainsKey(string keyword) { throw null; }
        public virtual bool EquivalentTo(System.Data.Common.DbConnectionStringBuilder connectionStringBuilder) { throw null; }
        protected virtual void GetProperties(System.Collections.Hashtable propertyDescriptors) { }
        public virtual bool Remove(string keyword) { throw null; }
        public virtual bool ShouldSerialize(string keyword) { throw null; }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        void System.Collections.IDictionary.Add(object keyword, object value) { }
        bool System.Collections.IDictionary.Contains(object keyword) { throw null; }
        System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { throw null; }
        void System.Collections.IDictionary.Remove(object keyword) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { throw null; }
        string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { throw null; }
        string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { throw null; }
        System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { throw null; }
        System.ComponentModel.EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { throw null; }
        System.ComponentModel.PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { throw null; }
        object System.ComponentModel.ICustomTypeDescriptor.GetEditor(System.Type editorBaseType) { throw null; }
        System.ComponentModel.EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { throw null; }
        System.ComponentModel.EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(System.Attribute[] attributes) { throw null; }
        System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { throw null; }
        System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes) { throw null; }
        object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd) { throw null; }
        public override string ToString() { throw null; }
        public virtual bool TryGetValue(string keyword, out object value) { throw null; }
    }
    public abstract partial class DbDataAdapter : System.Data.Common.DataAdapter, System.Data.IDataAdapter, System.Data.IDbDataAdapter, System.ICloneable
    {
        public const string DefaultSourceTableName = "Table";
        protected DbDataAdapter() { }
        protected DbDataAdapter(System.Data.Common.DbDataAdapter adapter) { }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public System.Data.Common.DbCommand DeleteCommand { get { throw null; } set { } }
        protected internal System.Data.CommandBehavior FillCommandBehavior { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public System.Data.Common.DbCommand InsertCommand { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public System.Data.Common.DbCommand SelectCommand { get { throw null; } set { } }
        System.Data.IDbCommand System.Data.IDbDataAdapter.DeleteCommand { get { throw null; } set { } }
        System.Data.IDbCommand System.Data.IDbDataAdapter.InsertCommand { get { throw null; } set { } }
        System.Data.IDbCommand System.Data.IDbDataAdapter.SelectCommand { get { throw null; } set { } }
        System.Data.IDbCommand System.Data.IDbDataAdapter.UpdateCommand { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(1)]
        public virtual int UpdateBatchSize { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public System.Data.Common.DbCommand UpdateCommand { get { throw null; } set { } }
        protected virtual int AddToBatch(System.Data.IDbCommand command) { throw null; }
        protected virtual void ClearBatch() { }
        protected virtual System.Data.Common.RowUpdatedEventArgs CreateRowUpdatedEvent(System.Data.DataRow dataRow, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) { throw null; }
        protected virtual System.Data.Common.RowUpdatingEventArgs CreateRowUpdatingEvent(System.Data.DataRow dataRow, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) { throw null; }
        protected override void Dispose(bool disposing) { }
        protected virtual int ExecuteBatch() { throw null; }
        public override int Fill(System.Data.DataSet dataSet) { throw null; }
        public int Fill(System.Data.DataSet dataSet, int startRecord, int maxRecords, string srcTable) { throw null; }
        protected virtual int Fill(System.Data.DataSet dataSet, int startRecord, int maxRecords, string srcTable, System.Data.IDbCommand command, System.Data.CommandBehavior behavior) { throw null; }
        public int Fill(System.Data.DataSet dataSet, string srcTable) { throw null; }
        public int Fill(System.Data.DataTable dataTable) { throw null; }
        protected virtual int Fill(System.Data.DataTable dataTable, System.Data.IDbCommand command, System.Data.CommandBehavior behavior) { throw null; }
        protected virtual int Fill(System.Data.DataTable[] dataTables, int startRecord, int maxRecords, System.Data.IDbCommand command, System.Data.CommandBehavior behavior) { throw null; }
        public int Fill(int startRecord, int maxRecords, params System.Data.DataTable[] dataTables) { throw null; }
        public override System.Data.DataTable[] FillSchema(System.Data.DataSet dataSet, System.Data.SchemaType schemaType) { throw null; }
        protected virtual System.Data.DataTable[] FillSchema(System.Data.DataSet dataSet, System.Data.SchemaType schemaType, System.Data.IDbCommand command, string srcTable, System.Data.CommandBehavior behavior) { throw null; }
        public System.Data.DataTable[] FillSchema(System.Data.DataSet dataSet, System.Data.SchemaType schemaType, string srcTable) { throw null; }
        public System.Data.DataTable FillSchema(System.Data.DataTable dataTable, System.Data.SchemaType schemaType) { throw null; }
        protected virtual System.Data.DataTable FillSchema(System.Data.DataTable dataTable, System.Data.SchemaType schemaType, System.Data.IDbCommand command, System.Data.CommandBehavior behavior) { throw null; }
        protected virtual System.Data.IDataParameter GetBatchedParameter(int commandIdentifier, int parameterIndex) { throw null; }
        protected virtual bool GetBatchedRecordsAffected(int commandIdentifier, out int recordsAffected, out System.Exception error) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public override System.Data.IDataParameter[] GetFillParameters() { throw null; }
        protected virtual void InitializeBatching() { }
        protected virtual void OnRowUpdated(System.Data.Common.RowUpdatedEventArgs value) { }
        protected virtual void OnRowUpdating(System.Data.Common.RowUpdatingEventArgs value) { }
        object System.ICloneable.Clone() { throw null; }
        protected virtual void TerminateBatching() { }
        public int Update(System.Data.DataRow[] dataRows) { throw null; }
        protected virtual int Update(System.Data.DataRow[] dataRows, System.Data.Common.DataTableMapping tableMapping) { throw null; }
        public override int Update(System.Data.DataSet dataSet) { throw null; }
        public int Update(System.Data.DataSet dataSet, string srcTable) { throw null; }
        public int Update(System.Data.DataTable dataTable) { throw null; }
    }
    public abstract partial class DbDataReader : System.MarshalByRefObject, System.Collections.IEnumerable, System.Data.IDataReader, System.Data.IDataRecord, System.IDisposable
    {
        protected DbDataReader() { }
        public abstract int Depth { get; }
        public abstract int FieldCount { get; }
        public abstract bool HasRows { get; }
        public abstract bool IsClosed { get; }
        public abstract object this[int ordinal] { get; }
        public abstract object this[string name] { get; }
        public abstract int RecordsAffected { get; }
        public virtual int VisibleFieldCount { get { throw null; } }
        public virtual void Close() { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public abstract bool GetBoolean(int ordinal);
        public abstract byte GetByte(int ordinal);
        public abstract long GetBytes(int ordinal, long dataOffset, byte[] buffer, int bufferOffset, int length);
        public abstract char GetChar(int ordinal);
        public abstract long GetChars(int ordinal, long dataOffset, char[] buffer, int bufferOffset, int length);
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Data.Common.DbDataReader GetData(int ordinal) { throw null; }
        public abstract string GetDataTypeName(int ordinal);
        public abstract System.DateTime GetDateTime(int ordinal);
        protected virtual System.Data.Common.DbDataReader GetDbDataReader(int ordinal) { throw null; }
        public abstract decimal GetDecimal(int ordinal);
        public abstract double GetDouble(int ordinal);
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public abstract System.Collections.IEnumerator GetEnumerator();
        public abstract System.Type GetFieldType(int ordinal);
        public System.Threading.Tasks.Task<T> GetFieldValueAsync<T>(int ordinal) { throw null; }
        public virtual System.Threading.Tasks.Task<T> GetFieldValueAsync<T>(int ordinal, System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual T GetFieldValue<T>(int ordinal) { throw null; }
        public abstract float GetFloat(int ordinal);
        public abstract System.Guid GetGuid(int ordinal);
        public abstract short GetInt16(int ordinal);
        public abstract int GetInt32(int ordinal);
        public abstract long GetInt64(int ordinal);
        public abstract string GetName(int ordinal);
        public abstract int GetOrdinal(string name);
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual System.Type GetProviderSpecificFieldType(int ordinal) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual object GetProviderSpecificValue(int ordinal) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual int GetProviderSpecificValues(object[] values) { throw null; }
        public virtual System.Data.DataTable GetSchemaTable() { throw null; }
        public virtual System.IO.Stream GetStream(int ordinal) { throw null; }
        public abstract string GetString(int ordinal);
        public virtual System.IO.TextReader GetTextReader(int ordinal) { throw null; }
        public abstract object GetValue(int ordinal);
        public abstract int GetValues(object[] values);
        public abstract bool IsDBNull(int ordinal);
        public System.Threading.Tasks.Task<bool> IsDBNullAsync(int ordinal) { throw null; }
        public virtual System.Threading.Tasks.Task<bool> IsDBNullAsync(int ordinal, System.Threading.CancellationToken cancellationToken) { throw null; }
        public abstract bool NextResult();
        public System.Threading.Tasks.Task<bool> NextResultAsync() { throw null; }
        public virtual System.Threading.Tasks.Task<bool> NextResultAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public abstract bool Read();
        public System.Threading.Tasks.Task<bool> ReadAsync() { throw null; }
        public virtual System.Threading.Tasks.Task<bool> ReadAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Data.IDataReader System.Data.IDataRecord.GetData(int ordinal) { throw null; }
    }
    public static partial class DbDataReaderExtensions
    {
        public static bool CanGetColumnSchema(this System.Data.Common.DbDataReader reader) { throw null; }
        public static System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Common.DbColumn> GetColumnSchema(this System.Data.Common.DbDataReader reader) { throw null; }
    }
    public abstract partial class DbDataRecord : System.ComponentModel.ICustomTypeDescriptor, System.Data.IDataRecord
    {
        protected DbDataRecord() { }
        public abstract int FieldCount { get; }
        public abstract object this[int i] { get; }
        public abstract object this[string name] { get; }
        public abstract bool GetBoolean(int i);
        public abstract byte GetByte(int i);
        public abstract long GetBytes(int i, long dataIndex, byte[] buffer, int bufferIndex, int length);
        public abstract char GetChar(int i);
        public abstract long GetChars(int i, long dataIndex, char[] buffer, int bufferIndex, int length);
        public System.Data.IDataReader GetData(int i) { throw null; }
        public abstract string GetDataTypeName(int i);
        public abstract System.DateTime GetDateTime(int i);
        protected virtual System.Data.Common.DbDataReader GetDbDataReader(int i) { throw null; }
        public abstract decimal GetDecimal(int i);
        public abstract double GetDouble(int i);
        public abstract System.Type GetFieldType(int i);
        public abstract float GetFloat(int i);
        public abstract System.Guid GetGuid(int i);
        public abstract short GetInt16(int i);
        public abstract int GetInt32(int i);
        public abstract long GetInt64(int i);
        public abstract string GetName(int i);
        public abstract int GetOrdinal(string name);
        public abstract string GetString(int i);
        public abstract object GetValue(int i);
        public abstract int GetValues(object[] values);
        public abstract bool IsDBNull(int i);
        System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { throw null; }
        string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { throw null; }
        string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { throw null; }
        System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { throw null; }
        System.ComponentModel.EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { throw null; }
        System.ComponentModel.PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { throw null; }
        object System.ComponentModel.ICustomTypeDescriptor.GetEditor(System.Type editorBaseType) { throw null; }
        System.ComponentModel.EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { throw null; }
        System.ComponentModel.EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(System.Attribute[] attributes) { throw null; }
        System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { throw null; }
        System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes) { throw null; }
        object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd) { throw null; }
    }
    public abstract partial class DbDataSourceEnumerator
    {
        protected DbDataSourceEnumerator() { }
        public abstract System.Data.DataTable GetDataSources();
    }
    public partial class DbEnumerator : System.Collections.IEnumerator
    {
        public DbEnumerator(System.Data.Common.DbDataReader reader) { }
        public DbEnumerator(System.Data.Common.DbDataReader reader, bool closeReader) { }
        public DbEnumerator(System.Data.IDataReader reader) { }
        public DbEnumerator(System.Data.IDataReader reader, bool closeReader) { }
        public object Current { get { throw null; } }
        public bool MoveNext() { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public void Reset() { }
    }
    public abstract partial class DbException : System.Runtime.InteropServices.ExternalException
    {
        protected DbException() { }
        protected DbException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        protected DbException(string message) { }
        protected DbException(string message, System.Exception innerException) { }
        protected DbException(string message, int errorCode) { }
    }
    public static partial class DbMetaDataCollectionNames
    {
        public static readonly string DataSourceInformation;
        public static readonly string DataTypes;
        public static readonly string MetaDataCollections;
        public static readonly string ReservedWords;
        public static readonly string Restrictions;
    }
    public static partial class DbMetaDataColumnNames
    {
        public static readonly string CollectionName;
        public static readonly string ColumnSize;
        public static readonly string CompositeIdentifierSeparatorPattern;
        public static readonly string CreateFormat;
        public static readonly string CreateParameters;
        public static readonly string DataSourceProductName;
        public static readonly string DataSourceProductVersion;
        public static readonly string DataSourceProductVersionNormalized;
        public static readonly string DataType;
        public static readonly string GroupByBehavior;
        public static readonly string IdentifierCase;
        public static readonly string IdentifierPattern;
        public static readonly string IsAutoIncrementable;
        public static readonly string IsBestMatch;
        public static readonly string IsCaseSensitive;
        public static readonly string IsConcurrencyType;
        public static readonly string IsFixedLength;
        public static readonly string IsFixedPrecisionScale;
        public static readonly string IsLiteralSupported;
        public static readonly string IsLong;
        public static readonly string IsNullable;
        public static readonly string IsSearchable;
        public static readonly string IsSearchableWithLike;
        public static readonly string IsUnsigned;
        public static readonly string LiteralPrefix;
        public static readonly string LiteralSuffix;
        public static readonly string MaximumScale;
        public static readonly string MinimumScale;
        public static readonly string NumberOfIdentifierParts;
        public static readonly string NumberOfRestrictions;
        public static readonly string OrderByColumnsInSelect;
        public static readonly string ParameterMarkerFormat;
        public static readonly string ParameterMarkerPattern;
        public static readonly string ParameterNameMaxLength;
        public static readonly string ParameterNamePattern;
        public static readonly string ProviderDbType;
        public static readonly string QuotedIdentifierCase;
        public static readonly string QuotedIdentifierPattern;
        public static readonly string ReservedWord;
        public static readonly string StatementSeparatorPattern;
        public static readonly string StringLiteralPattern;
        public static readonly string SupportedJoinOperators;
        public static readonly string TypeName;
    }
    public abstract partial class DbParameter : System.MarshalByRefObject, System.Data.IDataParameter, System.Data.IDbDataParameter
    {
        protected DbParameter() { }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        public abstract System.Data.DbType DbType { get; set; }
        [System.ComponentModel.DefaultValueAttribute(System.Data.ParameterDirection.Input)]
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        public abstract System.Data.ParameterDirection Direction { get; set; }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignOnlyAttribute(true)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public abstract bool IsNullable { get; set; }
        [System.ComponentModel.DefaultValueAttribute("")]
        public abstract string ParameterName { get; set; }
        public virtual byte Precision { get { throw null; } set { } }
        public virtual byte Scale { get { throw null; } set { } }
        public abstract int Size { get; set; }
        [System.ComponentModel.DefaultValueAttribute("")]
        public abstract string SourceColumn { get; set; }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        public abstract bool SourceColumnNullMapping { get; set; }
        [System.ComponentModel.DefaultValueAttribute(System.Data.DataRowVersion.Current)]
        public virtual System.Data.DataRowVersion SourceVersion { get { throw null; } set { } }
        byte System.Data.IDbDataParameter.Precision { get { throw null; } set { } }
        byte System.Data.IDbDataParameter.Scale { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        public abstract object Value { get; set; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public abstract void ResetDbType();
    }
    public abstract partial class DbParameterCollection : System.MarshalByRefObject, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.Data.IDataParameterCollection
    {
        protected DbParameterCollection() { }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public abstract int Count { get; }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual bool IsFixedSize { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual bool IsReadOnly { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual bool IsSynchronized { get { throw null; } }
        public System.Data.Common.DbParameter this[int index] { get { throw null; } set { } }
        public System.Data.Common.DbParameter this[string parameterName] { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public abstract object SyncRoot { get; }
        object System.Collections.IList.this[int index] { get { throw null; } set { } }
        object System.Data.IDataParameterCollection.this[string parameterName] { get { throw null; } set { } }
        public abstract int Add(object value);
        public abstract void AddRange(System.Array values);
        public abstract void Clear();
        public abstract bool Contains(object value);
        public abstract bool Contains(string value);
        public abstract void CopyTo(System.Array array, int index);
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public abstract System.Collections.IEnumerator GetEnumerator();
        protected abstract System.Data.Common.DbParameter GetParameter(int index);
        protected abstract System.Data.Common.DbParameter GetParameter(string parameterName);
        public abstract int IndexOf(object value);
        public abstract int IndexOf(string parameterName);
        public abstract void Insert(int index, object value);
        public abstract void Remove(object value);
        public abstract void RemoveAt(int index);
        public abstract void RemoveAt(string parameterName);
        protected abstract void SetParameter(int index, System.Data.Common.DbParameter value);
        protected abstract void SetParameter(string parameterName, System.Data.Common.DbParameter value);
    }
    public static partial class DbProviderFactories
    {
        public static System.Data.Common.DbProviderFactory GetFactory(System.Data.Common.DbConnection connection) { throw null; }
        public static System.Data.Common.DbProviderFactory GetFactory(System.Data.DataRow providerRow) { throw null; }
        public static System.Data.Common.DbProviderFactory GetFactory(string providerInvariantName) { throw null; }
        public static System.Data.DataTable GetFactoryClasses() { throw null; }
        public static System.Collections.Generic.IEnumerable<string> GetProviderInvariantNames() { throw null; }
        public static void RegisterFactory(string providerInvariantName, System.Data.Common.DbProviderFactory factory) { }
        public static void RegisterFactory(string providerInvariantName, string factoryTypeAssemblyQualifiedName) { }
        public static void RegisterFactory(string providerInvariantName, System.Type providerFactoryClass) { }
        public static bool TryGetFactory(string providerInvariantName, out System.Data.Common.DbProviderFactory factory) { throw null; }
        public static bool UnregisterFactory(string providerInvariantName) { throw null; }
    }
    public abstract partial class DbProviderFactory
    {
        protected DbProviderFactory() { }
        public virtual bool CanCreateDataSourceEnumerator { get { throw null; } }
        public virtual System.Data.Common.DbCommand CreateCommand() { throw null; }
        public virtual System.Data.Common.DbCommandBuilder CreateCommandBuilder() { throw null; }
        public virtual System.Data.Common.DbConnection CreateConnection() { throw null; }
        public virtual System.Data.Common.DbConnectionStringBuilder CreateConnectionStringBuilder() { throw null; }
        public virtual System.Data.Common.DbDataAdapter CreateDataAdapter() { throw null; }
        public virtual System.Data.Common.DbDataSourceEnumerator CreateDataSourceEnumerator() { throw null; }
        public virtual System.Data.Common.DbParameter CreateParameter() { throw null; }
//CAS        public virtual System.Security.CodeAccessPermission CreatePermission(System.Security.Permissions.PermissionState state) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property, AllowMultiple=false, Inherited=true)]
    public sealed partial class DbProviderSpecificTypePropertyAttribute : System.Attribute
    {
        public DbProviderSpecificTypePropertyAttribute(bool isProviderSpecificTypeProperty) { }
        public bool IsProviderSpecificTypeProperty { get { throw null; } }
    }
    public abstract partial class DbTransaction : System.MarshalByRefObject, System.Data.IDbTransaction, System.IDisposable
    {
        protected DbTransaction() { }
        public System.Data.Common.DbConnection Connection { get { throw null; } }
        protected abstract System.Data.Common.DbConnection DbConnection { get; }
        public abstract System.Data.IsolationLevel IsolationLevel { get; }
        System.Data.IDbConnection System.Data.IDbTransaction.Connection { get { throw null; } }
        public abstract void Commit();
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public abstract void Rollback();
    }
    public enum GroupByBehavior
    {
        ExactMatch = 4,
        MustContainAll = 3,
        NotSupported = 1,
        Unknown = 0,
        Unrelated = 2,
    }
    public partial interface IDbColumnSchemaGenerator
    {
        System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Common.DbColumn> GetColumnSchema();
    }
    public enum IdentifierCase
    {
        Insensitive = 1,
        Sensitive = 2,
        Unknown = 0,
    }
    public partial class RowUpdatedEventArgs : System.EventArgs
    {
        public RowUpdatedEventArgs(System.Data.DataRow dataRow, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) { }
        public System.Data.IDbCommand Command { get { throw null; } }
        public System.Exception Errors { get { throw null; } set { } }
        public int RecordsAffected { get { throw null; } }
        public System.Data.DataRow Row { get { throw null; } }
        public int RowCount { get { throw null; } }
        public System.Data.StatementType StatementType { get { throw null; } }
        public System.Data.UpdateStatus Status { get { throw null; } set { } }
        public System.Data.Common.DataTableMapping TableMapping { get { throw null; } }
        public void CopyToRows(System.Data.DataRow[] array) { }
        public void CopyToRows(System.Data.DataRow[] array, int arrayIndex) { }
    }
    public partial class RowUpdatingEventArgs : System.EventArgs
    {
        public RowUpdatingEventArgs(System.Data.DataRow dataRow, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) { }
        protected virtual System.Data.IDbCommand BaseCommand { get { throw null; } set { } }
        public System.Data.IDbCommand Command { get { throw null; } set { } }
        public System.Exception Errors { get { throw null; } set { } }
        public System.Data.DataRow Row { get { throw null; } }
        public System.Data.StatementType StatementType { get { throw null; } }
        public System.Data.UpdateStatus Status { get { throw null; } set { } }
        public System.Data.Common.DataTableMapping TableMapping { get { throw null; } }
    }
    public static partial class SchemaTableColumn
    {
        public static readonly string AllowDBNull;
        public static readonly string BaseColumnName;
        public static readonly string BaseSchemaName;
        public static readonly string BaseTableName;
        public static readonly string ColumnName;
        public static readonly string ColumnOrdinal;
        public static readonly string ColumnSize;
        public static readonly string DataType;
        public static readonly string IsAliased;
        public static readonly string IsExpression;
        public static readonly string IsKey;
        public static readonly string IsLong;
        public static readonly string IsUnique;
        public static readonly string NonVersionedProviderType;
        public static readonly string NumericPrecision;
        public static readonly string NumericScale;
        public static readonly string ProviderType;
    }
    public static partial class SchemaTableOptionalColumn
    {
        public static readonly string AutoIncrementSeed;
        public static readonly string AutoIncrementStep;
        public static readonly string BaseCatalogName;
        public static readonly string BaseColumnNamespace;
        public static readonly string BaseServerName;
        public static readonly string BaseTableNamespace;
        public static readonly string ColumnMapping;
        public static readonly string DefaultValue;
        public static readonly string Expression;
        public static readonly string IsAutoIncrement;
        public static readonly string IsHidden;
        public static readonly string IsReadOnly;
        public static readonly string IsRowVersion;
        public static readonly string ProviderSpecificDataType;
    }
    [System.FlagsAttribute]
    public enum SupportedJoinOperators
    {
        FullOuter = 8,
        Inner = 1,
        LeftOuter = 2,
        None = 0,
        RightOuter = 4,
    }
}
