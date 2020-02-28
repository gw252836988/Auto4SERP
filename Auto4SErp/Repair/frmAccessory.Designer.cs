namespace Auto4SErp.Repair
{
    partial class frmAccessory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccessory));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("已选取下列需求配件");
            this.cmenuAccessory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ModifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgAccessory = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.AccessoryCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StorePlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessoryType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SmallType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsEnabled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplicationModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncreaseRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSmallType = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblSmallType = new DevComponents.DotNetBar.LabelX();
            this.txtKC = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblKC = new DevComponents.DotNetBar.LabelX();
            this.cmbAccessoryType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblAccessoryType = new DevComponents.DotNetBar.LabelX();
            this.txtAccessoryName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblAccessoryName = new DevComponents.DotNetBar.LabelX();
            this.txtAccessoryCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblAccessoryCode = new DevComponents.DotNetBar.LabelX();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddAccessory = new System.Windows.Forms.ToolStripButton();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.btnIn = new System.Windows.Forms.ToolStripButton();
            this.btnDemandSel = new System.Windows.Forms.ToolStripButton();
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
            this.listviewsel = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cmenuAccessory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccessory)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmenuAccessory
            // 
            this.cmenuAccessory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModifyToolStripMenuItem,
            this.DelToolStripMenuItem});
            this.cmenuAccessory.Name = "cmenuCarDetail";
            this.cmenuAccessory.Size = new System.Drawing.Size(101, 48);
            // 
            // ModifyToolStripMenuItem
            // 
            this.ModifyToolStripMenuItem.Name = "ModifyToolStripMenuItem";
            this.ModifyToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.ModifyToolStripMenuItem.Text = "修改";
            this.ModifyToolStripMenuItem.Click += new System.EventHandler(this.ModifyToolStripMenuItem_Click);
            // 
            // DelToolStripMenuItem
            // 
            this.DelToolStripMenuItem.Name = "DelToolStripMenuItem";
            this.DelToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.DelToolStripMenuItem.Text = "删除";
            this.DelToolStripMenuItem.Click += new System.EventHandler(this.DelToolStripMenuItem_Click);
            // 
            // dgAccessory
            // 
            this.dgAccessory.AllowUserToAddRows = false;
            this.dgAccessory.AllowUserToDeleteRows = false;
            this.dgAccessory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAccessory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccessoryCode,
            this.AccessoryName,
            this.Brand,
            this.Unit,
            this.StorePlace,
            this.AccessoryType,
            this.SmallType,
            this.IsEnabled,
            this.SalePrice,
            this.ApplicationModel,
            this.IncreaseRate,
            this.ChangeCode});
            this.dgAccessory.ContextMenuStrip = this.cmenuAccessory;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAccessory.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgAccessory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAccessory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgAccessory.Location = new System.Drawing.Point(166, 122);
            this.dgAccessory.MultiSelect = false;
            this.dgAccessory.Name = "dgAccessory";
            this.dgAccessory.RowTemplate.Height = 23;
            this.dgAccessory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAccessory.Size = new System.Drawing.Size(629, 271);
            this.dgAccessory.TabIndex = 42;
            this.dgAccessory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAccessory_CellContentClick);
            this.dgAccessory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAccessory_CellDoubleClick);
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
            // Brand
            // 
            this.Brand.DataPropertyName = "Brand";
            this.Brand.HeaderText = "品牌";
            this.Brand.Name = "Brand";
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "Unit";
            this.Unit.HeaderText = "单位";
            this.Unit.Name = "Unit";
            // 
            // StorePlace
            // 
            this.StorePlace.DataPropertyName = "StorePlace";
            this.StorePlace.HeaderText = "库位";
            this.StorePlace.Name = "StorePlace";
            // 
            // AccessoryType
            // 
            this.AccessoryType.DataPropertyName = "AccessoryType";
            this.AccessoryType.HeaderText = "类型";
            this.AccessoryType.Name = "AccessoryType";
            // 
            // SmallType
            // 
            this.SmallType.DataPropertyName = "SmallType";
            this.SmallType.HeaderText = "小类";
            this.SmallType.Name = "SmallType";
            // 
            // IsEnabled
            // 
            this.IsEnabled.DataPropertyName = "enabled";
            this.IsEnabled.HeaderText = "是否停用";
            this.IsEnabled.Name = "IsEnabled";
            // 
            // SalePrice
            // 
            this.SalePrice.DataPropertyName = "SalePrice";
            this.SalePrice.HeaderText = "销售价格";
            this.SalePrice.Name = "SalePrice";
            // 
            // ApplicationModel
            // 
            this.ApplicationModel.DataPropertyName = "ApplicationModel";
            this.ApplicationModel.HeaderText = "适用车型";
            this.ApplicationModel.Name = "ApplicationModel";
            // 
            // IncreaseRate
            // 
            this.IncreaseRate.DataPropertyName = "IncreaseRate";
            this.IncreaseRate.HeaderText = "加价率";
            this.IncreaseRate.Name = "IncreaseRate";
            // 
            // ChangeCode
            // 
            this.ChangeCode.DataPropertyName = "ChangeCode";
            this.ChangeCode.HeaderText = "互换码";
            this.ChangeCode.Name = "ChangeCode";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSmallType);
            this.groupBox1.Controls.Add(this.lblSmallType);
            this.groupBox1.Controls.Add(this.txtKC);
            this.groupBox1.Controls.Add(this.lblKC);
            this.groupBox1.Controls.Add(this.cmbAccessoryType);
            this.groupBox1.Controls.Add(this.lblAccessoryType);
            this.groupBox1.Controls.Add(this.txtAccessoryName);
            this.groupBox1.Controls.Add(this.lblAccessoryName);
            this.groupBox1.Controls.Add(this.txtAccessoryCode);
            this.groupBox1.Controls.Add(this.lblAccessoryCode);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 97);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            // 
            // txtSmallType
            // 
            // 
            // 
            // 
            this.txtSmallType.Border.Class = "TextBoxBorder";
            this.txtSmallType.Location = new System.Drawing.Point(107, 60);
            this.txtSmallType.Name = "txtSmallType";
            this.txtSmallType.Size = new System.Drawing.Size(128, 21);
            this.txtSmallType.TabIndex = 23;
            this.txtSmallType.Tag = "F1S1";
            // 
            // lblSmallType
            // 
            this.lblSmallType.AutoSize = true;
            this.lblSmallType.Location = new System.Drawing.Point(45, 63);
            this.lblSmallType.Name = "lblSmallType";
            this.lblSmallType.Size = new System.Drawing.Size(56, 18);
            this.lblSmallType.TabIndex = 22;
            this.lblSmallType.Text = "配件小类";
            // 
            // txtKC
            // 
            // 
            // 
            // 
            this.txtKC.Border.Class = "TextBoxBorder";
            this.txtKC.Location = new System.Drawing.Point(335, 60);
            this.txtKC.Name = "txtKC";
            this.txtKC.ReadOnly = true;
            this.txtKC.Size = new System.Drawing.Size(128, 21);
            this.txtKC.TabIndex = 21;
            this.txtKC.Tag = "";
            // 
            // lblKC
            // 
            this.lblKC.AutoSize = true;
            this.lblKC.Location = new System.Drawing.Point(273, 63);
            this.lblKC.Name = "lblKC";
            this.lblKC.Size = new System.Drawing.Size(56, 18);
            this.lblKC.TabIndex = 20;
            this.lblKC.Text = "库 存 量";
            // 
            // cmbAccessoryType
            // 
            this.cmbAccessoryType.DisplayMember = "Text";
            this.cmbAccessoryType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAccessoryType.FormattingEnabled = true;
            this.cmbAccessoryType.ItemHeight = 15;
            this.cmbAccessoryType.Location = new System.Drawing.Point(562, 24);
            this.cmbAccessoryType.Name = "cmbAccessoryType";
            this.cmbAccessoryType.Size = new System.Drawing.Size(125, 21);
            this.cmbAccessoryType.TabIndex = 19;
            this.cmbAccessoryType.Tag = "F1S1B0";
            // 
            // lblAccessoryType
            // 
            this.lblAccessoryType.AutoSize = true;
            this.lblAccessoryType.Location = new System.Drawing.Point(500, 25);
            this.lblAccessoryType.Name = "lblAccessoryType";
            this.lblAccessoryType.Size = new System.Drawing.Size(56, 18);
            this.lblAccessoryType.TabIndex = 18;
            this.lblAccessoryType.Text = "配件类型";
            // 
            // txtAccessoryName
            // 
            // 
            // 
            // 
            this.txtAccessoryName.Border.Class = "TextBoxBorder";
            this.txtAccessoryName.Location = new System.Drawing.Point(335, 24);
            this.txtAccessoryName.Name = "txtAccessoryName";
            this.txtAccessoryName.Size = new System.Drawing.Size(128, 21);
            this.txtAccessoryName.TabIndex = 12;
            this.txtAccessoryName.Tag = "F1S1";
            // 
            // lblAccessoryName
            // 
            this.lblAccessoryName.AutoSize = true;
            this.lblAccessoryName.Location = new System.Drawing.Point(273, 27);
            this.lblAccessoryName.Name = "lblAccessoryName";
            this.lblAccessoryName.Size = new System.Drawing.Size(56, 18);
            this.lblAccessoryName.TabIndex = 11;
            this.lblAccessoryName.Text = "配件名称";
            // 
            // txtAccessoryCode
            // 
            // 
            // 
            // 
            this.txtAccessoryCode.Border.Class = "TextBoxBorder";
            this.txtAccessoryCode.Location = new System.Drawing.Point(107, 25);
            this.txtAccessoryCode.Name = "txtAccessoryCode";
            this.txtAccessoryCode.Size = new System.Drawing.Size(128, 21);
            this.txtAccessoryCode.TabIndex = 10;
            this.txtAccessoryCode.Tag = "F1S1";
            // 
            // lblAccessoryCode
            // 
            this.lblAccessoryCode.AutoSize = true;
            this.lblAccessoryCode.Location = new System.Drawing.Point(46, 26);
            this.lblAccessoryCode.Name = "lblAccessoryCode";
            this.lblAccessoryCode.Size = new System.Drawing.Size(56, 18);
            this.lblAccessoryCode.TabIndex = 9;
            this.lblAccessoryCode.Text = "配件编码";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddAccessory,
            this.btnQuery,
            this.btnIn,
            this.btnDemandSel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(795, 25);
            this.toolStrip1.TabIndex = 43;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddAccessory
            // 
            this.btnAddAccessory.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAccessory.Image")));
            this.btnAddAccessory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddAccessory.Name = "btnAddAccessory";
            this.btnAddAccessory.Size = new System.Drawing.Size(52, 22);
            this.btnAddAccessory.Tag = "add";
            this.btnAddAccessory.Text = "增加";
            this.btnAddAccessory.Click += new System.EventHandler(this.btnAddAccessory_Click);
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
            // btnIn
            // 
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(52, 22);
            this.btnIn.Tag = "in";
            this.btnIn.Text = "导入";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnDemandSel
            // 
            this.btnDemandSel.Image = ((System.Drawing.Image)(resources.GetObject("btnDemandSel.Image")));
            this.btnDemandSel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDemandSel.Name = "btnDemandSel";
            this.btnDemandSel.Size = new System.Drawing.Size(76, 22);
            this.btnDemandSel.Tag = "select";
            this.btnDemandSel.Text = "需求选择";
            this.btnDemandSel.Visible = false;
            this.btnDemandSel.Click += new System.EventHandler(this.btnDemandSel_Click);
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
            this.toolStripLabel1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 393);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(795, 25);
            this.bindingNavigator1.TabIndex = 45;
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
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
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
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
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
            // listviewsel
            // 
            // 
            // 
            // 
            this.listviewsel.Border.Class = "ListViewBorder";
            this.listviewsel.Dock = System.Windows.Forms.DockStyle.Left;
            this.listviewsel.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listviewsel.Location = new System.Drawing.Point(0, 122);
            this.listviewsel.Name = "listviewsel";
            this.listviewsel.Size = new System.Drawing.Size(166, 271);
            this.listviewsel.TabIndex = 46;
            this.listviewsel.UseCompatibleStateImageBehavior = false;
            this.listviewsel.View = System.Windows.Forms.View.Tile;
            this.listviewsel.Visible = false;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(176, 22);
            this.toolStripLabel1.Text = "注：停用的配件无法被选作需求";
            // 
            // frmAccessory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 418);
            this.Controls.Add(this.dgAccessory);
            this.Controls.Add(this.listviewsel);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmAccessory";
            this.Text = "配件资料";
            this.Load += new System.EventHandler(this.frmAccessory_Load);
            this.cmenuAccessory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAccessory)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgAccessory;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddAccessory;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAccessoryCode;
        private DevComponents.DotNetBar.LabelX lblAccessoryCode;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ContextMenuStrip cmenuAccessory;
        private System.Windows.Forms.ToolStripMenuItem DelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModifyToolStripMenuItem;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAccessoryName;
        private DevComponents.DotNetBar.LabelX lblAccessoryName;
        private System.Windows.Forms.ToolStripButton btnIn;
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
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbAccessoryType;
        private DevComponents.DotNetBar.LabelX lblAccessoryType;
        private DevComponents.DotNetBar.Controls.ListViewEx listviewsel;
        private System.Windows.Forms.ToolStripButton btnDemandSel;
        private DevComponents.DotNetBar.Controls.TextBoxX txtKC;
        private DevComponents.DotNetBar.LabelX lblKC;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSmallType;
        private DevComponents.DotNetBar.LabelX lblSmallType;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessoryCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn StorePlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessoryType;
        private System.Windows.Forms.DataGridViewTextBoxColumn SmallType;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsEnabled;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplicationModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncreaseRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChangeCode;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}