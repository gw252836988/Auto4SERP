namespace Auto4SErp.Report
{
    partial class frmRCarSale
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRCarSale));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dgCarSale = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.DH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarSer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCarSer = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCarSer = new DevComponents.DotNetBar.LabelX();
            this.datBegin = new System.Windows.Forms.DateTimePicker();
            this.datEnd = new System.Windows.Forms.DateTimePicker();
            this.chbIsDate = new System.Windows.Forms.CheckBox();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSaler = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblSaler = new DevComponents.DotNetBar.LabelX();
            this.cmbMonth = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cmbYear = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.lblInvoiceType = new DevComponents.DotNetBar.LabelX();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.tbtnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnOut = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblSum = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgCarSale)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgCarSale
            // 
            this.dgCarSale.AllowUserToAddRows = false;
            this.dgCarSale.AllowUserToDeleteRows = false;
            this.dgCarSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCarSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DH,
            this.SaleType,
            this.SaleMan,
            this.OrderDate,
            this.AccountDate,
            this.CustName,
            this.mobile,
            this.days,
            this.CarSer,
            this.CarModel,
            this.Vin,
            this.Color,
            this.TotalPrice,
            this.CarPrice});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCarSale.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgCarSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCarSale.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgCarSale.Location = new System.Drawing.Point(0, 133);
            this.dgCarSale.MultiSelect = false;
            this.dgCarSale.Name = "dgCarSale";
            this.dgCarSale.RowTemplate.Height = 23;
            this.dgCarSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCarSale.Size = new System.Drawing.Size(1031, 305);
            this.dgCarSale.TabIndex = 38;
            // 
            // DH
            // 
            this.DH.DataPropertyName = "DH";
            this.DH.HeaderText = "单号";
            this.DH.Name = "DH";
            // 
            // SaleType
            // 
            this.SaleType.DataPropertyName = "SaleType";
            this.SaleType.HeaderText = "销售类型";
            this.SaleType.Name = "SaleType";
            // 
            // SaleMan
            // 
            this.SaleMan.DataPropertyName = "SaleMan";
            this.SaleMan.HeaderText = "业务员";
            this.SaleMan.Name = "SaleMan";
            // 
            // OrderDate
            // 
            this.OrderDate.DataPropertyName = "OrderDate";
            this.OrderDate.HeaderText = "订单日期";
            this.OrderDate.Name = "OrderDate";
            // 
            // AccountDate
            // 
            this.AccountDate.DataPropertyName = "AccountDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.AccountDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.AccountDate.HeaderText = "结算日期";
            this.AccountDate.Name = "AccountDate";
            // 
            // CustName
            // 
            this.CustName.DataPropertyName = "CustName";
            this.CustName.HeaderText = "顾客";
            this.CustName.Name = "CustName";
            // 
            // mobile
            // 
            this.mobile.DataPropertyName = "mobile";
            this.mobile.HeaderText = "手机";
            this.mobile.Name = "mobile";
            // 
            // days
            // 
            this.days.DataPropertyName = "days";
            this.days.HeaderText = "库存天数";
            this.days.Name = "days";
            // 
            // CarSer
            // 
            this.CarSer.DataPropertyName = "CarSer";
            this.CarSer.HeaderText = "车系";
            this.CarSer.Name = "CarSer";
            // 
            // CarModel
            // 
            this.CarModel.DataPropertyName = "CarModel";
            this.CarModel.HeaderText = "车型";
            this.CarModel.Name = "CarModel";
            // 
            // Vin
            // 
            this.Vin.DataPropertyName = "Vin";
            this.Vin.HeaderText = "Vin";
            this.Vin.Name = "Vin";
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "颜色";
            this.Color.Name = "Color";
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "总价";
            this.TotalPrice.Name = "TotalPrice";
            // 
            // CarPrice
            // 
            this.CarPrice.DataPropertyName = "CarPrice";
            this.CarPrice.HeaderText = "车价";
            this.CarPrice.Name = "CarPrice";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCarSer);
            this.groupBox1.Controls.Add(this.lblCarSer);
            this.groupBox1.Controls.Add(this.datBegin);
            this.groupBox1.Controls.Add(this.datEnd);
            this.groupBox1.Controls.Add(this.chbIsDate);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSaler);
            this.groupBox1.Controls.Add(this.lblSaler);
            this.groupBox1.Controls.Add(this.cmbMonth);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.cmbYear);
            this.groupBox1.Controls.Add(this.lblInvoiceType);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1031, 108);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // txtCarSer
            // 
            // 
            // 
            // 
            this.txtCarSer.Border.Class = "TextBoxBorder";
            this.txtCarSer.Location = new System.Drawing.Point(288, 68);
            this.txtCarSer.Name = "txtCarSer";
            this.txtCarSer.Size = new System.Drawing.Size(113, 21);
            this.txtCarSer.TabIndex = 41;
            // 
            // lblCarSer
            // 
            this.lblCarSer.AutoSize = true;
            this.lblCarSer.Location = new System.Drawing.Point(238, 70);
            this.lblCarSer.Name = "lblCarSer";
            this.lblCarSer.Size = new System.Drawing.Size(44, 18);
            this.lblCarSer.TabIndex = 40;
            this.lblCarSer.Text = "车  系";
            // 
            // datBegin
            // 
            this.datBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datBegin.Location = new System.Drawing.Point(495, 30);
            this.datBegin.Name = "datBegin";
            this.datBegin.Size = new System.Drawing.Size(108, 21);
            this.datBegin.TabIndex = 39;
            // 
            // datEnd
            // 
            this.datEnd.Checked = false;
            this.datEnd.CustomFormat = "";
            this.datEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datEnd.Location = new System.Drawing.Point(632, 30);
            this.datEnd.Name = "datEnd";
            this.datEnd.Size = new System.Drawing.Size(104, 21);
            this.datEnd.TabIndex = 38;
            // 
            // chbIsDate
            // 
            this.chbIsDate.AutoSize = true;
            this.chbIsDate.Location = new System.Drawing.Point(749, 33);
            this.chbIsDate.Name = "chbIsDate";
            this.chbIsDate.Size = new System.Drawing.Size(15, 14);
            this.chbIsDate.TabIndex = 37;
            this.chbIsDate.UseVisualStyleBackColor = true;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(433, 32);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(56, 18);
            this.labelX2.TabIndex = 36;
            this.labelX2.Text = "结算日期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(609, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 35;
            this.label1.Text = "至";
            // 
            // txtSaler
            // 
            // 
            // 
            // 
            this.txtSaler.Border.Class = "TextBoxBorder";
            this.txtSaler.Location = new System.Drawing.Point(96, 68);
            this.txtSaler.Name = "txtSaler";
            this.txtSaler.Size = new System.Drawing.Size(113, 21);
            this.txtSaler.TabIndex = 20;
            // 
            // lblSaler
            // 
            this.lblSaler.AutoSize = true;
            this.lblSaler.Location = new System.Drawing.Point(46, 70);
            this.lblSaler.Name = "lblSaler";
            this.lblSaler.Size = new System.Drawing.Size(44, 18);
            this.lblSaler.TabIndex = 19;
            this.lblSaler.Text = "业务员";
            // 
            // cmbMonth
            // 
            this.cmbMonth.DisplayMember = "Text";
            this.cmbMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.ItemHeight = 15;
            this.cmbMonth.Location = new System.Drawing.Point(288, 31);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(113, 21);
            this.cmbMonth.TabIndex = 16;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(238, 33);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(44, 18);
            this.labelX1.TabIndex = 15;
            this.labelX1.Text = "月  份";
            // 
            // cmbYear
            // 
            this.cmbYear.DisplayMember = "Text";
            this.cmbYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.ItemHeight = 15;
            this.cmbYear.Items.AddRange(new object[] {
            this.comboItem4,
            this.comboItem1});
            this.cmbYear.Location = new System.Drawing.Point(96, 31);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(113, 21);
            this.cmbYear.TabIndex = 14;
            this.cmbYear.Text = "2015";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "2017";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "2016";
            // 
            // lblInvoiceType
            // 
            this.lblInvoiceType.AutoSize = true;
            this.lblInvoiceType.Location = new System.Drawing.Point(47, 33);
            this.lblInvoiceType.Name = "lblInvoiceType";
            this.lblInvoiceType.Size = new System.Drawing.Size(44, 18);
            this.lblInvoiceType.TabIndex = 13;
            this.lblInvoiceType.Text = "年  份";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQuery,
            this.tbtnOpen,
            this.btnOut});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1031, 25);
            this.toolStrip1.TabIndex = 40;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnQuery
            // 
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(52, 22);
            this.btnQuery.Tag = "query";
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSum});
            this.statusStrip1.Location = new System.Drawing.Point(0, 438);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1031, 22);
            this.statusStrip1.TabIndex = 41;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblSum
            // 
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(0, 17);
            // 
            // frmRCarSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 460);
            this.Controls.Add(this.dgCarSale);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmRCarSale";
            this.Text = "整车销售月报表";
            this.Load += new System.EventHandler(this.frmRCarSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCarSale)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgCarSale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolTip toolTip1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbMonth;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbYear;
        private DevComponents.DotNetBar.LabelX lblInvoiceType;
        private DevComponents.Editors.ComboItem comboItem1;
        private System.Windows.Forms.ToolStripButton btnOut;
        private DevComponents.Editors.ComboItem comboItem4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblSum;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSaler;
        private DevComponents.DotNetBar.LabelX lblSaler;
        private System.Windows.Forms.DateTimePicker datBegin;
        private System.Windows.Forms.DateTimePicker datEnd;
        private System.Windows.Forms.CheckBox chbIsDate;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCarSer;
        private DevComponents.DotNetBar.LabelX lblCarSer;
        private System.Windows.Forms.DataGridViewTextBoxColumn DH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn days;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarSer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarPrice;
        private System.Windows.Forms.ToolStripButton tbtnOpen;
    }
}