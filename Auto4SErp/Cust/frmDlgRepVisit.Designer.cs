namespace Auto4SErp.Cust
{
    partial class frmDlgRepVisit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDlgRepVisit));
            this.txtVisitRemark = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblVisitRemark = new DevComponents.DotNetBar.LabelX();
            this.cmbVisitResult = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem9 = new DevComponents.Editors.ComboItem();
            this.comboItem10 = new DevComponents.Editors.ComboItem();
            this.comboItem11 = new DevComponents.Editors.ComboItem();
            this.comboItem12 = new DevComponents.Editors.ComboItem();
            this.comboItem14 = new DevComponents.Editors.ComboItem();
            this.comboItem15 = new DevComponents.Editors.ComboItem();
            this.comboItem16 = new DevComponents.Editors.ComboItem();
            this.comboItem17 = new DevComponents.Editors.ComboItem();
            this.lblVisitResult = new DevComponents.DotNetBar.LabelX();
            this.txtCarModel = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCarModel = new DevComponents.DotNetBar.LabelX();
            this.txtCustName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCustName = new DevComponents.DotNetBar.LabelX();
            this.txtPlateNum = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblPlateNum = new DevComponents.DotNetBar.LabelX();
            this.txtDH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblDH = new DevComponents.DotNetBar.LabelX();
            this.cmbVisitReturn = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.comboItem6 = new DevComponents.Editors.ComboItem();
            this.comboItem7 = new DevComponents.Editors.ComboItem();
            this.comboItem8 = new DevComponents.Editors.ComboItem();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem13 = new DevComponents.Editors.ComboItem();
            this.lblVisitReturn = new DevComponents.DotNetBar.LabelX();
            this.datVisitDate = new System.Windows.Forms.DateTimePicker();
            this.lblVisitDate = new DevComponents.DotNetBar.LabelX();
            this.cmbVisitType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.lblVisitType = new DevComponents.DotNetBar.LabelX();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtVisitRemark
            // 
            // 
            // 
            // 
            this.txtVisitRemark.Border.Class = "TextBoxBorder";
            this.txtVisitRemark.Location = new System.Drawing.Point(95, 207);
            this.txtVisitRemark.Name = "txtVisitRemark";
            this.txtVisitRemark.Size = new System.Drawing.Size(250, 21);
            this.txtVisitRemark.TabIndex = 52;
            this.txtVisitRemark.Tag = "F1S1";
            // 
            // lblVisitRemark
            // 
            this.lblVisitRemark.AutoSize = true;
            this.lblVisitRemark.Location = new System.Drawing.Point(45, 209);
            this.lblVisitRemark.Name = "lblVisitRemark";
            this.lblVisitRemark.Size = new System.Drawing.Size(44, 18);
            this.lblVisitRemark.TabIndex = 51;
            this.lblVisitRemark.Text = "备  注";
            // 
            // cmbVisitResult
            // 
            this.cmbVisitResult.DisplayMember = "Text";
            this.cmbVisitResult.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbVisitResult.FormattingEnabled = true;
            this.cmbVisitResult.ItemHeight = 15;
            this.cmbVisitResult.Items.AddRange(new object[] {
            this.comboItem9,
            this.comboItem10,
            this.comboItem11,
            this.comboItem12,
            this.comboItem14,
            this.comboItem15,
            this.comboItem16,
            this.comboItem17});
            this.cmbVisitResult.Location = new System.Drawing.Point(339, 166);
            this.cmbVisitResult.Name = "cmbVisitResult";
            this.cmbVisitResult.Size = new System.Drawing.Size(128, 21);
            this.cmbVisitResult.TabIndex = 50;
            this.cmbVisitResult.Tag = "F1S1B1";
            // 
            // comboItem9
            // 
            this.comboItem9.Text = "抱怨";
            // 
            // comboItem10
            // 
            this.comboItem10.Text = "表扬";
            // 
            // comboItem11
            // 
            this.comboItem11.Text = "电话号码错";
            // 
            // comboItem12
            // 
            this.comboItem12.Text = "电话忙";
            // 
            // comboItem14
            // 
            this.comboItem14.Text = "建议 ";
            // 
            // comboItem15
            // 
            this.comboItem15.Text = "空号";
            // 
            // comboItem16
            // 
            this.comboItem16.Text = "投诉 ";
            // 
            // comboItem17
            // 
            this.comboItem17.Text = "无法回访";
            // 
            // lblVisitResult
            // 
            this.lblVisitResult.AutoSize = true;
            this.lblVisitResult.Location = new System.Drawing.Point(278, 169);
            this.lblVisitResult.Name = "lblVisitResult";
            this.lblVisitResult.Size = new System.Drawing.Size(56, 18);
            this.lblVisitResult.TabIndex = 49;
            this.lblVisitResult.Text = "反馈结果";
            // 
            // txtCarModel
            // 
            // 
            // 
            // 
            this.txtCarModel.Border.Class = "TextBoxBorder";
            this.txtCarModel.Location = new System.Drawing.Point(339, 90);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.ReadOnly = true;
            this.txtCarModel.Size = new System.Drawing.Size(128, 21);
            this.txtCarModel.TabIndex = 48;
            this.txtCarModel.Tag = "F1S1";
            // 
            // lblCarModel
            // 
            this.lblCarModel.AutoSize = true;
            this.lblCarModel.Location = new System.Drawing.Point(277, 91);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.Size = new System.Drawing.Size(56, 18);
            this.lblCarModel.TabIndex = 47;
            this.lblCarModel.Text = "车辆型号";
            // 
            // txtCustName
            // 
            // 
            // 
            // 
            this.txtCustName.Border.Class = "TextBoxBorder";
            this.txtCustName.Location = new System.Drawing.Point(95, 91);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.ReadOnly = true;
            this.txtCustName.Size = new System.Drawing.Size(128, 21);
            this.txtCustName.TabIndex = 46;
            this.txtCustName.Tag = "F1S1";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(33, 93);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(56, 18);
            this.lblCustName.TabIndex = 45;
            this.lblCustName.Text = "客户名字";
            // 
            // txtPlateNum
            // 
            // 
            // 
            // 
            this.txtPlateNum.Border.Class = "TextBoxBorder";
            this.txtPlateNum.Location = new System.Drawing.Point(339, 54);
            this.txtPlateNum.Name = "txtPlateNum";
            this.txtPlateNum.ReadOnly = true;
            this.txtPlateNum.Size = new System.Drawing.Size(128, 21);
            this.txtPlateNum.TabIndex = 44;
            this.txtPlateNum.Tag = "F1S1";
            // 
            // lblPlateNum
            // 
            this.lblPlateNum.AutoSize = true;
            this.lblPlateNum.Location = new System.Drawing.Point(278, 55);
            this.lblPlateNum.Name = "lblPlateNum";
            this.lblPlateNum.Size = new System.Drawing.Size(56, 18);
            this.lblPlateNum.TabIndex = 43;
            this.lblPlateNum.Text = "车 牌 号";
            // 
            // txtDH
            // 
            // 
            // 
            // 
            this.txtDH.Border.Class = "TextBoxBorder";
            this.txtDH.Location = new System.Drawing.Point(95, 53);
            this.txtDH.Name = "txtDH";
            this.txtDH.ReadOnly = true;
            this.txtDH.Size = new System.Drawing.Size(128, 21);
            this.txtDH.TabIndex = 42;
            this.txtDH.Tag = "F1S1";
            // 
            // lblDH
            // 
            this.lblDH.AutoSize = true;
            this.lblDH.Location = new System.Drawing.Point(45, 54);
            this.lblDH.Name = "lblDH";
            this.lblDH.Size = new System.Drawing.Size(44, 18);
            this.lblDH.TabIndex = 41;
            this.lblDH.Text = "单  号";
            // 
            // cmbVisitReturn
            // 
            this.cmbVisitReturn.DisplayMember = "Text";
            this.cmbVisitReturn.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbVisitReturn.FormattingEnabled = true;
            this.cmbVisitReturn.ItemHeight = 15;
            this.cmbVisitReturn.Items.AddRange(new object[] {
            this.comboItem5,
            this.comboItem6,
            this.comboItem7,
            this.comboItem8,
            this.comboItem1,
            this.comboItem13});
            this.cmbVisitReturn.Location = new System.Drawing.Point(95, 166);
            this.cmbVisitReturn.Name = "cmbVisitReturn";
            this.cmbVisitReturn.Size = new System.Drawing.Size(128, 21);
            this.cmbVisitReturn.TabIndex = 40;
            this.cmbVisitReturn.Tag = "F1S1B1";
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "很满意";
            // 
            // comboItem6
            // 
            this.comboItem6.Text = "较满意";
            // 
            // comboItem7
            // 
            this.comboItem7.Text = "满意";
            // 
            // comboItem8
            // 
            this.comboItem8.Text = "一般";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "一般";
            // 
            // comboItem13
            // 
            this.comboItem13.Text = "不满意";
            // 
            // lblVisitReturn
            // 
            this.lblVisitReturn.AutoSize = true;
            this.lblVisitReturn.Location = new System.Drawing.Point(33, 168);
            this.lblVisitReturn.Name = "lblVisitReturn";
            this.lblVisitReturn.Size = new System.Drawing.Size(56, 18);
            this.lblVisitReturn.TabIndex = 39;
            this.lblVisitReturn.Text = "回访效果";
            // 
            // datVisitDate
            // 
            this.datVisitDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datVisitDate.Location = new System.Drawing.Point(95, 130);
            this.datVisitDate.Name = "datVisitDate";
            this.datVisitDate.Size = new System.Drawing.Size(128, 21);
            this.datVisitDate.TabIndex = 38;
            // 
            // lblVisitDate
            // 
            this.lblVisitDate.AutoSize = true;
            this.lblVisitDate.Location = new System.Drawing.Point(33, 131);
            this.lblVisitDate.Name = "lblVisitDate";
            this.lblVisitDate.Size = new System.Drawing.Size(56, 18);
            this.lblVisitDate.TabIndex = 37;
            this.lblVisitDate.Text = "回访时间";
            // 
            // cmbVisitType
            // 
            this.cmbVisitType.DisplayMember = "Text";
            this.cmbVisitType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbVisitType.FormattingEnabled = true;
            this.cmbVisitType.ItemHeight = 15;
            this.cmbVisitType.Items.AddRange(new object[] {
            this.comboItem2,
            this.comboItem3,
            this.comboItem4});
            this.cmbVisitType.Location = new System.Drawing.Point(339, 127);
            this.cmbVisitType.Name = "cmbVisitType";
            this.cmbVisitType.Size = new System.Drawing.Size(128, 21);
            this.cmbVisitType.TabIndex = 21;
            this.cmbVisitType.Tag = "F1S1B1";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "电话";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "短信";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "Email";
            // 
            // lblVisitType
            // 
            this.lblVisitType.AutoSize = true;
            this.lblVisitType.Location = new System.Drawing.Point(277, 130);
            this.lblVisitType.Name = "lblVisitType";
            this.lblVisitType.Size = new System.Drawing.Size(56, 18);
            this.lblVisitType.TabIndex = 20;
            this.lblVisitType.Text = "回访方式";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(499, 25);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnSave
            // 
            this.tbtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tbtnSave.Image")));
            this.tbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnSave.Name = "tbtnSave";
            this.tbtnSave.Size = new System.Drawing.Size(52, 22);
            this.tbtnSave.Tag = "ok";
            this.tbtnSave.Text = "确定";
            this.tbtnSave.Click += new System.EventHandler(this.tbtnSave_Click);
            // 
            // frmDlgRepVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 260);
            this.Controls.Add(this.txtVisitRemark);
            this.Controls.Add(this.lblVisitRemark);
            this.Controls.Add(this.cmbVisitResult);
            this.Controls.Add(this.lblVisitResult);
            this.Controls.Add(this.txtCarModel);
            this.Controls.Add(this.lblCarModel);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.txtPlateNum);
            this.Controls.Add(this.lblPlateNum);
            this.Controls.Add(this.txtDH);
            this.Controls.Add(this.lblDH);
            this.Controls.Add(this.cmbVisitReturn);
            this.Controls.Add(this.lblVisitReturn);
            this.Controls.Add(this.datVisitDate);
            this.Controls.Add(this.lblVisitDate);
            this.Controls.Add(this.cmbVisitType);
            this.Controls.Add(this.lblVisitType);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmDlgRepVisit";
            this.Text = "回访登记";
            this.Load += new System.EventHandler(this.frmDlgRepVisit_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnSave;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbVisitType;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.DotNetBar.LabelX lblVisitType;
        private System.Windows.Forms.DateTimePicker datVisitDate;
        private DevComponents.DotNetBar.LabelX lblVisitDate;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbVisitReturn;
        private DevComponents.Editors.ComboItem comboItem5;
        private DevComponents.Editors.ComboItem comboItem6;
        private DevComponents.Editors.ComboItem comboItem7;
        private DevComponents.Editors.ComboItem comboItem8;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDH;
        private DevComponents.DotNetBar.LabelX lblDH;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPlateNum;
        private DevComponents.DotNetBar.LabelX lblPlateNum;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCustName;
        private DevComponents.DotNetBar.LabelX lblCustName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCarModel;
        private DevComponents.DotNetBar.LabelX lblCarModel;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbVisitResult;
        private DevComponents.Editors.ComboItem comboItem9;
        private DevComponents.Editors.ComboItem comboItem10;
        private DevComponents.Editors.ComboItem comboItem11;
        private DevComponents.Editors.ComboItem comboItem12;
        private DevComponents.DotNetBar.LabelX lblVisitResult;
        private DevComponents.DotNetBar.LabelX lblVisitReturn;
        private DevComponents.DotNetBar.LabelX lblVisitRemark;
        private DevComponents.DotNetBar.Controls.TextBoxX txtVisitRemark;
        private DevComponents.Editors.ComboItem comboItem14;
        private DevComponents.Editors.ComboItem comboItem15;
        private DevComponents.Editors.ComboItem comboItem16;
        private DevComponents.Editors.ComboItem comboItem17;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem13;
    }
}