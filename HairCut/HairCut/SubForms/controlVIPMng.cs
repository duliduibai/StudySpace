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

namespace HairCut.SubForms
{
    public partial class controlVIPMng : UserControl
    {
        VIPBAL vIPBAL = new VIPBAL();
        DataTable dt = new DataTable();
        public controlVIPMng()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            dt = vIPBAL.GetAllVIP();
            vIPMngBindingSource.CurrentChanged += CurrentChanged;
            vIPMngBindingSource.DataSource = dt;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            vIPMngBindingSource.EndEdit();
            if (vIPBAL.SaveVIP(dt))
            {
                MessageBox.Show("保存成功");
            }
        }

        private void CurrentChanged(object sender, EventArgs e)
        {
            dt.RejectChanges();
            if (vIPMngBindingSource.Current != null)
            {
                DataRowView dr = (DataRowView)vIPMngBindingSource.Current;
                if (Convert.ToInt32(dr["Gender"]) == 1)
                {
                    radioButton1.Checked = true;
                }
                else if (Convert.ToInt32(dr["Gender"]) == 2)
                {
                    radioButton2.Checked = true;
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (vIPMngBindingSource.Current != null)
            {
                DataRowView dr = (DataRowView)vIPMngBindingSource.Current;
                if (radioButton1.Checked)
                {
                    dr["Gender"] = 1;
                }
                else if (radioButton2.Checked)
                {
                    dr["Gender"] = 2;
                }
            }
        }
    }
}
