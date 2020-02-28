namespace Auto4SErp.Report
{
    partial class frmRPVOfRepair
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRPVOfRepair));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnQuery = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudYear = new DevComponents.Editors.IntegerInput();
            this.chbClaim = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chbRepair = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.lblInvoiceType = new DevComponents.DotNetBar.LabelX();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnQuery});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(787, 25);
            this.toolStrip1.TabIndex = 36;
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
            this.groupBox1.Controls.Add(this.chbClaim);
            this.groupBox1.Controls.Add(this.chbRepair);
            this.groupBox1.Controls.Add(this.lblInvoiceType);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 77);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // nudYear
            // 
            // 
            // 
            // 
            this.nudYear.BackgroundStyle.Class = "DateTimeInputBackground";
            this.nudYear.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.nudYear.Location = new System.Drawing.Point(94, 29);
            this.nudYear.Name = "nudYear";
            this.nudYear.ShowUpDown = true;
            this.nudYear.Size = new System.Drawing.Size(80, 21);
            this.nudYear.TabIndex = 17;
            // 
            // chbClaim
            // 
            this.chbClaim.AutoSize = true;
            this.chbClaim.Location = new System.Drawing.Point(307, 32);
            this.chbClaim.Name = "chbClaim";
            this.chbClaim.Size = new System.Drawing.Size(51, 18);
            this.chbClaim.TabIndex = 16;
            this.chbClaim.Text = "索赔";
            // 
            // chbRepair
            // 
            this.chbRepair.AutoSize = true;
            this.chbRepair.Checked = true;
            this.chbRepair.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbRepair.CheckValue = "Y";
            this.chbRepair.Location = new System.Drawing.Point(230, 33);
            this.chbRepair.Name = "chbRepair";
            this.chbRepair.Size = new System.Drawing.Size(51, 18);
            this.chbRepair.TabIndex = 15;
            this.chbRepair.Text = "维修";
            // 
            // lblInvoiceType
            // 
            this.lblInvoiceType.AutoSize = true;
            this.lblInvoiceType.Location = new System.Drawing.Point(57, 33);
            this.lblInvoiceType.Name = "lblInvoiceType";
            this.lblInvoiceType.Size = new System.Drawing.Size(31, 18);
            this.lblInvoiceType.TabIndex = 13;
            this.lblInvoiceType.Text = "年份";
            // 
            // chart1
            // 
            chartArea3.AxisX.Interval = 1D;
            chartArea3.AxisX.IntervalOffset = 1D;
            chartArea3.AxisX.MajorGrid.LineWidth = 0;
            chartArea3.AxisX.Title = "月份";
            chartArea3.AxisY.Title = "产值";
            chartArea3.BorderColor = System.Drawing.Color.White;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(0, 102);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.IsValueShownAsLabel = true;
            series3.IsXValueIndexed = true;
            series3.Legend = "Legend1";
            series3.Name = "售后产值";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(787, 324);
            this.chart1.TabIndex = 41;
            this.chart1.Text = "chart1";
            // 
            // frmRPVOfRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 426);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmRPVOfRepair";
            this.Text = "售后产值统计";
            this.Load += new System.EventHandler(this.frmRPVOfRepair_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnQuery;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.LabelX lblInvoiceType;
        private DevComponents.DotNetBar.Controls.CheckBoxX chbClaim;
        private DevComponents.DotNetBar.Controls.CheckBoxX chbRepair;
        private DevComponents.Editors.IntegerInput nudYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;

    }
}