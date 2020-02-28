namespace Auto4SErp
{
    partial class frmDlgCarSer
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
            this.labBrand = new DevComponents.DotNetBar.LabelX();
            this.labCarSer = new DevComponents.DotNetBar.LabelX();
            this.btnOK = new DevComponents.DotNetBar.ButtonX();
            this.txtCarSer = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCarBrand = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnSel = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // labBrand
            // 
            this.labBrand.Location = new System.Drawing.Point(36, 21);
            this.labBrand.Name = "labBrand";
            this.labBrand.Size = new System.Drawing.Size(46, 23);
            this.labBrand.TabIndex = 5;
            this.labBrand.Text = "品牌";
            // 
            // labCarSer
            // 
            this.labCarSer.Location = new System.Drawing.Point(36, 59);
            this.labCarSer.Name = "labCarSer";
            this.labCarSer.Size = new System.Drawing.Size(46, 23);
            this.labCarSer.TabIndex = 6;
            this.labCarSer.Text = "车系";
            // 
            // btnOK
            // 
            this.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOK.Location = new System.Drawing.Point(120, 98);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtCarSer
            // 
            // 
            // 
            // 
            this.txtCarSer.Border.Class = "TextBoxBorder";
            this.txtCarSer.Location = new System.Drawing.Point(88, 59);
            this.txtCarSer.Name = "txtCarSer";
            this.txtCarSer.Size = new System.Drawing.Size(138, 21);
            this.txtCarSer.TabIndex = 8;
            // 
            // txtCarBrand
            // 
            // 
            // 
            // 
            this.txtCarBrand.Border.Class = "TextBoxBorder";
            this.txtCarBrand.Enabled = false;
            this.txtCarBrand.Location = new System.Drawing.Point(89, 22);
            this.txtCarBrand.Name = "txtCarBrand";
            this.txtCarBrand.Size = new System.Drawing.Size(137, 21);
            this.txtCarBrand.TabIndex = 9;
            // 
            // btnSel
            // 
            this.btnSel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSel.Location = new System.Drawing.Point(234, 21);
            this.btnSel.Name = "btnSel";
            this.btnSel.Size = new System.Drawing.Size(64, 23);
            this.btnSel.TabIndex = 10;
            this.btnSel.Text = "选择";
            this.btnSel.Click += new System.EventHandler(this.btnSel_Click);
            // 
            // frmDlgCarSer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 139);
            this.Controls.Add(this.btnSel);
            this.Controls.Add(this.txtCarBrand);
            this.Controls.Add(this.txtCarSer);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.labCarSer);
            this.Controls.Add(this.labBrand);
            this.MaximizeBox = false;
            this.Name = "frmDlgCarSer";
            this.Text = "车系编辑";
            this.Load += new System.EventHandler(this.frmDlgCarSer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labBrand;
        private DevComponents.DotNetBar.LabelX labCarSer;
        private DevComponents.DotNetBar.ButtonX btnOK;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCarSer;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCarBrand;
        private DevComponents.DotNetBar.ButtonX btnSel;
    }
}