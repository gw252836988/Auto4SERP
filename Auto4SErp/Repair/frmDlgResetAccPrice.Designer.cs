﻿namespace Auto4SErp.Repair
{
    partial class frmDlgResetAccPrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDlgResetAccPrice));
            this.dgAccessory = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dbiSalePrice = new DevComponents.Editors.DoubleInput();
            this.txtSalePrice = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblSalePrice = new DevComponents.DotNetBar.LabelX();
            this.cmbDiscount = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem9 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.comboItem6 = new DevComponents.Editors.ComboItem();
            this.comboItem8 = new DevComponents.Editors.ComboItem();
            this.lblDiscount = new DevComponents.DotNetBar.LabelX();
            this.cmbPriceType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem7 = new DevComponents.Editors.ComboItem();
            this.comboItem10 = new DevComponents.Editors.ComboItem();
            this.lblPriceType = new DevComponents.DotNetBar.LabelX();
            this.txtAccName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblAccName = new DevComponents.DotNetBar.LabelX();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSure = new System.Windows.Forms.ToolStripButton();
            this.btnOK = new System.Windows.Forms.ToolStripButton();
            this.btnResetZero = new System.Windows.Forms.ToolStripButton();
            this.xxh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessorycode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessoryname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sum1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccessory)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbiSalePrice)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.xxh,
            this.AccType,
            this.accessorycode,
            this.accessoryname,
            this.Amount,
            this.SalePrice,
            this.sum1,
            this.FinalPrice,
            this.PriceType,
            this.Discount});
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
            this.dgAccessory.Location = new System.Drawing.Point(0, 118);
            this.dgAccessory.MultiSelect = false;
            this.dgAccessory.Name = "dgAccessory";
            this.dgAccessory.RowTemplate.Height = 23;
            this.dgAccessory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAccessory.Size = new System.Drawing.Size(841, 276);
            this.dgAccessory.TabIndex = 40;
            this.dgAccessory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAccessory_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.dbiSalePrice);
            this.groupBox1.Controls.Add(this.txtSalePrice);
            this.groupBox1.Controls.Add(this.lblSalePrice);
            this.groupBox1.Controls.Add(this.cmbDiscount);
            this.groupBox1.Controls.Add(this.lblDiscount);
            this.groupBox1.Controls.Add(this.cmbPriceType);
            this.groupBox1.Controls.Add(this.lblPriceType);
            this.groupBox1.Controls.Add(this.txtAccName);
            this.groupBox1.Controls.Add(this.lblAccName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(841, 93);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(413, 59);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(155, 18);
            this.labelX1.TabIndex = 24;
            this.labelX1.Text = "注：选择折扣后点批量打折";
            // 
            // dbiSalePrice
            // 
            // 
            // 
            // 
            this.dbiSalePrice.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dbiSalePrice.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.dbiSalePrice.Increment = 1D;
            this.dbiSalePrice.Location = new System.Drawing.Point(104, 56);
            this.dbiSalePrice.Name = "dbiSalePrice";
            this.dbiSalePrice.ShowUpDown = true;
            this.dbiSalePrice.Size = new System.Drawing.Size(124, 21);
            this.dbiSalePrice.TabIndex = 23;
            // 
            // txtSalePrice
            // 
            // 
            // 
            // 
            this.txtSalePrice.Border.Class = "TextBoxBorder";
            this.txtSalePrice.Location = new System.Drawing.Point(253, 55);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.ReadOnly = true;
            this.txtSalePrice.Size = new System.Drawing.Size(123, 21);
            this.txtSalePrice.TabIndex = 22;
            this.txtSalePrice.Tag = "N";
            this.txtSalePrice.Visible = false;
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.Location = new System.Drawing.Point(37, 58);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(62, 18);
            this.lblSalePrice.TabIndex = 21;
            this.lblSalePrice.Text = " 配件单价";
            // 
            // cmbDiscount
            // 
            this.cmbDiscount.DisplayMember = "Text";
            this.cmbDiscount.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cmbDiscount.FormattingEnabled = true;
            this.cmbDiscount.ItemHeight = 15;
            this.cmbDiscount.Items.AddRange(new object[] {
            this.comboItem9,
            this.comboItem2,
            this.comboItem3,
            this.comboItem4,
            this.comboItem5,
            this.comboItem6,
            this.comboItem8});
            this.cmbDiscount.Location = new System.Drawing.Point(449, 23);
            this.cmbDiscount.Name = "cmbDiscount";
            this.cmbDiscount.Size = new System.Drawing.Size(66, 21);
            this.cmbDiscount.TabIndex = 20;
            this.cmbDiscount.Tag = "N";
            // 
            // comboItem9
            // 
            this.comboItem9.Text = "100";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "95";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "90";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "85";
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "80";
            // 
            // comboItem6
            // 
            this.comboItem6.Text = "75";
            // 
            // comboItem8
            // 
            this.comboItem8.Text = "70";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(413, 25);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(31, 18);
            this.lblDiscount.TabIndex = 19;
            this.lblDiscount.Text = "折扣";
            // 
            // cmbPriceType
            // 
            this.cmbPriceType.DisplayMember = "Text";
            this.cmbPriceType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPriceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriceType.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cmbPriceType.FormattingEnabled = true;
            this.cmbPriceType.ItemHeight = 15;
            this.cmbPriceType.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem7,
            this.comboItem10});
            this.cmbPriceType.Location = new System.Drawing.Point(300, 23);
            this.cmbPriceType.Name = "cmbPriceType";
            this.cmbPriceType.Size = new System.Drawing.Size(76, 21);
            this.cmbPriceType.TabIndex = 18;
            this.cmbPriceType.Tag = "N";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "正常";
            // 
            // comboItem7
            // 
            this.comboItem7.Text = "索赔";
            // 
            // comboItem10
            // 
            this.comboItem10.Text = "免单";
            // 
            // lblPriceType
            // 
            this.lblPriceType.AutoSize = true;
            this.lblPriceType.Location = new System.Drawing.Point(265, 25);
            this.lblPriceType.Name = "lblPriceType";
            this.lblPriceType.Size = new System.Drawing.Size(31, 18);
            this.lblPriceType.TabIndex = 17;
            this.lblPriceType.Text = "价类";
            // 
            // txtAccName
            // 
            // 
            // 
            // 
            this.txtAccName.Border.Class = "TextBoxBorder";
            this.txtAccName.Location = new System.Drawing.Point(105, 23);
            this.txtAccName.Name = "txtAccName";
            this.txtAccName.ReadOnly = true;
            this.txtAccName.Size = new System.Drawing.Size(123, 21);
            this.txtAccName.TabIndex = 16;
            this.txtAccName.Tag = "N";
            // 
            // lblAccName
            // 
            this.lblAccName.AutoSize = true;
            this.lblAccName.Location = new System.Drawing.Point(44, 25);
            this.lblAccName.Name = "lblAccName";
            this.lblAccName.Size = new System.Drawing.Size(56, 18);
            this.lblAccName.TabIndex = 3;
            this.lblAccName.Text = "配件名称";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSure,
            this.btnOK,
            this.btnResetZero});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(841, 25);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSure
            // 
            this.btnSure.Image = ((System.Drawing.Image)(resources.GetObject("btnSure.Image")));
            this.btnSure.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSure.Name = "btnSure";
            this.btnSure.Size = new System.Drawing.Size(52, 22);
            this.btnSure.Tag = "ok";
            this.btnSure.Text = "确定";
            this.btnSure.Click += new System.EventHandler(this.btnSure_Click);
            // 
            // btnOK
            // 
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(76, 22);
            this.btnOK.Tag = "ok";
            this.btnOK.Text = "批量打折";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnResetZero
            // 
            this.btnResetZero.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnResetZero.Image = ((System.Drawing.Image)(resources.GetObject("btnResetZero.Image")));
            this.btnResetZero.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnResetZero.Name = "btnResetZero";
            this.btnResetZero.Size = new System.Drawing.Size(55, 22);
            this.btnResetZero.Text = "全部置0";
            this.btnResetZero.Click += new System.EventHandler(this.btnResetZero_Click);
            // 
            // xxh
            // 
            this.xxh.DataPropertyName = "xh";
            this.xxh.HeaderText = "序号";
            this.xxh.Name = "xxh";
            this.xxh.Width = 60;
            // 
            // AccType
            // 
            this.AccType.DataPropertyName = "AccType";
            this.AccType.HeaderText = "类型";
            this.AccType.Name = "AccType";
            this.AccType.Width = 80;
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
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "数量";
            this.Amount.Name = "Amount";
            this.Amount.Width = 80;
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
            this.sum1.Width = 80;
            // 
            // FinalPrice
            // 
            this.FinalPrice.DataPropertyName = "sum1";
            this.FinalPrice.HeaderText = "实际金额";
            this.FinalPrice.Name = "FinalPrice";
            this.FinalPrice.Width = 80;
            // 
            // PriceType
            // 
            this.PriceType.DataPropertyName = "PriceType";
            this.PriceType.HeaderText = "价类";
            this.PriceType.Name = "PriceType";
            this.PriceType.Width = 80;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "折扣";
            this.Discount.Name = "Discount";
            // 
            // frmDlgResetAccPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 394);
            this.Controls.Add(this.dgAccessory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmDlgResetAccPrice";
            this.Text = "配件价格重置";
            this.Load += new System.EventHandler(this.frmDlgResetAccPrice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAccessory)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbiSalePrice)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSalePrice;
        private DevComponents.DotNetBar.LabelX lblSalePrice;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbDiscount;
        private DevComponents.Editors.ComboItem comboItem9;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.ComboItem comboItem5;
        private DevComponents.Editors.ComboItem comboItem6;
        private DevComponents.Editors.ComboItem comboItem8;
        private DevComponents.DotNetBar.LabelX lblDiscount;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbPriceType;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem7;
        private DevComponents.DotNetBar.LabelX lblPriceType;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAccName;
        private DevComponents.DotNetBar.LabelX lblAccName;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgAccessory;
        private DevComponents.Editors.DoubleInput dbiSalePrice;
        private DevComponents.Editors.ComboItem comboItem10;
        private System.Windows.Forms.ToolStripButton btnResetZero;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.ToolStripButton btnSure;
        private System.Windows.Forms.DataGridViewTextBoxColumn xxh;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccType;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessorycode;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessoryname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn sum1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
    }
}