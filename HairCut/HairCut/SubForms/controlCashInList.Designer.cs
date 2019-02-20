namespace HairCut.SubForms
{
    partial class controlCashInList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hairCutDataSet1 = new HairCut.HairCutDataSet1();
            this.hairCutDataSet = new HairCut.HairCutDataSet();
            this.accountTableAdapter = new HairCut.HairCutDataSetTableAdapters.AccountTableAdapter();
            this.accountTableAdapter1 = new HairCut.HairCutDataSet1TableAdapters.AccountTableAdapter();
            this.btnOperate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.accountNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.washBlowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hairCutDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hairCutDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnOperate,
            this.accountNoDataGridViewTextBoxColumn,
            this.createTimeDataGridViewTextBoxColumn,
            this.designerNameDataGridViewTextBoxColumn,
            this.washBlowDataGridViewTextBoxColumn,
            this.cashTotalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.accountBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(595, 378);
            this.dataGridView1.TabIndex = 0;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.hairCutDataSet1;
            // 
            // hairCutDataSet1
            // 
            this.hairCutDataSet1.DataSetName = "HairCutDataSet1";
            this.hairCutDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hairCutDataSet
            // 
            this.hairCutDataSet.DataSetName = "HairCutDataSet";
            this.hairCutDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // accountTableAdapter1
            // 
            this.accountTableAdapter1.ClearBeforeFill = true;
            // 
            // btnOperate
            // 
            this.btnOperate.HeaderText = "操作";
            this.btnOperate.Name = "btnOperate";
            this.btnOperate.ReadOnly = true;
            this.btnOperate.Text = "打开";
            this.btnOperate.Width = 50;
            // 
            // accountNoDataGridViewTextBoxColumn
            // 
            this.accountNoDataGridViewTextBoxColumn.DataPropertyName = "AccountNo";
            this.accountNoDataGridViewTextBoxColumn.HeaderText = "AccountNo";
            this.accountNoDataGridViewTextBoxColumn.Name = "accountNoDataGridViewTextBoxColumn";
            this.accountNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.HeaderText = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            this.createTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // designerNameDataGridViewTextBoxColumn
            // 
            this.designerNameDataGridViewTextBoxColumn.DataPropertyName = "DesignerName";
            this.designerNameDataGridViewTextBoxColumn.HeaderText = "DesignerName";
            this.designerNameDataGridViewTextBoxColumn.Name = "designerNameDataGridViewTextBoxColumn";
            this.designerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // washBlowDataGridViewTextBoxColumn
            // 
            this.washBlowDataGridViewTextBoxColumn.DataPropertyName = "WashBlow";
            this.washBlowDataGridViewTextBoxColumn.HeaderText = "WashBlow";
            this.washBlowDataGridViewTextBoxColumn.Name = "washBlowDataGridViewTextBoxColumn";
            this.washBlowDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cashTotalDataGridViewTextBoxColumn
            // 
            this.cashTotalDataGridViewTextBoxColumn.DataPropertyName = "CashTotal";
            this.cashTotalDataGridViewTextBoxColumn.HeaderText = "CashTotal";
            this.cashTotalDataGridViewTextBoxColumn.Name = "cashTotalDataGridViewTextBoxColumn";
            this.cashTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // controlCashInList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "controlCashInList";
            this.Size = new System.Drawing.Size(595, 378);
            this.Load += new System.EventHandler(this.controlCashIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hairCutDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hairCutDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private HairCutDataSet hairCutDataSet;
        private HairCutDataSetTableAdapters.AccountTableAdapter accountTableAdapter;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private HairCutDataSet1 hairCutDataSet1;
        private HairCutDataSet1TableAdapters.AccountTableAdapter accountTableAdapter1;
        private System.Windows.Forms.DataGridViewButtonColumn btnOperate;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn washBlowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashTotalDataGridViewTextBoxColumn;
    }
}
