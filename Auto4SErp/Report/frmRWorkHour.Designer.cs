﻿namespace Auto4SErp.Report
{
    partial class frmRWorkHour
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
            System.Windows.Forms.PictureBox btnFindItem;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRWorkHour));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnQuery = new System.Windows.Forms.ToolStripButton();
            this.btnOut = new System.Windows.Forms.ToolStripButton();
            this.btnSummary = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbWorkMan = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtItemName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblItemName = new DevComponents.DotNetBar.LabelX();
            this.lblWorkMan = new DevComponents.DotNetBar.LabelX();
            this.txtWHJE = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtTotalHour = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.datBegin = new System.Windows.Forms.DateTimePicker();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.label1 = new System.Windows.Forms.Label();
            this.datEnd = new System.Windows.Forms.DateTimePicker();
            this.dgWorkHour = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dgSummary = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.gworkman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gworkhour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gItemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platenum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpWorkH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnFindItem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(btnFindItem)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgWorkHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFindItem
            // 
            btnFindItem.BackgroundImage = global::Auto4SErp.Properties.Resources.smallquery;
            btnFindItem.Cursor = System.Windows.Forms.Cursors.Hand;
            btnFindItem.Location = new System.Drawing.Point(761, 22);
            btnFindItem.Name = "btnFindItem";
            btnFindItem.Size = new System.Drawing.Size(16, 16);
            btnFindItem.TabIndex = 115;
            btnFindItem.TabStop = false;
            btnFindItem.Click += new System.EventHandler(this.btnFindItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnQuery,
            this.btnOut,
            this.btnSummary});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(854, 25);
            this.toolStrip1.TabIndex = 40;
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
            // btnSummary
            // 
            this.btnSummary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSummary.Image = ((System.Drawing.Image)(resources.GetObject("btnSummary.Image")));
            this.btnSummary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(60, 22);
            this.btnSummary.Text = "分组统计";
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbWorkMan);
            this.groupBox1.Controls.Add(btnFindItem);
            this.groupBox1.Controls.Add(this.txtItemName);
            this.groupBox1.Controls.Add(this.lblItemName);
            this.groupBox1.Controls.Add(this.lblWorkMan);
            this.groupBox1.Controls.Add(this.txtWHJE);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.txtTotalHour);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.datBegin);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.datEnd);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(854, 99);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // cmbWorkMan
            // 
            this.cmbWorkMan.DisplayMember = "Text";
            this.cmbWorkMan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbWorkMan.FormattingEnabled = true;
            this.cmbWorkMan.ItemHeight = 15;
            this.cmbWorkMan.Location = new System.Drawing.Point(435, 22);
            this.cmbWorkMan.Name = "cmbWorkMan";
            this.cmbWorkMan.Size = new System.Drawing.Size(113, 21);
            this.cmbWorkMan.TabIndex = 120;
            // 
            // txtItemName
            // 
            // 
            // 
            // 
            this.txtItemName.Border.Class = "TextBoxBorder";
            this.txtItemName.Location = new System.Drawing.Point(640, 20);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(115, 21);
            this.txtItemName.TabIndex = 36;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(578, 23);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(56, 18);
            this.lblItemName.TabIndex = 35;
            this.lblItemName.Text = "项目名称";
            // 
            // lblWorkMan
            // 
            this.lblWorkMan.AutoSize = true;
            this.lblWorkMan.Location = new System.Drawing.Point(367, 23);
            this.lblWorkMan.Name = "lblWorkMan";
            this.lblWorkMan.Size = new System.Drawing.Size(62, 18);
            this.lblWorkMan.TabIndex = 33;
            this.lblWorkMan.Text = " 作业人员";
            // 
            // txtWHJE
            // 
            // 
            // 
            // 
            this.txtWHJE.Border.Class = "TextBoxBorder";
            this.txtWHJE.Location = new System.Drawing.Point(290, 59);
            this.txtWHJE.Name = "txtWHJE";
            this.txtWHJE.ReadOnly = true;
            this.txtWHJE.Size = new System.Drawing.Size(101, 21);
            this.txtWHJE.TabIndex = 32;
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.Location = new System.Drawing.Point(232, 62);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(56, 18);
            this.labelX3.TabIndex = 31;
            this.labelX3.Text = "总工时费";
            // 
            // txtTotalHour
            // 
            // 
            // 
            // 
            this.txtTotalHour.Border.Class = "TextBoxBorder";
            this.txtTotalHour.Location = new System.Drawing.Point(100, 59);
            this.txtTotalHour.Name = "txtTotalHour";
            this.txtTotalHour.ReadOnly = true;
            this.txtTotalHour.Size = new System.Drawing.Size(100, 21);
            this.txtTotalHour.TabIndex = 30;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(50, 62);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(44, 18);
            this.labelX2.TabIndex = 29;
            this.labelX2.Text = "总工时";
            // 
            // datBegin
            // 
            this.datBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datBegin.Location = new System.Drawing.Point(99, 22);
            this.datBegin.Name = "datBegin";
            this.datBegin.Size = new System.Drawing.Size(108, 21);
            this.datBegin.TabIndex = 28;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(37, 23);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(56, 18);
            this.labelX1.TabIndex = 14;
            this.labelX1.Text = "结算日期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "至";
            // 
            // datEnd
            // 
            this.datEnd.Checked = false;
            this.datEnd.CustomFormat = "";
            this.datEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datEnd.Location = new System.Drawing.Point(236, 22);
            this.datEnd.Name = "datEnd";
            this.datEnd.Size = new System.Drawing.Size(104, 21);
            this.datEnd.TabIndex = 12;
            // 
            // dgWorkHour
            // 
            this.dgWorkHour.AllowUserToAddRows = false;
            this.dgWorkHour.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgWorkHour.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgWorkHour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWorkHour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WorkMan,
            this.DH,
            this.CustName,
            this.platenum,
            this.ItemName,
            this.EmpWorkH,
            this.ItemTotalPrice});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgWorkHour.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgWorkHour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgWorkHour.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgWorkHour.Location = new System.Drawing.Point(355, 124);
            this.dgWorkHour.MultiSelect = false;
            this.dgWorkHour.Name = "dgWorkHour";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgWorkHour.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgWorkHour.RowTemplate.Height = 23;
            this.dgWorkHour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgWorkHour.Size = new System.Drawing.Size(499, 300);
            this.dgWorkHour.TabIndex = 42;
            // 
            // dgSummary
            // 
            this.dgSummary.AllowUserToAddRows = false;
            this.dgSummary.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSummary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gworkman,
            this.gworkhour,
            this.gItemType});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgSummary.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgSummary.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgSummary.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgSummary.Location = new System.Drawing.Point(0, 124);
            this.dgSummary.MultiSelect = false;
            this.dgSummary.Name = "dgSummary";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSummary.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgSummary.RowTemplate.Height = 23;
            this.dgSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSummary.Size = new System.Drawing.Size(355, 300);
            this.dgSummary.TabIndex = 43;
            this.dgSummary.Visible = false;
            // 
            // gworkman
            // 
            this.gworkman.DataPropertyName = "emp";
            this.gworkman.HeaderText = "作业人员";
            this.gworkman.Name = "gworkman";
            // 
            // gworkhour
            // 
            this.gworkhour.DataPropertyName = "gworkhour";
            this.gworkhour.HeaderText = "总工时";
            this.gworkhour.Name = "gworkhour";
            // 
            // gItemType
            // 
            this.gItemType.DataPropertyName = "gItemType";
            this.gItemType.HeaderText = "项目类型";
            this.gItemType.Name = "gItemType";
            // 
            // WorkMan
            // 
            this.WorkMan.DataPropertyName = "WorkMan";
            this.WorkMan.HeaderText = "作业人员";
            this.WorkMan.Name = "WorkMan";
            // 
            // DH
            // 
            this.DH.DataPropertyName = "DH";
            this.DH.HeaderText = "单号";
            this.DH.Name = "DH";
            // 
            // CustName
            // 
            this.CustName.DataPropertyName = "CustName";
            this.CustName.HeaderText = "顾客姓名";
            this.CustName.Name = "CustName";
            // 
            // platenum
            // 
            this.platenum.DataPropertyName = "platenum";
            this.platenum.HeaderText = "车牌号";
            this.platenum.Name = "platenum";
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "项目名称";
            this.ItemName.Name = "ItemName";
            // 
            // EmpWorkH
            // 
            this.EmpWorkH.DataPropertyName = "EmpWorkH";
            this.EmpWorkH.HeaderText = "工时";
            this.EmpWorkH.Name = "EmpWorkH";
            // 
            // ItemTotalPrice
            // 
            this.ItemTotalPrice.DataPropertyName = "ItemTotalPrice";
            this.ItemTotalPrice.HeaderText = "工时费";
            this.ItemTotalPrice.Name = "ItemTotalPrice";
            // 
            // frmRWorkHour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 424);
            this.Controls.Add(this.dgWorkHour);
            this.Controls.Add(this.dgSummary);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmRWorkHour";
            this.Text = "维修工时统计";
            this.Load += new System.EventHandler(this.frmRWorkHour_Load);
            ((System.ComponentModel.ISupportInitialize)(btnFindItem)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgWorkHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSummary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnQuery;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker datBegin;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datEnd;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgWorkHour;
        private DevComponents.DotNetBar.Controls.TextBoxX txtWHJE;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTotalHour;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX lblWorkMan;
        private DevComponents.DotNetBar.Controls.TextBoxX txtItemName;
        private DevComponents.DotNetBar.LabelX lblItemName;
        private System.Windows.Forms.ToolStripButton btnOut;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbWorkMan;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgSummary;
        private System.Windows.Forms.ToolStripButton btnSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn gworkman;
        private System.Windows.Forms.DataGridViewTextBoxColumn gworkhour;
        private System.Windows.Forms.DataGridViewTextBoxColumn gItemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn platenum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpWorkH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemTotalPrice;
    }
}