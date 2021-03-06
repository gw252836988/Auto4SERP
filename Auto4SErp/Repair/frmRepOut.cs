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
using Bll.Repair;
namespace Auto4SErp.Repair
{
    public partial class frmRepOut : ifrmBase
    {
        private IRepair mIRepair;
        public frmRepOut()
        {
            InitializeComponent();
            mIRepair = Bll.BllFactory.GetRepariBll();
            tsbFirst = bindingNavigatorMoveFirstItem;
            tsbLast = bindingNavigatorMoveLastItem;
            tsbPre = bindingNavigatorMovePreviousItem;
            tsbNext = bindingNavigatorMoveNextItem;
            tstbPageCount = bindingNavigatorCountItem;
            tstbPageCurrent = bindingNavigatorPositionItem;
            tstbRecordCount = bindingNavigatorRecordCount;
        }

        private void frmRepOutcs_Load(object sender, EventArgs e)
        {
            SetTButtonPng(toolStrip1);
            cmbOutType.SelectedIndex = 0;
            DateTime dtNow = DateTime.Now;
            datBegin.Value = DateTime.Parse(dtNow.Year + "-" + dtNow.Month + "-01");
            DoQuery();
        }


        protected override void DoQuery()
        {
            DataTable dt;
            string strBegin = "";
            string strEnd = "";
            int tmpRecordCount;
            int tmpPageCount;

            strBegin = datBegin.Value.ToShortDateString() + " 00:00:00";
            strEnd = datEnd.Value.ToShortDateString() + " 23:59:59";


            dt = mIRepair.GetRepairsOfOut(strBegin, strEnd, txtPlateNum.Text, cmbOutType.Text, mPageInfo.PageCurrent, mPageInfo.PageSize, out tmpRecordCount, out tmpPageCount);
            DataToControl(dt);
            mPageInfo.RecordCount = tmpRecordCount;
            mPageInfo.PageCount = tmpPageCount;
            SetRoleNavigatorState();


        }
        private void DataToControl(DataTable dt)
        {
            dgRepair.AutoGenerateColumns = false;
            dgRepair.DataSource = dt;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DoQuery();
        }

        private void cmbOutType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOutType.SelectedIndex == 0)
                btnOut.Enabled = true;
            else
                btnOut.Enabled = false;

        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            if (ShowMessageOfWarning("该车确认放行吗") == DialogResult.OK)
            {
                if (dgRepair.SelectedRows.Count != 0)
                {
                    DataGridViewRow seldr = dgRepair.SelectedRows[0];
                    //DataGridViewCell dr = seldr.Cells[0];
                    string strdh = seldr.Cells["dh"].Value.ToString();
                    mIRepair.SetRepOut(strdh);
                    DoQuery();
                }

            }

        }

    }
}
