﻿namespace Auto4SErp.Repair
{
    partial class frmDlgClaimBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDlgClaimBill));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddBill = new System.Windows.Forms.ToolStripButton();
            this.btnSelect = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.btnPost = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.btnOut = new System.Windows.Forms.ToolStripButton();
            this.txtDH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblDH = new DevComponents.DotNetBar.LabelX();
            this.dbiAllAmount = new DevComponents.Editors.DoubleInput();
            this.lblAllAmount = new DevComponents.DotNetBar.LabelX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgClaim = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.chbSel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClaimDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlateNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElseAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClaimAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmenuRepair = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbiAllAmount)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClaim)).BeginInit();
            this.cmenuRepair.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddBill,
            this.btnSelect,
            this.btnDel,
            this.btnPost,
            this.btnCancel,
            this.btnOut});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(845, 25);
            this.toolStrip1.TabIndex = 135;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddBill
            // 
            this.btnAddBill.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBill.Image")));
            this.btnAddBill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(52, 22);
            this.btnAddBill.Tag = "add";
            this.btnAddBill.Text = "开票";
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSelect.Enabled = false;
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(60, 22);
            this.btnSelect.Text = "添加索赔";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnDel
            // 
            this.btnDel.Enabled = false;
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(76, 22);
            this.btnDel.Tag = "delete";
            this.btnDel.Text = "删除索赔";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnPost
            // 
            this.btnPost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPost.Image = ((System.Drawing.Image)(resources.GetObject("btnPost.Image")));
            this.btnPost.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(60, 22);
            this.btnPost.Text = "提交收款";
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 22);
            this.btnCancel.Text = "放弃收款";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            // txtDH
            // 
            // 
            // 
            // 
            this.txtDH.Border.Class = "TextBoxBorder";
            this.txtDH.Location = new System.Drawing.Point(97, 30);
            this.txtDH.Name = "txtDH";
            this.txtDH.ReadOnly = true;
            this.txtDH.Size = new System.Drawing.Size(119, 21);
            this.txtDH.TabIndex = 137;
            this.txtDH.Tag = "F1S1";
            // 
            // lblDH
            // 
            this.lblDH.AutoSize = true;
            this.lblDH.Location = new System.Drawing.Point(47, 33);
            this.lblDH.Name = "lblDH";
            this.lblDH.Size = new System.Drawing.Size(44, 18);
            this.lblDH.TabIndex = 136;
            this.lblDH.Text = "发票号";
            // 
            // dbiAllAmount
            // 
            // 
            // 
            // 
            this.dbiAllAmount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dbiAllAmount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.dbiAllAmount.Increment = 1D;
            this.dbiAllAmount.Location = new System.Drawing.Point(314, 30);
            this.dbiAllAmount.Name = "dbiAllAmount";
            this.dbiAllAmount.ShowUpDown = true;
            this.dbiAllAmount.Size = new System.Drawing.Size(126, 21);
            this.dbiAllAmount.TabIndex = 139;
            // 
            // lblAllAmount
            // 
            this.lblAllAmount.AutoSize = true;
            this.lblAllAmount.Location = new System.Drawing.Point(264, 33);
            this.lblAllAmount.Name = "lblAllAmount";
            this.lblAllAmount.Size = new System.Drawing.Size(44, 18);
            this.lblAllAmount.TabIndex = 138;
            this.lblAllAmount.Text = "总金额";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dbiAllAmount);
            this.groupBox1.Controls.Add(this.lblDH);
            this.groupBox1.Controls.Add(this.lblAllAmount);
            this.groupBox1.Controls.Add(this.txtDH);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 79);
            this.groupBox1.TabIndex = 140;
            this.groupBox1.TabStop = false;
            // 
            // dgClaim
            // 
            this.dgClaim.AllowUserToAddRows = false;
            this.dgClaim.AllowUserToDeleteRows = false;
            this.dgClaim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClaim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chbSel,
            this.ID,
            this.cstatus,
            this.RepDH,
            this.ClaimDH,
            this.AccountDate,
            this.AccessAmount,
            this.CustName,
            this.PlateNum,
            this.Vin,
            this.accAmount,
            this.ItemAmount,
            this.ElseAmount,
            this.ClaimAmount,
            this.PostMan});
            this.dgClaim.ContextMenuStrip = this.cmenuRepair;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgClaim.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgClaim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgClaim.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgClaim.Location = new System.Drawing.Point(0, 104);
            this.dgClaim.Name = "dgClaim";
            this.dgClaim.RowTemplate.Height = 23;
            this.dgClaim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgClaim.Size = new System.Drawing.Size(845, 347);
            this.dgClaim.TabIndex = 141;
            this.dgClaim.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgClaim_RowPostPaint);
            // 
            // chbSel
            // 
            this.chbSel.HeaderText = "";
            this.chbSel.Name = "chbSel";
            this.chbSel.Visible = false;
            this.chbSel.Width = 50;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "iD";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // cstatus
            // 
            this.cstatus.DataPropertyName = "cstatus";
            this.cstatus.HeaderText = "状态";
            this.cstatus.Name = "cstatus";
            this.cstatus.Visible = false;
            // 
            // RepDH
            // 
            this.RepDH.DataPropertyName = "RepDH";
            this.RepDH.HeaderText = "维修单号";
            this.RepDH.Name = "RepDH";
            // 
            // ClaimDH
            // 
            this.ClaimDH.DataPropertyName = "ClaimDH";
            this.ClaimDH.HeaderText = "厂家索赔单号";
            this.ClaimDH.Name = "ClaimDH";
            // 
            // AccountDate
            // 
            this.AccountDate.DataPropertyName = "AccountDate";
            this.AccountDate.HeaderText = "结算时间";
            this.AccountDate.Name = "AccountDate";
            // 
            // AccessAmount
            // 
            this.AccessAmount.DataPropertyName = "AccessAmount";
            this.AccessAmount.HeaderText = "通过金额";
            this.AccessAmount.Name = "AccessAmount";
            // 
            // CustName
            // 
            this.CustName.DataPropertyName = "CustName";
            this.CustName.HeaderText = "客户名称";
            this.CustName.Name = "CustName";
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
            // accAmount
            // 
            this.accAmount.DataPropertyName = "accAmount";
            this.accAmount.HeaderText = "配件金额";
            this.accAmount.Name = "accAmount";
            // 
            // ItemAmount
            // 
            this.ItemAmount.DataPropertyName = "ItemAmount";
            this.ItemAmount.HeaderText = "项目金额";
            this.ItemAmount.Name = "ItemAmount";
            // 
            // ElseAmount
            // 
            this.ElseAmount.DataPropertyName = "ElseAmount";
            this.ElseAmount.HeaderText = "其它金额";
            this.ElseAmount.Name = "ElseAmount";
            // 
            // ClaimAmount
            // 
            this.ClaimAmount.DataPropertyName = "ClaimAmount";
            this.ClaimAmount.HeaderText = "索赔金额";
            this.ClaimAmount.Name = "ClaimAmount";
            // 
            // PostMan
            // 
            this.PostMan.DataPropertyName = "PostMan";
            this.PostMan.HeaderText = "申报人";
            this.PostMan.Name = "PostMan";
            // 
            // cmenuRepair
            // 
            this.cmenuRepair.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DelToolStripMenuItem});
            this.cmenuRepair.Name = "cmenuCarDetail";
            this.cmenuRepair.Size = new System.Drawing.Size(101, 26);
            // 
            // DelToolStripMenuItem
            // 
            this.DelToolStripMenuItem.Name = "DelToolStripMenuItem";
            this.DelToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.DelToolStripMenuItem.Text = "删除";
            this.DelToolStripMenuItem.Click += new System.EventHandler(this.DelToolStripMenuItem_Click);
            // 
            // frmDlgClaimBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 451);
            this.Controls.Add(this.dgClaim);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmDlgClaimBill";
            this.Text = "开票编辑";
            this.Load += new System.EventHandler(this.frmDlgClaimBill_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbiAllAmount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClaim)).EndInit();
            this.cmenuRepair.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddBill;
        private System.Windows.Forms.ToolStripButton btnSelect;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDH;
        private DevComponents.DotNetBar.LabelX lblDH;
        private DevComponents.Editors.DoubleInput dbiAllAmount;
        private DevComponents.DotNetBar.LabelX lblAllAmount;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgClaim;
        private System.Windows.Forms.ContextMenuStrip cmenuRepair;
        private System.Windows.Forms.ToolStripMenuItem DelToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnPost;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chbSel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaimDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlateNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vin;
        private System.Windows.Forms.DataGridViewTextBoxColumn accAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElseAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaimAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostMan;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripButton btnOut;
    }
}