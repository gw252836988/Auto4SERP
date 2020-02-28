namespace Auto4SErp
{
    partial class frmSupplyUnit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplyUnit));
            this.cMenuUnit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ModifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgUnit = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUnitAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblUnitAddress = new DevComponents.DotNetBar.LabelX();
            this.cmbUnitType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.lblSupplier = new DevComponents.DotNetBar.LabelX();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnQuery = new System.Windows.Forms.ToolStripButton();
            this.tbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.cMenuUnit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUnit)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cMenuUnit
            // 
            this.cMenuUnit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModifyToolStripMenuItem,
            this.DelToolStripMenuItem});
            this.cMenuUnit.Name = "cMenuUnit";
            this.cMenuUnit.Size = new System.Drawing.Size(101, 48);
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
            // dgUnit
            // 
            this.dgUnit.AllowUserToAddRows = false;
            this.dgUnit.AllowUserToDeleteRows = false;
            this.dgUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUnit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.UnitType,
            this.UnitName,
            this.UnitAddress,
            this.PayType});
            this.dgUnit.ContextMenuStrip = this.cMenuUnit;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgUnit.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgUnit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgUnit.Location = new System.Drawing.Point(0, 89);
            this.dgUnit.MultiSelect = false;
            this.dgUnit.Name = "dgUnit";
            this.dgUnit.RowTemplate.Height = 23;
            this.dgUnit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUnit.Size = new System.Drawing.Size(775, 407);
            this.dgUnit.TabIndex = 32;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "编号";
            this.ID.Name = "ID";
            // 
            // UnitType
            // 
            this.UnitType.DataPropertyName = "UnitType";
            this.UnitType.HeaderText = "单位类型";
            this.UnitType.Name = "UnitType";
            // 
            // UnitName
            // 
            this.UnitName.DataPropertyName = "UnitName";
            this.UnitName.HeaderText = "单位名称";
            this.UnitName.Name = "UnitName";
            // 
            // UnitAddress
            // 
            this.UnitAddress.DataPropertyName = "UnitAddress";
            this.UnitAddress.HeaderText = "单位地址";
            this.UnitAddress.Name = "UnitAddress";
            // 
            // PayType
            // 
            this.PayType.DataPropertyName = "PayType";
            this.PayType.HeaderText = "付款方式";
            this.PayType.Name = "PayType";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUnitAddress);
            this.groupBox1.Controls.Add(this.lblUnitAddress);
            this.groupBox1.Controls.Add(this.cmbUnitType);
            this.groupBox1.Controls.Add(this.lblSupplier);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 64);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // txtUnitAddress
            // 
            // 
            // 
            // 
            this.txtUnitAddress.Border.Class = "TextBoxBorder";
            this.txtUnitAddress.Location = new System.Drawing.Point(346, 24);
            this.txtUnitAddress.Name = "txtUnitAddress";
            this.txtUnitAddress.Size = new System.Drawing.Size(134, 21);
            this.txtUnitAddress.TabIndex = 30;
            this.txtUnitAddress.Tag = "F1S1";
            // 
            // lblUnitAddress
            // 
            this.lblUnitAddress.AutoSize = true;
            this.lblUnitAddress.Location = new System.Drawing.Point(284, 26);
            this.lblUnitAddress.Name = "lblUnitAddress";
            this.lblUnitAddress.Size = new System.Drawing.Size(56, 18);
            this.lblUnitAddress.TabIndex = 29;
            this.lblUnitAddress.Text = "单位地址";
            // 
            // cmbUnitType
            // 
            this.cmbUnitType.DisplayMember = "Text";
            this.cmbUnitType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUnitType.FormattingEnabled = true;
            this.cmbUnitType.ItemHeight = 15;
            this.cmbUnitType.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.cmbUnitType.Location = new System.Drawing.Point(110, 24);
            this.cmbUnitType.Name = "cmbUnitType";
            this.cmbUnitType.Size = new System.Drawing.Size(125, 21);
            this.cmbUnitType.TabIndex = 28;
            this.cmbUnitType.Tag = "F1S1B0";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "销售";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "售后";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(48, 27);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(56, 18);
            this.lblSupplier.TabIndex = 27;
            this.lblSupplier.Text = "单位类型";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnQuery,
            this.tbtnAdd});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(775, 25);
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
            // tbtnAdd
            // 
            this.tbtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("tbtnAdd.Image")));
            this.tbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnAdd.Name = "tbtnAdd";
            this.tbtnAdd.Size = new System.Drawing.Size(52, 22);
            this.tbtnAdd.Tag = "add";
            this.tbtnAdd.Text = "增加";
            this.tbtnAdd.Click += new System.EventHandler(this.tbtnAdd_Click);
            // 
            // frmSupplyUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 496);
            this.Controls.Add(this.dgUnit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmSupplyUnit";
            this.Text = "供货单位";
            this.Load += new System.EventHandler(this.frmSupplyUnit_Load);
            this.cMenuUnit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgUnit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgUnit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnQuery;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbUnitType;
        private DevComponents.DotNetBar.LabelX lblSupplier;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUnitAddress;
        private DevComponents.DotNetBar.LabelX lblUnitAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitType;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayType;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private System.Windows.Forms.ToolStripButton tbtnAdd;
        private System.Windows.Forms.ContextMenuStrip cMenuUnit;
        private System.Windows.Forms.ToolStripMenuItem ModifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelToolStripMenuItem;
    }
}