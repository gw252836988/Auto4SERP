﻿namespace Auto4SErp.Sale
{
    partial class frmCarDoc_R
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarDoc_R));
            this.cmenuCarDoc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifytoolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.DeltoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmenuCarDetail = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeCarDoc = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.dgCarDetails = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutoNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirectPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transmission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Displacement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InnerStyle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarOfYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnAllDetails = new System.Windows.Forms.ToolStripButton();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtDirectPrice = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.AddCarBrandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCarSerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCarDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCarSer = new System.Windows.Forms.ToolStripButton();
            this.btnCarModel = new System.Windows.Forms.ToolStripButton();
            this.btnCarDetailIn = new System.Windows.Forms.ToolStripButton();
            this.cmenuCarDoc.SuspendLayout();
            this.cmenuCarDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeCarDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCarDetails)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmenuCarDoc
            // 
            this.cmenuCarDoc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDetailToolStripMenuItem,
            this.ModifytoolStripMenuItem2,
            this.DeltoolStripMenuItem1});
            this.cmenuCarDoc.Name = "contextMenuStrip1";
            this.cmenuCarDoc.Size = new System.Drawing.Size(125, 70);
            this.cmenuCarDoc.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmenuCarDoc_ItemClicked);
            // 
            // addDetailToolStripMenuItem
            // 
            this.addDetailToolStripMenuItem.Name = "addDetailToolStripMenuItem";
            this.addDetailToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.addDetailToolStripMenuItem.Text = "增加车型";
            // 
            // ModifytoolStripMenuItem2
            // 
            this.ModifytoolStripMenuItem2.Enabled = false;
            this.ModifytoolStripMenuItem2.Name = "ModifytoolStripMenuItem2";
            this.ModifytoolStripMenuItem2.Size = new System.Drawing.Size(124, 22);
            this.ModifytoolStripMenuItem2.Text = "修改";
            this.ModifytoolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // DeltoolStripMenuItem1
            // 
            this.DeltoolStripMenuItem1.Enabled = false;
            this.DeltoolStripMenuItem1.Name = "DeltoolStripMenuItem1";
            this.DeltoolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.DeltoolStripMenuItem1.Text = "删除";
            // 
            // cmenuCarDetail
            // 
            this.cmenuCarDetail.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改ToolStripMenuItem,
            this.删除ToolStripMenuItem});
            this.cmenuCarDetail.Name = "cmenuCarDetail";
            this.cmenuCarDetail.Size = new System.Drawing.Size(101, 48);
            this.cmenuCarDetail.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmenuCarDetail_ItemClicked);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.修改ToolStripMenuItem.Text = "修改";
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.修改ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeCarDoc);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgCarDetails);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip2);
            this.splitContainer1.Size = new System.Drawing.Size(828, 454);
            this.splitContainer1.SplitterDistance = 227;
            this.splitContainer1.TabIndex = 27;
            // 
            // treeCarDoc
            // 
            this.treeCarDoc.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.treeCarDoc.AllowDrop = true;
            this.treeCarDoc.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.treeCarDoc.BackgroundStyle.Class = "TreeBorderKey";
            this.treeCarDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeCarDoc.DragDropEnabled = false;
            this.treeCarDoc.Location = new System.Drawing.Point(0, 0);
            this.treeCarDoc.Name = "treeCarDoc";
            this.treeCarDoc.NodesConnector = this.nodeConnector1;
            this.treeCarDoc.NodeStyle = this.elementStyle1;
            this.treeCarDoc.PathSeparator = ";";
            this.treeCarDoc.Size = new System.Drawing.Size(227, 454);
            this.treeCarDoc.Styles.Add(this.elementStyle1);
            this.treeCarDoc.TabIndex = 25;
            this.treeCarDoc.Text = "advTree1";
            this.treeCarDoc.AfterCollapse += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.treeCarDoc_AfterCollapse);
            this.treeCarDoc.AfterExpand += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.treeCarDoc_AfterExpand);
            this.treeCarDoc.NodeClick += new DevComponents.AdvTree.TreeNodeMouseEventHandler(this.treeCarDoc_NodeClick);
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle1
            // 
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // dgCarDetails
            // 
            this.dgCarDetails.AllowUserToAddRows = false;
            this.dgCarDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCarDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCarDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCarDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.modelname,
            this.AutoNumber,
            this.DirectPrice,
            this.SalePrice,
            this.Color,
            this.Transmission,
            this.Displacement,
            this.InnerStyle,
            this.CarOfYear,
            this.model});
            this.dgCarDetails.ContextMenuStrip = this.cmenuCarDetail;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCarDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgCarDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCarDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgCarDetails.Location = new System.Drawing.Point(0, 25);
            this.dgCarDetails.MultiSelect = false;
            this.dgCarDetails.Name = "dgCarDetails";
            this.dgCarDetails.ReadOnly = true;
            this.dgCarDetails.RowHeadersVisible = false;
            this.dgCarDetails.RowTemplate.Height = 23;
            this.dgCarDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCarDetails.Size = new System.Drawing.Size(597, 429);
            this.dgCarDetails.TabIndex = 26;
            this.dgCarDetails.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCarDetails_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // modelname
            // 
            this.modelname.DataPropertyName = "carmodelname";
            this.modelname.HeaderText = "车型";
            this.modelname.Name = "modelname";
            this.modelname.ReadOnly = true;
            // 
            // AutoNumber
            // 
            this.AutoNumber.DataPropertyName = "AutoNumber";
            this.AutoNumber.HeaderText = "自编号";
            this.AutoNumber.Name = "AutoNumber";
            this.AutoNumber.ReadOnly = true;
            // 
            // DirectPrice
            // 
            this.DirectPrice.DataPropertyName = "DirectPrice";
            this.DirectPrice.HeaderText = "指导价";
            this.DirectPrice.Name = "DirectPrice";
            this.DirectPrice.ReadOnly = true;
            // 
            // SalePrice
            // 
            this.SalePrice.DataPropertyName = "SalePrice";
            this.SalePrice.HeaderText = "销售限价";
            this.SalePrice.Name = "SalePrice";
            this.SalePrice.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "颜色";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // Transmission
            // 
            this.Transmission.DataPropertyName = "Transmission";
            this.Transmission.HeaderText = "变速器";
            this.Transmission.Name = "Transmission";
            this.Transmission.ReadOnly = true;
            // 
            // Displacement
            // 
            this.Displacement.DataPropertyName = "Displacement";
            this.Displacement.HeaderText = "排气量";
            this.Displacement.Name = "Displacement";
            this.Displacement.ReadOnly = true;
            // 
            // InnerStyle
            // 
            this.InnerStyle.DataPropertyName = "InnerStyle";
            this.InnerStyle.HeaderText = "内饰风格";
            this.InnerStyle.Name = "InnerStyle";
            this.InnerStyle.ReadOnly = true;
            // 
            // CarOfYear
            // 
            this.CarOfYear.DataPropertyName = "CarOfYear";
            this.CarOfYear.HeaderText = "车款年份";
            this.CarOfYear.Name = "CarOfYear";
            this.CarOfYear.ReadOnly = true;
            // 
            // model
            // 
            this.model.DataPropertyName = "carmodel";
            this.model.HeaderText = "cx";
            this.model.Name = "model";
            this.model.ReadOnly = true;
            this.model.Visible = false;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAllDetails,
            this.btnQuery,
            this.toolStripLabel1,
            this.txtDirectPrice});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(597, 25);
            this.toolStrip2.TabIndex = 30;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnAllDetails
            // 
            this.btnAllDetails.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAllDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnAllDetails.Image")));
            this.btnAllDetails.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAllDetails.Name = "btnAllDetails";
            this.btnAllDetails.Size = new System.Drawing.Size(60, 22);
            this.btnAllDetails.Text = "显示全部";
            this.btnAllDetails.Click += new System.EventHandler(this.btnAllDetails_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Image = global::Auto4SErp.Properties.Resources.query;
            this.btnQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(52, 22);
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(44, 22);
            this.toolStripLabel1.Text = "指导价";
            // 
            // txtDirectPrice
            // 
            this.txtDirectPrice.Name = "txtDirectPrice";
            this.txtDirectPrice.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.btnCarSer,
            this.btnCarModel,
            this.btnCarDetailIn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(828, 25);
            this.toolStrip1.TabIndex = 29;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddCarBrandToolStripMenuItem,
            this.AddCarSerToolStripMenuItem,
            this.AddModelToolStripMenuItem,
            this.AddCarDetailToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(61, 22);
            this.toolStripDropDownButton1.Tag = "add";
            this.toolStripDropDownButton1.Text = "增加";
            // 
            // AddCarBrandToolStripMenuItem
            // 
            this.AddCarBrandToolStripMenuItem.Enabled = false;
            this.AddCarBrandToolStripMenuItem.Name = "AddCarBrandToolStripMenuItem";
            this.AddCarBrandToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.AddCarBrandToolStripMenuItem.Text = "增加品牌";
            this.AddCarBrandToolStripMenuItem.Click += new System.EventHandler(this.AddCarBrandToolStripMenuItem_Click_1);
            // 
            // AddCarSerToolStripMenuItem
            // 
            this.AddCarSerToolStripMenuItem.Enabled = false;
            this.AddCarSerToolStripMenuItem.Name = "AddCarSerToolStripMenuItem";
            this.AddCarSerToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.AddCarSerToolStripMenuItem.Text = "增加车系";
            this.AddCarSerToolStripMenuItem.Click += new System.EventHandler(this.AddCarSerToolStripMenuItem_Click_1);
            // 
            // AddModelToolStripMenuItem
            // 
            this.AddModelToolStripMenuItem.Enabled = false;
            this.AddModelToolStripMenuItem.Name = "AddModelToolStripMenuItem";
            this.AddModelToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.AddModelToolStripMenuItem.Text = "增加车型";
            this.AddModelToolStripMenuItem.Click += new System.EventHandler(this.AddModelToolStripMenuItem_Click_1);
            // 
            // AddCarDetailToolStripMenuItem
            // 
            this.AddCarDetailToolStripMenuItem.Name = "AddCarDetailToolStripMenuItem";
            this.AddCarDetailToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.AddCarDetailToolStripMenuItem.Text = "增加车辆资料";
            this.AddCarDetailToolStripMenuItem.Click += new System.EventHandler(this.AddCarDetailToolStripMenuItem_Click_1);
            // 
            // btnCarSer
            // 
            this.btnCarSer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCarSer.Image = ((System.Drawing.Image)(resources.GetObject("btnCarSer.Image")));
            this.btnCarSer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCarSer.Name = "btnCarSer";
            this.btnCarSer.Size = new System.Drawing.Size(60, 22);
            this.btnCarSer.Text = "导入车系";
            this.btnCarSer.Click += new System.EventHandler(this.btnCarSer_Click);
            // 
            // btnCarModel
            // 
            this.btnCarModel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCarModel.Image = ((System.Drawing.Image)(resources.GetObject("btnCarModel.Image")));
            this.btnCarModel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCarModel.Name = "btnCarModel";
            this.btnCarModel.Size = new System.Drawing.Size(60, 22);
            this.btnCarModel.Text = "导入车型";
            this.btnCarModel.Click += new System.EventHandler(this.btnCarModel_Click);
            // 
            // btnCarDetailIn
            // 
            this.btnCarDetailIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCarDetailIn.Image = ((System.Drawing.Image)(resources.GetObject("btnCarDetailIn.Image")));
            this.btnCarDetailIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCarDetailIn.Name = "btnCarDetailIn";
            this.btnCarDetailIn.Size = new System.Drawing.Size(84, 22);
            this.btnCarDetailIn.Text = "导入车辆资料";
            this.btnCarDetailIn.Click += new System.EventHandler(this.btnCarDetailIn_Click);
            // 
            // frmCarDoc_R
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 479);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmCarDoc_R";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "车辆资料定义";
            this.Load += new System.EventHandler(this.frmCarDoc_Load);
            this.cmenuCarDoc.ResumeLayout(false);
            this.cmenuCarDetail.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeCarDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCarDetails)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cmenuCarDoc;
        private System.Windows.Forms.ToolStripMenuItem DeltoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ModifytoolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip cmenuCarDetail;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private DevComponents.AdvTree.AdvTree treeCarDoc;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgCarDetails;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem AddCarBrandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddCarSerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddCarDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnAllDetails;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtDirectPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelname;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutoNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirectPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transmission;
        private System.Windows.Forms.DataGridViewTextBoxColumn Displacement;
        private System.Windows.Forms.DataGridViewTextBoxColumn InnerStyle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarOfYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.ToolStripMenuItem addDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnCarSer;
        private System.Windows.Forms.ToolStripButton btnCarModel;
        private System.Windows.Forms.ToolStripButton btnCarDetailIn;
    }
}