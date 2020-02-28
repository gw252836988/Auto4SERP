namespace Auto4SErp.Personnel
{
    partial class frmOperateMan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOperateMan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.btnPower = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStaffId = new DevComponents.DotNetBar.LabelX();
            this.txtStaffId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtStaffName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblStaffName = new DevComponents.DotNetBar.LabelX();
            this.dgStaff = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSearch,
            this.btnDel,
            this.btnPower,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(738, 25);
            this.toolStrip1.TabIndex = 32;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbSearch
            // 
            this.tsbSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearch.Image")));
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(52, 22);
            this.tsbSearch.Tag = "query";
            this.tsbSearch.Text = "查询";
            this.tsbSearch.Click += new System.EventHandler(this.tsbSearch_Click);
            // 
            // btnDel
            // 
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(52, 22);
            this.btnDel.Tag = "delete";
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnPower
            // 
            this.btnPower.Image = global::Auto4SErp.Properties.Resources.power;
            this.btnPower.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(52, 22);
            this.btnPower.Text = "权限";
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStaffId);
            this.groupBox1.Controls.Add(this.txtStaffId);
            this.groupBox1.Controls.Add(this.txtStaffName);
            this.groupBox1.Controls.Add(this.lblStaffName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 77);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // lblStaffId
            // 
            this.lblStaffId.Location = new System.Drawing.Point(44, 31);
            this.lblStaffId.Name = "lblStaffId";
            this.lblStaffId.Size = new System.Drawing.Size(44, 23);
            this.lblStaffId.TabIndex = 32;
            this.lblStaffId.Text = "工  号";
            // 
            // txtStaffId
            // 
            // 
            // 
            // 
            this.txtStaffId.Border.Class = "TextBoxBorder";
            this.txtStaffId.Location = new System.Drawing.Point(94, 31);
            this.txtStaffId.Name = "txtStaffId";
            this.txtStaffId.Size = new System.Drawing.Size(128, 21);
            this.txtStaffId.TabIndex = 33;
            this.txtStaffId.Tag = "F0S1";
            // 
            // txtStaffName
            // 
            // 
            // 
            // 
            this.txtStaffName.Border.Class = "TextBoxBorder";
            this.txtStaffName.Location = new System.Drawing.Point(298, 31);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(128, 21);
            this.txtStaffName.TabIndex = 35;
            this.txtStaffName.Tag = "F1S1";
            // 
            // lblStaffName
            // 
            this.lblStaffName.Location = new System.Drawing.Point(253, 31);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(48, 23);
            this.lblStaffName.TabIndex = 34;
            this.lblStaffName.Text = "姓  名";
            // 
            // dgStaff
            // 
            this.dgStaff.AllowUserToAddRows = false;
            this.dgStaff.AllowUserToDeleteRows = false;
            this.dgStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgStaff.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgStaff.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgStaff.Location = new System.Drawing.Point(0, 102);
            this.dgStaff.MultiSelect = false;
            this.dgStaff.Name = "dgStaff";
            this.dgStaff.RowTemplate.Height = 23;
            this.dgStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgStaff.Size = new System.Drawing.Size(738, 358);
            this.dgStaff.TabIndex = 40;
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.SelToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(45, 22);
            this.toolStripDropDownButton1.Text = "增加";
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AddToolStripMenuItem.Text = "自定义增加";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // SelToolStripMenuItem
            // 
            this.SelToolStripMenuItem.Name = "SelToolStripMenuItem";
            this.SelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SelToolStripMenuItem.Text = "选择增加";
            this.SelToolStripMenuItem.Click += new System.EventHandler(this.SelToolStripMenuItem_Click);
            // 
            // frmOperateMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 460);
            this.Controls.Add(this.dgStaff);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmOperateMan";
            this.Text = "操作人员管理";
            this.Load += new System.EventHandler(this.frmOperateMan_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.LabelX lblStaffId;
        private DevComponents.DotNetBar.Controls.TextBoxX txtStaffId;
        private DevComponents.DotNetBar.Controls.TextBoxX txtStaffName;
        private DevComponents.DotNetBar.LabelX lblStaffName;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgStaff;
        private System.Windows.Forms.ToolStripButton btnPower;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelToolStripMenuItem;
    }
}