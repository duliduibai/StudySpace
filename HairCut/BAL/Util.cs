using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public static class Util<T>
    {
        public static T TransDataRowToAccount(DataRow r)
        {
            T t = default(T);
            t = Activator.CreateInstance<T>();
            PropertyInfo[] ps = t.GetType().GetProperties();
            foreach (var property in ps)
            {
                if (r.Table.Columns.Contains(property.Name))
                {
                    object v;
                    v = r[property.Name];
                    if (v.GetType() == typeof(System.DBNull))
                        v = null;
                    if (v != null)
                    {
                        if (property.PropertyType == typeof(DateTime))
                        {
                            v = Convert.ToDateTime(r[property.Name]);
                        }
                        else if (property.PropertyType == typeof(decimal))
                        {
                            v = Convert.ToDecimal(r[property.Name]);
                        }
                        else if (property.PropertyType == typeof(int))
                        {
                            v = Convert.ToInt32(r[property.Name]);
                        }
                        else if (property.PropertyType == typeof(bool))
                        {
                            v = Convert.ToBoolean(r[property.Name]);
                        }
                    }
                    property.SetValue(t, v, null);
                }
            }
            return t;
        }
    }
}
