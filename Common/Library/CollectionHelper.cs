using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace Common.Library
{
    public static class CollectionHelper
    {
        //private CollectionHelper()
        //{
        //}

        // this is the method I have been using
        public static DataTable ConvertTo<T>(ICollection<T> list)
        {
            DataTable table = CreateTable<T>();
            Type entityType = typeof(T);
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entityType);

            foreach (T item in list)
            {
                DataRow row = table.NewRow();

                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }

                table.Rows.Add(row);
            }

            return table;
        }

        public static DataTable CreateTable<T>()
        {
            Type entityType = typeof(T);
            DataTable table = new DataTable(entityType.Name);
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entityType);

            foreach (PropertyDescriptor prop in properties)
            {
               
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(
                                    prop.PropertyType) ?? prop.PropertyType);
            }

            return table;
        }
    }
}
