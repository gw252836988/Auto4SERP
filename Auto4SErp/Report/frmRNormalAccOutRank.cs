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
namespace Auto4SErp.Report
{
    public partial class frmRNormalAccOutRank : ifrmBase
    {

        private IAccessory mIAccessory;
        public frmRNormalAccOutRank()
        {
            InitializeComponent();
            mIAccessory = Bll.BllFactory.GetAccessoryBll();
        }

        private void tbtnQuery_Click(object sender, EventArgs e)
        {
            DoQuery();
        }


        protected override void DoQuery()
        {
            string strBegin = "";
            string strEnd = "";


            if (chbIsDate.Checked)
            {
                strBegin = datBegin.Value.ToShortDateString() + " 00:00:00";
                strEnd = datEnd.Value.ToShortDateString() + " 23:59:59";
            }


            dgOutWareRec.AutoGenerateColumns = false;
            DataTable dt = mIAccessory.GetNormalAccOutRank(cmbHouseName.Text, txtAccessoryCode.Text, strBegin, strEnd, chbClaim.Checked);
            dgOutWareRec.DataSource = dt;

            decimal suminprice = dt.AsEnumerable().Sum(r => decimal.Parse(r[6].ToString()));
            decimal sumsaleprice = dt.AsEnumerable().Sum(r => decimal.Parse(r[7].ToString()));
            decimal sum = dt.AsEnumerable().Sum(r => (decimal.Parse(r[3].ToString())));
            lblSum.Text = string.Format("总数量:{2},总成本价:{0},总销售价{1}", suminprice, sumsaleprice, sum);
        }

        private void frmRNormalAccOutRank_Load(object sender, EventArgs e)
        {
            DateTime dtNow = DateTime.Now;
            datBegin.Value = DateTime.Parse(dtNow.Year + "/" + dtNow.Month + "/01 00:00");
            LoadExtendContents("仓库名称", cmbHouseName);
            cmbHouseName.SelectedIndex = -1;
            SetTButtonPng(toolStrip1);
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            ExcelInAndOut eio = new ExcelInAndOut("");
            //eio.Title = "维修查询";
            // DataTable dt = dgRepair.DataSource as DataTable;
            // Comm.ExcelInAndOut io = new Comm.ExcelInAndOut("");
            // dt.

            //eio.DTOutTo(dt,dgCarSale);
            eio.NewDTOutTo((DataGridView)dgOutWareRec);
        }


    }
}
