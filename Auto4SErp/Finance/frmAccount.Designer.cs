namespace Auto4SErp
{
    partial class frmAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccount));
            this.dgAccount = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlateNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Describes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DHFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcceptDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiveMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Check = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P2P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Self = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.other = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreRecv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Integral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceAmount1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmenuAcc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnOpen = new System.Windows.Forms.ToolStripMenuItem();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPlate = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.datBegin = new System.Windows.Forms.DateTimePicker();
            this.datEnd = new System.Windows.Forms.DateTimePicker();
            this.cmbDescribes = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem7 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem8 = new DevComponents.Editors.ComboItem();
            this.lblDescribes = new DevComponents.DotNetBar.LabelX();
            this.txtDHFrom = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblDHFrom = new DevComponents.DotNetBar.LabelX();
            this.cmbDateType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.comboItem6 = new DevComponents.Editors.ComboItem();
            this.txtMobile = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblMobile = new DevComponents.DotNetBar.LabelX();
            this.txtCustName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCustName = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnQuery = new System.Windows.Forms.ToolStripButton();
            this.tbtbAccept = new System.Windows.Forms.ToolStripButton();
            this.tbtnAllNoAccept = new System.Windows.Forms.ToolStripButton();
            this.tnbtBack = new System.Windows.Forms.ToolStripButton();
            this.btnReAccount = new System.Windows.Forms.ToolStripButton();
            this.btnPreRecv = new System.Windows.Forms.ToolStripButton();
            this.btnOut = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccount)).BeginInit();
            this.cmenuAcc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgAccount
            // 
            this.dgAccount.AllowUserToAddRows = false;
            this.dgAccount.AllowUserToDeleteRows = false;
            this.dgAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Status,
            this.CustName,
            this.Mobile,
            this.PlateNum,
            this.Describes,
            this.Amount,
            this.RecAmount,
            this.DHFrom,
            this.AccountDate,
            this.AcceptDate,
            this.ReceiveMan,
            this.Cash,
            this.Bank,
            this.Check,
            this.Vip,
            this.P2P,
            this.Quan,
            this.sc,
            this.Self,
            this.other,
            this.PreRecv,
            this.Integral,
            this.InvoiceNum,
            this.InvoiceAmount1});
            this.dgAccount.ContextMenuStrip = this.cmenuAcc;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAccount.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAccount.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgAccount.Location = new System.Drawing.Point(0, 157);
            this.dgAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgAccount.MultiSelect = false;
            this.dgAccount.Name = "dgAccount";
            this.dgAccount.RowTemplate.Height = 23;
            this.dgAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAccount.Size = new System.Drawing.Size(1280, 470);
            this.dgAccount.TabIndex = 37;
            this.dgAccount.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgAccount_RowPostPaint);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "编号";
            this.ID.Name = "ID";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "状态";
            this.Status.Name = "Status";
            // 
            // CustName
            // 
            this.CustName.DataPropertyName = "CustName";
            this.CustName.HeaderText = "顾客姓名";
            this.CustName.Name = "CustName";
            // 
            // Mobile
            // 
            this.Mobile.DataPropertyName = "Mobile";
            this.Mobile.HeaderText = "手机";
            this.Mobile.Name = "Mobile";
            // 
            // PlateNum
            // 
            this.PlateNum.DataPropertyName = "Plate";
            this.PlateNum.HeaderText = "车牌号";
            this.PlateNum.Name = "PlateNum";
            // 
            // Describes
            // 
            this.Describes.DataPropertyName = "Describes";
            this.Describes.HeaderText = "收款类型";
            this.Describes.Name = "Describes";
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "应收金额";
            this.Amount.Name = "Amount";
            // 
            // RecAmount
            // 
            this.RecAmount.DataPropertyName = "RecAmount";
            this.RecAmount.HeaderText = "实收金额";
            this.RecAmount.Name = "RecAmount";
            // 
            // DHFrom
            // 
            this.DHFrom.DataPropertyName = "DHFrom";
            this.DHFrom.HeaderText = "来源单号";
            this.DHFrom.Name = "DHFrom";
            // 
            // AccountDate
            // 
            this.AccountDate.DataPropertyName = "AccountDate";
            this.AccountDate.HeaderText = "提交日期";
            this.AccountDate.Name = "AccountDate";
            // 
            // AcceptDate
            // 
            this.AcceptDate.DataPropertyName = "AcceptDate";
            this.AcceptDate.HeaderText = "收款日期";
            this.AcceptDate.Name = "AcceptDate";
            // 
            // ReceiveMan
            // 
            this.ReceiveMan.DataPropertyName = "ReceiveMan";
            this.ReceiveMan.HeaderText = "收款人";
            this.ReceiveMan.Name = "ReceiveMan";
            // 
            // Cash
            // 
            this.Cash.DataPropertyName = "Cash";
            this.Cash.HeaderText = "现金";
            this.Cash.Name = "Cash";
            // 
            // Bank
            // 
            this.Bank.DataPropertyName = "Bank";
            this.Bank.HeaderText = "银行卡";
            this.Bank.Name = "Bank";
            // 
            // Check
            // 
            this.Check.DataPropertyName = "CheckAmount";
            this.Check.HeaderText = "支票";
            this.Check.Name = "Check";
            // 
            // Vip
            // 
            this.Vip.DataPropertyName = "Vip";
            this.Vip.HeaderText = "Vip";
            this.Vip.Name = "Vip";
            // 
            // P2P
            // 
            this.P2P.DataPropertyName = "P2P";
            this.P2P.HeaderText = "P2P";
            this.P2P.Name = "P2P";
            // 
            // Quan
            // 
            this.Quan.DataPropertyName = "Quan";
            this.Quan.HeaderText = "优惠券";
            this.Quan.Name = "Quan";
            // 
            // sc
            // 
            this.sc.DataPropertyName = "cs";
            this.sc.HeaderText = "赊销";
            this.sc.Name = "sc";
            // 
            // Self
            // 
            this.Self.DataPropertyName = "SelfAmount";
            this.Self.HeaderText = "内部结算";
            this.Self.Name = "Self";
            // 
            // other
            // 
            this.other.DataPropertyName = "other";
            this.other.HeaderText = "异地代收";
            this.other.Name = "other";
            // 
            // PreRecv
            // 
            this.PreRecv.DataPropertyName = "PreRecv";
            this.PreRecv.HeaderText = "预收款";
            this.PreRecv.Name = "PreRecv";
            // 
            // Integral
            // 
            this.Integral.DataPropertyName = "Integral";
            this.Integral.HeaderText = "积分结算";
            this.Integral.Name = "Integral";
            // 
            // InvoiceNum
            // 
            this.InvoiceNum.DataPropertyName = "InvoiceNum";
            this.InvoiceNum.HeaderText = "发票号";
            this.InvoiceNum.Name = "InvoiceNum";
            // 
            // InvoiceAmount1
            // 
            this.InvoiceAmount1.DataPropertyName = "InvoiceAmount";
            this.InvoiceAmount1.HeaderText = "发票金额";
            this.InvoiceAmount1.Name = "InvoiceAmount1";
            // 
            // cmenuAcc
            // 
            this.cmenuAcc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen});
            this.cmenuAcc.Name = "cmenuCarDetail";
            this.cmenuAcc.Size = new System.Drawing.Size(139, 28);
            // 
            // btnOpen
            // 
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(138, 24);
            this.btnOpen.Text = "打开单据";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
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
            this.bindingNavigatorRecordCount});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 627);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1280, 27);
            this.bindingNavigator1.TabIndex = 48;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorAddNewItem.Text = "新添";
            this.bindingNavigatorAddNewItem.Visible = false;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(38, 24);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorDeleteItem.Text = "删除";
            this.bindingNavigatorDeleteItem.Visible = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorRecordCount
            // 
            this.bindingNavigatorRecordCount.Name = "bindingNavigatorRecordCount";
            this.bindingNavigatorRecordCount.Size = new System.Drawing.Size(18, 24);
            this.bindingNavigatorRecordCount.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPlate);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.datBegin);
            this.groupBox1.Controls.Add(this.datEnd);
            this.groupBox1.Controls.Add(this.cmbDescribes);
            this.groupBox1.Controls.Add(this.lblDescribes);
            this.groupBox1.Controls.Add(this.txtDHFrom);
            this.groupBox1.Controls.Add(this.lblDHFrom);
            this.groupBox1.Controls.Add(this.cmbDateType);
            this.groupBox1.Controls.Add(this.txtMobile);
            this.groupBox1.Controls.Add(this.lblMobile);
            this.groupBox1.Controls.Add(this.txtCustName);
            this.groupBox1.Controls.Add(this.lblCustName);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1280, 130);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // txtPlate
            // 
            // 
            // 
            // 
            this.txtPlate.Border.Class = "TextBoxBorder";
            this.txtPlate.Location = new System.Drawing.Point(735, 78);
            this.txtPlate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.Size = new System.Drawing.Size(151, 25);
            this.txtPlate.TabIndex = 34;
            this.txtPlate.Tag = "F1S1";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(652, 81);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(69, 21);
            this.labelX2.TabIndex = 33;
            this.labelX2.Text = "车 牌 号";
            // 
            // datBegin
            // 
            this.datBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datBegin.Location = new System.Drawing.Point(139, 39);
            this.datBegin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datBegin.Name = "datBegin";
            this.datBegin.Size = new System.Drawing.Size(143, 25);
            this.datBegin.TabIndex = 32;
            // 
            // datEnd
            // 
            this.datEnd.Checked = false;
            this.datEnd.CustomFormat = "";
            this.datEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datEnd.Location = new System.Drawing.Point(321, 39);
            this.datEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datEnd.Name = "datEnd";
            this.datEnd.Size = new System.Drawing.Size(137, 25);
            this.datEnd.TabIndex = 31;
            // 
            // cmbDescribes
            // 
            this.cmbDescribes.DisplayMember = "Text";
            this.cmbDescribes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDescribes.FormattingEnabled = true;
            this.cmbDescribes.ItemHeight = 15;
            this.cmbDescribes.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem7,
            this.comboItem3,
            this.comboItem8});
            this.cmbDescribes.Location = new System.Drawing.Point(735, 38);
            this.cmbDescribes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDescribes.Name = "cmbDescribes";
            this.cmbDescribes.Size = new System.Drawing.Size(149, 21);
            this.cmbDescribes.TabIndex = 30;
            this.cmbDescribes.Tag = "F0S1B0";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "销售订金";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "销售收款";
            // 
            // comboItem7
            // 
            this.comboItem7.Text = "销售装潢";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "售后";
            // 
            // comboItem8
            // 
            this.comboItem8.Text = "索赔收款";
            // 
            // lblDescribes
            // 
            this.lblDescribes.AutoSize = true;
            this.lblDescribes.Location = new System.Drawing.Point(652, 40);
            this.lblDescribes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblDescribes.Name = "lblDescribes";
            this.lblDescribes.Size = new System.Drawing.Size(69, 21);
            this.lblDescribes.TabIndex = 29;
            this.lblDescribes.Text = "收款类型";
            // 
            // txtDHFrom
            // 
            // 
            // 
            // 
            this.txtDHFrom.Border.Class = "TextBoxBorder";
            this.txtDHFrom.Location = new System.Drawing.Point(140, 79);
            this.txtDHFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDHFrom.Name = "txtDHFrom";
            this.txtDHFrom.Size = new System.Drawing.Size(176, 25);
            this.txtDHFrom.TabIndex = 28;
            this.txtDHFrom.Tag = "F1S1";
            // 
            // lblDHFrom
            // 
            this.lblDHFrom.AutoSize = true;
            this.lblDHFrom.Location = new System.Drawing.Point(91, 81);
            this.lblDHFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblDHFrom.Name = "lblDHFrom";
            this.lblDHFrom.Size = new System.Drawing.Size(38, 21);
            this.lblDHFrom.TabIndex = 27;
            this.lblDHFrom.Text = "单号";
            // 
            // cmbDateType
            // 
            this.cmbDateType.DisplayMember = "Text";
            this.cmbDateType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDateType.FormattingEnabled = true;
            this.cmbDateType.ItemHeight = 15;
            this.cmbDateType.Items.AddRange(new object[] {
            this.comboItem4,
            this.comboItem5,
            this.comboItem6});
            this.cmbDateType.Location = new System.Drawing.Point(489, 39);
            this.cmbDateType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDateType.Name = "cmbDateType";
            this.cmbDateType.Size = new System.Drawing.Size(131, 21);
            this.cmbDateType.TabIndex = 26;
            this.cmbDateType.Tag = "F0S0B1";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "无";
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "提交日期";
            // 
            // comboItem6
            // 
            this.comboItem6.Text = "收款日期";
            // 
            // txtMobile
            // 
            // 
            // 
            // 
            this.txtMobile.Border.Class = "TextBoxBorder";
            this.txtMobile.Location = new System.Drawing.Point(431, 78);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(191, 25);
            this.txtMobile.TabIndex = 21;
            this.txtMobile.Tag = "F1S1";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(369, 81);
            this.lblMobile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(54, 21);
            this.lblMobile.TabIndex = 20;
            this.lblMobile.Text = "手机号";
            // 
            // txtCustName
            // 
            // 
            // 
            // 
            this.txtCustName.Border.Class = "TextBoxBorder";
            this.txtCustName.Location = new System.Drawing.Point(1004, 75);
            this.txtCustName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(179, 25);
            this.txtCustName.TabIndex = 19;
            this.txtCustName.Tag = "F1S1";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(921, 79);
            this.lblCustName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(69, 21);
            this.lblCustName.TabIndex = 18;
            this.lblCustName.Text = "客户姓名";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(91, 41);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(38, 21);
            this.labelX1.TabIndex = 14;
            this.labelX1.Text = "日期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "至";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnQuery,
            this.tbtbAccept,
            this.tbtnAllNoAccept,
            this.tnbtBack,
            this.btnReAccount,
            this.btnPreRecv,
            this.btnOut});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1280, 27);
            this.toolStrip1.TabIndex = 38;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnQuery
            // 
            this.tbtnQuery.Image = ((System.Drawing.Image)(resources.GetObject("tbtnQuery.Image")));
            this.tbtnQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnQuery.Name = "tbtnQuery";
            this.tbtnQuery.Size = new System.Drawing.Size(59, 24);
            this.tbtnQuery.Tag = "query";
            this.tbtnQuery.Text = "查询";
            this.tbtnQuery.Click += new System.EventHandler(this.tbtnQuery_Click);
            // 
            // tbtbAccept
            // 
            this.tbtbAccept.Image = global::Auto4SErp.Properties.Resources.receptm;
            this.tbtbAccept.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtbAccept.Name = "tbtbAccept";
            this.tbtbAccept.Size = new System.Drawing.Size(59, 24);
            this.tbtbAccept.Text = "收款";
            this.tbtbAccept.Click += new System.EventHandler(this.tbtbAccept_Click);
            // 
            // tbtnAllNoAccept
            // 
            this.tbtnAllNoAccept.Image = ((System.Drawing.Image)(resources.GetObject("tbtnAllNoAccept.Image")));
            this.tbtnAllNoAccept.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnAllNoAccept.Name = "tbtnAllNoAccept";
            this.tbtnAllNoAccept.Size = new System.Drawing.Size(74, 24);
            this.tbtnAllNoAccept.Text = "未收款";
            this.tbtnAllNoAccept.Click += new System.EventHandler(this.tbtnAllNoAccept_Click);
            // 
            // tnbtBack
            // 
            this.tnbtBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tnbtBack.Image = ((System.Drawing.Image)(resources.GetObject("tnbtBack.Image")));
            this.tnbtBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tnbtBack.Name = "tnbtBack";
            this.tnbtBack.Size = new System.Drawing.Size(43, 24);
            this.tnbtBack.Text = "返单";
            this.tnbtBack.Click += new System.EventHandler(this.tnbtBack_Click);
            // 
            // btnReAccount
            // 
            this.btnReAccount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnReAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnReAccount.Image")));
            this.btnReAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReAccount.Name = "btnReAccount";
            this.btnReAccount.Size = new System.Drawing.Size(73, 24);
            this.btnReAccount.Text = "售后重结";
            this.btnReAccount.Click += new System.EventHandler(this.btnReAccount_Click);
            // 
            // btnPreRecv
            // 
            this.btnPreRecv.Image = global::Auto4SErp.Properties.Resources.prepay;
            this.btnPreRecv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPreRecv.Name = "btnPreRecv";
            this.btnPreRecv.Size = new System.Drawing.Size(89, 24);
            this.btnPreRecv.Text = "充预收款";
            this.btnPreRecv.Click += new System.EventHandler(this.btnPreRecv_Click);
            // 
            // btnOut
            // 
            this.btnOut.Image = ((System.Drawing.Image)(resources.GetObject("btnOut.Image")));
            this.btnOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(59, 24);
            this.btnOut.Tag = "out";
            this.btnOut.Text = "导出";
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 654);
            this.Controls.Add(this.dgAccount);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmAccount";
            this.Text = "财务收款";
            this.Load += new System.EventHandler(this.frmAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAccount)).EndInit();
            this.cmenuAcc.ResumeLayout(false);
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

        private DevComponents.DotNetBar.Controls.DataGridViewX dgAccount;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtbAccept;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton tbtnQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMobile;
        private DevComponents.DotNetBar.LabelX lblMobile;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCustName;
        private DevComponents.DotNetBar.LabelX lblCustName;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbDateType;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.ComboItem comboItem5;
        private DevComponents.Editors.ComboItem comboItem6;
        private System.Windows.Forms.ToolStripButton tbtnAllNoAccept;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDHFrom;
        private DevComponents.DotNetBar.LabelX lblDHFrom;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbDescribes;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.DotNetBar.LabelX lblDescribes;
        private System.Windows.Forms.DateTimePicker datBegin;
        private System.Windows.Forms.DateTimePicker datEnd;
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
        private DevComponents.Editors.ComboItem comboItem7;
        private System.Windows.Forms.ToolStripButton btnPreRecv;
        private System.Windows.Forms.ContextMenuStrip cmenuAcc;
        private System.Windows.Forms.ToolStripMenuItem btnOpen;
        private System.Windows.Forms.ToolStripButton btnOut;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPlate;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.Editors.ComboItem comboItem8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlateNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Describes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DHFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcceptDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiveMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cash;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bank;
        private System.Windows.Forms.DataGridViewTextBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vip;
        private System.Windows.Forms.DataGridViewTextBoxColumn P2P;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quan;
        private System.Windows.Forms.DataGridViewTextBoxColumn sc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Self;
        private System.Windows.Forms.DataGridViewTextBoxColumn other;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreRecv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Integral;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceAmount1;
        private System.Windows.Forms.ToolStripButton tnbtBack;
        private System.Windows.Forms.ToolStripButton btnReAccount;
    }
}