namespace Auto4SErp
{
    partial class FrmDepartment
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepartment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbModity = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.treeDepart = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.dgvDepart = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmModifty = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeDepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepart)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbModity,
            this.tsbDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(822, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(36, 22);
            this.tsbAdd.Text = "增加";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
        
            // 
            // treeDepart
            // 
            this.treeDepart.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.treeDepart.AllowDrop = true;
            this.treeDepart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeDepart.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.treeDepart.BackgroundStyle.Class = "TreeBorderKey";
            this.treeDepart.ContextMenuStrip = this.contextMenuStrip1;
            this.treeDepart.Location = new System.Drawing.Point(0, 28);
            this.treeDepart.Name = "treeDepart";
            this.treeDepart.NodesConnector = this.nodeConnector1;
            this.treeDepart.NodeStyle = this.elementStyle1;
            this.treeDepart.PathSeparator = ";";
            this.treeDepart.Size = new System.Drawing.Size(150, 375);
            this.treeDepart.Styles.Add(this.elementStyle1);
            this.treeDepart.TabIndex = 1;
            this.treeDepart.Text = "advTree1";
            this.treeDepart.SelectedIndexChanged += new System.EventHandler(this.treeDepart_SelectedIndexChanged);
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle1
            // 
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // dgvDepart
            // 
            this.dgvDepart.AllowUserToAddRows = false;
            this.dgvDepart.AllowUserToDeleteRows = false;
            this.dgvDepart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDepart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDepart.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDepart.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDepart.Location = new System.Drawing.Point(157, 29);
            this.dgvDepart.Name = "dgvDepart";
            this.dgvDepart.ReadOnly = true;
            this.dgvDepart.RowTemplate.Height = 23;
            this.dgvDepart.Size = new System.Drawing.Size(665, 374);
            this.dgvDepart.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmModifty,
            this.tsmDel});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // tsmModifty
            // 
            this.tsmModifty.Name = "tsmModifty";
            this.tsmModifty.Size = new System.Drawing.Size(152, 22);
            this.tsmModifty.Text = "修改";
            this.tsmModifty.Click += new System.EventHandler(this.tsmModifty_Click);
            // 
            // tsmDel
            // 
            this.tsmDel.Name = "tsmDel";
            this.tsmDel.Size = new System.Drawing.Size(152, 22);
            this.tsmDel.Text = "删除";
            this.tsmDel.Click += new System.EventHandler(this.tsmDel_Click);
            // 
            // FrmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 401);
            this.Controls.Add(this.dgvDepart);
            this.Controls.Add(this.treeDepart);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmDepartment";
            this.Text = "部门";
            this.Load += new System.EventHandler(this.FrmDepartment_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeDepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepart)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private DevComponents.AdvTree.AdvTree treeDepart;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDepart;
        private System.Windows.Forms.ToolStripButton tsbModity;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmModifty;
        private System.Windows.Forms.ToolStripMenuItem tsmDel;
    }
}