namespace Auto4SErp.Repair
{
    partial class frmDlgPriceInOfTake
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDlgPriceInOfTake));
            this.dbiSalePrice = new DevComponents.Editors.DoubleInput();
            this.lblSalePrice = new DevComponents.DotNetBar.LabelX();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOK = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dbiSalePrice)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbiSalePrice
            // 
            // 
            // 
            // 
            this.dbiSalePrice.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dbiSalePrice.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.dbiSalePrice.Increment = 1D;
            this.dbiSalePrice.Location = new System.Drawing.Point(78, 42);
            this.dbiSalePrice.Name = "dbiSalePrice";
            this.dbiSalePrice.ShowUpDown = true;
            this.dbiSalePrice.Size = new System.Drawing.Size(104, 21);
            this.dbiSalePrice.TabIndex = 59;
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.Location = new System.Drawing.Point(28, 44);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(44, 18);
            this.lblSalePrice.TabIndex = 58;
            this.lblSalePrice.Text = "价  格";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOK});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(225, 25);
            this.toolStrip1.TabIndex = 60;
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
            // frmDlgPriceInOfTake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 82);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dbiSalePrice);
            this.Controls.Add(this.lblSalePrice);
            this.Name = "frmDlgPriceInOfTake";
            this.Text = "请输入价格";
            this.Load += new System.EventHandler(this.frmDlgPriceInOfTake_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbiSalePrice)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.Editors.DoubleInput dbiSalePrice;
        private DevComponents.DotNetBar.LabelX lblSalePrice;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnOK;
    }
}