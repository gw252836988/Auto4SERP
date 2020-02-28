namespace Auto4SErp
{
    partial class frmPwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPwd));
            this.lblNewPwd = new DevComponents.DotNetBar.LabelX();
            this.txtNewPwd = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtConfrimPwd = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblConfirmPwd = new DevComponents.DotNetBar.LabelX();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNewPwd
            // 
            this.lblNewPwd.AutoSize = true;
            this.lblNewPwd.Location = new System.Drawing.Point(27, 45);
            this.lblNewPwd.Name = "lblNewPwd";
            this.lblNewPwd.Size = new System.Drawing.Size(56, 18);
            this.lblNewPwd.TabIndex = 15;
            this.lblNewPwd.Text = "新 密 码";
            // 
            // txtNewPwd
            // 
            // 
            // 
            // 
            this.txtNewPwd.Border.Class = "TextBoxBorder";
            this.txtNewPwd.Location = new System.Drawing.Point(89, 42);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.PasswordChar = '*';
            this.txtNewPwd.Size = new System.Drawing.Size(123, 21);
            this.txtNewPwd.TabIndex = 16;
            this.txtNewPwd.Tag = "N";
            // 
            // txtConfrimPwd
            // 
            // 
            // 
            // 
            this.txtConfrimPwd.Border.Class = "TextBoxBorder";
            this.txtConfrimPwd.Location = new System.Drawing.Point(89, 79);
            this.txtConfrimPwd.Name = "txtConfrimPwd";
            this.txtConfrimPwd.PasswordChar = '*';
            this.txtConfrimPwd.Size = new System.Drawing.Size(123, 21);
            this.txtConfrimPwd.TabIndex = 18;
            this.txtConfrimPwd.Tag = "N";
            // 
            // lblConfirmPwd
            // 
            this.lblConfirmPwd.AutoSize = true;
            this.lblConfirmPwd.Location = new System.Drawing.Point(27, 82);
            this.lblConfirmPwd.Name = "lblConfirmPwd";
            this.lblConfirmPwd.Size = new System.Drawing.Size(56, 18);
            this.lblConfirmPwd.TabIndex = 17;
            this.lblConfirmPwd.Text = "确认密码";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(241, 25);
            this.toolStrip1.TabIndex = 44;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(52, 22);
            this.btnSave.Tag = "save";
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 120);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtConfrimPwd);
            this.Controls.Add(this.lblConfirmPwd);
            this.Controls.Add(this.txtNewPwd);
            this.Controls.Add(this.lblNewPwd);
            this.Name = "frmPwd";
            this.Text = "密码修改";
            this.Load += new System.EventHandler(this.frmPwd_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lblNewPwd;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNewPwd;
        private DevComponents.DotNetBar.Controls.TextBoxX txtConfrimPwd;
        private DevComponents.DotNetBar.LabelX lblConfirmPwd;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSave;


    }
}