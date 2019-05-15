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
using HairCut.CommonControls;

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

        private void dataGridView1_Click(object sender, EventArgs e)
        {
        }

        public void OpenEx()
        {
            DataGridViewSelectedRowCollection rows = dataGridView1.SelectedRows;
            if (rows.Count < 1)
            {
                MessageBox.Show("未选中任何一个Bill");
                return;
            }
            if (rows.Count > 1)
            {
                MessageBox.Show("只能打开一个Bill");
                return;
            }
            Open(rows[0].Cells[0].Value.ToString());
        }
        

        private void Open(string AccountNo)
        {
            frmEditBill frm = new frmEditBill(AccountNo);
            frm.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow dr = dataGridView1.Rows[e.RowIndex];
            //Open(dr.Cells["AccountNo"].Value.ToString());
            Open(dr.Cells[0].Value.ToString());
        }
    }
}
