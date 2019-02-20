using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class AccessDB
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        private void Connect()
        {
            conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\bchen7\Desktop\HairCut.mdb");
            cmd = conn.CreateCommand();
            conn.Open();
        }

        private void Close()
        {
            cmd.Dispose();
            conn.Close();
        }

        public DataTable GetAccount(string sql = "Select * FROM Account")
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                cmd.CommandText = sql;
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        dt.Columns.Add(reader.GetName(i));
                    }
                    dt.Rows.Clear();
                }
                while (reader.Read())
                {
                    DataRow row = dt.NewRow();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row[i] = reader[i];
                    }
                    dt.Rows.Add(row);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Close();
            }
            return dt;
        }
    }
}
