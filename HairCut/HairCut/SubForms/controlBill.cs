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
        decimal originalCashTotal = 0;
        AccountBAL accountBAL = new AccountBAL();
        StaffBAL staffBAL = new StaffBAL();
        private Account accountSource = new Account();
        private DataTable tblAccount = new DataTable();
        private DataTable tblDesigner = new DataTable();

        public controlBill()
        {
            InitializeComponent();
            InsertNewAccount();
            Init();
        }

        private void InsertNewAccount()
        {
            tblAccount = accountBAL.TableGetAccountByNo("");
            accountBindingSource.DataSource = tblAccount;
        }

        public controlBill(DataTable tblAccount)
        {
            InitializeComponent();
            this.tblAccount = tblAccount;
            accountBindingSource.DataSource = tblAccount;
            Init();
        }

        private void Init()
        {
            originalCashTotal = Convert.ToDecimal(tblAccount.Rows[0]["CashTotal"] == DBNull.Value ? 0 : tblAccount.Rows[0]["CashTotal"]);
            combDesign.DataSource = staffBAL.GetAllStaffList("设计师");
            combAssist.DataSource = staffBAL.GetAllStaffList("助理");
            combTech.DataSource = staffBAL.GetAllStaffList("技师");
            combBarber.DataSource = staffBAL.GetAllStaffList("理发师");
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
            InsertNewAccount();
            Init();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ChangeStaffNo();
            ChangeRadioButton();
            if (tblAccount.Rows[0]["CreateTime"] == DBNull.Value)
            {
                tblAccount.Rows[0]["CreateTime"] = DateTime.Now;
            }
            ///就是因为这个EndEdit(),让我卡在"不能保存修改"这个地方半个下午.
            accountBindingSource.EndEdit();
            staffBindingSource.EndEdit();
            if(Save())
                MessageBox.Show("保存成功");
        }

        private void ChangeRadioButton()
        {
            tblAccount.Rows[0]["IsVIP"] = rbtnVIP.Checked;
            if (cboxAliPay.Checked)
            {
                tblAccount.Rows[0]["PayWay"] = 1;
            }
            else if (cboxWechat.Checked)
            {
                tblAccount.Rows[0]["PayWay"] = 2;
            }
        }

        private void ChangeStaffNo()
        {
            object value = combDesign.SelectedValue;
            if (value != null)
            {
                tblAccount.Rows[0]["DesignerNo"] = Convert.ToInt32(value);
            }
            value = combAssist.SelectedValue;
            if (value != null)
            {
                tblAccount.Rows[0]["AssistDesignNo"] = Convert.ToInt32(value);
            }
            value = combTech.SelectedValue;
            if (value != null)
            {
                tblAccount.Rows[0]["TechnicianNo"] = Convert.ToInt32(value);
            }
            value = combBarber.SelectedValue;
            if (value != null)
            {
                tblAccount.Rows[0]["BarberNo"] = Convert.ToInt32(value);
            }
        }

        private bool Save()
        {
            ///TODO: 首先判断是不是VIP，看是否余额充足，如果不够则弹出充值框
            bool isVIP = false;
            isVIP = Convert.ToBoolean(tblAccount.Rows[0]["IsVIP"]);
            if (isVIP)
            {
                decimal sub;
                string VIPNo = Convert.ToString(tblAccount.Rows[0]["VIPNo"]);
                DataTable tableVIP = new VIPBAL().GetVIPByNo(VIPNo);
                if (tableVIP.Rows.Count <= 0)
                {
                    MessageBox.Show("未找到该VIP账号，请检查输入");
                    return false;
                }
                sub = Convert.ToDecimal(tableVIP.Rows[0]["Balance"]) - (Convert.ToDecimal(tblAccount.Rows[0]["CashTotal"]) - originalCashTotal);
                if (sub < 0)
                {
                    if (MessageBox.Show("会员余额不足，立即充值？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        frmFastCharge frmFastCharge = new frmFastCharge(VIPNo);
                        if (frmFastCharge.ShowDialog() == DialogResult.OK)
                        {
                            MessageBox.Show("充值成功，请重新保存");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("保存失败，请先充值;或以非会员方式支付。");
                        return false;
                    }
                }
                else
                {
                    tableVIP.Rows[0]["Balance"] = sub;
                    new VIPBAL().SaveVIP(tableVIP);
                }
            }
            accountBAL.Save(tblAccount);
            return true;
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
        private void CalculateTotal()
        {
            totalCash.Value = 0
                    + numericUpDown1.Value
                    + numericUpDown2.Value
                    + numericUpDown3.Value
                    + numericUpDown4.Value
                    + numericUpDown5.Value
                    + numericUpDown6.Value
                    + numericUpDown7.Value
                    + numericUpDown8.Value
                    + numericUpDown9.Value
                    + numericUpDown10.Value
                    + numericUpDown11.Value
                    + numericUpDown12.Value;
        }

        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }
    }
}
