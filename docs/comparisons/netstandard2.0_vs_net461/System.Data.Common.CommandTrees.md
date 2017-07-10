# System.Data.Common.CommandTrees

``` diff
+namespace System.Data.Common.CommandTrees {
+    public abstract class DbAggregate {
+        public IList<DbExpression> Arguments { get; }
+        public TypeUsage ResultType { get; }
+    }
+    public sealed class DbAndExpression : DbBinaryExpression {
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public sealed class DbApplyExpression : DbExpression {
+        public DbExpressionBinding Apply { get; }
+        public DbExpressionBinding Input { get; }
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public sealed class DbArithmeticExpression : DbExpression {
+        public IList<DbExpression> Arguments { get; }
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public abstract class DbBinaryExpression : DbExpression {
+        public DbExpression Left { get; }
+        public DbExpression Right { get; }
+    }
+    public sealed class DbCaseExpression : DbExpression {
+        public DbExpression Else { get; }
+        public IList<DbExpression> Then { get; }
+        public IList<DbExpression> When { get; }
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public sealed class DbCastExpression : DbUnaryExpression {
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public abstract class DbCommandTree {
+        public IEnumerable<KeyValuePair<string, TypeUsage>> Parameters { get; }
+    }
+    public sealed class DbComparisonExpression : DbBinaryExpression {
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public sealed class DbConstantExpression : DbExpression {
+        public object Value { get; }
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public sealed class DbCrossJoinExpression : DbExpression {
+        public IList<DbExpressionBinding> Inputs { get; }
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public sealed class DbDeleteCommandTree : DbModificationCommandTree {
+        public DbExpression Predicate { get; }
+    }
+    public sealed class DbDerefExpression : DbUnaryExpression {
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public sealed class DbDistinctExpression : DbUnaryExpression {
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public sealed class DbElementExpression : DbUnaryExpression {
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public sealed class DbEntityRefExpression : DbUnaryExpression {
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public sealed class DbExceptExpression : DbBinaryExpression {
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public abstract class DbExpression {
+        public DbExpressionKind ExpressionKind { get; }
+        public TypeUsage ResultType { get; }
+        public abstract void Accept(DbExpressionVisitor visitor);
+        public abstract TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+        public override bool Equals(object obj);
+        public static DbExpression FromBinary(byte[] value);
+        public static DbExpression FromBoolean(Nullable<bool> value);
+        public static DbExpression FromByte(Nullable<byte> value);
+        public static DbExpression FromDateTime(Nullable<DateTime> value);
+        public static DbExpression FromDateTimeOffset(Nullable<DateTimeOffset> value);
+        public static DbExpression FromDecimal(Nullable<decimal> value);
+        public static DbExpression FromDouble(Nullable<double> value);
+        public static DbExpression FromGeography(DbGeography value);
+        public static DbExpression FromGeometry(DbGeometry value);
+        public static DbExpression FromGuid(Nullable<Guid> value);
+        public static DbExpression FromInt16(Nullable<short> value);
+        public static DbExpression FromInt32(Nullable<int> value);
+        public static DbExpression FromInt64(Nullable<long> value);
+        public static DbExpression FromSingle(Nullable<float> value);
+        public static DbExpression FromString(string value);
+        public override int GetHashCode();
+        public static implicit operator DbExpression (byte[] value);
+        public static implicit operator DbExpression (DbGeography value);
+        public static implicit operator DbExpression (DbGeometry value);
+        public static implicit operator DbExpression (Nullable<bool> value);
+        public static implicit operator DbExpression (Nullable<byte> value);
+        public static implicit operator DbExpression (Nullable<DateTime> value);
+        public static implicit operator DbExpression (Nullable<DateTimeOffset> value);
+        public static implicit operator DbExpression (Nullable<decimal> value);
+        public static implicit operator DbExpression (Nullable<double> value);
+        public static implicit operator DbExpression (Nullable<Guid> value);
+        public static implicit operator DbExpression (Nullable<short> value);
+        public static implicit operator DbExpression (Nullable<int> value);
+        public static implicit operator DbExpression (Nullable<long> value);
+        public static implicit operator DbExpression (Nullable<float> value);
+        public static implicit operator DbExpression (string value);
+    }
+    public sealed class DbExpressionBinding {
+        public DbExpression Expression { get; }
+        public DbVariableReferenceExpression Variable { get; }
+        public string VariableName { get; }
+        public TypeUsage VariableType { get; }
+    }
+    public enum DbExpressionKind {
+        All = 0,
+        And = 1,
+        Any = 2,
+        Case = 3,
+        Cast = 4,
+        Constant = 5,
+        CrossApply = 6,
+        CrossJoin = 7,
+        Deref = 8,
+        Distinct = 9,
+        Divide = 10,
+        Element = 11,
+        EntityRef = 12,
+        Equals = 13,
+        Except = 14,
+        Filter = 15,
+        FullOuterJoin = 16,
+        Function = 17,
+        GreaterThan = 18,
+        GreaterThanOrEquals = 19,
+        GroupBy = 20,
+        InnerJoin = 21,
+        Intersect = 22,
+        IsEmpty = 23,
+        IsNull = 24,
+        IsOf = 25,
+        IsOfOnly = 26,
+        Lambda = 57,
+        LeftOuterJoin = 27,
+        LessThan = 28,
+        LessThanOrEquals = 29,
+        Like = 30,
+        Limit = 31,
+        Minus = 32,
+        Modulo = 33,
+        Multiply = 34,
+        NewInstance = 35,
+        Not = 36,
+        NotEquals = 37,
+        Null = 38,
+        OfType = 39,
+        OfTypeOnly = 40,
+        Or = 41,
+        OuterApply = 42,
+        ParameterReference = 43,
+        Plus = 44,
+        Project = 45,
+        Property = 46,
+        Ref = 47,
+        RefKey = 48,
+        RelationshipNavigation = 49,
+        Scan = 50,
+        Skip = 51,
+        Sort = 52,
+        Treat = 53,
+        UnaryMinus = 54,
+        UnionAll = 55,
+        VariableReference = 56,
+    }
+    public abstract class DbExpressionVisitor {
+        protected DbExpressionVisitor();
+        public abstract void Visit(DbAndExpression expression);
+        public abstract void Visit(DbApplyExpression expression);
+        public abstract void Visit(DbArithmeticExpression expression);
+        public abstract void Visit(DbCaseExpression expression);
+        public abstract void Visit(DbCastExpression expression);
+        public abstract void Visit(DbComparisonExpression expression);
+        public abstract void Visit(DbConstantExpression expression);
+        public abstract void Visit(DbCrossJoinExpression expression);
+        public abstract void Visit(DbDerefExpression expression);
+        public abstract void Visit(DbDistinctExpression expression);
+        public abstract void Visit(DbElementExpression expression);
+        public abstract void Visit(DbEntityRefExpression expression);
+        public abstract void Visit(DbExceptExpression expression);
+        public abstract void Visit(DbExpression expression);
+        public abstract void Visit(DbFilterExpression expression);
+        public abstract void Visit(DbFunctionExpression expression);
+        public abstract void Visit(DbGroupByExpression expression);
+        public abstract void Visit(DbIntersectExpression expression);
+        public abstract void Visit(DbIsEmptyExpression expression);
+        public abstract void Visit(DbIsNullExpression expression);
+        public abstract void Visit(DbIsOfExpression expression);
+        public abstract void Visit(DbJoinExpression expression);
+        public virtual void Visit(DbLambdaExpression expression);
+        public abstract void Visit(DbLikeExpression expression);
+        public abstract void Visit(DbLimitExpression expression);
+        public abstract void Visit(DbNewInstanceExpression expression);
+        public abstract void Visit(DbNotExpression expression);
+        public abstract void Visit(DbNullExpression expression);
+        public abstract void Visit(DbOfTypeExpression expression);
+        public abstract void Visit(DbOrExpression expression);
+        public abstract void Visit(DbParameterReferenceExpression expression);
+        public abstract void Visit(DbProjectExpression expression);
+        public abstract void Visit(DbPropertyExpression expression);
+        public abstract void Visit(DbQuantifierExpression expression);
+        public abstract void Visit(DbRefExpression expression);
+        public abstract void Visit(DbRefKeyExpression expression);
+        public abstract void Visit(DbRelationshipNavigationExpression expression);
+        public abstract void Visit(DbScanExpression expression);
+        public abstract void Visit(DbSkipExpression expression);
+        public abstract void Visit(DbSortExpression expression);
+        public abstract void Visit(DbTreatExpression expression);
+        public abstract void Visit(DbUnionAllExpression expression);
+        public abstract void Visit(DbVariableReferenceExpression expression);
+    }
+    public abstract class DbExpressionVisitor<TResultType> {
+        protected DbExpressionVisitor();
+        public abstract TResultType Visit(DbAndExpression expression);
+        public abstract TResultType Visit(DbApplyExpression expression);
+        public abstract TResultType Visit(DbArithmeticExpression expression);
+        public abstract TResultType Visit(DbCaseExpression expression);
+        public abstract TResultType Visit(DbCastExpression expression);
+        public abstract TResultType Visit(DbComparisonExpression expression);
+        public abstract TResultType Visit(DbConstantExpression expression);
+        public abstract TResultType Visit(DbCrossJoinExpression expression);
+        public abstract TResultType Visit(DbDerefExpression expression);
+        public abstract TResultType Visit(DbDistinctExpression expression);
+        public abstract TResultType Visit(DbElementExpression expression);
+        public abstract TResultType Visit(DbEntityRefExpression expression);
+        public abstract TResultType Visit(DbExceptExpression expression);
+        public abstract TResultType Visit(DbExpression expression);
+        public abstract TResultType Visit(DbFilterExpression expression);
+        public abstract TResultType Visit(DbFunctionExpression expression);
+        public abstract TResultType Visit(DbGroupByExpression expression);
+        public abstract TResultType Visit(DbIntersectExpression expression);
+        public abstract TResultType Visit(DbIsEmptyExpression expression);
+        public abstract TResultType Visit(DbIsNullExpression expression);
+        public abstract TResultType Visit(DbIsOfExpression expression);
+        public abstract TResultType Visit(DbJoinExpression expression);
+        public virtual TResultType Visit(DbLambdaExpression expression);
+        public abstract TResultType Visit(DbLikeExpression expression);
+        public abstract TResultType Visit(DbLimitExpression expression);
+        public abstract TResultType Visit(DbNewInstanceExpression expression);
+        public abstract TResultType Visit(DbNotExpression expression);
+        public abstract TResultType Visit(DbNullExpression expression);
+        public abstract TResultType Visit(DbOfTypeExpression expression);
+        public abstract TResultType Visit(DbOrExpression expression);
+        public abstract TResultType Visit(DbParameterReferenceExpression expression);
+        public abstract TResultType Visit(DbProjectExpression expression);
+        public abstract TResultType Visit(DbPropertyExpression expression);
+        public abstract TResultType Visit(DbQuantifierExpression expression);
+        public abstract TResultType Visit(DbRefExpression expression);
+        public abstract TResultType Visit(DbRefKeyExpression expression);
+        public abstract TResultType Visit(DbRelationshipNavigationExpression expression);
+        public abstract TResultType Visit(DbScanExpression expression);
+        public abstract TResultType Visit(DbSkipExpression expression);
+        public abstract TResultType Visit(DbSortExpression expression);
+        public abstract TResultType Visit(DbTreatExpression expression);
+        public abstract TResultType Visit(DbUnionAllExpression expression);
+        public abstract TResultType Visit(DbVariableReferenceExpression expression);
+    }
+    public sealed class DbFilterExpression : DbExpression {
+        public DbExpressionBinding Input { get; }
+        public DbExpression Predicate { get; }
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public sealed class DbFunctionAggregate : DbAggregate {
+        public bool Distinct { get; }
+        public EdmFunction Function { get; }
+    }
+    public sealed class DbFunctionCommandTree : DbCommandTree {
+        public EdmFunction EdmFunction { get; }
+        public TypeUsage ResultType { get; }
+    }
+    public sealed class DbFunctionExpression : DbExpression {
+        public IList<DbExpression> Arguments { get; }
+        public EdmFunction Function { get; }
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public sealed class DbGroupAggregate : DbAggregate
+    public sealed class DbGroupByExpression : DbExpression {
+        public IList<DbAggregate> Aggregates { get; }
+        public DbGroupExpressionBinding Input { get; }
+        public IList<DbExpression> Keys { get; }
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public sealed class DbGroupExpressionBinding {
+        public DbExpression Expression { get; }
+        public DbGroupAggregate GroupAggregate { get; }
+        public DbVariableReferenceExpression GroupVariable { get; }
+        public string GroupVariableName { get; }
+        public TypeUsage GroupVariableType { get; }
+        public DbVariableReferenceExpression Variable { get; }
+        public string VariableName { get; }
+        public TypeUsage VariableType { get; }
+    }
+    public sealed class DbInsertCommandTree : DbModificationCommandTree {
+        public DbExpression Returning { get; }
+        public IList<DbModificationClause> SetClauses { get; }
+    }
+    public sealed class DbIntersectExpression : DbBinaryExpression {
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public sealed class DbIsEmptyExpression : DbUnaryExpression {
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public sealed class DbIsNullExpression : DbUnaryExpression {
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public sealed class DbIsOfExpression : DbUnaryExpression {
+        public TypeUsage OfType { get; }
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public sealed class DbJoinExpression : DbExpression {
+        public DbExpression JoinCondition { get; }
+        public DbExpressionBinding Left { get; }
+        public DbExpressionBinding Right { get; }
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public sealed class DbLambda {
+        public DbExpression Body { get; }
+        public IList<DbVariableReferenceExpression> Variables { get; }
+        public static DbLambda Create(DbExpression body, IEnumerable<DbVariableReferenceExpression> variables);
+        public static DbLambda Create(DbExpression body, params DbVariableReferenceExpression[] variables);
+        public static DbLambda Create(TypeUsage argument1Type, TypeUsage argument2Type, TypeUsage argument3Type, TypeUsage argument4Type, TypeUsage argument5Type, TypeUsage argument6Type, TypeUsage argument7Type, TypeUsage argument8Type, TypeUsage argument9Type, TypeUsage argument10Type, TypeUsage argument11Type, TypeUsage argument12Type, TypeUsage argument13Type, TypeUsage argument14Type, TypeUsage argument15Type, TypeUsage argument16Type, Func<DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression> lambdaFunction);
+        public static DbLambda Create(TypeUsage argument1Type, TypeUsage argument2Type, TypeUsage argument3Type, TypeUsage argument4Type, TypeUsage argument5Type, TypeUsage argument6Type, TypeUsage argument7Type, TypeUsage argument8Type, TypeUsage argument9Type, TypeUsage argument10Type, TypeUsage argument11Type, TypeUsage argument12Type, TypeUsage argument13Type, TypeUsage argument14Type, TypeUsage argument15Type, Func<DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression> lambdaFunction);
+        public static DbLambda Create(TypeUsage argument1Type, TypeUsage argument2Type, TypeUsage argument3Type, TypeUsage argument4Type, TypeUsage argument5Type, TypeUsage argument6Type, TypeUsage argument7Type, TypeUsage argument8Type, TypeUsage argument9Type, TypeUsage argument10Type, TypeUsage argument11Type, TypeUsage argument12Type, TypeUsage argument13Type, TypeUsage argument14Type, Func<DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression> lambdaFunction);
+        public static DbLambda Create(TypeUsage argument1Type, TypeUsage argument2Type, TypeUsage argument3Type, TypeUsage argument4Type, TypeUsage argument5Type, TypeUsage argument6Type, TypeUsage argument7Type, TypeUsage argument8Type, TypeUsage argument9Type, TypeUsage argument10Type, TypeUsage argument11Type, TypeUsage argument12Type, TypeUsage argument13Type, Func<DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression> lambdaFunction);
+        public static DbLambda Create(TypeUsage argument1Type, TypeUsage argument2Type, TypeUsage argument3Type, TypeUsage argument4Type, TypeUsage argument5Type, TypeUsage argument6Type, TypeUsage argument7Type, TypeUsage argument8Type, TypeUsage argument9Type, TypeUsage argument10Type, TypeUsage argument11Type, TypeUsage argument12Type, Func<DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression> lambdaFunction);
+        public static DbLambda Create(TypeUsage argument1Type, TypeUsage argument2Type, TypeUsage argument3Type, TypeUsage argument4Type, TypeUsage argument5Type, TypeUsage argument6Type, TypeUsage argument7Type, TypeUsage argument8Type, TypeUsage argument9Type, TypeUsage argument10Type, TypeUsage argument11Type, Func<DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression> lambdaFunction);
+        public static DbLambda Create(TypeUsage argument1Type, TypeUsage argument2Type, TypeUsage argument3Type, TypeUsage argument4Type, TypeUsage argument5Type, TypeUsage argument6Type, TypeUsage argument7Type, TypeUsage argument8Type, TypeUsage argument9Type, TypeUsage argument10Type, Func<DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression> lambdaFunction);
+        public static DbLambda Create(TypeUsage argument1Type, TypeUsage argument2Type, TypeUsage argument3Type, TypeUsage argument4Type, TypeUsage argument5Type, TypeUsage argument6Type, TypeUsage argument7Type, TypeUsage argument8Type, TypeUsage argument9Type, Func<DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression> lambdaFunction);
+        public static DbLambda Create(TypeUsage argument1Type, TypeUsage argument2Type, TypeUsage argument3Type, TypeUsage argument4Type, TypeUsage argument5Type, TypeUsage argument6Type, TypeUsage argument7Type, TypeUsage argument8Type, Func<DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression> lambdaFunction);
+        public static DbLambda Create(TypeUsage argument1Type, TypeUsage argument2Type, TypeUsage argument3Type, TypeUsage argument4Type, TypeUsage argument5Type, TypeUsage argument6Type, TypeUsage argument7Type, Func<DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression> lambdaFunction);
+        public static DbLambda Create(TypeUsage argument1Type, TypeUsage argument2Type, TypeUsage argument3Type, TypeUsage argument4Type, TypeUsage argument5Type, TypeUsage argument6Type, Func<DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression> lambdaFunction);
+        public static DbLambda Create(TypeUsage argument1Type, TypeUsage argument2Type, TypeUsage argument3Type, TypeUsage argument4Type, TypeUsage argument5Type, Func<DbExpression, DbExpression, DbExpression, DbExpression, DbExpression, DbExpression> lambdaFunction);
+        public static DbLambda Create(TypeUsage argument1Type, TypeUsage argument2Type, TypeUsage argument3Type, TypeUsage argument4Type, Func<DbExpression, DbExpression, DbExpression, DbExpression, DbExpression> lambdaFunction);
+        public static DbLambda Create(TypeUsage argument1Type, TypeUsage argument2Type, TypeUsage argument3Type, Func<DbExpression, DbExpression, DbExpression, DbExpression> lambdaFunction);
+        public static DbLambda Create(TypeUsage argument1Type, TypeUsage argument2Type, Func<DbExpression, DbExpression, DbExpression> lambdaFunction);
+        public static DbLambda Create(TypeUsage argument1Type, Func<DbExpression, DbExpression> lambdaFunction);
+    }
+    public sealed class DbLambdaExpression : DbExpression {
+        public IList<DbExpression> Arguments { get; }
+        public DbLambda Lambda { get; }
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public sealed class DbLikeExpression : DbExpression {
+        public DbExpression Argument { get; }
+        public DbExpression Escape { get; }
+        public DbExpression Pattern { get; }
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public sealed class DbLimitExpression : DbExpression {
+        public DbExpression Argument { get; }
+        public DbExpression Limit { get; }
+        public bool WithTies { get; }
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public abstract class DbModificationClause
+    public abstract class DbModificationCommandTree : DbCommandTree {
+        public DbExpressionBinding Target { get; }
+    }
+    public sealed class DbNewInstanceExpression : DbExpression {
+        public IList<DbExpression> Arguments { get; }
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public sealed class DbNotExpression : DbUnaryExpression {
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public sealed class DbNullExpression : DbExpression {
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public sealed class DbOfTypeExpression : DbUnaryExpression {
+        public TypeUsage OfType { get; }
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public sealed class DbOrExpression : DbBinaryExpression {
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public sealed class DbParameterReferenceExpression : DbExpression {
+        public string ParameterName { get; }
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public sealed class DbProjectExpression : DbExpression {
+        public DbExpressionBinding Input { get; }
+        public DbExpression Projection { get; }
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public sealed class DbPropertyExpression : DbExpression {
+        public DbExpression Instance { get; }
+        public EdmMember Property { get; }
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+        public static implicit operator KeyValuePair<string, DbExpression> (DbPropertyExpression value);
+        public KeyValuePair<string, DbExpression> ToKeyValuePair();
+    }
+    public sealed class DbQuantifierExpression : DbExpression {
+        public DbExpressionBinding Input { get; }
+        public DbExpression Predicate { get; }
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public sealed class DbQueryCommandTree : DbCommandTree {
+        public DbExpression Query { get; }
+    }
+    public sealed class DbRefExpression : DbUnaryExpression {
+        public EntitySet EntitySet { get; }
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public sealed class DbRefKeyExpression : DbUnaryExpression {
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public sealed class DbRelationshipNavigationExpression : DbExpression {
+        public RelationshipEndMember NavigateFrom { get; }
+        public RelationshipEndMember NavigateTo { get; }
+        public DbExpression NavigationSource { get; }
+        public RelationshipType Relationship { get; }
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public sealed class DbScanExpression : DbExpression {
+        public EntitySetBase Target { get; }
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public sealed class DbSetClause : DbModificationClause {
+        public DbExpression Property { get; }
+        public DbExpression Value { get; }
+    }
+    public sealed class DbSkipExpression : DbExpression {
+        public DbExpression Count { get; }
+        public DbExpressionBinding Input { get; }
+        public IList<DbSortClause> SortOrder { get; }
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public sealed class DbSortClause {
+        public bool Ascending { get; }
+        public string Collation { get; }
+        public DbExpression Expression { get; }
+    }
+    public sealed class DbSortExpression : DbExpression {
+        public DbExpressionBinding Input { get; }
+        public IList<DbSortClause> SortOrder { get; }
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public sealed class DbTreatExpression : DbUnaryExpression {
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public abstract class DbUnaryExpression : DbExpression {
+        public DbExpression Argument { get; }
+    }
+    public sealed class DbUnionAllExpression : DbBinaryExpression {
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public sealed class DbUpdateCommandTree : DbModificationCommandTree {
+        public DbExpression Predicate { get; }
+        public DbExpression Returning { get; }
+        public IList<DbModificationClause> SetClauses { get; }
+    }
+    public sealed class DbVariableReferenceExpression : DbExpression {
+        public string VariableName { get; }
+        public override void Accept(DbExpressionVisitor visitor);
+        public override TResultType Accept<TResultType>(DbExpressionVisitor<TResultType> visitor);
+    }
+    public class DefaultExpressionVisitor : DbExpressionVisitor<DbExpression> {
+        protected DefaultExpressionVisitor();
+        protected virtual void OnEnterScope(IEnumerable<DbVariableReferenceExpression> scopeVariables);
+        protected virtual void OnExitScope();
+        protected virtual void OnExpressionReplaced(DbExpression oldExpression, DbExpression newExpression);
+        protected virtual void OnVariableRebound(DbVariableReferenceExpression fromVarRef, DbVariableReferenceExpression toVarRef);
+        public override DbExpression Visit(DbAndExpression expression);
+        public override DbExpression Visit(DbApplyExpression expression);
+        public override DbExpression Visit(DbArithmeticExpression expression);
+        public override DbExpression Visit(DbCaseExpression expression);
+        public override DbExpression Visit(DbCastExpression expression);
+        public override DbExpression Visit(DbComparisonExpression expression);
+        public override DbExpression Visit(DbConstantExpression expression);
+        public override DbExpression Visit(DbCrossJoinExpression expression);
+        public override DbExpression Visit(DbDerefExpression expression);
+        public override DbExpression Visit(DbDistinctExpression expression);
+        public override DbExpression Visit(DbElementExpression expression);
+        public override DbExpression Visit(DbEntityRefExpression expression);
+        public override DbExpression Visit(DbExceptExpression expression);
+        public override DbExpression Visit(DbExpression expression);
+        public override DbExpression Visit(DbFilterExpression expression);
+        public override DbExpression Visit(DbFunctionExpression expression);
+        public override DbExpression Visit(DbGroupByExpression expression);
+        public override DbExpression Visit(DbIntersectExpression expression);
+        public override DbExpression Visit(DbIsEmptyExpression expression);
+        public override DbExpression Visit(DbIsNullExpression expression);
+        public override DbExpression Visit(DbIsOfExpression expression);
+        public override DbExpression Visit(DbJoinExpression expression);
+        public override DbExpression Visit(DbLambdaExpression expression);
+        public override DbExpression Visit(DbLikeExpression expression);
+        public override DbExpression Visit(DbLimitExpression expression);
+        public override DbExpression Visit(DbNewInstanceExpression expression);
+        public override DbExpression Visit(DbNotExpression expression);
+        public override DbExpression Visit(DbNullExpression expression);
+        public override DbExpression Visit(DbOfTypeExpression expression);
+        public override DbExpression Visit(DbOrExpression expression);
+        public override DbExpression Visit(DbParameterReferenceExpression expression);
+        public override DbExpression Visit(DbProjectExpression expression);
+        public override DbExpression Visit(DbPropertyExpression expression);
+        public override DbExpression Visit(DbQuantifierExpression expression);
+        public override DbExpression Visit(DbRefExpression expression);
+        public override DbExpression Visit(DbRefKeyExpression expression);
+        public override DbExpression Visit(DbRelationshipNavigationExpression expression);
+        public override DbExpression Visit(DbScanExpression expression);
+        public override DbExpression Visit(DbSkipExpression expression);
+        public override DbExpression Visit(DbSortExpression expression);
+        public override DbExpression Visit(DbTreatExpression expression);
+        public override DbExpression Visit(DbUnionAllExpression expression);
+        public override DbExpression Visit(DbVariableReferenceExpression expression);
+        protected virtual DbAggregate VisitAggregate(DbAggregate aggregate);
+        protected virtual EntitySetBase VisitEntitySet(EntitySetBase entitySet);
+        protected virtual DbExpression VisitExpression(DbExpression expression);
+        protected virtual DbExpressionBinding VisitExpressionBinding(DbExpressionBinding binding);
+        protected virtual IList<DbExpressionBinding> VisitExpressionBindingList(IList<DbExpressionBinding> list);
+        protected virtual IList<DbExpression> VisitExpressionList(IList<DbExpression> list);
+        protected virtual EdmFunction VisitFunction(EdmFunction functionMetadata);
+        protected virtual DbFunctionAggregate VisitFunctionAggregate(DbFunctionAggregate aggregate);
+        protected virtual DbGroupAggregate VisitGroupAggregate(DbGroupAggregate aggregate);
+        protected virtual DbGroupExpressionBinding VisitGroupExpressionBinding(DbGroupExpressionBinding binding);
+        protected virtual DbLambda VisitLambda(DbLambda lambda);
+        protected virtual DbSortClause VisitSortClause(DbSortClause clause);
+        protected virtual IList<DbSortClause> VisitSortOrder(IList<DbSortClause> sortOrder);
+        protected virtual EdmType VisitType(EdmType type);
+        protected virtual TypeUsage VisitTypeUsage(TypeUsage type);
+    }
+}
```

