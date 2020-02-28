namespace Auto4SErp.Report
{
    partial class frmP2PStatistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmP2PStatistics));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnQuery = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMobile = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.datBegin = new System.Windows.Forms.DateTimePicker();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.label1 = new System.Windows.Forms.Label();
            this.datEnd = new System.Windows.Forms.DateTimePicker();
            this.dgAccount = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DHFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VirtualMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Append = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnQuery});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(781, 25);
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
            this.groupBox1.Controls.Add(this.txtMobile);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.datBegin);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.datEnd);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 71);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // txtMobile
            // 
            // 
            // 
            // 
            this.txtMobile.Border.Class = "TextBoxBorder";
            this.txtMobile.Location = new System.Drawing.Point(441, 29);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(120, 21);
            this.txtMobile.TabIndex = 58;
            this.txtMobile.Tag = "B1S1";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(391, 33);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(44, 18);
            this.labelX2.TabIndex = 29;
            this.labelX2.Text = "手机号";
            // 
            // datBegin
            // 
            this.datBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datBegin.Location = new System.Drawing.Point(99, 29);
            this.datBegin.Name = "datBegin";
            this.datBegin.Size = new System.Drawing.Size(108, 21);
            this.datBegin.TabIndex = 28;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(47, 31);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(44, 18);
            this.labelX1.TabIndex = 14;
            this.labelX1.Text = "日  期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 33);
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
            this.datEnd.Location = new System.Drawing.Point(236, 29);
            this.datEnd.Name = "datEnd";
            this.datEnd.Size = new System.Drawing.Size(104, 21);
            this.datEnd.TabIndex = 12;
            // 
            // dgAccount
            // 
            this.dgAccount.AllowUserToAddRows = false;
            this.dgAccount.AllowUserToDeleteRows = false;
            this.dgAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mobile,
            this.RecDate,
            this.RecUnit,
            this.DHFrom,
            this.CustName,
            this.PayType,
            this.Amount,
            this.balance,
            this.VirtualMoney,
            this.Append});
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
            this.dgAccount.Location = new System.Drawing.Point(0, 96);
            this.dgAccount.MultiSelect = false;
            this.dgAccount.Name = "dgAccount";
            this.dgAccount.RowTemplate.Height = 23;
            this.dgAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAccount.Size = new System.Drawing.Size(781, 316);
            this.dgAccount.TabIndex = 42;
            // 
            // Mobile
            // 
            this.Mobile.DataPropertyName = "Mobile";
            this.Mobile.HeaderText = "手机";
            this.Mobile.Name = "Mobile";
            // 
            // RecDate
            // 
            this.RecDate.DataPropertyName = "RecDate";
            this.RecDate.HeaderText = "日期";
            this.RecDate.Name = "RecDate";
            // 
            // RecUnit
            // 
            this.RecUnit.DataPropertyName = "RecUnit";
            this.RecUnit.HeaderText = "收款单位";
            this.RecUnit.Name = "RecUnit";
            // 
            // DHFrom
            // 
            this.DHFrom.DataPropertyName = "DHFrom";
            this.DHFrom.HeaderText = "收款单号";
            this.DHFrom.Name = "DHFrom";
            // 
            // CustName
            // 
            this.CustName.DataPropertyName = "CustName";
            this.CustName.HeaderText = "客户名称";
            this.CustName.Name = "CustName";
            // 
            // PayType
            // 
            this.PayType.DataPropertyName = "PayType";
            this.PayType.HeaderText = "支付方式";
            this.PayType.Name = "PayType";
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "扣除金额";
            this.Amount.Name = "Amount";
            // 
            // balance
            // 
            this.balance.DataPropertyName = "balance";
            this.balance.HeaderText = "余额支付";
            this.balance.Name = "balance";
            // 
            // VirtualMoney
            // 
            this.VirtualMoney.DataPropertyName = "VirtualMoney";
            this.VirtualMoney.HeaderText = "新城币";
            this.VirtualMoney.Name = "VirtualMoney";
            // 
            // Append
            // 
            this.Append.DataPropertyName = "Append";
            this.Append.HeaderText = "附加";
            this.Append.Name = "Append";
            // 
            // frmP2PStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 412);
            this.Controls.Add(this.dgAccount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmP2PStatistics";
            this.Text = "P2P统计";
            this.Load += new System.EventHandler(this.frmP2PStatistics_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnQuery;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker datBegin;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datEnd;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DHFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn VirtualMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn Append;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMobile;
    }
}