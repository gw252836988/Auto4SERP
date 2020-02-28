namespace Auto4SErp.GroupReport
{
    partial class frmGVisitYear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGVisitYear));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnQuery = new System.Windows.Forms.ToolStripButton();
            this.btnSelOrgan = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudYear = new DevComponents.Editors.IntegerInput();
            this.lblInvoiceType = new DevComponents.DotNetBar.LabelX();
            this.dgVisit = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dgSum = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tlblConsume = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblerror = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVisit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSum)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnQuery,
            this.btnSelOrgan});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(690, 25);
            this.toolStrip1.TabIndex = 43;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnQuery
            // 
            this.tbtnQuery.Image = ((System.Drawing.Image)(resources.GetObject("tbtnQuery.Image")));
            this.tbtnQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnQuery.Name = "tbtnQuery";
            this.tbtnQuery.Size = new System.Drawing.Size(52, 22);
            this.tbtnQuery.Tag = "query";
            this.tbtnQuery.Text = "查询";
            this.tbtnQuery.Click += new System.EventHandler(this.tbtnQuery_Click);
            // 
            // btnSelOrgan
            // 
            this.btnSelOrgan.Image = ((System.Drawing.Image)(resources.GetObject("btnSelOrgan.Image")));
            this.btnSelOrgan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelOrgan.Name = "btnSelOrgan";
            this.btnSelOrgan.Size = new System.Drawing.Size(76, 22);
            this.btnSelOrgan.Tag = "select";
            this.btnSelOrgan.Text = "选择机构";
            this.btnSelOrgan.Click += new System.EventHandler(this.btnSelOrgan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudYear);
            this.groupBox1.Controls.Add(this.lblInvoiceType);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 71);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // nudYear
            // 
            // 
            // 
            // 
            this.nudYear.BackgroundStyle.Class = "DateTimeInputBackground";
            this.nudYear.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.nudYear.Location = new System.Drawing.Point(86, 28);
            this.nudYear.MaxValue = 9999;
            this.nudYear.MinValue = 0;
            this.nudYear.Name = "nudYear";
            this.nudYear.ShowUpDown = true;
            this.nudYear.Size = new System.Drawing.Size(80, 21);
            this.nudYear.TabIndex = 22;
            // 
            // lblInvoiceType
            // 
            this.lblInvoiceType.AutoSize = true;
            this.lblInvoiceType.Location = new System.Drawing.Point(49, 31);
            this.lblInvoiceType.Name = "lblInvoiceType";
            this.lblInvoiceType.Size = new System.Drawing.Size(31, 18);
            this.lblInvoiceType.TabIndex = 17;
            this.lblInvoiceType.Text = "年份";
            // 
            // dgVisit
            // 
            this.dgVisit.AllowUserToAddRows = false;
            this.dgVisit.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVisit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgVisit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgVisit.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgVisit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgVisit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgVisit.Location = new System.Drawing.Point(0, 96);
            this.dgVisit.MultiSelect = false;
            this.dgVisit.Name = "dgVisit";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVisit.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgVisit.RowTemplate.Height = 23;
            this.dgVisit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVisit.Size = new System.Drawing.Size(690, 303);
            this.dgVisit.TabIndex = 50;
            // 
            // dgSum
            // 
            this.dgSum.AllowUserToAddRows = false;
            this.dgSum.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSum.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgSum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgSum.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgSum.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgSum.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgSum.Location = new System.Drawing.Point(0, 283);
            this.dgSum.MultiSelect = false;
            this.dgSum.Name = "dgSum";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSum.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgSum.RowTemplate.Height = 23;
            this.dgSum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSum.Size = new System.Drawing.Size(690, 94);
            this.dgSum.TabIndex = 51;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlblConsume,
            this.lblerror});
            this.statusStrip1.Location = new System.Drawing.Point(0, 377);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(690, 22);
            this.statusStrip1.TabIndex = 52;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tlblConsume
            // 
            this.tlblConsume.Name = "tlblConsume";
            this.tlblConsume.Size = new System.Drawing.Size(0, 17);
            // 
            // lblerror
            // 
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 17);
            // 
            // frmGVisitYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 399);
            this.Controls.Add(this.dgSum);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgVisit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmGVisitYear";
            this.Text = "来访数年统计";
            this.Load += new System.EventHandler(this.frmGVisitYear_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVisit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSum)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnQuery;
        private System.Windows.Forms.ToolStripButton btnSelOrgan;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.Editors.IntegerInput nudYear;
        private DevComponents.DotNetBar.LabelX lblInvoiceType;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgVisit;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgSum;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tlblConsume;
        private System.Windows.Forms.ToolStripStatusLabel lblerror;
    }
}