using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Bll.Repair;

//test
namespace Auto4SErp.Repair
{
    public partial class frmAccDemandDlg : ifrmBase
    {

        private IRepairAccessory mIRepairAccessory;
        private string xH;
        private IAccessory mIAccessory;
        public string XH
        {
            get { return xH; }
            set { xH = value; }
        }

        private string dH;

        public string DH
        {
            get { return dH; }
            set { dH = value; }
        }


        private string accessoryName;

        public string AccessoryName
        {
            get { return accessoryName; }
            set { accessoryName = value; }
        }

        public frmAccDemandDlg()
        {
            InitializeComponent();
            mIRepairAccessory = Bll.BllFactory.GetRepairAccessoryBll();
            mIAccessory = Bll.BllFactory.GetAccessoryBll();
        }

        private void frmAccDemandDlg_Load(object sender, EventArgs e)
        {
            AccessoryOfRep obj = mIRepairAccessory.GetAccessoryOfRep(xH, dH);
            if (obj != null)
            {
                txtAccessoryCode.Text = obj.AccessoryCode;
                txtAccessoryName.Text = accessoryName;
                dbiSalePrice.Value = (double)obj.SalePrice;
                dbiAmount.Value = (double)obj.Amount;

            }
            SetTButtonPng(toolStrip1);

        }

        private void btnOK_Click(object sender, EventArgs e)
        {


            AccessoryOfRep obj = new AccessoryOfRep();
            obj.XH = xH;
            obj.DH = dH;
            obj.Amount = (float)dbiAmount.Value;
            obj.SalePrice = (float)dbiSalePrice.Value;
            //if (!mIAccessory.CheckStore(txtAccessoryCode.Text, obj.Amount))
            //{
            //    ShowMessage("库存不足");
            //    return;
            //}

            obj.FinalPrice = (float)dbiSalePrice.Value;
            obj.Discount = -1;
            mIRepairAccessory.UpdateAccessoryOfRepair(obj);
            IsModify = true;
            this.Close();
        }
    }
}
