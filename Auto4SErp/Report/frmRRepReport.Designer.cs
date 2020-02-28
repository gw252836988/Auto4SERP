namespace Auto4SErp.Report
{
    partial class frmRRepReport
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
            DevComponents.DotNetBar.LabelX lblRepChildType;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRRepReport));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnQuery = new System.Windows.Forms.ToolStripButton();
            this.tbtnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnOut = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPlateNum = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.chbZH = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chbIsSG = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.lblSum = new DevComponents.DotNetBar.LabelX();
            this.txtReceptMan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblReceptMan = new DevComponents.DotNetBar.LabelX();
            this.cmbRepChildType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cmbMonth = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cmbYear = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.lblInvoiceType = new DevComponents.DotNetBar.LabelX();
            this.chbIsDate = new System.Windows.Forms.CheckBox();
            this.datBegin = new System.Windows.Forms.DateTimePicker();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.label1 = new System.Windows.Forms.Label();
            this.datEnd = new System.Windows.Forms.DateTimePicker();
            this.gridRepair = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.DeleteEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            lblRepChildType = new DevComponents.DotNetBar.LabelX();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRepair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRepChildType
            // 
            lblRepChildType.AutoSize = true;
            lblRepChildType.Location = new System.Drawing.Point(57, 88);
            lblRepChildType.Margin = new System.Windows.Forms.Padding(4);
            lblRepChildType.Name = "lblRepChildType";
            lblRepChildType.Size = new System.Drawing.Size(69, 21);
            lblRepChildType.TabIndex = 45;
            lblRepChildType.Text = "维修小类";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnQuery,
            this.tbtnOpen,
            this.btnOut});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1523, 27);
            this.toolStrip1.TabIndex = 36;
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
            // tbtnOpen
            // 
            this.tbtnOpen.Image = ((System.Drawing.Image)(resources.GetObject("tbtnOpen.Image")));
            this.tbtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnOpen.Name = "tbtnOpen";
            this.tbtnOpen.Size = new System.Drawing.Size(59, 24);
            this.tbtnOpen.Tag = "open";
            this.tbtnOpen.Text = "打开";
            this.tbtnOpen.Click += new System.EventHandler(this.tbtnOpen_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPlateNum);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.chbZH);
            this.groupBox1.Controls.Add(this.chbIsSG);
            this.groupBox1.Controls.Add(this.lblSum);
            this.groupBox1.Controls.Add(this.txtReceptMan);
            this.groupBox1.Controls.Add(this.lblReceptMan);
            this.groupBox1.Controls.Add(lblRepChildType);
            this.groupBox1.Controls.Add(this.cmbRepChildType);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.cmbMonth);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.cmbYear);
            this.groupBox1.Controls.Add(this.lblInvoiceType);
            this.groupBox1.Controls.Add(this.chbIsDate);
            this.groupBox1.Controls.Add(this.datBegin);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.datEnd);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1523, 152);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // txtPlateNum
            // 
            // 
            // 
            // 
            this.txtPlateNum.Border.Class = "TextBoxBorder";
            this.txtPlateNum.Location = new System.Drawing.Point(692, 82);
            this.txtPlateNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlateNum.Name = "txtPlateNum";
            this.txtPlateNum.Size = new System.Drawing.Size(144, 25);
            this.txtPlateNum.TabIndex = 54;
            this.txtPlateNum.Tag = "N";
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            this.labelX4.Location = new System.Drawing.Point(625, 85);
            this.labelX4.Margin = new System.Windows.Forms.Padding(4);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(54, 21);
            this.labelX4.TabIndex = 53;
            this.labelX4.Text = "车牌号";
            // 
            // chbZH
            // 
            this.chbZH.Location = new System.Drawing.Point(1239, 39);
            this.chbZH.Margin = new System.Windows.Forms.Padding(4);
            this.chbZH.Name = "chbZH";
            this.chbZH.Size = new System.Drawing.Size(100, 29);
            this.chbZH.TabIndex = 52;
            this.chbZH.Text = "只看装潢";
            this.chbZH.Visible = false;
            // 
            // chbIsSG
            // 
            this.chbIsSG.Location = new System.Drawing.Point(1112, 39);
            this.chbIsSG.Margin = new System.Windows.Forms.Padding(4);
            this.chbIsSG.Name = "chbIsSG";
            this.chbIsSG.Size = new System.Drawing.Size(100, 29);
            this.chbIsSG.TabIndex = 51;
            this.chbIsSG.Text = "去事故";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(67, 120);
            this.lblSum.Margin = new System.Windows.Forms.Padding(4);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(0, 0);
            this.lblSum.TabIndex = 49;
            // 
            // txtReceptMan
            // 
            // 
            // 
            // 
            this.txtReceptMan.Border.Class = "TextBoxBorder";
            this.txtReceptMan.Location = new System.Drawing.Point(413, 82);
            this.txtReceptMan.Margin = new System.Windows.Forms.Padding(4);
            this.txtReceptMan.Name = "txtReceptMan";
            this.txtReceptMan.Size = new System.Drawing.Size(151, 25);
            this.txtReceptMan.TabIndex = 48;
            this.txtReceptMan.Tag = "N";
            // 
            // lblReceptMan
            // 
            this.lblReceptMan.AutoSize = true;
            this.lblReceptMan.Location = new System.Drawing.Point(331, 85);
            this.lblReceptMan.Margin = new System.Windows.Forms.Padding(4);
            this.lblReceptMan.Name = "lblReceptMan";
            this.lblReceptMan.Size = new System.Drawing.Size(69, 21);
            this.lblReceptMan.TabIndex = 47;
            this.lblReceptMan.Text = "服务顾问";
            // 
            // cmbRepChildType
            // 
            this.cmbRepChildType.DisplayMember = "Text";
            this.cmbRepChildType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRepChildType.FormattingEnabled = true;
            this.cmbRepChildType.ItemHeight = 15;
            this.cmbRepChildType.Location = new System.Drawing.Point(140, 82);
            this.cmbRepChildType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRepChildType.Name = "cmbRepChildType";
            this.cmbRepChildType.Size = new System.Drawing.Size(149, 21);
            this.cmbRepChildType.TabIndex = 46;
            this.cmbRepChildType.Tag = "N";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.Location = new System.Drawing.Point(1009, 81);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(201, 21);
            this.labelX3.TabIndex = 43;
            this.labelX3.Text = "注：只统计应收大于0的单据";
            // 
            // cmbMonth
            // 
            this.cmbMonth.DisplayMember = "Text";
            this.cmbMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.ItemHeight = 15;
            this.cmbMonth.Location = new System.Drawing.Point(413, 39);
            this.cmbMonth.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(149, 21);
            this.cmbMonth.TabIndex = 42;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(347, 41);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(54, 21);
            this.labelX2.TabIndex = 41;
            this.labelX2.Text = "月  份";
            // 
            // cmbYear
            // 
            this.cmbYear.DisplayMember = "Text";
            this.cmbYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.ItemHeight = 15;
            this.cmbYear.Items.AddRange(new object[] {
            this.comboItem4,
            this.comboItem1,
            this.comboItem3,
            this.comboItem2});
            this.cmbYear.Location = new System.Drawing.Point(140, 41);
            this.cmbYear.Margin = new System.Windows.Forms.Padding(4);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(149, 21);
            this.cmbYear.TabIndex = 40;
            this.cmbYear.Text = "2015";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "2016";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "2015";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "2013";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "2014";
            // 
            // lblInvoiceType
            // 
            this.lblInvoiceType.AutoSize = true;
            this.lblInvoiceType.Location = new System.Drawing.Point(73, 42);
            this.lblInvoiceType.Margin = new System.Windows.Forms.Padding(4);
            this.lblInvoiceType.Name = "lblInvoiceType";
            this.lblInvoiceType.Size = new System.Drawing.Size(54, 21);
            this.lblInvoiceType.TabIndex = 39;
            this.lblInvoiceType.Text = "年  份";
            // 
            // chbIsDate
            // 
            this.chbIsDate.AutoSize = true;
            this.chbIsDate.Location = new System.Drawing.Point(1035, 41);
            this.chbIsDate.Margin = new System.Windows.Forms.Padding(4);
            this.chbIsDate.Name = "chbIsDate";
            this.chbIsDate.Size = new System.Drawing.Size(18, 17);
            this.chbIsDate.TabIndex = 38;
            this.chbIsDate.UseVisualStyleBackColor = true;
            // 
            // datBegin
            // 
            this.datBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datBegin.Location = new System.Drawing.Point(692, 39);
            this.datBegin.Margin = new System.Windows.Forms.Padding(4);
            this.datBegin.Name = "datBegin";
            this.datBegin.Size = new System.Drawing.Size(143, 25);
            this.datBegin.TabIndex = 32;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(609, 40);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(69, 21);
            this.labelX1.TabIndex = 31;
            this.labelX1.Text = "结算日期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(844, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "至";
            // 
            // datEnd
            // 
            this.datEnd.Checked = false;
            this.datEnd.CustomFormat = "";
            this.datEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datEnd.Location = new System.Drawing.Point(875, 39);
            this.datEnd.Margin = new System.Windows.Forms.Padding(4);
            this.datEnd.Name = "datEnd";
            this.datEnd.Size = new System.Drawing.Size(137, 25);
            this.datEnd.TabIndex = 29;
            // 
            // gridRepair
            // 
            this.gridRepair.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridRepair.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridRepair.Location = new System.Drawing.Point(0, 179);
            this.gridRepair.MainView = this.gridView1;
            this.gridRepair.Name = "gridRepair";
            this.gridRepair.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.DateEdit,
            this.DeleteEdit});
            this.gridRepair.Size = new System.Drawing.Size(1523, 520);
            this.gridRepair.TabIndex = 57;
            this.gridRepair.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn13,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn3});
            this.gridView1.GridControl = this.gridRepair;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Gamount", null, "(结算金额: {0:0.##})"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ItemProfit", null, "(工时费: {0:0.##})"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AccProfit", null, "(材料费: {0:0.##})")});
            this.gridView1.IndicatorWidth = 50;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "单号";
            this.gridColumn1.FieldName = "DH";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "DH", "{0:0.##}")});
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "维修小类";
            this.gridColumn2.FieldName = "RepChildType";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "车牌号";
            this.gridColumn4.FieldName = "PlateNum";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "顾客姓名";
            this.gridColumn5.FieldName = "CustName";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "服务顾问";
            this.gridColumn13.FieldName = "ReceptMan";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 5;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "结算金额";
            this.gridColumn6.FieldName = "Gamount";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Gamount", "{0:0.##}")});
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "通过金额";
            this.gridColumn7.FieldName = "AccessAmount";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AccessAmount", "{0:0.##}")});
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 7;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "工时费";
            this.gridColumn8.FieldName = "ItemProfit";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ItemProfit", "{0:0.##}")});
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 8;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "材料费";
            this.gridColumn9.FieldName = "AccProfit";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AccProfit", "{0:0.##}")});
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 9;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "材料成本";
            this.gridColumn10.FieldName = "Ginprice";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Ginprice", "{0:0.##}")});
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 10;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "单车利润";
            this.gridColumn11.FieldName = "GProfit";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "GProfit", "{0:0.##}")});
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 11;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "毛利率";
            this.gridColumn12.FieldName = "PRate";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "PRate", "{0:0.##}")});
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 12;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "结算日期";
            this.gridColumn3.FieldName = "accounttime";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // DateEdit
            // 
            this.DateEdit.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.DateEdit.AutoHeight = false;
            this.DateEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateEdit.CalendarTimeProperties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.DateEdit.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateEdit.Name = "DateEdit";
            this.DateEdit.NullDate = new System.DateTime(2019, 11, 22, 9, 31, 10, 198);
            // 
            // DeleteEdit
            // 
            this.DeleteEdit.AutoHeight = false;
            this.DeleteEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "删除", 3, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.DeleteEdit.Name = "DeleteEdit";
            this.DeleteEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // frmRRepReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1523, 699);
            this.Controls.Add(this.gridRepair);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmRRepReport";
            this.Text = "售后利润统计";
            this.Load += new System.EventHandler(this.frmRRepReport_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRepair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnQuery;
        private System.Windows.Forms.ToolStripButton tbtnOpen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker datBegin;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datEnd;
        private System.Windows.Forms.CheckBox chbIsDate;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbMonth;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbYear;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.DotNetBar.LabelX lblInvoiceType;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.ToolStripButton btnOut;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbRepChildType;
        private DevComponents.DotNetBar.Controls.TextBoxX txtReceptMan;
        private DevComponents.DotNetBar.LabelX lblReceptMan;
        private DevComponents.DotNetBar.LabelX lblSum;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPlateNum;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.CheckBoxX chbZH;
        private DevComponents.DotNetBar.Controls.CheckBoxX chbIsSG;
        private DevExpress.XtraGrid.GridControl gridRepair;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit DateEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit DeleteEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}