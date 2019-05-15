using DAL;
using BAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DB;
using System.Data.OleDb;

namespace BAL
{
    public class AccountBAL : IAccountBAL
    {
        AccessDB accessDB = new AccessDB();
        const String SQL_SELECT = @"SELECT AccountNo, CreateTime, DesignerName, DesignerNo, AssistDesignName
                                , AssistDesignNo, TechnicianName, TechnicianNo, WashBlow, Perm, WashCutBlow, Dye
                                , InhaleCutBlow, Straight, ChildCut, TransHair, Style, HairCare, Other, PayWay
                                , CashTotal, IsVIP, VIPNo, VIPBalance, BarberNo, BarberName
                                FROM Account ORDER BY AccountNo";
        const String SQL_SELECT_EX = @"SELECT AccountNo, CreateTime, DesignerName, DesignerNo, AssistDesignName
                                , AssistDesignNo, TechnicianName, TechnicianNo, WashBlow, Perm, WashCutBlow, Dye
                                , InhaleCutBlow, Straight, ChildCut, TransHair, Style, HairCare, Other, PayWay
                                , CashTotal, IsVIP, VIPNo, VIPBalance, BarberNo, BarberName
                                FROM Account WHERE AccountNo = @AccountNo";
        public Account GetAccountByNo(string accountNo)
        {
            OleDbParameter oleDbParameter = new OleDbParameter();
            DataTable dt = accessDB.Get(SQL_SELECT_EX, GenerateParameters(accountNo));
            if (dt != null && dt.Rows.Count > 0)
            {
                return Util<Account>.TransDataRowToAccount(dt.Rows[0]);
            }
            return null;
        }

        private OleDbParameter[] GenerateParameters(string accountNo)
        {
            return new OleDbParameter[]
            {
                new OleDbParameter("@AccountNo", accountNo)
            };
        }
        public DataTable TableGetAccountByNo(string accountNo)
        {
            AccessDB accessDB = new AccessDB();
            DataTable dt = accessDB.Get(SQL_SELECT_EX, GenerateParameters(accountNo));
            if (String.IsNullOrEmpty(accountNo))
            {
                object obj = accessDB.GetExcuteScalar("Select Max(AccountNo) From Account");
                DataRow dr = dt.NewRow();
                int no = Convert.ToInt32(obj);
                no++;
                dr["AccountNo"] = no.ToString();
                dt.Rows.Add(dr);
            }
            return dt;
        }

        public List<Account> GetAllAccounts()
        {
            return new List<Account>()
            {
                new Account(){AccountNo = "1", DesignerName = "name1", DesignerNo = "1"},
                new Account(){AccountNo = "5", DesignerName = "name2", DesignerNo = "2"},
                new Account(){AccountNo = "4", DesignerName = "name1", DesignerNo = "1"},
                new Account(){AccountNo = "2", DesignerName = "name2", DesignerNo = "2"},
                new Account(){AccountNo = "3", DesignerName = "name3", DesignerNo = "3"}
            };
        }

        public DataTable GetAllAccountsEx()
        {
            return accessDB.Get(SQL_SELECT, null);
        }

        public void GetSingleAccout(string accountNo)
        {
            throw new NotImplementedException();
        }

        public void SaveAccount(Account account)
        {
            throw new NotImplementedException();
        }

        public bool Save(DataTable dt)
        {
            return accessDB.Save(dt, SQL_SELECT);
        }
    }
}

