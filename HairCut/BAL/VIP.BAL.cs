using BAL.Interface;
using DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class VIPBAL : IVIPBAL
    {
        const String SQL_SELECT_EX = @"SELECT * FROM VIPMng WHERE VIPNo = @VIPNo";
        const String SQL_SELECT = @"SELECT * FROM VIPMng";
        AccessDB accessDB = new AccessDB();
        public DataTable GetAllVIP()
        {
            return accessDB.Get(SQL_SELECT, null);
        }

        public DataTable GetVIPByNo(string VIPNo)
        {
            DataTable tableVIP = accessDB.Get(SQL_SELECT_EX, new OleDbParameter[] {
                    new OleDbParameter("@VIPNo", VIPNo)
                });
            return tableVIP;
        }

        public bool SaveVIP(DataTable dataTable)
        {
            return accessDB.Save(dataTable, SQL_SELECT);
        }
    }
}
