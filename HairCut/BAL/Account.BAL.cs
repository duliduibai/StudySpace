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
            return accessDB.GetAccount();
        }

        public void GetSingleAccout(string accountNo)
        {
            throw new NotImplementedException();
        }

        public void SaveAccount(Account account)
        {
            throw new NotImplementedException();
        }
    }
}
