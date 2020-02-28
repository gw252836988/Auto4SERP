namespace Auto4SErp
{
    partial class frmDlgCarSuperSel
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
            this.treeCarDoc = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            ((System.ComponentModel.ISupportInitialize)(this.treeCarDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // treeCarDoc
            // 
            this.treeCarDoc.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.treeCarDoc.AllowDrop = true;
            this.treeCarDoc.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.treeCarDoc.BackgroundStyle.Class = "TreeBorderKey";
            this.treeCarDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeCarDoc.Location = new System.Drawing.Point(0, 0);
            this.treeCarDoc.Name = "treeCarDoc";
            this.treeCarDoc.NodesConnector = this.nodeConnector1;
            this.treeCarDoc.NodeStyle = this.elementStyle1;
            this.treeCarDoc.PathSeparator = ";";
            this.treeCarDoc.Size = new System.Drawing.Size(215, 407);
            this.treeCarDoc.Styles.Add(this.elementStyle1);
            this.treeCarDoc.TabIndex = 1;
            this.treeCarDoc.Text = "advTree1";
            this.treeCarDoc.NodeDoubleClick += new DevComponents.AdvTree.TreeNodeMouseEventHandler(this.treeCarDoc_NodeDoubleClick);
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
            // frmDlgCarSuperSel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 407);
            this.Controls.Add(this.treeCarDoc);
            this.Name = "frmDlgCarSuperSel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmDlgCarSuperSel";
            this.Load += new System.EventHandler(this.frmDlgCarSuperSel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeCarDoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.AdvTree.AdvTree treeCarDoc;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
    }
}