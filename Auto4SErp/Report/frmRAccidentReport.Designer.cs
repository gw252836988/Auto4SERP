namespace Auto4SErp.Report
{
    partial class frmRAccidentReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRAccidentReport));
            this.dgRepair = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.AccountTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlateNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsuranceCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GInprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblSum = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbComeType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem11 = new DevComponents.Editors.ComboItem();
            this.comboItem12 = new DevComponents.Editors.ComboItem();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtInsuranceCompany = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblInsuranceCompany = new DevComponents.DotNetBar.LabelX();
            this.itimaxamount = new DevComponents.Editors.IntegerInput();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.itiminamount = new DevComponents.Editors.IntegerInput();
            this.lblJSAmount = new DevComponents.DotNetBar.LabelX();
            this.datBegin = new System.Windows.Forms.DateTimePicker();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.label1 = new System.Windows.Forms.Label();
            this.datEnd = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnQuery = new System.Windows.Forms.ToolStripButton();
            this.tbtnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnOut = new System.Windows.Forms.ToolStripButton();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgRepair)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itimaxamount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itiminamount)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgRepair
            // 
            this.dgRepair.AllowUserToAddRows = false;
            this.dgRepair.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRepair.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgRepair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRepair.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountTime,
            this.DH,
            this.ComeType,
            this.PlateNum,
            this.CustName,
            this.InsuranceCompany,
            this.GAmount,
            this.ItemProfit,
            this.AccProfit,
            this.GInprice,
            this.GProfit,
            this.PRate,
            this.cash,
            this.bank,
            this.vip,
            this.CS});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgRepair.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgRepair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgRepair.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgRepair.Location = new System.Drawing.Point(0, 133);
            this.dgRepair.Name = "dgRepair";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRepair.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgRepair.RowTemplate.Height = 23;
            this.dgRepair.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRepair.Size = new System.Drawing.Size(890, 267);
            this.dgRepair.TabIndex = 39;
            this.dgRepair.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgRepair_RowPostPaint);
            // 
            // AccountTime
            // 
            this.AccountTime.DataPropertyName = "AccountTime";
            this.AccountTime.HeaderText = "结算日期";
            this.AccountTime.Name = "AccountTime";
            // 
            // DH
            // 
            this.DH.DataPropertyName = "DH";
            this.DH.HeaderText = "单号";
            this.DH.Name = "DH";
            // 
            // ComeType
            // 
            this.ComeType.DataPropertyName = "ComeType";
            this.ComeType.HeaderText = "来店方式";
            this.ComeType.Name = "ComeType";
            // 
            // PlateNum
            // 
            this.PlateNum.DataPropertyName = "PlateNum";
            this.PlateNum.HeaderText = "车牌号";
            this.PlateNum.Name = "PlateNum";
            // 
            // CustName
            // 
            this.CustName.DataPropertyName = "CustName";
            this.CustName.HeaderText = "顾客姓名";
            this.CustName.Name = "CustName";
            // 
            // InsuranceCompany
            // 
            this.InsuranceCompany.DataPropertyName = "InsuranceCompany";
            this.InsuranceCompany.HeaderText = "保险公司";
            this.InsuranceCompany.Name = "InsuranceCompany";
            // 
            // GAmount
            // 
            this.GAmount.DataPropertyName = "GAmount";
            this.GAmount.HeaderText = "结算金额";
            this.GAmount.Name = "GAmount";
            // 
            // ItemProfit
            // 
            this.ItemProfit.DataPropertyName = "ItemProfit";
            this.ItemProfit.HeaderText = "工时费";
            this.ItemProfit.Name = "ItemProfit";
            // 
            // AccProfit
            // 
            this.AccProfit.DataPropertyName = "AccProfit";
            this.AccProfit.HeaderText = "材料费";
            this.AccProfit.Name = "AccProfit";
            // 
            // GInprice
            // 
            this.GInprice.DataPropertyName = "GInprice";
            this.GInprice.HeaderText = "材料成本";
            this.GInprice.Name = "GInprice";
            // 
            // GProfit
            // 
            this.GProfit.DataPropertyName = "GProfit";
            this.GProfit.HeaderText = "单车毛利";
            this.GProfit.Name = "GProfit";
            // 
            // PRate
            // 
            this.PRate.DataPropertyName = "PRate";
            this.PRate.HeaderText = "毛利率";
            this.PRate.Name = "PRate";
            // 
            // cash
            // 
            this.cash.DataPropertyName = "cash";
            this.cash.HeaderText = "现金";
            this.cash.Name = "cash";
            // 
            // bank
            // 
            this.bank.DataPropertyName = "bank";
            this.bank.HeaderText = "银行卡";
            this.bank.Name = "bank";
            // 
            // vip
            // 
            this.vip.DataPropertyName = "vip";
            this.vip.HeaderText = "会员卡";
            this.vip.Name = "vip";
            // 
            // CS
            // 
            this.CS.DataPropertyName = "cs";
            this.CS.HeaderText = "赊销";
            this.CS.Name = "CS";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSum,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 400);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(890, 22);
            this.statusStrip1.TabIndex = 40;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblSum
            // 
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbComeType);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.txtInsuranceCompany);
            this.groupBox1.Controls.Add(this.lblInsuranceCompany);
            this.groupBox1.Controls.Add(this.itimaxamount);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.itiminamount);
            this.groupBox1.Controls.Add(this.lblJSAmount);
            this.groupBox1.Controls.Add(this.datBegin);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.datEnd);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 108);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbComeType
            // 
            this.cmbComeType.DisplayMember = "Text";
            this.cmbComeType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbComeType.FormattingEnabled = true;
            this.cmbComeType.ItemHeight = 15;
            this.cmbComeType.Items.AddRange(new object[] {
            this.comboItem11,
            this.comboItem12,
            this.comboItem1});
            this.cmbComeType.Location = new System.Drawing.Point(448, 72);
            this.cmbComeType.Name = "cmbComeType";
            this.cmbComeType.Size = new System.Drawing.Size(100, 21);
            this.cmbComeType.TabIndex = 134;
            this.cmbComeType.Tag = "N";
            // 
            // comboItem11
            // 
            this.comboItem11.Text = "保险推修";
            // 
            // comboItem12
            // 
            this.comboItem12.Text = "开拓进店";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX2.Location = new System.Drawing.Point(385, 75);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(56, 18);
            this.labelX2.TabIndex = 133;
            this.labelX2.Text = "进店方式";
            // 
            // txtInsuranceCompany
            // 
            // 
            // 
            // 
            this.txtInsuranceCompany.Border.Class = "TextBoxBorder";
            this.txtInsuranceCompany.Location = new System.Drawing.Point(448, 35);
            this.txtInsuranceCompany.Name = "txtInsuranceCompany";
            this.txtInsuranceCompany.Size = new System.Drawing.Size(100, 21);
            this.txtInsuranceCompany.TabIndex = 46;
            // 
            // lblInsuranceCompany
            // 
            this.lblInsuranceCompany.AutoSize = true;
            this.lblInsuranceCompany.Location = new System.Drawing.Point(385, 38);
            this.lblInsuranceCompany.Name = "lblInsuranceCompany";
            this.lblInsuranceCompany.Size = new System.Drawing.Size(56, 18);
            this.lblInsuranceCompany.TabIndex = 45;
            this.lblInsuranceCompany.Text = "保险公司";
            // 
            // itimaxamount
            // 
            // 
            // 
            // 
            this.itimaxamount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.itimaxamount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.itimaxamount.Location = new System.Drawing.Point(756, 35);
            this.itimaxamount.Name = "itimaxamount";
            this.itimaxamount.ShowUpDown = true;
            this.itimaxamount.Size = new System.Drawing.Size(80, 21);
            this.itimaxamount.TabIndex = 44;
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.Location = new System.Drawing.Point(731, 36);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(19, 18);
            this.labelX3.TabIndex = 43;
            this.labelX3.Text = "至";
            // 
            // itiminamount
            // 
            // 
            // 
            // 
            this.itiminamount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.itiminamount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.itiminamount.Location = new System.Drawing.Point(645, 35);
            this.itiminamount.Name = "itiminamount";
            this.itiminamount.ShowUpDown = true;
            this.itiminamount.Size = new System.Drawing.Size(80, 21);
            this.itiminamount.TabIndex = 42;
            // 
            // lblJSAmount
            // 
            this.lblJSAmount.AutoSize = true;
            this.lblJSAmount.Location = new System.Drawing.Point(583, 37);
            this.lblJSAmount.Name = "lblJSAmount";
            this.lblJSAmount.Size = new System.Drawing.Size(56, 18);
            this.lblJSAmount.TabIndex = 41;
            this.lblJSAmount.Text = "结算金额";
            // 
            // datBegin
            // 
            this.datBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datBegin.Location = new System.Drawing.Point(113, 35);
            this.datBegin.Name = "datBegin";
            this.datBegin.Size = new System.Drawing.Size(108, 21);
            this.datBegin.TabIndex = 32;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(51, 36);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(56, 18);
            this.labelX1.TabIndex = 31;
            this.labelX1.Text = "结算日期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 30;
            this.label1.Text = "至";
            // 
            // datEnd
            // 
            this.datEnd.Checked = false;
            this.datEnd.CustomFormat = "";
            this.datEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datEnd.Location = new System.Drawing.Point(250, 35);
            this.datEnd.Name = "datEnd";
            this.datEnd.Size = new System.Drawing.Size(104, 21);
            this.datEnd.TabIndex = 29;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnQuery,
            this.tbtnOpen,
            this.btnOut});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(890, 25);
            this.toolStrip1.TabIndex = 37;
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
            // tbtnOpen
            // 
            this.tbtnOpen.Image = ((System.Drawing.Image)(resources.GetObject("tbtnOpen.Image")));
            this.tbtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnOpen.Name = "tbtnOpen";
            this.tbtnOpen.Size = new System.Drawing.Size(52, 22);
            this.tbtnOpen.Tag = "open";
            this.tbtnOpen.Text = "打开";
            this.tbtnOpen.Click += new System.EventHandler(this.tbtnOpen_Click);
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
            // comboItem1
            // 
            this.comboItem1.Text = "自然进店";
            // 
            // frmRAccidentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 422);
            this.Controls.Add(this.dgRepair);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmRAccidentReport";
            this.Text = "事故车统计报表";
            this.Load += new System.EventHandler(this.frmRAccidentReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRepair)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itimaxamount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itiminamount)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnQuery;
        private System.Windows.Forms.ToolStripButton tbtnOpen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker datBegin;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datEnd;
        private DevComponents.Editors.IntegerInput itimaxamount;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.Editors.IntegerInput itiminamount;
        private DevComponents.DotNetBar.LabelX lblJSAmount;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgRepair;
        private System.Windows.Forms.ToolStripButton btnOut;
        private DevComponents.DotNetBar.Controls.TextBoxX txtInsuranceCompany;
        private DevComponents.DotNetBar.LabelX lblInsuranceCompany;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblSum;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbComeType;
        private DevComponents.Editors.ComboItem comboItem11;
        private DevComponents.Editors.ComboItem comboItem12;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlateNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsuranceCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn GAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemProfit;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccProfit;
        private System.Windows.Forms.DataGridViewTextBoxColumn GInprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn GProfit;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cash;
        private System.Windows.Forms.DataGridViewTextBoxColumn bank;
        private System.Windows.Forms.DataGridViewTextBoxColumn vip;
        private System.Windows.Forms.DataGridViewTextBoxColumn CS;
        private DevComponents.Editors.ComboItem comboItem1;
    }
}