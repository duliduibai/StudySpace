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
        OleDbDataAdapter adapter;
        OleDbCommandBuilder cb;
        private void Connect()
        {
            //conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source = D:\我的文档\github\StudySpace\HairCut\DataBase\HairCut.mdb");
            conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source = E:\StudySpace\HairCut\DataBase\HairCut.mdb");
            cmd = conn.CreateCommand();
        }

        private void Close()
        {
            cmd.Dispose();
            conn.Close();
        }

        public bool Save(DataTable dt, string selectSql)
        {
            try
            {
                Connect();
                cmd = new OleDbCommand(selectSql, conn);
                adapter = new OleDbDataAdapter(cmd);
                cb = new OleDbCommandBuilder(adapter);
                conn.Open();
                adapter.Update(dt);
            }
            catch (Exception ex)
            {
                throw;
            }
            return true;
        }

        public DataTable Get(string selectSql, OleDbParameter[] para)
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                cmd = new OleDbCommand(selectSql, conn);
                adapter = new OleDbDataAdapter(cmd);
                if (para != null)
                {
                    adapter.SelectCommand.Parameters.AddRange(para);
                }
                cb = new OleDbCommandBuilder(adapter);
                
                conn.Open();
                adapter.Fill(dt);
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

        public object GetExcuteScalar(string selectSql)
        {
            object temp;
            try
            {
                Connect();
                cmd = new OleDbCommand(selectSql, conn);
                conn.Open();
                temp = cmd.ExecuteScalar();
            }
            catch (Exception)
            {
                throw;
            }
            return temp;
        }
    }
}
