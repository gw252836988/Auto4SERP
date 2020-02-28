namespace Auto4SErp.Repair
{
    partial class frmDlgRepRecept
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
            DevComponents.DotNetBar.LabelX lblStatus;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDlgRepRecept));
            this.txtPlateNum = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblPlateNum = new DevComponents.DotNetBar.LabelX();
            this.cmbStatus = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOK = new System.Windows.Forms.ToolStripButton();
            this.txtDH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblDH = new DevComponents.DotNetBar.LabelX();
            this.txtCustName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCustName = new DevComponents.DotNetBar.LabelX();
            lblStatus = new DevComponents.DotNetBar.LabelX();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new System.Drawing.Point(31, 85);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(56, 18);
            lblStatus.TabIndex = 41;
            lblStatus.Text = "工单状态";
            // 
            // txtPlateNum
            // 
            // 
            // 
            // 
            this.txtPlateNum.Border.Class = "TextBoxBorder";
            this.txtPlateNum.Location = new System.Drawing.Point(267, 43);
            this.txtPlateNum.Name = "txtPlateNum";
            this.txtPlateNum.Size = new System.Drawing.Size(127, 21);
            this.txtPlateNum.TabIndex = 44;
            this.txtPlateNum.Tag = "F1S1";
            // 
            // lblPlateNum
            // 
            this.lblPlateNum.AutoSize = true;
            this.lblPlateNum.Location = new System.Drawing.Point(217, 46);
            this.lblPlateNum.Name = "lblPlateNum";
            this.lblPlateNum.Size = new System.Drawing.Size(44, 18);
            this.lblPlateNum.TabIndex = 43;
            this.lblPlateNum.Text = "车牌号";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DisplayMember = "Text";
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.ItemHeight = 15;
            this.cmbStatus.Items.AddRange(new object[] {
            this.comboItem2,
            this.comboItem3,
            this.comboItem4,
            this.comboItem5});
            this.cmbStatus.Location = new System.Drawing.Point(93, 82);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(114, 21);
            this.cmbStatus.TabIndex = 42;
            this.cmbStatus.Tag = "F0S0B1";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "开单";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "作业中";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "预结算";
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "已结算";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOK});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(432, 25);
            this.toolStrip1.TabIndex = 40;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnOK
            // 
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(52, 22);
            this.btnOK.Tag = "ok";
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtDH
            // 
            // 
            // 
            // 
            this.txtDH.Border.Class = "TextBoxBorder";
            this.txtDH.Location = new System.Drawing.Point(267, 82);
            this.txtDH.Name = "txtDH";
            this.txtDH.Size = new System.Drawing.Size(127, 21);
            this.txtDH.TabIndex = 37;
            this.txtDH.Tag = "F1S1";
            // 
            // lblDH
            // 
            this.lblDH.AutoSize = true;
            this.lblDH.Location = new System.Drawing.Point(230, 85);
            this.lblDH.Name = "lblDH";
            this.lblDH.Size = new System.Drawing.Size(31, 18);
            this.lblDH.TabIndex = 36;
            this.lblDH.Text = "单号";
            // 
            // txtCustName
            // 
            // 
            // 
            // 
            this.txtCustName.Border.Class = "TextBoxBorder";
            this.txtCustName.Location = new System.Drawing.Point(93, 43);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(114, 21);
            this.txtCustName.TabIndex = 35;
            this.txtCustName.Tag = "F1S1";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(31, 46);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(56, 18);
            this.lblCustName.TabIndex = 34;
            this.lblCustName.Text = "客户名字";
            // 
            // frmDlgRepRecept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 123);
            this.Controls.Add(this.txtPlateNum);
            this.Controls.Add(this.lblPlateNum);
            this.Controls.Add(lblStatus);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtDH);
            this.Controls.Add(this.lblDH);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.lblCustName);
            this.Name = "frmDlgRepRecept";
            this.Text = "维修接车查询";
            this.Load += new System.EventHandler(this.frmDlgRepRecept_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtCustName;
        private DevComponents.DotNetBar.LabelX lblCustName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDH;
        private DevComponents.DotNetBar.LabelX lblDH;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnOK;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbStatus;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPlateNum;
        private DevComponents.DotNetBar.LabelX lblPlateNum;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.ComboItem comboItem5;
    }
}