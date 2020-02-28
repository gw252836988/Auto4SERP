namespace Auto4SErp.Report
{
    partial class frmRNormalAccOutRank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRNormalAccOutRank));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnQuery = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbClaim = new System.Windows.Forms.CheckBox();
            this.txtAccessoryCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblAccessoryCode = new DevComponents.DotNetBar.LabelX();
            this.cmbHouseName = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblHouseName1 = new DevComponents.DotNetBar.LabelX();
            this.datBegin = new System.Windows.Forms.DateTimePicker();
            this.datEnd = new System.Windows.Forms.DateTimePicker();
            this.chbIsDate = new System.Windows.Forms.CheckBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.label1 = new System.Windows.Forms.Label();
            this.dgOutWareRec = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.AccessoryCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HouseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblSum = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnOut = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOutWareRec)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnQuery,
            this.btnOut});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(936, 25);
            this.toolStrip1.TabIndex = 40;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbClaim);
            this.groupBox1.Controls.Add(this.txtAccessoryCode);
            this.groupBox1.Controls.Add(this.lblAccessoryCode);
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
            this.groupBox1.Size = new System.Drawing.Size(936, 74);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // chbClaim
            // 
            this.chbClaim.AutoSize = true;
            this.chbClaim.Location = new System.Drawing.Point(782, 28);
            this.chbClaim.Name = "chbClaim";
            this.chbClaim.Size = new System.Drawing.Size(84, 16);
            this.chbClaim.TabIndex = 46;
            this.chbClaim.Text = "只显示索赔";
            this.chbClaim.UseVisualStyleBackColor = true;
            // 
            // txtAccessoryCode
            // 
            // 
            // 
            // 
            this.txtAccessoryCode.Border.Class = "TextBoxBorder";
            this.txtAccessoryCode.Location = new System.Drawing.Point(642, 25);
            this.txtAccessoryCode.Name = "txtAccessoryCode";
            this.txtAccessoryCode.Size = new System.Drawing.Size(114, 21);
            this.txtAccessoryCode.TabIndex = 44;
            this.txtAccessoryCode.Tag = "F1S1";
            // 
            // lblAccessoryCode
            // 
            this.lblAccessoryCode.AutoSize = true;
            this.lblAccessoryCode.Location = new System.Drawing.Point(582, 27);
            this.lblAccessoryCode.Name = "lblAccessoryCode";
            this.lblAccessoryCode.Size = new System.Drawing.Size(56, 18);
            this.lblAccessoryCode.TabIndex = 43;
            this.lblAccessoryCode.Text = "配件编码";
            // 
            // cmbHouseName
            // 
            this.cmbHouseName.DisplayMember = "Text";
            this.cmbHouseName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbHouseName.FormattingEnabled = true;
            this.cmbHouseName.ItemHeight = 15;
            this.cmbHouseName.Location = new System.Drawing.Point(448, 25);
            this.cmbHouseName.Name = "cmbHouseName";
            this.cmbHouseName.Size = new System.Drawing.Size(99, 21);
            this.cmbHouseName.TabIndex = 42;
            this.cmbHouseName.Tag = "F1S1B0";
            // 
            // lblHouseName1
            // 
            this.lblHouseName1.AutoSize = true;
            this.lblHouseName1.Location = new System.Drawing.Point(389, 28);
            this.lblHouseName1.Name = "lblHouseName1";
            this.lblHouseName1.Size = new System.Drawing.Size(56, 18);
            this.lblHouseName1.TabIndex = 41;
            this.lblHouseName1.Text = "仓库名称";
            // 
            // datBegin
            // 
            this.datBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datBegin.Location = new System.Drawing.Point(98, 26);
            this.datBegin.Name = "datBegin";
            this.datBegin.Size = new System.Drawing.Size(108, 21);
            this.datBegin.TabIndex = 34;
            // 
            // datEnd
            // 
            this.datEnd.Checked = false;
            this.datEnd.CustomFormat = "";
            this.datEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datEnd.Location = new System.Drawing.Point(235, 26);
            this.datEnd.Name = "datEnd";
            this.datEnd.Size = new System.Drawing.Size(104, 21);
            this.datEnd.TabIndex = 33;
            // 
            // chbIsDate
            // 
            this.chbIsDate.AutoSize = true;
            this.chbIsDate.Checked = true;
            this.chbIsDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbIsDate.Location = new System.Drawing.Point(345, 28);
            this.chbIsDate.Name = "chbIsDate";
            this.chbIsDate.Size = new System.Drawing.Size(15, 14);
            this.chbIsDate.TabIndex = 27;
            this.chbIsDate.UseVisualStyleBackColor = true;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(39, 28);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(56, 18);
            this.labelX1.TabIndex = 26;
            this.labelX1.Text = "出库日期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "至";
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
            this.inje,
            this.zje,
            this.sumamount});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgOutWareRec.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgOutWareRec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOutWareRec.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgOutWareRec.Location = new System.Drawing.Point(0, 99);
            this.dgOutWareRec.MultiSelect = false;
            this.dgOutWareRec.Name = "dgOutWareRec";
            this.dgOutWareRec.RowTemplate.Height = 23;
            this.dgOutWareRec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOutWareRec.Size = new System.Drawing.Size(936, 330);
            this.dgOutWareRec.TabIndex = 42;
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
            // inje
            // 
            this.inje.DataPropertyName = "inje";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.inje.DefaultCellStyle = dataGridViewCellStyle4;
            this.inje.HeaderText = "成本金额";
            this.inje.Name = "inje";
            // 
            // zje
            // 
            this.zje.DataPropertyName = "zje";
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.zje.DefaultCellStyle = dataGridViewCellStyle5;
            this.zje.HeaderText = "销售金额";
            this.zje.Name = "zje";
            // 
            // sumamount
            // 
            this.sumamount.DataPropertyName = "sumamount";
            this.sumamount.HeaderText = "当前库存";
            this.sumamount.Name = "sumamount";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSum});
            this.statusStrip1.Location = new System.Drawing.Point(0, 407);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(936, 22);
            this.statusStrip1.TabIndex = 43;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblSum
            // 
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(0, 17);
            // 
            // btnOut
            // 
            this.btnOut.Image = ((System.Drawing.Image)(resources.GetObject("btnOut.Image")));
            this.btnOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(52, 22);
            this.btnOut.Tag = "out";
            this.btnOut.Text = "导出";
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // frmRNormalAccOutRank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 429);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgOutWareRec);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmRNormalAccOutRank";
            this.Text = "配件出库排行";
            this.Load += new System.EventHandler(this.frmRNormalAccOutRank_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOutWareRec)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private DevComponents.DotNetBar.Controls.DataGridViewX dgOutWareRec;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAccessoryCode;
        private DevComponents.DotNetBar.LabelX lblAccessoryCode;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessoryCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HouseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn InPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn inje;
        private System.Windows.Forms.DataGridViewTextBoxColumn zje;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumamount;
        private System.Windows.Forms.CheckBox chbClaim;
        private System.Windows.Forms.ToolStripButton btnOut;
    }
}