namespace Auto4SErp.Personnel
{
    partial class frmAddOperateMan
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
            System.Windows.Forms.PictureBox btnDepartmentFind;
            System.Windows.Forms.PictureBox btnPositionFind;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddOperateMan));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.lblStaffId = new DevComponents.DotNetBar.LabelX();
            this.txtStaffId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtStaffName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblStaffName = new DevComponents.DotNetBar.LabelX();
            this.txtPositionName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDepartmentName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblDepartmentID = new DevComponents.DotNetBar.LabelX();
            this.lblPositionID = new DevComponents.DotNetBar.LabelX();
            btnDepartmentFind = new System.Windows.Forms.PictureBox();
            btnPositionFind = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(btnDepartmentFind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(btnPositionFind)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDepartmentFind
            // 
            btnDepartmentFind.BackgroundImage = global::Auto4SErp.Properties.Resources.smallquery;
            btnDepartmentFind.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDepartmentFind.Location = new System.Drawing.Point(227, 124);
            btnDepartmentFind.Name = "btnDepartmentFind";
            btnDepartmentFind.Size = new System.Drawing.Size(16, 16);
            btnDepartmentFind.TabIndex = 46;
            btnDepartmentFind.TabStop = false;
            btnDepartmentFind.Click += new System.EventHandler(this.btnDepartmentFind_Click);
            // 
            // btnPositionFind
            // 
            btnPositionFind.BackgroundImage = global::Auto4SErp.Properties.Resources.smallquery;
            btnPositionFind.Cursor = System.Windows.Forms.Cursors.Hand;
            btnPositionFind.Location = new System.Drawing.Point(227, 167);
            btnPositionFind.Name = "btnPositionFind";
            btnPositionFind.Size = new System.Drawing.Size(16, 16);
            btnPositionFind.TabIndex = 47;
            btnPositionFind.TabStop = false;
            btnPositionFind.Click += new System.EventHandler(this.btnPositionFind_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(255, 25);
            this.toolStrip1.TabIndex = 33;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(52, 22);
            this.tsbAdd.Tag = "save";
            this.tsbAdd.Text = "保存";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // lblStaffId
            // 
            this.lblStaffId.Location = new System.Drawing.Point(31, 47);
            this.lblStaffId.Name = "lblStaffId";
            this.lblStaffId.Size = new System.Drawing.Size(46, 23);
            this.lblStaffId.TabIndex = 36;
            this.lblStaffId.Text = "工  号";
            // 
            // txtStaffId
            // 
            // 
            // 
            // 
            this.txtStaffId.Border.Class = "TextBoxBorder";
            this.txtStaffId.Location = new System.Drawing.Point(83, 47);
            this.txtStaffId.Name = "txtStaffId";
            this.txtStaffId.Size = new System.Drawing.Size(128, 21);
            this.txtStaffId.TabIndex = 37;
            this.txtStaffId.Tag = "N";
            // 
            // txtStaffName
            // 
            // 
            // 
            // 
            this.txtStaffName.Border.Class = "TextBoxBorder";
            this.txtStaffName.Location = new System.Drawing.Point(83, 84);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(126, 21);
            this.txtStaffName.TabIndex = 39;
            this.txtStaffName.Tag = "N";
            // 
            // lblStaffName
            // 
            this.lblStaffName.Location = new System.Drawing.Point(31, 84);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(46, 23);
            this.lblStaffName.TabIndex = 38;
            this.lblStaffName.Text = "姓  名";
            // 
            // txtPositionName
            // 
            // 
            // 
            // 
            this.txtPositionName.Border.Class = "TextBoxBorder";
            this.txtPositionName.Location = new System.Drawing.Point(83, 164);
            this.txtPositionName.Name = "txtPositionName";
            this.txtPositionName.ReadOnly = true;
            this.txtPositionName.Size = new System.Drawing.Size(128, 21);
            this.txtPositionName.TabIndex = 45;
            this.txtPositionName.Tag = "N";
            // 
            // txtDepartmentName
            // 
            // 
            // 
            // 
            this.txtDepartmentName.Border.Class = "TextBoxBorder";
            this.txtDepartmentName.Location = new System.Drawing.Point(83, 124);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.ReadOnly = true;
            this.txtDepartmentName.Size = new System.Drawing.Size(126, 21);
            this.txtDepartmentName.TabIndex = 43;
            this.txtDepartmentName.Tag = "N";
            // 
            // lblDepartmentID
            // 
            this.lblDepartmentID.Location = new System.Drawing.Point(31, 124);
            this.lblDepartmentID.Name = "lblDepartmentID";
            this.lblDepartmentID.Size = new System.Drawing.Size(46, 23);
            this.lblDepartmentID.TabIndex = 42;
            this.lblDepartmentID.Text = "部  门";
            // 
            // lblPositionID
            // 
            this.lblPositionID.AutoSize = true;
            this.lblPositionID.Location = new System.Drawing.Point(33, 167);
            this.lblPositionID.Name = "lblPositionID";
            this.lblPositionID.Size = new System.Drawing.Size(44, 18);
            this.lblPositionID.TabIndex = 44;
            this.lblPositionID.Text = "职  位";
            // 
            // frmAddOperateMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 210);
            this.Controls.Add(btnPositionFind);
            this.Controls.Add(btnDepartmentFind);
            this.Controls.Add(this.txtPositionName);
            this.Controls.Add(this.txtDepartmentName);
            this.Controls.Add(this.lblDepartmentID);
            this.Controls.Add(this.lblPositionID);
            this.Controls.Add(this.lblStaffId);
            this.Controls.Add(this.txtStaffId);
            this.Controls.Add(this.txtStaffName);
            this.Controls.Add(this.lblStaffName);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmAddOperateMan";
            this.Text = "添加操作人员";
            this.Load += new System.EventHandler(this.frmAddOperateMan_Load);
            ((System.ComponentModel.ISupportInitialize)(btnDepartmentFind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(btnPositionFind)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private DevComponents.DotNetBar.LabelX lblStaffId;
        private DevComponents.DotNetBar.Controls.TextBoxX txtStaffId;
        private DevComponents.DotNetBar.Controls.TextBoxX txtStaffName;
        private DevComponents.DotNetBar.LabelX lblStaffName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPositionName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDepartmentName;
        private DevComponents.DotNetBar.LabelX lblDepartmentID;
        private DevComponents.DotNetBar.LabelX lblPositionID;
    }
}