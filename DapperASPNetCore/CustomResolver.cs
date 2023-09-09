using Dapper;
using System.Reflection;
using System;

namespace DapperASPNetCore
{
    public class CustomResolver : SimpleCRUD.ITableNameResolver, SimpleCRUD.IColumnNameResolver
    {
        public string ResolveTableName(Type type)
        {
            return string.Format("tbl_{0}", type.Name);
        }

        public string ResolveColumnName(PropertyInfo propertyInfo)
        {
            return string.Format("{0}_{1}", propertyInfo.DeclaringType.Name, propertyInfo.Name);
        }
    }
}
