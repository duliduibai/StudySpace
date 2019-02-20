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
            conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source = E:\StudySpace\HairCut\DataBase\HairCut.mdb");
            cmd = conn.CreateCommand();
        }

        private void Close()
        {
            cmd.Dispose();
            conn.Close();
        }

        public bool Save(DataTable dt, string selectCommond)
        {
            try
            {
                Connect();
                OleDbDataAdapter adapter = new OleDbDataAdapter(new OleDbCommand(selectCommond, conn));
                OleDbCommandBuilder cb = new OleDbCommandBuilder(adapter);
                conn.Open();
                //DataTable temp = new DataTable();
                //adapter.Fill(temp);

                //temp = dt;
                //temp.AcceptChanges();
                dt.AcceptChanges();
                cb.GetUpdateCommand();
                adapter.Update(dt);
            }
            catch (Exception ex)
            {
                throw;
            }
            return true;
        }

        public DataTable Get(string sql = "Select * FROM Account")
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                cmd.CommandText = sql;
                conn.Open();
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
