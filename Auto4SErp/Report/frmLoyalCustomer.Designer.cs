namespace Auto4SErp.Report
{
    partial class frmLoyalCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoyalCustomer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnQuery = new System.Windows.Forms.ToolStripButton();
            this.btnOut = new System.Windows.Forms.ToolStripButton();
            this.dgResult = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platenum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.itiCount = new DevComponents.Editors.IntegerInput();
            this.lblCount = new DevComponents.DotNetBar.LabelX();
            this.chbIsDate = new System.Windows.Forms.CheckBox();
            this.datBegin = new System.Windows.Forms.DateTimePicker();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.label1 = new System.Windows.Forms.Label();
            this.datEnd = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itiCount)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnQuery,
            this.btnOut});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(833, 25);
            this.toolStrip1.TabIndex = 40;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
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
            // dgResult
            // 
            this.dgResult.AllowUserToAddRows = false;
            this.dgResult.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.count,
            this.mobile,
            this.custname,
            this.platenum,
            this.Vin,
            this.AccountDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgResult.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgResult.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgResult.Location = new System.Drawing.Point(0, 109);
            this.dgResult.MultiSelect = false;
            this.dgResult.Name = "dgResult";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgResult.RowTemplate.Height = 23;
            this.dgResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgResult.Size = new System.Drawing.Size(833, 257);
            this.dgResult.TabIndex = 41;
            this.dgResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgResult_CellContentClick);
            this.dgResult.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgResult_RowPostPaint);
            // 
            // count
            // 
            this.count.DataPropertyName = "count";
            this.count.HeaderText = "次数";
            this.count.Name = "count";
            // 
            // mobile
            // 
            this.mobile.DataPropertyName = "mobile";
            this.mobile.HeaderText = "手机";
            this.mobile.Name = "mobile";
            // 
            // custname
            // 
            this.custname.DataPropertyName = "custname";
            this.custname.HeaderText = "顾客姓名";
            this.custname.Name = "custname";
            // 
            // platenum
            // 
            this.platenum.DataPropertyName = "platenum";
            this.platenum.HeaderText = "车牌号";
            this.platenum.Name = "platenum";
            // 
            // Vin
            // 
            this.Vin.DataPropertyName = "Vin";
            this.Vin.HeaderText = "Vin";
            this.Vin.Name = "Vin";
            // 
            // AccountDate
            // 
            this.AccountDate.DataPropertyName = "AccountDate";
            this.AccountDate.HeaderText = "本店购车时间";
            this.AccountDate.Name = "AccountDate";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.itiCount);
            this.groupBox1.Controls.Add(this.lblCount);
            this.groupBox1.Controls.Add(this.chbIsDate);
            this.groupBox1.Controls.Add(this.datBegin);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.datEnd);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 84);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(561, 60);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(235, 18);
            this.labelX2.TabIndex = 41;
            this.labelX2.Text = "注：默认显示12个月消费次数3以上的客户";
            // 
            // itiCount
            // 
            // 
            // 
            // 
            this.itiCount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.itiCount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.itiCount.Location = new System.Drawing.Point(475, 34);
            this.itiCount.Name = "itiCount";
            this.itiCount.ShowUpDown = true;
            this.itiCount.Size = new System.Drawing.Size(80, 21);
            this.itiCount.TabIndex = 40;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(413, 37);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(56, 18);
            this.lblCount.TabIndex = 39;
            this.lblCount.Text = "消费次数";
            // 
            // chbIsDate
            // 
            this.chbIsDate.AutoSize = true;
            this.chbIsDate.Location = new System.Drawing.Point(362, 39);
            this.chbIsDate.Name = "chbIsDate";
            this.chbIsDate.Size = new System.Drawing.Size(15, 14);
            this.chbIsDate.TabIndex = 38;
            this.chbIsDate.UseVisualStyleBackColor = true;
            // 
            // datBegin
            // 
            this.datBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datBegin.Location = new System.Drawing.Point(110, 36);
            this.datBegin.Name = "datBegin";
            this.datBegin.Size = new System.Drawing.Size(108, 21);
            this.datBegin.TabIndex = 32;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(48, 37);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(56, 18);
            this.labelX1.TabIndex = 31;
            this.labelX1.Text = "结算日期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 40);
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
            this.datEnd.Location = new System.Drawing.Point(247, 36);
            this.datEnd.Name = "datEnd";
            this.datEnd.Size = new System.Drawing.Size(104, 21);
            this.datEnd.TabIndex = 29;
            // 
            // frmLoyalCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 366);
            this.Controls.Add(this.dgResult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmLoyalCustomer";
            this.Text = "客户消费排行";
            this.Load += new System.EventHandler(this.frmLoyalCustomer_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itiCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnQuery;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.Editors.IntegerInput itiCount;
        private DevComponents.DotNetBar.LabelX lblCount;
        private System.Windows.Forms.CheckBox chbIsDate;
        private System.Windows.Forms.DateTimePicker datBegin;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datEnd;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.ToolStripButton btnOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn custname;
        private System.Windows.Forms.DataGridViewTextBoxColumn platenum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vin;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountDate;
    }
}