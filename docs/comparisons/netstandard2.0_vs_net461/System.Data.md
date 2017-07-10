# System.Data

``` diff
 namespace System.Data {
+    public static class DataRowComparer {
+        public static DataRowComparer<DataRow> Default { get; }
+    }
+    public sealed class DataRowComparer<TRow> : IEqualityComparer<TRow> where TRow : DataRow {
+        public static DataRowComparer<TRow> Default { get; }
+        public bool Equals(TRow leftRow, TRow rightRow);
+        public int GetHashCode(TRow row);
+    }
+    public static class DataRowExtensions {
+        public static T Field<T>(this DataRow row, DataColumn column);
+        public static T Field<T>(this DataRow row, DataColumn column, DataRowVersion version);
+        public static T Field<T>(this DataRow row, int columnIndex);
+        public static T Field<T>(this DataRow row, int columnIndex, DataRowVersion version);
+        public static T Field<T>(this DataRow row, string columnName);
+        public static T Field<T>(this DataRow row, string columnName, DataRowVersion version);
+        public static void SetField<T>(this DataRow row, DataColumn column, T value);
+        public static void SetField<T>(this DataRow row, int columnIndex, T value);
+        public static void SetField<T>(this DataRow row, string columnName, T value);
+    }
+    public class DataSetSchemaImporterExtension : SchemaImporterExtension {
+        public DataSetSchemaImporterExtension();
+        public override string ImportSchemaType(string name, string schemaNamespace, XmlSchemaObject context, XmlSchemas schemas, XmlSchemaImporter importer, CodeCompileUnit compileUnit, CodeNamespace mainNamespace, CodeGenerationOptions options, CodeDomProvider codeProvider);
+        public override string ImportSchemaType(XmlSchemaType type, XmlSchemaObject context, XmlSchemas schemas, XmlSchemaImporter importer, CodeCompileUnit compileUnit, CodeNamespace mainNamespace, CodeGenerationOptions options, CodeDomProvider codeProvider);
+    }
+    public static class DataTableExtensions {
+        public static DataView AsDataView(this DataTable table);
+        public static DataView AsDataView<T>(this EnumerableRowCollection<T> source) where T : DataRow;
+        public static EnumerableRowCollection<DataRow> AsEnumerable(this DataTable source);
+        public static DataTable CopyToDataTable<T>(this IEnumerable<T> source) where T : DataRow;
+        public static void CopyToDataTable<T>(this IEnumerable<T> source, DataTable table, LoadOption options) where T : DataRow;
+        public static void CopyToDataTable<T>(this IEnumerable<T> source, DataTable table, LoadOption options, FillErrorEventHandler errorHandler) where T : DataRow;
+    }
+    public sealed class EntityCommandCompilationException : EntityException {
+        public EntityCommandCompilationException();
+        public EntityCommandCompilationException(string message);
+        public EntityCommandCompilationException(string message, Exception innerException);
+    }
+    public sealed class EntityCommandExecutionException : EntityException {
+        public EntityCommandExecutionException();
+        public EntityCommandExecutionException(string message);
+        public EntityCommandExecutionException(string message, Exception innerException);
+    }
+    public class EntityException : DataException {
+        public EntityException();
+        protected EntityException(SerializationInfo info, StreamingContext context);
+        public EntityException(string message);
+        public EntityException(string message, Exception innerException);
+    }
+    public sealed class EntityKey : IEquatable<EntityKey> {
+        public static readonly EntityKey EntityNotValidKey;
+        public static readonly EntityKey NoEntitySetKey;
+        public EntityKey();
+        public EntityKey(string qualifiedEntitySetName, IEnumerable<KeyValuePair<string, object>> entityKeyValues);
+        public EntityKey(string qualifiedEntitySetName, IEnumerable<EntityKeyMember> entityKeyValues);
+        public EntityKey(string qualifiedEntitySetName, string keyName, object keyValue);
+        public string EntityContainerName { get; set; }
+        public EntityKeyMember[] EntityKeyValues { get; set; }
+        public string EntitySetName { get; set; }
+        public bool IsTemporary { get; }
+        public bool Equals(EntityKey other);
+        public override bool Equals(object obj);
+        public EntitySet GetEntitySet(MetadataWorkspace metadataWorkspace);
+        public override int GetHashCode();
+        public void OnDeserialized(StreamingContext context);
+        public void OnDeserializing(StreamingContext context);
+        public static bool operator ==(EntityKey key1, EntityKey key2);
+        public static bool operator !=(EntityKey key1, EntityKey key2);
+    }
+    public class EntityKeyMember {
+        public EntityKeyMember();
+        public EntityKeyMember(string keyName, object keyValue);
+        public string Key { get; set; }
+        public object Value { get; set; }
+        public override string ToString();
+    }
+    public sealed class EntitySqlException : EntityException {
+        public EntitySqlException();
+        public EntitySqlException(string message);
+        public EntitySqlException(string message, Exception innerException);
+        public int Column { get; }
+        public string ErrorContext { get; }
+        public string ErrorDescription { get; }
+        public int Line { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public enum EntityState {
+        Added = 4,
+        Deleted = 8,
+        Detached = 1,
+        Modified = 16,
+        Unchanged = 2,
+    }
+    public abstract class EnumerableRowCollection : IEnumerable {
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+    }
+    public class EnumerableRowCollection<TRow> : EnumerableRowCollection, IEnumerable, IEnumerable<TRow> {
+        public IEnumerator<TRow> GetEnumerator();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+    }
+    public static class EnumerableRowCollectionExtensions {
+        public static EnumerableRowCollection<TResult> Cast<TResult>(this EnumerableRowCollection source);
+        public static OrderedEnumerableRowCollection<TRow> OrderBy<TRow, TKey>(this EnumerableRowCollection<TRow> source, Func<TRow, TKey> keySelector);
+        public static OrderedEnumerableRowCollection<TRow> OrderBy<TRow, TKey>(this EnumerableRowCollection<TRow> source, Func<TRow, TKey> keySelector, IComparer<TKey> comparer);
+        public static OrderedEnumerableRowCollection<TRow> OrderByDescending<TRow, TKey>(this EnumerableRowCollection<TRow> source, Func<TRow, TKey> keySelector);
+        public static OrderedEnumerableRowCollection<TRow> OrderByDescending<TRow, TKey>(this EnumerableRowCollection<TRow> source, Func<TRow, TKey> keySelector, IComparer<TKey> comparer);
+        public static EnumerableRowCollection<S> Select<TRow, S>(this EnumerableRowCollection<TRow> source, Func<TRow, S> selector);
+        public static OrderedEnumerableRowCollection<TRow> ThenBy<TRow, TKey>(this OrderedEnumerableRowCollection<TRow> source, Func<TRow, TKey> keySelector);
+        public static OrderedEnumerableRowCollection<TRow> ThenBy<TRow, TKey>(this OrderedEnumerableRowCollection<TRow> source, Func<TRow, TKey> keySelector, IComparer<TKey> comparer);
+        public static OrderedEnumerableRowCollection<TRow> ThenByDescending<TRow, TKey>(this OrderedEnumerableRowCollection<TRow> source, Func<TRow, TKey> keySelector);
+        public static OrderedEnumerableRowCollection<TRow> ThenByDescending<TRow, TKey>(this OrderedEnumerableRowCollection<TRow> source, Func<TRow, TKey> keySelector, IComparer<TKey> comparer);
+        public static EnumerableRowCollection<TRow> Where<TRow>(this EnumerableRowCollection<TRow> source, Func<TRow, bool> predicate);
+    }
+    public interface IExtendedDataRecord : IDataRecord {
+        DataRecordInfo DataRecordInfo { get; }
+        DbDataReader GetDataReader(int i);
+        DbDataRecord GetDataRecord(int i);
+    }
+    public sealed class InvalidCommandTreeException : DataException {
+        public InvalidCommandTreeException();
+        public InvalidCommandTreeException(string message);
+        public InvalidCommandTreeException(string message, Exception innerException);
+    }
+    public sealed class MappingException : EntityException {
+        public MappingException();
+        public MappingException(string message);
+        public MappingException(string message, Exception innerException);
+    }
+    public sealed class MetadataException : EntityException {
+        public MetadataException();
+        public MetadataException(string message);
+        public MetadataException(string message, Exception innerException);
+    }
+    public sealed class ObjectNotFoundException : DataException {
+        public ObjectNotFoundException();
+        public ObjectNotFoundException(string message);
+        public ObjectNotFoundException(string message, Exception innerException);
+    }
+    public sealed class OperationAbortedException : SystemException
+    public sealed class OptimisticConcurrencyException : UpdateException {
+        public OptimisticConcurrencyException();
+        public OptimisticConcurrencyException(string message);
+        public OptimisticConcurrencyException(string message, Exception innerException);
+        public OptimisticConcurrencyException(string message, Exception innerException, IEnumerable<ObjectStateEntry> stateEntries);
+    }
+    public sealed class OrderedEnumerableRowCollection<TRow> : EnumerableRowCollection<TRow>
+    public enum PropertyAttributes {
+        NotSupported = 0,
+        Optional = 2,
+        Read = 512,
+        Required = 1,
+        Write = 1024,
+    }
+    public sealed class PropertyConstraintException : ConstraintException {
+        public PropertyConstraintException();
+        public PropertyConstraintException(string message);
+        public PropertyConstraintException(string message, Exception innerException);
+        public PropertyConstraintException(string message, string propertyName);
+        public PropertyConstraintException(string message, string propertyName, Exception innerException);
+        public string PropertyName { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public sealed class ProviderIncompatibleException : EntityException {
+        public ProviderIncompatibleException();
+        public ProviderIncompatibleException(string message);
+        public ProviderIncompatibleException(string message, Exception innerException);
+    }
+    public class TypedDataSetGenerator {
+        public TypedDataSetGenerator();
+        public static void Generate(DataSet dataSet, CodeNamespace codeNamespace, ICodeGenerator codeGen);
+        public static string GenerateIdName(string name, ICodeGenerator codeGen);
+    }
+    public class TypedDataSetGeneratorException : DataException {
+        public TypedDataSetGeneratorException();
+        public TypedDataSetGeneratorException(ArrayList list);
+        protected TypedDataSetGeneratorException(SerializationInfo info, StreamingContext context);
+        public TypedDataSetGeneratorException(string message);
+        public TypedDataSetGeneratorException(string message, Exception innerException);
+        public ArrayList ErrorList { get; }
+        public override void GetObjectData(SerializationInfo info, StreamingContext context);
+    }
+    public abstract class TypedTableBase<T> : DataTable, IEnumerable, IEnumerable<T> where T : DataRow {
+        protected TypedTableBase();
+        protected TypedTableBase(SerializationInfo info, StreamingContext context);
+        public EnumerableRowCollection<TResult> Cast<TResult>();
+        public IEnumerator<T> GetEnumerator();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+    }
+    public static class TypedTableBaseExtensions {
+        public static EnumerableRowCollection<TRow> AsEnumerable<TRow>(this TypedTableBase<TRow> source) where TRow : DataRow;
+        public static TRow ElementAtOrDefault<TRow>(this TypedTableBase<TRow> source, int index) where TRow : DataRow;
+        public static OrderedEnumerableRowCollection<TRow> OrderBy<TRow, TKey>(this TypedTableBase<TRow> source, Func<TRow, TKey> keySelector) where TRow : DataRow;
+        public static OrderedEnumerableRowCollection<TRow> OrderBy<TRow, TKey>(this TypedTableBase<TRow> source, Func<TRow, TKey> keySelector, IComparer<TKey> comparer) where TRow : DataRow;
+        public static OrderedEnumerableRowCollection<TRow> OrderByDescending<TRow, TKey>(this TypedTableBase<TRow> source, Func<TRow, TKey> keySelector) where TRow : DataRow;
+        public static OrderedEnumerableRowCollection<TRow> OrderByDescending<TRow, TKey>(this TypedTableBase<TRow> source, Func<TRow, TKey> keySelector, IComparer<TKey> comparer) where TRow : DataRow;
+        public static EnumerableRowCollection<S> Select<TRow, S>(this TypedTableBase<TRow> source, Func<TRow, S> selector) where TRow : DataRow;
+        public static EnumerableRowCollection<TRow> Where<TRow>(this TypedTableBase<TRow> source, Func<TRow, bool> predicate) where TRow : DataRow;
+    }
+    public class UpdateException : DataException {
+        public UpdateException();
+        protected UpdateException(SerializationInfo info, StreamingContext context);
+        public UpdateException(string message);
+        public UpdateException(string message, Exception innerException);
+        public UpdateException(string message, Exception innerException, IEnumerable<ObjectStateEntry> stateEntries);
+        public ReadOnlyCollection<ObjectStateEntry> StateEntries { get; }
+    }
 }
```

