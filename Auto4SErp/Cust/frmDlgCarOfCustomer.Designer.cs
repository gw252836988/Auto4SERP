namespace Auto4SErp.Cust
{
    partial class frmDlgCarOfCustomer
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
            System.Windows.Forms.PictureBox btnCarDocSel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDlgCarOfCustomer));
            this.txtCarColor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCarColor = new DevComponents.DotNetBar.LabelX();
            this.txtCarModel = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCarModel = new DevComponents.DotNetBar.LabelX();
            this.txtCarSer = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCarSer = new DevComponents.DotNetBar.LabelX();
            this.txtCarBrand = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCarBrand = new DevComponents.DotNetBar.LabelX();
            this.txtVin = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblVin = new DevComponents.DotNetBar.LabelX();
            this.txtPlateNum = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblPlateNum = new DevComponents.DotNetBar.LabelX();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOK = new System.Windows.Forms.ToolStripButton();
            btnCarDocSel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(btnCarDocSel)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCarDocSel
            // 
            btnCarDocSel.BackgroundImage = global::Auto4SErp.Properties.Resources.smallquery;
            btnCarDocSel.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCarDocSel.Location = new System.Drawing.Point(190, 82);
            btnCarDocSel.Name = "btnCarDocSel";
            btnCarDocSel.Size = new System.Drawing.Size(16, 16);
            btnCarDocSel.TabIndex = 105;
            btnCarDocSel.TabStop = false;
            btnCarDocSel.Visible = false;
            btnCarDocSel.Click += new System.EventHandler(this.btnCarDocSel_Click);
            // 
            // txtCarColor
            // 
            // 
            // 
            // 
            this.txtCarColor.Border.Class = "TextBoxBorder";
            this.txtCarColor.Location = new System.Drawing.Point(76, 160);
            this.txtCarColor.Name = "txtCarColor";
            this.txtCarColor.ReadOnly = true;
            this.txtCarColor.Size = new System.Drawing.Size(108, 21);
            this.txtCarColor.TabIndex = 107;
            this.txtCarColor.Tag = "Y";
            // 
            // lblCarColor
            // 
            this.lblCarColor.AutoSize = true;
            this.lblCarColor.Location = new System.Drawing.Point(32, 163);
            this.lblCarColor.Name = "lblCarColor";
            this.lblCarColor.Size = new System.Drawing.Size(44, 18);
            this.lblCarColor.TabIndex = 106;
            this.lblCarColor.Tag = "ya";
            this.lblCarColor.Text = "颜  色";
            // 
            // txtCarModel
            // 
            // 
            // 
            // 
            this.txtCarModel.Border.Class = "TextBoxBorder";
            this.txtCarModel.Location = new System.Drawing.Point(76, 119);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.ReadOnly = true;
            this.txtCarModel.Size = new System.Drawing.Size(192, 21);
            this.txtCarModel.TabIndex = 13;
            this.txtCarModel.Tag = "Y";
            // 
            // lblCarModel
            // 
            this.lblCarModel.AutoSize = true;
            this.lblCarModel.Location = new System.Drawing.Point(32, 122);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.Size = new System.Drawing.Size(44, 18);
            this.lblCarModel.TabIndex = 12;
            this.lblCarModel.Text = "车  型";
            // 
            // txtCarSer
            // 
            // 
            // 
            // 
            this.txtCarSer.Border.Class = "TextBoxBorder";
            this.txtCarSer.Location = new System.Drawing.Point(268, 78);
            this.txtCarSer.Name = "txtCarSer";
            this.txtCarSer.ReadOnly = true;
            this.txtCarSer.Size = new System.Drawing.Size(108, 21);
            this.txtCarSer.TabIndex = 11;
            this.txtCarSer.Tag = "Y";
            // 
            // lblCarSer
            // 
            this.lblCarSer.AutoSize = true;
            this.lblCarSer.Location = new System.Drawing.Point(224, 81);
            this.lblCarSer.Name = "lblCarSer";
            this.lblCarSer.Size = new System.Drawing.Size(44, 18);
            this.lblCarSer.TabIndex = 10;
            this.lblCarSer.Text = "车  系";
            // 
            // txtCarBrand
            // 
            // 
            // 
            // 
            this.txtCarBrand.Border.Class = "TextBoxBorder";
            this.txtCarBrand.Location = new System.Drawing.Point(76, 79);
            this.txtCarBrand.Name = "txtCarBrand";
            this.txtCarBrand.ReadOnly = true;
            this.txtCarBrand.Size = new System.Drawing.Size(108, 21);
            this.txtCarBrand.TabIndex = 9;
            this.txtCarBrand.Tag = "Y";
            // 
            // lblCarBrand
            // 
            this.lblCarBrand.AutoSize = true;
            this.lblCarBrand.Location = new System.Drawing.Point(32, 81);
            this.lblCarBrand.Name = "lblCarBrand";
            this.lblCarBrand.Size = new System.Drawing.Size(44, 18);
            this.lblCarBrand.TabIndex = 8;
            this.lblCarBrand.Text = "品  牌";
            // 
            // txtVin
            // 
            // 
            // 
            // 
            this.txtVin.Border.Class = "TextBoxBorder";
            this.txtVin.Location = new System.Drawing.Point(268, 40);
            this.txtVin.Name = "txtVin";
            this.txtVin.ReadOnly = true;
            this.txtVin.Size = new System.Drawing.Size(118, 21);
            this.txtVin.TabIndex = 7;
            this.txtVin.Tag = "Y";
            // 
            // lblVin
            // 
            this.lblVin.AutoSize = true;
            this.lblVin.Location = new System.Drawing.Point(224, 43);
            this.lblVin.Name = "lblVin";
            this.lblVin.Size = new System.Drawing.Size(44, 18);
            this.lblVin.TabIndex = 6;
            this.lblVin.Text = "Vin 码";
            // 
            // txtPlateNum
            // 
            // 
            // 
            // 
            this.txtPlateNum.Border.Class = "TextBoxBorder";
            this.txtPlateNum.Location = new System.Drawing.Point(76, 41);
            this.txtPlateNum.Name = "txtPlateNum";
            this.txtPlateNum.Size = new System.Drawing.Size(108, 21);
            this.txtPlateNum.TabIndex = 5;
            this.txtPlateNum.Tag = "N";
            // 
            // lblPlateNum
            // 
            this.lblPlateNum.AutoSize = true;
            this.lblPlateNum.ForeColor = System.Drawing.Color.Red;
            this.lblPlateNum.Location = new System.Drawing.Point(32, 43);
            this.lblPlateNum.Name = "lblPlateNum";
            this.lblPlateNum.Size = new System.Drawing.Size(44, 18);
            this.lblPlateNum.TabIndex = 4;
            this.lblPlateNum.Text = "车牌号";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOK});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(408, 25);
            this.toolStrip1.TabIndex = 108;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(52, 22);
            this.btnOK.Tag = "ok";
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmDlgCarOfCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 194);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtCarColor);
            this.Controls.Add(this.lblCarColor);
            this.Controls.Add(btnCarDocSel);
            this.Controls.Add(this.txtCarModel);
            this.Controls.Add(this.lblCarModel);
            this.Controls.Add(this.txtCarSer);
            this.Controls.Add(this.lblCarSer);
            this.Controls.Add(this.txtCarBrand);
            this.Controls.Add(this.lblCarBrand);
            this.Controls.Add(this.txtVin);
            this.Controls.Add(this.lblVin);
            this.Controls.Add(this.txtPlateNum);
            this.Controls.Add(this.lblPlateNum);
            this.Name = "frmDlgCarOfCustomer";
            this.Text = "变更车牌号";
            this.Load += new System.EventHandler(this.frmDlgCarOfCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(btnCarDocSel)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtPlateNum;
        private DevComponents.DotNetBar.LabelX lblPlateNum;
        private DevComponents.DotNetBar.Controls.TextBoxX txtVin;
        private DevComponents.DotNetBar.LabelX lblVin;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCarBrand;
        private DevComponents.DotNetBar.LabelX lblCarBrand;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCarSer;
        private DevComponents.DotNetBar.LabelX lblCarSer;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCarModel;
        private DevComponents.DotNetBar.LabelX lblCarModel;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCarColor;
        private DevComponents.DotNetBar.LabelX lblCarColor;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnOK;
    }
}