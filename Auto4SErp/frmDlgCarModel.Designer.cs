namespace Auto4SErp
{
    partial class frmDlgCarModel
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
            this.btnOK = new DevComponents.DotNetBar.ButtonX();
            this.labModel = new DevComponents.DotNetBar.LabelX();
            this.labCarSer = new DevComponents.DotNetBar.LabelX();
            this.txtCarSer = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCarModel = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnSel = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOK.Location = new System.Drawing.Point(98, 111);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // labModel
            // 
            this.labModel.Location = new System.Drawing.Point(37, 72);
            this.labModel.Name = "labModel";
            this.labModel.Size = new System.Drawing.Size(75, 23);
            this.labModel.TabIndex = 13;
            this.labModel.Text = "车型";
            // 
            // labCarSer
            // 
            this.labCarSer.Location = new System.Drawing.Point(37, 27);
            this.labCarSer.Name = "labCarSer";
            this.labCarSer.Size = new System.Drawing.Size(75, 23);
            this.labCarSer.TabIndex = 14;
            this.labCarSer.Text = "车系";
            // 
            // txtCarSer
            // 
            // 
            // 
            // 
            this.txtCarSer.Border.Class = "TextBoxBorder";
            this.txtCarSer.Enabled = false;
            this.txtCarSer.Location = new System.Drawing.Point(98, 26);
            this.txtCarSer.Name = "txtCarSer";
            this.txtCarSer.Size = new System.Drawing.Size(141, 21);
            this.txtCarSer.TabIndex = 17;
            // 
            // txtCarModel
            // 
            // 
            // 
            // 
            this.txtCarModel.Border.Class = "TextBoxBorder";
            this.txtCarModel.Location = new System.Drawing.Point(98, 72);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(225, 21);
            this.txtCarModel.TabIndex = 18;
            // 
            // btnSel
            // 
            this.btnSel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSel.Location = new System.Drawing.Point(260, 26);
            this.btnSel.Name = "btnSel";
            this.btnSel.Size = new System.Drawing.Size(63, 23);
            this.btnSel.TabIndex = 19;
            this.btnSel.Text = "选择";
            this.btnSel.Click += new System.EventHandler(this.btnSel_Click);
            // 
            // frmDlgCarModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 148);
            this.Controls.Add(this.btnSel);
            this.Controls.Add(this.txtCarModel);
            this.Controls.Add(this.txtCarSer);
            this.Controls.Add(this.labCarSer);
            this.Controls.Add(this.labModel);
            this.Controls.Add(this.btnOK);
            this.MaximizeBox = false;
            this.Name = "frmDlgCarModel";
            this.Text = "车型编辑";
            this.Load += new System.EventHandler(this.frmDlgCarModel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnOK;
        private DevComponents.DotNetBar.LabelX labModel;
        private DevComponents.DotNetBar.LabelX labCarSer;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCarSer;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCarModel;
        private DevComponents.DotNetBar.ButtonX btnSel;
    }
}