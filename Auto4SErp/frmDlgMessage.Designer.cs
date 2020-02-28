namespace Auto4SErp
{
    partial class frmDlgMessage
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("在线用户");
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstUsers = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.txtSend = new System.Windows.Forms.RichTextBox();
            this.txtMsg = new System.Windows.Forms.RichTextBox();
            this.btnSend = new DevComponents.DotNetBar.ButtonX();
            this.panel1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstUsers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(401, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 364);
            this.panel1.TabIndex = 21;
            // 
            // lstUsers
            // 
            // 
            // 
            // 
            this.lstUsers.Border.Class = "ListViewBorder";
            this.lstUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstUsers.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lstUsers.Location = new System.Drawing.Point(0, 0);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(126, 364);
            this.lstUsers.TabIndex = 19;
            this.lstUsers.UseCompatibleStateImageBehavior = false;
            this.lstUsers.View = System.Windows.Forms.View.Tile;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.txtSend);
            this.mainPanel.Controls.Add(this.txtMsg);
            this.mainPanel.Controls.Add(this.btnSend);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(401, 364);
            this.mainPanel.TabIndex = 20;
            // 
            // txtSend
            // 
            this.txtSend.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSend.Location = new System.Drawing.Point(0, 219);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(401, 87);
            this.txtSend.TabIndex = 3;
            this.txtSend.Text = "";
            // 
            // txtMsg
            // 
            this.txtMsg.BulletIndent = 5;
            this.txtMsg.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMsg.Location = new System.Drawing.Point(0, 0);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(401, 219);
            this.txtMsg.TabIndex = 2;
            this.txtMsg.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSend.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSend.Location = new System.Drawing.Point(293, 326);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 18;
            this.btnSend.Text = "发送";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // frmDlgMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 364);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDlgMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "消息窗口";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDlgMessage_FormClosed);
            this.Load += new System.EventHandler(this.frmDlgMessage_Load);
            this.panel1.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtMsg;
        private System.Windows.Forms.RichTextBox txtSend;
        private DevComponents.DotNetBar.ButtonX btnSend;
        private DevComponents.DotNetBar.Controls.ListViewEx lstUsers;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel1;
    }
}