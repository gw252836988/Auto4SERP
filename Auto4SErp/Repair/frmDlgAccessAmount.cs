using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using Bll.Repair;
using Comm;
using Bll;
namespace Auto4SErp.Repair
{
    public partial class frmDlgAccessAmount : ifrmBase
    {

        private string dH;
        private IRepair mIRepair;
        private IFinance mIFinance;
        public string DH
        {
            get { return dH; }
            set { dH = value; }
        }

        public double AccessAmount
        {
            get;
            set;
        }


        public bool Modify
        {
            get;
            set;
        }
        public frmDlgAccessAmount()
        {
            mIRepair = BllFactory.GetRepariBll();
            mIFinance = BllFactory.GetFinanceBll();
            InitializeComponent();
        }

        private void frmDlgAccessAmount_Load(object sender, EventArgs e)
        {
            SetTButtonPng(toolStrip1);
            dbiAmountRe.Value = AccessAmount;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            decimal accessamount = (decimal)dbiAmountRe.Value;

            mIRepair.ExtractClaimFromRep(dH, accessamount);

            if (!Modify)
                PostFinance();
            Modify = true;
            this.Close();
        }

        private void PostFinance()
        {
            RepairM objRep = mIRepair.GetRepairByDH(dH);
            if (objRep.Status != 1)
            {
                ShowMessage("状态不对，无法预结算");
                return;
            }

            Account obj = new Account();

            obj.DHFrom = dH;

            obj.Describes = "售后";

            obj.CustName = objRep.CustName;
            obj.Mobile = objRep.Mobile;
            obj.PlateNum = objRep.PlateNum;
            mIFinance.AddAmount(obj);
            objRep.DH = dH;
            objRep.Status = 2;
            objRep.GAmount = 0;
            mIRepair.SetRepStatus(objRep);
            decimal GInprice = mIRepair.GetAccInPriceOfDH(dH);
            mIRepair.UpdateSumDataOfRepair(dH, 0, 0, GInprice);



        }
    }
}
