﻿namespace Auto4SErp.Report
{
    partial class frmFStatistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFStatistics));
            this.dgAccount = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.DH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P2P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Integral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Other = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreRecv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDescribes = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem8 = new DevComponents.Editors.ComboItem();
            this.comboItem9 = new DevComponents.Editors.ComboItem();
            this.cmbInType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.comboItem6 = new DevComponents.Editors.ComboItem();
            this.comboItem7 = new DevComponents.Editors.ComboItem();
            this.lblInType = new DevComponents.DotNetBar.LabelX();
            this.datBegin = new System.Windows.Forms.DateTimePicker();
            this.lblDescribes = new DevComponents.DotNetBar.LabelX();
            this.chbDH = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chbDescribes = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.label1 = new System.Windows.Forms.Label();
            this.datEnd = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnQuery = new System.Windows.Forms.ToolStripButton();
            this.btnOut = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgAccount
            // 
            this.dgAccount.AllowUserToAddRows = false;
            this.dgAccount.AllowUserToDeleteRows = false;
            this.dgAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DH,
            this.Amount,
            this.recamount,
            this.Cash,
            this.bank,
            this.CheckAmount,
            this.vip,
            this.P2P,
            this.Integral,
            this.CS,
            this.Other,
            this.PreRecv,
            this.InvoiceAmount});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAccount.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAccount.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgAccount.Location = new System.Drawing.Point(0, 120);
            this.dgAccount.MultiSelect = false;
            this.dgAccount.Name = "dgAccount";
            this.dgAccount.RowTemplate.Height = 23;
            this.dgAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAccount.Size = new System.Drawing.Size(876, 354);
            this.dgAccount.TabIndex = 41;
            // 
            // DH
            // 
            this.DH.DataPropertyName = "dhfrom";
            this.DH.HeaderText = "单号";
            this.DH.Name = "DH";
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "应收金额";
            this.Amount.Name = "Amount";
            // 
            // recamount
            // 
            this.recamount.DataPropertyName = "recamount";
            this.recamount.HeaderText = "实收金额";
            this.recamount.Name = "recamount";
            // 
            // Cash
            // 
            this.Cash.DataPropertyName = "Cash";
            this.Cash.HeaderText = "现金";
            this.Cash.Name = "Cash";
            // 
            // bank
            // 
            this.bank.DataPropertyName = "bank";
            this.bank.HeaderText = "银行";
            this.bank.Name = "bank";
            // 
            // CheckAmount
            // 
            this.CheckAmount.DataPropertyName = "CheckAmount";
            this.CheckAmount.HeaderText = "支票";
            this.CheckAmount.Name = "CheckAmount";
            // 
            // vip
            // 
            this.vip.DataPropertyName = "vip";
            this.vip.HeaderText = "Vip";
            this.vip.Name = "vip";
            // 
            // P2P
            // 
            this.P2P.DataPropertyName = "P2P";
            this.P2P.HeaderText = "P2P";
            this.P2P.Name = "P2P";
            // 
            // Integral
            // 
            this.Integral.DataPropertyName = "Integral";
            this.Integral.HeaderText = "积分";
            this.Integral.Name = "Integral";
            // 
            // CS
            // 
            this.CS.DataPropertyName = "CS";
            this.CS.HeaderText = "赊销";
            this.CS.Name = "CS";
            // 
            // Other
            // 
            this.Other.DataPropertyName = "Other";
            this.Other.HeaderText = "异地代收";
            this.Other.Name = "Other";
            // 
            // PreRecv
            // 
            this.PreRecv.DataPropertyName = "PreRecv";
            this.PreRecv.HeaderText = "预收款";
            this.PreRecv.Name = "PreRecv";
            // 
            // InvoiceAmount
            // 
            this.InvoiceAmount.DataPropertyName = "InvoiceAmount";
            this.InvoiceAmount.HeaderText = "发票金额";
            this.InvoiceAmount.Name = "InvoiceAmount";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbDescribes);
            this.groupBox1.Controls.Add(this.cmbInType);
            this.groupBox1.Controls.Add(this.lblInType);
            this.groupBox1.Controls.Add(this.datBegin);
            this.groupBox1.Controls.Add(this.lblDescribes);
            this.groupBox1.Controls.Add(this.chbDH);
            this.groupBox1.Controls.Add(this.chbDescribes);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.datEnd);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 95);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // cmbDescribes
            // 
            this.cmbDescribes.DisplayMember = "Text";
            this.cmbDescribes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDescribes.FormattingEnabled = true;
            this.cmbDescribes.ItemHeight = 15;
            this.cmbDescribes.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem8,
            this.comboItem9});
            this.cmbDescribes.Location = new System.Drawing.Point(428, 24);
            this.cmbDescribes.Name = "cmbDescribes";
            this.cmbDescribes.Size = new System.Drawing.Size(121, 21);
            this.cmbDescribes.TabIndex = 31;
            this.cmbDescribes.Tag = "F0S1B0";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "销售订金";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "销售收款";
            // 
            // comboItem8
            // 
            this.comboItem8.Text = "销售装潢";
            // 
            // comboItem9
            // 
            this.comboItem9.Text = "售后";
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
            this.cmbInType.Location = new System.Drawing.Point(428, 57);
            this.cmbInType.Name = "cmbInType";
            this.cmbInType.Size = new System.Drawing.Size(121, 21);
            this.cmbInType.TabIndex = 30;
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
            this.lblInType.Location = new System.Drawing.Point(360, 60);
            this.lblInType.Name = "lblInType";
            this.lblInType.Size = new System.Drawing.Size(62, 18);
            this.lblInType.TabIndex = 29;
            this.lblInType.Text = " 收入种类";
            // 
            // datBegin
            // 
            this.datBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datBegin.Location = new System.Drawing.Point(89, 22);
            this.datBegin.Name = "datBegin";
            this.datBegin.Size = new System.Drawing.Size(108, 21);
            this.datBegin.TabIndex = 28;
            // 
            // lblDescribes
            // 
            this.lblDescribes.AutoSize = true;
            this.lblDescribes.Location = new System.Drawing.Point(360, 24);
            this.lblDescribes.Name = "lblDescribes";
            this.lblDescribes.Size = new System.Drawing.Size(62, 18);
            this.lblDescribes.TabIndex = 26;
            this.lblDescribes.Text = " 收款类型";
            // 
            // chbDH
            // 
            this.chbDH.Location = new System.Drawing.Point(157, 57);
            this.chbDH.Name = "chbDH";
            this.chbDH.Size = new System.Drawing.Size(75, 23);
            this.chbDH.TabIndex = 16;
            this.chbDH.Text = "单号";
            // 
            // chbDescribes
            // 
            this.chbDescribes.Location = new System.Drawing.Point(53, 58);
            this.chbDescribes.Name = "chbDescribes";
            this.chbDescribes.Size = new System.Drawing.Size(75, 23);
            this.chbDescribes.TabIndex = 15;
            this.chbDescribes.Text = "收款类型";
            this.chbDescribes.CheckValueChanged += new System.EventHandler(this.chbDescribes_CheckValueChanged);
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(53, 25);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(31, 18);
            this.labelX1.TabIndex = 14;
            this.labelX1.Text = "日期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "至";
            // 
            // datEnd
            // 
            this.datEnd.Checked = false;
            this.datEnd.CustomFormat = "";
            this.datEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datEnd.Location = new System.Drawing.Point(226, 22);
            this.datEnd.Name = "datEnd";
            this.datEnd.Size = new System.Drawing.Size(104, 21);
            this.datEnd.TabIndex = 12;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnQuery,
            this.btnOut});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(876, 25);
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
            // frmFStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 474);
            this.Controls.Add(this.dgAccount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmFStatistics";
            this.Text = "财务收款统计";
            this.Load += new System.EventHandler(this.frmFStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAccount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnQuery;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datEnd;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgAccount;
        private DevComponents.DotNetBar.Controls.CheckBoxX chbDH;
        private DevComponents.DotNetBar.Controls.CheckBoxX chbDescribes;
        private DevComponents.DotNetBar.LabelX lblDescribes;
        private System.Windows.Forms.DateTimePicker datBegin;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.ComboItem comboItem5;
        private DevComponents.Editors.ComboItem comboItem6;
        private DevComponents.Editors.ComboItem comboItem7;
        private DevComponents.DotNetBar.LabelX lblInType;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbInType;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbDescribes;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem8;
        private DevComponents.Editors.ComboItem comboItem9;
        private System.Windows.Forms.ToolStripButton btnOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn DH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn recamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cash;
        private System.Windows.Forms.DataGridViewTextBoxColumn bank;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn vip;
        private System.Windows.Forms.DataGridViewTextBoxColumn P2P;
        private System.Windows.Forms.DataGridViewTextBoxColumn Integral;
        private System.Windows.Forms.DataGridViewTextBoxColumn CS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Other;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreRecv;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceAmount;
    }
}