using DAL;
using BAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DB;

namespace BAL
{
    public class AccountBAL : IAccountBAL
    {
        public Account GetAccountByNo(string accountNo)
        {
            AccessDB accessDB = new AccessDB();
            DataTable dt = accessDB.Get(String.Format("SELECT * FROM Account WHERE AccountNo = '{0}'", accountNo));
            if (dt != null && dt.Rows.Count > 0)
            {
                return Util<Account>.TransDataRowToAccount(dt.Rows[0]);
            }
            return null;
        }
        public DataTable TableGetAccountByNo(string accountNo)
        {
            AccessDB accessDB = new AccessDB();
            DataTable dt = accessDB.Get(String.Format("SELECT * FROM Account WHERE AccountNo = '{0}'", accountNo));
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
            AccessDB accessDB = new AccessDB();
            return accessDB.Get();
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
            AccessDB accessDB = new AccessDB();
            string selectCommond = @"SELECT AccountNo, CreateTime, DesignerName, DesignerNo, AssistDesignName
                                , AssistDesignNo, TechnicianName, TechnicianNo, WashBlow, Perm, WashCutBlow, Dye
                                , InhaleCutBlow, Straight, ChildCut, TransHair, Style, HairCare, Other, PayWay
                                , CashTotal, IsVIP, VIPNo, VIPBalance
                                FROM Account";
            return accessDB.Save(dt, selectCommond);
        }
    }
}

