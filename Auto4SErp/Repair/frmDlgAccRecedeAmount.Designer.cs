namespace Auto4SErp.Repair
{
    partial class frmDlgAccRecedeAmount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDlgAccRecedeAmount));
            this.dbiAmountRe = new DevComponents.Editors.DoubleInput();
            this.lblSalePrice = new DevComponents.DotNetBar.LabelX();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOK = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dbiAmountRe)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbiAmountRe
            // 
            // 
            // 
            // 
            this.dbiAmountRe.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dbiAmountRe.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.dbiAmountRe.Increment = 1D;
            this.dbiAmountRe.Location = new System.Drawing.Point(105, 45);
            this.dbiAmountRe.Name = "dbiAmountRe";
            this.dbiAmountRe.ShowUpDown = true;
            this.dbiAmountRe.Size = new System.Drawing.Size(123, 21);
            this.dbiAmountRe.TabIndex = 61;
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.Location = new System.Drawing.Point(43, 47);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(56, 18);
            this.lblSalePrice.TabIndex = 60;
            this.lblSalePrice.Text = "退库数量";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOK});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(284, 25);
            this.toolStrip1.TabIndex = 62;
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
            // frmDlgAccRecedeAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 97);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dbiAmountRe);
            this.Controls.Add(this.lblSalePrice);
            this.Name = "frmDlgAccRecedeAmount";
            this.Text = "请输入退库数量";
            this.Load += new System.EventHandler(this.frmDlgAccRecedeAmount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbiAmountRe)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.Editors.DoubleInput dbiAmountRe;
        private DevComponents.DotNetBar.LabelX lblSalePrice;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnOK;
    }
}