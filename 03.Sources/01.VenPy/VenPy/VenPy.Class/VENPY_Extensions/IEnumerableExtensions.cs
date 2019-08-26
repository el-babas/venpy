using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Reflection;

namespace VenPy.Class
{
    public static class IEnumerableExtensions
    {
        #region [ METHODS ]

        public static DataTable ToDataTable<T>(this IEnumerable<T> enumerableList)
        {
            if (enumerableList != null)
            {
                var dataTable = new DataTable(typeof(T).Name);
                IEnumerable<PropertyInfo> propertyInformation = typeof(T).GetProperties();
                foreach (var property in propertyInformation)
                {
                    Type columnType = property.PropertyType;
                    Boolean allowDBNull = true;
                    if (property.PropertyType.IsGenericType && property.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                    {
                        columnType = property.PropertyType.GetGenericArguments()[0];
                        allowDBNull = true;
                    }
                    DataColumn dataColumn = new DataColumn(property.Name, columnType);
                    dataColumn.AllowDBNull = allowDBNull;
                    dataTable.Columns.Add(dataColumn);
                }
                foreach (var enumerable in enumerableList)
                {
                    var values = new object[propertyInformation.Count()];
                    for (var i = 0; i < propertyInformation.Count(); i++)
                    {
                        values[i] = propertyInformation.ElementAt(i).GetValue(enumerable, null);
                    }
                    dataTable.Rows.Add(values);
                }
                return dataTable;
            }
            return null;
        }
        public static DataTable ToTableParameter<T>(this IEnumerable<T> enumerableList)
        {
            if (enumerableList != null)
            {
                var dataTable = new DataTable(typeof(T).Name);
                IEnumerable<PropertyInfo> propertyInformation = typeof(T).GetProperties().Where(prop => Attribute.IsDefined(prop, typeof(TableParameterAttribute)) && (prop.GetCustomAttributes(typeof(TableParameterAttribute), false).FirstOrDefault() as TableParameterAttribute).Export).OrderBy(prop => (prop.GetCustomAttributes(typeof(TableParameterAttribute), false).FirstOrDefault() as TableParameterAttribute).Order);
                foreach (var property in propertyInformation)
                {
                    Type columnType = property.PropertyType;
                    bool allowDBNull = true;
                    if (property.PropertyType.IsGenericType && property.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                    {
                        columnType = property.PropertyType.GetGenericArguments()[0];
                        allowDBNull = true;
                    }
                    DataColumn dataColumn = new DataColumn(property.Name, columnType);
                    dataColumn.AllowDBNull = allowDBNull;
                    dataTable.Columns.Add(dataColumn);
                }
                foreach (var enumerable in enumerableList)
                {
                    var values = new object[propertyInformation.Count()];
                    for (var i = 0; i < propertyInformation.Count(); i++)
                    {
                        values[i] = propertyInformation.ElementAt(i).GetValue(enumerable, null);
                    }
                    dataTable.Rows.Add(values);
                }
                return dataTable;
            }
            return null;
        }

        #endregion
    }
}
