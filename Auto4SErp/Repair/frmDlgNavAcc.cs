using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bll.Repair;
using Model;
namespace Auto4SErp.Repair
{
    public partial class frmDlgNavAcc : ifrmBase
    {
        private IRepairAccessory mIRepair;
        private IAccessory mIAccessory;
        public string AccessoryCode
        {
            get;
            set;
        }
        public frmDlgNavAcc()
        {
            InitializeComponent();
            mIRepair = Bll.BllFactory.GetRepairAccessoryBll();
            mIAccessory = Bll.BllFactory.GetAccessoryBll();
        }

        private void frmDlgNavAcc_Load(object sender, EventArgs e)
        {
            SetTButtonPng(toolStrip1);
            txtAccessoryCode.Text = AccessoryCode;
            LoadExtendContents("仓库名称", cmbHouseName);
            Accessory obj = mIAccessory.GetAccessoryByCode(txtAccessoryCode.Text);
            if (obj != null)
            {
                string strtype = obj.AccessoryType;
                cmbHouseName.Text = strtype + "库";
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (dbiInPrice.Value <= 0)
            {
                ShowMessage("成本价必须大于0");
                return;
            }
            mIRepair.AddAccNavInfo(txtAccessoryCode.Text, dbiInPrice.Value, cmbHouseName.Text);
            this.Close();
        }
    }
}
