// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Data.Common
{
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
    public static partial class DbDataReaderExtensions
    {
        public static bool CanGetColumnSchema(this System.Data.Common.DbDataReader reader) { throw null; }
        public static System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Common.DbColumn> GetColumnSchema(this System.Data.Common.DbDataReader reader) { throw null; }
    }
    public partial interface IDbColumnSchemaGenerator
    {
        System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Common.DbColumn> GetColumnSchema();
    }
}
