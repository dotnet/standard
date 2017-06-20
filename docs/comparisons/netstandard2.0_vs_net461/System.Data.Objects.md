# System.Data.Objects

``` diff
+namespace System.Data.Objects {
+    public sealed class CompiledQuery {
+        public static Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(Expression<Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>> query) where TArg0 : ObjectContext;
+        public static Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(Expression<Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>> query) where TArg0 : ObjectContext;
+        public static Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(Expression<Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>> query) where TArg0 : ObjectContext;
+        public static Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(Expression<Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>> query) where TArg0 : ObjectContext;
+        public static Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(Expression<Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>> query) where TArg0 : ObjectContext;
+        public static Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(Expression<Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>> query) where TArg0 : ObjectContext;
+        public static Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(Expression<Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>> query) where TArg0 : ObjectContext;
+        public static Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(Expression<Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>> query) where TArg0 : ObjectContext;
+        public static Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(Expression<Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>> query) where TArg0 : ObjectContext;
+        public static Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(Expression<Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>> query) where TArg0 : ObjectContext;
+        public static Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(Expression<Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TResult>> query) where TArg0 : ObjectContext;
+        public static Func<TArg0, TArg1, TArg2, TArg3, TArg4, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TResult>(Expression<Func<TArg0, TArg1, TArg2, TArg3, TArg4, TResult>> query) where TArg0 : ObjectContext;
+        public static Func<TArg0, TArg1, TArg2, TArg3, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TResult>(Expression<Func<TArg0, TArg1, TArg2, TArg3, TResult>> query) where TArg0 : ObjectContext;
+        public static Func<TArg0, TArg1, TArg2, TResult> Compile<TArg0, TArg1, TArg2, TResult>(Expression<Func<TArg0, TArg1, TArg2, TResult>> query) where TArg0 : ObjectContext;
+        public static Func<TArg0, TArg1, TResult> Compile<TArg0, TArg1, TResult>(Expression<Func<TArg0, TArg1, TResult>> query) where TArg0 : ObjectContext;
+        public static Func<TArg0, TResult> Compile<TArg0, TResult>(Expression<Func<TArg0, TResult>> query) where TArg0 : ObjectContext;
+    }
+    public abstract class CurrentValueRecord : DbUpdatableDataRecord
+    public abstract class DbUpdatableDataRecord : DbDataRecord, IDataRecord, IExtendedDataRecord {
+        public virtual DataRecordInfo DataRecordInfo { get; }
+        public override int FieldCount { get; }
+        public override object this[int ordinal] { get; }
+        public override object this[string name] { get; }
+        public override bool GetBoolean(int ordinal);
+        public override byte GetByte(int ordinal);
+        public override long GetBytes(int ordinal, long dataIndex, byte[] buffer, int bufferIndex, int length);
+        public override char GetChar(int ordinal);
+        public override long GetChars(int ordinal, long dataIndex, char[] buffer, int bufferIndex, int length);
+        public DbDataReader GetDataReader(int i);
+        public DbDataRecord GetDataRecord(int ordinal);
+        public override string GetDataTypeName(int ordinal);
+        public override DateTime GetDateTime(int ordinal);
+        protected override DbDataReader GetDbDataReader(int ordinal);
+        public override decimal GetDecimal(int ordinal);
+        public override double GetDouble(int ordinal);
+        public override Type GetFieldType(int ordinal);
+        public override float GetFloat(int ordinal);
+        public override Guid GetGuid(int ordinal);
+        public override short GetInt16(int ordinal);
+        public override int GetInt32(int ordinal);
+        public override long GetInt64(int ordinal);
+        public override string GetName(int ordinal);
+        public override int GetOrdinal(string name);
+        protected abstract object GetRecordValue(int ordinal);
+        public override string GetString(int ordinal);
+        public override object GetValue(int ordinal);
+        public override int GetValues(object[] values);
+        public override bool IsDBNull(int ordinal);
+        public void SetBoolean(int ordinal, bool value);
+        public void SetByte(int ordinal, byte value);
+        public void SetChar(int ordinal, char value);
+        public void SetDataRecord(int ordinal, IDataRecord value);
+        public void SetDateTime(int ordinal, DateTime value);
+        public void SetDBNull(int ordinal);
+        public void SetDecimal(int ordinal, decimal value);
+        public void SetDouble(int ordinal, double value);
+        public void SetFloat(int ordinal, float value);
+        public void SetGuid(int ordinal, Guid value);
+        public void SetInt16(int ordinal, short value);
+        public void SetInt32(int ordinal, int value);
+        public void SetInt64(int ordinal, long value);
+        protected abstract void SetRecordValue(int ordinal, object value);
+        public void SetString(int ordinal, string value);
+        public void SetValue(int ordinal, object value);
+        public int SetValues(params object[] values);
+        IDataReader System.Data.IDataRecord.GetData(int ordinal);
+    }
+    public static class EntityFunctions {
+        public static Nullable<DateTime> AddDays(Nullable<DateTime> dateValue, Nullable<int> addValue);
+        public static Nullable<DateTimeOffset> AddDays(Nullable<DateTimeOffset> dateValue, Nullable<int> addValue);
+        public static Nullable<DateTime> AddHours(Nullable<DateTime> timeValue, Nullable<int> addValue);
+        public static Nullable<DateTimeOffset> AddHours(Nullable<DateTimeOffset> timeValue, Nullable<int> addValue);
+        public static Nullable<TimeSpan> AddHours(Nullable<TimeSpan> timeValue, Nullable<int> addValue);
+        public static Nullable<DateTime> AddMicroseconds(Nullable<DateTime> timeValue, Nullable<int> addValue);
+        public static Nullable<DateTimeOffset> AddMicroseconds(Nullable<DateTimeOffset> timeValue, Nullable<int> addValue);
+        public static Nullable<TimeSpan> AddMicroseconds(Nullable<TimeSpan> timeValue, Nullable<int> addValue);
+        public static Nullable<DateTime> AddMilliseconds(Nullable<DateTime> timeValue, Nullable<int> addValue);
+        public static Nullable<DateTimeOffset> AddMilliseconds(Nullable<DateTimeOffset> timeValue, Nullable<int> addValue);
+        public static Nullable<TimeSpan> AddMilliseconds(Nullable<TimeSpan> timeValue, Nullable<int> addValue);
+        public static Nullable<DateTime> AddMinutes(Nullable<DateTime> timeValue, Nullable<int> addValue);
+        public static Nullable<DateTimeOffset> AddMinutes(Nullable<DateTimeOffset> timeValue, Nullable<int> addValue);
+        public static Nullable<TimeSpan> AddMinutes(Nullable<TimeSpan> timeValue, Nullable<int> addValue);
+        public static Nullable<DateTime> AddMonths(Nullable<DateTime> dateValue, Nullable<int> addValue);
+        public static Nullable<DateTimeOffset> AddMonths(Nullable<DateTimeOffset> dateValue, Nullable<int> addValue);
+        public static Nullable<DateTime> AddNanoseconds(Nullable<DateTime> timeValue, Nullable<int> addValue);
+        public static Nullable<DateTimeOffset> AddNanoseconds(Nullable<DateTimeOffset> timeValue, Nullable<int> addValue);
+        public static Nullable<TimeSpan> AddNanoseconds(Nullable<TimeSpan> timeValue, Nullable<int> addValue);
+        public static Nullable<DateTime> AddSeconds(Nullable<DateTime> timeValue, Nullable<int> addValue);
+        public static Nullable<DateTimeOffset> AddSeconds(Nullable<DateTimeOffset> timeValue, Nullable<int> addValue);
+        public static Nullable<TimeSpan> AddSeconds(Nullable<TimeSpan> timeValue, Nullable<int> addValue);
+        public static Nullable<DateTime> AddYears(Nullable<DateTime> dateValue, Nullable<int> addValue);
+        public static Nullable<DateTimeOffset> AddYears(Nullable<DateTimeOffset> dateValue, Nullable<int> addValue);
+        public static string AsNonUnicode(string value);
+        public static string AsUnicode(string value);
+        public static Nullable<DateTime> CreateDateTime(Nullable<int> year, Nullable<int> month, Nullable<int> day, Nullable<int> hour, Nullable<int> minute, Nullable<double> second);
+        public static Nullable<DateTimeOffset> CreateDateTimeOffset(Nullable<int> year, Nullable<int> month, Nullable<int> day, Nullable<int> hour, Nullable<int> minute, Nullable<double> second, Nullable<int> timeZoneOffset);
+        public static Nullable<TimeSpan> CreateTime(Nullable<int> hour, Nullable<int> minute, Nullable<double> second);
+        public static Nullable<int> DiffDays(Nullable<DateTime> dateValue1, Nullable<DateTime> dateValue2);
+        public static Nullable<int> DiffDays(Nullable<DateTimeOffset> dateValue1, Nullable<DateTimeOffset> dateValue2);
+        public static Nullable<int> DiffHours(Nullable<DateTime> timeValue1, Nullable<DateTime> timeValue2);
+        public static Nullable<int> DiffHours(Nullable<DateTimeOffset> timeValue1, Nullable<DateTimeOffset> timeValue2);
+        public static Nullable<int> DiffHours(Nullable<TimeSpan> timeValue1, Nullable<TimeSpan> timeValue2);
+        public static Nullable<int> DiffMicroseconds(Nullable<DateTime> timeValue1, Nullable<DateTime> timeValue2);
+        public static Nullable<int> DiffMicroseconds(Nullable<DateTimeOffset> timeValue1, Nullable<DateTimeOffset> timeValue2);
+        public static Nullable<int> DiffMicroseconds(Nullable<TimeSpan> timeValue1, Nullable<TimeSpan> timeValue2);
+        public static Nullable<int> DiffMilliseconds(Nullable<DateTime> timeValue1, Nullable<DateTime> timeValue2);
+        public static Nullable<int> DiffMilliseconds(Nullable<DateTimeOffset> timeValue1, Nullable<DateTimeOffset> timeValue2);
+        public static Nullable<int> DiffMilliseconds(Nullable<TimeSpan> timeValue1, Nullable<TimeSpan> timeValue2);
+        public static Nullable<int> DiffMinutes(Nullable<DateTime> timeValue1, Nullable<DateTime> timeValue2);
+        public static Nullable<int> DiffMinutes(Nullable<DateTimeOffset> timeValue1, Nullable<DateTimeOffset> timeValue2);
+        public static Nullable<int> DiffMinutes(Nullable<TimeSpan> timeValue1, Nullable<TimeSpan> timeValue2);
+        public static Nullable<int> DiffMonths(Nullable<DateTime> dateValue1, Nullable<DateTime> dateValue2);
+        public static Nullable<int> DiffMonths(Nullable<DateTimeOffset> dateValue1, Nullable<DateTimeOffset> dateValue2);
+        public static Nullable<int> DiffNanoseconds(Nullable<DateTime> timeValue1, Nullable<DateTime> timeValue2);
+        public static Nullable<int> DiffNanoseconds(Nullable<DateTimeOffset> timeValue1, Nullable<DateTimeOffset> timeValue2);
+        public static Nullable<int> DiffNanoseconds(Nullable<TimeSpan> timeValue1, Nullable<TimeSpan> timeValue2);
+        public static Nullable<int> DiffSeconds(Nullable<DateTime> timeValue1, Nullable<DateTime> timeValue2);
+        public static Nullable<int> DiffSeconds(Nullable<DateTimeOffset> timeValue1, Nullable<DateTimeOffset> timeValue2);
+        public static Nullable<int> DiffSeconds(Nullable<TimeSpan> timeValue1, Nullable<TimeSpan> timeValue2);
+        public static Nullable<int> DiffYears(Nullable<DateTime> dateValue1, Nullable<DateTime> dateValue2);
+        public static Nullable<int> DiffYears(Nullable<DateTimeOffset> dateValue1, Nullable<DateTimeOffset> dateValue2);
+        public static Nullable<int> GetTotalOffsetMinutes(Nullable<DateTimeOffset> dateTimeOffsetArgument);
+        public static string Left(string stringArgument, Nullable<long> length);
+        public static string Reverse(string stringArgument);
+        public static string Right(string stringArgument, Nullable<long> length);
+        public static Nullable<double> StandardDeviation(IEnumerable<decimal> collection);
+        public static Nullable<double> StandardDeviation(IEnumerable<double> collection);
+        public static Nullable<double> StandardDeviation(IEnumerable<int> collection);
+        public static Nullable<double> StandardDeviation(IEnumerable<long> collection);
+        public static Nullable<double> StandardDeviation(IEnumerable<Nullable<decimal>> collection);
+        public static Nullable<double> StandardDeviation(IEnumerable<Nullable<double>> collection);
+        public static Nullable<double> StandardDeviation(IEnumerable<Nullable<int>> collection);
+        public static Nullable<double> StandardDeviation(IEnumerable<Nullable<long>> collection);
+        public static Nullable<double> StandardDeviationP(IEnumerable<decimal> collection);
+        public static Nullable<double> StandardDeviationP(IEnumerable<double> collection);
+        public static Nullable<double> StandardDeviationP(IEnumerable<int> collection);
+        public static Nullable<double> StandardDeviationP(IEnumerable<long> collection);
+        public static Nullable<double> StandardDeviationP(IEnumerable<Nullable<decimal>> collection);
+        public static Nullable<double> StandardDeviationP(IEnumerable<Nullable<double>> collection);
+        public static Nullable<double> StandardDeviationP(IEnumerable<Nullable<int>> collection);
+        public static Nullable<double> StandardDeviationP(IEnumerable<Nullable<long>> collection);
+        public static Nullable<decimal> Truncate(Nullable<decimal> value, Nullable<int> digits);
+        public static Nullable<double> Truncate(Nullable<double> value, Nullable<int> digits);
+        public static Nullable<DateTime> TruncateTime(Nullable<DateTime> dateValue);
+        public static Nullable<DateTimeOffset> TruncateTime(Nullable<DateTimeOffset> dateValue);
+        public static Nullable<double> Var(IEnumerable<decimal> collection);
+        public static Nullable<double> Var(IEnumerable<double> collection);
+        public static Nullable<double> Var(IEnumerable<int> collection);
+        public static Nullable<double> Var(IEnumerable<long> collection);
+        public static Nullable<double> Var(IEnumerable<Nullable<decimal>> collection);
+        public static Nullable<double> Var(IEnumerable<Nullable<double>> collection);
+        public static Nullable<double> Var(IEnumerable<Nullable<int>> collection);
+        public static Nullable<double> Var(IEnumerable<Nullable<long>> collection);
+        public static Nullable<double> VarP(IEnumerable<decimal> collection);
+        public static Nullable<double> VarP(IEnumerable<double> collection);
+        public static Nullable<double> VarP(IEnumerable<int> collection);
+        public static Nullable<double> VarP(IEnumerable<long> collection);
+        public static Nullable<double> VarP(IEnumerable<Nullable<decimal>> collection);
+        public static Nullable<double> VarP(IEnumerable<Nullable<double>> collection);
+        public static Nullable<double> VarP(IEnumerable<Nullable<int>> collection);
+        public static Nullable<double> VarP(IEnumerable<Nullable<long>> collection);
+    }
+    public interface IObjectSet<TEntity> : IEnumerable, IEnumerable<TEntity>, IQueryable, IQueryable<TEntity> where TEntity : class {
+        void AddObject(TEntity entity);
+        void Attach(TEntity entity);
+        void DeleteObject(TEntity entity);
+        void Detach(TEntity entity);
+    }
+    public enum MergeOption {
+        AppendOnly = 0,
+        NoTracking = 3,
+        OverwriteChanges = 1,
+        PreserveChanges = 2,
+    }
+    public class ObjectContext : IDisposable {
+        public ObjectContext(EntityConnection connection);
+        protected ObjectContext(EntityConnection connection, string defaultContainerName);
+        public ObjectContext(string connectionString);
+        protected ObjectContext(string connectionString, string defaultContainerName);
+        public Nullable<int> CommandTimeout { get; set; }
+        public DbConnection Connection { get; }
+        public ObjectContextOptions ContextOptions { get; }
+        public string DefaultContainerName { get; set; }
+        public MetadataWorkspace MetadataWorkspace { get; }
+        public ObjectStateManager ObjectStateManager { get; }
+        protected internal IQueryProvider QueryProvider { get; }
+        public event ObjectMaterializedEventHandler ObjectMaterialized;
+        public event EventHandler SavingChanges;
+        public void AcceptAllChanges();
+        public void AddObject(string entitySetName, object entity);
+        public TEntity ApplyCurrentValues<TEntity>(string entitySetName, TEntity currentEntity) where TEntity : class;
+        public TEntity ApplyOriginalValues<TEntity>(string entitySetName, TEntity originalEntity) where TEntity : class;
+        public void ApplyPropertyChanges(string entitySetName, object changed);
+        public void Attach(IEntityWithKey entity);
+        public void AttachTo(string entitySetName, object entity);
+        public void CreateDatabase();
+        public string CreateDatabaseScript();
+        public EntityKey CreateEntityKey(string entitySetName, object entity);
+        public T CreateObject<T>() where T : class;
+        public ObjectSet<TEntity> CreateObjectSet<TEntity>() where TEntity : class;
+        public ObjectSet<TEntity> CreateObjectSet<TEntity>(string entitySetName) where TEntity : class;
+        public void CreateProxyTypes(IEnumerable<Type> types);
+        public ObjectQuery<T> CreateQuery<T>(string queryString, params ObjectParameter[] parameters);
+        public bool DatabaseExists();
+        public void DeleteDatabase();
+        public void DeleteObject(object entity);
+        public void Detach(object entity);
+        public void DetectChanges();
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        public int ExecuteFunction(string functionName, params ObjectParameter[] parameters);
+        public ObjectResult<TElement> ExecuteFunction<TElement>(string functionName, MergeOption mergeOption, params ObjectParameter[] parameters);
+        public ObjectResult<TElement> ExecuteFunction<TElement>(string functionName, params ObjectParameter[] parameters);
+        public int ExecuteStoreCommand(string commandText, params object[] parameters);
+        public ObjectResult<TElement> ExecuteStoreQuery<TElement>(string commandText, params object[] parameters);
+        public ObjectResult<TEntity> ExecuteStoreQuery<TEntity>(string commandText, string entitySetName, MergeOption mergeOption, params object[] parameters);
+        public static IEnumerable<Type> GetKnownProxyTypes();
+        public object GetObjectByKey(EntityKey key);
+        public static Type GetObjectType(Type type);
+        public void LoadProperty(object entity, string navigationProperty);
+        public void LoadProperty(object entity, string navigationProperty, MergeOption mergeOption);
+        public void LoadProperty<TEntity>(TEntity entity, Expression<Func<TEntity, object>> selector);
+        public void LoadProperty<TEntity>(TEntity entity, Expression<Func<TEntity, object>> selector, MergeOption mergeOption);
+        public void Refresh(RefreshMode refreshMode, IEnumerable collection);
+        public void Refresh(RefreshMode refreshMode, object entity);
+        public int SaveChanges();
+        public int SaveChanges(bool acceptChangesDuringSave);
+        public virtual int SaveChanges(SaveOptions options);
+        public ObjectResult<TElement> Translate<TElement>(DbDataReader reader);
+        public ObjectResult<TEntity> Translate<TEntity>(DbDataReader reader, string entitySetName, MergeOption mergeOption);
+        public bool TryGetObjectByKey(EntityKey key, out object value);
+    }
+    public sealed class ObjectContextOptions {
+        public bool LazyLoadingEnabled { get; set; }
+        public bool ProxyCreationEnabled { get; set; }
+        public bool UseConsistentNullReferenceBehavior { get; set; }
+        public bool UseCSharpNullComparisonBehavior { get; set; }
+        public bool UseLegacyPreserveChangesBehavior { get; set; }
+    }
+    public class ObjectMaterializedEventArgs : EventArgs {
+        public object Entity { get; }
+    }
+    public delegate void ObjectMaterializedEventHandler(object sender, ObjectMaterializedEventArgs e);
+    public sealed class ObjectParameter {
+        public ObjectParameter(string name, object value);
+        public ObjectParameter(string name, Type type);
+        public string Name { get; }
+        public Type ParameterType { get; }
+        public object Value { get; set; }
+    }
+    public sealed class ObjectParameterCollection : ICollection<ObjectParameter>, IEnumerable, IEnumerable<ObjectParameter> {
+        public int Count { get; }
+        bool System.Collections.Generic.ICollection<System.Data.Objects.ObjectParameter>.IsReadOnly { get; }
+        public ObjectParameter this[string name] { get; }
+        public void Add(ObjectParameter parameter);
+        public void Clear();
+        public bool Contains(ObjectParameter parameter);
+        public bool Contains(string name);
+        public void CopyTo(ObjectParameter[] array, int index);
+        public bool Remove(ObjectParameter parameter);
+        IEnumerator<ObjectParameter> System.Collections.Generic.IEnumerable<System.Data.Objects.ObjectParameter>.GetEnumerator();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+    }
+    public abstract class ObjectQuery : IEnumerable, IListSource, IOrderedQueryable, IQueryable {
+        public string CommandText { get; }
+        public ObjectContext Context { get; }
+        public bool EnablePlanCaching { get; set; }
+        public MergeOption MergeOption { get; set; }
+        public ObjectParameterCollection Parameters { get; }
+        bool System.ComponentModel.IListSource.ContainsListCollection { get; }
+        Type System.Linq.IQueryable.ElementType { get; }
+        Expression System.Linq.IQueryable.Expression { get; }
+        IQueryProvider System.Linq.IQueryable.Provider { get; }
+        public ObjectResult Execute(MergeOption mergeOption);
+        public TypeUsage GetResultType();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        IList System.ComponentModel.IListSource.GetList();
+        public string ToTraceString();
+    }
+    public class ObjectQuery<T> : ObjectQuery, IEnumerable, IEnumerable<T>, IListSource, IOrderedQueryable, IOrderedQueryable<T>, IQueryable, IQueryable<T> {
+        public ObjectQuery(string commandText, ObjectContext context);
+        public ObjectQuery(string commandText, ObjectContext context, MergeOption mergeOption);
+        public string Name { get; set; }
+        public ObjectQuery<T> Distinct();
+        public ObjectQuery<T> Except(ObjectQuery<T> query);
+        public new ObjectResult<T> Execute(MergeOption mergeOption);
+        public ObjectQuery<DbDataRecord> GroupBy(string keys, string projection, params ObjectParameter[] parameters);
+        public ObjectQuery<T> Include(string path);
+        public ObjectQuery<T> Intersect(ObjectQuery<T> query);
+        public ObjectQuery<TResultType> OfType<TResultType>();
+        public ObjectQuery<T> OrderBy(string keys, params ObjectParameter[] parameters);
+        public ObjectQuery<DbDataRecord> Select(string projection, params ObjectParameter[] parameters);
+        public ObjectQuery<TResultType> SelectValue<TResultType>(string projection, params ObjectParameter[] parameters);
+        public ObjectQuery<T> Skip(string keys, string count, params ObjectParameter[] parameters);
+        IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
+        public ObjectQuery<T> Top(string count, params ObjectParameter[] parameters);
+        public ObjectQuery<T> Union(ObjectQuery<T> query);
+        public ObjectQuery<T> UnionAll(ObjectQuery<T> query);
+        public ObjectQuery<T> Where(string predicate, params ObjectParameter[] parameters);
+    }
+    public abstract class ObjectResult : IDisposable, IEnumerable, IListSource {
+        public abstract Type ElementType { get; }
+        bool System.ComponentModel.IListSource.ContainsListCollection { get; }
+        public abstract void Dispose();
+        public ObjectResult<TElement> GetNextResult<TElement>();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        IList System.ComponentModel.IListSource.GetList();
+    }
+    public sealed class ObjectResult<T> : ObjectResult, IEnumerable, IEnumerable<T> {
+        public override Type ElementType { get; }
+        public override void Dispose();
+        public IEnumerator<T> GetEnumerator();
+    }
+    public class ObjectSet<TEntity> : ObjectQuery<TEntity>, IEnumerable, IEnumerable<TEntity>, IObjectSet<TEntity>, IQueryable, IQueryable<TEntity> where TEntity : class {
+        public EntitySet EntitySet { get; }
+        public void AddObject(TEntity entity);
+        public TEntity ApplyCurrentValues(TEntity currentEntity);
+        public TEntity ApplyOriginalValues(TEntity originalEntity);
+        public void Attach(TEntity entity);
+        public TEntity CreateObject();
+        public T CreateObject<T>() where T : class, TEntity;
+        public void DeleteObject(TEntity entity);
+        public void Detach(TEntity entity);
+    }
+    public abstract class ObjectStateEntry : IEntityChangeTracker, IEntityStateEntry {
+        public abstract CurrentValueRecord CurrentValues { get; }
+        public abstract object Entity { get; }
+        public abstract EntityKey EntityKey { get; internal set; }
+        public EntitySetBase EntitySet { get; }
+        public abstract bool IsRelationship { get; }
+        public ObjectStateManager ObjectStateManager { get; }
+        public abstract DbDataRecord OriginalValues { get; }
+        public abstract RelationshipManager RelationshipManager { get; }
+        public EntityState State { get; internal set; }
+        EntityState System.Data.Objects.DataClasses.IEntityChangeTracker.EntityState { get; }
+        public abstract void AcceptChanges();
+        public abstract void ApplyCurrentValues(object currentEntity);
+        public abstract void ApplyOriginalValues(object originalEntity);
+        public abstract void ChangeState(EntityState state);
+        public abstract void Delete();
+        public abstract IEnumerable<string> GetModifiedProperties();
+        public abstract OriginalValueRecord GetUpdatableOriginalValues();
+        public abstract bool IsPropertyChanged(string propertyName);
+        public abstract void RejectPropertyChanges(string propertyName);
+        public abstract void SetModified();
+        public abstract void SetModifiedProperty(string propertyName);
+        void System.Data.Objects.DataClasses.IEntityChangeTracker.EntityComplexMemberChanged(string entityMemberName, object complexObject, string complexObjectMemberName);
+        void System.Data.Objects.DataClasses.IEntityChangeTracker.EntityComplexMemberChanging(string entityMemberName, object complexObject, string complexObjectMemberName);
+        void System.Data.Objects.DataClasses.IEntityChangeTracker.EntityMemberChanged(string entityMemberName);
+        void System.Data.Objects.DataClasses.IEntityChangeTracker.EntityMemberChanging(string entityMemberName);
+    }
+    public class ObjectStateManager : IEntityStateManager {
+        public ObjectStateManager(MetadataWorkspace metadataWorkspace);
+        public MetadataWorkspace MetadataWorkspace { get; }
+        public event CollectionChangeEventHandler ObjectStateManagerChanged;
+        public ObjectStateEntry ChangeObjectState(object entity, EntityState entityState);
+        public ObjectStateEntry ChangeRelationshipState(object sourceEntity, object targetEntity, string navigationProperty, EntityState relationshipState);
+        public ObjectStateEntry ChangeRelationshipState(object sourceEntity, object targetEntity, string relationshipName, string targetRoleName, EntityState relationshipState);
+        public ObjectStateEntry ChangeRelationshipState<TEntity>(TEntity sourceEntity, object targetEntity, Expression<Func<TEntity, object>> navigationPropertySelector, EntityState relationshipState) where TEntity : class;
+        public IEnumerable<ObjectStateEntry> GetObjectStateEntries(EntityState state);
+        public ObjectStateEntry GetObjectStateEntry(EntityKey key);
+        public ObjectStateEntry GetObjectStateEntry(object entity);
+        public RelationshipManager GetRelationshipManager(object entity);
+        public bool TryGetObjectStateEntry(EntityKey key, out ObjectStateEntry entry);
+        public bool TryGetObjectStateEntry(object entity, out ObjectStateEntry entry);
+        public bool TryGetRelationshipManager(object entity, out RelationshipManager relationshipManager);
+    }
+    public abstract class OriginalValueRecord : DbUpdatableDataRecord
+    public class ProxyDataContractResolver : DataContractResolver {
+        public ProxyDataContractResolver();
+        public override Type ResolveName(string typeName, string typeNamespace, Type declaredType, DataContractResolver knownTypeResolver);
+        public override bool TryResolveType(Type dataContractType, Type declaredType, DataContractResolver knownTypeResolver, out XmlDictionaryString typeName, out XmlDictionaryString typeNamespace);
+    }
+    public enum RefreshMode {
+        ClientWins = 2,
+        StoreWins = 1,
+    }
+    public enum SaveOptions {
+        AcceptAllChangesAfterSave = 1,
+        DetectChangesBeforeSave = 2,
+        None = 0,
+    }
+}
```

