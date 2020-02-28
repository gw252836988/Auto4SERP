namespace Auto4SErp.Repair
{
    partial class frmDlgBatchIDofTake
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDlgBatchIDofTake));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOK = new System.Windows.Forms.ToolStripButton();
            this.lblBatchID = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.itiBatchID = new DevComponents.Editors.IntegerInput();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itiBatchID)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOK});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(287, 25);
            this.toolStrip1.TabIndex = 61;
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
            // lblBatchID
            // 
            this.lblBatchID.AutoSize = true;
            this.lblBatchID.Location = new System.Drawing.Point(46, 52);
            this.lblBatchID.Name = "lblBatchID";
            this.lblBatchID.Size = new System.Drawing.Size(56, 18);
            this.lblBatchID.TabIndex = 62;
            this.lblBatchID.Text = "打印批次";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(46, 85);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(99, 18);
            this.labelX1.TabIndex = 64;
            this.labelX1.Text = "注：0是全部打印";
            // 
            // itiBatchID
            // 
            // 
            // 
            // 
            this.itiBatchID.BackgroundStyle.Class = "DateTimeInputBackground";
            this.itiBatchID.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.itiBatchID.Location = new System.Drawing.Point(109, 50);
            this.itiBatchID.Name = "itiBatchID";
            this.itiBatchID.ShowUpDown = true;
            this.itiBatchID.Size = new System.Drawing.Size(92, 21);
            this.itiBatchID.TabIndex = 65;
            // 
            // frmDlgBatchIDofTake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 128);
            this.Controls.Add(this.itiBatchID);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.lblBatchID);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmDlgBatchIDofTake";
            this.Text = "打印批次选择";
            this.Load += new System.EventHandler(this.frmDlgBatchIDofTake_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itiBatchID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnOK;
        private DevComponents.DotNetBar.LabelX lblBatchID;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.IntegerInput itiBatchID;
    }
}