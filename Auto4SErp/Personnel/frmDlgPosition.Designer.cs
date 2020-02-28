namespace Auto4SErp.Personnel
{
    partial class frmDlgPosition
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
            System.Windows.Forms.PictureBox btnDepartmentFind;
            this.labDepart = new DevComponents.DotNetBar.LabelX();
            this.txtDepart = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labPosition = new DevComponents.DotNetBar.LabelX();
            this.txtPosition = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnOk = new DevComponents.DotNetBar.ButtonX();
            btnDepartmentFind = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(btnDepartmentFind)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDepartmentFind
            // 
            btnDepartmentFind.BackgroundImage = global::Auto4SErp.Properties.Resources.smallquery;
            btnDepartmentFind.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDepartmentFind.Location = new System.Drawing.Point(292, 30);
            btnDepartmentFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnDepartmentFind.Name = "btnDepartmentFind";
            btnDepartmentFind.Size = new System.Drawing.Size(21, 20);
            btnDepartmentFind.TabIndex = 42;
            btnDepartmentFind.TabStop = false;
            btnDepartmentFind.Click += new System.EventHandler(this.btnDepartmentFind_Click);
            // 
            // labDepart
            // 
            this.labDepart.Location = new System.Drawing.Point(59, 30);
            this.labDepart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labDepart.Name = "labDepart";
            this.labDepart.Size = new System.Drawing.Size(47, 29);
            this.labDepart.TabIndex = 0;
            this.labDepart.Text = "部门";
            // 
            // txtDepart
            // 
            // 
            // 
            // 
            this.txtDepart.Border.Class = "TextBoxBorder";
            this.txtDepart.Location = new System.Drawing.Point(113, 30);
            this.txtDepart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDepart.Name = "txtDepart";
            this.txtDepart.ReadOnly = true;
            this.txtDepart.Size = new System.Drawing.Size(171, 25);
            this.txtDepart.TabIndex = 1;
            // 
            // labPosition
            // 
            this.labPosition.Location = new System.Drawing.Point(60, 82);
            this.labPosition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labPosition.Name = "labPosition";
            this.labPosition.Size = new System.Drawing.Size(47, 29);
            this.labPosition.TabIndex = 3;
            this.labPosition.Text = "职位";
            // 
            // txtPosition
            // 
            // 
            // 
            // 
            this.txtPosition.Border.Class = "TextBoxBorder";
            this.txtPosition.Location = new System.Drawing.Point(113, 82);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(171, 25);
            this.txtPosition.TabIndex = 4;
            // 
            // btnOk
            // 
            this.btnOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOk.Location = new System.Drawing.Point(148, 130);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(85, 29);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "确定";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmDlgPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 179);
            this.Controls.Add(btnDepartmentFind);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.labPosition);
            this.Controls.Add(this.txtDepart);
            this.Controls.Add(this.labDepart);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "frmDlgPosition";
            this.Text = "职位";
            this.Load += new System.EventHandler(this.frmDlgPosition_Load);
            ((System.ComponentModel.ISupportInitialize)(btnDepartmentFind)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labDepart;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDepart;
        private DevComponents.DotNetBar.LabelX labPosition;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPosition;
        private DevComponents.DotNetBar.ButtonX btnOk;

    }
}