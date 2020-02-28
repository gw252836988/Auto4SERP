﻿namespace Auto4SErp.Repair
{
    partial class frmRepair
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
            System.Windows.Forms.PictureBox btnGetVin;
            System.Windows.Forms.PictureBox btnCustomerAdd;
            System.Windows.Forms.PictureBox btnCustomerFind;
            DevComponents.DotNetBar.LabelX lblRepChildType;
            DevComponents.DotNetBar.LabelX lblRepType;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepair));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmenuRepairItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmenuAcc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dModifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelDemandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetAccToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgRepairItem = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.XH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricetype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpWorkH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActWorkH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemtotalprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeOfWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faultDescribe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faultReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceidhide = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgAccessory = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.xxh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessorycode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessoryname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HouseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPriceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sum1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aFinalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TakeMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TakeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtAccessAmount = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblAccessAmount = new DevComponents.DotNetBar.LabelX();
            this.txtAll = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblAll = new DevComponents.DotNetBar.LabelX();
            this.txtPreAccessoryAmount = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPreItemAmount = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblPreAccessoryAmount = new DevComponents.DotNetBar.LabelX();
            this.lblPreItemAmount = new DevComponents.DotNetBar.LabelX();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtEngineID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblEngineID = new DevComponents.DotNetBar.LabelX();
            this.txtColor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblColor = new DevComponents.DotNetBar.LabelX();
            this.txtVin = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblVin = new DevComponents.DotNetBar.LabelX();
            this.txtPlateNum = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblPlateNum = new DevComponents.DotNetBar.LabelX();
            this.txtCarModel = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCarModel = new DevComponents.DotNetBar.LabelX();
            this.txtCarBrand = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCarSer = new DevComponents.DotNetBar.LabelX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbComeType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem11 = new DevComponents.Editors.ComboItem();
            this.comboItem12 = new DevComponents.Editors.ComboItem();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cmbCustType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem8 = new DevComponents.Editors.ComboItem();
            this.lblCustType = new DevComponents.DotNetBar.LabelX();
            this.chbP2PVip = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btnModify = new DevComponents.DotNetBar.ButtonX();
            this.chbBuyHere = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chbPresent = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.lblBalance = new DevComponents.DotNetBar.LabelX();
            this.lblVipType = new DevComponents.DotNetBar.LabelX();
            this.txtCardNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCardNo = new DevComponents.DotNetBar.LabelX();
            this.txtMobile = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblMobile = new DevComponents.DotNetBar.LabelX();
            this.txtAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblAddress = new DevComponents.DotNetBar.LabelX();
            this.txtCustName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCustName = new DevComponents.DotNetBar.LabelX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpEstimateComplete = new System.Windows.Forms.DateTimePicker();
            this.lblEstimateComplete = new DevComponents.DotNetBar.LabelX();
            this.txtDecorateDH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblDecorateDH = new DevComponents.DotNetBar.LabelX();
            this.txtReceptTime = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmbRepChildType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.comboItem6 = new DevComponents.Editors.ComboItem();
            this.lblReceptTime = new DevComponents.DotNetBar.LabelX();
            this.txtDH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtReceptMan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblDH = new DevComponents.DotNetBar.LabelX();
            this.lblReceptMan = new DevComponents.DotNetBar.LabelX();
            this.cmbRepType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem7 = new DevComponents.Editors.ComboItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.tdrRecept = new System.Windows.Forms.ToolStripDropDownButton();
            this.tbtnRecept = new System.Windows.Forms.ToolStripMenuItem();
            this.tbtnUnRecept = new System.Windows.Forms.ToolStripMenuItem();
            this.tdrAccount = new System.Windows.Forms.ToolStripDropDownButton();
            this.tbtnPreAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.tbtnUnPreAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrintDele = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnPrintDemand = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrintRep = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrintAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.takeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.menuClaim = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnCalimSure = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClaimModify = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtSystemDH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtLastMil = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblLastMil = new DevComponents.DotNetBar.LabelX();
            this.txtRemark = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblRemark = new DevComponents.DotNetBar.LabelX();
            this.datKeepEnd = new System.Windows.Forms.DateTimePicker();
            this.lblKeepEnd = new DevComponents.DotNetBar.LabelX();
            this.datKeepBegin = new System.Windows.Forms.DateTimePicker();
            this.lblKeepBegin = new DevComponents.DotNetBar.LabelX();
            this.datNextKeepDate = new System.Windows.Forms.DateTimePicker();
            this.datInEnd = new System.Windows.Forms.DateTimePicker();
            this.lblInEnd = new DevComponents.DotNetBar.LabelX();
            this.datInBegin = new System.Windows.Forms.DateTimePicker();
            this.lblInBegin = new DevComponents.DotNetBar.LabelX();
            this.lblNextKeepDate = new DevComponents.DotNetBar.LabelX();
            this.txtNextKeepMil = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblNextKeepMil = new DevComponents.DotNetBar.LabelX();
            this.txtInMil = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblInMil = new DevComponents.DotNetBar.LabelX();
            this.chbIsNeedOld = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chbIsWash = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chbIsWillVisit = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txtSendRepTel = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblSendRepTel = new DevComponents.DotNetBar.LabelX();
            this.txtSendRepMan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblSendRepMan = new DevComponents.DotNetBar.LabelX();
            this.txtInsuranceCompany = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblInsuranceCompany = new DevComponents.DotNetBar.LabelX();
            this.comboItem9 = new DevComponents.Editors.ComboItem();
            btnGetVin = new System.Windows.Forms.PictureBox();
            btnCustomerAdd = new System.Windows.Forms.PictureBox();
            btnCustomerFind = new System.Windows.Forms.PictureBox();
            lblRepChildType = new DevComponents.DotNetBar.LabelX();
            lblRepType = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(btnGetVin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(btnCustomerAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(btnCustomerFind)).BeginInit();
            this.cmenuRepairItem.SuspendLayout();
            this.cmenuAcc.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRepairItem)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccessory)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetVin
            // 
            btnGetVin.BackgroundImage = global::Auto4SErp.Properties.Resources.get;
            btnGetVin.Cursor = System.Windows.Forms.Cursors.Hand;
            btnGetVin.Location = new System.Drawing.Point(454, 25);
            btnGetVin.Name = "btnGetVin";
            btnGetVin.Size = new System.Drawing.Size(16, 16);
            btnGetVin.TabIndex = 106;
            btnGetVin.TabStop = false;
            btnGetVin.Visible = false;
            btnGetVin.Click += new System.EventHandler(this.btnGetVin_Click);
            // 
            // btnCustomerAdd
            // 
            btnCustomerAdd.BackgroundImage = global::Auto4SErp.Properties.Resources.customer;
            btnCustomerAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnCustomerAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCustomerAdd.Location = new System.Drawing.Point(248, 27);
            btnCustomerAdd.Name = "btnCustomerAdd";
            btnCustomerAdd.Size = new System.Drawing.Size(16, 15);
            btnCustomerAdd.TabIndex = 121;
            btnCustomerAdd.TabStop = false;
            btnCustomerAdd.Click += new System.EventHandler(this.btnCustomerAdd_Click);
            // 
            // btnCustomerFind
            // 
            btnCustomerFind.BackgroundImage = global::Auto4SErp.Properties.Resources.smallquery;
            btnCustomerFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnCustomerFind.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCustomerFind.Location = new System.Drawing.Point(226, 27);
            btnCustomerFind.Name = "btnCustomerFind";
            btnCustomerFind.Size = new System.Drawing.Size(16, 16);
            btnCustomerFind.TabIndex = 105;
            btnCustomerFind.TabStop = false;
            btnCustomerFind.Click += new System.EventHandler(this.btnCustomerFind_Click_1);
            // 
            // lblRepChildType
            // 
            lblRepChildType.AutoSize = true;
            lblRepChildType.Location = new System.Drawing.Point(480, 21);
            lblRepChildType.Name = "lblRepChildType";
            lblRepChildType.Size = new System.Drawing.Size(56, 18);
            lblRepChildType.TabIndex = 13;
            lblRepChildType.Text = "维修小类";
            // 
            // lblRepType
            // 
            lblRepType.Location = new System.Drawing.Point(253, 22);
            lblRepType.Name = "lblRepType";
            lblRepType.Size = new System.Drawing.Size(56, 18);
            lblRepType.TabIndex = 8;
            lblRepType.Text = "维修类别";
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            // 
            // cmenuRepairItem
            // 
            this.cmenuRepairItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddItemToolStripMenuItem,
            this.ModifyToolStripMenuItem,
            this.DelToolStripMenuItem,
            this.ResetItemToolStripMenuItem});
            this.cmenuRepairItem.Name = "cmenuCarDetail";
            this.cmenuRepairItem.Size = new System.Drawing.Size(161, 92);
            this.cmenuRepairItem.Opening += new System.ComponentModel.CancelEventHandler(this.cmenuRepairItem_Opening);
            // 
            // AddItemToolStripMenuItem
            // 
            this.AddItemToolStripMenuItem.Name = "AddItemToolStripMenuItem";
            this.AddItemToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.AddItemToolStripMenuItem.Text = "增加项目";
            this.AddItemToolStripMenuItem.Click += new System.EventHandler(this.AddItemToolStripMenuItem_Click);
            // 
            // ModifyToolStripMenuItem
            // 
            this.ModifyToolStripMenuItem.Name = "ModifyToolStripMenuItem";
            this.ModifyToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.ModifyToolStripMenuItem.Text = "修改项目";
            this.ModifyToolStripMenuItem.Click += new System.EventHandler(this.ModifyToolStripMenuItem_Click);
            // 
            // DelToolStripMenuItem
            // 
            this.DelToolStripMenuItem.Name = "DelToolStripMenuItem";
            this.DelToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.DelToolStripMenuItem.Text = "删除项目";
            this.DelToolStripMenuItem.Click += new System.EventHandler(this.DelToolStripMenuItem_Click);
            // 
            // ResetItemToolStripMenuItem
            // 
            this.ResetItemToolStripMenuItem.Name = "ResetItemToolStripMenuItem";
            this.ResetItemToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.ResetItemToolStripMenuItem.Text = "重置价格及优惠";
            this.ResetItemToolStripMenuItem.Click += new System.EventHandler(this.ResetItemToolStripMenuItem_Click);
            // 
            // cmenuAcc
            // 
            this.cmenuAcc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddtoolStripMenuItem,
            this.dModifyToolStripMenuItem,
            this.DelDemandToolStripMenuItem,
            this.ResetAccToolStripMenuItem});
            this.cmenuAcc.Name = "cmenuCarDetail";
            this.cmenuAcc.Size = new System.Drawing.Size(161, 92);
            // 
            // AddtoolStripMenuItem
            // 
            this.AddtoolStripMenuItem.Name = "AddtoolStripMenuItem";
            this.AddtoolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.AddtoolStripMenuItem.Text = "增加需求";
            this.AddtoolStripMenuItem.Click += new System.EventHandler(this.AddtoolStripMenuItem_Click);
            // 
            // dModifyToolStripMenuItem
            // 
            this.dModifyToolStripMenuItem.Name = "dModifyToolStripMenuItem";
            this.dModifyToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.dModifyToolStripMenuItem.Text = "修改需求";
            this.dModifyToolStripMenuItem.Click += new System.EventHandler(this.dModifyToolStripMenuItem_Click);
            // 
            // DelDemandToolStripMenuItem
            // 
            this.DelDemandToolStripMenuItem.Name = "DelDemandToolStripMenuItem";
            this.DelDemandToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.DelDemandToolStripMenuItem.Text = "删除需求";
            this.DelDemandToolStripMenuItem.Click += new System.EventHandler(this.DelDemandToolStripMenuItem_Click);
            // 
            // ResetAccToolStripMenuItem
            // 
            this.ResetAccToolStripMenuItem.Name = "ResetAccToolStripMenuItem";
            this.ResetAccToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.ResetAccToolStripMenuItem.Text = "重置价格及优惠";
            this.ResetAccToolStripMenuItem.Click += new System.EventHandler(this.ResetAccToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 480);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(725, 248);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgRepairItem);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(717, 222);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "维修项目";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgRepairItem
            // 
            this.dgRepairItem.AllowUserToAddRows = false;
            this.dgRepairItem.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRepairItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgRepairItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRepairItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.XH,
            this.ItemCode,
            this.itemname,
            this.pricetype,
            this.EmpWorkH,
            this.ActWorkH,
            this.WorkMan,
            this.Discount,
            this.itemtotalprice,
            this.FinalPrice,
            this.CarLevel,
            this.TypeOfWork,
            this.faultDescribe,
            this.faultReason,
            this.priceidhide});
            this.dgRepairItem.ContextMenuStrip = this.cmenuRepairItem;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgRepairItem.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgRepairItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgRepairItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgRepairItem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgRepairItem.Location = new System.Drawing.Point(3, 3);
            this.dgRepairItem.Name = "dgRepairItem";
            this.dgRepairItem.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRepairItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgRepairItem.RowHeadersVisible = false;
            this.dgRepairItem.RowTemplate.Height = 23;
            this.dgRepairItem.Size = new System.Drawing.Size(711, 216);
            this.dgRepairItem.TabIndex = 2;
            this.dgRepairItem.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgRepairItem_CellBeginEdit);
            this.dgRepairItem.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRepairItem_CellEndEdit);
            this.dgRepairItem.NewRowNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgRepairItem_NewRowNeeded);
            // 
            // XH
            // 
            this.XH.DataPropertyName = "XH";
            this.XH.HeaderText = "序号";
            this.XH.Name = "XH";
            this.XH.ReadOnly = true;
            this.XH.Visible = false;
            this.XH.Width = 60;
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
            // pricetype
            // 
            this.pricetype.DataPropertyName = "pricetype";
            this.pricetype.HeaderText = "价类";
            this.pricetype.Name = "pricetype";
            this.pricetype.ReadOnly = true;
            this.pricetype.Width = 55;
            // 
            // EmpWorkH
            // 
            this.EmpWorkH.DataPropertyName = "EmpWorkH";
            this.EmpWorkH.HeaderText = "员工工时";
            this.EmpWorkH.Name = "EmpWorkH";
            this.EmpWorkH.ReadOnly = true;
            this.EmpWorkH.Width = 80;
            // 
            // ActWorkH
            // 
            this.ActWorkH.DataPropertyName = "ActWorkH";
            this.ActWorkH.HeaderText = "结算工时";
            this.ActWorkH.Name = "ActWorkH";
            this.ActWorkH.ReadOnly = true;
            this.ActWorkH.Width = 80;
            // 
            // WorkMan
            // 
            this.WorkMan.DataPropertyName = "WorkMan";
            this.WorkMan.HeaderText = "作业人员";
            this.WorkMan.Name = "WorkMan";
            this.WorkMan.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "折扣";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            this.Discount.Width = 55;
            // 
            // itemtotalprice
            // 
            this.itemtotalprice.DataPropertyName = "ItemTotalPrice";
            this.itemtotalprice.HeaderText = "工时金额";
            this.itemtotalprice.Name = "itemtotalprice";
            this.itemtotalprice.ReadOnly = true;
            this.itemtotalprice.Width = 80;
            // 
            // FinalPrice
            // 
            this.FinalPrice.DataPropertyName = "FinalPrice";
            this.FinalPrice.HeaderText = "实际金额";
            this.FinalPrice.Name = "FinalPrice";
            this.FinalPrice.ReadOnly = true;
            this.FinalPrice.Width = 80;
            // 
            // CarLevel
            // 
            this.CarLevel.DataPropertyName = "CarLevel";
            this.CarLevel.HeaderText = "车型分类";
            this.CarLevel.Name = "CarLevel";
            this.CarLevel.ReadOnly = true;
            this.CarLevel.Width = 80;
            // 
            // TypeOfWork
            // 
            this.TypeOfWork.DataPropertyName = "TypeOfWork";
            this.TypeOfWork.HeaderText = "工种";
            this.TypeOfWork.Name = "TypeOfWork";
            this.TypeOfWork.ReadOnly = true;
            this.TypeOfWork.Width = 55;
            // 
            // faultDescribe
            // 
            this.faultDescribe.DataPropertyName = "faultDescribe";
            this.faultDescribe.HeaderText = "故障描述";
            this.faultDescribe.Name = "faultDescribe";
            this.faultDescribe.ReadOnly = true;
            // 
            // faultReason
            // 
            this.faultReason.DataPropertyName = "faultReason";
            this.faultReason.HeaderText = "故障原因";
            this.faultReason.Name = "faultReason";
            this.faultReason.ReadOnly = true;
            // 
            // priceidhide
            // 
            this.priceidhide.DataPropertyName = "PriceId";
            this.priceidhide.HeaderText = "价格编号";
            this.priceidhide.Name = "priceidhide";
            this.priceidhide.ReadOnly = true;
            this.priceidhide.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgAccessory);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(717, 222);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "维修领料";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgAccessory
            // 
            this.dgAccessory.AllowUserToAddRows = false;
            this.dgAccessory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAccessory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgAccessory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAccessory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xxh,
            this.AccType,
            this.accessorycode,
            this.accessoryname,
            this.HouseName,
            this.aPriceType,
            this.Amount,
            this.SalePrice,
            this.sum1,
            this.aDiscount,
            this.aFinalPrice,
            this.TakeMan,
            this.TakeDate});
            this.dgAccessory.ContextMenuStrip = this.cmenuAcc;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAccessory.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgAccessory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAccessory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgAccessory.Location = new System.Drawing.Point(3, 3);
            this.dgAccessory.MultiSelect = false;
            this.dgAccessory.Name = "dgAccessory";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAccessory.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgAccessory.RowHeadersVisible = false;
            this.dgAccessory.RowTemplate.Height = 23;
            this.dgAccessory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAccessory.Size = new System.Drawing.Size(711, 216);
            this.dgAccessory.TabIndex = 39;
            // 
            // xxh
            // 
            this.xxh.DataPropertyName = "xh";
            this.xxh.HeaderText = "序号";
            this.xxh.Name = "xxh";
            this.xxh.Visible = false;
            // 
            // AccType
            // 
            this.AccType.DataPropertyName = "AccType";
            this.AccType.HeaderText = "类型";
            this.AccType.Name = "AccType";
            this.AccType.Width = 55;
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
            this.HouseName.Width = 60;
            // 
            // aPriceType
            // 
            this.aPriceType.DataPropertyName = "PriceType";
            this.aPriceType.HeaderText = "价类";
            this.aPriceType.Name = "aPriceType";
            this.aPriceType.Width = 55;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "数量";
            this.Amount.Name = "Amount";
            this.Amount.Width = 55;
            // 
            // SalePrice
            // 
            this.SalePrice.DataPropertyName = "SalePrice";
            this.SalePrice.HeaderText = "单价";
            this.SalePrice.Name = "SalePrice";
            this.SalePrice.Width = 55;
            // 
            // sum1
            // 
            this.sum1.DataPropertyName = "sum";
            dataGridViewCellStyle5.Format = "0.00";
            this.sum1.DefaultCellStyle = dataGridViewCellStyle5;
            this.sum1.HeaderText = "金额";
            this.sum1.Name = "sum1";
            this.sum1.Width = 55;
            // 
            // aDiscount
            // 
            this.aDiscount.DataPropertyName = "Discount";
            this.aDiscount.HeaderText = "折扣";
            this.aDiscount.Name = "aDiscount";
            this.aDiscount.Width = 55;
            // 
            // aFinalPrice
            // 
            this.aFinalPrice.DataPropertyName = "sum1";
            this.aFinalPrice.HeaderText = "实际金额";
            this.aFinalPrice.Name = "aFinalPrice";
            this.aFinalPrice.Width = 80;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 449);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtAccessAmount);
            this.groupBox4.Controls.Add(this.lblAccessAmount);
            this.groupBox4.Controls.Add(this.txtAll);
            this.groupBox4.Controls.Add(this.lblAll);
            this.groupBox4.Controls.Add(this.txtPreAccessoryAmount);
            this.groupBox4.Controls.Add(this.txtPreItemAmount);
            this.groupBox4.Controls.Add(this.lblPreAccessoryAmount);
            this.groupBox4.Controls.Add(this.lblPreItemAmount);
            this.groupBox4.Location = new System.Drawing.Point(18, 338);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(706, 96);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "维修信息";
            // 
            // txtAccessAmount
            // 
            // 
            // 
            // 
            this.txtAccessAmount.Border.Class = "TextBoxBorder";
            this.txtAccessAmount.Location = new System.Drawing.Point(93, 63);
            this.txtAccessAmount.Name = "txtAccessAmount";
            this.txtAccessAmount.ReadOnly = true;
            this.txtAccessAmount.Size = new System.Drawing.Size(128, 21);
            this.txtAccessAmount.TabIndex = 19;
            this.txtAccessAmount.Tag = "N";
            // 
            // lblAccessAmount
            // 
            this.lblAccessAmount.AutoSize = true;
            this.lblAccessAmount.Location = new System.Drawing.Point(33, 64);
            this.lblAccessAmount.Name = "lblAccessAmount";
            this.lblAccessAmount.Size = new System.Drawing.Size(56, 18);
            this.lblAccessAmount.TabIndex = 18;
            this.lblAccessAmount.Text = "索赔金额";
            // 
            // txtAll
            // 
            // 
            // 
            // 
            this.txtAll.Border.Class = "TextBoxBorder";
            this.txtAll.Location = new System.Drawing.Point(546, 26);
            this.txtAll.Name = "txtAll";
            this.txtAll.ReadOnly = true;
            this.txtAll.Size = new System.Drawing.Size(128, 21);
            this.txtAll.TabIndex = 17;
            this.txtAll.Tag = "N";
            // 
            // lblAll
            // 
            this.lblAll.AutoSize = true;
            this.lblAll.Location = new System.Drawing.Point(484, 29);
            this.lblAll.Name = "lblAll";
            this.lblAll.Size = new System.Drawing.Size(56, 18);
            this.lblAll.TabIndex = 16;
            this.lblAll.Text = "预估费用";
            // 
            // txtPreAccessoryAmount
            // 
            // 
            // 
            // 
            this.txtPreAccessoryAmount.Border.Class = "TextBoxBorder";
            this.txtPreAccessoryAmount.Location = new System.Drawing.Point(319, 26);
            this.txtPreAccessoryAmount.Name = "txtPreAccessoryAmount";
            this.txtPreAccessoryAmount.ReadOnly = true;
            this.txtPreAccessoryAmount.Size = new System.Drawing.Size(128, 21);
            this.txtPreAccessoryAmount.TabIndex = 15;
            this.txtPreAccessoryAmount.Tag = "N";
            // 
            // txtPreItemAmount
            // 
            // 
            // 
            // 
            this.txtPreItemAmount.Border.Class = "TextBoxBorder";
            this.txtPreItemAmount.Location = new System.Drawing.Point(93, 27);
            this.txtPreItemAmount.Name = "txtPreItemAmount";
            this.txtPreItemAmount.ReadOnly = true;
            this.txtPreItemAmount.Size = new System.Drawing.Size(128, 21);
            this.txtPreItemAmount.TabIndex = 14;
            this.txtPreItemAmount.Tag = "N";
            // 
            // lblPreAccessoryAmount
            // 
            this.lblPreAccessoryAmount.AutoSize = true;
            this.lblPreAccessoryAmount.Location = new System.Drawing.Point(257, 30);
            this.lblPreAccessoryAmount.Name = "lblPreAccessoryAmount";
            this.lblPreAccessoryAmount.Size = new System.Drawing.Size(56, 18);
            this.lblPreAccessoryAmount.TabIndex = 8;
            this.lblPreAccessoryAmount.Text = "预估材料";
            // 
            // lblPreItemAmount
            // 
            this.lblPreItemAmount.AutoSize = true;
            this.lblPreItemAmount.Location = new System.Drawing.Point(33, 28);
            this.lblPreItemAmount.Name = "lblPreItemAmount";
            this.lblPreItemAmount.Size = new System.Drawing.Size(56, 18);
            this.lblPreItemAmount.TabIndex = 6;
            this.lblPreItemAmount.Text = "预估项目";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtEngineID);
            this.groupBox3.Controls.Add(this.lblEngineID);
            this.groupBox3.Controls.Add(btnGetVin);
            this.groupBox3.Controls.Add(this.txtColor);
            this.groupBox3.Controls.Add(this.lblColor);
            this.groupBox3.Controls.Add(this.txtVin);
            this.groupBox3.Controls.Add(this.lblVin);
            this.groupBox3.Controls.Add(this.txtPlateNum);
            this.groupBox3.Controls.Add(this.lblPlateNum);
            this.groupBox3.Controls.Add(this.txtCarModel);
            this.groupBox3.Controls.Add(this.lblCarModel);
            this.groupBox3.Controls.Add(this.txtCarBrand);
            this.groupBox3.Controls.Add(this.lblCarSer);
            this.groupBox3.Location = new System.Drawing.Point(22, 240);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(702, 93);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "车辆信息";
            // 
            // txtEngineID
            // 
            // 
            // 
            // 
            this.txtEngineID.Border.Class = "TextBoxBorder";
            this.txtEngineID.Location = new System.Drawing.Point(542, 22);
            this.txtEngineID.Name = "txtEngineID";
            this.txtEngineID.ReadOnly = true;
            this.txtEngineID.Size = new System.Drawing.Size(128, 21);
            this.txtEngineID.TabIndex = 108;
            this.txtEngineID.Tag = "N";
            this.txtEngineID.TextChanged += new System.EventHandler(this.textBoxX1_TextChanged_1);
            // 
            // lblEngineID
            // 
            this.lblEngineID.AutoSize = true;
            this.lblEngineID.Location = new System.Drawing.Point(480, 25);
            this.lblEngineID.Name = "lblEngineID";
            this.lblEngineID.Size = new System.Drawing.Size(56, 18);
            this.lblEngineID.TabIndex = 107;
            this.lblEngineID.Text = "发动机号";
            // 
            // txtColor
            // 
            // 
            // 
            // 
            this.txtColor.Border.Class = "TextBoxBorder";
            this.txtColor.Location = new System.Drawing.Point(542, 54);
            this.txtColor.Name = "txtColor";
            this.txtColor.ReadOnly = true;
            this.txtColor.Size = new System.Drawing.Size(128, 21);
            this.txtColor.TabIndex = 15;
            this.txtColor.Tag = "N";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(480, 57);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(56, 18);
            this.lblColor.TabIndex = 14;
            this.lblColor.Text = "车身颜色";
            // 
            // txtVin
            // 
            // 
            // 
            // 
            this.txtVin.Border.Class = "TextBoxBorder";
            this.txtVin.Location = new System.Drawing.Point(315, 22);
            this.txtVin.Name = "txtVin";
            this.txtVin.ReadOnly = true;
            this.txtVin.Size = new System.Drawing.Size(128, 21);
            this.txtVin.TabIndex = 13;
            this.txtVin.Tag = "N";
            this.txtVin.TextChanged += new System.EventHandler(this.txtVin_TextChanged);
            // 
            // lblVin
            // 
            this.lblVin.AutoSize = true;
            this.lblVin.Location = new System.Drawing.Point(265, 25);
            this.lblVin.Name = "lblVin";
            this.lblVin.Size = new System.Drawing.Size(44, 18);
            this.lblVin.TabIndex = 12;
            this.lblVin.Text = "Vin 码";
            // 
            // txtPlateNum
            // 
            // 
            // 
            // 
            this.txtPlateNum.Border.Class = "TextBoxBorder";
            this.txtPlateNum.Location = new System.Drawing.Point(89, 21);
            this.txtPlateNum.Name = "txtPlateNum";
            this.txtPlateNum.ReadOnly = true;
            this.txtPlateNum.Size = new System.Drawing.Size(128, 21);
            this.txtPlateNum.TabIndex = 11;
            this.txtPlateNum.Tag = "N";
            // 
            // lblPlateNum
            // 
            this.lblPlateNum.AutoSize = true;
            this.lblPlateNum.ForeColor = System.Drawing.Color.Red;
            this.lblPlateNum.Location = new System.Drawing.Point(28, 24);
            this.lblPlateNum.Name = "lblPlateNum";
            this.lblPlateNum.Size = new System.Drawing.Size(56, 18);
            this.lblPlateNum.TabIndex = 10;
            this.lblPlateNum.Text = "车 牌 号";
            // 
            // txtCarModel
            // 
            // 
            // 
            // 
            this.txtCarModel.Border.Class = "TextBoxBorder";
            this.txtCarModel.Location = new System.Drawing.Point(315, 54);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.ReadOnly = true;
            this.txtCarModel.Size = new System.Drawing.Size(128, 21);
            this.txtCarModel.TabIndex = 9;
            this.txtCarModel.Tag = "N";
            // 
            // lblCarModel
            // 
            this.lblCarModel.AutoSize = true;
            this.lblCarModel.Location = new System.Drawing.Point(253, 57);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.Size = new System.Drawing.Size(56, 18);
            this.lblCarModel.TabIndex = 8;
            this.lblCarModel.Text = "车辆型号";
            // 
            // txtCarBrand
            // 
            // 
            // 
            // 
            this.txtCarBrand.Border.Class = "TextBoxBorder";
            this.txtCarBrand.Location = new System.Drawing.Point(89, 54);
            this.txtCarBrand.Name = "txtCarBrand";
            this.txtCarBrand.ReadOnly = true;
            this.txtCarBrand.Size = new System.Drawing.Size(128, 21);
            this.txtCarBrand.TabIndex = 7;
            this.txtCarBrand.Tag = "N";
            // 
            // lblCarSer
            // 
            this.lblCarSer.AutoSize = true;
            this.lblCarSer.Location = new System.Drawing.Point(40, 54);
            this.lblCarSer.Name = "lblCarSer";
            this.lblCarSer.Size = new System.Drawing.Size(44, 18);
            this.lblCarSer.TabIndex = 6;
            this.lblCarSer.Text = "车  系";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbComeType);
            this.groupBox2.Controls.Add(this.labelX2);
            this.groupBox2.Controls.Add(this.cmbCustType);
            this.groupBox2.Controls.Add(this.lblCustType);
            this.groupBox2.Controls.Add(this.chbP2PVip);
            this.groupBox2.Controls.Add(this.btnModify);
            this.groupBox2.Controls.Add(this.chbBuyHere);
            this.groupBox2.Controls.Add(this.chbPresent);
            this.groupBox2.Controls.Add(this.labelX1);
            this.groupBox2.Controls.Add(this.lblBalance);
            this.groupBox2.Controls.Add(this.lblVipType);
            this.groupBox2.Controls.Add(btnCustomerAdd);
            this.groupBox2.Controls.Add(btnCustomerFind);
            this.groupBox2.Controls.Add(this.txtCardNo);
            this.groupBox2.Controls.Add(this.lblCardNo);
            this.groupBox2.Controls.Add(this.txtMobile);
            this.groupBox2.Controls.Add(this.lblMobile);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.lblAddress);
            this.groupBox2.Controls.Add(this.txtCustName);
            this.groupBox2.Controls.Add(this.lblCustName);
            this.groupBox2.Location = new System.Drawing.Point(22, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(702, 126);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "客户信息";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cmbComeType
            // 
            this.cmbComeType.DisplayMember = "Text";
            this.cmbComeType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbComeType.FormattingEnabled = true;
            this.cmbComeType.ItemHeight = 15;
            this.cmbComeType.Items.AddRange(new object[] {
            this.comboItem11,
            this.comboItem12,
            this.comboItem9});
            this.cmbComeType.Location = new System.Drawing.Point(533, 59);
            this.cmbComeType.Name = "cmbComeType";
            this.cmbComeType.Size = new System.Drawing.Size(128, 21);
            this.cmbComeType.TabIndex = 132;
            this.cmbComeType.Tag = "N";
            // 
            // comboItem11
            // 
            this.comboItem11.Text = "保险推修";
            // 
            // comboItem12
            // 
            this.comboItem12.Text = "开拓进店";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX2.Location = new System.Drawing.Point(471, 63);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(56, 18);
            this.labelX2.TabIndex = 131;
            this.labelX2.Text = "进店方式";
            // 
            // cmbCustType
            // 
            this.cmbCustType.DisplayMember = "Text";
            this.cmbCustType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCustType.Enabled = false;
            this.cmbCustType.FormattingEnabled = true;
            this.cmbCustType.ItemHeight = 15;
            this.cmbCustType.Items.AddRange(new object[] {
            this.comboItem2,
            this.comboItem3,
            this.comboItem8});
            this.cmbCustType.Location = new System.Drawing.Point(315, 59);
            this.cmbCustType.Name = "cmbCustType";
            this.cmbCustType.Size = new System.Drawing.Size(128, 21);
            this.cmbCustType.TabIndex = 130;
            this.cmbCustType.Tag = "N";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "A类";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "B类";
            // 
            // comboItem8
            // 
            this.comboItem8.Text = "C类";
            // 
            // lblCustType
            // 
            this.lblCustType.AutoSize = true;
            this.lblCustType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCustType.Location = new System.Drawing.Point(253, 62);
            this.lblCustType.Name = "lblCustType";
            this.lblCustType.Size = new System.Drawing.Size(56, 18);
            this.lblCustType.TabIndex = 129;
            this.lblCustType.Text = "客户类型";
            // 
            // chbP2PVip
            // 
            this.chbP2PVip.Location = new System.Drawing.Point(561, 91);
            this.chbP2PVip.Name = "chbP2PVip";
            this.chbP2PVip.Size = new System.Drawing.Size(100, 23);
            this.chbP2PVip.TabIndex = 128;
            this.chbP2PVip.Text = "是否伟启会员";
            this.chbP2PVip.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            // 
            // btnModify
            // 
            this.btnModify.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnModify.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnModify.Location = new System.Drawing.Point(271, 24);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(38, 23);
            this.btnModify.TabIndex = 126;
            this.btnModify.Text = "修改";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // chbBuyHere
            // 
            this.chbBuyHere.Location = new System.Drawing.Point(454, 92);
            this.chbBuyHere.Name = "chbBuyHere";
            this.chbBuyHere.Size = new System.Drawing.Size(100, 23);
            this.chbBuyHere.TabIndex = 127;
            this.chbBuyHere.Text = "是否本店购车";
            this.chbBuyHere.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            // 
            // chbPresent
            // 
            this.chbPresent.Location = new System.Drawing.Point(586, 25);
            this.chbPresent.Name = "chbPresent";
            this.chbPresent.Size = new System.Drawing.Size(75, 23);
            this.chbPresent.TabIndex = 125;
            this.chbPresent.Text = "赠送装潢";
            this.chbPresent.Visible = false;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(330, 95);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(31, 18);
            this.labelX1.TabIndex = 124;
            this.labelX1.Text = "余额";
            this.labelX1.Visible = false;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(368, 97);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(25, 16);
            this.lblBalance.TabIndex = 123;
            this.lblBalance.Text = "0.0";
            this.lblBalance.Visible = false;
            // 
            // lblVipType
            // 
            this.lblVipType.AutoSize = true;
            this.lblVipType.Location = new System.Drawing.Point(226, 95);
            this.lblVipType.Name = "lblVipType";
            this.lblVipType.Size = new System.Drawing.Size(44, 18);
            this.lblVipType.TabIndex = 122;
            this.lblVipType.Text = "非会员";
            // 
            // txtCardNo
            // 
            // 
            // 
            // 
            this.txtCardNo.Border.Class = "TextBoxBorder";
            this.txtCardNo.Location = new System.Drawing.Point(89, 92);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.ReadOnly = true;
            this.txtCardNo.Size = new System.Drawing.Size(128, 21);
            this.txtCardNo.TabIndex = 13;
            this.txtCardNo.Tag = "N";
            // 
            // lblCardNo
            // 
            this.lblCardNo.AutoSize = true;
            this.lblCardNo.Location = new System.Drawing.Point(27, 95);
            this.lblCardNo.Name = "lblCardNo";
            this.lblCardNo.Size = new System.Drawing.Size(56, 18);
            this.lblCardNo.TabIndex = 12;
            this.lblCardNo.Text = "会员卡号";
            // 
            // txtMobile
            // 
            // 
            // 
            // 
            this.txtMobile.Border.Class = "TextBoxBorder";
            this.txtMobile.Location = new System.Drawing.Point(89, 60);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.ReadOnly = true;
            this.txtMobile.Size = new System.Drawing.Size(128, 21);
            this.txtMobile.TabIndex = 9;
            this.txtMobile.Tag = "N";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(40, 62);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(44, 18);
            this.lblMobile.TabIndex = 8;
            this.lblMobile.Text = "手  机";
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.Border.Class = "TextBoxBorder";
            this.txtAddress.Location = new System.Drawing.Point(366, 24);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(207, 21);
            this.txtAddress.TabIndex = 7;
            this.txtAddress.Tag = "N";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(324, 26);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(37, 18);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "地 址";
            // 
            // txtCustName
            // 
            // 
            // 
            // 
            this.txtCustName.Border.Class = "TextBoxBorder";
            this.txtCustName.Location = new System.Drawing.Point(89, 24);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(128, 21);
            this.txtCustName.TabIndex = 5;
            this.txtCustName.Tag = "N";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.ForeColor = System.Drawing.Color.Red;
            this.lblCustName.Location = new System.Drawing.Point(28, 27);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(56, 18);
            this.lblCustName.TabIndex = 4;
            this.lblCustName.Text = "客户名字";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpEstimateComplete);
            this.groupBox1.Controls.Add(this.lblEstimateComplete);
            this.groupBox1.Controls.Add(this.txtDecorateDH);
            this.groupBox1.Controls.Add(this.lblDecorateDH);
            this.groupBox1.Controls.Add(this.txtReceptTime);
            this.groupBox1.Controls.Add(lblRepChildType);
            this.groupBox1.Controls.Add(this.cmbRepChildType);
            this.groupBox1.Controls.Add(this.lblReceptTime);
            this.groupBox1.Controls.Add(this.txtDH);
            this.groupBox1.Controls.Add(this.txtReceptMan);
            this.groupBox1.Controls.Add(this.lblDH);
            this.groupBox1.Controls.Add(this.lblReceptMan);
            this.groupBox1.Controls.Add(lblRepType);
            this.groupBox1.Controls.Add(this.cmbRepType);
            this.groupBox1.Location = new System.Drawing.Point(22, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 89);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "单据信息";
            // 
            // dtpEstimateComplete
            // 
            this.dtpEstimateComplete.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEstimateComplete.Location = new System.Drawing.Point(542, 53);
            this.dtpEstimateComplete.Name = "dtpEstimateComplete";
            this.dtpEstimateComplete.Size = new System.Drawing.Size(128, 21);
            this.dtpEstimateComplete.TabIndex = 46;
            // 
            // lblEstimateComplete
            // 
            this.lblEstimateComplete.AutoSize = true;
            this.lblEstimateComplete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEstimateComplete.Location = new System.Drawing.Point(459, 56);
            this.lblEstimateComplete.Name = "lblEstimateComplete";
            this.lblEstimateComplete.Size = new System.Drawing.Size(81, 18);
            this.lblEstimateComplete.TabIndex = 45;
            this.lblEstimateComplete.Text = "预估完成时间";
            // 
            // txtDecorateDH
            // 
            // 
            // 
            // 
            this.txtDecorateDH.Border.Class = "TextBoxBorder";
            this.txtDecorateDH.Location = new System.Drawing.Point(542, 53);
            this.txtDecorateDH.Name = "txtDecorateDH";
            this.txtDecorateDH.ReadOnly = true;
            this.txtDecorateDH.Size = new System.Drawing.Size(128, 21);
            this.txtDecorateDH.TabIndex = 18;
            this.txtDecorateDH.Tag = "N";
            this.txtDecorateDH.Visible = false;
            this.txtDecorateDH.TextChanged += new System.EventHandler(this.textBoxX1_TextChanged);
            // 
            // lblDecorateDH
            // 
            this.lblDecorateDH.AutoSize = true;
            this.lblDecorateDH.Location = new System.Drawing.Point(480, 56);
            this.lblDecorateDH.Name = "lblDecorateDH";
            this.lblDecorateDH.Size = new System.Drawing.Size(56, 18);
            this.lblDecorateDH.TabIndex = 17;
            this.lblDecorateDH.Text = "销售单号";
            this.lblDecorateDH.Visible = false;
            this.lblDecorateDH.Click += new System.EventHandler(this.labelX2_Click);
            // 
            // txtReceptTime
            // 
            // 
            // 
            // 
            this.txtReceptTime.Border.Class = "TextBoxBorder";
            this.txtReceptTime.Location = new System.Drawing.Point(314, 53);
            this.txtReceptTime.Name = "txtReceptTime";
            this.txtReceptTime.ReadOnly = true;
            this.txtReceptTime.Size = new System.Drawing.Size(129, 21);
            this.txtReceptTime.TabIndex = 16;
            this.txtReceptTime.Tag = "N";
            // 
            // cmbRepChildType
            // 
            this.cmbRepChildType.DisplayMember = "Text";
            this.cmbRepChildType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRepChildType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRepChildType.FormattingEnabled = true;
            this.cmbRepChildType.ItemHeight = 15;
            this.cmbRepChildType.Items.AddRange(new object[] {
            this.comboItem4,
            this.comboItem5,
            this.comboItem6});
            this.cmbRepChildType.Location = new System.Drawing.Point(542, 19);
            this.cmbRepChildType.Name = "cmbRepChildType";
            this.cmbRepChildType.Size = new System.Drawing.Size(128, 21);
            this.cmbRepChildType.TabIndex = 14;
            this.cmbRepChildType.Tag = "N";
            this.cmbRepChildType.SelectedIndexChanged += new System.EventHandler(this.cmbRepChildType_SelectedIndexChanged);
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "维修";
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "保养";
            // 
            // comboItem6
            // 
            this.comboItem6.Text = "事故";
            // 
            // lblReceptTime
            // 
            this.lblReceptTime.AutoSize = true;
            this.lblReceptTime.Location = new System.Drawing.Point(252, 56);
            this.lblReceptTime.Name = "lblReceptTime";
            this.lblReceptTime.Size = new System.Drawing.Size(56, 18);
            this.lblReceptTime.TabIndex = 10;
            this.lblReceptTime.Text = "接车时间";
            // 
            // txtDH
            // 
            // 
            // 
            // 
            this.txtDH.Border.Class = "TextBoxBorder";
            this.txtDH.Location = new System.Drawing.Point(89, 21);
            this.txtDH.Name = "txtDH";
            this.txtDH.ReadOnly = true;
            this.txtDH.Size = new System.Drawing.Size(128, 21);
            this.txtDH.TabIndex = 3;
            this.txtDH.Tag = "N";
            // 
            // txtReceptMan
            // 
            // 
            // 
            // 
            this.txtReceptMan.Border.Class = "TextBoxBorder";
            this.txtReceptMan.Location = new System.Drawing.Point(89, 53);
            this.txtReceptMan.Name = "txtReceptMan";
            this.txtReceptMan.ReadOnly = true;
            this.txtReceptMan.Size = new System.Drawing.Size(128, 21);
            this.txtReceptMan.TabIndex = 11;
            this.txtReceptMan.Tag = "N";
            // 
            // lblDH
            // 
            this.lblDH.AutoSize = true;
            this.lblDH.Location = new System.Drawing.Point(39, 24);
            this.lblDH.Name = "lblDH";
            this.lblDH.Size = new System.Drawing.Size(44, 18);
            this.lblDH.TabIndex = 2;
            this.lblDH.Text = "单  号";
            this.lblDH.Click += new System.EventHandler(this.lblDH_Click);
            // 
            // lblReceptMan
            // 
            this.lblReceptMan.AutoSize = true;
            this.lblReceptMan.Location = new System.Drawing.Point(27, 54);
            this.lblReceptMan.Name = "lblReceptMan";
            this.lblReceptMan.Size = new System.Drawing.Size(56, 18);
            this.lblReceptMan.TabIndex = 10;
            this.lblReceptMan.Text = "接 车 人";
            // 
            // cmbRepType
            // 
            this.cmbRepType.DisplayMember = "Text";
            this.cmbRepType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRepType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRepType.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cmbRepType.FormattingEnabled = true;
            this.cmbRepType.ItemHeight = 15;
            this.cmbRepType.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem7});
            this.cmbRepType.Location = new System.Drawing.Point(315, 20);
            this.cmbRepType.Name = "cmbRepType";
            this.cmbRepType.Size = new System.Drawing.Size(128, 21);
            this.cmbRepType.TabIndex = 9;
            this.cmbRepType.Tag = "N";
            this.cmbRepType.SelectedIndexChanged += new System.EventHandler(this.cmbRepType_SelectedIndexChanged_1);
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "维修";
            // 
            // comboItem7
            // 
            this.comboItem7.Text = "装潢";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.tdrRecept,
            this.tdrAccount,
            this.btnPrintDele,
            this.btnDel,
            this.menuClaim});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(989, 25);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(52, 22);
            this.btnSave.Tag = "add";
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tdrRecept
            // 
            this.tdrRecept.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnRecept,
            this.tbtnUnRecept});
            this.tdrRecept.Image = global::Auto4SErp.Properties.Resources.recept;
            this.tdrRecept.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tdrRecept.Name = "tdrRecept";
            this.tdrRecept.Size = new System.Drawing.Size(61, 22);
            this.tdrRecept.Text = "接车";
            // 
            // tbtnRecept
            // 
            this.tbtnRecept.Name = "tbtnRecept";
            this.tbtnRecept.Size = new System.Drawing.Size(124, 22);
            this.tbtnRecept.Text = "接车完成";
            this.tbtnRecept.Click += new System.EventHandler(this.tbtnRecept_Click);
            // 
            // tbtnUnRecept
            // 
            this.tbtnUnRecept.Name = "tbtnUnRecept";
            this.tbtnUnRecept.Size = new System.Drawing.Size(124, 22);
            this.tbtnUnRecept.Text = "放弃接车";
            this.tbtnUnRecept.Click += new System.EventHandler(this.tbtnUnRecept_Click);
            // 
            // tdrAccount
            // 
            this.tdrAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnPreAccount,
            this.tbtnUnPreAccount});
            this.tdrAccount.Image = global::Auto4SErp.Properties.Resources.preacount;
            this.tdrAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tdrAccount.Name = "tdrAccount";
            this.tdrAccount.Size = new System.Drawing.Size(73, 22);
            this.tdrAccount.Text = "预结算";
            // 
            // tbtnPreAccount
            // 
            this.tbtnPreAccount.Name = "tbtnPreAccount";
            this.tbtnPreAccount.Size = new System.Drawing.Size(136, 22);
            this.tbtnPreAccount.Text = "预结算";
            this.tbtnPreAccount.Click += new System.EventHandler(this.tbtnPreAccount_Click);
            // 
            // tbtnUnPreAccount
            // 
            this.tbtnUnPreAccount.Name = "tbtnUnPreAccount";
            this.tbtnUnPreAccount.Size = new System.Drawing.Size(136, 22);
            this.tbtnUnPreAccount.Text = "放弃预结算";
            this.tbtnUnPreAccount.Click += new System.EventHandler(this.tbtnUnPreAccount_Click);
            // 
            // btnPrintDele
            // 
            this.btnPrintDele.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPrintDemand,
            this.btnPrintRep,
            this.btnPrintAccount,
            this.takeToolStripMenuItem});
            this.btnPrintDele.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintDele.Image")));
            this.btnPrintDele.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrintDele.Name = "btnPrintDele";
            this.btnPrintDele.Size = new System.Drawing.Size(61, 22);
            this.btnPrintDele.Tag = "print";
            this.btnPrintDele.Text = "打印";
            this.btnPrintDele.Click += new System.EventHandler(this.btnPrintDele_Click);
            // 
            // btnPrintDemand
            // 
            this.btnPrintDemand.Name = "btnPrintDemand";
            this.btnPrintDemand.Size = new System.Drawing.Size(136, 22);
            this.btnPrintDemand.Text = "领料需求";
            this.btnPrintDemand.Click += new System.EventHandler(this.btnPrintDemand_Click);
            // 
            // btnPrintRep
            // 
            this.btnPrintRep.Name = "btnPrintRep";
            this.btnPrintRep.Size = new System.Drawing.Size(136, 22);
            this.btnPrintRep.Text = "维修委托书";
            this.btnPrintRep.Click += new System.EventHandler(this.btnPrintRep_Click);
            // 
            // btnPrintAccount
            // 
            this.btnPrintAccount.Name = "btnPrintAccount";
            this.btnPrintAccount.Size = new System.Drawing.Size(136, 22);
            this.btnPrintAccount.Text = "维修结算单";
            this.btnPrintAccount.Click += new System.EventHandler(this.btnRepAccount_Click);
            // 
            // takeToolStripMenuItem
            // 
            this.takeToolStripMenuItem.Name = "takeToolStripMenuItem";
            this.takeToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.takeToolStripMenuItem.Text = "领料明细";
            this.takeToolStripMenuItem.Click += new System.EventHandler(this.takeToolStripMenuItem_Click);
            // 
            // btnDel
            // 
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(52, 22);
            this.btnDel.Tag = "delete";
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // menuClaim
            // 
            this.menuClaim.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuClaim.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCalimSure,
            this.btnClaimModify});
            this.menuClaim.Enabled = false;
            this.menuClaim.Image = ((System.Drawing.Image)(resources.GetObject("menuClaim.Image")));
            this.menuClaim.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuClaim.Name = "menuClaim";
            this.menuClaim.Size = new System.Drawing.Size(93, 22);
            this.menuClaim.Text = "财务索赔操作";
            this.menuClaim.Click += new System.EventHandler(this.menuClaim_Click);
            // 
            // btnCalimSure
            // 
            this.btnCalimSure.Name = "btnCalimSure";
            this.btnCalimSure.Size = new System.Drawing.Size(124, 22);
            this.btnCalimSure.Text = "索赔确认";
            this.btnCalimSure.Click += new System.EventHandler(this.btnCalimSure_Click);
            // 
            // btnClaimModify
            // 
            this.btnClaimModify.Name = "btnClaimModify";
            this.btnClaimModify.Size = new System.Drawing.Size(124, 22);
            this.btnClaimModify.Text = "修改金额";
            this.btnClaimModify.Click += new System.EventHandler(this.btnClaimModify_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtSystemDH);
            this.groupBox5.Controls.Add(this.labelX3);
            this.groupBox5.Controls.Add(this.txtLastMil);
            this.groupBox5.Controls.Add(this.lblLastMil);
            this.groupBox5.Controls.Add(this.txtRemark);
            this.groupBox5.Controls.Add(this.lblRemark);
            this.groupBox5.Controls.Add(this.datKeepEnd);
            this.groupBox5.Controls.Add(this.lblKeepEnd);
            this.groupBox5.Controls.Add(this.datKeepBegin);
            this.groupBox5.Controls.Add(this.lblKeepBegin);
            this.groupBox5.Controls.Add(this.datNextKeepDate);
            this.groupBox5.Controls.Add(this.datInEnd);
            this.groupBox5.Controls.Add(this.lblInEnd);
            this.groupBox5.Controls.Add(this.datInBegin);
            this.groupBox5.Controls.Add(this.lblInBegin);
            this.groupBox5.Controls.Add(this.lblNextKeepDate);
            this.groupBox5.Controls.Add(this.txtNextKeepMil);
            this.groupBox5.Controls.Add(this.lblNextKeepMil);
            this.groupBox5.Controls.Add(this.txtInMil);
            this.groupBox5.Controls.Add(this.lblInMil);
            this.groupBox5.Controls.Add(this.chbIsNeedOld);
            this.groupBox5.Controls.Add(this.chbIsWash);
            this.groupBox5.Controls.Add(this.chbIsWillVisit);
            this.groupBox5.Controls.Add(this.txtSendRepTel);
            this.groupBox5.Controls.Add(this.lblSendRepTel);
            this.groupBox5.Controls.Add(this.txtSendRepMan);
            this.groupBox5.Controls.Add(this.lblSendRepMan);
            this.groupBox5.Controls.Add(this.txtInsuranceCompany);
            this.groupBox5.Controls.Add(this.lblInsuranceCompany);
            this.groupBox5.Location = new System.Drawing.Point(753, 28);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(223, 696);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "其它信息";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // txtSystemDH
            // 
            // 
            // 
            // 
            this.txtSystemDH.Border.Class = "TextBoxBorder";
            this.txtSystemDH.Location = new System.Drawing.Point(97, 37);
            this.txtSystemDH.Name = "txtSystemDH";
            this.txtSystemDH.Size = new System.Drawing.Size(108, 21);
            this.txtSystemDH.TabIndex = 50;
            this.txtSystemDH.Tag = "N";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX3.Location = new System.Drawing.Point(38, 40);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(56, 18);
            this.labelX3.TabIndex = 49;
            this.labelX3.Text = "厂家单号";
            // 
            // txtLastMil
            // 
            // 
            // 
            // 
            this.txtLastMil.Border.Class = "TextBoxBorder";
            this.txtLastMil.Location = new System.Drawing.Point(98, 253);
            this.txtLastMil.Name = "txtLastMil";
            this.txtLastMil.ReadOnly = true;
            this.txtLastMil.Size = new System.Drawing.Size(108, 21);
            this.txtLastMil.TabIndex = 48;
            this.txtLastMil.Tag = "N";
            // 
            // lblLastMil
            // 
            this.lblLastMil.AutoSize = true;
            this.lblLastMil.Location = new System.Drawing.Point(14, 256);
            this.lblLastMil.Name = "lblLastMil";
            this.lblLastMil.Size = new System.Drawing.Size(81, 18);
            this.lblLastMil.TabIndex = 47;
            this.lblLastMil.Text = "上次里程(km)";
            // 
            // txtRemark
            // 
            // 
            // 
            // 
            this.txtRemark.Border.Class = "TextBoxBorder";
            this.txtRemark.Location = new System.Drawing.Point(98, 469);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(108, 57);
            this.txtRemark.TabIndex = 46;
            this.txtRemark.Tag = "N";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(54, 471);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(37, 18);
            this.lblRemark.TabIndex = 45;
            this.lblRemark.Text = "备 注";
            // 
            // datKeepEnd
            // 
            this.datKeepEnd.Enabled = false;
            this.datKeepEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datKeepEnd.Location = new System.Drawing.Point(98, 110);
            this.datKeepEnd.Name = "datKeepEnd";
            this.datKeepEnd.Size = new System.Drawing.Size(108, 21);
            this.datKeepEnd.TabIndex = 44;
            // 
            // lblKeepEnd
            // 
            this.lblKeepEnd.AutoSize = true;
            this.lblKeepEnd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKeepEnd.Location = new System.Drawing.Point(14, 111);
            this.lblKeepEnd.Name = "lblKeepEnd";
            this.lblKeepEnd.Size = new System.Drawing.Size(81, 18);
            this.lblKeepEnd.TabIndex = 43;
            this.lblKeepEnd.Text = "保修结束日期";
            // 
            // datKeepBegin
            // 
            this.datKeepBegin.Enabled = false;
            this.datKeepBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datKeepBegin.Location = new System.Drawing.Point(98, 72);
            this.datKeepBegin.Name = "datKeepBegin";
            this.datKeepBegin.Size = new System.Drawing.Size(108, 21);
            this.datKeepBegin.TabIndex = 42;
            // 
            // lblKeepBegin
            // 
            this.lblKeepBegin.AutoSize = true;
            this.lblKeepBegin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKeepBegin.Location = new System.Drawing.Point(15, 74);
            this.lblKeepBegin.Name = "lblKeepBegin";
            this.lblKeepBegin.Size = new System.Drawing.Size(81, 18);
            this.lblKeepBegin.TabIndex = 41;
            this.lblKeepBegin.Text = "保修开始日期";
            // 
            // datNextKeepDate
            // 
            this.datNextKeepDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datNextKeepDate.Location = new System.Drawing.Point(98, 363);
            this.datNextKeepDate.Name = "datNextKeepDate";
            this.datNextKeepDate.Size = new System.Drawing.Size(108, 21);
            this.datNextKeepDate.TabIndex = 40;
            // 
            // datInEnd
            // 
            this.datInEnd.Enabled = false;
            this.datInEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datInEnd.Location = new System.Drawing.Point(98, 218);
            this.datInEnd.Name = "datInEnd";
            this.datInEnd.Size = new System.Drawing.Size(108, 21);
            this.datInEnd.TabIndex = 39;
            // 
            // lblInEnd
            // 
            this.lblInEnd.AutoSize = true;
            this.lblInEnd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInEnd.Location = new System.Drawing.Point(14, 219);
            this.lblInEnd.Name = "lblInEnd";
            this.lblInEnd.Size = new System.Drawing.Size(81, 18);
            this.lblInEnd.TabIndex = 38;
            this.lblInEnd.Text = "保险结束日期";
            // 
            // datInBegin
            // 
            this.datInBegin.Enabled = false;
            this.datInBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datInBegin.Location = new System.Drawing.Point(98, 180);
            this.datInBegin.Name = "datInBegin";
            this.datInBegin.Size = new System.Drawing.Size(108, 21);
            this.datInBegin.TabIndex = 37;
            // 
            // lblInBegin
            // 
            this.lblInBegin.AutoSize = true;
            this.lblInBegin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInBegin.Location = new System.Drawing.Point(15, 183);
            this.lblInBegin.Name = "lblInBegin";
            this.lblInBegin.Size = new System.Drawing.Size(81, 18);
            this.lblInBegin.TabIndex = 36;
            this.lblInBegin.Text = "保险开始日期";
            // 
            // lblNextKeepDate
            // 
            this.lblNextKeepDate.AutoSize = true;
            this.lblNextKeepDate.Location = new System.Drawing.Point(14, 366);
            this.lblNextKeepDate.Name = "lblNextKeepDate";
            this.lblNextKeepDate.Size = new System.Drawing.Size(81, 18);
            this.lblNextKeepDate.TabIndex = 32;
            this.lblNextKeepDate.Text = "下次保养日期";
            // 
            // txtNextKeepMil
            // 
            // 
            // 
            // 
            this.txtNextKeepMil.Border.Class = "TextBoxBorder";
            this.txtNextKeepMil.Location = new System.Drawing.Point(98, 325);
            this.txtNextKeepMil.Name = "txtNextKeepMil";
            this.txtNextKeepMil.Size = new System.Drawing.Size(108, 21);
            this.txtNextKeepMil.TabIndex = 31;
            this.txtNextKeepMil.Tag = "N";
            // 
            // lblNextKeepMil
            // 
            this.lblNextKeepMil.AutoSize = true;
            this.lblNextKeepMil.Location = new System.Drawing.Point(13, 329);
            this.lblNextKeepMil.Name = "lblNextKeepMil";
            this.lblNextKeepMil.Size = new System.Drawing.Size(81, 18);
            this.lblNextKeepMil.TabIndex = 30;
            this.lblNextKeepMil.Text = "下次保养里程";
            // 
            // txtInMil
            // 
            // 
            // 
            // 
            this.txtInMil.Border.Class = "TextBoxBorder";
            this.txtInMil.Location = new System.Drawing.Point(98, 289);
            this.txtInMil.Name = "txtInMil";
            this.txtInMil.Size = new System.Drawing.Size(108, 21);
            this.txtInMil.TabIndex = 29;
            this.txtInMil.Tag = "N";
            // 
            // lblInMil
            // 
            this.lblInMil.AutoSize = true;
            this.lblInMil.ForeColor = System.Drawing.Color.Red;
            this.lblInMil.Location = new System.Drawing.Point(14, 292);
            this.lblInMil.Name = "lblInMil";
            this.lblInMil.Size = new System.Drawing.Size(81, 18);
            this.lblInMil.TabIndex = 28;
            this.lblInMil.Text = "进厂里程(km)";
            // 
            // chbIsNeedOld
            // 
            this.chbIsNeedOld.Location = new System.Drawing.Point(45, 603);
            this.chbIsNeedOld.Name = "chbIsNeedOld";
            this.chbIsNeedOld.Size = new System.Drawing.Size(141, 23);
            this.chbIsNeedOld.TabIndex = 27;
            this.chbIsNeedOld.Text = "是否需要旧件";
            // 
            // chbIsWash
            // 
            this.chbIsWash.Location = new System.Drawing.Point(45, 572);
            this.chbIsWash.Name = "chbIsWash";
            this.chbIsWash.Size = new System.Drawing.Size(141, 23);
            this.chbIsWash.TabIndex = 26;
            this.chbIsWash.Text = "是否需要清洗车辆";
            // 
            // chbIsWillVisit
            // 
            this.chbIsWillVisit.Location = new System.Drawing.Point(45, 542);
            this.chbIsWillVisit.Name = "chbIsWillVisit";
            this.chbIsWillVisit.Size = new System.Drawing.Size(151, 23);
            this.chbIsWillVisit.TabIndex = 25;
            this.chbIsWillVisit.Text = "是否确认三天后回访";
            // 
            // txtSendRepTel
            // 
            // 
            // 
            // 
            this.txtSendRepTel.Border.Class = "TextBoxBorder";
            this.txtSendRepTel.Location = new System.Drawing.Point(98, 434);
            this.txtSendRepTel.Name = "txtSendRepTel";
            this.txtSendRepTel.Size = new System.Drawing.Size(108, 21);
            this.txtSendRepTel.TabIndex = 24;
            this.txtSendRepTel.Tag = "N";
            // 
            // lblSendRepTel
            // 
            this.lblSendRepTel.AutoSize = true;
            this.lblSendRepTel.Location = new System.Drawing.Point(23, 436);
            this.lblSendRepTel.Name = "lblSendRepTel";
            this.lblSendRepTel.Size = new System.Drawing.Size(68, 18);
            this.lblSendRepTel.TabIndex = 23;
            this.lblSendRepTel.Text = "送修人电话";
            // 
            // txtSendRepMan
            // 
            // 
            // 
            // 
            this.txtSendRepMan.Border.Class = "TextBoxBorder";
            this.txtSendRepMan.Location = new System.Drawing.Point(98, 400);
            this.txtSendRepMan.Name = "txtSendRepMan";
            this.txtSendRepMan.Size = new System.Drawing.Size(108, 21);
            this.txtSendRepMan.TabIndex = 22;
            this.txtSendRepMan.Tag = "N";
            // 
            // lblSendRepMan
            // 
            this.lblSendRepMan.AutoSize = true;
            this.lblSendRepMan.Location = new System.Drawing.Point(36, 402);
            this.lblSendRepMan.Name = "lblSendRepMan";
            this.lblSendRepMan.Size = new System.Drawing.Size(56, 18);
            this.lblSendRepMan.TabIndex = 21;
            this.lblSendRepMan.Text = "送 修 人";
            // 
            // txtInsuranceCompany
            // 
            // 
            // 
            // 
            this.txtInsuranceCompany.Border.Class = "TextBoxBorder";
            this.txtInsuranceCompany.Location = new System.Drawing.Point(98, 145);
            this.txtInsuranceCompany.Name = "txtInsuranceCompany";
            this.txtInsuranceCompany.ReadOnly = true;
            this.txtInsuranceCompany.Size = new System.Drawing.Size(108, 21);
            this.txtInsuranceCompany.TabIndex = 13;
            this.txtInsuranceCompany.Tag = "N";
            // 
            // lblInsuranceCompany
            // 
            this.lblInsuranceCompany.AutoSize = true;
            this.lblInsuranceCompany.ForeColor = System.Drawing.Color.Red;
            this.lblInsuranceCompany.Location = new System.Drawing.Point(36, 147);
            this.lblInsuranceCompany.Name = "lblInsuranceCompany";
            this.lblInsuranceCompany.Size = new System.Drawing.Size(56, 18);
            this.lblInsuranceCompany.TabIndex = 12;
            this.lblInsuranceCompany.Text = "保险公司";
            // 
            // comboItem9
            // 
            this.comboItem9.Text = "自然进店";
            // 
            // frmRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 734);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox5);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRepair";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "维修单";
            this.Load += new System.EventHandler(this.frmRepair_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmRepair_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(btnGetVin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(btnCustomerAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(btnCustomerFind)).EndInit();
            this.cmenuRepairItem.ResumeLayout(false);
            this.cmenuAcc.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgRepairItem)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAccessory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ContextMenuStrip cmenuRepairItem;
        private System.Windows.Forms.ToolStripMenuItem DelToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmenuAcc;
        private System.Windows.Forms.ToolStripMenuItem AddtoolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tdrRecept;
        private System.Windows.Forms.ToolStripMenuItem tbtnRecept;
        private System.Windows.Forms.ToolStripMenuItem tbtnUnRecept;
        private System.Windows.Forms.ToolStripDropDownButton tdrAccount;
        private System.Windows.Forms.ToolStripMenuItem tbtnPreAccount;
        private System.Windows.Forms.ToolStripMenuItem tbtnUnPreAccount;
        private System.Windows.Forms.ToolStripMenuItem AddItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dModifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton btnPrintDele;
        private System.Windows.Forms.ToolStripMenuItem btnPrintDemand;
        private System.Windows.Forms.ToolStripMenuItem DelDemandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ResetItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ResetAccToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtReceptTime;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPreAccessoryAmount;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPreItemAmount;
        private DevComponents.DotNetBar.LabelX lblReceptTime;
        private DevComponents.DotNetBar.LabelX lblPreAccessoryAmount;
        private DevComponents.DotNetBar.LabelX lblPreItemAmount;
        private System.Windows.Forms.GroupBox groupBox5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtInsuranceCompany;
        private DevComponents.DotNetBar.LabelX lblInsuranceCompany;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtColor;
        private DevComponents.DotNetBar.LabelX lblColor;
        private DevComponents.DotNetBar.Controls.TextBoxX txtVin;
        private DevComponents.DotNetBar.LabelX lblVin;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPlateNum;
        private DevComponents.DotNetBar.LabelX lblPlateNum;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCarModel;
        private DevComponents.DotNetBar.LabelX lblCarModel;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCarBrand;
        private DevComponents.DotNetBar.LabelX lblCarSer;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCardNo;
        private DevComponents.DotNetBar.LabelX lblCardNo;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMobile;
        private DevComponents.DotNetBar.LabelX lblMobile;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAddress;
        private DevComponents.DotNetBar.LabelX lblAddress;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCustName;
        private DevComponents.DotNetBar.LabelX lblCustName;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbRepChildType;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.ComboItem comboItem5;
        private DevComponents.Editors.ComboItem comboItem6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDH;
        private DevComponents.DotNetBar.Controls.TextBoxX txtReceptMan;
        private DevComponents.DotNetBar.LabelX lblDH;
        private DevComponents.DotNetBar.LabelX lblReceptMan;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbRepType;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgRepairItem;
        private System.Windows.Forms.TabPage tabPage2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgAccessory;
        private System.Windows.Forms.ToolStripButton btnDel;
        private DevComponents.DotNetBar.LabelX lblVipType;
        private System.Windows.Forms.ToolStripMenuItem btnPrintRep;
        private DevComponents.DotNetBar.LabelX lblBalance;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAll;
        private DevComponents.DotNetBar.LabelX lblAll;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDecorateDH;
        private DevComponents.DotNetBar.LabelX lblDecorateDH;
        private DevComponents.DotNetBar.Controls.CheckBoxX chbPresent;
        private DevComponents.DotNetBar.ButtonX btnModify;
        private DevComponents.DotNetBar.Controls.CheckBoxX chbIsNeedOld;
        private DevComponents.DotNetBar.Controls.CheckBoxX chbIsWash;
        private DevComponents.DotNetBar.Controls.CheckBoxX chbIsWillVisit;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSendRepTel;
        private DevComponents.DotNetBar.LabelX lblSendRepTel;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSendRepMan;
        private DevComponents.DotNetBar.LabelX lblSendRepMan;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNextKeepMil;
        private DevComponents.DotNetBar.LabelX lblNextKeepMil;
        private DevComponents.DotNetBar.Controls.TextBoxX txtInMil;
        private DevComponents.DotNetBar.LabelX lblInMil;
        private DevComponents.DotNetBar.LabelX lblNextKeepDate;
        private System.Windows.Forms.DateTimePicker datInBegin;
        private DevComponents.DotNetBar.LabelX lblInBegin;
        private System.Windows.Forms.DateTimePicker datInEnd;
        private DevComponents.DotNetBar.LabelX lblInEnd;
        private DevComponents.DotNetBar.Controls.CheckBoxX chbP2PVip;
        private DevComponents.DotNetBar.Controls.CheckBoxX chbBuyHere;
        private System.Windows.Forms.DataGridViewTextBoxColumn xxh;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccType;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessorycode;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessoryname;
        private System.Windows.Forms.DataGridViewTextBoxColumn HouseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPriceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn sum1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn aFinalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TakeMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TakeDate;
        private System.Windows.Forms.DateTimePicker datNextKeepDate;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbCustType;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem8;
        private DevComponents.DotNetBar.LabelX lblCustType;
        private System.Windows.Forms.DateTimePicker datKeepEnd;
        private DevComponents.DotNetBar.LabelX lblKeepEnd;
        private System.Windows.Forms.DateTimePicker datKeepBegin;
        private DevComponents.DotNetBar.LabelX lblKeepBegin;
        private System.Windows.Forms.DateTimePicker dtpEstimateComplete;
        private DevComponents.DotNetBar.LabelX lblEstimateComplete;
        private System.Windows.Forms.ToolStripMenuItem btnPrintAccount;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLastMil;
        private DevComponents.DotNetBar.LabelX lblLastMil;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRemark;
        private DevComponents.DotNetBar.LabelX lblRemark;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEngineID;
        private DevComponents.DotNetBar.LabelX lblEngineID;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbComeType;
        private DevComponents.Editors.ComboItem comboItem11;
        private DevComponents.Editors.ComboItem comboItem12;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSystemDH;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.ToolStripMenuItem takeToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn XH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemname;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricetype;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpWorkH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActWorkH;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemtotalprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeOfWork;
        private System.Windows.Forms.DataGridViewTextBoxColumn faultDescribe;
        private System.Windows.Forms.DataGridViewTextBoxColumn faultReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceidhide;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAccessAmount;
        private DevComponents.DotNetBar.LabelX lblAccessAmount;
        private System.Windows.Forms.ToolStripDropDownButton menuClaim;
        private System.Windows.Forms.ToolStripMenuItem btnCalimSure;
        private System.Windows.Forms.ToolStripMenuItem btnClaimModify;
        private DevComponents.Editors.ComboItem comboItem9;

    }
}