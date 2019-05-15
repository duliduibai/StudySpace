using BAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairCut
{
    public partial class frmFastCharge : Form
    {
        VIPBAL bal = new VIPBAL();
        string VIPNo = "";
        public frmFastCharge(string VIPNo)
        {
            this.VIPNo = VIPNo;
            InitializeComponent();
            textBox1.Text = VIPNo;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value <= 0)
            {
                MessageBox.Show("请输入大于0的数字");
                return;
            }
            DataTable dt = bal.GetVIPByNo(VIPNo);
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("不存在该VIP账号");
                return;
            }
            decimal ori = Convert.ToDecimal(dt.Rows[0]["Balance"]);
            ori += numericUpDown1.Value;
            dt.Rows[0]["Balance"] = ori;
            if(bal.SaveVIP(dt))
                this.DialogResult = DialogResult.OK;
            //Thread.Sleep(500);
        }
    }
}
