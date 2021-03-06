﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bll;
using Model;
using Comm;
using Auto4SErp.Cust;
namespace Auto4SErp
{
    public partial class frmDlgPreRecv : ifrmBase
    {
        //  private ICustomer mICustomer;
        private IFinance mIFinance;
        private string mobile;
        private ICustomer mICustomer;
        public string Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }
        private string custname;

        public string Custname
        {
            get { return custname; }
            set { custname = value; }
        }
        public frmDlgPreRecv()
        {
            InitializeComponent();
            //   mICustomer = Bll.BllFactory.GetCustomerBll();
            mIFinance = Bll.BllFactory.GetFinanceBll();
            mICustomer = Bll.BllFactory.GetCustomerBll();
        }

        private void tbtnOK_Click(object sender, EventArgs e)
        {
            if (dbiPreRecv.Value > 0)
            {
                mIFinance.AddPreRecv(mobile, custname, dbiPreRecv.Value);

                Account obj = new Account();
                obj.Mobile = mobile;
                obj.Amount = dbiPreRecv.Value;
                obj.DHFrom = "";
                obj.Describes = "充预收款";
                obj.CustName = custname;
                obj.ReceiveMan = Comm.LoginInfoShare.getInstance().UserName;
                obj.AcceptDate = DateTime.Now.ToString();
                if (cmbType.SelectedIndex == 0)
                {
                    obj.Cash = dbiPreRecv.Value;
                    obj.Bank = 0;
                }
                else
                {
                    obj.Bank = dbiPreRecv.Value;
                    obj.Cash = 0;
                }
                mIFinance.AddAccountOfRec(obj);
                IsModify = true;
                ShowMessage("冲款成款");

                this.Close();
            }
        }

        private void frmDlgPreRecv_Load(object sender, EventArgs e)
        {
            cmbType.SelectedIndex = 0;
            txtMobile.Text = mobile;

            txtCustName.Text = custname;
            SetTButtonPng(toolStrip1);
        }

        private void btnCustomerFind_Click(object sender, EventArgs e)
        {
            frmCustomerQuery frm = new frmCustomerQuery();
            frm.IsSelect = true;
            frm.IsRepair = true;

            frm.setTransferDelegate(delegate(object o)
            {
                string strResult = (string)o;
                string[] strlst = strResult.Split(',');
                mobile = strlst[0];
                Customer objcust = mICustomer.GetCustomerByMobile(mobile);
                custname = objcust.CustName;
                txtCustName.Text = custname;
                txtMobile.Text = mobile;


            });
            frm.ShowDialogEx();
        }
    }
}
