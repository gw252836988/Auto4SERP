namespace Auto4SErp.Personnel
{
    partial class frmStaffFunction
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
            this.treeFunction = new DevComponents.AdvTree.AdvTree();
            this.cMenuPositionFunction = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EnableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.pnlPower = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.treeFunction)).BeginInit();
            this.cMenuPositionFunction.SuspendLayout();
            this.SuspendLayout();
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
            this.treeFunction.Size = new System.Drawing.Size(238, 465);
            this.treeFunction.Styles.Add(this.elementStyle1);
            this.treeFunction.TabIndex = 9;
            this.treeFunction.Text = "advTree1";
            this.treeFunction.NodeClick += new DevComponents.AdvTree.TreeNodeMouseEventHandler(this.treeFunction_NodeClick);
            // 
            // cMenuPositionFunction
            // 
            this.cMenuPositionFunction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EnableToolStripMenuItem,
            this.CancelToolStripMenuItem});
            this.cMenuPositionFunction.Name = "cmenuCarDetail";
            this.cMenuPositionFunction.Size = new System.Drawing.Size(101, 48);
            // 
            // EnableToolStripMenuItem
            // 
            this.EnableToolStripMenuItem.Name = "EnableToolStripMenuItem";
            this.EnableToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.EnableToolStripMenuItem.Text = "开启";
            this.EnableToolStripMenuItem.Click += new System.EventHandler(this.EnableToolStripMenuItem_Click);
            // 
            // CancelToolStripMenuItem
            // 
            this.CancelToolStripMenuItem.Name = "CancelToolStripMenuItem";
            this.CancelToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.CancelToolStripMenuItem.Text = "禁用";
            this.CancelToolStripMenuItem.Click += new System.EventHandler(this.CancelToolStripMenuItem_Click);
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
            // pnlPower
            // 
            this.pnlPower.Location = new System.Drawing.Point(266, 99);
            this.pnlPower.Name = "pnlPower";
            this.pnlPower.Size = new System.Drawing.Size(140, 318);
            this.pnlPower.TabIndex = 10;
            // 
            // frmStaffFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 465);
            this.Controls.Add(this.pnlPower);
            this.Controls.Add(this.treeFunction);
            this.Name = "frmStaffFunction";
            this.Text = "员工权限";
            this.Load += new System.EventHandler(this.frmStaffFunction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeFunction)).EndInit();
            this.cMenuPositionFunction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.AdvTree.AdvTree treeFunction;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private System.Windows.Forms.ContextMenuStrip cMenuPositionFunction;
        private System.Windows.Forms.ToolStripMenuItem EnableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CancelToolStripMenuItem;
        private System.Windows.Forms.Panel pnlPower;
    }
}