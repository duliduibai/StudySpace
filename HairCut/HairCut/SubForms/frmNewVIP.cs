using BAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairCut.SubForms
{
    public partial class frmNewVIP : Form
    {
        DataTable dt = new DataTable();
        VIPBAL vIPBAL = new VIPBAL();
        public frmNewVIP()
        {
            InitializeComponent();
            dt = vIPBAL.GetVIPByNo("");
            DataRow dr = dt.NewRow();
            dt.Rows.Add(dr);
            vIPMngBindingSource.DataSource = dt;
        }

        private void frmNewVIP_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“hairCutDataSet1.VIPMng”中。您可以根据需要移动或删除它。
            this.vIPMngTableAdapter.Fill(this.hairCutDataSet1.VIPMng);

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            vIPMngBindingSource.EndEdit();
            if (dt.Rows[0]["VIPNo"] != DBNull.Value)
            {
                if (radioButton1.Checked)
                {
                    dt.Rows[0]["Gender"] = 1;
                }
                else if (radioButton2.Checked)
                {
                    dt.Rows[0]["Gender"] = 2;
                }
                else
                {
                    dt.Rows[0]["Gender"] = 0;
                }
                if (vIPBAL.SaveVIP(dt))
                {
                    MessageBox.Show("添加成功！");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("添加失败，请检查VIP编号是否已经存在！");
                    this.DialogResult = DialogResult.No;
                }
            }
            else
                MessageBox.Show("新增失败，请输入VIP编号");
        }
    }
}
