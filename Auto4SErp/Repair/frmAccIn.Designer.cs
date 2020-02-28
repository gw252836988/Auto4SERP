namespace Auto4SErp.Repair
{
    partial class frmAccIn
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
            System.Windows.Forms.PictureBox btnCustomerFind;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccIn));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgAccessory = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IsPriceChange = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cmbSupplyUnit = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbInType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbHouseName = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblHouseName = new DevComponents.DotNetBar.LabelX();
            this.lblSupplyUnit = new DevComponents.DotNetBar.LabelX();
            this.lblInType = new DevComponents.DotNetBar.LabelX();
            this.txtCreateDate = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCreateDate = new DevComponents.DotNetBar.LabelX();
            this.txtDH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblDH = new DevComponents.DotNetBar.LabelX();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnIn = new System.Windows.Forms.ToolStripButton();
            this.btnBatchIn = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.BackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelAccInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblCount1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblsum = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DeleteEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AccessoryCodeEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.NumEdit = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.searchEdit = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            btnCustomerFind = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(btnCustomerFind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccessory)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccessoryCodeEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCustomerFind
            // 
            btnCustomerFind.BackgroundImage = global::Auto4SErp.Properties.Resources.supply;
            btnCustomerFind.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCustomerFind.Location = new System.Drawing.Point(233, 63);
            btnCustomerFind.Name = "btnCustomerFind";
            btnCustomerFind.Size = new System.Drawing.Size(24, 24);
            btnCustomerFind.TabIndex = 108;
            btnCustomerFind.TabStop = false;
            btnCustomerFind.Click += new System.EventHandler(this.btnCustomerFind_Click);
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "成本单价";
            this.gridColumn4.FieldName = "InPrice";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // dgAccessory
            // 
            this.dgAccessory.AllowUserToAddRows = false;
            this.dgAccessory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAccessory.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgAccessory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgAccessory.Location = new System.Drawing.Point(75, 138);
            this.dgAccessory.MultiSelect = false;
            this.dgAccessory.Name = "dgAccessory";
            this.dgAccessory.RowTemplate.Height = 23;
            this.dgAccessory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgAccessory.Size = new System.Drawing.Size(603, 47);
            this.dgAccessory.TabIndex = 45;
            this.dgAccessory.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAccessory_CellEndEdit);
            this.dgAccessory.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAccessory_CellValidated);
            this.dgAccessory.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgAccessory_CellValidating);
            this.dgAccessory.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgAccessory_RowPostPaint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IsPriceChange);
            this.groupBox1.Controls.Add(btnCustomerFind);
            this.groupBox1.Controls.Add(this.cmbSupplyUnit);
            this.groupBox1.Controls.Add(this.cmbInType);
            this.groupBox1.Controls.Add(this.cmbHouseName);
            this.groupBox1.Controls.Add(this.lblHouseName);
            this.groupBox1.Controls.Add(this.lblSupplyUnit);
            this.groupBox1.Controls.Add(this.lblInType);
            this.groupBox1.Controls.Add(this.txtCreateDate);
            this.groupBox1.Controls.Add(this.lblCreateDate);
            this.groupBox1.Controls.Add(this.txtDH);
            this.groupBox1.Controls.Add(this.lblDH);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // IsPriceChange
            // 
            this.IsPriceChange.Location = new System.Drawing.Point(524, 66);
            this.IsPriceChange.Name = "IsPriceChange";
            this.IsPriceChange.Size = new System.Drawing.Size(170, 23);
            this.IsPriceChange.TabIndex = 109;
            this.IsPriceChange.Text = "用非含税价录入(仅手动)";
            // 
            // cmbSupplyUnit
            // 
            this.cmbSupplyUnit.DisplayMember = "Text";
            this.cmbSupplyUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSupplyUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplyUnit.FormattingEnabled = true;
            this.cmbSupplyUnit.ItemHeight = 15;
            this.cmbSupplyUnit.Location = new System.Drawing.Point(102, 66);
            this.cmbSupplyUnit.Name = "cmbSupplyUnit";
            this.cmbSupplyUnit.Size = new System.Drawing.Size(125, 21);
            this.cmbSupplyUnit.TabIndex = 25;
            this.cmbSupplyUnit.Tag = "N";
            // 
            // cmbInType
            // 
            this.cmbInType.DisplayMember = "Text";
            this.cmbInType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbInType.FormattingEnabled = true;
            this.cmbInType.ItemHeight = 15;
            this.cmbInType.Location = new System.Drawing.Point(586, 31);
            this.cmbInType.Name = "cmbInType";
            this.cmbInType.Size = new System.Drawing.Size(125, 21);
            this.cmbInType.TabIndex = 24;
            this.cmbInType.Tag = "F1S1B0";
            // 
            // cmbHouseName
            // 
            this.cmbHouseName.DisplayMember = "Text";
            this.cmbHouseName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbHouseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHouseName.FormattingEnabled = true;
            this.cmbHouseName.ItemHeight = 15;
            this.cmbHouseName.Location = new System.Drawing.Point(352, 66);
            this.cmbHouseName.Name = "cmbHouseName";
            this.cmbHouseName.Size = new System.Drawing.Size(128, 21);
            this.cmbHouseName.TabIndex = 23;
            this.cmbHouseName.Tag = "N";
            // 
            // lblHouseName
            // 
            this.lblHouseName.AutoSize = true;
            this.lblHouseName.Location = new System.Drawing.Point(290, 69);
            this.lblHouseName.Name = "lblHouseName";
            this.lblHouseName.Size = new System.Drawing.Size(56, 18);
            this.lblHouseName.TabIndex = 21;
            this.lblHouseName.Text = "仓库名称";
            // 
            // lblSupplyUnit
            // 
            this.lblSupplyUnit.AutoSize = true;
            this.lblSupplyUnit.Location = new System.Drawing.Point(40, 69);
            this.lblSupplyUnit.Name = "lblSupplyUnit";
            this.lblSupplyUnit.Size = new System.Drawing.Size(56, 18);
            this.lblSupplyUnit.TabIndex = 17;
            this.lblSupplyUnit.Text = "供货单位";
            // 
            // lblInType
            // 
            this.lblInType.AutoSize = true;
            this.lblInType.Location = new System.Drawing.Point(524, 34);
            this.lblInType.Name = "lblInType";
            this.lblInType.Size = new System.Drawing.Size(56, 18);
            this.lblInType.TabIndex = 15;
            this.lblInType.Text = "入库方式";
            // 
            // txtCreateDate
            // 
            // 
            // 
            // 
            this.txtCreateDate.Border.Class = "TextBoxBorder";
            this.txtCreateDate.Location = new System.Drawing.Point(352, 30);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.ReadOnly = true;
            this.txtCreateDate.Size = new System.Drawing.Size(128, 21);
            this.txtCreateDate.TabIndex = 14;
            this.txtCreateDate.Tag = "B1S1";
            // 
            // lblCreateDate
            // 
            this.lblCreateDate.AutoSize = true;
            this.lblCreateDate.Location = new System.Drawing.Point(290, 33);
            this.lblCreateDate.Name = "lblCreateDate";
            this.lblCreateDate.Size = new System.Drawing.Size(56, 18);
            this.lblCreateDate.TabIndex = 13;
            this.lblCreateDate.Text = "开单日期";
            // 
            // txtDH
            // 
            // 
            // 
            // 
            this.txtDH.Border.Class = "TextBoxBorder";
            this.txtDH.Location = new System.Drawing.Point(102, 30);
            this.txtDH.Name = "txtDH";
            this.txtDH.ReadOnly = true;
            this.txtDH.Size = new System.Drawing.Size(128, 21);
            this.txtDH.TabIndex = 12;
            this.txtDH.Tag = "B1S1";
            // 
            // lblDH
            // 
            this.lblDH.AutoSize = true;
            this.lblDH.Location = new System.Drawing.Point(52, 33);
            this.lblDH.Name = "lblDH";
            this.lblDH.Size = new System.Drawing.Size(44, 18);
            this.lblDH.TabIndex = 11;
            this.lblDH.Text = "单  号";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnIn,
            this.btnBatchIn,
            this.btnPrint,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(789, 25);
            this.toolStrip1.TabIndex = 44;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(52, 22);
            this.btnSave.Tag = "save";
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnIn
            // 
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(52, 22);
            this.btnIn.Tag = "instore";
            this.btnIn.Text = "入库";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnBatchIn
            // 
            this.btnBatchIn.Image = ((System.Drawing.Image)(resources.GetObject("btnBatchIn.Image")));
            this.btnBatchIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBatchIn.Name = "btnBatchIn";
            this.btnBatchIn.Size = new System.Drawing.Size(52, 22);
            this.btnBatchIn.Tag = "in";
            this.btnBatchIn.Text = "导入";
            this.btnBatchIn.Click += new System.EventHandler(this.btnBatchIn_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(52, 22);
            this.btnPrint.Tag = "print";
            this.btnPrint.Text = "打印";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackToolStripMenuItem,
            this.DelAccInToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(45, 22);
            this.toolStripDropDownButton1.Text = "其它";
            // 
            // BackToolStripMenuItem
            // 
            this.BackToolStripMenuItem.Name = "BackToolStripMenuItem";
            this.BackToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.BackToolStripMenuItem.Text = "入库回滚";
            this.BackToolStripMenuItem.Click += new System.EventHandler(this.BackToolStripMenuItem_Click);
            // 
            // DelAccInToolStripMenuItem
            // 
            this.DelAccInToolStripMenuItem.Name = "DelAccInToolStripMenuItem";
            this.DelAccInToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.DelAccInToolStripMenuItem.Tag = "delete";
            this.DelAccInToolStripMenuItem.Text = "删除单据";
            this.DelAccInToolStripMenuItem.Click += new System.EventHandler(this.DelAccInToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCount1,
            this.lblCount,
            this.toolStripStatusLabel1,
            this.lblsum,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(789, 22);
            this.statusStrip1.TabIndex = 46;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblCount1
            // 
            this.lblCount1.Name = "lblCount1";
            this.lblCount1.Size = new System.Drawing.Size(56, 17);
            this.lblCount1.Text = "总数量：";
            // 
            // lblCount
            // 
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(15, 17);
            this.lblCount.Text = "0";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel1.Text = "总金额：";
            // 
            // lblsum
            // 
            this.lblsum.Name = "lblsum";
            this.lblsum.Size = new System.Drawing.Size(15, 17);
            this.lblsum.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(284, 17);
            this.toolStripStatusLabel2.Text = "注：该功能已更新，手动添加时请直接在表格上操作";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 132);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.AccessoryCodeEdit,
            this.NumEdit,
            this.DeleteEdit,
            this.searchEdit});
            this.gridControl1.Size = new System.Drawing.Size(789, 296);
            this.gridControl1.TabIndex = 47;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            gridFormatRule1.Column = this.gridColumn4;
            gridFormatRule1.Name = "Format0";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            this.gridView1.FormatRules.Add(gridFormatRule1);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 20;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            this.gridView1.CustomRowCellEditForEditing += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gridView1_CustomRowCellEditForEditing);
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            this.gridView1.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridView1_InvalidRowException);
            this.gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView1_ValidateRow);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // gridColumn7
            // 
            this.gridColumn7.ColumnEdit = this.DeleteEdit;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            // 
            // DeleteEdit
            // 
            this.DeleteEdit.AutoHeight = false;
            this.DeleteEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "删除", 3, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.DeleteEdit.Name = "DeleteEdit";
            this.DeleteEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.DeleteEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.DeleteEdit_ButtonClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "配件编码";
            this.gridColumn1.FieldName = "AccessoryCode";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "配件名称";
            this.gridColumn2.FieldName = "AccessoryName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "数量";
            this.gridColumn3.FieldName = "Amount";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "金额";
            this.gridColumn5.FieldName = "JE";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "序号";
            this.gridColumn6.FieldName = "XH";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // AccessoryCodeEdit
            // 
            this.AccessoryCodeEdit.AutoHeight = false;
            this.AccessoryCodeEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.AccessoryCodeEdit.Name = "AccessoryCodeEdit";
            this.AccessoryCodeEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.AccessoryCodeEdit_ButtonClick);
            // 
            // NumEdit
            // 
            this.NumEdit.AutoHeight = false;
            this.NumEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NumEdit.Name = "NumEdit";
            this.NumEdit.ValueChanged += new System.EventHandler(this.NumEdit_ValueChanged);
            // 
            // searchEdit
            // 
            this.searchEdit.AutoHeight = false;
            this.searchEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchEdit.DisplayMember = "accessoryname";
            this.searchEdit.Name = "searchEdit";
            this.searchEdit.ValueMember = "accessorycode";
            this.searchEdit.View = this.repositoryItemSearchLookUpEdit1View;
            this.searchEdit.EditValueChanged += new System.EventHandler(this.searchEdit_EditValueChanged);
            this.searchEdit.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.searchEdit_EditValueChanging);
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // frmAccIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 450);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgAccessory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAccIn";
            this.Text = "配件入库";
            this.Load += new System.EventHandler(this.frmAccIn_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAccIn_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(btnCustomerFind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccessory)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccessoryCodeEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.LabelX lblHouseName;
        private DevComponents.DotNetBar.LabelX lblSupplyUnit;
        private DevComponents.DotNetBar.LabelX lblInType;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCreateDate;
        private DevComponents.DotNetBar.LabelX lblCreateDate;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDH;
        private DevComponents.DotNetBar.LabelX lblDH;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbInType;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbHouseName;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgAccessory;
        private System.Windows.Forms.ToolStripButton btnIn;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem BackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelAccInToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnBatchIn;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbSupplyUnit;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblsum;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblCount1;
        private System.Windows.Forms.ToolStripStatusLabel lblCount;
        private DevComponents.DotNetBar.Controls.CheckBoxX IsPriceChange;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit AccessoryCodeEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit NumEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit DeleteEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit searchEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}