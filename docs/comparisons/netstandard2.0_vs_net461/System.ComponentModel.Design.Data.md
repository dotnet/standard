# System.ComponentModel.Design.Data

``` diff
+namespace System.ComponentModel.Design.Data {
+    public abstract class DataSourceDescriptor {
+        protected DataSourceDescriptor();
+        public abstract Bitmap Image { get; }
+        public abstract bool IsDesignable { get; }
+        public abstract string Name { get; }
+        public abstract string TypeName { get; }
+    }
+    public class DataSourceDescriptorCollection : CollectionBase {
+        public DataSourceDescriptorCollection();
+        public DataSourceDescriptor this[int index] { get; set; }
+        public int Add(DataSourceDescriptor value);
+        public bool Contains(DataSourceDescriptor value);
+        public void CopyTo(DataSourceDescriptor[] array, int index);
+        public int IndexOf(DataSourceDescriptor value);
+        public void Insert(int index, DataSourceDescriptor value);
+        public void Remove(DataSourceDescriptor value);
+    }
+    public abstract class DataSourceGroup {
+        protected DataSourceGroup();
+        public abstract DataSourceDescriptorCollection DataSources { get; }
+        public abstract Bitmap Image { get; }
+        public abstract bool IsDefault { get; }
+        public abstract string Name { get; }
+    }
+    public class DataSourceGroupCollection : CollectionBase {
+        public DataSourceGroupCollection();
+        public DataSourceGroup this[int index] { get; set; }
+        public int Add(DataSourceGroup value);
+        public bool Contains(DataSourceGroup value);
+        public void CopyTo(DataSourceGroup[] array, int index);
+        public int IndexOf(DataSourceGroup value);
+        public void Insert(int index, DataSourceGroup value);
+        public void Remove(DataSourceGroup value);
+    }
+    public abstract class DataSourceProviderService {
+        protected DataSourceProviderService();
+        public abstract bool SupportsAddNewDataSource { get; }
+        public abstract bool SupportsConfigureDataSource { get; }
+        public abstract object AddDataSourceInstance(IDesignerHost host, DataSourceDescriptor dataSourceDescriptor);
+        public abstract DataSourceGroupCollection GetDataSources();
+        public abstract DataSourceGroup InvokeAddNewDataSource(IWin32Window parentWindow, FormStartPosition startPosition);
+        public abstract bool InvokeConfigureDataSource(IWin32Window parentWindow, FormStartPosition startPosition, DataSourceDescriptor dataSourceDescriptor);
+        public abstract void NotifyDataSourceComponentAdded(object dsc);
+    }
+    public sealed class DesignerDataColumn {
+        public DesignerDataColumn(string name, DbType dataType);
+        public DesignerDataColumn(string name, DbType dataType, object defaultValue);
+        public DesignerDataColumn(string name, DbType dataType, object defaultValue, bool identity, bool nullable, bool primaryKey, int precision, int scale, int length);
+        public DbType DataType { get; }
+        public object DefaultValue { get; }
+        public bool Identity { get; }
+        public int Length { get; }
+        public string Name { get; }
+        public bool Nullable { get; }
+        public int Precision { get; }
+        public bool PrimaryKey { get; }
+        public int Scale { get; }
+    }
+    public sealed class DesignerDataConnection {
+        public DesignerDataConnection(string name, string providerName, string connectionString);
+        public DesignerDataConnection(string name, string providerName, string connectionString, bool isConfigured);
+        public string ConnectionString { get; }
+        public bool IsConfigured { get; }
+        public string Name { get; }
+        public string ProviderName { get; }
+    }
+    public sealed class DesignerDataParameter {
+        public DesignerDataParameter(string name, DbType dataType, ParameterDirection direction);
+        public DbType DataType { get; }
+        public ParameterDirection Direction { get; }
+        public string Name { get; }
+    }
+    public sealed class DesignerDataRelationship {
+        public DesignerDataRelationship(string name, ICollection parentColumns, DesignerDataTable childTable, ICollection childColumns);
+        public ICollection ChildColumns { get; }
+        public DesignerDataTable ChildTable { get; }
+        public string Name { get; }
+        public ICollection ParentColumns { get; }
+    }
+    public sealed class DesignerDataSchemaClass {
+        public static readonly DesignerDataSchemaClass StoredProcedures;
+        public static readonly DesignerDataSchemaClass Tables;
+        public static readonly DesignerDataSchemaClass Views;
+    }
+    public abstract class DesignerDataStoredProcedure {
+        protected DesignerDataStoredProcedure(string name);
+        protected DesignerDataStoredProcedure(string name, string owner);
+        public string Name { get; }
+        public string Owner { get; }
+        public ICollection Parameters { get; }
+        protected abstract ICollection CreateParameters();
+    }
+    public abstract class DesignerDataTable : DesignerDataTableBase {
+        protected DesignerDataTable(string name);
+        protected DesignerDataTable(string name, string owner);
+        public ICollection Relationships { get; }
+        protected abstract ICollection CreateRelationships();
+    }
+    public abstract class DesignerDataTableBase {
+        protected DesignerDataTableBase(string name);
+        protected DesignerDataTableBase(string name, string owner);
+        public ICollection Columns { get; }
+        public string Name { get; }
+        public string Owner { get; }
+        protected abstract ICollection CreateColumns();
+    }
+    public abstract class DesignerDataView : DesignerDataTableBase {
+        protected DesignerDataView(string name);
+        protected DesignerDataView(string name, string owner);
+    }
+    public interface IDataEnvironment {
+        ICollection Connections { get; }
+        DesignerDataConnection BuildConnection(IWin32Window owner, DesignerDataConnection initialConnection);
+        string BuildQuery(IWin32Window owner, DesignerDataConnection connection, QueryBuilderMode mode, string initialQueryText);
+        DesignerDataConnection ConfigureConnection(IWin32Window owner, DesignerDataConnection connection, string name);
+        CodeExpression GetCodeExpression(DesignerDataConnection connection);
+        IDesignerDataSchema GetConnectionSchema(DesignerDataConnection connection);
+        DbConnection GetDesignTimeConnection(DesignerDataConnection connection);
+    }
+    public interface IDesignerDataSchema {
+        ICollection GetSchemaItems(DesignerDataSchemaClass schemaClass);
+        bool SupportsSchemaClass(DesignerDataSchemaClass schemaClass);
+    }
+    public enum QueryBuilderMode {
+        Delete = 3,
+        Insert = 2,
+        Select = 0,
+        Update = 1,
+    }
+}
```

