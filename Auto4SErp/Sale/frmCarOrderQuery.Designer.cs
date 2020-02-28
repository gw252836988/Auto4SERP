namespace Auto4SErp.Sale
{
    partial class frmCarOrderQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarOrderQuery));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataSet11 = new Auto4SErp.DataSet1();
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
            this.dgCarOrder = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datBegin = new System.Windows.Forms.DateTimePicker();
            this.datEnd = new System.Windows.Forms.DateTimePicker();
            this.chbIsDate = new System.Windows.Forms.CheckBox();
            this.txtMobile = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblDH = new DevComponents.DotNetBar.LabelX();
            this.lblMobile = new DevComponents.DotNetBar.LabelX();
            this.txtCustName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCustName = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnQuery = new System.Windows.Forms.ToolStripButton();
            this.tbtbAdd = new System.Windows.Forms.ToolStripButton();
            this.tbtbOpen = new System.Windows.Forms.ToolStripButton();
            this.btnOut = new System.Windows.Forms.ToolStripButton();
            this.DH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MCustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutoNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarSer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarModelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperatorMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountReceive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCarOrder)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 418);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(922, 25);
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
            // dgCarOrder
            // 
            this.dgCarOrder.AllowUserToAddRows = false;
            this.dgCarOrder.AllowUserToDeleteRows = false;
            this.dgCarOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCarOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DH,
            this.OrderDate,
            this.CustName,
            this.Mobile,
            this.MCustName,
            this.AutoNumber,
            this.CarSer,
            this.CarModelName,
            this.SalePrice,
            this.OperatorMan,
            this.AmountSum,
            this.AmountReceive,
            this.SaleDH});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCarOrder.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgCarOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCarOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgCarOrder.Location = new System.Drawing.Point(0, 111);
            this.dgCarOrder.MultiSelect = false;
            this.dgCarOrder.Name = "dgCarOrder";
            this.dgCarOrder.RowTemplate.Height = 23;
            this.dgCarOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCarOrder.Size = new System.Drawing.Size(922, 307);
            this.dgCarOrder.TabIndex = 36;
            this.dgCarOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCarOrder_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datBegin);
            this.groupBox1.Controls.Add(this.datEnd);
            this.groupBox1.Controls.Add(this.chbIsDate);
            this.groupBox1.Controls.Add(this.txtMobile);
            this.groupBox1.Controls.Add(this.txtDH);
            this.groupBox1.Controls.Add(this.lblDH);
            this.groupBox1.Controls.Add(this.lblMobile);
            this.groupBox1.Controls.Add(this.txtCustName);
            this.groupBox1.Controls.Add(this.lblCustName);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(922, 86);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // datBegin
            // 
            this.datBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datBegin.Location = new System.Drawing.Point(106, 20);
            this.datBegin.Name = "datBegin";
            this.datBegin.Size = new System.Drawing.Size(108, 21);
            this.datBegin.TabIndex = 36;
            // 
            // datEnd
            // 
            this.datEnd.Checked = false;
            this.datEnd.CustomFormat = "";
            this.datEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datEnd.Location = new System.Drawing.Point(243, 20);
            this.datEnd.Name = "datEnd";
            this.datEnd.Size = new System.Drawing.Size(104, 21);
            this.datEnd.TabIndex = 35;
            // 
            // chbIsDate
            // 
            this.chbIsDate.AutoSize = true;
            this.chbIsDate.Checked = true;
            this.chbIsDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbIsDate.Location = new System.Drawing.Point(360, 24);
            this.chbIsDate.Name = "chbIsDate";
            this.chbIsDate.Size = new System.Drawing.Size(15, 14);
            this.chbIsDate.TabIndex = 20;
            this.chbIsDate.UseVisualStyleBackColor = true;
            this.chbIsDate.CheckedChanged += new System.EventHandler(this.chbIsDate_CheckedChanged);
            // 
            // txtMobile
            // 
            // 
            // 
            // 
            this.txtMobile.Border.Class = "TextBoxBorder";
            this.txtMobile.Location = new System.Drawing.Point(106, 53);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(137, 21);
            this.txtMobile.TabIndex = 17;
            this.txtMobile.Tag = "F1S1";
            // 
            // txtDH
            // 
            // 
            // 
            // 
            this.txtDH.Border.Class = "TextBoxBorder";
            this.txtDH.Location = new System.Drawing.Point(445, 19);
            this.txtDH.Name = "txtDH";
            this.txtDH.Size = new System.Drawing.Size(134, 21);
            this.txtDH.TabIndex = 16;
            this.txtDH.Tag = "F1S1";
            // 
            // lblDH
            // 
            this.lblDH.AutoSize = true;
            this.lblDH.Location = new System.Drawing.Point(395, 22);
            this.lblDH.Name = "lblDH";
            this.lblDH.Size = new System.Drawing.Size(44, 18);
            this.lblDH.TabIndex = 15;
            this.lblDH.Text = "单  号";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(56, 56);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(44, 18);
            this.lblMobile.TabIndex = 13;
            this.lblMobile.Text = "手机号";
            // 
            // txtCustName
            // 
            // 
            // 
            // 
            this.txtCustName.Border.Class = "TextBoxBorder";
            this.txtCustName.Location = new System.Drawing.Point(351, 53);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(134, 21);
            this.txtCustName.TabIndex = 12;
            this.txtCustName.Tag = "F1S1";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(289, 56);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(56, 18);
            this.lblCustName.TabIndex = 11;
            this.lblCustName.Text = "客户姓名";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(56, 23);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(44, 18);
            this.labelX1.TabIndex = 10;
            this.labelX1.Text = "日  期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "至";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnQuery,
            this.tbtbAdd,
            this.tbtbOpen,
            this.btnOut});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(922, 25);
            this.toolStrip1.TabIndex = 34;
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
            // tbtbAdd
            // 
            this.tbtbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tbtbAdd.Image")));
            this.tbtbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtbAdd.Name = "tbtbAdd";
            this.tbtbAdd.Size = new System.Drawing.Size(52, 22);
            this.tbtbAdd.Tag = "add";
            this.tbtbAdd.Text = "增加";
            this.tbtbAdd.Click += new System.EventHandler(this.tbtbAdd_Click);
            // 
            // tbtbOpen
            // 
            this.tbtbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tbtbOpen.Image")));
            this.tbtbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtbOpen.Name = "tbtbOpen";
            this.tbtbOpen.Size = new System.Drawing.Size(52, 22);
            this.tbtbOpen.Tag = "open";
            this.tbtbOpen.Text = "打开";
            this.tbtbOpen.Click += new System.EventHandler(this.tbtbOpen_Click);
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
            // DH
            // 
            this.DH.DataPropertyName = "DH";
            this.DH.HeaderText = "单号";
            this.DH.Name = "DH";
            // 
            // OrderDate
            // 
            this.OrderDate.DataPropertyName = "OrderDate";
            this.OrderDate.HeaderText = "开单日期";
            this.OrderDate.Name = "OrderDate";
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
            this.Mobile.HeaderText = "手机号";
            this.Mobile.Name = "Mobile";
            // 
            // MCustName
            // 
            this.MCustName.DataPropertyName = "CustNameM";
            this.MCustName.HeaderText = "变更客户名";
            this.MCustName.Name = "MCustName";
            // 
            // AutoNumber
            // 
            this.AutoNumber.DataPropertyName = "AutoNumber";
            this.AutoNumber.HeaderText = "自编号";
            this.AutoNumber.Name = "AutoNumber";
            // 
            // CarSer
            // 
            this.CarSer.DataPropertyName = "CarSer";
            this.CarSer.HeaderText = "车系";
            this.CarSer.Name = "CarSer";
            // 
            // CarModelName
            // 
            this.CarModelName.DataPropertyName = "CarModel";
            this.CarModelName.HeaderText = "车型";
            this.CarModelName.Name = "CarModelName";
            // 
            // SalePrice
            // 
            this.SalePrice.DataPropertyName = "SalePrice";
            this.SalePrice.HeaderText = "开票价";
            this.SalePrice.Name = "SalePrice";
            // 
            // OperatorMan
            // 
            this.OperatorMan.DataPropertyName = "OperatorMan";
            this.OperatorMan.HeaderText = "业务员";
            this.OperatorMan.Name = "OperatorMan";
            // 
            // AmountSum
            // 
            this.AmountSum.DataPropertyName = "AmountSum";
            this.AmountSum.HeaderText = "提交金额";
            this.AmountSum.Name = "AmountSum";
            // 
            // AmountReceive
            // 
            this.AmountReceive.DataPropertyName = "AmountReceive";
            this.AmountReceive.HeaderText = "已收订金";
            this.AmountReceive.Name = "AmountReceive";
            // 
            // SaleDH
            // 
            this.SaleDH.DataPropertyName = "SaleDH";
            this.SaleDH.HeaderText = "销售单号";
            this.SaleDH.Name = "SaleDH";
            // 
            // frmCarOrderQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 443);
            this.Controls.Add(this.dgCarOrder);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmCarOrderQuery";
            this.Text = "销售订单";
            this.Load += new System.EventHandler(this.frmCarOrderQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCarOrder)).EndInit();
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
        private DevComponents.DotNetBar.LabelX lblMobile;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCustName;
        private DevComponents.DotNetBar.LabelX lblCustName;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgCarOrder;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDH;
        private DevComponents.DotNetBar.LabelX lblDH;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMobile;
        private System.Windows.Forms.ToolStripButton tbtbAdd;
        private System.Windows.Forms.ToolStripButton tbtbOpen;
        private System.Windows.Forms.CheckBox chbIsDate;
        private DataSet1 dataSet11;
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
        private System.Windows.Forms.ToolStripButton btnOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn DH;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn MCustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutoNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarSer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarModelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperatorMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountReceive;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleDH;
    }
}