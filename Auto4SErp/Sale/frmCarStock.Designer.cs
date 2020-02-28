namespace Auto4SErp.Sale
{
    partial class frmCarStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarStock));
            this.cMenuCarStock = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ModifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgCarStock = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInfo = new DevComponents.DotNetBar.LabelX();
            this.picCar = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.igiDays = new DevComponents.Editors.IntegerInput();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cmbStatus = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.lblStatus = new DevComponents.DotNetBar.LabelX();
            this.txtVin = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblVin = new DevComponents.DotNetBar.LabelX();
            this.cmbStorePlace = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblStorePlace = new DevComponents.DotNetBar.LabelX();
            this.cmbDisplacement = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem7 = new DevComponents.Editors.ComboItem();
            this.lblDisplacement = new DevComponents.DotNetBar.LabelX();
            this.cmbColor = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblColor = new DevComponents.DotNetBar.LabelX();
            this.txtCarSer = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCarSer = new DevComponents.DotNetBar.LabelX();
            this.txtCarModel = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCarModel = new DevComponents.DotNetBar.LabelX();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnQuery = new System.Windows.Forms.ToolStripButton();
            this.btnOut = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblSum = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblOver = new System.Windows.Forms.ToolStripStatusLabel();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutoNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarSer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Displacement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transmission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarOfYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StorePlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemIDFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarInDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirectPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMenuCarStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCarStock)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.igiDays)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cMenuCarStock
            // 
            this.cMenuCarStock.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModifyToolStripMenuItem,
            this.DelToolStripMenuItem});
            this.cMenuCarStock.Name = "cMenuCarStock";
            this.cMenuCarStock.Size = new System.Drawing.Size(101, 48);
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
            // dgCarStock
            // 
            this.dgCarStock.AllowUserToAddRows = false;
            this.dgCarStock.AllowUserToDeleteRows = false;
            this.dgCarStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCarStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Status1,
            this.DetailID,
            this.AutoNumber,
            this.StockDays,
            this.BrandName,
            this.CarSer,
            this.CarModel,
            this.Color,
            this.Displacement,
            this.Transmission,
            this.Vin,
            this.CarOfYear,
            this.SalePrice,
            this.StorePlace,
            this.ItemIDFrom,
            this.Image1,
            this.CarInDate,
            this.InPrice,
            this.DirectPrice});
            this.dgCarStock.ContextMenuStrip = this.cMenuCarStock;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCarStock.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgCarStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCarStock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgCarStock.Location = new System.Drawing.Point(198, 125);
            this.dgCarStock.MultiSelect = false;
            this.dgCarStock.Name = "dgCarStock";
            this.dgCarStock.RowTemplate.Height = 23;
            this.dgCarStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCarStock.Size = new System.Drawing.Size(628, 317);
            this.dgCarStock.TabIndex = 30;
            this.dgCarStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCarStock_CellClick);
            this.dgCarStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCarStock_CellContentClick);
            this.dgCarStock.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCarStock_CellDoubleClick);
            this.dgCarStock.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgCarStock_RowPostPaint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Controls.Add(this.picCar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 339);
            this.panel1.TabIndex = 33;
            this.panel1.Visible = false;
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(59, 144);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(75, 23);
            this.lblInfo.TabIndex = 1;
            // 
            // picCar
            // 
            this.picCar.Location = new System.Drawing.Point(0, 0);
            this.picCar.Name = "picCar";
            this.picCar.Size = new System.Drawing.Size(198, 138);
            this.picCar.TabIndex = 0;
            this.picCar.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.igiDays);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.txtVin);
            this.groupBox1.Controls.Add(this.lblVin);
            this.groupBox1.Controls.Add(this.cmbStorePlace);
            this.groupBox1.Controls.Add(this.lblStorePlace);
            this.groupBox1.Controls.Add(this.cmbDisplacement);
            this.groupBox1.Controls.Add(this.lblDisplacement);
            this.groupBox1.Controls.Add(this.cmbColor);
            this.groupBox1.Controls.Add(this.lblColor);
            this.groupBox1.Controls.Add(this.txtCarSer);
            this.groupBox1.Controls.Add(this.lblCarSer);
            this.groupBox1.Controls.Add(this.txtCarModel);
            this.groupBox1.Controls.Add(this.lblCarModel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(826, 100);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // igiDays
            // 
            // 
            // 
            // 
            this.igiDays.BackgroundStyle.Class = "DateTimeInputBackground";
            this.igiDays.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.igiDays.Location = new System.Drawing.Point(711, 57);
            this.igiDays.Name = "igiDays";
            this.igiDays.ShowUpDown = true;
            this.igiDays.Size = new System.Drawing.Size(92, 21);
            this.igiDays.TabIndex = 84;
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.Location = new System.Drawing.Point(649, 60);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(62, 18);
            this.labelX3.TabIndex = 83;
            this.labelX3.Text = "库存天数>";
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
            this.comboItem5});
            this.cmbStatus.Location = new System.Drawing.Point(711, 20);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(93, 21);
            this.cmbStatus.TabIndex = 82;
            this.cmbStatus.Tag = "F1S1B1";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "未出库";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "锁定";
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "已出库";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(661, 24);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 18);
            this.lblStatus.TabIndex = 81;
            this.lblStatus.Text = "状  态";
            // 
            // txtVin
            // 
            // 
            // 
            // 
            this.txtVin.Border.Class = "TextBoxBorder";
            this.txtVin.Location = new System.Drawing.Point(498, 57);
            this.txtVin.Name = "txtVin";
            this.txtVin.Size = new System.Drawing.Size(121, 21);
            this.txtVin.TabIndex = 80;
            this.txtVin.Tag = "F1S1";
            // 
            // lblVin
            // 
            this.lblVin.AutoSize = true;
            this.lblVin.Location = new System.Drawing.Point(448, 60);
            this.lblVin.Name = "lblVin";
            this.lblVin.Size = new System.Drawing.Size(44, 18);
            this.lblVin.TabIndex = 79;
            this.lblVin.Text = "VIN 码";
            // 
            // cmbStorePlace
            // 
            this.cmbStorePlace.DisplayMember = "Text";
            this.cmbStorePlace.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStorePlace.FormattingEnabled = true;
            this.cmbStorePlace.ItemHeight = 15;
            this.cmbStorePlace.Location = new System.Drawing.Point(292, 58);
            this.cmbStorePlace.Name = "cmbStorePlace";
            this.cmbStorePlace.Size = new System.Drawing.Size(119, 21);
            this.cmbStorePlace.TabIndex = 78;
            this.cmbStorePlace.Tag = "F1S1B0";
            // 
            // lblStorePlace
            // 
            this.lblStorePlace.AutoSize = true;
            this.lblStorePlace.Location = new System.Drawing.Point(230, 60);
            this.lblStorePlace.Name = "lblStorePlace";
            this.lblStorePlace.Size = new System.Drawing.Size(56, 18);
            this.lblStorePlace.TabIndex = 77;
            this.lblStorePlace.Text = "存放位置";
            // 
            // cmbDisplacement
            // 
            this.cmbDisplacement.DisplayMember = "Text";
            this.cmbDisplacement.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDisplacement.FormattingEnabled = true;
            this.cmbDisplacement.ItemHeight = 15;
            this.cmbDisplacement.Items.AddRange(new object[] {
            this.comboItem3,
            this.comboItem4,
            this.comboItem7});
            this.cmbDisplacement.Location = new System.Drawing.Point(87, 58);
            this.cmbDisplacement.Name = "cmbDisplacement";
            this.cmbDisplacement.Size = new System.Drawing.Size(121, 21);
            this.cmbDisplacement.TabIndex = 62;
            this.cmbDisplacement.Tag = "F1S1B0";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "1.4";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "1.6";
            // 
            // comboItem7
            // 
            this.comboItem7.Text = "2.0";
            // 
            // lblDisplacement
            // 
            this.lblDisplacement.AutoSize = true;
            this.lblDisplacement.Location = new System.Drawing.Point(39, 61);
            this.lblDisplacement.Name = "lblDisplacement";
            this.lblDisplacement.Size = new System.Drawing.Size(44, 18);
            this.lblDisplacement.TabIndex = 61;
            this.lblDisplacement.Text = "排气量";
            // 
            // cmbColor
            // 
            this.cmbColor.DisplayMember = "Text";
            this.cmbColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.ItemHeight = 15;
            this.cmbColor.Location = new System.Drawing.Point(498, 20);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(121, 21);
            this.cmbColor.TabIndex = 60;
            this.cmbColor.Tag = "F1S1B0";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(436, 22);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(56, 18);
            this.lblColor.TabIndex = 59;
            this.lblColor.Text = "车身颜色";
            // 
            // txtCarSer
            // 
            // 
            // 
            // 
            this.txtCarSer.Border.Class = "TextBoxBorder";
            this.txtCarSer.Location = new System.Drawing.Point(87, 20);
            this.txtCarSer.Name = "txtCarSer";
            this.txtCarSer.Size = new System.Drawing.Size(121, 21);
            this.txtCarSer.TabIndex = 53;
            this.txtCarSer.Tag = "F1S1";
            // 
            // lblCarSer
            // 
            this.lblCarSer.AutoSize = true;
            this.lblCarSer.Location = new System.Drawing.Point(39, 23);
            this.lblCarSer.Name = "lblCarSer";
            this.lblCarSer.Size = new System.Drawing.Size(44, 18);
            this.lblCarSer.TabIndex = 52;
            this.lblCarSer.Text = "车  系";
            // 
            // txtCarModel
            // 
            // 
            // 
            // 
            this.txtCarModel.Border.Class = "TextBoxBorder";
            this.txtCarModel.Location = new System.Drawing.Point(292, 19);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(119, 21);
            this.txtCarModel.TabIndex = 51;
            this.txtCarModel.Tag = "F1S1";
            // 
            // lblCarModel
            // 
            this.lblCarModel.AutoSize = true;
            this.lblCarModel.Location = new System.Drawing.Point(242, 23);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.Size = new System.Drawing.Size(44, 18);
            this.lblCarModel.TabIndex = 50;
            this.lblCarModel.Text = "车  型";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnQuery,
            this.btnOut});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(826, 25);
            this.toolStrip1.TabIndex = 31;
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSum,
            this.lblOver});
            this.statusStrip1.Location = new System.Drawing.Point(198, 442);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(628, 22);
            this.statusStrip1.TabIndex = 34;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblSum
            // 
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(0, 17);
            // 
            // lblOver
            // 
            this.lblOver.Name = "lblOver";
            this.lblOver.Size = new System.Drawing.Size(0, 17);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Status1
            // 
            this.Status1.DataPropertyName = "Status";
            this.Status1.HeaderText = "状态";
            this.Status1.Name = "Status1";
            // 
            // DetailID
            // 
            this.DetailID.DataPropertyName = "DetailID";
            this.DetailID.HeaderText = "DetailID";
            this.DetailID.Name = "DetailID";
            // 
            // AutoNumber
            // 
            this.AutoNumber.DataPropertyName = "AutoNumber";
            this.AutoNumber.HeaderText = "自编号";
            this.AutoNumber.Name = "AutoNumber";
            // 
            // StockDays
            // 
            this.StockDays.DataPropertyName = "StockDays";
            this.StockDays.HeaderText = "库存天数";
            this.StockDays.Name = "StockDays";
            // 
            // BrandName
            // 
            this.BrandName.DataPropertyName = "BrandName";
            this.BrandName.HeaderText = "品牌";
            this.BrandName.Name = "BrandName";
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
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "颜色";
            this.Color.Name = "Color";
            // 
            // Displacement
            // 
            this.Displacement.DataPropertyName = "Displacement";
            this.Displacement.HeaderText = "排量";
            this.Displacement.Name = "Displacement";
            // 
            // Transmission
            // 
            this.Transmission.DataPropertyName = "Transmission";
            this.Transmission.HeaderText = "变速器";
            this.Transmission.Name = "Transmission";
            // 
            // Vin
            // 
            this.Vin.DataPropertyName = "Vin";
            this.Vin.HeaderText = "Vin";
            this.Vin.Name = "Vin";
            // 
            // CarOfYear
            // 
            this.CarOfYear.DataPropertyName = "CarOfYear";
            this.CarOfYear.HeaderText = "车款年限";
            this.CarOfYear.Name = "CarOfYear";
            // 
            // SalePrice
            // 
            this.SalePrice.DataPropertyName = "SalePrice";
            this.SalePrice.HeaderText = "销售限价";
            this.SalePrice.Name = "SalePrice";
            // 
            // StorePlace
            // 
            this.StorePlace.DataPropertyName = "StorePlace";
            this.StorePlace.HeaderText = "存放位置";
            this.StorePlace.Name = "StorePlace";
            // 
            // ItemIDFrom
            // 
            this.ItemIDFrom.DataPropertyName = "ItemIDFrom";
            this.ItemIDFrom.HeaderText = "ItemIDFrom";
            this.ItemIDFrom.Name = "ItemIDFrom";
            // 
            // Image1
            // 
            this.Image1.DataPropertyName = "Image";
            this.Image1.HeaderText = "Image ";
            this.Image1.Name = "Image1";
            this.Image1.Visible = false;
            // 
            // CarInDate
            // 
            this.CarInDate.DataPropertyName = "CarInDate";
            this.CarInDate.HeaderText = "入库日期";
            this.CarInDate.Name = "CarInDate";
            // 
            // InPrice
            // 
            this.InPrice.DataPropertyName = "InPrice";
            this.InPrice.HeaderText = "进货价";
            this.InPrice.Name = "InPrice";
            // 
            // DirectPrice
            // 
            this.DirectPrice.DataPropertyName = "DirectPrice";
            this.DirectPrice.HeaderText = "指导价";
            this.DirectPrice.Name = "DirectPrice";
            // 
            // frmCarStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 464);
            this.Controls.Add(this.dgCarStock);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmCarStock";
            this.Text = "车辆库存";
            this.Load += new System.EventHandler(this.frmCarStock_Load);
            this.cMenuCarStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCarStock)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.igiDays)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgCarStock;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnQuery;
        private System.Windows.Forms.ContextMenuStrip cMenuCarStock;
        private System.Windows.Forms.ToolStripMenuItem ModifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCarSer;
        private DevComponents.DotNetBar.LabelX lblCarSer;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCarModel;
        private DevComponents.DotNetBar.LabelX lblCarModel;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbColor;
        private DevComponents.DotNetBar.LabelX lblColor;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbDisplacement;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.ComboItem comboItem7;
        private DevComponents.DotNetBar.LabelX lblDisplacement;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbStorePlace;
        private DevComponents.DotNetBar.LabelX lblStorePlace;
        private DevComponents.DotNetBar.Controls.TextBoxX txtVin;
        private DevComponents.DotNetBar.LabelX lblVin;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbStatus;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem5;
        private DevComponents.DotNetBar.LabelX lblStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picCar;
        private DevComponents.DotNetBar.LabelX lblInfo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblSum;
        private DevComponents.Editors.IntegerInput igiDays;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.ToolStripStatusLabel lblOver;
        private System.Windows.Forms.ToolStripButton btnOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutoNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarSer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Displacement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transmission;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vin;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarOfYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn StorePlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemIDFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Image1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarInDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn InPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirectPrice;
    }
}