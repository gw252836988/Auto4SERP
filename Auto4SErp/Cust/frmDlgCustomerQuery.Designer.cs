namespace Auto4SErp.Cust
{
    partial class frmDlgCustomerQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDlgCustomerQuery));
            this.txtTelephone = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtIdentityCard = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblIdentityCard = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cmbSex = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnQuery = new System.Windows.Forms.ToolStripButton();
            this.txtMobile = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtBH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCustName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.lblBH = new DevComponents.DotNetBar.LabelX();
            this.lblCustName = new DevComponents.DotNetBar.LabelX();
            this.chbVip = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTelephone
            // 
            // 
            // 
            // 
            this.txtTelephone.Border.Class = "TextBoxBorder";
            this.txtTelephone.Location = new System.Drawing.Point(88, 152);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(108, 21);
            this.txtTelephone.TabIndex = 19;
            this.txtTelephone.Tag = "F1S1";
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            this.labelX4.Location = new System.Drawing.Point(27, 155);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(56, 18);
            this.labelX4.TabIndex = 18;
            this.labelX4.Text = "固定电话";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.Location = new System.Drawing.Point(239, 118);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(50, 18);
            this.labelX3.TabIndex = 17;
            this.labelX3.Text = "地   址";
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.Border.Class = "TextBoxBorder";
            this.txtAddress.Location = new System.Drawing.Point(292, 114);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(115, 23);
            this.txtAddress.TabIndex = 16;
            this.txtAddress.Tag = "F1S1";
            // 
            // txtIdentityCard
            // 
            // 
            // 
            // 
            this.txtIdentityCard.Border.Class = "TextBoxBorder";
            this.txtIdentityCard.Location = new System.Drawing.Point(88, 116);
            this.txtIdentityCard.Name = "txtIdentityCard";
            this.txtIdentityCard.Size = new System.Drawing.Size(108, 21);
            this.txtIdentityCard.TabIndex = 15;
            this.txtIdentityCard.Tag = "F1S1";
            // 
            // lblIdentityCard
            // 
            this.lblIdentityCard.AutoSize = true;
            this.lblIdentityCard.Location = new System.Drawing.Point(26, 116);
            this.lblIdentityCard.Name = "lblIdentityCard";
            this.lblIdentityCard.Size = new System.Drawing.Size(56, 18);
            this.lblIdentityCard.TabIndex = 14;
            this.lblIdentityCard.Text = "身 份 证";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(242, 80);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(44, 18);
            this.labelX2.TabIndex = 8;
            this.labelX2.Text = "性  别";
            // 
            // cmbSex
            // 
            this.cmbSex.DisplayMember = "Text";
            this.cmbSex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.ItemHeight = 15;
            this.cmbSex.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.cmbSex.Location = new System.Drawing.Point(292, 77);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(69, 21);
            this.cmbSex.TabIndex = 7;
            this.cmbSex.Tag = "F0S1B0";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "男";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "女";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnQuery});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(469, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnQuery
            // 
            this.tbtnQuery.Image = ((System.Drawing.Image)(resources.GetObject("tbtnQuery.Image")));
            this.tbtnQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnQuery.Name = "tbtnQuery";
            this.tbtnQuery.Size = new System.Drawing.Size(52, 22);
            this.tbtnQuery.Tag = "ok";
            this.tbtnQuery.Text = "确定";
            this.tbtnQuery.Click += new System.EventHandler(this.tbtnQuery_Click);
            // 
            // txtMobile
            // 
            // 
            // 
            // 
            this.txtMobile.Border.Class = "TextBoxBorder";
            this.txtMobile.Location = new System.Drawing.Point(88, 77);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(108, 21);
            this.txtMobile.TabIndex = 5;
            this.txtMobile.Tag = "F1S1";
            // 
            // txtBH
            // 
            // 
            // 
            // 
            this.txtBH.Border.Class = "TextBoxBorder";
            this.txtBH.Location = new System.Drawing.Point(292, 40);
            this.txtBH.Name = "txtBH";
            this.txtBH.Size = new System.Drawing.Size(115, 21);
            this.txtBH.TabIndex = 4;
            this.txtBH.Tag = "F1S1";
            // 
            // txtCustName
            // 
            // 
            // 
            // 
            this.txtCustName.Border.Class = "TextBoxBorder";
            this.txtCustName.Location = new System.Drawing.Point(88, 41);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(108, 21);
            this.txtCustName.TabIndex = 3;
            this.txtCustName.Tag = "F1S1";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(27, 78);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(56, 18);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "手机号码";
            // 
            // lblBH
            // 
            this.lblBH.AutoSize = true;
            this.lblBH.Location = new System.Drawing.Point(233, 43);
            this.lblBH.Name = "lblBH";
            this.lblBH.Size = new System.Drawing.Size(56, 18);
            this.lblBH.TabIndex = 1;
            this.lblBH.Text = "客户编号";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(27, 44);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(56, 18);
            this.lblCustName.TabIndex = 0;
            this.lblCustName.Text = "客户名称";
            // 
            // chbVip
            // 
            this.chbVip.AutoSize = true;
            this.chbVip.Location = new System.Drawing.Point(413, 42);
            this.chbVip.Name = "chbVip";
            this.chbVip.Size = new System.Drawing.Size(48, 16);
            this.chbVip.TabIndex = 20;
            this.chbVip.Text = "会员";
            this.chbVip.UseVisualStyleBackColor = true;
            // 
            // frmDlgCustomerQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 190);
            this.Controls.Add(this.chbVip);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtIdentityCard);
            this.Controls.Add(this.lblIdentityCard);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.cmbSex);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtBH);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.lblBH);
            this.Controls.Add(this.lblCustName);
            this.Name = "frmDlgCustomerQuery";
            this.Text = "客户查询条件";
            this.Load += new System.EventHandler(this.frmDlgCustomerQuery_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lblCustName;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX lblBH;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCustName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMobile;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBH;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnQuery;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbSex;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtIdentityCard;
        private DevComponents.DotNetBar.LabelX lblIdentityCard;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAddress;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTelephone;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.CheckBox chbVip;
    }
}