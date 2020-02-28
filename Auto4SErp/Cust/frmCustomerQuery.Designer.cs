namespace Auto4SErp.Cust
{
    partial class frmCustomerQuery
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerQuery));
            this.cMenuCustomer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ModifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToVipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuCar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ModifyCarStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteCarStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dgCustomer = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dgCar = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobilephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlateNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarSer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsuranceCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyHere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeepBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeepEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnQuery = new System.Windows.Forms.ToolStripButton();
            this.tbtnQueryOfCar = new System.Windows.Forms.ToolStripButton();
            this.tbtnSel = new System.Windows.Forms.ToolStripButton();
            this.btnAddCustomer = new System.Windows.Forms.ToolStripButton();
            this.btnAddCar = new System.Windows.Forms.ToolStripButton();
            this.btnCustIn = new System.Windows.Forms.ToolStripButton();
            this.btnCarIn = new System.Windows.Forms.ToolStripButton();
            this.cMenuCustomer.SuspendLayout();
            this.cMenuCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cMenuCustomer
            // 
            this.cMenuCustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModifyToolStripMenuItem,
            this.DeleteToolStripMenuItem,
            this.ToVipToolStripMenuItem,
            this.toolStripMenuItem2});
            this.cMenuCustomer.Name = "cMenuCustomer";
            this.cMenuCustomer.Size = new System.Drawing.Size(125, 92);
            this.cMenuCustomer.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cMenuCustomer_ItemClicked);
            // 
            // ModifyToolStripMenuItem
            // 
            this.ModifyToolStripMenuItem.Name = "ModifyToolStripMenuItem";
            this.ModifyToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.ModifyToolStripMenuItem.Text = "修改";
            this.ModifyToolStripMenuItem.Click += new System.EventHandler(this.ModifyToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.DeleteToolStripMenuItem.Text = "删除";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // ToVipToolStripMenuItem
            // 
            this.ToVipToolStripMenuItem.Name = "ToVipToolStripMenuItem";
            this.ToVipToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.ToVipToolStripMenuItem.Text = "升级会员";
            this.ToVipToolStripMenuItem.Click += new System.EventHandler(this.ToVipToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem2.Text = "P2P绑定";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // cMenuCar
            // 
            this.cMenuCar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModifyCarStripMenuItem1,
            this.DeleteCarStripMenuItem1});
            this.cMenuCar.Name = "cMenuCustomer";
            this.cMenuCar.Size = new System.Drawing.Size(137, 48);
            // 
            // ModifyCarStripMenuItem1
            // 
            this.ModifyCarStripMenuItem1.Name = "ModifyCarStripMenuItem1";
            this.ModifyCarStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.ModifyCarStripMenuItem1.Text = "变更车牌号";
            this.ModifyCarStripMenuItem1.Click += new System.EventHandler(this.ModifyCarStripMenuItem1_Click);
            // 
            // DeleteCarStripMenuItem1
            // 
            this.DeleteCarStripMenuItem1.Name = "DeleteCarStripMenuItem1";
            this.DeleteCarStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.DeleteCarStripMenuItem1.Text = "删除";
            this.DeleteCarStripMenuItem1.Click += new System.EventHandler(this.DeleteCarStripMenuItem1_Click);
            // 
            // dgCustomer
            // 
            this.dgCustomer.AllowUserToAddRows = false;
            this.dgCustomer.AllowUserToDeleteRows = false;
            this.dgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomer.ContextMenuStrip = this.cMenuCustomer;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCustomer.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCustomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgCustomer.Location = new System.Drawing.Point(0, 25);
            this.dgCustomer.MultiSelect = false;
            this.dgCustomer.Name = "dgCustomer";
            this.dgCustomer.RowTemplate.Height = 23;
            this.dgCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCustomer.Size = new System.Drawing.Size(1061, 315);
            this.dgCustomer.TabIndex = 29;
            this.dgCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCustomer_CellClick);
            this.dgCustomer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCustomer_CellDoubleClick);
            // 
            // dgCar
            // 
            this.dgCar.AllowUserToAddRows = false;
            this.dgCar.AllowUserToDeleteRows = false;
            this.dgCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.mobilephone,
            this.PlateNum,
            this.Vin,
            this.CarBrand,
            this.CarSer,
            this.CarModel,
            this.CarColor,
            this.InsuranceCompany,
            this.InBegin,
            this.InEnd,
            this.BuyHere,
            this.KeepBegin,
            this.KeepEnd});
            this.dgCar.ContextMenuStrip = this.cMenuCar;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgCar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgCar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgCar.Location = new System.Drawing.Point(0, 340);
            this.dgCar.MultiSelect = false;
            this.dgCar.Name = "dgCar";
            this.dgCar.RowTemplate.Height = 23;
            this.dgCar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCar.Size = new System.Drawing.Size(1061, 138);
            this.dgCar.TabIndex = 30;
            this.dgCar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCar_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // mobilephone
            // 
            this.mobilephone.DataPropertyName = "mobile";
            this.mobilephone.HeaderText = "手机号";
            this.mobilephone.Name = "mobilephone";
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
            // CarBrand
            // 
            this.CarBrand.DataPropertyName = "CarBrand";
            this.CarBrand.HeaderText = "品牌";
            this.CarBrand.Name = "CarBrand";
            // 
            // CarSer
            // 
            this.CarSer.DataPropertyName = "CarSer";
            this.CarSer.HeaderText = "车系";
            this.CarSer.Name = "CarSer";
            // 
            // CarModel
            // 
            this.CarModel.DataPropertyName = "CarModel";
            this.CarModel.HeaderText = "车型";
            this.CarModel.Name = "CarModel";
            // 
            // CarColor
            // 
            this.CarColor.DataPropertyName = "CarColor";
            this.CarColor.HeaderText = "车身颜色";
            this.CarColor.Name = "CarColor";
            // 
            // InsuranceCompany
            // 
            this.InsuranceCompany.DataPropertyName = "InsuranceCompany";
            this.InsuranceCompany.HeaderText = "保险公司";
            this.InsuranceCompany.Name = "InsuranceCompany";
            // 
            // InBegin
            // 
            this.InBegin.DataPropertyName = "InBegin";
            this.InBegin.HeaderText = "保险开始日期";
            this.InBegin.Name = "InBegin";
            // 
            // InEnd
            // 
            this.InEnd.DataPropertyName = "InEnd";
            this.InEnd.HeaderText = "保险结束日期";
            this.InEnd.Name = "InEnd";
            // 
            // BuyHere
            // 
            this.BuyHere.DataPropertyName = "BuyHere";
            this.BuyHere.HeaderText = "是否本店购买";
            this.BuyHere.Name = "BuyHere";
            // 
            // KeepBegin
            // 
            this.KeepBegin.DataPropertyName = "KeepBegin";
            this.KeepBegin.HeaderText = "保修开始日期";
            this.KeepBegin.Name = "KeepBegin";
            // 
            // KeepEnd
            // 
            this.KeepEnd.DataPropertyName = "KeepEnd";
            this.KeepEnd.HeaderText = "保修结束日期";
            this.KeepEnd.Name = "KeepEnd";
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
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 478);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1061, 25);
            this.bindingNavigator1.TabIndex = 46;
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
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnQuery,
            this.tbtnQueryOfCar,
            this.tbtnSel,
            this.btnAddCustomer,
            this.btnAddCar,
            this.btnCustIn,
            this.btnCarIn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1061, 25);
            this.toolStrip1.TabIndex = 28;
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
            // tbtnQueryOfCar
            // 
            this.tbtnQueryOfCar.Image = ((System.Drawing.Image)(resources.GetObject("tbtnQueryOfCar.Image")));
            this.tbtnQueryOfCar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnQueryOfCar.Name = "tbtnQueryOfCar";
            this.tbtnQueryOfCar.Size = new System.Drawing.Size(76, 22);
            this.tbtnQueryOfCar.Tag = "query";
            this.tbtnQueryOfCar.Text = "查询车辆";
            this.tbtnQueryOfCar.Click += new System.EventHandler(this.tbtnQueryOfCar_Click);
            // 
            // tbtnSel
            // 
            this.tbtnSel.Image = ((System.Drawing.Image)(resources.GetObject("tbtnSel.Image")));
            this.tbtnSel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnSel.Name = "tbtnSel";
            this.tbtnSel.Size = new System.Drawing.Size(52, 22);
            this.tbtnSel.Tag = "select";
            this.tbtnSel.Text = "选择";
            this.tbtnSel.Click += new System.EventHandler(this.tbtnSel_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCustomer.Image")));
            this.btnAddCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(76, 22);
            this.btnAddCustomer.Tag = "add";
            this.btnAddCustomer.Text = "增加客户";
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCar.Image")));
            this.btnAddCar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(76, 22);
            this.btnAddCar.Tag = "add";
            this.btnAddCar.Text = "增加车辆";
            this.btnAddCar.Visible = false;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnCustIn
            // 
            this.btnCustIn.Image = ((System.Drawing.Image)(resources.GetObject("btnCustIn.Image")));
            this.btnCustIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustIn.Name = "btnCustIn";
            this.btnCustIn.Size = new System.Drawing.Size(76, 22);
            this.btnCustIn.Tag = "in";
            this.btnCustIn.Text = "导入客户";
            this.btnCustIn.Click += new System.EventHandler(this.btnCustIn_Click);
            // 
            // btnCarIn
            // 
            this.btnCarIn.Image = ((System.Drawing.Image)(resources.GetObject("btnCarIn.Image")));
            this.btnCarIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCarIn.Name = "btnCarIn";
            this.btnCarIn.Size = new System.Drawing.Size(76, 22);
            this.btnCarIn.Tag = "in";
            this.btnCarIn.Text = "导入车辆";
            this.btnCarIn.Click += new System.EventHandler(this.btnCarIn_Click);
            // 
            // frmCustomerQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 503);
            this.Controls.Add(this.dgCustomer);
            this.Controls.Add(this.dgCar);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmCustomerQuery";
            this.Text = "客户资料";
            this.Load += new System.EventHandler(this.frmCustomerQuery_Load);
            this.cMenuCustomer.ResumeLayout(false);
            this.cMenuCar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnQuery;
        private System.Windows.Forms.ToolStripButton tbtnSel;
        private System.Windows.Forms.ContextMenuStrip cMenuCustomer;
        private System.Windows.Forms.ToolStripMenuItem ModifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgCar;
        private System.Windows.Forms.ToolStripButton btnAddCar;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgCustomer;
        private System.Windows.Forms.ToolStripMenuItem ToVipToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cMenuCar;
        private System.Windows.Forms.ToolStripMenuItem ModifyCarStripMenuItem1;
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
        private System.Windows.Forms.ToolStripButton btnCustIn;
        private System.Windows.Forms.ToolStripButton btnCarIn;
        private System.Windows.Forms.ToolStripMenuItem DeleteCarStripMenuItem1;
        private System.Windows.Forms.ToolStripButton tbtnQueryOfCar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripButton btnAddCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobilephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlateNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vin;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarSer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsuranceCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn InBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn InEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyHere;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeepBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeepEnd;
    }
}