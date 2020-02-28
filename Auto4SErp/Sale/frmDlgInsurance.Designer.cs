namespace Auto4SErp.Sale
{
    partial class frmDlgInsurance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDlgInsurance));
            this.btnChange = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtVin = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dbiBTPrice = new DevComponents.Editors.DoubleInput();
            this.lblBTPrice = new DevComponents.DotNetBar.LabelX();
            this.dbiAmountRe = new DevComponents.Editors.DoubleInput();
            this.lblSalePrice = new DevComponents.DotNetBar.LabelX();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOK = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dbiBTPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbiAmountRe)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChange.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnChange.Location = new System.Drawing.Point(265, 119);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(47, 23);
            this.btnChange.TabIndex = 70;
            this.btnChange.Text = "更改";
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(80, 126);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(37, 16);
            this.labelX1.TabIndex = 69;
            this.labelX1.Text = "V I N";
            // 
            // txtVin
            // 
            // 
            // 
            // 
            this.txtVin.Border.Class = "TextBoxBorder";
            this.txtVin.Location = new System.Drawing.Point(123, 121);
            this.txtVin.Name = "txtVin";
            this.txtVin.Size = new System.Drawing.Size(123, 21);
            this.txtVin.TabIndex = 68;
            // 
            // dbiBTPrice
            // 
            // 
            // 
            // 
            this.dbiBTPrice.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dbiBTPrice.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.dbiBTPrice.Increment = 1D;
            this.dbiBTPrice.Location = new System.Drawing.Point(123, 82);
            this.dbiBTPrice.Name = "dbiBTPrice";
            this.dbiBTPrice.ShowUpDown = true;
            this.dbiBTPrice.Size = new System.Drawing.Size(123, 21);
            this.dbiBTPrice.TabIndex = 67;
            // 
            // lblBTPrice
            // 
            this.lblBTPrice.AutoSize = true;
            this.lblBTPrice.Location = new System.Drawing.Point(61, 85);
            this.lblBTPrice.Name = "lblBTPrice";
            this.lblBTPrice.Size = new System.Drawing.Size(56, 18);
            this.lblBTPrice.TabIndex = 66;
            this.lblBTPrice.Text = "补贴金额";
            // 
            // dbiAmountRe
            // 
            // 
            // 
            // 
            this.dbiAmountRe.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dbiAmountRe.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.dbiAmountRe.Increment = 1D;
            this.dbiAmountRe.Location = new System.Drawing.Point(123, 44);
            this.dbiAmountRe.Name = "dbiAmountRe";
            this.dbiAmountRe.ShowUpDown = true;
            this.dbiAmountRe.Size = new System.Drawing.Size(123, 21);
            this.dbiAmountRe.TabIndex = 65;
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.Location = new System.Drawing.Point(61, 46);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(56, 18);
            this.lblSalePrice.TabIndex = 64;
            this.lblSalePrice.Text = "保险金额";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOK});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(359, 25);
            this.toolStrip1.TabIndex = 63;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnOK
            // 
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(52, 22);
            this.btnOK.Tag = "ok";
            this.btnOK.Text = "确认";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmDlgInsurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 177);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtVin);
            this.Controls.Add(this.dbiBTPrice);
            this.Controls.Add(this.lblBTPrice);
            this.Controls.Add(this.dbiAmountRe);
            this.Controls.Add(this.lblSalePrice);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmDlgInsurance";
            this.Text = "补录保险金额";
            this.Load += new System.EventHandler(this.frmDlgInsurance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbiBTPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbiAmountRe)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnOK;
        private DevComponents.Editors.DoubleInput dbiAmountRe;
        private DevComponents.DotNetBar.LabelX lblSalePrice;
        private DevComponents.Editors.DoubleInput dbiBTPrice;
        private DevComponents.DotNetBar.LabelX lblBTPrice;
        private DevComponents.DotNetBar.Controls.TextBoxX txtVin;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnChange;
    }
}