namespace Auto4SErp.Personnel
{
    partial class frmPositionFunction
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cMenuPositionFunction = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EnableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EnableAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeFunction = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.dgPosition = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PositionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartMentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMenuPositionFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // cMenuPositionFunction
            // 
            this.cMenuPositionFunction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EnableToolStripMenuItem,
            this.EnableAllToolStripMenuItem,
            this.CancelToolStripMenuItem,
            this.CancelAllToolStripMenuItem});
            this.cMenuPositionFunction.Name = "cmenuCarDetail";
            this.cMenuPositionFunction.Size = new System.Drawing.Size(149, 92);
            // 
            // EnableToolStripMenuItem
            // 
            this.EnableToolStripMenuItem.Name = "EnableToolStripMenuItem";
            this.EnableToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.EnableToolStripMenuItem.Text = "开启";
            this.EnableToolStripMenuItem.Click += new System.EventHandler(this.EnableToolStripMenuItem_Click);
            // 
            // EnableAllToolStripMenuItem
            // 
            this.EnableAllToolStripMenuItem.Name = "EnableAllToolStripMenuItem";
            this.EnableAllToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.EnableAllToolStripMenuItem.Text = "开启全部子项";
            this.EnableAllToolStripMenuItem.Click += new System.EventHandler(this.EnableAllToolStripMenuItem_Click);
            // 
            // CancelToolStripMenuItem
            // 
            this.CancelToolStripMenuItem.Name = "CancelToolStripMenuItem";
            this.CancelToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.CancelToolStripMenuItem.Text = "禁用";
            this.CancelToolStripMenuItem.Click += new System.EventHandler(this.CancelToolStripMenuItem_Click);
            // 
            // CancelAllToolStripMenuItem
            // 
            this.CancelAllToolStripMenuItem.Name = "CancelAllToolStripMenuItem";
            this.CancelAllToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.CancelAllToolStripMenuItem.Text = "禁用全部子项";
            this.CancelAllToolStripMenuItem.Click += new System.EventHandler(this.CancelAllToolStripMenuItem_Click);
            // 
            // treeFunction
            // 
            this.treeFunction.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.treeFunction.AllowDrop = true;
            this.treeFunction.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.treeFunction.BackgroundStyle.Class = "TreeBorderKey";
            this.treeFunction.ContextMenuStrip = this.cMenuPositionFunction;
            this.treeFunction.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeFunction.Location = new System.Drawing.Point(0, 0);
            this.treeFunction.Name = "treeFunction";
            this.treeFunction.NodesConnector = this.nodeConnector1;
            this.treeFunction.NodeStyle = this.elementStyle1;
            this.treeFunction.PathSeparator = ";";
            this.treeFunction.Size = new System.Drawing.Size(161, 412);
            this.treeFunction.Styles.Add(this.elementStyle1);
            this.treeFunction.TabIndex = 8;
            this.treeFunction.Text = "advTree1";
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
            // dgPosition
            // 
            this.dgPosition.AllowUserToAddRows = false;
            this.dgPosition.AllowUserToDeleteRows = false;
            this.dgPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPosition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PositionName,
            this.DepartmentID,
            this.DepartMentName});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPosition.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPosition.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgPosition.Location = new System.Drawing.Point(161, 0);
            this.dgPosition.MultiSelect = false;
            this.dgPosition.Name = "dgPosition";
            this.dgPosition.RowHeadersVisible = false;
            this.dgPosition.RowTemplate.Height = 23;
            this.dgPosition.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPosition.Size = new System.Drawing.Size(482, 412);
            this.dgPosition.TabIndex = 40;
            this.dgPosition.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPosition_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "职位编号";
            this.ID.Name = "ID";
            // 
            // PositionName
            // 
            this.PositionName.DataPropertyName = "PositionName";
            this.PositionName.HeaderText = "职位名称";
            this.PositionName.Name = "PositionName";
            // 
            // DepartmentID
            // 
            this.DepartmentID.DataPropertyName = "DepartmentID";
            this.DepartmentID.HeaderText = "部门编号";
            this.DepartmentID.Name = "DepartmentID";
            // 
            // DepartMentName
            // 
            this.DepartMentName.DataPropertyName = "DepartMentName";
            this.DepartMentName.HeaderText = "部门名称";
            this.DepartMentName.Name = "DepartMentName";
            // 
            // frmPositionFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 412);
            this.Controls.Add(this.dgPosition);
            this.Controls.Add(this.treeFunction);
            this.Name = "frmPositionFunction";
            this.Text = "职位权限";
            this.Load += new System.EventHandler(this.frmPositionFunction_Load);
            this.cMenuPositionFunction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPosition)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.AdvTree.AdvTree treeFunction;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private System.Windows.Forms.ContextMenuStrip cMenuPositionFunction;
        private System.Windows.Forms.ToolStripMenuItem EnableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EnableAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CancelAllToolStripMenuItem;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartMentName;
    }
}