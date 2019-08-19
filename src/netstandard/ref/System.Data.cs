// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Data
{
    public enum AcceptRejectRule
    {
        Cascade = 1,
        None = 0,
    }
    [System.FlagsAttribute]
    public enum CommandBehavior
    {
        CloseConnection = 32,
        Default = 0,
        KeyInfo = 4,
        SchemaOnly = 2,
        SequentialAccess = 16,
        SingleResult = 1,
        SingleRow = 8,
    }
    public enum CommandType
    {
        StoredProcedure = 4,
        TableDirect = 512,
        Text = 1,
    }
    public enum ConflictOption
    {
        CompareAllSearchableValues = 1,
        CompareRowVersion = 2,
        OverwriteChanges = 3,
    }
    [System.FlagsAttribute]
    public enum ConnectionState
    {
        Broken = 16,
        Closed = 0,
        Connecting = 2,
        Executing = 4,
        Fetching = 8,
        Open = 1,
    }
    [System.ComponentModel.DefaultPropertyAttribute("ConstraintName")]
    public abstract partial class Constraint
    {
        internal Constraint() { }
        [System.ComponentModel.DefaultValueAttribute("")]
        public virtual string ConstraintName { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public System.Data.PropertyCollection ExtendedProperties { get { throw null; } }
        public abstract System.Data.DataTable Table { get; }
        [System.CLSCompliantAttribute(false)]
        protected virtual System.Data.DataSet _DataSet { get { throw null; } }
        protected void CheckStateForProperty() { }
        protected internal void SetDataSet(System.Data.DataSet dataSet) { }
        public override string ToString() { throw null; }
    }
    [System.ComponentModel.DefaultEventAttribute("CollectionChanged")]
    public sealed partial class ConstraintCollection : System.Data.InternalDataCollectionBase
    {
        internal ConstraintCollection() { }
        public System.Data.Constraint this[int index] { get { throw null; } }
        public System.Data.Constraint this[string name] { get { throw null; } }
        protected override System.Collections.ArrayList List { get { throw null; } }
        public event System.ComponentModel.CollectionChangeEventHandler CollectionChanged { add { } remove { } }
        public void Add(System.Data.Constraint constraint) { }
        public System.Data.Constraint Add(string name, System.Data.DataColumn column, bool primaryKey) { throw null; }
        public System.Data.Constraint Add(string name, System.Data.DataColumn primaryKeyColumn, System.Data.DataColumn foreignKeyColumn) { throw null; }
        public System.Data.Constraint Add(string name, System.Data.DataColumn[] columns, bool primaryKey) { throw null; }
        public System.Data.Constraint Add(string name, System.Data.DataColumn[] primaryKeyColumns, System.Data.DataColumn[] foreignKeyColumns) { throw null; }
        public void AddRange(System.Data.Constraint[] constraints) { }
        public bool CanRemove(System.Data.Constraint constraint) { throw null; }
        public void Clear() { }
        public bool Contains(string name) { throw null; }
        public void CopyTo(System.Data.Constraint[] array, int index) { }
        public int IndexOf(System.Data.Constraint constraint) { throw null; }
        public int IndexOf(string constraintName) { throw null; }
        public void Remove(System.Data.Constraint constraint) { }
        public void Remove(string name) { }
        public void RemoveAt(int index) { }
    }
    public partial class ConstraintException : System.Data.DataException
    {
        public ConstraintException() { }
        protected ConstraintException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public ConstraintException(string s) { }
        public ConstraintException(string message, System.Exception innerException) { }
    }
    [System.ComponentModel.DefaultPropertyAttribute("ColumnName")]
    [System.ComponentModel.DesignTimeVisibleAttribute(false)]
    [System.ComponentModel.ToolboxItemAttribute(false)]
    public partial class DataColumn : System.ComponentModel.MarshalByValueComponent
    {
        public DataColumn() { }
        public DataColumn(string columnName) { }
        public DataColumn(string columnName, System.Type dataType) { }
        public DataColumn(string columnName, System.Type dataType, string expr) { }
        public DataColumn(string columnName, System.Type dataType, string expr, System.Data.MappingType type) { }
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool AllowDBNull { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        public bool AutoIncrement { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute((long)0)]
        public long AutoIncrementSeed { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute((long)1)]
        public long AutoIncrementStep { get { throw null; } set { } }
        public string Caption { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(System.Data.MappingType.Element)]
        public virtual System.Data.MappingType ColumnMapping { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        public string ColumnName { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(typeof(string))]
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        public System.Type DataType { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(System.Data.DataSetDateTime.UnspecifiedLocal)]
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        public System.Data.DataSetDateTime DateTimeMode { get { throw null; } set { } }
        public object DefaultValue { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        public string Expression { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public System.Data.PropertyCollection ExtendedProperties { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute(-1)]
        public int MaxLength { get { throw null; } set { } }
        public string Namespace { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public int Ordinal { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute("")]
        public string Prefix { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool ReadOnly { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public System.Data.DataTable Table { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public bool Unique { get { throw null; } set { } }
        protected internal void CheckNotAllowNull() { }
        protected void CheckUnique() { }
        protected virtual void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent) { }
        protected internal void RaisePropertyChanging(string name) { }
        public void SetOrdinal(int ordinal) { }
        public override string ToString() { throw null; }
    }
    public partial class DataColumnChangeEventArgs : System.EventArgs
    {
        public DataColumnChangeEventArgs(System.Data.DataRow row, System.Data.DataColumn column, object value) { }
        public System.Data.DataColumn Column { get { throw null; } }
        public object ProposedValue { get { throw null; } set { } }
        public System.Data.DataRow Row { get { throw null; } }
    }
    public delegate void DataColumnChangeEventHandler(object sender, System.Data.DataColumnChangeEventArgs e);
    [System.ComponentModel.DefaultEventAttribute("CollectionChanged")]
    public sealed partial class DataColumnCollection : System.Data.InternalDataCollectionBase
    {
        internal DataColumnCollection() { }
        public System.Data.DataColumn this[int index] { get { throw null; } }
        public System.Data.DataColumn this[string name] { get { throw null; } }
        protected override System.Collections.ArrayList List { get { throw null; } }
        public event System.ComponentModel.CollectionChangeEventHandler CollectionChanged { add { } remove { } }
        public System.Data.DataColumn Add() { throw null; }
        public void Add(System.Data.DataColumn column) { }
        public System.Data.DataColumn Add(string columnName) { throw null; }
        public System.Data.DataColumn Add(string columnName, System.Type type) { throw null; }
        public System.Data.DataColumn Add(string columnName, System.Type type, string expression) { throw null; }
        public void AddRange(System.Data.DataColumn[] columns) { }
        public bool CanRemove(System.Data.DataColumn column) { throw null; }
        public void Clear() { }
        public bool Contains(string name) { throw null; }
        public void CopyTo(System.Data.DataColumn[] array, int index) { }
        public int IndexOf(System.Data.DataColumn column) { throw null; }
        public int IndexOf(string columnName) { throw null; }
        public void Remove(System.Data.DataColumn column) { }
        public void Remove(string name) { }
        public void RemoveAt(int index) { }
    }
    public static partial class DataReaderExtensions
    {
        public static bool GetBoolean(this System.Data.Common.DbDataReader reader, string name) { throw null; }
        public static byte GetByte(this System.Data.Common.DbDataReader reader, string name) { throw null; }
        public static long GetBytes(this System.Data.Common.DbDataReader reader, string name, long dataOffset, byte[] buffer, int bufferOffset, int length) { throw null; }
        public static char GetChar(this System.Data.Common.DbDataReader reader, string name) { throw null; }
        public static long GetChars(this System.Data.Common.DbDataReader reader, string name, long dataOffset, char[] buffer, int bufferOffset, int length) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public static System.Data.Common.DbDataReader GetData(this System.Data.Common.DbDataReader reader, string name) { throw null; }
        public static string GetDataTypeName(this System.Data.Common.DbDataReader reader, string name) { throw null; }
        public static System.DateTime GetDateTime(this System.Data.Common.DbDataReader reader, string name) { throw null; }
        public static decimal GetDecimal(this System.Data.Common.DbDataReader reader, string name) { throw null; }
        public static double GetDouble(this System.Data.Common.DbDataReader reader, string name) { throw null; }
        public static System.Type GetFieldType(this System.Data.Common.DbDataReader reader, string name) { throw null; }
        public static T GetFieldValue<T>(this System.Data.Common.DbDataReader reader, string name) { throw null; }
        public static System.Threading.Tasks.Task<T> GetFieldValueAsync<T>(
            this System.Data.Common.DbDataReader reader, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static float GetFloat(this System.Data.Common.DbDataReader reader, string name) { throw null; }
        public static System.Guid GetGuid(this System.Data.Common.DbDataReader reader, string name) { throw null; }
        public static short GetInt16(this System.Data.Common.DbDataReader reader, string name) { throw null; }
        public static int GetInt32(this System.Data.Common.DbDataReader reader, string name) { throw null; }
        public static long GetInt64(this System.Data.Common.DbDataReader reader, string name) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public static System.Type GetProviderSpecificFieldType(this System.Data.Common.DbDataReader reader, string name) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public static object GetProviderSpecificValue(this System.Data.Common.DbDataReader reader, string name) { throw null; }
        public static System.IO.Stream GetStream(this System.Data.Common.DbDataReader reader, string name) { throw null; }
        public static string GetString(this System.Data.Common.DbDataReader reader, string name) { throw null; }
        public static System.IO.TextReader GetTextReader(this System.Data.Common.DbDataReader reader, string name) { throw null; }
        public static object GetValue(this System.Data.Common.DbDataReader reader, string name) { throw null; }
        public static bool IsDBNull(this System.Data.Common.DbDataReader reader, string name) { throw null; }
        public static System.Threading.Tasks.Task<bool> IsDBNullAsync(
            this System.Data.Common.DbDataReader reader, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class DataException : System.SystemException
    {
        public DataException() { }
        protected DataException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public DataException(string s) { }
        public DataException(string s, System.Exception innerException) { }
    }
    [System.ComponentModel.DefaultPropertyAttribute("RelationName")]
    public partial class DataRelation
    {
        public DataRelation(string relationName, System.Data.DataColumn parentColumn, System.Data.DataColumn childColumn) { }
        public DataRelation(string relationName, System.Data.DataColumn parentColumn, System.Data.DataColumn childColumn, bool createConstraints) { }
        public DataRelation(string relationName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns) { }
        public DataRelation(string relationName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns, bool createConstraints) { }
        [System.ComponentModel.BrowsableAttribute(false)]
        public DataRelation(string relationName, string parentTableName, string parentTableNamespace, string childTableName, string childTableNamespace, string[] parentColumnNames, string[] childColumnNames, bool nested) { }
        [System.ComponentModel.BrowsableAttribute(false)]
        public DataRelation(string relationName, string parentTableName, string childTableName, string[] parentColumnNames, string[] childColumnNames, bool nested) { }
        public virtual System.Data.DataColumn[] ChildColumns { get { throw null; } }
        public virtual System.Data.ForeignKeyConstraint ChildKeyConstraint { get { throw null; } }
        public virtual System.Data.DataTable ChildTable { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public virtual System.Data.DataSet DataSet { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public System.Data.PropertyCollection ExtendedProperties { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        public virtual bool Nested { get { throw null; } set { } }
        public virtual System.Data.DataColumn[] ParentColumns { get { throw null; } }
        public virtual System.Data.UniqueConstraint ParentKeyConstraint { get { throw null; } }
        public virtual System.Data.DataTable ParentTable { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute("")]
        public virtual string RelationName { get { throw null; } set { } }
        protected void CheckStateForProperty() { }
        protected internal void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent) { }
        protected internal void RaisePropertyChanging(string name) { }
        public override string ToString() { throw null; }
    }
    [System.ComponentModel.DefaultEventAttribute("CollectionChanged")]
    [System.ComponentModel.DefaultPropertyAttribute("Table")]
    public abstract partial class DataRelationCollection : System.Data.InternalDataCollectionBase
    {
        protected DataRelationCollection() { }
        public abstract System.Data.DataRelation this[int index] { get; }
        public abstract System.Data.DataRelation this[string name] { get; }
        public event System.ComponentModel.CollectionChangeEventHandler CollectionChanged { add { } remove { } }
        public virtual System.Data.DataRelation Add(System.Data.DataColumn parentColumn, System.Data.DataColumn childColumn) { throw null; }
        public virtual System.Data.DataRelation Add(System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns) { throw null; }
        public void Add(System.Data.DataRelation relation) { }
        public virtual System.Data.DataRelation Add(string name, System.Data.DataColumn parentColumn, System.Data.DataColumn childColumn) { throw null; }
        public virtual System.Data.DataRelation Add(string name, System.Data.DataColumn parentColumn, System.Data.DataColumn childColumn, bool createConstraints) { throw null; }
        public virtual System.Data.DataRelation Add(string name, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns) { throw null; }
        public virtual System.Data.DataRelation Add(string name, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns, bool createConstraints) { throw null; }
        protected virtual void AddCore(System.Data.DataRelation relation) { }
        public virtual void AddRange(System.Data.DataRelation[] relations) { }
        public virtual bool CanRemove(System.Data.DataRelation relation) { throw null; }
        public virtual void Clear() { }
        public virtual bool Contains(string name) { throw null; }
        public void CopyTo(System.Data.DataRelation[] array, int index) { }
        protected abstract System.Data.DataSet GetDataSet();
        public virtual int IndexOf(System.Data.DataRelation relation) { throw null; }
        public virtual int IndexOf(string relationName) { throw null; }
        protected virtual void OnCollectionChanged(System.ComponentModel.CollectionChangeEventArgs ccevent) { }
        protected virtual void OnCollectionChanging(System.ComponentModel.CollectionChangeEventArgs ccevent) { }
        public void Remove(System.Data.DataRelation relation) { }
        public void Remove(string name) { }
        public void RemoveAt(int index) { }
        protected virtual void RemoveCore(System.Data.DataRelation relation) { }
    }
    public partial class DataRow
    {
        protected internal DataRow(System.Data.DataRowBuilder builder) { }
        public bool HasErrors { get { throw null; } }
        public object this[System.Data.DataColumn column] { get { throw null; } set { } }
        public object this[System.Data.DataColumn column, System.Data.DataRowVersion version] { get { throw null; } }
        public object this[int columnIndex] { get { throw null; } set { } }
        public object this[int columnIndex, System.Data.DataRowVersion version] { get { throw null; } }
        public object this[string columnName] { get { throw null; } set { } }
        public object this[string columnName, System.Data.DataRowVersion version] { get { throw null; } }
        public object[] ItemArray { get { throw null; } set { } }
        public string RowError { get { throw null; } set { } }
        public System.Data.DataRowState RowState { get { throw null; } }
        public System.Data.DataTable Table { get { throw null; } }
        public void AcceptChanges() { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void BeginEdit() { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void CancelEdit() { }
        public void ClearErrors() { }
        public void Delete() { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndEdit() { }
        public System.Data.DataRow[] GetChildRows(System.Data.DataRelation relation) { throw null; }
        public System.Data.DataRow[] GetChildRows(System.Data.DataRelation relation, System.Data.DataRowVersion version) { throw null; }
        public System.Data.DataRow[] GetChildRows(string relationName) { throw null; }
        public System.Data.DataRow[] GetChildRows(string relationName, System.Data.DataRowVersion version) { throw null; }
        public string GetColumnError(System.Data.DataColumn column) { throw null; }
        public string GetColumnError(int columnIndex) { throw null; }
        public string GetColumnError(string columnName) { throw null; }
        public System.Data.DataColumn[] GetColumnsInError() { throw null; }
        public System.Data.DataRow GetParentRow(System.Data.DataRelation relation) { throw null; }
        public System.Data.DataRow GetParentRow(System.Data.DataRelation relation, System.Data.DataRowVersion version) { throw null; }
        public System.Data.DataRow GetParentRow(string relationName) { throw null; }
        public System.Data.DataRow GetParentRow(string relationName, System.Data.DataRowVersion version) { throw null; }
        public System.Data.DataRow[] GetParentRows(System.Data.DataRelation relation) { throw null; }
        public System.Data.DataRow[] GetParentRows(System.Data.DataRelation relation, System.Data.DataRowVersion version) { throw null; }
        public System.Data.DataRow[] GetParentRows(string relationName) { throw null; }
        public System.Data.DataRow[] GetParentRows(string relationName, System.Data.DataRowVersion version) { throw null; }
        public bool HasVersion(System.Data.DataRowVersion version) { throw null; }
        public bool IsNull(System.Data.DataColumn column) { throw null; }
        public bool IsNull(System.Data.DataColumn column, System.Data.DataRowVersion version) { throw null; }
        public bool IsNull(int columnIndex) { throw null; }
        public bool IsNull(string columnName) { throw null; }
        public void RejectChanges() { }
        public void SetAdded() { }
        public void SetColumnError(System.Data.DataColumn column, string error) { }
        public void SetColumnError(int columnIndex, string error) { }
        public void SetColumnError(string columnName, string error) { }
        public void SetModified() { }
        protected void SetNull(System.Data.DataColumn column) { }
        public void SetParentRow(System.Data.DataRow parentRow) { }
        public void SetParentRow(System.Data.DataRow parentRow, System.Data.DataRelation relation) { }
    }
    [System.FlagsAttribute]
    public enum DataRowAction
    {
        Add = 16,
        Change = 2,
        ChangeCurrentAndOriginal = 64,
        ChangeOriginal = 32,
        Commit = 8,
        Delete = 1,
        Nothing = 0,
        Rollback = 4,
    }
    public sealed partial class DataRowBuilder
    {
        internal DataRowBuilder() { }
    }
    public partial class DataRowChangeEventArgs : System.EventArgs
    {
        public DataRowChangeEventArgs(System.Data.DataRow row, System.Data.DataRowAction action) { }
        public System.Data.DataRowAction Action { get { throw null; } }
        public System.Data.DataRow Row { get { throw null; } }
    }
    public delegate void DataRowChangeEventHandler(object sender, System.Data.DataRowChangeEventArgs e);
    public sealed partial class DataRowCollection : System.Data.InternalDataCollectionBase
    {
        internal DataRowCollection() { }
        public override int Count { get { throw null; } }
        public System.Data.DataRow this[int index] { get { throw null; } }
        public void Add(System.Data.DataRow row) { }
        public System.Data.DataRow Add(params object[] values) { throw null; }
        public void Clear() { }
        public bool Contains(object key) { throw null; }
        public bool Contains(object[] keys) { throw null; }
        public override void CopyTo(System.Array ar, int index) { }
        public void CopyTo(System.Data.DataRow[] array, int index) { }
        public System.Data.DataRow Find(object key) { throw null; }
        public System.Data.DataRow Find(object[] keys) { throw null; }
        public override System.Collections.IEnumerator GetEnumerator() { throw null; }
        public int IndexOf(System.Data.DataRow row) { throw null; }
        public void InsertAt(System.Data.DataRow row, int pos) { }
        public void Remove(System.Data.DataRow row) { }
        public void RemoveAt(int index) { }
    }
    public static partial class DataRowComparer
    {
        public static System.Data.DataRowComparer<System.Data.DataRow> Default { get { throw null; } }
    }
    public sealed partial class DataRowComparer<TRow> : System.Collections.Generic.IEqualityComparer<TRow> where TRow : System.Data.DataRow
    {
        internal DataRowComparer() { }
        public static System.Data.DataRowComparer<TRow> Default { get { throw null; } }
        public bool Equals(TRow leftRow, TRow rightRow) { throw null; }
        public int GetHashCode(TRow row) { throw null; }
    }
    public static partial class DataRowExtensions
    {
        public static T Field<T>(this System.Data.DataRow row, System.Data.DataColumn column) { throw null; }
        public static T Field<T>(this System.Data.DataRow row, System.Data.DataColumn column, System.Data.DataRowVersion version) { throw null; }
        public static T Field<T>(this System.Data.DataRow row, int columnIndex) { throw null; }
        public static T Field<T>(this System.Data.DataRow row, int columnIndex, System.Data.DataRowVersion version) { throw null; }
        public static T Field<T>(this System.Data.DataRow row, string columnName) { throw null; }
        public static T Field<T>(this System.Data.DataRow row, string columnName, System.Data.DataRowVersion version) { throw null; }
        public static void SetField<T>(this System.Data.DataRow row, System.Data.DataColumn column, T value) { }
        public static void SetField<T>(this System.Data.DataRow row, int columnIndex, T value) { }
        public static void SetField<T>(this System.Data.DataRow row, string columnName, T value) { }
    }
    [System.FlagsAttribute]
    public enum DataRowState
    {
        Added = 4,
        Deleted = 8,
        Detached = 1,
        Modified = 16,
        Unchanged = 2,
    }
    public enum DataRowVersion
    {
        Current = 512,
        Default = 1536,
        Original = 256,
        Proposed = 1024,
    }
    public partial class DataRowView : System.ComponentModel.ICustomTypeDescriptor, System.ComponentModel.IDataErrorInfo, System.ComponentModel.IEditableObject, System.ComponentModel.INotifyPropertyChanged
    {
        internal DataRowView() { }
        public System.Data.DataView DataView { get { throw null; } }
        public bool IsEdit { get { throw null; } }
        public bool IsNew { get { throw null; } }
        public object this[int ndx] { get { throw null; } set { } }
        public object this[string property] { get { throw null; } set { } }
        public System.Data.DataRow Row { get { throw null; } }
        public System.Data.DataRowVersion RowVersion { get { throw null; } }
        string System.ComponentModel.IDataErrorInfo.Error { get { throw null; } }
        string System.ComponentModel.IDataErrorInfo.this[string colName] { get { throw null; } }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged { add { } remove { } }
        public void BeginEdit() { }
        public void CancelEdit() { }
        public System.Data.DataView CreateChildView(System.Data.DataRelation relation) { throw null; }
        public System.Data.DataView CreateChildView(System.Data.DataRelation relation, bool followParent) { throw null; }
        public System.Data.DataView CreateChildView(string relationName) { throw null; }
        public System.Data.DataView CreateChildView(string relationName, bool followParent) { throw null; }
        public void Delete() { }
        public void EndEdit() { }
        public override bool Equals(object other) { throw null; }
        public override int GetHashCode() { throw null; }
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
    [System.ComponentModel.DefaultPropertyAttribute("DataSetName")]
    [System.ComponentModel.ToolboxItemAttribute("Microsoft.VSDesigner.Data.VS.DataSetToolboxItem, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Xml.Serialization.XmlSchemaProviderAttribute("GetDataSetSchema")]
    public partial class DataSet : System.ComponentModel.MarshalByValueComponent, System.ComponentModel.IListSource, System.ComponentModel.ISupportInitialize, System.ComponentModel.ISupportInitializeNotification, System.Runtime.Serialization.ISerializable, System.Xml.Serialization.IXmlSerializable
    {
        public DataSet() { }
        protected DataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        protected DataSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, bool ConstructSchema) { }
        public DataSet(string dataSetName) { }
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool CaseSensitive { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        public string DataSetName { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public System.Data.DataViewManager DefaultViewManager { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool EnforceConstraints { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public System.Data.PropertyCollection ExtendedProperties { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public bool HasErrors { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public bool IsInitialized { get { throw null; } }
        public System.Globalization.CultureInfo Locale { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        public string Namespace { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        public string Prefix { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public System.Data.DataRelationCollection Relations { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute(System.Data.SerializationFormat.Xml)]
        public System.Data.SerializationFormat RemotingFormat { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public virtual System.Data.SchemaSerializationMode SchemaSerializationMode { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public override System.ComponentModel.ISite Site { get { throw null; } set { } }
        bool System.ComponentModel.IListSource.ContainsListCollection { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public System.Data.DataTableCollection Tables { get { throw null; } }
        public event System.EventHandler Initialized { add { } remove { } }
        public event System.Data.MergeFailedEventHandler MergeFailed { add { } remove { } }
        public void AcceptChanges() { }
        public void BeginInit() { }
        public void Clear() { }
        public virtual System.Data.DataSet Clone() { throw null; }
        public System.Data.DataSet Copy() { throw null; }
        public System.Data.DataTableReader CreateDataReader() { throw null; }
        public System.Data.DataTableReader CreateDataReader(params System.Data.DataTable[] dataTables) { throw null; }
        protected System.Data.SchemaSerializationMode DetermineSchemaSerializationMode(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { throw null; }
        protected System.Data.SchemaSerializationMode DetermineSchemaSerializationMode(System.Xml.XmlReader reader) { throw null; }
        public void EndInit() { }
        public System.Data.DataSet GetChanges() { throw null; }
        public System.Data.DataSet GetChanges(System.Data.DataRowState rowStates) { throw null; }
        public static System.Xml.Schema.XmlSchemaComplexType GetDataSetSchema(System.Xml.Schema.XmlSchemaSet schemaSet) { throw null; }
        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        protected virtual System.Xml.Schema.XmlSchema GetSchemaSerializable() { throw null; }
        protected void GetSerializationData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public string GetXml() { throw null; }
        public string GetXmlSchema() { throw null; }
        public bool HasChanges() { throw null; }
        public bool HasChanges(System.Data.DataRowState rowStates) { throw null; }
        public void InferXmlSchema(System.IO.Stream stream, string[] nsArray) { }
        public void InferXmlSchema(System.IO.TextReader reader, string[] nsArray) { }
        public void InferXmlSchema(string fileName, string[] nsArray) { }
        public void InferXmlSchema(System.Xml.XmlReader reader, string[] nsArray) { }
        protected virtual void InitializeDerivedDataSet() { }
        protected bool IsBinarySerialized(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { throw null; }
        public void Load(System.Data.IDataReader reader, System.Data.LoadOption loadOption, params System.Data.DataTable[] tables) { }
        public virtual void Load(System.Data.IDataReader reader, System.Data.LoadOption loadOption, System.Data.FillErrorEventHandler errorHandler, params System.Data.DataTable[] tables) { }
        public void Load(System.Data.IDataReader reader, System.Data.LoadOption loadOption, params string[] tables) { }
        public void Merge(System.Data.DataRow[] rows) { }
        public void Merge(System.Data.DataRow[] rows, bool preserveChanges, System.Data.MissingSchemaAction missingSchemaAction) { }
        public void Merge(System.Data.DataSet dataSet) { }
        public void Merge(System.Data.DataSet dataSet, bool preserveChanges) { }
        public void Merge(System.Data.DataSet dataSet, bool preserveChanges, System.Data.MissingSchemaAction missingSchemaAction) { }
        public void Merge(System.Data.DataTable table) { }
        public void Merge(System.Data.DataTable table, bool preserveChanges, System.Data.MissingSchemaAction missingSchemaAction) { }
        protected virtual void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent) { }
        protected virtual void OnRemoveRelation(System.Data.DataRelation relation) { }
        protected internal virtual void OnRemoveTable(System.Data.DataTable table) { }
        protected internal void RaisePropertyChanging(string name) { }
        public System.Data.XmlReadMode ReadXml(System.IO.Stream stream) { throw null; }
        public System.Data.XmlReadMode ReadXml(System.IO.Stream stream, System.Data.XmlReadMode mode) { throw null; }
        public System.Data.XmlReadMode ReadXml(System.IO.TextReader reader) { throw null; }
        public System.Data.XmlReadMode ReadXml(System.IO.TextReader reader, System.Data.XmlReadMode mode) { throw null; }
        public System.Data.XmlReadMode ReadXml(string fileName) { throw null; }
        public System.Data.XmlReadMode ReadXml(string fileName, System.Data.XmlReadMode mode) { throw null; }
        public System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader) { throw null; }
        public System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader, System.Data.XmlReadMode mode) { throw null; }
        public void ReadXmlSchema(System.IO.Stream stream) { }
        public void ReadXmlSchema(System.IO.TextReader reader) { }
        public void ReadXmlSchema(string fileName) { }
        public void ReadXmlSchema(System.Xml.XmlReader reader) { }
        protected virtual void ReadXmlSerializable(System.Xml.XmlReader reader) { }
        public virtual void RejectChanges() { }
        public virtual void Reset() { }
        protected virtual bool ShouldSerializeRelations() { throw null; }
        protected virtual bool ShouldSerializeTables() { throw null; }
        System.Collections.IList System.ComponentModel.IListSource.GetList() { throw null; }
        System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { throw null; }
        void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
        void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        public void WriteXml(System.IO.Stream stream) { }
        public void WriteXml(System.IO.Stream stream, System.Data.XmlWriteMode mode) { }
        public void WriteXml(System.IO.TextWriter writer) { }
        public void WriteXml(System.IO.TextWriter writer, System.Data.XmlWriteMode mode) { }
        public void WriteXml(string fileName) { }
        public void WriteXml(string fileName, System.Data.XmlWriteMode mode) { }
        public void WriteXml(System.Xml.XmlWriter writer) { }
        public void WriteXml(System.Xml.XmlWriter writer, System.Data.XmlWriteMode mode) { }
        public void WriteXmlSchema(System.IO.Stream stream) { }
        public void WriteXmlSchema(System.IO.Stream stream, System.Converter<System.Type, string> multipleTargetConverter) { }
        public void WriteXmlSchema(System.IO.TextWriter writer) { }
        public void WriteXmlSchema(System.IO.TextWriter writer, System.Converter<System.Type, string> multipleTargetConverter) { }
        public void WriteXmlSchema(string fileName) { }
        public void WriteXmlSchema(string fileName, System.Converter<System.Type, string> multipleTargetConverter) { }
        public void WriteXmlSchema(System.Xml.XmlWriter writer) { }
        public void WriteXmlSchema(System.Xml.XmlWriter writer, System.Converter<System.Type, string> multipleTargetConverter) { }
    }
    public enum DataSetDateTime
    {
        Local = 1,
        Unspecified = 2,
        UnspecifiedLocal = 3,
        Utc = 4,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All)]
    [System.ObsoleteAttribute("DataSysDescriptionAttribute has been deprecated.  https://go.microsoft.com/fwlink/?linkid=14202", false)]
    public partial class DataSysDescriptionAttribute : System.ComponentModel.DescriptionAttribute
    {
        [System.ObsoleteAttribute("DataSysDescriptionAttribute has been deprecated.  https://go.microsoft.com/fwlink/?linkid=14202", false)]
        public DataSysDescriptionAttribute(string description) { }
        public override string Description { get { throw null; } }
    }
    [System.ComponentModel.DefaultEventAttribute("RowChanging")]
    [System.ComponentModel.DefaultPropertyAttribute("TableName")]
    [System.ComponentModel.DesignTimeVisibleAttribute(false)]
    [System.ComponentModel.ToolboxItemAttribute(false)]
    [System.Xml.Serialization.XmlSchemaProviderAttribute("GetDataTableSchema")]
    public partial class DataTable : System.ComponentModel.MarshalByValueComponent, System.ComponentModel.IListSource, System.ComponentModel.ISupportInitialize, System.ComponentModel.ISupportInitializeNotification, System.Runtime.Serialization.ISerializable, System.Xml.Serialization.IXmlSerializable
    {
        protected internal bool fInitInProgress;
        public DataTable() { }
        protected DataTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public DataTable(string tableName) { }
        public DataTable(string tableName, string tableNamespace) { }
        public bool CaseSensitive { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public System.Data.DataRelationCollection ChildRelations { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public System.Data.DataColumnCollection Columns { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public System.Data.ConstraintCollection Constraints { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public System.Data.DataSet DataSet { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public System.Data.DataView DefaultView { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute("")]
        public string DisplayExpression { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public System.Data.PropertyCollection ExtendedProperties { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public bool HasErrors { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public bool IsInitialized { get { throw null; } }
        public System.Globalization.CultureInfo Locale { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(50)]
        public int MinimumCapacity { get { throw null; } set { } }
        public string Namespace { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public System.Data.DataRelationCollection ParentRelations { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute("")]
        public string Prefix { get { throw null; } set { } }
        public System.Data.DataColumn[] PrimaryKey { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(System.Data.SerializationFormat.Xml)]
        public System.Data.SerializationFormat RemotingFormat { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public System.Data.DataRowCollection Rows { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public override System.ComponentModel.ISite Site { get { throw null; } set { } }
        bool System.ComponentModel.IListSource.ContainsListCollection { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        public string TableName { get { throw null; } set { } }
        public event System.Data.DataColumnChangeEventHandler ColumnChanged { add { } remove { } }
        public event System.Data.DataColumnChangeEventHandler ColumnChanging { add { } remove { } }
        public event System.EventHandler Initialized { add { } remove { } }
        public event System.Data.DataRowChangeEventHandler RowChanged { add { } remove { } }
        public event System.Data.DataRowChangeEventHandler RowChanging { add { } remove { } }
        public event System.Data.DataRowChangeEventHandler RowDeleted { add { } remove { } }
        public event System.Data.DataRowChangeEventHandler RowDeleting { add { } remove { } }
        public event System.Data.DataTableClearEventHandler TableCleared { add { } remove { } }
        public event System.Data.DataTableClearEventHandler TableClearing { add { } remove { } }
        public event System.Data.DataTableNewRowEventHandler TableNewRow { add { } remove { } }
        public void AcceptChanges() { }
        public virtual void BeginInit() { }
        public void BeginLoadData() { }
        public void Clear() { }
        public virtual System.Data.DataTable Clone() { throw null; }
        public object Compute(string expression, string filter) { throw null; }
        public System.Data.DataTable Copy() { throw null; }
        public System.Data.DataTableReader CreateDataReader() { throw null; }
        protected virtual System.Data.DataTable CreateInstance() { throw null; }
        public virtual void EndInit() { }
        public void EndLoadData() { }
        public System.Data.DataTable GetChanges() { throw null; }
        public System.Data.DataTable GetChanges(System.Data.DataRowState rowStates) { throw null; }
        public static System.Xml.Schema.XmlSchemaComplexType GetDataTableSchema(System.Xml.Schema.XmlSchemaSet schemaSet) { throw null; }
        public System.Data.DataRow[] GetErrors() { throw null; }
        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        protected virtual System.Type GetRowType() { throw null; }
        protected virtual System.Xml.Schema.XmlSchema GetSchema() { throw null; }
        public void ImportRow(System.Data.DataRow row) { }
        public void Load(System.Data.IDataReader reader) { }
        public void Load(System.Data.IDataReader reader, System.Data.LoadOption loadOption) { }
        public virtual void Load(System.Data.IDataReader reader, System.Data.LoadOption loadOption, System.Data.FillErrorEventHandler errorHandler) { }
        public System.Data.DataRow LoadDataRow(object[] values, bool fAcceptChanges) { throw null; }
        public System.Data.DataRow LoadDataRow(object[] values, System.Data.LoadOption loadOption) { throw null; }
        public void Merge(System.Data.DataTable table) { }
        public void Merge(System.Data.DataTable table, bool preserveChanges) { }
        public void Merge(System.Data.DataTable table, bool preserveChanges, System.Data.MissingSchemaAction missingSchemaAction) { }
        public System.Data.DataRow NewRow() { throw null; }
        protected internal System.Data.DataRow[] NewRowArray(int size) { throw null; }
        protected virtual System.Data.DataRow NewRowFromBuilder(System.Data.DataRowBuilder builder) { throw null; }
        protected internal virtual void OnColumnChanged(System.Data.DataColumnChangeEventArgs e) { }
        protected internal virtual void OnColumnChanging(System.Data.DataColumnChangeEventArgs e) { }
        protected virtual void OnPropertyChanging(System.ComponentModel.PropertyChangedEventArgs pcevent) { }
        protected virtual void OnRemoveColumn(System.Data.DataColumn column) { }
        protected virtual void OnRowChanged(System.Data.DataRowChangeEventArgs e) { }
        protected virtual void OnRowChanging(System.Data.DataRowChangeEventArgs e) { }
        protected virtual void OnRowDeleted(System.Data.DataRowChangeEventArgs e) { }
        protected virtual void OnRowDeleting(System.Data.DataRowChangeEventArgs e) { }
        protected virtual void OnTableCleared(System.Data.DataTableClearEventArgs e) { }
        protected virtual void OnTableClearing(System.Data.DataTableClearEventArgs e) { }
        protected virtual void OnTableNewRow(System.Data.DataTableNewRowEventArgs e) { }
        public System.Data.XmlReadMode ReadXml(System.IO.Stream stream) { throw null; }
        public System.Data.XmlReadMode ReadXml(System.IO.TextReader reader) { throw null; }
        public System.Data.XmlReadMode ReadXml(string fileName) { throw null; }
        public System.Data.XmlReadMode ReadXml(System.Xml.XmlReader reader) { throw null; }
        public void ReadXmlSchema(System.IO.Stream stream) { }
        public void ReadXmlSchema(System.IO.TextReader reader) { }
        public void ReadXmlSchema(string fileName) { }
        public void ReadXmlSchema(System.Xml.XmlReader reader) { }
        protected virtual void ReadXmlSerializable(System.Xml.XmlReader reader) { }
        public void RejectChanges() { }
        public virtual void Reset() { }
        public System.Data.DataRow[] Select() { throw null; }
        public System.Data.DataRow[] Select(string filterExpression) { throw null; }
        public System.Data.DataRow[] Select(string filterExpression, string sort) { throw null; }
        public System.Data.DataRow[] Select(string filterExpression, string sort, System.Data.DataViewRowState recordStates) { throw null; }
        System.Collections.IList System.ComponentModel.IListSource.GetList() { throw null; }
        System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { throw null; }
        void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
        void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        public override string ToString() { throw null; }
        public void WriteXml(System.IO.Stream stream) { }
        public void WriteXml(System.IO.Stream stream, bool writeHierarchy) { }
        public void WriteXml(System.IO.Stream stream, System.Data.XmlWriteMode mode) { }
        public void WriteXml(System.IO.Stream stream, System.Data.XmlWriteMode mode, bool writeHierarchy) { }
        public void WriteXml(System.IO.TextWriter writer) { }
        public void WriteXml(System.IO.TextWriter writer, bool writeHierarchy) { }
        public void WriteXml(System.IO.TextWriter writer, System.Data.XmlWriteMode mode) { }
        public void WriteXml(System.IO.TextWriter writer, System.Data.XmlWriteMode mode, bool writeHierarchy) { }
        public void WriteXml(string fileName) { }
        public void WriteXml(string fileName, bool writeHierarchy) { }
        public void WriteXml(string fileName, System.Data.XmlWriteMode mode) { }
        public void WriteXml(string fileName, System.Data.XmlWriteMode mode, bool writeHierarchy) { }
        public void WriteXml(System.Xml.XmlWriter writer) { }
        public void WriteXml(System.Xml.XmlWriter writer, bool writeHierarchy) { }
        public void WriteXml(System.Xml.XmlWriter writer, System.Data.XmlWriteMode mode) { }
        public void WriteXml(System.Xml.XmlWriter writer, System.Data.XmlWriteMode mode, bool writeHierarchy) { }
        public void WriteXmlSchema(System.IO.Stream stream) { }
        public void WriteXmlSchema(System.IO.Stream stream, bool writeHierarchy) { }
        public void WriteXmlSchema(System.IO.TextWriter writer) { }
        public void WriteXmlSchema(System.IO.TextWriter writer, bool writeHierarchy) { }
        public void WriteXmlSchema(string fileName) { }
        public void WriteXmlSchema(string fileName, bool writeHierarchy) { }
        public void WriteXmlSchema(System.Xml.XmlWriter writer) { }
        public void WriteXmlSchema(System.Xml.XmlWriter writer, bool writeHierarchy) { }
    }
    public sealed partial class DataTableClearEventArgs : System.EventArgs
    {
        public DataTableClearEventArgs(System.Data.DataTable dataTable) { }
        public System.Data.DataTable Table { get { throw null; } }
        public string TableName { get { throw null; } }
        public string TableNamespace { get { throw null; } }
    }
    public delegate void DataTableClearEventHandler(object sender, System.Data.DataTableClearEventArgs e);
    [System.ComponentModel.DefaultEventAttribute("CollectionChanged")]
    [System.ComponentModel.ListBindableAttribute(false)]
    public sealed partial class DataTableCollection : System.Data.InternalDataCollectionBase
    {
        internal DataTableCollection() { }
        public System.Data.DataTable this[int index] { get { throw null; } }
        public System.Data.DataTable this[string name] { get { throw null; } }
        public System.Data.DataTable this[string name, string tableNamespace] { get { throw null; } }
        protected override System.Collections.ArrayList List { get { throw null; } }
        public event System.ComponentModel.CollectionChangeEventHandler CollectionChanged { add { } remove { } }
        public event System.ComponentModel.CollectionChangeEventHandler CollectionChanging { add { } remove { } }
        public System.Data.DataTable Add() { throw null; }
        public void Add(System.Data.DataTable table) { }
        public System.Data.DataTable Add(string name) { throw null; }
        public System.Data.DataTable Add(string name, string tableNamespace) { throw null; }
        public void AddRange(System.Data.DataTable[] tables) { }
        public bool CanRemove(System.Data.DataTable table) { throw null; }
        public void Clear() { }
        public bool Contains(string name) { throw null; }
        public bool Contains(string name, string tableNamespace) { throw null; }
        public void CopyTo(System.Data.DataTable[] array, int index) { }
        public int IndexOf(System.Data.DataTable table) { throw null; }
        public int IndexOf(string tableName) { throw null; }
        public int IndexOf(string tableName, string tableNamespace) { throw null; }
        public void Remove(System.Data.DataTable table) { }
        public void Remove(string name) { }
        public void Remove(string name, string tableNamespace) { }
        public void RemoveAt(int index) { }
    }
    public static partial class DataTableExtensions
    {
        public static System.Data.DataView AsDataView(this System.Data.DataTable table) { throw null; }
        public static System.Data.DataView AsDataView<T>(this System.Data.EnumerableRowCollection<T> source) where T : System.Data.DataRow { throw null; }
        public static System.Data.EnumerableRowCollection<System.Data.DataRow> AsEnumerable(this System.Data.DataTable source) { throw null; }
        public static System.Data.DataTable CopyToDataTable<T>(this System.Collections.Generic.IEnumerable<T> source) where T : System.Data.DataRow { throw null; }
        public static void CopyToDataTable<T>(this System.Collections.Generic.IEnumerable<T> source, System.Data.DataTable table, System.Data.LoadOption options) where T : System.Data.DataRow { }
        public static void CopyToDataTable<T>(this System.Collections.Generic.IEnumerable<T> source, System.Data.DataTable table, System.Data.LoadOption options, System.Data.FillErrorEventHandler errorHandler) where T : System.Data.DataRow { }
    }
    public sealed partial class DataTableNewRowEventArgs : System.EventArgs
    {
        public DataTableNewRowEventArgs(System.Data.DataRow dataRow) { }
        public System.Data.DataRow Row { get { throw null; } }
    }
    public delegate void DataTableNewRowEventHandler(object sender, System.Data.DataTableNewRowEventArgs e);
    public sealed partial class DataTableReader : System.Data.Common.DbDataReader
    {
        public DataTableReader(System.Data.DataTable dataTable) { }
        public DataTableReader(System.Data.DataTable[] dataTables) { }
        public override int Depth { get { throw null; } }
        public override int FieldCount { get { throw null; } }
        public override bool HasRows { get { throw null; } }
        public override bool IsClosed { get { throw null; } }
        public override object this[int ordinal] { get { throw null; } }
        public override object this[string name] { get { throw null; } }
        public override int RecordsAffected { get { throw null; } }
        public override void Close() { }
        public override bool GetBoolean(int ordinal) { throw null; }
        public override byte GetByte(int ordinal) { throw null; }
        public override long GetBytes(int ordinal, long dataIndex, byte[] buffer, int bufferIndex, int length) { throw null; }
        public override char GetChar(int ordinal) { throw null; }
        public override long GetChars(int ordinal, long dataIndex, char[] buffer, int bufferIndex, int length) { throw null; }
        public override string GetDataTypeName(int ordinal) { throw null; }
        public override System.DateTime GetDateTime(int ordinal) { throw null; }
        public override decimal GetDecimal(int ordinal) { throw null; }
        public override double GetDouble(int ordinal) { throw null; }
        public override System.Collections.IEnumerator GetEnumerator() { throw null; }
        public override System.Type GetFieldType(int ordinal) { throw null; }
        public override float GetFloat(int ordinal) { throw null; }
        public override System.Guid GetGuid(int ordinal) { throw null; }
        public override short GetInt16(int ordinal) { throw null; }
        public override int GetInt32(int ordinal) { throw null; }
        public override long GetInt64(int ordinal) { throw null; }
        public override string GetName(int ordinal) { throw null; }
        public override int GetOrdinal(string name) { throw null; }
        public override System.Type GetProviderSpecificFieldType(int ordinal) { throw null; }
        public override object GetProviderSpecificValue(int ordinal) { throw null; }
        public override int GetProviderSpecificValues(object[] values) { throw null; }
        public override System.Data.DataTable GetSchemaTable() { throw null; }
        public override string GetString(int ordinal) { throw null; }
        public override object GetValue(int ordinal) { throw null; }
        public override int GetValues(object[] values) { throw null; }
        public override bool IsDBNull(int ordinal) { throw null; }
        public override bool NextResult() { throw null; }
        public override bool Read() { throw null; }
    }
    [System.ComponentModel.DefaultEventAttribute("PositionChanged")]
    [System.ComponentModel.DefaultPropertyAttribute("Table")]
    public partial class DataView : System.ComponentModel.MarshalByValueComponent, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ComponentModel.IBindingList, System.ComponentModel.IBindingListView, System.ComponentModel.ISupportInitialize, System.ComponentModel.ISupportInitializeNotification, System.ComponentModel.ITypedList
    {
        public DataView() { }
        public DataView(System.Data.DataTable table) { }
        public DataView(System.Data.DataTable table, string RowFilter, string Sort, System.Data.DataViewRowState RowState) { }
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool AllowDelete { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool AllowEdit { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool AllowNew { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        public bool ApplyDefaultSort { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public int Count { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public System.Data.DataViewManager DataViewManager { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public bool IsInitialized { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        protected bool IsOpen { get { throw null; } }
        public System.Data.DataRowView this[int recordIndex] { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute("")]
        public virtual string RowFilter { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(System.Data.DataViewRowState.CurrentRows)]
        public System.Data.DataViewRowState RowStateFilter { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        public string Sort { get { throw null; } set { } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        bool System.Collections.IList.IsFixedSize { get { throw null; } }
        bool System.Collections.IList.IsReadOnly { get { throw null; } }
        object System.Collections.IList.this[int recordIndex] { get { throw null; } set { } }
        bool System.ComponentModel.IBindingList.AllowEdit { get { throw null; } }
        bool System.ComponentModel.IBindingList.AllowNew { get { throw null; } }
        bool System.ComponentModel.IBindingList.AllowRemove { get { throw null; } }
        bool System.ComponentModel.IBindingList.IsSorted { get { throw null; } }
        System.ComponentModel.ListSortDirection System.ComponentModel.IBindingList.SortDirection { get { throw null; } }
        System.ComponentModel.PropertyDescriptor System.ComponentModel.IBindingList.SortProperty { get { throw null; } }
        bool System.ComponentModel.IBindingList.SupportsChangeNotification { get { throw null; } }
        bool System.ComponentModel.IBindingList.SupportsSearching { get { throw null; } }
        bool System.ComponentModel.IBindingList.SupportsSorting { get { throw null; } }
        string System.ComponentModel.IBindingListView.Filter { get { throw null; } set { } }
        System.ComponentModel.ListSortDescriptionCollection System.ComponentModel.IBindingListView.SortDescriptions { get { throw null; } }
        bool System.ComponentModel.IBindingListView.SupportsAdvancedSorting { get { throw null; } }
        bool System.ComponentModel.IBindingListView.SupportsFiltering { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        public System.Data.DataTable Table { get { throw null; } set { } }
        public event System.EventHandler Initialized { add { } remove { } }
        public event System.ComponentModel.ListChangedEventHandler ListChanged { add { } remove { } }
        public virtual System.Data.DataRowView AddNew() { throw null; }
        public void BeginInit() { }
        protected void Close() { }
        protected virtual void ColumnCollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) { }
        public void CopyTo(System.Array array, int index) { }
        public void Delete(int index) { }
        protected override void Dispose(bool disposing) { }
        public void EndInit() { }
        public virtual bool Equals(System.Data.DataView view) { throw null; }
        public int Find(object key) { throw null; }
        public int Find(object[] key) { throw null; }
        public System.Data.DataRowView[] FindRows(object key) { throw null; }
        public System.Data.DataRowView[] FindRows(object[] key) { throw null; }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        protected virtual void IndexListChanged(object sender, System.ComponentModel.ListChangedEventArgs e) { }
        protected virtual void OnListChanged(System.ComponentModel.ListChangedEventArgs e) { }
        protected void Open() { }
        protected void Reset() { }
        int System.Collections.IList.Add(object value) { throw null; }
        void System.Collections.IList.Clear() { }
        bool System.Collections.IList.Contains(object value) { throw null; }
        int System.Collections.IList.IndexOf(object value) { throw null; }
        void System.Collections.IList.Insert(int index, object value) { }
        void System.Collections.IList.Remove(object value) { }
        void System.Collections.IList.RemoveAt(int index) { }
        void System.ComponentModel.IBindingList.AddIndex(System.ComponentModel.PropertyDescriptor property) { }
        object System.ComponentModel.IBindingList.AddNew() { throw null; }
        void System.ComponentModel.IBindingList.ApplySort(System.ComponentModel.PropertyDescriptor property, System.ComponentModel.ListSortDirection direction) { }
        int System.ComponentModel.IBindingList.Find(System.ComponentModel.PropertyDescriptor property, object key) { throw null; }
        void System.ComponentModel.IBindingList.RemoveIndex(System.ComponentModel.PropertyDescriptor property) { }
        void System.ComponentModel.IBindingList.RemoveSort() { }
        void System.ComponentModel.IBindingListView.ApplySort(System.ComponentModel.ListSortDescriptionCollection sorts) { }
        void System.ComponentModel.IBindingListView.RemoveFilter() { }
        System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(System.ComponentModel.PropertyDescriptor[] listAccessors) { throw null; }
        string System.ComponentModel.ITypedList.GetListName(System.ComponentModel.PropertyDescriptor[] listAccessors) { throw null; }
        public System.Data.DataTable ToTable() { throw null; }
        public System.Data.DataTable ToTable(bool distinct, params string[] columnNames) { throw null; }
        public System.Data.DataTable ToTable(string tableName) { throw null; }
        public System.Data.DataTable ToTable(string tableName, bool distinct, params string[] columnNames) { throw null; }
        protected void UpdateIndex() { }
        protected virtual void UpdateIndex(bool force) { }
    }
    public partial class DataViewManager : System.ComponentModel.MarshalByValueComponent, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ComponentModel.IBindingList, System.ComponentModel.ITypedList
    {
        public DataViewManager() { }
        public DataViewManager(System.Data.DataSet dataSet) { }
        [System.ComponentModel.DefaultValueAttribute(null)]
        public System.Data.DataSet DataSet { get { throw null; } set { } }
        public string DataViewSettingCollectionString { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public System.Data.DataViewSettingCollection DataViewSettings { get { throw null; } }
        int System.Collections.ICollection.Count { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        bool System.Collections.IList.IsFixedSize { get { throw null; } }
        bool System.Collections.IList.IsReadOnly { get { throw null; } }
        object System.Collections.IList.this[int index] { get { throw null; } set { } }
        bool System.ComponentModel.IBindingList.AllowEdit { get { throw null; } }
        bool System.ComponentModel.IBindingList.AllowNew { get { throw null; } }
        bool System.ComponentModel.IBindingList.AllowRemove { get { throw null; } }
        bool System.ComponentModel.IBindingList.IsSorted { get { throw null; } }
        System.ComponentModel.ListSortDirection System.ComponentModel.IBindingList.SortDirection { get { throw null; } }
        System.ComponentModel.PropertyDescriptor System.ComponentModel.IBindingList.SortProperty { get { throw null; } }
        bool System.ComponentModel.IBindingList.SupportsChangeNotification { get { throw null; } }
        bool System.ComponentModel.IBindingList.SupportsSearching { get { throw null; } }
        bool System.ComponentModel.IBindingList.SupportsSorting { get { throw null; } }
        public event System.ComponentModel.ListChangedEventHandler ListChanged { add { } remove { } }
        public System.Data.DataView CreateDataView(System.Data.DataTable table) { throw null; }
        protected virtual void OnListChanged(System.ComponentModel.ListChangedEventArgs e) { }
        protected virtual void RelationCollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) { }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        int System.Collections.IList.Add(object value) { throw null; }
        void System.Collections.IList.Clear() { }
        bool System.Collections.IList.Contains(object value) { throw null; }
        int System.Collections.IList.IndexOf(object value) { throw null; }
        void System.Collections.IList.Insert(int index, object value) { }
        void System.Collections.IList.Remove(object value) { }
        void System.Collections.IList.RemoveAt(int index) { }
        void System.ComponentModel.IBindingList.AddIndex(System.ComponentModel.PropertyDescriptor property) { }
        object System.ComponentModel.IBindingList.AddNew() { throw null; }
        void System.ComponentModel.IBindingList.ApplySort(System.ComponentModel.PropertyDescriptor property, System.ComponentModel.ListSortDirection direction) { }
        int System.ComponentModel.IBindingList.Find(System.ComponentModel.PropertyDescriptor property, object key) { throw null; }
        void System.ComponentModel.IBindingList.RemoveIndex(System.ComponentModel.PropertyDescriptor property) { }
        void System.ComponentModel.IBindingList.RemoveSort() { }
        System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(System.ComponentModel.PropertyDescriptor[] listAccessors) { throw null; }
        string System.ComponentModel.ITypedList.GetListName(System.ComponentModel.PropertyDescriptor[] listAccessors) { throw null; }
        protected virtual void TableCollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) { }
    }
    [System.FlagsAttribute]
    public enum DataViewRowState
    {
        Added = 4,
        CurrentRows = 22,
        Deleted = 8,
        ModifiedCurrent = 16,
        ModifiedOriginal = 32,
        None = 0,
        OriginalRows = 42,
        Unchanged = 2,
    }
    public partial class DataViewSetting
    {
        internal DataViewSetting() { }
        public bool ApplyDefaultSort { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public System.Data.DataViewManager DataViewManager { get { throw null; } }
        public string RowFilter { get { throw null; } set { } }
        public System.Data.DataViewRowState RowStateFilter { get { throw null; } set { } }
        public string Sort { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public System.Data.DataTable Table { get { throw null; } }
    }
    public partial class DataViewSettingCollection : System.Collections.ICollection, System.Collections.IEnumerable
    {
        internal DataViewSettingCollection() { }
        [System.ComponentModel.BrowsableAttribute(false)]
        public virtual int Count { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public bool IsReadOnly { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public bool IsSynchronized { get { throw null; } }
        public virtual System.Data.DataViewSetting this[System.Data.DataTable table] { get { throw null; } set { } }
        public virtual System.Data.DataViewSetting this[int index] { get { throw null; } set { } }
        public virtual System.Data.DataViewSetting this[string tableName] { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public object SyncRoot { get { throw null; } }
        public void CopyTo(System.Array ar, int index) { }
        public void CopyTo(System.Data.DataViewSetting[] ar, int index) { }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
    }
    public sealed partial class DBConcurrencyException : System.SystemException
    {
        public DBConcurrencyException() { }
        public DBConcurrencyException(string message) { }
        public DBConcurrencyException(string message, System.Exception inner) { }
        public DBConcurrencyException(string message, System.Exception inner, System.Data.DataRow[] dataRows) { }
        public System.Data.DataRow Row { get { throw null; } set { } }
        public int RowCount { get { throw null; } }
        public void CopyToRows(System.Data.DataRow[] array) { }
        public void CopyToRows(System.Data.DataRow[] array, int arrayIndex) { }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public enum DbType
    {
        AnsiString = 0,
        AnsiStringFixedLength = 22,
        Binary = 1,
        Boolean = 3,
        Byte = 2,
        Currency = 4,
        Date = 5,
        DateTime = 6,
        DateTime2 = 26,
        DateTimeOffset = 27,
        Decimal = 7,
        Double = 8,
        Guid = 9,
        Int16 = 10,
        Int32 = 11,
        Int64 = 12,
        Object = 13,
        SByte = 14,
        Single = 15,
        String = 16,
        StringFixedLength = 23,
        Time = 17,
        UInt16 = 18,
        UInt32 = 19,
        UInt64 = 20,
        VarNumeric = 21,
        Xml = 25,
    }
    public partial class DeletedRowInaccessibleException : System.Data.DataException
    {
        public DeletedRowInaccessibleException() { }
        protected DeletedRowInaccessibleException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public DeletedRowInaccessibleException(string s) { }
        public DeletedRowInaccessibleException(string message, System.Exception innerException) { }
    }
    public partial class DuplicateNameException : System.Data.DataException
    {
        public DuplicateNameException() { }
        protected DuplicateNameException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public DuplicateNameException(string s) { }
        public DuplicateNameException(string message, System.Exception innerException) { }
    }
    public abstract partial class EnumerableRowCollection : System.Collections.IEnumerable
    {
        internal EnumerableRowCollection() { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class EnumerableRowCollection<TRow> : System.Data.EnumerableRowCollection, System.Collections.Generic.IEnumerable<TRow>, System.Collections.IEnumerable
    {
        internal EnumerableRowCollection() { }
        public System.Collections.Generic.IEnumerator<TRow> GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public static partial class EnumerableRowCollectionExtensions
    {
        public static System.Data.EnumerableRowCollection<TResult> Cast<TResult>(this System.Data.EnumerableRowCollection source) { throw null; }
        public static System.Data.OrderedEnumerableRowCollection<TRow> OrderByDescending<TRow, TKey>(this System.Data.EnumerableRowCollection<TRow> source, System.Func<TRow, TKey> keySelector) { throw null; }
        public static System.Data.OrderedEnumerableRowCollection<TRow> OrderByDescending<TRow, TKey>(this System.Data.EnumerableRowCollection<TRow> source, System.Func<TRow, TKey> keySelector, System.Collections.Generic.IComparer<TKey> comparer) { throw null; }
        public static System.Data.OrderedEnumerableRowCollection<TRow> OrderBy<TRow, TKey>(this System.Data.EnumerableRowCollection<TRow> source, System.Func<TRow, TKey> keySelector) { throw null; }
        public static System.Data.OrderedEnumerableRowCollection<TRow> OrderBy<TRow, TKey>(this System.Data.EnumerableRowCollection<TRow> source, System.Func<TRow, TKey> keySelector, System.Collections.Generic.IComparer<TKey> comparer) { throw null; }
        public static System.Data.EnumerableRowCollection<S> Select<TRow, S>(this System.Data.EnumerableRowCollection<TRow> source, System.Func<TRow, S> selector) { throw null; }
        public static System.Data.OrderedEnumerableRowCollection<TRow> ThenByDescending<TRow, TKey>(this System.Data.OrderedEnumerableRowCollection<TRow> source, System.Func<TRow, TKey> keySelector) { throw null; }
        public static System.Data.OrderedEnumerableRowCollection<TRow> ThenByDescending<TRow, TKey>(this System.Data.OrderedEnumerableRowCollection<TRow> source, System.Func<TRow, TKey> keySelector, System.Collections.Generic.IComparer<TKey> comparer) { throw null; }
        public static System.Data.OrderedEnumerableRowCollection<TRow> ThenBy<TRow, TKey>(this System.Data.OrderedEnumerableRowCollection<TRow> source, System.Func<TRow, TKey> keySelector) { throw null; }
        public static System.Data.OrderedEnumerableRowCollection<TRow> ThenBy<TRow, TKey>(this System.Data.OrderedEnumerableRowCollection<TRow> source, System.Func<TRow, TKey> keySelector, System.Collections.Generic.IComparer<TKey> comparer) { throw null; }
        public static System.Data.EnumerableRowCollection<TRow> Where<TRow>(this System.Data.EnumerableRowCollection<TRow> source, System.Func<TRow, bool> predicate) { throw null; }
    }
    public partial class EvaluateException : System.Data.InvalidExpressionException
    {
        public EvaluateException() { }
        protected EvaluateException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public EvaluateException(string s) { }
        public EvaluateException(string message, System.Exception innerException) { }
    }
    public partial class FillErrorEventArgs : System.EventArgs
    {
        public FillErrorEventArgs(System.Data.DataTable dataTable, object[] values) { }
        public bool Continue { get { throw null; } set { } }
        public System.Data.DataTable DataTable { get { throw null; } }
        public System.Exception Errors { get { throw null; } set { } }
        public object[] Values { get { throw null; } }
    }
    public delegate void FillErrorEventHandler(object sender, System.Data.FillErrorEventArgs e);
    [System.ComponentModel.DefaultPropertyAttribute("ConstraintName")]
    public partial class ForeignKeyConstraint : System.Data.Constraint
    {
        public ForeignKeyConstraint(System.Data.DataColumn parentColumn, System.Data.DataColumn childColumn) { }
        public ForeignKeyConstraint(System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns) { }
        public ForeignKeyConstraint(string constraintName, System.Data.DataColumn parentColumn, System.Data.DataColumn childColumn) { }
        public ForeignKeyConstraint(string constraintName, System.Data.DataColumn[] parentColumns, System.Data.DataColumn[] childColumns) { }
        [System.ComponentModel.BrowsableAttribute(false)]
        public ForeignKeyConstraint(string constraintName, string parentTableName, string parentTableNamespace, string[] parentColumnNames, string[] childColumnNames, System.Data.AcceptRejectRule acceptRejectRule, System.Data.Rule deleteRule, System.Data.Rule updateRule) { }
        [System.ComponentModel.BrowsableAttribute(false)]
        public ForeignKeyConstraint(string constraintName, string parentTableName, string[] parentColumnNames, string[] childColumnNames, System.Data.AcceptRejectRule acceptRejectRule, System.Data.Rule deleteRule, System.Data.Rule updateRule) { }
        [System.ComponentModel.DefaultValueAttribute(System.Data.AcceptRejectRule.None)]
        public virtual System.Data.AcceptRejectRule AcceptRejectRule { get { throw null; } set { } }
        [System.ComponentModel.ReadOnlyAttribute(true)]
        public virtual System.Data.DataColumn[] Columns { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute(System.Data.Rule.Cascade)]
        public virtual System.Data.Rule DeleteRule { get { throw null; } set { } }
        [System.ComponentModel.ReadOnlyAttribute(true)]
        public virtual System.Data.DataColumn[] RelatedColumns { get { throw null; } }
        [System.ComponentModel.ReadOnlyAttribute(true)]
        public virtual System.Data.DataTable RelatedTable { get { throw null; } }
        [System.ComponentModel.ReadOnlyAttribute(true)]
        public override System.Data.DataTable Table { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute(System.Data.Rule.Cascade)]
        public virtual System.Data.Rule UpdateRule { get { throw null; } set { } }
        public override bool Equals(object key) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public partial interface IColumnMapping
    {
        string DataSetColumn { get; set; }
        string SourceColumn { get; set; }
    }
    public partial interface IColumnMappingCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
    {
        object this[string index] { get; set; }
        System.Data.IColumnMapping Add(string sourceColumnName, string dataSetColumnName);
        bool Contains(string sourceColumnName);
        System.Data.IColumnMapping GetByDataSetColumn(string dataSetColumnName);
        int IndexOf(string sourceColumnName);
        void RemoveAt(string sourceColumnName);
    }
    public partial interface IDataAdapter
    {
        System.Data.MissingMappingAction MissingMappingAction { get; set; }
        System.Data.MissingSchemaAction MissingSchemaAction { get; set; }
        System.Data.ITableMappingCollection TableMappings { get; }
        int Fill(System.Data.DataSet dataSet);
        System.Data.DataTable[] FillSchema(System.Data.DataSet dataSet, System.Data.SchemaType schemaType);
        System.Data.IDataParameter[] GetFillParameters();
        int Update(System.Data.DataSet dataSet);
    }
    public partial interface IDataParameter
    {
        System.Data.DbType DbType { get; set; }
        System.Data.ParameterDirection Direction { get; set; }
        bool IsNullable { get; }
        string ParameterName { get; set; }
        string SourceColumn { get; set; }
        System.Data.DataRowVersion SourceVersion { get; set; }
        object Value { get; set; }
    }
    public partial interface IDataParameterCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
    {
        object this[string parameterName] { get; set; }
        bool Contains(string parameterName);
        int IndexOf(string parameterName);
        void RemoveAt(string parameterName);
    }
    public partial interface IDataReader : System.Data.IDataRecord, System.IDisposable
    {
        int Depth { get; }
        bool IsClosed { get; }
        int RecordsAffected { get; }
        void Close();
        System.Data.DataTable GetSchemaTable();
        bool NextResult();
        bool Read();
    }
    public partial interface IDataRecord
    {
        int FieldCount { get; }
        object this[int i] { get; }
        object this[string name] { get; }
        bool GetBoolean(int i);
        byte GetByte(int i);
        long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length);
        char GetChar(int i);
        long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length);
        System.Data.IDataReader GetData(int i);
        string GetDataTypeName(int i);
        System.DateTime GetDateTime(int i);
        decimal GetDecimal(int i);
        double GetDouble(int i);
        System.Type GetFieldType(int i);
        float GetFloat(int i);
        System.Guid GetGuid(int i);
        short GetInt16(int i);
        int GetInt32(int i);
        long GetInt64(int i);
        string GetName(int i);
        int GetOrdinal(string name);
        string GetString(int i);
        object GetValue(int i);
        int GetValues(object[] values);
        bool IsDBNull(int i);
    }
    public partial interface IDbCommand : System.IDisposable
    {
        string CommandText { get; set; }
        int CommandTimeout { get; set; }
        System.Data.CommandType CommandType { get; set; }
        System.Data.IDbConnection Connection { get; set; }
        System.Data.IDataParameterCollection Parameters { get; }
        System.Data.IDbTransaction Transaction { get; set; }
        System.Data.UpdateRowSource UpdatedRowSource { get; set; }
        void Cancel();
        System.Data.IDbDataParameter CreateParameter();
        int ExecuteNonQuery();
        System.Data.IDataReader ExecuteReader();
        System.Data.IDataReader ExecuteReader(System.Data.CommandBehavior behavior);
        object ExecuteScalar();
        void Prepare();
    }
    public partial interface IDbConnection : System.IDisposable
    {
        string ConnectionString { get; set; }
        int ConnectionTimeout { get; }
        string Database { get; }
        System.Data.ConnectionState State { get; }
        System.Data.IDbTransaction BeginTransaction();
        System.Data.IDbTransaction BeginTransaction(System.Data.IsolationLevel il);
        void ChangeDatabase(string databaseName);
        void Close();
        System.Data.IDbCommand CreateCommand();
        void Open();
    }
    public partial interface IDbDataAdapter : System.Data.IDataAdapter
    {
        System.Data.IDbCommand DeleteCommand { get; set; }
        System.Data.IDbCommand InsertCommand { get; set; }
        System.Data.IDbCommand SelectCommand { get; set; }
        System.Data.IDbCommand UpdateCommand { get; set; }
    }
    public partial interface IDbDataParameter : System.Data.IDataParameter
    {
        byte Precision { get; set; }
        byte Scale { get; set; }
        int Size { get; set; }
    }
    public partial interface IDbTransaction : System.IDisposable
    {
        System.Data.IDbConnection Connection { get; }
        System.Data.IsolationLevel IsolationLevel { get; }
        void Commit();
        void Rollback();
    }
    public partial class InRowChangingEventException : System.Data.DataException
    {
        public InRowChangingEventException() { }
        protected InRowChangingEventException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public InRowChangingEventException(string s) { }
        public InRowChangingEventException(string message, System.Exception innerException) { }
    }
    public partial class InternalDataCollectionBase : System.Collections.ICollection, System.Collections.IEnumerable
    {
        public InternalDataCollectionBase() { }
        [System.ComponentModel.BrowsableAttribute(false)]
        public virtual int Count { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public bool IsReadOnly { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public bool IsSynchronized { get { throw null; } }
        protected virtual System.Collections.ArrayList List { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public object SyncRoot { get { throw null; } }
        public virtual void CopyTo(System.Array ar, int index) { }
        public virtual System.Collections.IEnumerator GetEnumerator() { throw null; }
    }
    public partial class InvalidConstraintException : System.Data.DataException
    {
        public InvalidConstraintException() { }
        protected InvalidConstraintException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public InvalidConstraintException(string s) { }
        public InvalidConstraintException(string message, System.Exception innerException) { }
    }
    public partial class InvalidExpressionException : System.Data.DataException
    {
        public InvalidExpressionException() { }
        protected InvalidExpressionException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public InvalidExpressionException(string s) { }
        public InvalidExpressionException(string message, System.Exception innerException) { }
    }
    public enum IsolationLevel
    {
        Chaos = 16,
        ReadCommitted = 4096,
        ReadUncommitted = 256,
        RepeatableRead = 65536,
        Serializable = 1048576,
        Snapshot = 16777216,
        Unspecified = -1,
    }
    public partial interface ITableMapping
    {
        System.Data.IColumnMappingCollection ColumnMappings { get; }
        string DataSetTable { get; set; }
        string SourceTable { get; set; }
    }
    public partial interface ITableMappingCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
    {
        object this[string index] { get; set; }
        System.Data.ITableMapping Add(string sourceTableName, string dataSetTableName);
        bool Contains(string sourceTableName);
        System.Data.ITableMapping GetByDataSetTable(string dataSetTableName);
        int IndexOf(string sourceTableName);
        void RemoveAt(string sourceTableName);
    }
    public enum KeyRestrictionBehavior
    {
        AllowOnly = 0,
        PreventUsage = 1,
    }
    public enum LoadOption
    {
        OverwriteChanges = 1,
        PreserveChanges = 2,
        Upsert = 3,
    }
    public enum MappingType
    {
        Attribute = 2,
        Element = 1,
        Hidden = 4,
        SimpleContent = 3,
    }
    public partial class MergeFailedEventArgs : System.EventArgs
    {
        public MergeFailedEventArgs(System.Data.DataTable table, string conflict) { }
        public string Conflict { get { throw null; } }
        public System.Data.DataTable Table { get { throw null; } }
    }
    public delegate void MergeFailedEventHandler(object sender, System.Data.MergeFailedEventArgs e);
    public enum MissingMappingAction
    {
        Error = 3,
        Ignore = 2,
        Passthrough = 1,
    }
    public partial class MissingPrimaryKeyException : System.Data.DataException
    {
        public MissingPrimaryKeyException() { }
        protected MissingPrimaryKeyException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public MissingPrimaryKeyException(string s) { }
        public MissingPrimaryKeyException(string message, System.Exception innerException) { }
    }
    public enum MissingSchemaAction
    {
        Add = 1,
        AddWithKey = 4,
        Error = 3,
        Ignore = 2,
    }
    public partial class NoNullAllowedException : System.Data.DataException
    {
        public NoNullAllowedException() { }
        protected NoNullAllowedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public NoNullAllowedException(string s) { }
        public NoNullAllowedException(string message, System.Exception innerException) { }
    }
    public sealed partial class OrderedEnumerableRowCollection<TRow> : System.Data.EnumerableRowCollection<TRow>
    {
        internal OrderedEnumerableRowCollection() { }
    }
    public enum ParameterDirection
    {
        Input = 1,
        InputOutput = 3,
        Output = 2,
        ReturnValue = 6,
    }
    public partial class PropertyCollection : System.Collections.Hashtable
    {
        public PropertyCollection() { }
        protected PropertyCollection(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public override object Clone() { throw null; }
    }
    public partial class ReadOnlyException : System.Data.DataException
    {
        public ReadOnlyException() { }
        protected ReadOnlyException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public ReadOnlyException(string s) { }
        public ReadOnlyException(string message, System.Exception innerException) { }
    }
    public partial class RowNotInTableException : System.Data.DataException
    {
        public RowNotInTableException() { }
        protected RowNotInTableException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public RowNotInTableException(string s) { }
        public RowNotInTableException(string message, System.Exception innerException) { }
    }
    public enum Rule
    {
        Cascade = 1,
        None = 0,
        SetDefault = 3,
        SetNull = 2,
    }
    public enum SchemaSerializationMode
    {
        ExcludeSchema = 2,
        IncludeSchema = 1,
    }
    public enum SchemaType
    {
        Mapped = 2,
        Source = 1,
    }
    public enum SerializationFormat
    {
        Binary = 1,
        Xml = 0,
    }
    public enum SqlDbType
    {
        BigInt = 0,
        Binary = 1,
        Bit = 2,
        Char = 3,
        Date = 31,
        DateTime = 4,
        DateTime2 = 33,
        DateTimeOffset = 34,
        Decimal = 5,
        Float = 6,
        Image = 7,
        Int = 8,
        Money = 9,
        NChar = 10,
        NText = 11,
        NVarChar = 12,
        Real = 13,
        SmallDateTime = 15,
        SmallInt = 16,
        SmallMoney = 17,
        Structured = 30,
        Text = 18,
        Time = 32,
        Timestamp = 19,
        TinyInt = 20,
        Udt = 29,
        UniqueIdentifier = 14,
        VarBinary = 21,
        VarChar = 22,
        Variant = 23,
        Xml = 25,
    }
    public sealed partial class StateChangeEventArgs : System.EventArgs
    {
        public StateChangeEventArgs(System.Data.ConnectionState originalState, System.Data.ConnectionState currentState) { }
        public System.Data.ConnectionState CurrentState { get { throw null; } }
        public System.Data.ConnectionState OriginalState { get { throw null; } }
    }
    public delegate void StateChangeEventHandler(object sender, System.Data.StateChangeEventArgs e);
    public sealed partial class StatementCompletedEventArgs : System.EventArgs
    {
        public StatementCompletedEventArgs(int recordCount) { }
        public int RecordCount { get { throw null; } }
    }
    public delegate void StatementCompletedEventHandler(object sender, System.Data.StatementCompletedEventArgs e);
    public enum StatementType
    {
        Batch = 4,
        Delete = 3,
        Insert = 1,
        Select = 0,
        Update = 2,
    }
    public partial class StrongTypingException : System.Data.DataException
    {
        public StrongTypingException() { }
        protected StrongTypingException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public StrongTypingException(string message) { }
        public StrongTypingException(string s, System.Exception innerException) { }
    }
    public partial class SyntaxErrorException : System.Data.InvalidExpressionException
    {
        public SyntaxErrorException() { }
        protected SyntaxErrorException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public SyntaxErrorException(string s) { }
        public SyntaxErrorException(string message, System.Exception innerException) { }
    }
    public abstract partial class TypedTableBase<T> : System.Data.DataTable, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable where T : System.Data.DataRow
    {
        protected TypedTableBase() { }
        protected TypedTableBase(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public System.Data.EnumerableRowCollection<TResult> Cast<TResult>() { throw null; }
        public System.Collections.Generic.IEnumerator<T> GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public static partial class TypedTableBaseExtensions
    {
        public static System.Data.EnumerableRowCollection<TRow> AsEnumerable<TRow>(this System.Data.TypedTableBase<TRow> source) where TRow : System.Data.DataRow { throw null; }
        public static TRow ElementAtOrDefault<TRow>(this System.Data.TypedTableBase<TRow> source, int index) where TRow : System.Data.DataRow { throw null; }
        public static System.Data.OrderedEnumerableRowCollection<TRow> OrderByDescending<TRow, TKey>(this System.Data.TypedTableBase<TRow> source, System.Func<TRow, TKey> keySelector) where TRow : System.Data.DataRow { throw null; }
        public static System.Data.OrderedEnumerableRowCollection<TRow> OrderByDescending<TRow, TKey>(this System.Data.TypedTableBase<TRow> source, System.Func<TRow, TKey> keySelector, System.Collections.Generic.IComparer<TKey> comparer) where TRow : System.Data.DataRow { throw null; }
        public static System.Data.OrderedEnumerableRowCollection<TRow> OrderBy<TRow, TKey>(this System.Data.TypedTableBase<TRow> source, System.Func<TRow, TKey> keySelector) where TRow : System.Data.DataRow { throw null; }
        public static System.Data.OrderedEnumerableRowCollection<TRow> OrderBy<TRow, TKey>(this System.Data.TypedTableBase<TRow> source, System.Func<TRow, TKey> keySelector, System.Collections.Generic.IComparer<TKey> comparer) where TRow : System.Data.DataRow { throw null; }
        public static System.Data.EnumerableRowCollection<S> Select<TRow, S>(this System.Data.TypedTableBase<TRow> source, System.Func<TRow, S> selector) where TRow : System.Data.DataRow { throw null; }
        public static System.Data.EnumerableRowCollection<TRow> Where<TRow>(this System.Data.TypedTableBase<TRow> source, System.Func<TRow, bool> predicate) where TRow : System.Data.DataRow { throw null; }
    }
    [System.ComponentModel.DefaultPropertyAttribute("ConstraintName")]
    public partial class UniqueConstraint : System.Data.Constraint
    {
        public UniqueConstraint(System.Data.DataColumn column) { }
        public UniqueConstraint(System.Data.DataColumn column, bool isPrimaryKey) { }
        public UniqueConstraint(System.Data.DataColumn[] columns) { }
        public UniqueConstraint(System.Data.DataColumn[] columns, bool isPrimaryKey) { }
        public UniqueConstraint(string name, System.Data.DataColumn column) { }
        public UniqueConstraint(string name, System.Data.DataColumn column, bool isPrimaryKey) { }
        public UniqueConstraint(string name, System.Data.DataColumn[] columns) { }
        public UniqueConstraint(string name, System.Data.DataColumn[] columns, bool isPrimaryKey) { }
        [System.ComponentModel.BrowsableAttribute(false)]
        public UniqueConstraint(string name, string[] columnNames, bool isPrimaryKey) { }
        [System.ComponentModel.ReadOnlyAttribute(true)]
        public virtual System.Data.DataColumn[] Columns { get { throw null; } }
        public bool IsPrimaryKey { get { throw null; } }
        [System.ComponentModel.ReadOnlyAttribute(true)]
        public override System.Data.DataTable Table { get { throw null; } }
        public override bool Equals(object key2) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public enum UpdateRowSource
    {
        Both = 3,
        FirstReturnedRecord = 2,
        None = 0,
        OutputParameters = 1,
    }
    public enum UpdateStatus
    {
        Continue = 0,
        ErrorsOccurred = 1,
        SkipAllRemainingRows = 3,
        SkipCurrentRow = 2,
    }
    public partial class VersionNotFoundException : System.Data.DataException
    {
        public VersionNotFoundException() { }
        protected VersionNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public VersionNotFoundException(string s) { }
        public VersionNotFoundException(string message, System.Exception innerException) { }
    }
    public enum XmlReadMode
    {
        Auto = 0,
        DiffGram = 4,
        Fragment = 5,
        IgnoreSchema = 2,
        InferSchema = 3,
        InferTypedSchema = 6,
        ReadSchema = 1,
    }
    public enum XmlWriteMode
    {
        DiffGram = 2,
        IgnoreSchema = 1,
        WriteSchema = 0,
    }
}
