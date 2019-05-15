using BAL;
using DAL;
using HairCut.SubForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairCut
{
    public partial class frmEditBill : Form
    {
        private string accountNo;
        private AccountBAL accountBAL;
        controlBill ctlBill;
        Account account;
        public frmEditBill(string AccountNo)
        {
            accountBAL = new AccountBAL();
            accountNo = AccountNo;
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            //account = accountBAL.GetAccountByNo(accountNo);
            //ctlBill = new controlBill(account);
            DataTable dt = accountBAL.TableGetAccountByNo(accountNo);
            ctlBill = new controlBill(dt);
            ctlBill.Dock = DockStyle.Fill;
            panel1.Controls.Add(ctlBill);
        }
    }
}
