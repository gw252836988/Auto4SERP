﻿namespace Auto4SErp
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnLogin = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.chbIsNB = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chbpassword = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.cbtOrgan = new DevComponents.DotNetBar.Controls.ComboTree();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtPwd = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtStaffID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblPwd = new DevComponents.DotNetBar.LabelX();
            this.lblStaffID = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLogin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLogin.Location = new System.Drawing.Point(95, 233);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(176, 24);
            this.btnLogin.TabIndex = 45;
            this.btnLogin.Text = "登  录";
            this.btnLogin.Tooltip = "想让登录更方便，别忘了选中记住密码哦";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(95, 209);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(217, 18);
            this.labelX2.TabIndex = 54;
            this.labelX2.Text = "注：本门店员工密码是OA密码的前三位";
            // 
            // chbIsNB
            // 
            this.chbIsNB.Location = new System.Drawing.Point(286, 140);
            this.chbIsNB.Name = "chbIsNB";
            this.chbIsNB.Size = new System.Drawing.Size(75, 23);
            this.chbIsNB.TabIndex = 53;
            this.chbIsNB.Text = "内网";
            this.chbIsNB.Visible = false;
            // 
            // chbpassword
            // 
            this.chbpassword.Location = new System.Drawing.Point(286, 177);
            this.chbpassword.Name = "chbpassword";
            this.chbpassword.Size = new System.Drawing.Size(75, 23);
            this.chbpassword.TabIndex = 52;
            this.chbpassword.Text = "记住密码";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(14, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(374, 79);
            this.pnlLogin.TabIndex = 50;
            // 
            // cbtOrgan
            // 
            this.cbtOrgan.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.cbtOrgan.BackgroundStyle.Class = "TextBoxBorder";
            this.cbtOrgan.ButtonDropDown.Visible = true;
            this.cbtOrgan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbtOrgan.Location = new System.Drawing.Point(143, 100);
            this.cbtOrgan.Name = "cbtOrgan";
            this.cbtOrgan.Size = new System.Drawing.Size(128, 23);
            this.cbtOrgan.TabIndex = 49;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(93, 103);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(44, 18);
            this.labelX1.TabIndex = 47;
            this.labelX1.Text = "门  店";
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPwd.Border.Class = "TextBoxBorder";
            this.txtPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPwd.Location = new System.Drawing.Point(143, 177);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(128, 21);
            this.txtPwd.TabIndex = 44;
            this.txtPwd.Tag = "N";
            // 
            // txtStaffID
            // 
            this.txtStaffID.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtStaffID.Border.Class = "TextBoxBorder";
            this.txtStaffID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStaffID.Location = new System.Drawing.Point(143, 139);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(128, 21);
            this.txtStaffID.TabIndex = 43;
            this.txtStaffID.Tag = "N";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(95, 179);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(44, 18);
            this.lblPwd.TabIndex = 42;
            this.lblPwd.Text = "密  码";
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Location = new System.Drawing.Point(94, 140);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(44, 18);
            this.lblStaffID.TabIndex = 41;
            this.lblStaffID.Text = "工  号";
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 271);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.chbIsNB);
            this.Controls.Add(this.chbpassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.cbtOrgan);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblStaffID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmLogin_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lblStaffID;
        private DevComponents.DotNetBar.LabelX lblPwd;
        private DevComponents.DotNetBar.Controls.TextBoxX txtStaffID;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPwd;
        private DevComponents.DotNetBar.ButtonX btnLogin;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboTree cbtOrgan;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.Controls.CheckBoxX chbpassword;
        private DevComponents.DotNetBar.Controls.CheckBoxX chbIsNB;
        private DevComponents.DotNetBar.LabelX labelX2;

    }
}