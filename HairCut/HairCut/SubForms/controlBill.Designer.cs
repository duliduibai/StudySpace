namespace HairCut.SubForms
{
    partial class controlBill
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hairCutDataSet = new HairCut.HairCutDataSet();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown9 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown10 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown11 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown12 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totalCash = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboxWechat = new System.Windows.Forms.CheckBox();
            this.cboxAliPay = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtVIPCard = new System.Windows.Forms.TextBox();
            this.combBarber = new System.Windows.Forms.ComboBox();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label19 = new System.Windows.Forms.Label();
            this.rbtnNonVIP = new System.Windows.Forms.RadioButton();
            this.label20 = new System.Windows.Forms.Label();
            this.rbtnVIP = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.combAssist = new System.Windows.Forms.ComboBox();
            this.combTech = new System.Windows.Forms.ComboBox();
            this.combDesign = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.accountTableAdapter = new HairCut.HairCutDataSetTableAdapters.AccountTableAdapter();
            this.staffTableAdapter = new HairCut.HairCutDataSetTableAdapters.StaffTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hairCutDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalCash)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.accountBindingSource, "Other", true));
            this.numericUpDown1.Location = new System.Drawing.Point(300, 199);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(121, 26);
            this.numericUpDown1.TabIndex = 16;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.hairCutDataSet;
            // 
            // hairCutDataSet
            // 
            this.hairCutDataSet.DataSetName = "HairCutDataSet";
            this.hairCutDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(83, 199);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(121, 26);
            this.numericUpDown2.TabIndex = 15;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.accountBindingSource, "HairCare", true));
            this.numericUpDown3.Location = new System.Drawing.Point(300, 167);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(121, 26);
            this.numericUpDown3.TabIndex = 14;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.accountBindingSource, "Style", true));
            this.numericUpDown4.Location = new System.Drawing.Point(83, 167);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(121, 26);
            this.numericUpDown4.TabIndex = 13;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.accountBindingSource, "TransHair", true));
            this.numericUpDown5.Location = new System.Drawing.Point(300, 133);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(121, 26);
            this.numericUpDown5.TabIndex = 12;
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.accountBindingSource, "ChildCut", true));
            this.numericUpDown6.Location = new System.Drawing.Point(83, 133);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(121, 26);
            this.numericUpDown6.TabIndex = 11;
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.accountBindingSource, "Straight", true));
            this.numericUpDown7.Location = new System.Drawing.Point(300, 98);
            this.numericUpDown7.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(121, 26);
            this.numericUpDown7.TabIndex = 10;
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.accountBindingSource, "InhaleCutBlow", true));
            this.numericUpDown8.Location = new System.Drawing.Point(83, 98);
            this.numericUpDown8.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(121, 26);
            this.numericUpDown8.TabIndex = 9;
            // 
            // numericUpDown9
            // 
            this.numericUpDown9.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.accountBindingSource, "Dye", true));
            this.numericUpDown9.Location = new System.Drawing.Point(300, 63);
            this.numericUpDown9.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown9.Name = "numericUpDown9";
            this.numericUpDown9.Size = new System.Drawing.Size(121, 26);
            this.numericUpDown9.TabIndex = 8;
            // 
            // numericUpDown10
            // 
            this.numericUpDown10.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.accountBindingSource, "WashCutBlow", true));
            this.numericUpDown10.Location = new System.Drawing.Point(83, 63);
            this.numericUpDown10.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown10.Name = "numericUpDown10";
            this.numericUpDown10.Size = new System.Drawing.Size(121, 26);
            this.numericUpDown10.TabIndex = 7;
            this.numericUpDown10.ValueChanged += new System.EventHandler(this.numericUpDown10_ValueChanged);
            // 
            // numericUpDown11
            // 
            this.numericUpDown11.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.accountBindingSource, "Perm", true));
            this.numericUpDown11.Location = new System.Drawing.Point(300, 29);
            this.numericUpDown11.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown11.Name = "numericUpDown11";
            this.numericUpDown11.Size = new System.Drawing.Size(121, 26);
            this.numericUpDown11.TabIndex = 6;
            this.numericUpDown11.ValueChanged += new System.EventHandler(this.numericUpDown11_ValueChanged);
            // 
            // numericUpDown12
            // 
            this.numericUpDown12.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.accountBindingSource, "WashBlow", true));
            this.numericUpDown12.Location = new System.Drawing.Point(83, 29);
            this.numericUpDown12.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown12.Name = "numericUpDown12";
            this.numericUpDown12.Size = new System.Drawing.Size(121, 26);
            this.numericUpDown12.TabIndex = 5;
            this.numericUpDown12.ValueChanged += new System.EventHandler(this.numericUpDown12_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "其他";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "产品";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "护发";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "造型";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "接发";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "儿童剪";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(237, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "直发";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "吸剪吹";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(237, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "染色";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "洗剪吹";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(237, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "烫发";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "洗吹";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalCash);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.numericUpDown3);
            this.groupBox1.Controls.Add(this.numericUpDown4);
            this.groupBox1.Controls.Add(this.numericUpDown5);
            this.groupBox1.Controls.Add(this.numericUpDown6);
            this.groupBox1.Controls.Add(this.numericUpDown7);
            this.groupBox1.Controls.Add(this.numericUpDown8);
            this.groupBox1.Controls.Add(this.numericUpDown9);
            this.groupBox1.Controls.Add(this.numericUpDown10);
            this.groupBox1.Controls.Add(this.numericUpDown11);
            this.groupBox1.Controls.Add(this.numericUpDown12);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 264);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "项目和收费";
            // 
            // totalCash
            // 
            this.totalCash.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.accountBindingSource, "CashTotal", true));
            this.totalCash.Location = new System.Drawing.Point(83, 232);
            this.totalCash.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.totalCash.Name = "totalCash";
            this.totalCash.Size = new System.Drawing.Size(121, 26);
            this.totalCash.TabIndex = 17;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 234);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 20);
            this.label18.TabIndex = 23;
            this.label18.Text = "金额合计";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(22, 146);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 20);
            this.label14.TabIndex = 5;
            this.label14.Text = "技师";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(250, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 20);
            this.label15.TabIndex = 4;
            this.label15.Text = "助理";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(22, 111);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 20);
            this.label16.TabIndex = 3;
            this.label16.Text = "设计师";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.accountBindingSource, "CreateTime", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "D"));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(250, 76);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 20);
            this.label17.TabIndex = 1;
            this.label17.Text = "单号";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cboxWechat);
            this.panel1.Controls.Add(this.cboxAliPay);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.txtVIPCard);
            this.panel1.Controls.Add(this.combBarber);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.rbtnNonVIP);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.rbtnVIP);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.combAssist);
            this.panel1.Controls.Add(this.combTech);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.combDesign);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(21, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 573);
            this.panel1.TabIndex = 3;
            // 
            // cboxWechat
            // 
            this.cboxWechat.AutoSize = true;
            this.cboxWechat.Location = new System.Drawing.Point(331, 487);
            this.cboxWechat.Name = "cboxWechat";
            this.cboxWechat.Size = new System.Drawing.Size(60, 24);
            this.cboxWechat.TabIndex = 22;
            this.cboxWechat.Text = "微信";
            this.cboxWechat.UseVisualStyleBackColor = true;
            this.cboxWechat.CheckedChanged += new System.EventHandler(this.cboxWechat_CheckedChanged);
            // 
            // cboxAliPay
            // 
            this.cboxAliPay.AutoSize = true;
            this.cboxAliPay.Location = new System.Drawing.Point(188, 488);
            this.cboxAliPay.Name = "cboxAliPay";
            this.cboxAliPay.Size = new System.Drawing.Size(76, 24);
            this.cboxAliPay.TabIndex = 21;
            this.cboxAliPay.Text = "支付宝";
            this.cboxAliPay.UseVisualStyleBackColor = true;
            this.cboxAliPay.CheckedChanged += new System.EventHandler(this.cboxAliPay_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(257, 522);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 29);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(364, 522);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(88, 29);
            this.btnSubmit.TabIndex = 25;
            this.btnSubmit.Text = "提交 ";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtVIPCard
            // 
            this.txtVIPCard.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "VIPNo", true));
            this.txtVIPCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVIPCard.Location = new System.Drawing.Point(253, 453);
            this.txtVIPCard.Name = "txtVIPCard";
            this.txtVIPCard.Size = new System.Drawing.Size(184, 26);
            this.txtVIPCard.TabIndex = 19;
            this.txtVIPCard.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtVIPCard_KeyUp);
            // 
            // combBarber
            // 
            this.combBarber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "BarberName", true));
            this.combBarber.DataSource = this.staffBindingSource;
            this.combBarber.DisplayMember = "StaffName";
            this.combBarber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combBarber.FormattingEnabled = true;
            this.combBarber.Location = new System.Drawing.Point(99, 523);
            this.combBarber.Name = "combBarber";
            this.combBarber.Size = new System.Drawing.Size(121, 28);
            this.combBarber.TabIndex = 23;
            this.combBarber.ValueMember = "StaffNo";
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.hairCutDataSet;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(184, 456);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 20);
            this.label19.TabIndex = 11;
            this.label19.Text = "卡号";
            // 
            // rbtnNonVIP
            // 
            this.rbtnNonVIP.AutoSize = true;
            this.rbtnNonVIP.Checked = true;
            this.rbtnNonVIP.Location = new System.Drawing.Point(26, 487);
            this.rbtnNonVIP.Name = "rbtnNonVIP";
            this.rbtnNonVIP.Size = new System.Drawing.Size(75, 24);
            this.rbtnNonVIP.TabIndex = 20;
            this.rbtnNonVIP.TabStop = true;
            this.rbtnNonVIP.Text = "非会员";
            this.rbtnNonVIP.UseVisualStyleBackColor = true;
            this.rbtnNonVIP.CheckedChanged += new System.EventHandler(this.rbtnNonVIP_CheckedChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(22, 526);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 20);
            this.label20.TabIndex = 14;
            this.label20.Text = "理发师";
            // 
            // rbtnVIP
            // 
            this.rbtnVIP.AutoSize = true;
            this.rbtnVIP.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.accountBindingSource, "IsVIP", true));
            this.rbtnVIP.Location = new System.Drawing.Point(26, 454);
            this.rbtnVIP.Name = "rbtnVIP";
            this.rbtnVIP.Size = new System.Drawing.Size(59, 24);
            this.rbtnVIP.TabIndex = 18;
            this.rbtnVIP.Text = "会员";
            this.rbtnVIP.UseVisualStyleBackColor = true;
            this.rbtnVIP.CheckedChanged += new System.EventHandler(this.rbtnVIP_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(265, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 33);
            this.label13.TabIndex = 12;
            this.label13.Text = "细剪";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(132, 6);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(127, 31);
            this.labelTitle.TabIndex = 11;
            this.labelTitle.Text = "Love her";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "AccountNo", true));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(316, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 26);
            this.textBox1.TabIndex = 1;
            // 
            // combAssist
            // 
            this.combAssist.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "AssistDesignName", true));
            this.combAssist.DataSource = this.staffBindingSource;
            this.combAssist.DisplayMember = "StaffName";
            this.combAssist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combAssist.FormattingEnabled = true;
            this.combAssist.Location = new System.Drawing.Point(316, 108);
            this.combAssist.Name = "combAssist";
            this.combAssist.Size = new System.Drawing.Size(121, 28);
            this.combAssist.TabIndex = 3;
            this.combAssist.ValueMember = "StaffNo";
            // 
            // combTech
            // 
            this.combTech.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "TechnicianName", true));
            this.combTech.DataSource = this.staffBindingSource;
            this.combTech.DisplayMember = "StaffName";
            this.combTech.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combTech.FormattingEnabled = true;
            this.combTech.Location = new System.Drawing.Point(99, 143);
            this.combTech.Name = "combTech";
            this.combTech.Size = new System.Drawing.Size(121, 28);
            this.combTech.TabIndex = 4;
            this.combTech.ValueMember = "StaffNo";
            // 
            // combDesign
            // 
            this.combDesign.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "DesignerName", true));
            this.combDesign.DataSource = this.staffBindingSource;
            this.combDesign.DisplayMember = "StaffName";
            this.combDesign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combDesign.FormattingEnabled = true;
            this.combDesign.Location = new System.Drawing.Point(99, 108);
            this.combDesign.Name = "combDesign";
            this.combDesign.Size = new System.Drawing.Size(121, 28);
            this.combDesign.TabIndex = 2;
            this.combDesign.ValueMember = "StaffNo";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(70, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 653);
            this.panel2.TabIndex = 4;
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // controlBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel2);
            this.Name = "controlBill";
            this.Size = new System.Drawing.Size(659, 715);
            this.SizeChanged += new System.EventHandler(this.controlBill_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hairCutDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalCash)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.NumericUpDown numericUpDown8;
        private System.Windows.Forms.NumericUpDown numericUpDown9;
        private System.Windows.Forms.NumericUpDown numericUpDown10;
        private System.Windows.Forms.NumericUpDown numericUpDown11;
        private System.Windows.Forms.NumericUpDown numericUpDown12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox combAssist;
        private System.Windows.Forms.ComboBox combTech;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown totalCash;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtVIPCard;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RadioButton rbtnNonVIP;
        private System.Windows.Forms.RadioButton rbtnVIP;
        private System.Windows.Forms.ComboBox combBarber;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox cboxWechat;
        private System.Windows.Forms.CheckBox cboxAliPay;
        private System.Windows.Forms.ComboBox combDesign;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private HairCutDataSet hairCutDataSet;
        private HairCutDataSetTableAdapters.AccountTableAdapter accountTableAdapter;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private HairCutDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
    }
}
