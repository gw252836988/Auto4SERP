﻿namespace Auto4SErp.Sale
{
    partial class frmDlgCarStockModify
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
            this.txtVin = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblVin = new DevComponents.DotNetBar.LabelX();
            this.cmbStorePlace = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblStorePlace = new DevComponents.DotNetBar.LabelX();
            this.lblInPrice = new DevComponents.DotNetBar.LabelX();
            this.btnOK = new DevComponents.DotNetBar.ButtonX();
            this.txtImage = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblImage = new DevComponents.DotNetBar.LabelX();
            this.txtInPrice = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtAutoNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // txtVin
            // 
            // 
            // 
            // 
            this.txtVin.Border.Class = "TextBoxBorder";
            this.txtVin.Location = new System.Drawing.Point(78, 71);
            this.txtVin.Name = "txtVin";
            this.txtVin.Size = new System.Drawing.Size(121, 21);
            this.txtVin.TabIndex = 84;
            this.txtVin.Tag = "N";
            // 
            // lblVin
            // 
            this.lblVin.AutoSize = true;
            this.lblVin.Location = new System.Drawing.Point(29, 74);
            this.lblVin.Name = "lblVin";
            this.lblVin.Size = new System.Drawing.Size(44, 18);
            this.lblVin.TabIndex = 83;
            this.lblVin.Text = "VIN 码";
            // 
            // cmbStorePlace
            // 
            this.cmbStorePlace.DisplayMember = "Text";
            this.cmbStorePlace.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStorePlace.FormattingEnabled = true;
            this.cmbStorePlace.ItemHeight = 15;
            this.cmbStorePlace.Location = new System.Drawing.Point(78, 33);
            this.cmbStorePlace.Name = "cmbStorePlace";
            this.cmbStorePlace.Size = new System.Drawing.Size(121, 21);
            this.cmbStorePlace.TabIndex = 82;
            this.cmbStorePlace.Tag = "N";
            // 
            // lblStorePlace
            // 
            this.lblStorePlace.AutoSize = true;
            this.lblStorePlace.Location = new System.Drawing.Point(17, 36);
            this.lblStorePlace.Name = "lblStorePlace";
            this.lblStorePlace.Size = new System.Drawing.Size(56, 18);
            this.lblStorePlace.TabIndex = 81;
            this.lblStorePlace.Text = "存放位置";
            // 
            // lblInPrice
            // 
            this.lblInPrice.AutoSize = true;
            this.lblInPrice.Location = new System.Drawing.Point(230, 34);
            this.lblInPrice.Name = "lblInPrice";
            this.lblInPrice.Size = new System.Drawing.Size(56, 18);
            this.lblInPrice.TabIndex = 79;
            this.lblInPrice.Text = "进 货 价";
            // 
            // btnOK
            // 
            this.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOK.Location = new System.Drawing.Point(187, 151);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(82, 25);
            this.btnOK.TabIndex = 85;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtImage
            // 
            // 
            // 
            // 
            this.txtImage.Border.Class = "TextBoxBorder";
            this.txtImage.Location = new System.Drawing.Point(292, 71);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(119, 21);
            this.txtImage.TabIndex = 87;
            this.txtImage.Tag = "Y";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(242, 74);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(44, 18);
            this.lblImage.TabIndex = 86;
            this.lblImage.Text = "图  片";
            // 
            // txtInPrice
            // 
            // 
            // 
            // 
            this.txtInPrice.Border.Class = "TextBoxBorder";
            this.txtInPrice.Location = new System.Drawing.Point(292, 33);
            this.txtInPrice.Name = "txtInPrice";
            this.txtInPrice.Size = new System.Drawing.Size(119, 21);
            this.txtInPrice.TabIndex = 88;
            this.txtInPrice.Tag = "NDouble";
            // 
            // txtAutoNumber
            // 
            // 
            // 
            // 
            this.txtAutoNumber.Border.Class = "TextBoxBorder";
            this.txtAutoNumber.Location = new System.Drawing.Point(78, 108);
            this.txtAutoNumber.Name = "txtAutoNumber";
            this.txtAutoNumber.Size = new System.Drawing.Size(121, 21);
            this.txtAutoNumber.TabIndex = 90;
            this.txtAutoNumber.Tag = "N";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(16, 111);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(56, 18);
            this.labelX1.TabIndex = 89;
            this.labelX1.Text = "自 编 号";
            // 
            // frmDlgCarStockModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 201);
            this.Controls.Add(this.txtAutoNumber);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtInPrice);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtVin);
            this.Controls.Add(this.lblVin);
            this.Controls.Add(this.cmbStorePlace);
            this.Controls.Add(this.lblStorePlace);
            this.Controls.Add(this.lblInPrice);
            this.Name = "frmDlgCarStockModify";
            this.Text = "车辆资料修改";
            this.Load += new System.EventHandler(this.frmDlgCarStockModify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtVin;
        private DevComponents.DotNetBar.LabelX lblVin;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbStorePlace;
        private DevComponents.DotNetBar.LabelX lblStorePlace;
        private DevComponents.DotNetBar.LabelX lblInPrice;
        private DevComponents.DotNetBar.ButtonX btnOK;
        private DevComponents.DotNetBar.Controls.TextBoxX txtImage;
        private DevComponents.DotNetBar.LabelX lblImage;
        private DevComponents.DotNetBar.Controls.TextBoxX txtInPrice;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAutoNumber;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}