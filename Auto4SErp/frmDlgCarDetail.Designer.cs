namespace Auto4SErp
{
    partial class frmDlgCarDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDlgCarDetail));
            this.lblMinPrice = new DevComponents.DotNetBar.LabelX();
            this.lblSalePrice = new DevComponents.DotNetBar.LabelX();
            this.lblAllotPrice = new DevComponents.DotNetBar.LabelX();
            this.lblCostPrice = new DevComponents.DotNetBar.LabelX();
            this.lblInnerStyle = new DevComponents.DotNetBar.LabelX();
            this.lblTransmission = new DevComponents.DotNetBar.LabelX();
            this.lblDisplacement = new DevComponents.DotNetBar.LabelX();
            this.txtAutoNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblAutoNumber = new DevComponents.DotNetBar.LabelX();
            this.cmbInnerStyle = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnSave = new System.Windows.Forms.ToolStripButton();
            this.tbtnSel = new System.Windows.Forms.ToolStripButton();
            this.lblCarModel = new DevComponents.DotNetBar.LabelX();
            this.txtCarModel = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblColor = new DevComponents.DotNetBar.LabelX();
            this.lblCarOfYear = new DevComponents.DotNetBar.LabelX();
            this.dbiCostPrice = new DevComponents.Editors.DoubleInput();
            this.dbiAllotPrice = new DevComponents.Editors.DoubleInput();
            this.dbiSalePrice = new DevComponents.Editors.DoubleInput();
            this.dbiMinPrice = new DevComponents.Editors.DoubleInput();
            this.cmbColor = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbTransmission = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.cmbDisplacement = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem7 = new DevComponents.Editors.ComboItem();
            this.cmbCarOfYear = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.comboItem6 = new DevComponents.Editors.ComboItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbiCostPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbiAllotPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbiSalePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbiMinPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMinPrice
            // 
            this.lblMinPrice.Location = new System.Drawing.Point(264, 269);
            this.lblMinPrice.Name = "lblMinPrice";
            this.lblMinPrice.Size = new System.Drawing.Size(75, 23);
            this.lblMinPrice.TabIndex = 40;
            this.lblMinPrice.Text = "最低价";
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.Location = new System.Drawing.Point(46, 265);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(75, 23);
            this.lblSalePrice.TabIndex = 39;
            this.lblSalePrice.Text = "销售价";
            // 
            // lblAllotPrice
            // 
            this.lblAllotPrice.Location = new System.Drawing.Point(263, 222);
            this.lblAllotPrice.Name = "lblAllotPrice";
            this.lblAllotPrice.Size = new System.Drawing.Size(75, 19);
            this.lblAllotPrice.TabIndex = 38;
            this.lblAllotPrice.Text = "调拨价";
            // 
            // lblCostPrice
            // 
            this.lblCostPrice.Location = new System.Drawing.Point(46, 222);
            this.lblCostPrice.Name = "lblCostPrice";
            this.lblCostPrice.Size = new System.Drawing.Size(75, 19);
            this.lblCostPrice.TabIndex = 37;
            this.lblCostPrice.Text = "进货价";
            // 
            // lblInnerStyle
            // 
            this.lblInnerStyle.Location = new System.Drawing.Point(44, 133);
            this.lblInnerStyle.Name = "lblInnerStyle";
            this.lblInnerStyle.Size = new System.Drawing.Size(75, 23);
            this.lblInnerStyle.TabIndex = 35;
            this.lblInnerStyle.Text = "内饰风格";
            // 
            // lblTransmission
            // 
            this.lblTransmission.Location = new System.Drawing.Point(262, 90);
            this.lblTransmission.Name = "lblTransmission";
            this.lblTransmission.Size = new System.Drawing.Size(75, 23);
            this.lblTransmission.TabIndex = 33;
            this.lblTransmission.Text = "变速器";
            // 
            // lblDisplacement
            // 
            this.lblDisplacement.Location = new System.Drawing.Point(45, 89);
            this.lblDisplacement.Name = "lblDisplacement";
            this.lblDisplacement.Size = new System.Drawing.Size(75, 23);
            this.lblDisplacement.TabIndex = 31;
            this.lblDisplacement.Text = "排气量";
            // 
            // txtAutoNumber
            // 
            // 
            // 
            // 
            this.txtAutoNumber.Border.Class = "TextBoxBorder";
            this.txtAutoNumber.Location = new System.Drawing.Point(105, 44);
            this.txtAutoNumber.Name = "txtAutoNumber";
            this.txtAutoNumber.Size = new System.Drawing.Size(119, 21);
            this.txtAutoNumber.TabIndex = 24;
            this.txtAutoNumber.Tag = "N";
            // 
            // lblAutoNumber
            // 
            this.lblAutoNumber.ForeColor = System.Drawing.Color.Red;
            this.lblAutoNumber.Location = new System.Drawing.Point(44, 42);
            this.lblAutoNumber.Name = "lblAutoNumber";
            this.lblAutoNumber.Size = new System.Drawing.Size(75, 23);
            this.lblAutoNumber.TabIndex = 23;
            this.lblAutoNumber.Text = "自编号";
            // 
            // cmbInnerStyle
            // 
            this.cmbInnerStyle.DisplayMember = "Text";
            this.cmbInnerStyle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbInnerStyle.FormattingEnabled = true;
            this.cmbInnerStyle.ItemHeight = 15;
            this.cmbInnerStyle.Location = new System.Drawing.Point(104, 134);
            this.cmbInnerStyle.Name = "cmbInnerStyle";
            this.cmbInnerStyle.Size = new System.Drawing.Size(121, 21);
            this.cmbInnerStyle.TabIndex = 46;
            this.cmbInnerStyle.Tag = "Y";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnSave,
            this.tbtnSel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(493, 25);
            this.toolStrip1.TabIndex = 47;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnSave
            // 
            this.tbtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tbtnSave.Image")));
            this.tbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnSave.Name = "tbtnSave";
            this.tbtnSave.Size = new System.Drawing.Size(52, 22);
            this.tbtnSave.Text = "保存";
            this.tbtnSave.Click += new System.EventHandler(this.tbtnSave_Click);
            // 
            // tbtnSel
            // 
            this.tbtnSel.Image = global::Auto4SErp.Properties.Resources.select;
            this.tbtnSel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnSel.Name = "tbtnSel";
            this.tbtnSel.Size = new System.Drawing.Size(76, 22);
            this.tbtnSel.Text = "选择车型";
            this.tbtnSel.Click += new System.EventHandler(this.tbtnSel_Click);
            // 
            // lblCarModel
            // 
            this.lblCarModel.Location = new System.Drawing.Point(264, 44);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.Size = new System.Drawing.Size(75, 23);
            this.lblCarModel.TabIndex = 48;
            this.lblCarModel.Text = "车型";
            // 
            // txtCarModel
            // 
            // 
            // 
            // 
            this.txtCarModel.Border.Class = "TextBoxBorder";
            this.txtCarModel.Enabled = false;
            this.txtCarModel.Location = new System.Drawing.Point(322, 45);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(119, 21);
            this.txtCarModel.TabIndex = 49;
            this.txtCarModel.Tag = "N";
            // 
            // lblColor
            // 
            this.lblColor.Location = new System.Drawing.Point(263, 132);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(75, 23);
            this.lblColor.TabIndex = 50;
            this.lblColor.Text = "车身颜色";
            // 
            // lblCarOfYear
            // 
            this.lblCarOfYear.Location = new System.Drawing.Point(47, 179);
            this.lblCarOfYear.Name = "lblCarOfYear";
            this.lblCarOfYear.Size = new System.Drawing.Size(75, 23);
            this.lblCarOfYear.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.lblCarOfYear.TabIndex = 52;
            this.lblCarOfYear.Text = "年款";
            // 
            // dbiCostPrice
            // 
            // 
            // 
            // 
            this.dbiCostPrice.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dbiCostPrice.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.dbiCostPrice.Increment = 1D;
            this.dbiCostPrice.Location = new System.Drawing.Point(103, 220);
            this.dbiCostPrice.Name = "dbiCostPrice";
            this.dbiCostPrice.ShowUpDown = true;
            this.dbiCostPrice.Size = new System.Drawing.Size(123, 21);
            this.dbiCostPrice.TabIndex = 54;
            this.dbiCostPrice.Tag = "N";
            // 
            // dbiAllotPrice
            // 
            // 
            // 
            // 
            this.dbiAllotPrice.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dbiAllotPrice.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.dbiAllotPrice.Increment = 1D;
            this.dbiAllotPrice.Location = new System.Drawing.Point(324, 220);
            this.dbiAllotPrice.Name = "dbiAllotPrice";
            this.dbiAllotPrice.ShowUpDown = true;
            this.dbiAllotPrice.Size = new System.Drawing.Size(120, 21);
            this.dbiAllotPrice.TabIndex = 55;
            this.dbiAllotPrice.Tag = "N";
            // 
            // dbiSalePrice
            // 
            // 
            // 
            // 
            this.dbiSalePrice.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dbiSalePrice.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.dbiSalePrice.Increment = 1D;
            this.dbiSalePrice.Location = new System.Drawing.Point(103, 266);
            this.dbiSalePrice.Name = "dbiSalePrice";
            this.dbiSalePrice.ShowUpDown = true;
            this.dbiSalePrice.Size = new System.Drawing.Size(123, 21);
            this.dbiSalePrice.TabIndex = 56;
            this.dbiSalePrice.Tag = "N";
            // 
            // dbiMinPrice
            // 
            // 
            // 
            // 
            this.dbiMinPrice.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dbiMinPrice.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.dbiMinPrice.Increment = 1D;
            this.dbiMinPrice.Location = new System.Drawing.Point(324, 265);
            this.dbiMinPrice.Name = "dbiMinPrice";
            this.dbiMinPrice.ShowUpDown = true;
            this.dbiMinPrice.Size = new System.Drawing.Size(120, 21);
            this.dbiMinPrice.TabIndex = 57;
            this.dbiMinPrice.Tag = "N";
            // 
            // cmbColor
            // 
            this.cmbColor.DisplayMember = "Text";
            this.cmbColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.ItemHeight = 15;
            this.cmbColor.Location = new System.Drawing.Point(323, 133);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(121, 21);
            this.cmbColor.TabIndex = 58;
            this.cmbColor.Tag = "N";
            // 
            // cmbTransmission
            // 
            this.cmbTransmission.DisplayMember = "Text";
            this.cmbTransmission.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTransmission.FormattingEnabled = true;
            this.cmbTransmission.ItemHeight = 15;
            this.cmbTransmission.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.cmbTransmission.Location = new System.Drawing.Point(323, 90);
            this.cmbTransmission.Name = "cmbTransmission";
            this.cmbTransmission.Size = new System.Drawing.Size(121, 21);
            this.cmbTransmission.TabIndex = 59;
            this.cmbTransmission.Tag = "N";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "自动";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "手动";
            // 
            // cmbDisplacement
            // 
            this.cmbDisplacement.DisplayMember = "Text";
            this.cmbDisplacement.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDisplacement.FormattingEnabled = true;
            this.cmbDisplacement.ItemHeight = 15;
            this.cmbDisplacement.Items.AddRange(new object[] {
            this.comboItem3,
            this.comboItem4,
            this.comboItem7});
            this.cmbDisplacement.Location = new System.Drawing.Point(103, 90);
            this.cmbDisplacement.Name = "cmbDisplacement";
            this.cmbDisplacement.Size = new System.Drawing.Size(121, 21);
            this.cmbDisplacement.TabIndex = 60;
            this.cmbDisplacement.Tag = "N";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "1.4";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "1.6";
            // 
            // comboItem7
            // 
            this.comboItem7.Text = "2.0";
            // 
            // cmbCarOfYear
            // 
            this.cmbCarOfYear.DisplayMember = "Text";
            this.cmbCarOfYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCarOfYear.FormattingEnabled = true;
            this.cmbCarOfYear.ItemHeight = 15;
            this.cmbCarOfYear.Items.AddRange(new object[] {
            this.comboItem5,
            this.comboItem6});
            this.cmbCarOfYear.Location = new System.Drawing.Point(105, 178);
            this.cmbCarOfYear.Name = "cmbCarOfYear";
            this.cmbCarOfYear.Size = new System.Drawing.Size(121, 21);
            this.cmbCarOfYear.TabIndex = 61;
            this.cmbCarOfYear.Tag = "N";
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "2015";
            // 
            // comboItem6
            // 
            this.comboItem6.Text = "2014";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDlgCarDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 321);
            this.Controls.Add(this.cmbCarOfYear);
            this.Controls.Add(this.cmbDisplacement);
            this.Controls.Add(this.cmbTransmission);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.dbiMinPrice);
            this.Controls.Add(this.dbiSalePrice);
            this.Controls.Add(this.dbiAllotPrice);
            this.Controls.Add(this.dbiCostPrice);
            this.Controls.Add(this.lblCarOfYear);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.txtCarModel);
            this.Controls.Add(this.lblCarModel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cmbInnerStyle);
            this.Controls.Add(this.lblMinPrice);
            this.Controls.Add(this.lblSalePrice);
            this.Controls.Add(this.lblAllotPrice);
            this.Controls.Add(this.lblCostPrice);
            this.Controls.Add(this.lblInnerStyle);
            this.Controls.Add(this.lblTransmission);
            this.Controls.Add(this.lblDisplacement);
            this.Controls.Add(this.txtAutoNumber);
            this.Controls.Add(this.lblAutoNumber);
            this.Name = "frmDlgCarDetail";
            this.Text = "车辆资料编辑";
            this.Load += new System.EventHandler(this.frmDlgCarDetail_Load);
            this.Shown += new System.EventHandler(this.frmDlgCarDetail_Shown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbiCostPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbiAllotPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbiSalePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbiMinPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lblMinPrice;
        private DevComponents.DotNetBar.LabelX lblSalePrice;
        private DevComponents.DotNetBar.LabelX lblAllotPrice;
        private DevComponents.DotNetBar.LabelX lblCostPrice;
        private DevComponents.DotNetBar.LabelX lblInnerStyle;
        private DevComponents.DotNetBar.LabelX lblTransmission;
        private DevComponents.DotNetBar.LabelX lblDisplacement;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAutoNumber;
        private DevComponents.DotNetBar.LabelX lblAutoNumber;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbInnerStyle;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnSave;
        private System.Windows.Forms.ToolStripButton tbtnSel;
        private DevComponents.DotNetBar.LabelX lblCarModel;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCarModel;
        private DevComponents.DotNetBar.LabelX lblColor;
        private DevComponents.DotNetBar.LabelX lblCarOfYear;
        private DevComponents.Editors.DoubleInput dbiCostPrice;
        private DevComponents.Editors.DoubleInput dbiAllotPrice;
        private DevComponents.Editors.DoubleInput dbiSalePrice;
        private DevComponents.Editors.DoubleInput dbiMinPrice;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbColor;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbTransmission;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbDisplacement;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbCarOfYear;
        private DevComponents.Editors.ComboItem comboItem5;
        private DevComponents.Editors.ComboItem comboItem6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.Editors.ComboItem comboItem7;
    }
}