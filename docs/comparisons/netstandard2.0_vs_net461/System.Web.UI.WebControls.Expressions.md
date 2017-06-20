# System.Web.UI.WebControls.Expressions

``` diff
+namespace System.Web.UI.WebControls.Expressions {
+    public class CustomExpression : ParameterDataSourceExpression {
+        public CustomExpression();
+        public event EventHandler<CustomExpressionEventArgs> Querying;
+        public override IQueryable GetQueryable(IQueryable source);
+    }
+    public class CustomExpressionEventArgs : EventArgs {
+        public CustomExpressionEventArgs(IQueryable source, IDictionary<string, object> values);
+        public IQueryable Query { get; set; }
+        public IDictionary<string, object> Values { get; private set; }
+    }
+    public abstract class DataSourceExpression : IStateManager {
+        protected DataSourceExpression();
+        protected HttpContext Context { get; private set; }
+        public IQueryableDataSource DataSource { get; internal set; }
+        protected bool IsTrackingViewState { get; }
+        protected Control Owner { get; private set; }
+        bool System.Web.UI.IStateManager.IsTrackingViewState { get; }
+        protected StateBag ViewState { get; }
+        public abstract IQueryable GetQueryable(IQueryable source);
+        protected virtual void LoadViewState(object savedState);
+        protected virtual object SaveViewState();
+        public virtual void SetContext(Control owner, HttpContext context, IQueryableDataSource dataSource);
+        public void SetDirty();
+        void System.Web.UI.IStateManager.LoadViewState(object state);
+        object System.Web.UI.IStateManager.SaveViewState();
+        void System.Web.UI.IStateManager.TrackViewState();
+        protected virtual void TrackViewState();
+    }
+    public class DataSourceExpressionCollection : StateManagedCollection {
+        public DataSourceExpressionCollection();
+        public HttpContext Context { get; private set; }
+        public Control Owner { get; private set; }
+        public DataSourceExpression this[int index] { get; set; }
+        public void Add(DataSourceExpression expression);
+        public void Contains(DataSourceExpression expression);
+        public void CopyTo(DataSourceExpression[] expressionArray, int index);
+        protected override object CreateKnownType(int index);
+        protected override Type[] GetKnownTypes();
+        public int IndexOf(DataSourceExpression expression);
+        public void Insert(int index, DataSourceExpression expression);
+        public void Remove(DataSourceExpression expression);
+        public void RemoveAt(int index);
+        protected override void SetDirtyObject(object o);
+    }
+    public class MethodExpression : ParameterDataSourceExpression {
+        public MethodExpression();
+        public bool IgnoreIfNotFound { get; set; }
+        public string MethodName { get; set; }
+        public string TypeName { get; set; }
+        public override IQueryable GetQueryable(IQueryable source);
+    }
+    public class OfTypeExpression : DataSourceExpression {
+        public OfTypeExpression();
+        public OfTypeExpression(Type type);
+        public string TypeName { get; set; }
+        public override IQueryable GetQueryable(IQueryable query);
+    }
+    public class OrderByExpression : DataSourceExpression {
+        public OrderByExpression();
+        public string DataField { get; set; }
+        public SortDirection Direction { get; set; }
+        public Collection<ThenBy> ThenByExpressions { get; }
+        public override IQueryable GetQueryable(IQueryable source);
+    }
+    public abstract class ParameterDataSourceExpression : DataSourceExpression {
+        protected ParameterDataSourceExpression();
+        public ParameterCollection Parameters { get; }
+        protected override void LoadViewState(object savedState);
+        protected override object SaveViewState();
+        public override void SetContext(Control owner, HttpContext context, IQueryableDataSource dataSource);
+        protected override void TrackViewState();
+    }
+    public class PropertyExpression : ParameterDataSourceExpression {
+        public PropertyExpression();
+        public override IQueryable GetQueryable(IQueryable source);
+    }
+    public class QueryExpression {
+        public QueryExpression();
+        public DataSourceExpressionCollection Expressions { get; }
+        public virtual IQueryable GetQueryable(IQueryable source);
+        public void Initialize(Control owner, HttpContext context, IQueryableDataSource dataSource);
+    }
+    public class RangeExpression : ParameterDataSourceExpression {
+        public RangeExpression();
+        public string DataField { get; set; }
+        public RangeType MaxType { get; set; }
+        public RangeType MinType { get; set; }
+        public override IQueryable GetQueryable(IQueryable source);
+    }
+    public enum RangeType {
+        Exclusive = 1,
+        Inclusive = 2,
+        None = 0,
+    }
+    public class SearchExpression : ParameterDataSourceExpression {
+        public SearchExpression();
+        public StringComparison ComparisonType { get; set; }
+        public string DataFields { get; set; }
+        public SearchType SearchType { get; set; }
+        public override IQueryable GetQueryable(IQueryable source);
+    }
+    public enum SearchType {
+        Contains = 0,
+        EndsWith = 2,
+        StartsWith = 1,
+    }
+    public class ThenBy {
+        public ThenBy();
+        public string DataField { get; set; }
+        public SortDirection Direction { get; set; }
+    }
+}
```

