﻿using System;
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


namespace Auto4SErp.Repair
{
    public partial class frmDlgClaimEdit : ifrmBase
    {

        private IClaim mIClaim;
        public frmDlgClaimEdit()
        {
            InitializeComponent();
            mIClaim = Bll.BllFactory.GetClaimBll();
        }

        //private string iD;

        //public string ID
        //{
        //    get { return iD; }
        //    set { iD = value; }
        //}

        private string dH;

        public string DH
        {
            get { return dH; }
            set { dH = value; }
        }
        private void frmDlgClaimEdit_Load(object sender, EventArgs e)
        {
            DataTable dt = mIClaim.GetClaim(dH);

            if (dt.Rows.Count > 0)
            {
                txtRepDH.Text = dt.Rows[0]["RepDH"].ToString();
                txtAccountDate.Text = dt.Rows[0]["AccountDate"].ToString();
                txtReceptMan.Text = dt.Rows[0]["ReceptMan"].ToString();
                txtPlateNum.Text = dt.Rows[0]["PlateNum"].ToString();
                txtCustName.Text = dt.Rows[0]["CustName"].ToString();
                txtVin.Text = dt.Rows[0]["Vin"].ToString();
                txtPostMan.Text = dt.Rows[0]["PostMan"].ToString();
                txtAccessDate.Text = dt.Rows[0]["AccessDate"].ToString();
                txtCaimDH.Text = dt.Rows[0]["ClaimDH"].ToString();
                dbiElseAmount.Value = double.Parse(dt.Rows[0]["ElseAmount"].ToString());
                dbiAccAmount.Value = double.Parse(dt.Rows[0]["AccAmount"].ToString());
                dbiItemAmount.Value = double.Parse(dt.Rows[0]["ItemAmount"].ToString());
                dbiClaimAmount.Value = double.Parse(dt.Rows[0]["ClaimAmount"].ToString());
                if (string.IsNullOrEmpty(dt.Rows[0]["AccessAmount"].ToString()))
                    dbiAccessAmount.Value = 0;
                else
                    dbiAccessAmount.Value = double.Parse(dt.Rows[0]["AccessAmount"].ToString());


            }
            SetTButtonPng(toolStrip1);
        }

        private void dbiElseAmount_ValueChanged(object sender, EventArgs e)
        {
            dbiClaimAmount.Value = dbiAccAmount.Value + dbiItemAmount.Value + dbiElseAmount.Value;

        }

        private void tbtnOK_Click(object sender, EventArgs e)
        {
            DataTable dt = mIClaim.GetClaim(dH);
            if (dt.Rows[0]["BillDH"].ToString().Length < 1)
            {
                mIClaim.UpdateClaim(txtRepDH.Text, txtCaimDH.Text, dbiItemAmount.Value, dbiAccAmount.Value, dbiElseAmount.Value, dbiClaimAmount.Value);
                ShowMessage("修改成功");
            }
            else
                ShowMessage("该单据已开票");
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            DataTable dt = mIClaim.GetClaim(dH);
            if (dt.Rows[0]["BillDH"].ToString().Length < 1)
            {
                mIClaim.AccessClaim(txtRepDH.Text, dbiAccessAmount.Value);
                ShowMessage("索赔通过");
            }
            else
                ShowMessage("该单据已开票");
        }

        private void dbiItemAmount_ValueChanged(object sender, EventArgs e)
        {
            dbiClaimAmount.Value = dbiAccAmount.Value + dbiItemAmount.Value + dbiElseAmount.Value;
        }

        private void dbiAccAmount_ValueChanged(object sender, EventArgs e)
        {
            dbiClaimAmount.Value = dbiAccAmount.Value + dbiItemAmount.Value + dbiElseAmount.Value;
        }

        private void dbiClaimAmount_ValueChanged(object sender, EventArgs e)
        {
            dbiTax.Value = dbiClaimAmount.Value * 0.16;
            dbiTotal.Value = dbiClaimAmount.Value * 1.16;
        }
    }
}
