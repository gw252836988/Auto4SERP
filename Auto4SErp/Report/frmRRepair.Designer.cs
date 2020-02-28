namespace Auto4SErp.Report
{
    partial class frmRRepair
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
            DevComponents.DotNetBar.LabelX labelX3;
            DevComponents.DotNetBar.LabelX labelX2;
            DevComponents.DotNetBar.LabelX lblRepChildType;
            DevComponents.DotNetBar.LabelX lblRepType;
            DevComponents.DotNetBar.LabelX lblStatus;
            DevComponents.DotNetBar.LabelX lblDate;
            System.Windows.Forms.PictureBox btnCarDocSel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRRepair));
            this.dgRepair = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCarModel = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCarModel = new DevComponents.DotNetBar.LabelX();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpBegin = new System.Windows.Forms.DateTimePicker();
            this.txtVin = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblVin = new DevComponents.DotNetBar.LabelX();
            this.txtCustName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCustName = new DevComponents.DotNetBar.LabelX();
            this.gpStatus = new System.Windows.Forms.GroupBox();
            this.chbPreAccount = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chbWorking = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cmbRepChildType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbRepType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem9 = new DevComponents.Editors.ComboItem();
            this.comboItem7 = new DevComponents.Editors.ComboItem();
            this.comboItem8 = new DevComponents.Editors.ComboItem();
            this.cmbStatus = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.txtPlateNum = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblPlateNum = new DevComponents.DotNetBar.LabelX();
            this.txtReceptMan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblReceptMan = new DevComponents.DotNetBar.LabelX();
            this.txtDH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblDH = new DevComponents.DotNetBar.LabelX();
            this.txtDate = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem6 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
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
            this.tbtnQuery = new System.Windows.Forms.ToolStripButton();
            this.tbtnOpen = new System.Windows.Forms.ToolStripButton();
            this.tbtnOut = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlateNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceptTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepChildType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceptMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendRepMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vipLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            labelX3 = new DevComponents.DotNetBar.LabelX();
            labelX2 = new DevComponents.DotNetBar.LabelX();
            lblRepChildType = new DevComponents.DotNetBar.LabelX();
            lblRepType = new DevComponents.DotNetBar.LabelX();
            lblStatus = new DevComponents.DotNetBar.LabelX();
            lblDate = new DevComponents.DotNetBar.LabelX();
            btnCarDocSel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(btnCarDocSel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRepair)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gpStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelX3
            // 
            labelX3.AutoSize = true;
            labelX3.Location = new System.Drawing.Point(51, 101);
            labelX3.Name = "labelX3";
            labelX3.Size = new System.Drawing.Size(19, 18);
            labelX3.TabIndex = 38;
            labelX3.Text = "至";
            // 
            // labelX2
            // 
            labelX2.AutoSize = true;
            labelX2.Location = new System.Drawing.Point(52, 67);
            labelX2.Name = "labelX2";
            labelX2.Size = new System.Drawing.Size(19, 18);
            labelX2.TabIndex = 36;
            labelX2.Text = "从";
            // 
            // lblRepChildType
            // 
            lblRepChildType.AutoSize = true;
            lblRepChildType.Location = new System.Drawing.Point(396, 66);
            lblRepChildType.Name = "lblRepChildType";
            lblRepChildType.Size = new System.Drawing.Size(56, 18);
            lblRepChildType.TabIndex = 27;
            lblRepChildType.Text = "维修小类";
            // 
            // lblRepType
            // 
            lblRepType.Location = new System.Drawing.Point(203, 66);
            lblRepType.Name = "lblRepType";
            lblRepType.Size = new System.Drawing.Size(56, 18);
            lblRepType.TabIndex = 25;
            lblRepType.Text = "维修类别";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new System.Drawing.Point(820, 33);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(56, 18);
            lblStatus.TabIndex = 23;
            lblStatus.Text = "工单状态";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new System.Drawing.Point(39, 32);
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(31, 18);
            lblDate.TabIndex = 15;
            lblDate.Text = "日期";
            // 
            // btnCarDocSel
            // 
            btnCarDocSel.BackgroundImage = global::Auto4SErp.Properties.Resources.smallquery;
            btnCarDocSel.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCarDocSel.Location = new System.Drawing.Point(769, 64);
            btnCarDocSel.Name = "btnCarDocSel";
            btnCarDocSel.Size = new System.Drawing.Size(16, 16);
            btnCarDocSel.TabIndex = 108;
            btnCarDocSel.TabStop = false;
            btnCarDocSel.Click += new System.EventHandler(this.btnCarDocSel_Click);
            // 
            // dgRepair
            // 
            this.dgRepair.AllowUserToAddRows = false;
            this.dgRepair.AllowUserToDeleteRows = false;
            this.dgRepair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRepair.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Status,
            this.DH,
            this.PlateNum,
            this.Vin,
            this.CustName,
            this.mobile,
            this.ReceptTime,
            this.AccountTime,
            this.RepType,
            this.RepChildType,
            this.CarModel,
            this.GAmount,
            this.AccessAmount,
            this.AccessDate,
            this.ReceptMan,
            this.SendRepMan,
            this.CardNo,
            this.vipLevel});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgRepair.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgRepair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgRepair.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgRepair.Location = new System.Drawing.Point(0, 165);
            this.dgRepair.Name = "dgRepair";
            this.dgRepair.RowTemplate.Height = 23;
            this.dgRepair.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRepair.Size = new System.Drawing.Size(1025, 312);
            this.dgRepair.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(btnCarDocSel);
            this.groupBox1.Controls.Add(this.txtCarModel);
            this.groupBox1.Controls.Add(this.lblCarModel);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(labelX3);
            this.groupBox1.Controls.Add(this.dtpBegin);
            this.groupBox1.Controls.Add(labelX2);
            this.groupBox1.Controls.Add(this.txtVin);
            this.groupBox1.Controls.Add(this.lblVin);
            this.groupBox1.Controls.Add(this.txtCustName);
            this.groupBox1.Controls.Add(this.lblCustName);
            this.groupBox1.Controls.Add(this.gpStatus);
            this.groupBox1.Controls.Add(lblRepChildType);
            this.groupBox1.Controls.Add(this.cmbRepChildType);
            this.groupBox1.Controls.Add(lblRepType);
            this.groupBox1.Controls.Add(this.cmbRepType);
            this.groupBox1.Controls.Add(lblStatus);
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.txtPlateNum);
            this.groupBox1.Controls.Add(this.lblPlateNum);
            this.groupBox1.Controls.Add(this.txtReceptMan);
            this.groupBox1.Controls.Add(this.lblReceptMan);
            this.groupBox1.Controls.Add(this.txtDH);
            this.groupBox1.Controls.Add(this.lblDH);
            this.groupBox1.Controls.Add(lblDate);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1025, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtCarModel
            // 
            // 
            // 
            // 
            this.txtCarModel.Border.Class = "TextBoxBorder";
            this.txtCarModel.Location = new System.Drawing.Point(646, 63);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(116, 21);
            this.txtCarModel.TabIndex = 41;
            this.txtCarModel.Tag = "F1S1";
            // 
            // lblCarModel
            // 
            this.lblCarModel.AutoSize = true;
            this.lblCarModel.Location = new System.Drawing.Point(588, 66);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.Size = new System.Drawing.Size(56, 18);
            this.lblCarModel.TabIndex = 40;
            this.lblCarModel.Text = "车辆型号";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Enabled = false;
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(76, 98);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(112, 21);
            this.dtpEnd.TabIndex = 39;
            // 
            // dtpBegin
            // 
            this.dtpBegin.CustomFormat = "";
            this.dtpBegin.Enabled = false;
            this.dtpBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBegin.Location = new System.Drawing.Point(77, 63);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(112, 21);
            this.dtpBegin.TabIndex = 37;
            // 
            // txtVin
            // 
            // 
            // 
            // 
            this.txtVin.Border.Class = "TextBoxBorder";
            this.txtVin.Location = new System.Drawing.Point(456, 97);
            this.txtVin.Name = "txtVin";
            this.txtVin.Size = new System.Drawing.Size(116, 21);
            this.txtVin.TabIndex = 35;
            this.txtVin.Tag = "F1S1";
            // 
            // lblVin
            // 
            this.lblVin.AutoSize = true;
            this.lblVin.Location = new System.Drawing.Point(407, 100);
            this.lblVin.Name = "lblVin";
            this.lblVin.Size = new System.Drawing.Size(37, 18);
            this.lblVin.TabIndex = 34;
            this.lblVin.Text = "Vin码";
            // 
            // txtCustName
            // 
            // 
            // 
            // 
            this.txtCustName.Border.Class = "TextBoxBorder";
            this.txtCustName.Location = new System.Drawing.Point(265, 97);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(114, 21);
            this.txtCustName.TabIndex = 33;
            this.txtCustName.Tag = "F1S1";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(203, 100);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(56, 18);
            this.lblCustName.TabIndex = 32;
            this.lblCustName.Text = "客户名字";
            // 
            // gpStatus
            // 
            this.gpStatus.Controls.Add(this.chbPreAccount);
            this.gpStatus.Controls.Add(this.chbWorking);
            this.gpStatus.Enabled = false;
            this.gpStatus.Location = new System.Drawing.Point(820, 61);
            this.gpStatus.Name = "gpStatus";
            this.gpStatus.Size = new System.Drawing.Size(155, 44);
            this.gpStatus.TabIndex = 31;
            this.gpStatus.TabStop = false;
            // 
            // chbPreAccount
            // 
            this.chbPreAccount.Location = new System.Drawing.Point(74, 15);
            this.chbPreAccount.Name = "chbPreAccount";
            this.chbPreAccount.Size = new System.Drawing.Size(75, 23);
            this.chbPreAccount.TabIndex = 1;
            this.chbPreAccount.Text = "已预结算";
            // 
            // chbWorking
            // 
            this.chbWorking.Location = new System.Drawing.Point(6, 16);
            this.chbWorking.Name = "chbWorking";
            this.chbWorking.Size = new System.Drawing.Size(75, 23);
            this.chbWorking.TabIndex = 0;
            this.chbWorking.Text = "作业中";
            // 
            // cmbRepChildType
            // 
            this.cmbRepChildType.DisplayMember = "Text";
            this.cmbRepChildType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRepChildType.FormattingEnabled = true;
            this.cmbRepChildType.ItemHeight = 15;
            this.cmbRepChildType.Location = new System.Drawing.Point(457, 64);
            this.cmbRepChildType.Name = "cmbRepChildType";
            this.cmbRepChildType.Size = new System.Drawing.Size(116, 21);
            this.cmbRepChildType.TabIndex = 28;
            this.cmbRepChildType.Tag = "F1S1B0";
            // 
            // cmbRepType
            // 
            this.cmbRepType.DisplayMember = "Text";
            this.cmbRepType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRepType.FormattingEnabled = true;
            this.cmbRepType.ItemHeight = 15;
            this.cmbRepType.Items.AddRange(new object[] {
            this.comboItem9,
            this.comboItem7,
            this.comboItem8});
            this.cmbRepType.Location = new System.Drawing.Point(265, 64);
            this.cmbRepType.Name = "cmbRepType";
            this.cmbRepType.Size = new System.Drawing.Size(114, 21);
            this.cmbRepType.TabIndex = 26;
            this.cmbRepType.Tag = "F0S1B0";
            this.cmbRepType.SelectedIndexChanged += new System.EventHandler(this.cmbRepType_SelectedIndexChanged);
            // 
            // comboItem7
            // 
            this.comboItem7.Text = "维修";
            // 
            // comboItem8
            // 
            this.comboItem8.Text = "装潢";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DisplayMember = "Text";
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.ItemHeight = 15;
            this.cmbStatus.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3});
            this.cmbStatus.Location = new System.Drawing.Point(882, 30);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(93, 21);
            this.cmbStatus.TabIndex = 24;
            this.cmbStatus.Tag = "N";
            this.cmbStatus.SelectedValueChanged += new System.EventHandler(this.cmbStatus_SelectedValueChanged);
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "在修";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "结算";
            // 
            // txtPlateNum
            // 
            // 
            // 
            // 
            this.txtPlateNum.Border.Class = "TextBoxBorder";
            this.txtPlateNum.Location = new System.Drawing.Point(457, 30);
            this.txtPlateNum.Name = "txtPlateNum";
            this.txtPlateNum.Size = new System.Drawing.Size(115, 21);
            this.txtPlateNum.TabIndex = 22;
            this.txtPlateNum.Tag = "F1S1";
            // 
            // lblPlateNum
            // 
            this.lblPlateNum.AutoSize = true;
            this.lblPlateNum.Location = new System.Drawing.Point(407, 33);
            this.lblPlateNum.Name = "lblPlateNum";
            this.lblPlateNum.Size = new System.Drawing.Size(44, 18);
            this.lblPlateNum.TabIndex = 21;
            this.lblPlateNum.Text = "车牌号";
            // 
            // txtReceptMan
            // 
            // 
            // 
            // 
            this.txtReceptMan.Border.Class = "TextBoxBorder";
            this.txtReceptMan.Location = new System.Drawing.Point(646, 30);
            this.txtReceptMan.Name = "txtReceptMan";
            this.txtReceptMan.Size = new System.Drawing.Size(116, 21);
            this.txtReceptMan.TabIndex = 20;
            this.txtReceptMan.Tag = "F1S1";
            // 
            // lblReceptMan
            // 
            this.lblReceptMan.AutoSize = true;
            this.lblReceptMan.Location = new System.Drawing.Point(596, 33);
            this.lblReceptMan.Name = "lblReceptMan";
            this.lblReceptMan.Size = new System.Drawing.Size(44, 18);
            this.lblReceptMan.TabIndex = 19;
            this.lblReceptMan.Text = "接车人";
            // 
            // txtDH
            // 
            // 
            // 
            // 
            this.txtDH.Border.Class = "TextBoxBorder";
            this.txtDH.Location = new System.Drawing.Point(265, 31);
            this.txtDH.Name = "txtDH";
            this.txtDH.Size = new System.Drawing.Size(114, 21);
            this.txtDH.TabIndex = 18;
            this.txtDH.Tag = "F1S1";
            // 
            // lblDH
            // 
            this.lblDH.AutoSize = true;
            this.lblDH.Location = new System.Drawing.Point(228, 34);
            this.lblDH.Name = "lblDH";
            this.lblDH.Size = new System.Drawing.Size(31, 18);
            this.lblDH.TabIndex = 17;
            this.lblDH.Text = "单号";
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
            this.txtDate.Location = new System.Drawing.Point(76, 30);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(113, 21);
            this.txtDate.TabIndex = 16;
            this.txtDate.Tag = "N";
            this.txtDate.SelectedIndexChanged += new System.EventHandler(this.txtDate_SelectedIndexChanged);
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "接车日期";
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "结算日期";
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
            this.lblSum});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 477);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1025, 25);
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
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(0, 22);
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
            // tbtnOpen
            // 
            this.tbtnOpen.Image = ((System.Drawing.Image)(resources.GetObject("tbtnOpen.Image")));
            this.tbtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnOpen.Name = "tbtnOpen";
            this.tbtnOpen.Size = new System.Drawing.Size(52, 22);
            this.tbtnOpen.Tag = "open";
            this.tbtnOpen.Text = "打开";
            this.tbtnOpen.Click += new System.EventHandler(this.tbtnOpen_Click);
            // 
            // tbtnOut
            // 
            this.tbtnOut.Image = ((System.Drawing.Image)(resources.GetObject("tbtnOut.Image")));
            this.tbtnOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnOut.Name = "tbtnOut";
            this.tbtnOut.Size = new System.Drawing.Size(52, 22);
            this.tbtnOut.Tag = "out";
            this.tbtnOut.Text = "导出";
            this.tbtnOut.Click += new System.EventHandler(this.tbtnOut_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnQuery,
            this.tbtnOpen,
            this.tbtnOut});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1025, 25);
            this.toolStrip1.TabIndex = 35;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.Frozen = true;
            this.Status.HeaderText = "状态";
            this.Status.Name = "Status";
            // 
            // DH
            // 
            this.DH.DataPropertyName = "DH";
            this.DH.Frozen = true;
            this.DH.HeaderText = "单号";
            this.DH.Name = "DH";
            // 
            // PlateNum
            // 
            this.PlateNum.DataPropertyName = "PlateNum";
            this.PlateNum.Frozen = true;
            this.PlateNum.HeaderText = "车牌号";
            this.PlateNum.Name = "PlateNum";
            // 
            // Vin
            // 
            this.Vin.DataPropertyName = "Vin";
            this.Vin.Frozen = true;
            this.Vin.HeaderText = "Vin码";
            this.Vin.Name = "Vin";
            // 
            // CustName
            // 
            this.CustName.DataPropertyName = "CustName";
            this.CustName.Frozen = true;
            this.CustName.HeaderText = "客户姓名";
            this.CustName.Name = "CustName";
            // 
            // mobile
            // 
            this.mobile.DataPropertyName = "mobile";
            this.mobile.Frozen = true;
            this.mobile.HeaderText = "手机号";
            this.mobile.Name = "mobile";
            // 
            // ReceptTime
            // 
            this.ReceptTime.DataPropertyName = "ReceptTime";
            this.ReceptTime.HeaderText = "接车时间";
            this.ReceptTime.Name = "ReceptTime";
            // 
            // AccountTime
            // 
            this.AccountTime.DataPropertyName = "AccountTime";
            this.AccountTime.HeaderText = "结算时间";
            this.AccountTime.Name = "AccountTime";
            // 
            // RepType
            // 
            this.RepType.DataPropertyName = "RepType";
            this.RepType.HeaderText = "维修类别";
            this.RepType.Name = "RepType";
            // 
            // RepChildType
            // 
            this.RepChildType.DataPropertyName = "RepChildType";
            this.RepChildType.HeaderText = "维修小类";
            this.RepChildType.Name = "RepChildType";
            // 
            // CarModel
            // 
            this.CarModel.DataPropertyName = "CarModel";
            this.CarModel.HeaderText = "车型";
            this.CarModel.Name = "CarModel";
            // 
            // GAmount
            // 
            this.GAmount.DataPropertyName = "GAmount";
            this.GAmount.HeaderText = "应收金额";
            this.GAmount.Name = "GAmount";
            // 
            // AccessAmount
            // 
            this.AccessAmount.DataPropertyName = "AccessAmount";
            this.AccessAmount.HeaderText = "通过金额";
            this.AccessAmount.Name = "AccessAmount";
            // 
            // AccessDate
            // 
            this.AccessDate.DataPropertyName = "AccessDate";
            this.AccessDate.HeaderText = "通过日期";
            this.AccessDate.Name = "AccessDate";
            // 
            // ReceptMan
            // 
            this.ReceptMan.DataPropertyName = "ReceptMan";
            this.ReceptMan.HeaderText = "接车人";
            this.ReceptMan.Name = "ReceptMan";
            // 
            // SendRepMan
            // 
            this.SendRepMan.DataPropertyName = "SendRepMan";
            this.SendRepMan.HeaderText = "送修人";
            this.SendRepMan.Name = "SendRepMan";
            // 
            // CardNo
            // 
            this.CardNo.DataPropertyName = "CardNo";
            this.CardNo.HeaderText = "会员卡号";
            this.CardNo.Name = "CardNo";
            // 
            // vipLevel
            // 
            this.vipLevel.DataPropertyName = "vipLevel";
            this.vipLevel.HeaderText = "会员级别";
            this.vipLevel.Name = "vipLevel";
            // 
            // frmRRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 502);
            this.Controls.Add(this.dgRepair);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmRRepair";
            this.Text = "维修查询";
            this.Load += new System.EventHandler(this.frmR_Repair_Load);
            ((System.ComponentModel.ISupportInitialize)(btnCarDocSel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRepair)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx txtDate;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.ComboItem comboItem5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDH;
        private DevComponents.DotNetBar.LabelX lblDH;
        private DevComponents.DotNetBar.Controls.TextBoxX txtReceptMan;
        private DevComponents.DotNetBar.LabelX lblReceptMan;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbStatus;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPlateNum;
        private DevComponents.DotNetBar.LabelX lblPlateNum;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbRepType;
        private DevComponents.Editors.ComboItem comboItem7;
        private DevComponents.Editors.ComboItem comboItem8;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbRepChildType;
        private System.Windows.Forms.GroupBox gpStatus;
        private DevComponents.DotNetBar.Controls.CheckBoxX chbPreAccount;
        private DevComponents.DotNetBar.Controls.CheckBoxX chbWorking;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCustName;
        private DevComponents.DotNetBar.LabelX lblCustName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtVin;
        private DevComponents.DotNetBar.LabelX lblVin;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpBegin;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgRepair;
        private DevComponents.Editors.ComboItem comboItem6;
        private DevComponents.Editors.ComboItem comboItem9;
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
        private System.Windows.Forms.ToolStripLabel lblSum;
        private System.Windows.Forms.ToolStripButton tbtnQuery;
        private System.Windows.Forms.ToolStripButton tbtnOpen;
        private System.Windows.Forms.ToolStripButton tbtnOut;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCarModel;
        private DevComponents.DotNetBar.LabelX lblCarModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn DH;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlateNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vin;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceptTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepChildType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn GAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceptMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SendRepMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn vipLevel;
    }
}