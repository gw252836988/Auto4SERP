﻿namespace Auto4SErp.Repair
{
    partial class frmOutWareRec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOutWareRec));
            this.dgOutWareRec = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessoryCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HouseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DHFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InPrice1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JE1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplyUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutToUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlateNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorRecordCount = new System.Windows.Forms.ToolStripLabel();
            this.lblSum = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDHFrom = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblDHFrom = new DevComponents.DotNetBar.LabelX();
            this.chbIsPC = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txtPlateNum = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblPlateNum = new DevComponents.DotNetBar.LabelX();
            this.txtSmallType = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblSmallType = new DevComponents.DotNetBar.LabelX();
            this.IsShow = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cmbOutToUnit = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblOutToUnit = new DevComponents.DotNetBar.LabelX();
            this.cmbHouseName = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblHouseName1 = new DevComponents.DotNetBar.LabelX();
            this.cmbOutReason = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblOutReason = new DevComponents.DotNetBar.LabelX();
            this.txtAccessoryCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblAccessoryCode = new DevComponents.DotNetBar.LabelX();
            this.datBegin = new System.Windows.Forms.DateTimePicker();
            this.datEnd = new System.Windows.Forms.DateTimePicker();
            this.txtAccessoryName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblAccessoryName = new DevComponents.DotNetBar.LabelX();
            this.chbIsDate = new System.Windows.Forms.CheckBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnQuery = new System.Windows.Forms.ToolStripButton();
            this.btnOut = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgOutWareRec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgOutWareRec
            // 
            this.dgOutWareRec.AllowUserToAddRows = false;
            this.dgOutWareRec.AllowUserToDeleteRows = false;
            this.dgOutWareRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOutWareRec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.status,
            this.AccessoryCode,
            this.AccessoryName,
            this.HouseName,
            this.OutReason,
            this.OutDate,
            this.DHFrom,
            this.Amount,
            this.InPrice,
            this.InPrice1,
            this.inamount,
            this.JE1,
            this.SalePrice,
            this.SaleAmount,
            this.SupplyUnit,
            this.Vin,
            this.OutToUnit,
            this.CustName,
            this.PlateNum});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgOutWareRec.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgOutWareRec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOutWareRec.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgOutWareRec.Location = new System.Drawing.Point(0, 163);
            this.dgOutWareRec.MultiSelect = false;
            this.dgOutWareRec.Name = "dgOutWareRec";
            this.dgOutWareRec.RowTemplate.Height = 23;
            this.dgOutWareRec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOutWareRec.Size = new System.Drawing.Size(924, 237);
            this.dgOutWareRec.TabIndex = 37;
            this.dgOutWareRec.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgOutWareRec_RowPostPaint);
            // 
            // status
            // 
            this.status.DataPropertyName = "status1";
            this.status.HeaderText = "状态";
            this.status.Name = "status";
            this.status.Width = 55;
            // 
            // AccessoryCode
            // 
            this.AccessoryCode.DataPropertyName = "AccessoryCode";
            this.AccessoryCode.HeaderText = "配件编码";
            this.AccessoryCode.Name = "AccessoryCode";
            // 
            // AccessoryName
            // 
            this.AccessoryName.DataPropertyName = "AccessoryName";
            this.AccessoryName.HeaderText = "配件名称";
            this.AccessoryName.Name = "AccessoryName";
            // 
            // HouseName
            // 
            this.HouseName.DataPropertyName = "HouseName";
            this.HouseName.HeaderText = "仓库名";
            this.HouseName.Name = "HouseName";
            // 
            // OutReason
            // 
            this.OutReason.DataPropertyName = "OutReason";
            this.OutReason.HeaderText = "出库方式";
            this.OutReason.Name = "OutReason";
            // 
            // OutDate
            // 
            this.OutDate.DataPropertyName = "OutDate";
            this.OutDate.HeaderText = "出库时间";
            this.OutDate.Name = "OutDate";
            // 
            // DHFrom
            // 
            this.DHFrom.DataPropertyName = "DHFrom";
            this.DHFrom.HeaderText = "单据号";
            this.DHFrom.Name = "DHFrom";
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "数量";
            this.Amount.Name = "Amount";
            this.Amount.Width = 55;
            // 
            // InPrice
            // 
            this.InPrice.DataPropertyName = "InPrice";
            this.InPrice.HeaderText = "成本价";
            this.InPrice.Name = "InPrice";
            this.InPrice.Width = 70;
            // 
            // InPrice1
            // 
            this.InPrice1.DataPropertyName = "InPrice1";
            this.InPrice1.HeaderText = "非含税价";
            this.InPrice1.Name = "InPrice1";
            // 
            // inamount
            // 
            this.inamount.DataPropertyName = "inamount";
            this.inamount.HeaderText = "成本金额";
            this.inamount.Name = "inamount";
            this.inamount.Width = 80;
            // 
            // JE1
            // 
            this.JE1.DataPropertyName = "JE1";
            this.JE1.HeaderText = "非含税金额";
            this.JE1.Name = "JE1";
            // 
            // SalePrice
            // 
            this.SalePrice.DataPropertyName = "SalePrice";
            this.SalePrice.HeaderText = "销售单价";
            this.SalePrice.Name = "SalePrice";
            this.SalePrice.Width = 80;
            // 
            // SaleAmount
            // 
            this.SaleAmount.DataPropertyName = "SaleAmount";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.SaleAmount.DefaultCellStyle = dataGridViewCellStyle1;
            this.SaleAmount.HeaderText = "销售金额";
            this.SaleAmount.Name = "SaleAmount";
            this.SaleAmount.Width = 80;
            // 
            // SupplyUnit
            // 
            this.SupplyUnit.DataPropertyName = "SupplyUnit";
            this.SupplyUnit.HeaderText = "供货单位";
            this.SupplyUnit.Name = "SupplyUnit";
            // 
            // Vin
            // 
            this.Vin.DataPropertyName = "Vin";
            this.Vin.HeaderText = "Vin";
            this.Vin.Name = "Vin";
            this.Vin.Visible = false;
            // 
            // OutToUnit
            // 
            this.OutToUnit.DataPropertyName = "OutToUnit";
            this.OutToUnit.HeaderText = "出库单位";
            this.OutToUnit.Name = "OutToUnit";
            this.OutToUnit.Visible = false;
            // 
            // CustName
            // 
            this.CustName.DataPropertyName = "CustName";
            this.CustName.HeaderText = "顾客姓名";
            this.CustName.Name = "CustName";
            this.CustName.Visible = false;
            // 
            // PlateNum
            // 
            this.PlateNum.DataPropertyName = "PlateNum";
            this.PlateNum.HeaderText = "车牌号";
            this.PlateNum.Name = "PlateNum";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorRecordCount,
            this.lblSum,
            this.toolStripLabel1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 400);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(924, 25);
            this.bindingNavigator1.TabIndex = 47;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新添";
            this.bindingNavigatorAddNewItem.Visible = false;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            this.bindingNavigatorDeleteItem.Visible = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorRecordCount
            // 
            this.bindingNavigatorRecordCount.Name = "bindingNavigatorRecordCount";
            this.bindingNavigatorRecordCount.Size = new System.Drawing.Size(15, 22);
            this.bindingNavigatorRecordCount.Text = "0";
            // 
            // lblSum
            // 
            this.lblSum.ForeColor = System.Drawing.Color.Red;
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(188, 22);
            this.toolStripLabel1.Text = "入库退货已调整到入库查询里统计";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDHFrom);
            this.groupBox1.Controls.Add(this.lblDHFrom);
            this.groupBox1.Controls.Add(this.chbIsPC);
            this.groupBox1.Controls.Add(this.txtPlateNum);
            this.groupBox1.Controls.Add(this.lblPlateNum);
            this.groupBox1.Controls.Add(this.txtSmallType);
            this.groupBox1.Controls.Add(this.lblSmallType);
            this.groupBox1.Controls.Add(this.IsShow);
            this.groupBox1.Controls.Add(this.cmbOutToUnit);
            this.groupBox1.Controls.Add(this.lblOutToUnit);
            this.groupBox1.Controls.Add(this.cmbHouseName);
            this.groupBox1.Controls.Add(this.lblHouseName1);
            this.groupBox1.Controls.Add(this.cmbOutReason);
            this.groupBox1.Controls.Add(this.lblOutReason);
            this.groupBox1.Controls.Add(this.txtAccessoryCode);
            this.groupBox1.Controls.Add(this.lblAccessoryCode);
            this.groupBox1.Controls.Add(this.datBegin);
            this.groupBox1.Controls.Add(this.datEnd);
            this.groupBox1.Controls.Add(this.txtAccessoryName);
            this.groupBox1.Controls.Add(this.lblAccessoryName);
            this.groupBox1.Controls.Add(this.chbIsDate);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(924, 138);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // txtDHFrom
            // 
            // 
            // 
            // 
            this.txtDHFrom.Border.Class = "TextBoxBorder";
            this.txtDHFrom.Location = new System.Drawing.Point(639, 66);
            this.txtDHFrom.Name = "txtDHFrom";
            this.txtDHFrom.Size = new System.Drawing.Size(116, 21);
            this.txtDHFrom.TabIndex = 52;
            this.txtDHFrom.Tag = "F1S1";
            // 
            // lblDHFrom
            // 
            this.lblDHFrom.AutoSize = true;
            this.lblDHFrom.Location = new System.Drawing.Point(589, 69);
            this.lblDHFrom.Name = "lblDHFrom";
            this.lblDHFrom.Size = new System.Drawing.Size(44, 18);
            this.lblDHFrom.TabIndex = 51;
            this.lblDHFrom.Text = "单  号";
            // 
            // chbIsPC
            // 
            this.chbIsPC.Location = new System.Drawing.Point(446, 67);
            this.chbIsPC.Name = "chbIsPC";
            this.chbIsPC.Size = new System.Drawing.Size(107, 23);
            this.chbIsPC.TabIndex = 50;
            this.chbIsPC.Text = "排除入库退货";
            this.chbIsPC.Visible = false;
            // 
            // txtPlateNum
            // 
            // 
            // 
            // 
            this.txtPlateNum.Border.Class = "TextBoxBorder";
            this.txtPlateNum.Enabled = false;
            this.txtPlateNum.Location = new System.Drawing.Point(496, 96);
            this.txtPlateNum.Name = "txtPlateNum";
            this.txtPlateNum.Size = new System.Drawing.Size(114, 21);
            this.txtPlateNum.TabIndex = 49;
            this.txtPlateNum.Tag = "F1S1";
            // 
            // lblPlateNum
            // 
            this.lblPlateNum.AutoSize = true;
            this.lblPlateNum.Location = new System.Drawing.Point(446, 99);
            this.lblPlateNum.Name = "lblPlateNum";
            this.lblPlateNum.Size = new System.Drawing.Size(44, 18);
            this.lblPlateNum.TabIndex = 48;
            this.lblPlateNum.Text = "车牌号";
            // 
            // txtSmallType
            // 
            // 
            // 
            // 
            this.txtSmallType.Border.Class = "TextBoxBorder";
            this.txtSmallType.Location = new System.Drawing.Point(810, 31);
            this.txtSmallType.Name = "txtSmallType";
            this.txtSmallType.Size = new System.Drawing.Size(92, 21);
            this.txtSmallType.TabIndex = 47;
            this.txtSmallType.Tag = "F1S1";
            // 
            // lblSmallType
            // 
            this.lblSmallType.AutoSize = true;
            this.lblSmallType.Location = new System.Drawing.Point(750, 33);
            this.lblSmallType.Name = "lblSmallType";
            this.lblSmallType.Size = new System.Drawing.Size(56, 18);
            this.lblSmallType.TabIndex = 46;
            this.lblSmallType.Text = "配件小类";
            // 
            // IsShow
            // 
            this.IsShow.Location = new System.Drawing.Point(90, 100);
            this.IsShow.Name = "IsShow";
            this.IsShow.Size = new System.Drawing.Size(138, 23);
            this.IsShow.TabIndex = 45;
            this.IsShow.Text = "显示附加信息";
            this.IsShow.CheckValueChanged += new System.EventHandler(this.IsShow_CheckValueChanged);
            // 
            // cmbOutToUnit
            // 
            this.cmbOutToUnit.DisplayMember = "Text";
            this.cmbOutToUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbOutToUnit.Enabled = false;
            this.cmbOutToUnit.FormattingEnabled = true;
            this.cmbOutToUnit.ItemHeight = 15;
            this.cmbOutToUnit.Location = new System.Drawing.Point(295, 99);
            this.cmbOutToUnit.Name = "cmbOutToUnit";
            this.cmbOutToUnit.Size = new System.Drawing.Size(114, 21);
            this.cmbOutToUnit.TabIndex = 44;
            this.cmbOutToUnit.Tag = "F1S1B0";
            // 
            // lblOutToUnit
            // 
            this.lblOutToUnit.AutoSize = true;
            this.lblOutToUnit.Location = new System.Drawing.Point(234, 102);
            this.lblOutToUnit.Name = "lblOutToUnit";
            this.lblOutToUnit.Size = new System.Drawing.Size(56, 18);
            this.lblOutToUnit.TabIndex = 43;
            this.lblOutToUnit.Text = "出货单位";
            // 
            // cmbHouseName
            // 
            this.cmbHouseName.DisplayMember = "Text";
            this.cmbHouseName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbHouseName.FormattingEnabled = true;
            this.cmbHouseName.ItemHeight = 15;
            this.cmbHouseName.Location = new System.Drawing.Point(105, 67);
            this.cmbHouseName.Name = "cmbHouseName";
            this.cmbHouseName.Size = new System.Drawing.Size(99, 21);
            this.cmbHouseName.TabIndex = 42;
            this.cmbHouseName.Tag = "F1S1B0";
            // 
            // lblHouseName1
            // 
            this.lblHouseName1.AutoSize = true;
            this.lblHouseName1.Location = new System.Drawing.Point(43, 70);
            this.lblHouseName1.Name = "lblHouseName1";
            this.lblHouseName1.Size = new System.Drawing.Size(56, 18);
            this.lblHouseName1.TabIndex = 41;
            this.lblHouseName1.Text = "仓库名称";
            // 
            // cmbOutReason
            // 
            this.cmbOutReason.DisplayMember = "Text";
            this.cmbOutReason.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbOutReason.FormattingEnabled = true;
            this.cmbOutReason.ItemHeight = 15;
            this.cmbOutReason.Location = new System.Drawing.Point(295, 66);
            this.cmbOutReason.Name = "cmbOutReason";
            this.cmbOutReason.Size = new System.Drawing.Size(114, 21);
            this.cmbOutReason.TabIndex = 40;
            this.cmbOutReason.Tag = "F1S1B0";
            // 
            // lblOutReason
            // 
            this.lblOutReason.AutoSize = true;
            this.lblOutReason.Location = new System.Drawing.Point(233, 69);
            this.lblOutReason.Name = "lblOutReason";
            this.lblOutReason.Size = new System.Drawing.Size(56, 18);
            this.lblOutReason.TabIndex = 39;
            this.lblOutReason.Text = "出库方式";
            // 
            // txtAccessoryCode
            // 
            // 
            // 
            // 
            this.txtAccessoryCode.Border.Class = "TextBoxBorder";
            this.txtAccessoryCode.Location = new System.Drawing.Point(424, 30);
            this.txtAccessoryCode.Name = "txtAccessoryCode";
            this.txtAccessoryCode.Size = new System.Drawing.Size(114, 21);
            this.txtAccessoryCode.TabIndex = 38;
            this.txtAccessoryCode.Tag = "F1S1";
            // 
            // lblAccessoryCode
            // 
            this.lblAccessoryCode.AutoSize = true;
            this.lblAccessoryCode.Location = new System.Drawing.Point(364, 32);
            this.lblAccessoryCode.Name = "lblAccessoryCode";
            this.lblAccessoryCode.Size = new System.Drawing.Size(56, 18);
            this.lblAccessoryCode.TabIndex = 37;
            this.lblAccessoryCode.Text = "配件编码";
            // 
            // datBegin
            // 
            this.datBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datBegin.Location = new System.Drawing.Point(79, 31);
            this.datBegin.Name = "datBegin";
            this.datBegin.Size = new System.Drawing.Size(108, 21);
            this.datBegin.TabIndex = 34;
            // 
            // datEnd
            // 
            this.datEnd.Checked = false;
            this.datEnd.CustomFormat = "";
            this.datEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datEnd.Location = new System.Drawing.Point(216, 31);
            this.datEnd.Name = "datEnd";
            this.datEnd.Size = new System.Drawing.Size(104, 21);
            this.datEnd.TabIndex = 33;
            // 
            // txtAccessoryName
            // 
            // 
            // 
            // 
            this.txtAccessoryName.Border.Class = "TextBoxBorder";
            this.txtAccessoryName.Location = new System.Drawing.Point(615, 30);
            this.txtAccessoryName.Name = "txtAccessoryName";
            this.txtAccessoryName.Size = new System.Drawing.Size(114, 21);
            this.txtAccessoryName.TabIndex = 29;
            this.txtAccessoryName.Tag = "F1S1";
            // 
            // lblAccessoryName
            // 
            this.lblAccessoryName.AutoSize = true;
            this.lblAccessoryName.Location = new System.Drawing.Point(554, 32);
            this.lblAccessoryName.Name = "lblAccessoryName";
            this.lblAccessoryName.Size = new System.Drawing.Size(56, 18);
            this.lblAccessoryName.TabIndex = 28;
            this.lblAccessoryName.Text = "配件名称";
            // 
            // chbIsDate
            // 
            this.chbIsDate.AutoSize = true;
            this.chbIsDate.Checked = true;
            this.chbIsDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbIsDate.Location = new System.Drawing.Point(333, 34);
            this.chbIsDate.Name = "chbIsDate";
            this.chbIsDate.Size = new System.Drawing.Size(15, 14);
            this.chbIsDate.TabIndex = 27;
            this.chbIsDate.UseVisualStyleBackColor = true;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(42, 33);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(31, 18);
            this.labelX1.TabIndex = 26;
            this.labelX1.Text = "日期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "至";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnQuery,
            this.btnOut});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(924, 25);
            this.toolStrip1.TabIndex = 35;
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
            // frmOutWareRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 425);
            this.Controls.Add(this.dgOutWareRec);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmOutWareRec";
            this.Text = "出库查询";
            this.Load += new System.EventHandler(this.frmOutWareRec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOutWareRec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnQuery;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAccessoryName;
        private DevComponents.DotNetBar.LabelX lblAccessoryName;
        private System.Windows.Forms.CheckBox chbIsDate;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgOutWareRec;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorRecordCount;
        private System.Windows.Forms.DateTimePicker datBegin;
        private System.Windows.Forms.DateTimePicker datEnd;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAccessoryCode;
        private DevComponents.DotNetBar.LabelX lblAccessoryCode;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbOutReason;
        private DevComponents.DotNetBar.LabelX lblOutReason;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbHouseName;
        private DevComponents.DotNetBar.LabelX lblHouseName1;
        private System.Windows.Forms.ToolStripLabel lblSum;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbOutToUnit;
        private DevComponents.DotNetBar.LabelX lblOutToUnit;
        private DevComponents.DotNetBar.Controls.CheckBoxX IsShow;
        private System.Windows.Forms.ToolStripButton btnOut;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSmallType;
        private DevComponents.DotNetBar.LabelX lblSmallType;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPlateNum;
        private DevComponents.DotNetBar.LabelX lblPlateNum;
        private DevComponents.DotNetBar.Controls.CheckBoxX chbIsPC;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDHFrom;
        private DevComponents.DotNetBar.LabelX lblDHFrom;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessoryCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HouseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DHFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn InPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn InPrice1;
        private System.Windows.Forms.DataGridViewTextBoxColumn inamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn JE1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplyUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vin;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutToUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlateNum;
    }
}