namespace Auto4SErp.Report
{
    partial class frmRCarInAndOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRCarInAndOut));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnQuery = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudYear = new DevComponents.Editors.IntegerInput();
            this.lblInvoiceType = new DevComponents.DotNetBar.LabelX();
            this.dgInAndOut = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outcount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInAndOut)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnQuery});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(657, 25);
            this.toolStrip1.TabIndex = 44;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudYear);
            this.groupBox1.Controls.Add(this.lblInvoiceType);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 71);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            // 
            // nudYear
            // 
            // 
            // 
            // 
            this.nudYear.BackgroundStyle.Class = "DateTimeInputBackground";
            this.nudYear.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.nudYear.Location = new System.Drawing.Point(111, 26);
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
            this.lblInvoiceType.Location = new System.Drawing.Point(61, 29);
            this.lblInvoiceType.Name = "lblInvoiceType";
            this.lblInvoiceType.Size = new System.Drawing.Size(44, 18);
            this.lblInvoiceType.TabIndex = 17;
            this.lblInvoiceType.Text = "年  份";
            // 
            // dgInAndOut
            // 
            this.dgInAndOut.AllowUserToAddRows = false;
            this.dgInAndOut.AllowUserToDeleteRows = false;
            this.dgInAndOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInAndOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.month,
            this.incount,
            this.inje,
            this.outcount,
            this.outje});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgInAndOut.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgInAndOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgInAndOut.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgInAndOut.Location = new System.Drawing.Point(0, 96);
            this.dgInAndOut.MultiSelect = false;
            this.dgInAndOut.Name = "dgInAndOut";
            this.dgInAndOut.RowTemplate.Height = 23;
            this.dgInAndOut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgInAndOut.Size = new System.Drawing.Size(657, 288);
            this.dgInAndOut.TabIndex = 51;
            // 
            // month
            // 
            this.month.DataPropertyName = "month";
            this.month.HeaderText = "月份";
            this.month.Name = "month";
            // 
            // incount
            // 
            this.incount.DataPropertyName = "incount";
            this.incount.HeaderText = "入库数量";
            this.incount.Name = "incount";
            // 
            // inje
            // 
            this.inje.DataPropertyName = "inje";
            this.inje.HeaderText = "入库金额";
            this.inje.Name = "inje";
            // 
            // outcount
            // 
            this.outcount.DataPropertyName = "outcount";
            this.outcount.HeaderText = "出库数量";
            this.outcount.Name = "outcount";
            // 
            // outje
            // 
            this.outje.DataPropertyName = "outje";
            this.outje.HeaderText = "出库金额";
            this.outje.Name = "outje";
            // 
            // frmRCarInAndOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 384);
            this.Controls.Add(this.dgInAndOut);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmRCarInAndOut";
            this.Text = "整车出入库统计";
            this.Load += new System.EventHandler(this.frmRCarInAndOut_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInAndOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnQuery;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.Editors.IntegerInput nudYear;
        private DevComponents.DotNetBar.LabelX lblInvoiceType;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgInAndOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn month;
        private System.Windows.Forms.DataGridViewTextBoxColumn incount;
        private System.Windows.Forms.DataGridViewTextBoxColumn inje;
        private System.Windows.Forms.DataGridViewTextBoxColumn outcount;
        private System.Windows.Forms.DataGridViewTextBoxColumn outje;
    }
}