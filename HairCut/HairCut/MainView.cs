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
    public enum LastSelectContol
    {
        NONE = -1,
        Bill=0,
        CASHINLIST,
        VIP,
        DESIGNER,
        REPORT
    };
    public partial class MainView : Form
    {
        LastSelectContol SELECTED_CONTROL = LastSelectContol.NONE;
        controlBill subCtlBill;
        controlCashInList subCtlCashInList;
        controlVIPMng subCtlVIP;
        controlDesigner subCtlDesigner;
        controlReport subCtlReport;
        public MainView()
        {
            InitializeComponent();
            Bill_Click(null, null);
        }
        private void LoadControl(Control ctl)
        {
            panelContainer.Controls.Clear();
            ctl.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(ctl);
        }

        private void Bill_Click(object sender, EventArgs e)
        {
            if (SELECTED_CONTROL.Equals(LastSelectContol.Bill))
            {
                return;
            }
            subCtlBill = new controlBill();
            LoadControl(subCtlBill);
            SELECTED_CONTROL = LastSelectContol.Bill;
        }

        private void CashInList_Click(object sender, EventArgs e)
        {
            if (SELECTED_CONTROL.Equals(LastSelectContol.CASHINLIST))
            {
                return;
            }
            subCtlCashInList = new controlCashInList();
            LoadControl(subCtlCashInList);
            SELECTED_CONTROL = LastSelectContol.CASHINLIST;
        }

        private void VIPMng_Click(object sender, EventArgs e)
        {
            if (SELECTED_CONTROL.Equals(LastSelectContol.VIP))
            {
                return;
            }
            subCtlVIP = new controlVIPMng();
            LoadControl(subCtlVIP);
            SELECTED_CONTROL = LastSelectContol.VIP;
        }

        private void RptView_Click(object sender, EventArgs e)
        {
            if (SELECTED_CONTROL.Equals(LastSelectContol.REPORT))
            {
                return;
            }
            subCtlReport = new controlReport();
            LoadControl(subCtlReport);
            SELECTED_CONTROL = LastSelectContol.REPORT;
        }

        private void DesignerMng_Click(object sender, EventArgs e)
        {
            if (SELECTED_CONTROL.Equals(LastSelectContol.DESIGNER))
            {
                return;
            }
            subCtlDesigner = new controlDesigner();
            LoadControl(subCtlDesigner);
            SELECTED_CONTROL = LastSelectContol.DESIGNER;
        }

    }
}
