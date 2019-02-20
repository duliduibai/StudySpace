using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairCut.SubForms
{
    public partial class controlBill : UserControl
    {
        public controlBill()
        {
            InitializeComponent();
        }

        private void controlBill_SizeChanged(object sender, EventArgs e)
        {
            panel2.Left = (this.Width - panel2.Width) / 2;
            panel2.Top = 20;
            panel1.Left = (panel2.Width - panel1.Width) / 2;
            panel1.Top = (panel2.Height - panel1.Height) / 2; ;
        }
    }
}
