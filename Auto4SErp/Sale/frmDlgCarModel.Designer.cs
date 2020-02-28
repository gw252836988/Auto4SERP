namespace Auto4SErp.Sale
{
    partial class frmDlgCarModel
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
            System.Windows.Forms.PictureBox btnCustSel;
            this.txtCarModel = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCarSer = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labCarSer = new DevComponents.DotNetBar.LabelX();
            this.labModel = new DevComponents.DotNetBar.LabelX();
            this.btnOK = new DevComponents.DotNetBar.ButtonX();
            this.txtid = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblid = new DevComponents.DotNetBar.LabelX();
            btnCustSel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(btnCustSel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCustSel
            // 
            btnCustSel.BackgroundImage = global::Auto4SErp.Properties.Resources.smallquery;
            btnCustSel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnCustSel.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCustSel.Location = new System.Drawing.Point(405, 138);
            btnCustSel.Name = "btnCustSel";
            btnCustSel.Size = new System.Drawing.Size(16, 16);
            btnCustSel.TabIndex = 20;
            btnCustSel.TabStop = false;
            btnCustSel.Visible = false;
            btnCustSel.Click += new System.EventHandler(this.btnCustSel_Click);
            // 
            // txtCarModel
            // 
            // 
            // 
            // 
            this.txtCarModel.Border.Class = "TextBoxBorder";
            this.txtCarModel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
       
            this.txtCarModel.Location = new System.Drawing.Point(105, 65);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(141, 21);
            this.txtCarModel.TabIndex = 18;
            // 
            // txtCarSer
            // 
            // 
            // 
            // 
            this.txtCarSer.Border.Class = "TextBoxBorder";
            this.txtCarSer.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
           
            this.txtCarSer.Enabled = false;
            this.txtCarSer.Location = new System.Drawing.Point(258, 136);
            this.txtCarSer.Name = "txtCarSer";
            this.txtCarSer.Size = new System.Drawing.Size(141, 21);
            this.txtCarSer.TabIndex = 17;
            this.txtCarSer.Visible = false;
            // 
            // labCarSer
            // 
            // 
            // 
            // 
            this.labCarSer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labCarSer.Location = new System.Drawing.Point(204, 138);
            this.labCarSer.Name = "labCarSer";
            this.labCarSer.Size = new System.Drawing.Size(48, 23);
            this.labCarSer.TabIndex = 14;
            this.labCarSer.Text = "车  系";
            this.labCarSer.Visible = false;
            // 
            // labModel
            // 
            // 
            // 
            // 
            this.labModel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labModel.Location = new System.Drawing.Point(51, 65);
            this.labModel.Name = "labModel";
            this.labModel.Size = new System.Drawing.Size(48, 23);
            this.labModel.TabIndex = 13;
            this.labModel.Text = "车  型";
            this.labModel.Click += new System.EventHandler(this.labModel_Click);
            // 
            // btnOK
            // 
            this.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOK.Location = new System.Drawing.Point(105, 105);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(93, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtid
            // 
            // 
            // 
            // 
            this.txtid.Border.Class = "TextBoxBorder";
            this.txtid.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
           
            this.txtid.Location = new System.Drawing.Point(106, 28);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(141, 21);
            this.txtid.TabIndex = 22;
            // 
            // lblid
            // 
            // 
            // 
            // 
            this.lblid.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblid.Location = new System.Drawing.Point(40, 28);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(59, 23);
            this.lblid.TabIndex = 21;
            this.lblid.Text = "车型编码";
            // 
            // frmDlgCarModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 154);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblid);
            this.Controls.Add(btnCustSel);
            this.Controls.Add(this.txtCarModel);
            this.Controls.Add(this.txtCarSer);
            this.Controls.Add(this.labCarSer);
            this.Controls.Add(this.labModel);
            this.Controls.Add(this.btnOK);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmDlgCarModel";
            this.Text = "车型编辑";
            this.Load += new System.EventHandler(this.frmDlgCarModel_Load);
            ((System.ComponentModel.ISupportInitialize)(btnCustSel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnOK;
        private DevComponents.DotNetBar.LabelX labModel;
        private DevComponents.DotNetBar.LabelX labCarSer;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCarSer;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCarModel;
        private DevComponents.DotNetBar.Controls.TextBoxX txtid;
        private DevComponents.DotNetBar.LabelX lblid;
    }
}