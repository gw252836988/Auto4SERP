namespace Auto4SErp.Sale
{
    partial class frmDlgCarInD
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
            System.Windows.Forms.PictureBox btnCarDocSel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDlgCarInD));
            this.txtVin = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblVin = new DevComponents.DotNetBar.LabelX();
            this.cmbStorePlace = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblStorePlace = new DevComponents.DotNetBar.LabelX();
            this.lblInPrice = new DevComponents.DotNetBar.LabelX();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnOK = new System.Windows.Forms.ToolStripButton();
            this.cmbCarOfYear = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.comboItem6 = new DevComponents.Editors.ComboItem();
            this.cmbDisplacement = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem7 = new DevComponents.Editors.ComboItem();
            this.cmbTransmission = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.cmbColor = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblCarOfYear = new DevComponents.DotNetBar.LabelX();
            this.lblColor = new DevComponents.DotNetBar.LabelX();
            this.cmbInnerStyle = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblInnerStyle = new DevComponents.DotNetBar.LabelX();
            this.lblTransmission = new DevComponents.DotNetBar.LabelX();
            this.lblDisplacement = new DevComponents.DotNetBar.LabelX();
            this.txtCarSer = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCarSer = new DevComponents.DotNetBar.LabelX();
            this.txtCarbrand = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCarBrand = new DevComponents.DotNetBar.LabelX();
            this.txtCarModel = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCarModel = new DevComponents.DotNetBar.LabelX();
            this.txtAutoNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblAutoNumber = new DevComponents.DotNetBar.LabelX();
            this.txtInPrice = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDirectPrice = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblDirectPrice = new DevComponents.DotNetBar.LabelX();
            btnCarDocSel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(btnCarDocSel)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCarDocSel
            // 
            btnCarDocSel.BackgroundImage = global::Auto4SErp.Properties.Resources.smallquery;
            btnCarDocSel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnCarDocSel.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCarDocSel.Location = new System.Drawing.Point(195, 41);
            btnCarDocSel.Name = "btnCarDocSel";
            btnCarDocSel.Size = new System.Drawing.Size(16, 16);
            btnCarDocSel.TabIndex = 90;
            btnCarDocSel.TabStop = false;
            btnCarDocSel.Click += new System.EventHandler(this.btnCarDocSel_Click);
            // 
            // txtVin
            // 
            // 
            // 
            // 
            this.txtVin.Border.Class = "TextBoxBorder";
            this.txtVin.Location = new System.Drawing.Point(296, 215);
            this.txtVin.Name = "txtVin";
            this.txtVin.Size = new System.Drawing.Size(108, 21);
            this.txtVin.TabIndex = 78;
            this.txtVin.Tag = "N";
            // 
            // lblVin
            // 
            this.lblVin.AutoSize = true;
            this.lblVin.Location = new System.Drawing.Point(246, 219);
            this.lblVin.Name = "lblVin";
            this.lblVin.Size = new System.Drawing.Size(44, 18);
            this.lblVin.TabIndex = 77;
            this.lblVin.Text = "VIN 码";
            // 
            // cmbStorePlace
            // 
            this.cmbStorePlace.DisplayMember = "Text";
            this.cmbStorePlace.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStorePlace.FormattingEnabled = true;
            this.cmbStorePlace.ItemHeight = 15;
            this.cmbStorePlace.Location = new System.Drawing.Point(294, 180);
            this.cmbStorePlace.Name = "cmbStorePlace";
            this.cmbStorePlace.Size = new System.Drawing.Size(110, 21);
            this.cmbStorePlace.TabIndex = 76;
            this.cmbStorePlace.Tag = "N";
            // 
            // lblStorePlace
            // 
            this.lblStorePlace.AutoSize = true;
            this.lblStorePlace.Location = new System.Drawing.Point(234, 181);
            this.lblStorePlace.Name = "lblStorePlace";
            this.lblStorePlace.Size = new System.Drawing.Size(56, 18);
            this.lblStorePlace.TabIndex = 75;
            this.lblStorePlace.Text = "存放位置";
            // 
            // lblInPrice
            // 
            this.lblInPrice.AutoSize = true;
            this.lblInPrice.Location = new System.Drawing.Point(19, 219);
            this.lblInPrice.Name = "lblInPrice";
            this.lblInPrice.Size = new System.Drawing.Size(56, 18);
            this.lblInPrice.TabIndex = 73;
            this.lblInPrice.Text = "进 货 价";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnOK});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(424, 25);
            this.toolStrip1.TabIndex = 72;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnOK
            // 
            this.tbtnOK.Image = ((System.Drawing.Image)(resources.GetObject("tbtnOK.Image")));
            this.tbtnOK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnOK.Name = "tbtnOK";
            this.tbtnOK.Size = new System.Drawing.Size(52, 22);
            this.tbtnOK.Tag = "ok";
            this.tbtnOK.Text = "确定";
            this.tbtnOK.Click += new System.EventHandler(this.tbtnOK_Click);
            // 
            // cmbCarOfYear
            // 
            this.cmbCarOfYear.DisplayMember = "Text";
            this.cmbCarOfYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCarOfYear.Enabled = false;
            this.cmbCarOfYear.FormattingEnabled = true;
            this.cmbCarOfYear.ItemHeight = 15;
            this.cmbCarOfYear.Items.AddRange(new object[] {
            this.comboItem5,
            this.comboItem6});
            this.cmbCarOfYear.Location = new System.Drawing.Point(82, 181);
            this.cmbCarOfYear.Name = "cmbCarOfYear";
            this.cmbCarOfYear.Size = new System.Drawing.Size(107, 21);
            this.cmbCarOfYear.TabIndex = 71;
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
            // cmbDisplacement
            // 
            this.cmbDisplacement.DisplayMember = "Text";
            this.cmbDisplacement.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDisplacement.Enabled = false;
            this.cmbDisplacement.FormattingEnabled = true;
            this.cmbDisplacement.ItemHeight = 15;
            this.cmbDisplacement.Items.AddRange(new object[] {
            this.comboItem3,
            this.comboItem4,
            this.comboItem7});
            this.cmbDisplacement.Location = new System.Drawing.Point(82, 109);
            this.cmbDisplacement.Name = "cmbDisplacement";
            this.cmbDisplacement.Size = new System.Drawing.Size(107, 21);
            this.cmbDisplacement.TabIndex = 70;
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
            // cmbTransmission
            // 
            this.cmbTransmission.DisplayMember = "Text";
            this.cmbTransmission.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTransmission.Enabled = false;
            this.cmbTransmission.FormattingEnabled = true;
            this.cmbTransmission.ItemHeight = 15;
            this.cmbTransmission.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.cmbTransmission.Location = new System.Drawing.Point(296, 108);
            this.cmbTransmission.Name = "cmbTransmission";
            this.cmbTransmission.Size = new System.Drawing.Size(108, 21);
            this.cmbTransmission.TabIndex = 69;
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
            // cmbColor
            // 
            this.cmbColor.DisplayMember = "Text";
            this.cmbColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbColor.Enabled = false;
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.ItemHeight = 15;
            this.cmbColor.Location = new System.Drawing.Point(296, 144);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(108, 21);
            this.cmbColor.TabIndex = 68;
            this.cmbColor.Tag = "N";
            // 
            // lblCarOfYear
            // 
            this.lblCarOfYear.AutoSize = true;
            this.lblCarOfYear.Location = new System.Drawing.Point(32, 182);
            this.lblCarOfYear.Name = "lblCarOfYear";
            this.lblCarOfYear.Size = new System.Drawing.Size(44, 18);
            this.lblCarOfYear.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.lblCarOfYear.TabIndex = 67;
            this.lblCarOfYear.Text = "年  款";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(234, 144);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(56, 18);
            this.lblColor.TabIndex = 66;
            this.lblColor.Text = "车身颜色";
            // 
            // cmbInnerStyle
            // 
            this.cmbInnerStyle.DisplayMember = "Text";
            this.cmbInnerStyle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbInnerStyle.Enabled = false;
            this.cmbInnerStyle.FormattingEnabled = true;
            this.cmbInnerStyle.ItemHeight = 15;
            this.cmbInnerStyle.Location = new System.Drawing.Point(81, 146);
            this.cmbInnerStyle.Name = "cmbInnerStyle";
            this.cmbInnerStyle.Size = new System.Drawing.Size(108, 21);
            this.cmbInnerStyle.TabIndex = 65;
            this.cmbInnerStyle.Tag = "N";
            // 
            // lblInnerStyle
            // 
            this.lblInnerStyle.AutoSize = true;
            this.lblInnerStyle.Location = new System.Drawing.Point(23, 148);
            this.lblInnerStyle.Name = "lblInnerStyle";
            this.lblInnerStyle.Size = new System.Drawing.Size(56, 18);
            this.lblInnerStyle.TabIndex = 64;
            this.lblInnerStyle.Text = "内饰风格";
            // 
            // lblTransmission
            // 
            this.lblTransmission.AutoSize = true;
            this.lblTransmission.Location = new System.Drawing.Point(234, 110);
            this.lblTransmission.Name = "lblTransmission";
            this.lblTransmission.Size = new System.Drawing.Size(56, 18);
            this.lblTransmission.TabIndex = 63;
            this.lblTransmission.Text = "变 速 器";
            // 
            // lblDisplacement
            // 
            this.lblDisplacement.AutoSize = true;
            this.lblDisplacement.Location = new System.Drawing.Point(20, 112);
            this.lblDisplacement.Name = "lblDisplacement";
            this.lblDisplacement.Size = new System.Drawing.Size(56, 18);
            this.lblDisplacement.TabIndex = 62;
            this.lblDisplacement.Text = "排 气 量";
            // 
            // txtCarSer
            // 
            // 
            // 
            // 
            this.txtCarSer.Border.Class = "TextBoxBorder";
            this.txtCarSer.Enabled = false;
            this.txtCarSer.Location = new System.Drawing.Point(81, 74);
            this.txtCarSer.Name = "txtCarSer";
            this.txtCarSer.Size = new System.Drawing.Size(108, 21);
            this.txtCarSer.TabIndex = 57;
            this.txtCarSer.Tag = "N";
            // 
            // lblCarSer
            // 
            this.lblCarSer.AutoSize = true;
            this.lblCarSer.Location = new System.Drawing.Point(30, 77);
            this.lblCarSer.Name = "lblCarSer";
            this.lblCarSer.Size = new System.Drawing.Size(44, 18);
            this.lblCarSer.TabIndex = 56;
            this.lblCarSer.Text = "车  系";
            // 
            // txtCarbrand
            // 
            // 
            // 
            // 
            this.txtCarbrand.Border.Class = "TextBoxBorder";
            this.txtCarbrand.Enabled = false;
            this.txtCarbrand.Location = new System.Drawing.Point(296, 39);
            this.txtCarbrand.Name = "txtCarbrand";
            this.txtCarbrand.Size = new System.Drawing.Size(108, 21);
            this.txtCarbrand.TabIndex = 55;
            this.txtCarbrand.Tag = "N";
            // 
            // lblCarBrand
            // 
            this.lblCarBrand.AutoSize = true;
            this.lblCarBrand.Location = new System.Drawing.Point(246, 41);
            this.lblCarBrand.Name = "lblCarBrand";
            this.lblCarBrand.Size = new System.Drawing.Size(44, 18);
            this.lblCarBrand.TabIndex = 54;
            this.lblCarBrand.Text = "品  牌";
            // 
            // txtCarModel
            // 
            // 
            // 
            // 
            this.txtCarModel.Border.Class = "TextBoxBorder";
            this.txtCarModel.Enabled = false;
            this.txtCarModel.Location = new System.Drawing.Point(296, 72);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(108, 21);
            this.txtCarModel.TabIndex = 53;
            this.txtCarModel.Tag = "N";
            // 
            // lblCarModel
            // 
            this.lblCarModel.AutoSize = true;
            this.lblCarModel.Location = new System.Drawing.Point(245, 75);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.Size = new System.Drawing.Size(44, 18);
            this.lblCarModel.TabIndex = 52;
            this.lblCarModel.Text = "车  型";
            // 
            // txtAutoNumber
            // 
            // 
            // 
            // 
            this.txtAutoNumber.Border.Class = "TextBoxBorder";
            this.txtAutoNumber.Enabled = false;
            this.txtAutoNumber.Location = new System.Drawing.Point(81, 39);
            this.txtAutoNumber.Name = "txtAutoNumber";
            this.txtAutoNumber.Size = new System.Drawing.Size(108, 21);
            this.txtAutoNumber.TabIndex = 51;
            this.txtAutoNumber.Tag = "N";
            // 
            // lblAutoNumber
            // 
            this.lblAutoNumber.AutoSize = true;
            this.lblAutoNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAutoNumber.Location = new System.Drawing.Point(22, 39);
            this.lblAutoNumber.Name = "lblAutoNumber";
            this.lblAutoNumber.Size = new System.Drawing.Size(56, 18);
            this.lblAutoNumber.TabIndex = 50;
            this.lblAutoNumber.Text = "自 编 号";
            // 
            // txtInPrice
            // 
            // 
            // 
            // 
            this.txtInPrice.Border.Class = "TextBoxBorder";
            this.txtInPrice.Location = new System.Drawing.Point(81, 216);
            this.txtInPrice.Name = "txtInPrice";
            this.txtInPrice.Size = new System.Drawing.Size(108, 21);
            this.txtInPrice.TabIndex = 89;
            this.txtInPrice.Tag = "NDouble";
            // 
            // txtDirectPrice
            // 
            // 
            // 
            // 
            this.txtDirectPrice.Border.Class = "TextBoxBorder";
            this.txtDirectPrice.Location = new System.Drawing.Point(81, 254);
            this.txtDirectPrice.Name = "txtDirectPrice";
            this.txtDirectPrice.Size = new System.Drawing.Size(108, 21);
            this.txtDirectPrice.TabIndex = 92;
            this.txtDirectPrice.Tag = "NDouble";
            // 
            // lblDirectPrice
            // 
            this.lblDirectPrice.AutoSize = true;
            this.lblDirectPrice.Location = new System.Drawing.Point(18, 257);
            this.lblDirectPrice.Name = "lblDirectPrice";
            this.lblDirectPrice.Size = new System.Drawing.Size(56, 18);
            this.lblDirectPrice.TabIndex = 91;
            this.lblDirectPrice.Text = "指 导 价";
            // 
            // frmDlgCarInD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 292);
            this.Controls.Add(this.txtDirectPrice);
            this.Controls.Add(this.lblDirectPrice);
            this.Controls.Add(btnCarDocSel);
            this.Controls.Add(this.txtInPrice);
            this.Controls.Add(this.txtVin);
            this.Controls.Add(this.lblVin);
            this.Controls.Add(this.cmbStorePlace);
            this.Controls.Add(this.lblStorePlace);
            this.Controls.Add(this.lblInPrice);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cmbCarOfYear);
            this.Controls.Add(this.cmbDisplacement);
            this.Controls.Add(this.cmbTransmission);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.lblCarOfYear);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.cmbInnerStyle);
            this.Controls.Add(this.lblInnerStyle);
            this.Controls.Add(this.lblTransmission);
            this.Controls.Add(this.lblDisplacement);
            this.Controls.Add(this.txtCarSer);
            this.Controls.Add(this.lblCarSer);
            this.Controls.Add(this.txtCarbrand);
            this.Controls.Add(this.lblCarBrand);
            this.Controls.Add(this.txtCarModel);
            this.Controls.Add(this.lblCarModel);
            this.Controls.Add(this.txtAutoNumber);
            this.Controls.Add(this.lblAutoNumber);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDlgCarInD";
            this.Text = "车辆入库单项目";
            this.Load += new System.EventHandler(this.frmDlgCarInD_Load);
            ((System.ComponentModel.ISupportInitialize)(btnCarDocSel)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtCarModel;
        private DevComponents.DotNetBar.LabelX lblCarModel;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAutoNumber;
        private DevComponents.DotNetBar.LabelX lblAutoNumber;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCarbrand;
        private DevComponents.DotNetBar.LabelX lblCarBrand;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCarSer;
        private DevComponents.DotNetBar.LabelX lblCarSer;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbCarOfYear;
        private DevComponents.Editors.ComboItem comboItem5;
        private DevComponents.Editors.ComboItem comboItem6;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbDisplacement;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.ComboItem comboItem7;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbTransmission;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbColor;
        private DevComponents.DotNetBar.LabelX lblCarOfYear;
        private DevComponents.DotNetBar.LabelX lblColor;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbInnerStyle;
        private DevComponents.DotNetBar.LabelX lblInnerStyle;
        private DevComponents.DotNetBar.LabelX lblTransmission;
        private DevComponents.DotNetBar.LabelX lblDisplacement;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnOK;
        private DevComponents.DotNetBar.LabelX lblStorePlace;
        private DevComponents.DotNetBar.LabelX lblInPrice;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbStorePlace;
        private DevComponents.DotNetBar.LabelX lblVin;
        private DevComponents.DotNetBar.Controls.TextBoxX txtVin;
        private DevComponents.DotNetBar.Controls.TextBoxX txtInPrice;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDirectPrice;
        private DevComponents.DotNetBar.LabelX lblDirectPrice;
    }
}