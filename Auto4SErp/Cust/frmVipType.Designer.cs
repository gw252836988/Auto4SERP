namespace Auto4SErp.Cust
{
    partial class frmVipType
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgVipType = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.VipTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VipTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValidityDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgVipType)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVipType
            // 
            this.dgVipType.AllowUserToAddRows = false;
            this.dgVipType.AllowUserToDeleteRows = false;
            this.dgVipType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVipType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VipTypeID,
            this.VipTypeName,
            this.ValidityDate,
            this.ItemDiscount,
            this.AccDiscount});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgVipType.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgVipType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgVipType.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgVipType.Location = new System.Drawing.Point(0, 0);
            this.dgVipType.MultiSelect = false;
            this.dgVipType.Name = "dgVipType";
            this.dgVipType.RowTemplate.Height = 23;
            this.dgVipType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVipType.Size = new System.Drawing.Size(638, 333);
            this.dgVipType.TabIndex = 33;
            // 
            // VipTypeID
            // 
            this.VipTypeID.DataPropertyName = "VipTypeID";
            this.VipTypeID.HeaderText = "类型编号";
            this.VipTypeID.Name = "VipTypeID";
            // 
            // VipTypeName
            // 
            this.VipTypeName.DataPropertyName = "VipTypeName";
            this.VipTypeName.HeaderText = "类型名称";
            this.VipTypeName.Name = "VipTypeName";
            // 
            // ValidityDate
            // 
            this.ValidityDate.DataPropertyName = "ValidityDate";
            this.ValidityDate.HeaderText = "有效日期";
            this.ValidityDate.Name = "ValidityDate";
            // 
            // ItemDiscount
            // 
            this.ItemDiscount.DataPropertyName = "ItemDiscount";
            this.ItemDiscount.HeaderText = "项目折扣";
            this.ItemDiscount.Name = "ItemDiscount";
            // 
            // AccDiscount
            // 
            this.AccDiscount.DataPropertyName = "AccDiscount";
            this.AccDiscount.HeaderText = "材料折扣";
            this.AccDiscount.Name = "AccDiscount";
            // 
            // frmVipType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 333);
            this.Controls.Add(this.dgVipType);
            this.Name = "frmVipType";
            this.Text = "会员类型";
            this.Load += new System.EventHandler(this.frmVipType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVipType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgVipType;
        private System.Windows.Forms.DataGridViewTextBoxColumn VipTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VipTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValidityDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccDiscount;
    }
}