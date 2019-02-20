using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using DAL;

namespace HairCut.SubForms
{
    public partial class controlCashInList : UserControl
    {
        AccountBAL accountBAL;
        List<Account> lstAccount;
        DataTable tblAccount;
        public controlCashInList()
        {
            InitializeComponent();
        }
        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void controlCashIn_Load(object sender, EventArgs e)
        {
            accountBAL = new AccountBAL();
            lstAccount = accountBAL.GetAllAccounts();
            tblAccount = accountBAL.GetAllAccountsEx();
            BindData();
        }

        private void BindData()
        {
            this.accountBindingSource.DataSource = tblAccount;
        }
    }
}
