﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bll;
using Bll.Repair;
using Auto4SErp.Repair;
namespace Auto4SErp.Report
{
    public partial class frmRWorkHour : ifrmBase
    {

        private IRepair mIRepair;
        private IRepairItem mIRepairItem;
        private DataTable mDt;
        public frmRWorkHour()
        {
            InitializeComponent();
            mIRepair = BllFactory.GetRepariBll();
            mIRepairItem = BllFactory.GetRepairItemBll();
        }

        private void frmRWorkHour_Load(object sender, EventArgs e)
        {
            LoadExtendContents("作业人员", cmbWorkMan);
            cmbWorkMan.SelectedIndex = -1;
            DateTime dtNow = DateTime.Now;
            datBegin.Value = DateTime.Parse(dtNow.Year + "/" + dtNow.Month + "/01 00:00");
            SetTButtonPng(toolStrip1);
        }

        private void tbtnQuery_Click(object sender, EventArgs e)
        {
            DoQuery();
        }


        private void summaryData()
        {
            if (dgSummary.Visible == true)
            {
                dgSummary.Visible = false;
                return;
            }
            if (mDt != null && mDt.Rows.Count > 0)
            {
                dgSummary.Visible = true;
                var summaryDt = mDt.AsEnumerable().GroupBy(m => new { a = m["WorkMan"].ToString() }).Select(k => new { gworkhour = k.Sum(l => decimal.Parse(l["EmpWorkH"].ToString())), emp = k.Max(l => l["WorkMan"]) }).ToList();
                dgSummary.AutoGenerateColumns = false;
                dgSummary.DataSource = summaryDt;
            }


        }
        protected override void DoQuery()
        {
            string strBegin = "";
            string strEnd = "";

            strBegin = datBegin.Value.ToShortDateString() + " 00:00:00";
            strEnd = datEnd.Value.ToShortDateString() + " 23:59:59";

            dgWorkHour.AutoGenerateColumns = false;
            DataTable dt = mIRepair.STEmpWorkHour(strBegin, strEnd, cmbWorkMan.Text, txtItemName.Text);
            dgWorkHour.DataSource = dt;
            mDt = dt;
            DataTable dtResult = mIRepair.GetSumWHofQuery(strBegin, strEnd, cmbWorkMan.Text, txtItemName.Text);


            txtTotalHour.Text = dtResult.Rows[0][0].ToString();
            txtWHJE.Text = dtResult.Rows[0][1].ToString();

        }

        private void btnOut_Click(object sender, EventArgs e)
        {

            string strBegin = "";
            string strEnd = "";

            strBegin = datBegin.Value.ToShortDateString() + " 00:00:00";
            strEnd = datEnd.Value.ToShortDateString() + " 23:59:59";


            DataTable dt = mIRepair.STEmpWorkHour(strBegin, strEnd, cmbWorkMan.Text, txtItemName.Text);

            Comm.ExcelInAndOut io = new Comm.ExcelInAndOut("");
            io.DTOutTo(dt, dgWorkHour);
        }

        private void btnFindItem_Click(object sender, EventArgs e)
        {
            frmRepairItem frm = new frmRepairItem();
            frm.IsSelect = true;
            frm.setTransferDelegate(delegate(object data)
            {
                string str = data.ToString();

                //string[] strlst = str.Split(',');
                string[] tmplst = str.Split(',');
                string item = tmplst[0];
                // string price = tmplst[1];
                txtItemName.Text = item;
                DataTable dtItem = mIRepairItem.GetRepairItemByCode(item);

                if (dtItem.Rows.Count > 0)
                {


                    txtItemName.Text = dtItem.Rows[0]["ItemName"].ToString();
                    //mItemCode = dtItem.Rows[0]["ItemCode"].ToString();
                    //txtItemCode.Text = dtItem.Rows[0]["ItemCode"].ToString();
                }

            });
            frm.ShowDialogEx();
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            summaryData();
        }
    }
}
