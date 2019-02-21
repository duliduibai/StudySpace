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
            this.hairCutDataSet = new HairCut.HairCutDataSet1();
            this.accountTableAdapter = new HairCut.HairCutDataSet1TableAdapters.AccountTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designerNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assistDesignNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assistDesignNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.technicianNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.technicianNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.washCutBlowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dyeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inhaleCutBlowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.straightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.childCutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transHairDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.styleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hairCareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payWayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isVIPDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vIPNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vIPBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.designerNoDataGridViewTextBoxColumn,
            this.assistDesignNameDataGridViewTextBoxColumn,
            this.assistDesignNoDataGridViewTextBoxColumn,
            this.technicianNameDataGridViewTextBoxColumn,
            this.technicianNoDataGridViewTextBoxColumn,
            this.permDataGridViewTextBoxColumn,
            this.washCutBlowDataGridViewTextBoxColumn,
            this.dyeDataGridViewTextBoxColumn,
            this.inhaleCutBlowDataGridViewTextBoxColumn,
            this.straightDataGridViewTextBoxColumn,
            this.childCutDataGridViewTextBoxColumn,
            this.transHairDataGridViewTextBoxColumn,
            this.styleDataGridViewTextBoxColumn,
            this.hairCareDataGridViewTextBoxColumn,
            this.otherDataGridViewTextBoxColumn,
            this.payWayDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn5,
            this.isVIPDataGridViewCheckBoxColumn,
            this.vIPNoDataGridViewTextBoxColumn,
            this.vIPBalanceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.accountBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(763, 515);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.hairCutDataSet;
            // 
            // hairCutDataSet
            // 
            this.hairCutDataSet.DataSetName = "HairCutDataSet1";
            this.hairCutDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AccountNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "AccountNo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CreateTime";
            this.dataGridViewTextBoxColumn2.HeaderText = "CreateTime";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "WashBlow";
            this.dataGridViewTextBoxColumn4.HeaderText = "WashBlow";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DesignerName";
            this.dataGridViewTextBoxColumn3.HeaderText = "DesignerName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // designerNoDataGridViewTextBoxColumn
            // 
            this.designerNoDataGridViewTextBoxColumn.DataPropertyName = "DesignerNo";
            this.designerNoDataGridViewTextBoxColumn.HeaderText = "DesignerNo";
            this.designerNoDataGridViewTextBoxColumn.Name = "designerNoDataGridViewTextBoxColumn";
            this.designerNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // assistDesignNameDataGridViewTextBoxColumn
            // 
            this.assistDesignNameDataGridViewTextBoxColumn.DataPropertyName = "AssistDesignName";
            this.assistDesignNameDataGridViewTextBoxColumn.HeaderText = "AssistDesignName";
            this.assistDesignNameDataGridViewTextBoxColumn.Name = "assistDesignNameDataGridViewTextBoxColumn";
            this.assistDesignNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // assistDesignNoDataGridViewTextBoxColumn
            // 
            this.assistDesignNoDataGridViewTextBoxColumn.DataPropertyName = "AssistDesignNo";
            this.assistDesignNoDataGridViewTextBoxColumn.HeaderText = "AssistDesignNo";
            this.assistDesignNoDataGridViewTextBoxColumn.Name = "assistDesignNoDataGridViewTextBoxColumn";
            this.assistDesignNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // technicianNameDataGridViewTextBoxColumn
            // 
            this.technicianNameDataGridViewTextBoxColumn.DataPropertyName = "TechnicianName";
            this.technicianNameDataGridViewTextBoxColumn.HeaderText = "TechnicianName";
            this.technicianNameDataGridViewTextBoxColumn.Name = "technicianNameDataGridViewTextBoxColumn";
            this.technicianNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // technicianNoDataGridViewTextBoxColumn
            // 
            this.technicianNoDataGridViewTextBoxColumn.DataPropertyName = "TechnicianNo";
            this.technicianNoDataGridViewTextBoxColumn.HeaderText = "TechnicianNo";
            this.technicianNoDataGridViewTextBoxColumn.Name = "technicianNoDataGridViewTextBoxColumn";
            this.technicianNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // permDataGridViewTextBoxColumn
            // 
            this.permDataGridViewTextBoxColumn.DataPropertyName = "Perm";
            this.permDataGridViewTextBoxColumn.HeaderText = "Perm";
            this.permDataGridViewTextBoxColumn.Name = "permDataGridViewTextBoxColumn";
            this.permDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // washCutBlowDataGridViewTextBoxColumn
            // 
            this.washCutBlowDataGridViewTextBoxColumn.DataPropertyName = "WashCutBlow";
            this.washCutBlowDataGridViewTextBoxColumn.HeaderText = "WashCutBlow";
            this.washCutBlowDataGridViewTextBoxColumn.Name = "washCutBlowDataGridViewTextBoxColumn";
            this.washCutBlowDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dyeDataGridViewTextBoxColumn
            // 
            this.dyeDataGridViewTextBoxColumn.DataPropertyName = "Dye";
            this.dyeDataGridViewTextBoxColumn.HeaderText = "Dye";
            this.dyeDataGridViewTextBoxColumn.Name = "dyeDataGridViewTextBoxColumn";
            this.dyeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inhaleCutBlowDataGridViewTextBoxColumn
            // 
            this.inhaleCutBlowDataGridViewTextBoxColumn.DataPropertyName = "InhaleCutBlow";
            this.inhaleCutBlowDataGridViewTextBoxColumn.HeaderText = "InhaleCutBlow";
            this.inhaleCutBlowDataGridViewTextBoxColumn.Name = "inhaleCutBlowDataGridViewTextBoxColumn";
            this.inhaleCutBlowDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // straightDataGridViewTextBoxColumn
            // 
            this.straightDataGridViewTextBoxColumn.DataPropertyName = "Straight";
            this.straightDataGridViewTextBoxColumn.HeaderText = "Straight";
            this.straightDataGridViewTextBoxColumn.Name = "straightDataGridViewTextBoxColumn";
            this.straightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // childCutDataGridViewTextBoxColumn
            // 
            this.childCutDataGridViewTextBoxColumn.DataPropertyName = "ChildCut";
            this.childCutDataGridViewTextBoxColumn.HeaderText = "ChildCut";
            this.childCutDataGridViewTextBoxColumn.Name = "childCutDataGridViewTextBoxColumn";
            this.childCutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transHairDataGridViewTextBoxColumn
            // 
            this.transHairDataGridViewTextBoxColumn.DataPropertyName = "TransHair";
            this.transHairDataGridViewTextBoxColumn.HeaderText = "TransHair";
            this.transHairDataGridViewTextBoxColumn.Name = "transHairDataGridViewTextBoxColumn";
            this.transHairDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // styleDataGridViewTextBoxColumn
            // 
            this.styleDataGridViewTextBoxColumn.DataPropertyName = "Style";
            this.styleDataGridViewTextBoxColumn.HeaderText = "Style";
            this.styleDataGridViewTextBoxColumn.Name = "styleDataGridViewTextBoxColumn";
            this.styleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hairCareDataGridViewTextBoxColumn
            // 
            this.hairCareDataGridViewTextBoxColumn.DataPropertyName = "HairCare";
            this.hairCareDataGridViewTextBoxColumn.HeaderText = "HairCare";
            this.hairCareDataGridViewTextBoxColumn.Name = "hairCareDataGridViewTextBoxColumn";
            this.hairCareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // otherDataGridViewTextBoxColumn
            // 
            this.otherDataGridViewTextBoxColumn.DataPropertyName = "Other";
            this.otherDataGridViewTextBoxColumn.HeaderText = "Other";
            this.otherDataGridViewTextBoxColumn.Name = "otherDataGridViewTextBoxColumn";
            this.otherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // payWayDataGridViewTextBoxColumn
            // 
            this.payWayDataGridViewTextBoxColumn.DataPropertyName = "PayWay";
            this.payWayDataGridViewTextBoxColumn.HeaderText = "PayWay";
            this.payWayDataGridViewTextBoxColumn.Name = "payWayDataGridViewTextBoxColumn";
            this.payWayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CashTotal";
            this.dataGridViewTextBoxColumn5.HeaderText = "CashTotal";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // isVIPDataGridViewCheckBoxColumn
            // 
            this.isVIPDataGridViewCheckBoxColumn.DataPropertyName = "IsVIP";
            this.isVIPDataGridViewCheckBoxColumn.HeaderText = "IsVIP";
            this.isVIPDataGridViewCheckBoxColumn.Name = "isVIPDataGridViewCheckBoxColumn";
            this.isVIPDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // vIPNoDataGridViewTextBoxColumn
            // 
            this.vIPNoDataGridViewTextBoxColumn.DataPropertyName = "VIPNo";
            this.vIPNoDataGridViewTextBoxColumn.HeaderText = "VIPNo";
            this.vIPNoDataGridViewTextBoxColumn.Name = "vIPNoDataGridViewTextBoxColumn";
            this.vIPNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vIPBalanceDataGridViewTextBoxColumn
            // 
            this.vIPBalanceDataGridViewTextBoxColumn.DataPropertyName = "VIPBalance";
            this.vIPBalanceDataGridViewTextBoxColumn.HeaderText = "VIPBalance";
            this.vIPBalanceDataGridViewTextBoxColumn.Name = "vIPBalanceDataGridViewTextBoxColumn";
            this.vIPBalanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // controlCashInList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "controlCashInList";
            this.Size = new System.Drawing.Size(763, 515);
            this.Load += new System.EventHandler(this.controlCashIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hairCutDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn washBlowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private HairCutDataSet1 hairCutDataSet;
        private HairCutDataSet1TableAdapters.AccountTableAdapter accountTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn designerNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assistDesignNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assistDesignNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn technicianNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn technicianNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn washCutBlowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dyeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inhaleCutBlowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn straightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn childCutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transHairDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn styleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hairCareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payWayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isVIPDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vIPNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vIPBalanceDataGridViewTextBoxColumn;
    }
}
