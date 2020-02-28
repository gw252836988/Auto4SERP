namespace Auto4SErp.Repair
{
    partial class frmDlgResetItemPrice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDlgResetItemPrice));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtItemPrice = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
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
            this.txtItemName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblItemName = new DevComponents.DotNetBar.LabelX();
            this.dgRepairItem = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.XH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemtotalprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOK = new System.Windows.Forms.ToolStripButton();
            this.btnBachDis = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRepairItem)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtItemPrice);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.cmbDiscount);
            this.groupBox1.Controls.Add(this.lblDiscount);
            this.groupBox1.Controls.Add(this.cmbPriceType);
            this.groupBox1.Controls.Add(this.lblPriceType);
            this.groupBox1.Controls.Add(this.txtItemName);
            this.groupBox1.Controls.Add(this.lblItemName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(771, 103);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // txtItemPrice
            // 
            // 
            // 
            // 
            this.txtItemPrice.Border.Class = "TextBoxBorder";
            this.txtItemPrice.Location = new System.Drawing.Point(105, 63);
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.ReadOnly = true;
            this.txtItemPrice.Size = new System.Drawing.Size(123, 21);
            this.txtItemPrice.TabIndex = 22;
            this.txtItemPrice.Tag = "N";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(43, 66);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(56, 18);
            this.labelX1.TabIndex = 21;
            this.labelX1.Text = "工时金额";
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
            this.lblDiscount.Location = new System.Drawing.Point(412, 25);
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
            this.lblPriceType.Location = new System.Drawing.Point(263, 25);
            this.lblPriceType.Name = "lblPriceType";
            this.lblPriceType.Size = new System.Drawing.Size(31, 18);
            this.lblPriceType.TabIndex = 17;
            this.lblPriceType.Text = "价类";
            // 
            // txtItemName
            // 
            // 
            // 
            // 
            this.txtItemName.Border.Class = "TextBoxBorder";
            this.txtItemName.Location = new System.Drawing.Point(105, 23);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.ReadOnly = true;
            this.txtItemName.Size = new System.Drawing.Size(123, 21);
            this.txtItemName.TabIndex = 16;
            this.txtItemName.Tag = "N";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(44, 26);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(56, 18);
            this.lblItemName.TabIndex = 3;
            this.lblItemName.Text = "维修项目";
            // 
            // dgRepairItem
            // 
            this.dgRepairItem.AllowUserToAddRows = false;
            this.dgRepairItem.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRepairItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgRepairItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRepairItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.XH,
            this.ItemCode,
            this.itemname,
            this.PriceType,
            this.itemtotalprice,
            this.Discount,
            this.FinalPrice});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgRepairItem.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgRepairItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgRepairItem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgRepairItem.Location = new System.Drawing.Point(0, 128);
            this.dgRepairItem.Name = "dgRepairItem";
            this.dgRepairItem.ReadOnly = true;
            this.dgRepairItem.RowTemplate.Height = 23;
            this.dgRepairItem.Size = new System.Drawing.Size(771, 239);
            this.dgRepairItem.TabIndex = 20;
            this.dgRepairItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRepairItem_CellClick);
            // 
            // XH
            // 
            this.XH.DataPropertyName = "XH";
            this.XH.HeaderText = "序号";
            this.XH.Name = "XH";
            this.XH.ReadOnly = true;
            // 
            // ItemCode
            // 
            this.ItemCode.DataPropertyName = "ItemCode";
            this.ItemCode.HeaderText = "项目编码";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            // 
            // itemname
            // 
            this.itemname.DataPropertyName = "ItemName";
            this.itemname.HeaderText = "项目名称";
            this.itemname.Name = "itemname";
            this.itemname.ReadOnly = true;
            // 
            // PriceType
            // 
            this.PriceType.DataPropertyName = "PriceType";
            this.PriceType.HeaderText = "价类";
            this.PriceType.Name = "PriceType";
            this.PriceType.ReadOnly = true;
            // 
            // itemtotalprice
            // 
            this.itemtotalprice.DataPropertyName = "ItemTotalPrice";
            this.itemtotalprice.HeaderText = "工时金额";
            this.itemtotalprice.Name = "itemtotalprice";
            this.itemtotalprice.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "折扣";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // FinalPrice
            // 
            this.FinalPrice.DataPropertyName = "FinalPrice";
            this.FinalPrice.HeaderText = "实际金额";
            this.FinalPrice.Name = "FinalPrice";
            this.FinalPrice.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOK,
            this.btnBachDis});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(771, 25);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnOK
            // 
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(52, 22);
            this.btnOK.Tag = "ok";
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnBachDis
            // 
            this.btnBachDis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnBachDis.Image = ((System.Drawing.Image)(resources.GetObject("btnBachDis.Image")));
            this.btnBachDis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBachDis.Name = "btnBachDis";
            this.btnBachDis.Size = new System.Drawing.Size(60, 22);
            this.btnBachDis.Text = "批量打折";
            this.btnBachDis.Click += new System.EventHandler(this.btnBachDis_Click);
            // 
            // frmDlgResetItemPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 367);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgRepairItem);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmDlgResetItemPrice";
            this.Text = "项目价格重置";
            this.Load += new System.EventHandler(this.frmDlgResetItemPrice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRepairItem)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgRepairItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.LabelX lblItemName;
        private DevComponents.DotNetBar.LabelX lblPriceType;
        private DevComponents.DotNetBar.Controls.TextBoxX txtItemName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtItemPrice;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbDiscount;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.DotNetBar.LabelX lblDiscount;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbPriceType;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem7;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.ComboItem comboItem5;
        private DevComponents.Editors.ComboItem comboItem6;
        private DevComponents.Editors.ComboItem comboItem8;
        private System.Windows.Forms.ToolStripButton btnOK;
        private DevComponents.Editors.ComboItem comboItem9;
        private System.Windows.Forms.ToolStripButton btnBachDis;
        private DevComponents.Editors.ComboItem comboItem10;
        private System.Windows.Forms.DataGridViewTextBoxColumn XH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemname;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemtotalprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalPrice;
    }
}