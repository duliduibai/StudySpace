using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Interface
{
    public interface IAccountBAL
    {
        List<Account> GetAllAccounts();
        DataTable GetAllAccountsEx();
        void GetSingleAccout(string accountNo);
        void SaveAccount(Account account);
    }
}
