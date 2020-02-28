namespace Auto4SErp
{
    partial class frmUserInfoOfP2P2
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
            this.txtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblPassword = new DevComponents.DotNetBar.LabelX();
            this.btnLogin = new DevComponents.DotNetBar.ButtonX();
            this.txtMobile = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblMobile = new DevComponents.DotNetBar.LabelX();
            this.txtValidateCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblValidateCode = new DevComponents.DotNetBar.LabelX();
            this.lblJE = new DevComponents.DotNetBar.LabelX();
            this.dbiJE = new DevComponents.Editors.DoubleInput();
            this.txtBalance = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblBalance = new DevComponents.DotNetBar.LabelX();
            this.txtLevel = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblLevel = new DevComponents.DotNetBar.LabelX();
            this.txtName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblName = new DevComponents.DotNetBar.LabelX();
            this.txtAccount = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblAccount = new DevComponents.DotNetBar.LabelX();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnRec = new System.Windows.Forms.ToolStripButton();
            this.btnValidate = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dbiJE)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.Border.Class = "TextBoxBorder";
            this.txtPassword.Location = new System.Drawing.Point(313, 47);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(128, 21);
            this.txtPassword.TabIndex = 149;
            this.txtPassword.Tag = "";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(263, 50);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(44, 18);
            this.lblPassword.TabIndex = 148;
            this.lblPassword.Text = "密  码";
            // 
            // btnLogin
            // 
            this.btnLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLogin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLogin.Location = new System.Drawing.Point(451, 46);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(63, 23);
            this.btnLogin.TabIndex = 147;
            this.btnLogin.Text = "登录";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtMobile
            // 
            // 
            // 
            // 
            this.txtMobile.Border.Class = "TextBoxBorder";
            this.txtMobile.Location = new System.Drawing.Point(83, 47);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(128, 21);
            this.txtMobile.TabIndex = 100;
            this.txtMobile.Tag = "F1S1";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(21, 49);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(56, 18);
            this.lblMobile.TabIndex = 145;
            this.lblMobile.Text = "手 机 号";
            // 
            // txtValidateCode
            // 
            // 
            // 
            // 
            this.txtValidateCode.Border.Class = "TextBoxBorder";
            this.txtValidateCode.Location = new System.Drawing.Point(313, 165);
            this.txtValidateCode.Name = "txtValidateCode";
            this.txtValidateCode.Size = new System.Drawing.Size(128, 21);
            this.txtValidateCode.TabIndex = 144;
            this.txtValidateCode.Tag = "";
            // 
            // lblValidateCode
            // 
            this.lblValidateCode.AutoSize = true;
            this.lblValidateCode.Location = new System.Drawing.Point(255, 168);
            this.lblValidateCode.Name = "lblValidateCode";
            this.lblValidateCode.Size = new System.Drawing.Size(56, 18);
            this.lblValidateCode.TabIndex = 143;
            this.lblValidateCode.Text = "验 证 码";
            // 
            // lblJE
            // 
            this.lblJE.AutoSize = true;
            this.lblJE.Location = new System.Drawing.Point(27, 168);
            this.lblJE.Name = "lblJE";
            this.lblJE.Size = new System.Drawing.Size(50, 18);
            this.lblJE.TabIndex = 139;
            this.lblJE.Text = "P2P余额";
            // 
            // dbiJE
            // 
            // 
            // 
            // 
            this.dbiJE.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dbiJE.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.dbiJE.Enabled = false;
            this.dbiJE.Increment = 1D;
            this.dbiJE.Location = new System.Drawing.Point(83, 166);
            this.dbiJE.Name = "dbiJE";
            this.dbiJE.ShowUpDown = true;
            this.dbiJE.Size = new System.Drawing.Size(128, 21);
            this.dbiJE.TabIndex = 137;
            // 
            // txtBalance
            // 
            // 
            // 
            // 
            this.txtBalance.Border.Class = "TextBoxBorder";
            this.txtBalance.Location = new System.Drawing.Point(313, 89);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(128, 21);
            this.txtBalance.TabIndex = 132;
            this.txtBalance.Tag = "F1S1";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(243, 92);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(68, 18);
            this.lblBalance.TabIndex = 131;
            this.lblBalance.Text = "购车宝余额";
            // 
            // txtLevel
            // 
            // 
            // 
            // 
            this.txtLevel.Border.Class = "TextBoxBorder";
            this.txtLevel.Location = new System.Drawing.Point(313, 126);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.ReadOnly = true;
            this.txtLevel.Size = new System.Drawing.Size(128, 21);
            this.txtLevel.TabIndex = 130;
            this.txtLevel.Tag = "F1S1";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(263, 129);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(44, 18);
            this.lblLevel.TabIndex = 129;
            this.lblLevel.Text = "级  别";
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.Border.Class = "TextBoxBorder";
            this.txtName.Location = new System.Drawing.Point(83, 126);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(128, 21);
            this.txtName.TabIndex = 126;
            this.txtName.Tag = "F1S1";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(33, 129);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 18);
            this.lblName.TabIndex = 125;
            this.lblName.Text = "姓  名";
            // 
            // txtAccount
            // 
            // 
            // 
            // 
            this.txtAccount.Border.Class = "TextBoxBorder";
            this.txtAccount.Location = new System.Drawing.Point(83, 88);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.ReadOnly = true;
            this.txtAccount.Size = new System.Drawing.Size(128, 21);
            this.txtAccount.TabIndex = 124;
            this.txtAccount.Tag = "F1S1";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(35, 91);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(44, 18);
            this.lblAccount.TabIndex = 123;
            this.lblAccount.Text = "账  号";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRec});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(545, 25);
            this.toolStrip1.TabIndex = 115;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnRec
            // 
            this.btnRec.Enabled = false;
            this.btnRec.Image = global::Auto4SErp.Properties.Resources.breceptm;
            this.btnRec.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRec.Name = "btnRec";
            this.btnRec.Size = new System.Drawing.Size(52, 22);
            this.btnRec.Text = "收款";
            this.btnRec.Click += new System.EventHandler(this.btnRec_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnValidate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnValidate.Enabled = false;
            this.btnValidate.Location = new System.Drawing.Point(451, 164);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(82, 23);
            this.btnValidate.TabIndex = 150;
            this.btnValidate.Text = "获取验证码";
            this.btnValidate.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // frmUserInfoOfP2P2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 207);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.txtValidateCode);
            this.Controls.Add(this.lblValidateCode);
            this.Controls.Add(this.lblJE);
            this.Controls.Add(this.dbiJE);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmUserInfoOfP2P2";
            this.Text = "P2P销售收款";
            this.Load += new System.EventHandler(this.frmUserInfoOfP2P2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbiJE)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRec;
        private DevComponents.DotNetBar.ButtonX btnLogin;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMobile;
        private DevComponents.DotNetBar.LabelX lblMobile;
        private DevComponents.DotNetBar.Controls.TextBoxX txtValidateCode;
        private DevComponents.DotNetBar.LabelX lblValidateCode;
        private DevComponents.DotNetBar.LabelX lblJE;
        private DevComponents.Editors.DoubleInput dbiJE;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBalance;
        private DevComponents.DotNetBar.LabelX lblBalance;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLevel;
        private DevComponents.DotNetBar.LabelX lblLevel;
        private DevComponents.DotNetBar.Controls.TextBoxX txtName;
        private DevComponents.DotNetBar.LabelX lblName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAccount;
        private DevComponents.DotNetBar.LabelX lblAccount;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPassword;
        private DevComponents.DotNetBar.LabelX lblPassword;
        private DevComponents.DotNetBar.ButtonX btnValidate;
    }
}