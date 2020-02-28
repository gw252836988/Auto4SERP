namespace Auto4SErp.Report
{
    partial class frmRRepDebt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRRepDebt));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnQuery = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datBegin = new System.Windows.Forms.DateTimePicker();
            this.datEnd = new System.Windows.Forms.DateTimePicker();
            this.cmbDateType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.comboItem6 = new DevComponents.Editors.ComboItem();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.label1 = new System.Windows.Forms.Label();
            this.dgAccount = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlateNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Describes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DHFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcceptDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiveMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceAmount1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblSum = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccount)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnQuery});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(783, 25);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datBegin);
            this.groupBox1.Controls.Add(this.datEnd);
            this.groupBox1.Controls.Add(this.cmbDateType);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 76);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // datBegin
            // 
            this.datBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datBegin.Location = new System.Drawing.Point(104, 31);
            this.datBegin.Name = "datBegin";
            this.datBegin.Size = new System.Drawing.Size(108, 21);
            this.datBegin.TabIndex = 32;
            // 
            // datEnd
            // 
            this.datEnd.Checked = false;
            this.datEnd.CustomFormat = "";
            this.datEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datEnd.Location = new System.Drawing.Point(241, 31);
            this.datEnd.Name = "datEnd";
            this.datEnd.Size = new System.Drawing.Size(104, 21);
            this.datEnd.TabIndex = 31;
            // 
            // cmbDateType
            // 
            this.cmbDateType.DisplayMember = "Text";
            this.cmbDateType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDateType.FormattingEnabled = true;
            this.cmbDateType.ItemHeight = 15;
            this.cmbDateType.Items.AddRange(new object[] {
            this.comboItem5,
            this.comboItem6});
            this.cmbDateType.Location = new System.Drawing.Point(367, 31);
            this.cmbDateType.Name = "cmbDateType";
            this.cmbDateType.Size = new System.Drawing.Size(99, 21);
            this.cmbDateType.TabIndex = 26;
            this.cmbDateType.Tag = "F0S0B1";
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "提交日期";
            // 
            // comboItem6
            // 
            this.comboItem6.Text = "收款日期";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(68, 33);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(31, 18);
            this.labelX1.TabIndex = 14;
            this.labelX1.Text = "日期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "至";
            // 
            // dgAccount
            // 
            this.dgAccount.AllowUserToAddRows = false;
            this.dgAccount.AllowUserToDeleteRows = false;
            this.dgAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Status,
            this.CustName,
            this.Mobile,
            this.PlateNum,
            this.Describes,
            this.Amount,
            this.RecAmount,
            this.DHFrom,
            this.AccountDate,
            this.AcceptDate,
            this.ReceiveMan,
            this.sc,
            this.InvoiceNum,
            this.InvoiceAmount1});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAccount.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAccount.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgAccount.Location = new System.Drawing.Point(0, 101);
            this.dgAccount.MultiSelect = false;
            this.dgAccount.Name = "dgAccount";
            this.dgAccount.RowTemplate.Height = 23;
            this.dgAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAccount.Size = new System.Drawing.Size(783, 268);
            this.dgAccount.TabIndex = 41;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "编号";
            this.ID.Name = "ID";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "状态";
            this.Status.Name = "Status";
            // 
            // CustName
            // 
            this.CustName.DataPropertyName = "CustName";
            this.CustName.HeaderText = "顾客姓名";
            this.CustName.Name = "CustName";
            // 
            // Mobile
            // 
            this.Mobile.DataPropertyName = "Mobile";
            this.Mobile.HeaderText = "手机";
            this.Mobile.Name = "Mobile";
            // 
            // PlateNum
            // 
            this.PlateNum.DataPropertyName = "Plate";
            this.PlateNum.HeaderText = "车牌号";
            this.PlateNum.Name = "PlateNum";
            // 
            // Describes
            // 
            this.Describes.DataPropertyName = "Describes";
            this.Describes.HeaderText = "收款类型";
            this.Describes.Name = "Describes";
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "应收金额";
            this.Amount.Name = "Amount";
            // 
            // RecAmount
            // 
            this.RecAmount.DataPropertyName = "RecAmount";
            this.RecAmount.HeaderText = "实收金额";
            this.RecAmount.Name = "RecAmount";
            // 
            // DHFrom
            // 
            this.DHFrom.DataPropertyName = "DHFrom";
            this.DHFrom.HeaderText = "来源单号";
            this.DHFrom.Name = "DHFrom";
            // 
            // AccountDate
            // 
            this.AccountDate.DataPropertyName = "AccountDate";
            this.AccountDate.HeaderText = "提交日期";
            this.AccountDate.Name = "AccountDate";
            // 
            // AcceptDate
            // 
            this.AcceptDate.DataPropertyName = "AcceptDate";
            this.AcceptDate.HeaderText = "收款日期";
            this.AcceptDate.Name = "AcceptDate";
            // 
            // ReceiveMan
            // 
            this.ReceiveMan.DataPropertyName = "ReceiveMan";
            this.ReceiveMan.HeaderText = "收款人";
            this.ReceiveMan.Name = "ReceiveMan";
            // 
            // sc
            // 
            this.sc.DataPropertyName = "cs";
            this.sc.HeaderText = "赊销";
            this.sc.Name = "sc";
            // 
            // InvoiceNum
            // 
            this.InvoiceNum.DataPropertyName = "InvoiceNum";
            this.InvoiceNum.HeaderText = "发票号";
            this.InvoiceNum.Name = "InvoiceNum";
            // 
            // InvoiceAmount1
            // 
            this.InvoiceAmount1.DataPropertyName = "InvoiceAmount";
            this.InvoiceAmount1.HeaderText = "发票金额";
            this.InvoiceAmount1.Name = "InvoiceAmount1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSum,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 347);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(783, 22);
            this.statusStrip1.TabIndex = 42;
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
            // frmRRepDebt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 369);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgAccount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmRRepDebt";
            this.Text = "售后赊销统计";
            this.Load += new System.EventHandler(this.frmRRepDebt_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccount)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnQuery;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker datBegin;
        private System.Windows.Forms.DateTimePicker datEnd;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbDateType;
        private DevComponents.Editors.ComboItem comboItem5;
        private DevComponents.Editors.ComboItem comboItem6;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlateNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Describes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DHFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcceptDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiveMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn sc;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceAmount1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblSum;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}