# System.Data.Linq

``` diff
+namespace System.Data.Linq {
+    public sealed class Binary : IEquatable<Binary> {
+        public Binary(byte[] value);
+        public int Length { get; }
+        public bool Equals(Binary other);
+        public override bool Equals(object obj);
+        public override int GetHashCode();
+        public static bool operator ==(Binary binary1, Binary binary2);
+        public static implicit operator Binary (byte[] value);
+        public static bool operator !=(Binary binary1, Binary binary2);
+        public byte[] ToArray();
+        public override string ToString();
+    }
+    public enum ChangeAction {
+        Delete = 1,
+        Insert = 2,
+        None = 0,
+        Update = 3,
+    }
+    public sealed class ChangeConflictCollection : ICollection, ICollection<ObjectChangeConflict>, IEnumerable, IEnumerable<ObjectChangeConflict> {
+        public int Count { get; }
+        bool System.Collections.Generic.ICollection<System.Data.Linq.ObjectChangeConflict>.IsReadOnly { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        public ObjectChangeConflict this[int index] { get; }
+        public void Clear();
+        public bool Contains(ObjectChangeConflict item);
+        public void CopyTo(ObjectChangeConflict[] array, int arrayIndex);
+        public IEnumerator<ObjectChangeConflict> GetEnumerator();
+        public bool Remove(ObjectChangeConflict item);
+        public void ResolveAll(RefreshMode mode);
+        public void ResolveAll(RefreshMode mode, bool autoResolveDeletes);
+        void System.Collections.Generic.ICollection<System.Data.Linq.ObjectChangeConflict>.Add(ObjectChangeConflict item);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+    }
+    public class ChangeConflictException : Exception {
+        public ChangeConflictException();
+        public ChangeConflictException(string message);
+        public ChangeConflictException(string message, Exception innerException);
+    }
+    public sealed class ChangeSet {
+        public IList<object> Deletes { get; }
+        public IList<object> Inserts { get; }
+        public IList<object> Updates { get; }
+        public override string ToString();
+    }
+    public sealed class CompiledQuery {
+        public LambdaExpression Expression { get; }
+        public static Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(Expression<Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>> query) where TArg0 : DataContext;
+        public static Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(Expression<Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>> query) where TArg0 : DataContext;
+        public static Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(Expression<Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>> query) where TArg0 : DataContext;
+        public static Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(Expression<Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>> query) where TArg0 : DataContext;
+        public static Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(Expression<Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>> query) where TArg0 : DataContext;
+        public static Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(Expression<Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>> query) where TArg0 : DataContext;
+        public static Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(Expression<Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>> query) where TArg0 : DataContext;
+        public static Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(Expression<Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>> query) where TArg0 : DataContext;
+        public static Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(Expression<Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>> query) where TArg0 : DataContext;
+        public static Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(Expression<Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>> query) where TArg0 : DataContext;
+        public static Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(Expression<Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TResult>> query) where TArg0 : DataContext;
+        public static Func<TArg0, TArg1, TArg2, TArg3, TArg4, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TResult>(Expression<Func<TArg0, TArg1, TArg2, TArg3, TArg4, TResult>> query) where TArg0 : DataContext;
+        public static Func<TArg0, TArg1, TArg2, TArg3, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TResult>(Expression<Func<TArg0, TArg1, TArg2, TArg3, TResult>> query) where TArg0 : DataContext;
+        public static Func<TArg0, TArg1, TArg2, TResult> Compile<TArg0, TArg1, TArg2, TResult>(Expression<Func<TArg0, TArg1, TArg2, TResult>> query) where TArg0 : DataContext;
+        public static Func<TArg0, TArg1, TResult> Compile<TArg0, TArg1, TResult>(Expression<Func<TArg0, TArg1, TResult>> query) where TArg0 : DataContext;
+        public static Func<TArg0, TResult> Compile<TArg0, TResult>(Expression<Func<TArg0, TResult>> query) where TArg0 : DataContext;
+    }
+    public enum ConflictMode {
+        ContinueOnConflict = 1,
+        FailOnFirstConflict = 0,
+    }
+    public class DataContext : IDisposable {
+        public DataContext(IDbConnection connection);
+        public DataContext(IDbConnection connection, MappingSource mapping);
+        public DataContext(string fileOrServerOrConnection);
+        public DataContext(string fileOrServerOrConnection, MappingSource mapping);
+        public ChangeConflictCollection ChangeConflicts { get; }
+        public int CommandTimeout { get; set; }
+        public DbConnection Connection { get; }
+        public bool DeferredLoadingEnabled { get; set; }
+        public DataLoadOptions LoadOptions { get; set; }
+        public TextWriter Log { get; set; }
+        public MetaModel Mapping { get; }
+        public bool ObjectTrackingEnabled { get; set; }
+        public DbTransaction Transaction { get; set; }
+        public void CreateDatabase();
+        protected internal IQueryable<TResult> CreateMethodCallQuery<TResult>(object instance, MethodInfo methodInfo, params object[] parameters);
+        public bool DatabaseExists();
+        public void DeleteDatabase();
+        public void Dispose();
+        protected virtual void Dispose(bool disposing);
+        public int ExecuteCommand(string command, params object[] parameters);
+        protected internal void ExecuteDynamicDelete(object entity);
+        protected internal void ExecuteDynamicInsert(object entity);
+        protected internal void ExecuteDynamicUpdate(object entity);
+        protected internal IExecuteResult ExecuteMethodCall(object instance, MethodInfo methodInfo, params object[] parameters);
+        public IEnumerable ExecuteQuery(Type elementType, string query, params object[] parameters);
+        public IEnumerable<TResult> ExecuteQuery<TResult>(string query, params object[] parameters);
+        public ChangeSet GetChangeSet();
+        public DbCommand GetCommand(IQueryable query);
+        public ITable GetTable(Type type);
+        public Table<TEntity> GetTable<TEntity>() where TEntity : class;
+        public void Refresh(RefreshMode mode, IEnumerable entities);
+        public void Refresh(RefreshMode mode, object entity);
+        public void Refresh(RefreshMode mode, params object[] entities);
+        public void SubmitChanges();
+        public virtual void SubmitChanges(ConflictMode failureMode);
+        public IMultipleResults Translate(DbDataReader reader);
+        public IEnumerable Translate(Type elementType, DbDataReader reader);
+        public IEnumerable<TResult> Translate<TResult>(DbDataReader reader);
+    }
+    public sealed class DataLoadOptions {
+        public DataLoadOptions();
+        public void AssociateWith(LambdaExpression expression);
+        public void AssociateWith<T>(Expression<Func<T, object>> expression);
+        public void LoadWith(LambdaExpression expression);
+        public void LoadWith<T>(Expression<Func<T, object>> expression);
+    }
+    public static class DBConvert {
+        public static object ChangeType(object value, Type type);
+        public static T ChangeType<T>(object value);
+    }
+    public class DuplicateKeyException : InvalidOperationException {
+        public DuplicateKeyException(object duplicate);
+        public DuplicateKeyException(object duplicate, string message);
+        public DuplicateKeyException(object duplicate, string message, Exception innerException);
+        public object Object { get; }
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct EntityRef<TEntity> where TEntity : class {
+        public EntityRef(IEnumerable<TEntity> source);
+        public EntityRef(EntityRef<TEntity> entityRef);
+        public EntityRef(TEntity entity);
+        public TEntity Entity { get; set; }
+        public bool HasLoadedOrAssignedValue { get; }
+    }
+    public sealed class EntitySet<TEntity> : ICollection, ICollection<TEntity>, IEnumerable, IEnumerable<TEntity>, IList, IList<TEntity>, IListSource where TEntity : class {
+        public EntitySet();
+        public EntitySet(Action<TEntity> onAdd, Action<TEntity> onRemove);
+        public int Count { get; }
+        public bool HasLoadedOrAssignedValues { get; }
+        public bool IsDeferred { get; }
+        bool System.Collections.Generic.ICollection<TEntity>.IsReadOnly { get; }
+        bool System.Collections.ICollection.IsSynchronized { get; }
+        object System.Collections.ICollection.SyncRoot { get; }
+        bool System.Collections.IList.IsFixedSize { get; }
+        bool System.Collections.IList.IsReadOnly { get; }
+        object System.Collections.IList.this[int index] { get; set; }
+        bool System.ComponentModel.IListSource.ContainsListCollection { get; }
+        public TEntity this[int index] { get; set; }
+        public event ListChangedEventHandler ListChanged;
+        public void Add(TEntity entity);
+        public void AddRange(IEnumerable<TEntity> collection);
+        public void Assign(IEnumerable<TEntity> entitySource);
+        public void Clear();
+        public bool Contains(TEntity entity);
+        public void CopyTo(TEntity[] array, int arrayIndex);
+        public IEnumerator<TEntity> GetEnumerator();
+        public IBindingList GetNewBindingList();
+        public int IndexOf(TEntity entity);
+        public void Insert(int index, TEntity entity);
+        public void Load();
+        public bool Remove(TEntity entity);
+        public void RemoveAt(int index);
+        public void SetSource(IEnumerable<TEntity> entitySource);
+        void System.Collections.ICollection.CopyTo(Array array, int index);
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        int System.Collections.IList.Add(object value);
+        bool System.Collections.IList.Contains(object value);
+        int System.Collections.IList.IndexOf(object value);
+        void System.Collections.IList.Insert(int index, object value);
+        void System.Collections.IList.Remove(object value);
+        IList System.ComponentModel.IListSource.GetList();
+    }
+    public class ForeignKeyReferenceAlreadyHasValueException : InvalidOperationException {
+        public ForeignKeyReferenceAlreadyHasValueException();
+        public ForeignKeyReferenceAlreadyHasValueException(string message);
+        public ForeignKeyReferenceAlreadyHasValueException(string message, Exception innerException);
+    }
+    public interface IExecuteResult : IDisposable {
+        object ReturnValue { get; }
+        object GetParameterValue(int parameterIndex);
+    }
+    public interface IFunctionResult {
+        object ReturnValue { get; }
+    }
+    public interface IMultipleResults : IDisposable, IFunctionResult {
+        IEnumerable<TElement> GetResult<TElement>();
+    }
+    public interface ISingleResult<T> : IDisposable, IEnumerable, IEnumerable<T>, IFunctionResult
+    public interface ITable : IEnumerable, IQueryable {
+        DataContext Context { get; }
+        bool IsReadOnly { get; }
+        void Attach(object entity);
+        void Attach(object entity, bool asModified);
+        void Attach(object entity, object original);
+        void AttachAll(IEnumerable entities);
+        void AttachAll(IEnumerable entities, bool asModified);
+        void DeleteAllOnSubmit(IEnumerable entities);
+        void DeleteOnSubmit(object entity);
+        ModifiedMemberInfo[] GetModifiedMembers(object entity);
+        object GetOriginalEntityState(object entity);
+        void InsertAllOnSubmit(IEnumerable entities);
+        void InsertOnSubmit(object entity);
+    }
+    public interface ITable<TEntity> : IEnumerable, IEnumerable<TEntity>, IQueryable, IQueryable<TEntity> where TEntity : class {
+        void Attach(TEntity entity);
+        void DeleteOnSubmit(TEntity entity);
+        void InsertOnSubmit(TEntity entity);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct Link<T> {
+        public Link(IEnumerable<T> source);
+        public Link(Link<T> link);
+        public Link(T value);
+        public bool HasLoadedOrAssignedValue { get; }
+        public bool HasValue { get; }
+        public T Value { get; set; }
+    }
+    public sealed class MemberChangeConflict {
+        public object CurrentValue { get; }
+        public object DatabaseValue { get; }
+        public bool IsModified { get; }
+        public bool IsResolved { get; }
+        public MemberInfo Member { get; }
+        public object OriginalValue { get; }
+        public void Resolve(RefreshMode refreshMode);
+        public void Resolve(object value);
+    }
+    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
+    public struct ModifiedMemberInfo {
+        public object CurrentValue { get; }
+        public MemberInfo Member { get; }
+        public object OriginalValue { get; }
+    }
+    public sealed class ObjectChangeConflict {
+        public bool IsDeleted { get; }
+        public bool IsResolved { get; }
+        public ReadOnlyCollection<MemberChangeConflict> MemberConflicts { get; }
+        public object Object { get; }
+        public void Resolve();
+        public void Resolve(RefreshMode refreshMode);
+        public void Resolve(RefreshMode refreshMode, bool autoResolveDeletes);
+    }
+    public enum RefreshMode {
+        KeepChanges = 1,
+        KeepCurrentValues = 0,
+        OverwriteCurrentValues = 2,
+    }
+    public sealed class Table<TEntity> : IEnumerable, IEnumerable<TEntity>, IListSource, IQueryable, IQueryable<TEntity>, IQueryProvider, ITable, ITable<TEntity> where TEntity : class {
+        public DataContext Context { get; }
+        public bool IsReadOnly { get; }
+        bool System.ComponentModel.IListSource.ContainsListCollection { get; }
+        Type System.Linq.IQueryable.ElementType { get; }
+        Expression System.Linq.IQueryable.Expression { get; }
+        IQueryProvider System.Linq.IQueryable.Provider { get; }
+        public void Attach(TEntity entity);
+        public void Attach(TEntity entity, bool asModified);
+        public void Attach(TEntity entity, TEntity original);
+        public void AttachAll<TSubEntity>(IEnumerable<TSubEntity> entities) where TSubEntity : TEntity;
+        public void AttachAll<TSubEntity>(IEnumerable<TSubEntity> entities, bool asModified) where TSubEntity : TEntity;
+        public void DeleteAllOnSubmit<TSubEntity>(IEnumerable<TSubEntity> entities) where TSubEntity : TEntity;
+        public void DeleteOnSubmit(TEntity entity);
+        public IEnumerator<TEntity> GetEnumerator();
+        public ModifiedMemberInfo[] GetModifiedMembers(TEntity entity);
+        public IBindingList GetNewBindingList();
+        public TEntity GetOriginalEntityState(TEntity entity);
+        public void InsertAllOnSubmit<TSubEntity>(IEnumerable<TSubEntity> entities) where TSubEntity : TEntity;
+        public void InsertOnSubmit(TEntity entity);
+        IEnumerator<TEntity> System.Collections.Generic.IEnumerable<TEntity>.GetEnumerator();
+        IEnumerator System.Collections.IEnumerable.GetEnumerator();
+        IList System.ComponentModel.IListSource.GetList();
+        void System.Data.Linq.ITable.Attach(object entity);
+        void System.Data.Linq.ITable.Attach(object entity, bool asModified);
+        void System.Data.Linq.ITable.Attach(object entity, object original);
+        void System.Data.Linq.ITable.AttachAll(IEnumerable entities);
+        void System.Data.Linq.ITable.AttachAll(IEnumerable entities, bool asModified);
+        void System.Data.Linq.ITable.DeleteAllOnSubmit(IEnumerable entities);
+        void System.Data.Linq.ITable.DeleteOnSubmit(object entity);
+        ModifiedMemberInfo[] System.Data.Linq.ITable.GetModifiedMembers(object entity);
+        object System.Data.Linq.ITable.GetOriginalEntityState(object entity);
+        void System.Data.Linq.ITable.InsertAllOnSubmit(IEnumerable entities);
+        void System.Data.Linq.ITable.InsertOnSubmit(object entity);
+        IQueryable System.Linq.IQueryProvider.CreateQuery(Expression expression);
+        IQueryable<TResult> System.Linq.IQueryProvider.CreateQuery<TResult>(Expression expression);
+        object System.Linq.IQueryProvider.Execute(Expression expression);
+        TResult System.Linq.IQueryProvider.Execute<TResult>(Expression expression);
+        public override string ToString();
+    }
+}
```

