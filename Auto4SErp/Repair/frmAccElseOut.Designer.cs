namespace Auto4SErp.Repair
{
    partial class frmAccElseOut
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
            System.Windows.Forms.PictureBox btnCustomerFind;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccElseOut));
            this.dgAccessory = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.AccType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessorycode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessoryname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HouseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sum1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TakeMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TakeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XH1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbOutToUnit = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbOutType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblOutToUnit = new DevComponents.DotNetBar.LabelX();
            this.lblOutType = new DevComponents.DotNetBar.LabelX();
            this.txtCreateDate = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCreateDate = new DevComponents.DotNetBar.LabelX();
            this.txtDH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblDH = new DevComponents.DotNetBar.LabelX();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnRecede = new System.Windows.Forms.ToolStripButton();
            this.btnComplete = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnOut = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtSum = new System.Windows.Forms.ToolStripStatusLabel();
            btnCustomerFind = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(btnCustomerFind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccessory)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCustomerFind
            // 
            btnCustomerFind.BackgroundImage = global::Auto4SErp.Properties.Resources.supply;
            btnCustomerFind.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCustomerFind.Location = new System.Drawing.Point(249, 64);
            btnCustomerFind.Name = "btnCustomerFind";
            btnCustomerFind.Size = new System.Drawing.Size(24, 24);
            btnCustomerFind.TabIndex = 108;
            btnCustomerFind.TabStop = false;
            btnCustomerFind.Click += new System.EventHandler(this.btnCustomerFind_Click);
            // 
            // dgAccessory
            // 
            this.dgAccessory.AllowUserToAddRows = false;
            this.dgAccessory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAccessory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgAccessory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAccessory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccType,
            this.accessorycode,
            this.accessoryname,
            this.HouseName,
            this.Amount,
            this.SalePrice,
            this.sum1,
            this.TakeMan,
            this.TakeDate,
            this.XH1,
            this.status1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAccessory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgAccessory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAccessory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgAccessory.Location = new System.Drawing.Point(0, 130);
            this.dgAccessory.MultiSelect = false;
            this.dgAccessory.Name = "dgAccessory";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAccessory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgAccessory.RowTemplate.Height = 23;
            this.dgAccessory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAccessory.Size = new System.Drawing.Size(774, 289);
            this.dgAccessory.TabIndex = 47;
            // 
            // AccType
            // 
            this.AccType.DataPropertyName = "AccType";
            this.AccType.HeaderText = "状态";
            this.AccType.Name = "AccType";
            // 
            // accessorycode
            // 
            this.accessorycode.DataPropertyName = "accessorycode";
            this.accessorycode.HeaderText = "配件编码";
            this.accessorycode.Name = "accessorycode";
            // 
            // accessoryname
            // 
            this.accessoryname.DataPropertyName = "accessoryname";
            this.accessoryname.HeaderText = "配件名称";
            this.accessoryname.Name = "accessoryname";
            // 
            // HouseName
            // 
            this.HouseName.DataPropertyName = "HouseName";
            this.HouseName.HeaderText = "仓库";
            this.HouseName.Name = "HouseName";
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "数量";
            this.Amount.Name = "Amount";
            // 
            // SalePrice
            // 
            this.SalePrice.DataPropertyName = "SalePrice";
            this.SalePrice.HeaderText = "单价";
            this.SalePrice.Name = "SalePrice";
            // 
            // sum1
            // 
            this.sum1.DataPropertyName = "sum";
            this.sum1.HeaderText = "金额";
            this.sum1.Name = "sum1";
            // 
            // TakeMan
            // 
            this.TakeMan.DataPropertyName = "TakeMan";
            this.TakeMan.HeaderText = "领料人";
            this.TakeMan.Name = "TakeMan";
            // 
            // TakeDate
            // 
            this.TakeDate.DataPropertyName = "TakeDate";
            this.TakeDate.HeaderText = "时间";
            this.TakeDate.Name = "TakeDate";
            // 
            // XH1
            // 
            this.XH1.DataPropertyName = "XH";
            this.XH1.HeaderText = "批次";
            this.XH1.Name = "XH1";
            // 
            // status1
            // 
            this.status1.DataPropertyName = "status";
            this.status1.HeaderText = "是否退料";
            this.status1.Name = "status1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(btnCustomerFind);
            this.groupBox1.Controls.Add(this.cmbOutToUnit);
            this.groupBox1.Controls.Add(this.cmbOutType);
            this.groupBox1.Controls.Add(this.lblOutToUnit);
            this.groupBox1.Controls.Add(this.lblOutType);
            this.groupBox1.Controls.Add(this.txtCreateDate);
            this.groupBox1.Controls.Add(this.lblCreateDate);
            this.groupBox1.Controls.Add(this.txtDH);
            this.groupBox1.Controls.Add(this.lblDH);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(774, 105);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            // 
            // cmbOutToUnit
            // 
            this.cmbOutToUnit.DisplayMember = "Text";
            this.cmbOutToUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbOutToUnit.FormattingEnabled = true;
            this.cmbOutToUnit.ItemHeight = 15;
            this.cmbOutToUnit.Location = new System.Drawing.Point(118, 65);
            this.cmbOutToUnit.Name = "cmbOutToUnit";
            this.cmbOutToUnit.Size = new System.Drawing.Size(125, 21);
            this.cmbOutToUnit.TabIndex = 25;
            this.cmbOutToUnit.Tag = "N";
            // 
            // cmbOutType
            // 
            this.cmbOutType.DisplayMember = "Text";
            this.cmbOutType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbOutType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOutType.FormattingEnabled = true;
            this.cmbOutType.ItemHeight = 15;
            this.cmbOutType.Location = new System.Drawing.Point(564, 29);
            this.cmbOutType.Name = "cmbOutType";
            this.cmbOutType.Size = new System.Drawing.Size(125, 21);
            this.cmbOutType.TabIndex = 24;
            this.cmbOutType.Tag = "F1S1B0";
            // 
            // lblOutToUnit
            // 
            this.lblOutToUnit.AutoSize = true;
            this.lblOutToUnit.Location = new System.Drawing.Point(57, 68);
            this.lblOutToUnit.Name = "lblOutToUnit";
            this.lblOutToUnit.Size = new System.Drawing.Size(56, 18);
            this.lblOutToUnit.TabIndex = 17;
            this.lblOutToUnit.Text = "出库对象";
            // 
            // lblOutType
            // 
            this.lblOutType.AutoSize = true;
            this.lblOutType.Location = new System.Drawing.Point(502, 32);
            this.lblOutType.Name = "lblOutType";
            this.lblOutType.Size = new System.Drawing.Size(56, 18);
            this.lblOutType.TabIndex = 15;
            this.lblOutType.Text = "出库方式";
            // 
            // txtCreateDate
            // 
            // 
            // 
            // 
            this.txtCreateDate.Border.Class = "TextBoxBorder";
            this.txtCreateDate.Location = new System.Drawing.Point(341, 29);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.ReadOnly = true;
            this.txtCreateDate.Size = new System.Drawing.Size(124, 21);
            this.txtCreateDate.TabIndex = 14;
            this.txtCreateDate.Tag = "B1S1";
            // 
            // lblCreateDate
            // 
            this.lblCreateDate.AutoSize = true;
            this.lblCreateDate.Location = new System.Drawing.Point(279, 32);
            this.lblCreateDate.Name = "lblCreateDate";
            this.lblCreateDate.Size = new System.Drawing.Size(56, 18);
            this.lblCreateDate.TabIndex = 13;
            this.lblCreateDate.Text = "开单日期";
            // 
            // txtDH
            // 
            // 
            // 
            // 
            this.txtDH.Border.Class = "TextBoxBorder";
            this.txtDH.Location = new System.Drawing.Point(94, 29);
            this.txtDH.Name = "txtDH";
            this.txtDH.ReadOnly = true;
            this.txtDH.Size = new System.Drawing.Size(149, 21);
            this.txtDH.TabIndex = 12;
            this.txtDH.Tag = "B1S1";
            // 
            // lblDH
            // 
            this.lblDH.AutoSize = true;
            this.lblDH.Location = new System.Drawing.Point(57, 32);
            this.lblDH.Name = "lblDH";
            this.lblDH.Size = new System.Drawing.Size(31, 18);
            this.lblDH.TabIndex = 11;
            this.lblDH.Text = "单号";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnAdd,
            this.btnRecede,
            this.btnComplete,
            this.btnCancel,
            this.btnPrint,
            this.btnDelete,
            this.btnOut});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(774, 25);
            this.toolStrip1.TabIndex = 45;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(52, 22);
            this.btnSave.Tag = "save";
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 22);
            this.btnAdd.Tag = "add";
            this.btnAdd.Text = "增加配件";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRecede
            // 
            this.btnRecede.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRecede.Image = ((System.Drawing.Image)(resources.GetObject("btnRecede.Image")));
            this.btnRecede.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRecede.Name = "btnRecede";
            this.btnRecede.Size = new System.Drawing.Size(36, 22);
            this.btnRecede.Text = "退料";
            this.btnRecede.Click += new System.EventHandler(this.btnRecede_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnComplete.Image = ((System.Drawing.Image)(resources.GetObject("btnComplete.Image")));
            this.btnComplete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(36, 22);
            this.btnComplete.Text = "完成";
            this.btnComplete.Click += new System.EventHandler(this.btnCompelte_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(36, 22);
            this.btnCancel.Text = "撤销";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(52, 22);
            this.btnPrint.Tag = "print";
            this.btnPrint.Text = "打印";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(52, 22);
            this.btnDelete.Tag = "delete";
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOut
            // 
            this.btnOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOut.Image = ((System.Drawing.Image)(resources.GetObject("btnOut.Image")));
            this.btnOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(36, 22);
            this.btnOut.Text = "导出";
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txtSum});
            this.statusStrip1.Location = new System.Drawing.Point(0, 419);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(774, 22);
            this.statusStrip1.TabIndex = 48;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel1.Text = "总金额";
            // 
            // txtSum
            // 
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(15, 17);
            this.txtSum.Text = "0";
            // 
            // frmAccElseOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 441);
            this.Controls.Add(this.dgAccessory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmAccElseOut";
            this.Text = "其它出库";
            this.Load += new System.EventHandler(this.frmAccElseOut_Load);
            ((System.ComponentModel.ISupportInitialize)(btnCustomerFind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccessory)).EndInit();
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

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbOutToUnit;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbOutType;
        private DevComponents.DotNetBar.LabelX lblOutToUnit;
        private DevComponents.DotNetBar.LabelX lblOutType;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCreateDate;
        private DevComponents.DotNetBar.LabelX lblCreateDate;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDH;
        private DevComponents.DotNetBar.LabelX lblDH;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnComplete;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgAccessory;
        private System.Windows.Forms.ToolStripButton btnRecede;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccType;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessorycode;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessoryname;
        private System.Windows.Forms.DataGridViewTextBoxColumn HouseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn sum1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TakeMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TakeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn XH1;
        private System.Windows.Forms.DataGridViewTextBoxColumn status1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txtSum;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripButton btnOut;
    }
}