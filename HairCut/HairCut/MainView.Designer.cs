namespace HairCut
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Bill = new System.Windows.Forms.ToolStripMenuItem();
            this.CashIn = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenBill = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteBill = new System.Windows.Forms.ToolStripMenuItem();
            this.VIPMng = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewVIP = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RptView = new System.Windows.Forms.ToolStripMenuItem();
            this.DesignerMng = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Bill,
            this.CashIn,
            this.VIPMng,
            this.RptView,
            this.DesignerMng});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Bill
            // 
            this.Bill.Name = "Bill";
            this.Bill.Size = new System.Drawing.Size(44, 21);
            this.Bill.Text = "收银";
            this.Bill.Click += new System.EventHandler(this.Bill_Click);
            // 
            // CashIn
            // 
            this.CashIn.CheckOnClick = true;
            this.CashIn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpenBill,
            this.btnDeleteBill});
            this.CashIn.Name = "CashIn";
            this.CashIn.Size = new System.Drawing.Size(68, 21);
            this.CashIn.Text = "收银列表";
            this.CashIn.Click += new System.EventHandler(this.CashInList_Click);
            // 
            // btnOpenBill
            // 
            this.btnOpenBill.Name = "btnOpenBill";
            this.btnOpenBill.Size = new System.Drawing.Size(100, 22);
            this.btnOpenBill.Text = "打开";
            this.btnOpenBill.Click += new System.EventHandler(this.btnOpenBill_Click);
            // 
            // btnDeleteBill
            // 
            this.btnDeleteBill.Name = "btnDeleteBill";
            this.btnDeleteBill.Size = new System.Drawing.Size(100, 22);
            this.btnDeleteBill.Text = "删除";
            this.btnDeleteBill.Click += new System.EventHandler(this.btnDeleteBill_Click);
            // 
            // VIPMng
            // 
            this.VIPMng.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewVIP,
            this.修改ToolStripMenuItem,
            this.删除ToolStripMenuItem});
            this.VIPMng.Name = "VIPMng";
            this.VIPMng.Size = new System.Drawing.Size(68, 21);
            this.VIPMng.Text = "会员管理";
            this.VIPMng.Click += new System.EventHandler(this.VIPMng_Click);
            // 
            // btnNewVIP
            // 
            this.btnNewVIP.Name = "btnNewVIP";
            this.btnNewVIP.Size = new System.Drawing.Size(100, 22);
            this.btnNewVIP.Text = "新增";
            this.btnNewVIP.Click += new System.EventHandler(this.btnNewVIP_Click);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.修改ToolStripMenuItem.Text = "修改";
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            // 
            // RptView
            // 
            this.RptView.Name = "RptView";
            this.RptView.Size = new System.Drawing.Size(44, 21);
            this.RptView.Text = "报表";
            this.RptView.Click += new System.EventHandler(this.RptView_Click);
            // 
            // DesignerMng
            // 
            this.DesignerMng.Name = "DesignerMng";
            this.DesignerMng.Size = new System.Drawing.Size(80, 21);
            this.DesignerMng.Text = "设计师管理";
            this.DesignerMng.Click += new System.EventHandler(this.DesignerMng_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.AutoScroll = true;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 25);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(884, 837);
            this.panelContainer.TabIndex = 1;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 862);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(900, 800);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Love Her 细剪";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CashIn;
        private System.Windows.Forms.ToolStripMenuItem VIPMng;
        private System.Windows.Forms.ToolStripMenuItem RptView;
        private System.Windows.Forms.ToolStripMenuItem DesignerMng;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.ToolStripMenuItem btnNewVIP;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Bill;
        private System.Windows.Forms.ToolStripMenuItem btnOpenBill;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteBill;
    }
}

