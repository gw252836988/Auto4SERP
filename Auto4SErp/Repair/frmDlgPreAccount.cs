﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bll.Repair;

using Model;
using Bll;
namespace Auto4SErp.Repair
{
    public partial class frmDlgPreAccount : ifrmBase
    {

        private float mGAmount;
        private float mItemAmount;
        private float mAccAmount;
        private IRepair mIRepair;
        private string dH;
        private IFinance mIFinance;
        private string repChildType;
        private decimal mGInprice;
        public string RepChildType
        {
            get { return repChildType; }
            set { repChildType = value; }
        }

        public string DH
        {
            get { return dH; }
            set { dH = value; }
        }

        private double balance = 0;

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        private string vip;

        public string Vip
        {
            get { return vip; }
            set { vip = value; }
        }
        public frmDlgPreAccount()
        {
            mIRepair = BllFactory.GetRepariBll();
            mIFinance = Bll.BllFactory.GetFinanceBll();
            InitializeComponent();
        }

        private void frmDlgPreAccount_Load(object sender, EventArgs e)
        {
            mItemAmount = mIRepair.GetItemAmountOfDH(dH);
            if (repChildType.Equals("销售装潢") || repChildType.Equals("原厂装潢"))
                mAccAmount = mIRepair.GetAccDemandAmountOfDH(dH);
            else
                mAccAmount = mIRepair.GetAccAmountOfDH(dH);
            mGInprice = mIRepair.GetAccInPriceOfDH(dH);
            txtAccAmount.Text = mAccAmount.ToString();
            txtItemAmount.Text = mItemAmount.ToString();
            mGAmount = mItemAmount + mAccAmount;
            txtGAmount.Text = mGAmount.ToString();
            //去零
            // int finalprice = (int)mGAmount;
            double finalprice;

            finalprice = Math.Round(mGAmount, MidpointRounding.AwayFromZero);


            //double  finalprice =
            if (!"161".Contains(Comm.LoginInfoShare.getInstance().OrganId))
                txtFinalPrice.Text = finalprice.ToString();
            else
                txtFinalPrice.Text = mGAmount.ToString();
            //RepairM obj=mIRepair.GetRepairByDH(dH);
            SetTButtonPng(toolStrip1);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {


            //判断是否能会员打折消费

            if (vip != "非会员")
            {
                if (mIRepair.IsDiscountOfDH(dH))
                {
                    if (balance < mGAmount)
                    {
                        ShowMessage("会员余额不足，请撤销打折");
                        return;
                    }

                }
            }
            RepairM objRep = mIRepair.GetRepairByDH(dH);
            if (objRep.Status != 1)
            {
                ShowMessage("状态不对，无法预结算");
                return;
            }
            DelChange();
            Account obj = new Account();
            if (!"161".Contains(Comm.LoginInfoShare.getInstance().OrganId))
                obj.Amount = float.Parse(txtFinalPrice.Text);
            else
                obj.Amount = mGAmount;
            obj.DHFrom = dH;
            if (repChildType == "销售装潢" || repChildType == "原厂装潢")
                obj.Describes = repChildType;
            else
                obj.Describes = "售后";

            obj.CustName = objRep.CustName;
            obj.Mobile = objRep.Mobile;
            obj.PlateNum = objRep.PlateNum;
            mIFinance.AddAmount(obj);

            objRep.DH = dH;
            objRep.Status = 2;
            if (!"161".Contains(Comm.LoginInfoShare.getInstance().OrganId))
                objRep.GAmount = float.Parse(txtFinalPrice.Text);
            else
                objRep.GAmount = mGAmount;
            mIRepair.SetRepStatus(objRep);
            mIRepair.UpdateSumDataOfRepair(dH, mAccAmount, mItemAmount, mGInprice);

            IsModify = true;
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            double fprice = double.Parse(txtFinalPrice.Text);
            fprice = Math.Floor(fprice);
            int fi;
            fi = (int)fprice;
            int tmp = 0;

            tmp = (fi - fi / 10 * 10);
            fi = fi - tmp;
            txtFinalPrice.Text = fi.ToString();

        }

        private void DelChange()
        {
            double fprice = double.Parse(txtFinalPrice.Text);
            fprice = Math.Floor(fprice);
            txtFinalPrice.Text = fprice.ToString();

        }
    }
}
