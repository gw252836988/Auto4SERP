﻿namespace Auto4SErp.Sale
{
    partial class frmCarAllot
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
            System.Windows.Forms.PictureBox btnVin;
            System.Windows.Forms.PictureBox btnCustomerFind;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarAllot));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dbiDirectPrice = new DevComponents.Editors.DoubleInput();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtSalePrice = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblSalePrice = new DevComponents.DotNetBar.LabelX();
            this.txtAutoNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblAutoNumber = new DevComponents.DotNetBar.LabelX();
            this.cmbCarOfYear = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblCarOfYear = new DevComponents.DotNetBar.LabelX();
            this.cmbColor = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblColor = new DevComponents.DotNetBar.LabelX();
            this.cmbDisplacement = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbTransmission = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbInnerStyle = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblInnerStyle = new DevComponents.DotNetBar.LabelX();
            this.lblTransmission = new DevComponents.DotNetBar.LabelX();
            this.lblDisplacement = new DevComponents.DotNetBar.LabelX();
            this.txtCarBrand = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCarModel = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCarModel = new DevComponents.DotNetBar.LabelX();
            this.txtCarSer = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCarSer = new DevComponents.DotNetBar.LabelX();
            this.lblCarBrand = new DevComponents.DotNetBar.LabelX();
            this.txtVin = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblVin = new DevComponents.DotNetBar.LabelX();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnSave = new System.Windows.Forms.ToolStripButton();
            this.btnPost = new System.Windows.Forms.ToolStripButton();
            this.btnUndo = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.gbDB = new System.Windows.Forms.GroupBox();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.datAllot = new System.Windows.Forms.DateTimePicker();
            this.cmbSupplier = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblSupplier = new DevComponents.DotNetBar.LabelX();
            this.dbiAllotPrice = new DevComponents.Editors.DoubleInput();
            this.lblCarPrice = new DevComponents.DotNetBar.LabelX();
            this.lblSaleMan = new DevComponents.DotNetBar.LabelX();
            this.txtSaleMan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblStatusText = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtDH = new DevComponents.DotNetBar.Controls.TextBoxX();
            btnVin = new System.Windows.Forms.PictureBox();
            btnCustomerFind = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(btnVin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(btnCustomerFind)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbiDirectPrice)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.gbDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbiAllotPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVin
            // 
            btnVin.BackgroundImage = global::Auto4SErp.Properties.Resources.smallquery;
            btnVin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnVin.Cursor = System.Windows.Forms.Cursors.Hand;
            btnVin.Location = new System.Drawing.Point(524, 34);
            btnVin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnVin.Name = "btnVin";
            btnVin.Size = new System.Drawing.Size(21, 20);
            btnVin.TabIndex = 115;
            btnVin.TabStop = false;
            btnVin.Click += new System.EventHandler(this.btnVin_Click);
            // 
            // btnCustomerFind
            // 
            btnCustomerFind.BackgroundImage = global::Auto4SErp.Properties.Resources.supply;
            btnCustomerFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnCustomerFind.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCustomerFind.Location = new System.Drawing.Point(571, 32);
            btnCustomerFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnCustomerFind.Name = "btnCustomerFind";
            btnCustomerFind.Size = new System.Drawing.Size(32, 30);
            btnCustomerFind.TabIndex = 109;
            btnCustomerFind.TabStop = false;
            btnCustomerFind.Click += new System.EventHandler(this.btnCustomerFind_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dbiDirectPrice);
            this.groupBox2.Controls.Add(this.labelX5);
            this.groupBox2.Controls.Add(this.txtSalePrice);
            this.groupBox2.Controls.Add(this.lblSalePrice);
            this.groupBox2.Controls.Add(this.txtAutoNumber);
            this.groupBox2.Controls.Add(this.lblAutoNumber);
            this.groupBox2.Controls.Add(btnVin);
            this.groupBox2.Controls.Add(this.cmbCarOfYear);
            this.groupBox2.Controls.Add(this.lblCarOfYear);
            this.groupBox2.Controls.Add(this.cmbColor);
            this.groupBox2.Controls.Add(this.lblColor);
            this.groupBox2.Controls.Add(this.cmbDisplacement);
            this.groupBox2.Controls.Add(this.cmbTransmission);
            this.groupBox2.Controls.Add(this.cmbInnerStyle);
            this.groupBox2.Controls.Add(this.lblInnerStyle);
            this.groupBox2.Controls.Add(this.lblTransmission);
            this.groupBox2.Controls.Add(this.lblDisplacement);
            this.groupBox2.Controls.Add(this.txtCarBrand);
            this.groupBox2.Controls.Add(this.txtCarModel);
            this.groupBox2.Controls.Add(this.lblCarModel);
            this.groupBox2.Controls.Add(this.txtCarSer);
            this.groupBox2.Controls.Add(this.lblCarSer);
            this.groupBox2.Controls.Add(this.lblCarBrand);
            this.groupBox2.Controls.Add(this.txtVin);
            this.groupBox2.Controls.Add(this.lblVin);
            this.groupBox2.Location = new System.Drawing.Point(21, 90);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(823, 205);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "车辆信息";
            // 
            // dbiDirectPrice
            // 
            // 
            // 
            // 
            this.dbiDirectPrice.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dbiDirectPrice.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.dbiDirectPrice.Enabled = false;
            this.dbiDirectPrice.Increment = 1D;
            this.dbiDirectPrice.Location = new System.Drawing.Point(644, 152);
            this.dbiDirectPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dbiDirectPrice.Name = "dbiDirectPrice";
            this.dbiDirectPrice.ShowUpDown = true;
            this.dbiDirectPrice.Size = new System.Drawing.Size(144, 25);
            this.dbiDirectPrice.TabIndex = 133;
            this.dbiDirectPrice.Tag = "N";
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            this.labelX5.Location = new System.Drawing.Point(571, 156);
            this.labelX5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(69, 21);
            this.labelX5.TabIndex = 132;
            this.labelX5.Text = "指 导 价";
            // 
            // txtSalePrice
            // 
            // 
            // 
            // 
            this.txtSalePrice.Border.Class = "TextBoxBorder";
            this.txtSalePrice.Location = new System.Drawing.Point(375, 154);
            this.txtSalePrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.ReadOnly = true;
            this.txtSalePrice.Size = new System.Drawing.Size(144, 25);
            this.txtSalePrice.TabIndex = 119;
            this.txtSalePrice.Tag = "Y";
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.Location = new System.Drawing.Point(293, 158);
            this.lblSalePrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(69, 21);
            this.lblSalePrice.TabIndex = 118;
            this.lblSalePrice.Text = "本月限价";
            // 
            // txtAutoNumber
            // 
            // 
            // 
            // 
            this.txtAutoNumber.Border.Class = "TextBoxBorder";
            this.txtAutoNumber.Location = new System.Drawing.Point(119, 34);
            this.txtAutoNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAutoNumber.Name = "txtAutoNumber";
            this.txtAutoNumber.ReadOnly = true;
            this.txtAutoNumber.Size = new System.Drawing.Size(144, 25);
            this.txtAutoNumber.TabIndex = 117;
            this.txtAutoNumber.Tag = "Y";
            // 
            // lblAutoNumber
            // 
            this.lblAutoNumber.AutoSize = true;
            this.lblAutoNumber.Location = new System.Drawing.Point(44, 35);
            this.lblAutoNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblAutoNumber.Name = "lblAutoNumber";
            this.lblAutoNumber.Size = new System.Drawing.Size(69, 21);
            this.lblAutoNumber.TabIndex = 116;
            this.lblAutoNumber.Text = "自 编 号";
            // 
            // cmbCarOfYear
            // 
            this.cmbCarOfYear.DisplayMember = "Text";
            this.cmbCarOfYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCarOfYear.Enabled = false;
            this.cmbCarOfYear.FormattingEnabled = true;
            this.cmbCarOfYear.ItemHeight = 15;
            this.cmbCarOfYear.Location = new System.Drawing.Point(375, 114);
            this.cmbCarOfYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCarOfYear.Name = "cmbCarOfYear";
            this.cmbCarOfYear.Size = new System.Drawing.Size(143, 21);
            this.cmbCarOfYear.TabIndex = 114;
            this.cmbCarOfYear.Tag = "N";
            // 
            // lblCarOfYear
            // 
            this.lblCarOfYear.AutoSize = true;
            this.lblCarOfYear.Location = new System.Drawing.Point(317, 118);
            this.lblCarOfYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblCarOfYear.Name = "lblCarOfYear";
            this.lblCarOfYear.Size = new System.Drawing.Size(46, 21);
            this.lblCarOfYear.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.lblCarOfYear.TabIndex = 113;
            this.lblCarOfYear.Text = "年 款";
            // 
            // cmbColor
            // 
            this.cmbColor.DisplayMember = "Text";
            this.cmbColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbColor.Enabled = false;
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.ItemHeight = 15;
            this.cmbColor.Location = new System.Drawing.Point(644, 74);
            this.cmbColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(143, 21);
            this.cmbColor.TabIndex = 112;
            this.cmbColor.Tag = "Y";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(569, 76);
            this.lblColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(69, 21);
            this.lblColor.TabIndex = 111;
            this.lblColor.Text = "车身颜色";
            // 
            // cmbDisplacement
            // 
            this.cmbDisplacement.DisplayMember = "Text";
            this.cmbDisplacement.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDisplacement.Enabled = false;
            this.cmbDisplacement.FormattingEnabled = true;
            this.cmbDisplacement.ItemHeight = 15;
            this.cmbDisplacement.Location = new System.Drawing.Point(119, 155);
            this.cmbDisplacement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDisplacement.Name = "cmbDisplacement";
            this.cmbDisplacement.Size = new System.Drawing.Size(143, 21);
            this.cmbDisplacement.TabIndex = 110;
            this.cmbDisplacement.Tag = "Y";
            // 
            // cmbTransmission
            // 
            this.cmbTransmission.DisplayMember = "Text";
            this.cmbTransmission.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTransmission.Enabled = false;
            this.cmbTransmission.FormattingEnabled = true;
            this.cmbTransmission.ItemHeight = 15;
            this.cmbTransmission.Location = new System.Drawing.Point(644, 112);
            this.cmbTransmission.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTransmission.Name = "cmbTransmission";
            this.cmbTransmission.Size = new System.Drawing.Size(143, 21);
            this.cmbTransmission.TabIndex = 109;
            this.cmbTransmission.Tag = "Y";
            // 
            // cmbInnerStyle
            // 
            this.cmbInnerStyle.DisplayMember = "Text";
            this.cmbInnerStyle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbInnerStyle.Enabled = false;
            this.cmbInnerStyle.FormattingEnabled = true;
            this.cmbInnerStyle.ItemHeight = 15;
            this.cmbInnerStyle.Location = new System.Drawing.Point(119, 112);
            this.cmbInnerStyle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbInnerStyle.Name = "cmbInnerStyle";
            this.cmbInnerStyle.Size = new System.Drawing.Size(143, 21);
            this.cmbInnerStyle.TabIndex = 108;
            this.cmbInnerStyle.Tag = "Y";
            // 
            // lblInnerStyle
            // 
            this.lblInnerStyle.AutoSize = true;
            this.lblInnerStyle.Location = new System.Drawing.Point(41, 114);
            this.lblInnerStyle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblInnerStyle.Name = "lblInnerStyle";
            this.lblInnerStyle.Size = new System.Drawing.Size(69, 21);
            this.lblInnerStyle.TabIndex = 107;
            this.lblInnerStyle.Text = "内饰风格";
            // 
            // lblTransmission
            // 
            this.lblTransmission.AutoSize = true;
            this.lblTransmission.Location = new System.Drawing.Point(569, 115);
            this.lblTransmission.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblTransmission.Name = "lblTransmission";
            this.lblTransmission.Size = new System.Drawing.Size(69, 21);
            this.lblTransmission.TabIndex = 106;
            this.lblTransmission.Text = "变 速 器";
            // 
            // lblDisplacement
            // 
            this.lblDisplacement.AutoSize = true;
            this.lblDisplacement.Location = new System.Drawing.Point(41, 158);
            this.lblDisplacement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblDisplacement.Name = "lblDisplacement";
            this.lblDisplacement.Size = new System.Drawing.Size(69, 21);
            this.lblDisplacement.TabIndex = 105;
            this.lblDisplacement.Text = "排 气 量";
            // 
            // txtCarBrand
            // 
            // 
            // 
            // 
            this.txtCarBrand.Border.Class = "TextBoxBorder";
            this.txtCarBrand.Location = new System.Drawing.Point(644, 32);
            this.txtCarBrand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCarBrand.Name = "txtCarBrand";
            this.txtCarBrand.ReadOnly = true;
            this.txtCarBrand.Size = new System.Drawing.Size(144, 25);
            this.txtCarBrand.TabIndex = 104;
            this.txtCarBrand.Tag = "Y";
            // 
            // txtCarModel
            // 
            // 
            // 
            // 
            this.txtCarModel.Border.Class = "TextBoxBorder";
            this.txtCarModel.Location = new System.Drawing.Point(119, 72);
            this.txtCarModel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.ReadOnly = true;
            this.txtCarModel.Size = new System.Drawing.Size(144, 25);
            this.txtCarModel.TabIndex = 102;
            this.txtCarModel.Tag = "Y";
            // 
            // lblCarModel
            // 
            this.lblCarModel.AutoSize = true;
            this.lblCarModel.Location = new System.Drawing.Point(56, 76);
            this.lblCarModel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.Size = new System.Drawing.Size(54, 21);
            this.lblCarModel.TabIndex = 101;
            this.lblCarModel.Text = "车  型";
            // 
            // txtCarSer
            // 
            // 
            // 
            // 
            this.txtCarSer.Border.Class = "TextBoxBorder";
            this.txtCarSer.Location = new System.Drawing.Point(375, 72);
            this.txtCarSer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCarSer.Name = "txtCarSer";
            this.txtCarSer.ReadOnly = true;
            this.txtCarSer.Size = new System.Drawing.Size(144, 25);
            this.txtCarSer.TabIndex = 100;
            this.txtCarSer.Tag = "Y";
            // 
            // lblCarSer
            // 
            this.lblCarSer.AutoSize = true;
            this.lblCarSer.Location = new System.Drawing.Point(313, 75);
            this.lblCarSer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblCarSer.Name = "lblCarSer";
            this.lblCarSer.Size = new System.Drawing.Size(54, 21);
            this.lblCarSer.TabIndex = 99;
            this.lblCarSer.Text = "车  系";
            // 
            // lblCarBrand
            // 
            this.lblCarBrand.AutoSize = true;
            this.lblCarBrand.Location = new System.Drawing.Point(583, 35);
            this.lblCarBrand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblCarBrand.Name = "lblCarBrand";
            this.lblCarBrand.Size = new System.Drawing.Size(54, 21);
            this.lblCarBrand.TabIndex = 98;
            this.lblCarBrand.Text = "品  牌";
            // 
            // txtVin
            // 
            // 
            // 
            // 
            this.txtVin.Border.Class = "TextBoxBorder";
            this.txtVin.ForeColor = System.Drawing.Color.Red;
            this.txtVin.Location = new System.Drawing.Point(375, 31);
            this.txtVin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVin.Name = "txtVin";
            this.txtVin.ReadOnly = true;
            this.txtVin.Size = new System.Drawing.Size(144, 25);
            this.txtVin.TabIndex = 96;
            this.txtVin.Tag = "Y";
            // 
            // lblVin
            // 
            this.lblVin.AutoSize = true;
            this.lblVin.Location = new System.Drawing.Point(319, 35);
            this.lblVin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblVin.Name = "lblVin";
            this.lblVin.Size = new System.Drawing.Size(46, 19);
            this.lblVin.TabIndex = 95;
            this.lblVin.Text = "V i n";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnSave,
            this.btnPost,
            this.btnUndo,
            this.btnDel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(864, 27);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnSave
            // 
            this.tbtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tbtnSave.Image")));
            this.tbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnSave.Name = "tbtnSave";
            this.tbtnSave.Size = new System.Drawing.Size(59, 24);
            this.tbtnSave.Tag = "save";
            this.tbtnSave.Text = "开单";
            this.tbtnSave.Click += new System.EventHandler(this.tbtnSave_Click);
            // 
            // btnPost
            // 
            this.btnPost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPost.Image = ((System.Drawing.Image)(resources.GetObject("btnPost.Image")));
            this.btnPost.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(73, 24);
            this.btnPost.Text = "提交财务";
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnUndo.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.Image")));
            this.btnUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(73, 24);
            this.btnUndo.Text = "放弃提交";
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnDel
            // 
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(59, 24);
            this.btnDel.Tag = "delete";
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // gbDB
            // 
            this.gbDB.BackColor = System.Drawing.Color.White;
            this.gbDB.Controls.Add(this.labelX2);
            this.gbDB.Controls.Add(this.datAllot);
            this.gbDB.Controls.Add(btnCustomerFind);
            this.gbDB.Controls.Add(this.cmbSupplier);
            this.gbDB.Controls.Add(this.lblSupplier);
            this.gbDB.Controls.Add(this.dbiAllotPrice);
            this.gbDB.Controls.Add(this.lblCarPrice);
            this.gbDB.Location = new System.Drawing.Point(21, 302);
            this.gbDB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDB.Name = "gbDB";
            this.gbDB.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDB.Size = new System.Drawing.Size(823, 132);
            this.gbDB.TabIndex = 6;
            this.gbDB.TabStop = false;
            this.gbDB.Text = "调拨信息";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(36, 88);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(69, 21);
            this.labelX2.TabIndex = 110;
            this.labelX2.Text = "调拨日期";
            // 
            // datAllot
            // 
            this.datAllot.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datAllot.Location = new System.Drawing.Point(119, 85);
            this.datAllot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datAllot.Name = "datAllot";
            this.datAllot.Size = new System.Drawing.Size(143, 25);
            this.datAllot.TabIndex = 33;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.DisplayMember = "Text";
            this.cmbSupplier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.ItemHeight = 15;
            this.cmbSupplier.Location = new System.Drawing.Point(375, 35);
            this.cmbSupplier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(187, 21);
            this.cmbSupplier.TabIndex = 108;
            this.cmbSupplier.Tag = "F1S1B0";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(293, 40);
            this.lblSupplier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(69, 21);
            this.lblSupplier.TabIndex = 107;
            this.lblSupplier.Text = "调拨单位";
            // 
            // dbiAllotPrice
            // 
            // 
            // 
            // 
            this.dbiAllotPrice.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dbiAllotPrice.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.dbiAllotPrice.Increment = 1D;
            this.dbiAllotPrice.Location = new System.Drawing.Point(119, 36);
            this.dbiAllotPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dbiAllotPrice.Name = "dbiAllotPrice";
            this.dbiAllotPrice.ShowUpDown = true;
            this.dbiAllotPrice.Size = new System.Drawing.Size(144, 25);
            this.dbiAllotPrice.TabIndex = 97;
            // 
            // lblCarPrice
            // 
            this.lblCarPrice.AutoSize = true;
            this.lblCarPrice.ForeColor = System.Drawing.Color.Red;
            this.lblCarPrice.Location = new System.Drawing.Point(36, 40);
            this.lblCarPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblCarPrice.Name = "lblCarPrice";
            this.lblCarPrice.Size = new System.Drawing.Size(69, 21);
            this.lblCarPrice.TabIndex = 96;
            this.lblCarPrice.Text = "调 拨 价";
            // 
            // lblSaleMan
            // 
            this.lblSaleMan.AutoSize = true;
            this.lblSaleMan.Location = new System.Drawing.Point(335, 60);
            this.lblSaleMan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblSaleMan.Name = "lblSaleMan";
            this.lblSaleMan.Size = new System.Drawing.Size(54, 21);
            this.lblSaleMan.TabIndex = 21;
            this.lblSaleMan.Text = "操作员";
            // 
            // txtSaleMan
            // 
            // 
            // 
            // 
            this.txtSaleMan.Border.Class = "TextBoxBorder";
            this.txtSaleMan.Location = new System.Drawing.Point(396, 56);
            this.txtSaleMan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSaleMan.Name = "txtSaleMan";
            this.txtSaleMan.ReadOnly = true;
            this.txtSaleMan.Size = new System.Drawing.Size(144, 25);
            this.txtSaleMan.TabIndex = 22;
            // 
            // lblStatusText
            // 
            this.lblStatusText.AutoSize = true;
            this.lblStatusText.ForeColor = System.Drawing.Color.Red;
            this.lblStatusText.Location = new System.Drawing.Point(265, 65);
            this.lblStatusText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblStatusText.Name = "lblStatusText";
            this.lblStatusText.Size = new System.Drawing.Size(0, 0);
            this.lblStatusText.TabIndex = 20;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.ForeColor = System.Drawing.Color.Red;
            this.labelX1.Location = new System.Drawing.Point(77, 60);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(54, 21);
            this.labelX1.TabIndex = 18;
            this.labelX1.Text = "单  号";
            // 
            // txtDH
            // 
            // 
            // 
            // 
            this.txtDH.Border.Class = "TextBoxBorder";
            this.txtDH.Location = new System.Drawing.Point(140, 56);
            this.txtDH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDH.Name = "txtDH";
            this.txtDH.ReadOnly = true;
            this.txtDH.Size = new System.Drawing.Size(144, 25);
            this.txtDH.TabIndex = 19;
            // 
            // frmCarAllot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 446);
            this.Controls.Add(this.lblSaleMan);
            this.Controls.Add(this.txtSaleMan);
            this.Controls.Add(this.lblStatusText);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtDH);
            this.Controls.Add(this.gbDB);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmCarAllot";
            this.Text = "车辆调拨";
            this.Load += new System.EventHandler(this.frmCarAllot_Load);
            ((System.ComponentModel.ISupportInitialize)(btnVin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(btnCustomerFind)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbiDirectPrice)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbDB.ResumeLayout(false);
            this.gbDB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbiAllotPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.Editors.DoubleInput dbiDirectPrice;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSalePrice;
        private DevComponents.DotNetBar.LabelX lblSalePrice;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAutoNumber;
        private DevComponents.DotNetBar.LabelX lblAutoNumber;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbCarOfYear;
        private DevComponents.DotNetBar.LabelX lblCarOfYear;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbColor;
        private DevComponents.DotNetBar.LabelX lblColor;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbDisplacement;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbTransmission;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbInnerStyle;
        private DevComponents.DotNetBar.LabelX lblInnerStyle;
        private DevComponents.DotNetBar.LabelX lblTransmission;
        private DevComponents.DotNetBar.LabelX lblDisplacement;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCarBrand;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCarModel;
        private DevComponents.DotNetBar.LabelX lblCarModel;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCarSer;
        private DevComponents.DotNetBar.LabelX lblCarSer;
        private DevComponents.DotNetBar.LabelX lblCarBrand;
        private DevComponents.DotNetBar.Controls.TextBoxX txtVin;
        private DevComponents.DotNetBar.LabelX lblVin;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnSave;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.GroupBox gbDB;
        private DevComponents.Editors.DoubleInput dbiAllotPrice;
        private DevComponents.DotNetBar.LabelX lblCarPrice;
        private DevComponents.DotNetBar.LabelX lblSaleMan;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSaleMan;
        private DevComponents.DotNetBar.LabelX lblStatusText;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDH;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbSupplier;
        private DevComponents.DotNetBar.LabelX lblSupplier;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.DateTimePicker datAllot;
        private System.Windows.Forms.ToolStripButton btnPost;
        private System.Windows.Forms.ToolStripButton btnUndo;
    }
}