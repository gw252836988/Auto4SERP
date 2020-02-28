namespace Auto4SErp.Repair
{
    partial class frmClaim
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClaim));
            this.dgClaim = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.chbSel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClaimDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlateNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElseAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClaimAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lblSum = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.lblaccsum = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.lblitemsum = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDate = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem6 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.lblStatus = new DevComponents.DotNetBar.LabelX();
            this.cmbStatus = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.txtVin = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblVin = new DevComponents.DotNetBar.LabelX();
            this.datBegin = new System.Windows.Forms.DateTimePicker();
            this.datEnd = new System.Windows.Forms.DateTimePicker();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlateNum = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblPlateNum = new DevComponents.DotNetBar.LabelX();
            this.txtCustName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCustName = new DevComponents.DotNetBar.LabelX();
            this.txtRepDH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblRepDH = new DevComponents.DotNetBar.LabelX();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.btnOPen1 = new System.Windows.Forms.ToolStripButton();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnModify = new System.Windows.Forms.ToolStripButton();
            this.btnSelect = new System.Windows.Forms.ToolStripButton();
            this.btnAllSelect = new System.Windows.Forms.ToolStripButton();
            this.btnOut = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgClaim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgClaim
            // 
            this.dgClaim.AllowUserToAddRows = false;
            this.dgClaim.AllowUserToDeleteRows = false;
            this.dgClaim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClaim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chbSel,
            this.ID,
            this.cstatus,
            this.RepDH,
            this.ClaimDH,
            this.CreateDate,
            this.AccountDate,
            this.AccessDate,
            this.CustName,
            this.PlateNum,
            this.Vin,
            this.accAmount,
            this.ItemAmount,
            this.ElseAmount,
            this.ClaimAmount,
            this.AccessAmount,
            this.PostMan,
            this.BillDH});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgClaim.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgClaim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgClaim.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgClaim.Location = new System.Drawing.Point(0, 133);
            this.dgClaim.Name = "dgClaim";
            this.dgClaim.RowTemplate.Height = 23;
            this.dgClaim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgClaim.Size = new System.Drawing.Size(913, 274);
            this.dgClaim.TabIndex = 43;
            // 
            // chbSel
            // 
            this.chbSel.HeaderText = "";
            this.chbSel.Name = "chbSel";
            this.chbSel.Visible = false;
            this.chbSel.Width = 50;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "iD";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // cstatus
            // 
            this.cstatus.DataPropertyName = "cstatus";
            this.cstatus.HeaderText = "状态";
            this.cstatus.Name = "cstatus";
            // 
            // RepDH
            // 
            this.RepDH.DataPropertyName = "RepDH";
            this.RepDH.HeaderText = "维修单号";
            this.RepDH.Name = "RepDH";
            // 
            // ClaimDH
            // 
            this.ClaimDH.DataPropertyName = "ClaimDH";
            this.ClaimDH.HeaderText = "厂家索赔单号";
            this.ClaimDH.Name = "ClaimDH";
            // 
            // CreateDate
            // 
            this.CreateDate.DataPropertyName = "CreateDate";
            this.CreateDate.HeaderText = "登记时间";
            this.CreateDate.Name = "CreateDate";
            // 
            // AccountDate
            // 
            this.AccountDate.DataPropertyName = "AccountDate";
            this.AccountDate.HeaderText = "结算时间";
            this.AccountDate.Name = "AccountDate";
            // 
            // AccessDate
            // 
            this.AccessDate.DataPropertyName = "AccessDate";
            this.AccessDate.HeaderText = "通过时间";
            this.AccessDate.Name = "AccessDate";
            // 
            // CustName
            // 
            this.CustName.DataPropertyName = "CustName";
            this.CustName.HeaderText = "客户名称";
            this.CustName.Name = "CustName";
            // 
            // PlateNum
            // 
            this.PlateNum.DataPropertyName = "PlateNum";
            this.PlateNum.HeaderText = "车牌号";
            this.PlateNum.Name = "PlateNum";
            // 
            // Vin
            // 
            this.Vin.DataPropertyName = "Vin";
            this.Vin.HeaderText = "Vin";
            this.Vin.Name = "Vin";
            // 
            // accAmount
            // 
            this.accAmount.DataPropertyName = "accAmount";
            this.accAmount.HeaderText = "配件金额";
            this.accAmount.Name = "accAmount";
            // 
            // ItemAmount
            // 
            this.ItemAmount.DataPropertyName = "ItemAmount";
            this.ItemAmount.HeaderText = "项目金额";
            this.ItemAmount.Name = "ItemAmount";
            // 
            // ElseAmount
            // 
            this.ElseAmount.DataPropertyName = "ElseAmount";
            this.ElseAmount.HeaderText = "其它金额";
            this.ElseAmount.Name = "ElseAmount";
            // 
            // ClaimAmount
            // 
            this.ClaimAmount.DataPropertyName = "ClaimAmount";
            this.ClaimAmount.HeaderText = "索赔金额";
            this.ClaimAmount.Name = "ClaimAmount";
            // 
            // AccessAmount
            // 
            this.AccessAmount.DataPropertyName = "AccessAmount";
            this.AccessAmount.HeaderText = "通过金额";
            this.AccessAmount.Name = "AccessAmount";
            // 
            // PostMan
            // 
            this.PostMan.DataPropertyName = "PostMan";
            this.PostMan.HeaderText = "申报人";
            this.PostMan.Name = "PostMan";
            // 
            // BillDH
            // 
            this.BillDH.DataPropertyName = "BillDH";
            this.BillDH.HeaderText = "开票单号";
            this.BillDH.Name = "BillDH";
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
            this.toolStripLabel1,
            this.lblSum,
            this.toolStripLabel2,
            this.lblaccsum,
            this.toolStripLabel3,
            this.lblitemsum});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 407);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(913, 25);
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(80, 22);
            this.toolStripLabel1.Text = "通过总金额：";
            // 
            // lblSum
            // 
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(15, 22);
            this.lblSum.Text = "0";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(68, 22);
            this.toolStripLabel2.Text = "配件金额：";
            // 
            // lblaccsum
            // 
            this.lblaccsum.Name = "lblaccsum";
            this.lblaccsum.Size = new System.Drawing.Size(15, 22);
            this.lblaccsum.Text = "0";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(68, 22);
            this.toolStripLabel3.Text = "项目金额：";
            // 
            // lblitemsum
            // 
            this.lblitemsum.Name = "lblitemsum";
            this.lblitemsum.Size = new System.Drawing.Size(15, 22);
            this.lblitemsum.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.txtVin);
            this.groupBox1.Controls.Add(this.lblVin);
            this.groupBox1.Controls.Add(this.datBegin);
            this.groupBox1.Controls.Add(this.datEnd);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPlateNum);
            this.groupBox1.Controls.Add(this.lblPlateNum);
            this.groupBox1.Controls.Add(this.txtCustName);
            this.groupBox1.Controls.Add(this.lblCustName);
            this.groupBox1.Controls.Add(this.txtRepDH);
            this.groupBox1.Controls.Add(this.lblRepDH);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(913, 108);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            // 
            // txtDate
            // 
            this.txtDate.DisplayMember = "Text";
            this.txtDate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtDate.FormattingEnabled = true;
            this.txtDate.ItemHeight = 15;
            this.txtDate.Items.AddRange(new object[] {
            this.comboItem6,
            this.comboItem4,
            this.comboItem5});
            this.txtDate.Location = new System.Drawing.Point(125, 31);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(123, 21);
            this.txtDate.TabIndex = 44;
            this.txtDate.Tag = "N";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "结算日期";
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "通过日期";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(712, 68);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 18);
            this.lblStatus.TabIndex = 43;
            this.lblStatus.Text = "状  态";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DisplayMember = "Text";
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.ItemHeight = 15;
            this.cmbStatus.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.cmbStatus.Location = new System.Drawing.Point(762, 65);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(99, 21);
            this.cmbStatus.TabIndex = 42;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "已通过";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "未通过";
            // 
            // txtVin
            // 
            // 
            // 
            // 
            this.txtVin.Border.Class = "TextBoxBorder";
            this.txtVin.Location = new System.Drawing.Point(328, 67);
            this.txtVin.Name = "txtVin";
            this.txtVin.Size = new System.Drawing.Size(123, 21);
            this.txtVin.TabIndex = 41;
            this.txtVin.Tag = "F1S1";
            // 
            // lblVin
            // 
            this.lblVin.AutoSize = true;
            this.lblVin.Location = new System.Drawing.Point(285, 71);
            this.lblVin.Name = "lblVin";
            this.lblVin.Size = new System.Drawing.Size(37, 16);
            this.lblVin.TabIndex = 40;
            this.lblVin.Text = "V I N";
            // 
            // datBegin
            // 
            this.datBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datBegin.Location = new System.Drawing.Point(282, 32);
            this.datBegin.Name = "datBegin";
            this.datBegin.Size = new System.Drawing.Size(108, 21);
            this.datBegin.TabIndex = 39;
            // 
            // datEnd
            // 
            this.datEnd.Checked = false;
            this.datEnd.CustomFormat = "";
            this.datEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datEnd.Location = new System.Drawing.Point(419, 32);
            this.datEnd.Name = "datEnd";
            this.datEnd.Size = new System.Drawing.Size(104, 21);
            this.datEnd.TabIndex = 38;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(75, 33);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(44, 18);
            this.labelX1.TabIndex = 36;
            this.labelX1.Text = "日  期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 35;
            this.label1.Text = "至";
            // 
            // txtPlateNum
            // 
            // 
            // 
            // 
            this.txtPlateNum.Border.Class = "TextBoxBorder";
            this.txtPlateNum.Location = new System.Drawing.Point(125, 67);
            this.txtPlateNum.Name = "txtPlateNum";
            this.txtPlateNum.Size = new System.Drawing.Size(123, 21);
            this.txtPlateNum.TabIndex = 13;
            this.txtPlateNum.Tag = "F1S1";
            // 
            // lblPlateNum
            // 
            this.lblPlateNum.AutoSize = true;
            this.lblPlateNum.Location = new System.Drawing.Point(63, 69);
            this.lblPlateNum.Name = "lblPlateNum";
            this.lblPlateNum.Size = new System.Drawing.Size(56, 18);
            this.lblPlateNum.TabIndex = 12;
            this.lblPlateNum.Text = "车 牌 号";
            // 
            // txtCustName
            // 
            // 
            // 
            // 
            this.txtCustName.Border.Class = "TextBoxBorder";
            this.txtCustName.Location = new System.Drawing.Point(550, 66);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(123, 21);
            this.txtCustName.TabIndex = 7;
            this.txtCustName.Tag = "F1S1";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(488, 68);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(56, 18);
            this.lblCustName.TabIndex = 6;
            this.lblCustName.Text = "客户名字";
            // 
            // txtRepDH
            // 
            // 
            // 
            // 
            this.txtRepDH.Border.Class = "TextBoxBorder";
            this.txtRepDH.Location = new System.Drawing.Point(637, 31);
            this.txtRepDH.Name = "txtRepDH";
            this.txtRepDH.Size = new System.Drawing.Size(119, 21);
            this.txtRepDH.TabIndex = 5;
            this.txtRepDH.Tag = "F1S1";
            // 
            // lblRepDH
            // 
            this.lblRepDH.AutoSize = true;
            this.lblRepDH.Location = new System.Drawing.Point(587, 34);
            this.lblRepDH.Name = "lblRepDH";
            this.lblRepDH.Size = new System.Drawing.Size(44, 18);
            this.lblRepDH.TabIndex = 4;
            this.lblRepDH.Text = "单  号";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQuery,
            this.btnOPen1,
            this.btnOpen,
            this.btnModify,
            this.btnSelect,
            this.btnAllSelect,
            this.btnOut});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(913, 25);
            this.toolStrip1.TabIndex = 44;
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
            // btnOPen1
            // 
            this.btnOPen1.Image = ((System.Drawing.Image)(resources.GetObject("btnOPen1.Image")));
            this.btnOPen1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOPen1.Name = "btnOPen1";
            this.btnOPen1.Size = new System.Drawing.Size(52, 22);
            this.btnOPen1.Tag = "open";
            this.btnOPen1.Text = "打开";
            this.btnOPen1.Click += new System.EventHandler(this.btnOPen1_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(52, 22);
            this.btnOpen.Tag = "open";
            this.btnOpen.Text = "提取";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnModify
            // 
            this.btnModify.Image = ((System.Drawing.Image)(resources.GetObject("btnModify.Image")));
            this.btnModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(76, 22);
            this.btnModify.Tag = "modify";
            this.btnModify.Text = "修改索赔";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(76, 22);
            this.btnSelect.Tag = "ok";
            this.btnSelect.Text = "确认选择";
            this.btnSelect.Visible = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnAllSelect
            // 
            this.btnAllSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnAllSelect.Image")));
            this.btnAllSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAllSelect.Name = "btnAllSelect";
            this.btnAllSelect.Size = new System.Drawing.Size(76, 22);
            this.btnAllSelect.Tag = "select";
            this.btnAllSelect.Text = "本页全选";
            this.btnAllSelect.Visible = false;
            this.btnAllSelect.Click += new System.EventHandler(this.btnAllSelect_Click);
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
            // frmClaim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 432);
            this.Controls.Add(this.dgClaim);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmClaim";
            this.Text = "索赔登记";
            this.Load += new System.EventHandler(this.frmClaim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClaim)).EndInit();
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

        private DevComponents.DotNetBar.Controls.DataGridViewX dgClaim;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRepDH;
        private DevComponents.DotNetBar.LabelX lblRepDH;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCustName;
        private DevComponents.DotNetBar.LabelX lblCustName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPlateNum;
        private DevComponents.DotNetBar.LabelX lblPlateNum;
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
        private System.Windows.Forms.ToolStripButton btnModify;
        private System.Windows.Forms.ToolStripButton btnSelect;
        private System.Windows.Forms.DateTimePicker datBegin;
        private System.Windows.Forms.DateTimePicker datEnd;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtVin;
        private DevComponents.DotNetBar.LabelX lblVin;
        private DevComponents.DotNetBar.LabelX lblStatus;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbStatus;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private System.Windows.Forms.ToolStripButton btnAllSelect;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel lblSum;
        private System.Windows.Forms.ToolStripButton btnOut;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chbSel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaimDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlateNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vin;
        private System.Windows.Forms.DataGridViewTextBoxColumn accAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElseAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaimAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillDH;
        private DevComponents.DotNetBar.Controls.ComboBoxEx txtDate;
        private DevComponents.Editors.ComboItem comboItem6;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.ComboItem comboItem5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel lblaccsum;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel lblitemsum;
        private System.Windows.Forms.ToolStripButton btnOPen1;
    }
}