using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAL.Interface;
using DAL;
using DB;

namespace BAL
{
    public class StaffBAL : IStaff
    {
        const String SELECT_QUERY = @"SELECT * FROM Staff WHERE TypeName = @TypeName";

        public List<Staff> GetAllStaffList(string typeName)
        {
            List<Staff> lst = new List<Staff>();
            AccessDB accessDB = new AccessDB();
            OleDbParameter[] oleDbParameters = new OleDbParameter[]
            {
                new OleDbParameter("@TypeName", typeName)
            };
            DataTable dt = accessDB.Get(SELECT_QUERY, oleDbParameters);
            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lst.Add(Util<Staff>.TransDataRowToAccount(dt.Rows[i]));
                }
            }
            return lst;
        }

        public DataTable GetAllStaff()
        {
            AccessDB accessDB = new AccessDB();
            DataTable dt = accessDB.Get(SELECT_QUERY, null);
            return dt;
        }

        public bool SaveStaff(DataTable dataTable)
        {
            throw new NotImplementedException();
        }
    }
}
