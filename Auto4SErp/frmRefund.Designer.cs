namespace Auto4SErp
{
    partial class frmRefund
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRefund));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnOK = new System.Windows.Forms.ToolStripButton();
            this.lblRefundTo = new DevComponents.DotNetBar.LabelX();
            this.cmbRefundTo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnOK});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(282, 25);
            this.toolStrip1.TabIndex = 39;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnOK
            // 
            this.tbtnOK.Image = ((System.Drawing.Image)(resources.GetObject("tbtnOK.Image")));
            this.tbtnOK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnOK.Name = "tbtnOK";
            this.tbtnOK.Size = new System.Drawing.Size(56, 22);
            this.tbtnOK.Tag = "ok";
            this.tbtnOK.Text = " 确定";
            this.tbtnOK.Click += new System.EventHandler(this.tbtnOK_Click);
            // 
            // lblRefundTo
            // 
            this.lblRefundTo.AutoSize = true;
            // 
            // 
            // 
            this.lblRefundTo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRefundTo.Location = new System.Drawing.Point(49, 47);
            this.lblRefundTo.Name = "lblRefundTo";
            this.lblRefundTo.Size = new System.Drawing.Size(56, 18);
            this.lblRefundTo.TabIndex = 19;
            this.lblRefundTo.Text = "退款类型";
            // 
            // cmbRefundTo
            // 
            this.cmbRefundTo.DisplayMember = "Text";
            this.cmbRefundTo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRefundTo.FormattingEnabled = true;
            this.cmbRefundTo.ItemHeight = 15;
            this.cmbRefundTo.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3});
            this.cmbRefundTo.Location = new System.Drawing.Point(111, 44);
            this.cmbRefundTo.Name = "cmbRefundTo";
            this.cmbRefundTo.Size = new System.Drawing.Size(105, 21);
            this.cmbRefundTo.TabIndex = 0;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "现金";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "银行卡";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "会员卡";
            // 
            // frmRefund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 94);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblRefundTo);
            this.Controls.Add(this.cmbRefundTo);
            this.Name = "frmRefund";
            this.Text = "返单";
            this.Load += new System.EventHandler(this.frmRefund_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbRefundTo;
        private DevComponents.DotNetBar.LabelX lblRefundTo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnOK;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
    }
}