namespace Auto4SErp
{
    partial class frmExecuteSql
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExecuteSql));
            this.txtSql = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnQuery = new System.Windows.Forms.ToolStripButton();
            this.txtResult = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSql
            // 
            // 
            // 
            // 
            this.txtSql.Border.Class = "TextBoxBorder";
            this.txtSql.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSql.Location = new System.Drawing.Point(0, 25);
            this.txtSql.Multiline = true;
            this.txtSql.Name = "txtSql";
            this.txtSql.Size = new System.Drawing.Size(482, 203);
            this.txtSql.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnQuery});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(482, 25);
            this.toolStrip1.TabIndex = 35;
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
            // txtResult
            // 
            // 
            // 
            // 
            this.txtResult.Border.Class = "TextBoxBorder";
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtResult.Location = new System.Drawing.Point(0, 168);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(482, 60);
            this.txtResult.TabIndex = 36;
            // 
            // frmExecuteSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 228);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtSql);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmExecuteSql";
            this.Text = "语句执行";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtSql;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX txtResult;
    }
}