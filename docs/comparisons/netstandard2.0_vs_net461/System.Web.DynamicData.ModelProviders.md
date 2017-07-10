# System.Web.DynamicData.ModelProviders

``` diff
+namespace System.Web.DynamicData.ModelProviders {
+    public enum AssociationDirection {
+        ManyToMany = 3,
+        ManyToOne = 2,
+        OneToMany = 1,
+        OneToOne = 0,
+    }
+    public abstract class AssociationProvider {
+        protected AssociationProvider();
+        public virtual AssociationDirection Direction { get; protected set; }
+        public virtual ReadOnlyCollection<string> ForeignKeyNames { get; protected set; }
+        public virtual ColumnProvider FromColumn { get; protected set; }
+        public virtual bool IsPrimaryKeyInThisTable { get; protected set; }
+        public virtual ColumnProvider ToColumn { get; protected set; }
+        public virtual TableProvider ToTable { get; protected set; }
+        public virtual string GetSortExpression(ColumnProvider sortColumn);
+    }
+    public abstract class ColumnProvider {
+        protected ColumnProvider(TableProvider table);
+        public virtual AssociationProvider Association { get; protected set; }
+        public virtual AttributeCollection Attributes { get; }
+        public virtual Type ColumnType { get; protected set; }
+        public virtual PropertyInfo EntityTypeProperty { get; protected set; }
+        public virtual bool IsCustomProperty { get; protected set; }
+        public virtual bool IsForeignKeyComponent { get; protected set; }
+        public virtual bool IsGenerated { get; protected set; }
+        public virtual bool IsPrimaryKey { get; protected set; }
+        public virtual bool IsReadOnly { get; protected set; }
+        public virtual bool IsSortable { get; protected set; }
+        public virtual int MaxLength { get; protected set; }
+        public virtual string Name { get; protected set; }
+        public virtual bool Nullable { get; protected set; }
+        public TableProvider Table { get; private set; }
+        protected static AttributeCollection AddDefaultAttributes(ColumnProvider columnProvider, AttributeCollection attributes);
+        public override string ToString();
+    }
+    public abstract class DataModelProvider {
+        protected DataModelProvider();
+        public virtual Type ContextType { get; protected set; }
+        public abstract ReadOnlyCollection<TableProvider> Tables { get; }
+        public abstract object CreateContext();
+    }
+    public abstract class TableProvider {
+        protected TableProvider(DataModelProvider model);
+        public virtual AttributeCollection Attributes { get; }
+        public abstract ReadOnlyCollection<ColumnProvider> Columns { get; }
+        public virtual string DataContextPropertyName { get; protected set; }
+        public DataModelProvider DataModel { get; internal set; }
+        public virtual Type EntityType { get; protected set; }
+        public virtual string Name { get; protected set; }
+        public virtual Type ParentEntityType { get; protected set; }
+        public virtual Type RootEntityType { get; protected set; }
+        public virtual bool CanDelete(IPrincipal principal);
+        public virtual bool CanInsert(IPrincipal principal);
+        public virtual bool CanRead(IPrincipal principal);
+        public virtual bool CanUpdate(IPrincipal principal);
+        public virtual object EvaluateForeignKey(object row, string foreignKeyName);
+        public abstract IQueryable GetQuery(object context);
+        public virtual ICustomTypeDescriptor GetTypeDescriptor();
+        public override string ToString();
+    }
+}
```

