namespace Auto4SErp.Report
{
    partial class frmRAccOutRank
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRAccOutRank));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblSum = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgOutWareRec = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbRepair = new System.Windows.Forms.CheckBox();
            this.chbClaim = new System.Windows.Forms.CheckBox();
            this.cmbInType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.comboItem6 = new DevComponents.Editors.ComboItem();
            this.comboItem7 = new DevComponents.Editors.ComboItem();
            this.lblInType = new DevComponents.DotNetBar.LabelX();
            this.cmbHouseName = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblHouseName1 = new DevComponents.DotNetBar.LabelX();
            this.datBegin = new System.Windows.Forms.DateTimePicker();
            this.datEnd = new System.Windows.Forms.DateTimePicker();
            this.chbIsDate = new System.Windows.Forms.CheckBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnQuery = new System.Windows.Forms.ToolStripButton();
            this.AccessoryCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HouseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOutWareRec)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSum});
            this.statusStrip1.Location = new System.Drawing.Point(0, 390);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(869, 22);
            this.statusStrip1.TabIndex = 41;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblSum
            // 
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(0, 17);
            // 
            // dgOutWareRec
            // 
            this.dgOutWareRec.AllowUserToAddRows = false;
            this.dgOutWareRec.AllowUserToDeleteRows = false;
            this.dgOutWareRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOutWareRec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccessoryCode,
            this.AccessoryName,
            this.HouseName,
            this.Amount,
            this.InPrice,
            this.SalePrice,
            this.sumamount});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgOutWareRec.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgOutWareRec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOutWareRec.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgOutWareRec.Location = new System.Drawing.Point(0, 117);
            this.dgOutWareRec.MultiSelect = false;
            this.dgOutWareRec.Name = "dgOutWareRec";
            this.dgOutWareRec.RowTemplate.Height = 23;
            this.dgOutWareRec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOutWareRec.Size = new System.Drawing.Size(869, 295);
            this.dgOutWareRec.TabIndex = 38;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbRepair);
            this.groupBox1.Controls.Add(this.chbClaim);
            this.groupBox1.Controls.Add(this.cmbInType);
            this.groupBox1.Controls.Add(this.lblInType);
            this.groupBox1.Controls.Add(this.cmbHouseName);
            this.groupBox1.Controls.Add(this.lblHouseName1);
            this.groupBox1.Controls.Add(this.datBegin);
            this.groupBox1.Controls.Add(this.datEnd);
            this.groupBox1.Controls.Add(this.chbIsDate);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(869, 92);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // chbRepair
            // 
            this.chbRepair.AutoSize = true;
            this.chbRepair.Location = new System.Drawing.Point(783, 58);
            this.chbRepair.Name = "chbRepair";
            this.chbRepair.Size = new System.Drawing.Size(60, 16);
            this.chbRepair.TabIndex = 46;
            this.chbRepair.Text = "非售后";
            this.chbRepair.UseVisualStyleBackColor = true;
            // 
            // chbClaim
            // 
            this.chbClaim.AutoSize = true;
            this.chbClaim.Location = new System.Drawing.Point(783, 33);
            this.chbClaim.Name = "chbClaim";
            this.chbClaim.Size = new System.Drawing.Size(60, 16);
            this.chbClaim.TabIndex = 45;
            this.chbClaim.Text = "去索赔";
            this.chbClaim.UseVisualStyleBackColor = true;
            // 
            // cmbInType
            // 
            this.cmbInType.DisplayMember = "Text";
            this.cmbInType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbInType.FormattingEnabled = true;
            this.cmbInType.ItemHeight = 15;
            this.cmbInType.Items.AddRange(new object[] {
            this.comboItem3,
            this.comboItem4,
            this.comboItem5,
            this.comboItem6,
            this.comboItem7});
            this.cmbInType.Location = new System.Drawing.Point(641, 31);
            this.cmbInType.Name = "cmbInType";
            this.cmbInType.Size = new System.Drawing.Size(121, 21);
            this.cmbInType.TabIndex = 44;
            this.cmbInType.Tag = "F1S1B0";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "收款已开票";
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "欠款已开票";
            // 
            // comboItem6
            // 
            this.comboItem6.Text = "收款未开票";
            // 
            // comboItem7
            // 
            this.comboItem7.Text = "欠款未开票";
            // 
            // lblInType
            // 
            this.lblInType.AutoSize = true;
            this.lblInType.Location = new System.Drawing.Point(573, 34);
            this.lblInType.Name = "lblInType";
            this.lblInType.Size = new System.Drawing.Size(62, 18);
            this.lblInType.TabIndex = 43;
            this.lblInType.Text = " 收入种类";
            // 
            // cmbHouseName
            // 
            this.cmbHouseName.DisplayMember = "Text";
            this.cmbHouseName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbHouseName.FormattingEnabled = true;
            this.cmbHouseName.ItemHeight = 15;
            this.cmbHouseName.Location = new System.Drawing.Point(447, 31);
            this.cmbHouseName.Name = "cmbHouseName";
            this.cmbHouseName.Size = new System.Drawing.Size(99, 21);
            this.cmbHouseName.TabIndex = 42;
            this.cmbHouseName.Tag = "F1S1B0";
            // 
            // lblHouseName1
            // 
            this.lblHouseName1.AutoSize = true;
            this.lblHouseName1.Location = new System.Drawing.Point(388, 34);
            this.lblHouseName1.Name = "lblHouseName1";
            this.lblHouseName1.Size = new System.Drawing.Size(56, 18);
            this.lblHouseName1.TabIndex = 41;
            this.lblHouseName1.Text = "仓库名称";
            // 
            // datBegin
            // 
            this.datBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datBegin.Location = new System.Drawing.Point(97, 32);
            this.datBegin.Name = "datBegin";
            this.datBegin.Size = new System.Drawing.Size(108, 21);
            this.datBegin.TabIndex = 34;
            // 
            // datEnd
            // 
            this.datEnd.Checked = false;
            this.datEnd.CustomFormat = "";
            this.datEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datEnd.Location = new System.Drawing.Point(234, 32);
            this.datEnd.Name = "datEnd";
            this.datEnd.Size = new System.Drawing.Size(104, 21);
            this.datEnd.TabIndex = 33;
            // 
            // chbIsDate
            // 
            this.chbIsDate.AutoSize = true;
            this.chbIsDate.Checked = true;
            this.chbIsDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbIsDate.Location = new System.Drawing.Point(344, 34);
            this.chbIsDate.Name = "chbIsDate";
            this.chbIsDate.Size = new System.Drawing.Size(15, 14);
            this.chbIsDate.TabIndex = 27;
            this.chbIsDate.UseVisualStyleBackColor = true;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(38, 34);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(56, 18);
            this.labelX1.TabIndex = 26;
            this.labelX1.Text = "结算日期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "至";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnQuery});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(869, 25);
            this.toolStrip1.TabIndex = 39;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnQuery
            // 
            this.tbtnQuery.Image = ((System.Drawing.Image)(resources.GetObject("tbtnQuery.Image")));
            this.tbtnQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnQuery.Name = "tbtnQuery";
            this.tbtnQuery.Size = new System.Drawing.Size(52, 22);
            this.tbtnQuery.Tag = "query";
            this.tbtnQuery.Text = "查询";
            this.tbtnQuery.Click += new System.EventHandler(this.tbtnQuery_Click);
            // 
            // AccessoryCode
            // 
            this.AccessoryCode.DataPropertyName = "AccessoryCode";
            this.AccessoryCode.HeaderText = "配件编码";
            this.AccessoryCode.Name = "AccessoryCode";
            // 
            // AccessoryName
            // 
            this.AccessoryName.DataPropertyName = "AccessoryName";
            this.AccessoryName.HeaderText = "配件名称";
            this.AccessoryName.Name = "AccessoryName";
            // 
            // HouseName
            // 
            this.HouseName.DataPropertyName = "HouseName";
            this.HouseName.HeaderText = "配件仓";
            this.HouseName.Name = "HouseName";
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.Amount.DefaultCellStyle = dataGridViewCellStyle1;
            this.Amount.HeaderText = "数量";
            this.Amount.Name = "Amount";
            // 
            // InPrice
            // 
            this.InPrice.DataPropertyName = "InPrice";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.InPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.InPrice.HeaderText = "成本价";
            this.InPrice.Name = "InPrice";
            // 
            // SalePrice
            // 
            this.SalePrice.DataPropertyName = "SalePrice";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.SalePrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.SalePrice.HeaderText = "销售价";
            this.SalePrice.Name = "SalePrice";
            // 
            // sumamount
            // 
            this.sumamount.DataPropertyName = "sumamount";
            this.sumamount.HeaderText = "当前库存";
            this.sumamount.Name = "sumamount";
            // 
            // frmRAccOutRank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 412);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgOutWareRec);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmRAccOutRank";
            this.Text = "结算配件出库排行";
            this.Load += new System.EventHandler(this.FrmRAccOutRank_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOutWareRec)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgOutWareRec;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnQuery;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbHouseName;
        private DevComponents.DotNetBar.LabelX lblHouseName1;
        private System.Windows.Forms.DateTimePicker datBegin;
        private System.Windows.Forms.DateTimePicker datEnd;
        private System.Windows.Forms.CheckBox chbIsDate;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbInType;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.ComboItem comboItem5;
        private DevComponents.Editors.ComboItem comboItem6;
        private DevComponents.Editors.ComboItem comboItem7;
        private DevComponents.DotNetBar.LabelX lblInType;
        private System.Windows.Forms.CheckBox chbClaim;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblSum;
        private System.Windows.Forms.CheckBox chbRepair;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessoryCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HouseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn InPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumamount;
    }
}