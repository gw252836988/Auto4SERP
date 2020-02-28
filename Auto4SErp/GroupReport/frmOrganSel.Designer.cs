namespace Auto4SErp.GroupReport
{
    partial class frmOrganSel
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtAll = new System.Windows.Forms.ToolStripButton();
            this.tbtNo = new System.Windows.Forms.ToolStripButton();
            this.tbtChange = new System.Windows.Forms.ToolStripButton();
            this.gbelse = new System.Windows.Forms.GroupBox();
            this.cb301 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.rb_elseno = new System.Windows.Forms.RadioButton();
            this.rb_elseall = new System.Windows.Forms.RadioButton();
            this.gbrd = new System.Windows.Forms.GroupBox();
            this.cb209 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cb206 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cb208 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cb205 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.rb_rdno = new System.Windows.Forms.RadioButton();
            this.rb_rdall = new System.Windows.Forms.RadioButton();
            this.gbhm = new System.Windows.Forms.GroupBox();
            this.cb202 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cb201 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.rb_hmno = new System.Windows.Forms.RadioButton();
            this.rb_hmall = new System.Windows.Forms.RadioButton();
            this.gbgys = new System.Windows.Forms.GroupBox();
            this.cb161 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cb159 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cb160 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cb153 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cb152 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.rb_gyno = new System.Windows.Forms.RadioButton();
            this.rb_gyall = new System.Windows.Forms.RadioButton();
            this.gbYX = new System.Windows.Forms.GroupBox();
            this.cb352 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cb102 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cb101 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.rb_yxno = new System.Windows.Forms.RadioButton();
            this.rb_yxall = new System.Windows.Forms.RadioButton();
            this.cb258 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cb608 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.toolStrip1.SuspendLayout();
            this.gbelse.SuspendLayout();
            this.gbrd.SuspendLayout();
            this.gbhm.SuspendLayout();
            this.gbgys.SuspendLayout();
            this.gbYX.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtAll,
            this.tbtNo,
            this.tbtChange});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(594, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtAll
            // 
            this.tbtAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtAll.Name = "tbtAll";
            this.tbtAll.Size = new System.Drawing.Size(36, 22);
            this.tbtAll.Tag = "select";
            this.tbtAll.Text = "全选";
            this.tbtAll.Click += new System.EventHandler(this.tbtAll_Click);
            // 
            // tbtNo
            // 
            this.tbtNo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtNo.Name = "tbtNo";
            this.tbtNo.Size = new System.Drawing.Size(48, 22);
            this.tbtNo.Tag = "cancel";
            this.tbtNo.Text = "全不选";
            this.tbtNo.Click += new System.EventHandler(this.tbtNo_Click);
            // 
            // tbtChange
            // 
            this.tbtChange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtChange.Name = "tbtChange";
            this.tbtChange.Size = new System.Drawing.Size(60, 22);
            this.tbtChange.Tag = "ok";
            this.tbtChange.Text = "确定选择";
            this.tbtChange.Click += new System.EventHandler(this.tbtChange_Click);
            // 
            // gbelse
            // 
            this.gbelse.Controls.Add(this.cb608);
            this.gbelse.Controls.Add(this.cb258);
            this.gbelse.Controls.Add(this.cb301);
            this.gbelse.Controls.Add(this.rb_elseno);
            this.gbelse.Controls.Add(this.rb_elseall);
            this.gbelse.Location = new System.Drawing.Point(5, 401);
            this.gbelse.Name = "gbelse";
            this.gbelse.Size = new System.Drawing.Size(585, 88);
            this.gbelse.TabIndex = 4;
            this.gbelse.TabStop = false;
            this.gbelse.Text = "其它";
            // 
            // cb301
            // 
            this.cb301.Location = new System.Drawing.Point(24, 49);
            this.cb301.Name = "cb301";
            this.cb301.Size = new System.Drawing.Size(96, 23);
            this.cb301.TabIndex = 2;
            this.cb301.Text = "盐城别克";
            // 
            // rb_elseno
            // 
            this.rb_elseno.AutoSize = true;
            this.rb_elseno.Location = new System.Drawing.Point(137, 20);
            this.rb_elseno.Name = "rb_elseno";
            this.rb_elseno.Size = new System.Drawing.Size(59, 16);
            this.rb_elseno.TabIndex = 1;
            this.rb_elseno.TabStop = true;
            this.rb_elseno.Text = "全不选";
            this.rb_elseno.UseVisualStyleBackColor = true;
            // 
            // rb_elseall
            // 
            this.rb_elseall.AutoSize = true;
            this.rb_elseall.Location = new System.Drawing.Point(72, 20);
            this.rb_elseall.Name = "rb_elseall";
            this.rb_elseall.Size = new System.Drawing.Size(47, 16);
            this.rb_elseall.TabIndex = 0;
            this.rb_elseall.TabStop = true;
            this.rb_elseall.Text = "全选";
            this.rb_elseall.UseVisualStyleBackColor = true;
            // 
            // gbrd
            // 
            this.gbrd.Controls.Add(this.cb209);
            this.gbrd.Controls.Add(this.cb206);
            this.gbrd.Controls.Add(this.cb208);
            this.gbrd.Controls.Add(this.cb205);
            this.gbrd.Controls.Add(this.rb_rdno);
            this.gbrd.Controls.Add(this.rb_rdall);
            this.gbrd.Location = new System.Drawing.Point(5, 307);
            this.gbrd.Name = "gbrd";
            this.gbrd.Size = new System.Drawing.Size(585, 88);
            this.gbrd.TabIndex = 3;
            this.gbrd.TabStop = false;
            this.gbrd.Text = "如东";
            // 
            // cb209
            // 
            this.cb209.Location = new System.Drawing.Point(298, 48);
            this.cb209.Name = "cb209";
            this.cb209.Size = new System.Drawing.Size(91, 23);
            this.cb209.TabIndex = 5;
            this.cb209.Text = "如东名爵";
            // 
            // cb206
            // 
            this.cb206.Location = new System.Drawing.Point(213, 48);
            this.cb206.Name = "cb206";
            this.cb206.Size = new System.Drawing.Size(91, 23);
            this.cb206.TabIndex = 4;
            this.cb206.Text = "如东广本";
            // 
            // cb208
            // 
            this.cb208.Location = new System.Drawing.Point(121, 48);
            this.cb208.Name = "cb208";
            this.cb208.Size = new System.Drawing.Size(99, 23);
            this.cb208.TabIndex = 3;
            this.cb208.Text = "如东荣威";
            // 
            // cb205
            // 
            this.cb205.Location = new System.Drawing.Point(23, 48);
            this.cb205.Name = "cb205";
            this.cb205.Size = new System.Drawing.Size(96, 23);
            this.cb205.TabIndex = 2;
            this.cb205.Text = "如东雪佛兰";
            // 
            // rb_rdno
            // 
            this.rb_rdno.AutoSize = true;
            this.rb_rdno.Location = new System.Drawing.Point(137, 20);
            this.rb_rdno.Name = "rb_rdno";
            this.rb_rdno.Size = new System.Drawing.Size(59, 16);
            this.rb_rdno.TabIndex = 1;
            this.rb_rdno.TabStop = true;
            this.rb_rdno.Text = "全不选";
            this.rb_rdno.UseVisualStyleBackColor = true;
            // 
            // rb_rdall
            // 
            this.rb_rdall.AutoSize = true;
            this.rb_rdall.Location = new System.Drawing.Point(72, 20);
            this.rb_rdall.Name = "rb_rdall";
            this.rb_rdall.Size = new System.Drawing.Size(47, 16);
            this.rb_rdall.TabIndex = 0;
            this.rb_rdall.TabStop = true;
            this.rb_rdall.Text = "全选";
            this.rb_rdall.UseVisualStyleBackColor = true;
            // 
            // gbhm
            // 
            this.gbhm.Controls.Add(this.cb202);
            this.gbhm.Controls.Add(this.cb201);
            this.gbhm.Controls.Add(this.rb_hmno);
            this.gbhm.Controls.Add(this.rb_hmall);
            this.gbhm.Location = new System.Drawing.Point(5, 213);
            this.gbhm.Name = "gbhm";
            this.gbhm.Size = new System.Drawing.Size(585, 88);
            this.gbhm.TabIndex = 2;
            this.gbhm.TabStop = false;
            this.gbhm.Text = "海门";
            // 
            // cb202
            // 
            this.cb202.Location = new System.Drawing.Point(125, 48);
            this.cb202.Name = "cb202";
            this.cb202.Size = new System.Drawing.Size(99, 23);
            this.cb202.TabIndex = 3;
            this.cb202.Text = "海门广本";
            // 
            // cb201
            // 
            this.cb201.Location = new System.Drawing.Point(23, 48);
            this.cb201.Name = "cb201";
            this.cb201.Size = new System.Drawing.Size(96, 23);
            this.cb201.TabIndex = 2;
            this.cb201.Text = "海门别克";
            // 
            // rb_hmno
            // 
            this.rb_hmno.AutoSize = true;
            this.rb_hmno.Location = new System.Drawing.Point(137, 20);
            this.rb_hmno.Name = "rb_hmno";
            this.rb_hmno.Size = new System.Drawing.Size(59, 16);
            this.rb_hmno.TabIndex = 1;
            this.rb_hmno.TabStop = true;
            this.rb_hmno.Text = "全不选";
            this.rb_hmno.UseVisualStyleBackColor = true;
            // 
            // rb_hmall
            // 
            this.rb_hmall.AutoSize = true;
            this.rb_hmall.Location = new System.Drawing.Point(72, 20);
            this.rb_hmall.Name = "rb_hmall";
            this.rb_hmall.Size = new System.Drawing.Size(47, 16);
            this.rb_hmall.TabIndex = 0;
            this.rb_hmall.TabStop = true;
            this.rb_hmall.Text = "全选";
            this.rb_hmall.UseVisualStyleBackColor = true;
            // 
            // gbgys
            // 
            this.gbgys.Controls.Add(this.cb161);
            this.gbgys.Controls.Add(this.cb159);
            this.gbgys.Controls.Add(this.cb160);
            this.gbgys.Controls.Add(this.cb153);
            this.gbgys.Controls.Add(this.cb152);
            this.gbgys.Controls.Add(this.rb_gyno);
            this.gbgys.Controls.Add(this.rb_gyall);
            this.gbgys.Location = new System.Drawing.Point(5, 119);
            this.gbgys.Name = "gbgys";
            this.gbgys.Size = new System.Drawing.Size(585, 88);
            this.gbgys.TabIndex = 1;
            this.gbgys.TabStop = false;
            this.gbgys.Text = "观音山";
            // 
            // cb161
            // 
            this.cb161.Location = new System.Drawing.Point(327, 48);
            this.cb161.Name = "cb161";
            this.cb161.Size = new System.Drawing.Size(116, 23);
            this.cb161.TabIndex = 6;
            this.cb161.Text = "观音山一汽丰田";
            // 
            // cb159
            // 
            this.cb159.Location = new System.Drawing.Point(449, 48);
            this.cb159.Name = "cb159";
            this.cb159.Size = new System.Drawing.Size(100, 23);
            this.cb159.TabIndex = 5;
            this.cb159.Text = "观音山北现代";
            // 
            // cb160
            // 
            this.cb160.Location = new System.Drawing.Point(230, 48);
            this.cb160.Name = "cb160";
            this.cb160.Size = new System.Drawing.Size(91, 23);
            this.cb160.TabIndex = 4;
            this.cb160.Text = "观音山广丰";
            // 
            // cb153
            // 
            this.cb153.Location = new System.Drawing.Point(125, 48);
            this.cb153.Name = "cb153";
            this.cb153.Size = new System.Drawing.Size(99, 23);
            this.cb153.TabIndex = 3;
            this.cb153.Text = "观音山雪佛兰";
            // 
            // cb152
            // 
            this.cb152.Location = new System.Drawing.Point(23, 48);
            this.cb152.Name = "cb152";
            this.cb152.Size = new System.Drawing.Size(96, 23);
            this.cb152.TabIndex = 2;
            this.cb152.Text = "观音山荣威";
            // 
            // rb_gyno
            // 
            this.rb_gyno.AutoSize = true;
            this.rb_gyno.Location = new System.Drawing.Point(137, 20);
            this.rb_gyno.Name = "rb_gyno";
            this.rb_gyno.Size = new System.Drawing.Size(59, 16);
            this.rb_gyno.TabIndex = 1;
            this.rb_gyno.TabStop = true;
            this.rb_gyno.Text = "全不选";
            this.rb_gyno.UseVisualStyleBackColor = true;
            // 
            // rb_gyall
            // 
            this.rb_gyall.AutoSize = true;
            this.rb_gyall.Location = new System.Drawing.Point(72, 20);
            this.rb_gyall.Name = "rb_gyall";
            this.rb_gyall.Size = new System.Drawing.Size(47, 16);
            this.rb_gyall.TabIndex = 0;
            this.rb_gyall.TabStop = true;
            this.rb_gyall.Text = "全选";
            this.rb_gyall.UseVisualStyleBackColor = true;
            // 
            // gbYX
            // 
            this.gbYX.Controls.Add(this.cb352);
            this.gbYX.Controls.Add(this.cb102);
            this.gbYX.Controls.Add(this.cb101);
            this.gbYX.Controls.Add(this.rb_yxno);
            this.gbYX.Controls.Add(this.rb_yxall);
            this.gbYX.Location = new System.Drawing.Point(5, 33);
            this.gbYX.Name = "gbYX";
            this.gbYX.Size = new System.Drawing.Size(585, 80);
            this.gbYX.TabIndex = 0;
            this.gbYX.TabStop = false;
            this.gbYX.Text = "永兴";
            // 
            // cb352
            // 
            this.cb352.Location = new System.Drawing.Point(229, 43);
            this.cb352.Name = "cb352";
            this.cb352.Size = new System.Drawing.Size(75, 23);
            this.cb352.TabIndex = 4;
            this.cb352.Text = "永兴荣威";
            this.cb352.CheckedChanged += new System.EventHandler(this.cb352_CheckedChanged);
            // 
            // cb102
            // 
            this.cb102.Location = new System.Drawing.Point(121, 43);
            this.cb102.Name = "cb102";
            this.cb102.Size = new System.Drawing.Size(75, 23);
            this.cb102.TabIndex = 3;
            this.cb102.Text = "永兴一汽";
            // 
            // cb101
            // 
            this.cb101.Location = new System.Drawing.Point(23, 43);
            this.cb101.Name = "cb101";
            this.cb101.Size = new System.Drawing.Size(75, 23);
            this.cb101.TabIndex = 2;
            this.cb101.Text = "永兴别克";
            // 
            // rb_yxno
            // 
            this.rb_yxno.AutoSize = true;
            this.rb_yxno.Location = new System.Drawing.Point(137, 12);
            this.rb_yxno.Name = "rb_yxno";
            this.rb_yxno.Size = new System.Drawing.Size(59, 16);
            this.rb_yxno.TabIndex = 1;
            this.rb_yxno.Text = "全不选";
            this.rb_yxno.UseVisualStyleBackColor = true;
            // 
            // rb_yxall
            // 
            this.rb_yxall.AutoSize = true;
            this.rb_yxall.Location = new System.Drawing.Point(72, 12);
            this.rb_yxall.Name = "rb_yxall";
            this.rb_yxall.Size = new System.Drawing.Size(47, 16);
            this.rb_yxall.TabIndex = 0;
            this.rb_yxall.Text = "全选";
            this.rb_yxall.UseVisualStyleBackColor = true;
            // 
            // cb258
            // 
            this.cb258.Location = new System.Drawing.Point(121, 49);
            this.cb258.Name = "cb258";
            this.cb258.Size = new System.Drawing.Size(96, 23);
            this.cb258.TabIndex = 3;
            this.cb258.Text = "启东宝马";
            // 
            // cb608
            // 
            this.cb608.Location = new System.Drawing.Point(213, 49);
            this.cb608.Name = "cb608";
            this.cb608.Size = new System.Drawing.Size(96, 23);
            this.cb608.TabIndex = 4;
            this.cb608.Text = "江西奔驰";
            // 
            // frmOrganSel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(594, 492);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gbelse);
            this.Controls.Add(this.gbrd);
            this.Controls.Add(this.gbhm);
            this.Controls.Add(this.gbgys);
            this.Controls.Add(this.gbYX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmOrganSel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "门店选择";
            this.Load += new System.EventHandler(this.frmOrganSel_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbelse.ResumeLayout(false);
            this.gbelse.PerformLayout();
            this.gbrd.ResumeLayout(false);
            this.gbrd.PerformLayout();
            this.gbhm.ResumeLayout(false);
            this.gbhm.PerformLayout();
            this.gbgys.ResumeLayout(false);
            this.gbgys.PerformLayout();
            this.gbYX.ResumeLayout(false);
            this.gbYX.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbYX;
        private System.Windows.Forms.RadioButton rb_yxno;
        private System.Windows.Forms.RadioButton rb_yxall;
        private System.Windows.Forms.GroupBox gbgys;
        private System.Windows.Forms.RadioButton rb_gyno;
        private System.Windows.Forms.RadioButton rb_gyall;
        private DevComponents.DotNetBar.Controls.CheckBoxX cb101;
        private DevComponents.DotNetBar.Controls.CheckBoxX cb102;
        private DevComponents.DotNetBar.Controls.CheckBoxX cb352;
        private DevComponents.DotNetBar.Controls.CheckBoxX cb152;
        private DevComponents.DotNetBar.Controls.CheckBoxX cb153;
        private DevComponents.DotNetBar.Controls.CheckBoxX cb160;
        private DevComponents.DotNetBar.Controls.CheckBoxX cb159;
        private System.Windows.Forms.GroupBox gbhm;
        private DevComponents.DotNetBar.Controls.CheckBoxX cb202;
        private DevComponents.DotNetBar.Controls.CheckBoxX cb201;
        private System.Windows.Forms.RadioButton rb_hmno;
        private System.Windows.Forms.RadioButton rb_hmall;
        private DevComponents.DotNetBar.Controls.CheckBoxX cb206;
        private DevComponents.DotNetBar.Controls.CheckBoxX cb208;
        private DevComponents.DotNetBar.Controls.CheckBoxX cb205;
        private System.Windows.Forms.GroupBox gbrd;
        private System.Windows.Forms.RadioButton rb_rdno;
        private System.Windows.Forms.RadioButton rb_rdall;
        private DevComponents.DotNetBar.Controls.CheckBoxX cb301;
        private System.Windows.Forms.GroupBox gbelse;
        private System.Windows.Forms.RadioButton rb_elseno;
        private System.Windows.Forms.RadioButton rb_elseall;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtAll;
        private System.Windows.Forms.ToolStripButton tbtNo;
        private System.Windows.Forms.ToolStripButton tbtChange;
        private DevComponents.DotNetBar.Controls.CheckBoxX cb161;
        private DevComponents.DotNetBar.Controls.CheckBoxX cb209;
        private DevComponents.DotNetBar.Controls.CheckBoxX cb608;
        private DevComponents.DotNetBar.Controls.CheckBoxX cb258;

    }
}