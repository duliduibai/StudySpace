using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BAL;

namespace HairCut.SubForms
{
    public partial class controlBill : UserControl
    {
        AccountBAL accountBAL = new AccountBAL();
        private bool isEdit;
        public bool IsEdit
        {
            get { return isEdit; }
            set
            {
                isEdit = value;
            }
        }
        private Account accountSource = new Account();
        private DataTable tblAccount = new DataTable();
        public controlBill()
        {
            InitializeComponent();
        }
        public controlBill(Account account)
        {
            InitializeComponent();
            accountSource = account;
            Init();
        }
        public controlBill(DataTable tblAccount)
        {
            InitializeComponent();
            this.tblAccount = tblAccount;
            Init();
        }


        private void Init()
        {
            accountBindingSource.DataSource = tblAccount;
        }

        private void controlBill_SizeChanged(object sender, EventArgs e)
        {
            panel2.Left = (this.Width - panel2.Width) / 2;
            panel2.Top = 20;
            panel1.Left = (panel2.Width - panel1.Width) / 2;
            panel1.Top = (panel2.Height - panel1.Height) / 2; ;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            accountBAL.Save(tblAccount);
        }
        
        private void cboxAliPay_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxAliPay.Checked)
            {
                rbtnVIP.Checked = false;
                rbtnNonVIP.Checked = true;
                cboxWechat.Checked = false;
            }
        }

        private void cboxWechat_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxWechat.Checked)
            {
                rbtnVIP.Checked = false;
                rbtnNonVIP.Checked = true;
                cboxAliPay.Checked = false;
            }
        }

        private void txtVIPCard_KeyUp(object sender, KeyEventArgs e)
        {
            rbtnNonVIP.Checked = false;
            rbtnVIP.Checked = true;
        }

        private void rbtnVIP_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnVIP.Checked)
            {
                cboxAliPay.Checked = false;
                cboxWechat.Checked = false;
            }
        }

        private void rbtnNonVIP_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNonVIP.Checked)
            {
                txtVIPCard.Text = "";
            }
        }
    }
}
